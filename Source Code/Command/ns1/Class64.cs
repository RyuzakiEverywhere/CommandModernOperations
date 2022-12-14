using System;
using System.Runtime.InteropServices;

namespace ns1
{
	// Token: 0x02000065 RID: 101
	internal static class Class64
	{
		// Token: 0x060001CE RID: 462
		[DllImport("Kernel32.dll")]
		private static extern bool QueryPerformanceCounter(out long perfcount);

		// Token: 0x060001CF RID: 463
		[DllImport("Kernel32.dll")]
		private static extern bool QueryPerformanceFrequency(out long freq);

		// Token: 0x060001D0 RID: 464 RVA: 0x00003B4C File Offset: 0x00001D4C
		static Class64()
		{
			Class64.QueryPerformanceFrequency(out Class64.long_1);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00003B59 File Offset: 0x00001D59
		public static void smethod_0()
		{
			Class64.QueryPerformanceCounter(out Class64.long_0);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00058A68 File Offset: 0x00056C68
		public static double smethod_1()
		{
			long num;
			Class64.QueryPerformanceCounter(out num);
			return (double)(num - Class64.long_0) / (double)Class64.long_1;
		}

		// Token: 0x040000FF RID: 255
		private static long long_0;

		// Token: 0x04000100 RID: 256
		private static long long_1;
	}
}
