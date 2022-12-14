using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns1;

namespace ns0
{
	// Token: 0x02000046 RID: 70
	internal sealed class Class43 : DataGridViewTextBoxCell
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x00003247 File Offset: 0x00001447
		public Class43()
		{
			this.int_0 = 15;
			this.int_1 = 0;
			this.bool_0 = false;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00003265 File Offset: 0x00001465
		public override object Clone()
		{
			Class43 @class = (Class43)base.Clone();
			@class.int_0 = this.int_0;
			@class.int_1 = this.int_1;
			return @class;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000328A File Offset: 0x0000148A
		protected internal void vmethod_0()
		{
			this.bool_0 = false;
			base.Style.Padding = this.padding_0;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000032A4 File Offset: 0x000014A4
		protected internal void vmethod_1()
		{
			this.bool_0 = true;
			this.padding_0 = base.Style.Padding;
			this.vmethod_2();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0005644C File Offset: 0x0005464C
		protected internal void vmethod_2()
		{
			if (!this.bool_0)
			{
				return;
			}
			int num = this.method_0();
			Padding padding = this.padding_0;
			Size preferredSize;
			using (Graphics graphics = this.method_1().treeGridView_0.CreateGraphics())
			{
				preferredSize = this.GetPreferredSize(graphics, base.InheritedStyle, base.RowIndex, new Size(0, 0));
			}
			Image image = this.method_1().method_4();
			if (image != null)
			{
				this.int_2 = image.Width + 2;
				this.int_3 = image.Height + 2;
			}
			else
			{
				this.int_2 = this.int_0;
				this.int_3 = 0;
			}
			if (preferredSize.Height < this.int_3)
			{
				base.Style.Padding = new Padding(padding.Left + num * 20 + this.int_2 + 5, padding.Top + this.int_3 / 2, padding.Right, padding.Bottom + this.int_3 / 2);
				this.int_4 = 2;
			}
			else
			{
				base.Style.Padding = new Padding(padding.Left + num * 20 + this.int_2 + 5, padding.Top, padding.Right, padding.Bottom);
			}
			this.int_1 = (num - 1) * this.int_0 + this.int_2 + 5;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000565B4 File Offset: 0x000547B4
		public int method_0()
		{
			Class48 @class = this.method_1();
			if (@class != null)
			{
				return @class.method_8();
			}
			return -1;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000032C4 File Offset: 0x000014C4
		protected int vmethod_3()
		{
			return (this.method_0() - 1) * 20 + 5;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000565D4 File Offset: 0x000547D4
		protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
		{
			Class48 @class = this.method_1();
			if (@class == null)
			{
				return;
			}
			Image image = @class.method_4();
			if (this.int_3 == 0 && image != null)
			{
				this.vmethod_2();
			}
			base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
			Rectangle rectangle = new Rectangle(cellBounds.X + this.vmethod_3(), cellBounds.Y, 20, cellBounds.Height - 1);
			int num = rectangle.Width / 2;
			this.method_0();
			if (image != null)
			{
				Point point;
				if (this.int_3 > cellBounds.Height)
				{
					point = new Point(rectangle.X + this.int_0, cellBounds.Y + this.int_4);
				}
				else
				{
					point = new Point(rectangle.X + this.int_0, cellBounds.Height / 2 - this.int_3 / 2 + cellBounds.Y);
				}
				GraphicsContainer container = graphics.BeginContainer();
				graphics.SetClip(cellBounds);
				graphics.DrawImageUnscaled(image, point);
				graphics.EndContainer(container);
			}
			if (@class.treeGridView_0.method_6())
			{
				using (Pen pen = new Pen(SystemBrushes.ControlDark, 1f))
				{
					pen.DashStyle = DashStyle.Dot;
					bool flag = @class.method_12();
					bool flag2 = @class.method_11();
					if (@class.method_8() == 1)
					{
						if (flag2 && flag)
						{
							graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2, rectangle.Right, cellBounds.Top + cellBounds.Height / 2);
						}
						else if (flag)
						{
							graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2, rectangle.Right, cellBounds.Top + cellBounds.Height / 2);
							graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2);
						}
						else if (flag2)
						{
							graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2, rectangle.Right, cellBounds.Top + cellBounds.Height / 2);
							graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2, rectangle.X + 4, cellBounds.Bottom);
						}
						else
						{
							graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2, rectangle.Right, cellBounds.Top + cellBounds.Height / 2);
							graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top, rectangle.X + 4, cellBounds.Bottom);
						}
					}
					else
					{
						if (flag)
						{
							graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2, rectangle.Right, cellBounds.Top + cellBounds.Height / 2);
							graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2);
						}
						else
						{
							graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top + cellBounds.Height / 2, rectangle.Right, cellBounds.Top + cellBounds.Height / 2);
							graphics.DrawLine(pen, rectangle.X + 4, cellBounds.Top, rectangle.X + 4, cellBounds.Bottom);
						}
						Class48 class2 = @class.method_9();
						int num2 = rectangle.X + 4 - 20;
						while (!class2.bool_1)
						{
							if (class2.vmethod_2() && !class2.method_12())
							{
								graphics.DrawLine(pen, num2, cellBounds.Top, num2, cellBounds.Bottom);
							}
							class2 = class2.method_9();
							num2 -= 20;
						}
					}
				}
			}
			if (@class.vmethod_2() || @class.treeGridView_0.method_4())
			{
				Bitmap image2;
				if (@class.bool_0)
				{
					image2 = new Bitmap(Application.StartupPath + "\\Symbols\\Menu\\Minus.png");
					graphics.DrawImage(image2, rectangle.X, rectangle.Y + rectangle.Height / 2 - 4, 10, 10);
					return;
				}
				image2 = new Bitmap(Application.StartupPath + "\\Symbols\\Menu\\Plus.png");
				graphics.DrawImage(image2, rectangle.X, rectangle.Y + rectangle.Height / 2 - 4, 10, 10);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00056AB0 File Offset: 0x00054CB0
		protected override void OnMouseUp(DataGridViewCellMouseEventArgs e)
		{
			base.OnMouseUp(e);
			Class48 @class = this.method_1();
			if (@class != null)
			{
				@class.treeGridView_0.bool_2 = false;
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00056ADC File Offset: 0x00054CDC
		protected override void OnMouseDown(DataGridViewCellMouseEventArgs e)
		{
			if (e.Location.X > base.InheritedStyle.Padding.Left)
			{
				base.OnMouseDown(e);
				return;
			}
			Class48 @class = this.method_1();
			if (@class != null)
			{
				@class.treeGridView_0.bool_2 = true;
				if (@class.bool_0)
				{
					@class.vmethod_3();
					return;
				}
				@class.vmethod_4();
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000032D3 File Offset: 0x000014D3
		public Class48 method_1()
		{
			return base.OwningRow as Class48;
		}

		// Token: 0x040000A2 RID: 162
		private int int_0;

		// Token: 0x040000A3 RID: 163
		private int int_1;

		// Token: 0x040000A4 RID: 164
		internal bool bool_0;

		// Token: 0x040000A5 RID: 165
		private Padding padding_0;

		// Token: 0x040000A6 RID: 166
		private int int_2;

		// Token: 0x040000A7 RID: 167
		private int int_3;

		// Token: 0x040000A8 RID: 168
		private int int_4;
	}
}
