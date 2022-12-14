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
	// Token: 0x02000E0D RID: 3597
	[Attribute11]
	[Attribute13]
	[DesignerGenerated]
	[Attribute12]
	public sealed class ScenarioMinimapWindow : Window, IComponentConnector
	{
		// Token: 0x060068E1 RID: 26849 RVA: 0x00042A89 File Offset: 0x00040C89
		public ScenarioMinimapWindow()
		{
			this.bool_0 = false;
			this.bool_1 = false;
			this.bool_2 = false;
			this.InitializeComponent();
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x0038D058 File Offset: 0x0038B258
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
			this.scenarioMinimapViewModel_0 = new ScenarioMinimapViewModel();
			this.scenarioMinimapViewModel_0.dispatcher_0 = base.Dispatcher;
			this.scenarioMinimapViewModel_0.grid_0 = this.MainGrid;
			base.DataContext = this.scenarioMinimapViewModel_0;
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

		// Token: 0x060068E3 RID: 26851 RVA: 0x00042AAC File Offset: 0x00040CAC
		private void method_0()
		{
			this.bool_0 = true;
			while (!this.bool_2)
			{
				this.scenarioMinimapViewModel_0.method_1();
				Thread.Sleep(20000);
			}
			this.bool_0 = false;
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x00042ADB File Offset: 0x00040CDB
		private void method_1()
		{
			this.bool_1 = true;
			while (!this.bool_2)
			{
				this.scenarioMinimapViewModel_0.method_2();
				Thread.Sleep(5000);
			}
			this.bool_1 = false;
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x00042B0A File Offset: 0x00040D0A
		private void Window_Closed(object sender, EventArgs e)
		{
			this.bool_2 = true;
		}

		// Token: 0x060068E6 RID: 26854 RVA: 0x0038D15C File Offset: 0x0038B35C
		private void UnitsImage_OnMouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton != MouseButton.Left)
			{
				this.scenarioMinimapViewModel_0.method_3((int)Math.Round(e.GetPosition((IInputElement)sender).X), (int)Math.Round(e.GetPosition((IInputElement)sender).Y));
			}
		}

		// Token: 0x060068E7 RID: 26855 RVA: 0x00042970 File Offset: 0x00040B70
		private void MinimapWindow_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			base.DragMove();
		}

		// Token: 0x060068E8 RID: 26856 RVA: 0x0038D1B0 File Offset: 0x0038B3B0
		private void UnitsImage_OnMouseMove(object sender, MouseEventArgs e)
		{
			if (e.RightButton == MouseButtonState.Pressed)
			{
				this.scenarioMinimapViewModel_0.method_3((int)Math.Round(e.GetPosition((IInputElement)sender).X), (int)Math.Round(e.GetPosition((IInputElement)sender).Y));
			}
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x00042B13 File Offset: 0x00040D13
		private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			Class2413.smethod_2().method_41().method_108(this, null);
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060068EA RID: 26858 RVA: 0x00042B26 File Offset: 0x00040D26
		// (set) Token: 0x060068EB RID: 26859 RVA: 0x00042B2E File Offset: 0x00040D2E
		internal Grid MainGrid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060068EC RID: 26860 RVA: 0x00042B37 File Offset: 0x00040D37
		// (set) Token: 0x060068ED RID: 26861 RVA: 0x00042B3F File Offset: 0x00040D3F
		internal Image TerrainImage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060068EE RID: 26862 RVA: 0x00042B48 File Offset: 0x00040D48
		// (set) Token: 0x060068EF RID: 26863 RVA: 0x00042B50 File Offset: 0x00040D50
		internal Image UnitsImage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060068F0 RID: 26864 RVA: 0x0038D208 File Offset: 0x0038B408
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_3)
			{
				this.bool_3 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/minimap/scenariominimapwindow.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060068F1 RID: 26865 RVA: 0x0038D238 File Offset: 0x0038B438
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((ScenarioMinimapWindow)target).Loaded += this.Window_Loaded;
				((ScenarioMinimapWindow)target).Closed += this.Window_Closed;
				((ScenarioMinimapWindow)target).MouseLeftButtonDown += this.MinimapWindow_OnMouseLeftButtonDown;
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

		// Token: 0x04003BCC RID: 15308
		private ScenarioMinimapViewModel scenarioMinimapViewModel_0;

		// Token: 0x04003BCD RID: 15309
		private Thread thread_0;

		// Token: 0x04003BCE RID: 15310
		private bool bool_0;

		// Token: 0x04003BCF RID: 15311
		private Thread thread_1;

		// Token: 0x04003BD0 RID: 15312
		private bool bool_1;

		// Token: 0x04003BD1 RID: 15313
		private bool bool_2;

		// Token: 0x04003BD2 RID: 15314
		[CompilerGenerated]
		[AccessedThroughProperty("MainGrid")]
		private Grid grid_0;

		// Token: 0x04003BD3 RID: 15315
		[CompilerGenerated]
		[AccessedThroughProperty("TerrainImage")]
		private Image image_0;

		// Token: 0x04003BD4 RID: 15316
		[CompilerGenerated]
		[AccessedThroughProperty("UnitsImage")]
		private Image image_1;

		// Token: 0x04003BD5 RID: 15317
		private bool bool_3;
	}
}
