using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace DotSpatial.Serialization.Properties
{
	// Token: 0x02000BFB RID: 3067
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06004C1B RID: 19483 RVA: 0x00030209 File Offset: 0x0002E409
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		// Token: 0x04002FA0 RID: 12192
		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
