using System;
using System.ComponentModel;
using ns1;

namespace ns0
{
	// Token: 0x02000049 RID: 73
	internal sealed class EventArgs0 : CancelEventArgs
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x0000332C File Offset: 0x0000152C
		private EventArgs0()
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00003334 File Offset: 0x00001534
		public EventArgs0(Class48 class48_1)
		{
			this.class48_0 = class48_1;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003343 File Offset: 0x00001543
		public Class48 method_0()
		{
			return this.class48_0;
		}

		// Token: 0x040000AB RID: 171
		private Class48 class48_0;
	}
}
