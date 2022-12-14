using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns14;
using ns2;
using ns3;
using ns4;
using ns5;
using ns7;

namespace ns6
{
	// Token: 0x02000EFC RID: 3836
	[DesignerGenerated]
	internal sealed partial class StartGame : DarkSecondaryFormBase
	{
		// Token: 0x0600875E RID: 34654 RVA: 0x00489988 File Offset: 0x00487B88
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(StartGame));
			this.vmethod_1(new Class115());
			this.vmethod_21(new Control9());
			this.vmethod_19(new Control9());
			this.vmethod_17(new Control9());
			this.vmethod_13(new Control9());
			this.vmethod_7(new Control9());
			this.vmethod_3(new Class115());
			this.vmethod_9(new Control9());
			this.vmethod_11(new Control9());
			this.vmethod_15(new Control9());
			this.vmethod_5(new PictureBox());
			this.vmethod_0().SuspendLayout();
			this.vmethod_2().SuspendLayout();
			((ISupportInitialize)this.vmethod_4()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Controls.Add(this.vmethod_20());
			this.vmethod_0().Controls.Add(this.vmethod_18());
			this.vmethod_0().Controls.Add(this.vmethod_16());
			this.vmethod_0().Controls.Add(this.vmethod_12());
			this.vmethod_0().Controls.Add(this.vmethod_6());
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(491, 3);
			this.vmethod_0().Name = "GroupBox1";
			this.vmethod_0().Size = new Size(211, 160);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().TabStop = false;
			this.vmethod_0().Text = "Play game";
			this.vmethod_20().BackColor = Color.Transparent;
			this.vmethod_20().DialogResult = DialogResult.None;
			this.vmethod_20().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_20().Location = new Point(5, 15);
			this.vmethod_20().Name = "Button_QuickBattle";
			this.vmethod_20().method_1(0);
			this.vmethod_20().Size = new Size(200, 23);
			this.vmethod_20().TabIndex = 6;
			this.vmethod_20().Text = "Quick Battle";
			this.vmethod_18().BackColor = Color.Transparent;
			this.vmethod_18().DialogResult = DialogResult.None;
			this.vmethod_18().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_18().Location = new Point(5, 43);
			this.vmethod_18().Name = "Button_Campaign";
			this.vmethod_18().Padding = new Padding(5);
			this.vmethod_18().method_1(0);
			this.vmethod_18().Size = new Size(200, 23);
			this.vmethod_18().TabIndex = 5;
			this.vmethod_18().Text = "Campaign";
			this.vmethod_16().BackColor = Color.Transparent;
			this.vmethod_16().DialogResult = DialogResult.None;
			this.vmethod_16().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_16().Location = new Point(5, 128);
			this.vmethod_16().Name = "Button6";
			this.vmethod_16().Padding = new Padding(5);
			this.vmethod_16().method_1(0);
			this.vmethod_16().Size = new Size(200, 25);
			this.vmethod_16().TabIndex = 4;
			this.vmethod_16().Text = "Resume from last autosave";
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_12().Location = new Point(5, 98);
			this.vmethod_12().Name = "Button4";
			this.vmethod_12().Padding = new Padding(5);
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new Size(200, 25);
			this.vmethod_12().TabIndex = 3;
			this.vmethod_12().Text = "Load a saved game";
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.None;
			this.vmethod_6().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_6().Location = new Point(5, 71);
			this.vmethod_6().Name = "Button3";
			this.vmethod_6().Padding = new Padding(5);
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(200, 23);
			this.vmethod_6().TabIndex = 2;
			this.vmethod_6().Text = "Start new scenario";
			this.vmethod_2().Controls.Add(this.vmethod_8());
			this.vmethod_2().Controls.Add(this.vmethod_10());
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(491, 169);
			this.vmethod_2().Name = "GroupBox2";
			this.vmethod_2().Size = new Size(211, 81);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().TabStop = false;
			this.vmethod_2().Text = "Scenario Editor";
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().DialogResult = DialogResult.None;
			this.vmethod_8().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_8().Location = new Point(5, 50);
			this.vmethod_8().Name = "Button2";
			this.vmethod_8().Padding = new Padding(5);
			this.vmethod_8().method_1(0);
			this.vmethod_8().Size = new Size(200, 25);
			this.vmethod_8().TabIndex = 2;
			this.vmethod_8().Text = "Load existing scenario";
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().DialogResult = DialogResult.None;
			this.vmethod_10().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_10().Location = new Point(5, 20);
			this.vmethod_10().Name = "Button1";
			this.vmethod_10().Padding = new Padding(5);
			this.vmethod_10().method_1(0);
			this.vmethod_10().Size = new Size(200, 25);
			this.vmethod_10().TabIndex = 0;
			this.vmethod_10().Text = "Create new blank scenario";
			this.vmethod_14().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_14().BackColor = Color.Transparent;
			this.vmethod_14().DialogResult = DialogResult.None;
			this.vmethod_14().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_14().Location = new Point(613, 263);
			this.vmethod_14().Name = "Button5";
			this.vmethod_14().Padding = new Padding(5);
			this.vmethod_14().method_1(0);
			this.vmethod_14().Size = new Size(89, 33);
			this.vmethod_14().TabIndex = 2;
			this.vmethod_14().Text = "EXIT GAME";
			this.vmethod_4().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_4().Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.vmethod_4().Location = new Point(3, 4);
			this.vmethod_4().Name = "PictureBox1";
			this.vmethod_4().Size = new Size(483, 292);
			this.vmethod_4().TabIndex = 3;
			this.vmethod_4().TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(704, 299);
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_14());
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "StartGame";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Start menu";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_2().ResumeLayout(false);
			((ISupportInitialize)this.vmethod_4()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600875F RID: 34655 RVA: 0x000517BE File Offset: 0x0004F9BE
		[CompilerGenerated]
		internal Class115 vmethod_0()
		{
			return this.class115_0;
		}

		// Token: 0x06008760 RID: 34656 RVA: 0x000517C6 File Offset: 0x0004F9C6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class115 class115_2)
		{
			this.class115_0 = class115_2;
		}

		// Token: 0x06008761 RID: 34657 RVA: 0x000517CF File Offset: 0x0004F9CF
		[CompilerGenerated]
		internal Class115 vmethod_2()
		{
			return this.class115_1;
		}

		// Token: 0x06008762 RID: 34658 RVA: 0x000517D7 File Offset: 0x0004F9D7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class115 class115_2)
		{
			this.class115_1 = class115_2;
		}

		// Token: 0x06008763 RID: 34659 RVA: 0x000517E0 File Offset: 0x0004F9E0
		[CompilerGenerated]
		internal PictureBox vmethod_4()
		{
			return this.pictureBox_0;
		}

		// Token: 0x06008764 RID: 34660 RVA: 0x000517E8 File Offset: 0x0004F9E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(PictureBox pictureBox_1)
		{
			this.pictureBox_0 = pictureBox_1;
		}

		// Token: 0x06008765 RID: 34661 RVA: 0x000517F1 File Offset: 0x0004F9F1
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_0;
		}

		// Token: 0x06008766 RID: 34662 RVA: 0x0048A2D0 File Offset: 0x004884D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_4);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_8;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008767 RID: 34663 RVA: 0x000517F9 File Offset: 0x0004F9F9
		[CompilerGenerated]
		internal Control9 vmethod_8()
		{
			return this.control9_1;
		}

		// Token: 0x06008768 RID: 34664 RVA: 0x0048A314 File Offset: 0x00488514
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_6);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_8;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008769 RID: 34665 RVA: 0x00051801 File Offset: 0x0004FA01
		[CompilerGenerated]
		internal Control9 vmethod_10()
		{
			return this.control9_2;
		}

		// Token: 0x0600876A RID: 34666 RVA: 0x0048A358 File Offset: 0x00488558
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_8;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600876B RID: 34667 RVA: 0x00051809 File Offset: 0x0004FA09
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_3;
		}

		// Token: 0x0600876C RID: 34668 RVA: 0x0048A39C File Offset: 0x0048859C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_5);
			Control9 control = this.control9_3;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_3 = control9_8;
			control = this.control9_3;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600876D RID: 34669 RVA: 0x00051811 File Offset: 0x0004FA11
		[CompilerGenerated]
		internal Control9 vmethod_14()
		{
			return this.control9_4;
		}

		// Token: 0x0600876E RID: 34670 RVA: 0x0048A3E0 File Offset: 0x004885E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_7);
			Control9 control = this.control9_4;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_4 = control9_8;
			control = this.control9_4;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600876F RID: 34671 RVA: 0x00051819 File Offset: 0x0004FA19
		[CompilerGenerated]
		internal Control9 vmethod_16()
		{
			return this.control9_5;
		}

		// Token: 0x06008770 RID: 34672 RVA: 0x0048A424 File Offset: 0x00488624
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_8);
			Control9 control = this.control9_5;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_5 = control9_8;
			control = this.control9_5;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008771 RID: 34673 RVA: 0x00051821 File Offset: 0x0004FA21
		[CompilerGenerated]
		internal Control9 vmethod_18()
		{
			return this.control9_6;
		}

		// Token: 0x06008772 RID: 34674 RVA: 0x0048A468 File Offset: 0x00488668
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_9);
			Control9 control = this.control9_6;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_6 = control9_8;
			control = this.control9_6;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008773 RID: 34675 RVA: 0x00051829 File Offset: 0x0004FA29
		[CompilerGenerated]
		internal Control9 vmethod_20()
		{
			return this.control9_7;
		}

		// Token: 0x06008774 RID: 34676 RVA: 0x0048A4AC File Offset: 0x004886AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_10);
			Control9 control = this.control9_7;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_7 = control9_8;
			control = this.control9_7;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008775 RID: 34677 RVA: 0x0048A4F0 File Offset: 0x004886F0
		public StartGame()
		{
			base.FormClosed += this.StartGame_FormClosed;
			base.Load += this.StartGame_Load;
			base.KeyDown += this.StartGame_KeyDown;
			base.Shown += this.StartGame_Shown;
			this.InitializeComponent_1();
			this.bool_1 = false;
			this.bool_2 = false;
		}

		// Token: 0x06008776 RID: 34678 RVA: 0x0048A560 File Offset: 0x00488760
		private void method_3(object sender, EventArgs e)
		{
			if (!GameGeneral.smethod_6() && !Class2556.smethod_6(Class2556.Enum209.const_0))
			{
				Class2413.smethod_2().method_30().method_2(new List<Class2556.Enum209>
				{
					Class2556.Enum209.const_0
				});
				Class2413.smethod_2().method_30().Show();
				return;
			}
			Client.smethod_0().method_2(Class279.Enum67.const_2);
			Client.smethod_76();
			base.Close();
		}

		// Token: 0x06008777 RID: 34679 RVA: 0x00044FFF File Offset: 0x000431FF
		private void method_4(object sender, EventArgs e)
		{
			Client.smethod_0().method_2(Class279.Enum67.const_0);
			Class2413.smethod_2().method_38().enum208_0 = LoadScenario.Enum208.const_0;
			Class2413.smethod_2().method_38().Show();
		}

		// Token: 0x06008778 RID: 34680 RVA: 0x00044FD3 File Offset: 0x000431D3
		private void method_5(object sender, EventArgs e)
		{
			Client.smethod_0().method_2(Class279.Enum67.const_0);
			Class2413.smethod_2().method_38().enum208_0 = LoadScenario.Enum208.const_1;
			Class2413.smethod_2().method_38().Show();
		}

		// Token: 0x06008779 RID: 34681 RVA: 0x003BC520 File Offset: 0x003BA720
		private void method_6(object sender, EventArgs e)
		{
			if (!Class2556.smethod_6(Class2556.Enum209.const_0) && !GameGeneral.smethod_6())
			{
				Class2413.smethod_2().method_30().method_2(new List<Class2556.Enum209>
				{
					Class2556.Enum209.const_0
				});
				Class2413.smethod_2().method_30().Show();
				return;
			}
			Client.smethod_0().method_2(Class279.Enum67.const_2);
			Class2413.smethod_2().method_38().enum208_0 = LoadScenario.Enum208.const_0;
			Class2413.smethod_2().method_38().Show();
		}

		// Token: 0x0600877A RID: 34682 RVA: 0x00044FC2 File Offset: 0x000431C2
		private void method_7(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_41().Close();
		}

		// Token: 0x0600877B RID: 34683 RVA: 0x0004B84D File Offset: 0x00049A4D
		private void StartGame_FormClosed(object sender, FormClosedEventArgs e)
		{
			Class2413.smethod_2().method_41().Enabled = true;
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x0600877C RID: 34684 RVA: 0x0048A5C0 File Offset: 0x004887C0
		private void StartGame_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_4().Image = Class2558.bitmap_0;
			this.vmethod_18().Visible = true;
			Class2413.smethod_2().method_41().Enabled = false;
			Client.smethod_0().method_4();
		}

		// Token: 0x0600877D RID: 34685 RVA: 0x0048A618 File Offset: 0x00488818
		private void method_8(object sender, EventArgs e)
		{
			if (File.Exists(GameGeneral.string_4 + "\\Autosave.scen"))
			{
				Client.smethod_0().method_2(Class279.Enum67.const_0);
				Class2413.smethod_2().method_55().string_0 = GameGeneral.string_4 + "\\Autosave.scen";
				Class2413.smethod_2().method_55().Show();
				base.Close();
				return;
			}
			DarkMessageBox.smethod_2("No autosave file was found at the path \\Scenarios\\Autosave.scen", "No autosave found", Enum11.const_0);
		}

		// Token: 0x0600877E RID: 34686 RVA: 0x0004B8B4 File Offset: 0x00049AB4
		private void StartGame_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x0600877F RID: 34687 RVA: 0x00051831 File Offset: 0x0004FA31
		private void StartGame_Shown(object sender, EventArgs e)
		{
			if (Class570.class280_0.method_10())
			{
				Class2561.smethod_1();
			}
			base.Close();
		}

		// Token: 0x06008780 RID: 34688 RVA: 0x0004737D File Offset: 0x0004557D
		private void method_9(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_10().Show();
			base.Close();
		}

		// Token: 0x06008781 RID: 34689 RVA: 0x0005184A File Offset: 0x0004FA4A
		private void method_10(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_50().Show();
			base.Close();
		}

		// Token: 0x040049B9 RID: 18873
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox1")]
		private Class115 class115_0;

		// Token: 0x040049BA RID: 18874
		[AccessedThroughProperty("GroupBox2")]
		[CompilerGenerated]
		private Class115 class115_1;

		// Token: 0x040049BB RID: 18875
		[CompilerGenerated]
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox pictureBox_0;

		// Token: 0x040049BC RID: 18876
		[CompilerGenerated]
		[AccessedThroughProperty("Button3")]
		private Control9 control9_0;

		// Token: 0x040049BD RID: 18877
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_1;

		// Token: 0x040049BE RID: 18878
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x040049BF RID: 18879
		[AccessedThroughProperty("Button4")]
		[CompilerGenerated]
		private Control9 control9_3;

		// Token: 0x040049C0 RID: 18880
		[AccessedThroughProperty("Button5")]
		[CompilerGenerated]
		private Control9 control9_4;

		// Token: 0x040049C1 RID: 18881
		[AccessedThroughProperty("Button6")]
		[CompilerGenerated]
		private Control9 control9_5;

		// Token: 0x040049C2 RID: 18882
		[CompilerGenerated]
		[AccessedThroughProperty("Button_Campaign")]
		private Control9 control9_6;

		// Token: 0x040049C3 RID: 18883
		[CompilerGenerated]
		[AccessedThroughProperty("Button_QuickBattle")]
		private Control9 control9_7;
	}
}
