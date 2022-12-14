using System;
using System.Collections;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x0200056F RID: 1391
	[Serializable]
	public sealed class MultiPolygon : GeometryCollection, IEnumerable, IComparable<IGeometry>, IEquatable<IGeometry>, ICloneable, IComparable, IGeometry, IGeometryCollection, IMultiPolygon
	{
		// Token: 0x0600284B RID: 10315 RVA: 0x000127F3 File Offset: 0x000109F3
		public MultiPolygon(IPolygon[] ipolygon_0, IGeometryFactory igeometryFactory_0) : base(ipolygon_0, igeometryFactory_0)
		{
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x0000C629 File Offset: 0x0000A829
		public override Dimensions imethod_7()
		{
			return Dimensions.Surface;
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x000041ED File Offset: 0x000023ED
		public override Dimensions imethod_4()
		{
			return Dimensions.Curve;
		}

		// Token: 0x0400211D RID: 8477
		public new static readonly IMultiPolygon Empty = new GeometryFactory().imethod_10(null);
	}
}
