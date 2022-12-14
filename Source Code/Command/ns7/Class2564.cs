using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns5;

namespace ns7
{
	// Token: 0x02000F4A RID: 3914
	[StandardModule]
	internal sealed class Class2564
	{
		// Token: 0x06008C16 RID: 35862 RVA: 0x004B6CB4 File Offset: 0x004B4EB4
		public static BitmapImage smethod_0(string string_1)
		{
			Class2564.Class2565 @class = new Class2564.Class2565();
			@class.string_0 = string_1;
			BitmapImage result;
			if (Class2564.dictionary_0.ContainsKey(@class.string_0))
			{
				result = Class2564.dictionary_0[@class.string_0];
			}
			else
			{
				if (!Directory.Exists(Path.GetDirectoryName(@class.string_0)))
				{
					Directory.CreateDirectory(Path.GetDirectoryName(@class.string_0));
				}
				if (File.Exists(@class.string_0))
				{
					try
					{
						BitmapImage bitmapImage = new BitmapImage(new Uri(@class.string_0));
						Class2564.dictionary_0[@class.string_0] = bitmapImage;
						return bitmapImage;
					}
					catch (Exception ex)
					{
						return result;
					}
				}
				Task.Factory.StartNew(new Action(@class.method_0));
				result = null;
			}
			return result;
		}

		// Token: 0x06008C17 RID: 35863 RVA: 0x000539E7 File Offset: 0x00051BE7
		public static void smethod_1()
		{
			Class2564.string_0 = Class570.smethod_4();
		}

		// Token: 0x06008C18 RID: 35864 RVA: 0x004B6D84 File Offset: 0x004B4F84
		public static string smethod_2(ActiveUnit activeUnit_0)
		{
			string str;
			if (activeUnit_0.bool_3)
			{
				str = "Aircraft";
			}
			else if (activeUnit_0.bool_6)
			{
				str = "Ship";
			}
			else if (activeUnit_0.bool_5)
			{
				str = "Submarine";
			}
			else if (activeUnit_0.bool_8)
			{
				str = "Facility";
			}
			else if (activeUnit_0.method_1())
			{
				str = "Satellite";
			}
			else
			{
				if (!activeUnit_0.bool_2)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					return string.Empty;
				}
				str = "Weapon";
			}
			string str2 = "";
			switch (DBOps.smethod_10(activeUnit_0.scenario_0.method_7(), ref Class2564.dbfileCheckResult_0, false, false).DBID)
			{
			case 1:
				str2 = "DB3000";
				break;
			case 2:
				str2 = "CWDB";
				break;
			case 3:
				str2 = "WW2DB";
				break;
			}
			string text = Class2413.smethod_1().Info.DirectoryPath + "\\DB\\Images\\" + str2;
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			return Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + ".jpg");
		}

		// Token: 0x06008C19 RID: 35865 RVA: 0x004B6EA4 File Offset: 0x004B50A4
		public static List<string> smethod_3(ActiveUnit activeUnit_0)
		{
			string str;
			if (activeUnit_0.bool_3)
			{
				str = "Aircraft";
			}
			else if (activeUnit_0.bool_6)
			{
				str = "Ship";
			}
			else if (activeUnit_0.bool_5)
			{
				str = "Submarine";
			}
			else if (activeUnit_0.bool_8)
			{
				str = "Facility";
			}
			else if (activeUnit_0.method_1())
			{
				str = "Satellite";
			}
			else
			{
				if (!activeUnit_0.bool_2)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					return new List<string>();
				}
				str = "Weapon";
			}
			string str2 = "";
			switch (DBOps.smethod_10(activeUnit_0.scenario_0.method_7(), ref Class2564.dbfileCheckResult_0, false, false).DBID)
			{
			case 1:
				str2 = "DB3000";
				break;
			case 2:
				str2 = "CWDB";
				break;
			case 3:
				str2 = "WW2DB";
				break;
			}
			string text = Class2413.smethod_1().Info.DirectoryPath + "\\DB\\Images\\" + str2;
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string item = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + "_t1.jpg");
			string item2 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + "_t2.jpg");
			string item3 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + "_t3.jpg");
			string item4 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + "_t4.jpg");
			string item5 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + "_t5.jpg");
			string item6 = Path.Combine(text, str + "_" + Conversions.ToString(activeUnit_0.DBID) + "_t6.jpg");
			return new List<string>
			{
				item,
				item2,
				item3,
				item4,
				item5,
				item6
			};
		}

		// Token: 0x06008C1A RID: 35866 RVA: 0x004B70AC File Offset: 0x004B52AC
		public static void smethod_4(Scenario scenario_0)
		{
			List<ActiveUnit> list = Enumerable.ToList<ActiveUnit>(scenario_0.vmethod_0().Values);
			HashSet<string> hashSet = new HashSet<string>();
			try
			{
				foreach (ActiveUnit activeUnit in list)
				{
					if (!activeUnit.bool_1)
					{
						hashSet.Add(Class2564.smethod_2(activeUnit));
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (ActiveUnit activeUnit2 in list)
				{
					if (!activeUnit2.bool_1)
					{
						List<string> list2 = Class2564.smethod_3(activeUnit2);
						try
						{
							foreach (string text in list2)
							{
								hashSet.Add(text);
							}
						}
						finally
						{
							List<string>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			try
			{
				foreach (string text2 in hashSet)
				{
					if (!File.Exists(text2))
					{
						try
						{
							Class2564.smethod_5(text2);
						}
						catch (Exception ex)
						{
						}
					}
				}
			}
			finally
			{
				HashSet<string>.Enumerator enumerator4;
				enumerator4.Dispose();
			}
		}

		// Token: 0x06008C1B RID: 35867 RVA: 0x004B7214 File Offset: 0x004B5414
		public static void smethod_5(string string_1)
		{
			if (InternetConnectivityCheck.bool_0)
			{
				int num = Class2564.string_0.Length;
				string text;
				if (num != 0)
				{
					if (num != 1)
					{
						text = Class2564.string_0[new Random().Next(0, Class2564.string_0.Length)];
					}
					else
					{
						text = Class2564.string_0[0];
					}
				}
				else
				{
					text = "http://warfaresims.slitherine.com/DBImages";
				}
				string fileName = Path.GetFileName(Path.GetDirectoryName(string_1));
				Uri address = new Uri(string.Concat(new string[]
				{
					text,
					"/",
					fileName,
					"/",
					Path.GetFileName(string_1)
				}));
				try
				{
					new WebClient().DownloadFile(address, string_1);
					if (new FileInfo(string_1).Length == 79413L)
					{
						try
						{
							File.Delete(string_1);
						}
						catch (Exception ex)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
					}
				}
				catch (WebException ex2)
				{
					try
					{
						File.Delete(string_1);
					}
					catch (Exception ex3)
					{
						bool isAttached = Debugger.IsAttached;
					}
				}
			}
		}

		// Token: 0x06008C1C RID: 35868 RVA: 0x004B7340 File Offset: 0x004B5540
		public static BitmapImage smethod_6(string string_1)
		{
			BitmapImage result;
			if (!InternetConnectivityCheck.bool_0)
			{
				result = null;
			}
			else
			{
				int num = Class2564.string_0.Length;
				string text;
				if (num != 0)
				{
					if (num != 1)
					{
						text = Class2564.string_0[new Random().Next(0, Class2564.string_0.Length)];
					}
					else
					{
						text = Class2564.string_0[0];
					}
				}
				else
				{
					text = "http://warfaresims.slitherine.com/DBImages";
				}
				string fileName = Path.GetFileName(Path.GetDirectoryName(string_1));
				Uri address = new Uri(string.Concat(new string[]
				{
					text,
					"/",
					fileName,
					"/",
					Path.GetFileName(string_1)
				}));
				try
				{
					new WebClient().DownloadFile(address, string_1);
					if (new FileInfo(string_1).Length == 79413L)
					{
						try
						{
							File.Delete(string_1);
						}
						catch (Exception ex)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
					}
					if (File.Exists(string_1))
					{
						result = new BitmapImage(new Uri(string_1));
					}
					else
					{
						result = null;
					}
				}
				catch (WebException ex2)
				{
					try
					{
						File.Delete(string_1);
					}
					catch (Exception ex3)
					{
						bool isAttached = Debugger.IsAttached;
					}
					result = null;
				}
			}
			return result;
		}

		// Token: 0x04004BEC RID: 19436
		private static Dictionary<string, BitmapImage> dictionary_0 = new Dictionary<string, BitmapImage>();

		// Token: 0x04004BED RID: 19437
		private static string[] string_0;

		// Token: 0x04004BEE RID: 19438
		private static DBOps.DBFileCheckResult dbfileCheckResult_0;

		// Token: 0x02000F4B RID: 3915
		[CompilerGenerated]
		internal sealed class Class2565
		{
			// Token: 0x06008C1E RID: 35870 RVA: 0x000539F3 File Offset: 0x00051BF3
			internal void method_0()
			{
				Class2564.smethod_5(this.string_0);
			}

			// Token: 0x04004BEF RID: 19439
			public string string_0;
		}
	}
}
