using System;

namespace ns0
{
	// Token: 0x02000033 RID: 51
	internal static class Class29
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00002E47 File Offset: 0x00001047
		public static string smethod_0(object object_0)
		{
			if (object_0 == null)
			{
				return "{null}";
			}
			if (!(object_0 is string))
			{
				return object_0.ToString();
			}
			return "\"" + object_0.ToString() + "\"";
		}
	}
}
