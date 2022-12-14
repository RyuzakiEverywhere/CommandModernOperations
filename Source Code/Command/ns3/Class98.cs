using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns3
{
	// Token: 0x020000A2 RID: 162
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal sealed class Class98
	{
		// Token: 0x06000338 RID: 824 RVA: 0x00002977 File Offset: 0x00000B77
		internal Class98()
		{
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00004D90 File Offset: 0x00002F90
		internal static ResourceManager smethod_0()
		{
			if (Class98.resourceManager_0 == null)
			{
				Class98.resourceManager_0 = new ResourceManager("CSMaterial.DarkUI.Icons.ScrollIcons", typeof(Class98).Assembly);
			}
			return Class98.resourceManager_0;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00004DBC File Offset: 0x00002FBC
		internal static Bitmap smethod_1()
		{
			return (Bitmap)Class98.smethod_0().GetObject("scrollbar_arrow_clicked", Class98.cultureInfo_0);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00004DD7 File Offset: 0x00002FD7
		internal static Bitmap smethod_2()
		{
			return (Bitmap)Class98.smethod_0().GetObject("scrollbar_arrow_disabled", Class98.cultureInfo_0);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00004DF2 File Offset: 0x00002FF2
		internal static Bitmap smethod_3()
		{
			return (Bitmap)Class98.smethod_0().GetObject("scrollbar_arrow_hot", Class98.cultureInfo_0);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00004E0D File Offset: 0x0000300D
		internal static Bitmap smethod_4()
		{
			return (Bitmap)Class98.smethod_0().GetObject("scrollbar_arrow_standard", Class98.cultureInfo_0);
		}

		// Token: 0x040002AF RID: 687
		private static ResourceManager resourceManager_0;

		// Token: 0x040002B0 RID: 688
		private static CultureInfo cultureInfo_0;
	}
}
