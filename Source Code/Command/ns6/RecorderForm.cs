using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns2;
using ns3;
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000ECD RID: 3789
	[DesignerGenerated]
	internal sealed partial class RecorderForm : DarkSecondaryFormBase
	{
		// Token: 0x0600836B RID: 33643 RVA: 0x0046B2EC File Offset: 0x004694EC
		public RecorderForm()
		{
			base.Load += this.RecorderForm_Load;
			base.KeyDown += this.RecorderForm_KeyDown;
			base.FormClosing += this.RecorderForm_FormClosing;
			base.Closing += new CancelEventHandler(this.RecorderForm_Closing);
			this.InitializeComponent_1();
		}

		// Token: 0x0600836D RID: 33645 RVA: 0x0046B390 File Offset: 0x00469590
		private void InitializeComponent_1()
		{
			this.icontainer_1 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(RecorderForm));
			this.vmethod_1(new TrackBar());
			this.vmethod_3(new Class125());
			this.vmethod_5(new ToolStripButton());
			this.vmethod_19(new ToolStripButton());
			this.vmethod_7(new ToolStripSeparator());
			this.vmethod_9(new ToolStripButton());
			this.vmethod_11(new ToolStripButton());
			this.vmethod_13(new ToolStripButton());
			this.vmethod_15(new ToolStripButton());
			this.vmethod_17(new ToolStripButton());
			this.vmethod_21(new OpenFileDialog());
			this.vmethod_23(new Timer(this.icontainer_1));
			this.vmethod_25(new Timer(this.icontainer_1));
			this.vmethod_27(new Class125());
			this.vmethod_29(new ToolStripLabel());
			this.vmethod_31(new ToolStripLabel());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			this.vmethod_2().SuspendLayout();
			this.vmethod_26().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().Location = new Point(0, 28);
			this.vmethod_0().Name = "TB_Snapshots";
			this.vmethod_0().Size = new Size(464, 45);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().AutoSize = false;
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_2().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_4(),
				this.vmethod_18(),
				this.vmethod_6(),
				this.vmethod_8(),
				this.vmethod_10(),
				this.vmethod_12(),
				this.vmethod_14(),
				this.vmethod_16()
			});
			this.vmethod_2().Location = new Point(0, 0);
			this.vmethod_2().Name = "ToolStrip1";
			this.vmethod_2().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_2().Size = new Size(464, 25);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "ToolStrip1";
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Image = (Image)componentResourceManager.GetObject("TSB_LoadRecording.Image");
			this.vmethod_4().ImageTransparentColor = Color.Magenta;
			this.vmethod_4().Name = "TSB_LoadRecording";
			this.vmethod_4().Size = new Size(53, 22);
			this.vmethod_4().Text = "Load";
			this.vmethod_18().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Image = (Image)componentResourceManager.GetObject("TSB_LoadMostRecent.Image");
			this.vmethod_18().ImageTransparentColor = Color.Magenta;
			this.vmethod_18().Name = "TSB_LoadMostRecent";
			this.vmethod_18().Size = new Size(119, 22);
			this.vmethod_18().Text = "Load most recent";
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Margin = new Padding(0, 0, 2, 0);
			this.vmethod_6().Name = "ToolStripSeparator1";
			this.vmethod_6().Size = new Size(6, 25);
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Image = (Image)componentResourceManager.GetObject("TSB_GoToStart.Image");
			this.vmethod_8().ImageTransparentColor = Color.Magenta;
			this.vmethod_8().Name = "TSB_GoToStart";
			this.vmethod_8().Size = new Size(23, 22);
			this.vmethod_8().Text = "TSB_GoToStart";
			this.vmethod_8().ToolTipText = "Jump to start of recording";
			this.vmethod_10().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Image = (Image)componentResourceManager.GetObject("TSB_StepBack.Image");
			this.vmethod_10().ImageTransparentColor = Color.Magenta;
			this.vmethod_10().Name = "TSB_StepBack";
			this.vmethod_10().Size = new Size(23, 22);
			this.vmethod_10().Text = "TSB_Reverse";
			this.vmethod_10().ToolTipText = "Step Back";
			this.vmethod_12().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_12().CheckOnClick = true;
			this.vmethod_12().DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Image = (Image)componentResourceManager.GetObject("TSB_Play.Image");
			this.vmethod_12().ImageTransparentColor = Color.Magenta;
			this.vmethod_12().Name = "TSB_Play";
			this.vmethod_12().Size = new Size(23, 22);
			this.vmethod_12().Text = "Play/Pause";
			this.vmethod_12().ToolTipText = "Pause";
			this.vmethod_14().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_14().DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Image = (Image)componentResourceManager.GetObject("TSB_StepForward.Image");
			this.vmethod_14().ImageTransparentColor = Color.Magenta;
			this.vmethod_14().Name = "TSB_StepForward";
			this.vmethod_14().Size = new Size(23, 22);
			this.vmethod_14().Text = "TSB_Play";
			this.vmethod_14().ToolTipText = "Step Forward";
			this.vmethod_16().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_16().DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Image = (Image)componentResourceManager.GetObject("TSB_GoToEnd.Image");
			this.vmethod_16().ImageTransparentColor = Color.Magenta;
			this.vmethod_16().Name = "TSB_GoToEnd";
			this.vmethod_16().Size = new Size(23, 22);
			this.vmethod_16().Text = "TSB_GoToEnd";
			this.vmethod_16().ToolTipText = "Jump to end of recording";
			this.vmethod_20().FileName = "OpenFileDialog1";
			this.vmethod_22().Interval = 500;
			this.vmethod_24().Interval = 50;
			this.vmethod_26().AutoSize = false;
			this.vmethod_26().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_26().Dock = DockStyle.Bottom;
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_26().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_28(),
				this.vmethod_30()
			});
			this.vmethod_26().Location = new Point(0, 57);
			this.vmethod_26().Name = "DarkToolStrip1";
			this.vmethod_26().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_26().Size = new Size(464, 28);
			this.vmethod_26().TabIndex = 2;
			this.vmethod_26().Text = "DarkToolStrip1";
			this.vmethod_28().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_28().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_28().Name = "TSL1";
			this.vmethod_28().Size = new Size(32, 25);
			this.vmethod_28().Text = "TSL1";
			this.vmethod_30().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Image = (Image)componentResourceManager.GetObject("TSSL_BadFrame.Image");
			this.vmethod_30().Name = "TSSL_BadFrame";
			this.vmethod_30().Size = new Size(106, 25);
			this.vmethod_30().Text = "TSSL_BadFrame";
			this.vmethod_30().Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(464, 85);
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			this.DoubleBuffered = true;
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RecorderForm";
			base.ShowIcon = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Replay Viewer";
			base.TopMost = true;
			((ISupportInitialize)this.vmethod_0()).EndInit();
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			this.vmethod_26().ResumeLayout(false);
			this.vmethod_26().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600836E RID: 33646 RVA: 0x0004FC3B File Offset: 0x0004DE3B
		[CompilerGenerated]
		internal TrackBar vmethod_0()
		{
			return this.trackBar_0;
		}

		// Token: 0x0600836F RID: 33647 RVA: 0x0046BE20 File Offset: 0x0046A020
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TrackBar trackBar_1)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_11);
			MouseEventHandler value2 = new MouseEventHandler(this.method_16);
			TrackBar trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.MouseMove -= value;
				trackBar.MouseUp -= value2;
			}
			this.trackBar_0 = trackBar_1;
			trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.MouseMove += value;
				trackBar.MouseUp += value2;
			}
		}

		// Token: 0x06008370 RID: 33648 RVA: 0x0004FC43 File Offset: 0x0004DE43
		[CompilerGenerated]
		internal Class125 vmethod_2()
		{
			return this.class125_0;
		}

		// Token: 0x06008371 RID: 33649 RVA: 0x0004FC4B File Offset: 0x0004DE4B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class125 class125_2)
		{
			this.class125_0 = class125_2;
		}

		// Token: 0x06008372 RID: 33650 RVA: 0x0004FC54 File Offset: 0x0004DE54
		[CompilerGenerated]
		internal ToolStripButton vmethod_4()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06008373 RID: 33651 RVA: 0x0046BE80 File Offset: 0x0046A080
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripButton toolStripButton_7)
		{
			EventHandler value = new EventHandler(this.method_5);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_7;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008374 RID: 33652 RVA: 0x0004FC5C File Offset: 0x0004DE5C
		[CompilerGenerated]
		internal ToolStripSeparator vmethod_6()
		{
			return this.toolStripSeparator_0;
		}

		// Token: 0x06008375 RID: 33653 RVA: 0x0004FC64 File Offset: 0x0004DE64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripSeparator toolStripSeparator_1)
		{
			this.toolStripSeparator_0 = toolStripSeparator_1;
		}

		// Token: 0x06008376 RID: 33654 RVA: 0x0004FC6D File Offset: 0x0004DE6D
		[CompilerGenerated]
		internal ToolStripButton vmethod_8()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x06008377 RID: 33655 RVA: 0x0046BEC4 File Offset: 0x0046A0C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripButton toolStripButton_7)
		{
			EventHandler value = new EventHandler(this.method_9);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_7;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008378 RID: 33656 RVA: 0x0004FC75 File Offset: 0x0004DE75
		[CompilerGenerated]
		internal ToolStripButton vmethod_10()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x06008379 RID: 33657 RVA: 0x0046BF08 File Offset: 0x0046A108
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ToolStripButton toolStripButton_7)
		{
			EventHandler value = new EventHandler(this.method_12);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_7;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600837A RID: 33658 RVA: 0x0004FC7D File Offset: 0x0004DE7D
		[CompilerGenerated]
		internal ToolStripButton vmethod_12()
		{
			return this.toolStripButton_3;
		}

		// Token: 0x0600837B RID: 33659 RVA: 0x0046BF4C File Offset: 0x0046A14C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(ToolStripButton toolStripButton_7)
		{
			EventHandler value = new EventHandler(this.method_8);
			ToolStripButton toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.CheckedChanged -= value;
			}
			this.toolStripButton_3 = toolStripButton_7;
			toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.CheckedChanged += value;
			}
		}

		// Token: 0x0600837C RID: 33660 RVA: 0x0004FC85 File Offset: 0x0004DE85
		[CompilerGenerated]
		internal ToolStripButton vmethod_14()
		{
			return this.toolStripButton_4;
		}

		// Token: 0x0600837D RID: 33661 RVA: 0x0046BF90 File Offset: 0x0046A190
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ToolStripButton toolStripButton_7)
		{
			EventHandler value = new EventHandler(this.method_13);
			ToolStripButton toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_4 = toolStripButton_7;
			toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600837E RID: 33662 RVA: 0x0004FC8D File Offset: 0x0004DE8D
		[CompilerGenerated]
		internal ToolStripButton vmethod_16()
		{
			return this.toolStripButton_5;
		}

		// Token: 0x0600837F RID: 33663 RVA: 0x0046BFD4 File Offset: 0x0046A1D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(ToolStripButton toolStripButton_7)
		{
			EventHandler value = new EventHandler(this.method_10);
			ToolStripButton toolStripButton = this.toolStripButton_5;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_5 = toolStripButton_7;
			toolStripButton = this.toolStripButton_5;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008380 RID: 33664 RVA: 0x0004FC95 File Offset: 0x0004DE95
		[CompilerGenerated]
		internal ToolStripButton vmethod_18()
		{
			return this.toolStripButton_6;
		}

		// Token: 0x06008381 RID: 33665 RVA: 0x0046C018 File Offset: 0x0046A218
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(ToolStripButton toolStripButton_7)
		{
			EventHandler value = new EventHandler(this.method_6);
			ToolStripButton toolStripButton = this.toolStripButton_6;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_6 = toolStripButton_7;
			toolStripButton = this.toolStripButton_6;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008382 RID: 33666 RVA: 0x0004FC9D File Offset: 0x0004DE9D
		[CompilerGenerated]
		internal OpenFileDialog vmethod_20()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x06008383 RID: 33667 RVA: 0x0004FCA5 File Offset: 0x0004DEA5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x06008384 RID: 33668 RVA: 0x0004FCAE File Offset: 0x0004DEAE
		[CompilerGenerated]
		internal Timer vmethod_22()
		{
			return this.timer_0;
		}

		// Token: 0x06008385 RID: 33669 RVA: 0x0046C05C File Offset: 0x0046A25C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Timer timer_2)
		{
			EventHandler value = new EventHandler(this.method_17);
			Timer timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.timer_0 = timer_2;
			timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06008386 RID: 33670 RVA: 0x0004FCB6 File Offset: 0x0004DEB6
		[CompilerGenerated]
		internal Timer vmethod_24()
		{
			return this.timer_1;
		}

		// Token: 0x06008387 RID: 33671 RVA: 0x0046C0A0 File Offset: 0x0046A2A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Timer timer_2)
		{
			EventHandler value = new EventHandler(this.method_21);
			Timer timer = this.timer_1;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.timer_1 = timer_2;
			timer = this.timer_1;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06008388 RID: 33672 RVA: 0x0004FCBE File Offset: 0x0004DEBE
		[CompilerGenerated]
		internal Class125 vmethod_26()
		{
			return this.class125_1;
		}

		// Token: 0x06008389 RID: 33673 RVA: 0x0004FCC6 File Offset: 0x0004DEC6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class125 class125_2)
		{
			this.class125_1 = class125_2;
		}

		// Token: 0x0600838A RID: 33674 RVA: 0x0004FCCF File Offset: 0x0004DECF
		[CompilerGenerated]
		internal ToolStripLabel vmethod_28()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x0600838B RID: 33675 RVA: 0x0004FCD7 File Offset: 0x0004DED7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(ToolStripLabel toolStripLabel_2)
		{
			this.toolStripLabel_0 = toolStripLabel_2;
		}

		// Token: 0x0600838C RID: 33676 RVA: 0x0004FCE0 File Offset: 0x0004DEE0
		[CompilerGenerated]
		internal ToolStripLabel vmethod_30()
		{
			return this.toolStripLabel_1;
		}

		// Token: 0x0600838D RID: 33677 RVA: 0x0004FCE8 File Offset: 0x0004DEE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(ToolStripLabel toolStripLabel_2)
		{
			this.toolStripLabel_1 = toolStripLabel_2;
		}

		// Token: 0x0600838E RID: 33678 RVA: 0x0004FCF1 File Offset: 0x0004DEF1
		[CompilerGenerated]
		private BackgroundWorker vmethod_32()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x0600838F RID: 33679 RVA: 0x0046C0E4 File Offset: 0x0046A2E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_33(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler doWorkEventHandler = new DoWorkEventHandler(this.method_18);
			RunWorkerCompletedEventHandler runWorkerCompletedEventHandler = new RunWorkerCompletedEventHandler(this.method_20);
			BackgroundWorker backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted -= runWorkerCompletedEventHandler;
			}
			this.backgroundWorker_0 = backgroundWorker_1;
			backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted += runWorkerCompletedEventHandler;
			}
		}

		// Token: 0x06008390 RID: 33680 RVA: 0x0004FCF9 File Offset: 0x0004DEF9
		private int method_3()
		{
			return this.int_0;
		}

		// Token: 0x06008391 RID: 33681 RVA: 0x0046C144 File Offset: 0x0046A344
		private void method_4(int int_1)
		{
			this.int_0 = int_1;
			this.side_0 = Client.smethod_46().method_54();
			while (this.vmethod_32().IsBusy)
			{
				Application.DoEvents();
			}
			this.vmethod_32().RunWorkerAsync();
			this.double_0 = 0.0;
			this.vmethod_28().Visible = true;
		}

		// Token: 0x06008392 RID: 33682 RVA: 0x0046C1A4 File Offset: 0x0046A3A4
		private void method_5(object sender, EventArgs e)
		{
			this.vmethod_20().InitialDirectory = Application.StartupPath + "\\Recordings\\";
			if (this.vmethod_20().ShowDialog() == DialogResult.OK)
			{
				string fileName = this.vmethod_20().FileName;
				this.method_7(fileName);
			}
		}

		// Token: 0x06008393 RID: 33683 RVA: 0x0046C1EC File Offset: 0x0046A3EC
		private void method_6(object sender, EventArgs e)
		{
			string text = Recorder.smethod_1();
			if (string.IsNullOrEmpty(text))
			{
				DarkMessageBox.smethod_2("No VCR files can be found.", "No files present!", Enum11.const_0);
				return;
			}
			this.method_7(text);
		}

		// Token: 0x06008394 RID: 33684 RVA: 0x0046C220 File Offset: 0x0046A420
		private void method_7(string string_1)
		{
			this.class581_0 = Recorder.smethod_2(string_1);
			if (this.class581_0.list_0.Count == 0)
			{
				DarkMessageBox.smethod_2("This recording does not have any saved snapshots! Please load another recording.", "Error", Enum11.const_0);
				this.class581_0 = null;
				return;
			}
			this.vmethod_0().Maximum = this.class581_0.list_0.Count - 1;
			this.vmethod_0().Value = 0;
			this.string_0 = "TapeLoad";
			this.method_4(this.class581_0.list_0[0].Item1);
			this.vmethod_16().Enabled = true;
			this.vmethod_8().Enabled = true;
			this.vmethod_12().Enabled = true;
			this.vmethod_10().Enabled = true;
			this.vmethod_14().Enabled = true;
			this.vmethod_0().Enabled = true;
		}

		// Token: 0x06008395 RID: 33685 RVA: 0x0046C2FC File Offset: 0x0046A4FC
		private void method_8(object sender, EventArgs e)
		{
			if (this.vmethod_12().Checked)
			{
				this.vmethod_12().Checked = true;
				this.vmethod_12().Image = Image.FromFile(Application.StartupPath + "\\Symbols\\Menu\\Pause.gif");
				this.vmethod_22().Start();
				return;
			}
			if (this.vmethod_32().IsBusy)
			{
				this.vmethod_32().CancelAsync();
			}
			this.vmethod_12().Checked = false;
			this.vmethod_12().Image = Image.FromFile(Application.StartupPath + "\\Symbols\\Menu\\Run.gif");
			this.vmethod_22().Stop();
		}

		// Token: 0x06008396 RID: 33686 RVA: 0x0046C39C File Offset: 0x0046A59C
		private void method_9(object sender, EventArgs e)
		{
			if (this.vmethod_32().IsBusy)
			{
				this.vmethod_32().CancelAsync();
			}
			this.string_0 = "TapeStep";
			this.method_4(this.class581_0.list_0[0].Item1);
		}

		// Token: 0x06008397 RID: 33687 RVA: 0x0046C3E8 File Offset: 0x0046A5E8
		private void method_10(object sender, EventArgs e)
		{
			if (this.vmethod_32().IsBusy)
			{
				this.vmethod_32().CancelAsync();
			}
			this.string_0 = "TapeStep";
			this.method_4(this.class581_0.list_0[this.class581_0.list_0.Count - 1].Item1);
		}

		// Token: 0x06008398 RID: 33688 RVA: 0x0046C448 File Offset: 0x0046A648
		private void method_11(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.vmethod_12().Checked = false;
				this.Text = string.Concat(new string[]
				{
					"Scenario time: ",
					this.class581_0.list_0[this.vmethod_0().Value].Item2.ToShortDateString(),
					" ",
					this.class581_0.list_0[this.vmethod_0().Value].Item2.ToShortTimeString(),
					" GMT - Release mouse button to load!"
				});
			}
		}

		// Token: 0x06008399 RID: 33689 RVA: 0x0004FD01 File Offset: 0x0004DF01
		private void method_12(object sender, EventArgs e)
		{
			this.method_15();
		}

		// Token: 0x0600839A RID: 33690 RVA: 0x0004FD09 File Offset: 0x0004DF09
		private void method_13(object sender, EventArgs e)
		{
			this.method_14();
		}

		// Token: 0x0600839B RID: 33691 RVA: 0x0046C4F0 File Offset: 0x0046A6F0
		private void method_14()
		{
			if (this.vmethod_0().Value != this.vmethod_0().Maximum - 1)
			{
				if (this.vmethod_32().IsBusy)
				{
					this.vmethod_32().CancelAsync();
				}
				this.vmethod_0().Value = Math.Min(this.vmethod_0().Maximum, this.vmethod_0().Value + 1);
				this.string_0 = "TapeStep";
				this.method_4(this.class581_0.list_0[this.vmethod_0().Value].Item1);
			}
		}

		// Token: 0x0600839C RID: 33692 RVA: 0x0046C588 File Offset: 0x0046A788
		private void method_15()
		{
			if (this.vmethod_0().Value != 0)
			{
				if (this.vmethod_32().IsBusy)
				{
					this.vmethod_32().CancelAsync();
				}
				this.vmethod_0().Value = Math.Max(this.vmethod_0().Minimum, this.vmethod_0().Value - 1);
				this.string_0 = "TapeStep";
				this.method_4(this.class581_0.list_0[this.vmethod_0().Value].Item1);
			}
		}

		// Token: 0x0600839D RID: 33693 RVA: 0x0004FD11 File Offset: 0x0004DF11
		private void method_16(object sender, MouseEventArgs e)
		{
			this.Text = "Replay Viewer";
			this.method_4(this.class581_0.list_0[this.vmethod_0().Value].Item1);
		}

		// Token: 0x0600839E RID: 33694 RVA: 0x0046C614 File Offset: 0x0046A814
		private void RecorderForm_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_33(new BackgroundWorker());
			this.vmethod_32().WorkerSupportsCancellation = true;
			this.vmethod_24().Start();
			this.vmethod_16().Enabled = false;
			this.vmethod_8().Enabled = false;
			this.vmethod_12().Enabled = false;
			this.vmethod_10().Enabled = false;
			this.vmethod_14().Enabled = false;
			this.vmethod_0().Enabled = false;
		}

		// Token: 0x0600839F RID: 33695 RVA: 0x0046C6A0 File Offset: 0x0046A8A0
		private void method_17(object sender, EventArgs e)
		{
			if (!Client.bool_3 && this.vmethod_0().Value != this.vmethod_0().Maximum)
			{
				this.vmethod_0().Value = this.vmethod_0().Value + 1;
				this.string_0 = "TapeStep";
				this.method_4(this.class581_0.list_0[this.vmethod_0().Value].Item1);
			}
		}

		// Token: 0x060083A0 RID: 33696 RVA: 0x0046C718 File Offset: 0x0046A918
		private void method_18(object sender, DoWorkEventArgs e)
		{
			Client.bool_3 = true;
			try
			{
				try
				{
					new MemoryFailPoint(100).Dispose();
				}
				catch (InsufficientMemoryException ex)
				{
					GameGeneral.smethod_10();
					ex.Data.Add("Error at 200394", ex.Message);
					Exception ex2 = ex;
					GameGeneral.smethod_25(ref ex2);
					ex = (InsufficientMemoryException)ex2;
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				this.scenario_0 = this.class581_0.method_6(this.method_3(), ref this.double_0);
				this.bool_3 = false;
			}
			catch (Exception ex3)
			{
				this.bool_3 = true;
			}
		}

		// Token: 0x060083A1 RID: 33697 RVA: 0x0004FD44 File Offset: 0x0004DF44
		private void method_19()
		{
			if (this.vmethod_12().Checked | this.vmethod_14().Checked)
			{
				this.method_14();
			}
			if (this.vmethod_10().Checked)
			{
				this.method_15();
			}
		}

		// Token: 0x060083A2 RID: 33698 RVA: 0x0046C7D4 File Offset: 0x0046A9D4
		private void method_20(object sender, RunWorkerCompletedEventArgs e)
		{
			if (this.bool_3)
			{
				this.vmethod_30().Visible = true;
				this.method_19();
				return;
			}
			this.vmethod_30().Visible = false;
			if (!Information.IsNothing(this.side_0))
			{
				foreach (Side side in this.scenario_0.method_44())
				{
					if (Operators.CompareString(side.string_0, this.side_0.string_0, false) == 0)
					{
						this.scenario_0.method_53(side);
						break;
					}
				}
			}
			this.vmethod_28().Visible = false;
			Client.smethod_47(this.scenario_0, true);
			Client.bool_3 = false;
			if (Operators.CompareString(this.string_0, "TapeLoad", false) == 0 && !Information.IsNothing(this.side_0) && Operators.CompareString(this.side_0.string_0, Client.smethod_50().string_0, false) != 0)
			{
				Class2413.smethod_2().method_41().method_161(true, Client.smethod_46().method_54().method_26());
				Class2413.smethod_2().method_41().method_153((int)Math.Round(Client.smethod_46().method_54().double_0));
			}
		}

		// Token: 0x060083A3 RID: 33699 RVA: 0x0004FD78 File Offset: 0x0004DF78
		private void method_21(object sender, EventArgs e)
		{
			this.vmethod_28().Text = "Loading frame..." + Conversions.ToString((int)Math.Round(this.double_0 * 100.0)) + "%";
		}

		// Token: 0x060083A4 RID: 33700 RVA: 0x000476BE File Offset: 0x000458BE
		private void RecorderForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x060083A5 RID: 33701 RVA: 0x00044820 File Offset: 0x00042A20
		private void RecorderForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x060083A6 RID: 33702 RVA: 0x0004645A File Offset: 0x0004465A
		private void RecorderForm_Closing(object sender, CancelEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
		}

		// Token: 0x040047F9 RID: 18425
		[AccessedThroughProperty("TB_Snapshots")]
		[CompilerGenerated]
		private TrackBar trackBar_0;

		// Token: 0x040047FA RID: 18426
		[AccessedThroughProperty("ToolStrip1")]
		[CompilerGenerated]
		private Class125 class125_0;

		// Token: 0x040047FB RID: 18427
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_LoadRecording")]
		private ToolStripButton toolStripButton_0;

		// Token: 0x040047FC RID: 18428
		[AccessedThroughProperty("ToolStripSeparator1")]
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x040047FD RID: 18429
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_GoToStart")]
		private ToolStripButton toolStripButton_1;

		// Token: 0x040047FE RID: 18430
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_StepBack")]
		private ToolStripButton toolStripButton_2;

		// Token: 0x040047FF RID: 18431
		[AccessedThroughProperty("TSB_Play")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_3;

		// Token: 0x04004800 RID: 18432
		[AccessedThroughProperty("TSB_StepForward")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_4;

		// Token: 0x04004801 RID: 18433
		[AccessedThroughProperty("TSB_GoToEnd")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_5;

		// Token: 0x04004802 RID: 18434
		[AccessedThroughProperty("TSB_LoadMostRecent")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_6;

		// Token: 0x04004803 RID: 18435
		[CompilerGenerated]
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x04004804 RID: 18436
		[AccessedThroughProperty("Timer1")]
		[CompilerGenerated]
		private Timer timer_0;

		// Token: 0x04004805 RID: 18437
		[AccessedThroughProperty("Timer2")]
		[CompilerGenerated]
		private Timer timer_1;

		// Token: 0x04004806 RID: 18438
		[AccessedThroughProperty("DarkToolStrip1")]
		[CompilerGenerated]
		private Class125 class125_1;

		// Token: 0x04004807 RID: 18439
		[AccessedThroughProperty("TSL1")]
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x04004808 RID: 18440
		[AccessedThroughProperty("TSSL_BadFrame")]
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_1;

		// Token: 0x04004809 RID: 18441
		private Class581 class581_0;

		// Token: 0x0400480A RID: 18442
		private int int_0;

		// Token: 0x0400480B RID: 18443
		private Side side_0;

		// Token: 0x0400480C RID: 18444
		[CompilerGenerated]
		[AccessedThroughProperty("BW1")]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x0400480D RID: 18445
		private double double_0;

		// Token: 0x0400480E RID: 18446
		private Scenario scenario_0;

		// Token: 0x0400480F RID: 18447
		private bool bool_3;

		// Token: 0x04004810 RID: 18448
		private string string_0;
	}
}
