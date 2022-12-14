using System;

namespace ns8
{
	// Token: 0x020000EC RID: 236
	internal struct Struct19
	{
		// Token: 0x060005FD RID: 1533 RVA: 0x000066F3 File Offset: 0x000048F3
		public Struct19(long long_1, ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
			this.long_0 = long_1;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0006D658 File Offset: 0x0006B858
		public static bool smethod_0(Struct19 struct19_0, Struct19 struct19_1)
		{
			return struct19_0 == struct19_1 || (struct19_0 != null && struct19_1 != null && struct19_0.long_0 == struct19_1.long_0 && struct19_0.ulong_0 == struct19_1.ulong_0);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0006D6A8 File Offset: 0x0006B8A8
		public override bool Equals(object obj)
		{
			if (obj != null && obj is Struct19)
			{
				Struct19 @struct = (Struct19)obj;
				return @struct.long_0 == this.long_0 && @struct.ulong_0 == this.ulong_0;
			}
			return false;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00006703 File Offset: 0x00004903
		public override int GetHashCode()
		{
			return this.long_0.GetHashCode() ^ this.ulong_0.GetHashCode();
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0000671C File Offset: 0x0000491C
		public static Struct19 smethod_1(Struct19 struct19_0)
		{
			if (struct19_0.ulong_0 == 0UL)
			{
				return new Struct19(-struct19_0.long_0, 0UL);
			}
			return new Struct19(~struct19_0.long_0, ~struct19_0.ulong_0 + 1UL);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0006D6E8 File Offset: 0x0006B8E8
		public static Struct19 smethod_2(long long_1, long long_2)
		{
			bool flag = long_1 < 0L != long_2 < 0L;
			if (long_1 < 0L)
			{
				long_1 = -long_1;
			}
			if (long_2 < 0L)
			{
				long_2 = -long_2;
			}
			ulong num = (ulong)long_1 >> 32;
			ulong num2 = (ulong)(long_1 & 4294967295L);
			ulong num3 = (ulong)long_2 >> 32;
			ulong num4 = (ulong)(long_2 & 4294967295L);
			ulong num5 = num * num3;
			ulong num6 = num2 * num4;
			ulong num7 = num * num4 + num2 * num3;
			long num8 = (long)(num5 + (num7 >> 32));
			ulong num9 = (num7 << 32) + num6;
			if (num9 < num6)
			{
				num8 += 1L;
			}
			Struct19 @struct = new Struct19(num8, num9);
			if (!flag)
			{
				return @struct;
			}
			return Struct19.smethod_1(@struct);
		}

		// Token: 0x04000410 RID: 1040
		private long long_0;

		// Token: 0x04000411 RID: 1041
		private ulong ulong_0;
	}
}
