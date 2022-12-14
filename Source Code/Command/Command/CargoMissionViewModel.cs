using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic;
using ns11;
using ns14;
using ns7;

namespace Command
{
	// Token: 0x02000DA2 RID: 3490
	[Attribute2]
	[Attribute3]
	[Attribute0]
	public sealed class CargoMissionViewModel : INotifyPropertyChanged
	{
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06005DD6 RID: 24022 RVA: 0x0003C6E8 File Offset: 0x0003A8E8
		// (set) Token: 0x06005DD7 RID: 24023 RVA: 0x0003C6F0 File Offset: 0x0003A8F0
		public ObservableCollection<CargoMissionAssignedUnitViewModel> AssignedUnits
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
				this.vmethod_0("AssignedUnits");
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06005DD8 RID: 24024 RVA: 0x0003C710 File Offset: 0x0003A910
		// (set) Token: 0x06005DD9 RID: 24025 RVA: 0x0003C718 File Offset: 0x0003A918
		public ObservableCollection<CargoMissionMothershipUnitViewModel> Motherships
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
				this.vmethod_0("Motherships");
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06005DDA RID: 24026 RVA: 0x0003C738 File Offset: 0x0003A938
		// (set) Token: 0x06005DDB RID: 24027 RVA: 0x0003C740 File Offset: 0x0003A940
		public ObservableCollection<string> Issues
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_2;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_2 == value)
				{
					return;
				}
				this.observableCollection_2 = value;
				this.vmethod_0("Issues");
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06005DDC RID: 24028 RVA: 0x0003C760 File Offset: 0x0003A960
		// (set) Token: 0x06005DDD RID: 24029 RVA: 0x0003C768 File Offset: 0x0003A968
		public ObservableCollection<CargoMissionMothershipCargoMountViewModel> Mounts
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_3;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_3 == value)
				{
					return;
				}
				this.observableCollection_3 = value;
				this.vmethod_0("Mounts");
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06005DDE RID: 24030 RVA: 0x0003C788 File Offset: 0x0003A988
		// (set) Token: 0x06005DDF RID: 24031 RVA: 0x0003C790 File Offset: 0x0003A990
		public CargoMissionMothershipCargoMountViewModel SelectedMount
		{
			[CompilerGenerated]
			get
			{
				return this.cargoMissionMothershipCargoMountViewModel_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.cargoMissionMothershipCargoMountViewModel_0 == value)
				{
					return;
				}
				this.cargoMissionMothershipCargoMountViewModel_0 = value;
				this.vmethod_0("SelectedMount");
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06005DE0 RID: 24032 RVA: 0x0003C7B0 File Offset: 0x0003A9B0
		public string Units
		{
			get
			{
				if (!Class570.class280_0.method_12())
				{
					return "m";
				}
				return "ft";
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06005DE1 RID: 24033 RVA: 0x0003C7C9 File Offset: 0x0003A9C9
		// (set) Token: 0x06005DE2 RID: 24034 RVA: 0x0003C7F4 File Offset: 0x0003A9F4
		public float TransitAltitude_Aircraft
		{
			get
			{
				if (!Class570.class280_0.method_12())
				{
					return this.class338_0.float_0;
				}
				return 3.28084f * this.class338_0.float_0;
			}
			set
			{
				if (this.TransitAltitude_Aircraft == value)
				{
					return;
				}
				this.class338_0.float_0 = (Class570.class280_0.method_12() ? (value / 3.28084f) : value);
				this.vmethod_0("TransitAltitude_Aircraft");
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06005DE3 RID: 24035 RVA: 0x0003C831 File Offset: 0x0003AA31
		// (set) Token: 0x06005DE4 RID: 24036 RVA: 0x0003C85C File Offset: 0x0003AA5C
		public float StationAltitude_Aircraft
		{
			get
			{
				if (!Class570.class280_0.method_12())
				{
					return this.class338_0.float_1;
				}
				return 3.28084f * this.class338_0.float_1;
			}
			set
			{
				if (this.StationAltitude_Aircraft == value)
				{
					return;
				}
				this.class338_0.float_1 = (Class570.class280_0.method_12() ? (value / 3.28084f) : value);
				this.vmethod_0("StationAltitude_Aircraft");
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06005DE5 RID: 24037 RVA: 0x0003C899 File Offset: 0x0003AA99
		// (set) Token: 0x06005DE6 RID: 24038 RVA: 0x0003C8A8 File Offset: 0x0003AAA8
		public int TransitThrottle_Aircraft
		{
			get
			{
				return (int)(this.class338_0.throttle_0 - ActiveUnit.Throttle.Loiter);
			}
			set
			{
				if (this.TransitThrottle_Aircraft == value)
				{
					return;
				}
				this.class338_0.throttle_0 = (ActiveUnit.Throttle)(value + 1);
				this.vmethod_0("TransitThrottle_Aircraft");
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06005DE7 RID: 24039 RVA: 0x0003C8D0 File Offset: 0x0003AAD0
		// (set) Token: 0x06005DE8 RID: 24040 RVA: 0x0003C8DF File Offset: 0x0003AADF
		public int StationThrottle_Aircraft
		{
			get
			{
				return (int)(this.class338_0.throttle_1 - ActiveUnit.Throttle.Loiter);
			}
			set
			{
				if (this.StationThrottle_Aircraft == value)
				{
					return;
				}
				this.class338_0.throttle_1 = (ActiveUnit.Throttle)(value + 1);
				this.vmethod_0("StationThrottle_Aircraft");
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06005DE9 RID: 24041 RVA: 0x0003C907 File Offset: 0x0003AB07
		// (set) Token: 0x06005DEA RID: 24042 RVA: 0x0003C916 File Offset: 0x0003AB16
		public int TransitThrottle_Ship
		{
			get
			{
				return (int)(this.class338_0.throttle_2 - ActiveUnit.Throttle.Loiter);
			}
			set
			{
				if (this.TransitThrottle_Ship == value)
				{
					return;
				}
				this.class338_0.throttle_2 = (ActiveUnit.Throttle)(value + 1);
				this.vmethod_0("TransitThrottle_Ship");
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06005DEB RID: 24043 RVA: 0x0003C93E File Offset: 0x0003AB3E
		// (set) Token: 0x06005DEC RID: 24044 RVA: 0x0003C94D File Offset: 0x0003AB4D
		public int StationThrottle_Ship
		{
			get
			{
				return (int)(this.class338_0.throttle_3 - ActiveUnit.Throttle.Loiter);
			}
			set
			{
				if (this.StationThrottle_Ship == value)
				{
					return;
				}
				this.class338_0.throttle_3 = (ActiveUnit.Throttle)(value + 1);
				this.vmethod_0("StationThrottle_Ship");
			}
		}

		// Token: 0x06005DED RID: 24045 RVA: 0x003311DC File Offset: 0x0032F3DC
		public CargoMissionViewModel(Class338 theMission)
		{
			this.AssignedUnits = new ObservableCollection<CargoMissionAssignedUnitViewModel>();
			this.Motherships = new ObservableCollection<CargoMissionMothershipUnitViewModel>();
			this.Issues = new ObservableCollection<string>();
			this.Mounts = new ObservableCollection<CargoMissionMothershipCargoMountViewModel>();
			this.MountUnloadAllCommand = new Class2569(new Action<object>(this.method_8));
			this.MountUnloadOneCommand = new Class2569(new Action<object>(this.method_9));
			this.MountLoadOneCommand = new Class2569(new Action<object>(this.method_10));
			this.MountLoadAllCommand = new Class2569(new Action<object>(this.method_11));
			this.class338_0 = theMission;
			try
			{
				foreach (KeyValuePair<int, int> keyValuePair in theMission.dictionary_0)
				{
					CargoMissionMothershipCargoMountViewModel cargoMissionMothershipCargoMountViewModel = new CargoMissionMothershipCargoMountViewModel(keyValuePair.Key);
					cargoMissionMothershipCargoMountViewModel.ToUnload = keyValuePair.Value;
					this.Mounts.Add(cargoMissionMothershipCargoMountViewModel);
				}
			}
			finally
			{
				Dictionary<int, int>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (ActiveUnit theUnit in theMission.method_15(Client.smethod_46()))
				{
					this.method_2(theUnit);
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			this.method_0();
		}

		// Token: 0x06005DEE RID: 24046 RVA: 0x00331334 File Offset: 0x0032F534
		private void method_0()
		{
			this.Issues.Clear();
			if (this.AssignedUnits.Count == 0)
			{
				this.Issues.Add("Zero units in mission");
			}
			if (Enumerable.Any<Ship>(Enumerable.OfType<Ship>(Enumerable.Select<CargoMissionAssignedUnitViewModel, ActiveUnit>(this.AssignedUnits, (CargoMissionViewModel._Closure$__.$I42-0 == null) ? (CargoMissionViewModel._Closure$__.$I42-0 = new Func<CargoMissionAssignedUnitViewModel, ActiveUnit>(CargoMissionViewModel._Closure$__.$I.method_0)) : CargoMissionViewModel._Closure$__.$I42-0)), (CargoMissionViewModel._Closure$__.$I42-1 == null) ? (CargoMissionViewModel._Closure$__.$I42-1 = new Func<Ship, bool>(CargoMissionViewModel._Closure$__.$I.method_1)) : CargoMissionViewModel._Closure$__.$I42-1))
			{
				this.Issues.Add("A ship has been added that is unable to take cargo. Please only add cargo carrying ships to this mission.");
			}
			if (Enumerable.Any<Aircraft>(Enumerable.OfType<Aircraft>(Enumerable.Select<CargoMissionAssignedUnitViewModel, ActiveUnit>(this.AssignedUnits, (CargoMissionViewModel._Closure$__.$I42-2 == null) ? (CargoMissionViewModel._Closure$__.$I42-2 = new Func<CargoMissionAssignedUnitViewModel, ActiveUnit>(CargoMissionViewModel._Closure$__.$I.method_2)) : CargoMissionViewModel._Closure$__.$I42-2)), (CargoMissionViewModel._Closure$__.$I42-3 == null) ? (CargoMissionViewModel._Closure$__.$I42-3 = new Func<Aircraft, bool>(CargoMissionViewModel._Closure$__.$I.method_3)) : CargoMissionViewModel._Closure$__.$I42-3))
			{
				this.Issues.Add("A aircraft has been added that is unable to take cargo with its current loadout.");
			}
			if (!this.class338_0.method_12())
			{
				this.Issues.Add("The mission is currently inactive.");
			}
			this.Motherships.Clear();
			try
			{
				foreach (Ship ship in Enumerable.Where<Ship>(Enumerable.OfType<Ship>(Enumerable.Select<CargoMissionAssignedUnitViewModel, ActiveUnit>(this.AssignedUnits, (CargoMissionViewModel._Closure$__.$I42-4 == null) ? (CargoMissionViewModel._Closure$__.$I42-4 = new Func<CargoMissionAssignedUnitViewModel, ActiveUnit>(CargoMissionViewModel._Closure$__.$I.method_4)) : CargoMissionViewModel._Closure$__.$I42-4)), (CargoMissionViewModel._Closure$__.$I42-5 == null) ? (CargoMissionViewModel._Closure$__.$I42-5 = new Func<Ship, bool>(CargoMissionViewModel._Closure$__.$I.method_5)) : CargoMissionViewModel._Closure$__.$I42-5))
				{
					CargoMissionViewModel.Class2429 @class = new CargoMissionViewModel.Class2429(@class);
					@class.activeUnit_0 = ship.vmethod_93().method_11(false);
					if (@class.activeUnit_0 != null && !Enumerable.Any<CargoMissionMothershipUnitViewModel>(this.Motherships, new Func<CargoMissionMothershipUnitViewModel, bool>(@class.method_0)))
					{
						this.Motherships.Add(new CargoMissionMothershipUnitViewModel(@class.activeUnit_0));
					}
				}
			}
			finally
			{
				IEnumerator<Ship> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				foreach (Aircraft aircraft in Enumerable.Where<Aircraft>(Enumerable.OfType<Aircraft>(Enumerable.Select<CargoMissionAssignedUnitViewModel, ActiveUnit>(this.AssignedUnits, (CargoMissionViewModel._Closure$__.$I42-7 == null) ? (CargoMissionViewModel._Closure$__.$I42-7 = new Func<CargoMissionAssignedUnitViewModel, ActiveUnit>(CargoMissionViewModel._Closure$__.$I.method_6)) : CargoMissionViewModel._Closure$__.$I42-7)), (CargoMissionViewModel._Closure$__.$I42-8 == null) ? (CargoMissionViewModel._Closure$__.$I42-8 = new Func<Aircraft, bool>(CargoMissionViewModel._Closure$__.$I.method_7)) : CargoMissionViewModel._Closure$__.$I42-8))
				{
					CargoMissionViewModel.Class2430 class2 = new CargoMissionViewModel.Class2430(class2);
					class2.activeUnit_0 = aircraft.method_164().method_32(false);
					if (class2.activeUnit_0 != null && !Enumerable.Any<CargoMissionMothershipUnitViewModel>(this.Motherships, new Func<CargoMissionMothershipUnitViewModel, bool>(class2.method_0)))
					{
						this.Motherships.Add(new CargoMissionMothershipUnitViewModel(class2.activeUnit_0));
					}
				}
			}
			finally
			{
				IEnumerator<Aircraft> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			try
			{
				foreach (CargoMissionMothershipCargoMountViewModel cargoMissionMothershipCargoMountViewModel in this.Mounts)
				{
					cargoMissionMothershipCargoMountViewModel.Available = 0;
				}
			}
			finally
			{
				IEnumerator<CargoMissionMothershipCargoMountViewModel> enumerator3;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
			}
			try
			{
				foreach (CargoMissionMothershipUnitViewModel cargoMissionMothershipUnitViewModel in this.Motherships)
				{
					if (cargoMissionMothershipUnitViewModel.activeUnit_0 is Group)
					{
						try
						{
							foreach (KeyValuePair<string, ActiveUnit> keyValuePair in ((Group)cargoMissionMothershipUnitViewModel.activeUnit_0).vmethod_141())
							{
								try
								{
									foreach (Cargo cargo in Enumerable.Where<Cargo>(keyValuePair.Value.cargo_0, (CargoMissionViewModel._Closure$__.$I42-10 == null) ? (CargoMissionViewModel._Closure$__.$I42-10 = new Func<Cargo, bool>(CargoMissionViewModel._Closure$__.$I.method_8)) : CargoMissionViewModel._Closure$__.$I42-10))
									{
										CargoMissionViewModel.Class2431 class3 = new CargoMissionViewModel.Class2431(class3);
										class3.mount_0 = (Mount)cargo.method_25();
										CargoMissionMothershipCargoMountViewModel cargoMissionMothershipCargoMountViewModel2 = Enumerable.FirstOrDefault<CargoMissionMothershipCargoMountViewModel>(this.Mounts, new Func<CargoMissionMothershipCargoMountViewModel, bool>(class3.method_0));
										if (cargoMissionMothershipCargoMountViewModel2 == null)
										{
											cargoMissionMothershipCargoMountViewModel2 = new CargoMissionMothershipCargoMountViewModel(class3.mount_0.DBID);
											this.Mounts.Add(cargoMissionMothershipCargoMountViewModel2);
										}
										CargoMissionMothershipCargoMountViewModel cargoMissionMothershipCargoMountViewModel3;
										(cargoMissionMothershipCargoMountViewModel3 = cargoMissionMothershipCargoMountViewModel2).Available = cargoMissionMothershipCargoMountViewModel3.Available + 1;
										if (cargoMissionMothershipCargoMountViewModel2.Available > 0)
										{
											bool flag = false;
											try
											{
												foreach (Ship ship2 in Enumerable.Where<Ship>(Enumerable.OfType<Ship>(Enumerable.Select<CargoMissionAssignedUnitViewModel, ActiveUnit>(this.AssignedUnits, (CargoMissionViewModel._Closure$__.$I42-12 == null) ? (CargoMissionViewModel._Closure$__.$I42-12 = new Func<CargoMissionAssignedUnitViewModel, ActiveUnit>(CargoMissionViewModel._Closure$__.$I.method_9)) : CargoMissionViewModel._Closure$__.$I42-12)), (class3.func_0 == null) ? (class3.func_0 = new Func<Ship, bool>(class3.method_1)) : class3.func_0))
												{
													flag = true;
												}
											}
											finally
											{
												IEnumerator<Ship> enumerator7;
												if (enumerator7 != null)
												{
													enumerator7.Dispose();
												}
											}
											try
											{
												foreach (Aircraft aircraft2 in Enumerable.Where<Aircraft>(Enumerable.OfType<Aircraft>(Enumerable.Select<CargoMissionAssignedUnitViewModel, ActiveUnit>(this.AssignedUnits, (CargoMissionViewModel._Closure$__.$I42-14 == null) ? (CargoMissionViewModel._Closure$__.$I42-14 = new Func<CargoMissionAssignedUnitViewModel, ActiveUnit>(CargoMissionViewModel._Closure$__.$I.method_10)) : CargoMissionViewModel._Closure$__.$I42-14)), (class3.func_1 == null) ? (class3.func_1 = new Func<Aircraft, bool>(class3.method_2)) : class3.func_1))
												{
													flag = true;
												}
											}
											finally
											{
												IEnumerator<Aircraft> enumerator8;
												if (enumerator8 != null)
												{
													enumerator8.Dispose();
												}
											}
											if (!flag)
											{
												cargoMissionMothershipCargoMountViewModel2.canMove = false;
											}
											else
											{
												cargoMissionMothershipCargoMountViewModel2.canMove = true;
											}
										}
									}
								}
								finally
								{
									IEnumerator<Cargo> enumerator6;
									if (enumerator6 != null)
									{
										enumerator6.Dispose();
									}
								}
							}
							continue;
						}
						finally
						{
							IEnumerator<KeyValuePair<string, ActiveUnit>> enumerator5;
							if (enumerator5 != null)
							{
								enumerator5.Dispose();
							}
						}
					}
					try
					{
						foreach (Cargo cargo2 in Enumerable.Where<Cargo>(cargoMissionMothershipUnitViewModel.activeUnit_0.cargo_0, (CargoMissionViewModel._Closure$__.$I42-16 == null) ? (CargoMissionViewModel._Closure$__.$I42-16 = new Func<Cargo, bool>(CargoMissionViewModel._Closure$__.$I.method_11)) : CargoMissionViewModel._Closure$__.$I42-16))
						{
							CargoMissionViewModel.Class2432 class4 = new CargoMissionViewModel.Class2432(class4);
							class4.mount_0 = (Mount)cargo2.method_25();
							CargoMissionMothershipCargoMountViewModel cargoMissionMothershipCargoMountViewModel4 = Enumerable.FirstOrDefault<CargoMissionMothershipCargoMountViewModel>(this.Mounts, new Func<CargoMissionMothershipCargoMountViewModel, bool>(class4.method_0));
							if (cargoMissionMothershipCargoMountViewModel4 == null)
							{
								cargoMissionMothershipCargoMountViewModel4 = new CargoMissionMothershipCargoMountViewModel(class4.mount_0.DBID);
								this.Mounts.Add(cargoMissionMothershipCargoMountViewModel4);
							}
							CargoMissionMothershipCargoMountViewModel cargoMissionMothershipCargoMountViewModel3;
							(cargoMissionMothershipCargoMountViewModel3 = cargoMissionMothershipCargoMountViewModel4).Available = cargoMissionMothershipCargoMountViewModel3.Available + 1;
							if (cargoMissionMothershipCargoMountViewModel4.Available > 0)
							{
								bool flag2 = false;
								try
								{
									foreach (Ship ship3 in Enumerable.Where<Ship>(Enumerable.OfType<Ship>(Enumerable.Select<CargoMissionAssignedUnitViewModel, ActiveUnit>(this.AssignedUnits, (CargoMissionViewModel._Closure$__.$I42-18 == null) ? (CargoMissionViewModel._Closure$__.$I42-18 = new Func<CargoMissionAssignedUnitViewModel, ActiveUnit>(CargoMissionViewModel._Closure$__.$I.method_12)) : CargoMissionViewModel._Closure$__.$I42-18)), (class4.func_0 == null) ? (class4.func_0 = new Func<Ship, bool>(class4.method_1)) : class4.func_0))
									{
										flag2 = true;
									}
								}
								finally
								{
									IEnumerator<Ship> enumerator10;
									if (enumerator10 != null)
									{
										enumerator10.Dispose();
									}
								}
								try
								{
									foreach (Aircraft aircraft3 in Enumerable.Where<Aircraft>(Enumerable.OfType<Aircraft>(Enumerable.Select<CargoMissionAssignedUnitViewModel, ActiveUnit>(this.AssignedUnits, (CargoMissionViewModel._Closure$__.$I42-20 == null) ? (CargoMissionViewModel._Closure$__.$I42-20 = new Func<CargoMissionAssignedUnitViewModel, ActiveUnit>(CargoMissionViewModel._Closure$__.$I.method_13)) : CargoMissionViewModel._Closure$__.$I42-20)), (class4.func_1 == null) ? (class4.func_1 = new Func<Aircraft, bool>(class4.method_2)) : class4.func_1))
									{
										flag2 = true;
									}
								}
								finally
								{
									IEnumerator<Aircraft> enumerator11;
									if (enumerator11 != null)
									{
										enumerator11.Dispose();
									}
								}
								if (!flag2)
								{
									cargoMissionMothershipCargoMountViewModel4.canMove = false;
								}
								else
								{
									cargoMissionMothershipCargoMountViewModel4.canMove = true;
								}
							}
						}
					}
					finally
					{
						IEnumerator<Cargo> enumerator9;
						if (enumerator9 != null)
						{
							enumerator9.Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator<CargoMissionMothershipUnitViewModel> enumerator4;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
				}
			}
			try
			{
				IEnumerator<Ship> enumerator12 = Enumerable.OfType<Ship>(Enumerable.Select<CargoMissionAssignedUnitViewModel, ActiveUnit>(this.AssignedUnits, (CargoMissionViewModel._Closure$__.$I42-22 == null) ? (CargoMissionViewModel._Closure$__.$I42-22 = new Func<CargoMissionAssignedUnitViewModel, ActiveUnit>(CargoMissionViewModel._Closure$__.$I.method_14)) : CargoMissionViewModel._Closure$__.$I42-22)).GetEnumerator();
				while (enumerator12.MoveNext())
				{
					CargoMissionViewModel.Class2433 class5 = new CargoMissionViewModel.Class2433(class5);
					class5.ship_0 = enumerator12.Current;
					class5.ship_0.vmethod_93();
					if (Enumerable.Count<Cargo>(class5.ship_0.cargo_0) > 0 && !Information.IsNothing(class5.ship_0.vmethod_93().method_11(false)))
					{
						float num = class5.ship_0.method_146().vmethod_26() / 2f;
						float num2 = Enumerable.Average(Enumerable.Select<ReferencePoint, float>(((Class338)class5.ship_0.vmethod_101()).list_5, new Func<ReferencePoint, float>(class5.method_0)));
						if ((double)num2 >= (double)num * 0.75)
						{
							this.Issues.Add(string.Concat(new string[]
							{
								"Boat ",
								class5.ship_0.Name,
								" too far from destination area by ",
								string.Format("{0:0.0}", Math.Abs((double)num * 0.75 - (double)num2)),
								"NM  to launch."
							}));
						}
					}
				}
			}
			finally
			{
				IEnumerator<Ship> enumerator12;
				if (enumerator12 != null)
				{
					enumerator12.Dispose();
				}
			}
			try
			{
				foreach (CargoMissionMothershipCargoMountViewModel cargoMissionMothershipCargoMountViewModel5 in this.Mounts)
				{
					if (cargoMissionMothershipCargoMountViewModel5.Available > 0 && !cargoMissionMothershipCargoMountViewModel5.canMove)
					{
						this.Issues.Add("No assigned unit can carry " + cargoMissionMothershipCargoMountViewModel5.Name + ".");
					}
				}
			}
			finally
			{
				IEnumerator<CargoMissionMothershipCargoMountViewModel> enumerator13;
				if (enumerator13 != null)
				{
					enumerator13.Dispose();
				}
			}
		}

		// Token: 0x06005DEF RID: 24047 RVA: 0x00331E14 File Offset: 0x00330014
		public void method_1(ActiveUnit theUnit)
		{
			CargoMissionViewModel.Class2434 @class = new CargoMissionViewModel.Class2434(@class);
			@class.activeUnit_0 = theUnit;
			bool flag = false;
			foreach (CargoMissionAssignedUnitViewModel item in Enumerable.ToArray<CargoMissionAssignedUnitViewModel>(Enumerable.Where<CargoMissionAssignedUnitViewModel>(this.AssignedUnits, (@class.func_0 == null) ? (@class.func_0 = new Func<CargoMissionAssignedUnitViewModel, bool>(@class.method_0)) : @class.func_0)))
			{
				this.AssignedUnits.Remove(item);
				flag = true;
			}
			if (flag)
			{
				this.method_0();
			}
		}

		// Token: 0x06005DF0 RID: 24048 RVA: 0x00331E98 File Offset: 0x00330098
		public void method_2(ActiveUnit theUnit)
		{
			CargoMissionViewModel.Class2435 @class = new CargoMissionViewModel.Class2435();
			@class.activeUnit_0 = theUnit;
			bool flag = false;
			if (!Enumerable.Any<CargoMissionAssignedUnitViewModel>(this.AssignedUnits, new Func<CargoMissionAssignedUnitViewModel, bool>(@class.method_0)))
			{
				this.AssignedUnits.Add(new CargoMissionAssignedUnitViewModel(@class.activeUnit_0));
				flag = true;
			}
			if (flag)
			{
				this.method_0();
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06005DF1 RID: 24049 RVA: 0x0003C975 File Offset: 0x0003AB75
		// (set) Token: 0x06005DF2 RID: 24050 RVA: 0x0003C97D File Offset: 0x0003AB7D
		public Class2569 MountUnloadAllCommand
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
				this.vmethod_0("MountUnloadAllCommand");
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06005DF3 RID: 24051 RVA: 0x0003C99D File Offset: 0x0003AB9D
		// (set) Token: 0x06005DF4 RID: 24052 RVA: 0x0003C9A5 File Offset: 0x0003ABA5
		public Class2569 MountUnloadOneCommand
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
				this.vmethod_0("MountUnloadOneCommand");
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06005DF5 RID: 24053 RVA: 0x0003C9C5 File Offset: 0x0003ABC5
		// (set) Token: 0x06005DF6 RID: 24054 RVA: 0x0003C9CD File Offset: 0x0003ABCD
		public Class2569 MountLoadOneCommand
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
				this.vmethod_0("MountLoadOneCommand");
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06005DF7 RID: 24055 RVA: 0x0003C9ED File Offset: 0x0003ABED
		// (set) Token: 0x06005DF8 RID: 24056 RVA: 0x0003C9F5 File Offset: 0x0003ABF5
		public Class2569 MountLoadAllCommand
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
				this.vmethod_0("MountLoadAllCommand");
			}
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x0003CA15 File Offset: 0x0003AC15
		public void method_3()
		{
			if (this.SelectedMount != null)
			{
				this.SelectedMount.ToUnload = 0;
				this.method_7();
			}
		}

		// Token: 0x06005DFA RID: 24058 RVA: 0x00331EF0 File Offset: 0x003300F0
		public void method_4()
		{
			if (this.SelectedMount != null)
			{
				CargoMissionMothershipCargoMountViewModel selectedMount;
				(selectedMount = this.SelectedMount).ToUnload = selectedMount.ToUnload - 1;
				if (this.SelectedMount.ToUnload < 0)
				{
					this.SelectedMount.ToUnload = 0;
				}
				this.method_7();
			}
		}

		// Token: 0x06005DFB RID: 24059 RVA: 0x00331F3C File Offset: 0x0033013C
		public void method_5()
		{
			if (this.SelectedMount != null)
			{
				CargoMissionMothershipCargoMountViewModel selectedMount;
				(selectedMount = this.SelectedMount).ToUnload = selectedMount.ToUnload + 1;
				if (this.SelectedMount.ToUnload > this.SelectedMount.Available)
				{
					this.SelectedMount.ToUnload = this.SelectedMount.Available;
				}
				this.method_7();
			}
		}

		// Token: 0x06005DFC RID: 24060 RVA: 0x0003CA31 File Offset: 0x0003AC31
		public void method_6()
		{
			if (this.SelectedMount != null)
			{
				this.SelectedMount.ToUnload = this.SelectedMount.Available;
				this.method_7();
			}
		}

		// Token: 0x06005DFD RID: 24061 RVA: 0x00331F9C File Offset: 0x0033019C
		private void method_7()
		{
			this.class338_0.dictionary_0.Clear();
			try
			{
				foreach (CargoMissionMothershipCargoMountViewModel cargoMissionMothershipCargoMountViewModel in this.Mounts)
				{
					this.class338_0.dictionary_0[cargoMissionMothershipCargoMountViewModel.DBID] = cargoMissionMothershipCargoMountViewModel.ToUnload;
				}
			}
			finally
			{
				IEnumerator<CargoMissionMothershipCargoMountViewModel> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x0003CA57 File Offset: 0x0003AC57
		[CompilerGenerated]
		private void method_8(object a0)
		{
			this.method_3();
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x0003CA5F File Offset: 0x0003AC5F
		[CompilerGenerated]
		private void method_9(object a0)
		{
			this.method_4();
		}

		// Token: 0x06005E00 RID: 24064 RVA: 0x0003CA67 File Offset: 0x0003AC67
		[CompilerGenerated]
		private void method_10(object a0)
		{
			this.method_5();
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x0003CA6F File Offset: 0x0003AC6F
		[CompilerGenerated]
		private void method_11(object a0)
		{
			this.method_6();
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06005E02 RID: 24066 RVA: 0x00332010 File Offset: 0x00330210
		// (remove) Token: 0x06005E03 RID: 24067 RVA: 0x00332048 File Offset: 0x00330248
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

		// Token: 0x06005E04 RID: 24068 RVA: 0x00332080 File Offset: 0x00330280
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003684 RID: 13956
		public Class338 class338_0;

		// Token: 0x04003685 RID: 13957
		[CompilerGenerated]
		private ObservableCollection<CargoMissionAssignedUnitViewModel> observableCollection_0;

		// Token: 0x04003686 RID: 13958
		[CompilerGenerated]
		private ObservableCollection<CargoMissionMothershipUnitViewModel> observableCollection_1;

		// Token: 0x04003687 RID: 13959
		[CompilerGenerated]
		private ObservableCollection<string> observableCollection_2;

		// Token: 0x04003688 RID: 13960
		[CompilerGenerated]
		private ObservableCollection<CargoMissionMothershipCargoMountViewModel> observableCollection_3;

		// Token: 0x04003689 RID: 13961
		[CompilerGenerated]
		private CargoMissionMothershipCargoMountViewModel cargoMissionMothershipCargoMountViewModel_0;

		// Token: 0x0400368A RID: 13962
		[CompilerGenerated]
		private Class2569 class2569_0;

		// Token: 0x0400368B RID: 13963
		[CompilerGenerated]
		private Class2569 class2569_1;

		// Token: 0x0400368C RID: 13964
		[CompilerGenerated]
		private Class2569 class2569_2;

		// Token: 0x0400368D RID: 13965
		[CompilerGenerated]
		private Class2569 class2569_3;

		// Token: 0x0400368E RID: 13966
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x02000DA3 RID: 3491
		[CompilerGenerated]
		internal sealed class Class2429
		{
			// Token: 0x06005E05 RID: 24069 RVA: 0x0003CA77 File Offset: 0x0003AC77
			public Class2429(CargoMissionViewModel.Class2429 arg0)
			{
				if (arg0 != null)
				{
					this.activeUnit_0 = arg0.activeUnit_0;
				}
			}

			// Token: 0x06005E06 RID: 24070 RVA: 0x0003CA8E File Offset: 0x0003AC8E
			internal bool method_0(CargoMissionMothershipUnitViewModel s)
			{
				return s.activeUnit_0 == this.activeUnit_0;
			}

			// Token: 0x0400368F RID: 13967
			public ActiveUnit activeUnit_0;
		}

		// Token: 0x02000DA4 RID: 3492
		[CompilerGenerated]
		internal sealed class Class2430
		{
			// Token: 0x06005E07 RID: 24071 RVA: 0x0003CA9E File Offset: 0x0003AC9E
			public Class2430(CargoMissionViewModel.Class2430 arg0)
			{
				if (arg0 != null)
				{
					this.activeUnit_0 = arg0.activeUnit_0;
				}
			}

			// Token: 0x06005E08 RID: 24072 RVA: 0x0003CAB5 File Offset: 0x0003ACB5
			internal bool method_0(CargoMissionMothershipUnitViewModel s)
			{
				return s.activeUnit_0 == this.activeUnit_0;
			}

			// Token: 0x04003690 RID: 13968
			public ActiveUnit activeUnit_0;
		}

		// Token: 0x02000DA5 RID: 3493
		[CompilerGenerated]
		internal sealed class Class2431
		{
			// Token: 0x06005E09 RID: 24073 RVA: 0x0003CAC5 File Offset: 0x0003ACC5
			public Class2431(CargoMissionViewModel.Class2431 arg0)
			{
				if (arg0 != null)
				{
					this.mount_0 = arg0.mount_0;
				}
			}

			// Token: 0x06005E0A RID: 24074 RVA: 0x0003CADC File Offset: 0x0003ACDC
			internal bool method_0(CargoMissionMothershipCargoMountViewModel s)
			{
				return s.DBID == this.mount_0.DBID;
			}

			// Token: 0x06005E0B RID: 24075 RVA: 0x0003CAF1 File Offset: 0x0003ACF1
			internal bool method_1(Ship s)
			{
				return s.cargoType_0 >= this.mount_0.cargoType_0;
			}

			// Token: 0x06005E0C RID: 24076 RVA: 0x0003CB09 File Offset: 0x0003AD09
			internal bool method_2(Aircraft s)
			{
				return s.method_167().cargoType_0 >= this.mount_0.cargoType_0;
			}

			// Token: 0x04003691 RID: 13969
			public Mount mount_0;

			// Token: 0x04003692 RID: 13970
			public Func<Ship, bool> func_0;

			// Token: 0x04003693 RID: 13971
			public Func<Aircraft, bool> func_1;
		}

		// Token: 0x02000DA6 RID: 3494
		[CompilerGenerated]
		internal sealed class Class2432
		{
			// Token: 0x06005E0D RID: 24077 RVA: 0x0003CB26 File Offset: 0x0003AD26
			public Class2432(CargoMissionViewModel.Class2432 arg0)
			{
				if (arg0 != null)
				{
					this.mount_0 = arg0.mount_0;
				}
			}

			// Token: 0x06005E0E RID: 24078 RVA: 0x0003CB3D File Offset: 0x0003AD3D
			internal bool method_0(CargoMissionMothershipCargoMountViewModel s)
			{
				return s.DBID == this.mount_0.DBID;
			}

			// Token: 0x06005E0F RID: 24079 RVA: 0x0003CB52 File Offset: 0x0003AD52
			internal bool method_1(Ship s)
			{
				return s.cargoType_0 >= this.mount_0.cargoType_0;
			}

			// Token: 0x06005E10 RID: 24080 RVA: 0x0003CB6A File Offset: 0x0003AD6A
			internal bool method_2(Aircraft s)
			{
				return s.method_167().cargoType_0 >= this.mount_0.cargoType_0;
			}

			// Token: 0x04003694 RID: 13972
			public Mount mount_0;

			// Token: 0x04003695 RID: 13973
			public Func<Ship, bool> func_0;

			// Token: 0x04003696 RID: 13974
			public Func<Aircraft, bool> func_1;
		}

		// Token: 0x02000DA7 RID: 3495
		[CompilerGenerated]
		internal sealed class Class2433
		{
			// Token: 0x06005E11 RID: 24081 RVA: 0x0003CB87 File Offset: 0x0003AD87
			public Class2433(CargoMissionViewModel.Class2433 arg0)
			{
				if (arg0 != null)
				{
					this.ship_0 = arg0.ship_0;
				}
			}

			// Token: 0x06005E12 RID: 24082 RVA: 0x003320A8 File Offset: 0x003302A8
			internal float method_0(ReferencePoint s)
			{
				return s.method_12(this.ship_0.vmethod_93().method_11(false).vmethod_28(null), this.ship_0.vmethod_93().method_11(false).vmethod_30(null));
			}

			// Token: 0x04003697 RID: 13975
			public Ship ship_0;
		}

		// Token: 0x02000DA9 RID: 3497
		[CompilerGenerated]
		internal sealed class Class2434
		{
			// Token: 0x06005E24 RID: 24100 RVA: 0x0003CBE8 File Offset: 0x0003ADE8
			public Class2434(CargoMissionViewModel.Class2434 arg0)
			{
				if (arg0 != null)
				{
					this.activeUnit_0 = arg0.activeUnit_0;
				}
			}

			// Token: 0x06005E25 RID: 24101 RVA: 0x0003CBFF File Offset: 0x0003ADFF
			internal bool method_0(CargoMissionAssignedUnitViewModel s)
			{
				return s.activeUnit_0 == this.activeUnit_0;
			}

			// Token: 0x040036A8 RID: 13992
			public ActiveUnit activeUnit_0;

			// Token: 0x040036A9 RID: 13993
			public Func<CargoMissionAssignedUnitViewModel, bool> func_0;
		}

		// Token: 0x02000DAA RID: 3498
		[CompilerGenerated]
		internal sealed class Class2435
		{
			// Token: 0x06005E27 RID: 24103 RVA: 0x0003CC0F File Offset: 0x0003AE0F
			internal bool method_0(CargoMissionAssignedUnitViewModel s)
			{
				return s.activeUnit_0 == this.activeUnit_0;
			}

			// Token: 0x040036AA RID: 13994
			public ActiveUnit activeUnit_0;
		}
	}
}
