using System;
using System.Drawing;
using System.Windows.Forms;
using ns8;

namespace ns3
{
	// Token: 0x020000A8 RID: 168
	internal class Class104 : ToolStripRenderer
	{
		// Token: 0x06000355 RID: 853 RVA: 0x00004F60 File Offset: 0x00003160
		protected override void Initialize(ToolStrip toolStrip)
		{
			base.Initialize(toolStrip);
			toolStrip.BackColor = Class129.smethod_0();
			toolStrip.ForeColor = Class129.smethod_11();
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00061A48 File Offset: 0x0005FC48
		protected override void InitializeItem(ToolStripItem item)
		{
			base.InitializeItem(item);
			item.BackColor = Class129.smethod_0();
			item.ForeColor = Class129.smethod_11();
			if (item.GetType() == typeof(ToolStripSeparator))
			{
				item.Margin = new Padding(0, 0, 0, 1);
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00061A98 File Offset: 0x0005FC98
		protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
		{
			Graphics graphics = e.Graphics;
			using (SolidBrush solidBrush = new SolidBrush(Class129.smethod_0()))
			{
				graphics.FillRectangle(solidBrush, e.AffectedBounds);
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00061AE0 File Offset: 0x0005FCE0
		protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);
			using (Pen pen = new Pen(Class129.smethod_9()))
			{
				graphics.DrawRectangle(pen, rect);
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00061B48 File Offset: 0x0005FD48
		protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(e.ImageRectangle.Left - 2, e.ImageRectangle.Top - 2, e.ImageRectangle.Width + 4, e.ImageRectangle.Height + 4);
			using (SolidBrush solidBrush = new SolidBrush(Class129.smethod_9()))
			{
				graphics.FillRectangle(solidBrush, rect);
			}
			using (Pen pen = new Pen(Class129.smethod_13()))
			{
				Rectangle rect2 = new Rectangle(rect.Left, rect.Top, rect.Width - 1, rect.Height - 1);
				graphics.DrawRectangle(pen, rect2);
			}
			if (e.Item.ImageIndex == -1 && string.IsNullOrEmpty(e.Item.ImageKey) && e.Item.Image == null)
			{
				graphics.DrawImageUnscaled(Class96.smethod_2(), new Point(e.ImageRectangle.Left, e.ImageRectangle.Top));
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00061C84 File Offset: 0x0005FE84
		protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(1, 3, e.Item.Width, 1);
			using (SolidBrush solidBrush = new SolidBrush(Class129.smethod_9()))
			{
				graphics.FillRectangle(solidBrush, rect);
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00061CDC File Offset: 0x0005FEDC
		protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
		{
			e.ArrowColor = Class129.smethod_11();
			e.ArrowRectangle = new Rectangle(new Point(e.ArrowRectangle.Left, e.ArrowRectangle.Top - 1), e.ArrowRectangle.Size);
			base.OnRenderArrow(e);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00061D38 File Offset: 0x0005FF38
		protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
		{
			Graphics graphics = e.Graphics;
			e.Item.ForeColor = (e.Item.Enabled ? Class129.smethod_11() : Class129.smethod_12());
			if (e.Item.Enabled)
			{
				Color color = e.Item.Selected ? Class129.smethod_15() : e.Item.BackColor;
				Rectangle rect = new Rectangle(2, 0, e.Item.Width - 3, e.Item.Height);
				using (SolidBrush solidBrush = new SolidBrush(color))
				{
					graphics.FillRectangle(solidBrush, rect);
				}
				if (e.Item.GetType() == typeof(ToolStripMenuItem) && ((ToolStripMenuItem)e.Item).DropDown.Visible && !e.Item.IsOnDropDown)
				{
					using (SolidBrush solidBrush2 = new SolidBrush(Class129.smethod_16()))
					{
						graphics.FillRectangle(solidBrush2, rect);
					}
				}
			}
		}
	}
}
