using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns3
{
	// Token: 0x0200009F RID: 159
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal sealed class Class95
	{
		// Token: 0x06000327 RID: 807 RVA: 0x00002977 File Offset: 0x00000B77
		internal Class95()
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00004BE3 File Offset: 0x00002DE3
		internal static ResourceManager smethod_0()
		{
			if (Class95.resourceManager_0 == null)
			{
				Class95.resourceManager_0 = new ResourceManager("CSMaterial.DarkUI.Icons.DockIcons", typeof(Class95).Assembly);
			}
			return Class95.resourceManager_0;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00004C0F File Offset: 0x00002E0F
		internal static Bitmap smethod_1()
		{
			return (Bitmap)Class95.smethod_0().GetObject("active_inactive_close", Class95.cultureInfo_0);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00004C2A File Offset: 0x00002E2A
		internal static Bitmap smethod_2()
		{
			return (Bitmap)Class95.smethod_0().GetObject("arrow", Class95.cultureInfo_0);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00004C45 File Offset: 0x00002E45
		internal static Bitmap smethod_3()
		{
			return (Bitmap)Class95.smethod_0().GetObject("close", Class95.cultureInfo_0);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00004C60 File Offset: 0x00002E60
		internal static Bitmap smethod_4()
		{
			return (Bitmap)Class95.smethod_0().GetObject("close_selected", Class95.cultureInfo_0);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00004C7B File Offset: 0x00002E7B
		internal static Bitmap smethod_5()
		{
			return (Bitmap)Class95.smethod_0().GetObject("inactive_close", Class95.cultureInfo_0);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00004C96 File Offset: 0x00002E96
		internal static Bitmap smethod_6()
		{
			return (Bitmap)Class95.smethod_0().GetObject("inactive_close_selected", Class95.cultureInfo_0);
		}

		// Token: 0x040002A9 RID: 681
		private static ResourceManager resourceManager_0;

		// Token: 0x040002AA RID: 682
		private static CultureInfo cultureInfo_0;
	}
}
