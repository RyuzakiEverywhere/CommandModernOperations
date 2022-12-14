using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using ns14;

namespace Command
{
	// Token: 0x02000D81 RID: 3457
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public class PlatFormViewModel : INotifyPropertyChanged
	{
		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06005C2A RID: 23594 RVA: 0x0003B183 File Offset: 0x00039383
		// (set) Token: 0x06005C2B RID: 23595 RVA: 0x0003B18B File Offset: 0x0003938B
		[Attribute2]
		public string UnitName
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
				this.vmethod_0("UnitName");
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06005C2C RID: 23596 RVA: 0x0032BE4C File Offset: 0x0032A04C
		// (remove) Token: 0x06005C2D RID: 23597 RVA: 0x0032BE84 File Offset: 0x0032A084
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

		// Token: 0x06005C2E RID: 23598 RVA: 0x0032BEBC File Offset: 0x0032A0BC
		public virtual void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040035C4 RID: 13764
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040035C5 RID: 13765
		public ActiveUnit activeUnit_0;

		// Token: 0x040035C6 RID: 13766
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
