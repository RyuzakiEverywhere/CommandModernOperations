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
	// Token: 0x02000DE0 RID: 3552
	[Attribute0]
	[Attribute2]
	[Attribute3]
	[DesignerGenerated]
	public sealed class HoverInfoCargo : UserControl, IComponentConnector
	{
		// Token: 0x060066E0 RID: 26336 RVA: 0x0004117E File Offset: 0x0003F37E
		public HoverInfoCargo()
		{
			this.InitializeComponent();
		}

		// Token: 0x060066E1 RID: 26337 RVA: 0x00386CDC File Offset: 0x00384EDC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfocargo.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060066E2 RID: 26338 RVA: 0x0004118C File Offset: 0x0003F38C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003AA5 RID: 15013
		private bool bool_0;
	}
}
