using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using DiskQueue.Implementation;

namespace ns3
{
	// Token: 0x0200009C RID: 156
	internal sealed class Class93 : IDisposable
	{
		// Token: 0x06000321 RID: 801 RVA: 0x00061144 File Offset: 0x0005F344
		public void Dispose()
		{
			object obj = Class93.object_0;
			lock (obj)
			{
				if (this.bool_0)
				{
					return;
				}
				this.bool_0 = true;
				this.interface2_0.imethod_0(this.list_0);
				this.list_0.Clear();
				foreach (Stream stream in this.list_1)
				{
					stream.Dispose();
				}
				this.stream_0.Dispose();
				GC.SuppressFinalize(this);
			}
			Thread.Sleep(0);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00061208 File Offset: 0x0005F408
		~Class93()
		{
			if (!this.bool_0)
			{
				this.Dispose();
			}
		}

		// Token: 0x04000288 RID: 648
		private readonly List<Operation> list_0;

		// Token: 0x04000289 RID: 649
		private Stream stream_0;

		// Token: 0x0400028A RID: 650
		private readonly Interface2 interface2_0;

		// Token: 0x0400028B RID: 651
		private readonly List<Stream> list_1;

		// Token: 0x0400028C RID: 652
		private static readonly object object_0 = new object();

		// Token: 0x0400028D RID: 653
		private volatile bool bool_0;
	}
}
