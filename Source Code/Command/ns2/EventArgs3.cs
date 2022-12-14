using System;
using System.Runtime.CompilerServices;
using DarkUI.Docking;

namespace ns2
{
	// Token: 0x020000BC RID: 188
	internal sealed class EventArgs3 : EventArgs
	{
		// Token: 0x06000415 RID: 1045 RVA: 0x000055EA File Offset: 0x000037EA
		[CompilerGenerated]
		public DarkDockContent method_0()
		{
			return this.darkDockContent_0;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000055F2 File Offset: 0x000037F2
		[CompilerGenerated]
		private void method_1(DarkDockContent darkDockContent_1)
		{
			this.darkDockContent_0 = darkDockContent_1;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000055FB File Offset: 0x000037FB
		public EventArgs3(DarkDockContent darkDockContent_1)
		{
			this.method_1(darkDockContent_1);
		}

		// Token: 0x04000331 RID: 817
		[CompilerGenerated]
		private DarkDockContent darkDockContent_0;
	}
}
