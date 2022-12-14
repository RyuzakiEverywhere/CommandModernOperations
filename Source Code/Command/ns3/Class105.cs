using System;
using System.Drawing;
using System.Windows.Forms;
using ns8;

namespace ns3
{
	// Token: 0x020000A9 RID: 169
	internal sealed class Class105 : Class104
	{
		// Token: 0x0600035E RID: 862 RVA: 0x00061E58 File Offset: 0x00060058
		protected override void InitializeItem(ToolStripItem item)
		{
			base.InitializeItem(item);
			if (item.GetType() == typeof(ToolStripSeparator) && !((ToolStripSeparator)item).IsOnDropDown)
			{
				item.Margin = new Padding(0, 0, 2, 0);
			}
			if (item.GetType() == typeof(ToolStripButton))
			{
				item.AutoSize = false;
				item.Size = new Size(24, 24);
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00061ECC File Offset: 0x000600CC
		protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
		{
			base.OnRenderToolStripBackground(e);
			Graphics graphics = e.Graphics;
			if (e.ToolStrip.GetType() == typeof(ToolStripOverflow))
			{
				using (Pen pen = new Pen(Class129.smethod_0()))
				{
					Rectangle rect = new Rectangle(e.AffectedBounds.Left, e.AffectedBounds.Top, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1);
					graphics.DrawRectangle(pen, rect);
				}
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00004F87 File Offset: 0x00003187
		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
			if (e.ToolStrip.GetType() != typeof(ToolStrip))
			{
				base.OnRenderToolStripBorder(e);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00061F78 File Offset: 0x00060178
		protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 1, e.Item.Width, e.Item.Height - 2);
			if (e.Item.Selected || e.Item.Pressed)
			{
				using (SolidBrush solidBrush = new SolidBrush(Class129.smethod_16()))
				{
					graphics.FillRectangle(solidBrush, rect);
				}
			}
			if (e.Item.GetType() == typeof(ToolStripButton))
			{
				ToolStripButton toolStripButton = (ToolStripButton)e.Item;
				if (toolStripButton.Checked)
				{
					using (SolidBrush solidBrush2 = new SolidBrush(Class129.smethod_16()))
					{
						graphics.FillRectangle(solidBrush2, rect);
					}
				}
				if (toolStripButton.Checked && toolStripButton.Selected)
				{
					Rectangle rect2 = new Rectangle(rect.Left, rect.Top, rect.Width - 1, rect.Height - 1);
					using (Pen pen = new Pen(Class129.smethod_15()))
					{
						graphics.DrawRectangle(pen, rect2);
					}
				}
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000620C0 File Offset: 0x000602C0
		protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 1, e.Item.Width, e.Item.Height - 2);
			if (e.Item.Selected || e.Item.Pressed)
			{
				using (SolidBrush solidBrush = new SolidBrush(Class129.smethod_16()))
				{
					graphics.FillRectangle(solidBrush, rect);
				}
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00062140 File Offset: 0x00060340
		protected override void OnRenderGrip(ToolStripGripRenderEventArgs e)
		{
			if (e.GripStyle == ToolStripGripStyle.Hidden)
			{
				return;
			}
			Graphics graphics = e.Graphics;
			using (Bitmap bitmap = Class106.smethod_0(Class96.smethod_1(), Class129.smethod_9()))
			{
				graphics.DrawImageUnscaled(bitmap, new Point(e.AffectedBounds.Left, e.AffectedBounds.Top));
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000621B4 File Offset: 0x000603B4
		protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
		{
			Graphics graphics = e.Graphics;
			if (((ToolStripSeparator)e.Item).IsOnDropDown)
			{
				base.OnRenderSeparator(e);
				return;
			}
			Rectangle rectangle = new Rectangle(3, 3, 2, e.Item.Height - 4);
			using (Pen pen = new Pen(Class129.smethod_10()))
			{
				graphics.DrawLine(pen, rectangle.Left, rectangle.Top, rectangle.Left, rectangle.Height);
			}
			using (Pen pen2 = new Pen(Class129.smethod_9()))
			{
				graphics.DrawLine(pen2, rectangle.Left + 1, rectangle.Top, rectangle.Left + 1, rectangle.Height);
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00062290 File Offset: 0x00060490
		protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
		{
			Graphics graphics = e.Graphics;
			if (e.Image == null)
			{
				return;
			}
			if (e.Item.Enabled)
			{
				graphics.DrawImageUnscaled(e.Image, new Point(e.ImageRectangle.Left, e.ImageRectangle.Top));
				return;
			}
			ControlPaint.DrawImageDisabled(graphics, e.Image, e.ImageRectangle.Left, e.ImageRectangle.Top, Color.Transparent);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000378C File Offset: 0x0000198C
		protected override void OnRenderOverflowButtonBackground(ToolStripItemRenderEventArgs e)
		{
		}
	}
}
