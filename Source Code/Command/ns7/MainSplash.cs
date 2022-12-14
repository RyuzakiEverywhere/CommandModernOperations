using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns5;

namespace ns7
{
	// Token: 0x02000F3C RID: 3900
	[DesignerGenerated]
	internal sealed partial class MainSplash : Form
	{
		// Token: 0x06008BD0 RID: 35792 RVA: 0x000537C7 File Offset: 0x000519C7
		public MainSplash()
		{
			base.Shown += this.MainSplash_Shown;
			this.InitializeComponent();
		}

		// Token: 0x06008BD3 RID: 35795 RVA: 0x000537E7 File Offset: 0x000519E7
		[CompilerGenerated]
		internal PictureBox vmethod_0()
		{
			return this.pictureBox_0;
		}

		// Token: 0x06008BD4 RID: 35796 RVA: 0x000537EF File Offset: 0x000519EF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(PictureBox pictureBox_1)
		{
			this.pictureBox_0 = pictureBox_1;
		}

		// Token: 0x06008BD5 RID: 35797 RVA: 0x000537F8 File Offset: 0x000519F8
		[CompilerGenerated]
		internal Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x06008BD6 RID: 35798 RVA: 0x00053800 File Offset: 0x00051A00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06008BD7 RID: 35799 RVA: 0x004B51B8 File Offset: 0x004B33B8
		private void MainSplash_Shown(object sender, EventArgs e)
		{
			base.Visible = false;
			if (Client.float_1 == 0f)
			{
				int num = Conversions.ToInteger(Class2413.smethod_0().Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LogPixels", null));
				if (num > 0)
				{
					Client.float_1 = (float)((double)num / 96.0);
				}
				if (Class570.class280_0.method_50())
				{
					string text = "DPI registry setting, HKEY_CURRENT_USER\\Control Panel\\Desktop\\LogPixels:" + Conversions.ToString(num) + ".";
					GameGeneral.smethod_26(ref text);
				}
				if (Client.float_1 == 0f)
				{
					num = Conversions.ToInteger(Class2413.smethod_0().Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\FontDPI", "LogPixels", null));
					if (num > 0)
					{
						Client.float_1 = (float)((double)num / 96.0);
					}
					if (Class570.class280_0.method_50())
					{
						string text = "DPI registry setting, HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\FontDPI\\LogPixels:" + Conversions.ToString(num) + ".";
						GameGeneral.smethod_26(ref text);
					}
				}
				if (Client.float_1 == 0f)
				{
					num = Conversions.ToInteger(Class2413.smethod_0().Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows NT\\CurrentVersion\\FontDPI", "LogPixels", null));
					if (num > 0)
					{
						Client.float_1 = (float)((double)num / 96.0);
					}
					if (Class570.class280_0.method_50())
					{
						string text = "DPI registry setting, HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows NT\\CurrentVersion\\FontDPI\\LogPixels:" + Conversions.ToString(num) + ".";
						GameGeneral.smethod_26(ref text);
					}
				}
				using (Graphics graphics = base.CreateGraphics())
				{
					Client.float_1 = graphics.DpiX / 96f;
				}
				if (Class570.class280_0.method_50())
				{
					string text = "DPI scale: " + Conversions.ToString(Client.float_1) + ".";
					GameGeneral.smethod_26(ref text);
				}
			}
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (Class570.class280_0.method_50())
			{
				string text = "Showing splash screen.";
				GameGeneral.smethod_26(ref text);
			}
			Application.DoEvents();
			if (Client.float_1 > 1f)
			{
				this.method_0();
			}
			this.vmethod_2().Visible = false;
			if (GameGeneral.smethod_7())
			{
				this.vmethod_0().Image = Image.FromFile(Path.Combine(Class2413.smethod_1().Info.DirectoryPath, "Symbols\\splash_academic.jpg"));
			}
			else if (GameGeneral.smethod_8())
			{
				this.vmethod_0().Image = Image.FromFile(Path.Combine(Class2413.smethod_1().Info.DirectoryPath, "Symbols\\splash_student.jpg"));
			}
			else if (GameGeneral.smethod_9())
			{
				this.vmethod_0().Image = Image.FromFile(Path.Combine(Class2413.smethod_1().Info.DirectoryPath, "Symbols\\splash_MilGov.jpg"));
			}
			else if (!GameGeneral.smethod_6() && !Class2556.smethod_6(Class2556.Enum209.const_0))
			{
				if (Class2556.smethod_6(Class2556.Enum209.const_16))
				{
					this.vmethod_0().Image = Image.FromFile(Path.Combine(Class2413.smethod_1().Info.DirectoryPath, "Symbols\\splash_DS.jpg"));
				}
				else if (Class2556.smethod_6(Class2556.Enum209.const_12))
				{
					this.vmethod_0().Image = Image.FromFile(Path.Combine(Class2413.smethod_1().Info.DirectoryPath, "Symbols\\splash_TSS.jpg"));
				}
				else if (Class2556.smethod_6(Class2556.Enum209.const_10))
				{
					this.vmethod_0().Image = Image.FromFile(Path.Combine(Class2413.smethod_1().Info.DirectoryPath, "Symbols\\splash_SS.jpg"));
				}
				else if (Class2556.smethod_6(Class2556.Enum209.const_7))
				{
					this.vmethod_0().Image = Image.FromFile(Path.Combine(Class2413.smethod_1().Info.DirectoryPath, "Symbols\\splash_COW.jpg"));
				}
				else if (Class2556.smethod_6(Class2556.Enum209.const_1))
				{
					this.vmethod_0().Image = Image.FromFile(Path.Combine(Class2413.smethod_1().Info.DirectoryPath, "Symbols\\splash_NI.jpg"));
				}
			}
			else
			{
				this.vmethod_0().Image = Image.FromFile(Path.Combine(Class2413.smethod_1().Info.DirectoryPath, "Symbols\\splash.jpg"));
			}
			Class2558.bitmap_0 = (Bitmap)this.vmethod_0().Image;
			Client.smethod_34();
			Application.DoEvents();
			Client.smethod_62(Client.Enum197.const_0);
			if (Class570.class280_0.method_50())
			{
				string text = "Wait for terrain to load.";
				GameGeneral.smethod_26(ref text);
			}
			while (!Terrain.bool_0)
			{
				Thread.Sleep(100);
			}
			if (Class570.class280_0.method_50())
			{
				string text = "Terrain loaded.";
				GameGeneral.smethod_26(ref text);
			}
			Application.DoEvents();
		}

		// Token: 0x06008BD8 RID: 35800 RVA: 0x004B5614 File Offset: 0x004B3814
		public void method_0()
		{
			string text = Path.Combine(Class2413.smethod_1().Info.DirectoryPath, Process.GetCurrentProcess().ProcessName + ".exe");
			string text2 = Conversions.ToString(Class2413.smethod_0().Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers", text, string.Empty));
			if (!text2.Contains("~ DPIUNAWARE"))
			{
				bool flag = false;
				try
				{
					Class2413.smethod_0().Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers", text, text2 + " ~ DPIUNAWARE");
					text2 = Conversions.ToString(Class2413.smethod_0().Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers", text, string.Empty));
					flag = text2.Contains("~ DPIUNAWARE");
				}
				catch (Exception ex)
				{
					flag = false;
				}
				if (flag)
				{
					string path = Path.Combine(GameGeneral.string_5, "instance");
					if (Directory.Exists(path))
					{
						Directory.Delete(path, true);
					}
					ProcessStartInfo processStartInfo = new ProcessStartInfo(text);
					processStartInfo.CreateNoWindow = false;
					processStartInfo.UseShellExecute = false;
					new Process
					{
						StartInfo = processStartInfo
					}.Start();
					Environment.Exit(0);
					return;
				}
				MessageBox.Show("CAUTION! Your system appears to be using a high-DPI desktop setting (e.g. an ultra-high resolution monitor). This program needs an extra configuration step in order to run without issues in such a setting.\r\n\r\nClick on the 'Help' button to navigate to our dedicated instructions for this.\r\n\r\nWe apologize for the inconvenience!", "High-DPI settings detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0, "http://www.matrixgames.com/forums/tm.asp?m=4190908", "keyword");
			}
		}

		// Token: 0x04004BD4 RID: 19412
		[AccessedThroughProperty("PictureBox1")]
		[CompilerGenerated]
		private PictureBox pictureBox_0;

		// Token: 0x04004BD5 RID: 19413
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Label label_0;
	}
}
