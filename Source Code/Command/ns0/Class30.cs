using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x02000034 RID: 52
	internal static class Class30
	{
		// Token: 0x06000091 RID: 145 RVA: 0x00002E76 File Offset: 0x00001076
		public static bool smethod_0(Type type_0)
		{
			Class33.smethod_0(type_0, "t");
			return Class32.smethod_0(type_0) && type_0.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00055E04 File Offset: 0x00054004
		public static bool smethod_1(Type type_0, Type type_1, string string_0)
		{
			Class30.Class31 @class = new Class30.Class31();
			@class.string_0 = string_0;
			@class.type_0 = type_1;
			return Enumerable.Any<MethodInfo>(type_0.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), new Func<MethodInfo, bool>(@class.method_0));
		}

		// Token: 0x02000035 RID: 53
		[CompilerGenerated]
		private sealed class Class31
		{
			// Token: 0x06000094 RID: 148 RVA: 0x00002EA2 File Offset: 0x000010A2
			internal bool method_0(MethodInfo methodInfo_0)
			{
				return methodInfo_0.Name == this.string_0 && methodInfo_0.DeclaringType != this.type_0 && methodInfo_0.GetBaseDefinition().DeclaringType == this.type_0;
			}

			// Token: 0x0400008F RID: 143
			public string string_0;

			// Token: 0x04000090 RID: 144
			public Type type_0;
		}
	}
}
