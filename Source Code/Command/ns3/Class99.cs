using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns3
{
	// Token: 0x020000A3 RID: 163
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal sealed class Class99
	{
		// Token: 0x0600033E RID: 830 RVA: 0x00002977 File Offset: 0x00000B77
		internal Class99()
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00004E28 File Offset: 0x00003028
		internal static ResourceManager smethod_0()
		{
			if (Class99.resourceManager_0 == null)
			{
				Class99.resourceManager_0 = new ResourceManager("CSMaterial.DarkUI.Icons.TreeViewIcons", typeof(Class99).Assembly);
			}
			return Class99.resourceManager_0;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00004E54 File Offset: 0x00003054
		internal static Bitmap smethod_1()
		{
			return (Bitmap)Class99.smethod_0().GetObject("node_closed_empty", Class99.cultureInfo_0);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00004E6F File Offset: 0x0000306F
		internal static Bitmap smethod_2()
		{
			return (Bitmap)Class99.smethod_0().GetObject("node_closed_full", Class99.cultureInfo_0);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00004E8A File Offset: 0x0000308A
		internal static Bitmap smethod_3()
		{
			return (Bitmap)Class99.smethod_0().GetObject("node_open", Class99.cultureInfo_0);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00004EA5 File Offset: 0x000030A5
		internal static Bitmap smethod_4()
		{
			return (Bitmap)Class99.smethod_0().GetObject("node_open_empty", Class99.cultureInfo_0);
		}

		// Token: 0x040002B1 RID: 689
		private static ResourceManager resourceManager_0;

		// Token: 0x040002B2 RID: 690
		private static CultureInfo cultureInfo_0;
	}
}
