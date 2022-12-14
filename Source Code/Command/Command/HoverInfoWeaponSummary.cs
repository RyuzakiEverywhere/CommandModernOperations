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
	// Token: 0x02000DF4 RID: 3572
	[Attribute0]
	[Attribute3]
	[Attribute2]
	[DesignerGenerated]
	public sealed class HoverInfoWeaponSummary : UserControl, IComponentConnector
	{
		// Token: 0x060067EA RID: 26602 RVA: 0x000420A0 File Offset: 0x000402A0
		public HoverInfoWeaponSummary()
		{
			this.InitializeComponent();
		}

		// Token: 0x060067EB RID: 26603 RVA: 0x00388E58 File Offset: 0x00387058
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfoweaponsummary.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060067EC RID: 26604 RVA: 0x000420AE File Offset: 0x000402AE
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003B2D RID: 15149
		private bool bool_0;
	}
}
