using System;
using System.Collections;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x0200057E RID: 1406
	[Serializable]
	public sealed class MultiPoint : GeometryCollection, IEnumerable, IComparable<IGeometry>, IEquatable<IGeometry>, ICloneable, IComparable, IGeometry, IGeometryCollection, IMultiPoint
	{
		// Token: 0x060028AB RID: 10411 RVA: 0x000127F3 File Offset: 0x000109F3
		public MultiPoint(IPoint[] ipoint_0, IGeometryFactory igeometryFactory_0) : base(ipoint_0, igeometryFactory_0)
		{
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x00003024 File Offset: 0x00001224
		public override Dimensions imethod_7()
		{
			return Dimensions.Point;
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x000126FC File Offset: 0x000108FC
		public override Dimensions imethod_4()
		{
			return Dimensions.False;
		}

		// Token: 0x04002132 RID: 8498
		public new static readonly IMultiPoint Empty = new GeometryFactory().imethod_8(new IPoint[0]);
	}
}
