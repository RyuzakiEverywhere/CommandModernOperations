using System;
using System.Runtime.CompilerServices;

namespace ns2
{
	// Token: 0x020000E0 RID: 224
	internal sealed class EventArgs4 : EventArgs
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0000630D File Offset: 0x0000450D
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00006315 File Offset: 0x00004515
		public int Value { get; private set; }

		// Token: 0x060005BD RID: 1469 RVA: 0x0000631E File Offset: 0x0000451E
		public EventArgs4(int int_1)
		{
			this.Value = int_1;
		}

		// Token: 0x040003F3 RID: 1011
		[CompilerGenerated]
		private int int_0;
	}
}
