using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace Command
{
	// Token: 0x02000F50 RID: 3920
	[Attribute0]
	[DesignerGenerated]
	[Attribute3]
	[Attribute2]
	public sealed class CommandWPFResourceDictionary : ResourceDictionary, IComponentConnector
	{
		// Token: 0x06008C2E RID: 35886 RVA: 0x00053A62 File Offset: 0x00051C62
		public CommandWPFResourceDictionary()
		{
			this.InitializeComponent();
		}

		// Token: 0x06008C2F RID: 35887 RVA: 0x004B787C File Offset: 0x004B5A7C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/wpf/commandwpfresourcedictionary.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06008C30 RID: 35888 RVA: 0x00053A70 File Offset: 0x00051C70
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04004BF1 RID: 19441
		private bool bool_0;
	}
}
