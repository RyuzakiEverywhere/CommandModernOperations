using System;
using System.Collections;
using ns25;

namespace DotSpatial.Topology
{
	// Token: 0x02000B30 RID: 2864
	public interface IMultiPoint : IEnumerable, ICloneable, IComparable, Interface20, IGeometry, IGeometryCollection
	{
		// Token: 0x170003C1 RID: 961
		IPoint this[int int_0]
		{
			get;
			set;
		}
	}
}
