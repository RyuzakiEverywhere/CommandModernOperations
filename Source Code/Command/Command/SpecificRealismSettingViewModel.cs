using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media.Imaging;
using ns14;
using ns5;

namespace Command
{
	// Token: 0x02000E32 RID: 3634
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class SpecificRealismSettingViewModel : INotifyPropertyChanged
	{
		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06006CFA RID: 27898 RVA: 0x00044889 File Offset: 0x00042A89
		// (set) Token: 0x06006CFB RID: 27899 RVA: 0x00044891 File Offset: 0x00042A91
		public string Title
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
				this.vmethod_0("Title");
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06006CFC RID: 27900 RVA: 0x000448B5 File Offset: 0x00042AB5
		// (set) Token: 0x06006CFD RID: 27901 RVA: 0x000448BD File Offset: 0x00042ABD
		public string Subtitle
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
				this.vmethod_0("Subtitle");
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06006CFE RID: 27902 RVA: 0x000448E1 File Offset: 0x00042AE1
		// (set) Token: 0x06006CFF RID: 27903 RVA: 0x000448E9 File Offset: 0x00042AE9
		public bool Active
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
				this.vmethod_0("Active");
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06006D00 RID: 27904 RVA: 0x00044909 File Offset: 0x00042B09
		public static BitmapImage NegativeImageSource
		{
			get
			{
				return SpecificRealismSettingViewModel.bitmapImage_1;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06006D01 RID: 27905 RVA: 0x00044910 File Offset: 0x00042B10
		public static BitmapImage PositiveImageSource
		{
			get
			{
				return SpecificRealismSettingViewModel.bitmapImage_0;
			}
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06006D02 RID: 27906 RVA: 0x003BB468 File Offset: 0x003B9668
		// (remove) Token: 0x06006D03 RID: 27907 RVA: 0x003BB4A0 File Offset: 0x003B96A0
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

		// Token: 0x06006D04 RID: 27908 RVA: 0x003BB4D8 File Offset: 0x003B96D8
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003E23 RID: 15907
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003E24 RID: 15908
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04003E25 RID: 15909
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04003E26 RID: 15910
		private static BitmapImage bitmapImage_0 = new BitmapImage(new Uri(Class2413.smethod_1().Info.DirectoryPath + "/Symbols/Positive.png"));

		// Token: 0x04003E27 RID: 15911
		private static BitmapImage bitmapImage_1 = new BitmapImage(new Uri(Class2413.smethod_1().Info.DirectoryPath + "/Symbols/Negative.png"));

		// Token: 0x04003E28 RID: 15912
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
