using System;
using ns25;

namespace DotSpatial.Topology
{
	// Token: 0x02000B33 RID: 2867
	public interface IPolygon : ICloneable, IComparable, Interface20, IGeometry, Interface26
	{
		// Token: 0x0600477A RID: 18298
		ILinearRing imethod_17();

		// Token: 0x0600477B RID: 18299
		ILinearRing[] imethod_18();

		// Token: 0x0600477C RID: 18300
		ILineString imethod_19(int int_0);
	}
}
