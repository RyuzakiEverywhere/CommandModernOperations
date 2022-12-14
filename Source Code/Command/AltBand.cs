using System;

namespace Command_Core
{
	// Token: 0x020001AF RID: 431
	public sealed class AltBand
	{
		// Token: 0x06000D8A RID: 3466 RVA: 0x0010F5CC File Offset: 0x0010D7CC
		public int method_0()
		{
			int result;
			if (this.nullable_1 != null)
			{
				result = (int)this.nullable_1.Value;
			}
			else if (this.nullable_0 != null)
			{
				result = (int)this.nullable_0.Value;
			}
			else
			{
				result = this.int_1;
			}
			return result;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00002977 File Offset: 0x00000B77
		private AltBand()
		{
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00009251 File Offset: 0x00007451
		public AltBand(float float_4, float float_5)
		{
			this.float_0 = float_4;
			this.float_1 = float_5;
		}

		// Token: 0x040008B9 RID: 2233
		public float float_0;

		// Token: 0x040008BA RID: 2234
		public float float_1;

		// Token: 0x040008BB RID: 2235
		public int int_0;

		// Token: 0x040008BC RID: 2236
		public int int_1;

		// Token: 0x040008BD RID: 2237
		public long? nullable_0;

		// Token: 0x040008BE RID: 2238
		public long? nullable_1;

		// Token: 0x040008BF RID: 2239
		public float float_2;

		// Token: 0x040008C0 RID: 2240
		public float float_3;

		// Token: 0x040008C1 RID: 2241
		public float? nullable_2;

		// Token: 0x040008C2 RID: 2242
		public float? nullable_3;
	}
}
