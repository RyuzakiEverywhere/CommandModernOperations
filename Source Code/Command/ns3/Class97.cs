using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns3
{
	// Token: 0x020000A1 RID: 161
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal sealed class Class97
	{
		// Token: 0x06000333 RID: 819 RVA: 0x00002977 File Offset: 0x00000B77
		internal Class97()
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00004D13 File Offset: 0x00002F13
		internal static ResourceManager smethod_0()
		{
			if (Class97.resourceManager_0 == null)
			{
				Class97.resourceManager_0 = new ResourceManager("CSMaterial.DarkUI.Icons.MessageBoxIcons", typeof(Class97).Assembly);
			}
			return Class97.resourceManager_0;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00004D3F File Offset: 0x00002F3F
		internal static Bitmap smethod_1()
		{
			return (Bitmap)Class97.smethod_0().GetObject("error", Class97.cultureInfo_0);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00004D5A File Offset: 0x00002F5A
		internal static Bitmap smethod_2()
		{
			return (Bitmap)Class97.smethod_0().GetObject("info", Class97.cultureInfo_0);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00004D75 File Offset: 0x00002F75
		internal static Bitmap smethod_3()
		{
			return (Bitmap)Class97.smethod_0().GetObject("warning", Class97.cultureInfo_0);
		}

		// Token: 0x040002AD RID: 685
		private static ResourceManager resourceManager_0;

		// Token: 0x040002AE RID: 686
		private static CultureInfo cultureInfo_0;
	}
}
