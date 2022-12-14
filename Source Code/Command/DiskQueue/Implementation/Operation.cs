using System;
using System.Runtime.CompilerServices;
using ns3;

namespace DiskQueue.Implementation
{
	// Token: 0x02000097 RID: 151
	public sealed class Operation
	{
		// Token: 0x06000302 RID: 770 RVA: 0x00004AAA File Offset: 0x00002CAA
		public Operation(Enum9 enum9_1, int int_3, int int_4, int int_5)
		{
			this.method_1(enum9_1);
			this.method_3(int_3);
			this.method_5(int_4);
			this.method_7(int_5);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00004ACF File Offset: 0x00002CCF
		[CompilerGenerated]
		public Enum9 method_0()
		{
			return this.enum9_0;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00004AD7 File Offset: 0x00002CD7
		[CompilerGenerated]
		public void method_1(Enum9 enum9_1)
		{
			this.enum9_0 = enum9_1;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00004AE0 File Offset: 0x00002CE0
		[CompilerGenerated]
		public int method_2()
		{
			return this.int_0;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[CompilerGenerated]
		public void method_3(int int_3)
		{
			this.int_0 = int_3;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00004AF1 File Offset: 0x00002CF1
		[CompilerGenerated]
		public int method_4()
		{
			return this.int_1;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00004AF9 File Offset: 0x00002CF9
		[CompilerGenerated]
		public void method_5(int int_3)
		{
			this.int_1 = int_3;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00004B02 File Offset: 0x00002D02
		[CompilerGenerated]
		public int method_6()
		{
			return this.int_2;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00004B0A File Offset: 0x00002D0A
		[CompilerGenerated]
		public void method_7(int int_3)
		{
			this.int_2 = int_3;
		}

		// Token: 0x0400026F RID: 623
		[CompilerGenerated]
		private Enum9 enum9_0;

		// Token: 0x04000270 RID: 624
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000271 RID: 625
		[CompilerGenerated]
		private int int_1;

		// Token: 0x04000272 RID: 626
		[CompilerGenerated]
		private int int_2;
	}
}
