using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns5;

namespace Command
{
	// Token: 0x02000DF7 RID: 3575
	[Attribute0]
	[Attribute2]
	[Attribute3]
	[DesignerGenerated]
	public sealed class HoverInfoMain : UserControl, INotifyPropertyChanged, IComponentConnector
	{
		// Token: 0x06006813 RID: 26643 RVA: 0x00042351 File Offset: 0x00040551
		public HoverInfoMain()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06006814 RID: 26644 RVA: 0x0004235F File Offset: 0x0004055F
		// (set) Token: 0x06006815 RID: 26645 RVA: 0x0004236C File Offset: 0x0004056C
		public HoverInfoViewModel VM
		{
			get
			{
				return (HoverInfoViewModel)base.DataContext;
			}
			set
			{
				if (this.VM == value)
				{
					return;
				}
				base.DataContext = value;
				this.vmethod_0("VM");
			}
		}

		// Token: 0x06006816 RID: 26646 RVA: 0x00389144 File Offset: 0x00387344
		public void method_0(Unit unit)
		{
			HoverInfoViewModel hoverInfoViewModel = new HoverInfoViewModel(this.MyContentControl, Class2413.smethod_2().method_41().vmethod_1000());
			hoverInfoViewModel.method_0(Client.smethod_42());
			this.VM = hoverInfoViewModel;
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06006817 RID: 26647 RVA: 0x0004238C File Offset: 0x0004058C
		// (set) Token: 0x06006818 RID: 26648 RVA: 0x00042394 File Offset: 0x00040594
		internal ContentControl MyContentControl
		{
			[CompilerGenerated]
			get
			{
				return this.contentControl_0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this.contentControl_0 == value)
				{
					return;
				}
				this.contentControl_0 = value;
				this.vmethod_0("MyContentControl");
			}
		}

		// Token: 0x06006819 RID: 26649 RVA: 0x00389180 File Offset: 0x00387380
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/hoverinfo/hoverinfomain.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x0600681A RID: 26650 RVA: 0x000423B4 File Offset: 0x000405B4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.MyContentControl = (ContentControl)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x0600681B RID: 26651 RVA: 0x003891B0 File Offset: 0x003873B0
		// (remove) Token: 0x0600681C RID: 26652 RVA: 0x003891E8 File Offset: 0x003873E8
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

		// Token: 0x0600681D RID: 26653 RVA: 0x00389220 File Offset: 0x00387420
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003B43 RID: 15171
		[CompilerGenerated]
		[AccessedThroughProperty("MyContentControl")]
		private ContentControl contentControl_0;

		// Token: 0x04003B44 RID: 15172
		private bool bool_0;

		// Token: 0x04003B45 RID: 15173
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
