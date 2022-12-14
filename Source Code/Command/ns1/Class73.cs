using System;

namespace ns1
{
	// Token: 0x02000073 RID: 115
	internal static class Class73
	{
		// Token: 0x0600020C RID: 524 RVA: 0x00003DCF File Offset: 0x00001FCF
		public static double smethod_0(double double_2)
		{
			return double_2 * double_2;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0005A410 File Offset: 0x00058610
		public static double smethod_1(double double_2)
		{
			double num = double_2 % 6.283185307179586;
			if (num < 0.0)
			{
				num += 6.283185307179586;
			}
			return num;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0005A444 File Offset: 0x00058644
		public static double smethod_2(double double_2, double double_3)
		{
			double result;
			if (double_3 == 0.0)
			{
				if (double_2 > 0.0)
				{
					result = 1.5707963267948966;
				}
				else
				{
					result = 4.71238898038469;
				}
			}
			else if (double_3 > 0.0)
			{
				result = Math.Atan(double_2 / double_3);
			}
			else
			{
				result = 3.141592653589793 + Math.Atan(double_2 / double_3);
			}
			return result;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00003DD4 File Offset: 0x00001FD4
		public static double smethod_3(double double_2)
		{
			return double_2 * 57.29577951308232;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00003DE1 File Offset: 0x00001FE1
		public static double smethod_4(double double_2)
		{
			return double_2 * 0.017453292519943295;
		}

		// Token: 0x04000151 RID: 337
		public static double double_0 = Math.Sqrt(0.005530438215158448);

		// Token: 0x04000152 RID: 338
		public static double double_1 = Math.Pow(0.006584997024992489, 4.0);
	}
}
