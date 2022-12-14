using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DarkUI.Docking;
using ns3;

namespace ns2
{
	// Token: 0x020000BA RID: 186
	internal sealed class Class108
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x00005502 File Offset: 0x00003702
		[CompilerGenerated]
		private void method_0(Enum13 enum13_1)
		{
			this.enum13_0 = enum13_1;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000550B File Offset: 0x0000370B
		[CompilerGenerated]
		public Rectangle method_1()
		{
			return this.rectangle_0;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00005513 File Offset: 0x00003713
		[CompilerGenerated]
		public void method_2(Rectangle rectangle_2)
		{
			this.rectangle_0 = rectangle_2;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000551C File Offset: 0x0000371C
		[CompilerGenerated]
		public Rectangle method_3()
		{
			return this.rectangle_1;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00005524 File Offset: 0x00003724
		[CompilerGenerated]
		public void method_4(Rectangle rectangle_2)
		{
			this.rectangle_1 = rectangle_2;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000552D File Offset: 0x0000372D
		[CompilerGenerated]
		public bool method_5()
		{
			return this.bool_0;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00005535 File Offset: 0x00003735
		[CompilerGenerated]
		public void method_6(bool bool_2)
		{
			this.bool_0 = bool_2;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000553E File Offset: 0x0000373E
		[CompilerGenerated]
		public int method_7()
		{
			return this.int_0;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00005546 File Offset: 0x00003746
		[CompilerGenerated]
		public void method_8(int int_2)
		{
			this.int_0 = int_2;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000554F File Offset: 0x0000374F
		[CompilerGenerated]
		public int method_9()
		{
			return this.int_1;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00005557 File Offset: 0x00003757
		[CompilerGenerated]
		public void method_10(int int_2)
		{
			this.int_1 = int_2;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00005560 File Offset: 0x00003760
		[CompilerGenerated]
		public bool method_11()
		{
			return this.bool_1;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00005568 File Offset: 0x00003768
		[CompilerGenerated]
		public void method_12(bool bool_2)
		{
			this.bool_1 = bool_2;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00005571 File Offset: 0x00003771
		[CompilerGenerated]
		public DarkDockTab method_13()
		{
			return this.darkDockTab_0;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00005579 File Offset: 0x00003779
		[CompilerGenerated]
		public void method_14(DarkDockTab darkDockTab_1)
		{
			this.darkDockTab_0 = darkDockTab_1;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00005582 File Offset: 0x00003782
		public Class108(Enum13 enum13_1)
		{
			this.method_0(enum13_1);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000055B2 File Offset: 0x000037B2
		public void method_15(Control control_0, Point point_0)
		{
			this.class113_0.Show(control_0, point_0);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000055C1 File Offset: 0x000037C1
		public void method_16(ToolStripMenuItem toolStripMenuItem_0)
		{
			this.list_0.Add(toolStripMenuItem_0);
			this.method_19();
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x000055D5 File Offset: 0x000037D5
		public void method_17(ToolStripMenuItem toolStripMenuItem_0)
		{
			this.list_0.Remove(toolStripMenuItem_0);
			this.method_19();
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00065940 File Offset: 0x00063B40
		public ToolStripMenuItem method_18(DarkDockContent darkDockContent_0)
		{
			ToolStripMenuItem result = null;
			foreach (ToolStripMenuItem toolStripMenuItem in this.list_0)
			{
				DarkDockContent darkDockContent = toolStripMenuItem.Tag as DarkDockContent;
				if (darkDockContent != null && darkDockContent == darkDockContent_0)
				{
					result = toolStripMenuItem;
				}
			}
			return result;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000659A8 File Offset: 0x00063BA8
		public void method_19()
		{
			this.class113_0.Items.Clear();
			List<ToolStripMenuItem> list = new List<ToolStripMenuItem>();
			int num = 0;
			for (int i = 0; i < this.list_0.Count; i++)
			{
				foreach (ToolStripMenuItem toolStripMenuItem in this.list_0)
				{
					if (((DarkDockContent)toolStripMenuItem.Tag).method_13() == num)
					{
						list.Add(toolStripMenuItem);
					}
				}
				num++;
			}
			foreach (ToolStripMenuItem value in list)
			{
				this.class113_0.Items.Add(value);
			}
		}

		// Token: 0x04000321 RID: 801
		private Dictionary<DarkDockContent, DarkDockTab> dictionary_0 = new Dictionary<DarkDockContent, DarkDockTab>();

		// Token: 0x04000322 RID: 802
		private List<ToolStripMenuItem> list_0 = new List<ToolStripMenuItem>();

		// Token: 0x04000323 RID: 803
		private Class113 class113_0 = new Class113();

		// Token: 0x04000324 RID: 804
		[CompilerGenerated]
		private Enum13 enum13_0;

		// Token: 0x04000325 RID: 805
		[CompilerGenerated]
		private Rectangle rectangle_0;

		// Token: 0x04000326 RID: 806
		[CompilerGenerated]
		private Rectangle rectangle_1;

		// Token: 0x04000327 RID: 807
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000328 RID: 808
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000329 RID: 809
		[CompilerGenerated]
		private int int_1;

		// Token: 0x0400032A RID: 810
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x0400032B RID: 811
		[CompilerGenerated]
		private DarkDockTab darkDockTab_0;
	}
}
