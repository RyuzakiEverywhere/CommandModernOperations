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
	// Token: 0x02000DE4 RID: 3556
	[Attribute0]
	[Attribute2]
	[Attribute3]
	[DesignerGenerated]
	public sealed class HoverInfoContactHeader : UserControl, IComponentConnector
	{
		// Token: 0x060066EC RID: 26348 RVA: 0x000411DA File Offset: 0x0003F3DA
		public HoverInfoContactHeader()
		{
			this.InitializeComponent();
		}

		// Token: 0x060066ED RID: 26349 RVA: 0x00386D9C File Offset: 0x00384F9C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfocontactheader.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060066EE RID: 26350 RVA: 0x000411E8 File Offset: 0x0003F3E8
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003AA9 RID: 15017
		private bool bool_0;
	}
}
