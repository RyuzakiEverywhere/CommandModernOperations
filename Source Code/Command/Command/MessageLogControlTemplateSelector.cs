using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using ns14;

namespace Command
{
	// Token: 0x02000E49 RID: 3657
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class MessageLogControlTemplateSelector : DataTemplateSelector, INotifyPropertyChanged
	{
		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06006E3B RID: 28219 RVA: 0x00045602 File Offset: 0x00043802
		// (set) Token: 0x06006E3C RID: 28220 RVA: 0x0004560A File Offset: 0x0004380A
		public DataTemplate DefaultMessageLogTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.dataTemplate_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTemplate_0 == value)
				{
					return;
				}
				this.dataTemplate_0 = value;
				this.vmethod_0("DefaultMessageLogTemplate");
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06006E3D RID: 28221 RVA: 0x0004562A File Offset: 0x0004382A
		// (set) Token: 0x06006E3E RID: 28222 RVA: 0x00045632 File Offset: 0x00043832
		public DataTemplate HTMLMessageLogTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.dataTemplate_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTemplate_1 == value)
				{
					return;
				}
				this.dataTemplate_1 = value;
				this.vmethod_0("HTMLMessageLogTemplate");
			}
		}

		// Token: 0x06006E3F RID: 28223 RVA: 0x003BEF7C File Offset: 0x003BD17C
		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			DataTemplate result;
			if (((MLDetailViewModel)item).LongText.StartsWith("<BODY"))
			{
				result = this.HTMLMessageLogTemplate;
			}
			else
			{
				result = this.DefaultMessageLogTemplate;
			}
			return result;
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06006E40 RID: 28224 RVA: 0x003BEFB4 File Offset: 0x003BD1B4
		// (remove) Token: 0x06006E41 RID: 28225 RVA: 0x003BEFEC File Offset: 0x003BD1EC
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

		// Token: 0x06006E42 RID: 28226 RVA: 0x003BF024 File Offset: 0x003BD224
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003EAC RID: 16044
		[CompilerGenerated]
		private DataTemplate dataTemplate_0;

		// Token: 0x04003EAD RID: 16045
		[CompilerGenerated]
		private DataTemplate dataTemplate_1;

		// Token: 0x04003EAE RID: 16046
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
