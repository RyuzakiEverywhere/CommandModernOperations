using System;
using System.Collections;
using ns25;

namespace DotSpatial.Topology
{
	// Token: 0x02000B57 RID: 2903
	[Serializable]
	public sealed class MultiPolygon : GeometryCollection, IEnumerable, ICloneable, IComparable, Interface20, IGeometry, IGeometryCollection, IMultiPolygon
	{
		// Token: 0x060048C1 RID: 18625 RVA: 0x0002E03E File Offset: 0x0002C23E
		public MultiPolygon(Interface20 interface20_0) : base(interface20_0, Geometry.DefaultFactory)
		{
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x0002E0C8 File Offset: 0x0002C2C8
		public MultiPolygon(IPolygon[] ipolygon_0, IGeometryFactory igeometryFactory_0) : base(ipolygon_0, igeometryFactory_0)
		{
		}

		// Token: 0x04002E48 RID: 11848
		public new static readonly IMultiPolygon Empty = new GeometryFactory().imethod_6(null);
	}
}
