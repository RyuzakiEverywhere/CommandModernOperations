using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns5;

namespace ns4
{
	// Token: 0x02000E7A RID: 3706
	[DesignerGenerated]
	internal sealed partial class Hotkeys : DarkSecondaryFormBase
	{
		// Token: 0x060071D0 RID: 29136 RVA: 0x003D2AF8 File Offset: 0x003D0CF8
		public Hotkeys()
		{
			base.KeyDown += this.Hotkeys_KeyDown;
			base.FormClosing += this.Hotkeys_FormClosing;
			base.Load += this.Hotkeys_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x060071D2 RID: 29138 RVA: 0x003D2B88 File Offset: 0x003D0D88
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Hotkeys));
			this.vmethod_1(new Class116());
			this.vmethod_3(new Class116());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Class116());
			this.vmethod_9(new Class116());
			this.vmethod_11(new Class116());
			this.vmethod_13(new Class116());
			this.vmethod_15(new Class123());
			this.vmethod_17(new Class123());
			this.vmethod_19(new Class123());
			this.vmethod_21(new Class123());
			this.vmethod_23(new Class123());
			this.vmethod_25(new Class123());
			this.vmethod_27(new Class123());
			this.vmethod_29(new Class116());
			this.vmethod_31(new Class123());
			this.vmethod_35(new Class116());
			this.vmethod_33(new Class123());
			base.SuspendLayout();
			this.vmethod_0().method_2(true);
			this.vmethod_0().Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(15, 0);
			this.vmethod_0().Name = "Label3";
			this.vmethod_0().Size = new Size(45, 20);
			this.vmethod_0().TabIndex = 9;
			this.vmethod_0().Text = "Basic";
			this.vmethod_2().method_2(true);
			this.vmethod_2().Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(393, 620);
			this.vmethod_2().Name = "Label5";
			this.vmethod_2().Size = new Size(70, 20);
			this.vmethod_2().TabIndex = 12;
			this.vmethod_2().Text = "Contacts";
			this.vmethod_4().method_2(true);
			this.vmethod_4().Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(393, 302);
			this.vmethod_4().Name = "Label4";
			this.vmethod_4().Size = new Size(82, 20);
			this.vmethod_4().TabIndex = 11;
			this.vmethod_4().Text = "Own Units";
			this.vmethod_6().method_2(true);
			this.vmethod_6().Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(15, 551);
			this.vmethod_6().Name = "Label6";
			this.vmethod_6().Size = new Size(114, 20);
			this.vmethod_6().TabIndex = 10;
			this.vmethod_6().Text = "Scenario Editor";
			this.vmethod_8().method_2(true);
			this.vmethod_8().Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(15, 112);
			this.vmethod_8().Name = "Label2";
			this.vmethod_8().Size = new Size(96, 20);
			this.vmethod_8().TabIndex = 15;
			this.vmethod_8().Text = "Tactical Map";
			this.vmethod_10().method_2(true);
			this.vmethod_10().Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Location = new Point(832, 4);
			this.vmethod_10().Name = "Label7";
			this.vmethod_10().Size = new Size(171, 20);
			this.vmethod_10().TabIndex = 14;
			this.vmethod_10().Text = "Expert's Tricks and Tips";
			this.vmethod_12().method_2(true);
			this.vmethod_12().Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Location = new Point(393, 2);
			this.vmethod_12().Name = "Label1";
			this.vmethod_12().Size = new Size(107, 20);
			this.vmethod_12().TabIndex = 13;
			this.vmethod_12().Text = "Function Keys";
			this.vmethod_14().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_14().BorderStyle = BorderStyle.None;
			this.vmethod_14().Font = new Font("Segoe UI", 10f);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(835, 25);
			this.vmethod_14().Name = "RichTextBox7";
			this.vmethod_14().Size = new Size(414, 246);
			this.vmethod_14().TabIndex = 4;
			this.vmethod_14().Text = componentResourceManager.GetString("RichTextBox7.Text");
			this.vmethod_16().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_16().BorderStyle = BorderStyle.None;
			this.vmethod_16().Font = new Font("Segoe UI", 10f);
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Location = new Point(18, 21);
			this.vmethod_16().Name = "RichTextBox3";
			this.vmethod_16().Size = new Size(380, 106);
			this.vmethod_16().TabIndex = 5;
			this.vmethod_16().Text = "Spacebar , Ctrl + Enter\tStart / Resume / Pause Game\n+ (plus)\t\t\tIncrease Time Compression\n- (minus)\t\tDecrease Time Compression\nEnter\t\t\tReal-time mode (1:1 sec)\nCtrl + S\t\t\tSave Scenario\n";
			this.vmethod_18().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_18().BorderStyle = BorderStyle.None;
			this.vmethod_18().Font = new Font("Segoe UI", 10f);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(396, 641);
			this.vmethod_18().Name = "RichTextBox5";
			this.vmethod_18().Size = new Size(367, 105);
			this.vmethod_18().TabIndex = 2;
			this.vmethod_18().Text = "P, PgDn , Num 3\t            Drop Contact(s)\nH\t\t\tMark Hostile\nCtrl + H\t\t\tMark Unfriendly\nN\t\t\tMark Neutral\nF\t\t\tMark Friendly\nR\t\t\tRename";
			this.vmethod_20().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_20().BorderStyle = BorderStyle.None;
			this.vmethod_20().Font = new Font("Segoe UI", 10f);
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Location = new Point(18, 570);
			this.vmethod_20().Name = "RichTextBox6";
			this.vmethod_20().Size = new Size(380, 187);
			this.vmethod_20().TabIndex = 3;
			this.vmethod_20().Text = componentResourceManager.GetString("RichTextBox6.Text");
			this.vmethod_22().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_22().BorderStyle = BorderStyle.None;
			this.vmethod_22().Font = new Font("Segoe UI", 10f);
			this.vmethod_22().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_22().Location = new Point(396, 323);
			this.vmethod_22().Name = "RichTextBox4";
			this.vmethod_22().Size = new Size(561, 301);
			this.vmethod_22().TabIndex = 8;
			this.vmethod_22().Text = componentResourceManager.GetString("RichTextBox4.Text");
			this.vmethod_24().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_24().BorderStyle = BorderStyle.None;
			this.vmethod_24().Font = new Font("Segoe UI", 10f);
			this.vmethod_24().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_24().Location = new Point(18, 133);
			this.vmethod_24().Name = "RichTextBox2";
			this.vmethod_24().Size = new Size(380, 410);
			this.vmethod_24().TabIndex = 7;
			this.vmethod_24().Text = componentResourceManager.GetString("RichTextBox2.Text");
			this.vmethod_26().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_26().BorderStyle = BorderStyle.None;
			this.vmethod_26().Font = new Font("Segoe UI", 10f);
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().Location = new Point(396, 23);
			this.vmethod_26().Name = "RichTextBox1";
			this.vmethod_26().Size = new Size(433, 277);
			this.vmethod_26().TabIndex = 6;
			this.vmethod_26().Text = componentResourceManager.GetString("RichTextBox1.Text");
			this.vmethod_28().method_2(true);
			this.vmethod_28().Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_28().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_28().Location = new Point(832, 148);
			this.vmethod_28().Name = "Label8";
			this.vmethod_28().Size = new Size(41, 20);
			this.vmethod_28().TabIndex = 17;
			this.vmethod_28().Text = "Misc";
			this.vmethod_30().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_30().BorderStyle = BorderStyle.None;
			this.vmethod_30().Font = new Font("Segoe UI", 10f);
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Location = new Point(835, 169);
			this.vmethod_30().Name = "RichTextBox8";
			this.vmethod_30().Size = new Size(391, 187);
			this.vmethod_30().TabIndex = 16;
			this.vmethod_30().Text = "Ctrl + Shift + C\tLua Script Console\nCtrl + C\t\tCopy Lua values of selected units to clipboard\nCtrl + Z\t\tCopy Lua values of highlighted RPs to clipboard";
			this.vmethod_34().method_2(true);
			this.vmethod_34().Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_34().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_34().Location = new Point(834, 239);
			this.vmethod_34().Margin = new Padding(2, 0, 2, 0);
			this.vmethod_34().Name = "Label_AMP_Header";
			this.vmethod_34().Size = new Size(193, 20);
			this.vmethod_34().TabIndex = 17;
			this.vmethod_34().Text = "Advanced Mission Planner";
			this.vmethod_32().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_32().BorderStyle = BorderStyle.None;
			this.vmethod_32().Font = new Font("Segoe UI", 10f);
			this.vmethod_32().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_32().Location = new Point(836, 254);
			this.vmethod_32().Margin = new Padding(2);
			this.vmethod_32().Name = "RichTextBoxL_AMP";
			this.vmethod_32().Size = new Size(261, 57);
			this.vmethod_32().TabIndex = 16;
			this.vmethod_32().Text = "Ctrl + Shift + F11\tAir Tasking Order (ATO)";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1258, 765);
			base.Controls.Add(this.vmethod_34());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_32());
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_26());
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Hotkeys";
			base.Padding = new Padding(9);
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "Hotkeys";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060071D3 RID: 29139 RVA: 0x0004758C File Offset: 0x0004578C
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x060071D4 RID: 29140 RVA: 0x00047594 File Offset: 0x00045794
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_9)
		{
			this.class116_0 = class116_9;
		}

		// Token: 0x060071D5 RID: 29141 RVA: 0x0004759D File Offset: 0x0004579D
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_1;
		}

		// Token: 0x060071D6 RID: 29142 RVA: 0x000475A5 File Offset: 0x000457A5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_9)
		{
			this.class116_1 = class116_9;
		}

		// Token: 0x060071D7 RID: 29143 RVA: 0x000475AE File Offset: 0x000457AE
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_2;
		}

		// Token: 0x060071D8 RID: 29144 RVA: 0x000475B6 File Offset: 0x000457B6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_9)
		{
			this.class116_2 = class116_9;
		}

		// Token: 0x060071D9 RID: 29145 RVA: 0x000475BF File Offset: 0x000457BF
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_3;
		}

		// Token: 0x060071DA RID: 29146 RVA: 0x000475C7 File Offset: 0x000457C7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_9)
		{
			this.class116_3 = class116_9;
		}

		// Token: 0x060071DB RID: 29147 RVA: 0x000475D0 File Offset: 0x000457D0
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_4;
		}

		// Token: 0x060071DC RID: 29148 RVA: 0x000475D8 File Offset: 0x000457D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_9)
		{
			this.class116_4 = class116_9;
		}

		// Token: 0x060071DD RID: 29149 RVA: 0x000475E1 File Offset: 0x000457E1
		[CompilerGenerated]
		internal Class116 vmethod_10()
		{
			return this.class116_5;
		}

		// Token: 0x060071DE RID: 29150 RVA: 0x000475E9 File Offset: 0x000457E9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class116 class116_9)
		{
			this.class116_5 = class116_9;
		}

		// Token: 0x060071DF RID: 29151 RVA: 0x000475F2 File Offset: 0x000457F2
		[CompilerGenerated]
		internal Class116 vmethod_12()
		{
			return this.class116_6;
		}

		// Token: 0x060071E0 RID: 29152 RVA: 0x000475FA File Offset: 0x000457FA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class116 class116_9)
		{
			this.class116_6 = class116_9;
		}

		// Token: 0x060071E1 RID: 29153 RVA: 0x00047603 File Offset: 0x00045803
		[CompilerGenerated]
		internal Class123 vmethod_14()
		{
			return this.class123_0;
		}

		// Token: 0x060071E2 RID: 29154 RVA: 0x0004760B File Offset: 0x0004580B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class123 class123_9)
		{
			this.class123_0 = class123_9;
		}

		// Token: 0x060071E3 RID: 29155 RVA: 0x00047614 File Offset: 0x00045814
		[CompilerGenerated]
		internal Class123 vmethod_16()
		{
			return this.class123_1;
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x0004761C File Offset: 0x0004581C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class123 class123_9)
		{
			this.class123_1 = class123_9;
		}

		// Token: 0x060071E5 RID: 29157 RVA: 0x00047625 File Offset: 0x00045825
		[CompilerGenerated]
		internal Class123 vmethod_18()
		{
			return this.class123_2;
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x0004762D File Offset: 0x0004582D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class123 class123_9)
		{
			this.class123_2 = class123_9;
		}

		// Token: 0x060071E7 RID: 29159 RVA: 0x00047636 File Offset: 0x00045836
		[CompilerGenerated]
		internal Class123 vmethod_20()
		{
			return this.class123_3;
		}

		// Token: 0x060071E8 RID: 29160 RVA: 0x0004763E File Offset: 0x0004583E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class123 class123_9)
		{
			this.class123_3 = class123_9;
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x00047647 File Offset: 0x00045847
		[CompilerGenerated]
		internal Class123 vmethod_22()
		{
			return this.class123_4;
		}

		// Token: 0x060071EA RID: 29162 RVA: 0x0004764F File Offset: 0x0004584F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class123 class123_9)
		{
			this.class123_4 = class123_9;
		}

		// Token: 0x060071EB RID: 29163 RVA: 0x00047658 File Offset: 0x00045858
		[CompilerGenerated]
		internal Class123 vmethod_24()
		{
			return this.class123_5;
		}

		// Token: 0x060071EC RID: 29164 RVA: 0x00047660 File Offset: 0x00045860
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class123 class123_9)
		{
			this.class123_5 = class123_9;
		}

		// Token: 0x060071ED RID: 29165 RVA: 0x00047669 File Offset: 0x00045869
		[CompilerGenerated]
		internal Class123 vmethod_26()
		{
			return this.class123_6;
		}

		// Token: 0x060071EE RID: 29166 RVA: 0x00047671 File Offset: 0x00045871
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class123 class123_9)
		{
			this.class123_6 = class123_9;
		}

		// Token: 0x060071EF RID: 29167 RVA: 0x0004767A File Offset: 0x0004587A
		[CompilerGenerated]
		internal Class116 vmethod_28()
		{
			return this.class116_7;
		}

		// Token: 0x060071F0 RID: 29168 RVA: 0x00047682 File Offset: 0x00045882
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Class116 class116_9)
		{
			this.class116_7 = class116_9;
		}

		// Token: 0x060071F1 RID: 29169 RVA: 0x0004768B File Offset: 0x0004588B
		[CompilerGenerated]
		internal Class123 vmethod_30()
		{
			return this.class123_7;
		}

		// Token: 0x060071F2 RID: 29170 RVA: 0x00047693 File Offset: 0x00045893
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class123 class123_9)
		{
			this.class123_7 = class123_9;
		}

		// Token: 0x060071F3 RID: 29171 RVA: 0x0004769C File Offset: 0x0004589C
		[CompilerGenerated]
		internal Class123 vmethod_32()
		{
			return this.class123_8;
		}

		// Token: 0x060071F4 RID: 29172 RVA: 0x000476A4 File Offset: 0x000458A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Class123 class123_9)
		{
			this.class123_8 = class123_9;
		}

		// Token: 0x060071F5 RID: 29173 RVA: 0x000476AD File Offset: 0x000458AD
		[CompilerGenerated]
		internal Class116 vmethod_34()
		{
			return this.class116_8;
		}

		// Token: 0x060071F6 RID: 29174 RVA: 0x000476B5 File Offset: 0x000458B5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Class116 class116_9)
		{
			this.class116_8 = class116_9;
		}

		// Token: 0x060071F7 RID: 29175 RVA: 0x000476BE File Offset: 0x000458BE
		private void Hotkeys_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x060071F8 RID: 29176 RVA: 0x00044820 File Offset: 0x00042A20
		private void Hotkeys_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x000476EF File Offset: 0x000458EF
		private void Hotkeys_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_32().Visible = false;
			this.vmethod_34().Visible = false;
		}

		// Token: 0x04004033 RID: 16435
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_0;

		// Token: 0x04004034 RID: 16436
		[CompilerGenerated]
		[AccessedThroughProperty("Label5")]
		private Class116 class116_1;

		// Token: 0x04004035 RID: 16437
		[CompilerGenerated]
		[AccessedThroughProperty("Label4")]
		private Class116 class116_2;

		// Token: 0x04004036 RID: 16438
		[CompilerGenerated]
		[AccessedThroughProperty("Label6")]
		private Class116 class116_3;

		// Token: 0x04004037 RID: 16439
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_4;

		// Token: 0x04004038 RID: 16440
		[CompilerGenerated]
		[AccessedThroughProperty("Label7")]
		private Class116 class116_5;

		// Token: 0x04004039 RID: 16441
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_6;

		// Token: 0x0400403A RID: 16442
		[CompilerGenerated]
		[AccessedThroughProperty("RichTextBox7")]
		private Class123 class123_0;

		// Token: 0x0400403B RID: 16443
		[CompilerGenerated]
		[AccessedThroughProperty("RichTextBox3")]
		private Class123 class123_1;

		// Token: 0x0400403C RID: 16444
		[CompilerGenerated]
		[AccessedThroughProperty("RichTextBox5")]
		private Class123 class123_2;

		// Token: 0x0400403D RID: 16445
		[CompilerGenerated]
		[AccessedThroughProperty("RichTextBox6")]
		private Class123 class123_3;

		// Token: 0x0400403E RID: 16446
		[CompilerGenerated]
		[AccessedThroughProperty("RichTextBox4")]
		private Class123 class123_4;

		// Token: 0x0400403F RID: 16447
		[AccessedThroughProperty("RichTextBox2")]
		[CompilerGenerated]
		private Class123 class123_5;

		// Token: 0x04004040 RID: 16448
		[AccessedThroughProperty("RichTextBox1")]
		[CompilerGenerated]
		private Class123 class123_6;

		// Token: 0x04004041 RID: 16449
		[AccessedThroughProperty("Label8")]
		[CompilerGenerated]
		private Class116 class116_7;

		// Token: 0x04004042 RID: 16450
		[CompilerGenerated]
		[AccessedThroughProperty("RichTextBox8")]
		private Class123 class123_7;

		// Token: 0x04004043 RID: 16451
		[AccessedThroughProperty("RichTextBoxL_AMP")]
		[CompilerGenerated]
		private Class123 class123_8;

		// Token: 0x04004044 RID: 16452
		[CompilerGenerated]
		[AccessedThroughProperty("Label_AMP_Header")]
		private Class116 class116_8;
	}
}
