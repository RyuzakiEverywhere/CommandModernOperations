using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns8;

namespace ns2
{
	// Token: 0x020000CE RID: 206
	internal sealed class Class122 : RadioButton
	{
		// Token: 0x06000481 RID: 1153 RVA: 0x000059C4 File Offset: 0x00003BC4
		public Class122()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000059D8 File Offset: 0x00003BD8
		private void method_0(Enum17 enum17_1)
		{
			if (this.enum17_0 != enum17_1)
			{
				this.enum17_0 = enum17_1;
				base.Invalidate();
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00067A28 File Offset: 0x00065C28
		protected override void OnMouseMove(MouseEventArgs mea)
		{
			base.OnMouseMove(mea);
			if (this.bool_0)
			{
				return;
			}
			if (mea.Button != MouseButtons.Left)
			{
				this.method_0(Enum17.const_1);
				return;
			}
			if (base.ClientRectangle.Contains(mea.Location))
			{
				this.method_0(Enum17.const_2);
				return;
			}
			this.method_0(Enum17.const_1);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00067A80 File Offset: 0x00065C80
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (!base.ClientRectangle.Contains(e.Location))
			{
				return;
			}
			this.method_0(Enum17.const_2);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000059F0 File Offset: 0x00003BF0
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			if (this.bool_0)
			{
				return;
			}
			this.method_0(Enum17.const_0);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00005A09 File Offset: 0x00003C09
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			if (this.bool_0)
			{
				return;
			}
			this.method_0(Enum17.const_0);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00067AB4 File Offset: 0x00065CB4
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
				this.method_0(Enum17.const_0);
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000056D2 File Offset: 0x000038D2
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			base.Invalidate();
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00067AF0 File Offset: 0x00065CF0
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			this.bool_0 = false;
			Point position = Cursor.Position;
			if (!base.ClientRectangle.Contains(position))
			{
				this.method_0(Enum17.const_0);
				return;
			}
			this.method_0(Enum17.const_1);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00067B34 File Offset: 0x00065D34
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 0, base.ClientSize.Width, base.ClientSize.Height);
			int int_ = Class130.int_5;
			Color color = Class129.smethod_11();
			Color color2 = Class129.smethod_11();
			Color color3 = Class129.smethod_8();
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
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			using (Pen pen = new Pen(color2))
			{
				Rectangle rect2 = new Rectangle(0, rect.Height / 2 - int_ / 2, int_, int_);
				graphics.DrawEllipse(pen, rect2);
			}
			if (base.Checked)
			{
				using (SolidBrush solidBrush2 = new SolidBrush(color3))
				{
					Rectangle rect3 = new Rectangle(3, rect.Height / 2 - (int_ - 7) / 2 - 1, int_ - 6, int_ - 6);
					graphics.FillEllipse(solidBrush2, rect3);
				}
			}
			graphics.SmoothingMode = SmoothingMode.Default;
			using (SolidBrush solidBrush3 = new SolidBrush(color))
			{
				StringFormat format = new StringFormat
				{
					LineAlignment = StringAlignment.Center,
					Alignment = StringAlignment.Near
				};
				Rectangle r = new Rectangle(int_ + 4, 0, rect.Width - int_, rect.Height);
				graphics.DrawString(this.Text, this.Font, solidBrush3, r, format);
			}
		}

		// Token: 0x04000361 RID: 865
		private Enum17 enum17_0;

		// Token: 0x04000362 RID: 866
		private bool bool_0;
	}
}
