using System;
using System.Collections.Generic;
using System.Linq;

namespace ns0
{
	// Token: 0x02000021 RID: 33
	internal static class Class14
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00055498 File Offset: 0x00053698
		public static void smethod_0<T>(IList<T> ilist_0, IEnumerable<T> ienumerable_0)
		{
			if (ilist_0 == null)
			{
				throw new ArgumentNullException("initial");
			}
			if (ienumerable_0 == null)
			{
				return;
			}
			foreach (T item in ienumerable_0)
			{
				ilist_0.Add(item);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002C1A File Offset: 0x00000E1A
		public static T[] smethod_1<T>()
		{
			return (Enumerable.Empty<T>() as T[]) ?? new T[0];
		}
	}
}
