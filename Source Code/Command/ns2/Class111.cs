using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using ns8;

namespace ns2
{
	// Token: 0x020000C0 RID: 192
	internal sealed class Class111 : Button
	{
		// Token: 0x0600041F RID: 1055 RVA: 0x00005642 File Offset: 0x00003842
		public string method_0()
		{
			return base.Text;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000564A File Offset: 0x0000384A
		public void method_1(string string_0)
		{
			base.Text = string_0;
			base.Invalidate();
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00005659 File Offset: 0x00003859
		public bool method_2()
		{
			return base.Enabled;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00005661 File Offset: 0x00003861
		public void method_3(bool bool_2)
		{
			base.Enabled = bool_2;
			base.Invalidate();
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00005670 File Offset: 0x00003870
		public Enum16 method_4()
		{
			return this.enum16_0;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00005678 File Offset: 0x00003878
		public int method_5()
		{
			return this.int_1;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00005680 File Offset: 0x00003880
		public Enum17 method_6()
		{
			return this.enum17_0;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00065A90 File Offset: 0x00063C90
		public Class111()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
			base.UseVisualStyleBackColor = false;
			base.UseCompatibleTextRendering = false;
			this.method_7(Enum17.const_0);
			base.Padding = new Padding(this.int_0);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00005688 File Offset: 0x00003888
		private void method_7(Enum17 enum17_1)
		{
			if (this.enum17_0 != enum17_1)
			{
				this.enum17_0 = enum17_1;
				base.Invalidate();
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00065AEC File Offset: 0x00063CEC
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			Form form = base.FindForm();
			if (form != null && form.AcceptButton == this)
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00065B1C File Offset: 0x00063D1C
		protected override void OnMouseMove(MouseEventArgs mea)
		{
			base.OnMouseMove(mea);
			if (this.bool_1)
			{
				return;
			}
			if (mea.Button != MouseButtons.Left)
			{
				this.method_7(Enum17.const_1);
				return;
			}
			if (base.ClientRectangle.Contains(mea.Location))
			{
				this.method_7(Enum17.const_2);
				return;
			}
			this.method_7(Enum17.const_1);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00065B74 File Offset: 0x00063D74
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (!base.ClientRectangle.Contains(e.Location))
			{
				return;
			}
			this.method_7(Enum17.const_2);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000056A0 File Offset: 0x000038A0
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			if (this.bool_1)
			{
				return;
			}
			this.method_7(Enum17.const_0);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000056B9 File Offset: 0x000038B9
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			if (this.bool_1)
			{
				return;
			}
			this.method_7(Enum17.const_0);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00065BA8 File Offset: 0x00063DA8
		protected override void OnMouseCaptureChanged(EventArgs e)
		{
			base.OnMouseCaptureChanged(e);
			if (this.bool_1)
			{
				return;
			}
			Point position = Cursor.Position;
			if (!base.ClientRectangle.Contains(position))
			{
				this.method_7(Enum17.const_0);
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000056D2 File Offset: 0x000038D2
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			base.Invalidate();
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00065BE4 File Offset: 0x00063DE4
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			this.bool_1 = false;
			Point position = Cursor.Position;
			if (!base.ClientRectangle.Contains(position))
			{
				this.method_7(Enum17.const_0);
				return;
			}
			this.method_7(Enum17.const_1);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000056E1 File Offset: 0x000038E1
		protected override void OnKeyDown(KeyEventArgs ke)
		{
			base.OnKeyDown(ke);
			if (ke.KeyCode == Keys.Space)
			{
				this.bool_1 = true;
				this.method_7(Enum17.const_2);
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00065C28 File Offset: 0x00063E28
		protected override void OnKeyUp(KeyEventArgs e)
		{
			base.OnKeyUp(e);
			if (e.KeyCode == Keys.Space)
			{
				this.bool_1 = false;
				Point position = Cursor.Position;
				if (!base.ClientRectangle.Contains(position))
				{
					this.method_7(Enum17.const_0);
					return;
				}
				this.method_7(Enum17.const_1);
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00005702 File Offset: 0x00003902
		public override void NotifyDefault(bool value)
		{
			base.NotifyDefault(value);
			if (!base.DesignMode)
			{
				return;
			}
			this.bool_0 = value;
			base.Invalidate();
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00065C74 File Offset: 0x00063E74
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 0, base.ClientSize.Width, base.ClientSize.Height);
			Color color = Class129.smethod_11();
			Color color2 = Class129.smethod_16();
			Color color3 = this.bool_0 ? Class129.smethod_3() : Class129.smethod_6();
			if (this.method_2())
			{
				if (this.method_4() == Enum16.const_0)
				{
					if (this.Focused && base.TabStop)
					{
						color2 = Class129.smethod_13();
					}
					Enum17 @enum = this.method_6();
					if (@enum != Enum17.const_1)
					{
						if (@enum == Enum17.const_2)
						{
							color3 = (this.bool_0 ? Class129.smethod_4() : Class129.smethod_4());
						}
					}
					else
					{
						color3 = (this.bool_0 ? Class129.smethod_2() : Class129.smethod_7());
					}
				}
				else if (this.method_4() == Enum16.const_1)
				{
					switch (this.method_6())
					{
					case Enum17.const_0:
						color3 = Class129.smethod_0();
						break;
					case Enum17.const_1:
						color3 = Class129.smethod_5();
						break;
					case Enum17.const_2:
						color3 = Class129.smethod_4();
						break;
					}
				}
			}
			else
			{
				color = Class129.smethod_12();
				color3 = Class129.smethod_17();
			}
			using (SolidBrush solidBrush = new SolidBrush(color3))
			{
				graphics.FillRectangle(solidBrush, rect);
			}
			if (this.method_4() == Enum16.const_0)
			{
				using (Pen pen = new Pen(color2, 1f))
				{
					Rectangle rect2 = new Rectangle(rect.Left, rect.Top, rect.Width - 1, rect.Height - 1);
					graphics.DrawRectangle(pen, rect2);
				}
			}
			int num = 0;
			int num2 = 0;
			if (base.Image != null)
			{
				SizeF sizeF = graphics.MeasureString(this.method_0(), this.Font, rect.Size);
				int num3 = base.ClientSize.Width / 2 - base.Image.Size.Width / 2;
				int num4 = base.ClientSize.Height / 2 - base.Image.Size.Height / 2;
				TextImageRelation textImageRelation = base.TextImageRelation;
				switch (textImageRelation)
				{
				case TextImageRelation.ImageAboveText:
					num2 = base.Image.Size.Height / 2 + this.method_5() / 2;
					num4 -= (int)(sizeF.Height / 2f) + this.method_5() / 2;
					break;
				case TextImageRelation.TextAboveImage:
					num2 = (base.Image.Size.Height / 2 + this.method_5() / 2) * -1;
					num4 += (int)(sizeF.Height / 2f) + this.method_5() / 2;
					break;
				case (TextImageRelation)3:
					break;
				case TextImageRelation.ImageBeforeText:
					num = base.Image.Size.Width + this.method_5() * 2;
					num3 = this.method_5();
					break;
				default:
					if (textImageRelation == TextImageRelation.TextBeforeImage)
					{
						num3 += (int)sizeF.Width;
					}
					break;
				}
				graphics.DrawImageUnscaled(base.Image, num3, num4);
			}
			using (SolidBrush solidBrush2 = new SolidBrush(color))
			{
				Rectangle r = new Rectangle(rect.Left + num + base.Padding.Left, rect.Top + num2 + base.Padding.Top, rect.Width - base.Padding.Horizontal, rect.Height - base.Padding.Vertical);
				StringFormat format = new StringFormat
				{
					LineAlignment = StringAlignment.Center,
					Alignment = StringAlignment.Center,
					Trimming = StringTrimming.EllipsisCharacter
				};
				graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
				graphics.DrawString(this.method_0(), this.Font, solidBrush2, r, format);
			}
		}

		// Token: 0x0400033D RID: 829
		private Enum16 enum16_0;

		// Token: 0x0400033E RID: 830
		private Enum17 enum17_0;

		// Token: 0x0400033F RID: 831
		private bool bool_0;

		// Token: 0x04000340 RID: 832
		private bool bool_1;

		// Token: 0x04000341 RID: 833
		private int int_0 = Class130.int_0 / 2;

		// Token: 0x04000342 RID: 834
		private int int_1 = 5;
	}
}
