using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;
using ns5;

namespace Command
{
	// Token: 0x02000E3A RID: 3642
	[DesignerGenerated]
	public sealed class TerrainTypeLegendWindow : Window, IComponentConnector
	{
		// Token: 0x06006D5E RID: 27998 RVA: 0x00044C7D File Offset: 0x00042E7D
		public TerrainTypeLegendWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x00042970 File Offset: 0x00040B70
		private void TerrainTypeLegendWindow_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			base.DragMove();
		}

		// Token: 0x06006D60 RID: 28000 RVA: 0x000427F9 File Offset: 0x000409F9
		private void TerrainTypeLegendWindow_OnLoaded(object sender, RoutedEventArgs e)
		{
			new WindowInteropHelper(this).Owner = Class2413.smethod_2().method_41().Handle;
		}

		// Token: 0x06006D61 RID: 28001 RVA: 0x003BC2B8 File Offset: 0x003BA4B8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/scenario/terraintypelegendwindow.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006D62 RID: 28002 RVA: 0x00044C8B File Offset: 0x00042E8B
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((TerrainTypeLegendWindow)target).MouseLeftButtonDown += this.TerrainTypeLegendWindow_OnMouseLeftButtonDown;
				((TerrainTypeLegendWindow)target).Loaded += this.TerrainTypeLegendWindow_OnLoaded;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04003E4B RID: 15947
		private bool bool_0;
	}
}
