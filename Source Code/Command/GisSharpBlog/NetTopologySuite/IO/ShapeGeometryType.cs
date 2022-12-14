using System;

namespace GisSharpBlog.NetTopologySuite.IO
{
	// Token: 0x02000532 RID: 1330
	public enum ShapeGeometryType
	{
		// Token: 0x04002081 RID: 8321
		NullShape,
		// Token: 0x04002082 RID: 8322
		Point,
		// Token: 0x04002083 RID: 8323
		LineString = 3,
		// Token: 0x04002084 RID: 8324
		Polygon = 5,
		// Token: 0x04002085 RID: 8325
		MultiPoint = 8,
		// Token: 0x04002086 RID: 8326
		PointZM = 11,
		// Token: 0x04002087 RID: 8327
		LineStringZM = 13,
		// Token: 0x04002088 RID: 8328
		PolygonZM = 15,
		// Token: 0x04002089 RID: 8329
		MultiPointZM = 18,
		// Token: 0x0400208A RID: 8330
		PointM = 21,
		// Token: 0x0400208B RID: 8331
		LineStringM = 23,
		// Token: 0x0400208C RID: 8332
		PolygonM = 25,
		// Token: 0x0400208D RID: 8333
		MultiPointM = 28,
		// Token: 0x0400208E RID: 8334
		MultiPatch = 31,
		// Token: 0x0400208F RID: 8335
		PointZ = 9,
		// Token: 0x04002090 RID: 8336
		LineStringZ,
		// Token: 0x04002091 RID: 8337
		PolygonZ = 19,
		// Token: 0x04002092 RID: 8338
		MultiPointZ
	}
}
