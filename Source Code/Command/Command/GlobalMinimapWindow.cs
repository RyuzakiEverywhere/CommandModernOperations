using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000E13 RID: 3603
	[Attribute12]
	[DesignerGenerated]
	[Attribute11]
	[Attribute13]
	public sealed class GlobalMinimapWindow : Window, IComponentConnector
	{
		// Token: 0x06006909 RID: 26889 RVA: 0x00042C35 File Offset: 0x00040E35
		public GlobalMinimapWindow()
		{
			this.bool_0 = false;
			this.bool_1 = false;
			this.bool_2 = false;
			this.InitializeComponent();
		}

		// Token: 0x0600690A RID: 26890 RVA: 0x0038E26C File Offset: 0x0038C46C
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			if (this.bool_0 && Debugger.IsAttached)
			{
				Debugger.Break();
			}
			if (this.bool_1 && Debugger.IsAttached)
			{
				Debugger.Break();
			}
			this.globalMinimapViewModel_0 = new GlobalMinimapViewModel();
			this.globalMinimapViewModel_0.dispatcher_0 = base.Dispatcher;
			this.globalMinimapViewModel_0.grid_0 = this.MainGrid;
			base.DataContext = this.globalMinimapViewModel_0;
			this.thread_0 = new Thread(new ThreadStart(this.method_0));
			this.thread_0.Name = "Minimap Terrain Thread";
			this.thread_0.Priority = ThreadPriority.Lowest;
			this.thread_0.Start();
			this.thread_1 = new Thread(new ThreadStart(this.method_1));
			this.thread_1.Name = "Minimap Unit Thread";
			this.thread_1.Priority = ThreadPriority.Lowest;
			this.thread_1.Start();
			new WindowInteropHelper(this).Owner = Class2413.smethod_2().method_41().Handle;
		}

		// Token: 0x0600690B RID: 26891 RVA: 0x00042C58 File Offset: 0x00040E58
		private void method_0()
		{
			this.bool_0 = true;
			while (!this.bool_2)
			{
				this.globalMinimapViewModel_0.method_1();
				Thread.Sleep(20000);
			}
			this.bool_0 = false;
		}

		// Token: 0x0600690C RID: 26892 RVA: 0x00042C87 File Offset: 0x00040E87
		private void method_1()
		{
			this.bool_1 = true;
			while (!this.bool_2)
			{
				this.globalMinimapViewModel_0.method_2();
				Thread.Sleep(5000);
			}
			this.bool_1 = false;
		}

		// Token: 0x0600690D RID: 26893 RVA: 0x00042CB6 File Offset: 0x00040EB6
		private void Window_Closed(object sender, EventArgs e)
		{
			this.bool_2 = true;
		}

		// Token: 0x0600690E RID: 26894 RVA: 0x0038E370 File Offset: 0x0038C570
		private void UnitsImage_OnMouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton != MouseButton.Left)
			{
				this.globalMinimapViewModel_0.method_3((int)Math.Round(e.GetPosition((IInputElement)sender).X), (int)Math.Round(e.GetPosition((IInputElement)sender).Y));
			}
		}

		// Token: 0x0600690F RID: 26895 RVA: 0x00042970 File Offset: 0x00040B70
		private void MinimapWindow_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			base.DragMove();
		}

		// Token: 0x06006910 RID: 26896 RVA: 0x0038E3C4 File Offset: 0x0038C5C4
		private void UnitsImage_OnMouseMove(object sender, MouseEventArgs e)
		{
			if (e.RightButton == MouseButtonState.Pressed)
			{
				this.globalMinimapViewModel_0.method_3((int)Math.Round(e.GetPosition((IInputElement)sender).X), (int)Math.Round(e.GetPosition((IInputElement)sender).Y));
			}
		}

		// Token: 0x06006911 RID: 26897 RVA: 0x00042CBF File Offset: 0x00040EBF
		private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			Class2413.smethod_2().method_41().method_109(this, null);
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06006912 RID: 26898 RVA: 0x00042CD2 File Offset: 0x00040ED2
		// (set) Token: 0x06006913 RID: 26899 RVA: 0x00042CDA File Offset: 0x00040EDA
		internal Grid MainGrid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06006914 RID: 26900 RVA: 0x00042CE3 File Offset: 0x00040EE3
		// (set) Token: 0x06006915 RID: 26901 RVA: 0x00042CEB File Offset: 0x00040EEB
		internal Image TerrainImage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06006916 RID: 26902 RVA: 0x00042CF4 File Offset: 0x00040EF4
		// (set) Token: 0x06006917 RID: 26903 RVA: 0x00042CFC File Offset: 0x00040EFC
		internal Image UnitsImage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06006918 RID: 26904 RVA: 0x0038E41C File Offset: 0x0038C61C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_3)
			{
				this.bool_3 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/minimap/globalminimapwindow.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006919 RID: 26905 RVA: 0x0038E44C File Offset: 0x0038C64C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((GlobalMinimapWindow)target).Loaded += this.Window_Loaded;
				((GlobalMinimapWindow)target).Closed += this.Window_Closed;
				((GlobalMinimapWindow)target).MouseLeftButtonDown += this.MinimapWindow_OnMouseLeftButtonDown;
				return;
			}
			if (connectionId == 2)
			{
				((Button)target).Click += this.ButtonBase_OnClick;
				return;
			}
			if (connectionId == 3)
			{
				this.MainGrid = (Grid)target;
				return;
			}
			if (connectionId == 4)
			{
				this.TerrainImage = (Image)target;
				return;
			}
			if (connectionId == 5)
			{
				this.UnitsImage = (Image)target;
				this.UnitsImage.MouseDown += this.UnitsImage_OnMouseDown;
				this.UnitsImage.MouseMove += this.UnitsImage_OnMouseMove;
				return;
			}
			this.bool_3 = true;
		}

		// Token: 0x04003BFB RID: 15355
		private GlobalMinimapViewModel globalMinimapViewModel_0;

		// Token: 0x04003BFC RID: 15356
		private Thread thread_0;

		// Token: 0x04003BFD RID: 15357
		private bool bool_0;

		// Token: 0x04003BFE RID: 15358
		private Thread thread_1;

		// Token: 0x04003BFF RID: 15359
		private bool bool_1;

		// Token: 0x04003C00 RID: 15360
		private bool bool_2;

		// Token: 0x04003C01 RID: 15361
		[AccessedThroughProperty("MainGrid")]
		[CompilerGenerated]
		private Grid grid_0;

		// Token: 0x04003C02 RID: 15362
		[CompilerGenerated]
		[AccessedThroughProperty("TerrainImage")]
		private Image image_0;

		// Token: 0x04003C03 RID: 15363
		[CompilerGenerated]
		[AccessedThroughProperty("UnitsImage")]
		private Image image_1;

		// Token: 0x04003C04 RID: 15364
		private bool bool_3;
	}
}
