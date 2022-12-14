using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns5;

namespace ns4
{
	// Token: 0x02000E24 RID: 3620
	[DesignerGenerated]
	internal sealed partial class FlightPlanErrors : DarkSecondaryFormBase
	{
		// Token: 0x06006BE8 RID: 27624 RVA: 0x003B3854 File Offset: 0x003B1A54
		public FlightPlanErrors()
		{
			base.FormClosing += this.FlightPlanErrors_FormClosing;
			base.FormClosed += this.FlightPlanErrors_FormClosed;
			base.KeyDown += this.FlightPlanErrors_KeyDown;
			this.InitializeComponent_1();
		}

		// Token: 0x06006BEA RID: 27626 RVA: 0x003B38E4 File Offset: 0x003B1AE4
		private void InitializeComponent_1()
		{
			this.vmethod_1(new Control4());
			base.SuspendLayout();
			this.vmethod_0().Dock = DockStyle.Fill;
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "LB_Errors";
			this.vmethod_0().Size = new Size(1111, 96);
			this.vmethod_0().TabIndex = 1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1111, 96);
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FlightPlanErrors";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Flightplan Errors";
			base.ResumeLayout(false);
		}

		// Token: 0x06006BEB RID: 27627 RVA: 0x000440B8 File Offset: 0x000422B8
		[CompilerGenerated]
		internal Control4 vmethod_0()
		{
			return this.control4_0;
		}

		// Token: 0x06006BEC RID: 27628 RVA: 0x000440C0 File Offset: 0x000422C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control4 control4_1)
		{
			this.control4_0 = control4_1;
		}

		// Token: 0x06006BED RID: 27629 RVA: 0x00042F6B File Offset: 0x0004116B
		private void FlightPlanErrors_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06006BEE RID: 27630 RVA: 0x0000378C File Offset: 0x0000198C
		private void FlightPlanErrors_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		// Token: 0x06006BEF RID: 27631 RVA: 0x000440C9 File Offset: 0x000422C9
		private void FlightPlanErrors_KeyDown(object sender, KeyEventArgs e)
		{
			Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x04003DB5 RID: 15797
		[AccessedThroughProperty("LB_Errors")]
		[CompilerGenerated]
		private Control4 control4_0;
	}
}
