using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using ns14;

namespace Command
{
	// Token: 0x02000E4C RID: 3660
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class MLBalloonViewModel : INotifyPropertyChanged
	{
		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06006E76 RID: 28278 RVA: 0x000459E1 File Offset: 0x00043BE1
		// (set) Token: 0x06006E77 RID: 28279 RVA: 0x000459E9 File Offset: 0x00043BE9
		public double CanvasLeft
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
				this.vmethod_0("CanvasLeft");
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06006E78 RID: 28280 RVA: 0x00045A0C File Offset: 0x00043C0C
		// (set) Token: 0x06006E79 RID: 28281 RVA: 0x00045A14 File Offset: 0x00043C14
		public double CanvasTop
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
				this.vmethod_0("CanvasTop");
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06006E7A RID: 28282 RVA: 0x00045A37 File Offset: 0x00043C37
		// (set) Token: 0x06006E7B RID: 28283 RVA: 0x00045A3F File Offset: 0x00043C3F
		public double StemCanvasLeft
		{
			[CompilerGenerated]
			get
			{
				return this.double_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_2 == value)
				{
					return;
				}
				this.double_2 = value;
				this.vmethod_0("StemCanvasLeft");
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06006E7C RID: 28284 RVA: 0x00045A62 File Offset: 0x00043C62
		// (set) Token: 0x06006E7D RID: 28285 RVA: 0x00045A6A File Offset: 0x00043C6A
		public double StemCanvasTop
		{
			[CompilerGenerated]
			get
			{
				return this.double_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_3 == value)
				{
					return;
				}
				this.double_3 = value;
				this.vmethod_0("StemCanvasTop");
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06006E7E RID: 28286 RVA: 0x00045A8D File Offset: 0x00043C8D
		// (set) Token: 0x06006E7F RID: 28287 RVA: 0x00045A95 File Offset: 0x00043C95
		public double ObservedHeight
		{
			[CompilerGenerated]
			get
			{
				return this.double_4;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_4 == value)
				{
					return;
				}
				this.double_4 = value;
				this.vmethod_0("ObservedHeight");
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06006E80 RID: 28288 RVA: 0x00045AB8 File Offset: 0x00043CB8
		// (set) Token: 0x06006E81 RID: 28289 RVA: 0x00045AC0 File Offset: 0x00043CC0
		public double ObservedWidth
		{
			[CompilerGenerated]
			get
			{
				return this.double_5;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_5 == value)
				{
					return;
				}
				this.double_5 = value;
				this.vmethod_0("ObservedWidth");
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06006E82 RID: 28290 RVA: 0x00045AE3 File Offset: 0x00043CE3
		// (set) Token: 0x06006E83 RID: 28291 RVA: 0x00045AEB File Offset: 0x00043CEB
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

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06006E84 RID: 28292 RVA: 0x00045B0F File Offset: 0x00043D0F
		// (set) Token: 0x06006E85 RID: 28293 RVA: 0x00045B17 File Offset: 0x00043D17
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

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06006E86 RID: 28294 RVA: 0x00045B3B File Offset: 0x00043D3B
		// (set) Token: 0x06006E87 RID: 28295 RVA: 0x00045B43 File Offset: 0x00043D43
		public object Tag
		{
			[CompilerGenerated]
			get
			{
				return this.object_0;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.object_0, value))
				{
					return;
				}
				this.object_0 = RuntimeHelpers.GetObjectValue(value);
				this.vmethod_0("Tag");
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06006E88 RID: 28296 RVA: 0x00045B6B File Offset: 0x00043D6B
		// (set) Token: 0x06006E89 RID: 28297 RVA: 0x00045B73 File Offset: 0x00043D73
		public double Lat
		{
			[CompilerGenerated]
			get
			{
				return this.double_6;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_6 == value)
				{
					return;
				}
				this.double_6 = value;
				this.vmethod_0("Lat");
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06006E8A RID: 28298 RVA: 0x00045B96 File Offset: 0x00043D96
		// (set) Token: 0x06006E8B RID: 28299 RVA: 0x00045B9E File Offset: 0x00043D9E
		public double Lon
		{
			[CompilerGenerated]
			get
			{
				return this.double_7;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_7 == value)
				{
					return;
				}
				this.double_7 = value;
				this.vmethod_0("Lon");
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06006E8C RID: 28300 RVA: 0x00045BC1 File Offset: 0x00043DC1
		// (set) Token: 0x06006E8D RID: 28301 RVA: 0x00045BC9 File Offset: 0x00043DC9
		public double Opacity
		{
			[CompilerGenerated]
			get
			{
				return this.double_8;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_8 == value)
				{
					return;
				}
				this.double_8 = value;
				this.vmethod_0("Opacity");
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06006E8E RID: 28302 RVA: 0x00045BEC File Offset: 0x00043DEC
		// (set) Token: 0x06006E8F RID: 28303 RVA: 0x00045BF4 File Offset: 0x00043DF4
		public bool Hover
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
				this.vmethod_0("Hover");
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06006E90 RID: 28304 RVA: 0x00045C14 File Offset: 0x00043E14
		// (set) Token: 0x06006E91 RID: 28305 RVA: 0x00045C1C File Offset: 0x00043E1C
		public Color Color
		{
			[CompilerGenerated]
			get
			{
				return this.color_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.color_0 == value)
				{
					return;
				}
				this.color_0 = value;
				this.vmethod_0("Color");
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06006E92 RID: 28306 RVA: 0x00045C3F File Offset: 0x00043E3F
		// (set) Token: 0x06006E93 RID: 28307 RVA: 0x00045C47 File Offset: 0x00043E47
		public double X1
		{
			[CompilerGenerated]
			get
			{
				return this.double_9;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_9 == value)
				{
					return;
				}
				this.double_9 = value;
				this.vmethod_0("X1");
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06006E94 RID: 28308 RVA: 0x00045C6A File Offset: 0x00043E6A
		// (set) Token: 0x06006E95 RID: 28309 RVA: 0x00045C72 File Offset: 0x00043E72
		public double X2
		{
			[CompilerGenerated]
			get
			{
				return this.double_10;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_10 == value)
				{
					return;
				}
				this.double_10 = value;
				this.vmethod_0("X2");
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06006E96 RID: 28310 RVA: 0x00045C95 File Offset: 0x00043E95
		// (set) Token: 0x06006E97 RID: 28311 RVA: 0x00045C9D File Offset: 0x00043E9D
		public double Y1
		{
			[CompilerGenerated]
			get
			{
				return this.double_11;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_11 == value)
				{
					return;
				}
				this.double_11 = value;
				this.vmethod_0("Y1");
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06006E98 RID: 28312 RVA: 0x00045CC0 File Offset: 0x00043EC0
		// (set) Token: 0x06006E99 RID: 28313 RVA: 0x00045CC8 File Offset: 0x00043EC8
		public double Y2
		{
			[CompilerGenerated]
			get
			{
				return this.double_12;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_12 == value)
				{
					return;
				}
				this.double_12 = value;
				this.vmethod_0("Y2");
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06006E9A RID: 28314 RVA: 0x00045CEB File Offset: 0x00043EEB
		// (set) Token: 0x06006E9B RID: 28315 RVA: 0x00045CF3 File Offset: 0x00043EF3
		public double Radius
		{
			[CompilerGenerated]
			get
			{
				return this.double_13;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_13 == value)
				{
					return;
				}
				this.double_13 = value;
				this.vmethod_0("Radius");
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06006E9C RID: 28316 RVA: 0x00045D16 File Offset: 0x00043F16
		// (set) Token: 0x06006E9D RID: 28317 RVA: 0x00045D1E File Offset: 0x00043F1E
		public double Theta
		{
			[CompilerGenerated]
			get
			{
				return this.double_14;
			}
			[CompilerGenerated]
			set
			{
				if (this.double_14 == value)
				{
					return;
				}
				this.double_14 = value;
				this.vmethod_0("Theta");
			}
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06006E9E RID: 28318 RVA: 0x003BF1D0 File Offset: 0x003BD3D0
		// (remove) Token: 0x06006E9F RID: 28319 RVA: 0x003BF208 File Offset: 0x003BD408
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

		// Token: 0x06006EA0 RID: 28320 RVA: 0x003BF240 File Offset: 0x003BD440
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003EC4 RID: 16068
		[CompilerGenerated]
		private double double_0;

		// Token: 0x04003EC5 RID: 16069
		[CompilerGenerated]
		private double double_1;

		// Token: 0x04003EC6 RID: 16070
		[CompilerGenerated]
		private double double_2;

		// Token: 0x04003EC7 RID: 16071
		[CompilerGenerated]
		private double double_3;

		// Token: 0x04003EC8 RID: 16072
		[CompilerGenerated]
		private double double_4;

		// Token: 0x04003EC9 RID: 16073
		[CompilerGenerated]
		private double double_5;

		// Token: 0x04003ECA RID: 16074
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003ECB RID: 16075
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04003ECC RID: 16076
		[CompilerGenerated]
		private object object_0;

		// Token: 0x04003ECD RID: 16077
		[CompilerGenerated]
		private double double_6;

		// Token: 0x04003ECE RID: 16078
		[CompilerGenerated]
		private double double_7;

		// Token: 0x04003ECF RID: 16079
		[CompilerGenerated]
		private double double_8;

		// Token: 0x04003ED0 RID: 16080
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04003ED1 RID: 16081
		[CompilerGenerated]
		private Color color_0;

		// Token: 0x04003ED2 RID: 16082
		[CompilerGenerated]
		private double double_9;

		// Token: 0x04003ED3 RID: 16083
		[CompilerGenerated]
		private double double_10;

		// Token: 0x04003ED4 RID: 16084
		[CompilerGenerated]
		private double double_11;

		// Token: 0x04003ED5 RID: 16085
		[CompilerGenerated]
		private double double_12;

		// Token: 0x04003ED6 RID: 16086
		[CompilerGenerated]
		private double double_13;

		// Token: 0x04003ED7 RID: 16087
		[CompilerGenerated]
		private double double_14;

		// Token: 0x04003ED8 RID: 16088
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
