using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Xml;
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns12;
using ns2;
using ns3;
using ns4;
using ns5;
using ns7;
using ns9;

namespace Command
{
	// Token: 0x02000EDC RID: 3804
	[DesignerGenerated]
	public sealed partial class LoadScenario : DarkSecondaryFormBase
	{
		// Token: 0x060084DC RID: 34012 RVA: 0x00474E34 File Offset: 0x00473034
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Control9());
			this.vmethod_3(new Control6());
			this.vmethod_5(new Control12());
			this.vmethod_7(new TabPage());
			this.vmethod_9(new TabPage());
			this.vmethod_11(new Control6());
			this.vmethod_37(new TabPage());
			this.vmethod_39(new ElementHost());
			this.scenarioSelectControl_0 = new ScenarioSelectControl();
			this.vmethod_13(new Control9());
			this.vmethod_15(new Class116());
			this.vmethod_17(new Control11());
			this.vmethod_19(new Class116());
			this.vmethod_21(new WebBrowser());
			this.vmethod_23(new Class116());
			this.vmethod_25(new Class116());
			this.vmethod_27(new Control11());
			this.vmethod_29(new Control11());
			this.vmethod_31(new Class116());
			this.vmethod_33(new Class116());
			this.vmethod_35(new Class2451());
			this.vmethod_41(new Control9());
			this.vmethod_43(new OpenFileDialog());
			this.vmethod_4().SuspendLayout();
			this.vmethod_6().SuspendLayout();
			this.vmethod_8().SuspendLayout();
			this.vmethod_36().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_0().BackColor = Color.Transparent;
			this.vmethod_0().DialogResult = DialogResult.None;
			this.vmethod_0().Font = new Font("Segoe UI", 10f);
			this.vmethod_0().ForeColor = SystemColors.Control;
			this.vmethod_0().Location = new Point(420, 566);
			this.vmethod_0().Name = "Button2";
			this.vmethod_0().method_1(0);
			this.vmethod_0().Size = new Size(135, 23);
			this.vmethod_0().TabIndex = 2;
			this.vmethod_0().Text = "Load selected";
			this.vmethod_2().Dock = DockStyle.Fill;
			this.vmethod_2().Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_2().Location = new Point(3, 3);
			this.vmethod_2().method_6(20);
			this.vmethod_2().Name = "TV_Scens";
			this.vmethod_2().Size = new Size(388, 512);
			this.vmethod_2().TabIndex = 5;
			this.vmethod_4().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_4().Controls.Add(this.vmethod_6());
			this.vmethod_4().Controls.Add(this.vmethod_8());
			this.vmethod_4().Controls.Add(this.vmethod_36());
			this.vmethod_4().Cursor = Cursors.Hand;
			this.vmethod_4().Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_4().ItemSize = new Size(80, 20);
			this.vmethod_4().Location = new Point(12, 43);
			this.vmethod_4().Name = "TabControl1";
			this.vmethod_4().SelectedIndex = 0;
			this.vmethod_4().Size = new Size(402, 546);
			this.vmethod_4().TabIndex = 6;
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().Controls.Add(this.vmethod_2());
			this.vmethod_6().Location = new Point(4, 24);
			this.vmethod_6().Name = "TabPage1";
			this.vmethod_6().Padding = new Padding(3);
			this.vmethod_6().Size = new Size(394, 518);
			this.vmethod_6().TabIndex = 0;
			this.vmethod_6().Text = "Scenarios";
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().Controls.Add(this.vmethod_10());
			this.vmethod_8().Location = new Point(4, 24);
			this.vmethod_8().Name = "TabPage2";
			this.vmethod_8().Padding = new Padding(3);
			this.vmethod_8().Size = new Size(394, 518);
			this.vmethod_8().TabIndex = 1;
			this.vmethod_8().Text = "Saved games";
			this.vmethod_10().Dock = DockStyle.Fill;
			this.vmethod_10().Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_10().Location = new Point(3, 3);
			this.vmethod_10().method_6(20);
			this.vmethod_10().Name = "TV_Saves";
			this.vmethod_10().Size = new Size(388, 512);
			this.vmethod_10().TabIndex = 6;
			this.vmethod_36().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_36().Controls.Add(this.vmethod_38());
			this.vmethod_36().Location = new Point(4, 24);
			this.vmethod_36().Name = "TabPage3";
			this.vmethod_36().Padding = new Padding(3);
			this.vmethod_36().Size = new Size(394, 518);
			this.vmethod_36().TabIndex = 2;
			this.vmethod_36().Text = "Steam Workshop";
			this.vmethod_38().Dock = DockStyle.Fill;
			this.vmethod_38().Location = new Point(3, 3);
			this.vmethod_38().Name = "ElementHost1";
			this.vmethod_38().Size = new Size(388, 512);
			this.vmethod_38().TabIndex = 0;
			this.vmethod_38().Text = "ElementHost1";
			this.vmethod_38().Child = this.scenarioSelectControl_0;
			this.vmethod_12().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().Font = new Font("Segoe UI", 10f);
			this.vmethod_12().ForeColor = SystemColors.Control;
			this.vmethod_12().Location = new Point(892, 566);
			this.vmethod_12().Name = "Button1";
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new Size(104, 23);
			this.vmethod_12().TabIndex = 9;
			this.vmethod_12().Text = "Cancel";
			this.vmethod_14().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_14().method_2(true);
			this.vmethod_14().Font = new Font("Arial", 12f, FontStyle.Bold);
			this.vmethod_14().ForeColor = Color.Gainsboro;
			this.vmethod_14().Location = new Point(419, 12);
			this.vmethod_14().Name = "Label_Title";
			this.vmethod_14().Size = new Size(113, 19);
			this.vmethod_14().TabIndex = 10;
			this.vmethod_14().Text = "Scenario Title";
			this.vmethod_14().TextAlign = ContentAlignment.MiddleCenter;
			this.vmethod_14().Visible = false;
			this.vmethod_16().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_16().BackColor = Color.Transparent;
			this.vmethod_16().Font = new Font("Segoe UI", 9f);
			this.vmethod_16().Location = new Point(480, 546);
			this.vmethod_16().method_1(100);
			this.vmethod_16().Name = "PB_PercentComplete";
			this.vmethod_16().method_3(true);
			this.vmethod_16().method_5(false);
			this.vmethod_16().Size = new Size(516, 12);
			this.vmethod_16().TabIndex = 13;
			this.vmethod_16().Value = 0;
			this.vmethod_18().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_18().method_2(true);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(420, 545);
			this.vmethod_18().Name = "Label_Loading";
			this.vmethod_18().Size = new Size(59, 15);
			this.vmethod_18().TabIndex = 14;
			this.vmethod_18().Text = "Loading...";
			this.vmethod_20().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_20().Location = new Point(423, 89);
			this.vmethod_20().MinimumSize = new Size(20, 20);
			this.vmethod_20().Name = "WebBrowser1";
			this.vmethod_20().Size = new Size(573, 450);
			this.vmethod_20().TabIndex = 15;
			this.vmethod_20().Visible = false;
			this.vmethod_22().method_2(true);
			this.vmethod_22().ForeColor = Color.Gainsboro;
			this.vmethod_22().Location = new Point(420, 45);
			this.vmethod_22().Name = "Label1";
			this.vmethod_22().Size = new Size(58, 15);
			this.vmethod_22().TabIndex = 16;
			this.vmethod_22().Text = "Difficulty:";
			this.vmethod_22().Visible = false;
			this.vmethod_24().method_2(true);
			this.vmethod_24().ForeColor = Color.Gainsboro;
			this.vmethod_24().Location = new Point(646, 45);
			this.vmethod_24().Name = "Label2";
			this.vmethod_24().Size = new Size(71, 15);
			this.vmethod_24().TabIndex = 17;
			this.vmethod_24().Text = "Complexity:";
			this.vmethod_24().Visible = false;
			this.vmethod_26().BackColor = Color.Transparent;
			this.vmethod_26().Font = new Font("Segoe UI", 9f);
			this.vmethod_26().ForeColor = Color.FromArgb(0, 0, 0, 0);
			this.vmethod_26().Location = new Point(504, 45);
			this.vmethod_26().method_1(100);
			this.vmethod_26().Name = "PB_Difficulty";
			this.vmethod_26().method_3(true);
			this.vmethod_26().method_5(false);
			this.vmethod_26().Size = new Size(100, 16);
			this.vmethod_26().TabIndex = 19;
			this.vmethod_26().Value = 0;
			this.vmethod_26().Visible = false;
			this.vmethod_28().BackColor = Color.Transparent;
			this.vmethod_28().Font = new Font("Segoe UI", 9f);
			this.vmethod_28().ForeColor = Color.FromArgb(0, 0, 0, 0);
			this.vmethod_28().Location = new Point(722, 45);
			this.vmethod_28().method_1(100);
			this.vmethod_28().Name = "PB_Complexity";
			this.vmethod_28().method_3(true);
			this.vmethod_28().method_5(false);
			this.vmethod_28().Size = new Size(100, 16);
			this.vmethod_28().TabIndex = 20;
			this.vmethod_28().Value = 0;
			this.vmethod_28().Visible = false;
			this.vmethod_30().method_2(true);
			this.vmethod_30().ForeColor = Color.Gainsboro;
			this.vmethod_30().Location = new Point(420, 65);
			this.vmethod_30().Name = "Label4";
			this.vmethod_30().Size = new Size(104, 15);
			this.vmethod_30().TabIndex = 21;
			this.vmethod_30().Text = "Location / Setting:";
			this.vmethod_30().Visible = false;
			this.vmethod_32().method_2(true);
			this.vmethod_32().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_32().Location = new Point(12, 17);
			this.vmethod_32().Name = "Label5";
			this.vmethod_32().Size = new Size(108, 15);
			this.vmethod_32().TabIndex = 23;
			this.vmethod_32().Text = "Order scenarios by:";
			this.vmethod_34().BackColor = Color.Transparent;
			this.vmethod_34().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_34().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_34().Font = new Font("Segoe UI", 7f);
			this.vmethod_34().FormattingEnabled = true;
			this.vmethod_34().Items.AddRange(new object[]
			{
				"Name",
				"Date",
				"Difficulty",
				"Complexity"
			});
			this.vmethod_34().Location = new Point(130, 12);
			this.vmethod_34().Name = "CB_ScenOrder";
			this.vmethod_34().Size = new Size(201, 21);
			this.vmethod_34().TabIndex = 24;
			this.vmethod_40().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_40().BackColor = Color.Transparent;
			this.vmethod_40().DialogResult = DialogResult.Cancel;
			this.vmethod_40().Font = new Font("Segoe UI", 10f);
			this.vmethod_40().ForeColor = SystemColors.Control;
			this.vmethod_40().Location = new Point(657, 566);
			this.vmethod_40().Name = "Button_BrowseScenario";
			this.vmethod_40().method_1(0);
			this.vmethod_40().Size = new Size(135, 23);
			this.vmethod_40().TabIndex = 25;
			this.vmethod_40().Text = "Browse...";
			this.vmethod_42().FileName = "OpenFileDialog1";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1008, 601);
			base.Controls.Add(this.vmethod_40());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_34());
			base.Controls.Add(this.vmethod_32());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_14());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "LoadScenario";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Load Scenario";
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_6().ResumeLayout(false);
			this.vmethod_8().ResumeLayout(false);
			this.vmethod_36().ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060084DD RID: 34013 RVA: 0x00050613 File Offset: 0x0004E813
		[CompilerGenerated]
		internal Control9 vmethod_0()
		{
			return this.control9_0;
		}

		// Token: 0x060084DE RID: 34014 RVA: 0x00475E3C File Offset: 0x0047403C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_4);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_3;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060084DF RID: 34015 RVA: 0x0005061B File Offset: 0x0004E81B
		[CompilerGenerated]
		internal Control6 vmethod_2()
		{
			return this.control6_0;
		}

		// Token: 0x060084E0 RID: 34016 RVA: 0x00475E80 File Offset: 0x00474080
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control6 control6_2)
		{
			EventHandler eventHandler_ = new EventHandler(this.method_18);
			Control6.Delegate9 delegate9_ = new Control6.Delegate9(this.method_20);
			Control6 control = this.control6_0;
			if (control != null)
			{
				control.method_17(eventHandler_);
				control.method_19(delegate9_);
			}
			this.control6_0 = control6_2;
			control = this.control6_0;
			if (control != null)
			{
				control.method_16(eventHandler_);
				control.method_18(delegate9_);
			}
		}

		// Token: 0x060084E1 RID: 34017 RVA: 0x00050623 File Offset: 0x0004E823
		[CompilerGenerated]
		internal Control12 vmethod_4()
		{
			return this.control12_0;
		}

		// Token: 0x060084E2 RID: 34018 RVA: 0x0005062B File Offset: 0x0004E82B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control12 control12_1)
		{
			this.control12_0 = control12_1;
		}

		// Token: 0x060084E3 RID: 34019 RVA: 0x00050634 File Offset: 0x0004E834
		[CompilerGenerated]
		internal TabPage vmethod_6()
		{
			return this.tabPage_0;
		}

		// Token: 0x060084E4 RID: 34020 RVA: 0x0005063C File Offset: 0x0004E83C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TabPage tabPage_3)
		{
			this.tabPage_0 = tabPage_3;
		}

		// Token: 0x060084E5 RID: 34021 RVA: 0x00050645 File Offset: 0x0004E845
		[CompilerGenerated]
		internal TabPage vmethod_8()
		{
			return this.tabPage_1;
		}

		// Token: 0x060084E6 RID: 34022 RVA: 0x0005064D File Offset: 0x0004E84D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TabPage tabPage_3)
		{
			this.tabPage_1 = tabPage_3;
		}

		// Token: 0x060084E7 RID: 34023 RVA: 0x00050656 File Offset: 0x0004E856
		[CompilerGenerated]
		internal Control6 vmethod_10()
		{
			return this.control6_1;
		}

		// Token: 0x060084E8 RID: 34024 RVA: 0x00475EE0 File Offset: 0x004740E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control6 control6_2)
		{
			EventHandler eventHandler_ = new EventHandler(this.method_17);
			Control6.Delegate9 delegate9_ = new Control6.Delegate9(this.method_21);
			Control6 control = this.control6_1;
			if (control != null)
			{
				control.method_17(eventHandler_);
				control.method_19(delegate9_);
			}
			this.control6_1 = control6_2;
			control = this.control6_1;
			if (control != null)
			{
				control.method_16(eventHandler_);
				control.method_18(delegate9_);
			}
		}

		// Token: 0x060084E9 RID: 34025 RVA: 0x0005065E File Offset: 0x0004E85E
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_1;
		}

		// Token: 0x060084EA RID: 34026 RVA: 0x00475F40 File Offset: 0x00474140
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_10);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_3;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060084EB RID: 34027 RVA: 0x00050666 File Offset: 0x0004E866
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_0;
		}

		// Token: 0x060084EC RID: 34028 RVA: 0x0005066E File Offset: 0x0004E86E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_6)
		{
			this.class116_0 = class116_6;
		}

		// Token: 0x060084ED RID: 34029 RVA: 0x00050677 File Offset: 0x0004E877
		[CompilerGenerated]
		internal Control11 vmethod_16()
		{
			return this.control11_0;
		}

		// Token: 0x060084EE RID: 34030 RVA: 0x0005067F File Offset: 0x0004E87F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Control11 control11_3)
		{
			this.control11_0 = control11_3;
		}

		// Token: 0x060084EF RID: 34031 RVA: 0x00050688 File Offset: 0x0004E888
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_1;
		}

		// Token: 0x060084F0 RID: 34032 RVA: 0x00050690 File Offset: 0x0004E890
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_6)
		{
			this.class116_1 = class116_6;
		}

		// Token: 0x060084F1 RID: 34033 RVA: 0x00050699 File Offset: 0x0004E899
		[CompilerGenerated]
		internal WebBrowser vmethod_20()
		{
			return this.webBrowser_0;
		}

		// Token: 0x060084F2 RID: 34034 RVA: 0x000506A1 File Offset: 0x0004E8A1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(WebBrowser webBrowser_1)
		{
			this.webBrowser_0 = webBrowser_1;
		}

		// Token: 0x060084F3 RID: 34035 RVA: 0x000506AA File Offset: 0x0004E8AA
		[CompilerGenerated]
		internal Class116 vmethod_22()
		{
			return this.class116_2;
		}

		// Token: 0x060084F4 RID: 34036 RVA: 0x000506B2 File Offset: 0x0004E8B2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class116 class116_6)
		{
			this.class116_2 = class116_6;
		}

		// Token: 0x060084F5 RID: 34037 RVA: 0x000506BB File Offset: 0x0004E8BB
		[CompilerGenerated]
		internal Class116 vmethod_24()
		{
			return this.class116_3;
		}

		// Token: 0x060084F6 RID: 34038 RVA: 0x000506C3 File Offset: 0x0004E8C3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class116 class116_6)
		{
			this.class116_3 = class116_6;
		}

		// Token: 0x060084F7 RID: 34039 RVA: 0x000506CC File Offset: 0x0004E8CC
		[CompilerGenerated]
		internal Control11 vmethod_26()
		{
			return this.control11_1;
		}

		// Token: 0x060084F8 RID: 34040 RVA: 0x000506D4 File Offset: 0x0004E8D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Control11 control11_3)
		{
			this.control11_1 = control11_3;
		}

		// Token: 0x060084F9 RID: 34041 RVA: 0x000506DD File Offset: 0x0004E8DD
		[CompilerGenerated]
		internal Control11 vmethod_28()
		{
			return this.control11_2;
		}

		// Token: 0x060084FA RID: 34042 RVA: 0x000506E5 File Offset: 0x0004E8E5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Control11 control11_3)
		{
			this.control11_2 = control11_3;
		}

		// Token: 0x060084FB RID: 34043 RVA: 0x000506EE File Offset: 0x0004E8EE
		[CompilerGenerated]
		internal Class116 vmethod_30()
		{
			return this.class116_4;
		}

		// Token: 0x060084FC RID: 34044 RVA: 0x000506F6 File Offset: 0x0004E8F6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class116 class116_6)
		{
			this.class116_4 = class116_6;
		}

		// Token: 0x060084FD RID: 34045 RVA: 0x000506FF File Offset: 0x0004E8FF
		[CompilerGenerated]
		internal Class116 vmethod_32()
		{
			return this.class116_5;
		}

		// Token: 0x060084FE RID: 34046 RVA: 0x00050707 File Offset: 0x0004E907
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Class116 class116_6)
		{
			this.class116_5 = class116_6;
		}

		// Token: 0x060084FF RID: 34047 RVA: 0x00050710 File Offset: 0x0004E910
		[CompilerGenerated]
		internal Class2451 vmethod_34()
		{
			return this.class2451_0;
		}

		// Token: 0x06008500 RID: 34048 RVA: 0x00475F84 File Offset: 0x00474184
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Class2451 class2451_1)
		{
			EventHandler value = new EventHandler(this.method_14);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_1;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06008501 RID: 34049 RVA: 0x00050718 File Offset: 0x0004E918
		[CompilerGenerated]
		internal TabPage vmethod_36()
		{
			return this.tabPage_2;
		}

		// Token: 0x06008502 RID: 34050 RVA: 0x00050720 File Offset: 0x0004E920
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(TabPage tabPage_3)
		{
			this.tabPage_2 = tabPage_3;
		}

		// Token: 0x06008503 RID: 34051 RVA: 0x00050729 File Offset: 0x0004E929
		[CompilerGenerated]
		internal ElementHost vmethod_38()
		{
			return this.elementHost_0;
		}

		// Token: 0x06008504 RID: 34052 RVA: 0x00050731 File Offset: 0x0004E931
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(ElementHost elementHost_1)
		{
			this.elementHost_0 = elementHost_1;
		}

		// Token: 0x06008505 RID: 34053 RVA: 0x0005073A File Offset: 0x0004E93A
		[CompilerGenerated]
		internal Control9 vmethod_40()
		{
			return this.control9_2;
		}

		// Token: 0x06008506 RID: 34054 RVA: 0x00475FC8 File Offset: 0x004741C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_22);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_3;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008507 RID: 34055 RVA: 0x00050742 File Offset: 0x0004E942
		[CompilerGenerated]
		internal OpenFileDialog vmethod_42()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x06008508 RID: 34056 RVA: 0x0005074A File Offset: 0x0004E94A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x06008509 RID: 34057 RVA: 0x00050753 File Offset: 0x0004E953
		[CompilerGenerated]
		private BackgroundWorker vmethod_44()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x0600850A RID: 34058 RVA: 0x0047600C File Offset: 0x0047420C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_45(BackgroundWorker backgroundWorker_2)
		{
			DoWorkEventHandler doWorkEventHandler = new DoWorkEventHandler(this.method_12);
			RunWorkerCompletedEventHandler runWorkerCompletedEventHandler = new RunWorkerCompletedEventHandler(this.method_13);
			BackgroundWorker backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted -= runWorkerCompletedEventHandler;
			}
			this.backgroundWorker_0 = backgroundWorker_2;
			backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted += runWorkerCompletedEventHandler;
			}
		}

		// Token: 0x0600850B RID: 34059 RVA: 0x0005075B File Offset: 0x0004E95B
		[CompilerGenerated]
		private BackgroundWorker vmethod_46()
		{
			return this.backgroundWorker_1;
		}

		// Token: 0x0600850C RID: 34060 RVA: 0x0047606C File Offset: 0x0047426C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_47(BackgroundWorker backgroundWorker_2)
		{
			DoWorkEventHandler doWorkEventHandler = new DoWorkEventHandler(this.method_15);
			RunWorkerCompletedEventHandler runWorkerCompletedEventHandler = new RunWorkerCompletedEventHandler(this.method_16);
			BackgroundWorker backgroundWorker = this.backgroundWorker_1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted -= runWorkerCompletedEventHandler;
			}
			this.backgroundWorker_1 = backgroundWorker_2;
			backgroundWorker = this.backgroundWorker_1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted += runWorkerCompletedEventHandler;
			}
		}

		// Token: 0x0600850D RID: 34061 RVA: 0x004760CC File Offset: 0x004742CC
		public LoadScenario()
		{
			base.FormClosing += this.LoadScenario_FormClosing;
			base.Load += this.LoadScenario_Load;
			base.KeyDown += this.LoadScenario_KeyDown;
			base.FormClosed += this.LoadScenario_FormClosed;
			this.vmethod_45(new BackgroundWorker());
			this.vmethod_47(new BackgroundWorker());
			this.InitializeComponent_1();
			this.bool_1 = false;
			this.bool_2 = true;
			this.scenarioSelectControl_0.VM.loadScenario_0 = this;
		}

		// Token: 0x0600850E RID: 34062 RVA: 0x00476164 File Offset: 0x00474364
		private bool method_3(WebBrowser webBrowser_1, string string_3, string string_4)
		{
			bool result;
			if (string.IsNullOrEmpty(string_3))
			{
				result = false;
			}
			else if (string_3.Contains("[LOADDOC]"))
			{
				int num = Strings.InStr(string_3, "[LOADDOC]", CompareMethod.Binary) + "[LOADDOC]".Length - 1;
				int num2 = Strings.InStr(string_3, "[/LOADDOC]", CompareMethod.Binary);
				string path = string_3.Substring(num, string_3.Length - num - (string_3.Length - num2 + 1));
				if (File.Exists(Path.Combine(string_4, path)))
				{
					webBrowser_1.Navigate(Path.Combine(string_4, path));
					webBrowser_1.Visible = true;
					result = true;
				}
				else
				{
					string string_5 = Scenario.smethod_23(this.scenContainer_0.method_7(), "CampaignID");
					Class264 @class = Class264.smethod_2(GameGeneral.string_4, string_5);
					if (!Information.IsNothing(@class))
					{
						webBrowser_1.Navigate(Path.Combine(@class.string_4, path));
						webBrowser_1.Visible = true;
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600850F RID: 34063 RVA: 0x0047624C File Offset: 0x0047444C
		private void method_4(object sender, EventArgs e)
		{
			MainForm.bool_2 = true;
			if (!Information.IsNothing(this.scenContainer_0))
			{
				this.vmethod_0().Enabled = false;
				if (Client.smethod_0().method_0() == Class279.Enum68.const_1)
				{
					Client.smethod_0().method_4();
				}
				this.bool_3 = false;
				this.scenario_0 = null;
				this.vmethod_44().RunWorkerAsync();
				this.vmethod_18().Visible = true;
				this.vmethod_16().Visible = true;
				while (this.vmethod_44().IsBusy)
				{
					Application.DoEvents();
					this.vmethod_16().Value = (int)Math.Round(this.double_0 * 100.0);
					Thread.Sleep(50);
				}
				if (!Information.IsNothing(this.scenario_0))
				{
					Client.smethod_103(this.scenario_0, this.string_0);
					base.Close();
				}
				this.vmethod_0().Enabled = true;
				this.vmethod_18().Visible = false;
				this.vmethod_16().Visible = false;
				MainForm.bool_2 = false;
			}
		}

		// Token: 0x06008510 RID: 34064 RVA: 0x00476350 File Offset: 0x00474550
		private List<string> method_5(IEnumerable<string> ienumerable_0)
		{
			List<string> result = new List<string>();
			switch (this.vmethod_34().SelectedIndex)
			{
			case 0:
				result = Enumerable.ToList<string>(Enumerable.OrderBy<string, string>(ienumerable_0, (LoadScenario._Closure$__.$I115-0 == null) ? (LoadScenario._Closure$__.$I115-0 = new Func<string, string>(LoadScenario._Closure$__.$I.method_0)) : LoadScenario._Closure$__.$I115-0, new Class399()));
				break;
			case 1:
				result = Enumerable.ToList<string>(Enumerable.OrderBy<string, string>(ienumerable_0, (LoadScenario._Closure$__.$I115-1 == null) ? (LoadScenario._Closure$__.$I115-1 = new Func<string, string>(LoadScenario._Closure$__.$I.method_1)) : LoadScenario._Closure$__.$I115-1));
				break;
			case 2:
				result = Enumerable.ToList<string>(Enumerable.OrderBy<string, string>(ienumerable_0, (LoadScenario._Closure$__.$I115-2 == null) ? (LoadScenario._Closure$__.$I115-2 = new Func<string, string>(LoadScenario._Closure$__.$I.method_2)) : LoadScenario._Closure$__.$I115-2));
				break;
			case 3:
				result = Enumerable.ToList<string>(Enumerable.OrderBy<string, string>(ienumerable_0, (LoadScenario._Closure$__.$I115-3 == null) ? (LoadScenario._Closure$__.$I115-3 = new Func<string, string>(LoadScenario._Closure$__.$I.method_3)) : LoadScenario._Closure$__.$I115-3));
				break;
			}
			return result;
		}

		// Token: 0x06008511 RID: 34065 RVA: 0x0047645C File Offset: 0x0047465C
		private void method_6()
		{
			this.vmethod_2().method_20().Clear();
			this.vmethod_2().method_29(false);
			List<string> list = Enumerable.ToList<string>(Directory.GetDirectories(GameGeneral.string_4));
			string text = string.Empty;
			if (Class2556.smethod_6(Class2556.Enum209.const_0))
			{
				try
				{
					foreach (string text2 in list)
					{
						if (text2.EndsWith("Standalone Scenarios"))
						{
							text = text2;
							break;
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (!string.IsNullOrEmpty(text))
				{
					list.Remove(text);
					list.Insert(0, text);
				}
			}
			text = string.Empty;
			try
			{
				foreach (string text3 in list)
				{
					if (text3.EndsWith("Tutorials"))
					{
						text = text3;
						break;
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			if (!string.IsNullOrEmpty(text))
			{
				list.Remove(text);
				list.Insert(0, text);
			}
			try
			{
				foreach (string text4 in list)
				{
					if (this.method_8(text4))
					{
						Class127 @class = new Class127(Path.GetFileName(text4));
						this.vmethod_2().method_20().method_4(@class);
						@class.Tag = text4;
						if (Enumerable.Count<string>(Directory.GetDirectories(text4)) > 0 | Enumerable.Count<string>(Directory.GetFiles(text4)) > 0)
						{
							@class.method_23().method_4(new Class127("virtual"));
						}
						string value = this.method_9(text4);
						if (!string.IsNullOrEmpty(value) && !Class2556.smethod_10(Class2556.smethod_7(value)))
						{
							this.vmethod_2().method_29(true);
							@class.method_19(this.bitmap_0);
						}
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
			List<string> ienumerable_ = this.method_5(Enumerable.Where<string>(Directory.GetFiles(GameGeneral.string_4), (LoadScenario._Closure$__.$I116-0 == null) ? (LoadScenario._Closure$__.$I116-0 = new Func<string, bool>(LoadScenario._Closure$__.$I.method_4)) : LoadScenario._Closure$__.$I116-0));
			List<string> list2 = this.method_5(ienumerable_);
			try
			{
				foreach (string text5 in list2)
				{
					Class127 @class = new Class127(Path.GetFileName(text5));
					this.vmethod_2().method_20().method_4(@class);
					@class.Tag = text5;
				}
			}
			finally
			{
				List<string>.Enumerator enumerator4;
				((IDisposable)enumerator4).Dispose();
			}
		}

		// Token: 0x06008512 RID: 34066 RVA: 0x004766F8 File Offset: 0x004748F8
		private void method_7()
		{
			this.vmethod_10().method_20().Clear();
			this.vmethod_10().method_29(false);
			foreach (string text in Directory.GetDirectories(GameGeneral.string_4))
			{
				if (this.method_8(text))
				{
					Class127 @class = new Class127(Path.GetFileName(text));
					this.vmethod_10().method_20().method_4(@class);
					@class.Tag = text;
					if (Enumerable.Count<string>(Directory.GetDirectories(text)) > 0 | Enumerable.Count<string>(Directory.GetFiles(text)) > 0)
					{
						@class.method_23().method_4(new Class127("virtual"));
					}
					string value = this.method_9(text);
					if (!string.IsNullOrEmpty(value) && !Class2556.smethod_10(Class2556.smethod_7(value)))
					{
						this.vmethod_10().method_29(true);
						@class.method_19(this.bitmap_0);
					}
				}
			}
			List<string> list = this.method_5(Enumerable.Where<string>(Directory.GetFiles(GameGeneral.string_4), (LoadScenario._Closure$__.$I117-0 == null) ? (LoadScenario._Closure$__.$I117-0 = new Func<string, bool>(LoadScenario._Closure$__.$I.method_5)) : LoadScenario._Closure$__.$I117-0));
			try
			{
				foreach (string text2 in list)
				{
					this.string_1 = Path.GetFileName(text2);
					this.fileInfo_0 = new FileInfo(text2);
					this.string_1 = string.Concat(new string[]
					{
						"[",
						this.fileInfo_0.LastWriteTime.ToShortDateString(),
						" ",
						this.fileInfo_0.LastWriteTime.ToShortTimeString(),
						"] ",
						this.string_1
					});
					Class127 @class = new Class127(this.string_1);
					this.vmethod_10().method_20().method_4(@class);
					@class.Tag = text2;
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06008513 RID: 34067 RVA: 0x00476904 File Offset: 0x00474B04
		private bool method_8(string string_3)
		{
			foreach (string text in Directory.GetFiles(string_3))
			{
				if (text.EndsWith(".scen") || text.EndsWith(".save"))
				{
					return true;
				}
			}
			foreach (string string_4 in Directory.GetDirectories(string_3))
			{
				if (this.method_8(string_4))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06008514 RID: 34068 RVA: 0x0047697C File Offset: 0x00474B7C
		private string method_9(string string_3)
		{
			foreach (string text in Directory.GetFiles(string_3))
			{
				if (text.EndsWith(".campaign"))
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(text);
					return xmlDocument.ChildNodes[1].ChildNodes[0].InnerText;
				}
			}
			return null;
		}

		// Token: 0x06008515 RID: 34069 RVA: 0x0004B84D File Offset: 0x00049A4D
		private void LoadScenario_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().Enabled = true;
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06008516 RID: 34070 RVA: 0x004769DC File Offset: 0x00474BDC
		private void LoadScenario_Load(object sender, EventArgs e)
		{
			this.vmethod_14().ForeColor = Color.Gainsboro;
			Class2413.smethod_2().method_41().Enabled = false;
			this.vmethod_34().SelectedIndex = 0;
			this.vmethod_18().Visible = false;
			this.vmethod_16().Visible = false;
			this.vmethod_4().SelectedIndex = (int)this.enum208_0;
			this.vmethod_20().Visible = false;
			this.bitmap_0 = (Bitmap)Image.FromFile(Class2413.smethod_1().Info.DirectoryPath + "\\Symbols\\Lock.png");
			this.method_6();
			this.method_7();
		}

		// Token: 0x06008517 RID: 34071 RVA: 0x00050763 File Offset: 0x0004E963
		private void method_10(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_41().Enabled = true;
			base.Close();
		}

		// Token: 0x06008518 RID: 34072 RVA: 0x00476A80 File Offset: 0x00474C80
		private void method_11(Class127 class127_0)
		{
			LoadScenario.Class2511 @class = new LoadScenario.Class2511(@class);
			class127_0.method_23().Clear();
			string path = class127_0.Tag.ToString();
			@class.string_0 = "";
			int selectedIndex = this.vmethod_4().SelectedIndex;
			if (selectedIndex != 0)
			{
				if (selectedIndex != 1)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				else
				{
					@class.string_0 = ".save";
				}
			}
			else
			{
				@class.string_0 = ".scen";
			}
			List<string> list = Enumerable.ToList<string>(Enumerable.OrderBy<string, string>(Directory.GetDirectories(path), (LoadScenario._Closure$__.$I123-0 == null) ? (LoadScenario._Closure$__.$I123-0 = new Func<string, string>(LoadScenario._Closure$__.$I.method_6)) : LoadScenario._Closure$__.$I123-0, new Class399()));
			try
			{
				foreach (string text in list)
				{
					if (this.method_8(text))
					{
						Class127 class2 = new Class127(Path.GetFileName(text));
						class127_0.method_23().method_4(class2);
						class2.Tag = text;
						if (Directory.GetDirectories(text).Length > 0 | Directory.GetFiles(text).Length > 0)
						{
							class2.method_23().method_4(new Class127("virtual"));
						}
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			List<string> list2 = this.method_5(Enumerable.Where<string>(Directory.GetFiles(path), new Func<string, bool>(@class.method_0)));
			try
			{
				foreach (string text2 in list2)
				{
					this.string_1 = Path.GetFileName(text2);
					if (Operators.CompareString(@class.string_0, ".save", false) == 0)
					{
						this.fileInfo_0 = new FileInfo(text2);
						this.string_1 = string.Concat(new string[]
						{
							"[",
							this.fileInfo_0.LastWriteTime.ToShortDateString(),
							" ",
							this.fileInfo_0.LastWriteTime.ToShortTimeString(),
							"] ",
							this.string_1
						});
					}
					Class127 class2 = new Class127(this.string_1);
					class127_0.method_23().method_4(class2);
					class2.Tag = text2;
				}
			}
			finally
			{
				List<string>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
		}

		// Token: 0x06008519 RID: 34073 RVA: 0x00476CD0 File Offset: 0x00474ED0
		private void method_12(object sender, DoWorkEventArgs e)
		{
			try
			{
				string theXMLText = this.scenContainer_0.method_7();
				CMANO.smethod_0();
				this.string_2 = Scenario.smethod_23(theXMLText, "ContentTag");
				if (string.IsNullOrEmpty(this.string_2))
				{
					this.string_2 = "";
				}
				if (!Class2556.smethod_10(this.string_2))
				{
					this.bool_4 = false;
				}
				else
				{
					this.bool_4 = true;
					Scenario scenario = Scenario.smethod_19(theXMLText, ref Client.string_2, ref this.double_0, false, true);
					if (Information.IsNothing(scenario))
					{
						this.bool_4 = true;
					}
					else
					{
						Client.smethod_82(ref scenario);
						if (scenario.vmethod_2().Count > 0)
						{
							Class258.smethod_1(scenario, this.string_0);
						}
						this.scenario_0 = scenario;
					}
				}
			}
			catch (Exception2 exception)
			{
				DarkMessageBox.smethod_2(exception.Message, "Error", Enum11.const_0);
				this.bool_4 = true;
			}
			catch (Exception ex)
			{
				DarkMessageBox.smethod_2(ex.Message, "Error", Enum11.const_0);
				ex.Data.Add("Error at 101159", "");
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				this.bool_4 = true;
				throw;
			}
		}

		// Token: 0x0600851A RID: 34074 RVA: 0x00476E10 File Offset: 0x00475010
		private void method_13(object sender, RunWorkerCompletedEventArgs e)
		{
			if (!this.bool_4)
			{
				Class2413.smethod_2().method_30().method_2(new List<Class2556.Enum209>
				{
					Class2556.smethod_12(this.string_2)
				});
				Class2413.smethod_2().method_30().Show();
				return;
			}
			this.bool_3 = true;
		}

		// Token: 0x0600851B RID: 34075 RVA: 0x0004B8B4 File Offset: 0x00049AB4
		private void LoadScenario_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x0600851C RID: 34076 RVA: 0x00476E64 File Offset: 0x00475064
		private void method_14(object sender, EventArgs e)
		{
			LoadScenario.Class2512 @class = new LoadScenario.Class2512(@class);
			List<Class127> list = new List<Class127>();
			@class.string_0 = "";
			Control6 control = null;
			switch (this.vmethod_4().SelectedIndex)
			{
			case 0:
				control = this.vmethod_2();
				@class.string_0 = ".scen";
				break;
			case 1:
				control = this.vmethod_10();
				@class.string_0 = ".save";
				break;
			case 2:
				this.scenarioSelectControl_0.VM.method_1(this.vmethod_34().SelectedIndex);
				return;
			default:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				break;
			}
			list = Enumerable.ToList<Class127>(Class2558.smethod_9(control));
			try
			{
				foreach (Class127 class2 in list)
				{
					if (class2.method_21())
					{
						this.method_11(class2);
					}
				}
			}
			finally
			{
				List<Class127>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			List<Class127> list2 = new List<Class127>();
			try
			{
				foreach (Class127 class3 in control.method_20())
				{
					if (class3.method_23().Count == 0)
					{
						list2.Add(class3);
					}
				}
			}
			finally
			{
				List<Class127>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			try
			{
				foreach (Class127 gparam_ in list2)
				{
					control.method_20().method_6(gparam_);
				}
			}
			finally
			{
				List<Class127>.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
			List<string> list3 = this.method_5(Enumerable.Where<string>(Directory.GetFiles(Application.StartupPath + "\\Scenarios\\"), new Func<string, bool>(@class.method_0)));
			try
			{
				foreach (string text in list3)
				{
					this.string_1 = Path.GetFileName(text);
					if (Operators.CompareString(@class.string_0, ".save", false) == 0)
					{
						this.fileInfo_0 = new FileInfo(text);
						this.string_1 = string.Concat(new string[]
						{
							"[",
							this.fileInfo_0.LastWriteTime.ToShortDateString(),
							" ",
							this.fileInfo_0.LastWriteTime.ToShortTimeString(),
							"] ",
							this.string_1
						});
					}
					Class127 class4 = new Class127(this.string_1);
					control.method_20().method_4(class4);
					class4.Tag = text;
				}
			}
			finally
			{
				List<string>.Enumerator enumerator4;
				((IDisposable)enumerator4).Dispose();
			}
		}

		// Token: 0x0600851D RID: 34077 RVA: 0x0005077B File Offset: 0x0004E97B
		private void LoadScenario_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.scenario_0 = null;
		}

		// Token: 0x0600851E RID: 34078 RVA: 0x00050784 File Offset: 0x0004E984
		private void method_15(object sender, DoWorkEventArgs e)
		{
			if (!Information.IsNothing(this.scenContainer_0))
			{
				this.string_2 = Scenario.smethod_23(this.scenContainer_0.method_7(), "ContentTag");
			}
		}

		// Token: 0x0600851F RID: 34079 RVA: 0x000507AE File Offset: 0x0004E9AE
		private void method_16(object sender, RunWorkerCompletedEventArgs e)
		{
			if (!Class2556.smethod_10(this.string_2))
			{
				this.vmethod_14().Text = "[NOT LICENSED] " + this.scenContainer_0.ScenTitle;
				this.vmethod_14().ForeColor = Color.Red;
			}
		}

		// Token: 0x06008520 RID: 34080 RVA: 0x00477110 File Offset: 0x00475310
		private void method_17(object sender, EventArgs e)
		{
			if (this.vmethod_10().method_22().Count != 0)
			{
				string text = this.vmethod_10().method_22()[0].Tag.ToString();
				if (Directory.Exists(text))
				{
					this.vmethod_14().Visible = false;
					this.vmethod_22().Visible = false;
					this.vmethod_26().Visible = false;
					this.vmethod_24().Visible = false;
					this.vmethod_28().Visible = false;
					this.vmethod_30().Visible = false;
					this.vmethod_20().Visible = false;
					return;
				}
				if (File.Exists(text))
				{
					this.vmethod_14().Visible = true;
					this.vmethod_22().Visible = true;
					this.vmethod_26().Visible = true;
					this.vmethod_24().Visible = true;
					this.vmethod_28().Visible = true;
					this.vmethod_30().Visible = true;
					this.method_19(text, this.vmethod_10().method_22()[0].Tag.ToString());
				}
			}
		}

		// Token: 0x06008521 RID: 34081 RVA: 0x00477220 File Offset: 0x00475420
		private void method_18(object sender, EventArgs e)
		{
			if (this.vmethod_2().method_22().Count != 0)
			{
				string text = this.vmethod_2().method_22()[0].Tag.ToString();
				if (Directory.Exists(text))
				{
					this.vmethod_14().Visible = false;
					this.vmethod_22().Visible = false;
					this.vmethod_26().Visible = false;
					this.vmethod_24().Visible = false;
					this.vmethod_28().Visible = false;
					this.vmethod_30().Visible = false;
					this.vmethod_20().Visible = false;
					return;
				}
				if (File.Exists(text))
				{
					this.vmethod_14().Visible = true;
					this.vmethod_22().Visible = true;
					this.vmethod_26().Visible = true;
					this.vmethod_24().Visible = true;
					this.vmethod_28().Visible = true;
					this.vmethod_30().Visible = true;
					this.vmethod_20().Visible = true;
					this.method_19(text, this.vmethod_2().method_22()[0].Tag.ToString());
				}
			}
		}

		// Token: 0x06008522 RID: 34082 RVA: 0x0047733C File Offset: 0x0047553C
		public void method_19(string string_3, string string_4)
		{
			try
			{
				this.scenContainer_0 = ScenContainer.smethod_2(string_3);
				this.string_0 = string_4;
				if (!this.method_3(this.vmethod_20(), this.scenContainer_0.ScenDescription, Path.GetDirectoryName(this.string_0)))
				{
					Class2558.smethod_11(this.vmethod_20(), this.scenContainer_0.ScenDescription);
					this.vmethod_20().Visible = true;
				}
				this.vmethod_14().Text = this.scenContainer_0.ScenTitle;
				this.vmethod_14().ForeColor = Color.Gainsboro;
				if (!this.vmethod_46().IsBusy)
				{
					this.vmethod_46().RunWorkerAsync();
				}
				this.vmethod_26().Value = (int)(20 * this.scenContainer_0.Difficulty);
				this.vmethod_28().Value = (int)(20 * this.scenContainer_0.Complexity);
				switch (this.scenContainer_0.Difficulty)
				{
				case 1:
					this.vmethod_26().method_6(Color.Green);
					break;
				case 2:
					this.vmethod_26().method_6(Color.LimeGreen);
					break;
				case 3:
					this.vmethod_26().method_6(Color.Yellow);
					break;
				case 4:
					this.vmethod_26().method_6(Color.Orange);
					break;
				case 5:
					this.vmethod_26().method_6(Color.Red);
					break;
				}
				switch (this.scenContainer_0.Complexity)
				{
				case 1:
					this.vmethod_28().method_6(Color.Green);
					break;
				case 2:
					this.vmethod_28().method_6(Color.LimeGreen);
					break;
				case 3:
					this.vmethod_28().method_6(Color.Yellow);
					break;
				case 4:
					this.vmethod_28().method_6(Color.Orange);
					break;
				case 5:
					this.vmethod_28().method_6(Color.Red);
					break;
				}
				this.vmethod_30().Text = "";
				if (!string.IsNullOrEmpty(this.scenContainer_0.ScenSetting))
				{
					this.vmethod_30().Text = "Location: " + this.scenContainer_0.ScenSetting;
				}
				if (!string.IsNullOrEmpty(this.scenContainer_0.ScenSetting))
				{
					this.vmethod_30().Text = this.vmethod_30().Text + "  --  ";
				}
				this.vmethod_30().Text = this.vmethod_30().Text + "Year: " + Conversions.ToString((int)this.scenContainer_0.ScenDate);
				if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
				{
					Client.string_3 = string_3;
				}
				else
				{
					Client.string_3 = null;
				}
			}
			catch (Exception ex)
			{
				this.vmethod_14().Text = "Error!";
				Class2558.smethod_11(this.vmethod_20(), string.Concat(new string[]
				{
					"ERROR - Unable to load scenario! Please copy this entire text and submit it to the dev team for investigation. \r\n\r\nException: ",
					ex.Message,
					"\r\n\r\nException source: ",
					ex.Source,
					"\r\n\r\nStack Trace:\r\n",
					ex.StackTrace
				}));
				this.vmethod_14().ForeColor = Color.Red;
			}
		}

		// Token: 0x06008523 RID: 34083 RVA: 0x000507ED File Offset: 0x0004E9ED
		private void method_20(Control6 control6_2, Class127 class127_0)
		{
			this.method_11(class127_0);
		}

		// Token: 0x06008524 RID: 34084 RVA: 0x000507ED File Offset: 0x0004E9ED
		private void method_21(Control6 control6_2, Class127 class127_0)
		{
			this.method_11(class127_0);
		}

		// Token: 0x06008525 RID: 34085 RVA: 0x0047766C File Offset: 0x0047586C
		private void method_22(object sender, EventArgs e)
		{
			this.vmethod_42().DefaultExt = "*.scen;*.save";
			this.vmethod_42().FileName = "*.scen;*.save";
			this.vmethod_42().Filter = "Scenario files (.scen)|*.scen|Save files (.save)|*.save";
			if (this.vmethod_42().ShowDialog() == DialogResult.OK)
			{
				Class2413.smethod_2().method_55().string_0 = this.vmethod_42().FileName;
				Class2413.smethod_2().method_55().Show();
				if (Class2413.smethod_2().method_67().Visible)
				{
					Class2413.smethod_2().method_67().Close();
				}
				base.Close();
			}
		}

		// Token: 0x040048A4 RID: 18596
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_0;

		// Token: 0x040048A5 RID: 18597
		[AccessedThroughProperty("TV_Scens")]
		[CompilerGenerated]
		private Control6 control6_0;

		// Token: 0x040048A6 RID: 18598
		[AccessedThroughProperty("TabControl1")]
		[CompilerGenerated]
		private Control12 control12_0;

		// Token: 0x040048A7 RID: 18599
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage1")]
		private TabPage tabPage_0;

		// Token: 0x040048A8 RID: 18600
		[AccessedThroughProperty("TabPage2")]
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x040048A9 RID: 18601
		[CompilerGenerated]
		[AccessedThroughProperty("TV_Saves")]
		private Control6 control6_1;

		// Token: 0x040048AA RID: 18602
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_1;

		// Token: 0x040048AB RID: 18603
		[AccessedThroughProperty("Label_Title")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x040048AC RID: 18604
		[CompilerGenerated]
		[AccessedThroughProperty("PB_PercentComplete")]
		private Control11 control11_0;

		// Token: 0x040048AD RID: 18605
		[AccessedThroughProperty("Label_Loading")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x040048AE RID: 18606
		[CompilerGenerated]
		[AccessedThroughProperty("WebBrowser1")]
		private WebBrowser webBrowser_0;

		// Token: 0x040048AF RID: 18607
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_2;

		// Token: 0x040048B0 RID: 18608
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_3;

		// Token: 0x040048B1 RID: 18609
		[AccessedThroughProperty("PB_Difficulty")]
		[CompilerGenerated]
		private Control11 control11_1;

		// Token: 0x040048B2 RID: 18610
		[AccessedThroughProperty("PB_Complexity")]
		[CompilerGenerated]
		private Control11 control11_2;

		// Token: 0x040048B3 RID: 18611
		[CompilerGenerated]
		[AccessedThroughProperty("Label4")]
		private Class116 class116_4;

		// Token: 0x040048B4 RID: 18612
		[AccessedThroughProperty("Label5")]
		[CompilerGenerated]
		private Class116 class116_5;

		// Token: 0x040048B5 RID: 18613
		[AccessedThroughProperty("CB_ScenOrder")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x040048B6 RID: 18614
		[AccessedThroughProperty("TabPage3")]
		[CompilerGenerated]
		private TabPage tabPage_2;

		// Token: 0x040048B7 RID: 18615
		[AccessedThroughProperty("ElementHost1")]
		[CompilerGenerated]
		private ElementHost elementHost_0;

		// Token: 0x040048B8 RID: 18616
		internal ScenarioSelectControl scenarioSelectControl_0;

		// Token: 0x040048B9 RID: 18617
		[AccessedThroughProperty("Button_BrowseScenario")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x040048BA RID: 18618
		[CompilerGenerated]
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x040048BB RID: 18619
		private string string_0;

		// Token: 0x040048BC RID: 18620
		public LoadScenario.Enum208 enum208_0;

		// Token: 0x040048BD RID: 18621
		[CompilerGenerated]
		[AccessedThroughProperty("BW_LoadScen")]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x040048BE RID: 18622
		[CompilerGenerated]
		[AccessedThroughProperty("BW_CheckContentTag")]
		private BackgroundWorker backgroundWorker_1;

		// Token: 0x040048BF RID: 18623
		private Scenario scenario_0;

		// Token: 0x040048C0 RID: 18624
		private bool bool_3;

		// Token: 0x040048C1 RID: 18625
		private double double_0;

		// Token: 0x040048C2 RID: 18626
		private bool bool_4;

		// Token: 0x040048C3 RID: 18627
		private string string_1;

		// Token: 0x040048C4 RID: 18628
		private FileInfo fileInfo_0;

		// Token: 0x040048C5 RID: 18629
		private ScenContainer scenContainer_0;

		// Token: 0x040048C6 RID: 18630
		private string string_2;

		// Token: 0x040048C7 RID: 18631
		private Bitmap bitmap_0;

		// Token: 0x02000EDD RID: 3805
		internal enum Enum208 : byte
		{
			// Token: 0x040048C9 RID: 18633
			const_0,
			// Token: 0x040048CA RID: 18634
			const_1
		}

		// Token: 0x02000EDF RID: 3807
		[CompilerGenerated]
		internal sealed class Class2511
		{
			// Token: 0x0600852F RID: 34095 RVA: 0x00050855 File Offset: 0x0004EA55
			public Class2511(LoadScenario.Class2511 class2511_0)
			{
				if (class2511_0 != null)
				{
					this.string_0 = class2511_0.string_0;
				}
			}

			// Token: 0x06008530 RID: 34096 RVA: 0x0005086C File Offset: 0x0004EA6C
			internal bool method_0(string string_1)
			{
				return Operators.CompareString(Path.GetExtension(string_1), this.string_0, false) == 0;
			}

			// Token: 0x040048D3 RID: 18643
			public string string_0;
		}

		// Token: 0x02000EE0 RID: 3808
		[CompilerGenerated]
		internal sealed class Class2512
		{
			// Token: 0x06008531 RID: 34097 RVA: 0x00050883 File Offset: 0x0004EA83
			public Class2512(LoadScenario.Class2512 class2512_0)
			{
				if (class2512_0 != null)
				{
					this.string_0 = class2512_0.string_0;
				}
			}

			// Token: 0x06008532 RID: 34098 RVA: 0x0005089A File Offset: 0x0004EA9A
			internal bool method_0(string string_1)
			{
				return Operators.CompareString(Path.GetExtension(string_1), this.string_0, false) == 0;
			}

			// Token: 0x040048D4 RID: 18644
			public string string_0;
		}
	}
}
