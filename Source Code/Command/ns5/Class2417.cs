using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns5
{
	// Token: 0x02000D64 RID: 3428
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[StandardModule]
	[DebuggerNonUserCode]
	internal sealed class Class2417
	{
		// Token: 0x060059F4 RID: 23028 RVA: 0x0003A259 File Offset: 0x00038459
		internal static ResourceManager smethod_0()
		{
			if (object.ReferenceEquals(Class2417.resourceManager_0, null))
			{
				Class2417.resourceManager_0 = new ResourceManager("Command.Resources", typeof(Class2417).Assembly);
			}
			return Class2417.resourceManager_0;
		}

		// Token: 0x060059F5 RID: 23029 RVA: 0x0003A28B File Offset: 0x0003848B
		internal static Bitmap smethod_1()
		{
			return (Bitmap)RuntimeHelpers.GetObjectValue(Class2417.smethod_0().GetObject("CloudTop", Class2417.cultureInfo_0));
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x0003A2AB File Offset: 0x000384AB
		internal static Bitmap smethod_2()
		{
			return (Bitmap)RuntimeHelpers.GetObjectValue(Class2417.smethod_0().GetObject("GroudLevel", Class2417.cultureInfo_0));
		}

		// Token: 0x060059F7 RID: 23031 RVA: 0x0003A2CB File Offset: 0x000384CB
		internal static Bitmap smethod_3()
		{
			return (Bitmap)RuntimeHelpers.GetObjectValue(Class2417.smethod_0().GetObject("LayerBottom", Class2417.cultureInfo_0));
		}

		// Token: 0x060059F8 RID: 23032 RVA: 0x0003A2EB File Offset: 0x000384EB
		internal static Bitmap smethod_4()
		{
			return (Bitmap)RuntimeHelpers.GetObjectValue(Class2417.smethod_0().GetObject("LayerTop", Class2417.cultureInfo_0));
		}

		// Token: 0x060059F9 RID: 23033 RVA: 0x0003A30B File Offset: 0x0003850B
		internal static Bitmap smethod_5()
		{
			return (Bitmap)RuntimeHelpers.GetObjectValue(Class2417.smethod_0().GetObject("No", Class2417.cultureInfo_0));
		}

		// Token: 0x060059FA RID: 23034 RVA: 0x0003A32B File Offset: 0x0003852B
		internal static Bitmap smethod_6()
		{
			return (Bitmap)RuntimeHelpers.GetObjectValue(Class2417.smethod_0().GetObject("SeaFloor", Class2417.cultureInfo_0));
		}

		// Token: 0x060059FB RID: 23035 RVA: 0x0003A34B File Offset: 0x0003854B
		internal static Bitmap smethod_7()
		{
			return (Bitmap)RuntimeHelpers.GetObjectValue(Class2417.smethod_0().GetObject("Yes", Class2417.cultureInfo_0));
		}

		// Token: 0x0400346A RID: 13418
		private static ResourceManager resourceManager_0;

		// Token: 0x0400346B RID: 13419
		private static CultureInfo cultureInfo_0;
	}
}
