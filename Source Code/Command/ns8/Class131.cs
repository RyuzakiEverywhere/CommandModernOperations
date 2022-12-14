using System;
using System.Collections.Generic;
using System.Threading;

namespace ns8
{
	// Token: 0x020000E6 RID: 230
	internal sealed class Class131<T> : IDisposable
	{
		// Token: 0x060005E4 RID: 1508 RVA: 0x0000657E File Offset: 0x0000477E
		public void Dispose()
		{
			if (this.readerWriterLockSlim_0 != null)
			{
				this.readerWriterLockSlim_0.Dispose();
			}
		}

		// Token: 0x040003FE RID: 1022
		private readonly ReaderWriterLockSlim readerWriterLockSlim_0 = new ReaderWriterLockSlim(1);

		// Token: 0x040003FF RID: 1023
		private readonly HashSet<T> hashSet_0 = new HashSet<T>();
	}
}
