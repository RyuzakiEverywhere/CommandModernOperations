using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Command_Core.DAL;
using DarkUI.Collections;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns13;
using ns14;
using ns8;
using ns9;

namespace Command_Core
{
	// Token: 0x0200011D RID: 285
	public abstract class ActiveUnit : Unit
	{
		// Token: 0x060006DA RID: 1754 RVA: 0x00006EBD File Offset: 0x000050BD
		[CompilerGenerated]
		public virtual ObservableList<Engine> vmethod_49()
		{
			return this.observableList_0;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000768E0 File Offset: 0x00074AE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void vmethod_50(ObservableList<Engine> observableList_2)
		{
			EventHandler<EventArgs5<Engine>> eventHandler_ = new EventHandler<EventArgs5<Engine>>(this.method_135);
			EventHandler<EventArgs5<Engine>> eventHandler_2 = new EventHandler<EventArgs5<Engine>>(this.method_136);
			ObservableList<Engine> observableList = this.observableList_0;
			if (observableList != null)
			{
				observableList.method_1(eventHandler_);
				observableList.method_3(eventHandler_2);
			}
			this.observableList_0 = observableList_2;
			observableList = this.observableList_0;
			if (observableList != null)
			{
				observableList.method_0(eventHandler_);
				observableList.method_2(eventHandler_2);
			}
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00006EC5 File Offset: 0x000050C5
		[CompilerGenerated]
		public virtual ObservableList<Mount> vmethod_51()
		{
			return this.observableList_1;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00076940 File Offset: 0x00074B40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void vmethod_52(ObservableList<Mount> observableList_2)
		{
			EventHandler<EventArgs5<Mount>> eventHandler_ = new EventHandler<EventArgs5<Mount>>(this.method_132);
			EventHandler<EventArgs5<Mount>> eventHandler_2 = new EventHandler<EventArgs5<Mount>>(this.method_133);
			ObservableList<Mount> observableList = this.observableList_1;
			if (observableList != null)
			{
				observableList.method_1(eventHandler_);
				observableList.method_3(eventHandler_2);
			}
			this.observableList_1 = observableList_2;
			observableList = this.observableList_1;
			if (observableList != null)
			{
				observableList.method_0(eventHandler_);
				observableList.method_2(eventHandler_2);
			}
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x000769A0 File Offset: 0x00074BA0
		[CompilerGenerated]
		public static void smethod_0(ActiveUnit.Delegate12 delegate12_1)
		{
			ActiveUnit.Delegate12 @delegate = ActiveUnit.delegate12_0;
			ActiveUnit.Delegate12 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit.Delegate12 value = (ActiveUnit.Delegate12)Delegate.Combine(delegate2, delegate12_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit.Delegate12>(ref ActiveUnit.delegate12_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x000769D4 File Offset: 0x00074BD4
		[CompilerGenerated]
		public static void smethod_1(ActiveUnit.Delegate12 delegate12_1)
		{
			ActiveUnit.Delegate12 @delegate = ActiveUnit.delegate12_0;
			ActiveUnit.Delegate12 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit.Delegate12 value = (ActiveUnit.Delegate12)Delegate.Remove(delegate2, delegate12_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit.Delegate12>(ref ActiveUnit.delegate12_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00076A08 File Offset: 0x00074C08
		[CompilerGenerated]
		public static void smethod_2(ActiveUnit.Delegate13 delegate13_1)
		{
			ActiveUnit.Delegate13 @delegate = ActiveUnit.delegate13_0;
			ActiveUnit.Delegate13 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit.Delegate13 value = (ActiveUnit.Delegate13)Delegate.Combine(delegate2, delegate13_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit.Delegate13>(ref ActiveUnit.delegate13_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00076A3C File Offset: 0x00074C3C
		[CompilerGenerated]
		public static void smethod_3(ActiveUnit.Delegate13 delegate13_1)
		{
			ActiveUnit.Delegate13 @delegate = ActiveUnit.delegate13_0;
			ActiveUnit.Delegate13 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit.Delegate13 value = (ActiveUnit.Delegate13)Delegate.Remove(delegate2, delegate13_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit.Delegate13>(ref ActiveUnit.delegate13_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00076A70 File Offset: 0x00074C70
		[CompilerGenerated]
		public static void smethod_4(ActiveUnit.Delegate14 delegate14_1)
		{
			ActiveUnit.Delegate14 @delegate = ActiveUnit.delegate14_0;
			ActiveUnit.Delegate14 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit.Delegate14 value = (ActiveUnit.Delegate14)Delegate.Combine(delegate2, delegate14_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit.Delegate14>(ref ActiveUnit.delegate14_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00076AA4 File Offset: 0x00074CA4
		[CompilerGenerated]
		public static void smethod_5(ActiveUnit.Delegate14 delegate14_1)
		{
			ActiveUnit.Delegate14 @delegate = ActiveUnit.delegate14_0;
			ActiveUnit.Delegate14 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit.Delegate14 value = (ActiveUnit.Delegate14)Delegate.Remove(delegate2, delegate14_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit.Delegate14>(ref ActiveUnit.delegate14_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00076AD8 File Offset: 0x00074CD8
		[CompilerGenerated]
		public static void smethod_6(ActiveUnit.Delegate15 delegate15_1)
		{
			ActiveUnit.Delegate15 @delegate = ActiveUnit.delegate15_0;
			ActiveUnit.Delegate15 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit.Delegate15 value = (ActiveUnit.Delegate15)Delegate.Combine(delegate2, delegate15_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit.Delegate15>(ref ActiveUnit.delegate15_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00076B0C File Offset: 0x00074D0C
		[CompilerGenerated]
		public static void smethod_7(ActiveUnit.Delegate15 delegate15_1)
		{
			ActiveUnit.Delegate15 @delegate = ActiveUnit.delegate15_0;
			ActiveUnit.Delegate15 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit.Delegate15 value = (ActiveUnit.Delegate15)Delegate.Remove(delegate2, delegate15_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit.Delegate15>(ref ActiveUnit.delegate15_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00006ECD File Offset: 0x000050CD
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x00076B40 File Offset: 0x00074D40
		public override string Name
		{
			get
			{
				return base.Name;
			}
			set
			{
				Operators.CompareString(base.Name, value, false);
				base.Name = value;
				ActiveUnit.Delegate13 @delegate = ActiveUnit.delegate13_0;
				if (@delegate != null)
				{
					@delegate(this.string_0);
				}
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00076B78 File Offset: 0x00074D78
		public double? method_56()
		{
			if (this.nullable_11 == null)
			{
				this.nullable_11 = new double?(this.vmethod_30(null));
			}
			return this.nullable_11;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00006ED5 File Offset: 0x000050D5
		public void method_57(double? nullable_16)
		{
			this.nullable_11 = nullable_16;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00076BB4 File Offset: 0x00074DB4
		public double? method_58()
		{
			if (this.nullable_10 == null)
			{
				this.nullable_10 = new double?(this.vmethod_28(null));
			}
			return this.nullable_10;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00006EDE File Offset: 0x000050DE
		public void method_59(double? nullable_16)
		{
			this.nullable_10 = nullable_16;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00006EE7 File Offset: 0x000050E7
		public int method_60()
		{
			return this.int_4;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00006EEF File Offset: 0x000050EF
		public void method_61(int int_6)
		{
			this.int_4 = int_6;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00076BF0 File Offset: 0x00074DF0
		public override float vmethod_18()
		{
			float result;
			if (this.vmethod_6())
			{
				result = this.float_3;
			}
			else if (!this.bool_8 && !this.bool_6)
			{
				float num = this.vmethod_14(false) - base.method_18();
				if (num == 0f)
				{
					result = 0f;
				}
				else
				{
					double x = (double)this.vmethod_40() * 0.514444 * (double)this.scenario_0.method_40();
					double num2 = Math.Atan2((double)Math.Abs(num), x) * 57.2957795130823;
					if (num > 0f)
					{
						result = (float)num2;
					}
					else
					{
						result = -(float)num2;
					}
				}
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00006EF8 File Offset: 0x000050F8
		public override void vmethod_19(float float_25)
		{
			base.vmethod_19(float_25);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00076C90 File Offset: 0x00074E90
		public short method_62()
		{
			GlobalVariables.ProficiencyLevel? proficiencyLevel = this.vmethod_53();
			int? num = (proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
			short result;
			if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				result = this.short_1 * 2;
			}
			else
			{
				num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					result = (short)Math.Round((double)this.short_1 * 1.5);
				}
				else
				{
					num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						result = (short)Math.Round((double)this.short_1 * 1.2);
					}
					else
					{
						num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							result = this.short_1;
						}
						else
						{
							num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								result = (short)Math.Round((double)this.short_1 * 0.8);
							}
							else if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00076EB0 File Offset: 0x000750B0
		public override double vmethod_28(bool? _HintIsOperating = null)
		{
			bool flag;
			if (_HintIsOperating != null)
			{
				flag = _HintIsOperating.Value;
			}
			else
			{
				flag = this.vmethod_127();
			}
			double result;
			if (flag)
			{
				result = base.vmethod_28(null);
			}
			else
			{
				ActiveUnit activeUnit = this.vmethod_93().method_17();
				if (activeUnit == null)
				{
					if (!this.bool_24)
					{
						bool isAttached = Debugger.IsAttached;
					}
					result = 0.0;
				}
				else
				{
					result = activeUnit.vmethod_28(null);
				}
			}
			return result;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00076F28 File Offset: 0x00075128
		public override void vmethod_29(bool? _HintIsOperating = null, double value)
		{
			base.vmethod_29(null, value);
			this.vmethod_93().method_3();
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00076F50 File Offset: 0x00075150
		public override double vmethod_30(bool? _HintIsOperating = null)
		{
			bool flag;
			if (_HintIsOperating != null)
			{
				flag = _HintIsOperating.Value;
			}
			else
			{
				flag = this.vmethod_127();
			}
			double result;
			if (flag)
			{
				result = base.vmethod_30(null);
			}
			else
			{
				ActiveUnit activeUnit = this.vmethod_93().method_17();
				if (activeUnit == null)
				{
					if (!this.bool_24)
					{
						bool isAttached = Debugger.IsAttached;
					}
					result = 0.0;
				}
				else
				{
					result = activeUnit.vmethod_30(null);
				}
			}
			return result;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00076FC8 File Offset: 0x000751C8
		public override void vmethod_31(bool? _HintIsOperating = null, double value)
		{
			base.vmethod_31(null, value);
			this.vmethod_93().method_3();
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00006F01 File Offset: 0x00005101
		public override float vmethod_9()
		{
			return base.vmethod_9();
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00006F09 File Offset: 0x00005109
		public override void vmethod_10(float float_25)
		{
			base.vmethod_10(float_25);
			this.vmethod_93().method_3();
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00076FF0 File Offset: 0x000751F0
		public virtual GlobalVariables.ProficiencyLevel? vmethod_53()
		{
			GlobalVariables.ProficiencyLevel? result;
			if (this.nullable_15 == null)
			{
				result = new GlobalVariables.ProficiencyLevel?(this.vmethod_7(false).method_24());
			}
			else
			{
				result = new GlobalVariables.ProficiencyLevel?(this.nullable_15.Value);
			}
			return result;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00006F1D File Offset: 0x0000511D
		public virtual void vmethod_54(GlobalVariables.ProficiencyLevel? nullable_16)
		{
			this.nullable_15 = nullable_16;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00077034 File Offset: 0x00075234
		public virtual bool vmethod_55()
		{
			bool result;
			if (this.vmethod_127())
			{
				result = true;
			}
			else
			{
				ActiveUnit_DockingOps._DockingOpsCondition dockingOpsCondition = this.vmethod_93().method_8();
				if (dockingOpsCondition != ActiveUnit_DockingOps._DockingOpsCondition.Docked)
				{
					if (dockingOpsCondition != ActiveUnit_DockingOps._DockingOpsCondition.Readying)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0007706C File Offset: 0x0007526C
		public string method_63()
		{
			if (string.IsNullOrEmpty(this.string_8))
			{
				switch (this.vmethod_56())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					this.string_8 = "Aircraft";
					goto IL_AE;
				case GlobalVariables.ActiveUnitType.Ship:
					this.string_8 = "Ship";
					goto IL_AE;
				case GlobalVariables.ActiveUnitType.Submarine:
					this.string_8 = "Submarine";
					goto IL_AE;
				case GlobalVariables.ActiveUnitType.Facility:
					this.string_8 = "Facility";
					goto IL_AE;
				case GlobalVariables.ActiveUnitType.Weapon:
					this.string_8 = "Weapon";
					goto IL_AE;
				case GlobalVariables.ActiveUnitType.Satellite:
					this.string_8 = "Satellite";
					goto IL_AE;
				}
				if (!Debugger.IsAttached)
				{
					return this.vmethod_56().ToString();
				}
				Debugger.Break();
			}
			IL_AE:
			return this.string_8;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00077130 File Offset: 0x00075330
		public XSection[] method_64()
		{
			if (this.xsection_0 == null)
			{
				string text = this.method_63() + "_" + Conversions.ToString(this.DBID);
				if (this.scenario_0.Cache_XSections.ContainsKey(text))
				{
					this.xsection_0 = this.scenario_0.Cache_XSections[text];
				}
				else
				{
					this.xsection_0 = DBFunctions.smethod_106(this);
					this.scenario_0.Cache_XSections.TryAdd(text, this.xsection_0);
				}
			}
			return this.xsection_0;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00003024 File Offset: 0x00001224
		public virtual GlobalVariables.ActiveUnitType vmethod_56()
		{
			return GlobalVariables.ActiveUnitType.None;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x000771B8 File Offset: 0x000753B8
		public virtual int vmethod_57()
		{
			switch (this.vmethod_56())
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				return DBFunctions.smethod_20(ref this.scenario_0, this.DBID);
			case GlobalVariables.ActiveUnitType.Ship:
				return DBFunctions.smethod_22(ref this.scenario_0, this.DBID);
			case GlobalVariables.ActiveUnitType.Submarine:
				return DBFunctions.smethod_24(ref this.scenario_0, this.DBID);
			case GlobalVariables.ActiveUnitType.Facility:
				return DBFunctions.smethod_26(ref this.scenario_0, this.DBID);
			case GlobalVariables.ActiveUnitType.Weapon:
				return DBFunctions.smethod_29(ref this.scenario_0, this.DBID);
			case GlobalVariables.ActiveUnitType.Satellite:
				return DBFunctions.smethod_27(ref this.scenario_0, this.DBID);
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0007727C File Offset: 0x0007547C
		public virtual string vmethod_58()
		{
			switch (this.vmethod_56())
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				return DBFunctions.smethod_21(ref this.scenario_0, this.DBID);
			case GlobalVariables.ActiveUnitType.Ship:
				return DBFunctions.smethod_23(ref this.scenario_0, this.DBID);
			case GlobalVariables.ActiveUnitType.Submarine:
				return DBFunctions.smethod_25(ref this.scenario_0, this.DBID);
			case GlobalVariables.ActiveUnitType.Facility:
				return DBFunctions.smethod_35(ref this.scenario_0, this.DBID, this.vmethod_89().vmethod_4().Count);
			case GlobalVariables.ActiveUnitType.Weapon:
				return DBFunctions.smethod_30(ref this.scenario_0, this.DBID);
			case GlobalVariables.ActiveUnitType.Satellite:
				return DBFunctions.smethod_28(ref this.scenario_0, this.DBID);
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			return this.vmethod_56().ToString();
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00077368 File Offset: 0x00075568
		public bool method_65()
		{
			switch (this.vmethod_56())
			{
			case GlobalVariables.ActiveUnitType.None:
			case GlobalVariables.ActiveUnitType.Ship:
			case GlobalVariables.ActiveUnitType.Submarine:
			case GlobalVariables.ActiveUnitType.Facility:
				return false;
			case GlobalVariables.ActiveUnitType.Aircraft:
			case GlobalVariables.ActiveUnitType.Satellite:
				return true;
			case GlobalVariables.ActiveUnitType.Weapon:
			{
				Weapon._WeaponType weaponType = ((Weapon)this).method_167();
				if (weaponType <= Weapon._WeaponType.GuidedProjectile)
				{
					if (weaponType - Weapon._WeaponType.GuidedWeapon <= 2 || weaponType == Weapon._WeaponType.GuidedProjectile)
					{
						goto IL_83;
					}
				}
				else
				{
					if (weaponType - Weapon._WeaponType.BallisticMissile <= 1)
					{
						goto IL_83;
					}
					if (weaponType == Weapon._WeaponType.HGV)
					{
						goto IL_83;
					}
				}
				return false;
				IL_83:
				return true;
			}
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			return false;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00077400 File Offset: 0x00075600
		public bool method_66()
		{
			GlobalVariables.ActiveUnitType activeUnitType = this.vmethod_56();
			bool result;
			if (activeUnitType == GlobalVariables.ActiveUnitType.Facility)
			{
				Facility._FacilityCategory facilityCategory_ = ((Facility)this)._FacilityCategory_0;
				if (facilityCategory_ - Facility._FacilityCategory.Runway > 2 && facilityCategory_ - Facility._FacilityCategory.Building_Bunker > 1)
				{
					if (facilityCategory_ != Facility._FacilityCategory.AirBase)
					{
						return false;
					}
				}
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00077450 File Offset: 0x00075650
		public bool method_67(Side side_1)
		{
			return this.method_92(side_1);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00077470 File Offset: 0x00075670
		public bool method_68()
		{
			return this.vmethod_101() != null && this.vmethod_101().method_12() && this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x000774AC File Offset: 0x000756AC
		public bool method_69()
		{
			return this.vmethod_101() != null && this.vmethod_101().method_12() && this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x000774E8 File Offset: 0x000756E8
		public bool method_70()
		{
			return this.vmethod_101() != null && this.vmethod_101().method_12() && this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Mining;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00077524 File Offset: 0x00075724
		public bool method_71()
		{
			return this.vmethod_101() != null && this.vmethod_101().method_12() && this.vmethod_101()._MissionClass_0 == Mission._MissionClass.MineClearing;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00077560 File Offset: 0x00075760
		public bool method_72()
		{
			return this.vmethod_101() != null && this.vmethod_101().method_12() && this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Cargo;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0007759C File Offset: 0x0007579C
		public bool method_73()
		{
			return this.vmethod_101() != null && this.vmethod_101().method_12() && this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Ferry;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00003024 File Offset: 0x00001224
		public virtual bool vmethod_59()
		{
			return false;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00003024 File Offset: 0x00001224
		public virtual bool vmethod_60()
		{
			return false;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00003024 File Offset: 0x00001224
		public virtual ActiveUnit._ActiveUnitFuelState vmethod_61(GeoPoint geoPoint_0, Doctrine._FuelState? nullable_16)
		{
			return ActiveUnit._ActiveUnitFuelState.None;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x000775D8 File Offset: 0x000757D8
		public virtual ActiveUnit._ActiveUnitFuelState vmethod_62(ActiveUnit activeUnit_0, GeoPoint geoPoint_0, Doctrine._FuelState? nullable_16)
		{
			ActiveUnit._ActiveUnitFuelState result;
			try
			{
				if (this.vmethod_114(ActiveUnit.Throttle.Cruise, null, null, null) <= 900L)
				{
					result = ActiveUnit._ActiveUnitFuelState.IsBingo;
				}
				else
				{
					float num;
					if (geoPoint_0 == null)
					{
						num = base.method_36(activeUnit_0);
					}
					else
					{
						float num2 = activeUnit_0.method_23(geoPoint_0);
						num = base.method_23(geoPoint_0) + num2;
					}
					if ((double)this.vmethod_87().vmethod_24(true, null, null) >= (double)num * 1.1)
					{
						result = ActiveUnit._ActiveUnitFuelState.None;
					}
					else
					{
						result = ActiveUnit._ActiveUnitFuelState.IsBingo;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101183", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x000776B0 File Offset: 0x000758B0
		public Weather.WeatherProfile method_74()
		{
			Scenario.WeatherModellingLevel weatherLevel = this.scenario_0.WeatherLevel;
			if (weatherLevel != Scenario.WeatherModellingLevel.Level0)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw new NotImplementedException();
			}
			return Weather.smethod_0(this.scenario_0, this.vmethod_30(null), this.vmethod_28(null), (int)Math.Round((double)this.vmethod_14(false)));
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00006F26 File Offset: 0x00005126
		public virtual float vmethod_63(bool ScenEditAction = false, Weapon theWeapon = null)
		{
			return this.float_14;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00077718 File Offset: 0x00075918
		public virtual void vmethod_64(bool ScenEditAction = false, Weapon theWeapon = null, float value)
		{
			try
			{
				bool flag = this.float_14 != value;
				float num = this.vmethod_91().method_0();
				float num2 = this.float_14;
				if (this.bool_8 && this.vmethod_99() != null && Enumerable.Any<AirFacility>(Enumerable.Where<AirFacility>(this.vmethod_99(), (ActiveUnit._Closure$__.$I203-0 == null) ? (ActiveUnit._Closure$__.$I203-0 = new Func<AirFacility, bool>(ActiveUnit._Closure$__.$I.method_0)) : ActiveUnit._Closure$__.$I203-0)))
				{
					value = Math.Max(1f, value);
				}
				this.float_14 = value;
				float num3 = this.vmethod_91().method_0();
				if (!ScenEditAction)
				{
					if (this.float_14 <= 0f && num2 > 0f)
					{
						if (this.bool_6)
						{
							((Ship)this).method_155(num);
						}
						else
						{
							this.scenario_0.method_65(this);
						}
					}
					if ((!this.bool_6 || !((Ship)this).method_152()) && (flag || num != num3) && value < num2)
					{
						List<EventTrigger> list = new List<EventTrigger>();
						try
						{
							foreach (EventTrigger eventTrigger in this.scenario_0.vmethod_4().Values)
							{
								if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.UnitDamaged && ((Class336)eventTrigger).method_8(this, num, num3, theWeapon))
								{
									list.Add(eventTrigger);
								}
							}
						}
						finally
						{
							IEnumerator<EventTrigger> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						this.scenario_0.method_24(list);
						this.float_15 = value;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101184", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x000778F4 File Offset: 0x00075AF4
		public ActiveUnit.Enum29 method_75()
		{
			ActiveUnit.Enum29 result;
			if (this.vmethod_14(false) < 8000f)
			{
				result = ActiveUnit.Enum29.const_0;
			}
			else
			{
				if (this.bool_2)
				{
					if (this.vmethod_49().Count > 0)
					{
						Engine.Enum112 enum112_ = this.vmethod_49()[0].enum112_0;
						if (enum112_ <= Engine.Enum112.const_9)
						{
							if (enum112_ != Engine.Enum112.const_0 && enum112_ != Engine.Enum112.const_9)
							{
								goto IL_75;
							}
						}
						else if (enum112_ != Engine.Enum112.const_10 && enum112_ != Engine.Enum112.const_14)
						{
							goto IL_75;
						}
						return ActiveUnit.Enum29.const_0;
					}
					return ActiveUnit.Enum29.const_0;
				}
				IL_75:
				Weather.Struct46 @struct = default(Weather.Struct46);
				Weather.smethod_2(Weather.Enum140.const_5, (int)Math.Round((double)this.vmethod_14(false)), ref @struct, null);
				if (@struct.double_1 > 233.0)
				{
					result = ActiveUnit.Enum29.const_0;
				}
				else
				{
					switch (this.vmethod_121())
					{
					case GlobalVariables.TargetVisualSizeClass.Stealthy:
						result = ActiveUnit.Enum29.const_0;
						break;
					case GlobalVariables.TargetVisualSizeClass.VSmall:
						result = ActiveUnit.Enum29.const_1;
						break;
					case GlobalVariables.TargetVisualSizeClass.Small:
						result = ActiveUnit.Enum29.const_2;
						break;
					case GlobalVariables.TargetVisualSizeClass.Medium:
						result = ActiveUnit.Enum29.const_3;
						break;
					case GlobalVariables.TargetVisualSizeClass.Large:
						result = ActiveUnit.Enum29.const_4;
						break;
					case GlobalVariables.TargetVisualSizeClass.VLarge:
						result = ActiveUnit.Enum29.const_5;
						break;
					default:
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw new NotImplementedException();
					}
				}
			}
			return result;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00077A04 File Offset: 0x00075C04
		public bool method_76(Strike strike_0)
		{
			return strike_0.hashSet_0.Count != 0 && strike_0.hashSet_0.Contains(this);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00006F2E File Offset: 0x0000512E
		public override float vmethod_14(bool DoSanityCheck = false)
		{
			return base.vmethod_14(false);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00077A38 File Offset: 0x00075C38
		public override void vmethod_15(bool DoSanityCheck = false, float value)
		{
			if (DoSanityCheck)
			{
				float num = this.vmethod_87().vmethod_30();
				float num2 = this.vmethod_87().vmethod_31();
				if (this.bool_2 && ((Weapon)this).method_167() == Weapon._WeaponType.Sonobuoy)
				{
					num2 = (float)base.method_9(false, false, false);
				}
				if (value > num)
				{
					value = num;
				}
				if (value < num2)
				{
					value = num2;
				}
			}
			if (value != this.vmethod_14(false) && this.bool_5)
			{
				((Submarine)this).method_147(null);
			}
			base.vmethod_15(false, value);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00077ABC File Offset: 0x00075CBC
		public override Side vmethod_7(bool SetSideOnly = false)
		{
			if (this.side_0 == null)
			{
				foreach (Side side in this.scenario_0.method_44())
				{
					if (Enumerable.Contains<ActiveUnit>(side.activeUnit_0, this) || Operators.CompareString(side.method_51(), this.string_7, false) == 0)
					{
						this.side_0 = side;
						break;
					}
				}
			}
			return this.side_0;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00077B20 File Offset: 0x00075D20
		public override void vmethod_8(bool SetSideOnly = false, Side value)
		{
			if (value != this.side_0)
			{
				if (SetSideOnly)
				{
					if (this.side_0 != null)
					{
						Class429.smethod_1(ref this.side_0.activeUnit_0, this);
						if (this.method_120() && this.vmethod_65(false).vmethod_7(false) != value)
						{
							this.vmethod_65(false).vmethod_141().Remove(new KeyValuePair<string, ActiveUnit>(this.string_0, this));
							this.vmethod_66(false, null);
						}
						if (this.vmethod_101() != null)
						{
							Mission value2 = null;
							bool setMissionOnly = false;
							Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
							this.vmethod_102(value2, setMissionOnly, ref missionAssignmentAttemptResult);
						}
						ActiveUnit_AI activeUnit_AI = this.vmethod_86();
						ActiveUnit activeUnit = this;
						activeUnit_AI.method_33(ref activeUnit);
						this.vmethod_86().method_34();
					}
					if (value != null)
					{
						Class429.smethod_0(ref value.activeUnit_0, this);
					}
				}
				this.side_0 = value;
				this.string_7 = this.side_0.method_51();
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00006F37 File Offset: 0x00005137
		public virtual Group vmethod_65(bool UsingMissionPlanner = false)
		{
			return this.group_0;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00077BEC File Offset: 0x00075DEC
		public virtual void vmethod_66(bool UsingMissionPlanner = false, Group value)
		{
			bool flag;
			if (flag = (value != this.group_0))
			{
				Group group = this.group_0;
				if (group != null)
				{
					group.vmethod_141().Remove(this.string_0);
				}
				this.group_0 = value;
				if (value != null)
				{
					value.vmethod_141().Add(this.string_0, this);
				}
				if (value != null && value.scenario_0 == null)
				{
					value.scenario_0 = this.scenario_0;
				}
				if (!UsingMissionPlanner && flag && value != null && !this.method_122())
				{
					this.vmethod_85().vmethod_9();
					this.vmethod_85().method_54(this.vmethod_28(null), this.vmethod_30(null), false);
					this.vmethod_85().vmethod_10();
				}
				if (flag)
				{
					ActiveUnit.Delegate12 @delegate = ActiveUnit.delegate12_0;
					if (@delegate != null)
					{
						@delegate(this.string_0);
					}
				}
				if (value == null)
				{
					this.vmethod_85().method_3(null);
				}
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00006F3F File Offset: 0x0000513F
		public virtual FuelRec[] vmethod_67()
		{
			return this.fuelRec_0;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00006F47 File Offset: 0x00005147
		public override float vmethod_22()
		{
			return base.vmethod_22();
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00006F4F File Offset: 0x0000514F
		public override void vmethod_23(float float_25)
		{
			base.vmethod_23(float_25);
			this.vmethod_86().bool_6 = true;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00006F64 File Offset: 0x00005164
		public virtual float vmethod_68()
		{
			return this.float_9;
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00006F6C File Offset: 0x0000516C
		public virtual void vmethod_69(ActiveUnit.Enum28 enum28_1, float float_25)
		{
			if (float.IsNaN(float_25))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					return;
				}
			}
			else
			{
				this.float_9 = float_25;
				this.vmethod_79(enum28_1);
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00006F91 File Offset: 0x00005191
		public virtual float vmethod_70()
		{
			return this.float_10;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00077CD4 File Offset: 0x00075ED4
		public virtual void vmethod_71(float float_25)
		{
			if (float_25 > 0f)
			{
				float num = (float)this.vmethod_87().vmethod_38();
				if (float_25 > num)
				{
					float_25 = num;
				}
			}
			float num2 = this.vmethod_87().vmethod_32(this.vmethod_14(false), false);
			if (float_25 < num2)
			{
				float_25 = num2;
			}
			this.float_10 = float_25;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00006F99 File Offset: 0x00005199
		public virtual float vmethod_72()
		{
			return this.float_11;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00077D20 File Offset: 0x00075F20
		public virtual void vmethod_73(float float_25)
		{
			float num = this.vmethod_87().vmethod_30();
			if (float_25 > num)
			{
				float_25 = num;
			}
			float_25 = (float)Math.Round((double)float_25, 2);
			bool flag = float_25 != this.float_11;
			this.float_11 = float_25;
			if (flag)
			{
				this.vmethod_86().bool_6 = false;
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00006FA1 File Offset: 0x000051A1
		public virtual float vmethod_74()
		{
			return this.float_12;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00077D6C File Offset: 0x00075F6C
		public virtual void vmethod_75(float float_25)
		{
			float num = this.vmethod_87().vmethod_30();
			if (float_25 > num)
			{
				float_25 = num;
			}
			float_25 = (float)Math.Round((double)float_25, 2);
			this.float_12 = float_25;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00003024 File Offset: 0x00001224
		public virtual bool vmethod_76(ActiveUnit activeUnit_0)
		{
			return false;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0000378C File Offset: 0x0000198C
		public virtual void vmethod_77(ActiveUnit activeUnit_0, bool bool_27)
		{
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00006FA9 File Offset: 0x000051A9
		public virtual ActiveUnit.Enum28 vmethod_78()
		{
			return this.enum28_0;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00006FB1 File Offset: 0x000051B1
		public virtual void vmethod_79(ActiveUnit.Enum28 enum28_1)
		{
			this.enum28_0 = enum28_1;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00006FBA File Offset: 0x000051BA
		public virtual Waypoint.Enum81 vmethod_80()
		{
			return this.enum81_0;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00006FC2 File Offset: 0x000051C2
		public virtual void vmethod_81(Waypoint.Enum81 enum81_1)
		{
			this.enum81_0 = enum81_1;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00077DA0 File Offset: 0x00075FA0
		public virtual ActiveUnit.Throttle vmethod_82()
		{
			if (this.nullable_12 == null)
			{
				if (this.vmethod_49().Count == 0)
				{
					this.nullable_12 = new ActiveUnit.Throttle?(ActiveUnit.Throttle.FullStop);
				}
				else if (this.vmethod_87().vmethod_34())
				{
					this.nullable_12 = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Flank);
				}
				else if (this.vmethod_87().method_10())
				{
					this.nullable_12 = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Full);
				}
				else
				{
					this.nullable_12 = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
				}
			}
			return this.nullable_12.Value;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00077E24 File Offset: 0x00076024
		public virtual ActiveUnit.Throttle vmethod_83()
		{
			ActiveUnit.Throttle result;
			if (this.bool_3 && !((Aircraft)this).method_169())
			{
				result = ActiveUnit.Throttle.Loiter;
			}
			else
			{
				result = ActiveUnit.Throttle.FullStop;
			}
			return result;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00006FCB File Offset: 0x000051CB
		public virtual ActiveUnit.Throttle vmethod_84()
		{
			return this.throttle_0;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00077E50 File Offset: 0x00076050
		public virtual ActiveUnit_Navigator vmethod_85()
		{
			if (this.activeUnit_Navigator_0 == null)
			{
				if (this.bool_1)
				{
					return ((Group)this).vmethod_85();
				}
				switch (this.vmethod_56())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					return ((Aircraft)this).method_157();
				case GlobalVariables.ActiveUnitType.Ship:
					return ((Ship)this).method_144();
				case GlobalVariables.ActiveUnitType.Submarine:
					return ((Submarine)this).method_152();
				case GlobalVariables.ActiveUnitType.Facility:
					return ((Facility)this).method_147();
				case GlobalVariables.ActiveUnitType.Weapon:
					return ((Weapon)this).method_187();
				}
				ActiveUnit activeUnit = this;
				this.activeUnit_Navigator_0 = new ActiveUnit_Navigator(ref activeUnit);
			}
			return this.activeUnit_Navigator_0;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00077F0C File Offset: 0x0007610C
		public virtual ActiveUnit_AI vmethod_86()
		{
			if (this.activeUnit_AI_0 == null)
			{
				if (this.bool_1)
				{
					return ((Group)this).vmethod_86();
				}
				switch (this.vmethod_56())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					return ((Aircraft)this).method_158();
				case GlobalVariables.ActiveUnitType.Ship:
					return ((Ship)this).method_145();
				case GlobalVariables.ActiveUnitType.Submarine:
					return ((Submarine)this).method_153();
				case GlobalVariables.ActiveUnitType.Facility:
					return ((Facility)this).method_148();
				case GlobalVariables.ActiveUnitType.Weapon:
					return ((Weapon)this).vmethod_142();
				}
				this.activeUnit_AI_0 = new ActiveUnit_AI(this);
			}
			return this.activeUnit_AI_0;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00077FC4 File Offset: 0x000761C4
		public virtual ActiveUnit_Kinematics vmethod_87()
		{
			if (this.activeUnit_Kinematics_0 == null)
			{
				if (this.bool_1)
				{
					return ((Group)this).method_145();
				}
				switch (this.vmethod_56())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					return ((Aircraft)this).method_159();
				case GlobalVariables.ActiveUnitType.Ship:
					return ((Ship)this).method_146();
				case GlobalVariables.ActiveUnitType.Submarine:
					return ((Submarine)this).method_154();
				case GlobalVariables.ActiveUnitType.Facility:
					return ((Facility)this).method_149();
				case GlobalVariables.ActiveUnitType.Weapon:
					return ((Weapon)this).vmethod_143();
				case GlobalVariables.ActiveUnitType.Satellite:
					return ((Satellite)this).method_142();
				}
				ActiveUnit activeUnit = this;
				this.activeUnit_Kinematics_0 = new ActiveUnit_Kinematics(ref activeUnit);
			}
			return this.activeUnit_Kinematics_0;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00078090 File Offset: 0x00076290
		public virtual ActiveUnit_Sensory vmethod_88()
		{
			if (this.activeUnit_Sensory_0 == null)
			{
				if (this.bool_1)
				{
					return ((Group)this).vmethod_88();
				}
				switch (this.vmethod_56())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					return ((Aircraft)this).method_160();
				case GlobalVariables.ActiveUnitType.Ship:
					return ((Ship)this).method_147();
				case GlobalVariables.ActiveUnitType.Submarine:
					return ((Submarine)this).method_155();
				case GlobalVariables.ActiveUnitType.Facility:
					return ((Facility)this).method_150();
				case GlobalVariables.ActiveUnitType.Weapon:
					return ((Weapon)this).method_188();
				}
				ActiveUnit activeUnit = this;
				this.activeUnit_Sensory_0 = new ActiveUnit_Sensory(ref activeUnit);
			}
			return this.activeUnit_Sensory_0;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0007814C File Offset: 0x0007634C
		public virtual ActiveUnit_Weaponry vmethod_89()
		{
			if (this.activeUnit_Weaponry_0 == null)
			{
				if (this.bool_1)
				{
					return ((Group)this).vmethod_89();
				}
				switch (this.vmethod_56())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					return ((Aircraft)this).method_161();
				case GlobalVariables.ActiveUnitType.Ship:
					return ((Ship)this).method_148();
				case GlobalVariables.ActiveUnitType.Submarine:
					return ((Submarine)this).method_156();
				case GlobalVariables.ActiveUnitType.Facility:
					return ((Facility)this).method_151();
				default:
					this.activeUnit_Weaponry_0 = new ActiveUnit_Weaponry(this);
					break;
				}
			}
			return this.activeUnit_Weaponry_0;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000781E4 File Offset: 0x000763E4
		public virtual ActiveUnit_CommStuff vmethod_90()
		{
			if (this.activeUnit_CommStuff_0 == null)
			{
				if (this.bool_1)
				{
					return ((Group)this).vmethod_90();
				}
				switch (this.vmethod_56())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					return ((Aircraft)this).method_162();
				case GlobalVariables.ActiveUnitType.Ship:
					return ((Ship)this).method_149();
				case GlobalVariables.ActiveUnitType.Submarine:
					return ((Submarine)this).method_157();
				case GlobalVariables.ActiveUnitType.Facility:
					return ((Facility)this).method_152();
				case GlobalVariables.ActiveUnitType.Weapon:
					return ((Weapon)this).method_189();
				}
				ActiveUnit activeUnit = this;
				this.activeUnit_CommStuff_0 = new ActiveUnit_CommStuff(ref activeUnit);
			}
			return this.activeUnit_CommStuff_0;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000782A0 File Offset: 0x000764A0
		public virtual ActiveUnit_Damage vmethod_91()
		{
			if (this.activeUnit_Damage_0 == null)
			{
				if (this.bool_1)
				{
					return ((Group)this).method_146();
				}
				switch (this.vmethod_56())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					return ((Aircraft)this).method_163();
				case GlobalVariables.ActiveUnitType.Ship:
					return ((Ship)this).method_150();
				case GlobalVariables.ActiveUnitType.Submarine:
					return ((Submarine)this).method_158();
				case GlobalVariables.ActiveUnitType.Facility:
					return ((Facility)this).method_153();
				case GlobalVariables.ActiveUnitType.Weapon:
					return ((Weapon)this).method_190();
				case GlobalVariables.ActiveUnitType.Satellite:
					return ((Satellite)this).method_143();
				}
				ActiveUnit activeUnit = this;
				this.activeUnit_Damage_0 = new ActiveUnit_Damage(ref activeUnit);
			}
			return this.activeUnit_Damage_0;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0007836C File Offset: 0x0007656C
		public virtual ActiveUnit_AirOps vmethod_92()
		{
			if (this.activeUnit_AirOps_0 == null)
			{
				if (this.bool_1)
				{
					return ((Group)this).vmethod_92();
				}
				GlobalVariables.ActiveUnitType activeUnitType = this.vmethod_56();
				if (activeUnitType == GlobalVariables.ActiveUnitType.Aircraft)
				{
					return ((Aircraft)this).method_164();
				}
				ActiveUnit activeUnit = this;
				this.activeUnit_AirOps_0 = new ActiveUnit_AirOps(ref activeUnit);
			}
			return this.activeUnit_AirOps_0;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000783C8 File Offset: 0x000765C8
		public virtual ActiveUnit_DockingOps vmethod_93()
		{
			if (this.activeUnit_DockingOps_0 == null)
			{
				ActiveUnit activeUnit = this;
				this.activeUnit_DockingOps_0 = new ActiveUnit_DockingOps(ref activeUnit);
			}
			return this.activeUnit_DockingOps_0;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x000783F4 File Offset: 0x000765F4
		private CommDevice[] method_77()
		{
			CommDevice[] array = new CommDevice[this.commDevice_0.Length - 1 + 1];
			if (this.commDevice_0.Length > 0)
			{
				Array.Copy(this.commDevice_0, array, this.commDevice_0.Length);
			}
			return array;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00078434 File Offset: 0x00076634
		public virtual CommDevice[] vmethod_94()
		{
			CommDevice[] result;
			if (this.vmethod_51().Count > 0)
			{
				CommDevice[] array = null;
				int num = this.vmethod_51().Count - 1;
				for (int i = 0; i <= num; i++)
				{
					Mount mount = this.vmethod_51()[i];
					int num2 = mount.commDevice_0.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						if (array == null)
						{
							array = this.method_77();
						}
						CommDevice commDevice_ = mount.commDevice_0[j];
						Class429.smethod_9(ref array, commDevice_);
					}
				}
				if (array == null)
				{
					result = this.commDevice_0;
				}
				else
				{
					result = array;
				}
			}
			else
			{
				result = this.commDevice_0;
			}
			return result;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00006FD3 File Offset: 0x000051D3
		public virtual List<Sensor> vmethod_95()
		{
			return Enumerable.ToList<Sensor>(Enumerable.Where<Sensor>(this.sensor_0, (ActiveUnit._Closure$__.$I275-0 == null) ? (ActiveUnit._Closure$__.$I275-0 = new Func<Sensor, bool>(ActiveUnit._Closure$__.$I.method_1)) : ActiveUnit._Closure$__.$I275-0));
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00007009 File Offset: 0x00005209
		public Sensor[] method_78()
		{
			if (this.sensor_1 == null)
			{
				this.sensor_1 = this.vmethod_96();
			}
			return this.sensor_1;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00007025 File Offset: 0x00005225
		public void method_79(Sensor[] sensor_2)
		{
			this.sensor_1 = sensor_2;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000784D0 File Offset: 0x000766D0
		private void method_80(ref int? nullable_16, ref Sensor[] sensor_2)
		{
			int num = 0;
			foreach (Sensor sensor in this.sensor_0)
			{
				if (!sensor.method_65())
				{
					if (nullable_16 != null)
					{
						nullable_16++;
					}
					if (sensor_2 != null)
					{
						sensor_2[num] = sensor;
						num++;
					}
				}
			}
			int num2 = this.vmethod_51().Count - 1;
			for (int j = 0; j <= num2; j++)
			{
				foreach (Sensor sensor2 in this.vmethod_51()[j].method_36())
				{
					if (nullable_16 != null)
					{
						nullable_16++;
					}
					if (sensor_2 != null)
					{
						sensor_2[num] = sensor2;
						num++;
					}
				}
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000785E0 File Offset: 0x000767E0
		public virtual Sensor[] vmethod_96()
		{
			Sensor[] result;
			try
			{
				int? num = new int?(0);
				Sensor[] array = null;
				this.method_80(ref num, ref array);
				Sensor[] array2 = new Sensor[num.Value - 1 + 1];
				int? num2 = new int?(0);
				this.method_80(ref num2, ref array2);
				array = array2;
				checked
				{
					for (int i = 0; i < array.Length; i++)
					{
					}
					result = array2;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101185", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00078684 File Offset: 0x00076884
		public bool method_81()
		{
			checked
			{
				bool result;
				try
				{
					if (this.method_78().Length == 0)
					{
						result = false;
					}
					else
					{
						Sensor[] array = this.method_78();
						for (int i = 0; i < array.Length; i++)
						{
							if (array[i].method_43())
							{
								return true;
							}
						}
						result = false;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101186", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				return result;
			}
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00078710 File Offset: 0x00076910
		public virtual bool vmethod_97()
		{
			checked
			{
				bool result;
				try
				{
					if (this.vmethod_67().Length == 0)
					{
						result = false;
					}
					else
					{
						FuelRec[] array = this.vmethod_67();
						for (int i = 0; i < array.Length; i++)
						{
							if (array[i].float_0 > 0f)
							{
								return false;
							}
						}
						result = true;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101187", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				return result;
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0000702E File Offset: 0x0000522E
		public virtual float vmethod_98(ActiveUnit.Throttle throttle_5, AltBand altBand_0, float? nullable_16, float? nullable_17, bool bool_27, bool bool_28, bool bool_29, bool bool_30, bool bool_31)
		{
			return 1E-07f;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000787A0 File Offset: 0x000769A0
		public bool method_82()
		{
			return this.bool_24 || (!this.scenario_0.vmethod_0().ContainsKey(this.string_0) && !this.scenario_0.method_45().Contains(this)) || this.scenario_0.method_46().Contains(this);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00007035 File Offset: 0x00005235
		public virtual AirFacility[] vmethod_99()
		{
			return this.airFacility_0;
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0000703D File Offset: 0x0000523D
		public virtual DockFacility[] vmethod_100()
		{
			return this.dockFacility_0;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000787FC File Offset: 0x000769FC
		public bool method_83()
		{
			try
			{
				List<Sensor>.Enumerator enumerator = this.vmethod_95().GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.method_66())
					{
						return true;
					}
				}
			}
			finally
			{
				List<Sensor>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return false;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00078858 File Offset: 0x00076A58
		public virtual Mission vmethod_101()
		{
			Mission result;
			try
			{
				if (this.mission_0 == null && !string.IsNullOrEmpty(this.string_4))
				{
					ReadOnlyCollection<Mission> readOnlyCollection = this.vmethod_7(false).method_36(this.scenario_0);
					int num = readOnlyCollection.Count - 1;
					int i = 0;
					while (i <= num)
					{
						Mission mission = readOnlyCollection[i];
						if (mission == null || Operators.CompareString(mission.string_0, this.string_4, false) != 0)
						{
							i++;
						}
						else
						{
							this.mission_0 = mission;
							IL_6A:
							if (this.mission_0 == null)
							{
								this.string_4 = null;
								goto IL_79;
							}
							goto IL_79;
						}
					}
					goto IL_6A;
				}
				IL_79:
				if (this.mission_0 != null && this.mission_0.enum88_0 == Mission.Enum88.const_1 && !string.IsNullOrEmpty(this.mission_0.method_13(this.vmethod_7(false))))
				{
					this.string_5 = this.mission_0.method_13(this.vmethod_7(false));
				}
				result = this.mission_0;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101188", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0007897C File Offset: 0x00076B7C
		public unsafe virtual void vmethod_102(Mission value, bool SetMissionOnly, ref Mission.MissionAssignmentAttemptResult Result = Mission.MissionAssignmentAttemptResult*.None)
		{
			try
			{
				if (!this.vmethod_90().vmethod_1())
				{
					Result = Mission.MissionAssignmentAttemptResult.Fail_OutOfComms;
				}
				else
				{
					bool flag = value != this.mission_0;
					if (value == null)
					{
						if (this.vmethod_86().method_12().Length > 0)
						{
							bool flag2 = this.vmethod_86().method_37();
							foreach (Contact contact in this.vmethod_86().method_12())
							{
								if (this.vmethod_86().method_20(contact) == ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted)
								{
									ActiveUnit_AI activeUnit_AI = this.vmethod_86();
									Contact contact_ = contact;
									Mission mission = this.mission_0;
									Doctrine.Enum59? @enum = new Doctrine.Enum59?(this.doctrine_0.method_162(this.scenario_0, false, false, false).Value);
									bool bool_ = false;
									bool flag3 = flag2;
									bool flag4 = true;
									Misc.PostureStance? postureStance = null;
									string text = "";
									int num = 0;
									if (activeUnit_AI.method_39(contact_, mission, @enum, bool_, flag3, flag4, postureStance, ref text, ref num))
									{
										this.vmethod_86().vmethod_15(contact, true);
									}
								}
							}
						}
						if (this.mission_0 == null || (this.mission_0 != null && this.mission_0.enum88_0 != Mission.Enum88.const_1))
						{
							this.mission_1 = null;
							this.string_5 = "";
						}
						this.mission_0 = null;
						this.string_4 = "";
						if (SetMissionOnly)
						{
							Result = Mission.MissionAssignmentAttemptResult.Success;
							return;
						}
						if (!this.method_85())
						{
							this.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
						}
					}
					else
					{
						if (value.enum88_0 == Mission.Enum88.const_2)
						{
							this.mission_1 = value;
							this.string_5 = value.string_0;
							Result = Mission.MissionAssignmentAttemptResult.Success;
							return;
						}
						this.mission_0 = value;
						this.string_4 = value.string_0;
						if (SetMissionOnly)
						{
							Result = Mission.MissionAssignmentAttemptResult.Success;
							return;
						}
						this.vmethod_109(ActiveUnit._ActiveUnitStatus.Tasked);
						if (this.vmethod_7(false) != null)
						{
							this.vmethod_7(false).method_38(value);
						}
						if (this.vmethod_85().method_47() && this.vmethod_85().method_4()[0].waypointType_0 != Waypoint.WaypointType.ManualPlottedCourseWaypoint)
						{
							this.vmethod_85().vmethod_9();
							if (this.vmethod_85().method_49())
							{
								this.vmethod_85().method_7().method_17();
							}
						}
						if (value._MissionClass_0 != Mission._MissionClass.Escort)
						{
							this.vmethod_86().string_0 = null;
						}
						if (value._MissionClass_0 == Mission._MissionClass.Patrol)
						{
							this.doctrine_0.method_84(this.scenario_0, false, new bool?(false), false, false, new Doctrine.Enum64?(Doctrine.Enum64.const_1));
						}
						if (value._MissionClass_0 == Mission._MissionClass.Ferry)
						{
							FerryMission.FerryMissionBehavior ferryMissionBehavior = ((FerryMission)value).method_65();
							if (ferryMissionBehavior != FerryMission.FerryMissionBehavior.Cycle)
							{
								if (ferryMissionBehavior == FerryMission.FerryMissionBehavior.Random)
								{
									if (this.bool_3)
									{
										((Aircraft)this).method_164().method_29(((Aircraft)this).method_164().method_32(false));
									}
									else
									{
										this.vmethod_93().method_43(this.vmethod_93().method_11(false));
									}
								}
							}
							else
							{
								this.vmethod_86().method_40();
							}
						}
					}
					if (flag)
					{
						this.vmethod_86().bool_2 = false;
						if (this.method_122())
						{
							Group group = this.vmethod_65(false);
							bool setMissionOnly = false;
							Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
							group.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
						}
					}
					Result = Mission.MissionAssignmentAttemptResult.Success;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101189", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				Result = Mission.MissionAssignmentAttemptResult.Fail_Other;
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00078CA0 File Offset: 0x00076EA0
		public static Mission.MissionAssignmentAttemptResult smethod_8(ref Scenario scenario_1, ref ActiveUnit activeUnit_0, ref Mission mission_2, ref bool bool_27)
		{
			Mission.MissionAssignmentAttemptResult result;
			try
			{
				string str = "";
				if (activeUnit_0.bool_3 && Operators.CompareString(activeUnit_0.Name, activeUnit_0.string_2, false) != 0)
				{
					str = " (" + activeUnit_0.string_2 + ")";
				}
				Mission mission = null;
				if (activeUnit_0.vmethod_101() != null && mission_2 != activeUnit_0.vmethod_101())
				{
					mission = activeUnit_0.vmethod_101();
				}
				if (mission_2.enum88_0 == Mission.Enum88.const_2)
				{
					Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult;
					activeUnit_0.vmethod_102(null, false, ref missionAssignmentAttemptResult);
					if (missionAssignmentAttemptResult != Mission.MissionAssignmentAttemptResult.Success)
					{
						result = missionAssignmentAttemptResult;
					}
					else
					{
						if (mission != null && activeUnit_0.vmethod_85().method_48() && mission.list_1.Contains(activeUnit_0.vmethod_85().method_7()))
						{
							mission.list_1.Remove(activeUnit_0.vmethod_85().method_7());
						}
						if (activeUnit_0.vmethod_103() == null || activeUnit_0.vmethod_103() != mission_2)
						{
							activeUnit_0.vmethod_104(mission_2);
							activeUnit_0.scenario_0.method_59(activeUnit_0.Name + str + " has been assigned to task pool: " + mission_2.Name, activeUnit_0.Name + " assigned to tak pool", LoggedMessage.MessageType.UnitAI, 0, activeUnit_0.string_0, activeUnit_0.vmethod_7(false), new Geopoint_Struct(activeUnit_0.vmethod_28(null), activeUnit_0.vmethod_30(null)));
							if (activeUnit_0.bool_1)
							{
								Group group = (Group)activeUnit_0;
								try
								{
									foreach (ActiveUnit activeUnit in group.vmethod_141().Values)
									{
										activeUnit.vmethod_86().vmethod_10(0f, false, true);
									}
									goto IL_1B7;
								}
								finally
								{
									IEnumerator<ActiveUnit> enumerator;
									if (enumerator != null)
									{
										enumerator.Dispose();
									}
								}
							}
							activeUnit_0.vmethod_86().vmethod_10(0f, false, true);
							IL_1B7:
							activeUnit_0.doctrine_0.method_4();
						}
						result = missionAssignmentAttemptResult;
					}
				}
				else
				{
					if (activeUnit_0.bool_1)
					{
						((Group)activeUnit_0).method_147();
					}
					Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult2;
					activeUnit_0.vmethod_102(mission_2, false, ref missionAssignmentAttemptResult2);
					if (missionAssignmentAttemptResult2 != Mission.MissionAssignmentAttemptResult.Success)
					{
						result = missionAssignmentAttemptResult2;
					}
					else
					{
						if (mission != null && activeUnit_0.vmethod_85().method_48() && mission.list_1.Contains(activeUnit_0.vmethod_85().method_7()))
						{
							mission.list_1.Remove(activeUnit_0.vmethod_85().method_7());
						}
						if (activeUnit_0.vmethod_101().enum88_0 == Mission.Enum88.const_1)
						{
							try
							{
								foreach (Mission mission2 in activeUnit_0.vmethod_7(false).method_35())
								{
									if (Operators.CompareString(mission2.string_0, activeUnit_0.vmethod_101().method_13(activeUnit_0.vmethod_7(false)), false) == 0)
									{
										activeUnit_0.vmethod_104(mission2);
										IL_2A0:
										goto IL_2B6;
									}
								}
								goto IL_2A0;
							}
							finally
							{
								IEnumerator<Mission> enumerator2;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
								}
							}
						}
						activeUnit_0.vmethod_104(null);
						IL_2B6:
						if (activeUnit_0.bool_1)
						{
							try
							{
								foreach (ActiveUnit activeUnit2 in ((Group)activeUnit_0).vmethod_141().Values)
								{
									activeUnit2.vmethod_104(activeUnit_0.vmethod_103());
								}
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
						if (activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && bool_27)
						{
							if (activeUnit_0.bool_1)
							{
								try
								{
									foreach (ActiveUnit activeUnit3 in ((Group)activeUnit_0).vmethod_141().Values)
									{
										activeUnit3.vmethod_86().bool_2 = true;
									}
									goto IL_375;
								}
								finally
								{
									IEnumerator<ActiveUnit> enumerator4;
									if (enumerator4 != null)
									{
										enumerator4.Dispose();
									}
								}
							}
							activeUnit_0.vmethod_86().bool_2 = true;
							IL_375:
							scenario_1.method_59(activeUnit_0.Name + str + " has been assigned as an escort to mission: " + mission_2.Name, activeUnit_0.Name + " assigned as escort", LoggedMessage.MessageType.UnitAI, 0, activeUnit_0.string_0, activeUnit_0.vmethod_7(false), new Geopoint_Struct(activeUnit_0.vmethod_28(null), activeUnit_0.vmethod_30(null)));
						}
						else
						{
							if (activeUnit_0.bool_1)
							{
								try
								{
									foreach (ActiveUnit activeUnit4 in ((Group)activeUnit_0).vmethod_141().Values)
									{
										activeUnit4.vmethod_86().bool_2 = false;
									}
									goto IL_43D;
								}
								finally
								{
									IEnumerator<ActiveUnit> enumerator5;
									if (enumerator5 != null)
									{
										enumerator5.Dispose();
									}
								}
							}
							activeUnit_0.vmethod_86().bool_2 = false;
							IL_43D:
							scenario_1.method_59(activeUnit_0.Name + str + " has been assigned to mission: " + mission_2.Name, activeUnit_0.Name + " assigned to mission", LoggedMessage.MessageType.UnitAI, 0, activeUnit_0.string_0, activeUnit_0.vmethod_7(false), new Geopoint_Struct(activeUnit_0.vmethod_28(null), activeUnit_0.vmethod_30(null)));
						}
						activeUnit_0.doctrine_0.method_4();
						activeUnit_0.vmethod_88().vmethod_5(activeUnit_0.method_78());
						if (activeUnit_0.bool_1)
						{
							Group group2 = (Group)activeUnit_0;
							try
							{
								foreach (ActiveUnit activeUnit5 in group2.vmethod_141().Values)
								{
									if (activeUnit5.vmethod_127())
									{
										activeUnit5.vmethod_86().vmethod_10(0f, false, true);
										activeUnit5.doctrine_0.method_4();
										activeUnit5.vmethod_88().vmethod_5(activeUnit_0.method_78());
									}
								}
								goto IL_55B;
							}
							finally
							{
								IEnumerator<ActiveUnit> enumerator6;
								if (enumerator6 != null)
								{
									enumerator6.Dispose();
								}
							}
						}
						activeUnit_0.vmethod_86().vmethod_10(0f, false, true);
						IL_55B:
						activeUnit_0.doctrine_0.method_4();
						result = missionAssignmentAttemptResult2;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101189", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00079300 File Offset: 0x00077500
		public virtual Mission vmethod_103()
		{
			Mission result;
			try
			{
				if (this.mission_1 == null)
				{
					if (this.mission_0 != null && this.mission_0.enum88_0 == Mission.Enum88.const_1 && !string.IsNullOrEmpty(this.mission_0.method_13(this.vmethod_7(false))))
					{
						this.string_5 = this.mission_0.method_13(this.vmethod_7(false));
					}
					if (!string.IsNullOrEmpty(this.string_5))
					{
						ReadOnlyCollection<Mission> readOnlyCollection = this.vmethod_7(false).method_36(this.scenario_0);
						int num = readOnlyCollection.Count - 1;
						int i = 0;
						while (i <= num)
						{
							Mission mission = readOnlyCollection[i];
							if (mission == null || Operators.CompareString(mission.string_0, this.string_5, false) != 0)
							{
								i++;
							}
							else
							{
								this.mission_1 = mission;
								IL_B4:
								if (this.mission_1 == null)
								{
									this.string_5 = null;
									goto IL_C3;
								}
								goto IL_C3;
							}
						}
						goto IL_B4;
					}
				}
				IL_C3:
				result = this.mission_1;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200638", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00079424 File Offset: 0x00077624
		public virtual void vmethod_104(Mission mission_2)
		{
			try
			{
				if (mission_2 == null)
				{
					this.mission_1 = null;
					this.string_5 = "";
				}
				else
				{
					this.mission_1 = mission_2;
					this.string_5 = mission_2.string_0;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200639", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00003024 File Offset: 0x00001224
		public virtual bool vmethod_105(ActiveUnit activeUnit_0)
		{
			return false;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00003024 File Offset: 0x00001224
		public virtual bool vmethod_106()
		{
			return false;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000041ED File Offset: 0x000023ED
		public virtual bool vmethod_107(ActiveUnit activeUnit_0, Aircraft_AirOps aircraft_AirOps_0, float float_25, bool bool_27)
		{
			return true;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00007045 File Offset: 0x00005245
		public virtual ActiveUnit._ActiveUnitStatus vmethod_108()
		{
			return this._ActiveUnitStatus_0;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000794A4 File Offset: 0x000776A4
		public virtual void vmethod_109(ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_6)
		{
			try
			{
				this.bool_14 = (_ActiveUnitStatus_6 != this._ActiveUnitStatus_0);
				if (this.bool_14)
				{
					this._ActiveUnitStatus_1 = this._ActiveUnitStatus_0;
					if (((_ActiveUnitStatus_6 == ActiveUnit._ActiveUnitStatus.RTB && this.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IsBingo) || _ActiveUnitStatus_6 == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || _ActiveUnitStatus_6 == ActiveUnit._ActiveUnitStatus.Refuelling) && (this._ActiveUnitStatus_1 != ActiveUnit._ActiveUnitStatus.RTB || this.vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsBingo) && this._ActiveUnitStatus_1 != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && this._ActiveUnitStatus_1 != ActiveUnit._ActiveUnitStatus.Refuelling)
					{
						this._ActiveUnitStatus_2 = this._ActiveUnitStatus_0;
						this._ActiveUnitFuelState_1 = this._ActiveUnitFuelState_0;
						if (this.method_121() && !this.method_122() && !this.vmethod_85().method_47())
						{
							if (this.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
							{
								this.throttle_1 = this.vmethod_65(false).method_147().throttle_2;
							}
							else if (this.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
							{
								this.throttle_1 = this.vmethod_65(false).method_147().throttle_3;
							}
							else if (this.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.WaitForPathfinder)
							{
								this.throttle_1 = this.vmethod_65(false).method_147().throttle_4;
							}
							else
							{
								this.throttle_1 = this.vmethod_65(false).method_147().vmethod_84();
							}
						}
						else
						{
							this.throttle_1 = this.vmethod_84();
						}
						this.float_17 = this.vmethod_72();
						this.float_18 = this.vmethod_74();
						this.bool_19 = this.vmethod_76(this);
						this.vmethod_77(this, false);
						if (this.bool_3 && this.vmethod_85().method_49())
						{
							if (this.vmethod_101() != null && (this.vmethod_101()._MissionClass_0 != Mission._MissionClass.Strike || (this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && this.vmethod_86().bool_2)))
							{
								this.bool_17 = true;
							}
							else
							{
								this.bool_17 = false;
							}
						}
						if (this.bool_17)
						{
							this.nullable_13 = this.vmethod_87().vmethod_10();
							this.float_16 = this.vmethod_70();
							this.bool_18 = this.vmethod_87().vmethod_12();
							this.vmethod_87().vmethod_11(null);
							this.vmethod_87().vmethod_13(false);
						}
					}
					else if (_ActiveUnitStatus_6 == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
					{
						this._ActiveUnitStatus_3 = this._ActiveUnitStatus_0;
						if (this._ActiveUnitStatus_1 == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
						{
							this.throttle_2 = this.throttle_3;
							this.float_19 = this.float_20;
							this.nullable_14 = new float?(this.float_21);
							this.bool_20 = this.bool_21;
						}
						else if (this._ActiveUnitStatus_1 == ActiveUnit._ActiveUnitStatus.WaitForPathfinder)
						{
							this.throttle_2 = this.throttle_4;
							this.float_19 = this.float_22;
							this.nullable_14 = new float?(this.float_23);
							this.bool_20 = this.bool_22;
						}
						else
						{
							if (this._ActiveUnitStatus_1 != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
							{
								if (this._ActiveUnitStatus_1 != ActiveUnit._ActiveUnitStatus.Refuelling)
								{
									if (this.method_121() && !this.method_122() && !this.vmethod_85().method_47())
									{
										if (this.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
										{
											this.throttle_2 = this.vmethod_65(false).method_147().throttle_2;
										}
										else if (this.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
										{
											this.throttle_2 = this.vmethod_65(false).method_147().throttle_3;
										}
										else if (this.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.WaitForPathfinder)
										{
											this.throttle_2 = this.vmethod_65(false).method_147().throttle_4;
										}
										else
										{
											this.throttle_2 = this.vmethod_65(false).method_147().vmethod_84();
										}
									}
									else
									{
										this.throttle_2 = this.vmethod_84();
									}
									this.float_19 = this.vmethod_72();
									this.nullable_14 = new float?(this.vmethod_74());
									this.bool_20 = this.vmethod_76(this);
									if (this.bool_3)
									{
										if (this.vmethod_101() != null && (this.vmethod_101()._MissionClass_0 != Mission._MissionClass.Strike || (this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && this.vmethod_86().bool_2)))
										{
											this.bool_17 = true;
										}
										else
										{
											this.bool_17 = false;
										}
									}
									if (this.bool_17)
									{
										this.nullable_13 = this.vmethod_87().vmethod_10();
										this.float_16 = this.vmethod_70();
										this.bool_18 = this.vmethod_87().vmethod_12();
										this.vmethod_87().vmethod_11(null);
										this.vmethod_87().vmethod_13(false);
										goto IL_EDE;
									}
									goto IL_EDE;
								}
							}
							this.throttle_2 = this.throttle_1;
							this.float_19 = this.float_17;
							this.nullable_14 = new float?(this.float_18);
							this.bool_20 = this.bool_19;
						}
					}
					else if (_ActiveUnitStatus_6 == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
					{
						if (this.bool_3 && this.vmethod_85().method_26())
						{
							List<Waypoint> list = new List<Waypoint>();
							foreach (Waypoint waypoint in this.vmethod_85().method_4())
							{
								if (!waypoint.method_45())
								{
									break;
								}
								list.Add(waypoint);
							}
							try
							{
								foreach (Waypoint waypoint2 in list)
								{
									ActiveUnit_Navigator activeUnit_Navigator = this.vmethod_85();
									float float_ = 0f;
									bool flag = true;
									bool flag2 = false;
									activeUnit_Navigator.vmethod_19(float_, ref flag, ref flag2);
								}
							}
							finally
							{
								List<Waypoint>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						this._ActiveUnitStatus_4 = this._ActiveUnitStatus_0;
						if (this._ActiveUnitStatus_1 == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
						{
							this.throttle_3 = this.throttle_2;
							this.float_20 = this.float_19;
							if (this.nullable_14 != null)
							{
								this.float_21 = this.nullable_14.Value;
							}
							this.bool_21 = this.bool_20;
						}
						else if (this._ActiveUnitStatus_1 == ActiveUnit._ActiveUnitStatus.WaitForPathfinder)
						{
							this.throttle_3 = this.throttle_4;
							this.float_20 = this.float_22;
							this.float_21 = this.float_23;
							this.bool_21 = this.bool_22;
						}
						else
						{
							if (this._ActiveUnitStatus_1 != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
							{
								if (this._ActiveUnitStatus_1 != ActiveUnit._ActiveUnitStatus.Refuelling)
								{
									if (this.method_121() && !Information.IsNothing(this.method_122()) && !this.vmethod_85().method_47())
									{
										if (this.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
										{
											this.throttle_3 = this.vmethod_65(false).method_147().throttle_2;
										}
										else if (this.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
										{
											this.throttle_3 = this.vmethod_65(false).method_147().throttle_3;
										}
										else if (this.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.WaitForPathfinder)
										{
											this.throttle_3 = this.vmethod_65(false).method_147().throttle_4;
										}
										else
										{
											this.throttle_3 = this.vmethod_65(false).method_147().vmethod_84();
										}
									}
									else
									{
										this.throttle_3 = this.vmethod_84();
									}
									this.float_20 = this.vmethod_72();
									this.float_21 = this.vmethod_74();
									this.bool_21 = this.vmethod_76(this);
									if (this.bool_3)
									{
										if (!Information.IsNothing(this.vmethod_101()) && (this.vmethod_101()._MissionClass_0 != Mission._MissionClass.Strike || (this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && this.vmethod_86().bool_2)))
										{
											this.bool_17 = true;
										}
										else
										{
											this.bool_17 = false;
										}
									}
									if (this.bool_17)
									{
										this.nullable_13 = this.vmethod_87().vmethod_10();
										this.float_16 = this.vmethod_70();
										this.bool_18 = this.vmethod_87().vmethod_12();
										this.vmethod_87().vmethod_11(null);
										this.vmethod_87().vmethod_13(false);
										goto IL_EDE;
									}
									goto IL_EDE;
								}
							}
							this.throttle_3 = this.throttle_1;
							this.float_20 = this.float_17;
							this.float_21 = this.float_18;
							this.bool_21 = this.bool_19;
						}
					}
					else if (_ActiveUnitStatus_6 == ActiveUnit._ActiveUnitStatus.WaitForPathfinder)
					{
						this._ActiveUnitStatus_5 = this._ActiveUnitStatus_0;
						if (this._ActiveUnitStatus_1 == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
						{
							this.throttle_4 = this.throttle_3;
							this.float_22 = this.float_20;
							this.float_23 = this.float_21;
							this.bool_22 = this.bool_21;
						}
						else if (this._ActiveUnitStatus_1 == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
						{
							this.throttle_4 = this.throttle_2;
							this.float_22 = this.float_19;
							if (this.nullable_14 != null)
							{
								this.float_23 = this.nullable_14.Value;
							}
							this.bool_22 = this.bool_20;
						}
						else
						{
							if (this._ActiveUnitStatus_1 != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
							{
								if (this._ActiveUnitStatus_1 != ActiveUnit._ActiveUnitStatus.Refuelling)
								{
									if (this.method_121() && !Information.IsNothing(this.method_122()) && !this.vmethod_85().method_47())
									{
										if (this.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
										{
											this.throttle_4 = this.vmethod_65(false).method_147().throttle_2;
										}
										else if (this.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
										{
											this.throttle_4 = this.vmethod_65(false).method_147().throttle_3;
										}
										else if (this.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
										{
											this.throttle_4 = this.vmethod_65(false).method_147().throttle_3;
										}
										else
										{
											this.throttle_4 = this.vmethod_65(false).method_147().vmethod_84();
										}
									}
									else
									{
										this.throttle_4 = this.vmethod_84();
									}
									this.float_22 = this.vmethod_72();
									this.float_23 = this.vmethod_74();
									this.bool_22 = this.vmethod_76(this);
									if (this.bool_3)
									{
										if (!Information.IsNothing(this.vmethod_101()) && (this.vmethod_101()._MissionClass_0 != Mission._MissionClass.Strike || (this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && this.vmethod_86().bool_2)))
										{
											this.bool_17 = true;
										}
										else
										{
											this.bool_17 = false;
										}
									}
									if (this.bool_17)
									{
										this.nullable_13 = this.vmethod_87().vmethod_10();
										this.float_16 = this.vmethod_70();
										this.bool_18 = this.vmethod_87().vmethod_12();
										this.vmethod_87().vmethod_11(null);
										this.vmethod_87().vmethod_13(false);
										goto IL_EDE;
									}
									goto IL_EDE;
								}
							}
							this.throttle_4 = this.throttle_1;
							this.float_22 = this.float_17;
							this.float_23 = this.float_18;
							this.bool_22 = this.bool_19;
						}
					}
					else if ((this._ActiveUnitStatus_1 == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && _ActiveUnitStatus_6 != ActiveUnit._ActiveUnitStatus.Refuelling) || this._ActiveUnitStatus_1 == ActiveUnit._ActiveUnitStatus.Refuelling)
					{
						if (!this.method_121() || this.vmethod_85().method_47())
						{
							this.vmethod_134(this.throttle_1, null);
							this.vmethod_73(this.float_17);
							this.vmethod_75(this.float_18);
							this.vmethod_77(this, this.bool_19);
						}
						if (this.bool_17 && this.vmethod_85().method_49() && !Information.IsNothing(this.vmethod_101()) && (this.vmethod_101()._MissionClass_0 != Mission._MissionClass.Strike || (this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && this.vmethod_86().bool_2)))
						{
							this.vmethod_87().vmethod_11(this.nullable_13);
							if (!Information.IsNothing(this.nullable_13))
							{
								this.vmethod_71(this.float_16);
							}
							this.vmethod_87().vmethod_13(this.bool_18);
						}
						this.bool_17 = false;
					}
					else if (this._ActiveUnitStatus_1 == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
					{
						if (!this.method_121() || this.vmethod_85().method_47())
						{
							this.vmethod_134(this.throttle_2, null);
							this.vmethod_73(this.float_19);
							if (this.nullable_14 != null)
							{
								this.vmethod_75(this.nullable_14.Value);
							}
							this.vmethod_77(this, this.bool_20);
						}
						if (this.bool_17 && this.vmethod_85().method_49() && !Information.IsNothing(this.vmethod_101()) && (this.vmethod_101()._MissionClass_0 != Mission._MissionClass.Strike || (this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && this.vmethod_86().bool_2)))
						{
							this.vmethod_87().vmethod_11(this.nullable_13);
							if (!Information.IsNothing(this.nullable_13))
							{
								this.vmethod_71(this.float_16);
							}
							this.vmethod_87().vmethod_13(this.bool_18);
						}
						this.bool_17 = false;
					}
					else if (this._ActiveUnitStatus_1 == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
					{
						if (!this.method_121() || this.vmethod_85().method_47())
						{
							this.vmethod_134(this.throttle_3, null);
							this.vmethod_73(this.float_20);
							this.vmethod_75(this.float_21);
							this.vmethod_77(this, this.bool_21);
						}
						if (this.bool_17 && this.vmethod_85().method_49())
						{
							if (!Information.IsNothing(this.vmethod_101()) && (this.vmethod_101()._MissionClass_0 != Mission._MissionClass.Strike || (this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && this.vmethod_86().bool_2)))
							{
								this.vmethod_87().vmethod_11(this.nullable_13);
								if (!Information.IsNothing(this.nullable_13))
								{
									this.vmethod_71(this.float_16);
								}
								this.vmethod_87().vmethod_13(this.bool_18);
							}
							if (this.bool_3)
							{
								Aircraft aircraft = (Aircraft)this;
								Aircraft_AirOps._AirOpsCondition airOpsCondition = aircraft.method_164().method_36();
								if (airOpsCondition - Aircraft_AirOps._AirOpsCondition.BVRAttack <= 2 || airOpsCondition == Aircraft_AirOps._AirOpsCondition.BVRDrag)
								{
									aircraft.method_164().method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
								}
							}
						}
						this.bool_17 = false;
					}
					else if (this._ActiveUnitStatus_1 == ActiveUnit._ActiveUnitStatus.WaitForPathfinder)
					{
						if (!this.method_121() || this.vmethod_85().method_47())
						{
							this.vmethod_134(this.throttle_4, null);
							this.vmethod_73(this.float_22);
							this.vmethod_75(this.float_23);
							this.vmethod_77(this, this.bool_22);
						}
						if (this.bool_17 && this.vmethod_85().method_49() && !Information.IsNothing(this.vmethod_101()) && (this.vmethod_101()._MissionClass_0 != Mission._MissionClass.Strike || (this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && this.vmethod_86().bool_2)))
						{
							this.vmethod_87().vmethod_11(this.nullable_13);
							if (!Information.IsNothing(this.nullable_13))
							{
								this.vmethod_71(this.float_16);
							}
							this.vmethod_87().vmethod_13(this.bool_18);
						}
						this.bool_17 = false;
					}
				}
				IL_EDE:
				if (this.bool_14 && (this.bool_6 || this.bool_5))
				{
					if (_ActiveUnitStatus_6 == ActiveUnit._ActiveUnitStatus.RTB && this.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IsBingo && this.vmethod_93().method_18())
					{
						if (!string.IsNullOrEmpty(this.vmethod_93().string_4))
						{
							ActiveUnit activeUnit = this.scenario_0.vmethod_0()[this.vmethod_93().string_4];
							if (!Information.IsNothing(activeUnit) && !activeUnit.method_82())
							{
								activeUnit.vmethod_93().method_26();
							}
						}
						if (!string.IsNullOrEmpty(this.vmethod_93().string_5))
						{
							ActiveUnit activeUnit2 = this.scenario_0.vmethod_0()[this.vmethod_93().string_5];
							if (!Information.IsNothing(activeUnit2) && !activeUnit2.method_82())
							{
								activeUnit2.vmethod_93().method_26();
							}
						}
						if (!string.IsNullOrEmpty(this.vmethod_93().string_6))
						{
							ActiveUnit activeUnit3 = this.scenario_0.vmethod_0()[this.vmethod_93().string_6];
							if (!Information.IsNothing(activeUnit3) && !activeUnit3.method_82())
							{
								activeUnit3.vmethod_93().method_26();
							}
						}
					}
					if (_ActiveUnitStatus_6 <= ActiveUnit._ActiveUnitStatus.RTB)
					{
						if (_ActiveUnitStatus_6 != ActiveUnit._ActiveUnitStatus.Unassigned && _ActiveUnitStatus_6 != ActiveUnit._ActiveUnitStatus.RTB)
						{
							goto IL_1050;
						}
					}
					else if (_ActiveUnitStatus_6 != ActiveUnit._ActiveUnitStatus.RTB_Manual && _ActiveUnitStatus_6 != ActiveUnit._ActiveUnitStatus.RTB_MissionOver && _ActiveUnitStatus_6 - ActiveUnit._ActiveUnitStatus.RTB_Group > 1)
					{
						goto IL_1050;
					}
					if (this._ActiveUnitStatus_1 == ActiveUnit._ActiveUnitStatus.Refuelling || this.vmethod_93().method_8() == ActiveUnit_DockingOps._DockingOpsCondition.Replenishing)
					{
						this.vmethod_93().method_26();
					}
				}
				IL_1050:
				if (this.bool_14 && this._ActiveUnitStatus_1 == ActiveUnit._ActiveUnitStatus.EngagedOffensive && (_ActiveUnitStatus_6 == ActiveUnit._ActiveUnitStatus.OnPatrol || _ActiveUnitStatus_6 == ActiveUnit._ActiveUnitStatus.OnPlottedCourse || _ActiveUnitStatus_6 == ActiveUnit._ActiveUnitStatus.Tasked || _ActiveUnitStatus_6 == ActiveUnit._ActiveUnitStatus.Unassigned || _ActiveUnitStatus_6 == ActiveUnit._ActiveUnitStatus.RTB_CalledOff) && this._ActiveUnitStatus_1 == this._ActiveUnitStatus_0 && this.bool_3 && (this.vmethod_85().method_25() || (!Information.IsNothing(this.vmethod_101()) && this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && this.vmethod_86().bool_2 && this.vmethod_85().method_32())))
				{
					this._ActiveUnitStatus_0 = _ActiveUnitStatus_6;
					Aircraft_AirOps aircraft_AirOps = ((Aircraft)this).method_164();
					List<Waypoint> list2 = Enumerable.ToList<Waypoint>(this.vmethod_85().method_4());
					aircraft_AirOps.method_46(ref list2, false, false);
				}
				this._ActiveUnitStatus_0 = _ActiveUnitStatus_6;
				if (this.method_85() && !this.bool_3 && this.method_120())
				{
					this.vmethod_66(false, null);
				}
				if (this.method_85() && Enumerable.Count<Waypoint>(this.vmethod_85().method_4()) > 0)
				{
					this.vmethod_85().vmethod_9();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0000704D File Offset: 0x0000524D
		public ActiveUnit._ActiveUnitStatus method_84()
		{
			return this._ActiveUnitStatus_2;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00007055 File Offset: 0x00005255
		public virtual ActiveUnit._ActiveUnitFuelState vmethod_110()
		{
			return this._ActiveUnitFuelState_0;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0000705D File Offset: 0x0000525D
		public virtual void vmethod_111(ActiveUnit._ActiveUnitFuelState _ActiveUnitFuelState_2)
		{
			this._ActiveUnitFuelState_0 = _ActiveUnitFuelState_2;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00007066 File Offset: 0x00005266
		public virtual ActiveUnit._ActiveUnitWeaponState vmethod_112()
		{
			return this._ActiveUnitWeaponState_0;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0000706E File Offset: 0x0000526E
		public virtual void vmethod_113(ActiveUnit._ActiveUnitWeaponState _ActiveUnitWeaponState_1)
		{
			this._ActiveUnitWeaponState_0 = _ActiveUnitWeaponState_1;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0007A670 File Offset: 0x00078870
		public bool method_85()
		{
			ActiveUnit._ActiveUnitStatus activeUnitStatus = this.vmethod_108();
			if (activeUnitStatus <= ActiveUnit._ActiveUnitStatus.RTB_Manual)
			{
				if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.RTB || activeUnitStatus == ActiveUnit._ActiveUnitStatus.RTB_Manual)
				{
					goto IL_27;
				}
			}
			else
			{
				if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.RTB_MissionOver)
				{
					goto IL_27;
				}
				if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.RTB_Group)
				{
					goto IL_27;
				}
			}
			return false;
			IL_27:
			return true;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0007A6A8 File Offset: 0x000788A8
		public bool method_86()
		{
			ActiveUnit._ActiveUnitStatus activeUnitStatus = this.vmethod_108();
			if (activeUnitStatus <= ActiveUnit._ActiveUnitStatus.RTB_Manual)
			{
				if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.RTB || activeUnitStatus == ActiveUnit._ActiveUnitStatus.RTB_Manual)
				{
					goto IL_27;
				}
			}
			else if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.RTB_MissionOver || activeUnitStatus - ActiveUnit._ActiveUnitStatus.RTB_Group <= 1)
			{
				goto IL_27;
			}
			return false;
			IL_27:
			return true;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00007077 File Offset: 0x00005277
		public virtual long vmethod_114(ActiveUnit.Throttle throttle_5, AltBand altBand_0, float? nullable_16, float? nullable_17)
		{
			return 0L;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00007082 File Offset: 0x00005282
		public virtual int vmethod_115()
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			return int.MaxValue;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0007A6E0 File Offset: 0x000788E0
		public virtual int vmethod_116()
		{
			int num;
			foreach (FuelRec fuelRec in this.vmethod_67())
			{
				num = (int)Math.Round((double)((float)num + fuelRec.float_0));
			}
			return num;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00007095 File Offset: 0x00005295
		public bool method_87()
		{
			return this.method_88() || this.method_89() || this.method_90();
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0007A718 File Offset: 0x00078918
		public bool method_88()
		{
			return this.bool_2 && ((Weapon)this).method_167() == Weapon._WeaponType.Decoy_Vehicle && ((Weapon)this).float_29 > 0f;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0007A758 File Offset: 0x00078958
		public bool method_89()
		{
			return this.bool_2 && ((Weapon)this).method_167() == Weapon._WeaponType.Decoy_Vehicle && ((Weapon)this).float_31 > 0f;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0007A798 File Offset: 0x00078998
		public bool method_90()
		{
			return this.bool_2 && ((Weapon)this).method_167() == Weapon._WeaponType.Decoy_Vehicle && ((Weapon)this).float_35 > 0f;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000070AF File Offset: 0x000052AF
		public override bool vmethod_43()
		{
			return base.GetType().BaseType == typeof(Class350);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0007A7D8 File Offset: 0x000789D8
		public Magazine[] method_91()
		{
			Magazine[] result;
			if (this.vmethod_51() != null)
			{
				List<Magazine> list = new List<Magazine>();
				list.AddRange(this.vmethod_117());
				try
				{
					foreach (Mount mount in this.vmethod_51())
					{
						if (mount.method_32() != null)
						{
							list.Add(mount.method_32());
						}
					}
				}
				finally
				{
					List<Mount>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = list.ToArray();
			}
			else
			{
				result = this.vmethod_117();
			}
			return result;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0007A864 File Offset: 0x00078A64
		public virtual Magazine[] vmethod_117()
		{
			Magazine[] result;
			if (this.vmethod_43())
			{
				result = ((Class350)this).magazine_0;
			}
			else if (this.bool_1)
			{
				result = ((Group)this).vmethod_117();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0007A8A0 File Offset: 0x00078AA0
		public bool method_92(Side side_1)
		{
			return !this.bool_1 && (this.bool_13 || (side_1 != null && ((this.vmethod_118() && side_1.bool_14) || side_1.method_28() == Side.AwarenessLevel_Enum.Omniscient || (side_1.method_68(this.vmethod_7(false)) == Misc.PostureStance.Friendly && this.vmethod_90().vmethod_1()))));
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x000070C8 File Offset: 0x000052C8
		public void method_93(Side side_1, bool bool_27)
		{
			this.bool_13 = bool_27;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0007A914 File Offset: 0x00078B14
		public virtual bool vmethod_118()
		{
			int num = this.int_3;
			return num - 1101 <= 1;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0007A93C File Offset: 0x00078B3C
		public virtual double vmethod_119(ref double double_4, ref double double_5, bool bool_27)
		{
			double result;
			try
			{
				if (this.vmethod_49().Count > 0 && this.vmethod_49()[0].enum112_0 == Engine.Enum112.const_9)
				{
					result = 1.0;
				}
				else if (Enumerable.Count<FuelRec>(this.vmethod_67()) == 0)
				{
					result = 0.0;
				}
				else
				{
					foreach (FuelRec fuelRec in this.vmethod_67())
					{
						if (!this.bool_6 || this.vmethod_49()[0].method_25(fuelRec._FuelType_0))
						{
							double_4 += (double)fuelRec.float_0;
							double_5 += (double)fuelRec.int_0;
						}
					}
					if (bool_27 && this.bool_3)
					{
						double_4 -= (double)this.vmethod_87().vmethod_4();
						double_5 -= (double)this.vmethod_87().vmethod_4();
					}
					if (double_5 <= 0.0)
					{
						result = 0.0;
					}
					else
					{
						result = double_4 / double_5;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101346", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0.0;
			}
			return result;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0007AA90 File Offset: 0x00078C90
		public virtual ReadOnlyCollection<PlatformComponent> vmethod_120()
		{
			List<PlatformComponent> list = new List<PlatformComponent>();
			foreach (Sensor item in this.vmethod_96())
			{
				list.Add(item);
			}
			try
			{
				foreach (Mount item2 in this.vmethod_51())
				{
					list.Add(item2);
				}
			}
			finally
			{
				List<Mount>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			foreach (CommDevice item3 in this.vmethod_94())
			{
				list.Add(item3);
			}
			foreach (DockFacility item4 in this.vmethod_100())
			{
				list.Add(item4);
			}
			foreach (AirFacility item5 in this.vmethod_99())
			{
				list.Add(item5);
			}
			foreach (Cargo item6 in this.cargo_0)
			{
				list.Add(item6);
			}
			try
			{
				foreach (Engine item7 in this.vmethod_49())
				{
					list.Add(item7);
				}
			}
			finally
			{
				List<Engine>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			if (this.vmethod_117() != null)
			{
				foreach (Magazine item8 in this.vmethod_117())
				{
					list.Add(item8);
				}
			}
			return list.AsReadOnly();
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x000070D1 File Offset: 0x000052D1
		public bool method_94()
		{
			return Enumerable.Count<Sensor>(Enumerable.Where<Sensor>(this.vmethod_96(), (ActiveUnit._Closure$__.$I354-0 == null) ? (ActiveUnit._Closure$__.$I354-0 = new Func<Sensor, bool>(ActiveUnit._Closure$__.$I.method_2)) : ActiveUnit._Closure$__.$I354-0)) > 0;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0007AC34 File Offset: 0x00078E34
		public bool method_95()
		{
			return this.scenario_0.method_17().Count != 0 && Enumerable.Count<Weapon>(Enumerable.Where<Weapon>(this.scenario_0.method_17(), new Func<Weapon, bool>(this.method_137))) > 0;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0007AC80 File Offset: 0x00078E80
		public bool method_96(Contact contact_0)
		{
			ActiveUnit.Class164 @class = new ActiveUnit.Class164();
			@class.contact_0 = contact_0;
			return Enumerable.Count<Sensor>(Enumerable.Where<Sensor>(this.vmethod_96(), new Func<Sensor, bool>(@class.method_0))) > 0;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0007ACBC File Offset: 0x00078EBC
		public Contact method_97()
		{
			Contact result;
			if (this.scenario_0.method_17().Count == 0)
			{
				result = null;
			}
			else
			{
				IEnumerable<Weapon> enumerable = Enumerable.OrderBy<Weapon, double>(Enumerable.Where<Weapon>(this.scenario_0.method_17(), new Func<Weapon, bool>(this.method_138)), new Func<Weapon, double>(this.method_139));
				if (Enumerable.Count<Weapon>(enumerable) > 0)
				{
					result = Enumerable.ElementAtOrDefault<Weapon>(enumerable, 0).vmethod_142().vmethod_3();
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0007AD30 File Offset: 0x00078F30
		public GlobalVariables.Enum145 method_98()
		{
			XSection xsection = Sensor.smethod_3(this, XSection.Enum132.const_0);
			if (xsection == null)
			{
				xsection = Sensor.smethod_3(this, XSection.Enum132.const_0);
			}
			GlobalVariables.Enum145 result;
			if (xsection == null)
			{
				result = GlobalVariables.Enum145.const_2;
			}
			else
			{
				float num = xsection.method_11(this);
				if (num < 100f)
				{
					result = GlobalVariables.Enum145.const_4;
				}
				else if (num < 120f)
				{
					result = GlobalVariables.Enum145.const_3;
				}
				else if (num < 130f)
				{
					result = GlobalVariables.Enum145.const_2;
				}
				else if (num < 140f)
				{
					result = GlobalVariables.Enum145.const_1;
				}
				else
				{
					result = GlobalVariables.Enum145.const_0;
				}
			}
			return result;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0000710A File Offset: 0x0000530A
		public virtual GlobalVariables.TargetVisualSizeClass vmethod_121()
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0000711D File Offset: 0x0000531D
		public override void vmethod_0(string string_9)
		{
			if (!string.IsNullOrEmpty(string_9))
			{
				string_9 = string_9.Replace("_", "");
			}
			base.vmethod_0(string_9);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0007AD9C File Offset: 0x00078F9C
		public override void vmethod_1()
		{
			base.vmethod_1();
			Sensor[] array = this.sensor_0;
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i].vmethod_1();
				}
				CommDevice[] array2 = this.commDevice_0;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].vmethod_1();
				}
				try
				{
					foreach (Engine engine in this.vmethod_49())
					{
						engine.vmethod_1();
					}
				}
				finally
				{
					List<Engine>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				XSection[] array3 = this.method_64();
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k].vmethod_1();
				}
				FuelRec[] array4 = this.fuelRec_0;
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l].vmethod_1();
				}
				try
				{
					foreach (Mount mount in this.vmethod_51())
					{
						mount.vmethod_1();
					}
				}
				finally
				{
					List<Mount>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				Cargo[] array5 = this.cargo_0;
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m].vmethod_1();
				}
				AirFacility[] array6 = this.airFacility_0;
				for (int n = 0; n < array6.Length; n++)
				{
					array6[n].vmethod_1();
				}
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0007AF04 File Offset: 0x00079104
		public override void vmethod_44(float float_25, Scenario scenario_1)
		{
			base.vmethod_44(float_25, scenario_1);
			if (this.vmethod_7(false).list_7.Count > 0)
			{
				ActiveUnit_Navigator activeUnit_Navigator = this.vmethod_85();
				if (activeUnit_Navigator.double_9 > 0.0)
				{
					ActiveUnit_Navigator activeUnit_Navigator2 = activeUnit_Navigator;
					ref double ptr = ref activeUnit_Navigator2.double_9;
					activeUnit_Navigator2.double_9 = ptr - (double)float_25;
				}
			}
			if (this.bool_3)
			{
				((Aircraft)this).imethod_5(null);
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0007AF70 File Offset: 0x00079170
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				try
				{
					xmlWriter_0.WriteStartElement("ActiveUnit");
					xmlWriter_0.WriteElementString("ID", this.string_0);
					if (hashSet_0.Contains(this.string_0))
					{
						xmlWriter_0.WriteEndElement();
					}
					else
					{
						hashSet_0.Add(this.string_0);
						xmlWriter_0.WriteElementString("Name", this.Name);
						xmlWriter_0.WriteElementString("CurrentHeading", XmlConvert.ToString(this.vmethod_9()));
						xmlWriter_0.WriteElementString("CurrentSpeed", XmlConvert.ToString(this.vmethod_40()));
						xmlWriter_0.WriteElementString("CurrentAltitude", XmlConvert.ToString(this.vmethod_14(false)));
						xmlWriter_0.WriteElementString("Longitude", XmlConvert.ToString(this.vmethod_28(null)));
						xmlWriter_0.WriteElementString("Latitude", XmlConvert.ToString(this.vmethod_30(null)));
						xmlWriter_0.WriteElementString("UnitClass", this.string_2);
						if (base.method_17().Count > 0)
						{
							xmlWriter_0.WriteStartElement("RangeSymbols");
							try
							{
								foreach (RangeSymbol rangeSymbol in base.method_17())
								{
									xmlWriter_0.WriteRaw(rangeSymbol.method_8());
								}
							}
							finally
							{
								List<RangeSymbol>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							xmlWriter_0.WriteEndElement();
						}
						xmlWriter_0.WriteElementString("Side", this.vmethod_7(false).method_51());
						if (!string.IsNullOrEmpty(this.string_3))
						{
							xmlWriter_0.WriteElementString("Message", this.string_3);
						}
						xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
						xmlWriter_0.WriteElementString("DesiredHeading", XmlConvert.ToString(this.vmethod_68()));
						xmlWriter_0.WriteElementString("DesiredSpeed", XmlConvert.ToString(this.vmethod_70()));
						xmlWriter_0.WriteElementString("DesiredAltitude", XmlConvert.ToString(this.vmethod_72()));
						if (this.vmethod_74() != 0f)
						{
							xmlWriter_0.WriteElementString("DesiredAltitude_TerrainFollowing", XmlConvert.ToString(this.vmethod_74()));
						}
						xmlWriter_0.WriteElementString("DesiredTurnRate", ((byte)this.vmethod_78()).ToString());
						xmlWriter_0.WriteElementString("DesiredTurnRate_Navigation", ((byte)this.vmethod_80()).ToString());
						if (this.vmethod_76(this))
						{
							xmlWriter_0.WriteElementString("TerrainFollowing", this.vmethod_76(this).ToString());
						}
						xmlWriter_0.WriteElementString("Weight", XmlConvert.ToString(this.int_0));
						xmlWriter_0.WriteElementString("ThrottleSetting", ((byte)this.vmethod_84()).ToString());
						if (this.nullable_15 != null)
						{
							xmlWriter_0.WriteElementString("Prof", ((int)this.nullable_15.Value).ToString());
						}
						xmlWriter_0.WriteStartElement("Sensors");
						foreach (Sensor sensor in this.sensor_0)
						{
							xmlWriter_0.WriteRaw(sensor.method_23(hashSet_0));
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Comms");
						foreach (CommDevice commDevice in this.commDevice_0)
						{
							xmlWriter_0.WriteRaw(commDevice.method_23(ref hashSet_0));
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Propulsion");
						try
						{
							foreach (Engine engine in this.vmethod_49())
							{
								xmlWriter_0.WriteRaw(engine.method_23(hashSet_0));
							}
						}
						finally
						{
							List<Engine>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("XSections");
						XSection[] array3 = this.method_64();
						for (int k = 0; k < array3.Length; k++)
						{
							array3[k].method_8(ref xmlWriter_0);
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Fuel");
						foreach (FuelRec fuelRec in this.fuelRec_0)
						{
							xmlWriter_0.WriteRaw(fuelRec.method_8());
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Mounts");
						try
						{
							foreach (Mount mount in this.vmethod_51())
							{
								xmlWriter_0.WriteRaw(mount.method_23(ref hashSet_0, this.scenario_0));
							}
						}
						finally
						{
							List<Mount>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("OnboardCargo");
						foreach (Cargo cargo in this.cargo_0)
						{
							xmlWriter_0.WriteRaw(cargo.method_27(hashSet_0, this.scenario_0));
						}
						xmlWriter_0.WriteEndElement();
						XmlWriter xmlWriter = xmlWriter_0;
						string localName = "Status";
						byte b = (byte)this._ActiveUnitStatus_0;
						xmlWriter.WriteElementString(localName, b.ToString());
						XmlWriter xmlWriter2 = xmlWriter_0;
						string localName2 = "FuelState";
						b = (byte)this._ActiveUnitFuelState_0;
						xmlWriter2.WriteElementString(localName2, b.ToString());
						XmlWriter xmlWriter3 = xmlWriter_0;
						string localName3 = "WeaponState";
						b = (byte)this._ActiveUnitWeaponState_0;
						xmlWriter3.WriteElementString(localName3, b.ToString());
						XmlWriter xmlWriter4 = xmlWriter_0;
						string localName4 = "SBR";
						b = (byte)this._ActiveUnitStatus_2;
						xmlWriter4.WriteElementString(localName4, b.ToString());
						XmlWriter xmlWriter5 = xmlWriter_0;
						string localName5 = "SBED";
						b = (byte)this._ActiveUnitStatus_3;
						xmlWriter5.WriteElementString(localName5, b.ToString());
						XmlWriter xmlWriter6 = xmlWriter_0;
						string localName6 = "SBEO";
						b = (byte)this._ActiveUnitStatus_4;
						xmlWriter6.WriteElementString(localName6, b.ToString());
						XmlWriter xmlWriter7 = xmlWriter_0;
						string localName7 = "FSBR";
						b = (byte)this._ActiveUnitFuelState_1;
						xmlWriter7.WriteElementString(localName7, b.ToString());
						xmlWriter_0.WriteElementString("SBR_Altitude", XmlConvert.ToString(this.float_17));
						xmlWriter_0.WriteElementString("SBR_Altitude_TF", XmlConvert.ToString(this.float_18));
						xmlWriter_0.WriteElementString("SBR_TF", XmlConvert.ToString(this.bool_19));
						XmlWriter xmlWriter8 = xmlWriter_0;
						string localName8 = "SBR_ThrottleSetting";
						b = (byte)this.throttle_1;
						xmlWriter8.WriteElementString(localName8, b.ToString());
						xmlWriter_0.WriteElementString("SBED_Altitude", XmlConvert.ToString(this.float_19));
						if (this.nullable_14 != null)
						{
							xmlWriter_0.WriteElementString("SBED_Altitude_TF", XmlConvert.ToString(this.nullable_14.Value));
						}
						xmlWriter_0.WriteElementString("SBED_TF", XmlConvert.ToString(this.bool_20));
						XmlWriter xmlWriter9 = xmlWriter_0;
						string localName9 = "SBED_ThrottleSetting";
						b = (byte)this.throttle_2;
						xmlWriter9.WriteElementString(localName9, b.ToString());
						xmlWriter_0.WriteElementString("SBEO_Altitude", XmlConvert.ToString(this.float_20));
						xmlWriter_0.WriteElementString("SBEO_Altitude_TF", XmlConvert.ToString(this.float_21));
						xmlWriter_0.WriteElementString("SBEO_TF", XmlConvert.ToString(this.bool_21));
						XmlWriter xmlWriter10 = xmlWriter_0;
						string localName10 = "SBEO_ThrottleSetting";
						b = (byte)this.throttle_3;
						xmlWriter10.WriteElementString(localName10, b.ToString());
						xmlWriter_0.WriteElementString("SBPF_Altitude", XmlConvert.ToString(this.float_22));
						xmlWriter_0.WriteElementString("SBPF_Altitude_TF", XmlConvert.ToString(this.float_23));
						xmlWriter_0.WriteElementString("SBPF_TF", XmlConvert.ToString(this.bool_22));
						XmlWriter xmlWriter11 = xmlWriter_0;
						string localName11 = "SBPF_ThrottleSetting";
						b = (byte)this.throttle_4;
						xmlWriter11.WriteElementString(localName11, b.ToString());
						xmlWriter_0.WriteElementString("AMP_OC", this.bool_17.ToString());
						if (this.nullable_13 != null)
						{
							xmlWriter_0.WriteElementString("AMP_OC_DSO", this.nullable_13.ToString());
						}
						xmlWriter_0.WriteElementString("AMP_OC_DAO", this.bool_18.ToString());
						xmlWriter_0.WriteElementString("AMP_OC_Speed", XmlConvert.ToString(this.float_16));
						xmlWriter_0.WriteElementString("DamagePts", XmlConvert.ToString(this.float_14));
						xmlWriter_0.WriteElementString("OldDamagePercent", XmlConvert.ToString(this.float_15));
						if (this.airFacility_0.Length > 0)
						{
							xmlWriter_0.WriteStartElement("AirFacilities");
							foreach (AirFacility airFacility in this.airFacility_0)
							{
								xmlWriter_0.WriteRaw(airFacility.method_23(hashSet_0));
							}
							xmlWriter_0.WriteEndElement();
						}
						if (Enumerable.Count<DockFacility>(this.dockFacility_0) > 0)
						{
							xmlWriter_0.WriteStartElement("DockFacilities");
							foreach (DockFacility dockFacility in this.dockFacility_0)
							{
								xmlWriter_0.WriteRaw(dockFacility.method_23(hashSet_0));
							}
							xmlWriter_0.WriteEndElement();
						}
						if (this.vmethod_101() != null)
						{
							xmlWriter_0.WriteElementString("AssignedMission", this.mission_0.string_0);
						}
						if (this.vmethod_103() != null)
						{
							xmlWriter_0.WriteElementString("AssignedTaskPool", this.mission_1.string_0);
						}
						if (this.vmethod_65(false) != null)
						{
							xmlWriter_0.WriteElementString("ParentGroup", this.group_0.string_0);
						}
						if (this.method_92(null))
						{
							xmlWriter_0.WriteElementString("IsAD", this.method_92(null).ToString());
						}
						this.doctrine_0.method_282(ref xmlWriter_0, ref this.scenario_0, "Doctrine");
						this.activeUnit_Navigator_0.vmethod_0(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteStartElement("ActiveUnit_AI");
						this.activeUnit_AI_0.vmethod_2(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("ActiveUnit_Kinematics");
						this.activeUnit_Kinematics_0.vmethod_0(ref xmlWriter_0);
						xmlWriter_0.WriteEndElement();
						this.activeUnit_Sensory_0.vmethod_2(ref xmlWriter_0);
						this.activeUnit_Weaponry_0.vmethod_2(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteStartElement("ActiveUnit_CommStuff");
						this.activeUnit_CommStuff_0.vmethod_0(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						this.activeUnit_Damage_0.vmethod_0(ref xmlWriter_0);
						this.activeUnit_AirOps_0.vmethod_0(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100000", string.Concat(new string[]
					{
						"Name: ",
						this.Name,
						" DBID: ",
						Conversions.ToString(this.DBID),
						" ObjectID: ",
						this.string_0
					}));
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0007B9D8 File Offset: 0x00079BD8
		public static ActiveUnit smethod_9(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_1)
		{
			ActiveUnit result;
			try
			{
				string name = xmlNode_0.Name;
				uint num = Class582.smethod_0(name);
				if (num <= 1158526071U)
				{
					if (num != 91525164U)
					{
						if (num != 746798495U)
						{
							if (num == 1158526071U)
							{
								if (Operators.CompareString(name, "Submarine", false) == 0)
								{
									return Submarine.smethod_10(ref xmlNode_0, ref dictionary_0, ref scenario_1);
								}
							}
						}
						else if (Operators.CompareString(name, "Ship", false) == 0)
						{
							return Ship.smethod_10(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						}
					}
					else if (Operators.CompareString(name, "Group", false) == 0)
					{
						return Group.smethod_14(ref xmlNode_0, ref dictionary_0, ref scenario_1);
					}
				}
				else if (num <= 3082879841U)
				{
					if (num != 2722002328U)
					{
						if (num == 3082879841U)
						{
							if (Operators.CompareString(name, "Weapon", false) == 0)
							{
								return Weapon.smethod_11(ref xmlNode_0, ref dictionary_0, ref scenario_1);
							}
						}
					}
					else if (Operators.CompareString(name, "Facility", false) == 0)
					{
						return Facility.smethod_11(ref xmlNode_0, ref dictionary_0, ref scenario_1);
					}
				}
				else if (num != 3388951946U)
				{
					if (num == 4032298643U && Operators.CompareString(name, "Aircraft", false) == 0)
					{
						return Aircraft.smethod_10(ref xmlNode_0, ref dictionary_0, ref scenario_1);
					}
				}
				else if (Operators.CompareString(name, "Satellite", false) == 0)
				{
					return Satellite.smethod_10(ref xmlNode_0, ref dictionary_0, ref scenario_1);
				}
				result = null;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100001", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0007BB60 File Offset: 0x00079D60
		protected void method_99(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_1)
		{
			try
			{
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "AirFacilities", false) == 0)
						{
							try
							{
								foreach (object obj2 in xmlNode.ChildNodes)
								{
									XmlNode xmlNode2 = (XmlNode)obj2;
									this.list_2.Add(xmlNode2.ChildNodes[0].InnerXml);
								}
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
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100002", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0007BC74 File Offset: 0x00079E74
		public void method_100(ref Scenario scenario_1, Dictionary<string, Class310> dictionary_0)
		{
			try
			{
				if (!string.IsNullOrEmpty(this.string_6))
				{
					try
					{
						this.vmethod_66(true, (Group)scenario_1.vmethod_0()[this.string_6]);
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 200004", ex.Message);
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
				}
				if (this.vmethod_65(false) == null)
				{
					this.vmethod_85().method_3(null);
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100003", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0007BD50 File Offset: 0x00079F50
		public virtual void vmethod_122(ref Scenario scenario_1, Dictionary<string, Class310> dictionary_0, List<ActiveUnit> list_3, bool bool_27)
		{
			try
			{
				if (string.IsNullOrEmpty(this.string_7))
				{
					list_3.Add(this);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				else
				{
					this.vmethod_8(false, Side.smethod_10(this.string_7, ref dictionary_0));
					this.vmethod_92().vmethod_1(ref scenario_1, dictionary_0, bool_27);
					this.vmethod_85().vmethod_1(ref scenario_1, dictionary_0, bool_27);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100004", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00007140 File Offset: 0x00005340
		public virtual bool vmethod_123()
		{
			return this.vmethod_93().method_8() == ActiveUnit_DockingOps._DockingOpsCondition.Docked && this.vmethod_93().method_0() == 0f;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00007164 File Offset: 0x00005364
		public virtual bool vmethod_124()
		{
			return this.vmethod_93().method_8() == ActiveUnit_DockingOps._DockingOpsCondition.Docked && this.vmethod_93().method_0() > 0f;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x000041ED File Offset: 0x000023ED
		public virtual bool vmethod_125(ref string string_9)
		{
			return true;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0007BDFC File Offset: 0x00079FFC
		public ActiveUnit()
		{
			this.sensor_0 = new Sensor[0];
			this.commDevice_0 = new CommDevice[0];
			this.vmethod_50(new ObservableList<Engine>());
			this.fuelRec_0 = new FuelRec[0];
			this.vmethod_52(new ObservableList<Mount>());
			this.cargo_0 = new Cargo[0];
			this.airFacility_0 = new AirFacility[0];
			this.dockFacility_0 = new DockFacility[0];
			List<ActiveUnit> list = null;
			this.doctrine_0 = new Doctrine(this, ref list);
			this.float_24 = 1801f;
			this.bool_24 = false;
			this.weapon_0 = new Weapon[0];
			this.int_5 = 0;
			this.bool_25 = false;
			this.struct26_0 = default(ActiveUnit.Struct26);
			this.list_2 = new List<string>();
			this.bool_26 = false;
			this.bool_0 = true;
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0007BED0 File Offset: 0x0007A0D0
		public ActiveUnit(ref Scenario theScen, string theGUID = null)
		{
			this.sensor_0 = new Sensor[0];
			this.commDevice_0 = new CommDevice[0];
			this.vmethod_50(new ObservableList<Engine>());
			this.fuelRec_0 = new FuelRec[0];
			this.vmethod_52(new ObservableList<Mount>());
			this.cargo_0 = new Cargo[0];
			this.airFacility_0 = new AirFacility[0];
			this.dockFacility_0 = new DockFacility[0];
			List<ActiveUnit> list = null;
			this.doctrine_0 = new Doctrine(this, ref list);
			this.float_24 = 1801f;
			this.bool_24 = false;
			this.weapon_0 = new Weapon[0];
			this.int_5 = 0;
			this.bool_25 = false;
			this.struct26_0 = default(ActiveUnit.Struct26);
			this.list_2 = new List<string>();
			this.bool_26 = false;
			try
			{
				this.bool_0 = true;
				this.scenario_0 = theScen;
				if (!string.IsNullOrEmpty(theGUID))
				{
					this.vmethod_0(theGUID);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100005", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0000378C File Offset: 0x0000198C
		public virtual void vmethod_126(float float_25, ref Random random_0)
		{
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0007C004 File Offset: 0x0007A204
		public virtual bool vmethod_127()
		{
			bool result;
			switch (this.vmethod_93().method_8())
			{
			case ActiveUnit_DockingOps._DockingOpsCondition.Underway:
			case ActiveUnit_DockingOps._DockingOpsCondition.RTB:
			case ActiveUnit_DockingOps._DockingOpsCondition.ManoeuveringToRefuel:
			case ActiveUnit_DockingOps._DockingOpsCondition.Replenishing:
			case ActiveUnit_DockingOps._DockingOpsCondition.ProvidingUNREP:
			case ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries:
			case ActiveUnit_DockingOps._DockingOpsCondition.SettlingForCargoTransfer:
				result = true;
				break;
			default:
				result = false;
				break;
			}
			return result;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0007C058 File Offset: 0x0007A258
		public virtual bool vmethod_128()
		{
			return !this.vmethod_127() && this.vmethod_93().method_15() != null && this.vmethod_93().method_15().method_24();
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0007C09C File Offset: 0x0007A29C
		public virtual float vmethod_129()
		{
			float result;
			try
			{
				FuelRec fuelRec = this.vmethod_67()[0];
				result = (float)fuelRec.int_0 - fuelRec.float_0;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100006", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00007188 File Offset: 0x00005388
		public void method_101(CommDevice commDevice_1)
		{
			Class429.smethod_9(ref this.commDevice_0, commDevice_1);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00007196 File Offset: 0x00005396
		public void method_102(Sensor sensor_2)
		{
			Class429.smethod_24(ref this.sensor_0, sensor_2);
			this.method_79(null);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000071AB File Offset: 0x000053AB
		public void method_103(AirFacility airFacility_1)
		{
			Class429.smethod_4(ref this.airFacility_0, airFacility_1);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000071B9 File Offset: 0x000053B9
		public void method_104(DockFacility dockFacility_1)
		{
			Class429.smethod_17(ref this.dockFacility_0, dockFacility_1);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x000071C7 File Offset: 0x000053C7
		public void method_105(FuelRec fuelRec_1)
		{
			Class429.smethod_19(ref this.fuelRec_0, fuelRec_1);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000071D5 File Offset: 0x000053D5
		public virtual void vmethod_130()
		{
			this.vmethod_86().method_34();
			this.vmethod_86().vmethod_6(null);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0007C10C File Offset: 0x0007A30C
		public void method_106(UnguidedWeapon unguidedWeapon_0, Sensor sensor_2)
		{
			try
			{
				string str = "";
				if (this.bool_3 && Operators.CompareString(this.Name, this.string_2, false) != 0)
				{
					str = " (" + this.string_2 + ")";
				}
				unguidedWeapon_0.method_75(ref this.scenario_0);
				this.scenario_0.method_59(this.Name + str + " has neutralized mine: " + unguidedWeapon_0.Name, this.Name + " neutralized mine", LoggedMessage.MessageType.WeaponEndgame, 0, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
				sensor_2.vmethod_6(this.vmethod_7(false), false, false);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100007", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0007C210 File Offset: 0x0007A410
		public void method_107(bool bool_27, bool bool_28, float float_25, bool bool_29)
		{
			checked
			{
				try
				{
					if (!bool_27 && !this.bool_26)
					{
						if ((!this.bool_6 || (this.bool_6 && bool_28)) | (!this.bool_6 || !((Ship)this).method_152()))
						{
							this.scenario_0.method_86(this, float_25);
						}
						this.bool_26 = true;
					}
					if (this.vmethod_99().Length > 0)
					{
						try
						{
							foreach (Aircraft aircraft in this.vmethod_92().vmethod_4())
							{
								aircraft.vmethod_133(bool_27, base.method_6(), bool_29);
							}
						}
						finally
						{
							List<Aircraft>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					if (this.vmethod_100().Length > 0)
					{
						try
						{
							foreach (ActiveUnit activeUnit in this.vmethod_93().method_14())
							{
								activeUnit.vmethod_133(bool_27, base.method_6(), bool_29);
							}
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
					try
					{
						foreach (PlatformComponent platformComponent in this.vmethod_120())
						{
							platformComponent.vmethod_6(this.vmethod_7(false), bool_27, base.method_6());
						}
					}
					finally
					{
						IEnumerator<PlatformComponent> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
					foreach (Mission mission in Enumerable.ToArray<Mission>(Enumerable.SelectMany<Side, Mission>(this.scenario_0.method_44(), (ActiveUnit._Closure$__.$I394-0 == null) ? (ActiveUnit._Closure$__.$I394-0 = new Func<Side, IEnumerable<Mission>>(ActiveUnit._Closure$__.$I.method_3)) : ActiveUnit._Closure$__.$I394-0)))
					{
						if (mission is Strike)
						{
							Strike strike = (Strike)mission;
							foreach (Contact contact in Enumerable.ToArray<Contact>(Enumerable.OfType<Contact>(strike.hashSet_0)))
							{
								if (contact.activeUnit_0 != null)
								{
									if (contact.activeUnit_0 == this)
									{
										strike.hashSet_0.Remove(contact);
									}
								}
								else
								{
									strike.hashSet_0.Remove(contact);
								}
							}
							foreach (ActiveUnit activeUnit2 in Enumerable.ToArray<ActiveUnit>(Enumerable.OfType<ActiveUnit>(strike.hashSet_0)))
							{
								if (activeUnit2 == this)
								{
									strike.hashSet_0.Remove(activeUnit2);
								}
							}
						}
					}
					foreach (Cargo cargo in this.cargo_0)
					{
						if (cargo.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed && cargo.method_23() == Cargo.Enum111.const_1)
						{
							((Mount)cargo.method_25()).vmethod_6(this.vmethod_7(false), bool_27, true);
						}
					}
					Class429.smethod_26(ref this.sensor_0);
					this.vmethod_51().Clear();
					Class429.smethod_5(ref this.airFacility_0);
					Class429.smethod_18(ref this.dockFacility_0);
					Class429.smethod_8(ref this.cargo_0);
					if (this.vmethod_117() != null)
					{
						Magazine[] array5 = this.vmethod_117();
						Class429.smethod_23(ref array5);
					}
					if (this.vmethod_7(false) != null)
					{
						List<ActiveUnit> list = new List<ActiveUnit>();
						list.AddRange(this.vmethod_7(false).activeUnit_0);
						List<Class312> list2 = new List<Class312>();
						try
						{
							foreach (ActiveUnit activeUnit3 in list)
							{
								list2.AddRange(activeUnit3.vmethod_90().method_2());
								try
								{
									foreach (Class312 @class in list2)
									{
										if (@class.activeUnit_0 == this)
										{
											activeUnit3.vmethod_90().method_5(@class);
											if (activeUnit3.bool_2)
											{
												Weapon weapon = (Weapon)activeUnit3;
												if (weapon.method_179() != null)
												{
													weapon.method_180(null);
													Weapon weapon2 = weapon;
													float float_26 = 0f;
													Random random = GameGeneral.smethod_5();
													weapon2.vmethod_126(float_26, ref random);
												}
											}
										}
									}
								}
								finally
								{
									List<Class312>.Enumerator enumerator5;
									((IDisposable)enumerator5).Dispose();
								}
								list2.Clear();
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
					}
					List<ActiveUnit> list3 = new List<ActiveUnit>();
					list3.AddRange(this.scenario_0.method_42());
					try
					{
						foreach (ActiveUnit activeUnit4 in Enumerable.Where<ActiveUnit>(list3, (ActiveUnit._Closure$__.$I394-1 == null) ? (ActiveUnit._Closure$__.$I394-1 = new Func<ActiveUnit, bool>(ActiveUnit._Closure$__.$I.method_4)) : ActiveUnit._Closure$__.$I394-1))
						{
							if (activeUnit4.vmethod_127())
							{
								if (activeUnit4.bool_3)
								{
									if (((Aircraft)activeUnit4).method_164().method_32(false) == this)
									{
										((Aircraft)activeUnit4).method_164().method_28();
									}
								}
								else if ((activeUnit4.bool_6 || activeUnit4.bool_5) && activeUnit4.vmethod_93().method_11(false) == this)
								{
									activeUnit4.vmethod_93().method_44();
								}
							}
						}
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator6;
						if (enumerator6 != null)
						{
							enumerator6.Dispose();
						}
					}
					if (this.vmethod_86().vmethod_3() != null)
					{
						try
						{
							ConcurrentDictionary<string, ActiveUnit> concurrentDictionary = this.vmethod_86().vmethod_3().method_120(this.scenario_0, this.vmethod_7(false), false, null);
							string string_ = this.string_0;
							ActiveUnit activeUnit5 = this;
							concurrentDictionary.TryRemove(string_, ref activeUnit5);
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 200005", ex.Message);
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
					}
					if (this.vmethod_7(false) != null)
					{
						if (!this.bool_2)
						{
							this.vmethod_7(false).method_87(ref this.scenario_0, this.string_0);
						}
						else
						{
							this.vmethod_7(false).method_84(ref this.scenario_0, ref this.string_0);
						}
					}
					else if (!this.bool_2)
					{
						Side[] array6 = this.scenario_0.method_44();
						for (int m = 0; m < array6.Length; m++)
						{
							array6[m].method_87(ref this.scenario_0, this.string_0);
						}
					}
					else
					{
						Side[] array7 = this.scenario_0.method_44();
						for (int n = 0; n < array7.Length; n++)
						{
							array7[n].method_84(ref this.scenario_0, ref this.string_0);
						}
					}
					if (this.method_120())
					{
						this.vmethod_65(false).vmethod_141().Remove(this.string_0);
					}
					if (!bool_27 && this.vmethod_7(false) != null)
					{
						if (!this.bool_6 && !this.bool_2 && !this.bool_1)
						{
							string str = "";
							if (this.bool_3 && Operators.CompareString(this.Name, this.string_2, false) != 0)
							{
								str = " (" + this.string_2 + ")";
							}
							this.scenario_0.method_59(this.Name + str + " has been destroyed!", this.Name + " destroyed!", LoggedMessage.MessageType.UnitLost, 0, this.string_0, this.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
						}
						if (!this.bool_2 && !this.bool_1 && !base.method_6())
						{
							this.vmethod_7(false).class366_0.method_1(this, false);
						}
					}
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 100008", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0007CA04 File Offset: 0x0007AC04
		private int method_108()
		{
			int result;
			try
			{
				if (this.scenario_0.MaxRisingMineRange_meters == null)
				{
					DataTable dataTable = DBFunctions.smethod_6(this.scenario_0.method_39());
					float num;
					try
					{
						foreach (object obj in dataTable.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							if (Conversions.ToInteger(dataRow["Type"]) == 4008)
							{
								Weapon weapon = this.scenario_0.method_87(Conversions.ToInteger(dataRow["ID"])).warhead_0[0].method_17(this.scenario_0);
								if (weapon != null)
								{
									if (weapon.float_31 > num)
									{
										num = weapon.float_31;
									}
									if (weapon.float_35 > num)
									{
										num = weapon.float_35;
									}
								}
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
					if (num == 0f)
					{
						num = 1.5f;
					}
					this.scenario_0.MaxRisingMineRange_meters = new int?((int)Math.Round((double)(num * 1852f)));
				}
				result = this.scenario_0.MaxRisingMineRange_meters.Value;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100009", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0007CB94 File Offset: 0x0007AD94
		public virtual int vmethod_131(bool bool_27)
		{
			int result;
			if (bool_27)
			{
				result = this.method_108() * 3;
			}
			else
			{
				result = this.method_108();
			}
			return result;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0007CBB8 File Offset: 0x0007ADB8
		public virtual int vmethod_132(Weapon._WeaponType _WeaponType_0, bool bool_27)
		{
			int result;
			try
			{
				if (_WeaponType_0 == Weapon._WeaponType.RisingMine)
				{
					if (this.vmethod_59())
					{
						if (bool_27)
						{
							result = Math.Max((int)Math.Round((double)this.method_108() * 0.3), 1000);
						}
						else
						{
							result = (int)Math.Round((double)this.method_108() * 0.1);
						}
					}
					else if (bool_27)
					{
						result = Math.Max(this.method_108() * 3, 1000);
					}
					else
					{
						result = this.method_108();
					}
				}
				else if (this.vmethod_59())
				{
					if (bool_27)
					{
						result = 1000;
					}
					else
					{
						result = 100;
					}
				}
				else if (bool_27)
				{
					result = 1000;
				}
				else
				{
					result = 400;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100010", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				if (bool_27)
				{
					result = 1000;
				}
				else
				{
					result = 400;
				}
			}
			return result;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0007CCCC File Offset: 0x0007AECC
		public virtual void vmethod_133(bool bool_27, bool bool_28, bool bool_29)
		{
			checked
			{
				try
				{
					this.bool_24 = true;
					this.method_107(bool_27, false, this.vmethod_91().method_0(), bool_29);
					Side[] array = this.scenario_0.method_44();
					for (int i = 0; i < array.Length; i++)
					{
						array[i].method_63(this, bool_27);
					}
					try
					{
						foreach (ActiveUnit activeUnit in this.scenario_0.method_21())
						{
							List<Contact> list = new List<Contact>();
							foreach (Contact contact in activeUnit.vmethod_86().method_12())
							{
								if (contact.activeUnit_0 == this)
								{
									list.Add(contact);
								}
							}
							try
							{
								foreach (Contact theTarget in list)
								{
									activeUnit.vmethod_86().vmethod_15(theTarget, true);
								}
							}
							finally
							{
								List<Contact>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
						}
					}
					finally
					{
						List<Weapon>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					try
					{
						foreach (ActiveUnit activeUnit2 in this.vmethod_93().method_14())
						{
							activeUnit2.vmethod_133(bool_27, base.method_6(), bool_29);
						}
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
					try
					{
						foreach (Aircraft aircraft in this.vmethod_92().vmethod_4())
						{
							aircraft.vmethod_133(bool_27, base.method_6(), bool_29);
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
					if (bool_27)
					{
						this.method_109();
					}
					else if (bool_29)
					{
						this.scenario_0.method_65(this);
					}
					else
					{
						this.method_109();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100011", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x000071EE File Offset: 0x000053EE
		protected void method_109()
		{
			this.scenario_0.vmethod_0().Remove(this.string_0);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0007CF2C File Offset: 0x0007B12C
		public virtual void vmethod_134(ActiveUnit.Throttle newThrottleSetting, float? SpecificDesiredSpeed = null)
		{
			try
			{
				if (this.vmethod_84() != newThrottleSetting || SpecificDesiredSpeed != null || this.scenario_0.MinuteIsChangingOnThisPulse)
				{
					if (newThrottleSetting > ActiveUnit.Throttle.Flank)
					{
						newThrottleSetting = ActiveUnit.Throttle.Flank;
					}
					if (newThrottleSetting < ActiveUnit.Throttle.FullStop)
					{
						newThrottleSetting = ActiveUnit.Throttle.FullStop;
					}
					if (newThrottleSetting > this.vmethod_82())
					{
						newThrottleSetting = this.vmethod_82();
					}
					this.throttle_0 = newThrottleSetting;
					if (!this.bool_1)
					{
						if (SpecificDesiredSpeed == null)
						{
							this.vmethod_71((float)this.vmethod_87().vmethod_40(this.vmethod_14(false), this.throttle_0, false));
						}
						else if (this.vmethod_87().vmethod_1() == ActiveUnit_Kinematics.UnitThrottlePreset.None)
						{
							float? num = SpecificDesiredSpeed;
							float num2 = (float)this.vmethod_87().vmethod_40(this.vmethod_14(false), newThrottleSetting, false);
							bool? flag = (num != null) ? new bool?(num.GetValueOrDefault() > num2) : null;
							bool? flag2 = flag = ((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag);
							bool? flag3;
							bool? flag4;
							if (flag != null && !flag2.GetValueOrDefault())
							{
								flag3 = new bool?(false);
							}
							else
							{
								num = SpecificDesiredSpeed;
								num2 = (float)this.vmethod_87().vmethod_33((float)((int)Math.Round((double)this.vmethod_14(false))), newThrottleSetting, false);
								flag = ((num != null) ? new bool?(num.GetValueOrDefault() < num2) : null);
								flag4 = (flag = ((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag));
								flag3 = ((flag != null) ? (flag2 & flag4.GetValueOrDefault()) : null);
							}
							flag4 = flag3;
							if (flag4.GetValueOrDefault())
							{
								this.vmethod_71(SpecificDesiredSpeed.Value);
							}
							else
							{
								this.throttle_0 = this.vmethod_87().vmethod_41(this.vmethod_14(false), SpecificDesiredSpeed.Value);
								num = SpecificDesiredSpeed;
								num2 = (float)this.vmethod_87().vmethod_40(this.vmethod_14(false), this.throttle_0, false);
								if (((num != null) ? new bool?(num.GetValueOrDefault() > num2) : null).GetValueOrDefault())
								{
									this.vmethod_71((float)this.vmethod_87().vmethod_40(this.vmethod_14(false), this.throttle_0, false));
								}
							}
						}
						else
						{
							this.vmethod_71((float)this.vmethod_87().vmethod_40(this.vmethod_14(false), (ActiveUnit.Throttle)this.vmethod_87().vmethod_1(), false));
						}
					}
					this.method_110(this, this.throttle_0);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100013", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0007D204 File Offset: 0x0007B404
		public void method_110(ActiveUnit activeUnit_0, ActiveUnit.Throttle throttle_5)
		{
			ActiveUnit.Delegate11 @delegate = ActiveUnit.delegate11_0;
			if (@delegate != null)
			{
				@delegate(activeUnit_0, throttle_5);
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0007D224 File Offset: 0x0007B424
		public bool method_111()
		{
			AirFacility[] array = this.vmethod_99();
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].method_31())
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0007D258 File Offset: 0x0007B458
		public bool method_112()
		{
			return this.vmethod_99() != null && this.vmethod_99().Length > 0;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00007207 File Offset: 0x00005407
		public bool method_113()
		{
			return Enumerable.Count<Cargo>(this.cargo_0) != 0;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0007D280 File Offset: 0x0007B480
		public bool method_114()
		{
			return this.vmethod_100() != null && this.vmethod_100().Length > 0;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0007D2A8 File Offset: 0x0007B4A8
		public bool method_115()
		{
			bool result;
			try
			{
				List<Sensor> list = new List<Sensor>();
				list.AddRange(this.method_78());
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (list[i].sensor_Type_0 == Sensor.Sensor_Type.Radar)
					{
						return true;
					}
				}
				if (this.bool_2)
				{
					Weapon weapon = (Weapon)this;
					foreach (Warhead warhead in weapon.warhead_0)
					{
						if (warhead.warheadType_0 == Warhead.WarheadType.Weapon)
						{
							Weapon weapon2 = warhead.method_17(weapon.scenario_0);
							List<Sensor> list2 = new List<Sensor>();
							list2.AddRange(weapon2.method_78());
							int num2 = list2.Count - 1;
							for (int k = 0; k <= num2; k++)
							{
								if (list2[k].sensor_Type_0 == Sensor.Sensor_Type.Radar)
								{
									return true;
								}
							}
						}
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100014", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0007D3E8 File Offset: 0x0007B5E8
		public bool method_116()
		{
			bool result;
			try
			{
				List<Sensor> list = new List<Sensor>();
				list.AddRange(this.method_78());
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (list[i].sensor_Type_0 == Sensor.Sensor_Type.Infrared)
					{
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100015", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00007217 File Offset: 0x00005417
		public bool method_117()
		{
			return this.vmethod_95().Count > 0;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00007227 File Offset: 0x00005427
		public bool method_118()
		{
			return Enumerable.Count<Sensor>(Enumerable.Where<Sensor>(this.vmethod_96(), (ActiveUnit._Closure$__.$I418-0 == null) ? (ActiveUnit._Closure$__.$I418-0 = new Func<Sensor, bool>(ActiveUnit._Closure$__.$I.method_5)) : ActiveUnit._Closure$__.$I418-0)) > 0;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0007D484 File Offset: 0x0007B684
		public bool method_119()
		{
			bool result;
			try
			{
				foreach (Sensor sensor in this.method_78())
				{
					if (sensor.method_74() && sensor.method_58())
					{
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100016", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00007260 File Offset: 0x00005460
		public bool method_120()
		{
			return this.vmethod_65(false) != null;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0007D50C File Offset: 0x0007B70C
		public bool method_121()
		{
			return this.method_120() && !this.method_122();
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0007D530 File Offset: 0x0007B730
		public bool method_122()
		{
			return this.method_120() && this.vmethod_65(false).method_147() == this;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0007D55C File Offset: 0x0007B75C
		public void method_123(Mission.Flight flight_0, int int_6)
		{
			if (this.method_120())
			{
				switch (int_6)
				{
				case 1:
					this.enum106_0 = Mission.Flight.Enum106.const_1;
					break;
				case 2:
					this.enum106_0 = Mission.Flight.Enum106.const_2;
					break;
				case 3:
					this.enum106_0 = Mission.Flight.Enum106.const_3;
					break;
				case 4:
					this.enum106_0 = Mission.Flight.Enum106.const_4;
					break;
				case 5:
					this.enum106_0 = Mission.Flight.Enum106.const_5;
					break;
				case 6:
					this.enum106_0 = Mission.Flight.Enum106.const_6;
					break;
				default:
					this.enum106_0 = Mission.Flight.Enum106.const_0;
					break;
				}
			}
			else
			{
				this.enum106_0 = Mission.Flight.Enum106.const_0;
			}
			this.vmethod_85().method_8(flight_0);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0000726C File Offset: 0x0000546C
		public void method_124(string string_9, string string_10, LoggedMessage.MessageType messageType_0, byte byte_0, bool bool_27, Geopoint_Struct geopoint_Struct_0)
		{
			if (bool_27)
			{
				this.string_3 = string_9;
			}
			this.scenario_0.method_59(string_9, string_10, messageType_0, byte_0, this.string_0, this.vmethod_7(false), geopoint_Struct_0);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00007298 File Offset: 0x00005498
		public void method_125(CommDevice commDevice_1)
		{
			Class429.smethod_10(ref this.commDevice_0, commDevice_1);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0007D5E8 File Offset: 0x0007B7E8
		public virtual void vmethod_135(float float_25, FuelRec._FuelType _FuelType_0)
		{
			try
			{
				float num = float_25;
				foreach (FuelRec fuelRec in this.vmethod_67())
				{
					if (num == 0f)
					{
						break;
					}
					if (fuelRec._FuelType_0 == _FuelType_0)
					{
						float num2 = (float)fuelRec.int_0 - fuelRec.float_0;
						if (num2 > num)
						{
							FuelRec fuelRec2 = fuelRec;
							ref float ptr = ref fuelRec2.float_0;
							fuelRec2.float_0 = ptr + num;
							num = 0f;
						}
						else
						{
							fuelRec.float_0 = (float)fuelRec.int_0;
							num -= num2;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100017", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0007D6B0 File Offset: 0x0007B8B0
		public virtual void vmethod_136(float float_25, FuelRec._FuelType _FuelType_0)
		{
			ActiveUnit.Class165 @class = new ActiveUnit.Class165();
			@class._FuelType_0 = _FuelType_0;
			try
			{
				if (float_25 != 0f)
				{
					FuelRec fuelRec = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Where<FuelRec>(Enumerable.Select<FuelRec, FuelRec>(this.vmethod_67(), (ActiveUnit._Closure$__.$I429-0 == null) ? (ActiveUnit._Closure$__.$I429-0 = new Func<FuelRec, FuelRec>(ActiveUnit._Closure$__.$I.method_6)) : ActiveUnit._Closure$__.$I429-0), new Func<FuelRec, bool>(@class.method_0)), 0);
					if (fuelRec.float_0 > float_25)
					{
						fuelRec.float_0 -= float_25;
					}
					else
					{
						bool flag = fuelRec.float_0 > 0f;
						fuelRec.float_0 = 0f;
						this.vmethod_134(ActiveUnit.Throttle.FullStop, null);
						if (flag)
						{
							this.method_124(this.Name + " (" + Misc.smethod_9(this.string_2) + ") has run out of fuel!", "Unit out of fuel", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100018", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0000378C File Offset: 0x0000198C
		public virtual void vmethod_137(float float_25)
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0007D800 File Offset: 0x0007BA00
		public virtual void vmethod_138(ActiveUnit activeUnit_0)
		{
			bool flag = !activeUnit_0.bool_1;
			bool flag2 = false;
			bool flag3 = false;
			if (activeUnit_0.bool_1)
			{
				if (((Group)activeUnit_0).method_143() == Group.GroupType.AirBase)
				{
					flag3 = true;
				}
				else
				{
					flag2 = true;
				}
			}
			if (flag || flag3)
			{
				string text = this.vmethod_93().method_45(activeUnit_0);
				if (Operators.CompareString(text, "OK", false) == 0)
				{
					this.vmethod_93().method_12(false, activeUnit_0);
					this.scenario_0.method_59(activeUnit_0.Name + " is now the base for " + this.Name, this.Name + " has new home base", LoggedMessage.MessageType.DockingOps, 5, this.string_0, this.vmethod_7(false), default(Geopoint_Struct));
				}
				else
				{
					this.scenario_0.method_59(string.Concat(new string[]
					{
						"Failed to set ",
						activeUnit_0.Name,
						" as the new base for ",
						this.Name,
						". Reason: ",
						text
					}), "Failed to re-base " + this.Name, LoggedMessage.MessageType.DockingOps, 5, this.string_0, this.vmethod_7(false), default(Geopoint_Struct));
				}
			}
			if (flag2)
			{
				Unit unit = null;
				try
				{
					foreach (ActiveUnit activeUnit in ((Group)activeUnit_0).vmethod_141().Values)
					{
						if (Operators.CompareString(this.vmethod_93().method_45(activeUnit), "OK", false) == 0)
						{
							this.vmethod_93().method_12(false, activeUnit);
							unit = activeUnit;
							break;
						}
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (unit == null)
				{
					this.scenario_0.method_59("Failed to set " + activeUnit_0.Name + " as the new base for " + this.Name, "Failed to re-base " + this.Name, LoggedMessage.MessageType.DockingOps, 5, this.string_0, this.vmethod_7(false), default(Geopoint_Struct));
					return;
				}
				this.scenario_0.method_59(activeUnit_0.Name + " is now the base for " + this.Name, this.Name + " has new home base", LoggedMessage.MessageType.DockingOps, 5, this.string_0, this.vmethod_7(false), default(Geopoint_Struct));
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0007DA40 File Offset: 0x0007BC40
		public void method_126()
		{
			checked
			{
				try
				{
					ActiveUnit_AI activeUnit_AI = this.vmethod_86();
					ActiveUnit activeUnit = this;
					activeUnit_AI.method_33(ref activeUnit);
					Side[] array = this.scenario_0.method_44();
					for (int i = 0; i < array.Length; i++)
					{
						array[i].method_58(this);
					}
					ActiveUnit activeUnit2;
					if (this.bool_3)
					{
						activeUnit2 = ((Aircraft)this).method_164().method_30();
					}
					else
					{
						activeUnit2 = this.vmethod_93().method_17();
					}
					if (activeUnit2 != null)
					{
						if (activeUnit2.vmethod_90().vmethod_1())
						{
							this.vmethod_90().method_1(ActiveUnit_CommStuff.Enum31.const_0, true);
						}
						else if (this.vmethod_90().vmethod_1())
						{
							ActiveUnit_CommStuff.Enum31 enum31_ = activeUnit2.vmethod_90().method_0();
							activeUnit2.vmethod_90().method_1(ActiveUnit_CommStuff.Enum31.const_0, true);
							activeUnit2.vmethod_90().method_1(enum31_, false);
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100019", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0007DB44 File Offset: 0x0007BD44
		public void method_127(Sensor sensor_2)
		{
			try
			{
				Class429.smethod_25(ref this.sensor_0, sensor_2);
				try
				{
					foreach (Mount mount in this.vmethod_51())
					{
						mount.method_40(sensor_2);
					}
				}
				finally
				{
					List<Mount>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.method_79(null);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100020", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0007DBEC File Offset: 0x0007BDEC
		public bool method_128(Scenario scenario_1)
		{
			bool result;
			try
			{
				if (scenario_1.method_17().Count > 0)
				{
					List<Weapon> list = scenario_1.method_17();
					if (list == null)
					{
						return false;
					}
					try
					{
						foreach (Weapon weapon in list)
						{
							if (weapon != null)
							{
								Weapon_AI weapon_AI = weapon.vmethod_142();
								if (weapon_AI != null && weapon_AI.vmethod_3() != null && weapon_AI.vmethod_3().activeUnit_0 != null && weapon_AI.vmethod_3().activeUnit_0 == this)
								{
									return true;
								}
								if (weapon.method_219())
								{
									foreach (Contact contact in weapon_AI.method_12())
									{
										if (contact.activeUnit_0 != null && contact.activeUnit_0 == this)
										{
											return true;
										}
									}
								}
							}
						}
					}
					finally
					{
						List<Weapon>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (scenario_1.method_45().Count > 0)
				{
					List<ActiveUnit> list2 = Enumerable.ToList<ActiveUnit>(scenario_1.method_45());
					try
					{
						foreach (ActiveUnit activeUnit in list2)
						{
							if (activeUnit.bool_2)
							{
								Weapon_AI weapon_AI = ((Weapon)activeUnit).vmethod_142();
								if (weapon_AI.vmethod_3() != null && weapon_AI.vmethod_3().activeUnit_0 != null && weapon_AI.vmethod_3().activeUnit_0 == this)
								{
									return true;
								}
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200273", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0007DDE0 File Offset: 0x0007BFE0
		public void method_129(bool bool_27, bool bool_28, bool bool_29)
		{
			if (!this.bool_2 && this.method_120())
			{
				try
				{
					if (this.method_122() && this.vmethod_65(false).vmethod_141().Count > 1)
					{
						ActiveUnit activeUnit2;
						if (this.bool_8)
						{
							try
							{
								foreach (ActiveUnit activeUnit in this.vmethod_65(false).vmethod_141().Values)
								{
									if (activeUnit != this)
									{
										activeUnit2 = activeUnit;
									}
								}
								goto IL_DB;
							}
							finally
							{
								IEnumerator<ActiveUnit> enumerator;
								if (enumerator != null)
								{
									enumerator.Dispose();
								}
							}
						}
						double num = 0.0;
						try
						{
							foreach (ActiveUnit activeUnit3 in this.vmethod_65(false).vmethod_141().Values)
							{
								if (activeUnit3 != this && (double)activeUnit3.int_0 > num)
								{
									activeUnit2 = activeUnit3;
									num = (double)activeUnit3.int_0;
								}
							}
						}
						finally
						{
							IEnumerator<ActiveUnit> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						IL_DB:
						if (activeUnit2 != null)
						{
							this.vmethod_65(false).method_153(activeUnit2);
							activeUnit2.vmethod_109(this.vmethod_108());
							activeUnit2.vmethod_87().vmethod_11(this.vmethod_87().vmethod_10());
							activeUnit2.vmethod_87().vmethod_13(this.vmethod_87().vmethod_12());
							activeUnit2.vmethod_73(this.vmethod_72());
							activeUnit2.vmethod_75(this.vmethod_74());
							activeUnit2.vmethod_71(this.vmethod_70());
							activeUnit2.vmethod_77(activeUnit2, this.vmethod_76(this));
						}
					}
					if (bool_27)
					{
						string str = "";
						if (this.bool_3 && Operators.CompareString(this.Name, this.string_2, false) != 0)
						{
							str = " (" + this.string_2 + ")";
						}
						this.scenario_0.method_59(this.Name + str + " has been detached from group: " + this.vmethod_65(false).Name, this.Name + " detached", LoggedMessage.MessageType.UnitAI, 5, this.string_0, this.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					}
					if (bool_29 && this.bool_3 && this.vmethod_65(false).method_147() != null && this.vmethod_65(false).method_147().vmethod_85().method_47())
					{
						foreach (Waypoint waypoint_ in this.vmethod_65(false).method_147().vmethod_85().method_4())
						{
							ActiveUnit_Navigator activeUnit_Navigator = this.vmethod_85();
							Waypoint[] waypoint_2 = activeUnit_Navigator.method_4();
							Class429.smethod_36(ref waypoint_2, waypoint_);
							activeUnit_Navigator.method_5(waypoint_2);
						}
					}
					this.vmethod_66(false, null);
					if (bool_28)
					{
						this.vmethod_85().vmethod_9();
					}
					this.vmethod_87().vmethod_11(null);
					this.vmethod_87().vmethod_13(false);
					this.doctrine_0.method_4();
					this.vmethod_88().vmethod_5(this.method_78());
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101262", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0007E14C File Offset: 0x0007C34C
		public bool method_130(double double_4, double double_5, float float_25)
		{
			bool result;
			try
			{
				try
				{
					foreach (NoNavZone noNavZone in this.vmethod_7(false).list_7)
					{
						if (noNavZone.list_0.Count != 0 && noNavZone.method_8(this))
						{
							if (float_25 == 0.2f)
							{
								if (noNavZone.list_1.Count == 0 || noNavZone.method_12(noNavZone.list_1))
								{
									noNavZone.method_9(float_25, ref noNavZone.list_3, ref noNavZone.list_1);
								}
								if (GeoPoint.smethod_3(double_4, double_5, noNavZone.list_3, true))
								{
									return true;
								}
							}
							else if (float_25 == 0.15f)
							{
								if (noNavZone.list_2.Count == 0 || noNavZone.method_12(noNavZone.list_2))
								{
									noNavZone.method_9(float_25, ref noNavZone.list_4, ref noNavZone.list_2);
								}
								if (GeoPoint.smethod_3(double_4, double_5, noNavZone.list_4, true))
								{
									return true;
								}
							}
							else if (GeoPoint.smethod_4(double_4, double_5, noNavZone.list_0, true))
							{
								return true;
							}
						}
					}
				}
				finally
				{
					List<NoNavZone>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101268", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0007E2D0 File Offset: 0x0007C4D0
		public bool method_131()
		{
			bool result;
			try
			{
				if (this.vmethod_7(false).list_7.Count == 0)
				{
					result = false;
				}
				else
				{
					if (this.vmethod_85().double_9 <= 0.0)
					{
						float num = float.MaxValue;
						try
						{
							foreach (NoNavZone noNavZone in this.vmethod_7(false).list_7)
							{
								if (noNavZone.list_0.Count != 0 && noNavZone.method_8(this))
								{
									float num2 = noNavZone.method_10(this.vmethod_30(null), this.vmethod_28(null), this.scenario_0);
									if (num2 < num)
									{
										num = num2;
									}
								}
							}
						}
						finally
						{
							List<NoNavZone>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (num < 10f)
						{
							this.vmethod_85().double_9 = 300.0;
							this.vmethod_85().bool_13 = true;
						}
						else
						{
							double num3 = (double)((num - 5f) / (float)this.vmethod_87().vmethod_38() * 3600f);
							if (num3 > 300.0)
							{
								num3 = 300.0;
							}
							this.vmethod_85().double_9 = num3;
							this.vmethod_85().bool_13 = false;
						}
					}
					if (this.vmethod_85().bool_13)
					{
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200340", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				this.vmethod_85().double_9 = 300.0;
				this.vmethod_85().bool_13 = true;
				result = true;
			}
			return result;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0007E4B8 File Offset: 0x0007C6B8
		private void method_132(object sender, EventArgs5<Mount> e)
		{
			try
			{
				foreach (Mount mount in e.method_0())
				{
					ActiveUnit.Delegate14 @delegate = ActiveUnit.delegate14_0;
					if (@delegate != null)
					{
						@delegate(this.string_0, mount.string_0);
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
			this.bool_25 = false;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0007E520 File Offset: 0x0007C720
		private void method_133(object sender, EventArgs5<Mount> e)
		{
			try
			{
				foreach (Mount mount in e.method_0())
				{
					ActiveUnit.Delegate15 @delegate = ActiveUnit.delegate15_0;
					if (@delegate != null)
					{
						@delegate(this.string_0, mount.string_0);
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
			this.method_134();
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0007E588 File Offset: 0x0007C788
		public void method_134()
		{
			if (this.vmethod_51().Count != 0)
			{
				this.bool_25 = false;
				return;
			}
			if (base.method_5())
			{
				this.bool_25 = true;
				return;
			}
			if (this.vmethod_56() == GlobalVariables.ActiveUnitType.Facility && ((Facility)this).method_154())
			{
				this.bool_25 = false;
				return;
			}
			this.bool_25 = (this.vmethod_49().Count == 0);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000072A6 File Offset: 0x000054A6
		private void method_135(object sender, EventArgs5<Engine> e)
		{
			this.bool_25 = false;
			this.vmethod_87().method_1();
			this.vmethod_87().method_8();
			this.nullable_12 = null;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x000072D1 File Offset: 0x000054D1
		private void method_136(object sender, EventArgs5<Engine> e)
		{
			this.method_134();
			this.vmethod_87().method_1();
			this.vmethod_87().method_8();
			this.nullable_12 = null;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000072FB File Offset: 0x000054FB
		[CompilerGenerated]
		private bool method_137(Weapon weapon_1)
		{
			return weapon_1.method_177() == this && weapon_1.struct36_0.bool_1;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00007313 File Offset: 0x00005513
		[CompilerGenerated]
		private bool method_138(Weapon weapon_1)
		{
			return weapon_1.method_177() == this && (weapon_1.struct36_0.bool_1 || weapon_1.struct36_0.bool_0) && weapon_1.vmethod_142().vmethod_3() != null;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00007348 File Offset: 0x00005548
		[CompilerGenerated]
		private double method_139(Weapon weapon_1)
		{
			return base.method_31(weapon_1);
		}

		// Token: 0x040004D8 RID: 1240
		public int DBID;

		// Token: 0x040004D9 RID: 1241
		private double? nullable_10;

		// Token: 0x040004DA RID: 1242
		private double? nullable_11;

		// Token: 0x040004DB RID: 1243
		internal double double_2;

		// Token: 0x040004DC RID: 1244
		internal double double_3;

		// Token: 0x040004DD RID: 1245
		protected float float_9;

		// Token: 0x040004DE RID: 1246
		protected float float_10;

		// Token: 0x040004DF RID: 1247
		protected float float_11;

		// Token: 0x040004E0 RID: 1248
		protected float float_12;

		// Token: 0x040004E1 RID: 1249
		protected ActiveUnit.Enum28 enum28_0;

		// Token: 0x040004E2 RID: 1250
		protected Waypoint.Enum81 enum81_0;

		// Token: 0x040004E3 RID: 1251
		protected bool bool_12;

		// Token: 0x040004E4 RID: 1252
		public float float_13;

		// Token: 0x040004E5 RID: 1253
		public int int_0;

		// Token: 0x040004E6 RID: 1254
		public int int_1;

		// Token: 0x040004E7 RID: 1255
		public int int_2;

		// Token: 0x040004E8 RID: 1256
		public Scenario scenario_0;

		// Token: 0x040004E9 RID: 1257
		protected ActiveUnit.Throttle throttle_0;

		// Token: 0x040004EA RID: 1258
		protected Sensor[] sensor_0;

		// Token: 0x040004EB RID: 1259
		protected CommDevice[] commDevice_0;

		// Token: 0x040004EC RID: 1260
		[CompilerGenerated]
		[AccessedThroughProperty("Propulsion")]
		private ObservableList<Engine> observableList_0;

		// Token: 0x040004ED RID: 1261
		protected FuelRec[] fuelRec_0;

		// Token: 0x040004EE RID: 1262
		private XSection[] xsection_0;

		// Token: 0x040004EF RID: 1263
		[CompilerGenerated]
		[AccessedThroughProperty("Mounts")]
		private ObservableList<Mount> observableList_1;

		// Token: 0x040004F0 RID: 1264
		public Cargo[] cargo_0;

		// Token: 0x040004F1 RID: 1265
		protected ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_0;

		// Token: 0x040004F2 RID: 1266
		protected ActiveUnit._ActiveUnitFuelState _ActiveUnitFuelState_0;

		// Token: 0x040004F3 RID: 1267
		protected ActiveUnit._ActiveUnitWeaponState _ActiveUnitWeaponState_0;

		// Token: 0x040004F4 RID: 1268
		private float float_14;

		// Token: 0x040004F5 RID: 1269
		protected AirFacility[] airFacility_0;

		// Token: 0x040004F6 RID: 1270
		protected DockFacility[] dockFacility_0;

		// Token: 0x040004F7 RID: 1271
		protected Mission mission_0;

		// Token: 0x040004F8 RID: 1272
		protected string string_4;

		// Token: 0x040004F9 RID: 1273
		protected Mission mission_1;

		// Token: 0x040004FA RID: 1274
		protected string string_5;

		// Token: 0x040004FB RID: 1275
		protected Group group_0;

		// Token: 0x040004FC RID: 1276
		protected string string_6;

		// Token: 0x040004FD RID: 1277
		private bool bool_13;

		// Token: 0x040004FE RID: 1278
		public Doctrine doctrine_0;

		// Token: 0x040004FF RID: 1279
		internal bool bool_14;

		// Token: 0x04000500 RID: 1280
		protected string string_7;

		// Token: 0x04000501 RID: 1281
		internal short short_0;

		// Token: 0x04000502 RID: 1282
		internal short short_1;

		// Token: 0x04000503 RID: 1283
		internal short short_2;

		// Token: 0x04000504 RID: 1284
		internal bool bool_15;

		// Token: 0x04000505 RID: 1285
		internal bool bool_16;

		// Token: 0x04000506 RID: 1286
		private ActiveUnit.Throttle? nullable_12;

		// Token: 0x04000507 RID: 1287
		internal ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_1;

		// Token: 0x04000508 RID: 1288
		internal float float_15;

		// Token: 0x04000509 RID: 1289
		internal ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_2;

		// Token: 0x0400050A RID: 1290
		internal ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_3;

		// Token: 0x0400050B RID: 1291
		internal ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_4;

		// Token: 0x0400050C RID: 1292
		internal ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_5;

		// Token: 0x0400050D RID: 1293
		internal bool bool_17;

		// Token: 0x0400050E RID: 1294
		internal float? nullable_13;

		// Token: 0x0400050F RID: 1295
		internal bool bool_18;

		// Token: 0x04000510 RID: 1296
		internal float float_16;

		// Token: 0x04000511 RID: 1297
		internal ActiveUnit._ActiveUnitFuelState _ActiveUnitFuelState_1;

		// Token: 0x04000512 RID: 1298
		internal float float_17;

		// Token: 0x04000513 RID: 1299
		internal float float_18;

		// Token: 0x04000514 RID: 1300
		internal bool bool_19;

		// Token: 0x04000515 RID: 1301
		internal ActiveUnit.Throttle throttle_1;

		// Token: 0x04000516 RID: 1302
		internal float float_19;

		// Token: 0x04000517 RID: 1303
		internal float? nullable_14;

		// Token: 0x04000518 RID: 1304
		internal bool bool_20;

		// Token: 0x04000519 RID: 1305
		internal ActiveUnit.Throttle throttle_2;

		// Token: 0x0400051A RID: 1306
		internal float float_20;

		// Token: 0x0400051B RID: 1307
		internal float float_21;

		// Token: 0x0400051C RID: 1308
		internal bool bool_21;

		// Token: 0x0400051D RID: 1309
		internal ActiveUnit.Throttle throttle_3;

		// Token: 0x0400051E RID: 1310
		internal float float_22;

		// Token: 0x0400051F RID: 1311
		internal float float_23;

		// Token: 0x04000520 RID: 1312
		internal bool bool_22;

		// Token: 0x04000521 RID: 1313
		internal ActiveUnit.Throttle throttle_4;

		// Token: 0x04000522 RID: 1314
		public float float_24;

		// Token: 0x04000523 RID: 1315
		protected GlobalVariables.ProficiencyLevel? nullable_15;

		// Token: 0x04000524 RID: 1316
		public int int_3;

		// Token: 0x04000525 RID: 1317
		public bool bool_23;

		// Token: 0x04000526 RID: 1318
		private string string_8;

		// Token: 0x04000527 RID: 1319
		public bool bool_24;

		// Token: 0x04000528 RID: 1320
		public Weapon[] weapon_0;

		// Token: 0x04000529 RID: 1321
		private int int_4;

		// Token: 0x0400052A RID: 1322
		public Mission.Flight.Enum106 enum106_0;

		// Token: 0x0400052B RID: 1323
		public int int_5;

		// Token: 0x0400052C RID: 1324
		public bool bool_25;

		// Token: 0x0400052D RID: 1325
		public ActiveUnit.Struct26 struct26_0;

		// Token: 0x0400052E RID: 1326
		private ActiveUnit_Navigator activeUnit_Navigator_0;

		// Token: 0x0400052F RID: 1327
		protected ActiveUnit_AI activeUnit_AI_0;

		// Token: 0x04000530 RID: 1328
		private ActiveUnit_Kinematics activeUnit_Kinematics_0;

		// Token: 0x04000531 RID: 1329
		protected ActiveUnit_Sensory activeUnit_Sensory_0;

		// Token: 0x04000532 RID: 1330
		private ActiveUnit_Weaponry activeUnit_Weaponry_0;

		// Token: 0x04000533 RID: 1331
		protected ActiveUnit_CommStuff activeUnit_CommStuff_0;

		// Token: 0x04000534 RID: 1332
		protected ActiveUnit_Damage activeUnit_Damage_0;

		// Token: 0x04000535 RID: 1333
		protected ActiveUnit_DockingOps activeUnit_DockingOps_0;

		// Token: 0x04000536 RID: 1334
		protected ActiveUnit_AirOps activeUnit_AirOps_0;

		// Token: 0x04000537 RID: 1335
		internal List<string> list_2;

		// Token: 0x04000538 RID: 1336
		[CompilerGenerated]
		private static ActiveUnit.Delegate11 delegate11_0;

		// Token: 0x04000539 RID: 1337
		[CompilerGenerated]
		private static ActiveUnit.Delegate12 delegate12_0;

		// Token: 0x0400053A RID: 1338
		[CompilerGenerated]
		private static ActiveUnit.Delegate13 delegate13_0;

		// Token: 0x0400053B RID: 1339
		[CompilerGenerated]
		private static ActiveUnit.Delegate14 delegate14_0;

		// Token: 0x0400053C RID: 1340
		[CompilerGenerated]
		private static ActiveUnit.Delegate15 delegate15_0;

		// Token: 0x0400053D RID: 1341
		protected bool bool_26;

		// Token: 0x0400053E RID: 1342
		private Sensor[] sensor_1;

		// Token: 0x0200011E RID: 286
		// (Invoke) Token: 0x060007AC RID: 1964
		internal delegate void Delegate11(ActiveUnit theUnit, ActiveUnit.Throttle NewThrottleSetting);

		// Token: 0x0200011F RID: 287
		// (Invoke) Token: 0x060007B0 RID: 1968
		internal delegate void Delegate12(string UnitObjectID);

		// Token: 0x02000120 RID: 288
		// (Invoke) Token: 0x060007B4 RID: 1972
		internal delegate void Delegate13(string UnitObjectID);

		// Token: 0x02000121 RID: 289
		// (Invoke) Token: 0x060007B8 RID: 1976
		internal delegate void Delegate14(string UnitObjectID, string NewMountObjectID);

		// Token: 0x02000122 RID: 290
		// (Invoke) Token: 0x060007BC RID: 1980
		internal delegate void Delegate15(string UnitObjectID, string RemovedMountObjectID);

		// Token: 0x02000123 RID: 291
		internal enum Enum28 : byte
		{
			// Token: 0x04000540 RID: 1344
			const_0,
			// Token: 0x04000541 RID: 1345
			const_1
		}

		// Token: 0x02000124 RID: 292
		public enum Throttle : byte
		{
			// Token: 0x04000543 RID: 1347
			FullStop,
			// Token: 0x04000544 RID: 1348
			Loiter,
			// Token: 0x04000545 RID: 1349
			Cruise,
			// Token: 0x04000546 RID: 1350
			Full,
			// Token: 0x04000547 RID: 1351
			Flank
		}

		// Token: 0x02000125 RID: 293
		public enum _ActiveUnitStatus : byte
		{
			// Token: 0x04000549 RID: 1353
			Unassigned,
			// Token: 0x0400054A RID: 1354
			OnPlottedCourse,
			// Token: 0x0400054B RID: 1355
			EngagedOffensive,
			// Token: 0x0400054C RID: 1356
			EngagedDefensive,
			// Token: 0x0400054D RID: 1357
			OnAttackRun,
			// Token: 0x0400054E RID: 1358
			OnPatrol,
			// Token: 0x0400054F RID: 1359
			RTB,
			// Token: 0x04000550 RID: 1360
			Tasked,
			// Token: 0x04000551 RID: 1361
			FormingUp,
			// Token: 0x04000552 RID: 1362
			RTB_Manual = 10,
			// Token: 0x04000553 RID: 1363
			OnSupportMission,
			// Token: 0x04000554 RID: 1364
			OnFerryMission,
			// Token: 0x04000555 RID: 1365
			HeadingToRefuelPoint,
			// Token: 0x04000556 RID: 1366
			Refuelling,
			// Token: 0x04000557 RID: 1367
			RTB_MissionOver,
			// Token: 0x04000558 RID: 1368
			GroupLead_SlowingToAllowFormUp,
			// Token: 0x04000559 RID: 1369
			RTB_Group = 19,
			// Token: 0x0400055A RID: 1370
			RTB_CalledOff,
			// Token: 0x0400055B RID: 1371
			WaitForPathfinder,
			// Token: 0x0400055C RID: 1372
			AttemptingToReestablishComms
		}

		// Token: 0x02000126 RID: 294
		public enum _ActiveUnitFuelState : byte
		{
			// Token: 0x0400055E RID: 1374
			None,
			// Token: 0x0400055F RID: 1375
			IsBingo,
			// Token: 0x04000560 RID: 1376
			IsJoker,
			// Token: 0x04000561 RID: 1377
			IgnoreBingoAndJoker
		}

		// Token: 0x02000127 RID: 295
		public enum _ActiveUnitWeaponState : byte
		{
			// Token: 0x04000563 RID: 1379
			None,
			// Token: 0x04000564 RID: 1380
			IsWinchester,
			// Token: 0x04000565 RID: 1381
			IsWinchester_EngagingToO,
			// Token: 0x04000566 RID: 1382
			IsShotgun,
			// Token: 0x04000567 RID: 1383
			IsShotgun_EngagingToO,
			// Token: 0x04000568 RID: 1384
			IgnoreWinchesterAndShotgun
		}

		// Token: 0x02000128 RID: 296
		internal enum Enum29 : byte
		{
			// Token: 0x0400056A RID: 1386
			const_0,
			// Token: 0x0400056B RID: 1387
			const_1,
			// Token: 0x0400056C RID: 1388
			const_2,
			// Token: 0x0400056D RID: 1389
			const_3,
			// Token: 0x0400056E RID: 1390
			const_4,
			// Token: 0x0400056F RID: 1391
			const_5
		}

		// Token: 0x02000129 RID: 297
		internal struct Struct26
		{
			// Token: 0x04000570 RID: 1392
			internal byte byte_0;

			// Token: 0x04000571 RID: 1393
			internal byte byte_1;

			// Token: 0x04000572 RID: 1394
			internal byte byte_2;

			// Token: 0x04000573 RID: 1395
			internal byte byte_3;

			// Token: 0x04000574 RID: 1396
			internal byte byte_4;

			// Token: 0x04000575 RID: 1397
			internal byte byte_5;

			// Token: 0x04000576 RID: 1398
			internal byte byte_6;

			// Token: 0x04000577 RID: 1399
			internal byte byte_7;

			// Token: 0x04000578 RID: 1400
			internal byte byte_8;

			// Token: 0x04000579 RID: 1401
			internal byte byte_9;

			// Token: 0x0400057A RID: 1402
			internal byte byte_10;

			// Token: 0x0400057B RID: 1403
			internal byte byte_11;
		}

		// Token: 0x0200012B RID: 299
		[CompilerGenerated]
		internal sealed class Class164
		{
			// Token: 0x060007C7 RID: 1991 RVA: 0x000073B0 File Offset: 0x000055B0
			internal bool method_0(Sensor sensor_0)
			{
				return sensor_0.method_41().Contains(this.contact_0);
			}

			// Token: 0x04000584 RID: 1412
			public Contact contact_0;
		}

		// Token: 0x0200012C RID: 300
		[CompilerGenerated]
		internal sealed class Class165
		{
			// Token: 0x060007C9 RID: 1993 RVA: 0x000073C3 File Offset: 0x000055C3
			internal bool method_0(FuelRec fuelRec_0)
			{
				return fuelRec_0._FuelType_0 == this._FuelType_0;
			}

			// Token: 0x04000585 RID: 1413
			public FuelRec._FuelType _FuelType_0;
		}
	}
}
