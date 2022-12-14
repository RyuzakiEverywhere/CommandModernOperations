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
	// Token: 0x020000B6 RID: 182
	public sealed class DarkDockRegion : Panel
	{
		// Token: 0x060003CE RID: 974 RVA: 0x00005330 File Offset: 0x00003530
		[CompilerGenerated]
		public DarkDockPanel method_0()
		{
			return this.darkDockPanel_0;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00005338 File Offset: 0x00003538
		[CompilerGenerated]
		private void method_1(DarkDockPanel darkDockPanel_1)
		{
			this.darkDockPanel_0 = darkDockPanel_1;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00005341 File Offset: 0x00003541
		[CompilerGenerated]
		public Enum13 method_2()
		{
			return this.enum13_0;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00005349 File Offset: 0x00003549
		[CompilerGenerated]
		private void method_3(Enum13 enum13_1)
		{
			this.enum13_0 = enum13_1;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00005352 File Offset: 0x00003552
		public DarkDockRegion(DarkDockPanel darkDockPanel_1, Enum13 enum13_1)
		{
			this.list_0 = new List<DarkDockGroup>();
			this.method_1(darkDockPanel_1);
			this.method_3(enum13_1);
			this.method_12();
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00064D3C File Offset: 0x00062F3C
		internal void method_4(DarkDockContent darkDockContent_0, DarkDockGroup darkDockGroup_0)
		{
			if (darkDockGroup_0 == null)
			{
				if (this.method_2() == Enum13.const_1 && this.list_0.Count > 0)
				{
					darkDockGroup_0 = this.list_0[0];
				}
				else
				{
					darkDockGroup_0 = this.method_7();
				}
			}
			darkDockContent_0.method_8(this);
			darkDockGroup_0.method_11(darkDockContent_0);
			if (!base.Visible)
			{
				base.Visible = true;
				this.method_13();
			}
			this.method_10();
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00064DA4 File Offset: 0x00062FA4
		internal void method_5(DarkDockContent darkDockContent_0, DarkDockGroup darkDockGroup_0, Enum15 enum15_0)
		{
			int num = darkDockGroup_0.method_8();
			if (enum15_0 == Enum15.const_2)
			{
				num++;
			}
			DarkDockGroup darkDockGroup = this.method_8(num);
			darkDockContent_0.method_8(this);
			darkDockGroup.method_11(darkDockContent_0);
			if (!base.Visible)
			{
				base.Visible = true;
				this.method_13();
			}
			this.method_10();
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00064DF0 File Offset: 0x00062FF0
		internal void method_6(DarkDockContent darkDockContent_0)
		{
			darkDockContent_0.method_8(null);
			DarkDockGroup darkDockGroup = darkDockContent_0.method_9();
			darkDockGroup.method_12(darkDockContent_0);
			darkDockContent_0.method_12(Enum13.const_0);
			if (darkDockGroup.method_10() == 0)
			{
				this.method_9(darkDockGroup);
			}
			if (this.list_0.Count == 0 && this.method_2() != Enum13.const_1)
			{
				base.Visible = false;
				this.method_14();
			}
			this.method_10();
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00064E54 File Offset: 0x00063054
		private DarkDockGroup method_7()
		{
			int num = 0;
			if (this.list_0.Count >= 1)
			{
				num = -1;
				foreach (DarkDockGroup darkDockGroup in this.list_0)
				{
					if (darkDockGroup.method_8() >= num)
					{
						num = darkDockGroup.method_8() + 1;
					}
				}
			}
			DarkDockGroup darkDockGroup2 = new DarkDockGroup(this.method_0(), this, num);
			this.list_0.Add(darkDockGroup2);
			base.Controls.Add(darkDockGroup2);
			return darkDockGroup2;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00064EEC File Offset: 0x000630EC
		private DarkDockGroup method_8(int int_0)
		{
			foreach (DarkDockGroup darkDockGroup in this.list_0)
			{
				if (darkDockGroup.method_8() >= int_0)
				{
					DarkDockGroup darkDockGroup2 = darkDockGroup;
					int num = darkDockGroup2.method_8();
					darkDockGroup2.method_9(num + 1);
				}
			}
			DarkDockGroup darkDockGroup3 = new DarkDockGroup(this.method_0(), this, int_0);
			this.list_0.Add(darkDockGroup3);
			base.Controls.Add(darkDockGroup3);
			return darkDockGroup3;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00064F7C File Offset: 0x0006317C
		private void method_9(DarkDockGroup darkDockGroup_0)
		{
			int num = darkDockGroup_0.method_8();
			this.list_0.Remove(darkDockGroup_0);
			base.Controls.Remove(darkDockGroup_0);
			foreach (DarkDockGroup darkDockGroup in this.list_0)
			{
				if (darkDockGroup.method_8() > num)
				{
					DarkDockGroup darkDockGroup2 = darkDockGroup;
					int num2 = darkDockGroup2.method_8();
					darkDockGroup2.method_9(num2 - 1);
				}
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00065004 File Offset: 0x00063204
		private void method_10()
		{
			DockStyle dock;
			switch (this.method_2())
			{
			default:
				dock = DockStyle.Fill;
				break;
			case Enum13.const_2:
			case Enum13.const_3:
				dock = DockStyle.Top;
				break;
			case Enum13.const_4:
				dock = DockStyle.Left;
				break;
			}
			if (this.list_0.Count == 1)
			{
				this.list_0[0].Dock = DockStyle.Fill;
				return;
			}
			if (this.list_0.Count > 1)
			{
				DarkDockGroup darkDockGroup = Enumerable.First<DarkDockGroup>(Enumerable.OrderByDescending<DarkDockGroup, int>(this.list_0, new Func<DarkDockGroup, int>(DarkDockRegion.<>c.<>9.method_0)));
				foreach (DarkDockGroup darkDockGroup2 in Enumerable.OrderByDescending<DarkDockGroup, int>(this.list_0, new Func<DarkDockGroup, int>(DarkDockRegion.<>c.<>9.method_1)))
				{
					darkDockGroup2.SendToBack();
					if (darkDockGroup2.method_8() == darkDockGroup.method_8())
					{
						darkDockGroup2.Dock = DockStyle.Fill;
					}
					else
					{
						darkDockGroup2.Dock = dock;
					}
				}
				this.method_11();
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0006512C File Offset: 0x0006332C
		private void method_11()
		{
			if (this.list_0.Count <= 1)
			{
				return;
			}
			Size size = new Size(0, 0);
			switch (this.method_2())
			{
			default:
				return;
			case Enum13.const_2:
			case Enum13.const_3:
				size = new Size(base.ClientRectangle.Width, base.ClientRectangle.Height / this.list_0.Count);
				break;
			case Enum13.const_4:
				size = new Size(base.ClientRectangle.Width / this.list_0.Count, base.ClientRectangle.Height);
				break;
			}
			foreach (DarkDockGroup darkDockGroup in this.list_0)
			{
				darkDockGroup.Size = size;
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00065218 File Offset: 0x00063418
		private void method_12()
		{
			this.MinimumSize = new Size(50, 50);
			switch (this.method_2())
			{
			default:
				this.Dock = DockStyle.Fill;
				base.Padding = new Padding(0, 1, 0, 0);
				return;
			case Enum13.const_2:
				this.Dock = DockStyle.Left;
				base.Padding = new Padding(0, 0, 1, 0);
				base.Visible = false;
				return;
			case Enum13.const_3:
				this.Dock = DockStyle.Right;
				base.Padding = new Padding(1, 0, 0, 0);
				base.Visible = false;
				return;
			case Enum13.const_4:
				this.Dock = DockStyle.Bottom;
				base.Padding = new Padding(0, 0, 0, 0);
				base.Visible = false;
				return;
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000652C4 File Offset: 0x000634C4
		private void method_13()
		{
			if (this.class107_0 != null && this.method_0().method_7().Contains(this.class107_0))
			{
				this.method_0().method_7().Remove(this.class107_0);
			}
			switch (this.method_2())
			{
			case Enum13.const_2:
				this.class107_0 = new Class107(this.method_0(), this, Enum14.const_1);
				break;
			case Enum13.const_3:
				this.class107_0 = new Class107(this.method_0(), this, Enum14.const_0);
				break;
			case Enum13.const_4:
				this.class107_0 = new Class107(this.method_0(), this, Enum14.const_2);
				break;
			default:
				return;
			}
			this.method_0().method_7().Add(this.class107_0);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00005379 File Offset: 0x00003579
		private void method_14()
		{
			if (this.method_0().method_7().Contains(this.class107_0))
			{
				this.method_0().method_7().Remove(this.class107_0);
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000053AA File Offset: 0x000035AA
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			this.form_0 = base.FindForm();
			this.form_0.ResizeEnd += this.form_0_ResizeEnd;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000053D5 File Offset: 0x000035D5
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.method_11();
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000053E4 File Offset: 0x000035E4
		private void form_0_ResizeEnd(object sender, EventArgs e)
		{
			if (this.class107_0 != null)
			{
				this.class107_0.method_8();
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x000053F9 File Offset: 0x000035F9
		protected override void OnLayout(LayoutEventArgs e)
		{
			base.OnLayout(e);
			if (this.class107_0 != null)
			{
				this.class107_0.method_8();
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00065378 File Offset: 0x00063578
		public void method_15()
		{
			base.Invalidate();
			foreach (DarkDockGroup darkDockGroup in this.list_0)
			{
				darkDockGroup.method_21();
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000653D0 File Offset: 0x000635D0
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			if (!base.Visible)
			{
				return;
			}
			using (SolidBrush solidBrush = new SolidBrush(Class129.smethod_0()))
			{
				graphics.FillRectangle(solidBrush, base.ClientRectangle);
			}
			using (Pen pen = new Pen(Class129.smethod_10()))
			{
				if (this.method_2() == Enum13.const_1)
				{
					graphics.DrawLine(pen, base.ClientRectangle.Left, 0, base.ClientRectangle.Right, 0);
				}
				if (this.method_2() == Enum13.const_3)
				{
					graphics.DrawLine(pen, base.ClientRectangle.Left, 0, base.ClientRectangle.Left, base.ClientRectangle.Height);
				}
				if (this.method_2() == Enum13.const_2)
				{
					graphics.DrawLine(pen, base.ClientRectangle.Right - 1, 0, base.ClientRectangle.Right - 1, base.ClientRectangle.Height);
				}
			}
		}

		// Token: 0x0400030B RID: 779
		private List<DarkDockGroup> list_0;

		// Token: 0x0400030C RID: 780
		private Form form_0;

		// Token: 0x0400030D RID: 781
		private Class107 class107_0;

		// Token: 0x0400030E RID: 782
		[CompilerGenerated]
		private DarkDockPanel darkDockPanel_0;

		// Token: 0x0400030F RID: 783
		[CompilerGenerated]
		private Enum13 enum13_0;
	}
}
