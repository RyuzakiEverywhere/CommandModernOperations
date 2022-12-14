using System;
using System.Runtime.CompilerServices;

namespace ns1
{
	// Token: 0x02000071 RID: 113
	internal class Class71
	{
		// Token: 0x06000201 RID: 513 RVA: 0x00003D4F File Offset: 0x00001F4F
		[CompilerGenerated]
		public Class81 method_0()
		{
			return this.class81_0;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00003D57 File Offset: 0x00001F57
		[CompilerGenerated]
		protected void method_1(Class81 class81_2)
		{
			this.class81_0 = class81_2;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00003D60 File Offset: 0x00001F60
		[CompilerGenerated]
		public Class81 method_2()
		{
			return this.class81_1;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00003D68 File Offset: 0x00001F68
		[CompilerGenerated]
		protected void method_3(Class81 class81_2)
		{
			this.class81_1 = class81_2;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00003D71 File Offset: 0x00001F71
		public Class71() : this(new Class81(), new Class81())
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00003D83 File Offset: 0x00001F83
		public Class71(Class81 class81_2, Class81 class81_3)
		{
			this.method_1(class81_2);
			this.method_3(class81_3);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00003D99 File Offset: 0x00001F99
		public void method_4(double double_0)
		{
			this.method_0().method_8(double_0);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00003DA7 File Offset: 0x00001FA7
		public void method_5(double double_0)
		{
			this.method_2().method_8(double_0);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0005A380 File Offset: 0x00058580
		public override string ToString()
		{
			return string.Format("km:({0:F0}, {1:F0}, {2:F0}) km/s:({3:F1}, {4:F1}, {5:F1})", new object[]
			{
				this.method_0().method_0(),
				this.method_0().method_2(),
				this.method_0().method_4(),
				this.method_2().method_0(),
				this.method_2().method_2(),
				this.method_2().method_4()
			});
		}

		// Token: 0x0400014E RID: 334
		[CompilerGenerated]
		private Class81 class81_0;

		// Token: 0x0400014F RID: 335
		[CompilerGenerated]
		private Class81 class81_1;
	}
}
