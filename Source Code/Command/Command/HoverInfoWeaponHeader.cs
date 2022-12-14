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
	// Token: 0x02000DE2 RID: 3554
	[Attribute3]
	[Attribute2]
	[Attribute0]
	[DesignerGenerated]
	public sealed class HoverInfoWeaponHeader : UserControl, IComponentConnector
	{
		// Token: 0x060066E6 RID: 26342 RVA: 0x000411AC File Offset: 0x0003F3AC
		public HoverInfoWeaponHeader()
		{
			this.InitializeComponent();
		}

		// Token: 0x060066E7 RID: 26343 RVA: 0x00386D3C File Offset: 0x00384F3C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfoweaponheader.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060066E8 RID: 26344 RVA: 0x000411BA File Offset: 0x0003F3BA
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003AA7 RID: 15015
		private bool bool_0;
	}
}
