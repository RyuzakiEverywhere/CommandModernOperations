namespace ns4
{
	// Token: 0x02000E31 RID: 3633
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	internal sealed partial class RealismDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06006CF3 RID: 27891 RVA: 0x003BB2BC File Offset: 0x003B94BC
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06006CF4 RID: 27892 RVA: 0x003BB2FC File Offset: 0x003B94FC
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Integration.ElementHost());
			this.realismDialogControl_0 = new global::Command.RealismDialogControl();
			base.SuspendLayout();
			this.vmethod_0().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Name = "ElementHost1";
			this.vmethod_0().Size = new global::System.Drawing.Size(475, 468);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "ElementHost1";
			this.vmethod_0().Child = this.realismDialogControl_0;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			base.ClientSize = new global::System.Drawing.Size(475, 468);
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RealismDialog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Scenario Features & Realism Options";
			base.TopMost = true;
			base.ResumeLayout(false);
		}

		// Token: 0x04003E20 RID: 15904
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04003E22 RID: 15906
		internal global::Command.RealismDialogControl realismDialogControl_0;
	}
}
