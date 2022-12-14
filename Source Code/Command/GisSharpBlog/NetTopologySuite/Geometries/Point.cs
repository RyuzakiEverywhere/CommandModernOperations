using System;
using System.Diagnostics;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000576 RID: 1398
	[Serializable]
	public sealed class Point : Geometry, IComparable<IGeometry>, IEquatable<IGeometry>, ICloneable, IComparable, IGeometry, IPoint
	{
		// Token: 0x06002884 RID: 10372 RVA: 0x00013678 File Offset: 0x00011878
		public Point(ICoordinateSequence icoordinateSequence_0, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (icoordinateSequence_0 == null)
			{
				icoordinateSequence_0 = igeometryFactory_0.imethod_0().imethod_0(new ICoordinate[0]);
			}
			Debug.Assert(icoordinateSequence_0.Count <= 1);
			this.coordinates = icoordinateSequence_0;
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x002C4B14 File Offset: 0x002C2D14
		public override ICoordinate[] imethod_6()
		{
			return this.imethod_10() ? new ICoordinate[0] : new ICoordinate[]
			{
				this.imethod_5()
			};
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x002C4B44 File Offset: 0x002C2D44
		public override int imethod_3()
		{
			return this.imethod_10() ? 0 : 1;
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x000136B5 File Offset: 0x000118B5
		public override bool imethod_10()
		{
			return this.imethod_5() == null;
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x00003024 File Offset: 0x00001224
		public override Dimensions imethod_7()
		{
			return Dimensions.Point;
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x000126FC File Offset: 0x000108FC
		public override Dimensions imethod_4()
		{
			return Dimensions.False;
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x002C4B60 File Offset: 0x002C2D60
		public override ICoordinate imethod_5()
		{
			return (this.coordinates.Count != 0) ? this.coordinates.imethod_0(0) : null;
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x002C4B8C File Offset: 0x002C2D8C
		protected override IEnvelope vmethod_1()
		{
			IEnvelope result;
			if (this.imethod_10())
			{
				result = new Envelope();
			}
			else
			{
				result = new Envelope(this.imethod_5().imethod_0(), this.imethod_5().imethod_0(), this.imethod_5().imethod_2(), this.imethod_5().imethod_2());
			}
			return result;
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x002C4BE0 File Offset: 0x002C2DE0
		public override object Clone()
		{
			Point point = (Point)base.Clone();
			point.coordinates = (ICoordinateSequence)this.coordinates.Clone();
			return point;
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x002C4C14 File Offset: 0x002C2E14
		protected internal override int vmethod_2(object object_0)
		{
			Point point = (Point)object_0;
			return this.imethod_5().CompareTo(point.imethod_5());
		}

		// Token: 0x04002129 RID: 8489
		private static readonly ICoordinate emptyCoordinate = null;

		// Token: 0x0400212A RID: 8490
		public static readonly IPoint Empty = new GeometryFactory().imethod_3(Point.emptyCoordinate);

		// Token: 0x0400212B RID: 8491
		private ICoordinateSequence coordinates;
	}
}
