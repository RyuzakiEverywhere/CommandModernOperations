using System;

namespace ns3
{
	// Token: 0x02000094 RID: 148
	internal static class Class89
	{
		// Token: 0x04000266 RID: 614
		public static int int_0 = 1123990689;

		// Token: 0x04000267 RID: 615
		public static byte[] byte_0 = BitConverter.GetBytes(Class89.int_0);

		// Token: 0x04000268 RID: 616
		public static Guid guid_0 = new Guid("b75bfb12-93bb-42b6-acb1-a897239ea3a5");

		// Token: 0x04000269 RID: 617
		public static byte[] byte_1 = Class89.guid_0.ToByteArray();

		// Token: 0x0400026A RID: 618
		public static Guid guid_1 = new Guid("866c9705-4456-4e9d-b452-3146b3bfa4ce");

		// Token: 0x0400026B RID: 619
		public static byte[] byte_2 = Class89.guid_1.ToByteArray();
	}
}
