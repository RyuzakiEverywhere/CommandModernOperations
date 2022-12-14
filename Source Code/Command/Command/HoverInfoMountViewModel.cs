using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ns14;

namespace Command
{
	// Token: 0x02000DED RID: 3565
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class HoverInfoMountViewModel : INotifyPropertyChanged
	{
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x0600671C RID: 26396 RVA: 0x000413A1 File Offset: 0x0003F5A1
		// (set) Token: 0x0600671D RID: 26397 RVA: 0x000413A9 File Offset: 0x0003F5A9
		public string Header
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
				this.vmethod_0("Header");
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600671E RID: 26398 RVA: 0x000413CD File Offset: 0x0003F5CD
		// (set) Token: 0x0600671F RID: 26399 RVA: 0x000413D5 File Offset: 0x0003F5D5
		public int Quantity
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
				this.vmethod_0("Quantity");
			}
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06006720 RID: 26400 RVA: 0x003870EC File Offset: 0x003852EC
		// (remove) Token: 0x06006721 RID: 26401 RVA: 0x00387124 File Offset: 0x00385324
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

		// Token: 0x06006722 RID: 26402 RVA: 0x0038715C File Offset: 0x0038535C
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003ABA RID: 15034
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003ABB RID: 15035
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04003ABC RID: 15036
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
