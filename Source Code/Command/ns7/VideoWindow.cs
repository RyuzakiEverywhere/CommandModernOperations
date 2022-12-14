using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.DirectX.AudioVideoPlayback;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;

namespace ns7
{
	// Token: 0x02000F37 RID: 3895
	[DesignerGenerated]
	internal sealed partial class VideoWindow : Form
	{
		// Token: 0x06008BAD RID: 35757 RVA: 0x004B3B58 File Offset: 0x004B1D58
		public VideoWindow()
		{
			base.KeyDown += this.VideoWindow_KeyDown;
			base.VisibleChanged += this.VideoWindow_VisibleChanged;
			base.Load += this.VideoWindow_Load;
			this.InitializeComponent();
		}

		// Token: 0x06008BB0 RID: 35760 RVA: 0x00053724 File Offset: 0x00051924
		[CompilerGenerated]
		private Video vmethod_0()
		{
			return this.video_0;
		}

		// Token: 0x06008BB1 RID: 35761 RVA: 0x004B3C70 File Offset: 0x004B1E70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_1(Video video_1)
		{
			EventHandler eh = new EventHandler(this.method_0);
			EventHandler eh2 = new EventHandler(this.method_2);
			Video video = this.video_0;
			if (video != null)
			{
				video.Ending -= eh;
				video.Stopping -= eh2;
			}
			this.video_0 = video_1;
			video = this.video_0;
			if (video != null)
			{
				video.Ending += eh;
				video.Stopping += eh2;
			}
		}

		// Token: 0x06008BB2 RID: 35762 RVA: 0x0005372C File Offset: 0x0005192C
		private void method_0(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x06008BB3 RID: 35763 RVA: 0x004B3CD0 File Offset: 0x004B1ED0
		public void method_1()
		{
			if (!Information.IsNothing(Class2561.class2559_0.vmethod_0()))
			{
				Class2561.class2559_0.vmethod_0().Volume = this.double_0;
			}
			Cursor.Show();
			if (this.bool_1)
			{
				Client.smethod_0().method_3();
			}
			this.bool_0 = false;
			base.DialogResult = DialogResult.OK;
			base.Hide();
		}

		// Token: 0x06008BB4 RID: 35764 RVA: 0x00053734 File Offset: 0x00051934
		private void VideoWindow_KeyDown(object sender, KeyEventArgs e)
		{
			this.vmethod_0().Stop();
		}

		// Token: 0x06008BB5 RID: 35765 RVA: 0x004B3D30 File Offset: 0x004B1F30
		private void VideoWindow_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				string item = this.tuple_0.Item1;
				bool item2 = this.tuple_0.Item2;
				int item3 = this.tuple_0.Item3;
				this.bool_0 = true;
				try
				{
					if (item3 > 0)
					{
						base.Opacity = 0.0;
						Thread.Sleep(item3 * 1000);
						base.Opacity = 1.0;
					}
					this.vmethod_1(new Video(item));
					this.vmethod_0().Owner = this;
					this.bool_1 = (Client.smethod_0().method_0() == Class279.Enum68.const_1);
					if (this.bool_1)
					{
						Client.smethod_0().method_4();
					}
					if (item2)
					{
						base.WindowState = FormWindowState.Maximized;
						Cursor.Hide();
					}
					else
					{
						base.StartPosition = FormStartPosition.CenterScreen;
					}
					if (!Information.IsNothing(Class2561.class2559_0.vmethod_0()))
					{
						this.double_0 = Class2561.class2559_0.vmethod_0().Volume;
						Class2561.class2559_0.vmethod_0().Volume = 0.0;
					}
					this.vmethod_0().Play();
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200415", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					this.bool_0 = false;
					base.Hide();
				}
			}
		}

		// Token: 0x06008BB6 RID: 35766 RVA: 0x0005372C File Offset: 0x0005192C
		private void method_2(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x06008BB7 RID: 35767 RVA: 0x00044489 File Offset: 0x00042689
		private void VideoWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04004BAF RID: 19375
		public Tuple<string, bool, int> tuple_0;

		// Token: 0x04004BB0 RID: 19376
		public bool bool_0;

		// Token: 0x04004BB1 RID: 19377
		[CompilerGenerated]
		[AccessedThroughProperty("ourVideo")]
		private Video video_0;

		// Token: 0x04004BB2 RID: 19378
		private double double_0;

		// Token: 0x04004BB3 RID: 19379
		private bool bool_1;
	}
}
