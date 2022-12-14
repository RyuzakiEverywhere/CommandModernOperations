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
	// Token: 0x02000DE3 RID: 3555
	[Attribute0]
	[Attribute2]
	[Attribute3]
	[DesignerGenerated]
	public sealed class HoverInfoParasites : UserControl, IComponentConnector
	{
		// Token: 0x060066E9 RID: 26345 RVA: 0x000411C3 File Offset: 0x0003F3C3
		public HoverInfoParasites()
		{
			this.InitializeComponent();
		}

		// Token: 0x060066EA RID: 26346 RVA: 0x00386D6C File Offset: 0x00384F6C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfoparasites.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060066EB RID: 26347 RVA: 0x000411D1 File Offset: 0x0003F3D1
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003AA8 RID: 15016
		private bool bool_0;
	}
}
