using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns5;

namespace ns4
{
	// Token: 0x02000DCD RID: 3533
	internal sealed class Control11 : Control
	{
		// Token: 0x06006623 RID: 26147 RVA: 0x00384920 File Offset: 0x00382B20
		public Control11()
		{
			this.int_0 = 100;
			this.int_1 = 0;
			this.bool_0 = true;
			this.bool_1 = true;
			this.nullable_0 = null;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			this.BackColor = Color.Transparent;
			base.UpdateStyles();
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06006624 RID: 26148 RVA: 0x00384980 File Offset: 0x00382B80
		// (set) Token: 0x06006625 RID: 26149 RVA: 0x003849A4 File Offset: 0x00382BA4
		[Description("Gets or sets the current position of the progressbar.")]
		[Category("Custom")]
		public int Value
		{
			get
			{
				int result;
				if (this.int_1 < 0)
				{
					result = 0;
				}
				else
				{
					result = this.int_1;
				}
				return result;
			}
			set
			{
				if (value > this.method_0())
				{
					value = this.method_0();
				}
				this.int_1 = value;
				if (this.delegate87_0 != null)
				{
					Control11.Delegate87 @delegate = this.delegate87_0;
					if (@delegate != null)
					{
						@delegate(this);
					}
				}
				base.Invalidate();
			}
		}

		// Token: 0x06006626 RID: 26150 RVA: 0x00040889 File Offset: 0x0003EA89
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x06006627 RID: 26151 RVA: 0x00040891 File Offset: 0x0003EA91
		public void method_1(int int_2)
		{
			if (int_2 < this.int_1)
			{
				this.int_1 = int_2;
			}
			this.int_0 = int_2;
			base.Invalidate();
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x000408B0 File Offset: 0x0003EAB0
		public bool method_2()
		{
			return this.bool_0;
		}

		// Token: 0x06006629 RID: 26153 RVA: 0x000408B8 File Offset: 0x0003EAB8
		public void method_3(bool bool_2)
		{
			this.bool_0 = bool_2;
			base.Invalidate();
		}

		// Token: 0x0600662A RID: 26154 RVA: 0x000408C7 File Offset: 0x0003EAC7
		public bool method_4()
		{
			return this.bool_1;
		}

		// Token: 0x0600662B RID: 26155 RVA: 0x000408CF File Offset: 0x0003EACF
		public void method_5(bool bool_2)
		{
			this.bool_1 = bool_2;
			base.Invalidate();
		}

		// Token: 0x0600662C RID: 26156 RVA: 0x000408DE File Offset: 0x0003EADE
		public void method_6(Color color_0)
		{
			this.nullable_0 = new Color?(color_0);
			base.Invalidate();
		}

		// Token: 0x0600662D RID: 26157 RVA: 0x003849E8 File Offset: 0x00382BE8
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			GraphicsPath graphicsPath = new GraphicsPath();
			int num = Convert.ToInt32((double)this.Value / (double)this.method_0() * (double)base.Width);
			Rectangle rectangle = new Rectangle(0, 0, base.Width - 1, base.Height - 1);
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle, Color.FromArgb(29, 29, 29), Color.FromArgb(41, 41, 41), 90f))
			{
				graphics.FillPath(linearGradientBrush, Class2450.smethod_4(rectangle, 2, true, true, true, true));
			}
			if (num != 0)
			{
				if (Information.IsNothing(this.nullable_0))
				{
					using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(new Rectangle(rectangle.X, rectangle.Y, num - 1, rectangle.Height), Color.FromArgb(48, 48, 48), Color.FromArgb(64, 64, 64), 270f))
					{
						using (Pen pen = new Pen(Color.FromArgb(20, Color.White)))
						{
							graphics.FillPath(linearGradientBrush2, Class2450.smethod_4(new Rectangle(rectangle.X, rectangle.Y, num - 1, rectangle.Height), 2, true, true, true, true));
							using (Pen pen2 = new Pen(Color.FromArgb(50, 50, 50), 20f))
							{
								if (this.method_2())
								{
									graphics.SmoothingMode = SmoothingMode.AntiAlias;
									int num2 = Convert.ToInt32((double)(base.Width - 20) * ((double)this.Value / (double)this.method_0()));
									for (int i = 9; i <= num2; i += 45)
									{
										graphics.DrawLine(pen2, new Point(i, Convert.ToInt32(base.Height / 2 - base.Height)), new Point(i - base.Height, Convert.ToInt32(base.Height / 2 + base.Height)));
									}
								}
							}
							graphics.DrawLine(pen, rectangle.X, 1, num - 2, 1);
							goto IL_257;
						}
					}
				}
				using (SolidBrush solidBrush = new SolidBrush(this.nullable_0.Value))
				{
					graphics.FillPath(solidBrush, Class2450.smethod_4(new Rectangle(rectangle.X, rectangle.Y, num - 1, rectangle.Height), 2, true, true, true, true));
				}
			}
			IL_257:
			using (SolidBrush solidBrush2 = new SolidBrush(Color.FromArgb(207, 207, 207)))
			{
				if (this.method_4())
				{
					graphics.DrawString(Conversions.ToString(this.Value) + "%", this.Font, solidBrush2, new Rectangle(0, 1, base.Width, base.Height), Class2450.smethod_3(StringAlignment.Center, StringAlignment.Center));
				}
			}
			using (Pen pen3 = new Pen(Color.FromArgb(22, 22, 22)))
			{
				graphics.DrawPath(pen3, Class2450.smethod_4(rectangle, 2, true, true, true, true));
			}
			graphicsPath.Dispose();
		}

		// Token: 0x04003A4F RID: 14927
		private int int_0;

		// Token: 0x04003A50 RID: 14928
		private int int_1;

		// Token: 0x04003A51 RID: 14929
		private bool bool_0;

		// Token: 0x04003A52 RID: 14930
		[CompilerGenerated]
		private Control11.Delegate87 delegate87_0;

		// Token: 0x04003A53 RID: 14931
		private bool bool_1;

		// Token: 0x04003A54 RID: 14932
		private Color? nullable_0;

		// Token: 0x02000DCE RID: 3534
		// (Invoke) Token: 0x06006631 RID: 26161
		internal delegate void Delegate87(object sender);
	}
}
