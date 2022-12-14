using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns13;
using ns14;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000E60 RID: 3680
	[DesignerGenerated]
	public sealed class UnitStatus_WPF : System.Windows.Controls.UserControl, IComponentConnector
	{
		// Token: 0x06007004 RID: 28676 RVA: 0x003C67D0 File Offset: 0x003C49D0
		[CompilerGenerated]
		public static void smethod_0(UnitStatus_WPF.Delegate91 delegate91_1)
		{
			UnitStatus_WPF.Delegate91 @delegate = UnitStatus_WPF.delegate91_0;
			UnitStatus_WPF.Delegate91 delegate2;
			do
			{
				delegate2 = @delegate;
				UnitStatus_WPF.Delegate91 value = (UnitStatus_WPF.Delegate91)Delegate.Combine(delegate2, delegate91_1);
				@delegate = Interlocked.CompareExchange<UnitStatus_WPF.Delegate91>(ref UnitStatus_WPF.delegate91_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06007005 RID: 28677 RVA: 0x003C6804 File Offset: 0x003C4A04
		[CompilerGenerated]
		public static void smethod_1(UnitStatus_WPF.Delegate92 delegate92_1)
		{
			UnitStatus_WPF.Delegate92 @delegate = UnitStatus_WPF.delegate92_0;
			UnitStatus_WPF.Delegate92 delegate2;
			do
			{
				delegate2 = @delegate;
				UnitStatus_WPF.Delegate92 value = (UnitStatus_WPF.Delegate92)Delegate.Combine(delegate2, delegate92_1);
				@delegate = Interlocked.CompareExchange<UnitStatus_WPF.Delegate92>(ref UnitStatus_WPF.delegate92_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06007006 RID: 28678 RVA: 0x003C6838 File Offset: 0x003C4A38
		[CompilerGenerated]
		public static void smethod_2(UnitStatus_WPF.Delegate93 delegate93_1)
		{
			UnitStatus_WPF.Delegate93 @delegate = UnitStatus_WPF.delegate93_0;
			UnitStatus_WPF.Delegate93 delegate2;
			do
			{
				delegate2 = @delegate;
				UnitStatus_WPF.Delegate93 value = (UnitStatus_WPF.Delegate93)Delegate.Combine(delegate2, delegate93_1);
				@delegate = Interlocked.CompareExchange<UnitStatus_WPF.Delegate93>(ref UnitStatus_WPF.delegate93_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06007007 RID: 28679 RVA: 0x003C686C File Offset: 0x003C4A6C
		[CompilerGenerated]
		public static void smethod_3(UnitStatus_WPF.Delegate94 delegate94_1)
		{
			UnitStatus_WPF.Delegate94 @delegate = UnitStatus_WPF.delegate94_0;
			UnitStatus_WPF.Delegate94 delegate2;
			do
			{
				delegate2 = @delegate;
				UnitStatus_WPF.Delegate94 value = (UnitStatus_WPF.Delegate94)Delegate.Combine(delegate2, delegate94_1);
				@delegate = Interlocked.CompareExchange<UnitStatus_WPF.Delegate94>(ref UnitStatus_WPF.delegate94_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06007008 RID: 28680 RVA: 0x003C68A0 File Offset: 0x003C4AA0
		public UnitStatus_WPF()
		{
			base.SizeChanged += this.UnitStatus_WPF_SizeChanged;
			base.Loaded += this.UnitStatus_WPF_Loaded;
			this.string_0 = "";
			this.vmethod_1(new BackgroundWorker());
			this.InitializeComponent();
		}

		// Token: 0x06007009 RID: 28681 RVA: 0x003C68F4 File Offset: 0x003C4AF4
		private void method_0(ActiveUnit activeUnit_0)
		{
			if (activeUnit_0.vmethod_120().Count == 0)
			{
				this.vmethod_54().Width = 0.0;
				this.vmethod_56().Width = 0.0;
				this.vmethod_58().Width = 0.0;
				this.vmethod_60().Width = 0.0;
				this.vmethod_62().Width = 0.0;
				return;
			}
			int num = (int)Math.Round(base.ActualWidth * 0.6666666666666666);
			int num2;
			int num3;
			int num4;
			int num5;
			int num6;
			try
			{
				foreach (PlatformComponent platformComponent in activeUnit_0.vmethod_120())
				{
					switch (platformComponent.vmethod_5())
					{
					case PlatformComponent._ComponentStatus.Operational:
						num2++;
						break;
					case PlatformComponent._ComponentStatus.Damaged:
						switch (platformComponent.method_16())
						{
						case PlatformComponent._DamageSeverityFactor.Light:
							num3++;
							break;
						case PlatformComponent._DamageSeverityFactor.Medium:
							num4++;
							break;
						case PlatformComponent._DamageSeverityFactor.Heavy:
							num5++;
							break;
						}
						break;
					case PlatformComponent._ComponentStatus.Destroyed:
						num6++;
						break;
					}
				}
			}
			finally
			{
				IEnumerator<PlatformComponent> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				if (num6 > 0)
				{
					this.vmethod_54().Width = (double)((int)Math.Round((double)(num * num6) / (double)activeUnit_0.vmethod_120().Count));
				}
				else
				{
					this.vmethod_54().Width = 0.0;
				}
				if (num5 > 0)
				{
					this.vmethod_56().Width = (double)((int)Math.Round((double)(num * num5) / (double)activeUnit_0.vmethod_120().Count));
				}
				else
				{
					this.vmethod_56().Width = 0.0;
				}
				if (num4 > 0)
				{
					this.vmethod_58().Width = (double)((int)Math.Round((double)(num * num4) / (double)activeUnit_0.vmethod_120().Count));
				}
				else
				{
					this.vmethod_58().Width = 0.0;
				}
				if (num3 > 0)
				{
					this.vmethod_60().Width = (double)((int)Math.Round((double)(num * num3) / (double)activeUnit_0.vmethod_120().Count));
				}
				else
				{
					this.vmethod_60().Width = 0.0;
				}
				if (num2 > 0)
				{
					this.vmethod_62().Width = (double)((int)Math.Round((double)(num * num2) / (double)activeUnit_0.vmethod_120().Count));
				}
				else
				{
					this.vmethod_62().Width = 0.0;
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600700A RID: 28682 RVA: 0x000468A5 File Offset: 0x00044AA5
		[CompilerGenerated]
		private BackgroundWorker vmethod_0()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x0600700B RID: 28683 RVA: 0x003C6BA0 File Offset: 0x003C4DA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_1(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler doWorkEventHandler = new DoWorkEventHandler(this.theBW_DoWork);
			RunWorkerCompletedEventHandler runWorkerCompletedEventHandler = new RunWorkerCompletedEventHandler(this.theBW_RunWorkerCompleted);
			BackgroundWorker backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted -= runWorkerCompletedEventHandler;
			}
			this.backgroundWorker_0 = backgroundWorker_1;
			backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted += runWorkerCompletedEventHandler;
			}
		}

		// Token: 0x0600700C RID: 28684 RVA: 0x003C6C00 File Offset: 0x003C4E00
		private void method_1(ActiveUnit activeUnit_0)
		{
			try
			{
				this.string_1 = Class2564.smethod_2(activeUnit_0);
				this.bitmapImage_1 = Class2564.smethod_0(this.string_1);
				if (this.bitmapImage_1 != null)
				{
					this.method_2();
				}
				else if (!this.vmethod_0().IsBusy)
				{
					this.vmethod_0().RunWorkerAsync();
				}
			}
			catch (Exception ex)
			{
				if (this.vmethod_6().Source != null)
				{
					this.vmethod_6().Source = null;
					this.vmethod_6().Visibility = Visibility.Collapsed;
				}
				ex.Data.Add("Error at 200371", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600700D RID: 28685 RVA: 0x000468AD File Offset: 0x00044AAD
		private void theBW_DoWork(object sender, DoWorkEventArgs e)
		{
			Class2564.smethod_6(this.string_1);
		}

		// Token: 0x0600700E RID: 28686 RVA: 0x000468BB File Offset: 0x00044ABB
		private void theBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.method_2();
		}

		// Token: 0x0600700F RID: 28687 RVA: 0x003C6CC0 File Offset: 0x003C4EC0
		private void method_2()
		{
			if (Operators.CompareString(this.string_0, this.string_1, false) != 0 || Information.IsNothing(this.vmethod_6().Source))
			{
				if (Class570.class280_0.method_42())
				{
					if (Information.IsNothing(this.bitmapImage_1) & !Information.IsNothing(this.bitmapImage_0))
					{
						this.vmethod_6().Source = null;
						this.vmethod_6().Visibility = Visibility.Collapsed;
						this.bitmapImage_0 = null;
					}
					else if (!(Information.IsNothing(this.bitmapImage_1) & Information.IsNothing(this.bitmapImage_0)))
					{
						if (!Information.IsNothing(this.bitmapImage_1) && !Information.IsNothing(this.bitmapImage_0) && Operators.CompareString(this.bitmapImage_1.ToString(), this.bitmapImage_0.ToString(), false) == 0)
						{
							this.vmethod_6().Visibility = Visibility.Visible;
							if (Information.IsNothing(this.vmethod_6().Source))
							{
								this.vmethod_6().Source = this.bitmapImage_1;
							}
						}
						else
						{
							this.vmethod_6().Source = this.bitmapImage_1;
							this.vmethod_6().Visibility = Visibility.Visible;
							this.bitmapImage_0 = this.bitmapImage_1;
						}
					}
				}
				else if (!Information.IsNothing(this.bitmapImage_0))
				{
					this.vmethod_6().Source = null;
					this.vmethod_6().Visibility = Visibility.Collapsed;
					this.bitmapImage_0 = null;
				}
				this.string_0 = this.string_1;
			}
		}

		// Token: 0x06007010 RID: 28688 RVA: 0x003C6E30 File Offset: 0x003C5030
		private void method_3(Scenario scenario_0, Side side_0, Unit unit_0)
		{
			this.method_9(Visibility.Collapsed);
			this.vmethod_32().Visibility = Visibility.Collapsed;
			this.vmethod_28().Visibility = Visibility.Collapsed;
			this.vmethod_102().Visibility = Visibility.Collapsed;
			this.vmethod_100().Visibility = Visibility.Collapsed;
			this.vmethod_24().Visibility = Visibility.Visible;
			this.vmethod_108().Visibility = Visibility.Hidden;
			this.vmethod_76().Visibility = Visibility.Collapsed;
			this.method_10(Visibility.Collapsed);
			this.vmethod_22().Visibility = Visibility.Collapsed;
			this.vmethod_48().Visibility = Visibility.Collapsed;
			this.method_11(Visibility.Collapsed);
			this.method_12(Visibility.Collapsed);
			this.vmethod_78().Visibility = Visibility.Collapsed;
			this.vmethod_26().Visibility = Visibility.Collapsed;
			this.vmethod_72().Visibility = Visibility.Collapsed;
			this.vmethod_74().Visibility = Visibility.Collapsed;
			this.vmethod_86().Visibility = Visibility.Collapsed;
			Contact contact = (Contact)unit_0;
			if (contact.activeUnit_0 != null && (side_0.method_11().ContainsKey(contact.activeUnit_0.string_0) || side_0.method_12().ContainsKey(contact.activeUnit_0.string_0)))
			{
				this.vmethod_4().Content = contact.Name;
				switch (contact.method_125())
				{
				case Contact_Base.IdentificationStatus.Unknown:
					this.vmethod_14().Visibility = Visibility.Collapsed;
					this.vmethod_8().Visibility = Visibility.Collapsed;
					this.vmethod_10().IsEnabled = false;
					this.vmethod_6().Source = null;
					this.vmethod_6().Visibility = Visibility.Collapsed;
					break;
				case Contact_Base.IdentificationStatus.KnownDomain:
					this.vmethod_14().Visibility = Visibility.Visible;
					this.vmethod_16().Text = contact.method_71();
					this.vmethod_8().Visibility = Visibility.Collapsed;
					this.vmethod_10().IsEnabled = false;
					this.vmethod_6().Source = null;
					this.vmethod_6().Visibility = Visibility.Collapsed;
					break;
				case Contact_Base.IdentificationStatus.KnownType:
					this.vmethod_14().Visibility = Visibility.Visible;
					if (contact.activeUnit_0.bool_8)
					{
						Facility facility = (Facility)contact.activeUnit_0;
						this.vmethod_16().Text = facility.method_142();
					}
					else
					{
						this.vmethod_16().Text = contact.activeUnit_0.vmethod_58();
					}
					this.vmethod_8().Visibility = Visibility.Collapsed;
					this.vmethod_10().IsEnabled = false;
					this.vmethod_6().Source = null;
					this.vmethod_6().Visibility = Visibility.Collapsed;
					break;
				case Contact_Base.IdentificationStatus.KnownClass:
				case Contact_Base.IdentificationStatus.PreciseID:
					this.vmethod_14().Visibility = Visibility.Visible;
					if (contact.activeUnit_0.bool_8)
					{
						Facility facility2 = (Facility)contact.activeUnit_0;
						this.vmethod_16().Text = facility2.method_142();
					}
					else
					{
						this.vmethod_16().Text = contact.activeUnit_0.vmethod_58();
					}
					this.vmethod_8().Visibility = Visibility.Visible;
					this.vmethod_12().Text = Misc.smethod_9(contact.activeUnit_0.string_2);
					this.vmethod_10().IsEnabled = true;
					if (!(contact.contactType_0 == Contact_Base.ContactType.Installation | contact.contactType_0 == Contact_Base.ContactType.MobileGroup | contact.contactType_0 == Contact_Base.ContactType.AirBase | contact.contactType_0 == Contact_Base.ContactType.NavalBase))
					{
						this.method_1(contact.activeUnit_0);
					}
					else
					{
						this.vmethod_6().Source = null;
						this.vmethod_6().Visibility = Visibility.Collapsed;
					}
					break;
				}
				this.vmethod_36().Content = "Course: " + contact.method_88();
				if ((contact.contactType_0 == Contact_Base.ContactType.Air | contact.contactType_0 == Contact_Base.ContactType.Missile) & contact.bool_19)
				{
					this.vmethod_38().Content = string.Concat(new string[]
					{
						"Speed: ",
						Conversions.ToString((int)Math.Round((double)contact.vmethod_40())),
						" kts (M ",
						string.Format("{0:0.00}", Class437.smethod_0((double)contact.vmethod_14(false), (double)contact.vmethod_40())),
						")"
					});
				}
				else
				{
					this.vmethod_38().Content = "Speed: " + contact.method_89();
				}
				if (contact.bool_12)
				{
					if (!Information.IsNothing(contact.activeUnit_0.vmethod_7(false)))
					{
						this.vmethod_34().Content = "Side: " + contact.activeUnit_0.vmethod_7(false).method_51();
					}
				}
				else
				{
					this.vmethod_34().Content = "Side: Unknown";
				}
				if (contact.activeUnit_0.bool_6 | contact.activeUnit_0.bool_8)
				{
					this.vmethod_40().Content = "";
				}
				else
				{
					this.vmethod_40().Content = "Altitude: " + contact.method_90(Class570.class280_0.method_12());
				}
				this.method_13(Visibility.Collapsed);
				if (!contact.activeUnit_0.bool_3 && !contact.activeUnit_0.bool_2)
				{
					this.method_16(Visibility.Visible);
					this.method_15(Visibility.Visible);
					if (contact.activeUnit_0.bool_6 | contact.activeUnit_0.bool_5)
					{
						this.method_14(Visibility.Visible);
					}
					else
					{
						this.method_14(Visibility.Collapsed);
					}
					this.vmethod_46().Text = "BDA: " + Misc.smethod_54(contact.method_74(Client.smethod_50()));
					if (!contact.activeUnit_0.bool_6 && !contact.activeUnit_0.bool_5)
					{
						this.vmethod_68().Visibility = Visibility.Collapsed;
						this.vmethod_70().Visibility = Visibility.Collapsed;
					}
					else
					{
						this.vmethod_68().Visibility = Visibility.Visible;
						this.vmethod_70().Visibility = Visibility.Visible;
						if (contact.method_78(Client.smethod_50()) != null)
						{
							this.vmethod_68().Content = "Flood:";
							ActiveUnit_Damage.FloodingIntensityLevel? floodingIntensityLevel = contact.method_78(Client.smethod_50());
							byte? b = (floodingIntensityLevel != null) ? new byte?((byte)floodingIntensityLevel.GetValueOrDefault()) : null;
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								this.vmethod_70().Value = 0.0;
							}
							else
							{
								b = ((floodingIntensityLevel != null) ? new byte?((byte)floodingIntensityLevel.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									this.vmethod_70().Value = 25.0;
								}
								else
								{
									b = ((floodingIntensityLevel != null) ? new byte?((byte)floodingIntensityLevel.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										this.vmethod_70().Value = 50.0;
									}
									else
									{
										b = ((floodingIntensityLevel != null) ? new byte?((byte)floodingIntensityLevel.GetValueOrDefault()) : null);
										if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											this.vmethod_70().Value = 75.0;
										}
										else
										{
											b = ((floodingIntensityLevel != null) ? new byte?((byte)floodingIntensityLevel.GetValueOrDefault()) : null);
											if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
											{
												this.vmethod_70().Value = 100.0;
											}
										}
									}
								}
							}
						}
						else
						{
							this.vmethod_70().Visibility = Visibility.Collapsed;
							this.vmethod_68().Content = "Flood: UNKNOWN";
						}
					}
					this.vmethod_64().Visibility = Visibility.Visible;
					this.vmethod_66().Visibility = Visibility.Visible;
					if (contact.method_76(Client.smethod_50()) != null)
					{
						this.vmethod_64().Content = "Fire:";
						ActiveUnit_Damage.FireIntensityLevel? fireIntensityLevel = contact.method_76(Client.smethod_50());
						byte? b = (fireIntensityLevel != null) ? new byte?((byte)fireIntensityLevel.GetValueOrDefault()) : null;
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							this.vmethod_66().Value = 0.0;
						}
						else
						{
							b = ((fireIntensityLevel != null) ? new byte?((byte)fireIntensityLevel.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								this.vmethod_66().Value = 25.0;
							}
							else
							{
								b = ((fireIntensityLevel != null) ? new byte?((byte)fireIntensityLevel.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									this.vmethod_66().Value = 50.0;
								}
								else
								{
									b = ((fireIntensityLevel != null) ? new byte?((byte)fireIntensityLevel.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
									{
										this.vmethod_66().Value = 75.0;
									}
									else
									{
										b = ((fireIntensityLevel != null) ? new byte?((byte)fireIntensityLevel.GetValueOrDefault()) : null);
										if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
										{
											this.vmethod_66().Value = 100.0;
										}
									}
								}
							}
						}
					}
					else
					{
						this.vmethod_66().Visibility = Visibility.Collapsed;
						this.vmethod_64().Content = "Fire: UNKNOWN";
					}
				}
				else
				{
					this.method_16(Visibility.Collapsed);
					this.method_15(Visibility.Collapsed);
					this.method_14(Visibility.Collapsed);
				}
				if (contact.activeUnit_0.bool_1)
				{
					this.vmethod_110().Visibility = Visibility.Hidden;
				}
				else
				{
					this.vmethod_110().Visibility = Visibility.Visible;
					this.vmethod_110().Content = "WRA: " + Doctrine.smethod_8(Doctrine.smethod_7(ref contact));
				}
				this.vmethod_80().Visibility = Visibility.Collapsed;
				this.method_17(Visibility.Collapsed);
			}
		}

		// Token: 0x06007011 RID: 28689 RVA: 0x003C78F0 File Offset: 0x003C5AF0
		private void method_4(Scenario scenario_0, Side side_0, Unit unit_0)
		{
			this.vmethod_110().Visibility = Visibility.Collapsed;
			this.group_0 = (Group)unit_0;
			if (this.group_0 != null && this.group_0.method_147() != null)
			{
				this.method_1(this.group_0.method_147());
				this.method_18(Visibility.Visible);
				if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
				{
					this.vmethod_86().Visibility = Visibility.Visible;
				}
				else
				{
					this.vmethod_86().Visibility = Visibility.Collapsed;
				}
				this.vmethod_100().Visibility = Visibility.Visible;
				this.vmethod_24().Visibility = Visibility.Collapsed;
				this.vmethod_108().Visibility = Visibility.Hidden;
				this.vmethod_76().Visibility = Visibility.Collapsed;
				this.vmethod_78().Visibility = Visibility.Collapsed;
				this.vmethod_80().Visibility = Visibility.Collapsed;
				this.method_16(Visibility.Collapsed);
				this.method_15(Visibility.Collapsed);
				this.method_14(Visibility.Collapsed);
				this.vmethod_28().Visibility = Visibility.Visible;
				this.vmethod_102().Visibility = Visibility.Collapsed;
				this.method_10(Visibility.Collapsed);
				this.vmethod_22().Visibility = Visibility.Collapsed;
				this.vmethod_8().Visibility = Visibility.Visible;
				this.vmethod_100().Visibility = Visibility.Visible;
				this.method_11(Visibility.Collapsed);
				this.vmethod_10().IsEnabled = true;
				this.vmethod_26().Visibility = Visibility.Collapsed;
				switch (this.group_0.method_143())
				{
				case Group.GroupType.AirGroup:
				case Group.GroupType.Installation:
				case Group.GroupType.AirBase:
				case Group.GroupType.NavalBase:
					this.method_12(Visibility.Collapsed);
					break;
				default:
					this.method_12(Visibility.Visible);
					this.vmethod_42().IsChecked = new bool?(this.group_0.method_145().method_17());
					break;
				}
				if (this.vmethod_28().IsExpanded)
				{
					this.method_7();
				}
				this.vmethod_8().Visibility = Visibility.Visible;
				if (this.group_0.method_143() == Group.GroupType.AirGroup)
				{
					if (this.group_0.vmethod_141().Count > 0)
					{
						this.vmethod_12().Text = string.Concat(new string[]
						{
							"(",
							Conversions.ToString(this.group_0.vmethod_141().Count),
							"x ",
							Misc.smethod_9(Enumerable.ElementAtOrDefault<ActiveUnit>(this.group_0.vmethod_141().Values, 0).string_2),
							")"
						});
					}
					this.vmethod_32().Visibility = Visibility.Visible;
					if (this.group_0.vmethod_141().Count > 0)
					{
						this.vmethod_32().Text = "Loadout: " + Misc.smethod_9(((Aircraft)Enumerable.ElementAtOrDefault<ActiveUnit>(this.group_0.vmethod_141().Values, 0)).method_165());
					}
				}
				else
				{
					this.vmethod_12().Text = this.group_0.method_144() + " (" + Conversions.ToString(this.group_0.vmethod_141().Count) + " units)";
					this.vmethod_32().Visibility = Visibility.Collapsed;
				}
				this.vmethod_14().Visibility = Visibility.Visible;
				this.vmethod_16().Text = this.group_0.method_144();
				if (this.group_0.method_112() | this.group_0.method_114())
				{
					this.method_17(Visibility.Visible);
					if (this.group_0.method_112())
					{
						this.vmethod_84().Visibility = Visibility.Visible;
						this.vmethod_84().Content = "Aircraft: " + Conversions.ToString(Enumerable.Count<Aircraft>(this.group_0.vmethod_92().method_3())) + "/" + Conversions.ToString(this.group_0.vmethod_92().vmethod_4().Count);
						this.vmethod_90().Visibility = Visibility.Visible;
					}
					else
					{
						this.vmethod_84().Visibility = Visibility.Hidden;
						this.vmethod_90().Visibility = Visibility.Hidden;
					}
					if (this.group_0.method_114())
					{
						this.vmethod_82().Visibility = Visibility.Visible;
						this.vmethod_82().Content = "Boats: " + Conversions.ToString(Enumerable.Count<ActiveUnit>(ActiveUnit_DockingOps.smethod_9(this.group_0.vmethod_93()))) + "/" + Conversions.ToString(this.group_0.vmethod_93().method_14().Count);
						this.vmethod_88().Visibility = Visibility.Visible;
					}
					else
					{
						this.vmethod_82().Visibility = Visibility.Hidden;
						this.vmethod_88().Visibility = Visibility.Hidden;
					}
					int num = 0;
					try
					{
						foreach (ActiveUnit activeUnit in this.group_0.vmethod_141().Values)
						{
							if (Enumerable.Count<Cargo>(activeUnit.cargo_0) > 0)
							{
								num += Enumerable.Count<Cargo>(activeUnit.cargo_0);
							}
						}
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					if (num > 0)
					{
						this.vmethod_78().Visibility = Visibility.Visible;
						this.vmethod_78().Content = "Cargo: " + Conversions.ToString(num);
					}
				}
				else
				{
					this.method_17(Visibility.Collapsed);
				}
				this.vmethod_4().Content = unit_0.Name;
				this.vmethod_36().Content = "Course: " + string.Format("{0:0.0}", unit_0.vmethod_9(), 0).ToString() + " deg";
				if (this.group_0.method_143() == Group.GroupType.AirGroup)
				{
					if (!Information.IsNothing(this.group_0.method_147()))
					{
						this.vmethod_38().Content = string.Concat(new string[]
						{
							"Speed: ",
							string.Format("{0:0.0}", unit_0.vmethod_40(), 0).ToString(),
							" kts (M ",
							string.Format("{0:0.00}", Class437.smethod_0((double)this.group_0.method_147().vmethod_14(false), (double)this.group_0.method_147().vmethod_40())),
							") (",
							Misc.smethod_42(this.group_0.method_147().vmethod_84(), this.group_0.method_147()),
							")"
						});
					}
				}
				else if (!Information.IsNothing(this.group_0.method_147()))
				{
					this.vmethod_38().Content = string.Concat(new string[]
					{
						"Speed: ",
						string.Format("{0:0.0}", unit_0.vmethod_40(), 0).ToString(),
						" kts (",
						Misc.smethod_42(this.group_0.method_147().vmethod_84(), this.group_0.method_147()),
						")"
					});
				}
				if (!Information.IsNothing(this.group_0.method_147()) && this.group_0.method_147().vmethod_86().method_77())
				{
					this.vmethod_38().Content = this.vmethod_38().Content.ToString() + "\r\n(Reducing speed to regroup)";
				}
				if (!Information.IsNothing(unit_0.vmethod_7(false)))
				{
					this.vmethod_34().Content = unit_0.vmethod_7(false).method_51();
				}
				else
				{
					this.vmethod_34().Content = "None";
				}
				if (unit_0.vmethod_7(false) == side_0)
				{
					this.method_13(Visibility.Visible);
				}
				else
				{
					this.method_13(Visibility.Collapsed);
				}
				if (Class570.class280_0.method_12())
				{
					if (unit_0.vmethod_13() > 3048f)
					{
						if (this.group_0.method_143() == Group.GroupType.AirGroup)
						{
							this.vmethod_40().Content = "Altitude: " + string.Format("{0:0}", unit_0.vmethod_14(false) * 3.28084f).ToString() + " ft ASL";
						}
						else
						{
							this.vmethod_40().Content = "Altitude: " + string.Format("{0:0}", unit_0.vmethod_14(false) * 3.28084f).ToString() + " ft";
						}
					}
					else if (this.group_0.method_143() == Group.GroupType.AirGroup)
					{
						if (unit_0.method_15())
						{
							this.vmethod_40().Content = string.Concat(new string[]
							{
								"Altitude: ",
								string.Format("{0:0}", unit_0.vmethod_14(false) * 3.28084f),
								" ft ASL (",
								string.Format("{0:0}", unit_0.vmethod_13() * 3.28084f),
								" ft AGL)"
							});
						}
						else
						{
							this.vmethod_40().Content = "Altitude: " + string.Format("{0:0}", unit_0.vmethod_14(false) * 3.28084f) + " ft ASL";
						}
					}
					else
					{
						this.vmethod_40().Content = "Altitude: " + string.Format("{0:0}", unit_0.vmethod_14(false) * 3.28084f).ToString() + " ft";
					}
				}
				else if (unit_0.vmethod_13() > 3048f)
				{
					if (this.group_0.method_143() == Group.GroupType.AirGroup)
					{
						this.vmethod_40().Content = "Altitude: " + string.Format("{0:0.0}", unit_0.vmethod_14(false), 0).ToString() + " m ASL";
					}
					else
					{
						this.vmethod_40().Content = "Altitude: " + string.Format("{0:0.0}", unit_0.vmethod_14(false), 0).ToString() + " m";
					}
				}
				else if (this.group_0.method_143() == Group.GroupType.AirGroup)
				{
					if (unit_0.method_15())
					{
						this.vmethod_40().Content = string.Concat(new string[]
						{
							"Altitude: ",
							string.Format("{0:0.0}", unit_0.vmethod_14(false), 0),
							" m ASL (",
							string.Format("{0:0.0}", unit_0.vmethod_13(), 0),
							" m AGL)"
						});
					}
					else
					{
						this.vmethod_40().Content = "Altitude: " + string.Format("{0:0.0}", unit_0.vmethod_14(false), 0) + " m ASL";
					}
				}
				else
				{
					this.vmethod_40().Content = "Altitude: " + string.Format("{0:0.0}", unit_0.vmethod_14(false), 0).ToString() + " m";
				}
				this.method_16(Visibility.Collapsed);
				if (this.group_0.method_140())
				{
					if (unit_0.vmethod_7(false) == side_0)
					{
						this.vmethod_80().Visibility = Visibility.Visible;
					}
					else
					{
						this.vmethod_80().Visibility = Visibility.Collapsed;
					}
				}
				else
				{
					this.vmethod_80().Visibility = Visibility.Collapsed;
				}
				this.vmethod_100().Text = "Status: " + Misc.smethod_57(this.group_0.vmethod_108(), this.group_0);
				if (!Information.IsNothing(this.group_0.method_147()) && this.group_0.method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
				{
					GlobalVariables.ActiveUnitType activeUnitType = this.group_0.method_147().vmethod_56();
					if (activeUnitType == GlobalVariables.ActiveUnitType.Aircraft && !Information.IsNothing(((Aircraft)this.group_0.method_147()).method_164().method_24()))
					{
						this.vmethod_100().Text = this.vmethod_100().Text + " (Dest: " + ((Aircraft)this.group_0.method_147()).method_164().method_24().Name + ")";
					}
				}
				if (this.group_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.FormingUp)
				{
					int value = Enumerable.Count<ActiveUnit>(Enumerable.Where<ActiveUnit>(this.group_0.vmethod_141().Values, (UnitStatus_WPF._Closure$__.$I43-0 == null) ? (UnitStatus_WPF._Closure$__.$I43-0 = new Func<ActiveUnit, bool>(UnitStatus_WPF._Closure$__.$I.method_0)) : UnitStatus_WPF._Closure$__.$I43-0));
					this.vmethod_100().Text = "Forming up: " + Conversions.ToString(value) + "/" + Conversions.ToString(this.group_0.vmethod_141().Count);
				}
				if (this.group_0.vmethod_101() != null)
				{
					if (this.group_0.vmethod_7(false) == Client.smethod_50())
					{
						this.method_9(Visibility.Visible);
						this.vmethod_96().Tag = this.group_0.vmethod_101();
						string text = "";
						if (!Information.IsNothing(this.group_0.method_147()) && this.group_0.method_147().vmethod_86().bool_2)
						{
							text = "(Escort) ";
						}
						text = string.Concat(new string[]
						{
							text,
							this.group_0.vmethod_101().Name,
							" (",
							this.group_0.vmethod_101().vmethod_5(Client.smethod_46()),
							")"
						});
						this.vmethod_98().Text = text;
						return;
					}
				}
				this.method_9(Visibility.Collapsed);
				return;
			}
		}

		// Token: 0x06007012 RID: 28690 RVA: 0x003C85E0 File Offset: 0x003C67E0
		private void method_5(Scenario scenario_0, Side side_0, Unit unit_0)
		{
			this.vmethod_110().Visibility = Visibility.Collapsed;
			ActiveUnit activeUnit = (ActiveUnit)unit_0;
			this.method_1(activeUnit);
			this.vmethod_26().Visibility = Visibility.Visible;
			if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
			{
				this.vmethod_86().Visibility = Visibility.Visible;
			}
			else
			{
				this.vmethod_86().Visibility = Visibility.Collapsed;
			}
			this.vmethod_14().Visibility = Visibility.Visible;
			this.vmethod_18().Visibility = Visibility.Collapsed;
			if (activeUnit.bool_8)
			{
				Facility facility = (Facility)activeUnit;
				this.vmethod_16().Text = facility.method_142();
			}
			else
			{
				this.vmethod_16().Text = activeUnit.vmethod_58();
			}
			this.vmethod_78().Visibility = Visibility.Collapsed;
			if (this.vmethod_28().Visibility != Visibility.Collapsed)
			{
				this.vmethod_28().Visibility = Visibility.Collapsed;
			}
			if (activeUnit.bool_3 && ((Aircraft)activeUnit).method_146())
			{
				this.vmethod_102().Visibility = Visibility.Visible;
				Aircraft_AirOps aircraft_AirOps = ((Aircraft)activeUnit).method_164();
				this.vmethod_102().Header = string.Concat(new string[]
				{
					"Refueling queue: ",
					Conversions.ToString(aircraft_AirOps.concurrentDictionary_0.Count + aircraft_AirOps.concurrentDictionary_1.Count),
					" [Served: ",
					Conversions.ToString(aircraft_AirOps.int_0),
					"]"
				});
				if (this.vmethod_102().IsExpanded)
				{
					this.method_8(ref activeUnit);
				}
			}
			else if (activeUnit.bool_6 && ((Ship)activeUnit).vmethod_105(activeUnit))
			{
				this.vmethod_102().Visibility = Visibility.Visible;
				ActiveUnit_DockingOps activeUnit_DockingOps = ((Ship)activeUnit).vmethod_93();
				int num = 0;
				if (activeUnit_DockingOps.vmethod_0().Count > 0 || !string.IsNullOrEmpty(activeUnit_DockingOps.string_5) || !string.IsNullOrEmpty(activeUnit_DockingOps.string_4) || !string.IsNullOrEmpty(activeUnit_DockingOps.string_6))
				{
					if (!string.IsNullOrEmpty(activeUnit_DockingOps.string_5))
					{
						num++;
					}
					if (!string.IsNullOrEmpty(activeUnit_DockingOps.string_4))
					{
						num++;
					}
					if (!string.IsNullOrEmpty(activeUnit_DockingOps.string_6))
					{
						num++;
					}
					try
					{
						foreach (string text in activeUnit_DockingOps.vmethod_0())
						{
							num++;
						}
					}
					finally
					{
						List<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.vmethod_102().Header = "UNREP queue:" + Conversions.ToString(num);
				if (this.vmethod_102().IsExpanded)
				{
					this.method_8(ref activeUnit);
				}
			}
			else if (this.vmethod_102().Visibility != Visibility.Collapsed)
			{
				this.vmethod_102().Visibility = Visibility.Collapsed;
			}
			if (this.vmethod_100().Visibility != Visibility.Visible)
			{
				this.vmethod_100().Visibility = Visibility.Visible;
			}
			if (this.vmethod_24().Visibility != Visibility.Collapsed)
			{
				this.vmethod_24().Visibility = Visibility.Collapsed;
			}
			if (!unit_0.bool_2)
			{
				this.vmethod_108().Visibility = Visibility.Visible;
			}
			else
			{
				this.vmethod_108().Visibility = Visibility.Collapsed;
			}
			this.method_12(Visibility.Collapsed);
			this.method_10(Visibility.Visible);
			this.vmethod_8().Visibility = Visibility.Visible;
			if (activeUnit.bool_2)
			{
				this.vmethod_22().Visibility = Visibility.Collapsed;
			}
			else
			{
				this.vmethod_22().Visibility = Visibility.Visible;
				this.vmethod_22().Content = Misc.smethod_20(activeUnit.vmethod_53().Value);
			}
			this.vmethod_10().IsEnabled = true;
			if (unit_0.bool_3)
			{
				this.vmethod_32().Visibility = Visibility.Visible;
				Loadout loadout = ((Aircraft)unit_0).method_167();
				Aircraft_AirOps aircraft_AirOps2 = ((Aircraft)unit_0).method_164();
				if (!Information.IsNothing(loadout))
				{
					if (aircraft_AirOps2.bool_0)
					{
						this.vmethod_32().Text = string.Concat(new string[]
						{
							"Loadout: ",
							Misc.smethod_9(loadout.Name),
							", Quick Turnaround Enabled, ",
							Conversions.ToString(aircraft_AirOps2.int_1),
							" / ",
							Conversions.ToString(aircraft_AirOps2.int_2),
							" sorties"
						});
					}
					else
					{
						this.vmethod_32().Text = "Loadout: " + Misc.smethod_9(loadout.Name);
					}
				}
				else
				{
					this.vmethod_32().Text = "Loadout: Nothing";
				}
			}
			else
			{
				this.vmethod_32().Visibility = Visibility.Collapsed;
			}
			ActiveUnit activeUnit2;
			if (activeUnit.bool_3)
			{
				activeUnit2 = ((Aircraft)activeUnit).method_164().method_32(false);
			}
			else
			{
				activeUnit2 = activeUnit.vmethod_93().method_11(false);
			}
			if (Information.IsNothing(activeUnit2))
			{
				this.vmethod_92().Text = "Assigned base: None";
			}
			else
			{
				string name;
				if (activeUnit2.bool_8 && activeUnit2.method_120())
				{
					name = activeUnit2.vmethod_65(false).Name;
				}
				else
				{
					name = activeUnit2.Name;
				}
				this.vmethod_92().Text = "Assigned base: " + name;
			}
			if ((!activeUnit.method_112() && !activeUnit.method_114() && !activeUnit.method_113()) || (!activeUnit.vmethod_90().vmethod_1() && !Class2558.smethod_17(activeUnit) && !Client.smethod_52().method_1()))
			{
				this.method_17(Visibility.Collapsed);
				this.vmethod_90().Visibility = Visibility.Collapsed;
				this.vmethod_88().Visibility = Visibility.Collapsed;
			}
			else
			{
				this.method_17(Visibility.Visible);
				if (activeUnit.method_112())
				{
					this.vmethod_84().Visibility = Visibility.Visible;
					this.vmethod_84().Content = "Aircraft: " + Conversions.ToString(Enumerable.Count<Aircraft>(activeUnit.vmethod_92().method_3())) + "/" + Conversions.ToString(activeUnit.vmethod_92().vmethod_4().Count);
					this.vmethod_90().Visibility = Visibility.Visible;
				}
				else
				{
					this.vmethod_84().Visibility = Visibility.Collapsed;
					this.vmethod_90().Visibility = Visibility.Collapsed;
				}
				if (activeUnit.method_114())
				{
					this.vmethod_82().Visibility = Visibility.Visible;
					this.vmethod_82().Content = "Boats: " + Conversions.ToString(Enumerable.Count<ActiveUnit>(ActiveUnit_DockingOps.smethod_9(activeUnit.vmethod_93()))) + "/" + Conversions.ToString(activeUnit.vmethod_93().method_14().Count);
					this.vmethod_88().Visibility = Visibility.Visible;
				}
				else
				{
					this.vmethod_82().Visibility = Visibility.Collapsed;
					this.vmethod_88().Visibility = Visibility.Collapsed;
				}
				if (activeUnit.method_113())
				{
					this.vmethod_78().Visibility = Visibility.Visible;
					this.vmethod_78().Content = "Cargo: " + Conversions.ToString(Enumerable.Count<Cargo>(activeUnit.cargo_0));
				}
				else
				{
					this.vmethod_78().Visibility = Visibility.Collapsed;
				}
			}
			if (activeUnit.method_122())
			{
				if (activeUnit.vmethod_85().method_48())
				{
					this.vmethod_4().Content = string.Concat(new string[]
					{
						"[LEAD] ",
						activeUnit.Name,
						" (Flight ",
						activeUnit.vmethod_85().method_7().string_4,
						")"
					});
				}
				else
				{
					this.vmethod_4().Content = unit_0.Name;
				}
			}
			else if (activeUnit.vmethod_85().method_48())
			{
				this.vmethod_4().Content = unit_0.Name + " (Flight " + activeUnit.vmethod_85().method_7().string_4 + ")";
			}
			else
			{
				this.vmethod_4().Content = unit_0.Name;
			}
			this.vmethod_8().Visibility = Visibility.Visible;
			this.vmethod_12().Text = Misc.smethod_9(unit_0.string_2);
			if (!activeUnit.vmethod_90().vmethod_1() && !Class2558.smethod_17(activeUnit) && !Client.smethod_52().method_1())
			{
				this.vmethod_36().Content = "Course: XXX";
			}
			else
			{
				if (activeUnit.bool_25)
				{
					this.vmethod_36().Content = null;
					this.vmethod_38().Content = null;
				}
				else if (activeUnit.vmethod_56() == GlobalVariables.ActiveUnitType.Facility && !((Facility)activeUnit).method_154())
				{
					this.vmethod_36().Content = null;
					this.vmethod_38().Content = null;
				}
				else
				{
					this.vmethod_36().Content = "Course: " + Conversions.ToString(Math.Round((double)unit_0.vmethod_9(), 0)) + " deg";
				}
				if (activeUnit.vmethod_85().bool_2)
				{
					this.vmethod_36().Content = Conversions.ToString(this.vmethod_36().Content) + " (Plotting..." + Conversions.ToString((int)Math.Round((double)(activeUnit.vmethod_85().float_1 * 100f))) + "%)";
				}
			}
			if (!activeUnit.vmethod_90().vmethod_1() && !Class2558.smethod_17(activeUnit) && !Client.smethod_52().method_1())
			{
				this.vmethod_38().Content = "Speed: XXX";
			}
			else if (unit_0.bool_3 | unit_0.method_2())
			{
				if (unit_0.vmethod_6())
				{
					this.vmethod_38().Content = string.Concat(new string[]
					{
						"Speed:\r\nTAS ",
						Conversions.ToString((int)Math.Round((double)unit_0.vmethod_40())),
						" kts (M ",
						string.Format("{0:0.00}", Class437.smethod_0((double)unit_0.vmethod_14(false), (double)unit_0.vmethod_40())),
						")\r\nGnd ",
						Conversions.ToString((int)Math.Round((double)unit_0.vmethod_40() * Math2.smethod_2((double)unit_0.vmethod_18()))),
						" kts (",
						Misc.smethod_42(activeUnit.vmethod_84(), activeUnit),
						")"
					});
				}
				else
				{
					this.vmethod_38().Content = string.Concat(new string[]
					{
						"Speed: ",
						Conversions.ToString((int)Math.Round((double)unit_0.vmethod_40())),
						" kts (M ",
						string.Format("{0:0.00}", Class437.smethod_0((double)unit_0.vmethod_14(false), (double)unit_0.vmethod_40())),
						") (",
						Misc.smethod_42(activeUnit.vmethod_84(), activeUnit),
						")"
					});
				}
			}
			else if (unit_0.method_1())
			{
				this.vmethod_38().Content = "Speed: " + Conversions.ToString((int)Math.Round((double)unit_0.vmethod_40())) + " kts";
			}
			else
			{
				this.vmethod_38().Content = string.Concat(new string[]
				{
					"Speed: ",
					string.Format("{0:0.0}", unit_0.vmethod_40(), 0),
					" kts (",
					Misc.smethod_42(activeUnit.vmethod_84(), activeUnit),
					")"
				});
			}
			if (!Information.IsNothing(unit_0.vmethod_7(false)))
			{
				this.vmethod_34().Content = "Side: " + unit_0.vmethod_7(false).method_51();
			}
			else
			{
				this.vmethod_34().Content = "Side: None";
			}
			if (unit_0.vmethod_7(false) == side_0 && (activeUnit.vmethod_90().vmethod_1() || Class2558.smethod_17(activeUnit) || Client.smethod_52().method_1()))
			{
				this.method_13(Visibility.Visible);
			}
			else
			{
				this.method_13(Visibility.Collapsed);
			}
			if (!unit_0.bool_2 && (activeUnit.vmethod_90().vmethod_1() || Class2558.smethod_17(activeUnit) || Client.smethod_52().method_1()))
			{
				this.method_16(Visibility.Visible);
				this.method_15(Visibility.Visible);
				if (unit_0.bool_6 | unit_0.bool_5)
				{
					this.method_14(Visibility.Visible);
				}
				else
				{
					this.method_14(Visibility.Collapsed);
				}
				this.vmethod_48().Visibility = Visibility.Visible;
				if (unit_0.bool_6 && ((Ship)unit_0).method_152())
				{
					this.vmethod_46().Text = "SINKING";
				}
				else
				{
					this.vmethod_46().Text = string.Format("{0:0.0}", activeUnit.vmethod_91().method_0(), 1) + "%";
				}
				if (!unit_0.bool_6 && !unit_0.bool_5)
				{
					this.vmethod_68().Visibility = Visibility.Collapsed;
					this.vmethod_70().Visibility = Visibility.Collapsed;
				}
				else
				{
					this.vmethod_68().Visibility = Visibility.Visible;
					this.vmethod_70().Visibility = Visibility.Visible;
					this.vmethod_68().Content = "Flood:";
					switch (activeUnit.vmethod_91().vmethod_1())
					{
					case ActiveUnit_Damage.FloodingIntensityLevel.NoFlooding:
						this.vmethod_70().Value = 0.0;
						this.vmethod_68().Visibility = Visibility.Collapsed;
						this.vmethod_70().Visibility = Visibility.Collapsed;
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Minor:
						this.vmethod_70().Value = 25.0;
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Major:
						this.vmethod_70().Value = 50.0;
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Severe:
						this.vmethod_70().Value = 75.0;
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Capsizing:
						this.vmethod_70().Value = 100.0;
						break;
					}
				}
				if (unit_0.bool_3 && ((Aircraft)unit_0).method_159().method_24() && !((Aircraft)unit_0).method_169())
				{
					this.vmethod_72().Visibility = Visibility.Visible;
					this.vmethod_74().Visibility = Visibility.Visible;
					Aircraft aircraft = (Aircraft)unit_0;
					this.vmethod_74().Value = (double)(100f * (aircraft.float_30 / aircraft.float_31));
					float num2 = aircraft.float_30 / aircraft.float_31;
					if (num2 < 0.5f)
					{
						this.vmethod_74().Foreground = Brushes.Green;
					}
					else if (num2 < 0.75f)
					{
						this.vmethod_74().Foreground = Brushes.Yellow;
					}
					else
					{
						this.vmethod_74().Foreground = Brushes.Red;
					}
				}
				else
				{
					this.vmethod_72().Visibility = Visibility.Collapsed;
					this.vmethod_74().Visibility = Visibility.Collapsed;
				}
				this.vmethod_64().Visibility = Visibility.Visible;
				this.vmethod_66().Visibility = Visibility.Visible;
				this.vmethod_64().Content = "Fire:";
				switch (activeUnit.vmethod_91().vmethod_3())
				{
				case ActiveUnit_Damage.FireIntensityLevel.NoFire:
					this.vmethod_66().Value = 0.0;
					this.vmethod_64().Visibility = Visibility.Collapsed;
					this.vmethod_66().Visibility = Visibility.Collapsed;
					break;
				case ActiveUnit_Damage.FireIntensityLevel.Minor:
					this.vmethod_66().Value = 25.0;
					break;
				case ActiveUnit_Damage.FireIntensityLevel.Major:
					this.vmethod_66().Value = 50.0;
					break;
				case ActiveUnit_Damage.FireIntensityLevel.Severe:
					this.vmethod_66().Value = 75.0;
					break;
				case ActiveUnit_Damage.FireIntensityLevel.Conflagration:
					this.vmethod_66().Value = 100.0;
					break;
				}
			}
			else
			{
				this.method_16(Visibility.Collapsed);
				this.method_15(Visibility.Collapsed);
				this.method_14(Visibility.Collapsed);
			}
			GlobalVariables.ActiveUnitType activeUnitType = ((ActiveUnit)unit_0).vmethod_56();
			if (activeUnitType != GlobalVariables.ActiveUnitType.Ship)
			{
				if (activeUnitType != GlobalVariables.ActiveUnitType.Facility)
				{
					if (!activeUnit.vmethod_90().vmethod_1() && !Class2558.smethod_17(activeUnit) && !Client.smethod_52().method_1())
					{
						this.vmethod_40().Content = "Altitude: XXX";
						goto IL_129A;
					}
					if (Class570.class280_0.method_12())
					{
						if (unit_0.vmethod_14(false) > 45720f)
						{
							this.vmethod_40().Content = "Altitude: " + string.Format("{0:0.0}", unit_0.vmethod_14(false) / 1000f) + " km ASL";
							goto IL_129A;
						}
						if (unit_0.vmethod_13() > 3048f)
						{
							if (unit_0.bool_3 | unit_0.bool_2)
							{
								this.vmethod_40().Content = "Altitude: " + string.Format("{0:0}", unit_0.vmethod_14(false) * 3.28084f) + " ft ASL";
								goto IL_129A;
							}
							this.vmethod_40().Content = "Altitude: " + string.Format("{0:0}", unit_0.vmethod_14(false) * 3.28084f) + " ft";
							goto IL_129A;
						}
						else
						{
							if (!(unit_0.bool_3 | unit_0.bool_2))
							{
								this.vmethod_40().Content = "Altitude: " + string.Format("{0:0}", unit_0.vmethod_14(false) * 3.28084f) + " ft";
								goto IL_129A;
							}
							if (unit_0.method_15())
							{
								this.vmethod_40().Content = string.Concat(new string[]
								{
									"Altitude: ",
									string.Format("{0:0}", unit_0.vmethod_14(false) * 3.28084f),
									" ft ASL (",
									string.Format("{0:0}", unit_0.vmethod_13() * 3.28084f),
									" ft AGL)"
								});
								goto IL_129A;
							}
							this.vmethod_40().Content = "Altitude: " + string.Format("{0:0}", unit_0.vmethod_14(false) * 3.28084f) + " ft ASL";
							goto IL_129A;
						}
					}
					else
					{
						if (unit_0.vmethod_14(false) > 45720f)
						{
							this.vmethod_40().Content = "Altitude: " + string.Format("{0:0.0}", unit_0.vmethod_14(false) / 1000f) + " km ASL";
							goto IL_129A;
						}
						if (unit_0.vmethod_13() > 3048f)
						{
							if (unit_0.bool_3 | unit_0.bool_2)
							{
								this.vmethod_40().Content = "Altitude: " + string.Format("{0:0.0}", unit_0.vmethod_14(false)) + " m ASL";
								goto IL_129A;
							}
							this.vmethod_40().Content = "Altitude: " + string.Format("{0:0.0}", unit_0.vmethod_14(false)) + " m";
							goto IL_129A;
						}
						else
						{
							if (!(unit_0.bool_3 | unit_0.bool_2))
							{
								this.vmethod_40().Content = "Altitude: " + string.Format("{0:0.0}", unit_0.vmethod_14(false)) + " m";
								goto IL_129A;
							}
							if (unit_0.method_15())
							{
								this.vmethod_40().Content = string.Concat(new string[]
								{
									"Altitude: ",
									string.Format("{0:0.0}", unit_0.vmethod_14(false)),
									" m ASL (",
									string.Format("{0:0.0}", unit_0.vmethod_13(), 0),
									" m AGL)"
								});
								goto IL_129A;
							}
							this.vmethod_40().Content = "Altitude: " + string.Format("{0:0.0}", unit_0.vmethod_14(false)) + " m ASL";
							goto IL_129A;
						}
					}
				}
			}
			this.vmethod_40().Content = "";
			IL_129A:
			if (unit_0.vmethod_43() && Client.smethod_77(unit_0))
			{
				if (Client.smethod_0().method_1() != Class279.Enum67.const_2 && Enumerable.Count<Magazine>(((Class350)unit_0).magazine_0) <= 0)
				{
					bool flag;
					if ((unit_0.bool_6 || unit_0.bool_8) && ((Class350)unit_0).vmethod_51().Count > 0)
					{
						try
						{
							List<Mount>.Enumerator enumerator2 = ((Class350)unit_0).vmethod_51().GetEnumerator();
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current.method_32().vmethod_10().Count > 0)
								{
									flag = true;
									break;
								}
							}
						}
						finally
						{
							List<Mount>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
					if (flag)
					{
						this.vmethod_80().Visibility = Visibility.Visible;
					}
					else
					{
						this.vmethod_80().Visibility = Visibility.Collapsed;
					}
				}
				else if (activeUnit.bool_3)
				{
					this.vmethod_80().Visibility = Visibility.Collapsed;
				}
				else if (unit_0.vmethod_7(false) == side_0)
				{
					this.vmethod_80().Visibility = Visibility.Visible;
				}
				else
				{
					this.vmethod_80().Visibility = Visibility.Collapsed;
				}
			}
			else
			{
				this.vmethod_80().Visibility = Visibility.Collapsed;
			}
			if (activeUnit.method_117() && Client.smethod_77(unit_0))
			{
				this.vmethod_76().Visibility = Visibility.Visible;
			}
			else
			{
				this.vmethod_76().Visibility = Visibility.Collapsed;
			}
			if (unit_0.bool_6 && ((Ship)unit_0).method_152())
			{
				this.vmethod_100().Text = "Status: SINKING";
			}
			else if (!activeUnit.vmethod_90().vmethod_1() && !Class2558.smethod_17(activeUnit) && !Client.smethod_52().method_1())
			{
				this.vmethod_100().Text = "Status: UNKNOWN (Out of comms)";
			}
			else if (activeUnit.bool_2 && ((Weapon)activeUnit).method_167() == Weapon._WeaponType.Sonobuoy)
			{
				this.vmethod_100().Text = "Time To Live: " + Misc.smethod_11((long)Math.Round((double)activeUnit.vmethod_67()[0].float_0), Aircraft_AirOps.Enum44.const_0, false, false);
			}
			else
			{
				this.vmethod_100().Text = "Status: " + Misc.smethod_57(activeUnit.vmethod_108(), activeUnit);
				if ((unit_0.bool_6 | unit_0.bool_5) && activeUnit.vmethod_85().vmethod_3())
				{
					ActiveUnit_Kinematics.Enum33 enum33_ = activeUnit.vmethod_87().enum33_0;
					if (enum33_ != ActiveUnit_Kinematics.Enum33.const_0)
					{
						if (enum33_ == ActiveUnit_Kinematics.Enum33.const_1)
						{
							TextBlock textBlock;
							(textBlock = this.vmethod_100()).Text = textBlock.Text + " (Drifting)";
						}
					}
					else
					{
						TextBlock textBlock;
						(textBlock = this.vmethod_100()).Text = textBlock.Text + " (Sprinting)";
					}
				}
				if (activeUnit.vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
				{
					GlobalVariables.ActiveUnitType activeUnitType2 = activeUnit.vmethod_56();
					if (activeUnitType2 == GlobalVariables.ActiveUnitType.Aircraft)
					{
						if (!Information.IsNothing(((Aircraft)activeUnit).method_164().method_24()))
						{
							this.vmethod_100().Text = this.vmethod_100().Text + " (Dest: " + ((Aircraft)activeUnit).method_164().method_24().Name + ")";
						}
						else if (activeUnit.method_121() && !Information.IsNothing(activeUnit.method_122()))
						{
							ActiveUnit activeUnit3 = activeUnit.vmethod_65(false).method_147();
							if (!Information.IsNothing(((Aircraft)activeUnit3).method_164().method_24()))
							{
								this.vmethod_100().Text = this.vmethod_100().Text + " (Dest: " + ((Aircraft)activeUnit3).method_164().method_24().Name + ")";
							}
						}
					}
					else if (!Information.IsNothing(activeUnit.vmethod_93().method_6()))
					{
						this.vmethod_100().Text = this.vmethod_100().Text + " (Dest: " + activeUnit.vmethod_93().method_6().Name + ")";
					}
				}
				if (unit_0.bool_3)
				{
					if (((Aircraft)unit_0).method_164().method_36() != Aircraft_AirOps._AirOpsCondition.RTB)
					{
						string text2 = " (" + ((Aircraft)unit_0).method_164().method_40();
						Aircraft_AirOps._AirOpsCondition airOpsCondition = ((Aircraft)activeUnit).method_164().method_36();
						if (airOpsCondition == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar || airOpsCondition == Aircraft_AirOps._AirOpsCondition.TransferringCargo)
						{
							if (activeUnit.vmethod_13() > 45.72f)
							{
								text2 += ", Adjusting Altitude";
							}
							else
							{
								text2 = text2 + " (" + Misc.smethod_11((long)Math.Round((double)((Aircraft)activeUnit).method_164().method_38()), Aircraft_AirOps.Enum44.const_0, false, true) + ")";
							}
						}
						text2 += ")";
						this.vmethod_100().Text = this.vmethod_100().Text + text2;
					}
				}
				else
				{
					if (activeUnit.vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling)
					{
						string text3 = string.Empty;
						int num3 = activeUnit.vmethod_93().method_6().vmethod_93().method_36(activeUnit);
						int num4 = activeUnit.vmethod_93().method_6().vmethod_93().method_37(activeUnit);
						if (num3 > 0)
						{
							text3 = text3 + "Refuelling (" + Conversions.ToString(num3) + "kg to go)";
						}
						if (num4 > 0)
						{
							if (num3 > 0)
							{
								text3 += " - ";
							}
							text3 = text3 + "Replenishing (" + Conversions.ToString(num4) + " items to go)";
						}
						this.vmethod_100().Text = "Status: " + text3;
					}
					if (activeUnit.vmethod_93().method_18())
					{
						string text4 = "\r\nProviding UNREP: ";
						ActiveUnit activeUnit4;
						if (!string.IsNullOrEmpty(activeUnit.vmethod_93().string_4))
						{
							activeUnit4 = Client.smethod_46().vmethod_0()[activeUnit.vmethod_93().string_4];
						}
						if (!Information.IsNothing(activeUnit4))
						{
							text4 = text4 + "\r\nPort: " + activeUnit4.Name;
						}
						activeUnit4 = null;
						if (!string.IsNullOrEmpty(activeUnit.vmethod_93().string_5))
						{
							activeUnit4 = Client.smethod_46().vmethod_0()[activeUnit.vmethod_93().string_5];
						}
						if (!Information.IsNothing(activeUnit4))
						{
							text4 = text4 + "\r\nStarboard: " + activeUnit4.Name;
						}
						activeUnit4 = null;
						if (!string.IsNullOrEmpty(activeUnit.vmethod_93().string_6))
						{
							activeUnit4 = Client.smethod_46().vmethod_0()[activeUnit.vmethod_93().string_6];
						}
						if (!Information.IsNothing(activeUnit4))
						{
							text4 = text4 + "\r\nAstern: " + activeUnit4.Name;
						}
						activeUnit4 = null;
						TextBlock textBlock;
						(textBlock = this.vmethod_100()).Text = textBlock.Text + text4;
					}
					else if (!unit_0.method_5() || activeUnit.vmethod_93().method_8() != ActiveUnit_DockingOps._DockingOpsCondition.Underway)
					{
						TextBlock textBlock;
						(textBlock = this.vmethod_100()).Text = textBlock.Text + " (" + activeUnit.vmethod_93().method_10() + ")";
					}
				}
			}
			if (activeUnit.vmethod_101() != null)
			{
				if (activeUnit.vmethod_7(false) == Client.smethod_50())
				{
					this.method_9(Visibility.Visible);
					this.vmethod_96().Tag = activeUnit.vmethod_101();
					string text5 = "";
					if (activeUnit.vmethod_86().bool_2)
					{
						text5 = "(Escort) ";
					}
					text5 += activeUnit.vmethod_101().Name;
					if (!string.IsNullOrEmpty(activeUnit.vmethod_101().vmethod_5(Client.smethod_46())))
					{
						text5 = text5 + " (" + activeUnit.vmethod_101().vmethod_5(Client.smethod_46()) + ")";
					}
					this.vmethod_98().Text = text5;
					if (!activeUnit.vmethod_101().method_12())
					{
						Run run;
						(run = this.vmethod_98()).Text = run.Text + " - Inactive";
						goto IL_1A29;
					}
					goto IL_1A29;
				}
			}
			this.method_9(Visibility.Collapsed);
			IL_1A29:
			if (activeUnit.vmethod_90().vmethod_1())
			{
				this.method_11(Visibility.Visible);
				this.method_0(activeUnit);
				return;
			}
			this.method_11(Visibility.Collapsed);
		}

		// Token: 0x06007013 RID: 28691 RVA: 0x003CA058 File Offset: 0x003C8258
		public void method_6(Scenario scenario_0, Side side_0, Unit unit_0)
		{
			this.vmethod_16().Text = "";
			this.vmethod_20().Text = "";
			if (!Information.IsNothing(unit_0))
			{
				if (unit_0.method_14())
				{
					this.method_3(scenario_0, side_0, unit_0);
					return;
				}
				if (unit_0.bool_1)
				{
					this.method_4(scenario_0, side_0, unit_0);
					return;
				}
				if (unit_0.bool_0)
				{
					this.method_5(scenario_0, side_0, unit_0);
					return;
				}
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06007014 RID: 28692 RVA: 0x003CA0D0 File Offset: 0x003C82D0
		private void Button_Damage_Click(object sender, RoutedEventArgs e)
		{
			UnitStatus_WPF.Delegate91 @delegate = UnitStatus_WPF.delegate91_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06007015 RID: 28693 RVA: 0x000468C3 File Offset: 0x00044AC3
		private void Button_AirOps_Click(object sender, RoutedEventArgs e)
		{
			Class2413.smethod_2().method_41().method_173();
		}

		// Token: 0x06007016 RID: 28694 RVA: 0x003CA0EC File Offset: 0x003C82EC
		private void Button_Magazines_Click(object sender, RoutedEventArgs e)
		{
			UnitStatus_WPF.Delegate92 @delegate = UnitStatus_WPF.delegate92_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06007017 RID: 28695 RVA: 0x003CA108 File Offset: 0x003C8308
		private void Button_Sensors_Click(object sender, RoutedEventArgs e)
		{
			UnitStatus_WPF.Delegate94 @delegate = UnitStatus_WPF.delegate94_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06007018 RID: 28696 RVA: 0x003CA124 File Offset: 0x003C8324
		private void Button_Weapons_Click(object sender, RoutedEventArgs e)
		{
			UnitStatus_WPF.Delegate93 @delegate = UnitStatus_WPF.delegate93_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06007019 RID: 28697 RVA: 0x003CA140 File Offset: 0x003C8340
		private void method_7()
		{
			if (!Information.IsNothing(this.group_0))
			{
				this.vmethod_30().Items.Clear();
				if (this.group_0.method_143() != Group.GroupType.AirGroup && this.group_0.method_143() != Group.GroupType.SurfaceGroup)
				{
					if (this.group_0.method_143() != Group.GroupType.SubGroup)
					{
						IEnumerable<string> enumerable = Enumerable.Distinct<string>(Enumerable.OrderBy<string, string>(Enumerable.Select<ActiveUnit, string>(this.group_0.vmethod_141().Values, (UnitStatus_WPF._Closure$__.$I51-2 == null) ? (UnitStatus_WPF._Closure$__.$I51-2 = new Func<ActiveUnit, string>(UnitStatus_WPF._Closure$__.$I.method_3)) : UnitStatus_WPF._Closure$__.$I51-2), (UnitStatus_WPF._Closure$__.$I51-3 == null) ? (UnitStatus_WPF._Closure$__.$I51-3 = new Func<string, string>(UnitStatus_WPF._Closure$__.$I.method_4)) : UnitStatus_WPF._Closure$__.$I51-3));
						try
						{
							foreach (string text in enumerable)
							{
								UnitStatus_WPF.Class2476 @class = new UnitStatus_WPF.Class2476(@class);
								@class.string_0 = text;
								IEnumerable<ActiveUnit> enumerable2 = Enumerable.Where<ActiveUnit>(Enumerable.Select<ActiveUnit, ActiveUnit>(this.group_0.vmethod_141().Values, (UnitStatus_WPF._Closure$__.$I51-4 == null) ? (UnitStatus_WPF._Closure$__.$I51-4 = new Func<ActiveUnit, ActiveUnit>(UnitStatus_WPF._Closure$__.$I.method_5)) : UnitStatus_WPF._Closure$__.$I51-4), new Func<ActiveUnit, bool>(@class.method_0));
								int value = Enumerable.Count<ActiveUnit>(enumerable2);
								System.Windows.Forms.ListViewItem listViewItem = new System.Windows.Forms.ListViewItem();
								listViewItem.Text = Conversions.ToString(value) + "x " + @class.string_0;
								string str;
								if (Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable2, 0).bool_3)
								{
									str = "Aircraft";
								}
								else if (Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable2, 0).bool_6)
								{
									str = "Ship";
								}
								else if (Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable2, 0).bool_5)
								{
									str = "Submarine";
								}
								else if (Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable2, 0).bool_8)
								{
									str = "Facility";
								}
								else if (Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable2, 0).method_1())
								{
									str = "Satellite";
								}
								else if (Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable2, 0).method_1())
								{
									str = "Weapon";
								}
								else
								{
									if (Debugger.IsAttached)
									{
										Debugger.Break();
										continue;
									}
									continue;
								}
								listViewItem.Tag = str + "_" + Conversions.ToString(Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable2, 0).DBID);
								this.vmethod_30().Items.Add(listViewItem);
							}
							return;
						}
						finally
						{
							IEnumerator<string> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
					}
				}
				IEnumerable<ActiveUnit> enumerable3 = Enumerable.OrderBy<ActiveUnit, string>(Enumerable.Select<ActiveUnit, ActiveUnit>(this.group_0.vmethod_141().Values, (UnitStatus_WPF._Closure$__.$I51-0 == null) ? (UnitStatus_WPF._Closure$__.$I51-0 = new Func<ActiveUnit, ActiveUnit>(UnitStatus_WPF._Closure$__.$I.method_1)) : UnitStatus_WPF._Closure$__.$I51-0), (UnitStatus_WPF._Closure$__.$I51-1 == null) ? (UnitStatus_WPF._Closure$__.$I51-1 = new Func<ActiveUnit, string>(UnitStatus_WPF._Closure$__.$I.method_2)) : UnitStatus_WPF._Closure$__.$I51-1);
				try
				{
					foreach (ActiveUnit activeUnit in enumerable3)
					{
						System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem();
						listViewItem2.Text = activeUnit.Name + " (" + activeUnit.string_2 + ")";
						listViewItem2.Tag = activeUnit.string_0;
						this.vmethod_30().Items.Add(listViewItem2);
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
			}
		}

		// Token: 0x0600701A RID: 28698 RVA: 0x000468D4 File Offset: 0x00044AD4
		private void Expander_GroupMembers_Collapsed(object sender, RoutedEventArgs e)
		{
			this.vmethod_28().Header = "Group Composition:";
		}

		// Token: 0x0600701B RID: 28699 RVA: 0x000468E6 File Offset: 0x00044AE6
		private void Expander_GroupMembers_Expanded(object sender, RoutedEventArgs e)
		{
			this.vmethod_28().Header = "Group Composition:";
			this.method_7();
		}

		// Token: 0x0600701C RID: 28700 RVA: 0x0000378C File Offset: 0x0000198C
		private void Expander_TankerClients_Collapsed(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x0600701D RID: 28701 RVA: 0x003CA4A0 File Offset: 0x003C86A0
		private void Expander_TankerClients_Expanded(object sender, RoutedEventArgs e)
		{
			if (!Information.IsNothing(Client.smethod_54()))
			{
				ActiveUnit activeUnit = (ActiveUnit)Client.smethod_54();
				this.method_8(ref activeUnit);
			}
		}

		// Token: 0x0600701E RID: 28702 RVA: 0x003CA4CC File Offset: 0x003C86CC
		private void method_8(ref ActiveUnit activeUnit_0)
		{
			if (!Information.IsNothing(activeUnit_0))
			{
				this.vmethod_104().Items.Clear();
				if (activeUnit_0.bool_3)
				{
					Aircraft aircraft = (Aircraft)activeUnit_0;
					List<KeyValuePair<string, Aircraft_AirOps.Enum43>> list = new List<KeyValuePair<string, Aircraft_AirOps.Enum43>>();
					list.AddRange(aircraft.method_164().concurrentDictionary_1);
					try
					{
						foreach (KeyValuePair<string, Aircraft_AirOps.Enum43> keyValuePair in list)
						{
							if (Client.smethod_46().vmethod_0().ContainsKey(keyValuePair.Key))
							{
								Aircraft aircraft2 = (Aircraft)Client.smethod_46().vmethod_0()[keyValuePair.Key];
								System.Windows.Forms.ListViewItem listViewItem = new System.Windows.Forms.ListViewItem();
								listViewItem.Text = string.Concat(new string[]
								{
									"Refuelling: ",
									aircraft2.Name,
									" (",
									aircraft2.string_2,
									")"
								});
								listViewItem.Tag = "Aircraft_" + Conversions.ToString(aircraft2.DBID);
								this.vmethod_104().Items.Add(listViewItem);
							}
							else
							{
								ConcurrentDictionary<string, Aircraft_AirOps.Enum43> concurrentDictionary_ = aircraft.method_164().concurrentDictionary_1;
								string key = keyValuePair.Key;
								Aircraft_AirOps.Enum43 @enum = Aircraft_AirOps.Enum43.const_0;
								concurrentDictionary_.TryRemove(key, ref @enum);
								Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
								ref int ptr = ref aircraft_AirOps.int_0;
								aircraft_AirOps.int_0 = ptr + 1;
							}
						}
					}
					finally
					{
						List<KeyValuePair<string, Aircraft_AirOps.Enum43>>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					List<string> list2 = new List<string>();
					list2.AddRange((IEnumerable<string>)aircraft.method_164().concurrentDictionary_0);
					try
					{
						foreach (string text in list2)
						{
							if (Client.smethod_46().vmethod_0().ContainsKey(text))
							{
								Aircraft aircraft2 = (Aircraft)Client.smethod_46().vmethod_0()[text];
								System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem();
								listViewItem2.Text = string.Concat(new string[]
								{
									"In queue: ",
									aircraft2.Name,
									" (",
									aircraft2.string_2,
									")"
								});
								listViewItem2.Tag = "Aircraft_" + Conversions.ToString(aircraft2.DBID);
								this.vmethod_104().Items.Add(listViewItem2);
							}
							else
							{
								ConcurrentDictionary<string, byte> concurrentDictionary_2 = aircraft.method_164().concurrentDictionary_0;
								string text2 = text;
								byte b = 0;
								concurrentDictionary_2.TryRemove(text2, ref b);
							}
						}
						return;
					}
					finally
					{
						List<string>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				if (activeUnit_0.bool_6)
				{
					Ship ship = (Ship)activeUnit_0;
					if (!string.IsNullOrEmpty(((Ship)activeUnit_0).vmethod_93().string_5))
					{
						Ship ship2 = (Ship)Client.smethod_46().vmethod_0()[((Ship)activeUnit_0).vmethod_93().string_5];
						if (!Information.IsNothing(ship2))
						{
							System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem();
							listViewItem3.Text = string.Concat(new string[]
							{
								"UNREP, Starboard: ",
								ship2.Name,
								" (",
								ship2.string_2,
								")"
							});
							listViewItem3.Tag = "Ship_" + Conversions.ToString(ship2.DBID);
							this.vmethod_104().Items.Add(listViewItem3);
						}
					}
					if (!string.IsNullOrEmpty(((Ship)activeUnit_0).vmethod_93().string_4))
					{
						Ship ship3 = (Ship)Client.smethod_46().vmethod_0()[((Ship)activeUnit_0).vmethod_93().string_4];
						if (!Information.IsNothing(ship3))
						{
							System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem();
							listViewItem4.Text = string.Concat(new string[]
							{
								"UNREP, Port: ",
								ship3.Name,
								" (",
								ship3.string_2,
								")"
							});
							listViewItem4.Tag = "Ship_" + Conversions.ToString(ship3.DBID);
							this.vmethod_104().Items.Add(listViewItem4);
						}
					}
					if (!string.IsNullOrEmpty(((Ship)activeUnit_0).vmethod_93().string_6))
					{
						Ship ship4 = (Ship)Client.smethod_46().vmethod_0()[((Ship)activeUnit_0).vmethod_93().string_6];
						if (!Information.IsNothing(ship4))
						{
							System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem();
							listViewItem5.Text = string.Concat(new string[]
							{
								"UNREP, Astern: ",
								ship4.Name,
								" (",
								ship4.string_2,
								")"
							});
							listViewItem5.Tag = "Ship_" + Conversions.ToString(ship4.DBID);
							this.vmethod_104().Items.Add(listViewItem5);
						}
					}
					try
					{
						foreach (string key2 in ship.vmethod_93().vmethod_0())
						{
							Ship ship5 = (Ship)Client.smethod_46().vmethod_0()[key2];
							if (!Information.IsNothing(ship5))
							{
								System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem();
								listViewItem6.Text = string.Concat(new string[]
								{
									"In queue: ",
									ship5.Name,
									" (",
									ship5.string_2,
									")"
								});
								listViewItem6.Tag = "Ship_" + Conversions.ToString(ship5.DBID);
								this.vmethod_104().Items.Add(listViewItem6);
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
			}
		}

		// Token: 0x0600701F RID: 28703 RVA: 0x003CAAB0 File Offset: 0x003C8CB0
		private void UnitStatus_WPF_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			UnitStatus_WPF.Delegate90 @delegate = UnitStatus_WPF.delegate90_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06007020 RID: 28704 RVA: 0x003CAACC File Offset: 0x003C8CCC
		private void Button_ContactReport_Click(object sender, RoutedEventArgs e)
		{
			if (!Information.IsNothing(Client.smethod_54()) && Client.smethod_54().method_14())
			{
				Class2413.smethod_2().method_15().contact_0 = (Contact)Client.smethod_54();
				Class2413.smethod_2().method_15().Show();
			}
		}

		// Token: 0x06007021 RID: 28705 RVA: 0x000468FE File Offset: 0x00044AFE
		private void Button_CargoOps_Click(object sender, RoutedEventArgs e)
		{
			Class2413.smethod_2().method_41().method_86();
		}

		// Token: 0x06007022 RID: 28706 RVA: 0x0004690F File Offset: 0x00044B0F
		private void Button_DockOps_Click(object sender, RoutedEventArgs e)
		{
			Class2413.smethod_2().method_41().method_174();
		}

		// Token: 0x06007023 RID: 28707 RVA: 0x00046920 File Offset: 0x00044B20
		private void Button_MCM_Click(object sender, RoutedEventArgs e)
		{
			if (!Information.IsNothing(Client.smethod_54()))
			{
				Class2413.smethod_2().method_43().Show();
			}
		}

		// Token: 0x06007024 RID: 28708 RVA: 0x003CAB1C File Offset: 0x003C8D1C
		private void ListView_GroupMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (this.vmethod_30().SelectedItem != null)
			{
				Group.GroupType groupType = this.group_0.method_143();
				if (groupType <= Group.GroupType.SubGroup)
				{
					string key = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_30().SelectedItem, null, "Tag", new object[0], null, null, null));
					if (Client.smethod_46().vmethod_0().ContainsKey(key))
					{
						Client.smethod_56(Client.smethod_46().vmethod_0()[key], true);
						if (Client.smethod_52().enum87_0 == Class285.Enum87.const_0)
						{
							Class2413.smethod_2().method_41().method_177();
							return;
						}
					}
				}
				else
				{
					string text = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_30().SelectedItem, null, "Tag", new object[0], null, null, null));
					string selectedObjectType = text.ToString().Split(new char[]
					{
						'_'
					})[0];
					int selectedObjectID = Conversions.ToInteger(text.ToString().Split(new char[]
					{
						'_'
					})[1]);
					Client.smethod_63(selectedObjectType, selectedObjectID, null);
				}
			}
		}

		// Token: 0x06007025 RID: 28709 RVA: 0x003CAC1C File Offset: 0x003C8E1C
		private void CB_GroupLeadSlowDown_Click(object sender, RoutedEventArgs e)
		{
			if (!Information.IsNothing(Client.smethod_54()) && Client.smethod_54().bool_1)
			{
				((Group)Client.smethod_54()).method_145().method_18(this.vmethod_42().IsChecked.Value);
			}
		}

		// Token: 0x06007026 RID: 28710 RVA: 0x003CAC68 File Offset: 0x003C8E68
		private void Hyperlink_Mission_Click(object sender, RoutedEventArgs e)
		{
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_96().Tag)))
			{
				Client.smethod_30().method_7((Mission)this.vmethod_96().Tag);
				if (!Client.smethod_30().Visible)
				{
					Client.smethod_30().Show();
					return;
				}
				Client.smethod_30().method_3();
			}
		}

		// Token: 0x06007027 RID: 28711 RVA: 0x003CACC8 File Offset: 0x003C8EC8
		private void Hyperlink_UnitClass_Click(object sender, RoutedEventArgs e)
		{
			ActiveUnit theAU = null;
			if (!Information.IsNothing(Client.smethod_54()))
			{
				if (Client.smethod_54().bool_0)
				{
					theAU = (ActiveUnit)Client.smethod_54();
				}
				if (Client.smethod_54().method_14())
				{
					theAU = ((Contact)Client.smethod_54()).activeUnit_0;
				}
				if (Client.smethod_54().bool_1 && ((Group)Client.smethod_54()).method_143() == Group.GroupType.AirGroup)
				{
					theAU = Enumerable.ElementAtOrDefault<ActiveUnit>(((Group)Client.smethod_54()).vmethod_141().Values, 0);
				}
				Client.smethod_64(theAU, null);
			}
		}

		// Token: 0x06007028 RID: 28712 RVA: 0x0004693D File Offset: 0x00044B3D
		private void Button_UnitMessageLog_Click(object sender, RoutedEventArgs e)
		{
			if (Client.smethod_54() != null)
			{
				Class2413.smethod_2().method_74().string_0 = Client.smethod_54().string_0;
				Class2413.smethod_2().method_74().Show();
			}
		}

		// Token: 0x06007029 RID: 28713 RVA: 0x0004696E File Offset: 0x00044B6E
		private void UnitStatus_WPF_Loaded(object sender, RoutedEventArgs e)
		{
			this.vmethod_2().ShowGridLines = GameGeneral.bool_5;
		}

		// Token: 0x0600702A RID: 28714 RVA: 0x00046980 File Offset: 0x00044B80
		private void method_9(Visibility visibility_0)
		{
			this.vmethod_94().Visibility = visibility_0;
		}

		// Token: 0x0600702B RID: 28715 RVA: 0x0004698E File Offset: 0x00044B8E
		private void method_10(Visibility visibility_0)
		{
			this.vmethod_92().Visibility = visibility_0;
		}

		// Token: 0x0600702C RID: 28716 RVA: 0x0004699C File Offset: 0x00044B9C
		private void method_11(Visibility visibility_0)
		{
			this.vmethod_50().Visibility = visibility_0;
			this.vmethod_52().Visibility = visibility_0;
		}

		// Token: 0x0600702D RID: 28717 RVA: 0x000469B6 File Offset: 0x00044BB6
		private void method_12(Visibility visibility_0)
		{
			this.vmethod_42().Visibility = visibility_0;
		}

		// Token: 0x0600702E RID: 28718 RVA: 0x000469C4 File Offset: 0x00044BC4
		private void method_13(Visibility visibility_0)
		{
			this.vmethod_106().Visibility = visibility_0;
			this.vmethod_108().Visibility = visibility_0;
		}

		// Token: 0x0600702F RID: 28719 RVA: 0x000469DE File Offset: 0x00044BDE
		private void method_14(Visibility visibility_0)
		{
			this.vmethod_68().Visibility = visibility_0;
			this.vmethod_70().Visibility = visibility_0;
		}

		// Token: 0x06007030 RID: 28720 RVA: 0x000469F8 File Offset: 0x00044BF8
		private void method_15(Visibility visibility_0)
		{
			this.vmethod_64().Visibility = visibility_0;
			this.vmethod_66().Visibility = visibility_0;
		}

		// Token: 0x06007031 RID: 28721 RVA: 0x00046A12 File Offset: 0x00044C12
		private void method_16(Visibility visibility_0)
		{
			this.vmethod_44().Visibility = visibility_0;
			this.vmethod_46().Visibility = visibility_0;
			this.vmethod_48().Visibility = visibility_0;
		}

		// Token: 0x06007032 RID: 28722 RVA: 0x00046A38 File Offset: 0x00044C38
		private void method_17(Visibility visibility_0)
		{
			this.vmethod_82().Visibility = visibility_0;
			this.vmethod_84().Visibility = visibility_0;
		}

		// Token: 0x06007033 RID: 28723 RVA: 0x00046A52 File Offset: 0x00044C52
		private void method_18(Visibility visibility_0)
		{
			this.vmethod_100().Visibility = visibility_0;
		}

		// Token: 0x06007034 RID: 28724 RVA: 0x00046A60 File Offset: 0x00044C60
		private void Button_EditHostedBoats_Click(object sender, RoutedEventArgs e)
		{
			Class2413.smethod_2().method_41().method_345();
		}

		// Token: 0x06007035 RID: 28725 RVA: 0x00046A71 File Offset: 0x00044C71
		private void Button_EditHostedAC_Click(object sender, RoutedEventArgs e)
		{
			Class2413.smethod_2().method_41().method_259();
		}

		// Token: 0x06007036 RID: 28726 RVA: 0x00046A82 File Offset: 0x00044C82
		[CompilerGenerated]
		internal Grid vmethod_2()
		{
			return this.grid_0;
		}

		// Token: 0x06007037 RID: 28727 RVA: 0x00046A8A File Offset: 0x00044C8A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Grid grid_1)
		{
			this.grid_0 = grid_1;
		}

		// Token: 0x06007038 RID: 28728 RVA: 0x00046A93 File Offset: 0x00044C93
		[CompilerGenerated]
		internal System.Windows.Controls.Label vmethod_4()
		{
			return this.label_0;
		}

		// Token: 0x06007039 RID: 28729 RVA: 0x00046A9B File Offset: 0x00044C9B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(System.Windows.Controls.Label label_12)
		{
			this.label_0 = label_12;
		}

		// Token: 0x0600703A RID: 28730 RVA: 0x00046AA4 File Offset: 0x00044CA4
		[CompilerGenerated]
		internal Image vmethod_6()
		{
			return this.image_0;
		}

		// Token: 0x0600703B RID: 28731 RVA: 0x00046AAC File Offset: 0x00044CAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Image image_1)
		{
			this.image_0 = image_1;
		}

		// Token: 0x0600703C RID: 28732 RVA: 0x00046AB5 File Offset: 0x00044CB5
		[CompilerGenerated]
		internal TextBlock vmethod_8()
		{
			return this.textBlock_0;
		}

		// Token: 0x0600703D RID: 28733 RVA: 0x00046ABD File Offset: 0x00044CBD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TextBlock textBlock_8)
		{
			this.textBlock_0 = textBlock_8;
		}

		// Token: 0x0600703E RID: 28734 RVA: 0x00046AC6 File Offset: 0x00044CC6
		[CompilerGenerated]
		internal Hyperlink vmethod_10()
		{
			return this.hyperlink_0;
		}

		// Token: 0x0600703F RID: 28735 RVA: 0x003CAD58 File Offset: 0x003C8F58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Hyperlink hyperlink_2)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Hyperlink_UnitClass_Click);
			Hyperlink hyperlink = this.hyperlink_0;
			if (hyperlink != null)
			{
				hyperlink.Click -= value;
			}
			this.hyperlink_0 = hyperlink_2;
			hyperlink = this.hyperlink_0;
			if (hyperlink != null)
			{
				hyperlink.Click += value;
			}
		}

		// Token: 0x06007040 RID: 28736 RVA: 0x00046ACE File Offset: 0x00044CCE
		[CompilerGenerated]
		internal Run vmethod_12()
		{
			return this.run_0;
		}

		// Token: 0x06007041 RID: 28737 RVA: 0x00046AD6 File Offset: 0x00044CD6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Run run_4)
		{
			this.run_0 = run_4;
		}

		// Token: 0x06007042 RID: 28738 RVA: 0x00046ADF File Offset: 0x00044CDF
		[CompilerGenerated]
		internal TextBlock vmethod_14()
		{
			return this.textBlock_1;
		}

		// Token: 0x06007043 RID: 28739 RVA: 0x00046AE7 File Offset: 0x00044CE7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(TextBlock textBlock_8)
		{
			this.textBlock_1 = textBlock_8;
		}

		// Token: 0x06007044 RID: 28740 RVA: 0x00046AF0 File Offset: 0x00044CF0
		[CompilerGenerated]
		internal Run vmethod_16()
		{
			return this.run_1;
		}

		// Token: 0x06007045 RID: 28741 RVA: 0x00046AF8 File Offset: 0x00044CF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Run run_4)
		{
			this.run_1 = run_4;
		}

		// Token: 0x06007046 RID: 28742 RVA: 0x00046B01 File Offset: 0x00044D01
		[CompilerGenerated]
		internal TextBlock vmethod_18()
		{
			return this.textBlock_2;
		}

		// Token: 0x06007047 RID: 28743 RVA: 0x00046B09 File Offset: 0x00044D09
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(TextBlock textBlock_8)
		{
			this.textBlock_2 = textBlock_8;
		}

		// Token: 0x06007048 RID: 28744 RVA: 0x00046B12 File Offset: 0x00044D12
		[CompilerGenerated]
		internal Run vmethod_20()
		{
			return this.run_2;
		}

		// Token: 0x06007049 RID: 28745 RVA: 0x00046B1A File Offset: 0x00044D1A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Run run_4)
		{
			this.run_2 = run_4;
		}

		// Token: 0x0600704A RID: 28746 RVA: 0x00046B23 File Offset: 0x00044D23
		[CompilerGenerated]
		internal System.Windows.Controls.Label vmethod_22()
		{
			return this.label_1;
		}

		// Token: 0x0600704B RID: 28747 RVA: 0x00046B2B File Offset: 0x00044D2B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(System.Windows.Controls.Label label_12)
		{
			this.label_1 = label_12;
		}

		// Token: 0x0600704C RID: 28748 RVA: 0x00046B34 File Offset: 0x00044D34
		[CompilerGenerated]
		internal System.Windows.Controls.Button vmethod_24()
		{
			return this.button_0;
		}

		// Token: 0x0600704D RID: 28749 RVA: 0x003CAD9C File Offset: 0x003C8F9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(System.Windows.Controls.Button button_12)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button_ContactReport_Click);
			System.Windows.Controls.Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_12;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600704E RID: 28750 RVA: 0x00046B3C File Offset: 0x00044D3C
		[CompilerGenerated]
		internal System.Windows.Controls.Button vmethod_26()
		{
			return this.button_1;
		}

		// Token: 0x0600704F RID: 28751 RVA: 0x003CADE0 File Offset: 0x003C8FE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(System.Windows.Controls.Button button_12)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button_UnitMessageLog_Click);
			System.Windows.Controls.Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_12;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06007050 RID: 28752 RVA: 0x00046B44 File Offset: 0x00044D44
		[CompilerGenerated]
		internal Expander vmethod_28()
		{
			return this.expander_0;
		}

		// Token: 0x06007051 RID: 28753 RVA: 0x003CAE24 File Offset: 0x003C9024
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Expander expander_2)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Expander_GroupMembers_Collapsed);
			RoutedEventHandler value2 = new RoutedEventHandler(this.Expander_GroupMembers_Expanded);
			Expander expander = this.expander_0;
			if (expander != null)
			{
				expander.Collapsed -= value;
				expander.Expanded -= value2;
			}
			this.expander_0 = expander_2;
			expander = this.expander_0;
			if (expander != null)
			{
				expander.Collapsed += value;
				expander.Expanded += value2;
			}
		}

		// Token: 0x06007052 RID: 28754 RVA: 0x00046B4C File Offset: 0x00044D4C
		[CompilerGenerated]
		internal System.Windows.Controls.ListView vmethod_30()
		{
			return this.listView_0;
		}

		// Token: 0x06007053 RID: 28755 RVA: 0x003CAE84 File Offset: 0x003C9084
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(System.Windows.Controls.ListView listView_2)
		{
			SelectionChangedEventHandler value = new SelectionChangedEventHandler(this.ListView_GroupMembers_SelectionChanged);
			System.Windows.Controls.ListView listView = this.listView_0;
			if (listView != null)
			{
				listView.SelectionChanged -= value;
			}
			this.listView_0 = listView_2;
			listView = this.listView_0;
			if (listView != null)
			{
				listView.SelectionChanged += value;
			}
		}

		// Token: 0x06007054 RID: 28756 RVA: 0x00046B54 File Offset: 0x00044D54
		[CompilerGenerated]
		internal TextBlock vmethod_32()
		{
			return this.textBlock_3;
		}

		// Token: 0x06007055 RID: 28757 RVA: 0x00046B5C File Offset: 0x00044D5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(TextBlock textBlock_8)
		{
			this.textBlock_3 = textBlock_8;
		}

		// Token: 0x06007056 RID: 28758 RVA: 0x00046B65 File Offset: 0x00044D65
		[CompilerGenerated]
		internal System.Windows.Controls.Label vmethod_34()
		{
			return this.label_2;
		}

		// Token: 0x06007057 RID: 28759 RVA: 0x00046B6D File Offset: 0x00044D6D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(System.Windows.Controls.Label label_12)
		{
			this.label_2 = label_12;
		}

		// Token: 0x06007058 RID: 28760 RVA: 0x00046B76 File Offset: 0x00044D76
		[CompilerGenerated]
		internal System.Windows.Controls.Label vmethod_36()
		{
			return this.label_3;
		}

		// Token: 0x06007059 RID: 28761 RVA: 0x00046B7E File Offset: 0x00044D7E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(System.Windows.Controls.Label label_12)
		{
			this.label_3 = label_12;
		}

		// Token: 0x0600705A RID: 28762 RVA: 0x00046B87 File Offset: 0x00044D87
		[CompilerGenerated]
		internal System.Windows.Controls.Label vmethod_38()
		{
			return this.label_4;
		}

		// Token: 0x0600705B RID: 28763 RVA: 0x00046B8F File Offset: 0x00044D8F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(System.Windows.Controls.Label label_12)
		{
			this.label_4 = label_12;
		}

		// Token: 0x0600705C RID: 28764 RVA: 0x00046B98 File Offset: 0x00044D98
		[CompilerGenerated]
		internal System.Windows.Controls.Label vmethod_40()
		{
			return this.label_5;
		}

		// Token: 0x0600705D RID: 28765 RVA: 0x00046BA0 File Offset: 0x00044DA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(System.Windows.Controls.Label label_12)
		{
			this.label_5 = label_12;
		}

		// Token: 0x0600705E RID: 28766 RVA: 0x00046BA9 File Offset: 0x00044DA9
		[CompilerGenerated]
		internal System.Windows.Controls.CheckBox vmethod_42()
		{
			return this.checkBox_0;
		}

		// Token: 0x0600705F RID: 28767 RVA: 0x003CAEC8 File Offset: 0x003C90C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(System.Windows.Controls.CheckBox checkBox_1)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.CB_GroupLeadSlowDown_Click);
			System.Windows.Controls.CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_0 = checkBox_1;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06007060 RID: 28768 RVA: 0x00046BB1 File Offset: 0x00044DB1
		[CompilerGenerated]
		internal System.Windows.Controls.Label vmethod_44()
		{
			return this.label_6;
		}

		// Token: 0x06007061 RID: 28769 RVA: 0x00046BB9 File Offset: 0x00044DB9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(System.Windows.Controls.Label label_12)
		{
			this.label_6 = label_12;
		}

		// Token: 0x06007062 RID: 28770 RVA: 0x00046BC2 File Offset: 0x00044DC2
		[CompilerGenerated]
		internal TextBlock vmethod_46()
		{
			return this.textBlock_4;
		}

		// Token: 0x06007063 RID: 28771 RVA: 0x00046BCA File Offset: 0x00044DCA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(TextBlock textBlock_8)
		{
			this.textBlock_4 = textBlock_8;
		}

		// Token: 0x06007064 RID: 28772 RVA: 0x00046BD3 File Offset: 0x00044DD3
		[CompilerGenerated]
		internal System.Windows.Controls.Button vmethod_48()
		{
			return this.button_2;
		}

		// Token: 0x06007065 RID: 28773 RVA: 0x003CAF0C File Offset: 0x003C910C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(System.Windows.Controls.Button button_12)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button_Damage_Click);
			System.Windows.Controls.Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_12;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06007066 RID: 28774 RVA: 0x00046BDB File Offset: 0x00044DDB
		[CompilerGenerated]
		internal System.Windows.Controls.Label vmethod_50()
		{
			return this.label_7;
		}

		// Token: 0x06007067 RID: 28775 RVA: 0x00046BE3 File Offset: 0x00044DE3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(System.Windows.Controls.Label label_12)
		{
			this.label_7 = label_12;
		}

		// Token: 0x06007068 RID: 28776 RVA: 0x00046BEC File Offset: 0x00044DEC
		[CompilerGenerated]
		internal DockPanel vmethod_52()
		{
			return this.dockPanel_0;
		}

		// Token: 0x06007069 RID: 28777 RVA: 0x00046BF4 File Offset: 0x00044DF4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(DockPanel dockPanel_2)
		{
			this.dockPanel_0 = dockPanel_2;
		}

		// Token: 0x0600706A RID: 28778 RVA: 0x00046BFD File Offset: 0x00044DFD
		[CompilerGenerated]
		internal System.Windows.Controls.ProgressBar vmethod_54()
		{
			return this.progressBar_0;
		}

		// Token: 0x0600706B RID: 28779 RVA: 0x00046C05 File Offset: 0x00044E05
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(System.Windows.Controls.ProgressBar progressBar_8)
		{
			this.progressBar_0 = progressBar_8;
		}

		// Token: 0x0600706C RID: 28780 RVA: 0x00046C0E File Offset: 0x00044E0E
		[CompilerGenerated]
		internal System.Windows.Controls.ProgressBar vmethod_56()
		{
			return this.progressBar_1;
		}

		// Token: 0x0600706D RID: 28781 RVA: 0x00046C16 File Offset: 0x00044E16
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(System.Windows.Controls.ProgressBar progressBar_8)
		{
			this.progressBar_1 = progressBar_8;
		}

		// Token: 0x0600706E RID: 28782 RVA: 0x00046C1F File Offset: 0x00044E1F
		[CompilerGenerated]
		internal System.Windows.Controls.ProgressBar vmethod_58()
		{
			return this.progressBar_2;
		}

		// Token: 0x0600706F RID: 28783 RVA: 0x00046C27 File Offset: 0x00044E27
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(System.Windows.Controls.ProgressBar progressBar_8)
		{
			this.progressBar_2 = progressBar_8;
		}

		// Token: 0x06007070 RID: 28784 RVA: 0x00046C30 File Offset: 0x00044E30
		[CompilerGenerated]
		internal System.Windows.Controls.ProgressBar vmethod_60()
		{
			return this.progressBar_3;
		}

		// Token: 0x06007071 RID: 28785 RVA: 0x00046C38 File Offset: 0x00044E38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(System.Windows.Controls.ProgressBar progressBar_8)
		{
			this.progressBar_3 = progressBar_8;
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x00046C41 File Offset: 0x00044E41
		[CompilerGenerated]
		internal System.Windows.Controls.ProgressBar vmethod_62()
		{
			return this.progressBar_4;
		}

		// Token: 0x06007073 RID: 28787 RVA: 0x00046C49 File Offset: 0x00044E49
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(System.Windows.Controls.ProgressBar progressBar_8)
		{
			this.progressBar_4 = progressBar_8;
		}

		// Token: 0x06007074 RID: 28788 RVA: 0x00046C52 File Offset: 0x00044E52
		[CompilerGenerated]
		internal System.Windows.Controls.Label vmethod_64()
		{
			return this.label_8;
		}

		// Token: 0x06007075 RID: 28789 RVA: 0x00046C5A File Offset: 0x00044E5A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(System.Windows.Controls.Label label_12)
		{
			this.label_8 = label_12;
		}

		// Token: 0x06007076 RID: 28790 RVA: 0x00046C63 File Offset: 0x00044E63
		[CompilerGenerated]
		internal System.Windows.Controls.ProgressBar vmethod_66()
		{
			return this.progressBar_5;
		}

		// Token: 0x06007077 RID: 28791 RVA: 0x00046C6B File Offset: 0x00044E6B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(System.Windows.Controls.ProgressBar progressBar_8)
		{
			this.progressBar_5 = progressBar_8;
		}

		// Token: 0x06007078 RID: 28792 RVA: 0x00046C74 File Offset: 0x00044E74
		[CompilerGenerated]
		internal System.Windows.Controls.Label vmethod_68()
		{
			return this.label_9;
		}

		// Token: 0x06007079 RID: 28793 RVA: 0x00046C7C File Offset: 0x00044E7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(System.Windows.Controls.Label label_12)
		{
			this.label_9 = label_12;
		}

		// Token: 0x0600707A RID: 28794 RVA: 0x00046C85 File Offset: 0x00044E85
		[CompilerGenerated]
		internal System.Windows.Controls.ProgressBar vmethod_70()
		{
			return this.progressBar_6;
		}

		// Token: 0x0600707B RID: 28795 RVA: 0x00046C8D File Offset: 0x00044E8D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(System.Windows.Controls.ProgressBar progressBar_8)
		{
			this.progressBar_6 = progressBar_8;
		}

		// Token: 0x0600707C RID: 28796 RVA: 0x00046C96 File Offset: 0x00044E96
		[CompilerGenerated]
		internal System.Windows.Controls.Label vmethod_72()
		{
			return this.label_10;
		}

		// Token: 0x0600707D RID: 28797 RVA: 0x00046C9E File Offset: 0x00044E9E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(System.Windows.Controls.Label label_12)
		{
			this.label_10 = label_12;
		}

		// Token: 0x0600707E RID: 28798 RVA: 0x00046CA7 File Offset: 0x00044EA7
		[CompilerGenerated]
		internal System.Windows.Controls.ProgressBar vmethod_74()
		{
			return this.progressBar_7;
		}

		// Token: 0x0600707F RID: 28799 RVA: 0x00046CAF File Offset: 0x00044EAF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(System.Windows.Controls.ProgressBar progressBar_8)
		{
			this.progressBar_7 = progressBar_8;
		}

		// Token: 0x06007080 RID: 28800 RVA: 0x00046CB8 File Offset: 0x00044EB8
		[CompilerGenerated]
		internal System.Windows.Controls.Button vmethod_76()
		{
			return this.button_3;
		}

		// Token: 0x06007081 RID: 28801 RVA: 0x003CAF50 File Offset: 0x003C9150
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(System.Windows.Controls.Button button_12)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button_MCM_Click);
			System.Windows.Controls.Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_12;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06007082 RID: 28802 RVA: 0x00046CC0 File Offset: 0x00044EC0
		[CompilerGenerated]
		internal System.Windows.Controls.Button vmethod_78()
		{
			return this.button_4;
		}

		// Token: 0x06007083 RID: 28803 RVA: 0x003CAF94 File Offset: 0x003C9194
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(System.Windows.Controls.Button button_12)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button_CargoOps_Click);
			System.Windows.Controls.Button button = this.button_4;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_4 = button_12;
			button = this.button_4;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06007084 RID: 28804 RVA: 0x00046CC8 File Offset: 0x00044EC8
		[CompilerGenerated]
		internal System.Windows.Controls.Button vmethod_80()
		{
			return this.button_5;
		}

		// Token: 0x06007085 RID: 28805 RVA: 0x003CAFD8 File Offset: 0x003C91D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(System.Windows.Controls.Button button_12)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button_Magazines_Click);
			System.Windows.Controls.Button button = this.button_5;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_5 = button_12;
			button = this.button_5;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06007086 RID: 28806 RVA: 0x00046CD0 File Offset: 0x00044ED0
		[CompilerGenerated]
		internal System.Windows.Controls.Button vmethod_82()
		{
			return this.button_6;
		}

		// Token: 0x06007087 RID: 28807 RVA: 0x003CB01C File Offset: 0x003C921C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(System.Windows.Controls.Button button_12)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button_DockOps_Click);
			System.Windows.Controls.Button button = this.button_6;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_6 = button_12;
			button = this.button_6;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06007088 RID: 28808 RVA: 0x00046CD8 File Offset: 0x00044ED8
		[CompilerGenerated]
		internal System.Windows.Controls.Button vmethod_84()
		{
			return this.button_7;
		}

		// Token: 0x06007089 RID: 28809 RVA: 0x003CB060 File Offset: 0x003C9260
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(System.Windows.Controls.Button button_12)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button_AirOps_Click);
			System.Windows.Controls.Button button = this.button_7;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_7 = button_12;
			button = this.button_7;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600708A RID: 28810 RVA: 0x00046CE0 File Offset: 0x00044EE0
		[CompilerGenerated]
		internal DockPanel vmethod_86()
		{
			return this.dockPanel_1;
		}

		// Token: 0x0600708B RID: 28811 RVA: 0x00046CE8 File Offset: 0x00044EE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(DockPanel dockPanel_2)
		{
			this.dockPanel_1 = dockPanel_2;
		}

		// Token: 0x0600708C RID: 28812 RVA: 0x00046CF1 File Offset: 0x00044EF1
		[CompilerGenerated]
		internal System.Windows.Controls.Button vmethod_88()
		{
			return this.button_8;
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x003CB0A4 File Offset: 0x003C92A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(System.Windows.Controls.Button button_12)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button_EditHostedBoats_Click);
			System.Windows.Controls.Button button = this.button_8;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_8 = button_12;
			button = this.button_8;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600708E RID: 28814 RVA: 0x00046CF9 File Offset: 0x00044EF9
		[CompilerGenerated]
		internal System.Windows.Controls.Button vmethod_90()
		{
			return this.button_9;
		}

		// Token: 0x0600708F RID: 28815 RVA: 0x003CB0E8 File Offset: 0x003C92E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(System.Windows.Controls.Button button_12)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button_EditHostedAC_Click);
			System.Windows.Controls.Button button = this.button_9;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_9 = button_12;
			button = this.button_9;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06007090 RID: 28816 RVA: 0x00046D01 File Offset: 0x00044F01
		[CompilerGenerated]
		internal TextBlock vmethod_92()
		{
			return this.textBlock_5;
		}

		// Token: 0x06007091 RID: 28817 RVA: 0x00046D09 File Offset: 0x00044F09
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(TextBlock textBlock_8)
		{
			this.textBlock_5 = textBlock_8;
		}

		// Token: 0x06007092 RID: 28818 RVA: 0x00046D12 File Offset: 0x00044F12
		[CompilerGenerated]
		internal TextBlock vmethod_94()
		{
			return this.textBlock_6;
		}

		// Token: 0x06007093 RID: 28819 RVA: 0x00046D1A File Offset: 0x00044F1A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(TextBlock textBlock_8)
		{
			this.textBlock_6 = textBlock_8;
		}

		// Token: 0x06007094 RID: 28820 RVA: 0x00046D23 File Offset: 0x00044F23
		[CompilerGenerated]
		internal Hyperlink vmethod_96()
		{
			return this.hyperlink_1;
		}

		// Token: 0x06007095 RID: 28821 RVA: 0x003CB12C File Offset: 0x003C932C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_97(Hyperlink hyperlink_2)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Hyperlink_Mission_Click);
			Hyperlink hyperlink = this.hyperlink_1;
			if (hyperlink != null)
			{
				hyperlink.Click -= value;
			}
			this.hyperlink_1 = hyperlink_2;
			hyperlink = this.hyperlink_1;
			if (hyperlink != null)
			{
				hyperlink.Click += value;
			}
		}

		// Token: 0x06007096 RID: 28822 RVA: 0x00046D2B File Offset: 0x00044F2B
		[CompilerGenerated]
		internal Run vmethod_98()
		{
			return this.run_3;
		}

		// Token: 0x06007097 RID: 28823 RVA: 0x00046D33 File Offset: 0x00044F33
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_99(Run run_4)
		{
			this.run_3 = run_4;
		}

		// Token: 0x06007098 RID: 28824 RVA: 0x00046D3C File Offset: 0x00044F3C
		[CompilerGenerated]
		internal TextBlock vmethod_100()
		{
			return this.textBlock_7;
		}

		// Token: 0x06007099 RID: 28825 RVA: 0x00046D44 File Offset: 0x00044F44
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_101(TextBlock textBlock_8)
		{
			this.textBlock_7 = textBlock_8;
		}

		// Token: 0x0600709A RID: 28826 RVA: 0x00046D4D File Offset: 0x00044F4D
		[CompilerGenerated]
		internal Expander vmethod_102()
		{
			return this.expander_1;
		}

		// Token: 0x0600709B RID: 28827 RVA: 0x003CB170 File Offset: 0x003C9370
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_103(Expander expander_2)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Expander_TankerClients_Collapsed);
			RoutedEventHandler value2 = new RoutedEventHandler(this.Expander_TankerClients_Expanded);
			Expander expander = this.expander_1;
			if (expander != null)
			{
				expander.Collapsed -= value;
				expander.Expanded -= value2;
			}
			this.expander_1 = expander_2;
			expander = this.expander_1;
			if (expander != null)
			{
				expander.Collapsed += value;
				expander.Expanded += value2;
			}
		}

		// Token: 0x0600709C RID: 28828 RVA: 0x00046D55 File Offset: 0x00044F55
		[CompilerGenerated]
		internal System.Windows.Controls.ListView vmethod_104()
		{
			return this.listView_1;
		}

		// Token: 0x0600709D RID: 28829 RVA: 0x00046D5D File Offset: 0x00044F5D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_105(System.Windows.Controls.ListView listView_2)
		{
			this.listView_1 = listView_2;
		}

		// Token: 0x0600709E RID: 28830 RVA: 0x00046D66 File Offset: 0x00044F66
		[CompilerGenerated]
		internal System.Windows.Controls.Button vmethod_106()
		{
			return this.button_10;
		}

		// Token: 0x0600709F RID: 28831 RVA: 0x003CB1D0 File Offset: 0x003C93D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_107(System.Windows.Controls.Button button_12)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button_Sensors_Click);
			System.Windows.Controls.Button button = this.button_10;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_10 = button_12;
			button = this.button_10;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060070A0 RID: 28832 RVA: 0x00046D6E File Offset: 0x00044F6E
		[CompilerGenerated]
		internal System.Windows.Controls.Button vmethod_108()
		{
			return this.button_11;
		}

		// Token: 0x060070A1 RID: 28833 RVA: 0x003CB214 File Offset: 0x003C9414
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_109(System.Windows.Controls.Button button_12)
		{
			RoutedEventHandler value = new RoutedEventHandler(this.Button_Weapons_Click);
			System.Windows.Controls.Button button = this.button_11;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_11 = button_12;
			button = this.button_11;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060070A2 RID: 28834 RVA: 0x00046D76 File Offset: 0x00044F76
		[CompilerGenerated]
		internal System.Windows.Controls.Label vmethod_110()
		{
			return this.label_11;
		}

		// Token: 0x060070A3 RID: 28835 RVA: 0x00046D7E File Offset: 0x00044F7E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_111(System.Windows.Controls.Label label_12)
		{
			this.label_11 = label_12;
		}

		// Token: 0x060070A4 RID: 28836 RVA: 0x003CB258 File Offset: 0x003C9458
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Command;component/customcontrols/rightcolumn/unitstatus_wpf.xaml", UriKind.Relative);
				System.Windows.Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060070A5 RID: 28837 RVA: 0x003CB288 File Offset: 0x003C9488
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.vmethod_3((Grid)target);
				return;
			}
			if (connectionId == 2)
			{
				this.vmethod_5((System.Windows.Controls.Label)target);
				return;
			}
			if (connectionId == 3)
			{
				this.vmethod_7((Image)target);
				return;
			}
			if (connectionId == 4)
			{
				this.vmethod_9((TextBlock)target);
				return;
			}
			if (connectionId == 5)
			{
				this.vmethod_11((Hyperlink)target);
				return;
			}
			if (connectionId == 6)
			{
				this.vmethod_13((Run)target);
				return;
			}
			if (connectionId == 7)
			{
				this.vmethod_15((TextBlock)target);
				return;
			}
			if (connectionId == 8)
			{
				this.vmethod_17((Run)target);
				return;
			}
			if (connectionId == 9)
			{
				this.vmethod_19((TextBlock)target);
				return;
			}
			if (connectionId == 10)
			{
				this.vmethod_21((Run)target);
				return;
			}
			if (connectionId == 11)
			{
				this.vmethod_23((System.Windows.Controls.Label)target);
				return;
			}
			if (connectionId == 12)
			{
				this.vmethod_25((System.Windows.Controls.Button)target);
				return;
			}
			if (connectionId == 13)
			{
				this.vmethod_27((System.Windows.Controls.Button)target);
				return;
			}
			if (connectionId == 14)
			{
				this.vmethod_29((Expander)target);
				return;
			}
			if (connectionId == 15)
			{
				this.vmethod_31((System.Windows.Controls.ListView)target);
				return;
			}
			if (connectionId == 16)
			{
				this.vmethod_33((TextBlock)target);
				return;
			}
			if (connectionId == 17)
			{
				this.vmethod_35((System.Windows.Controls.Label)target);
				return;
			}
			if (connectionId == 18)
			{
				this.vmethod_37((System.Windows.Controls.Label)target);
				return;
			}
			if (connectionId == 19)
			{
				this.vmethod_39((System.Windows.Controls.Label)target);
				return;
			}
			if (connectionId == 20)
			{
				this.vmethod_41((System.Windows.Controls.Label)target);
				return;
			}
			if (connectionId == 21)
			{
				this.vmethod_43((System.Windows.Controls.CheckBox)target);
				return;
			}
			if (connectionId == 22)
			{
				this.vmethod_45((System.Windows.Controls.Label)target);
				return;
			}
			if (connectionId == 23)
			{
				this.vmethod_47((TextBlock)target);
				return;
			}
			if (connectionId == 24)
			{
				this.vmethod_49((System.Windows.Controls.Button)target);
				return;
			}
			if (connectionId == 25)
			{
				this.vmethod_51((System.Windows.Controls.Label)target);
				return;
			}
			if (connectionId == 26)
			{
				this.vmethod_53((DockPanel)target);
				return;
			}
			if (connectionId == 27)
			{
				this.vmethod_55((System.Windows.Controls.ProgressBar)target);
				return;
			}
			if (connectionId == 28)
			{
				this.vmethod_57((System.Windows.Controls.ProgressBar)target);
				return;
			}
			if (connectionId == 29)
			{
				this.vmethod_59((System.Windows.Controls.ProgressBar)target);
				return;
			}
			if (connectionId == 30)
			{
				this.vmethod_61((System.Windows.Controls.ProgressBar)target);
				return;
			}
			if (connectionId == 31)
			{
				this.vmethod_63((System.Windows.Controls.ProgressBar)target);
				return;
			}
			if (connectionId == 32)
			{
				this.vmethod_65((System.Windows.Controls.Label)target);
				return;
			}
			if (connectionId == 33)
			{
				this.vmethod_67((System.Windows.Controls.ProgressBar)target);
				return;
			}
			if (connectionId == 34)
			{
				this.vmethod_69((System.Windows.Controls.Label)target);
				return;
			}
			if (connectionId == 35)
			{
				this.vmethod_71((System.Windows.Controls.ProgressBar)target);
				return;
			}
			if (connectionId == 36)
			{
				this.vmethod_73((System.Windows.Controls.Label)target);
				return;
			}
			if (connectionId == 37)
			{
				this.vmethod_75((System.Windows.Controls.ProgressBar)target);
				return;
			}
			if (connectionId == 38)
			{
				this.vmethod_77((System.Windows.Controls.Button)target);
				return;
			}
			if (connectionId == 39)
			{
				this.vmethod_79((System.Windows.Controls.Button)target);
				return;
			}
			if (connectionId == 40)
			{
				this.vmethod_81((System.Windows.Controls.Button)target);
				return;
			}
			if (connectionId == 41)
			{
				this.vmethod_83((System.Windows.Controls.Button)target);
				return;
			}
			if (connectionId == 42)
			{
				this.vmethod_85((System.Windows.Controls.Button)target);
				return;
			}
			if (connectionId == 43)
			{
				this.vmethod_87((DockPanel)target);
				return;
			}
			if (connectionId == 44)
			{
				this.vmethod_89((System.Windows.Controls.Button)target);
				return;
			}
			if (connectionId == 45)
			{
				this.vmethod_91((System.Windows.Controls.Button)target);
				return;
			}
			if (connectionId == 46)
			{
				this.vmethod_93((TextBlock)target);
				return;
			}
			if (connectionId == 47)
			{
				this.vmethod_95((TextBlock)target);
				return;
			}
			if (connectionId == 48)
			{
				this.vmethod_97((Hyperlink)target);
				return;
			}
			if (connectionId == 49)
			{
				this.vmethod_99((Run)target);
				return;
			}
			if (connectionId == 50)
			{
				this.vmethod_101((TextBlock)target);
				return;
			}
			if (connectionId == 51)
			{
				this.vmethod_103((Expander)target);
				return;
			}
			if (connectionId == 52)
			{
				this.vmethod_105((System.Windows.Controls.ListView)target);
				return;
			}
			if (connectionId == 53)
			{
				this.vmethod_107((System.Windows.Controls.Button)target);
				return;
			}
			if (connectionId == 54)
			{
				this.vmethod_109((System.Windows.Controls.Button)target);
				return;
			}
			if (connectionId == 55)
			{
				this.vmethod_111((System.Windows.Controls.Label)target);
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04003F62 RID: 16226
		[CompilerGenerated]
		private static UnitStatus_WPF.Delegate90 delegate90_0;

		// Token: 0x04003F63 RID: 16227
		[CompilerGenerated]
		private static UnitStatus_WPF.Delegate91 delegate91_0;

		// Token: 0x04003F64 RID: 16228
		[CompilerGenerated]
		private static UnitStatus_WPF.Delegate92 delegate92_0;

		// Token: 0x04003F65 RID: 16229
		[CompilerGenerated]
		private static UnitStatus_WPF.Delegate93 delegate93_0;

		// Token: 0x04003F66 RID: 16230
		[CompilerGenerated]
		private static UnitStatus_WPF.Delegate94 delegate94_0;

		// Token: 0x04003F67 RID: 16231
		private Group group_0;

		// Token: 0x04003F68 RID: 16232
		private string string_0;

		// Token: 0x04003F69 RID: 16233
		private BitmapImage bitmapImage_0;

		// Token: 0x04003F6A RID: 16234
		[AccessedThroughProperty("theBW")]
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04003F6B RID: 16235
		private string string_1;

		// Token: 0x04003F6C RID: 16236
		private BitmapImage bitmapImage_1;

		// Token: 0x04003F6D RID: 16237
		[CompilerGenerated]
		[AccessedThroughProperty("MasterGrid")]
		private Grid grid_0;

		// Token: 0x04003F6E RID: 16238
		[CompilerGenerated]
		[AccessedThroughProperty("Label_UnitName")]
		private System.Windows.Controls.Label label_0;

		// Token: 0x04003F6F RID: 16239
		[AccessedThroughProperty("Image_UnitImage")]
		[CompilerGenerated]
		private Image image_0;

		// Token: 0x04003F70 RID: 16240
		[CompilerGenerated]
		[AccessedThroughProperty("OuterTextBlock_UnitClass")]
		private TextBlock textBlock_0;

		// Token: 0x04003F71 RID: 16241
		[CompilerGenerated]
		[AccessedThroughProperty("Hyperlink_UnitClass")]
		private Hyperlink hyperlink_0;

		// Token: 0x04003F72 RID: 16242
		[CompilerGenerated]
		[AccessedThroughProperty("TextBlock_UnitClass")]
		private Run run_0;

		// Token: 0x04003F73 RID: 16243
		[CompilerGenerated]
		[AccessedThroughProperty("OuterTextBlock_UnitCategory")]
		private TextBlock textBlock_1;

		// Token: 0x04003F74 RID: 16244
		[CompilerGenerated]
		[AccessedThroughProperty("TextBlock_UnitCategory")]
		private Run run_1;

		// Token: 0x04003F75 RID: 16245
		[CompilerGenerated]
		[AccessedThroughProperty("OuterTextBlock_UnitType")]
		private TextBlock textBlock_2;

		// Token: 0x04003F76 RID: 16246
		[CompilerGenerated]
		[AccessedThroughProperty("TextBlock_UnitType")]
		private Run run_2;

		// Token: 0x04003F77 RID: 16247
		[AccessedThroughProperty("Label_UnitProficiency")]
		[CompilerGenerated]
		private System.Windows.Controls.Label label_1;

		// Token: 0x04003F78 RID: 16248
		[AccessedThroughProperty("Button_ContactReport")]
		[CompilerGenerated]
		private System.Windows.Controls.Button button_0;

		// Token: 0x04003F79 RID: 16249
		[AccessedThroughProperty("Button_UnitMessageLog")]
		[CompilerGenerated]
		private System.Windows.Controls.Button button_1;

		// Token: 0x04003F7A RID: 16250
		[AccessedThroughProperty("Expander_GroupMembers")]
		[CompilerGenerated]
		private Expander expander_0;

		// Token: 0x04003F7B RID: 16251
		[AccessedThroughProperty("ListView_GroupMembers")]
		[CompilerGenerated]
		private System.Windows.Controls.ListView listView_0;

		// Token: 0x04003F7C RID: 16252
		[AccessedThroughProperty("TextBlock_Loadout")]
		[CompilerGenerated]
		private TextBlock textBlock_3;

		// Token: 0x04003F7D RID: 16253
		[CompilerGenerated]
		[AccessedThroughProperty("Label_UnitSide")]
		private System.Windows.Controls.Label label_2;

		// Token: 0x04003F7E RID: 16254
		[CompilerGenerated]
		[AccessedThroughProperty("Label_UnitCourse")]
		private System.Windows.Controls.Label label_3;

		// Token: 0x04003F7F RID: 16255
		[CompilerGenerated]
		[AccessedThroughProperty("Label_UnitSpeed")]
		private System.Windows.Controls.Label label_4;

		// Token: 0x04003F80 RID: 16256
		[AccessedThroughProperty("Label_UnitAlt")]
		[CompilerGenerated]
		private System.Windows.Controls.Label label_5;

		// Token: 0x04003F81 RID: 16257
		[CompilerGenerated]
		[AccessedThroughProperty("CB_GroupLeadSlowDown")]
		private System.Windows.Controls.CheckBox checkBox_0;

		// Token: 0x04003F82 RID: 16258
		[CompilerGenerated]
		[AccessedThroughProperty("Label_DamageLabel")]
		private System.Windows.Controls.Label label_6;

		// Token: 0x04003F83 RID: 16259
		[CompilerGenerated]
		[AccessedThroughProperty("Label_UnitDamage")]
		private TextBlock textBlock_4;

		// Token: 0x04003F84 RID: 16260
		[AccessedThroughProperty("Button_Damage")]
		[CompilerGenerated]
		private System.Windows.Controls.Button button_2;

		// Token: 0x04003F85 RID: 16261
		[AccessedThroughProperty("ComponentStatusLabel")]
		[CompilerGenerated]
		private System.Windows.Controls.Label label_7;

		// Token: 0x04003F86 RID: 16262
		[CompilerGenerated]
		[AccessedThroughProperty("ComponentStatusDockPanel")]
		private DockPanel dockPanel_0;

		// Token: 0x04003F87 RID: 16263
		[CompilerGenerated]
		[AccessedThroughProperty("PB_ComponentsDestroyed")]
		private System.Windows.Controls.ProgressBar progressBar_0;

		// Token: 0x04003F88 RID: 16264
		[AccessedThroughProperty("PB_ComponentsHeavyDamage")]
		[CompilerGenerated]
		private System.Windows.Controls.ProgressBar progressBar_1;

		// Token: 0x04003F89 RID: 16265
		[AccessedThroughProperty("PB_ComponentsMediumDamage")]
		[CompilerGenerated]
		private System.Windows.Controls.ProgressBar progressBar_2;

		// Token: 0x04003F8A RID: 16266
		[AccessedThroughProperty("PB_ComponentsLightDamage")]
		[CompilerGenerated]
		private System.Windows.Controls.ProgressBar progressBar_3;

		// Token: 0x04003F8B RID: 16267
		[AccessedThroughProperty("PB_ComponentsOK")]
		[CompilerGenerated]
		private System.Windows.Controls.ProgressBar progressBar_4;

		// Token: 0x04003F8C RID: 16268
		[AccessedThroughProperty("Label_FireDamage")]
		[CompilerGenerated]
		private System.Windows.Controls.Label label_8;

		// Token: 0x04003F8D RID: 16269
		[CompilerGenerated]
		[AccessedThroughProperty("PB_FireDamage")]
		private System.Windows.Controls.ProgressBar progressBar_5;

		// Token: 0x04003F8E RID: 16270
		[CompilerGenerated]
		[AccessedThroughProperty("Label_FloodDamage")]
		private System.Windows.Controls.Label label_9;

		// Token: 0x04003F8F RID: 16271
		[CompilerGenerated]
		[AccessedThroughProperty("PB_FloodDamage")]
		private System.Windows.Controls.ProgressBar progressBar_6;

		// Token: 0x04003F90 RID: 16272
		[AccessedThroughProperty("Label_GTolerance")]
		[CompilerGenerated]
		private System.Windows.Controls.Label label_10;

		// Token: 0x04003F91 RID: 16273
		[AccessedThroughProperty("PB_GTolerance")]
		[CompilerGenerated]
		private System.Windows.Controls.ProgressBar progressBar_7;

		// Token: 0x04003F92 RID: 16274
		[AccessedThroughProperty("Button_MCM")]
		[CompilerGenerated]
		private System.Windows.Controls.Button button_3;

		// Token: 0x04003F93 RID: 16275
		[AccessedThroughProperty("Button_CargoOps")]
		[CompilerGenerated]
		private System.Windows.Controls.Button button_4;

		// Token: 0x04003F94 RID: 16276
		[AccessedThroughProperty("Button_Magazines")]
		[CompilerGenerated]
		private System.Windows.Controls.Button button_5;

		// Token: 0x04003F95 RID: 16277
		[AccessedThroughProperty("Button_DockOps")]
		[CompilerGenerated]
		private System.Windows.Controls.Button button_6;

		// Token: 0x04003F96 RID: 16278
		[AccessedThroughProperty("Button_AirOps")]
		[CompilerGenerated]
		private System.Windows.Controls.Button button_7;

		// Token: 0x04003F97 RID: 16279
		[AccessedThroughProperty("Dockpanel_EditHosted")]
		[CompilerGenerated]
		private DockPanel dockPanel_1;

		// Token: 0x04003F98 RID: 16280
		[CompilerGenerated]
		[AccessedThroughProperty("Button_EditHostedBoats")]
		private System.Windows.Controls.Button button_8;

		// Token: 0x04003F99 RID: 16281
		[AccessedThroughProperty("Button_EditHostedAC")]
		[CompilerGenerated]
		private System.Windows.Controls.Button button_9;

		// Token: 0x04003F9A RID: 16282
		[CompilerGenerated]
		[AccessedThroughProperty("TextBlock_AssignedHost")]
		private TextBlock textBlock_5;

		// Token: 0x04003F9B RID: 16283
		[CompilerGenerated]
		[AccessedThroughProperty("TextBlock_Mission")]
		private TextBlock textBlock_6;

		// Token: 0x04003F9C RID: 16284
		[AccessedThroughProperty("Hyperlink_Mission")]
		[CompilerGenerated]
		private Hyperlink hyperlink_1;

		// Token: 0x04003F9D RID: 16285
		[AccessedThroughProperty("TextBlock_MissionName")]
		[CompilerGenerated]
		private Run run_3;

		// Token: 0x04003F9E RID: 16286
		[AccessedThroughProperty("TextBlock_UnitStatus")]
		[CompilerGenerated]
		private TextBlock textBlock_7;

		// Token: 0x04003F9F RID: 16287
		[CompilerGenerated]
		[AccessedThroughProperty("Expander_TankerClients")]
		private Expander expander_1;

		// Token: 0x04003FA0 RID: 16288
		[AccessedThroughProperty("ListView_TankerClients")]
		[CompilerGenerated]
		private System.Windows.Controls.ListView listView_1;

		// Token: 0x04003FA1 RID: 16289
		[CompilerGenerated]
		[AccessedThroughProperty("Button_Sensors")]
		private System.Windows.Controls.Button button_10;

		// Token: 0x04003FA2 RID: 16290
		[AccessedThroughProperty("Button_Weapons")]
		[CompilerGenerated]
		private System.Windows.Controls.Button button_11;

		// Token: 0x04003FA3 RID: 16291
		[CompilerGenerated]
		[AccessedThroughProperty("Label_ContactWRAType")]
		private System.Windows.Controls.Label label_11;

		// Token: 0x04003FA4 RID: 16292
		private bool bool_0;

		// Token: 0x02000E61 RID: 3681
		// (Invoke) Token: 0x060070A9 RID: 28841
		internal delegate void Delegate90();

		// Token: 0x02000E62 RID: 3682
		// (Invoke) Token: 0x060070AD RID: 28845
		internal delegate void Delegate91();

		// Token: 0x02000E63 RID: 3683
		// (Invoke) Token: 0x060070B1 RID: 28849
		internal delegate void Delegate92();

		// Token: 0x02000E64 RID: 3684
		// (Invoke) Token: 0x060070B5 RID: 28853
		internal delegate void Delegate93();

		// Token: 0x02000E65 RID: 3685
		// (Invoke) Token: 0x060070B9 RID: 28857
		internal delegate void Delegate94();

		// Token: 0x02000E67 RID: 3687
		[CompilerGenerated]
		internal sealed class Class2476
		{
			// Token: 0x060070C2 RID: 28866 RVA: 0x00046DA0 File Offset: 0x00044FA0
			public Class2476(UnitStatus_WPF.Class2476 class2476_0)
			{
				if (class2476_0 != null)
				{
					this.string_0 = class2476_0.string_0;
				}
			}

			// Token: 0x060070C3 RID: 28867 RVA: 0x00046DB7 File Offset: 0x00044FB7
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return string.CompareOrdinal(Misc.smethod_9(activeUnit_0.string_2), this.string_0) == 0;
			}

			// Token: 0x04003FAC RID: 16300
			public string string_0;
		}
	}
}
