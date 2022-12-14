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
	// Token: 0x02000DF2 RID: 3570
	[DesignerGenerated]
	[Attribute2]
	[Attribute0]
	[Attribute3]
	public sealed class HoverInfoSensors : UserControl, IComponentConnector
	{
		// Token: 0x060067E2 RID: 26594 RVA: 0x00042068 File Offset: 0x00040268
		public HoverInfoSensors()
		{
			this.InitializeComponent();
		}

		// Token: 0x060067E3 RID: 26595 RVA: 0x00388DF8 File Offset: 0x00386FF8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfosensors.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x00042076 File Offset: 0x00040276
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_0(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x00042080 File Offset: 0x00040280
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04003B2B RID: 15147
		private bool bool_0;
	}
}
