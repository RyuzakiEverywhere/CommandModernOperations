using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ns14;

namespace Command
{
	// Token: 0x02000DD1 RID: 3537
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class DatabaseControlTypeViewModel : INotifyPropertyChanged
	{
		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06006642 RID: 26178 RVA: 0x00040990 File Offset: 0x0003EB90
		// (set) Token: 0x06006643 RID: 26179 RVA: 0x00040998 File Offset: 0x0003EB98
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

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06006644 RID: 26180 RVA: 0x0038556C File Offset: 0x0038376C
		// (remove) Token: 0x06006645 RID: 26181 RVA: 0x003855A4 File Offset: 0x003837A4
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

		// Token: 0x06006646 RID: 26182 RVA: 0x003855DC File Offset: 0x003837DC
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003A58 RID: 14936
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003A59 RID: 14937
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
