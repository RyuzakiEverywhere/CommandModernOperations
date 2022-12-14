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
	// Token: 0x02000DE6 RID: 3558
	[DesignerGenerated]
	[Attribute2]
	[Attribute0]
	[Attribute3]
	public sealed class HoverInfoMission : UserControl, IComponentConnector
	{
		// Token: 0x060066F2 RID: 26354 RVA: 0x00041208 File Offset: 0x0003F408
		public HoverInfoMission()
		{
			this.InitializeComponent();
		}

		// Token: 0x060066F3 RID: 26355 RVA: 0x00386DFC File Offset: 0x00384FFC
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfomission.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060066F4 RID: 26356 RVA: 0x00041216 File Offset: 0x0003F416
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003AAB RID: 15019
		private bool bool_0;
	}
}
