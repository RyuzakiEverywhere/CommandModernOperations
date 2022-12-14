using System;
using System.Threading;
using DiskQueue.Implementation;

namespace ns3
{
	// Token: 0x02000091 RID: 145
	internal sealed class Class86 : IDisposable
	{
		// Token: 0x060002EB RID: 747 RVA: 0x000608F4 File Offset: 0x0005EAF4
		public void Dispose()
		{
			PersistentQueueImpl persistentQueueImpl = Interlocked.Exchange<PersistentQueueImpl>(ref this.persistentQueueImpl_0, null);
			if (persistentQueueImpl == null)
			{
				return;
			}
			persistentQueueImpl.Dispose();
			GC.SuppressFinalize(this);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00060920 File Offset: 0x0005EB20
		~Class86()
		{
			if (this.persistentQueueImpl_0 != null)
			{
				this.Dispose();
			}
		}

		// Token: 0x04000264 RID: 612
		private PersistentQueueImpl persistentQueueImpl_0;
	}
}
