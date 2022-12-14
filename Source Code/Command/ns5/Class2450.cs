using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.CompilerServices;

namespace ns5
{
	// Token: 0x02000DC5 RID: 3525
	[StandardModule]
	internal sealed class Class2450
	{
		// Token: 0x060065D8 RID: 26072 RVA: 0x0004048B File Offset: 0x0003E68B
		public static void smethod_0(Graphics G, Brush B, Rectangle Rect, int Curve, bool TopLeft = true, bool TopRight = true, bool BottomLeft = true, bool BottomRight = true)
		{
			G.FillPath(B, Class2450.smethod_4(Rect, Curve, TopLeft, TopRight, BottomLeft, BottomRight));
		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x000404A3 File Offset: 0x0003E6A3
		public static void smethod_1(Graphics G, Color C, float Size, Rectangle Rect, int Curve, bool TopLeft = true, bool TopRight = true, bool BottomLeft = true, bool BottomRight = true)
		{
			G.DrawPath(new Pen(C, Size), Class2450.smethod_4(Rect, Curve, TopLeft, TopRight, BottomLeft, BottomRight));
		}

		// Token: 0x060065DA RID: 26074 RVA: 0x000404C2 File Offset: 0x0003E6C2
		public static void smethod_2(Graphics graphics_0, Color color_0, int int_0, Point point_0, Point point_1, Point point_2, Point point_3, Point point_4, Point point_5)
		{
			graphics_0.DrawLine(new Pen(color_0, (float)int_0), point_0, point_1);
			graphics_0.DrawLine(new Pen(color_0, (float)int_0), point_2, point_3);
			graphics_0.DrawLine(new Pen(color_0, (float)int_0), point_4, point_5);
		}

		// Token: 0x060065DB RID: 26075 RVA: 0x000059AF File Offset: 0x00003BAF
		public static StringFormat smethod_3(StringAlignment Horizontal = StringAlignment.Center, StringAlignment Vertical = StringAlignment.Center)
		{
			return new StringFormat
			{
				Alignment = Horizontal,
				LineAlignment = Vertical
			};
		}

		// Token: 0x060065DC RID: 26076 RVA: 0x0006743C File Offset: 0x0006563C
		public static GraphicsPath smethod_4(Rectangle r, int Curve, bool TopLeft = true, bool TopRight = true, bool BottomLeft = true, bool BottomRight = true)
		{
			GraphicsPath graphicsPath = new GraphicsPath(FillMode.Winding);
			if (TopLeft)
			{
				graphicsPath.AddArc(r.X, r.Y, Curve, Curve, 180f, 90f);
			}
			else
			{
				graphicsPath.AddLine(r.X, r.Y, r.X, r.Y);
			}
			if (TopRight)
			{
				graphicsPath.AddArc(r.Right - Curve, r.Y, Curve, Curve, 270f, 90f);
			}
			else
			{
				graphicsPath.AddLine(r.Right - r.Width, r.Y, r.Width, r.Y);
			}
			if (BottomRight)
			{
				graphicsPath.AddArc(r.Right - Curve, r.Bottom - Curve, Curve, Curve, 0f, 90f);
			}
			else
			{
				graphicsPath.AddLine(r.Right, r.Bottom, r.Right, r.Bottom);
			}
			if (BottomLeft)
			{
				graphicsPath.AddArc(r.X, r.Bottom - Curve, Curve, Curve, 90f, 90f);
			}
			else
			{
				graphicsPath.AddLine(r.X, r.Bottom, r.X, r.Bottom);
			}
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x02000DC6 RID: 3526
		internal enum Enum199 : byte
		{
			// Token: 0x04003A34 RID: 14900
			const_0,
			// Token: 0x04003A35 RID: 14901
			const_1,
			// Token: 0x04003A36 RID: 14902
			const_2,
			// Token: 0x04003A37 RID: 14903
			const_3
		}
	}
}
