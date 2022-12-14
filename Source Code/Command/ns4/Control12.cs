using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using ns5;
using ns8;

namespace ns4
{
	// Token: 0x02000DCF RID: 3535
	internal sealed class Control12 : TabControl
	{
		// Token: 0x06006632 RID: 26162 RVA: 0x00384DA4 File Offset: 0x00382FA4
		public Control12()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.SizeMode = TabSizeMode.Normal;
			this.Dock = DockStyle.None;
			base.ItemSize = new Size(80, 20);
			base.Alignment = TabAlignment.Top;
			base.UpdateStyles();
		}

		// Token: 0x06006633 RID: 26163 RVA: 0x00384DF4 File Offset: 0x00382FF4
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.Clear(Color.FromArgb(39, 39, 39));
			this.Cursor = Cursors.Hand;
			int num = 0;
			int num2 = base.TabCount - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (base.TabPages[i].Enabled)
				{
					Rectangle tabRect = base.GetTabRect(i);
					if (tabRect.Width != 0 && tabRect.Height != 0)
					{
						if (i == base.TabCount - 1)
						{
							using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(tabRect, Color.FromArgb(29, 29, 29), Color.FromArgb(41, 41, 41), 270f))
							{
								Class2450.smethod_0(graphics, linearGradientBrush, tabRect, 2, false, true, false, true);
								goto IL_16A;
							}
						}
						if (i == 0)
						{
							using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(tabRect, Color.FromArgb(29, 29, 29), Color.FromArgb(41, 41, 41), 270f))
							{
								Class2450.smethod_0(graphics, linearGradientBrush2, new Rectangle(tabRect.X, tabRect.Y, tabRect.Width, tabRect.Height), 2, true, false, true, false);
								goto IL_16A;
							}
						}
						using (LinearGradientBrush linearGradientBrush3 = new LinearGradientBrush(tabRect, Color.FromArgb(29, 29, 29), Color.FromArgb(41, 41, 41), 270f))
						{
							graphics.FillRectangle(linearGradientBrush3, tabRect);
						}
					}
				}
				IL_16A:;
			}
			int num3 = base.TabCount - 1;
			for (int j = 0; j <= num3; j++)
			{
				if (base.TabPages[j].Enabled)
				{
					Rectangle tabRect2 = base.GetTabRect(j);
					num += tabRect2.Width;
					if (base.SelectedIndex == j)
					{
						using (LinearGradientBrush linearGradientBrush4 = new LinearGradientBrush(tabRect2, Color.FromArgb(48, 48, 48), Color.FromArgb(64, 64, 64), 270f))
						{
							if (j == base.TabCount - 1)
							{
								graphics.FillPath(linearGradientBrush4, Class2450.smethod_4(new Rectangle(tabRect2.X + 1, tabRect2.Y, tabRect2.Width - 1, tabRect2.Height - 1), 2, false, true, false, true));
								goto IL_347;
							}
							if (j == 0)
							{
								graphics.FillPath(linearGradientBrush4, Class2450.smethod_4(new Rectangle(tabRect2.X, tabRect2.Y, tabRect2.Width, tabRect2.Height), 2, true, false, true, false));
								goto IL_347;
							}
							graphics.FillRectangle(linearGradientBrush4, new Rectangle(tabRect2.X + 1, tabRect2.Y, tabRect2.Width - 1, tabRect2.Height));
							goto IL_347;
						}
						SolidBrush solidBrush;
						try
						{
							IL_2A9:
							graphics.DrawString(base.TabPages[j].Text, this.Font, solidBrush, tabRect2, Class2450.smethod_3(StringAlignment.Center, StringAlignment.Center));
							goto IL_33C;
						}
						finally
						{
							if (solidBrush != null)
							{
								((IDisposable)solidBrush).Dispose();
							}
						}
						goto IL_2E5;
						IL_347:
						solidBrush = new SolidBrush(Color.White);
						goto IL_2A9;
					}
					IL_2E5:
					using (SolidBrush solidBrush2 = new SolidBrush(Color.FromArgb(168, 168, 168)))
					{
						graphics.DrawString(base.TabPages[j].Text, this.Font, solidBrush2, tabRect2, Class2450.smethod_3(StringAlignment.Center, StringAlignment.Center));
					}
				}
				IL_33C:;
			}
		}

		// Token: 0x06006634 RID: 26164 RVA: 0x003851A8 File Offset: 0x003833A8
		protected override void OnMouseMove(MouseEventArgs mea)
		{
			base.OnMouseMove(mea);
			int num = base.TabCount - 1;
			for (int i = 0; i <= num; i++)
			{
				if (base.GetTabRect(i).Contains(mea.Location))
				{
					this.Cursor = Cursors.Hand;
					base.Invalidate();
				}
				else
				{
					this.Cursor = Cursors.Arrow;
					base.Invalidate();
				}
			}
		}

		// Token: 0x06006635 RID: 26165 RVA: 0x0038520C File Offset: 0x0038340C
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			try
			{
				foreach (object obj in base.TabPages)
				{
					((TabPage)obj).BackColor = Class129.smethod_0();
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06006636 RID: 26166 RVA: 0x000408F2 File Offset: 0x0003EAF2
		protected override void OnSelecting(TabControlCancelEventArgs e)
		{
			base.OnSelecting(e);
			if (!e.TabPage.Enabled)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06006637 RID: 26167 RVA: 0x00385270 File Offset: 0x00383470
		public void method_0()
		{
			try
			{
				foreach (object obj in base.TabPages)
				{
					TabPage tabPage = (TabPage)obj;
					if (tabPage == base.SelectedTab)
					{
						tabPage.Parent = this;
					}
					else
					{
						tabPage.Parent = null;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
	}
}
