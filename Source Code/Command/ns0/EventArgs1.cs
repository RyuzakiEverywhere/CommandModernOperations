using System;
using System.ComponentModel;
using ns1;

namespace ns0
{
	// Token: 0x0200004B RID: 75
	internal sealed class EventArgs1 : CancelEventArgs
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x0000332C File Offset: 0x0000152C
		private EventArgs1()
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00003354 File Offset: 0x00001554
		public EventArgs1(Class48 class48_1)
		{
			this.class48_0 = class48_1;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00003363 File Offset: 0x00001563
		public Class48 method_0()
		{
			return this.class48_0;
		}

		// Token: 0x040000AC RID: 172
		private Class48 class48_0;
	}
}
