using System;
using System.Runtime.InteropServices;

namespace ns3
{
	// Token: 0x0200009E RID: 158
	internal sealed class Class94
	{
		// Token: 0x06000324 RID: 804
		[DllImport("libc", BestFitMapping = false, CharSet = CharSet.Ansi, SetLastError = true, ThrowOnUnmappableChar = true)]
		private static extern int chmod(string string_0, uint uint_0);

		// Token: 0x06000325 RID: 805 RVA: 0x00004BDA File Offset: 0x00002DDA
		public static int smethod_0(string string_0, Enum10 enum10_0)
		{
			return Class94.chmod(string_0, (uint)enum10_0);
		}
	}
}
