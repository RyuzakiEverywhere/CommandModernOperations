using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using System.Windows.Threading;
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using ns14;
using ns5;

namespace Command
{
	// Token: 0x02000F44 RID: 3908
	public sealed class SoundHandler_Effects : DispatcherObject
	{
		// Token: 0x06008BFE RID: 35838 RVA: 0x004B61C8 File Offset: 0x004B43C8
		public SoundHandler_Effects()
		{
			this.list_0 = null;
			this.list_1 = null;
			this.list_2 = null;
			this.string_0 = Class2413.smethod_1().Info.DirectoryPath + "\\Sound\\Effects\\";
			ActiveUnit_Weaponry.smethod_0(new ActiveUnit_Weaponry.Delegate22(this.method_2));
			Weapon.smethod_10(new Weapon.Delegate55(this.method_3));
			Aircraft_AirOps.smethod_1(new Aircraft_AirOps.Delegate23(this.method_1));
			ActiveUnit_Sensory.smethod_0(new ActiveUnit_Sensory.Delegate21(this.method_0));
			PrivateMethods.smethod_3(new PrivateMethods.Delegate61(this.method_5));
		}

		// Token: 0x06008BFF RID: 35839 RVA: 0x004B6264 File Offset: 0x004B4464
		private void method_0(Side side_0, Contact_Base.ContactType contactType_0)
		{
			if (Class570.class280_0.method_8() && !Information.IsNothing(Client.smethod_50()) && !Information.IsNothing(Client.smethod_50()) && (side_0 == Client.smethod_50() || side_0.method_68(Client.smethod_50()) == Misc.PostureStance.Friendly))
			{
				switch (contactType_0)
				{
				case Contact_Base.ContactType.Air:
					this.method_6(this.string_0 + "contact_air.mp3");
					return;
				case Contact_Base.ContactType.Missile:
					this.method_6(this.string_0 + "Alert_missile.mp3");
					return;
				case Contact_Base.ContactType.Surface:
					this.method_6(this.string_0 + "contact_surface.mp3");
					return;
				case Contact_Base.ContactType.Submarine:
					this.method_6(this.string_0 + "contact_underwater.mp3");
					return;
				case Contact_Base.ContactType.Facility_Fixed:
				case Contact_Base.ContactType.Facility_Mobile:
					this.method_6(this.string_0 + "contact_ground.mp3");
					return;
				case Contact_Base.ContactType.Torpedo:
					this.method_6(this.string_0 + "Alert_torpedo.mp3");
					return;
				}
				this.method_6(this.string_0 + "contact_new.mp3");
			}
		}

		// Token: 0x06008C00 RID: 35840 RVA: 0x004B638C File Offset: 0x004B458C
		private void method_1(Aircraft aircraft_0)
		{
			if (Class570.class280_0.method_8() && !Information.IsNothing(Client.smethod_50()) && aircraft_0.vmethod_7(false) == Client.smethod_50())
			{
				if (aircraft_0.method_169())
				{
					this.method_6(this.string_0 + "helo_takeoff.mp3");
					return;
				}
				if (aircraft_0.method_164().method_32(false).bool_6 & !aircraft_0.method_15())
				{
					if (aircraft_0.vmethod_49()[0].enum112_0 == Engine.Enum112.const_3 | aircraft_0.vmethod_49()[0].enum112_0 == Engine.Enum112.const_4)
					{
						this.method_6(this.string_0 + "airplane_carriertakeoff_prop.mp3");
						return;
					}
					this.method_6(this.string_0 + "airplane_carriertakeoff.mp3");
					return;
				}
				else
				{
					if (aircraft_0.vmethod_49()[0].enum112_0 == Engine.Enum112.const_3 | aircraft_0.vmethod_49()[0].enum112_0 == Engine.Enum112.const_4)
					{
						this.method_6(this.string_0 + "airplane_takeoff_prop.mp3");
						return;
					}
					this.method_6(this.string_0 + "airplane_takeoff.mp3");
				}
			}
		}

		// Token: 0x06008C01 RID: 35841 RVA: 0x004B64C8 File Offset: 0x004B46C8
		private void method_2(Scenario scenario_0, ActiveUnit activeUnit_0, Weapon weapon_0)
		{
			if (!Information.IsNothing(Client.smethod_50()) && Class570.class280_0.method_8() && (activeUnit_0.vmethod_7(false) == Client.smethod_50() | activeUnit_0.vmethod_7(false).method_67(Client.smethod_50())) && scenario_0 == Client.smethod_46())
			{
				Weapon._WeaponType weaponType = weapon_0.method_167();
				switch (weaponType)
				{
				case Weapon._WeaponType.GuidedWeapon:
					if (Enumerable.Count<FuelRec>(weapon_0.vmethod_67()) <= 0 || weapon_0.vmethod_67()[0]._FuelType_0 != FuelRec._FuelType.WeaponCoast)
					{
						if (activeUnit_0.bool_3 & weapon_0.method_199())
						{
							if (weapon_0.method_116())
							{
								this.method_6(this.string_0 + "AAM_IR.mp3");
								return;
							}
							this.method_6(this.string_0 + "AAM_Other.mp3");
							return;
						}
						else
						{
							if (activeUnit_0.bool_6)
							{
								this.method_6(this.string_0 + "ship_missilelaunch.mp3");
								return;
							}
							if (activeUnit_0.bool_8)
							{
								this.method_6(this.string_0 + "ground_missilelaunch.mp3");
								return;
							}
							if (weapon_0.method_159() < 10f)
							{
								this.method_6(this.string_0 + "Missile_small.mp3");
								return;
							}
							this.method_6(this.string_0 + "Missile_medium.mp3");
							return;
						}
					}
					break;
				case Weapon._WeaponType.Rocket:
					this.method_6(this.string_0 + "Rocket_small.mp3");
					return;
				case Weapon._WeaponType.IronBomb:
					break;
				case Weapon._WeaponType.Gun:
					switch (weapon_0.warhead_0[0].warheadCaliber_0)
					{
					case Warhead.WarheadCaliber.Gun_6_15mm:
						this.method_6(this.string_0 + "Gunfire_machinegun.mp3");
						return;
					case Warhead.WarheadCaliber.Gun_16_24mm:
						this.method_6(this.string_0 + "Gunfire_20mm.mp3");
						return;
					case Warhead.WarheadCaliber.Gun_25_60mm:
						this.method_6(this.string_0 + "Gunfire_40mm.mp3");
						return;
					case Warhead.WarheadCaliber.Gun_61_80mm:
						this.method_6(this.string_0 + "Gunfire_76mm.mp3");
						return;
					case Warhead.WarheadCaliber.Gun_81_150mm:
						this.method_6(this.string_0 + "Gunfire_100mm.mp3");
						return;
					default:
						this.method_6(this.string_0 + "Gunfire_152mm.mp3");
						return;
					}
					break;
				default:
					if (weaponType == Weapon._WeaponType.Torpedo)
					{
						this.method_6(this.string_0 + "Torpedo_launch.mp3");
						return;
					}
					if (weaponType != Weapon._WeaponType.Laser)
					{
						return;
					}
					this.method_6(this.string_0 + "Gunfire_laser.mp3");
					break;
				}
			}
		}

		// Token: 0x06008C02 RID: 35842 RVA: 0x004B673C File Offset: 0x004B493C
		private void method_3(Scenario scenario_0, Weapon weapon_0, Unit unit_0, bool bool_0)
		{
			if (Class570.class280_0.method_8() && !Information.IsNothing(Client.smethod_50()) && (weapon_0.vmethod_7(false) == Client.smethod_50() | (!Information.IsNothing(unit_0.vmethod_7(false)) && unit_0.vmethod_7(false) == Client.smethod_50())) && scenario_0 == Client.smethod_46())
			{
				if (bool_0)
				{
					switch (weapon_0.method_167())
					{
					case Weapon._WeaponType.GuidedWeapon:
					case Weapon._WeaponType.IronBomb:
					{
						if (unit_0.bool_3)
						{
							this.method_6(this.string_0 + "Explosion_air_medium.mp3");
							return;
						}
						float float_ = weapon_0.warhead_0[0].float_0;
						if (float_ < 5f)
						{
							this.method_6(this.string_0 + "Impact_directhit_vsmall.mp3");
							return;
						}
						if (float_ < 50f)
						{
							this.method_6(this.string_0 + "Impact_directhit_small.mp3");
							return;
						}
						if (float_ < 200f)
						{
							this.method_6(this.string_0 + "Impact_directhit_medium.mp3");
							return;
						}
						this.method_6(this.string_0 + "Impact_directhit_large.mp3");
						return;
					}
					case Weapon._WeaponType.Rocket:
					case Weapon._WeaponType.Gun:
					{
						Warhead.WarheadCaliber warheadCaliber_ = weapon_0.warhead_0[0].warheadCaliber_0;
						if (warheadCaliber_ - Warhead.WarheadCaliber.Gun_6_15mm <= 3)
						{
							this.method_6(this.string_0 + "Impact_directhit_small.mp3");
							return;
						}
						if (warheadCaliber_ - Warhead.WarheadCaliber.Gun_81_150mm > 1)
						{
							this.method_6(this.string_0 + "Impact_directhit_large.mp3");
							return;
						}
						this.method_6(this.string_0 + "Impact_directhit_medium.mp3");
						return;
					}
					default:
						return;
					}
				}
				else if (weapon_0.method_15())
				{
					switch (weapon_0.method_167())
					{
					case Weapon._WeaponType.GuidedWeapon:
					case Weapon._WeaponType.IronBomb:
					{
						float float_2 = weapon_0.warhead_0[0].float_0;
						if (float_2 < 50f)
						{
							this.method_6(this.string_0 + "Impact_miss_land_small.mp3");
							return;
						}
						if (float_2 < 200f)
						{
							this.method_6(this.string_0 + "Impact_miss_land_medium.mp3");
							return;
						}
						this.method_6(this.string_0 + "Impact_miss_land_large.mp3");
						return;
					}
					case Weapon._WeaponType.Rocket:
					case Weapon._WeaponType.Gun:
					{
						Warhead.WarheadCaliber warheadCaliber_2 = weapon_0.warhead_0[0].warheadCaliber_0;
						if (warheadCaliber_2 - Warhead.WarheadCaliber.Gun_6_15mm <= 3)
						{
							this.method_6(this.string_0 + "Impact_miss_land_small.mp3");
							return;
						}
						if (warheadCaliber_2 - Warhead.WarheadCaliber.Gun_81_150mm > 1)
						{
							this.method_6(this.string_0 + "Impact_miss_land_large.mp3");
							return;
						}
						this.method_6(this.string_0 + "Impact_miss_land_medium.mp3");
						return;
					}
					default:
						return;
					}
				}
				else
				{
					this.method_6(this.string_0 + "Watersplash_large.mp3");
				}
			}
		}

		// Token: 0x06008C03 RID: 35843 RVA: 0x004B69F0 File Offset: 0x004B4BF0
		private void method_4(string string_1)
		{
			if (this.list_0 == null)
			{
				this.list_0 = new List<MediaPlayer>();
				this.list_0.AddRange(Enumerable.Select<int, MediaPlayer>(Enumerable.Range(0, 8), (SoundHandler_Effects._Closure$__.$I10-0 == null) ? (SoundHandler_Effects._Closure$__.$I10-0 = new Func<int, MediaPlayer>(SoundHandler_Effects._Closure$__.$I.method_0)) : SoundHandler_Effects._Closure$__.$I10-0));
				this.list_1 = new List<bool>();
				this.list_1.AddRange(Enumerable.Select<int, bool>(Enumerable.Range(0, 8), (SoundHandler_Effects._Closure$__.$I10-1 == null) ? (SoundHandler_Effects._Closure$__.$I10-1 = new Func<int, bool>(SoundHandler_Effects._Closure$__.$I.method_1)) : SoundHandler_Effects._Closure$__.$I10-1));
				this.list_2 = new List<string>();
				this.list_2.AddRange(Enumerable.Select<int, string>(Enumerable.Range(0, 8), (SoundHandler_Effects._Closure$__.$I10-2 == null) ? (SoundHandler_Effects._Closure$__.$I10-2 = new Func<int, string>(SoundHandler_Effects._Closure$__.$I.method_2)) : SoundHandler_Effects._Closure$__.$I10-2));
				int num = 0;
				do
				{
					SoundHandler_Effects.Class2562 @class = new SoundHandler_Effects.Class2562(@class);
					@class.soundHandler_Effects_0 = this;
					@class.int_0 = num;
					this.list_0[num].MediaEnded += @class.method_0;
					this.list_0[num].MediaOpened += @class.method_2;
					this.list_1[@class.int_0] = false;
					num++;
				}
				while (num <= 7);
			}
			if (!this.list_2.Contains(string_1))
			{
				int num2 = this.list_1.IndexOf(false);
				if (num2 != -1)
				{
					MediaPlayer mediaPlayer = Enumerable.First<MediaPlayer>(Enumerable.Skip<MediaPlayer>(this.list_0, num2));
					mediaPlayer.Open(new Uri(string_1));
					mediaPlayer.Play();
					this.list_2[num2] = string_1;
				}
			}
		}

		// Token: 0x06008C04 RID: 35844 RVA: 0x00053934 File Offset: 0x00051B34
		private void method_5(string string_1, int int_0)
		{
			if (Class570.class280_0.method_8())
			{
				this.method_6(string_1);
			}
		}

		// Token: 0x06008C05 RID: 35845 RVA: 0x004B6B94 File Offset: 0x004B4D94
		private void method_6(string string_1)
		{
			SoundHandler_Effects.Class2563 @class = new SoundHandler_Effects.Class2563();
			@class.soundHandler_Effects_0 = this;
			@class.string_0 = string_1;
			try
			{
				base.Dispatcher.Invoke(new VB$AnonymousDelegate_0(@class.method_0), new object[0]);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200421", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x04004BDE RID: 19422
		private string string_0;

		// Token: 0x04004BDF RID: 19423
		private List<MediaPlayer> list_0;

		// Token: 0x04004BE0 RID: 19424
		private List<bool> list_1;

		// Token: 0x04004BE1 RID: 19425
		private List<string> list_2;

		// Token: 0x02000F45 RID: 3909
		[CompilerGenerated]
		internal sealed class Class2562
		{
			// Token: 0x06008C06 RID: 35846 RVA: 0x00053949 File Offset: 0x00051B49
			public Class2562(SoundHandler_Effects.Class2562 class2562_0)
			{
				if (class2562_0 != null)
				{
					this.int_0 = class2562_0.int_0;
				}
			}

			// Token: 0x06008C07 RID: 35847 RVA: 0x004B6C1C File Offset: 0x004B4E1C
			internal void method_0(object sender, EventArgs e)
			{
				this.soundHandler_Effects_0.Dispatcher.Invoke((this.vb$AnonymousDelegate_0_0 == null) ? (this.vb$AnonymousDelegate_0_0 = new VB$AnonymousDelegate_0(this.method_1)) : this.vb$AnonymousDelegate_0_0, new object[0]);
			}

			// Token: 0x06008C08 RID: 35848 RVA: 0x00053960 File Offset: 0x00051B60
			internal void method_1()
			{
				this.soundHandler_Effects_0.list_1[this.int_0] = false;
				this.soundHandler_Effects_0.list_2[this.int_0] = "";
			}

			// Token: 0x06008C09 RID: 35849 RVA: 0x004B6C68 File Offset: 0x004B4E68
			internal void method_2(object sender, EventArgs e)
			{
				this.soundHandler_Effects_0.Dispatcher.Invoke((this.vb$AnonymousDelegate_0_1 == null) ? (this.vb$AnonymousDelegate_0_1 = new VB$AnonymousDelegate_0(this.method_3)) : this.vb$AnonymousDelegate_0_1, new object[0]);
			}

			// Token: 0x06008C0A RID: 35850 RVA: 0x00053994 File Offset: 0x00051B94
			internal void method_3()
			{
				this.soundHandler_Effects_0.list_1[this.int_0] = true;
			}

			// Token: 0x04004BE2 RID: 19426
			public int int_0;

			// Token: 0x04004BE3 RID: 19427
			public SoundHandler_Effects soundHandler_Effects_0;

			// Token: 0x04004BE4 RID: 19428
			public VB$AnonymousDelegate_0 vb$AnonymousDelegate_0_0;

			// Token: 0x04004BE5 RID: 19429
			public VB$AnonymousDelegate_0 vb$AnonymousDelegate_0_1;
		}

		// Token: 0x02000F47 RID: 3911
		[CompilerGenerated]
		internal sealed class Class2563
		{
			// Token: 0x06008C11 RID: 35857 RVA: 0x000539C0 File Offset: 0x00051BC0
			internal void method_0()
			{
				this.soundHandler_Effects_0.method_4(this.string_0);
			}

			// Token: 0x04004BEA RID: 19434
			public string string_0;

			// Token: 0x04004BEB RID: 19435
			public SoundHandler_Effects soundHandler_Effects_0;
		}
	}
}
