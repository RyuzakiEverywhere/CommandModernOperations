using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using ns14;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000D94 RID: 3476
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class UnitSpeedAltViewModel : INotifyPropertyChanged
	{
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06005D1F RID: 23839 RVA: 0x0003BD84 File Offset: 0x00039F84
		// (set) Token: 0x06005D20 RID: 23840 RVA: 0x0003BD8C File Offset: 0x00039F8C
		public ObservableCollection<UnitSpeedAltRadioButtonWrapperViewModel> Alts
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
				this.vmethod_0("Alts");
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06005D21 RID: 23841 RVA: 0x0003BDAC File Offset: 0x00039FAC
		// (set) Token: 0x06005D22 RID: 23842 RVA: 0x0003BDB4 File Offset: 0x00039FB4
		public ObservableCollection<UnitSpeedAltRadioButtonWrapperViewModel> Speeds
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_1 == value)
				{
					return;
				}
				this.observableCollection_1 = value;
				this.vmethod_0("Speeds");
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06005D23 RID: 23843 RVA: 0x0003BDD4 File Offset: 0x00039FD4
		// (set) Token: 0x06005D24 RID: 23844 RVA: 0x0003BDDC File Offset: 0x00039FDC
		public Visibility Visible
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_0 == value)
				{
					return;
				}
				this.visibility_0 = value;
				this.vmethod_0("Visible");
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06005D25 RID: 23845 RVA: 0x0003BDFC File Offset: 0x00039FFC
		// (set) Token: 0x06005D26 RID: 23846 RVA: 0x0003BE04 File Offset: 0x0003A004
		public Visibility SpeedVis
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_1 == value)
				{
					return;
				}
				this.visibility_1 = value;
				this.vmethod_0("SpeedVis");
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06005D27 RID: 23847 RVA: 0x0003BE24 File Offset: 0x0003A024
		// (set) Token: 0x06005D28 RID: 23848 RVA: 0x0003BE2C File Offset: 0x0003A02C
		public Visibility AltVis
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_2 == value)
				{
					return;
				}
				this.visibility_2 = value;
				this.vmethod_0("AltVis");
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06005D29 RID: 23849 RVA: 0x0003BE4C File Offset: 0x0003A04C
		// (set) Token: 0x06005D2A RID: 23850 RVA: 0x0003BE54 File Offset: 0x0003A054
		public Class2569 ManualSpeedCommand
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
				this.vmethod_0("ManualSpeedCommand");
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06005D2B RID: 23851 RVA: 0x0003BE74 File Offset: 0x0003A074
		// (set) Token: 0x06005D2C RID: 23852 RVA: 0x0003BE7C File Offset: 0x0003A07C
		public Class2569 ManualAltCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_1 == value)
				{
					return;
				}
				this.class2569_1 = value;
				this.vmethod_0("ManualAltCommand");
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06005D2D RID: 23853 RVA: 0x0003BE9C File Offset: 0x0003A09C
		// (set) Token: 0x06005D2E RID: 23854 RVA: 0x0003BEA4 File Offset: 0x0003A0A4
		public bool ManualAltChecked
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
				this.vmethod_0("ManualAltChecked");
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06005D2F RID: 23855 RVA: 0x0003BEC4 File Offset: 0x0003A0C4
		// (set) Token: 0x06005D30 RID: 23856 RVA: 0x0003BECC File Offset: 0x0003A0CC
		public bool ManualSpeedChecked
		{
			[CompilerGenerated]
			get
			{
				return this.bool_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.bool_1 == value)
				{
					return;
				}
				this.bool_1 = value;
				this.vmethod_0("ManualSpeedChecked");
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06005D31 RID: 23857 RVA: 0x0003BEEC File Offset: 0x0003A0EC
		// (set) Token: 0x06005D32 RID: 23858 RVA: 0x0003BEF4 File Offset: 0x0003A0F4
		public string ManualAltText
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
				this.vmethod_0("ManualAltText");
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06005D33 RID: 23859 RVA: 0x0003BF18 File Offset: 0x0003A118
		// (set) Token: 0x06005D34 RID: 23860 RVA: 0x0003BF20 File Offset: 0x0003A120
		public string ManualSpeedText
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_1, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_1 = value;
				this.vmethod_0("ManualSpeedText");
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06005D35 RID: 23861 RVA: 0x0003BF44 File Offset: 0x0003A144
		// (set) Token: 0x06005D36 RID: 23862 RVA: 0x0003BF4C File Offset: 0x0003A14C
		public Visibility ManualAltVis
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_3 == value)
				{
					return;
				}
				this.visibility_3 = value;
				this.vmethod_0("ManualAltVis");
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06005D37 RID: 23863 RVA: 0x0003BF6C File Offset: 0x0003A16C
		// (set) Token: 0x06005D38 RID: 23864 RVA: 0x0003BF74 File Offset: 0x0003A174
		public Visibility ManualSpeedVis
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_4;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_4 == value)
				{
					return;
				}
				this.visibility_4 = value;
				this.vmethod_0("ManualSpeedVis");
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06005D39 RID: 23865 RVA: 0x0003BF94 File Offset: 0x0003A194
		// (set) Token: 0x06005D3A RID: 23866 RVA: 0x0003BF9C File Offset: 0x0003A19C
		public Class2569 PreviousWaypointCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_2 == value)
				{
					return;
				}
				this.class2569_2 = value;
				this.vmethod_0("PreviousWaypointCommand");
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06005D3B RID: 23867 RVA: 0x0003BFBC File Offset: 0x0003A1BC
		// (set) Token: 0x06005D3C RID: 23868 RVA: 0x0003BFC4 File Offset: 0x0003A1C4
		public string CurrentWaypointString
		{
			[CompilerGenerated]
			get
			{
				return this.string_2;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_2, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_2 = value;
				this.vmethod_0("CurrentWaypointString");
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06005D3D RID: 23869 RVA: 0x0003BFE8 File Offset: 0x0003A1E8
		// (set) Token: 0x06005D3E RID: 23870 RVA: 0x0003BFF0 File Offset: 0x0003A1F0
		public Class2569 NextWaypointCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_3 == value)
				{
					return;
				}
				this.class2569_3 = value;
				this.vmethod_0("NextWaypointCommand");
			}
		}

		// Token: 0x06005D3F RID: 23871 RVA: 0x0003C010 File Offset: 0x0003A210
		private void method_0()
		{
			Class2413.smethod_2().method_66().method_56(null, null);
			this.method_4(false);
		}

		// Token: 0x06005D40 RID: 23872 RVA: 0x0003C02A File Offset: 0x0003A22A
		private void method_1()
		{
			Class2413.smethod_2().method_66().method_57(null, null);
			this.method_4(false);
		}

		// Token: 0x06005D41 RID: 23873 RVA: 0x0032ED14 File Offset: 0x0032CF14
		public UnitSpeedAltViewModel()
		{
			this.Alts = new ObservableCollection<UnitSpeedAltRadioButtonWrapperViewModel>(new List<UnitSpeedAltRadioButtonWrapperViewModel>
			{
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_66()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_64()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_62()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_54()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_56()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_60()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_58()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_68()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_48()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_50()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_46()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_44()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_42())
			});
			this.Speeds = new ObservableCollection<UnitSpeedAltRadioButtonWrapperViewModel>(new List<UnitSpeedAltRadioButtonWrapperViewModel>
			{
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_84()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_82()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_80()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_78()),
				new UnitSpeedAltRadioButtonWrapperViewModel(this, Class2413.smethod_2().method_66().vmethod_86())
			});
			this.Visible = Visibility.Collapsed;
			this.ManualSpeedCommand = new Class2569(new Action<object>(this.method_5));
			this.ManualAltCommand = new Class2569(new Action<object>(this.method_6));
			this.PreviousWaypointCommand = new Class2569(new Action<object>(this.method_7));
			this.NextWaypointCommand = new Class2569(new Action<object>(this.method_8));
			this.method_4(false);
		}

		// Token: 0x06005D42 RID: 23874 RVA: 0x0003C044 File Offset: 0x0003A244
		private void method_2()
		{
			Class2413.smethod_2().method_66().vmethod_38().Checked = false;
			Class2413.smethod_2().method_66().method_46(null, null);
			this.method_4(false);
		}

		// Token: 0x06005D43 RID: 23875 RVA: 0x0003C073 File Offset: 0x0003A273
		private void method_3()
		{
			Class2413.smethod_2().method_66().vmethod_36().Checked = false;
			Class2413.smethod_2().method_66().method_45(null, null);
			this.method_4(false);
		}

		// Token: 0x06005D44 RID: 23876 RVA: 0x0032EF9C File Offset: 0x0032D19C
		public void method_4(bool TriggeredBySpeedAltForm)
		{
			if (Client.smethod_54() == null)
			{
				this.Visible = Visibility.Collapsed;
				return;
			}
			this.Visible = Visibility.Visible;
			try
			{
				foreach (UnitSpeedAltRadioButtonWrapperViewModel unitSpeedAltRadioButtonWrapperViewModel in this.Speeds)
				{
					unitSpeedAltRadioButtonWrapperViewModel.method_1();
				}
			}
			finally
			{
				IEnumerator<UnitSpeedAltRadioButtonWrapperViewModel> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				foreach (UnitSpeedAltRadioButtonWrapperViewModel unitSpeedAltRadioButtonWrapperViewModel2 in this.Alts)
				{
					unitSpeedAltRadioButtonWrapperViewModel2.method_1();
				}
			}
			finally
			{
				IEnumerator<UnitSpeedAltRadioButtonWrapperViewModel> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			if (Enumerable.Any<UnitSpeedAltRadioButtonWrapperViewModel>(this.Speeds, (UnitSpeedAltViewModel._Closure$__.$I69-0 == null) ? (UnitSpeedAltViewModel._Closure$__.$I69-0 = new Func<UnitSpeedAltRadioButtonWrapperViewModel, bool>(UnitSpeedAltViewModel._Closure$__.$I.method_0)) : UnitSpeedAltViewModel._Closure$__.$I69-0))
			{
				this.SpeedVis = Visibility.Visible;
			}
			else
			{
				this.SpeedVis = Visibility.Collapsed;
			}
			if (Enumerable.Any<UnitSpeedAltRadioButtonWrapperViewModel>(this.Alts, (UnitSpeedAltViewModel._Closure$__.$I69-1 == null) ? (UnitSpeedAltViewModel._Closure$__.$I69-1 = new Func<UnitSpeedAltRadioButtonWrapperViewModel, bool>(UnitSpeedAltViewModel._Closure$__.$I.method_1)) : UnitSpeedAltViewModel._Closure$__.$I69-1))
			{
				this.AltVis = Visibility.Visible;
			}
			else
			{
				this.AltVis = Visibility.Collapsed;
			}
			if (!TriggeredBySpeedAltForm)
			{
				Class2413.smethod_2().method_66().method_5(true);
			}
			this.ManualSpeedChecked = Class2413.smethod_2().method_66().vmethod_38().Checked;
			this.ManualAltChecked = Class2413.smethod_2().method_66().vmethod_36().Checked;
			this.CurrentWaypointString = Class2413.smethod_2().method_66().vmethod_166().Text;
			if (this.ManualSpeedChecked)
			{
				this.ManualSpeedVis = Visibility.Visible;
				this.ManualSpeedText = "Set Auto";
			}
			else
			{
				this.ManualSpeedVis = Visibility.Hidden;
				this.ManualSpeedText = "";
			}
			if (this.ManualAltChecked)
			{
				this.ManualAltVis = Visibility.Visible;
				this.ManualAltText = "Set Auto";
			}
			else
			{
				this.ManualAltVis = Visibility.Hidden;
				this.ManualAltText = "";
			}
			if (this.AltVis == Visibility.Collapsed)
			{
				this.ManualAltVis = Visibility.Collapsed;
			}
			if (this.SpeedVis == Visibility.Collapsed)
			{
				this.ManualSpeedVis = Visibility.Collapsed;
			}
		}

		// Token: 0x06005D45 RID: 23877 RVA: 0x0003C0A2 File Offset: 0x0003A2A2
		[CompilerGenerated]
		private void method_5(object a0)
		{
			this.method_2();
		}

		// Token: 0x06005D46 RID: 23878 RVA: 0x0003C0AA File Offset: 0x0003A2AA
		[CompilerGenerated]
		private void method_6(object a0)
		{
			this.method_3();
		}

		// Token: 0x06005D47 RID: 23879 RVA: 0x0003C0B2 File Offset: 0x0003A2B2
		[CompilerGenerated]
		private void method_7(object a0)
		{
			this.method_0();
		}

		// Token: 0x06005D48 RID: 23880 RVA: 0x0003C0BA File Offset: 0x0003A2BA
		[CompilerGenerated]
		private void method_8(object a0)
		{
			this.method_1();
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06005D49 RID: 23881 RVA: 0x0032F198 File Offset: 0x0032D398
		// (remove) Token: 0x06005D4A RID: 23882 RVA: 0x0032F1D0 File Offset: 0x0032D3D0
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

		// Token: 0x06005D4B RID: 23883 RVA: 0x0032F208 File Offset: 0x0032D408
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003631 RID: 13873
		[CompilerGenerated]
		private ObservableCollection<UnitSpeedAltRadioButtonWrapperViewModel> observableCollection_0;

		// Token: 0x04003632 RID: 13874
		[CompilerGenerated]
		private ObservableCollection<UnitSpeedAltRadioButtonWrapperViewModel> observableCollection_1;

		// Token: 0x04003633 RID: 13875
		[CompilerGenerated]
		private Visibility visibility_0;

		// Token: 0x04003634 RID: 13876
		[CompilerGenerated]
		private Visibility visibility_1;

		// Token: 0x04003635 RID: 13877
		[CompilerGenerated]
		private Visibility visibility_2;

		// Token: 0x04003636 RID: 13878
		[CompilerGenerated]
		private Class2569 class2569_0;

		// Token: 0x04003637 RID: 13879
		[CompilerGenerated]
		private Class2569 class2569_1;

		// Token: 0x04003638 RID: 13880
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04003639 RID: 13881
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x0400363A RID: 13882
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400363B RID: 13883
		[CompilerGenerated]
		private string string_1;

		// Token: 0x0400363C RID: 13884
		[CompilerGenerated]
		private Visibility visibility_3;

		// Token: 0x0400363D RID: 13885
		[CompilerGenerated]
		private Visibility visibility_4;

		// Token: 0x0400363E RID: 13886
		[CompilerGenerated]
		private Class2569 class2569_2;

		// Token: 0x0400363F RID: 13887
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04003640 RID: 13888
		[CompilerGenerated]
		private Class2569 class2569_3;

		// Token: 0x04003641 RID: 13889
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
