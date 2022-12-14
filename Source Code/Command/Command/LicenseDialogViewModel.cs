using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using ns7;

namespace Command
{
	// Token: 0x02000DFB RID: 3579
	[Attribute11]
	[Attribute12]
	[Attribute13]
	public sealed class LicenseDialogViewModel : INotifyPropertyChanged
	{
		// Token: 0x06006869 RID: 26729 RVA: 0x00389CBC File Offset: 0x00387EBC
		[Obsolete("Used for design time only", true)]
		public LicenseDialogViewModel()
		{
			this.Items = new ObservableCollection<LicenseViewModel>();
			this.Items.Add(new LicenseViewModel
			{
				Title = "Aircraft Damage model",
				Subtitle = "",
				Required = true,
				Owned = false,
				AssociatedLicense = Class2556.Enum209.const_7
			});
			this.Items.Add(new LicenseViewModel
			{
				Title = "Cargo Operations",
				Subtitle = "",
				Required = true,
				Owned = false,
				AssociatedLicense = Class2556.Enum209.const_7
			});
			this.Items.Add(new LicenseViewModel
			{
				Title = "Communications Disruption",
				Subtitle = "",
				Required = true,
				Owned = false,
				AssociatedLicense = Class2556.Enum209.const_7
			});
			this.Items.Add(new LicenseViewModel
			{
				Title = "Tactical EMP (Omnidirectional)",
				Subtitle = "",
				Required = true,
				Owned = false,
				AssociatedLicense = Class2556.Enum209.const_7
			});
			this.Items.Add(new LicenseViewModel
			{
				Title = "High-Energy Lasers (Phase 2)",
				Subtitle = "",
				Required = true,
				Owned = false,
				AssociatedLicense = Class2556.Enum209.const_7
			});
			this.Items.Add(new LicenseViewModel
			{
				Title = "Railguns / HVPs",
				Subtitle = "",
				Required = true,
				Owned = false,
				AssociatedLicense = Class2556.Enum209.const_7
			});
			this.BeginScenarioEnabled = false;
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x00389E44 File Offset: 0x00388044
		public LicenseDialogViewModel(List<Scenario.ScenarioFeatureOption> theFeatureList)
		{
			this.Items = new ObservableCollection<LicenseViewModel>();
			try
			{
				foreach (Scenario.ScenarioFeatureOption scenarioFeatureOption in theFeatureList)
				{
					if (scenarioFeatureOption == Scenario.ScenarioFeatureOption.const_4)
					{
						this.Items.Add(new LicenseViewModel
						{
							Title = "Communications Jamming",
							Subtitle = "",
							Required = true,
							Owned = false,
							AssociatedLicense = Class2556.Enum209.const_8
						});
					}
				}
			}
			finally
			{
				List<Scenario.ScenarioFeatureOption>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.BeginScenarioEnabled = false;
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x0600686B RID: 26731 RVA: 0x000425EC File Offset: 0x000407EC
		// (set) Token: 0x0600686C RID: 26732 RVA: 0x000425F4 File Offset: 0x000407F4
		public bool BeginScenarioEnabled
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.bool_0 == value)
				{
					return;
				}
				this.bool_0 = value;
				this.vmethod_0("BeginScenarioEnabled");
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x0600686D RID: 26733 RVA: 0x00042614 File Offset: 0x00040814
		// (set) Token: 0x0600686E RID: 26734 RVA: 0x0004261C File Offset: 0x0004081C
		public ObservableCollection<LicenseViewModel> Items
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

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x0600686F RID: 26735 RVA: 0x00389EE4 File Offset: 0x003880E4
		// (remove) Token: 0x06006870 RID: 26736 RVA: 0x00389F1C File Offset: 0x0038811C
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

		// Token: 0x06006871 RID: 26737 RVA: 0x00389F54 File Offset: 0x00388154
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003B60 RID: 15200
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04003B61 RID: 15201
		[CompilerGenerated]
		private ObservableCollection<LicenseViewModel> observableCollection_0;

		// Token: 0x04003B62 RID: 15202
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
