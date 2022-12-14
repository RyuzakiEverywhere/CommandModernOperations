using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using ns5;

namespace ns4
{
	// Token: 0x02000DC7 RID: 3527
	internal sealed class Class2451 : ComboBox
	{
		// Token: 0x060065DD RID: 26077 RVA: 0x00383538 File Offset: 0x00381738
		public Class2451()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.BackColor = Color.Transparent;
			base.DrawMode = DrawMode.OwnerDrawFixed;
			this.DoubleBuffered = true;
			base.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Font = new Font(Client.font_1.FontFamily, 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.stringFormat_0 = new StringFormat(StringFormatFlags.NoWrap, 0);
			base.UpdateStyles();
		}

		// Token: 0x060065DE RID: 26078 RVA: 0x003835B0 File Offset: 0x003817B0
		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			try
			{
				using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(e.Graphics.ClipBounds, Color.FromArgb(48, 48, 48), Color.FromArgb(64, 64, 64), 270f))
				{
					using (SolidBrush solidBrush = new SolidBrush(((e.State & DrawItemState.Selected) != DrawItemState.None) ? Color.White : Color.FromArgb(189, 189, 189)))
					{
						using (Font font = new Font(this.Font.Name, this.Font.Size + 2f))
						{
							graphics.FillRectangle(linearGradientBrush, e.Bounds);
							if (e.Index != -1)
							{
								graphics.DrawString(base.GetItemText(RuntimeHelpers.GetObjectValue(base.Items[e.Index])), font, solidBrush, e.Bounds, Class2450.smethod_3(StringAlignment.Near, StringAlignment.Center));
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060065DF RID: 26079 RVA: 0x003836F8 File Offset: 0x003818F8
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			Rectangle rect = new Rectangle(0, 0, base.Width - 1, base.Height - 1);
			using (Pen pen = new Pen(Color.FromArgb(20, Color.White)))
			{
				using (SolidBrush solidBrush = new SolidBrush(Color.FromArgb(31, 31, 31)))
				{
					using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(base.Width - 29, 0, 30, base.Height - 1), Color.FromArgb(48, 48, 48), Color.FromArgb(64, 64, 64), 270f))
					{
						Class2450.smethod_0(graphics, solidBrush, rect, 1, true, true, true, true);
						Class2450.smethod_0(graphics, linearGradientBrush, new Rectangle(base.Width - 29, 0, 30, base.Height - 1), 1, false, true, false, true);
						graphics.DrawLine(pen, base.Width - 28, 1, base.Width - 28 + base.Width, 1);
						Class2450.smethod_1(graphics, Color.FromArgb(22, 22, 22), 1f, rect, 2, true, true, true, true);
					}
				}
			}
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Class2450.smethod_2(graphics, Color.FromArgb(192, 192, 192), 2, new Point(base.Width - 20, 10), new Point(base.Width - 16, 14), new Point(base.Width - 16, 14), new Point(base.Width - 12, 10), new Point(base.Width - 16, 15), new Point(base.Width - 16, 14));
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			using (SolidBrush solidBrush2 = new SolidBrush(Color.FromArgb(168, 168, 168)))
			{
				using (Font font = new Font(this.Font.Name, this.Font.Size + 2f))
				{
					graphics.DrawString(this.Text, font, solidBrush2, new Rectangle(3, 1, base.Width - 27, base.Height - 1), this.stringFormat_0);
				}
			}
		}

		// Token: 0x04003A38 RID: 14904
		private StringFormat stringFormat_0;
	}
}
