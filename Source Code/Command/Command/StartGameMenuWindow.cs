using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Shapes;
using System.Windows.Threading;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns7;

namespace Command
{
	// Token: 0x02000E3D RID: 3645
	[DesignerGenerated]
	public sealed class StartGameMenuWindow : Window, IComponentConnector
	{
		// Token: 0x06006D8A RID: 28042 RVA: 0x0004503C File Offset: 0x0004323C
		public StartGameMenuWindow()
		{
			base.Closing += new CancelEventHandler(this.StartGameMenuWindow_Closing);
			this.InitializeComponent();
		}

		// Token: 0x06006D8B RID: 28043 RVA: 0x0004505C File Offset: 0x0004325C
		private static void smethod_0()
		{
			Client.startGameMenuWindow_0 = new StartGameMenuWindow();
			StartGameMenuWindow.dispatcher_0 = Dispatcher.CurrentDispatcher;
			Dispatcher.Run();
		}

		// Token: 0x06006D8C RID: 28044 RVA: 0x003BC65C File Offset: 0x003BA85C
		public static void smethod_1()
		{
			if (StartGameMenuWindow.thread_0 == null)
			{
				StartGameMenuWindow.thread_0 = new Thread(new ThreadStart(StartGameMenuWindow.smethod_0));
				StartGameMenuWindow.thread_0.Name = "StartGameWindowThread";
				StartGameMenuWindow.thread_0.SetApartmentState(ApartmentState.STA);
				StartGameMenuWindow.thread_0.IsBackground = true;
				StartGameMenuWindow.thread_0.Start();
				while (StartGameMenuWindow.dispatcher_0 == null)
				{
					Thread.Sleep(1);
				}
			}
			if (Client.startGameMenuWindow_0 == null && Debugger.IsAttached)
			{
				Debugger.Break();
			}
			StartGameMenuWindow.dispatcher_0.InvokeAsync((StartGameMenuWindow._Closure$__.$I4-0 == null) ? (StartGameMenuWindow._Closure$__.$I4-0 = new Action(StartGameMenuWindow._Closure$__.$I.method_0)) : StartGameMenuWindow._Closure$__.$I4-0);
		}

		// Token: 0x06006D8D RID: 28045 RVA: 0x00045077 File Offset: 0x00043277
		public static void smethod_2()
		{
			StartGameMenuWindow.dispatcher_0.InvokeAsync((StartGameMenuWindow._Closure$__.$I5-0 == null) ? (StartGameMenuWindow._Closure$__.$I5-0 = new Action(StartGameMenuWindow._Closure$__.$I.method_1)) : StartGameMenuWindow._Closure$__.$I5-0);
		}

		// Token: 0x06006D8E RID: 28046 RVA: 0x000450A8 File Offset: 0x000432A8
		private void MyMediaElement_MediaEnded(object sender, RoutedEventArgs e)
		{
			this.vmethod_0().Position = TimeSpan.Zero;
		}

		// Token: 0x06006D8F RID: 28047 RVA: 0x003BC708 File Offset: 0x003BA908
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			Client.startGameMenuWindow_0.Topmost = true;
			Client.startGameMenuWindow_0.Focus();
			this.vmethod_20().Content = "Loading, please wait...";
			this.vmethod_10().Visibility = Visibility.Collapsed;
			this.vmethod_8().Visibility = Visibility.Collapsed;
			this.vmethod_6().Visibility = Visibility.Collapsed;
			this.vmethod_14().Visibility = Visibility.Collapsed;
			this.vmethod_16().Visibility = Visibility.Collapsed;
			this.vmethod_22().Visibility = Visibility.Collapsed;
			this.vmethod_24().Visibility = Visibility.Collapsed;
			this.vmethod_28().Visibility = Visibility.Collapsed;
			this.vmethod_12().Visibility = Visibility.Collapsed;
			this.vmethod_18().Visibility = Visibility.Collapsed;
			this.vmethod_26().Visibility = Visibility.Collapsed;
			this.vmethod_31().Visibility = Visibility.Collapsed;
			VB$AnonymousDelegate_4<Image> vb$AnonymousDelegate_ = (StartGameMenuWindow._Closure$__.$I7-0 == null) ? (StartGameMenuWindow._Closure$__.$I7-0 = new VB$AnonymousDelegate_4<Image>(StartGameMenuWindow._Closure$__.$I.method_2)) : StartGameMenuWindow._Closure$__.$I7-0;
			vb$AnonymousDelegate_(this.vmethod_2());
			vb$AnonymousDelegate_(this.vmethod_4());
			base.DataContext = new StartGameMenuWindowViewModel(this);
			base.WindowState = WindowState.Maximized;
			base.ShowInTaskbar = false;
		}

		// Token: 0x06006D90 RID: 28048 RVA: 0x000450BA File Offset: 0x000432BA
		public void method_0()
		{
			StartGameMenuWindow.dispatcher_0.InvokeAsync(new Action(this.method_2));
		}

		// Token: 0x06006D91 RID: 28049 RVA: 0x000450D3 File Offset: 0x000432D3
		private void StartGameMenuWindow_Closing(object sender, CancelEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
		}

		// Token: 0x06006D92 RID: 28050 RVA: 0x000450E2 File Offset: 0x000432E2
		private void MyMediaElement_OnMediaOpened(object sender, RoutedEventArgs e)
		{
			this.vmethod_2().Visibility = Visibility.Collapsed;
		}

		// Token: 0x06006D93 RID: 28051 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_1(object sender, DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x06006D94 RID: 28052 RVA: 0x003BC820 File Offset: 0x003BAA20
		public static void smethod_3(IntPtr intptr_0)
		{
			StartGameMenuWindow.Class2469 @class = new StartGameMenuWindow.Class2469();
			@class.intptr_0 = intptr_0;
			StartGameMenuWindow.dispatcher_0.InvokeAsync(new Action(@class.method_0));
		}

		// Token: 0x06006D95 RID: 28053 RVA: 0x000450F0 File Offset: 0x000432F0
		[CompilerGenerated]
		internal MediaElement vmethod_0()
		{
			return this.mediaElement_0;
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x003BC854 File Offset: 0x003BAA54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(MediaElement mediaElement_1)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.MyMediaElement_MediaEnded);
			MediaElement mediaElement = this.mediaElement_0;
			if (mediaElement != null)
			{
				mediaElement.MediaEnded -= value;
			}
			this.mediaElement_0 = mediaElement_1;
			mediaElement = this.mediaElement_0;
			if (mediaElement != null)
			{
				mediaElement.MediaEnded += value;
			}
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x000450F8 File Offset: 0x000432F8
		[CompilerGenerated]
		internal Image vmethod_2()
		{
			return this.image_0;
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x00045100 File Offset: 0x00043300
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Image image_2)
		{
			this.image_0 = image_2;
		}

		// Token: 0x06006D99 RID: 28057 RVA: 0x00045109 File Offset: 0x00043309
		[CompilerGenerated]
		internal Image vmethod_4()
		{
			return this.image_1;
		}

		// Token: 0x06006D9A RID: 28058 RVA: 0x00045111 File Offset: 0x00043311
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Image image_2)
		{
			this.image_1 = image_2;
		}

		// Token: 0x06006D9B RID: 28059 RVA: 0x0004511A File Offset: 0x0004331A
		[CompilerGenerated]
		internal Button vmethod_6()
		{
			return this.button_0;
		}

		// Token: 0x06006D9C RID: 28060 RVA: 0x00045122 File Offset: 0x00043322
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_9)
		{
			this.button_0 = button_9;
		}

		// Token: 0x06006D9D RID: 28061 RVA: 0x0004512B File Offset: 0x0004332B
		[CompilerGenerated]
		internal Button vmethod_8()
		{
			return this.button_1;
		}

		// Token: 0x06006D9E RID: 28062 RVA: 0x00045133 File Offset: 0x00043333
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Button button_9)
		{
			this.button_1 = button_9;
		}

		// Token: 0x06006D9F RID: 28063 RVA: 0x0004513C File Offset: 0x0004333C
		[CompilerGenerated]
		internal Button vmethod_10()
		{
			return this.button_2;
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x00045144 File Offset: 0x00043344
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Button button_9)
		{
			this.button_2 = button_9;
		}

		// Token: 0x06006DA1 RID: 28065 RVA: 0x0004514D File Offset: 0x0004334D
		[CompilerGenerated]
		internal Rectangle vmethod_12()
		{
			return this.rectangle_0;
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x00045155 File Offset: 0x00043355
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Rectangle rectangle_3)
		{
			this.rectangle_0 = rectangle_3;
		}

		// Token: 0x06006DA3 RID: 28067 RVA: 0x0004515E File Offset: 0x0004335E
		[CompilerGenerated]
		internal Button vmethod_14()
		{
			return this.button_3;
		}

		// Token: 0x06006DA4 RID: 28068 RVA: 0x00045166 File Offset: 0x00043366
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Button button_9)
		{
			this.button_3 = button_9;
		}

		// Token: 0x06006DA5 RID: 28069 RVA: 0x0004516F File Offset: 0x0004336F
		[CompilerGenerated]
		internal Button vmethod_16()
		{
			return this.button_4;
		}

		// Token: 0x06006DA6 RID: 28070 RVA: 0x00045177 File Offset: 0x00043377
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Button button_9)
		{
			this.button_4 = button_9;
		}

		// Token: 0x06006DA7 RID: 28071 RVA: 0x00045180 File Offset: 0x00043380
		[CompilerGenerated]
		internal Rectangle vmethod_18()
		{
			return this.rectangle_1;
		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x00045188 File Offset: 0x00043388
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Rectangle rectangle_3)
		{
			this.rectangle_1 = rectangle_3;
		}

		// Token: 0x06006DA9 RID: 28073 RVA: 0x00045191 File Offset: 0x00043391
		[CompilerGenerated]
		internal Label vmethod_20()
		{
			return this.label_0;
		}

		// Token: 0x06006DAA RID: 28074 RVA: 0x00045199 File Offset: 0x00043399
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Label label_2)
		{
			this.label_0 = label_2;
		}

		// Token: 0x06006DAB RID: 28075 RVA: 0x000451A2 File Offset: 0x000433A2
		[CompilerGenerated]
		internal Button vmethod_22()
		{
			return this.button_5;
		}

		// Token: 0x06006DAC RID: 28076 RVA: 0x000451AA File Offset: 0x000433AA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Button button_9)
		{
			this.button_5 = button_9;
		}

		// Token: 0x06006DAD RID: 28077 RVA: 0x000451B3 File Offset: 0x000433B3
		[CompilerGenerated]
		internal Button vmethod_24()
		{
			return this.button_6;
		}

		// Token: 0x06006DAE RID: 28078 RVA: 0x000451BB File Offset: 0x000433BB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Button button_9)
		{
			this.button_6 = button_9;
		}

		// Token: 0x06006DAF RID: 28079 RVA: 0x000451C4 File Offset: 0x000433C4
		[CompilerGenerated]
		internal Rectangle vmethod_26()
		{
			return this.rectangle_2;
		}

		// Token: 0x06006DB0 RID: 28080 RVA: 0x000451CC File Offset: 0x000433CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Rectangle rectangle_3)
		{
			this.rectangle_2 = rectangle_3;
		}

		// Token: 0x06006DB1 RID: 28081 RVA: 0x000451D5 File Offset: 0x000433D5
		[CompilerGenerated]
		internal Button vmethod_28()
		{
			return this.button_7;
		}

		// Token: 0x06006DB2 RID: 28082 RVA: 0x000451DD File Offset: 0x000433DD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Button button_9)
		{
			this.button_7 = button_9;
		}

		// Token: 0x06006DB3 RID: 28083 RVA: 0x000451E6 File Offset: 0x000433E6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_30(Button button_9)
		{
			this.button_8 = button_9;
		}

		// Token: 0x06006DB4 RID: 28084 RVA: 0x000451EF File Offset: 0x000433EF
		[CompilerGenerated]
		internal Label vmethod_31()
		{
			return this.label_1;
		}

		// Token: 0x06006DB5 RID: 28085 RVA: 0x000451F7 File Offset: 0x000433F7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_32(Label label_2)
		{
			this.label_1 = label_2;
		}

		// Token: 0x06006DB6 RID: 28086 RVA: 0x003BC898 File Offset: 0x003BAA98
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/startgamemenu/startgamemenuwindow.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006DB7 RID: 28087 RVA: 0x003BC8C8 File Offset: 0x003BAAC8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((StartGameMenuWindow)target).Loaded += this.Window_Loaded;
				((StartGameMenuWindow)target).IsVisibleChanged += this.method_1;
				return;
			}
			if (connectionId == 2)
			{
				this.vmethod_1((MediaElement)target);
				this.vmethod_0().MediaOpened += this.MyMediaElement_OnMediaOpened;
				return;
			}
			if (connectionId == 3)
			{
				this.vmethod_3((Image)target);
				return;
			}
			if (connectionId == 4)
			{
				this.vmethod_5((Image)target);
				return;
			}
			if (connectionId == 5)
			{
				this.vmethod_7((Button)target);
				return;
			}
			if (connectionId == 6)
			{
				this.vmethod_9((Button)target);
				return;
			}
			if (connectionId == 7)
			{
				this.vmethod_11((Button)target);
				return;
			}
			if (connectionId == 8)
			{
				this.vmethod_13((Rectangle)target);
				return;
			}
			if (connectionId == 9)
			{
				this.vmethod_15((Button)target);
				return;
			}
			if (connectionId == 10)
			{
				this.vmethod_17((Button)target);
				return;
			}
			if (connectionId == 11)
			{
				this.vmethod_19((Rectangle)target);
				return;
			}
			if (connectionId == 12)
			{
				this.vmethod_21((Label)target);
				return;
			}
			if (connectionId == 13)
			{
				this.vmethod_23((Button)target);
				return;
			}
			if (connectionId == 14)
			{
				this.vmethod_25((Button)target);
				return;
			}
			if (connectionId == 15)
			{
				this.vmethod_27((Rectangle)target);
				return;
			}
			if (connectionId == 16)
			{
				this.vmethod_29((Button)target);
				return;
			}
			if (connectionId == 17)
			{
				this.vmethod_30((Button)target);
				return;
			}
			if (connectionId == 18)
			{
				this.vmethod_32((Label)target);
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x06006DB8 RID: 28088 RVA: 0x003BCA54 File Offset: 0x003BAC54
		[CompilerGenerated]
		private void method_2()
		{
			this.vmethod_20().Visibility = Visibility.Collapsed;
			this.vmethod_10().Visibility = Visibility.Visible;
			this.vmethod_8().Visibility = Visibility.Visible;
			this.vmethod_6().Visibility = Visibility.Visible;
			this.vmethod_14().Visibility = Visibility.Visible;
			this.vmethod_16().Visibility = Visibility.Visible;
			this.vmethod_22().Visibility = Visibility.Visible;
			this.vmethod_24().Visibility = Visibility.Visible;
			this.vmethod_28().Visibility = Visibility.Visible;
			this.vmethod_12().Visibility = Visibility.Visible;
			this.vmethod_18().Visibility = Visibility.Visible;
			this.vmethod_26().Visibility = Visibility.Visible;
			this.vmethod_31().Visibility = Visibility.Visible;
			this.vmethod_31().Content = GameGeneral.smethod_2();
			if (Class570.class280_0.method_10())
			{
				Class2561.smethod_1();
			}
		}

		// Token: 0x04003E5F RID: 15967
		public static Thread thread_0;

		// Token: 0x04003E60 RID: 15968
		public static Dispatcher dispatcher_0;

		// Token: 0x04003E61 RID: 15969
		[CompilerGenerated]
		[AccessedThroughProperty("myMediaElement")]
		private MediaElement mediaElement_0;

		// Token: 0x04003E62 RID: 15970
		[AccessedThroughProperty("FirstFrame")]
		[CompilerGenerated]
		private Image image_0;

		// Token: 0x04003E63 RID: 15971
		[AccessedThroughProperty("MainTitle")]
		[CompilerGenerated]
		private Image image_1;

		// Token: 0x04003E64 RID: 15972
		[AccessedThroughProperty("Button_NewGame")]
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04003E65 RID: 15973
		[AccessedThroughProperty("Button_QuickBattle")]
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04003E66 RID: 15974
		[CompilerGenerated]
		[AccessedThroughProperty("Button_Campaign")]
		private Button button_2;

		// Token: 0x04003E67 RID: 15975
		[CompilerGenerated]
		[AccessedThroughProperty("Divider1")]
		private Rectangle rectangle_0;

		// Token: 0x04003E68 RID: 15976
		[CompilerGenerated]
		[AccessedThroughProperty("Button_LoadGame")]
		private Button button_3;

		// Token: 0x04003E69 RID: 15977
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ResumeGame")]
		private Button button_4;

		// Token: 0x04003E6A RID: 15978
		[CompilerGenerated]
		[AccessedThroughProperty("Divider2")]
		private Rectangle rectangle_1;

		// Token: 0x04003E6B RID: 15979
		[AccessedThroughProperty("Label_Loading")]
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04003E6C RID: 15980
		[CompilerGenerated]
		[AccessedThroughProperty("Button_CreateScenario")]
		private Button button_5;

		// Token: 0x04003E6D RID: 15981
		[AccessedThroughProperty("Button_LoadScenario")]
		[CompilerGenerated]
		private Button button_6;

		// Token: 0x04003E6E RID: 15982
		[CompilerGenerated]
		[AccessedThroughProperty("Divider3")]
		private Rectangle rectangle_2;

		// Token: 0x04003E6F RID: 15983
		[CompilerGenerated]
		[AccessedThroughProperty("Button_Exit")]
		private Button button_7;

		// Token: 0x04003E70 RID: 15984
		[CompilerGenerated]
		[AccessedThroughProperty("Button_Spacer")]
		private Button button_8;

		// Token: 0x04003E71 RID: 15985
		[AccessedThroughProperty("Label_ProgramTitle")]
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04003E72 RID: 15986
		private bool bool_0;

		// Token: 0x02000E3F RID: 3647
		[CompilerGenerated]
		internal sealed class Class2469
		{
			// Token: 0x06006DBF RID: 28095 RVA: 0x00045269 File Offset: 0x00043469
			internal void method_0()
			{
				Client.startGameMenuWindow_0.Topmost = false;
				new WindowInteropHelper(Client.startGameMenuWindow_0).Owner = this.intptr_0;
			}

			// Token: 0x04003E77 RID: 15991
			public IntPtr intptr_0;
		}
	}
}
