using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns5;

namespace Command
{
	// Token: 0x02000D7B RID: 3451
	[DesignerGenerated]
	public sealed class GameControlBar : UserControl, IComponentConnector
	{
		// Token: 0x06005B7F RID: 23423 RVA: 0x00329FCC File Offset: 0x003281CC
		public GameControlBar()
		{
			this.InitializeComponent();
			if (!Assembly.GetExecutingAssembly().Location.Contains("VisualStudio"))
			{
				this.vmethod_4().Source = new BitmapImage(new Uri(Class2413.smethod_1().Info.DirectoryPath + "/Symbols/Bar/Time_1x.png"));
				this.vmethod_8().Source = new BitmapImage(new Uri(Class2413.smethod_1().Info.DirectoryPath + "/Symbols/Bar/Time_2x.png"));
				this.vmethod_12().Source = new BitmapImage(new Uri(Class2413.smethod_1().Info.DirectoryPath + "/Symbols/Bar/Time_5x.png"));
				this.vmethod_16().Source = new BitmapImage(new Uri(Class2413.smethod_1().Info.DirectoryPath + "/Symbols/Bar/Time_Turbo.png"));
				this.vmethod_32().Source = new BitmapImage(new Uri(Class2413.smethod_1().Info.DirectoryPath + "/Symbols/Bar/Arrow.png"));
				this.vmethod_30().Source = new BitmapImage(new Uri(Class2413.smethod_1().Info.DirectoryPath + "/Symbols/Bar/Layers.png"));
				this.vmethod_20().Source = new BitmapImage(new Uri(Class2413.smethod_1().Info.DirectoryPath + "/Symbols/Bar/Play.png"));
				this.vmethod_24().Source = new BitmapImage(new Uri(Class2413.smethod_1().Info.DirectoryPath + "/Symbols/Bar/Pause.png"));
				this.vmethod_28().Source = new BitmapImage(new Uri(Class2413.smethod_1().Info.DirectoryPath + "/Symbols/Bar/Record.png"));
				this.vmethod_36().Source = new BitmapImage(new Uri(Class2413.smethod_1().Info.DirectoryPath + "/Symbols/Bar/Special.png"));
			}
		}

		// Token: 0x06005B80 RID: 23424 RVA: 0x0032A1CC File Offset: 0x003283CC
		private void TimeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (Client.bool_0)
			{
				ComboBoxItem comboBoxItem = (ComboBoxItem)this.vmethod_0().SelectedItem;
				if (comboBoxItem == this.vmethod_2())
				{
					Class2413.smethod_2().method_41().method_619(null, null);
					return;
				}
				if (comboBoxItem == this.vmethod_6())
				{
					Class2413.smethod_2().method_41().method_620(null, null);
					return;
				}
				if (comboBoxItem == this.vmethod_10())
				{
					Class2413.smethod_2().method_41().method_621(null, null);
					return;
				}
				if (comboBoxItem == this.vmethod_14())
				{
					Class2413.smethod_2().method_41().method_622(null, null);
				}
			}
		}

		// Token: 0x06005B81 RID: 23425 RVA: 0x0003ADEB File Offset: 0x00038FEB
		private void PlayButton_Click(object sender, RoutedEventArgs e)
		{
			Class2413.smethod_2().method_41().method_214(null, null);
		}

		// Token: 0x06005B82 RID: 23426 RVA: 0x0032A25C File Offset: 0x0032845C
		private void RecordButton_Click(object sender, RoutedEventArgs e)
		{
			if (Client.smethod_44())
			{
				Client.smethod_45(false);
				this.vmethod_28().Source = new BitmapImage(new Uri(Class2413.smethod_1().Info.DirectoryPath + "/Symbols/Bar/Record.png"));
				this.vmethod_26().ToolTip = "Record the current game";
				return;
			}
			Client.class581_0 = Recorder.smethod_0(null, null);
			Client.smethod_45(true);
			this.vmethod_28().Source = new BitmapImage(new Uri(Class2413.smethod_1().Info.DirectoryPath + "/Symbols/Bar/RecordStop.png"));
			this.vmethod_26().ToolTip = "Stop recording";
		}

		// Token: 0x06005B83 RID: 23427 RVA: 0x0003ADFE File Offset: 0x00038FFE
		private void LayersButton_Click(object sender, RoutedEventArgs e)
		{
			Class2413.smethod_2().method_16().Show();
		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x0003AE0F File Offset: 0x0003900F
		private void ArrowButton_Click(object sender, RoutedEventArgs e)
		{
			Class2413.smethod_2().method_41().method_626(null, null);
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x0003ADEB File Offset: 0x00038FEB
		private void PauseButton_Click(object sender, RoutedEventArgs e)
		{
			Class2413.smethod_2().method_41().method_214(null, null);
		}

		// Token: 0x06005B86 RID: 23430 RVA: 0x0003AE22 File Offset: 0x00039022
		private void SpecialButton_Click(object sender, RoutedEventArgs e)
		{
			Class2413.smethod_2().method_65().Show();
		}

		// Token: 0x06005B87 RID: 23431 RVA: 0x0003AE33 File Offset: 0x00039033
		[CompilerGenerated]
		internal ComboBox vmethod_0()
		{
			return this.comboBox_0;
		}

		// Token: 0x06005B88 RID: 23432 RVA: 0x0003AE3B File Offset: 0x0003903B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ComboBox comboBox_1)
		{
			this.comboBox_0 = comboBox_1;
		}

		// Token: 0x06005B89 RID: 23433 RVA: 0x0003AE44 File Offset: 0x00039044
		[CompilerGenerated]
		internal ComboBoxItem vmethod_2()
		{
			return this.comboBoxItem_0;
		}

		// Token: 0x06005B8A RID: 23434 RVA: 0x0003AE4C File Offset: 0x0003904C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ComboBoxItem comboBoxItem_4)
		{
			this.comboBoxItem_0 = comboBoxItem_4;
		}

		// Token: 0x06005B8B RID: 23435 RVA: 0x0003AE55 File Offset: 0x00039055
		[CompilerGenerated]
		internal Image vmethod_4()
		{
			return this.image_0;
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x0003AE5D File Offset: 0x0003905D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Image image_10)
		{
			this.image_0 = image_10;
		}

		// Token: 0x06005B8D RID: 23437 RVA: 0x0003AE66 File Offset: 0x00039066
		[CompilerGenerated]
		internal ComboBoxItem vmethod_6()
		{
			return this.comboBoxItem_1;
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x0003AE6E File Offset: 0x0003906E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ComboBoxItem comboBoxItem_4)
		{
			this.comboBoxItem_1 = comboBoxItem_4;
		}

		// Token: 0x06005B8F RID: 23439 RVA: 0x0003AE77 File Offset: 0x00039077
		[CompilerGenerated]
		internal Image vmethod_8()
		{
			return this.image_1;
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x0003AE7F File Offset: 0x0003907F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Image image_10)
		{
			this.image_1 = image_10;
		}

		// Token: 0x06005B91 RID: 23441 RVA: 0x0003AE88 File Offset: 0x00039088
		[CompilerGenerated]
		internal ComboBoxItem vmethod_10()
		{
			return this.comboBoxItem_2;
		}

		// Token: 0x06005B92 RID: 23442 RVA: 0x0003AE90 File Offset: 0x00039090
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ComboBoxItem comboBoxItem_4)
		{
			this.comboBoxItem_2 = comboBoxItem_4;
		}

		// Token: 0x06005B93 RID: 23443 RVA: 0x0003AE99 File Offset: 0x00039099
		[CompilerGenerated]
		internal Image vmethod_12()
		{
			return this.image_2;
		}

		// Token: 0x06005B94 RID: 23444 RVA: 0x0003AEA1 File Offset: 0x000390A1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Image image_10)
		{
			this.image_2 = image_10;
		}

		// Token: 0x06005B95 RID: 23445 RVA: 0x0003AEAA File Offset: 0x000390AA
		[CompilerGenerated]
		internal ComboBoxItem vmethod_14()
		{
			return this.comboBoxItem_3;
		}

		// Token: 0x06005B96 RID: 23446 RVA: 0x0003AEB2 File Offset: 0x000390B2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ComboBoxItem comboBoxItem_4)
		{
			this.comboBoxItem_3 = comboBoxItem_4;
		}

		// Token: 0x06005B97 RID: 23447 RVA: 0x0003AEBB File Offset: 0x000390BB
		[CompilerGenerated]
		internal Image vmethod_16()
		{
			return this.image_3;
		}

		// Token: 0x06005B98 RID: 23448 RVA: 0x0003AEC3 File Offset: 0x000390C3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Image image_10)
		{
			this.image_3 = image_10;
		}

		// Token: 0x06005B99 RID: 23449 RVA: 0x0003AECC File Offset: 0x000390CC
		[CompilerGenerated]
		public Button vmethod_18()
		{
			return this.button_0;
		}

		// Token: 0x06005B9A RID: 23450 RVA: 0x0003AED4 File Offset: 0x000390D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_19(Button button_4)
		{
			this.button_0 = button_4;
		}

		// Token: 0x06005B9B RID: 23451 RVA: 0x0003AEDD File Offset: 0x000390DD
		[CompilerGenerated]
		internal Image vmethod_20()
		{
			return this.image_4;
		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x0003AEE5 File Offset: 0x000390E5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Image image_10)
		{
			this.image_4 = image_10;
		}

		// Token: 0x06005B9D RID: 23453 RVA: 0x0003AEEE File Offset: 0x000390EE
		[CompilerGenerated]
		public Button vmethod_22()
		{
			return this.button_1;
		}

		// Token: 0x06005B9E RID: 23454 RVA: 0x0003AEF6 File Offset: 0x000390F6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_23(Button button_4)
		{
			this.button_1 = button_4;
		}

		// Token: 0x06005B9F RID: 23455 RVA: 0x0003AEFF File Offset: 0x000390FF
		[CompilerGenerated]
		internal Image vmethod_24()
		{
			return this.image_5;
		}

		// Token: 0x06005BA0 RID: 23456 RVA: 0x0003AF07 File Offset: 0x00039107
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Image image_10)
		{
			this.image_5 = image_10;
		}

		// Token: 0x06005BA1 RID: 23457 RVA: 0x0003AF10 File Offset: 0x00039110
		[CompilerGenerated]
		internal Button vmethod_26()
		{
			return this.button_2;
		}

		// Token: 0x06005BA2 RID: 23458 RVA: 0x0003AF18 File Offset: 0x00039118
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Button button_4)
		{
			this.button_2 = button_4;
		}

		// Token: 0x06005BA3 RID: 23459 RVA: 0x0003AF21 File Offset: 0x00039121
		[CompilerGenerated]
		internal Image vmethod_28()
		{
			return this.image_6;
		}

		// Token: 0x06005BA4 RID: 23460 RVA: 0x0003AF29 File Offset: 0x00039129
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Image image_10)
		{
			this.image_6 = image_10;
		}

		// Token: 0x06005BA5 RID: 23461 RVA: 0x0003AF32 File Offset: 0x00039132
		[CompilerGenerated]
		internal Image vmethod_30()
		{
			return this.image_7;
		}

		// Token: 0x06005BA6 RID: 23462 RVA: 0x0003AF3A File Offset: 0x0003913A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Image image_10)
		{
			this.image_7 = image_10;
		}

		// Token: 0x06005BA7 RID: 23463 RVA: 0x0003AF43 File Offset: 0x00039143
		[CompilerGenerated]
		internal Image vmethod_32()
		{
			return this.image_8;
		}

		// Token: 0x06005BA8 RID: 23464 RVA: 0x0003AF4B File Offset: 0x0003914B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Image image_10)
		{
			this.image_8 = image_10;
		}

		// Token: 0x06005BA9 RID: 23465 RVA: 0x0003AF54 File Offset: 0x00039154
		[CompilerGenerated]
		internal Button vmethod_34()
		{
			return this.button_3;
		}

		// Token: 0x06005BAA RID: 23466 RVA: 0x0003AF5C File Offset: 0x0003915C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Button button_4)
		{
			this.button_3 = button_4;
		}

		// Token: 0x06005BAB RID: 23467 RVA: 0x0003AF65 File Offset: 0x00039165
		[CompilerGenerated]
		internal Image vmethod_36()
		{
			return this.image_9;
		}

		// Token: 0x06005BAC RID: 23468 RVA: 0x0003AF6D File Offset: 0x0003916D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Image image_10)
		{
			this.image_9 = image_10;
		}

		// Token: 0x06005BAD RID: 23469 RVA: 0x0032A308 File Offset: 0x00328508
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/customcontrols/gamecontrolbar.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06005BAE RID: 23470 RVA: 0x0032A338 File Offset: 0x00328538
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.vmethod_1((ComboBox)target);
				this.vmethod_0().SelectionChanged += this.TimeComboBox_SelectionChanged;
				return;
			}
			if (connectionId == 2)
			{
				this.vmethod_3((ComboBoxItem)target);
				return;
			}
			if (connectionId == 3)
			{
				this.vmethod_5((Image)target);
				return;
			}
			if (connectionId == 4)
			{
				this.vmethod_7((ComboBoxItem)target);
				return;
			}
			if (connectionId == 5)
			{
				this.vmethod_9((Image)target);
				return;
			}
			if (connectionId == 6)
			{
				this.vmethod_11((ComboBoxItem)target);
				return;
			}
			if (connectionId == 7)
			{
				this.vmethod_13((Image)target);
				return;
			}
			if (connectionId == 8)
			{
				this.vmethod_15((ComboBoxItem)target);
				return;
			}
			if (connectionId == 9)
			{
				this.vmethod_17((Image)target);
				return;
			}
			if (connectionId == 10)
			{
				this.vmethod_19((Button)target);
				this.vmethod_18().Click += this.PlayButton_Click;
				return;
			}
			if (connectionId == 11)
			{
				this.vmethod_21((Image)target);
				return;
			}
			if (connectionId == 12)
			{
				this.vmethod_23((Button)target);
				this.vmethod_22().Click += this.PauseButton_Click;
				return;
			}
			if (connectionId == 13)
			{
				this.vmethod_25((Image)target);
				return;
			}
			if (connectionId == 14)
			{
				this.vmethod_27((Button)target);
				this.vmethod_26().Click += this.RecordButton_Click;
				return;
			}
			if (connectionId == 15)
			{
				this.vmethod_29((Image)target);
				return;
			}
			if (connectionId == 16)
			{
				((Button)target).Click += this.LayersButton_Click;
				return;
			}
			if (connectionId == 17)
			{
				this.vmethod_31((Image)target);
				return;
			}
			if (connectionId == 18)
			{
				((Button)target).Click += this.ArrowButton_Click;
				return;
			}
			if (connectionId == 19)
			{
				this.vmethod_33((Image)target);
				return;
			}
			if (connectionId == 20)
			{
				this.vmethod_35((Button)target);
				this.vmethod_34().Click += this.SpecialButton_Click;
				return;
			}
			if (connectionId == 21)
			{
				this.vmethod_37((Image)target);
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04003565 RID: 13669
		[CompilerGenerated]
		[AccessedThroughProperty("TimeComboBox")]
		private ComboBox comboBox_0;

		// Token: 0x04003566 RID: 13670
		[CompilerGenerated]
		[AccessedThroughProperty("TimeItem1x")]
		private ComboBoxItem comboBoxItem_0;

		// Token: 0x04003567 RID: 13671
		[CompilerGenerated]
		[AccessedThroughProperty("Time1Image")]
		private Image image_0;

		// Token: 0x04003568 RID: 13672
		[CompilerGenerated]
		[AccessedThroughProperty("TimeItem2x")]
		private ComboBoxItem comboBoxItem_1;

		// Token: 0x04003569 RID: 13673
		[CompilerGenerated]
		[AccessedThroughProperty("Time2Image")]
		private Image image_1;

		// Token: 0x0400356A RID: 13674
		[CompilerGenerated]
		[AccessedThroughProperty("TimeItem5x")]
		private ComboBoxItem comboBoxItem_2;

		// Token: 0x0400356B RID: 13675
		[CompilerGenerated]
		[AccessedThroughProperty("Time5Image")]
		private Image image_2;

		// Token: 0x0400356C RID: 13676
		[AccessedThroughProperty("TimeItemTurbo")]
		[CompilerGenerated]
		private ComboBoxItem comboBoxItem_3;

		// Token: 0x0400356D RID: 13677
		[CompilerGenerated]
		[AccessedThroughProperty("TimeTurboImage")]
		private Image image_3;

		// Token: 0x0400356E RID: 13678
		[AccessedThroughProperty("PlayButton")]
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x0400356F RID: 13679
		[CompilerGenerated]
		[AccessedThroughProperty("PlayButtonImage")]
		private Image image_4;

		// Token: 0x04003570 RID: 13680
		[AccessedThroughProperty("PauseButton")]
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04003571 RID: 13681
		[AccessedThroughProperty("PauseButtonImage")]
		[CompilerGenerated]
		private Image image_5;

		// Token: 0x04003572 RID: 13682
		[CompilerGenerated]
		[AccessedThroughProperty("RecordButton")]
		private Button button_2;

		// Token: 0x04003573 RID: 13683
		[AccessedThroughProperty("RecordButtonImage")]
		[CompilerGenerated]
		private Image image_6;

		// Token: 0x04003574 RID: 13684
		[AccessedThroughProperty("LayersButtonImage")]
		[CompilerGenerated]
		private Image image_7;

		// Token: 0x04003575 RID: 13685
		[AccessedThroughProperty("ArrowButtonImage")]
		[CompilerGenerated]
		private Image image_8;

		// Token: 0x04003576 RID: 13686
		[CompilerGenerated]
		[AccessedThroughProperty("SpecialActionsButton")]
		private Button button_3;

		// Token: 0x04003577 RID: 13687
		[CompilerGenerated]
		[AccessedThroughProperty("SpecialButtonImage")]
		private Image image_9;

		// Token: 0x04003578 RID: 13688
		private bool bool_0;
	}
}
