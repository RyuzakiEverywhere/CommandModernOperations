using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace Command
{
	// Token: 0x02000DB6 RID: 3510
	[Attribute2]
	[Attribute3]
	[Attribute0]
	[DesignerGenerated]
	public sealed class EditCargoControl : UserControl, IComponentConnector
	{
		// Token: 0x06005EC7 RID: 24263 RVA: 0x0003D4A3 File Offset: 0x0003B6A3
		public EditCargoControl()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06005EC8 RID: 24264 RVA: 0x0003D4B1 File Offset: 0x0003B6B1
		// (set) Token: 0x06005EC9 RID: 24265 RVA: 0x0003D4B9 File Offset: 0x0003B6B9
		internal DataGrid MyDataGrid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06005ECA RID: 24266 RVA: 0x00333B64 File Offset: 0x00331D64
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/cargo/editcargocontrol.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06005ECB RID: 24267 RVA: 0x0003D4C2 File Offset: 0x0003B6C2
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.MyDataGrid = (DataGrid)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x040036FC RID: 14076
		[AccessedThroughProperty("MyDataGrid")]
		[CompilerGenerated]
		private DataGrid dataGrid_0;

		// Token: 0x040036FD RID: 14077
		private bool bool_0;
	}
}
