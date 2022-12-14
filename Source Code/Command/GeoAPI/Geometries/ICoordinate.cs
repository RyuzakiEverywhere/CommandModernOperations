using System;

namespace GeoAPI.Geometries
{
	// Token: 0x020004F3 RID: 1267
	public interface ICoordinate : IComparable<ICoordinate>, IEquatable<ICoordinate>, ICloneable, IComparable
	{
		// Token: 0x06002532 RID: 9522
		double imethod_0();

		// Token: 0x06002533 RID: 9523
		void imethod_1(double double_0);

		// Token: 0x06002534 RID: 9524
		double imethod_2();

		// Token: 0x06002535 RID: 9525
		void imethod_3(double double_0);

		// Token: 0x06002536 RID: 9526
		double imethod_4();

		// Token: 0x06002537 RID: 9527
		void imethod_5(double double_0);

		// Token: 0x06002538 RID: 9528
		void imethod_6(ICoordinate icoordinate_0);

		// Token: 0x06002539 RID: 9529
		double imethod_7(ICoordinate icoordinate_0);

		// Token: 0x0600253A RID: 9530
		bool imethod_8(ICoordinate icoordinate_0);
	}
}
