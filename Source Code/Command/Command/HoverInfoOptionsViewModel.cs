using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using Nini.Config;
using ns14;

namespace Command
{
	// Token: 0x02000DDD RID: 3549
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class HoverInfoOptionsViewModel : INotifyPropertyChanged
	{
		// Token: 0x060066BC RID: 26300 RVA: 0x00040F70 File Offset: 0x0003F170
		private HoverInfoOptionsViewModel()
		{
			this.string_0 = Path.Combine(GameGeneral.string_11, "HoverInfo.ini");
			this.method_1();
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060066BD RID: 26301 RVA: 0x00040F93 File Offset: 0x0003F193
		public static HoverInfoOptionsViewModel Singleton
		{
			get
			{
				return HoverInfoOptionsViewModel.hoverInfoOptionsViewModel_0;
			}
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x00386994 File Offset: 0x00384B94
		private void method_0()
		{
			IniConfigSource iniConfigSource = new IniConfigSource();
			IConfig config = iniConfigSource.AddConfig("HoverInfo");
			foreach (PropertyInfo propertyInfo in typeof(HoverInfoOptionsViewModel).GetProperties(BindingFlags.Instance | BindingFlags.Public))
			{
				DefaultValueAttribute defaultValueAttribute = Enumerable.First<DefaultValueAttribute>(Enumerable.Cast<DefaultValueAttribute>(propertyInfo.GetCustomAttributes(typeof(DefaultValueAttribute), true)));
				config.Set(propertyInfo.Name, RuntimeHelpers.GetObjectValue(defaultValueAttribute.Value));
			}
			iniConfigSource.Save(this.string_0);
		}

		// Token: 0x060066BF RID: 26303 RVA: 0x00386A1C File Offset: 0x00384C1C
		public void method_1()
		{
			try
			{
				if (!File.Exists(this.string_0))
				{
					this.method_0();
				}
				IniConfigSource iniConfigSource = new IniConfigSource(this.string_0);
				foreach (PropertyInfo propertyInfo in typeof(HoverInfoOptionsViewModel).GetProperties(BindingFlags.Instance | BindingFlags.Public))
				{
					string value = iniConfigSource.Configs["HoverInfo"].Get(propertyInfo.Name);
					object objectValue = RuntimeHelpers.GetObjectValue(Enum.Parse(propertyInfo.PropertyType, value));
					propertyInfo.SetValue(this, RuntimeHelpers.GetObjectValue(objectValue), null);
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				this.method_0();
			}
		}

		// Token: 0x060066C0 RID: 26304 RVA: 0x00386AE0 File Offset: 0x00384CE0
		public void Save()
		{
			try
			{
				if (!File.Exists(this.string_0))
				{
					this.method_0();
				}
				IniConfigSource iniConfigSource = new IniConfigSource(this.string_0);
				foreach (PropertyInfo propertyInfo in typeof(HoverInfoOptionsViewModel).GetProperties(BindingFlags.Instance | BindingFlags.Public))
				{
					iniConfigSource.Configs["HoverInfo"].Set(propertyInfo.Name, RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(this, null)));
				}
				iniConfigSource.Save(this.string_0);
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				this.method_0();
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060066C1 RID: 26305 RVA: 0x00040F9A File Offset: 0x0003F19A
		// (set) Token: 0x060066C2 RID: 26306 RVA: 0x00040FA2 File Offset: 0x0003F1A2
		[DefaultValue(1)]
		[Category("Hover Info Settings")]
		[Description("Weapon")]
		[DisplayName("Weapon")]
		public HoverInfoEnableDetailedEnum Weapons
		{
			[CompilerGenerated]
			get
			{
				return this.hoverInfoEnableDetailedEnum_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.hoverInfoEnableDetailedEnum_0 == value)
				{
					return;
				}
				this.hoverInfoEnableDetailedEnum_0 = value;
				this.vmethod_0("Weapons");
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060066C3 RID: 26307 RVA: 0x00040FC2 File Offset: 0x0003F1C2
		// (set) Token: 0x060066C4 RID: 26308 RVA: 0x00040FCA File Offset: 0x0003F1CA
		[DefaultValue(0)]
		[Description("Sensor")]
		[Category("Hover Info Settings")]
		[DisplayName("Sensor")]
		public HoverInfoEnableEnum Sensor
		{
			[CompilerGenerated]
			get
			{
				return this.hoverInfoEnableEnum_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.hoverInfoEnableEnum_0 == value)
				{
					return;
				}
				this.hoverInfoEnableEnum_0 = value;
				this.vmethod_0("Sensor");
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060066C5 RID: 26309 RVA: 0x00040FEA File Offset: 0x0003F1EA
		// (set) Token: 0x060066C6 RID: 26310 RVA: 0x00040FF2 File Offset: 0x0003F1F2
		[DisplayName("Cargo")]
		[Category("Hover Info Settings")]
		[DefaultValue(0)]
		[Description("Cargo")]
		public HoverInfoEnableEnum Cargo
		{
			[CompilerGenerated]
			get
			{
				return this.hoverInfoEnableEnum_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.hoverInfoEnableEnum_1 == value)
				{
					return;
				}
				this.hoverInfoEnableEnum_1 = value;
				this.vmethod_0("Cargo");
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060066C7 RID: 26311 RVA: 0x00041012 File Offset: 0x0003F212
		// (set) Token: 0x060066C8 RID: 26312 RVA: 0x0004101A File Offset: 0x0003F21A
		[DisplayName("Damage")]
		[Description("Damage")]
		[Category("Hover Info Settings")]
		[DefaultValue(0)]
		public HoverInfoEnableEnum Damage
		{
			[CompilerGenerated]
			get
			{
				return this.hoverInfoEnableEnum_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.hoverInfoEnableEnum_2 == value)
				{
					return;
				}
				this.hoverInfoEnableEnum_2 = value;
				this.vmethod_0("Damage");
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x060066C9 RID: 26313 RVA: 0x0004103A File Offset: 0x0003F23A
		// (set) Token: 0x060066CA RID: 26314 RVA: 0x00041042 File Offset: 0x0003F242
		[DisplayName("Landed Aircraft")]
		[Category("Hover Info Settings")]
		[DefaultValue(0)]
		[Description("Aircraft landed on carrier/airbase")]
		public HoverInfoEnableEnum AirParasite
		{
			[CompilerGenerated]
			get
			{
				return this.hoverInfoEnableEnum_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.hoverInfoEnableEnum_3 == value)
				{
					return;
				}
				this.hoverInfoEnableEnum_3 = value;
				this.vmethod_0("AirParasite");
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060066CB RID: 26315 RVA: 0x00041062 File Offset: 0x0003F262
		// (set) Token: 0x060066CC RID: 26316 RVA: 0x0004106A File Offset: 0x0003F26A
		[DisplayName("Docked Boats")]
		[DefaultValue(0)]
		[Description("Boats docked to mothership")]
		[Category("Hover Info Settings")]
		public HoverInfoEnableEnum BoatParasite
		{
			[CompilerGenerated]
			get
			{
				return this.hoverInfoEnableEnum_4;
			}
			[CompilerGenerated]
			set
			{
				if (this.hoverInfoEnableEnum_4 == value)
				{
					return;
				}
				this.hoverInfoEnableEnum_4 = value;
				this.vmethod_0("BoatParasite");
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060066CD RID: 26317 RVA: 0x0004108A File Offset: 0x0003F28A
		// (set) Token: 0x060066CE RID: 26318 RVA: 0x00041092 File Offset: 0x0003F292
		[Category("Hover Info Settings")]
		[DefaultValue(1)]
		[DisplayName("Fuel Information")]
		[Description("Fuel Information")]
		public HoverInfoEnableDetailedEnum Fuel
		{
			[CompilerGenerated]
			get
			{
				return this.hoverInfoEnableDetailedEnum_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.hoverInfoEnableDetailedEnum_1 == value)
				{
					return;
				}
				this.hoverInfoEnableDetailedEnum_1 = value;
				this.vmethod_0("Fuel");
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060066CF RID: 26319 RVA: 0x000410B2 File Offset: 0x0003F2B2
		// (set) Token: 0x060066D0 RID: 26320 RVA: 0x000410BA File Offset: 0x0003F2BA
		[DefaultValue(0)]
		[Category("Hover Info Settings")]
		[Description("Mission Information")]
		[DisplayName("Mission Information")]
		public HoverInfoEnableEnum Mission
		{
			[CompilerGenerated]
			get
			{
				return this.hoverInfoEnableEnum_5;
			}
			[CompilerGenerated]
			set
			{
				if (this.hoverInfoEnableEnum_5 == value)
				{
					return;
				}
				this.hoverInfoEnableEnum_5 = value;
				this.vmethod_0("Mission");
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060066D1 RID: 26321 RVA: 0x000410DA File Offset: 0x0003F2DA
		// (set) Token: 0x060066D2 RID: 26322 RVA: 0x000410E2 File Offset: 0x0003F2E2
		[DefaultValue(0)]
		[DisplayName("Vehicle Information")]
		[Category("Hover Info Settings")]
		[Description("Ground unit vehicles")]
		public HoverInfoEnableEnum Vehicles
		{
			[CompilerGenerated]
			get
			{
				return this.hoverInfoEnableEnum_6;
			}
			[CompilerGenerated]
			set
			{
				if (this.hoverInfoEnableEnum_6 == value)
				{
					return;
				}
				this.hoverInfoEnableEnum_6 = value;
				this.vmethod_0("Vehicles");
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060066D3 RID: 26323 RVA: 0x00041102 File Offset: 0x0003F302
		// (set) Token: 0x060066D4 RID: 26324 RVA: 0x0004110A File Offset: 0x0003F30A
		[Description("Group Members")]
		[Category("Hover Info Settings")]
		[DefaultValue(0)]
		[DisplayName("Group Members")]
		public HoverInfoEnableEnum GroupMembers
		{
			[CompilerGenerated]
			get
			{
				return this.hoverInfoEnableEnum_7;
			}
			[CompilerGenerated]
			set
			{
				if (this.hoverInfoEnableEnum_7 == value)
				{
					return;
				}
				this.hoverInfoEnableEnum_7 = value;
				this.vmethod_0("GroupMembers");
			}
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x060066D5 RID: 26325 RVA: 0x00386B98 File Offset: 0x00384D98
		// (remove) Token: 0x060066D6 RID: 26326 RVA: 0x00386BD0 File Offset: 0x00384DD0
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

		// Token: 0x060066D7 RID: 26327 RVA: 0x00386C08 File Offset: 0x00384E08
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003A96 RID: 14998
		private string string_0;

		// Token: 0x04003A97 RID: 14999
		private static HoverInfoOptionsViewModel hoverInfoOptionsViewModel_0 = new HoverInfoOptionsViewModel();

		// Token: 0x04003A98 RID: 15000
		[CompilerGenerated]
		private HoverInfoEnableDetailedEnum hoverInfoEnableDetailedEnum_0;

		// Token: 0x04003A99 RID: 15001
		[CompilerGenerated]
		private HoverInfoEnableEnum hoverInfoEnableEnum_0;

		// Token: 0x04003A9A RID: 15002
		[CompilerGenerated]
		private HoverInfoEnableEnum hoverInfoEnableEnum_1;

		// Token: 0x04003A9B RID: 15003
		[CompilerGenerated]
		private HoverInfoEnableEnum hoverInfoEnableEnum_2;

		// Token: 0x04003A9C RID: 15004
		[CompilerGenerated]
		private HoverInfoEnableEnum hoverInfoEnableEnum_3;

		// Token: 0x04003A9D RID: 15005
		[CompilerGenerated]
		private HoverInfoEnableEnum hoverInfoEnableEnum_4;

		// Token: 0x04003A9E RID: 15006
		[CompilerGenerated]
		private HoverInfoEnableDetailedEnum hoverInfoEnableDetailedEnum_1;

		// Token: 0x04003A9F RID: 15007
		[CompilerGenerated]
		private HoverInfoEnableEnum hoverInfoEnableEnum_5;

		// Token: 0x04003AA0 RID: 15008
		[CompilerGenerated]
		private HoverInfoEnableEnum hoverInfoEnableEnum_6;

		// Token: 0x04003AA1 RID: 15009
		[CompilerGenerated]
		private HoverInfoEnableEnum hoverInfoEnableEnum_7;

		// Token: 0x04003AA2 RID: 15010
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
