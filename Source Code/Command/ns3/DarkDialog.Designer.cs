namespace ns3
{
	// Token: 0x020000AA RID: 170
	internal partial class DarkDialog : global::ns3.Form0
	{
		// Token: 0x06000372 RID: 882 RVA: 0x00005021 File Offset: 0x00003221
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00062620 File Offset: 0x00060820
		private void InitializeComponent()
		{
			this.pnlFooter = new global::System.Windows.Forms.Panel();
			this.flowInner = new global::System.Windows.Forms.FlowLayoutPanel();
			this.btnOk = new global::ns2.Class111();
			this.btnCancel = new global::ns2.Class111();
			this.btnClose = new global::ns2.Class111();
			this.btnYes = new global::ns2.Class111();
			this.btnNo = new global::ns2.Class111();
			this.btnAbort = new global::ns2.Class111();
			this.btnRetry = new global::ns2.Class111();
			this.btnIgnore = new global::ns2.Class111();
			this.pnlFooter.SuspendLayout();
			this.flowInner.SuspendLayout();
			base.SuspendLayout();
			this.pnlFooter.Controls.Add(this.flowInner);
			this.pnlFooter.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.pnlFooter.Location = new global::System.Drawing.Point(0, 357);
			this.pnlFooter.Name = "pnlFooter";
			this.pnlFooter.Size = new global::System.Drawing.Size(767, 45);
			this.pnlFooter.TabIndex = 1;
			this.flowInner.Controls.Add(this.btnOk);
			this.flowInner.Controls.Add(this.btnCancel);
			this.flowInner.Controls.Add(this.btnClose);
			this.flowInner.Controls.Add(this.btnYes);
			this.flowInner.Controls.Add(this.btnNo);
			this.flowInner.Controls.Add(this.btnAbort);
			this.flowInner.Controls.Add(this.btnRetry);
			this.flowInner.Controls.Add(this.btnIgnore);
			this.flowInner.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.flowInner.Location = new global::System.Drawing.Point(104, 0);
			this.flowInner.Name = "flowInner";
			this.flowInner.Padding = new global::System.Windows.Forms.Padding(10);
			this.flowInner.Size = new global::System.Drawing.Size(663, 45);
			this.flowInner.TabIndex = 10014;
			this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new global::System.Drawing.Point(10, 10);
			this.btnOk.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnOk.Name = "btnOk";
			this.btnOk.Padding = new global::System.Windows.Forms.Padding(5);
			this.btnOk.Size = new global::System.Drawing.Size(75, 26);
			this.btnOk.TabIndex = 3;
			this.btnOk.method_1("Ok");
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(85, 10);
			this.btnCancel.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Padding = new global::System.Windows.Forms.Padding(5);
			this.btnCancel.Size = new global::System.Drawing.Size(75, 26);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.method_1("Cancel");
			this.btnClose.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new global::System.Drawing.Point(160, 10);
			this.btnClose.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Padding = new global::System.Windows.Forms.Padding(5);
			this.btnClose.Size = new global::System.Drawing.Size(75, 26);
			this.btnClose.TabIndex = 5;
			this.btnClose.method_1("Close");
			this.btnYes.DialogResult = global::System.Windows.Forms.DialogResult.Yes;
			this.btnYes.Location = new global::System.Drawing.Point(235, 10);
			this.btnYes.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnYes.Name = "btnYes";
			this.btnYes.Padding = new global::System.Windows.Forms.Padding(5);
			this.btnYes.Size = new global::System.Drawing.Size(75, 26);
			this.btnYes.TabIndex = 6;
			this.btnYes.method_1("Yes");
			this.btnNo.DialogResult = global::System.Windows.Forms.DialogResult.No;
			this.btnNo.Location = new global::System.Drawing.Point(310, 10);
			this.btnNo.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnNo.Name = "btnNo";
			this.btnNo.Padding = new global::System.Windows.Forms.Padding(5);
			this.btnNo.Size = new global::System.Drawing.Size(75, 26);
			this.btnNo.TabIndex = 7;
			this.btnNo.method_1("No");
			this.btnAbort.DialogResult = global::System.Windows.Forms.DialogResult.Abort;
			this.btnAbort.Location = new global::System.Drawing.Point(385, 10);
			this.btnAbort.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnAbort.Name = "btnAbort";
			this.btnAbort.Padding = new global::System.Windows.Forms.Padding(5);
			this.btnAbort.Size = new global::System.Drawing.Size(75, 26);
			this.btnAbort.TabIndex = 8;
			this.btnAbort.method_1("Abort");
			this.btnRetry.DialogResult = global::System.Windows.Forms.DialogResult.Retry;
			this.btnRetry.Location = new global::System.Drawing.Point(460, 10);
			this.btnRetry.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnRetry.Name = "btnRetry";
			this.btnRetry.Padding = new global::System.Windows.Forms.Padding(5);
			this.btnRetry.Size = new global::System.Drawing.Size(75, 26);
			this.btnRetry.TabIndex = 9;
			this.btnRetry.method_1("Retry");
			this.btnIgnore.DialogResult = global::System.Windows.Forms.DialogResult.Ignore;
			this.btnIgnore.Location = new global::System.Drawing.Point(535, 10);
			this.btnIgnore.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnIgnore.Name = "btnIgnore";
			this.btnIgnore.Padding = new global::System.Windows.Forms.Padding(5);
			this.btnIgnore.Size = new global::System.Drawing.Size(75, 26);
			this.btnIgnore.TabIndex = 10;
			this.btnIgnore.method_1("Ignore");
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(767, 402);
			base.Controls.Add(this.pnlFooter);
			base.Name = "DarkDialog";
			this.Text = "DarkDialog";
			this.pnlFooter.ResumeLayout(false);
			this.flowInner.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040002C3 RID: 707
		protected global::ns2.Class111 btnOk;

		// Token: 0x040002C4 RID: 708
		protected global::ns2.Class111 btnCancel;

		// Token: 0x040002C5 RID: 709
		protected global::ns2.Class111 btnClose;

		// Token: 0x040002C6 RID: 710
		protected global::ns2.Class111 btnYes;

		// Token: 0x040002C7 RID: 711
		protected global::ns2.Class111 btnNo;

		// Token: 0x040002C8 RID: 712
		protected global::ns2.Class111 btnAbort;

		// Token: 0x040002C9 RID: 713
		protected global::ns2.Class111 btnRetry;

		// Token: 0x040002CA RID: 714
		protected global::ns2.Class111 btnIgnore;

		// Token: 0x040002CC RID: 716
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040002CD RID: 717
		private global::System.Windows.Forms.Panel pnlFooter;

		// Token: 0x040002CE RID: 718
		private global::System.Windows.Forms.FlowLayoutPanel flowInner;
	}
}
