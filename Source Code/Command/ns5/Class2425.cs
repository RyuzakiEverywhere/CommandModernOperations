using System;
using System.Runtime.CompilerServices;
using Command;
using Command_Core;

namespace ns5
{
	// Token: 0x02000D7E RID: 3454
	internal sealed class Class2425
	{
		// Token: 0x06005BB3 RID: 23475 RVA: 0x0003AF7D File Offset: 0x0003917D
		public Class2425()
		{
			this.method_1(true);
			this.class2423_0 = new Class2423();
			this.class2424_0 = new Class2424();
		}

		// Token: 0x06005BB4 RID: 23476 RVA: 0x0003AFA2 File Offset: 0x000391A2
		[CompilerGenerated]
		public bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x06005BB5 RID: 23477 RVA: 0x0003AFAA File Offset: 0x000391AA
		[CompilerGenerated]
		public void method_1(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x06005BB6 RID: 23478 RVA: 0x0003AFB3 File Offset: 0x000391B3
		public void method_2(Scenario scenario_0, Side side_0, Unit unit_0, bool bool_1)
		{
			if (unit_0 != null)
			{
				Class2425.smethod_0();
			}
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x0003AFBD File Offset: 0x000391BD
		internal void method_3(Unit unit_0, Unit unit_1)
		{
			if (unit_0 != null)
			{
				Class2425.smethod_0();
			}
		}

		// Token: 0x06005BB8 RID: 23480 RVA: 0x0003AFC7 File Offset: 0x000391C7
		public static void smethod_0()
		{
			if (Client.smethod_50() != null && Client.smethod_54() != null)
			{
				((RightColumnWPF)Client.elementHost_0.Child).method_2(Client.smethod_46(), Client.smethod_50(), Client.smethod_54());
			}
		}

		// Token: 0x04003579 RID: 13689
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400357A RID: 13690
		public Class2423 class2423_0;

		// Token: 0x0400357B RID: 13691
		public Class2424 class2424_0;
	}
}
