using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ns14;

namespace Command
{
	// Token: 0x02000DEB RID: 3563
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class HoverInfoWeaponViewModel : INotifyPropertyChanged
	{
		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600670C RID: 26380 RVA: 0x000412F9 File Offset: 0x0003F4F9
		// (set) Token: 0x0600670D RID: 26381 RVA: 0x00041301 File Offset: 0x0003F501
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

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600670E RID: 26382 RVA: 0x00041325 File Offset: 0x0003F525
		// (set) Token: 0x0600670F RID: 26383 RVA: 0x0004132D File Offset: 0x0003F52D
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

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06006710 RID: 26384 RVA: 0x00386FBC File Offset: 0x003851BC
		// (remove) Token: 0x06006711 RID: 26385 RVA: 0x00386FF4 File Offset: 0x003851F4
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

		// Token: 0x06006712 RID: 26386 RVA: 0x0038702C File Offset: 0x0038522C
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003AB4 RID: 15028
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003AB5 RID: 15029
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04003AB6 RID: 15030
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
