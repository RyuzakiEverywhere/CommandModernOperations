using System;
using System.Collections.ObjectModel;
using ns35;

namespace ns5
{
	// Token: 0x02000D43 RID: 3395
	internal sealed class Class2396<T> : KeyedCollection<string, Class2395<T>> where T : struct
	{
		// Token: 0x060058DB RID: 22747 RVA: 0x00039293 File Offset: 0x00037493
		protected override string GetKeyForItem(Class2395<T> item)
		{
			return item.method_0();
		}
	}
}
