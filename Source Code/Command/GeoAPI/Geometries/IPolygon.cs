using System;

namespace GeoAPI.Geometries
{
	// Token: 0x020004EE RID: 1262
	public interface IPolygon : IComparable<IGeometry>, IEquatable<IGeometry>, ICloneable, IComparable, IGeometry
	{
		// Token: 0x0600251D RID: 9501
		ILineString imethod_11();

		// Token: 0x0600251E RID: 9502
		ILinearRing imethod_12();

		// Token: 0x0600251F RID: 9503
		int imethod_13();

		// Token: 0x06002520 RID: 9504
		ILineString[] imethod_14();

		// Token: 0x06002521 RID: 9505
		ILineString imethod_15(int int_0);

		// Token: 0x06002522 RID: 9506
		ILinearRing[] imethod_16();
	}
}
