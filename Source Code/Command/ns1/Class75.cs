using System;
using System.Runtime.CompilerServices;
using Zeptomoby.OrbitTools;

namespace ns1
{
	// Token: 0x02000077 RID: 119
	internal abstract class Class75
	{
		// Token: 0x06000221 RID: 545 RVA: 0x00003EA8 File Offset: 0x000020A8
		[CompilerGenerated]
		protected Class78 method_0()
		{
			return this.class78_0;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00003EB0 File Offset: 0x000020B0
		[CompilerGenerated]
		private void method_1(Class78 class78_1)
		{
			this.class78_0 = class78_1;
		}

		// Token: 0x06000223 RID: 547
		public abstract Class72 vmethod_0(double double_32);

		// Token: 0x06000224 RID: 548 RVA: 0x00003EB9 File Offset: 0x000020B9
		public Class75(Class78 class78_1)
		{
			this.method_1(class78_1);
			this.method_2();
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0005A6A4 File Offset: 0x000588A4
		private void method_2()
		{
			this.double_0 = this.method_0().method_11();
			this.double_1 = this.method_0().method_12();
			this.double_2 = Math.Cos(this.double_0);
			this.double_3 = this.double_2 * this.double_2;
			this.double_4 = 3.0 * this.double_3 - 1.0;
			this.double_5 = this.double_1 * this.double_1;
			this.double_6 = 1.0 - this.double_5;
			this.double_7 = Math.Sqrt(this.double_6);
			this.double_8 = this.method_0().method_7();
			this.double_9 = this.method_0().method_8();
			this.double_12 = 6378.135 * (this.double_8 * (1.0 - this.double_1) - 1.0);
			this.double_10 = 1.0122292801892716;
			this.double_11 = Class73.double_1;
			if (this.double_12 < 156.0)
			{
				this.double_10 = this.double_12 - 78.0;
				if (this.double_12 <= 98.0)
				{
					this.double_10 = 20.0;
				}
				this.double_11 = Math.Pow((120.0 - this.double_10) * 1.0 / 6378.135, 4.0);
				this.double_10 = this.double_10 / 6378.135 + 1.0;
			}
			double num = 1.0 / (this.double_8 * this.double_8 * this.double_6 * this.double_6);
			this.double_13 = 1.0 / (this.double_8 - this.double_10);
			this.double_14 = this.double_8 * this.double_1 * this.double_13;
			this.double_15 = this.double_14 * this.double_14;
			this.double_16 = this.double_1 * this.double_14;
			double num2 = Math.Abs(1.0 - this.double_15);
			this.double_17 = this.double_11 * Math.Pow(this.double_13, 4.0);
			this.double_18 = this.double_17 / Math.Pow(num2, 3.5);
			double num3 = this.double_18 * this.double_9 * (this.double_8 * (1.0 + 1.5 * this.double_15 + this.double_16 * (4.0 + this.double_15)) + 0.000405980925 * this.double_13 / num2 * this.double_4 * (8.0 + 3.0 * this.double_15 * (8.0 + this.double_15)));
			this.double_19 = this.method_0().method_15() * num3;
			this.double_22 = Math.Sin(this.double_0);
			double num4 = 0.004690140306468833 * Math.Pow(1.0, 3.0);
			this.double_20 = this.double_17 * this.double_13 * num4 * this.double_9 * 1.0 * this.double_22 / this.double_1;
			this.double_23 = 1.0 - this.double_3;
			this.double_21 = 2.0 * this.double_9 * this.double_18 * this.double_8 * this.double_6 * (this.double_14 * (2.0 + 0.5 * this.double_15) + this.double_1 * (0.5 + 2.0 * this.double_15) - 0.0010826158 * this.double_13 / (this.double_8 * num2) * (-3.0 * this.double_4 * (1.0 - 2.0 * this.double_16 + this.double_15 * (1.5 - 0.5 * this.double_16)) + 0.75 * this.double_23 * (2.0 * this.double_15 - this.double_16 * (1.0 + this.double_15)) * Math.Cos(2.0 * this.method_0().method_14())));
			double num5 = this.double_3 * this.double_3;
			double num6 = 0.0016239237 * num * this.double_9;
			double num7 = num6 * 0.0005413079 * num;
			double num8 = 7.762359374999998E-07 * num * num * this.double_9;
			this.double_24 = this.double_9 + 0.5 * num6 * this.double_7 * this.double_4 + 0.0625 * num7 * this.double_7 * (13.0 - 78.0 * this.double_3 + 137.0 * num5);
			double num9 = 1.0 - 5.0 * this.double_3;
			this.double_25 = -0.5 * num6 * num9 + 0.0625 * num7 * (7.0 - 114.0 * this.double_3 + 395.0 * num5) + num8 * (3.0 - 36.0 * this.double_3 + 49.0 * num5);
			double num10 = -num6 * this.double_2;
			this.double_26 = num10 + (0.5 * num7 * (4.0 - 19.0 * this.double_3) + 2.0 * num8 * (3.0 - 7.0 * this.double_3)) * this.double_2;
			this.double_27 = 3.5 * this.double_6 * num10 * this.double_19;
			this.double_28 = 1.5 * this.double_19;
			this.double_29 = 0.125 * num4 * this.double_22 * (3.0 + 5.0 * this.double_2) / (1.0 + this.double_2);
			this.double_30 = 0.25 * num4 * this.double_22;
			this.double_31 = 7.0 * this.double_3 - 1.0;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0005ADDC File Offset: 0x00058FDC
		protected Class72 method_3(double double_32, double double_33, double double_34, double double_35, double double_36, double double_37, double double_38, double double_39)
		{
			if (double_34 * double_34 > 1.0)
			{
				throw new PropagationException("Error in satellite data");
			}
			double num = Math.Sqrt(1.0 - double_34 * double_34);
			double num2 = double_34 * Math.Cos(double_33);
			double num3 = 1.0 / (double_35 * num * num);
			double num4 = num3 * this.double_29 * num2;
			double num5 = num3 * this.double_30;
			double num6 = double_36 + num4;
			double num7 = double_34 * Math.Sin(double_33) + num5;
			double num8 = Class73.smethod_1(num6 - double_37);
			double num9 = num8;
			double num10 = 0.0;
			double num11 = 0.0;
			double num12 = 0.0;
			double num13 = 0.0;
			double num14 = 0.0;
			double num15 = 0.0;
			bool flag = false;
			int num16 = 1;
			while (num16 <= 10 && !flag)
			{
				num14 = Math.Sin(num9);
				num15 = Math.Cos(num9);
				num10 = num2 * num14;
				num11 = num7 * num15;
				num12 = num2 * num15;
				num13 = num7 * num14;
				double num17 = (num8 - num11 + num10 - num9) / (1.0 - num12 - num13) + num9;
				if (Math.Abs(num17 - num9) <= 1E-06)
				{
					flag = true;
				}
				else
				{
					num9 = num17;
				}
				num16++;
			}
			double num18 = num12 + num13;
			double num19 = num10 - num11;
			double num20 = num2 * num2 + num7 * num7;
			num3 = 1.0 - num20;
			double num21 = double_35 * num3;
			double num22 = double_35 * (1.0 - num18);
			double num23 = 1.0 / num22;
			double num24 = Class73.double_0 * Math.Sqrt(double_35) * num19 * num23;
			double num25 = Class73.double_0 * Math.Sqrt(num21) * num23;
			num9 = double_35 * num23;
			double num26 = Math.Sqrt(num3);
			num10 = 1.0 / (1.0 + num26);
			double num27 = num9 * (num15 - num2 + num7 * num19 * num10);
			double num28 = num9 * (num14 - num7 - num2 * num19 * num10);
			double num29 = Class73.smethod_2(num28, num27);
			double num30 = 2.0 * num28 * num27;
			double num31 = 2.0 * num27 * num27 - 1.0;
			num3 = 1.0 / num21;
			num23 = 0.0005413079 * num3;
			num9 = num23 * num3;
			double num32 = num22 * (1.0 - 1.5 * num9 * num26 * this.double_4) + 0.5 * num23 * this.double_23 * num31;
			double num33 = num29 - 0.25 * num9 * this.double_31 * num30;
			double num34 = double_37 + 1.5 * num9 * this.double_2 * num30;
			double num35 = double_32 + 1.5 * num9 * this.double_2 * this.double_22 * num31;
			double num36 = num24 - double_38 * num23 * this.double_23 * num30;
			double num37 = num25 + double_38 * num23 * (this.double_23 * num31 + 1.5 * this.double_4);
			double num38 = Math.Sin(num33);
			double num39 = Math.Cos(num33);
			double num40 = Math.Sin(num35);
			double num41 = Math.Cos(num35);
			double num42 = Math.Sin(num34);
			double num43 = Math.Cos(num34);
			double num44 = -num42 * num41;
			double num45 = num43 * num41;
			double num46 = num44 * num38 + num43 * num39;
			double num47 = num45 * num38 + num42 * num39;
			double num48 = num40 * num38;
			double num49 = num44 * num39 - num43 * num38;
			double num50 = num45 * num39 - num42 * num38;
			double num51 = num40 * num39;
			double num52 = num32 * num46;
			double num53 = num32 * num47;
			double num54 = num32 * num48;
			Class81 @class = new Class81(num52, num53, num54);
			DateTime dateTime_ = this.method_0().method_4().AddMinutes(double_39);
			if (@class.method_9() * 6378.135 < 6378.135)
			{
				throw new DecayException(dateTime_, this.method_0().method_20());
			}
			double num55 = num36 * num46 + num37 * num49;
			double num56 = num36 * num47 + num37 * num50;
			double num57 = num36 * num48 + num37 * num51;
			Class81 class81_ = new Class81(num55, num56, num57);
			return new Class72(@class, class81_, new Class74(dateTime_));
		}

		// Token: 0x04000158 RID: 344
		protected double double_0;

		// Token: 0x04000159 RID: 345
		protected double double_1;

		// Token: 0x0400015A RID: 346
		protected double double_2;

		// Token: 0x0400015B RID: 347
		protected double double_3;

		// Token: 0x0400015C RID: 348
		protected double double_4;

		// Token: 0x0400015D RID: 349
		protected double double_5;

		// Token: 0x0400015E RID: 350
		protected double double_6;

		// Token: 0x0400015F RID: 351
		protected double double_7;

		// Token: 0x04000160 RID: 352
		protected double double_8;

		// Token: 0x04000161 RID: 353
		protected double double_9;

		// Token: 0x04000162 RID: 354
		protected double double_10;

		// Token: 0x04000163 RID: 355
		protected double double_11;

		// Token: 0x04000164 RID: 356
		protected double double_12;

		// Token: 0x04000165 RID: 357
		protected double double_13;

		// Token: 0x04000166 RID: 358
		protected double double_14;

		// Token: 0x04000167 RID: 359
		protected double double_15;

		// Token: 0x04000168 RID: 360
		protected double double_16;

		// Token: 0x04000169 RID: 361
		protected double double_17;

		// Token: 0x0400016A RID: 362
		protected double double_18;

		// Token: 0x0400016B RID: 363
		protected double double_19;

		// Token: 0x0400016C RID: 364
		protected double double_20;

		// Token: 0x0400016D RID: 365
		protected double double_21;

		// Token: 0x0400016E RID: 366
		protected double double_22;

		// Token: 0x0400016F RID: 367
		protected double double_23;

		// Token: 0x04000170 RID: 368
		protected double double_24;

		// Token: 0x04000171 RID: 369
		protected double double_25;

		// Token: 0x04000172 RID: 370
		protected double double_26;

		// Token: 0x04000173 RID: 371
		protected double double_27;

		// Token: 0x04000174 RID: 372
		protected double double_28;

		// Token: 0x04000175 RID: 373
		protected double double_29;

		// Token: 0x04000176 RID: 374
		protected double double_30;

		// Token: 0x04000177 RID: 375
		protected double double_31;

		// Token: 0x04000178 RID: 376
		[CompilerGenerated]
		private Class78 class78_0;
	}
}
