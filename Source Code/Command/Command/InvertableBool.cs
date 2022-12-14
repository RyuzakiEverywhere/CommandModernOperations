using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ns7;

namespace Command
{
	// Token: 0x02000F51 RID: 3921
	[Attribute12]
	[Attribute11]
	[Attribute13]
	public sealed class InvertableBool : INotifyPropertyChanged
	{
		// Token: 0x14000049 RID: 73
		// (add) Token: 0x06008C31 RID: 35889 RVA: 0x004B78AC File Offset: 0x004B5AAC
		// (remove) Token: 0x06008C32 RID: 35890 RVA: 0x004B78E4 File Offset: 0x004B5AE4
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
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
			[CompilerGenerated]
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

		// Token: 0x06008C33 RID: 35891 RVA: 0x004B791C File Offset: 0x004B5B1C
		private void method_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06008C34 RID: 35892 RVA: 0x00053A79 File Offset: 0x00051C79
		// (set) Token: 0x06008C35 RID: 35893 RVA: 0x00053A81 File Offset: 0x00051C81
		public bool Value
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				if (this.bool_0 == value)
				{
					return;
				}
				this.bool_0 = value;
				this.method_0("Value");
				this.method_0("Invert");
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06008C36 RID: 35894 RVA: 0x00053AAC File Offset: 0x00051CAC
		// (set) Token: 0x06008C37 RID: 35895 RVA: 0x00053AB7 File Offset: 0x00051CB7
		public bool Invert
		{
			get
			{
				return !this.bool_0;
			}
			set
			{
				this.bool_0 = !value;
				this.method_0("Value");
				this.method_0("Invert");
			}
		}

		// Token: 0x06008C38 RID: 35896 RVA: 0x00053AD9 File Offset: 0x00051CD9
		public InvertableBool(bool b)
		{
			this.bool_0 = false;
			this.bool_0 = b;
		}

		// Token: 0x06008C39 RID: 35897 RVA: 0x00053AEF File Offset: 0x00051CEF
		public static InvertableBool smethod_0(bool b)
		{
			return new InvertableBool(b);
		}

		// Token: 0x06008C3A RID: 35898 RVA: 0x00053AF7 File Offset: 0x00051CF7
		public static bool smethod_1(InvertableBool b)
		{
			return b.Value;
		}

		// Token: 0x04004BF2 RID: 19442
		[CompilerGenerated]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x04004BF3 RID: 19443
		private bool bool_0;
	}
}
