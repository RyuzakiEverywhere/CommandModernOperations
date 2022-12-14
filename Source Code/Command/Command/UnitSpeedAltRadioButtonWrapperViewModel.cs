using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using ns14;
using ns2;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000D93 RID: 3475
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class UnitSpeedAltRadioButtonWrapperViewModel : INotifyPropertyChanged
	{
		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06005D0E RID: 23822 RVA: 0x0003BC59 File Offset: 0x00039E59
		// (set) Token: 0x06005D0F RID: 23823 RVA: 0x0003BC61 File Offset: 0x00039E61
		public string Content
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
				this.vmethod_0("Content");
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06005D10 RID: 23824 RVA: 0x0003BC85 File Offset: 0x00039E85
		// (set) Token: 0x06005D11 RID: 23825 RVA: 0x0003BC8D File Offset: 0x00039E8D
		public Class2569 Command
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
				this.vmethod_0("Command");
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06005D12 RID: 23826 RVA: 0x0003BCAD File Offset: 0x00039EAD
		// (set) Token: 0x06005D13 RID: 23827 RVA: 0x0003BCB5 File Offset: 0x00039EB5
		public Visibility Visible
		{
			[CompilerGenerated]
			get
			{
				return this.visibility_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.visibility_0 == value)
				{
					return;
				}
				this.visibility_0 = value;
				this.vmethod_0("Visible");
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06005D14 RID: 23828 RVA: 0x0003BCD5 File Offset: 0x00039ED5
		// (set) Token: 0x06005D15 RID: 23829 RVA: 0x0003BCDD File Offset: 0x00039EDD
		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.bool_0 == value)
				{
					return;
				}
				this.bool_0 = value;
				this.vmethod_0("Enabled");
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06005D16 RID: 23830 RVA: 0x0003BCFD File Offset: 0x00039EFD
		// (set) Token: 0x06005D17 RID: 23831 RVA: 0x0003BD05 File Offset: 0x00039F05
		public bool Checked
		{
			[CompilerGenerated]
			get
			{
				return this.bool_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.bool_1 == value)
				{
					return;
				}
				this.bool_1 = value;
				this.vmethod_0("Checked");
			}
		}

		// Token: 0x06005D18 RID: 23832 RVA: 0x0003BD25 File Offset: 0x00039F25
		private void method_0()
		{
			this.class122_0.Checked = true;
			Class2413.smethod_1().DoEvents();
			this.unitSpeedAltViewModel_0.method_4(false);
		}

		// Token: 0x06005D19 RID: 23833 RVA: 0x0003BD49 File Offset: 0x00039F49
		public UnitSpeedAltRadioButtonWrapperViewModel(UnitSpeedAltViewModel UnitSpeedAltViewModel, Class122 RadioButton)
		{
			this.Command = new Class2569(new Action<object>(this.method_2));
			this.class122_0 = RadioButton;
			this.unitSpeedAltViewModel_0 = UnitSpeedAltViewModel;
			this.method_1();
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x0032EC18 File Offset: 0x0032CE18
		public void method_1()
		{
			this.Content = this.class122_0.Text;
			this.Checked = this.class122_0.Checked;
			if (this.class122_0.Parent.Enabled)
			{
				this.Visible = Visibility.Visible;
			}
			else
			{
				this.Visible = Visibility.Collapsed;
			}
			this.Enabled = this.class122_0.Enabled;
		}

		// Token: 0x06005D1B RID: 23835 RVA: 0x0003BD7C File Offset: 0x00039F7C
		[CompilerGenerated]
		private void method_2(object a0)
		{
			this.method_0();
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06005D1C RID: 23836 RVA: 0x0032EC7C File Offset: 0x0032CE7C
		// (remove) Token: 0x06005D1D RID: 23837 RVA: 0x0032ECB4 File Offset: 0x0032CEB4
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

		// Token: 0x06005D1E RID: 23838 RVA: 0x0032ECEC File Offset: 0x0032CEEC
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003629 RID: 13865
		private Class122 class122_0;

		// Token: 0x0400362A RID: 13866
		private UnitSpeedAltViewModel unitSpeedAltViewModel_0;

		// Token: 0x0400362B RID: 13867
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400362C RID: 13868
		[CompilerGenerated]
		private Class2569 class2569_0;

		// Token: 0x0400362D RID: 13869
		[CompilerGenerated]
		private Visibility visibility_0;

		// Token: 0x0400362E RID: 13870
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400362F RID: 13871
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04003630 RID: 13872
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
