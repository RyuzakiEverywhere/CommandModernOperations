using System;
using System.Runtime.CompilerServices;
using ns0;

namespace Gameloop.Vdf
{
	// Token: 0x0200001F RID: 31
	public abstract class VdfWriter : IDisposable
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00002BAB File Offset: 0x00000DAB
		[CompilerGenerated]
		public Class11 method_0()
		{
			return this.class11_0;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002BB3 File Offset: 0x00000DB3
		[CompilerGenerated]
		public bool method_1()
		{
			return this.bool_0;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002BBB File Offset: 0x00000DBB
		[CompilerGenerated]
		public void method_2(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[CompilerGenerated]
		protected internal VdfWriter.State method_3()
		{
			return this.state_0;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002BCC File Offset: 0x00000DCC
		[CompilerGenerated]
		protected void method_4(VdfWriter.State state_1)
		{
			this.state_0 = state_1;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002BD5 File Offset: 0x00000DD5
		protected VdfWriter() : this(Class11.smethod_0())
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002BE2 File Offset: 0x00000DE2
		protected VdfWriter(Class11 class11_1)
		{
			this.class11_0 = class11_1;
			this.method_4(VdfWriter.State.const_0);
			this.method_2(true);
		}

		// Token: 0x0600004B RID: 75
		public abstract void vmethod_0();

		// Token: 0x0600004C RID: 76
		public abstract void vmethod_1();

		// Token: 0x0600004D RID: 77
		public abstract void vmethod_2(string string_0);

		// Token: 0x0600004E RID: 78
		public abstract void vmethod_3(Class42 class42_0);

		// Token: 0x0600004F RID: 79 RVA: 0x00002BFF File Offset: 0x00000DFF
		void IDisposable.Dispose()
		{
			if (this.method_3() == VdfWriter.State.const_6)
			{
				return;
			}
			this.vmethod_4();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002C11 File Offset: 0x00000E11
		public virtual void vmethod_4()
		{
			this.method_4(VdfWriter.State.const_6);
		}

		// Token: 0x04000060 RID: 96
		[CompilerGenerated]
		private readonly Class11 class11_0;

		// Token: 0x04000061 RID: 97
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000062 RID: 98
		[CompilerGenerated]
		private VdfWriter.State state_0;

		// Token: 0x02000020 RID: 32
		protected internal enum State
		{
			// Token: 0x04000064 RID: 100
			const_0,
			// Token: 0x04000065 RID: 101
			const_1,
			// Token: 0x04000066 RID: 102
			Value,
			// Token: 0x04000067 RID: 103
			const_3,
			// Token: 0x04000068 RID: 104
			const_4,
			// Token: 0x04000069 RID: 105
			const_5,
			// Token: 0x0400006A RID: 106
			const_6
		}
	}
}
