using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using ns5;
using ns8;

namespace ns4
{
	// Token: 0x02000DCA RID: 3530
	internal sealed class Control9 : Control, IButtonControl
	{
		// Token: 0x06006607 RID: 26119 RVA: 0x00040750 File Offset: 0x0003E950
		public Control9()
		{
			this.int_0 = 0;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			this.BackColor = Color.Transparent;
			this.ForeColor = SystemColors.Control;
			base.UpdateStyles();
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x0004078E File Offset: 0x0003E98E
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x06006609 RID: 26121 RVA: 0x00040796 File Offset: 0x0003E996
		public void method_1(int int_1)
		{
			this.int_0 = int_1;
			base.Invalidate();
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x0600660A RID: 26122 RVA: 0x000407A5 File Offset: 0x0003E9A5
		// (set) Token: 0x0600660B RID: 26123 RVA: 0x000407AD File Offset: 0x0003E9AD
		public DialogResult DialogResult
		{
			get
			{
				return this.dialogResult_0;
			}
			set
			{
				this.dialogResult_0 = value;
			}
		}

		// Token: 0x0600660C RID: 26124 RVA: 0x00383DC4 File Offset: 0x00381FC4
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			GraphicsPath graphicsPath = new GraphicsPath();
			GraphicsPath graphicsPath2 = new GraphicsPath();
			Rectangle rectangle = new Rectangle(0, 0, base.Width - 1, base.Height - 2);
			Rectangle rectangle2 = new Rectangle(0, 1, base.Width - 1, base.Height - 2);
			if (this.method_0() > 0)
			{
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				graphicsPath = Class2450.smethod_4(rectangle, this.method_0(), true, true, true, true);
				graphicsPath2 = Class2450.smethod_4(rectangle2, this.method_0(), true, true, true, true);
			}
			else
			{
				graphicsPath.AddRectangle(rectangle);
				graphicsPath2.AddRectangle(rectangle2);
			}
			graphicsPath.CloseFigure();
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			if (!base.Enabled)
			{
				Color color = Class129.smethod_12();
				Color color2 = Class129.smethod_17();
				using (SolidBrush solidBrush = new SolidBrush(color2))
				{
					using (Pen pen = new Pen(Color.FromArgb(22, 22, 22)))
					{
						using (Pen pen2 = new Pen(Color.FromArgb(30, Color.White)))
						{
							using (SolidBrush solidBrush2 = new SolidBrush(color))
							{
								graphics.FillPath(solidBrush, graphicsPath);
								graphics.DrawPath(pen2, graphicsPath2);
								graphics.DrawPath(pen, graphicsPath);
								graphics.DrawString(this.Text, this.Font, solidBrush2, new Rectangle(0, 0, base.Width, base.Height), Class2450.smethod_3(StringAlignment.Center, StringAlignment.Center));
								goto IL_419;
							}
						}
					}
				}
			}
			switch (this.enum199_0)
			{
			case Class2450.Enum199.const_0:
				using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle, Color.FromArgb(48, 48, 48), Color.FromArgb(64, 64, 64), 270f))
				{
					using (Pen pen3 = new Pen(Color.FromArgb(22, 22, 22)))
					{
						using (Pen pen4 = new Pen(Color.FromArgb(30, Color.White)))
						{
							using (SolidBrush solidBrush3 = new SolidBrush(this.ForeColor))
							{
								graphics.FillPath(linearGradientBrush, graphicsPath);
								graphics.DrawPath(pen4, graphicsPath2);
								graphics.DrawPath(pen3, graphicsPath);
								graphics.DrawString(this.Text, this.Font, solidBrush3, new Rectangle(0, 0, base.Width, base.Height), Class2450.smethod_3(StringAlignment.Center, StringAlignment.Center));
								goto IL_419;
							}
						}
					}
				}
				break;
			case Class2450.Enum199.const_1:
				break;
			case Class2450.Enum199.const_2:
				goto IL_344;
			default:
				goto IL_419;
			}
			this.Cursor = Cursors.Hand;
			using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(rectangle, Color.FromArgb(29, 29, 29), Color.FromArgb(41, 41, 41), 270f))
			{
				using (Pen pen5 = new Pen(Color.FromArgb(22, 22, 22)))
				{
					using (Pen pen6 = new Pen(Color.FromArgb(30, Color.White)))
					{
						using (SolidBrush solidBrush4 = new SolidBrush(this.ForeColor))
						{
							graphics.FillPath(linearGradientBrush2, graphicsPath);
							graphics.DrawPath(pen6, graphicsPath2);
							graphics.DrawPath(pen5, graphicsPath);
							graphics.DrawString(this.Text, this.Font, solidBrush4, new Rectangle(0, 0, base.Width, base.Height), Class2450.smethod_3(StringAlignment.Center, StringAlignment.Center));
							goto IL_419;
						}
					}
				}
			}
			IL_344:
			using (LinearGradientBrush linearGradientBrush3 = new LinearGradientBrush(rectangle, Color.FromArgb(48, 48, 48), Color.FromArgb(64, 64, 64), 270f))
			{
				using (Pen pen7 = new Pen(Color.FromArgb(22, 22, 22)))
				{
					using (Pen pen8 = new Pen(Color.FromArgb(30, Color.White)))
					{
						using (SolidBrush solidBrush5 = new SolidBrush(this.ForeColor))
						{
							graphics.FillPath(linearGradientBrush3, graphicsPath);
							graphics.DrawPath(pen8, graphicsPath2);
							graphics.DrawPath(pen7, graphicsPath);
							graphics.DrawString(this.Text, this.Font, solidBrush5, new Rectangle(0, 0, base.Width, base.Height), Class2450.smethod_3(StringAlignment.Center, StringAlignment.Center));
						}
					}
				}
			}
			IL_419:
			graphicsPath.Dispose();
		}

		// Token: 0x0600660D RID: 26125 RVA: 0x000407B6 File Offset: 0x0003E9B6
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			this.enum199_0 = Class2450.Enum199.const_1;
			base.Invalidate();
		}

		// Token: 0x0600660E RID: 26126 RVA: 0x000407CC File Offset: 0x0003E9CC
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.enum199_0 = Class2450.Enum199.const_2;
			base.Invalidate();
		}

		// Token: 0x0600660F RID: 26127 RVA: 0x000407E2 File Offset: 0x0003E9E2
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.enum199_0 = Class2450.Enum199.const_1;
			base.Invalidate();
		}

		// Token: 0x06006610 RID: 26128 RVA: 0x000407F8 File Offset: 0x0003E9F8
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.enum199_0 = Class2450.Enum199.const_0;
			base.Invalidate();
		}

		// Token: 0x06006611 RID: 26129 RVA: 0x0000378C File Offset: 0x0000198C
		public void NotifyDefault(bool value)
		{
		}

		// Token: 0x06006612 RID: 26130 RVA: 0x0000378C File Offset: 0x0000198C
		public void PerformClick()
		{
		}

		// Token: 0x04003A46 RID: 14918
		private Class2450.Enum199 enum199_0;

		// Token: 0x04003A47 RID: 14919
		private int int_0;

		// Token: 0x04003A48 RID: 14920
		private DialogResult dialogResult_0;
	}
}
