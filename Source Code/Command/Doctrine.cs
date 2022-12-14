using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns13;
using ns14;

namespace Command_Core
{
	// Token: 0x0200020B RID: 523
	public sealed class Doctrine
	{
		// Token: 0x06000FDF RID: 4063 RVA: 0x001294E8 File Offset: 0x001276E8
		[CompilerGenerated]
		public static void smethod_0(Doctrine.Delegate28 delegate28_1)
		{
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			Doctrine.Delegate28 delegate2;
			do
			{
				delegate2 = @delegate;
				Doctrine.Delegate28 value = (Doctrine.Delegate28)Delegate.Combine(delegate2, delegate28_1);
				@delegate = Interlocked.CompareExchange<Doctrine.Delegate28>(ref Doctrine.delegate28_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0012951C File Offset: 0x0012771C
		[CompilerGenerated]
		public static void smethod_1(Doctrine.Delegate28 delegate28_1)
		{
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			Doctrine.Delegate28 delegate2;
			do
			{
				delegate2 = @delegate;
				Doctrine.Delegate28 value = (Doctrine.Delegate28)Delegate.Remove(delegate2, delegate28_1);
				@delegate = Interlocked.CompareExchange<Doctrine.Delegate28>(ref Doctrine.delegate28_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00129550 File Offset: 0x00127750
		[CompilerGenerated]
		public static void smethod_2(Doctrine.Delegate29 delegate29_1)
		{
			Doctrine.Delegate29 @delegate = Doctrine.delegate29_0;
			Doctrine.Delegate29 delegate2;
			do
			{
				delegate2 = @delegate;
				Doctrine.Delegate29 value = (Doctrine.Delegate29)Delegate.Combine(delegate2, delegate29_1);
				@delegate = Interlocked.CompareExchange<Doctrine.Delegate29>(ref Doctrine.delegate29_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00129584 File Offset: 0x00127784
		[CompilerGenerated]
		public static void smethod_3(Doctrine.Delegate29 delegate29_1)
		{
			Doctrine.Delegate29 @delegate = Doctrine.delegate29_0;
			Doctrine.Delegate29 delegate2;
			do
			{
				delegate2 = @delegate;
				Doctrine.Delegate29 value = (Doctrine.Delegate29)Delegate.Remove(delegate2, delegate29_1);
				@delegate = Interlocked.CompareExchange<Doctrine.Delegate29>(ref Doctrine.delegate29_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x001295B8 File Offset: 0x001277B8
		public static void smethod_4(Class310 class310_1, bool? nullable_42, bool bool_35, bool bool_36, bool bool_37, bool bool_38)
		{
			Doctrine.Delegate29 @delegate = Doctrine.delegate29_0;
			if (@delegate != null)
			{
				@delegate(class310_1, nullable_42, bool_35, bool_36, bool_37, bool_38);
			}
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x001295DC File Offset: 0x001277DC
		public Doctrine(Class310 class310_1, ref List<ActiveUnit> list_1)
		{
			try
			{
				this.class310_0 = class310_1;
				this.list_0 = list_1;
				if (this.class310_0.GetType() == typeof(Side))
				{
					this.nullable_6 = new Doctrine.Enum65?(Doctrine.Enum65.const_0);
					this.bool_6 = false;
					this.nullable_0 = new Doctrine.Enum52?(Doctrine.Enum52.const_1);
					this.bool_0 = true;
					this.nullable_1 = new Doctrine.Enum52?(Doctrine.Enum52.const_1);
					this.bool_1 = true;
					this.nullable_2 = new Doctrine.Enum52?(Doctrine.Enum52.const_1);
					this.bool_2 = true;
					this.nullable_3 = new Doctrine.Enum52?(Doctrine.Enum52.const_1);
					this.bool_3 = true;
					this.nullable_4 = new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.No);
					this.bool_4 = true;
					this.nullable_5 = new Doctrine.Enum64?(Doctrine.Enum64.const_0);
					this.bool_5 = true;
					this.nullable_11 = new Doctrine.Enum51?(Doctrine.Enum51.const_2);
					this.bool_11 = true;
					this.nullable_12 = new Doctrine.Enum61?(Doctrine.Enum61.const_1);
					this.bool_12 = true;
					this.nullable_13 = new Doctrine.Enum62?(Doctrine.Enum62.const_1);
					this.bool_13 = true;
					this.nullable_14 = new Doctrine.Enum63?(Doctrine.Enum63.const_0);
					this.bool_14 = true;
					this.nullable_15 = new Doctrine.Enum63?(Doctrine.Enum63.const_0);
					this.bool_15 = true;
					this.nullable_16 = new Doctrine.Enum63?(Doctrine.Enum63.const_0);
					this.bool_16 = true;
					this.nullable_17 = new Doctrine.Enum56?(Doctrine.Enum56.const_0);
					this.bool_17 = true;
					this.nullable_18 = new Doctrine.Enum57?(Doctrine.Enum57.const_0);
					this.bool_18 = true;
					this.nullable_19 = new Doctrine.Enum59?(Doctrine.Enum59.const_0);
					this.bool_19 = true;
					this.nullable_20 = new Doctrine.Enum58?(Doctrine.Enum58.const_0);
					this.bool_20 = true;
					this.nullable_21 = new Doctrine.Enum60?(Doctrine.Enum60.const_1);
					this.bool_21 = true;
					this.nullable_22 = new Doctrine.Enum53?(Doctrine.Enum53.const_1);
					this.bool_22 = false;
					this.nullable_23 = new Doctrine.Enum54?(Doctrine.Enum54.const_0);
					this.bool_23 = false;
					this.nullable_25 = new Doctrine._WeaponState?(Doctrine._WeaponState.LoadoutSetting);
					this.bool_25 = true;
					this.nullable_7 = new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit);
					this.bool_7 = true;
					this.nullable_24 = new Doctrine._FuelState?(Doctrine._FuelState.Bingo);
					this.bool_24 = true;
					this.bool_8 = true;
					this.nullable_8 = new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesFirstUnit);
					this.nullable_9 = new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.No);
					this.bool_9 = true;
					this.nullable_10 = new Doctrine._BVRLogicEnum?(Doctrine._BVRLogicEnum.Crank);
					this.bool_10 = true;
					this.nullable_26 = new Doctrine.Enum55?(Doctrine.Enum55.const_2);
					this.bool_26 = true;
					this.nullable_27 = new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Yes);
					this.bool_27 = true;
					this.nullable_28 = new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.No);
					this.bool_28 = true;
					this.nullable_29 = new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes);
					this.bool_29 = true;
					this.nullable_30 = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_60_Percent);
					this.bool_30 = true;
					this.nullable_31 = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_10_Percent);
					this.bool_31 = true;
					this.nullable_32 = new Doctrine._UseAIP?(Doctrine._UseAIP.Yes_AttackOnly);
					this.bool_32 = true;
					this.nullable_33 = new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Automatically_HoverAnd150ft);
					this.bool_33 = true;
					this.class275_0 = new Doctrine.Class275();
					this.nullable_34 = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Ignore);
					this.nullable_35 = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Bingo);
					this.nullable_36 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore);
					this.nullable_37 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore);
					this.nullable_38 = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent5);
					this.nullable_39 = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent100);
					this.nullable_40 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent100);
					this.nullable_41 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent100);
				}
				else if (this.class310_0.GetType() == typeof(Waypoint))
				{
					this.nullable_6 = new Doctrine.Enum65?(Doctrine.Enum65.const_3);
					this.nullable_0 = new Doctrine.Enum52?(Doctrine.Enum52.const_4);
					this.nullable_1 = new Doctrine.Enum52?(Doctrine.Enum52.const_4);
					this.nullable_2 = new Doctrine.Enum52?(Doctrine.Enum52.const_4);
					this.nullable_3 = new Doctrine.Enum52?(Doctrine.Enum52.const_4);
					this.nullable_4 = new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.NotConfigured);
					this.nullable_5 = new Doctrine.Enum64?(Doctrine.Enum64.const_3);
					this.nullable_11 = new Doctrine.Enum51?(Doctrine.Enum51.const_4);
					this.nullable_12 = new Doctrine.Enum61?(Doctrine.Enum61.const_3);
					this.nullable_13 = new Doctrine.Enum62?(Doctrine.Enum62.const_3);
					this.nullable_14 = new Doctrine.Enum63?(Doctrine.Enum63.const_7);
					this.nullable_15 = new Doctrine.Enum63?(Doctrine.Enum63.const_7);
					this.nullable_16 = new Doctrine.Enum63?(Doctrine.Enum63.const_7);
					this.nullable_17 = new Doctrine.Enum56?(Doctrine.Enum56.const_4);
					this.nullable_18 = new Doctrine.Enum57?(Doctrine.Enum57.const_4);
					this.nullable_19 = new Doctrine.Enum59?(Doctrine.Enum59.const_3);
					this.nullable_20 = new Doctrine.Enum58?(Doctrine.Enum58.const_3);
					this.nullable_21 = new Doctrine.Enum60?(Doctrine.Enum60.const_3);
					this.nullable_22 = new Doctrine.Enum53?(Doctrine.Enum53.const_4);
					this.nullable_23 = new Doctrine.Enum54?(Doctrine.Enum54.const_3);
					this.nullable_25 = new Doctrine._WeaponState?(Doctrine._WeaponState.NotConfigured);
					this.nullable_7 = new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.NotConfigured);
					this.nullable_24 = new Doctrine._FuelState?(Doctrine._FuelState.NotConfigured);
					this.nullable_8 = new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.NotConfigured);
					this.nullable_9 = new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.NotConfigured);
					this.nullable_10 = new Doctrine._BVRLogicEnum?(Doctrine._BVRLogicEnum.NotConfigured);
					this.nullable_26 = new Doctrine.Enum55?(Doctrine.Enum55.const_4);
					this.nullable_27 = new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.NotConfigured);
					this.nullable_28 = new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.NotConfigured);
					this.nullable_29 = new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.NotConfigured);
					this.nullable_30 = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.NotConfigured);
					this.nullable_31 = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.NotConfigured);
					this.nullable_32 = new Doctrine._UseAIP?(Doctrine._UseAIP.NotConfigured);
					this.nullable_33 = new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.NotConfigured);
					this.nullable_34 = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.NotConfigured);
					this.nullable_35 = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.NotConfigured);
					this.nullable_36 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.NotConfigured);
					this.nullable_37 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.NotConfigured);
					this.nullable_38 = new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.NotConfigured);
					this.nullable_39 = new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.NotConfigured);
					this.nullable_40 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.NotConfigured);
					this.nullable_41 = new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.NotConfigured);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101000", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00129B7C File Offset: 0x00127D7C
		public Doctrine method_0(ref Doctrine doctrine_1, Class310 class310_1, ref Scenario scenario_0)
		{
			Doctrine.Class275.Enum66 enum66_;
			Doctrine.Class275.Enum66 enum66_2;
			Doctrine.Class275.Enum66 enum66_3;
			if (doctrine_1.method_7() && this.class310_0.GetType() == typeof(Waypoint))
			{
				enum66_ = Doctrine.Class275.Enum66.const_3;
				enum66_2 = Doctrine.Class275.Enum66.const_3;
				enum66_3 = Doctrine.Class275.Enum66.const_3;
			}
			else
			{
				enum66_ = doctrine_1.method_6(scenario_0).method_1();
				enum66_2 = doctrine_1.method_6(scenario_0).method_2();
				enum66_3 = doctrine_1.method_6(scenario_0).method_3();
			}
			return new Doctrine(ref scenario_0, ref class310_1, doctrine_1.nullable_6, doctrine_1.method_33(), doctrine_1.nullable_0, doctrine_1.method_65(), doctrine_1.nullable_1, doctrine_1.method_70(), doctrine_1.nullable_2, doctrine_1.method_75(), doctrine_1.nullable_3, doctrine_1.method_80(), doctrine_1.nullable_4, doctrine_1.method_149(), doctrine_1.nullable_5, doctrine_1.method_85(), doctrine_1.nullable_11, doctrine_1.method_90(), doctrine_1.nullable_12, doctrine_1.method_139(), doctrine_1.nullable_13, doctrine_1.method_144(), doctrine_1.nullable_17, doctrine_1.method_154(), doctrine_1.nullable_18, doctrine_1.method_159(), doctrine_1.nullable_19, doctrine_1.method_164(), doctrine_1.nullable_20, doctrine_1.method_169(), doctrine_1.nullable_21, doctrine_1.method_174(), doctrine_1.nullable_22, doctrine_1.method_198(), doctrine_1.nullable_23, doctrine_1.method_203(), doctrine_1.nullable_25, doctrine_1.method_213(), doctrine_1.nullable_7, doctrine_1.method_119(), doctrine_1.nullable_24, doctrine_1.method_208(), doctrine_1.nullable_8, doctrine_1.method_124(), doctrine_1.nullable_9, doctrine_1.method_129(), doctrine_1.nullable_10, doctrine_1.method_134(), doctrine_1.nullable_26, doctrine_1.method_218(), doctrine_1.nullable_27, doctrine_1.method_242(), doctrine_1.nullable_28, doctrine_1.method_248(), doctrine_1.nullable_29, doctrine_1.method_254(), doctrine_1.nullable_30, doctrine_1.method_260(), doctrine_1.nullable_31, doctrine_1.method_266(), doctrine_1.nullable_32, doctrine_1.method_272(), doctrine_1.nullable_33, doctrine_1.method_278(), doctrine_1.nullable_34, doctrine_1.method_95(), doctrine_1.nullable_35, doctrine_1.method_98(), doctrine_1.nullable_36, doctrine_1.method_101(), doctrine_1.nullable_37, doctrine_1.method_104(), doctrine_1.nullable_38, doctrine_1.method_107(), doctrine_1.nullable_39, doctrine_1.method_110(), doctrine_1.nullable_40, doctrine_1.method_113(), doctrine_1.nullable_41, doctrine_1.method_116(), enum66_, enum66_2, enum66_3, doctrine_1.method_7(), doctrine_1.nullable_14, doctrine_1.method_179(), doctrine_1.nullable_15, doctrine_1.method_184(), doctrine_1.nullable_16, doctrine_1.method_189());
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00129E3C File Offset: 0x0012803C
		public Doctrine(ref Scenario scenario_0, ref Class310 class310_1, Doctrine.Enum65? nullable_42, bool bool_35, Doctrine.Enum52? nullable_43, bool bool_36, Doctrine.Enum52? nullable_44, bool bool_37, Doctrine.Enum52? nullable_45, bool bool_38, Doctrine.Enum52? nullable_46, bool bool_39, Doctrine._GunStrafeGroundTargets? nullable_47, bool bool_40, Doctrine.Enum64? nullable_48, bool bool_41, Doctrine.Enum51? nullable_49, bool bool_42, Doctrine.Enum61? nullable_50, bool bool_43, Doctrine.Enum62? nullable_51, bool bool_44, Doctrine.Enum56? nullable_52, bool bool_45, Doctrine.Enum57? nullable_53, bool bool_46, Doctrine.Enum59? nullable_54, bool bool_47, Doctrine.Enum58? nullable_55, bool bool_48, Doctrine.Enum60? nullable_56, bool bool_49, Doctrine.Enum53? nullable_57, bool bool_50, Doctrine.Enum54? nullable_58, bool bool_51, Doctrine._WeaponState? nullable_59, bool bool_52, Doctrine._WeaponStateRTB? nullable_60, bool bool_53, Doctrine._FuelState? nullable_61, bool bool_54, Doctrine._FuelStateRTB? nullable_62, bool bool_55, Doctrine._JettisonOrdnance? nullable_63, bool bool_56, Doctrine._BVRLogicEnum? nullable_64, bool bool_57, Doctrine.Enum55? nullable_65, bool bool_58, Doctrine._RefuelAlliedUnits? nullable_66, bool bool_59, Doctrine._AvoidContactWhenPossible? nullable_67, bool bool_60, Doctrine._DiveOnContact? nullable_68, bool bool_61, Doctrine._RechargeBatteryPercentage? nullable_69, bool bool_62, Doctrine._RechargeBatteryPercentage? nullable_70, bool bool_63, Doctrine._UseAIP? nullable_71, bool bool_64, Doctrine._UseDippingSonar? nullable_72, bool bool_65, Doctrine._DamageThreshold? nullable_73, bool bool_66, Doctrine._FuelQuantityThreshold? nullable_74, bool bool_67, Doctrine._WeaponQuantityThreshold? nullable_75, bool bool_68, Doctrine._WeaponQuantityThreshold? nullable_76, bool bool_69, Doctrine._DamageThreshold? nullable_77, bool bool_70, Doctrine._FuelQuantityThreshold? nullable_78, bool bool_71, Doctrine._WeaponQuantityThreshold? nullable_79, bool bool_72, Doctrine._WeaponQuantityThreshold? nullable_80, bool bool_73, Doctrine.Class275.Enum66 enum66_0, Doctrine.Class275.Enum66 enum66_1, Doctrine.Class275.Enum66 enum66_2, bool bool_74, Doctrine.Enum63? nullable_81, bool bool_75, Doctrine.Enum63? nullable_82, bool bool_76, Doctrine.Enum63? nullable_83, bool bool_77)
		{
			try
			{
				this.class310_0 = class310_1;
				if (bool_35)
				{
					this.nullable_6 = null;
				}
				else
				{
					this.nullable_6 = nullable_42;
				}
				if (bool_36)
				{
					this.nullable_0 = null;
				}
				else
				{
					this.nullable_0 = nullable_43;
				}
				if (bool_37)
				{
					this.nullable_1 = null;
				}
				else
				{
					this.nullable_1 = nullable_44;
				}
				if (bool_38)
				{
					this.nullable_2 = null;
				}
				else
				{
					this.nullable_2 = nullable_45;
				}
				if (bool_39)
				{
					this.nullable_3 = null;
				}
				else
				{
					this.nullable_3 = nullable_46;
				}
				if (bool_40)
				{
					this.nullable_4 = null;
				}
				else
				{
					this.nullable_4 = nullable_47;
				}
				if (bool_41)
				{
					this.nullable_5 = null;
				}
				else
				{
					this.nullable_5 = nullable_48;
				}
				if (bool_42)
				{
					this.nullable_11 = null;
				}
				else
				{
					this.nullable_11 = nullable_49;
				}
				if (bool_43)
				{
					this.nullable_12 = null;
				}
				else
				{
					this.nullable_12 = nullable_50;
				}
				if (bool_44)
				{
					this.nullable_13 = null;
				}
				else
				{
					this.nullable_13 = nullable_51;
				}
				if (bool_75)
				{
					this.nullable_14 = null;
				}
				else
				{
					this.nullable_14 = nullable_81;
				}
				if (bool_76)
				{
					this.nullable_15 = null;
				}
				else
				{
					this.nullable_15 = nullable_82;
				}
				if (bool_77)
				{
					this.nullable_16 = null;
				}
				else
				{
					this.nullable_16 = nullable_83;
				}
				if (bool_45)
				{
					this.nullable_17 = null;
				}
				else
				{
					this.nullable_17 = nullable_52;
				}
				if (bool_46)
				{
					this.nullable_18 = null;
				}
				else
				{
					this.nullable_18 = nullable_53;
				}
				if (bool_47)
				{
					this.nullable_19 = null;
				}
				else
				{
					this.nullable_19 = nullable_54;
				}
				if (bool_48)
				{
					this.nullable_20 = null;
				}
				else
				{
					this.nullable_20 = nullable_55;
				}
				if (bool_49)
				{
					this.nullable_21 = null;
				}
				else
				{
					this.nullable_21 = nullable_56;
				}
				if (bool_50)
				{
					this.nullable_22 = null;
				}
				else
				{
					this.nullable_22 = nullable_57;
				}
				if (bool_51)
				{
					this.nullable_23 = null;
				}
				else
				{
					this.nullable_23 = nullable_58;
				}
				if (bool_52)
				{
					this.nullable_25 = null;
				}
				else
				{
					this.nullable_25 = nullable_59;
				}
				if (bool_53)
				{
					this.nullable_7 = null;
				}
				else
				{
					this.nullable_7 = nullable_60;
				}
				if (bool_54)
				{
					this.nullable_24 = null;
				}
				else
				{
					this.nullable_24 = nullable_61;
				}
				if (bool_55)
				{
					this.nullable_8 = null;
				}
				else
				{
					this.nullable_8 = nullable_62;
				}
				if (bool_56)
				{
					this.nullable_9 = null;
				}
				else
				{
					this.nullable_9 = nullable_63;
				}
				if (bool_57)
				{
					this.nullable_10 = null;
				}
				else
				{
					this.nullable_10 = nullable_64;
				}
				if (bool_58)
				{
					this.nullable_26 = null;
				}
				else
				{
					this.nullable_26 = nullable_65;
				}
				if (bool_59)
				{
					this.nullable_27 = null;
				}
				else
				{
					this.nullable_27 = nullable_66;
				}
				if (bool_60)
				{
					this.nullable_28 = null;
				}
				else
				{
					this.nullable_28 = nullable_67;
				}
				if (bool_61)
				{
					this.nullable_29 = null;
				}
				else
				{
					this.nullable_29 = nullable_68;
				}
				if (bool_62)
				{
					this.nullable_30 = null;
				}
				else
				{
					this.nullable_30 = nullable_69;
				}
				if (bool_63)
				{
					this.nullable_31 = null;
				}
				else
				{
					this.nullable_31 = nullable_70;
				}
				if (bool_64)
				{
					this.nullable_32 = null;
				}
				else
				{
					this.nullable_32 = nullable_71;
				}
				if (bool_65)
				{
					this.nullable_33 = null;
				}
				else
				{
					this.nullable_33 = nullable_72;
				}
				if (bool_66)
				{
					this.nullable_34 = null;
				}
				else
				{
					this.nullable_34 = nullable_73;
				}
				if (bool_67)
				{
					this.nullable_35 = null;
				}
				else
				{
					this.nullable_35 = nullable_74;
				}
				if (bool_68)
				{
					this.nullable_36 = null;
				}
				else
				{
					this.nullable_36 = nullable_75;
				}
				if (bool_69)
				{
					this.nullable_37 = null;
				}
				else
				{
					this.nullable_37 = nullable_76;
				}
				if (bool_70)
				{
					this.nullable_38 = null;
				}
				else
				{
					this.nullable_38 = nullable_77;
				}
				if (bool_71)
				{
					this.nullable_39 = null;
				}
				else
				{
					this.nullable_39 = nullable_78;
				}
				if (bool_72)
				{
					this.nullable_40 = null;
				}
				else
				{
					this.nullable_40 = nullable_79;
				}
				if (bool_73)
				{
					this.nullable_41 = null;
				}
				else
				{
					this.nullable_41 = nullable_80;
				}
				if (bool_74)
				{
					this.method_8(bool_74);
				}
				else
				{
					this.method_8(bool_74);
					this.method_192(enum66_0, scenario_0);
					this.method_193(enum66_1, scenario_0);
					this.method_194(enum66_2, scenario_0);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101306", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0012A324 File Offset: 0x00128524
		public void method_1(Class310 class310_1, bool? nullable_42, bool bool_35, bool bool_36, bool bool_37, bool bool_38)
		{
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(class310_1, nullable_42, bool_35, bool_36, bool_37, bool_38);
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0012A34C File Offset: 0x0012854C
		public void method_2(Class310 class310_1, bool? nullable_42, bool bool_35, bool bool_36, bool bool_37, bool bool_38)
		{
			Doctrine.Delegate29 @delegate = Doctrine.delegate29_0;
			if (@delegate != null)
			{
				@delegate(class310_1, nullable_42, bool_35, bool_36, bool_37, bool_38);
			}
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0012A374 File Offset: 0x00128574
		public Doctrine method_3(Scenario scenario_0, ref bool bool_35)
		{
			checked
			{
				Doctrine result;
				try
				{
					if (this.doctrine_0 == null)
					{
						try
						{
							if (!bool_35 && this.class310_0.bool_0)
							{
								ActiveUnit activeUnit = (ActiveUnit)this.class310_0;
								if (activeUnit.bool_3)
								{
									Aircraft aircraft = (Aircraft)activeUnit;
									if (!aircraft.vmethod_127())
									{
										Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
										if (aircraft_AirOps.method_30() != null)
										{
											return aircraft_AirOps.method_30().doctrine_0;
										}
									}
								}
								else if (activeUnit.bool_6)
								{
								}
							}
							if (this.class310_0.bool_1)
							{
								Group group = (Group)this.class310_0;
								if (group.vmethod_101() != null && group.vmethod_101().method_12())
								{
									if (group.method_147() != null && group.method_147().vmethod_86().bool_2)
									{
										if (group.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
										{
											this.doctrine_0 = ((Strike)group.vmethod_101()).doctrine_1;
										}
										else
										{
											this.doctrine_0 = group.vmethod_101().doctrine_0;
										}
									}
									else
									{
										this.doctrine_0 = group.vmethod_101().doctrine_0;
									}
								}
								else
								{
									this.doctrine_0 = group.vmethod_7(false).doctrine_0;
								}
							}
							else if (this.class310_0.bool_0)
							{
								ActiveUnit activeUnit2 = (ActiveUnit)this.class310_0;
								if (activeUnit2.method_120())
								{
									this.doctrine_0 = activeUnit2.vmethod_65(false).doctrine_0;
								}
								else if (activeUnit2.vmethod_101() != null && activeUnit2.vmethod_101().method_12())
								{
									if (activeUnit2.vmethod_86().bool_2 && activeUnit2.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
									{
										this.doctrine_0 = ((Strike)activeUnit2.vmethod_101()).doctrine_1;
									}
									else
									{
										this.doctrine_0 = activeUnit2.vmethod_101().doctrine_0;
									}
								}
								else
								{
									this.doctrine_0 = activeUnit2.vmethod_7(false).doctrine_0;
								}
							}
							else if (this.class310_0.bool_9)
							{
								Mission value = (Mission)this.class310_0;
								foreach (Side side in scenario_0.method_44())
								{
									if (side.method_36(scenario_0).Contains(value))
									{
										this.doctrine_0 = side.doctrine_0;
										break;
									}
								}
							}
							else if (this.class310_0.bool_10)
							{
								Waypoint waypoint = (Waypoint)this.class310_0;
								bool flag = false;
								if (scenario_0 != null)
								{
									if (waypoint.enum79_0 == Waypoint.Enum79.const_0)
									{
										try
										{
											foreach (ActiveUnit activeUnit3 in scenario_0.method_42())
											{
												if (activeUnit3 != null && activeUnit3.vmethod_85().method_47() && Enumerable.Contains<Waypoint>(activeUnit3.vmethod_85().method_4(), waypoint))
												{
													this.doctrine_0 = activeUnit3.doctrine_0;
													IL_2D2:
													goto IL_482;
												}
											}
											goto IL_2D2;
										}
										finally
										{
											List<ActiveUnit>.Enumerator enumerator;
											((IDisposable)enumerator).Dispose();
										}
									}
									foreach (Side side2 in scenario_0.method_44())
									{
										try
										{
											foreach (Mission mission in side2.method_35())
											{
												if (mission.method_55())
												{
													try
													{
														List<Mission.Flight>.Enumerator enumerator3 = mission.list_1.GetEnumerator();
														IL_404:
														while (enumerator3.MoveNext())
														{
															Mission.Flight flight = enumerator3.Current;
															Waypoint[] array3 = flight.method_15();
															int k = 0;
															while (k < array3.Length)
															{
																Waypoint waypoint2 = array3[k];
																if (waypoint2 == waypoint)
																{
																	this.doctrine_0 = mission.doctrine_0;
																	flag = true;
																}
																else if (waypoint2.waypoint_0 == null)
																{
																	if (waypoint2.waypoint_1 == null)
																	{
																		if (waypoint2.waypoint_2 == null)
																		{
																			if (waypoint2.waypoint_3 == null)
																			{
																				if (waypoint2.waypoint_4 == null)
																				{
																					k++;
																					continue;
																				}
																				this.doctrine_0 = mission.doctrine_0;
																				flag = true;
																			}
																			else
																			{
																				this.doctrine_0 = mission.doctrine_0;
																				flag = true;
																			}
																		}
																		else
																		{
																			this.doctrine_0 = mission.doctrine_0;
																			flag = true;
																		}
																	}
																	else
																	{
																		this.doctrine_0 = mission.doctrine_0;
																		flag = true;
																	}
																}
																else
																{
																	this.doctrine_0 = mission.doctrine_0;
																	flag = true;
																}
																IL_400:
																if (!flag)
																{
																	goto IL_404;
																}
																goto IL_410;
															}
															goto IL_400;
														}
														IL_410:;
													}
													finally
													{
														List<Mission.Flight>.Enumerator enumerator3;
														((IDisposable)enumerator3).Dispose();
													}
												}
												if (flag)
												{
													break;
												}
											}
										}
										finally
										{
											IEnumerator<Mission> enumerator2;
											if (enumerator2 != null)
											{
												enumerator2.Dispose();
											}
										}
										if (flag)
										{
											break;
										}
									}
								}
							}
							else if (this.class310_0.GetType() == typeof(Side))
							{
								this.doctrine_0 = ((Side)this.class310_0).doctrine_0;
							}
							IL_482:
							if (this.list_0 != null && this.doctrine_0 == null)
							{
								Side side3 = scenario_0.method_54();
								if (side3 != null)
								{
									return side3.doctrine_0;
								}
							}
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 101171", "");
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
					}
					if (this.doctrine_0 == null && Debugger.IsAttached)
					{
						this.class310_0.GetType();
						typeof(Side);
					}
					result = this.doctrine_0;
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 101001", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = scenario_0.method_54().doctrine_0;
				}
				return result;
			}
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00009FFA File Offset: 0x000081FA
		public void method_4()
		{
			this.doctrine_0 = null;
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0012A958 File Offset: 0x00128B58
		public List<ActiveUnit> method_5(Scenario scenario_0, bool? nullable_42)
		{
			List<ActiveUnit> result;
			try
			{
				List<ActiveUnit> list = new List<ActiveUnit>();
				if (this.class310_0.GetType() == typeof(Side))
				{
					list.AddRange(((Side)this.class310_0).activeUnit_0);
				}
				else
				{
					if (this.class310_0.GetType() == typeof(Waypoint))
					{
						return new List<ActiveUnit>();
					}
					if (this.class310_0.bool_9)
					{
						try
						{
							foreach (ActiveUnit activeUnit in scenario_0.method_42())
							{
								if (activeUnit != null && activeUnit.vmethod_101() == this.class310_0)
								{
									if (nullable_42 == null)
									{
										list.Add(activeUnit);
									}
									bool? flag2;
									bool? flag = flag2 = nullable_42;
									if (((flag2 == null || flag.GetValueOrDefault()) ? (flag & activeUnit.vmethod_86().bool_2) : new bool?(false)).GetValueOrDefault())
									{
										list.Add(activeUnit);
									}
									flag = (flag2 = ((nullable_42 != null) ? new bool?(!nullable_42.GetValueOrDefault()) : nullable_42));
									if (((flag2 == null || flag.GetValueOrDefault()) ? (flag & !activeUnit.vmethod_86().bool_2) : new bool?(false)).GetValueOrDefault())
									{
										list.Add(activeUnit);
									}
								}
							}
							goto IL_1D1;
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					if (this.class310_0.bool_1)
					{
						list.AddRange(((Group)this.class310_0).vmethod_141().Values);
					}
					else if (this.list_0 != null && this.list_0.Count > 0)
					{
						list.AddRange(this.list_0);
					}
					else
					{
						list.Add((ActiveUnit)this.class310_0);
					}
				}
				IL_1D1:
				result = list;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101002", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<ActiveUnit>();
			}
			return result;
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0012ABB0 File Offset: 0x00128DB0
		public Doctrine.Class275 method_6(Scenario scenario_0)
		{
			if (this.method_7())
			{
				bool flag = true;
				Doctrine doctrine = this.method_3(scenario_0, ref flag);
				if (!Information.IsNothing(doctrine))
				{
					return doctrine.method_6(scenario_0);
				}
			}
			return this.class275_0;
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0000A003 File Offset: 0x00008203
		public bool method_7()
		{
			return Information.IsNothing(this.class275_0);
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0000A010 File Offset: 0x00008210
		public void method_8(bool bool_35)
		{
			if (!bool_35)
			{
				if (Information.IsNothing(this.class275_0))
				{
					this.class275_0 = new Doctrine.Class275();
					return;
				}
			}
			else
			{
				this.class275_0 = null;
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0012ABEC File Offset: 0x00128DEC
		public int? method_9(Scenario theScen, Weapon theWeapon, Doctrine._WRA_WeaponTargetType selectedNodeTargetType, bool FindInheritedValuesOnly, ref int? TargetType_InheritedWeaponQty = null, ref int? TargetType_UnspecifiedWeaponQty = null)
		{
			int? result;
			if (this.class310_0.GetType() != typeof(Side) && theWeapon.DBID > 0)
			{
				if (FindInheritedValuesOnly)
				{
					bool flag = true;
					TargetType_InheritedWeaponQty = this.method_3(theScen, ref flag).method_10(theScen, theWeapon, selectedNodeTargetType);
				}
				else
				{
					TargetType_InheritedWeaponQty = this.method_10(theScen, theWeapon, selectedNodeTargetType);
				}
				if (Information.IsNothing(TargetType_InheritedWeaponQty) && !this.method_29(ref selectedNodeTargetType))
				{
					Doctrine._WRA_WeaponTargetType wra_WeaponTargetType_ = this.method_30(ref selectedNodeTargetType);
					TargetType_UnspecifiedWeaponQty = this.method_10(theScen, theWeapon, wra_WeaponTargetType_);
					result = TargetType_UnspecifiedWeaponQty;
				}
				else
				{
					result = TargetType_InheritedWeaponQty;
				}
			}
			return result;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0012AC98 File Offset: 0x00128E98
		public int? method_10(Scenario scenario_0, Weapon weapon_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? num = this.method_11(weapon_0.DBID, _WRA_WeaponTargetType_0);
			if (num == null && this.class310_0.GetType() != typeof(Side))
			{
				bool flag = true;
				Doctrine doctrine = this.method_3(scenario_0, ref flag);
				if (doctrine != null)
				{
					num = doctrine.method_10(scenario_0, weapon_0, _WRA_WeaponTargetType_0);
				}
			}
			int? result;
			if (Information.IsNothing(num))
			{
				result = Doctrine.smethod_5(weapon_0, _WRA_WeaponTargetType_0);
			}
			else
			{
				result = num;
			}
			return result;
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0012AD08 File Offset: 0x00128F08
		public static int? smethod_5(Weapon weapon_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			if (_WRA_WeaponTargetType_0 == Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
			{
				_WRA_WeaponTargetType_0 = Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified;
			}
			if (!Information.IsNothing(weapon_0.doctrine_0.method_27()))
			{
				try
				{
					foreach (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair in weapon_0.doctrine_0.method_27())
					{
						foreach (Doctrine.Class276 @class in keyValuePair.Value.class276_0)
						{
							if (_WRA_WeaponTargetType_0 == @class._WRA_WeaponTargetType_0)
							{
								return @class.nullable_0;
							}
						}
					}
				}
				finally
				{
					Dictionary<int, Doctrine.WRA_Weapon>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			return null;
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0000A035 File Offset: 0x00008235
		public int? method_11(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			return this.method_12(int_0, _WRA_WeaponTargetType_0);
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0012ADC0 File Offset: 0x00128FC0
		private int? method_12(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? result;
			if (Information.IsNothing(this.dictionary_0))
			{
				result = null;
			}
			else if (!this.dictionary_0.ContainsKey(int_0))
			{
				result = null;
			}
			else
			{
				Doctrine.WRA_Weapon wra_Weapon = new Doctrine.WRA_Weapon();
				this.dictionary_0.TryGetValue(int_0, out wra_Weapon);
				if (!Information.IsNothing(wra_Weapon))
				{
					foreach (Doctrine.Class276 @class in wra_Weapon.class276_0)
					{
						if (@class._WRA_WeaponTargetType_0 == _WRA_WeaponTargetType_0)
						{
							return @class.nullable_0;
						}
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0012AE54 File Offset: 0x00129054
		public int? method_13(Scenario theScen, Weapon theWeapon, Doctrine._WRA_WeaponTargetType selectedNodeTargetType, bool FindInheritedValuesOnly, ref int? TargetType_InheritedShooterQty = null, ref int? TargetType_UnspecifiedShooterQty = null)
		{
			int? result;
			if (this.class310_0.GetType() != typeof(Side) && theWeapon.DBID > 0)
			{
				if (FindInheritedValuesOnly)
				{
					bool flag = true;
					TargetType_InheritedShooterQty = this.method_3(theScen, ref flag).method_14(theScen, theWeapon, selectedNodeTargetType);
				}
				else
				{
					TargetType_InheritedShooterQty = this.method_14(theScen, theWeapon, selectedNodeTargetType);
				}
				if (Information.IsNothing(TargetType_InheritedShooterQty) && !this.method_29(ref selectedNodeTargetType))
				{
					Doctrine._WRA_WeaponTargetType wra_WeaponTargetType_ = this.method_30(ref selectedNodeTargetType);
					TargetType_UnspecifiedShooterQty = this.method_14(theScen, theWeapon, wra_WeaponTargetType_);
					result = TargetType_UnspecifiedShooterQty;
				}
				else
				{
					result = TargetType_InheritedShooterQty;
				}
			}
			return result;
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0012AF00 File Offset: 0x00129100
		public int? method_14(Scenario scenario_0, Weapon weapon_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? num = this.method_16(weapon_0.DBID, _WRA_WeaponTargetType_0);
			if (Information.IsNothing(num) && this.class310_0.GetType() != typeof(Side))
			{
				bool flag = true;
				Doctrine doctrine = this.method_3(scenario_0, ref flag);
				if (!Information.IsNothing(doctrine))
				{
					num = doctrine.method_14(scenario_0, weapon_0, _WRA_WeaponTargetType_0);
				}
			}
			int? result;
			if (Information.IsNothing(num))
			{
				result = this.method_15(weapon_0, _WRA_WeaponTargetType_0);
			}
			else
			{
				result = num;
			}
			return result;
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0012AF78 File Offset: 0x00129178
		public int? method_15(Weapon weapon_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			if (!Information.IsNothing(weapon_0.doctrine_0.method_27()))
			{
				try
				{
					foreach (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair in weapon_0.doctrine_0.method_27())
					{
						foreach (Doctrine.Class276 @class in keyValuePair.Value.class276_0)
						{
							if (_WRA_WeaponTargetType_0 == @class._WRA_WeaponTargetType_0)
							{
								return @class.nullable_1;
							}
						}
					}
				}
				finally
				{
					Dictionary<int, Doctrine.WRA_Weapon>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			return null;
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0000A03F File Offset: 0x0000823F
		public int? method_16(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			return this.method_17(int_0, _WRA_WeaponTargetType_0);
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0012B020 File Offset: 0x00129220
		private int? method_17(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? result;
			if (Information.IsNothing(this.dictionary_0))
			{
				result = null;
			}
			else if (!this.dictionary_0.ContainsKey(int_0))
			{
				result = null;
			}
			else
			{
				Doctrine.WRA_Weapon wra_Weapon = new Doctrine.WRA_Weapon();
				this.dictionary_0.TryGetValue(int_0, out wra_Weapon);
				if (!Information.IsNothing(wra_Weapon))
				{
					foreach (Doctrine.Class276 @class in wra_Weapon.class276_0)
					{
						if (@class._WRA_WeaponTargetType_0 == _WRA_WeaponTargetType_0)
						{
							return @class.nullable_1;
						}
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0012B0B4 File Offset: 0x001292B4
		public int? method_18(Scenario theScen, Weapon theWeapon, Doctrine._WRA_WeaponTargetType selectedNodeTargetType, bool FindInheritedValuesOnly, ref int? TargetType_InheriteSelfDefenceRange = null, ref int? TargetType_UnspecifiedSelfDefenceRange = null)
		{
			int? result;
			if (this.class310_0.GetType() != typeof(Side) && theWeapon.DBID > 0)
			{
				if (FindInheritedValuesOnly)
				{
					bool flag = true;
					TargetType_InheriteSelfDefenceRange = this.method_3(theScen, ref flag).method_19(theScen, theWeapon, selectedNodeTargetType);
				}
				else
				{
					TargetType_InheriteSelfDefenceRange = this.method_19(theScen, theWeapon, selectedNodeTargetType);
				}
				if (Information.IsNothing(TargetType_InheriteSelfDefenceRange) && !this.method_29(ref selectedNodeTargetType))
				{
					Doctrine._WRA_WeaponTargetType wra_WeaponTargetType_ = this.method_30(ref selectedNodeTargetType);
					TargetType_UnspecifiedSelfDefenceRange = this.method_19(theScen, theWeapon, wra_WeaponTargetType_);
					result = TargetType_UnspecifiedSelfDefenceRange;
				}
				else
				{
					result = TargetType_InheriteSelfDefenceRange;
				}
			}
			return result;
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0012B160 File Offset: 0x00129360
		public int? method_19(Scenario scenario_0, Weapon weapon_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? num = this.method_21(weapon_0.DBID, _WRA_WeaponTargetType_0);
			if (Information.IsNothing(num) && this.class310_0.GetType() != typeof(Side))
			{
				bool flag = true;
				Doctrine doctrine = this.method_3(scenario_0, ref flag);
				if (!Information.IsNothing(doctrine))
				{
					num = doctrine.method_19(scenario_0, weapon_0, _WRA_WeaponTargetType_0);
				}
			}
			int? result;
			if (Information.IsNothing(num))
			{
				result = this.method_20(weapon_0, _WRA_WeaponTargetType_0);
			}
			else
			{
				result = num;
			}
			return result;
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0012B1D8 File Offset: 0x001293D8
		public int? method_20(Weapon weapon_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			if (!Information.IsNothing(weapon_0.doctrine_0.method_27()))
			{
				try
				{
					foreach (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair in weapon_0.doctrine_0.method_27())
					{
						foreach (Doctrine.Class276 @class in keyValuePair.Value.class276_0)
						{
							if (_WRA_WeaponTargetType_0 == @class._WRA_WeaponTargetType_0)
							{
								return @class.nullable_3;
							}
						}
					}
				}
				finally
				{
					Dictionary<int, Doctrine.WRA_Weapon>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			return null;
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0000A049 File Offset: 0x00008249
		public int? method_21(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			return this.method_22(int_0, _WRA_WeaponTargetType_0);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0012B280 File Offset: 0x00129480
		private int? method_22(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? result;
			if (Information.IsNothing(this.dictionary_0))
			{
				result = null;
			}
			else if (!this.dictionary_0.ContainsKey(int_0))
			{
				result = null;
			}
			else
			{
				Doctrine.WRA_Weapon wra_Weapon = new Doctrine.WRA_Weapon();
				this.dictionary_0.TryGetValue(int_0, out wra_Weapon);
				if (!Information.IsNothing(wra_Weapon))
				{
					foreach (Doctrine.Class276 @class in wra_Weapon.class276_0)
					{
						if (@class._WRA_WeaponTargetType_0 == _WRA_WeaponTargetType_0)
						{
							return @class.nullable_3;
						}
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0012B314 File Offset: 0x00129514
		public int? method_23(Scenario theScen, int theWeaponDBID, Doctrine._WRA_WeaponTargetType selectedNodeTargetType, bool FindInheritedValuesOnly, ref int? TargetType_InheritedFiringRange = null, ref int? TargetType_UnspecifiedFiringRange = null)
		{
			int? result;
			if (this.class310_0.GetType() != typeof(Side) && theWeaponDBID > 0)
			{
				if (FindInheritedValuesOnly)
				{
					bool flag = true;
					TargetType_InheritedFiringRange = this.method_3(theScen, ref flag).method_24(theScen, theWeaponDBID, selectedNodeTargetType);
				}
				else
				{
					TargetType_InheritedFiringRange = this.method_24(theScen, theWeaponDBID, selectedNodeTargetType);
				}
				if (Information.IsNothing(TargetType_InheritedFiringRange) && !this.method_29(ref selectedNodeTargetType))
				{
					Doctrine._WRA_WeaponTargetType wra_WeaponTargetType_ = this.method_30(ref selectedNodeTargetType);
					TargetType_UnspecifiedFiringRange = this.method_24(theScen, theWeaponDBID, wra_WeaponTargetType_);
					result = TargetType_UnspecifiedFiringRange;
				}
				else
				{
					result = TargetType_InheritedFiringRange;
				}
			}
			return result;
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0012B3B8 File Offset: 0x001295B8
		public int? method_24(Scenario scenario_0, int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? num = this.method_25(int_0, _WRA_WeaponTargetType_0);
			if (Information.IsNothing(num) && this.class310_0.GetType() != typeof(Side))
			{
				bool flag = true;
				Doctrine doctrine = this.method_3(scenario_0, ref flag);
				if (!Information.IsNothing(doctrine))
				{
					num = doctrine.method_24(scenario_0, int_0, _WRA_WeaponTargetType_0);
				}
			}
			return num;
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0000A053 File Offset: 0x00008253
		public int? method_25(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			return this.method_26(int_0, _WRA_WeaponTargetType_0);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0012B414 File Offset: 0x00129614
		private int? method_26(int int_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			int? result;
			if (Information.IsNothing(this.dictionary_0))
			{
				result = null;
			}
			else if (!this.dictionary_0.ContainsKey(int_0))
			{
				result = null;
			}
			else
			{
				Doctrine.WRA_Weapon wra_Weapon = new Doctrine.WRA_Weapon();
				this.dictionary_0.TryGetValue(int_0, out wra_Weapon);
				if (!Information.IsNothing(wra_Weapon))
				{
					foreach (Doctrine.Class276 @class in wra_Weapon.class276_0)
					{
						if (@class._WRA_WeaponTargetType_0 == _WRA_WeaponTargetType_0)
						{
							return @class.nullable_2;
						}
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0000A05D File Offset: 0x0000825D
		public Dictionary<int, Doctrine.WRA_Weapon> method_27()
		{
			return this.dictionary_0;
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0000A065 File Offset: 0x00008265
		public void method_28(Dictionary<int, Doctrine.WRA_Weapon> dictionary_1)
		{
			this.dictionary_0 = dictionary_1;
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0012B4A8 File Offset: 0x001296A8
		public static Doctrine._WRA_WeaponTargetType smethod_6(ref Weapon weapon_0, ref Contact contact_0, ref Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			Doctrine._WRA_WeaponTargetType result;
			if (weapon_0.class394_0.bool_5)
			{
				result = Doctrine._WRA_WeaponTargetType.Radar_Unspecified;
			}
			else if (weapon_0.class394_0.bool_1 && _WRA_WeaponTargetType_0 == Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
			{
				result = Doctrine._WRA_WeaponTargetType.Submarine_Unspecified;
			}
			else if (weapon_0.class394_0.bool_9 && contact_0.contactType_0 == Contact_Base.ContactType.Torpedo)
			{
				result = Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type;
			}
			else
			{
				if (contact_0.contactType_0 == Contact_Base.ContactType.Decoy_Air && contact_0.method_68().Count > 0)
				{
					try
					{
						foreach (KeyValuePair<int, EmissionContainer> keyValuePair in contact_0.method_68())
						{
							if (keyValuePair.Value.method_0(keyValuePair.Key, weapon_0.scenario_0).method_72())
							{
								return Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified;
							}
						}
					}
					finally
					{
						IEnumerator<KeyValuePair<int, EmissionContainer>> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				result = _WRA_WeaponTargetType_0;
			}
			return result;
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0012B594 File Offset: 0x00129794
		public static Doctrine._WRA_WeaponTargetType smethod_7(ref Contact contact_0)
		{
			Doctrine._WRA_WeaponTargetType result;
			if (contact_0.method_125() == Contact_Base.IdentificationStatus.Unknown)
			{
				result = Doctrine._WRA_WeaponTargetType.None;
			}
			else
			{
				if (contact_0.method_125() >= Contact_Base.IdentificationStatus.KnownType)
				{
					if (contact_0.activeUnit_0 != null)
					{
						ActiveUnit activeUnit_ = contact_0.activeUnit_0;
						switch (contact_0.contactType_0)
						{
						case Contact_Base.ContactType.Air:
						{
							if (activeUnit_.bool_2 && ((Weapon)activeUnit_).method_208())
							{
								return Doctrine._WRA_WeaponTargetType.Decoy;
							}
							Aircraft aircraft = (Aircraft)activeUnit_;
							if (aircraft.method_169() && aircraft._AircraftType_0 != Aircraft._AircraftType.UAV && aircraft._AircraftType_0 != Aircraft._AircraftType.UCAV)
							{
								return Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified;
							}
							Aircraft._AircraftType aircraftType_ = aircraft._AircraftType_0;
							if (aircraftType_ <= Aircraft._AircraftType.CAS)
							{
								if (aircraftType_ <= Aircraft._AircraftType.WildWeasel)
								{
									if (aircraftType_ - Aircraft._AircraftType.Fighter > 1 && aircraftType_ - Aircraft._AircraftType.Attack > 1)
									{
										goto IL_225;
									}
								}
								else if (aircraftType_ != Aircraft._AircraftType.Bomber)
								{
									if (aircraftType_ != Aircraft._AircraftType.CAS)
									{
										goto IL_225;
									}
								}
								else
								{
									if ((double)aircraft.float_25 >= 2.0)
									{
										return Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers;
									}
									if ((double)aircraft.float_25 >= 1.5)
									{
										return Doctrine._WRA_WeaponTargetType.Aircraft_Medium_Perf_Bombers;
									}
									if ((double)aircraft.float_25 >= 1.0)
									{
										return Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Bombers;
									}
									goto IL_A02;
								}
								if ((double)aircraft.float_25 >= 5.0)
								{
									return Doctrine._WRA_WeaponTargetType.Aircraft_5th_Generation;
								}
								if ((double)aircraft.float_25 >= 4.0)
								{
									return Doctrine._WRA_WeaponTargetType.Aircraft_4th_Generation;
								}
								if ((double)aircraft.float_25 >= 3.0)
								{
									return Doctrine._WRA_WeaponTargetType.Aircraft_3rd_Generation;
								}
								if ((double)aircraft.float_25 >= 2.0)
								{
									return Doctrine._WRA_WeaponTargetType.Aircraft_Less_Capable;
								}
								goto IL_A02;
							}
							else
							{
								if (aircraftType_ <= Aircraft._AircraftType.AirborneCP)
								{
									if (aircraftType_ != Aircraft._AircraftType.OECM)
									{
										if (aircraftType_ - Aircraft._AircraftType.AEW <= 1)
										{
											return Doctrine._WRA_WeaponTargetType.Aircraft_AEW;
										}
										goto IL_225;
									}
								}
								else if (aircraftType_ - Aircraft._AircraftType.Recon > 2)
								{
									if (aircraftType_ - Aircraft._AircraftType.UAV > 1)
									{
										goto IL_225;
									}
									if (aircraft.int_1 <= 10)
									{
										return Doctrine._WRA_WeaponTargetType.Aircraft_MicroUAV;
									}
									return Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified;
								}
								if ((double)aircraft.float_25 >= 4.0)
								{
									return Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW;
								}
								if ((double)aircraft.float_25 >= 3.0)
								{
									return Doctrine._WRA_WeaponTargetType.Aircraft_Medium_Perf_Recon_EW;
								}
								if ((double)aircraft.float_25 >= 2.0)
								{
									return Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Recon_EW;
								}
								goto IL_A02;
							}
							IL_225:
							return Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified;
						}
						case Contact_Base.ContactType.Missile:
							if (((Weapon)activeUnit_).vmethod_3())
							{
								return Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic;
							}
							if (!contact_0.bool_17)
							{
								return Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified;
							}
							if (contact_0.vmethod_40() > 600f)
							{
								if (contact_0.bool_19 && contact_0.vmethod_14(false) <= 30.48f)
								{
									return Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic_Sea_Skimming;
								}
								return Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic;
							}
							else
							{
								if (contact_0.bool_19 && contact_0.vmethod_14(false) <= 30.48f)
								{
									return Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic_Sea_Skimming;
								}
								return Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic;
							}
							break;
						case Contact_Base.ContactType.Surface:
						{
							Ship ship = (Ship)activeUnit_;
							switch (ship.enum118_0)
							{
							case Ship.Enum118.const_2:
							case Ship.Enum118.const_8:
								if (ship.imethod_6() >= 95001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Carrier_95000_tons;
								}
								if (ship.imethod_6() >= 45001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Carrier_45001_95000_tons;
								}
								if (ship.imethod_6() >= 25001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Carrier_25001_45000_tons;
								}
								return Doctrine._WRA_WeaponTargetType.Ship_Carrier_0_25000_tons;
							case Ship.Enum118.const_1:
							case Ship.Enum118.const_7:
								if (ship.imethod_6() >= 95001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_95000_tons;
								}
								if (ship.imethod_6() >= 45001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_45001_95000_tons;
								}
								if (ship.imethod_6() >= 25001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_25001_45000_tons;
								}
								if (ship.imethod_6() >= 10001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_10001_25000_tons;
								}
								if (ship.imethod_6() >= 5001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_5001_10000_tons;
								}
								if (ship.imethod_6() >= 1501f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_1501_5000_tons;
								}
								if (ship.imethod_6() >= 501f)
								{
									Ship._ShipType shipType_ = ship._ShipType_0;
									if (shipType_ - Ship._ShipType.DE > 2 && shipType_ - Ship._ShipType.F > 3)
									{
										return Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_501_1500_tons;
									}
									return Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_1501_5000_tons;
								}
								else
								{
									if (ship.imethod_6() >= 0f)
									{
										Ship._ShipType shipType_2 = ship._ShipType_0;
										if (shipType_2 <= Ship._ShipType.PGM)
										{
											if (shipType_2 == Ship._ShipType.PCFG || shipType_2 == Ship._ShipType.PGM)
											{
												goto IL_791;
											}
										}
										else
										{
											if (shipType_2 == Ship._ShipType.PHM)
											{
												goto IL_791;
											}
											if (shipType_2 == Ship._ShipType.MTB)
											{
												goto IL_791;
											}
										}
										bool flag = false;
										try
										{
											foreach (Weapon weapon in ship.method_148().method_2(false).Values)
											{
												if (weapon.method_2() && (weapon.method_196() || weapon.method_195()))
												{
													flag = true;
													break;
												}
											}
										}
										finally
										{
											Dictionary<int, Weapon>.ValueCollection.Enumerator enumerator;
											((IDisposable)enumerator).Dispose();
										}
										if (flag)
										{
											return Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_501_1500_tons;
										}
										return Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons;
										IL_791:
										return Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_501_1500_tons;
									}
									goto IL_A02;
								}
								break;
							case Ship.Enum118.const_3:
								if (ship.imethod_6() >= 95001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons;
								}
								if (ship.imethod_6() >= 45001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Amphibious_45001_95000_tons;
								}
								if (ship.imethod_6() >= 25001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Amphibious_25001_45000_tons;
								}
								if (ship.imethod_6() >= 10001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Amphibious_10001_25000_tons;
								}
								if (ship.imethod_6() >= 5001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Amphibious_5001_10000_tons;
								}
								if (ship.imethod_6() >= 1501f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Amphibious_1501_5000_tons;
								}
								if (ship.imethod_6() >= 501f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Amphibious_501_1500_tons;
								}
								if (ship.imethod_6() >= 0f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons;
								}
								goto IL_A02;
							case Ship.Enum118.const_4:
								if (ship.imethod_6() >= 95001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_95000_tons;
								}
								if (ship.imethod_6() >= 45001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_45001_95000_tons;
								}
								if (ship.imethod_6() >= 25001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_25001_45000_tons;
								}
								if (ship.imethod_6() >= 10001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_10001_25000_tons;
								}
								if (ship.imethod_6() >= 5001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_5001_10000_tons;
								}
								if (ship.imethod_6() >= 1501f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_1501_5000_tons;
								}
								if (ship.imethod_6() >= 501f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_501_1500_tons;
								}
								if (ship.imethod_6() >= 0f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons;
								}
								goto IL_A02;
							case Ship.Enum118.const_5:
							case Ship.Enum118.const_6:
								if (ship.imethod_6() >= 95001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_95000_tons;
								}
								if (ship.imethod_6() >= 45001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_45001_95000_tons;
								}
								if (ship.imethod_6() >= 25001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_25001_45000_tons;
								}
								if (ship.imethod_6() >= 10001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_10001_25000_tons;
								}
								if (ship.imethod_6() >= 5001f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_5001_10000_tons;
								}
								if (ship.imethod_6() >= 1501f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_1501_5000_tons;
								}
								if (ship.imethod_6() >= 501f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_501_1500_tons;
								}
								if (ship.imethod_6() >= 0f)
								{
									return Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons;
								}
								goto IL_A02;
							default:
								return Doctrine._WRA_WeaponTargetType.Ship_Unspecified;
							}
							break;
						}
						case Contact_Base.ContactType.Submarine:
							if (((Submarine)activeUnit_).method_161())
							{
								return Doctrine._WRA_WeaponTargetType.Submarine_Surfaced;
							}
							return Doctrine._WRA_WeaponTargetType.Submarine_Unspecified;
						case Contact_Base.ContactType.Orbital:
							return Doctrine._WRA_WeaponTargetType.Satellite_Unspecified;
						case Contact_Base.ContactType.Facility_Fixed:
						case Contact_Base.ContactType.Facility_Mobile:
						{
							Facility facility = (Facility)activeUnit_;
							Facility._FacilityCategory facilityCategory_ = facility._FacilityCategory_0;
							if (facilityCategory_ <= Facility._FacilityCategory.Underwater)
							{
								switch (facilityCategory_)
								{
								case Facility._FacilityCategory.Runway:
									return Doctrine._WRA_WeaponTargetType.Runway;
								case Facility._FacilityCategory.RunwayGrade_Taxiway:
									return Doctrine._WRA_WeaponTargetType.Runway_Grade_Taxiway;
								case Facility._FacilityCategory.RunwayAccessPoint:
									return Doctrine._WRA_WeaponTargetType.Runway_Access_Point;
								default:
									switch (facilityCategory_)
									{
									case Facility._FacilityCategory.Building_Surface:
										if (facility.armorRating_0 >= GlobalVariables.ArmorRating.Light)
										{
											return Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Surface;
										}
										return Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface;
									case Facility._FacilityCategory.Building_Reveted:
										if (facility.armorRating_0 >= GlobalVariables.ArmorRating.Light)
										{
											return Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Reveted;
										}
										return Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted;
									case Facility._FacilityCategory.Building_Bunker:
										return Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Bunker;
									case Facility._FacilityCategory.Building_Underground:
										return Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Underground;
									case Facility._FacilityCategory.Structure_Open:
										if (facility.armorRating_0 >= GlobalVariables.ArmorRating.Light)
										{
											return Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Open;
										}
										return Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open;
									case Facility._FacilityCategory.Structure_Reveted:
										if (facility.armorRating_0 >= GlobalVariables.ArmorRating.Light)
										{
											return Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted;
										}
										return Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted;
									default:
										if (facilityCategory_ == Facility._FacilityCategory.Underwater)
										{
											return Doctrine._WRA_WeaponTargetType.Underwater_Structure;
										}
										break;
									}
									break;
								}
							}
							else if (facilityCategory_ <= Facility._FacilityCategory.Mobile_Personnel)
							{
								if (facilityCategory_ == Facility._FacilityCategory.Mobile_Vehicle)
								{
									return Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Mobile_Vehicle;
								}
								if (facilityCategory_ == Facility._FacilityCategory.Mobile_Personnel)
								{
									return Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel;
								}
							}
							else
							{
								if (facilityCategory_ == Facility._FacilityCategory.AerostatMooring)
								{
									return Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified;
								}
								if (facilityCategory_ == Facility._FacilityCategory.AirBase)
								{
									return Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified;
								}
							}
							if (facility.armorRating_0 >= GlobalVariables.ArmorRating.Light)
							{
								return Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified;
							}
							return Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified;
						}
						case Contact_Base.ContactType.Torpedo:
							return Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type;
						}
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw new NotImplementedException();
					}
					return Doctrine._WRA_WeaponTargetType.None;
				}
				IL_A02:
				if (contact_0.method_125() >= Contact_Base.IdentificationStatus.KnownDomain)
				{
					if (contact_0.activeUnit_0 != null)
					{
						ActiveUnit activeUnit_2 = contact_0.activeUnit_0;
						switch (contact_0.contactType_0)
						{
						case Contact_Base.ContactType.Air:
							return Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type;
						case Contact_Base.ContactType.Missile:
							if (activeUnit_2.vmethod_3())
							{
								return Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic;
							}
							if (!contact_0.bool_17)
							{
								return Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified;
							}
							if (contact_0.vmethod_40() > 600f)
							{
								if (contact_0.bool_19 && contact_0.vmethod_14(false) <= 30.48f)
								{
									return Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic_Sea_Skimming;
								}
								return Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic;
							}
							else
							{
								if (contact_0.bool_19 && contact_0.vmethod_14(false) <= 30.48f)
								{
									return Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic_Sea_Skimming;
								}
								return Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic;
							}
							break;
						case Contact_Base.ContactType.Surface:
							return Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type;
						case Contact_Base.ContactType.Submarine:
							if (((Submarine)activeUnit_2).method_161())
							{
								return Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type;
							}
							return Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type;
						case Contact_Base.ContactType.Orbital:
							return Doctrine._WRA_WeaponTargetType.Satellite_Unspecified;
						case Contact_Base.ContactType.Facility_Fixed:
						case Contact_Base.ContactType.Facility_Mobile:
							return Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type;
						case Contact_Base.ContactType.Torpedo:
							return Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type;
						case Contact_Base.ContactType.Decoy_Air:
						case Contact_Base.ContactType.Decoy_Surface:
						case Contact_Base.ContactType.Decoy_Land:
						case Contact_Base.ContactType.Decoy_Sub:
							return Doctrine._WRA_WeaponTargetType.Decoy;
						}
						throw new NotImplementedException();
					}
					result = Doctrine._WRA_WeaponTargetType.None;
				}
				else
				{
					result = Doctrine._WRA_WeaponTargetType.None;
				}
			}
			return result;
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0012C120 File Offset: 0x0012A320
		public bool method_29(ref Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			Doctrine._WRA_WeaponTargetType wra_WeaponTargetType = _WRA_WeaponTargetType_0;
			if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified)
			{
				if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified)
				{
					if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type <= 1)
					{
						return true;
					}
					if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
					{
						return true;
					}
					if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified)
					{
						return true;
					}
				}
				else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Unspecified)
				{
					if (wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type <= 1)
					{
						return true;
					}
				}
				else
				{
					if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type <= 1)
					{
						return true;
					}
					if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type <= 1)
					{
						return true;
					}
				}
			}
			else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Radar_Unspecified)
			{
				if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified)
				{
					return true;
				}
				if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified)
				{
					return true;
				}
				if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Radar_Unspecified)
				{
					return true;
				}
			}
			else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified)
			{
				if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified)
				{
					return true;
				}
				if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified)
				{
					return true;
				}
			}
			else
			{
				if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Underwater_Structure)
				{
					return true;
				}
				if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0012C224 File Offset: 0x0012A424
		public Doctrine._WRA_WeaponTargetType method_30(ref Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			Doctrine._WRA_WeaponTargetType wra_WeaponTargetType = _WRA_WeaponTargetType_0;
			if (wra_WeaponTargetType > Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons)
			{
				if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted)
				{
					if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_95000_tons)
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons > 7 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons > 7)
						{
							goto IL_138;
						}
						goto IL_EA;
					}
					else
					{
						if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
						{
							goto IL_EA;
						}
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface > 1 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open > 1)
						{
							goto IL_138;
						}
					}
				}
				else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted)
				{
					if (wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring)
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Surface <= 5)
						{
							return Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified;
						}
						goto IL_138;
					}
				}
				else
				{
					if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Runway <= 2)
					{
						return Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified;
					}
					if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Vehicle <= 1)
					{
						return Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified;
					}
					if (wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Mobile_Vehicle)
					{
						goto IL_138;
					}
					return Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified;
				}
				return Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified;
			}
			if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_MicroUAV)
			{
				if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Bombers)
				{
					if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_5th_Generation > 3 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers > 2)
					{
						goto IL_138;
					}
				}
				else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW > 2 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_AEW > 1)
				{
					goto IL_138;
				}
				return Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified;
			}
			if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
			{
				if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic_Sea_Skimming > 3 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
				{
					goto IL_138;
				}
				return Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified;
			}
			else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Carrier_0_25000_tons > 3 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons > 7 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons > 7)
			{
				goto IL_138;
			}
			IL_EA:
			return Doctrine._WRA_WeaponTargetType.Ship_Unspecified;
			IL_138:
			return Doctrine._WRA_WeaponTargetType.None;
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0012C388 File Offset: 0x0012A588
		public Doctrine.Enum65? method_31(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine.Enum65? result;
			try
			{
				if (this.method_33())
				{
					Doctrine doctrine;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.method_3(scenario_0, ref flag);
					}
					result = doctrine.method_31(scenario_0, bool_35, bool_36, bool_37);
				}
				else
				{
					result = new Doctrine.Enum65?(this.nullable_6.Value);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200447", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine.Enum65?(Doctrine.Enum65.const_0);
			}
			return result;
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0012C424 File Offset: 0x0012A624
		public void method_32(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine.Enum65? nullable_42)
		{
			this.nullable_6 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0000A06E File Offset: 0x0000826E
		public bool method_33()
		{
			return this.nullable_6 == null;
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0012C45C File Offset: 0x0012A65C
		public bool method_34(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_6;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_34(scenario_0);
			}
			return result;
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0012C49C File Offset: 0x0012A69C
		public void method_35(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_6 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_35(scenario_0, bool_35);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0012C4DC File Offset: 0x0012A6DC
		public void method_36(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum65? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "GRANTED - use nuclear weapons";
			string text2 = "NOT GRANTED - do not use nuclear weapons";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum65? @enum = this.method_3(scenario_0, ref flag).method_31(scenario_0, false, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text2
						});
					}
				}
				Doctrine.Enum65? enum2 = this.method_31(scenario_0, false, false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0012C85C File Offset: 0x0012AA5C
		public void method_37(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum52? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "FREE - fire at any contact not positively identified as friendly";
			string text2 = "TIGHT - fire only at contacts positively identified as hostile";
			string text3 = "HOLD - do not fire except in self defence (manual only)";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum52? @enum = this.method_3(scenario_0, ref flag).method_63(scenario_0, false, null, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text3
							});
						}
					}
				}
				Doctrine.Enum52? enum2 = this.method_63(scenario_0, false, new bool?(false), false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0012CD18 File Offset: 0x0012AF18
		public void method_38(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum52? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "FREE - fire at any contact not positively identified as friendly";
			string text2 = "TIGHT - fire only at contacts positively identified as hostile";
			string text3 = "HOLD - do not fire except in self defence (manual only)";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum52? @enum = this.method_3(scenario_0, ref flag).method_68(scenario_0, false, null, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text3
							});
						}
					}
				}
				Doctrine.Enum52? enum2 = this.method_68(scenario_0, false, new bool?(false), false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0012D1D4 File Offset: 0x0012B3D4
		public void method_39(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum52? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "FREE - fire at any contact not positively identified as friendly";
			string text2 = "TIGHT - fire only at contacts positively identified as hostile";
			string text3 = "HOLD - do not fire except in self defence (manual only)";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum52? @enum = this.method_3(scenario_0, ref flag).method_73(scenario_0, false, null, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text3
							});
						}
					}
				}
				Doctrine.Enum52? enum2 = this.method_73(scenario_0, false, new bool?(false), false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0012D690 File Offset: 0x0012B890
		public void method_40(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum52? nullable_42)
		{
			try
			{
				if (!dataTable_0.Columns.Contains("ID"))
				{
					dataTable_0.Columns.Add("ID", typeof(int));
				}
				if (!dataTable_0.Columns.Contains("Description"))
				{
					dataTable_0.Columns.Add("Description", typeof(string));
				}
				string text = "FREE - fire at any contact not positively identified as friendly";
				string text2 = "TIGHT - fire only at contacts positively identified as hostile";
				string text3 = "HOLD - do not fire except in self defence (manual only)";
				dataTable_0.Rows.Add(new object[]
				{
					0,
					text
				});
				dataTable_0.Rows.Add(new object[]
				{
					1,
					text2
				});
				dataTable_0.Rows.Add(new object[]
				{
					2,
					text3
				});
				if (this.class310_0.GetType() != typeof(Side))
				{
					byte? b;
					if (!Information.IsNothing(nullable_42))
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, " + text2
								});
							}
							else
							{
								b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										3,
										"Inherited, " + text3
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										3,
										"Inherited, Various"
									});
								}
							}
						}
					}
					else
					{
						bool flag = true;
						Doctrine.Enum52? @enum = this.method_3(scenario_0, ref flag).method_78(scenario_0, false, null, false, false);
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text
							});
						}
						else
						{
							b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, " + text2
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, " + text3
								});
							}
						}
					}
					Doctrine.Enum52? enum2 = this.method_78(scenario_0, false, new bool?(false), false, false);
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"Various"
						});
					}
					if (this.class310_0.GetType() == typeof(Waypoint))
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"Not configured"
						});
					}
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0012DB84 File Offset: 0x0012BD84
		public void method_41(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum64? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Yes";
			string text2 = "No";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum64? @enum = this.method_3(scenario_0, ref flag).method_83(scenario_0, false, null, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text2
						});
					}
				}
				Doctrine.Enum64? enum2 = this.method_83(scenario_0, false, new bool?(false), false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0012DF14 File Offset: 0x0012C114
		public void method_42(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._WeaponStateRTB? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Yes, aircraft leave flight and return to base (RTB) as they reach weapon state";
			string text2 = "Yes, RTB when the first aircraft in a flight reaches weapon state";
			string text3 = "Yes, RTB when the last aircraft in a flight reaches weapon state";
			string text4 = "No, aircraft do not RTB when weapon state is reached";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"Inherited, " + text3
								});
							}
							else
							{
								b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"Inherited, " + text4
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"Inherited, Various"
									});
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._WeaponStateRTB? weaponStateRTB = this.method_3(scenario_0, ref flag).method_117(scenario_0, false, false, false);
					b = ((weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"Inherited, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"Inherited, " + text4
								});
							}
						}
					}
				}
				Doctrine._WeaponStateRTB? weaponStateRTB2 = this.method_117(scenario_0, false, false, false);
				b = ((weaponStateRTB2 != null) ? new byte?((byte)weaponStateRTB2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0012E4EC File Offset: 0x0012C6EC
		public void method_43(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._FuelStateRTB? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Yes, units leave group and return to base (RTB) as they reach fuel state";
			string text2 = "Yes, when first unit in flight reaches fuel state";
			string text3 = "Yes, when last unit in flight reached fuel state (WARNING: Not recommended!)";
			string text4 = "No, units do not RTB when fuel state is reached";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"Inherited, " + text3
								});
							}
							else
							{
								b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"Inherited, " + text4
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"Inherited, Various"
									});
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._FuelStateRTB? fuelStateRTB = this.method_3(scenario_0, ref flag).method_122(scenario_0, false, false, false);
					b = ((fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"Inherited, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"Inherited, " + text4
								});
							}
						}
					}
				}
				Doctrine._FuelStateRTB? fuelStateRTB2 = this.method_122(scenario_0, false, false, false);
				b = ((fuelStateRTB2 != null) ? new byte?((byte)fuelStateRTB2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0012EAC4 File Offset: 0x0012CCC4
		public void method_44(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._JettisonOrdnance? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Jettison ordnance when under attack";
			string text2 = "No";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._JettisonOrdnance? jettisonOrdnance = this.method_3(scenario_0, ref flag).method_127(scenario_0, false, false, false);
					b = ((jettisonOrdnance != null) ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text2
						});
					}
				}
				Doctrine._JettisonOrdnance? jettisonOrdnance2 = this.method_127(scenario_0, false, false, false);
				b = ((jettisonOrdnance2 != null) ? new byte?((byte)jettisonOrdnance2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x0012EE44 File Offset: 0x0012D044
		public void method_45(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._BVRLogicEnum? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Follow missile straight-in";
			string text2 = "Crank if possible";
			string text3 = "Crank and drag if possible";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				if (!Information.IsNothing(nullable_42))
				{
					byte? b = (nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
						return;
					}
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text2
						});
						return;
					}
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text3
						});
						return;
					}
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Inherited, Various"
					});
					return;
				}
				else
				{
					bool flag = true;
					Doctrine._BVRLogicEnum? bvrlogicEnum = this.method_3(scenario_0, ref flag).method_132(scenario_0, false, false, false);
					byte? b = (bvrlogicEnum != null) ? new byte?((byte)bvrlogicEnum.GetValueOrDefault()) : null;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((bvrlogicEnum != null) ? new byte?((byte)bvrlogicEnum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((bvrlogicEnum != null) ? new byte?((byte)bvrlogicEnum.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, " + text3
								});
							}
						}
					}
					Doctrine._BVRLogicEnum? bvrlogicEnum2 = this.method_132(scenario_0, false, false, false);
					b = ((bvrlogicEnum2 != null) ? new byte?((byte)bvrlogicEnum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"Various"
						});
					}
					if (this.class310_0.GetType() == typeof(Waypoint))
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"Not configured"
						});
					}
				}
			}
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0012F330 File Offset: 0x0012D530
		public void method_46(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum51? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Ignore";
			string text2 = "Optimistic";
			string text3 = "Pessimistic";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum51? @enum = this.method_3(scenario_0, ref flag).method_88(scenario_0, false, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text3
							});
						}
					}
				}
				Doctrine.Enum51? enum2 = this.method_88(scenario_0, false, false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0012F7DC File Offset: 0x0012D9DC
		private void method_47(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum61? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Yes";
			string text2 = "No";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum61? @enum = this.method_3(scenario_0, ref flag).method_137(scenario_0, false, true, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text2
						});
					}
				}
				Doctrine.Enum61? enum2 = this.method_137(scenario_0, false, true, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0012FB5C File Offset: 0x0012DD5C
		public void method_48(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum62? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Yes";
			string text2 = "No";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum62? @enum = this.method_3(scenario_0, ref flag).method_142(scenario_0, false, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text2
						});
					}
				}
				Doctrine.Enum62? enum2 = this.method_142(scenario_0, false, false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0012FEDC File Offset: 0x0012E0DC
		public void method_49(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum63? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Shortest Route";
			string text2 = "Deep Water Navigation, 1525m+ (5000ft+)";
			string text3 = "Littoral Navigation, 200m (660ft)";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum63? @enum = this.method_3(scenario_0, ref flag).method_177(scenario_0, false, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text3
							});
						}
					}
				}
				Doctrine.Enum63? enum2 = this.method_177(scenario_0, false, false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 6) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00130388 File Offset: 0x0012E588
		public void method_50(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum63? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Shortest Route";
			string text2 = "Deep Water Navigation, 1525m+ (5000ft+)";
			string text3 = "CZ";
			string text4 = "Littoral";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"Inherited, " + text3
								});
							}
							else
							{
								b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"Inherited, " + text4
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"Inherited, Various"
									});
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum63? @enum = this.method_3(scenario_0, ref flag).method_182(scenario_0, false, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"Inherited, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"Inherited, " + text4
								});
							}
						}
					}
				}
				Doctrine.Enum63? enum2 = this.method_182(scenario_0, false, false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 6) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00130960 File Offset: 0x0012EB60
		public void method_51(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum63? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Shortest Route";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"Inherited, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"Inherited, Various"
						});
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum63? @enum = this.method_3(scenario_0, ref flag).method_187(scenario_0, false, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"Inherited, " + text
						});
					}
				}
				Doctrine.Enum63? enum2 = this.method_187(scenario_0, false, false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 6) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						2,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						2,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00130C0C File Offset: 0x0012EE0C
		public void method_52(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._GunStrafeGroundTargets? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Yes (except for loadouts with Stand-Off weapons)";
			string text2 = "No";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = this.method_3(scenario_0, ref flag).method_147(scenario_0, false, false, false);
					b = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text2
						});
					}
				}
				Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets2 = this.method_147(scenario_0, false, false, false);
				b = ((gunStrafeGroundTargets2 != null) ? new byte?((byte)gunStrafeGroundTargets2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00130F8C File Offset: 0x0012F18C
		public void method_53(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum56? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Allow";
			string text2 = "Allow, but not tankers refuelling tankers";
			string text3 = "Not allowed";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum56? @enum = this.method_3(scenario_0, ref flag).method_152(scenario_0, false, false, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text3
							});
						}
					}
				}
				Doctrine.Enum56? enum2 = this.method_152(scenario_0, false, false, false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00131438 File Offset: 0x0012F638
		public void method_54(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum57? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Pick nearest";
			string text2 = "Pick tankers between us and objective (target or station, or base if RTB)";
			string text3 = "Give priority to tankers between us and objective (target or station, or base if RTB), but allow turning back";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum57? @enum = this.method_3(scenario_0, ref flag).method_157(scenario_0, false, false, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text3
							});
						}
					}
				}
				Doctrine.Enum57? enum2 = this.method_157(scenario_0, false, false, false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
			}
			if (this.class310_0.GetType() == typeof(Waypoint))
			{
				dataTable_0.Rows.Add(new object[]
				{
					4,
					"Not configured"
				});
			}
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x001318E4 File Offset: 0x0012FAE4
		public void method_55(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum59? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Yes (engage any contacts)";
			string text2 = "No (engage mission-specific contacts only)";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum59? @enum = this.method_3(scenario_0, ref flag).method_162(scenario_0, false, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text2
						});
					}
				}
				Doctrine.Enum59? enum2 = this.method_162(scenario_0, false, false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00131C64 File Offset: 0x0012FE64
		public void method_56(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum58? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Yes, use SASS (Surface-to-Air in Surface-to-Surface) mode";
			string text2 = "No";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum58? @enum = this.method_3(scenario_0, ref flag).method_167(scenario_0, false, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text2
						});
					}
				}
				Doctrine.Enum58? enum2 = this.method_167(scenario_0, false, false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00131FE4 File Offset: 0x001301E4
		public void method_57(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum60? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Yes";
			string text2 = "No";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum60? @enum = this.method_3(scenario_0, ref flag).method_172(scenario_0, false, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text2
						});
					}
				}
				Doctrine.Enum60? enum2 = this.method_172(scenario_0, false, false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00132364 File Offset: 0x00130564
		public void method_58(ref DataTable dataTable_0, Scenario scenario_0, bool bool_35, Doctrine.Enum53? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Yes";
			string text2 = "Fighter and ASW loadout";
			string text3 = "No";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					Doctrine.Enum53? @enum = this.method_3(scenario_0, ref bool_35).method_196(scenario_0, false, true, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text3
							});
						}
					}
				}
				Doctrine.Enum53? enum2 = this.method_196(scenario_0, false, true, false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00132810 File Offset: 0x00130A10
		private void method_59(ref DataTable dataTable_0, Scenario scenario_0, bool bool_35, Doctrine.Enum54? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Surge";
			string text2 = "Sustained";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					Doctrine.Enum54? @enum = this.method_3(scenario_0, ref bool_35).method_201(scenario_0, false, true, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text2
						});
					}
				}
				Doctrine.Enum54? enum2 = this.method_201(scenario_0, false, true, false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00132B90 File Offset: 0x00130D90
		public void method_60(ref DataTable dataTable_0, Scenario scenario_0, bool bool_35, Doctrine._WeaponState? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Use loadout setting";
			string text2 = "Winchester: Mission-specific weapons have been expended. Disengage immediately";
			string text3 = "Winchester: Mission-specific weapons have been expended. Allow targets of opportunity with air-to-air guns. PREFERRED!";
			string text4 = "Shotgun: All BVR or Stand-Off weapons have been expended. Disengage immediately";
			string text5 = "Shotgun: All BVR or Stand-Off weapons have been expended. Allow easy targets of opportunity with WVR or Strike weapons. No air-to-air guns";
			string text6 = "Shotgun: All BVR or Stand-Off weapons have been expended. Allow easy targets of opportunity with WVR or Strike weapons, and air-to-air guns";
			string text7 = "Shotgun: One engagement with BVR or Stand-Off weapons. Disengage immediately";
			string text8 = "Shotgun: One engagement with BVR or Stand-Off weapons. Allow easy targets of opportunity with WVR or Strike weapons. No air-to-air guns. PREFERRED!";
			string text9 = "Shotgun: One engagement with BVR or Stand-Off weapons. Allow easy targets of opportunity with WVR or Strike weapon, and air-to-air guns";
			string text10 = "Shotgun: One engagement with both BVR and WVR or Stand-Off and Strike weapons. No air-to-air guns.";
			string text11 = "Shotgun: One engagement with both BVR and WVR or Stand-Off and Strike weapons. Allow easy targets of opportunity with air-to-air guns. PREFERRED!";
			string text12 = "Shotgun: One engagement with WVR or Strike weapons. Disengage immediately";
			string text13 = "Shotgun: One engagement with WVR or Strike weapons. Allow targets of opportunity with air-to-air guns. PREFERRED!";
			string text14 = "Shotgun: One engagement with guns";
			string text15 = "Shotgun: 25% of relevant weapons have been expended. Disengage immediately";
			string text16 = "Shotgun: 25% of relevant weapons have been expended. Allow targets of opportunity, including air-to-air guns";
			string text17 = "Shotgun: 50% of relevant weapons have been expended. Disengage immediately";
			string text18 = "Shotgun: 50% of relevant weapons have been expended. Allow targets of opportunity, including air-to-air guns";
			string text19 = "Shotgun: 75% of relevant weapons have been expended. Disengage immediately";
			string text20 = "Shotgun: 75% of relevant weapons have been expended. Allow targets of opportunity, including air-to-air guns";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				text6
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				text7
			});
			dataTable_0.Rows.Add(new object[]
			{
				7,
				text8
			});
			dataTable_0.Rows.Add(new object[]
			{
				8,
				text9
			});
			dataTable_0.Rows.Add(new object[]
			{
				9,
				text10
			});
			dataTable_0.Rows.Add(new object[]
			{
				10,
				text11
			});
			dataTable_0.Rows.Add(new object[]
			{
				11,
				text12
			});
			dataTable_0.Rows.Add(new object[]
			{
				12,
				text13
			});
			dataTable_0.Rows.Add(new object[]
			{
				13,
				text14
			});
			dataTable_0.Rows.Add(new object[]
			{
				14,
				text15
			});
			dataTable_0.Rows.Add(new object[]
			{
				15,
				text16
			});
			dataTable_0.Rows.Add(new object[]
			{
				16,
				text17
			});
			dataTable_0.Rows.Add(new object[]
			{
				17,
				text18
			});
			dataTable_0.Rows.Add(new object[]
			{
				18,
				text19
			});
			dataTable_0.Rows.Add(new object[]
			{
				19,
				text20
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				int? num;
				if (!Information.IsNothing(nullable_42))
				{
					num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							20,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2001) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								20,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2002) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									20,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3001) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										20,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 3002) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											20,
											"Inherited, " + text5
										});
									}
									else
									{
										num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 3003) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												20,
												"Inherited, " + text6
											});
										}
										else
										{
											num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 5001) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													20,
													"Inherited, " + text7
												});
											}
											else
											{
												num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
												if (((num != null) ? new bool?(num.GetValueOrDefault() == 5002) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														20,
														"Inherited, " + text8
													});
												}
												else
												{
													num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
													if (((num != null) ? new bool?(num.GetValueOrDefault() == 5003) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															20,
															"Inherited, " + text9
														});
													}
													else
													{
														num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
														if (((num != null) ? new bool?(num.GetValueOrDefault() == 5005) : null).GetValueOrDefault())
														{
															dataTable_0.Rows.Add(new object[]
															{
																20,
																"Inherited, " + text10
															});
														}
														else
														{
															num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
															if (((num != null) ? new bool?(num.GetValueOrDefault() == 5006) : null).GetValueOrDefault())
															{
																dataTable_0.Rows.Add(new object[]
																{
																	20,
																	"Inherited, " + text11
																});
															}
															else
															{
																num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
																if (((num != null) ? new bool?(num.GetValueOrDefault() == 5011) : null).GetValueOrDefault())
																{
																	dataTable_0.Rows.Add(new object[]
																	{
																		20,
																		"Inherited, " + text12
																	});
																}
																else
																{
																	num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
																	if (((num != null) ? new bool?(num.GetValueOrDefault() == 5012) : null).GetValueOrDefault())
																	{
																		dataTable_0.Rows.Add(new object[]
																		{
																			20,
																			"Inherited, " + text13
																		});
																	}
																	else
																	{
																		num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
																		if (((num != null) ? new bool?(num.GetValueOrDefault() == 5021) : null).GetValueOrDefault())
																		{
																			dataTable_0.Rows.Add(new object[]
																			{
																				20,
																				"Inherited, " + text14
																			});
																		}
																		else
																		{
																			num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
																			if (((num != null) ? new bool?(num.GetValueOrDefault() == 4001) : null).GetValueOrDefault())
																			{
																				dataTable_0.Rows.Add(new object[]
																				{
																					20,
																					"Inherited, " + text15
																				});
																			}
																			else
																			{
																				num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
																				if (((num != null) ? new bool?(num.GetValueOrDefault() == 4002) : null).GetValueOrDefault())
																				{
																					dataTable_0.Rows.Add(new object[]
																					{
																						20,
																						"Inherited, " + text16
																					});
																				}
																				else
																				{
																					num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
																					if (((num != null) ? new bool?(num.GetValueOrDefault() == 4011) : null).GetValueOrDefault())
																					{
																						dataTable_0.Rows.Add(new object[]
																						{
																							20,
																							"Inherited, " + text17
																						});
																					}
																					else
																					{
																						num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
																						if (((num != null) ? new bool?(num.GetValueOrDefault() == 4012) : null).GetValueOrDefault())
																						{
																							dataTable_0.Rows.Add(new object[]
																							{
																								20,
																								"Inherited, " + text18
																							});
																						}
																						else
																						{
																							num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
																							if (((num != null) ? new bool?(num.GetValueOrDefault() == 4021) : null).GetValueOrDefault())
																							{
																								dataTable_0.Rows.Add(new object[]
																								{
																									20,
																									"Inherited, " + text19
																								});
																							}
																							else
																							{
																								num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
																								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4022) : null).GetValueOrDefault())
																								{
																									dataTable_0.Rows.Add(new object[]
																									{
																										20,
																										"Inherited, " + text20
																									});
																								}
																								else
																								{
																									dataTable_0.Rows.Add(new object[]
																									{
																										20,
																										"Inherited, Various"
																									});
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					Doctrine._WeaponState? weaponState = this.method_3(scenario_0, ref bool_35).method_211(scenario_0, false, true, false, false);
					num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							20,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2001) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								20,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2002) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									20,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3001) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										20,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 3002) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											20,
											"Inherited, " + text5
										});
									}
									else
									{
										num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 3003) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												20,
												"Inherited, " + text6
											});
										}
										else
										{
											num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 5001) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													20,
													"Inherited, " + text7
												});
											}
											else
											{
												num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
												if (((num != null) ? new bool?(num.GetValueOrDefault() == 5002) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														20,
														"Inherited, " + text8
													});
												}
												else
												{
													num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
													if (((num != null) ? new bool?(num.GetValueOrDefault() == 5003) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															20,
															"Inherited, " + text9
														});
													}
													else
													{
														num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
														if (((num != null) ? new bool?(num.GetValueOrDefault() == 5005) : null).GetValueOrDefault())
														{
															dataTable_0.Rows.Add(new object[]
															{
																20,
																"Inherited, " + text10
															});
														}
														else
														{
															num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
															if (((num != null) ? new bool?(num.GetValueOrDefault() == 5006) : null).GetValueOrDefault())
															{
																dataTable_0.Rows.Add(new object[]
																{
																	20,
																	"Inherited, " + text11
																});
															}
															else
															{
																num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																if (((num != null) ? new bool?(num.GetValueOrDefault() == 5011) : null).GetValueOrDefault())
																{
																	dataTable_0.Rows.Add(new object[]
																	{
																		20,
																		"Inherited, " + text12
																	});
																}
																else
																{
																	num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																	if (((num != null) ? new bool?(num.GetValueOrDefault() == 5012) : null).GetValueOrDefault())
																	{
																		dataTable_0.Rows.Add(new object[]
																		{
																			20,
																			"Inherited, " + text13
																		});
																	}
																	else
																	{
																		num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																		if (((num != null) ? new bool?(num.GetValueOrDefault() == 5021) : null).GetValueOrDefault())
																		{
																			dataTable_0.Rows.Add(new object[]
																			{
																				20,
																				"Inherited, " + text14
																			});
																		}
																		else
																		{
																			num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																			if (((num != null) ? new bool?(num.GetValueOrDefault() == 4001) : null).GetValueOrDefault())
																			{
																				dataTable_0.Rows.Add(new object[]
																				{
																					20,
																					"Inherited, " + text15
																				});
																			}
																			else
																			{
																				num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																				if (((num != null) ? new bool?(num.GetValueOrDefault() == 4002) : null).GetValueOrDefault())
																				{
																					dataTable_0.Rows.Add(new object[]
																					{
																						20,
																						"Inherited, " + text16
																					});
																				}
																				else
																				{
																					num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																					if (((num != null) ? new bool?(num.GetValueOrDefault() == 4011) : null).GetValueOrDefault())
																					{
																						dataTable_0.Rows.Add(new object[]
																						{
																							20,
																							"Inherited, " + text17
																						});
																					}
																					else
																					{
																						num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																						if (((num != null) ? new bool?(num.GetValueOrDefault() == 4012) : null).GetValueOrDefault())
																						{
																							dataTable_0.Rows.Add(new object[]
																							{
																								20,
																								"Inherited, " + text18
																							});
																						}
																						else
																						{
																							num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																							if (((num != null) ? new bool?(num.GetValueOrDefault() == 4021) : null).GetValueOrDefault())
																							{
																								dataTable_0.Rows.Add(new object[]
																								{
																									20,
																									"Inherited, " + text19
																								});
																							}
																							else
																							{
																								dataTable_0.Rows.Add(new object[]
																								{
																									20,
																									"Inherited, " + text20
																								});
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Doctrine._WeaponState? weaponState2 = this.method_211(scenario_0, false, true, false, false);
				num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						21,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						21,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x001344F4 File Offset: 0x001326F4
		public void method_61(ref DataTable dataTable_0, Scenario scenario_0, bool bool_35, Doctrine._FuelState? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Bingo: terminate mission and return to base with planned reserve fuel";
			string text2 = "Joker: terminate mission and return to base with 10% of mission fuel remaining (i.e. 10% above Bingo)";
			string text3 = "Joker: 20% above Bingo";
			string text4 = "Joker: 25% above Bingo";
			string text5 = "Joker: 30% above Bingo";
			string text6 = "Joker: 40% above Bingo";
			string text7 = "Joker: 50% above Bingo";
			string text8 = "Joker: 60% above Bingo";
			string text9 = "Joker: 70% above Bingo";
			string text10 = "Joker: 75% above Bingo";
			string text11 = "Joker: 80% above Bingo";
			string text12 = "Joker: 90% above Bingo";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				text6
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				text7
			});
			dataTable_0.Rows.Add(new object[]
			{
				7,
				text8
			});
			dataTable_0.Rows.Add(new object[]
			{
				8,
				text9
			});
			dataTable_0.Rows.Add(new object[]
			{
				9,
				text10
			});
			dataTable_0.Rows.Add(new object[]
			{
				10,
				text11
			});
			dataTable_0.Rows.Add(new object[]
			{
				11,
				text12
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							12,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								12,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									12,
									"Inherited, " + text3
								});
							}
							else
							{
								b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										12,
										"Inherited, " + text4
									});
								}
								else
								{
									b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											12,
											"Inherited, " + text5
										});
									}
									else
									{
										b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
										if (((b != null) ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												12,
												"Inherited, " + text6
											});
										}
										else
										{
											b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
											if (((b != null) ? new bool?(b.GetValueOrDefault() == 6) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													12,
													"Inherited, " + text7
												});
											}
											else
											{
												b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
												if (((b != null) ? new bool?(b.GetValueOrDefault() == 7) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														12,
														"Inherited, " + text8
													});
												}
												else
												{
													b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
													if (((b != null) ? new bool?(b.GetValueOrDefault() == 8) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															12,
															"Inherited, " + text9
														});
													}
													else
													{
														b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
														if (((b != null) ? new bool?(b.GetValueOrDefault() == 9) : null).GetValueOrDefault())
														{
															dataTable_0.Rows.Add(new object[]
															{
																12,
																"Inherited, " + text10
															});
														}
														else
														{
															b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
															if (((b != null) ? new bool?(b.GetValueOrDefault() == 10) : null).GetValueOrDefault())
															{
																dataTable_0.Rows.Add(new object[]
																{
																	12,
																	"Inherited, " + text11
																});
															}
															else
															{
																b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
																if (((b != null) ? new bool?(b.GetValueOrDefault() == 11) : null).GetValueOrDefault())
																{
																	dataTable_0.Rows.Add(new object[]
																	{
																		12,
																		"Inherited, " + text12
																	});
																}
																else
																{
																	dataTable_0.Rows.Add(new object[]
																	{
																		12,
																		"Inherited, Various"
																	});
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					Doctrine._FuelState? fuelState = this.method_3(scenario_0, ref bool_35).method_206(scenario_0, false, true, false, false);
					b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							12,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								12,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									12,
									"Inherited, " + text3
								});
							}
							else
							{
								b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										12,
										"Inherited, " + text4
									});
								}
								else
								{
									b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											12,
											"Inherited, " + text5
										});
									}
									else
									{
										b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
										if (((b != null) ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												12,
												"Inherited, " + text6
											});
										}
										else
										{
											b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
											if (((b != null) ? new bool?(b.GetValueOrDefault() == 6) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													12,
													"Inherited, " + text7
												});
											}
											else
											{
												b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
												if (((b != null) ? new bool?(b.GetValueOrDefault() == 7) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														12,
														"Inherited, " + text8
													});
												}
												else
												{
													b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
													if (((b != null) ? new bool?(b.GetValueOrDefault() == 8) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															12,
															"Inherited, " + text9
														});
													}
													else
													{
														b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
														if (((b != null) ? new bool?(b.GetValueOrDefault() == 9) : null).GetValueOrDefault())
														{
															dataTable_0.Rows.Add(new object[]
															{
																12,
																"Inherited, " + text10
															});
														}
														else
														{
															b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
															if (((b != null) ? new bool?(b.GetValueOrDefault() == 10) : null).GetValueOrDefault())
															{
																dataTable_0.Rows.Add(new object[]
																{
																	12,
																	"Inherited, " + text11
																});
															}
															else
															{
																dataTable_0.Rows.Add(new object[]
																{
																	12,
																	"Inherited, " + text12
																});
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Doctrine._FuelState? fuelState2 = this.method_206(scenario_0, false, true, false, false);
				b = ((fuelState2 != null) ? new byte?((byte)fuelState2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 12) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						13,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						13,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00135450 File Offset: 0x00133650
		private void method_62(ref DataTable dataTable_0, Scenario scenario_0, Doctrine.Enum55? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Kinematic range for automatic and manual launches";
			string text2 = "Kinematic range for manual launches only";
			string text3 = "Practical range";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine.Enum55? @enum = this.method_3(scenario_0, ref flag).method_216(scenario_0, false, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text3
							});
						}
					}
				}
				Doctrine.Enum55? enum2 = this.method_216(scenario_0, false, false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x001358FC File Offset: 0x00133AFC
		public Doctrine.Enum52? method_63(Scenario scenario_0, bool bool_35, bool? nullable_42, bool bool_36, bool bool_37)
		{
			Doctrine.Enum52? result;
			try
			{
				if (this.method_65())
				{
					bool flag = true;
					result = this.method_3(scenario_0, ref flag).method_63(scenario_0, bool_35, nullable_42, bool_36, bool_37);
				}
				else
				{
					result = new Doctrine.Enum52?(this.nullable_0.Value);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200448", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine.Enum52?(Doctrine.Enum52.const_2);
			}
			return result;
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00135990 File Offset: 0x00133B90
		public void method_64(Scenario scenario_0, bool bool_35, bool? nullable_42, bool bool_36, bool bool_37, Doctrine.Enum52? nullable_43)
		{
			this.nullable_0 = nullable_43;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, nullable_42, bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0000A07E File Offset: 0x0000827E
		public bool method_65()
		{
			return this.nullable_0 == null;
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x001359C4 File Offset: 0x00133BC4
		public bool method_66(Scenario scenario_0)
		{
			bool result;
			try
			{
				if (this.class310_0.GetType() == typeof(Side))
				{
					result = this.bool_0;
				}
				else
				{
					bool flag = true;
					result = this.method_3(scenario_0, ref flag).method_66(scenario_0);
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00135A2C File Offset: 0x00133C2C
		public void method_67(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_0 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_67(scenario_0, bool_35);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00135A6C File Offset: 0x00133C6C
		public Doctrine.Enum52? method_68(Scenario scenario_0, bool bool_35, bool? nullable_42, bool bool_36, bool bool_37)
		{
			Doctrine.Enum52? result;
			try
			{
				if (this.method_70())
				{
					bool flag = true;
					result = this.method_3(scenario_0, ref flag).method_68(scenario_0, bool_35, nullable_42, bool_36, bool_37);
				}
				else
				{
					result = new Doctrine.Enum52?(this.nullable_1.Value);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200449", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine.Enum52?(Doctrine.Enum52.const_2);
			}
			return result;
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00135B00 File Offset: 0x00133D00
		public void method_69(Scenario scenario_0, bool bool_35, bool? nullable_42, bool bool_36, bool bool_37, Doctrine.Enum52? nullable_43)
		{
			this.nullable_1 = nullable_43;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, nullable_42, bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0000A08E File Offset: 0x0000828E
		public bool method_70()
		{
			return this.nullable_1 == null;
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00135B34 File Offset: 0x00133D34
		public bool method_71(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_1;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_71(scenario_0);
			}
			return result;
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00135B74 File Offset: 0x00133D74
		public void method_72(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_1 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_72(scenario_0, bool_35);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00135BB4 File Offset: 0x00133DB4
		public Doctrine.Enum52? method_73(Scenario scenario_0, bool bool_35, bool? nullable_42, bool bool_36, bool bool_37)
		{
			Doctrine.Enum52? result;
			try
			{
				if (this.method_75())
				{
					bool flag = true;
					result = this.method_3(scenario_0, ref flag).method_73(scenario_0, bool_35, nullable_42, bool_36, bool_37);
				}
				else
				{
					result = new Doctrine.Enum52?(this.nullable_2.Value);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200450", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine.Enum52?(Doctrine.Enum52.const_2);
			}
			return result;
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00135C48 File Offset: 0x00133E48
		public void method_74(Scenario scenario_0, bool bool_35, bool? nullable_42, bool bool_36, bool bool_37, Doctrine.Enum52? nullable_43)
		{
			this.nullable_2 = nullable_43;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, nullable_42, bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0000A09E File Offset: 0x0000829E
		public bool method_75()
		{
			return this.nullable_2 == null;
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00135C7C File Offset: 0x00133E7C
		public bool method_76(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_2;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_76(scenario_0);
			}
			return result;
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00135CBC File Offset: 0x00133EBC
		public void method_77(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_2 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_77(scenario_0, bool_35);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00135CFC File Offset: 0x00133EFC
		public Doctrine.Enum52? method_78(Scenario scenario_0, bool bool_35, bool? nullable_42, bool bool_36, bool bool_37)
		{
			Doctrine.Enum52? result;
			try
			{
				if (this.method_80())
				{
					bool flag = true;
					result = this.method_3(scenario_0, ref flag).method_78(scenario_0, bool_35, nullable_42, bool_36, bool_37);
				}
				else
				{
					result = new Doctrine.Enum52?(this.nullable_3.Value);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200451", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine.Enum52?(Doctrine.Enum52.const_2);
			}
			return result;
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00135D90 File Offset: 0x00133F90
		public void method_79(Scenario scenario_0, bool bool_35, bool? nullable_42, bool bool_36, bool bool_37, Doctrine.Enum52? nullable_43)
		{
			this.nullable_3 = nullable_43;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, nullable_42, bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0000A0AE File Offset: 0x000082AE
		public bool method_80()
		{
			return this.nullable_3 == null;
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00135DC4 File Offset: 0x00133FC4
		public bool method_81(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_3;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_81(scenario_0);
			}
			return result;
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00135E04 File Offset: 0x00134004
		public void method_82(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_3 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_82(scenario_0, bool_35);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00135E44 File Offset: 0x00134044
		public Doctrine.Enum64? method_83(Scenario scenario_0, bool bool_35, bool? nullable_42, bool bool_36, bool bool_37)
		{
			Doctrine.Enum64? result;
			if (this.method_85())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_83(scenario_0, bool_35, nullable_42, bool_36, bool_37);
			}
			else
			{
				if (this.nullable_5.Value == (Doctrine.Enum64)255)
				{
					this.nullable_5 = new Doctrine.Enum64?(Doctrine.Enum64.const_1);
				}
				result = new Doctrine.Enum64?(this.nullable_5.Value);
			}
			return result;
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00135EA4 File Offset: 0x001340A4
		public void method_84(Scenario scenario_0, bool bool_35, bool? nullable_42, bool bool_36, bool bool_37, Doctrine.Enum64? nullable_43)
		{
			bool flag;
			if (this.nullable_5 == null)
			{
				flag = true;
			}
			else
			{
				byte value = (byte)this.nullable_5.Value;
				byte? b = (nullable_43 != null) ? new byte?((byte)nullable_43.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(value != b.GetValueOrDefault()) : null).GetValueOrDefault())
				{
					flag = true;
				}
			}
			this.nullable_5 = nullable_43;
			if (flag)
			{
				Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
				if (@delegate != null)
				{
					@delegate(this.class310_0, nullable_42, bool_35, bool_36, bool_37, false);
				}
			}
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0000A0BE File Offset: 0x000082BE
		public bool method_85()
		{
			return this.nullable_5 == null;
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x00135F50 File Offset: 0x00134150
		public bool method_86(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_5;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_86(scenario_0);
			}
			return result;
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00135F90 File Offset: 0x00134190
		public void method_87(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_5 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_87(scenario_0, bool_35);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00135FD0 File Offset: 0x001341D0
		public Doctrine.Enum51? method_88(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine.Enum51? result;
			if (this.method_90())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_88(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine.Enum51?(this.nullable_11.Value);
			}
			return result;
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00136010 File Offset: 0x00134210
		public void method_89(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine.Enum51? nullable_42)
		{
			this.nullable_11 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0000A0CE File Offset: 0x000082CE
		public bool method_90()
		{
			return this.nullable_11 == null;
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00136048 File Offset: 0x00134248
		public bool method_91(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_11;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_91(scenario_0);
			}
			return result;
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00136088 File Offset: 0x00134288
		public void method_92(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_11 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_92(scenario_0, bool_35);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x001360C8 File Offset: 0x001342C8
		public Doctrine._DamageThreshold? method_93(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._DamageThreshold? result;
			if (this.method_95())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_93(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine._DamageThreshold?(this.nullable_34.Value);
			}
			return result;
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00136108 File Offset: 0x00134308
		public void method_94(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._DamageThreshold? nullable_42)
		{
			this.nullable_34 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0000A0DE File Offset: 0x000082DE
		public bool method_95()
		{
			return this.nullable_34 == null;
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00136140 File Offset: 0x00134340
		public Doctrine._FuelQuantityThreshold? method_96(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._FuelQuantityThreshold? result;
			if (this.method_98())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_96(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine._FuelQuantityThreshold?(this.nullable_35.Value);
			}
			return result;
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00136180 File Offset: 0x00134380
		public void method_97(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._FuelQuantityThreshold? nullable_42)
		{
			this.nullable_35 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0000A0EE File Offset: 0x000082EE
		public bool method_98()
		{
			return this.nullable_35 == null;
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x001361B8 File Offset: 0x001343B8
		public Doctrine._WeaponQuantityThreshold? method_99(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._WeaponQuantityThreshold? result;
			if (this.method_101())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_99(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine._WeaponQuantityThreshold?(this.nullable_36.Value);
			}
			return result;
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x001361F8 File Offset: 0x001343F8
		public void method_100(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._WeaponQuantityThreshold? nullable_42)
		{
			this.nullable_36 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0000A0FE File Offset: 0x000082FE
		public bool method_101()
		{
			return this.nullable_36 == null;
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00136230 File Offset: 0x00134430
		public Doctrine._WeaponQuantityThreshold? method_102(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._WeaponQuantityThreshold? result;
			if (this.method_104())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_102(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine._WeaponQuantityThreshold?(this.nullable_37.Value);
			}
			return result;
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00136270 File Offset: 0x00134470
		public void method_103(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._WeaponQuantityThreshold? nullable_42)
		{
			this.nullable_37 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0000A10E File Offset: 0x0000830E
		public bool method_104()
		{
			return this.nullable_37 == null;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x001362A8 File Offset: 0x001344A8
		public Doctrine._DamageThreshold? method_105(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._DamageThreshold? result;
			if (this.method_107())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_105(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine._DamageThreshold?(this.nullable_38.Value);
			}
			return result;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x001362E8 File Offset: 0x001344E8
		public void method_106(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._DamageThreshold? nullable_42)
		{
			this.nullable_38 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0000A11E File Offset: 0x0000831E
		public bool method_107()
		{
			return this.nullable_38 == null;
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00136320 File Offset: 0x00134520
		public Doctrine._FuelQuantityThreshold? method_108(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._FuelQuantityThreshold? result;
			if (this.method_110())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_108(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine._FuelQuantityThreshold?(this.nullable_39.Value);
			}
			return result;
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00136360 File Offset: 0x00134560
		public void method_109(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._FuelQuantityThreshold? nullable_42)
		{
			this.nullable_39 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0000A12E File Offset: 0x0000832E
		public bool method_110()
		{
			return this.nullable_39 == null;
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00136398 File Offset: 0x00134598
		public Doctrine._WeaponQuantityThreshold? method_111(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._WeaponQuantityThreshold? result;
			if (this.method_113())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_111(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine._WeaponQuantityThreshold?(this.nullable_40.Value);
			}
			return result;
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x001363D8 File Offset: 0x001345D8
		public void method_112(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._WeaponQuantityThreshold? nullable_42)
		{
			this.nullable_40 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0000A13E File Offset: 0x0000833E
		public bool method_113()
		{
			return this.nullable_40 == null;
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00136410 File Offset: 0x00134610
		public Doctrine._WeaponQuantityThreshold? method_114(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._WeaponQuantityThreshold? result;
			if (this.method_116())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_114(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine._WeaponQuantityThreshold?(this.nullable_41.Value);
			}
			return result;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00136450 File Offset: 0x00134650
		public void method_115(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._WeaponQuantityThreshold? nullable_42)
		{
			this.nullable_41 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0000A14E File Offset: 0x0000834E
		public bool method_116()
		{
			return this.nullable_41 == null;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00136488 File Offset: 0x00134688
		public Doctrine._WeaponStateRTB? method_117(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._WeaponStateRTB? result;
			try
			{
				if (this.method_119())
				{
					bool flag = true;
					result = this.method_3(scenario_0, ref flag).method_117(scenario_0, bool_35, bool_36, bool_37);
				}
				else
				{
					result = new Doctrine._WeaponStateRTB?(this.nullable_7.Value);
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x001364F0 File Offset: 0x001346F0
		public void method_118(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._WeaponStateRTB? nullable_42)
		{
			this.nullable_7 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0000A15E File Offset: 0x0000835E
		public bool method_119()
		{
			return this.nullable_7 == null;
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00136528 File Offset: 0x00134728
		public bool method_120(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_7;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_120(scenario_0);
			}
			return result;
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00136568 File Offset: 0x00134768
		public void method_121(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_7 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_121(scenario_0, bool_35);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x001365A8 File Offset: 0x001347A8
		public Doctrine._FuelStateRTB? method_122(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._FuelStateRTB? result;
			if (this.method_124())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_122(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine._FuelStateRTB?(this.nullable_8.Value);
			}
			return result;
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x001365E8 File Offset: 0x001347E8
		public void method_123(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._FuelStateRTB? nullable_42)
		{
			this.nullable_8 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0000A16E File Offset: 0x0000836E
		public bool method_124()
		{
			return this.nullable_8 == null;
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00136620 File Offset: 0x00134820
		public bool method_125(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_8;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_125(scenario_0);
			}
			return result;
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00136660 File Offset: 0x00134860
		public void method_126(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_8 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_126(scenario_0, bool_35);
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x001366A0 File Offset: 0x001348A0
		public Doctrine._JettisonOrdnance? method_127(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._JettisonOrdnance? result;
			if (this.method_129())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_127(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine._JettisonOrdnance?(this.nullable_9.Value);
			}
			return result;
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x001366E0 File Offset: 0x001348E0
		public void method_128(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._JettisonOrdnance? nullable_42)
		{
			this.nullable_9 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0000A17E File Offset: 0x0000837E
		public bool method_129()
		{
			return this.nullable_9 == null;
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00136718 File Offset: 0x00134918
		public bool method_130(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_9;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_130(scenario_0);
			}
			return result;
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00136758 File Offset: 0x00134958
		public void method_131(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_9 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_131(scenario_0, bool_35);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00136798 File Offset: 0x00134998
		public Doctrine._BVRLogicEnum? method_132(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._BVRLogicEnum? result;
			if (this.method_134())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_132(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine._BVRLogicEnum?(this.nullable_10.Value);
			}
			return result;
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x001367D8 File Offset: 0x001349D8
		public void method_133(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._BVRLogicEnum? nullable_42)
		{
			this.nullable_10 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0000A18E File Offset: 0x0000838E
		public bool method_134()
		{
			return this.nullable_10 == null;
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00136810 File Offset: 0x00134A10
		public bool method_135(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_10;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_135(scenario_0);
			}
			return result;
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00136850 File Offset: 0x00134A50
		public void method_136(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_10 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_136(scenario_0, bool_35);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00136890 File Offset: 0x00134A90
		public Doctrine.Enum61? method_137(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine.Enum61? result;
			try
			{
				if (this.method_139())
				{
					bool flag = true;
					result = this.method_3(scenario_0, ref flag).method_137(scenario_0, bool_35, bool_36, bool_37);
				}
				else
				{
					result = new Doctrine.Enum61?(this.nullable_12.Value);
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x001368F8 File Offset: 0x00134AF8
		public void method_138(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine.Enum61? nullable_42)
		{
			this.nullable_12 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0000A19E File Offset: 0x0000839E
		public bool method_139()
		{
			return this.nullable_12 == null;
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00136930 File Offset: 0x00134B30
		public bool method_140(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_12;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_140(scenario_0);
			}
			return result;
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00136970 File Offset: 0x00134B70
		public void method_141(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_12 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_141(scenario_0, bool_35);
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x001369B0 File Offset: 0x00134BB0
		public Doctrine.Enum62? method_142(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine.Enum62? result;
			if (this.method_144())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_142(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine.Enum62?(this.nullable_13.Value);
			}
			return result;
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x001369F0 File Offset: 0x00134BF0
		public void method_143(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine.Enum62? nullable_42)
		{
			this.nullable_13 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0000A1AE File Offset: 0x000083AE
		public bool method_144()
		{
			return this.nullable_13 == null;
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00136A28 File Offset: 0x00134C28
		public bool method_145(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_13;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_145(scenario_0);
			}
			return result;
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00136A68 File Offset: 0x00134C68
		public void method_146(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_13 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_146(scenario_0, bool_35);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00136AA8 File Offset: 0x00134CA8
		public Doctrine._GunStrafeGroundTargets? method_147(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._GunStrafeGroundTargets? result;
			if (this.method_149())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_147(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine._GunStrafeGroundTargets?(this.nullable_4.Value);
			}
			return result;
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00136AE8 File Offset: 0x00134CE8
		public void method_148(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._GunStrafeGroundTargets? nullable_42)
		{
			this.nullable_4 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0000A1BE File Offset: 0x000083BE
		public bool method_149()
		{
			return this.nullable_4 == null;
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00136B20 File Offset: 0x00134D20
		public bool method_150(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_4;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_150(scenario_0);
			}
			return result;
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00136B60 File Offset: 0x00134D60
		public void method_151(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_4 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_151(scenario_0, bool_35);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00136BA0 File Offset: 0x00134DA0
		public Doctrine.Enum56? method_152(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, bool bool_38)
		{
			Doctrine.Enum56? result;
			if (this.method_154())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_152(scenario_0, bool_35, bool_36, bool_37, bool_38);
			}
			else
			{
				result = new Doctrine.Enum56?(this.nullable_17.Value);
			}
			return result;
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00136BE4 File Offset: 0x00134DE4
		public void method_153(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, bool bool_38, Doctrine.Enum56? nullable_42)
		{
			this.nullable_17 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, bool_38);
			}
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0000A1CE File Offset: 0x000083CE
		public bool method_154()
		{
			return this.nullable_17 == null;
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00136C1C File Offset: 0x00134E1C
		public bool method_155(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_17;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_155(scenario_0);
			}
			return result;
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00136C5C File Offset: 0x00134E5C
		public void method_156(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_17 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_156(scenario_0, bool_35);
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00136C9C File Offset: 0x00134E9C
		public Doctrine.Enum57? method_157(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, bool bool_38)
		{
			Doctrine.Enum57? result;
			if (this.method_159())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_157(scenario_0, bool_35, bool_36, bool_37, bool_38);
			}
			else
			{
				result = new Doctrine.Enum57?(this.nullable_18.Value);
			}
			return result;
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00136CE0 File Offset: 0x00134EE0
		public void method_158(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, bool bool_38, Doctrine.Enum57? nullable_42)
		{
			this.nullable_18 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, bool_38);
			}
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0000A1DE File Offset: 0x000083DE
		public bool method_159()
		{
			return this.nullable_18 == null;
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00136D18 File Offset: 0x00134F18
		public bool method_160(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_18;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_160(scenario_0);
			}
			return result;
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00136D58 File Offset: 0x00134F58
		public void method_161(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_18 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_161(scenario_0, bool_35);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00136D98 File Offset: 0x00134F98
		public Doctrine.Enum59? method_162(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine.Enum59? result;
			if (this.method_164())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_162(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine.Enum59?(this.nullable_19.Value);
			}
			return result;
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00136DD8 File Offset: 0x00134FD8
		public void method_163(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine.Enum59? nullable_42)
		{
			this.nullable_19 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0000A1EE File Offset: 0x000083EE
		public bool method_164()
		{
			return this.nullable_19 == null;
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00136E10 File Offset: 0x00135010
		public bool method_165(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_19;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_165(scenario_0);
			}
			return result;
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00136E50 File Offset: 0x00135050
		public void method_166(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_19 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_166(scenario_0, bool_35);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00136E90 File Offset: 0x00135090
		public Doctrine.Enum58? method_167(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine.Enum58? result;
			if (this.method_169())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_167(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine.Enum58?(this.nullable_20.Value);
			}
			return result;
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00136ED0 File Offset: 0x001350D0
		public void method_168(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine.Enum58? nullable_42)
		{
			this.nullable_20 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0000A1FE File Offset: 0x000083FE
		public bool method_169()
		{
			return this.nullable_20 == null;
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00136F08 File Offset: 0x00135108
		public bool method_170(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_20;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_170(scenario_0);
			}
			return result;
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00136F48 File Offset: 0x00135148
		public void method_171(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_20 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_171(scenario_0, bool_35);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00136F88 File Offset: 0x00135188
		public Doctrine.Enum60? method_172(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine.Enum60? result;
			if (this.method_174())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_172(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine.Enum60?(this.nullable_21.Value);
			}
			return result;
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00136FC8 File Offset: 0x001351C8
		public void method_173(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine.Enum60? nullable_42)
		{
			this.nullable_21 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0000A20E File Offset: 0x0000840E
		public bool method_174()
		{
			return this.nullable_21 == null;
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00137000 File Offset: 0x00135200
		public bool method_175(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_21;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_175(scenario_0);
			}
			return result;
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00137040 File Offset: 0x00135240
		public void method_176(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_21 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_176(scenario_0, bool_35);
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00137080 File Offset: 0x00135280
		public Doctrine.Enum63? method_177(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine.Enum63? result;
			try
			{
				if (this.method_179())
				{
					bool flag = true;
					result = this.method_3(scenario_0, ref flag).method_177(scenario_0, bool_35, bool_36, bool_37);
				}
				else
				{
					result = new Doctrine.Enum63?(this.nullable_14.Value);
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x001370F4 File Offset: 0x001352F4
		public void method_178(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine.Enum63? nullable_42)
		{
			this.nullable_14 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0000A21E File Offset: 0x0000841E
		public bool method_179()
		{
			return this.nullable_14 == null;
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0013712C File Offset: 0x0013532C
		public bool method_180(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_14;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_180(scenario_0);
			}
			return result;
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0013716C File Offset: 0x0013536C
		public void method_181(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_14 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_181(scenario_0, bool_35);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x001371AC File Offset: 0x001353AC
		public Doctrine.Enum63? method_182(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine.Enum63? result;
			if (this.method_184())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_182(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine.Enum63?(this.nullable_15.Value);
			}
			return result;
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x001371EC File Offset: 0x001353EC
		public void method_183(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine.Enum63? nullable_42)
		{
			this.nullable_15 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0000A22E File Offset: 0x0000842E
		public bool method_184()
		{
			return this.nullable_15 == null;
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00137224 File Offset: 0x00135424
		public bool method_185(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_15;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_185(scenario_0);
			}
			return result;
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00137264 File Offset: 0x00135464
		public void method_186(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_15 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_186(scenario_0, bool_35);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x001372A4 File Offset: 0x001354A4
		public Doctrine.Enum63? method_187(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine.Enum63? result;
			if (this.method_189())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_187(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine.Enum63?(this.nullable_16.Value);
			}
			return result;
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x001372E4 File Offset: 0x001354E4
		public void method_188(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine.Enum63? nullable_42)
		{
			this.nullable_16 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0000A23E File Offset: 0x0000843E
		public bool method_189()
		{
			return this.nullable_16 == null;
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0013731C File Offset: 0x0013551C
		public bool method_190(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_16;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_190(scenario_0);
			}
			return result;
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0013735C File Offset: 0x0013555C
		public void method_191(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_16 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_191(scenario_0, bool_35);
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0013739C File Offset: 0x0013559C
		public void method_192(Doctrine.Class275.Enum66 enum66_0, Scenario scenario_0)
		{
			if (this.method_7() && !Information.IsNothing(this.method_6(scenario_0)))
			{
				this.class275_0 = new Doctrine.Class275(enum66_0, this.method_6(scenario_0).method_2(), this.method_6(scenario_0).method_3());
				return;
			}
			if (Information.IsNothing(this.class275_0))
			{
				this.class275_0 = new Doctrine.Class275(enum66_0, Doctrine.Class275.Enum66.const_3, Doctrine.Class275.Enum66.const_3);
				return;
			}
			this.class275_0 = new Doctrine.Class275(enum66_0, this.class275_0.method_2(), this.class275_0.method_3());
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x00137424 File Offset: 0x00135624
		public void method_193(Doctrine.Class275.Enum66 enum66_0, Scenario scenario_0)
		{
			if (this.method_7() && !Information.IsNothing(this.method_6(scenario_0)))
			{
				this.class275_0 = new Doctrine.Class275(this.method_6(scenario_0).method_1(), enum66_0, this.method_6(scenario_0).method_3());
				return;
			}
			if (Information.IsNothing(this.class275_0))
			{
				this.class275_0 = new Doctrine.Class275(Doctrine.Class275.Enum66.const_3, enum66_0, Doctrine.Class275.Enum66.const_3);
				return;
			}
			this.class275_0 = new Doctrine.Class275(this.class275_0.method_1(), enum66_0, this.class275_0.method_3());
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x001374AC File Offset: 0x001356AC
		public void method_194(Doctrine.Class275.Enum66 enum66_0, Scenario scenario_0)
		{
			if (this.method_7() && !Information.IsNothing(this.method_6(scenario_0)))
			{
				this.class275_0 = new Doctrine.Class275(this.method_6(scenario_0).method_1(), this.method_6(scenario_0).method_2(), enum66_0);
				return;
			}
			if (Information.IsNothing(this.class275_0))
			{
				this.class275_0 = new Doctrine.Class275(Doctrine.Class275.Enum66.const_3, Doctrine.Class275.Enum66.const_3, enum66_0);
				return;
			}
			this.class275_0 = new Doctrine.Class275(this.class275_0.method_1(), this.class275_0.method_2(), enum66_0);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0000A24E File Offset: 0x0000844E
		public void method_195(Doctrine.Class275.Enum66 enum66_0, Doctrine.Class275.Enum66 enum66_1, Doctrine.Class275.Enum66 enum66_2)
		{
			this.class275_0 = new Doctrine.Class275(enum66_0, enum66_1, enum66_2);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00137534 File Offset: 0x00135734
		public Doctrine.Enum53? method_196(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, bool bool_38)
		{
			if (!bool_36)
			{
				this.method_4();
			}
			Doctrine.Enum53? result;
			if (this.method_198())
			{
				Doctrine.Enum53? @enum = this.method_3(scenario_0, ref bool_36).method_196(scenario_0, bool_35, true, bool_37, bool_38);
				if (!bool_36)
				{
					this.method_4();
				}
				result = @enum;
			}
			else
			{
				result = new Doctrine.Enum53?(this.nullable_22.Value);
			}
			return result;
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00137588 File Offset: 0x00135788
		public void method_197(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, bool bool_38, Doctrine.Enum53? nullable_42)
		{
			this.nullable_22 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_37, bool_38, false);
			}
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0000A25E File Offset: 0x0000845E
		public bool method_198()
		{
			return this.nullable_22 == null;
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x001375C0 File Offset: 0x001357C0
		public bool method_199(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_22;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_199(scenario_0);
			}
			return result;
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00137600 File Offset: 0x00135800
		public void method_200(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_22 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_200(scenario_0, bool_35);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00137640 File Offset: 0x00135840
		public Doctrine.Enum54? method_201(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, bool bool_38)
		{
			if (!bool_36)
			{
				this.method_4();
			}
			Doctrine.Enum54? result;
			if (this.method_203())
			{
				Doctrine.Enum54? @enum = this.method_3(scenario_0, ref bool_36).method_201(scenario_0, bool_35, true, bool_37, bool_38);
				if (!bool_36)
				{
					this.method_4();
				}
				result = @enum;
			}
			else
			{
				result = new Doctrine.Enum54?(this.nullable_23.Value);
			}
			return result;
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00137694 File Offset: 0x00135894
		public void method_202(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, bool bool_38, Doctrine.Enum54? nullable_42)
		{
			this.nullable_23 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_37, bool_38, false);
			}
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0000A26E File Offset: 0x0000846E
		public bool method_203()
		{
			return this.nullable_23 == null;
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x001376CC File Offset: 0x001358CC
		public bool method_204(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_23;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_204(scenario_0);
			}
			return result;
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0013770C File Offset: 0x0013590C
		public void method_205(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_23 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_205(scenario_0, bool_35);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0013774C File Offset: 0x0013594C
		public Doctrine._FuelState? method_206(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, bool bool_38)
		{
			Doctrine._FuelState? result;
			try
			{
				if (this.method_208())
				{
					result = this.method_3(scenario_0, ref bool_36).method_206(scenario_0, bool_35, true, bool_37, bool_38);
				}
				else
				{
					result = new Doctrine._FuelState?(this.nullable_24.Value);
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x001377C0 File Offset: 0x001359C0
		public void method_207(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, bool bool_38, Doctrine._FuelState? nullable_42)
		{
			this.nullable_24 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_37, bool_38, false);
			}
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0000A27E File Offset: 0x0000847E
		public bool method_208()
		{
			return this.nullable_24 == null;
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x001377F8 File Offset: 0x001359F8
		public bool method_209(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_24;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_209(scenario_0);
			}
			return result;
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00137838 File Offset: 0x00135A38
		public void method_210(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_24 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_210(scenario_0, bool_35);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00137878 File Offset: 0x00135A78
		public Doctrine._WeaponState? method_211(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, bool bool_38)
		{
			Doctrine._WeaponState? result;
			if (this.method_213())
			{
				result = this.method_3(scenario_0, ref bool_36).method_211(scenario_0, bool_35, true, bool_37, bool_38);
			}
			else
			{
				result = new Doctrine._WeaponState?(this.nullable_25.Value);
			}
			return result;
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x001378B8 File Offset: 0x00135AB8
		public void method_212(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, bool bool_38, Doctrine._WeaponState? nullable_42)
		{
			this.nullable_25 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_37, bool_38, false);
			}
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0000A28E File Offset: 0x0000848E
		public bool method_213()
		{
			return this.nullable_25 == null;
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x001378F0 File Offset: 0x00135AF0
		public bool method_214(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_25;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_214(scenario_0);
			}
			return result;
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00137930 File Offset: 0x00135B30
		public void method_215(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_25 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_215(scenario_0, bool_35);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00137970 File Offset: 0x00135B70
		public Doctrine.Enum55? method_216(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine.Enum55? result;
			if (this.method_218())
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_216(scenario_0, bool_35, bool_36, bool_37);
			}
			else
			{
				result = new Doctrine.Enum55?(this.nullable_26.Value);
			}
			return result;
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x001379B0 File Offset: 0x00135BB0
		public void method_217(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine.Enum55? nullable_42)
		{
			this.nullable_26 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0000A29E File Offset: 0x0000849E
		public bool method_218()
		{
			return this.nullable_26 == null;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x001379E8 File Offset: 0x00135BE8
		public bool method_219(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_26;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_219(scenario_0);
			}
			return result;
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00137A28 File Offset: 0x00135C28
		public void method_220(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_26 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_220(scenario_0, bool_35);
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00137A68 File Offset: 0x00135C68
		public void method_221(ref DataTable dataTable_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, ref Weapon weapon_0, int int_0, bool bool_35)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			int? num;
			try
			{
				foreach (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair in weapon_0.doctrine_0.method_27())
				{
					int key = keyValuePair.Key;
					foreach (Doctrine.Class276 @class in keyValuePair.Value.class276_0)
					{
						if (@class._WRA_WeaponTargetType_0 == _WRA_WeaponTargetType_0)
						{
							num = @class.nullable_0;
							break;
						}
					}
				}
			}
			finally
			{
				Dictionary<int, Doctrine.WRA_Weapon>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			int? num2;
			int? num3;
			if (!bool_35)
			{
				if (this.class310_0.GetType() != typeof(Side))
				{
					this.method_9(weapon_0.scenario_0, weapon_0, _WRA_WeaponTargetType_0, true, ref num2, ref num3);
				}
				else if (!this.method_29(ref _WRA_WeaponTargetType_0))
				{
					Doctrine._WRA_WeaponTargetType wra_WeaponTargetType_ = this.method_30(ref _WRA_WeaponTargetType_0);
					num3 = this.method_10(weapon_0.scenario_0, weapon_0, wra_WeaponTargetType_);
				}
			}
			Doctrine._WRA_WeaponTargetType wra_WeaponTargetType = _WRA_WeaponTargetType_0;
			if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons)
			{
				if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic)
				{
					if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Recon_EW)
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type > 5 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers > 2 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW > 2)
						{
							goto IL_1AB9;
						}
					}
					else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_AEW > 1 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified > 4)
					{
						goto IL_1AB9;
					}
				}
				else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type)
				{
					if (wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
					{
						if (wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
						{
							if (wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type)
							{
								goto IL_1AB9;
							}
							goto IL_10E6;
						}
						else
						{
							if (this.class310_0.GetType() != typeof(Side))
							{
								if (Information.IsNothing(num))
								{
									if (Information.IsNothing(num2) && Information.IsNothing(num3))
									{
										dataTable_0.Rows.Add(new object[]
										{
											0,
											"Inherited"
										});
									}
									else if (Information.IsNothing(num2))
									{
										dataTable_0.Rows.Add(new object[]
										{
											0,
											"Inherited, " + this.method_235(num3, !Information.IsNothing(num3))
										});
									}
									else if (!Information.IsNothing(num2))
									{
										dataTable_0.Rows.Add(new object[]
										{
											0,
											"Inherited, " + this.method_235(num2, !Information.IsNothing(num3))
										});
									}
									else
									{
										dataTable_0.Rows.Add(new object[]
										{
											0,
											"Inherited, " + this.method_235(num, !Information.IsNothing(num3))
										});
									}
								}
								else if (Information.IsNothing(num2) && Information.IsNothing(num3))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"Inherited"
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"Inherited, " + this.method_235(num2, !Information.IsNothing(num3))
									});
								}
							}
							if (!Information.IsNothing(num))
							{
								if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.class310_0.GetType() != typeof(Side))
								{
									dataTable_0.Rows.Add(new object[]
									{
										1,
										"System default"
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										1,
										"System default, " + this.method_235(num, false)
									});
								}
							}
							else if (this.class310_0.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
							{
								if (Information.IsNothing(num2) && Information.IsNothing(num3))
								{
									dataTable_0.Rows.Add(new object[]
									{
										1,
										"Not Configured"
									});
								}
								else if (Information.IsNothing(num2))
								{
									dataTable_0.Rows.Add(new object[]
									{
										1,
										"Not Configured, " + this.method_235(num3, !Information.IsNothing(num3))
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										1,
										"Not Configured, " + this.method_235(num, !Information.IsNothing(num3))
									});
								}
							}
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Do not use weapon against this target type"
							});
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"1 rnd"
							});
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"2 rnds"
							});
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"Use all weapons against target"
							});
							if (int_0 == this.method_228(ref _WRA_WeaponTargetType_0, new int?(-100)))
							{
								dataTable_0.Rows.Add(new object[]
								{
									6,
									"Various settings"
								});
								return;
							}
							return;
						}
					}
				}
				else
				{
					if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Unspecified > 4 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons > 7 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons > 7)
					{
						goto IL_1AB9;
					}
					goto IL_AC6;
				}
				if (this.class310_0.GetType() != typeof(Side))
				{
					if (Information.IsNothing(num))
					{
						if (Information.IsNothing(num2) && Information.IsNothing(num3))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited"
							});
						}
						else if (Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited, " + this.method_235(num3, !Information.IsNothing(num3))
							});
						}
						else if (!Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited, " + this.method_235(num2, !Information.IsNothing(num3))
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited, " + this.method_235(num, !Information.IsNothing(num3))
							});
						}
					}
					else if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_235(num2, !Information.IsNothing(num3))
						});
					}
				}
				if (!Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.class310_0.GetType() != typeof(Side))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"System default"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"System default, " + this.method_235(num, false)
						});
					}
				}
				else if (this.class310_0.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified)
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"Not Configured"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"Not Configured, " + this.method_235(num3, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"Not Configured, " + this.method_235(num, !Information.IsNothing(num3))
						});
					}
				}
				dataTable_0.Rows.Add(new object[]
				{
					2,
					"Do not use weapon against this target type"
				});
				dataTable_0.Rows.Add(new object[]
				{
					3,
					"1 rnd (easy target, or IR-guided weapon)"
				});
				dataTable_0.Rows.Add(new object[]
				{
					4,
					"2 rnds (non-cooperative target)"
				});
				dataTable_0.Rows.Add(new object[]
				{
					5,
					"3 rnds (extremely difficult target, rarely used)"
				});
				dataTable_0.Rows.Add(new object[]
				{
					6,
					"Use all weapons against target"
				});
				if (int_0 == this.method_228(ref _WRA_WeaponTargetType_0, new int?(-100)))
				{
					dataTable_0.Rows.Add(new object[]
					{
						7,
						"Various settings"
					});
					return;
				}
				return;
			}
			else
			{
				if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted)
				{
					if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons > 7 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons > 7 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
						{
							goto IL_1AB9;
						}
						goto IL_AC6;
					}
					else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type > 1)
					{
						switch (wra_WeaponTargetType)
						{
						case Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type:
							goto IL_10E6;
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring:
							break;
						case (Doctrine._WRA_WeaponTargetType)5003:
						case (Doctrine._WRA_WeaponTargetType)5004:
						case (Doctrine._WRA_WeaponTargetType)5007:
						case (Doctrine._WRA_WeaponTargetType)5008:
						case (Doctrine._WRA_WeaponTargetType)5009:
						case (Doctrine._WRA_WeaponTargetType)5010:
							goto IL_1AB9;
						default:
							if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified > 6)
							{
								goto IL_1AB9;
							}
							break;
						}
					}
					else
					{
						if (this.class310_0.GetType() != typeof(Side))
						{
							if (Information.IsNothing(num))
							{
								if (Information.IsNothing(num2) && Information.IsNothing(num3))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"Inherited"
									});
								}
								else if (Information.IsNothing(num2))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"Inherited, " + this.method_235(num3, !Information.IsNothing(num3))
									});
								}
								else if (!Information.IsNothing(num2))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"Inherited, " + this.method_235(num2, !Information.IsNothing(num3))
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"Inherited, " + this.method_235(num, !Information.IsNothing(num3))
									});
								}
							}
							else if (Information.IsNothing(num2) && Information.IsNothing(num3))
							{
								dataTable_0.Rows.Add(new object[]
								{
									0,
									"Inherited"
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									0,
									"Inherited, " + this.method_235(num2, !Information.IsNothing(num3))
								});
							}
						}
						if (!Information.IsNothing(num))
						{
							if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.class310_0.GetType() != typeof(Side))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"System default"
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"System default, " + this.method_235(num, false)
								});
							}
						}
						else if (this.class310_0.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Submarine_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type)
						{
							if (Information.IsNothing(num2) && Information.IsNothing(num3))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"Not Configured"
								});
							}
							else if (Information.IsNothing(num2))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"Not Configured, " + this.method_235(num3, !Information.IsNothing(num3))
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"Not Configured, " + this.method_235(num, !Information.IsNothing(num3))
								});
							}
						}
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Do not use weapon against this target type"
						});
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"1 rnd"
						});
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"2 rnds"
						});
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"3 rnds"
						});
						dataTable_0.Rows.Add(new object[]
						{
							6,
							"4 rnds"
						});
						dataTable_0.Rows.Add(new object[]
						{
							7,
							"Use all weapons against target"
						});
						if (int_0 == this.method_228(ref _WRA_WeaponTargetType_0, new int?(-100)))
						{
							dataTable_0.Rows.Add(new object[]
							{
								8,
								"Various settings"
							});
							return;
						}
						return;
					}
				}
				else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel)
				{
					if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified > 3 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Radar_Unspecified && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified > 2)
					{
						goto IL_1AB9;
					}
				}
				else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified > 1 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Underwater_Structure && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
				{
					goto IL_1AB9;
				}
				if (this.class310_0.GetType() != typeof(Side))
				{
					if (Information.IsNothing(num))
					{
						if (Information.IsNothing(num2) && Information.IsNothing(num3))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited"
							});
						}
						else if (Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited, " + this.method_235(num3, !Information.IsNothing(num3))
							});
						}
						else if (!Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited, " + this.method_235(num2, !Information.IsNothing(num3))
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited, " + this.method_235(num, !Information.IsNothing(num3))
							});
						}
					}
					else if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_235(num2, !Information.IsNothing(num3))
						});
					}
				}
				if (!Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.class310_0.GetType() != typeof(Side))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"System default"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"System default, " + this.method_235(num, false)
						});
					}
				}
				else if (this.class310_0.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Radar_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Underwater_Structure && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"Not Configured"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"Not Configured, " + this.method_235(num3, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"Not Configured, " + this.method_235(num, !Information.IsNothing(num3))
						});
					}
				}
				dataTable_0.Rows.Add(new object[]
				{
					2,
					"Do not use weapon against this target type"
				});
				dataTable_0.Rows.Add(new object[]
				{
					3,
					"Use target's Missile Defence value"
				});
				dataTable_0.Rows.Add(new object[]
				{
					4,
					"Use twice as many weapons as the target's Missile Defence value"
				});
				dataTable_0.Rows.Add(new object[]
				{
					5,
					"Use four times the target's Missile Defence value"
				});
				dataTable_0.Rows.Add(new object[]
				{
					6,
					"Use 1/2 the target's Missile Defence value"
				});
				dataTable_0.Rows.Add(new object[]
				{
					7,
					"Use 1/4 the target's Missile Defence value"
				});
				dataTable_0.Rows.Add(new object[]
				{
					8,
					"1 rnd"
				});
				dataTable_0.Rows.Add(new object[]
				{
					9,
					"2 rnds"
				});
				dataTable_0.Rows.Add(new object[]
				{
					10,
					"3 rnds"
				});
				dataTable_0.Rows.Add(new object[]
				{
					11,
					"4 rnds"
				});
				dataTable_0.Rows.Add(new object[]
				{
					12,
					"5 rnds"
				});
				dataTable_0.Rows.Add(new object[]
				{
					13,
					"6 rnds"
				});
				dataTable_0.Rows.Add(new object[]
				{
					14,
					"7 rnds"
				});
				dataTable_0.Rows.Add(new object[]
				{
					15,
					"8 rnds"
				});
				dataTable_0.Rows.Add(new object[]
				{
					16,
					"Use all weapons against target"
				});
				if (int_0 == this.method_228(ref _WRA_WeaponTargetType_0, new int?(-100)))
				{
					dataTable_0.Rows.Add(new object[]
					{
						17,
						"Various settings"
					});
					return;
				}
				return;
			}
			IL_AC6:
			if (this.class310_0.GetType() != typeof(Side))
			{
				if (Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_235(num3, !Information.IsNothing(num3))
						});
					}
					else if (!Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_235(num2, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_235(num, !Information.IsNothing(num3))
						});
					}
				}
				else if (Information.IsNothing(num2) && Information.IsNothing(num3))
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"Inherited"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"Inherited, " + this.method_235(num2, !Information.IsNothing(num3))
					});
				}
			}
			if (!Information.IsNothing(num))
			{
				if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.class310_0.GetType() != typeof(Side))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"System default"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"System default, " + this.method_235(num, false)
					});
				}
			}
			else if (this.class310_0.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Ship_Unspecified)
			{
				if (Information.IsNothing(num2) && Information.IsNothing(num3))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Not Configured"
					});
				}
				else if (Information.IsNothing(num2))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Not Configured, " + this.method_235(num3, !Information.IsNothing(num3))
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Not Configured, " + this.method_235(num, !Information.IsNothing(num3))
					});
				}
			}
			dataTable_0.Rows.Add(new object[]
			{
				2,
				"Do not use weapon against this target type"
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				"Use target's Missile Defence value"
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				"Use twice as many weapons as the target's Missile Defence value"
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				"Use four times the target's Missile Defence value"
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				"Use 1/2 the target's Missile Defence value"
			});
			dataTable_0.Rows.Add(new object[]
			{
				7,
				"Use 1/4 the target's Missile Defence value"
			});
			dataTable_0.Rows.Add(new object[]
			{
				8,
				"1 rnd"
			});
			dataTable_0.Rows.Add(new object[]
			{
				9,
				"2 rnds"
			});
			dataTable_0.Rows.Add(new object[]
			{
				10,
				"3 rnds"
			});
			dataTable_0.Rows.Add(new object[]
			{
				11,
				"4 rnds"
			});
			dataTable_0.Rows.Add(new object[]
			{
				12,
				"5 rnds"
			});
			dataTable_0.Rows.Add(new object[]
			{
				13,
				"6 rnds"
			});
			dataTable_0.Rows.Add(new object[]
			{
				14,
				"7 rnds"
			});
			dataTable_0.Rows.Add(new object[]
			{
				15,
				"8 rnds"
			});
			dataTable_0.Rows.Add(new object[]
			{
				16,
				"Use all weapons against target"
			});
			if (int_0 == this.method_228(ref _WRA_WeaponTargetType_0, new int?(-100)))
			{
				dataTable_0.Rows.Add(new object[]
				{
					17,
					"Various settings"
				});
				return;
			}
			return;
			IL_10E6:
			if (this.class310_0.GetType() != typeof(Side))
			{
				if (Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_235(num3, !Information.IsNothing(num3))
						});
					}
					else if (!Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_235(num2, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_235(num, !Information.IsNothing(num3))
						});
					}
				}
				else if (Information.IsNothing(num2) && Information.IsNothing(num3))
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"Inherited"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"Inherited, " + this.method_235(num2, !Information.IsNothing(num3))
					});
				}
			}
			if (!Information.IsNothing(num))
			{
				if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.class310_0.GetType() != typeof(Side))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"System default"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"System default, " + this.method_235(num, false)
					});
				}
			}
			else if (this.class310_0.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type)
			{
				if (Information.IsNothing(num2) && Information.IsNothing(num3))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Not Configured"
					});
				}
				else if (Information.IsNothing(num2))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Not Configured, " + this.method_235(num3, !Information.IsNothing(num3))
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Not Configured, " + this.method_235(num, !Information.IsNothing(num3))
					});
				}
			}
			dataTable_0.Rows.Add(new object[]
			{
				2,
				"Do not use weapon against this target type"
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				"1 rnd"
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				"2 rnds"
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				"3 rnds"
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				"4 rnds"
			});
			dataTable_0.Rows.Add(new object[]
			{
				7,
				"5 rnds"
			});
			dataTable_0.Rows.Add(new object[]
			{
				8,
				"6 rnds"
			});
			dataTable_0.Rows.Add(new object[]
			{
				9,
				"7 rnds"
			});
			dataTable_0.Rows.Add(new object[]
			{
				10,
				"8 rnds"
			});
			dataTable_0.Rows.Add(new object[]
			{
				11,
				"Use all weapons against target"
			});
			if (int_0 == this.method_228(ref _WRA_WeaponTargetType_0, new int?(-100)))
			{
				dataTable_0.Rows.Add(new object[]
				{
					12,
					"Various settings"
				});
				return;
			}
			return;
			IL_1AB9:
			dataTable_0.Rows.Add(new object[]
			{
				0,
				"Not implemented"
			});
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00139B70 File Offset: 0x00137D70
		public void method_222(ref DataTable dataTable_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, ref Weapon weapon_0, int int_0, bool bool_35)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			int? num;
			try
			{
				foreach (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair in weapon_0.doctrine_0.method_27())
				{
					int key = keyValuePair.Key;
					foreach (Doctrine.Class276 @class in keyValuePair.Value.class276_0)
					{
						if (@class._WRA_WeaponTargetType_0 == _WRA_WeaponTargetType_0)
						{
							num = @class.nullable_1;
							break;
						}
					}
				}
			}
			finally
			{
				Dictionary<int, Doctrine.WRA_Weapon>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			int? num2;
			int? num3;
			if (!bool_35)
			{
				if (this.class310_0.GetType() != typeof(Side))
				{
					this.method_13(weapon_0.scenario_0, weapon_0, _WRA_WeaponTargetType_0, true, ref num2, ref num3);
				}
				else if (!this.method_29(ref _WRA_WeaponTargetType_0))
				{
					Doctrine._WRA_WeaponTargetType wra_WeaponTargetType_ = this.method_30(ref _WRA_WeaponTargetType_0);
					num3 = this.method_14(weapon_0.scenario_0, weapon_0, wra_WeaponTargetType_);
				}
			}
			if (this.class310_0.GetType() != typeof(Side))
			{
				if (Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_236(num3, !Information.IsNothing(num3))
						});
					}
					else if (!Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_236(num2, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_236(num, !Information.IsNothing(num3))
						});
					}
				}
				else if (Information.IsNothing(num2) && Information.IsNothing(num3))
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"Inherited"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"Inherited, " + this.method_236(num2, !Information.IsNothing(num3))
					});
				}
			}
			if (!Information.IsNothing(num))
			{
				if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.class310_0.GetType() != typeof(Side))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"System default"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"System default, " + this.method_236(num, false)
					});
				}
			}
			else if (this.class310_0.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified)
			{
				if (!Information.IsNothing(num2) && !Information.IsNothing(num3))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Not Configured"
					});
				}
				else if (Information.IsNothing(num2))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Not Configured, " + this.method_236(num3, !Information.IsNothing(num3))
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Not Configured, " + this.method_236(num, !Information.IsNothing(num3))
					});
				}
			}
			dataTable_0.Rows.Add(new object[]
			{
				2,
				"Fire weapons from enough units to fill the salvo's Weapon Qty requirement"
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				"1 unit"
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				"2 units"
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				"4 units"
			});
			if (int_0 == this.method_230(new int?(-100)))
			{
				dataTable_0.Rows.Add(new object[]
				{
					6,
					"Various settings"
				});
			}
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0013A0F0 File Offset: 0x001382F0
		public void method_223(ref DataTable dataTable_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, ref Weapon weapon_0, int int_0, bool bool_35)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			int? num;
			try
			{
				foreach (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair in weapon_0.doctrine_0.method_27())
				{
					int key = keyValuePair.Key;
					foreach (Doctrine.Class276 @class in keyValuePair.Value.class276_0)
					{
						if (@class._WRA_WeaponTargetType_0 == _WRA_WeaponTargetType_0)
						{
							num = @class.nullable_3;
							break;
						}
					}
				}
			}
			finally
			{
				Dictionary<int, Doctrine.WRA_Weapon>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			int? num2;
			int? num3;
			if (!bool_35)
			{
				if (this.class310_0.GetType() != typeof(Side))
				{
					this.method_18(weapon_0.scenario_0, weapon_0, _WRA_WeaponTargetType_0, true, ref num2, ref num3);
				}
				else if (!this.method_29(ref _WRA_WeaponTargetType_0))
				{
					Doctrine._WRA_WeaponTargetType wra_WeaponTargetType_ = this.method_30(ref _WRA_WeaponTargetType_0);
					num3 = this.method_19(weapon_0.scenario_0, weapon_0, wra_WeaponTargetType_);
				}
			}
			Doctrine._WRA_WeaponTargetType wra_WeaponTargetType = _WRA_WeaponTargetType_0;
			if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons)
			{
				if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
				{
					if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Bombers)
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type > 5 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers > 2)
						{
							goto IL_1494;
						}
					}
					else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW > 2 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_AEW > 1 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
					{
						goto IL_1494;
					}
				}
				else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
				{
					if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified > 4 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
					{
						if (wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
						{
							goto IL_1494;
						}
						if (this.class310_0.GetType() != typeof(Side))
						{
							if (Information.IsNothing(num))
							{
								if (Information.IsNothing(num2) && Information.IsNothing(num3))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"Inherited"
									});
								}
								else if (Information.IsNothing(num2))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"Inherited, " + this.method_237(num3, !Information.IsNothing(num3))
									});
								}
								else if (!Information.IsNothing(num2))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"Inherited, " + this.method_237(num2, !Information.IsNothing(num3))
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"Inherited, " + this.method_237(num, !Information.IsNothing(num3))
									});
								}
							}
							else if (Information.IsNothing(num2) && Information.IsNothing(num3))
							{
								dataTable_0.Rows.Add(new object[]
								{
									0,
									"Inherited"
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									0,
									"Inherited, " + this.method_237(num2, !Information.IsNothing(num3))
								});
							}
						}
						if (!Information.IsNothing(num))
						{
							if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.class310_0.GetType() != typeof(Side))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"System default"
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"System default, " + this.method_237(num, false)
								});
							}
						}
						else if (this.class310_0.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
						{
							if (!Information.IsNothing(num2) && !Information.IsNothing(num3))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"Not Configured"
								});
							}
							else if (Information.IsNothing(num2))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"Not Configured, " + this.method_237(num3, !Information.IsNothing(num3))
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"Not Configured, " + this.method_237(num, !Information.IsNothing(num3))
								});
							}
						}
						if (int_0 == this.method_232(ref _WRA_WeaponTargetType_0, new int?(-100)))
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Various settings"
							});
							return;
						}
						return;
					}
				}
				else
				{
					if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type > 5 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons > 7 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons > 7)
					{
						goto IL_1494;
					}
					goto IL_A86;
				}
				if (this.class310_0.GetType() != typeof(Side))
				{
					if (Information.IsNothing(num))
					{
						if (Information.IsNothing(num2) && Information.IsNothing(num3))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited"
							});
						}
						else if (Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited, " + this.method_237(num3, !Information.IsNothing(num3))
							});
						}
						else if (!Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited, " + this.method_237(num2, !Information.IsNothing(num3))
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited, " + this.method_237(num, !Information.IsNothing(num3))
							});
						}
					}
					else if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_237(num2, !Information.IsNothing(num3))
						});
					}
				}
				if (!Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.class310_0.GetType() != typeof(Side))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"System default"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"System default, " + this.method_237(num, false)
						});
					}
				}
				else if (this.class310_0.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified)
				{
					if (!Information.IsNothing(num2) && !Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"Not Configured"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"Not Configured, " + this.method_237(num3, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"Not Configured, " + this.method_237(num, !Information.IsNothing(num3))
						});
					}
				}
				dataTable_0.Rows.Add(new object[]
				{
					2,
					"Do not use weapon in self defence"
				});
				if (weapon_0.float_29 > 2f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						" 2 nm"
					});
				}
				if (weapon_0.float_29 > 5f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						" 5 nm"
					});
				}
				if (weapon_0.float_29 > 10f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"10 nm"
					});
				}
				if (weapon_0.float_29 > 15f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"15 nm"
					});
				}
				dataTable_0.Rows.Add(new object[]
				{
					7,
					"Maximum range"
				});
				if (int_0 == this.method_232(ref _WRA_WeaponTargetType_0, new int?(-100)))
				{
					dataTable_0.Rows.Add(new object[]
					{
						8,
						"Various settings"
					});
					return;
				}
				return;
			}
			else
			{
				if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted)
				{
					if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons > 7 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons > 7 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
						{
							goto IL_1494;
						}
						goto IL_A86;
					}
					else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type > 1)
					{
						switch (wra_WeaponTargetType)
						{
						case Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted:
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring:
							break;
						case (Doctrine._WRA_WeaponTargetType)5003:
						case (Doctrine._WRA_WeaponTargetType)5004:
						case (Doctrine._WRA_WeaponTargetType)5007:
						case (Doctrine._WRA_WeaponTargetType)5008:
						case (Doctrine._WRA_WeaponTargetType)5009:
						case (Doctrine._WRA_WeaponTargetType)5010:
							goto IL_1494;
						default:
							if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified > 6)
							{
								goto IL_1494;
							}
							break;
						}
					}
					else
					{
						if (this.class310_0.GetType() != typeof(Side))
						{
							if (Information.IsNothing(num))
							{
								if (Information.IsNothing(num2) && Information.IsNothing(num3))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"Inherited"
									});
								}
								else if (Information.IsNothing(num2))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"Inherited, " + this.method_237(num3, !Information.IsNothing(num3))
									});
								}
								else if (!Information.IsNothing(num2))
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"Inherited, " + this.method_237(num2, !Information.IsNothing(num3))
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										0,
										"Inherited, " + this.method_237(num, !Information.IsNothing(num3))
									});
								}
							}
							else if (Information.IsNothing(num2) && Information.IsNothing(num3))
							{
								dataTable_0.Rows.Add(new object[]
								{
									0,
									"Inherited"
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									0,
									"Inherited, " + this.method_237(num2, !Information.IsNothing(num3))
								});
							}
						}
						if (!Information.IsNothing(num))
						{
							if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.class310_0.GetType() != typeof(Side))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"System default"
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"System default, " + this.method_237(num, false)
								});
							}
						}
						else if (this.class310_0.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Submarine_Unspecified)
						{
							if (!Information.IsNothing(num2) && !Information.IsNothing(num3))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"Not Configured"
								});
							}
							else if (Information.IsNothing(num2))
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"Not Configured, " + this.method_237(num3, !Information.IsNothing(num3))
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									1,
									"Not Configured, " + this.method_237(num, !Information.IsNothing(num3))
								});
							}
						}
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Do not use weapon in self defence"
						});
						if (weapon_0.float_35 > 2f)
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								" 2 nm"
							});
						}
						if (weapon_0.float_35 > 5f)
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								" 5 nm"
							});
						}
						if (weapon_0.float_35 > 10f)
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"10 nm"
							});
						}
						if (weapon_0.float_35 > 15f)
						{
							dataTable_0.Rows.Add(new object[]
							{
								6,
								"15 nm"
							});
						}
						dataTable_0.Rows.Add(new object[]
						{
							7,
							"Maximum range"
						});
						if (int_0 == this.method_232(ref _WRA_WeaponTargetType_0, new int?(-100)))
						{
							dataTable_0.Rows.Add(new object[]
							{
								8,
								"Various settings"
							});
							return;
						}
						return;
					}
				}
				else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel)
				{
					if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified > 3 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Radar_Unspecified && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified > 2)
					{
						goto IL_1494;
					}
				}
				else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified > 1 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Underwater_Structure && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
				{
					goto IL_1494;
				}
				if (this.class310_0.GetType() != typeof(Side))
				{
					if (Information.IsNothing(num))
					{
						if (Information.IsNothing(num2) && Information.IsNothing(num3))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited"
							});
						}
						else if (Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited, " + this.method_237(num3, !Information.IsNothing(num3))
							});
						}
						else if (!Information.IsNothing(num2))
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited, " + this.method_237(num2, !Information.IsNothing(num3))
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								0,
								"Inherited, " + this.method_237(num, !Information.IsNothing(num3))
							});
						}
					}
					else if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_237(num2, !Information.IsNothing(num3))
						});
					}
				}
				if (!Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.class310_0.GetType() != typeof(Side))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"System default"
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"System default, " + this.method_237(num, false)
						});
					}
				}
				else if (this.class310_0.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Underwater_Structure && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Radar_Unspecified)
				{
					if (!Information.IsNothing(num2) && !Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"Not Configured"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"Not Configured, " + this.method_237(num3, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							1,
							"Not Configured, " + this.method_237(num, !Information.IsNothing(num3))
						});
					}
				}
				dataTable_0.Rows.Add(new object[]
				{
					2,
					"Do not use weapon in self defence"
				});
				if (weapon_0.float_33 > 2f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						" 2 nm"
					});
				}
				if (weapon_0.float_33 > 5f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						" 5 nm"
					});
				}
				if (weapon_0.float_33 > 10f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"10 nm"
					});
				}
				if (weapon_0.float_33 > 15f)
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"15 nm"
					});
				}
				dataTable_0.Rows.Add(new object[]
				{
					7,
					"Maximum range"
				});
				if (int_0 == this.method_232(ref _WRA_WeaponTargetType_0, new int?(-100)))
				{
					dataTable_0.Rows.Add(new object[]
					{
						8,
						"Various settings"
					});
					return;
				}
				return;
			}
			IL_A86:
			if (this.class310_0.GetType() != typeof(Side))
			{
				if (Information.IsNothing(num))
				{
					if (Information.IsNothing(num2) && Information.IsNothing(num3))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited"
						});
					}
					else if (Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_237(num3, !Information.IsNothing(num3))
						});
					}
					else if (!Information.IsNothing(num2))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_237(num2, !Information.IsNothing(num3))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_237(num, !Information.IsNothing(num3))
						});
					}
				}
				else if (Information.IsNothing(num2) && Information.IsNothing(num3))
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"Inherited"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"Inherited, " + this.method_237(num2, !Information.IsNothing(num3))
					});
				}
			}
			if (!Information.IsNothing(num))
			{
				if (Information.IsNothing(num2) && Information.IsNothing(num3) && this.class310_0.GetType() != typeof(Side))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"System default"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"System default, " + this.method_237(num, false)
					});
				}
			}
			else if (this.class310_0.GetType() == typeof(Side) && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type && _WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Ship_Unspecified)
			{
				if (!Information.IsNothing(num2) && !Information.IsNothing(num3))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Not Configured"
					});
				}
				else if (Information.IsNothing(num2))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Not Configured, " + this.method_237(num3, !Information.IsNothing(num3))
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Not Configured, " + this.method_237(num, !Information.IsNothing(num3))
					});
				}
			}
			dataTable_0.Rows.Add(new object[]
			{
				2,
				"Do not use weapon in self defence"
			});
			if (weapon_0.float_31 > 2f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					3,
					" 2 nm"
				});
			}
			if (weapon_0.float_31 > 5f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					4,
					" 5 nm"
				});
			}
			if (weapon_0.float_31 > 10f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					5,
					"10 nm"
				});
			}
			if (weapon_0.float_31 > 15f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					6,
					"15 nm"
				});
			}
			dataTable_0.Rows.Add(new object[]
			{
				7,
				"Maximum range"
			});
			if (int_0 == this.method_232(ref _WRA_WeaponTargetType_0, new int?(-100)))
			{
				dataTable_0.Rows.Add(new object[]
				{
					8,
					"Various settings"
				});
				return;
			}
			return;
			IL_1494:
			dataTable_0.Rows.Add(new object[]
			{
				0,
				"Not implemented"
			});
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0013BAC8 File Offset: 0x00139CC8
		public void method_224(ref DataTable dataTable_0, Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, ref Weapon weapon_0, int int_0, bool bool_35)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			int? num;
			int? num2;
			int? num3;
			if (!bool_35)
			{
				if (this.class310_0.GetType() != typeof(Side))
				{
					this.method_23(weapon_0.scenario_0, weapon_0.DBID, _WRA_WeaponTargetType_0, true, ref num, ref num2);
				}
				else if (!this.method_29(ref _WRA_WeaponTargetType_0))
				{
					Doctrine._WRA_WeaponTargetType wra_WeaponTargetType_ = this.method_30(ref _WRA_WeaponTargetType_0);
					num2 = this.method_24(weapon_0.scenario_0, weapon_0.DBID, wra_WeaponTargetType_);
				}
				else
				{
					num3 = new int?(-99);
				}
				if (Information.IsNothing(num2))
				{
					num2 = new int?(-99);
				}
			}
			if (this.class310_0.GetType() != typeof(Side))
			{
				if (Information.IsNothing(num3))
				{
					if (Information.IsNothing(num) && Information.IsNothing(num2) && bool_35)
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited"
						});
					}
					else if (Information.IsNothing(num))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_238(num2, !Information.IsNothing(num2))
						});
					}
					else if (!Information.IsNothing(num))
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_238(num, !Information.IsNothing(num2))
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							0,
							"Inherited, " + this.method_238(num3, !Information.IsNothing(num2))
						});
					}
				}
				else if (Information.IsNothing(num) && Information.IsNothing(num2))
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"Inherited"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						0,
						"Inherited, " + this.method_238(num, !Information.IsNothing(num2))
					});
				}
			}
			if (!Information.IsNothing(num3))
			{
				if (!Information.IsNothing(num) && !Information.IsNothing(num2) && this.class310_0.GetType() != typeof(Side))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"System Default, Automatic Fire to Max Range"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"System Default, " + this.method_238(num3, !Information.IsNothing(num2))
					});
				}
			}
			else if (this.class310_0.GetType() == typeof(Side))
			{
				if (Information.IsNothing(num) && Information.IsNothing(num2))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Not Configured"
					});
				}
				else if (!Information.IsNothing(num))
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Not Configured, " + this.method_238(num, !Information.IsNothing(num2))
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Not Configured, " + this.method_238(num2, !Information.IsNothing(num2))
					});
				}
			}
			else
			{
				dataTable_0.Rows.Add(new object[]
				{
					1,
					"Automatic Fire to Max Range"
				});
			}
			dataTable_0.Rows.Add(new object[]
			{
				2,
				"No Automatic Fire"
			});
			float num4 = weapon_0.method_159();
			float num5 = weapon_0.method_160();
			if (num4 > 2f && num5 < 2f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					3,
					" 2 nm"
				});
			}
			if (num4 > 5f && num5 < 5f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					4,
					" 5 nm"
				});
			}
			if (num4 > 10f && num5 < 10f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					5,
					"10 nm"
				});
			}
			if (num4 > 15f && num5 < 15f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					6,
					"15 nm"
				});
			}
			if (num4 > 20f && num5 < 20f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					7,
					"20 nm"
				});
			}
			if (num4 > 25f && num5 < 25f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					8,
					"25 nm"
				});
			}
			if (num4 > 30f && num5 < 30f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					9,
					"30 nm"
				});
			}
			if (num4 > 35f && num5 < 35f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					10,
					"35 nm"
				});
			}
			if (num4 > 40f && num5 < 40f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					11,
					"40 nm"
				});
			}
			if (num4 > 45f && num5 < 45f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					12,
					"45 nm"
				});
			}
			if (num4 > 50f && num5 < 50f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					13,
					"50 nm"
				});
			}
			if (num4 > 60f && num5 < 60f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					14,
					"60 nm"
				});
			}
			if (num4 > 70f && num5 < 70f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					15,
					"70 nm"
				});
			}
			if (num4 > 80f && num5 < 80f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					16,
					"80 nm"
				});
			}
			if (num4 > 90f && num5 < 90f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					17,
					"90 nm"
				});
			}
			if (num4 > 100f && num5 < 100f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					18,
					"100 nm"
				});
			}
			if (num4 > 125f && num5 < 125f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					19,
					"125 nm"
				});
			}
			if (num4 > 150f && num5 < 150f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					20,
					"150 nm"
				});
			}
			if (num4 > 175f && num5 < 175f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					21,
					"175 nm"
				});
			}
			if (num4 > 200f && num5 < 200f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					22,
					"200 nm"
				});
			}
			if (num4 > 250f && num5 < 250f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					23,
					"250 nm"
				});
			}
			if (num4 > 300f && num5 < 300f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					24,
					"300 nm"
				});
			}
			if (num4 > 500f && num5 < 500f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					25,
					"500 nm"
				});
			}
			if (num4 > 750f && num5 < 750f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					26,
					"750 nm"
				});
			}
			if (num4 > 1000f && num5 < 1000f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					27,
					"1000 nm"
				});
			}
			if (num4 > 1500f && num5 < 1500f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					28,
					"1500 nm"
				});
			}
			if (num4 > 2000f && num5 < 2000f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					29,
					"2000 nm"
				});
			}
			if (int_0 == this.method_234(new int?(-100)))
			{
				dataTable_0.Rows.Add(new object[]
				{
					30,
					"Various settings"
				});
			}
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0013C55C File Offset: 0x0013A75C
		public static string smethod_8(Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0)
		{
			Doctrine._WRA_WeaponTargetType wra_WeaponTargetType = _WRA_WeaponTargetType_0;
			if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_95000_tons)
			{
				if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic)
				{
					if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_AEW)
					{
						switch (wra_WeaponTargetType)
						{
						case Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type:
							return "Air Contact - Unknown Type";
						case Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified:
							return "Aircraft - Unspecified";
						case Doctrine._WRA_WeaponTargetType.Aircraft_5th_Generation:
							return "Aircraft - 5th Generation Fighter/Attack [Agility/Gen: 5.0+] (F-22, Eurofighter, Rafale)";
						case Doctrine._WRA_WeaponTargetType.Aircraft_4th_Generation:
							return "Aircraft - 4th Generation Fighter/Attack [Agility/Gen: 4.0-4.9] (F-14, F-15, F-16, MiG-29, Su-27)";
						case Doctrine._WRA_WeaponTargetType.Aircraft_3rd_Generation:
							return "Aircraft - 3rd Generation Fighter/Attack [Agility/Gen: 3.0-3.9] (F-4, F-5, MiG-21, MiG-23)";
						case Doctrine._WRA_WeaponTargetType.Aircraft_Less_Capable:
							return "Aircraft - Less Capable Fighter/Attack [Agility: 2.0-2.9] (F-111, Lightning, Su-7, MiG-17)";
						case (Doctrine._WRA_WeaponTargetType)2005:
						case (Doctrine._WRA_WeaponTargetType)2006:
						case (Doctrine._WRA_WeaponTargetType)2007:
						case (Doctrine._WRA_WeaponTargetType)2008:
						case (Doctrine._WRA_WeaponTargetType)2009:
						case (Doctrine._WRA_WeaponTargetType)2010:
							break;
						case Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers:
							return "Aircraft - High-performance Bombers [Agility: 2.0+] (B-1B, B-2A, Tu-22M";
						case Doctrine._WRA_WeaponTargetType.Aircraft_Medium_Perf_Bombers:
							return "Aircraft - Medium-performance Bombers [Agility: 1.5-1.9] (B-52, Vulcan, Tu-16)";
						case Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Bombers:
							return "Aircraft - Low-performance Bombers [Agility: 1.0-1.4] (B-24, Canberra, Tu-95, Bison)";
						default:
							switch (wra_WeaponTargetType)
							{
							case Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW:
								return "Aircraft - High-Performance Reconnaissance and Electronic Warfare [Agility: 4.0+]";
							case Doctrine._WRA_WeaponTargetType.Aircraft_Medium_Perf_Recon_EW:
								return "Aircraft - Medium-Performance Reconnaissance and Electronic Warfare [Agility: 3.0-3.9]";
							case Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Recon_EW:
								return "Aircraft - Low-Performance Reconnaissance and Electronic Warfare [Agility: 2.0-2.9]";
							default:
								if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Aircraft_AEW)
								{
									return "Aircraft - Airborne Early Warning and Control";
								}
								break;
							}
							break;
						}
					}
					else
					{
						if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Aircraft_MicroUAV)
						{
							return "Aircraft - Micro-UAV";
						}
						if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
						{
							return "Helicopter - Unspecified";
						}
						switch (wra_WeaponTargetType)
						{
						case Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified:
							return "Guided Weapon - Unspecified";
						case Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic_Sea_Skimming:
							return "Guided Weapon - Supersonic Sea-Skimming";
						case Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic_Sea_Skimming:
							return "Guided Weapon - Subsonic Sea-Skimming";
						case Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic:
							return "Guided Weapon - Supersonic";
						case Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic:
							return "Guided Weapon - Subsonic";
						}
					}
				}
				else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Carrier_95000_tons)
				{
					if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
					{
						return "Guided Weapon - Ballistic";
					}
					if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
					{
						return "Satellite - Unspecified";
					}
					switch (wra_WeaponTargetType)
					{
					case Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type:
						return "Surface Contact - Unknown Type";
					case Doctrine._WRA_WeaponTargetType.Ship_Unspecified:
						return "Ship - Unspecified";
					case Doctrine._WRA_WeaponTargetType.Ship_Carrier_0_25000_tons:
						return "Ship - Carrier, 0-25000 tons";
					case Doctrine._WRA_WeaponTargetType.Ship_Carrier_25001_45000_tons:
						return "Ship - Carrier, 25001-45000 tons";
					case Doctrine._WRA_WeaponTargetType.Ship_Carrier_45001_95000_tons:
						return "Ship - Carrier, 45001-95000 tons";
					case Doctrine._WRA_WeaponTargetType.Ship_Carrier_95000_tons:
						return "Ship - Carrier, 95000+ tons";
					}
				}
				else
				{
					switch (wra_WeaponTargetType)
					{
					case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons:
						return "Ship - Surface Combatant, 0-500 tons";
					case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_501_1500_tons:
						return "Ship - Surface Combatant, 501-1500 tons, plus Missile Boats with smaller displacement";
					case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_1501_5000_tons:
						return "Ship - Surface Combatant, 1501-5000 tons, plus Frigates and Corvettes with smaller displacement";
					case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_5001_10000_tons:
						return "Ship - Surface Combatant, 5001-10000 tons, plus Destroyers with smaller displacement";
					case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_10001_25000_tons:
						return "Ship - Surface Combatant, 10001-25000 tons, plus Cruisers with smaller displacement";
					case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_25001_45000_tons:
						return "Ship - Surface Combatant, 25001-45000 tons";
					case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_45001_95000_tons:
						return "Ship - Surface Combatant, 45001-95000 tons";
					case Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_95000_tons:
						return "Ship - Surface Combatant, 95000+ tons";
					default:
						switch (wra_WeaponTargetType)
						{
						case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons:
							return "Ship - Amphibious, 0-500 tons";
						case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_501_1500_tons:
							return "Ship - Amphibious, 501-1500 tons";
						case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_1501_5000_tons:
							return "Ship - Amphibious, 1501-5000 tons";
						case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_5001_10000_tons:
							return "Ship - Amphibious, 5001-10000 tons";
						case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_10001_25000_tons:
							return "Ship - Amphibious, 10001-25000 tons";
						case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_25001_45000_tons:
							return "Ship - Amphibious, 25001-45000 tons";
						case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_45001_95000_tons:
							return "Ship - Amphibious, 45001-95000 tons";
						case Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons:
							return "Ship - Amphibious, 95000+ tons";
						default:
							switch (wra_WeaponTargetType)
							{
							case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons:
								return "Ship - Auxiliary, 0-500 tons";
							case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_501_1500_tons:
								return "Ship - Auxiliary, 501-1500 tons";
							case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_1501_5000_tons:
								return "Ship - Auxiliary, 1501-5000 tons";
							case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_5001_10000_tons:
								return "Ship - Auxiliary, 5001-10000 tons";
							case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_10001_25000_tons:
								return "Ship - Auxiliary, 10001-25000 tons";
							case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_25001_45000_tons:
								return "Ship - Auxiliary, 25001-45000 tons";
							case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_45001_95000_tons:
								return "Ship - Auxiliary, 45001-95000 tons";
							case Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_95000_tons:
								return "Ship - Auxiliary, 95000+ tons";
							}
							break;
						}
						break;
					}
				}
			}
			else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted)
			{
				if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type)
				{
					switch (wra_WeaponTargetType)
					{
					case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons:
						return "Ship - Merchant / Civilian, 0-500 tons";
					case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_501_1500_tons:
						return "Ship - Merchant / Civilian, 501-1500 tons";
					case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_1501_5000_tons:
						return "Ship - Merchant / Civilian, 1501-5000 tons";
					case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_5001_10000_tons:
						return "Ship - Merchant / Civilian, 5001-10000 tons";
					case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_10001_25000_tons:
						return "Ship - Merchant / Civilian, 10001-25000 tons";
					case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_25001_45000_tons:
						return "Ship - Merchant / Civilian, 25001-45000 tons";
					case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_45001_95000_tons:
						return "Ship - Merchant / Civilian, 45001-95000 tons";
					case Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_95000_tons:
						return "Ship - Merchant / Civilian, 95000+ tons";
					default:
						if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
						{
							return "Ship - Surfaced Submarine";
						}
						if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type)
						{
							return "Sub-Surface Contact - Unknown Type";
						}
						break;
					}
				}
				else
				{
					if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Submarine_Unspecified)
					{
						return "Submarine - Unspecified";
					}
					switch (wra_WeaponTargetType)
					{
					case Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type:
						return "Land Contact - Unknown Type";
					case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified:
						return "Land Structure - Soft - Unspecified";
					case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface:
						return "Land Structure - Soft - Building (Surface)";
					case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted:
						return "Land Structure - Soft - Building (Reveted)";
					case (Doctrine._WRA_WeaponTargetType)5003:
					case (Doctrine._WRA_WeaponTargetType)5004:
					case (Doctrine._WRA_WeaponTargetType)5007:
					case (Doctrine._WRA_WeaponTargetType)5008:
					case (Doctrine._WRA_WeaponTargetType)5009:
					case (Doctrine._WRA_WeaponTargetType)5010:
						break;
					case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open:
						return "Land Structure - Soft - Structure (Open)";
					case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted:
						return "Land Structure - Soft - Structure (Reveted)";
					case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring:
						return "Land Structure - Soft - Aerostat Moring";
					default:
						switch (wra_WeaponTargetType)
						{
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified:
							return "Land Structure - Hardened - Unspecified";
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Surface:
							return "Land Structure - Hardened - Building (Surface)";
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Reveted:
							return "Land Structure - Hardened - Building (Reveted)";
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Bunker:
							return "Land Structure - Hardened - Building (Bunker)";
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Underground:
							return "Land Structure - Hardened - Building (Underground)";
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Open:
							return "Land Structure - Hardened - Structure (Open)";
						case Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted:
							return "Land Structure - Hardened - Structure (Reveted)";
						}
						break;
					}
				}
			}
			else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel)
			{
				switch (wra_WeaponTargetType)
				{
				case Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified:
					return "Runway Facility - Unspecified";
				case Doctrine._WRA_WeaponTargetType.Runway:
					return "Runway";
				case Doctrine._WRA_WeaponTargetType.Runway_Grade_Taxiway:
					return "Runway-Grade Taxiway";
				case Doctrine._WRA_WeaponTargetType.Runway_Access_Point:
					return "Runway Access Point";
				default:
					if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Radar_Unspecified)
					{
						return "Radar - Unspecified";
					}
					switch (wra_WeaponTargetType)
					{
					case Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified:
						return "Mobile Target - Soft - Unspecified";
					case Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Vehicle:
						return "Mobile Target - Soft - Mobile Vehicle(s)";
					case Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel:
						return "Mobile Target - Soft - Mobile Personnel";
					}
					break;
				}
			}
			else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Mobile_Vehicle)
			{
				if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified)
				{
					return "Mobile Target - Hardened - Unspecified";
				}
				if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Mobile_Vehicle)
				{
					return "Mobile Target - Hardened - Mobile Vehicle(s)";
				}
			}
			else
			{
				if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Underwater_Structure)
				{
					return "Underwater Structure";
				}
				if (wra_WeaponTargetType == Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
				{
					return "Air Base (Single-Unit Airfield)";
				}
			}
			return _WRA_WeaponTargetType_0.ToString();
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0013CC08 File Offset: 0x0013AE08
		public string method_225(int? nullable_42, ActiveUnit activeUnit_0, Contact contact_0, Weapon weapon_0)
		{
			int? num = nullable_42;
			int? num2 = num;
			string result;
			if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
			{
				result = "Fire all weapons per salvo";
			}
			else
			{
				num2 = num;
				if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					result = "Do not use weapon against this target type";
				}
				else
				{
					num2 = num;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -2) : null).GetValueOrDefault())
					{
						int? num3 = activeUnit_0.vmethod_7(false).method_80(nullable_42, ref activeUnit_0, ref contact_0, ref weapon_0);
						num2 = num3;
						if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							result = ((num3 != null) ? Conversions.ToString(num3.GetValueOrDefault()) : null) + "x rnd per salvo (using target's Missile Defence value)";
						}
						else
						{
							result = ((num3 != null) ? Conversions.ToString(num3.GetValueOrDefault()) : null) + "x rnds per salvo (using target's Missile Defence value)";
						}
					}
					else
					{
						num2 = num;
						if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -3) : null).GetValueOrDefault())
						{
							int? num4 = activeUnit_0.vmethod_7(false).method_80(nullable_42, ref activeUnit_0, ref contact_0, ref weapon_0);
							num2 = num4;
							if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								result = ((num4 != null) ? Conversions.ToString(num4.GetValueOrDefault()) : null) + "x rnd per salvo (using twice the target's Missile Defence value)";
							}
							else
							{
								result = ((num4 != null) ? Conversions.ToString(num4.GetValueOrDefault()) : null) + "x rnds per salvo (using twice the target's Missile Defence value)";
							}
						}
						else
						{
							num2 = num;
							if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -4) : null).GetValueOrDefault())
							{
								int? num5 = activeUnit_0.vmethod_7(false).method_80(nullable_42, ref activeUnit_0, ref contact_0, ref weapon_0);
								num2 = num5;
								if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									result = ((num5 != null) ? Conversions.ToString(num5.GetValueOrDefault()) : null) + "x rnd per salvo (using four times the target's Missile Defence value)";
								}
								else
								{
									result = ((num5 != null) ? Conversions.ToString(num5.GetValueOrDefault()) : null) + "x rnds per salvo (using four times the target's Missile Defence value)";
								}
							}
							else
							{
								num2 = num;
								if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -5) : null).GetValueOrDefault())
								{
									int? num6 = activeUnit_0.vmethod_7(false).method_80(nullable_42, ref activeUnit_0, ref contact_0, ref weapon_0);
									num2 = num6;
									if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
									{
										result = ((num6 != null) ? Conversions.ToString(num6.GetValueOrDefault()) : null) + "x rnd per salvo (using half the target's Missile Defence value)";
									}
									else
									{
										result = ((num6 != null) ? Conversions.ToString(num6.GetValueOrDefault()) : null) + "x rnds per salvo (using half the target's Missile Defence value)";
									}
								}
								else
								{
									num2 = num;
									if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -6) : null).GetValueOrDefault())
									{
										int? num7 = activeUnit_0.vmethod_7(false).method_80(nullable_42, ref activeUnit_0, ref contact_0, ref weapon_0);
										num2 = num7;
										if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											result = ((num7 != null) ? Conversions.ToString(num7.GetValueOrDefault()) : null) + "x rnd per salvo (using one-fourth the target's Missile Defence value)";
										}
										else
										{
											result = ((num7 != null) ? Conversions.ToString(num7.GetValueOrDefault()) : null) + "x rnds per salvo (using one-fourth the target's Missile Defence value)";
										}
									}
									else
									{
										num2 = num;
										if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -98) : null).GetValueOrDefault())
										{
											result = "Not defined";
										}
										else
										{
											num2 = num;
											if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -1) : null).GetValueOrDefault())
											{
												int? num8 = activeUnit_0.vmethod_7(false).method_80(nullable_42, ref activeUnit_0, ref contact_0, ref weapon_0);
												num2 = num8;
												if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
												{
													result = ((num8 != null) ? Conversions.ToString(num8.GetValueOrDefault()) : null) + "x rnd per salvo (using system default)";
												}
												else
												{
													result = ((num8 != null) ? Conversions.ToString(num8.GetValueOrDefault()) : null) + "x rnds per salvo (using system default)";
												}
											}
											else
											{
												num2 = num;
												if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
												{
													result = "Various weapon quantities";
												}
												else
												{
													num2 = nullable_42;
													if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
													{
														result = nullable_42.ToString() + "x rnd per salvo";
													}
													else
													{
														result = nullable_42.ToString() + "x rnds per salvo";
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0013D210 File Offset: 0x0013B410
		public string method_226(int? nullable_42)
		{
			if (Information.IsNothing(nullable_42))
			{
				nullable_42 = new int?(-99);
			}
			int? num = nullable_42;
			int? num2 = num;
			string result;
			if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				result = "No automatic fire against this target type, manual fire only";
			}
			else
			{
				num2 = num;
				if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
				{
					result = "Weapon launch at max range";
				}
				else
				{
					num2 = num;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -98) : null).GetValueOrDefault())
					{
						result = "Not defined";
					}
					else
					{
						num2 = num;
						if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
						{
							result = "Various firing ranges";
						}
						else
						{
							result = ((nullable_42 != null) ? Conversions.ToString(nullable_42.GetValueOrDefault()) : null) + "nm maximum firing range";
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0013D340 File Offset: 0x0013B540
		public int? method_227(ref Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, ref object object_0)
		{
			int? result;
			try
			{
				Doctrine._WRA_WeaponTargetType wra_WeaponTargetType = _WRA_WeaponTargetType_0;
				if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons)
				{
					if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic)
					{
						if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Recon_EW)
						{
							if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type > 5 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers > 2 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW > 2)
							{
								goto IL_511;
							}
						}
						else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_AEW > 1 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified > 4)
						{
							goto IL_511;
						}
					}
					else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type)
					{
						if (wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
						{
							if (wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
							{
								if (wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type)
								{
									goto IL_511;
								}
								goto IL_36F;
							}
							else
							{
								switch (Conversions.ToInteger(object_0))
								{
								case 2:
									return new int?(0);
								case 3:
									return new int?(1);
								case 4:
									return new int?(2);
								case 5:
									return new int?(-99);
								case 6:
									return new int?(-100);
								default:
									return null;
								}
							}
						}
					}
					else
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Unspecified > 4 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons > 7 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons > 7)
						{
							goto IL_511;
						}
						goto IL_1EA;
					}
					switch (Conversions.ToInteger(object_0))
					{
					case 2:
						return new int?(0);
					case 3:
						return new int?(1);
					case 4:
						return new int?(2);
					case 5:
						return new int?(3);
					case 6:
						return new int?(-99);
					case 7:
						return new int?(-100);
					default:
						return null;
					}
				}
				else
				{
					if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted)
					{
						if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
						{
							if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons > 7 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons > 7 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
							{
								goto IL_511;
							}
							goto IL_1EA;
						}
						else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type > 1)
						{
							switch (wra_WeaponTargetType)
							{
							case Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type:
								goto IL_36F;
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring:
								break;
							case (Doctrine._WRA_WeaponTargetType)5003:
							case (Doctrine._WRA_WeaponTargetType)5004:
							case (Doctrine._WRA_WeaponTargetType)5007:
							case (Doctrine._WRA_WeaponTargetType)5008:
							case (Doctrine._WRA_WeaponTargetType)5009:
							case (Doctrine._WRA_WeaponTargetType)5010:
								goto IL_511;
							default:
								if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified > 6)
								{
									goto IL_511;
								}
								break;
							}
						}
						else
						{
							switch (Conversions.ToInteger(object_0))
							{
							case 2:
								return new int?(0);
							case 3:
								return new int?(1);
							case 4:
								return new int?(2);
							case 5:
								return new int?(3);
							case 6:
								return new int?(4);
							case 7:
								return new int?(-99);
							case 8:
								return new int?(-100);
							default:
								return null;
							}
						}
					}
					else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel)
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified > 3 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Radar_Unspecified && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified > 2)
						{
							goto IL_511;
						}
					}
					else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified > 1 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Underwater_Structure && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
					{
						goto IL_511;
					}
					switch (Conversions.ToInteger(object_0))
					{
					case 2:
						return new int?(0);
					case 3:
						return new int?(-2);
					case 4:
						return new int?(-3);
					case 5:
						return new int?(-4);
					case 6:
						return new int?(-5);
					case 7:
						return new int?(-6);
					case 8:
						return new int?(1);
					case 9:
						return new int?(2);
					case 10:
						return new int?(3);
					case 11:
						return new int?(4);
					case 12:
						return new int?(5);
					case 13:
						return new int?(6);
					case 14:
						return new int?(7);
					case 15:
						return new int?(8);
					case 16:
						return new int?(-99);
					case 17:
						return new int?(-100);
					default:
						return null;
					}
				}
				IL_1EA:
				switch (Conversions.ToInteger(object_0))
				{
				case 2:
					return new int?(0);
				case 3:
					return new int?(-2);
				case 4:
					return new int?(-3);
				case 5:
					return new int?(-4);
				case 6:
					return new int?(-5);
				case 7:
					return new int?(-6);
				case 8:
					return new int?(1);
				case 9:
					return new int?(2);
				case 10:
					return new int?(3);
				case 11:
					return new int?(4);
				case 12:
					return new int?(5);
				case 13:
					return new int?(6);
				case 14:
					return new int?(7);
				case 15:
					return new int?(8);
				case 16:
					return new int?(-99);
				case 17:
					return new int?(-100);
				default:
					return null;
				}
				IL_36F:
				switch (Conversions.ToInteger(object_0))
				{
				case 2:
					return new int?(0);
				case 3:
					return new int?(1);
				case 4:
					return new int?(2);
				case 5:
					return new int?(3);
				case 6:
					return new int?(4);
				case 7:
					return new int?(5);
				case 8:
					return new int?(6);
				case 9:
					return new int?(7);
				case 10:
					return new int?(8);
				case 11:
					return new int?(-99);
				case 12:
					return new int?(-100);
				default:
					return null;
				}
				IL_511:
				result = new int?(0);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101197", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0013D9D0 File Offset: 0x0013BBD0
		public int method_228(ref Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, int? nullable_42)
		{
			int result;
			try
			{
				Doctrine._WRA_WeaponTargetType wra_WeaponTargetType = _WRA_WeaponTargetType_0;
				if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons)
				{
					if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic)
					{
						if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Recon_EW)
						{
							if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type > 5 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers > 2 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW > 2)
							{
								goto IL_DBD;
							}
						}
						else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_AEW > 1 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified > 4)
						{
							goto IL_DBD;
						}
					}
					else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type)
					{
						if (wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
						{
							if (wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
							{
								if (wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type)
								{
									goto IL_DBD;
								}
								goto IL_89D;
							}
							else
							{
								int? num = nullable_42;
								if (((num != null) ? new bool?(num.GetValueOrDefault() == -1) : null).GetValueOrDefault())
								{
									return 1;
								}
								num = nullable_42;
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									return 2;
								}
								num = nullable_42;
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									return 3;
								}
								num = nullable_42;
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									return 4;
								}
								num = nullable_42;
								if (((num != null) ? new bool?(num.GetValueOrDefault() == -99) : null).GetValueOrDefault())
								{
									return 5;
								}
								num = nullable_42;
								if (((num != null) ? new bool?(num.GetValueOrDefault() == -100) : null).GetValueOrDefault())
								{
									return 6;
								}
								if (this.class310_0.GetType() == typeof(Side))
								{
									return 1;
								}
								return 0;
							}
						}
					}
					else
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Unspecified > 4 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons > 7 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons > 7)
						{
							goto IL_DBD;
						}
						goto IL_42C;
					}
					int? num2 = nullable_42;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -1) : null).GetValueOrDefault())
					{
						return 1;
					}
					num2 = nullable_42;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						return 2;
					}
					num2 = nullable_42;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						return 3;
					}
					num2 = nullable_42;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						return 4;
					}
					num2 = nullable_42;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 3) : null).GetValueOrDefault())
					{
						return 5;
					}
					num2 = nullable_42;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
					{
						return 6;
					}
					num2 = nullable_42;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
					{
						return 7;
					}
					if (this.class310_0.GetType() == typeof(Side))
					{
						return 1;
					}
					return 0;
				}
				else
				{
					if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted)
					{
						if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
						{
							if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons > 7 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons > 7 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
							{
								goto IL_DBD;
							}
							goto IL_42C;
						}
						else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type > 1)
						{
							switch (wra_WeaponTargetType)
							{
							case Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type:
								goto IL_89D;
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring:
								break;
							case (Doctrine._WRA_WeaponTargetType)5003:
							case (Doctrine._WRA_WeaponTargetType)5004:
							case (Doctrine._WRA_WeaponTargetType)5007:
							case (Doctrine._WRA_WeaponTargetType)5008:
							case (Doctrine._WRA_WeaponTargetType)5009:
							case (Doctrine._WRA_WeaponTargetType)5010:
								goto IL_DBD;
							default:
								if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified > 6)
								{
									goto IL_DBD;
								}
								break;
							}
						}
						else
						{
							int? num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == -1) : null).GetValueOrDefault())
							{
								return 1;
							}
							num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								return 2;
							}
							num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								return 3;
							}
							num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								return 4;
							}
							num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								return 5;
							}
							num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								return 6;
							}
							num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == -99) : null).GetValueOrDefault())
							{
								return 7;
							}
							num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == -100) : null).GetValueOrDefault())
							{
								return 8;
							}
							if (this.class310_0.GetType() == typeof(Side))
							{
								return 1;
							}
							return 0;
						}
					}
					else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel)
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified > 3 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Radar_Unspecified && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified > 2)
						{
							goto IL_DBD;
						}
					}
					else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified > 1 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Underwater_Structure && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
					{
						goto IL_DBD;
					}
					int? num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == -1) : null).GetValueOrDefault())
					{
						return 1;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						return 2;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == -2) : null).GetValueOrDefault())
					{
						return 3;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == -3) : null).GetValueOrDefault())
					{
						return 4;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == -4) : null).GetValueOrDefault())
					{
						return 5;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == -5) : null).GetValueOrDefault())
					{
						return 6;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == -6) : null).GetValueOrDefault())
					{
						return 7;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						return 8;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						return 9;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 3) : null).GetValueOrDefault())
					{
						return 10;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 4) : null).GetValueOrDefault())
					{
						return 11;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 5) : null).GetValueOrDefault())
					{
						return 12;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 6) : null).GetValueOrDefault())
					{
						return 13;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 7) : null).GetValueOrDefault())
					{
						return 14;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 8) : null).GetValueOrDefault())
					{
						return 15;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == -99) : null).GetValueOrDefault())
					{
						return 16;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == -100) : null).GetValueOrDefault())
					{
						return 17;
					}
					if (this.class310_0.GetType() == typeof(Side))
					{
						return 1;
					}
					return 0;
				}
				IL_42C:
				int? num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == -1) : null).GetValueOrDefault())
				{
					return 1;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					return 2;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == -2) : null).GetValueOrDefault())
				{
					return 3;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == -3) : null).GetValueOrDefault())
				{
					return 4;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == -4) : null).GetValueOrDefault())
				{
					return 5;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == -5) : null).GetValueOrDefault())
				{
					return 6;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == -6) : null).GetValueOrDefault())
				{
					return 7;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					return 8;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					return 9;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					return 10;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 4) : null).GetValueOrDefault())
				{
					return 11;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 5) : null).GetValueOrDefault())
				{
					return 12;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 6) : null).GetValueOrDefault())
				{
					return 13;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 7) : null).GetValueOrDefault())
				{
					return 14;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 8) : null).GetValueOrDefault())
				{
					return 15;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == -99) : null).GetValueOrDefault())
				{
					return 16;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == -100) : null).GetValueOrDefault())
				{
					return 17;
				}
				if (this.class310_0.GetType() == typeof(Side))
				{
					return 1;
				}
				return 0;
				IL_89D:
				int? num6 = nullable_42;
				if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == -1) : null).GetValueOrDefault())
				{
					return 1;
				}
				num6 = nullable_42;
				if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					return 2;
				}
				num6 = nullable_42;
				if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					return 3;
				}
				num6 = nullable_42;
				if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					return 4;
				}
				num6 = nullable_42;
				if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					return 5;
				}
				num6 = nullable_42;
				if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == 4) : null).GetValueOrDefault())
				{
					return 6;
				}
				num6 = nullable_42;
				if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == 5) : null).GetValueOrDefault())
				{
					return 7;
				}
				num6 = nullable_42;
				if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == 6) : null).GetValueOrDefault())
				{
					return 8;
				}
				num6 = nullable_42;
				if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == 7) : null).GetValueOrDefault())
				{
					return 9;
				}
				num6 = nullable_42;
				if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == 8) : null).GetValueOrDefault())
				{
					return 10;
				}
				num6 = nullable_42;
				if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == -99) : null).GetValueOrDefault())
				{
					return 11;
				}
				num6 = nullable_42;
				if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == -100) : null).GetValueOrDefault())
				{
					return 12;
				}
				if (this.class310_0.GetType() == typeof(Side))
				{
					return 1;
				}
				return 0;
				IL_DBD:
				result = 0;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101198", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0013EC04 File Offset: 0x0013CE04
		public int? method_229(ref object object_0)
		{
			int? result;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 2:
					result = new int?(-99);
					break;
				case 3:
					result = new int?(1);
					break;
				case 4:
					result = new int?(2);
					break;
				case 5:
					result = new int?(4);
					break;
				case 6:
					result = new int?(-100);
					break;
				default:
					result = null;
					break;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101212", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0013ECC0 File Offset: 0x0013CEC0
		public int method_230(int? nullable_42)
		{
			int result;
			try
			{
				int? num = nullable_42;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == -1) : null).GetValueOrDefault())
				{
					result = 1;
				}
				else
				{
					num = nullable_42;
					if (((num != null) ? new bool?(num.GetValueOrDefault() == -99) : null).GetValueOrDefault())
					{
						result = 2;
					}
					else
					{
						num = nullable_42;
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							result = 3;
						}
						else
						{
							num = nullable_42;
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								result = 4;
							}
							else
							{
								num = nullable_42;
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									result = 5;
								}
								else
								{
									num = nullable_42;
									if (((num != null) ? new bool?(num.GetValueOrDefault() == -100) : null).GetValueOrDefault())
									{
										result = 6;
									}
									else if (this.class310_0.GetType() == typeof(Side))
									{
										result = 1;
									}
									else
									{
										result = 0;
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101213", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0013EE88 File Offset: 0x0013D088
		public int? method_231(ref Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, ref object object_0)
		{
			int? result;
			try
			{
				Doctrine._WRA_WeaponTargetType wra_WeaponTargetType = _WRA_WeaponTargetType_0;
				if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons)
				{
					if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
					{
						if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Bombers)
						{
							if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type > 5 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers > 2)
							{
								goto IL_36B;
							}
						}
						else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW > 2 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_AEW > 1 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
						{
							goto IL_36B;
						}
					}
					else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified > 4 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
						{
							if (wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
							{
								goto IL_36B;
							}
							int num = Conversions.ToInteger(object_0);
							if (num == 2)
							{
								return new int?(0);
							}
							if (num != 3)
							{
								return null;
							}
							return new int?(-100);
						}
					}
					else
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type > 5 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons > 7 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons > 7)
						{
							goto IL_36B;
						}
						goto IL_1A9;
					}
					switch (Conversions.ToInteger(object_0))
					{
					case 2:
						return new int?(0);
					case 3:
						return new int?(2);
					case 4:
						return new int?(5);
					case 5:
						return new int?(10);
					case 6:
						return new int?(15);
					case 7:
						return new int?(-99);
					case 8:
						return new int?(-100);
					default:
						return null;
					}
				}
				else
				{
					if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted)
					{
						if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
						{
							if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons > 7 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons > 7 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
							{
								goto IL_36B;
							}
							goto IL_1A9;
						}
						else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type > 1)
						{
							switch (wra_WeaponTargetType)
							{
							case Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring:
								break;
							case (Doctrine._WRA_WeaponTargetType)5003:
							case (Doctrine._WRA_WeaponTargetType)5004:
							case (Doctrine._WRA_WeaponTargetType)5007:
							case (Doctrine._WRA_WeaponTargetType)5008:
							case (Doctrine._WRA_WeaponTargetType)5009:
							case (Doctrine._WRA_WeaponTargetType)5010:
								goto IL_36B;
							default:
								if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified > 6)
								{
									goto IL_36B;
								}
								break;
							}
						}
						else
						{
							switch (Conversions.ToInteger(object_0))
							{
							case 2:
								return new int?(0);
							case 3:
								return new int?(2);
							case 4:
								return new int?(5);
							case 5:
								return new int?(10);
							case 6:
								return new int?(15);
							case 7:
								return new int?(-99);
							case 8:
								return new int?(-100);
							default:
								return null;
							}
						}
					}
					else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel)
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified > 3 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Radar_Unspecified && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified > 2)
						{
							goto IL_36B;
						}
					}
					else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified > 1 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Underwater_Structure && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
					{
						goto IL_36B;
					}
					switch (Conversions.ToInteger(object_0))
					{
					case 2:
						return new int?(0);
					case 3:
						return new int?(2);
					case 4:
						return new int?(5);
					case 5:
						return new int?(10);
					case 6:
						return new int?(15);
					case 7:
						return new int?(-99);
					case 8:
						return new int?(-100);
					default:
						return null;
					}
				}
				IL_1A9:
				switch (Conversions.ToInteger(object_0))
				{
				case 2:
					return new int?(0);
				case 3:
					return new int?(2);
				case 4:
					return new int?(5);
				case 5:
					return new int?(10);
				case 6:
					return new int?(15);
				case 7:
					return new int?(-99);
				case 8:
					return new int?(-100);
				default:
					return null;
				}
				IL_36B:
				result = null;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101199", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0013F2E8 File Offset: 0x0013D4E8
		public int method_232(ref Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0, int? nullable_42)
		{
			int result;
			try
			{
				Doctrine._WRA_WeaponTargetType wra_WeaponTargetType = _WRA_WeaponTargetType_0;
				if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons)
				{
					if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
					{
						if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Bombers)
						{
							if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type > 5 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers > 2)
							{
								goto IL_825;
							}
						}
						else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW > 2 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Aircraft_AEW > 1 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified)
						{
							goto IL_825;
						}
					}
					else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified > 4 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic)
						{
							if (wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Satellite_Unspecified)
							{
								goto IL_825;
							}
							int? num = nullable_42;
							if (((num != null) ? new bool?(num.GetValueOrDefault() == -1) : null).GetValueOrDefault())
							{
								return 1;
							}
							num = nullable_42;
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								return 2;
							}
							num = nullable_42;
							if (((num != null) ? new bool?(num.GetValueOrDefault() == -100) : null).GetValueOrDefault())
							{
								return 3;
							}
							return 0;
						}
					}
					else
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type > 5 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons > 7 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons > 7)
						{
							goto IL_825;
						}
						goto IL_391;
					}
					int? num2 = nullable_42;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -1) : null).GetValueOrDefault())
					{
						return 1;
					}
					num2 = nullable_42;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						return 2;
					}
					num2 = nullable_42;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						return 3;
					}
					num2 = nullable_42;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 5) : null).GetValueOrDefault())
					{
						return 4;
					}
					num2 = nullable_42;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 10) : null).GetValueOrDefault())
					{
						return 5;
					}
					num2 = nullable_42;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 15) : null).GetValueOrDefault())
					{
						return 6;
					}
					num2 = nullable_42;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
					{
						return 7;
					}
					num2 = nullable_42;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
					{
						return 8;
					}
					if (this.class310_0.GetType() == typeof(Side))
					{
						return 1;
					}
					return 0;
				}
				else
				{
					if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted)
					{
						if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
						{
							if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons > 7 && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons > 7 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Submarine_Surfaced)
							{
								goto IL_825;
							}
							goto IL_391;
						}
						else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type > 1)
						{
							switch (wra_WeaponTargetType)
							{
							case Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted:
							case Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring:
								break;
							case (Doctrine._WRA_WeaponTargetType)5003:
							case (Doctrine._WRA_WeaponTargetType)5004:
							case (Doctrine._WRA_WeaponTargetType)5007:
							case (Doctrine._WRA_WeaponTargetType)5008:
							case (Doctrine._WRA_WeaponTargetType)5009:
							case (Doctrine._WRA_WeaponTargetType)5010:
								goto IL_825;
							default:
								if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified > 6)
								{
									goto IL_825;
								}
								break;
							}
						}
						else
						{
							int? num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == -1) : null).GetValueOrDefault())
							{
								return 1;
							}
							num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								return 2;
							}
							num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								return 3;
							}
							num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 5) : null).GetValueOrDefault())
							{
								return 4;
							}
							num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 10) : null).GetValueOrDefault())
							{
								return 5;
							}
							num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 15) : null).GetValueOrDefault())
							{
								return 6;
							}
							num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == -99) : null).GetValueOrDefault())
							{
								return 7;
							}
							num3 = nullable_42;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == -100) : null).GetValueOrDefault())
							{
								return 8;
							}
							if (this.class310_0.GetType() == typeof(Side))
							{
								return 1;
							}
							return 0;
						}
					}
					else if (wra_WeaponTargetType <= Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel)
					{
						if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified > 3 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Radar_Unspecified && wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified > 2)
						{
							goto IL_825;
						}
					}
					else if (wra_WeaponTargetType - Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified > 1 && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Underwater_Structure && wra_WeaponTargetType != Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield)
					{
						goto IL_825;
					}
					int? num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == -1) : null).GetValueOrDefault())
					{
						return 1;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						return 2;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						return 3;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 5) : null).GetValueOrDefault())
					{
						return 4;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 10) : null).GetValueOrDefault())
					{
						return 5;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 15) : null).GetValueOrDefault())
					{
						return 6;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == -99) : null).GetValueOrDefault())
					{
						return 7;
					}
					num4 = nullable_42;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == -100) : null).GetValueOrDefault())
					{
						return 8;
					}
					if (this.class310_0.GetType() == typeof(Side))
					{
						return 1;
					}
					return 0;
				}
				IL_391:
				int? num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == -1) : null).GetValueOrDefault())
				{
					return 1;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					return 2;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					return 3;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 5) : null).GetValueOrDefault())
				{
					return 4;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 10) : null).GetValueOrDefault())
				{
					return 5;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 15) : null).GetValueOrDefault())
				{
					return 6;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == -99) : null).GetValueOrDefault())
				{
					return 7;
				}
				num5 = nullable_42;
				if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == -100) : null).GetValueOrDefault())
				{
					return 8;
				}
				if (this.class310_0.GetType() == typeof(Side))
				{
					return 1;
				}
				return 0;
				IL_825:
				result = 0;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101200", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0013FD6C File Offset: 0x0013DF6C
		public int? method_233(ref object object_0)
		{
			int? result;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 1:
					result = new int?(-99);
					break;
				case 2:
					result = new int?(0);
					break;
				case 3:
					result = new int?(2);
					break;
				case 4:
					result = new int?(5);
					break;
				case 5:
					result = new int?(10);
					break;
				case 6:
					result = new int?(15);
					break;
				case 7:
					result = new int?(20);
					break;
				case 8:
					result = new int?(25);
					break;
				case 9:
					result = new int?(30);
					break;
				case 10:
					result = new int?(35);
					break;
				case 11:
					result = new int?(40);
					break;
				case 12:
					result = new int?(45);
					break;
				case 13:
					result = new int?(50);
					break;
				case 14:
					result = new int?(60);
					break;
				case 15:
					result = new int?(70);
					break;
				case 16:
					result = new int?(80);
					break;
				case 17:
					result = new int?(90);
					break;
				case 18:
					result = new int?(100);
					break;
				case 19:
					result = new int?(125);
					break;
				case 20:
					result = new int?(150);
					break;
				case 21:
					result = new int?(175);
					break;
				case 22:
					result = new int?(200);
					break;
				case 23:
					result = new int?(250);
					break;
				case 24:
					result = new int?(300);
					break;
				case 25:
					result = new int?(500);
					break;
				case 26:
					result = new int?(750);
					break;
				case 27:
					result = new int?(1000);
					break;
				case 28:
					result = new int?(1500);
					break;
				case 29:
					result = new int?(2000);
					break;
				case 30:
					result = new int?(-100);
					break;
				default:
					result = null;
					break;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101201", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0013FFF8 File Offset: 0x0013E1F8
		public int method_234(int? nullable_42)
		{
			int result;
			try
			{
				int? num = nullable_42;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == -99) : null).GetValueOrDefault())
				{
					result = 1;
				}
				else
				{
					num = nullable_42;
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						result = 2;
					}
					else
					{
						num = nullable_42;
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							result = 3;
						}
						else
						{
							num = nullable_42;
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
							{
								result = 4;
							}
							else
							{
								num = nullable_42;
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 10) : null).GetValueOrDefault())
								{
									result = 5;
								}
								else
								{
									num = nullable_42;
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 15) : null).GetValueOrDefault())
									{
										result = 6;
									}
									else
									{
										num = nullable_42;
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 20) : null).GetValueOrDefault())
										{
											result = 7;
										}
										else
										{
											num = nullable_42;
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 25) : null).GetValueOrDefault())
											{
												result = 8;
											}
											else
											{
												num = nullable_42;
												if (((num != null) ? new bool?(num.GetValueOrDefault() == 30) : null).GetValueOrDefault())
												{
													result = 9;
												}
												else
												{
													num = nullable_42;
													if (((num != null) ? new bool?(num.GetValueOrDefault() == 35) : null).GetValueOrDefault())
													{
														result = 10;
													}
													else
													{
														num = nullable_42;
														if (((num != null) ? new bool?(num.GetValueOrDefault() == 40) : null).GetValueOrDefault())
														{
															result = 11;
														}
														else
														{
															num = nullable_42;
															if (((num != null) ? new bool?(num.GetValueOrDefault() == 45) : null).GetValueOrDefault())
															{
																result = 12;
															}
															else
															{
																num = nullable_42;
																if (((num != null) ? new bool?(num.GetValueOrDefault() == 50) : null).GetValueOrDefault())
																{
																	result = 13;
																}
																else
																{
																	num = nullable_42;
																	if (((num != null) ? new bool?(num.GetValueOrDefault() == 60) : null).GetValueOrDefault())
																	{
																		result = 14;
																	}
																	else
																	{
																		num = nullable_42;
																		if (((num != null) ? new bool?(num.GetValueOrDefault() == 70) : null).GetValueOrDefault())
																		{
																			result = 15;
																		}
																		else
																		{
																			num = nullable_42;
																			if (((num != null) ? new bool?(num.GetValueOrDefault() == 80) : null).GetValueOrDefault())
																			{
																				result = 16;
																			}
																			else
																			{
																				num = nullable_42;
																				if (((num != null) ? new bool?(num.GetValueOrDefault() == 90) : null).GetValueOrDefault())
																				{
																					result = 17;
																				}
																				else
																				{
																					num = nullable_42;
																					if (((num != null) ? new bool?(num.GetValueOrDefault() == 100) : null).GetValueOrDefault())
																					{
																						result = 18;
																					}
																					else
																					{
																						num = nullable_42;
																						if (((num != null) ? new bool?(num.GetValueOrDefault() == 125) : null).GetValueOrDefault())
																						{
																							result = 19;
																						}
																						else
																						{
																							num = nullable_42;
																							if (((num != null) ? new bool?(num.GetValueOrDefault() == 150) : null).GetValueOrDefault())
																							{
																								result = 20;
																							}
																							else
																							{
																								num = nullable_42;
																								if (((num != null) ? new bool?(num.GetValueOrDefault() == 175) : null).GetValueOrDefault())
																								{
																									result = 21;
																								}
																								else
																								{
																									num = nullable_42;
																									if (((num != null) ? new bool?(num.GetValueOrDefault() == 200) : null).GetValueOrDefault())
																									{
																										result = 22;
																									}
																									else
																									{
																										num = nullable_42;
																										if (((num != null) ? new bool?(num.GetValueOrDefault() == 250) : null).GetValueOrDefault())
																										{
																											result = 23;
																										}
																										else
																										{
																											num = nullable_42;
																											if (((num != null) ? new bool?(num.GetValueOrDefault() == 300) : null).GetValueOrDefault())
																											{
																												result = 24;
																											}
																											else
																											{
																												num = nullable_42;
																												if (((num != null) ? new bool?(num.GetValueOrDefault() == 500) : null).GetValueOrDefault())
																												{
																													result = 25;
																												}
																												else
																												{
																													num = nullable_42;
																													if (((num != null) ? new bool?(num.GetValueOrDefault() == 750) : null).GetValueOrDefault())
																													{
																														result = 26;
																													}
																													else
																													{
																														num = nullable_42;
																														if (((num != null) ? new bool?(num.GetValueOrDefault() == 1000) : null).GetValueOrDefault())
																														{
																															result = 27;
																														}
																														else
																														{
																															num = nullable_42;
																															if (((num != null) ? new bool?(num.GetValueOrDefault() == 1500) : null).GetValueOrDefault())
																															{
																																result = 28;
																															}
																															else
																															{
																																num = nullable_42;
																																if (((num != null) ? new bool?(num.GetValueOrDefault() == 2000) : null).GetValueOrDefault())
																																{
																																	result = 29;
																																}
																																else
																																{
																																	num = nullable_42;
																																	if (((num != null) ? new bool?(num.GetValueOrDefault() == -100) : null).GetValueOrDefault())
																																	{
																																		result = 30;
																																	}
																																	else if (this.class310_0.GetType() == typeof(Side))
																																	{
																																		result = 1;
																																	}
																																	else
																																	{
																																		result = 0;
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101202", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00140720 File Offset: 0x0013E920
		public string method_235(int? nullable_42, bool bool_35)
		{
			string text = "";
			if (bool_35)
			{
				text = " (Using 'Unspecified' target type settings)";
			}
			int? num = nullable_42;
			int? num2 = num;
			string result;
			if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -1) : null).GetValueOrDefault())
			{
				result = "System default (from database)" + text;
			}
			else
			{
				num2 = num;
				if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					result = "Do not use weapon against this target type" + text;
				}
				else
				{
					num2 = num;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -98) : null).GetValueOrDefault())
					{
						result = "Not defined" + text;
					}
					else
					{
						num2 = num;
						if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
						{
							result = "All weapons" + text;
						}
						else
						{
							num2 = num;
							if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -2) : null).GetValueOrDefault())
							{
								result = "Target's Missile Defence value" + text;
							}
							else
							{
								num2 = num;
								if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -3) : null).GetValueOrDefault())
								{
									result = "2x Target's Missile Defence value" + text;
								}
								else
								{
									num2 = num;
									if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -4) : null).GetValueOrDefault())
									{
										result = "4x Target's Missile Defence value" + text;
									}
									else
									{
										num2 = num;
										if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -5) : null).GetValueOrDefault())
										{
											result = "1/2 Target's Missile Defence value" + text;
										}
										else
										{
											num2 = num;
											if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -6) : null).GetValueOrDefault())
											{
												result = "1/4 Target's Missile Defence value" + text;
											}
											else
											{
												num2 = num;
												if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
												{
													result = "Various" + text;
												}
												else if (!Information.IsNothing(nullable_42))
												{
													num2 = nullable_42;
													if (((num2 != null) ? new bool?(num2.GetValueOrDefault() > 1) : null).GetValueOrDefault())
													{
														result = nullable_42.ToString() + " rnds" + text;
													}
													else
													{
														result = nullable_42.ToString() + " rnd" + text;
													}
												}
												else
												{
													result = text + "Not Configured";
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00140A5C File Offset: 0x0013EC5C
		public string method_236(int? nullable_42, bool bool_35)
		{
			string text = "";
			if (bool_35)
			{
				text = " (Using 'Unspecified' target type settings)";
			}
			int? num = nullable_42;
			int? num2 = num;
			string result;
			if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -1) : null).GetValueOrDefault())
			{
				result = "System default (from database)" + text;
			}
			else
			{
				num2 = num;
				if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
				{
					result = "Fire weapons from enough units to fill the salvo's Weapon Qty requirement" + text;
				}
				else
				{
					num2 = num;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
					{
						result = "Various" + text;
					}
					else if (!Information.IsNothing(nullable_42))
					{
						num2 = nullable_42;
						if (((num2 != null) ? new bool?(num2.GetValueOrDefault() > 1) : null).GetValueOrDefault())
						{
							result = nullable_42.ToString() + " units" + text;
						}
						else
						{
							result = nullable_42.ToString() + " unit" + text;
						}
					}
					else
					{
						result = text + "Not Configured";
					}
				}
			}
			return result;
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00140BC4 File Offset: 0x0013EDC4
		public string method_237(int? nullable_42, bool bool_35)
		{
			string text = "";
			if (bool_35)
			{
				text = " (Using 'Unspecified' target type settings)";
			}
			int? num = nullable_42;
			int? num2 = num;
			string result;
			if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -1) : null).GetValueOrDefault())
			{
				result = "System default (from database)" + text;
			}
			else
			{
				num2 = num;
				if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					result = "Do not use weapon in self defence" + text;
				}
				else
				{
					num2 = num;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -98) : null).GetValueOrDefault())
					{
						result = "Not defined" + text;
					}
					else
					{
						num2 = num;
						if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
						{
							result = "Maximum range" + text;
						}
						else
						{
							num2 = num;
							if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
							{
								result = "Various" + text;
							}
							else if (!Information.IsNothing(nullable_42))
							{
								result = nullable_42.ToString() + " nm" + text;
							}
							else
							{
								result = "Not Configured" + text;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x00140D60 File Offset: 0x0013EF60
		public string method_238(int? nullable_42, bool bool_35)
		{
			string text = "";
			if (bool_35)
			{
				text = " (Using 'Unspecified' target type settings)";
			}
			int? num = nullable_42;
			int? num2 = num;
			string result;
			if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				result = "No automatic use, manual fire only" + text;
			}
			else
			{
				num2 = num;
				if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -98) : null).GetValueOrDefault())
				{
					result = "Not defined" + text;
				}
				else
				{
					num2 = num;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -99) : null).GetValueOrDefault())
					{
						result = "Automatic Fire to Max Range" + text;
					}
					else
					{
						num2 = num;
						if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -100) : null).GetValueOrDefault())
						{
							result = "Various" + text;
						}
						else if (!Information.IsNothing(nullable_42))
						{
							result = nullable_42.ToString() + "nm" + text;
						}
						else
						{
							result = "";
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x00140EB4 File Offset: 0x0013F0B4
		public bool method_239(ref Weapon weapon_0)
		{
			Weapon._WeaponType weaponType = weapon_0.method_167();
			if (weaponType <= Weapon._WeaponType.FerryTank)
			{
				switch (weaponType)
				{
				case Weapon._WeaponType.Decoy_Expendable:
					return false;
				case Weapon._WeaponType.Decoy_Towed:
					return false;
				case Weapon._WeaponType.Decoy_Vehicle:
					return false;
				case Weapon._WeaponType.TrainingRound:
					return false;
				default:
					switch (weaponType)
					{
					case Weapon._WeaponType.SensorPod:
						return false;
					case Weapon._WeaponType.DropTank:
						return false;
					case Weapon._WeaponType.BuddyStore:
						return false;
					case Weapon._WeaponType.FerryTank:
						return false;
					}
					break;
				}
			}
			else
			{
				if (weaponType == Weapon._WeaponType.Sonobuoy)
				{
					return false;
				}
				if (weaponType == Weapon._WeaponType.HeliTowedPackage)
				{
					return false;
				}
				switch (weaponType)
				{
				case Weapon._WeaponType.Cargo:
					return false;
				case Weapon._WeaponType.Troops:
					return false;
				case Weapon._WeaponType.Paratroops:
					return false;
				}
			}
			return true;
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00140F6C File Offset: 0x0013F16C
		public Doctrine._RefuelAlliedUnits? method_240(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._RefuelAlliedUnits? result;
			try
			{
				if (this.method_242())
				{
					Doctrine doctrine;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.method_3(scenario_0, ref flag);
					}
					result = doctrine.method_240(scenario_0, bool_35, bool_36, bool_37);
				}
				else
				{
					result = new Doctrine._RefuelAlliedUnits?(this.nullable_27.Value);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200452", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.No);
			}
			return result;
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00141008 File Offset: 0x0013F208
		public void method_241(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._RefuelAlliedUnits? nullable_42)
		{
			this.nullable_27 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0000A2AE File Offset: 0x000084AE
		public bool method_242()
		{
			return this.nullable_27 == null;
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00141040 File Offset: 0x0013F240
		public bool method_243(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_27;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_243(scenario_0);
			}
			return result;
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00141080 File Offset: 0x0013F280
		public void method_244(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_27 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_244(scenario_0, bool_35);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x001410C0 File Offset: 0x0013F2C0
		public void method_245(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._RefuelAlliedUnits? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Yes";
			string text2 = "Yes, receive only";
			string text3 = "Yes, offload only";
			string text4 = "No";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"Inherited, " + text3
								});
							}
							else
							{
								b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"Inherited, " + text4
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"Inherited, Various"
									});
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._RefuelAlliedUnits? refuelAlliedUnits = this.method_3(scenario_0, ref flag).method_240(scenario_0, false, false, false);
					b = ((refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"Inherited, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"Inherited, " + text4
								});
							}
						}
					}
				}
				Doctrine._RefuelAlliedUnits? refuelAlliedUnits2 = this.method_240(scenario_0, false, false, false);
				b = ((refuelAlliedUnits2 != null) ? new byte?((byte)refuelAlliedUnits2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00141698 File Offset: 0x0013F898
		public Doctrine._AvoidContactWhenPossible? method_246(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._AvoidContactWhenPossible? result;
			try
			{
				if (this.method_248())
				{
					Doctrine doctrine;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.method_3(scenario_0, ref flag);
					}
					result = doctrine.method_246(scenario_0, bool_35, bool_36, bool_37);
				}
				else
				{
					result = new Doctrine._AvoidContactWhenPossible?(this.nullable_28.Value);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200453", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Yes_Always);
			}
			return result;
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x00141734 File Offset: 0x0013F934
		public void method_247(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._AvoidContactWhenPossible? nullable_42)
		{
			this.nullable_28 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0000A2BE File Offset: 0x000084BE
		public bool method_248()
		{
			return this.nullable_28 == null;
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0014176C File Offset: 0x0013F96C
		public bool method_249(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_28;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_249(scenario_0);
			}
			return result;
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x001417AC File Offset: 0x0013F9AC
		public void method_250(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_28 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_250(scenario_0, bool_35);
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x001417EC File Offset: 0x0013F9EC
		public void method_251(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._AvoidContactWhenPossible? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "No";
			string text2 = "Yes, always";
			string text3 = "Yes, except in self defence";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._AvoidContactWhenPossible? avoidContactWhenPossible = this.method_3(scenario_0, ref flag).method_246(scenario_0, false, false, false);
					b = ((avoidContactWhenPossible != null) ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((avoidContactWhenPossible != null) ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text3
							});
						}
					}
				}
				Doctrine._AvoidContactWhenPossible? avoidContactWhenPossible2 = this.method_246(scenario_0, false, false, false);
				b = ((avoidContactWhenPossible2 != null) ? new byte?((byte)avoidContactWhenPossible2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00141C98 File Offset: 0x0013FE98
		public Doctrine._DiveOnContact? method_252(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._DiveOnContact? result;
			try
			{
				if (this.method_254())
				{
					Doctrine doctrine;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.method_3(scenario_0, ref flag);
					}
					result = doctrine.method_252(scenario_0, bool_35, bool_36, bool_37);
				}
				else
				{
					result = new Doctrine._DiveOnContact?(this.nullable_29.Value);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200454", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes);
			}
			return result;
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00141D34 File Offset: 0x0013FF34
		public void method_253(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._DiveOnContact? nullable_42)
		{
			this.nullable_29 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0000A2CE File Offset: 0x000084CE
		public bool method_254()
		{
			return this.nullable_29 == null;
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x00141D6C File Offset: 0x0013FF6C
		public bool method_255(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_29;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_255(scenario_0);
			}
			return result;
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00141DAC File Offset: 0x0013FFAC
		public void method_256(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_29 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_256(scenario_0, bool_35);
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00141DEC File Offset: 0x0013FFEC
		public void method_257(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._DiveOnContact? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Yes, on ESM detection and threat proximity";
			string text2 = "Yes, on periscope/surface search capable radar detection";
			string text3 = "Yes, when ships are within 20nm or aircraft within 30nm";
			string text4 = "No";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"Inherited, " + text3
								});
							}
							else
							{
								b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"Inherited, " + text4
									});
								}
								else
								{
									dataTable_0.Rows.Add(new object[]
									{
										4,
										"Inherited, Various"
									});
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._DiveOnContact? diveOnContact = this.method_3(scenario_0, ref flag).method_252(scenario_0, false, false, false);
					b = ((diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							4,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								4,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"Inherited, " + text3
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									4,
									"Inherited, " + text4
								});
							}
						}
					}
				}
				Doctrine._DiveOnContact? diveOnContact2 = this.method_252(scenario_0, false, false, false);
				b = ((diveOnContact2 != null) ? new byte?((byte)diveOnContact2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x001423C4 File Offset: 0x001405C4
		public Doctrine._RechargeBatteryPercentage? method_258(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._RechargeBatteryPercentage? result;
			try
			{
				if (this.method_260())
				{
					Doctrine doctrine;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.method_3(scenario_0, ref flag);
					}
					result = doctrine.method_258(scenario_0, bool_35, bool_36, bool_37);
				}
				else
				{
					result = new Doctrine._RechargeBatteryPercentage?(this.nullable_30.Value);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200455", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_10_Percent);
			}
			return result;
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00142464 File Offset: 0x00140664
		public void method_259(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._RechargeBatteryPercentage? nullable_42)
		{
			this.nullable_30 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0000A2DE File Offset: 0x000084DE
		public bool method_260()
		{
			return this.nullable_30 == null;
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0014249C File Offset: 0x0014069C
		public bool method_261(Scenario scenario_0)
		{
			bool result;
			try
			{
				if (this.class310_0.GetType() == typeof(Side))
				{
					result = this.bool_30;
				}
				else
				{
					bool flag = true;
					result = this.method_3(scenario_0, ref flag).method_261(scenario_0);
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0014250C File Offset: 0x0014070C
		public void method_262(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_30 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_262(scenario_0, bool_35);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0014254C File Offset: 0x0014074C
		public void method_263(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._RechargeBatteryPercentage? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "When empty";
			string text2 = "When 10% battery remains";
			string text3 = "20%";
			string text4 = "30%";
			string text5 = "40%";
			string text6 = "50%";
			string text7 = "60%";
			string text8 = "70%";
			string text9 = "80%";
			string text10 = "90%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				text6
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				text7
			});
			dataTable_0.Rows.Add(new object[]
			{
				7,
				text8
			});
			dataTable_0.Rows.Add(new object[]
			{
				8,
				text9
			});
			dataTable_0.Rows.Add(new object[]
			{
				9,
				text10
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				int? num;
				if (!Information.IsNothing(nullable_42))
				{
					num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							10,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 10) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								10,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 20) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									10,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 30) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										10,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 40) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											10,
											"Inherited, " + text5
										});
									}
									else
									{
										num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 50) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												10,
												"Inherited, " + text6
											});
										}
										else
										{
											num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 60) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													10,
													"Inherited, " + text7
												});
											}
											else
											{
												num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
												if (((num != null) ? new bool?(num.GetValueOrDefault() == 70) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														10,
														"Inherited, " + text8
													});
												}
												else
												{
													num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
													if (((num != null) ? new bool?(num.GetValueOrDefault() == 80) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															10,
															"Inherited, " + text9
														});
													}
													else
													{
														num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
														if (((num != null) ? new bool?(num.GetValueOrDefault() == 90) : null).GetValueOrDefault())
														{
															dataTable_0.Rows.Add(new object[]
															{
																10,
																"Inherited, " + text10
															});
														}
														else
														{
															dataTable_0.Rows.Add(new object[]
															{
																10,
																"Inherited, Various"
															});
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage = this.method_3(scenario_0, ref flag).method_258(scenario_0, false, false, false);
					num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							10,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 10) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								10,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 20) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									10,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 30) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										10,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 40) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											10,
											"Inherited, " + text5
										});
									}
									else
									{
										num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 50) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												10,
												"Inherited, " + text6
											});
										}
										else
										{
											num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 60) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													10,
													"Inherited, " + text7
												});
											}
											else
											{
												num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
												if (((num != null) ? new bool?(num.GetValueOrDefault() == 70) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														10,
														"Inherited, " + text8
													});
												}
												else
												{
													num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
													if (((num != null) ? new bool?(num.GetValueOrDefault() == 80) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															10,
															"Inherited, " + text9
														});
													}
													else
													{
														dataTable_0.Rows.Add(new object[]
														{
															10,
															"Inherited, " + text10
														});
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage2 = this.method_258(scenario_0, false, false, false);
				num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == -100) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						11,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						11,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00143258 File Offset: 0x00141458
		public Doctrine._RechargeBatteryPercentage? method_264(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._RechargeBatteryPercentage? result;
			try
			{
				if (this.method_266())
				{
					Doctrine doctrine;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.method_3(scenario_0, ref flag);
					}
					result = doctrine.method_264(scenario_0, bool_35, bool_36, bool_37);
				}
				else
				{
					result = new Doctrine._RechargeBatteryPercentage?(this.nullable_31.Value);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200456", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_10_Percent);
			}
			return result;
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x001432F8 File Offset: 0x001414F8
		public void method_265(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._RechargeBatteryPercentage? nullable_42)
		{
			this.nullable_31 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0000A2EE File Offset: 0x000084EE
		public bool method_266()
		{
			return this.nullable_31 == null;
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00143330 File Offset: 0x00141530
		public bool method_267(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_31;
			}
			else
			{
				bool flag = true;
				Doctrine doctrine = this.method_3(scenario_0, ref flag);
				try
				{
					result = doctrine.method_267(scenario_0);
				}
				catch (Exception ex)
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00143394 File Offset: 0x00141594
		public void method_268(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_31 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag);
			try
			{
				flag = true;
				this.method_3(scenario_0, ref flag).method_268(scenario_0, bool_35);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00143400 File Offset: 0x00141600
		public void method_269(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._RechargeBatteryPercentage? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "When empty";
			string text2 = "When 10% battery remains";
			string text3 = "20%";
			string text4 = "30%";
			string text5 = "40%";
			string text6 = "50%";
			string text7 = "60%";
			string text8 = "70%";
			string text9 = "80%";
			string text10 = "90%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				text6
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				text7
			});
			dataTable_0.Rows.Add(new object[]
			{
				7,
				text8
			});
			dataTable_0.Rows.Add(new object[]
			{
				8,
				text9
			});
			dataTable_0.Rows.Add(new object[]
			{
				9,
				text10
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				int? num;
				if (!Information.IsNothing(nullable_42))
				{
					num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							10,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 10) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								10,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 20) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									10,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 30) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										10,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 40) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											10,
											"Inherited, " + text5
										});
									}
									else
									{
										num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 50) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												10,
												"Inherited, " + text6
											});
										}
										else
										{
											num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 60) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													10,
													"Inherited, " + text7
												});
											}
											else
											{
												num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
												if (((num != null) ? new bool?(num.GetValueOrDefault() == 70) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														10,
														"Inherited, " + text8
													});
												}
												else
												{
													num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
													if (((num != null) ? new bool?(num.GetValueOrDefault() == 80) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															10,
															"Inherited, " + text9
														});
													}
													else
													{
														num = ((nullable_42 != null) ? new int?((int)nullable_42.GetValueOrDefault()) : null);
														if (((num != null) ? new bool?(num.GetValueOrDefault() == 90) : null).GetValueOrDefault())
														{
															dataTable_0.Rows.Add(new object[]
															{
																10,
																"Inherited, " + text10
															});
														}
														else
														{
															dataTable_0.Rows.Add(new object[]
															{
																10,
																"Inherited, Various"
															});
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage = this.method_3(scenario_0, ref flag).method_264(scenario_0, false, false, false);
					num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							10,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 10) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								10,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 20) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									10,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 30) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										10,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 40) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											10,
											"Inherited, " + text5
										});
									}
									else
									{
										num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 50) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												10,
												"Inherited, " + text6
											});
										}
										else
										{
											num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 60) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													10,
													"Inherited, " + text7
												});
											}
											else
											{
												num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
												if (((num != null) ? new bool?(num.GetValueOrDefault() == 70) : null).GetValueOrDefault())
												{
													dataTable_0.Rows.Add(new object[]
													{
														10,
														"Inherited, " + text8
													});
												}
												else
												{
													num = ((rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null);
													if (((num != null) ? new bool?(num.GetValueOrDefault() == 80) : null).GetValueOrDefault())
													{
														dataTable_0.Rows.Add(new object[]
														{
															10,
															"Inherited, " + text9
														});
													}
													else
													{
														dataTable_0.Rows.Add(new object[]
														{
															10,
															"Inherited, " + text10
														});
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage2 = this.method_264(scenario_0, false, false, false);
				num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == -100) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						11,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						11,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0014410C File Offset: 0x0014230C
		public Doctrine._UseAIP? method_270(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._UseAIP? result;
			try
			{
				if (this.method_272())
				{
					Doctrine doctrine;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.method_3(scenario_0, ref flag);
					}
					result = doctrine.method_270(scenario_0, bool_35, bool_36, bool_37);
				}
				else
				{
					result = new Doctrine._UseAIP?(this.nullable_32.Value);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200457", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._UseAIP?(Doctrine._UseAIP.No);
			}
			return result;
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x001441A8 File Offset: 0x001423A8
		public void method_271(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._UseAIP? nullable_42)
		{
			this.nullable_32 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0000A2FE File Offset: 0x000084FE
		public bool method_272()
		{
			return this.nullable_32 == null;
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x001441E0 File Offset: 0x001423E0
		public bool method_273(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_32;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_273(scenario_0);
			}
			return result;
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00144220 File Offset: 0x00142420
		public void method_274(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_32 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_274(scenario_0, bool_35);
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00144260 File Offset: 0x00142460
		private void method_275(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._UseAIP? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "No";
			string text2 = "Yes, when engaged offensive or engaged defensive";
			string text3 = "Yes, always";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text3
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, " + text
								});
							}
							else
							{
								dataTable_0.Rows.Add(new object[]
								{
									3,
									"Inherited, Various"
								});
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._UseAIP? useAIP = this.method_3(scenario_0, ref flag).method_270(scenario_0, false, false, false);
					b = ((useAIP != null) ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							3,
							"Inherited, " + text3
						});
					}
					else
					{
						b = ((useAIP != null) ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								3,
								"Inherited, " + text
							});
						}
					}
				}
				Doctrine._UseAIP? useAIP2 = this.method_270(scenario_0, false, false, false);
				b = ((useAIP2 != null) ? new byte?((byte)useAIP2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						4,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0014470C File Offset: 0x0014290C
		public Doctrine._UseDippingSonar? method_276(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37)
		{
			Doctrine._UseDippingSonar? result;
			try
			{
				if (this.method_278())
				{
					Doctrine doctrine;
					while (Information.IsNothing(doctrine))
					{
						bool flag = true;
						doctrine = this.method_3(scenario_0, ref flag);
					}
					result = doctrine.method_276(scenario_0, bool_35, bool_36, bool_37);
				}
				else
				{
					result = new Doctrine._UseDippingSonar?(this.nullable_33.Value);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200458", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Automatically_HoverAnd150ft);
			}
			return result;
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x001447A8 File Offset: 0x001429A8
		public void method_277(Scenario scenario_0, bool bool_35, bool bool_36, bool bool_37, Doctrine._UseDippingSonar? nullable_42)
		{
			this.nullable_33 = nullable_42;
			Doctrine.Delegate28 @delegate = Doctrine.delegate28_0;
			if (@delegate != null)
			{
				@delegate(this.class310_0, new bool?(false), bool_35, bool_36, bool_37, false);
			}
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x0000A30E File Offset: 0x0000850E
		public bool method_278()
		{
			return this.nullable_33 == null;
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x001447E0 File Offset: 0x001429E0
		public bool method_279(Scenario scenario_0)
		{
			bool result;
			if (this.class310_0.GetType() == typeof(Side))
			{
				result = this.bool_33;
			}
			else
			{
				bool flag = true;
				result = this.method_3(scenario_0, ref flag).method_279(scenario_0);
			}
			return result;
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00144820 File Offset: 0x00142A20
		public void method_280(Scenario scenario_0, bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				this.bool_33 = bool_35;
				return;
			}
			bool flag = true;
			this.method_3(scenario_0, ref flag).method_280(scenario_0, bool_35);
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00144860 File Offset: 0x00142A60
		public void method_281(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._UseDippingSonar? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Automatically deploy in hover and less than 150ft altitude";
			string text2 = "Only deploy manually or when assigned to mission";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				byte? b;
				if (!Information.IsNothing(nullable_42))
				{
					b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						b = ((nullable_42 != null) ? new byte?((byte)nullable_42.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, " + text2
							});
						}
						else
						{
							dataTable_0.Rows.Add(new object[]
							{
								2,
								"Inherited, Various"
							});
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._UseDippingSonar? useDippingSonar = this.method_3(scenario_0, ref flag).method_276(scenario_0, false, false, false);
					b = ((useDippingSonar != null) ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text
						});
					}
					else
					{
						dataTable_0.Rows.Add(new object[]
						{
							2,
							"Inherited, " + text2
						});
					}
				}
				Doctrine._UseDippingSonar? useDippingSonar2 = this.method_276(scenario_0, false, false, false);
				b = ((useDippingSonar2 != null) ? new byte?((byte)useDippingSonar2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						3,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00144BE0 File Offset: 0x00142DE0
		public void method_282(ref XmlWriter theWriter, ref Scenario theScen, string theDoctrineName = "Doctrine")
		{
			try
			{
				theWriter.WriteStartElement(theDoctrineName);
				if (this.nullable_6 != null)
				{
					theWriter.WriteElementString("Nukes", ((byte)this.method_31(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_6)
				{
					theWriter.WriteElementString("Nukes_Player", this.bool_6.ToString());
				}
				if (this.nullable_0 != null)
				{
					theWriter.WriteElementString("WCS_Air", ((byte)this.method_63(theScen, false, null, false, false).Value).ToString());
				}
				if (this.bool_0)
				{
					theWriter.WriteElementString("WCS_Air_Player", this.bool_0.ToString());
				}
				if (this.nullable_1 != null)
				{
					theWriter.WriteElementString("WCS_Surface", ((byte)this.method_68(theScen, false, null, false, false).Value).ToString());
				}
				if (this.bool_1)
				{
					theWriter.WriteElementString("WCS_Surface_Player", this.bool_1.ToString());
				}
				if (this.nullable_2 != null)
				{
					theWriter.WriteElementString("WCS_Submarine", ((byte)this.method_73(theScen, false, null, false, false).Value).ToString());
				}
				if (this.bool_2)
				{
					theWriter.WriteElementString("WCS_Submarine_Player", this.bool_2.ToString());
				}
				if (this.nullable_3 != null)
				{
					theWriter.WriteElementString("WCS_Land", ((byte)this.method_78(theScen, false, null, false, false).Value).ToString());
				}
				if (this.bool_3)
				{
					theWriter.WriteElementString("WCS_Player_Land", this.bool_3.ToString());
				}
				if (this.nullable_5 != null)
				{
					theWriter.WriteElementString("IPCWA", ((byte)this.method_83(theScen, false, null, false, false).Value).ToString());
				}
				if (this.bool_5)
				{
					theWriter.WriteElementString("IPCWA_Player", this.bool_5.ToString());
				}
				if (this.nullable_7 != null)
				{
					theWriter.WriteElementString("WinchesterShotgunRTB", ((byte)this.method_117(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_7)
				{
					theWriter.WriteElementString("WinchesterShotgunRTB_Player", this.bool_7.ToString());
				}
				if (this.nullable_8 != null)
				{
					theWriter.WriteElementString("BingoJokerRTB", ((byte)this.method_122(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_8)
				{
					theWriter.WriteElementString("BingoJokerRTB_Player", this.bool_8.ToString());
				}
				if (this.nullable_9 != null)
				{
					theWriter.WriteElementString("JettisonOrdnance", ((byte)this.method_127(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_9)
				{
					theWriter.WriteElementString("JettisonOrdnance_Player", this.bool_9.ToString());
				}
				if (this.nullable_10 != null)
				{
					theWriter.WriteElementString("BVRLogic", ((byte)this.method_132(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_10)
				{
					theWriter.WriteElementString("BVRLogic_Player", this.bool_10.ToString());
				}
				if (this.nullable_11 != null)
				{
					theWriter.WriteElementString("BTAT", ((byte)this.method_88(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_11)
				{
					theWriter.WriteElementString("BTAT_Player", this.bool_11.ToString());
				}
				if (this.nullable_12 != null)
				{
					theWriter.WriteElementString("AE", ((byte)this.method_137(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_12)
				{
					theWriter.WriteElementString("AE_Player", this.bool_12.ToString());
				}
				if (this.nullable_13 != null)
				{
					theWriter.WriteElementString("MS", ((byte)this.method_142(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_13)
				{
					theWriter.WriteElementString("MS_Player", this.bool_13.ToString());
				}
				if (this.nullable_4 != null)
				{
					theWriter.WriteElementString("GS", ((byte)this.method_147(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_4)
				{
					theWriter.WriteElementString("GS_Player", this.bool_4.ToString());
				}
				if (this.nullable_17 != null)
				{
					theWriter.WriteElementString("UR", ((byte)this.method_152(theScen, false, false, false, false).Value).ToString());
				}
				if (this.bool_17)
				{
					theWriter.WriteElementString("UR_Player", this.bool_17.ToString());
				}
				if (this.nullable_18 != null)
				{
					theWriter.WriteElementString("RS", ((byte)this.method_157(theScen, false, false, false, false).Value).ToString());
				}
				if (this.bool_18)
				{
					theWriter.WriteElementString("RS_Player", this.bool_18.ToString());
				}
				if (this.nullable_19 != null)
				{
					theWriter.WriteElementString("ST", ((byte)this.method_162(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_19)
				{
					theWriter.WriteElementString("ST_Player", this.bool_19.ToString());
				}
				if (this.nullable_20 != null)
				{
					theWriter.WriteElementString("SAM_ASUW", ((byte)this.method_167(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_20)
				{
					theWriter.WriteElementString("SAM_ASUW_Player", this.bool_20.ToString());
				}
				if (!Information.IsNothing(this.class275_0))
				{
					theWriter.WriteElementString("E_Radar", ((byte)this.class275_0.method_1()).ToString());
					theWriter.WriteElementString("E_Sonar", ((byte)this.class275_0.method_2()).ToString());
					theWriter.WriteElementString("E_OECM", ((byte)this.class275_0.method_3()).ToString());
				}
				if (this.nullable_22 != null)
				{
					theWriter.WriteElementString("QuickTurnAround", ((byte)this.method_196(theScen, false, true, false, false).Value).ToString());
				}
				if (this.bool_22)
				{
					theWriter.WriteElementString("QTA_Player", this.bool_22.ToString());
				}
				if (this.nullable_23 != null)
				{
					theWriter.WriteElementString("AirOpsTempo", ((byte)this.method_201(theScen, false, true, false, false).Value).ToString());
				}
				if (this.bool_23)
				{
					theWriter.WriteElementString("AirOpsTempo_Player", this.bool_23.ToString());
				}
				if (this.nullable_24 != null)
				{
					theWriter.WriteElementString("BingoJoker", ((byte)this.method_206(theScen, false, true, false, false).Value).ToString());
				}
				if (this.bool_24)
				{
					theWriter.WriteElementString("BingoJoker_Player", this.bool_24.ToString());
				}
				if (this.nullable_25 != null)
				{
					theWriter.WriteElementString("WinchesterShotgun", ((int)this.method_211(theScen, false, true, false, false).Value).ToString());
				}
				if (this.bool_25)
				{
					theWriter.WriteElementString("WinchesterShotgun_Player", this.bool_25.ToString());
				}
				if (this.nullable_34 != null)
				{
					theWriter.WriteElementString("WithdrawDamageThreshold", ((int)this.method_93(theScen, false, false, false).Value).ToString());
				}
				if (this.nullable_35 != null)
				{
					theWriter.WriteElementString("WithdrawFuelThreshold", ((int)this.method_96(theScen, false, false, false).Value).ToString());
				}
				if (this.nullable_36 != null)
				{
					theWriter.WriteElementString("WithdrawAttackThreshold", ((int)this.method_99(theScen, false, false, false).Value).ToString());
				}
				if (this.nullable_37 != null)
				{
					theWriter.WriteElementString("WithdrawDefenceThreshold", ((int)this.method_102(theScen, false, false, false).Value).ToString());
				}
				if (this.nullable_38 != null)
				{
					theWriter.WriteElementString("RedeployDamageThreshold", ((int)this.method_105(theScen, false, false, false).Value).ToString());
				}
				if (this.nullable_39 != null)
				{
					theWriter.WriteElementString("RedeployFuelThreshold", ((int)this.method_108(theScen, false, false, false).Value).ToString());
				}
				if (this.nullable_40 != null)
				{
					theWriter.WriteElementString("RedeployAttackThreshold", ((int)this.method_111(theScen, false, false, false).Value).ToString());
				}
				if (this.nullable_41 != null)
				{
					theWriter.WriteElementString("RedeployDefenceThreshold", ((int)this.method_114(theScen, false, false, false).Value).ToString());
				}
				if (this.nullable_21 != null)
				{
					theWriter.WriteElementString("IgnoreEMCONUnderAttack", ((byte)this.method_172(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_21)
				{
					theWriter.WriteElementString("IgnoreEMCONUnderAttack_Player", this.bool_21.ToString());
				}
				if (this.nullable_26 != null)
				{
					theWriter.WriteElementString("UseTorpedoesKinematicRange", ((byte)this.method_216(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_26)
				{
					theWriter.WriteElementString("UseTorpedoesKinematicRange_Player", this.bool_26.ToString());
				}
				if (this.nullable_27 != null)
				{
					theWriter.WriteElementString("RefuelAllies", ((byte)this.method_240(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_27)
				{
					theWriter.WriteElementString("RefuelAllies_Player", this.bool_27.ToString());
				}
				if (this.nullable_28 != null)
				{
					theWriter.WriteElementString("AvoidContact", ((byte)this.method_246(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_28)
				{
					theWriter.WriteElementString("AvoidContact_Player", this.bool_28.ToString());
				}
				if (this.nullable_29 != null)
				{
					theWriter.WriteElementString("DiveWhenThreatsDetected", ((byte)this.method_252(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_29)
				{
					theWriter.WriteElementString("DiveWhenThreatsDetected_Player", this.bool_29.ToString());
				}
				if (this.nullable_30 != null)
				{
					theWriter.WriteElementString("RechargePercentagePatrol", ((int)this.method_258(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_30)
				{
					theWriter.WriteElementString("RechargePercentagePatrol_Player", this.bool_30.ToString());
				}
				if (this.nullable_31 != null)
				{
					theWriter.WriteElementString("RechargePercentageAttack", ((int)this.method_264(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_31)
				{
					theWriter.WriteElementString("RechargePercentageAttack_Player", this.bool_31.ToString());
				}
				if (this.nullable_32 != null)
				{
					theWriter.WriteElementString("AIPUsage", ((byte)this.method_270(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_32)
				{
					theWriter.WriteElementString("AIPUsage_Player", this.bool_32.ToString());
				}
				if (this.nullable_33 != null)
				{
					theWriter.WriteElementString("DippingSonar", ((byte)this.method_276(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_33)
				{
					theWriter.WriteElementString("DippingSonar_Player", this.bool_33.ToString());
				}
				if (this.nullable_14 != null)
				{
					theWriter.WriteElementString("SurfNav", ((byte)this.method_177(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_14)
				{
					theWriter.WriteElementString("SurfNav_Player", this.bool_14.ToString());
				}
				if (this.nullable_15 != null)
				{
					theWriter.WriteElementString("SubNav", ((byte)this.method_182(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_15)
				{
					theWriter.WriteElementString("SubNav_Player", this.bool_15.ToString());
				}
				if (this.nullable_16 != null)
				{
					theWriter.WriteElementString("LandNav", ((byte)this.method_187(theScen, false, false, false).Value).ToString());
				}
				if (this.bool_16)
				{
					theWriter.WriteElementString("LandNav_Player", this.bool_16.ToString());
				}
				if (!Information.IsNothing(this.method_27()))
				{
					theWriter.WriteStartElement("WRA");
					try
					{
						foreach (KeyValuePair<int, Doctrine.WRA_Weapon> keyValuePair in this.method_27())
						{
							theWriter.WriteStartElement("Weapon_" + Conversions.ToString(Conversions.ToInteger(keyValuePair.Key.ToString())));
							foreach (Doctrine.Class276 @class in keyValuePair.Value.class276_0)
							{
								XmlWriter xmlWriter = theWriter;
								string str = "WeaponTarget_";
								int wra_WeaponTargetType_ = (int)@class._WRA_WeaponTargetType_0;
								xmlWriter.WriteStartElement(str + wra_WeaponTargetType_.ToString());
								if (this.class310_0.GetType() == typeof(Side))
								{
									bool? flag;
									bool? flag2;
									if (Information.IsNothing(@class.nullable_0))
									{
										flag = new bool?(false);
									}
									else
									{
										int? num = @class.nullable_0;
										flag2 = ((num != null) ? new bool?(num.GetValueOrDefault() == -1) : null);
										flag = ((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2);
									}
									flag2 = flag;
									if (flag2.GetValueOrDefault())
									{
										theWriter.WriteElementString("WeaponQty", @class.nullable_0.Value.ToString());
									}
									bool? flag3;
									if (Information.IsNothing(@class.nullable_1))
									{
										flag3 = new bool?(false);
									}
									else
									{
										int? num = @class.nullable_1;
										flag2 = ((num != null) ? new bool?(num.GetValueOrDefault() == -1) : null);
										flag3 = ((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2);
									}
									flag2 = flag3;
									if (flag2.GetValueOrDefault())
									{
										theWriter.WriteElementString("ShooterQty", @class.nullable_1.Value.ToString());
									}
									bool? flag4;
									if (Information.IsNothing(@class.nullable_3))
									{
										flag4 = new bool?(false);
									}
									else
									{
										int? num = @class.nullable_3;
										flag2 = ((num != null) ? new bool?(num.GetValueOrDefault() == -1) : null);
										flag4 = ((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2);
									}
									flag2 = flag4;
									if (flag2.GetValueOrDefault())
									{
										theWriter.WriteElementString("SelfDefenceRange", @class.nullable_3.Value.ToString());
									}
									if (!Information.IsNothing(@class.nullable_2))
									{
										theWriter.WriteElementString("FiringRange", @class.nullable_2.Value.ToString());
									}
								}
								else
								{
									if (!Information.IsNothing(@class.nullable_0))
									{
										theWriter.WriteElementString("WeaponQty", @class.nullable_0.Value.ToString());
									}
									if (!Information.IsNothing(@class.nullable_1))
									{
										theWriter.WriteElementString("ShooterQty", @class.nullable_1.Value.ToString());
									}
									if (!Information.IsNothing(@class.nullable_3))
									{
										theWriter.WriteElementString("SelfDefenceRange", @class.nullable_3.Value.ToString());
									}
									if (!Information.IsNothing(@class.nullable_2))
									{
										theWriter.WriteElementString("FiringRange", @class.nullable_2.Value.ToString());
									}
								}
								theWriter.WriteEndElement();
							}
							theWriter.WriteEndElement();
						}
					}
					finally
					{
						Dictionary<int, Doctrine.WRA_Weapon>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					theWriter.WriteEndElement();
				}
				theWriter.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101003", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00145D94 File Offset: 0x00143F94
		public static Doctrine smethod_9(ref XmlNode xmlNode_0, Class310 class310_1)
		{
			Doctrine result;
			try
			{
				List<ActiveUnit> list = null;
				Doctrine doctrine = new Doctrine(class310_1, ref list);
				if (class310_1.GetType() == typeof(Side))
				{
					doctrine.bool_6 = false;
					doctrine.bool_0 = false;
					doctrine.bool_1 = false;
					doctrine.bool_2 = false;
					doctrine.bool_3 = false;
					doctrine.bool_4 = false;
					doctrine.bool_5 = false;
					doctrine.bool_11 = false;
					doctrine.bool_12 = false;
					doctrine.bool_13 = false;
					doctrine.bool_17 = false;
					doctrine.bool_18 = false;
					doctrine.bool_19 = false;
					doctrine.bool_20 = false;
					doctrine.bool_21 = false;
					doctrine.bool_22 = false;
					doctrine.bool_23 = false;
					doctrine.bool_25 = false;
					doctrine.bool_7 = false;
					doctrine.bool_24 = false;
					doctrine.bool_8 = false;
					doctrine.bool_9 = false;
					doctrine.bool_10 = false;
					doctrine.bool_26 = false;
					doctrine.bool_27 = false;
					doctrine.bool_28 = false;
					doctrine.bool_29 = false;
					doctrine.bool_30 = false;
					doctrine.bool_31 = false;
					doctrine.bool_32 = false;
					doctrine.bool_33 = false;
				}
				Doctrine.Class275.Enum66? @enum;
				Doctrine.Class275.Enum66? enum2;
				Doctrine.Class275.Enum66? enum3;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 2048548214U)
						{
							if (num <= 926850787U)
							{
								if (num <= 573162790U)
								{
									if (num <= 367419441U)
									{
										if (num <= 168888245U)
										{
											if (num != 96685014U)
											{
												if (num != 168888245U)
												{
													continue;
												}
												if (Operators.CompareString(name, "IgnoreEMCONUnderAttack_Player", false) == 0)
												{
													doctrine.bool_21 = Conversions.ToBoolean(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "RS_Player", false) == 0)
												{
													doctrine.bool_18 = Conversions.ToBoolean(xmlNode.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (num != 328518098U)
										{
											if (num != 333190174U)
											{
												if (num != 367419441U)
												{
													continue;
												}
												if (Operators.CompareString(name, "WCS_Submarine_Player", false) == 0)
												{
													doctrine.bool_2 = Conversions.ToBoolean(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "QuickTurnAround", false) == 0)
												{
													doctrine.method_197(null, false, true, true, true, new Doctrine.Enum53?((Doctrine.Enum53)Conversions.ToByte(xmlNode.InnerText)));
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "AvoidContact_Player", false) == 0)
											{
												doctrine.bool_28 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num <= 527662466U)
									{
										if (num != 403125585U)
										{
											if (num != 418596570U)
											{
												if (num != 527662466U)
												{
													continue;
												}
												if (Operators.CompareString(name, "SubNav", false) == 0)
												{
													doctrine.method_183(null, false, true, true, new Doctrine.Enum63?((Doctrine.Enum63)Conversions.ToByte(xmlNode.InnerText)));
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "EMCON_OECM", false) != 0)
												{
													continue;
												}
												goto IL_166A;
											}
										}
										else
										{
											if (Operators.CompareString(name, "RTBWW", false) != 0)
											{
												continue;
											}
											goto IL_1B37;
										}
									}
									else if (num != 539702834U)
									{
										if (num != 557852687U)
										{
											if (num != 573162790U)
											{
												continue;
											}
											if (Operators.CompareString(name, "SubNav_Player", false) == 0)
											{
												doctrine.bool_15 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "NukesAllowed", false) != 0)
											{
												continue;
											}
											goto IL_19FB;
										}
									}
									else
									{
										if (Operators.CompareString(name, "RedeployFuelThreshold", false) == 0)
										{
											doctrine.method_109(null, false, true, true, new Doctrine._FuelQuantityThreshold?((Doctrine._FuelQuantityThreshold)Conversions.ToShort(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else if (num <= 836709739U)
								{
									if (num <= 691945251U)
									{
										if (num != 592509872U)
										{
											if (num != 668277163U)
											{
												if (num != 691945251U)
												{
													continue;
												}
												if (Operators.CompareString(name, "MS_Player", false) == 0)
												{
													doctrine.bool_13 = Conversions.ToBoolean(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "AE", false) != 0)
												{
													continue;
												}
												if (!Versioned.IsNumeric(xmlNode.InnerText))
												{
													if (Conversions.ToBoolean(xmlNode.InnerText))
													{
														doctrine.method_138(null, false, true, true, new Doctrine.Enum61?(Doctrine.Enum61.const_1));
														continue;
													}
													doctrine.method_138(null, false, true, true, new Doctrine.Enum61?(Doctrine.Enum61.const_0));
													continue;
												}
												else
												{
													if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
													{
														doctrine.method_138(null, false, true, true, new Doctrine.Enum61?(Doctrine.Enum61.const_1));
														continue;
													}
													doctrine.method_138(null, false, true, true, new Doctrine.Enum61?((Doctrine.Enum61)Conversions.ToByte(xmlNode.InnerText)));
													continue;
												}
											}
										}
										else
										{
											if (Operators.CompareString(name, "WCS_Surface_Player", false) == 0)
											{
												doctrine.bool_1 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num != 765306101U)
									{
										if (num != 804597985U)
										{
											if (num != 836709739U)
											{
												continue;
											}
											if (Operators.CompareString(name, "LandNav_Player", false) == 0)
											{
												doctrine.bool_16 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "JettisonOrdnance", false) == 0)
											{
												doctrine.method_128(null, false, true, true, new Doctrine._JettisonOrdnance?((Doctrine._JettisonOrdnance)Conversions.ToByte(xmlNode.InnerText)));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "BingoJokerRTB", false) == 0)
										{
											doctrine.method_123(null, false, true, true, new Doctrine._FuelStateRTB?((Doctrine._FuelStateRTB)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else if (num <= 903688902U)
								{
									if (num != 879821284U)
									{
										if (num != 886153571U)
										{
											if (num != 903688902U)
											{
												continue;
											}
											if (Operators.CompareString(name, "EMCON_Radar", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "RTBWW_Player", false) != 0)
											{
												continue;
											}
											goto IL_1852;
										}
									}
									else
									{
										if (Operators.CompareString(name, "AirOpsTempo_Player", false) == 0)
										{
											doctrine.bool_23 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 903855377U)
								{
									if (num != 917115394U)
									{
										if (num != 926850787U)
										{
											continue;
										}
										if (Operators.CompareString(name, "RTBWhenWinchester", false) != 0)
										{
											continue;
										}
										goto IL_1B37;
									}
									else
									{
										if (Operators.CompareString(name, "SurfNav_Player", false) == 0)
										{
											doctrine.bool_14 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "MS", false) != 0)
									{
										continue;
									}
									if (!Versioned.IsNumeric(xmlNode.InnerText))
									{
										if (Conversions.ToBoolean(xmlNode.InnerText))
										{
											doctrine.method_143(null, false, true, true, new Doctrine.Enum62?(Doctrine.Enum62.const_1));
											continue;
										}
										doctrine.method_143(null, false, true, true, new Doctrine.Enum62?(Doctrine.Enum62.const_0));
										continue;
									}
									else
									{
										if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
										{
											doctrine.method_143(null, false, true, true, new Doctrine.Enum62?(Doctrine.Enum62.const_1));
											continue;
										}
										doctrine.method_143(null, false, true, true, new Doctrine.Enum62?((Doctrine.Enum62)Conversions.ToByte(xmlNode.InnerText)));
										continue;
									}
								}
							}
							else if (num <= 1650673117U)
							{
								if (num <= 1301901233U)
								{
									if (num <= 1222598759U)
									{
										if (num != 1121381144U)
										{
											if (num != 1222598759U)
											{
												continue;
											}
											if (Operators.CompareString(name, "BingoJokerRTB_Player", false) == 0)
											{
												doctrine.bool_8 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "RechargePercentageAttack", false) == 0)
											{
												doctrine.method_265(null, false, true, true, new Doctrine._RechargeBatteryPercentage?((Doctrine._RechargeBatteryPercentage)Conversions.ToInteger(xmlNode.InnerText)));
												continue;
											}
											continue;
										}
									}
									else if (num != 1279327281U)
									{
										if (num != 1282069123U)
										{
											if (num != 1301901233U)
											{
												continue;
											}
											if (Operators.CompareString(name, "SAM_ASUW", false) != 0)
											{
												continue;
											}
											if (!Versioned.IsNumeric(xmlNode.InnerText))
											{
												doctrine.method_168(null, false, true, true, new Doctrine.Enum58?((-((Conversions.ToBoolean(xmlNode.InnerText) > false) ? Doctrine.Enum58.const_1 : Doctrine.Enum58.const_0)) ? Doctrine.Enum58.const_1 : Doctrine.Enum58.const_0));
												continue;
											}
											if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
											{
												doctrine.method_168(null, false, true, true, new Doctrine.Enum58?(Doctrine.Enum58.const_0));
												continue;
											}
											doctrine.method_168(null, false, true, true, new Doctrine.Enum58?((Doctrine.Enum58)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "UseTorpedoesKinematicRange_Player", false) == 0)
											{
												doctrine.bool_26 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "WCS_Air_Player", false) == 0)
										{
											doctrine.bool_0 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num <= 1459330367U)
								{
									if (num != 1444970949U)
									{
										if (num != 1458546423U)
										{
											if (num != 1459330367U)
											{
												continue;
											}
											if (Operators.CompareString(name, "IgnoreEMCONUnderAttack", false) == 0)
											{
												doctrine.method_173(null, false, true, true, new Doctrine.Enum60?((Doctrine.Enum60)Conversions.ToByte(xmlNode.InnerText)));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "WRA", false) != 0)
											{
												continue;
											}
											doctrine.dictionary_0 = new Dictionary<int, Doctrine.WRA_Weapon>();
											try
											{
												foreach (object obj2 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode2 = (XmlNode)obj2;
													int key = Conversions.ToInteger(xmlNode2.Name.Split(new char[]
													{
														'_'
													})[1]);
													Doctrine.WRA_Weapon wra_Weapon = new Doctrine.WRA_Weapon();
													doctrine.dictionary_0.Add(key, wra_Weapon);
													try
													{
														foreach (object obj3 in xmlNode2.ChildNodes)
														{
															XmlNode xmlNode3 = (XmlNode)obj3;
															Doctrine._WRA_WeaponTargetType wra_WeaponTargetType_ = (Doctrine._WRA_WeaponTargetType)Conversions.ToInteger(xmlNode3.Name.Split(new char[]
															{
																'_'
															})[1]);
															Doctrine.Class276 @class = new Doctrine.Class276(wra_WeaponTargetType_);
															try
															{
																foreach (object obj4 in xmlNode3.ChildNodes)
																{
																	XmlNode xmlNode4 = (XmlNode)obj4;
																	string name2 = xmlNode4.Name;
																	if (Operators.CompareString(name2, "WeaponQty", false) != 0)
																	{
																		if (Operators.CompareString(name2, "ShooterQty", false) != 0)
																		{
																			if (Operators.CompareString(name2, "SelfDefenceRange", false) != 0)
																			{
																				if (Operators.CompareString(name2, "FiringRange", false) == 0)
																				{
																					@class.nullable_2 = new int?(Conversions.ToInteger(xmlNode4.InnerText));
																				}
																			}
																			else
																			{
																				@class.nullable_3 = new int?(Conversions.ToInteger(xmlNode4.InnerText));
																			}
																		}
																		else
																		{
																			@class.nullable_1 = new int?(Conversions.ToInteger(xmlNode4.InnerText));
																		}
																	}
																	else
																	{
																		@class.nullable_0 = new int?(Conversions.ToInteger(xmlNode4.InnerText));
																	}
																}
															}
															finally
															{
																IEnumerator enumerator4;
																if (enumerator4 is IDisposable)
																{
																	(enumerator4 as IDisposable).Dispose();
																}
															}
															Class429.smethod_46(ref wra_Weapon.class276_0, @class);
														}
													}
													finally
													{
														IEnumerator enumerator3;
														if (enumerator3 is IDisposable)
														{
															(enumerator3 as IDisposable).Dispose();
														}
													}
												}
												continue;
											}
											finally
											{
												IEnumerator enumerator2;
												if (enumerator2 is IDisposable)
												{
													(enumerator2 as IDisposable).Dispose();
												}
											}
										}
									}
									if (Operators.CompareString(name, "GS_Player", false) == 0)
									{
										doctrine.bool_4 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else if (num != 1549193998U)
								{
									if (num != 1565608346U)
									{
										if (num != 1650673117U)
										{
											continue;
										}
										if (Operators.CompareString(name, "DippingSonar", false) == 0)
										{
											doctrine.method_277(null, false, true, true, new Doctrine._UseDippingSonar?((Doctrine._UseDippingSonar)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "BTAT_Player", false) == 0)
										{
											doctrine.bool_11 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "DiveWhenThreatsDetected", false) == 0)
									{
										doctrine.method_253(null, false, true, true, new Doctrine._DiveOnContact?((Doctrine._DiveOnContact)Conversions.ToByte(xmlNode.InnerText)));
										continue;
									}
									continue;
								}
							}
							else if (num <= 1836827262U)
							{
								if (num <= 1749912049U)
								{
									if (num != 1690126063U)
									{
										if (num != 1693683398U)
										{
											if (num != 1749912049U)
											{
												continue;
											}
											if (Operators.CompareString(name, "EMCON_Sonar", false) != 0)
											{
												continue;
											}
											goto IL_11FF;
										}
										else
										{
											if (Operators.CompareString(name, "UR", false) != 0)
											{
												continue;
											}
											if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
											{
												doctrine.method_153(null, false, true, true, false, new Doctrine.Enum56?(Doctrine.Enum56.const_0));
												continue;
											}
											doctrine.method_153(null, false, true, true, false, new Doctrine.Enum56?((Doctrine.Enum56)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "IPCWA_Player", false) == 0)
										{
											doctrine.bool_5 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 1795334850U)
								{
									if (num != 1821569801U)
									{
										if (num != 1836827262U)
										{
											continue;
										}
										if (Operators.CompareString(name, "SurfNav", false) == 0)
										{
											doctrine.method_178(null, false, true, true, new Doctrine.Enum63?((Doctrine.Enum63)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "BingoJoker_Player", false) == 0)
										{
											doctrine.bool_24 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "ST", false) != 0)
									{
										continue;
									}
									if (!Versioned.IsNumeric(xmlNode.InnerText))
									{
										if (doctrine.class310_0.GetType() == typeof(Side))
										{
											doctrine.method_163(null, false, true, true, new Doctrine.Enum59?(Doctrine.Enum59.const_0));
											continue;
										}
										doctrine.method_163(null, false, true, true, new Doctrine.Enum59?((-((Conversions.ToBoolean(xmlNode.InnerText) > false) ? Doctrine.Enum59.const_1 : Doctrine.Enum59.const_0)) ? Doctrine.Enum59.const_1 : Doctrine.Enum59.const_0));
										continue;
									}
									else
									{
										if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
										{
											doctrine.method_163(null, false, true, true, new Doctrine.Enum59?(Doctrine.Enum59.const_0));
											continue;
										}
										doctrine.method_163(null, false, true, true, new Doctrine.Enum59?((Doctrine.Enum59)Conversions.ToByte(xmlNode.InnerText)));
										continue;
									}
								}
							}
							else if (num <= 1903492872U)
							{
								if (num != 1842416303U)
								{
									if (num != 1845814802U)
									{
										if (num != 1903492872U)
										{
											continue;
										}
										if (Operators.CompareString(name, "SFirst", false) != 0)
										{
											continue;
										}
										goto IL_1380;
									}
									else
									{
										if (Operators.CompareString(name, "RS", false) == 0)
										{
											doctrine.method_158(null, false, true, true, false, new Doctrine.Enum57?((Doctrine.Enum57)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "GS", false) == 0)
									{
										doctrine.method_148(null, false, true, true, new Doctrine._GunStrafeGroundTargets?((Doctrine._GunStrafeGroundTargets)Conversions.ToByte(xmlNode.InnerText)));
										continue;
									}
									continue;
								}
							}
							else if (num != 1927987729U)
							{
								if (num != 2039869005U)
								{
									if (num != 2048548214U)
									{
										continue;
									}
									if (Operators.CompareString(name, "RefuelAllies_Player", false) == 0)
									{
										doctrine.bool_27 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "RedeployDamageThreshold", false) == 0)
									{
										doctrine.method_106(null, false, true, true, new Doctrine._DamageThreshold?((Doctrine._DamageThreshold)Conversions.ToShort(xmlNode.InnerText)));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "AE_Player", false) == 0)
								{
									doctrine.bool_12 = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else
						{
							if (num <= 3019355958U)
							{
								if (num <= 2530879819U)
								{
									if (num <= 2316341410U)
									{
										if (num <= 2152316275U)
										{
											if (num != 2148434813U)
											{
												if (num != 2152316275U)
												{
													continue;
												}
												if (Operators.CompareString(name, "E_Radar", false) == 0)
												{
													goto IL_F78;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "IPCWA", false) != 0)
												{
													continue;
												}
												if (!Versioned.IsNumeric(xmlNode.InnerText))
												{
													if (Conversions.ToBoolean(xmlNode.InnerText))
													{
														doctrine.method_84(null, false, null, true, true, new Doctrine.Enum64?(Doctrine.Enum64.const_1));
														continue;
													}
													doctrine.method_84(null, false, null, true, true, new Doctrine.Enum64?(Doctrine.Enum64.const_0));
													continue;
												}
												else
												{
													if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
													{
														doctrine.method_84(null, false, null, true, true, new Doctrine.Enum64?(Doctrine.Enum64.const_1));
														continue;
													}
													doctrine.method_84(null, false, null, true, true, new Doctrine.Enum64?((Doctrine.Enum64)Conversions.ToByte(xmlNode.InnerText)));
													continue;
												}
											}
										}
										else if (num != 2175700664U)
										{
											if (num != 2206632227U)
											{
												if (num != 2316341410U)
												{
													continue;
												}
												if (Operators.CompareString(name, "QuickTurnAround_Player", false) != 0)
												{
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name, "BingoJoker", false) == 0)
												{
													doctrine.method_207(null, false, true, true, true, new Doctrine._FuelState?((Doctrine._FuelState)Conversions.ToByte(xmlNode.InnerText)));
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "WithdrawDefenceThreshold", false) == 0)
											{
												doctrine.method_103(null, false, true, true, new Doctrine._WeaponQuantityThreshold?((Doctrine._WeaponQuantityThreshold)Conversions.ToShort(xmlNode.InnerText)));
												continue;
											}
											continue;
										}
									}
									else if (num <= 2501560678U)
									{
										if (num != 2380873069U)
										{
											if (num != 2407947114U)
											{
												if (num != 2501560678U)
												{
													continue;
												}
												if (Operators.CompareString(name, "WithdrawFuelThreshold", false) == 0)
												{
													doctrine.method_97(null, false, true, true, new Doctrine._FuelQuantityThreshold?((Doctrine._FuelQuantityThreshold)Conversions.ToShort(xmlNode.InnerText)));
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "RechargePercentagePatrol", false) == 0)
												{
													doctrine.method_259(null, false, true, true, new Doctrine._RechargeBatteryPercentage?((Doctrine._RechargeBatteryPercentage)Conversions.ToInteger(xmlNode.InnerText)));
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "BVRLogic", false) == 0)
											{
												doctrine.method_133(null, false, true, true, new Doctrine._BVRLogicEnum?((Doctrine._BVRLogicEnum)Conversions.ToByte(xmlNode.InnerText)));
												continue;
											}
											continue;
										}
									}
									else if (num != 2505807413U)
									{
										if (num != 2528837740U)
										{
											if (num != 2530879819U)
											{
												continue;
											}
											if (Operators.CompareString(name, "WCS_Air", false) != 0)
											{
												continue;
											}
											goto IL_1380;
										}
										else
										{
											if (Operators.CompareString(name, "E_Sonar", false) == 0)
											{
												goto IL_11FF;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "WinchesterShotgun", false) == 0)
										{
											doctrine.method_212(null, false, true, true, true, new Doctrine._WeaponState?((Doctrine._WeaponState)Conversions.ToInteger(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (num <= 2724490744U)
									{
										if (num <= 2637333443U)
										{
											if (num != 2569853489U)
											{
												if (num != 2588410225U)
												{
													if (num != 2637333443U)
													{
														continue;
													}
													if (Operators.CompareString(name, "SAM_ASUW_Player", false) == 0)
													{
														doctrine.bool_20 = Conversions.ToBoolean(xmlNode.InnerText);
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name, "UseTorpedoesKinematicRange", false) == 0)
													{
														doctrine.method_217(null, false, true, true, new Doctrine.Enum55?((Doctrine.Enum55)Conversions.ToByte(xmlNode.InnerText)));
														continue;
													}
													continue;
												}
											}
											else if (Operators.CompareString(name, "BehaviorTowardsAmbigousTarget", false) != 0)
											{
												continue;
											}
										}
										else if (num != 2649618078U)
										{
											if (num != 2704532014U)
											{
												if (num != 2724490744U)
												{
													continue;
												}
												if (Operators.CompareString(name, "WCS_Land_Player", false) == 0)
												{
													doctrine.bool_3 = Conversions.ToBoolean(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "AvoidContact", false) == 0)
												{
													doctrine.method_247(null, false, true, true, new Doctrine._AvoidContactWhenPossible?((Doctrine._AvoidContactWhenPossible)Conversions.ToByte(xmlNode.InnerText)));
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "ShootFirst", false) == 0)
											{
												goto IL_1380;
											}
											continue;
										}
									}
									else if (num <= 2957235506U)
									{
										if (num != 2909453697U)
										{
											if (num != 2953830872U)
											{
												if (num != 2957235506U)
												{
													continue;
												}
												if (Operators.CompareString(name, "RefuelAllies", false) == 0)
												{
													doctrine.method_241(null, false, true, true, new Doctrine._RefuelAlliedUnits?((Doctrine._RefuelAlliedUnits)Conversions.ToByte(xmlNode.InnerText)));
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "NukesAllowed_Inherits", false) == 0 && Conversions.ToBoolean(xmlNode.InnerText))
												{
													doctrine.nullable_6 = null;
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "QTA_Player", false) == 0)
											{
												goto IL_157A;
											}
											continue;
										}
									}
									else if (num != 2997369849U)
									{
										if (num != 2999508185U)
										{
											if (num != 3019355958U)
											{
												continue;
											}
											if (Operators.CompareString(name, "BTAT", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "E_OECM", false) == 0)
											{
												goto IL_166A;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "LandNav", false) == 0)
										{
											doctrine.method_188(null, false, true, true, new Doctrine.Enum63?((Doctrine.Enum63)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
									if (!Versioned.IsNumeric(xmlNode.InnerText))
									{
										if (Conversions.ToBoolean(xmlNode.InnerText))
										{
											doctrine.method_89(null, false, true, true, new Doctrine.Enum51?(Doctrine.Enum51.const_2));
											continue;
										}
										doctrine.method_89(null, false, true, true, new Doctrine.Enum51?(Doctrine.Enum51.const_1));
										continue;
									}
									else
									{
										if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
										{
											doctrine.method_89(null, false, true, true, new Doctrine.Enum51?(Doctrine.Enum51.const_2));
											continue;
										}
										doctrine.method_89(null, false, true, true, new Doctrine.Enum51?((Doctrine.Enum51)Conversions.ToByte(xmlNode.InnerText)));
										continue;
									}
								}
								IL_157A:
								doctrine.bool_22 = Conversions.ToBoolean(xmlNode.InnerText);
								continue;
							}
							if (num <= 3456526287U)
							{
								if (num <= 3154946918U)
								{
									if (num <= 3036757307U)
									{
										if (num != 3029320127U)
										{
											if (num != 3036757307U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Nukes_Player", false) == 0)
											{
												doctrine.bool_6 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "BVRLogic_Player", false) == 0)
											{
												doctrine.bool_10 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num != 3097459879U)
									{
										if (num != 3109207514U)
										{
											if (num != 3154946918U)
											{
												continue;
											}
											if (Operators.CompareString(name, "ST_Player", false) == 0)
											{
												doctrine.bool_19 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "WithdrawAttackThreshold", false) == 0)
											{
												doctrine.method_100(null, false, true, true, new Doctrine._WeaponQuantityThreshold?((Doctrine._WeaponQuantityThreshold)Conversions.ToShort(xmlNode.InnerText)));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "WinchesterShotgun_Player", false) == 0)
										{
											doctrine.bool_25 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num <= 3240019622U)
								{
									if (num != 3170035372U)
									{
										if (num != 3220006457U)
										{
											if (num != 3240019622U)
											{
												continue;
											}
											if (Operators.CompareString(name, "RedeployAttackThreshold", false) == 0)
											{
												doctrine.method_112(null, false, true, true, new Doctrine._WeaponQuantityThreshold?((Doctrine._WeaponQuantityThreshold)Conversions.ToShort(xmlNode.InnerText)));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "WinchesterShotgunRTB_Player", false) == 0)
											{
												goto IL_1852;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "RedeployDefenceThreshold", false) == 0)
										{
											doctrine.method_115(null, false, true, true, new Doctrine._WeaponQuantityThreshold?((Doctrine._WeaponQuantityThreshold)Conversions.ToShort(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else if (num != 3313931310U)
								{
									if (num != 3444605084U)
									{
										if (num != 3456526287U)
										{
											continue;
										}
										if (Operators.CompareString(name, "DippingSonar_Player", false) == 0)
										{
											doctrine.bool_33 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "AirOpsTempo", false) == 0)
										{
											doctrine.method_202(null, false, true, true, true, new Doctrine.Enum54?((Doctrine.Enum54)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "RechargePercentagePatrol_Player", false) == 0)
									{
										doctrine.bool_30 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 3938078664U)
							{
								if (num <= 3745846603U)
								{
									if (num != 3478926953U)
									{
										if (num != 3489877104U)
										{
											if (num != 3745846603U)
											{
												continue;
											}
											if (Operators.CompareString(name, "WCS_Submarine", false) == 0)
											{
												doctrine.method_74(null, false, null, true, true, new Doctrine.Enum52?((Doctrine.Enum52)Conversions.ToByte(xmlNode.InnerText)));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "AIPUsage", false) == 0)
											{
												doctrine.method_271(null, false, true, true, new Doctrine._UseAIP?((Doctrine._UseAIP)Conversions.ToByte(xmlNode.InnerText)));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "Nukes", false) == 0)
										{
											goto IL_19FB;
										}
										continue;
									}
								}
								else if (num != 3846505587U)
								{
									if (num != 3847341200U)
									{
										if (num != 3938078664U)
										{
											continue;
										}
										if (Operators.CompareString(name, "WCS_Surface", false) == 0)
										{
											doctrine.method_69(null, false, null, true, true, new Doctrine.Enum52?((Doctrine.Enum52)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "WCS_Land", false) == 0)
										{
											doctrine.method_79(null, false, null, true, true, new Doctrine.Enum52?((Doctrine.Enum52)Conversions.ToByte(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "WinchesterShotgunRTB", false) == 0)
									{
										goto IL_1B37;
									}
									continue;
								}
							}
							else if (num <= 4037167626U)
							{
								if (num != 3973228320U)
								{
									if (num != 4004128433U)
									{
										if (num != 4037167626U)
										{
											continue;
										}
										if (Operators.CompareString(name, "UR_Player", false) == 0)
										{
											doctrine.bool_17 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "WithdrawDamageThreshold", false) == 0)
										{
											doctrine.method_94(null, false, true, true, new Doctrine._DamageThreshold?((Doctrine._DamageThreshold)Conversions.ToShort(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "RechargePercentageAttack_Player", false) == 0)
									{
										doctrine.bool_31 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 4059101362U)
							{
								if (num != 4085195859U)
								{
									if (num != 4268668376U)
									{
										continue;
									}
									if (Operators.CompareString(name, "AIPUsage_Player", false) == 0)
									{
										doctrine.bool_32 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "JettisonOrdnance_Player", false) == 0)
									{
										doctrine.bool_9 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "DiveWhenThreatsDetected_Player", false) == 0)
								{
									doctrine.bool_29 = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						IL_F78:
						@enum = new Doctrine.Class275.Enum66?((Doctrine.Class275.Enum66)XmlConvert.ToByte(xmlNode.InnerText));
						continue;
						IL_11FF:
						enum2 = new Doctrine.Class275.Enum66?((Doctrine.Class275.Enum66)XmlConvert.ToByte(xmlNode.InnerText));
						continue;
						IL_1380:
						if (!Versioned.IsNumeric(xmlNode.InnerText))
						{
							if (Conversions.ToBoolean(xmlNode.InnerText))
							{
								doctrine.method_64(null, false, null, true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_0));
								doctrine.method_69(null, false, null, true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_0));
								doctrine.method_74(null, false, null, true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_0));
								doctrine.method_79(null, false, null, true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_0));
								continue;
							}
							doctrine.method_64(null, false, null, true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
							doctrine.method_69(null, false, null, true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
							doctrine.method_74(null, false, null, true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
							doctrine.method_79(null, false, null, true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
							continue;
						}
						else
						{
							if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
							{
								doctrine.method_64(null, false, null, true, true, new Doctrine.Enum52?(Doctrine.Enum52.const_0));
								continue;
							}
							doctrine.method_64(null, false, null, true, true, new Doctrine.Enum52?((Doctrine.Enum52)Conversions.ToByte(xmlNode.InnerText)));
							continue;
						}
						IL_166A:
						enum3 = new Doctrine.Class275.Enum66?((Doctrine.Class275.Enum66)XmlConvert.ToByte(xmlNode.InnerText));
						continue;
						IL_1852:
						doctrine.bool_7 = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_19FB:
						if (!Versioned.IsNumeric(xmlNode.InnerText))
						{
							if (Conversions.ToBoolean(xmlNode.InnerText))
							{
								doctrine.method_32(null, false, true, true, new Doctrine.Enum65?(Doctrine.Enum65.const_1));
								continue;
							}
							doctrine.method_32(null, false, true, true, new Doctrine.Enum65?(Doctrine.Enum65.const_0));
							continue;
						}
						else
						{
							if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
							{
								doctrine.method_32(null, false, true, true, new Doctrine.Enum65?(Doctrine.Enum65.const_1));
								continue;
							}
							doctrine.method_32(null, false, true, true, new Doctrine.Enum65?((Doctrine.Enum65)Conversions.ToByte(xmlNode.InnerText)));
							continue;
						}
						IL_1B37:
						if (!Versioned.IsNumeric(xmlNode.InnerText))
						{
							if (Conversions.ToBoolean(xmlNode.InnerText))
							{
								doctrine.method_118(null, false, true, true, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLeaveGroup));
							}
							else
							{
								doctrine.method_118(null, false, true, true, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.No));
							}
						}
						else if (Operators.CompareString(xmlNode.InnerText, "255", false) == 0)
						{
							doctrine.method_118(null, false, true, true, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLeaveGroup));
						}
						else
						{
							doctrine.method_118(null, false, true, true, new Doctrine._WeaponStateRTB?((Doctrine._WeaponStateRTB)Conversions.ToByte(xmlNode.InnerText)));
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (@enum != null || enum2 != null || enum3 != null)
				{
					doctrine.class275_0 = new Doctrine.Class275(@enum.Value, enum2.Value, enum3.Value);
				}
				result = doctrine;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101004", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				List<ActiveUnit> list = null;
				result = new Doctrine(class310_1, ref list);
			}
			return result;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00147BC0 File Offset: 0x00145DC0
		public void method_283(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum65? nullable_42)
		{
			Doctrine.Enum65? @enum = this.method_31(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_36(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_33())
			{
				comboBox_0.SelectedIndex = 2;
			}
			else
			{
				Doctrine.Enum65? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 3;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x00147D94 File Offset: 0x00145F94
		public void method_284(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_32(scenario_0, true, bool_35, bool_36, new Doctrine.Enum65?(Doctrine.Enum65.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_32(scenario_0, false, bool_35, bool_36, new Doctrine.Enum65?(Doctrine.Enum65.const_1));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_32(scenario_0, true, bool_35, bool_36, new Doctrine.Enum65?(Doctrine.Enum65.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_32(scenario_0, false, bool_35, bool_36, new Doctrine.Enum65?(Doctrine.Enum65.const_0));
				return;
			case 2:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_32(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_32(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00147F48 File Offset: 0x00146148
		public void method_285(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum52? nullable_42)
		{
			Doctrine.Enum52? @enum = this.method_63(scenario_0, false, null, false, false);
			DataTable dataSource = new DataTable();
			this.method_37(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_65())
			{
				comboBox_0.SelectedIndex = 3;
			}
			else
			{
				Doctrine.Enum52? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 4;
							}
							else
							{
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00148178 File Offset: 0x00146378
		public void method_286(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_64(scenario_0, true, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_64(scenario_0, false, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_0));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_64(scenario_0, true, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_64(scenario_0, false, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_64(scenario_0, true, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_2));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_64(scenario_0, false, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_2));
				return;
			case 3:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_64(scenario_0, true, null, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_64(scenario_0, false, new bool?(false), bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x001483D8 File Offset: 0x001465D8
		public void method_287(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum52? nullable_42)
		{
			Doctrine.Enum52? @enum = this.method_68(scenario_0, false, null, false, false);
			DataTable dataSource = new DataTable();
			this.method_38(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_70())
			{
				comboBox_0.SelectedIndex = 3;
			}
			else
			{
				Doctrine.Enum52? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 4;
							}
							else
							{
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00148608 File Offset: 0x00146808
		public void method_288(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_69(scenario_0, true, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_69(scenario_0, false, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_0));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_69(scenario_0, true, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_69(scenario_0, false, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_69(scenario_0, true, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_2));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_69(scenario_0, false, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_2));
				return;
			case 3:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_69(scenario_0, true, null, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_69(scenario_0, false, new bool?(false), bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00148868 File Offset: 0x00146A68
		public void method_289(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum52? nullable_42)
		{
			Doctrine.Enum52? @enum = this.method_73(scenario_0, false, null, false, false);
			DataTable dataSource = new DataTable();
			this.method_39(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_75())
			{
				comboBox_0.SelectedIndex = 3;
			}
			else
			{
				Doctrine.Enum52? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 4;
							}
							else
							{
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00148A98 File Offset: 0x00146C98
		public void method_290(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_74(scenario_0, true, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_74(scenario_0, false, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_0));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_74(scenario_0, true, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_74(scenario_0, false, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_74(scenario_0, true, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_2));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_74(scenario_0, false, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_2));
				return;
			case 3:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_74(scenario_0, true, null, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_74(scenario_0, false, new bool?(false), bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00148CF8 File Offset: 0x00146EF8
		public void method_291(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum52? nullable_42)
		{
			Doctrine.Enum52? @enum = this.method_78(scenario_0, false, null, false, false);
			DataTable dataSource = new DataTable();
			this.method_40(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_80())
			{
				comboBox_0.SelectedIndex = 3;
			}
			else
			{
				Doctrine.Enum52? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 4;
							}
							else
							{
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00148F28 File Offset: 0x00147128
		public void method_292(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_79(scenario_0, true, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_79(scenario_0, false, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_0));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_79(scenario_0, true, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_79(scenario_0, false, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_79(scenario_0, true, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_2));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_79(scenario_0, false, new bool?(false), bool_35, bool_36, new Doctrine.Enum52?(Doctrine.Enum52.const_2));
				return;
			case 3:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_79(scenario_0, true, null, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_79(scenario_0, false, new bool?(false), bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00149188 File Offset: 0x00147388
		public void method_293(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum64? nullable_42)
		{
			Doctrine.Enum64? @enum = this.method_83(scenario_0, false, null, false, false);
			DataTable dataSource = new DataTable();
			this.method_41(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_85())
			{
				comboBox_0.SelectedIndex = 2;
			}
			else
			{
				Doctrine.Enum64? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 3;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0014935C File Offset: 0x0014755C
		public void method_294(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_84(scenario_0, true, new bool?(false), bool_35, bool_36, new Doctrine.Enum64?(Doctrine.Enum64.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_84(scenario_0, false, new bool?(false), bool_35, bool_36, new Doctrine.Enum64?(Doctrine.Enum64.const_1));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_84(scenario_0, true, new bool?(false), bool_35, bool_36, new Doctrine.Enum64?(Doctrine.Enum64.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_84(scenario_0, false, new bool?(false), bool_35, bool_36, new Doctrine.Enum64?(Doctrine.Enum64.const_0));
				return;
			case 2:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_84(scenario_0, true, null, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_84(scenario_0, false, new bool?(false), bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00149538 File Offset: 0x00147738
		public void method_295(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._WeaponStateRTB? nullable_42)
		{
			Doctrine._WeaponStateRTB? weaponStateRTB = this.method_117(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_42(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_119())
			{
				comboBox_0.SelectedIndex = 4;
			}
			else
			{
				Doctrine._WeaponStateRTB? weaponStateRTB2 = weaponStateRTB;
				byte? b = (weaponStateRTB2 != null) ? new byte?((byte)weaponStateRTB2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((weaponStateRTB2 != null) ? new byte?((byte)weaponStateRTB2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((weaponStateRTB2 != null) ? new byte?((byte)weaponStateRTB2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((weaponStateRTB2 != null) ? new byte?((byte)weaponStateRTB2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								b = ((weaponStateRTB2 != null) ? new byte?((byte)weaponStateRTB2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 5;
								}
								else
								{
									b = ((weaponStateRTB2 != null) ? new byte?((byte)weaponStateRTB2.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 5;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x001497C8 File Offset: 0x001479C8
		public void method_296(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_118(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLeaveGroup));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_118(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLeaveGroup));
				break;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_118(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesFirstUnit));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_118(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesFirstUnit));
				break;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_118(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_118(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
				break;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_118(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.No));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_118(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.No));
				break;
			case 4:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_118(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_118(scenario_0, false, bool_35, bool_36, null);
				break;
			}
			if (comboBox_0.SelectedIndex >= 0)
			{
				try
				{
					foreach (ActiveUnit activeUnit6 in this.method_5(scenario_0, null))
					{
						if (activeUnit6.bool_3)
						{
							activeUnit6.vmethod_113(ActiveUnit._ActiveUnitWeaponState.None);
							if (activeUnit6.vmethod_127())
							{
								activeUnit6.vmethod_86().vmethod_11(0f, false, true);
							}
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator6;
					((IDisposable)enumerator6).Dispose();
				}
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00149AFC File Offset: 0x00147CFC
		public void method_297(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._FuelStateRTB? nullable_42)
		{
			Doctrine._FuelStateRTB? fuelStateRTB = this.method_122(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_43(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_124())
			{
				comboBox_0.SelectedIndex = 4;
			}
			else
			{
				Doctrine._FuelStateRTB? fuelStateRTB2 = fuelStateRTB;
				byte? b = (fuelStateRTB2 != null) ? new byte?((byte)fuelStateRTB2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((fuelStateRTB2 != null) ? new byte?((byte)fuelStateRTB2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((fuelStateRTB2 != null) ? new byte?((byte)fuelStateRTB2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((fuelStateRTB2 != null) ? new byte?((byte)fuelStateRTB2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								b = ((fuelStateRTB2 != null) ? new byte?((byte)fuelStateRTB2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 5;
								}
								else
								{
									b = ((fuelStateRTB2 != null) ? new byte?((byte)fuelStateRTB2.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 5;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00149D8C File Offset: 0x00147F8C
		public void method_298(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_123(scenario_0, true, bool_35, bool_36, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesLeaveGroup));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_123(scenario_0, false, bool_35, bool_36, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesLeaveGroup));
				break;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_123(scenario_0, true, bool_35, bool_36, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesFirstUnit));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_123(scenario_0, false, bool_35, bool_36, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesFirstUnit));
				break;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_123(scenario_0, true, bool_35, bool_36, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesLastUnit));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_123(scenario_0, false, bool_35, bool_36, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesLastUnit));
				break;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_123(scenario_0, true, bool_35, bool_36, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.No));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_123(scenario_0, false, bool_35, bool_36, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.No));
				break;
			case 4:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_123(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_123(scenario_0, false, bool_35, bool_36, null);
				break;
			}
			if (comboBox_0.SelectedIndex >= 0)
			{
				try
				{
					foreach (ActiveUnit activeUnit6 in this.method_5(scenario_0, null))
					{
						if (activeUnit6.bool_3)
						{
							activeUnit6.vmethod_111(ActiveUnit._ActiveUnitFuelState.None);
							if (activeUnit6.vmethod_127())
							{
								activeUnit6.vmethod_86().vmethod_11(0f, true, false);
							}
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator6;
					((IDisposable)enumerator6).Dispose();
				}
			}
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0014A0C0 File Offset: 0x001482C0
		public void method_299(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._JettisonOrdnance? nullable_42)
		{
			Doctrine._JettisonOrdnance? jettisonOrdnance = this.method_127(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_44(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_129())
			{
				comboBox_0.SelectedIndex = 2;
			}
			else
			{
				Doctrine._JettisonOrdnance? jettisonOrdnance2 = jettisonOrdnance;
				byte? b = (jettisonOrdnance2 != null) ? new byte?((byte)jettisonOrdnance2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((jettisonOrdnance2 != null) ? new byte?((byte)jettisonOrdnance2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((jettisonOrdnance2 != null) ? new byte?((byte)jettisonOrdnance2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 3;
						}
						else
						{
							b = ((jettisonOrdnance2 != null) ? new byte?((byte)jettisonOrdnance2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0014A294 File Offset: 0x00148494
		public void method_300(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_128(scenario_0, true, bool_35, bool_36, new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.Yes));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_128(scenario_0, false, bool_35, bool_36, new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.Yes));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_128(scenario_0, true, bool_35, bool_36, new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.No));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_128(scenario_0, false, bool_35, bool_36, new Doctrine._JettisonOrdnance?(Doctrine._JettisonOrdnance.No));
				return;
			case 2:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_128(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_128(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0014A448 File Offset: 0x00148648
		public void method_301(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._BVRLogicEnum? nullable_42)
		{
			try
			{
				Doctrine._BVRLogicEnum? bvrlogicEnum = this.method_132(scenario_0, false, false, false);
				DataTable dataSource = new DataTable();
				this.method_45(ref dataSource, scenario_0, nullable_42);
				comboBox_0.DataSource = dataSource;
				comboBox_0.DisplayMember = "Description";
				comboBox_0.ValueMember = "ID";
				if (this.method_134())
				{
					comboBox_0.SelectedIndex = 3;
				}
				else
				{
					Doctrine._BVRLogicEnum? bvrlogicEnum2 = bvrlogicEnum;
					byte? b = (bvrlogicEnum2 != null) ? new byte?((byte)bvrlogicEnum2.GetValueOrDefault()) : null;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 0;
					}
					else
					{
						b = ((bvrlogicEnum2 != null) ? new byte?((byte)bvrlogicEnum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 1;
						}
						else
						{
							b = ((bvrlogicEnum2 != null) ? new byte?((byte)bvrlogicEnum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 2;
							}
							else
							{
								b = ((bvrlogicEnum2 != null) ? new byte?((byte)bvrlogicEnum2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
								else
								{
									b = ((bvrlogicEnum2 != null) ? new byte?((byte)bvrlogicEnum2.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 4;
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0014A6B0 File Offset: 0x001488B0
		public void method_302(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_133(scenario_0, true, bool_35, bool_36, new Doctrine._BVRLogicEnum?(Doctrine._BVRLogicEnum.StraightIn));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_133(scenario_0, false, bool_35, bool_36, new Doctrine._BVRLogicEnum?(Doctrine._BVRLogicEnum.StraightIn));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_133(scenario_0, true, bool_35, bool_36, new Doctrine._BVRLogicEnum?(Doctrine._BVRLogicEnum.Crank));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_133(scenario_0, false, bool_35, bool_36, new Doctrine._BVRLogicEnum?(Doctrine._BVRLogicEnum.Crank));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_133(scenario_0, true, bool_35, bool_36, new Doctrine._BVRLogicEnum?(Doctrine._BVRLogicEnum.Drag));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_133(scenario_0, false, bool_35, bool_36, new Doctrine._BVRLogicEnum?(Doctrine._BVRLogicEnum.Drag));
				return;
			case 3:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_133(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_133(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0014A8DC File Offset: 0x00148ADC
		public void method_303(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum51? nullable_42)
		{
			Doctrine.Enum51? @enum = this.method_88(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_46(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_90())
			{
				comboBox_0.SelectedIndex = 3;
			}
			else
			{
				Doctrine.Enum51? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 4;
							}
							else
							{
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0014AB0C File Offset: 0x00148D0C
		public void method_304(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_89(scenario_0, true, bool_35, bool_36, new Doctrine.Enum51?(Doctrine.Enum51.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_89(scenario_0, false, bool_35, bool_36, new Doctrine.Enum51?(Doctrine.Enum51.const_0));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_89(scenario_0, true, bool_35, bool_36, new Doctrine.Enum51?(Doctrine.Enum51.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_89(scenario_0, false, bool_35, bool_36, new Doctrine.Enum51?(Doctrine.Enum51.const_1));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_89(scenario_0, true, bool_35, bool_36, new Doctrine.Enum51?(Doctrine.Enum51.const_2));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_89(scenario_0, false, bool_35, bool_36, new Doctrine.Enum51?(Doctrine.Enum51.const_2));
				return;
			case 3:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_89(scenario_0, false, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_89(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0014AD38 File Offset: 0x00148F38
		public void method_305(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum61? nullable_42)
		{
			Doctrine.Enum61? @enum = this.method_137(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_47(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_139())
			{
				comboBox_0.SelectedIndex = 2;
			}
			else
			{
				Doctrine.Enum61? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 3;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0014AF0C File Offset: 0x0014910C
		public void method_306(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_138(scenario_0, true, bool_35, bool_36, new Doctrine.Enum61?(Doctrine.Enum61.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_138(scenario_0, false, bool_35, bool_36, new Doctrine.Enum61?(Doctrine.Enum61.const_1));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_138(scenario_0, true, bool_35, bool_36, new Doctrine.Enum61?(Doctrine.Enum61.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_138(scenario_0, false, bool_35, bool_36, new Doctrine.Enum61?(Doctrine.Enum61.const_0));
				return;
			case 2:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_138(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_138(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0014B0C0 File Offset: 0x001492C0
		public void method_307(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum62? nullable_42)
		{
			Doctrine.Enum62? @enum = this.method_142(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_48(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_144())
			{
				comboBox_0.SelectedIndex = 2;
			}
			else
			{
				Doctrine.Enum62? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 3;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0014B294 File Offset: 0x00149494
		public void method_308(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_143(scenario_0, true, bool_35, bool_36, new Doctrine.Enum62?(Doctrine.Enum62.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_143(scenario_0, false, bool_35, bool_36, new Doctrine.Enum62?(Doctrine.Enum62.const_1));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_143(scenario_0, true, bool_35, bool_36, new Doctrine.Enum62?(Doctrine.Enum62.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_143(scenario_0, false, bool_35, bool_36, new Doctrine.Enum62?(Doctrine.Enum62.const_0));
				return;
			case 2:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_143(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_143(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0014B448 File Offset: 0x00149648
		public void method_309(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum63? nullable_42)
		{
			Doctrine.Enum63? @enum = this.method_177(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_49(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_179())
			{
				comboBox_0.SelectedIndex = 3;
			}
			else
			{
				Doctrine.Enum63? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 6) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 4;
							}
							else
							{
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 7) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0014B678 File Offset: 0x00149878
		public void method_310(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_178(scenario_0, true, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_178(scenario_0, false, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_0));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_178(scenario_0, true, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_178(scenario_0, false, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_1));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_178(scenario_0, true, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_2));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_178(scenario_0, false, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_2));
				return;
			case 3:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_178(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_178(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0014B8A4 File Offset: 0x00149AA4
		public void method_311(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum63? nullable_42)
		{
			Doctrine.Enum63? @enum = this.method_182(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_50(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_184())
			{
				comboBox_0.SelectedIndex = 4;
			}
			else
			{
				Doctrine.Enum63? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 6) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 5;
								}
								else
								{
									b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 7) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 5;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0014BB34 File Offset: 0x00149D34
		public void method_312(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_183(scenario_0, true, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_183(scenario_0, false, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_0));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_183(scenario_0, true, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_3));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_183(scenario_0, false, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_3));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_183(scenario_0, true, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_4));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_183(scenario_0, false, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_4));
				return;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_183(scenario_0, true, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_5));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_183(scenario_0, false, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_5));
				return;
			case 4:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_183(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_183(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0014BDD4 File Offset: 0x00149FD4
		public void method_313(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum63? nullable_42)
		{
			Doctrine.Enum63? @enum = this.method_187(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_51(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_189())
			{
				comboBox_0.SelectedIndex = 1;
			}
			else
			{
				Doctrine.Enum63? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 6) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 2;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 7) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
					}
				}
			}
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0014BF48 File Offset: 0x0014A148
		public void method_314(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			int selectedIndex = comboBox_0.SelectedIndex;
			if (selectedIndex == 0)
			{
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_188(scenario_0, true, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_188(scenario_0, false, bool_35, bool_36, new Doctrine.Enum63?(Doctrine.Enum63.const_0));
				return;
			}
			if (selectedIndex != 1)
			{
				return;
			}
			if (this.class310_0.GetType() == typeof(Side))
			{
				GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
				comboBox_0.SelectedIndex = int_0;
				return;
			}
			if (!Information.IsNothing(this.list_0))
			{
				try
				{
					foreach (ActiveUnit activeUnit2 in this.list_0)
					{
						activeUnit2.doctrine_0.method_188(scenario_0, true, bool_35, bool_36, null);
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
			this.method_188(scenario_0, false, bool_35, bool_36, null);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0014C080 File Offset: 0x0014A280
		public void method_315(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._GunStrafeGroundTargets? nullable_42)
		{
			Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = this.method_147(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_52(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_149())
			{
				comboBox_0.SelectedIndex = 2;
			}
			else
			{
				Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets2 = gunStrafeGroundTargets;
				byte? b = (gunStrafeGroundTargets2 != null) ? new byte?((byte)gunStrafeGroundTargets2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((gunStrafeGroundTargets2 != null) ? new byte?((byte)gunStrafeGroundTargets2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((gunStrafeGroundTargets2 != null) ? new byte?((byte)gunStrafeGroundTargets2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 3;
						}
						else
						{
							b = ((gunStrafeGroundTargets2 != null) ? new byte?((byte)gunStrafeGroundTargets2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0014C254 File Offset: 0x0014A454
		public void method_316(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_148(scenario_0, true, bool_35, bool_36, new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.Yes));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_148(scenario_0, false, bool_35, bool_36, new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.Yes));
				break;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_148(scenario_0, true, bool_35, bool_36, new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.No));
							if (activeUnit2.vmethod_127() && activeUnit2.bool_3)
							{
								activeUnit2.vmethod_86().vmethod_11(0f, false, false);
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_148(scenario_0, false, bool_35, bool_36, new Doctrine._GunStrafeGroundTargets?(Doctrine._GunStrafeGroundTargets.No));
				break;
			case 2:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_148(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_148(scenario_0, false, bool_35, bool_36, null);
				break;
			}
			if (comboBox_0.SelectedIndex >= 0)
			{
				try
				{
					foreach (ActiveUnit activeUnit4 in this.method_5(scenario_0, null))
					{
						if (activeUnit4.vmethod_127() && activeUnit4.bool_3)
						{
							activeUnit4.vmethod_86().vmethod_11(0f, false, false);
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator4;
					((IDisposable)enumerator4).Dispose();
				}
			}
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0014C4B0 File Offset: 0x0014A6B0
		public void method_317(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum56? nullable_42)
		{
			Doctrine.Enum56? @enum = this.method_152(scenario_0, false, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_53(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_154())
			{
				comboBox_0.SelectedIndex = 3;
			}
			else
			{
				Doctrine.Enum56? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 4;
							}
							else
							{
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0014C6E0 File Offset: 0x0014A8E0
		public void method_318(int int_0, ref Scenario scenario_0, ref int int_1, bool bool_35, bool bool_36, bool bool_37)
		{
			switch (int_0)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_153(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine.Enum56?(Doctrine.Enum56.const_2));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_153(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine.Enum56?(Doctrine.Enum56.const_2));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_153(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine.Enum56?(Doctrine.Enum56.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_153(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine.Enum56?(Doctrine.Enum56.const_0));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_153(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine.Enum56?(Doctrine.Enum56.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_153(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine.Enum56?(Doctrine.Enum56.const_1));
				return;
			case 3:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					int_0 = int_1;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_153(scenario_0, true, bool_35, bool_36, bool_37, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_153(scenario_0, false, bool_35, bool_36, bool_37, null);
				return;
			case 4:
				this.method_153(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine.Enum56?(Doctrine.Enum56.const_4));
				return;
			default:
				return;
			}
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0014C92C File Offset: 0x0014AB2C
		public void method_319(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum57? nullable_42)
		{
			Doctrine.Enum57? @enum = this.method_157(scenario_0, false, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_54(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_159())
			{
				comboBox_0.SelectedIndex = 3;
			}
			else
			{
				Doctrine.Enum57? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 4;
							}
							else
							{
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x0014CB5C File Offset: 0x0014AD5C
		public void method_320(int int_0, ref Scenario scenario_0, ref int int_1, bool bool_35, bool bool_36, bool bool_37)
		{
			switch (int_0)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_158(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine.Enum57?(Doctrine.Enum57.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_158(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine.Enum57?(Doctrine.Enum57.const_0));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_158(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine.Enum57?(Doctrine.Enum57.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_158(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine.Enum57?(Doctrine.Enum57.const_1));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_158(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine.Enum57?(Doctrine.Enum57.const_2));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_158(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine.Enum57?(Doctrine.Enum57.const_2));
				return;
			case 3:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					int_0 = int_1;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_158(scenario_0, true, bool_35, bool_36, bool_37, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_158(scenario_0, false, bool_35, bool_36, bool_37, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0014CD8C File Offset: 0x0014AF8C
		public void method_321(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum59? nullable_42)
		{
			Doctrine.Enum59? @enum = this.method_162(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_55(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_164())
			{
				comboBox_0.SelectedIndex = 2;
			}
			else
			{
				Doctrine.Enum59? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 3;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0014CF60 File Offset: 0x0014B160
		public void method_322(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_163(scenario_0, true, bool_35, bool_36, new Doctrine.Enum59?(Doctrine.Enum59.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_163(scenario_0, false, bool_35, bool_36, new Doctrine.Enum59?(Doctrine.Enum59.const_1));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_163(scenario_0, true, bool_35, bool_36, new Doctrine.Enum59?(Doctrine.Enum59.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_163(scenario_0, false, bool_35, bool_36, new Doctrine.Enum59?(Doctrine.Enum59.const_0));
				return;
			case 2:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_163(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_163(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0014D114 File Offset: 0x0014B314
		public void method_323(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum58? nullable_42)
		{
			Doctrine.Enum58? @enum = this.method_167(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_56(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_169())
			{
				comboBox_0.SelectedIndex = 2;
			}
			else
			{
				Doctrine.Enum58? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 3;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0014D2E8 File Offset: 0x0014B4E8
		public void method_324(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_168(scenario_0, true, bool_35, bool_36, new Doctrine.Enum58?(Doctrine.Enum58.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_168(scenario_0, false, bool_35, bool_36, new Doctrine.Enum58?(Doctrine.Enum58.const_1));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_168(scenario_0, true, bool_35, bool_36, new Doctrine.Enum58?(Doctrine.Enum58.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_168(scenario_0, false, bool_35, bool_36, new Doctrine.Enum58?(Doctrine.Enum58.const_0));
				return;
			case 2:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_168(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_168(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x0014D49C File Offset: 0x0014B69C
		public void method_325(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum60? nullable_42)
		{
			Doctrine.Enum60? @enum = this.method_172(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_57(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_174())
			{
				comboBox_0.SelectedIndex = 2;
			}
			else
			{
				Doctrine.Enum60? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 3;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0014D670 File Offset: 0x0014B870
		public void method_326(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_173(scenario_0, true, bool_35, bool_36, new Doctrine.Enum60?(Doctrine.Enum60.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_173(scenario_0, false, bool_35, bool_36, new Doctrine.Enum60?(Doctrine.Enum60.const_1));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_173(scenario_0, true, bool_35, bool_36, new Doctrine.Enum60?(Doctrine.Enum60.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_173(scenario_0, false, bool_35, bool_36, new Doctrine.Enum60?(Doctrine.Enum60.const_0));
				return;
			case 2:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_173(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_173(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0014D824 File Offset: 0x0014BA24
		public void method_327(ComboBox comboBox_0, ref Scenario scenario_0, ref bool bool_35, Doctrine.Enum53? nullable_42)
		{
			Doctrine.Enum53? @enum = this.method_196(scenario_0, false, bool_35, false, false);
			DataTable dataSource = new DataTable();
			this.method_58(ref dataSource, scenario_0, bool_35, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_198())
			{
				comboBox_0.SelectedIndex = 3;
			}
			else
			{
				Doctrine.Enum53? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 4;
							}
							else
							{
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x0014DA58 File Offset: 0x0014BC58
		public void method_328(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, ref bool bool_35, bool bool_36, bool bool_37)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_197(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine.Enum53?(Doctrine.Enum53.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_197(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine.Enum53?(Doctrine.Enum53.const_0));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_197(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine.Enum53?(Doctrine.Enum53.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_197(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine.Enum53?(Doctrine.Enum53.const_1));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_197(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine.Enum53?(Doctrine.Enum53.const_2));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_197(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine.Enum53?(Doctrine.Enum53.const_2));
				return;
			case 3:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_197(scenario_0, false, bool_35, bool_36, bool_37, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_197(scenario_0, false, bool_35, bool_36, bool_37, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0014DC9C File Offset: 0x0014BE9C
		public void method_329(ComboBox comboBox_0, ref Scenario scenario_0, ref bool bool_35, Doctrine.Enum54? nullable_42)
		{
			Doctrine.Enum54? @enum = this.method_201(scenario_0, false, bool_35, false, false);
			DataTable dataSource = new DataTable();
			this.method_59(ref dataSource, scenario_0, bool_35, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_203())
			{
				comboBox_0.SelectedIndex = 2;
			}
			else
			{
				Doctrine.Enum54? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 3;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0014DE74 File Offset: 0x0014C074
		public void method_330(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, ref bool bool_35, bool bool_36, bool bool_37)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_202(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine.Enum54?(Doctrine.Enum54.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_202(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine.Enum54?(Doctrine.Enum54.const_1));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_202(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine.Enum54?(Doctrine.Enum54.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_202(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine.Enum54?(Doctrine.Enum54.const_0));
				return;
			case 2:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_202(scenario_0, true, bool_35, bool_36, bool_37, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_202(scenario_0, false, bool_35, bool_36, bool_37, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x0014E038 File Offset: 0x0014C238
		public void method_331(ComboBox comboBox_0, ref Scenario scenario_0, ref bool bool_35, Doctrine._FuelState? nullable_42)
		{
			Doctrine._FuelState? fuelState = this.method_206(scenario_0, false, bool_35, false, false);
			DataTable dataSource = new DataTable();
			this.method_61(ref dataSource, scenario_0, bool_35, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_208())
			{
				comboBox_0.SelectedIndex = 12;
			}
			else
			{
				Doctrine._FuelState? fuelState2 = fuelState;
				byte? b = (fuelState2 != null) ? new byte?((byte)fuelState2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((fuelState2 != null) ? new byte?((byte)fuelState2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((fuelState2 != null) ? new byte?((byte)fuelState2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((fuelState2 != null) ? new byte?((byte)fuelState2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								b = ((fuelState2 != null) ? new byte?((byte)fuelState2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
								else
								{
									b = ((fuelState2 != null) ? new byte?((byte)fuelState2.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 5;
									}
									else
									{
										b = ((fuelState2 != null) ? new byte?((byte)fuelState2.GetValueOrDefault()) : null);
										if (((b != null) ? new bool?(b.GetValueOrDefault() == 6) : null).GetValueOrDefault())
										{
											comboBox_0.SelectedIndex = 6;
										}
										else
										{
											b = ((fuelState2 != null) ? new byte?((byte)fuelState2.GetValueOrDefault()) : null);
											if (((b != null) ? new bool?(b.GetValueOrDefault() == 7) : null).GetValueOrDefault())
											{
												comboBox_0.SelectedIndex = 7;
											}
											else
											{
												b = ((fuelState2 != null) ? new byte?((byte)fuelState2.GetValueOrDefault()) : null);
												if (((b != null) ? new bool?(b.GetValueOrDefault() == 8) : null).GetValueOrDefault())
												{
													comboBox_0.SelectedIndex = 8;
												}
												else
												{
													b = ((fuelState2 != null) ? new byte?((byte)fuelState2.GetValueOrDefault()) : null);
													if (((b != null) ? new bool?(b.GetValueOrDefault() == 9) : null).GetValueOrDefault())
													{
														comboBox_0.SelectedIndex = 9;
													}
													else
													{
														b = ((fuelState2 != null) ? new byte?((byte)fuelState2.GetValueOrDefault()) : null);
														if (((b != null) ? new bool?(b.GetValueOrDefault() == 10) : null).GetValueOrDefault())
														{
															comboBox_0.SelectedIndex = 10;
														}
														else
														{
															b = ((fuelState2 != null) ? new byte?((byte)fuelState2.GetValueOrDefault()) : null);
															if (((b != null) ? new bool?(b.GetValueOrDefault() == 11) : null).GetValueOrDefault())
															{
																comboBox_0.SelectedIndex = 11;
															}
															else
															{
																b = ((fuelState2 != null) ? new byte?((byte)fuelState2.GetValueOrDefault()) : null);
																if (((b != null) ? new bool?(b.GetValueOrDefault() == 12) : null).GetValueOrDefault())
																{
																	comboBox_0.SelectedIndex = 13;
																}
																else
																{
																	b = ((fuelState2 != null) ? new byte?((byte)fuelState2.GetValueOrDefault()) : null);
																	if (((b != null) ? new bool?(b.GetValueOrDefault() == 14) : null).GetValueOrDefault())
																	{
																		comboBox_0.SelectedIndex = 13;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x0014E5C8 File Offset: 0x0014C7C8
		public void method_332(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, ref bool bool_35, ref bool bool_36, bool bool_37, bool bool_38)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_207(scenario_0, true, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Bingo));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_207(scenario_0, false, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Bingo));
				break;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_207(scenario_0, true, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker10Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_207(scenario_0, false, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker10Percent));
				break;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_207(scenario_0, true, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker20Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_207(scenario_0, false, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker20Percent));
				break;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_207(scenario_0, true, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker25Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_207(scenario_0, false, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker25Percent));
				break;
			case 4:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_207(scenario_0, true, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker30Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_207(scenario_0, false, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker30Percent));
				break;
			case 5:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit6 in this.list_0)
						{
							activeUnit6.doctrine_0.method_207(scenario_0, true, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker40Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
				}
				this.method_207(scenario_0, false, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker40Percent));
				break;
			case 6:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit7 in this.list_0)
						{
							activeUnit7.doctrine_0.method_207(scenario_0, true, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker50Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator7;
						((IDisposable)enumerator7).Dispose();
					}
				}
				this.method_207(scenario_0, false, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker50Percent));
				break;
			case 7:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit8 in this.list_0)
						{
							activeUnit8.doctrine_0.method_207(scenario_0, true, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker60Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator8;
						((IDisposable)enumerator8).Dispose();
					}
				}
				this.method_207(scenario_0, false, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker60Percent));
				break;
			case 8:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit9 in this.list_0)
						{
							activeUnit9.doctrine_0.method_207(scenario_0, true, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker70Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator9;
						((IDisposable)enumerator9).Dispose();
					}
				}
				this.method_207(scenario_0, false, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker70Percent));
				break;
			case 9:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit10 in this.list_0)
						{
							activeUnit10.doctrine_0.method_207(scenario_0, true, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker75Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator10;
						((IDisposable)enumerator10).Dispose();
					}
				}
				this.method_207(scenario_0, false, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker75Percent));
				break;
			case 10:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit11 in this.list_0)
						{
							activeUnit11.doctrine_0.method_207(scenario_0, true, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker80Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator11;
						((IDisposable)enumerator11).Dispose();
					}
				}
				this.method_207(scenario_0, false, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker80Percent));
				break;
			case 11:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit12 in this.list_0)
						{
							activeUnit12.doctrine_0.method_207(scenario_0, true, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker90Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator12;
						((IDisposable)enumerator12).Dispose();
					}
				}
				this.method_207(scenario_0, false, bool_35, bool_37, bool_38, new Doctrine._FuelState?(Doctrine._FuelState.Joker90Percent));
				break;
			case 12:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit13 in this.list_0)
						{
							activeUnit13.doctrine_0.method_207(scenario_0, false, bool_35, bool_37, bool_38, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator13;
						((IDisposable)enumerator13).Dispose();
					}
				}
				this.method_207(scenario_0, false, bool_35, bool_37, bool_38, null);
				break;
			}
			if (this.class310_0.GetType() == typeof(Side))
			{
				try
				{
					foreach (ActiveUnit activeUnit14 in scenario_0.method_42())
					{
						if (!Information.IsNothing(activeUnit14))
						{
							activeUnit14.vmethod_87().vmethod_7();
						}
					}
					return;
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator14;
					((IDisposable)enumerator14).Dispose();
				}
			}
			try
			{
				foreach (ActiveUnit activeUnit15 in this.method_5(scenario_0, new bool?(bool_36)))
				{
					activeUnit15.vmethod_87().vmethod_7();
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator15;
				((IDisposable)enumerator15).Dispose();
			}
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x0014ED64 File Offset: 0x0014CF64
		public void method_333(ComboBox comboBox_0, ref Scenario scenario_0, ref bool bool_35, Doctrine._WeaponState? nullable_42)
		{
			Doctrine._WeaponState? weaponState = this.method_211(scenario_0, false, bool_35, false, false);
			DataTable dataSource = new DataTable();
			this.method_60(ref dataSource, scenario_0, bool_35, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_213())
			{
				comboBox_0.SelectedIndex = 20;
			}
			else
			{
				Doctrine._WeaponState? weaponState2 = weaponState;
				int? num = (weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 2001) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2002) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3001) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3002) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
								else
								{
									num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 3003) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 5;
									}
									else
									{
										num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 5001) : null).GetValueOrDefault())
										{
											comboBox_0.SelectedIndex = 6;
										}
										else
										{
											num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 5002) : null).GetValueOrDefault())
											{
												comboBox_0.SelectedIndex = 7;
											}
											else
											{
												num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
												if (((num != null) ? new bool?(num.GetValueOrDefault() == 5003) : null).GetValueOrDefault())
												{
													comboBox_0.SelectedIndex = 8;
												}
												else
												{
													num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
													if (((num != null) ? new bool?(num.GetValueOrDefault() == 5005) : null).GetValueOrDefault())
													{
														comboBox_0.SelectedIndex = 9;
													}
													else
													{
														num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
														if (((num != null) ? new bool?(num.GetValueOrDefault() == 5006) : null).GetValueOrDefault())
														{
															comboBox_0.SelectedIndex = 10;
														}
														else
														{
															num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
															if (((num != null) ? new bool?(num.GetValueOrDefault() == 5011) : null).GetValueOrDefault())
															{
																comboBox_0.SelectedIndex = 11;
															}
															else
															{
																num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
																if (((num != null) ? new bool?(num.GetValueOrDefault() == 5012) : null).GetValueOrDefault())
																{
																	comboBox_0.SelectedIndex = 12;
																}
																else
																{
																	num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
																	if (((num != null) ? new bool?(num.GetValueOrDefault() == 5021) : null).GetValueOrDefault())
																	{
																		comboBox_0.SelectedIndex = 13;
																	}
																	else
																	{
																		num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
																		if (((num != null) ? new bool?(num.GetValueOrDefault() == 4001) : null).GetValueOrDefault())
																		{
																			comboBox_0.SelectedIndex = 14;
																		}
																		else
																		{
																			num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
																			if (((num != null) ? new bool?(num.GetValueOrDefault() == 4002) : null).GetValueOrDefault())
																			{
																				comboBox_0.SelectedIndex = 15;
																			}
																			else
																			{
																				num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
																				if (((num != null) ? new bool?(num.GetValueOrDefault() == 4011) : null).GetValueOrDefault())
																				{
																					comboBox_0.SelectedIndex = 16;
																				}
																				else
																				{
																					num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
																					if (((num != null) ? new bool?(num.GetValueOrDefault() == 4012) : null).GetValueOrDefault())
																					{
																						comboBox_0.SelectedIndex = 17;
																					}
																					else
																					{
																						num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
																						if (((num != null) ? new bool?(num.GetValueOrDefault() == 4021) : null).GetValueOrDefault())
																						{
																							comboBox_0.SelectedIndex = 18;
																						}
																						else
																						{
																							num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
																							if (((num != null) ? new bool?(num.GetValueOrDefault() == 4022) : null).GetValueOrDefault())
																							{
																								comboBox_0.SelectedIndex = 19;
																							}
																							else
																							{
																								num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
																								if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
																								{
																									comboBox_0.SelectedIndex = 21;
																								}
																								else
																								{
																									num = ((weaponState2 != null) ? new int?((int)weaponState2.GetValueOrDefault()) : null);
																									if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
																									{
																										comboBox_0.SelectedIndex = 21;
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x0014F630 File Offset: 0x0014D830
		public void method_334(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, ref bool bool_35, bool bool_36, bool bool_37)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.LoadoutSetting));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.LoadoutSetting));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Winchester));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Winchester));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Winchester_ToO));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Winchester_ToO));
				return;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunBVR));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunBVR));
				return;
			case 4:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunBVR_WVR));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunBVR_WVR));
				return;
			case 5:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit6 in this.list_0)
						{
							activeUnit6.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunBVR_WVR_Guns));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunBVR_WVR_Guns));
				return;
			case 6:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit7 in this.list_0)
						{
							activeUnit7.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator7;
						((IDisposable)enumerator7).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR));
				return;
			case 7:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit8 in this.list_0)
						{
							activeUnit8.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_Opportunity_WVR));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator8;
						((IDisposable)enumerator8).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_Opportunity_WVR));
				return;
			case 8:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit9 in this.list_0)
						{
							activeUnit9.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_Opportunity_WVR_Guns));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator9;
						((IDisposable)enumerator9).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_Opportunity_WVR_Guns));
				return;
			case 9:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit10 in this.list_0)
						{
							activeUnit10.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_And_WVR));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator10;
						((IDisposable)enumerator10).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_And_WVR));
				return;
			case 10:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit11 in this.list_0)
						{
							activeUnit11.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_And_WVR_Opportunity_Guns));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator11;
						((IDisposable)enumerator11).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementBVR_And_WVR_Opportunity_Guns));
				return;
			case 11:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit12 in this.list_0)
						{
							activeUnit12.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementWVR));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator12;
						((IDisposable)enumerator12).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementWVR));
				return;
			case 12:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit13 in this.list_0)
						{
							activeUnit13.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementWVR_Guns));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator13;
						((IDisposable)enumerator13).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementWVR_Guns));
				return;
			case 13:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit14 in this.list_0)
						{
							activeUnit14.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementGun));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator14;
						((IDisposable)enumerator14).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.ShotgunOneEngagementGun));
				return;
			case 14:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit15 in this.list_0)
						{
							activeUnit15.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun25));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator15;
						((IDisposable)enumerator15).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun25));
				return;
			case 15:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit16 in this.list_0)
						{
							activeUnit16.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun25_ToO));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator16;
						((IDisposable)enumerator16).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun25_ToO));
				return;
			case 16:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit17 in this.list_0)
						{
							activeUnit17.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun50));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator17;
						((IDisposable)enumerator17).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun50));
				return;
			case 17:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit18 in this.list_0)
						{
							activeUnit18.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun50_ToO));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator18;
						((IDisposable)enumerator18).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun50_ToO));
				return;
			case 18:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit19 in this.list_0)
						{
							activeUnit19.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun75));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator19;
						((IDisposable)enumerator19).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun75));
				return;
			case 19:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit20 in this.list_0)
						{
							activeUnit20.doctrine_0.method_212(scenario_0, true, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun75_ToO));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator20;
						((IDisposable)enumerator20).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, new Doctrine._WeaponState?(Doctrine._WeaponState.Shotgun75_ToO));
				return;
			case 20:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit21 in this.list_0)
						{
							activeUnit21.doctrine_0.method_212(scenario_0, false, bool_35, bool_36, bool_37, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator21;
						((IDisposable)enumerator21).Dispose();
					}
				}
				this.method_212(scenario_0, false, bool_35, bool_36, bool_37, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00150254 File Offset: 0x0014E454
		public void method_335(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine.Enum55? nullable_42)
		{
			Doctrine.Enum55? @enum = this.method_216(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_62(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_218())
			{
				comboBox_0.SelectedIndex = 3;
			}
			else
			{
				Doctrine.Enum55? enum2 = @enum;
				byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 4;
							}
							else
							{
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00150484 File Offset: 0x0014E684
		public void method_336(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_217(scenario_0, true, bool_35, bool_36, new Doctrine.Enum55?(Doctrine.Enum55.const_0));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_217(scenario_0, false, bool_35, bool_36, new Doctrine.Enum55?(Doctrine.Enum55.const_0));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_217(scenario_0, true, bool_35, bool_36, new Doctrine.Enum55?(Doctrine.Enum55.const_1));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_217(scenario_0, false, bool_35, bool_36, new Doctrine.Enum55?(Doctrine.Enum55.const_1));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_217(scenario_0, true, bool_35, bool_36, new Doctrine.Enum55?(Doctrine.Enum55.const_2));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_217(scenario_0, false, bool_35, bool_36, new Doctrine.Enum55?(Doctrine.Enum55.const_2));
				return;
			case 3:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_217(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_217(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x001506B0 File Offset: 0x0014E8B0
		public void method_337(ComboBox comboBox_0, ref Scenario scenario_0, ref Doctrine doctrine_1)
		{
			comboBox_0.Items.Clear();
			comboBox_0.Items.Add("Passive");
			comboBox_0.Items.Add("Active");
			if (!Information.IsNothing(this.list_0) && this.list_0.Count > 1 && !doctrine_1.method_7() && this.class275_0.method_1() == Doctrine.Class275.Enum66.const_2)
			{
				comboBox_0.Items.Add("Various");
			}
			if (!doctrine_1.method_7() && this.class310_0.GetType() == typeof(Waypoint))
			{
				comboBox_0.Items.Add("Not configured");
			}
			if (doctrine_1.method_6(scenario_0).method_1() == Doctrine.Class275.Enum66.const_0)
			{
				comboBox_0.SelectedIndex = 0;
			}
			else if (doctrine_1.method_6(scenario_0).method_1() == Doctrine.Class275.Enum66.const_1)
			{
				comboBox_0.SelectedIndex = 1;
			}
			else if (doctrine_1.method_6(scenario_0).method_1() == Doctrine.Class275.Enum66.const_3)
			{
				comboBox_0.SelectedIndex = 2;
			}
			comboBox_0.Enabled = !doctrine_1.method_7();
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x001507BC File Offset: 0x0014E9BC
		public void method_338(ComboBox comboBox_0, ref Scenario scenario_0, ref Doctrine doctrine_1)
		{
			comboBox_0.Items.Clear();
			comboBox_0.Items.Add("Passive");
			comboBox_0.Items.Add("Active");
			if (!Information.IsNothing(this.list_0) && this.list_0.Count > 1 && !doctrine_1.method_7() && this.class275_0.method_3() == Doctrine.Class275.Enum66.const_2)
			{
				comboBox_0.Items.Add("Various");
			}
			if (!doctrine_1.method_7() && this.class310_0.GetType() == typeof(Waypoint))
			{
				comboBox_0.Items.Add("Not configured");
			}
			if (doctrine_1.method_6(scenario_0).method_3() == Doctrine.Class275.Enum66.const_0)
			{
				comboBox_0.SelectedIndex = 0;
			}
			else if (doctrine_1.method_6(scenario_0).method_3() == Doctrine.Class275.Enum66.const_1)
			{
				comboBox_0.SelectedIndex = 1;
			}
			else if (doctrine_1.method_6(scenario_0).method_3() == Doctrine.Class275.Enum66.const_3)
			{
				comboBox_0.SelectedIndex = 2;
			}
			comboBox_0.Enabled = !doctrine_1.method_7();
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x001508C8 File Offset: 0x0014EAC8
		public void method_339(ComboBox comboBox_0, ref Scenario scenario_0, ref Doctrine doctrine_1)
		{
			comboBox_0.Items.Clear();
			comboBox_0.Items.Add("Passive");
			comboBox_0.Items.Add("Active");
			if (!Information.IsNothing(this.list_0) && this.list_0.Count > 1 && !doctrine_1.method_7() && this.class275_0.method_2() == Doctrine.Class275.Enum66.const_2)
			{
				comboBox_0.Items.Add("Various");
			}
			if (!doctrine_1.method_7() && this.class310_0.GetType() == typeof(Waypoint))
			{
				comboBox_0.Items.Add("Not configured");
			}
			if (doctrine_1.method_6(scenario_0).method_2() == Doctrine.Class275.Enum66.const_0)
			{
				comboBox_0.SelectedIndex = 0;
			}
			else if (doctrine_1.method_6(scenario_0).method_2() == Doctrine.Class275.Enum66.const_1)
			{
				comboBox_0.SelectedIndex = 1;
			}
			else if (doctrine_1.method_6(scenario_0).method_2() == Doctrine.Class275.Enum66.const_3)
			{
				comboBox_0.SelectedIndex = 2;
			}
			comboBox_0.Enabled = !doctrine_1.method_7();
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0000A31E File Offset: 0x0000851E
		public void method_340(CheckBox checkBox_0, ref Class310 class310_1, ref Doctrine doctrine_1)
		{
			if (!Information.IsNothing(class310_1))
			{
				checkBox_0.Enabled = (class310_1.GetType() != typeof(Side));
			}
			else
			{
				checkBox_0.Enabled = true;
			}
			checkBox_0.Checked = doctrine_1.method_7();
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x001509D4 File Offset: 0x0014EBD4
		public void method_341(CheckBox checkBox_0, ComboBox comboBox_0, ComboBox comboBox_1, ComboBox comboBox_2, ref Doctrine doctrine_1, Scenario scenario_0, bool bool_35, bool bool_36)
		{
			Doctrine.Class275.Enum66 enum66_;
			if (doctrine_1.method_6(scenario_0).method_1() == Doctrine.Class275.Enum66.const_1)
			{
				enum66_ = Doctrine.Class275.Enum66.const_1;
			}
			else if (doctrine_1.method_6(scenario_0).method_1() == Doctrine.Class275.Enum66.const_4)
			{
				enum66_ = Doctrine.Class275.Enum66.const_4;
			}
			Doctrine.Class275.Enum66 enum66_2;
			if (doctrine_1.method_6(scenario_0).method_2() == Doctrine.Class275.Enum66.const_1)
			{
				enum66_2 = Doctrine.Class275.Enum66.const_1;
			}
			else if (doctrine_1.method_6(scenario_0).method_2() == Doctrine.Class275.Enum66.const_4)
			{
				enum66_2 = Doctrine.Class275.Enum66.const_4;
			}
			Doctrine.Class275.Enum66 enum66_3;
			if (doctrine_1.method_6(scenario_0).method_3() == Doctrine.Class275.Enum66.const_1)
			{
				enum66_3 = Doctrine.Class275.Enum66.const_1;
			}
			else if (doctrine_1.method_6(scenario_0).method_3() == Doctrine.Class275.Enum66.const_4)
			{
				enum66_3 = Doctrine.Class275.Enum66.const_4;
			}
			doctrine_1.method_8(checkBox_0.Checked);
			comboBox_0.Enabled = !doctrine_1.method_7();
			comboBox_1.Enabled = !doctrine_1.method_7();
			comboBox_2.Enabled = !doctrine_1.method_7();
			if (!doctrine_1.bool_34)
			{
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_8(checkBox_0.Checked);
							if (!activeUnit.doctrine_0.method_7())
							{
								activeUnit.doctrine_0.method_192(enum66_, scenario_0);
								activeUnit.doctrine_0.method_193(enum66_2, scenario_0);
								activeUnit.doctrine_0.method_194(enum66_3, scenario_0);
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (!doctrine_1.method_7())
				{
					doctrine_1.method_192(enum66_, scenario_0);
					doctrine_1.method_193(enum66_2, scenario_0);
					doctrine_1.method_194(enum66_3, scenario_0);
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (Unit unit in this.list_0)
						{
							((ActiveUnit)unit).doctrine_0.method_2(unit, new bool?(false), true, bool_35, bool_36, false);
						}
						return;
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				doctrine_1.method_2(this.class310_0, new bool?(false), false, bool_35, bool_36, false);
			}
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00150BF8 File Offset: 0x0014EDF8
		public void method_342(ref Side side_0, ref Scenario scenario_0, ref bool bool_35)
		{
			if (this.class310_0.GetType() == typeof(Side))
			{
				foreach (ActiveUnit activeUnit in side_0.activeUnit_0)
				{
					activeUnit.vmethod_88().vmethod_5(activeUnit.method_78());
				}
				return;
			}
			try
			{
				foreach (ActiveUnit activeUnit2 in this.method_5(scenario_0, new bool?(bool_35)))
				{
					activeUnit2.vmethod_88().vmethod_5(activeUnit2.method_78());
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00150CA8 File Offset: 0x0014EEA8
		public void method_343(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._RefuelAlliedUnits? nullable_42)
		{
			Doctrine._RefuelAlliedUnits? refuelAlliedUnits = this.method_240(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_245(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_242())
			{
				comboBox_0.SelectedIndex = 4;
			}
			else
			{
				Doctrine._RefuelAlliedUnits? refuelAlliedUnits2 = refuelAlliedUnits;
				byte? b = (refuelAlliedUnits2 != null) ? new byte?((byte)refuelAlliedUnits2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((refuelAlliedUnits2 != null) ? new byte?((byte)refuelAlliedUnits2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((refuelAlliedUnits2 != null) ? new byte?((byte)refuelAlliedUnits2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((refuelAlliedUnits2 != null) ? new byte?((byte)refuelAlliedUnits2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								b = ((refuelAlliedUnits2 != null) ? new byte?((byte)refuelAlliedUnits2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 5;
								}
								else
								{
									b = ((refuelAlliedUnits2 != null) ? new byte?((byte)refuelAlliedUnits2.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 5;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00150F38 File Offset: 0x0014F138
		public void method_344(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_241(scenario_0, true, bool_35, bool_36, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Yes));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_241(scenario_0, false, bool_35, bool_36, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Yes));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_241(scenario_0, true, bool_35, bool_36, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Yes_ReceiveOnly));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_241(scenario_0, false, bool_35, bool_36, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Yes_ReceiveOnly));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_241(scenario_0, true, bool_35, bool_36, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Yes_DeliverOnly));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_241(scenario_0, false, bool_35, bool_36, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.Yes_DeliverOnly));
				return;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_241(scenario_0, true, bool_35, bool_36, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.No));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_241(scenario_0, false, bool_35, bool_36, new Doctrine._RefuelAlliedUnits?(Doctrine._RefuelAlliedUnits.No));
				return;
			case 4:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_241(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_241(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x001511D8 File Offset: 0x0014F3D8
		public void method_345(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._AvoidContactWhenPossible? nullable_42)
		{
			Doctrine._AvoidContactWhenPossible? avoidContactWhenPossible = this.method_246(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_251(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_248())
			{
				comboBox_0.SelectedIndex = 3;
			}
			else
			{
				Doctrine._AvoidContactWhenPossible? avoidContactWhenPossible2 = avoidContactWhenPossible;
				byte? b = (avoidContactWhenPossible2 != null) ? new byte?((byte)avoidContactWhenPossible2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((avoidContactWhenPossible2 != null) ? new byte?((byte)avoidContactWhenPossible2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((avoidContactWhenPossible2 != null) ? new byte?((byte)avoidContactWhenPossible2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((avoidContactWhenPossible2 != null) ? new byte?((byte)avoidContactWhenPossible2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 4;
							}
							else
							{
								b = ((avoidContactWhenPossible2 != null) ? new byte?((byte)avoidContactWhenPossible2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00151408 File Offset: 0x0014F608
		public void method_346(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_247(scenario_0, true, bool_35, bool_36, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.No));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_247(scenario_0, false, bool_35, bool_36, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.No));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_247(scenario_0, true, bool_35, bool_36, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Yes_Always));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_247(scenario_0, false, bool_35, bool_36, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Yes_Always));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_247(scenario_0, true, bool_35, bool_36, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Yes_ExceptSelfDefence));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_247(scenario_0, false, bool_35, bool_36, new Doctrine._AvoidContactWhenPossible?(Doctrine._AvoidContactWhenPossible.Yes_ExceptSelfDefence));
				return;
			case 3:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_247(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_247(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00151634 File Offset: 0x0014F834
		public void method_347(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._DiveOnContact? nullable_42)
		{
			Doctrine._DiveOnContact? diveOnContact = this.method_252(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_257(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_254())
			{
				comboBox_0.SelectedIndex = 4;
			}
			else
			{
				Doctrine._DiveOnContact? diveOnContact2 = diveOnContact;
				byte? b = (diveOnContact2 != null) ? new byte?((byte)diveOnContact2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((diveOnContact2 != null) ? new byte?((byte)diveOnContact2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((diveOnContact2 != null) ? new byte?((byte)diveOnContact2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((diveOnContact2 != null) ? new byte?((byte)diveOnContact2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								b = ((diveOnContact2 != null) ? new byte?((byte)diveOnContact2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 5;
								}
								else
								{
									b = ((diveOnContact2 != null) ? new byte?((byte)diveOnContact2.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 5;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x001518C4 File Offset: 0x0014FAC4
		public void method_348(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_253(scenario_0, true, bool_35, bool_36, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_253(scenario_0, false, bool_35, bool_36, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_253(scenario_0, true, bool_35, bool_36, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes_ESM_Only));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_253(scenario_0, false, bool_35, bool_36, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes_ESM_Only));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_253(scenario_0, true, bool_35, bool_36, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes_Ships20nm_Aircraft30nm));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_253(scenario_0, false, bool_35, bool_36, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.Yes_Ships20nm_Aircraft30nm));
				return;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_253(scenario_0, true, bool_35, bool_36, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.No));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_253(scenario_0, false, bool_35, bool_36, new Doctrine._DiveOnContact?(Doctrine._DiveOnContact.No));
				return;
			case 4:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_253(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_253(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00151B64 File Offset: 0x0014FD64
		public void method_349(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._RechargeBatteryPercentage? nullable_42)
		{
			Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage = this.method_258(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_263(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_260())
			{
				comboBox_0.SelectedIndex = 10;
			}
			else
			{
				Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage2 = rechargeBatteryPercentage;
				int? num = (rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 10) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 20) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 30) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 40) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
								else
								{
									num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 50) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 5;
									}
									else
									{
										num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 60) : null).GetValueOrDefault())
										{
											comboBox_0.SelectedIndex = 6;
										}
										else
										{
											num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 70) : null).GetValueOrDefault())
											{
												comboBox_0.SelectedIndex = 7;
											}
											else
											{
												num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
												if (((num != null) ? new bool?(num.GetValueOrDefault() == 80) : null).GetValueOrDefault())
												{
													comboBox_0.SelectedIndex = 8;
												}
												else
												{
													num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
													if (((num != null) ? new bool?(num.GetValueOrDefault() == 90) : null).GetValueOrDefault())
													{
														comboBox_0.SelectedIndex = 9;
													}
													else
													{
														num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
														if (((num != null) ? new bool?(num.GetValueOrDefault() == -100) : null).GetValueOrDefault())
														{
															comboBox_0.SelectedIndex = 11;
														}
														else
														{
															num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
															if (((num != null) ? new bool?(num.GetValueOrDefault() == -101) : null).GetValueOrDefault())
															{
																comboBox_0.SelectedIndex = 11;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00152034 File Offset: 0x00150234
		public void method_350(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_259(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_Empty));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_259(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_Empty));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_259(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_10_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_259(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_10_Percent));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_259(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_20_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_259(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_20_Percent));
				return;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_259(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_30_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_259(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_30_Percent));
				return;
			case 4:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_259(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_40_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_259(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_40_Percent));
				return;
			case 5:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit6 in this.list_0)
						{
							activeUnit6.doctrine_0.method_259(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_50_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
				}
				this.method_259(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_50_Percent));
				return;
			case 6:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit7 in this.list_0)
						{
							activeUnit7.doctrine_0.method_259(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_60_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator7;
						((IDisposable)enumerator7).Dispose();
					}
				}
				this.method_259(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_60_Percent));
				return;
			case 7:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit8 in this.list_0)
						{
							activeUnit8.doctrine_0.method_259(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_70_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator8;
						((IDisposable)enumerator8).Dispose();
					}
				}
				this.method_259(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_70_Percent));
				return;
			case 8:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit9 in this.list_0)
						{
							activeUnit9.doctrine_0.method_259(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_80_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator9;
						((IDisposable)enumerator9).Dispose();
					}
				}
				this.method_259(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_80_Percent));
				return;
			case 9:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit10 in this.list_0)
						{
							activeUnit10.doctrine_0.method_259(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_90_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator10;
						((IDisposable)enumerator10).Dispose();
					}
				}
				this.method_259(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_90_Percent));
				return;
			case 10:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit11 in this.list_0)
						{
							activeUnit11.doctrine_0.method_259(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator11;
						((IDisposable)enumerator11).Dispose();
					}
				}
				this.method_259(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x001525B0 File Offset: 0x001507B0
		public void method_351(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._RechargeBatteryPercentage? nullable_42)
		{
			Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage = this.method_264(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_269(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_266())
			{
				comboBox_0.SelectedIndex = 10;
			}
			else
			{
				Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage2 = rechargeBatteryPercentage;
				int? num = (rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 10) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 20) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 30) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 40) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
								else
								{
									num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 50) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 5;
									}
									else
									{
										num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 60) : null).GetValueOrDefault())
										{
											comboBox_0.SelectedIndex = 6;
										}
										else
										{
											num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 70) : null).GetValueOrDefault())
											{
												comboBox_0.SelectedIndex = 7;
											}
											else
											{
												num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
												if (((num != null) ? new bool?(num.GetValueOrDefault() == 80) : null).GetValueOrDefault())
												{
													comboBox_0.SelectedIndex = 8;
												}
												else
												{
													num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
													if (((num != null) ? new bool?(num.GetValueOrDefault() == 90) : null).GetValueOrDefault())
													{
														comboBox_0.SelectedIndex = 9;
													}
													else
													{
														num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
														if (((num != null) ? new bool?(num.GetValueOrDefault() == -100) : null).GetValueOrDefault())
														{
															comboBox_0.SelectedIndex = 11;
														}
														else
														{
															num = ((rechargeBatteryPercentage2 != null) ? new int?((int)rechargeBatteryPercentage2.GetValueOrDefault()) : null);
															if (((num != null) ? new bool?(num.GetValueOrDefault() == -101) : null).GetValueOrDefault())
															{
																comboBox_0.SelectedIndex = 11;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00152A80 File Offset: 0x00150C80
		public void method_352(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_265(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_Empty));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_265(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_Empty));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_265(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_10_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_265(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_10_Percent));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_265(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_20_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_265(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_20_Percent));
				return;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_265(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_30_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_265(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_30_Percent));
				return;
			case 4:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_265(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_40_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_265(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_40_Percent));
				return;
			case 5:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit6 in this.list_0)
						{
							activeUnit6.doctrine_0.method_265(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_50_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
				}
				this.method_265(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_50_Percent));
				return;
			case 6:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit7 in this.list_0)
						{
							activeUnit7.doctrine_0.method_265(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_60_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator7;
						((IDisposable)enumerator7).Dispose();
					}
				}
				this.method_265(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_60_Percent));
				return;
			case 7:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit8 in this.list_0)
						{
							activeUnit8.doctrine_0.method_265(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_70_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator8;
						((IDisposable)enumerator8).Dispose();
					}
				}
				this.method_265(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_70_Percent));
				return;
			case 8:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit9 in this.list_0)
						{
							activeUnit9.doctrine_0.method_265(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_80_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator9;
						((IDisposable)enumerator9).Dispose();
					}
				}
				this.method_265(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_80_Percent));
				return;
			case 9:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit10 in this.list_0)
						{
							activeUnit10.doctrine_0.method_265(scenario_0, true, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_90_Percent));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator10;
						((IDisposable)enumerator10).Dispose();
					}
				}
				this.method_265(scenario_0, false, bool_35, bool_36, new Doctrine._RechargeBatteryPercentage?(Doctrine._RechargeBatteryPercentage.Recharge_90_Percent));
				return;
			case 10:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit11 in this.list_0)
						{
							activeUnit11.doctrine_0.method_265(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator11;
						((IDisposable)enumerator11).Dispose();
					}
				}
				this.method_265(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00152FFC File Offset: 0x001511FC
		public void method_353(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._UseAIP? nullable_42)
		{
			Doctrine._UseAIP? useAIP = this.method_270(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_275(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_272())
			{
				comboBox_0.SelectedIndex = 3;
			}
			else
			{
				Doctrine._UseAIP? useAIP2 = useAIP;
				byte? b = (useAIP2 != null) ? new byte?((byte)useAIP2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((useAIP2 != null) ? new byte?((byte)useAIP2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((useAIP2 != null) ? new byte?((byte)useAIP2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							b = ((useAIP2 != null) ? new byte?((byte)useAIP2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 4;
							}
							else
							{
								b = ((useAIP2 != null) ? new byte?((byte)useAIP2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0015322C File Offset: 0x0015142C
		public void method_354(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_271(scenario_0, true, bool_35, bool_36, new Doctrine._UseAIP?(Doctrine._UseAIP.Yes_Always));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_271(scenario_0, false, bool_35, bool_36, new Doctrine._UseAIP?(Doctrine._UseAIP.Yes_Always));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_271(scenario_0, true, bool_35, bool_36, new Doctrine._UseAIP?(Doctrine._UseAIP.Yes_AttackOnly));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_271(scenario_0, false, bool_35, bool_36, new Doctrine._UseAIP?(Doctrine._UseAIP.Yes_AttackOnly));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_271(scenario_0, true, bool_35, bool_36, new Doctrine._UseAIP?(Doctrine._UseAIP.No));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_271(scenario_0, false, bool_35, bool_36, new Doctrine._UseAIP?(Doctrine._UseAIP.No));
				return;
			case 3:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_271(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_271(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00153458 File Offset: 0x00151658
		public void method_355(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._UseDippingSonar? nullable_42)
		{
			Doctrine._UseDippingSonar? useDippingSonar = this.method_276(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_281(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_278())
			{
				comboBox_0.SelectedIndex = 2;
			}
			else
			{
				Doctrine._UseDippingSonar? useDippingSonar2 = useDippingSonar;
				byte? b = (useDippingSonar2 != null) ? new byte?((byte)useDippingSonar2.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					b = ((useDippingSonar2 != null) ? new byte?((byte)useDippingSonar2.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						b = ((useDippingSonar2 != null) ? new byte?((byte)useDippingSonar2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 3;
						}
						else
						{
							b = ((useDippingSonar2 != null) ? new byte?((byte)useDippingSonar2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x0015362C File Offset: 0x0015182C
		public void method_356(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_277(scenario_0, true, bool_35, bool_36, new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Automatically_HoverAnd150ft));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_277(scenario_0, false, bool_35, bool_36, new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.Automatically_HoverAnd150ft));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_277(scenario_0, true, bool_35, bool_36, new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.ManualAndMissionOnly));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_277(scenario_0, false, bool_35, bool_36, new Doctrine._UseDippingSonar?(Doctrine._UseDippingSonar.ManualAndMissionOnly));
				return;
			case 2:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_277(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_277(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x001537E0 File Offset: 0x001519E0
		public void method_357(ref Scenario scenario_0, ref Side side_0)
		{
			foreach (Side side in scenario_0.method_44())
			{
				if (side == side_0 || side.method_67(side_0))
				{
					try
					{
						foreach (Mission mission in side.method_35())
						{
							mission.int_0 = 0;
						}
					}
					finally
					{
						IEnumerator<Mission> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00153858 File Offset: 0x00151A58
		public static void smethod_10(ref ActiveUnit activeUnit_0, ref Doctrine doctrine_1, Scenario scenario_0)
		{
			if (!Information.IsNothing(doctrine_1.method_31(scenario_0, false, false, false)))
			{
				doctrine_1.method_32(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_63(scenario_0, false, new bool?(false), false, false)))
			{
				doctrine_1.method_64(scenario_0, false, new bool?(false), true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_68(scenario_0, false, new bool?(false), false, false)))
			{
				doctrine_1.method_69(scenario_0, false, new bool?(false), true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_73(scenario_0, false, new bool?(false), false, false)))
			{
				doctrine_1.method_74(scenario_0, false, new bool?(false), true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_78(scenario_0, false, new bool?(false), false, false)))
			{
				doctrine_1.method_79(scenario_0, false, new bool?(false), true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_83(scenario_0, false, new bool?(false), false, false)))
			{
				doctrine_1.method_84(scenario_0, false, new bool?(false), true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_211(scenario_0, false, false, false, false)))
			{
				doctrine_1.method_212(scenario_0, false, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_117(scenario_0, false, false, false)))
			{
				doctrine_1.method_118(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_206(scenario_0, false, false, false, false)))
			{
				doctrine_1.method_207(scenario_0, false, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_122(scenario_0, false, false, false)))
			{
				doctrine_1.method_123(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_127(scenario_0, false, false, false)))
			{
				doctrine_1.method_128(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_88(scenario_0, false, false, false)))
			{
				doctrine_1.method_89(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_137(scenario_0, false, false, false)))
			{
				doctrine_1.method_138(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_147(scenario_0, false, false, false)))
			{
				doctrine_1.method_148(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_142(scenario_0, false, false, false)))
			{
				doctrine_1.method_143(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_152(scenario_0, false, false, false, false)))
			{
				doctrine_1.method_153(scenario_0, false, true, true, false, null);
			}
			if (!Information.IsNothing(doctrine_1.method_157(scenario_0, false, false, false, false)))
			{
				doctrine_1.method_158(scenario_0, false, true, true, false, null);
			}
			if (!Information.IsNothing(doctrine_1.method_162(scenario_0, false, false, false)))
			{
				doctrine_1.method_163(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_167(scenario_0, false, false, false)))
			{
				doctrine_1.method_168(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_172(scenario_0, false, false, false)))
			{
				doctrine_1.method_173(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_216(scenario_0, false, false, false)))
			{
				doctrine_1.method_217(scenario_0, false, true, true, null);
			}
			if (Information.IsNothing(activeUnit_0))
			{
				if (!Information.IsNothing(doctrine_1.method_196(scenario_0, false, false, false, false)))
				{
					doctrine_1.method_197(scenario_0, false, false, true, true, null);
				}
				if (!Information.IsNothing(doctrine_1.method_201(scenario_0, false, false, false, false)))
				{
					doctrine_1.method_202(scenario_0, false, false, true, true, null);
				}
			}
			else
			{
				if (!Information.IsNothing(doctrine_1.method_196(scenario_0, false, activeUnit_0.vmethod_127(), false, false)))
				{
					doctrine_1.method_197(scenario_0, false, activeUnit_0.vmethod_127(), true, true, null);
				}
				if (!Information.IsNothing(doctrine_1.method_201(scenario_0, false, activeUnit_0.vmethod_127(), false, false)))
				{
					doctrine_1.method_202(scenario_0, false, activeUnit_0.vmethod_127(), true, true, null);
				}
			}
			if (!Information.IsNothing(activeUnit_0) && activeUnit_0.bool_3)
			{
				activeUnit_0.vmethod_87().vmethod_7();
			}
			if (!Information.IsNothing(doctrine_1.method_240(scenario_0, false, false, false)))
			{
				doctrine_1.method_241(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_246(scenario_0, false, false, false)))
			{
				doctrine_1.method_247(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_252(scenario_0, false, false, false)))
			{
				doctrine_1.method_253(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_258(scenario_0, false, false, false)))
			{
				doctrine_1.method_259(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_264(scenario_0, false, false, false)))
			{
				doctrine_1.method_265(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_270(scenario_0, false, false, false)))
			{
				doctrine_1.method_271(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_276(scenario_0, false, false, false)))
			{
				doctrine_1.method_277(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_93(scenario_0, false, false, false)))
			{
				doctrine_1.method_94(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_96(scenario_0, false, false, false)))
			{
				doctrine_1.method_97(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_99(scenario_0, false, false, false)))
			{
				doctrine_1.method_100(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_102(scenario_0, false, false, false)))
			{
				doctrine_1.method_103(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_105(scenario_0, false, false, false)))
			{
				doctrine_1.method_106(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_108(scenario_0, false, false, false)))
			{
				doctrine_1.method_109(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_111(scenario_0, false, false, false)))
			{
				doctrine_1.method_112(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_114(scenario_0, false, false, false)))
			{
				doctrine_1.method_115(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_177(scenario_0, false, false, false)))
			{
				doctrine_1.method_178(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_182(scenario_0, false, false, false)))
			{
				doctrine_1.method_183(scenario_0, false, true, true, null);
			}
			if (!Information.IsNothing(doctrine_1.method_187(scenario_0, false, false, false)))
			{
				doctrine_1.method_188(scenario_0, false, true, true, null);
			}
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00154054 File Offset: 0x00152254
		private void method_358(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._DamageThreshold? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Ignore Damage";
			string text2 = "5%";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_42))
				{
					num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, " + text5
										});
									}
									else
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, Various"
										});
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._DamageThreshold? damageThreshold = this.method_3(scenario_0, ref flag).method_93(scenario_0, false, false, false);
					num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, " + text5
										});
									}
								}
							}
						}
					}
				}
				Doctrine._DamageThreshold? damageThreshold2 = this.method_93(scenario_0, false, false, false);
				num = ((damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x001547AC File Offset: 0x001529AC
		private void method_359(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._FuelQuantityThreshold? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Ignore Fuel";
			string text2 = "Bingo";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_42))
				{
					num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, " + text5
										});
									}
									else
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, Various"
										});
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._FuelQuantityThreshold? fuelQuantityThreshold = this.method_3(scenario_0, ref flag).method_96(scenario_0, false, false, false);
					num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, " + text5
										});
									}
								}
							}
						}
					}
				}
				Doctrine._FuelQuantityThreshold? fuelQuantityThreshold2 = this.method_96(scenario_0, false, false, false);
				num = ((fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00154F04 File Offset: 0x00153104
		private void method_360(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._FuelQuantityThreshold? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Ignore Fuel";
			string text2 = "Bingo";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			string text6 = "100%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				text6
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_42))
				{
					num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							6,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								6,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									6,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										6,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											6,
											"Inherited, " + text5
										});
									}
									else
									{
										num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												6,
												"Inherited, " + text6
											});
										}
										else
										{
											dataTable_0.Rows.Add(new object[]
											{
												6,
												"Inherited, Various"
											});
										}
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._FuelQuantityThreshold? fuelQuantityThreshold = this.method_3(scenario_0, ref flag).method_108(scenario_0, false, false, false);
					num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							6,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								6,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									6,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										6,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											6,
											"Inherited, " + text5
										});
									}
									else
									{
										num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												6,
												"Inherited, " + text6
											});
										}
									}
								}
							}
						}
					}
				}
				Doctrine._FuelQuantityThreshold? fuelQuantityThreshold2 = this.method_108(scenario_0, false, false, false);
				num = ((fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						7,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						7,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00155788 File Offset: 0x00153988
		private void method_361(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Ignore";
			string text2 = "Exhausted";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_42))
				{
					num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, " + text5
										});
									}
									else
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, Various"
										});
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = this.method_3(scenario_0, ref flag).method_99(scenario_0, false, false, false);
					num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, " + text5
										});
									}
								}
							}
						}
					}
				}
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold2 = this.method_99(scenario_0, false, false, false);
				num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00155EE0 File Offset: 0x001540E0
		private void method_362(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Ignore";
			string text2 = "Exhausted";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			string text6 = "100%";
			string text7 = "All attack weapons";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				text6
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				text7
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_42))
				{
					num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							7,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								7,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									7,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										7,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											7,
											"Inherited, " + text5
										});
									}
									else
									{
										num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												7,
												"Inherited, " + text6
											});
										}
										else
										{
											num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													7,
													"Inherited, " + text7
												});
											}
											else
											{
												dataTable_0.Rows.Add(new object[]
												{
													7,
													"Inherited, Various"
												});
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = this.method_3(scenario_0, ref flag).method_111(scenario_0, false, false, false);
					num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							7,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								7,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									7,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										7,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											7,
											"Inherited, " + text5
										});
									}
									else
									{
										num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												7,
												"Inherited, " + text6
											});
										}
										else
										{
											num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													7,
													"Inherited, " + text7
												});
											}
										}
									}
								}
							}
						}
					}
				}
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold2 = this.method_111(scenario_0, false, false, false);
				num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						8,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						8,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00156890 File Offset: 0x00154A90
		private void method_363(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Ignore";
			string text2 = "Exhausted";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_42))
				{
					num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, " + text5
										});
									}
									else
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, Various"
										});
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = this.method_3(scenario_0, ref flag).method_102(scenario_0, false, false, false);
					num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, " + text5
										});
									}
								}
							}
						}
					}
				}
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold2 = this.method_102(scenario_0, false, false, false);
				num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00156FE8 File Offset: 0x001551E8
		private void method_364(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Ignore";
			string text2 = "Exhausted";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			string text6 = "100%";
			string text7 = "All defence weapons";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				text6
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				text7
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_42))
				{
					num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							7,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								7,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									7,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										7,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											7,
											"Inherited, " + text5
										});
									}
									else
									{
										num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												7,
												"Inherited, " + text6
											});
										}
										else
										{
											num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													7,
													"Inherited, " + text7
												});
											}
											else
											{
												dataTable_0.Rows.Add(new object[]
												{
													7,
													"Inherited, Various"
												});
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = this.method_3(scenario_0, ref flag).method_114(scenario_0, false, false, false);
					num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							7,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								7,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									7,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										7,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											7,
											"Inherited, " + text5
										});
									}
									else
									{
										num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											dataTable_0.Rows.Add(new object[]
											{
												7,
												"Inherited, " + text6
											});
										}
										else
										{
											num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
											{
												dataTable_0.Rows.Add(new object[]
												{
													7,
													"Inherited, " + text7
												});
											}
										}
									}
								}
							}
						}
					}
				}
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold2 = this.method_114(scenario_0, false, false, false);
				num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						8,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						8,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00157998 File Offset: 0x00155B98
		private void method_365(ref DataTable dataTable_0, Scenario scenario_0, Doctrine._DamageThreshold? nullable_42)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			string text = "Ignore Damage";
			string text2 = "5%";
			string text3 = "25%";
			string text4 = "50%";
			string text5 = "75%";
			dataTable_0.Rows.Add(new object[]
			{
				0,
				text
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				text2
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				text3
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				text4
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				text5
			});
			if (this.class310_0.GetType() != typeof(Side))
			{
				short? num;
				if (!Information.IsNothing(nullable_42))
				{
					num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((nullable_42 != null) ? new short?((short)nullable_42.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, " + text5
										});
									}
									else
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, Various"
										});
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag = true;
					Doctrine._DamageThreshold? damageThreshold = this.method_3(scenario_0, ref flag).method_105(scenario_0, false, false, false);
					num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						dataTable_0.Rows.Add(new object[]
						{
							5,
							"Inherited, " + text
						});
					}
					else
					{
						num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							dataTable_0.Rows.Add(new object[]
							{
								5,
								"Inherited, " + text2
							});
						}
						else
						{
							num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								dataTable_0.Rows.Add(new object[]
								{
									5,
									"Inherited, " + text3
								});
							}
							else
							{
								num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									dataTable_0.Rows.Add(new object[]
									{
										5,
										"Inherited, " + text4
									});
								}
								else
								{
									num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										dataTable_0.Rows.Add(new object[]
										{
											5,
											"Inherited, " + text5
										});
									}
								}
							}
						}
					}
				}
				Doctrine._DamageThreshold? damageThreshold2 = this.method_105(scenario_0, false, false, false);
				num = ((damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Various"
					});
				}
				if (this.class310_0.GetType() == typeof(Waypoint))
				{
					dataTable_0.Rows.Add(new object[]
					{
						6,
						"Not configured"
					});
				}
			}
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x001580F0 File Offset: 0x001562F0
		public void method_366(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._DamageThreshold? nullable_42)
		{
			Doctrine._DamageThreshold? damageThreshold = this.method_93(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_358(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_95())
			{
				comboBox_0.SelectedIndex = 5;
			}
			else
			{
				Doctrine._DamageThreshold? damageThreshold2 = damageThreshold;
				short? num = (damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					num = ((damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						num = ((damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							num = ((damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								num = ((damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
								else
								{
									num = ((damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 6;
									}
									else
									{
										num = ((damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
										{
											comboBox_0.SelectedIndex = 6;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x001583DC File Offset: 0x001565DC
		public void method_367(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._FuelQuantityThreshold? nullable_42)
		{
			Doctrine._FuelQuantityThreshold? fuelQuantityThreshold = this.method_96(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_359(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_98())
			{
				comboBox_0.SelectedIndex = 5;
			}
			else
			{
				Doctrine._FuelQuantityThreshold? fuelQuantityThreshold2 = fuelQuantityThreshold;
				short? num = (fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					num = ((fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						num = ((fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							num = ((fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								num = ((fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
								else
								{
									num = ((fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 6;
									}
									else
									{
										num = ((fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
										{
											comboBox_0.SelectedIndex = 6;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x001586C8 File Offset: 0x001568C8
		public void method_368(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_42)
		{
			Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = this.method_99(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_361(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_101())
			{
				comboBox_0.SelectedIndex = 5;
			}
			else
			{
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold2 = weaponQuantityThreshold;
				short? num = (weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
								else
								{
									num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 6;
									}
									else
									{
										num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 8) : null).GetValueOrDefault())
										{
											comboBox_0.SelectedIndex = 6;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x001589B4 File Offset: 0x00156BB4
		public void method_369(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_42)
		{
			Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = this.method_102(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_363(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_104())
			{
				comboBox_0.SelectedIndex = 5;
			}
			else
			{
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold2 = weaponQuantityThreshold;
				short? num = (weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
								else
								{
									num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 6;
									}
									else
									{
										num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 8) : null).GetValueOrDefault())
										{
											comboBox_0.SelectedIndex = 6;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00158CA0 File Offset: 0x00156EA0
		public void method_370(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._DamageThreshold? nullable_42)
		{
			Doctrine._DamageThreshold? damageThreshold = this.method_105(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_365(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_107())
			{
				comboBox_0.SelectedIndex = 5;
			}
			else
			{
				Doctrine._DamageThreshold? damageThreshold2 = damageThreshold;
				short? num = (damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					num = ((damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						num = ((damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							num = ((damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								num = ((damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
								else
								{
									num = ((damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 6;
									}
									else
									{
										num = ((damageThreshold2 != null) ? new short?((short)damageThreshold2.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
										{
											comboBox_0.SelectedIndex = 6;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00158F8C File Offset: 0x0015718C
		public void method_371(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._FuelQuantityThreshold? nullable_42)
		{
			Doctrine._FuelQuantityThreshold? fuelQuantityThreshold = this.method_108(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_360(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_110())
			{
				comboBox_0.SelectedIndex = 6;
			}
			else
			{
				Doctrine._FuelQuantityThreshold? fuelQuantityThreshold2 = fuelQuantityThreshold;
				short? num = (fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					num = ((fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						num = ((fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							num = ((fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								num = ((fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
								else
								{
									num = ((fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 5;
									}
									else
									{
										num = ((fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
										{
											comboBox_0.SelectedIndex = 7;
										}
										else
										{
											num = ((fuelQuantityThreshold2 != null) ? new short?((short)fuelQuantityThreshold2.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
											{
												comboBox_0.SelectedIndex = 7;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x001592D8 File Offset: 0x001574D8
		public void method_372(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_42)
		{
			Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = this.method_111(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_362(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_113())
			{
				comboBox_0.SelectedIndex = 7;
			}
			else
			{
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold2 = weaponQuantityThreshold;
				short? num = (weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
								else
								{
									num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 5;
									}
									else
									{
										num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
										{
											comboBox_0.SelectedIndex = 6;
										}
										else
										{
											num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
											{
												comboBox_0.SelectedIndex = 8;
											}
											else
											{
												num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
												if (((num != null) ? new bool?(num.GetValueOrDefault() == 8) : null).GetValueOrDefault())
												{
													comboBox_0.SelectedIndex = 8;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00159680 File Offset: 0x00157880
		public void method_373(ComboBox comboBox_0, ref Scenario scenario_0, Doctrine._WeaponQuantityThreshold? nullable_42)
		{
			Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = this.method_114(scenario_0, false, false, false);
			DataTable dataSource = new DataTable();
			this.method_364(ref dataSource, scenario_0, nullable_42);
			comboBox_0.DataSource = dataSource;
			comboBox_0.DisplayMember = "Description";
			comboBox_0.ValueMember = "ID";
			if (this.method_116())
			{
				comboBox_0.SelectedIndex = 7;
			}
			else
			{
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold2 = weaponQuantityThreshold;
				short? num = (weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					comboBox_0.SelectedIndex = 0;
				}
				else
				{
					num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						comboBox_0.SelectedIndex = 1;
					}
					else
					{
						num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							comboBox_0.SelectedIndex = 2;
						}
						else
						{
							num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								comboBox_0.SelectedIndex = 3;
							}
							else
							{
								num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									comboBox_0.SelectedIndex = 4;
								}
								else
								{
									num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										comboBox_0.SelectedIndex = 5;
									}
									else
									{
										num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
										{
											comboBox_0.SelectedIndex = 6;
										}
										else
										{
											num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 7) : null).GetValueOrDefault())
											{
												comboBox_0.SelectedIndex = 8;
											}
											else
											{
												num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
												if (((num != null) ? new bool?(num.GetValueOrDefault() == 8) : null).GetValueOrDefault())
												{
													comboBox_0.SelectedIndex = 8;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00159A28 File Offset: 0x00157C28
		public void method_374(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_94(scenario_0, true, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Ignore));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_94(scenario_0, false, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Ignore));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_94(scenario_0, true, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent5));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_94(scenario_0, false, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent5));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_94(scenario_0, true, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent25));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_94(scenario_0, false, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent25));
				return;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_94(scenario_0, true, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent50));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_94(scenario_0, false, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent50));
				return;
			case 4:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_94(scenario_0, true, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent75));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_94(scenario_0, false, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent75));
				return;
			case 5:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit6 in this.list_0)
						{
							activeUnit6.doctrine_0.method_94(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
				}
				this.method_94(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00159D40 File Offset: 0x00157F40
		public void method_375(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_106(scenario_0, true, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Ignore));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_106(scenario_0, false, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Ignore));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_106(scenario_0, true, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent5));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_106(scenario_0, false, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent5));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_106(scenario_0, true, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent25));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_106(scenario_0, false, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent25));
				return;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_106(scenario_0, true, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent50));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_106(scenario_0, false, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent50));
				return;
			case 4:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_106(scenario_0, true, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent75));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_106(scenario_0, false, bool_35, bool_36, new Doctrine._DamageThreshold?(Doctrine._DamageThreshold.Percent75));
				return;
			case 5:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit6 in this.list_0)
						{
							activeUnit6.doctrine_0.method_106(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
				}
				this.method_106(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0015A058 File Offset: 0x00158258
		public void method_376(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_97(scenario_0, true, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Ignore));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_97(scenario_0, false, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Ignore));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_97(scenario_0, true, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Bingo));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_97(scenario_0, false, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Bingo));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_97(scenario_0, true, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent25));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_97(scenario_0, false, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent25));
				return;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_97(scenario_0, true, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent50));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_97(scenario_0, false, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent50));
				return;
			case 4:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_97(scenario_0, true, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent75));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_97(scenario_0, false, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent75));
				return;
			case 5:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit6 in this.list_0)
						{
							activeUnit6.doctrine_0.method_97(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
				}
				this.method_97(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0015A370 File Offset: 0x00158570
		public void method_377(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_109(scenario_0, true, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Ignore));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_109(scenario_0, false, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Ignore));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_109(scenario_0, true, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Bingo));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_109(scenario_0, false, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Bingo));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_109(scenario_0, true, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent25));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_109(scenario_0, false, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent25));
				return;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_109(scenario_0, true, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent50));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_109(scenario_0, false, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent50));
				return;
			case 4:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_109(scenario_0, true, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent75));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_109(scenario_0, false, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent75));
				return;
			case 5:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit6 in this.list_0)
						{
							activeUnit6.doctrine_0.method_109(scenario_0, true, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent100));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
				}
				this.method_109(scenario_0, false, bool_35, bool_36, new Doctrine._FuelQuantityThreshold?(Doctrine._FuelQuantityThreshold.Percent100));
				return;
			case 6:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit7 in this.list_0)
						{
							activeUnit7.doctrine_0.method_109(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator7;
						((IDisposable)enumerator7).Dispose();
					}
				}
				this.method_109(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0015A700 File Offset: 0x00158900
		public void method_378(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_100(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_100(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_100(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_100(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_100(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_100(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
				return;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_100(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_100(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
				return;
			case 4:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_100(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_100(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
				return;
			case 5:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit6 in this.list_0)
						{
							activeUnit6.doctrine_0.method_100(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
				}
				this.method_100(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0015AA18 File Offset: 0x00158C18
		public void method_379(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_112(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_112(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_112(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_112(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_112(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_112(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
				return;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_112(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_112(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
				return;
			case 4:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_112(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_112(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
				return;
			case 5:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit6 in this.list_0)
						{
							activeUnit6.doctrine_0.method_112(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent100));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
				}
				this.method_112(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent100));
				return;
			case 6:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit7 in this.list_0)
						{
							activeUnit7.doctrine_0.method_112(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.LoadFullWeapons));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator7;
						((IDisposable)enumerator7).Dispose();
					}
				}
				this.method_112(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.LoadFullWeapons));
				return;
			case 7:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit8 in this.list_0)
						{
							activeUnit8.doctrine_0.method_112(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator8;
						((IDisposable)enumerator8).Dispose();
					}
				}
				this.method_112(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0015AE20 File Offset: 0x00159020
		public void method_380(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_103(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_103(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_103(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_103(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_103(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_103(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
				return;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_103(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_103(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
				return;
			case 4:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_103(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_103(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
				return;
			case 5:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit6 in this.list_0)
						{
							activeUnit6.doctrine_0.method_103(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
				}
				this.method_103(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x0015B138 File Offset: 0x00159338
		public void method_381(ComboBox comboBox_0, ref Scenario scenario_0, ref int int_0, bool bool_35, bool bool_36)
		{
			switch (comboBox_0.SelectedIndex)
			{
			case 0:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_0)
						{
							activeUnit.doctrine_0.method_115(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_115(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Ignore));
				return;
			case 1:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.list_0)
						{
							activeUnit2.doctrine_0.method_115(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				this.method_115(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Exhausted));
				return;
			case 2:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit3 in this.list_0)
						{
							activeUnit3.doctrine_0.method_115(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.method_115(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent25));
				return;
			case 3:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.list_0)
						{
							activeUnit4.doctrine_0.method_115(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_115(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent50));
				return;
			case 4:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in this.list_0)
						{
							activeUnit5.doctrine_0.method_115(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				this.method_115(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent75));
				return;
			case 5:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit6 in this.list_0)
						{
							activeUnit6.doctrine_0.method_115(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent100));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
				}
				this.method_115(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.Percent100));
				return;
			case 6:
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit7 in this.list_0)
						{
							activeUnit7.doctrine_0.method_115(scenario_0, true, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.LoadFullWeapons));
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator7;
						((IDisposable)enumerator7).Dispose();
					}
				}
				this.method_115(scenario_0, false, bool_35, bool_36, new Doctrine._WeaponQuantityThreshold?(Doctrine._WeaponQuantityThreshold.LoadFullWeapons));
				return;
			case 7:
				if (this.class310_0.GetType() == typeof(Side))
				{
					GameGeneral.smethod_1("Side-level Doctrine/RoE settings cannot be inherited from elsewhere!");
					comboBox_0.SelectedIndex = int_0;
					return;
				}
				if (!Information.IsNothing(this.list_0))
				{
					try
					{
						foreach (ActiveUnit activeUnit8 in this.list_0)
						{
							activeUnit8.doctrine_0.method_115(scenario_0, true, bool_35, bool_36, null);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator8;
						((IDisposable)enumerator8).Dispose();
					}
				}
				this.method_115(scenario_0, false, bool_35, bool_36, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x04000A94 RID: 2708
		public Class310 class310_0;

		// Token: 0x04000A95 RID: 2709
		public List<ActiveUnit> list_0;

		// Token: 0x04000A96 RID: 2710
		private Doctrine.Class275 class275_0;

		// Token: 0x04000A97 RID: 2711
		private Dictionary<int, Doctrine.WRA_Weapon> dictionary_0;

		// Token: 0x04000A98 RID: 2712
		private Doctrine.Enum52? nullable_0;

		// Token: 0x04000A99 RID: 2713
		private bool bool_0;

		// Token: 0x04000A9A RID: 2714
		private Doctrine.Enum52? nullable_1;

		// Token: 0x04000A9B RID: 2715
		private bool bool_1;

		// Token: 0x04000A9C RID: 2716
		private Doctrine.Enum52? nullable_2;

		// Token: 0x04000A9D RID: 2717
		private bool bool_2;

		// Token: 0x04000A9E RID: 2718
		private Doctrine.Enum52? nullable_3;

		// Token: 0x04000A9F RID: 2719
		private bool bool_3;

		// Token: 0x04000AA0 RID: 2720
		private Doctrine._GunStrafeGroundTargets? nullable_4;

		// Token: 0x04000AA1 RID: 2721
		private bool bool_4;

		// Token: 0x04000AA2 RID: 2722
		private Doctrine.Enum64? nullable_5;

		// Token: 0x04000AA3 RID: 2723
		private bool bool_5;

		// Token: 0x04000AA4 RID: 2724
		private Doctrine.Enum65? nullable_6;

		// Token: 0x04000AA5 RID: 2725
		private bool bool_6;

		// Token: 0x04000AA6 RID: 2726
		private Doctrine._WeaponStateRTB? nullable_7;

		// Token: 0x04000AA7 RID: 2727
		private bool bool_7;

		// Token: 0x04000AA8 RID: 2728
		private Doctrine._FuelStateRTB? nullable_8;

		// Token: 0x04000AA9 RID: 2729
		private bool bool_8;

		// Token: 0x04000AAA RID: 2730
		private Doctrine._JettisonOrdnance? nullable_9;

		// Token: 0x04000AAB RID: 2731
		private bool bool_9;

		// Token: 0x04000AAC RID: 2732
		private Doctrine._BVRLogicEnum? nullable_10;

		// Token: 0x04000AAD RID: 2733
		private bool bool_10;

		// Token: 0x04000AAE RID: 2734
		private Doctrine.Enum51? nullable_11;

		// Token: 0x04000AAF RID: 2735
		private bool bool_11;

		// Token: 0x04000AB0 RID: 2736
		private Doctrine.Enum61? nullable_12;

		// Token: 0x04000AB1 RID: 2737
		private bool bool_12;

		// Token: 0x04000AB2 RID: 2738
		private Doctrine.Enum62? nullable_13;

		// Token: 0x04000AB3 RID: 2739
		private bool bool_13;

		// Token: 0x04000AB4 RID: 2740
		private Doctrine.Enum63? nullable_14;

		// Token: 0x04000AB5 RID: 2741
		private bool bool_14;

		// Token: 0x04000AB6 RID: 2742
		private Doctrine.Enum63? nullable_15;

		// Token: 0x04000AB7 RID: 2743
		private bool bool_15;

		// Token: 0x04000AB8 RID: 2744
		private Doctrine.Enum63? nullable_16;

		// Token: 0x04000AB9 RID: 2745
		private bool bool_16;

		// Token: 0x04000ABA RID: 2746
		private Doctrine.Enum56? nullable_17;

		// Token: 0x04000ABB RID: 2747
		private bool bool_17;

		// Token: 0x04000ABC RID: 2748
		private Doctrine.Enum57? nullable_18;

		// Token: 0x04000ABD RID: 2749
		private bool bool_18;

		// Token: 0x04000ABE RID: 2750
		private Doctrine.Enum59? nullable_19;

		// Token: 0x04000ABF RID: 2751
		private bool bool_19;

		// Token: 0x04000AC0 RID: 2752
		private Doctrine.Enum58? nullable_20;

		// Token: 0x04000AC1 RID: 2753
		private bool bool_20;

		// Token: 0x04000AC2 RID: 2754
		private Doctrine.Enum60? nullable_21;

		// Token: 0x04000AC3 RID: 2755
		private bool bool_21;

		// Token: 0x04000AC4 RID: 2756
		private Doctrine.Enum53? nullable_22;

		// Token: 0x04000AC5 RID: 2757
		private bool bool_22;

		// Token: 0x04000AC6 RID: 2758
		private Doctrine.Enum54? nullable_23;

		// Token: 0x04000AC7 RID: 2759
		private bool bool_23;

		// Token: 0x04000AC8 RID: 2760
		private Doctrine._FuelState? nullable_24;

		// Token: 0x04000AC9 RID: 2761
		private bool bool_24;

		// Token: 0x04000ACA RID: 2762
		private Doctrine._WeaponState? nullable_25;

		// Token: 0x04000ACB RID: 2763
		private bool bool_25;

		// Token: 0x04000ACC RID: 2764
		private Doctrine.Enum55? nullable_26;

		// Token: 0x04000ACD RID: 2765
		private bool bool_26;

		// Token: 0x04000ACE RID: 2766
		private Doctrine._RefuelAlliedUnits? nullable_27;

		// Token: 0x04000ACF RID: 2767
		private bool bool_27;

		// Token: 0x04000AD0 RID: 2768
		private Doctrine._AvoidContactWhenPossible? nullable_28;

		// Token: 0x04000AD1 RID: 2769
		private bool bool_28;

		// Token: 0x04000AD2 RID: 2770
		private Doctrine._DiveOnContact? nullable_29;

		// Token: 0x04000AD3 RID: 2771
		private bool bool_29;

		// Token: 0x04000AD4 RID: 2772
		private Doctrine._RechargeBatteryPercentage? nullable_30;

		// Token: 0x04000AD5 RID: 2773
		private bool bool_30;

		// Token: 0x04000AD6 RID: 2774
		private Doctrine._RechargeBatteryPercentage? nullable_31;

		// Token: 0x04000AD7 RID: 2775
		private bool bool_31;

		// Token: 0x04000AD8 RID: 2776
		private Doctrine._UseAIP? nullable_32;

		// Token: 0x04000AD9 RID: 2777
		private bool bool_32;

		// Token: 0x04000ADA RID: 2778
		private Doctrine._UseDippingSonar? nullable_33;

		// Token: 0x04000ADB RID: 2779
		private bool bool_33;

		// Token: 0x04000ADC RID: 2780
		private Doctrine._DamageThreshold? nullable_34;

		// Token: 0x04000ADD RID: 2781
		private Doctrine._FuelQuantityThreshold? nullable_35;

		// Token: 0x04000ADE RID: 2782
		private Doctrine._WeaponQuantityThreshold? nullable_36;

		// Token: 0x04000ADF RID: 2783
		private Doctrine._WeaponQuantityThreshold? nullable_37;

		// Token: 0x04000AE0 RID: 2784
		private Doctrine._DamageThreshold? nullable_38;

		// Token: 0x04000AE1 RID: 2785
		private Doctrine._FuelQuantityThreshold? nullable_39;

		// Token: 0x04000AE2 RID: 2786
		private Doctrine._WeaponQuantityThreshold? nullable_40;

		// Token: 0x04000AE3 RID: 2787
		private Doctrine._WeaponQuantityThreshold? nullable_41;

		// Token: 0x04000AE4 RID: 2788
		[CompilerGenerated]
		private static Doctrine.Delegate28 delegate28_0;

		// Token: 0x04000AE5 RID: 2789
		[CompilerGenerated]
		private static Doctrine.Delegate29 delegate29_0;

		// Token: 0x04000AE6 RID: 2790
		public bool bool_34;

		// Token: 0x04000AE7 RID: 2791
		private Doctrine doctrine_0;

		// Token: 0x0200020C RID: 524
		// (Invoke) Token: 0x0600116D RID: 4461
		internal delegate void Delegate28(Class310 theSubject, bool? viaMainForm, bool MultipleUnits, bool ViaDoctrineForm, bool ViaRightColumn, bool viaFlightPlanEditor);

		// Token: 0x0200020D RID: 525
		// (Invoke) Token: 0x06001171 RID: 4465
		internal delegate void Delegate29(Class310 theSubject, bool? viaMainForm, bool MultipleUnits, bool ViaDoctrineForm, bool ViaRightColumn, bool viaFlightPlanEditor);

		// Token: 0x0200020E RID: 526
		internal enum Enum51 : byte
		{
			// Token: 0x04000AE9 RID: 2793
			const_0,
			// Token: 0x04000AEA RID: 2794
			const_1,
			// Token: 0x04000AEB RID: 2795
			const_2,
			// Token: 0x04000AEC RID: 2796
			const_3,
			// Token: 0x04000AED RID: 2797
			const_4
		}

		// Token: 0x0200020F RID: 527
		internal enum Enum52 : byte
		{
			// Token: 0x04000AEF RID: 2799
			const_0,
			// Token: 0x04000AF0 RID: 2800
			const_1,
			// Token: 0x04000AF1 RID: 2801
			const_2,
			// Token: 0x04000AF2 RID: 2802
			const_3,
			// Token: 0x04000AF3 RID: 2803
			const_4
		}

		// Token: 0x02000210 RID: 528
		internal enum Enum53 : byte
		{
			// Token: 0x04000AF5 RID: 2805
			const_0,
			// Token: 0x04000AF6 RID: 2806
			const_1,
			// Token: 0x04000AF7 RID: 2807
			const_2,
			// Token: 0x04000AF8 RID: 2808
			const_3,
			// Token: 0x04000AF9 RID: 2809
			const_4
		}

		// Token: 0x02000211 RID: 529
		internal enum Enum54 : byte
		{
			// Token: 0x04000AFB RID: 2811
			const_0,
			// Token: 0x04000AFC RID: 2812
			const_1,
			// Token: 0x04000AFD RID: 2813
			const_2,
			// Token: 0x04000AFE RID: 2814
			const_3
		}

		// Token: 0x02000212 RID: 530
		public enum _WeaponState
		{
			// Token: 0x04000B00 RID: 2816
			LoadoutSetting,
			// Token: 0x04000B01 RID: 2817
			Winchester = 2001,
			// Token: 0x04000B02 RID: 2818
			Winchester_ToO,
			// Token: 0x04000B03 RID: 2819
			ShotgunBVR = 3001,
			// Token: 0x04000B04 RID: 2820
			ShotgunBVR_WVR,
			// Token: 0x04000B05 RID: 2821
			ShotgunBVR_WVR_Guns,
			// Token: 0x04000B06 RID: 2822
			ShotgunOneEngagementBVR = 5001,
			// Token: 0x04000B07 RID: 2823
			ShotgunOneEngagementBVR_Opportunity_WVR,
			// Token: 0x04000B08 RID: 2824
			ShotgunOneEngagementBVR_Opportunity_WVR_Guns,
			// Token: 0x04000B09 RID: 2825
			ShotgunOneEngagementBVR_And_WVR = 5005,
			// Token: 0x04000B0A RID: 2826
			ShotgunOneEngagementBVR_And_WVR_Opportunity_Guns,
			// Token: 0x04000B0B RID: 2827
			ShotgunOneEngagementWVR = 5011,
			// Token: 0x04000B0C RID: 2828
			ShotgunOneEngagementWVR_Guns,
			// Token: 0x04000B0D RID: 2829
			ShotgunOneEngagementGun = 5021,
			// Token: 0x04000B0E RID: 2830
			Shotgun25 = 4001,
			// Token: 0x04000B0F RID: 2831
			Shotgun25_ToO,
			// Token: 0x04000B10 RID: 2832
			Shotgun50 = 4011,
			// Token: 0x04000B11 RID: 2833
			Shotgun50_ToO,
			// Token: 0x04000B12 RID: 2834
			Shotgun75 = 4021,
			// Token: 0x04000B13 RID: 2835
			Shotgun75_ToO,
			// Token: 0x04000B14 RID: 2836
			Various = 1,
			// Token: 0x04000B15 RID: 2837
			NotConfigured
		}

		// Token: 0x02000213 RID: 531
		public enum _FuelState : byte
		{
			// Token: 0x04000B17 RID: 2839
			Bingo,
			// Token: 0x04000B18 RID: 2840
			Joker10Percent,
			// Token: 0x04000B19 RID: 2841
			Joker20Percent,
			// Token: 0x04000B1A RID: 2842
			Joker25Percent,
			// Token: 0x04000B1B RID: 2843
			Joker30Percent,
			// Token: 0x04000B1C RID: 2844
			Joker40Percent,
			// Token: 0x04000B1D RID: 2845
			Joker50Percent,
			// Token: 0x04000B1E RID: 2846
			Joker60Percent,
			// Token: 0x04000B1F RID: 2847
			Joker70Percent,
			// Token: 0x04000B20 RID: 2848
			Joker75Percent,
			// Token: 0x04000B21 RID: 2849
			Joker80Percent,
			// Token: 0x04000B22 RID: 2850
			Joker90Percent,
			// Token: 0x04000B23 RID: 2851
			Various,
			// Token: 0x04000B24 RID: 2852
			Chicken,
			// Token: 0x04000B25 RID: 2853
			NotConfigured
		}

		// Token: 0x02000214 RID: 532
		internal enum Enum55 : byte
		{
			// Token: 0x04000B27 RID: 2855
			const_0,
			// Token: 0x04000B28 RID: 2856
			const_1,
			// Token: 0x04000B29 RID: 2857
			const_2,
			// Token: 0x04000B2A RID: 2858
			const_3,
			// Token: 0x04000B2B RID: 2859
			const_4
		}

		// Token: 0x02000215 RID: 533
		internal enum Enum56 : byte
		{
			// Token: 0x04000B2D RID: 2861
			const_0,
			// Token: 0x04000B2E RID: 2862
			const_1,
			// Token: 0x04000B2F RID: 2863
			const_2,
			// Token: 0x04000B30 RID: 2864
			const_3,
			// Token: 0x04000B31 RID: 2865
			const_4
		}

		// Token: 0x02000216 RID: 534
		internal enum Enum57 : byte
		{
			// Token: 0x04000B33 RID: 2867
			const_0,
			// Token: 0x04000B34 RID: 2868
			const_1,
			// Token: 0x04000B35 RID: 2869
			const_2,
			// Token: 0x04000B36 RID: 2870
			const_3,
			// Token: 0x04000B37 RID: 2871
			const_4
		}

		// Token: 0x02000217 RID: 535
		internal enum Enum58 : byte
		{
			// Token: 0x04000B39 RID: 2873
			const_0,
			// Token: 0x04000B3A RID: 2874
			const_1,
			// Token: 0x04000B3B RID: 2875
			const_2,
			// Token: 0x04000B3C RID: 2876
			const_3
		}

		// Token: 0x02000218 RID: 536
		internal enum Enum59 : byte
		{
			// Token: 0x04000B3E RID: 2878
			const_0,
			// Token: 0x04000B3F RID: 2879
			const_1,
			// Token: 0x04000B40 RID: 2880
			const_2,
			// Token: 0x04000B41 RID: 2881
			const_3
		}

		// Token: 0x02000219 RID: 537
		internal enum Enum60 : byte
		{
			// Token: 0x04000B43 RID: 2883
			const_0,
			// Token: 0x04000B44 RID: 2884
			const_1,
			// Token: 0x04000B45 RID: 2885
			const_2,
			// Token: 0x04000B46 RID: 2886
			const_3
		}

		// Token: 0x0200021A RID: 538
		internal enum Enum61 : byte
		{
			// Token: 0x04000B48 RID: 2888
			const_0,
			// Token: 0x04000B49 RID: 2889
			const_1,
			// Token: 0x04000B4A RID: 2890
			const_2,
			// Token: 0x04000B4B RID: 2891
			const_3
		}

		// Token: 0x0200021B RID: 539
		internal enum Enum62 : byte
		{
			// Token: 0x04000B4D RID: 2893
			const_0,
			// Token: 0x04000B4E RID: 2894
			const_1,
			// Token: 0x04000B4F RID: 2895
			const_2,
			// Token: 0x04000B50 RID: 2896
			const_3
		}

		// Token: 0x0200021C RID: 540
		internal enum Enum63 : byte
		{
			// Token: 0x04000B52 RID: 2898
			const_0,
			// Token: 0x04000B53 RID: 2899
			const_1,
			// Token: 0x04000B54 RID: 2900
			const_2,
			// Token: 0x04000B55 RID: 2901
			const_3,
			// Token: 0x04000B56 RID: 2902
			const_4,
			// Token: 0x04000B57 RID: 2903
			const_5,
			// Token: 0x04000B58 RID: 2904
			const_6,
			// Token: 0x04000B59 RID: 2905
			const_7
		}

		// Token: 0x0200021D RID: 541
		public enum _GunStrafeGroundTargets : byte
		{
			// Token: 0x04000B5B RID: 2907
			No,
			// Token: 0x04000B5C RID: 2908
			Yes,
			// Token: 0x04000B5D RID: 2909
			Various,
			// Token: 0x04000B5E RID: 2910
			NotConfigured
		}

		// Token: 0x0200021E RID: 542
		internal enum Enum64 : byte
		{
			// Token: 0x04000B60 RID: 2912
			const_0,
			// Token: 0x04000B61 RID: 2913
			const_1,
			// Token: 0x04000B62 RID: 2914
			const_2,
			// Token: 0x04000B63 RID: 2915
			const_3
		}

		// Token: 0x0200021F RID: 543
		internal enum Enum65 : byte
		{
			// Token: 0x04000B65 RID: 2917
			const_0,
			// Token: 0x04000B66 RID: 2918
			const_1,
			// Token: 0x04000B67 RID: 2919
			const_2,
			// Token: 0x04000B68 RID: 2920
			const_3
		}

		// Token: 0x02000220 RID: 544
		public enum _WeaponStateRTB : byte
		{
			// Token: 0x04000B6A RID: 2922
			No,
			// Token: 0x04000B6B RID: 2923
			YesLastUnit,
			// Token: 0x04000B6C RID: 2924
			YesFirstUnit,
			// Token: 0x04000B6D RID: 2925
			YesLeaveGroup,
			// Token: 0x04000B6E RID: 2926
			Various,
			// Token: 0x04000B6F RID: 2927
			NotConfigured
		}

		// Token: 0x02000221 RID: 545
		public enum _FuelStateRTB : byte
		{
			// Token: 0x04000B71 RID: 2929
			No,
			// Token: 0x04000B72 RID: 2930
			YesLastUnit,
			// Token: 0x04000B73 RID: 2931
			YesFirstUnit,
			// Token: 0x04000B74 RID: 2932
			YesLeaveGroup,
			// Token: 0x04000B75 RID: 2933
			Various,
			// Token: 0x04000B76 RID: 2934
			NotConfigured
		}

		// Token: 0x02000222 RID: 546
		public enum _JettisonOrdnance : byte
		{
			// Token: 0x04000B78 RID: 2936
			No,
			// Token: 0x04000B79 RID: 2937
			Yes,
			// Token: 0x04000B7A RID: 2938
			Various,
			// Token: 0x04000B7B RID: 2939
			NotConfigured
		}

		// Token: 0x02000223 RID: 547
		public enum _BVRLogicEnum : byte
		{
			// Token: 0x04000B7D RID: 2941
			StraightIn,
			// Token: 0x04000B7E RID: 2942
			Crank,
			// Token: 0x04000B7F RID: 2943
			Drag,
			// Token: 0x04000B80 RID: 2944
			Various,
			// Token: 0x04000B81 RID: 2945
			NotConfigured
		}

		// Token: 0x02000224 RID: 548
		public enum _RefuelAlliedUnits : byte
		{
			// Token: 0x04000B83 RID: 2947
			Yes,
			// Token: 0x04000B84 RID: 2948
			Yes_ReceiveOnly,
			// Token: 0x04000B85 RID: 2949
			Yes_DeliverOnly,
			// Token: 0x04000B86 RID: 2950
			No,
			// Token: 0x04000B87 RID: 2951
			Various,
			// Token: 0x04000B88 RID: 2952
			NotConfigured
		}

		// Token: 0x02000225 RID: 549
		public enum _AvoidContactWhenPossible : byte
		{
			// Token: 0x04000B8A RID: 2954
			No,
			// Token: 0x04000B8B RID: 2955
			Yes_ExceptSelfDefence,
			// Token: 0x04000B8C RID: 2956
			Yes_Always,
			// Token: 0x04000B8D RID: 2957
			Various,
			// Token: 0x04000B8E RID: 2958
			NotConfigured
		}

		// Token: 0x02000226 RID: 550
		public enum _DiveOnContact : byte
		{
			// Token: 0x04000B90 RID: 2960
			Yes,
			// Token: 0x04000B91 RID: 2961
			Yes_ESM_Only,
			// Token: 0x04000B92 RID: 2962
			Yes_Ships20nm_Aircraft30nm,
			// Token: 0x04000B93 RID: 2963
			No,
			// Token: 0x04000B94 RID: 2964
			Various,
			// Token: 0x04000B95 RID: 2965
			NotConfigured
		}

		// Token: 0x02000227 RID: 551
		public enum _RechargeBatteryPercentage
		{
			// Token: 0x04000B97 RID: 2967
			Recharge_Empty,
			// Token: 0x04000B98 RID: 2968
			Recharge_10_Percent = 10,
			// Token: 0x04000B99 RID: 2969
			Recharge_20_Percent = 20,
			// Token: 0x04000B9A RID: 2970
			Recharge_30_Percent = 30,
			// Token: 0x04000B9B RID: 2971
			Recharge_40_Percent = 40,
			// Token: 0x04000B9C RID: 2972
			Recharge_50_Percent = 50,
			// Token: 0x04000B9D RID: 2973
			Recharge_60_Percent = 60,
			// Token: 0x04000B9E RID: 2974
			Recharge_70_Percent = 70,
			// Token: 0x04000B9F RID: 2975
			Recharge_80_Percent = 80,
			// Token: 0x04000BA0 RID: 2976
			Recharge_90_Percent = 90,
			// Token: 0x04000BA1 RID: 2977
			Various = -100,
			// Token: 0x04000BA2 RID: 2978
			NotConfigured = -101
		}

		// Token: 0x02000228 RID: 552
		public enum _UseAIP : byte
		{
			// Token: 0x04000BA4 RID: 2980
			No,
			// Token: 0x04000BA5 RID: 2981
			Yes_AttackOnly,
			// Token: 0x04000BA6 RID: 2982
			Yes_Always,
			// Token: 0x04000BA7 RID: 2983
			Various,
			// Token: 0x04000BA8 RID: 2984
			NotConfigured
		}

		// Token: 0x02000229 RID: 553
		public enum _UseDippingSonar : byte
		{
			// Token: 0x04000BAA RID: 2986
			Automatically_HoverAnd150ft,
			// Token: 0x04000BAB RID: 2987
			ManualAndMissionOnly,
			// Token: 0x04000BAC RID: 2988
			Various,
			// Token: 0x04000BAD RID: 2989
			NotConfigured
		}

		// Token: 0x0200022A RID: 554
		public enum _DamageThreshold : short
		{
			// Token: 0x04000BAF RID: 2991
			Ignore,
			// Token: 0x04000BB0 RID: 2992
			Percent5,
			// Token: 0x04000BB1 RID: 2993
			Percent25,
			// Token: 0x04000BB2 RID: 2994
			Percent50,
			// Token: 0x04000BB3 RID: 2995
			Percent75,
			// Token: 0x04000BB4 RID: 2996
			Various,
			// Token: 0x04000BB5 RID: 2997
			NotConfigured
		}

		// Token: 0x0200022B RID: 555
		public enum _FuelQuantityThreshold : short
		{
			// Token: 0x04000BB7 RID: 2999
			Ignore,
			// Token: 0x04000BB8 RID: 3000
			Bingo,
			// Token: 0x04000BB9 RID: 3001
			Percent25,
			// Token: 0x04000BBA RID: 3002
			Percent50,
			// Token: 0x04000BBB RID: 3003
			Percent75,
			// Token: 0x04000BBC RID: 3004
			Percent100,
			// Token: 0x04000BBD RID: 3005
			Various,
			// Token: 0x04000BBE RID: 3006
			NotConfigured
		}

		// Token: 0x0200022C RID: 556
		public enum _WeaponQuantityThreshold : short
		{
			// Token: 0x04000BC0 RID: 3008
			Ignore,
			// Token: 0x04000BC1 RID: 3009
			Exhausted,
			// Token: 0x04000BC2 RID: 3010
			Percent25,
			// Token: 0x04000BC3 RID: 3011
			Percent50,
			// Token: 0x04000BC4 RID: 3012
			Percent75,
			// Token: 0x04000BC5 RID: 3013
			Percent100,
			// Token: 0x04000BC6 RID: 3014
			LoadFullWeapons,
			// Token: 0x04000BC7 RID: 3015
			Various,
			// Token: 0x04000BC8 RID: 3016
			NotConfigured
		}

		// Token: 0x0200022D RID: 557
		internal sealed class Class275
		{
			// Token: 0x06001172 RID: 4466 RVA: 0x00002977 File Offset: 0x00000B77
			public Class275()
			{
			}

			// Token: 0x06001173 RID: 4467 RVA: 0x0000A35B File Offset: 0x0000855B
			public Class275(Doctrine.Class275.Enum66 enum66_3, Doctrine.Class275.Enum66 enum66_4, Doctrine.Class275.Enum66 enum66_5)
			{
				this.enum66_0 = enum66_3;
				this.enum66_1 = enum66_4;
				this.enum66_2 = enum66_5;
			}

			// Token: 0x06001174 RID: 4468 RVA: 0x0000A378 File Offset: 0x00008578
			public bool method_0()
			{
				return this.enum66_0 == Doctrine.Class275.Enum66.const_1 || this.enum66_1 == Doctrine.Class275.Enum66.const_1 || this.enum66_2 == Doctrine.Class275.Enum66.const_1;
			}

			// Token: 0x06001175 RID: 4469 RVA: 0x0000A397 File Offset: 0x00008597
			public Doctrine.Class275.Enum66 method_1()
			{
				return this.enum66_0;
			}

			// Token: 0x06001176 RID: 4470 RVA: 0x0000A39F File Offset: 0x0000859F
			public Doctrine.Class275.Enum66 method_2()
			{
				return this.enum66_1;
			}

			// Token: 0x06001177 RID: 4471 RVA: 0x0000A3A7 File Offset: 0x000085A7
			public Doctrine.Class275.Enum66 method_3()
			{
				return this.enum66_2;
			}

			// Token: 0x06001178 RID: 4472 RVA: 0x0015B540 File Offset: 0x00159740
			public static Doctrine.Class275.Enum66 smethod_0(int int_0)
			{
				Doctrine.Class275.Enum66 result;
				if (int_0 != 0)
				{
					if (int_0 != 1)
					{
						result = Doctrine.Class275.Enum66.const_3;
					}
					else
					{
						result = Doctrine.Class275.Enum66.const_1;
					}
				}
				else
				{
					result = Doctrine.Class275.Enum66.const_0;
				}
				return result;
			}

			// Token: 0x04000BC9 RID: 3017
			private Doctrine.Class275.Enum66 enum66_0;

			// Token: 0x04000BCA RID: 3018
			private Doctrine.Class275.Enum66 enum66_1;

			// Token: 0x04000BCB RID: 3019
			private Doctrine.Class275.Enum66 enum66_2;

			// Token: 0x0200022E RID: 558
			internal enum Enum66 : byte
			{
				// Token: 0x04000BCD RID: 3021
				const_0,
				// Token: 0x04000BCE RID: 3022
				const_1,
				// Token: 0x04000BCF RID: 3023
				const_2,
				// Token: 0x04000BD0 RID: 3024
				const_3,
				// Token: 0x04000BD1 RID: 3025
				const_4
			}
		}

		// Token: 0x0200022F RID: 559
		public sealed class WRA_Weapon
		{
			// Token: 0x06001179 RID: 4473 RVA: 0x0000A3AF File Offset: 0x000085AF
			public WRA_Weapon()
			{
				this.class276_0 = new Doctrine.Class276[0];
			}

			// Token: 0x0600117A RID: 4474 RVA: 0x0015B564 File Offset: 0x00159764
			public WRA_Weapon(ref Weapon weapon_1, Scenario scenario_0)
			{
				this.class276_0 = new Doctrine.Class276[0];
				if (weapon_1.class394_0.bool_2 || weapon_1.class394_0.bool_11 || weapon_1.class394_0.bool_3 || weapon_1.class394_0.bool_4)
				{
					Doctrine.Class276 class276_ = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type);
					Class429.smethod_46(ref this.class276_0, class276_);
				}
				if (weapon_1.class394_0.bool_2)
				{
					Doctrine.Class276 class276_2 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified);
					Class429.smethod_46(ref this.class276_0, class276_2);
					class276_2 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Aircraft_5th_Generation);
					Class429.smethod_46(ref this.class276_0, class276_2);
					class276_2 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Aircraft_4th_Generation);
					Class429.smethod_46(ref this.class276_0, class276_2);
					class276_2 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Aircraft_3rd_Generation);
					Class429.smethod_46(ref this.class276_0, class276_2);
					class276_2 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Aircraft_Less_Capable);
					Class429.smethod_46(ref this.class276_0, class276_2);
					class276_2 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Bombers);
					Class429.smethod_46(ref this.class276_0, class276_2);
					class276_2 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Aircraft_Medium_Perf_Bombers);
					Class429.smethod_46(ref this.class276_0, class276_2);
					class276_2 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Bombers);
					Class429.smethod_46(ref this.class276_0, class276_2);
					class276_2 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Aircraft_High_Perf_Recon_EW);
					Class429.smethod_46(ref this.class276_0, class276_2);
					class276_2 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Aircraft_Medium_Perf_Recon_EW);
					Class429.smethod_46(ref this.class276_0, class276_2);
					class276_2 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Aircraft_Low_Perf_Recon_EW);
					Class429.smethod_46(ref this.class276_0, class276_2);
					class276_2 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Aircraft_AEW);
					Class429.smethod_46(ref this.class276_0, class276_2);
					class276_2 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Aircraft_MicroUAV);
					Class429.smethod_46(ref this.class276_0, class276_2);
					class276_2 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified);
					Class429.smethod_46(ref this.class276_0, class276_2);
				}
				else if (weapon_1.class394_0.bool_11)
				{
					Doctrine.Class276 class276_3 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified);
					Class429.smethod_46(ref this.class276_0, class276_3);
				}
				if (weapon_1.class394_0.bool_3)
				{
					Doctrine.Class276 class276_4 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified);
					Class429.smethod_46(ref this.class276_0, class276_4);
					class276_4 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic_Sea_Skimming);
					Class429.smethod_46(ref this.class276_0, class276_4);
					class276_4 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic_Sea_Skimming);
					Class429.smethod_46(ref this.class276_0, class276_4);
					class276_4 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Guided_Weapon_Subsonic);
					Class429.smethod_46(ref this.class276_0, class276_4);
					class276_4 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Guided_Weapon_Supersonic);
					Class429.smethod_46(ref this.class276_0, class276_4);
					class276_4 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Guided_Weapon_Ballistic);
					Class429.smethod_46(ref this.class276_0, class276_4);
				}
				if (weapon_1.class394_0.bool_4)
				{
					Doctrine.Class276 class276_5 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Satellite_Unspecified);
					Class429.smethod_46(ref this.class276_0, class276_5);
				}
				if (weapon_1.class394_0.bool_0)
				{
					Doctrine.Class276 class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Unspecified);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Carrier_0_25000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Carrier_25001_45000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Carrier_45001_95000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Carrier_95000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_0_500_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_501_1500_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_1501_5000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_5001_10000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_10001_25000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_25001_45000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_45001_95000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Surface_Combatant_95000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_0_500_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_501_1500_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_1501_5000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_5001_10000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_10001_25000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_25001_45000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_45001_95000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Amphibious_95000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_0_500_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_501_1500_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_1501_5000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_5001_10000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_10001_25000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_25001_45000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_45001_95000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Auxiliary_95000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_0_500_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_501_1500_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_1501_5000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_5001_10000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_10001_25000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_25001_45000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_45001_95000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Merchant_Civilian_95000_tons);
					Class429.smethod_46(ref this.class276_0, class276_6);
					class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Submarine_Surfaced);
					Class429.smethod_46(ref this.class276_0, class276_6);
				}
				if (weapon_1.class394_0.bool_1)
				{
					Doctrine.Class276 class276_7 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Submarine_Unspecified);
					Class429.smethod_46(ref this.class276_0, class276_7);
					class276_7 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type);
					Class429.smethod_46(ref this.class276_0, class276_7);
				}
				if (weapon_1.class394_0.bool_7 || weapon_1.class394_0.bool_8 || weapon_1.class394_0.bool_12 || weapon_1.class394_0.bool_13 || weapon_1.class394_0.bool_6 || weapon_1.class394_0.bool_14 || weapon_1.class394_0.bool_15 || weapon_1.class394_0.bool_16)
				{
					Doctrine.Class276 class276_8 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type);
					Class429.smethod_46(ref this.class276_0, class276_8);
				}
				if (weapon_1.class394_0.bool_7 || weapon_1.class394_0.bool_8)
				{
					Doctrine.Class276 class276_9 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified);
					Class429.smethod_46(ref this.class276_0, class276_9);
					class276_9 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Surface);
					Class429.smethod_46(ref this.class276_0, class276_9);
					class276_9 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Building_Reveted);
					Class429.smethod_46(ref this.class276_0, class276_9);
					class276_9 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Open);
					Class429.smethod_46(ref this.class276_0, class276_9);
					class276_9 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Structure_Reveted);
					Class429.smethod_46(ref this.class276_0, class276_9);
					class276_9 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Aerostat_Moring);
					Class429.smethod_46(ref this.class276_0, class276_9);
					class276_9 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified);
					Class429.smethod_46(ref this.class276_0, class276_9);
					class276_9 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Surface);
					Class429.smethod_46(ref this.class276_0, class276_9);
					class276_9 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Reveted);
					Class429.smethod_46(ref this.class276_0, class276_9);
					class276_9 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Bunker);
					Class429.smethod_46(ref this.class276_0, class276_9);
					class276_9 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Building_Underground);
					Class429.smethod_46(ref this.class276_0, class276_9);
					class276_9 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Open);
					Class429.smethod_46(ref this.class276_0, class276_9);
					class276_9 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Structure_Reveted);
					Class429.smethod_46(ref this.class276_0, class276_9);
				}
				if (weapon_1.class394_0.bool_6)
				{
					Doctrine.Class276 class276_10 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified);
					Class429.smethod_46(ref this.class276_0, class276_10);
					class276_10 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Runway);
					Class429.smethod_46(ref this.class276_0, class276_10);
					class276_10 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Runway_Grade_Taxiway);
					Class429.smethod_46(ref this.class276_0, class276_10);
					class276_10 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Runway_Access_Point);
					Class429.smethod_46(ref this.class276_0, class276_10);
				}
				if (weapon_1.class394_0.bool_5)
				{
					Doctrine.Class276 class276_11 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Radar_Unspecified);
					Class429.smethod_46(ref this.class276_0, class276_11);
				}
				if (weapon_1.class394_0.bool_12 || weapon_1.class394_0.bool_13)
				{
					Doctrine.Class276 class276_12 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified);
					Class429.smethod_46(ref this.class276_0, class276_12);
					class276_12 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Vehicle);
					Class429.smethod_46(ref this.class276_0, class276_12);
					class276_12 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel);
					Class429.smethod_46(ref this.class276_0, class276_12);
					class276_12 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified);
					Class429.smethod_46(ref this.class276_0, class276_12);
					class276_12 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Mobile_Vehicle);
					Class429.smethod_46(ref this.class276_0, class276_12);
				}
				bool flag = false;
				checked
				{
					try
					{
						foreach (Doctrine.WRA_Weapon wra_Weapon in weapon_1.doctrine_0.method_27().Values)
						{
							if ((weapon_1.class394_0.bool_7 || weapon_1.class394_0.bool_8) && !weapon_1.class394_0.bool_12 && !weapon_1.class394_0.bool_13)
							{
								Doctrine.Class276[] array = wra_Weapon.class276_0;
								int i = 0;
								while (i < array.Length)
								{
									Doctrine.Class276 @class = array[i];
									if (@class._WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified)
									{
										if (@class._WRA_WeaponTargetType_0 != Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified)
										{
											i++;
											continue;
										}
									}
									Doctrine.Class276 class276_13 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified);
									Class429.smethod_46(ref this.class276_0, class276_13);
									class276_13 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Vehicle);
									Class429.smethod_46(ref this.class276_0, class276_13);
									class276_13 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Mobile_Personnel);
									Class429.smethod_46(ref this.class276_0, class276_13);
									class276_13 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified);
									Class429.smethod_46(ref this.class276_0, class276_13);
									class276_13 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Mobile_Vehicle);
									Class429.smethod_46(ref this.class276_0, class276_13);
									flag = true;
									break;
								}
							}
							if (flag)
							{
								break;
							}
						}
					}
					finally
					{
						Dictionary<int, Doctrine.WRA_Weapon>.ValueCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (weapon_1.class394_0.bool_14)
					{
						Doctrine.Class276 class276_14 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Underwater_Structure);
						Class429.smethod_46(ref this.class276_0, class276_14);
					}
					if (weapon_1.class394_0.bool_16)
					{
						Doctrine.Class276 class276_15 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield);
						Class429.smethod_46(ref this.class276_0, class276_15);
					}
				}
			}

			// Token: 0x0600117B RID: 4475 RVA: 0x0015C110 File Offset: 0x0015A310
			public void method_0(ref Weapon weapon_1)
			{
				if (weapon_1.class394_0.bool_2 || weapon_1.class394_0.bool_11 || weapon_1.class394_0.bool_3 || weapon_1.class394_0.bool_4)
				{
					Doctrine.Class276 class276_ = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Air_Contact_Unknown_Type, new int?(2), new int?(1), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_);
				}
				if (weapon_1.class394_0.bool_2)
				{
					Doctrine.Class276 class276_2 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Aircraft_Unspecified, new int?(2), new int?(1), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_2);
				}
				if (weapon_1.class394_0.bool_11 || weapon_1.class394_0.bool_2)
				{
					Doctrine.Class276 class276_3 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Helicopter_Unspecified, new int?(2), new int?(1), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_3);
				}
				if (weapon_1.class394_0.bool_3)
				{
					Doctrine.Class276 class276_4 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Guided_Weapon_Unspecified, new int?(2), new int?(1), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_4);
				}
				if (weapon_1.class394_0.bool_4)
				{
					Doctrine.Class276 class276_5 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Satellite_Unspecified, new int?(2), new int?(1), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_5);
				}
				if (weapon_1.class394_0.bool_0)
				{
					if (weapon_1.method_167() != Weapon._WeaponType.Gun && weapon_1.method_167() != Weapon._WeaponType.Rocket)
					{
						if (weapon_1.method_167() != Weapon._WeaponType.IronBomb)
						{
							if (weapon_1.method_167() == Weapon._WeaponType.Torpedo)
							{
								Doctrine.Class276 class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type, new int?(2), new int?(1), new int?(0), null);
								Class429.smethod_46(ref this.class276_0, class276_6);
								class276_6 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Unspecified, new int?(2), new int?(1), new int?(0), null);
								Class429.smethod_46(ref this.class276_0, class276_6);
								goto IL_315;
							}
							Doctrine.Class276 class276_7 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type, new int?(2), new int?(1), new int?(0), null);
							Class429.smethod_46(ref this.class276_0, class276_7);
							class276_7 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Unspecified, new int?(-2), new int?(-99), new int?(0), null);
							Class429.smethod_46(ref this.class276_0, class276_7);
							goto IL_315;
						}
					}
					Doctrine.Class276 class276_8 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Surface_Contact_Unknown_Type, new int?(-99), new int?(-99), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_8);
					class276_8 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Ship_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_8);
				}
				IL_315:
				if (weapon_1.class394_0.bool_1)
				{
					if (weapon_1.method_167() == Weapon._WeaponType.DepthCharge)
					{
						Doctrine.Class276 class276_9 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Submarine_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
						Class429.smethod_46(ref this.class276_0, class276_9);
						class276_9 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type, new int?(-99), new int?(-99), new int?(0), null);
						Class429.smethod_46(ref this.class276_0, class276_9);
					}
					else
					{
						Doctrine.Class276 class276_10 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Submarine_Unspecified, new int?(2), new int?(1), new int?(0), null);
						Class429.smethod_46(ref this.class276_0, class276_10);
						class276_10 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Subsurface_Contact_Unknown_Type, new int?(2), new int?(1), new int?(0), null);
						Class429.smethod_46(ref this.class276_0, class276_10);
					}
				}
				if (weapon_1.class394_0.bool_7 || weapon_1.class394_0.bool_8 || weapon_1.class394_0.bool_12 || weapon_1.class394_0.bool_13 || weapon_1.class394_0.bool_6 || weapon_1.class394_0.bool_14 || weapon_1.class394_0.bool_15 || weapon_1.class394_0.bool_16)
				{
					if (weapon_1.method_167() != Weapon._WeaponType.Gun && weapon_1.method_167() != Weapon._WeaponType.Rocket)
					{
						if (weapon_1.method_167() != Weapon._WeaponType.IronBomb)
						{
							Doctrine.Class276 class276_11 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type, new int?(2), new int?(1), new int?(0), null);
							Class429.smethod_46(ref this.class276_0, class276_11);
							class276_11 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified, new int?(2), new int?(1), new int?(0), null);
							Class429.smethod_46(ref this.class276_0, class276_11);
							goto IL_582;
						}
					}
					Doctrine.Class276 class276_12 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Contact_Unknown_Type, new int?(-99), new int?(-99), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_12);
					class276_12 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Runway_Facility_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_12);
				}
				IL_582:
				if (weapon_1.class394_0.bool_7 || weapon_1.class394_0.bool_8)
				{
					if (weapon_1.method_167() != Weapon._WeaponType.Gun && weapon_1.method_167() != Weapon._WeaponType.Rocket)
					{
						if (weapon_1.method_167() != Weapon._WeaponType.IronBomb)
						{
							Doctrine.Class276 class276_13 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified, new int?(-2), new int?(1), new int?(0), null);
							Class429.smethod_46(ref this.class276_0, class276_13);
							class276_13 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified, new int?(-2), new int?(1), new int?(0), null);
							Class429.smethod_46(ref this.class276_0, class276_13);
							goto IL_6A8;
						}
					}
					Doctrine.Class276 class276_14 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Soft_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_14);
					class276_14 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Land_Structure_Hardened_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_14);
				}
				IL_6A8:
				if (weapon_1.class394_0.bool_5)
				{
					if (weapon_1.method_167() != Weapon._WeaponType.Gun && weapon_1.method_167() != Weapon._WeaponType.Rocket)
					{
						if (weapon_1.method_167() != Weapon._WeaponType.IronBomb)
						{
							Doctrine.Class276 class276_15 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Radar_Unspecified, new int?(-2), new int?(-99), new int?(0), null);
							Class429.smethod_46(ref this.class276_0, class276_15);
							goto IL_753;
						}
					}
					Doctrine.Class276 class276_16 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Radar_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_16);
				}
				IL_753:
				if (weapon_1.class394_0.bool_12 || (weapon_1.class394_0.bool_7 && !weapon_1.struct36_0.bool_31 && !weapon_1.class394_0.bool_12) || weapon_1.class394_0.bool_13 || (weapon_1.class394_0.bool_8 && !weapon_1.struct36_0.bool_31 && !weapon_1.class394_0.bool_13))
				{
					if (weapon_1.method_167() != Weapon._WeaponType.Gun && weapon_1.method_167() != Weapon._WeaponType.Rocket)
					{
						if (weapon_1.method_167() != Weapon._WeaponType.IronBomb)
						{
							Doctrine.Class276 class276_17 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified, new int?(-2), new int?(1), new int?(0), null);
							Class429.smethod_46(ref this.class276_0, class276_17);
							class276_17 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified, new int?(-2), new int?(1), new int?(0), null);
							Class429.smethod_46(ref this.class276_0, class276_17);
							goto IL_8D3;
						}
					}
					Doctrine.Class276 class276_18 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Mobile_Target_Soft_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_18);
					class276_18 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Mobile_Target_Hardened_Unspecified, new int?(-99), new int?(-99), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_18);
				}
				IL_8D3:
				if (weapon_1.class394_0.bool_14)
				{
					if (weapon_1.method_167() != Weapon._WeaponType.Gun && weapon_1.method_167() != Weapon._WeaponType.Rocket)
					{
						if (weapon_1.method_167() != Weapon._WeaponType.IronBomb)
						{
							Doctrine.Class276 class276_19 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Underwater_Structure, new int?(-2), new int?(1), new int?(0), null);
							Class429.smethod_46(ref this.class276_0, class276_19);
							goto IL_97D;
						}
					}
					Doctrine.Class276 class276_20 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Underwater_Structure, new int?(-99), new int?(-99), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_20);
				}
				IL_97D:
				if (weapon_1.class394_0.bool_16)
				{
					if (weapon_1.method_167() != Weapon._WeaponType.Gun && weapon_1.method_167() != Weapon._WeaponType.Rocket)
					{
						if (weapon_1.method_167() != Weapon._WeaponType.IronBomb)
						{
							Doctrine.Class276 class276_21 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield, new int?(-2), new int?(1), new int?(0), null);
							Class429.smethod_46(ref this.class276_0, class276_21);
							return;
						}
					}
					Doctrine.Class276 class276_22 = new Doctrine.Class276(Doctrine._WRA_WeaponTargetType.Air_Base_Single_Unit_Airfield, new int?(-99), new int?(-99), new int?(0), null);
					Class429.smethod_46(ref this.class276_0, class276_22);
					return;
				}
			}

			// Token: 0x0600117C RID: 4476 RVA: 0x0000A3C3 File Offset: 0x000085C3
			public Weapon method_1(Scenario scenario_0, int int_0)
			{
				if (Information.IsNothing(this.weapon_0))
				{
					if (this.method_2(scenario_0, int_0))
					{
						this.weapon_0 = scenario_0.method_87(int_0);
					}
					else
					{
						this.weapon_0 = Weapon.smethod_16(ref scenario_0, int_0, null);
					}
				}
				return this.weapon_0;
			}

			// Token: 0x0600117D RID: 4477 RVA: 0x0015CB48 File Offset: 0x0015AD48
			public bool method_2(Scenario scenario_0, int int_0)
			{
				SQLiteConnection sqliteConnection = scenario_0.method_39();
				Weapon._WeaponType weaponType = DBFunctions.smethod_73(int_0, ref sqliteConnection);
				if (weaponType <= Weapon._WeaponType.DepthCharge)
				{
					if (weaponType - Weapon._WeaponType.Rocket <= 2 || weaponType == Weapon._WeaponType.DepthCharge)
					{
						goto IL_42;
					}
				}
				else if (weaponType == Weapon._WeaponType.Laser || weaponType - Weapon._WeaponType.Troops <= 1)
				{
					goto IL_42;
				}
				return false;
				IL_42:
				return true;
			}

			// Token: 0x04000BD2 RID: 3026
			public Doctrine.Class276[] class276_0;

			// Token: 0x04000BD3 RID: 3027
			private Weapon weapon_0;
		}

		// Token: 0x02000230 RID: 560
		internal sealed class Class276
		{
			// Token: 0x0600117E RID: 4478 RVA: 0x00002977 File Offset: 0x00000B77
			public Class276()
			{
			}

			// Token: 0x0600117F RID: 4479 RVA: 0x0015CB9C File Offset: 0x0015AD9C
			public Class276(Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_1)
			{
				try
				{
					this._WRA_WeaponTargetType_0 = _WRA_WeaponTargetType_1;
					this.nullable_0 = null;
					this.nullable_1 = null;
					this.nullable_3 = null;
					this.nullable_2 = null;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101196", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}

			// Token: 0x06001180 RID: 4480 RVA: 0x0015CC30 File Offset: 0x0015AE30
			public Class276(Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_1, int? nullable_4, int? nullable_5, int? nullable_6, int? nullable_7)
			{
				try
				{
					this._WRA_WeaponTargetType_0 = _WRA_WeaponTargetType_1;
					this.nullable_0 = nullable_4;
					this.nullable_1 = nullable_5;
					this.nullable_3 = nullable_6;
					this.nullable_2 = nullable_7;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101203", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}

			// Token: 0x04000BD4 RID: 3028
			public Doctrine._WRA_WeaponTargetType _WRA_WeaponTargetType_0;

			// Token: 0x04000BD5 RID: 3029
			public int? nullable_0;

			// Token: 0x04000BD6 RID: 3030
			public int? nullable_1;

			// Token: 0x04000BD7 RID: 3031
			public int? nullable_2;

			// Token: 0x04000BD8 RID: 3032
			public int? nullable_3;
		}

		// Token: 0x02000231 RID: 561
		public enum _WRA_WeaponTargetType
		{
			// Token: 0x04000BDA RID: 3034
			None = 1001,
			// Token: 0x04000BDB RID: 3035
			Decoy,
			// Token: 0x04000BDC RID: 3036
			Air_Contact_Unknown_Type = 1999,
			// Token: 0x04000BDD RID: 3037
			Aircraft_Unspecified,
			// Token: 0x04000BDE RID: 3038
			Aircraft_5th_Generation,
			// Token: 0x04000BDF RID: 3039
			Aircraft_4th_Generation,
			// Token: 0x04000BE0 RID: 3040
			Aircraft_3rd_Generation,
			// Token: 0x04000BE1 RID: 3041
			Aircraft_Less_Capable,
			// Token: 0x04000BE2 RID: 3042
			Aircraft_High_Perf_Bombers = 2011,
			// Token: 0x04000BE3 RID: 3043
			Aircraft_Medium_Perf_Bombers,
			// Token: 0x04000BE4 RID: 3044
			Aircraft_Low_Perf_Bombers,
			// Token: 0x04000BE5 RID: 3045
			Aircraft_High_Perf_Recon_EW = 2021,
			// Token: 0x04000BE6 RID: 3046
			Aircraft_Medium_Perf_Recon_EW,
			// Token: 0x04000BE7 RID: 3047
			Aircraft_Low_Perf_Recon_EW,
			// Token: 0x04000BE8 RID: 3048
			Aircraft_AEW = 2031,
			// Token: 0x04000BE9 RID: 3049
			Aircraft_MicroUAV,
			// Token: 0x04000BEA RID: 3050
			Helicopter_Unspecified = 2100,
			// Token: 0x04000BEB RID: 3051
			Guided_Weapon_Unspecified = 2200,
			// Token: 0x04000BEC RID: 3052
			Guided_Weapon_Supersonic_Sea_Skimming,
			// Token: 0x04000BED RID: 3053
			Guided_Weapon_Subsonic_Sea_Skimming,
			// Token: 0x04000BEE RID: 3054
			Guided_Weapon_Supersonic,
			// Token: 0x04000BEF RID: 3055
			Guided_Weapon_Subsonic,
			// Token: 0x04000BF0 RID: 3056
			Guided_Weapon_Ballistic = 2211,
			// Token: 0x04000BF1 RID: 3057
			Satellite_Unspecified = 2300,
			// Token: 0x04000BF2 RID: 3058
			Surface_Contact_Unknown_Type = 2999,
			// Token: 0x04000BF3 RID: 3059
			Ship_Unspecified,
			// Token: 0x04000BF4 RID: 3060
			Ship_Carrier_0_25000_tons,
			// Token: 0x04000BF5 RID: 3061
			Ship_Carrier_25001_45000_tons,
			// Token: 0x04000BF6 RID: 3062
			Ship_Carrier_45001_95000_tons,
			// Token: 0x04000BF7 RID: 3063
			Ship_Carrier_95000_tons,
			// Token: 0x04000BF8 RID: 3064
			Ship_Surface_Combatant_0_500_tons = 3101,
			// Token: 0x04000BF9 RID: 3065
			Ship_Surface_Combatant_501_1500_tons,
			// Token: 0x04000BFA RID: 3066
			Ship_Surface_Combatant_1501_5000_tons,
			// Token: 0x04000BFB RID: 3067
			Ship_Surface_Combatant_5001_10000_tons,
			// Token: 0x04000BFC RID: 3068
			Ship_Surface_Combatant_10001_25000_tons,
			// Token: 0x04000BFD RID: 3069
			Ship_Surface_Combatant_25001_45000_tons,
			// Token: 0x04000BFE RID: 3070
			Ship_Surface_Combatant_45001_95000_tons,
			// Token: 0x04000BFF RID: 3071
			Ship_Surface_Combatant_95000_tons,
			// Token: 0x04000C00 RID: 3072
			Ship_Amphibious_0_500_tons = 3201,
			// Token: 0x04000C01 RID: 3073
			Ship_Amphibious_501_1500_tons,
			// Token: 0x04000C02 RID: 3074
			Ship_Amphibious_1501_5000_tons,
			// Token: 0x04000C03 RID: 3075
			Ship_Amphibious_5001_10000_tons,
			// Token: 0x04000C04 RID: 3076
			Ship_Amphibious_10001_25000_tons,
			// Token: 0x04000C05 RID: 3077
			Ship_Amphibious_25001_45000_tons,
			// Token: 0x04000C06 RID: 3078
			Ship_Amphibious_45001_95000_tons,
			// Token: 0x04000C07 RID: 3079
			Ship_Amphibious_95000_tons,
			// Token: 0x04000C08 RID: 3080
			Ship_Auxiliary_0_500_tons = 3301,
			// Token: 0x04000C09 RID: 3081
			Ship_Auxiliary_501_1500_tons,
			// Token: 0x04000C0A RID: 3082
			Ship_Auxiliary_1501_5000_tons,
			// Token: 0x04000C0B RID: 3083
			Ship_Auxiliary_5001_10000_tons,
			// Token: 0x04000C0C RID: 3084
			Ship_Auxiliary_10001_25000_tons,
			// Token: 0x04000C0D RID: 3085
			Ship_Auxiliary_25001_45000_tons,
			// Token: 0x04000C0E RID: 3086
			Ship_Auxiliary_45001_95000_tons,
			// Token: 0x04000C0F RID: 3087
			Ship_Auxiliary_95000_tons,
			// Token: 0x04000C10 RID: 3088
			Ship_Merchant_Civilian_0_500_tons = 3401,
			// Token: 0x04000C11 RID: 3089
			Ship_Merchant_Civilian_501_1500_tons,
			// Token: 0x04000C12 RID: 3090
			Ship_Merchant_Civilian_1501_5000_tons,
			// Token: 0x04000C13 RID: 3091
			Ship_Merchant_Civilian_5001_10000_tons,
			// Token: 0x04000C14 RID: 3092
			Ship_Merchant_Civilian_10001_25000_tons,
			// Token: 0x04000C15 RID: 3093
			Ship_Merchant_Civilian_25001_45000_tons,
			// Token: 0x04000C16 RID: 3094
			Ship_Merchant_Civilian_45001_95000_tons,
			// Token: 0x04000C17 RID: 3095
			Ship_Merchant_Civilian_95000_tons,
			// Token: 0x04000C18 RID: 3096
			Submarine_Surfaced = 3501,
			// Token: 0x04000C19 RID: 3097
			Subsurface_Contact_Unknown_Type = 3999,
			// Token: 0x04000C1A RID: 3098
			Submarine_Unspecified,
			// Token: 0x04000C1B RID: 3099
			Land_Contact_Unknown_Type = 4999,
			// Token: 0x04000C1C RID: 3100
			Land_Structure_Soft_Unspecified,
			// Token: 0x04000C1D RID: 3101
			Land_Structure_Soft_Building_Surface,
			// Token: 0x04000C1E RID: 3102
			Land_Structure_Soft_Building_Reveted,
			// Token: 0x04000C1F RID: 3103
			Land_Structure_Soft_Structure_Open = 5005,
			// Token: 0x04000C20 RID: 3104
			Land_Structure_Soft_Structure_Reveted,
			// Token: 0x04000C21 RID: 3105
			Land_Structure_Soft_Aerostat_Moring = 5011,
			// Token: 0x04000C22 RID: 3106
			Land_Structure_Hardened_Unspecified = 5100,
			// Token: 0x04000C23 RID: 3107
			Land_Structure_Hardened_Building_Surface,
			// Token: 0x04000C24 RID: 3108
			Land_Structure_Hardened_Building_Reveted,
			// Token: 0x04000C25 RID: 3109
			Land_Structure_Hardened_Building_Bunker,
			// Token: 0x04000C26 RID: 3110
			Land_Structure_Hardened_Building_Underground,
			// Token: 0x04000C27 RID: 3111
			Land_Structure_Hardened_Structure_Open,
			// Token: 0x04000C28 RID: 3112
			Land_Structure_Hardened_Structure_Reveted,
			// Token: 0x04000C29 RID: 3113
			Runway_Facility_Unspecified = 5200,
			// Token: 0x04000C2A RID: 3114
			Runway,
			// Token: 0x04000C2B RID: 3115
			Runway_Grade_Taxiway,
			// Token: 0x04000C2C RID: 3116
			Runway_Access_Point,
			// Token: 0x04000C2D RID: 3117
			Radar_Unspecified = 5300,
			// Token: 0x04000C2E RID: 3118
			Mobile_Target_Soft_Unspecified = 5400,
			// Token: 0x04000C2F RID: 3119
			Mobile_Target_Soft_Mobile_Vehicle,
			// Token: 0x04000C30 RID: 3120
			Mobile_Target_Soft_Mobile_Personnel,
			// Token: 0x04000C31 RID: 3121
			Mobile_Target_Hardened_Unspecified = 5500,
			// Token: 0x04000C32 RID: 3122
			Mobile_Target_Hardened_Mobile_Vehicle,
			// Token: 0x04000C33 RID: 3123
			Underwater_Structure = 5601,
			// Token: 0x04000C34 RID: 3124
			Air_Base_Single_Unit_Airfield = 5801
		}
	}
}
