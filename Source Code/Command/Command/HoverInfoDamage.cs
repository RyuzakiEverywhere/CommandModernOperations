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
	// Token: 0x02000DD9 RID: 3545
	[DesignerGenerated]
	[Attribute0]
	[Attribute3]
	[Attribute2]
	public sealed class HoverInfoDamage : UserControl, IComponentConnector
	{
		// Token: 0x060066B3 RID: 26291 RVA: 0x00040F2B File Offset: 0x0003F12B
		public HoverInfoDamage()
		{
			this.InitializeComponent();
		}

		// Token: 0x060066B4 RID: 26292 RVA: 0x0038688C File Offset: 0x00384A8C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfodamage.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x00040F39 File Offset: 0x0003F139
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003A8D RID: 14989
		private bool bool_0;
	}
}
