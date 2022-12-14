using System;
using GeoAPI.Geometries;
using ns14;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000546 RID: 1350
	[Serializable]
	public class LineString : Geometry, IComparable<IGeometry>, IEquatable<IGeometry>, ICloneable, IComparable, IGeometry, Interface12, ILineString
	{
		// Token: 0x06002736 RID: 10038 RVA: 0x002C1638 File Offset: 0x002BF838
		public override ICoordinate[] imethod_6()
		{
			return this.points.imethod_2();
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x002C1654 File Offset: 0x002BF854
		public ICoordinateSequence imethod_11()
		{
			return this.points;
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x002C166C File Offset: 0x002BF86C
		public LineString(ICoordinateSequence icoordinateSequence_0, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (icoordinateSequence_0 == null)
			{
				icoordinateSequence_0 = igeometryFactory_0.imethod_0().imethod_0(new ICoordinate[0]);
			}
			if (icoordinateSequence_0.Count == 1)
			{
				throw new ArgumentException("point array must contain 0 or >1 elements", "points");
			}
			this.points = icoordinateSequence_0;
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x002C16C4 File Offset: 0x002BF8C4
		public ICoordinate imethod_13(int int_0)
		{
			return this.points.imethod_0(int_0);
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x002C16E0 File Offset: 0x002BF8E0
		public override ICoordinate imethod_5()
		{
			ICoordinate result;
			if (this.imethod_10())
			{
				result = null;
			}
			else
			{
				result = this.points.imethod_0(0);
			}
			return result;
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x000041ED File Offset: 0x000023ED
		public override Dimensions imethod_7()
		{
			return Dimensions.Curve;
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x002C170C File Offset: 0x002BF90C
		public override Dimensions imethod_4()
		{
			Dimensions result;
			if (this.imethod_12())
			{
				result = Dimensions.False;
			}
			else
			{
				result = Dimensions.Point;
			}
			return result;
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x00012CAE File Offset: 0x00010EAE
		public override bool imethod_10()
		{
			return this.points.Count == 0;
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x002C172C File Offset: 0x002BF92C
		public override int imethod_3()
		{
			return this.points.Count;
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x002C1748 File Offset: 0x002BF948
		public virtual bool imethod_12()
		{
			return !this.imethod_10() && this.imethod_13(0).imethod_8(this.imethod_13(this.imethod_3() - 1));
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x002C1780 File Offset: 0x002BF980
		protected override IEnvelope vmethod_1()
		{
			IEnvelope result;
			if (this.imethod_10())
			{
				result = new Envelope();
			}
			else
			{
				ICoordinate[] array = this.points.imethod_2();
				double num = array[0].imethod_0();
				double num2 = array[0].imethod_2();
				double num3 = array[0].imethod_0();
				double num4 = array[0].imethod_2();
				for (int i = 1; i < array.Length; i++)
				{
					num = ((num < array[i].imethod_0()) ? num : array[i].imethod_0());
					num3 = ((num3 > array[i].imethod_0()) ? num3 : array[i].imethod_0());
					num2 = ((num2 < array[i].imethod_2()) ? num2 : array[i].imethod_2());
					num4 = ((num4 > array[i].imethod_2()) ? num4 : array[i].imethod_2());
				}
				result = new Envelope(num, num3, num2, num4);
			}
			return result;
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x002C1860 File Offset: 0x002BFA60
		public override object Clone()
		{
			LineString lineString = (LineString)base.Clone();
			lineString.points = (ICoordinateSequence)this.points.Clone();
			return lineString;
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x002C1894 File Offset: 0x002BFA94
		protected internal override int vmethod_2(object object_0)
		{
			LineString lineString = (LineString)object_0;
			int num = 0;
			int num2 = 0;
			while (num < this.points.Count && num2 < lineString.points.Count)
			{
				int num3 = this.points.imethod_0(num).CompareTo(lineString.points.imethod_0(num2));
				if (num3 != 0)
				{
					return num3;
				}
				num++;
				num2++;
			}
			if (num < this.points.Count)
			{
				return 1;
			}
			if (num2 < lineString.points.Count)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x17000168 RID: 360
		public ICoordinate this[int int_0]
		{
			get
			{
				return this.points.imethod_0(int_0);
			}
			set
			{
				this.points.imethod_1(int_0, Enum157.const_0, value.imethod_0());
				this.points.imethod_1(int_0, Enum157.const_1, value.imethod_2());
				this.points.imethod_1(int_0, Enum157.const_2, value.imethod_4());
			}
		}

		// Token: 0x040020B0 RID: 8368
		public static readonly ILineString Empty = new GeometryFactory().imethod_4(new ICoordinate[0]);

		// Token: 0x040020B1 RID: 8369
		private ICoordinateSequence points;
	}
}
