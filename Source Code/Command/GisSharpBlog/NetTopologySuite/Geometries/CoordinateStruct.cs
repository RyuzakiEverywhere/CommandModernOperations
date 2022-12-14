using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000563 RID: 1379
	[Serializable]
	public struct CoordinateStruct : IComparable<ICoordinate>, IEquatable<ICoordinate>, ICloneable, IComparable, ICoordinate
	{
		// Token: 0x06002813 RID: 10259 RVA: 0x00013273 File Offset: 0x00011473
		public CoordinateStruct(double double_0, double double_1, double double_2)
		{
			this.x = double_0;
			this.y = double_1;
			this.z = double_2;
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x002C3E74 File Offset: 0x002C2074
		public double imethod_0()
		{
			return this.x;
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x0001328A File Offset: 0x0001148A
		public void imethod_1(double double_0)
		{
			this.x = double_0;
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x002C3E8C File Offset: 0x002C208C
		public double imethod_2()
		{
			return this.y;
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x00013293 File Offset: 0x00011493
		public void imethod_3(double double_0)
		{
			this.y = double_0;
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x002C3EA4 File Offset: 0x002C20A4
		public double imethod_4()
		{
			return this.z;
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x0001329C File Offset: 0x0001149C
		public void imethod_5(double double_0)
		{
			this.z = double_0;
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x000132A5 File Offset: 0x000114A5
		public void imethod_6(ICoordinate icoordinate_0)
		{
			this.x = icoordinate_0.imethod_0();
			this.y = icoordinate_0.imethod_2();
			this.z = icoordinate_0.imethod_4();
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x002C3EBC File Offset: 0x002C20BC
		public double imethod_7(ICoordinate icoordinate_0)
		{
			double num = this.x - icoordinate_0.imethod_0();
			double num2 = this.y - icoordinate_0.imethod_2();
			return Math.Sqrt(num * num + num2 * num2);
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x000132CB File Offset: 0x000114CB
		public bool imethod_8(ICoordinate icoordinate_0)
		{
			return this.x == icoordinate_0.imethod_0() && this.y == icoordinate_0.imethod_2();
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x002C3EF4 File Offset: 0x002C20F4
		public object Clone()
		{
			return new CoordinateStruct(this.imethod_0(), this.imethod_2(), this.imethod_4());
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x002C3F20 File Offset: 0x002C2120
		public int CompareTo(object target)
		{
			ICoordinate other = (ICoordinate)target;
			return this.CompareTo(other);
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x002C3F40 File Offset: 0x002C2140
		public int CompareTo(ICoordinate other)
		{
			int result;
			if (this.x < other.imethod_0())
			{
				result = -1;
			}
			else if (this.x > other.imethod_0())
			{
				result = 1;
			}
			else if (this.y < other.imethod_2())
			{
				result = -1;
			}
			else if (this.y > other.imethod_2())
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x000132EC File Offset: 0x000114EC
		public bool Equals(ICoordinate other)
		{
			return this.imethod_8(other);
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x002C3FAC File Offset: 0x002C21AC
		public override bool Equals(object obj)
		{
			return obj != null && obj is CoordinateStruct && this.Equals((CoordinateStruct)obj);
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x002C3FE8 File Offset: 0x002C21E8
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"(",
				this.x,
				", ",
				this.y,
				", ",
				this.z,
				")"
			});
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x002C4050 File Offset: 0x002C2250
		public override int GetHashCode()
		{
			int num = 629 + CoordinateStruct.smethod_0(this.imethod_0());
			return 37 * num + CoordinateStruct.smethod_0(this.imethod_2());
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x002BCCC4 File Offset: 0x002BAEC4
		private static int smethod_0(double double_0)
		{
			long num = BitConverter.DoubleToInt64Bits(double_0);
			return (int)(num ^ num >> 32);
		}

		// Token: 0x04002101 RID: 8449
		private double x;

		// Token: 0x04002102 RID: 8450
		private double y;

		// Token: 0x04002103 RID: 8451
		private double z;
	}
}
