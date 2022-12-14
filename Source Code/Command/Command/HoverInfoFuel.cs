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
	// Token: 0x02000DDF RID: 3551
	[Attribute0]
	[Attribute2]
	[Attribute3]
	[DesignerGenerated]
	public sealed class HoverInfoFuel : UserControl, IComponentConnector
	{
		// Token: 0x060066DD RID: 26333 RVA: 0x00041167 File Offset: 0x0003F367
		public HoverInfoFuel()
		{
			this.InitializeComponent();
		}

		// Token: 0x060066DE RID: 26334 RVA: 0x00386CAC File Offset: 0x00384EAC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfofuel.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060066DF RID: 26335 RVA: 0x00041175 File Offset: 0x0003F375
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003AA4 RID: 15012
		private bool bool_0;
	}
}
