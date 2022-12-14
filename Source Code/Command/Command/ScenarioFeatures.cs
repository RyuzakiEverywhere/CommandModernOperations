using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns3;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000E35 RID: 3637
	[DesignerGenerated]
	public sealed class ScenarioFeatures : Window, IComponentConnector
	{
		// Token: 0x06006D1A RID: 27930 RVA: 0x003BB8FC File Offset: 0x003B9AFC
		public ScenarioFeatures()
		{
			base.Loaded += this.ScenarioFeatures_Loaded;
			base.KeyDown += this.ScenarioFeatures_KeyDown;
			base.Closing += new CancelEventHandler(this.ScenarioFeatures_Closing);
			this.InitializeComponent();
		}

		// Token: 0x06006D1B RID: 27931 RVA: 0x003BB94C File Offset: 0x003B9B4C
		private void ScenarioFeatures_Loaded(object sender, RoutedEventArgs e)
		{
			if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
			{
				this.vmethod_16().Visibility = Visibility.Visible;
				this.vmethod_18().Visibility = Visibility.Visible;
				this.vmethod_2().IsEnabled = true;
				this.vmethod_4().IsEnabled = true;
				if (Class2556.smethod_11(Scenario.ScenarioFeatureOption.const_3))
				{
					this.vmethod_6().IsEnabled = true;
					((Control)this.vmethod_6().Content).Foreground = Brushes.White;
				}
				else
				{
					this.vmethod_6().IsEnabled = false;
					((Control)this.vmethod_6().Content).Foreground = Brushes.Gray;
				}
				if (Class2556.smethod_11(Scenario.ScenarioFeatureOption.const_5))
				{
					this.vmethod_12().IsEnabled = true;
					((Control)this.vmethod_12().Content).Foreground = Brushes.White;
				}
				else
				{
					this.vmethod_12().IsEnabled = false;
					((Control)this.vmethod_12().Content).Foreground = Brushes.Gray;
				}
				if (Class2556.smethod_11(Scenario.ScenarioFeatureOption.const_4))
				{
					this.vmethod_14().Visibility = Visibility.Visible;
				}
				else
				{
					this.vmethod_14().Visibility = Visibility.Collapsed;
				}
			}
			else
			{
				this.vmethod_16().Visibility = Visibility.Collapsed;
				this.vmethod_18().Visibility = Visibility.Collapsed;
				this.vmethod_2().IsEnabled = false;
				this.vmethod_4().IsEnabled = false;
				this.vmethod_14().IsEnabled = false;
				this.vmethod_12().IsEnabled = false;
				this.vmethod_6().IsEnabled = false;
			}
			this.vmethod_2().IsChecked = new bool?(Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_1));
			this.vmethod_4().IsChecked = new bool?(Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2));
			this.vmethod_8().IsChecked = new bool?(Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_9));
			this.vmethod_10().IsChecked = new bool?(Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_10));
			this.vmethod_14().IsChecked = new bool?(Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_4));
			this.vmethod_12().IsChecked = new bool?(Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_5));
			this.vmethod_6().IsChecked = new bool?(Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_3));
			base.Height = this.vmethod_0().Height + 5.0;
		}

		// Token: 0x06006D1C RID: 27932 RVA: 0x003BBBBC File Offset: 0x003B9DBC
		private void Button_OK_Click(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_2().IsChecked.GetValueOrDefault())
			{
				Client.smethod_46().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_1);
			}
			else
			{
				Client.smethod_46().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.const_1);
			}
			if (this.vmethod_4().IsChecked.GetValueOrDefault())
			{
				Client.smethod_46().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_2);
			}
			else
			{
				Client.smethod_46().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.const_2);
			}
			if (this.vmethod_8().IsChecked.GetValueOrDefault())
			{
				Client.smethod_46().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_9);
			}
			else
			{
				Client.smethod_46().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.const_9);
			}
			if (this.vmethod_10().IsChecked.GetValueOrDefault())
			{
				Client.smethod_46().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_10);
			}
			else
			{
				Client.smethod_46().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.const_10);
			}
			if (this.vmethod_14().IsChecked.GetValueOrDefault())
			{
				Client.smethod_46().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_4);
			}
			else
			{
				Client.smethod_46().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.const_4);
			}
			if (this.vmethod_6().IsChecked.GetValueOrDefault())
			{
				Client.smethod_46().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_3);
			}
			else
			{
				Client.smethod_46().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.const_3);
			}
			if (this.vmethod_12().IsChecked.GetValueOrDefault())
			{
				Client.smethod_46().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_5);
			}
			else
			{
				Client.smethod_46().DeclaredFeatures.Remove(Scenario.ScenarioFeatureOption.const_5);
			}
			Class2413.smethod_2().method_41().method_353();
			base.Close();
		}

		// Token: 0x06006D1D RID: 27933 RVA: 0x00040EFE File Offset: 0x0003F0FE
		private void Button_Cancel_Click(object sender, RoutedEventArgs e)
		{
			base.Close();
		}

		// Token: 0x06006D1E RID: 27934 RVA: 0x00044A0F File Offset: 0x00042C0F
		private void ScenarioFeatures_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Select && base.Visibility == Visibility.Visible)
			{
				base.Close();
				return;
			}
			if (e.Key == Key.Delete)
			{
				Visibility visibility = base.Visibility;
			}
		}

		// Token: 0x06006D1F RID: 27935 RVA: 0x00044820 File Offset: 0x00042A20
		private void ScenarioFeatures_Closing(object sender, CancelEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06006D20 RID: 27936 RVA: 0x003BBD74 File Offset: 0x003B9F74
		private void CB_ACDamage_Checked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_6().IsChecked.GetValueOrDefault())
			{
				DarkMessageBox.smethod_1("It appears that you are activating the 'Aircraft Damage' feature. If this scenario has been built prior to v1.12 and not been rebuilt afterwards, it is likely that one or more aircraft will not have their proper DP values set, and may immediately appear as damaged or even destroyed when the scenario runs. Please ensure that the scenario is deep-rebuilt prior to testing & release.", "CAUTION!", Enum11.const_0);
			}
		}

		// Token: 0x06006D21 RID: 27937 RVA: 0x00044A3B File Offset: 0x00042C3B
		[CompilerGenerated]
		internal StackPanel vmethod_0()
		{
			return this.stackPanel_0;
		}

		// Token: 0x06006D22 RID: 27938 RVA: 0x00044A43 File Offset: 0x00042C43
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(StackPanel stackPanel_1)
		{
			this.stackPanel_0 = stackPanel_1;
		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x00044A4C File Offset: 0x00042C4C
		[CompilerGenerated]
		internal CheckBox vmethod_2()
		{
			return this.checkBox_0;
		}

		// Token: 0x06006D24 RID: 27940 RVA: 0x00044A54 File Offset: 0x00042C54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(CheckBox checkBox_7)
		{
			this.checkBox_0 = checkBox_7;
		}

		// Token: 0x06006D25 RID: 27941 RVA: 0x00044A5D File Offset: 0x00042C5D
		[CompilerGenerated]
		internal CheckBox vmethod_4()
		{
			return this.checkBox_1;
		}

		// Token: 0x06006D26 RID: 27942 RVA: 0x00044A65 File Offset: 0x00042C65
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(CheckBox checkBox_7)
		{
			this.checkBox_1 = checkBox_7;
		}

		// Token: 0x06006D27 RID: 27943 RVA: 0x00044A6E File Offset: 0x00042C6E
		[CompilerGenerated]
		internal CheckBox vmethod_6()
		{
			return this.checkBox_2;
		}

		// Token: 0x06006D28 RID: 27944 RVA: 0x003BBDA8 File Offset: 0x003B9FA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(CheckBox checkBox_7)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_ACDamage_Checked);
			CheckBox checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_2 = checkBox_7;
			checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06006D29 RID: 27945 RVA: 0x00044A76 File Offset: 0x00042C76
		[CompilerGenerated]
		internal CheckBox vmethod_8()
		{
			return this.checkBox_3;
		}

		// Token: 0x06006D2A RID: 27946 RVA: 0x00044A7E File Offset: 0x00042C7E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(CheckBox checkBox_7)
		{
			this.checkBox_3 = checkBox_7;
		}

		// Token: 0x06006D2B RID: 27947 RVA: 0x00044A87 File Offset: 0x00042C87
		[CompilerGenerated]
		internal CheckBox vmethod_10()
		{
			return this.checkBox_4;
		}

		// Token: 0x06006D2C RID: 27948 RVA: 0x00044A8F File Offset: 0x00042C8F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(CheckBox checkBox_7)
		{
			this.checkBox_4 = checkBox_7;
		}

		// Token: 0x06006D2D RID: 27949 RVA: 0x00044A98 File Offset: 0x00042C98
		[CompilerGenerated]
		internal CheckBox vmethod_12()
		{
			return this.checkBox_5;
		}

		// Token: 0x06006D2E RID: 27950 RVA: 0x00044AA0 File Offset: 0x00042CA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(CheckBox checkBox_7)
		{
			this.checkBox_5 = checkBox_7;
		}

		// Token: 0x06006D2F RID: 27951 RVA: 0x00044AA9 File Offset: 0x00042CA9
		[CompilerGenerated]
		internal CheckBox vmethod_14()
		{
			return this.checkBox_6;
		}

		// Token: 0x06006D30 RID: 27952 RVA: 0x00044AB1 File Offset: 0x00042CB1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(CheckBox checkBox_7)
		{
			this.checkBox_6 = checkBox_7;
		}

		// Token: 0x06006D31 RID: 27953 RVA: 0x00044ABA File Offset: 0x00042CBA
		[CompilerGenerated]
		internal Button vmethod_16()
		{
			return this.button_0;
		}

		// Token: 0x06006D32 RID: 27954 RVA: 0x003BBDEC File Offset: 0x003B9FEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Button button_2)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button_OK_Click);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_2;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006D33 RID: 27955 RVA: 0x00044AC2 File Offset: 0x00042CC2
		[CompilerGenerated]
		internal Button vmethod_18()
		{
			return this.button_1;
		}

		// Token: 0x06006D34 RID: 27956 RVA: 0x003BBE30 File Offset: 0x003BA030
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Button button_2)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button_Cancel_Click);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_2;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006D35 RID: 27957 RVA: 0x003BBE74 File Offset: 0x003BA074
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/scenario/scenariofeatures.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006D36 RID: 27958 RVA: 0x003BBEA4 File Offset: 0x003BA0A4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.vmethod_1((StackPanel)target);
				return;
			}
			if (connectionId == 2)
			{
				this.vmethod_3((CheckBox)target);
				return;
			}
			if (connectionId == 3)
			{
				this.vmethod_5((CheckBox)target);
				return;
			}
			if (connectionId == 4)
			{
				this.vmethod_7((CheckBox)target);
				return;
			}
			if (connectionId == 5)
			{
				this.vmethod_9((CheckBox)target);
				return;
			}
			if (connectionId == 6)
			{
				this.vmethod_11((CheckBox)target);
				return;
			}
			if (connectionId == 7)
			{
				this.vmethod_13((CheckBox)target);
				return;
			}
			if (connectionId == 8)
			{
				this.vmethod_15((CheckBox)target);
				return;
			}
			if (connectionId == 9)
			{
				this.vmethod_17((Button)target);
				return;
			}
			if (connectionId == 10)
			{
				this.vmethod_19((Button)target);
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04003E31 RID: 15921
		[CompilerGenerated]
		[AccessedThroughProperty("StackPanel1")]
		private StackPanel stackPanel_0;

		// Token: 0x04003E32 RID: 15922
		[CompilerGenerated]
		[AccessedThroughProperty("CB_GunfireControl")]
		private CheckBox checkBox_0;

		// Token: 0x04003E33 RID: 15923
		[CompilerGenerated]
		[AccessedThroughProperty("CB_UnlimitedBaseMags")]
		private CheckBox checkBox_1;

		// Token: 0x04003E34 RID: 15924
		[CompilerGenerated]
		[AccessedThroughProperty("CB_ACDamage")]
		private CheckBox checkBox_2;

		// Token: 0x04003E35 RID: 15925
		[CompilerGenerated]
		[AccessedThroughProperty("CB_RealisticSubComms")]
		private CheckBox checkBox_3;

		// Token: 0x04003E36 RID: 15926
		[CompilerGenerated]
		[AccessedThroughProperty("CB_TerrainTypeEffects")]
		private CheckBox checkBox_4;

		// Token: 0x04003E37 RID: 15927
		[CompilerGenerated]
		[AccessedThroughProperty("CB_CommsDisruption")]
		private CheckBox checkBox_5;

		// Token: 0x04003E38 RID: 15928
		[CompilerGenerated]
		[AccessedThroughProperty("CB_CommsJamming")]
		private CheckBox checkBox_6;

		// Token: 0x04003E39 RID: 15929
		[CompilerGenerated]
		[AccessedThroughProperty("Button_OK")]
		private Button button_0;

		// Token: 0x04003E3A RID: 15930
		[CompilerGenerated]
		[AccessedThroughProperty("Button_Cancel")]
		private Button button_1;

		// Token: 0x04003E3B RID: 15931
		private bool bool_0;
	}
}
