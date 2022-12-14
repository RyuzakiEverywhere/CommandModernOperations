using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000567 RID: 1383
	[Serializable]
	public sealed class CoordinateStructSequenceFactory : ICoordinateSequenceFactory
	{
		// Token: 0x0600283B RID: 10299 RVA: 0x00002977 File Offset: 0x00000B77
		private CoordinateStructSequenceFactory()
		{
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x002C42E4 File Offset: 0x002C24E4
		public ICoordinateSequence imethod_0(ICoordinate[] icoordinate_0)
		{
			return new CoordinateStructSequence(icoordinate_0);
		}

		// Token: 0x04002108 RID: 8456
		private static readonly CoordinateStructSequenceFactory instance = new CoordinateStructSequenceFactory();
	}
}
