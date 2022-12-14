using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns5;
using Odyssey.Controls;

namespace Command
{
	// Token: 0x02000D8D RID: 3469
	[DesignerGenerated]
	public sealed class RightColumnWPF : UserControl, IComponentConnector
	{
		// Token: 0x06005C98 RID: 23704 RVA: 0x0003B806 File Offset: 0x00039A06
		public RightColumnWPF()
		{
			this.bool_0 = true;
			this.bool_1 = false;
			this.bool_2 = false;
			this.InitializeComponent();
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x0003B829 File Offset: 0x00039A29
		public void method_0()
		{
			this.bool_0 = false;
		}

		// Token: 0x06005C9A RID: 23706 RVA: 0x0003B832 File Offset: 0x00039A32
		public void method_1()
		{
			this.bool_0 = true;
			this.method_2(Client.smethod_46(), Client.smethod_50(), Client.smethod_54());
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x0032D88C File Offset: 0x0032BA8C
		public void method_2(Scenario scenario_0, Side side_0, Unit unit_0)
		{
			if (this.bool_0)
			{
				if (Client.smethod_50() == null)
				{
					this.vmethod_20().Visibility = Visibility.Collapsed;
					this.vmethod_24().Visibility = Visibility.Collapsed;
					this.vmethod_28().Visibility = Visibility.Collapsed;
					this.vmethod_32().Visibility = Visibility.Collapsed;
					this.vmethod_16().Visibility = Visibility.Collapsed;
					this.vmethod_26().method_0(null);
					UnitWeapons_WPF unitWeapons_WPF = this.vmethod_22();
					ActiveUnit theUnit = null;
					bool flag = false;
					bool flag2 = false;
					unitWeapons_WPF.method_0(theUnit, ref flag, ref flag2);
					this.vmethod_30().method_0(null);
					this.vmethod_34().method_3(null);
					this.vmethod_18().method_0(null, scenario_0);
					return;
				}
				if (Client.smethod_54() != null)
				{
					try
					{
						this.bool_1 = true;
						this.vmethod_8().IsEnabled = !Information.IsNothing(unit_0);
						if (!Information.IsNothing(scenario_0) && !Information.IsNothing(side_0) && !Information.IsNothing(unit_0))
						{
							if (unit_0.bool_0 && (unit_0.vmethod_7(false) == Client.smethod_50() || Client.smethod_52().method_1()))
							{
								if (unit_0.bool_1)
								{
									this.vmethod_8().Header = "GROUP STATUS";
									this.vmethod_12().Header = "GROUP ALT / SPEED";
									this.vmethod_20().Header = "GROUP WEAPONS";
									this.vmethod_24().Header = "GROUP FUEL";
									this.vmethod_28().Header = "GROUP EMCON";
								}
								else
								{
									this.vmethod_8().Header = "UNIT STATUS";
									this.vmethod_12().Header = "UNIT ALT / SPEED";
									this.vmethod_20().Header = "UNIT WEAPONS";
									this.vmethod_24().Header = "UNIT FUEL";
									this.vmethod_28().Header = "UNIT EMCON";
								}
								bool isExpanded = this.vmethod_20().IsExpanded;
								bool flag3;
								this.vmethod_22().method_0((ActiveUnit)unit_0, ref flag3, ref isExpanded);
								if (this.vmethod_20().IsExpanded != isExpanded && isExpanded)
								{
									this.vmethod_20().IsExpanded = true;
									this.vmethod_20().IsExpanded = false;
								}
								if (flag3)
								{
									this.vmethod_20().Visibility = Visibility.Visible;
								}
								else
								{
									this.vmethod_20().Visibility = Visibility.Collapsed;
								}
								this.vmethod_28().Visibility = Visibility.Visible;
								this.vmethod_32().Visibility = Visibility.Visible;
								this.vmethod_12().Visibility = Visibility.Visible;
								this.vmethod_30().method_0((ActiveUnit)unit_0);
								this.vmethod_34().method_3((ActiveUnit)unit_0);
								if (unit_0.bool_6 && ((Ship)unit_0).method_151())
								{
									this.vmethod_26().method_0(null);
									this.vmethod_24().Visibility = Visibility.Collapsed;
								}
								else if (unit_0.bool_5 && (((Submarine)unit_0).method_160() || Enumerable.Count<FuelRec>(((Submarine)unit_0).vmethod_67()) == 0))
								{
									this.vmethod_26().method_0(null);
									this.vmethod_24().Visibility = Visibility.Collapsed;
								}
								else if (unit_0.bool_8)
								{
									this.vmethod_26().method_0(null);
									this.vmethod_24().Visibility = Visibility.Collapsed;
									this.vmethod_12().Visibility = Visibility.Collapsed;
								}
								else if (unit_0.bool_2)
								{
									this.vmethod_26().method_0(null);
									this.vmethod_24().Visibility = Visibility.Collapsed;
									this.vmethod_12().Visibility = Visibility.Collapsed;
								}
								else if (unit_0.method_1())
								{
									this.vmethod_26().method_0(null);
									this.vmethod_24().Visibility = Visibility.Collapsed;
									this.vmethod_12().Visibility = Visibility.Collapsed;
								}
								else
								{
									this.vmethod_26().method_0((ActiveUnit)unit_0);
									this.vmethod_24().Visibility = Visibility.Visible;
								}
								if (!this.vmethod_24().IsExpanded)
								{
									this.vmethod_24().IsExpanded = true;
									this.vmethod_24().IsExpanded = false;
								}
								else
								{
									this.vmethod_24().IsExpanded = false;
									this.vmethod_24().IsExpanded = true;
								}
								if (!this.vmethod_12().IsExpanded)
								{
									this.vmethod_12().IsExpanded = true;
									this.vmethod_12().IsExpanded = false;
								}
								else
								{
									this.vmethod_12().IsExpanded = false;
									this.vmethod_12().IsExpanded = true;
								}
							}
							else if (unit_0.method_14())
							{
								this.vmethod_8().Header = "Contact Status";
								this.vmethod_20().Visibility = Visibility.Collapsed;
								this.vmethod_24().Visibility = Visibility.Collapsed;
								this.vmethod_28().Visibility = Visibility.Collapsed;
								this.vmethod_32().Visibility = Visibility.Collapsed;
								this.vmethod_12().Visibility = Visibility.Collapsed;
								this.vmethod_26().method_0(null);
								UnitWeapons_WPF unitWeapons_WPF2 = this.vmethod_22();
								ActiveUnit theUnit2 = null;
								bool flag2 = false;
								bool flag3;
								unitWeapons_WPF2.method_0(theUnit2, ref flag3, ref flag2);
								this.vmethod_30().method_0(null);
								this.vmethod_34().method_3(null);
							}
							else
							{
								this.vmethod_20().Visibility = Visibility.Collapsed;
								this.vmethod_24().Visibility = Visibility.Collapsed;
								this.vmethod_28().Visibility = Visibility.Collapsed;
								this.vmethod_32().Visibility = Visibility.Collapsed;
								this.vmethod_12().Visibility = Visibility.Collapsed;
								this.vmethod_26().method_0(null);
								UnitWeapons_WPF unitWeapons_WPF3 = this.vmethod_22();
								ActiveUnit theUnit3 = null;
								bool flag2 = false;
								bool flag3;
								unitWeapons_WPF3.method_0(theUnit3, ref flag3, ref flag2);
								this.vmethod_30().method_0(null);
								this.vmethod_34().method_3(null);
							}
							if (unit_0.method_14())
							{
								this.vmethod_16().Visibility = Visibility.Visible;
								this.vmethod_12().Visibility = Visibility.Collapsed;
								if (this.vmethod_16().IsExpanded)
								{
									this.vmethod_18().method_0((Contact)unit_0, scenario_0);
								}
							}
							else
							{
								this.vmethod_16().Visibility = Visibility.Collapsed;
							}
							if (this.vmethod_8().IsExpanded)
							{
								this.vmethod_10().method_6(scenario_0, side_0, unit_0);
							}
						}
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 999999", "");
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
					finally
					{
						this.bool_1 = false;
					}
				}
			}
		}

		// Token: 0x06005C9C RID: 23708 RVA: 0x0032DE7C File Offset: 0x0032C07C
		public double method_3(UIElement uielement_0)
		{
			PresentationSource presentationSource = PresentationSource.FromVisual(uielement_0);
			Matrix transformToDevice;
			if (presentationSource != null)
			{
				transformToDevice = presentationSource.CompositionTarget.TransformToDevice;
			}
			else
			{
				using (HwndSource hwndSource = new HwndSource(default(HwndSourceParameters)))
				{
					transformToDevice = hwndSource.CompositionTarget.TransformToDevice;
				}
			}
			return transformToDevice.M11;
		}

		// Token: 0x06005C9D RID: 23709 RVA: 0x0032DEE0 File Offset: 0x0032C0E0
		public void method_4(MainForm mainForm_0)
		{
			if (!Information.IsNothing(Client.elementHost_0))
			{
				double num = this.method_3(this);
				this.vmethod_0().MaxHeight = (double)(mainForm_0.vmethod_796().Height + 110) / num;
				if (!this.bool_2)
				{
					this.bool_2 = true;
					Client.elementHost_0.Width = (int)Math.Round(270.0 * num);
				}
				MainForm mainForm = (MainForm)Client.elementHost_0.Parent;
				if (mainForm != null)
				{
					int width = mainForm.Size.Width;
					int width2 = Client.elementHost_0.Width;
					Client.elementHost_0.Left = width - width2 - 14;
					Client.elementHost_0.Top = mainForm.vmethod_6().Top;
				}
			}
		}

		// Token: 0x06005C9E RID: 23710 RVA: 0x0032DFA0 File Offset: 0x0032C1A0
		private void StackPanel_Main_LayoutUpdated(object sender, EventArgs e)
		{
			if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
			{
				double actualHeight = this.vmethod_6().ActualHeight;
				if (Client.elementHost_0 != null)
				{
					if (actualHeight > (double)(Class2413.smethod_2().method_41().vmethod_796().Height - 75))
					{
						this.vmethod_0().VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
					}
					if (actualHeight < (double)(Class2413.smethod_2().method_41().vmethod_796().Height - 75) * 0.9)
					{
						this.vmethod_0().VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
					}
				}
			}
		}

		// Token: 0x06005C9F RID: 23711 RVA: 0x0003B850 File Offset: 0x00039A50
		private void Expander_UnitStatus_Expanded(object sender, RoutedEventArgs e)
		{
			if (!this.bool_1)
			{
				this.method_2(Client.smethod_46(), Client.smethod_50(), Client.smethod_54());
			}
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x0003B850 File Offset: 0x00039A50
		private void Expander_UnitWeapons_Expanded(object sender, RoutedEventArgs e)
		{
			if (!this.bool_1)
			{
				this.method_2(Client.smethod_46(), Client.smethod_50(), Client.smethod_54());
			}
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x0003B850 File Offset: 0x00039A50
		private void Expander_UnitFuel_Expanded(object sender, RoutedEventArgs e)
		{
			if (!this.bool_1)
			{
				this.method_2(Client.smethod_46(), Client.smethod_50(), Client.smethod_54());
			}
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x0003B850 File Offset: 0x00039A50
		private void Expander_UnitEMCON_Expanded(object sender, RoutedEventArgs e)
		{
			if (!this.bool_1)
			{
				this.method_2(Client.smethod_46(), Client.smethod_50(), Client.smethod_54());
			}
		}

		// Token: 0x06005CA3 RID: 23715 RVA: 0x0003B850 File Offset: 0x00039A50
		private void Expander_UnitDoctrine_Expanded(object sender, RoutedEventArgs e)
		{
			if (!this.bool_1)
			{
				this.method_2(Client.smethod_46(), Client.smethod_50(), Client.smethod_54());
			}
		}

		// Token: 0x06005CA4 RID: 23716 RVA: 0x0003B86F File Offset: 0x00039A6F
		[CompilerGenerated]
		internal ScrollViewer vmethod_0()
		{
			return this.scrollViewer_0;
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x0003B877 File Offset: 0x00039A77
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ScrollViewer scrollViewer_1)
		{
			this.scrollViewer_0 = scrollViewer_1;
		}

		// Token: 0x06005CA6 RID: 23718 RVA: 0x0003B880 File Offset: 0x00039A80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_2(Grid grid_1)
		{
			this.grid_0 = grid_1;
		}

		// Token: 0x06005CA7 RID: 23719 RVA: 0x0003B889 File Offset: 0x00039A89
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(RowDefinition rowDefinition_2)
		{
			this.rowDefinition_0 = rowDefinition_2;
		}

		// Token: 0x06005CA8 RID: 23720 RVA: 0x0003B892 File Offset: 0x00039A92
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_4(RowDefinition rowDefinition_2)
		{
			this.rowDefinition_1 = rowDefinition_2;
		}

		// Token: 0x06005CA9 RID: 23721 RVA: 0x0003B89B File Offset: 0x00039A9B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ColumnDefinition columnDefinition_1)
		{
			this.columnDefinition_0 = columnDefinition_1;
		}

		// Token: 0x06005CAA RID: 23722 RVA: 0x0003B8A4 File Offset: 0x00039AA4
		[CompilerGenerated]
		internal StackPanel vmethod_6()
		{
			return this.stackPanel_0;
		}

		// Token: 0x06005CAB RID: 23723 RVA: 0x0003B8AC File Offset: 0x00039AAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(StackPanel stackPanel_1)
		{
			this.stackPanel_0 = stackPanel_1;
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x0003B8B5 File Offset: 0x00039AB5
		[CompilerGenerated]
		internal OdcExpander vmethod_8()
		{
			return this.odcExpander_0;
		}

		// Token: 0x06005CAD RID: 23725 RVA: 0x0032E020 File Offset: 0x0032C220
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(OdcExpander odcExpander_7)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Expander_UnitStatus_Expanded);
			OdcExpander odcExpander = this.odcExpander_0;
			if (odcExpander != null)
			{
				odcExpander.Expanded -= value;
			}
			this.odcExpander_0 = odcExpander_7;
			odcExpander = this.odcExpander_0;
			if (odcExpander != null)
			{
				odcExpander.Expanded += value;
			}
		}

		// Token: 0x06005CAE RID: 23726 RVA: 0x0003B8BD File Offset: 0x00039ABD
		[CompilerGenerated]
		internal UnitStatus_WPF vmethod_10()
		{
			return this.unitStatus_WPF_0;
		}

		// Token: 0x06005CAF RID: 23727 RVA: 0x0003B8C5 File Offset: 0x00039AC5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(UnitStatus_WPF unitStatus_WPF_1)
		{
			this.unitStatus_WPF_0 = unitStatus_WPF_1;
		}

		// Token: 0x06005CB0 RID: 23728 RVA: 0x0003B8CE File Offset: 0x00039ACE
		[CompilerGenerated]
		internal OdcExpander vmethod_12()
		{
			return this.odcExpander_1;
		}

		// Token: 0x06005CB1 RID: 23729 RVA: 0x0003B8D6 File Offset: 0x00039AD6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(OdcExpander odcExpander_7)
		{
			this.odcExpander_1 = odcExpander_7;
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x0003B8DF File Offset: 0x00039ADF
		[CompilerGenerated]
		internal UnitSpeedAlt vmethod_14()
		{
			return this.unitSpeedAlt_0;
		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x0003B8E7 File Offset: 0x00039AE7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(UnitSpeedAlt unitSpeedAlt_1)
		{
			this.unitSpeedAlt_0 = unitSpeedAlt_1;
		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x0003B8F0 File Offset: 0x00039AF0
		[CompilerGenerated]
		internal OdcExpander vmethod_16()
		{
			return this.odcExpander_2;
		}

		// Token: 0x06005CB5 RID: 23733 RVA: 0x0003B8F8 File Offset: 0x00039AF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(OdcExpander odcExpander_7)
		{
			this.odcExpander_2 = odcExpander_7;
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x0003B901 File Offset: 0x00039B01
		[CompilerGenerated]
		internal RecentDetections_WPF vmethod_18()
		{
			return this.recentDetections_WPF_0;
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x0003B909 File Offset: 0x00039B09
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(RecentDetections_WPF recentDetections_WPF_1)
		{
			this.recentDetections_WPF_0 = recentDetections_WPF_1;
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x0003B912 File Offset: 0x00039B12
		[CompilerGenerated]
		internal OdcExpander vmethod_20()
		{
			return this.odcExpander_3;
		}

		// Token: 0x06005CB9 RID: 23737 RVA: 0x0032E064 File Offset: 0x0032C264
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(OdcExpander odcExpander_7)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Expander_UnitWeapons_Expanded);
			OdcExpander odcExpander = this.odcExpander_3;
			if (odcExpander != null)
			{
				odcExpander.Expanded -= value;
			}
			this.odcExpander_3 = odcExpander_7;
			odcExpander = this.odcExpander_3;
			if (odcExpander != null)
			{
				odcExpander.Expanded += value;
			}
		}

		// Token: 0x06005CBA RID: 23738 RVA: 0x0003B91A File Offset: 0x00039B1A
		[CompilerGenerated]
		internal UnitWeapons_WPF vmethod_22()
		{
			return this.unitWeapons_WPF_0;
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x0003B922 File Offset: 0x00039B22
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(UnitWeapons_WPF unitWeapons_WPF_1)
		{
			this.unitWeapons_WPF_0 = unitWeapons_WPF_1;
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x0003B92B File Offset: 0x00039B2B
		[CompilerGenerated]
		internal OdcExpander vmethod_24()
		{
			return this.odcExpander_4;
		}

		// Token: 0x06005CBD RID: 23741 RVA: 0x0032E0A8 File Offset: 0x0032C2A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(OdcExpander odcExpander_7)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Expander_UnitFuel_Expanded);
			OdcExpander odcExpander = this.odcExpander_4;
			if (odcExpander != null)
			{
				odcExpander.Expanded -= value;
			}
			this.odcExpander_4 = odcExpander_7;
			odcExpander = this.odcExpander_4;
			if (odcExpander != null)
			{
				odcExpander.Expanded += value;
			}
		}

		// Token: 0x06005CBE RID: 23742 RVA: 0x0003B933 File Offset: 0x00039B33
		[CompilerGenerated]
		internal FuelPanel_WPF vmethod_26()
		{
			return this.fuelPanel_WPF_0;
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x0003B93B File Offset: 0x00039B3B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(FuelPanel_WPF fuelPanel_WPF_1)
		{
			this.fuelPanel_WPF_0 = fuelPanel_WPF_1;
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x0003B944 File Offset: 0x00039B44
		[CompilerGenerated]
		internal OdcExpander vmethod_28()
		{
			return this.odcExpander_5;
		}

		// Token: 0x06005CC1 RID: 23745 RVA: 0x0032E0EC File Offset: 0x0032C2EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(OdcExpander odcExpander_7)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Expander_UnitEMCON_Expanded);
			OdcExpander odcExpander = this.odcExpander_5;
			if (odcExpander != null)
			{
				odcExpander.Expanded -= value;
			}
			this.odcExpander_5 = odcExpander_7;
			odcExpander = this.odcExpander_5;
			if (odcExpander != null)
			{
				odcExpander.Expanded += value;
			}
		}

		// Token: 0x06005CC2 RID: 23746 RVA: 0x0003B94C File Offset: 0x00039B4C
		[CompilerGenerated]
		internal UnitEMCON_WPF vmethod_30()
		{
			return this.unitEMCON_WPF_0;
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x0003B954 File Offset: 0x00039B54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(UnitEMCON_WPF unitEMCON_WPF_1)
		{
			this.unitEMCON_WPF_0 = unitEMCON_WPF_1;
		}

		// Token: 0x06005CC4 RID: 23748 RVA: 0x0003B95D File Offset: 0x00039B5D
		[CompilerGenerated]
		internal OdcExpander vmethod_32()
		{
			return this.odcExpander_6;
		}

		// Token: 0x06005CC5 RID: 23749 RVA: 0x0032E130 File Offset: 0x0032C330
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(OdcExpander odcExpander_7)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Expander_UnitDoctrine_Expanded);
			OdcExpander odcExpander = this.odcExpander_6;
			if (odcExpander != null)
			{
				odcExpander.Expanded -= value;
			}
			this.odcExpander_6 = odcExpander_7;
			odcExpander = this.odcExpander_6;
			if (odcExpander != null)
			{
				odcExpander.Expanded += value;
			}
		}

		// Token: 0x06005CC6 RID: 23750 RVA: 0x0003B965 File Offset: 0x00039B65
		[CompilerGenerated]
		internal UnitDoctrine_WPF vmethod_34()
		{
			return this.unitDoctrine_WPF_0;
		}

		// Token: 0x06005CC7 RID: 23751 RVA: 0x0003B96D File Offset: 0x00039B6D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(UnitDoctrine_WPF unitDoctrine_WPF_1)
		{
			this.unitDoctrine_WPF_0 = unitDoctrine_WPF_1;
		}

		// Token: 0x06005CC8 RID: 23752 RVA: 0x0032E174 File Offset: 0x0032C374
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_3)
			{
				this.bool_3 = true;
				Uri resourceLocator = new Uri("/Command;component/customcontrols/rightcolumn/rightcolumnwpf.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06005CC9 RID: 23753 RVA: 0x0032E1A4 File Offset: 0x0032C3A4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.vmethod_1((ScrollViewer)target);
				return;
			}
			if (connectionId == 2)
			{
				this.vmethod_2((Grid)target);
				return;
			}
			if (connectionId == 3)
			{
				this.vmethod_3((RowDefinition)target);
				return;
			}
			if (connectionId == 4)
			{
				this.vmethod_4((RowDefinition)target);
				return;
			}
			if (connectionId == 5)
			{
				this.vmethod_5((ColumnDefinition)target);
				return;
			}
			if (connectionId == 6)
			{
				this.vmethod_7((StackPanel)target);
				this.vmethod_6().LayoutUpdated += this.StackPanel_Main_LayoutUpdated;
				return;
			}
			if (connectionId == 7)
			{
				this.vmethod_9((OdcExpander)target);
				return;
			}
			if (connectionId == 8)
			{
				this.vmethod_11((UnitStatus_WPF)target);
				return;
			}
			if (connectionId == 9)
			{
				this.vmethod_13((OdcExpander)target);
				return;
			}
			if (connectionId == 10)
			{
				this.vmethod_15((UnitSpeedAlt)target);
				return;
			}
			if (connectionId == 11)
			{
				this.vmethod_17((OdcExpander)target);
				return;
			}
			if (connectionId == 12)
			{
				this.vmethod_19((RecentDetections_WPF)target);
				return;
			}
			if (connectionId == 13)
			{
				this.vmethod_21((OdcExpander)target);
				return;
			}
			if (connectionId == 14)
			{
				this.vmethod_23((UnitWeapons_WPF)target);
				return;
			}
			if (connectionId == 15)
			{
				this.vmethod_25((OdcExpander)target);
				return;
			}
			if (connectionId == 16)
			{
				this.vmethod_27((FuelPanel_WPF)target);
				return;
			}
			if (connectionId == 17)
			{
				this.vmethod_29((OdcExpander)target);
				return;
			}
			if (connectionId == 18)
			{
				this.vmethod_31((UnitEMCON_WPF)target);
				return;
			}
			if (connectionId == 19)
			{
				this.vmethod_33((OdcExpander)target);
				return;
			}
			if (connectionId == 20)
			{
				this.vmethod_35((UnitDoctrine_WPF)target);
				return;
			}
			this.bool_3 = true;
		}

		// Token: 0x040035F4 RID: 13812
		private bool bool_0;

		// Token: 0x040035F5 RID: 13813
		public bool bool_1;

		// Token: 0x040035F6 RID: 13814
		private bool bool_2;

		// Token: 0x040035F7 RID: 13815
		[CompilerGenerated]
		[AccessedThroughProperty("MyScrollViewer")]
		private ScrollViewer scrollViewer_0;

		// Token: 0x040035F8 RID: 13816
		[AccessedThroughProperty("MyGrid")]
		[CompilerGenerated]
		private Grid grid_0;

		// Token: 0x040035F9 RID: 13817
		[CompilerGenerated]
		[AccessedThroughProperty("RowDefinition_UsedSpace")]
		private RowDefinition rowDefinition_0;

		// Token: 0x040035FA RID: 13818
		[CompilerGenerated]
		[AccessedThroughProperty("RowDefinition_ExtraSpace")]
		private RowDefinition rowDefinition_1;

		// Token: 0x040035FB RID: 13819
		[AccessedThroughProperty("ColumnDefinition_UsedSpace")]
		[CompilerGenerated]
		private ColumnDefinition columnDefinition_0;

		// Token: 0x040035FC RID: 13820
		[AccessedThroughProperty("StackPanel_Main")]
		[CompilerGenerated]
		private StackPanel stackPanel_0;

		// Token: 0x040035FD RID: 13821
		[AccessedThroughProperty("Expander_UnitStatus")]
		[CompilerGenerated]
		private OdcExpander odcExpander_0;

		// Token: 0x040035FE RID: 13822
		[CompilerGenerated]
		[AccessedThroughProperty("WPFControl_UnitStatus")]
		private UnitStatus_WPF unitStatus_WPF_0;

		// Token: 0x040035FF RID: 13823
		[CompilerGenerated]
		[AccessedThroughProperty("Expander_AltSpeed")]
		private OdcExpander odcExpander_1;

		// Token: 0x04003600 RID: 13824
		[CompilerGenerated]
		[AccessedThroughProperty("WPFControl_AltSpeed")]
		private UnitSpeedAlt unitSpeedAlt_0;

		// Token: 0x04003601 RID: 13825
		[AccessedThroughProperty("Expander_ContactLastDetections")]
		[CompilerGenerated]
		private OdcExpander odcExpander_2;

		// Token: 0x04003602 RID: 13826
		[CompilerGenerated]
		[AccessedThroughProperty("WPFControl_RecentDetections")]
		private RecentDetections_WPF recentDetections_WPF_0;

		// Token: 0x04003603 RID: 13827
		[CompilerGenerated]
		[AccessedThroughProperty("Expander_UnitWeapons")]
		private OdcExpander odcExpander_3;

		// Token: 0x04003604 RID: 13828
		[AccessedThroughProperty("WPFControl_UnitWeapons")]
		[CompilerGenerated]
		private UnitWeapons_WPF unitWeapons_WPF_0;

		// Token: 0x04003605 RID: 13829
		[CompilerGenerated]
		[AccessedThroughProperty("Expander_UnitFuel")]
		private OdcExpander odcExpander_4;

		// Token: 0x04003606 RID: 13830
		[AccessedThroughProperty("WPFControl_FuelPanel")]
		[CompilerGenerated]
		private FuelPanel_WPF fuelPanel_WPF_0;

		// Token: 0x04003607 RID: 13831
		[AccessedThroughProperty("Expander_UnitEMCON")]
		[CompilerGenerated]
		private OdcExpander odcExpander_5;

		// Token: 0x04003608 RID: 13832
		[CompilerGenerated]
		[AccessedThroughProperty("WPFControl_UnitEMCON")]
		private UnitEMCON_WPF unitEMCON_WPF_0;

		// Token: 0x04003609 RID: 13833
		[AccessedThroughProperty("Expander_UnitDoctrine")]
		[CompilerGenerated]
		private OdcExpander odcExpander_6;

		// Token: 0x0400360A RID: 13834
		[AccessedThroughProperty("WPFControl_UnitDoctrine")]
		[CompilerGenerated]
		private UnitDoctrine_WPF unitDoctrine_WPF_0;

		// Token: 0x0400360B RID: 13835
		private bool bool_3;
	}
}
