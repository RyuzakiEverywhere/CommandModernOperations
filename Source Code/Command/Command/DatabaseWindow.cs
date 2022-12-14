using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Threading;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns5;

namespace Command
{
	// Token: 0x02000DD4 RID: 3540
	[Attribute0]
	[Attribute2]
	[Attribute3]
	[DesignerGenerated]
	public sealed class DatabaseWindow : Window, INotifyPropertyChanged, IComponentConnector
	{
		// Token: 0x06006679 RID: 26233 RVA: 0x00040CD8 File Offset: 0x0003EED8
		public DatabaseWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x00385D24 File Offset: 0x00383F24
		public static void smethod_0(string SelectedObjectType, int selectedObjectID, string HighlightTarget = null)
		{
			object obj = DatabaseWindow.object_0;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			lock (obj)
			{
				DatabaseWindow.string_0 = SelectedObjectType;
				DatabaseWindow.int_0 = selectedObjectID;
				DatabaseWindow.string_1 = HighlightTarget;
				DatabaseWindow.int_1 = (int)Class2413.smethod_2().method_41().Handle;
				Thread thread = new Thread(new ThreadStart(DatabaseWindow.smethod_1));
				DatabaseWindow.list_0.Add(thread);
				thread.Name = "Database Viewer Thread";
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
			}
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x00385DC4 File Offset: 0x00383FC4
		private static void smethod_1()
		{
			object obj = DatabaseWindow.object_0;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			DatabaseControlViewModel databaseControlViewModel;
			lock (obj)
			{
				databaseControlViewModel = new DatabaseControlViewModel();
				databaseControlViewModel.SelectedObjectType = DatabaseWindow.string_0;
				databaseControlViewModel.SelectedObjectID = DatabaseWindow.int_0;
				databaseControlViewModel.HighlightTarget = DatabaseWindow.string_1;
			}
			DatabaseWindow databaseWindow = new DatabaseWindow();
			new WindowInteropHelper(databaseWindow).Owner = (IntPtr)DatabaseWindow.int_1;
			databaseWindow.thread_0 = Thread.CurrentThread;
			databaseWindow.DatabaseControl1.DataContext = databaseControlViewModel;
			databaseWindow.DataContext = databaseControlViewModel;
			databaseControlViewModel.DatabaseControl = databaseWindow.DatabaseControl1;
			databaseControlViewModel.method_0();
			databaseWindow.Show();
			databaseWindow.dispatcher_0 = Dispatcher.CurrentDispatcher;
			Dispatcher.Run();
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x00040CE6 File Offset: 0x0003EEE6
		private void DatabaseWindow_OnClosed(object sender, EventArgs e)
		{
			this.dispatcher_0.InvokeShutdown();
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x0600667D RID: 26237 RVA: 0x00040CF3 File Offset: 0x0003EEF3
		// (set) Token: 0x0600667E RID: 26238 RVA: 0x00040CFB File Offset: 0x0003EEFB
		internal DatabaseControl DatabaseControl1
		{
			[CompilerGenerated]
			get
			{
				return this.databaseControl_0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this.databaseControl_0 == value)
				{
					return;
				}
				this.databaseControl_0 = value;
				this.vmethod_0("DatabaseControl1");
			}
		}

		// Token: 0x0600667F RID: 26239 RVA: 0x00385E8C File Offset: 0x0038408C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/dbviewer/databasewindow.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006680 RID: 26240 RVA: 0x00040D1B File Offset: 0x0003EF1B
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((DatabaseWindow)target).Closed += this.DatabaseWindow_OnClosed;
				return;
			}
			if (connectionId == 2)
			{
				this.DatabaseControl1 = (DatabaseControl)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06006681 RID: 26241 RVA: 0x00385EBC File Offset: 0x003840BC
		// (remove) Token: 0x06006682 RID: 26242 RVA: 0x00385EF4 File Offset: 0x003840F4
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

		// Token: 0x06006683 RID: 26243 RVA: 0x00385F2C File Offset: 0x0038412C
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003A70 RID: 14960
		private Thread thread_0;

		// Token: 0x04003A71 RID: 14961
		private static List<Thread> list_0 = new List<Thread>();

		// Token: 0x04003A72 RID: 14962
		public Dispatcher dispatcher_0;

		// Token: 0x04003A73 RID: 14963
		private static string string_0;

		// Token: 0x04003A74 RID: 14964
		private static int int_0;

		// Token: 0x04003A75 RID: 14965
		private static int int_1;

		// Token: 0x04003A76 RID: 14966
		private static string string_1;

		// Token: 0x04003A77 RID: 14967
		private static object object_0 = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04003A78 RID: 14968
		[CompilerGenerated]
		[AccessedThroughProperty("DatabaseControl1")]
		private DatabaseControl databaseControl_0;

		// Token: 0x04003A79 RID: 14969
		private bool bool_0;

		// Token: 0x04003A7A RID: 14970
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
