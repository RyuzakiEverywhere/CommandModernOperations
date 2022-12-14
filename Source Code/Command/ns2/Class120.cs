using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns8;

namespace ns2
{
	// Token: 0x020000CC RID: 204
	internal sealed class Class120 : NumericUpDown
	{
		// Token: 0x0600047C RID: 1148 RVA: 0x000059AF File Offset: 0x00003BAF
		public static StringFormat smethod_0(StringAlignment Horizontal = StringAlignment.Center, StringAlignment Vertical = StringAlignment.Center)
		{
			return new StringFormat
			{
				Alignment = Horizontal,
				LineAlignment = Vertical
			};
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0006743C File Offset: 0x0006563C
		public static GraphicsPath smethod_1(Rectangle r, int Curve, bool TopLeft = true, bool TopRight = true, bool BottomLeft = true, bool BottomRight = true)
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

		// Token: 0x0600047E RID: 1150 RVA: 0x00067588 File Offset: 0x00065788
		public Class120()
		{
			this.BackColor = Class129.smethod_6();
			this.ForeColor = Class129.smethod_11();
			base.Padding = new Padding(2, 2, 2, 2);
			base.BorderStyle = BorderStyle.None;
			this.BackColor = Class129.smethod_4();
			using (IEnumerator enumerator = base.Controls.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class120.Class121 @class = new Class120.Class121();
					@class.class120_0 = this;
					@class.control_0 = (Control)enumerator.Current;
					if (!(@class.control_0 is TextBox))
					{
						typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty, null, @class.control_0, new object[]
						{
							true
						});
						@class.control_0.Paint += @class.method_0;
					}
				}
			}
		}

		// Token: 0x020000CD RID: 205
		[CompilerGenerated]
		private sealed class Class121
		{
			// Token: 0x06000480 RID: 1152 RVA: 0x00067680 File Offset: 0x00065880
			internal void method_0(object sender, PaintEventArgs e)
			{
				Graphics graphics = e.Graphics;
				int height = this.control_0.Height;
				int num = this.control_0.Width;
				num -= 2;
				Graphics graphics2 = e.Graphics;
				graphics2.Clear(Color.Transparent);
				Rectangle rect = new Rectangle(0, 0, num, height);
				num += 5;
				using (SolidBrush solidBrush = new SolidBrush(Color.FromArgb(31, 31, 31)))
				{
					using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, Color.FromArgb(48, 48, 48), Color.FromArgb(64, 64, 64), 270f))
					{
						using (Pen pen = new Pen(Color.FromArgb(22, 22, 22)))
						{
							using (Pen pen2 = new Pen(Color.FromArgb(20, Color.White)))
							{
								graphics2.FillRectangle(solidBrush, rect);
								graphics2.FillPath(linearGradientBrush, Class120.smethod_1(new Rectangle(num - 25, 0, 24, height - 1), 2, true, true, true, true));
								graphics2.DrawLine(pen, new Point(num - 25, 1), new Point(num - 25, height - 2));
								graphics2.DrawLine(pen, new Point(num - 25, 13), new Point(num - 1, 13));
								graphics2.DrawLine(pen2, num - 24, 1, num - 24 + num, 1);
							}
						}
					}
				}
				graphics2.SmoothingMode = SmoothingMode.AntiAlias;
				using (GraphicsPath graphicsPath = new GraphicsPath())
				{
					using (SolidBrush solidBrush2 = new SolidBrush((this.class120_0.Value != this.class120_0.Maximum) ? Color.FromArgb(192, 192, 192) : Color.FromArgb(22, 22, 22)))
					{
						graphicsPath.AddLine(num - 17, 9, num - 2, 9);
						graphicsPath.AddLine(num - 9, 9, num - 13, 4);
						graphicsPath.CloseFigure();
						graphics2.FillPath(solidBrush2, graphicsPath);
					}
				}
				using (GraphicsPath graphicsPath2 = new GraphicsPath())
				{
					using (SolidBrush solidBrush3 = new SolidBrush((this.class120_0.Value > this.class120_0.Minimum) ? Color.FromArgb(192, 192, 192) : Color.FromArgb(22, 22, 22)))
					{
						graphicsPath2.AddLine(num - 17, 17, num - 2, 17);
						graphicsPath2.AddLine(num - 9, 17, num - 13, 22);
						graphicsPath2.CloseFigure();
						graphics2.FillPath(solidBrush3, graphicsPath2);
					}
				}
				graphics2.SmoothingMode = SmoothingMode.Default;
				using (SolidBrush solidBrush4 = new SolidBrush(Color.FromArgb(207, 207, 207)))
				{
					graphics2.DrawString(this.class120_0.Value.ToString(), this.class120_0.Font, solidBrush4, new Rectangle(0, 0, num - 18, height), Class120.smethod_0(StringAlignment.Center, StringAlignment.Center));
				}
				using (Pen pen3 = new Pen(Color.FromArgb(22, 22, 22)))
				{
					graphics2.DrawRectangle(pen3, rect);
				}
			}

			// Token: 0x0400035F RID: 863
			public Control control_0;

			// Token: 0x04000360 RID: 864
			public Class120 class120_0;
		}
	}
}
