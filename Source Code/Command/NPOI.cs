using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace Command_Core
{
	// Token: 0x020003F4 RID: 1012
	[StandardModule]
	internal sealed class NPOI
	{
		// Token: 0x06001E86 RID: 7814 RVA: 0x0022ABAC File Offset: 0x00228DAC
		public static DataTable smethod_0(string theFileName, int SheetIndex = 0)
		{
			DataTable result;
			try
			{
				IWorkbook workbook;
				using (FileStream fileStream = new FileStream(theFileName, FileMode.Open, FileAccess.Read))
				{
					workbook = new HSSFWorkbook(fileStream);
				}
				ISheet sheetAt = workbook.GetSheetAt(SheetIndex);
				DataTable dataTable = new DataTable(sheetAt.SheetName);
				IRow row = sheetAt.GetRow(0);
				try
				{
					foreach (ICell cell in row)
					{
						dataTable.Columns.Add(cell.ToString());
					}
				}
				finally
				{
					IEnumerator<ICell> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				bool flag = true;
				try
				{
					foreach (object obj in sheetAt)
					{
						IRow row2 = (IRow)obj;
						if (flag)
						{
							flag = false;
						}
						else
						{
							DataRow dataRow = dataTable.NewRow();
							try
							{
								dataRow.ItemArray = Enumerable.ToArray<string>(Enumerable.Select<ICell, string>(row2.Cells, (NPOI._Closure$__.$I0-0 == null) ? (NPOI._Closure$__.$I0-0 = new Func<ICell, string>(NPOI._Closure$__.$I.method_0)) : NPOI._Closure$__.$I0-0));
							}
							catch (Exception ex)
							{
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								continue;
							}
							dataTable.Rows.Add(dataRow);
						}
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
				result = dataTable;
			}
			catch (Exception ex2)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					throw;
				}
			}
			return result;
		}
	}
}
