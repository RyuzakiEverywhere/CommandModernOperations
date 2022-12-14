using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000ED8 RID: 3800
	[DesignerGenerated]
	internal sealed partial class EditWeather : DarkSecondaryFormBase
	{
		// Token: 0x0600846E RID: 33902 RVA: 0x004715E0 File Offset: 0x0046F7E0
		public EditWeather()
		{
			base.Load += this.EditWeather_Load;
			base.KeyDown += this.EditWeather_KeyDown;
			base.FormClosing += this.EditWeather_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x06008470 RID: 33904 RVA: 0x00471670 File Offset: 0x0046F870
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(EditWeather));
			this.vmethod_1(new Class125());
			this.vmethod_3(new ToolStripLabel());
			this.vmethod_5(new ToolStripDropDownButton());
			this.vmethod_7(new Control12());
			this.vmethod_9(new TabPage());
			this.vmethod_33(new Class116());
			this.vmethod_35(new Class116());
			this.vmethod_37(new TrackBar());
			this.vmethod_39(new Class116());
			this.vmethod_29(new Class116());
			this.vmethod_31(new TrackBar());
			this.vmethod_17(new Class116());
			this.vmethod_19(new Class116());
			this.vmethod_21(new Class116());
			this.vmethod_23(new Class116());
			this.vmethod_25(new TrackBar());
			this.vmethod_27(new TrackBar());
			this.vmethod_15(new Class116());
			this.vmethod_11(new Class116());
			this.vmethod_13(new Class116());
			this.vmethod_0().SuspendLayout();
			this.vmethod_6().SuspendLayout();
			this.vmethod_8().SuspendLayout();
			((ISupportInitialize)this.vmethod_36()).BeginInit();
			((ISupportInitialize)this.vmethod_30()).BeginInit();
			((ISupportInitialize)this.vmethod_24()).BeginInit();
			((ISupportInitialize)this.vmethod_26()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_0().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_2(),
				this.vmethod_4()
			});
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "ToolStrip1";
			this.vmethod_0().Size = new Size(563, 25);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "ToolStrip1";
			this.vmethod_2().Name = "ToolStripLabel1";
			this.vmethod_2().Size = new Size(138, 22);
			this.vmethod_2().Text = "Weather modelling level:";
			this.vmethod_4().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_4().Image = (Image)componentResourceManager.GetObject("TSDD_WeatherLevel.Image");
			this.vmethod_4().ImageTransparentColor = Color.Magenta;
			this.vmethod_4().Name = "TSDD_WeatherLevel";
			this.vmethod_4().Size = new Size(56, 22);
			this.vmethod_4().Text = "Level 0";
			this.vmethod_6().Controls.Add(this.vmethod_8());
			this.vmethod_6().Dock = DockStyle.Fill;
			this.vmethod_6().Location = new Point(0, 25);
			this.vmethod_6().Multiline = true;
			this.vmethod_6().Name = "TC_WeatherLevel";
			this.vmethod_6().SelectedIndex = 0;
			this.vmethod_6().Size = new Size(563, 172);
			this.vmethod_6().TabIndex = 19;
			this.vmethod_8().BackColor = SystemColors.Control;
			this.vmethod_8().Controls.Add(this.vmethod_32());
			this.vmethod_8().Controls.Add(this.vmethod_34());
			this.vmethod_8().Controls.Add(this.vmethod_36());
			this.vmethod_8().Controls.Add(this.vmethod_38());
			this.vmethod_8().Controls.Add(this.vmethod_28());
			this.vmethod_8().Controls.Add(this.vmethod_30());
			this.vmethod_8().Controls.Add(this.vmethod_16());
			this.vmethod_8().Controls.Add(this.vmethod_18());
			this.vmethod_8().Controls.Add(this.vmethod_20());
			this.vmethod_8().Controls.Add(this.vmethod_22());
			this.vmethod_8().Controls.Add(this.vmethod_24());
			this.vmethod_8().Controls.Add(this.vmethod_26());
			this.vmethod_8().Controls.Add(this.vmethod_14());
			this.vmethod_8().Controls.Add(this.vmethod_10());
			this.vmethod_8().Controls.Add(this.vmethod_12());
			this.vmethod_8().Location = new Point(4, 23);
			this.vmethod_8().Name = "TabPage1";
			this.vmethod_8().Padding = new Padding(3);
			this.vmethod_8().Size = new Size(555, 145);
			this.vmethod_8().TabIndex = 0;
			this.vmethod_8().Text = "Level 0";
			this.vmethod_32().method_2(true);
			this.vmethod_32().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_32().Location = new Point(410, 113);
			this.vmethod_32().Name = "Label9";
			this.vmethod_32().Size = new Size(62, 13);
			this.vmethod_32().TabIndex = 14;
			this.vmethod_32().Text = "Hurricane";
			this.vmethod_34().method_2(true);
			this.vmethod_34().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_34().Location = new Point(144, 111);
			this.vmethod_34().Name = "Label10";
			this.vmethod_34().Size = new Size(34, 13);
			this.vmethod_34().TabIndex = 13;
			this.vmethod_34().Text = "Calm";
			this.vmethod_36().AutoSize = false;
			this.vmethod_36().LargeChange = 10;
			this.vmethod_36().Location = new Point(177, 109);
			this.vmethod_36().Maximum = 9;
			this.vmethod_36().Name = "TrackBar_SeaState";
			this.vmethod_36().Size = new Size(239, 31);
			this.vmethod_36().TabIndex = 12;
			this.vmethod_38().method_2(true);
			this.vmethod_38().Font = new Font(Client.font_1.FontFamily, 12f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_38().Location = new Point(8, 109);
			this.vmethod_38().Name = "Label8";
			this.vmethod_38().Size = new Size(130, 20);
			this.vmethod_38().TabIndex = 11;
			this.vmethod_38().Text = "Wind / Sea state:";
			this.vmethod_28().method_2(true);
			this.vmethod_28().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_28().Location = new Point(410, 20);
			this.vmethod_28().Name = "Label_AverageTemp";
			this.vmethod_28().Size = new Size(24, 13);
			this.vmethod_28().TabIndex = 10;
			this.vmethod_28().Text = "° C";
			this.vmethod_30().AutoSize = false;
			this.vmethod_30().LargeChange = 10;
			this.vmethod_30().Location = new Point(177, 15);
			this.vmethod_30().Maximum = 50;
			this.vmethod_30().Minimum = -50;
			this.vmethod_30().Name = "TrackBar_AverageTemp";
			this.vmethod_30().Size = new Size(239, 31);
			this.vmethod_30().SmallChange = 5;
			this.vmethod_30().TabIndex = 9;
			this.vmethod_16().method_2(true);
			this.vmethod_16().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_16().Location = new Point(410, 82);
			this.vmethod_16().Name = "Label7";
			this.vmethod_16().Size = new Size(127, 13);
			this.vmethod_16().TabIndex = 8;
			this.vmethod_16().Text = "Full with thick clouds";
			this.vmethod_18().method_2(true);
			this.vmethod_18().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_18().Location = new Point(142, 82);
			this.vmethod_18().Name = "Label6";
			this.vmethod_18().Size = new Size(36, 13);
			this.vmethod_18().TabIndex = 7;
			this.vmethod_18().Text = "Clear";
			this.vmethod_20().method_2(true);
			this.vmethod_20().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_20().Location = new Point(410, 51);
			this.vmethod_20().Name = "Label5";
			this.vmethod_20().Size = new Size(77, 13);
			this.vmethod_20().TabIndex = 6;
			this.vmethod_20().Text = "Heavy storm";
			this.vmethod_22().method_2(true);
			this.vmethod_22().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_22().Location = new Point(130, 49);
			this.vmethod_22().Name = "Label4";
			this.vmethod_22().Size = new Size(48, 13);
			this.vmethod_22().TabIndex = 5;
			this.vmethod_22().Text = "No rain";
			this.vmethod_24().AutoSize = false;
			this.vmethod_24().LargeChange = 10;
			this.vmethod_24().Location = new Point(177, 46);
			this.vmethod_24().Maximum = 50;
			this.vmethod_24().Name = "TrackBar_Rainfall";
			this.vmethod_24().Size = new Size(239, 31);
			this.vmethod_24().SmallChange = 5;
			this.vmethod_24().TabIndex = 4;
			this.vmethod_26().AutoSize = false;
			this.vmethod_26().LargeChange = 10;
			this.vmethod_26().Location = new Point(177, 80);
			this.vmethod_26().Name = "TrackBar_FUR";
			this.vmethod_26().Size = new Size(239, 31);
			this.vmethod_26().TabIndex = 3;
			this.vmethod_14().method_2(true);
			this.vmethod_14().Font = new Font(Client.font_1.FontFamily, 12f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_14().Location = new Point(8, 77);
			this.vmethod_14().Name = "Label3";
			this.vmethod_14().Size = new Size(82, 20);
			this.vmethod_14().TabIndex = 2;
			this.vmethod_14().Text = "The sky is:";
			this.vmethod_10().method_2(true);
			this.vmethod_10().Font = new Font(Client.font_1.FontFamily, 12f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_10().Location = new Point(8, 46);
			this.vmethod_10().Name = "Label2";
			this.vmethod_10().Size = new Size(98, 20);
			this.vmethod_10().TabIndex = 1;
			this.vmethod_10().Text = "Rainfall rate:";
			this.vmethod_12().method_2(true);
			this.vmethod_12().Font = new Font(Client.font_1.FontFamily, 12f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_12().Location = new Point(8, 15);
			this.vmethod_12().Name = "Label1";
			this.vmethod_12().Size = new Size(163, 20);
			this.vmethod_12().TabIndex = 0;
			this.vmethod_12().Text = "Average temperature:";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(563, 197);
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditWeather";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Weather editor";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_0().PerformLayout();
			this.vmethod_6().ResumeLayout(false);
			this.vmethod_8().ResumeLayout(false);
			this.vmethod_8().PerformLayout();
			((ISupportInitialize)this.vmethod_36()).EndInit();
			((ISupportInitialize)this.vmethod_30()).EndInit();
			((ISupportInitialize)this.vmethod_24()).EndInit();
			((ISupportInitialize)this.vmethod_26()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06008471 RID: 33905 RVA: 0x000502DF File Offset: 0x0004E4DF
		[CompilerGenerated]
		internal Class125 vmethod_0()
		{
			return this.class125_0;
		}

		// Token: 0x06008472 RID: 33906 RVA: 0x000502E7 File Offset: 0x0004E4E7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x06008473 RID: 33907 RVA: 0x000502F0 File Offset: 0x0004E4F0
		[CompilerGenerated]
		internal ToolStripLabel vmethod_2()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x06008474 RID: 33908 RVA: 0x000502F8 File Offset: 0x0004E4F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStripLabel toolStripLabel_1)
		{
			this.toolStripLabel_0 = toolStripLabel_1;
		}

		// Token: 0x06008475 RID: 33909 RVA: 0x00050301 File Offset: 0x0004E501
		[CompilerGenerated]
		internal ToolStripDropDownButton vmethod_4()
		{
			return this.toolStripDropDownButton_0;
		}

		// Token: 0x06008476 RID: 33910 RVA: 0x00050309 File Offset: 0x0004E509
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripDropDownButton toolStripDropDownButton_1)
		{
			this.toolStripDropDownButton_0 = toolStripDropDownButton_1;
		}

		// Token: 0x06008477 RID: 33911 RVA: 0x00050312 File Offset: 0x0004E512
		[CompilerGenerated]
		internal Control12 vmethod_6()
		{
			return this.control12_0;
		}

		// Token: 0x06008478 RID: 33912 RVA: 0x0005031A File Offset: 0x0004E51A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control12 control12_1)
		{
			this.control12_0 = control12_1;
		}

		// Token: 0x06008479 RID: 33913 RVA: 0x00050323 File Offset: 0x0004E523
		[CompilerGenerated]
		internal TabPage vmethod_8()
		{
			return this.tabPage_0;
		}

		// Token: 0x0600847A RID: 33914 RVA: 0x0005032B File Offset: 0x0004E52B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TabPage tabPage_1)
		{
			this.tabPage_0 = tabPage_1;
		}

		// Token: 0x0600847B RID: 33915 RVA: 0x00050334 File Offset: 0x0004E534
		[CompilerGenerated]
		internal Class116 vmethod_10()
		{
			return this.class116_0;
		}

		// Token: 0x0600847C RID: 33916 RVA: 0x0005033C File Offset: 0x0004E53C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class116 class116_11)
		{
			this.class116_0 = class116_11;
		}

		// Token: 0x0600847D RID: 33917 RVA: 0x00050345 File Offset: 0x0004E545
		[CompilerGenerated]
		internal Class116 vmethod_12()
		{
			return this.class116_1;
		}

		// Token: 0x0600847E RID: 33918 RVA: 0x0005034D File Offset: 0x0004E54D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class116 class116_11)
		{
			this.class116_1 = class116_11;
		}

		// Token: 0x0600847F RID: 33919 RVA: 0x00050356 File Offset: 0x0004E556
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_2;
		}

		// Token: 0x06008480 RID: 33920 RVA: 0x0005035E File Offset: 0x0004E55E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_11)
		{
			this.class116_2 = class116_11;
		}

		// Token: 0x06008481 RID: 33921 RVA: 0x00050367 File Offset: 0x0004E567
		[CompilerGenerated]
		internal Class116 vmethod_16()
		{
			return this.class116_3;
		}

		// Token: 0x06008482 RID: 33922 RVA: 0x0005036F File Offset: 0x0004E56F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class116 class116_11)
		{
			this.class116_3 = class116_11;
		}

		// Token: 0x06008483 RID: 33923 RVA: 0x00050378 File Offset: 0x0004E578
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_4;
		}

		// Token: 0x06008484 RID: 33924 RVA: 0x00050380 File Offset: 0x0004E580
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_11)
		{
			this.class116_4 = class116_11;
		}

		// Token: 0x06008485 RID: 33925 RVA: 0x00050389 File Offset: 0x0004E589
		[CompilerGenerated]
		internal Class116 vmethod_20()
		{
			return this.class116_5;
		}

		// Token: 0x06008486 RID: 33926 RVA: 0x00050391 File Offset: 0x0004E591
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class116 class116_11)
		{
			this.class116_5 = class116_11;
		}

		// Token: 0x06008487 RID: 33927 RVA: 0x0005039A File Offset: 0x0004E59A
		[CompilerGenerated]
		internal Class116 vmethod_22()
		{
			return this.class116_6;
		}

		// Token: 0x06008488 RID: 33928 RVA: 0x000503A2 File Offset: 0x0004E5A2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class116 class116_11)
		{
			this.class116_6 = class116_11;
		}

		// Token: 0x06008489 RID: 33929 RVA: 0x000503AB File Offset: 0x0004E5AB
		[CompilerGenerated]
		internal TrackBar vmethod_24()
		{
			return this.trackBar_0;
		}

		// Token: 0x0600848A RID: 33930 RVA: 0x004723F4 File Offset: 0x004705F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(TrackBar trackBar_4)
		{
			EventHandler value = new EventHandler(this.method_4);
			TrackBar trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.Scroll -= value;
			}
			this.trackBar_0 = trackBar_4;
			trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.Scroll += value;
			}
		}

		// Token: 0x0600848B RID: 33931 RVA: 0x000503B3 File Offset: 0x0004E5B3
		[CompilerGenerated]
		internal TrackBar vmethod_26()
		{
			return this.trackBar_1;
		}

		// Token: 0x0600848C RID: 33932 RVA: 0x00472438 File Offset: 0x00470638
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(TrackBar trackBar_4)
		{
			EventHandler value = new EventHandler(this.method_5);
			TrackBar trackBar = this.trackBar_1;
			if (trackBar != null)
			{
				trackBar.Scroll -= value;
			}
			this.trackBar_1 = trackBar_4;
			trackBar = this.trackBar_1;
			if (trackBar != null)
			{
				trackBar.Scroll += value;
			}
		}

		// Token: 0x0600848D RID: 33933 RVA: 0x000503BB File Offset: 0x0004E5BB
		[CompilerGenerated]
		internal Class116 vmethod_28()
		{
			return this.class116_7;
		}

		// Token: 0x0600848E RID: 33934 RVA: 0x000503C3 File Offset: 0x0004E5C3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Class116 class116_11)
		{
			this.class116_7 = class116_11;
		}

		// Token: 0x0600848F RID: 33935 RVA: 0x000503CC File Offset: 0x0004E5CC
		[CompilerGenerated]
		internal TrackBar vmethod_30()
		{
			return this.trackBar_2;
		}

		// Token: 0x06008490 RID: 33936 RVA: 0x0047247C File Offset: 0x0047067C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(TrackBar trackBar_4)
		{
			EventHandler value = new EventHandler(this.method_3);
			TrackBar trackBar = this.trackBar_2;
			if (trackBar != null)
			{
				trackBar.Scroll -= value;
			}
			this.trackBar_2 = trackBar_4;
			trackBar = this.trackBar_2;
			if (trackBar != null)
			{
				trackBar.Scroll += value;
			}
		}

		// Token: 0x06008491 RID: 33937 RVA: 0x000503D4 File Offset: 0x0004E5D4
		[CompilerGenerated]
		internal Class116 vmethod_32()
		{
			return this.class116_8;
		}

		// Token: 0x06008492 RID: 33938 RVA: 0x000503DC File Offset: 0x0004E5DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Class116 class116_11)
		{
			this.class116_8 = class116_11;
		}

		// Token: 0x06008493 RID: 33939 RVA: 0x000503E5 File Offset: 0x0004E5E5
		[CompilerGenerated]
		internal Class116 vmethod_34()
		{
			return this.class116_9;
		}

		// Token: 0x06008494 RID: 33940 RVA: 0x000503ED File Offset: 0x0004E5ED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Class116 class116_11)
		{
			this.class116_9 = class116_11;
		}

		// Token: 0x06008495 RID: 33941 RVA: 0x000503F6 File Offset: 0x0004E5F6
		[CompilerGenerated]
		internal TrackBar vmethod_36()
		{
			return this.trackBar_3;
		}

		// Token: 0x06008496 RID: 33942 RVA: 0x004724C0 File Offset: 0x004706C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(TrackBar trackBar_4)
		{
			EventHandler value = new EventHandler(this.method_6);
			TrackBar trackBar = this.trackBar_3;
			if (trackBar != null)
			{
				trackBar.Scroll -= value;
			}
			this.trackBar_3 = trackBar_4;
			trackBar = this.trackBar_3;
			if (trackBar != null)
			{
				trackBar.Scroll += value;
			}
		}

		// Token: 0x06008497 RID: 33943 RVA: 0x000503FE File Offset: 0x0004E5FE
		[CompilerGenerated]
		internal Class116 vmethod_38()
		{
			return this.class116_10;
		}

		// Token: 0x06008498 RID: 33944 RVA: 0x00050406 File Offset: 0x0004E606
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Class116 class116_11)
		{
			this.class116_10 = class116_11;
		}

		// Token: 0x06008499 RID: 33945 RVA: 0x00472504 File Offset: 0x00470704
		private void EditWeather_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.weatherProfile_0 = Client.smethod_46().method_23();
			this.vmethod_30().Value = (int)Math.Round(this.weatherProfile_0.method_6());
			this.vmethod_28().Text = Conversions.ToString(this.weatherProfile_0.method_6()) + " °C";
			this.vmethod_24().Value = (int)Math.Round((double)this.weatherProfile_0.float_0);
			this.vmethod_26().Value = (int)Math.Round((double)(this.weatherProfile_0.method_3() * 10f));
			this.vmethod_36().Value = this.weatherProfile_0.int_0;
		}

		// Token: 0x0600849A RID: 33946 RVA: 0x004725CC File Offset: 0x004707CC
		private void method_3(object sender, EventArgs e)
		{
			Client.smethod_46().method_23().method_7((double)this.vmethod_30().Value);
			this.vmethod_28().Text = Conversions.ToString(Client.smethod_46().method_23().method_6()) + " °C";
		}

		// Token: 0x0600849B RID: 33947 RVA: 0x0005040F File Offset: 0x0004E60F
		private void method_4(object sender, EventArgs e)
		{
			Client.smethod_46().method_23().float_0 = (float)this.vmethod_24().Value;
		}

		// Token: 0x0600849C RID: 33948 RVA: 0x0005042C File Offset: 0x0004E62C
		private void method_5(object sender, EventArgs e)
		{
			Client.smethod_46().method_23().method_4((float)((double)this.vmethod_26().Value * 0.1));
		}

		// Token: 0x0600849D RID: 33949 RVA: 0x00050454 File Offset: 0x0004E654
		private void method_6(object sender, EventArgs e)
		{
			Client.smethod_46().method_23().int_0 = this.vmethod_36().Value;
		}

		// Token: 0x0600849E RID: 33950 RVA: 0x00472620 File Offset: 0x00470820
		private void EditWeather_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (!base.Visible || (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x0600849F RID: 33951 RVA: 0x00044820 File Offset: 0x00042A20
		private void EditWeather_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x04004876 RID: 18550
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStrip1")]
		private Class125 class125_0;

		// Token: 0x04004877 RID: 18551
		[AccessedThroughProperty("ToolStripLabel1")]
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x04004878 RID: 18552
		[AccessedThroughProperty("TSDD_WeatherLevel")]
		[CompilerGenerated]
		private ToolStripDropDownButton toolStripDropDownButton_0;

		// Token: 0x04004879 RID: 18553
		[AccessedThroughProperty("TC_WeatherLevel")]
		[CompilerGenerated]
		private Control12 control12_0;

		// Token: 0x0400487A RID: 18554
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage1")]
		private TabPage tabPage_0;

		// Token: 0x0400487B RID: 18555
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x0400487C RID: 18556
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_1;

		// Token: 0x0400487D RID: 18557
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_2;

		// Token: 0x0400487E RID: 18558
		[CompilerGenerated]
		[AccessedThroughProperty("Label7")]
		private Class116 class116_3;

		// Token: 0x0400487F RID: 18559
		[AccessedThroughProperty("Label6")]
		[CompilerGenerated]
		private Class116 class116_4;

		// Token: 0x04004880 RID: 18560
		[AccessedThroughProperty("Label5")]
		[CompilerGenerated]
		private Class116 class116_5;

		// Token: 0x04004881 RID: 18561
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Class116 class116_6;

		// Token: 0x04004882 RID: 18562
		[CompilerGenerated]
		[AccessedThroughProperty("TrackBar_Rainfall")]
		private TrackBar trackBar_0;

		// Token: 0x04004883 RID: 18563
		[CompilerGenerated]
		[AccessedThroughProperty("TrackBar_FUR")]
		private TrackBar trackBar_1;

		// Token: 0x04004884 RID: 18564
		[CompilerGenerated]
		[AccessedThroughProperty("Label_AverageTemp")]
		private Class116 class116_7;

		// Token: 0x04004885 RID: 18565
		[CompilerGenerated]
		[AccessedThroughProperty("TrackBar_AverageTemp")]
		private TrackBar trackBar_2;

		// Token: 0x04004886 RID: 18566
		[CompilerGenerated]
		[AccessedThroughProperty("Label9")]
		private Class116 class116_8;

		// Token: 0x04004887 RID: 18567
		[CompilerGenerated]
		[AccessedThroughProperty("Label10")]
		private Class116 class116_9;

		// Token: 0x04004888 RID: 18568
		[CompilerGenerated]
		[AccessedThroughProperty("TrackBar_SeaState")]
		private TrackBar trackBar_3;

		// Token: 0x04004889 RID: 18569
		[CompilerGenerated]
		[AccessedThroughProperty("Label8")]
		private Class116 class116_10;

		// Token: 0x0400488A RID: 18570
		private Weather.WeatherProfile weatherProfile_0;
	}
}
