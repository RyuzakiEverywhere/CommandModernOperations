using System;
using GeoAPI.Geometries;
using ns14;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000547 RID: 1351
	[Serializable]
	public sealed class LinearRing : LineString, IComparable<IGeometry>, IEquatable<IGeometry>, ICloneable, IComparable, IGeometry, Interface12, ILineString, ILinearRing
	{
		// Token: 0x06002746 RID: 10054 RVA: 0x00012D10 File Offset: 0x00010F10
		public LinearRing(ICoordinateSequence icoordinateSequence_0, IGeometryFactory igeometryFactory_0) : base(icoordinateSequence_0, igeometryFactory_0)
		{
			this.method_5();
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x002C193C File Offset: 0x002BFB3C
		private void method_5()
		{
			if (!this.imethod_10() && !base.imethod_12())
			{
				throw new ArgumentException("points must form a closed linestring");
			}
			if (base.imethod_11().Count >= 1 && base.imethod_11().Count <= 3)
			{
				throw new ArgumentException("Number of points must be 0 or >3");
			}
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x000041ED File Offset: 0x000023ED
		public override bool imethod_12()
		{
			return true;
		}
	}
}
