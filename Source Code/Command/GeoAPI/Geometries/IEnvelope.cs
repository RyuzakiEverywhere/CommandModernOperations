using System;

namespace GeoAPI.Geometries
{
	// Token: 0x020004E1 RID: 1249
	public interface IEnvelope : IComparable<IEnvelope>, IEquatable<IEnvelope>, ICloneable, IComparable
	{
		// Token: 0x060024EB RID: 9451
		double imethod_0();

		// Token: 0x060024EC RID: 9452
		double imethod_1();

		// Token: 0x060024ED RID: 9453
		double imethod_2();

		// Token: 0x060024EE RID: 9454
		double imethod_3();

		// Token: 0x060024EF RID: 9455
		double imethod_4();

		// Token: 0x060024F0 RID: 9456
		bool imethod_5(ICoordinate icoordinate_0);

		// Token: 0x060024F1 RID: 9457
		bool imethod_6(IEnvelope ienvelope_0);

		// Token: 0x060024F2 RID: 9458
		void imethod_7(IEnvelope ienvelope_0);

		// Token: 0x060024F3 RID: 9459
		void imethod_8(ICoordinate icoordinate_0, ICoordinate icoordinate_1);

		// Token: 0x060024F4 RID: 9460
		bool imethod_9(IEnvelope ienvelope_0);

		// Token: 0x060024F5 RID: 9461
		bool imethod_10();
	}
}
