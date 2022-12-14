using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x0200057F RID: 1407
	[Serializable]
	public sealed class CoordinateStructSequence : CoordinateArraySequence
	{
		// Token: 0x060028AF RID: 10415 RVA: 0x0001377A File Offset: 0x0001197A
		public CoordinateStructSequence(ICoordinate[] icoordinate_0) : base(icoordinate_0)
		{
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x002C5D70 File Offset: 0x002C3F70
		public override object Clone()
		{
			ICoordinate[] icoordinate_ = base.method_0();
			return new CoordinateStructSequence(icoordinate_);
		}
	}
}
