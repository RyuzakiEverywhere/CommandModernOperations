using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns4;
using ns6;

namespace ns7
{
	// Token: 0x02000F4C RID: 3916
	[StandardModule]
	internal sealed class Class2566
	{
		// Token: 0x06008C20 RID: 35872 RVA: 0x00053A0C File Offset: 0x00051C0C
		public static void smethod_0(string string_0, int int_0, int int_1, int int_2, int int_3)
		{
			if (Class2566.dictionary_0.ContainsKey(string_0))
			{
				Class2566.dictionary_0[string_0] = new Tuple<int, int, int, int>(int_0, int_1, int_2, int_3);
				return;
			}
			Class2566.dictionary_0.Add(string_0, new Tuple<int, int, int, int>(int_0, int_1, int_2, int_3));
		}

		// Token: 0x06008C21 RID: 35873 RVA: 0x004B748C File Offset: 0x004B568C
		public static void smethod_1(Form4 form4_0)
		{
			if (Class2566.dictionary_0.ContainsKey(form4_0.Name))
			{
				Tuple<int, int, int, int> tuple = Class2566.dictionary_0[form4_0.Name];
				if (form4_0.bool_0)
				{
					form4_0.Location = new Point(tuple.Item1, tuple.Item2);
				}
				if (form4_0.bool_1)
				{
					if (form4_0.MinimumSize.Width > tuple.Item3)
					{
						form4_0.Width = form4_0.MinimumSize.Width;
					}
					else
					{
						form4_0.Width = tuple.Item3;
					}
					if (form4_0.MinimumSize.Height > tuple.Item4)
					{
						form4_0.Height = form4_0.MinimumSize.Height;
						return;
					}
					form4_0.Height = tuple.Item4;
					return;
				}
			}
			else
			{
				try
				{
					Point location;
					location.X = (int)Math.Round((double)Screen.AllScreens[0].Bounds.Width / 2.0 - (double)form4_0.Width / 2.0);
					location.Y = (int)Math.Round((double)Screen.AllScreens[0].Bounds.Height / 2.0 - (double)form4_0.Height / 2.0);
					form4_0.Location = location;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200488", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06008C22 RID: 35874 RVA: 0x004B762C File Offset: 0x004B582C
		public static void smethod_2(DarkSecondaryFormBase darkSecondaryFormBase_0)
		{
			if (Class2566.dictionary_0.ContainsKey(darkSecondaryFormBase_0.Name))
			{
				Tuple<int, int, int, int> tuple = Class2566.dictionary_0[darkSecondaryFormBase_0.Name];
				if (darkSecondaryFormBase_0.bool_1)
				{
					darkSecondaryFormBase_0.Location = new Point(tuple.Item1, tuple.Item2);
				}
				if (darkSecondaryFormBase_0.bool_2)
				{
					if (darkSecondaryFormBase_0.MinimumSize.Width > tuple.Item3)
					{
						darkSecondaryFormBase_0.Width = darkSecondaryFormBase_0.MinimumSize.Width;
					}
					else
					{
						darkSecondaryFormBase_0.Width = tuple.Item3;
					}
					if (darkSecondaryFormBase_0.MinimumSize.Height > tuple.Item4)
					{
						darkSecondaryFormBase_0.Height = darkSecondaryFormBase_0.MinimumSize.Height;
						return;
					}
					darkSecondaryFormBase_0.Height = tuple.Item4;
					return;
				}
			}
			else
			{
				try
				{
					Point location;
					location.X = (int)Math.Round((double)Screen.AllScreens[0].Bounds.Width / 2.0 - (double)darkSecondaryFormBase_0.Width / 2.0);
					location.Y = (int)Math.Round((double)Screen.AllScreens[0].Bounds.Height / 2.0 - (double)darkSecondaryFormBase_0.Height / 2.0);
					darkSecondaryFormBase_0.Location = location;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200488", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x04004BF0 RID: 19440
		public static Dictionary<string, Tuple<int, int, int, int>> dictionary_0 = new Dictionary<string, Tuple<int, int, int, int>>();
	}
}
