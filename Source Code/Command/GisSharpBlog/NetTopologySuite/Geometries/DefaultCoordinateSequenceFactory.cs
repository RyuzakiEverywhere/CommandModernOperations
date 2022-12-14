using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000577 RID: 1399
	[Obsolete("No longer used")]
	[Serializable]
	public sealed class DefaultCoordinateSequenceFactory : ICoordinateSequenceFactory
	{
		// Token: 0x0600288F RID: 10383 RVA: 0x00002977 File Offset: 0x00000B77
		private DefaultCoordinateSequenceFactory()
		{
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x002C4C3C File Offset: 0x002C2E3C
		public ICoordinateSequence imethod_0(ICoordinate[] icoordinate_0)
		{
			return new DefaultCoordinateSequence(icoordinate_0);
		}

		// Token: 0x0400212C RID: 8492
		private static readonly DefaultCoordinateSequenceFactory instance = new DefaultCoordinateSequenceFactory();
	}
}
