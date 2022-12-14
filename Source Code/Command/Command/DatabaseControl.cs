using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Navigation;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace Command
{
	// Token: 0x02000DD3 RID: 3539
	[DesignerGenerated]
	[Attribute2]
	[Attribute3]
	[Attribute0]
	public sealed class DatabaseControl : UserControl, INotifyPropertyChanged, IComponentConnector
	{
		// Token: 0x0600666E RID: 26222 RVA: 0x00040C8D File Offset: 0x0003EE8D
		public DatabaseControl()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600666F RID: 26223 RVA: 0x0000378C File Offset: 0x0000198C
		private void WebBrowser1_Navigated(object sender, NavigationEventArgs e)
		{
		}

		// Token: 0x06006670 RID: 26224 RVA: 0x0000378C File Offset: 0x0000198C
		private void WebBrowser1_Navigating(object sender, NavigatingCancelEventArgs e)
		{
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06006671 RID: 26225 RVA: 0x00040C9B File Offset: 0x0003EE9B
		// (set) Token: 0x06006672 RID: 26226 RVA: 0x00385BE4 File Offset: 0x00383DE4
		public WebBrowser WebBrowser1
		{
			[CompilerGenerated]
			get
			{
				return this.webBrowser_0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this.webBrowser_0 == value)
				{
					return;
				}
				NavigatedEventHandler value2 = new NavigatedEventHandler(this.WebBrowser1_Navigated);
				NavigatingCancelEventHandler value3 = new NavigatingCancelEventHandler(this.WebBrowser1_Navigating);
				WebBrowser webBrowser = this.webBrowser_0;
				if (webBrowser != null)
				{
					webBrowser.Navigated -= value2;
					webBrowser.Navigating -= value3;
				}
				this.webBrowser_0 = value;
				this.vmethod_0("WebBrowser1");
				webBrowser = this.webBrowser_0;
				if (webBrowser != null)
				{
					webBrowser.Navigated += value2;
					webBrowser.Navigating += value3;
				}
			}
		}

		// Token: 0x06006673 RID: 26227 RVA: 0x00385C5C File Offset: 0x00383E5C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/dbviewer/databasecontrol.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006674 RID: 26228 RVA: 0x00040CA3 File Offset: 0x0003EEA3
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.WebBrowser1 = (WebBrowser)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06006675 RID: 26229 RVA: 0x00385C8C File Offset: 0x00383E8C
		// (remove) Token: 0x06006676 RID: 26230 RVA: 0x00385CC4 File Offset: 0x00383EC4
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

		// Token: 0x06006677 RID: 26231 RVA: 0x00385CFC File Offset: 0x00383EFC
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003A6D RID: 14957
		[CompilerGenerated]
		[AccessedThroughProperty("WebBrowser1")]
		private WebBrowser webBrowser_0;

		// Token: 0x04003A6E RID: 14958
		private bool bool_0;

		// Token: 0x04003A6F RID: 14959
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
