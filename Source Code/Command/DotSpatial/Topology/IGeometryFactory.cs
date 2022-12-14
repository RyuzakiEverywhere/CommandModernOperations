using System;
using System.Collections;
using System.Collections.Generic;
using ns25;

namespace DotSpatial.Topology
{
	// Token: 0x02000B20 RID: 2848
	public interface IGeometryFactory
	{
		// Token: 0x0600473D RID: 18237
		int imethod_0();

		// Token: 0x0600473E RID: 18238
		PrecisionModelType imethod_1();

		// Token: 0x0600473F RID: 18239
		IGeometry imethod_2(IList ilist_0);

		// Token: 0x06004740 RID: 18240
		IPoint imethod_3(Coordinate coordinate_0);

		// Token: 0x06004741 RID: 18241
		Interface31 imethod_4(Interface23[] interface23_0);

		// Token: 0x06004742 RID: 18242
		IGeometryCollection imethod_5(IGeometry[] igeometry_0);

		// Token: 0x06004743 RID: 18243
		IMultiPolygon imethod_6(IPolygon[] ipolygon_0);

		// Token: 0x06004744 RID: 18244
		ILinearRing imethod_7(IList<Coordinate> ilist_0);

		// Token: 0x06004745 RID: 18245
		IMultiPoint imethod_8(IEnumerable<Interface24> ienumerable_0);

		// Token: 0x06004746 RID: 18246
		ILineString imethod_9(IList<Coordinate> ilist_0);

		// Token: 0x06004747 RID: 18247
		IPolygon imethod_10(ILinearRing ilinearRing_0, ILinearRing[] ilinearRing_1);
	}
}
