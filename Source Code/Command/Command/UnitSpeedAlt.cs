using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns5;

namespace Command
{
	// Token: 0x02000D96 RID: 3478
	[Attribute0]
	[Attribute2]
	[DesignerGenerated]
	[Attribute3]
	public sealed class UnitSpeedAlt : UserControl, INotifyPropertyChanged, IComponentConnector
	{
		// Token: 0x06005D50 RID: 23888 RVA: 0x0003C0D9 File Offset: 0x0003A2D9
		public UnitSpeedAlt()
		{
			this.InitializeComponent();
		}

		// Token: 0x06005D51 RID: 23889 RVA: 0x0003C0E7 File Offset: 0x0003A2E7
		public void method_0()
		{
			if (base.DataContext != null)
			{
				((UnitSpeedAltViewModel)base.DataContext).Visible = Visibility.Collapsed;
				return;
			}
			base.DataContext = new UnitSpeedAltViewModel();
			((UnitSpeedAltViewModel)base.DataContext).Visible = Visibility.Collapsed;
		}

		// Token: 0x06005D52 RID: 23890 RVA: 0x0032F230 File Offset: 0x0032D430
		public void method_1(bool TriggeredBySpeedAltForm)
		{
			if (base.DataContext != null)
			{
				UnitSpeedAltViewModel unitSpeedAltViewModel = (UnitSpeedAltViewModel)base.DataContext;
				unitSpeedAltViewModel.method_4(TriggeredBySpeedAltForm);
			}
			else
			{
				UnitSpeedAltViewModel unitSpeedAltViewModel = new UnitSpeedAltViewModel();
				unitSpeedAltViewModel.method_4(TriggeredBySpeedAltForm);
				base.DataContext = unitSpeedAltViewModel;
			}
			if (!Class2413.smethod_2().method_41().rightColumnWPF_0.vmethod_12().IsExpanded)
			{
				Class2413.smethod_2().method_41().rightColumnWPF_0.vmethod_12().IsExpanded = true;
				Class2413.smethod_2().method_41().rightColumnWPF_0.vmethod_12().IsExpanded = false;
				return;
			}
			Class2413.smethod_2().method_41().rightColumnWPF_0.vmethod_12().IsExpanded = false;
			Class2413.smethod_2().method_41().rightColumnWPF_0.vmethod_12().IsExpanded = true;
		}

		// Token: 0x06005D53 RID: 23891 RVA: 0x0032F2F4 File Offset: 0x0032D4F4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/customcontrols/rightcolumn/unitspeedalt.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06005D54 RID: 23892 RVA: 0x0003C11F File Offset: 0x0003A31F
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06005D55 RID: 23893 RVA: 0x0032F324 File Offset: 0x0032D524
		// (remove) Token: 0x06005D56 RID: 23894 RVA: 0x0032F35C File Offset: 0x0032D55C
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

		// Token: 0x06005D57 RID: 23895 RVA: 0x0032F394 File Offset: 0x0032D594
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003645 RID: 13893
		private bool bool_0;

		// Token: 0x04003646 RID: 13894
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
