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
	// Token: 0x02000DF1 RID: 3569
	[DesignerGenerated]
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class HoverInfoActiveUnitHeader : UserControl, IComponentConnector
	{
		// Token: 0x060067DF RID: 26591 RVA: 0x00042051 File Offset: 0x00040251
		public HoverInfoActiveUnitHeader()
		{
			this.InitializeComponent();
		}

		// Token: 0x060067E0 RID: 26592 RVA: 0x00388DC8 File Offset: 0x00386FC8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfoactiveunitheader.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060067E1 RID: 26593 RVA: 0x0004205F File Offset: 0x0004025F
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003B2A RID: 15146
		private bool bool_0;
	}
}
