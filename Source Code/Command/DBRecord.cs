using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Command_Core
{
	// Token: 0x020003A8 RID: 936
	public sealed class DBRecord
	{
		// Token: 0x06001C94 RID: 7316 RVA: 0x0020C408 File Offset: 0x0020A608
		public List<string> method_0()
		{
			if (Information.IsNothing(this.list_0))
			{
				this.list_0 = new List<string>();
				DataTable dataTable = new DataTable();
				DataTable dataTable2 = new DataTable();
				DataTable dataTable3 = new DataTable();
				DataTable dataTable4 = new DataTable();
				DataTable dataTable5 = new DataTable();
				DataTable dataTable6 = new DataTable();
				SQLiteConnection sqliteConnection = new SQLiteConnection(this.method_3());
				DBFunctions.smethod_0(ref dataTable, ref dataTable2, ref dataTable3, ref dataTable4, ref dataTable5, ref dataTable6, ref sqliteConnection);
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						this.list_0.Add("Aircraft #" + dataRow["ID"].ToString());
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
				try
				{
					foreach (object obj2 in dataTable2.Rows)
					{
						DataRow dataRow2 = (DataRow)obj2;
						this.list_0.Add("Ship #" + dataRow2["ID"].ToString());
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				try
				{
					foreach (object obj3 in dataTable3.Rows)
					{
						DataRow dataRow3 = (DataRow)obj3;
						this.list_0.Add("Submarine #" + dataRow3["ID"].ToString());
					}
				}
				finally
				{
					IEnumerator enumerator3;
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				try
				{
					foreach (object obj4 in dataTable4.Rows)
					{
						DataRow dataRow4 = (DataRow)obj4;
						this.list_0.Add("Facility #" + dataRow4["ID"].ToString());
					}
				}
				finally
				{
					IEnumerator enumerator4;
					if (enumerator4 is IDisposable)
					{
						(enumerator4 as IDisposable).Dispose();
					}
				}
				try
				{
					foreach (object obj5 in dataTable5.Rows)
					{
						DataRow dataRow5 = (DataRow)obj5;
						this.list_0.Add("Satellite #" + dataRow5["ID"].ToString());
					}
				}
				finally
				{
					IEnumerator enumerator5;
					if (enumerator5 is IDisposable)
					{
						(enumerator5 as IDisposable).Dispose();
					}
				}
				try
				{
					foreach (object obj6 in dataTable6.Rows)
					{
						DataRow dataRow6 = (DataRow)obj6;
						this.list_0.Add("Weapon #" + dataRow6["ID"].ToString());
					}
				}
				finally
				{
					IEnumerator enumerator6;
					if (enumerator6 is IDisposable)
					{
						(enumerator6 as IDisposable).Dispose();
					}
				}
			}
			return this.list_0;
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0000DFDE File Offset: 0x0000C1DE
		public bool method_1()
		{
			return DBOps.smethod_4().Contains(this);
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0000DFEB File Offset: 0x0000C1EB
		public bool method_2()
		{
			return File.Exists(Path.Combine(GameGeneral.string_7, this.string_2));
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0000E002 File Offset: 0x0000C202
		public string method_3()
		{
			return "Data Source=" + Path.Combine(GameGeneral.string_7, this.string_2) + ";Version=3;Read Only=True;";
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0000E023 File Offset: 0x0000C223
		public bool method_4()
		{
			return Operators.CompareString(DBOps.smethod_12(this.DBID), this.string_0, false) == 0;
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x0000E03F File Offset: 0x0000C23F
		public DBRecord(int theDBID, string theHash, string theDBName, string theFilename, bool IsSupported = false)
		{
			this.DBID = theDBID;
			this.string_0 = theHash;
			this.string_1 = theDBName;
			this.string_2 = theFilename;
			this.nullable_0 = new bool?(IsSupported);
		}

		// Token: 0x0400192C RID: 6444
		public int DBID;

		// Token: 0x0400192D RID: 6445
		public string string_0;

		// Token: 0x0400192E RID: 6446
		public string string_1;

		// Token: 0x0400192F RID: 6447
		public string string_2;

		// Token: 0x04001930 RID: 6448
		public bool? nullable_0;

		// Token: 0x04001931 RID: 6449
		private List<string> list_0;
	}
}
