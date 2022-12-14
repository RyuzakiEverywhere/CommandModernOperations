using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace Command
{
	// Token: 0x02000DAC RID: 3500
	[Attribute3]
	[Attribute2]
	[Attribute0]
	public sealed class CargoOpsCargoItemViewModel : INotifyPropertyChanged
	{
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06005E2C RID: 24108 RVA: 0x0003CC36 File Offset: 0x0003AE36
		// (set) Token: 0x06005E2D RID: 24109 RVA: 0x0033212C File Offset: 0x0033032C
		public Cargo Cargo
		{
			[CompilerGenerated]
			get
			{
				return this.cargo_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.cargo_0 == value)
				{
					return;
				}
				this.cargo_0 = value;
				this.vmethod_0("Name");
				this.vmethod_0("CargoType");
				this.vmethod_0("MassPerUnit");
				this.vmethod_0("AreaPerUnit");
				this.vmethod_0("CrewPerUnit");
				this.vmethod_0("Abilities");
				this.vmethod_0("Cargo");
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06005E2E RID: 24110 RVA: 0x0003CC3E File Offset: 0x0003AE3E
		// (set) Token: 0x06005E2F RID: 24111 RVA: 0x0003CC46 File Offset: 0x0003AE46
		public int Quantity
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
				this.vmethod_0("Name");
				this.vmethod_0("Quantity");
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06005E30 RID: 24112 RVA: 0x0003CC71 File Offset: 0x0003AE71
		// (set) Token: 0x06005E31 RID: 24113 RVA: 0x0003CC79 File Offset: 0x0003AE79
		public int InitialQuantity
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
				this.vmethod_0("InitialQuantity");
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06005E32 RID: 24114 RVA: 0x0003CC99 File Offset: 0x0003AE99
		// (set) Token: 0x06005E33 RID: 24115 RVA: 0x0003CCA1 File Offset: 0x0003AEA1
		public bool CargoTypeLimited
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
				this.vmethod_0("CargoTypeLimitedBrush");
				this.vmethod_0("CargoTypeLimited");
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06005E34 RID: 24116 RVA: 0x0033219C File Offset: 0x0033039C
		public SolidColorBrush CargoTypeLimitedBrush
		{
			get
			{
				SolidColorBrush result;
				if (this.CargoTypeLimited)
				{
					result = new SolidColorBrush(Colors.IndianRed);
				}
				else
				{
					result = new SolidColorBrush(Colors.White);
				}
				return result;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06005E35 RID: 24117 RVA: 0x0003CCCC File Offset: 0x0003AECC
		public string Name
		{
			get
			{
				return Conversions.ToString(this.Quantity) + "x " + this.Cargo.method_26();
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06005E36 RID: 24118 RVA: 0x0003CCEE File Offset: 0x0003AEEE
		public CargoType CargoType
		{
			get
			{
				return ((Mount)this.Cargo.method_25()).cargoType_0;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06005E37 RID: 24119 RVA: 0x0003CD05 File Offset: 0x0003AF05
		public double MassPerUnit
		{
			get
			{
				return (double)((Mount)this.Cargo.method_25()).short_2;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06005E38 RID: 24120 RVA: 0x0003CD1D File Offset: 0x0003AF1D
		public double AreaPerUnit
		{
			get
			{
				return (double)((Mount)this.Cargo.method_25()).short_1;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06005E39 RID: 24121 RVA: 0x0003CD35 File Offset: 0x0003AF35
		public double CrewPerUnit
		{
			get
			{
				return (double)((Mount)this.Cargo.method_25()).short_0;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06005E3A RID: 24122 RVA: 0x003321CC File Offset: 0x003303CC
		public string Abilities
		{
			get
			{
				string result;
				if (((Mount)this.Cargo.method_25()).bool_18)
				{
					result = "Paradrop Capable";
				}
				else
				{
					result = "";
				}
				return result;
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06005E3B RID: 24123 RVA: 0x00332200 File Offset: 0x00330400
		// (remove) Token: 0x06005E3C RID: 24124 RVA: 0x00332238 File Offset: 0x00330438
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

		// Token: 0x06005E3D RID: 24125 RVA: 0x00332270 File Offset: 0x00330470
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040036AC RID: 13996
		[CompilerGenerated]
		private Cargo cargo_0;

		// Token: 0x040036AD RID: 13997
		[CompilerGenerated]
		private int int_0;

		// Token: 0x040036AE RID: 13998
		[CompilerGenerated]
		private int int_1;

		// Token: 0x040036AF RID: 13999
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040036B0 RID: 14000
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
