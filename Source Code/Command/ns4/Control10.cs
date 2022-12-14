using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns5;

namespace ns4
{
	// Token: 0x02000DCB RID: 3531
	internal sealed class Control10 : Control
	{
		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06006613 RID: 26131 RVA: 0x0004080E File Offset: 0x0003EA0E
		// (set) Token: 0x06006614 RID: 26132 RVA: 0x003842B4 File Offset: 0x003824B4
		[Description("Gets or sets the current number of the NumericUpDown.")]
		[Category("Custom")]
		public int Value
		{
			get
			{
				return this.int_2;
			}
			set
			{
				bool flag = value != this.int_2;
				if (value <= this.method_0() & value >= this.method_2())
				{
					this.int_2 = value;
				}
				if (value > this.method_0())
				{
					this.int_2 = this.method_0();
				}
				base.Invalidate();
				if (flag)
				{
					Control10.Delegate86 @delegate = this.delegate86_0;
					if (@delegate != null)
					{
						@delegate();
					}
				}
			}
		}

		// Token: 0x06006615 RID: 26133 RVA: 0x00040816 File Offset: 0x0003EA16
		public int method_0()
		{
			return this.int_3;
		}

		// Token: 0x06006616 RID: 26134 RVA: 0x0004081E File Offset: 0x0003EA1E
		public void method_1(int int_5)
		{
			if (int_5 > this.method_2())
			{
				this.int_3 = int_5;
			}
			if (int_5 > this.int_3)
			{
				int_5 = this.int_3;
			}
			base.Invalidate();
		}

		// Token: 0x06006617 RID: 26135 RVA: 0x00040847 File Offset: 0x0003EA47
		public int method_2()
		{
			return this.int_4;
		}

		// Token: 0x06006618 RID: 26136 RVA: 0x0004084F File Offset: 0x0003EA4F
		public void method_3(int int_5)
		{
			if (int_5 < this.method_0())
			{
				this.int_4 = int_5;
			}
			if (int_5 < this.int_4)
			{
				int_5 = this.int_4;
			}
			base.Invalidate();
		}

		// Token: 0x06006619 RID: 26137 RVA: 0x0038431C File Offset: 0x0038251C
		public Control10()
		{
			this.int_0 = 0;
			this.int_1 = 0;
			this.int_2 = 0;
			this.int_3 = 100;
			this.int_4 = 0;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.UpdateStyles();
			this.BackColor = Color.Transparent;
		}

		// Token: 0x0600661A RID: 26138 RVA: 0x00384378 File Offset: 0x00382578
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			Rectangle rect = new Rectangle(0, 0, base.Width - 1, base.Height - 1);
			using (SolidBrush solidBrush = new SolidBrush(Color.FromArgb(31, 31, 31)))
			{
				using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, Color.FromArgb(48, 48, 48), Color.FromArgb(64, 64, 64), 270f))
				{
					using (Pen pen = new Pen(Color.FromArgb(22, 22, 22)))
					{
						using (Pen pen2 = new Pen(Color.FromArgb(20, Color.White)))
						{
							graphics.FillRectangle(solidBrush, rect);
							graphics.FillPath(linearGradientBrush, Class2450.smethod_4(new Rectangle(base.Width - 25, 0, 24, base.Height - 1), 2, true, true, true, true));
							graphics.DrawLine(pen, new Point(base.Width - 25, 1), new Point(base.Width - 25, base.Height - 2));
							graphics.DrawLine(pen, new Point(base.Width - 25, 13), new Point(base.Width - 1, 13));
							graphics.DrawLine(pen2, base.Width - 24, 1, base.Width - 24 + base.Width, 1);
						}
					}
				}
			}
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			using (GraphicsPath graphicsPath = new GraphicsPath())
			{
				using (SolidBrush solidBrush2 = new SolidBrush((this.Value != this.method_0()) ? Color.FromArgb(192, 192, 192) : Color.FromArgb(22, 22, 22)))
				{
					graphicsPath.AddLine(base.Width - 17, 9, base.Width - 2, 9);
					graphicsPath.AddLine(base.Width - 9, 9, base.Width - 13, 4);
					graphicsPath.CloseFigure();
					graphics.FillPath(solidBrush2, graphicsPath);
				}
			}
			using (GraphicsPath graphicsPath2 = new GraphicsPath())
			{
				using (SolidBrush solidBrush3 = new SolidBrush((this.Value > this.method_2()) ? Color.FromArgb(192, 192, 192) : Color.FromArgb(22, 22, 22)))
				{
					graphicsPath2.AddLine(base.Width - 17, 17, base.Width - 2, 17);
					graphicsPath2.AddLine(base.Width - 9, 17, base.Width - 13, 22);
					graphicsPath2.CloseFigure();
					graphics.FillPath(solidBrush3, graphicsPath2);
				}
			}
			graphics.SmoothingMode = SmoothingMode.Default;
			using (SolidBrush solidBrush4 = new SolidBrush(Color.FromArgb(207, 207, 207)))
			{
				graphics.DrawString(this.Value.ToString(), this.Font, solidBrush4, new Rectangle(0, 0, base.Width - 18, base.Height), Class2450.smethod_3(StringAlignment.Center, StringAlignment.Center));
			}
			using (Pen pen3 = new Pen(Color.FromArgb(22, 22, 22)))
			{
				graphics.DrawRectangle(pen3, rect);
			}
		}

		// Token: 0x0600661B RID: 26139 RVA: 0x003847B0 File Offset: 0x003829B0
		protected override void OnMouseMove(MouseEventArgs mea)
		{
			base.OnMouseMove(mea);
			this.int_0 = mea.Location.X;
			this.int_1 = mea.Location.Y;
			base.Invalidate();
			if (mea.X < base.Width - 25)
			{
				this.Cursor = Cursors.IBeam;
				return;
			}
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x00040878 File Offset: 0x0003EA78
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Height = 26;
		}

		// Token: 0x0600661D RID: 26141 RVA: 0x0038481C File Offset: 0x00382A1C
		protected override void OnMouseDown(MouseEventArgs e)
		{
			this.OnMouseClick(e);
			if (this.int_0 > base.Width - 17 && this.int_0 < base.Width - 3)
			{
				if (this.int_1 < 13)
				{
					if (this.Value + 1 <= this.method_0())
					{
						this.Value++;
					}
				}
				else if (this.Value - 1 >= this.method_2())
				{
					this.Value--;
				}
			}
			base.Invalidate();
		}

		// Token: 0x0600661E RID: 26142 RVA: 0x003848A0 File Offset: 0x00382AA0
		protected override bool ProcessCmdKey(ref Message m, Keys keyData)
		{
			bool result;
			if (keyData == Keys.Down | keyData == Keys.Next)
			{
				if (this.Value - 1 >= this.method_2())
				{
					this.Value--;
				}
				base.Invalidate();
				result = true;
			}
			else if (keyData == Keys.Up | keyData == Keys.Back)
			{
				if (this.Value + 1 <= this.method_0())
				{
					this.Value++;
				}
				base.Invalidate();
				result = true;
			}
			else
			{
				result = base.ProcessCmdKey(ref m, keyData);
			}
			return result;
		}

		// Token: 0x04003A49 RID: 14921
		private int int_0;

		// Token: 0x04003A4A RID: 14922
		private int int_1;

		// Token: 0x04003A4B RID: 14923
		private int int_2;

		// Token: 0x04003A4C RID: 14924
		private int int_3;

		// Token: 0x04003A4D RID: 14925
		private int int_4;

		// Token: 0x04003A4E RID: 14926
		[CompilerGenerated]
		private Control10.Delegate86 delegate86_0;

		// Token: 0x02000DCC RID: 3532
		// (Invoke) Token: 0x06006622 RID: 26146
		internal delegate void Delegate86();
	}
}
