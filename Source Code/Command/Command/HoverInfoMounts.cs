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
	// Token: 0x02000DE7 RID: 3559
	[Attribute2]
	[DesignerGenerated]
	[Attribute0]
	[Attribute3]
	public sealed class HoverInfoMounts : UserControl, IComponentConnector
	{
		// Token: 0x060066F5 RID: 26357 RVA: 0x0004121F File Offset: 0x0003F41F
		public HoverInfoMounts()
		{
			this.InitializeComponent();
		}

		// Token: 0x060066F6 RID: 26358 RVA: 0x00386E2C File Offset: 0x0038502C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfomounts.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060066F7 RID: 26359 RVA: 0x0004122D File Offset: 0x0003F42D
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003AAC RID: 15020
		private bool bool_0;
	}
}
