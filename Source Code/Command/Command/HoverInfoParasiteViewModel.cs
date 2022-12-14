using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ns14;

namespace Command
{
	// Token: 0x02000DE9 RID: 3561
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class HoverInfoParasiteViewModel : INotifyPropertyChanged
	{
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060066FC RID: 26364 RVA: 0x0004124D File Offset: 0x0003F44D
		// (set) Token: 0x060066FD RID: 26365 RVA: 0x00041255 File Offset: 0x0003F455
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

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060066FE RID: 26366 RVA: 0x00041279 File Offset: 0x0003F479
		// (set) Token: 0x060066FF RID: 26367 RVA: 0x00041281 File Offset: 0x0003F481
		public string Ready
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
				this.vmethod_0("Ready");
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06006700 RID: 26368 RVA: 0x00386E8C File Offset: 0x0038508C
		// (remove) Token: 0x06006701 RID: 26369 RVA: 0x00386EC4 File Offset: 0x003850C4
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

		// Token: 0x06006702 RID: 26370 RVA: 0x00386EFC File Offset: 0x003850FC
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003AAE RID: 15022
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003AAF RID: 15023
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04003AB0 RID: 15024
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
