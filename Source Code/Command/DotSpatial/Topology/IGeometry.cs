using System;
using ns25;

namespace DotSpatial.Topology
{
	// Token: 0x02000B19 RID: 2841
	public interface IGeometry : ICloneable, IComparable, Interface20
	{
		// Token: 0x060046F2 RID: 18162
		void imethod_5(Interface27 interface27_0);

		// Token: 0x060046F3 RID: 18163
		void imethod_6(Interface28 interface28_0);

		// Token: 0x060046F4 RID: 18164
		void imethod_7(Interface21 interface21_0);

		// Token: 0x060046F5 RID: 18165
		int imethod_8(object object_0);

		// Token: 0x060046F6 RID: 18166
		void imethod_9();

		// Token: 0x060046F7 RID: 18167
		IGeometry imethod_10(int int_0);

		// Token: 0x060046F8 RID: 18168
		Coordinate imethod_11();

		// Token: 0x060046F9 RID: 18169
		IEnvelope imethod_12();

		// Token: 0x060046FA RID: 18170
		IGeometryFactory imethod_13();

		// Token: 0x060046FB RID: 18171
		bool imethod_14();

		// Token: 0x060046FC RID: 18172
		PrecisionModelType imethod_15();
	}
}
