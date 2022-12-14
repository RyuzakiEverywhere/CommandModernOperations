using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ns3
{
	// Token: 0x0200008B RID: 139
	internal struct Struct15
	{
		// Token: 0x060002DA RID: 730 RVA: 0x00004925 File Offset: 0x00002B25
		[CompilerGenerated]
		public void method_0(int int_5)
		{
			this.int_0 = int_5;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000492E File Offset: 0x00002B2E
		[CompilerGenerated]
		public int method_1()
		{
			return this.int_1;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00004936 File Offset: 0x00002B36
		[CompilerGenerated]
		public void method_2(int int_5)
		{
			this.int_1 = int_5;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000493F File Offset: 0x00002B3F
		[CompilerGenerated]
		public int method_3()
		{
			return this.int_2;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00004947 File Offset: 0x00002B47
		[CompilerGenerated]
		public void method_4(int int_5)
		{
			this.int_2 = int_5;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00004950 File Offset: 0x00002B50
		[CompilerGenerated]
		public Enum7 method_5()
		{
			return this.enum7_0;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00004958 File Offset: 0x00002B58
		[CompilerGenerated]
		public void method_6(Enum7 enum7_1)
		{
			this.enum7_0 = enum7_1;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00004961 File Offset: 0x00002B61
		[CompilerGenerated]
		public int method_7()
		{
			return this.int_3;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00004969 File Offset: 0x00002B69
		[CompilerGenerated]
		public void method_8(int int_5)
		{
			this.int_3 = int_5;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00004972 File Offset: 0x00002B72
		[CompilerGenerated]
		public int method_9()
		{
			return this.int_4;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000497A File Offset: 0x00002B7A
		[CompilerGenerated]
		public void method_10(int int_5)
		{
			this.int_4 = int_5;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0006088C File Offset: 0x0005EA8C
		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, "{0} by {1}, {2}, {3} Bit, {4} Hertz", new object[]
			{
				this.method_1(),
				this.method_3(),
				(int)this.method_5(),
				this.method_7(),
				this.method_9()
			});
		}

		// Token: 0x04000236 RID: 566
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000237 RID: 567
		[CompilerGenerated]
		private int int_1;

		// Token: 0x04000238 RID: 568
		[CompilerGenerated]
		private int int_2;

		// Token: 0x04000239 RID: 569
		[CompilerGenerated]
		private Enum7 enum7_0;

		// Token: 0x0400023A RID: 570
		[CompilerGenerated]
		private int int_3;

		// Token: 0x0400023B RID: 571
		[CompilerGenerated]
		private int int_4;
	}
}
