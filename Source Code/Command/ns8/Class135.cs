using System;
using System.Collections.Generic;
using CSMaterial.ClipperLib;

namespace ns8
{
	// Token: 0x020000EB RID: 235
	internal sealed class Class135
	{
		// Token: 0x060005F9 RID: 1529 RVA: 0x000066C0 File Offset: 0x000048C0
		public int method_0()
		{
			return this.list_1.Count;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0006D624 File Offset: 0x0006B824
		internal void method_1(Class135 class135_1)
		{
			int count = this.list_1.Count;
			this.list_1.Add(class135_1);
			class135_1.class135_0 = this;
			class135_1.int_0 = count;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x000066CD File Offset: 0x000048CD
		public List<Class135> method_2()
		{
			return this.list_1;
		}

		// Token: 0x0400040A RID: 1034
		internal Class135 class135_0;

		// Token: 0x0400040B RID: 1035
		internal List<IntPoint> list_0 = new List<IntPoint>();

		// Token: 0x0400040C RID: 1036
		internal int int_0;

		// Token: 0x0400040D RID: 1037
		internal Enum22 enum22_0;

		// Token: 0x0400040E RID: 1038
		internal Enum23 enum23_0;

		// Token: 0x0400040F RID: 1039
		internal List<Class135> list_1 = new List<Class135>();
	}
}
