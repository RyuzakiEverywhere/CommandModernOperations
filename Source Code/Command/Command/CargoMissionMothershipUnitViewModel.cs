using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using ns14;

namespace Command
{
	// Token: 0x02000D9F RID: 3487
	[Attribute3]
	[Attribute2]
	[Attribute0]
	public sealed class CargoMissionMothershipUnitViewModel : INotifyPropertyChanged
	{
		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06005DBD RID: 23997 RVA: 0x0003C5A5 File Offset: 0x0003A7A5
		// (set) Token: 0x06005DBE RID: 23998 RVA: 0x0003C5AD File Offset: 0x0003A7AD
		public string Name
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
				this.vmethod_0("Name");
			}
		}

		// Token: 0x06005DBF RID: 23999 RVA: 0x0003C5D1 File Offset: 0x0003A7D1
		public CargoMissionMothershipUnitViewModel(ActiveUnit theUnit)
		{
			this.activeUnit_0 = theUnit;
			this.Name = theUnit.Name;
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06005DC0 RID: 24000 RVA: 0x00330F90 File Offset: 0x0032F190
		// (remove) Token: 0x06005DC1 RID: 24001 RVA: 0x00330FC8 File Offset: 0x0032F1C8
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

		// Token: 0x06005DC2 RID: 24002 RVA: 0x00331000 File Offset: 0x0032F200
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003679 RID: 13945
		public ActiveUnit activeUnit_0;

		// Token: 0x0400367A RID: 13946
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400367B RID: 13947
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
