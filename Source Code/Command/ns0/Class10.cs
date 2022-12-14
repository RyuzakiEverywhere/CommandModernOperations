using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x0200001A RID: 26
	internal abstract class Class10 : IDisposable
	{
		// Token: 0x0600002D RID: 45 RVA: 0x000029E5 File Offset: 0x00000BE5
		[CompilerGenerated]
		public void method_0(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000029EE File Offset: 0x00000BEE
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000029F6 File Offset: 0x00000BF6
		public string Value { get; set; }

		// Token: 0x06000030 RID: 48 RVA: 0x000029FF File Offset: 0x00000BFF
		[CompilerGenerated]
		protected internal Class10.Enum0 method_1()
		{
			return this.enum0_0;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002A07 File Offset: 0x00000C07
		[CompilerGenerated]
		protected void method_2(Class10.Enum0 enum0_1)
		{
			this.enum0_0 = enum0_1;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002A10 File Offset: 0x00000C10
		protected Class10() : this(Class11.smethod_0())
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002A1D File Offset: 0x00000C1D
		protected Class10(Class11 class11_1)
		{
			this.class11_0 = class11_1;
			this.method_2(Class10.Enum0.const_0);
			this.Value = null;
			this.method_0(true);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002A41 File Offset: 0x00000C41
		void IDisposable.Dispose()
		{
			if (this.method_1() == Class10.Enum0.const_5)
			{
				return;
			}
			this.vmethod_0();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002A53 File Offset: 0x00000C53
		public virtual void vmethod_0()
		{
			this.method_2(Class10.Enum0.const_5);
			this.Value = null;
		}

		// Token: 0x0400004B RID: 75
		[CompilerGenerated]
		private readonly Class11 class11_0;

		// Token: 0x0400004C RID: 76
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400004D RID: 77
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400004E RID: 78
		[CompilerGenerated]
		private Class10.Enum0 enum0_0;

		// Token: 0x0200001B RID: 27
		protected internal enum Enum0
		{
			// Token: 0x04000050 RID: 80
			const_0,
			// Token: 0x04000051 RID: 81
			const_1,
			// Token: 0x04000052 RID: 82
			const_2,
			// Token: 0x04000053 RID: 83
			const_3,
			// Token: 0x04000054 RID: 84
			const_4,
			// Token: 0x04000055 RID: 85
			const_5
		}
	}
}
