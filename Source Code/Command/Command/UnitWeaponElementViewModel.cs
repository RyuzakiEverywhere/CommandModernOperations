using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ns14;
using ns7;

namespace Command
{
	// Token: 0x02000D97 RID: 3479
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class UnitWeaponElementViewModel : INotifyPropertyChanged
	{
		// Token: 0x06005D58 RID: 23896 RVA: 0x0003C128 File Offset: 0x0003A328
		public UnitWeaponElementViewModel()
		{
			this.OpenDBViewerCommand = new Class2569(new Action<object>(this.method_1));
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06005D59 RID: 23897 RVA: 0x0003C147 File Offset: 0x0003A347
		// (set) Token: 0x06005D5A RID: 23898 RVA: 0x0003C14F File Offset: 0x0003A34F
		public int WeaponDBID
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
				this.vmethod_0("WeaponDBID");
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06005D5B RID: 23899 RVA: 0x0003C16F File Offset: 0x0003A36F
		// (set) Token: 0x06005D5C RID: 23900 RVA: 0x0003C177 File Offset: 0x0003A377
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

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06005D5D RID: 23901 RVA: 0x0003C19B File Offset: 0x0003A39B
		// (set) Token: 0x06005D5E RID: 23902 RVA: 0x0003C1A3 File Offset: 0x0003A3A3
		public int Qty
		{
			[CompilerGenerated]
			get
			{
				return this.int_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_1 == value)
				{
					return;
				}
				this.int_1 = value;
				this.vmethod_0("Qty");
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06005D5F RID: 23903 RVA: 0x0003C1C3 File Offset: 0x0003A3C3
		// (set) Token: 0x06005D60 RID: 23904 RVA: 0x0003C1CB File Offset: 0x0003A3CB
		public int Type
		{
			[CompilerGenerated]
			get
			{
				return this.int_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.int_2 == value)
				{
					return;
				}
				this.int_2 = value;
				this.vmethod_0("Type");
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06005D61 RID: 23905 RVA: 0x0003C1EB File Offset: 0x0003A3EB
		// (set) Token: 0x06005D62 RID: 23906 RVA: 0x0003C1F3 File Offset: 0x0003A3F3
		public Class2569 OpenDBViewerCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_0 == value)
				{
					return;
				}
				this.class2569_0 = value;
				this.vmethod_0("OpenDBViewerCommand");
			}
		}

		// Token: 0x06005D63 RID: 23907 RVA: 0x0003C213 File Offset: 0x0003A413
		public void method_0()
		{
			Client.smethod_63("Weapon", this.WeaponDBID, null);
		}

		// Token: 0x06005D64 RID: 23908 RVA: 0x0003C226 File Offset: 0x0003A426
		[CompilerGenerated]
		private void method_1(object a0)
		{
			this.method_0();
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06005D65 RID: 23909 RVA: 0x0032F3BC File Offset: 0x0032D5BC
		// (remove) Token: 0x06005D66 RID: 23910 RVA: 0x0032F3F4 File Offset: 0x0032D5F4
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

		// Token: 0x06005D67 RID: 23911 RVA: 0x0032F42C File Offset: 0x0032D62C
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003647 RID: 13895
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04003648 RID: 13896
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003649 RID: 13897
		[CompilerGenerated]
		private int int_1;

		// Token: 0x0400364A RID: 13898
		[CompilerGenerated]
		private int int_2;

		// Token: 0x0400364B RID: 13899
		[CompilerGenerated]
		private Class2569 class2569_0;

		// Token: 0x0400364C RID: 13900
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
