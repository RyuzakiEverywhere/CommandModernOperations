using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns12;
using ns13;
using ns9;

namespace Command_Core
{
	// Token: 0x020003A3 RID: 931
	[StandardModule]
	public sealed class DBOps
	{
		// Token: 0x06001C7C RID: 7292 RVA: 0x0000DF6B File Offset: 0x0000C16B
		// Note: this type is marked as 'beforefieldinit'.
		static DBOps()
		{
			DBOps.smethod_1(new ObservableDictionary<string, DBRecord>());
			DBOps.dictionary_0 = new Dictionary<string, DBRecord>();
			DBOps.bool_0 = false;
			DBOps.bool_1 = false;
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0000DF8D File Offset: 0x0000C18D
		[CompilerGenerated]
		private static ObservableDictionary<string, DBRecord> smethod_0()
		{
			return DBOps.observableDictionary_0;
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0020BBC0 File Offset: 0x00209DC0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void smethod_1(ObservableDictionary<string, DBRecord> observableDictionary_1)
		{
			INotifyDictionaryChanged<string, DBRecord>.DictionaryChangedEventHandler obj = new INotifyDictionaryChanged<string, DBRecord>.DictionaryChangedEventHandler(DBOps.smethod_5);
			ObservableDictionary<string, DBRecord> observableDictionary = DBOps.observableDictionary_0;
			if (observableDictionary != null)
			{
				observableDictionary.DictionaryChanged -= obj;
			}
			DBOps.observableDictionary_0 = observableDictionary_1;
			observableDictionary = DBOps.observableDictionary_0;
			if (observableDictionary != null)
			{
				observableDictionary.DictionaryChanged += obj;
			}
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x0020BC00 File Offset: 0x00209E00
		[CompilerGenerated]
		public static void smethod_2(DBOps.Delegate56 delegate56_1)
		{
			DBOps.Delegate56 @delegate = DBOps.delegate56_0;
			DBOps.Delegate56 delegate2;
			do
			{
				delegate2 = @delegate;
				DBOps.Delegate56 value = (DBOps.Delegate56)Delegate.Combine(delegate2, delegate56_1);
				@delegate = Interlocked.CompareExchange<DBOps.Delegate56>(ref DBOps.delegate56_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x0020BC34 File Offset: 0x00209E34
		public static DBOps.Enum134 smethod_3(string string_0, string string_1)
		{
			DBOps.Enum134 result;
			if (Operators.CompareString(string_0, string_1, false) == 0)
			{
				result = DBOps.Enum134.const_1;
			}
			else
			{
				DBOps.DBFileCheckResult dbfileCheckResult;
				DBRecord dbrecord = DBOps.smethod_10(string_0, ref dbfileCheckResult, false, false);
				if (dbrecord == null)
				{
					result = DBOps.Enum134.const_4;
				}
				else
				{
					DBRecord dbrecord2 = DBOps.smethod_10(string_1, ref dbfileCheckResult, false, false);
					if (dbrecord2 == null)
					{
						result = DBOps.Enum134.const_4;
					}
					else if (dbrecord.DBID == dbrecord2.DBID)
					{
						result = DBOps.Enum134.const_2;
					}
					else
					{
						result = DBOps.Enum134.const_3;
					}
				}
			}
			return result;
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x0000DF94 File Offset: 0x0000C194
		public static ReadOnlyCollection<DBRecord> smethod_4()
		{
			List<DBRecord> list = new List<DBRecord>();
			list.AddRange(DBOps.smethod_0().Values);
			return list.AsReadOnly();
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0000378C File Offset: 0x0000198C
		private static void smethod_5(object sender, NotifyDictionaryChangedEventArgs<string, DBRecord> e)
		{
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0020BC88 File Offset: 0x00209E88
		public static void smethod_6()
		{
			string directoryPath = Class160.smethod_1().Info.DirectoryPath;
			DBOps.smethod_15();
			DBOps.bool_0 = true;
			if (DBOps.bool_2)
			{
				DBOps.smethod_14(directoryPath);
			}
			DBOps.bool_1 = true;
			DBOps.Delegate56 @delegate = DBOps.delegate56_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0020BCD4 File Offset: 0x00209ED4
		public static string smethod_7(DBOps.DBFileCheckResult dbfileCheckResult_0)
		{
			DBOps.DBFileCheckResult dbfileCheckResult = dbfileCheckResult_0;
			string result;
			switch (dbfileCheckResult)
			{
			case DBOps.DBFileCheckResult.Undefined:
				result = "Undefined result";
				break;
			case DBOps.DBFileCheckResult.AllOK:
				result = "Everything OK";
				break;
			case DBOps.DBFileCheckResult.DBFileNotPresent:
				result = "Database file was not found - Please contact the database author to obtain a copy of this version of the database";
				break;
			case DBOps.DBFileCheckResult.DBIsUnregistered:
				result = "Database is unregistered";
				break;
			case DBOps.DBFileCheckResult.DBFileIsTampered:
				result = "The database file has been tampered";
				break;
			default:
				if (dbfileCheckResult != DBOps.DBFileCheckResult.UnspecifiedError)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = dbfileCheckResult_0.ToString();
				}
				else
				{
					result = "Unspecified error";
				}
				break;
			}
			return result;
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0020BD50 File Offset: 0x00209F50
		private static XmlDocument smethod_8()
		{
			XmlDocument result;
			if (!Information.IsNothing(DBOps.xmlDocument_0))
			{
				result = DBOps.xmlDocument_0;
			}
			else
			{
				StreamReader streamReader = new StreamReader(Path.Combine(GameGeneral.string_7, "DBInfo.dat"));
				string text;
				using (streamReader)
				{
					text = streamReader.ReadToEnd();
				}
				text = Class431.smethod_1(text, "");
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(text);
				DBOps.xmlDocument_0 = xmlDocument;
				result = xmlDocument;
			}
			return result;
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0020BDCC File Offset: 0x00209FCC
		public static bool smethod_9(DBRecord dbrecord_0)
		{
			string left = Class431.smethod_3(Path.Combine(GameGeneral.string_7, dbrecord_0.string_2));
			string string_ = dbrecord_0.string_0;
			return Operators.CompareString(left, string_, false) != 0;
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0020BE00 File Offset: 0x0020A000
		public static DBRecord smethod_10(string theHash, ref DBOps.DBFileCheckResult theResult, bool CheckLocalFileExists = true, bool CheckForTampering = true)
		{
			DBRecord result;
			try
			{
				DBRecord dbrecord;
				if (DBOps.smethod_0().ContainsKey(theHash))
				{
					dbrecord = DBOps.smethod_0()[theHash];
				}
				else
				{
					if (!DBOps.bool_2)
					{
						theResult = DBOps.DBFileCheckResult.DBIsUnregistered;
						return null;
					}
					dbrecord = DBOps.dictionary_0[theHash];
				}
				if (CheckLocalFileExists && !dbrecord.method_2())
				{
					theResult = DBOps.DBFileCheckResult.DBFileNotPresent;
					result = null;
				}
				else if (CheckForTampering && (DBOps.smethod_9(dbrecord) & !DBOps.bool_2))
				{
					theResult = DBOps.DBFileCheckResult.DBFileIsTampered;
					result = null;
				}
				else
				{
					theResult = DBOps.DBFileCheckResult.AllOK;
					result = dbrecord;
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				theResult = DBOps.DBFileCheckResult.UnspecifiedError;
				result = null;
			}
			return result;
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0020BEAC File Offset: 0x0020A0AC
		public static ValueTuple<DBRecord, DBOps.DBFileCheckResult> smethod_11(string string_0, bool bool_3)
		{
			ValueTuple<DBRecord, DBOps.DBFileCheckResult> result;
			try
			{
				try
				{
					foreach (DBRecord dbrecord in DBOps.smethod_0().Values)
					{
						if (Operators.CompareString(dbrecord.string_2, Path.GetFileName(string_0), false) == 0)
						{
							return new ValueTuple<DBRecord, DBOps.DBFileCheckResult>(dbrecord, DBOps.DBFileCheckResult.AllOK);
						}
					}
				}
				finally
				{
					IEnumerator<DBRecord> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (bool_3)
				{
					try
					{
						foreach (DBRecord dbrecord in DBOps.dictionary_0.Values)
						{
							if (Operators.CompareString(dbrecord.string_2, Path.GetFileName(string_0), false) == 0)
							{
								return new ValueTuple<DBRecord, DBOps.DBFileCheckResult>(dbrecord, DBOps.DBFileCheckResult.DBIsUnregistered);
							}
						}
					}
					finally
					{
						Dictionary<string, DBRecord>.ValueCollection.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					result = new ValueTuple<DBRecord, DBOps.DBFileCheckResult>(null, DBOps.DBFileCheckResult.DBFileNotPresent);
				}
				else
				{
					result = new ValueTuple<DBRecord, DBOps.DBFileCheckResult>(null, DBOps.DBFileCheckResult.DBIsUnregistered);
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ValueTuple<DBRecord, DBOps.DBFileCheckResult>(null, DBOps.DBFileCheckResult.UnspecifiedError);
			}
			return result;
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0020BFC4 File Offset: 0x0020A1C4
		public static string smethod_12(int int_0)
		{
			while (DBOps.smethod_0().Count == 0)
			{
				Thread.Sleep(100);
			}
			try
			{
				Dictionary<string, DBRecord> dictionary = new Dictionary<string, DBRecord>();
				try
				{
					foreach (KeyValuePair<string, DBRecord> keyValuePair in DBOps.smethod_0())
					{
						dictionary.Add(keyValuePair.Key, keyValuePair.Value);
					}
				}
				finally
				{
					IEnumerator<KeyValuePair<string, DBRecord>> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				IOrderedEnumerable<KeyValuePair<string, DBRecord>> orderedEnumerable = Enumerable.OrderByDescending<KeyValuePair<string, DBRecord>, DateTime>(dictionary, (DBOps._Closure$__.$I33-0 == null) ? (DBOps._Closure$__.$I33-0 = new Func<KeyValuePair<string, DBRecord>, DateTime>(DBOps._Closure$__.$I.method_0)) : DBOps._Closure$__.$I33-0);
				try
				{
					foreach (KeyValuePair<string, DBRecord> keyValuePair2 in orderedEnumerable)
					{
						if ((keyValuePair2.Value.DBID == int_0 || GameGeneral.smethod_6()) && keyValuePair2.Value.method_2())
						{
							return keyValuePair2.Key;
						}
					}
				}
				finally
				{
					IEnumerator<KeyValuePair<string, DBRecord>> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			throw new Exception("No DB versions were found for this ID number!");
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0020C100 File Offset: 0x0020A300
		public static string smethod_13(string string_0, string string_1)
		{
			bool flag = false;
			DBRecord dbrecord = null;
			string result;
			try
			{
				if (DBOps.smethod_0().ContainsKey(string_1))
				{
					flag = true;
					dbrecord = DBOps.smethod_0()[string_1];
				}
				if (DBOps.dictionary_0.ContainsKey(string_1))
				{
					dbrecord = DBOps.dictionary_0[string_1];
				}
				if (Information.IsNothing(dbrecord))
				{
					throw new Exception2("You have (explicitly or implicitly) attempted to load a database that does not exist on the DB folder.");
				}
				if (!dbrecord.method_2())
				{
					string text = "You have (explicitly or implicitly) attempted to load a database that does not exist on the DB folder. ";
					if (flag)
					{
						text = text + "The database is registered under the name: " + dbrecord.string_1 + ". Please contact the author of this database for a copy.";
					}
					else
					{
						text = text + "The database is unregistered, and has the file hash: " + string_1 + ". Please contact the DB authors to see if any of their DB versions corresponds to this hash, in order to obtain it.";
					}
					throw new Exception2(text);
				}
				result = dbrecord.method_3();
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

		// Token: 0x06001C8B RID: 7307 RVA: 0x0020C1CC File Offset: 0x0020A3CC
		private static void smethod_14(string string_0)
		{
			string[] files = Directory.GetFiles(GameGeneral.string_7);
			checked
			{
				for (int i = 0; i < files.Length; i++)
				{
					string fileName = Path.GetFileName(files[i]);
					if (fileName.EndsWith(".db3"))
					{
						bool flag = false;
						try
						{
							IEnumerator<DBRecord> enumerator = DBOps.smethod_0().Values.GetEnumerator();
							while (enumerator.MoveNext())
							{
								if (Operators.CompareString(enumerator.Current.string_2, fileName, false) == 0)
								{
									flag = true;
									break;
								}
							}
							goto IL_AD;
						}
						finally
						{
							IEnumerator<DBRecord> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						IL_71:
						string text = Class431.smethod_3(Path.Combine(GameGeneral.string_7, fileName));
						DBOps.dictionary_0.Add(text, new DBRecord(0, text, "Unregistered DB: " + fileName, fileName, false));
						goto IL_A4;
						IL_AD:
						if (!flag)
						{
							goto IL_71;
						}
					}
					IL_A4:;
				}
			}
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x0020C29C File Offset: 0x0020A49C
		private static void smethod_15()
		{
			DBOps.smethod_0().Clear();
			DBOps.smethod_0().Add("b439f8334b9767c4b6e6f9b2ca93c86f2d773a30", new DBRecord(1, "b439f8334b9767c4b6e6f9b2ca93c86f2d773a30", "DB3000 v480", "DB3K_480.db3", true));
			DBOps.smethod_0().Add("59b67f39e1a31b6f6ee843b9acfa8d1e368133c9", new DBRecord(2, "59b67f39e1a31b6f6ee843b9acfa8d1e368133c9", "Cold War DB v478", "CWDB_478.db3", true));
			DBOps.smethod_0().Add("e37e2e6e6522b3ba52a20b791dc854ce3e54d9f1", new DBRecord(1, "e37e2e6e6522b3ba52a20b791dc854ce3e54d9f1", "DB3000 v479", "DB3K_479.db3", true));
			XmlNode xmlNode = DBOps.smethod_8().SelectSingleNode("/DBFiles");
			try
			{
				foreach (object obj in xmlNode.ChildNodes)
				{
					XmlNode xmlNode2 = (XmlNode)obj;
					DBRecord dbrecord = new DBRecord(Conversions.ToInteger(xmlNode2.SelectSingleNode("DBID").InnerText), xmlNode2.SelectSingleNode("Hash").InnerText, xmlNode2.SelectSingleNode("Name").InnerText, xmlNode2.SelectSingleNode("File").InnerText, Conversions.ToBoolean(xmlNode2.SelectSingleNode("Supported").InnerText));
					if (File.Exists(Path.Combine(GameGeneral.string_7, dbrecord.string_2)))
					{
						DBOps.smethod_0().Add(dbrecord.string_0, dbrecord);
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x04001916 RID: 6422
		[CompilerGenerated]
		[AccessedThroughProperty("_RegisteredDBs")]
		private static ObservableDictionary<string, DBRecord> observableDictionary_0;

		// Token: 0x04001917 RID: 6423
		private static Dictionary<string, DBRecord> dictionary_0;

		// Token: 0x04001918 RID: 6424
		public static bool bool_0;

		// Token: 0x04001919 RID: 6425
		public static bool bool_1;

		// Token: 0x0400191A RID: 6426
		[CompilerGenerated]
		private static DBOps.Delegate56 delegate56_0;

		// Token: 0x0400191B RID: 6427
		internal static bool bool_2;

		// Token: 0x0400191C RID: 6428
		private static XmlDocument xmlDocument_0;

		// Token: 0x020003A4 RID: 932
		// (Invoke) Token: 0x06001C90 RID: 7312
		internal delegate void Delegate56();

		// Token: 0x020003A5 RID: 933
		internal enum Enum134 : short
		{
			// Token: 0x0400191E RID: 6430
			const_0,
			// Token: 0x0400191F RID: 6431
			const_1,
			// Token: 0x04001920 RID: 6432
			const_2,
			// Token: 0x04001921 RID: 6433
			const_3,
			// Token: 0x04001922 RID: 6434
			const_4
		}

		// Token: 0x020003A6 RID: 934
		public enum DBFileCheckResult
		{
			// Token: 0x04001924 RID: 6436
			Undefined,
			// Token: 0x04001925 RID: 6437
			AllOK,
			// Token: 0x04001926 RID: 6438
			DBFileNotPresent,
			// Token: 0x04001927 RID: 6439
			DBIsUnregistered,
			// Token: 0x04001928 RID: 6440
			DBFileIsTampered,
			// Token: 0x04001929 RID: 6441
			UnspecifiedError = 9999
		}
	}
}
