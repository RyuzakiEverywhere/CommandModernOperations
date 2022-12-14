using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ns14;

namespace Command
{
	// Token: 0x02000DEC RID: 3564
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class HoverInfoCargoViewModel : INotifyPropertyChanged
	{
		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06006714 RID: 26388 RVA: 0x0004134D File Offset: 0x0003F54D
		// (set) Token: 0x06006715 RID: 26389 RVA: 0x00041355 File Offset: 0x0003F555
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

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06006716 RID: 26390 RVA: 0x00041379 File Offset: 0x0003F579
		// (set) Token: 0x06006717 RID: 26391 RVA: 0x00041381 File Offset: 0x0003F581
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

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06006718 RID: 26392 RVA: 0x00387054 File Offset: 0x00385254
		// (remove) Token: 0x06006719 RID: 26393 RVA: 0x0038708C File Offset: 0x0038528C
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

		// Token: 0x0600671A RID: 26394 RVA: 0x003870C4 File Offset: 0x003852C4
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003AB7 RID: 15031
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003AB8 RID: 15032
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04003AB9 RID: 15033
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
