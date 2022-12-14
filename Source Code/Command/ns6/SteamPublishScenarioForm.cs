using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns2;
using ns3;
using ns4;
using ns5;
using ns7;

namespace ns6
{
	// Token: 0x02000E84 RID: 3716
	[DesignerGenerated]
	internal sealed partial class SteamPublishScenarioForm : DarkSecondaryFormBase
	{
		// Token: 0x0600728B RID: 29323 RVA: 0x003D7138 File Offset: 0x003D5338
		public SteamPublishScenarioForm()
		{
			base.Shown += this.SteamPublishScenarioForm_Shown;
			base.Load += this.SteamPublishScenarioForm_Load;
			this.string_0 = Path.Combine(Class2413.smethod_1().Info.DirectoryPath, "screenshot.png");
			this.string_1 = Path.Combine(Class2413.smethod_1().Info.DirectoryPath, "screenshot_thumb.png");
			this.InitializeComponent_1();
		}

		// Token: 0x0600728D RID: 29325 RVA: 0x003D71F4 File Offset: 0x003D53F4
		private void InitializeComponent_1()
		{
			this.vmethod_1(new PictureBox());
			this.vmethod_3(new Control9());
			this.vmethod_5(new Control9());
			this.vmethod_7(new Control9());
			this.vmethod_9(new Control8());
			this.vmethod_11(new Control8());
			this.vmethod_13(new Control8());
			this.vmethod_15(new Class116());
			this.vmethod_17(new Class116());
			this.vmethod_19(new OpenFileDialog());
			this.vmethod_21(new Control9());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_0().Location = new Point(422, 13);
			this.vmethod_0().Name = "PictureBox1";
			this.vmethod_0().Size = new Size(256, 256);
			this.vmethod_0().SizeMode = PictureBoxSizeMode.CenterImage;
			this.vmethod_0().TabIndex = 1;
			this.vmethod_0().TabStop = false;
			this.vmethod_2().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DialogResult = DialogResult.None;
			this.vmethod_2().Font = new Font("Segoe UI", 10f);
			this.vmethod_2().ForeColor = SystemColors.Control;
			this.vmethod_2().Location = new Point(423, 283);
			this.vmethod_2().Name = "Button1";
			this.vmethod_2().method_1(0);
			this.vmethod_2().Size = new Size(255, 23);
			this.vmethod_2().TabIndex = 2;
			this.vmethod_2().Text = "Select Preview Image";
			this.vmethod_4().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().Font = new Font("Segoe UI", 10f);
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(422, 313);
			this.vmethod_4().Name = "Button_MapScreenshot";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(256, 23);
			this.vmethod_4().TabIndex = 3;
			this.vmethod_4().Text = "Use Screenshot";
			this.vmethod_6().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.None;
			this.vmethod_6().Font = new Font("Segoe UI", 10f);
			this.vmethod_6().ForeColor = SystemColors.Control;
			this.vmethod_6().Location = new Point(422, 343);
			this.vmethod_6().Name = "Button3";
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(256, 23);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_6().Text = "Publish New Item";
			this.vmethod_8().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_8().method_14(null);
			this.vmethod_8().method_15(AutoCompleteMode.None);
			this.vmethod_8().method_13(AutoCompleteSource.None);
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().method_17(new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0));
			this.vmethod_8().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_8().method_12(null);
			this.vmethod_8().method_18(null);
			this.vmethod_8().Location = new Point(104, 13);
			this.vmethod_8().method_2(32767);
			this.vmethod_8().method_7(false);
			this.vmethod_8().Name = "TextBox1";
			this.vmethod_8().method_3(false);
			this.vmethod_8().method_19(ScrollBars.None);
			this.vmethod_8().method_9(0);
			this.vmethod_8().Size = new Size(312, 24);
			this.vmethod_8().TabIndex = 5;
			this.vmethod_8().method_1(HorizontalAlignment.Center);
			this.vmethod_8().method_5(false);
			this.vmethod_8().method_10("");
			this.vmethod_10().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_10().method_14(null);
			this.vmethod_10().method_15(AutoCompleteMode.None);
			this.vmethod_10().method_13(AutoCompleteSource.None);
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().method_17(new Font("Segoe UI", 8f));
			this.vmethod_10().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_10().method_12(null);
			this.vmethod_10().method_18(null);
			this.vmethod_10().Location = new Point(12, 67);
			this.vmethod_10().method_2(32767);
			this.vmethod_10().method_7(true);
			this.vmethod_10().Name = "TextBox2";
			this.vmethod_10().method_3(false);
			this.vmethod_10().method_19(ScrollBars.None);
			this.vmethod_10().method_9(0);
			this.vmethod_10().Size = new Size(404, 380);
			this.vmethod_10().TabIndex = 6;
			this.vmethod_10().method_1(HorizontalAlignment.Left);
			this.vmethod_10().method_5(false);
			this.vmethod_10().method_10("");
			this.vmethod_12().method_14(null);
			this.vmethod_12().method_15(AutoCompleteMode.None);
			this.vmethod_12().method_13(AutoCompleteSource.None);
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().method_17(new Font("Segoe UI", 8f));
			this.vmethod_12().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_12().method_12(null);
			this.vmethod_12().method_18(null);
			this.vmethod_12().Location = new Point(104, 41);
			this.vmethod_12().method_2(32767);
			this.vmethod_12().method_7(false);
			this.vmethod_12().Name = "TextBox3";
			this.vmethod_12().method_3(false);
			this.vmethod_12().method_19(ScrollBars.None);
			this.vmethod_12().method_9(0);
			this.vmethod_12().Size = new Size(312, 20);
			this.vmethod_12().TabIndex = 7;
			this.vmethod_12().method_1(HorizontalAlignment.Left);
			this.vmethod_12().method_5(false);
			this.vmethod_12().method_10("");
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(12, 20);
			this.vmethod_14().Name = "Label1";
			this.vmethod_14().Size = new Size(86, 17);
			this.vmethod_14().TabIndex = 8;
			this.vmethod_14().Text = "Scenario Title:";
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Location = new Point(12, 44);
			this.vmethod_16().Name = "Label2";
			this.vmethod_16().Size = new Size(72, 17);
			this.vmethod_16().TabIndex = 9;
			this.vmethod_16().Text = "Filename:";
			this.vmethod_20().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_20().BackColor = Color.Transparent;
			this.vmethod_20().DialogResult = DialogResult.None;
			this.vmethod_20().Font = new Font("Segoe UI", 10f);
			this.vmethod_20().ForeColor = SystemColors.Control;
			this.vmethod_20().Location = new Point(423, 373);
			this.vmethod_20().Name = "Button2";
			this.vmethod_20().method_1(0);
			this.vmethod_20().Size = new Size(255, 23);
			this.vmethod_20().TabIndex = 10;
			this.vmethod_20().Text = "Update Existing Workshop Item";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(684, 455);
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SteamPublishScenarioForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "Steam Workshop Publishing";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0600728E RID: 29326 RVA: 0x00047B48 File Offset: 0x00045D48
		[CompilerGenerated]
		internal PictureBox vmethod_0()
		{
			return this.pictureBox_0;
		}

		// Token: 0x0600728F RID: 29327 RVA: 0x00047B50 File Offset: 0x00045D50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(PictureBox pictureBox_1)
		{
			this.pictureBox_0 = pictureBox_1;
		}

		// Token: 0x06007290 RID: 29328 RVA: 0x00047B59 File Offset: 0x00045D59
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_0;
		}

		// Token: 0x06007291 RID: 29329 RVA: 0x003D7BA8 File Offset: 0x003D5DA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_3);
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

		// Token: 0x06007292 RID: 29330 RVA: 0x00047B61 File Offset: 0x00045D61
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_1;
		}

		// Token: 0x06007293 RID: 29331 RVA: 0x003D7BEC File Offset: 0x003D5DEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_6);
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

		// Token: 0x06007294 RID: 29332 RVA: 0x00047B69 File Offset: 0x00045D69
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_2;
		}

		// Token: 0x06007295 RID: 29333 RVA: 0x003D7C30 File Offset: 0x003D5E30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_4);
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

		// Token: 0x06007296 RID: 29334 RVA: 0x00047B71 File Offset: 0x00045D71
		[CompilerGenerated]
		internal Control8 vmethod_8()
		{
			return this.control8_0;
		}

		// Token: 0x06007297 RID: 29335 RVA: 0x00047B79 File Offset: 0x00045D79
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control8 control8_3)
		{
			this.control8_0 = control8_3;
		}

		// Token: 0x06007298 RID: 29336 RVA: 0x00047B82 File Offset: 0x00045D82
		[CompilerGenerated]
		internal Control8 vmethod_10()
		{
			return this.control8_1;
		}

		// Token: 0x06007299 RID: 29337 RVA: 0x00047B8A File Offset: 0x00045D8A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control8 control8_3)
		{
			this.control8_1 = control8_3;
		}

		// Token: 0x0600729A RID: 29338 RVA: 0x00047B93 File Offset: 0x00045D93
		[CompilerGenerated]
		internal Control8 vmethod_12()
		{
			return this.control8_2;
		}

		// Token: 0x0600729B RID: 29339 RVA: 0x00047B9B File Offset: 0x00045D9B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control8 control8_3)
		{
			this.control8_2 = control8_3;
		}

		// Token: 0x0600729C RID: 29340 RVA: 0x00047BA4 File Offset: 0x00045DA4
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_0;
		}

		// Token: 0x0600729D RID: 29341 RVA: 0x00047BAC File Offset: 0x00045DAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_2)
		{
			this.class116_0 = class116_2;
		}

		// Token: 0x0600729E RID: 29342 RVA: 0x00047BB5 File Offset: 0x00045DB5
		[CompilerGenerated]
		internal Class116 vmethod_16()
		{
			return this.class116_1;
		}

		// Token: 0x0600729F RID: 29343 RVA: 0x00047BBD File Offset: 0x00045DBD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class116 class116_2)
		{
			this.class116_1 = class116_2;
		}

		// Token: 0x060072A0 RID: 29344 RVA: 0x00047BC6 File Offset: 0x00045DC6
		[CompilerGenerated]
		internal OpenFileDialog vmethod_18()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x060072A1 RID: 29345 RVA: 0x00047BCE File Offset: 0x00045DCE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x060072A2 RID: 29346 RVA: 0x00047BD7 File Offset: 0x00045DD7
		[CompilerGenerated]
		internal Control9 vmethod_20()
		{
			return this.control9_3;
		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x003D7C74 File Offset: 0x003D5E74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_8);
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

		// Token: 0x060072A4 RID: 29348 RVA: 0x003D7CB8 File Offset: 0x003D5EB8
		private void method_3(object sender, EventArgs e)
		{
			this.vmethod_18().Filter = "";
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			string text = string.Empty;
			foreach (ImageCodecInfo imageCodecInfo in imageEncoders)
			{
				string text2 = imageCodecInfo.CodecName.Substring(8).Replace("Codec", "Files").Trim();
				this.vmethod_18().Filter = string.Format("{0}{1}{2} ({3})|{3}", new object[]
				{
					this.vmethod_18().Filter,
					text,
					text2,
					imageCodecInfo.FilenameExtension
				});
				text = "|";
			}
			this.vmethod_18().Filter = string.Format("{0}{1}{2} ({3})|{3}", new object[]
			{
				this.vmethod_18().Filter,
				text,
				"All Files",
				"*.*"
			});
			this.vmethod_18().FilterIndex = 1;
			if (this.vmethod_18().ShowDialog() == DialogResult.OK)
			{
				if (File.Exists(this.string_0))
				{
					File.Delete(this.string_0);
				}
				File.Copy(this.vmethod_18().FileName, this.string_0);
				Image image = Image.FromFile(this.vmethod_18().FileName);
				this.method_7(image, image.RawFormat);
			}
		}

		// Token: 0x060072A5 RID: 29349 RVA: 0x003D7DFC File Offset: 0x003D5FFC
		private void method_4(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.vmethod_8().Text))
			{
				DarkMessageBox.smethod_2("Please provide a scenario title!", "No title", Enum11.const_0);
				return;
			}
			if (string.IsNullOrEmpty(this.vmethod_10().Text))
			{
				DarkMessageBox.smethod_2("Please provide a scenario description!", "No description", Enum11.const_0);
				return;
			}
			if (!string.IsNullOrEmpty(this.vmethod_12().Text) && Operators.CompareString(this.vmethod_12().Text, "Input Scenario Filename Here", false) != 0)
			{
				Class2486.Class2488 @class = new Class2486.Class2488();
				@class.string_0 = this.vmethod_8().Text;
				@class.string_1 = this.vmethod_10().Text;
				@class.string_3 = this.string_1;
				@class.string_2 = this.vmethod_12().Text.Replace("/", "").Replace("\\", "").Replace(":", "");
				Class2413.smethod_2().method_41().vmethod_790().Interval = 1000;
				Class2486.smethod_1(@class);
				base.Close();
				return;
			}
			DarkMessageBox.smethod_2("Please provide a scenario filename!", "No filename", Enum11.const_0);
		}

		// Token: 0x060072A6 RID: 29350 RVA: 0x003D7F28 File Offset: 0x003D6128
		private void SteamPublishScenarioForm_Shown(object sender, EventArgs e)
		{
			this.vmethod_8().Text = Client.smethod_46().method_0();
			if (!string.IsNullOrEmpty(Client.smethod_46().method_4()))
			{
				this.vmethod_10().Text = Class441.smethod_1(Client.smethod_46().method_4());
			}
			if (!string.IsNullOrEmpty(Client.string_3))
			{
				this.vmethod_12().Text = Path.GetFileNameWithoutExtension(Client.string_3);
			}
			else
			{
				this.vmethod_12().Text = "Input Scenario Filename Here";
			}
			string text = Path.ChangeExtension(Client.string_3, "jpg");
			if (!Information.IsNothing(Client.string_3) && File.Exists(text))
			{
				Image image = Image.FromFile(text);
				this.method_7(image, image.RawFormat);
				return;
			}
			this.method_5();
		}

		// Token: 0x060072A7 RID: 29351 RVA: 0x003D7FE8 File Offset: 0x003D61E8
		private void method_5()
		{
			try
			{
				if (File.Exists(this.string_0))
				{
					File.Delete(this.string_0);
				}
				Bitmap bitmap = new Bitmap(Class2413.smethod_2().method_41().vmethod_796().Width, Class2413.smethod_2().method_41().vmethod_796().Height);
				Graphics.FromImage(bitmap).CopyFromScreen(Class2413.smethod_2().method_41().vmethod_796().PointToScreen(default(Point)).X, Class2413.smethod_2().method_41().vmethod_796().PointToScreen(default(Point)).Y, 0, 0, bitmap.Size);
				bitmap.Save(this.string_0, ImageFormat.Png);
				this.method_7(bitmap, ImageFormat.Png);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200407", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060072A8 RID: 29352 RVA: 0x00047BDF File Offset: 0x00045DDF
		private void method_6(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x060072A9 RID: 29353 RVA: 0x003D8100 File Offset: 0x003D6300
		private void method_7(Image image_0, ImageFormat imageFormat_0)
		{
			Image image = Class2558.smethod_4((Bitmap)image_0, new Size(637, 358), true);
			image.Save(this.string_1, imageFormat_0);
			this.vmethod_0().Image = Class2558.smethod_4((Bitmap)image, new Size(256, 256), true);
		}

		// Token: 0x060072AA RID: 29354 RVA: 0x003D815C File Offset: 0x003D635C
		private void method_8(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.vmethod_8().Text))
			{
				DarkMessageBox.smethod_2("Please provide a scenario title!", "Error", Enum11.const_0);
				return;
			}
			if (string.IsNullOrEmpty(this.vmethod_10().Text))
			{
				DarkMessageBox.smethod_2("Please provide a scenario description!", "Error", Enum11.const_0);
				return;
			}
			if (!string.IsNullOrEmpty(this.vmethod_12().Text) && Operators.CompareString(this.vmethod_12().Text, "Input Scenario Filename Here", false) != 0)
			{
				Class2486.Class2488 @class = new Class2486.Class2488();
				@class.string_0 = this.vmethod_8().Text;
				@class.string_1 = this.vmethod_10().Text;
				@class.string_3 = this.string_1;
				@class.string_2 = this.vmethod_12().Text.Replace("/", "").Replace("\\", "").Replace(":", "");
				Class2413.smethod_2().method_41().vmethod_790().Interval = 1000;
				SteamUpdateScenarioForm.class2488_0 = @class;
				Class2413.smethod_2().method_69().Show();
				base.Close();
				return;
			}
			DarkMessageBox.smethod_2("Please provide a scenario filename!", "Error", Enum11.const_0);
		}

		// Token: 0x060072AB RID: 29355 RVA: 0x00044489 File Offset: 0x00042689
		private void SteamPublishScenarioForm_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04004089 RID: 16521
		[AccessedThroughProperty("PictureBox1")]
		[CompilerGenerated]
		private PictureBox pictureBox_0;

		// Token: 0x0400408A RID: 16522
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x0400408B RID: 16523
		[AccessedThroughProperty("Button_MapScreenshot")]
		[CompilerGenerated]
		private Control9 control9_1;

		// Token: 0x0400408C RID: 16524
		[AccessedThroughProperty("Button3")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x0400408D RID: 16525
		[AccessedThroughProperty("TextBox1")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x0400408E RID: 16526
		[AccessedThroughProperty("TextBox2")]
		[CompilerGenerated]
		private Control8 control8_1;

		// Token: 0x0400408F RID: 16527
		[AccessedThroughProperty("TextBox3")]
		[CompilerGenerated]
		private Control8 control8_2;

		// Token: 0x04004090 RID: 16528
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04004091 RID: 16529
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x04004092 RID: 16530
		[CompilerGenerated]
		[AccessedThroughProperty("OFD_CustomImage")]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x04004093 RID: 16531
		[AccessedThroughProperty("Button2")]
		[CompilerGenerated]
		private Control9 control9_3;

		// Token: 0x04004094 RID: 16532
		private string string_0;

		// Token: 0x04004095 RID: 16533
		private string string_1;
	}
}
