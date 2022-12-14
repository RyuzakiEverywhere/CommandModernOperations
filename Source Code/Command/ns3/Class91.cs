using System;
using System.Collections.Generic;

namespace ns3
{
	// Token: 0x02000096 RID: 150
	internal static class Class91
	{
		// Token: 0x06000301 RID: 769 RVA: 0x00060BB8 File Offset: 0x0005EDB8
		public static T smethod_0<T, K>(IDictionary<K, T> idictionary_0, K gparam_0)
		{
			T result;
			if (idictionary_0.TryGetValue(gparam_0, out result))
			{
				return result;
			}
			return default(T);
		}
	}
}
