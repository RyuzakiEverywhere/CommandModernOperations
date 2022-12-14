using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core.DAL;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace Command
{
	// Token: 0x02000DA1 RID: 3489
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class CargoMissionMothershipCargoMountViewModel : INotifyPropertyChanged
	{
		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06005DC7 RID: 24007 RVA: 0x003310C0 File Offset: 0x0032F2C0
		public string Status
		{
			get
			{
				return string.Concat(new string[]
				{
					this.Name,
					" ",
					Conversions.ToString(this.ToUnload),
					" / ",
					Conversions.ToString(this.Available)
				});
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06005DC8 RID: 24008 RVA: 0x0003C5FB File Offset: 0x0003A7FB
		// (set) Token: 0x06005DC9 RID: 24009 RVA: 0x0003C603 File Offset: 0x0003A803
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
				this.vmethod_0("Status");
				this.vmethod_0("Name");
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06005DCA RID: 24010 RVA: 0x0003C632 File Offset: 0x0003A832
		// (set) Token: 0x06005DCB RID: 24011 RVA: 0x0003C63A File Offset: 0x0003A83A
		public int Available
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
				this.vmethod_0("Status");
				this.vmethod_0("Available");
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06005DCC RID: 24012 RVA: 0x0003C665 File Offset: 0x0003A865
		// (set) Token: 0x06005DCD RID: 24013 RVA: 0x0003C66D File Offset: 0x0003A86D
		public int ToUnload
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
				this.vmethod_0("Status");
				this.vmethod_0("ToUnload");
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06005DCE RID: 24014 RVA: 0x0003C698 File Offset: 0x0003A898
		// (set) Token: 0x06005DCF RID: 24015 RVA: 0x0003C6A0 File Offset: 0x0003A8A0
		public int DBID
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
				this.vmethod_0("DBID");
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06005DD0 RID: 24016 RVA: 0x0003C6C0 File Offset: 0x0003A8C0
		// (set) Token: 0x06005DD1 RID: 24017 RVA: 0x0003C6C8 File Offset: 0x0003A8C8
		public bool canMove
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
				this.vmethod_0("canMove");
			}
		}

		// Token: 0x06005DD2 RID: 24018 RVA: 0x00331110 File Offset: 0x0032F310
		public CargoMissionMothershipCargoMountViewModel(int theMountDBID)
		{
			SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
			this.Name = DBFunctions.smethod_109(theMountDBID, ref sqliteConnection);
			this.DBID = theMountDBID;
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06005DD3 RID: 24019 RVA: 0x00331144 File Offset: 0x0032F344
		// (remove) Token: 0x06005DD4 RID: 24020 RVA: 0x0033117C File Offset: 0x0032F37C
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

		// Token: 0x06005DD5 RID: 24021 RVA: 0x003311B4 File Offset: 0x0032F3B4
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400367E RID: 13950
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400367F RID: 13951
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04003680 RID: 13952
		[CompilerGenerated]
		private int int_1;

		// Token: 0x04003681 RID: 13953
		[CompilerGenerated]
		private int int_2;

		// Token: 0x04003682 RID: 13954
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04003683 RID: 13955
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
