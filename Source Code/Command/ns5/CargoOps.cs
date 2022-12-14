using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace ns5
{
	// Token: 0x02000DB4 RID: 3508
	[DesignerGenerated]
	internal sealed partial class CargoOps : DarkSecondaryFormBase
	{
		// Token: 0x06005EBB RID: 24251 RVA: 0x0003D418 File Offset: 0x0003B618
		public CargoOps()
		{
			base.Load += this.CargoOps_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x06005EBD RID: 24253 RVA: 0x003338C0 File Offset: 0x00331AC0
		private void InitializeComponent_1()
		{
			this.vmethod_1(new ElementHost());
			this.cargoOpsControl_0 = new CargoOpsControl();
			base.SuspendLayout();
			this.vmethod_0().Dock = DockStyle.Fill;
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "ElementHost1";
			this.vmethod_0().Size = new Size(784, 261);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "ElementHost1";
			this.vmethod_0().Child = this.cargoOpsControl_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(784, 261);
			base.Controls.Add(this.vmethod_0());
			base.Name = "CargoOps";
			this.Text = "CargoDialog";
			base.ResumeLayout(false);
		}

		// Token: 0x06005EBE RID: 24254 RVA: 0x0003D438 File Offset: 0x0003B638
		[CompilerGenerated]
		internal ElementHost vmethod_0()
		{
			return this.elementHost_0;
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x0003D440 File Offset: 0x0003B640
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ElementHost elementHost_1)
		{
			this.elementHost_0 = elementHost_1;
		}

		// Token: 0x06005EC0 RID: 24256 RVA: 0x0003D449 File Offset: 0x0003B649
		private void CargoOps_Load(object sender, EventArgs e)
		{
			((CargoOpsControl)this.vmethod_0().Child).DataContext = new CargoOpsViewModel(this, this.activeUnit_0, this.activeUnit_1);
		}

		// Token: 0x040036F4 RID: 14068
		[CompilerGenerated]
		[AccessedThroughProperty("ElementHost1")]
		private ElementHost elementHost_0;

		// Token: 0x040036F5 RID: 14069
		internal CargoOpsControl cargoOpsControl_0;

		// Token: 0x040036F6 RID: 14070
		public ActiveUnit activeUnit_0;

		// Token: 0x040036F7 RID: 14071
		public ActiveUnit activeUnit_1;
	}
}
