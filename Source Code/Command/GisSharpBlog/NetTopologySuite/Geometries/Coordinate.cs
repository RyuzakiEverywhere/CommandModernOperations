using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000558 RID: 1368
	[Serializable]
	public sealed class Coordinate : IComparable<ICoordinate>, IEquatable<ICoordinate>, ICloneable, IComparable, ICoordinate
	{
		// Token: 0x060027B3 RID: 10163 RVA: 0x002C2EEC File Offset: 0x002C10EC
		public double imethod_0()
		{
			return this.x;
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x00012F6C File Offset: 0x0001116C
		public void imethod_1(double double_0)
		{
			this.x = double_0;
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x002C2F04 File Offset: 0x002C1104
		public double imethod_2()
		{
			return this.y;
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x00012F75 File Offset: 0x00011175
		public void imethod_3(double double_0)
		{
			this.y = double_0;
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x002C2F1C File Offset: 0x002C111C
		public double imethod_4()
		{
			return this.z;
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x00012F7E File Offset: 0x0001117E
		public void imethod_5(double double_0)
		{
			this.z = double_0;
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x00012F87 File Offset: 0x00011187
		public Coordinate(double double_0, double double_1, double double_2)
		{
			this.x = double_0;
			this.y = double_1;
			this.z = double_2;
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x00012FA4 File Offset: 0x000111A4
		public Coordinate() : this(0.0, 0.0, double.NaN)
		{
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x00012FC7 File Offset: 0x000111C7
		public Coordinate(ICoordinate icoordinate_0) : this(icoordinate_0.imethod_0(), icoordinate_0.imethod_2(), icoordinate_0.imethod_4())
		{
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x00012FE1 File Offset: 0x000111E1
		public Coordinate(double double_0, double double_1) : this(double_0, double_1, double.NaN)
		{
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00012FF4 File Offset: 0x000111F4
		public void imethod_6(ICoordinate icoordinate_0)
		{
			this.x = icoordinate_0.imethod_0();
			this.y = icoordinate_0.imethod_2();
			this.z = icoordinate_0.imethod_4();
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x002C2F34 File Offset: 0x002C1134
		public bool imethod_8(ICoordinate icoordinate_0)
		{
			return this.x == icoordinate_0.imethod_0() && this.y == icoordinate_0.imethod_2();
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x002C2F6C File Offset: 0x002C116C
		public override bool Equals(object obj)
		{
			return obj != null && obj is Coordinate && this.Equals((Coordinate)obj);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x0001301A File Offset: 0x0001121A
		public bool Equals(ICoordinate other)
		{
			return this.imethod_8(other);
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x002C2FA4 File Offset: 0x002C11A4
		public int CompareTo(object target)
		{
			ICoordinate other = (ICoordinate)target;
			return this.CompareTo(other);
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x002C2FC4 File Offset: 0x002C11C4
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

		// Token: 0x060027C3 RID: 10179 RVA: 0x002C3030 File Offset: 0x002C1230
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

		// Token: 0x060027C4 RID: 10180 RVA: 0x002C3098 File Offset: 0x002C1298
		public object Clone()
		{
			return new Coordinate(this.imethod_0(), this.imethod_2(), this.imethod_4());
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x002C30C0 File Offset: 0x002C12C0
		public double imethod_7(ICoordinate icoordinate_0)
		{
			double num = this.x - icoordinate_0.imethod_0();
			double num2 = this.y - icoordinate_0.imethod_2();
			return Math.Sqrt(num * num + num2 * num2);
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x002C30F8 File Offset: 0x002C12F8
		public override int GetHashCode()
		{
			int num = 629 + Coordinate.smethod_0(this.imethod_0());
			return 37 * num + Coordinate.smethod_0(this.imethod_2());
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x002BCCC4 File Offset: 0x002BAEC4
		private static int smethod_0(double double_0)
		{
			long num = BitConverter.DoubleToInt64Bits(double_0);
			return (int)(num ^ num >> 32);
		}

		// Token: 0x040020E6 RID: 8422
		private double x;

		// Token: 0x040020E7 RID: 8423
		private double y;

		// Token: 0x040020E8 RID: 8424
		private double z;
	}
}
