using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;

namespace Command
{
	// Token: 0x02000DFD RID: 3581
	[DesignerGenerated]
	public sealed class MapCursorDatabox : Window, IComponentConnector
	{
		// Token: 0x06006876 RID: 26742 RVA: 0x00042686 File Offset: 0x00040886
		public MapCursorDatabox()
		{
			this.InitializeComponent();
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x00042694 File Offset: 0x00040894
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_0(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x00389FAC File Offset: 0x003881AC
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/mapcursordatabox.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x0004269D File Offset: 0x0004089D
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.vmethod_0((Label)target);
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04003B64 RID: 15204
		[AccessedThroughProperty("TextLabel")]
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04003B65 RID: 15205
		private bool bool_0;
	}
}
