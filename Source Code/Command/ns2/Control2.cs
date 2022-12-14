using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns8;

namespace ns2
{
	// Token: 0x020000D1 RID: 209
	internal abstract class Control2 : Control
	{
		// Token: 0x060004A5 RID: 1189 RVA: 0x00005B4D File Offset: 0x00003D4D
		public Rectangle method_0()
		{
			return this.rectangle_0;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00005B55 File Offset: 0x00003D55
		private void method_1(Rectangle rectangle_1)
		{
			this.rectangle_0 = rectangle_1;
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, null);
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00005B73 File Offset: 0x00003D73
		public Size method_2()
		{
			return this.size_1;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00005B7B File Offset: 0x00003D7B
		public void method_3(Size size_2)
		{
			this.size_1 = size_2;
			this.method_9();
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, null);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00005B9F File Offset: 0x00003D9F
		public Point method_4()
		{
			return this.point_0;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00005BA7 File Offset: 0x00003DA7
		public int method_5()
		{
			return this.int_0;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00005BAF File Offset: 0x00003DAF
		public void method_6(int int_1)
		{
			this.int_0 = int_1;
			base.Invalidate();
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00005BBE File Offset: 0x00003DBE
		[CompilerGenerated]
		public bool method_7()
		{
			return this.bool_1;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00005BC6 File Offset: 0x00003DC6
		[CompilerGenerated]
		private void method_8(bool bool_2)
		{
			this.bool_1 = bool_2;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00068724 File Offset: 0x00066924
		protected Control2()
		{
			base.SetStyle(ControlStyles.Selectable | ControlStyles.UserMouse, true);
			Control1 control = new Control1();
			control.method_1(Enum18.const_0);
			this.control1_0 = control;
			Control1 control2 = new Control1();
			control2.method_1(Enum18.const_1);
			this.control1_1 = control2;
			base.Controls.Add(this.control1_0);
			base.Controls.Add(this.control1_1);
			this.control1_0.method_0(new EventHandler<EventArgs4>(this.method_14));
			this.control1_1.method_0(new EventHandler<EventArgs4>(this.method_15));
			this.control1_0.MouseDown += this.control1_0_MouseDown;
			this.control1_1.MouseDown += this.control1_1_MouseDown;
			this.timer_0 = new Timer();
			this.timer_0.Interval = 1;
			this.timer_0.Tick += this.timer_0_Tick;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0006881C File Offset: 0x00066A1C
		private void method_9()
		{
			if (this.control1_0.method_3() != this.method_2().Height)
			{
				this.control1_0.method_4(this.method_2().Height);
			}
			if (this.control1_1.method_3() != this.method_2().Width)
			{
				this.control1_1.method_4(this.method_2().Width);
			}
			int int_ = Class130.int_1;
			this.control1_0.Location = new Point(base.ClientSize.Width - int_, 0);
			this.control1_0.Size = new Size(int_, base.ClientSize.Height);
			this.control1_1.Location = new Point(0, base.ClientSize.Height - int_);
			this.control1_1.Size = new Size(base.ClientSize.Width, int_);
			if (base.DesignMode)
			{
				return;
			}
			this.method_11();
			this.method_10();
			this.method_11();
			this.method_10();
			if (this.control1_0.method_7())
			{
				this.control1_1.Width -= int_;
			}
			if (this.control1_1.method_7())
			{
				this.control1_0.Height -= int_;
			}
			this.control1_0.method_6(this.size_0.Height);
			this.control1_1.method_6(this.size_0.Width);
			this.method_12();
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000689AC File Offset: 0x00066BAC
		private void method_10()
		{
			this.control1_0.Enabled = (this.size_0.Height < this.method_2().Height);
			this.control1_1.Enabled = (this.size_0.Width < this.method_2().Width);
			if (this.bool_0)
			{
				this.control1_0.method_8(this.control1_0.Enabled);
				this.control1_1.method_8(this.control1_1.Enabled);
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00068A3C File Offset: 0x00066C3C
		private void method_11()
		{
			int int_ = Class130.int_1;
			this.size_0 = new Size(base.ClientSize.Width, base.ClientSize.Height);
			if (this.control1_0.method_7())
			{
				this.size_0.Width = this.size_0.Width - int_;
			}
			if (this.control1_1.method_7())
			{
				this.size_0.Height = this.size_0.Height - int_;
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00068AB8 File Offset: 0x00066CB8
		private void method_12()
		{
			int x = 0;
			int y = 0;
			int num = base.ClientSize.Width;
			int num2 = base.ClientSize.Height;
			if (this.control1_1.method_7())
			{
				x = this.control1_1.Value;
				num2 -= this.control1_1.Height;
			}
			if (this.control1_0.method_7())
			{
				y = this.control1_0.Value;
				num -= this.control1_0.Width;
			}
			this.method_1(new Rectangle(x, y, num, num2));
			Point point = base.PointToClient(Control.MousePosition);
			this.point_0 = new Point(point.X + this.method_0().Left, point.Y + this.method_0().Top);
			base.Invalidate();
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00005BCF File Offset: 0x00003DCF
		public void method_13(int int_1)
		{
			if (this.control1_0.method_7())
			{
				this.control1_0.Value = int_1;
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00005BEA File Offset: 0x00003DEA
		protected virtual void vmethod_0()
		{
			this.method_8(true);
			this.timer_0.Start();
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00005BFE File Offset: 0x00003DFE
		protected virtual void vmethod_1()
		{
			this.method_8(false);
			this.timer_0.Stop();
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00005C12 File Offset: 0x00003E12
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			this.method_9();
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00005C20 File Offset: 0x00003E20
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			base.Invalidate();
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00005C2F File Offset: 0x00003E2F
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			base.Invalidate();
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00005C3E File Offset: 0x00003E3E
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.method_9();
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00068B94 File Offset: 0x00066D94
		protected override void OnMouseMove(MouseEventArgs mea)
		{
			base.OnMouseMove(mea);
			this.point_0 = new Point(mea.X + this.method_0().Left, mea.Y + this.method_0().Top);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00005C4D File Offset: 0x00003E4D
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (e.Button == MouseButtons.Right)
			{
				base.Select();
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00068BE0 File Offset: 0x00066DE0
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			base.OnMouseWheel(e);
			bool flag = false;
			if (this.control1_1.method_7() && Control.ModifierKeys == Keys.Control)
			{
				flag = true;
			}
			if (this.control1_1.method_7() && !this.control1_0.method_7())
			{
				flag = true;
			}
			if (!flag)
			{
				if (e.Delta > 0)
				{
					this.control1_0.method_12(3);
					return;
				}
				if (e.Delta < 0)
				{
					this.control1_0.method_12(-3);
					return;
				}
			}
			else
			{
				if (e.Delta > 0)
				{
					this.control1_1.method_12(3);
					return;
				}
				if (e.Delta < 0)
				{
					this.control1_1.method_12(-3);
				}
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00068C8C File Offset: 0x00066E8C
		protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
		{
			base.OnPreviewKeyDown(e);
			Keys keyCode = e.KeyCode;
			if (keyCode - Keys.Left <= 3)
			{
				e.IsInputKey = true;
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00068CB8 File Offset: 0x00066EB8
		private void timer_0_Tick(object sender, EventArgs e)
		{
			Point point = base.PointToClient(Control.MousePosition);
			int num = base.ClientRectangle.Right;
			int num2 = base.ClientRectangle.Bottom;
			if (this.control1_0.method_7())
			{
				num = this.control1_0.Left;
			}
			if (this.control1_1.method_7())
			{
				num2 = this.control1_1.Top;
			}
			if (this.control1_0.method_7())
			{
				if (point.Y < base.ClientRectangle.Top)
				{
					int num3 = (point.Y - base.ClientRectangle.Top) * -1;
					if (this.method_5() > 0 && num3 > this.method_5())
					{
						num3 = this.method_5();
					}
					this.control1_0.Value = this.control1_0.Value - num3;
				}
				if (point.Y > num2)
				{
					int num4 = point.Y - num2;
					if (this.method_5() > 0 && num4 > this.method_5())
					{
						num4 = this.method_5();
					}
					this.control1_0.Value = this.control1_0.Value + num4;
				}
			}
			if (this.control1_1.method_7())
			{
				if (point.X < base.ClientRectangle.Left)
				{
					int num5 = (point.X - base.ClientRectangle.Left) * -1;
					if (this.method_5() > 0 && num5 > this.method_5())
					{
						num5 = this.method_5();
					}
					this.control1_1.Value = this.control1_1.Value - num5;
				}
				if (point.X > num)
				{
					int num6 = point.X - num;
					if (this.method_5() > 0 && num6 > this.method_5())
					{
						num6 = this.method_5();
					}
					this.control1_1.Value = this.control1_1.Value + num6;
				}
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00005C69 File Offset: 0x00003E69
		[CompilerGenerated]
		private void method_14(object sender, EventArgs4 e)
		{
			this.method_12();
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00005C69 File Offset: 0x00003E69
		[CompilerGenerated]
		private void method_15(object sender, EventArgs4 e)
		{
			this.method_12();
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00005C71 File Offset: 0x00003E71
		[CompilerGenerated]
		private void control1_0_MouseDown(object sender, MouseEventArgs e)
		{
			base.Select();
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00005C71 File Offset: 0x00003E71
		[CompilerGenerated]
		private void control1_1_MouseDown(object sender, MouseEventArgs e)
		{
			base.Select();
		}

		// Token: 0x04000378 RID: 888
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x04000379 RID: 889
		[CompilerGenerated]
		private EventHandler eventHandler_1;

		// Token: 0x0400037A RID: 890
		protected readonly Control1 control1_0;

		// Token: 0x0400037B RID: 891
		protected readonly Control1 control1_1;

		// Token: 0x0400037C RID: 892
		private Size size_0;

		// Token: 0x0400037D RID: 893
		private Size size_1;

		// Token: 0x0400037E RID: 894
		private Rectangle rectangle_0;

		// Token: 0x0400037F RID: 895
		private Point point_0;

		// Token: 0x04000380 RID: 896
		private int int_0;

		// Token: 0x04000381 RID: 897
		private Timer timer_0;

		// Token: 0x04000382 RID: 898
		private bool bool_0 = true;

		// Token: 0x04000383 RID: 899
		[CompilerGenerated]
		private bool bool_1;
	}
}
