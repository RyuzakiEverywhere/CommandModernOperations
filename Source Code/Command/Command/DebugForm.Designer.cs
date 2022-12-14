namespace Command
{
	// Token: 0x02000DD6 RID: 3542
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public sealed partial class DebugForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06006689 RID: 26249 RVA: 0x00386004 File Offset: 0x00384204
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

		// Token: 0x0600668A RID: 26250 RVA: 0x00386044 File Offset: 0x00384244
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			this.vmethod_1(new global::System.Windows.Forms.TextBox());
			this.vmethod_3(new global::System.Windows.Forms.Timer(this.icontainer_0));
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.TextBox());
			this.vmethod_9(new global::System.Windows.Forms.Button());
			this.vmethod_11(new global::System.Windows.Forms.CheckedListBox());
			this.vmethod_13(new global::System.Windows.Forms.Button());
			this.vmethod_15(new global::System.Windows.Forms.Button());
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().Location = new global::System.Drawing.Point(12, 12);
			this.vmethod_0().Multiline = true;
			this.vmethod_0().Name = "TextBox1";
			this.vmethod_0().ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.vmethod_0().Size = new global::System.Drawing.Size(511, 725);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().Enabled = true;
			this.vmethod_2().Interval = 1000;
			this.vmethod_4().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_4().AutoSize = true;
			this.vmethod_4().Location = new global::System.Drawing.Point(885, 12);
			this.vmethod_4().Name = "Label1";
			this.vmethod_4().Size = new global::System.Drawing.Size(37, 13);
			this.vmethod_4().TabIndex = 1;
			this.vmethod_4().Text = "Status";
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_6().Location = new global::System.Drawing.Point(884, 28);
			this.vmethod_6().Multiline = true;
			this.vmethod_6().Name = "TextBox2";
			this.vmethod_6().Size = new global::System.Drawing.Size(229, 652);
			this.vmethod_6().TabIndex = 2;
			this.vmethod_8().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_8().Location = new global::System.Drawing.Point(888, 713);
			this.vmethod_8().Name = "Button1";
			this.vmethod_8().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_8().TabIndex = 3;
			this.vmethod_8().Text = "Reset DX";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_10().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_10().ColumnWidth = 160;
			this.vmethod_10().FormattingEnabled = true;
			this.vmethod_10().Location = new global::System.Drawing.Point(529, 12);
			this.vmethod_10().MultiColumn = true;
			this.vmethod_10().Name = "CheckedListBox1";
			this.vmethod_10().Size = new global::System.Drawing.Size(349, 724);
			this.vmethod_10().TabIndex = 4;
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_12().Location = new global::System.Drawing.Point(1013, 686);
			this.vmethod_12().Name = "Button2";
			this.vmethod_12().Size = new global::System.Drawing.Size(100, 23);
			this.vmethod_12().TabIndex = 3;
			this.vmethod_12().Text = "Reset TacView";
			this.vmethod_12().UseVisualStyleBackColor = true;
			this.vmethod_14().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_14().Location = new global::System.Drawing.Point(969, 715);
			this.vmethod_14().Name = "Button3";
			this.vmethod_14().Size = new global::System.Drawing.Size(144, 23);
			this.vmethod_14().TabIndex = 3;
			this.vmethod_14().Text = "Send Junk to TacView";
			this.vmethod_14().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1129, 748);
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_0());
			base.Name = "DebugForm";
			this.Text = "DebugForm";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04003A7C RID: 14972
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
