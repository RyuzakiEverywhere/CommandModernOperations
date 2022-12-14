using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns3;

namespace ns2
{
	// Token: 0x020000B8 RID: 184
	internal sealed class Class107
	{
		// Token: 0x060003E8 RID: 1000 RVA: 0x00005429 File Offset: 0x00003629
		[CompilerGenerated]
		public Rectangle method_0()
		{
			return this.rectangle_0;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00005431 File Offset: 0x00003631
		[CompilerGenerated]
		public void method_1(Rectangle rectangle_1)
		{
			this.rectangle_0 = rectangle_1;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000543A File Offset: 0x0000363A
		[CompilerGenerated]
		public Cursor method_2()
		{
			return this.cursor_0;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00005442 File Offset: 0x00003642
		[CompilerGenerated]
		private void method_3(Cursor cursor_1)
		{
			this.cursor_0 = cursor_1;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000654EC File Offset: 0x000636EC
		public Class107(Control control_2, Control control_3, Enum14 enum14_1)
		{
			this.control_0 = control_2;
			this.control_1 = control_3;
			this.enum14_0 = enum14_1;
			Enum14 @enum = this.enum14_0;
			if (@enum <= Enum14.const_1)
			{
				this.method_3(Cursors.SizeWE);
				return;
			}
			if (@enum - Enum14.const_2 > 1)
			{
				return;
			}
			this.method_3(Cursors.SizeNS);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000544B File Offset: 0x0000364B
		public void method_4()
		{
			this.form2_0 = new Form2(Color.Black, 0.6);
			this.form2_0.Visible = true;
			this.method_6(new Point(0, 0));
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000547F File Offset: 0x0000367F
		public void method_5()
		{
			this.form2_0.Visible = false;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00065540 File Offset: 0x00063740
		public void method_6(Point point_0)
		{
			Rectangle bounds = new Rectangle(this.method_0().Location, this.method_0().Size);
			switch (this.enum14_0)
			{
			case Enum14.const_0:
			{
				int num = Math.Max(bounds.Location.X - point_0.X, this.int_0);
				if (this.int_1 != 0 && num > this.int_1)
				{
					num = this.int_1;
				}
				bounds.Location = new Point(num, bounds.Location.Y);
				break;
			}
			case Enum14.const_1:
			{
				int num2 = Math.Max(bounds.Location.X - point_0.X, this.int_0);
				if (this.int_1 != 0 && num2 > this.int_1)
				{
					num2 = this.int_1;
				}
				bounds.Location = new Point(num2, bounds.Location.Y);
				break;
			}
			case Enum14.const_2:
			{
				int num3 = Math.Max(bounds.Location.Y - point_0.Y, this.int_0);
				if (this.int_1 != 0 && num3 > this.int_1)
				{
					num3 = this.int_1;
				}
				bounds.Location = new Point(bounds.Location.X, num3);
				break;
			}
			case Enum14.const_3:
			{
				int num4 = Math.Max(bounds.Location.Y - point_0.Y, this.int_0);
				if (this.int_1 != 0 && num4 > this.int_1)
				{
					int num3 = this.int_1;
				}
				bounds.Location = new Point(bounds.Location.X, num4);
				break;
			}
			}
			this.form2_0.Bounds = bounds;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00065718 File Offset: 0x00063918
		public void method_7(Point point_0)
		{
			switch (this.enum14_0)
			{
			case Enum14.const_0:
				this.control_1.Width += point_0.X;
				break;
			case Enum14.const_1:
				this.control_1.Width -= point_0.X;
				break;
			case Enum14.const_2:
				this.control_1.Height += point_0.Y;
				break;
			case Enum14.const_3:
				this.control_1.Height -= point_0.Y;
				break;
			}
			this.method_8();
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000657B4 File Offset: 0x000639B4
		public void method_8()
		{
			Rectangle rectangle = this.control_0.RectangleToScreen(this.control_1.Bounds);
			switch (this.enum14_0)
			{
			case Enum14.const_0:
				this.method_1(new Rectangle(rectangle.Left - 2, rectangle.Top, 5, rectangle.Height));
				this.int_1 = rectangle.Right - 2 - this.control_1.MinimumSize.Width;
				return;
			case Enum14.const_1:
				this.method_1(new Rectangle(rectangle.Right - 2, rectangle.Top, 5, rectangle.Height));
				this.int_0 = rectangle.Left - 2 + this.control_1.MinimumSize.Width;
				return;
			case Enum14.const_2:
				this.method_1(new Rectangle(rectangle.Left, rectangle.Top - 2, rectangle.Width, 5));
				this.int_1 = rectangle.Bottom - 2 - this.control_1.MinimumSize.Height;
				return;
			case Enum14.const_3:
				this.method_1(new Rectangle(rectangle.Left, rectangle.Bottom - 2, rectangle.Width, 5));
				this.int_0 = rectangle.Top - 2 + this.control_1.MinimumSize.Height;
				return;
			default:
				return;
			}
		}

		// Token: 0x04000313 RID: 787
		private Control control_0;

		// Token: 0x04000314 RID: 788
		private Control control_1;

		// Token: 0x04000315 RID: 789
		private Enum14 enum14_0;

		// Token: 0x04000316 RID: 790
		private int int_0;

		// Token: 0x04000317 RID: 791
		private int int_1;

		// Token: 0x04000318 RID: 792
		private Form2 form2_0;

		// Token: 0x04000319 RID: 793
		[CompilerGenerated]
		private Rectangle rectangle_0;

		// Token: 0x0400031A RID: 794
		[CompilerGenerated]
		private Cursor cursor_0;
	}
}
