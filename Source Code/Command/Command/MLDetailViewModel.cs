using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using Command_Core;
using ns13;
using ns14;
using ns7;

namespace Command
{
	// Token: 0x02000E4A RID: 3658
	[Attribute3]
	[Attribute2]
	[Attribute0]
	public sealed class MLDetailViewModel : INotifyPropertyChanged
	{
		// Token: 0x06006E43 RID: 28227 RVA: 0x00045652 File Offset: 0x00043852
		public MLDetailViewModel()
		{
			this.ExpandCommand = new Class2569(new Action<object>(this.method_2));
			this.OpenHyperlinkCommand = new Class2569(new Action<object>(this.method_3));
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06006E44 RID: 28228 RVA: 0x00045688 File Offset: 0x00043888
		// (set) Token: 0x06006E45 RID: 28229 RVA: 0x00045690 File Offset: 0x00043890
		public LoggedMessage LoggedMessage
		{
			[CompilerGenerated]
			get
			{
				return this.loggedMessage_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.loggedMessage_0 == value)
				{
					return;
				}
				this.loggedMessage_0 = value;
				this.vmethod_0("LoggedMessage");
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06006E46 RID: 28230 RVA: 0x000456B0 File Offset: 0x000438B0
		// (set) Token: 0x06006E47 RID: 28231 RVA: 0x000456B8 File Offset: 0x000438B8
		public string Text
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
				this.vmethod_0("Text");
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06006E48 RID: 28232 RVA: 0x000456DC File Offset: 0x000438DC
		// (set) Token: 0x06006E49 RID: 28233 RVA: 0x000456E4 File Offset: 0x000438E4
		public string LongText
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
				this.vmethod_0("LongText");
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06006E4A RID: 28234 RVA: 0x00045708 File Offset: 0x00043908
		// (set) Token: 0x06006E4B RID: 28235 RVA: 0x00045710 File Offset: 0x00043910
		public string Summary
		{
			[CompilerGenerated]
			get
			{
				return this.string_2;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_2, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_2 = value;
				this.vmethod_0("Summary");
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06006E4C RID: 28236 RVA: 0x00045734 File Offset: 0x00043934
		// (set) Token: 0x06006E4D RID: 28237 RVA: 0x0004573C File Offset: 0x0004393C
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

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06006E4E RID: 28238 RVA: 0x0004575F File Offset: 0x0004395F
		// (set) Token: 0x06006E4F RID: 28239 RVA: 0x00045767 File Offset: 0x00043967
		public double Lat
		{
			[CompilerGenerated]
			get
			{
				return this.double_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_0 == value)
				{
					return;
				}
				this.double_0 = value;
				this.vmethod_0("Lat");
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06006E50 RID: 28240 RVA: 0x0004578A File Offset: 0x0004398A
		// (set) Token: 0x06006E51 RID: 28241 RVA: 0x00045792 File Offset: 0x00043992
		public double Lon
		{
			[CompilerGenerated]
			get
			{
				return this.double_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_1 == value)
				{
					return;
				}
				this.double_1 = value;
				this.vmethod_0("Lon");
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06006E52 RID: 28242 RVA: 0x000457B5 File Offset: 0x000439B5
		// (set) Token: 0x06006E53 RID: 28243 RVA: 0x000457BD File Offset: 0x000439BD
		public bool Read
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
				this.vmethod_0("Read");
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06006E54 RID: 28244 RVA: 0x000457DD File Offset: 0x000439DD
		// (set) Token: 0x06006E55 RID: 28245 RVA: 0x000457E5 File Offset: 0x000439E5
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

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06006E56 RID: 28246 RVA: 0x00045805 File Offset: 0x00043A05
		// (set) Token: 0x06006E57 RID: 28247 RVA: 0x0004580D File Offset: 0x00043A0D
		public Visibility PlusVisibility
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
				this.vmethod_0("PlusVisibility");
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06006E58 RID: 28248 RVA: 0x0004582D File Offset: 0x00043A2D
		// (set) Token: 0x06006E59 RID: 28249 RVA: 0x00045835 File Offset: 0x00043A35
		public bool Expanded
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
				this.vmethod_0("Expanded");
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06006E5A RID: 28250 RVA: 0x00045855 File Offset: 0x00043A55
		// (set) Token: 0x06006E5B RID: 28251 RVA: 0x0004585D File Offset: 0x00043A5D
		public Class2569 ExpandCommand
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
				this.vmethod_0("ExpandCommand");
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06006E5C RID: 28252 RVA: 0x0004587D File Offset: 0x00043A7D
		// (set) Token: 0x06006E5D RID: 28253 RVA: 0x00045885 File Offset: 0x00043A85
		public Class2569 OpenHyperlinkCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_1 == value)
				{
					return;
				}
				this.class2569_1 = value;
				this.vmethod_0("OpenHyperlinkCommand");
			}
		}

		// Token: 0x06006E5E RID: 28254 RVA: 0x000458A5 File Offset: 0x00043AA5
		private void method_0()
		{
			Client.smethod_46().UnhandledPopUpMessages.Enqueue(this.LoggedMessage);
		}

		// Token: 0x06006E5F RID: 28255 RVA: 0x003BF04C File Offset: 0x003BD24C
		private void method_1()
		{
			if (this.Expanded)
			{
				this.PlusVisibility = Visibility.Visible;
				this.Expanded = false;
				this.Text = Class441.smethod_0(this.Summary);
				return;
			}
			this.PlusVisibility = Visibility.Collapsed;
			this.Expanded = true;
			this.Text = Class441.smethod_0(this.LongText);
		}

		// Token: 0x06006E60 RID: 28256 RVA: 0x000458BC File Offset: 0x00043ABC
		[CompilerGenerated]
		private void method_2(object a0)
		{
			this.method_1();
		}

		// Token: 0x06006E61 RID: 28257 RVA: 0x000458C4 File Offset: 0x00043AC4
		[CompilerGenerated]
		private void method_3(object a0)
		{
			this.method_0();
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x06006E62 RID: 28258 RVA: 0x003BF0A0 File Offset: 0x003BD2A0
		// (remove) Token: 0x06006E63 RID: 28259 RVA: 0x003BF0D8 File Offset: 0x003BD2D8
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

		// Token: 0x06006E64 RID: 28260 RVA: 0x003BF110 File Offset: 0x003BD310
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003EAF RID: 16047
		[CompilerGenerated]
		private LoggedMessage loggedMessage_0;

		// Token: 0x04003EB0 RID: 16048
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003EB1 RID: 16049
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04003EB2 RID: 16050
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04003EB3 RID: 16051
		[CompilerGenerated]
		private DateTime dateTime_0;

		// Token: 0x04003EB4 RID: 16052
		[CompilerGenerated]
		private double double_0;

		// Token: 0x04003EB5 RID: 16053
		[CompilerGenerated]
		private double double_1;

		// Token: 0x04003EB6 RID: 16054
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04003EB7 RID: 16055
		[CompilerGenerated]
		private Brush brush_0;

		// Token: 0x04003EB8 RID: 16056
		[CompilerGenerated]
		private Visibility visibility_0;

		// Token: 0x04003EB9 RID: 16057
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04003EBA RID: 16058
		[CompilerGenerated]
		private Class2569 class2569_0;

		// Token: 0x04003EBB RID: 16059
		[CompilerGenerated]
		private Class2569 class2569_1;

		// Token: 0x04003EBC RID: 16060
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
