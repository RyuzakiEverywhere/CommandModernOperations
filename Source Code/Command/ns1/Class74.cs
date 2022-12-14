using System;

namespace ns1
{
	// Token: 0x02000076 RID: 118
	internal sealed class Class74
	{
		// Token: 0x0600021A RID: 538 RVA: 0x0005A4AC File Offset: 0x000586AC
		public Class74(DateTime dateTime_0)
		{
			double double_ = (double)dateTime_0.DayOfYear + ((double)dateTime_0.Hour + ((double)dateTime_0.Minute + ((double)dateTime_0.Second + (double)dateTime_0.Millisecond / 1000.0) / 60.0) / 60.0) / 24.0;
			this.method_2(dateTime_0.Year, double_);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00003E74 File Offset: 0x00002074
		public Class74(int int_1, double double_2)
		{
			this.method_2(int_1, double_2);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00003E84 File Offset: 0x00002084
		public double method_0()
		{
			return this.double_0 - 2415020.0;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00003E96 File Offset: 0x00002096
		public double method_1()
		{
			return this.double_0 - 2451545.0;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0005A524 File Offset: 0x00058724
		protected void method_2(int int_1, double double_2)
		{
			if (int_1 < 1900 || int_1 > 2100)
			{
				throw new ArgumentOutOfRangeException("year");
			}
			if (double_2 < 1.0 || double_2 >= 367.0)
			{
				throw new ArgumentOutOfRangeException("doy");
			}
			this.int_0 = int_1;
			this.double_1 = double_2;
			int_1--;
			int num = int_1 / 100;
			int num2 = 2 - num + num / 4;
			double num3 = (double)((int)(365.25 * (double)int_1) + 428) + 1720994.5 + (double)num2;
			this.double_0 = num3 + double_2;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0005A5BC File Offset: 0x000587BC
		public double method_3()
		{
			double num = (this.double_0 + 0.5) % 1.0;
			double num2 = (this.method_1() - num) / 36525.0;
			double num3 = 24110.54841 + num2 * (8640184.812866 + num2 * (0.093104 - num2 * 6.2E-06));
			num3 = (num3 + 86636.555366976 * num) % 86400.0;
			if (num3 < 0.0)
			{
				num3 += 86400.0;
			}
			return 6.283185307179586 * (num3 / 86400.0);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0005A66C File Offset: 0x0005886C
		public DateTime method_4()
		{
			DateTime result = new DateTime(this.int_0, 1, 1);
			result = result.AddDays(this.double_1 - 1.0);
			return result;
		}

		// Token: 0x04000155 RID: 341
		private double double_0;

		// Token: 0x04000156 RID: 342
		private int int_0;

		// Token: 0x04000157 RID: 343
		private double double_1;
	}
}
