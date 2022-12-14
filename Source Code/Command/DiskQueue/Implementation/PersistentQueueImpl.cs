using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using ns3;

namespace DiskQueue.Implementation
{
	// Token: 0x02000099 RID: 153
	internal sealed class PersistentQueueImpl : IDisposable, Interface2
	{
		// Token: 0x0600030B RID: 779 RVA: 0x00004B13 File Offset: 0x00002D13
		[CompilerGenerated]
		public bool vmethod_0()
		{
			return this.bool_1;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00060BDC File Offset: 0x0005EDDC
		private void method_0()
		{
			if (this.string_0 == null)
			{
				return;
			}
			string path = Path.Combine(this.string_0, "lock");
			if (this.fileStream_0 != null)
			{
				this.fileStream_0.Dispose();
				File.Delete(path);
			}
			this.fileStream_0 = null;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00004B1B File Offset: 0x00002D1B
		public int method_1()
		{
			return this.linkedList_0.Count + this.hashSet_0.Count;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00004B34 File Offset: 0x00002D34
		private string method_2()
		{
			return Path.Combine(this.string_0, "transaction.log");
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00004B46 File Offset: 0x00002D46
		[CompilerGenerated]
		public int vmethod_1()
		{
			return this.int_0;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00060C24 File Offset: 0x0005EE24
		~PersistentQueueImpl()
		{
			if (!this.bool_0)
			{
				this.Dispose();
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00060C5C File Offset: 0x0005EE5C
		public void Dispose()
		{
			object obj = PersistentQueueImpl.object_1;
			lock (obj)
			{
				if (!this.bool_0)
				{
					try
					{
						this.bool_0 = true;
						object obj2 = this.object_0;
						lock (obj2)
						{
							if (this.vmethod_0())
							{
								this.method_3();
							}
						}
						GC.SuppressFinalize(this);
					}
					finally
					{
						this.method_0();
					}
				}
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00060CFC File Offset: 0x0005EEFC
		public void imethod_0(IEnumerable<Operation> ienumerable_0)
		{
			LinkedList<Class90> obj = this.linkedList_0;
			lock (obj)
			{
				this.method_5(Enumerable.Select<Operation, Operation>(Enumerable.Where<Operation>(ienumerable_0, new Func<Operation, bool>(PersistentQueueImpl.<>c.<>9.method_0)), new Func<Operation, Operation>(PersistentQueueImpl.<>c.<>9.method_1)));
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00060D88 File Offset: 0x0005EF88
		private void method_3()
		{
			PersistentQueueImpl.Class92 @class = new PersistentQueueImpl.Class92();
			using (MemoryStream memoryStream = new MemoryStream())
			{
				memoryStream.Write(Class89.byte_1, 0, Class89.byte_1.Length);
				byte[] bytes = BitConverter.GetBytes(this.method_1());
				memoryStream.Write(bytes, 0, bytes.Length);
				foreach (Class90 class90_ in Enumerable.ToArray<Class90>(this.hashSet_0))
				{
					PersistentQueueImpl.smethod_0(memoryStream, class90_, Enum9.const_0);
				}
				foreach (Class90 class90_2 in Enumerable.ToArray<Class90>(this.linkedList_0))
				{
					PersistentQueueImpl.smethod_0(memoryStream, class90_2, Enum9.const_0);
				}
				memoryStream.Write(Class89.byte_2, 0, Class89.byte_2.Length);
				memoryStream.Flush();
				@class.byte_0 = memoryStream.ToArray();
			}
			Class88.smethod_0(this.method_2(), new Action<Stream>(@class.method_0));
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00060E80 File Offset: 0x0005F080
		private static void smethod_0(Stream stream_0, Class90 class90_0, Enum9 enum9_0)
		{
			stream_0.Write(Class89.byte_0, 0, Class89.byte_0.Length);
			stream_0.WriteByte((byte)enum9_0);
			byte[] bytes = BitConverter.GetBytes(class90_0.method_0());
			stream_0.Write(bytes, 0, bytes.Length);
			byte[] bytes2 = BitConverter.GetBytes(class90_0.method_2());
			stream_0.Write(bytes2, 0, bytes2.Length);
			byte[] bytes3 = BitConverter.GetBytes(class90_0.method_4());
			stream_0.Write(bytes3, 0, bytes3.Length);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00060EEC File Offset: 0x0005F0EC
		public int[] method_4(IEnumerable<Operation> ienumerable_0)
		{
			foreach (Operation operation in ienumerable_0)
			{
				switch (operation.method_0())
				{
				case Enum9.const_0:
				{
					Class90 @class = new Class90(operation);
					this.linkedList_0.AddLast(@class);
					int num = Class91.smethod_0<int, int>(this.dictionary_0, @class.method_0());
					this.dictionary_0[@class.method_0()] = num + 1;
					break;
				}
				case Enum9.const_1:
				{
					Class90 class2 = new Class90(operation);
					this.hashSet_0.Remove(class2);
					int num2 = Class91.smethod_0<int, int>(this.dictionary_0, class2.method_0());
					this.dictionary_0[class2.method_0()] = num2 - 1;
					break;
				}
				case Enum9.const_2:
				{
					Class90 class3 = new Class90(operation);
					this.linkedList_0.AddFirst(class3);
					this.hashSet_0.Remove(class3);
					break;
				}
				}
			}
			HashSet<int> hashSet = new HashSet<int>(Enumerable.Select<KeyValuePair<int, int>, int>(Enumerable.Where<KeyValuePair<int, int>>(this.dictionary_0, new Func<KeyValuePair<int, int>, bool>(PersistentQueueImpl.<>c.<>9.method_2)), new Func<KeyValuePair<int, int>, int>(PersistentQueueImpl.<>c.<>9.method_3)));
			foreach (int key in hashSet)
			{
				this.dictionary_0.Remove(key);
			}
			return Enumerable.ToArray<int>(hashSet);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0006109C File Offset: 0x0005F29C
		private void method_5(IEnumerable<Operation> ienumerable_0)
		{
			LinkedList<Class90> obj = this.linkedList_0;
			int[] array;
			lock (obj)
			{
				array = this.method_4(ienumerable_0);
			}
			foreach (int num in array)
			{
				if (this.vmethod_1() != num)
				{
					File.Delete(this.method_6(num));
				}
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00004B4E File Offset: 0x00002D4E
		public string method_6(int int_1)
		{
			return Path.Combine(this.string_0, "data." + int_1);
		}

		// Token: 0x04000277 RID: 631
		private readonly HashSet<Class90> hashSet_0;

		// Token: 0x04000278 RID: 632
		private readonly Dictionary<int, int> dictionary_0;

		// Token: 0x04000279 RID: 633
		private readonly LinkedList<Class90> linkedList_0;

		// Token: 0x0400027A RID: 634
		private readonly string string_0;

		// Token: 0x0400027B RID: 635
		private readonly object object_0;

		// Token: 0x0400027C RID: 636
		private static readonly object object_1 = new object();

		// Token: 0x0400027D RID: 637
		private volatile bool bool_0;

		// Token: 0x0400027E RID: 638
		private FileStream fileStream_0;

		// Token: 0x0400027F RID: 639
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000280 RID: 640
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0200009B RID: 155
		[CompilerGenerated]
		private sealed class Class92
		{
			// Token: 0x06000320 RID: 800 RVA: 0x00004BA8 File Offset: 0x00002DA8
			internal void method_0(Stream stream_0)
			{
				stream_0.SetLength((long)this.byte_0.Length);
				stream_0.Write(this.byte_0, 0, this.byte_0.Length);
			}

			// Token: 0x04000287 RID: 647
			public byte[] byte_0;
		}
	}
}
