using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;
using ns5;
using ns7;

namespace ns6
{
	// Token: 0x02000E8F RID: 3727
	[DesignerGenerated]
	internal sealed partial class AboutBox1 : DarkSecondaryFormBase
	{
		// Token: 0x0600736D RID: 29549 RVA: 0x003E4B8C File Offset: 0x003E2D8C
		public AboutBox1()
		{
			base.Load += this.AboutBox1_Load;
			base.KeyDown += this.AboutBox1_KeyDown;
			base.FormClosing += this.AboutBox1_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x003E4BDC File Offset: 0x003E2DDC
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutBox1));
			this.vmethod_19(new Class116());
			this.vmethod_15(new Control8());
			this.vmethod_9(new Class116());
			this.vmethod_7(new Class116());
			this.vmethod_5(new Class116());
			this.vmethod_11(new Class116());
			this.vmethod_13(new PictureBox());
			this.vmethod_1(new Class116());
			this.vmethod_3(new Control9());
			this.vmethod_17(new Control8());
			((ISupportInitialize)this.vmethod_12()).BeginInit();
			base.SuspendLayout();
			this.vmethod_18().method_2(true);
			this.vmethod_18().BackColor = Color.Transparent;
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(228, 41);
			this.vmethod_18().MaximumSize = new Size(400, 0);
			this.vmethod_18().Name = "Label_License";
			this.vmethod_18().Size = new Size(44, 13);
			this.vmethod_18().TabIndex = 9;
			this.vmethod_18().Text = "License";
			this.vmethod_14().method_14(null);
			this.vmethod_14().method_15(AutoCompleteMode.None);
			this.vmethod_14().method_13(AutoCompleteSource.None);
			this.vmethod_14().BackColor = SystemColors.Control;
			this.vmethod_14().method_17(new Font("Segoe UI", 8f));
			this.vmethod_14().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_14().method_12(null);
			this.vmethod_14().method_18(null);
			this.vmethod_14().Location = new Point(13, 154);
			this.vmethod_14().method_2(32767);
			this.vmethod_14().method_7(true);
			this.vmethod_14().Name = "TextBox1";
			this.vmethod_14().method_3(true);
			this.vmethod_14().method_19(ScrollBars.None);
			this.vmethod_14().method_9(0);
			this.vmethod_14().Size = new Size(620, 255);
			this.vmethod_14().TabIndex = 8;
			this.vmethod_14().method_1(HorizontalAlignment.Left);
			this.vmethod_14().method_5(false);
			this.vmethod_14().method_10("");
			this.vmethod_8().method_2(true);
			this.vmethod_8().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(12, 138);
			this.vmethod_8().Name = "Label3";
			this.vmethod_8().Size = new Size(93, 30);
			this.vmethod_8().TabIndex = 5;
			this.vmethod_8().Text = "Credits:";
			this.vmethod_6().method_2(true);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(228, 120);
			this.vmethod_6().Name = "Label2";
			this.vmethod_6().Size = new Size(204, 13);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_6().Text = "Copyright (c)2007-2018 WarfareSims LTD";
			this.vmethod_4().method_2(true);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(228, 92);
			this.vmethod_4().Name = "Label1";
			this.vmethod_4().Size = new Size(405, 27);
			this.vmethod_4().TabIndex = 3;
			this.vmethod_4().Text = "Developed by WarfareSims LTD";
			this.vmethod_10().method_2(true);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Location = new Point(228, 120);
			this.vmethod_10().Name = "Label_Copyright";
			this.vmethod_10().Size = new Size(339, 32);
			this.vmethod_10().TabIndex = 4;
			this.vmethod_10().Text = "(c)2013-2018 WarfareSims LTD";
			this.vmethod_12().Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.vmethod_12().Location = new Point(13, 13);
			this.vmethod_12().Name = "PictureBox1";
			this.vmethod_12().Size = new Size(209, 120);
			this.vmethod_12().SizeMode = PictureBoxSizeMode.StretchImage;
			this.vmethod_12().TabIndex = 2;
			this.vmethod_12().TabStop = false;
			this.vmethod_0().AutoEllipsis = true;
			this.vmethod_0().method_2(true);
			this.vmethod_0().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(228, 13);
			this.vmethod_0().MaximumSize = new Size(400, 0);
			this.vmethod_0().Name = "Label_version";
			this.vmethod_0().Size = new Size(333, 60);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Command - Modern Air/Naval Operations Build x";
			this.vmethod_2().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DialogResult = DialogResult.None;
			this.vmethod_2().Font = new Font("Segoe UI", 10f);
			this.vmethod_2().ForeColor = SystemColors.Control;
			this.vmethod_2().Location = new Point(558, 415);
			this.vmethod_2().Name = "OKButton";
			this.vmethod_2().method_1(0);
			this.vmethod_2().Size = new Size(75, 23);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "OK";
			this.vmethod_16().method_14(null);
			this.vmethod_16().method_15(AutoCompleteMode.None);
			this.vmethod_16().method_13(AutoCompleteSource.None);
			this.vmethod_16().BackColor = SystemColors.Control;
			this.vmethod_16().method_17(new Font("Segoe UI", 8f));
			this.vmethod_16().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_16().method_12(null);
			this.vmethod_16().method_18(null);
			this.vmethod_16().Location = new Point(231, 29);
			this.vmethod_16().method_2(32767);
			this.vmethod_16().method_7(true);
			this.vmethod_16().Name = "TB_Licensing";
			this.vmethod_16().method_3(true);
			this.vmethod_16().method_19(ScrollBars.Vertical);
			this.vmethod_16().method_9(0);
			this.vmethod_16().Size = new Size(402, 79);
			this.vmethod_16().TabIndex = 9;
			this.vmethod_16().method_1(HorizontalAlignment.Left);
			this.vmethod_16().method_5(false);
			this.vmethod_16().method_10("");
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(638, 442);
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AboutBox1";
			base.Padding = new Padding(9);
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "About Command";
			((ISupportInitialize)this.vmethod_12()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06007370 RID: 29552 RVA: 0x000480FD File Offset: 0x000462FD
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x06007371 RID: 29553 RVA: 0x00048105 File Offset: 0x00046305
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_6)
		{
			this.class116_0 = class116_6;
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x0004810E File Offset: 0x0004630E
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_0;
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x003E54B8 File Offset: 0x003E36B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control9 control9_1)
		{
			EventHandler value = new EventHandler(this.method_3);
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

		// Token: 0x06007374 RID: 29556 RVA: 0x00048116 File Offset: 0x00046316
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_1;
		}

		// Token: 0x06007375 RID: 29557 RVA: 0x0004811E File Offset: 0x0004631E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_6)
		{
			this.class116_1 = class116_6;
		}

		// Token: 0x06007376 RID: 29558 RVA: 0x00048127 File Offset: 0x00046327
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_2;
		}

		// Token: 0x06007377 RID: 29559 RVA: 0x0004812F File Offset: 0x0004632F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_6)
		{
			this.class116_2 = class116_6;
		}

		// Token: 0x06007378 RID: 29560 RVA: 0x00048138 File Offset: 0x00046338
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_3;
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x00048140 File Offset: 0x00046340
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_6)
		{
			this.class116_3 = class116_6;
		}

		// Token: 0x0600737A RID: 29562 RVA: 0x00048149 File Offset: 0x00046349
		[CompilerGenerated]
		internal Class116 vmethod_10()
		{
			return this.class116_4;
		}

		// Token: 0x0600737B RID: 29563 RVA: 0x00048151 File Offset: 0x00046351
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class116 class116_6)
		{
			this.class116_4 = class116_6;
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x0004815A File Offset: 0x0004635A
		[CompilerGenerated]
		internal PictureBox vmethod_12()
		{
			return this.pictureBox_0;
		}

		// Token: 0x0600737D RID: 29565 RVA: 0x00048162 File Offset: 0x00046362
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(PictureBox pictureBox_1)
		{
			this.pictureBox_0 = pictureBox_1;
		}

		// Token: 0x0600737E RID: 29566 RVA: 0x0004816B File Offset: 0x0004636B
		[CompilerGenerated]
		internal Control8 vmethod_14()
		{
			return this.control8_0;
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x00048173 File Offset: 0x00046373
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Control8 control8_2)
		{
			this.control8_0 = control8_2;
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x0004817C File Offset: 0x0004637C
		[CompilerGenerated]
		internal Control8 vmethod_16()
		{
			return this.control8_1;
		}

		// Token: 0x06007381 RID: 29569 RVA: 0x00048184 File Offset: 0x00046384
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Control8 control8_2)
		{
			this.control8_1 = control8_2;
		}

		// Token: 0x06007382 RID: 29570 RVA: 0x0004818D File Offset: 0x0004638D
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_5;
		}

		// Token: 0x06007383 RID: 29571 RVA: 0x00048195 File Offset: 0x00046395
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_6)
		{
			this.class116_5 = class116_6;
		}

		// Token: 0x06007384 RID: 29572 RVA: 0x003E54FC File Offset: 0x003E36FC
		private void AboutBox1_Load(object sender, EventArgs e)
		{
			this.vmethod_0().Text = GameGeneral.smethod_2();
			string str = "";
			if (Client.smethod_38())
			{
				str += "Running in Steam mode.\r\n";
			}
			str += "Licensed modules: \r\n";
			List<string> list = new List<string>();
			try
			{
				foreach (KeyValuePair<Class2556.Enum209, Class2556.Struct78> keyValuePair in Class2556.smethod_1())
				{
					if (Class2556.smethod_6(keyValuePair.Key))
					{
						list.Add(keyValuePair.Value.string_0);
					}
				}
			}
			finally
			{
				Dictionary<Class2556.Enum209, Class2556.Struct78>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.vmethod_16().Text = str + string.Join("\r\n", list);
			if (GameGeneral.smethod_3() == GameGeneral.Enum144.const_0)
			{
				this.vmethod_10().Text = "(c) WarfareSims Ltd. 2013-" + Conversions.ToString(DateTime.Now.Year);
			}
			else
			{
				this.vmethod_10().Text = "(c) WarfareSims Professional Services 2013-" + Conversions.ToString(DateTime.Now.Year);
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Geodesic model:\r\nCredits: T.Vincenty, \r\n'Direct and inverse solutions of geodesics of nested equations'. \r\nSurvey Review XXII, 176, April 1975. Pp.88-93.\r\nP.S.Zakatov. Kurs vysshei geodezii. 4th ed. M., 1976.\r\nU.S. Army Topographic Engineering Center, Geospatial Information Division 7701 Telegraph Road Alexandria, VA  22310-3864 - for TransMerc code\r\nGerald Evenden (proj code) and Frank Warmerdam (proj copyright holder)\r\nParts of code: (C) Dimitris V. Dranidis, 2009\r\nBrent minimization routine: AlgLib, (C) Bochkanov Sergey 09.04.2007\r\n\r\n");
			stringBuilder.Append("Weather model:\r\nThis module includes NOVAS 3.0f library from US Naval Observatory for astronomical calculations.\r\nBased on JPL ASCII ephemerides DE405 valid for 2000-2019 (will extend back to 1940s in the future)\r\nSources: ITU-R P.837 rainfall rate data\r\nDr. Tim Mitchell from UK Met.Office (Tyndall centre), CRU TS 2.1 (1901-2002 data)\r\nHansen's thermal anomaly data from http://data.giss.nasa.gov/gistemp/\r\n\r\n");
			stringBuilder.Append("Radar Model:\r\nRodney Spence and Glenn Feldhake of NASA (propagation code)\r\nProf. David C. Jenn of NPS (radjam code)\r\nMicrowaves101 - phased array plot\r\nRaafat Nasser (U.S. Dept of Commerce) - RCG-44\r\nW.L.Patterson, C.P.Hattan, G.E.Lindem, Richard A.Paulus,  H.V.Hitney, K.D.Anderson, Amalia E.Barrios  - EREPS V.3.0 user manual. Tech.Doc.2648. San Diego, May 1994.\r\nAmalia E. Barrios, W. L. Patterson. - Advanced Propagation Model  Ver.1.3.1 CSCI Documents Tech.Doc.3145. San Diego, August 2002.\r\nAREPS User Manual V.3.6. San Diego, December 2006.\r\nHerr Alfred Ochs (Peter-Behrens-Str. 14, D-6100 Darmstadt) - the neat rain attenuation model from  the COST 210 Hydrometeor Scatter Prediction Procedure\r\nSources: ITU-R F.1245-1; ITU-R M.1652, miscellaneous files from ITU-R\r\nH.T.Dougherty, E.J.Dutton, 1981 NTIA Report 81-69\r\nRadar Technology Encyclopedia, 1998. David K. Barton, Sergey A. Leonov (eds.) \r\nKuzmin, 1974\r\nF.B.Chernyi. Rasprostranenie radiovoln. 2nd ed. M., 1972\r\nA.I.Kupriyanov, A.V.Sakharov. Teoreticheskiye osnovy radioelektronnoy borby. M., 2007\r\nYu.P.Melnikov. Vozdushnaya radiotekhnicheskaya razvedka. M., 2005\r\nV.G.Radzievsky (ed.) Sovremennaya radioelectronnaya borba. M., 2006\r\nA.I.Kanaschenkov, V.I.Merkulov (eds.) Zaschita radiolokatsionnykh sistem ot pomekh. M., 2003\r\nMichale O. Kolawole (2002) Radar Systems, Peak Detection and Tracking. Oxford, UK. 388 p.\r\nRadar Handbook (2nd and 3rd eds.) Edited by Merrill I. Skolnik.\r\nElectronic Warfare and Radar Systems Engineering Handbook\r\nV.I.Borisov, V.M.Zinchuk, A.E.Limarev. Pomekhozaschischennost' sistem radiosvyazi s rasshireniyem spektra signalov metodom PPRCh. M., 2008.\r\n\r\n");
			stringBuilder.Append("Virtual Globe: (c)NASA WorldWind\r\n\r\n");
			stringBuilder.Append("\r\n");
			stringBuilder.Append("SRTM map layers & elevation data provided by NASA & based on Shuttle Radar Topography Mission.\r\n");
			stringBuilder.Append("Stamen Terrain & Stamen Roads & Cities map layers provided by Stamen Design & based on OpenStreetMap data.\r\n");
			stringBuilder.Append("Sentinel-2 map layer provided by EOX & based on ESA Copernicus Sentinel-2 missions.\r\n");
			stringBuilder.Append("Some of the sound effects included in Command have been acquired from http://www.freesfx.co.uk and are used under the site's terms of use.\r\n");
			stringBuilder.Append("Images & 3D models rights belong to respective IP holders unless property of WarfareSims LTD.\r\n");
			stringBuilder.Append("\r\n");
			stringBuilder.Append("Thanks to our families & friends who supported us.\r\n\r\n");
			this.vmethod_14().Text = stringBuilder.ToString();
		}

		// Token: 0x06007385 RID: 29573 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_3(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x000476BE File Offset: 0x000458BE
		private void AboutBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06007387 RID: 29575 RVA: 0x00044820 File Offset: 0x00042A20
		private void AboutBox1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x04004100 RID: 16640
		[CompilerGenerated]
		[AccessedThroughProperty("Label_version")]
		private Class116 class116_0;

		// Token: 0x04004101 RID: 16641
		[CompilerGenerated]
		[AccessedThroughProperty("OKButton")]
		private Control9 control9_0;

		// Token: 0x04004102 RID: 16642
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_1;

		// Token: 0x04004103 RID: 16643
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_2;

		// Token: 0x04004104 RID: 16644
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_3;

		// Token: 0x04004105 RID: 16645
		[AccessedThroughProperty("Label_Copyright")]
		[CompilerGenerated]
		private Class116 class116_4;

		// Token: 0x04004106 RID: 16646
		[CompilerGenerated]
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox pictureBox_0;

		// Token: 0x04004107 RID: 16647
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private Control8 control8_0;

		// Token: 0x04004108 RID: 16648
		[CompilerGenerated]
		[AccessedThroughProperty("TB_Licensing")]
		private Control8 control8_1;

		// Token: 0x04004109 RID: 16649
		[AccessedThroughProperty("Label_License")]
		[CompilerGenerated]
		private Class116 class116_5;
	}
}
