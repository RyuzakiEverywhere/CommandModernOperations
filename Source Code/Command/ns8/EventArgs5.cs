using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns8
{
	// Token: 0x020000E5 RID: 229
	internal sealed class EventArgs5<T> : EventArgs
	{
		// Token: 0x060005E1 RID: 1505 RVA: 0x0000655E File Offset: 0x0000475E
		[CompilerGenerated]
		public IEnumerable<T> method_0()
		{
			return this.ienumerable_0;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00006566 File Offset: 0x00004766
		[CompilerGenerated]
		private void method_1(IEnumerable<T> ienumerable_1)
		{
			this.ienumerable_0 = ienumerable_1;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0000656F File Offset: 0x0000476F
		public EventArgs5(IEnumerable<T> ienumerable_1)
		{
			this.method_1(ienumerable_1);
		}

		// Token: 0x040003FD RID: 1021
		[CompilerGenerated]
		private IEnumerable<T> ienumerable_0;
	}
}
