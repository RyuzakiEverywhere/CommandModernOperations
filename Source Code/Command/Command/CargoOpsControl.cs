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
	// Token: 0x02000DAB RID: 3499
	[Attribute2]
	[DesignerGenerated]
	[Attribute3]
	[Attribute0]
	public sealed class CargoOpsControl : UserControl, IComponentConnector
	{
		// Token: 0x06005E28 RID: 24104 RVA: 0x0003CC1F File Offset: 0x0003AE1F
		public CargoOpsControl()
		{
			this.InitializeComponent();
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x003320FC File Offset: 0x003302FC
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/cargo/cargoopscontrol.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x0003CC2D File Offset: 0x0003AE2D
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x040036AB RID: 13995
		private bool bool_0;
	}
}
