using System;
using System.Collections;

namespace GeoAPI.Geometries
{
	// Token: 0x020004E4 RID: 1252
	public interface IGeometryCollection : IEnumerable, IComparable<IGeometry>, IEquatable<IGeometry>, ICloneable, IComparable, IGeometry
	{
		// Token: 0x0600250D RID: 9485
		IGeometry[] imethod_11();

		// Token: 0x17000148 RID: 328
		IGeometry this[int int_0]
		{
			get;
		}
	}
}
