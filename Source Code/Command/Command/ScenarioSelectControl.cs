using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace Command
{
	// Token: 0x02000E2D RID: 3629
	[Attribute0]
	[Attribute3]
	[DesignerGenerated]
	[Attribute2]
	public sealed class ScenarioSelectControl : UserControl, INotifyPropertyChanged, IComponentConnector
	{
		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06006CA8 RID: 27816 RVA: 0x0004465B File Offset: 0x0004285B
		public ScenarioSelectControlViewModel VM
		{
			get
			{
				return (ScenarioSelectControlViewModel)base.DataContext;
			}
		}

		// Token: 0x06006CA9 RID: 27817 RVA: 0x00044668 File Offset: 0x00042868
		public ScenarioSelectControl()
		{
			this.InitializeComponent();
			base.DataContext = new ScenarioSelectControlViewModel();
		}

		// Token: 0x06006CAA RID: 27818 RVA: 0x00044681 File Offset: 0x00042881
		private void ScenarioSelectControl_OnLoaded(object sender, RoutedEventArgs e)
		{
			this.VM.method_0();
		}

		// Token: 0x06006CAB RID: 27819 RVA: 0x003B9950 File Offset: 0x003B7B50
		private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(e.AddedItems[0]);
			if (objectValue != null)
			{
				((SteamScenarioViewModel)objectValue).method_0();
			}
		}

		// Token: 0x06006CAC RID: 27820 RVA: 0x003B9980 File Offset: 0x003B7B80
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/scenario/scenarioselectcontrol.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x003B99B0 File Offset: 0x003B7BB0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((ScenarioSelectControl)target).Loaded += this.ScenarioSelectControl_OnLoaded;
				return;
			}
			if (connectionId == 2)
			{
				((ListBox)target).SelectionChanged += this.Selector_OnSelectionChanged;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x06006CAE RID: 27822 RVA: 0x003B99FC File Offset: 0x003B7BFC
		// (remove) Token: 0x06006CAF RID: 27823 RVA: 0x003B9A34 File Offset: 0x003B7C34
		public event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x06006CB0 RID: 27824 RVA: 0x003B9A6C File Offset: 0x003B7C6C
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003E00 RID: 15872
		private bool bool_0;

		// Token: 0x04003E01 RID: 15873
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
