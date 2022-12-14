using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000D8C RID: 3468
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class RecentDetectionViewModel : INotifyPropertyChanged
	{
		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06005C7E RID: 23678 RVA: 0x0003B644 File Offset: 0x00039844
		// (set) Token: 0x06005C7F RID: 23679 RVA: 0x0003B64C File Offset: 0x0003984C
		public string SensorName
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
				this.vmethod_0("SensorName");
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06005C80 RID: 23680 RVA: 0x0003B670 File Offset: 0x00039870
		// (set) Token: 0x06005C81 RID: 23681 RVA: 0x0003B678 File Offset: 0x00039878
		public int SensorDBID
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
				this.vmethod_0("SensorDBID");
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06005C82 RID: 23682 RVA: 0x0003B698 File Offset: 0x00039898
		// (set) Token: 0x06005C83 RID: 23683 RVA: 0x0003B6A0 File Offset: 0x000398A0
		public string PlatformGUID
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
				this.vmethod_0("PlatformGUID");
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06005C84 RID: 23684 RVA: 0x0003B6C4 File Offset: 0x000398C4
		// (set) Token: 0x06005C85 RID: 23685 RVA: 0x0003B6CC File Offset: 0x000398CC
		public string PlatformName
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
				this.vmethod_0("PlatformName");
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06005C86 RID: 23686 RVA: 0x0003B6F0 File Offset: 0x000398F0
		// (set) Token: 0x06005C87 RID: 23687 RVA: 0x0003B6F8 File Offset: 0x000398F8
		public int PlatformDBID
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
				this.vmethod_0("PlatformDBID");
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06005C88 RID: 23688 RVA: 0x0003B718 File Offset: 0x00039918
		// (set) Token: 0x06005C89 RID: 23689 RVA: 0x0003B720 File Offset: 0x00039920
		public string TimeSinceDetection_String
		{
			[CompilerGenerated]
			get
			{
				return this.string_3;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_3, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_3 = value;
				this.vmethod_0("TimeSinceDetection_String");
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06005C8A RID: 23690 RVA: 0x0003B744 File Offset: 0x00039944
		// (set) Token: 0x06005C8B RID: 23691 RVA: 0x0003B74C File Offset: 0x0003994C
		public string DetectionRange_String
		{
			[CompilerGenerated]
			get
			{
				return this.string_4;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_4, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_4 = value;
				this.vmethod_0("DetectionRange_String");
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06005C8C RID: 23692 RVA: 0x0003B770 File Offset: 0x00039970
		// (set) Token: 0x06005C8D RID: 23693 RVA: 0x0003B778 File Offset: 0x00039978
		public Class2569 SensorClickCommand
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
				this.vmethod_0("SensorClickCommand");
			}
		}

		// Token: 0x06005C8E RID: 23694 RVA: 0x0032D694 File Offset: 0x0032B894
		public void method_0()
		{
			if (!string.IsNullOrEmpty(this.PlatformGUID))
			{
				ActiveUnit activeUnit = null;
				try
				{
					foreach (ActiveUnit activeUnit2 in Client.smethod_46().method_42())
					{
						if (!Information.IsNothing(activeUnit2) && Operators.CompareString(activeUnit2.string_0, this.PlatformGUID, false) == 0)
						{
							activeUnit = activeUnit2;
							break;
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (activeUnit != null)
				{
					Client.smethod_64(activeUnit, "Sensor" + Conversions.ToString(this.SensorDBID));
				}
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06005C8F RID: 23695 RVA: 0x0003B798 File Offset: 0x00039998
		// (set) Token: 0x06005C90 RID: 23696 RVA: 0x0003B7A0 File Offset: 0x000399A0
		public Class2569 PlatformClickCommand
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
				this.vmethod_0("PlatformClickCommand");
			}
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x0032D734 File Offset: 0x0032B934
		public void method_1()
		{
			if (!string.IsNullOrEmpty(this.PlatformGUID))
			{
				ActiveUnit activeUnit = null;
				try
				{
					foreach (ActiveUnit activeUnit2 in Client.smethod_46().method_42())
					{
						if (!Information.IsNothing(activeUnit2) && Operators.CompareString(activeUnit2.string_0, this.PlatformGUID, false) == 0)
						{
							activeUnit = activeUnit2;
							break;
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (activeUnit != null)
				{
					Class2413.smethod_2().method_41().method_161(true, new GeoPoint(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
					Client.smethod_56(activeUnit, true);
				}
			}
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x0003B7C0 File Offset: 0x000399C0
		public RecentDetectionViewModel()
		{
			this.SensorClickCommand = new Class2569(new Action<object>(this.method_2));
			this.PlatformClickCommand = new Class2569(new Action<object>(this.method_3));
		}

		// Token: 0x06005C93 RID: 23699 RVA: 0x0003B7F6 File Offset: 0x000399F6
		[CompilerGenerated]
		private void method_2(object a0)
		{
			this.method_0();
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x0003B7FE File Offset: 0x000399FE
		[CompilerGenerated]
		private void method_3(object a0)
		{
			this.method_1();
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06005C95 RID: 23701 RVA: 0x0032D7F4 File Offset: 0x0032B9F4
		// (remove) Token: 0x06005C96 RID: 23702 RVA: 0x0032D82C File Offset: 0x0032BA2C
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

		// Token: 0x06005C97 RID: 23703 RVA: 0x0032D864 File Offset: 0x0032BA64
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040035EA RID: 13802
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040035EB RID: 13803
		[CompilerGenerated]
		private int int_0;

		// Token: 0x040035EC RID: 13804
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040035ED RID: 13805
		[CompilerGenerated]
		private string string_2;

		// Token: 0x040035EE RID: 13806
		[CompilerGenerated]
		private int int_1;

		// Token: 0x040035EF RID: 13807
		[CompilerGenerated]
		private string string_3;

		// Token: 0x040035F0 RID: 13808
		[CompilerGenerated]
		private string string_4;

		// Token: 0x040035F1 RID: 13809
		[CompilerGenerated]
		private Class2569 class2569_0;

		// Token: 0x040035F2 RID: 13810
		[CompilerGenerated]
		private Class2569 class2569_1;

		// Token: 0x040035F3 RID: 13811
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
