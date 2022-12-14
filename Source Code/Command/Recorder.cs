using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns12;
using ns14;
using ns9;

namespace Command_Core
{
	// Token: 0x020004C9 RID: 1225
	public sealed class Recorder
	{
		// Token: 0x06002452 RID: 9298 RVA: 0x002B7040 File Offset: 0x002B5240
		public static Class581 smethod_0(string string_2, string string_3)
		{
			Class581 result;
			try
			{
				string text;
				if (string.IsNullOrEmpty(string_3))
				{
					text = Guid.NewGuid().ToString();
				}
				else
				{
					text = string_3;
				}
				Class581 @class = new Class581();
				if (string.IsNullOrEmpty(string_2))
				{
					File.Copy(Recorder.string_0 + "Sample.rec", Recorder.string_0 + text + ".rec");
					@class.string_0 = Recorder.string_0 + text + ".rec";
				}
				else
				{
					File.Copy(Recorder.string_0 + "Sample.rec", Path.Combine(string_2, text) + ".rec");
					@class.string_0 = Path.Combine(string_2, text) + ".rec";
				}
				@class.dateTime_0 = DateAndTime.Now;
				result = @class;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101125", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Class581();
			}
			return result;
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x002B7154 File Offset: 0x002B5354
		public static string smethod_1()
		{
			string directoryPath = Class160.smethod_1().Info.DirectoryPath;
			IEnumerable<string> enumerable = Enumerable.OrderByDescending<string, DateTime>(Enumerable.Where<string>(Enumerable.Select<string, string>(Directory.GetFiles(Recorder.string_0), (Recorder._Closure$__.$I6-0 == null) ? (Recorder._Closure$__.$I6-0 = new Func<string, string>(Recorder._Closure$__.$I.method_0)) : Recorder._Closure$__.$I6-0), (Recorder._Closure$__.$I6-1 == null) ? (Recorder._Closure$__.$I6-1 = new Func<string, bool>(Recorder._Closure$__.$I.method_1)) : Recorder._Closure$__.$I6-1), (Recorder._Closure$__.$I6-2 == null) ? (Recorder._Closure$__.$I6-2 = new Func<string, DateTime>(Recorder._Closure$__.$I.method_2)) : Recorder._Closure$__.$I6-2);
			string result;
			if (Enumerable.Count<string>(enumerable) > 0)
			{
				result = Enumerable.ElementAtOrDefault<string>(enumerable, 0);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x002B7210 File Offset: 0x002B5410
		public static Class581 smethod_2(string string_2)
		{
			Class581 result;
			try
			{
				Class581 @class = new Class581();
				@class.string_0 = string_2;
				string connectionString = "Data Source=" + string_2 + ";Version=3";
				SQLiteConnection sqliteConnection_ = new SQLiteConnection(connectionString);
				SQLiteDataReader sqliteDataReader = new Class403(sqliteConnection_).method_1("SELECT ID, ScenarioTime from Snapshots order by ID ASC");
				while (sqliteDataReader.Read())
				{
					@class.list_0.Add(new Tuple<int, DateTime>(Conversions.ToInteger(sqliteDataReader["ID"]), DateTime.FromBinary(Conversions.ToLong(sqliteDataReader["ScenarioTime"]))));
				}
				sqliteDataReader.Close();
				result = @class;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101126", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Class581();
			}
			return result;
		}

		// Token: 0x04001F37 RID: 7991
		public static bool bool_0;

		// Token: 0x04001F38 RID: 7992
		private static string string_0 = Class160.smethod_1().Info.DirectoryPath + "\\Recordings\\";

		// Token: 0x04001F39 RID: 7993
		public static string string_1 = GameGeneral.string_5 + "\\" + Path.GetRandomFileName();
	}
}
