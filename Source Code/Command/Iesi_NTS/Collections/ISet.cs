using System;
using System.Collections;

namespace Iesi_NTS.Collections
{
	// Token: 0x02000503 RID: 1283
	public interface ISet : IEnumerable, ICollection, ICloneable
	{
		// Token: 0x060025A1 RID: 9633
		bool Contains(object object_0);

		// Token: 0x060025A2 RID: 9634
		bool Add(object object_0);

		// Token: 0x060025A3 RID: 9635
		bool imethod_0(object object_0);

		// Token: 0x060025A4 RID: 9636
		void Clear();
	}
}
