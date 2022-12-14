using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Command;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns2;
using ns3;
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000EE8 RID: 3816
	[DesignerGenerated]
	internal sealed partial class Losses : DarkSecondaryFormBase
	{
		// Token: 0x06008627 RID: 34343 RVA: 0x0047F310 File Offset: 0x0047D510
		public Losses()
		{
			base.Load += this.Losses_Load;
			base.KeyDown += this.Losses_KeyDown;
			base.FormClosing += this.Losses_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x06008629 RID: 34345 RVA: 0x0047F3A0 File Offset: 0x0047D5A0
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Losses));
			this.vmethod_1(new Control8());
			this.vmethod_3(new Class125());
			this.vmethod_5(new ToolStripButton());
			this.vmethod_7(new ToolStripButton());
			this.vmethod_2().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().method_14(null);
			this.vmethod_0().method_15(AutoCompleteMode.None);
			this.vmethod_0().method_13(AutoCompleteSource.None);
			this.vmethod_0().BackColor = Color.Transparent;
			this.vmethod_0().method_17(new Font("Segoe UI", 10f));
			this.vmethod_0().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_0().method_12(null);
			this.vmethod_0().method_18(null);
			this.vmethod_0().Location = new Point(0, 28);
			this.vmethod_0().method_2(32767);
			this.vmethod_0().method_7(true);
			this.vmethod_0().Name = "TextBox1";
			this.vmethod_0().method_3(false);
			this.vmethod_0().method_19(ScrollBars.Vertical);
			this.vmethod_0().method_9(0);
			this.vmethod_0().Size = new Size(500, 316);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().method_1(HorizontalAlignment.Left);
			this.vmethod_0().method_5(false);
			this.vmethod_0().method_10("");
			this.vmethod_2().AutoSize = false;
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_2().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_4(),
				this.vmethod_6()
			});
			this.vmethod_2().Location = new Point(0, 0);
			this.vmethod_2().Name = "TS1";
			this.vmethod_2().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_2().Size = new Size(500, 25);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "ToolStrip1";
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Image = (Image)componentResourceManager.GetObject("TSB_ResetAll.Image");
			this.vmethod_4().ImageTransparentColor = Color.Magenta;
			this.vmethod_4().Name = "TSB_ResetAll";
			this.vmethod_4().Size = new Size(165, 22);
			this.vmethod_4().Text = "Reset All Losses/Expenditures";
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Image = (Image)componentResourceManager.GetObject("TSMI_ResetScore.Image");
			this.vmethod_6().ImageTransparentColor = Color.Magenta;
			this.vmethod_6().Name = "TSMI_ResetScore";
			this.vmethod_6().Size = new Size(118, 22);
			this.vmethod_6().Text = "Reset All Side Scores";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(500, 344);
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Losses";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Losses & Expenditures";
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0600862A RID: 34346 RVA: 0x00050F61 File Offset: 0x0004F161
		[CompilerGenerated]
		internal Control8 vmethod_0()
		{
			return this.control8_0;
		}

		// Token: 0x0600862B RID: 34347 RVA: 0x00050F69 File Offset: 0x0004F169
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control8 control8_1)
		{
			this.control8_0 = control8_1;
		}

		// Token: 0x0600862C RID: 34348 RVA: 0x00050F72 File Offset: 0x0004F172
		[CompilerGenerated]
		internal Class125 vmethod_2()
		{
			return this.class125_0;
		}

		// Token: 0x0600862D RID: 34349 RVA: 0x00050F7A File Offset: 0x0004F17A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x0600862E RID: 34350 RVA: 0x00050F83 File Offset: 0x0004F183
		[CompilerGenerated]
		internal ToolStripButton vmethod_4()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x0600862F RID: 34351 RVA: 0x0047F808 File Offset: 0x0047DA08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripButton toolStripButton_2)
		{
			EventHandler value = new EventHandler(this.method_4);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_2;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008630 RID: 34352 RVA: 0x00050F8B File Offset: 0x0004F18B
		[CompilerGenerated]
		internal ToolStripButton vmethod_6()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x06008631 RID: 34353 RVA: 0x0047F84C File Offset: 0x0047DA4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripButton toolStripButton_2)
		{
			EventHandler value = new EventHandler(this.method_5);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_2;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008632 RID: 34354 RVA: 0x0047F890 File Offset: 0x0047DA90
		private void Losses_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_2().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			this.vmethod_0().Text = string.Empty;
			foreach (Side side_ in Client.smethod_46().method_44())
			{
				this.method_3(side_);
			}
		}

		// Token: 0x06008633 RID: 34355 RVA: 0x0047F8FC File Offset: 0x0047DAFC
		private static string smethod_0(Scenario scenario_0, KeyValuePair<string, HashSet<string>> keyValuePair_0)
		{
			string[] array = keyValuePair_0.Key.ToString().Split(new char[]
			{
				'_'
			});
			string result = "";
			string left = array[0].ToString();
			if (Operators.CompareString(left, "Aircraft", false) != 0)
			{
				if (Operators.CompareString(left, "Ship", false) != 0)
				{
					if (Operators.CompareString(left, "Submarine", false) != 0)
					{
						if (Operators.CompareString(left, "Facility", false) != 0)
						{
							if (Operators.CompareString(left, "FacilityAimpoint", false) == 0)
							{
								if (Operators.CompareString(array[1], "0", false) == 0)
								{
									result = "Non-identifiable land aimpoint - sorry!";
								}
								else
								{
									int int_ = Conversions.ToInteger(array[1]);
									SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
									result = Misc.smethod_9(DBFunctions.smethod_109(int_, ref sqliteConnection));
								}
							}
						}
						else
						{
							result = Misc.smethod_9(scenario_0.Cache_Facilities_DT.Select("ID=" + array[1])[0]["Name"].ToString());
						}
					}
					else
					{
						result = Misc.smethod_9(scenario_0.Cache_Subs_DT.Select("ID=" + array[1])[0]["Name"].ToString());
					}
				}
				else
				{
					result = Misc.smethod_9(scenario_0.Cache_Ships_DT.Select("ID=" + array[1])[0]["Name"].ToString());
				}
			}
			else
			{
				result = Misc.smethod_9(scenario_0.Cache_Aircraft_DT.Select("ID=" + array[1])[0]["Name"].ToString());
			}
			return result;
		}

		// Token: 0x06008634 RID: 34356 RVA: 0x00050F93 File Offset: 0x0004F193
		private static string smethod_1(Scenario scenario_0, KeyValuePair<int, int> keyValuePair_0)
		{
			return Misc.smethod_9(scenario_0.Cache_Weapons_DT.Select("ID=" + Conversions.ToString(keyValuePair_0.Key))[0]["Name"].ToString());
		}

		// Token: 0x06008635 RID: 34357 RVA: 0x00050FCC File Offset: 0x0004F1CC
		private void method_3(Side side_0)
		{
			this.vmethod_0().Text = this.vmethod_0().Text + Losses.smethod_2(side_0, Client.smethod_46());
		}

		// Token: 0x06008636 RID: 34358 RVA: 0x0047FA90 File Offset: 0x0047DC90
		public static string smethod_2(Side side_0, Scenario scenario_0)
		{
			Losses.Class2513 @class = new Losses.Class2513(@class);
			@class.scenario_0 = scenario_0;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SIDE: " + side_0.method_51() + "\r\n===========================================================\r\n\r\n");
			stringBuilder.Append("LOSSES:\r\n-------------------------------\r\n");
			List<KeyValuePair<string, HashSet<string>>> list = Enumerable.ToList<KeyValuePair<string, HashSet<string>>>(Enumerable.OrderBy<KeyValuePair<string, HashSet<string>>, string>(side_0.class366_0.dictionary_1, new Func<KeyValuePair<string, HashSet<string>>, string>(@class.method_0)));
			try
			{
				foreach (KeyValuePair<string, HashSet<string>> keyValuePair_ in list)
				{
					stringBuilder.Append(Conversions.ToString(keyValuePair_.Value.Count) + "x " + Losses.smethod_0(@class.scenario_0, keyValuePair_) + "\r\n");
				}
			}
			finally
			{
				List<KeyValuePair<string, HashSet<string>>>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			stringBuilder.Append("\r\n\r\nEXPENDITURES:\r\n------------------\r\n");
			List<KeyValuePair<int, int>> list2 = Enumerable.ToList<KeyValuePair<int, int>>(Enumerable.OrderBy<KeyValuePair<int, int>, string>(side_0.class366_0.dictionary_0, new Func<KeyValuePair<int, int>, string>(@class.method_1)));
			try
			{
				foreach (KeyValuePair<int, int> keyValuePair_2 in list2)
				{
					stringBuilder.Append(keyValuePair_2.Value.ToString() + "x " + Losses.smethod_1(@class.scenario_0, keyValuePair_2) + "\r\n");
				}
			}
			finally
			{
				List<KeyValuePair<int, int>>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			stringBuilder.Append("\r\n\r\n\r\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06008637 RID: 34359 RVA: 0x0047FC18 File Offset: 0x0047DE18
		private void method_4(object sender, EventArgs e)
		{
			foreach (Side side in Client.smethod_46().method_44())
			{
				side.class366_0.dictionary_1.Clear();
				side.class366_0.dictionary_0.Clear();
			}
			this.vmethod_0().Text = string.Empty;
			foreach (Side side_ in Client.smethod_46().method_44())
			{
				this.method_3(side_);
			}
		}

		// Token: 0x06008638 RID: 34360 RVA: 0x0047FC98 File Offset: 0x0047DE98
		private void Losses_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (!base.Visible || (e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.End && e.KeyCode != Keys.Home && (e.KeyCode != Keys.C || e.Modifiers != Keys.Control) && (e.KeyCode != Keys.X || e.Modifiers != Keys.Control) && (e.KeyCode != Keys.V || e.Modifiers != Keys.Control)))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06008639 RID: 34361 RVA: 0x00044820 File Offset: 0x00042A20
		private void Losses_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x0600863A RID: 34362 RVA: 0x0047FD4C File Offset: 0x0047DF4C
		private void method_5(object sender, EventArgs e)
		{
			foreach (Side side in Client.smethod_46().method_44())
			{
				side.method_23(Client.smethod_46(), null, 0);
				side.list_8.Clear();
			}
			DarkMessageBox.smethod_0("Score points for all sides have been reset to 0.", "", Enum11.const_0);
		}

		// Token: 0x04004933 RID: 18739
		[AccessedThroughProperty("TextBox1")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x04004934 RID: 18740
		[CompilerGenerated]
		[AccessedThroughProperty("TS1")]
		private Class125 class125_0;

		// Token: 0x04004935 RID: 18741
		[AccessedThroughProperty("TSB_ResetAll")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04004936 RID: 18742
		[AccessedThroughProperty("TSMI_ResetScore")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x02000EE9 RID: 3817
		[CompilerGenerated]
		internal sealed class Class2513
		{
			// Token: 0x0600863B RID: 34363 RVA: 0x00050FF4 File Offset: 0x0004F1F4
			public Class2513(Losses.Class2513 class2513_0)
			{
				if (class2513_0 != null)
				{
					this.scenario_0 = class2513_0.scenario_0;
				}
			}

			// Token: 0x0600863C RID: 34364 RVA: 0x0005100B File Offset: 0x0004F20B
			internal string method_0(KeyValuePair<string, HashSet<string>> keyValuePair_0)
			{
				return Losses.smethod_0(this.scenario_0, keyValuePair_0);
			}

			// Token: 0x0600863D RID: 34365 RVA: 0x00051019 File Offset: 0x0004F219
			internal string method_1(KeyValuePair<int, int> keyValuePair_0)
			{
				return Losses.smethod_1(this.scenario_0, keyValuePair_0);
			}

			// Token: 0x04004937 RID: 18743
			public Scenario scenario_0;
		}
	}
}
