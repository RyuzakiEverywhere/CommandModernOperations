using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;

namespace Command
{
	// Token: 0x02000E43 RID: 3651
	[DesignerGenerated]
	public sealed class TimeOnTargetControl : UserControl, IComponentConnector
	{
		// Token: 0x06006DD3 RID: 28115 RVA: 0x0004531A File Offset: 0x0004351A
		public TimeOnTargetControl()
		{
			this.InitializeComponent();
		}

		// Token: 0x06006DD4 RID: 28116 RVA: 0x003BCED0 File Offset: 0x003BB0D0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/tot/timeontargetcontrol.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006DD5 RID: 28117 RVA: 0x00045328 File Offset: 0x00043528
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003E80 RID: 16000
		private bool bool_0;
	}
}
