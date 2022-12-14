using System;

namespace Command_Core
{
	// Token: 0x020001DE RID: 478
	public sealed class CargoTracker
	{
		// Token: 0x06000EC6 RID: 3782 RVA: 0x000099FD File Offset: 0x00007BFD
		public CargoTracker(Cargo cargo_1, int int_2, int int_3)
		{
			this.cargo_0 = cargo_1;
			this.int_0 = int_2;
			this.int_1 = int_3;
		}

		// Token: 0x040009AB RID: 2475
		public Cargo cargo_0;

		// Token: 0x040009AC RID: 2476
		public int int_0;

		// Token: 0x040009AD RID: 2477
		public int int_1;
	}
}
