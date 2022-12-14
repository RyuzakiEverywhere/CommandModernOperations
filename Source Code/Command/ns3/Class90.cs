using System;
using System.Runtime.CompilerServices;
using DiskQueue.Implementation;

namespace ns3
{
	// Token: 0x02000095 RID: 149
	internal sealed class Class90 : IEquatable<Class90>
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x000049CC File Offset: 0x00002BCC
		public Class90(int int_3, int int_4, int int_5)
		{
			this.method_1(int_3);
			this.method_3(int_4);
			this.method_5(int_5);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000049E9 File Offset: 0x00002BE9
		public Class90(Operation operation_0) : this(operation_0.method_2(), operation_0.method_4(), operation_0.method_6())
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00004A03 File Offset: 0x00002C03
		[CompilerGenerated]
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00004A0B File Offset: 0x00002C0B
		[CompilerGenerated]
		public void method_1(int int_3)
		{
			this.int_0 = int_3;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00004A14 File Offset: 0x00002C14
		[CompilerGenerated]
		public int method_2()
		{
			return this.int_1;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00004A1C File Offset: 0x00002C1C
		[CompilerGenerated]
		public void method_3(int int_3)
		{
			this.int_1 = int_3;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00004A25 File Offset: 0x00002C25
		[CompilerGenerated]
		public int method_4()
		{
			return this.int_2;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00004A2D File Offset: 0x00002C2D
		[CompilerGenerated]
		public void method_5(int int_3)
		{
			this.int_2 = int_3;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00004A36 File Offset: 0x00002C36
		public bool Equals(Class90 other)
		{
			return other != null && (this == other || (other.method_0() == this.method_0() && other.method_2() == this.method_2() && other.method_4() == this.method_4()));
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00004A6F File Offset: 0x00002C6F
		public override bool Equals(object obj)
		{
			return obj != null && (this == obj || this.Equals(obj as Class90));
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00004A88 File Offset: 0x00002C88
		public override int GetHashCode()
		{
			return (this.method_0() * 397 ^ this.method_2()) * 397 ^ this.method_4();
		}

		// Token: 0x0400026C RID: 620
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400026D RID: 621
		[CompilerGenerated]
		private int int_1;

		// Token: 0x0400026E RID: 622
		[CompilerGenerated]
		private int int_2;
	}
}
