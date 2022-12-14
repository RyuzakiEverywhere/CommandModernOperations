using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using LZ4;
using Microsoft.VisualBasic;
using ns13;
using ns29;
using SevenZip;

namespace Command_Core
{
	// Token: 0x0200031F RID: 799
	[Serializable]
	public sealed class ScenContainer
	{
		// Token: 0x06001793 RID: 6035 RVA: 0x001ADF14 File Offset: 0x001AC114
		public static ScenContainer smethod_0(string string_0)
		{
			ScenContainer result;
			try
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(ScenContainer));
				StringReader stringReader = new StringReader(string_0);
				XmlTextReader xmlTextReader = new XmlTextReader(stringReader);
				ScenContainer scenContainer = (ScenContainer)xmlSerializer.Deserialize(xmlTextReader);
				xmlTextReader.Close();
				stringReader.Close();
				result = scenContainer;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101047", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x001ADFA4 File Offset: 0x001AC1A4
		public static string smethod_1(string string_0, string string_1)
		{
			XmlTextReader xmlTextReader = new XmlTextReader(string_0);
			string result;
			using (xmlTextReader)
			{
				if (xmlTextReader.ReadToDescendant(string_1))
				{
					result = xmlTextReader.ReadElementContentAsString();
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x001ADFEC File Offset: 0x001AC1EC
		public string method_0()
		{
			Class2234 @class = new Class2234();
			byte[] byte_ = new byte[this.Scenario_Compressed.Length + 1];
			byte_ = this.Scenario_Compressed;
			byte[] array = @class.method_9(byte_, 0, 0, 0);
			int num = array.Length - 1;
			while (array[num] == 0)
			{
				num--;
			}
			byte[] array2 = new byte[num + 1 + 1];
			Array.Copy(array, array2, num + 1);
			array = array2;
			array = Misc.smethod_4(array);
			array = Misc.smethod_6(array);
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x001AE064 File Offset: 0x001AC264
		public string method_1()
		{
			MemoryStream archiveStream = new MemoryStream(this.Scenario_Compressed);
			MemoryStream memoryStream = new MemoryStream();
			new SevenZipExtractor(archiveStream, GameGeneral.string_3).ExtractFile(0, memoryStream);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			byte[] array = memoryStream.ToArray();
			array = Misc.smethod_4(array);
			array = Misc.smethod_6(array);
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x001AE0CC File Offset: 0x001AC2CC
		public void method_2()
		{
			MemoryStream memoryStream = GameGeneral.smethod_11(this.ScenarioObject);
			this.CompressVersion = 1;
			try
			{
				this.Scenario_Compressed = Class430.smethod_1(memoryStream, Enum179.const_4);
			}
			catch (OutOfMemoryException ex)
			{
				GameGeneral.smethod_10();
				this.Scenario_Compressed = Class430.smethod_1(memoryStream, Enum179.const_4);
			}
			memoryStream.Close();
			memoryStream = null;
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x001AE134 File Offset: 0x001AC334
		public void method_3()
		{
			MemoryStream memoryStream = GameGeneral.smethod_11(this.ScenarioObject);
			this.CompressVersion = 2;
			try
			{
				MemoryStream memoryStream2 = Class430.smethod_0(memoryStream, CompressionLevel.High);
				this.Scenario_Compressed = memoryStream2.ToArray();
			}
			catch (OutOfMemoryException ex)
			{
				GameGeneral.smethod_10();
				MemoryStream memoryStream2 = Class430.smethod_0(memoryStream, CompressionLevel.High);
				this.Scenario_Compressed = memoryStream2.ToArray();
			}
			memoryStream.Close();
			memoryStream = null;
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x001AE1AC File Offset: 0x001AC3AC
		public void method_4(Stream stream_0)
		{
			try
			{
				this.method_10(stream_0);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200055", ex.Message);
				GameGeneral.smethod_25(ref ex);
			}
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x001AE200 File Offset: 0x001AC400
		public void method_5(string theFileName, bool PreserveOriginalTimestamps = false)
		{
			if (this.Scenario_Compressed == null)
			{
				try
				{
					if (GameGeneral.bool_4)
					{
						this.method_3();
					}
					else
					{
						try
						{
							this.method_9();
						}
						catch (OutOfMemoryException ex)
						{
							GameGeneral.smethod_10();
							this.method_9();
						}
					}
				}
				catch (Exception ex2)
				{
					this.method_2();
					ex2.Data.Add("Error at 200056", ex2.Message);
					GameGeneral.smethod_25(ref ex2);
				}
			}
			this.ScenarioObject = null;
			bool flag = false;
			DateTime creationTime;
			DateTime lastWriteTime;
			DateTime lastAccessTime;
			if (PreserveOriginalTimestamps && File.Exists(theFileName))
			{
				flag = true;
				FileInfo fileInfo = new FileInfo(theFileName);
				creationTime = fileInfo.CreationTime;
				lastWriteTime = fileInfo.LastWriteTime;
				lastAccessTime = fileInfo.LastAccessTime;
			}
			FileStream fileStream = new FileStream(theFileName, FileMode.Create);
			new XmlSerializer(base.GetType()).Serialize(fileStream, this);
			fileStream.Close();
			if (PreserveOriginalTimestamps && flag)
			{
				FileInfo fileInfo2 = new FileInfo(theFileName);
				fileInfo2.CreationTime = creationTime;
				fileInfo2.LastWriteTime = lastWriteTime;
				fileInfo2.LastAccessTime = lastAccessTime;
			}
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x001AE310 File Offset: 0x001AC510
		public override string ToString()
		{
			MemoryStream memoryStream = this.method_6();
			string result = Misc.smethod_45(memoryStream);
			memoryStream.Dispose();
			return result;
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x001AE330 File Offset: 0x001AC530
		private MemoryStream method_6()
		{
			if (Information.IsNothing(this.Scenario_Compressed))
			{
				try
				{
					if (GameGeneral.bool_4)
					{
						this.method_3();
					}
					else
					{
						try
						{
							this.method_9();
						}
						catch (OutOfMemoryException ex)
						{
							GameGeneral.smethod_10();
							this.method_9();
						}
					}
				}
				catch (Exception ex2)
				{
					this.method_2();
					ex2.Data.Add("Error at 200057", ex2.Message);
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
			this.ScenarioObject = null;
			MemoryStream memoryStream = new MemoryStream();
			new XmlSerializer(typeof(ScenContainer)).Serialize(memoryStream, this);
			return memoryStream;
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x001AE3FC File Offset: 0x001AC5FC
		public static ScenContainer smethod_2(string string_0)
		{
			ScenContainer result;
			try
			{
				new FileInfo(string_0);
				ScenContainer scenContainer = new ScenContainer(null);
				FileStream fileStream = new FileStream(string_0, FileMode.Open);
				scenContainer = (ScenContainer)new XmlSerializer(scenContainer.GetType()).Deserialize(fileStream);
				fileStream.Close();
				result = scenContainer;
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x001AE468 File Offset: 0x001AC668
		public string method_7()
		{
			string result = "";
			switch (this.CompressVersion)
			{
			case 1:
				result = this.method_0();
				break;
			case 2:
				result = this.method_1();
				break;
			case 3:
				result = Class431.smethod_1(this.method_0(), GameGeneral.string_3);
				break;
			case 5:
				result = this.method_11();
				break;
			}
			return result;
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0000C5F3 File Offset: 0x0000A7F3
		public Scenario method_8(ref string string_0, ref double double_0, bool bool_0)
		{
			return Scenario.smethod_19(this.method_7(), ref string_0, ref double_0, bool_0, true);
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x001AE4D0 File Offset: 0x001AC6D0
		public ScenContainer(Scenario scenario_0)
		{
			this.CompressVersion = 1;
			this.IsCampaignCheckpoint = false;
			this.ScenarioObject = scenario_0;
			if (!Information.IsNothing(scenario_0))
			{
				if (!Information.IsNothing(scenario_0.method_0()))
				{
					this.ScenTitle = scenario_0.method_0().ToString();
				}
				if (!Information.IsNothing(scenario_0.method_4()))
				{
					this.ScenDescription = scenario_0.method_4().ToString();
				}
				this.Complexity = scenario_0.Meta_Complexity;
				this.Difficulty = scenario_0.Meta_Difficulty;
				this.ScenSetting = scenario_0.Meta_ScenSetting;
				string theHash = scenario_0.method_7();
				DBOps.DBFileCheckResult dbfileCheckResult = DBOps.DBFileCheckResult.Undefined;
				DBRecord dbrecord = DBOps.smethod_10(theHash, ref dbfileCheckResult, true, true);
				if (!Information.IsNothing(dbrecord))
				{
					this.DBVersion = dbrecord.string_2;
				}
			}
			else
			{
				this.Complexity = 1;
				this.Difficulty = 1;
				this.ScenSetting = "Not set";
			}
			this.BuildNumber = "1115.6";
			this.Version = GameGeneral.smethod_2();
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0000C604 File Offset: 0x0000A804
		public ScenContainer()
		{
			this.CompressVersion = 1;
			this.IsCampaignCheckpoint = false;
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x001AE5BC File Offset: 0x001AC7BC
		public void method_9()
		{
			this.CompressVersion = 5;
			RijndaelManaged rijndaelManaged = ScenContainer.smethod_3();
			using (MemoryStream memoryStream = GameGeneral.smethod_11(this.ScenarioObject))
			{
				using (MemoryStream memoryStream2 = Class430.smethod_2(memoryStream))
				{
					memoryStream2.Seek(0L, SeekOrigin.Begin);
					ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					using (MemoryStream memoryStream3 = new MemoryStream())
					{
						memoryStream3.Write(BitConverter.GetBytes(rijndaelManaged.IV.Length), 0, 4);
						memoryStream3.Write(rijndaelManaged.IV, 0, rijndaelManaged.IV.Length);
						using (CryptoStream cryptoStream = new CryptoStream(memoryStream3, transform, CryptoStreamMode.Write))
						{
							memoryStream2.CopyTo(cryptoStream);
						}
						this.Scenario_Compressed = memoryStream3.ToArray();
					}
				}
			}
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x001AE6C4 File Offset: 0x001AC8C4
		public void method_10(Stream stream_0)
		{
			this.CompressVersion = 5;
			RijndaelManaged rijndaelManaged = ScenContainer.smethod_3();
			try
			{
				using (MemoryStream memoryStream = Class430.smethod_2(stream_0))
				{
					memoryStream.Seek(0L, SeekOrigin.Begin);
					ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					using (MemoryStream memoryStream2 = new MemoryStream())
					{
						memoryStream2.Write(BitConverter.GetBytes(rijndaelManaged.IV.Length), 0, 4);
						memoryStream2.Write(rijndaelManaged.IV, 0, rijndaelManaged.IV.Length);
						using (CryptoStream cryptoStream = new CryptoStream(memoryStream2, transform, CryptoStreamMode.Write))
						{
							memoryStream.CopyTo(cryptoStream);
						}
						this.Scenario_Compressed = memoryStream2.ToArray();
					}
				}
			}
			finally
			{
				if (stream_0 != null)
				{
					((IDisposable)stream_0).Dispose();
				}
			}
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x001AE7C4 File Offset: 0x001AC9C4
		private static RijndaelManaged smethod_3()
		{
			byte[] bytes = Encoding.ASCII.GetBytes("Eg:ù2à[kÝB{ãÞ¬KîâÉ{µ\\µ¥¤4´J»ãvaWÀó±òÈV:£W-(Èª|cêI¹");
			string password = "âcI}´EjÆãoµËÛÞwÿë6ØçÌP«4lWT¶-áòêªÓb¶þ×r2Z,¬}¶üÿTYá^¦¯H%ÿºÂOð=_Û^&¬oÚýª~ÁtÂRëg{Ñ§kA«Õº½Ë¥PÊ+jbo<_ù¨xKUíTïBGÙøªçäð(tX`íÅuÉù³l(¶WØ$ëèw¬¦ÇJ|Z©*.¼ÏÒ_<·UP=W²üßå3ÂOºÃo_¤«ì8G2¶/R¬mo;>YwsÿJS}W£1ãC?ÍREÚâÙLK¬ä%¡X>ÀZÉUïdp¿o/uÕfé>ÄC©ñ)á6T~åÜ¡9>/ÚÑ«Wl£ÈÄëw{úupU®1ìU%0µõ¨";
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, bytes);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.KeySize / 8.0));
			return rijndaelManaged;
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x001AE828 File Offset: 0x001ACA28
		public string method_11()
		{
			string @string;
			using (MemoryStream memoryStream = new MemoryStream(this.Scenario_Compressed))
			{
				using (MemoryStream memoryStream2 = new MemoryStream())
				{
					RijndaelManaged rijndaelManaged = ScenContainer.smethod_3();
					byte[] array = new byte[4];
					memoryStream.Read(array, 0, array.Length);
					byte[] array2 = new byte[BitConverter.ToInt32(array, 0) - 1 + 1];
					memoryStream.Read(array2, 0, array2.Length);
					rijndaelManaged.IV = array2;
					ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
					{
						using (LZ4Stream lz4Stream = new LZ4Stream(cryptoStream, LZ4StreamMode.Decompress, LZ4StreamFlags.IsolateInnerStream, 1048576))
						{
							lz4Stream.CopyTo(memoryStream2);
						}
					}
					memoryStream2.Seek(0L, SeekOrigin.Begin);
					byte[] array3 = memoryStream2.ToArray();
					array3 = Misc.smethod_4(array3);
					array3 = Misc.smethod_6(array3);
					@string = Encoding.UTF8.GetString(array3);
				}
			}
			return @string;
		}

		// Token: 0x040014B8 RID: 5304
		public string ScenTitle;

		// Token: 0x040014B9 RID: 5305
		public string ScenDescription;

		// Token: 0x040014BA RID: 5306
		public string ScenAuthor;

		// Token: 0x040014BB RID: 5307
		public short Complexity;

		// Token: 0x040014BC RID: 5308
		public short Difficulty;

		// Token: 0x040014BD RID: 5309
		public string ScenSetting;

		// Token: 0x040014BE RID: 5310
		public short ScenDate;

		// Token: 0x040014BF RID: 5311
		public string DBVersion;

		// Token: 0x040014C0 RID: 5312
		private Scenario ScenarioObject;

		// Token: 0x040014C1 RID: 5313
		public byte[] Scenario_Compressed;

		// Token: 0x040014C2 RID: 5314
		public int CompressVersion;

		// Token: 0x040014C3 RID: 5315
		[XmlElement("BuildNumber", IsNullable = true)]
		public string BuildNumber;

		// Token: 0x040014C4 RID: 5316
		[XmlElement("Version", IsNullable = true)]
		public string Version;

		// Token: 0x040014C5 RID: 5317
		public bool IsCampaignCheckpoint;

		// Token: 0x040014C6 RID: 5318
		public long SaveCurrentTime;

		// Token: 0x040014C7 RID: 5319
		public string CampaignID;

		// Token: 0x040014C8 RID: 5320
		public string CampaignSessionID;
	}
}
