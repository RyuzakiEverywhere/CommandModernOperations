using System;

namespace GeoAPI.Geometries
{
	// Token: 0x020004ED RID: 1261
	public interface IPrecisionModel : IComparable<IPrecisionModel>, IEquatable<IPrecisionModel>, IComparable
	{
		// Token: 0x06002519 RID: 9497
		PrecisionModels imethod_0();

		// Token: 0x0600251A RID: 9498
		int imethod_1();

		// Token: 0x0600251B RID: 9499
		double imethod_2();

		// Token: 0x0600251C RID: 9500
		void imethod_3(ICoordinate icoordinate_0);
	}
}
