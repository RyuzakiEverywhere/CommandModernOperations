using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DarkUI.Docking;
using ns2;
using ns8;

namespace ns3
{
	// Token: 0x020000A5 RID: 165
	internal sealed class Class101 : IMessageFilter
	{
		// Token: 0x06000346 RID: 838 RVA: 0x00004EC0 File Offset: 0x000030C0
		public Class101(DarkDockPanel darkDockPanel_1)
		{
			this.darkDockPanel_0 = darkDockPanel_1;
			this.form2_0 = new Form2(Class129.smethod_14(), 0.6);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000612A8 File Offset: 0x0005F4A8
		public bool PreFilterMessage(ref Message m)
		{
			if (!this.bool_0)
			{
				return false;
			}
			if (m.Msg != 512 && m.Msg != 513 && m.Msg != 514 && m.Msg != 515 && m.Msg != 516 && m.Msg != 517 && m.Msg != 518)
			{
				return false;
			}
			if (m.Msg == 512)
			{
				this.method_2();
				return false;
			}
			if (m.Msg == 514)
			{
				if (this.darkDockRegion_0 != null)
				{
					this.darkDockPanel_0.method_13(this.darkDockContent_0);
					this.darkDockContent_0.method_12(this.darkDockRegion_0.method_2());
					this.darkDockPanel_0.method_10(this.darkDockContent_0);
				}
				else if (this.darkDockGroup_0 != null)
				{
					this.darkDockPanel_0.method_13(this.darkDockContent_0);
					Enum15 @enum = this.enum15_0;
					if (@enum != Enum15.const_0)
					{
						if (@enum - Enum15.const_1 <= 1)
						{
							this.darkDockPanel_0.method_12(this.darkDockContent_0, this.darkDockGroup_0, this.enum15_0);
						}
					}
					else
					{
						this.darkDockPanel_0.method_11(this.darkDockContent_0, this.darkDockGroup_0);
					}
				}
				this.method_0();
				return false;
			}
			return true;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00004EFE File Offset: 0x000030FE
		private void method_0()
		{
			Cursor.Current = Cursors.Default;
			this.form2_0.Hide();
			this.darkDockContent_0 = null;
			this.bool_0 = false;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000613EC File Offset: 0x0005F5EC
		private void method_1(Rectangle rectangle_0)
		{
			Cursor.Current = Cursors.SizeAll;
			this.form2_0.SuspendLayout();
			this.form2_0.Size = new Size(rectangle_0.Width, rectangle_0.Height);
			this.form2_0.Location = new Point(rectangle_0.X, rectangle_0.Y);
			this.form2_0.ResumeLayout();
			if (!this.form2_0.Visible)
			{
				this.form2_0.Show();
				this.form2_0.BringToFront();
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00061478 File Offset: 0x0005F678
		private void method_2()
		{
			Point position = Cursor.Position;
			this.enum15_0 = Enum15.const_0;
			this.darkDockRegion_0 = null;
			this.darkDockGroup_0 = null;
			foreach (Class109 @class in this.dictionary_0.Values)
			{
				if (@class.method_0().Contains(position))
				{
					this.enum15_0 = Enum15.const_0;
					this.darkDockRegion_0 = @class.method_2();
					this.method_1(@class.method_1());
					return;
				}
			}
			foreach (Class110 class2 in this.dictionary_1.Values)
			{
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				if (class2.method_0().method_3() == this.darkDockContent_0.method_9())
				{
					flag2 = true;
				}
				if (class2.method_0().method_3().method_2() == this.darkDockContent_0.method_7())
				{
					flag = true;
				}
				if (this.darkDockContent_0.method_9().method_10() > 1)
				{
					flag3 = true;
				}
				if (!flag2 || flag3)
				{
					bool flag4 = false;
					bool flag5 = false;
					if (flag && !flag3)
					{
						if (class2.method_1().method_3().method_8() == this.darkDockContent_0.method_9().method_8() + 1)
						{
							flag4 = true;
						}
						if (class2.method_2().method_3().method_8() == this.darkDockContent_0.method_9().method_8() - 1)
						{
							flag5 = true;
						}
					}
					if (!flag4 && class2.method_1().method_0().Contains(position))
					{
						this.enum15_0 = Enum15.const_1;
						this.darkDockGroup_0 = class2.method_1().method_3();
						this.method_1(class2.method_1().method_1());
						return;
					}
					if (!flag5 && class2.method_2().method_0().Contains(position))
					{
						this.enum15_0 = Enum15.const_2;
						this.darkDockGroup_0 = class2.method_2().method_3();
						this.method_1(class2.method_2().method_1());
						return;
					}
				}
				if (!flag2 && class2.method_0().method_0().Contains(position))
				{
					this.enum15_0 = Enum15.const_0;
					this.darkDockGroup_0 = class2.method_0().method_3();
					this.method_1(class2.method_0().method_1());
					return;
				}
			}
			if (this.form2_0.Visible)
			{
				this.form2_0.Hide();
			}
			Cursor.Current = Cursors.No;
		}

		// Token: 0x040002B3 RID: 691
		private DarkDockPanel darkDockPanel_0;

		// Token: 0x040002B4 RID: 692
		private DarkDockContent darkDockContent_0;

		// Token: 0x040002B5 RID: 693
		private Form2 form2_0;

		// Token: 0x040002B6 RID: 694
		private bool bool_0;

		// Token: 0x040002B7 RID: 695
		private DarkDockRegion darkDockRegion_0;

		// Token: 0x040002B8 RID: 696
		private DarkDockGroup darkDockGroup_0;

		// Token: 0x040002B9 RID: 697
		private Enum15 enum15_0;

		// Token: 0x040002BA RID: 698
		private Dictionary<DarkDockRegion, Class109> dictionary_0 = new Dictionary<DarkDockRegion, Class109>();

		// Token: 0x040002BB RID: 699
		private Dictionary<DarkDockGroup, Class110> dictionary_1 = new Dictionary<DarkDockGroup, Class110>();
	}
}
