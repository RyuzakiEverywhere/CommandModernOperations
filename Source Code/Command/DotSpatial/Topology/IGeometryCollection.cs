using System;
using System.Collections;
using ns25;

namespace DotSpatial.Topology
{
	// Token: 0x02000B1D RID: 2845
	public interface IGeometryCollection : IEnumerable, ICloneable, IComparable, Interface20, IGeometry
	{
		// Token: 0x170003BC RID: 956
		IGeometry this[int int_0]
		{
			get;
		}

		// Token: 0x06004721 RID: 18209
		IGeometry[] imethod_16();
	}
}
