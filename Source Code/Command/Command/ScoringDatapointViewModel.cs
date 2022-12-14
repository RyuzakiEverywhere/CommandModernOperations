using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ns14;

namespace Command
{
	// Token: 0x02000E36 RID: 3638
	[Attribute3]
	[Attribute0]
	[Attribute2]
	public sealed class ScoringDatapointViewModel : INotifyPropertyChanged
	{
		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06006D38 RID: 27960 RVA: 0x00044ACA File Offset: 0x00042CCA
		// (set) Token: 0x06006D39 RID: 27961 RVA: 0x00044AD2 File Offset: 0x00042CD2
		public int ScoreValue
		{
			[CompilerGenerated]
			get
			{
				return this.int_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_0 == value)
				{
					return;
				}
				this.int_0 = value;
				this.vmethod_0("ScoreValue");
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06006D3A RID: 27962 RVA: 0x00044AF2 File Offset: 0x00042CF2
		// (set) Token: 0x06006D3B RID: 27963 RVA: 0x00044AFA File Offset: 0x00042CFA
		public DateTime DateTime
		{
			[CompilerGenerated]
			get
			{
				return this.dateTime_0;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.dateTime_0, value))
				{
					return;
				}
				this.dateTime_0 = value;
				this.vmethod_0("DateTime");
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06006D3C RID: 27964 RVA: 0x00044B1D File Offset: 0x00042D1D
		// (set) Token: 0x06006D3D RID: 27965 RVA: 0x00044B25 File Offset: 0x00042D25
		public string Reason
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
				this.vmethod_0("Reason");
			}
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06006D3E RID: 27966 RVA: 0x003BBF64 File Offset: 0x003BA164
		// (remove) Token: 0x06006D3F RID: 27967 RVA: 0x003BBF9C File Offset: 0x003BA19C
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

		// Token: 0x06006D40 RID: 27968 RVA: 0x003BBFD4 File Offset: 0x003BA1D4
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003E3C RID: 15932
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04003E3D RID: 15933
		[CompilerGenerated]
		private DateTime dateTime_0;

		// Token: 0x04003E3E RID: 15934
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003E3F RID: 15935
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
