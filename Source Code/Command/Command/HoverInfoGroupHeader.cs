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
	// Token: 0x02000DE5 RID: 3557
	[Attribute3]
	[Attribute2]
	[DesignerGenerated]
	[Attribute0]
	public sealed class HoverInfoGroupHeader : UserControl, IComponentConnector
	{
		// Token: 0x060066EF RID: 26351 RVA: 0x000411F1 File Offset: 0x0003F3F1
		public HoverInfoGroupHeader()
		{
			this.InitializeComponent();
		}

		// Token: 0x060066F0 RID: 26352 RVA: 0x00386DCC File Offset: 0x00384FCC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfogroupheader.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060066F1 RID: 26353 RVA: 0x000411FF File Offset: 0x0003F3FF
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003AAA RID: 15018
		private bool bool_0;
	}
}
