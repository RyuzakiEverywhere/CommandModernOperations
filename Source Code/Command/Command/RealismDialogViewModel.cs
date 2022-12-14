using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media.Imaging;
using Command_Core;
using ns14;
using ns4;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000E33 RID: 3635
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class RealismDialogViewModel : INotifyPropertyChanged
	{
		// Token: 0x06006D05 RID: 27909 RVA: 0x003BB500 File Offset: 0x003B9700
		[Obsolete("Used for design time only", true)]
		public RealismDialogViewModel()
		{
			this.Items = new ObservableCollection<SpecificRealismSettingViewModel>();
			this.OKCommand = new Class2569(new Action<object>(this.method_1));
			this.YesIcon = Class2570.smethod_0(Class2417.smethod_7());
			this.NoIcon = Class2570.smethod_0(Class2417.smethod_5());
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "Detailed Gun Fire-Control",
				Subtitle = "Guns and other unguided weapons are affected (usually negatively) in their accuracy by a multitude of factors.",
				Active = true
			});
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "Unlimited Magazines",
				Subtitle = "Infinite munitions available at air and naval bases.",
				Active = false
			});
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "Communications Jamming",
				Subtitle = "Communications communications comments.",
				Active = true
			});
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "Aircraft Damage",
				Subtitle = "More realistic & detailed modelling of aircraft battle damage",
				Active = false
			});
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "Weather Affects Air Sorties",
				Subtitle = "Comments comments comments.",
				Active = true
			});
			this.ScenarioLength = "Duration: " + Misc.smethod_11((long)Math.Round(new TimeSpan(6, 0, 0).TotalSeconds), Aircraft_AirOps.Enum44.const_0, false, false);
		}

		// Token: 0x06006D06 RID: 27910 RVA: 0x003BB664 File Offset: 0x003B9864
		public RealismDialogViewModel(RealismDialog form, Scenario myScenario)
		{
			this.Items = new ObservableCollection<SpecificRealismSettingViewModel>();
			this.OKCommand = new Class2569(new Action<object>(this.method_2));
			this.YesIcon = Class2570.smethod_0(Class2417.smethod_7());
			this.NoIcon = Class2570.smethod_0(Class2417.smethod_5());
			this.realismDialog_0 = form;
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "Detailed Gun Fire-Control",
				Subtitle = "Unguided weapons accuracy suffers from various factors.",
				Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_1)
			});
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "Unlimited Base Magazines",
				Subtitle = "Infinite munitions for units available at air and naval bases.",
				Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2)
			});
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "Aircraft Damage",
				Subtitle = "More realistic & detailed modelling of aircraft battle damage",
				Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_3)
			});
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "Realistic Submarine Communications",
				Subtitle = "Submarines go off the communications grid when they submerge deep",
				Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_9)
			});
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "Effects of Terrain Type",
				Subtitle = "Terrain type affects mobility, sensor spotting and weapon effects",
				Active = myScenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_10)
			});
			this.Items.Add(new SpecificRealismSettingViewModel
			{
				Title = "Night & Weather Affect Air Sorties",
				Subtitle = "Aircraft sorties may be delayed/blocked by night & adverse weather.",
				Active = false
			});
			this.ScenarioLength = "Duration: " + Misc.smethod_11((long)Math.Round(myScenario.method_29().TotalSeconds), Aircraft_AirOps.Enum44.const_0, false, false);
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06006D07 RID: 27911 RVA: 0x00044917 File Offset: 0x00042B17
		// (set) Token: 0x06006D08 RID: 27912 RVA: 0x0004491F File Offset: 0x00042B1F
		public string ScenarioLength
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_0, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_0 = value;
				this.vmethod_0("ScenarioLength");
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06006D09 RID: 27913 RVA: 0x00044943 File Offset: 0x00042B43
		// (set) Token: 0x06006D0A RID: 27914 RVA: 0x0004494B File Offset: 0x00042B4B
		public ObservableCollection<SpecificRealismSettingViewModel> Items
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_0 == value)
				{
					return;
				}
				this.observableCollection_0 = value;
				this.vmethod_0("Items");
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06006D0B RID: 27915 RVA: 0x0004496B File Offset: 0x00042B6B
		// (set) Token: 0x06006D0C RID: 27916 RVA: 0x00044973 File Offset: 0x00042B73
		public Class2569 OKCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_0 == value)
				{
					return;
				}
				this.class2569_0 = value;
				this.vmethod_0("OKCommand");
			}
		}

		// Token: 0x06006D0D RID: 27917 RVA: 0x00044993 File Offset: 0x00042B93
		public void method_0()
		{
			this.realismDialog_0.Close();
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06006D0E RID: 27918 RVA: 0x000449A0 File Offset: 0x00042BA0
		// (set) Token: 0x06006D0F RID: 27919 RVA: 0x000449A8 File Offset: 0x00042BA8
		public BitmapImage YesIcon
		{
			[CompilerGenerated]
			get
			{
				return this.bitmapImage_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.bitmapImage_0 == value)
				{
					return;
				}
				this.bitmapImage_0 = value;
				this.vmethod_0("YesIcon");
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06006D10 RID: 27920 RVA: 0x000449C8 File Offset: 0x00042BC8
		// (set) Token: 0x06006D11 RID: 27921 RVA: 0x000449D0 File Offset: 0x00042BD0
		public BitmapImage NoIcon
		{
			[CompilerGenerated]
			get
			{
				return this.bitmapImage_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.bitmapImage_1 == value)
				{
					return;
				}
				this.bitmapImage_1 = value;
				this.vmethod_0("NoIcon");
			}
		}

		// Token: 0x06006D12 RID: 27922 RVA: 0x000449F0 File Offset: 0x00042BF0
		[CompilerGenerated]
		private void method_1(object a0)
		{
			this.method_0();
		}

		// Token: 0x06006D13 RID: 27923 RVA: 0x000449F0 File Offset: 0x00042BF0
		[CompilerGenerated]
		private void method_2(object a0)
		{
			this.method_0();
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06006D14 RID: 27924 RVA: 0x003BB834 File Offset: 0x003B9A34
		// (remove) Token: 0x06006D15 RID: 27925 RVA: 0x003BB86C File Offset: 0x003B9A6C
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

		// Token: 0x06006D16 RID: 27926 RVA: 0x003BB8A4 File Offset: 0x003B9AA4
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003E29 RID: 15913
		private RealismDialog realismDialog_0;

		// Token: 0x04003E2A RID: 15914
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003E2B RID: 15915
		[CompilerGenerated]
		private ObservableCollection<SpecificRealismSettingViewModel> observableCollection_0;

		// Token: 0x04003E2C RID: 15916
		[CompilerGenerated]
		private Class2569 class2569_0;

		// Token: 0x04003E2D RID: 15917
		[CompilerGenerated]
		private BitmapImage bitmapImage_0;

		// Token: 0x04003E2E RID: 15918
		[CompilerGenerated]
		private BitmapImage bitmapImage_1;

		// Token: 0x04003E2F RID: 15919
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
