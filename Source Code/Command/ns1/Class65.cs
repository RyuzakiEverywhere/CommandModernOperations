using System;
using System.Collections.Generic;

namespace ns1
{
	// Token: 0x0200006A RID: 106
	internal sealed class Class65
	{
		// Token: 0x0200006B RID: 107
		internal sealed class Class66 : IComparer<Struct13>
		{
			// Token: 0x060001D7 RID: 471 RVA: 0x00003B66 File Offset: 0x00001D66
			public int Compare(Struct13 x, Struct13 y)
			{
				if (x.int_0 > y.int_0)
				{
					return 1;
				}
				if (x.int_0 < y.int_0)
				{
					return -1;
				}
				return 0;
			}
		}
	}
}
