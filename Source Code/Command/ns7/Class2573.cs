using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;

namespace ns7
{
	// Token: 0x02000F59 RID: 3929
	[DesignerGenerated]
	internal sealed class Class2573 : ResourceDictionary, IComponentConnector
	{
		// Token: 0x06008C63 RID: 35939 RVA: 0x00053C68 File Offset: 0x00051E68
		public Class2573()
		{
			this.InitializeComponent();
		}

		// Token: 0x06008C64 RID: 35940 RVA: 0x004B8E74 File Offset: 0x004B7074
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/resources/icons.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06008C65 RID: 35941 RVA: 0x00053C76 File Offset: 0x00051E76
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04004C10 RID: 19472
		private bool bool_0;
	}
}
