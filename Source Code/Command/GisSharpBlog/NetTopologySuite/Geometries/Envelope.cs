using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000502 RID: 1282
	[Serializable]
	public sealed class Envelope : IComparable<IEnvelope>, IEquatable<IEnvelope>, ICloneable, IComparable, IEnvelope
	{
		// Token: 0x06002582 RID: 9602 RVA: 0x002BC750 File Offset: 0x002BA950
		public static bool smethod_0(ICoordinate icoordinate_0, ICoordinate icoordinate_1, ICoordinate icoordinate_2)
		{
			double num = icoordinate_2.imethod_0();
			double num2 = icoordinate_2.imethod_2();
			double num3 = icoordinate_0.imethod_0();
			double num4 = icoordinate_1.imethod_0();
			double num5 = icoordinate_0.imethod_2();
			double num6 = icoordinate_1.imethod_2();
			double num7;
			double num8;
			if (num3 < num4)
			{
				num7 = num3;
				num8 = num4;
			}
			else
			{
				num7 = num4;
				num8 = num3;
			}
			double num9;
			double num10;
			if (num5 < num6)
			{
				num9 = num5;
				num10 = num6;
			}
			else
			{
				num9 = num6;
				num10 = num5;
			}
			return num >= num7 && num <= num8 && num2 >= num9 && num2 <= num10;
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x002BC7E4 File Offset: 0x002BA9E4
		public static bool smethod_1(ICoordinate icoordinate_0, ICoordinate icoordinate_1, ICoordinate icoordinate_2, ICoordinate icoordinate_3)
		{
			double val = icoordinate_0.imethod_0();
			double val2 = icoordinate_1.imethod_0();
			double val3 = icoordinate_2.imethod_0();
			double val4 = icoordinate_3.imethod_0();
			double num = Math.Min(val, val2);
			double num2 = Math.Max(val3, val4);
			bool result;
			if (num > num2)
			{
				result = false;
			}
			else
			{
				double num3 = Math.Min(val3, val4);
				double num4 = Math.Max(val, val2);
				if (num4 < num3)
				{
					result = false;
				}
				else
				{
					num = Math.Min(icoordinate_0.imethod_2(), icoordinate_1.imethod_2());
					num2 = Math.Max(icoordinate_2.imethod_2(), icoordinate_3.imethod_2());
					if (num > num2)
					{
						result = false;
					}
					else
					{
						num3 = Math.Min(icoordinate_2.imethod_2(), icoordinate_3.imethod_2());
						num4 = Math.Max(icoordinate_0.imethod_2(), icoordinate_1.imethod_2());
						result = (num4 >= num3);
					}
				}
			}
			return result;
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x000121C3 File Offset: 0x000103C3
		public Envelope()
		{
			this.vmethod_0();
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x000121D1 File Offset: 0x000103D1
		public Envelope(double double_0, double double_1, double double_2, double double_3)
		{
			this.vmethod_1(double_0, double_1, double_2, double_3);
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x000121E4 File Offset: 0x000103E4
		public Envelope(ICoordinate icoordinate_0, ICoordinate icoordinate_1)
		{
			this.imethod_8(icoordinate_0, icoordinate_1);
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x000121F4 File Offset: 0x000103F4
		public Envelope(IEnvelope ienvelope_0)
		{
			this.vmethod_2(ienvelope_0);
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x00012203 File Offset: 0x00010403
		public void vmethod_0()
		{
			this.vmethod_3();
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x002BC8C8 File Offset: 0x002BAAC8
		public void vmethod_1(double double_0, double double_1, double double_2, double double_3)
		{
			if (double_0 < double_1)
			{
				this.minx = double_0;
				this.maxx = double_1;
			}
			else
			{
				this.minx = double_1;
				this.maxx = double_0;
			}
			if (double_2 < double_3)
			{
				this.miny = double_2;
				this.maxy = double_3;
			}
			else
			{
				this.miny = double_3;
				this.maxy = double_2;
			}
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x0001220B File Offset: 0x0001040B
		public void imethod_8(ICoordinate icoordinate_0, ICoordinate icoordinate_1)
		{
			this.vmethod_1(icoordinate_0.imethod_0(), icoordinate_1.imethod_0(), icoordinate_0.imethod_2(), icoordinate_1.imethod_2());
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x0001222B File Offset: 0x0001042B
		public void vmethod_2(IEnvelope ienvelope_0)
		{
			this.minx = ienvelope_0.imethod_3();
			this.maxx = ienvelope_0.imethod_1();
			this.miny = ienvelope_0.imethod_4();
			this.maxy = ienvelope_0.imethod_2();
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x0001225D File Offset: 0x0001045D
		public void vmethod_3()
		{
			this.minx = 0.0;
			this.maxx = -1.0;
			this.miny = 0.0;
			this.maxy = -1.0;
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x0001229B File Offset: 0x0001049B
		public bool imethod_10()
		{
			return this.maxx < this.minx;
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x002BC928 File Offset: 0x002BAB28
		public double imethod_3()
		{
			return this.minx;
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x002BC940 File Offset: 0x002BAB40
		public double imethod_1()
		{
			return this.maxx;
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x002BC958 File Offset: 0x002BAB58
		public double imethod_4()
		{
			return this.miny;
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x002BC970 File Offset: 0x002BAB70
		public double imethod_2()
		{
			return this.maxy;
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x002BC988 File Offset: 0x002BAB88
		public void imethod_7(IEnvelope ienvelope_0)
		{
			if (!ienvelope_0.imethod_10())
			{
				if (this.imethod_10())
				{
					this.minx = ienvelope_0.imethod_3();
					this.maxx = ienvelope_0.imethod_1();
					this.miny = ienvelope_0.imethod_4();
					this.maxy = ienvelope_0.imethod_2();
				}
				else
				{
					if (ienvelope_0.imethod_3() < this.minx)
					{
						this.minx = ienvelope_0.imethod_3();
					}
					if (ienvelope_0.imethod_1() > this.maxx)
					{
						this.maxx = ienvelope_0.imethod_1();
					}
					if (ienvelope_0.imethod_4() < this.miny)
					{
						this.miny = ienvelope_0.imethod_4();
					}
					if (ienvelope_0.imethod_2() > this.maxy)
					{
						this.maxy = ienvelope_0.imethod_2();
					}
				}
			}
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x002BCA5C File Offset: 0x002BAC5C
		public bool imethod_9(IEnvelope ienvelope_0)
		{
			return !this.imethod_10() && !ienvelope_0.imethod_10() && (ienvelope_0.imethod_3() <= this.maxx && ienvelope_0.imethod_1() >= this.minx && ienvelope_0.imethod_4() <= this.maxy) && ienvelope_0.imethod_2() >= this.miny;
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x000122AB File Offset: 0x000104AB
		public bool imethod_5(ICoordinate icoordinate_0)
		{
			return this.vmethod_4(icoordinate_0.imethod_0(), icoordinate_0.imethod_2());
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x000122BF File Offset: 0x000104BF
		public bool vmethod_4(double double_0, double double_1)
		{
			return double_0 >= this.minx && double_0 <= this.maxx && double_1 >= this.miny && double_1 <= this.maxy;
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x002BCAC4 File Offset: 0x002BACC4
		public bool imethod_6(IEnvelope ienvelope_0)
		{
			return !this.imethod_10() && !ienvelope_0.imethod_10() && (ienvelope_0.imethod_3() >= this.minx && ienvelope_0.imethod_1() <= this.maxx && ienvelope_0.imethod_4() >= this.miny) && ienvelope_0.imethod_2() <= this.maxy;
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x002BCB2C File Offset: 0x002BAD2C
		public override bool Equals(object obj)
		{
			return obj != null && obj is Envelope && this.Equals((IEnvelope)obj);
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x002BCB64 File Offset: 0x002BAD64
		public bool Equals(IEnvelope other)
		{
			bool result;
			if (this.imethod_10())
			{
				result = other.imethod_10();
			}
			else
			{
				result = (this.maxx == other.imethod_1() && this.maxy == other.imethod_2() && this.minx == other.imethod_3() && this.miny == other.imethod_4());
			}
			return result;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x002BCBC4 File Offset: 0x002BADC4
		public int CompareTo(object target)
		{
			return this.CompareTo((IEnvelope)target);
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x002BCBE0 File Offset: 0x002BADE0
		public int CompareTo(IEnvelope other)
		{
			int result;
			if (this.imethod_10() && other.imethod_10())
			{
				result = 0;
			}
			else if (!this.imethod_10() && other.imethod_10())
			{
				result = 1;
			}
			else if (this.imethod_10() && !other.imethod_10())
			{
				result = -1;
			}
			else if (this.imethod_0() > other.imethod_0())
			{
				result = 1;
			}
			else if (this.imethod_0() < other.imethod_0())
			{
				result = -1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x002BCC6C File Offset: 0x002BAE6C
		public override int GetHashCode()
		{
			int num = 629 + Envelope.smethod_2(this.minx);
			num = 37 * num + Envelope.smethod_2(this.maxx);
			num = 37 * num + Envelope.smethod_2(this.miny);
			return 37 * num + Envelope.smethod_2(this.maxy);
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x002BCCC4 File Offset: 0x002BAEC4
		private static int smethod_2(double double_0)
		{
			long num = BitConverter.DoubleToInt64Bits(double_0);
			return (int)(num ^ num >> 32);
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x002BCCE4 File Offset: 0x002BAEE4
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"Env[",
				this.minx,
				" : ",
				this.maxx,
				", ",
				this.miny,
				" : ",
				this.maxy,
				"]"
			});
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x002BCD64 File Offset: 0x002BAF64
		object ICloneable.Clone()
		{
			return this.method_0();
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x002BCD7C File Offset: 0x002BAF7C
		public double imethod_0()
		{
			double num = 1.0;
			num *= this.maxx - this.minx;
			return num * (this.maxy - this.miny);
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x002BCDB8 File Offset: 0x002BAFB8
		public IEnvelope method_0()
		{
			return new Envelope(this.minx, this.maxx, this.miny, this.maxy);
		}

		// Token: 0x04002019 RID: 8217
		private double minx;

		// Token: 0x0400201A RID: 8218
		private double maxx;

		// Token: 0x0400201B RID: 8219
		private double miny;

		// Token: 0x0400201C RID: 8220
		private double maxy;
	}
}
