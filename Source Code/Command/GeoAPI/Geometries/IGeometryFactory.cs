using System;
using ns14;

namespace GeoAPI.Geometries
{
	// Token: 0x020004F2 RID: 1266
	public interface IGeometryFactory
	{
		// Token: 0x06002526 RID: 9510
		ICoordinateSequenceFactory imethod_0();

		// Token: 0x06002527 RID: 9511
		int imethod_1();

		// Token: 0x06002528 RID: 9512
		IPrecisionModel imethod_2();

		// Token: 0x06002529 RID: 9513
		IPoint imethod_3(ICoordinate icoordinate_0);

		// Token: 0x0600252A RID: 9514
		ILineString imethod_4(ICoordinate[] icoordinate_0);

		// Token: 0x0600252B RID: 9515
		ILinearRing imethod_5(ICoordinate[] icoordinate_0);

		// Token: 0x0600252C RID: 9516
		ILinearRing imethod_6(ICoordinateSequence icoordinateSequence_0);

		// Token: 0x0600252D RID: 9517
		IPolygon imethod_7(ILinearRing ilinearRing_0, ILinearRing[] ilinearRing_1);

		// Token: 0x0600252E RID: 9518
		IMultiPoint imethod_8(IPoint[] ipoint_0);

		// Token: 0x0600252F RID: 9519
		Interface13 imethod_9(ILineString[] ilineString_0);

		// Token: 0x06002530 RID: 9520
		IMultiPolygon imethod_10(IPolygon[] ipolygon_0);

		// Token: 0x06002531 RID: 9521
		IGeometryCollection imethod_11(IGeometry[] igeometry_0);
	}
}
