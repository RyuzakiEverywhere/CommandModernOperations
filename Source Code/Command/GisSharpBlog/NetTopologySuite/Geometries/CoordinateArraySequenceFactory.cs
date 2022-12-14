using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000557 RID: 1367
	[Serializable]
	public sealed class CoordinateArraySequenceFactory : ICoordinateSequenceFactory
	{
		// Token: 0x060027AF RID: 10159 RVA: 0x00002977 File Offset: 0x00000B77
		private CoordinateArraySequenceFactory()
		{
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x002C2EC0 File Offset: 0x002C10C0
		public static CoordinateArraySequenceFactory smethod_0()
		{
			return CoordinateArraySequenceFactory.instance;
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x002C2ED4 File Offset: 0x002C10D4
		public ICoordinateSequence imethod_0(ICoordinate[] icoordinate_0)
		{
			return new CoordinateArraySequence(icoordinate_0);
		}

		// Token: 0x040020E5 RID: 8421
		private static readonly CoordinateArraySequenceFactory instance = new CoordinateArraySequenceFactory();
	}
}
