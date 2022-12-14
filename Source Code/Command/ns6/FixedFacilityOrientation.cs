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
	// Token: 0x02000F05 RID: 3845
	[DesignerGenerated]
	internal sealed partial class FixedFacilityOrientation : DarkSecondaryFormBase
	{
		// Token: 0x06008874 RID: 34932 RVA: 0x00491034 File Offset: 0x0048F234
		public FixedFacilityOrientation()
		{
			base.Load += this.FixedFacilityOrientation_Load;
			base.KeyDown += this.FixedFacilityOrientation_KeyDown;
			base.FormClosing += this.FixedFacilityOrientation_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x06008876 RID: 34934 RVA: 0x004910C4 File Offset: 0x0048F2C4
		private void InitializeComponent_1()
		{
			this.vmethod_1(new TrackBar());
			this.vmethod_3(new Class116());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Location = new Point(4, 3);
			this.vmethod_0().Maximum = 359;
			this.vmethod_0().Name = "TrackBar1";
			this.vmethod_0().Size = new Size(210, 45);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().method_2(true);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(220, 13);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new Size(44, 13);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "Current:";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(304, 35);
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FixedFacilityOrientation";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Set orientation for fixed facility";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06008877 RID: 34935 RVA: 0x00052065 File Offset: 0x00050265
		[CompilerGenerated]
		internal TrackBar vmethod_0()
		{
			return this.trackBar_0;
		}

		// Token: 0x06008878 RID: 34936 RVA: 0x00491288 File Offset: 0x0048F488
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TrackBar trackBar_1)
		{
			EventHandler value = new EventHandler(this.method_3);
			TrackBar trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.ValueChanged -= value;
			}
			this.trackBar_0 = trackBar_1;
			trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.ValueChanged += value;
			}
		}

		// Token: 0x06008879 RID: 34937 RVA: 0x0005206D File Offset: 0x0005026D
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_0;
		}

		// Token: 0x0600887A RID: 34938 RVA: 0x00052075 File Offset: 0x00050275
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x0600887B RID: 34939 RVA: 0x0005207E File Offset: 0x0005027E
		private void FixedFacilityOrientation_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_0().Value = (int)Math.Round((double)this.activeUnit_0.vmethod_9());
		}

		// Token: 0x0600887C RID: 34940 RVA: 0x004912CC File Offset: 0x0048F4CC
		private void method_3(object sender, EventArgs e)
		{
			this.activeUnit_0.vmethod_10((float)this.vmethod_0().Value);
			this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, (float)this.vmethod_0().Value);
			this.vmethod_2().Text = "Current: " + Conversions.ToString(this.vmethod_0().Value);
			Client.bool_1 = true;
		}

		// Token: 0x0600887D RID: 34941 RVA: 0x000476BE File Offset: 0x000458BE
		private void FixedFacilityOrientation_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x0600887E RID: 34942 RVA: 0x00044820 File Offset: 0x00042A20
		private void FixedFacilityOrientation_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x04004A2D RID: 18989
		[CompilerGenerated]
		[AccessedThroughProperty("TrackBar1")]
		private TrackBar trackBar_0;

		// Token: 0x04004A2E RID: 18990
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04004A2F RID: 18991
		public ActiveUnit activeUnit_0;
	}
}
