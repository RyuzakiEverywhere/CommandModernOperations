using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using ns5;

namespace Command.My
{
	// Token: 0x02000D65 RID: 3429
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x060059FE RID: 23038 RVA: 0x0003A390 File Offset: 0x00038590
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void smethod_0(object sender, EventArgs e)
		{
			if (Class2413.smethod_1().SaveMySettingsOnExit)
			{
				Class2418.smethod_0().Save();
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060059FF RID: 23039 RVA: 0x003168D8 File Offset: 0x00314AD8
		public static MySettings Default
		{
			get
			{
				if (!MySettings.bool_0)
				{
					object obj = MySettings.object_0;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.bool_0)
						{
							Class2413.smethod_1().Shutdown += MySettings.smethod_0;
							MySettings.bool_0 = true;
						}
					}
				}
				return MySettings.mySettings_0;
			}
		}

		// Token: 0x0400346C RID: 13420
		private static MySettings mySettings_0 = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x0400346D RID: 13421
		private static bool bool_0;

		// Token: 0x0400346E RID: 13422
		private static object object_0 = RuntimeHelpers.GetObjectValue(new object());
	}
}
