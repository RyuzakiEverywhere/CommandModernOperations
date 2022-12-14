using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns2
{
	// Token: 0x020000D3 RID: 211
	internal abstract class Control3 : Control2
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x00005C79 File Offset: 0x00003E79
		protected Control3()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x060004C4 RID: 1220
		protected abstract void vmethod_2(Graphics graphics_0);

		// Token: 0x060004C5 RID: 1221 RVA: 0x00068EA0 File Offset: 0x000670A0
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			using (SolidBrush solidBrush = new SolidBrush(this.BackColor))
			{
				graphics.FillRectangle(solidBrush, base.ClientRectangle);
			}
			graphics.TranslateTransform((float)(base.method_0().Left * -1), (float)(base.method_0().Top * -1));
			this.vmethod_2(graphics);
			graphics.TranslateTransform((float)base.method_0().Left, (float)base.method_0().Top);
			if (this.control1_0.method_7() && this.control1_1.method_7())
			{
				using (SolidBrush solidBrush2 = new SolidBrush(this.BackColor))
				{
					Rectangle rect = new Rectangle(this.control1_1.Right, this.control1_0.Bottom, this.control1_0.Width, this.control1_1.Height);
					graphics.FillRectangle(solidBrush2, rect);
				}
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000378C File Offset: 0x0000198C
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}
	}
}
