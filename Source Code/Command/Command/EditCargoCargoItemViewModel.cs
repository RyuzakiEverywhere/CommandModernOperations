using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace Command
{
	// Token: 0x02000DB7 RID: 3511
	[Attribute3]
	[Attribute2]
	[Attribute0]
	public sealed class EditCargoCargoItemViewModel : INotifyPropertyChanged
	{
		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06005ECD RID: 24269 RVA: 0x0003D4DC File Offset: 0x0003B6DC
		// (set) Token: 0x06005ECE RID: 24270 RVA: 0x0003D4E4 File Offset: 0x0003B6E4
		public Cargo Cargo
		{
			[CompilerGenerated]
			get
			{
				return this.cargo_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.cargo_0 == value)
				{
					return;
				}
				this.cargo_0 = value;
				this.vmethod_0("Name");
				this.vmethod_0("Cargo");
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06005ECF RID: 24271 RVA: 0x0003D50F File Offset: 0x0003B70F
		// (set) Token: 0x06005ED0 RID: 24272 RVA: 0x0003D517 File Offset: 0x0003B717
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
				this.vmethod_0("Name");
				this.vmethod_0("Quantity");
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06005ED1 RID: 24273 RVA: 0x0003D542 File Offset: 0x0003B742
		public string Name
		{
			get
			{
				return Conversions.ToString(this.Quantity) + "x " + this.Cargo.method_26();
			}
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06005ED2 RID: 24274 RVA: 0x00333B94 File Offset: 0x00331D94
		// (remove) Token: 0x06005ED3 RID: 24275 RVA: 0x00333BCC File Offset: 0x00331DCC
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

		// Token: 0x06005ED4 RID: 24276 RVA: 0x00333C04 File Offset: 0x00331E04
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040036FE RID: 14078
		[CompilerGenerated]
		private Cargo cargo_0;

		// Token: 0x040036FF RID: 14079
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04003700 RID: 14080
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
