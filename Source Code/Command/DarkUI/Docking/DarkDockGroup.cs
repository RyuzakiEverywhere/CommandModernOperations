using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns2;
using ns3;
using ns8;

namespace DarkUI.Docking
{
	// Token: 0x020000B3 RID: 179
	public sealed class DarkDockGroup : Panel
	{
		// Token: 0x06000397 RID: 919 RVA: 0x000051D7 File Offset: 0x000033D7
		[CompilerGenerated]
		public DarkDockPanel method_0()
		{
			return this.darkDockPanel_0;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000051DF File Offset: 0x000033DF
		[CompilerGenerated]
		private void method_1(DarkDockPanel darkDockPanel_1)
		{
			this.darkDockPanel_0 = darkDockPanel_1;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000051E8 File Offset: 0x000033E8
		[CompilerGenerated]
		public DarkDockRegion method_2()
		{
			return this.darkDockRegion_0;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000051F0 File Offset: 0x000033F0
		[CompilerGenerated]
		private void method_3(DarkDockRegion darkDockRegion_1)
		{
			this.darkDockRegion_0 = darkDockRegion_1;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000051F9 File Offset: 0x000033F9
		[CompilerGenerated]
		public Enum13 method_4()
		{
			return this.enum13_0;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00005201 File Offset: 0x00003401
		[CompilerGenerated]
		private void method_5(Enum13 enum13_1)
		{
			this.enum13_0 = enum13_1;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000520A File Offset: 0x0000340A
		[CompilerGenerated]
		public DarkDockContent method_6()
		{
			return this.darkDockContent_0;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00005212 File Offset: 0x00003412
		[CompilerGenerated]
		private void method_7(DarkDockContent darkDockContent_1)
		{
			this.darkDockContent_0 = darkDockContent_1;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000521B File Offset: 0x0000341B
		[CompilerGenerated]
		public int method_8()
		{
			return this.int_0;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00005223 File Offset: 0x00003423
		[CompilerGenerated]
		public void method_9(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000522C File Offset: 0x0000342C
		public int method_10()
		{
			return this.list_0.Count;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000631F0 File Offset: 0x000613F0
		public DarkDockGroup(DarkDockPanel darkDockPanel_1, DarkDockRegion darkDockRegion_1, int int_1)
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
			this.method_1(darkDockPanel_1);
			this.method_3(darkDockRegion_1);
			this.method_5(darkDockRegion_1.method_2());
			this.method_9(int_1);
			this.class108_0 = new Class108(this.method_4());
			this.method_0().method_0(new EventHandler<EventArgs3>(this.method_19));
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00063270 File Offset: 0x00061470
		public void method_11(DarkDockContent darkDockContent_1)
		{
			darkDockContent_1.method_10(this);
			darkDockContent_1.Dock = DockStyle.Fill;
			darkDockContent_1.method_14(0);
			if (this.list_0.Count > 0)
			{
				int num = -1;
				foreach (DarkDockContent darkDockContent in this.list_0)
				{
					if (darkDockContent.method_13() >= num)
					{
						num = darkDockContent.method_13() + 1;
					}
				}
				darkDockContent_1.method_14(num);
			}
			this.list_0.Add(darkDockContent_1);
			base.Controls.Add(darkDockContent_1);
			darkDockContent_1.method_0(new EventHandler(this.method_20));
			this.dictionary_0.Add(darkDockContent_1, new DarkDockTab(darkDockContent_1));
			if (this.method_6() == null)
			{
				darkDockContent_1.Visible = true;
				this.method_7(darkDockContent_1);
			}
			else
			{
				darkDockContent_1.Visible = false;
			}
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(darkDockContent_1.method_2());
			toolStripMenuItem.Tag = darkDockContent_1;
			toolStripMenuItem.Click += this.method_18;
			toolStripMenuItem.Image = darkDockContent_1.method_3();
			this.class108_0.method_16(toolStripMenuItem);
			this.method_13();
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0006339C File Offset: 0x0006159C
		public void method_12(DarkDockContent darkDockContent_1)
		{
			darkDockContent_1.method_10(null);
			int num = darkDockContent_1.method_13();
			this.list_0.Remove(darkDockContent_1);
			base.Controls.Remove(darkDockContent_1);
			foreach (DarkDockContent darkDockContent in this.list_0)
			{
				if (darkDockContent.method_13() > num)
				{
					DarkDockContent darkDockContent2 = darkDockContent;
					int num2 = darkDockContent2.method_13();
					darkDockContent2.method_14(num2 - 1);
				}
			}
			darkDockContent_1.method_1(new EventHandler(this.method_20));
			if (this.dictionary_0.ContainsKey(darkDockContent_1))
			{
				this.dictionary_0.Remove(darkDockContent_1);
			}
			if (this.method_6() == darkDockContent_1)
			{
				this.method_7(null);
				if (this.list_0.Count > 0)
				{
					DarkDockContent darkDockContent3 = this.list_0[0];
					darkDockContent3.Visible = true;
					this.method_7(darkDockContent3);
				}
			}
			ToolStripMenuItem toolStripMenuItem = this.class108_0.method_18(darkDockContent_1);
			toolStripMenuItem.Click -= this.method_18;
			this.class108_0.method_17(toolStripMenuItem);
			this.method_13();
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000634C8 File Offset: 0x000616C8
		private void method_13()
		{
			if (this.method_4() == Enum13.const_1)
			{
				this.class108_0.method_12(this.list_0.Count > 0);
			}
			else
			{
				this.class108_0.method_12(this.list_0.Count > 1);
			}
			switch (this.method_4())
			{
			case Enum13.const_1:
			{
				int num = this.class108_0.method_11() ? 24 : 0;
				base.Padding = new Padding(0, num, 0, 0);
				this.class108_0.method_2(new Rectangle(base.Padding.Left, 0, base.ClientRectangle.Width - base.Padding.Horizontal, num));
				break;
			}
			case Enum13.const_2:
			case Enum13.const_3:
			{
				int num = this.class108_0.method_11() ? 21 : 0;
				base.Padding = new Padding(0, 0, 0, num);
				this.class108_0.method_2(new Rectangle(base.Padding.Left, base.ClientRectangle.Bottom - num, base.ClientRectangle.Width - base.Padding.Horizontal, num));
				break;
			}
			case Enum13.const_4:
			{
				int num = this.class108_0.method_11() ? 21 : 0;
				base.Padding = new Padding(1, 0, 0, num);
				this.class108_0.method_2(new Rectangle(base.Padding.Left, base.ClientRectangle.Bottom - num, base.ClientRectangle.Width - base.Padding.Horizontal, num));
				break;
			}
			}
			if (this.method_4() == Enum13.const_1)
			{
				this.class108_0.method_4(new Rectangle(this.class108_0.method_1().Right - 24, 0, 24, 24));
			}
			this.method_14();
			this.method_15();
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000636BC File Offset: 0x000618BC
		private void method_14()
		{
			if (!this.class108_0.method_11())
			{
				return;
			}
			base.SuspendLayout();
			int width = Class95.smethod_3().Width;
			int num = 0;
			IOrderedEnumerable<DarkDockContent> orderedEnumerable = Enumerable.OrderBy<DarkDockContent, int>(this.list_0, new Func<DarkDockContent, int>(DarkDockGroup.<>c.<>9.method_0));
			foreach (DarkDockContent key in orderedEnumerable)
			{
				DarkDockTab darkDockTab = this.dictionary_0[key];
				int num2;
				using (Graphics graphics = base.CreateGraphics())
				{
					num2 = darkDockTab.method_12(graphics, this.Font);
				}
				if (this.method_4() == Enum13.const_1)
				{
					num2 += 5;
					num2 += width;
					if (darkDockTab.method_0().method_3() != null)
					{
						num2 += darkDockTab.method_0().method_3().Width + 5;
					}
				}
				darkDockTab.method_11(true);
				num2++;
				int y = (this.method_4() == Enum13.const_1) ? 0 : (base.ClientRectangle.Height - 21);
				int height = (this.method_4() == Enum13.const_1) ? 24 : 21;
				Rectangle rectangle_ = new Rectangle(this.class108_0.method_1().Left + num, y, num2, height);
				darkDockTab.method_3(rectangle_);
				num += num2;
			}
			if (this.method_4() != Enum13.const_1 && num > this.class108_0.method_1().Width)
			{
				int num3 = num - this.class108_0.method_1().Width;
				DarkDockTab darkDockTab2 = this.dictionary_0[Enumerable.Last<DarkDockContent>(orderedEnumerable)];
				Rectangle rectangle = darkDockTab2.method_2();
				darkDockTab2.method_3(new Rectangle(rectangle.Left, rectangle.Top, rectangle.Width - 1, rectangle.Height));
				darkDockTab2.method_11(false);
				int i = 1;
				while (i < num3)
				{
					int width2 = Enumerable.First<DarkDockTab>(Enumerable.OrderByDescending<DarkDockTab, int>(this.dictionary_0.Values, new Func<DarkDockTab, int>(DarkDockGroup.<>c.<>9.method_1))).method_2().Width;
					foreach (DarkDockContent key2 in orderedEnumerable)
					{
						DarkDockTab darkDockTab3 = this.dictionary_0[key2];
						if (i >= num3)
						{
							break;
						}
						if (darkDockTab3.method_2().Width >= width2)
						{
							Rectangle rectangle2 = darkDockTab3.method_2();
							darkDockTab3.method_3(new Rectangle(rectangle2.Left, rectangle2.Top, rectangle2.Width - 1, rectangle2.Height));
							i++;
						}
					}
				}
				int num4 = 0;
				foreach (DarkDockContent key3 in orderedEnumerable)
				{
					DarkDockTab darkDockTab4 = this.dictionary_0[key3];
					Rectangle rectangle3 = darkDockTab4.method_2();
					darkDockTab4.method_3(new Rectangle(this.class108_0.method_1().Left + num4, rectangle3.Top, rectangle3.Width, rectangle3.Height));
					num4 += rectangle3.Width;
				}
			}
			if (this.method_4() == Enum13.const_1)
			{
				foreach (DarkDockContent key4 in orderedEnumerable)
				{
					DarkDockTab darkDockTab5 = this.dictionary_0[key4];
					Rectangle rectangle_2 = new Rectangle(darkDockTab5.method_2().Right - 7 - width - 1, darkDockTab5.method_2().Top + darkDockTab5.method_2().Height / 2 - width / 2 - 1, width, width);
					darkDockTab5.method_5(rectangle_2);
				}
			}
			num = 0;
			foreach (DarkDockContent key5 in orderedEnumerable)
			{
				DarkDockTab darkDockTab6 = this.dictionary_0[key5];
				num += darkDockTab6.method_2().Width;
			}
			this.class108_0.method_10(num);
			base.ResumeLayout();
			base.Invalidate();
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00063B48 File Offset: 0x00061D48
		public void method_15()
		{
			if (this.method_4() != Enum13.const_1)
			{
				return;
			}
			if (this.method_6() == null)
			{
				return;
			}
			int num = base.ClientRectangle.Width - base.Padding.Horizontal - this.class108_0.method_3().Width;
			Rectangle rectangle = new Rectangle(base.Padding.Left, 0, num, 0);
			DarkDockTab darkDockTab = this.dictionary_0[this.method_6()];
			if (darkDockTab.method_2().IsEmpty)
			{
				return;
			}
			if (this.method_17(darkDockTab.method_2()).Left < rectangle.Left)
			{
				this.class108_0.method_8(darkDockTab.method_2().Left);
			}
			else if (this.method_17(darkDockTab.method_2()).Right > rectangle.Right)
			{
				this.class108_0.method_8(darkDockTab.method_2().Right - num);
			}
			if (this.class108_0.method_9() < rectangle.Width)
			{
				this.class108_0.method_8(0);
			}
			if (this.class108_0.method_9() > rectangle.Width)
			{
				IOrderedEnumerable<DarkDockContent> orderedEnumerable = Enumerable.OrderBy<DarkDockContent, int>(this.list_0, new Func<DarkDockContent, int>(DarkDockGroup.<>c.<>9.method_2));
				DarkDockTab darkDockTab2 = this.dictionary_0[Enumerable.Last<DarkDockContent>(orderedEnumerable)];
				if (darkDockTab2 != null && this.method_17(darkDockTab2.method_2()).Right < rectangle.Right)
				{
					this.class108_0.method_8(darkDockTab2.method_2().Right - num);
				}
			}
			base.Invalidate();
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00005239 File Offset: 0x00003439
		private Point method_16(Point point_0)
		{
			return new Point(point_0.X - this.class108_0.method_7(), point_0.Y);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000525A File Offset: 0x0000345A
		private Rectangle method_17(Rectangle rectangle_0)
		{
			return new Rectangle(this.method_16(rectangle_0.Location), rectangle_0.Size);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00005275 File Offset: 0x00003475
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.method_13();
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00063D00 File Offset: 0x00061F00
		protected override void OnMouseMove(MouseEventArgs mea)
		{
			base.OnMouseMove(mea);
			if (this.darkDockTab_0 != null)
			{
				int num = mea.Location.X + this.class108_0.method_7();
				if (num < this.darkDockTab_0.method_2().Left)
				{
					if (this.darkDockTab_0.method_0().method_13() > 0)
					{
						List<DarkDockTab> list = Enumerable.ToList<DarkDockTab>(Enumerable.Where<DarkDockTab>(this.dictionary_0.Values, new Func<DarkDockTab, bool>(this.method_24)));
						if (list.Count == 0)
						{
							return;
						}
						DarkDockTab darkDockTab = Enumerable.First<DarkDockTab>(list);
						if (darkDockTab == null)
						{
							return;
						}
						int num2 = this.darkDockTab_0.method_0().method_13();
						this.darkDockTab_0.method_0().method_14(num2 - 1);
						darkDockTab.method_0().method_14(num2);
						this.method_14();
						this.method_15();
						this.class108_0.method_19();
						return;
					}
				}
				else if (num > this.darkDockTab_0.method_2().Right)
				{
					int count = this.list_0.Count;
					if (this.darkDockTab_0.method_0().method_13() < count)
					{
						List<DarkDockTab> list2 = Enumerable.ToList<DarkDockTab>(Enumerable.Where<DarkDockTab>(this.dictionary_0.Values, new Func<DarkDockTab, bool>(this.method_25)));
						if (list2.Count == 0)
						{
							return;
						}
						DarkDockTab darkDockTab2 = Enumerable.First<DarkDockTab>(list2);
						if (darkDockTab2 == null)
						{
							return;
						}
						int num3 = this.darkDockTab_0.method_0().method_13();
						this.darkDockTab_0.method_0().method_14(num3 + 1);
						darkDockTab2.method_0().method_14(num3);
						this.method_14();
						this.method_15();
						this.class108_0.method_19();
						return;
					}
				}
				return;
			}
			if (this.class108_0.method_3().Contains(mea.Location))
			{
				this.class108_0.method_6(true);
				foreach (DarkDockTab darkDockTab3 in this.dictionary_0.Values)
				{
					darkDockTab3.method_7(false);
				}
				base.Invalidate();
				return;
			}
			this.class108_0.method_6(false);
			foreach (DarkDockTab darkDockTab4 in this.dictionary_0.Values)
			{
				bool flag = this.method_17(darkDockTab4.method_2()).Contains(mea.Location);
				if (darkDockTab4.method_6() != flag)
				{
					darkDockTab4.method_7(flag);
					base.Invalidate();
				}
				bool flag2 = this.method_17(darkDockTab4.method_4()).Contains(mea.Location);
				if (darkDockTab4.method_8() != flag2)
				{
					darkDockTab4.method_9(flag2);
					base.Invalidate();
				}
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00063FF0 File Offset: 0x000621F0
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (this.class108_0.method_3().Contains(e.Location))
			{
				this.class108_0.method_6(true);
				return;
			}
			foreach (DarkDockTab darkDockTab in this.dictionary_0.Values)
			{
				if (this.method_17(darkDockTab.method_2()).Contains(e.Location))
				{
					if (e.Button == MouseButtons.Middle)
					{
						darkDockTab.method_0().vmethod_0();
						return;
					}
					if (this.method_17(darkDockTab.method_4()).Contains(e.Location))
					{
						this.class108_0.method_14(darkDockTab);
						return;
					}
					this.method_0().method_1(darkDockTab.method_0());
					this.method_15();
					this.darkDockTab_0 = darkDockTab;
					return;
				}
			}
			if (this.method_6() != null)
			{
				this.method_0().method_1(this.method_6());
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0006410C File Offset: 0x0006230C
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			this.darkDockTab_0 = null;
			if (this.class108_0.method_3().Contains(mevent.Location))
			{
				if (this.class108_0.method_5())
				{
					this.class108_0.method_15(this, new Point(this.class108_0.method_3().Left, this.class108_0.method_3().Bottom - 2));
				}
				return;
			}
			if (this.class108_0.method_13() == null)
			{
				return;
			}
			if (this.method_17(this.class108_0.method_13().method_4()).Contains(mevent.Location))
			{
				this.class108_0.method_13().method_0().vmethod_0();
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000641D4 File Offset: 0x000623D4
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			foreach (DarkDockTab darkDockTab in this.dictionary_0.Values)
			{
				darkDockTab.method_7(false);
			}
			base.Invalidate();
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00064238 File Offset: 0x00062438
		private void method_18(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
			if (toolStripMenuItem == null)
			{
				return;
			}
			DarkDockContent darkDockContent = toolStripMenuItem.Tag as DarkDockContent;
			if (darkDockContent == null)
			{
				return;
			}
			this.method_0().method_1(darkDockContent);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0006426C File Offset: 0x0006246C
		private void method_19(object sender, EventArgs3 e)
		{
			if (!this.list_0.Contains(e.method_0()))
			{
				return;
			}
			if (e.method_0() == this.method_6())
			{
				this.method_6().Focus();
				return;
			}
			this.method_7(e.method_0());
			foreach (DarkDockContent darkDockContent in this.list_0)
			{
				darkDockContent.Visible = (darkDockContent == this.method_6());
			}
			this.method_6().Focus();
			this.method_15();
			base.Invalidate();
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00005284 File Offset: 0x00003484
		private void method_20(object sender, EventArgs e)
		{
			this.method_14();
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0006431C File Offset: 0x0006251C
		public void method_21()
		{
			base.Invalidate();
			foreach (DarkDockContent darkDockContent in this.list_0)
			{
				darkDockContent.Invalidate();
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00064374 File Offset: 0x00062574
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			using (SolidBrush solidBrush = new SolidBrush(Class129.smethod_0()))
			{
				graphics.FillRectangle(solidBrush, base.ClientRectangle);
			}
			if (!this.class108_0.method_11())
			{
				return;
			}
			using (SolidBrush solidBrush2 = new SolidBrush(Class129.smethod_5()))
			{
				graphics.FillRectangle(solidBrush2, this.class108_0.method_1());
			}
			foreach (DarkDockTab darkDockTab_ in this.dictionary_0.Values)
			{
				if (this.method_4() == Enum13.const_1)
				{
					this.method_22(graphics, darkDockTab_);
				}
				else
				{
					this.method_23(graphics, darkDockTab_);
				}
			}
			if (this.method_4() == Enum13.const_1)
			{
				using (SolidBrush solidBrush3 = new SolidBrush((this.method_0().method_3() == this) ? Class129.smethod_14() : Class129.smethod_16()))
				{
					Rectangle rect = new Rectangle(this.class108_0.method_1().Left, this.class108_0.method_1().Bottom - 2, this.class108_0.method_1().Width, 2);
					graphics.FillRectangle(solidBrush3, rect);
				}
				Rectangle rect2 = new Rectangle(this.class108_0.method_3().Left, this.class108_0.method_3().Top, this.class108_0.method_3().Width, this.class108_0.method_3().Height - 2);
				using (SolidBrush solidBrush4 = new SolidBrush(Class129.smethod_5()))
				{
					graphics.FillRectangle(solidBrush4, rect2);
				}
				using (Bitmap bitmap = Class95.smethod_2())
				{
					graphics.DrawImageUnscaled(bitmap, rect2.Left + rect2.Width / 2 - bitmap.Width / 2, rect2.Top + rect2.Height / 2 - bitmap.Height / 2 + 1);
				}
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x000645E4 File Offset: 0x000627E4
		private void method_22(Graphics graphics_0, DarkDockTab darkDockTab_1)
		{
			Rectangle rect = this.method_17(darkDockTab_1.method_2());
			bool flag = this.method_6() == darkDockTab_1.method_0();
			bool flag2 = this.method_0().method_3() == this;
			Color color = flag ? Class129.smethod_14() : Class129.smethod_4();
			if (!flag2)
			{
				color = (flag ? Class129.smethod_16() : Class129.smethod_4());
			}
			if (darkDockTab_1.method_6() && !flag)
			{
				color = Class129.smethod_5();
			}
			using (SolidBrush solidBrush = new SolidBrush(color))
			{
				graphics_0.FillRectangle(solidBrush, rect);
			}
			if (darkDockTab_1.method_10())
			{
				using (Pen pen = new Pen(Class129.smethod_10()))
				{
					graphics_0.DrawLine(pen, rect.Right - 1, rect.Top, rect.Right - 1, rect.Bottom);
				}
			}
			int num = 0;
			if (darkDockTab_1.method_0().method_3() != null)
			{
				graphics_0.DrawImageUnscaled(darkDockTab_1.method_0().method_3(), rect.Left + 5, rect.Top + 4);
				num += darkDockTab_1.method_0().method_3().Width + 2;
			}
			StringFormat format = new StringFormat
			{
				Alignment = StringAlignment.Near,
				LineAlignment = StringAlignment.Center,
				FormatFlags = StringFormatFlags.NoWrap,
				Trimming = StringTrimming.EllipsisCharacter
			};
			using (SolidBrush solidBrush2 = new SolidBrush(flag ? Class129.smethod_11() : Class129.smethod_12()))
			{
				Rectangle r = new Rectangle(rect.Left + 5 + num, rect.Top, rect.Width - darkDockTab_1.method_4().Width - 7 - 5 - num, rect.Height);
				graphics_0.DrawString(darkDockTab_1.method_0().method_2(), this.Font, solidBrush2, r, format);
			}
			Bitmap image = darkDockTab_1.method_8() ? Class95.smethod_6() : Class95.smethod_5();
			if (flag)
			{
				if (flag2)
				{
					image = (darkDockTab_1.method_8() ? Class95.smethod_4() : Class95.smethod_3());
				}
				else
				{
					image = (darkDockTab_1.method_8() ? Class95.smethod_4() : Class95.smethod_1());
				}
			}
			Rectangle rectangle = this.method_17(darkDockTab_1.method_4());
			graphics_0.DrawImageUnscaled(image, rectangle.Left, rectangle.Top);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00064848 File Offset: 0x00062A48
		private void method_23(Graphics graphics_0, DarkDockTab darkDockTab_1)
		{
			Rectangle rect = darkDockTab_1.method_2();
			bool flag;
			Color color = (flag = (this.method_6() == darkDockTab_1.method_0())) ? Class129.smethod_0() : Class129.smethod_4();
			if (darkDockTab_1.method_6() && !flag)
			{
				color = Class129.smethod_5();
			}
			using (SolidBrush solidBrush = new SolidBrush(color))
			{
				graphics_0.FillRectangle(solidBrush, rect);
			}
			if (darkDockTab_1.method_10())
			{
				using (Pen pen = new Pen(Class129.smethod_10()))
				{
					graphics_0.DrawLine(pen, rect.Right - 1, rect.Top, rect.Right - 1, rect.Bottom);
				}
			}
			StringFormat format = new StringFormat
			{
				Alignment = StringAlignment.Near,
				LineAlignment = StringAlignment.Center,
				FormatFlags = StringFormatFlags.NoWrap,
				Trimming = StringTrimming.EllipsisCharacter
			};
			using (SolidBrush solidBrush2 = new SolidBrush(flag ? Class129.smethod_13() : Class129.smethod_12()))
			{
				Rectangle r = new Rectangle(rect.Left + 5, rect.Top, rect.Width - 5, rect.Height);
				graphics_0.DrawString(darkDockTab_1.method_0().method_2(), this.Font, solidBrush2, r, format);
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000378C File Offset: 0x0000198C
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000528C File Offset: 0x0000348C
		[CompilerGenerated]
		private bool method_24(DarkDockTab darkDockTab_1)
		{
			return darkDockTab_1.method_0().method_13() == this.darkDockTab_0.method_0().method_13() - 1;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000052AD File Offset: 0x000034AD
		[CompilerGenerated]
		private bool method_25(DarkDockTab darkDockTab_1)
		{
			return darkDockTab_1.method_0().method_13() == this.darkDockTab_0.method_0().method_13() + 1;
		}

		// Token: 0x040002F1 RID: 753
		private List<DarkDockContent> list_0 = new List<DarkDockContent>();

		// Token: 0x040002F2 RID: 754
		private Dictionary<DarkDockContent, DarkDockTab> dictionary_0 = new Dictionary<DarkDockContent, DarkDockTab>();

		// Token: 0x040002F3 RID: 755
		private Class108 class108_0;

		// Token: 0x040002F4 RID: 756
		private DarkDockTab darkDockTab_0;

		// Token: 0x040002F5 RID: 757
		[CompilerGenerated]
		private DarkDockPanel darkDockPanel_0;

		// Token: 0x040002F6 RID: 758
		[CompilerGenerated]
		private DarkDockRegion darkDockRegion_0;

		// Token: 0x040002F7 RID: 759
		[CompilerGenerated]
		private Enum13 enum13_0;

		// Token: 0x040002F8 RID: 760
		[CompilerGenerated]
		private DarkDockContent darkDockContent_0;

		// Token: 0x040002F9 RID: 761
		[CompilerGenerated]
		private int int_0;
	}
}
