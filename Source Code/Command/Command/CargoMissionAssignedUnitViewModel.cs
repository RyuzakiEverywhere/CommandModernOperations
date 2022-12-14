using System;
using System.ComponentModel;
using System.Threading;
using Command_Core;
using ns14;

namespace Command
{
	// Token: 0x02000DA0 RID: 3488
	[Attribute2]
	[Attribute0]
	[Attribute3]
	public sealed class CargoMissionAssignedUnitViewModel : INotifyPropertyChanged
	{
		// Token: 0x06005DC3 RID: 24003 RVA: 0x0003C5EC File Offset: 0x0003A7EC
		public CargoMissionAssignedUnitViewModel(ActiveUnit theUnit)
		{
			this.activeUnit_0 = theUnit;
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06005DC4 RID: 24004 RVA: 0x00331028 File Offset: 0x0032F228
		// (remove) Token: 0x06005DC5 RID: 24005 RVA: 0x00331060 File Offset: 0x0032F260
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

		// Token: 0x06005DC6 RID: 24006 RVA: 0x00331098 File Offset: 0x0032F298
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400367C RID: 13948
		public ActiveUnit activeUnit_0;

		// Token: 0x0400367D RID: 13949
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
