using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using LiveCharts;
using ns14;

namespace Command
{
	// Token: 0x02000E37 RID: 3639
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class ScoringGraphControlViewModel : INotifyPropertyChanged
	{
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06006D42 RID: 27970 RVA: 0x00044B49 File Offset: 0x00042D49
		// (set) Token: 0x06006D43 RID: 27971 RVA: 0x00044B51 File Offset: 0x00042D51
		public ChartValues<ScoringDatapointViewModel> PlayerScore
		{
			[CompilerGenerated]
			get
			{
				return this.chartValues_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.chartValues_0 == value)
				{
					return;
				}
				this.chartValues_0 = value;
				this.vmethod_0("PlayerScore");
			}
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06006D44 RID: 27972 RVA: 0x003BBFFC File Offset: 0x003BA1FC
		// (remove) Token: 0x06006D45 RID: 27973 RVA: 0x003BC034 File Offset: 0x003BA234
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

		// Token: 0x06006D46 RID: 27974 RVA: 0x003BC06C File Offset: 0x003BA26C
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003E40 RID: 15936
		[CompilerGenerated]
		private ChartValues<ScoringDatapointViewModel> chartValues_0;

		// Token: 0x04003E41 RID: 15937
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
