using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Command_Core.DAL;
using DarkUI.Collections;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns10;
using ns11;
using ns12;
using ns13;
using ns14;
using ns9;

namespace Command_Core.Lua
{
	// Token: 0x0200043C RID: 1084
	[StandardModule]
	public sealed class PrivateMethods
	{
		// Token: 0x06002108 RID: 8456 RVA: 0x0024E7C8 File Offset: 0x0024C9C8
		[CompilerGenerated]
		public static void smethod_0(PrivateMethods.Delegate58 delegate58_1)
		{
			PrivateMethods.Delegate58 @delegate = PrivateMethods.delegate58_0;
			PrivateMethods.Delegate58 delegate2;
			do
			{
				delegate2 = @delegate;
				PrivateMethods.Delegate58 value = (PrivateMethods.Delegate58)Delegate.Combine(delegate2, delegate58_1);
				@delegate = Interlocked.CompareExchange<PrivateMethods.Delegate58>(ref PrivateMethods.delegate58_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x0024E7FC File Offset: 0x0024C9FC
		[CompilerGenerated]
		public static void smethod_1(PrivateMethods.Delegate59 delegate59_1)
		{
			PrivateMethods.Delegate59 @delegate = PrivateMethods.delegate59_0;
			PrivateMethods.Delegate59 delegate2;
			do
			{
				delegate2 = @delegate;
				PrivateMethods.Delegate59 value = (PrivateMethods.Delegate59)Delegate.Combine(delegate2, delegate59_1);
				@delegate = Interlocked.CompareExchange<PrivateMethods.Delegate59>(ref PrivateMethods.delegate59_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x0024E830 File Offset: 0x0024CA30
		[CompilerGenerated]
		public static void smethod_2(PrivateMethods.Delegate60 delegate60_1)
		{
			PrivateMethods.Delegate60 @delegate = PrivateMethods.delegate60_0;
			PrivateMethods.Delegate60 delegate2;
			do
			{
				delegate2 = @delegate;
				PrivateMethods.Delegate60 value = (PrivateMethods.Delegate60)Delegate.Combine(delegate2, delegate60_1);
				@delegate = Interlocked.CompareExchange<PrivateMethods.Delegate60>(ref PrivateMethods.delegate60_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x0024E864 File Offset: 0x0024CA64
		[CompilerGenerated]
		public static void smethod_3(PrivateMethods.Delegate61 delegate61_1)
		{
			PrivateMethods.Delegate61 @delegate = PrivateMethods.delegate61_0;
			PrivateMethods.Delegate61 delegate2;
			do
			{
				delegate2 = @delegate;
				PrivateMethods.Delegate61 value = (PrivateMethods.Delegate61)Delegate.Combine(delegate2, delegate61_1);
				@delegate = Interlocked.CompareExchange<PrivateMethods.Delegate61>(ref PrivateMethods.delegate61_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x0024E898 File Offset: 0x0024CA98
		public static string smethod_4(string string_0, string string_1, int int_0, int int_1, string string_2, string string_3, string string_4, Scenario scenario_0)
		{
			PrivateMethods.Class489 @class = new PrivateMethods.Class489();
			@class.string_0 = string_0;
			Side theSide = Enumerable.First<Side>(Enumerable.Select<Side, Side>(Enumerable.Where<Side>(scenario_0.method_44(), new Func<Side, bool>(@class.method_0)), (PrivateMethods._Closure$__.$I20-1 == null) ? (PrivateMethods._Closure$__.$I20-1 = new Func<Side, Side>(PrivateMethods._Closure$__.$I.method_0)) : PrivateMethods._Closure$__.$I20-1));
			double longitude;
			double latitude;
			if (Operators.CompareString(string_2, "DEC", false) != 0)
			{
				if (Operators.CompareString(string_2, "DEG", false) == 0)
				{
					longitude = LuaUtility.smethod_9(string_4);
					latitude = LuaUtility.smethod_8(string_3);
				}
			}
			else
			{
				string_4 = string_4.Replace(",", ".");
				string_3 = string_3.Replace(",", ".");
				longitude = XmlConvert.ToDouble(string_4);
				latitude = XmlConvert.ToDouble(string_3);
			}
			return scenario_0.method_71(theSide, string_1, longitude, latitude, int_0, int_1, 1000f, Unit.Enum122.const_0, null).string_0;
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x0024E980 File Offset: 0x0024CB80
		public static string smethod_5(string string_0, string string_1, int int_0, string string_2, string string_3, string string_4, Scenario scenario_0)
		{
			PrivateMethods.Class490 @class = new PrivateMethods.Class490();
			@class.string_0 = string_0;
			Side theSide = Enumerable.First<Side>(Enumerable.Select<Side, Side>(Enumerable.Where<Side>(scenario_0.method_44(), new Func<Side, bool>(@class.method_0)), (PrivateMethods._Closure$__.$I21-1 == null) ? (PrivateMethods._Closure$__.$I21-1 = new Func<Side, Side>(PrivateMethods._Closure$__.$I.method_1)) : PrivateMethods._Closure$__.$I21-1));
			double longitude;
			double latitude;
			if (Operators.CompareString(string_2, "DEC", false) != 0)
			{
				if (Operators.CompareString(string_2, "DEG", false) == 0)
				{
					longitude = LuaUtility.smethod_9(string_4);
					latitude = LuaUtility.smethod_8(string_3);
				}
			}
			else
			{
				string_4 = string_4.Replace(",", ".");
				string_3 = string_3.Replace(",", ".");
				longitude = XmlConvert.ToDouble(string_4);
				latitude = XmlConvert.ToDouble(string_3);
			}
			return scenario_0.method_73(theSide, int_0, string_1, longitude, latitude, false, Unit.Enum122.const_0, null).string_0;
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x0024EA64 File Offset: 0x0024CC64
		public static string smethod_6(string string_0, string string_1, int int_0, string string_2, string string_3, string string_4, Scenario scenario_0)
		{
			PrivateMethods.Class491 @class = new PrivateMethods.Class491();
			@class.string_0 = string_0;
			Side theSide = Enumerable.First<Side>(Enumerable.Select<Side, Side>(Enumerable.Where<Side>(scenario_0.method_44(), new Func<Side, bool>(@class.method_0)), (PrivateMethods._Closure$__.$I22-1 == null) ? (PrivateMethods._Closure$__.$I22-1 = new Func<Side, Side>(PrivateMethods._Closure$__.$I.method_2)) : PrivateMethods._Closure$__.$I22-1));
			double longitude;
			double latitude;
			if (Operators.CompareString(string_2, "DEC", false) != 0)
			{
				if (Operators.CompareString(string_2, "DEG", false) == 0)
				{
					longitude = LuaUtility.smethod_9(string_4);
					latitude = LuaUtility.smethod_8(string_3);
				}
			}
			else
			{
				string_4 = string_4.Replace(",", ".");
				string_3 = string_3.Replace(",", ".");
				longitude = XmlConvert.ToDouble(string_4);
				latitude = XmlConvert.ToDouble(string_3);
			}
			return scenario_0.method_75(theSide, int_0, string_1, longitude, latitude, false, Unit.Enum122.const_0, null).string_0;
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x0024EB48 File Offset: 0x0024CD48
		public static bool smethod_7(LuaTable luaTable_0, Scenario scenario_0)
		{
			Weapon._WeaponType theWeaponType = Weapon._WeaponType.IronBomb;
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			if (!dictionary.ContainsKey("WARHEADID"))
			{
				throw new Exception3("Missing mandatory variable 'WarheadID'");
			}
			int int_ = Conversions.ToInteger(dictionary["WARHEADID"]);
			Weapon._WeaponType weaponType;
			if (dictionary.ContainsKey("WEAPONTYPE") && (Enum.TryParse<Weapon._WeaponType>(Conversions.ToString(dictionary["WEAPONTYPE"]), true, out weaponType) & Enum.IsDefined(typeof(Weapon._WeaponType), weaponType)))
			{
				theWeaponType = weaponType;
			}
			double? num = LuaUtility.smethod_11(dictionary);
			if (num == null)
			{
				throw new Exception3("Missing 'Latitude'");
			}
			double? num2 = LuaUtility.smethod_13(dictionary);
			if (num2 == null)
			{
				throw new Exception3("Missing 'Longitude'");
			}
			int num5;
			if (dictionary.ContainsKey("ALTITUDE") && Operators.CompareString(dictionary["ALTITUDE"].ToString(), "SURFACE", false) != 0)
			{
				float? num3 = LuaUtility.smethod_20(dictionary);
				if (Information.IsNothing(num3))
				{
					short num4 = Terrain.smethod_7(num.Value, num2.Value, false);
					if (num4 < 0)
					{
						num5 = 0;
					}
					else
					{
						num5 = (int)num4;
					}
				}
				else
				{
					num5 = (int)Math.Round((double)num3.Value);
				}
			}
			else
			{
				short num6 = Terrain.smethod_7(num.Value, num2.Value, false);
				if (num6 < 0)
				{
					num5 = 0;
				}
				else
				{
					num5 = (int)num6;
				}
			}
			Warhead warhead = DBFunctions.smethod_89(scenario_0, int_);
			new Explosion(ref scenario_0, num2.Value, num.Value, num2.Value, num.Value, 0f, (float)num5, theWeaponType, warhead.float_0, warhead.float_0, warhead.warheadType_0, warhead.enum126_0, null, null, null, null, null, warhead.short_1, warhead.short_2, (int)warhead.short_0, 0f, 0);
			return true;
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x0024ED24 File Offset: 0x0024CF24
		public static string smethod_8(string string_0, string string_1, int int_0, int int_1, string string_2, string string_3, string string_4, Scenario scenario_0)
		{
			PrivateMethods.Class492 @class = new PrivateMethods.Class492();
			@class.string_0 = string_0;
			Side theSide = Enumerable.First<Side>(Enumerable.Select<Side, Side>(Enumerable.Where<Side>(scenario_0.method_44(), new Func<Side, bool>(@class.method_0)), (PrivateMethods._Closure$__.$I24-1 == null) ? (PrivateMethods._Closure$__.$I24-1 = new Func<Side, Side>(PrivateMethods._Closure$__.$I.method_3)) : PrivateMethods._Closure$__.$I24-1));
			double longitude;
			double latitude;
			if (Operators.CompareString(string_2, "DEC", false) != 0)
			{
				if (Operators.CompareString(string_2, "DEG", false) == 0)
				{
					longitude = LuaUtility.smethod_9(string_4);
					latitude = LuaUtility.smethod_8(string_3);
				}
			}
			else
			{
				string_4 = string_4.Replace(",", ".");
				string_3 = string_3.Replace(",", ".");
				longitude = XmlConvert.ToDouble(string_4);
				latitude = XmlConvert.ToDouble(string_3);
			}
			Facility facility = scenario_0.method_76(theSide, int_0, string_1, longitude, latitude, false, Unit.Enum122.const_0, null);
			facility.vmethod_10((float)int_1);
			return facility.string_0;
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x0024EE10 File Offset: 0x0024D010
		public static bool smethod_9(LuaTable luaTable_0, Scenario scenario_0, ActiveUnit activeUnit_0)
		{
			try
			{
				Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
				ActiveUnit activeUnit = null;
				ActiveUnit activeUnit2 = null;
				ActiveUnit activeUnit3 = null;
				if (!dictionary.ContainsKey("HostedUnitNameOrID".ToUpper()))
				{
					throw new Exception3("HostedUnitNameOrID has not been defined!");
				}
				string text = Conversions.ToString(dictionary["HostedUnitNameOrID".ToUpper()]);
				if (Operators.CompareString(text, "UnitX", false) == 0)
				{
					if (activeUnit_0 == null)
					{
						throw new Exception3("Unit:UnitX has not been defined!");
					}
					activeUnit = activeUnit_0;
				}
				else
				{
					scenario_0.vmethod_0().TryGetValue(text, ref activeUnit);
					if (activeUnit == null)
					{
						try
						{
							foreach (ActiveUnit activeUnit4 in scenario_0.vmethod_0().Values)
							{
								if (activeUnit4 != null && Operators.CompareString(activeUnit4.Name.ToUpper(), text.ToUpper(), false) == 0)
								{
									activeUnit = activeUnit4;
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
					}
				}
				if (!dictionary.ContainsKey("SelectedHostNameOrID".ToUpper()))
				{
					throw new Exception3("SelectedHostNameOrID has not been defined!");
				}
				string text2 = Conversions.ToString(dictionary["SelectedHostNameOrID".ToUpper()]);
				if (Operators.CompareString(text2, "UnitX", false) == 0)
				{
					if (Information.IsNothing(activeUnit_0))
					{
						throw new Exception3("Host:UnitX has not been defined!");
					}
					activeUnit2 = activeUnit_0;
				}
				else
				{
					try
					{
						foreach (ActiveUnit activeUnit5 in scenario_0.method_42())
						{
							if (!Information.IsNothing(activeUnit5) && (Operators.CompareString(activeUnit5.Name.ToUpper(), text2.ToUpper(), false) == 0 || Operators.CompareString(activeUnit5.string_0.ToLower(), text2.ToLower(), false) == 0))
							{
								activeUnit2 = activeUnit5;
								break;
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				if (dictionary.ContainsKey("SelectedBaseNameOrID".ToUpper()))
				{
					string text3 = Conversions.ToString(dictionary["SelectedBaseNameOrID".ToUpper()]);
					if (Operators.CompareString(text3, "UnitX", false) == 0)
					{
						if (Information.IsNothing(activeUnit_0))
						{
							throw new Exception3("Base:UnitX has not been defined!");
						}
						activeUnit3 = activeUnit_0;
					}
					else
					{
						activeUnit3 = PrivateMethods.smethod_67(text3, scenario_0);
					}
				}
				if (Information.IsNothing(activeUnit))
				{
					throw new Exception3("Couldn't find the hosted unit " + text);
				}
				if (Information.IsNothing(activeUnit2) && !Information.IsNothing(activeUnit3))
				{
					throw new Exception3("Couldn't find the selected host unit " + text2);
				}
				if (Information.IsNothing(activeUnit2) && Information.IsNothing(activeUnit3))
				{
					throw new Exception3("Couldn't find any host unit " + text2);
				}
				if (activeUnit.bool_3)
				{
					if (!Information.IsNothing(activeUnit2))
					{
						if (activeUnit2.vmethod_92() != null)
						{
							if (activeUnit2.vmethod_92().vmethod_8((Aircraft)activeUnit))
							{
								((Aircraft)activeUnit).method_164().method_35(null);
								activeUnit2.vmethod_92().method_18((Aircraft)activeUnit, false);
								activeUnit.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
								return true;
							}
							return false;
						}
					}
					else if (!Information.IsNothing(activeUnit3) && activeUnit.vmethod_92() != null)
					{
						Aircraft_AirOps aircraft_AirOps = (Aircraft_AirOps)activeUnit.vmethod_92();
						if (Operators.CompareString(aircraft_AirOps.method_26(activeUnit3), "OK", false) == 0)
						{
							aircraft_AirOps.method_33(false, activeUnit3);
							return true;
						}
						return false;
					}
				}
				else if (!Information.IsNothing(activeUnit2))
				{
					if (activeUnit2.vmethod_93() != null)
					{
						ActiveUnit_DockingOps activeUnit_DockingOps = activeUnit2.vmethod_93();
						ActiveUnit theBoat = activeUnit;
						DockFacility dockFacility = null;
						if (activeUnit_DockingOps.method_40(theBoat, ref dockFacility))
						{
							activeUnit.vmethod_93().method_16(null);
							activeUnit2.vmethod_93().method_42(activeUnit);
							activeUnit.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
							return true;
						}
						return false;
					}
				}
				else if (!Information.IsNothing(activeUnit3) && activeUnit.vmethod_93() != null)
				{
					ActiveUnit_DockingOps activeUnit_DockingOps2 = activeUnit.vmethod_93();
					if (Operators.CompareString(activeUnit_DockingOps2.method_45(activeUnit3), "OK", false) == 0)
					{
						activeUnit_DockingOps2.method_12(false, activeUnit3);
						return true;
					}
					return false;
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
			return false;
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x000106F8 File Offset: 0x0000E8F8
		public static string smethod_10(Scenario scenario_0)
		{
			return Misc.smethod_45(GameGeneral.smethod_11(scenario_0));
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x0024F238 File Offset: 0x0024D438
		public static bool smethod_11(ref Scenario scenario_0, LuaTable luaTable_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			if (dictionary.ContainsKey("XML".ToUpper()))
			{
				string text = Conversions.ToString(dictionary["XML".ToUpper()]);
				try
				{
					string theXMLText = text;
					string text2 = null;
					double num = 0.0;
					Scenario scenario = Scenario.smethod_19(theXMLText, ref text2, ref num, false, true);
					scenario_0 = scenario;
					Scenario.smethod_24(scenario);
					return true;
				}
				catch (Exception ex)
				{
					throw new Exception3("Error during XML parse: " + ex.Message);
				}
			}
			throw new Exception3("XML string not present!");
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x0024F2DC File Offset: 0x0024D4DC
		public static bool smethod_12(string string_0, string string_1, Scenario scenario_0, ActiveUnit activeUnit_0, bool bool_0, bool bool_1)
		{
			bool result;
			try
			{
				ActiveUnit activeUnit = null;
				Mission mission = null;
				Side side = null;
				bool flag = bool_0;
				if (Operators.CompareString(string_0, "UnitX", false) == 0)
				{
					if (activeUnit_0 == null)
					{
						throw new Exception3("UnitX has not been defined!");
					}
					activeUnit = activeUnit_0;
					side = activeUnit_0.vmethod_7(false);
				}
				else
				{
					scenario_0.vmethod_0().TryGetValue(string_0, ref activeUnit);
					if (activeUnit == null)
					{
						try
						{
							foreach (ActiveUnit activeUnit2 in scenario_0.vmethod_0().Values)
							{
								if (activeUnit2 != null && Operators.CompareString(activeUnit2.Name.ToUpper(), string_0.ToUpper(), false) == 0)
								{
									activeUnit = activeUnit2;
									side = activeUnit.vmethod_7(false);
									IL_9E:
									goto IL_B4;
								}
							}
							goto IL_9E;
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
					side = activeUnit.vmethod_7(false);
				}
				IL_B4:
				if (side == null)
				{
					throw new Exception3("UnitX was not found in the scenario unit list!");
				}
				try
				{
					foreach (Mission mission2 in side.method_35())
					{
						if (Operators.CompareString(mission2.Name.ToUpper(), string_1.ToUpper(), false) == 0 || Operators.CompareString(mission2.string_0.ToLower(), string_1.ToLower(), false) == 0)
						{
							mission = mission2;
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
				if (activeUnit == null)
				{
					throw new Exception3("Couldn't find the unit " + string_0);
				}
				if (!string.IsNullOrEmpty(string_1) && Operators.CompareString(string_1.ToUpper(), "NONE", false) != 0)
				{
					if (mission == null)
					{
						throw new Exception3("Couldn't find the mission " + string_1);
					}
					if (flag & activeUnit.bool_1)
					{
						ActiveUnit.smethod_8(ref activeUnit.scenario_0, ref activeUnit, ref mission, ref flag);
						try
						{
							foreach (ActiveUnit activeUnit3 in ((Group)activeUnit).vmethod_141().Values)
							{
								ActiveUnit.smethod_8(ref activeUnit.scenario_0, ref activeUnit3, ref mission, ref flag);
							}
							goto IL_1EE;
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
					ActiveUnit.smethod_8(ref activeUnit.scenario_0, ref activeUnit, ref mission, ref flag);
					IL_1EE:
					if (bool_1 && activeUnit.bool_3 && activeUnit.vmethod_127())
					{
						List<ActiveUnit> list = new List<ActiveUnit>();
						list.Add(activeUnit);
						Class514.smethod_0(activeUnit.scenario_0, mission, ref list, false);
					}
					mission.int_0 = 0;
					result = true;
				}
				else
				{
					ActiveUnit activeUnit4 = activeUnit;
					Mission value = null;
					bool setMissionOnly = false;
					Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
					activeUnit4.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
					result = true;
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

		// Token: 0x06002115 RID: 8469 RVA: 0x0024F5A4 File Offset: 0x0024D7A4
		public static bool smethod_13(LuaTable luaTable_0, Scenario scenario_0, ActiveUnit activeUnit_0)
		{
			bool result;
			try
			{
				Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
				Aircraft aircraft = null;
				LuaUtility.smethod_5(ref dictionary);
				if (!dictionary.ContainsKey("UnitName".ToUpper()))
				{
					throw new Exception3("UnitName has not been defined!");
				}
				string text = Conversions.ToString(dictionary["UnitName".ToUpper()]);
				if (Operators.CompareString(text, "UnitX", false) == 0)
				{
					if (Information.IsNothing(activeUnit_0))
					{
						throw new Exception3("UnitX has not been defined!");
					}
					if (!activeUnit_0.bool_3)
					{
						throw new Exception3("UnitX is not an aircraft!");
					}
					aircraft = (Aircraft)activeUnit_0;
				}
				else
				{
					if (scenario_0.vmethod_0().ContainsKey(text))
					{
						aircraft = (Aircraft)scenario_0.vmethod_0()[text];
					}
					if (aircraft == null)
					{
						try
						{
							foreach (ActiveUnit activeUnit in scenario_0.vmethod_0().Values)
							{
								if (activeUnit != null && Operators.CompareString(activeUnit.Name.ToUpper(), text.ToUpper(), false) == 0)
								{
									aircraft = (Aircraft)activeUnit;
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
					}
				}
				if (aircraft == null)
				{
					throw new Exception3("Aircraft has not been found!");
				}
				if (!(aircraft.method_174() | aircraft.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Readying))
				{
					throw new Exception3("Aircraft is not parked, cannot change loadout!");
				}
				if (!dictionary.ContainsKey("LOADOUTID"))
				{
					throw new Exception3("LoadoutID has not been defined!");
				}
				int num = Conversions.ToInteger(dictionary["LOADOUTID"]);
				if (num == 0)
				{
					num = aircraft.method_167().DBID;
				}
				Loadout loadout;
				try
				{
					loadout = DBFunctions.smethod_47(ref scenario_0, num, true, true);
				}
				catch (Exception ex)
				{
					throw new Exception3(ex.Message);
				}
				int num2 = loadout.int_2;
				if (dictionary.ContainsKey("TIMETOREADY_MINUTES"))
				{
					num2 = Conversions.ToInteger(dictionary["TIMETOREADY_MINUTES"]);
				}
				bool flag = false;
				if (dictionary.ContainsKey("IGNOREMAGAZINES"))
				{
					try
					{
						flag = Conversions.ToBoolean(dictionary["IGNOREMAGAZINES"]);
					}
					catch (Exception ex2)
					{
						throw new Exception3("Unable to parse IgnoreMagazines to true/false!");
					}
				}
				bool bool_ = false;
				if (dictionary.ContainsKey("EXCLUDEOPTIONALWEAPONS"))
				{
					try
					{
						bool_ = Conversions.ToBoolean(dictionary["EXCLUDEOPTIONALWEAPONS"]);
					}
					catch (Exception ex3)
					{
						throw new Exception3("Unable to parse ExcludeOptionalWeapons to true/false!");
					}
				}
				if (scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2))
				{
					flag = true;
				}
				if (!flag)
				{
					aircraft.method_164().method_67();
				}
				ActiveUnit activeUnit2 = aircraft.method_164().method_30();
				activeUnit2.vmethod_92().method_16(ref aircraft, num, 0, false, bool_, !flag, false, true);
				aircraft.method_164().method_39((float)(num2 * 60));
				activeUnit2.vmethod_92().method_14(ref aircraft);
				activeUnit2.vmethod_92().method_13(ref aircraft);
				if (num == 4 && !aircraft.method_174())
				{
					aircraft.method_164().method_37(Aircraft_AirOps._AirOpsCondition.Parked);
				}
				result = true;
			}
			catch (Exception ex4)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x0024F904 File Offset: 0x0024DB04
		public static LuaWrapper_Device_Loadout smethod_14(LuaTable luaTable_0, Scenario scenario_0, ActiveUnit activeUnit_0)
		{
			try
			{
				Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
				Aircraft aircraft = null;
				LuaUtility.smethod_5(ref dictionary);
				if (dictionary.ContainsKey("UnitName".ToUpper()))
				{
					string text = Conversions.ToString(dictionary["UnitName".ToUpper()]);
					if (Operators.CompareString(text, "UnitX", false) == 0)
					{
						if (Information.IsNothing(activeUnit_0))
						{
							throw new Exception3("UnitX has not been defined!");
						}
						if (!activeUnit_0.bool_3)
						{
							throw new Exception3("UnitX is not an aircraft!");
						}
						aircraft = (Aircraft)activeUnit_0;
					}
					else
					{
						try
						{
							foreach (ActiveUnit activeUnit in scenario_0.method_42())
							{
								if (!Information.IsNothing(activeUnit) && activeUnit.GetType() == typeof(Aircraft) && (Operators.CompareString(activeUnit.Name.ToUpper(), text.ToUpper(), false) == 0 || Operators.CompareString(activeUnit.string_0.ToLower(), text.ToLower(), false) == 0))
								{
									aircraft = (Aircraft)activeUnit;
									break;
								}
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					if (Information.IsNothing(aircraft))
					{
						throw new Exception3("Aircraft has not been found!");
					}
					int num = 0;
					if (dictionary.ContainsKey("LOADOUTID"))
					{
						num = Conversions.ToInteger(dictionary["LOADOUTID"]);
					}
					Loadout a;
					try
					{
						if (num == 0)
						{
							a = aircraft.method_167();
						}
						else
						{
							a = DBFunctions.smethod_47(ref scenario_0, num, true, true);
						}
						goto IL_17F;
					}
					catch (Exception ex)
					{
						throw new Exception3(ex.Message);
					}
					goto IL_174;
					IL_17F:
					return new LuaWrapper_Device_Loadout(a, scenario_0);
				}
				IL_174:
				throw new Exception3("UnitName has not been defined!");
			}
			catch (Exception ex2)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			LuaWrapper_Device_Loadout result;
			return result;
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x0024FB00 File Offset: 0x0024DD00
		public static bool smethod_15(int int_0, int int_1, float float_0, int int_2, Scenario scenario_0)
		{
			bool result;
			try
			{
				if (int_1 < 0 || int_1 > 50)
				{
					throw new Exception3("Invalid rainfall (0 - 50)");
				}
				if (float_0 < 0f || float_0 > 1f)
				{
					throw new Exception3("Invalid fraction of cloudcover (0.0 - 1.0)");
				}
				if (int_2 < 0 || int_2 > 9)
				{
					throw new Exception3("Invalid SeaState (0 - 9)");
				}
				scenario_0.method_23().method_7((double)int_0);
				scenario_0.method_23().float_0 = (float)int_1;
				scenario_0.method_23().method_4(float_0);
				scenario_0.method_23().int_0 = int_2;
				result = true;
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

		// Token: 0x06002118 RID: 8472 RVA: 0x0024FBB0 File Offset: 0x0024DDB0
		public static LuaTable smethod_16(Scenario scenario_0)
		{
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			LuaTable result;
			try
			{
				luaTable["temp"] = scenario_0.method_23().method_6();
				luaTable["rainfall"] = scenario_0.method_23().float_0;
				luaTable["undercloud"] = scenario_0.method_23().method_3();
				luaTable["seastate"] = scenario_0.method_23().int_0;
				result = luaTable;
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

		// Token: 0x06002119 RID: 8473 RVA: 0x0024FC60 File Offset: 0x0024DE60
		public static bool smethod_17(string string_0, string string_1, string string_2, Scenario scenario_0)
		{
			bool result;
			try
			{
				Side side = null;
				Side side2 = null;
				foreach (Side side3 in scenario_0.method_44())
				{
					if (Operators.CompareString(side3.method_51().ToUpper(), string_0.ToUpper(), false) == 0 || Operators.CompareString(side3.string_0.ToLower(), string_0.ToLower(), false) == 0)
					{
						side = side3;
					}
					if (Operators.CompareString(side3.method_51().ToUpper(), string_1.ToUpper(), false) == 0 || Operators.CompareString(side3.string_0.ToLower(), string_1.ToLower(), false) == 0)
					{
						side2 = side3;
					}
				}
				if (Information.IsNothing(side))
				{
					throw new Exception3("Unable to identify Side-A!");
				}
				if (Information.IsNothing(side2))
				{
					throw new Exception3("Unable to identify Side-B!");
				}
				Misc.PostureStance postureStance_;
				if (Operators.CompareString(string_2, "F", false) != 0)
				{
					if (Operators.CompareString(string_2, "H", false) != 0)
					{
						if (Operators.CompareString(string_2, "N", false) != 0)
						{
							if (Operators.CompareString(string_2, "U", false) != 0)
							{
								throw new Exception3("Invalid posture code! (Valid codes: F, H, N, U)");
							}
							postureStance_ = Misc.PostureStance.Unfriendly;
						}
						else
						{
							postureStance_ = Misc.PostureStance.Neutral;
						}
					}
					else
					{
						postureStance_ = Misc.PostureStance.Hostile;
					}
				}
				else
				{
					postureStance_ = Misc.PostureStance.Friendly;
				}
				side.method_69(side2, postureStance_);
				result = true;
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

		// Token: 0x0600211A RID: 8474 RVA: 0x0024FDBC File Offset: 0x0024DFBC
		public static LuaTable smethod_18(LuaTable luaTable_0, Scenario scenario_0)
		{
			LuaTable result;
			try
			{
				Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
				Side side = null;
				if (dictionary.ContainsKey("SIDE"))
				{
					string str = null;
					try
					{
						str = Conversions.ToString(dictionary["SIDE"]);
					}
					catch (Exception ex)
					{
						throw new Exception3("side must be a string");
					}
					try
					{
						side = LuaUtility.smethod_16(dictionary, scenario_0);
					}
					catch (Exception ex2)
					{
						throw new Exception3("Can't find Side '" + str + "'");
					}
				}
				if (dictionary.ContainsKey("AWARENESS"))
				{
					string text = Conversions.ToString(dictionary["AWARENESS"]).ToUpper();
					uint num = Class582.smethod_0(text);
					if (num <= 923577301U)
					{
						if (num <= 873244444U)
						{
							if (num != 348981803U)
							{
								if (num != 873244444U)
								{
									goto IL_1EE;
								}
								if (Operators.CompareString(text, "1", false) != 0)
								{
									goto IL_1EE;
								}
								goto IL_1F9;
							}
							else
							{
								if (Operators.CompareString(text, "-1", false) != 0)
								{
									goto IL_1EE;
								}
								goto IL_1C6;
							}
						}
						else if (num != 890022063U)
						{
							if (num != 906799682U)
							{
								if (num != 923577301U)
								{
									goto IL_1EE;
								}
								if (Operators.CompareString(text, "2", false) != 0)
								{
									goto IL_1EE;
								}
							}
							else
							{
								if (Operators.CompareString(text, "3", false) != 0)
								{
									goto IL_1EE;
								}
								goto IL_1DA;
							}
						}
						else
						{
							if (Operators.CompareString(text, "0", false) != 0)
							{
								goto IL_1EE;
							}
							goto IL_195;
						}
					}
					else if (num <= 1195330816U)
					{
						if (num != 1009949074U)
						{
							if (num != 1195330816U)
							{
								goto IL_1EE;
							}
							if (Operators.CompareString(text, "AUTOUNIT", false) != 0)
							{
								goto IL_1EE;
							}
						}
						else
						{
							if (Operators.CompareString(text, "NORMAL", false) == 0)
							{
								goto IL_195;
							}
							goto IL_1EE;
						}
					}
					else if (num != 1214123317U)
					{
						if (num != 3535787620U)
						{
							if (num != 3794288532U)
							{
								goto IL_1EE;
							}
							if (Operators.CompareString(text, "BLIND", false) == 0)
							{
								goto IL_1C6;
							}
							goto IL_1EE;
						}
						else
						{
							if (Operators.CompareString(text, "OMNI", false) == 0)
							{
								goto IL_1DA;
							}
							goto IL_1EE;
						}
					}
					else
					{
						if (Operators.CompareString(text, "AUTOSIDE", false) != 0)
						{
							goto IL_1EE;
						}
						goto IL_1F9;
					}
					Side.AwarenessLevel_Enum awarenessLevel_Enum_ = Side.AwarenessLevel_Enum.AutoSideAndUnitID;
					goto IL_1FC;
					IL_195:
					awarenessLevel_Enum_ = Side.AwarenessLevel_Enum.Normal;
					goto IL_1FC;
					IL_1C6:
					awarenessLevel_Enum_ = Side.AwarenessLevel_Enum.Blind;
					goto IL_1FC;
					IL_1DA:
					awarenessLevel_Enum_ = Side.AwarenessLevel_Enum.Omniscient;
					goto IL_1FC;
					IL_1EE:
					throw new Exception3("Invalid awareness code! (Valid codes: -1 ... 3)");
					IL_1F9:
					awarenessLevel_Enum_ = Side.AwarenessLevel_Enum.AutoSideID;
					IL_1FC:
					side.method_29(awarenessLevel_Enum_);
				}
				if (dictionary.ContainsKey("PROFICIENCY"))
				{
					string text2 = Conversions.ToString(dictionary["PROFICIENCY"]).ToUpper();
					uint num = Class582.smethod_0(text2);
					GlobalVariables.ProficiencyLevel proficiencyLevel_;
					if (num <= 890022063U)
					{
						if (num <= 615451163U)
						{
							if (num != 591782726U)
							{
								if (num != 615451163U)
								{
									goto IL_383;
								}
								if (Operators.CompareString(text2, "NOVICE", false) != 0)
								{
									goto IL_383;
								}
							}
							else
							{
								if (Operators.CompareString(text2, "CADET", false) != 0)
								{
									goto IL_383;
								}
								goto IL_2D4;
							}
						}
						else if (num != 822911587U)
						{
							if (num != 873244444U)
							{
								if (num != 890022063U)
								{
									goto IL_383;
								}
								if (Operators.CompareString(text2, "0", false) != 0)
								{
									goto IL_383;
								}
							}
							else
							{
								if (Operators.CompareString(text2, "1", false) == 0)
								{
									goto IL_2D4;
								}
								goto IL_383;
							}
						}
						else
						{
							if (Operators.CompareString(text2, "4", false) != 0)
							{
								goto IL_383;
							}
							goto IL_35B;
						}
						proficiencyLevel_ = GlobalVariables.ProficiencyLevel.Novice;
						goto IL_391;
						IL_2D4:
						proficiencyLevel_ = GlobalVariables.ProficiencyLevel.Cadet;
						goto IL_391;
					}
					if (num <= 923577301U)
					{
						if (num != 906799682U)
						{
							if (num != 923577301U)
							{
								goto IL_383;
							}
							if (Operators.CompareString(text2, "2", false) != 0)
							{
								goto IL_383;
							}
							goto IL_38E;
						}
						else if (Operators.CompareString(text2, "3", false) != 0)
						{
							goto IL_383;
						}
					}
					else if (num != 1139941943U)
					{
						if (num != 2090721268U)
						{
							if (num != 2122752904U)
							{
								goto IL_383;
							}
							if (Operators.CompareString(text2, "ACE", false) == 0)
							{
								goto IL_35B;
							}
							goto IL_383;
						}
						else if (Operators.CompareString(text2, "VETERAN", false) != 0)
						{
							goto IL_383;
						}
					}
					else
					{
						if (Operators.CompareString(text2, "REGULAR", false) != 0)
						{
							goto IL_383;
						}
						goto IL_38E;
					}
					proficiencyLevel_ = GlobalVariables.ProficiencyLevel.Veteran;
					goto IL_391;
					IL_38E:
					proficiencyLevel_ = GlobalVariables.ProficiencyLevel.Regular;
					goto IL_391;
					IL_35B:
					proficiencyLevel_ = GlobalVariables.ProficiencyLevel.Ace;
					goto IL_391;
					IL_383:
					throw new Exception3("Invalid proficiency code! (Valid codes: 0 ... 4)");
					IL_391:
					side.method_25(proficiencyLevel_);
				}
				if (dictionary.ContainsKey("SWITCHTO"))
				{
					bool? flag = LuaUtility.smethod_10(dictionary["SWITCHTO"].ToString());
					if (flag != null)
					{
						bool? flag2 = flag;
						if (((flag2 != null) ? new bool?(flag2.GetValueOrDefault()) : null).GetValueOrDefault())
						{
							scenario_0.method_53(side);
						}
					}
				}
				LuaUtility.smethod_3(dictionary, luaTable_0);
				result = PrivateMethods.smethod_28(luaTable_0, scenario_0);
			}
			catch (Exception ex3)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x0025023C File Offset: 0x0024E43C
		public static LuaTable smethod_19(LuaTable luaTable_0, Scenario scenario_0)
		{
			LuaTable result;
			try
			{
				Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
				ActiveUnit activeUnit = null;
				LuaSandBox.Singleton().CreateTable();
				LuaUtility.smethod_5(ref dictionary);
				string text = LuaUtility.smethod_28(dictionary, scenario_0);
				if (text.Length != 0)
				{
					throw new Exception3(text);
				}
				if (dictionary.ContainsKey("GUID"))
				{
					string key;
					try
					{
						key = Conversions.ToString(dictionary["GUID"]);
					}
					catch (Exception ex)
					{
						throw new Exception3("guid must be a string");
					}
					try
					{
						activeUnit = scenario_0.vmethod_0()[key];
					}
					catch (Exception ex2)
					{
					}
				}
				if (activeUnit == null)
				{
					throw new Exception3("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
				}
				if (!dictionary.ContainsKey("LOADOUTID"))
				{
					throw new Exception3("Must provide a valid loadout ID");
				}
				int num = Conversions.ToInteger(dictionary["LOADOUTID"]);
				Loadout loadout;
				try
				{
					loadout = DBFunctions.smethod_47(ref scenario_0, num, false, true);
				}
				catch (Exception ex3)
				{
					throw new Exception3("Must provide a valid loadout ID");
				}
				if (!dictionary.ContainsKey("QUANTITY") || Conversions.ToInteger(dictionary["QUANTITY"]) <= 0)
				{
					throw new Exception3("Must provide a valid (>0) quantity number");
				}
				int num2 = Conversions.ToInteger(dictionary["QUANTITY"]);
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				luaTable[1] = string.Concat(new string[]
				{
					"Attempting to add ",
					Conversions.ToString(num2),
					"x packs of loadout: #",
					Conversions.ToString(num),
					" - ",
					loadout.Name,
					" to the magazines of unit: ",
					activeUnit.Name
				});
				int num3 = 1;
				foreach (WeaponRec weaponRec in loadout.weaponRec_0)
				{
					weaponRec.int_2 *= num2;
					weaponRec.method_10(weaponRec.method_9() * num2);
					int num4 = 0;
					int num5 = 0;
					if (weaponRec.method_9() > 0)
					{
						int num6 = weaponRec.method_9();
						for (int j = 1; j <= num6; j++)
						{
							if (Operators.CompareString(activeUnit.vmethod_89().vmethod_11(weaponRec.int_5, true, true), "OK", false) == 0)
							{
								num4++;
							}
							else
							{
								num5++;
							}
						}
						if (num4 > 0)
						{
							num3++;
							luaTable[num3] = "Successfully added " + Conversions.ToString(num4) + "x stores of type: " + weaponRec.method_12(scenario_0).Name;
						}
						if (num5 > 0)
						{
							num3++;
							luaTable[num3] = "Failed to add " + Conversions.ToString(num5) + "x stores of type: " + weaponRec.method_12(scenario_0).Name;
						}
					}
				}
				result = luaTable;
			}
			catch (Exception ex4)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x00250584 File Offset: 0x0024E784
		public static LuaTable smethod_20(LuaTable luaTable_0, Scenario scenario_0)
		{
			try
			{
				Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
				ActiveUnit activeUnit = null;
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				LuaUtility.smethod_5(ref dictionary);
				string text = LuaUtility.smethod_28(dictionary, scenario_0);
				if (text.Length == 0)
				{
					if (dictionary.ContainsKey("GUID"))
					{
						string key;
						try
						{
							key = Conversions.ToString(dictionary["GUID"]);
						}
						catch (Exception ex)
						{
							throw new Exception3("guid must be a string");
						}
						activeUnit = scenario_0.vmethod_0()[key];
					}
					if (activeUnit == null)
					{
						return null;
					}
					ActiveUnit_Damage activeUnit_Damage = activeUnit.vmethod_91();
					int num = 0;
					if (dictionary.ContainsKey("FIRES"))
					{
						try
						{
							object objectValue = RuntimeHelpers.GetObjectValue(dictionary["FIRES"]);
							activeUnit_Damage.vmethod_4((ActiveUnit_Damage.FireIntensityLevel)Conversions.ToByte(objectValue));
						}
						catch (Exception ex2)
						{
						}
					}
					if (dictionary.ContainsKey("FLOOD"))
					{
						try
						{
							object objectValue2 = RuntimeHelpers.GetObjectValue(dictionary["FLOOD"]);
							activeUnit_Damage.vmethod_2((ActiveUnit_Damage.FloodingIntensityLevel)Conversions.ToByte(objectValue2));
						}
						catch (Exception ex3)
						{
						}
					}
					if (dictionary.ContainsKey("DP"))
					{
						try
						{
							num = Conversions.ToInteger(dictionary["DP"]);
						}
						catch (Exception ex4)
						{
						}
						ActiveUnit activeUnit2;
						(activeUnit2 = activeUnit).vmethod_64(false, null, activeUnit2.vmethod_63(false, null) - (float)num);
					}
					if (dictionary.ContainsKey("COMPONENTS"))
					{
						List<object> list = LuaUtility.smethod_0(((LuaTable)dictionary["COMPONENTS"]).GetEnumerator());
						try
						{
							foreach (object obj in list)
							{
								object objectValue3 = RuntimeHelpers.GetObjectValue(obj);
								if (!(objectValue3 is LuaTable))
								{
									throw new Exception3("Error at " + LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(objectValue3)) + " in ScenEdit_SetUnitDamage.");
								}
								Dictionary<string, object> dictionary2 = LuaUtility.smethod_1(((LuaTable)objectValue3).GetEnumerator());
								if (dictionary2.Count > 0)
								{
									PlatformComponent platformComponent = null;
									bool flag = false;
									string text2 = Conversions.ToString(dictionary2["1"]);
									PlatformComponent._DamageSeverityFactor damageSeverityFactor = PlatformComponent._DamageSeverityFactor.Light;
									if (Operators.CompareString(Conversions.ToString(dictionary2["2"]).ToLower(), "none", false) == 0)
									{
										flag = true;
									}
									else
									{
										if (!(Enum.TryParse<PlatformComponent._DamageSeverityFactor>(Conversions.ToString(dictionary2["2"]), true, out damageSeverityFactor) & Enum.IsDefined(typeof(PlatformComponent._DamageSeverityFactor), damageSeverityFactor)))
										{
											throw new Exception3("Error in damage level for  '" + text2 + "' in ScenEdit_SetUnitDamage.");
										}
										if (damageSeverityFactor > PlatformComponent._DamageSeverityFactor.Heavy)
										{
											damageSeverityFactor = PlatformComponent._DamageSeverityFactor.Heavy;
										}
										else if (damageSeverityFactor < PlatformComponent._DamageSeverityFactor.Light)
										{
											damageSeverityFactor = PlatformComponent._DamageSeverityFactor.Light;
										}
									}
									int count = activeUnit.vmethod_120().Count;
									int num2 = GameGeneral.smethod_5().Next(0, count);
									if (Operators.CompareString(text2.ToUpper(), "TYPE", false) == 0)
									{
										if (dictionary2.ContainsKey("TYPE"))
										{
											string text3 = Conversions.ToString(dictionary2["TYPE"]);
											if (count > 0)
											{
												PlatformComponent[] array = new PlatformComponent[count + 1];
												int num3 = 0;
												try
												{
													IEnumerator<PlatformComponent> enumerator2 = activeUnit.vmethod_120().GetEnumerator();
													while (enumerator2.MoveNext())
													{
														platformComponent = enumerator2.Current;
														if (Operators.CompareString(platformComponent.GetType().Name.ToUpper(), text3.ToUpper(), false) == 0)
														{
															array[num3] = platformComponent;
															num3++;
														}
													}
												}
												finally
												{
													IEnumerator<PlatformComponent> enumerator2;
													if (enumerator2 != null)
													{
														enumerator2.Dispose();
													}
												}
												if (num3 > 0)
												{
													num2 = GameGeneral.smethod_5().Next(0, num3);
													PlatformComponent._DamageSeverityFactor damageSeverityFactor2 = array[num2].method_16();
													array[num2].vmethod_8(damageSeverityFactor);
													if (damageSeverityFactor == PlatformComponent._DamageSeverityFactor.Light & (flag | damageSeverityFactor2 > PlatformComponent._DamageSeverityFactor.Light))
													{
														array[num2].vmethod_7();
													}
													LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
													luaTable2["guid"] = array[num2].string_0;
													luaTable2["dbid"] = array[num2].DBID;
													luaTable2["name"] = array[num2].Name;
													luaTable2["type"] = array[num2].GetType().Name;
													luaTable2["status"] = array[num2].vmethod_5().ToString();
													if (platformComponent.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
													{
														luaTable2["damage"] = array[num2].method_16().ToString();
													}
													luaTable[luaTable.Keys.Count + 1] = luaTable2;
												}
											}
										}
										else
										{
											PlatformComponent._DamageSeverityFactor damageSeverityFactor3 = activeUnit.vmethod_120()[num2].method_16();
											activeUnit.vmethod_120()[num2].vmethod_8(damageSeverityFactor);
											if (damageSeverityFactor == PlatformComponent._DamageSeverityFactor.Light & (flag | damageSeverityFactor3 > PlatformComponent._DamageSeverityFactor.Light))
											{
												activeUnit.vmethod_120()[num2].vmethod_7();
											}
										}
									}
									else
									{
										LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
										bool flag2 = false;
										string left = activeUnit.GetType().ToString();
										if (Operators.CompareString(left, "Command_Core.Ship", false) != 0)
										{
											if (Operators.CompareString(left, "Command_Core.Submarine", false) != 0)
											{
												if (Operators.CompareString(left, "Command_Core.Facility", false) == 0 && Operators.CompareString(text2.ToUpper(), "RUDDER", false) != 0)
												{
													if (Operators.CompareString(text2.ToUpper(), "CARGO", false) == 0)
													{
														((Facility)activeUnit).cargo_1.vmethod_8(damageSeverityFactor);
														luaTable3["name"] = text2.ToUpper();
														luaTable3["status"] = ((Facility)activeUnit).cargo_1.vmethod_5().ToString();
														if (((Facility)activeUnit).cargo_1.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
														{
															luaTable3["damage"] = ((Facility)activeUnit).cargo_1.method_16().ToString();
														}
														luaTable[luaTable.Keys.Count + 1] = luaTable3;
														flag2 = true;
													}
													else if (Operators.CompareString(text2.ToUpper(), "PRESSUREHULL", false) != 0 && Operators.CompareString(text2.ToUpper(), "CIC", false) == 0)
													{
														((Facility)activeUnit).class345_0.vmethod_8(damageSeverityFactor);
														luaTable3["name"] = text2.ToUpper();
														luaTable3["status"] = ((Facility)activeUnit).class345_0.vmethod_5().ToString();
														if (((Facility)activeUnit).class345_0.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
														{
															luaTable3["damage"] = ((Facility)activeUnit).class345_0.method_16().ToString();
														}
														luaTable[luaTable.Keys.Count + 1] = luaTable3;
														flag2 = true;
													}
												}
											}
											else if (Operators.CompareString(text2.ToUpper(), "RUDDER", false) == 0)
											{
												((Submarine)activeUnit).class347_0.vmethod_8(damageSeverityFactor);
												luaTable3["name"] = text2.ToUpper();
												luaTable3["status"] = ((Submarine)activeUnit).class347_0.vmethod_5().ToString();
												if (((Submarine)activeUnit).class347_0.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
												{
													luaTable3["damage"] = ((Submarine)activeUnit).class347_0.method_16().ToString();
												}
												luaTable[luaTable.Keys.Count + 1] = luaTable3;
												flag2 = true;
											}
											else if (Operators.CompareString(text2.ToUpper(), "CARGO", false) == 0)
											{
												((Submarine)activeUnit).cargo_1.vmethod_8(damageSeverityFactor);
												luaTable3["name"] = text2.ToUpper();
												luaTable3["status"] = ((Submarine)activeUnit).cargo_1.vmethod_5().ToString();
												if (((Submarine)activeUnit).cargo_1.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
												{
													luaTable3["damage"] = ((Submarine)activeUnit).cargo_1.method_16().ToString();
												}
												luaTable[luaTable.Keys.Count + 1] = luaTable3;
												flag2 = true;
											}
											else if (Operators.CompareString(text2.ToUpper(), "PRESSUREHULL", false) == 0)
											{
												((Submarine)activeUnit).class346_0.vmethod_8(damageSeverityFactor);
												luaTable3["name"] = text2.ToUpper();
												luaTable3["status"] = ((Submarine)activeUnit).class346_0.vmethod_5().ToString();
												if (((Submarine)activeUnit).class346_0.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
												{
													luaTable3["damage"] = ((Submarine)activeUnit).class346_0.method_16().ToString();
												}
												luaTable[luaTable.Keys.Count + 1] = luaTable3;
												flag2 = true;
											}
											else if (Operators.CompareString(text2.ToUpper(), "CIC", false) == 0)
											{
												((Submarine)activeUnit).class345_0.vmethod_8(damageSeverityFactor);
												luaTable3["name"] = text2.ToUpper();
												luaTable3["status"] = ((Submarine)activeUnit).class345_0.vmethod_5().ToString();
												if (((Submarine)activeUnit).class345_0.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
												{
													luaTable3["damage"] = ((Submarine)activeUnit).class345_0.method_16().ToString();
												}
												luaTable[luaTable.Keys.Count + 1] = luaTable3;
												flag2 = true;
											}
										}
										else if (Operators.CompareString(text2.ToUpper(), "RUDDER", false) == 0)
										{
											((Ship)activeUnit).class347_0.vmethod_8(damageSeverityFactor);
											luaTable3["name"] = text2.ToUpper();
											luaTable3["status"] = ((Ship)activeUnit).class347_0.vmethod_5().ToString();
											if (((Ship)activeUnit).class347_0.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
											{
												luaTable3["damage"] = ((Ship)activeUnit).class347_0.method_16().ToString();
											}
											luaTable[luaTable.Keys.Count + 1] = luaTable3;
											flag2 = true;
										}
										else if (Operators.CompareString(text2.ToUpper(), "CARGO", false) != 0 && Operators.CompareString(text2.ToUpper(), "PRESSUREHULL", false) != 0 && Operators.CompareString(text2.ToUpper(), "CIC", false) == 0)
										{
											((Ship)activeUnit).class345_0.vmethod_8(damageSeverityFactor);
											luaTable3["name"] = text2.ToUpper();
											luaTable3["status"] = ((Ship)activeUnit).class345_0.vmethod_5().ToString();
											if (((Ship)activeUnit).class345_0.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
											{
												luaTable3["damage"] = ((Ship)activeUnit).class345_0.method_16().ToString();
											}
											luaTable[luaTable.Keys.Count + 1] = luaTable3;
											flag2 = true;
										}
										if (count > 0 & !flag2)
										{
											try
											{
												IEnumerator<PlatformComponent> enumerator3 = activeUnit.vmethod_120().GetEnumerator();
												while (enumerator3.MoveNext())
												{
													platformComponent = enumerator3.Current;
													if (Operators.CompareString(platformComponent.string_0.ToUpper(), text2.ToUpper(), false) == 0 | Operators.CompareString(platformComponent.Name.ToUpper(), text2.ToUpper(), false) == 0)
													{
														PlatformComponent._DamageSeverityFactor damageSeverityFactor4 = platformComponent.method_16();
														platformComponent.vmethod_8(damageSeverityFactor);
														if (damageSeverityFactor == PlatformComponent._DamageSeverityFactor.Light & (flag | damageSeverityFactor4 > PlatformComponent._DamageSeverityFactor.Light))
														{
															platformComponent.vmethod_7();
														}
														LuaTable luaTable4 = LuaSandBox.Singleton().CreateTable();
														luaTable4["guid"] = platformComponent.string_0;
														luaTable4["dbid"] = platformComponent.DBID;
														luaTable4["name"] = platformComponent.Name;
														luaTable4["type"] = platformComponent.GetType().Name;
														luaTable4["status"] = platformComponent.vmethod_5().ToString();
														if (platformComponent.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
														{
															luaTable4["damage"] = platformComponent.method_16().ToString();
														}
														luaTable[luaTable.Keys.Count + 1] = luaTable4;
														break;
													}
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
										}
									}
								}
							}
							goto IL_D42;
						}
						finally
						{
							List<object>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						goto IL_D3B;
					}
					IL_D42:
					LuaUtility.smethod_3(dictionary, luaTable_0);
					return luaTable;
				}
				IL_D3B:
				throw new Exception3(text);
			}
			catch (Exception ex5)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			LuaTable result;
			return result;
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x002513BC File Offset: 0x0024F5BC
		public static bool smethod_21(string string_0, string string_1, string string_2, Scenario scenario_0)
		{
			Doctrine doctrine = null;
			string_0 = Strings.Trim(string_0);
			string_1 = Strings.Trim(string_1);
			string_2 = Strings.Trim(string_2);
			bool result;
			try
			{
				string left = string_0.ToUpper();
				if (Operators.CompareString(left, "SIDE", false) != 0)
				{
					if (Operators.CompareString(left, "MISSION", false) != 0)
					{
						if (Operators.CompareString(left, "GROUP", false) != 0)
						{
							if (Operators.CompareString(left, "UNIT", false) != 0)
							{
								throw new Exception3("Unable to identify EMCON subject type! Valid inputs are: Side / Mission /Group / Unit");
							}
							try
							{
								foreach (ActiveUnit activeUnit in scenario_0.method_42())
								{
									if (activeUnit != null && (Operators.CompareString(activeUnit.Name.ToUpper(), string_1.ToUpper(), false) == 0 || Operators.CompareString(activeUnit.string_0.ToLower(), string_1.ToLower(), false) == 0))
									{
										doctrine = activeUnit.doctrine_0;
										IL_D3:
										goto IL_258;
									}
								}
								goto IL_D3;
							}
							finally
							{
								List<ActiveUnit>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						try
						{
							foreach (ActiveUnit activeUnit2 in scenario_0.method_42())
							{
								if (activeUnit2 != null && activeUnit2.bool_1 && (Operators.CompareString(activeUnit2.Name.ToUpper(), string_1.ToUpper(), false) == 0 || Operators.CompareString(activeUnit2.string_0.ToLower(), string_1.ToLower(), false) == 0))
								{
									doctrine = activeUnit2.doctrine_0;
									IL_153:
									goto IL_258;
								}
							}
							goto IL_153;
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
					foreach (Side side in scenario_0.method_44())
					{
						try
						{
							foreach (Mission mission in side.method_35())
							{
								if (Operators.CompareString(mission.Name.ToUpper(), string_1.ToUpper(), false) == 0 || Operators.CompareString(mission.string_0.ToLower(), string_1.ToLower(), false) == 0)
								{
									doctrine = mission.doctrine_0;
									break;
								}
							}
						}
						finally
						{
							IEnumerator<Mission> enumerator3;
							if (enumerator3 != null)
							{
								enumerator3.Dispose();
							}
						}
					}
				}
				else
				{
					foreach (Side side2 in scenario_0.method_44())
					{
						if (Operators.CompareString(side2.method_51().ToUpper(), string_1.ToUpper(), false) == 0 || Operators.CompareString(side2.string_0.ToLower(), string_1.ToLower(), false) == 0)
						{
							doctrine = side2.doctrine_0;
							break;
						}
					}
				}
				IL_258:
				if (doctrine == null)
				{
					throw new Exception3("Unable to identify subject of EMCON change! Please verify the subject-type and subject-name/ID strings.");
				}
				foreach (string text in string_2.Split(new char[]
				{
					';'
				}))
				{
					if (Operators.CompareString(text.ToUpper(), "INHERIT", false) == 0)
					{
						doctrine.method_8(true);
					}
					else
					{
						KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>(text.Split(new char[]
						{
							'='
						})[0], text.Split(new char[]
						{
							'='
						})[1]);
						string left2 = keyValuePair.Key.ToUpper();
						if (Operators.CompareString(left2, "RADAR", false) != 0)
						{
							if (Operators.CompareString(left2, "SONAR", false) != 0)
							{
								if (Operators.CompareString(left2, "OECM", false) == 0)
								{
									if (Operators.CompareString(keyValuePair.Value.ToUpper(), "ACTIVE", false) == 0)
									{
										if (doctrine.method_7())
										{
											doctrine.method_8(false);
										}
										doctrine.method_194(Doctrine.Class275.Enum66.const_1, scenario_0);
									}
									else
									{
										if (Operators.CompareString(keyValuePair.Value.ToUpper(), "PASSIVE", false) != 0)
										{
											throw new Exception3("Invalid value for OECM EMCON setting (Valid values: Active / Passive).");
										}
										if (doctrine.method_7())
										{
											doctrine.method_8(false);
										}
										doctrine.method_194(Doctrine.Class275.Enum66.const_0, scenario_0);
									}
								}
							}
							else if (Operators.CompareString(keyValuePair.Value.ToUpper(), "ACTIVE", false) == 0)
							{
								if (doctrine.method_7())
								{
									doctrine.method_8(false);
								}
								doctrine.method_193(Doctrine.Class275.Enum66.const_1, scenario_0);
							}
							else
							{
								if (Operators.CompareString(keyValuePair.Value.ToUpper(), "PASSIVE", false) != 0)
								{
									throw new Exception3("Invalid value for sonar EMCON setting (Valid values: Active / Passive).");
								}
								if (doctrine.method_7())
								{
									doctrine.method_8(false);
								}
								doctrine.method_193(Doctrine.Class275.Enum66.const_0, scenario_0);
							}
						}
						else if (Operators.CompareString(keyValuePair.Value.ToUpper(), "ACTIVE", false) == 0)
						{
							if (doctrine.method_7())
							{
								doctrine.method_8(false);
							}
							doctrine.method_192(Doctrine.Class275.Enum66.const_1, scenario_0);
						}
						else
						{
							if (Operators.CompareString(keyValuePair.Value.ToUpper(), "PASSIVE", false) != 0)
							{
								throw new Exception3("Invalid value for radar EMCON setting (Valid values: Active / Passive).");
							}
							if (doctrine.method_7())
							{
								doctrine.method_8(false);
							}
							doctrine.method_192(Doctrine.Class275.Enum66.const_0, scenario_0);
						}
					}
				}
				result = true;
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

		// Token: 0x0600211E RID: 8478 RVA: 0x002518D0 File Offset: 0x0024FAD0
		public static string smethod_22(string string_0, int int_0, Scenario scenario_0)
		{
			string result = "";
			PrivateMethods.Delegate58 @delegate = PrivateMethods.delegate58_0;
			if (@delegate != null)
			{
				@delegate(string_0, int_0, scenario_0.RunningInMonteCarloMode, ref result);
			}
			return result;
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x00251900 File Offset: 0x0024FB00
		public static string smethod_23(string string_0)
		{
			string result = "";
			PrivateMethods.Delegate59 @delegate = PrivateMethods.delegate59_0;
			if (@delegate != null)
			{
				@delegate(string_0, ref result);
			}
			return result;
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x00251928 File Offset: 0x0024FB28
		public static string smethod_24(string string_0, bool bool_0, int int_0)
		{
			if (!File.Exists(string_0))
			{
				if (!File.Exists(Class160.smethod_1().Info.DirectoryPath + "\\Video\\" + string_0))
				{
					return "N";
				}
				string_0 = Class160.smethod_1().Info.DirectoryPath + "\\Video\\" + string_0;
			}
			PrivateMethods.Delegate60 @delegate = PrivateMethods.delegate60_0;
			if (@delegate != null)
			{
				@delegate(string_0, bool_0, int_0);
			}
			return "";
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x002519A0 File Offset: 0x0024FBA0
		public static bool smethod_25(string string_0, int int_0)
		{
			if (!File.Exists(string_0))
			{
				if (!File.Exists(Class160.smethod_1().Info.DirectoryPath + " \\Sound\\Effects\\" + string_0))
				{
					return false;
				}
				string_0 = Class160.smethod_1().Info.DirectoryPath + "\\Sound\\Effects\\" + string_0;
			}
			PrivateMethods.Delegate61 @delegate = PrivateMethods.delegate61_0;
			if (@delegate != null)
			{
				@delegate(string_0, int_0);
			}
			return true;
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x00010705 File Offset: 0x0000E905
		public static int smethod_26(string string_0, Scenario scenario_0)
		{
			Side side = LuaUtility.smethod_15(string_0, scenario_0);
			if (Information.IsNothing(side))
			{
				throw new Exception3("Unable to identify Side!");
			}
			return side.method_22(scenario_0, null);
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00251A0C File Offset: 0x0024FC0C
		public static string smethod_27(string string_0, string string_1, Scenario scenario_0)
		{
			try
			{
				Side side = null;
				Side side2 = null;
				foreach (Side side3 in scenario_0.method_44())
				{
					if (Operators.CompareString(side3.method_51().ToUpper(), string_0.ToUpper(), false) == 0 || Operators.CompareString(side3.string_0.ToLower(), string_0.ToLower(), false) == 0)
					{
						side = side3;
					}
					if (Operators.CompareString(side3.method_51().ToUpper(), string_1.ToUpper(), false) == 0 || Operators.CompareString(side3.string_0.ToLower(), string_1.ToLower(), false) == 0)
					{
						side2 = side3;
					}
				}
				if (Information.IsNothing(side))
				{
					throw new Exception3("Unable to identify Side-A!");
				}
				if (Information.IsNothing(side2))
				{
					throw new Exception3("Unable to identify Side-B!");
				}
				switch (side.method_68(side2))
				{
				case Misc.PostureStance.Neutral:
					return "N";
				case Misc.PostureStance.Friendly:
					return "F";
				case Misc.PostureStance.Unfriendly:
					return "U";
				case Misc.PostureStance.Hostile:
					return "H";
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
			return "";
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x00251B40 File Offset: 0x0024FD40
		public static LuaTable smethod_28(LuaTable luaTable_0, Scenario scenario_0)
		{
			try
			{
				Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
				Side side = null;
				if (dictionary.ContainsKey("SIDE"))
				{
					string str = null;
					try
					{
						str = Conversions.ToString(dictionary["SIDE"]);
					}
					catch (Exception ex)
					{
						throw new Exception3("side must be a string");
					}
					try
					{
						side = LuaUtility.smethod_16(dictionary, scenario_0);
					}
					catch (Exception ex2)
					{
						throw new Exception3("Can't find Side '" + str + "'");
					}
				}
				dictionary["SIDE"] = side.method_51();
				dictionary["GUID"] = side.string_0;
				dictionary["AWARENESS"] = side.method_28().ToString();
				dictionary["PROFICIENCY"] = side.method_24().ToString();
				LuaUtility.smethod_3(dictionary, luaTable_0);
			}
			catch (Exception ex3)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return luaTable_0;
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x00251C64 File Offset: 0x0024FE64
		public static bool smethod_29(string string_0, Scenario scenario_0)
		{
			checked
			{
				try
				{
					Side side = null;
					Side[] array = scenario_0.method_44();
					int i = 0;
					while (i < array.Length)
					{
						side = array[i];
						if (Operators.CompareString(side.method_51().ToUpper(), string_0.ToUpper(), false) != 0 && Operators.CompareString(side.string_0.ToLower(), string_0.ToLower(), false) != 0)
						{
							i++;
						}
						else
						{
							side = side;
							IL_51:
							if (Information.IsNothing(side))
							{
								throw new Exception3("Unable to identify side!");
							}
							return side.bool_11;
						}
					}
					goto IL_51;
				}
				catch (Exception ex)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
				bool result;
				return result;
			}
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x00251D04 File Offset: 0x0024FF04
		public static double smethod_30(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			if (dictionary.ContainsKey("DATE"))
			{
				string text = Conversions.ToString(dictionary["DATE"]);
				string value = string.Empty;
				if (text.Contains(":"))
				{
					value = ":";
				}
				else if (text.Contains("."))
				{
					value = ".";
				}
				if (string.IsNullOrEmpty(value))
				{
					throw new Exception3("Error in parsing provided date value: " + text + " - The delimiter must be either (.) or (:)");
				}
				int month;
				int day;
				int year;
				try
				{
					month = Conversions.ToInteger(text.Split(new char[]
					{
						Conversions.ToChar(value)
					})[0]);
					day = Conversions.ToInteger(text.Split(new char[]
					{
						Conversions.ToChar(value)
					})[1]);
					year = Conversions.ToInteger(text.Split(new char[]
					{
						Conversions.ToChar(value)
					})[2]);
				}
				catch (Exception ex)
				{
					throw new Exception3("Error in parsing provided date value: " + text + " - Error: " + ex.Message);
				}
				scenario_0.method_32(true, new DateTime(year, month, day, scenario_0.method_31().Hour, scenario_0.method_31().Minute, scenario_0.method_31().Second));
			}
			if (dictionary.ContainsKey("TIME"))
			{
				string text2 = Conversions.ToString(dictionary["TIME"]);
				string value2 = string.Empty;
				if (text2.Contains(":"))
				{
					value2 = ":";
				}
				else if (text2.Contains("."))
				{
					value2 = ".";
				}
				if (string.IsNullOrEmpty(value2))
				{
					throw new Exception3("Error in parsing provided time value: " + text2 + " - The delimiter must be either (.) or (:)");
				}
				int hour;
				int minute;
				int second;
				try
				{
					hour = Conversions.ToInteger(text2.Split(new char[]
					{
						Conversions.ToChar(value2)
					})[0]);
					minute = Conversions.ToInteger(text2.Split(new char[]
					{
						Conversions.ToChar(value2)
					})[1]);
					second = Conversions.ToInteger(text2.Split(new char[]
					{
						Conversions.ToChar(value2)
					})[2]);
				}
				catch (Exception ex2)
				{
					throw new Exception3("Error in parsing provided time value: " + text2 + " - Error: " + ex2.Message);
				}
				scenario_0.method_32(true, new DateTime(scenario_0.method_31().Year, scenario_0.method_31().Month, scenario_0.method_31().Day, hour, minute, second));
			}
			return (scenario_0.method_31() - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x00010728 File Offset: 0x0000E928
		public static int smethod_31(string string_0, int int_0, Scenario scenario_0, string string_1)
		{
			Side side = LuaUtility.smethod_15(string_0, scenario_0);
			if (Information.IsNothing(side))
			{
				throw new Exception3("Unable to identify Side!");
			}
			side.method_23(scenario_0, string_1, int_0);
			return side.method_22(scenario_0, null);
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x00251FD0 File Offset: 0x002501D0
		public static int smethod_32(string string_0, string string_1, Scenario scenario_0, LuaTable luaTable_0)
		{
			Side side = LuaUtility.smethod_15(string_0, scenario_0);
			if (Information.IsNothing(side))
			{
				throw new Exception3("Unable to identify Side-A!");
			}
			Geopoint_Struct? geopoint_Struct = null;
			if (!Information.IsNothing(luaTable_0))
			{
				Dictionary<string, object> dictionary_ = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
				double? num = LuaUtility.smethod_11(dictionary_);
				if (num == null)
				{
					throw new Exception3("Missing 'Latitude'");
				}
				double? num2 = LuaUtility.smethod_13(dictionary_);
				if (num2 == null)
				{
					throw new Exception3("Missing 'Longitude'");
				}
				geopoint_Struct = new Geopoint_Struct?(new Geopoint_Struct(num2.Value, num.Value));
			}
			scenario_0.method_59(string_1, string_1, LoggedMessage.MessageType.SpecialMessage, 0, null, side, geopoint_Struct.GetValueOrDefault());
			return 1;
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x00252078 File Offset: 0x00250278
		public static LuaWrapper_ActiveUnit_SE smethod_33(LuaTable luaTable_0, Scenario scenario_0)
		{
			ActiveUnit activeUnit = null;
			int orbitIndex = 0;
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			LuaUtility.smethod_5(ref dictionary);
			if (!dictionary.ContainsKey("TYPE"))
			{
				throw new Exception3("Missing 'Type' please choose one of SHIP, SUB, AIRCRAFT, FACILITY");
			}
			string text = Conversions.ToString(dictionary["TYPE"]).ToUpper();
			Side theSide = LuaUtility.smethod_17(dictionary, scenario_0);
			if (!dictionary.ContainsKey("DBID"))
			{
				throw new Exception3("Missing 'DBID'");
			}
			int num = Conversions.ToInteger(dictionary["DBID"]);
			if (!dictionary.ContainsKey("UNITNAME"))
			{
				throw new Exception3("Missing 'Name'");
			}
			string theName = Conversions.ToString(dictionary["UNITNAME"]);
			double? num2 = LuaUtility.smethod_11(dictionary);
			double? num3 = LuaUtility.smethod_13(dictionary);
			bool ignoreElevationCheck = false;
			if (!dictionary.ContainsKey("BASE"))
			{
				if (num2 == null)
				{
					throw new Exception3("Missing 'Latitude'");
				}
				if (num3 == null)
				{
					throw new Exception3("Missing 'Longitude'");
				}
			}
			else
			{
				string auname = Conversions.ToString(dictionary["BASE"]);
				if (!LuaUtility.smethod_29(dictionary, scenario_0))
				{
					throw new Exception3("Invalid base unit");
				}
				string text2 = Conversions.ToString(dictionary["BASE"]);
				ActiveUnit activeUnit2 = PrivateMethods.smethod_67(Conversions.ToString(dictionary["BASE"]), scenario_0);
				string auguid = text2;
				int i = 0;
				Class350 @class = null;
				if (Operators.CompareString(text, "AIR", false) != 0 && Operators.CompareString(text, "AIRCRAFT", false) != 0)
				{
					if (Operators.CompareString(text, "SHIP", false) == 0 || (Operators.CompareString(text, "SUB", false) == 0 | Operators.CompareString(text, "SUBMARINE", false) == 0))
					{
						@class = new Ship(ref scenario_0, null);
						Ship ship = (Ship)@class;
						DBFunctions.smethod_53(ref scenario_0, ref ship, num, true);
					}
				}
				else
				{
					@class = new Aircraft(ref scenario_0, null);
					Aircraft aircraft = (Aircraft)@class;
					DBFunctions.smethod_19(ref scenario_0, ref aircraft, num, true);
				}
				while (i < 100)
				{
					if (Operators.CompareString(text, "AIR", false) != 0 && Operators.CompareString(text, "AIRCRAFT", false) != 0)
					{
						if (Operators.CompareString(text, "SHIP", false) == 0 || (Operators.CompareString(text, "SUB", false) == 0 | Operators.CompareString(text, "SUBMARINE", false) == 0))
						{
							ActiveUnit_DockingOps activeUnit_DockingOps = activeUnit2.vmethod_93();
							ActiveUnit theBoat = @class;
							DockFacility dockFacility = null;
							if (!activeUnit_DockingOps.method_40(theBoat, ref dockFacility))
							{
								i++;
								activeUnit2 = PrivateMethods.smethod_70(auguid, auname, scenario_0, true);
								if (activeUnit2 != null)
								{
									auguid = activeUnit2.string_0;
								}
								else
								{
									if (text2 != null)
									{
										dictionary["BASE"] = text2;
										break;
									}
									break;
								}
							}
							else
							{
								if (num3 == null | num2 == null)
								{
									dictionary["LONGITUDE"] = activeUnit2.vmethod_28(null);
									dictionary["LATITUDE"] = activeUnit2.vmethod_30(null);
									num3 = new double?(activeUnit2.vmethod_28(null));
									num2 = new double?(activeUnit2.vmethod_30(null));
									dictionary["BASE"] = activeUnit2.string_0;
									ignoreElevationCheck = true;
									break;
								}
								break;
							}
						}
					}
					else if (!activeUnit2.vmethod_92().vmethod_8((Aircraft)@class))
					{
						i++;
						activeUnit2 = PrivateMethods.smethod_70(auguid, auname, scenario_0, true);
						if (activeUnit2 != null)
						{
							auguid = activeUnit2.string_0;
						}
						else
						{
							if (text2 != null)
							{
								dictionary["BASE"] = text2;
								break;
							}
							break;
						}
					}
					else
					{
						if (num3 == null | num2 == null)
						{
							dictionary["ALTITUDE"] = activeUnit2.vmethod_14(false);
							dictionary["LONGITUDE"] = activeUnit2.vmethod_28(null);
							dictionary["LATITUDE"] = activeUnit2.vmethod_30(null);
							num3 = new double?(activeUnit2.vmethod_28(null));
							num2 = new double?(activeUnit2.vmethod_30(null));
							dictionary["BASE"] = activeUnit2.string_0;
							break;
						}
						break;
					}
				}
			}
			string text3 = null;
			if (dictionary.ContainsKey("GUID"))
			{
				text3 = Conversions.ToString(dictionary["GUID"]);
			}
			try
			{
				uint num4 = Class582.smethod_0(text);
				if (num4 <= 1970077047U)
				{
					if (num4 <= 701195594U)
					{
						if (num4 != 522735669U)
						{
							if (num4 != 701195594U)
							{
								goto IL_651;
							}
							if (Operators.CompareString(text, "SATELLITE", false) == 0)
							{
								if (dictionary.ContainsKey("ORBIT"))
								{
									orbitIndex = Conversions.ToInteger(dictionary["GUID"]);
								}
								activeUnit = scenario_0.method_72(theSide, theName, num, orbitIndex, Unit.Enum122.const_0, text3);
								dictionary["TYPE"] = "SATELLITE";
								goto IL_6EC;
							}
							goto IL_651;
						}
						else
						{
							if (Operators.CompareString(text, "SUB", false) != 0)
							{
								goto IL_651;
							}
							goto IL_5B9;
						}
					}
					else if (num4 != 1434383544U)
					{
						if (num4 != 1970077047U)
						{
							goto IL_651;
						}
						if (Operators.CompareString(text, "AIR", false) != 0)
						{
							goto IL_651;
						}
						goto IL_667;
					}
					else if (Operators.CompareString(text, "FACILITY", false) != 0)
					{
						goto IL_651;
					}
				}
				else if (num4 <= 2872863644U)
				{
					if (num4 != 2872515511U)
					{
						if (num4 != 2872863644U)
						{
							goto IL_651;
						}
						if (Operators.CompareString(text, "LAND", false) != 0)
						{
							goto IL_651;
						}
					}
					else
					{
						if (Operators.CompareString(text, "SUBMARINE", false) == 0)
						{
							goto IL_5B9;
						}
						goto IL_651;
					}
				}
				else if (num4 != 2901380595U)
				{
					if (num4 == 3920176767U && Operators.CompareString(text, "SHIP", false) == 0)
					{
						activeUnit = scenario_0.method_73(theSide, num, theName, num3.Value, num2.Value, ignoreElevationCheck, Unit.Enum122.const_0, text3);
						dictionary["TYPE"] = "SHIP";
						goto IL_6EC;
					}
					goto IL_651;
				}
				else
				{
					if (Operators.CompareString(text, "AIRCRAFT", false) != 0)
					{
						goto IL_651;
					}
					goto IL_667;
				}
				activeUnit = scenario_0.method_76(theSide, num, theName, num3.Value, num2.Value, ignoreElevationCheck, Unit.Enum122.const_0, text3);
				dictionary["TYPE"] = "FACILITY";
				goto IL_6EC;
				IL_5B9:
				activeUnit = scenario_0.method_75(theSide, num, theName, num3.Value, num2.Value, ignoreElevationCheck, Unit.Enum122.const_0, text3);
				dictionary["TYPE"] = "SUBMARINE";
				goto IL_6EC;
				IL_651:
				throw new Exception3("Type cannot be " + text + " please choose one of the following: SHIP, SUB, AIRCRAFT, FACILITY, SATELLITE");
				IL_667:
				if (!dictionary.ContainsKey("LOADOUTID"))
				{
					throw new Exception3("Missing 'LoadoutID'");
				}
				int loadoutID = Conversions.ToInteger(dictionary["LOADOUTID"]);
				float? num5 = LuaUtility.smethod_20(dictionary);
				if (num5 == null)
				{
					throw new Exception3("Missing 'Altitude'");
				}
				activeUnit = scenario_0.method_71(theSide, theName, num3.Value, num2.Value, num, loadoutID, (float)((short)Math.Round((double)num5.Value)), Unit.Enum122.const_0, text3);
				dictionary["TYPE"] = "AIRCRAFT";
				IL_6EC:;
			}
			catch (Exception ex)
			{
			}
			if (activeUnit == null)
			{
				throw new Exception3("Unable to create new unit");
			}
			text3 = activeUnit.string_0;
			dictionary["GUID"] = text3;
			if (dictionary.ContainsKey("BASE"))
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				luaTable["HostedUnitNameOrID"] = activeUnit.string_0;
				luaTable["SelectedHostNameOrID"] = Conversions.ToString(dictionary["BASE"]);
				if (!PrivateMethods.smethod_9(luaTable, scenario_0, null))
				{
					throw new Exception3("Unable to host unit");
				}
				activeUnit.vmethod_41(0f);
				activeUnit.vmethod_134(ActiveUnit.Throttle.FullStop, null);
			}
			LuaUtility.smethod_3(dictionary, luaTable_0);
			return PrivateMethods.smethod_38(luaTable_0, scenario_0);
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x00252840 File Offset: 0x00250A40
		public static LuaWrapper_ActiveUnit_SE smethod_34(LuaTable luaTable_0, Scenario scenario_0)
		{
			ActiveUnit activeUnit = null;
			string text = null;
			int num = 0;
			PlatformComponent.Class295 @class = null;
			PlatformComponent.Class295 class2 = null;
			PlatformComponent.Class295 class3 = null;
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			LuaUtility.smethod_5(ref dictionary);
			if (dictionary.ContainsKey("GUID"))
			{
				string text2 = null;
				try
				{
					text2 = Conversions.ToString(dictionary["GUID"]);
					activeUnit = scenario_0.vmethod_0()[text2];
					if (activeUnit == null)
					{
						throw new Exception3("Can't find unit guid " + text2);
					}
				}
				catch (Exception ex)
				{
					if (ex is Exception3)
					{
						throw;
					}
					throw new Exception3("Can't find unit guid " + text2);
				}
			}
			if (dictionary.ContainsKey("MODE"))
			{
				try
				{
					text = Conversions.ToString(dictionary["MODE"]).ToUpper();
					if (Operators.CompareString(text, "ADD_SENSOR", false) != 0 && Operators.CompareString(text, "REMOVE_SENSOR", false) != 0 && Operators.CompareString(text, "UPDATE_SENSOR_ARC", false) != 0 && Operators.CompareString(text, "ADD_COMMS", false) != 0 && Operators.CompareString(text, "REMOVE_COMMS", false) != 0 && Operators.CompareString(text, "UPDATE_COMMS_ARC", false) != 0 && Operators.CompareString(text, "ADD_MOUNT", false) != 0 && Operators.CompareString(text, "REMOVE_MOUNT", false) != 0 && Operators.CompareString(text, "UPDATE_MOUNT_ARC", false) != 0 && Operators.CompareString(text, "ADD_WEAPON", false) != 0 && Operators.CompareString(text, "REMOVE_WEAPON", false) != 0 && Operators.CompareString(text, "DELTA", false) != 0)
					{
						throw new Exception3("function should be 'add_sensor', 'remove_sensor', 'add_mount', 'remove_mount', 'add_weapon', 'remove_weapon','add_comms', 'remove_comms', 'delta'");
					}
				}
				catch (Exception ex2)
				{
					throw;
				}
			}
			if (dictionary.ContainsKey("DBID"))
			{
				try
				{
					num = Conversions.ToInteger(dictionary["DBID"]);
				}
				catch (Exception ex3)
				{
					throw new Exception3("Missing dbid");
				}
			}
			uint num2;
			if (dictionary.ContainsKey("ARC_DETECT"))
			{
				LuaTable luaTable = (LuaTable)dictionary["ARC_DETECT"];
				PlatformComponent.Class295 class4 = new PlatformComponent.Class295();
				Conversions.ToString(LuaUtility.smethod_1(luaTable.GetEnumerator())["1"]);
				List<object> list = LuaUtility.smethod_0(luaTable.GetEnumerator());
				try
				{
					try
					{
						foreach (object value in list)
						{
							string text3 = Conversions.ToString(value);
							string text4 = text3.ToUpper();
							num2 = Class582.smethod_0(text4);
							if (num2 <= 2181607519U)
							{
								if (num2 <= 1604558652U)
								{
									if (num2 <= 1469204867U)
									{
										if (num2 != 3032978U)
										{
											if (num2 == 1469204867U)
											{
												if (Operators.CompareString(text4, "PMF1", false) == 0)
												{
													class4.bool_2 = true;
													continue;
												}
											}
										}
										else if (Operators.CompareString(text4, "PS2", false) == 0)
										{
											class4.bool_8 = true;
											continue;
										}
									}
									else if (num2 != 1485982486U)
									{
										if (num2 == 1604558652U)
										{
											if (Operators.CompareString(text4, "PMA1", false) == 0)
											{
												class4.bool_1 = true;
												continue;
											}
										}
									}
									else if (Operators.CompareString(text4, "PMF2", false) == 0)
									{
										class4.bool_10 = true;
										continue;
									}
								}
								else if (num2 <= 1729738499U)
								{
									if (num2 != 1654891509U)
									{
										if (num2 == 1729738499U)
										{
											if (Operators.CompareString(text4, "SS2", false) == 0)
											{
												class4.bool_12 = true;
												continue;
											}
										}
									}
									else if (Operators.CompareString(text4, "PMA2", false) == 0)
									{
										class4.bool_9 = true;
										continue;
									}
								}
								else if (num2 != 1746516118U)
								{
									if (num2 == 2181607519U)
									{
										if (Operators.CompareString(text4, "PB2", false) == 0)
										{
											class4.bool_11 = true;
											continue;
										}
									}
								}
								else if (Operators.CompareString(text4, "SS1", false) == 0)
								{
									class4.bool_4 = true;
									continue;
								}
							}
							else if (num2 <= 2859869279U)
							{
								if (num2 <= 2725501232U)
								{
									if (num2 != 2198385138U)
									{
										if (num2 == 2725501232U)
										{
											if (Operators.CompareString(text4, "SMF1", false) == 0)
											{
												class4.bool_6 = true;
												continue;
											}
										}
									}
									else if (Operators.CompareString(text4, "PB1", false) == 0)
									{
										class4.bool_3 = true;
										continue;
									}
								}
								else if (num2 != 2775834089U)
								{
									if (num2 == 2859869279U)
									{
										if (Operators.CompareString(text4, "SMA1", false) == 0)
										{
											class4.bool_5 = true;
											continue;
										}
									}
								}
								else if (Operators.CompareString(text4, "SMF2", false) == 0)
								{
									class4.bool_14 = true;
									continue;
								}
							}
							else if (num2 <= 3512027844U)
							{
								if (num2 != 2876646898U)
								{
									if (num2 == 3512027844U)
									{
										if (Operators.CompareString(text4, "360", false) == 0)
										{
											class4.bool_3 = true;
											class4.bool_1 = true;
											class4.bool_2 = true;
											class4.bool_0 = true;
											class4.bool_7 = true;
											class4.bool_5 = true;
											class4.bool_6 = true;
											class4.bool_4 = true;
											class4.bool_11 = true;
											class4.bool_9 = true;
											class4.bool_10 = true;
											class4.bool_8 = true;
											class4.bool_15 = true;
											class4.bool_13 = true;
											class4.bool_14 = true;
											class4.bool_12 = true;
											break;
										}
									}
								}
								else if (Operators.CompareString(text4, "SMA2", false) == 0)
								{
									class4.bool_13 = true;
									continue;
								}
							}
							else if (num2 != 3824130755U)
							{
								if (num2 != 3840908374U)
								{
									if (num2 == 4281222655U)
									{
										if (Operators.CompareString(text4, "PS1", false) == 0)
										{
											class4.bool_0 = true;
											continue;
										}
									}
								}
								else if (Operators.CompareString(text4, "SB2", false) == 0)
								{
									class4.bool_15 = true;
									continue;
								}
							}
							else if (Operators.CompareString(text4, "SB1", false) == 0)
							{
								class4.bool_7 = true;
								continue;
							}
							throw new Exception3("Invalid arc in arc_detect " + text3);
						}
					}
					finally
					{
						List<object>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					@class = class4;
				}
				catch (Exception ex4)
				{
					throw;
				}
			}
			if (dictionary.ContainsKey("ARC_TRACK"))
			{
				LuaTable luaTable2 = (LuaTable)dictionary["ARC_TRACK"];
				PlatformComponent.Class295 class5 = new PlatformComponent.Class295();
				Conversions.ToString(LuaUtility.smethod_1(luaTable2.GetEnumerator())["1"]);
				List<object> list2 = LuaUtility.smethod_0(luaTable2.GetEnumerator());
				try
				{
					try
					{
						foreach (object value2 in list2)
						{
							string text5 = Conversions.ToString(value2);
							string text6 = text5.ToUpper();
							num2 = Class582.smethod_0(text6);
							if (num2 <= 2181607519U)
							{
								if (num2 <= 1604558652U)
								{
									if (num2 <= 1469204867U)
									{
										if (num2 != 3032978U)
										{
											if (num2 == 1469204867U)
											{
												if (Operators.CompareString(text6, "PMF1", false) == 0)
												{
													class5.bool_2 = true;
													continue;
												}
											}
										}
										else if (Operators.CompareString(text6, "PS2", false) == 0)
										{
											class5.bool_8 = true;
											continue;
										}
									}
									else if (num2 != 1485982486U)
									{
										if (num2 == 1604558652U)
										{
											if (Operators.CompareString(text6, "PMA1", false) == 0)
											{
												class5.bool_1 = true;
												continue;
											}
										}
									}
									else if (Operators.CompareString(text6, "PMF2", false) == 0)
									{
										class5.bool_10 = true;
										continue;
									}
								}
								else if (num2 <= 1729738499U)
								{
									if (num2 != 1654891509U)
									{
										if (num2 == 1729738499U)
										{
											if (Operators.CompareString(text6, "SS2", false) == 0)
											{
												class5.bool_12 = true;
												continue;
											}
										}
									}
									else if (Operators.CompareString(text6, "PMA2", false) == 0)
									{
										class5.bool_9 = true;
										continue;
									}
								}
								else if (num2 != 1746516118U)
								{
									if (num2 == 2181607519U)
									{
										if (Operators.CompareString(text6, "PB2", false) == 0)
										{
											class5.bool_11 = true;
											continue;
										}
									}
								}
								else if (Operators.CompareString(text6, "SS1", false) == 0)
								{
									class5.bool_4 = true;
									continue;
								}
							}
							else if (num2 <= 2859869279U)
							{
								if (num2 <= 2725501232U)
								{
									if (num2 != 2198385138U)
									{
										if (num2 == 2725501232U)
										{
											if (Operators.CompareString(text6, "SMF1", false) == 0)
											{
												class5.bool_6 = true;
												continue;
											}
										}
									}
									else if (Operators.CompareString(text6, "PB1", false) == 0)
									{
										class5.bool_3 = true;
										continue;
									}
								}
								else if (num2 != 2775834089U)
								{
									if (num2 == 2859869279U)
									{
										if (Operators.CompareString(text6, "SMA1", false) == 0)
										{
											class5.bool_5 = true;
											continue;
										}
									}
								}
								else if (Operators.CompareString(text6, "SMF2", false) == 0)
								{
									class5.bool_14 = true;
									continue;
								}
							}
							else if (num2 <= 3512027844U)
							{
								if (num2 != 2876646898U)
								{
									if (num2 == 3512027844U)
									{
										if (Operators.CompareString(text6, "360", false) == 0)
										{
											class5.bool_3 = true;
											class5.bool_1 = true;
											class5.bool_2 = true;
											class5.bool_0 = true;
											class5.bool_7 = true;
											class5.bool_5 = true;
											class5.bool_6 = true;
											class5.bool_4 = true;
											class5.bool_11 = true;
											class5.bool_9 = true;
											class5.bool_10 = true;
											class5.bool_8 = true;
											class5.bool_15 = true;
											class5.bool_13 = true;
											class5.bool_14 = true;
											class5.bool_12 = true;
											break;
										}
									}
								}
								else if (Operators.CompareString(text6, "SMA2", false) == 0)
								{
									class5.bool_13 = true;
									continue;
								}
							}
							else if (num2 != 3824130755U)
							{
								if (num2 != 3840908374U)
								{
									if (num2 == 4281222655U)
									{
										if (Operators.CompareString(text6, "PS1", false) == 0)
										{
											class5.bool_0 = true;
											continue;
										}
									}
								}
								else if (Operators.CompareString(text6, "SB2", false) == 0)
								{
									class5.bool_15 = true;
									continue;
								}
							}
							else if (Operators.CompareString(text6, "SB1", false) == 0)
							{
								class5.bool_7 = true;
								continue;
							}
							throw new Exception3("Invalid arc in arc_track " + text5);
						}
					}
					finally
					{
						List<object>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					class2 = class5;
				}
				catch (Exception ex5)
				{
					throw;
				}
			}
			if (dictionary.ContainsKey("ARC_MOUNT"))
			{
				LuaTable luaTable3 = (LuaTable)dictionary["ARC_MOUNT"];
				PlatformComponent.Class295 class6 = new PlatformComponent.Class295();
				Conversions.ToString(LuaUtility.smethod_1(luaTable3.GetEnumerator())["1"]);
				List<object> list3 = LuaUtility.smethod_0(luaTable3.GetEnumerator());
				try
				{
					try
					{
						foreach (object value3 in list3)
						{
							string text7 = Conversions.ToString(value3);
							string text8 = text7.ToUpper();
							num2 = Class582.smethod_0(text8);
							if (num2 <= 2181607519U)
							{
								if (num2 <= 1604558652U)
								{
									if (num2 <= 1469204867U)
									{
										if (num2 != 3032978U)
										{
											if (num2 == 1469204867U)
											{
												if (Operators.CompareString(text8, "PMF1", false) == 0)
												{
													class6.bool_2 = true;
													continue;
												}
											}
										}
										else if (Operators.CompareString(text8, "PS2", false) == 0)
										{
											class6.bool_8 = true;
											continue;
										}
									}
									else if (num2 != 1485982486U)
									{
										if (num2 == 1604558652U)
										{
											if (Operators.CompareString(text8, "PMA1", false) == 0)
											{
												class6.bool_1 = true;
												continue;
											}
										}
									}
									else if (Operators.CompareString(text8, "PMF2", false) == 0)
									{
										class6.bool_10 = true;
										continue;
									}
								}
								else if (num2 <= 1729738499U)
								{
									if (num2 != 1654891509U)
									{
										if (num2 == 1729738499U)
										{
											if (Operators.CompareString(text8, "SS2", false) == 0)
											{
												class6.bool_12 = true;
												continue;
											}
										}
									}
									else if (Operators.CompareString(text8, "PMA2", false) == 0)
									{
										class6.bool_9 = true;
										continue;
									}
								}
								else if (num2 != 1746516118U)
								{
									if (num2 == 2181607519U)
									{
										if (Operators.CompareString(text8, "PB2", false) == 0)
										{
											class6.bool_11 = true;
											continue;
										}
									}
								}
								else if (Operators.CompareString(text8, "SS1", false) == 0)
								{
									class6.bool_4 = true;
									continue;
								}
							}
							else if (num2 <= 2859869279U)
							{
								if (num2 <= 2725501232U)
								{
									if (num2 != 2198385138U)
									{
										if (num2 == 2725501232U)
										{
											if (Operators.CompareString(text8, "SMF1", false) == 0)
											{
												class6.bool_6 = true;
												continue;
											}
										}
									}
									else if (Operators.CompareString(text8, "PB1", false) == 0)
									{
										class6.bool_3 = true;
										continue;
									}
								}
								else if (num2 != 2775834089U)
								{
									if (num2 == 2859869279U)
									{
										if (Operators.CompareString(text8, "SMA1", false) == 0)
										{
											class6.bool_5 = true;
											continue;
										}
									}
								}
								else if (Operators.CompareString(text8, "SMF2", false) == 0)
								{
									class6.bool_14 = true;
									continue;
								}
							}
							else if (num2 <= 3512027844U)
							{
								if (num2 != 2876646898U)
								{
									if (num2 == 3512027844U)
									{
										if (Operators.CompareString(text8, "360", false) == 0)
										{
											class6.bool_3 = true;
											class6.bool_1 = true;
											class6.bool_2 = true;
											class6.bool_0 = true;
											class6.bool_7 = true;
											class6.bool_5 = true;
											class6.bool_6 = true;
											class6.bool_4 = true;
											class6.bool_11 = true;
											class6.bool_9 = true;
											class6.bool_10 = true;
											class6.bool_8 = true;
											class6.bool_15 = true;
											class6.bool_13 = true;
											class6.bool_14 = true;
											class6.bool_12 = true;
											break;
										}
									}
								}
								else if (Operators.CompareString(text8, "SMA2", false) == 0)
								{
									class6.bool_13 = true;
									continue;
								}
							}
							else if (num2 != 3824130755U)
							{
								if (num2 != 3840908374U)
								{
									if (num2 == 4281222655U)
									{
										if (Operators.CompareString(text8, "PS1", false) == 0)
										{
											class6.bool_0 = true;
											continue;
										}
									}
								}
								else if (Operators.CompareString(text8, "SB2", false) == 0)
								{
									class6.bool_15 = true;
									continue;
								}
							}
							else if (Operators.CompareString(text8, "SB1", false) == 0)
							{
								class6.bool_7 = true;
								continue;
							}
							throw new Exception3("Invalid arc in arc_mount " + text7);
						}
					}
					finally
					{
						List<object>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					class3 = class6;
				}
				catch (Exception ex6)
				{
					throw;
				}
			}
			num2 = Class582.smethod_0(text);
			if (num2 <= 1802865248U)
			{
				if (num2 <= 907492678U)
				{
					if (num2 != 383055087U)
					{
						if (num2 != 907492678U)
						{
							goto IL_1BFD;
						}
						if (Operators.CompareString(text, "ADD_MOUNT", false) != 0)
						{
							goto IL_1BFD;
						}
						goto IL_190C;
					}
					else if (Operators.CompareString(text, "ADD_SENSOR", false) != 0)
					{
						goto IL_1BFD;
					}
				}
				else if (num2 != 988623553U)
				{
					if (num2 != 1025132263U)
					{
						if (num2 != 1802865248U)
						{
							goto IL_1BFD;
						}
						if (Operators.CompareString(text, "UPDATE_SENSOR_ARC", false) != 0)
						{
							goto IL_1BFD;
						}
					}
					else
					{
						if (Operators.CompareString(text, "REMOVE_MOUNT", false) != 0)
						{
							goto IL_1BFD;
						}
						goto IL_190C;
					}
				}
				else
				{
					if (Operators.CompareString(text, "DELTA", false) == 0)
					{
						if (dictionary.ContainsKey("FILE"))
						{
							int num3 = 0;
							string path = GameGeneral.string_4 + "\\" + Conversions.ToString(dictionary["FILE"]);
							FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
							XmlDocument xmlDocument = new XmlDocument();
							new Dictionary<string, Class310>();
							string text9;
							using (fileStream)
							{
								try
								{
									xmlDocument.Load(fileStream);
								}
								catch (Exception ex7)
								{
									text9 = "File Is improperly formatted, read failed!";
									throw new Exception3(text9);
								}
								fileStream.Close();
							}
							XmlNode xmlNode = xmlDocument.SelectSingleNode("/ScenarioUnits");
							if (xmlNode == null)
							{
								goto IL_1BFD;
							}
							XmlNodeList childNodes = xmlNode.ChildNodes;
							text9 = string.Concat(new string[]
							{
								"\r\n",
								DateAndTime.Now.ToString(),
								" Lua update to ",
								scenario_0.method_0(),
								" Platform list: \r\n  DBID -- Unit name  ----  Class Info  ----  ObjectID"
							});
							StreamWriter streamWriter = File.AppendText(Class160.smethod_1().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
							streamWriter.Write(text9);
							streamWriter.Close();
							try
							{
								foreach (object obj in childNodes)
								{
									XmlNode xmlNode2 = (XmlNode)obj;
									string text10 = xmlNode2.Name.Split(new char[]
									{
										'_'
									})[1];
									string innerText = Misc.smethod_44(xmlNode2.ChildNodes, "#comment").InnerText;
									ActiveUnit activeUnit2 = scenario_0.vmethod_0()[text10];
									if (activeUnit2 == null)
									{
										if (innerText.StartsWith(activeUnit.Name))
										{
											Class559.smethod_8(xmlNode2, activeUnit, scenario_0, null, null, false, ref num3);
											break;
										}
									}
									else
									{
										if (Operators.CompareString(activeUnit2.string_0, activeUnit.string_0, false) == 0)
										{
											Class559.smethod_8(xmlNode2, activeUnit, scenario_0, null, null, false, ref num3);
											break;
										}
										if (innerText.StartsWith(activeUnit.Name))
										{
											Class559.smethod_8(xmlNode2, activeUnit, scenario_0, null, null, false, ref num3);
											break;
										}
									}
									if (activeUnit2 == null)
									{
										text9 = "ERROR: UNIT # " + text10 + " DOES NOT EXIST IN SCENARIO!";
										throw new Exception3(text9);
									}
								}
								goto IL_1BFD;
							}
							finally
							{
								IEnumerator enumerator4;
								if (enumerator4 is IDisposable)
								{
									(enumerator4 as IDisposable).Dispose();
								}
							}
						}
						throw new Exception3("Missing file on applying delta ");
					}
					goto IL_1BFD;
				}
			}
			else
			{
				if (num2 > 2371881526U)
				{
					goto IL_14F0;
				}
				if (num2 != 1842088560U)
				{
					if (num2 != 2111523351U)
					{
						if (num2 != 2371881526U)
						{
							goto IL_1BFD;
						}
						if (Operators.CompareString(text, "REMOVE_WEAPON", false) != 0)
						{
							goto IL_1BFD;
						}
						goto IL_1527;
					}
					else
					{
						if (Operators.CompareString(text, "REMOVE_COMMS", false) != 0)
						{
							goto IL_1BFD;
						}
						goto IL_1766;
					}
				}
				else if (Operators.CompareString(text, "REMOVE_SENSOR", false) != 0)
				{
					goto IL_1BFD;
				}
			}
			checked
			{
				if (Operators.CompareString(text, "ADD_SENSOR", false) != 0)
				{
					if (Operators.CompareString(text, "REMOVE_SENSOR", false) == 0)
					{
						if (!dictionary.ContainsKey("SENSORID") && num > 0)
						{
							foreach (Sensor sensor in activeUnit.vmethod_96())
							{
								if (sensor.DBID == num)
								{
									dictionary["SENSORID"] = sensor.string_0;
									break;
								}
							}
						}
						if (dictionary.ContainsKey("SENSORID"))
						{
							string text11 = null;
							Sensor sensor2 = null;
							try
							{
								text11 = Conversions.ToString(dictionary["SENSORID"]);
								Sensor[] array2 = activeUnit.vmethod_96();
								int j = 0;
								while (j < array2.Length)
								{
									Sensor sensor3 = array2[j];
									if (Operators.CompareString(sensor3.string_0, text11, false) != 0)
									{
										j++;
									}
									else
									{
										sensor2 = sensor3;
										IL_13B9:
										if (sensor2 == null)
										{
											throw new Exception3("Can't find sensor " + text11);
										}
										goto IL_13EA;
									}
								}
								goto IL_13B9;
							}
							catch (Exception ex8)
							{
								throw new Exception3("Can't find sensor " + text11);
							}
							IL_13EA:
							try
							{
								activeUnit.method_127(sensor2);
								goto IL_1BFD;
							}
							catch (Exception ex9)
							{
								throw new Exception3("Unable to remove " + sensor2.Name);
							}
						}
						throw new Exception3("Sensor to remove not defined");
					}
					if (Operators.CompareString(text, "UPDATE_SENSOR_ARC", false) == 0)
					{
						if (dictionary.ContainsKey("SENSORID"))
						{
							string text12 = null;
							Sensor sensor4 = null;
							try
							{
								text12 = Conversions.ToString(dictionary["SENSORID"]);
								Sensor[] array3 = activeUnit.vmethod_96();
								int k = 0;
								while (k < array3.Length)
								{
									Sensor sensor5 = array3[k];
									if (Operators.CompareString(sensor5.string_0, text12, false) != 0)
									{
										k++;
									}
									else
									{
										sensor4 = sensor5;
										IL_1262:
										if (sensor4 == null)
										{
											throw new Exception3("Can't find sensor " + text12);
										}
										goto IL_1293;
									}
								}
								goto IL_1262;
							}
							catch (Exception ex10)
							{
								throw new Exception3("Can't find sensor " + text12);
							}
							IL_1293:
							try
							{
								if (@class.method_2() && !@class.Equals(sensor4.class295_0))
								{
									sensor4.class295_0 = @class;
								}
								if (class2.method_2() && !class2.Equals(sensor4.class295_1))
								{
									sensor4.class295_1 = class2;
								}
								goto IL_1BFD;
							}
							catch (Exception ex11)
							{
								throw new Exception3("Unable to update " + sensor4.Name);
							}
						}
						throw new Exception3("Sensor to update not defined");
					}
					goto IL_1BFD;
				}
				else
				{
					try
					{
						int int_ = num;
						SQLiteConnection sqliteConnection = activeUnit.scenario_0.method_39();
						Sensor sensor6 = DBFunctions.smethod_97(int_, ref sqliteConnection);
						if (sensor6 != null && @class != null && class2 != null)
						{
							if (@class.method_2() && !@class.Equals(sensor6.class295_0))
							{
								sensor6.class295_0 = @class;
							}
							if (class2.method_2() && !class2.Equals(sensor6.class295_1))
							{
								sensor6.class295_1 = class2;
							}
							sensor6.method_19(activeUnit);
							activeUnit.method_102(sensor6);
						}
						else
						{
							if (sensor6 == null)
							{
								throw new Exception3("Unknown sensor " + Conversions.ToString(num));
							}
							if (@class == null)
							{
								throw new Exception3("No detection arcs supplied for sensor " + sensor6.Name);
							}
							if (class2 == null)
							{
								throw new Exception3("No illumination arcs supplied for sensor " + sensor6.Name);
							}
						}
						goto IL_1BFD;
					}
					catch (Exception ex12)
					{
						throw;
					}
				}
				IL_14F0:
				if (num2 == 2528169845U)
				{
					goto IL_18FB;
				}
				if (num2 == 2811451306U)
				{
					goto IL_1755;
				}
				if (num2 != 4179568013U)
				{
					goto IL_1BFD;
				}
				if (Operators.CompareString(text, "ADD_WEAPON", false) != 0)
				{
					goto IL_1BFD;
				}
				IL_1527:
				Mount mount = null;
				if (dictionary.ContainsKey("MOUNTID"))
				{
					string text13 = null;
					try
					{
						text13 = Conversions.ToString(dictionary["MOUNTID"]);
						try
						{
							foreach (Mount mount2 in activeUnit.vmethod_51())
							{
								if (Operators.CompareString(mount2.string_0, text13, false) == 0)
								{
									mount = mount2;
									break;
								}
							}
						}
						finally
						{
							List<Mount>.Enumerator enumerator5;
							((IDisposable)enumerator5).Dispose();
						}
					}
					catch (Exception ex13)
					{
						throw new Exception3("Can't find weapon mount " + text13);
					}
					if (mount == null)
					{
						throw new Exception3("Can't find weapon mount " + text13);
					}
				}
				if (Operators.CompareString(text, "ADD_WEAPON", false) != 0)
				{
					if (Operators.CompareString(text, "REMOVE_WEAPON", false) == 0)
					{
						if (dictionary.ContainsKey("WEAPONID"))
						{
							string text14 = null;
							WeaponRec weaponRec = null;
							try
							{
								text14 = Conversions.ToString(dictionary["WEAPONID"]);
								try
								{
									foreach (WeaponRec weaponRec2 in mount.vmethod_10())
									{
										if (Operators.CompareString(weaponRec2.string_0, text14, false) == 0)
										{
											weaponRec = weaponRec2;
											break;
										}
									}
								}
								finally
								{
									List<WeaponRec>.Enumerator enumerator6;
									((IDisposable)enumerator6).Dispose();
								}
								if (weaponRec == null)
								{
									throw new Exception3("Can't find weapon " + text14 + " on mount " + mount.string_0);
								}
							}
							catch (Exception ex14)
							{
								throw new Exception3("Can't find weapon " + text14 + " on mount " + mount.string_0);
							}
							try
							{
								try
								{
									mount.vmethod_10().method_6(weaponRec);
								}
								catch (Exception ex15)
								{
									throw new Exception3("Unable to remove " + weaponRec.Name);
								}
								goto IL_1BFD;
							}
							catch (Exception ex16)
							{
								throw new Exception3("Unable to remove " + weaponRec.Name);
							}
						}
						throw new Exception3("mount to remove not defined");
					}
					goto IL_1BFD;
				}
				else
				{
					try
					{
						WeaponRec weaponRec3 = DBFunctions.smethod_59(num, scenario_0);
						if (weaponRec3 == null)
						{
							throw new Exception3("Unknown weapon record " + Conversions.ToString(num));
						}
						mount.vmethod_10().method_4(weaponRec3);
						goto IL_1BFD;
					}
					catch (Exception ex17)
					{
						throw new Exception3("Unknown weapon record " + Conversions.ToString(num));
					}
				}
				IL_1755:
				if (Operators.CompareString(text, "ADD_COMMS", false) != 0)
				{
					goto IL_1BFD;
				}
				IL_1766:
				if (Operators.CompareString(text, "ADD_COMMS", false) != 0)
				{
					if (Operators.CompareString(text, "REMOVE_COMMS", false) == 0)
					{
						if (!dictionary.ContainsKey("COMMSID") && num > 0)
						{
							foreach (CommDevice commDevice in activeUnit.vmethod_94())
							{
								if (commDevice.DBID == num)
								{
									dictionary["COMMSID"] = commDevice.string_0;
									break;
								}
							}
						}
						if (dictionary.ContainsKey("COMMSID"))
						{
							string text15 = null;
							CommDevice commDevice2 = null;
							try
							{
								text15 = Conversions.ToString(dictionary["COMMSID"]);
								CommDevice[] array5 = activeUnit.vmethod_94();
								int m = 0;
								while (m < array5.Length)
								{
									CommDevice commDevice3 = array5[m];
									if (Operators.CompareString(commDevice3.string_0, text15, false) != 0)
									{
										m++;
									}
									else
									{
										commDevice2 = commDevice3;
										IL_1840:
										if (commDevice2 == null)
										{
											throw new Exception3("Can't find comms " + text15);
										}
										goto IL_1871;
									}
								}
								goto IL_1840;
							}
							catch (Exception ex18)
							{
								throw new Exception3("Can't find comms " + text15);
							}
							IL_1871:
							try
							{
								activeUnit.method_125(commDevice2);
								goto IL_1BFD;
							}
							catch (Exception ex19)
							{
								throw new Exception3("Unable to remove " + commDevice2.Name);
							}
						}
						throw new Exception3("Comms to remove not defined");
					}
					goto IL_1BFD;
				}
				else
				{
					try
					{
						CommDevice commDevice4 = DBFunctions.smethod_95(num, ref activeUnit);
						if (commDevice4 == null)
						{
							throw new Exception3("Unknown comms " + Conversions.ToString(num));
						}
						commDevice4.method_19(activeUnit);
						activeUnit.method_101(commDevice4);
						goto IL_1BFD;
					}
					catch (Exception ex20)
					{
						throw new Exception3("Unknown comms " + Conversions.ToString(num));
					}
				}
				IL_18FB:
				if (Operators.CompareString(text, "UPDATE_MOUNT_ARC", false) != 0)
				{
					goto IL_1BFD;
				}
				IL_190C:
				if (Operators.CompareString(text, "ADD_MOUNT", false) != 0)
				{
					if (Operators.CompareString(text, "REMOVE_MOUNT", false) == 0)
					{
						if (!dictionary.ContainsKey("MOUNTID") && num > 0)
						{
							try
							{
								foreach (Mount mount3 in activeUnit.vmethod_51())
								{
									if (mount3.DBID == num)
									{
										dictionary["MOUNTID"] = mount3.string_0;
										break;
									}
								}
							}
							finally
							{
								List<Mount>.Enumerator enumerator7;
								((IDisposable)enumerator7).Dispose();
							}
						}
						if (dictionary.ContainsKey("MOUNTID"))
						{
							string text16 = null;
							Mount mount4 = null;
							try
							{
								text16 = Conversions.ToString(dictionary["MOUNTID"]);
								try
								{
									foreach (Mount mount5 in activeUnit.vmethod_51())
									{
										if (Operators.CompareString(mount5.string_0, text16, false) == 0)
										{
											mount4 = mount5;
											break;
										}
									}
								}
								finally
								{
									List<Mount>.Enumerator enumerator8;
									((IDisposable)enumerator8).Dispose();
								}
								if (mount4 == null)
								{
									throw new Exception3("Can't find mount " + text16);
								}
							}
							catch (Exception ex21)
							{
								throw new Exception3("Can't find mount " + text16);
							}
							try
							{
								activeUnit.vmethod_51().method_6(mount4);
								goto IL_1BFD;
							}
							catch (Exception ex22)
							{
								throw new Exception3("Unable to remove " + mount4.Name);
							}
						}
						throw new Exception3("mount to remove not defined");
					}
					if (Operators.CompareString(text, "UPDATE_MOUNT_ARC", false) == 0)
					{
						if (dictionary.ContainsKey("MOUNTID"))
						{
							string text17 = null;
							Mount mount6 = null;
							try
							{
								text17 = Conversions.ToString(dictionary["MOUNTID"]);
								try
								{
									foreach (Mount mount7 in activeUnit.vmethod_51())
									{
										if (Operators.CompareString(mount7.string_0, text17, false) == 0)
										{
											mount6 = mount7;
											break;
										}
									}
								}
								finally
								{
									List<Mount>.Enumerator enumerator9;
									((IDisposable)enumerator9).Dispose();
								}
								if (mount6 == null)
								{
									throw new Exception3("Can't find Mount " + text17);
								}
							}
							catch (Exception ex23)
							{
								throw new Exception3("Can't find mount " + text17);
							}
							try
							{
								if (class3.method_2() && !class3.Equals(mount6.class295_0))
								{
									mount6.class295_0 = class3;
								}
								goto IL_1BFD;
							}
							catch (Exception ex24)
							{
								throw new Exception3("Unable to update " + mount6.Name);
							}
						}
						throw new Exception3("Sensor to update not defined");
					}
				}
				else
				{
					try
					{
						Mount mount8 = DBFunctions.smethod_110(num, ref scenario_0, true);
						if (mount8 != null && class3 != null)
						{
							if (class3.method_2() && !class3.Equals(mount8.class295_0))
							{
								mount8.class295_0 = class3;
							}
							mount8.method_19(activeUnit);
							activeUnit.vmethod_51().method_4(mount8);
						}
						else
						{
							if (mount8 == null)
							{
								throw new Exception3("Unknown mount " + Conversions.ToString(num));
							}
							if (class3 == null)
							{
								throw new Exception3("No targeting arcs supplied for mount " + mount8.Name);
							}
						}
					}
					catch (Exception ex25)
					{
						throw;
					}
				}
				IL_1BFD:
				LuaUtility.smethod_3(dictionary, luaTable_0);
				return PrivateMethods.smethod_38(luaTable_0, scenario_0);
			}
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x002547A8 File Offset: 0x002529A8
		public static LuaWrapper_ActiveUnit_SE smethod_35(LuaTable luaTable_0, Scenario scenario_0)
		{
			ActiveUnit activeUnit = null;
			string text = null;
			int value = 0;
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			List<Tuple<string, int, Cargo>> list = new List<Tuple<string, int, Cargo>>();
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			LuaUtility.smethod_5(ref dictionary);
			if (dictionary.ContainsKey("GUID"))
			{
				string text2 = null;
				try
				{
					text2 = Conversions.ToString(dictionary["GUID"]);
					activeUnit = scenario_0.vmethod_0()[text2];
				}
				catch (Exception ex)
				{
					throw new Exception3("Can't find guid " + text2);
				}
			}
			if (dictionary.ContainsKey("MODE"))
			{
				try
				{
					text = Conversions.ToString(dictionary["MODE"]).ToUpper();
					if (Operators.CompareString(text, "ADD_CARGO", false) != 0 && Operators.CompareString(text, "REMOVE_CARGO", false) != 0)
					{
						throw new Exception3("function should be 'add_cargo', 'remove_cargo' ");
					}
				}
				catch (Exception ex2)
				{
					throw;
				}
			}
			if (dictionary.ContainsKey("DBID"))
			{
				try
				{
					value = Conversions.ToInteger(dictionary["DBID"]);
				}
				catch (Exception ex3)
				{
					throw new Exception3("Missing dbid");
				}
			}
			if (dictionary.ContainsKey("CARGO"))
			{
				try
				{
					luaTable = (LuaTable)dictionary["CARGO"];
				}
				catch (Exception ex4)
				{
					throw new Exception3("Error in cargo list");
				}
			}
			List<object> list2 = new List<object>();
			if (Information.IsNothing(luaTable))
			{
				throw new Exception3("Missing cargo list");
			}
			list2 = LuaUtility.smethod_0(luaTable.GetEnumerator());
			if (list2.Count == 0)
			{
				throw new Exception3("Missing cargo list");
			}
			try
			{
				foreach (object obj in list2)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					PrivateMethods.Class493 @class = new PrivateMethods.Class493(@class);
					@class.int_0 = 0;
					@class.string_0 = null;
					int num;
					if (objectValue is LuaTable)
					{
						List<object> list3 = LuaUtility.smethod_0(((LuaTable)objectValue).GetEnumerator());
						if (list3.Count == 1)
						{
							@class.int_0 = Conversions.ToInteger(list3[0]);
							num = 1;
						}
						else
						{
							@class.int_0 = Conversions.ToInteger(list3[1]);
							num = Conversions.ToInteger(list3[0]);
						}
					}
					else
					{
						@class.string_0 = Conversions.ToString(objectValue);
						num = 1;
					}
					if (num >= 1 && (@class.int_0 >= 1 || !Information.IsNothing(@class.string_0)))
					{
						IEnumerator<Cargo> enumerator2;
						if (Information.IsNothing(@class.string_0))
						{
							enumerator2 = Enumerable.Select<Cargo, Cargo>(Enumerable.Where<Cargo>(Enumerable.Where<Cargo>(activeUnit.cargo_0, (PrivateMethods._Closure$__.$I51-0 == null) ? (PrivateMethods._Closure$__.$I51-0 = new Func<Cargo, bool>(PrivateMethods._Closure$__.$I.method_4)) : PrivateMethods._Closure$__.$I51-0), new Func<Cargo, bool>(@class.method_0)), (PrivateMethods._Closure$__.$I51-2 == null) ? (PrivateMethods._Closure$__.$I51-2 = new Func<Cargo, Cargo>(PrivateMethods._Closure$__.$I.method_5)) : PrivateMethods._Closure$__.$I51-2).GetEnumerator();
						}
						else
						{
							enumerator2 = Enumerable.Select<Cargo, Cargo>(Enumerable.Where<Cargo>(activeUnit.cargo_0, new Func<Cargo, bool>(@class.method_1)), (PrivateMethods._Closure$__.$I51-4 == null) ? (PrivateMethods._Closure$__.$I51-4 = new Func<Cargo, Cargo>(PrivateMethods._Closure$__.$I.method_6)) : PrivateMethods._Closure$__.$I51-4).GetEnumerator();
						}
						for (int i = num; i > 0; i--)
						{
							if (!Information.IsNothing(@class.string_0))
							{
								if (Operators.CompareString(text, "REMOVE_CARGO", false) == 0)
								{
									list.Add(new Tuple<string, int, Cargo>(text, 1, enumerator2.Current));
								}
								i = 1;
							}
							else if (enumerator2.MoveNext() & Operators.CompareString(text, "REMOVE_CARGO", false) == 0)
							{
								list.Add(new Tuple<string, int, Cargo>(text, 1, enumerator2.Current));
							}
							else
							{
								list.Add(new Tuple<string, int, Cargo>(text, 1, new Cargo(activeUnit, DBFunctions.smethod_110(@class.int_0, ref activeUnit.scenario_0, true))));
							}
						}
					}
				}
			}
			finally
			{
				List<object>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (list.Count == 0)
			{
				throw new Exception3("No cargo list to action");
			}
			if (Operators.CompareString(text, "ADD_CARGO", false) != 0)
			{
				if (Operators.CompareString(text, "REMOVE_CARGO", false) != 0)
				{
					goto IL_6A6;
				}
				try
				{
					try
					{
						foreach (Tuple<string, int, Cargo> tuple in list)
						{
							Cargo item = tuple.Item3;
							for (int j = tuple.Item2; j > 0; j += -1)
							{
								if (Enumerable.Contains<Cargo>(activeUnit.cargo_0, item))
								{
									Class429.smethod_7(ref activeUnit.cargo_0, item);
								}
							}
						}
					}
					finally
					{
						List<Tuple<string, int, Cargo>>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					goto IL_6A6;
				}
				catch (Exception ex5)
				{
					throw new Exception3("Unknown cargo " + Conversions.ToString(value));
				}
			}
			try
			{
				double num2 = 0.0;
				double num3 = 0.0;
				double num4 = 0.0;
				CargoType cargoType = CargoType.NoCargo;
				switch (activeUnit.vmethod_56())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
				{
					Aircraft aircraft = (Aircraft)activeUnit;
					num2 = (double)aircraft.imethod_3();
					num3 = (double)aircraft.imethod_1();
					num4 = (double)aircraft.imethod_0();
					cargoType = aircraft.imethod_2();
					break;
				}
				case GlobalVariables.ActiveUnitType.Ship:
				case GlobalVariables.ActiveUnitType.Submarine:
				{
					Ship ship = (Ship)activeUnit;
					num2 = (double)ship.imethod_3();
					num3 = (double)ship.imethod_1();
					num4 = (double)ship.imethod_0();
					cargoType = ship.imethod_2();
					break;
				}
				case GlobalVariables.ActiveUnitType.Facility:
				{
					Facility facility = (Facility)activeUnit;
					num2 = (double)facility.imethod_3();
					num3 = (double)facility.imethod_1();
					num4 = (double)facility.imethod_0();
					cargoType = facility.imethod_2();
					break;
				}
				}
				foreach (Cargo cargo in activeUnit.cargo_0)
				{
					if (cargo.method_23() == Cargo.Enum111.const_1)
					{
						Mount mount = (Mount)cargo.method_25();
						if (mount.cargoType_0 <= cargoType)
						{
							num2 -= (double)mount.short_2;
							num3 -= (double)mount.short_1;
							num4 -= (double)mount.short_0;
						}
					}
				}
				try
				{
					foreach (Tuple<string, int, Cargo> tuple2 in list)
					{
						Cargo item2 = tuple2.Item3;
						int item3 = tuple2.Item2;
						if (item2.method_23() == Cargo.Enum111.const_1)
						{
							Mount mount2 = (Mount)item2.method_25();
							if (num2 >= (double)mount2.short_2 & num3 >= (double)mount2.short_1 & num4 >= (double)mount2.short_0)
							{
								num2 -= (double)mount2.short_2;
								num3 -= (double)mount2.short_1;
								num4 -= (double)mount2.short_0;
								Class429.smethod_6(ref activeUnit.cargo_0, item2);
							}
						}
						else if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
				}
				finally
				{
					List<Tuple<string, int, Cargo>>.Enumerator enumerator4;
					((IDisposable)enumerator4).Dispose();
				}
			}
			catch (Exception ex6)
			{
				throw new Exception3("Unknown cargo " + Conversions.ToString(value));
			}
			IL_6A6:
			LuaUtility.smethod_3(dictionary, luaTable_0);
			return PrivateMethods.smethod_38(luaTable_0, scenario_0);
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x00254F48 File Offset: 0x00253148
		public static LuaWrapper_ActiveUnit_SE smethod_36(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			LuaUtility.smethod_5(ref dictionary);
			if (dictionary.ContainsKey("GUID"))
			{
				string text;
				try
				{
					text = Conversions.ToString(dictionary["GUID"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.vmethod_0()[text];
					goto IL_1AA;
				}
				catch (Exception ex2)
				{
					throw new Exception3("Can't find guid " + text);
				}
			}
			if (dictionary.ContainsKey("UNITNAME"))
			{
				PrivateMethods.Class494 @class = new PrivateMethods.Class494();
				try
				{
					@class.string_0 = Conversions.ToString(dictionary["UNITNAME"]);
				}
				catch (Exception ex3)
				{
					throw new Exception3("name must be a string");
				}
				if (dictionary.ContainsKey("SIDE"))
				{
					string text2;
					try
					{
						text2 = Conversions.ToString(dictionary["SIDE"]);
					}
					catch (Exception ex4)
					{
						throw new Exception3("side must be a string");
					}
					Side side;
					try
					{
						side = LuaUtility.smethod_16(dictionary, scenario_0);
					}
					catch (Exception ex5)
					{
						throw new Exception3("Can't find Side '" + text2 + "'");
					}
					try
					{
						activeUnit = Enumerable.First<ActiveUnit>(side.activeUnit_0, new Func<ActiveUnit, bool>(@class.method_0));
						goto IL_1AA;
					}
					catch (Exception ex6)
					{
						throw new Exception3(string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text2,
							"'"
						}));
					}
				}
				try
				{
					activeUnit = Enumerable.First<ActiveUnit>(scenario_0.method_42(), new Func<ActiveUnit, bool>(@class.method_1));
				}
				catch (Exception ex7)
				{
					throw new Exception3("Can't find Unit '" + @class.string_0 + "'");
				}
			}
			IL_1AA:
			if (activeUnit == null)
			{
				throw new Exception3("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
			}
			return new LuaWrapper_ActiveUnit_SE(activeUnit, scenario_0);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x0025516C File Offset: 0x0025336C
		public static LuaWrapper_Contact smethod_37(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			Contact contact = null;
			Side side = null;
			string text = null;
			LuaUtility.smethod_5(ref dictionary);
			if (dictionary.ContainsKey("GUID"))
			{
				try
				{
					text = Conversions.ToString(dictionary["GUID"]);
					goto IL_7E;
				}
				catch (Exception ex)
				{
					throw new Exception3("guid must be a string");
				}
			}
			if (dictionary.ContainsKey("UNITNAME"))
			{
				try
				{
					text = Conversions.ToString(dictionary["UNITNAME"]);
				}
				catch (Exception ex2)
				{
					throw new Exception3("name must be a string");
				}
			}
			IL_7E:
			if (dictionary.ContainsKey("SIDE"))
			{
				string str;
				try
				{
					str = Conversions.ToString(dictionary["SIDE"]);
				}
				catch (Exception ex3)
				{
					throw new Exception3("side must be a string");
				}
				try
				{
					side = LuaUtility.smethod_16(dictionary, scenario_0);
				}
				catch (Exception ex4)
				{
					throw new Exception3("Can't find Side '" + str + "'");
				}
			}
			try
			{
				foreach (Contact contact2 in side.method_44())
				{
					if (Operators.CompareString(contact2.string_0.ToLower(), text.ToLower(), false) == 0 || Operators.CompareString(contact2.Name.ToLower(), text.ToLower(), false) == 0)
					{
						contact = contact2;
						break;
					}
				}
			}
			finally
			{
				List<Contact>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (Information.IsNothing(contact))
			{
				try
				{
					foreach (string text2 in side.lazy_0.Value.Keys)
					{
						Contact contact3 = side.lazy_0.Value[text2];
						if (Operators.CompareString(contact3.string_0.ToLower(), text.ToLower(), false) == 0 || Operators.CompareString(contact3.Name.ToLower(), text.ToLower(), false) == 0)
						{
							contact = contact3;
							break;
						}
					}
				}
				finally
				{
					IEnumerator<string> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
			}
			if (contact == null)
			{
				throw new Exception3("Need to define a Side and Guid to identify a contact.");
			}
			return new LuaWrapper_Contact(contact, scenario_0, side);
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x002553B4 File Offset: 0x002535B4
		public static LuaWrapper_ActiveUnit_SE smethod_38(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			Side side = null;
			string text = null;
			LuaUtility.smethod_5(ref dictionary);
			if (dictionary.ContainsKey("GUID"))
			{
				string key;
				try
				{
					key = Conversions.ToString(dictionary["GUID"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.vmethod_0()[key];
				}
				catch (Exception ex2)
				{
					return null;
				}
				if (activeUnit == null)
				{
					return null;
				}
				dictionary["SIDE"] = activeUnit.vmethod_7(false).method_51();
				dictionary["UNITNAME"] = activeUnit.Name;
			}
			else if (dictionary.ContainsKey("UNITNAME"))
			{
				PrivateMethods.Class495 @class = new PrivateMethods.Class495(@class);
				try
				{
					@class.string_0 = Conversions.ToString(dictionary["UNITNAME"]);
				}
				catch (Exception ex3)
				{
					throw new Exception3("name must be a string");
				}
				if (dictionary.ContainsKey("SIDE"))
				{
					string text2;
					try
					{
						text2 = Conversions.ToString(dictionary["SIDE"]);
					}
					catch (Exception ex4)
					{
						throw new Exception3("side must be a string");
					}
					try
					{
						side = LuaUtility.smethod_16(dictionary, scenario_0);
					}
					catch (Exception ex5)
					{
						throw new Exception3("Can't find Side '" + text2 + "'");
					}
					try
					{
						activeUnit = Enumerable.FirstOrDefault<ActiveUnit>(side.activeUnit_0, new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception ex6)
					{
						throw new Exception3(string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text2,
							"'"
						}));
					}
					dictionary["GUID"] = activeUnit.string_0;
				}
				else
				{
					try
					{
						activeUnit = Enumerable.FirstOrDefault<ActiveUnit>(scenario_0.method_42(), new Func<ActiveUnit, bool>(@class.method_1));
					}
					catch (Exception ex7)
					{
						throw new Exception3("Can't find Unit '" + @class.string_0 + "'");
					}
					dictionary["GUID"] = activeUnit.string_0;
					dictionary["SIDE"] = activeUnit.vmethod_7(false).method_51();
				}
			}
			if (activeUnit == null)
			{
				throw new Exception3("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
			}
			if (side == null)
			{
				side = LuaUtility.smethod_16(dictionary, scenario_0);
			}
			dictionary["TYPE"] = activeUnit.vmethod_56().ToString();
			if (dictionary.ContainsKey("NEWNAME"))
			{
				string text3 = Conversions.ToString(dictionary["NEWNAME"]);
				if (Operators.CompareString(activeUnit.Name, text3, false) != 0)
				{
					activeUnit.Name = text3;
				}
			}
			if (dictionary.ContainsKey("GROUP"))
			{
				Group group = LuaUtility.smethod_27(dictionary, side, scenario_0);
				if (group != activeUnit.vmethod_65(false))
				{
					activeUnit.vmethod_66(false, group);
				}
			}
			else if (activeUnit.vmethod_65(false) != null)
			{
				dictionary["GROUP"] = activeUnit.vmethod_65(false).Name;
			}
			if (dictionary.ContainsKey("MISSION"))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(dictionary["MISSION"]);
				if (!(objectValue is string))
				{
					goto IL_36C;
				}
				try
				{
					PrivateMethods.smethod_12(activeUnit.string_0, Conversions.ToString(objectValue), scenario_0, null, false, false);
					goto IL_36C;
				}
				catch (Exception ex8)
				{
					throw new Exception3(ex8.GetType().Name + " " + ex8.Message);
				}
			}
			if (activeUnit.vmethod_101() != null)
			{
				dictionary["MISSION"] = activeUnit.vmethod_101().Name;
			}
			IL_36C:
			if (dictionary.ContainsKey("COURSE"))
			{
				LuaTable luaTable = (LuaTable)dictionary["COURSE"];
				activeUnit.vmethod_85().vmethod_9();
				List<object> list = LuaUtility.smethod_0(luaTable.GetEnumerator());
				try
				{
					foreach (object obj in list)
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(obj);
						if (!(objectValue2 is LuaTable))
						{
							throw new Exception3("Error at " + LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(objectValue2)) + " in ScenEdit_SetUnit.");
						}
						Dictionary<string, object> dictionary_ = LuaUtility.smethod_1(((LuaTable)objectValue2).GetEnumerator());
						double? num = LuaUtility.smethod_13(dictionary_);
						double? num2 = LuaUtility.smethod_11(dictionary_);
						if (num == null | num == null)
						{
							throw new Exception3("Course object " + LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(objectValue2)) + " needs latitude or longitude.");
						}
						double? num3 = num;
						bool? flag = (num3 != null) ? new bool?(num3.GetValueOrDefault() == 0.0) : null;
						num3 = num;
						bool? flag2 = (num3 != null) ? new bool?(num3.GetValueOrDefault() == 0.0) : null;
						if (((flag == null || !flag.GetValueOrDefault()) ? ((flag2 != null) ? (flag | flag2.GetValueOrDefault()) : null) : new bool?(true)).GetValueOrDefault())
						{
							throw new Exception3("Course object " + LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(objectValue2)) + " Latitude or Longitude cannot be 0.");
						}
						activeUnit.vmethod_85().vmethod_24(num2.Value, num.Value, 0f, Waypoint.WaypointType.ManualPlottedCourseWaypoint, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0);
					}
				}
				finally
				{
					List<object>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (dictionary.ContainsKey("SPEED") & dictionary.ContainsKey("THROTTLE"))
			{
				throw new Exception3("Use either SPEED or THROTTLE.");
			}
			if (dictionary.ContainsKey("SPEED"))
			{
				float num4 = Conversions.ToSingle(dictionary["SPEED"]);
				if (num4 > (float)activeUnit.vmethod_87().vmethod_40(activeUnit.vmethod_14(false), activeUnit.vmethod_82(), false))
				{
					num4 = (float)activeUnit.vmethod_87().vmethod_40(activeUnit.vmethod_14(false), activeUnit.vmethod_82(), false);
				}
				else if (num4 < 0f)
				{
					num4 = 0f;
				}
				activeUnit.vmethod_41(num4);
			}
			else
			{
				dictionary["SPEED"] = activeUnit.vmethod_40();
			}
			if (dictionary.ContainsKey("THROTTLE"))
			{
				ActiveUnit.Throttle throttle = LuaUtility.smethod_24(dictionary);
				if (throttle > activeUnit.vmethod_82())
				{
					throttle = activeUnit.vmethod_82();
				}
				else if (throttle < activeUnit.vmethod_83())
				{
					throttle = activeUnit.vmethod_83();
				}
				activeUnit.vmethod_134(throttle, null);
			}
			else
			{
				dictionary["THROTTLE"] = activeUnit.vmethod_84();
			}
			if (dictionary.ContainsKey("LAUNCH"))
			{
				if (LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["LAUNCH"])).GetValueOrDefault())
				{
					if (activeUnit.bool_3)
					{
						Aircraft aircraft = (Aircraft)activeUnit;
						if (activeUnit.vmethod_92() != null && aircraft.method_175())
						{
							aircraft.method_164().method_37(Aircraft_AirOps._AirOpsCondition.PreparingToLaunch);
							aircraft.method_164().method_70();
						}
					}
					else if (activeUnit.vmethod_93() != null && activeUnit.vmethod_123())
					{
						activeUnit.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
					}
				}
				else if (activeUnit.bool_3)
				{
					if (activeUnit.vmethod_92() != null)
					{
						Aircraft aircraft2 = (Aircraft)activeUnit;
						if (aircraft2.method_164().method_22())
						{
							aircraft2.method_164().method_48(true, false, true);
							if (aircraft2.method_157().method_48())
							{
								aircraft2.method_157().method_7().method_11(scenario_0, Mission.Enum102.const_0);
							}
						}
					}
				}
				else if (activeUnit.vmethod_93() != null && activeUnit.vmethod_93().method_51())
				{
					activeUnit.vmethod_93().method_48(activeUnit.vmethod_93().method_17(), true);
				}
			}
			if (dictionary.ContainsKey("RTB"))
			{
				if (LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["RTB"])).GetValueOrDefault())
				{
					if (activeUnit.bool_3)
					{
						((Aircraft)activeUnit).method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
					}
					else
					{
						activeUnit.vmethod_93().method_5(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
					}
				}
				else
				{
					activeUnit.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
				}
			}
			if (dictionary.ContainsKey("REFUEL") && LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["REFUEL"])).GetValueOrDefault() && !Information.IsNothing(activeUnit) && activeUnit.bool_0 && (activeUnit.vmethod_7(false) == side || activeUnit.vmethod_7(false).method_67(side)) && activeUnit.GetType() != typeof(Weapon))
			{
				ActiveUnit theU = activeUnit;
				Scenario scenarioContext = scenario_0;
				ActiveUnit activeUnit2 = null;
				List<Mission> list2 = null;
				PrivateMethods.smethod_71(theU, scenarioContext, ref text, ref activeUnit2, ref list2);
			}
			dictionary["DBID"] = activeUnit.DBID;
			bool? flag3 = new bool?(false);
			if (dictionary.ContainsKey("MOVETO"))
			{
				flag3 = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["MOVETO"]));
			}
			GlobalVariables.ActiveUnitType activeUnitType = activeUnit.vmethod_56();
			if (activeUnitType != GlobalVariables.ActiveUnitType.Aircraft)
			{
				if (activeUnitType == GlobalVariables.ActiveUnitType.Submarine)
				{
					float? num5 = LuaUtility.smethod_23(dictionary);
					if (num5 != null)
					{
						float num6 = (float)((int)Math.Round((double)num5.Value));
						if (num6 > 0f & num6 <= 6f)
						{
							float num7 = num6;
							float num8;
							if (num7 == 6f)
							{
								num8 = 0f;
							}
							else if (num7 == 1f)
							{
								num8 = -20f;
							}
							else if (num7 == 2f)
							{
								num8 = -40f;
							}
							else if (num7 == 3f)
							{
								num8 = Submarine_AI.smethod_2(activeUnit);
							}
							else if (num7 == 4f)
							{
								num8 = Submarine_AI.smethod_3(activeUnit);
							}
							else if (num7 == 5f)
							{
								num8 = activeUnit.vmethod_87().vmethod_31();
							}
							num6 = num8;
						}
						if (num6 < activeUnit.vmethod_87().vmethod_31())
						{
							num6 = activeUnit.vmethod_87().vmethod_31();
						}
						if (num6 > 0f)
						{
							num6 = 0f;
						}
						if (flag3.GetValueOrDefault())
						{
							activeUnit.vmethod_73((float)((short)Math.Round((double)num6)));
						}
						else
						{
							activeUnit.vmethod_15(true, (float)((short)Math.Round((double)num6)));
						}
					}
					else
					{
						dictionary["DEPTH"] = activeUnit.vmethod_14(true);
					}
				}
			}
			else
			{
				dictionary["LOADOUTID"] = ((Aircraft)activeUnit).method_166();
				dictionary["LOADOUTNAME"] = ((Aircraft)activeUnit).method_165();
				float? num9 = LuaUtility.smethod_20(dictionary);
				if (num9 != null)
				{
					float num10 = (float)((int)Math.Round((double)num9.Value));
					if (num10 > 0f & num10 <= 7f)
					{
						((Aircraft)activeUnit).method_158();
						float num11 = num10;
						float num12;
						if (num11 == 1f)
						{
							num12 = activeUnit.vmethod_87().vmethod_31();
						}
						else if (num11 == 2f)
						{
							num12 = 304.8f;
						}
						else if (num11 == 3f)
						{
							num12 = 609.6f;
						}
						else if (num11 == 4f)
						{
							num12 = 3657.6f;
						}
						else if (num11 == 5f)
						{
							num12 = 7620f;
						}
						else if (num11 == 6f)
						{
							num12 = 10972.8f;
						}
						else if (num11 == 7f)
						{
							num12 = activeUnit.vmethod_87().vmethod_30();
						}
						num10 = num12;
					}
					if (num10 < activeUnit.vmethod_87().vmethod_31())
					{
						num10 = activeUnit.vmethod_87().vmethod_31();
					}
					if (num10 > activeUnit.vmethod_87().vmethod_30())
					{
						num10 = activeUnit.vmethod_87().vmethod_30();
					}
					if (flag3.GetValueOrDefault())
					{
						activeUnit.vmethod_73((float)((short)Math.Round((double)num10)));
					}
					else
					{
						activeUnit.vmethod_15(true, (float)((short)Math.Round((double)num10)));
					}
				}
				else
				{
					dictionary["ALTITUDE"] = activeUnit.vmethod_14(true);
				}
			}
			if (dictionary.ContainsKey("HEADING"))
			{
				float float_ = Conversions.ToSingle(dictionary["HEADING"]);
				activeUnit.vmethod_10(float_);
			}
			else
			{
				dictionary["HEADING"] = activeUnit.vmethod_9();
			}
			if (dictionary.ContainsKey("DESIREDHEADING"))
			{
				float float_2 = Conversions.ToSingle(dictionary["DESIREDHEADING"]);
				activeUnit.vmethod_69(ActiveUnit.Enum28.const_0, float_2);
			}
			else
			{
				dictionary["DESIREDHEADING"] = activeUnit.vmethod_68();
			}
			double? num13 = LuaUtility.smethod_11(dictionary);
			if (num13 != null)
			{
				activeUnit.vmethod_31(null, num13.Value);
			}
			else
			{
				dictionary["LONGITUDE"] = activeUnit.vmethod_28(null);
			}
			double? num14 = LuaUtility.smethod_13(dictionary);
			if (num14 != null)
			{
				activeUnit.vmethod_29(null, num14.Value);
			}
			else
			{
				dictionary["LONGITUDE"] = activeUnit.vmethod_28(null);
			}
			if (dictionary.ContainsKey("AUTODETECTABLE"))
			{
				bool? flag4 = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["AUTODETECTABLE"]));
				if (flag4 != null)
				{
					if (flag4.Value)
					{
						if (!activeUnit.method_92(null))
						{
							activeUnit.method_93(null, true);
							Contact contact = null;
							foreach (Side side2 in scenario_0.method_44())
							{
								if (side2 != activeUnit.vmethod_7(false))
								{
									ActiveUnit_Sensory.smethod_5(ref contact, ref scenario_0, side2, activeUnit, ActiveUnit_Sensory.Enum35.const_4, null, Contact_Base.IdentificationStatus.KnownDomain, null);
								}
							}
						}
					}
					else
					{
						activeUnit.method_93(null, false);
					}
				}
			}
			if (scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_5) && dictionary.ContainsKey("OUTOFCOMMS"))
			{
				bool? flag5 = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["OUTOFCOMMS"]));
				if (flag5 != null)
				{
					if (flag5.Value)
					{
						activeUnit.vmethod_90().method_1(ActiveUnit_CommStuff.Enum31.const_1, false);
					}
					else
					{
						activeUnit.vmethod_90().method_1(ActiveUnit_CommStuff.Enum31.const_0, true);
					}
				}
			}
			if (dictionary.ContainsKey("HOLDPOSITION"))
			{
				bool? flag6 = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["HOLDPOSITION"]));
				if (flag6 != null)
				{
					activeUnit.vmethod_86().bool_4 = flag6.Value;
				}
			}
			if (dictionary.ContainsKey("HOLDFIRE"))
			{
				bool? flag7 = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["HOLDFIRE"]));
				if (flag7 != null)
				{
					if (flag7.GetValueOrDefault())
					{
						activeUnit.doctrine_0.method_64(scenario_0, false, new bool?(false), false, false, new Doctrine.Enum52?(Doctrine.Enum52.const_2));
						activeUnit.doctrine_0.method_69(scenario_0, false, new bool?(false), false, false, new Doctrine.Enum52?(Doctrine.Enum52.const_2));
						activeUnit.doctrine_0.method_74(scenario_0, false, new bool?(false), false, false, new Doctrine.Enum52?(Doctrine.Enum52.const_2));
						activeUnit.doctrine_0.method_79(scenario_0, false, new bool?(false), false, false, new Doctrine.Enum52?(Doctrine.Enum52.const_2));
					}
					else
					{
						activeUnit.doctrine_0.method_64(scenario_0, false, new bool?(false), false, false, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
						activeUnit.doctrine_0.method_69(scenario_0, false, new bool?(false), false, false, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
						activeUnit.doctrine_0.method_74(scenario_0, false, new bool?(false), false, false, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
						activeUnit.doctrine_0.method_79(scenario_0, false, new bool?(false), false, false, new Doctrine.Enum52?(Doctrine.Enum52.const_1));
					}
				}
			}
			if (dictionary.ContainsKey("PROFICIENCY"))
			{
				string text4 = Conversions.ToString(dictionary["PROFICIENCY"]);
				GlobalVariables.ProficiencyLevel proficiencyLevel;
				if (Enum.TryParse<GlobalVariables.ProficiencyLevel>(text4, true, out proficiencyLevel) & Enum.IsDefined(typeof(GlobalVariables.ProficiencyLevel), proficiencyLevel))
				{
					activeUnit.vmethod_54(new GlobalVariables.ProficiencyLevel?(proficiencyLevel));
				}
				else
				{
					text4 = text4.ToUpper();
					if (Operators.CompareString(text4, "NOVICE", false) != 0)
					{
						if (Operators.CompareString(text4, "CADET", false) != 0)
						{
							if (Operators.CompareString(text4, "REGULAR", false) != 0)
							{
								if (Operators.CompareString(text4, "VETERAN", false) != 0)
								{
									if (Operators.CompareString(text4, "ACE", false) != 0)
									{
										throw new Exception3("Unable to understand '" + text4 + "' as a Proficiency Level");
									}
									activeUnit.vmethod_54(new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Ace));
								}
								else
								{
									activeUnit.vmethod_54(new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Veteran));
								}
							}
							else
							{
								activeUnit.vmethod_54(new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Regular));
							}
						}
						else
						{
							activeUnit.vmethod_54(new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Cadet));
						}
					}
					else
					{
						activeUnit.vmethod_54(new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Novice));
					}
				}
			}
			if (dictionary.ContainsKey("MANUALTHROTTLE"))
			{
				string text5 = Conversions.ToString(dictionary["MANUALTHROTTLE"]).ToUpper();
				if (Operators.CompareString(text5, "CURRENT", false) == 0)
				{
					float value = activeUnit.vmethod_40();
					activeUnit.vmethod_87().vmethod_11(new float?(value));
				}
				else if (Operators.CompareString(text5, "DESIRED", false) == 0)
				{
					float value = activeUnit.vmethod_70();
					activeUnit.vmethod_87().vmethod_11(new float?(value));
				}
				else if (Operators.CompareString(text5, "OFF", false) == 0)
				{
					activeUnit.vmethod_87().vmethod_11(null);
				}
				else
				{
					text5 = Conversions.ToString(dictionary["MANUALTHROTTLE"]);
					ActiveUnit_Kinematics.UnitThrottlePreset unitThrottlePreset;
					if (Enum.TryParse<ActiveUnit_Kinematics.UnitThrottlePreset>(text5, true, out unitThrottlePreset) && Enum.IsDefined(typeof(ActiveUnit_Kinematics.UnitThrottlePreset), unitThrottlePreset))
					{
						activeUnit.vmethod_87().vmethod_2(unitThrottlePreset);
						activeUnit.vmethod_87().vmethod_11(new float?((float)activeUnit.vmethod_87().vmethod_40(activeUnit.vmethod_14(false), (ActiveUnit.Throttle)activeUnit.vmethod_87().vmethod_1(), false)));
					}
				}
			}
			if (dictionary.ContainsKey("MANUALSPEED"))
			{
				string left = Conversions.ToString(dictionary["MANUALSPEED"]).ToUpper();
				if (Operators.CompareString(left, "CURRENT", false) == 0)
				{
					float value2 = activeUnit.vmethod_40();
					activeUnit.vmethod_87().vmethod_11(new float?(value2));
				}
				else if (Operators.CompareString(left, "DESIRED", false) == 0)
				{
					float value2 = activeUnit.vmethod_70();
					activeUnit.vmethod_87().vmethod_11(new float?(value2));
				}
				else if (Operators.CompareString(left, "OFF", false) == 0)
				{
					activeUnit.vmethod_87().vmethod_11(null);
				}
				else
				{
					float? num15 = null;
					try
					{
						num15 = new float?(float.Parse(Conversions.ToString(dictionary["MANUALSPEED"])));
					}
					catch (Exception ex9)
					{
					}
					if (num15 != null)
					{
						activeUnit.vmethod_87().vmethod_11(new float?(num15.Value));
						activeUnit.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.None);
					}
				}
				float? num16 = activeUnit.vmethod_87().vmethod_10();
				if (num16 != null)
				{
					activeUnit.vmethod_134(activeUnit.vmethod_87().vmethod_41(activeUnit.vmethod_14(false), num16.Value), null);
					float? num17 = num16;
					float num18 = (float)activeUnit.vmethod_87().vmethod_40(activeUnit.vmethod_14(false), activeUnit.vmethod_84(), false);
					if (((num17 != null) ? new bool?(num17.GetValueOrDefault() > num18) : null).GetValueOrDefault())
					{
						activeUnit.vmethod_87().vmethod_11(new float?((float)activeUnit.vmethod_87().vmethod_40(activeUnit.vmethod_14(false), activeUnit.vmethod_84(), false)));
					}
				}
			}
			if (dictionary.ContainsKey("MANUALALTITUDE"))
			{
				string left2 = Conversions.ToString(dictionary["MANUALALTITUDE"]).ToUpper();
				if (Operators.CompareString(left2, "CURRENT", false) == 0)
				{
					activeUnit.vmethod_14(false);
					activeUnit.vmethod_87().vmethod_13(true);
				}
				else if (Operators.CompareString(left2, "DESIRED", false) == 0)
				{
					activeUnit.vmethod_72();
					activeUnit.vmethod_87().vmethod_13(true);
				}
				else if (Operators.CompareString(left2, "OFF", false) == 0)
				{
					activeUnit.vmethod_87().vmethod_13(false);
				}
				else if (activeUnit.bool_5)
				{
					ActiveUnit_AI.SubmarineDepthPreset? submarineDepthPreset = LuaUtility.smethod_21(Conversions.ToString(dictionary["MANUALALTITUDE"]));
					if (submarineDepthPreset != null)
					{
						((Submarine)activeUnit).method_153().method_115(submarineDepthPreset.Value);
						((Submarine)activeUnit).method_153().vmethod_27();
						activeUnit.vmethod_87().vmethod_13(true);
					}
					else
					{
						activeUnit.vmethod_73(LuaUtility.smethod_22(Conversions.ToString(dictionary["MANUALALTITUDE"])).Value);
						((Submarine)activeUnit).method_153().method_115(ActiveUnit_AI.SubmarineDepthPreset.None);
						activeUnit.vmethod_87().vmethod_13(true);
					}
				}
				else if (activeUnit.bool_3)
				{
					ActiveUnit_AI.AircraftAltitudePreset? aircraftAltitudePreset = LuaUtility.smethod_18(Conversions.ToString(dictionary["MANUALALTITUDE"]));
					if (aircraftAltitudePreset != null)
					{
						((Aircraft)activeUnit).method_158().method_115(aircraftAltitudePreset.Value);
						((Aircraft)activeUnit).method_158().vmethod_27();
						activeUnit.vmethod_87().vmethod_13(true);
					}
					else
					{
						activeUnit.vmethod_73(LuaUtility.smethod_19(Conversions.ToString(dictionary["MANUALALTITUDE"])).Value);
						((Aircraft)activeUnit).method_158().method_115(ActiveUnit_AI.AircraftAltitudePreset.None);
						activeUnit.vmethod_87().vmethod_13(true);
					}
				}
				else
				{
					float float_3 = 0f;
					if (float.TryParse(Conversions.ToString(dictionary["MANUALALTITUDE"]), out float_3))
					{
						activeUnit.vmethod_73(float_3);
						activeUnit.vmethod_87().vmethod_13(true);
						if (activeUnit.bool_5)
						{
							((Submarine)activeUnit).method_153().method_115(ActiveUnit_AI.SubmarineDepthPreset.None);
						}
						else if (activeUnit.bool_3)
						{
							((Aircraft)activeUnit).method_158().method_115(ActiveUnit_AI.AircraftAltitudePreset.None);
						}
					}
				}
			}
			if (dictionary.ContainsKey("FUEL"))
			{
				List<object> list3 = LuaUtility.smethod_0(((LuaTable)dictionary["FUEL"]).GetEnumerator());
				try
				{
					try
					{
						foreach (object obj2 in list3)
						{
							object objectValue3 = RuntimeHelpers.GetObjectValue(obj2);
							if (objectValue3 is LuaTable)
							{
								Dictionary<string, object> dictionary2 = LuaUtility.smethod_1(((LuaTable)objectValue3).GetEnumerator());
								if (!(dictionary2.ContainsKey("1") & dictionary2.ContainsKey("2")))
								{
									throw new Exception3("Error at " + LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(objectValue3)) + " in ScenEdit_SetUnit.");
								}
								string value3 = Conversions.ToString(dictionary2["1"]);
								int maxValue = int.MaxValue;
								if (!int.TryParse(Conversions.ToString(dictionary2["2"]), out maxValue))
								{
									throw new Exception3("Error in amount at " + LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(objectValue3)) + " in ScenEdit_SetUnit.");
								}
								PrivateMethods.Class496 class2 = new PrivateMethods.Class496(class2);
								if (!(Enum.TryParse<FuelRec._FuelType>(value3, true, out class2._FuelType_0) & Enum.IsDefined(typeof(FuelRec._FuelType), class2._FuelType_0)))
								{
									throw new Exception3("Error in fuel type at " + LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(objectValue3)) + " in ScenEdit_SetUnit.");
								}
								if (Enumerable.FirstOrDefault<FuelRec>(activeUnit.vmethod_67(), new Func<FuelRec, bool>(class2.method_0)) == null)
								{
									throw new Exception3("Missing fuel type at " + LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(objectValue3)) + " in ScenEdit_SetUnit.");
								}
								int num19 = maxValue;
								foreach (FuelRec fuelRec in activeUnit.vmethod_67())
								{
									if (fuelRec._FuelType_0 == class2._FuelType_0)
									{
										int num20 = Math.Min(fuelRec.int_0, num19);
										num20 = Math.Max(0, num20);
										fuelRec.float_0 = (float)num20;
										num19 -= num20;
									}
								}
							}
						}
					}
					finally
					{
						List<object>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				catch (Exception ex10)
				{
					throw;
				}
			}
			if (dictionary.ContainsKey("BASE"))
			{
				string text6 = Conversions.ToString(dictionary["BASE"]);
				ActiveUnit activeUnit3 = null;
				if (Operators.CompareString(text6, "", false) != 0)
				{
					activeUnit3 = PrivateMethods.smethod_67(text6, scenario_0);
				}
				if (!Information.IsNothing(activeUnit3))
				{
					if (activeUnit.bool_3)
					{
						if (activeUnit.vmethod_92() != null)
						{
							Aircraft_AirOps aircraft_AirOps = (Aircraft_AirOps)activeUnit.vmethod_92();
							if (Operators.CompareString(aircraft_AirOps.method_26(activeUnit3), "OK", false) == 0)
							{
								aircraft_AirOps.method_33(false, activeUnit3);
							}
						}
					}
					else if (activeUnit.vmethod_93() != null)
					{
						ActiveUnit_DockingOps activeUnit_DockingOps = activeUnit.vmethod_93();
						if (Operators.CompareString(activeUnit_DockingOps.method_45(activeUnit3), "OK", false) == 0)
						{
							activeUnit_DockingOps.method_12(false, activeUnit3);
						}
					}
				}
				else if (Information.IsNothing(activeUnit3) && Operators.CompareString(text6, "", false) == 0)
				{
					if (activeUnit.bool_3)
					{
						if (activeUnit.vmethod_92() != null)
						{
							((Aircraft_AirOps)activeUnit.vmethod_92()).method_28();
						}
					}
					else if (activeUnit.vmethod_93() != null)
					{
						activeUnit.vmethod_93().method_44();
					}
				}
			}
			if (dictionary.ContainsKey("SPRINTDRIFT"))
			{
				bool? flag8 = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["SPRINTDRIFT"]));
				if (flag8 == null)
				{
					dictionary.Remove("SPRINTDRIFT");
				}
				else
				{
					activeUnit.vmethod_85().vmethod_4(flag8.Value);
				}
			}
			LuaUtility.smethod_3(dictionary, luaTable_0);
			return new LuaWrapper_ActiveUnit_SE(activeUnit, scenario_0);
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x00256D98 File Offset: 0x00254F98
		public static bool smethod_39(LuaTable luaTable_0, bool bool_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			LuaUtility.smethod_5(ref dictionary);
			if (dictionary.ContainsKey("GUID"))
			{
				string text;
				try
				{
					text = Conversions.ToString(dictionary["GUID"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.vmethod_0()[text];
				}
				catch (Exception ex2)
				{
					throw new Exception3("Can't find guid " + text);
				}
				dictionary["SIDE"] = activeUnit.vmethod_7(false).method_51();
				dictionary["UNITNAME"] = activeUnit.Name;
			}
			else if (dictionary.ContainsKey("UNITNAME"))
			{
				PrivateMethods.Class497 @class = new PrivateMethods.Class497(@class);
				try
				{
					@class.string_0 = Conversions.ToString(dictionary["UNITNAME"]);
				}
				catch (Exception ex3)
				{
					throw new Exception3("name must be a string");
				}
				if (dictionary.ContainsKey("SIDE"))
				{
					string text2;
					try
					{
						text2 = Conversions.ToString(dictionary["SIDE"]);
					}
					catch (Exception ex4)
					{
						throw new Exception3("side must be a string");
					}
					Side side;
					try
					{
						side = LuaUtility.smethod_16(dictionary, scenario_0);
					}
					catch (Exception ex5)
					{
						throw new Exception3("Can't find Side '" + text2 + "'");
					}
					try
					{
						activeUnit = Enumerable.First<ActiveUnit>(side.activeUnit_0, new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception ex6)
					{
						throw new Exception3(string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text2,
							"'"
						}));
					}
					dictionary["GUID"] = activeUnit.string_0;
				}
				else
				{
					try
					{
						activeUnit = Enumerable.First<ActiveUnit>(scenario_0.method_42(), new Func<ActiveUnit, bool>(@class.method_1));
					}
					catch (Exception ex7)
					{
						throw new Exception3("Can't find Unit '" + @class.string_0 + "'");
					}
					dictionary["GUID"] = activeUnit.string_0;
					dictionary["SIDE"] = activeUnit.vmethod_7(false).method_51();
				}
			}
			if (activeUnit == null)
			{
				throw new Exception3("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
			}
			if (scenario_0.ExecutionInProgress)
			{
				if (activeUnit.bool_1 && bool_0)
				{
					List<ActiveUnit> list = new List<ActiveUnit>();
					list.AddRange(((Group)activeUnit).vmethod_141().Values);
					try
					{
						foreach (ActiveUnit activeUnit_ in list)
						{
							scenario_0.method_64(activeUnit_);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				scenario_0.method_64(activeUnit);
			}
			else
			{
				if (activeUnit.bool_1 && bool_0)
				{
					List<ActiveUnit> list2 = new List<ActiveUnit>();
					list2.AddRange(((Group)activeUnit).vmethod_141().Values);
					try
					{
						foreach (ActiveUnit activeUnit2 in list2)
						{
							scenario_0.method_66(activeUnit2.string_0, true);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				scenario_0.method_66(activeUnit.string_0, true);
			}
			return true;
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00257114 File Offset: 0x00255314
		public static bool smethod_40(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			LuaUtility.smethod_5(ref dictionary);
			if (dictionary.ContainsKey("GUID"))
			{
				string text;
				try
				{
					text = Conversions.ToString(dictionary["GUID"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.vmethod_0()[text];
				}
				catch (Exception ex2)
				{
					throw new Exception3("Can't find guid " + text);
				}
				dictionary["SIDE"] = activeUnit.vmethod_7(false).method_51();
				dictionary["UNITNAME"] = activeUnit.Name;
			}
			else if (dictionary.ContainsKey("UNITNAME"))
			{
				PrivateMethods.Class498 @class = new PrivateMethods.Class498();
				try
				{
					@class.string_0 = Conversions.ToString(dictionary["UNITNAME"]);
				}
				catch (Exception ex3)
				{
					throw new Exception3("name must be a string");
				}
				if (dictionary.ContainsKey("SIDE"))
				{
					string text2;
					try
					{
						text2 = Conversions.ToString(dictionary["SIDE"]);
					}
					catch (Exception ex4)
					{
						throw new Exception3("side must be a string");
					}
					Side side;
					try
					{
						side = LuaUtility.smethod_16(dictionary, scenario_0);
					}
					catch (Exception ex5)
					{
						throw new Exception3("Can't find Side '" + text2 + "'");
					}
					try
					{
						activeUnit = Enumerable.First<ActiveUnit>(side.activeUnit_0, new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception ex6)
					{
						throw new Exception3(string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text2,
							"'"
						}));
					}
					dictionary["GUID"] = activeUnit.string_0;
				}
				else
				{
					try
					{
						activeUnit = Enumerable.First<ActiveUnit>(scenario_0.method_42(), new Func<ActiveUnit, bool>(@class.method_1));
					}
					catch (Exception ex7)
					{
						throw new Exception3("Can't find Unit '" + @class.string_0 + "'");
					}
					dictionary["GUID"] = activeUnit.string_0;
					dictionary["SIDE"] = activeUnit.vmethod_7(false).method_51();
				}
			}
			if (activeUnit == null)
			{
				throw new Exception3("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
			}
			scenario_0.method_65(activeUnit);
			return true;
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x002573A0 File Offset: 0x002555A0
		public static bool smethod_41(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			LuaUtility.smethod_5(ref dictionary);
			if (dictionary.ContainsKey("GUID"))
			{
				string text;
				try
				{
					text = Conversions.ToString(dictionary["GUID"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.vmethod_0()[text];
				}
				catch (Exception ex2)
				{
					throw new Exception3("Can't find guid " + text);
				}
				dictionary["SIDE"] = activeUnit.vmethod_7(false).method_51();
				dictionary["UNITNAME"] = activeUnit.Name;
			}
			else if (dictionary.ContainsKey("UNITNAME"))
			{
				PrivateMethods.Class499 @class = new PrivateMethods.Class499(@class);
				try
				{
					@class.string_0 = Conversions.ToString(dictionary["UNITNAME"]);
				}
				catch (Exception ex3)
				{
					throw new Exception3("name must be a string");
				}
				if (dictionary.ContainsKey("SIDE"))
				{
					string text2;
					try
					{
						text2 = Conversions.ToString(dictionary["SIDE"]);
					}
					catch (Exception ex4)
					{
						throw new Exception3("side must be a string");
					}
					Side side;
					try
					{
						side = LuaUtility.smethod_16(dictionary, scenario_0);
					}
					catch (Exception ex5)
					{
						throw new Exception3("Can't find Side '" + text2 + "'");
					}
					try
					{
						activeUnit = Enumerable.First<ActiveUnit>(side.activeUnit_0, new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception ex6)
					{
						throw new Exception3(string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text2,
							"'"
						}));
					}
					dictionary["GUID"] = activeUnit.string_0;
				}
				else
				{
					try
					{
						activeUnit = Enumerable.First<ActiveUnit>(scenario_0.method_42(), new Func<ActiveUnit, bool>(@class.method_1));
					}
					catch (Exception ex7)
					{
						throw new Exception3("Can't find Unit '" + @class.string_0 + "'");
					}
					dictionary["GUID"] = activeUnit.string_0;
					dictionary["SIDE"] = activeUnit.vmethod_7(false).method_51();
				}
			}
			if (activeUnit == null)
			{
				throw new Exception3("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
			}
			Side side2 = null;
			try
			{
				foreach (Side side3 in scenario_0.method_44())
				{
					if (Operators.CompareString(side3.method_51().ToUpper(), dictionary["NEWSIDE"].ToString().ToUpper(), false) == 0)
					{
						side2 = side3;
						break;
					}
				}
			}
			catch (Exception ex8)
			{
				throw new Exception3("Invalid new-side name!");
			}
			bool result;
			if (!Information.IsNothing(side2))
			{
				if (activeUnit.bool_1)
				{
					Group group = (Group)activeUnit;
					List<Unit> list = new List<Unit>();
					list = group.method_152();
					try
					{
						foreach (Unit unit in list)
						{
							try
							{
								foreach (Contact contact in side2.method_44())
								{
									if (!Information.IsNothing(contact.activeUnit_0) && Operators.CompareString(contact.activeUnit_0.string_0, unit.string_0, false) == 0)
									{
										side2.method_15(contact, ref scenario_0, false);
										break;
									}
								}
							}
							finally
							{
								List<Contact>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							try
							{
								IL_33C:
								foreach (Contact contact2 in side2.method_46())
								{
									if (!Information.IsNothing(contact2.activeUnit_0) && Operators.CompareString(contact2.activeUnit_0.string_0, unit.string_0, false) == 0)
									{
										side2.method_17(contact2, ref scenario_0, false);
										break;
									}
								}
							}
							finally
							{
								List<Contact>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
							unit.vmethod_8(true, side2);
							((ActiveUnit)unit).vmethod_66(false, (Group)activeUnit);
							continue;
							goto IL_33C;
						}
					}
					finally
					{
						List<Unit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					activeUnit.vmethod_8(true, side2);
					try
					{
						foreach (Contact contact3 in side2.method_44())
						{
							if (!Information.IsNothing(contact3.activeUnit_0) && Operators.CompareString(contact3.activeUnit_0.string_0, activeUnit.string_0, false) == 0)
							{
								side2.method_15(contact3, ref scenario_0, false);
								break;
							}
						}
					}
					finally
					{
						List<Contact>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
					try
					{
						foreach (Contact contact4 in side2.method_46())
						{
							if (!Information.IsNothing(contact4.activeUnit_0) && Operators.CompareString(contact4.activeUnit_0.string_0, activeUnit.string_0, false) == 0)
							{
								side2.method_17(contact4, ref scenario_0, false);
								break;
							}
						}
						goto IL_598;
					}
					finally
					{
						List<Contact>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				try
				{
					foreach (Contact contact5 in side2.method_44())
					{
						if (!Information.IsNothing(contact5.activeUnit_0) && Operators.CompareString(contact5.activeUnit_0.string_0, activeUnit.string_0, false) == 0)
						{
							side2.method_15(contact5, ref scenario_0, false);
							break;
						}
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator6;
					((IDisposable)enumerator6).Dispose();
				}
				try
				{
					foreach (Contact contact6 in side2.method_46())
					{
						if (!Information.IsNothing(contact6.activeUnit_0) && Operators.CompareString(contact6.activeUnit_0.string_0, activeUnit.string_0, false) == 0)
						{
							side2.method_17(contact6, ref scenario_0, false);
							break;
						}
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator7;
					((IDisposable)enumerator7).Dispose();
				}
				activeUnit.vmethod_8(true, side2);
				IL_598:
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00257ABC File Offset: 0x00255CBC
		public static int smethod_42(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			Side side = null;
			LuaUtility.smethod_5(ref dictionary);
			if (dictionary.ContainsKey("GUID"))
			{
				string key;
				try
				{
					key = Conversions.ToString(dictionary["GUID"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.vmethod_0()[key];
				}
				catch (Exception ex2)
				{
					return 0;
				}
				if (activeUnit == null)
				{
					return 0;
				}
				dictionary["SIDE"] = activeUnit.vmethod_7(false).method_51();
				dictionary["UNITNAME"] = activeUnit.Name;
			}
			else if (dictionary.ContainsKey("UNITNAME"))
			{
				PrivateMethods.Class500 @class = new PrivateMethods.Class500(@class);
				try
				{
					@class.string_0 = Conversions.ToString(dictionary["UNITNAME"]);
				}
				catch (Exception ex3)
				{
					throw new Exception3("name must be a string");
				}
				if (dictionary.ContainsKey("SIDE"))
				{
					string text;
					try
					{
						text = Conversions.ToString(dictionary["SIDE"]);
					}
					catch (Exception ex4)
					{
						throw new Exception3("side must be a string");
					}
					try
					{
						side = LuaUtility.smethod_16(dictionary, scenario_0);
					}
					catch (Exception ex5)
					{
						throw new Exception3("Can't find Side '" + text + "'");
					}
					try
					{
						activeUnit = Enumerable.FirstOrDefault<ActiveUnit>(side.activeUnit_0, new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception ex6)
					{
						throw new Exception3(string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text,
							"'"
						}));
					}
					dictionary["GUID"] = activeUnit.string_0;
				}
				else
				{
					try
					{
						activeUnit = Enumerable.FirstOrDefault<ActiveUnit>(scenario_0.method_42(), new Func<ActiveUnit, bool>(@class.method_1));
					}
					catch (Exception ex7)
					{
						throw new Exception3("Can't find Unit '" + @class.string_0 + "'");
					}
					dictionary["GUID"] = activeUnit.string_0;
					dictionary["SIDE"] = activeUnit.vmethod_7(false).method_51();
				}
			}
			if (activeUnit == null)
			{
				throw new Exception3("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
			}
			if (side == null)
			{
				side = LuaUtility.smethod_16(dictionary, scenario_0);
			}
			if (!dictionary.ContainsKey("WPN_DBID"))
			{
				throw new Exception3("No weapon defined.");
			}
			int num = Conversions.ToInteger(dictionary["WPN_DBID"]);
			Mount mount = null;
			if (dictionary.ContainsKey("MOUNT_GUID"))
			{
				if (activeUnit.vmethod_51().Count == 0)
				{
					throw new Exception3("No mount present in unit.");
				}
				try
				{
					foreach (Mount mount2 in activeUnit.vmethod_51())
					{
						if (Operators.CompareString(mount2.string_0, Conversions.ToString(dictionary["MOUNT_GUID"]), false) == 0)
						{
							mount = mount2;
						}
					}
				}
				finally
				{
					List<Mount>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (mount == null & activeUnit.vmethod_51().Count == 0)
			{
				throw new Exception3("No mount present in unit.");
			}
			string text2 = null;
			if (dictionary.ContainsKey("WPN_GUID"))
			{
				text2 = Conversions.ToString(dictionary["WPN_GUID"]);
			}
			int num2 = 0;
			bool flag = false;
			bool flag2 = true;
			bool flag3 = false;
			int num3 = 0;
			if (dictionary.ContainsKey("NUMBER"))
			{
				num2 = Conversions.ToInteger(dictionary["NUMBER"]);
			}
			if (dictionary.ContainsKey("REMOVE"))
			{
				flag = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["REMOVE"])).Value;
			}
			if (dictionary.ContainsKey("FILLOUT"))
			{
				flag3 = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["FILLOUT"])).Value;
			}
			if (flag3)
			{
				flag2 = false;
				flag = false;
				num2 = 9999999;
			}
			if (num2 > 0)
			{
				if (!Information.IsNothing(mount))
				{
					try
					{
						foreach (WeaponRec weaponRec in mount.vmethod_10())
						{
							int num4 = weaponRec.int_4;
							if (num4 < 1)
							{
								num4 = 1;
							}
							int num5 = num4 * num2;
							if ((text2 == null || Operators.CompareString(text2, weaponRec.string_0, false) == 0) && weaponRec.int_5 == num)
							{
								if (flag)
								{
									if (weaponRec.method_9() >= num5)
									{
										WeaponRec weaponRec2;
										(weaponRec2 = weaponRec).method_10(weaponRec2.method_9() - num5);
										num3 += num2;
										num2 = 0;
										break;
									}
									if (weaponRec.method_9() > 0)
									{
										while (weaponRec.method_9() >= num4 & num5 > 0)
										{
											num5 -= num4;
											num2--;
											WeaponRec weaponRec2;
											(weaponRec2 = weaponRec).method_10(weaponRec2.method_9() - num4);
											num3++;
										}
										weaponRec.method_10(0);
									}
								}
								else
								{
									if (weaponRec.method_9() + num5 <= weaponRec.int_2)
									{
										WeaponRec weaponRec2;
										(weaponRec2 = weaponRec).method_10(weaponRec2.method_9() + num5);
										num3 += num2;
										num2 = 0;
										break;
									}
									if (weaponRec.method_9() != weaponRec.int_2)
									{
										while (weaponRec.method_9() < weaponRec.int_2 & num5 > 0)
										{
											num5 -= num4;
											num2--;
											WeaponRec weaponRec2;
											(weaponRec2 = weaponRec).method_10(weaponRec2.method_9() + num4);
											num3++;
										}
										weaponRec.method_10(weaponRec.int_2);
									}
								}
							}
						}
						goto IL_73F;
					}
					finally
					{
						List<WeaponRec>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				try
				{
					foreach (Mount mount3 in activeUnit.vmethod_51())
					{
						try
						{
							foreach (WeaponRec weaponRec3 in mount3.vmethod_10())
							{
								int num6 = weaponRec3.int_4;
								if (num6 < 1)
								{
									num6 = 1;
								}
								int num7 = num6 * num2;
								if ((text2 == null || Operators.CompareString(text2, weaponRec3.string_0, false) == 0) && weaponRec3.int_5 == num)
								{
									if (flag)
									{
										if (weaponRec3.method_9() >= num7)
										{
											WeaponRec weaponRec2;
											(weaponRec2 = weaponRec3).method_10(weaponRec2.method_9() - num7);
											num3 += num2;
											num2 = 0;
											break;
										}
										if (weaponRec3.method_9() > 0)
										{
											while (weaponRec3.method_9() >= num6 & num7 > 0)
											{
												num7 -= num6;
												num2--;
												WeaponRec weaponRec2;
												(weaponRec2 = weaponRec3).method_10(weaponRec2.method_9() - num6);
												num3++;
											}
											weaponRec3.method_10(0);
										}
									}
									else
									{
										if (weaponRec3.method_9() + num7 <= weaponRec3.int_2)
										{
											WeaponRec weaponRec2;
											(weaponRec2 = weaponRec3).method_10(weaponRec2.method_9() + num7);
											num3 += num2;
											num2 = 0;
											break;
										}
										if (weaponRec3.method_9() != weaponRec3.int_2)
										{
											while (weaponRec3.method_9() < weaponRec3.int_2 & num7 > 0)
											{
												num7 -= num6;
												num2--;
												WeaponRec weaponRec2;
												(weaponRec2 = weaponRec3).method_10(weaponRec2.method_9() + num6);
												num3++;
											}
											weaponRec3.method_10(weaponRec3.int_2);
										}
									}
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
						if (num2 <= 0)
						{
							break;
						}
					}
				}
				finally
				{
					List<Mount>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
			}
			IL_73F:
			if (!(num2 > 0 & !flag & !flag3) || !flag2 || !Information.IsNothing(mount))
			{
			}
			return num3;
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x0025833C File Offset: 0x0025653C
		public static int smethod_43(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			Side side = null;
			LuaUtility.smethod_5(ref dictionary);
			if (dictionary.ContainsKey("GUID"))
			{
				string key;
				try
				{
					key = Conversions.ToString(dictionary["GUID"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.vmethod_0()[key];
				}
				catch (Exception ex2)
				{
					return 0;
				}
				if (activeUnit == null)
				{
					return 0;
				}
				dictionary["SIDE"] = activeUnit.vmethod_7(false).method_51();
				dictionary["UNITNAME"] = activeUnit.Name;
			}
			else if (dictionary.ContainsKey("UNITNAME"))
			{
				PrivateMethods.Class501 @class = new PrivateMethods.Class501(@class);
				try
				{
					@class.string_0 = Conversions.ToString(dictionary["UNITNAME"]);
				}
				catch (Exception ex3)
				{
					throw new Exception3("name must be a string");
				}
				if (dictionary.ContainsKey("SIDE"))
				{
					string text = null;
					try
					{
						text = Conversions.ToString(dictionary["SIDE"]);
					}
					catch (Exception ex4)
					{
						throw new Exception3("side must be a string");
					}
					try
					{
						side = LuaUtility.smethod_16(dictionary, scenario_0);
					}
					catch (Exception ex5)
					{
						throw new Exception3("Can't find Side '" + text + "'");
					}
					try
					{
						activeUnit = Enumerable.FirstOrDefault<ActiveUnit>(side.activeUnit_0, new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception ex6)
					{
						throw new Exception3(string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text,
							"'"
						}));
					}
					dictionary["GUID"] = activeUnit.string_0;
				}
				else
				{
					try
					{
						activeUnit = Enumerable.FirstOrDefault<ActiveUnit>(scenario_0.method_42(), new Func<ActiveUnit, bool>(@class.method_1));
					}
					catch (Exception ex7)
					{
						throw new Exception3("Can't find Unit '" + @class.string_0 + "'");
					}
					dictionary["GUID"] = activeUnit.string_0;
					dictionary["SIDE"] = activeUnit.vmethod_7(false).method_51();
				}
			}
			if (activeUnit == null)
			{
				throw new Exception3("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
			}
			if (side == null)
			{
				side = LuaUtility.smethod_16(dictionary, scenario_0);
			}
			Magazine magazine = null;
			if (dictionary.ContainsKey("MAG_GUID"))
			{
				if (Enumerable.Count<Magazine>(activeUnit.method_91()) == 0)
				{
					throw new Exception3("No magazine present in unit.");
				}
				foreach (Magazine magazine2 in activeUnit.method_91())
				{
					if (Operators.CompareString(magazine2.string_0, Conversions.ToString(dictionary["MAG_GUID"]), false) == 0)
					{
						magazine = magazine2;
					}
				}
			}
			if (magazine == null & Enumerable.Count<Magazine>(activeUnit.method_91()) == 0)
			{
				throw new Exception3("No magazine present in unit.");
			}
			if (!dictionary.ContainsKey("WPN_DBID"))
			{
				throw new Exception3("No weapon defined.");
			}
			int num = Conversions.ToInteger(dictionary["WPN_DBID"]);
			int num2 = 0;
			int int_ = 0;
			bool flag = false;
			bool bool_ = true;
			bool flag2 = false;
			int num3 = 0;
			if (dictionary.ContainsKey("NUMBER"))
			{
				num2 = Conversions.ToInteger(dictionary["NUMBER"]);
			}
			if (dictionary.ContainsKey("MAXCAP"))
			{
				int_ = Conversions.ToInteger(dictionary["MAXCAP"]);
			}
			if (dictionary.ContainsKey("REMOVE"))
			{
				flag = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["REMOVE"])).Value;
			}
			if (dictionary.ContainsKey("NEW"))
			{
				bool_ = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["NEW"])).Value;
			}
			if (dictionary.ContainsKey("FILLOUT"))
			{
				flag2 = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["FILLOUT"])).Value;
			}
			if (flag2)
			{
				bool_ = false;
				flag = false;
				num2 = 9999999;
			}
			if (num2 > 0)
			{
				if (!Information.IsNothing(magazine))
				{
					try
					{
						foreach (WeaponRec weaponRec in magazine.vmethod_10())
						{
							if (weaponRec.int_5 == num)
							{
								if (flag)
								{
									if (weaponRec.method_9() >= num2)
									{
										WeaponRec weaponRec2;
										(weaponRec2 = weaponRec).method_10(weaponRec2.method_9() - num2);
										num3 += num2;
										num2 = 0;
										break;
									}
									if (weaponRec.method_9() > 0)
									{
										num2 -= weaponRec.method_9();
										num3 += weaponRec.method_9();
										weaponRec.method_10(0);
									}
								}
								else
								{
									if (weaponRec.method_9() + num2 <= weaponRec.int_2)
									{
										WeaponRec weaponRec2;
										(weaponRec2 = weaponRec).method_10(weaponRec2.method_9() + num2);
										num3 += num2;
										num2 = 0;
										break;
									}
									if (weaponRec.method_9() != weaponRec.int_2)
									{
										num2 -= weaponRec.int_2 - weaponRec.method_9();
										num3 += weaponRec.int_2 - weaponRec.method_9();
										weaponRec.method_10(weaponRec.int_2);
									}
								}
							}
						}
						goto IL_75A;
					}
					finally
					{
						List<WeaponRec>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				Magazine[] array2 = activeUnit.method_91();
				int j = 0;
				while (j < array2.Length)
				{
					Magazine magazine3 = array2[j];
					try
					{
						foreach (WeaponRec weaponRec3 in magazine3.vmethod_10())
						{
							if (weaponRec3.int_5 == num)
							{
								if (flag)
								{
									if (weaponRec3.method_9() >= num2)
									{
										WeaponRec weaponRec2;
										(weaponRec2 = weaponRec3).method_10(weaponRec2.method_9() - num2);
										num3 += num2;
										num2 = 0;
										break;
									}
									if (weaponRec3.method_9() > 0)
									{
										num2 -= weaponRec3.method_9();
										num3 += weaponRec3.method_9();
										weaponRec3.method_10(0);
									}
								}
								else
								{
									if (weaponRec3.method_9() + num2 <= weaponRec3.int_2)
									{
										WeaponRec weaponRec2;
										(weaponRec2 = weaponRec3).method_10(weaponRec2.method_9() + num2);
										num3 += num2;
										num2 = 0;
										break;
									}
									if (weaponRec3.method_9() != weaponRec3.int_2)
									{
										num2 -= weaponRec3.int_2 - weaponRec3.method_9();
										num3 += weaponRec3.int_2 - weaponRec3.method_9();
										weaponRec3.method_10(weaponRec3.int_2);
									}
								}
							}
						}
						goto IL_65C;
					}
					finally
					{
						List<WeaponRec>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					IL_651:
					checked
					{
						j++;
						continue;
						IL_65C:
						if (num2 > 0)
						{
							goto IL_651;
						}
						break;
					}
				}
			}
			IL_75A:
			while (num2 > 0 & !flag & !flag2)
			{
				if (Information.IsNothing(magazine))
				{
					Magazine magazine4 = null;
					int int_2 = num;
					Magazine magazine5 = null;
					magazine4 = PrivateMethods.smethod_44(ref activeUnit, int_2, ref magazine5, false, bool_, int_);
					if (magazine4 != null)
					{
						num2--;
						num3++;
						try
						{
							foreach (WeaponRec weaponRec4 in magazine4.vmethod_10())
							{
								if (weaponRec4.int_5 == num)
								{
									if (weaponRec4.method_9() + num2 <= weaponRec4.int_2)
									{
										WeaponRec weaponRec2;
										(weaponRec2 = weaponRec4).method_10(weaponRec2.method_9() + num2);
										num3 += num2;
										num2 = 0;
										break;
									}
									if (weaponRec4.method_9() != weaponRec4.int_2)
									{
										num2 -= weaponRec4.int_2 - weaponRec4.method_9();
										num3 += weaponRec4.int_2 - weaponRec4.method_9();
										weaponRec4.method_10(weaponRec4.int_2);
									}
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
						magazine4.method_21();
						continue;
					}
				}
				else if (PrivateMethods.smethod_44(ref activeUnit, num, ref magazine, false, bool_, int_) != null)
				{
					num2--;
					num3++;
					try
					{
						foreach (WeaponRec weaponRec5 in magazine.vmethod_10())
						{
							if (weaponRec5.int_5 == num)
							{
								if (weaponRec5.method_9() + num2 <= weaponRec5.int_2)
								{
									WeaponRec weaponRec2;
									(weaponRec2 = weaponRec5).method_10(weaponRec2.method_9() + num2);
									num3 += num2;
									num2 = 0;
									break;
								}
								if (weaponRec5.method_9() != weaponRec5.int_2)
								{
									num2 -= weaponRec5.int_2 - weaponRec5.method_9();
									num3 += weaponRec5.int_2 - weaponRec5.method_9();
									weaponRec5.method_10(weaponRec5.int_2);
								}
							}
						}
					}
					finally
					{
						List<WeaponRec>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
					magazine.method_21();
				}
				IL_853:
				return num3;
			}
			goto IL_853;
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x00258CB0 File Offset: 0x00256EB0
		public static Magazine smethod_44(ref ActiveUnit activeUnit_0, int int_0, ref Magazine magazine_0, bool bool_0, bool bool_1, int int_1)
		{
			Magazine[] array = activeUnit_0.method_91();
			if (bool_1 && activeUnit_0.vmethod_117().Length > 0)
			{
				array = activeUnit_0.vmethod_117();
				if (bool_0)
				{
					array = Enumerable.ToArray<Magazine>(Enumerable.OrderByDescending<Magazine, string>(array, (PrivateMethods._Closure$__.$I60-0 == null) ? (PrivateMethods._Closure$__.$I60-0 = new Func<Magazine, string>(PrivateMethods._Closure$__.$I.method_7)) : PrivateMethods._Closure$__.$I60-0));
				}
				foreach (Magazine magazine in array)
				{
					Magazine magazine2 = magazine;
					int num = 0;
					int num2 = 0;
					if (magazine2.method_27(ref num, ref num2) <= magazine.int_1)
					{
						int int_2 = int_1 ?? magazine.int_1;
						magazine.vmethod_10().method_4(new WeaponRec(ref activeUnit_0.scenario_0, int_0, 0, int_2, 1, 1, false, false));
						if (string.CompareOrdinal(magazine.method_26(int_0), "OK") == 0)
						{
							return magazine;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00258D94 File Offset: 0x00256F94
		public static string smethod_45(LuaTable luaTable_0, Scenario scenario_0)
		{
			LuaSandBox.Singleton().CreateTable();
			ActiveUnit activeUnit = null;
			Side side = null;
			string text = "";
			ActiveUnit activeUnit2 = null;
			List<Mission> list = null;
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			LuaUtility.smethod_5(ref dictionary);
			if (dictionary.ContainsKey("SIDE"))
			{
				side = LuaUtility.smethod_16(dictionary, scenario_0);
			}
			string text2 = LuaUtility.smethod_28(dictionary, scenario_0);
			if (text2.Length == 0)
			{
				if (dictionary.ContainsKey("GUID"))
				{
					activeUnit = PrivateMethods.smethod_67(Conversions.ToString(dictionary["GUID"]), scenario_0);
					if (side == null)
					{
						side = activeUnit.vmethod_7(false);
					}
					if (dictionary.ContainsKey("TANKER"))
					{
						activeUnit2 = PrivateMethods.smethod_68(Conversions.ToString(dictionary["TANKER"]), side);
					}
					if (dictionary.ContainsKey("MISSIONS"))
					{
						list = new List<Mission>();
						List<object> list2 = LuaUtility.smethod_0(((LuaTable)dictionary["MISSIONS"]).GetEnumerator());
						try
						{
							foreach (object obj in list2)
							{
								Mission mission = Class461.smethod_9(Conversions.ToString(RuntimeHelpers.GetObjectValue(obj)), side);
								if (mission != null)
								{
									list.Add(mission);
								}
							}
						}
						finally
						{
							List<object>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					if (!Information.IsNothing(activeUnit) && activeUnit.bool_0 && (activeUnit.vmethod_7(false) == side || activeUnit.vmethod_7(false).method_67(side)) && activeUnit.GetType() != typeof(Weapon))
					{
						PrivateMethods.smethod_71(activeUnit, scenario_0, ref text, ref activeUnit2, ref list);
					}
				}
				string result;
				if (activeUnit == null)
				{
					result = null;
				}
				else
				{
					result = text;
				}
				return result;
			}
			throw new Exception3(text2);
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00258F44 File Offset: 0x00257144
		public static LuaTable smethod_46(string string_0, Scenario scenario_0)
		{
			Side side = null;
			foreach (Side side2 in scenario_0.method_44())
			{
				if (Operators.CompareString(side2.method_51().ToUpper(), string_0.ToUpper(), false) == 0 || Operators.CompareString(side2.string_0.ToUpper(), string_0.ToUpper(), false) == 0)
				{
					side = side2;
					IL_5A:
					LuaTable result;
					if (side == null)
					{
						result = null;
					}
					else
					{
						LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
						try
						{
							foreach (Contact theContact in side.method_44())
							{
								LuaWrapper_Contact value = new LuaWrapper_Contact(theContact, scenario_0, side);
								luaTable[luaTable.Keys.Count + 1] = value;
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						try
						{
							foreach (string text in side.lazy_0.Value.Keys)
							{
								Contact theContact2 = side.lazy_0.Value[text];
								LuaWrapper_Contact value2 = new LuaWrapper_Contact(theContact2, scenario_0, side);
								luaTable[luaTable.Keys.Count + 1] = value2;
							}
						}
						finally
						{
							IEnumerator<string> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						result = luaTable;
					}
					return result;
				}
			}
			goto IL_5A;
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x002590A8 File Offset: 0x002572A8
		public static bool smethod_47(string string_0, string string_1, LuaTable luaTable_0, Scenario scenario_0)
		{
			ActiveUnit activeUnit = null;
			Contact contact = null;
			ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior_ = ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted;
			string left = null;
			double double_ = 0.0;
			double double_2 = 0.0;
			List<Waypoint> list = new List<Waypoint>();
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			activeUnit = PrivateMethods.smethod_67(string_0, scenario_0);
			bool result;
			if (activeUnit == null)
			{
				result = false;
			}
			else
			{
				contact = PrivateMethods.smethod_69(string_1, scenario_0);
				if (contact == null)
				{
					if (Operators.CompareString(string_1.ToUpper(), "BOL", false) != 0)
					{
						return false;
					}
					string string_2 = null;
					if (dictionary.ContainsKey("LATITUDE"))
					{
						string_2 = Conversions.ToString(dictionary["LATITUDE"]);
					}
					double_ = LuaUtility.smethod_8(string_2);
					string_2 = "";
					if (dictionary.ContainsKey("LONGITUDE"))
					{
						string_2 = Conversions.ToString(dictionary["LONGITUDE"]);
					}
					double_2 = LuaUtility.smethod_9(string_2);
					if (dictionary.ContainsKey("COURSE"))
					{
						List<object> list2 = LuaUtility.smethod_0(((LuaTable)dictionary["COURSE"]).GetEnumerator());
						try
						{
							foreach (object obj in list2)
							{
								object objectValue = RuntimeHelpers.GetObjectValue(obj);
								if (!(objectValue is LuaTable))
								{
									throw new Exception3("BOL waypoint error");
								}
								Dictionary<string, object> dictionary_ = LuaUtility.smethod_1(((LuaTable)objectValue).GetEnumerator());
								double? num = LuaUtility.smethod_13(dictionary_);
								double? num2 = LuaUtility.smethod_11(dictionary_);
								if (num == null | num == null)
								{
									throw new Exception3("Course object " + LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(objectValue)) + " needs latitude or longitude.");
								}
								Waypoint item = new Waypoint(num.Value, num2.Value, 0f, Waypoint.WaypointType.TurningPoint, Waypoint.Enum80.const_2, Waypoint.Enum79.const_0);
								list.Add(item);
							}
						}
						finally
						{
							List<object>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					contact = new Class356(double_, double_2);
				}
				if (dictionary.ContainsKey("MODE"))
				{
					left = Conversions.ToString(dictionary["MODE"]);
				}
				if (Operators.CompareString(left, "0", false) != 0 && Operators.CompareString(left, "AutoTargeted", false) != 0)
				{
					if (Operators.CompareString(left, "1", false) != 0 && Operators.CompareString(left, "ManualWeaponAlloc", false) != 0)
					{
						if (Operators.CompareString(left, "2", false) != 0 && Operators.CompareString(left, "ManualTargeted", false) != 0)
						{
							throw new Exception3("Invalid targeting behaviour");
						}
						targetingBehavior_ = ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted;
						activeUnit.vmethod_86().vmethod_12(contact, true, true, ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted);
						activeUnit.vmethod_86().vmethod_22(0f);
					}
					else
					{
						targetingBehavior_ = ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc;
						Weapon weapon = null;
						Mount mount = null;
						WeaponRec weaponRec = null;
						int num3 = 0;
						int num4 = 0;
						int num5 = 0;
						int? num6 = new int?(1);
						int num7 = 0;
						if (dictionary.ContainsKey("MOUNT"))
						{
							num3 = Conversions.ToInteger(dictionary["MOUNT"]);
						}
						if (dictionary.ContainsKey("WEAPON"))
						{
							num4 = Conversions.ToInteger(dictionary["WEAPON"]);
						}
						if (dictionary.ContainsKey("QTY"))
						{
							num5 = Conversions.ToInteger(dictionary["QTY"]);
						}
						if (num3 == 0 || num4 == 0 || num5 == 0)
						{
							return false;
						}
						bool flag = false;
						try
						{
							foreach (Mount mount2 in activeUnit.vmethod_51())
							{
								if (mount2.DBID == num3 & mount2.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed)
								{
									try
									{
										foreach (WeaponRec weaponRec2 in mount2.vmethod_10())
										{
											if (weaponRec2.int_5 == num4)
											{
												if (weaponRec2.method_9() > 0)
												{
													if (weapon == null)
													{
														weapon = weaponRec2.method_12(scenario_0);
														weaponRec = weaponRec2;
														mount = mount2;
													}
													num7 += weaponRec2.method_9();
													if (mount2.hashSet_0.Contains(weaponRec2.int_5))
													{
														mount2.hashSet_0.Remove(weaponRec2.int_5);
													}
												}
												else
												{
													activeUnit.vmethod_89();
													if (mount2.method_32().vmethod_10().Count > 0 && mount2.method_32().vmethod_10().Count > 1 && !weaponRec2.method_11(mount2) && !weaponRec2.method_12(activeUnit.scenario_0).method_208() && activeUnit.vmethod_89().method_34(mount2, weaponRec2.int_5) != 0 && weapon == null && !mount2.hashSet_0.Contains(weaponRec2.int_5))
													{
														mount2.hashSet_0.Add(weaponRec2.int_5);
														weapon = weaponRec2.method_12(scenario_0);
														weaponRec = weaponRec2;
														mount = mount2;
														flag = true;
														break;
													}
												}
											}
										}
									}
									finally
									{
										List<WeaponRec>.Enumerator enumerator3;
										((IDisposable)enumerator3).Dispose();
									}
									if (weapon != null)
									{
										break;
									}
								}
							}
						}
						finally
						{
							List<Mount>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						if (weapon == null || num5 == 0 || (num7 == 0 & !flag))
						{
							return false;
						}
						List<Class316> list3 = activeUnit.vmethod_7(false).method_73(contact);
						try
						{
							foreach (Class316 @class in list3)
							{
								if (@class.contact_0 == contact && num4 == @class.int_0)
								{
									List<Class316.Class273> list4 = Enumerable.ToList<Class316.Class273>(@class.class273_0);
									try
									{
										List<Class316.Class273>.Enumerator enumerator5 = list4.GetEnumerator();
										while (enumerator5.MoveNext())
										{
											if (Operators.CompareString(enumerator5.Current.string_0, activeUnit.string_0, false) == 0)
											{
												if (@class.method_8() - @class.method_9() + num5 > num7)
												{
													return true;
												}
												break;
											}
										}
									}
									finally
									{
										List<Class316.Class273>.Enumerator enumerator5;
										((IDisposable)enumerator5).Dispose();
									}
								}
							}
						}
						finally
						{
							List<Class316>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
						activeUnit.vmethod_86().vmethod_12(contact, true, true, targetingBehavior_);
						if (Operators.CompareString(string_1.ToUpper(), "BOL", false) != 0)
						{
							ActiveUnit_Weaponry activeUnit_Weaponry = activeUnit.vmethod_89();
							Contact contact_ = contact;
							int dbid = weapon.DBID;
							int int_ = num5;
							bool bool_ = true;
							Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = null;
							activeUnit_Weaponry.method_11(contact_, dbid, int_, bool_, ref gunStrafeGroundTargets, DateTime.MinValue);
							activeUnit.vmethod_86().vmethod_19(0f);
						}
						else
						{
							Class316 class2 = activeUnit.vmethod_7(false).method_81(activeUnit.scenario_0, ref weapon, ref contact, new int?(num5), 0, new int?(num5), true, ref activeUnit.string_0, ref num6, DateTime.MinValue);
							if (list.Count > 0)
							{
								try
								{
									foreach (Waypoint waypoint_ in list)
									{
										Class429.smethod_36(ref class2.waypoint_0, waypoint_);
									}
								}
								finally
								{
									List<Waypoint>.Enumerator enumerator6;
									((IDisposable)enumerator6).Dispose();
								}
							}
						}
						if (flag)
						{
							mount.hashSet_0.Remove(weaponRec.int_5);
						}
					}
				}
				else
				{
					targetingBehavior_ = ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted;
					activeUnit.vmethod_86().vmethod_12(contact, false, true, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x002597F0 File Offset: 0x002579F0
		public static LuaWrapper_Side smethod_48(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			string text = null;
			Side side = null;
			LuaUtility.smethod_6(ref dictionary);
			if (dictionary.ContainsKey("SIDE"))
			{
				try
				{
					text = Conversions.ToString(dictionary["SIDE"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("Side must be a string");
				}
				try
				{
					side = LuaUtility.smethod_16(dictionary, scenario_0);
				}
				catch (Exception ex2)
				{
				}
			}
			if (side != null)
			{
				throw new Exception3("Side " + text + " already exists");
			}
			if (dictionary.ContainsKey("NAME"))
			{
				try
				{
					text = Conversions.ToString(dictionary["NAME"]);
				}
				catch (Exception ex3)
				{
					throw new Exception3("Side must be a string");
				}
			}
			Side side2 = new Side(text, ref scenario_0);
			scenario_0.method_69(side2);
			return new LuaWrapper_Side(side2, scenario_0);
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x002598EC File Offset: 0x00257AEC
		public static LuaWrapper_Side smethod_49(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			Side side = null;
			LuaUtility.smethod_6(ref dictionary);
			if (dictionary.ContainsKey("SIDE"))
			{
				string str;
				try
				{
					str = Conversions.ToString(dictionary["SIDE"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("side must be a string");
				}
				try
				{
					side = LuaUtility.smethod_16(dictionary, scenario_0);
				}
				catch (Exception ex2)
				{
					throw new Exception3("Can't find Side '" + str + "'");
				}
			}
			LuaWrapper_Side result = new LuaWrapper_Side(side, scenario_0);
			List<ActiveUnit> list = new List<ActiveUnit>();
			try
			{
				foreach (ActiveUnit activeUnit in scenario_0.method_42())
				{
					if (activeUnit != null && activeUnit.vmethod_7(false).Equals(side))
					{
						ActiveUnit activeUnit2 = activeUnit;
						if (activeUnit2.bool_1)
						{
							list.Add(activeUnit2);
						}
						else if (scenario_0.ExecutionInProgress)
						{
							scenario_0.method_64(activeUnit2);
						}
						else
						{
							scenario_0.method_66(activeUnit2.string_0, true);
						}
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (list.Count > 0)
			{
				try
				{
					foreach (ActiveUnit activeUnit3 in list)
					{
						if (activeUnit3 != null)
						{
							ActiveUnit activeUnit2 = activeUnit3;
							if (scenario_0.ExecutionInProgress)
							{
								scenario_0.method_64(activeUnit2);
							}
							else
							{
								scenario_0.method_66(activeUnit2.string_0, true);
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
			scenario_0.method_70(side);
			return result;
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x00259A8C File Offset: 0x00257C8C
		public static LuaWrapper_Zone smethod_50(string string_0, int int_0, LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			string text = null;
			Side side = null;
			Zone zone = new Zone();
			List<ReferencePoint> list = new List<ReferencePoint>();
			List<GlobalVariables.ActiveUnitType> list2 = new List<GlobalVariables.ActiveUnitType>();
			bool bool_ = false;
			bool flag = false;
			Unit unit = null;
			LuaUtility.smethod_5(ref dictionary);
			side = PrivateMethods.smethod_66(string_0, scenario_0);
			if (side == null)
			{
				throw new Exception3("Side " + text + " missing");
			}
			if (dictionary.ContainsKey("DESCRIPTION"))
			{
				text = Conversions.ToString(dictionary["DESCRIPTION"]);
				zone.string_2 = text;
			}
			if (dictionary.ContainsKey("ISACTIVE"))
			{
				text = Conversions.ToString(dictionary["ISACTIVE"]);
				zone.bool_11 = Conversions.ToBoolean(text);
			}
			if (dictionary.ContainsKey("LOCKED"))
			{
				text = Conversions.ToString(dictionary["LOCKED"]);
				bool_ = Conversions.ToBoolean(text);
			}
			checked
			{
				if (dictionary.ContainsKey("AFFECTS"))
				{
					list2.Clear();
					List<object> list3 = LuaUtility.smethod_0(((LuaTable)dictionary["AFFECTS"]).GetEnumerator());
					try
					{
						List<object>.Enumerator enumerator = list3.GetEnumerator();
						IL_1A8:
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							string text2 = RuntimeHelpers.GetObjectValue(obj).ToString().ToLower();
							GlobalVariables.ActiveUnitType activeUnitType = GlobalVariables.ActiveUnitType.None;
							byte[] array = (byte[])Enum.GetValues(typeof(GlobalVariables.ActiveUnitType));
							int i = 0;
							while (i < array.Length)
							{
								byte b = array[i];
								if (Operators.CompareString(text2, b.ToString().ToLower(), false) != 0)
								{
									string left = text2;
									GlobalVariables.ActiveUnitType activeUnitType2 = (GlobalVariables.ActiveUnitType)b;
									if (Operators.CompareString(left, activeUnitType2.ToString().ToLower(), false) != 0)
									{
										i++;
										continue;
									}
								}
								activeUnitType = (GlobalVariables.ActiveUnitType)b;
								IL_19B:
								if (activeUnitType != GlobalVariables.ActiveUnitType.None)
								{
									list2.Add(activeUnitType);
									goto IL_1A8;
								}
								throw new Exception3("Error in Affected UnitTypes!");
							}
							goto IL_19B;
						}
					}
					finally
					{
						List<object>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (dictionary.ContainsKey("RELATIVETO"))
				{
					string text3 = Conversions.ToString(dictionary["RELATIVETO"]);
					unit = PrivateMethods.smethod_68(text3, side);
					if (unit == null)
					{
						throw new Exception3("Missing unit " + text3 + " from relative bearing");
					}
				}
				if (dictionary.ContainsKey("AREA"))
				{
					list.Clear();
					List<object> list4 = LuaUtility.smethod_0(((LuaTable)dictionary["AREA"]).GetEnumerator());
					try
					{
						foreach (object obj2 in list4)
						{
							LuaTable luaTable = (LuaTable)obj2;
							LuaSandBox.Singleton().CreateTable();
							ReferencePoint referencePoint = Class478.smethod_5(LuaUtility.smethod_1(luaTable.GetEnumerator()), dictionary, scenario_0, unit);
							if (Information.IsNothing(referencePoint))
							{
								throw new Exception3("Can't create RP");
							}
							list.Add(referencePoint);
						}
					}
					finally
					{
						List<object>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					if (list == null)
					{
						throw new Exception3("Error in RP!");
					}
				}
				Misc.PostureStance theMarkViolatorAs;
				if (dictionary.ContainsKey("MARKAS"))
				{
					text = Conversions.ToString(dictionary["MARKAS"]);
					Misc.PostureStance postureStance = Misc.PostureStance.Unknown;
					if (Enum.TryParse<Misc.PostureStance>(text, true, out postureStance) & Enum.IsDefined(typeof(Misc.PostureStance), postureStance))
					{
						theMarkViolatorAs = postureStance;
					}
					else
					{
						byte[] array2 = (byte[])Enum.GetValues(typeof(Misc.PostureStance));
						int j = 0;
						while (j < array2.Length)
						{
							byte b2 = array2[j];
							if (Operators.CompareString(text.ToLower(), b2.ToString().ToLower(), false) != 0)
							{
								string left2 = text.ToLower();
								GlobalVariables.ActiveUnitType activeUnitType2 = (GlobalVariables.ActiveUnitType)b2;
								if (Operators.CompareString(left2, activeUnitType2.ToString().ToLower(), false) != 0)
								{
									j++;
									continue;
								}
							}
							theMarkViolatorAs = (Misc.PostureStance)b2;
							break;
						}
					}
				}
				if (dictionary.ContainsKey("HIDDEN") && LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["HIDDEN"])).GetValueOrDefault())
				{
					flag = true;
				}
				LuaWrapper_Zone result;
				if (int_0 == 0)
				{
					NoNavZone noNavZone = new NoNavZone(zone.string_2, list, scenario_0, side, list2);
					noNavZone.bool_11 = zone.bool_11;
					noNavZone.bool_12 = bool_;
					side.list_7.Add(noNavZone);
					try
					{
						foreach (ReferencePoint referencePoint2 in list)
						{
							if (!flag)
							{
								if (!side.vmethod_12().Contains(referencePoint2))
								{
									side.vmethod_12().method_4(referencePoint2);
								}
							}
							else if (side.vmethod_12().Contains(referencePoint2))
							{
								side.vmethod_12().method_6(referencePoint2);
							}
						}
					}
					finally
					{
						List<ReferencePoint>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					result = new LuaWrapper_Zone(noNavZone, scenario_0, side);
				}
				else
				{
					ExclusionZone exclusionZone = new ExclusionZone(zone.string_2, side, list, theMarkViolatorAs, list2);
					exclusionZone.bool_11 = zone.bool_11;
					side.list_6.Add(exclusionZone);
					try
					{
						foreach (ReferencePoint referencePoint3 in list)
						{
							if (!flag)
							{
								if (!side.vmethod_12().Contains(referencePoint3))
								{
									side.vmethod_12().method_4(referencePoint3);
								}
							}
							else if (side.vmethod_12().Contains(referencePoint3))
							{
								side.vmethod_12().method_6(referencePoint3);
							}
						}
					}
					finally
					{
						List<ReferencePoint>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
					result = new LuaWrapper_Zone(exclusionZone, scenario_0, side);
				}
				return result;
			}
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x00259FF4 File Offset: 0x002581F4
		public static LuaWrapper_Zone smethod_51(string string_0, int int_0, LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			string text = null;
			Side side = null;
			Zone zone = new Zone();
			List<ReferencePoint> list = new List<ReferencePoint>();
			List<GlobalVariables.ActiveUnitType> list2 = new List<GlobalVariables.ActiveUnitType>();
			bool bool_ = false;
			bool flag = false;
			LuaUtility.smethod_5(ref dictionary);
			side = PrivateMethods.smethod_66(string_0, scenario_0);
			if (side == null)
			{
				throw new Exception3("Side " + text + " missing");
			}
			if (dictionary.ContainsKey("DESCRIPTION"))
			{
				text = Conversions.ToString(dictionary["DESCRIPTION"]);
				zone.string_2 = text;
			}
			if (dictionary.ContainsKey("ISACTIVE"))
			{
				text = Conversions.ToString(dictionary["ISACTIVE"]);
				zone.bool_11 = Conversions.ToBoolean(text);
			}
			if (dictionary.ContainsKey("LOCKED"))
			{
				text = Conversions.ToString(dictionary["LOCKED"]);
				bool_ = Conversions.ToBoolean(text);
			}
			if (dictionary.ContainsKey("RENAME"))
			{
				text = Conversions.ToString(dictionary["RENAME"]);
				zone.Name = text;
			}
			checked
			{
				if (dictionary.ContainsKey("AFFECTS"))
				{
					list2.Clear();
					List<object> list3 = LuaUtility.smethod_0(((LuaTable)dictionary["AFFECTS"]).GetEnumerator());
					try
					{
						List<object>.Enumerator enumerator = list3.GetEnumerator();
						IL_1CB:
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							string text2 = RuntimeHelpers.GetObjectValue(obj).ToString().ToLower();
							GlobalVariables.ActiveUnitType activeUnitType = GlobalVariables.ActiveUnitType.None;
							byte[] array = (byte[])Enum.GetValues(typeof(GlobalVariables.ActiveUnitType));
							int i = 0;
							while (i < array.Length)
							{
								byte b = array[i];
								if (Operators.CompareString(text2, b.ToString().ToLower(), false) != 0)
								{
									string left = text2;
									GlobalVariables.ActiveUnitType activeUnitType2 = (GlobalVariables.ActiveUnitType)b;
									if (Operators.CompareString(left, activeUnitType2.ToString().ToLower(), false) != 0)
									{
										i++;
										continue;
									}
								}
								activeUnitType = (GlobalVariables.ActiveUnitType)b;
								IL_1BE:
								if (activeUnitType != GlobalVariables.ActiveUnitType.None)
								{
									list2.Add(activeUnitType);
									goto IL_1CB;
								}
								throw new Exception3("Error in Affected UnitTypes!");
							}
							goto IL_1BE;
						}
					}
					finally
					{
						List<object>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
			if (dictionary.ContainsKey("AREA"))
			{
				list.Clear();
				List<object> list4 = LuaUtility.smethod_0(((LuaTable)dictionary["AREA"]).GetEnumerator());
				try
				{
					List<object>.Enumerator enumerator2 = list4.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						PrivateMethods.Class502 @class = new PrivateMethods.Class502(@class);
						@class.object_0 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
						ReferencePoint referencePoint = null;
						if (@class.object_0 is LuaTable)
						{
							double? num = null;
							double? num2 = null;
							Unit unit = null;
							double? num3 = null;
							double? num4 = null;
							Dictionary<string, object> dictionary2 = LuaUtility.smethod_1(((LuaTable)@class.object_0).GetEnumerator());
							if (dictionary2.ContainsKey("HIDDEN"))
							{
								flag = true;
							}
							string text3;
							if (!dictionary2.ContainsKey("NAME"))
							{
								scenario_0.UnitsAutoIncrement++;
								text3 = "RP-" + Conversions.ToString(scenario_0.UnitsAutoIncrement);
								dictionary2["NAME"] = text3;
							}
							else
							{
								text3 = Conversions.ToString(dictionary2["NAME"]);
							}
							if (dictionary2.ContainsKey("BEARING") && dictionary2.ContainsKey("DISTANCE"))
							{
								if (Information.IsNothing(unit))
								{
									throw new Exception3("No unit defined for relative bearing");
								}
								num3 = new double?(Conversions.ToDouble(dictionary2["BEARING"]));
								num4 = new double?(Conversions.ToDouble(dictionary2["DISTANCE"]));
								Class432.Struct47 @struct = new Class432.Struct47(unit.vmethod_30(null), unit.vmethod_28(null));
								Class432.Struct47 struct2 = default(Class432.Struct47);
								Class432.smethod_13(ref @struct, ref struct2, num3.Value, num4.Value);
								num = new double?(struct2.double_0);
								num2 = new double?(struct2.double_1);
							}
							else
							{
								num = LuaUtility.smethod_11(dictionary2);
								if (num == null)
								{
									throw new Exception3("Missing 'Latitude'");
								}
								num2 = LuaUtility.smethod_13(dictionary2);
								if (num2 == null)
								{
									throw new Exception3("Missing 'Longitude'");
								}
							}
							referencePoint = new ReferencePoint();
							referencePoint.imethod_1(num2.Value);
							referencePoint.imethod_3(num.Value);
							referencePoint.Name = text3;
							list.Add(referencePoint);
						}
						else
						{
							if (!Information.IsNothing(Enumerable.FirstOrDefault<ReferencePoint>(side.vmethod_12(), new Func<ReferencePoint, bool>(@class.method_0))))
							{
								referencePoint = Enumerable.First<ReferencePoint>(side.vmethod_12(), new Func<ReferencePoint, bool>(@class.method_1));
							}
							if (!Information.IsNothing(referencePoint))
							{
								list.Add(referencePoint);
							}
							else
							{
								referencePoint = new ReferencePoint();
								referencePoint.Name = @class.object_0.ToString();
								referencePoint.imethod_1(1.79769313486231E+308);
								referencePoint.imethod_3(1.79769313486231E+308);
								list.Add(referencePoint);
							}
						}
					}
				}
				finally
				{
					List<object>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				if (list == null)
				{
					throw new Exception3("Error in RP!");
				}
				if (!flag)
				{
					try
					{
						foreach (ReferencePoint referencePoint2 in list)
						{
							if (referencePoint2.imethod_0() != 1.79769313486231E+308 && !side.vmethod_12().Contains(referencePoint2))
							{
								side.vmethod_12().method_4(referencePoint2);
							}
						}
					}
					finally
					{
						List<ReferencePoint>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
			}
			checked
			{
				Misc.PostureStance postureStance_;
				if (dictionary.ContainsKey("MARKAS"))
				{
					text = Conversions.ToString(dictionary["MARKAS"]);
					Misc.PostureStance postureStance = Misc.PostureStance.Unknown;
					if (Enum.TryParse<Misc.PostureStance>(text, true, out postureStance) & Enum.IsDefined(typeof(Misc.PostureStance), postureStance))
					{
						postureStance_ = postureStance;
					}
					else
					{
						byte[] array2 = (byte[])Enum.GetValues(typeof(Misc.PostureStance));
						int j = 0;
						while (j < array2.Length)
						{
							byte b2 = array2[j];
							if (Operators.CompareString(text.ToLower(), b2.ToString().ToLower(), false) != 0)
							{
								string left2 = text.ToLower();
								GlobalVariables.ActiveUnitType activeUnitType2 = (GlobalVariables.ActiveUnitType)b2;
								if (Operators.CompareString(left2, activeUnitType2.ToString().ToLower(), false) != 0)
								{
									j++;
									continue;
								}
							}
							postureStance_ = (Misc.PostureStance)b2;
							break;
						}
					}
				}
				LuaWrapper_Zone result;
				if (int_0 == 0)
				{
					NoNavZone noNavZone = null;
					try
					{
						foreach (NoNavZone noNavZone2 in side.list_7)
						{
							if (Operators.CompareString(noNavZone2.string_0, zone.string_2, false) == 0 || Operators.CompareString(noNavZone2.Name, zone.string_2, false) == 0 || Operators.CompareString(noNavZone2.string_2, zone.string_2, false) == 0)
							{
								noNavZone = noNavZone2;
								break;
							}
						}
					}
					finally
					{
						List<NoNavZone>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
					if (Information.IsNothing(noNavZone))
					{
						throw new Exception3("No no-nav zone exists with this name or ID.");
					}
					if (dictionary.ContainsKey("DESCRIPTION"))
					{
						noNavZone.string_2 = zone.string_2;
					}
					if (dictionary.ContainsKey("ISACTIVE"))
					{
						noNavZone.bool_11 = zone.bool_11;
					}
					if (dictionary.ContainsKey("LOCKED"))
					{
						noNavZone.bool_12 = bool_;
					}
					if (dictionary.ContainsKey("RENAME"))
					{
						noNavZone.string_2 = zone.Name;
					}
					if (dictionary.ContainsKey("AFFECTS"))
					{
						noNavZone.vmethod_5(new ObservableList<GlobalVariables.ActiveUnitType>());
						try
						{
							foreach (GlobalVariables.ActiveUnitType gparam_ in list2)
							{
								noNavZone.vmethod_4().method_4(gparam_);
							}
						}
						finally
						{
							List<GlobalVariables.ActiveUnitType>.Enumerator enumerator5;
							((IDisposable)enumerator5).Dispose();
						}
					}
					if (dictionary.ContainsKey("AREA"))
					{
						try
						{
							List<ReferencePoint>.Enumerator enumerator6 = noNavZone.list_0.GetEnumerator();
							while (enumerator6.MoveNext())
							{
								PrivateMethods.Class503 class2 = new PrivateMethods.Class503(class2);
								class2.referencePoint_0 = enumerator6.Current;
								if (Enumerable.First<ReferencePoint>(list, new Func<ReferencePoint, bool>(class2.method_0)) == null)
								{
								}
							}
						}
						finally
						{
							List<ReferencePoint>.Enumerator enumerator6;
							((IDisposable)enumerator6).Dispose();
						}
						noNavZone.list_0 = list;
					}
					result = new LuaWrapper_Zone(noNavZone, scenario_0, side);
				}
				else
				{
					ExclusionZone exclusionZone = null;
					try
					{
						foreach (ExclusionZone exclusionZone2 in side.list_6)
						{
							if (Operators.CompareString(exclusionZone2.string_0, zone.string_2, false) == 0 || Operators.CompareString(exclusionZone2.Name, zone.string_2, false) == 0 || Operators.CompareString(exclusionZone2.string_2, zone.string_2, false) == 0)
							{
								exclusionZone = exclusionZone2;
								break;
							}
						}
					}
					finally
					{
						List<ExclusionZone>.Enumerator enumerator7;
						((IDisposable)enumerator7).Dispose();
					}
					if (Information.IsNothing(exclusionZone))
					{
						throw new Exception3("No exclusion zone exists with this name or ID.");
					}
					if (dictionary.ContainsKey("DESCRIPTION"))
					{
						exclusionZone.string_2 = zone.string_2;
					}
					if (dictionary.ContainsKey("ISACTIVE"))
					{
						exclusionZone.bool_11 = zone.bool_11;
					}
					if (dictionary.ContainsKey("RENAME"))
					{
						exclusionZone.string_2 = zone.Name;
					}
					if (dictionary.ContainsKey("AFFECTS"))
					{
						exclusionZone.vmethod_5(new ObservableList<GlobalVariables.ActiveUnitType>());
						try
						{
							foreach (GlobalVariables.ActiveUnitType gparam_2 in list2)
							{
								exclusionZone.vmethod_4().method_4(gparam_2);
							}
						}
						finally
						{
							List<GlobalVariables.ActiveUnitType>.Enumerator enumerator8;
							((IDisposable)enumerator8).Dispose();
						}
					}
					if (dictionary.ContainsKey("MARKAS"))
					{
						exclusionZone.postureStance_0 = postureStance_;
					}
					if (dictionary.ContainsKey("AREA"))
					{
						try
						{
							List<ReferencePoint>.Enumerator enumerator9 = exclusionZone.list_0.GetEnumerator();
							while (enumerator9.MoveNext())
							{
								PrivateMethods.Class504 class3 = new PrivateMethods.Class504(class3);
								class3.referencePoint_0 = enumerator9.Current;
								if (Enumerable.First<ReferencePoint>(list, new Func<ReferencePoint, bool>(class3.method_0)) == null)
								{
								}
							}
						}
						finally
						{
							List<ReferencePoint>.Enumerator enumerator9;
							((IDisposable)enumerator9).Dispose();
						}
						exclusionZone.list_0 = list;
					}
					result = new LuaWrapper_Zone(exclusionZone, scenario_0, side);
				}
				return result;
			}
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x0025AAA8 File Offset: 0x00258CA8
		public static LuaWrapper_Zone smethod_52(string string_0, int int_0, LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			string text = null;
			Side side = null;
			Zone zone = new Zone();
			new List<ReferencePoint>();
			new List<GlobalVariables.ActiveUnitType>();
			LuaUtility.smethod_5(ref dictionary);
			side = PrivateMethods.smethod_66(string_0, scenario_0);
			if (side == null)
			{
				throw new Exception3("Side " + text + " missing");
			}
			if (dictionary.ContainsKey("DESCRIPTION"))
			{
				text = Conversions.ToString(dictionary["DESCRIPTION"]);
				zone.string_2 = text;
			}
			LuaWrapper_Zone result;
			if (int_0 == 0)
			{
				NoNavZone noNavZone = null;
				try
				{
					foreach (NoNavZone noNavZone2 in side.list_7)
					{
						if (Operators.CompareString(noNavZone2.string_0, zone.string_2, false) == 0 || Operators.CompareString(noNavZone2.Name, zone.string_2, false) == 0 || Operators.CompareString(noNavZone2.string_2, zone.string_2, false) == 0)
						{
							noNavZone = noNavZone2;
							break;
						}
					}
				}
				finally
				{
					List<NoNavZone>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (Information.IsNothing(zone))
				{
					throw new Exception3("No no-nav zone exists with this name or ID.");
				}
				side.list_7.Remove(noNavZone);
				result = new LuaWrapper_Zone(noNavZone, scenario_0, side);
			}
			else
			{
				ExclusionZone exclusionZone = null;
				try
				{
					foreach (ExclusionZone exclusionZone2 in side.list_6)
					{
						if (Operators.CompareString(exclusionZone2.string_0, zone.string_2, false) == 0 || Operators.CompareString(exclusionZone2.Name, zone.string_2, false) == 0 || Operators.CompareString(exclusionZone2.string_2, zone.string_2, false) == 0)
						{
							exclusionZone = exclusionZone2;
							break;
						}
					}
				}
				finally
				{
					List<ExclusionZone>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				if (Information.IsNothing(zone))
				{
					throw new Exception3("No exclusion zone exists with this name or ID.");
				}
				side.list_6.Remove(exclusionZone);
				result = new LuaWrapper_Zone(exclusionZone, scenario_0, side);
			}
			return result;
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x0025ACAC File Offset: 0x00258EAC
		public static bool smethod_53(string string_0, string string_1, LuaTable luaTable_0, Scenario scenario_0)
		{
			bool result = false;
			List<Cargo> list = new List<Cargo>();
			string str = "";
			new List<ActiveUnit>();
			ActiveUnit activeUnit = null;
			ActiveUnit activeUnit2 = null;
			try
			{
				activeUnit = PrivateMethods.smethod_67(string_0, scenario_0);
				activeUnit2 = PrivateMethods.smethod_67(string_1, scenario_0);
			}
			catch (Exception ex)
			{
			}
			if (Information.IsNothing(activeUnit))
			{
				throw new Exception3("From unit not found!");
			}
			if (Information.IsNothing(activeUnit2))
			{
				throw new Exception3("To unit not found!");
			}
			switch (activeUnit2.vmethod_56())
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				if (!((Aircraft_AirOps)activeUnit2.vmethod_92()).method_68())
				{
					throw new Exception3("Unit not available: not parked!");
				}
				break;
			case GlobalVariables.ActiveUnitType.Ship:
			case GlobalVariables.ActiveUnitType.Submarine:
				if (!activeUnit2.vmethod_125(ref str))
				{
					throw new Exception3("Unit not available:" + str + "!");
				}
				break;
			}
			switch (activeUnit.vmethod_56())
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				if (!((Aircraft_AirOps)activeUnit.vmethod_92()).method_68())
				{
					throw new Exception3("Unit not available: not parked!");
				}
				break;
			case GlobalVariables.ActiveUnitType.Ship:
			case GlobalVariables.ActiveUnitType.Submarine:
				if (!activeUnit.vmethod_125(ref str))
				{
					throw new Exception3("Unit not available:" + str + "!");
				}
				break;
			}
			try
			{
				List<object> list2 = LuaUtility.smethod_0(luaTable_0.GetEnumerator());
				double num = 0.0;
				double num2 = 0.0;
				double num3 = 0.0;
				CargoType cargoType = CargoType.NoCargo;
				switch (activeUnit2.vmethod_56())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
				{
					Aircraft aircraft = (Aircraft)activeUnit2;
					num = (double)aircraft.imethod_3();
					num2 = (double)aircraft.imethod_1();
					num3 = (double)aircraft.imethod_0();
					cargoType = aircraft.imethod_2();
					break;
				}
				case GlobalVariables.ActiveUnitType.Ship:
				case GlobalVariables.ActiveUnitType.Submarine:
				{
					Ship ship = (Ship)activeUnit2;
					num = (double)ship.imethod_3();
					num2 = (double)ship.imethod_1();
					num3 = (double)ship.imethod_0();
					cargoType = ship.imethod_2();
					break;
				}
				case GlobalVariables.ActiveUnitType.Facility:
				{
					Facility facility = (Facility)activeUnit2;
					num = (double)facility.imethod_3();
					num2 = (double)facility.imethod_1();
					num3 = (double)facility.imethod_0();
					cargoType = facility.imethod_2();
					break;
				}
				}
				foreach (Cargo cargo in activeUnit2.cargo_0)
				{
					if (cargo.method_23() == Cargo.Enum111.const_1)
					{
						Mount mount = (Mount)cargo.method_25();
						if (mount.cargoType_0 <= cargoType)
						{
							num -= (double)mount.short_2;
							num2 -= (double)mount.short_1;
							num3 -= (double)mount.short_0;
						}
					}
				}
				try
				{
					foreach (object obj in list2)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						int num4 = 0;
						string text = null;
						int num5;
						if (objectValue is LuaTable)
						{
							List<object> list3 = LuaUtility.smethod_0(((LuaTable)objectValue).GetEnumerator());
							if (list3.Count == 1)
							{
								num4 = Conversions.ToInteger(list3[0]);
								num5 = 1;
							}
							else
							{
								num4 = Conversions.ToInteger(list3[1]);
								num5 = Conversions.ToInteger(list3[0]);
							}
						}
						else
						{
							text = Conversions.ToString(objectValue);
							num5 = 1;
						}
						if (num5 >= 1 && (num4 >= 1 || !Information.IsNothing(text)))
						{
							try
							{
								foreach (Cargo cargo2 in Enumerable.OrderBy<Cargo, int>(activeUnit.cargo_0, (PrivateMethods._Closure$__.$I69-0 == null) ? (PrivateMethods._Closure$__.$I69-0 = new Func<Cargo, int>(PrivateMethods._Closure$__.$I.method_8)) : PrivateMethods._Closure$__.$I69-0))
								{
									if (cargo2.method_23() == Cargo.Enum111.const_1)
									{
										Mount mount2 = (Mount)cargo2.method_25();
										if (mount2.cargoType_0 <= cargoType && (num4 <= 0 || mount2.DBID == num4) && (Information.IsNothing(text) || Operators.CompareString(text, cargo2.string_0, false) == 0))
										{
											if (num5 > 0 && (num >= (double)mount2.short_2 & num2 >= (double)mount2.short_1 & num3 >= (double)mount2.short_0))
											{
												list.Add(cargo2);
												num -= (double)mount2.short_2;
												num2 -= (double)mount2.short_1;
												num3 -= (double)mount2.short_0;
												num5--;
											}
											if (num5 < 1)
											{
												break;
											}
										}
									}
								}
							}
							finally
							{
								IEnumerator<Cargo> enumerator2;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
								}
							}
						}
					}
				}
				finally
				{
					List<object>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				int num6 = Enumerable.Count<Cargo>(activeUnit.cargo_0);
				if (list.Count > 0)
				{
					ActiveUnit_DockingOps.smethod_13(activeUnit, activeUnit2, list);
					if (activeUnit2 is Ship)
					{
						activeUnit2.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.Readying);
						activeUnit2.vmethod_93().method_1(Math.Max(activeUnit2.vmethod_93().method_0(), 1800f));
					}
					else if (activeUnit2 is Aircraft)
					{
						((Aircraft)activeUnit2).method_164().method_37(Aircraft_AirOps._AirOpsCondition.Readying);
						((Aircraft)activeUnit2).method_164().method_39(Math.Max(((Aircraft)activeUnit2).method_164().method_38(), 1800f));
					}
					if (num6 > Enumerable.Count<Cargo>(activeUnit.cargo_0))
					{
						result = true;
					}
				}
			}
			catch (Exception ex2)
			{
				throw;
			}
			return result;
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x0025B238 File Offset: 0x00259438
		public static bool smethod_54(string string_0, LuaTable luaTable_0, Scenario scenario_0)
		{
			bool result = false;
			List<Cargo> list = new List<Cargo>();
			ActiveUnit activeUnit = null;
			ActiveUnit activeUnit2 = null;
			try
			{
				activeUnit = PrivateMethods.smethod_67(string_0, scenario_0);
			}
			catch (Exception ex)
			{
			}
			if (Information.IsNothing(activeUnit))
			{
				throw new Exception3("From unit not found!");
			}
			if (!activeUnit.method_113())
			{
				throw new Exception3(activeUnit.Name + " has no onboard cargo!");
			}
			List<object> list2 = new List<object>();
			if (!Information.IsNothing(luaTable_0))
			{
				list2 = LuaUtility.smethod_0(luaTable_0.GetEnumerator());
			}
			try
			{
				if (list2.Count > 0)
				{
					try
					{
						foreach (object obj in list2)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(obj);
							int num = 0;
							string text = null;
							int num2;
							if (objectValue is LuaTable)
							{
								List<object> list3 = LuaUtility.smethod_0(((LuaTable)objectValue).GetEnumerator());
								if (list3.Count == 1)
								{
									num = Conversions.ToInteger(list3[0]);
									num2 = 1;
								}
								else
								{
									num = Conversions.ToInteger(list3[1]);
									num2 = Conversions.ToInteger(list3[0]);
								}
							}
							else
							{
								text = Conversions.ToString(objectValue);
								num2 = 1;
							}
							if (num2 >= 1 && (num >= 1 || !Information.IsNothing(text)))
							{
								try
								{
									foreach (Cargo cargo in Enumerable.OrderBy<Cargo, int>(activeUnit.cargo_0, (PrivateMethods._Closure$__.$I70-0 == null) ? (PrivateMethods._Closure$__.$I70-0 = new Func<Cargo, int>(PrivateMethods._Closure$__.$I.method_9)) : PrivateMethods._Closure$__.$I70-0))
									{
										if (cargo.method_23() == Cargo.Enum111.const_1)
										{
											Mount mount = (Mount)cargo.method_25();
											if ((num <= 0 || mount.DBID == num) && (Information.IsNothing(text) || Operators.CompareString(text, cargo.string_0, false) == 0))
											{
												if (num2 > 0)
												{
													list.Add(cargo);
													num2--;
												}
												if (num2 < 1)
												{
													break;
												}
											}
										}
									}
								}
								finally
								{
									IEnumerator<Cargo> enumerator2;
									if (enumerator2 != null)
									{
										enumerator2.Dispose();
									}
								}
							}
						}
						goto IL_201;
					}
					finally
					{
						List<object>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				list = (List<Cargo>)activeUnit.cargo_0.Clone();
				IL_201:
				if (activeUnit.bool_0)
				{
					if (activeUnit is Aircraft)
					{
						if (((Aircraft_AirOps)activeUnit2.vmethod_92()).method_68())
						{
							ActiveUnit activeUnit3 = activeUnit;
							List<Facility> list4 = Facility.smethod_10(Enumerable.ToList<Mount>(Enumerable.Select<Cargo, Mount>(list, (PrivateMethods._Closure$__.$I70-1 == null) ? (PrivateMethods._Closure$__.$I70-1 = new Func<Cargo, Mount>(PrivateMethods._Closure$__.$I.method_10)) : PrivateMethods._Closure$__.$I70-1)), activeUnit3.scenario_0, activeUnit3.vmethod_7(false));
							try
							{
								foreach (Facility facility in list4)
								{
									facility.vmethod_29(null, activeUnit3.vmethod_28(null));
									facility.vmethod_31(null, activeUnit3.vmethod_30(null));
								}
							}
							finally
							{
								List<Facility>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
							try
							{
								foreach (Cargo cargo2 in Enumerable.ToList<Cargo>(list))
								{
									if (Enumerable.Contains<Cargo>(activeUnit3.cargo_0, cargo2))
									{
										Class429.smethod_7(ref activeUnit3.cargo_0, cargo2);
									}
								}
								goto IL_4BD;
							}
							finally
							{
								List<Cargo>.Enumerator enumerator4;
								((IDisposable)enumerator4).Dispose();
							}
						}
						Aircraft aircraft = (Aircraft)activeUnit;
						if (aircraft.method_167().bool_15)
						{
							aircraft.method_164().method_88();
						}
						if (Enumerable.Count<Cargo>(aircraft.cargo_0) != 0 && aircraft.method_169())
						{
							aircraft.method_164().method_37(Aircraft_AirOps._AirOpsCondition.TransferringCargo);
							aircraft.method_164().method_39(120f);
						}
					}
					else
					{
						ActiveUnit activeUnit4 = activeUnit;
						string text2 = null;
						if (activeUnit4.vmethod_125(ref text2))
						{
							ActiveUnit activeUnit5 = activeUnit;
							List<Facility> list5 = Facility.smethod_10(Enumerable.ToList<Mount>(Enumerable.Select<Cargo, Mount>(list, (PrivateMethods._Closure$__.$I70-2 == null) ? (PrivateMethods._Closure$__.$I70-2 = new Func<Cargo, Mount>(PrivateMethods._Closure$__.$I.method_11)) : PrivateMethods._Closure$__.$I70-2)), activeUnit5.scenario_0, activeUnit5.vmethod_7(false));
							try
							{
								foreach (Facility facility2 in list5)
								{
									facility2.vmethod_29(null, activeUnit5.vmethod_28(null));
									facility2.vmethod_31(null, activeUnit5.vmethod_30(null));
								}
							}
							finally
							{
								List<Facility>.Enumerator enumerator5;
								((IDisposable)enumerator5).Dispose();
							}
							try
							{
								foreach (Cargo cargo3 in Enumerable.ToList<Cargo>(list))
								{
									if (Enumerable.Contains<Cargo>(activeUnit5.cargo_0, cargo3))
									{
										Class429.smethod_7(ref activeUnit5.cargo_0, cargo3);
									}
								}
								goto IL_4BD;
							}
							finally
							{
								List<Cargo>.Enumerator enumerator6;
								((IDisposable)enumerator6).Dispose();
							}
						}
						if (activeUnit is Ship)
						{
							activeUnit.vmethod_93().method_20();
						}
					}
				}
				IL_4BD:
				result = true;
			}
			catch (Exception ex2)
			{
				throw;
			}
			return result;
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x0025B7D4 File Offset: 0x002599D4
		public static LuaTable smethod_55(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			LuaUtility.smethod_5(ref dictionary);
			if (dictionary.ContainsKey("GUID"))
			{
				string text;
				try
				{
					text = Conversions.ToString(dictionary["GUID"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.vmethod_0()[text];
					goto IL_1AB;
				}
				catch (Exception ex2)
				{
					throw new Exception3("Can't find guid " + text);
				}
			}
			if (dictionary.ContainsKey("UNITNAME"))
			{
				PrivateMethods.Class505 @class = new PrivateMethods.Class505(@class);
				try
				{
					@class.string_0 = Conversions.ToString(dictionary["UNITNAME"]);
				}
				catch (Exception ex3)
				{
					throw new Exception3("name must be a string");
				}
				if (dictionary.ContainsKey("SIDE"))
				{
					string text2;
					try
					{
						text2 = Conversions.ToString(dictionary["SIDE"]);
					}
					catch (Exception ex4)
					{
						throw new Exception3("side must be a string");
					}
					Side side;
					try
					{
						side = LuaUtility.smethod_16(dictionary, scenario_0);
					}
					catch (Exception ex5)
					{
						throw new Exception3("Can't find Side '" + text2 + "'");
					}
					try
					{
						activeUnit = Enumerable.First<ActiveUnit>(side.activeUnit_0, new Func<ActiveUnit, bool>(@class.method_0));
						goto IL_1AB;
					}
					catch (Exception ex6)
					{
						throw new Exception3(string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text2,
							"'"
						}));
					}
				}
				try
				{
					activeUnit = Enumerable.First<ActiveUnit>(scenario_0.method_42(), new Func<ActiveUnit, bool>(@class.method_1));
				}
				catch (Exception ex7)
				{
					throw new Exception3("Can't find Unit '" + @class.string_0 + "'");
				}
			}
			IL_1AB:
			if (activeUnit == null)
			{
				throw new Exception3("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
			}
			if (!activeUnit.bool_1)
			{
				throw new Exception3("Unit needs to be a group.");
			}
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			Group group = (Group)activeUnit;
			ActiveUnit activeUnit_ = group.method_147();
			try
			{
				foreach (ActiveUnit activeUnit2 in group.vmethod_141().Values)
				{
					if (!activeUnit2.method_122())
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						ActiveUnit_Navigator.Class216 class2 = activeUnit2.vmethod_85().method_2();
						luaTable2["guid"] = activeUnit2.string_0;
						luaTable2["bearing"] = class2.float_0;
						luaTable2["type"] = class2.orientationType_0.ToString();
						luaTable2["distance"] = class2.float_1;
						luaTable2["sprint"] = activeUnit2.vmethod_85().vmethod_3().ToString();
						Tuple<double, double> tuple = class2.method_0(activeUnit2, activeUnit_);
						luaTable2["latitude"] = tuple.Item1;
						luaTable2["longitude"] = tuple.Item2;
						luaTable[luaTable.Keys.Count.ToString()] = luaTable2;
					}
					else
					{
						luaTable["lead"] = activeUnit2.string_0;
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
			return luaTable;
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x0025BBE4 File Offset: 0x00259DE4
		public static LuaTable smethod_56(Scenario scenario_0)
		{
			Side side = scenario_0.method_54();
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
			LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
			if (side.method_56().Count > 0)
			{
				try
				{
					foreach (Unit unit in side.method_56())
					{
						LuaTable luaTable4 = LuaSandBox.Singleton().CreateTable();
						luaTable4["name"] = unit.Name;
						luaTable4["guid"] = unit.string_0;
						if (unit.method_14())
						{
							luaTable3[luaTable3.Keys.Count + 1] = luaTable4;
						}
						else if (unit.bool_0)
						{
							luaTable2[luaTable2.Keys.Count + 1] = luaTable4;
						}
					}
				}
				finally
				{
					IEnumerator<Unit> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			if (luaTable2.Keys.Count > 0)
			{
				luaTable["units"] = luaTable2;
			}
			if (luaTable3.Keys.Count > 0)
			{
				luaTable["contacts"] = luaTable3;
			}
			return luaTable;
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x0025BD20 File Offset: 0x00259F20
		public static LuaTable smethod_57(LuaTable luaTable_0, Scenario scenario_0)
		{
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			LuaTable result;
			try
			{
				Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
				ActiveUnit activeUnit = null;
				Side side = null;
				DateTime dateTime_ = scenario_0.method_31();
				LuaUtility.smethod_5(ref dictionary);
				if (dictionary.ContainsKey("DATE"))
				{
					string text = Conversions.ToString(dictionary["DATE"]);
					string value = string.Empty;
					if (text.Contains(":"))
					{
						value = ":";
					}
					else if (text.Contains("."))
					{
						value = ".";
					}
					if (string.IsNullOrEmpty(value))
					{
						throw new Exception3("Error in parsing provided date value: " + text + " - The delimiter must be either (.) or (:)");
					}
					int month;
					int day;
					int year;
					try
					{
						month = Conversions.ToInteger(text.Split(new char[]
						{
							Conversions.ToChar(value)
						})[0]);
						day = Conversions.ToInteger(text.Split(new char[]
						{
							Conversions.ToChar(value)
						})[1]);
						year = Conversions.ToInteger(text.Split(new char[]
						{
							Conversions.ToChar(value)
						})[2]);
					}
					catch (Exception ex)
					{
						throw new Exception3("Error in parsing provided date value: " + text + " - Error: " + ex.Message);
					}
					dateTime_ = new DateTime(year, month, day, dateTime_.Hour, dateTime_.Minute, dateTime_.Second);
				}
				if (dictionary.ContainsKey("TIME"))
				{
					string text2 = Conversions.ToString(dictionary["TIME"]);
					string value2 = string.Empty;
					if (text2.Contains(":"))
					{
						value2 = ":";
					}
					else if (text2.Contains("."))
					{
						value2 = ".";
					}
					if (string.IsNullOrEmpty(value2))
					{
						throw new Exception3("Error in parsing provided time value: " + text2 + " - The delimiter must be either (.) or (:)");
					}
					int hour;
					int minute;
					int second;
					try
					{
						hour = Conversions.ToInteger(text2.Split(new char[]
						{
							Conversions.ToChar(value2)
						})[0]);
						minute = Conversions.ToInteger(text2.Split(new char[]
						{
							Conversions.ToChar(value2)
						})[1]);
						second = Conversions.ToInteger(text2.Split(new char[]
						{
							Conversions.ToChar(value2)
						})[2]);
					}
					catch (Exception ex2)
					{
						throw new Exception3("Error in parsing provided time value: " + text2 + " - Error: " + ex2.Message);
					}
					dateTime_ = new DateTime(dateTime_.Year, dateTime_.Month, dateTime_.Day, hour, minute, second);
				}
				if (dictionary.ContainsKey("GUID"))
				{
					string text3;
					try
					{
						text3 = Conversions.ToString(dictionary["GUID"]);
					}
					catch (Exception ex3)
					{
						throw new Exception3("guid must be a string");
					}
					try
					{
						activeUnit = scenario_0.vmethod_0()[text3];
						goto IL_3D8;
					}
					catch (Exception ex4)
					{
						throw new Exception3("Can't find guid " + text3);
					}
				}
				if (dictionary.ContainsKey("UNITNAME"))
				{
					PrivateMethods.Class506 @class = new PrivateMethods.Class506();
					try
					{
						@class.string_0 = Conversions.ToString(dictionary["UNITNAME"]);
					}
					catch (Exception ex5)
					{
						throw new Exception3("name must be a string");
					}
					if (dictionary.ContainsKey("SIDE"))
					{
						string text4;
						try
						{
							text4 = Conversions.ToString(dictionary["SIDE"]);
						}
						catch (Exception ex6)
						{
							throw new Exception3("side must be a string");
						}
						try
						{
							side = LuaUtility.smethod_16(dictionary, scenario_0);
						}
						catch (Exception ex7)
						{
							throw new Exception3("Can't find Side '" + text4 + "'");
						}
						try
						{
							activeUnit = Enumerable.First<ActiveUnit>(side.activeUnit_0, new Func<ActiveUnit, bool>(@class.method_0));
						}
						catch (Exception ex8)
						{
							throw new Exception3(string.Concat(new string[]
							{
								"Can't find Unit '",
								@class.string_0,
								"' on Side '",
								text4,
								"'"
							}));
						}
						dictionary["GUID"] = activeUnit.string_0;
					}
				}
				IL_3D8:
				if (activeUnit != null)
				{
					dictionary["LATITUDE"] = activeUnit.vmethod_30(null);
					dictionary["LONGITUDE"] = activeUnit.vmethod_28(null);
				}
				double? num = LuaUtility.smethod_11(dictionary);
				if (num == null)
				{
					throw new Exception3("Missing 'Latitude'");
				}
				double? num2 = LuaUtility.smethod_13(dictionary);
				if (num2 == null)
				{
					throw new Exception3("Missing 'Longitude'");
				}
				bool bool_ = scenario_0.method_33();
				string string_ = scenario_0.method_35();
				string string_2 = scenario_0.method_37();
				string value3 = Misc.smethod_10(dateTime_, num2.Value, bool_, string_, string_2).ToShortTimeString();
				Weather.TTimeOfDayType ttimeOfDayType = Class418.smethod_1(scenario_0, dateTime_.Year, dateTime_.Month, dateTime_.Day, dateTime_.Hour, dateTime_.Minute, dateTime_.Second, false, num.Value, num2.Value, 0.0);
				switch (ttimeOfDayType)
				{
				case Weather.TTimeOfDayType.const_0:
					luaTable["tod"] = (int)ttimeOfDayType;
					luaTable["TOD"] = "day";
					break;
				case Weather.TTimeOfDayType.const_1:
					if (Misc.smethod_10(dateTime_, num2.Value, bool_, string_, string_2).Hour < 12)
					{
						luaTable["tod"] = 3;
						luaTable["TOD"] = "dawn";
					}
					else
					{
						luaTable["tod"] = 4;
						luaTable["TOD"] = "dusk";
					}
					break;
				case Weather.TTimeOfDayType.const_2:
					luaTable["tod"] = (int)ttimeOfDayType;
					luaTable["TOD"] = "night";
					break;
				}
				luaTable["localtime"] = value3;
				luaTable["zulutime"] = string.Concat(new string[]
				{
					dateTime_.Hour.ToString("D2"),
					":",
					dateTime_.Minute.ToString("D2"),
					":",
					dateTime_.Second.ToString("D2")
				});
				result = luaTable;
			}
			catch (Exception ex9)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x0025C43C File Offset: 0x0025A63C
		public static object smethod_58(string string_0, int int_0, Scenario scenario_0)
		{
			try
			{
				string text = string_0.ToLower();
				uint num = Class582.smethod_0(text);
				if (num <= 1992176343U)
				{
					if (num <= 1813408442U)
					{
						if (num != 1341832056U)
						{
							if (num == 1813408442U)
							{
								if (Operators.CompareString(text, "mount", false) == 0)
								{
									return new Class488(DBFunctions.smethod_110(int_0, ref scenario_0, false), scenario_0);
								}
							}
						}
						else if (Operators.CompareString(text, "facility", false) == 0)
						{
							Facility facility = new Facility(ref scenario_0, "");
							DBFunctions.smethod_57(ref scenario_0, ref facility, int_0, true);
						}
					}
					else if (num != 1865621569U)
					{
						if (num == 1992176343U)
						{
							if (Operators.CompareString(text, "submarine", false) == 0)
							{
								Submarine submarine = new Submarine(ref scenario_0, "");
								DBFunctions.smethod_55(ref scenario_0, ref submarine, int_0, true);
							}
						}
					}
					else if (Operators.CompareString(text, "weapon", false) == 0)
					{
						Weapon weapon = Weapon.smethod_16(ref scenario_0, int_0, null);
						DBFunctions.smethod_60(scenario_0.method_39(), weapon, int_0, scenario_0, false);
						return new Class486(weapon, scenario_0);
					}
				}
				else if (num <= 2891379071U)
				{
					if (num != 2209756795U)
					{
						if (num == 2891379071U)
						{
							if (Operators.CompareString(text, "ship", false) == 0)
							{
								Ship ship = new Ship(ref scenario_0, "");
								DBFunctions.smethod_53(ref scenario_0, ref ship, int_0, true);
							}
						}
					}
					else if (Operators.CompareString(text, "sensor", false) == 0)
					{
						SQLiteConnection sqliteConnection = scenario_0.method_39();
						return new Class487(DBFunctions.smethod_97(int_0, ref sqliteConnection), scenario_0);
					}
				}
				else if (num != 3200167146U)
				{
					if (num == 4136019571U && Operators.CompareString(text, "aircraft", false) == 0)
					{
						Aircraft aircraft = new Aircraft(ref scenario_0, "");
						DBFunctions.smethod_19(ref scenario_0, ref aircraft, int_0, true);
					}
				}
				else if (Operators.CompareString(text, "satellite", false) == 0)
				{
					Satellite satellite = new Satellite(ref scenario_0, null);
					DBFunctions.smethod_74(ref scenario_0, ref satellite, int_0, 0, true);
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
			return null;
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x0025C65C File Offset: 0x0025A85C
		public static LuaWrapper_ActiveUnit smethod_59(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			string text = null;
			string text2 = null;
			LuaUtility.smethod_5(ref dictionary);
			if (dictionary.ContainsKey("GUID"))
			{
				try
				{
					text2 = Conversions.ToString(dictionary["GUID"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.vmethod_0()[text2];
					goto IL_130;
				}
				catch (Exception ex2)
				{
					throw new Exception3("Can't find guid " + text2);
				}
			}
			if (dictionary.ContainsKey("UNITNAME"))
			{
				try
				{
					text = Conversions.ToString(dictionary["UNITNAME"]);
				}
				catch (Exception ex3)
				{
					throw new Exception3("name must be a string");
				}
				try
				{
					foreach (ActiveUnit activeUnit2 in scenario_0.method_42())
					{
						if (Operators.CompareString(activeUnit2.Name.ToUpper(), text.ToUpper(), false) == 0 || Operators.CompareString(activeUnit2.string_0.ToUpper(), text.ToUpper(), false) == 0)
						{
							activeUnit = activeUnit2;
							break;
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (Information.IsNothing(activeUnit))
				{
					throw new Exception3("Unable to find unit matching name: " + text);
				}
			}
			IL_130:
			if (activeUnit == null)
			{
				Contact contact = null;
				if (text2 != null)
				{
					string nameOrId = text2;
					Side side = null;
					contact = LuaUtility.smethod_31(nameOrId, scenario_0, ref side);
				}
				else if (text != null)
				{
					string nameOrId2 = text;
					Side side = null;
					contact = LuaUtility.smethod_31(nameOrId2, scenario_0, ref side);
				}
				if (contact != null)
				{
					activeUnit = contact.activeUnit_0;
				}
			}
			if (Information.IsNothing(activeUnit))
			{
				throw new Exception3("Unable to find unit");
			}
			return new LuaWrapper_ActiveUnit(activeUnit, scenario_0);
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x0025C820 File Offset: 0x0025AA20
		public static LuaWrapper_Contact smethod_60(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			Contact contact = null;
			Side fromSide = null;
			if (dictionary.ContainsKey("GUID"))
			{
				string text;
				try
				{
					text = Conversions.ToString(dictionary["GUID"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("guid must be a string");
				}
				bool flag = false;
				try
				{
					foreach (Side side in scenario_0.method_44())
					{
						if (flag)
						{
							break;
						}
						try
						{
							foreach (Contact contact2 in side.method_44())
							{
								if (Operators.CompareString(contact2.string_0, text.ToLower(), false) == 0)
								{
									fromSide = side;
									contact = contact2;
									flag = true;
									break;
								}
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (flag)
						{
							break;
						}
						try
						{
							foreach (string text2 in side.lazy_0.Value.Keys)
							{
								Contact contact3 = side.lazy_0.Value[text2];
								if (Operators.CompareString(contact3.string_0.ToLower(), text.ToLower(), false) == 0)
								{
									fromSide = side;
									contact = contact3;
									flag = true;
									break;
								}
							}
						}
						finally
						{
							IEnumerator<string> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
					}
				}
				catch (Exception ex2)
				{
					throw new Exception3("Can't find guid " + text);
				}
			}
			if (Information.IsNothing(contact))
			{
				throw new Exception3("Unable to find contact");
			}
			return new LuaWrapper_Contact(contact, scenario_0, fromSide);
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x0025CA0C File Offset: 0x0025AC0C
		public static LuaWrapper_Side smethod_61(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			Side side = null;
			LuaUtility.smethod_6(ref dictionary);
			checked
			{
				if (dictionary.ContainsKey("GUID"))
				{
					string text;
					try
					{
						text = Conversions.ToString(dictionary["GUID"]);
					}
					catch (Exception ex)
					{
						throw new Exception3("guid must be a string");
					}
					Side[] array = scenario_0.method_44();
					int i = 0;
					while (i < array.Length)
					{
						Side side2 = array[i];
						if (Operators.CompareString(side2.string_0, text.ToLower(), false) != 0)
						{
							i++;
						}
						else
						{
							side = side2;
							IL_81:
							if (Information.IsNothing(side))
							{
								throw new Exception3("Unable to find side matching guid:  " + text);
							}
							goto IL_EF;
						}
					}
					goto IL_81;
				}
				if (dictionary.ContainsKey("SIDE"))
				{
					string str;
					try
					{
						str = Conversions.ToString(dictionary["SIDE"]);
					}
					catch (Exception ex2)
					{
						throw new Exception3("name must be a string");
					}
					side = LuaUtility.smethod_16(dictionary, scenario_0);
					if (Information.IsNothing(side))
					{
						throw new Exception3("Unable to find side matching name: " + str);
					}
				}
				IL_EF:
				if (Information.IsNothing(side))
				{
					throw new Exception3("Unable to find side");
				}
				return new LuaWrapper_Side(side, scenario_0);
			}
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x0025CB40 File Offset: 0x0025AD40
		public static bool smethod_62(LuaTable luaTable_0, string string_0, Scenario scenario_0)
		{
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			Side side = null;
			new HashSet<string>();
			List<GlobalVariables.ActiveUnitType> list = new List<GlobalVariables.ActiveUnitType>();
			List<int> list2 = new List<int>();
			List<int> list3 = new List<int>();
			List<string> list4 = new List<string>();
			string text = null;
			LuaUtility.smethod_5(ref dictionary);
			if (dictionary.ContainsKey("TARGETSIDE"))
			{
				try
				{
					text = Conversions.ToString(dictionary["TARGETSIDE"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("name must be a string");
				}
				side = PrivateMethods.smethod_66(text, scenario_0);
				if (Information.IsNothing(side))
				{
					throw new Exception3("Unable to find side matching name: " + text);
				}
			}
			checked
			{
				if (dictionary.ContainsKey("TARGETTYPE"))
				{
					List<object> list5 = LuaUtility.smethod_0(((LuaTable)dictionary["TARGETTYPE"]).GetEnumerator());
					try
					{
						foreach (object obj in list5)
						{
							string text2 = Conversions.ToString(RuntimeHelpers.GetObjectValue(obj)).ToLower();
							byte[] array = (byte[])Enum.GetValues(typeof(GlobalVariables.ActiveUnitType));
							int i = 0;
							while (i < array.Length)
							{
								byte b = array[i];
								if (Operators.CompareString(text2, b.ToString().ToLower(), false) != 0)
								{
									string left = text2;
									GlobalVariables.ActiveUnitType activeUnitType = (GlobalVariables.ActiveUnitType)b;
									if (Operators.CompareString(left, activeUnitType.ToString().ToLower(), false) != 0)
									{
										i++;
										continue;
									}
								}
								list.Add((GlobalVariables.ActiveUnitType)b);
								break;
							}
						}
					}
					finally
					{
						List<object>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (dictionary.ContainsKey("TARGETSUBTYPE"))
				{
					List<object> list6 = LuaUtility.smethod_0(((LuaTable)dictionary["TARGETSUBTYPE"]).GetEnumerator());
					try
					{
						foreach (object obj2 in list6)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(obj2);
							list2.Add(Conversions.ToInteger(objectValue));
						}
					}
					finally
					{
						List<object>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				if (dictionary.ContainsKey("SPECIFICUNITCLASS"))
				{
					List<object> list7 = LuaUtility.smethod_0(((LuaTable)dictionary["SPECIFICUNITCLASS"]).GetEnumerator());
					try
					{
						foreach (object obj3 in list7)
						{
							object objectValue2 = RuntimeHelpers.GetObjectValue(obj3);
							list3.Add(Conversions.ToInteger(objectValue2));
						}
					}
					finally
					{
						List<object>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				if (dictionary.ContainsKey("SPECIFICUNIT"))
				{
					List<object> list8 = LuaUtility.smethod_0(((LuaTable)dictionary["SPECIFICUNIT"]).GetEnumerator());
					try
					{
						foreach (object obj4 in list8)
						{
							object objectValue3 = RuntimeHelpers.GetObjectValue(obj4);
							list4.Add(Conversions.ToString(objectValue3));
						}
					}
					finally
					{
						List<object>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
				xmlWriterSettings.Indent = true;
				xmlWriterSettings.IndentChars = "    ";
				xmlWriterSettings.ConformanceLevel = ConformanceLevel.Auto;
				string text3 = GameGeneral.string_4;
				string str = text3 + "\\" + string_0;
				if (scenario_0.method_16())
				{
					List<string> list9 = new List<string>();
					Class264.smethod_3(GameGeneral.string_4, list9);
					try
					{
						foreach (string text4 in list9)
						{
							if (Operators.CompareString(Class264.smethod_1(text4).string_0, scenario_0.CampaignID, false) == 0)
							{
								str = Path.Combine(text3 = Path.GetDirectoryName(text4), scenario_0.CampaignSessionID) + scenario_0.method_2();
								break;
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				MemoryStream memoryStream = new MemoryStream();
				XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
				string str2 = string.Concat(new string[]
				{
					"Scenario: ",
					scenario_0.method_0(),
					"\r\nScenario file: ",
					text3,
					"\\",
					scenario_0.FileName,
					".scen"
				});
				StreamWriter streamWriter = File.AppendText(Class160.smethod_1().Info.DirectoryPath + "\\Logs\\LuaExport.txt");
				streamWriter.Write("\r\n\r\n" + str2);
				DBOps.DBFileCheckResult dbfileCheckResult;
				DBRecord dbrecord = DBOps.smethod_10(scenario_0.method_7(), ref dbfileCheckResult, true, true);
				xmlWriter.WriteStartElement("ContentScenario");
				xmlWriter.WriteElementString("CampaignID", scenario_0.CampaignID);
				xmlWriter.WriteElementString("CampaignSessionID", scenario_0.CampaignSessionID);
				xmlWriter.WriteElementString("CampaignScore", scenario_0.CampaignScore.ToString());
				xmlWriter.WriteElementString("DBused", scenario_0.method_7());
				xmlWriter.WriteElementString("DBfilename", dbrecord.string_2);
				xmlWriter.WriteElementString("ScenarioID", scenario_0.method_2());
				xmlWriter.WriteElementString("Title", scenario_0.method_0());
				xmlWriter.WriteElementString("Description", scenario_0.method_4());
				xmlWriter.WriteElementString("FileName", scenario_0.FileName);
				xmlWriter.WriteStartElement("ActiveUnits");
				try
				{
					foreach (ActiveUnit activeUnit in scenario_0.method_42())
					{
						ActiveUnit activeUnit2 = null;
						if (!activeUnit.bool_1)
						{
							bool flag = false;
							bool? flag2 = null;
							if (!Information.IsNothing(side))
							{
								if (activeUnit.vmethod_7(false).Equals(side))
								{
									flag2 = new bool?(true);
								}
								else
								{
									flag2 = new bool?(false);
								}
							}
							if (list.Count > 0)
							{
								try
								{
									List<GlobalVariables.ActiveUnitType>.Enumerator enumerator7 = list.GetEnumerator();
									while (enumerator7.MoveNext())
									{
										if (enumerator7.Current == activeUnit.vmethod_56())
										{
											flag = true;
											break;
										}
									}
									goto IL_131C;
								}
								finally
								{
									List<GlobalVariables.ActiveUnitType>.Enumerator enumerator7;
									((IDisposable)enumerator7).Dispose();
								}
								goto Block_41;
							}
							goto IL_131C;
							IL_5B1:
							if (list3.Count > 0)
							{
								try
								{
									List<int>.Enumerator enumerator8 = list3.GetEnumerator();
									while (enumerator8.MoveNext())
									{
										if (enumerator8.Current == activeUnit.DBID)
										{
											flag = true;
											break;
										}
									}
								}
								finally
								{
									List<int>.Enumerator enumerator8;
									((IDisposable)enumerator8).Dispose();
								}
							}
							if (list4.Count > 0)
							{
								try
								{
									List<string>.Enumerator enumerator9 = list4.GetEnumerator();
									while (enumerator9.MoveNext())
									{
										if (Operators.CompareString(enumerator9.Current, activeUnit.string_0, false) == 0)
										{
											flag = true;
											break;
										}
									}
								}
								finally
								{
									List<string>.Enumerator enumerator9;
									((IDisposable)enumerator9).Dispose();
								}
							}
							if (!flag)
							{
								if (activeUnit.bool_3)
								{
									Aircraft_AirOps aircraft_AirOps = (Aircraft_AirOps)activeUnit.vmethod_92();
									if (aircraft_AirOps.method_30() != null)
									{
										activeUnit2 = aircraft_AirOps.method_30();
									}
									else if (aircraft_AirOps.method_21() != null)
									{
										activeUnit2 = aircraft_AirOps.method_21();
									}
								}
								if (activeUnit.bool_6 || activeUnit.bool_5)
								{
									ActiveUnit_DockingOps activeUnit_DockingOps = activeUnit.vmethod_93();
									if (activeUnit_DockingOps.method_17() != null && Operators.CompareString(activeUnit_DockingOps.method_17().string_0, activeUnit.string_0, false) == 0)
									{
										activeUnit2 = activeUnit_DockingOps.method_17();
									}
									else if (activeUnit_DockingOps.method_2() != null && Operators.CompareString(activeUnit_DockingOps.method_2().string_0, activeUnit.string_0, false) == 0)
									{
										activeUnit2 = activeUnit_DockingOps.method_2();
									}
								}
								if (activeUnit2 != null)
								{
									if (list.Count > 0)
									{
										try
										{
											List<GlobalVariables.ActiveUnitType>.Enumerator enumerator10 = list.GetEnumerator();
											while (enumerator10.MoveNext())
											{
												if (enumerator10.Current == activeUnit2.vmethod_56())
												{
													flag = true;
													break;
												}
											}
										}
										finally
										{
											List<GlobalVariables.ActiveUnitType>.Enumerator enumerator10;
											((IDisposable)enumerator10).Dispose();
										}
									}
									if (list2.Count > 0)
									{
										try
										{
											List<int>.Enumerator enumerator11 = list2.GetEnumerator();
											while (enumerator11.MoveNext())
											{
												if (enumerator11.Current == activeUnit2.vmethod_57())
												{
													flag = true;
													break;
												}
											}
										}
										finally
										{
											List<int>.Enumerator enumerator11;
											((IDisposable)enumerator11).Dispose();
										}
									}
									if (list3.Count > 0)
									{
										try
										{
											List<int>.Enumerator enumerator12 = list3.GetEnumerator();
											while (enumerator12.MoveNext())
											{
												if (enumerator12.Current == activeUnit2.DBID)
												{
													flag = true;
													break;
												}
											}
										}
										finally
										{
											List<int>.Enumerator enumerator12;
											((IDisposable)enumerator12).Dispose();
										}
									}
									if (list4.Count > 0)
									{
										try
										{
											List<string>.Enumerator enumerator13 = list4.GetEnumerator();
											while (enumerator13.MoveNext())
											{
												if (Operators.CompareString(enumerator13.Current, activeUnit2.string_0, false) == 0)
												{
													flag = true;
													break;
												}
											}
										}
										finally
										{
											List<string>.Enumerator enumerator13;
											((IDisposable)enumerator13).Dispose();
										}
									}
								}
							}
							bool? flag3;
							bool? flag4;
							if (!flag)
							{
								flag3 = new bool?(false);
							}
							else if (!Information.IsNothing(flag2))
							{
								flag4 = flag2;
								flag3 = ((flag4 != null) ? new bool?(flag4.GetValueOrDefault()) : null);
							}
							else
							{
								flag3 = new bool?(true);
							}
							flag4 = flag3;
							if (flag4.GetValueOrDefault())
							{
								xmlWriter.WriteStartElement("ActiveUnit");
								xmlWriter.WriteElementString("ID", activeUnit.string_0);
								xmlWriter.WriteElementString("Name", activeUnit.Name);
								xmlWriter.WriteComment(string.Concat(new string[]
								{
									activeUnit.Name,
									" (",
									activeUnit.string_2,
									" [",
									Conversions.ToString(activeUnit.DBID),
									"])"
								}));
								xmlWriter.WriteElementString("DBID", activeUnit.DBID.ToString());
								xmlWriter.WriteElementString("UnitSubtype", activeUnit.vmethod_57().ToString());
								xmlWriter.WriteElementString("UnitType", activeUnit.vmethod_56().ToString());
								xmlWriter.WriteElementString("SideName", activeUnit.vmethod_7(false).method_51());
								if (activeUnit2 != null)
								{
									xmlWriter.WriteElementString("Hosted", activeUnit2.string_0);
								}
								int num;
								Class559.smethod_4(activeUnit, activeUnit.scenario_0, xmlWriter, streamWriter, ref num);
								xmlWriter.WriteStartElement("Damage");
								if (activeUnit.vmethod_63(false, null) != (float)activeUnit.method_60())
								{
									xmlWriter.WriteElementString("DamagePts", XmlConvert.ToString(activeUnit.vmethod_63(false, null)));
								}
								if (activeUnit.vmethod_91().vmethod_3() > ActiveUnit_Damage.FireIntensityLevel.NoFire)
								{
									xmlWriter.WriteElementString("Fire", ((byte)activeUnit.vmethod_91().vmethod_3()).ToString());
								}
								if (activeUnit.vmethod_91().vmethod_1() > ActiveUnit_Damage.FloodingIntensityLevel.NoFlooding)
								{
									xmlWriter.WriteElementString("Flood", ((byte)activeUnit.vmethod_91().vmethod_1()).ToString());
								}
								switch (activeUnit.vmethod_56())
								{
								case GlobalVariables.ActiveUnitType.Ship:
								{
									Ship ship = (Ship)activeUnit;
									if (ship.class345_0.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
									{
										xmlWriter.WriteElementString("CIC_St", ((byte)ship.class345_0.vmethod_5()).ToString());
									}
									if (ship.class345_0.method_16() != PlatformComponent._DamageSeverityFactor.Light)
									{
										xmlWriter.WriteElementString("CIC_DamageSeverity", ((byte)ship.class345_0.method_16()).ToString());
									}
									if (ship.class347_0.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
									{
										xmlWriter.WriteElementString("Rudder_St", ((byte)ship.class347_0.vmethod_5()).ToString());
									}
									if (ship.class347_0.method_16() != PlatformComponent._DamageSeverityFactor.Light)
									{
										xmlWriter.WriteElementString("Rudder_DamageSeverity", ((byte)ship.class347_0.method_16()).ToString());
									}
									break;
								}
								case GlobalVariables.ActiveUnitType.Submarine:
								{
									Submarine submarine = (Submarine)activeUnit;
									if (submarine.class345_0.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
									{
										xmlWriter.WriteElementString("CIC_St", ((byte)submarine.class345_0.vmethod_5()).ToString());
									}
									if (submarine.class345_0.method_16() != PlatformComponent._DamageSeverityFactor.Light)
									{
										xmlWriter.WriteElementString("CIC_DamageSeverity", ((byte)submarine.class345_0.method_16()).ToString());
									}
									if (submarine.class347_0.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
									{
										xmlWriter.WriteElementString("Rudder_St", ((byte)submarine.class347_0.vmethod_5()).ToString());
									}
									if (submarine.class347_0.method_16() != PlatformComponent._DamageSeverityFactor.Light)
									{
										xmlWriter.WriteElementString("Rudder_DamageSeverity", ((byte)submarine.class347_0.method_16()).ToString());
									}
									if (submarine.class346_0.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
									{
										xmlWriter.WriteElementString("PressureHull_St", ((byte)submarine.class346_0.vmethod_5()).ToString());
									}
									if (submarine.class346_0.method_16() != PlatformComponent._DamageSeverityFactor.Light)
									{
										xmlWriter.WriteElementString("PressureHull_DamageSeverity", ((byte)submarine.class346_0.method_16()).ToString());
									}
									if (submarine.cargo_1.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
									{
										xmlWriter.WriteElementString("Cargo_St", ((byte)submarine.cargo_1.vmethod_5()).ToString());
									}
									if (submarine.cargo_1.method_16() != PlatformComponent._DamageSeverityFactor.Light)
									{
										xmlWriter.WriteElementString("Cargo_DamageSeverity", ((byte)submarine.cargo_1.method_16()).ToString());
									}
									break;
								}
								case GlobalVariables.ActiveUnitType.Facility:
								{
									Facility facility = (Facility)activeUnit;
									if (facility.class345_0.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
									{
										xmlWriter.WriteElementString("CIC_St", ((byte)facility.class345_0.vmethod_5()).ToString());
									}
									if (facility.class345_0.method_16() != PlatformComponent._DamageSeverityFactor.Light)
									{
										xmlWriter.WriteElementString("CIC_DamageSeverity", ((byte)facility.class345_0.method_16()).ToString());
									}
									if (facility.cargo_1.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
									{
										xmlWriter.WriteElementString("Cargo_St", ((byte)facility.cargo_1.vmethod_5()).ToString());
									}
									if (facility.cargo_1.method_16() != PlatformComponent._DamageSeverityFactor.Light)
									{
										xmlWriter.WriteElementString("Cargo_DamageSeverity", ((byte)facility.cargo_1.method_16()).ToString());
									}
									break;
								}
								}
								xmlWriter.WriteStartElement("Sensors");
								foreach (Sensor sensor in activeUnit.vmethod_96())
								{
									if (sensor.vmethod_5() != PlatformComponent._ComponentStatus.Operational || sensor.method_16() != PlatformComponent._DamageSeverityFactor.Light)
									{
										xmlWriter.WriteStartElement("Sensor");
										xmlWriter.WriteElementString("ID", sensor.string_0);
										xmlWriter.WriteElementString("Name", sensor.Name);
										xmlWriter.WriteElementString("DBID", sensor.DBID.ToString());
										if (sensor.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
										{
											xmlWriter.WriteElementString("St", ((byte)sensor.vmethod_5()).ToString());
										}
										if (sensor.method_16() != PlatformComponent._DamageSeverityFactor.Light)
										{
											xmlWriter.WriteElementString("DamageSeverity", ((byte)sensor.method_16()).ToString());
										}
										xmlWriter.WriteEndElement();
									}
								}
								xmlWriter.WriteEndElement();
								xmlWriter.WriteStartElement("Comms");
								foreach (CommDevice commDevice in activeUnit.vmethod_94())
								{
									if (commDevice.vmethod_5() != PlatformComponent._ComponentStatus.Operational || commDevice.method_16() != PlatformComponent._DamageSeverityFactor.Light)
									{
										xmlWriter.WriteStartElement("CD");
										xmlWriter.WriteElementString("ID", commDevice.string_0);
										xmlWriter.WriteElementString("Name", commDevice.Name);
										xmlWriter.WriteElementString("DBID", commDevice.DBID.ToString());
										if (commDevice.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
										{
											xmlWriter.WriteElementString("St", ((byte)commDevice.vmethod_5()).ToString());
										}
										if (commDevice.method_16() != PlatformComponent._DamageSeverityFactor.Light)
										{
											xmlWriter.WriteElementString("DamageSeverity", ((byte)commDevice.method_16()).ToString());
										}
										xmlWriter.WriteEndElement();
									}
								}
								xmlWriter.WriteEndElement();
								xmlWriter.WriteStartElement("Propulsion");
								try
								{
									foreach (Engine engine in activeUnit.vmethod_49())
									{
										if (engine.vmethod_5() != PlatformComponent._ComponentStatus.Operational || engine.method_16() != PlatformComponent._DamageSeverityFactor.Light)
										{
											xmlWriter.WriteStartElement("Engine");
											xmlWriter.WriteElementString("ID", engine.string_0);
											xmlWriter.WriteElementString("Name", engine.Name);
											xmlWriter.WriteElementString("DBID", engine.DBID.ToString());
											if (engine.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
											{
												xmlWriter.WriteElementString("Status", ((byte)engine.vmethod_5()).ToString());
											}
											if (engine.method_16() != PlatformComponent._DamageSeverityFactor.Light)
											{
												xmlWriter.WriteElementString("DamageSeverity", ((byte)engine.method_16()).ToString());
											}
											xmlWriter.WriteEndElement();
										}
									}
								}
								finally
								{
									List<Engine>.Enumerator enumerator14;
									((IDisposable)enumerator14).Dispose();
								}
								xmlWriter.WriteEndElement();
								xmlWriter.WriteStartElement("Mounts");
								try
								{
									foreach (Mount mount in activeUnit.vmethod_51())
									{
										if (mount.vmethod_5() != PlatformComponent._ComponentStatus.Operational || mount.method_16() != PlatformComponent._DamageSeverityFactor.Light)
										{
											xmlWriter.WriteStartElement("Mount");
											xmlWriter.WriteElementString("ID", mount.string_0);
											xmlWriter.WriteElementString("Name", mount.Name);
											xmlWriter.WriteElementString("DBID", mount.DBID.ToString());
											if (mount.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
											{
												xmlWriter.WriteElementString("St", ((byte)mount.vmethod_5()).ToString());
											}
											if (mount.method_16() != PlatformComponent._DamageSeverityFactor.Light)
											{
												xmlWriter.WriteElementString("DamageSeverity", ((byte)mount.method_16()).ToString());
											}
											xmlWriter.WriteEndElement();
										}
									}
								}
								finally
								{
									List<Mount>.Enumerator enumerator15;
									((IDisposable)enumerator15).Dispose();
								}
								xmlWriter.WriteEndElement();
								xmlWriter.WriteStartElement("Magazines");
								foreach (Magazine magazine in activeUnit.vmethod_117())
								{
									if (magazine.vmethod_5() != PlatformComponent._ComponentStatus.Operational || magazine.method_16() != PlatformComponent._DamageSeverityFactor.Light)
									{
										xmlWriter.WriteStartElement("Mag");
										xmlWriter.WriteElementString("ID", magazine.string_0);
										xmlWriter.WriteElementString("Name", magazine.Name);
										xmlWriter.WriteElementString("DBID", magazine.DBID.ToString());
										if (magazine.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
										{
											xmlWriter.WriteElementString("St", ((byte)magazine.vmethod_5()).ToString());
										}
										if (magazine.method_16() != PlatformComponent._DamageSeverityFactor.Light)
										{
											xmlWriter.WriteElementString("DamageSeverity", ((byte)magazine.method_16()).ToString());
										}
										xmlWriter.WriteEndElement();
									}
								}
								xmlWriter.WriteEndElement();
								xmlWriter.WriteStartElement("OnboardCargo");
								foreach (Cargo cargo in activeUnit.cargo_0)
								{
									if (cargo.vmethod_5() != PlatformComponent._ComponentStatus.Operational || cargo.method_16() != PlatformComponent._DamageSeverityFactor.Light)
									{
										xmlWriter.WriteStartElement("Cargo");
										xmlWriter.WriteElementString("ID", cargo.string_0);
										xmlWriter.WriteElementString("Name", cargo.Name);
										xmlWriter.WriteElementString("DBID", cargo.DBID.ToString());
										if (cargo.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
										{
											xmlWriter.WriteElementString("St", ((byte)cargo.vmethod_5()).ToString());
										}
										if (cargo.method_16() != PlatformComponent._DamageSeverityFactor.Light)
										{
											xmlWriter.WriteElementString("DamageSeverity", ((byte)cargo.method_16()).ToString());
										}
										xmlWriter.WriteEndElement();
									}
								}
								xmlWriter.WriteEndElement();
								xmlWriter.WriteEndElement();
								xmlWriter.WriteEndElement();
								goto IL_1310;
							}
							goto IL_1310;
							Block_41:
							try
							{
								IL_576:
								List<int>.Enumerator enumerator16 = list2.GetEnumerator();
								while (enumerator16.MoveNext())
								{
									if (enumerator16.Current == activeUnit.vmethod_57())
									{
										flag = true;
										break;
									}
								}
							}
							finally
							{
								List<int>.Enumerator enumerator16;
								((IDisposable)enumerator16).Dispose();
							}
							goto IL_5B1;
							IL_131C:
							if (list2.Count > 0)
							{
								goto IL_576;
							}
							goto IL_5B1;
						}
						IL_1310:
						streamWriter.Flush();
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator6;
					((IDisposable)enumerator6).Dispose();
				}
				streamWriter.Close();
				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndElement();
				xmlWriter.Flush();
				xmlWriter.Close();
				StreamWriter streamWriter2 = new StreamWriter(str + ".exu");
				using (streamWriter2)
				{
					streamWriter2.Write(Misc.smethod_45(memoryStream));
					streamWriter2.Flush();
					streamWriter2.Close();
				}
				return true;
			}
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x0025E0A4 File Offset: 0x0025C2A4
		public static int smethod_63(LuaTable luaTable_0)
		{
			Dictionary<string, object> dictionary_ = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			double? num = LuaUtility.smethod_11(dictionary_);
			if (num == null)
			{
				throw new Exception3("Missing 'Latitude'");
			}
			double? num2 = LuaUtility.smethod_13(dictionary_);
			if (num2 == null)
			{
				throw new Exception3("Missing 'Longitude'");
			}
			return (int)Terrain.smethod_7(num.Value, num2.Value, false);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x0025E108 File Offset: 0x0025C308
		public static LuaTable smethod_64(LuaTable luaTable_0)
		{
			int num = 45;
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			double? num2 = LuaUtility.smethod_11(dictionary);
			if (num2 == null)
			{
				throw new Exception3("Missing 'Latitude'");
			}
			double? num3 = LuaUtility.smethod_13(dictionary);
			if (num3 == null)
			{
				throw new Exception3("Missing 'Longitude'");
			}
			if (dictionary.ContainsKey("NUMPOINTS"))
			{
				try
				{
					num = Conversions.ToInteger(dictionary["NUMPOINTS"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("Numpoints must be an integer");
				}
			}
			if (dictionary.ContainsKey("RADIUS"))
			{
				float num4;
				try
				{
					num4 = Conversions.ToSingle(dictionary["RADIUS"]);
				}
				catch (Exception ex2)
				{
					throw new Exception3("Radius must be a number");
				}
				Class432.Struct48[] array = new Class432.Struct48[num + 1];
				Class432.smethod_11(num2.Value, num3.Value, (double)num4, num, ref array);
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num5 = 1;
				foreach (Class432.Struct48 @struct in array)
				{
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					luaTable2["latitude"] = @struct.double_1;
					luaTable2["longitude"] = @struct.double_0;
					luaTable2["Latitude"] = @struct.double_1;
					luaTable2["Longitude"] = @struct.double_0;
					luaTable[num5] = luaTable2;
					num5++;
				}
				return luaTable;
			}
			throw new Exception3("Radius is not specified");
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x0025E2CC File Offset: 0x0025C4CC
		public static LuaTable smethod_65(LuaTable luaTable_0)
		{
			double? num = null;
			double? num2 = null;
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(luaTable_0.GetEnumerator());
			double? num3 = LuaUtility.smethod_11(dictionary);
			if (num3 == null)
			{
				throw new Exception3("Missing 'Latitude'");
			}
			double? num4 = LuaUtility.smethod_13(dictionary);
			if (num4 == null)
			{
				throw new Exception3("Missing 'Longitude'");
			}
			if (dictionary.ContainsKey("BEARING"))
			{
				try
				{
					num2 = new double?(Conversions.ToDouble(dictionary["BEARING"]));
				}
				catch (Exception ex)
				{
					throw new Exception3("Bearing must be number");
				}
			}
			if (dictionary.ContainsKey("DISTANCE"))
			{
				try
				{
					num = new double?(Conversions.ToDouble(dictionary["DISTANCE"]));
				}
				catch (Exception ex2)
				{
					throw new Exception3("Dstance must be a number");
				}
			}
			if (Information.IsNothing(num2) || Information.IsNothing(num))
			{
				throw new Exception3("Bearing and distance not defined");
			}
			Class432.Struct47 @struct = new Class432.Struct47(num3.Value, num4.Value);
			Class432.Struct47 struct2 = default(Class432.Struct47);
			Class432.smethod_13(ref @struct, ref struct2, num2.Value, num.Value);
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			luaTable["Latitude"] = struct2.double_0;
			luaTable["Longitude"] = struct2.double_1;
			luaTable["latitude"] = struct2.double_0;
			luaTable["longitude"] = struct2.double_1;
			return luaTable;
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x0025E478 File Offset: 0x0025C678
		public static Side smethod_66(string string_0, Scenario scenario_0)
		{
			Side result = null;
			Side[] array = scenario_0.method_44();
			int i = 0;
			checked
			{
				while (i < array.Length)
				{
					Side side = array[i];
					if (Operators.CompareString(side.method_51(), string_0, false) != 0 && Operators.CompareString(side.string_0.ToLower(), string_0.ToLower(), false) != 0)
					{
						if (Operators.CompareString(side.method_51().ToUpper(), string_0.ToUpper(), false) != 0 && Operators.CompareString(side.string_0.ToUpper(), string_0.ToUpper(), false) != 0)
						{
							i++;
							continue;
						}
						result = side;
					}
					else
					{
						result = side;
					}
					return result;
				}
				return result;
			}
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x0025E504 File Offset: 0x0025C704
		public static ActiveUnit smethod_67(string string_0, Scenario scenario_0)
		{
			ActiveUnit result = null;
			try
			{
				foreach (ActiveUnit activeUnit in scenario_0.method_42())
				{
					if (Operators.CompareString(activeUnit.Name, string_0, false) == 0 || Operators.CompareString(activeUnit.string_0.ToLower(), string_0.ToLower(), false) == 0)
					{
						result = activeUnit;
						break;
					}
					if (Operators.CompareString(activeUnit.Name.ToUpper(), string_0.ToUpper(), false) == 0 || Operators.CompareString(activeUnit.string_0.ToUpper(), string_0.ToUpper(), false) == 0)
					{
						result = activeUnit;
						break;
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return result;
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x0025E5B8 File Offset: 0x0025C7B8
		public static ActiveUnit smethod_68(string string_0, Side side_0)
		{
			ActiveUnit result = null;
			ActiveUnit[] activeUnit_ = side_0.activeUnit_0;
			int i = 0;
			checked
			{
				while (i < activeUnit_.Length)
				{
					ActiveUnit activeUnit = activeUnit_[i];
					if (Operators.CompareString(activeUnit.Name, string_0, false) != 0 && Operators.CompareString(activeUnit.string_0.ToLower(), string_0.ToLower(), false) != 0)
					{
						if (Operators.CompareString(activeUnit.Name.ToUpper(), string_0.ToUpper(), false) != 0 && Operators.CompareString(activeUnit.string_0.ToUpper(), string_0.ToUpper(), false) != 0)
						{
							i++;
							continue;
						}
						result = activeUnit;
					}
					else
					{
						result = activeUnit;
					}
					return result;
				}
				return result;
			}
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x0025E644 File Offset: 0x0025C844
		public static Contact smethod_69(string string_0, Scenario scenario_0)
		{
			Contact result = null;
			foreach (Side side in scenario_0.method_44())
			{
				try
				{
					foreach (Contact contact in side.method_44())
					{
						if (Operators.CompareString(contact.Name, string_0, false) == 0 || Operators.CompareString(contact.string_0.ToLower(), string_0.ToLower(), false) == 0)
						{
							result = contact;
							return result;
						}
						if (Operators.CompareString(contact.Name.ToUpper(), string_0.ToUpper(), false) == 0 || Operators.CompareString(contact.string_0.ToUpper(), string_0.ToUpper(), false) == 0)
						{
							result = contact;
							return result;
						}
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (string text in side.lazy_0.Value.Keys)
					{
						Contact contact2 = side.lazy_0.Value[text];
						if (Operators.CompareString(contact2.Name, string_0, false) == 0 || Operators.CompareString(contact2.string_0.ToLower(), string_0.ToLower(), false) == 0)
						{
							result = contact2;
							return result;
						}
						if (Operators.CompareString(contact2.Name.ToUpper(), string_0.ToUpper(), false) == 0 || Operators.CompareString(contact2.string_0.ToUpper(), string_0.ToUpper(), false) == 0)
						{
							result = contact2;
							return result;
						}
					}
				}
				finally
				{
					IEnumerator<string> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
			}
			return result;
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x0025E7F8 File Offset: 0x0025C9F8
		public static ActiveUnit smethod_70(string AUGUID, string AUName, Scenario theScen, bool useParentGroup = true)
		{
			ActiveUnit result = null;
			bool flag = false;
			Group group = null;
			try
			{
				foreach (ActiveUnit activeUnit in theScen.method_42())
				{
					if (!Information.IsNothing(activeUnit))
					{
						if (Operators.CompareString(activeUnit.string_0.ToLower(), AUGUID.ToLower(), false) == 0)
						{
							flag = true;
							if (useParentGroup)
							{
								group = activeUnit.vmethod_65(false);
							}
						}
						else if (flag && (Operators.CompareString(activeUnit.Name, AUName, false) == 0 || Operators.CompareString(activeUnit.Name.ToUpper(), AUName.ToUpper(), false) == 0) && (group == null || Operators.CompareString(group.string_0, activeUnit.vmethod_65(false).string_0, false) == 0))
						{
							result = activeUnit;
							break;
						}
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return result;
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x0025E8D8 File Offset: 0x0025CAD8
		public static bool smethod_71(ActiveUnit theU, Scenario ScenarioContext, ref string message, ref ActiveUnit theSelectedTanker = null, ref List<Mission> theSelectedMissions = null)
		{
			string text = "";
			if (theU.bool_3)
			{
				Aircraft aircraft = (Aircraft)theU;
				Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
				GeoPoint geoPoint_ = aircraft.method_158().method_18();
				Doctrine.Enum57 enum57_ = Doctrine.Enum57.const_0;
				bool flag = true;
				bool bool_ = false;
				bool flag2 = aircraft.method_85();
				bool flag3 = false;
				if (!aircraft_AirOps.method_80(geoPoint_, enum57_, ref flag, bool_, ref theSelectedTanker, ref theSelectedMissions, ref text, ref flag2, ref flag3) && Operators.CompareString(text, "", false) != 0)
				{
					string text2 = "";
					if (Operators.CompareString(aircraft.Name, aircraft.string_2, false) != 0)
					{
						text2 = " (" + aircraft.string_2 + ")";
					}
					message = string.Concat(new string[]
					{
						"Aircraft ",
						aircraft.Name,
						text2,
						" cannot refuel. Reason: ",
						text
					});
				}
				aircraft.method_158().vmethod_11(0f, false, false);
			}
			else if (theU.bool_1)
			{
				Group group = (Group)theU;
				if (group.method_143() == Group.GroupType.AirGroup && !Information.IsNothing(((Group)theU).method_147()))
				{
					Aircraft aircraft2 = (Aircraft)((Group)theU).method_147();
					Aircraft_AirOps aircraft_AirOps2 = aircraft2.method_164();
					GeoPoint geoPoint_2 = aircraft2.method_158().method_18();
					Doctrine.Enum57 enum57_2 = Doctrine.Enum57.const_0;
					bool flag3 = true;
					bool bool_2 = false;
					bool flag2 = true;
					bool flag = false;
					if (aircraft_AirOps2.method_80(geoPoint_2, enum57_2, ref flag3, bool_2, ref theSelectedTanker, ref theSelectedMissions, ref text, ref flag2, ref flag))
					{
						Aircraft aircraft3 = aircraft2.method_164().method_24();
						if (Information.IsNothing(aircraft3))
						{
							goto IL_204;
						}
						try
						{
							foreach (ActiveUnit activeUnit in group.vmethod_141().Values)
							{
								if (activeUnit != aircraft2 && activeUnit.vmethod_108() != ActiveUnit._ActiveUnitStatus.Refuelling && activeUnit.vmethod_127() && activeUnit != aircraft3)
								{
									Aircraft_AirOps aircraft_AirOps3 = (Aircraft_AirOps)activeUnit.vmethod_92();
									activeUnit.vmethod_109(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
									aircraft_AirOps3.method_37(Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel);
									aircraft_AirOps3.method_25(aircraft3);
								}
							}
							goto IL_204;
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
					if (Operators.CompareString(text, "", false) != 0)
					{
						message = "The aircraft in group " + group.Name + " cannot refuel. Reason: " + text;
					}
				}
				IL_204:
				group.vmethod_86().vmethod_11(0f, false, false);
			}
			Ship ship = null;
			if (theU.bool_6)
			{
				ship = (Ship)theU;
			}
			if (ship == null)
			{
				ValueTuple<ActiveUnit_DockingOps.Enum32, string> valueTuple = ship.vmethod_93().method_54(ship.method_145().method_18(), theSelectedTanker, theSelectedMissions, false, new int?(100));
				if (valueTuple.Item1 != ActiveUnit_DockingOps.Enum32.const_1 && !string.IsNullOrEmpty(valueTuple.Item2))
				{
					message = "Ship " + ship.Name + " cannot UNREP. Reason: " + valueTuple.Item2;
				}
				ship.method_145().vmethod_11(0f, false, false);
			}
			if (theU.bool_1)
			{
				Group group2 = (Group)theU;
				if (group2.method_143() == Group.GroupType.SurfaceGroup || group2.method_143() == Group.GroupType.SubGroup)
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in group2.vmethod_141().Values)
						{
							text = "";
							if (activeUnit2.bool_6 || activeUnit2.bool_5)
							{
								ValueTuple<ActiveUnit_DockingOps.Enum32, string> valueTuple2 = activeUnit2.vmethod_93().method_54(activeUnit2.vmethod_86().method_18(), theSelectedTanker, theSelectedMissions, false, new int?(100));
								if (valueTuple2.Item1 != ActiveUnit_DockingOps.Enum32.const_1 && !string.IsNullOrEmpty(valueTuple2.Item2))
								{
									message = "Unit " + activeUnit2.Name + " cannot UNREP. Reason: " + valueTuple2.Item2;
								}
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
					group2.vmethod_86().vmethod_11(0f, false, false);
				}
			}
			return true;
		}

		// Token: 0x04001D11 RID: 7441
		[CompilerGenerated]
		private static PrivateMethods.Delegate58 delegate58_0;

		// Token: 0x04001D12 RID: 7442
		[CompilerGenerated]
		private static PrivateMethods.Delegate59 delegate59_0;

		// Token: 0x04001D13 RID: 7443
		[CompilerGenerated]
		private static PrivateMethods.Delegate60 delegate60_0;

		// Token: 0x04001D14 RID: 7444
		[CompilerGenerated]
		private static PrivateMethods.Delegate61 delegate61_0;

		// Token: 0x0200043D RID: 1085
		// (Invoke) Token: 0x06002153 RID: 8531
		internal delegate void Delegate58(string theMsg, int theStyle, bool RunningInMonteCarloMode, ref string pressed);

		// Token: 0x0200043E RID: 1086
		// (Invoke) Token: 0x06002157 RID: 8535
		internal delegate void Delegate59(string theMsg, ref string pressed);

		// Token: 0x0200043F RID: 1087
		// (Invoke) Token: 0x0600215B RID: 8539
		internal delegate void Delegate60(string theFileName, bool FullScreen, int Delay);

		// Token: 0x02000440 RID: 1088
		// (Invoke) Token: 0x0600215F RID: 8543
		internal delegate void Delegate61(string theFileName, int Delay);

		// Token: 0x02000441 RID: 1089
		[CompilerGenerated]
		internal sealed class Class489
		{
			// Token: 0x06002161 RID: 8545 RVA: 0x0025EC84 File Offset: 0x0025CE84
			internal bool method_0(Side side_0)
			{
				return Operators.CompareString(side_0.method_51().ToUpper(), this.string_0.ToUpper(), false) == 0 || Operators.CompareString(side_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04001D15 RID: 7445
			public string string_0;
		}

		// Token: 0x02000443 RID: 1091
		[CompilerGenerated]
		internal sealed class Class490
		{
			// Token: 0x06002171 RID: 8561 RVA: 0x0025ECD0 File Offset: 0x0025CED0
			internal bool method_0(Side side_0)
			{
				return Operators.CompareString(side_0.method_51().ToUpper(), this.string_0.ToUpper(), false) == 0 || Operators.CompareString(side_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04001D23 RID: 7459
			public string string_0;
		}

		// Token: 0x02000444 RID: 1092
		[CompilerGenerated]
		internal sealed class Class491
		{
			// Token: 0x06002173 RID: 8563 RVA: 0x0025ED1C File Offset: 0x0025CF1C
			internal bool method_0(Side side_0)
			{
				return Operators.CompareString(side_0.method_51().ToUpper(), this.string_0.ToUpper(), false) == 0 || Operators.CompareString(side_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04001D24 RID: 7460
			public string string_0;
		}

		// Token: 0x02000445 RID: 1093
		[CompilerGenerated]
		internal sealed class Class492
		{
			// Token: 0x06002175 RID: 8565 RVA: 0x0025ED68 File Offset: 0x0025CF68
			internal bool method_0(Side side_0)
			{
				return Operators.CompareString(side_0.method_51().ToUpper(), this.string_0.ToUpper(), false) == 0 || Operators.CompareString(side_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04001D25 RID: 7461
			public string string_0;
		}

		// Token: 0x02000446 RID: 1094
		[CompilerGenerated]
		internal sealed class Class493
		{
			// Token: 0x06002176 RID: 8566 RVA: 0x0001076B File Offset: 0x0000E96B
			public Class493(PrivateMethods.Class493 class493_0)
			{
				if (class493_0 != null)
				{
					this.int_0 = class493_0.int_0;
					this.string_0 = class493_0.string_0;
				}
			}

			// Token: 0x06002177 RID: 8567 RVA: 0x0001078E File Offset: 0x0000E98E
			internal bool method_0(Cargo cargo_0)
			{
				return ((Mount)cargo_0.method_25()).DBID == this.int_0;
			}

			// Token: 0x06002178 RID: 8568 RVA: 0x000107A8 File Offset: 0x0000E9A8
			internal bool method_1(Cargo cargo_0)
			{
				return Operators.CompareString(cargo_0.string_0, this.string_0, false) == 0;
			}

			// Token: 0x04001D26 RID: 7462
			public int int_0;

			// Token: 0x04001D27 RID: 7463
			public string string_0;
		}

		// Token: 0x02000447 RID: 1095
		[CompilerGenerated]
		internal sealed class Class494
		{
			// Token: 0x0600217A RID: 8570 RVA: 0x0025EDB4 File Offset: 0x0025CFB4
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x0600217B RID: 8571 RVA: 0x0025EDB4 File Offset: 0x0025CFB4
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04001D28 RID: 7464
			public string string_0;
		}

		// Token: 0x02000448 RID: 1096
		[CompilerGenerated]
		internal sealed class Class495
		{
			// Token: 0x0600217C RID: 8572 RVA: 0x000107BF File Offset: 0x0000E9BF
			public Class495(PrivateMethods.Class495 class495_0)
			{
				if (class495_0 != null)
				{
					this.string_0 = class495_0.string_0;
				}
			}

			// Token: 0x0600217D RID: 8573 RVA: 0x0025EE00 File Offset: 0x0025D000
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x0600217E RID: 8574 RVA: 0x0025EE00 File Offset: 0x0025D000
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04001D29 RID: 7465
			public string string_0;
		}

		// Token: 0x02000449 RID: 1097
		[CompilerGenerated]
		internal sealed class Class496
		{
			// Token: 0x0600217F RID: 8575 RVA: 0x000107D6 File Offset: 0x0000E9D6
			public Class496(PrivateMethods.Class496 class496_0)
			{
				if (class496_0 != null)
				{
					this._FuelType_0 = class496_0._FuelType_0;
				}
			}

			// Token: 0x06002180 RID: 8576 RVA: 0x000107ED File Offset: 0x0000E9ED
			internal bool method_0(FuelRec fuelRec_0)
			{
				return fuelRec_0._FuelType_0 == this._FuelType_0;
			}

			// Token: 0x04001D2A RID: 7466
			public FuelRec._FuelType _FuelType_0;
		}

		// Token: 0x0200044A RID: 1098
		[CompilerGenerated]
		internal sealed class Class497
		{
			// Token: 0x06002181 RID: 8577 RVA: 0x000107FD File Offset: 0x0000E9FD
			public Class497(PrivateMethods.Class497 class497_0)
			{
				if (class497_0 != null)
				{
					this.string_0 = class497_0.string_0;
				}
			}

			// Token: 0x06002182 RID: 8578 RVA: 0x00010814 File Offset: 0x0000EA14
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x06002183 RID: 8579 RVA: 0x00010814 File Offset: 0x0000EA14
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x04001D2B RID: 7467
			public string string_0;
		}

		// Token: 0x0200044B RID: 1099
		[CompilerGenerated]
		internal sealed class Class498
		{
			// Token: 0x06002185 RID: 8581 RVA: 0x0025EE4C File Offset: 0x0025D04C
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x06002186 RID: 8582 RVA: 0x0025EE4C File Offset: 0x0025D04C
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04001D2C RID: 7468
			public string string_0;
		}

		// Token: 0x0200044C RID: 1100
		[CompilerGenerated]
		internal sealed class Class499
		{
			// Token: 0x06002187 RID: 8583 RVA: 0x00010835 File Offset: 0x0000EA35
			public Class499(PrivateMethods.Class499 class499_0)
			{
				if (class499_0 != null)
				{
					this.string_0 = class499_0.string_0;
				}
			}

			// Token: 0x06002188 RID: 8584 RVA: 0x0025EE98 File Offset: 0x0025D098
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x06002189 RID: 8585 RVA: 0x0025EE98 File Offset: 0x0025D098
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04001D2D RID: 7469
			public string string_0;
		}

		// Token: 0x0200044D RID: 1101
		[CompilerGenerated]
		internal sealed class Class500
		{
			// Token: 0x0600218A RID: 8586 RVA: 0x0001084C File Offset: 0x0000EA4C
			public Class500(PrivateMethods.Class500 class500_0)
			{
				if (class500_0 != null)
				{
					this.string_0 = class500_0.string_0;
				}
			}

			// Token: 0x0600218B RID: 8587 RVA: 0x0025EEE4 File Offset: 0x0025D0E4
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x0600218C RID: 8588 RVA: 0x0025EEE4 File Offset: 0x0025D0E4
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04001D2E RID: 7470
			public string string_0;
		}

		// Token: 0x0200044E RID: 1102
		[CompilerGenerated]
		internal sealed class Class501
		{
			// Token: 0x0600218D RID: 8589 RVA: 0x00010863 File Offset: 0x0000EA63
			public Class501(PrivateMethods.Class501 class501_0)
			{
				if (class501_0 != null)
				{
					this.string_0 = class501_0.string_0;
				}
			}

			// Token: 0x0600218E RID: 8590 RVA: 0x0001087A File Offset: 0x0000EA7A
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x0600218F RID: 8591 RVA: 0x0001087A File Offset: 0x0000EA7A
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x04001D2F RID: 7471
			public string string_0;
		}

		// Token: 0x0200044F RID: 1103
		[CompilerGenerated]
		internal sealed class Class502
		{
			// Token: 0x06002190 RID: 8592 RVA: 0x0001089B File Offset: 0x0000EA9B
			public Class502(PrivateMethods.Class502 class502_0)
			{
				if (class502_0 != null)
				{
					this.object_0 = class502_0.object_0;
				}
			}

			// Token: 0x06002191 RID: 8593 RVA: 0x0025EF30 File Offset: 0x0025D130
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToLower(), this.object_0.ToString().ToLower(), false) == 0 || Operators.CompareString(referencePoint_0.string_0.ToLower(), this.object_0.ToString().ToLower(), false) == 0;
			}

			// Token: 0x06002192 RID: 8594 RVA: 0x0025EF30 File Offset: 0x0025D130
			internal bool method_1(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToLower(), this.object_0.ToString().ToLower(), false) == 0 || Operators.CompareString(referencePoint_0.string_0.ToLower(), this.object_0.ToString().ToLower(), false) == 0;
			}

			// Token: 0x04001D30 RID: 7472
			public object object_0;
		}

		// Token: 0x02000450 RID: 1104
		[CompilerGenerated]
		internal sealed class Class503
		{
			// Token: 0x06002193 RID: 8595 RVA: 0x000108B2 File Offset: 0x0000EAB2
			public Class503(PrivateMethods.Class503 class503_0)
			{
				if (class503_0 != null)
				{
					this.referencePoint_0 = class503_0.referencePoint_0;
				}
			}

			// Token: 0x06002194 RID: 8596 RVA: 0x0025EF88 File Offset: 0x0025D188
			internal bool method_0(ReferencePoint referencePoint_1)
			{
				return referencePoint_1.imethod_0() == 1.79769313486231E+308 && (Operators.CompareString(referencePoint_1.Name.ToLower(), this.referencePoint_0.Name.ToString().ToLower(), false) == 0 || Operators.CompareString(referencePoint_1.string_0.ToLower(), this.referencePoint_0.Name.ToString().ToLower(), false) == 0);
			}

			// Token: 0x04001D31 RID: 7473
			public ReferencePoint referencePoint_0;
		}

		// Token: 0x02000451 RID: 1105
		[CompilerGenerated]
		internal sealed class Class504
		{
			// Token: 0x06002195 RID: 8597 RVA: 0x000108C9 File Offset: 0x0000EAC9
			public Class504(PrivateMethods.Class504 class504_0)
			{
				if (class504_0 != null)
				{
					this.referencePoint_0 = class504_0.referencePoint_0;
				}
			}

			// Token: 0x06002196 RID: 8598 RVA: 0x0025EFFC File Offset: 0x0025D1FC
			internal bool method_0(ReferencePoint referencePoint_1)
			{
				return referencePoint_1.imethod_0() == 1.79769313486231E+308 && (Operators.CompareString(referencePoint_1.Name.ToLower(), this.referencePoint_0.Name.ToString().ToLower(), false) == 0 || Operators.CompareString(referencePoint_1.string_0.ToLower(), this.referencePoint_0.Name.ToString().ToLower(), false) == 0);
			}

			// Token: 0x04001D32 RID: 7474
			public ReferencePoint referencePoint_0;
		}

		// Token: 0x02000452 RID: 1106
		[CompilerGenerated]
		internal sealed class Class505
		{
			// Token: 0x06002197 RID: 8599 RVA: 0x000108E0 File Offset: 0x0000EAE0
			public Class505(PrivateMethods.Class505 class505_0)
			{
				if (class505_0 != null)
				{
					this.string_0 = class505_0.string_0;
				}
			}

			// Token: 0x06002198 RID: 8600 RVA: 0x0025F070 File Offset: 0x0025D270
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x06002199 RID: 8601 RVA: 0x0025F070 File Offset: 0x0025D270
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04001D33 RID: 7475
			public string string_0;
		}

		// Token: 0x02000453 RID: 1107
		[CompilerGenerated]
		internal sealed class Class506
		{
			// Token: 0x0600219B RID: 8603 RVA: 0x000108F7 File Offset: 0x0000EAF7
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0, this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04001D34 RID: 7476
			public string string_0;
		}
	}
}
