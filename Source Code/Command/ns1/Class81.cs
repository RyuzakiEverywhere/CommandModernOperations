using System;
using System.Runtime.CompilerServices;

namespace ns1
{
	// Token: 0x0200007F RID: 127
	internal sealed class Class81
	{
		// Token: 0x0600025B RID: 603 RVA: 0x00002977 File Offset: 0x00000B77
		public Class81()
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000040B0 File Offset: 0x000022B0
		public Class81(double double_4, double double_5, double double_6)
		{
			this.method_1(double_4);
			this.method_3(double_5);
			this.method_5(double_6);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000040CD File Offset: 0x000022CD
		[CompilerGenerated]
		public double method_0()
		{
			return this.double_0;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000040D5 File Offset: 0x000022D5
		[CompilerGenerated]
		public void method_1(double double_4)
		{
			this.double_0 = double_4;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000040DE File Offset: 0x000022DE
		[CompilerGenerated]
		public double method_2()
		{
			return this.double_1;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000040E6 File Offset: 0x000022E6
		[CompilerGenerated]
		public void method_3(double double_4)
		{
			this.double_1 = double_4;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000040EF File Offset: 0x000022EF
		[CompilerGenerated]
		public double method_4()
		{
			return this.double_2;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000040F7 File Offset: 0x000022F7
		[CompilerGenerated]
		public void method_5(double double_4)
		{
			this.double_2 = double_4;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00004100 File Offset: 0x00002300
		[CompilerGenerated]
		public double method_6()
		{
			return this.double_3;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00004108 File Offset: 0x00002308
		[CompilerGenerated]
		public void method_7(double double_4)
		{
			this.double_3 = double_4;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00004111 File Offset: 0x00002311
		public void method_8(double double_4)
		{
			this.method_1(this.method_0() * double_4);
			this.method_3(this.method_2() * double_4);
			this.method_5(this.method_4() * double_4);
			this.method_7(this.method_6() * Math.Abs(double_4));
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00004150 File Offset: 0x00002350
		public double method_9()
		{
			return Math.Sqrt(this.method_0() * this.method_0() + this.method_2() * this.method_2() + this.method_4() * this.method_4());
		}

		// Token: 0x040001E3 RID: 483
		[CompilerGenerated]
		private double double_0;

		// Token: 0x040001E4 RID: 484
		[CompilerGenerated]
		private double double_1;

		// Token: 0x040001E5 RID: 485
		[CompilerGenerated]
		private double double_2;

		// Token: 0x040001E6 RID: 486
		[CompilerGenerated]
		private double double_3;
	}
}
