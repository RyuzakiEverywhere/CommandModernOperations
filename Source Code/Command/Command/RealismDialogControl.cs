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
	// Token: 0x02000E34 RID: 3636
	[Attribute0]
	[Attribute2]
	[Attribute3]
	[DesignerGenerated]
	public sealed class RealismDialogControl : UserControl, IComponentConnector
	{
		// Token: 0x06006D17 RID: 27927 RVA: 0x000449F8 File Offset: 0x00042BF8
		public RealismDialogControl()
		{
			this.InitializeComponent();
		}

		// Token: 0x06006D18 RID: 27928 RVA: 0x003BB8CC File Offset: 0x003B9ACC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/scenario/realismdialog/realismdialogcontrol.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006D19 RID: 27929 RVA: 0x00044A06 File Offset: 0x00042C06
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003E30 RID: 15920
		private bool bool_0;
	}
}
