using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace Command
{
	// Token: 0x02000D9E RID: 3486
	[Attribute3]
	[DesignerGenerated]
	[Attribute2]
	[Attribute0]
	public sealed class CargoMissionControl : UserControl, IComponentConnector
	{
		// Token: 0x06005DBA RID: 23994 RVA: 0x0003C58E File Offset: 0x0003A78E
		public CargoMissionControl()
		{
			this.InitializeComponent();
		}

		// Token: 0x06005DBB RID: 23995 RVA: 0x00330F60 File Offset: 0x0032F160
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/cargo/cargomissioncontrol.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06005DBC RID: 23996 RVA: 0x0003C59C File Offset: 0x0003A79C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003678 RID: 13944
		private bool bool_0;
	}
}
