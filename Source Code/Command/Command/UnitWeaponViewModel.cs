using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic;
using ns14;

namespace Command
{
	// Token: 0x02000D98 RID: 3480
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class UnitWeaponViewModel : INotifyPropertyChanged
	{
		// Token: 0x06005D68 RID: 23912 RVA: 0x0032F454 File Offset: 0x0032D654
		private void method_0(Weapon Weapon, int Qty)
		{
			UnitWeaponViewModel.Class2428 @class = new UnitWeaponViewModel.Class2428();
			@class.weapon_0 = Weapon;
			UnitWeaponElementViewModel unitWeaponElementViewModel = Enumerable.FirstOrDefault<UnitWeaponElementViewModel>(this.Weapons, new Func<UnitWeaponElementViewModel, bool>(@class.method_0));
			if (unitWeaponElementViewModel == null)
			{
				unitWeaponElementViewModel = new UnitWeaponElementViewModel();
				unitWeaponElementViewModel.WeaponDBID = @class.weapon_0.DBID;
				unitWeaponElementViewModel.Name = @class.weapon_0.Name;
				unitWeaponElementViewModel.Qty = 0;
				unitWeaponElementViewModel.Type = (int)@class.weapon_0.method_167();
				this.Weapons.Add(unitWeaponElementViewModel);
			}
			UnitWeaponElementViewModel unitWeaponElementViewModel2;
			(unitWeaponElementViewModel2 = unitWeaponElementViewModel).Qty = unitWeaponElementViewModel2.Qty + Qty;
		}

		// Token: 0x06005D69 RID: 23913 RVA: 0x0032F4E8 File Offset: 0x0032D6E8
		public void method_1(ActiveUnit theUnit)
		{
			if (!Information.IsNothing(((Aircraft)theUnit).method_167()))
			{
				foreach (WeaponRec weaponRec in ((Aircraft)theUnit).method_167().weaponRec_0)
				{
					if (weaponRec.method_9() > 0)
					{
						Weapon weapon = weaponRec.method_12(Client.smethod_46());
						Weapon._WeaponType weaponType = weapon.method_167();
						if (weaponType != Weapon._WeaponType.DropTank && weaponType != Weapon._WeaponType.FerryTank && weaponType != Weapon._WeaponType.HeliTowedPackage && weaponType != Weapon._WeaponType.BuddyStore && weaponType != Weapon._WeaponType.TrainingRound)
						{
							if (weaponType == Weapon._WeaponType.SensorPod)
							{
								try
								{
									foreach (WeaponRec weaponRec2 in weapon.vmethod_139())
									{
										if (weaponRec2.method_9() > 0)
										{
											Weapon weapon2 = weaponRec2.method_12(Client.smethod_46());
											this.method_0(weapon2, weaponRec2.method_9());
										}
									}
									goto IL_F5;
								}
								finally
								{
									List<WeaponRec>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
							}
							this.method_0(weapon, weaponRec.method_9());
						}
					}
					IL_F5:;
				}
			}
		}

		// Token: 0x06005D6A RID: 23914 RVA: 0x0032F608 File Offset: 0x0032D808
		private void method_2(ActiveUnit theUnit)
		{
			IEnumerable<Magazine> enumerable = Enumerable.OrderBy<Magazine, string>(theUnit.vmethod_117(), (UnitWeaponViewModel._Closure$__.$I2-0 == null) ? (UnitWeaponViewModel._Closure$__.$I2-0 = new Func<Magazine, string>(UnitWeaponViewModel._Closure$__.$I.method_0)) : UnitWeaponViewModel._Closure$__.$I2-0);
			try
			{
				foreach (Magazine magazine in enumerable)
				{
					if (!magazine.bool_11 && magazine.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
					{
						try
						{
							foreach (WeaponRec weaponRec in magazine.vmethod_10())
							{
								if (weaponRec.method_9() > 0)
								{
									Weapon weapon = weaponRec.method_12(Client.smethod_46());
									if (weapon.method_167() != Weapon._WeaponType.TrainingRound)
									{
										int qty = weaponRec.method_9();
										this.method_0(weapon, qty);
									}
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator<Magazine> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06005D6B RID: 23915 RVA: 0x0032F708 File Offset: 0x0032D908
		private void method_3(ActiveUnit theUnit)
		{
			IEnumerable<Mount> enumerable = Enumerable.OrderBy<Mount, string>(theUnit.vmethod_51(), (UnitWeaponViewModel._Closure$__.$I3-0 == null) ? (UnitWeaponViewModel._Closure$__.$I3-0 = new Func<Mount, string>(UnitWeaponViewModel._Closure$__.$I.method_1)) : UnitWeaponViewModel._Closure$__.$I3-0);
			try
			{
				foreach (Mount mount in enumerable)
				{
					if (mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
					{
						try
						{
							foreach (WeaponRec weaponRec in mount.vmethod_10())
							{
								Weapon weapon = weaponRec.method_12(Client.smethod_46());
								if (weapon.method_167() != Weapon._WeaponType.TrainingRound)
								{
									int num = theUnit.vmethod_89().method_34(mount, weaponRec.int_5);
									int num2 = weaponRec.method_9();
									if (num > 0 || num2 > 0)
									{
										this.method_0(weapon, num2 + num);
									}
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator<Mount> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x0003C22E File Offset: 0x0003A42E
		public UnitWeaponViewModel(ActiveUnit theUnit)
		{
			this.Weapons = new List<UnitWeaponElementViewModel>();
			this.HasWeapons = false;
			this.WeaponsCollection_Sorted = new ObservableCollection<UnitWeaponElementViewModel>();
			this.activeUnit_0 = theUnit;
			this.method_4();
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06005D6D RID: 23917 RVA: 0x0003C260 File Offset: 0x0003A460
		// (set) Token: 0x06005D6E RID: 23918 RVA: 0x0003C268 File Offset: 0x0003A468
		private List<UnitWeaponElementViewModel> Weapons
		{
			[CompilerGenerated]
			get
			{
				return this.list_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.list_0 == value)
				{
					return;
				}
				this.list_0 = value;
				this.vmethod_0("Weapons");
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06005D6F RID: 23919 RVA: 0x0003C288 File Offset: 0x0003A488
		// (set) Token: 0x06005D70 RID: 23920 RVA: 0x0003C290 File Offset: 0x0003A490
		public bool HasWeapons
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
				this.vmethod_0("HasWeapons");
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06005D71 RID: 23921 RVA: 0x0003C2B0 File Offset: 0x0003A4B0
		// (set) Token: 0x06005D72 RID: 23922 RVA: 0x0003C2B8 File Offset: 0x0003A4B8
		public List<UnitWeaponElementViewModel> Weapons_Sorted
		{
			[CompilerGenerated]
			get
			{
				return this.list_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.list_1 == value)
				{
					return;
				}
				this.list_1 = value;
				this.vmethod_0("Weapons_Sorted");
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06005D73 RID: 23923 RVA: 0x0003C2D8 File Offset: 0x0003A4D8
		// (set) Token: 0x06005D74 RID: 23924 RVA: 0x0003C2E0 File Offset: 0x0003A4E0
		public ObservableCollection<UnitWeaponElementViewModel> WeaponsCollection_Sorted
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
				this.vmethod_0("WeaponsCollection_Sorted");
			}
		}

		// Token: 0x06005D75 RID: 23925 RVA: 0x0032F818 File Offset: 0x0032DA18
		public void method_4()
		{
			if (!Information.IsNothing(this.activeUnit_0) && (!this.activeUnit_0.bool_6 || !((Ship)this.activeUnit_0).method_152()))
			{
				if (this.activeUnit_0.bool_0)
				{
					if (!this.activeUnit_0.bool_3 && !this.activeUnit_0.bool_6 && !this.activeUnit_0.bool_5 && !this.activeUnit_0.bool_8 && !this.activeUnit_0.method_22() && !this.activeUnit_0.bool_1)
					{
						this.Weapons.Clear();
						if (!Information.IsNothing(this.Weapons_Sorted))
						{
							this.Weapons_Sorted.Clear();
						}
						this.WeaponsCollection_Sorted.Clear();
					}
					else
					{
						if (this.activeUnit_0 != this.activeUnit_1)
						{
							this.Weapons.Clear();
							this.WeaponsCollection_Sorted.Clear();
						}
						else
						{
							try
							{
								foreach (UnitWeaponElementViewModel unitWeaponElementViewModel in this.Weapons)
								{
									unitWeaponElementViewModel.Qty = 0;
								}
							}
							finally
							{
								List<UnitWeaponElementViewModel>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						if (this.activeUnit_0.bool_3)
						{
							this.method_3(this.activeUnit_0);
							this.method_1(this.activeUnit_0);
						}
						else
						{
							if (!this.activeUnit_0.bool_6 && !this.activeUnit_0.bool_5 && !this.activeUnit_0.bool_8)
							{
								if (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)
								{
									try
									{
										foreach (ActiveUnit theUnit in ((Group)this.activeUnit_0).vmethod_141().Values)
										{
											this.method_3(theUnit);
											this.method_1(theUnit);
										}
										goto IL_24B;
									}
									finally
									{
										IEnumerator<ActiveUnit> enumerator2;
										if (enumerator2 != null)
										{
											enumerator2.Dispose();
										}
									}
								}
								if (!this.activeUnit_0.bool_1)
								{
									goto IL_24B;
								}
								try
								{
									foreach (ActiveUnit theUnit2 in ((Group)this.activeUnit_0).vmethod_141().Values)
									{
										this.method_3(theUnit2);
										this.method_2(theUnit2);
									}
									goto IL_24B;
								}
								finally
								{
									IEnumerator<ActiveUnit> enumerator3;
									if (enumerator3 != null)
									{
										enumerator3.Dispose();
									}
								}
							}
							this.method_3(this.activeUnit_0);
							this.method_2(this.activeUnit_0);
						}
						IL_24B:
						this.WeaponsCollection_Sorted.Clear();
						this.Weapons_Sorted = Enumerable.ToList<UnitWeaponElementViewModel>(Enumerable.ThenBy<UnitWeaponElementViewModel, string>(Enumerable.OrderBy<UnitWeaponElementViewModel, int>(this.Weapons, (UnitWeaponViewModel._Closure$__.$I21-0 == null) ? (UnitWeaponViewModel._Closure$__.$I21-0 = new Func<UnitWeaponElementViewModel, int>(UnitWeaponViewModel._Closure$__.$I.method_2)) : UnitWeaponViewModel._Closure$__.$I21-0), (UnitWeaponViewModel._Closure$__.$I21-1 == null) ? (UnitWeaponViewModel._Closure$__.$I21-1 = new Func<UnitWeaponElementViewModel, string>(UnitWeaponViewModel._Closure$__.$I.method_3)) : UnitWeaponViewModel._Closure$__.$I21-1));
						try
						{
							foreach (UnitWeaponElementViewModel item in this.Weapons_Sorted)
							{
								this.WeaponsCollection_Sorted.Add(item);
							}
						}
						finally
						{
							List<UnitWeaponElementViewModel>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
					}
				}
				if (this.Weapons.Count > 0)
				{
					this.HasWeapons = true;
				}
				else
				{
					this.HasWeapons = false;
				}
				this.activeUnit_1 = this.activeUnit_0;
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06005D76 RID: 23926 RVA: 0x0032FB7C File Offset: 0x0032DD7C
		// (remove) Token: 0x06005D77 RID: 23927 RVA: 0x0032FBB4 File Offset: 0x0032DDB4
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

		// Token: 0x06005D78 RID: 23928 RVA: 0x0032FBEC File Offset: 0x0032DDEC
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400364D RID: 13901
		[CompilerGenerated]
		private List<UnitWeaponElementViewModel> list_0;

		// Token: 0x0400364E RID: 13902
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400364F RID: 13903
		[CompilerGenerated]
		private List<UnitWeaponElementViewModel> list_1;

		// Token: 0x04003650 RID: 13904
		[CompilerGenerated]
		private ObservableCollection<UnitWeaponElementViewModel> observableCollection_0;

		// Token: 0x04003651 RID: 13905
		public ActiveUnit activeUnit_0;

		// Token: 0x04003652 RID: 13906
		public ActiveUnit activeUnit_1;

		// Token: 0x04003653 RID: 13907
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x02000D99 RID: 3481
		[CompilerGenerated]
		internal sealed class Class2428
		{
			// Token: 0x06005D7A RID: 23930 RVA: 0x0003C300 File Offset: 0x0003A500
			internal bool method_0(UnitWeaponElementViewModel s)
			{
				return s.WeaponDBID == this.weapon_0.DBID;
			}

			// Token: 0x04003654 RID: 13908
			public Weapon weapon_0;
		}
	}
}
