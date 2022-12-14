using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Command_Core
{
	// Token: 0x0200039B RID: 923
	[StandardModule]
	public sealed class RBWQuadTree
	{
		// Token: 0x0200039C RID: 924
		[Serializable]
		public struct TQPoint<T>
		{
			// Token: 0x040018F1 RID: 6385
			public double X;

			// Token: 0x040018F2 RID: 6386
			public double Y;

			// Token: 0x040018F3 RID: 6387
			public List<T> Data;
		}

		// Token: 0x0200039D RID: 925
		[Serializable]
		public sealed class TSelectNode<T> : IComparer<RBWQuadTree.TSelectNode<T>>
		{
			// Token: 0x06001BF8 RID: 7160 RVA: 0x001FDDB0 File Offset: 0x001FBFB0
			public int Compare(RBWQuadTree.TSelectNode<T> x, RBWQuadTree.TSelectNode<T> y)
			{
				double num = y.Distance - x.Distance;
				int result;
				if (num > 0.0)
				{
					result = -1;
				}
				else if (num < 0.0)
				{
					result = 1;
				}
				else
				{
					result = 0;
				}
				return result;
			}

			// Token: 0x040018F4 RID: 6388
			public double Distance;

			// Token: 0x040018F5 RID: 6389
			public RBWQuadTree.TQPoint<T> Point;
		}
	}
}
