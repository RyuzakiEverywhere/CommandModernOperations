using System;

namespace ns0
{
	// Token: 0x02000036 RID: 54
	internal static class Class32
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00002EE2 File Offset: 0x000010E2
		public static bool smethod_0(Type type_0)
		{
			return type_0.IsGenericType;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002EEA File Offset: 0x000010EA
		public static Type smethod_1(Type type_0)
		{
			return type_0.BaseType;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002EF2 File Offset: 0x000010F2
		public static bool smethod_2(Type type_0)
		{
			return type_0.IsVisible;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002EFA File Offset: 0x000010FA
		public static bool smethod_3(Type type_0)
		{
			return type_0.IsValueType;
		}
	}
}
