using System;
using System.IO;
using System.Threading;

namespace ns3
{
	// Token: 0x02000093 RID: 147
	internal static class Class88
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x00060A64 File Offset: 0x0005EC64
		public static void smethod_0(string string_0, Action<Stream> action_0)
		{
			object obj = Class88.object_0;
			lock (obj)
			{
				if (!File.Exists(string_0 + ".old_copy"))
				{
					File.Move(string_0, string_0 + ".old_copy");
				}
				using (FileStream fileStream = new FileStream(string_0, FileMode.Create, FileAccess.Write, FileShare.None, 65536, FileOptions.WriteThrough | FileOptions.SequentialScan))
				{
					Class87.smethod_1(string_0);
					action_0(fileStream);
					fileStream.Flush();
				}
				Class88.smethod_1(string_0 + ".old_copy");
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00060B10 File Offset: 0x0005ED10
		private static bool smethod_1(string string_0)
		{
			for (int i = 0; i < 5; i++)
			{
				try
				{
					File.Delete(string_0);
					return true;
				}
				catch
				{
					Thread.Sleep(100);
				}
			}
			return false;
		}

		// Token: 0x04000265 RID: 613
		private static readonly object object_0 = new object();
	}
}
