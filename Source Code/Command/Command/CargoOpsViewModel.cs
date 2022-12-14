using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns14;
using ns5;
using ns7;
using ns9;

namespace Command
{
	// Token: 0x02000DAD RID: 3501
	[Attribute3]
	[Attribute2]
	[Attribute0]
	public sealed class CargoOpsViewModel : INotifyPropertyChanged
	{
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06005E3E RID: 24126 RVA: 0x0003CD4D File Offset: 0x0003AF4D
		// (set) Token: 0x06005E3F RID: 24127 RVA: 0x0003CD55 File Offset: 0x0003AF55
		public CargoOps Form
		{
			[CompilerGenerated]
			get
			{
				return this.cargoOps_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.cargoOps_0 == value)
				{
					return;
				}
				this.cargoOps_0 = value;
				this.vmethod_0("Form");
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06005E40 RID: 24128 RVA: 0x0003CD75 File Offset: 0x0003AF75
		// (set) Token: 0x06005E41 RID: 24129 RVA: 0x0003CD7D File Offset: 0x0003AF7D
		public ActiveUnit Host
		{
			[CompilerGenerated]
			get
			{
				return this.activeUnit_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.activeUnit_0 == value)
				{
					return;
				}
				this.activeUnit_0 = value;
				this.vmethod_0("Host");
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06005E42 RID: 24130 RVA: 0x0003CD9D File Offset: 0x0003AF9D
		// (set) Token: 0x06005E43 RID: 24131 RVA: 0x0003CDA5 File Offset: 0x0003AFA5
		public ActiveUnit Target
		{
			[CompilerGenerated]
			get
			{
				return this.activeUnit_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.activeUnit_1 == value)
				{
					return;
				}
				this.activeUnit_1 = value;
				this.vmethod_0("Target");
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06005E44 RID: 24132 RVA: 0x0003CDC5 File Offset: 0x0003AFC5
		// (set) Token: 0x06005E45 RID: 24133 RVA: 0x0003CDCD File Offset: 0x0003AFCD
		public ObservableCollection<CargoOpsCargoItemViewModel> HostInventory
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
				this.vmethod_0("HostInventory");
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06005E46 RID: 24134 RVA: 0x0003CDED File Offset: 0x0003AFED
		// (set) Token: 0x06005E47 RID: 24135 RVA: 0x0003CDF5 File Offset: 0x0003AFF5
		public CargoOpsCargoItemViewModel HostSelectedItem
		{
			[CompilerGenerated]
			get
			{
				return this.cargoOpsCargoItemViewModel_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.cargoOpsCargoItemViewModel_0 == value)
				{
					return;
				}
				this.cargoOpsCargoItemViewModel_0 = value;
				this.vmethod_0("HostSelectedItem");
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06005E48 RID: 24136 RVA: 0x0003CE15 File Offset: 0x0003B015
		// (set) Token: 0x06005E49 RID: 24137 RVA: 0x0003CE1D File Offset: 0x0003B01D
		public double HostRequiredMass
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
				this.vmethod_0("HostRequiredMass");
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06005E4A RID: 24138 RVA: 0x0003CE40 File Offset: 0x0003B040
		// (set) Token: 0x06005E4B RID: 24139 RVA: 0x0003CE48 File Offset: 0x0003B048
		public double HostRequiredArea
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
				this.vmethod_0("HostRequiredArea");
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06005E4C RID: 24140 RVA: 0x0003CE6B File Offset: 0x0003B06B
		// (set) Token: 0x06005E4D RID: 24141 RVA: 0x0003CE73 File Offset: 0x0003B073
		public double HostRequiredCrew
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
				this.vmethod_0("HostRequiredCrew");
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06005E4E RID: 24142 RVA: 0x0003CE96 File Offset: 0x0003B096
		// (set) Token: 0x06005E4F RID: 24143 RVA: 0x0003CE9E File Offset: 0x0003B09E
		public double HostTotalMass
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
				this.vmethod_0("HostTotalMass");
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06005E50 RID: 24144 RVA: 0x0003CEC1 File Offset: 0x0003B0C1
		// (set) Token: 0x06005E51 RID: 24145 RVA: 0x0003CEC9 File Offset: 0x0003B0C9
		public double HostTotalArea
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
				this.vmethod_0("HostTotalArea");
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06005E52 RID: 24146 RVA: 0x0003CEEC File Offset: 0x0003B0EC
		// (set) Token: 0x06005E53 RID: 24147 RVA: 0x0003CEF4 File Offset: 0x0003B0F4
		public double HostTotalCrew
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
				this.vmethod_0("HostTotalCrew");
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06005E54 RID: 24148 RVA: 0x0003CF17 File Offset: 0x0003B117
		// (set) Token: 0x06005E55 RID: 24149 RVA: 0x0003CF1F File Offset: 0x0003B11F
		public CargoType HostType
		{
			[CompilerGenerated]
			get
			{
				return this.cargoType_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.cargoType_0 == value)
				{
					return;
				}
				this.cargoType_0 = value;
				this.vmethod_0("HostType");
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06005E56 RID: 24150 RVA: 0x0003CF3F File Offset: 0x0003B13F
		// (set) Token: 0x06005E57 RID: 24151 RVA: 0x0003CF47 File Offset: 0x0003B147
		public string HostName
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
				this.vmethod_0("HostName");
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06005E58 RID: 24152 RVA: 0x0003CF6B File Offset: 0x0003B16B
		// (set) Token: 0x06005E59 RID: 24153 RVA: 0x0003CF73 File Offset: 0x0003B173
		public bool HostIsGroup
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
				this.vmethod_0("HostIsGroup");
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06005E5A RID: 24154 RVA: 0x0003CF93 File Offset: 0x0003B193
		// (set) Token: 0x06005E5B RID: 24155 RVA: 0x0003CF9B File Offset: 0x0003B19B
		public ObservableCollection<CargoOpsCargoItemViewModel> TargetInventory
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_1 == value)
				{
					return;
				}
				this.observableCollection_1 = value;
				this.vmethod_0("TargetInventory");
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06005E5C RID: 24156 RVA: 0x0003CFBB File Offset: 0x0003B1BB
		// (set) Token: 0x06005E5D RID: 24157 RVA: 0x0003CFC3 File Offset: 0x0003B1C3
		public CargoOpsCargoItemViewModel TargetSelectedItem
		{
			[CompilerGenerated]
			get
			{
				return this.cargoOpsCargoItemViewModel_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.cargoOpsCargoItemViewModel_1 == value)
				{
					return;
				}
				this.cargoOpsCargoItemViewModel_1 = value;
				this.vmethod_0("LoadVisibility");
				this.vmethod_0("UnloadVisibility");
				this.vmethod_0("TargetSelectedItem");
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06005E5E RID: 24158 RVA: 0x0003CFF9 File Offset: 0x0003B1F9
		// (set) Token: 0x06005E5F RID: 24159 RVA: 0x0003D001 File Offset: 0x0003B201
		public double TargetRequiredMass
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
				this.vmethod_0("TargetRequiredMass");
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06005E60 RID: 24160 RVA: 0x0003D024 File Offset: 0x0003B224
		// (set) Token: 0x06005E61 RID: 24161 RVA: 0x0003D02C File Offset: 0x0003B22C
		public double TargetRequiredArea
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
				this.vmethod_0("TargetRequiredArea");
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06005E62 RID: 24162 RVA: 0x0003D04F File Offset: 0x0003B24F
		// (set) Token: 0x06005E63 RID: 24163 RVA: 0x0003D057 File Offset: 0x0003B257
		public double TargetRequiredCrew
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
				this.vmethod_0("TargetRequiredCrew");
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06005E64 RID: 24164 RVA: 0x0003D07A File Offset: 0x0003B27A
		// (set) Token: 0x06005E65 RID: 24165 RVA: 0x0003D082 File Offset: 0x0003B282
		public double TargetTotalMass
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
				this.vmethod_0("TargetTotalMass");
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06005E66 RID: 24166 RVA: 0x0003D0A5 File Offset: 0x0003B2A5
		// (set) Token: 0x06005E67 RID: 24167 RVA: 0x0003D0AD File Offset: 0x0003B2AD
		public double TargetTotalArea
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
				this.vmethod_0("TargetTotalArea");
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06005E68 RID: 24168 RVA: 0x0003D0D0 File Offset: 0x0003B2D0
		// (set) Token: 0x06005E69 RID: 24169 RVA: 0x0003D0D8 File Offset: 0x0003B2D8
		public double TargetTotalCrew
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
				this.vmethod_0("TargetTotalCrew");
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06005E6A RID: 24170 RVA: 0x0003D0FB File Offset: 0x0003B2FB
		// (set) Token: 0x06005E6B RID: 24171 RVA: 0x0003D103 File Offset: 0x0003B303
		public CargoType TargetType
		{
			[CompilerGenerated]
			get
			{
				return this.cargoType_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.cargoType_1 == value)
				{
					return;
				}
				this.cargoType_1 = value;
				this.vmethod_0("TargetType");
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06005E6C RID: 24172 RVA: 0x0003D123 File Offset: 0x0003B323
		// (set) Token: 0x06005E6D RID: 24173 RVA: 0x0003D12B File Offset: 0x0003B32B
		public string TargetName
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
				this.vmethod_0("TargetName");
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06005E6E RID: 24174 RVA: 0x0003D14F File Offset: 0x0003B34F
		// (set) Token: 0x06005E6F RID: 24175 RVA: 0x00332298 File Offset: 0x00330498
		public bool Exchange
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
				this.vmethod_0("ExchangeVisibility");
				this.vmethod_0("ExchangeVisibilityInverse");
				this.vmethod_0("LoadVisibility");
				this.vmethod_0("UnloadVisibility");
				this.vmethod_0("Exchange");
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06005E70 RID: 24176 RVA: 0x003322F0 File Offset: 0x003304F0
		public Visibility ExchangeVisibility
		{
			get
			{
				Visibility result;
				if (this.Exchange)
				{
					result = Visibility.Visible;
				}
				else
				{
					result = Visibility.Collapsed;
				}
				return result;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06005E71 RID: 24177 RVA: 0x0033230C File Offset: 0x0033050C
		public Visibility ExchangeVisibilityInverse
		{
			get
			{
				Visibility result;
				if (!this.Exchange)
				{
					result = Visibility.Visible;
				}
				else
				{
					result = Visibility.Collapsed;
				}
				return result;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06005E72 RID: 24178 RVA: 0x00332328 File Offset: 0x00330528
		public Visibility LoadVisibility
		{
			get
			{
				Visibility result;
				if (this.TargetSelectedItem != null && this.TargetSelectedItem.CargoTypeLimited)
				{
					result = Visibility.Collapsed;
				}
				else if (this.Exchange)
				{
					result = Visibility.Visible;
				}
				else
				{
					result = Visibility.Collapsed;
				}
				return result;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06005E73 RID: 24179 RVA: 0x00332328 File Offset: 0x00330528
		public Visibility UnloadVisibility
		{
			get
			{
				Visibility result;
				if (this.TargetSelectedItem != null && this.TargetSelectedItem.CargoTypeLimited)
				{
					result = Visibility.Collapsed;
				}
				else if (this.Exchange)
				{
					result = Visibility.Visible;
				}
				else
				{
					result = Visibility.Collapsed;
				}
				return result;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06005E74 RID: 24180 RVA: 0x0003D157 File Offset: 0x0003B357
		// (set) Token: 0x06005E75 RID: 24181 RVA: 0x0003D15F File Offset: 0x0003B35F
		public DataTable AllMounts
		{
			[CompilerGenerated]
			get
			{
				return this.dataTable_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTable_0 == value)
				{
					return;
				}
				this.dataTable_0 = value;
				this.vmethod_0("AllMounts");
			}
		}

		// Token: 0x06005E76 RID: 24182 RVA: 0x00332360 File Offset: 0x00330560
		private void method_0()
		{
			this.HostRequiredMass = (double)Enumerable.Sum<int>(Enumerable.Select<CargoOpsCargoItemViewModel, int>(Enumerable.Where<CargoOpsCargoItemViewModel>(this.HostInventory, (CargoOpsViewModel._Closure$__.$I114-0 == null) ? (CargoOpsViewModel._Closure$__.$I114-0 = new Func<CargoOpsCargoItemViewModel, bool>(CargoOpsViewModel._Closure$__.$I.method_0)) : CargoOpsViewModel._Closure$__.$I114-0), (CargoOpsViewModel._Closure$__.$I114-1 == null) ? (CargoOpsViewModel._Closure$__.$I114-1 = new Func<CargoOpsCargoItemViewModel, int>(CargoOpsViewModel._Closure$__.$I.method_1)) : CargoOpsViewModel._Closure$__.$I114-1), (CargoOpsViewModel._Closure$__.$I114-2 == null) ? (CargoOpsViewModel._Closure$__.$I114-2 = new Func<int, int>(CargoOpsViewModel._Closure$__.$I.method_2)) : CargoOpsViewModel._Closure$__.$I114-2);
			this.HostRequiredArea = (double)Enumerable.Sum<int>(Enumerable.Select<CargoOpsCargoItemViewModel, int>(Enumerable.Where<CargoOpsCargoItemViewModel>(this.HostInventory, (CargoOpsViewModel._Closure$__.$I114-3 == null) ? (CargoOpsViewModel._Closure$__.$I114-3 = new Func<CargoOpsCargoItemViewModel, bool>(CargoOpsViewModel._Closure$__.$I.method_3)) : CargoOpsViewModel._Closure$__.$I114-3), (CargoOpsViewModel._Closure$__.$I114-4 == null) ? (CargoOpsViewModel._Closure$__.$I114-4 = new Func<CargoOpsCargoItemViewModel, int>(CargoOpsViewModel._Closure$__.$I.method_4)) : CargoOpsViewModel._Closure$__.$I114-4), (CargoOpsViewModel._Closure$__.$I114-5 == null) ? (CargoOpsViewModel._Closure$__.$I114-5 = new Func<int, int>(CargoOpsViewModel._Closure$__.$I.method_5)) : CargoOpsViewModel._Closure$__.$I114-5);
			this.HostRequiredCrew = (double)Enumerable.Sum<int>(Enumerable.Select<CargoOpsCargoItemViewModel, int>(Enumerable.Where<CargoOpsCargoItemViewModel>(this.HostInventory, (CargoOpsViewModel._Closure$__.$I114-6 == null) ? (CargoOpsViewModel._Closure$__.$I114-6 = new Func<CargoOpsCargoItemViewModel, bool>(CargoOpsViewModel._Closure$__.$I.method_6)) : CargoOpsViewModel._Closure$__.$I114-6), (CargoOpsViewModel._Closure$__.$I114-7 == null) ? (CargoOpsViewModel._Closure$__.$I114-7 = new Func<CargoOpsCargoItemViewModel, int>(CargoOpsViewModel._Closure$__.$I.method_7)) : CargoOpsViewModel._Closure$__.$I114-7), (CargoOpsViewModel._Closure$__.$I114-8 == null) ? (CargoOpsViewModel._Closure$__.$I114-8 = new Func<int, int>(CargoOpsViewModel._Closure$__.$I.method_8)) : CargoOpsViewModel._Closure$__.$I114-8);
			try
			{
				foreach (CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel in this.HostInventory)
				{
					if (this.Target != null & (cargoOpsCargoItemViewModel.CargoType > this.HostType | cargoOpsCargoItemViewModel.CargoType > this.TargetType))
					{
						cargoOpsCargoItemViewModel.CargoTypeLimited = true;
					}
				}
			}
			finally
			{
				IEnumerator<CargoOpsCargoItemViewModel> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			if (this.Target != null)
			{
				this.TargetRequiredMass = (double)Enumerable.Sum<int>(Enumerable.Select<CargoOpsCargoItemViewModel, int>(Enumerable.Where<CargoOpsCargoItemViewModel>(this.TargetInventory, (CargoOpsViewModel._Closure$__.$I114-9 == null) ? (CargoOpsViewModel._Closure$__.$I114-9 = new Func<CargoOpsCargoItemViewModel, bool>(CargoOpsViewModel._Closure$__.$I.method_9)) : CargoOpsViewModel._Closure$__.$I114-9), (CargoOpsViewModel._Closure$__.$I114-10 == null) ? (CargoOpsViewModel._Closure$__.$I114-10 = new Func<CargoOpsCargoItemViewModel, int>(CargoOpsViewModel._Closure$__.$I.method_10)) : CargoOpsViewModel._Closure$__.$I114-10), (CargoOpsViewModel._Closure$__.$I114-11 == null) ? (CargoOpsViewModel._Closure$__.$I114-11 = new Func<int, int>(CargoOpsViewModel._Closure$__.$I.method_11)) : CargoOpsViewModel._Closure$__.$I114-11);
				this.TargetRequiredArea = (double)Enumerable.Sum<int>(Enumerable.Select<CargoOpsCargoItemViewModel, int>(Enumerable.Where<CargoOpsCargoItemViewModel>(this.TargetInventory, (CargoOpsViewModel._Closure$__.$I114-12 == null) ? (CargoOpsViewModel._Closure$__.$I114-12 = new Func<CargoOpsCargoItemViewModel, bool>(CargoOpsViewModel._Closure$__.$I.method_12)) : CargoOpsViewModel._Closure$__.$I114-12), (CargoOpsViewModel._Closure$__.$I114-13 == null) ? (CargoOpsViewModel._Closure$__.$I114-13 = new Func<CargoOpsCargoItemViewModel, int>(CargoOpsViewModel._Closure$__.$I.method_13)) : CargoOpsViewModel._Closure$__.$I114-13), (CargoOpsViewModel._Closure$__.$I114-14 == null) ? (CargoOpsViewModel._Closure$__.$I114-14 = new Func<int, int>(CargoOpsViewModel._Closure$__.$I.method_14)) : CargoOpsViewModel._Closure$__.$I114-14);
				this.TargetRequiredCrew = (double)Enumerable.Sum<int>(Enumerable.Select<CargoOpsCargoItemViewModel, int>(Enumerable.Where<CargoOpsCargoItemViewModel>(this.TargetInventory, (CargoOpsViewModel._Closure$__.$I114-15 == null) ? (CargoOpsViewModel._Closure$__.$I114-15 = new Func<CargoOpsCargoItemViewModel, bool>(CargoOpsViewModel._Closure$__.$I.method_15)) : CargoOpsViewModel._Closure$__.$I114-15), (CargoOpsViewModel._Closure$__.$I114-16 == null) ? (CargoOpsViewModel._Closure$__.$I114-16 = new Func<CargoOpsCargoItemViewModel, int>(CargoOpsViewModel._Closure$__.$I.method_16)) : CargoOpsViewModel._Closure$__.$I114-16), (CargoOpsViewModel._Closure$__.$I114-17 == null) ? (CargoOpsViewModel._Closure$__.$I114-17 = new Func<int, int>(CargoOpsViewModel._Closure$__.$I.method_17)) : CargoOpsViewModel._Closure$__.$I114-17);
				try
				{
					foreach (CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel2 in this.TargetInventory)
					{
						if (cargoOpsCargoItemViewModel2.CargoType > this.HostType | cargoOpsCargoItemViewModel2.CargoType > this.TargetType)
						{
							cargoOpsCargoItemViewModel2.CargoTypeLimited = true;
						}
					}
				}
				finally
				{
					IEnumerator<CargoOpsCargoItemViewModel> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
			}
		}

		// Token: 0x06005E77 RID: 24183 RVA: 0x0033276C File Offset: 0x0033096C
		public CargoOpsViewModel(CargoOps Form, ActiveUnit selectedHost, ActiveUnit selectedTarget)
		{
			this.HostInventory = new ObservableCollection<CargoOpsCargoItemViewModel>();
			this.cargo_0 = new Cargo[0];
			this.collection_0 = new Collection<ActiveUnit>();
			this.TargetInventory = new ObservableCollection<CargoOpsCargoItemViewModel>();
			this.UnloadAllCommand = new Class2569(new Action<object>(this.method_8));
			this.UnloadOneCommand = new Class2569(new Action<object>(this.method_9));
			this.LoadOneCommand = new Class2569(new Action<object>(this.method_10));
			this.LoadAllCommand = new Class2569(new Action<object>(this.method_11));
			this.OKCommand = new Class2569(new Action<object>(this.method_12));
			this.CancelCommand = new Class2569(new Action<object>(this.method_13));
			this.Form = Form;
			SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
			this.AllMounts = DBFunctions.smethod_68(ref sqliteConnection);
			this.Host = selectedHost;
			this.Target = selectedTarget;
			if (this.Target == null)
			{
				this.Exchange = false;
			}
			else
			{
				this.Exchange = true;
			}
			if (this.Host == null)
			{
				if (this.Target is Aircraft)
				{
					Aircraft_AirOps aircraft_AirOps = ((Aircraft)this.Target).method_164();
					this.Host = aircraft_AirOps.method_30();
				}
				else if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			Form.Text = string.Format("Cargo {0}", this.Host.Name);
			this.HostName = this.Host.Name;
			if (!(this.Host is Group))
			{
				Interface3 @interface = (Interface3)this.Host;
				this.HostTotalMass = (double)@interface.imethod_3();
				this.HostTotalArea = (double)@interface.imethod_1();
				this.HostTotalCrew = (double)@interface.imethod_0();
				this.HostType = @interface.imethod_2();
				this.cargo_0 = this.Host.cargo_0;
			}
			else
			{
				Group group = (Group)this.Host;
				this.cargo_0 = new Cargo[0];
				this.HostTotalMass = 0.0;
				this.HostTotalArea = 0.0;
				this.HostTotalCrew = 0.0;
				this.HostType = CargoType.VLargeCargo;
				this.HostIsGroup = true;
				try
				{
					foreach (KeyValuePair<string, ActiveUnit> keyValuePair in group.vmethod_141())
					{
						Interface3 interface2 = (Interface3)keyValuePair.Value;
						this.HostTotalMass += (double)interface2.imethod_3();
						this.HostTotalArea += (double)interface2.imethod_1();
						this.HostTotalCrew += (double)interface2.imethod_0();
						foreach (Cargo cargo_ in keyValuePair.Value.cargo_0)
						{
							Class429.smethod_6(ref this.cargo_0, cargo_);
						}
						this.collection_0.Add(keyValuePair.Value);
					}
				}
				finally
				{
					IEnumerator<KeyValuePair<string, ActiveUnit>> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			try
			{
				foreach (var vb$AnonymousType_ in Enumerable.GroupBy(Enumerable.Where<Cargo>(this.cargo_0, (CargoOpsViewModel._Closure$__.$I115-0 == null) ? (CargoOpsViewModel._Closure$__.$I115-0 = new Func<Cargo, bool>(CargoOpsViewModel._Closure$__.$I.method_18)) : CargoOpsViewModel._Closure$__.$I115-0), (CargoOpsViewModel._Closure$__.$I115-1 == null) ? (CargoOpsViewModel._Closure$__.$I115-1 = new Func<Cargo, int>(CargoOpsViewModel._Closure$__.$I.method_19)) : CargoOpsViewModel._Closure$__.$I115-1, (CargoOpsViewModel._Closure$__.$I115-2 == null) ? (CargoOpsViewModel._Closure$__.$I115-2 = new Func<int, IEnumerable<Cargo>, VB$AnonymousType_0<int, int>>(CargoOpsViewModel._Closure$__.$I.method_20)) : CargoOpsViewModel._Closure$__.$I115-2))
				{
					CargoOpsCargoItemViewModel item = new CargoOpsCargoItemViewModel
					{
						Cargo = new Cargo(this.Host, DBFunctions.smethod_110(vb$AnonymousType_.DBID, ref this.Host.scenario_0, true)),
						Quantity = vb$AnonymousType_.method_0(),
						InitialQuantity = vb$AnonymousType_.method_0()
					};
					this.HostInventory.Add(item);
				}
			}
			finally
			{
				var enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			if (this.Target != null)
			{
				Form.Text = string.Format("Cargo Exchange {0} <=> {1}", this.Host.Name, this.Target.Name);
				this.TargetName = this.Target.Name;
				Interface3 interface3 = (Interface3)this.Target;
				this.TargetTotalMass = (double)interface3.imethod_3();
				this.TargetTotalArea = (double)interface3.imethod_1();
				this.TargetTotalCrew = (double)interface3.imethod_0();
				this.TargetType = interface3.imethod_2();
				try
				{
					foreach (var vb$AnonymousType_2 in Enumerable.GroupBy(Enumerable.Where<Cargo>(this.Target.cargo_0, (CargoOpsViewModel._Closure$__.$I115-3 == null) ? (CargoOpsViewModel._Closure$__.$I115-3 = new Func<Cargo, bool>(CargoOpsViewModel._Closure$__.$I.method_21)) : CargoOpsViewModel._Closure$__.$I115-3), (CargoOpsViewModel._Closure$__.$I115-4 == null) ? (CargoOpsViewModel._Closure$__.$I115-4 = new Func<Cargo, int>(CargoOpsViewModel._Closure$__.$I.method_22)) : CargoOpsViewModel._Closure$__.$I115-4, (CargoOpsViewModel._Closure$__.$I115-5 == null) ? (CargoOpsViewModel._Closure$__.$I115-5 = new Func<int, IEnumerable<Cargo>, VB$AnonymousType_0<int, int>>(CargoOpsViewModel._Closure$__.$I.method_23)) : CargoOpsViewModel._Closure$__.$I115-5))
					{
						CargoOpsCargoItemViewModel item2 = new CargoOpsCargoItemViewModel
						{
							Cargo = new Cargo(this.Target, DBFunctions.smethod_110(vb$AnonymousType_2.DBID, ref this.Target.scenario_0, true)),
							Quantity = vb$AnonymousType_2.method_0(),
							InitialQuantity = vb$AnonymousType_2.method_0()
						};
						this.TargetInventory.Add(item2);
					}
				}
				finally
				{
					var enumerator3;
					if (enumerator3 != null)
					{
						enumerator3.Dispose();
					}
				}
			}
			this.method_0();
		}

		// Token: 0x06005E78 RID: 24184 RVA: 0x00332D1C File Offset: 0x00330F1C
		private void method_1(CargoOpsCargoItemViewModel Item, ActiveUnit DestActiveUnit, ref ObservableCollection<CargoOpsCargoItemViewModel> Source, ref ObservableCollection<CargoOpsCargoItemViewModel> Dest, int Quantity, double DestRequiredMass, double DestTotalMass, double DestRequiredArea, double DestTotalArea, double DestRequiredCrew, double DestTotalCrew)
		{
			CargoOpsViewModel.Class2436 @class = new CargoOpsViewModel.Class2436();
			@class.cargoOpsCargoItemViewModel_0 = Item;
			if (@class.cargoOpsCargoItemViewModel_0 != null && @class.cargoOpsCargoItemViewModel_0.Quantity > 0 && !@class.cargoOpsCargoItemViewModel_0.CargoTypeLimited)
			{
				double massPerUnit = @class.cargoOpsCargoItemViewModel_0.MassPerUnit;
				double areaPerUnit = @class.cargoOpsCargoItemViewModel_0.AreaPerUnit;
				double crewPerUnit = @class.cargoOpsCargoItemViewModel_0.CrewPerUnit;
				double num = (DestTotalMass - DestRequiredMass) / massPerUnit;
				double num2 = (DestTotalArea - DestRequiredArea) / areaPerUnit;
				double num3 = (DestTotalCrew - DestRequiredCrew) / crewPerUnit;
				CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel = Enumerable.First<CargoOpsCargoItemViewModel>(Source, new Func<CargoOpsCargoItemViewModel, bool>(@class.method_0));
				int num4 = (int)Math.Floor(Enumerable.Min(Enumerable.ToArray<double>(Enumerable.Where<double>(new double[]
				{
					(double)Quantity,
					num,
					num2,
					num3,
					(double)cargoOpsCargoItemViewModel.Quantity
				}, (CargoOpsViewModel._Closure$__.$I116-1 == null) ? (CargoOpsViewModel._Closure$__.$I116-1 = new Func<double, bool>(CargoOpsViewModel._Closure$__.$I.method_24)) : CargoOpsViewModel._Closure$__.$I116-1))));
				if (num4 != 0)
				{
					CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel2 = Enumerable.FirstOrDefault<CargoOpsCargoItemViewModel>(Dest, new Func<CargoOpsCargoItemViewModel, bool>(@class.method_1));
					if (cargoOpsCargoItemViewModel2 == null)
					{
						cargoOpsCargoItemViewModel2 = new CargoOpsCargoItemViewModel
						{
							Cargo = new Cargo(DestActiveUnit, DBFunctions.smethod_110(Conversions.ToInteger(NewLateBinding.LateGet(@class.cargoOpsCargoItemViewModel_0.Cargo.method_25(), null, "DBID", new object[0], null, null, null)), ref DestActiveUnit.scenario_0, true)),
							Quantity = 0,
							InitialQuantity = 0
						};
						Dest.Add(cargoOpsCargoItemViewModel2);
					}
					CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel3;
					(cargoOpsCargoItemViewModel3 = cargoOpsCargoItemViewModel2).Quantity = cargoOpsCargoItemViewModel3.Quantity + num4;
					(cargoOpsCargoItemViewModel3 = cargoOpsCargoItemViewModel).Quantity = cargoOpsCargoItemViewModel3.Quantity - num4;
					this.method_0();
				}
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06005E79 RID: 24185 RVA: 0x0003D17F File Offset: 0x0003B37F
		// (set) Token: 0x06005E7A RID: 24186 RVA: 0x0003D187 File Offset: 0x0003B387
		public Class2569 UnloadAllCommand
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
				this.vmethod_0("UnloadAllCommand");
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06005E7B RID: 24187 RVA: 0x0003D1A7 File Offset: 0x0003B3A7
		// (set) Token: 0x06005E7C RID: 24188 RVA: 0x0003D1AF File Offset: 0x0003B3AF
		public Class2569 UnloadOneCommand
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
				this.vmethod_0("UnloadOneCommand");
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06005E7D RID: 24189 RVA: 0x0003D1CF File Offset: 0x0003B3CF
		// (set) Token: 0x06005E7E RID: 24190 RVA: 0x0003D1D7 File Offset: 0x0003B3D7
		public Class2569 LoadOneCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_2 == value)
				{
					return;
				}
				this.class2569_2 = value;
				this.vmethod_0("LoadOneCommand");
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06005E7F RID: 24191 RVA: 0x0003D1F7 File Offset: 0x0003B3F7
		// (set) Token: 0x06005E80 RID: 24192 RVA: 0x0003D1FF File Offset: 0x0003B3FF
		public Class2569 LoadAllCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_3 == value)
				{
					return;
				}
				this.class2569_3 = value;
				this.vmethod_0("LoadAllCommand");
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06005E81 RID: 24193 RVA: 0x0003D21F File Offset: 0x0003B41F
		// (set) Token: 0x06005E82 RID: 24194 RVA: 0x0003D227 File Offset: 0x0003B427
		public Class2569 OKCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_4;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_4 == value)
				{
					return;
				}
				this.class2569_4 = value;
				this.vmethod_0("OKCommand");
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06005E83 RID: 24195 RVA: 0x0003D247 File Offset: 0x0003B447
		// (set) Token: 0x06005E84 RID: 24196 RVA: 0x0003D24F File Offset: 0x0003B44F
		public Class2569 CancelCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_5;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_5 == value)
				{
					return;
				}
				this.class2569_5 = value;
				this.vmethod_0("CancelCommand");
			}
		}

		// Token: 0x06005E85 RID: 24197 RVA: 0x00332EC8 File Offset: 0x003310C8
		public void method_2()
		{
			if (this.TargetSelectedItem != null)
			{
				CargoOpsCargoItemViewModel targetSelectedItem = this.TargetSelectedItem;
				ActiveUnit host = this.Host;
				ObservableCollection<CargoOpsCargoItemViewModel> targetInventory = this.TargetInventory;
				ObservableCollection<CargoOpsCargoItemViewModel> hostInventory = this.HostInventory;
				this.method_1(targetSelectedItem, host, ref targetInventory, ref hostInventory, this.TargetSelectedItem.Quantity, this.HostRequiredMass, this.HostTotalMass, this.HostRequiredArea, this.HostTotalArea, this.HostRequiredCrew, this.HostTotalCrew);
				this.HostInventory = hostInventory;
				this.TargetInventory = targetInventory;
			}
		}

		// Token: 0x06005E86 RID: 24198 RVA: 0x00332F40 File Offset: 0x00331140
		public void method_3()
		{
			CargoOpsCargoItemViewModel targetSelectedItem = this.TargetSelectedItem;
			ActiveUnit host = this.Host;
			ObservableCollection<CargoOpsCargoItemViewModel> targetInventory = this.TargetInventory;
			ObservableCollection<CargoOpsCargoItemViewModel> hostInventory = this.HostInventory;
			this.method_1(targetSelectedItem, host, ref targetInventory, ref hostInventory, 1, this.HostRequiredMass, this.HostTotalMass, this.HostRequiredArea, this.HostTotalArea, this.HostRequiredCrew, this.HostTotalCrew);
			this.HostInventory = hostInventory;
			this.TargetInventory = targetInventory;
		}

		// Token: 0x06005E87 RID: 24199 RVA: 0x00332FA4 File Offset: 0x003311A4
		public void method_4()
		{
			CargoOpsCargoItemViewModel hostSelectedItem = this.HostSelectedItem;
			ActiveUnit target = this.Target;
			ObservableCollection<CargoOpsCargoItemViewModel> hostInventory = this.HostInventory;
			ObservableCollection<CargoOpsCargoItemViewModel> targetInventory = this.TargetInventory;
			this.method_1(hostSelectedItem, target, ref hostInventory, ref targetInventory, 1, this.TargetRequiredMass, this.TargetTotalMass, this.TargetRequiredArea, this.TargetTotalArea, this.TargetRequiredCrew, this.TargetTotalCrew);
			this.TargetInventory = targetInventory;
			this.HostInventory = hostInventory;
		}

		// Token: 0x06005E88 RID: 24200 RVA: 0x00333008 File Offset: 0x00331208
		public void method_5()
		{
			if (this.HostSelectedItem != null)
			{
				CargoOpsCargoItemViewModel hostSelectedItem = this.HostSelectedItem;
				ActiveUnit target = this.Target;
				ObservableCollection<CargoOpsCargoItemViewModel> hostInventory = this.HostInventory;
				ObservableCollection<CargoOpsCargoItemViewModel> targetInventory = this.TargetInventory;
				this.method_1(hostSelectedItem, target, ref hostInventory, ref targetInventory, this.HostSelectedItem.Quantity, this.TargetRequiredMass, this.TargetTotalMass, this.TargetRequiredArea, this.TargetTotalArea, this.TargetRequiredCrew, this.TargetTotalCrew);
				this.TargetInventory = targetInventory;
				this.HostInventory = hostInventory;
			}
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x00333080 File Offset: 0x00331280
		public void method_6()
		{
			if (!this.HostIsGroup)
			{
				List<Cargo> list = new List<Cargo>();
				List<Cargo> list2 = new List<Cargo>();
				try
				{
					IEnumerator<CargoOpsCargoItemViewModel> enumerator = this.HostInventory.GetEnumerator();
					while (enumerator.MoveNext())
					{
						CargoOpsViewModel.Class2437 @class = new CargoOpsViewModel.Class2437(@class);
						@class.cargoOpsCargoItemViewModel_0 = enumerator.Current;
						if (@class.cargoOpsCargoItemViewModel_0.Quantity < @class.cargoOpsCargoItemViewModel_0.InitialQuantity)
						{
							int num = @class.cargoOpsCargoItemViewModel_0.InitialQuantity - @class.cargoOpsCargoItemViewModel_0.Quantity;
							list.AddRange(Enumerable.Take<Cargo>(Enumerable.Where<Cargo>(this.Host.cargo_0, new Func<Cargo, bool>(@class.method_0)), num));
						}
					}
				}
				finally
				{
					IEnumerator<CargoOpsCargoItemViewModel> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				try
				{
					IEnumerator<CargoOpsCargoItemViewModel> enumerator2 = this.TargetInventory.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						CargoOpsViewModel.Class2438 class2 = new CargoOpsViewModel.Class2438(class2);
						class2.cargoOpsCargoItemViewModel_0 = enumerator2.Current;
						if (class2.cargoOpsCargoItemViewModel_0.Quantity < class2.cargoOpsCargoItemViewModel_0.InitialQuantity)
						{
							int num2 = class2.cargoOpsCargoItemViewModel_0.InitialQuantity - class2.cargoOpsCargoItemViewModel_0.Quantity;
							list2.AddRange(Enumerable.Take<Cargo>(Enumerable.Where<Cargo>(this.Target.cargo_0, new Func<Cargo, bool>(class2.method_0)), num2));
						}
					}
				}
				finally
				{
					IEnumerator<CargoOpsCargoItemViewModel> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
				if (list.Count != 0)
				{
					ActiveUnit_DockingOps.smethod_13(this.Host, this.Target, list);
				}
				if (list2.Count != 0)
				{
					ActiveUnit_DockingOps.smethod_13(this.Target, this.Host, list2);
				}
				if (this.Target is Ship & (list.Count > 0 || list2.Count > 0))
				{
					this.Target.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.Readying);
					this.Target.vmethod_93().method_1(Math.Max(this.Target.vmethod_93().method_0(), 1800f));
				}
				else if (this.Target is Aircraft & (list.Count > 0 || list2.Count > 0))
				{
					((Aircraft)this.Target).method_164().method_37(Aircraft_AirOps._AirOpsCondition.Readying);
					((Aircraft)this.Target).method_164().method_39(Math.Max(((Aircraft)this.Target).method_164().method_38(), 1800f));
				}
			}
			else
			{
				Dictionary<int, int> dictionary = new Dictionary<int, int>();
				Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
				try
				{
					foreach (CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel in this.HostInventory)
					{
						if (cargoOpsCargoItemViewModel.Quantity < cargoOpsCargoItemViewModel.InitialQuantity)
						{
							int value = cargoOpsCargoItemViewModel.InitialQuantity - cargoOpsCargoItemViewModel.Quantity;
							dictionary[Conversions.ToInteger(NewLateBinding.LateGet(cargoOpsCargoItemViewModel.Cargo.method_25(), null, "DBID", new object[0], null, null, null))] = value;
						}
					}
				}
				finally
				{
					IEnumerator<CargoOpsCargoItemViewModel> enumerator3;
					if (enumerator3 != null)
					{
						enumerator3.Dispose();
					}
				}
				try
				{
					foreach (CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel2 in this.TargetInventory)
					{
						if (cargoOpsCargoItemViewModel2.Quantity < cargoOpsCargoItemViewModel2.InitialQuantity)
						{
							int value2 = cargoOpsCargoItemViewModel2.InitialQuantity - cargoOpsCargoItemViewModel2.Quantity;
							dictionary2[Conversions.ToInteger(NewLateBinding.LateGet(cargoOpsCargoItemViewModel2.Cargo.method_25(), null, "DBID", new object[0], null, null, null))] = value2;
						}
					}
				}
				finally
				{
					IEnumerator<CargoOpsCargoItemViewModel> enumerator4;
					if (enumerator4 != null)
					{
						enumerator4.Dispose();
					}
				}
				checked
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.collection_0)
						{
							List<Cargo> list3 = new List<Cargo>();
							KeyValuePair<int, int>[] array = Enumerable.ToArray<KeyValuePair<int, int>>(dictionary);
							for (int i = 0; i < array.Length; i++)
							{
								CargoOpsViewModel.Class2439 class3 = new CargoOpsViewModel.Class2439(class3);
								class3.keyValuePair_0 = array[i];
								IEnumerable<Cargo> enumerable = Enumerable.Where<Cargo>(activeUnit.cargo_0, new Func<Cargo, bool>(class3.method_0));
								int value3 = class3.keyValuePair_0.Value;
								int num3 = Math.Min(Enumerable.Count<Cargo>(enumerable), value3);
								list3.AddRange(Enumerable.Take<Cargo>(Enumerable.Where<Cargo>(activeUnit.cargo_0, new Func<Cargo, bool>(class3.method_1)), num3));
								dictionary[class3.keyValuePair_0.Key] = unchecked(dictionary[class3.keyValuePair_0.Key] - num3);
							}
							ActiveUnit_DockingOps.smethod_13(activeUnit, this.Target, list3);
							if (this.Target is Ship)
							{
								this.Target.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.Readying);
								this.Target.vmethod_93().method_1(Math.Max(this.Target.vmethod_93().method_0(), 1800f));
							}
							else if (this.Target is Aircraft)
							{
								((Aircraft)this.Target).method_164().method_37(Aircraft_AirOps._AirOpsCondition.Readying);
								((Aircraft)this.Target).method_164().method_39(Math.Max(((Aircraft)this.Target).method_164().method_38(), 1800f));
							}
						}
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator5;
						if (enumerator5 != null)
						{
							enumerator5.Dispose();
						}
					}
					List<Cargo> list4 = new List<Cargo>();
					try
					{
						Dictionary<int, int>.Enumerator enumerator6 = dictionary2.GetEnumerator();
						while (enumerator6.MoveNext())
						{
							CargoOpsViewModel.Class2440 class4 = new CargoOpsViewModel.Class2440(class4);
							class4.keyValuePair_0 = enumerator6.Current;
							list4.AddRange(Enumerable.Take<Cargo>(Enumerable.Where<Cargo>(this.Target.cargo_0, new Func<Cargo, bool>(class4.method_0)), class4.keyValuePair_0.Value));
						}
					}
					finally
					{
						Dictionary<int, int>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
					ActiveUnit_DockingOps.smethod_13(this.Target, Enumerable.First<KeyValuePair<string, ActiveUnit>>(((Group)this.Host).vmethod_141()).Value, list4);
				}
			}
			this.AllMounts.Dispose();
			this.Form.Close();
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x0003D26F File Offset: 0x0003B46F
		public void method_7()
		{
			this.AllMounts.Dispose();
			this.Form.Close();
		}

		// Token: 0x06005E8B RID: 24203 RVA: 0x0003D287 File Offset: 0x0003B487
		[CompilerGenerated]
		private void method_8(object a0)
		{
			this.method_2();
		}

		// Token: 0x06005E8C RID: 24204 RVA: 0x0003D28F File Offset: 0x0003B48F
		[CompilerGenerated]
		private void method_9(object a0)
		{
			this.method_3();
		}

		// Token: 0x06005E8D RID: 24205 RVA: 0x0003D297 File Offset: 0x0003B497
		[CompilerGenerated]
		private void method_10(object a0)
		{
			this.method_4();
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x0003D29F File Offset: 0x0003B49F
		[CompilerGenerated]
		private void method_11(object a0)
		{
			this.method_5();
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x0003D2A7 File Offset: 0x0003B4A7
		[CompilerGenerated]
		private void method_12(object a0)
		{
			this.method_6();
		}

		// Token: 0x06005E90 RID: 24208 RVA: 0x0003D2AF File Offset: 0x0003B4AF
		[CompilerGenerated]
		private void method_13(object a0)
		{
			this.method_7();
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06005E91 RID: 24209 RVA: 0x003336E8 File Offset: 0x003318E8
		// (remove) Token: 0x06005E92 RID: 24210 RVA: 0x00333720 File Offset: 0x00331920
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

		// Token: 0x06005E93 RID: 24211 RVA: 0x00333758 File Offset: 0x00331958
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040036B1 RID: 14001
		[CompilerGenerated]
		private CargoOps cargoOps_0;

		// Token: 0x040036B2 RID: 14002
		[CompilerGenerated]
		private ActiveUnit activeUnit_0;

		// Token: 0x040036B3 RID: 14003
		[CompilerGenerated]
		private ActiveUnit activeUnit_1;

		// Token: 0x040036B4 RID: 14004
		[CompilerGenerated]
		private ObservableCollection<CargoOpsCargoItemViewModel> observableCollection_0;

		// Token: 0x040036B5 RID: 14005
		[CompilerGenerated]
		private CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel_0;

		// Token: 0x040036B6 RID: 14006
		[CompilerGenerated]
		private double double_0;

		// Token: 0x040036B7 RID: 14007
		[CompilerGenerated]
		private double double_1;

		// Token: 0x040036B8 RID: 14008
		[CompilerGenerated]
		private double double_2;

		// Token: 0x040036B9 RID: 14009
		[CompilerGenerated]
		private double double_3;

		// Token: 0x040036BA RID: 14010
		[CompilerGenerated]
		private double double_4;

		// Token: 0x040036BB RID: 14011
		[CompilerGenerated]
		private double double_5;

		// Token: 0x040036BC RID: 14012
		[CompilerGenerated]
		private CargoType cargoType_0;

		// Token: 0x040036BD RID: 14013
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040036BE RID: 14014
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040036BF RID: 14015
		private Cargo[] cargo_0;

		// Token: 0x040036C0 RID: 14016
		private Collection<ActiveUnit> collection_0;

		// Token: 0x040036C1 RID: 14017
		[CompilerGenerated]
		private ObservableCollection<CargoOpsCargoItemViewModel> observableCollection_1;

		// Token: 0x040036C2 RID: 14018
		[CompilerGenerated]
		private CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel_1;

		// Token: 0x040036C3 RID: 14019
		[CompilerGenerated]
		private double double_6;

		// Token: 0x040036C4 RID: 14020
		[CompilerGenerated]
		private double double_7;

		// Token: 0x040036C5 RID: 14021
		[CompilerGenerated]
		private double double_8;

		// Token: 0x040036C6 RID: 14022
		[CompilerGenerated]
		private double double_9;

		// Token: 0x040036C7 RID: 14023
		[CompilerGenerated]
		private double double_10;

		// Token: 0x040036C8 RID: 14024
		[CompilerGenerated]
		private double double_11;

		// Token: 0x040036C9 RID: 14025
		[CompilerGenerated]
		private CargoType cargoType_1;

		// Token: 0x040036CA RID: 14026
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040036CB RID: 14027
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040036CC RID: 14028
		[CompilerGenerated]
		private DataTable dataTable_0;

		// Token: 0x040036CD RID: 14029
		[CompilerGenerated]
		private Class2569 class2569_0;

		// Token: 0x040036CE RID: 14030
		[CompilerGenerated]
		private Class2569 class2569_1;

		// Token: 0x040036CF RID: 14031
		[CompilerGenerated]
		private Class2569 class2569_2;

		// Token: 0x040036D0 RID: 14032
		[CompilerGenerated]
		private Class2569 class2569_3;

		// Token: 0x040036D1 RID: 14033
		[CompilerGenerated]
		private Class2569 class2569_4;

		// Token: 0x040036D2 RID: 14034
		[CompilerGenerated]
		private Class2569 class2569_5;

		// Token: 0x040036D3 RID: 14035
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x02000DAF RID: 3503
		[CompilerGenerated]
		internal sealed class Class2436
		{
			// Token: 0x06005EB0 RID: 24240 RVA: 0x00333780 File Offset: 0x00331980
			internal bool method_0(CargoOpsCargoItemViewModel I)
			{
				return Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(I.Cargo.method_25(), null, "DBID", new object[0], null, null, null), NewLateBinding.LateGet(this.cargoOpsCargoItemViewModel_0.Cargo.method_25(), null, "DBID", new object[0], null, null, null), false);
			}

			// Token: 0x06005EB1 RID: 24241 RVA: 0x00333780 File Offset: 0x00331980
			internal bool method_1(CargoOpsCargoItemViewModel I)
			{
				return Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(I.Cargo.method_25(), null, "DBID", new object[0], null, null, null), NewLateBinding.LateGet(this.cargoOpsCargoItemViewModel_0.Cargo.method_25(), null, "DBID", new object[0], null, null, null), false);
			}

			// Token: 0x040036EE RID: 14062
			public CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel_0;
		}

		// Token: 0x02000DB0 RID: 3504
		[CompilerGenerated]
		internal sealed class Class2437
		{
			// Token: 0x06005EB2 RID: 24242 RVA: 0x0003D358 File Offset: 0x0003B558
			public Class2437(CargoOpsViewModel.Class2437 arg0)
			{
				if (arg0 != null)
				{
					this.cargoOpsCargoItemViewModel_0 = arg0.cargoOpsCargoItemViewModel_0;
				}
			}

			// Token: 0x06005EB3 RID: 24243 RVA: 0x003337D8 File Offset: 0x003319D8
			internal bool method_0(Cargo OC)
			{
				return Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(OC.method_25(), null, "DBID", new object[0], null, null, null), NewLateBinding.LateGet(this.cargoOpsCargoItemViewModel_0.Cargo.method_25(), null, "DBID", new object[0], null, null, null), false);
			}

			// Token: 0x040036EF RID: 14063
			public CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel_0;
		}

		// Token: 0x02000DB1 RID: 3505
		[CompilerGenerated]
		internal sealed class Class2438
		{
			// Token: 0x06005EB4 RID: 24244 RVA: 0x0003D36F File Offset: 0x0003B56F
			public Class2438(CargoOpsViewModel.Class2438 arg0)
			{
				if (arg0 != null)
				{
					this.cargoOpsCargoItemViewModel_0 = arg0.cargoOpsCargoItemViewModel_0;
				}
			}

			// Token: 0x06005EB5 RID: 24245 RVA: 0x0033382C File Offset: 0x00331A2C
			internal bool method_0(Cargo OC)
			{
				return Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(OC.method_25(), null, "DBID", new object[0], null, null, null), NewLateBinding.LateGet(this.cargoOpsCargoItemViewModel_0.Cargo.method_25(), null, "DBID", new object[0], null, null, null), false);
			}

			// Token: 0x040036F0 RID: 14064
			public CargoOpsCargoItemViewModel cargoOpsCargoItemViewModel_0;
		}

		// Token: 0x02000DB2 RID: 3506
		[CompilerGenerated]
		internal sealed class Class2439
		{
			// Token: 0x06005EB6 RID: 24246 RVA: 0x0003D386 File Offset: 0x0003B586
			public Class2439(CargoOpsViewModel.Class2439 arg0)
			{
				if (arg0 != null)
				{
					this.keyValuePair_0 = arg0.keyValuePair_0;
				}
			}

			// Token: 0x06005EB7 RID: 24247 RVA: 0x0003D39D File Offset: 0x0003B59D
			internal bool method_0(Cargo OC)
			{
				return Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(OC.method_25(), null, "DBID", new object[0], null, null, null), this.keyValuePair_0.Key, false);
			}

			// Token: 0x06005EB8 RID: 24248 RVA: 0x0003D39D File Offset: 0x0003B59D
			internal bool method_1(Cargo OC)
			{
				return Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(OC.method_25(), null, "DBID", new object[0], null, null, null), this.keyValuePair_0.Key, false);
			}

			// Token: 0x040036F1 RID: 14065
			public KeyValuePair<int, int> keyValuePair_0;
		}

		// Token: 0x02000DB3 RID: 3507
		[CompilerGenerated]
		internal sealed class Class2440
		{
			// Token: 0x06005EB9 RID: 24249 RVA: 0x0003D3CF File Offset: 0x0003B5CF
			public Class2440(CargoOpsViewModel.Class2440 arg0)
			{
				if (arg0 != null)
				{
					this.keyValuePair_0 = arg0.keyValuePair_0;
				}
			}

			// Token: 0x06005EBA RID: 24250 RVA: 0x0003D3E6 File Offset: 0x0003B5E6
			internal bool method_0(Cargo OC)
			{
				return Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(OC.method_25(), null, "DBID", new object[0], null, null, null), this.keyValuePair_0.Key, false);
			}

			// Token: 0x040036F2 RID: 14066
			public KeyValuePair<int, int> keyValuePair_0;
		}
	}
}
