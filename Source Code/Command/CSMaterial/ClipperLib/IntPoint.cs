using System;

namespace CSMaterial.ClipperLib
{
	// Token: 0x020000ED RID: 237
	public struct IntPoint
	{
		// Token: 0x06000603 RID: 1539 RVA: 0x00006759 File Offset: 0x00004959
		public IntPoint(long long_2, long long_3)
		{
			this.long_0 = long_2;
			this.long_1 = long_3;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00006769 File Offset: 0x00004969
		public static bool smethod_0(IntPoint intPoint_0, IntPoint intPoint_1)
		{
			return intPoint_0.long_0 == intPoint_1.long_0 && intPoint_0.long_1 == intPoint_1.long_1;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00006789 File Offset: 0x00004989
		public static bool smethod_1(IntPoint intPoint_0, IntPoint intPoint_1)
		{
			return intPoint_0.long_0 != intPoint_1.long_0 || intPoint_0.long_1 != intPoint_1.long_1;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0006D7A4 File Offset: 0x0006B9A4
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (obj is IntPoint)
			{
				IntPoint intPoint = (IntPoint)obj;
				return this.long_0 == intPoint.long_0 && this.long_1 == intPoint.long_1;
			}
			return false;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000067AC File Offset: 0x000049AC
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x04000412 RID: 1042
		public long long_0;

		// Token: 0x04000413 RID: 1043
		public long long_1;
	}
}
