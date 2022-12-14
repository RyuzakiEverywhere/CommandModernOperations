using System;

namespace ns5
{
	// Token: 0x02000D4C RID: 3404
	internal sealed class Class2402
	{
		// Token: 0x06005917 RID: 22807 RVA: 0x000396B0 File Offset: 0x000378B0
		public static int smethod_0(int int_0)
		{
			if (int_0 < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (int_0 == 0)
			{
				return 1;
			}
			return (int)Math.Floor(Math.Log10((double)int_0)) + 1;
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x000396D0 File Offset: 0x000378D0
		public static char smethod_1(int int_0)
		{
			if (int_0 <= 9)
			{
				return (char)(int_0 + 48);
			}
			return (char)(int_0 - 10 + 97);
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x00314CB8 File Offset: 0x00312EB8
		public static int smethod_2(double double_0)
		{
			int num = 10;
			double num2 = Math.Pow(0.1, (double)10f);
			if (double_0 == 0.0)
			{
				return 0;
			}
			int num3 = 0;
			while (double_0 - Math.Floor(double_0) > num2 && num3 < num)
			{
				double_0 *= 10.0;
				num3++;
			}
			return num3;
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x000396E5 File Offset: 0x000378E5
		public static int? smethod_3(int? nullable_0, int? nullable_1)
		{
			if (nullable_0 == null)
			{
				return nullable_1;
			}
			if (nullable_1 == null)
			{
				return nullable_0;
			}
			return new int?(Math.Min(nullable_0.Value, nullable_1.Value));
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x00039715 File Offset: 0x00037915
		public static int? smethod_4(int? nullable_0, int? nullable_1)
		{
			if (nullable_0 == null)
			{
				return nullable_1;
			}
			if (nullable_1 == null)
			{
				return nullable_0;
			}
			return new int?(Math.Max(nullable_0.Value, nullable_1.Value));
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x00039745 File Offset: 0x00037945
		public static double? smethod_5(double? nullable_0, double? nullable_1)
		{
			if (nullable_0 == null)
			{
				return nullable_1;
			}
			if (nullable_1 == null)
			{
				return nullable_0;
			}
			return new double?(Math.Max(nullable_0.Value, nullable_1.Value));
		}
	}
}
