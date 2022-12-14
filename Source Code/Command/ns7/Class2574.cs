using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns7
{
	// Token: 0x02000F5A RID: 3930
	[CompilerGenerated]
	internal sealed class Class2574
	{
		// Token: 0x06008C66 RID: 35942 RVA: 0x002B7540 File Offset: 0x002B5740
		internal static uint smethod_0(string string_0)
		{
			uint num = 2166136261U;
			if (string_0 != null)
			{
				for (int i = 0; i < string_0.Length; i++)
				{
					num = ((uint)string_0[i] ^ num) * 16777619U;
				}
			}
			return num;
		}

		// Token: 0x04004C11 RID: 19473 RVA: 0x000022E0 File Offset: 0x000004E0
		internal static readonly Class2574.Struct80 struct80_0;

		// Token: 0x04004C12 RID: 19474 RVA: 0x000027F0 File Offset: 0x000009F0
		internal static readonly Class2574.Struct79 struct79_0;

		// Token: 0x04004C13 RID: 19475 RVA: 0x00002328 File Offset: 0x00000528
		internal static readonly Class2574.Struct80 struct80_1;

		// Token: 0x02000F5B RID: 3931
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 5)]
		private struct Struct79
		{
		}

		// Token: 0x02000F5C RID: 3932
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
		private struct Struct80
		{
		}
	}
}
