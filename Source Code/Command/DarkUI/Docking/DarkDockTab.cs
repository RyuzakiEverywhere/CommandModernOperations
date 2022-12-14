using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace DarkUI.Docking
{
	// Token: 0x020000B9 RID: 185
	internal sealed class DarkDockTab
	{
		// Token: 0x060003F2 RID: 1010 RVA: 0x0000548D File Offset: 0x0000368D
		[CompilerGenerated]
		public DarkDockContent method_0()
		{
			return this.darkDockContent_0;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00005495 File Offset: 0x00003695
		[CompilerGenerated]
		public void method_1(DarkDockContent darkDockContent_1)
		{
			this.darkDockContent_0 = darkDockContent_1;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000549E File Offset: 0x0000369E
		[CompilerGenerated]
		public Rectangle method_2()
		{
			return this.rectangle_0;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000054A6 File Offset: 0x000036A6
		[CompilerGenerated]
		public void method_3(Rectangle rectangle_2)
		{
			this.rectangle_0 = rectangle_2;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000054AF File Offset: 0x000036AF
		[CompilerGenerated]
		public Rectangle method_4()
		{
			return this.rectangle_1;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000054B7 File Offset: 0x000036B7
		[CompilerGenerated]
		public void method_5(Rectangle rectangle_2)
		{
			this.rectangle_1 = rectangle_2;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000054C0 File Offset: 0x000036C0
		[CompilerGenerated]
		public bool method_6()
		{
			return this.bool_0;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000054C8 File Offset: 0x000036C8
		[CompilerGenerated]
		public void method_7(bool bool_3)
		{
			this.bool_0 = bool_3;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000054D1 File Offset: 0x000036D1
		[CompilerGenerated]
		public bool method_8()
		{
			return this.bool_1;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000054D9 File Offset: 0x000036D9
		[CompilerGenerated]
		public void method_9(bool bool_3)
		{
			this.bool_1 = bool_3;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000054E2 File Offset: 0x000036E2
		[CompilerGenerated]
		public bool method_10()
		{
			return this.bool_2;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000054EA File Offset: 0x000036EA
		[CompilerGenerated]
		public void method_11(bool bool_3)
		{
			this.bool_2 = bool_3;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000054F3 File Offset: 0x000036F3
		public DarkDockTab(DarkDockContent darkDockContent_1)
		{
			this.method_1(darkDockContent_1);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00065914 File Offset: 0x00063B14
		public int method_12(Graphics graphics_0, Font font_0)
		{
			return (int)graphics_0.MeasureString(this.method_0().method_2(), font_0).Width + 10;
		}

		// Token: 0x0400031B RID: 795
		[CompilerGenerated]
		private DarkDockContent darkDockContent_0;

		// Token: 0x0400031C RID: 796
		[CompilerGenerated]
		private Rectangle rectangle_0;

		// Token: 0x0400031D RID: 797
		[CompilerGenerated]
		private Rectangle rectangle_1;

		// Token: 0x0400031E RID: 798
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400031F RID: 799
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000320 RID: 800
		[CompilerGenerated]
		private bool bool_2;
	}
}
