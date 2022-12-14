using System;
using System.Runtime.CompilerServices;

namespace ns1
{
	// Token: 0x0200007A RID: 122
	internal sealed class Class78
	{
		// Token: 0x0600022F RID: 559 RVA: 0x00003ECE File Offset: 0x000020CE
		[CompilerGenerated]
		private Class80 method_0()
		{
			return this.class80_0;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00003ED6 File Offset: 0x000020D6
		[CompilerGenerated]
		private void method_1(Class80 class80_1)
		{
			this.class80_0 = class80_1;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00003EDF File Offset: 0x000020DF
		[CompilerGenerated]
		public Class74 method_2()
		{
			return this.class74_0;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00003EE7 File Offset: 0x000020E7
		[CompilerGenerated]
		private void method_3(Class74 class74_1)
		{
			this.class74_0 = class74_1;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00003EF0 File Offset: 0x000020F0
		public DateTime method_4()
		{
			return this.method_2().method_4();
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00003EFD File Offset: 0x000020FD
		[CompilerGenerated]
		private Class75 method_5()
		{
			return this.class75_0;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00003F05 File Offset: 0x00002105
		[CompilerGenerated]
		private void method_6(Class75 class75_1)
		{
			this.class75_0 = class75_1;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00003F0E File Offset: 0x0000210E
		public double method_7()
		{
			return this.double_8;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00003F16 File Offset: 0x00002116
		public double method_8()
		{
			return this.double_10;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00003F1E File Offset: 0x0000211E
		public double method_9()
		{
			return this.double_11;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00003F26 File Offset: 0x00002126
		public double method_10()
		{
			return this.double_12;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00003F2E File Offset: 0x0000212E
		public double method_11()
		{
			return this.double_0;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00003F36 File Offset: 0x00002136
		public double method_12()
		{
			return this.double_1;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00003F3E File Offset: 0x0000213E
		public double method_13()
		{
			return this.double_2;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00003F46 File Offset: 0x00002146
		public double method_14()
		{
			return this.double_3;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00003F4E File Offset: 0x0000214E
		public double method_15()
		{
			return this.double_4;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00003F56 File Offset: 0x00002156
		public double method_16()
		{
			return this.double_6;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00003F5E File Offset: 0x0000215E
		private double method_17()
		{
			return this.double_7;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00003F66 File Offset: 0x00002166
		public string method_18()
		{
			return this.method_0().method_1();
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00003F73 File Offset: 0x00002173
		public string method_19()
		{
			return this.method_0().method_0();
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00003F80 File Offset: 0x00002180
		public string method_20()
		{
			return this.method_19() + " #" + this.method_18();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0005D608 File Offset: 0x0005B808
		public TimeSpan method_21()
		{
			if (this.timeSpan_0.TotalSeconds < 0.0)
			{
				if (this.method_8() == 0.0)
				{
					this.timeSpan_0 = new TimeSpan(0, 0, 0);
				}
				else
				{
					double num = 6.283185307179586 / this.method_8() * 60.0;
					int milliseconds = (int)((num - (double)((int)num)) * 1000.0);
					this.timeSpan_0 = new TimeSpan(0, 0, 0, (int)num, milliseconds);
				}
			}
			return this.timeSpan_0;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0005D690 File Offset: 0x0005B890
		public Class78(Class80 class80_1)
		{
			this.method_1(class80_1);
			this.method_3(this.method_0().method_2());
			this.double_0 = this.method_25(Class80.Enum4.const_6);
			this.double_1 = this.method_0().method_4(Class80.Enum4.const_8);
			this.double_2 = this.method_25(Class80.Enum4.const_7);
			this.double_3 = this.method_25(Class80.Enum4.const_9);
			this.double_4 = this.method_0().method_4(Class80.Enum4.const_14);
			this.double_5 = this.method_0().method_4(Class80.Enum4.const_12);
			this.double_6 = this.method_25(Class80.Enum4.const_10);
			this.double_7 = this.method_0().method_4(Class80.Enum4.const_11);
			double num = this.method_17() * 6.283185307179586 / 1440.0;
			double num2 = Math.Pow(Class73.double_0 / num, 0.6666666666666666);
			double num3 = this.method_12();
			double d = this.method_11();
			double num4 = 0.00081196185 * (3.0 * Class73.smethod_0(Math.Cos(d)) - 1.0) / Math.Pow(1.0 - num3 * num3, 1.5);
			double num5 = num4 / (num2 * num2);
			double num6 = num2 * (1.0 - num5 * (0.3333333333333333 + num5 * (1.0 + 1.654320987654321 * num5)));
			double num7 = num4 / (num6 * num6);
			this.double_10 = num / (1.0 + num7);
			this.double_8 = num6 / (1.0 - num7);
			this.double_9 = this.double_8 * Math.Sqrt(1.0 - num3 * num3);
			this.double_11 = 6378.135 * (this.double_8 * (1.0 - num3) - 1.0);
			this.double_12 = 6378.135 * (this.double_8 * (1.0 + num3) - 1.0);
			if (this.method_21().TotalMinutes >= 225.0)
			{
				this.method_6(new Class76(this));
				return;
			}
			this.method_6(new Class77(this));
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0005D8E8 File Offset: 0x0005BAE8
		public Class72 method_22(double double_13)
		{
			Class72 @class = this.method_5().vmethod_0(double_13);
			double num = 6378.135;
			@class.method_4(num);
			@class.method_5(106.30225);
			return @class;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0005D924 File Offset: 0x0005BB24
		public Class72 method_23(DateTime dateTime_0)
		{
			return this.method_22(this.method_24(dateTime_0).TotalMinutes);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00003F98 File Offset: 0x00002198
		public TimeSpan method_24(DateTime dateTime_0)
		{
			return dateTime_0 - this.method_4();
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00003FA6 File Offset: 0x000021A6
		protected double method_25(Class80.Enum4 enum4_0)
		{
			return this.method_0().method_5(enum4_0, Class80.Enum5.const_0);
		}

		// Token: 0x040001B7 RID: 439
		private TimeSpan timeSpan_0 = new TimeSpan(0, 0, 0, -1);

		// Token: 0x040001B8 RID: 440
		private double double_0;

		// Token: 0x040001B9 RID: 441
		private double double_1;

		// Token: 0x040001BA RID: 442
		private double double_2;

		// Token: 0x040001BB RID: 443
		private double double_3;

		// Token: 0x040001BC RID: 444
		private double double_4;

		// Token: 0x040001BD RID: 445
		private double double_5;

		// Token: 0x040001BE RID: 446
		private double double_6;

		// Token: 0x040001BF RID: 447
		private double double_7;

		// Token: 0x040001C0 RID: 448
		private double double_8;

		// Token: 0x040001C1 RID: 449
		private double double_9;

		// Token: 0x040001C2 RID: 450
		private double double_10;

		// Token: 0x040001C3 RID: 451
		private double double_11;

		// Token: 0x040001C4 RID: 452
		private double double_12;

		// Token: 0x040001C5 RID: 453
		[CompilerGenerated]
		private Class80 class80_0;

		// Token: 0x040001C6 RID: 454
		[CompilerGenerated]
		private Class74 class74_0;

		// Token: 0x040001C7 RID: 455
		[CompilerGenerated]
		private Class75 class75_0;
	}
}
