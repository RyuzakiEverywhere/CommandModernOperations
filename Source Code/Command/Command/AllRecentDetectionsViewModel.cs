using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ns14;

namespace Command
{
	// Token: 0x02000D8B RID: 3467
	[Attribute3]
	[Attribute0]
	[Attribute2]
	public sealed class AllRecentDetectionsViewModel : INotifyPropertyChanged
	{
		// Token: 0x06005C78 RID: 23672 RVA: 0x0032D4E8 File Offset: 0x0032B6E8
		public AllRecentDetectionsViewModel()
		{
			this.Items = new ObservableCollection<RecentDetectionViewModel>();
			this.Items.Add(new RecentDetectionViewModel
			{
				PlatformName = "Platform Name1",
				SensorName = "Sensor Name123",
				PlatformDBID = 133,
				SensorDBID = 1536,
				TimeSinceDetection_String = "2d 7hrs",
				DetectionRange_String = "7.5nm"
			});
			this.Items.Add(new RecentDetectionViewModel
			{
				PlatformName = "Platform Name2",
				SensorName = "Sensor Name456",
				PlatformDBID = 141,
				SensorDBID = 1136,
				TimeSinceDetection_String = "2d 7hrs",
				DetectionRange_String = "7.5nm"
			});
			this.Items.Add(new RecentDetectionViewModel
			{
				PlatformName = "Platform Name3",
				SensorName = "Sensor Name789",
				PlatformDBID = 11465,
				SensorDBID = 1136,
				TimeSinceDetection_String = "2d 7hrs",
				DetectionRange_String = "7.5nm"
			});
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06005C79 RID: 23673 RVA: 0x0003B61C File Offset: 0x0003981C
		// (set) Token: 0x06005C7A RID: 23674 RVA: 0x0003B624 File Offset: 0x00039824
		public ObservableCollection<RecentDetectionViewModel> Items
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

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06005C7B RID: 23675 RVA: 0x0032D5FC File Offset: 0x0032B7FC
		// (remove) Token: 0x06005C7C RID: 23676 RVA: 0x0032D634 File Offset: 0x0032B834
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

		// Token: 0x06005C7D RID: 23677 RVA: 0x0032D66C File Offset: 0x0032B86C
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040035E8 RID: 13800
		[CompilerGenerated]
		private ObservableCollection<RecentDetectionViewModel> observableCollection_0;

		// Token: 0x040035E9 RID: 13801
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
