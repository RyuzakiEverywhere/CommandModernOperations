using System;

namespace DotSpatial.Topology.Utilities
{
	// Token: 0x02000B0F RID: 2831
	[Serializable]
	public sealed class CoordinateArraySequenceFactory : ICoordinateSequenceFactory
	{
		// Token: 0x0600469D RID: 18077 RVA: 0x00002977 File Offset: 0x00000B77
		private CoordinateArraySequenceFactory()
		{
		}

		// Token: 0x04002DC5 RID: 11717
		public static readonly CoordinateArraySequenceFactory Instance = new CoordinateArraySequenceFactory();
	}
}
