using System;
using System.Runtime.InteropServices;

namespace ns1
{
	// Token: 0x0200005D RID: 93
	internal sealed class Class58 : IDisposable
	{
		// Token: 0x06000190 RID: 400 RVA: 0x000038AD File Offset: 0x00001AAD
		public void method_0()
		{
			if (this.bool_0)
			{
				this.class59_0.method_0();
				this.bool_0 = false;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000038C9 File Offset: 0x00001AC9
		void IDisposable.Dispose()
		{
			this.method_0();
		}

		// Token: 0x040000E1 RID: 225
		private Class58.Class59 class59_0;

		// Token: 0x040000E2 RID: 226
		private bool bool_0;

		// Token: 0x0200005E RID: 94
		private sealed class Class59
		{
			// Token: 0x06000192 RID: 402
			[DllImport("User32", CallingConvention = CallingConvention.StdCall)]
			private static extern bool UnregisterPowerSettingNotification(IntPtr intptr_1);

			// Token: 0x06000193 RID: 403 RVA: 0x000038D1 File Offset: 0x00001AD1
			public void method_0()
			{
				Class58.Class59.UnregisterPowerSettingNotification(this.intptr_0);
			}

			// Token: 0x040000E3 RID: 227
			internal static Guid guid_0 = new Guid(2709787400U, 13633, 20395, 188, 129, 247, 21, 86, 242, 11, 74);

			// Token: 0x040000E4 RID: 228
			internal static Guid guid_1 = new Guid(2355003354U, 59583, 19094, 154, 133, 166, 226, 58, 140, 99, 92);

			// Token: 0x040000E5 RID: 229
			internal static Guid guid_2 = new Guid(941310498U, 63124, 16880, 150, 133, byte.MaxValue, 91, 178, 96, 223, 46);

			// Token: 0x040000E6 RID: 230
			private IntPtr intptr_0;
		}
	}
}
