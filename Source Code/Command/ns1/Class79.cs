using System;
using System.Runtime.CompilerServices;

namespace ns1
{
	// Token: 0x0200007B RID: 123
	internal sealed class Class79
	{
		// Token: 0x0600024A RID: 586 RVA: 0x00003FB5 File Offset: 0x000021B5
		[CompilerGenerated]
		private void method_0(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00003FBE File Offset: 0x000021BE
		[CompilerGenerated]
		public Class78 method_1()
		{
			return this.class78_0;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00003FC6 File Offset: 0x000021C6
		[CompilerGenerated]
		private void method_2(Class78 class78_1)
		{
			this.class78_0 = class78_1;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00003FCF File Offset: 0x000021CF
		public Class79(Class80 tle, string name = "")
		{
			this.method_2(new Class78(tle));
			if (name == "")
			{
				this.method_0(this.method_1().method_19());
				return;
			}
			this.method_0(name);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00004009 File Offset: 0x00002209
		public Class72 method_3(DateTime dateTime_0)
		{
			return this.method_1().method_23(dateTime_0);
		}

		// Token: 0x040001C8 RID: 456
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040001C9 RID: 457
		[CompilerGenerated]
		private Class78 class78_0;
	}
}
