using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;
using ns7;

namespace Command
{
	// Token: 0x02000DF9 RID: 3577
	[DesignerGenerated]
	public sealed class LicenseTweaker : Window, IComponentConnector
	{
		// Token: 0x0600681F RID: 26655 RVA: 0x000423CE File Offset: 0x000405CE
		public LicenseTweaker()
		{
			base.Loaded += this.LicenseTweaker_Loaded;
			this.InitializeComponent();
		}

		// Token: 0x06006820 RID: 26656 RVA: 0x00389248 File Offset: 0x00387448
		private void LicenseTweaker_Loaded(object sender, RoutedEventArgs e)
		{
			this.vmethod_0().IsChecked = new bool?(true);
			this.vmethod_2().IsChecked = new bool?(true);
			this.vmethod_4().IsChecked = new bool?(true);
			this.vmethod_6().IsChecked = new bool?(true);
			this.vmethod_8().IsChecked = new bool?(true);
			this.vmethod_10().IsChecked = new bool?(true);
			this.vmethod_12().IsChecked = new bool?(true);
			this.vmethod_14().IsChecked = new bool?(true);
			this.vmethod_16().IsChecked = new bool?(true);
			this.vmethod_18().IsChecked = new bool?(true);
			this.vmethod_20().IsChecked = new bool?(true);
			this.vmethod_22().IsChecked = new bool?(true);
			this.vmethod_24().IsChecked = new bool?(true);
			this.vmethod_26().IsChecked = new bool?(true);
			this.vmethod_28().IsChecked = new bool?(true);
			this.vmethod_30().IsChecked = new bool?(true);
		}

		// Token: 0x06006821 RID: 26657 RVA: 0x00389368 File Offset: 0x00387568
		private void CB_CMANOBase_Checked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_0().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_0);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_0);
		}

		// Token: 0x06006822 RID: 26658 RVA: 0x00389398 File Offset: 0x00387598
		private void CB_NorthernInferno_Checked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_2().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_1);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_1);
		}

		// Token: 0x06006823 RID: 26659 RVA: 0x003893C8 File Offset: 0x003875C8
		private void CB_ChainsOfWar_Checked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_4().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_7);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_7);
		}

		// Token: 0x06006824 RID: 26660 RVA: 0x003893F8 File Offset: 0x003875F8
		private void CB_ShiftingSands_Checked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_6().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_10);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_10);
		}

		// Token: 0x06006825 RID: 26661 RVA: 0x0038942C File Offset: 0x0038762C
		private void CB_TheSilentService_Checked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_8().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_12);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_12);
		}

		// Token: 0x06006826 RID: 26662 RVA: 0x00389460 File Offset: 0x00387660
		private void CB_DesertStorm_Checked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_10().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_16);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_16);
		}

		// Token: 0x06006827 RID: 26663 RVA: 0x00389494 File Offset: 0x00387694
		private void CB_CLIVE1_Checked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_12().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_2);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_2);
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x003894C4 File Offset: 0x003876C4
		private void CB_CLIVE2_Checked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_14().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_3);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_3);
		}

		// Token: 0x06006829 RID: 26665 RVA: 0x003894F4 File Offset: 0x003876F4
		private void CB_CLIVE3_Checked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_16().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_4);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_4);
		}

		// Token: 0x0600682A RID: 26666 RVA: 0x00389524 File Offset: 0x00387724
		private void CB_CLIVE4_Checked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_18().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_5);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_5);
		}

		// Token: 0x0600682B RID: 26667 RVA: 0x00389554 File Offset: 0x00387754
		private void CB_CLIVE5_Checked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_20().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_6);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_6);
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x00389584 File Offset: 0x00387784
		private void CB_CLIVE6_Clicked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_22().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_9);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_9);
		}

		// Token: 0x0600682D RID: 26669 RVA: 0x003895B8 File Offset: 0x003877B8
		private void CB_CLIVE7_Clicked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_24().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_11);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_11);
		}

		// Token: 0x0600682E RID: 26670 RVA: 0x003895EC File Offset: 0x003877EC
		private void CB_CLIVE8_Clicked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_26().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_13);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_13);
		}

		// Token: 0x0600682F RID: 26671 RVA: 0x00389620 File Offset: 0x00387820
		private void CB_CLIVE9_Clicked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_28().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_14);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_14);
		}

		// Token: 0x06006830 RID: 26672 RVA: 0x00389654 File Offset: 0x00387854
		private void CB_CLIVE10_Clicked(object sender, RoutedEventArgs e)
		{
			if (this.vmethod_30().IsChecked.GetValueOrDefault())
			{
				Class2556.smethod_4(Class2556.Enum209.const_15);
				return;
			}
			Class2556.smethod_5(Class2556.Enum209.const_15);
		}

		// Token: 0x06006831 RID: 26673 RVA: 0x000423EE File Offset: 0x000405EE
		[CompilerGenerated]
		internal CheckBox vmethod_0()
		{
			return this.checkBox_0;
		}

		// Token: 0x06006832 RID: 26674 RVA: 0x00389688 File Offset: 0x00387888
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_CMANOBase_Checked);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_0 = checkBox_16;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06006833 RID: 26675 RVA: 0x000423F6 File Offset: 0x000405F6
		[CompilerGenerated]
		internal CheckBox vmethod_2()
		{
			return this.checkBox_1;
		}

		// Token: 0x06006834 RID: 26676 RVA: 0x003896CC File Offset: 0x003878CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_NorthernInferno_Checked);
			CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_1 = checkBox_16;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06006835 RID: 26677 RVA: 0x000423FE File Offset: 0x000405FE
		[CompilerGenerated]
		internal CheckBox vmethod_4()
		{
			return this.checkBox_2;
		}

		// Token: 0x06006836 RID: 26678 RVA: 0x00389710 File Offset: 0x00387910
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_ChainsOfWar_Checked);
			CheckBox checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_2 = checkBox_16;
			checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06006837 RID: 26679 RVA: 0x00042406 File Offset: 0x00040606
		[CompilerGenerated]
		internal CheckBox vmethod_6()
		{
			return this.checkBox_3;
		}

		// Token: 0x06006838 RID: 26680 RVA: 0x00389754 File Offset: 0x00387954
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_ShiftingSands_Checked);
			CheckBox checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_3 = checkBox_16;
			checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x0004240E File Offset: 0x0004060E
		[CompilerGenerated]
		internal CheckBox vmethod_8()
		{
			return this.checkBox_4;
		}

		// Token: 0x0600683A RID: 26682 RVA: 0x00389798 File Offset: 0x00387998
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_TheSilentService_Checked);
			CheckBox checkBox = this.checkBox_4;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_4 = checkBox_16;
			checkBox = this.checkBox_4;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600683B RID: 26683 RVA: 0x00042416 File Offset: 0x00040616
		[CompilerGenerated]
		internal CheckBox vmethod_10()
		{
			return this.checkBox_5;
		}

		// Token: 0x0600683C RID: 26684 RVA: 0x003897DC File Offset: 0x003879DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_DesertStorm_Checked);
			CheckBox checkBox = this.checkBox_5;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_5 = checkBox_16;
			checkBox = this.checkBox_5;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600683D RID: 26685 RVA: 0x0004241E File Offset: 0x0004061E
		[CompilerGenerated]
		internal CheckBox vmethod_12()
		{
			return this.checkBox_6;
		}

		// Token: 0x0600683E RID: 26686 RVA: 0x00389820 File Offset: 0x00387A20
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_CLIVE1_Checked);
			CheckBox checkBox = this.checkBox_6;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_6 = checkBox_16;
			checkBox = this.checkBox_6;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600683F RID: 26687 RVA: 0x00042426 File Offset: 0x00040626
		[CompilerGenerated]
		internal CheckBox vmethod_14()
		{
			return this.checkBox_7;
		}

		// Token: 0x06006840 RID: 26688 RVA: 0x00389864 File Offset: 0x00387A64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_CLIVE2_Checked);
			CheckBox checkBox = this.checkBox_7;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_7 = checkBox_16;
			checkBox = this.checkBox_7;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06006841 RID: 26689 RVA: 0x0004242E File Offset: 0x0004062E
		[CompilerGenerated]
		internal CheckBox vmethod_16()
		{
			return this.checkBox_8;
		}

		// Token: 0x06006842 RID: 26690 RVA: 0x003898A8 File Offset: 0x00387AA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_CLIVE3_Checked);
			CheckBox checkBox = this.checkBox_8;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_8 = checkBox_16;
			checkBox = this.checkBox_8;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06006843 RID: 26691 RVA: 0x00042436 File Offset: 0x00040636
		[CompilerGenerated]
		internal CheckBox vmethod_18()
		{
			return this.checkBox_9;
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x003898EC File Offset: 0x00387AEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_CLIVE4_Checked);
			CheckBox checkBox = this.checkBox_9;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_9 = checkBox_16;
			checkBox = this.checkBox_9;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x0004243E File Offset: 0x0004063E
		[CompilerGenerated]
		internal CheckBox vmethod_20()
		{
			return this.checkBox_10;
		}

		// Token: 0x06006846 RID: 26694 RVA: 0x00389930 File Offset: 0x00387B30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_CLIVE5_Checked);
			CheckBox checkBox = this.checkBox_10;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_10 = checkBox_16;
			checkBox = this.checkBox_10;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x00042446 File Offset: 0x00040646
		[CompilerGenerated]
		internal CheckBox vmethod_22()
		{
			return this.checkBox_11;
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x00389974 File Offset: 0x00387B74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_CLIVE6_Clicked);
			CheckBox checkBox = this.checkBox_11;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_11 = checkBox_16;
			checkBox = this.checkBox_11;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x0004244E File Offset: 0x0004064E
		[CompilerGenerated]
		internal CheckBox vmethod_24()
		{
			return this.checkBox_12;
		}

		// Token: 0x0600684A RID: 26698 RVA: 0x003899B8 File Offset: 0x00387BB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_CLIVE7_Clicked);
			CheckBox checkBox = this.checkBox_12;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_12 = checkBox_16;
			checkBox = this.checkBox_12;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600684B RID: 26699 RVA: 0x00042456 File Offset: 0x00040656
		[CompilerGenerated]
		internal CheckBox vmethod_26()
		{
			return this.checkBox_13;
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x003899FC File Offset: 0x00387BFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_CLIVE8_Clicked);
			CheckBox checkBox = this.checkBox_13;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_13 = checkBox_16;
			checkBox = this.checkBox_13;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x0004245E File Offset: 0x0004065E
		[CompilerGenerated]
		internal CheckBox vmethod_28()
		{
			return this.checkBox_14;
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x00389A40 File Offset: 0x00387C40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_CLIVE9_Clicked);
			CheckBox checkBox = this.checkBox_14;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_14 = checkBox_16;
			checkBox = this.checkBox_14;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x00042466 File Offset: 0x00040666
		[CompilerGenerated]
		internal CheckBox vmethod_30()
		{
			return this.checkBox_15;
		}

		// Token: 0x06006850 RID: 26704 RVA: 0x00389A84 File Offset: 0x00387C84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(CheckBox checkBox_16)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_CLIVE10_Clicked);
			CheckBox checkBox = this.checkBox_15;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_15 = checkBox_16;
			checkBox = this.checkBox_15;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x00389AC8 File Offset: 0x00387CC8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/forms/licensing/licensetweaker.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06006852 RID: 26706 RVA: 0x00389AF8 File Offset: 0x00387CF8
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.vmethod_1((CheckBox)target);
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
				this.vmethod_17((CheckBox)target);
				return;
			}
			if (connectionId == 10)
			{
				this.vmethod_19((CheckBox)target);
				return;
			}
			if (connectionId == 11)
			{
				this.vmethod_21((CheckBox)target);
				return;
			}
			if (connectionId == 12)
			{
				this.vmethod_23((CheckBox)target);
				return;
			}
			if (connectionId == 13)
			{
				this.vmethod_25((CheckBox)target);
				return;
			}
			if (connectionId == 14)
			{
				this.vmethod_27((CheckBox)target);
				return;
			}
			if (connectionId == 15)
			{
				this.vmethod_29((CheckBox)target);
				return;
			}
			if (connectionId == 16)
			{
				this.vmethod_31((CheckBox)target);
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x06006853 RID: 26707 RVA: 0x0000378C File Offset: 0x0000198C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void Connect(int connectionId, object target)
		{
		}

		// Token: 0x04003B46 RID: 15174
		[CompilerGenerated]
		[AccessedThroughProperty("CB_CMANOBase")]
		private CheckBox checkBox_0;

		// Token: 0x04003B47 RID: 15175
		[AccessedThroughProperty("CB_NorthernInferno")]
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x04003B48 RID: 15176
		[AccessedThroughProperty("CB_ChainsOfWar")]
		[CompilerGenerated]
		private CheckBox checkBox_2;

		// Token: 0x04003B49 RID: 15177
		[AccessedThroughProperty("CB_ShiftingSands")]
		[CompilerGenerated]
		private CheckBox checkBox_3;

		// Token: 0x04003B4A RID: 15178
		[CompilerGenerated]
		[AccessedThroughProperty("CB_TheSilentService")]
		private CheckBox checkBox_4;

		// Token: 0x04003B4B RID: 15179
		[AccessedThroughProperty("CB_DesertStorm")]
		[CompilerGenerated]
		private CheckBox checkBox_5;

		// Token: 0x04003B4C RID: 15180
		[CompilerGenerated]
		[AccessedThroughProperty("CB_CLIVE1")]
		private CheckBox checkBox_6;

		// Token: 0x04003B4D RID: 15181
		[AccessedThroughProperty("CB_CLIVE2")]
		[CompilerGenerated]
		private CheckBox checkBox_7;

		// Token: 0x04003B4E RID: 15182
		[AccessedThroughProperty("CB_CLIVE3")]
		[CompilerGenerated]
		private CheckBox checkBox_8;

		// Token: 0x04003B4F RID: 15183
		[AccessedThroughProperty("CB_CLIVE4")]
		[CompilerGenerated]
		private CheckBox checkBox_9;

		// Token: 0x04003B50 RID: 15184
		[CompilerGenerated]
		[AccessedThroughProperty("CB_CLIVE5")]
		private CheckBox checkBox_10;

		// Token: 0x04003B51 RID: 15185
		[AccessedThroughProperty("CB_CLIVE6")]
		[CompilerGenerated]
		private CheckBox checkBox_11;

		// Token: 0x04003B52 RID: 15186
		[CompilerGenerated]
		[AccessedThroughProperty("CB_CLIVE7")]
		private CheckBox checkBox_12;

		// Token: 0x04003B53 RID: 15187
		[CompilerGenerated]
		[AccessedThroughProperty("CB_CLIVE8")]
		private CheckBox checkBox_13;

		// Token: 0x04003B54 RID: 15188
		[CompilerGenerated]
		[AccessedThroughProperty("CB_CLIVE9")]
		private CheckBox checkBox_14;

		// Token: 0x04003B55 RID: 15189
		[AccessedThroughProperty("CB_CLIVE10")]
		[CompilerGenerated]
		private CheckBox checkBox_15;

		// Token: 0x04003B56 RID: 15190
		private bool bool_0;
	}
}
