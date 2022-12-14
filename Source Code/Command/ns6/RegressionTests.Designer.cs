namespace ns6
{
	// Token: 0x02000ECE RID: 3790
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	internal sealed partial class RegressionTests : global::ns6.Form4
	{
		// Token: 0x060083A8 RID: 33704 RVA: 0x0046C948 File Offset: 0x0046AB48
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

		// Token: 0x060083A9 RID: 33705 RVA: 0x0046C988 File Offset: 0x0046AB88
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.TextBox());
			base.SuspendLayout();
			this.vmethod_0().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Multiline = true;
			this.vmethod_0().Name = "TextBox1";
			this.vmethod_0().ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.vmethod_0().Size = new global::System.Drawing.Size(544, 378);
			this.vmethod_0().TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			base.ClientSize = new global::System.Drawing.Size(544, 378);
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RegressionTests";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Regression Tests";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04004811 RID: 18449
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
