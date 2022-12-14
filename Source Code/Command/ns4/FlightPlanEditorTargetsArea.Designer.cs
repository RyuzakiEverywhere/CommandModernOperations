namespace ns4
{
	// Token: 0x02000E21 RID: 3617
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	internal sealed partial class FlightPlanEditorTargetsArea : global::ns6.Form4
	{
		// Token: 0x06006BA4 RID: 27556 RVA: 0x003B0268 File Offset: 0x003AE468
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

		// Token: 0x06006BA5 RID: 27557 RVA: 0x003B02A8 File Offset: 0x003AE4A8
		private void InitializeComponent()
		{
			this.vmethod_1(new global::ns4.AreaEditor());
			base.SuspendLayout();
			this.vmethod_0().Location = new global::System.Drawing.Point(28, 40);
			this.vmethod_0().Name = "AreaEditor_PatrolArea";
			this.vmethod_0().Size = new global::System.Drawing.Size(351, 124);
			this.vmethod_0().TabIndex = 4;
			this.vmethod_0().method_1(null);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(832, 442);
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FlightPlanEditorTargetsArea";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "FlightPlanEditorTargetsArea";
			base.ResumeLayout(false);
		}

		// Token: 0x04003D79 RID: 15737
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
