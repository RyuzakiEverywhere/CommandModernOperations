using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns3;
using ns8;

namespace ns2
{
	// Token: 0x020000D0 RID: 208
	internal sealed class Control1 : Control
	{
		// Token: 0x0600048C RID: 1164 RVA: 0x00067D38 File Offset: 0x00065F38
		[CompilerGenerated]
		public void method_0(EventHandler<EventArgs4> eventHandler_1)
		{
			EventHandler<EventArgs4> eventHandler = this.eventHandler_0;
			EventHandler<EventArgs4> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs4> value = (EventHandler<EventArgs4>)Delegate.Combine(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs4>>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00005A40 File Offset: 0x00003C40
		public void method_1(Enum18 enum18_1)
		{
			this.enum18_0 = enum18_1;
			this.method_13();
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00005A4F File Offset: 0x00003C4F
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00067D70 File Offset: 0x00065F70
		[Category("Behavior")]
		[Description("The value that the scroll thumb position represents.")]
		[DefaultValue(0)]
		public int Value
		{
			get
			{
				return this.int_0;
			}
			set
			{
				if (value < this.method_2())
				{
					value = this.method_2();
				}
				int num = this.method_3() - this.method_5();
				if (value > num)
				{
					value = num;
				}
				if (this.int_0 == value)
				{
					return;
				}
				this.int_0 = value;
				this.method_14(true);
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0(this, new EventArgs4(this.Value));
				}
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00005A57 File Offset: 0x00003C57
		public int method_2()
		{
			return this.int_1;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00005A5F File Offset: 0x00003C5F
		public int method_3()
		{
			return this.int_2;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00005A67 File Offset: 0x00003C67
		public void method_4(int int_5)
		{
			this.int_2 = int_5;
			this.method_13();
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00005A76 File Offset: 0x00003C76
		public int method_5()
		{
			return this.int_3;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00005A7E File Offset: 0x00003C7E
		public void method_6(int int_5)
		{
			this.int_3 = int_5;
			this.method_13();
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00005A8D File Offset: 0x00003C8D
		public bool method_7()
		{
			return base.Visible;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00005A95 File Offset: 0x00003C95
		public void method_8(bool bool_7)
		{
			if (base.Visible == bool_7)
			{
				return;
			}
			base.Visible = bool_7;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00067DDC File Offset: 0x00065FDC
		public Control1()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
			base.SetStyle(ControlStyles.Selectable, false);
			this.timer_0 = new Timer();
			this.timer_0.Interval = 1;
			this.timer_0.Tick += this.timer_0_Tick;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00005AA8 File Offset: 0x00003CA8
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.method_13();
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00067E40 File Offset: 0x00066040
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (this.rectangle_1.Contains(e.Location) && e.Button == MouseButtons.Left)
			{
				this.bool_6 = true;
				this.point_0 = e.Location;
				if (this.enum18_0 == Enum18.const_0)
				{
					this.int_4 = this.rectangle_1.Top;
				}
				else
				{
					this.int_4 = this.rectangle_1.Left;
				}
				base.Invalidate();
				return;
			}
			if (this.rectangle_2.Contains(e.Location) && e.Button == MouseButtons.Left)
			{
				this.bool_4 = true;
				this.timer_0.Enabled = true;
				base.Invalidate();
				return;
			}
			if (this.rectangle_3.Contains(e.Location) && e.Button == MouseButtons.Left)
			{
				this.bool_5 = true;
				this.timer_0.Enabled = true;
				base.Invalidate();
				return;
			}
			if (this.rectangle_0.Contains(e.Location) && e.Button == MouseButtons.Left)
			{
				if (this.enum18_0 == Enum18.const_0)
				{
					Rectangle rectangle = new Rectangle(this.rectangle_1.Left, this.rectangle_0.Top, this.rectangle_1.Width, this.rectangle_0.Height);
					if (!rectangle.Contains(e.Location))
					{
						return;
					}
				}
				else if (this.enum18_0 == Enum18.const_1)
				{
					Rectangle rectangle2 = new Rectangle(this.rectangle_0.Left, this.rectangle_1.Top, this.rectangle_0.Width, this.rectangle_1.Height);
					if (!rectangle2.Contains(e.Location))
					{
						return;
					}
				}
				if (this.enum18_0 == Enum18.const_0)
				{
					int num = e.Location.Y;
					num -= this.rectangle_2.Bottom - 1;
					num -= this.rectangle_1.Height / 2;
					this.method_10(num);
				}
				else
				{
					int num2 = e.Location.X;
					num2 -= this.rectangle_2.Right - 1;
					num2 -= this.rectangle_1.Width / 2;
					this.method_10(num2);
				}
				this.bool_6 = true;
				this.point_0 = e.Location;
				this.bool_0 = true;
				if (this.enum18_0 == Enum18.const_0)
				{
					this.int_4 = this.rectangle_1.Top;
				}
				else
				{
					this.int_4 = this.rectangle_1.Left;
				}
				base.Invalidate();
				return;
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00005AB7 File Offset: 0x00003CB7
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			this.bool_6 = false;
			this.bool_3 = false;
			this.bool_4 = false;
			this.bool_5 = false;
			base.Invalidate();
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000680B4 File Offset: 0x000662B4
		protected override void OnMouseMove(MouseEventArgs mea)
		{
			base.OnMouseMove(mea);
			if (!this.bool_6)
			{
				bool flag = this.rectangle_1.Contains(mea.Location);
				if (this.bool_0 != flag)
				{
					this.bool_0 = flag;
					base.Invalidate();
				}
				bool flag2 = this.rectangle_2.Contains(mea.Location);
				if (this.bool_1 != flag2)
				{
					this.bool_1 = flag2;
					base.Invalidate();
				}
				bool flag3 = this.rectangle_3.Contains(mea.Location);
				if (this.bool_2 != flag3)
				{
					this.bool_2 = flag3;
					base.Invalidate();
				}
			}
			if (this.bool_6)
			{
				if (mea.Button != MouseButtons.Left)
				{
					this.OnMouseUp(null);
					return;
				}
				Point point = new Point(mea.Location.X - this.point_0.X, mea.Location.Y - this.point_0.Y);
				if (this.enum18_0 == Enum18.const_0)
				{
					int int_ = this.int_4 - this.rectangle_0.Top + point.Y;
					this.method_10(int_);
				}
				else if (this.enum18_0 == Enum18.const_1)
				{
					int int_2 = this.int_4 - this.rectangle_0.Left + point.X;
					this.method_10(int_2);
				}
				this.method_13();
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00005AE2 File Offset: 0x00003CE2
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.bool_0 = false;
			this.bool_1 = false;
			this.bool_2 = false;
			base.Invalidate();
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00005B06 File Offset: 0x00003D06
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (!this.bool_4 && !this.bool_5)
			{
				this.timer_0.Enabled = false;
				return;
			}
			if (this.bool_4)
			{
				this.method_11(-1);
				return;
			}
			if (this.bool_5)
			{
				this.method_11(1);
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00005B44 File Offset: 0x00003D44
		public void method_9(int int_5)
		{
			this.Value = int_5;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00068208 File Offset: 0x00066408
		public void method_10(int int_5)
		{
			int num = (this.enum18_0 == Enum18.const_0) ? (this.rectangle_0.Height - this.rectangle_1.Height) : (this.rectangle_0.Width - this.rectangle_1.Width);
			float num2 = (float)int_5 / (float)num;
			int num3 = this.method_3() - this.method_5();
			int value = (int)(num2 * (float)num3);
			this.Value = value;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00068270 File Offset: 0x00066470
		public void method_11(int int_5)
		{
			int int_6 = this.Value + int_5;
			this.method_9(int_6);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00068290 File Offset: 0x00066490
		public void method_12(int int_5)
		{
			int int_6 = ((this.enum18_0 == Enum18.const_0) ? (this.rectangle_1.Top - this.rectangle_0.Top) : (this.rectangle_1.Left - this.rectangle_0.Left)) - int_5;
			this.method_10(int_6);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x000682E4 File Offset: 0x000664E4
		public void method_13()
		{
			Rectangle clientRectangle = base.ClientRectangle;
			if (this.enum18_0 == Enum18.const_0)
			{
				this.rectangle_2 = new Rectangle(clientRectangle.Left, clientRectangle.Top, Class130.int_2, Class130.int_2);
				this.rectangle_3 = new Rectangle(clientRectangle.Left, clientRectangle.Bottom - Class130.int_2, Class130.int_2, Class130.int_2);
			}
			else if (this.enum18_0 == Enum18.const_1)
			{
				this.rectangle_2 = new Rectangle(clientRectangle.Left, clientRectangle.Top, Class130.int_2, Class130.int_2);
				this.rectangle_3 = new Rectangle(clientRectangle.Right - Class130.int_2, clientRectangle.Top, Class130.int_2, Class130.int_2);
			}
			if (this.enum18_0 == Enum18.const_0)
			{
				this.rectangle_0 = new Rectangle(clientRectangle.Left, clientRectangle.Top + Class130.int_2, clientRectangle.Width, clientRectangle.Height - Class130.int_2 * 2);
			}
			else if (this.enum18_0 == Enum18.const_1)
			{
				this.rectangle_0 = new Rectangle(clientRectangle.Left + Class130.int_2, clientRectangle.Top, clientRectangle.Width - Class130.int_2 * 2, clientRectangle.Height);
			}
			this.method_14(false);
			base.Invalidate();
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00068430 File Offset: 0x00066630
		private void method_14(bool forceRefresh = false)
		{
			if (this.method_5() >= this.method_3())
			{
				return;
			}
			int num = this.method_3() - this.method_5();
			if (this.Value > num)
			{
				this.Value = num;
			}
			this.float_0 = (float)this.method_5() / (float)this.method_3();
			int num2 = this.method_3() - this.method_5();
			float num3 = (float)this.Value / (float)num2;
			if (this.enum18_0 == Enum18.const_0)
			{
				int num4 = (int)((float)this.rectangle_0.Height * this.float_0);
				if (num4 < Class130.int_3)
				{
					num4 = Class130.int_3;
				}
				int num5 = (int)((float)(this.rectangle_0.Height - num4) * num3);
				this.rectangle_1 = new Rectangle(this.rectangle_0.Left + 3, this.rectangle_0.Top + num5, Class130.int_1 - 6, num4);
			}
			else if (this.enum18_0 == Enum18.const_1)
			{
				int num6 = (int)((float)this.rectangle_0.Width * this.float_0);
				if (num6 < Class130.int_3)
				{
					num6 = Class130.int_3;
				}
				int num7 = (int)((float)(this.rectangle_0.Width - num6) * num3);
				this.rectangle_1 = new Rectangle(this.rectangle_0.Left + num7, this.rectangle_0.Top + 3, num6, Class130.int_1 - 6);
			}
			if (forceRefresh)
			{
				base.Invalidate();
				base.Update();
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00068588 File Offset: 0x00066788
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Bitmap bitmap = this.bool_1 ? Class98.smethod_3() : Class98.smethod_4();
			if (this.bool_4)
			{
				bitmap = Class98.smethod_1();
			}
			if (!base.Enabled)
			{
				bitmap = Class98.smethod_2();
			}
			if (this.enum18_0 == Enum18.const_0)
			{
				bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
			}
			else if (this.enum18_0 == Enum18.const_1)
			{
				bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
			}
			graphics.DrawImageUnscaled(bitmap, this.rectangle_2.Left + this.rectangle_2.Width / 2 - bitmap.Width / 2, this.rectangle_2.Top + this.rectangle_2.Height / 2 - bitmap.Height / 2);
			Bitmap bitmap2 = this.bool_2 ? Class98.smethod_3() : Class98.smethod_4();
			if (this.bool_5)
			{
				bitmap2 = Class98.smethod_1();
			}
			if (!base.Enabled)
			{
				bitmap2 = Class98.smethod_2();
			}
			if (this.enum18_0 == Enum18.const_1)
			{
				bitmap2.RotateFlip(RotateFlipType.Rotate270FlipNone);
			}
			graphics.DrawImageUnscaled(bitmap2, this.rectangle_3.Left + this.rectangle_3.Width / 2 - bitmap2.Width / 2, this.rectangle_3.Top + this.rectangle_3.Height / 2 - bitmap2.Height / 2);
			if (base.Enabled)
			{
				Color color = this.bool_0 ? Class129.smethod_15() : Class129.smethod_16();
				if (this.bool_6)
				{
					color = Class129.smethod_18();
				}
				using (SolidBrush solidBrush = new SolidBrush(color))
				{
					graphics.FillRectangle(solidBrush, this.rectangle_1);
				}
			}
		}

		// Token: 0x04000363 RID: 867
		[CompilerGenerated]
		private EventHandler<EventArgs4> eventHandler_0;

		// Token: 0x04000364 RID: 868
		private Enum18 enum18_0;

		// Token: 0x04000365 RID: 869
		private int int_0;

		// Token: 0x04000366 RID: 870
		private int int_1;

		// Token: 0x04000367 RID: 871
		private int int_2 = 100;

		// Token: 0x04000368 RID: 872
		private int int_3;

		// Token: 0x04000369 RID: 873
		private Rectangle rectangle_0;

		// Token: 0x0400036A RID: 874
		private float float_0;

		// Token: 0x0400036B RID: 875
		private Rectangle rectangle_1;

		// Token: 0x0400036C RID: 876
		private Rectangle rectangle_2;

		// Token: 0x0400036D RID: 877
		private Rectangle rectangle_3;

		// Token: 0x0400036E RID: 878
		private bool bool_0;

		// Token: 0x0400036F RID: 879
		private bool bool_1;

		// Token: 0x04000370 RID: 880
		private bool bool_2;

		// Token: 0x04000371 RID: 881
		private bool bool_3;

		// Token: 0x04000372 RID: 882
		private bool bool_4;

		// Token: 0x04000373 RID: 883
		private bool bool_5;

		// Token: 0x04000374 RID: 884
		private bool bool_6;

		// Token: 0x04000375 RID: 885
		private int int_4;

		// Token: 0x04000376 RID: 886
		private Point point_0;

		// Token: 0x04000377 RID: 887
		private Timer timer_0;
	}
}
