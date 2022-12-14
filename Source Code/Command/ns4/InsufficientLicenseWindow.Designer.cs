namespace ns4
{
	// Token: 0x02000E7B RID: 3707
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	internal sealed partial class InsufficientLicenseWindow : global::ns3.Form0
	{
		// Token: 0x060071FB RID: 29179 RVA: 0x003D3AD0 File Offset: 0x003D1CD0
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

		// Token: 0x060071FC RID: 29180 RVA: 0x003D3B10 File Offset: 0x003D1D10
		private void InitializeComponent()
		{
			this.vmethod_1(new global::ns2.Class116());
			this.vmethod_3(new global::System.Windows.Forms.SplitContainer());
			this.vmethod_5(new global::System.Windows.Forms.FlowLayoutPanel());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_2()).BeginInit();
			this.vmethod_2().Panel1.SuspendLayout();
			this.vmethod_2().Panel2.SuspendLayout();
			this.vmethod_2().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().BackColor = global::System.Drawing.Color.Transparent;
			this.vmethod_0().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_0().Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_0().ForeColor = global::System.Drawing.Color.White;
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().MaximumSize = new global::System.Drawing.Size(700, 0);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new global::System.Drawing.Size(374, 85);
			this.vmethod_0().TabIndex = 3;
			this.vmethod_0().Text = "To perform the requested action you need a license for the product below. Click on the product icon to obtain a license for it.";
			this.vmethod_2().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_2().FixedPanel = global::System.Windows.Forms.FixedPanel.Panel1;
			this.vmethod_2().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_2().Name = "SplitContainer1";
			this.vmethod_2().Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.vmethod_2().Panel1.BackColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.vmethod_2().Panel1.Controls.Add(this.vmethod_0());
			this.vmethod_2().Panel2.Controls.Add(this.vmethod_4());
			this.vmethod_2().Size = new global::System.Drawing.Size(374, 292);
			this.vmethod_2().SplitterDistance = 85;
			this.vmethod_2().TabIndex = 4;
			this.vmethod_4().AutoScroll = true;
			this.vmethod_4().BackColor = global::System.Drawing.SystemColors.ControlDark;
			this.vmethod_4().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_4().FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.vmethod_4().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_4().Name = "FlowLayoutPanel1";
			this.vmethod_4().Size = new global::System.Drawing.Size(374, 203);
			this.vmethod_4().TabIndex = 0;
			this.vmethod_4().WrapContents = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(374, 292);
			base.Controls.Add(this.vmethod_2());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "InsufficientLicenseWindow";
			base.ShowIcon = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.TopMost = true;
			this.vmethod_2().Panel1.ResumeLayout(false);
			this.vmethod_2().Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_2()).EndInit();
			this.vmethod_2().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04004045 RID: 16453
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
