using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ns1
{
	// Token: 0x02000070 RID: 112
	internal sealed class Class70
	{
		// Token: 0x060001F6 RID: 502 RVA: 0x00003CC8 File Offset: 0x00001EC8
		[CompilerGenerated]
		public double method_0()
		{
			return this.double_0;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00003CD0 File Offset: 0x00001ED0
		[CompilerGenerated]
		public void method_1(double double_3)
		{
			this.double_0 = double_3;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00003CD9 File Offset: 0x00001ED9
		[CompilerGenerated]
		public double method_2()
		{
			return this.double_1;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00003CE1 File Offset: 0x00001EE1
		[CompilerGenerated]
		public void method_3(double double_3)
		{
			this.double_1 = double_3;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00003CEA File Offset: 0x00001EEA
		public double method_4()
		{
			return Class73.smethod_3(this.method_0());
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00003CF7 File Offset: 0x00001EF7
		public double method_5()
		{
			return Class73.smethod_3(this.method_2());
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00003D04 File Offset: 0x00001F04
		[CompilerGenerated]
		public double method_6()
		{
			return this.double_2;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00003D0C File Offset: 0x00001F0C
		[CompilerGenerated]
		public void method_7(double double_3)
		{
			this.double_2 = double_3;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00003D15 File Offset: 0x00001F15
		public Class70(Class71 class71_0, Class74 class74_0) : this(class71_0.method_0(), (Class73.smethod_2(class71_0.method_0().method_2(), class71_0.method_0().method_0()) - class74_0.method_3()) % 6.283185307179586)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0005A1A8 File Offset: 0x000583A8
		private Class70(Class81 class81_0, double double_3)
		{
			double_3 %= 6.283185307179586;
			if (double_3 < 0.0)
			{
				double_3 += 6.283185307179586;
			}
			double num = Math.Sqrt(Class73.smethod_0(class81_0.method_0()) + Class73.smethod_0(class81_0.method_2()));
			double num2 = 0.006694317778266723;
			double num3 = Class73.smethod_2(class81_0.method_4(), num);
			double num4;
			double num5;
			do
			{
				num4 = num3;
				num5 = 1.0 / Math.Sqrt(1.0 - num2 * Class73.smethod_0(Math.Sin(num4)));
				num3 = Class73.smethod_2(class81_0.method_4() + 6378.135 * num5 * num2 * Math.Sin(num4), num);
			}
			while (Math.Abs(num3 - num4) > 1E-07);
			this.method_1(num3);
			this.method_3(double_3);
			this.method_7(num / Math.Cos(num3) - 6378.135 * num5);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0005A2A0 File Offset: 0x000584A0
		public override string ToString()
		{
			bool flag = this.method_0() >= 0.0;
			bool flag2 = this.method_2() >= 0.0;
			return string.Format(CultureInfo.CurrentCulture, "{0:00.0}{1} ", new object[]
			{
				Math.Abs(this.method_4()),
				flag ? 'N' : 'S'
			}) + string.Format(CultureInfo.CurrentCulture, "{0:000.0}{1} ", new object[]
			{
				Math.Abs(this.method_5()),
				flag2 ? 'E' : 'W'
			}) + string.Format(CultureInfo.CurrentCulture, "{0:F0}m", new object[]
			{
				this.method_6() * 1000.0
			});
		}

		// Token: 0x0400014B RID: 331
		[CompilerGenerated]
		private double double_0;

		// Token: 0x0400014C RID: 332
		[CompilerGenerated]
		private double double_1;

		// Token: 0x0400014D RID: 333
		[CompilerGenerated]
		private double double_2;
	}
}
