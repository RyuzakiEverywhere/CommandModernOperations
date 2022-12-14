using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000EFE RID: 3838
	[DesignerGenerated]
	public sealed partial class AddSatellite : DarkSecondaryFormBase
	{
		// Token: 0x060087A2 RID: 34722 RVA: 0x0048B250 File Offset: 0x00489450
		public AddSatellite()
		{
			base.Load += this.AddSatellite_Load;
			base.KeyDown += this.AddSatellite_KeyDown;
			base.FormClosing += this.AddSatellite_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x060087A4 RID: 34724 RVA: 0x0048B2E0 File Offset: 0x004894E0
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Control6());
			this.vmethod_3(new Control9());
			this.vmethod_5(new Class116());
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().Location = new Point(3, 3);
			this.vmethod_0().method_6(20);
			this.vmethod_0().method_26(true);
			this.vmethod_0().Name = "TreeView1";
			this.vmethod_0().Size = new Size(361, 458);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_2().Location = new Point(3, 467);
			this.vmethod_2().Name = "Button1";
			this.vmethod_2().method_1(0);
			this.vmethod_2().Size = new Size(114, 23);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "Add Selected";
			this.vmethod_4().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_4().method_2(true);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(124, 472);
			this.vmethod_4().Name = "Label1";
			this.vmethod_4().Size = new Size(39, 13);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "Label1";
			this.vmethod_4().Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(367, 496);
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AddSatellite";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Add Satellite";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060087A5 RID: 34725 RVA: 0x00051993 File Offset: 0x0004FB93
		[CompilerGenerated]
		internal Control6 vmethod_0()
		{
			return this.control6_0;
		}

		// Token: 0x060087A6 RID: 34726 RVA: 0x0005199B File Offset: 0x0004FB9B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control6 control6_1)
		{
			this.control6_0 = control6_1;
		}

		// Token: 0x060087A7 RID: 34727 RVA: 0x000519A4 File Offset: 0x0004FBA4
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_0;
		}

		// Token: 0x060087A8 RID: 34728 RVA: 0x0048B56C File Offset: 0x0048976C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control9 control9_1)
		{
			EventHandler value = new EventHandler(this.method_4);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_1;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060087A9 RID: 34729 RVA: 0x000519AC File Offset: 0x0004FBAC
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_0;
		}

		// Token: 0x060087AA RID: 34730 RVA: 0x000519B4 File Offset: 0x0004FBB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x060087AB RID: 34731 RVA: 0x0048B5B0 File Offset: 0x004897B0
		private void AddSatellite_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_0().method_20().Clear();
			List<string> list = Enumerable.ToList<string>(Enumerable.Distinct<string>(Enumerable.Select<object, string>(Enumerable.Cast<object>(Client.smethod_46().Cache_Satellites_DT.Rows), (AddSatellite._Closure$__.$I18-0 == null) ? (AddSatellite._Closure$__.$I18-0 = new Func<object, string>(AddSatellite._Closure$__.$I.method_0)) : AddSatellite._Closure$__.$I18-0)));
			try
			{
				foreach (string str in list)
				{
					Class127 @class = new Class127(str);
					@class.Tag = "Country_" + str;
					this.vmethod_0().method_20().method_4(@class);
					this.method_3(@class);
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x060087AC RID: 34732 RVA: 0x0048B694 File Offset: 0x00489894
		public void method_3(Class127 class127_0)
		{
			string text = Conversions.ToString(class127_0.Tag);
			string left = text.Split(new char[]
			{
				'_'
			})[0];
			if (Operators.CompareString(left, "Country", false) != 0)
			{
				if (Operators.CompareString(left, "Type", false) != 0)
				{
					if (Operators.CompareString(left, "SatClass", false) != 0)
					{
						return;
					}
					DataTable dataTable = DBFunctions.smethod_7(Conversions.ToInteger(text.Split(Conversions.ToCharArrayRankOne("_"))[1]), Client.smethod_46().method_39());
					try
					{
						foreach (object obj in dataTable.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							Class127 @class = new Class127(dataRow["MissonName"].ToString());
							DateTime dateTime = Conversions.ToDate(dataRow["LaunchDate"]);
							DateTime t = Conversions.ToDate(dataRow["DeOrbitingDate"]);
							if (DateTime.Compare(t, Client.smethod_46().method_31()) < 0 && DateTime.Compare(t, new DateTime(1900, 1, 1)) > 0)
							{
								@class.method_39(Color.Gray);
								@class.method_7(Conversions.ToString(dataRow["MissonName"]) + " (unavailable - already de-orbited)");
							}
							else if (DateTime.Compare(dateTime, Client.smethod_46().method_31()) < 0)
							{
								@class.method_7(Conversions.ToString(dataRow["MissonName"]) + " (in orbit)");
							}
							else
							{
								TimeSpan timeSpan = dateTime - Client.smethod_46().method_31();
								@class.method_7(Conversions.ToString(dataRow["MissonName"]) + " (will launch in " + Misc.smethod_11((long)Math.Round(timeSpan.TotalSeconds), Aircraft_AirOps.Enum44.const_0, false, false) + ")");
							}
							@class.Tag = "Spacecraft_" + dataRow["ID"].ToString() + "_" + dataRow["ComponentNumber"].ToString();
							class127_0.method_23().method_4(@class);
							this.method_3(@class);
						}
						return;
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
				this.string_1 = text.Split(new char[]
				{
					'_'
				})[1];
				var list = Enumerable.ToList(Enumerable.OrderBy(Enumerable.Select(Enumerable.Where<object>(Enumerable.Cast<object>(Client.smethod_46().Cache_Satellites_DT.Rows), new Func<object, bool>(this.method_6)), (AddSatellite._Closure$__.$I19-4 == null) ? (AddSatellite._Closure$__.$I19-4 = new Func<object, VB$AnonymousType_1<string, int>>(AddSatellite._Closure$__.$I.method_3)) : AddSatellite._Closure$__.$I19-4), (AddSatellite._Closure$__.$I19-5 == null) ? (AddSatellite._Closure$__.$I19-5 = new Func<VB$AnonymousType_1<string, int>, string>(AddSatellite._Closure$__.$I.method_4)) : AddSatellite._Closure$__.$I19-5));
				try
				{
					foreach (var vb$AnonymousType_ in list)
					{
						Class127 class2 = new Class127(vb$AnonymousType_.method_0());
						class2.Tag = "SatClass_" + Conversions.ToString(vb$AnonymousType_.method_1());
						class127_0.method_23().method_4(class2);
						this.method_3(class2);
					}
					return;
				}
				finally
				{
					var enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
			this.string_0 = text.Split(new char[]
			{
				'_'
			})[1];
			List<string> list2 = Enumerable.ToList<string>(Enumerable.Distinct<string>(Enumerable.OrderBy<string, string>(Enumerable.Select<object, string>(Enumerable.Where<object>(Enumerable.Cast<object>(Client.smethod_46().Cache_Satellites_DT.Rows), new Func<object, bool>(this.method_5)), (AddSatellite._Closure$__.$I19-1 == null) ? (AddSatellite._Closure$__.$I19-1 = new Func<object, string>(AddSatellite._Closure$__.$I.method_1)) : AddSatellite._Closure$__.$I19-1), (AddSatellite._Closure$__.$I19-2 == null) ? (AddSatellite._Closure$__.$I19-2 = new Func<string, string>(AddSatellite._Closure$__.$I.method_2)) : AddSatellite._Closure$__.$I19-2)));
			try
			{
				foreach (string str in list2)
				{
					Class127 class3 = new Class127(str);
					class3.Tag = "Type_" + str;
					class127_0.method_23().method_4(class3);
					this.method_3(class3);
				}
			}
			finally
			{
				List<string>.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
		}

		// Token: 0x060087AD RID: 34733 RVA: 0x0048BB1C File Offset: 0x00489D1C
		private void method_4(object sender, EventArgs e)
		{
			int num = 0;
			try
			{
				foreach (Class127 @class in this.vmethod_0().method_22())
				{
					string text = Conversions.ToString(@class.Tag);
					if (!Information.IsNothing(text) && Operators.CompareString(text.Split(new char[]
					{
						'_'
					})[0], "Spacecraft", false) == 0 && !(@class.method_38() == Color.Gray))
					{
						string text2 = text.Split(new char[]
						{
							'_'
						})[1] + "_" + text.Split(new char[]
						{
							'_'
						})[2];
						bool flag;
						try
						{
							foreach (ActiveUnit activeUnit in Client.smethod_46().method_42())
							{
								if (!Information.IsNothing(activeUnit) && activeUnit.method_1() && string.CompareOrdinal(((Satellite)activeUnit).string_9, text2) == 0)
								{
									flag = true;
									break;
								}
							}
							goto IL_154;
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						IL_FE:
						Client.smethod_46().method_72(Client.smethod_50(), "", Conversions.ToInteger(text.Split(new char[]
						{
							'_'
						})[1]), Conversions.ToInteger(text.Split(new char[]
						{
							'_'
						})[2]), Unit.Enum122.const_0, null).string_9 = text2;
						num++;
						continue;
						IL_154:
						if (!flag)
						{
							goto IL_FE;
						}
					}
				}
			}
			finally
			{
				IEnumerator<Class127> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			if (num > 0)
			{
				this.vmethod_4().Visible = true;
				this.vmethod_4().Text = Conversions.ToString(num) + " satellites were added to the scenario.";
				Client.bool_1 = true;
			}
		}

		// Token: 0x060087AE RID: 34734 RVA: 0x0048BCF8 File Offset: 0x00489EF8
		private void AddSatellite_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (!base.Visible || (e.KeyCode != Keys.Space && e.KeyCode != Keys.Add && e.KeyCode != Keys.Subtract))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060087AF RID: 34735 RVA: 0x00044820 File Offset: 0x00042A20
		private void AddSatellite_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x060087B0 RID: 34736 RVA: 0x000519BD File Offset: 0x0004FBBD
		[CompilerGenerated]
		private bool method_5(object object_0)
		{
			return Operators.CompareString(Conversions.ToString(((DataRow)object_0)["CountryString"]), this.string_0, false) == 0;
		}

		// Token: 0x060087B1 RID: 34737 RVA: 0x0048BD5C File Offset: 0x00489F5C
		[CompilerGenerated]
		private bool method_6(object object_0)
		{
			return Operators.CompareString(Conversions.ToString(((DataRow)object_0)["TypeString"]), this.string_1, false) == 0 & Operators.CompareString(Conversions.ToString(((DataRow)object_0)["CountryString"]), this.string_0, false) == 0;
		}

		// Token: 0x040049D3 RID: 18899
		[CompilerGenerated]
		[AccessedThroughProperty("TreeView1")]
		private Control6 control6_0;

		// Token: 0x040049D4 RID: 18900
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_0;

		// Token: 0x040049D5 RID: 18901
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x040049D6 RID: 18902
		private string string_0;

		// Token: 0x040049D7 RID: 18903
		private string string_1;
	}
}
