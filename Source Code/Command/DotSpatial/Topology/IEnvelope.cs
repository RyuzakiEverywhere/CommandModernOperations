using System;
using System.ComponentModel;
using ns25;

namespace DotSpatial.Topology
{
	// Token: 0x02000B13 RID: 2835
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public interface IEnvelope : ICloneable, Interface19
	{
		// Token: 0x060046BD RID: 18109
		void imethod_4(Coordinate coordinate_0, Coordinate coordinate_1);

		// Token: 0x060046BE RID: 18110
		Coordinate imethod_5();

		// Token: 0x060046BF RID: 18111
		Coordinate imethod_6();

		// Token: 0x060046C0 RID: 18112
		int imethod_7();

		// Token: 0x060046C1 RID: 18113
		bool imethod_8();
	}
}
