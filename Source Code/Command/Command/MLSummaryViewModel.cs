using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using ns14;

namespace Command
{
	// Token: 0x02000E4B RID: 3659
	[Attribute0]
	[Attribute3]
	[Attribute2]
	public sealed class MLSummaryViewModel : INotifyPropertyChanged
	{
		// Token: 0x06006E65 RID: 28261 RVA: 0x000458CC File Offset: 0x00043ACC
		public MLSummaryViewModel()
		{
			this.Details = new ObservableCollection<MLDetailViewModel>();
			this.Expanded = false;
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06006E66 RID: 28262 RVA: 0x000458E6 File Offset: 0x00043AE6
		// (set) Token: 0x06006E67 RID: 28263 RVA: 0x000458EE File Offset: 0x00043AEE
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

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06006E68 RID: 28264 RVA: 0x00045912 File Offset: 0x00043B12
		// (set) Token: 0x06006E69 RID: 28265 RVA: 0x0004591A File Offset: 0x00043B1A
		public Brush Brush
		{
			[CompilerGenerated]
			get
			{
				return this.brush_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.brush_0 == value)
				{
					return;
				}
				this.brush_0 = value;
				this.vmethod_0("Brush");
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06006E6A RID: 28266 RVA: 0x0004593A File Offset: 0x00043B3A
		// (set) Token: 0x06006E6B RID: 28267 RVA: 0x00045942 File Offset: 0x00043B42
		public ObservableCollection<MLDetailViewModel> Details
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_0 == value)
				{
					return;
				}
				this.observableCollection_0 = value;
				this.vmethod_0("Details");
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06006E6C RID: 28268 RVA: 0x00045962 File Offset: 0x00043B62
		// (set) Token: 0x06006E6D RID: 28269 RVA: 0x0004596A File Offset: 0x00043B6A
		public DateTime Timestamp
		{
			[CompilerGenerated]
			get
			{
				return this.dateTime_0;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.dateTime_0, value))
				{
					return;
				}
				this.dateTime_0 = value;
				this.vmethod_0("Timestamp");
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06006E6E RID: 28270 RVA: 0x0004598D File Offset: 0x00043B8D
		// (set) Token: 0x06006E6F RID: 28271 RVA: 0x00045995 File Offset: 0x00043B95
		public bool Expanded
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
				this.vmethod_0("Expanded");
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06006E70 RID: 28272 RVA: 0x000459B5 File Offset: 0x00043BB5
		// (set) Token: 0x06006E71 RID: 28273 RVA: 0x000459BD File Offset: 0x00043BBD
		public string Summary
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_1, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_1 = value;
				this.vmethod_0("Summary");
			}
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x06006E72 RID: 28274 RVA: 0x003BF138 File Offset: 0x003BD338
		// (remove) Token: 0x06006E73 RID: 28275 RVA: 0x003BF170 File Offset: 0x003BD370
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

		// Token: 0x06006E74 RID: 28276 RVA: 0x003BF1A8 File Offset: 0x003BD3A8
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003EBD RID: 16061
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003EBE RID: 16062
		[CompilerGenerated]
		private Brush brush_0;

		// Token: 0x04003EBF RID: 16063
		[CompilerGenerated]
		private ObservableCollection<MLDetailViewModel> observableCollection_0;

		// Token: 0x04003EC0 RID: 16064
		[CompilerGenerated]
		private DateTime dateTime_0;

		// Token: 0x04003EC1 RID: 16065
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04003EC2 RID: 16066
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04003EC3 RID: 16067
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
