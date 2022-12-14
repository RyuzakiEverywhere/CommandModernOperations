using System;
using System.Drawing;
using System.Windows.Forms;
using ns8;

namespace ns3
{
	// Token: 0x020000AC RID: 172
	internal partial class Form0 : Form
	{
		// Token: 0x06000374 RID: 884 RVA: 0x00005040 File Offset: 0x00003240
		public void method_0(bool bool_1)
		{
			this.bool_0 = bool_1;
			base.Invalidate();
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000504F File Offset: 0x0000324F
		public Form0()
		{
			this.BackColor = Class129.smethod_0();
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00062CD8 File Offset: 0x00060ED8
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
			if (!this.bool_0)
			{
				return;
			}
			Graphics graphics = e.Graphics;
			using (Pen pen = new Pen(Class129.smethod_10()))
			{
				Rectangle rect = new Rectangle(base.ClientRectangle.Location, new Size(base.ClientRectangle.Width - 1, base.ClientRectangle.Height - 1));
				graphics.DrawRectangle(pen, rect);
			}
		}

		// Token: 0x040002D7 RID: 727
		private bool bool_0;
	}
}
