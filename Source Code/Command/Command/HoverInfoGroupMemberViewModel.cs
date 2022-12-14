using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ns14;

namespace Command
{
	// Token: 0x02000DEA RID: 3562
	[Attribute2]
	[Attribute3]
	[Attribute0]
	public sealed class HoverInfoGroupMemberViewModel : INotifyPropertyChanged
	{
		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06006704 RID: 26372 RVA: 0x000412A5 File Offset: 0x0003F4A5
		// (set) Token: 0x06006705 RID: 26373 RVA: 0x000412AD File Offset: 0x0003F4AD
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

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06006706 RID: 26374 RVA: 0x000412D1 File Offset: 0x0003F4D1
		// (set) Token: 0x06006707 RID: 26375 RVA: 0x000412D9 File Offset: 0x0003F4D9
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

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06006708 RID: 26376 RVA: 0x00386F24 File Offset: 0x00385124
		// (remove) Token: 0x06006709 RID: 26377 RVA: 0x00386F5C File Offset: 0x0038515C
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

		// Token: 0x0600670A RID: 26378 RVA: 0x00386F94 File Offset: 0x00385194
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003AB1 RID: 15025
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003AB2 RID: 15026
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04003AB3 RID: 15027
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
