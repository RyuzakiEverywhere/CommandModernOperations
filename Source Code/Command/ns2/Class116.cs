using System;
using System.Drawing;
using System.Windows.Forms;
using ns8;

namespace ns2
{
	// Token: 0x020000C7 RID: 199
	internal sealed class Class116 : Label
	{
		// Token: 0x06000445 RID: 1093 RVA: 0x000057D7 File Offset: 0x000039D7
		public void method_0(bool bool_2)
		{
			this.bool_0 = bool_2;
			if (this.bool_0)
			{
				this.method_2(false);
				this.method_3();
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000057F5 File Offset: 0x000039F5
		public bool method_1()
		{
			return base.AutoSize;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000057FD File Offset: 0x000039FD
		public void method_2(bool bool_2)
		{
			base.AutoSize = bool_2;
			if (this.method_1())
			{
				this.method_0(false);
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00005815 File Offset: 0x00003A15
		public Class116()
		{
			this.ForeColor = Class129.smethod_11();
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000665DC File Offset: 0x000647DC
		private void method_3()
		{
			if (this.bool_0 && !this.bool_1)
			{
				try
				{
					this.bool_1 = true;
					Size proposedSize = new Size(base.Width, int.MaxValue);
					proposedSize = TextRenderer.MeasureText(this.Text, this.Font, proposedSize, TextFormatFlags.WordBreak);
					base.Height = proposedSize.Height + base.Padding.Vertical;
				}
				finally
				{
					this.bool_1 = false;
				}
				return;
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00005828 File Offset: 0x00003A28
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			this.method_3();
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00005837 File Offset: 0x00003A37
		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged(e);
			this.method_3();
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00005846 File Offset: 0x00003A46
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			this.method_3();
		}

		// Token: 0x0400034C RID: 844
		private bool bool_0;

		// Token: 0x0400034D RID: 845
		private bool bool_1;
	}
}
