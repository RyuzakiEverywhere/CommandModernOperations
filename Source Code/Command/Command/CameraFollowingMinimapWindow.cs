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
	// Token: 0x02000E07 RID: 3591
	[DesignerGenerated]
	[Attribute12]
	[Attribute11]
	[Attribute13]
	public sealed class CameraFollowingMinimapWindow : Window, IComponentConnector
	{
		// Token: 0x060068B8 RID: 26808 RVA: 0x000428F1 File Offset: 0x00040AF1
		public CameraFollowingMinimapWindow()
		{
			this.bool_0 = false;
			this.bool_1 = false;
			this.bool_2 = false;
			this.InitializeComponent();
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x0038BC38 File Offset: 0x00389E38
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
			this.cameraFollowingMinimapViewModel_0 = new CameraFollowingMinimapViewModel();
			this.cameraFollowingMinimapViewModel_0.dispatcher_0 = base.Dispatcher;
			this.cameraFollowingMinimapViewModel_0.grid_0 = this.MainGrid;
			base.DataContext = this.cameraFollowingMinimapViewModel_0;
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

		// Token: 0x060068BA RID: 26810 RVA: 0x00042914 File Offset: 0x00040B14
		private void method_0()
		{
			this.bool_0 = true;
			while (!this.bool_2)
			{
				Thread.Sleep(20000);
			}
			this.bool_0 = false;
		}

		// Token: 0x060068BB RID: 26811 RVA: 0x00042938 File Offset: 0x00040B38
		private void method_1()
		{
			this.bool_1 = true;
			while (!this.bool_2)
			{
				this.cameraFollowingMinimapViewModel_0.method_2();
				Thread.Sleep(5000);
			}
			this.bool_1 = false;
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x00042967 File Offset: 0x00040B67
		private void Window_Closed(object sender, EventArgs e)
		{
			this.bool_2 = true;
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x0038BD3C File Offset: 0x00389F3C
		private void UnitsImage_OnMouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton != MouseButton.Left)
			{
				this.cameraFollowingMinimapViewModel_0.method_3((int)Math.Round(e.GetPosition((IInputElement)sender).X), (int)Math.Round(e.GetPosition((IInputElement)sender).Y));
			}
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x00042970 File Offset: 0x00040B70
		private void MinimapWindow_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			base.DragMove();
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x0038BD90 File Offset: 0x00389F90
		private void UnitsImage_OnMouseMove(object sender, MouseEventArgs e)
		{
			if (e.RightButton == MouseButtonState.Pressed)
			{
				this.cameraFollowingMinimapViewModel_0.method_3((int)Math.Round(e.GetPosition((IInputElement)sender).X), (int)Math.Round(e.GetPosition((IInputElement)sender).Y));
			}
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x0004297F File Offset: 0x00040B7F
		private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			Class2413.smethod_2().method_41().method_110(this, null);
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060068C1 RID: 26817 RVA: 0x00042992 File Offset: 0x00040B92
		// (set) Token: 0x060068C2 RID: 26818 RVA: 0x0004299A File Offset: 0x00040B9A
		internal Grid MainGrid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060068C3 RID: 26819 RVA: 0x000429A3 File Offset: 0x00040BA3
		// (set) Token: 0x060068C4 RID: 26820 RVA: 0x000429AB File Offset: 0x00040BAB
		internal Image TerrainImage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060068C5 RID: 26821 RVA: 0x000429B4 File Offset: 0x00040BB4
		// (set) Token: 0x060068C6 RID: 26822 RVA: 0x000429BC File Offset: 0x00040BBC
		internal Image UnitsImage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060068C7 RID: 26823 RVA: 0x0038BDE8 File Offset: 0x00389FE8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_3)
			{
				this.bool_3 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/minimap/camerafollowingminimapwindow.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060068C8 RID: 26824 RVA: 0x0038BE18 File Offset: 0x0038A018
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((CameraFollowingMinimapWindow)target).Loaded += this.Window_Loaded;
				((CameraFollowingMinimapWindow)target).Closed += this.Window_Closed;
				((CameraFollowingMinimapWindow)target).MouseLeftButtonDown += this.MinimapWindow_OnMouseLeftButtonDown;
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

		// Token: 0x04003B9A RID: 15258
		private CameraFollowingMinimapViewModel cameraFollowingMinimapViewModel_0;

		// Token: 0x04003B9B RID: 15259
		private Thread thread_0;

		// Token: 0x04003B9C RID: 15260
		private bool bool_0;

		// Token: 0x04003B9D RID: 15261
		private Thread thread_1;

		// Token: 0x04003B9E RID: 15262
		private bool bool_1;

		// Token: 0x04003B9F RID: 15263
		private bool bool_2;

		// Token: 0x04003BA0 RID: 15264
		[CompilerGenerated]
		[AccessedThroughProperty("MainGrid")]
		private Grid grid_0;

		// Token: 0x04003BA1 RID: 15265
		[AccessedThroughProperty("TerrainImage")]
		[CompilerGenerated]
		private Image image_0;

		// Token: 0x04003BA2 RID: 15266
		[AccessedThroughProperty("UnitsImage")]
		[CompilerGenerated]
		private Image image_1;

		// Token: 0x04003BA3 RID: 15267
		private bool bool_3;
	}
}
