using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns3
{
	// Token: 0x020000A0 RID: 160
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal sealed class Class96
	{
		// Token: 0x0600032F RID: 815 RVA: 0x00002977 File Offset: 0x00000B77
		internal Class96()
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00004CB1 File Offset: 0x00002EB1
		public static ResourceManager smethod_0()
		{
			if (Class96.resourceManager_0 == null)
			{
				Class96.resourceManager_0 = new ResourceManager("CSMaterial.DarkUI.Icons.MenuIcons", typeof(Class96).Assembly);
			}
			return Class96.resourceManager_0;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00004CDD File Offset: 0x00002EDD
		public static Bitmap smethod_1()
		{
			return (Bitmap)Class96.smethod_0().GetObject("grip", Class96.cultureInfo_0);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00004CF8 File Offset: 0x00002EF8
		public static Bitmap smethod_2()
		{
			return (Bitmap)Class96.smethod_0().GetObject("tick", Class96.cultureInfo_0);
		}

		// Token: 0x040002AB RID: 683
		private static ResourceManager resourceManager_0;

		// Token: 0x040002AC RID: 684
		private static CultureInfo cultureInfo_0;
	}
}
