using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns7;

namespace Command
{
	// Token: 0x02000D92 RID: 3474
	[Attribute2]
	[Attribute0]
	[DesignerGenerated]
	[Attribute3]
	public sealed class UnitEMCON_WPF : UserControl, INotifyPropertyChanged, IComponentConnector
	{
		// Token: 0x06005D07 RID: 23815 RVA: 0x0003BC42 File Offset: 0x00039E42
		public UnitEMCON_WPF()
		{
			this.InitializeComponent();
		}

		// Token: 0x06005D08 RID: 23816 RVA: 0x0032EABC File Offset: 0x0032CCBC
		public void method_0(ActiveUnit theUnit)
		{
			if (Information.IsNothing(theUnit))
			{
				base.IsEnabled = false;
				return;
			}
			base.IsEnabled = true;
			if (!theUnit.vmethod_90().vmethod_1() && !Class2558.smethod_17(theUnit) && !Client.smethod_52().method_1())
			{
				base.Visibility = Visibility.Collapsed;
				return;
			}
			base.Visibility = Visibility.Visible;
			if (base.DataContext == null)
			{
				base.DataContext = new UnitEMCONViewModel(theUnit);
				return;
			}
			UnitEMCONViewModel unitEMCONViewModel = (UnitEMCONViewModel)base.DataContext;
			if (unitEMCONViewModel.activeUnit_0 == theUnit)
			{
				unitEMCONViewModel.method_3();
				return;
			}
			unitEMCONViewModel.activeUnit_0 = theUnit;
			unitEMCONViewModel.method_3();
		}

		// Token: 0x06005D09 RID: 23817 RVA: 0x0032EB50 File Offset: 0x0032CD50
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/customcontrols/rightcolumn/unitemcon_wpf.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06005D0A RID: 23818 RVA: 0x0003BC50 File Offset: 0x00039E50
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06005D0B RID: 23819 RVA: 0x0032EB80 File Offset: 0x0032CD80
		// (remove) Token: 0x06005D0C RID: 23820 RVA: 0x0032EBB8 File Offset: 0x0032CDB8
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

		// Token: 0x06005D0D RID: 23821 RVA: 0x0032EBF0 File Offset: 0x0032CDF0
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003627 RID: 13863
		private bool bool_0;

		// Token: 0x04003628 RID: 13864
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
