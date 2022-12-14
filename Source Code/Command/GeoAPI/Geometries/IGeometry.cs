using System;

namespace GeoAPI.Geometries
{
	// Token: 0x020004E3 RID: 1251
	public interface IGeometry : IComparable<IGeometry>, IEquatable<IGeometry>, ICloneable, IComparable
	{
		// Token: 0x06002502 RID: 9474
		IGeometryFactory imethod_0();

		// Token: 0x06002503 RID: 9475
		IPrecisionModel imethod_1();

		// Token: 0x06002504 RID: 9476
		int imethod_2();

		// Token: 0x06002505 RID: 9477
		int imethod_3();

		// Token: 0x06002506 RID: 9478
		Dimensions imethod_4();

		// Token: 0x06002507 RID: 9479
		ICoordinate imethod_5();

		// Token: 0x06002508 RID: 9480
		ICoordinate[] imethod_6();

		// Token: 0x06002509 RID: 9481
		Dimensions imethod_7();

		// Token: 0x0600250A RID: 9482
		IEnvelope imethod_8();

		// Token: 0x0600250B RID: 9483
		IGeometry imethod_9(int int_0);

		// Token: 0x0600250C RID: 9484
		bool imethod_10();
	}
}
