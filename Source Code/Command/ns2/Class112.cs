using System;
using System.Drawing;
using System.Windows.Forms;
using ns8;

namespace ns2
{
	// Token: 0x020000C2 RID: 194
	internal sealed class Class112 : CheckBox
	{
		// Token: 0x06000434 RID: 1076 RVA: 0x00005721 File Offset: 0x00003921
		public bool method_0()
		{
			return base.ThreeState;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00005729 File Offset: 0x00003929
		public void method_1(bool bool_1)
		{
			base.ThreeState = bool_1;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00005732 File Offset: 0x00003932
		public Class112()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00005746 File Offset: 0x00003946
		private void method_2(Enum17 enum17_1)
		{
			if (this.enum17_0 != enum17_1)
			{
				this.enum17_0 = enum17_1;
				base.Invalidate();
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00066060 File Offset: 0x00064260
		protected override void OnMouseMove(MouseEventArgs mea)
		{
			base.OnMouseMove(mea);
			if (this.bool_0)
			{
				return;
			}
			if (mea.Button != MouseButtons.Left)
			{
				this.method_2(Enum17.const_1);
				return;
			}
			if (base.ClientRectangle.Contains(mea.Location))
			{
				this.method_2(Enum17.const_2);
				return;
			}
			this.method_2(Enum17.const_1);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000660B8 File Offset: 0x000642B8
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (!base.ClientRectangle.Contains(e.Location))
			{
				return;
			}
			this.method_2(Enum17.const_2);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000575E File Offset: 0x0000395E
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			if (this.bool_0)
			{
				return;
			}
			this.method_2(Enum17.const_0);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00005777 File Offset: 0x00003977
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			if (this.bool_0)
			{
				return;
			}
			this.method_2(Enum17.const_0);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000660EC File Offset: 0x000642EC
		protected override void OnMouseCaptureChanged(EventArgs e)
		{
			base.OnMouseCaptureChanged(e);
			if (this.bool_0)
			{
				return;
			}
			Point position = Cursor.Position;
			if (!base.ClientRectangle.Contains(position))
			{
				this.method_2(Enum17.const_0);
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000056D2 File Offset: 0x000038D2
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			base.Invalidate();
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00066128 File Offset: 0x00064328
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			this.bool_0 = false;
			Point position = Cursor.Position;
			if (!base.ClientRectangle.Contains(position))
			{
				this.method_2(Enum17.const_0);
				return;
			}
			this.method_2(Enum17.const_1);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00005790 File Offset: 0x00003990
		protected override void OnKeyDown(KeyEventArgs ke)
		{
			base.OnKeyDown(ke);
			if (ke.KeyCode == Keys.Space)
			{
				this.bool_0 = true;
				this.method_2(Enum17.const_2);
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0006616C File Offset: 0x0006436C
		protected override void OnKeyUp(KeyEventArgs e)
		{
			base.OnKeyUp(e);
			if (e.KeyCode == Keys.Space)
			{
				this.bool_0 = false;
				Point position = Cursor.Position;
				if (!base.ClientRectangle.Contains(position))
				{
					this.method_2(Enum17.const_0);
					return;
				}
				this.method_2(Enum17.const_1);
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000661B8 File Offset: 0x000643B8
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 0, base.ClientSize.Width, base.ClientSize.Height);
			int int_ = Class130.int_4;
			Color color = Class129.smethod_11();
			Color color2 = Class129.smethod_11();
			Color color3 = Color.Transparent;
			if (base.Enabled)
			{
				if (this.Focused)
				{
					color2 = Class129.smethod_13();
					color3 = Class129.smethod_14();
				}
				if (this.enum17_0 == Enum17.const_1)
				{
					color2 = Class129.smethod_13();
					color3 = Class129.smethod_14();
				}
				else if (this.enum17_0 == Enum17.const_2)
				{
					color2 = Class129.smethod_15();
					color3 = Class129.smethod_16();
				}
			}
			else
			{
				color = Class129.smethod_12();
				color2 = Class129.smethod_15();
				color3 = Class129.smethod_16();
			}
			using (SolidBrush solidBrush = new SolidBrush(Class129.smethod_0()))
			{
				graphics.FillRectangle(solidBrush, rect);
			}
			using (Pen pen = new Pen(color2))
			{
				Rectangle rect2 = new Rectangle(0, rect.Height / 2 - int_ / 2, int_, int_);
				graphics.DrawRectangle(pen, rect2);
			}
			if (base.Checked)
			{
				if (this.method_0() && base.CheckState == CheckState.Indeterminate)
				{
					using (SolidBrush solidBrush2 = new SolidBrush(color3))
					{
						Rectangle rect3 = new Rectangle(2, rect.Height / 2 - (int_ - 4) / 2, int_ - 3, int_ - 3);
						graphics.FillRectangle(solidBrush2, rect3);
						goto IL_213;
					}
				}
				using (Pen pen2 = new Pen(Color.FromArgb(189, 189, 189), 2f))
				{
					Rectangle rectangle = new Rectangle(0, rect.Height / 2 - int_ / 2, int_, int_);
					graphics.DrawLines(pen2, new Point[]
					{
						new Point(rectangle.Left + 2, rectangle.Top + 6),
						new Point(rectangle.Left + 5, rectangle.Top + 9),
						new Point(rectangle.Left + 12, rectangle.Top + 2)
					});
				}
			}
			IL_213:
			using (new SolidBrush(color))
			{
				StringFormat stringFormat = new StringFormat();
				stringFormat.LineAlignment = StringAlignment.Center;
				stringFormat.Alignment = StringAlignment.Near;
				Rectangle bounds = new Rectangle(int_ + 4, 2, rect.Width - int_, rect.Height);
				TextRenderer.DrawText(graphics, this.Text, this.Font, bounds, color, TextFormatFlags.TextBoxControl | TextFormatFlags.WordBreak);
			}
		}

		// Token: 0x04000346 RID: 838
		private Enum17 enum17_0;

		// Token: 0x04000347 RID: 839
		private bool bool_0;
	}
}
