using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Command_Core;
using Command_Core.DAL;
using Command_Core.Lua;
using LiveCharts;
using LiveCharts.Configurations;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns11;
using ns13;
using ns2;
using ns3;
using ns4;
using ns5;
using ns9;

namespace Command
{
	// Token: 0x02000ED9 RID: 3801
	[DesignerGenerated]
	public sealed partial class Evaluation : DarkSecondaryFormBase
	{
		// Token: 0x060084A0 RID: 33952 RVA: 0x0047268C File Offset: 0x0047088C
		public Evaluation()
		{
			base.Load += this.Evaluation_Load;
			base.KeyDown += this.Evaluation_KeyDown;
			base.FormClosing += this.Evaluation_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x060084A2 RID: 33954 RVA: 0x0047271C File Offset: 0x0047091C
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Class116());
			this.vmethod_3(new Class116());
			this.vmethod_5(new Control12());
			this.vmethod_7(new TabPage());
			this.vmethod_33(new Control9());
			this.vmethod_31(new Label());
			this.vmethod_25(new Control0());
			this.vmethod_17(new Class116());
			this.vmethod_15(new Control9());
			this.vmethod_13(new Control9());
			this.vmethod_9(new TabPage());
			this.vmethod_11(new Control8());
			this.vmethod_19(new TabPage());
			this.vmethod_23(new Control9());
			this.vmethod_21(new Control8());
			this.vmethod_27(new TabPage());
			this.vmethod_29(new ElementHost());
			this.scoringGraphControl_0 = new ScoringGraphControl();
			this.vmethod_4().SuspendLayout();
			this.vmethod_6().SuspendLayout();
			this.vmethod_8().SuspendLayout();
			this.vmethod_18().SuspendLayout();
			this.vmethod_26().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_0().method_2(true);
			this.vmethod_0().Font = new Font("Segoe UI", 20f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new System.Drawing.Point(3, 267);
			this.vmethod_0().Name = "Label_Evaluation";
			this.vmethod_0().Size = new System.Drawing.Size(216, 37);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Label_Evaluation";
			this.vmethod_0().TextAlign = ContentAlignment.MiddleCenter;
			this.vmethod_2().method_2(true);
			this.vmethod_2().Font = new Font("Segoe UI", 16f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new System.Drawing.Point(8, 319);
			this.vmethod_2().Name = "Label_Score";
			this.vmethod_2().Size = new System.Drawing.Size(128, 30);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "Label_Score";
			this.vmethod_4().Controls.Add(this.vmethod_6());
			this.vmethod_4().Controls.Add(this.vmethod_8());
			this.vmethod_4().Controls.Add(this.vmethod_18());
			this.vmethod_4().Controls.Add(this.vmethod_26());
			this.vmethod_4().Cursor = Cursors.Hand;
			this.vmethod_4().Dock = DockStyle.Fill;
			this.vmethod_4().ItemSize = new System.Drawing.Size(80, 20);
			this.vmethod_4().Location = new System.Drawing.Point(0, 0);
			this.vmethod_4().Name = "TabControl1";
			this.vmethod_4().SelectedIndex = 0;
			this.vmethod_4().Size = new System.Drawing.Size(707, 422);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().Controls.Add(this.vmethod_32());
			this.vmethod_6().Controls.Add(this.vmethod_30());
			this.vmethod_6().Controls.Add(this.vmethod_24());
			this.vmethod_6().Controls.Add(this.vmethod_16());
			this.vmethod_6().Controls.Add(this.vmethod_14());
			this.vmethod_6().Controls.Add(this.vmethod_12());
			this.vmethod_6().Controls.Add(this.vmethod_0());
			this.vmethod_6().Controls.Add(this.vmethod_2());
			this.vmethod_6().Font = new Font("Segoe UI", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_6().Location = new System.Drawing.Point(4, 24);
			this.vmethod_6().Name = "TabPage1";
			this.vmethod_6().Padding = new Padding(3);
			this.vmethod_6().Size = new System.Drawing.Size(699, 394);
			this.vmethod_6().TabIndex = 0;
			this.vmethod_6().Text = "Evaluation";
			this.vmethod_32().BackColor = Color.Transparent;
			this.vmethod_32().DialogResult = DialogResult.None;
			this.vmethod_32().ForeColor = System.Drawing.SystemColors.Control;
			this.vmethod_32().Location = new System.Drawing.Point(544, 321);
			this.vmethod_32().Name = "Button_RestartScenario";
			this.vmethod_32().method_1(0);
			this.vmethod_32().Size = new System.Drawing.Size(149, 28);
			this.vmethod_32().TabIndex = 7;
			this.vmethod_32().Text = "Restart Scenario";
			this.vmethod_30().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_30().ForeColor = Color.White;
			this.vmethod_30().Location = new System.Drawing.Point(10, 310);
			this.vmethod_30().Name = "Label1";
			this.vmethod_30().Size = new System.Drawing.Size(683, 2);
			this.vmethod_30().TabIndex = 6;
			this.vmethod_24().method_12(Color.Gray);
			this.vmethod_24().method_13(120);
			this.vmethod_24().method_14(135);
			this.vmethod_24().method_15(270);
			this.vmethod_24().method_16(1);
			this.vmethod_24().method_0(1);
			this.vmethod_24().method_1(new Color[]
			{
				Color.Black,
				Color.Black,
				Color.Black,
				Color.Black,
				Color.Black
			});
			this.vmethod_24().method_4(new System.Drawing.Point(10, 10));
			this.vmethod_24().method_5(new System.Drawing.Point[]
			{
				new System.Drawing.Point(10, 10),
				new System.Drawing.Point(10, 10),
				new System.Drawing.Point(10, 10),
				new System.Drawing.Point(10, 10),
				new System.Drawing.Point(10, 10)
			});
			this.vmethod_24().method_3(new string[]
			{
				"",
				"",
				"",
				"",
				""
			});
			this.vmethod_24().method_2("");
			this.vmethod_24().method_7(new System.Drawing.Point(125, 125));
			this.vmethod_24().Font = new Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_24().Location = new System.Drawing.Point(210, 24);
			this.vmethod_24().method_11(400f);
			this.vmethod_24().method_9(-100f);
			this.vmethod_24().Name = "AGauge1";
			this.vmethod_24().method_53(Control0.Enum6.const_0);
			this.vmethod_24().method_54(Color.DimGray);
			this.vmethod_24().method_52(80);
			this.vmethod_24().method_51(0);
			this.vmethod_24().method_55(4);
			this.vmethod_24().method_31(2);
			this.vmethod_24().method_34(Color.Blue);
			this.vmethod_24().method_32(true);
			this.vmethod_24().method_38(0f);
			this.vmethod_24().method_40(70);
			this.vmethod_24().method_42(80);
			this.vmethod_24().method_35(new Color[]
			{
				Color.Red,
				Color.LightGray,
				Color.Blue,
				System.Drawing.SystemColors.Control,
				System.Drawing.SystemColors.Control
			});
			this.vmethod_24().method_33(new bool[]
			{
				true,
				true,
				true,
				false,
				false
			});
			Control0 control = this.vmethod_24();
			float[] array = new float[5];
			array[0] = 300f;
			array[1] = 400f;
			control.method_39(array);
			this.vmethod_24().method_41(new int[]
			{
				70,
				70,
				70,
				70,
				70
			});
			this.vmethod_24().method_43(new int[]
			{
				80,
				80,
				80,
				80,
				80
			});
			Control0 control2 = this.vmethod_24();
			float[] array2 = new float[5];
			array2[0] = -100f;
			array2[1] = 300f;
			control2.method_37(array2);
			this.vmethod_24().method_36(0f);
			this.vmethod_24().method_17(Color.Transparent);
			this.vmethod_24().method_18(73);
			this.vmethod_24().method_19(80);
			this.vmethod_24().method_20(0);
			this.vmethod_24().method_27(Color.Black);
			this.vmethod_24().method_28(70);
			this.vmethod_24().method_29(80);
			this.vmethod_24().method_26(50f);
			this.vmethod_24().method_30(0);
			this.vmethod_24().method_22(Color.Gray);
			this.vmethod_24().method_23(75);
			this.vmethod_24().method_21(0);
			this.vmethod_24().method_24(80);
			this.vmethod_24().method_25(1);
			this.vmethod_24().method_45(Color.LightGray);
			this.vmethod_24().method_46("F0");
			this.vmethod_24().method_44(95);
			this.vmethod_24().method_50(0);
			this.vmethod_24().method_48(0);
			this.vmethod_24().method_49(1);
			this.vmethod_24().Size = new System.Drawing.Size(257, 235);
			this.vmethod_24().TabIndex = 5;
			this.vmethod_24().Text = "AGauge1";
			this.vmethod_24().Value = 0f;
			this.vmethod_16().method_2(true);
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Location = new System.Drawing.Point(10, 364);
			this.vmethod_16().Name = "Label_PassScoreReached";
			this.vmethod_16().Size = new System.Drawing.Size(135, 13);
			this.vmethod_16().TabIndex = 4;
			this.vmethod_16().Text = "Label_PassScoreReached";
			this.vmethod_14().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_14().BackColor = Color.Transparent;
			this.vmethod_14().DialogResult = DialogResult.None;
			this.vmethod_14().ForeColor = System.Drawing.SystemColors.Control;
			this.vmethod_14().Location = new System.Drawing.Point(544, 364);
			this.vmethod_14().Name = "Button_ContinueCampaign";
			this.vmethod_14().method_1(0);
			this.vmethod_14().Size = new System.Drawing.Size(149, 27);
			this.vmethod_14().TabIndex = 3;
			this.vmethod_14().Text = "Continue Campaign";
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().ForeColor = System.Drawing.SystemColors.Control;
			this.vmethod_12().Location = new System.Drawing.Point(326, 321);
			this.vmethod_12().Name = "Button1";
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new System.Drawing.Size(177, 28);
			this.vmethod_12().TabIndex = 2;
			this.vmethod_12().Text = "Quit Scenario";
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().Controls.Add(this.vmethod_10());
			this.vmethod_8().Location = new System.Drawing.Point(4, 24);
			this.vmethod_8().Name = "TabPage2";
			this.vmethod_8().Padding = new Padding(3);
			this.vmethod_8().Size = new System.Drawing.Size(699, 394);
			this.vmethod_8().TabIndex = 1;
			this.vmethod_8().Text = "Losses & Expenditures";
			this.vmethod_10().method_14(null);
			this.vmethod_10().method_15(AutoCompleteMode.None);
			this.vmethod_10().method_13(AutoCompleteSource.None);
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().Dock = DockStyle.Fill;
			this.vmethod_10().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_10().method_12(null);
			this.vmethod_10().method_18(null);
			this.vmethod_10().Location = new System.Drawing.Point(3, 3);
			this.vmethod_10().method_2(32767);
			this.vmethod_10().method_7(true);
			this.vmethod_10().Name = "TextBox1";
			this.vmethod_10().method_3(false);
			this.vmethod_10().method_19(ScrollBars.Vertical);
			this.vmethod_10().method_9(0);
			this.vmethod_10().Size = new System.Drawing.Size(693, 388);
			this.vmethod_10().TabIndex = 0;
			this.vmethod_10().method_1(System.Windows.Forms.HorizontalAlignment.Left);
			this.vmethod_10().method_5(false);
			this.vmethod_10().method_10("");
			this.vmethod_18().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_18().Controls.Add(this.vmethod_22());
			this.vmethod_18().Controls.Add(this.vmethod_20());
			this.vmethod_18().Location = new System.Drawing.Point(4, 24);
			this.vmethod_18().Name = "TabPage3";
			this.vmethod_18().Size = new System.Drawing.Size(699, 394);
			this.vmethod_18().TabIndex = 2;
			this.vmethod_18().Text = "Scoring Log";
			this.vmethod_22().BackColor = Color.Transparent;
			this.vmethod_22().DialogResult = DialogResult.None;
			this.vmethod_22().ForeColor = System.Drawing.SystemColors.Control;
			this.vmethod_22().Location = new System.Drawing.Point(3, 3);
			this.vmethod_22().Name = "Button_ClearScoringLog";
			this.vmethod_22().method_1(0);
			this.vmethod_22().Size = new System.Drawing.Size(75, 23);
			this.vmethod_22().TabIndex = 2;
			this.vmethod_22().Text = "Clear Log";
			this.vmethod_20().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_20().method_14(null);
			this.vmethod_20().method_15(AutoCompleteMode.None);
			this.vmethod_20().method_13(AutoCompleteSource.None);
			this.vmethod_20().BackColor = Color.Transparent;
			this.vmethod_20().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_20().method_12(null);
			this.vmethod_20().method_18(null);
			this.vmethod_20().Location = new System.Drawing.Point(0, 29);
			this.vmethod_20().method_2(32767);
			this.vmethod_20().method_7(true);
			this.vmethod_20().Name = "TextBox_ScoringLog";
			this.vmethod_20().method_3(false);
			this.vmethod_20().method_19(ScrollBars.Vertical);
			this.vmethod_20().method_9(0);
			this.vmethod_20().Size = new System.Drawing.Size(699, 367);
			this.vmethod_20().TabIndex = 1;
			this.vmethod_20().method_1(System.Windows.Forms.HorizontalAlignment.Left);
			this.vmethod_20().method_5(false);
			this.vmethod_20().method_10("");
			this.vmethod_26().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_26().Controls.Add(this.vmethod_28());
			this.vmethod_26().Location = new System.Drawing.Point(4, 24);
			this.vmethod_26().Name = "TabPage4";
			this.vmethod_26().Padding = new Padding(3);
			this.vmethod_26().Size = new System.Drawing.Size(699, 394);
			this.vmethod_26().TabIndex = 3;
			this.vmethod_26().Text = "Scoring Graph";
			this.vmethod_28().Dock = DockStyle.Fill;
			this.vmethod_28().Location = new System.Drawing.Point(3, 3);
			this.vmethod_28().Name = "ElementHost1";
			this.vmethod_28().Size = new System.Drawing.Size(693, 388);
			this.vmethod_28().TabIndex = 0;
			this.vmethod_28().Text = "ElementHost1";
			this.vmethod_28().Child = this.scoringGraphControl_0;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new System.Drawing.Size(707, 422);
			base.Controls.Add(this.vmethod_4());
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Evaluation";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Player Evaluation";
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_6().ResumeLayout(false);
			this.vmethod_6().PerformLayout();
			this.vmethod_8().ResumeLayout(false);
			this.vmethod_18().ResumeLayout(false);
			this.vmethod_26().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x060084A3 RID: 33955 RVA: 0x00050470 File Offset: 0x0004E670
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x060084A4 RID: 33956 RVA: 0x00050478 File Offset: 0x0004E678
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_3)
		{
			this.class116_0 = class116_3;
		}

		// Token: 0x060084A5 RID: 33957 RVA: 0x00050481 File Offset: 0x0004E681
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_1;
		}

		// Token: 0x060084A6 RID: 33958 RVA: 0x00050489 File Offset: 0x0004E689
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_3)
		{
			this.class116_1 = class116_3;
		}

		// Token: 0x060084A7 RID: 33959 RVA: 0x00050492 File Offset: 0x0004E692
		[CompilerGenerated]
		internal Control12 vmethod_4()
		{
			return this.control12_0;
		}

		// Token: 0x060084A8 RID: 33960 RVA: 0x0005049A File Offset: 0x0004E69A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control12 control12_1)
		{
			this.control12_0 = control12_1;
		}

		// Token: 0x060084A9 RID: 33961 RVA: 0x000504A3 File Offset: 0x0004E6A3
		[CompilerGenerated]
		internal TabPage vmethod_6()
		{
			return this.tabPage_0;
		}

		// Token: 0x060084AA RID: 33962 RVA: 0x000504AB File Offset: 0x0004E6AB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TabPage tabPage_4)
		{
			this.tabPage_0 = tabPage_4;
		}

		// Token: 0x060084AB RID: 33963 RVA: 0x000504B4 File Offset: 0x0004E6B4
		[CompilerGenerated]
		internal TabPage vmethod_8()
		{
			return this.tabPage_1;
		}

		// Token: 0x060084AC RID: 33964 RVA: 0x000504BC File Offset: 0x0004E6BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TabPage tabPage_4)
		{
			this.tabPage_1 = tabPage_4;
		}

		// Token: 0x060084AD RID: 33965 RVA: 0x000504C5 File Offset: 0x0004E6C5
		[CompilerGenerated]
		internal Control8 vmethod_10()
		{
			return this.control8_0;
		}

		// Token: 0x060084AE RID: 33966 RVA: 0x000504CD File Offset: 0x0004E6CD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control8 control8_2)
		{
			this.control8_0 = control8_2;
		}

		// Token: 0x060084AF RID: 33967 RVA: 0x000504D6 File Offset: 0x0004E6D6
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_0;
		}

		// Token: 0x060084B0 RID: 33968 RVA: 0x0047390C File Offset: 0x00471B0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_9);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_4;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060084B1 RID: 33969 RVA: 0x000504DE File Offset: 0x0004E6DE
		[CompilerGenerated]
		internal Control9 vmethod_14()
		{
			return this.control9_1;
		}

		// Token: 0x060084B2 RID: 33970 RVA: 0x00473950 File Offset: 0x00471B50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_10);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_4;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060084B3 RID: 33971 RVA: 0x000504E6 File Offset: 0x0004E6E6
		[CompilerGenerated]
		internal Class116 vmethod_16()
		{
			return this.class116_2;
		}

		// Token: 0x060084B4 RID: 33972 RVA: 0x000504EE File Offset: 0x0004E6EE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class116 class116_3)
		{
			this.class116_2 = class116_3;
		}

		// Token: 0x060084B5 RID: 33973 RVA: 0x000504F7 File Offset: 0x0004E6F7
		[CompilerGenerated]
		internal TabPage vmethod_18()
		{
			return this.tabPage_2;
		}

		// Token: 0x060084B6 RID: 33974 RVA: 0x000504FF File Offset: 0x0004E6FF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(TabPage tabPage_4)
		{
			this.tabPage_2 = tabPage_4;
		}

		// Token: 0x060084B7 RID: 33975 RVA: 0x00050508 File Offset: 0x0004E708
		[CompilerGenerated]
		internal Control8 vmethod_20()
		{
			return this.control8_1;
		}

		// Token: 0x060084B8 RID: 33976 RVA: 0x00050510 File Offset: 0x0004E710
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Control8 control8_2)
		{
			this.control8_1 = control8_2;
		}

		// Token: 0x060084B9 RID: 33977 RVA: 0x00050519 File Offset: 0x0004E719
		[CompilerGenerated]
		internal Control9 vmethod_22()
		{
			return this.control9_2;
		}

		// Token: 0x060084BA RID: 33978 RVA: 0x00473994 File Offset: 0x00471B94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_14);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_4;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060084BB RID: 33979 RVA: 0x00050521 File Offset: 0x0004E721
		[CompilerGenerated]
		internal Control0 vmethod_24()
		{
			return this.control0_0;
		}

		// Token: 0x060084BC RID: 33980 RVA: 0x00050529 File Offset: 0x0004E729
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Control0 control0_1)
		{
			this.control0_0 = control0_1;
		}

		// Token: 0x060084BD RID: 33981 RVA: 0x00050532 File Offset: 0x0004E732
		[CompilerGenerated]
		internal TabPage vmethod_26()
		{
			return this.tabPage_3;
		}

		// Token: 0x060084BE RID: 33982 RVA: 0x0005053A File Offset: 0x0004E73A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(TabPage tabPage_4)
		{
			this.tabPage_3 = tabPage_4;
		}

		// Token: 0x060084BF RID: 33983 RVA: 0x00050543 File Offset: 0x0004E743
		[CompilerGenerated]
		internal ElementHost vmethod_28()
		{
			return this.elementHost_0;
		}

		// Token: 0x060084C0 RID: 33984 RVA: 0x0005054B File Offset: 0x0004E74B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(ElementHost elementHost_1)
		{
			this.elementHost_0 = elementHost_1;
		}

		// Token: 0x060084C1 RID: 33985 RVA: 0x00050554 File Offset: 0x0004E754
		[CompilerGenerated]
		internal Label vmethod_30()
		{
			return this.label_0;
		}

		// Token: 0x060084C2 RID: 33986 RVA: 0x0005055C File Offset: 0x0004E75C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x060084C3 RID: 33987 RVA: 0x00050565 File Offset: 0x0004E765
		[CompilerGenerated]
		internal Control9 vmethod_32()
		{
			return this.control9_3;
		}

		// Token: 0x060084C4 RID: 33988 RVA: 0x004739D8 File Offset: 0x00471BD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_15);
			Control9 control = this.control9_3;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_3 = control9_4;
			control = this.control9_3;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060084C5 RID: 33989 RVA: 0x0005056D File Offset: 0x0004E76D
		private void Evaluation_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.method_3();
		}

		// Token: 0x060084C6 RID: 33990 RVA: 0x00473A1C File Offset: 0x00471C1C
		private void method_3()
		{
			this.bool_3 = true;
			if (!Client.smethod_46().method_25())
			{
				this.method_13(0);
			}
			this.vmethod_0().Text = this.method_6();
			this.vmethod_12().Visible = !Client.smethod_46().method_25();
			if (Client.smethod_46().method_16())
			{
				this.vmethod_16().Visible = true;
				this.vmethod_14().Visible = true;
				int? num = Class264.smethod_5(Client.smethod_46());
				if (num != null)
				{
					int i = Client.smethod_50().method_22(Client.smethod_46(), null);
					if (((num != null) ? new bool?(i >= num.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						this.vmethod_16().Text = "You have reached the pass-score for this campaign scenario!";
						this.vmethod_14().Enabled = true;
						goto IL_168;
					}
				}
				this.vmethod_16().Text = string.Concat(new string[]
				{
					"Your current scenario score (",
					Conversions.ToString(Client.smethod_50().method_22(Client.smethod_46(), null)),
					") is still below the pass-score for this campaign scenario (",
					(num != null) ? Conversions.ToString(num.GetValueOrDefault()) : null,
					")"
				});
				this.vmethod_14().Enabled = false;
			}
			else
			{
				this.vmethod_16().Visible = false;
				this.vmethod_14().Visible = false;
			}
			IL_168:
			this.vmethod_10().Text = string.Empty;
			if (!Information.IsNothing(Client.smethod_50()))
			{
				if (Client.smethod_46().method_25())
				{
					this.vmethod_2().Text = "Final score: " + Conversions.ToString(Client.smethod_50().method_22(Client.smethod_46(), null));
				}
				else
				{
					this.vmethod_2().Text = "Current score: " + Conversions.ToString(Client.smethod_50().method_22(Client.smethod_46(), null));
				}
				this.method_5(Client.smethod_50());
			}
			foreach (Side side_ in Client.smethod_46().method_44())
			{
				this.method_4(side_);
			}
			this.bool_3 = false;
		}

		// Token: 0x060084C7 RID: 33991 RVA: 0x00473C48 File Offset: 0x00471E48
		private void method_4(Side side_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SIDE: " + side_0.method_51() + "\r\n===========================================================\r\n\r\n");
			stringBuilder.Append("LOSSES:\r\n-------------------------------\r\n");
			try
			{
				foreach (KeyValuePair<string, HashSet<string>> keyValuePair in side_0.class366_0.dictionary_1)
				{
					string[] array = keyValuePair.Key.ToString().Split(new char[]
					{
						'_'
					});
					string str = "";
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
											str = "Non-identifiable land aimpoint - sorry!";
										}
										else
										{
											int int_ = Conversions.ToInteger(array[1]);
											SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
											str = Misc.smethod_9(DBFunctions.smethod_109(int_, ref sqliteConnection));
										}
									}
								}
								else
								{
									str = Misc.smethod_9(Client.smethod_46().Cache_Facilities_DT.Select("ID=" + array[1])[0]["Name"].ToString());
								}
							}
							else
							{
								str = Misc.smethod_9(Client.smethod_46().Cache_Subs_DT.Select("ID=" + array[1])[0]["Name"].ToString());
							}
						}
						else
						{
							str = Misc.smethod_9(Client.smethod_46().Cache_Ships_DT.Select("ID=" + array[1])[0]["Name"].ToString());
						}
					}
					else
					{
						str = Misc.smethod_9(Client.smethod_46().Cache_Aircraft_DT.Select("ID=" + array[1])[0]["Name"].ToString());
					}
					stringBuilder.Append(Conversions.ToString(keyValuePair.Value.Count) + "x " + str + "\r\n");
				}
			}
			finally
			{
				Dictionary<string, HashSet<string>>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			stringBuilder.Append("\r\n\r\nEXPENDITURES:\r\n------------------\r\n");
			try
			{
				foreach (KeyValuePair<int, int> keyValuePair2 in side_0.class366_0.dictionary_0)
				{
					DataRow[] array2 = Client.smethod_46().Cache_Weapons_DT.Select("ID=" + Conversions.ToString(keyValuePair2.Key));
					stringBuilder.Append(keyValuePair2.Value.ToString() + "x " + Misc.smethod_9(array2[0]["Name"].ToString()) + "\r\n");
				}
			}
			finally
			{
				Dictionary<int, int>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			stringBuilder.Append("\r\n\r\n\r\n");
			this.vmethod_10().Text = this.vmethod_10().Text + stringBuilder.ToString();
		}

		// Token: 0x060084C8 RID: 33992 RVA: 0x00473F90 File Offset: 0x00472190
		private void method_5(Side side_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				foreach (string value in side_0.list_8)
				{
					stringBuilder.Append(value).Append("\r\n").Append("\r\n");
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.vmethod_20().Text = stringBuilder.ToString();
		}

		// Token: 0x060084C9 RID: 33993 RVA: 0x00474010 File Offset: 0x00472210
		private string method_6()
		{
			string result = "";
			if (!Information.IsNothing(Client.smethod_50()))
			{
				int num = Client.smethod_50().method_22(Client.smethod_46(), null);
				int? num3;
				if (Client.smethod_50().nullable_1 != null)
				{
					int num2 = num;
					num3 = Client.smethod_50().nullable_1;
					if (((num3 != null) ? new bool?(num2 >= num3.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						result = "Triumph";
					}
				}
				num3 = Client.smethod_50().nullable_1;
				if (((num3 != null) ? new bool?(num3.GetValueOrDefault() > num) : null).GetValueOrDefault() && num >= Client.smethod_50().method_34())
				{
					result = "Major Victory";
				}
				if (Client.smethod_50().method_34() > num && num >= Client.smethod_50().method_33())
				{
					result = "Minor Victory";
				}
				if (Client.smethod_50().method_33() > num && num > Client.smethod_50().method_31())
				{
					result = "Average";
				}
				if (Client.smethod_50().method_31() >= num && num > Client.smethod_50().method_30())
				{
					result = "Minor Defeat";
				}
				if (Client.smethod_50().method_30() >= num)
				{
					int num2 = num;
					num3 = Client.smethod_50().nullable_0;
					if (((num3 != null) ? new bool?(num2 > num3.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						result = "Major Defeat";
					}
				}
				if (Client.smethod_50().nullable_0 != null)
				{
					int num2 = Client.smethod_50().method_22(Client.smethod_46(), null);
					num3 = Client.smethod_50().nullable_0;
					if (((num3 != null) ? new bool?(num2 <= num3.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						result = "Disaster";
					}
				}
				this.method_7();
				this.method_8();
			}
			return result;
		}

		// Token: 0x060084CA RID: 33994 RVA: 0x00474208 File Offset: 0x00472408
		private void method_7()
		{
			Evaluation.Class2510 @class = new Evaluation.Class2510(@class);
			if (Client.smethod_50().list_8.Count == 0)
			{
				this.scoringGraphControl_0.Visibility = Visibility.Hidden;
				return;
			}
			this.scoringGraphControl_0.Visibility = Visibility.Visible;
			Regex regex = new Regex("^(\\d\\d)/(\\d\\d)/(\\d\\d\\d\\d) (\\d\\d):(\\d\\d): Score changed from (.+) to (.+)\\. Reason: (.+)$");
			List<Tuple<DateTime, int, string>> list = new List<Tuple<DateTime, int, string>>(Client.smethod_50().list_8.Count * 2 + 1);
			list.Add(new Tuple<DateTime, int, string>(Client.smethod_46().method_27(), 0, "Initial Score"));
			try
			{
				foreach (string text in Client.smethod_50().list_8)
				{
					Match match = regex.Match(text);
					if (match.Success)
					{
						DateTime item = new DateTime(int.Parse(match.Groups[3].Value), int.Parse(match.Groups[1].Value), int.Parse(match.Groups[2].Value), int.Parse(match.Groups[4].Value), int.Parse(match.Groups[5].Value), 0);
						int.Parse(match.Groups[6].Value);
						int item2 = int.Parse(match.Groups[7].Value);
						string value = match.Groups[8].Value;
						list.Add(new Tuple<DateTime, int, string>(item, item2, value));
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			list.Add(new Tuple<DateTime, int, string>(Client.smethod_46().method_31(), Client.smethod_50().method_22(null, null), "Current Score"));
			@class.dateTime_0 = Enumerable.Min<Tuple<DateTime, int, string>, DateTime>(list, (Evaluation._Closure$__.$I79-0 == null) ? (Evaluation._Closure$__.$I79-0 = new Func<Tuple<DateTime, int, string>, DateTime>(Evaluation._Closure$__.$I.method_0)) : Evaluation._Closure$__.$I79-0);
			ChartValues<ScoringDatapointViewModel> chartValues = new ChartValues<ScoringDatapointViewModel>();
			try
			{
				foreach (Tuple<DateTime, int, string> tuple in list)
				{
					chartValues.Add(new ScoringDatapointViewModel
					{
						DateTime = tuple.Item1,
						ScoreValue = tuple.Item2,
						Reason = tuple.Item3
					});
				}
			}
			finally
			{
				List<Tuple<DateTime, int, string>>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			Charting.For<ScoringDatapointViewModel>(Mappers.Xy<ScoringDatapointViewModel>().X(new Func<ScoringDatapointViewModel, double>(@class.method_0)).Y((Evaluation._Closure$__.$I79-2 == null) ? (Evaluation._Closure$__.$I79-2 = new Func<ScoringDatapointViewModel, double>(Evaluation._Closure$__.$I.method_1)) : Evaluation._Closure$__.$I79-2), SeriesOrientation.All);
			ScoringGraphControlViewModel scoringGraphControlViewModel = new ScoringGraphControlViewModel();
			scoringGraphControlViewModel.PlayerScore = chartValues;
			this.scoringGraphControl_0.DataContext = scoringGraphControlViewModel;
		}

		// Token: 0x060084CB RID: 33995 RVA: 0x00474500 File Offset: 0x00472700
		private void method_8()
		{
			if (Client.smethod_50().nullable_0 == null && Client.smethod_50().nullable_1 == null)
			{
				this.vmethod_24().Enabled = false;
				return;
			}
			this.vmethod_24().Enabled = true;
			int num = Client.smethod_50().method_22(Client.smethod_46(), null);
			this.vmethod_24().method_9((float)Math.Min(num, (Client.smethod_50().nullable_0 != null) ? Client.smethod_50().nullable_0.Value : 0));
			this.vmethod_24().method_11((float)Math.Max(num, (Client.smethod_50().nullable_1 != null) ? Client.smethod_50().nullable_1.Value : 0));
			this.vmethod_24().Value = (float)num;
			int num2 = Client.smethod_50().method_31();
			int num3 = Client.smethod_50().method_34();
			this.vmethod_24().method_26((float)((double)(this.vmethod_24().method_10() - this.vmethod_24().method_8()) / 10.0));
			this.vmethod_24().method_31(0);
			this.vmethod_24().method_36(this.vmethod_24().method_8());
			this.vmethod_24().method_38((float)num2);
			this.vmethod_24().method_31(1);
			this.vmethod_24().method_36((float)num2);
			this.vmethod_24().method_38((float)num3);
			this.vmethod_24().method_31(2);
			this.vmethod_24().method_36((float)num3);
			this.vmethod_24().method_38(this.vmethod_24().method_10());
		}

		// Token: 0x060084CC RID: 33996 RVA: 0x00050588 File Offset: 0x0004E788
		private void method_9(object sender, EventArgs e)
		{
			this.method_13(1);
			Client.smethod_46().method_48();
			this.method_3();
		}

		// Token: 0x060084CD RID: 33997 RVA: 0x00474698 File Offset: 0x00472898
		private void Evaluation_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (!base.Visible || (e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.End && e.KeyCode != Keys.Home && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Add && e.KeyCode != Keys.Subtract && (e.KeyCode != Keys.C || e.Modifiers != Keys.Control) && (e.KeyCode != Keys.X || e.Modifiers != Keys.Control)))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060084CE RID: 33998 RVA: 0x00044820 File Offset: 0x00042A20
		private void Evaluation_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x060084CF RID: 33999 RVA: 0x00474780 File Offset: 0x00472980
		private void method_10(object sender, EventArgs e)
		{
			if (Client.smethod_46().method_16())
			{
				List<string> list = new List<string>();
				Class264.smethod_3(GameGeneral.string_4, list);
				try
				{
					foreach (string text in list)
					{
						Class264 @class = Class264.smethod_1(text);
						if (Operators.CompareString(@class.string_0, Client.smethod_46().CampaignID, false) == 0)
						{
							Class264.smethod_6(text, @class, Client.smethod_46());
							this.method_13(2);
							try
							{
								foreach (Class264.Class265 class2 in @class.list_0)
								{
									if (class2.GetType() == typeof(Class264.Class266) && Operators.CompareString(((Class264.Class266)class2).string_1, Client.smethod_46().method_2(), false) == 0)
									{
										int num = @class.list_0.IndexOf(class2);
										if (num == @class.list_0.Count - 1)
										{
											this.method_12(@class);
											break;
										}
										Class264.Class265 class3 = @class.list_0[num + 1];
										Type type = class3.GetType();
										if (type == typeof(Class264.Class266))
										{
											this.method_11(class3, @class, text);
											break;
										}
										if (type == typeof(Class264.Class267))
										{
											this.method_11(class3, @class, text);
											if (class3 == Enumerable.Last<Class264.Class265>(@class.list_0))
											{
												this.method_12(@class);
												break;
											}
											this.method_11(@class.list_0[num + 2], @class, text);
											break;
										}
									}
								}
							}
							finally
							{
								List<Class264.Class265>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							break;
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x060084D0 RID: 34000 RVA: 0x00474964 File Offset: 0x00472B64
		private void method_11(Class264.Class265 class265_0, Class264 class264_0, string string_0)
		{
			Type type = class265_0.GetType();
			if (type == typeof(Class264.Class266))
			{
				string string_ = Path.GetDirectoryName(string_0) + "\\" + ((Class264.Class266)class265_0).string_2;
				Class2413.smethod_2().method_11().class264_0 = class264_0;
				Class2413.smethod_2().method_11().string_0 = string_;
				Class2413.smethod_2().method_11().string_1 = Client.smethod_46().CampaignSessionID;
				Class2413.smethod_2().method_11().int_0 = Client.smethod_46().CampaignScore + Client.smethod_50().method_22(Client.smethod_46(), null);
				Class2413.smethod_2().method_11().string_2 = Client.smethod_46().LuaXmlPassed;
				Class2413.smethod_2().method_11().Show();
				base.Close();
				return;
			}
			if (type == typeof(Class264.Class267))
			{
				Class508.smethod_0(((Class264.Class267)class265_0).string_1, null);
			}
		}

		// Token: 0x060084D1 RID: 34001 RVA: 0x000505A2 File Offset: 0x0004E7A2
		private void method_12(Class264 class264_0)
		{
			Class2413.smethod_2().method_9().class264_0 = class264_0;
			Class2413.smethod_2().method_9().Show();
		}

		// Token: 0x060084D2 RID: 34002 RVA: 0x00474A60 File Offset: 0x00472C60
		private bool method_13(int int_0)
		{
			List<string> list = new List<string>();
			bool result = false;
			string[] array = new string[]
			{
				"Setup",
				"Quit",
				"Continue"
			};
			try
			{
				foreach (Command_Core.EventTrigger eventTrigger in Client.smethod_46().vmethod_4().Values)
				{
					if (eventTrigger.eventTriggerType_0 == Command_Core.EventTrigger.EventTriggerType.ScenEnded && ((Class325)eventTrigger).method_8(Client.smethod_46()))
					{
						try
						{
							foreach (SimEvent simEvent in Client.smethod_46().vmethod_10().Values)
							{
								if (simEvent.bool_12 && simEvent.list_0.Contains(eventTrigger))
								{
									if (simEvent.method_9(Client.smethod_46()))
									{
										if (simEvent.bool_13)
										{
											Client.smethod_46().method_59(string.Concat(new string[]
											{
												"Event: '",
												simEvent.string_2,
												"(",
												array[int_0],
												")' has been fired."
											}), null, LoggedMessage.MessageType.EventEngine, 1, "", null, default(Geopoint_Struct));
										}
										LuaSandBox.Singleton().SB_Lua()["stage"] = "none";
										try
										{
											foreach (EventAction eventAction in simEvent.list_2)
											{
												LuaSandBox.Singleton().SB_Lua()["stage"] = int_0;
												eventAction.vmethod_5(Client.smethod_46(), simEvent);
												string text = null;
												try
												{
													text = LuaSandBox.Singleton().SB_Lua().GetString("answer");
													goto IL_1AB;
												}
												catch (Exception ex)
												{
													goto IL_1AB;
												}
												goto IL_19F;
												IL_1A7:
												result = true;
												continue;
												IL_19F:
												list.Add(text);
												goto IL_1A7;
												IL_1AB:
												if (text != null)
												{
													goto IL_19F;
												}
												goto IL_1A7;
											}
											continue;
										}
										finally
										{
											List<EventAction>.Enumerator enumerator3;
											((IDisposable)enumerator3).Dispose();
										}
									}
									if (simEvent.bool_13)
									{
										Client.smethod_46().method_59("Event: '" + simEvent.string_2 + "' was triggered but did NOT fire (at least one condition failed).", null, LoggedMessage.MessageType.EventEngine, 1, "", null, default(Geopoint_Struct));
									}
								}
							}
						}
						finally
						{
							IEnumerator<SimEvent> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator<Command_Core.EventTrigger> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return result;
		}

		// Token: 0x060084D3 RID: 34003 RVA: 0x000505C3 File Offset: 0x0004E7C3
		private void method_14(object sender, EventArgs e)
		{
			Client.smethod_50().list_8.Clear();
			this.vmethod_20().method_20();
		}

		// Token: 0x060084D4 RID: 34004 RVA: 0x00474D04 File Offset: 0x00472F04
		private void method_15(object sender, EventArgs e)
		{
			foreach (string text in Directory.GetFiles(GameGeneral.string_4, "*.scen", SearchOption.AllDirectories))
			{
				if (!Path.GetFileName(text).StartsWith("Autosave") && Operators.CompareString(ScenContainer.smethod_2(text).ScenTitle, Client.smethod_46().method_0(), false) == 0)
				{
					Class2413.smethod_2().method_55().string_0 = text;
					Class2413.smethod_2().method_55().Show();
					base.Close();
					return;
				}
			}
			DarkMessageBox.smethod_0("Unable to automatically locate the starting scenario. Please select the desired scenario manually. We apologize for the inconvenience!", "Original scenario not found", Enum11.const_0);
			Class2413.smethod_2().method_38().enum208_0 = LoadScenario.Enum208.const_0;
			Class2413.smethod_2().method_38().Show();
			base.Close();
		}

		// Token: 0x0400488C RID: 18572
		[AccessedThroughProperty("Label_Evaluation")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x0400488D RID: 18573
		[AccessedThroughProperty("Label_Score")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x0400488E RID: 18574
		[AccessedThroughProperty("TabControl1")]
		[CompilerGenerated]
		private Control12 control12_0;

		// Token: 0x0400488F RID: 18575
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage1")]
		private TabPage tabPage_0;

		// Token: 0x04004890 RID: 18576
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage2")]
		private TabPage tabPage_1;

		// Token: 0x04004891 RID: 18577
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private Control8 control8_0;

		// Token: 0x04004892 RID: 18578
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x04004893 RID: 18579
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ContinueCampaign")]
		private Control9 control9_1;

		// Token: 0x04004894 RID: 18580
		[CompilerGenerated]
		[AccessedThroughProperty("Label_PassScoreReached")]
		private Class116 class116_2;

		// Token: 0x04004895 RID: 18581
		[AccessedThroughProperty("TabPage3")]
		[CompilerGenerated]
		private TabPage tabPage_2;

		// Token: 0x04004896 RID: 18582
		[AccessedThroughProperty("TextBox_ScoringLog")]
		[CompilerGenerated]
		private Control8 control8_1;

		// Token: 0x04004897 RID: 18583
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ClearScoringLog")]
		private Control9 control9_2;

		// Token: 0x04004898 RID: 18584
		[CompilerGenerated]
		[AccessedThroughProperty("AGauge1")]
		private Control0 control0_0;

		// Token: 0x04004899 RID: 18585
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage4")]
		private TabPage tabPage_3;

		// Token: 0x0400489A RID: 18586
		[AccessedThroughProperty("ElementHost1")]
		[CompilerGenerated]
		private ElementHost elementHost_0;

		// Token: 0x0400489B RID: 18587
		internal ScoringGraphControl scoringGraphControl_0;

		// Token: 0x0400489C RID: 18588
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x0400489D RID: 18589
		[AccessedThroughProperty("Button_RestartScenario")]
		[CompilerGenerated]
		private Control9 control9_3;

		// Token: 0x0400489E RID: 18590
		public bool bool_3;

		// Token: 0x02000EDA RID: 3802
		[CompilerGenerated]
		internal sealed class Class2510
		{
			// Token: 0x060084D5 RID: 34005 RVA: 0x000505DF File Offset: 0x0004E7DF
			public Class2510(Evaluation.Class2510 class2510_0)
			{
				if (class2510_0 != null)
				{
					this.dateTime_0 = class2510_0.dateTime_0;
				}
			}

			// Token: 0x060084D6 RID: 34006 RVA: 0x00474DC0 File Offset: 0x00472FC0
			internal double method_0(ScoringDatapointViewModel scoringDatapointViewModel_0)
			{
				return (double)(scoringDatapointViewModel_0.DateTime - this.dateTime_0).Ticks / 10000000.0;
			}

			// Token: 0x0400489F RID: 18591
			public DateTime dateTime_0;
		}
	}
}
