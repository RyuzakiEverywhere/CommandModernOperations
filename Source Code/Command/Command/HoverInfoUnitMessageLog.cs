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
	// Token: 0x02000DE1 RID: 3553
	[Attribute2]
	[Attribute0]
	[DesignerGenerated]
	[Attribute3]
	public sealed class HoverInfoUnitMessageLog : UserControl, IComponentConnector
	{
		// Token: 0x060066E3 RID: 26339 RVA: 0x00041195 File Offset: 0x0003F395
		public HoverInfoUnitMessageLog()
		{
			this.InitializeComponent();
		}

		// Token: 0x060066E4 RID: 26340 RVA: 0x00386D0C File Offset: 0x00384F0C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfounitmessagelog.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060066E5 RID: 26341 RVA: 0x000411A3 File Offset: 0x0003F3A3
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003AA6 RID: 15014
		private bool bool_0;
	}
}
