using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;

namespace Command
{
	// Token: 0x02000E42 RID: 3650
	[DesignerGenerated]
	public sealed class TimeOnTargetWindow : Window, IComponentConnector
	{
		// Token: 0x06006DD0 RID: 28112 RVA: 0x00045303 File Offset: 0x00043503
		public TimeOnTargetWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x06006DD1 RID: 28113 RVA: 0x003BCEA0 File Offset: 0x003BB0A0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/tot/timeontargetwindow.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006DD2 RID: 28114 RVA: 0x00045311 File Offset: 0x00043511
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003E7F RID: 15999
		private bool bool_0;
	}
}
