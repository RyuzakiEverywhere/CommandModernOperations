using System;
using System.Text;
using GeoAPI.Geometries;
using ns15;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000536 RID: 1334
	[Serializable]
	public sealed class LineSegment : IComparable
	{
		// Token: 0x060026DF RID: 9951 RVA: 0x002C0120 File Offset: 0x002BE320
		public ICoordinate method_0()
		{
			return this.p1;
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x002C0138 File Offset: 0x002BE338
		public ICoordinate method_1()
		{
			return this.p0;
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x00012A49 File Offset: 0x00010C49
		public LineSegment(ICoordinate icoordinate_0, ICoordinate icoordinate_1)
		{
			this.p0 = icoordinate_0;
			this.p1 = icoordinate_1;
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x00012A6D File Offset: 0x00010C6D
		public LineSegment() : this(new Coordinate(), new Coordinate())
		{
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x002C0150 File Offset: 0x002BE350
		public int method_2(LineSegment lineSegment_0)
		{
			int num = Class655.smethod_0(this.method_1(), this.method_0(), lineSegment_0.method_1());
			int num2 = Class655.smethod_0(this.method_1(), this.method_0(), lineSegment_0.method_0());
			int result;
			if (num >= 0 && num2 >= 0)
			{
				result = Math.Max(num, num2);
			}
			else if (num <= 0 && num2 <= 0)
			{
				result = Math.Max(num, num2);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x002C01C0 File Offset: 0x002BE3C0
		public override bool Equals(object obj)
		{
			bool result;
			if (obj == null)
			{
				result = false;
			}
			else if (!(obj is LineSegment))
			{
				result = false;
			}
			else
			{
				LineSegment lineSegment = (LineSegment)obj;
				result = (this.p0.Equals(lineSegment.p0) && this.p1.Equals(lineSegment.p1));
			}
			return result;
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x002C021C File Offset: 0x002BE41C
		public int CompareTo(object target)
		{
			LineSegment lineSegment = (LineSegment)target;
			int num = this.method_1().CompareTo(lineSegment.method_1());
			int result;
			if (num != 0)
			{
				result = num;
			}
			else
			{
				result = this.method_0().CompareTo(lineSegment.method_0());
			}
			return result;
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x002C0260 File Offset: 0x002BE460
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder("LINESTRING( ");
			stringBuilder.Append(this.method_1().imethod_0()).Append(" ");
			stringBuilder.Append(this.method_1().imethod_2()).Append(", ");
			stringBuilder.Append(this.method_0().imethod_0()).Append(" ");
			stringBuilder.Append(this.method_0().imethod_2()).Append(")");
			return stringBuilder.ToString();
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x002BD96C File Offset: 0x002BBB6C
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0400209D RID: 8349
		private ICoordinate p0 = null;

		// Token: 0x0400209E RID: 8350
		private ICoordinate p1 = null;
	}
}
