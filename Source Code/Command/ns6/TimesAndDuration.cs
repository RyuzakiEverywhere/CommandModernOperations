using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000EE3 RID: 3811
	[DesignerGenerated]
	internal sealed partial class TimesAndDuration : DarkSecondaryFormBase
	{
		// Token: 0x06008578 RID: 34168 RVA: 0x0047A660 File Offset: 0x00478860
		public TimesAndDuration()
		{
			base.Load += this.TimesAndDuration_Load;
			base.KeyDown += this.TimesAndDuration_KeyDown;
			base.FormClosing += this.TimesAndDuration_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x0600857A RID: 34170 RVA: 0x0047A6F0 File Offset: 0x004788F0
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Class116());
			this.vmethod_3(new Control8());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Control8());
			this.vmethod_9(new Class116());
			this.vmethod_11(new Class118());
			this.vmethod_13(new Class116());
			this.vmethod_15(new Class116());
			this.vmethod_17(new Control8());
			this.vmethod_19(new Control9());
			this.vmethod_21(new Control9());
			this.vmethod_23(new Class118());
			this.vmethod_25(new Class118());
			this.vmethod_27(new Class116());
			this.vmethod_29(new Class118());
			this.vmethod_31(new Class116());
			this.vmethod_33(new Control10());
			this.vmethod_35(new Class116());
			this.vmethod_37(new Class116());
			this.vmethod_39(new Control8());
			this.vmethod_41(new Control10());
			this.vmethod_43(new Class112());
			this.vmethod_45(new Class116());
			this.vmethod_47(new Class116());
			this.vmethod_49(new MaskedTextBox());
			this.vmethod_51(new MaskedTextBox());
			this.vmethod_53(new Control9());
			base.SuspendLayout();
			this.vmethod_0().method_2(true);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(211, 240);
			this.vmethod_0().Name = "Label4";
			this.vmethod_0().Size = new Size(33, 15);
			this.vmethod_0().TabIndex = 15;
			this.vmethod_0().Text = "mins";
			this.vmethod_2().method_14(null);
			this.vmethod_2().method_15(AutoCompleteMode.None);
			this.vmethod_2().method_13(AutoCompleteSource.None);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().method_17(new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161));
			this.vmethod_2().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_2().method_12(null);
			this.vmethod_2().method_18(null);
			this.vmethod_2().Location = new Point(83, 237);
			this.vmethod_2().method_2(32767);
			this.vmethod_2().method_7(false);
			this.vmethod_2().Name = "TB_Hours";
			this.vmethod_2().method_3(false);
			this.vmethod_2().method_9(0);
			this.vmethod_2().Size = new Size(39, 24);
			this.vmethod_2().TabIndex = 14;
			this.vmethod_2().Text = "0";
			this.vmethod_2().method_1(HorizontalAlignment.Left);
			this.vmethod_2().method_5(false);
			this.vmethod_2().method_10("");
			this.vmethod_4().method_2(true);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(127, 240);
			this.vmethod_4().Name = "Label3";
			this.vmethod_4().Size = new Size(37, 15);
			this.vmethod_4().TabIndex = 13;
			this.vmethod_4().Text = "hours";
			this.vmethod_6().method_14(null);
			this.vmethod_6().method_15(AutoCompleteMode.None);
			this.vmethod_6().method_13(AutoCompleteSource.None);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().method_17(new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161));
			this.vmethod_6().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_6().method_12(null);
			this.vmethod_6().method_18(null);
			this.vmethod_6().Location = new Point(12, 238);
			this.vmethod_6().method_2(32767);
			this.vmethod_6().method_7(false);
			this.vmethod_6().Name = "TB_Days";
			this.vmethod_6().method_3(false);
			this.vmethod_6().method_9(0);
			this.vmethod_6().Size = new Size(35, 24);
			this.vmethod_6().TabIndex = 12;
			this.vmethod_6().Text = "0";
			this.vmethod_6().method_1(HorizontalAlignment.Left);
			this.vmethod_6().method_5(false);
			this.vmethod_6().method_10("");
			this.vmethod_8().method_2(true);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(48, 241);
			this.vmethod_8().Name = "Label2";
			this.vmethod_8().Size = new Size(31, 15);
			this.vmethod_8().TabIndex = 11;
			this.vmethod_8().Text = "days";
			this.vmethod_10().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_10().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Location = new Point(12, 167);
			this.vmethod_10().Name = "DTP_StartDate";
			this.vmethod_10().Size = new Size(305, 23);
			this.vmethod_10().TabIndex = 10;
			this.vmethod_12().method_2(true);
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Location = new Point(12, 151);
			this.vmethod_12().Name = "Label1";
			this.vmethod_12().Size = new Size(103, 15);
			this.vmethod_12().TabIndex = 16;
			this.vmethod_12().Text = "Scenario starts on:";
			this.vmethod_14().method_2(true);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(9, 222);
			this.vmethod_14().Name = "Label5";
			this.vmethod_14().Size = new Size(76, 15);
			this.vmethod_14().TabIndex = 17;
			this.vmethod_14().Text = "And lasts for:";
			this.vmethod_16().method_14(null);
			this.vmethod_16().method_15(AutoCompleteMode.None);
			this.vmethod_16().method_13(AutoCompleteSource.None);
			this.vmethod_16().BackColor = Color.Transparent;
			this.vmethod_16().method_17(new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161));
			this.vmethod_16().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_16().method_12(null);
			this.vmethod_16().method_18(null);
			this.vmethod_16().Location = new Point(166, 237);
			this.vmethod_16().method_2(32767);
			this.vmethod_16().method_7(false);
			this.vmethod_16().Name = "TB_Mins";
			this.vmethod_16().method_3(false);
			this.vmethod_16().method_9(0);
			this.vmethod_16().Size = new Size(39, 24);
			this.vmethod_16().TabIndex = 18;
			this.vmethod_16().Text = "0";
			this.vmethod_16().method_1(HorizontalAlignment.Left);
			this.vmethod_16().method_5(false);
			this.vmethod_16().method_10("");
			this.vmethod_18().BackColor = Color.Transparent;
			this.vmethod_18().DialogResult = DialogResult.None;
			this.vmethod_18().Font = new Font("Segoe UI", 10f);
			this.vmethod_18().ForeColor = SystemColors.Control;
			this.vmethod_18().Location = new Point(12, 345);
			this.vmethod_18().Name = "Button1";
			this.vmethod_18().method_1(0);
			this.vmethod_18().Size = new Size(75, 23);
			this.vmethod_18().TabIndex = 19;
			this.vmethod_18().Text = "OK";
			this.vmethod_20().BackColor = Color.Transparent;
			this.vmethod_20().DialogResult = DialogResult.None;
			this.vmethod_20().Font = new Font("Segoe UI", 10f);
			this.vmethod_20().ForeColor = SystemColors.Control;
			this.vmethod_20().Location = new Point(242, 345);
			this.vmethod_20().Name = "Button2";
			this.vmethod_20().method_1(0);
			this.vmethod_20().Size = new Size(75, 23);
			this.vmethod_20().TabIndex = 20;
			this.vmethod_20().Text = "Cancel";
			this.vmethod_22().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_22().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_22().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_22().Location = new Point(12, 193);
			this.vmethod_22().Name = "DTP_StartTime";
			this.vmethod_22().Size = new Size(305, 23);
			this.vmethod_22().TabIndex = 21;
			this.vmethod_24().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_24().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_24().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_24().Location = new Point(12, 22);
			this.vmethod_24().Name = "DTP_CurrentDate";
			this.vmethod_24().Size = new Size(305, 23);
			this.vmethod_24().TabIndex = 22;
			this.vmethod_26().method_2(true);
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().Location = new Point(12, 6);
			this.vmethod_26().Name = "Label6";
			this.vmethod_26().Size = new Size(123, 15);
			this.vmethod_26().TabIndex = 23;
			this.vmethod_26().Text = "Scenario current time:";
			this.vmethod_28().BackColor = Color.FromArgb(31, 31, 31);
			this.vmethod_28().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_28().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_28().Location = new Point(12, 48);
			this.vmethod_28().Name = "DTP_CurrentTime";
			this.vmethod_28().Size = new Size(305, 23);
			this.vmethod_28().TabIndex = 24;
			this.vmethod_30().method_2(true);
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Location = new Point(9, 290);
			this.vmethod_30().Name = "Label7";
			this.vmethod_30().Size = new Size(70, 15);
			this.vmethod_30().TabIndex = 25;
			this.vmethod_30().Text = "Complexity:";
			this.vmethod_32().BackColor = Color.Transparent;
			this.vmethod_32().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_32().Location = new Point(75, 284);
			this.vmethod_32().method_1(5);
			this.vmethod_32().method_3(1);
			this.vmethod_32().Name = "NUD_Complexity";
			this.vmethod_32().Size = new Size(47, 26);
			this.vmethod_32().TabIndex = 26;
			this.vmethod_32().Value = 1;
			this.vmethod_34().method_2(true);
			this.vmethod_34().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_34().Location = new Point(9, 316);
			this.vmethod_34().Name = "Label8";
			this.vmethod_34().Size = new Size(58, 15);
			this.vmethod_34().TabIndex = 27;
			this.vmethod_34().Text = "Difficulty:";
			this.vmethod_36().method_2(true);
			this.vmethod_36().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_36().Location = new Point(143, 295);
			this.vmethod_36().Name = "Label9";
			this.vmethod_36().Size = new Size(98, 15);
			this.vmethod_36().TabIndex = 29;
			this.vmethod_36().Text = "Location/Setting:";
			this.vmethod_38().method_14(null);
			this.vmethod_38().method_15(AutoCompleteMode.None);
			this.vmethod_38().method_13(AutoCompleteSource.None);
			this.vmethod_38().BackColor = Color.Transparent;
			this.vmethod_38().method_17(new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161));
			this.vmethod_38().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_38().method_12(null);
			this.vmethod_38().method_18(null);
			this.vmethod_38().Location = new Point(146, 311);
			this.vmethod_38().method_2(32767);
			this.vmethod_38().method_7(false);
			this.vmethod_38().Name = "TextBox1";
			this.vmethod_38().method_3(false);
			this.vmethod_38().method_9(0);
			this.vmethod_38().Size = new Size(171, 24);
			this.vmethod_38().TabIndex = 30;
			this.vmethod_38().method_1(HorizontalAlignment.Left);
			this.vmethod_38().method_5(false);
			this.vmethod_38().method_10("");
			this.vmethod_40().BackColor = Color.Transparent;
			this.vmethod_40().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_40().Location = new Point(75, 311);
			this.vmethod_40().method_1(5);
			this.vmethod_40().method_3(1);
			this.vmethod_40().Name = "NUD_Difficulty";
			this.vmethod_40().Size = new Size(47, 26);
			this.vmethod_40().TabIndex = 31;
			this.vmethod_40().Value = 1;
			this.vmethod_42().Location = new Point(12, 75);
			this.vmethod_42().Name = "CB_DaylightSavingTime";
			this.vmethod_42().Size = new Size(300, 17);
			this.vmethod_42().TabIndex = 32;
			this.vmethod_42().Text = "Use Daylight Saving Time (DST, or Summer Time)";
			this.vmethod_44().method_2(true);
			this.vmethod_44().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_44().Location = new Point(11, 97);
			this.vmethod_44().Name = "Label10";
			this.vmethod_44().Size = new Size(128, 15);
			this.vmethod_44().TabIndex = 34;
			this.vmethod_44().Text = "DST Start (Day.Month):";
			this.vmethod_46().method_2(true);
			this.vmethod_46().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_46().Location = new Point(11, 120);
			this.vmethod_46().Name = "Label11";
			this.vmethod_46().Size = new Size(124, 15);
			this.vmethod_46().TabIndex = 35;
			this.vmethod_46().Text = "DST End (Day.Month):";
			this.vmethod_48().BackColor = Color.Black;
			this.vmethod_48().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_48().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_48().Location = new Point(138, 94);
			this.vmethod_48().Mask = "00.00";
			this.vmethod_48().Name = "TB_DaylightSavingTime_Start";
			this.vmethod_48().Size = new Size(47, 23);
			this.vmethod_48().TabIndex = 36;
			this.vmethod_50().BackColor = Color.Black;
			this.vmethod_50().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_50().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_50().Location = new Point(138, 117);
			this.vmethod_50().Mask = "00.00";
			this.vmethod_50().Name = "TB_DaylightSavingTime_End";
			this.vmethod_50().Size = new Size(47, 23);
			this.vmethod_50().TabIndex = 36;
			this.vmethod_52().BackColor = Color.Transparent;
			this.vmethod_52().DialogResult = DialogResult.None;
			this.vmethod_52().Font = new Font("Segoe UI", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_52().ForeColor = SystemColors.Control;
			this.vmethod_52().Location = new Point(166, 143);
			this.vmethod_52().Name = "Button_CopyFromCurrent";
			this.vmethod_52().method_1(0);
			this.vmethod_52().Size = new Size(151, 21);
			this.vmethod_52().TabIndex = 37;
			this.vmethod_52().Text = "Copy from current date + time";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(329, 378);
			base.Controls.Add(this.vmethod_52());
			base.Controls.Add(this.vmethod_50());
			base.Controls.Add(this.vmethod_48());
			base.Controls.Add(this.vmethod_46());
			base.Controls.Add(this.vmethod_44());
			base.Controls.Add(this.vmethod_42());
			base.Controls.Add(this.vmethod_40());
			base.Controls.Add(this.vmethod_38());
			base.Controls.Add(this.vmethod_36());
			base.Controls.Add(this.vmethod_34());
			base.Controls.Add(this.vmethod_32());
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.method_0(true);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "TimesAndDuration";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Time - Duration - General Info";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600857B RID: 34171 RVA: 0x00050AC4 File Offset: 0x0004ECC4
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x0600857C RID: 34172 RVA: 0x00050ACC File Offset: 0x0004ECCC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_11)
		{
			this.class116_0 = class116_11;
		}

		// Token: 0x0600857D RID: 34173 RVA: 0x00050AD5 File Offset: 0x0004ECD5
		[CompilerGenerated]
		internal Control8 vmethod_2()
		{
			return this.control8_0;
		}

		// Token: 0x0600857E RID: 34174 RVA: 0x00050ADD File Offset: 0x0004ECDD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control8 control8_4)
		{
			this.control8_0 = control8_4;
		}

		// Token: 0x0600857F RID: 34175 RVA: 0x00050AE6 File Offset: 0x0004ECE6
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_1;
		}

		// Token: 0x06008580 RID: 34176 RVA: 0x00050AEE File Offset: 0x0004ECEE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_11)
		{
			this.class116_1 = class116_11;
		}

		// Token: 0x06008581 RID: 34177 RVA: 0x00050AF7 File Offset: 0x0004ECF7
		[CompilerGenerated]
		internal Control8 vmethod_6()
		{
			return this.control8_1;
		}

		// Token: 0x06008582 RID: 34178 RVA: 0x00050AFF File Offset: 0x0004ECFF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control8 control8_4)
		{
			this.control8_1 = control8_4;
		}

		// Token: 0x06008583 RID: 34179 RVA: 0x00050B08 File Offset: 0x0004ED08
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_2;
		}

		// Token: 0x06008584 RID: 34180 RVA: 0x00050B10 File Offset: 0x0004ED10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_11)
		{
			this.class116_2 = class116_11;
		}

		// Token: 0x06008585 RID: 34181 RVA: 0x00050B19 File Offset: 0x0004ED19
		[CompilerGenerated]
		internal Class118 vmethod_10()
		{
			return this.class118_0;
		}

		// Token: 0x06008586 RID: 34182 RVA: 0x00050B21 File Offset: 0x0004ED21
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class118 class118_4)
		{
			this.class118_0 = class118_4;
		}

		// Token: 0x06008587 RID: 34183 RVA: 0x00050B2A File Offset: 0x0004ED2A
		[CompilerGenerated]
		internal Class116 vmethod_12()
		{
			return this.class116_3;
		}

		// Token: 0x06008588 RID: 34184 RVA: 0x00050B32 File Offset: 0x0004ED32
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class116 class116_11)
		{
			this.class116_3 = class116_11;
		}

		// Token: 0x06008589 RID: 34185 RVA: 0x00050B3B File Offset: 0x0004ED3B
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_4;
		}

		// Token: 0x0600858A RID: 34186 RVA: 0x00050B43 File Offset: 0x0004ED43
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_11)
		{
			this.class116_4 = class116_11;
		}

		// Token: 0x0600858B RID: 34187 RVA: 0x00050B4C File Offset: 0x0004ED4C
		[CompilerGenerated]
		internal Control8 vmethod_16()
		{
			return this.control8_2;
		}

		// Token: 0x0600858C RID: 34188 RVA: 0x00050B54 File Offset: 0x0004ED54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Control8 control8_4)
		{
			this.control8_2 = control8_4;
		}

		// Token: 0x0600858D RID: 34189 RVA: 0x00050B5D File Offset: 0x0004ED5D
		[CompilerGenerated]
		internal Control9 vmethod_18()
		{
			return this.control9_0;
		}

		// Token: 0x0600858E RID: 34190 RVA: 0x0047BC08 File Offset: 0x00479E08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_3);
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

		// Token: 0x0600858F RID: 34191 RVA: 0x00050B65 File Offset: 0x0004ED65
		[CompilerGenerated]
		internal Control9 vmethod_20()
		{
			return this.control9_1;
		}

		// Token: 0x06008590 RID: 34192 RVA: 0x0047BC4C File Offset: 0x00479E4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_4);
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

		// Token: 0x06008591 RID: 34193 RVA: 0x00050B6D File Offset: 0x0004ED6D
		[CompilerGenerated]
		internal Class118 vmethod_22()
		{
			return this.class118_1;
		}

		// Token: 0x06008592 RID: 34194 RVA: 0x00050B75 File Offset: 0x0004ED75
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class118 class118_4)
		{
			this.class118_1 = class118_4;
		}

		// Token: 0x06008593 RID: 34195 RVA: 0x00050B7E File Offset: 0x0004ED7E
		[CompilerGenerated]
		internal Class118 vmethod_24()
		{
			return this.class118_2;
		}

		// Token: 0x06008594 RID: 34196 RVA: 0x00050B86 File Offset: 0x0004ED86
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class118 class118_4)
		{
			this.class118_2 = class118_4;
		}

		// Token: 0x06008595 RID: 34197 RVA: 0x00050B8F File Offset: 0x0004ED8F
		[CompilerGenerated]
		internal Class116 vmethod_26()
		{
			return this.class116_5;
		}

		// Token: 0x06008596 RID: 34198 RVA: 0x00050B97 File Offset: 0x0004ED97
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class116 class116_11)
		{
			this.class116_5 = class116_11;
		}

		// Token: 0x06008597 RID: 34199 RVA: 0x00050BA0 File Offset: 0x0004EDA0
		[CompilerGenerated]
		internal Class118 vmethod_28()
		{
			return this.class118_3;
		}

		// Token: 0x06008598 RID: 34200 RVA: 0x00050BA8 File Offset: 0x0004EDA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Class118 class118_4)
		{
			this.class118_3 = class118_4;
		}

		// Token: 0x06008599 RID: 34201 RVA: 0x00050BB1 File Offset: 0x0004EDB1
		[CompilerGenerated]
		internal Class116 vmethod_30()
		{
			return this.class116_6;
		}

		// Token: 0x0600859A RID: 34202 RVA: 0x00050BB9 File Offset: 0x0004EDB9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class116 class116_11)
		{
			this.class116_6 = class116_11;
		}

		// Token: 0x0600859B RID: 34203 RVA: 0x00050BC2 File Offset: 0x0004EDC2
		[CompilerGenerated]
		internal Control10 vmethod_32()
		{
			return this.control10_0;
		}

		// Token: 0x0600859C RID: 34204 RVA: 0x00050BCA File Offset: 0x0004EDCA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Control10 control10_2)
		{
			this.control10_0 = control10_2;
		}

		// Token: 0x0600859D RID: 34205 RVA: 0x00050BD3 File Offset: 0x0004EDD3
		[CompilerGenerated]
		internal Class116 vmethod_34()
		{
			return this.class116_7;
		}

		// Token: 0x0600859E RID: 34206 RVA: 0x00050BDB File Offset: 0x0004EDDB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Class116 class116_11)
		{
			this.class116_7 = class116_11;
		}

		// Token: 0x0600859F RID: 34207 RVA: 0x00050BE4 File Offset: 0x0004EDE4
		[CompilerGenerated]
		internal Class116 vmethod_36()
		{
			return this.class116_8;
		}

		// Token: 0x060085A0 RID: 34208 RVA: 0x00050BEC File Offset: 0x0004EDEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Class116 class116_11)
		{
			this.class116_8 = class116_11;
		}

		// Token: 0x060085A1 RID: 34209 RVA: 0x00050BF5 File Offset: 0x0004EDF5
		[CompilerGenerated]
		internal Control8 vmethod_38()
		{
			return this.control8_3;
		}

		// Token: 0x060085A2 RID: 34210 RVA: 0x00050BFD File Offset: 0x0004EDFD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Control8 control8_4)
		{
			this.control8_3 = control8_4;
		}

		// Token: 0x060085A3 RID: 34211 RVA: 0x00050C06 File Offset: 0x0004EE06
		[CompilerGenerated]
		internal Control10 vmethod_40()
		{
			return this.control10_1;
		}

		// Token: 0x060085A4 RID: 34212 RVA: 0x00050C0E File Offset: 0x0004EE0E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Control10 control10_2)
		{
			this.control10_1 = control10_2;
		}

		// Token: 0x060085A5 RID: 34213 RVA: 0x00050C17 File Offset: 0x0004EE17
		[CompilerGenerated]
		internal Class112 vmethod_42()
		{
			return this.class112_0;
		}

		// Token: 0x060085A6 RID: 34214 RVA: 0x0047BC90 File Offset: 0x00479E90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(Class112 class112_1)
		{
			EventHandler value = new EventHandler(this.method_6);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_0 = class112_1;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060085A7 RID: 34215 RVA: 0x00050C1F File Offset: 0x0004EE1F
		[CompilerGenerated]
		internal Class116 vmethod_44()
		{
			return this.class116_9;
		}

		// Token: 0x060085A8 RID: 34216 RVA: 0x00050C27 File Offset: 0x0004EE27
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Class116 class116_11)
		{
			this.class116_9 = class116_11;
		}

		// Token: 0x060085A9 RID: 34217 RVA: 0x00050C30 File Offset: 0x0004EE30
		[CompilerGenerated]
		internal Class116 vmethod_46()
		{
			return this.class116_10;
		}

		// Token: 0x060085AA RID: 34218 RVA: 0x00050C38 File Offset: 0x0004EE38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(Class116 class116_11)
		{
			this.class116_10 = class116_11;
		}

		// Token: 0x060085AB RID: 34219 RVA: 0x00050C41 File Offset: 0x0004EE41
		[CompilerGenerated]
		internal MaskedTextBox vmethod_48()
		{
			return this.maskedTextBox_0;
		}

		// Token: 0x060085AC RID: 34220 RVA: 0x00050C49 File Offset: 0x0004EE49
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(MaskedTextBox maskedTextBox_2)
		{
			this.maskedTextBox_0 = maskedTextBox_2;
		}

		// Token: 0x060085AD RID: 34221 RVA: 0x00050C52 File Offset: 0x0004EE52
		[CompilerGenerated]
		internal MaskedTextBox vmethod_50()
		{
			return this.maskedTextBox_1;
		}

		// Token: 0x060085AE RID: 34222 RVA: 0x00050C5A File Offset: 0x0004EE5A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(MaskedTextBox maskedTextBox_2)
		{
			this.maskedTextBox_1 = maskedTextBox_2;
		}

		// Token: 0x060085AF RID: 34223 RVA: 0x00050C63 File Offset: 0x0004EE63
		[CompilerGenerated]
		internal Control9 vmethod_52()
		{
			return this.control9_2;
		}

		// Token: 0x060085B0 RID: 34224 RVA: 0x0047BCD4 File Offset: 0x00479ED4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_7);
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

		// Token: 0x060085B1 RID: 34225 RVA: 0x0047BD18 File Offset: 0x00479F18
		private void TimesAndDuration_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_24().Mask = "0000-00-00";
			this.vmethod_28().Mask = "00:00:00";
			DateTime dateTime = Client.smethod_46().method_31();
			string text;
			GameGeneral.smethod_47(ref dateTime, ref text);
			string text2;
			GameGeneral.smethod_48(ref dateTime, ref text2, false);
			this.vmethod_24().Text = text2;
			this.vmethod_28().Text = text;
			if (!Information.IsNothing(Client.smethod_46().method_35()) && Operators.CompareString(Client.smethod_46().method_35(), "", false) != 0)
			{
				this.vmethod_48().Text = Client.smethod_46().method_35();
			}
			else
			{
				this.vmethod_48().Text = "00.00";
			}
			if (!Information.IsNothing(Client.smethod_46().method_37()) && Operators.CompareString(Client.smethod_46().method_37(), "", false) != 0)
			{
				this.vmethod_50().Text = Client.smethod_46().method_37();
			}
			else
			{
				this.vmethod_50().Text = "00.00";
			}
			this.vmethod_42().Checked = Client.smethod_46().method_33();
			this.vmethod_48().Enabled = this.vmethod_42().Checked;
			this.vmethod_50().Enabled = this.vmethod_42().Checked;
			this.vmethod_10().Mask = "0000-00-00";
			this.vmethod_22().Mask = "00:00:00";
			DateTime dateTime2 = Client.smethod_46().method_27();
			string text3;
			GameGeneral.smethod_47(ref dateTime2, ref text3);
			string text4;
			GameGeneral.smethod_48(ref dateTime2, ref text4, false);
			this.vmethod_10().Text = text4;
			this.vmethod_22().Text = text3;
			this.vmethod_6().Text = Conversions.ToString(Client.smethod_46().method_29().Days);
			this.vmethod_2().Text = Conversions.ToString(Client.smethod_46().method_29().Hours);
			this.vmethod_16().Text = Conversions.ToString(Client.smethod_46().method_29().Minutes);
			this.vmethod_32().Value = Convert.ToInt32(new decimal((int)((Client.smethod_46().Meta_Complexity == 0) ? 1 : Client.smethod_46().Meta_Complexity)));
			this.vmethod_40().Value = Convert.ToInt32(new decimal((int)((Client.smethod_46().Meta_Difficulty == 0) ? 1 : Client.smethod_46().Meta_Difficulty)));
			this.vmethod_38().Text = Client.smethod_46().Meta_ScenSetting;
		}

		// Token: 0x060085B2 RID: 34226 RVA: 0x0047BFA0 File Offset: 0x0047A1A0
		private void method_3(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_6().Text) & Versioned.IsNumeric(this.vmethod_2().Text) & Versioned.IsNumeric(this.vmethod_16().Text))
			{
				List<string> list;
				List<string> list2;
				try
				{
					Client.smethod_46().method_34(this.vmethod_42().Checked);
					if (Client.smethod_46().method_33() && (!this.method_5(this.vmethod_48().Text.Replace(",", ".")) || !this.method_5(this.vmethod_50().Text.Replace(",", "."))))
					{
						DarkMessageBox.smethod_2("Please enter a valid Daylight Saving Time start and end date!", "Illegal values entered!", Enum11.const_0);
						return;
					}
					list = Enumerable.ToList<string>(this.vmethod_28().Text.Split(Conversions.ToCharArrayRankOne(":")));
					if (!(Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1]) & Versioned.IsNumeric(list[2])))
					{
						return;
					}
					list2 = Enumerable.ToList<string>(this.vmethod_24().Text.Split(Conversions.ToCharArrayRankOne("-")));
					if (!(Versioned.IsNumeric(list2[0]) & Versioned.IsNumeric(list2[1]) & Versioned.IsNumeric(list2[2])))
					{
						return;
					}
					Client.smethod_46().method_32(true, new DateTime(Conversions.ToInteger(list2[0]), Conversions.ToInteger(list2[1]), Conversions.ToInteger(list2[2]), Conversions.ToInteger(list[0]), Conversions.ToInteger(list[1]), Conversions.ToInteger(list[2])));
				}
				catch (Exception ex)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					DarkMessageBox.smethod_2("Unable to set current scenario date & time: " + ex.Message, "Error in setting scenario current time", Enum11.const_0);
					return;
				}
				try
				{
					Client.smethod_46().method_36(this.vmethod_48().Text.Replace(",", "."));
					Client.smethod_46().method_38(this.vmethod_50().Text.Replace(",", "."));
					List<string> list3 = Enumerable.ToList<string>(this.vmethod_22().Text.Split(Conversions.ToCharArrayRankOne(":")));
					if (!(Versioned.IsNumeric(list3[0]) & Versioned.IsNumeric(list3[1]) & Versioned.IsNumeric(list3[2])))
					{
						return;
					}
					List<string> list4 = Enumerable.ToList<string>(this.vmethod_10().Text.Split(Conversions.ToCharArrayRankOne("-")));
					if (!(Versioned.IsNumeric(list4[0]) & Versioned.IsNumeric(list4[1]) & Versioned.IsNumeric(list4[2])))
					{
						return;
					}
					Client.smethod_46().method_28(new DateTime(Conversions.ToInteger(list2[0]), Conversions.ToInteger(list2[1]), Conversions.ToInteger(list2[2]), Conversions.ToInteger(list[0]), Conversions.ToInteger(list[1]), Conversions.ToInteger(list[2])));
				}
				catch (Exception ex2)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					DarkMessageBox.smethod_2("Unable to set scenario start date & time: " + ex2.Message, "Error in setting scenario start time", Enum11.const_0);
					return;
				}
				try
				{
					Client.smethod_46().method_30(new TimeSpan(Conversions.ToInteger(this.vmethod_6().Text) * 24, Conversions.ToInteger(this.vmethod_2().Text) * 60, Conversions.ToInteger(this.vmethod_16().Text) * 60));
				}
				catch (Exception ex3)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					DarkMessageBox.smethod_2("Unable to set scenario duration: " + ex3.Message, "Error in setting scenario duration", Enum11.const_0);
					return;
				}
				Client.smethod_46().Meta_Complexity = (short)this.vmethod_32().Value;
				Client.smethod_46().Meta_Difficulty = (short)this.vmethod_40().Value;
				Client.smethod_46().Meta_ScenSetting = this.vmethod_38().Text;
				Client.smethod_46().Cache_TimeOfDay = new Weather.TTimeOfDayType?[360][];
				Class2413.smethod_2().method_41().method_234();
				base.Close();
				return;
			}
			DarkMessageBox.smethod_2("Please check that the duration day/hour/minute values are all numeric.", "Non-numeric values entered!", Enum11.const_0);
		}

		// Token: 0x060085B3 RID: 34227 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_4(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060085B4 RID: 34228 RVA: 0x0047C454 File Offset: 0x0047A654
		private bool method_5(string string_0)
		{
			List<string> list = Enumerable.ToList<string>(string_0.Split(Conversions.ToCharArrayRankOne(".")));
			return (Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1])) && !(Conversions.ToInteger(list[0]) <= 0 | Conversions.ToInteger(list[0]) > 31) && !(Conversions.ToInteger(list[1]) <= 0 | Conversions.ToInteger(list[1]) > 12);
		}

		// Token: 0x060085B5 RID: 34229 RVA: 0x003B6260 File Offset: 0x003B4460
		private void TimesAndDuration_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060085B6 RID: 34230 RVA: 0x00050C6B File Offset: 0x0004EE6B
		private void method_6(object sender, EventArgs e)
		{
			this.vmethod_48().Enabled = this.vmethod_42().Checked;
			this.vmethod_50().Enabled = this.vmethod_42().Checked;
		}

		// Token: 0x060085B7 RID: 34231 RVA: 0x00044820 File Offset: 0x00042A20
		private void TimesAndDuration_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x060085B8 RID: 34232 RVA: 0x00050C99 File Offset: 0x0004EE99
		private void method_7(object sender, EventArgs e)
		{
			this.vmethod_10().Text = this.vmethod_24().Text;
			this.vmethod_22().Text = this.vmethod_28().Text;
		}

		// Token: 0x040048F0 RID: 18672
		[CompilerGenerated]
		[AccessedThroughProperty("Label4")]
		private Class116 class116_0;

		// Token: 0x040048F1 RID: 18673
		[AccessedThroughProperty("TB_Hours")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x040048F2 RID: 18674
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_1;

		// Token: 0x040048F3 RID: 18675
		[AccessedThroughProperty("TB_Days")]
		[CompilerGenerated]
		private Control8 control8_1;

		// Token: 0x040048F4 RID: 18676
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_2;

		// Token: 0x040048F5 RID: 18677
		[AccessedThroughProperty("DTP_StartDate")]
		[CompilerGenerated]
		private Class118 class118_0;

		// Token: 0x040048F6 RID: 18678
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x040048F7 RID: 18679
		[AccessedThroughProperty("Label5")]
		[CompilerGenerated]
		private Class116 class116_4;

		// Token: 0x040048F8 RID: 18680
		[AccessedThroughProperty("TB_Mins")]
		[CompilerGenerated]
		private Control8 control8_2;

		// Token: 0x040048F9 RID: 18681
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_0;

		// Token: 0x040048FA RID: 18682
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_1;

		// Token: 0x040048FB RID: 18683
		[CompilerGenerated]
		[AccessedThroughProperty("DTP_StartTime")]
		private Class118 class118_1;

		// Token: 0x040048FC RID: 18684
		[CompilerGenerated]
		[AccessedThroughProperty("DTP_CurrentDate")]
		private Class118 class118_2;

		// Token: 0x040048FD RID: 18685
		[AccessedThroughProperty("Label6")]
		[CompilerGenerated]
		private Class116 class116_5;

		// Token: 0x040048FE RID: 18686
		[CompilerGenerated]
		[AccessedThroughProperty("DTP_CurrentTime")]
		private Class118 class118_3;

		// Token: 0x040048FF RID: 18687
		[CompilerGenerated]
		[AccessedThroughProperty("Label7")]
		private Class116 class116_6;

		// Token: 0x04004900 RID: 18688
		[AccessedThroughProperty("NUD_Complexity")]
		[CompilerGenerated]
		private Control10 control10_0;

		// Token: 0x04004901 RID: 18689
		[AccessedThroughProperty("Label8")]
		[CompilerGenerated]
		private Class116 class116_7;

		// Token: 0x04004902 RID: 18690
		[AccessedThroughProperty("Label9")]
		[CompilerGenerated]
		private Class116 class116_8;

		// Token: 0x04004903 RID: 18691
		[AccessedThroughProperty("TextBox1")]
		[CompilerGenerated]
		private Control8 control8_3;

		// Token: 0x04004904 RID: 18692
		[AccessedThroughProperty("NUD_Difficulty")]
		[CompilerGenerated]
		private Control10 control10_1;

		// Token: 0x04004905 RID: 18693
		[AccessedThroughProperty("CB_DaylightSavingTime")]
		[CompilerGenerated]
		private Class112 class112_0;

		// Token: 0x04004906 RID: 18694
		[CompilerGenerated]
		[AccessedThroughProperty("Label10")]
		private Class116 class116_9;

		// Token: 0x04004907 RID: 18695
		[CompilerGenerated]
		[AccessedThroughProperty("Label11")]
		private Class116 class116_10;

		// Token: 0x04004908 RID: 18696
		[CompilerGenerated]
		[AccessedThroughProperty("TB_DaylightSavingTime_Start")]
		private MaskedTextBox maskedTextBox_0;

		// Token: 0x04004909 RID: 18697
		[CompilerGenerated]
		[AccessedThroughProperty("TB_DaylightSavingTime_End")]
		private MaskedTextBox maskedTextBox_1;

		// Token: 0x0400490A RID: 18698
		[CompilerGenerated]
		[AccessedThroughProperty("Button_CopyFromCurrent")]
		private Control9 control9_2;
	}
}
