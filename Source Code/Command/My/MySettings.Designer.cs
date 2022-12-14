using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Command_Core.My
{
	// Token: 0x0200011B RID: 283
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00006E82 File Offset: 0x00005082
		public static MySettings Default
		{
			get
			{
				return MySettings.mySettings_0;
			}
		}

		// Token: 0x040004D4 RID: 1236
		private static MySettings mySettings_0 = (MySettings)SettingsBase.Synchronized(new MySettings());
	}
}
