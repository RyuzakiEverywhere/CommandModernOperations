using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using Command_Core;
using ns14;

namespace Command
{
	// Token: 0x02000DF5 RID: 3573
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class HoverInfoTemplateSelector : DataTemplateSelector, INotifyPropertyChanged
	{
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060067EE RID: 26606 RVA: 0x000420BF File Offset: 0x000402BF
		// (set) Token: 0x060067EF RID: 26607 RVA: 0x000420C7 File Offset: 0x000402C7
		public DataTemplate ShipTemplate
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
				this.vmethod_0("ShipTemplate");
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060067F0 RID: 26608 RVA: 0x000420E7 File Offset: 0x000402E7
		// (set) Token: 0x060067F1 RID: 26609 RVA: 0x000420EF File Offset: 0x000402EF
		public DataTemplate SubTemplate
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
				this.vmethod_0("SubTemplate");
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060067F2 RID: 26610 RVA: 0x0004210F File Offset: 0x0004030F
		// (set) Token: 0x060067F3 RID: 26611 RVA: 0x00042117 File Offset: 0x00040317
		public DataTemplate AircraftTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.dataTemplate_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTemplate_2 == value)
				{
					return;
				}
				this.dataTemplate_2 = value;
				this.vmethod_0("AircraftTemplate");
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060067F4 RID: 26612 RVA: 0x00042137 File Offset: 0x00040337
		// (set) Token: 0x060067F5 RID: 26613 RVA: 0x0004213F File Offset: 0x0004033F
		public DataTemplate GroundUnitTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.dataTemplate_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTemplate_3 == value)
				{
					return;
				}
				this.dataTemplate_3 = value;
				this.vmethod_0("GroundUnitTemplate");
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060067F6 RID: 26614 RVA: 0x0004215F File Offset: 0x0004035F
		// (set) Token: 0x060067F7 RID: 26615 RVA: 0x00042167 File Offset: 0x00040367
		public DataTemplate SatelliteTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.dataTemplate_4;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTemplate_4 == value)
				{
					return;
				}
				this.dataTemplate_4 = value;
				this.vmethod_0("SatelliteTemplate");
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060067F8 RID: 26616 RVA: 0x00042187 File Offset: 0x00040387
		// (set) Token: 0x060067F9 RID: 26617 RVA: 0x0004218F File Offset: 0x0004038F
		public DataTemplate WeaponTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.dataTemplate_5;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTemplate_5 == value)
				{
					return;
				}
				this.dataTemplate_5 = value;
				this.vmethod_0("WeaponTemplate");
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060067FA RID: 26618 RVA: 0x000421AF File Offset: 0x000403AF
		// (set) Token: 0x060067FB RID: 26619 RVA: 0x000421B7 File Offset: 0x000403B7
		public DataTemplate AirbaseTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.dataTemplate_6;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTemplate_6 == value)
				{
					return;
				}
				this.dataTemplate_6 = value;
				this.vmethod_0("AirbaseTemplate");
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060067FC RID: 26620 RVA: 0x000421D7 File Offset: 0x000403D7
		// (set) Token: 0x060067FD RID: 26621 RVA: 0x000421DF File Offset: 0x000403DF
		public DataTemplate GroundGroupTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.dataTemplate_7;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTemplate_7 == value)
				{
					return;
				}
				this.dataTemplate_7 = value;
				this.vmethod_0("GroundGroupTemplate");
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060067FE RID: 26622 RVA: 0x000421FF File Offset: 0x000403FF
		// (set) Token: 0x060067FF RID: 26623 RVA: 0x00042207 File Offset: 0x00040407
		public DataTemplate NavalGroupTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.dataTemplate_8;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTemplate_8 == value)
				{
					return;
				}
				this.dataTemplate_8 = value;
				this.vmethod_0("NavalGroupTemplate");
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06006800 RID: 26624 RVA: 0x00042227 File Offset: 0x00040427
		// (set) Token: 0x06006801 RID: 26625 RVA: 0x0004222F File Offset: 0x0004042F
		public DataTemplate AirGroupTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.dataTemplate_9;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTemplate_9 == value)
				{
					return;
				}
				this.dataTemplate_9 = value;
				this.vmethod_0("AirGroupTemplate");
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06006802 RID: 26626 RVA: 0x0004224F File Offset: 0x0004044F
		// (set) Token: 0x06006803 RID: 26627 RVA: 0x00042257 File Offset: 0x00040457
		public DataTemplate ContactTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.dataTemplate_10;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTemplate_10 == value)
				{
					return;
				}
				this.dataTemplate_10 = value;
				this.vmethod_0("ContactTemplate");
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06006804 RID: 26628 RVA: 0x00042277 File Offset: 0x00040477
		// (set) Token: 0x06006805 RID: 26629 RVA: 0x0004227F File Offset: 0x0004047F
		public DataTemplate FallbackTemplate
		{
			[CompilerGenerated]
			get
			{
				return this.dataTemplate_11;
			}
			[CompilerGenerated]
			set
			{
				if (this.dataTemplate_11 == value)
				{
					return;
				}
				this.dataTemplate_11 = value;
				this.vmethod_0("FallbackTemplate");
			}
		}

		// Token: 0x06006806 RID: 26630 RVA: 0x00388E88 File Offset: 0x00387088
		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			HoverInfoViewModel hoverInfoViewModel = (HoverInfoViewModel)item;
			DataTemplate result;
			if (hoverInfoViewModel.Unit is Contact)
			{
				result = this.ContactTemplate;
			}
			else if (hoverInfoViewModel.Unit is Weapon)
			{
				result = this.WeaponTemplate;
			}
			else
			{
				if (hoverInfoViewModel.Unit is Group)
				{
					Group group = (Group)hoverInfoViewModel.Unit;
					if (Enumerable.Any<ActiveUnit>(group.vmethod_141().Values, (HoverInfoTemplateSelector._Closure$__.$I49-0 == null) ? (HoverInfoTemplateSelector._Closure$__.$I49-0 = new Func<ActiveUnit, bool>(HoverInfoTemplateSelector._Closure$__.$I.method_0)) : HoverInfoTemplateSelector._Closure$__.$I49-0))
					{
						if (Enumerable.Any<ActiveUnit>(group.vmethod_141().Values, (HoverInfoTemplateSelector._Closure$__.$I49-1 == null) ? (HoverInfoTemplateSelector._Closure$__.$I49-1 = new Func<ActiveUnit, bool>(HoverInfoTemplateSelector._Closure$__.$I.method_1)) : HoverInfoTemplateSelector._Closure$__.$I49-1))
						{
							return this.AirbaseTemplate;
						}
						if (Enumerable.Any<ActiveUnit>(group.vmethod_141().Values, (HoverInfoTemplateSelector._Closure$__.$I49-3 == null) ? (HoverInfoTemplateSelector._Closure$__.$I49-3 = new Func<ActiveUnit, bool>(HoverInfoTemplateSelector._Closure$__.$I.method_3)) : HoverInfoTemplateSelector._Closure$__.$I49-3))
						{
							return this.AirbaseTemplate;
						}
						return this.GroundGroupTemplate;
					}
					else
					{
						if (Enumerable.Any<ActiveUnit>(group.vmethod_141().Values, (HoverInfoTemplateSelector._Closure$__.$I49-5 == null) ? (HoverInfoTemplateSelector._Closure$__.$I49-5 = new Func<ActiveUnit, bool>(HoverInfoTemplateSelector._Closure$__.$I.method_5)) : HoverInfoTemplateSelector._Closure$__.$I49-5))
						{
							return this.NavalGroupTemplate;
						}
						if (Enumerable.Any<ActiveUnit>(group.vmethod_141().Values, (HoverInfoTemplateSelector._Closure$__.$I49-6 == null) ? (HoverInfoTemplateSelector._Closure$__.$I49-6 = new Func<ActiveUnit, bool>(HoverInfoTemplateSelector._Closure$__.$I.method_6)) : HoverInfoTemplateSelector._Closure$__.$I49-6))
						{
							return this.AirGroupTemplate;
						}
					}
				}
				if (hoverInfoViewModel.Unit is ActiveUnit)
				{
					ActiveUnit activeUnit = (ActiveUnit)hoverInfoViewModel.Unit;
					if (activeUnit is Ship)
					{
						return this.ShipTemplate;
					}
					if (activeUnit is Aircraft)
					{
						return this.AircraftTemplate;
					}
					if (activeUnit is Submarine)
					{
						return this.SubTemplate;
					}
					if (activeUnit is Facility)
					{
						return this.GroundUnitTemplate;
					}
					if (activeUnit is Satellite)
					{
						return this.SatelliteTemplate;
					}
				}
				result = this.FallbackTemplate;
			}
			return result;
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06006807 RID: 26631 RVA: 0x003890AC File Offset: 0x003872AC
		// (remove) Token: 0x06006808 RID: 26632 RVA: 0x003890E4 File Offset: 0x003872E4
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

		// Token: 0x06006809 RID: 26633 RVA: 0x0038911C File Offset: 0x0038731C
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003B2E RID: 15150
		[CompilerGenerated]
		private DataTemplate dataTemplate_0;

		// Token: 0x04003B2F RID: 15151
		[CompilerGenerated]
		private DataTemplate dataTemplate_1;

		// Token: 0x04003B30 RID: 15152
		[CompilerGenerated]
		private DataTemplate dataTemplate_2;

		// Token: 0x04003B31 RID: 15153
		[CompilerGenerated]
		private DataTemplate dataTemplate_3;

		// Token: 0x04003B32 RID: 15154
		[CompilerGenerated]
		private DataTemplate dataTemplate_4;

		// Token: 0x04003B33 RID: 15155
		[CompilerGenerated]
		private DataTemplate dataTemplate_5;

		// Token: 0x04003B34 RID: 15156
		[CompilerGenerated]
		private DataTemplate dataTemplate_6;

		// Token: 0x04003B35 RID: 15157
		[CompilerGenerated]
		private DataTemplate dataTemplate_7;

		// Token: 0x04003B36 RID: 15158
		[CompilerGenerated]
		private DataTemplate dataTemplate_8;

		// Token: 0x04003B37 RID: 15159
		[CompilerGenerated]
		private DataTemplate dataTemplate_9;

		// Token: 0x04003B38 RID: 15160
		[CompilerGenerated]
		private DataTemplate dataTemplate_10;

		// Token: 0x04003B39 RID: 15161
		[CompilerGenerated]
		private DataTemplate dataTemplate_11;

		// Token: 0x04003B3A RID: 15162
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
