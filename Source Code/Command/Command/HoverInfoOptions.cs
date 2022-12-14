using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using Xceed.Wpf.Toolkit.PropertyGrid;

namespace Command
{
	// Token: 0x02000DDE RID: 3550
	[DesignerGenerated]
	[Attribute3]
	[Attribute0]
	[Attribute2]
	public sealed class HoverInfoOptions : UserControl, IComponentConnector
	{
		// Token: 0x060066D8 RID: 26328 RVA: 0x0004112A File Offset: 0x0003F32A
		public HoverInfoOptions()
		{
			this.InitializeComponent();
		}

		// Token: 0x060066D9 RID: 26329 RVA: 0x00041138 File Offset: 0x0003F338
		private void HoverInfoOptions_OnLoaded(object sender, RoutedEventArgs e)
		{
			if (base.DataContext == null)
			{
				base.DataContext = HoverInfoOptionsViewModel.Singleton;
			}
		}

		// Token: 0x060066DA RID: 26330 RVA: 0x0004114D File Offset: 0x0003F34D
		private void PropertyGrid_OnPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (base.DataContext != null)
			{
				((HoverInfoOptionsViewModel)base.DataContext).Save();
			}
		}

		// Token: 0x060066DB RID: 26331 RVA: 0x00386C30 File Offset: 0x00384E30
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfooptions.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060066DC RID: 26332 RVA: 0x00386C60 File Offset: 0x00384E60
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((HoverInfoOptions)target).Loaded += this.HoverInfoOptions_OnLoaded;
				return;
			}
			if (connectionId == 2)
			{
				((PropertyGrid)target).PropertyChanged += new PropertyChangedEventHandler(this.PropertyGrid_OnPropertyChanged);
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04003AA3 RID: 15011
		private bool bool_0;
	}
}
