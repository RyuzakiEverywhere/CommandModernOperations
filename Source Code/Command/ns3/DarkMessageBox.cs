using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns2;

namespace ns3
{
	// Token: 0x020000AD RID: 173
	internal sealed partial class DarkMessageBox : DarkDialog
	{
		// Token: 0x06000377 RID: 887 RVA: 0x00005062 File Offset: 0x00003262
		public DarkMessageBox()
		{
			this.InitializeComponent_1();
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000507B File Offset: 0x0000327B
		public DarkMessageBox(string string_1, string string_2, Enum12 enum12_0, Enum11 enum11_1) : this()
		{
			this.Text = string_2;
			this.string_0 = string_1;
			base.method_1(enum11_1);
			this.method_9(enum12_0);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000050A0 File Offset: 0x000032A0
		public static DialogResult smethod_0(string message, string caption, Enum11 buttons = Enum11.const_0)
		{
			return DarkMessageBox.smethod_3(message, caption, Enum12.const_1, buttons);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000050AB File Offset: 0x000032AB
		public static DialogResult smethod_1(string message, string caption, Enum11 buttons = Enum11.const_0)
		{
			return DarkMessageBox.smethod_3(message, caption, Enum12.const_2, buttons);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000050B6 File Offset: 0x000032B6
		public static DialogResult smethod_2(string message, string caption, Enum11 buttons = Enum11.const_0)
		{
			return DarkMessageBox.smethod_3(message, caption, Enum12.const_3, buttons);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00062D68 File Offset: 0x00060F68
		private static DialogResult smethod_3(string string_1, string string_2, Enum12 enum12_0, Enum11 enum11_1)
		{
			DialogResult result;
			using (DarkMessageBox darkMessageBox = new DarkMessageBox(string_1, string_2, enum12_0, enum11_1))
			{
				result = darkMessageBox.ShowDialog();
			}
			return result;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00062DA4 File Offset: 0x00060FA4
		private void method_9(Enum12 enum12_0)
		{
			switch (enum12_0)
			{
			case Enum12.const_0:
				this.picIcon.Visible = false;
				this.lblText.Left = 10;
				return;
			case Enum12.const_1:
				this.picIcon.Image = Class97.smethod_2();
				return;
			case Enum12.const_2:
				this.picIcon.Image = Class97.smethod_3();
				return;
			case Enum12.const_3:
				this.picIcon.Image = Class97.smethod_1();
				return;
			default:
				return;
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00062E14 File Offset: 0x00061014
		private void method_10()
		{
			int height = 124;
			base.Size = new Size(260, 124);
			this.lblText.Text = string.Empty;
			this.lblText.method_2(true);
			this.lblText.Text = this.string_0;
			int num = Math.Max(260, base.method_2() + 15);
			int num2 = this.lblText.Right + 25;
			int num3;
			if (num2 < this.int_1)
			{
				num3 = num2;
				this.lblText.Top = this.picIcon.Top + this.picIcon.Height / 2 - this.lblText.Height / 2;
			}
			else
			{
				num3 = this.int_1;
				int num4 = base.Height - this.picIcon.Height;
				this.lblText.method_0(true);
				this.lblText.Width = num3 - this.lblText.Left - 25;
				height = num4 + this.lblText.Height;
			}
			if (num3 < num)
			{
				num3 = num;
			}
			base.Size = new Size(num3, height);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000050C1 File Offset: 0x000032C1
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.method_10();
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00062F2C File Offset: 0x0006112C
		private void InitializeComponent_1()
		{
			this.picIcon = new PictureBox();
			this.lblText = new Class116();
			((ISupportInitialize)this.picIcon).BeginInit();
			base.SuspendLayout();
			this.picIcon.Location = new Point(10, 10);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new Size(32, 32);
			this.picIcon.TabIndex = 3;
			this.picIcon.TabStop = false;
			this.lblText.method_2(true);
			this.lblText.ForeColor = Color.FromArgb(220, 220, 220);
			this.lblText.Location = new Point(50, 9);
			this.lblText.Name = "lblText";
			this.lblText.Size = new Size(185, 15);
			this.lblText.TabIndex = 4;
			this.lblText.Text = "Something something something";
			base.AutoScaleDimensions = new SizeF(7f, 15f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(244, 86);
			base.Controls.Add(this.lblText);
			base.Controls.Add(this.picIcon);
			this.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DarkMessageBox";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Message box";
			base.TopMost = true;
			base.Controls.SetChildIndex(this.picIcon, 0);
			base.Controls.SetChildIndex(this.lblText, 0);
			((ISupportInitialize)this.picIcon).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040002D8 RID: 728
		private string string_0;

		// Token: 0x040002D9 RID: 729
		private int int_1 = 350;

		// Token: 0x040002DB RID: 731
		private PictureBox picIcon;

		// Token: 0x040002DC RID: 732
		private Class116 lblText;
	}
}
