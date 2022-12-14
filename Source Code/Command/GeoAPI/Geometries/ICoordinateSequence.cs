using System;
using ns14;

namespace GeoAPI.Geometries
{
	// Token: 0x020004E0 RID: 1248
	public interface ICoordinateSequence : ICloneable
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060024E7 RID: 9447
		int Count { get; }

		// Token: 0x060024E8 RID: 9448
		ICoordinate imethod_0(int int_0);

		// Token: 0x060024E9 RID: 9449
		void imethod_1(int int_0, Enum157 enum157_0, double double_0);

		// Token: 0x060024EA RID: 9450
		ICoordinate[] imethod_2();
	}
}
