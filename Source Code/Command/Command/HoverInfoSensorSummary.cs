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
	// Token: 0x02000DE8 RID: 3560
	[Attribute0]
	[Attribute2]
	[Attribute3]
	[DesignerGenerated]
	public sealed class HoverInfoSensorSummary : UserControl, IComponentConnector
	{
		// Token: 0x060066F8 RID: 26360 RVA: 0x00041236 File Offset: 0x0003F436
		public HoverInfoSensorSummary()
		{
			this.InitializeComponent();
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x00386E5C File Offset: 0x0038505C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfosensorsummary.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060066FA RID: 26362 RVA: 0x00041244 File Offset: 0x0003F444
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003AAD RID: 15021
		private bool bool_0;
	}
}
