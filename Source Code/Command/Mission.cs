using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns12;
using ns13;
using ns14;
using ns9;

namespace Command_Core
{
	// Token: 0x02000292 RID: 658
	public abstract class Mission : Class310
	{
		// Token: 0x06001401 RID: 5121 RVA: 0x0017A7B8 File Offset: 0x001789B8
		public virtual void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Mission");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				xmlWriter_0.WriteElementString("Name", this.Name);
				xmlWriter_0.WriteElementString("Category", ((byte)this.enum88_0).ToString());
				this.doctrine_0.method_282(ref xmlWriter_0, ref scenario_0, "Doctrine");
				if (this.nullable_0 != null)
				{
					xmlWriter_0.WriteElementString("START", this.nullable_0.Value.ToBinary().ToString());
				}
				if (this.nullable_1 != null)
				{
					xmlWriter_0.WriteElementString("END", this.nullable_1.Value.ToBinary().ToString());
				}
				if (this.nullable_0 != null)
				{
					xmlWriter_0.WriteElementString("TakeOffTime", this.nullable_2.Value.ToBinary().ToString());
				}
				if (this.nullable_1 != null)
				{
					xmlWriter_0.WriteElementString("TimeOnTarget", this.nullable_3.Value.ToBinary().ToString());
				}
				xmlWriter_0.WriteElementString("Deactivation_UnassignUnits", this.bool_19.ToString());
				xmlWriter_0.WriteElementString("CheckBox_OrderRTB", this.bool_20.ToString());
				xmlWriter_0.WriteElementString("CheckBox_DeleteMission", this.bool_21.ToString());
				xmlWriter_0.WriteElementString("SISIH", this.bool_11.ToString());
				xmlWriter_0.WriteElementString("UseFlightplan", this.bool_14.ToString());
				xmlWriter_0.WriteElementString("UseFlightplansOnly", this.bool_15.ToString());
				xmlWriter_0.WriteElementString("IncludeInATO", this.bool_16.ToString());
				byte b;
				if (this.enum89_0 != Mission.Enum89.const_0)
				{
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Status";
					b = (byte)this.enum89_0;
					xmlWriter.WriteElementString(localName, b.ToString());
				}
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "TankerUsage";
				b = (byte)this.tankerMethod_0;
				xmlWriter2.WriteElementString(localName2, b.ToString());
				xmlWriter_0.WriteStartElement("TankerMissionList");
				try
				{
					foreach (Mission mission in this.list_4)
					{
						if (!Information.IsNothing(mission))
						{
							xmlWriter_0.WriteElementString("ID", mission.string_0);
						}
					}
				}
				finally
				{
					List<Mission>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				xmlWriter_0.WriteEndElement();
				if (this.bool_17)
				{
					xmlWriter_0.WriteElementString("LaunchMissionWithoutTankersInPlace", this.bool_17.ToString());
				}
				xmlWriter_0.WriteElementString("TankerMinNumber_Total", this.int_1.ToString());
				xmlWriter_0.WriteElementString("TankerMinNumber_Airborne", this.int_2.ToString());
				xmlWriter_0.WriteElementString("TankerMinNumber_Station", this.int_3.ToString());
				xmlWriter_0.WriteElementString("MaxReceiversInQueuePerTanker_Airborne", this.int_4.ToString());
				xmlWriter_0.WriteElementString("FuelQtyToStartLookingForTanker_Airborne", this.int_5.ToString());
				xmlWriter_0.WriteElementString("TankerMaxDistance_Airborne", this.int_6.ToString());
				xmlWriter_0.WriteElementString("TankerFollowsReceivers", this.bool_18.ToString());
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = "FlightSize";
				int num = (int)this._FlightSize_0;
				xmlWriter3.WriteElementString(localName3, num.ToString());
				XmlWriter xmlWriter4 = xmlWriter_0;
				string localName4 = "GroupSize";
				num = (int)this._GroupSize_0;
				xmlWriter4.WriteElementString(localName4, num.ToString());
				if (this.method_54())
				{
					Mission.Flight.smethod_1(ref xmlWriter_0, ref hashSet_0, ref scenario_0, ref this.list_1);
				}
				if (!Information.IsNothing(this.list_2) && this.list_2.Count > 0)
				{
					Mission.EmptyAircraftSlot.smethod_0(ref xmlWriter_0, ref hashSet_0, ref scenario_0, ref this.list_2);
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100639", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0017ABD8 File Offset: 0x00178DD8
		public static Mission smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_0)
		{
			Mission result;
			try
			{
				string name = xmlNode_0.Name;
				uint num = Class582.smethod_0(name);
				if (num <= 2699781355U)
				{
					if (num <= 1487674855U)
					{
						if (num != 211262994U)
						{
							if (num == 1487674855U)
							{
								if (Operators.CompareString(name, "CargoMission", false) == 0)
								{
									return Class338.smethod_10(ref xmlNode_0, ref dictionary_0, ref scenario_0);
								}
							}
						}
						else if (Operators.CompareString(name, "TaskPool", false) == 0)
						{
							return Class342.smethod_10(ref xmlNode_0, ref dictionary_0, ref scenario_0);
						}
					}
					else if (num != 1849856623U)
					{
						if (num == 2699781355U)
						{
							if (Operators.CompareString(name, "FerryMission", false) == 0)
							{
								return FerryMission.smethod_10(ref xmlNode_0, ref dictionary_0, scenario_0);
							}
						}
					}
					else if (Operators.CompareString(name, "Strike", false) == 0)
					{
						return Strike.smethod_10(ref xmlNode_0, ref dictionary_0, scenario_0);
					}
				}
				else if (num <= 3100519701U)
				{
					if (num != 2895700795U)
					{
						if (num == 3100519701U)
						{
							if (Operators.CompareString(name, "MiningMission", false) == 0)
							{
								return Class340.smethod_10(ref xmlNode_0, ref dictionary_0, ref scenario_0);
							}
						}
					}
					else if (Operators.CompareString(name, "Patrol", false) == 0)
					{
						return Class343.smethod_10(ref xmlNode_0, ref dictionary_0, ref scenario_0);
					}
				}
				else if (num != 3599814949U)
				{
					if (num == 3891038774U)
					{
						if (Operators.CompareString(name, "SupportMission", false) == 0)
						{
							return Class344.smethod_10(ref xmlNode_0, ref dictionary_0, ref scenario_0);
						}
					}
				}
				else if (Operators.CompareString(name, "MineClearingMission", false) == 0)
				{
					return Class341.smethod_10(ref xmlNode_0, ref dictionary_0, ref scenario_0);
				}
				result = new Class343(null, scenario_0, "ERROR", Mission.Enum88.const_0, null, GlobalVariables.PatrolType.AAW, false);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100640", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Class343(null, scenario_0, "ERROR", Mission.Enum88.const_0, null, GlobalVariables.PatrolType.AAW, false);
			}
			return result;
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0017ADC0 File Offset: 0x00178FC0
		public float? method_8(ref Aircraft aircraft_0, ref bool bool_22)
		{
			float? result;
			switch (this._MissionClass_0)
			{
			case Mission._MissionClass.Strike:
				if (aircraft_0.method_158().bool_2)
				{
					Strike strike = (Strike)this;
					bool_22 = strike.bool_23;
					result = strike.nullable_6;
				}
				else if (!Information.IsNothing(aircraft_0.method_167()))
				{
					if (aircraft_0.method_167().method_15(aircraft_0.scenario_0).bool_3)
					{
						bool_22 = false;
						result = new float?(Aircraft_AI.smethod_2(ref aircraft_0, ActiveUnit.Throttle.Cruise, ref bool_22));
					}
					else
					{
						bool_22 = aircraft_0.method_167().method_15(aircraft_0.scenario_0).bool_1;
						result = new float?(aircraft_0.method_167().method_15(aircraft_0.scenario_0).float_2);
					}
				}
				else
				{
					bool_22 = false;
					result = new float?(Aircraft_AI.smethod_2(ref aircraft_0, ActiveUnit.Throttle.Cruise, ref bool_22));
				}
				break;
			case Mission._MissionClass.Patrol:
			{
				Class343 @class = (Class343)this;
				bool_22 = @class.imethod_14();
				result = @class.imethod_6();
				break;
			}
			case Mission._MissionClass.Support:
			{
				Class344 class2 = (Class344)this;
				bool_22 = class2.bool_25;
				result = class2.nullable_6;
				break;
			}
			case Mission._MissionClass.Ferry:
			{
				FerryMission ferryMission = (FerryMission)this;
				bool_22 = false;
				result = ferryMission.nullable_5;
				break;
			}
			case Mission._MissionClass.Mining:
			{
				Class340 class3 = (Class340)this;
				bool_22 = class3.bool_23;
				result = class3.nullable_6;
				break;
			}
			case Mission._MissionClass.MineClearing:
			{
				Class341 class4 = (Class341)this;
				bool_22 = class4.bool_23;
				result = class4.nullable_6;
				break;
			}
			case Mission._MissionClass.Escort:
			{
				Class339 class5 = (Class339)this;
				bool_22 = class5.bool_22;
				result = class5.nullable_6;
				break;
			}
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0017AF58 File Offset: 0x00179158
		public ActiveUnit.Throttle? method_9(ref Aircraft aircraft_0)
		{
			ActiveUnit.Throttle? result;
			switch (this._MissionClass_0)
			{
			case Mission._MissionClass.Strike:
				if (aircraft_0.method_158().bool_2)
				{
					result = ((Strike)this).nullable_4;
				}
				else if (!Information.IsNothing(aircraft_0.method_167()))
				{
					result = new ActiveUnit.Throttle?(aircraft_0.method_167().method_15(aircraft_0.scenario_0).throttle_1);
				}
				else
				{
					result = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
				}
				break;
			case Mission._MissionClass.Patrol:
				result = ((Class343)this).imethod_0();
				break;
			case Mission._MissionClass.Support:
				result = ((Class344)this).nullable_4;
				break;
			case Mission._MissionClass.Ferry:
				result = ((FerryMission)this).nullable_4;
				break;
			case Mission._MissionClass.Mining:
				result = ((Class340)this).nullable_4;
				break;
			case Mission._MissionClass.MineClearing:
				result = ((Class341)this).nullable_4;
				break;
			case Mission._MissionClass.Escort:
				result = ((Class339)this).nullable_4;
				break;
			case Mission._MissionClass.Cargo:
				result = new ActiveUnit.Throttle?(((Class338)this).throttle_0);
				break;
			default:
				result = new ActiveUnit.Throttle?(ActiveUnit.Throttle.FullStop);
				break;
			}
			return result;
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0000B286 File Offset: 0x00009486
		public Mission.Enum89 method_10(Scenario scenario_0)
		{
			return this.enum89_0;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0017B060 File Offset: 0x00179260
		public void method_11(Scenario scenario_0, Mission.Enum89 enum89_1)
		{
			try
			{
				bool flag = enum89_1 != this.enum89_0;
				this.enum89_0 = enum89_1;
				if (flag)
				{
					try
					{
						foreach (ActiveUnit activeUnit in scenario_0.vmethod_0().Values)
						{
							if (activeUnit != null && activeUnit.vmethod_101() != null && activeUnit.vmethod_101() == this && activeUnit.vmethod_127())
							{
								activeUnit.vmethod_86().vmethod_10(0f, false, false);
								activeUnit.vmethod_86().vmethod_25();
								activeUnit.vmethod_86().vmethod_11(0f, false, false);
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
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100641", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0000B28E File Offset: 0x0000948E
		public bool method_12()
		{
			return this.enum89_0 == Mission.Enum89.const_0;
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0017B150 File Offset: 0x00179350
		public string method_13(Side side_0)
		{
			if (this.enum88_0 == Mission.Enum88.const_1 && string.IsNullOrEmpty(this.string_2))
			{
				try
				{
					foreach (Mission mission in side_0.method_35())
					{
						if (mission.enum88_0 == Mission.Enum88.const_2 && ((Class342)mission).list_5.Contains(this))
						{
							this.string_2 = mission.string_0;
							break;
						}
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
			return this.string_2;
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0000B299 File Offset: 0x00009499
		public void method_14(Side side_0, string string_3)
		{
			this.string_2 = string_3;
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x0017B1DC File Offset: 0x001793DC
		public List<ActiveUnit> method_15(Scenario scenario_0)
		{
			List<ActiveUnit> result;
			try
			{
				int count = scenario_0.method_42().Count;
				List<ActiveUnit> list = new List<ActiveUnit>();
				int num = count - 1;
				for (int i = 0; i <= num; i++)
				{
					ActiveUnit activeUnit = scenario_0.method_42()[i];
					if (!Information.IsNothing(activeUnit) && activeUnit.vmethod_101() == this)
					{
						list.Add(activeUnit);
					}
				}
				result = list;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100642", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<ActiveUnit>();
			}
			return result;
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0017B288 File Offset: 0x00179488
		public List<ActiveUnit> method_16(Scenario scenario_0)
		{
			List<ActiveUnit> result;
			try
			{
				int count = scenario_0.method_42().Count;
				List<ActiveUnit> list = new List<ActiveUnit>();
				int num = count - 1;
				for (int i = 0; i <= num; i++)
				{
					ActiveUnit activeUnit = scenario_0.method_42()[i];
					if (!Information.IsNothing(activeUnit) && activeUnit.vmethod_103() == this)
					{
						list.Add(activeUnit);
					}
				}
				result = list;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200643", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<ActiveUnit>();
			}
			return result;
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0017B334 File Offset: 0x00179534
		public void method_17(Scenario scenario_0, Mission.Flight flight_0)
		{
			try
			{
				List<ActiveUnit> list = Enumerable.ToList<ActiveUnit>(this.method_15(scenario_0));
				if (Information.IsNothing(flight_0))
				{
					for (int i = this.list_1.Count - 1; i >= 0; i += -1)
					{
						Mission.Flight flight = this.list_1[i];
						if (!Information.IsNothing(flight))
						{
							int num = 0;
							int num2 = 0;
							for (int j = list.Count - 1; j >= 0; j += -1)
							{
								ActiveUnit activeUnit = list[j];
								if (Information.IsNothing(activeUnit))
								{
									list.Remove(activeUnit);
								}
								else if (!activeUnit.bool_3)
								{
									list.Remove(activeUnit);
								}
								else if (activeUnit.vmethod_85().method_48() && activeUnit.vmethod_85().method_7() == flight)
								{
									num++;
									Aircraft aircraft = (Aircraft)activeUnit;
									if (activeUnit.vmethod_127())
									{
										goto IL_CE;
									}
									Aircraft aircraft2 = aircraft;
									string text = null;
									if (aircraft2.method_147(ref text) == Aircraft_AirOps.Enum44.const_0 && aircraft.vmethod_123())
									{
										goto IL_CE;
									}
									IL_D2:
									list.Remove(activeUnit);
									goto IL_DA;
									IL_CE:
									num2++;
									goto IL_D2;
								}
								IL_DA:;
							}
							flight.int_0 = num;
							flight.int_1 = num2;
						}
					}
				}
				else
				{
					int num3 = list.Count - 1;
					int num;
					int num2;
					for (int k = 0; k <= num3; k++)
					{
						ActiveUnit activeUnit = list[k];
						if (!Information.IsNothing(activeUnit) && activeUnit.bool_3 && activeUnit.vmethod_85().method_48() && activeUnit.vmethod_85().method_7() == flight_0)
						{
							num++;
							Aircraft aircraft3 = (Aircraft)activeUnit;
							if (!activeUnit.vmethod_127())
							{
								Aircraft aircraft4 = aircraft3;
								string text = null;
								if (aircraft4.method_147(ref text) != Aircraft_AirOps.Enum44.const_0 || !aircraft3.vmethod_123())
								{
									goto IL_17D;
								}
							}
							num2++;
						}
						IL_17D:;
					}
					flight_0.int_0 = num;
					flight_0.int_1 = num2;
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

		// Token: 0x0600140D RID: 5133 RVA: 0x0017B530 File Offset: 0x00179730
		public void method_18(Scenario scenario_0, ref List<int> list_5, ref List<int> list_6, ref List<Aircraft> list_7, ref List<Aircraft> list_8, ref List<Aircraft> list_9, ref List<Aircraft> list_10, ref List<ActiveUnit> list_11, ref int int_7, ref int int_8, ref int int_9, ref int int_10, ref int int_11, ref int int_12, ref List<int> list_12, ref List<ActiveUnit> list_13, ref List<ActiveUnit> list_14, List<ActiveUnit> list_15, ref List<Aircraft> list_16, ref List<Aircraft> list_17, ref List<Aircraft> list_18, ref int int_13, ref int int_14, ref int int_15, ref List<Mission.Flight> list_19, ref List<Mission.Flight> list_20, ref List<Mission.Flight> list_21, bool bool_22, bool bool_23, bool bool_24)
		{
			try
			{
				int num = scenario_0.method_42().Count - 1;
				for (int i = 0; i <= num; i++)
				{
					ActiveUnit activeUnit = scenario_0.method_42()[i];
					if (!Information.IsNothing(activeUnit) && !activeUnit.bool_1 && activeUnit.vmethod_101() == this)
					{
						if (activeUnit.bool_3)
						{
							Aircraft aircraft = (Aircraft)activeUnit;
							list_7.Add(aircraft);
							if (!Information.IsNothing(aircraft.method_157().method_7()) && !bool_24)
							{
								list_9.Add(aircraft);
								Aircraft aircraft2 = aircraft;
								string text = null;
								if (aircraft2.method_147(ref text) == Aircraft_AirOps.Enum44.const_0 && aircraft.vmethod_123() && !Information.IsNothing(aircraft.method_167()))
								{
									list_10.Add(aircraft);
									list_19.Add(aircraft.method_157().method_7());
								}
								else
								{
									list_20.Add(aircraft.method_157().method_7());
								}
								if (aircraft.method_158().bool_2)
								{
									if (aircraft.method_167().method_12())
									{
										int_9++;
									}
									else
									{
										int_8++;
									}
								}
								else
								{
									int_7++;
								}
							}
							else
							{
								Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
								if (!list_6.Contains(aircraft.DBID))
								{
									list_6.Add(aircraft.DBID);
								}
								if (bool_24)
								{
									Aircraft aircraft3 = aircraft;
									string text = null;
									if (aircraft3.method_147(ref text) == Aircraft_AirOps.Enum44.const_0)
									{
										if (!Information.IsNothing(aircraft_AirOps.method_30()))
										{
											if (!list_11.Contains(aircraft_AirOps.method_30()))
											{
												list_11.Add(aircraft_AirOps.method_30());
											}
										}
										else if (!Information.IsNothing(aircraft_AirOps.method_32(false)) && !list_11.Contains(aircraft_AirOps.method_32(false)))
										{
											list_11.Add(aircraft_AirOps.method_32(false));
										}
										if (!Information.IsNothing(aircraft.method_167()))
										{
											list_8.Add(aircraft);
											if (!list_5.Contains(aircraft.method_167().DBID))
											{
												list_5.Add(aircraft.method_167().DBID);
											}
										}
									}
								}
								else if (!Information.IsNothing(aircraft_AirOps.method_30()))
								{
									if (!list_11.Contains(aircraft_AirOps.method_30()))
									{
										list_11.Add(aircraft_AirOps.method_30());
									}
									Aircraft aircraft4 = aircraft;
									string text = null;
									if (aircraft4.method_147(ref text) == Aircraft_AirOps.Enum44.const_0 && (aircraft.vmethod_123() || (!bool_22 && aircraft.vmethod_124())))
									{
										if (!Information.IsNothing(aircraft.method_167()))
										{
											list_8.Add(aircraft);
											if (!list_5.Contains(aircraft.method_167().DBID))
											{
												list_5.Add(aircraft.method_167().DBID);
											}
											if (aircraft.method_158().bool_2)
											{
												if (aircraft.method_167().method_12())
												{
													int_12++;
												}
												else
												{
													int_11++;
												}
											}
											else
											{
												int_10++;
											}
										}
									}
									else if (aircraft_AirOps.method_22())
									{
										if (aircraft.method_158().bool_2)
										{
											if (aircraft.method_167().method_12())
											{
												int_9++;
											}
											else
											{
												int_8++;
											}
										}
										else
										{
											int_7++;
										}
									}
								}
								else if (aircraft.method_158().bool_2)
								{
									if (aircraft.method_167().method_12())
									{
										int_9++;
									}
									else
									{
										int_8++;
									}
								}
								else
								{
									int_7++;
								}
							}
						}
						else if (activeUnit.bool_6 || activeUnit.bool_5)
						{
							list_13.Add(activeUnit);
							if (!list_12.Contains(activeUnit.DBID))
							{
								list_12.Add(activeUnit.DBID);
							}
							if (!Information.IsNothing(activeUnit.vmethod_93().method_17()))
							{
								if (!list_15.Contains(activeUnit.vmethod_93().method_17()))
								{
									list_15.Add(activeUnit.vmethod_93().method_17());
								}
								if (activeUnit.vmethod_93().method_8() == ActiveUnit_DockingOps._DockingOpsCondition.Docked)
								{
									list_14.Add(activeUnit);
								}
							}
						}
					}
				}
				if (!bool_24 && bool_23 && list_16.Count > 0)
				{
					int num2 = list_16.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						ActiveUnit activeUnit = list_16[j];
						Aircraft aircraft5 = (Aircraft)activeUnit;
						list_7.Add(aircraft5);
						if (!Information.IsNothing(aircraft5.method_157().method_7()))
						{
							list_18.Add(aircraft5);
							list_21.Add(aircraft5.method_157().method_7());
						}
						else
						{
							list_8.Add(aircraft5);
							Aircraft_AirOps aircraft_AirOps2 = aircraft5.method_164();
							if (!list_6.Contains(aircraft5.DBID))
							{
								list_6.Add(aircraft5.DBID);
							}
							if (!Information.IsNothing(aircraft_AirOps2.method_30()))
							{
								if (!list_11.Contains(aircraft_AirOps2.method_30()))
								{
									list_11.Add(aircraft_AirOps2.method_30());
								}
								if (!Information.IsNothing(aircraft5.method_167()))
								{
									list_17.Add(aircraft5);
									if (!list_5.Contains(aircraft5.method_167().DBID))
									{
										list_5.Add(aircraft5.method_167().DBID);
									}
									if (aircraft5.method_158().bool_2)
									{
										if (aircraft5.method_167().method_12())
										{
											int_15++;
										}
										else
										{
											int_14++;
										}
									}
									else
									{
										int_13++;
									}
								}
							}
						}
					}
				}
				if (!bool_24)
				{
					try
					{
						foreach (Mission.Flight item in list_20)
						{
							if (list_19.Contains(item))
							{
								list_19.Remove(item);
							}
						}
					}
					finally
					{
						List<Mission.Flight>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101241", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0017BB58 File Offset: 0x00179D58
		public void method_19(ref Scenario scenario_0, ref Side side_0, bool? nullable_4)
		{
			if (Information.IsNothing(nullable_4))
			{
				try
				{
					List<Mission.Flight>.Enumerator enumerator = this.list_1.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.method_12())
						{
							nullable_4 = new bool?(true);
							break;
						}
					}
				}
				finally
				{
					List<Mission.Flight>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if ((nullable_4 & !Information.IsNothing(nullable_4)).GetValueOrDefault())
			{
				Mission._MissionClass missionClass_ = this._MissionClass_0;
				if (missionClass_ == Mission._MissionClass.Strike)
				{
					Strike strike = (Strike)this;
					if (strike._FlightQty_0 != Mission._FlightQty.NoPreferences)
					{
						strike._FlightQty_0 = Mission._FlightQty.NoPreferences;
						scenario_0.method_59("Mission " + this.Name + " uses pre-planned flights, and it therefore makes no sense to specify a minimum number of flights required to fly. Re-setting parameter to 'No Preferences'.", this.Name + " resetting min # of flights", LoggedMessage.MessageType.SpecialMessage, 0, null, side_0, default(Geopoint_Struct));
					}
					if (strike._FlightQty_3 != Mission._FlightQty.NoPreferences)
					{
						strike._FlightQty_3 = Mission._FlightQty.NoPreferences;
						scenario_0.method_59("Mission " + this.Name + " uses pre-planned flights, and it therefore makes no sense to specify a maximum number of flights allowed to fly. Re-setting parameter to 'No Preferences'.", this.Name + " resetting max # of flights", LoggedMessage.MessageType.SpecialMessage, 0, null, side_0, default(Geopoint_Struct));
					}
					if (strike._FlightQty_1 != Mission._FlightQty.NoPreferences)
					{
						strike._FlightQty_1 = Mission._FlightQty.NoPreferences;
						scenario_0.method_59("Mission " + this.Name + " uses pre-planned flights, and it therefore makes no sense to specify a minimum number of Escort flights (shooters) required to fly. Re-setting parameter to 'No Preferences'.", this.Name + " resetting min # of armed escorts", LoggedMessage.MessageType.SpecialMessage, 0, null, side_0, default(Geopoint_Struct));
					}
					if (strike._FlightQty_4 != Mission._FlightQty.NoPreferences)
					{
						strike._FlightQty_4 = Mission._FlightQty.NoPreferences;
						scenario_0.method_59("Mission " + this.Name + " uses pre-planned flights, and it therefore makes no sense to specify a maximum number of Escort flights (shooters) allowed to fly. Re-setting parameter to 'No Preferences'.", this.Name + " resetting max # of armed escorts", LoggedMessage.MessageType.SpecialMessage, 0, null, side_0, default(Geopoint_Struct));
					}
					if (strike._FlightQty_2 != Mission._FlightQty.NoPreferences)
					{
						strike._FlightQty_2 = Mission._FlightQty.NoPreferences;
						scenario_0.method_59("Mission " + this.Name + " uses pre-planned flights, and it therefore makes no sense to specify a minimum number of Escort flights (non-shooters) required to fly. Re-setting parameter to 'No Preferences'.", this.Name + " resetting min # of unarmed escorts", LoggedMessage.MessageType.SpecialMessage, 0, null, side_0, default(Geopoint_Struct));
					}
					if (strike._FlightQty_5 != Mission._FlightQty.NoPreferences)
					{
						strike._FlightQty_5 = Mission._FlightQty.NoPreferences;
						scenario_0.method_59("Mission " + this.Name + " uses pre-planned flights, and it therefore makes no sense to specify a maximum number of Escort flights (non-shooters) allowed to fly. Re-setting parameter to 'No Preferences'.", this.Name + " resetting max # of armed escorts", LoggedMessage.MessageType.SpecialMessage, 0, null, side_0, default(Geopoint_Struct));
					}
				}
			}
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x0017BDBC File Offset: 0x00179FBC
		public void method_20(ref Scenario scenario_0, ref Side side_0, ref Mission.Flight flight_0)
		{
			try
			{
				if (!Information.IsNothing(flight_0))
				{
					foreach (ActiveUnit activeUnit in side_0.activeUnit_0)
					{
						if (activeUnit.vmethod_85().method_48() && Operators.CompareString(activeUnit.vmethod_85().method_7().string_0, flight_0.string_0, false) == 0)
						{
							this.method_21(ref scenario_0, ref flight_0, ref activeUnit);
						}
					}
					flight_0.method_33(scenario_0, null);
					flight_0.string_11 = "";
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

		// Token: 0x06001410 RID: 5136 RVA: 0x0017BE88 File Offset: 0x0017A088
		public void method_21(ref Scenario scenario_0, ref Mission.Flight flight_0, ref ActiveUnit activeUnit_0)
		{
			try
			{
				if (!Information.IsNothing(flight_0))
				{
					activeUnit_0.vmethod_85().vmethod_10();
					if (Information.IsNothing(this.list_2))
					{
						this.list_2 = new List<Mission.EmptyAircraftSlot>();
					}
					if (activeUnit_0.bool_3)
					{
						Aircraft aircraft = (Aircraft)activeUnit_0;
						int dbid;
						string name;
						if (!Information.IsNothing(aircraft.method_167()))
						{
							dbid = aircraft.method_167().DBID;
							name = aircraft.method_167().Name;
						}
						string string_;
						string name2;
						if (!Information.IsNothing(aircraft.method_164().method_30()))
						{
							string_ = aircraft.method_164().method_30().string_0;
							name2 = aircraft.method_164().method_30().Name;
						}
						ActiveUnit activeUnit_ = null;
						int dbid2 = activeUnit_0.DBID;
						string string_2 = activeUnit_0.string_2;
						int num = dbid;
						string string_3 = name;
						ActiveUnit activeUnit = null;
						Mission.EmptyAircraftSlot emptyAircraftSlot = new Mission.EmptyAircraftSlot(activeUnit_, dbid2, string_2, num, string_3, ref activeUnit, string_, name2, activeUnit_0.vmethod_86().bool_2);
						int enum106_ = (int)activeUnit_0.enum106_0;
						this.list_2.Add(emptyAircraftSlot);
						emptyAircraftSlot.method_7(scenario_0, flight_0, enum106_);
						emptyAircraftSlot.method_4(scenario_0, aircraft.method_164().method_30());
						emptyAircraftSlot.string_4 = name2;
						emptyAircraftSlot.string_3 = string_;
						this.method_17(scenario_0, flight_0);
					}
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

		// Token: 0x06001411 RID: 5137 RVA: 0x0017C010 File Offset: 0x0017A210
		public void method_22(Scenario scenario_0, ref Side side_0, ref bool bool_22, Mission.Flight flight_0, bool bool_23)
		{
			Mission.Class290 @class = new Mission.Class290(@class);
			@class.scenario_0 = scenario_0;
			try
			{
				if (this.enum88_0 != Mission.Enum88.const_2)
				{
					if (!Information.IsNothing(this.list_2) && this.list_2.Count != 0)
					{
						List<ActiveUnit> list = new List<ActiveUnit>();
						new List<ActiveUnit>();
						new List<ActiveUnit>();
						new List<ActiveUnit>();
						List<ActiveUnit> list2 = Enumerable.ToList<ActiveUnit>(this.method_15(@class.scenario_0));
						list.AddRange(Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list2, (Mission._Closure$__.$I82-0 == null) ? (Mission._Closure$__.$I82-0 = new Func<ActiveUnit, bool>(Mission._Closure$__.$I.method_0)) : Mission._Closure$__.$I82-0)));
						bool flag = true;
						if (this._MissionClass_0 == Mission._MissionClass.Patrol)
						{
							int count = list2.Count;
							int num = this.method_34(ref this._FlightSize_0, ref ((Class343)this)._FlightQty_4);
							if (count < num)
							{
								flag = false;
							}
						}
						else if (this._MissionClass_0 == Mission._MissionClass.Support)
						{
							int count2 = list2.Count;
							int num2 = this.method_34(ref this._FlightSize_0, ref ((Class344)this)._FlightQty_2);
							if (count2 < num2)
							{
								flag = false;
							}
						}
						if (!flag)
						{
							try
							{
								foreach (Mission.Flight flight in this.list_1)
								{
									if (flight._FlightTask_0 == Mission._FlightTask.const_48)
									{
										this.method_20(ref @class.scenario_0, ref side_0, ref flight);
									}
								}
							}
							finally
							{
								List<Mission.Flight>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						Mission mission2;
						if (this.enum88_0 == Mission.Enum88.const_1)
						{
							try
							{
								foreach (Mission mission in side_0.method_35())
								{
									if (Operators.CompareString(mission.string_0, this.method_13(side_0), false) == 0)
									{
										mission2 = mission;
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
							if (Information.IsNothing(mission2))
							{
								GameGeneral.smethod_1("Could not find the mission's Task Pool!");
								return;
							}
							list.AddRange(Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(mission2.method_16(@class.scenario_0), (Mission._Closure$__.$I82-1 == null) ? (Mission._Closure$__.$I82-1 = new Func<ActiveUnit, bool>(Mission._Closure$__.$I.method_1)) : Mission._Closure$__.$I82-1)));
						}
						if (list.Count == 0)
						{
							if (bool_22)
							{
								if (this.enum88_0 == Mission.Enum88.const_1)
								{
									GameGeneral.smethod_1("Could not find any available aircraft in the Package or Task Pool!");
								}
								else
								{
									GameGeneral.smethod_1("Could not find any available aircraft on the Mission!");
								}
							}
							else if (this.int_0 == 0)
							{
								if (this.enum88_0 == Mission.Enum88.const_1)
								{
									@class.scenario_0.method_59("Package " + this.Name + " could not find any available aircraft in the Package or Task Pool!", this.Name + " cannot find AC", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
								}
								else
								{
									@class.scenario_0.method_59("Mission " + this.Name + " could not find any available aircraft!", this.Name + " cannot find AC", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
								}
							}
							this.method_17(@class.scenario_0, null);
						}
						else
						{
							List<Mission.EmptyAircraftSlot> list3 = new List<Mission.EmptyAircraftSlot>();
							list3.AddRange(Enumerable.ToList<Mission.EmptyAircraftSlot>(Enumerable.OrderByDescending<Mission.EmptyAircraftSlot, string>(Enumerable.Where<Mission.EmptyAircraftSlot>(this.list_2, new Func<Mission.EmptyAircraftSlot, bool>(@class.method_0)), new Func<Mission.EmptyAircraftSlot, string>(@class.method_1))));
							list3.AddRange(Enumerable.ToList<Mission.EmptyAircraftSlot>(Enumerable.ThenByDescending<Mission.EmptyAircraftSlot, string>(Enumerable.ThenByDescending<Mission.EmptyAircraftSlot, DateTime?>(Enumerable.OrderByDescending<Mission.EmptyAircraftSlot, bool>(Enumerable.Where<Mission.EmptyAircraftSlot>(this.list_2, new Func<Mission.EmptyAircraftSlot, bool>(@class.method_2)), (Mission._Closure$__.$I82-5 == null) ? (Mission._Closure$__.$I82-5 = new Func<Mission.EmptyAircraftSlot, bool>(Mission._Closure$__.$I.method_2)) : Mission._Closure$__.$I82-5), new Func<Mission.EmptyAircraftSlot, DateTime?>(@class.method_3)), new Func<Mission.EmptyAircraftSlot, string>(@class.method_4))));
							if (bool_22 && Enumerable.Count<Mission.EmptyAircraftSlot>(Enumerable.Where<Mission.EmptyAircraftSlot>(this.list_2, new Func<Mission.EmptyAircraftSlot, bool>(@class.method_5))) > 0)
							{
								GameGeneral.smethod_1("At least one pre-planned flight is lacking a flightplan. Only flights with flightplans can be filled with aircraft.");
							}
							if (!Information.IsNothing(list3) && list3.Count != 0)
							{
								if (!Information.IsNothing(list3))
								{
									for (int i = list3.Count - 1; i >= 0; i += -1)
									{
										Mission.EmptyAircraftSlot emptyAircraftSlot = list3[i];
										if (!Information.IsNothing(emptyAircraftSlot.method_5(@class.scenario_0)) && (Information.IsNothing(flight_0) || Operators.CompareString(flight_0.string_0, emptyAircraftSlot.string_2, false) == 0) && emptyAircraftSlot.method_5(@class.scenario_0).enum93_0 != Mission.Enum93.const_1 && (flag || emptyAircraftSlot.method_5(@class.scenario_0)._FlightTask_0 != Mission._FlightTask.const_48))
										{
											try
											{
												foreach (ActiveUnit activeUnit in list)
												{
													if (activeUnit.DBID == emptyAircraftSlot.int_0)
													{
														Aircraft aircraft = (Aircraft)activeUnit;
														if (aircraft.method_166() == emptyAircraftSlot.int_1 && !Information.IsNothing(aircraft.method_164().method_30()) && Operators.CompareString(aircraft.method_164().method_30().string_0, emptyAircraftSlot.string_3, false) == 0 && aircraft.method_164().method_38() <= 0f)
														{
															if (aircraft.method_164().method_36() != Aircraft_AirOps._AirOpsCondition.Parked)
															{
																if (aircraft.method_164().method_36() != Aircraft_AirOps._AirOpsCondition.Readying)
																{
																	continue;
																}
															}
															aircraft.method_157().method_8(emptyAircraftSlot.method_5(@class.scenario_0));
															aircraft.method_157().method_7().method_33(@class.scenario_0, aircraft);
															aircraft.method_157().method_7().int_2 = aircraft.DBID;
															aircraft.method_157().method_7().string_11 = aircraft.string_0;
															aircraft.method_157().method_7().string_12 = aircraft.string_2;
															if (!Information.IsNothing(aircraft.method_167()))
															{
																aircraft.method_157().method_7().int_3 = aircraft.method_167().DBID;
																aircraft.method_157().method_7().method_14(@class.scenario_0, aircraft.method_167().Name);
															}
															this.list_2.Remove(emptyAircraftSlot);
															list3.Remove(emptyAircraftSlot);
															ActiveUnit activeUnit2 = aircraft;
															bool setMissionOnly = false;
															Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
															activeUnit2.vmethod_102(this, setMissionOnly, ref missionAssignmentAttemptResult);
															aircraft.method_158().bool_2 = emptyAircraftSlot.bool_2;
															aircraft.doctrine_0.method_4();
															list.Remove(aircraft);
															break;
														}
													}
												}
											}
											finally
											{
												List<ActiveUnit>.Enumerator enumerator3;
												((IDisposable)enumerator3).Dispose();
											}
											if (list.Count == 0)
											{
												this.method_17(@class.scenario_0, null);
												return;
											}
										}
									}
								}
								list.Clear();
								list.AddRange(Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(this.method_15(@class.scenario_0), (Mission._Closure$__.$I82-9 == null) ? (Mission._Closure$__.$I82-9 = new Func<ActiveUnit, bool>(Mission._Closure$__.$I.method_3)) : Mission._Closure$__.$I82-9)));
								if (this.enum88_0 == Mission.Enum88.const_1)
								{
									list.AddRange(Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(mission2.method_16(@class.scenario_0), (Mission._Closure$__.$I82-10 == null) ? (Mission._Closure$__.$I82-10 = new Func<ActiveUnit, bool>(Mission._Closure$__.$I.method_4)) : Mission._Closure$__.$I82-10)));
								}
								if (list.Count == 0)
								{
									this.method_17(@class.scenario_0, null);
								}
								else if (list3.Count == 0)
								{
									this.method_17(@class.scenario_0, null);
								}
								else
								{
									if (!Information.IsNothing(list3))
									{
										for (int j = list3.Count - 1; j >= 0; j += -1)
										{
											Mission.EmptyAircraftSlot emptyAircraftSlot = list3[j];
											if (!Information.IsNothing(emptyAircraftSlot.method_5(@class.scenario_0)) && (Information.IsNothing(flight_0) || Operators.CompareString(flight_0.string_0, emptyAircraftSlot.string_2, false) == 0) && emptyAircraftSlot.method_5(@class.scenario_0).enum93_0 != Mission.Enum93.const_1 && (flag || emptyAircraftSlot.method_5(@class.scenario_0)._FlightTask_0 != Mission._FlightTask.const_48))
											{
												try
												{
													foreach (ActiveUnit activeUnit3 in list)
													{
														if (activeUnit3.DBID == emptyAircraftSlot.int_0)
														{
															Aircraft aircraft2 = (Aircraft)activeUnit3;
															if (aircraft2.method_166() == emptyAircraftSlot.int_1 && !Information.IsNothing(aircraft2.method_164().method_30()) && Operators.CompareString(aircraft2.method_164().method_30().string_0, emptyAircraftSlot.string_3, false) == 0 && (aircraft2.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Parked || aircraft2.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Readying) && aircraft2.method_164().method_38() < (float)(aircraft2.method_167().int_2 * 60))
															{
																if (Enumerable.Count<Waypoint>(emptyAircraftSlot.method_5(@class.scenario_0).method_15()) > 0 && !Information.IsNothing(emptyAircraftSlot.method_5(@class.scenario_0).method_15()[0].nullable_7))
																{
																	DateTime t = @class.scenario_0.method_31().AddSeconds((double)aircraft2.method_164().method_38());
																	DateTime? nullable_ = emptyAircraftSlot.method_5(@class.scenario_0).method_15()[0].nullable_7;
																	if (((nullable_ != null) ? new bool?(DateTime.Compare(t, nullable_.GetValueOrDefault()) > 0) : null).GetValueOrDefault())
																	{
																		continue;
																	}
																}
																aircraft2.method_157().method_8(emptyAircraftSlot.method_5(@class.scenario_0));
																aircraft2.method_157().method_7().method_33(@class.scenario_0, aircraft2);
																aircraft2.method_157().method_7().int_2 = aircraft2.DBID;
																aircraft2.method_157().method_7().string_11 = aircraft2.string_0;
																aircraft2.method_157().method_7().string_12 = aircraft2.string_2;
																if (!Information.IsNothing(aircraft2.method_167()))
																{
																	aircraft2.method_157().method_7().int_3 = aircraft2.method_167().DBID;
																	aircraft2.method_157().method_7().method_14(@class.scenario_0, aircraft2.method_167().Name);
																}
																this.list_2.Remove(emptyAircraftSlot);
																list3.Remove(emptyAircraftSlot);
																ActiveUnit activeUnit4 = aircraft2;
																bool setMissionOnly2 = false;
																Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
																activeUnit4.vmethod_102(this, setMissionOnly2, ref missionAssignmentAttemptResult);
																aircraft2.method_158().bool_2 = emptyAircraftSlot.bool_2;
																aircraft2.doctrine_0.method_4();
																list.Remove(aircraft2);
																break;
															}
														}
													}
												}
												finally
												{
													List<ActiveUnit>.Enumerator enumerator4;
													((IDisposable)enumerator4).Dispose();
												}
												if (list.Count == 0)
												{
													this.method_17(@class.scenario_0, null);
													return;
												}
											}
										}
									}
									list.Clear();
									list.AddRange(Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(this.method_15(@class.scenario_0), (Mission._Closure$__.$I82-11 == null) ? (Mission._Closure$__.$I82-11 = new Func<ActiveUnit, bool>(Mission._Closure$__.$I.method_5)) : Mission._Closure$__.$I82-11)));
									if (this.enum88_0 == Mission.Enum88.const_1)
									{
										list.AddRange(Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(mission2.method_16(@class.scenario_0), (Mission._Closure$__.$I82-12 == null) ? (Mission._Closure$__.$I82-12 = new Func<ActiveUnit, bool>(Mission._Closure$__.$I.method_6)) : Mission._Closure$__.$I82-12)));
									}
									if (list.Count == 0)
									{
										this.method_17(@class.scenario_0, null);
									}
									else if (list3.Count == 0)
									{
										this.method_17(@class.scenario_0, null);
									}
									else
									{
										if (!Information.IsNothing(list3))
										{
											for (int k = list3.Count - 1; k >= 0; k += -1)
											{
												Mission.EmptyAircraftSlot emptyAircraftSlot = list3[k];
												if (!Information.IsNothing(emptyAircraftSlot.method_5(@class.scenario_0)) && (Information.IsNothing(flight_0) || Operators.CompareString(flight_0.string_0, emptyAircraftSlot.string_2, false) == 0) && emptyAircraftSlot.method_5(@class.scenario_0).enum93_0 != Mission.Enum93.const_1 && (flag || emptyAircraftSlot.method_5(@class.scenario_0)._FlightTask_0 != Mission._FlightTask.const_48))
												{
													try
													{
														foreach (ActiveUnit activeUnit5 in list)
														{
															if (activeUnit5.DBID == emptyAircraftSlot.int_0)
															{
																Aircraft aircraft3 = (Aircraft)activeUnit5;
																if (!Information.IsNothing(aircraft3.method_164().method_30()) && Operators.CompareString(aircraft3.method_164().method_30().string_0, emptyAircraftSlot.string_3, false) == 0 && aircraft3.method_167().loadoutRole_0 != Loadout.LoadoutRole.Unavailable && (aircraft3.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Parked || aircraft3.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Readying) && emptyAircraftSlot.int_1 != 0)
																{
																	Loadout loadout = DBFunctions.smethod_47(ref aircraft3.scenario_0, emptyAircraftSlot.int_1, false, false);
																	if (aircraft3.method_164().method_38() <= (float)(loadout.int_2 * 60))
																	{
																		if (Enumerable.Count<Waypoint>(emptyAircraftSlot.method_5(@class.scenario_0).method_15()) > 0 && !Information.IsNothing(emptyAircraftSlot.method_5(@class.scenario_0).method_15()[0].nullable_7))
																		{
																			DateTime t = @class.scenario_0.method_31().AddMinutes((double)loadout.int_2);
																			DateTime? nullable_ = emptyAircraftSlot.method_5(@class.scenario_0).method_15()[0].nullable_7;
																			if (((nullable_ != null) ? new bool?(DateTime.Compare(t, nullable_.GetValueOrDefault()) > 0) : null).GetValueOrDefault())
																			{
																				continue;
																			}
																		}
																		if ((aircraft3.method_164().method_15(ref aircraft3, loadout, emptyAircraftSlot.int_1, emptyAircraftSlot.bool_0) || aircraft3.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2)) && Operators.CompareString(aircraft3.method_164().method_16(ref aircraft3, emptyAircraftSlot.int_1, aircraft3.method_166(), false, emptyAircraftSlot.bool_0, !aircraft3.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2), false, false), "OK", false) == 0)
																		{
																			aircraft3.method_157().method_8(emptyAircraftSlot.method_5(@class.scenario_0));
																			aircraft3.method_157().method_7().method_33(@class.scenario_0, aircraft3);
																			aircraft3.method_157().method_7().int_2 = aircraft3.DBID;
																			aircraft3.method_157().method_7().string_11 = aircraft3.string_0;
																			aircraft3.method_157().method_7().string_12 = aircraft3.string_2;
																			if (!Information.IsNothing(aircraft3.method_167()))
																			{
																				aircraft3.method_157().method_7().int_3 = aircraft3.method_167().DBID;
																				aircraft3.method_157().method_7().method_14(@class.scenario_0, aircraft3.method_167().Name);
																			}
																			this.list_2.Remove(emptyAircraftSlot);
																			list3.Remove(emptyAircraftSlot);
																			ActiveUnit activeUnit6 = aircraft3;
																			bool setMissionOnly3 = false;
																			Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
																			activeUnit6.vmethod_102(this, setMissionOnly3, ref missionAssignmentAttemptResult);
																			aircraft3.method_158().bool_2 = emptyAircraftSlot.bool_2;
																			aircraft3.doctrine_0.method_4();
																			list.Remove(aircraft3);
																			break;
																		}
																	}
																}
															}
														}
													}
													finally
													{
														List<ActiveUnit>.Enumerator enumerator5;
														((IDisposable)enumerator5).Dispose();
													}
													if (list.Count == 0)
													{
														this.method_17(@class.scenario_0, null);
														return;
													}
												}
											}
										}
										list.Clear();
										list.AddRange(Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(this.method_15(@class.scenario_0), (Mission._Closure$__.$I82-13 == null) ? (Mission._Closure$__.$I82-13 = new Func<ActiveUnit, bool>(Mission._Closure$__.$I.method_7)) : Mission._Closure$__.$I82-13)));
										if (this.enum88_0 == Mission.Enum88.const_1)
										{
											list.AddRange(Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(mission2.method_16(@class.scenario_0), (Mission._Closure$__.$I82-14 == null) ? (Mission._Closure$__.$I82-14 = new Func<ActiveUnit, bool>(Mission._Closure$__.$I.method_8)) : Mission._Closure$__.$I82-14)));
										}
										if (list.Count == 0)
										{
											this.method_17(@class.scenario_0, null);
										}
										else if (list3.Count == 0)
										{
											this.method_17(@class.scenario_0, null);
										}
										else
										{
											if (!Information.IsNothing(list3))
											{
												for (int l = list3.Count - 1; l >= 0; l += -1)
												{
													Mission.EmptyAircraftSlot emptyAircraftSlot = list3[l];
													if (!Information.IsNothing(emptyAircraftSlot.method_5(@class.scenario_0)) && (Information.IsNothing(flight_0) || Operators.CompareString(flight_0.string_0, emptyAircraftSlot.string_2, false) == 0) && emptyAircraftSlot.method_5(@class.scenario_0).enum93_0 != Mission.Enum93.const_1 && (flag || emptyAircraftSlot.method_5(@class.scenario_0)._FlightTask_0 != Mission._FlightTask.const_48))
													{
														try
														{
															foreach (ActiveUnit activeUnit7 in list)
															{
																if (activeUnit7.DBID == emptyAircraftSlot.int_0)
																{
																	Aircraft aircraft4 = (Aircraft)activeUnit7;
																	if (!Information.IsNothing(aircraft4.method_164().method_30()) && Operators.CompareString(aircraft4.method_164().method_30().string_0, emptyAircraftSlot.string_3, false) == 0 && aircraft4.method_167().loadoutRole_0 != Loadout.LoadoutRole.Unavailable && (aircraft4.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Parked || aircraft4.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Readying) && emptyAircraftSlot.int_1 != 0)
																	{
																		Loadout loadout2 = DBFunctions.smethod_47(ref aircraft4.scenario_0, emptyAircraftSlot.int_1, false, false);
																		if (Enumerable.Count<Waypoint>(emptyAircraftSlot.method_5(@class.scenario_0).method_15()) > 0 && !Information.IsNothing(emptyAircraftSlot.method_5(@class.scenario_0).method_15()[0].nullable_7))
																		{
																			if (aircraft4.method_164().method_38() > (float)(loadout2.int_2 * 60))
																			{
																				DateTime t = @class.scenario_0.method_31().AddSeconds((double)aircraft4.method_164().method_38());
																				DateTime? nullable_ = emptyAircraftSlot.method_5(@class.scenario_0).method_15()[0].nullable_7;
																				if (((nullable_ != null) ? new bool?(DateTime.Compare(t, nullable_.GetValueOrDefault()) > 0) : null).GetValueOrDefault())
																				{
																					continue;
																				}
																			}
																			else
																			{
																				DateTime t = @class.scenario_0.method_31().AddMinutes((double)loadout2.int_2);
																				DateTime? nullable_ = emptyAircraftSlot.method_5(@class.scenario_0).method_15()[0].nullable_7;
																				if (((nullable_ != null) ? new bool?(DateTime.Compare(t, nullable_.GetValueOrDefault()) > 0) : null).GetValueOrDefault())
																				{
																					continue;
																				}
																			}
																		}
																		if ((aircraft4.method_164().method_15(ref aircraft4, loadout2, emptyAircraftSlot.int_1, emptyAircraftSlot.bool_0) || aircraft4.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2)) && Operators.CompareString(aircraft4.method_164().method_16(ref aircraft4, emptyAircraftSlot.int_1, aircraft4.method_166(), false, emptyAircraftSlot.bool_0, !aircraft4.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2), false, false), "OK", false) == 0)
																		{
																			aircraft4.method_157().method_8(emptyAircraftSlot.method_5(@class.scenario_0));
																			aircraft4.method_157().method_7().method_33(@class.scenario_0, aircraft4);
																			aircraft4.method_157().method_7().int_2 = aircraft4.DBID;
																			aircraft4.method_157().method_7().string_11 = aircraft4.string_0;
																			aircraft4.method_157().method_7().string_12 = aircraft4.string_2;
																			if (!Information.IsNothing(aircraft4.method_167()))
																			{
																				aircraft4.method_157().method_7().int_3 = aircraft4.method_167().DBID;
																				aircraft4.method_157().method_7().method_14(@class.scenario_0, aircraft4.method_167().Name);
																			}
																			this.list_2.Remove(emptyAircraftSlot);
																			list3.Remove(emptyAircraftSlot);
																			ActiveUnit activeUnit8 = aircraft4;
																			bool setMissionOnly4 = false;
																			Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
																			activeUnit8.vmethod_102(this, setMissionOnly4, ref missionAssignmentAttemptResult);
																			aircraft4.method_158().bool_2 = emptyAircraftSlot.bool_2;
																			aircraft4.doctrine_0.method_4();
																			list.Remove(aircraft4);
																			break;
																		}
																	}
																}
															}
														}
														finally
														{
															List<ActiveUnit>.Enumerator enumerator6;
															((IDisposable)enumerator6).Dispose();
														}
														if (list.Count == 0)
														{
															this.method_17(@class.scenario_0, null);
															return;
														}
													}
												}
											}
											if (bool_23)
											{
												list.Clear();
												list.AddRange(Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(this.method_15(@class.scenario_0), (Mission._Closure$__.$I82-15 == null) ? (Mission._Closure$__.$I82-15 = new Func<ActiveUnit, bool>(Mission._Closure$__.$I.method_9)) : Mission._Closure$__.$I82-15)));
												if (this.enum88_0 == Mission.Enum88.const_1)
												{
													list.AddRange(Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(mission2.method_16(@class.scenario_0), (Mission._Closure$__.$I82-16 == null) ? (Mission._Closure$__.$I82-16 = new Func<ActiveUnit, bool>(Mission._Closure$__.$I.method_10)) : Mission._Closure$__.$I82-16)));
												}
												if (list.Count == 0)
												{
													this.method_17(@class.scenario_0, null);
													return;
												}
												if (list3.Count == 0)
												{
													this.method_17(@class.scenario_0, null);
													return;
												}
												if (!Information.IsNothing(list3))
												{
													for (int m = list3.Count - 1; m >= 0; m += -1)
													{
														Mission.EmptyAircraftSlot emptyAircraftSlot = list3[m];
														if (!Information.IsNothing(emptyAircraftSlot.method_5(@class.scenario_0)) && (Information.IsNothing(flight_0) || Operators.CompareString(flight_0.string_0, emptyAircraftSlot.string_2, false) == 0) && emptyAircraftSlot.method_5(@class.scenario_0).enum93_0 != Mission.Enum93.const_1 && (flag || emptyAircraftSlot.method_5(@class.scenario_0)._FlightTask_0 != Mission._FlightTask.const_48) && (emptyAircraftSlot.int_0 <= 0 || emptyAircraftSlot.int_1 <= 0))
														{
															try
															{
																foreach (ActiveUnit activeUnit9 in list)
																{
																	if (emptyAircraftSlot.int_0 <= 0 || activeUnit9.DBID == emptyAircraftSlot.int_0)
																	{
																		Aircraft aircraft5 = (Aircraft)activeUnit9;
																		if (!Information.IsNothing(aircraft5.method_164().method_30()) && Operators.CompareString(aircraft5.method_164().method_30().string_0, emptyAircraftSlot.string_3, false) == 0 && aircraft5.method_167().loadoutRole_0 != Loadout.LoadoutRole.Unavailable && aircraft5.method_167().loadoutRole_0 != Loadout.LoadoutRole.Reserve && (aircraft5.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Parked || aircraft5.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Readying))
																		{
																			if (Enumerable.Count<Waypoint>(emptyAircraftSlot.method_5(@class.scenario_0).method_15()) > 0 && !Information.IsNothing(emptyAircraftSlot.method_5(@class.scenario_0).method_15()[0].nullable_7) && aircraft5.method_164().method_38() > 0f)
																			{
																				DateTime t = @class.scenario_0.method_31().AddSeconds((double)aircraft5.method_164().method_38());
																				DateTime? nullable_ = emptyAircraftSlot.method_5(@class.scenario_0).method_15()[0].nullable_7;
																				if (((nullable_ != null) ? new bool?(DateTime.Compare(t, nullable_.GetValueOrDefault()) > 0) : null).GetValueOrDefault())
																				{
																					continue;
																				}
																			}
																			aircraft5.method_157().method_8(emptyAircraftSlot.method_5(@class.scenario_0));
																			aircraft5.method_157().method_7().method_33(@class.scenario_0, aircraft5);
																			aircraft5.method_157().method_7().int_2 = aircraft5.DBID;
																			aircraft5.method_157().method_7().string_11 = aircraft5.string_0;
																			aircraft5.method_157().method_7().string_12 = aircraft5.string_2;
																			if (!Information.IsNothing(aircraft5.method_167()))
																			{
																				aircraft5.method_157().method_7().int_3 = aircraft5.method_167().DBID;
																				aircraft5.method_157().method_7().method_14(@class.scenario_0, aircraft5.method_167().Name);
																			}
																			aircraft5.method_158().bool_2 = emptyAircraftSlot.bool_2;
																			this.list_2.Remove(emptyAircraftSlot);
																			list3.Remove(emptyAircraftSlot);
																			ActiveUnit activeUnit10 = aircraft5;
																			bool setMissionOnly5 = false;
																			Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
																			activeUnit10.vmethod_102(this, setMissionOnly5, ref missionAssignmentAttemptResult);
																			aircraft5.doctrine_0.method_4();
																			list.Remove(aircraft5);
																			if (!Information.IsNothing(this.list_2))
																			{
																				for (int n = this.list_2.Count - 1; n >= 0; n += -1)
																				{
																					Mission.EmptyAircraftSlot emptyAircraftSlot2 = this.list_2[n];
																					if (Operators.CompareString(emptyAircraftSlot2.string_2, aircraft5.method_157().method_7().string_0, false) == 0)
																					{
																						emptyAircraftSlot2.method_2(@class.scenario_0, null, aircraft5);
																						emptyAircraftSlot2.int_0 = aircraft5.DBID;
																						emptyAircraftSlot2.string_0 = aircraft5.string_2;
																						if (!Information.IsNothing(aircraft5.method_167()))
																						{
																							emptyAircraftSlot2.int_1 = aircraft5.method_167().DBID;
																							emptyAircraftSlot2.string_1 = aircraft5.method_167().Name;
																						}
																					}
																				}
																			}
																			this.method_22(@class.scenario_0, ref side_0, ref bool_22, aircraft5.method_157().method_7(), false);
																			Scenario scenario_ = @class.scenario_0;
																			ActiveUnit activeUnit_ = aircraft5.method_157().method_7().method_32(@class.scenario_0);
																			Mission.Flight flight_ = aircraft5.method_157().method_7();
																			Mission.Flight flight2;
																			Waypoint[] waypoint_ = (flight2 = aircraft5.method_157().method_7()).method_15();
																			float num3 = 0f;
																			float num4 = 0f;
																			Class514.smethod_28(scenario_, this, activeUnit_, flight_, ref waypoint_, ref num3, ref num4, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
																			flight2.method_16(waypoint_);
																			list.Clear();
																			list.AddRange(Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(this.method_15(@class.scenario_0), (Mission._Closure$__.$I82-17 == null) ? (Mission._Closure$__.$I82-17 = new Func<ActiveUnit, bool>(Mission._Closure$__.$I.method_11)) : Mission._Closure$__.$I82-17)));
																			if (this.enum88_0 == Mission.Enum88.const_1)
																			{
																				list.AddRange(Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(mission2.method_16(@class.scenario_0), (Mission._Closure$__.$I82-18 == null) ? (Mission._Closure$__.$I82-18 = new Func<ActiveUnit, bool>(Mission._Closure$__.$I.method_12)) : Mission._Closure$__.$I82-18)));
																			}
																			break;
																		}
																	}
																}
															}
															finally
															{
																List<ActiveUnit>.Enumerator enumerator7;
																((IDisposable)enumerator7).Dispose();
															}
															if (list.Count == 0)
															{
																this.method_17(@class.scenario_0, null);
																return;
															}
														}
													}
												}
											}
											this.method_17(@class.scenario_0, null);
										}
									}
								}
							}
							else
							{
								this.method_17(@class.scenario_0, null);
							}
						}
					}
					else
					{
						this.method_17(@class.scenario_0, null);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200644", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x0017DC50 File Offset: 0x0017BE50
		public Dictionary<string, Dictionary<string, Dictionary<string, int>>> method_23(ref Scenario scenario_0, bool bool_22, bool bool_23)
		{
			Dictionary<string, Dictionary<string, Dictionary<string, int>>> result;
			try
			{
				Dictionary<string, Dictionary<string, Dictionary<string, int>>> dictionary = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();
				Dictionary<string, Dictionary<string, string>> dictionary2 = new Dictionary<string, Dictionary<string, string>>();
				int num = scenario_0.method_42().Count - 1;
				for (int i = 0; i <= num; i++)
				{
					ActiveUnit activeUnit = scenario_0.method_42()[i];
					if (activeUnit != null && !activeUnit.bool_1 && activeUnit.vmethod_101() == this && activeUnit.bool_3 && (!bool_22 || activeUnit.vmethod_86().bool_2) && (!bool_23 || activeUnit.vmethod_86().bool_2) && (bool_22 || bool_23 || !activeUnit.vmethod_86().bool_2) && (!bool_22 || bool_23 || this._MissionClass_0 != Mission._MissionClass.Strike || ((Strike)this)._FlightSize_2 == Mission._FlightSize.None))
					{
						Aircraft aircraft = (Aircraft)activeUnit;
						Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
						if (aircraft.method_167() != null)
						{
							if (aircraft_AirOps.method_30() != null)
							{
								Dictionary<string, int> dictionary3 = null;
								Dictionary<string, Dictionary<string, int>> dictionary4 = null;
								if (!dictionary.ContainsKey(aircraft_AirOps.method_30().Name))
								{
									dictionary.Add(aircraft_AirOps.method_30().Name, null);
								}
								dictionary.TryGetValue(aircraft_AirOps.method_30().Name, out dictionary4);
								if (dictionary4 == null)
								{
									dictionary4 = new Dictionary<string, Dictionary<string, int>>();
									dictionary4.Add(aircraft.string_2, null);
									dictionary[aircraft_AirOps.method_30().Name] = dictionary4;
								}
								dictionary4.TryGetValue(aircraft.string_2, out dictionary3);
								if (dictionary3 == null)
								{
									dictionary3 = new Dictionary<string, int>();
									dictionary3.Add(aircraft.method_167().Name, 1);
									dictionary4[aircraft.string_2] = dictionary3;
								}
								else
								{
									int num2;
									dictionary3.TryGetValue(aircraft.method_167().Name, out num2);
									if (num2 == 0)
									{
										dictionary3.Add(aircraft.method_167().Name, 1);
									}
									else
									{
										Dictionary<string, int> dictionary5;
										string key;
										(dictionary5 = dictionary3)[key = aircraft.method_167().Name] = dictionary5[key] + 1;
									}
								}
							}
							else if (aircraft_AirOps.method_32(false) != null)
							{
								Dictionary<string, string> dictionary6 = null;
								if (!dictionary2.ContainsKey(aircraft_AirOps.method_32(false).Name))
								{
									dictionary2.Add(aircraft_AirOps.method_32(false).Name, null);
								}
								dictionary2.TryGetValue(aircraft_AirOps.method_32(false).Name, out dictionary6);
								if (dictionary6 == null)
								{
									dictionary6 = new Dictionary<string, string>();
									dictionary6.Add(aircraft.string_2, aircraft.method_167().Name);
									dictionary2[aircraft_AirOps.method_32(false).Name] = dictionary6;
								}
								else
								{
									string text;
									dictionary6.TryGetValue(aircraft.string_2, out text);
									if (text == null && !dictionary6.ContainsKey(aircraft.string_2))
									{
										dictionary6.Add(aircraft.string_2, aircraft.method_167().Name);
									}
								}
							}
						}
					}
				}
				if (this.list_2 != null)
				{
					int num3 = this.list_2.Count - 1;
					for (int j = 0; j <= num3; j++)
					{
						Mission.EmptyAircraftSlot emptyAircraftSlot = this.list_2[j];
						if ((!bool_22 || emptyAircraftSlot.bool_2) && (!bool_23 || emptyAircraftSlot.bool_2) && (bool_22 || bool_23 || !emptyAircraftSlot.bool_2) && (!bool_22 || bool_23 || this._MissionClass_0 != Mission._MissionClass.Strike || ((Strike)this)._FlightSize_2 == Mission._FlightSize.None))
						{
							Dictionary<string, int> dictionary7 = null;
							Dictionary<string, Dictionary<string, int>> dictionary8 = null;
							if (!dictionary.ContainsKey(emptyAircraftSlot.string_4))
							{
								dictionary.Add(emptyAircraftSlot.string_4, null);
							}
							dictionary.TryGetValue(emptyAircraftSlot.string_4, out dictionary8);
							if (dictionary8 == null)
							{
								dictionary8 = new Dictionary<string, Dictionary<string, int>>();
								dictionary8.Add(emptyAircraftSlot.string_0, null);
								dictionary[emptyAircraftSlot.string_4] = dictionary8;
							}
							dictionary8.TryGetValue(emptyAircraftSlot.string_0, out dictionary7);
							if (dictionary7 == null)
							{
								dictionary7 = new Dictionary<string, int>();
								dictionary7.Add(emptyAircraftSlot.string_1, 1);
								dictionary8[emptyAircraftSlot.string_0] = dictionary7;
							}
							else
							{
								int num4;
								dictionary7.TryGetValue(emptyAircraftSlot.string_1, out num4);
								if (num4 == 0)
								{
									dictionary7.Add(emptyAircraftSlot.string_1, 1);
								}
								else
								{
									Dictionary<string, int> dictionary5;
									string key;
									(dictionary5 = dictionary7)[key = emptyAircraftSlot.string_1] = dictionary5[key] + 1;
								}
							}
						}
					}
				}
				try
				{
					foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair in dictionary2)
					{
						Dictionary<string, string> value = keyValuePair.Value;
						try
						{
							foreach (KeyValuePair<string, string> keyValuePair2 in value)
							{
								string value2 = keyValuePair2.Value;
								List<string> list = new List<string>();
								try
								{
									foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, int>>> keyValuePair3 in dictionary)
									{
										List<string> list2 = new List<string>();
										Dictionary<string, Dictionary<string, int>> value3 = keyValuePair3.Value;
										try
										{
											foreach (KeyValuePair<string, Dictionary<string, int>> keyValuePair4 in value3)
											{
												List<string> list3 = new List<string>();
												Dictionary<string, int> value4 = keyValuePair4.Value;
												try
												{
													foreach (KeyValuePair<string, int> keyValuePair5 in value4)
													{
														if (Operators.CompareString(keyValuePair5.Key, value2, false) == 0)
														{
															list3.Add(value2);
														}
													}
												}
												finally
												{
													Dictionary<string, int>.Enumerator enumerator5;
													((IDisposable)enumerator5).Dispose();
												}
												try
												{
													foreach (string key2 in list3)
													{
														value4.Remove(key2);
													}
												}
												finally
												{
													List<string>.Enumerator enumerator6;
													((IDisposable)enumerator6).Dispose();
												}
												if (keyValuePair4.Value.Count == 0)
												{
													list2.Add(keyValuePair4.Key);
												}
											}
										}
										finally
										{
											Dictionary<string, Dictionary<string, int>>.Enumerator enumerator4;
											((IDisposable)enumerator4).Dispose();
										}
										try
										{
											foreach (string key3 in list2)
											{
												value3.Remove(key3);
											}
										}
										finally
										{
											List<string>.Enumerator enumerator7;
											((IDisposable)enumerator7).Dispose();
										}
										if (keyValuePair3.Value.Count == 0)
										{
											list.Add(keyValuePair3.Key);
										}
									}
								}
								finally
								{
									Dictionary<string, Dictionary<string, Dictionary<string, int>>>.Enumerator enumerator3;
									((IDisposable)enumerator3).Dispose();
								}
								try
								{
									foreach (string key4 in list)
									{
										dictionary.Remove(key4);
									}
								}
								finally
								{
									List<string>.Enumerator enumerator8;
									((IDisposable)enumerator8).Dispose();
								}
							}
						}
						finally
						{
							Dictionary<string, string>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
				finally
				{
					Dictionary<string, Dictionary<string, string>>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = dictionary;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101251", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();
			}
			return result;
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0000B2A2 File Offset: 0x000094A2
		public DateTime? method_24()
		{
			return this.nullable_0;
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0017E3DC File Offset: 0x0017C5DC
		public void method_25(DateTime? nullable_4, Scenario scenario_0)
		{
			bool flag = false;
			if (this.nullable_0 == null && nullable_4 != null)
			{
				flag = true;
			}
			else if (nullable_4 == null && this.nullable_0 != null)
			{
				flag = true;
			}
			else
			{
				DateTime? dateTime = this.nullable_0;
				bool? flag2 = (dateTime != null & nullable_4 != null) ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), nullable_4.GetValueOrDefault()) == 0) : null;
				if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
				{
					flag = true;
				}
			}
			this.nullable_0 = nullable_4;
			if (flag)
			{
				Mission.Delegate36 @delegate = Mission.delegate36_0;
				if (@delegate != null)
				{
					@delegate(this);
				}
			}
			this.method_26(scenario_0);
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0017E4AC File Offset: 0x0017C6AC
		private void method_26(Scenario scenario_0)
		{
			bool? flag;
			if (this.method_24() != null)
			{
				DateTime? dateTime = this.method_24();
				DateTime t = scenario_0.method_31();
				flag = ((dateTime != null) ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), t) < 0) : null);
			}
			else
			{
				flag = new bool?(true);
			}
			bool? flag3;
			bool? flag2 = flag3 = flag;
			bool? flag4;
			bool? flag6;
			if (flag3 != null && !flag2.GetValueOrDefault())
			{
				flag4 = new bool?(false);
			}
			else
			{
				bool? flag5;
				if (this.method_27() != null)
				{
					DateTime? dateTime = this.method_27();
					DateTime t = scenario_0.method_31();
					flag5 = ((dateTime != null) ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), t) > 0) : null);
				}
				else
				{
					flag5 = new bool?(true);
				}
				flag6 = (flag3 = flag5);
				flag4 = ((flag3 != null) ? (flag2 & flag6.GetValueOrDefault()) : null);
			}
			flag6 = flag4;
			if (flag6.GetValueOrDefault())
			{
				this.method_11(scenario_0, Mission.Enum89.const_0);
				return;
			}
			this.method_11(scenario_0, Mission.Enum89.const_1);
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x0000B2AA File Offset: 0x000094AA
		public DateTime? method_27()
		{
			return this.nullable_1;
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0017E5C0 File Offset: 0x0017C7C0
		public void method_28(DateTime? nullable_4, Scenario scenario_0)
		{
			bool flag = false;
			if (this.nullable_1 == null && nullable_4 != null)
			{
				flag = true;
			}
			else if (nullable_4 == null && this.nullable_1 != null)
			{
				flag = true;
			}
			else
			{
				DateTime? dateTime = this.nullable_1;
				bool? flag2 = (dateTime != null & nullable_4 != null) ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), nullable_4.GetValueOrDefault()) == 0) : null;
				if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
				{
					flag = true;
				}
			}
			this.nullable_1 = nullable_4;
			if (flag)
			{
				Mission.Delegate37 @delegate = Mission.delegate37_0;
				if (@delegate != null)
				{
					@delegate(this);
				}
			}
			this.method_26(scenario_0);
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0000B2B2 File Offset: 0x000094B2
		public DateTime? method_29()
		{
			return this.nullable_2;
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0017E690 File Offset: 0x0017C890
		public void method_30(DateTime? nullable_4)
		{
			bool flag = false;
			if (Information.IsNothing(this.nullable_2) && !Information.IsNothing(nullable_4))
			{
				flag = true;
			}
			else if (Information.IsNothing(nullable_4) && !Information.IsNothing(this.nullable_2))
			{
				flag = true;
			}
			else
			{
				DateTime? dateTime = this.nullable_2;
				bool? flag2 = (dateTime != null & nullable_4 != null) ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), nullable_4.GetValueOrDefault()) == 0) : null;
				if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
				{
					flag = true;
				}
			}
			this.nullable_2 = nullable_4;
			if (flag)
			{
				Mission.Delegate38 @delegate = Mission.delegate38_0;
				if (@delegate != null)
				{
					@delegate(this);
				}
			}
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0000B2BA File Offset: 0x000094BA
		public DateTime? method_31()
		{
			return this.nullable_3;
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0017E76C File Offset: 0x0017C96C
		public void method_32(DateTime? nullable_4)
		{
			bool flag = false;
			if (Information.IsNothing(this.nullable_3) && !Information.IsNothing(nullable_4))
			{
				flag = true;
			}
			else if (Information.IsNothing(nullable_4) && !Information.IsNothing(this.nullable_3))
			{
				flag = true;
			}
			else
			{
				DateTime? dateTime = this.nullable_3;
				bool? flag2 = (dateTime != null & nullable_4 != null) ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), nullable_4.GetValueOrDefault()) == 0) : null;
				if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
				{
					flag = true;
				}
			}
			this.nullable_3 = nullable_4;
			if (flag)
			{
				Mission.Delegate39 @delegate = Mission.delegate39_0;
				if (@delegate != null)
				{
					@delegate(this);
				}
			}
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x0017E848 File Offset: 0x0017CA48
		public int method_33(ref Mission._FlightQty _FlightQty_0)
		{
			switch (_FlightQty_0)
			{
			case Mission._FlightQty.None:
				return 0;
			case Mission._FlightQty.All:
				return int.MaxValue;
			case Mission._FlightQty.Flight_x1:
				return 1;
			case Mission._FlightQty.Flight_x2:
				return 2;
			case Mission._FlightQty.Flight_x3:
				return 3;
			case Mission._FlightQty.Flight_x4:
				return 4;
			case Mission._FlightQty.Flight_x6:
				return 6;
			case Mission._FlightQty.Flight_x8:
				return 8;
			case Mission._FlightQty.Flight_x12:
				return 12;
			}
			return 0;
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x0017E8B8 File Offset: 0x0017CAB8
		public int method_34(ref Mission._FlightSize _FlightSize_1, ref Mission._FlightQty _FlightQty_0)
		{
			switch (_FlightQty_0)
			{
			case Mission._FlightQty.None:
				return 0;
			case Mission._FlightQty.All:
				return int.MaxValue;
			case Mission._FlightQty.Flight_x1:
				return (int)_FlightSize_1;
			case Mission._FlightQty.Flight_x2:
				return (int)(_FlightSize_1 * Mission._FlightSize.TwoAircraft);
			case Mission._FlightQty.Flight_x3:
				return (int)(_FlightSize_1 * Mission._FlightSize.ThreeAircraft);
			case Mission._FlightQty.Flight_x4:
				return (int)(_FlightSize_1 * Mission._FlightSize.FourAircraft);
			case Mission._FlightQty.Flight_x6:
				return (int)(_FlightSize_1 * Mission._FlightSize.SixAircraft);
			case Mission._FlightQty.Flight_x8:
				return (int)(_FlightSize_1 * (Mission._FlightSize)8);
			case Mission._FlightQty.Flight_x12:
				return (int)(_FlightSize_1 * (Mission._FlightSize)12);
			}
			return 0;
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0017E93C File Offset: 0x0017CB3C
		public Mission._FlightQty method_35(ref int int_7)
		{
			Mission._FlightQty result;
			try
			{
				switch (int_7)
				{
				case 0:
					result = Mission._FlightQty.All;
					break;
				case 1:
					result = Mission._FlightQty.None;
					break;
				case 2:
					result = Mission._FlightQty.Flight_x1;
					break;
				case 3:
					result = Mission._FlightQty.Flight_x2;
					break;
				case 4:
					result = Mission._FlightQty.Flight_x3;
					break;
				case 5:
					result = Mission._FlightQty.Flight_x4;
					break;
				case 6:
					result = Mission._FlightQty.Flight_x6;
					break;
				case 7:
					result = Mission._FlightQty.Flight_x8;
					break;
				case 8:
					result = Mission._FlightQty.Flight_x12;
					break;
				default:
					result = Mission._FlightQty.All;
					break;
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
				result = Mission._FlightQty.All;
			}
			return result;
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0017E9F4 File Offset: 0x0017CBF4
		public int method_36(Mission._FlightQty _FlightQty_0)
		{
			int result;
			try
			{
				switch (_FlightQty_0)
				{
				case Mission._FlightQty.None:
					return 1;
				case Mission._FlightQty.All:
					return 0;
				case Mission._FlightQty.Flight_x1:
					return 2;
				case Mission._FlightQty.Flight_x2:
					return 3;
				case Mission._FlightQty.Flight_x3:
					return 4;
				case Mission._FlightQty.Flight_x4:
					return 5;
				case Mission._FlightQty.Flight_x6:
					return 6;
				case Mission._FlightQty.Flight_x8:
					return 7;
				case Mission._FlightQty.Flight_x12:
					return 8;
				}
				result = 0;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0017EAA8 File Offset: 0x0017CCA8
		public int method_37(ref int int_7, bool bool_22)
		{
			int result;
			try
			{
				if (!bool_22)
				{
					switch (int_7)
					{
					case 0:
						result = -99;
						break;
					case 1:
						result = 0;
						break;
					case 2:
						result = -97;
						break;
					case 3:
						result = -96;
						break;
					case 4:
						result = -95;
						break;
					case 5:
						result = -94;
						break;
					case 6:
						result = -93;
						break;
					case 7:
						result = -92;
						break;
					case 8:
						result = -91;
						break;
					default:
						result = 0;
						break;
					}
				}
				else
				{
					int num = int_7;
					if (num != 0)
					{
						if (num != 1)
						{
							result = 0;
						}
						else
						{
							result = 0;
						}
					}
					else
					{
						result = -99;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101242", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = -99;
			}
			return result;
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0017EB78 File Offset: 0x0017CD78
		public int method_38(int int_7, bool bool_22)
		{
			int result;
			try
			{
				if (!bool_22)
				{
					switch (int_7)
					{
					case -99:
						return 0;
					case -98:
						break;
					case -97:
						return 2;
					case -96:
						return 3;
					case -95:
						return 4;
					case -94:
						return 5;
					case -93:
						return 6;
					case -92:
						return 7;
					case -91:
						return 8;
					default:
						if (int_7 == 0)
						{
							return 1;
						}
						break;
					}
					result = 1;
				}
				else if (int_7 != -99)
				{
					if (int_7 != 0)
					{
						result = 1;
					}
					else
					{
						result = 1;
					}
				}
				else
				{
					result = 0;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101243", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0017EC44 File Offset: 0x0017CE44
		public int method_39(ref int int_7, bool bool_22)
		{
			int result;
			try
			{
				if (!bool_22)
				{
					switch (int_7)
					{
					case 0:
						result = 0;
						break;
					case 1:
						result = -97;
						break;
					case 2:
						result = -96;
						break;
					case 3:
						result = -95;
						break;
					case 4:
						result = -94;
						break;
					case 5:
						result = -93;
						break;
					case 6:
						result = -92;
						break;
					case 7:
						result = -91;
						break;
					default:
						result = 0;
						break;
					}
				}
				else
				{
					switch (int_7)
					{
					case 0:
						result = 0;
						break;
					case 1:
						result = -87;
						break;
					case 2:
						result = -86;
						break;
					case 3:
						result = -85;
						break;
					case 4:
						result = -84;
						break;
					case 5:
						result = -83;
						break;
					case 6:
						result = -82;
						break;
					case 7:
						result = -81;
						break;
					default:
						result = 0;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101245", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0017ED60 File Offset: 0x0017CF60
		public int method_40(int int_7, bool bool_22)
		{
			int result;
			try
			{
				if (!bool_22)
				{
					switch (int_7)
					{
					case -97:
						result = 1;
						break;
					case -96:
						result = 2;
						break;
					case -95:
						result = 3;
						break;
					case -94:
						result = 4;
						break;
					case -93:
						result = 5;
						break;
					case -92:
						result = 6;
						break;
					case -91:
						result = 7;
						break;
					default:
						result = 0;
						break;
					}
				}
				else
				{
					switch (int_7)
					{
					case -87:
						result = 1;
						break;
					case -86:
						result = 2;
						break;
					case -85:
						result = 3;
						break;
					case -84:
						result = 4;
						break;
					case -83:
						result = 5;
						break;
					case -82:
						result = 6;
						break;
					case -81:
						result = 7;
						break;
					default:
						result = 0;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101244", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0017EE5C File Offset: 0x0017D05C
		public int method_41(ref int int_7)
		{
			int result;
			try
			{
				switch (int_7)
				{
				case 0:
					result = -97;
					break;
				case 1:
					result = -96;
					break;
				case 2:
					result = -95;
					break;
				case 3:
					result = -94;
					break;
				case 4:
					result = -93;
					break;
				case 5:
					result = -92;
					break;
				case 6:
					result = -91;
					break;
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
				result = -99;
			}
			return result;
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0017EF00 File Offset: 0x0017D100
		public int method_42(ref int int_7)
		{
			int result;
			try
			{
				switch (int_7)
				{
				case 0:
					result = -96;
					break;
				case 1:
					result = -95;
					break;
				case 2:
					result = -94;
					break;
				case 3:
					result = -93;
					break;
				case 4:
					result = -92;
					break;
				case 5:
					result = -91;
					break;
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
				result = -99;
			}
			return result;
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0017EF98 File Offset: 0x0017D198
		public void method_43(ref Scenario scenario_0, List<Group> list_5, List<Aircraft> list_6, List<Aircraft> list_7, List<Aircraft> list_8)
		{
			try
			{
				if (!Information.IsNothing(list_5))
				{
					try
					{
						foreach (Group group in list_5)
						{
							if (group.vmethod_141().Values.Count == 1)
							{
								ActiveUnit activeUnit = Enumerable.ElementAtOrDefault<ActiveUnit>(group.vmethod_141().Values, 0);
								Mission.Flight flight_ = activeUnit.vmethod_85().method_7();
								Enumerable.ElementAtOrDefault<ActiveUnit>(group.vmethod_141().Values, 0).vmethod_66(true, null);
								group.vmethod_133(false, false, false);
								activeUnit.vmethod_85().method_8(flight_);
							}
						}
					}
					finally
					{
						List<Group>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (!Information.IsNothing(list_7))
				{
					try
					{
						foreach (Aircraft aircraft in list_7)
						{
							Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
							if (aircraft_AirOps.method_36() == Aircraft_AirOps._AirOpsCondition.Parked)
							{
								aircraft_AirOps.method_70();
							}
							if (aircraft.method_157().method_48())
							{
								aircraft.method_157().method_7().method_11(scenario_0, Mission.Enum102.const_4);
							}
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				if (!Information.IsNothing(list_8))
				{
					try
					{
						foreach (Aircraft aircraft2 in list_8)
						{
							Aircraft_AirOps aircraft_AirOps2 = aircraft2.method_164();
							if (aircraft_AirOps2.method_36() == Aircraft_AirOps._AirOpsCondition.Parked)
							{
								aircraft_AirOps2.method_70();
							}
							if (aircraft2.method_157().method_48())
							{
								aircraft2.method_157().method_7().method_11(scenario_0, Mission.Enum102.const_4);
							}
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				if (!Information.IsNothing(list_6))
				{
					try
					{
						foreach (Aircraft aircraft3 in list_6)
						{
							Aircraft_AirOps aircraft_AirOps3 = aircraft3.method_164();
							if (aircraft_AirOps3.method_36() == Aircraft_AirOps._AirOpsCondition.Parked)
							{
								aircraft_AirOps3.method_37(Aircraft_AirOps._AirOpsCondition.PreparingToLaunch);
								if (!aircraft_AirOps3.method_69())
								{
									aircraft_AirOps3.method_70();
								}
							}
							if (aircraft3.method_157().method_48())
							{
								aircraft3.method_157().method_7().method_11(scenario_0, Mission.Enum102.const_4);
							}
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
					if (list_6.Count > 0 && this._MissionClass_0 == Mission._MissionClass.Strike)
					{
						((Strike)this).bool_26 = true;
					}
				}
				list_5.Clear();
				list_6.Clear();
				if (!Information.IsNothing(list_7))
				{
					list_7.Clear();
				}
				if (!Information.IsNothing(list_8))
				{
					list_8.Clear();
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

		// Token: 0x06001427 RID: 5159 RVA: 0x0000B2C2 File Offset: 0x000094C2
		public virtual string vmethod_5(Scenario scenario_0)
		{
			return "";
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x0017F2A0 File Offset: 0x0017D4A0
		public Mission(Side side_0, Scenario scenario_0)
		{
			List<ActiveUnit> list = null;
			this.doctrine_0 = new Doctrine(this, ref list);
			this.enum88_0 = Mission.Enum88.const_0;
			this.int_0 = 0;
			this.list_0 = new List<Mission.Flight>();
			this.list_1 = new List<Mission.Flight>();
			this.list_3 = new List<string>();
			this.list_4 = new List<Mission>();
			this.int_4 = 0;
			this.int_6 = int.MaxValue;
			this.bool_18 = true;
			this.bool_19 = false;
			this.bool_20 = false;
			this.bool_21 = false;
			this.bool_9 = true;
			if (!Information.IsNothing(side_0))
			{
				side_0.method_38(this);
			}
			list = null;
			this.doctrine_0 = new Doctrine(this, ref list);
			if (this._MissionClass_0 == Mission._MissionClass.Strike)
			{
				this.int_5 = 85;
				return;
			}
			if (this._MissionClass_0 == Mission._MissionClass.Ferry)
			{
				this.int_5 = 80;
				return;
			}
			if (this._MissionClass_0 == Mission._MissionClass.Support)
			{
				this.int_5 = 0;
				return;
			}
			this.int_5 = 60;
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0017F390 File Offset: 0x0017D590
		public static string smethod_1(Mission._FlightSize _FlightSize_1)
		{
			switch (_FlightSize_1)
			{
			case Mission._FlightSize.SingleAircraft:
				return "Single aircraft";
			case Mission._FlightSize.TwoAircraft:
				return "Section (2x aircraft), typical for fighters";
			case Mission._FlightSize.ThreeAircraft:
				return "Cell (3x aircraft), typical for bombers";
			case Mission._FlightSize.FourAircraft:
				return "Two Sections (4x aircraft), typical for attack aircraft";
			case Mission._FlightSize.SixAircraft:
				return "Three Sections (6x aircraft), for medium/heavy attack aircraft";
			}
			return "None";
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0017F3F0 File Offset: 0x0017D5F0
		public static string smethod_2(Mission._GroupSize _GroupSize_1)
		{
			switch (_GroupSize_1)
			{
			case Mission._GroupSize.SingleVessel:
				return "Single vessel";
			case Mission._GroupSize.TwoVessels:
				return "2x vessels";
			case Mission._GroupSize.ThreeVessels:
				return "3x vessels";
			case Mission._GroupSize.FourVessels:
				return "4x vessels";
			case Mission._GroupSize.SixVessels:
				return "6x vessels";
			}
			return "None";
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x0017F450 File Offset: 0x0017D650
		public int method_44(ref int int_7)
		{
			int result;
			try
			{
				int num = int_7;
				if (num != 0)
				{
					if (num != 1)
					{
						result = 0;
					}
					else
					{
						result = 1;
					}
				}
				else
				{
					result = 0;
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
				result = 0;
			}
			return result;
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x0017F4BC File Offset: 0x0017D6BC
		public int method_45(ref int int_7)
		{
			int result;
			try
			{
				switch (int_7)
				{
				case 0:
					result = 0;
					break;
				case 1:
					result = 1;
					break;
				case 2:
					result = 2;
					break;
				case 3:
					result = 3;
					break;
				case 4:
					result = 4;
					break;
				case 5:
					result = 5;
					break;
				case 6:
					result = 6;
					break;
				case 7:
					result = 7;
					break;
				case 8:
					result = 8;
					break;
				case 9:
					result = 9;
					break;
				case 10:
					result = 10;
					break;
				case 11:
					result = 11;
					break;
				case 12:
					result = 12;
					break;
				case 13:
					result = 13;
					break;
				case 14:
					result = 14;
					break;
				case 15:
					result = 15;
					break;
				case 16:
					result = 16;
					break;
				case 17:
					result = 17;
					break;
				case 18:
					result = 18;
					break;
				case 19:
					result = 19;
					break;
				case 20:
					result = 20;
					break;
				case 21:
					result = 21;
					break;
				default:
					result = 0;
					break;
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
				result = 0;
			}
			return result;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0017F5F4 File Offset: 0x0017D7F4
		public int method_46(int int_7)
		{
			int result;
			try
			{
				switch (int_7)
				{
				case 0:
					result = 15;
					break;
				case 1:
					result = 20;
					break;
				case 2:
					result = 30;
					break;
				case 3:
					result = 40;
					break;
				case 4:
					result = 45;
					break;
				case 5:
					result = 50;
					break;
				case 6:
					result = 60;
					break;
				case 7:
					result = 75;
					break;
				case 8:
					result = 90;
					break;
				case 9:
					result = 105;
					break;
				case 10:
					result = 120;
					break;
				case 11:
					result = 135;
					break;
				case 12:
					result = 150;
					break;
				case 13:
					result = 165;
					break;
				case 14:
					result = 180;
					break;
				case 15:
					result = 210;
					break;
				case 16:
					result = 240;
					break;
				case 17:
					result = 300;
					break;
				case 18:
					result = 360;
					break;
				case 19:
					result = 480;
					break;
				case 20:
					result = 600;
					break;
				case 21:
					result = 720;
					break;
				default:
					result = 15;
					break;
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
				result = 0;
			}
			return result;
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0017F774 File Offset: 0x0017D974
		public int method_47(ref int int_7)
		{
			int result;
			try
			{
				switch (int_7)
				{
				case 0:
					result = 0;
					break;
				case 1:
					result = 1;
					break;
				case 2:
					result = 2;
					break;
				default:
					result = 1;
					break;
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
				result = 0;
			}
			return result;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0017F7F0 File Offset: 0x0017D9F0
		public int method_48(int int_7)
		{
			int result;
			try
			{
				switch (int_7)
				{
				case 0:
					result = 0;
					break;
				case 1:
					result = 2;
					break;
				case 2:
					result = 5;
					break;
				default:
					result = 0;
					break;
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
				result = 0;
			}
			return result;
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0017F86C File Offset: 0x0017DA6C
		public int method_49(ref int int_7)
		{
			int result;
			try
			{
				switch (int_7)
				{
				case 0:
					result = 0;
					break;
				case 1:
					result = 1;
					break;
				case 2:
					result = 2;
					break;
				case 3:
					result = 3;
					break;
				case 4:
					result = 4;
					break;
				default:
					result = 2;
					break;
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
				result = 2;
			}
			return result;
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0017F8F8 File Offset: 0x0017DAF8
		public int method_50(int int_7)
		{
			int result;
			try
			{
				switch (int_7)
				{
				case 0:
					result = 2;
					break;
				case 1:
					result = 4;
					break;
				case 2:
					result = 6;
					break;
				case 3:
					result = 12;
					break;
				case 4:
					result = 24;
					break;
				default:
					result = 2;
					break;
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
				result = 2;
			}
			return result;
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0017F984 File Offset: 0x0017DB84
		public int method_51(ref Mission._GroupSize _GroupSize_1, ref Mission.Enum100 enum100_0)
		{
			switch (enum100_0)
			{
			case Mission.Enum100.const_2:
				return 0;
			case Mission.Enum100.const_1:
				return int.MaxValue;
			case Mission.Enum100.const_3:
				return (int)_GroupSize_1;
			case Mission.Enum100.const_4:
				return (int)(_GroupSize_1 * Mission._GroupSize.TwoVessels);
			case Mission.Enum100.const_5:
				return (int)(_GroupSize_1 * Mission._GroupSize.ThreeVessels);
			case Mission.Enum100.const_6:
				return (int)(_GroupSize_1 * Mission._GroupSize.FourVessels);
			case Mission.Enum100.const_7:
				return (int)(_GroupSize_1 * Mission._GroupSize.SixVessels);
			case Mission.Enum100.const_8:
				return (int)(_GroupSize_1 * (Mission._GroupSize)8);
			case Mission.Enum100.const_9:
				return (int)(_GroupSize_1 * (Mission._GroupSize)12);
			}
			return 0;
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0017FA08 File Offset: 0x0017DC08
		public int method_52(ref int int_7)
		{
			int result;
			try
			{
				switch (int_7)
				{
				case 0:
					result = -99;
					break;
				case 1:
					result = -100;
					break;
				case 2:
					result = -97;
					break;
				case 3:
					result = -96;
					break;
				case 4:
					result = -95;
					break;
				case 5:
					result = -94;
					break;
				case 6:
					result = -93;
					break;
				case 7:
					result = -92;
					break;
				case 8:
					result = -91;
					break;
				default:
					result = -99;
					break;
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
				result = -99;
			}
			return result;
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0017FAC0 File Offset: 0x0017DCC0
		public int method_53(int int_7)
		{
			int result;
			try
			{
				switch (int_7)
				{
				case -100:
					return 1;
				case -99:
					return 0;
				case -97:
					return 2;
				case -96:
					return 3;
				case -95:
					return 4;
				case -94:
					return 5;
				case -93:
					return 6;
				case -92:
					return 7;
				case -91:
					return 8;
				}
				result = 0;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0017FB74 File Offset: 0x0017DD74
		public static string smethod_3(Mission._FlightTask _FlightTask_0)
		{
			switch (_FlightTask_0)
			{
			case Mission._FlightTask.const_1:
				return "Strike (Land)";
			case Mission._FlightTask.const_2:
				return "Strike, Maritime (Anti-Ship)";
			case Mission._FlightTask.const_3:
				return "Strike, OCA (Offensive Counter-Air)";
			case Mission._FlightTask.const_4:
				return "Strike, SEAD (Suppression of Enemy Air Defences)";
			case Mission._FlightTask.const_5:
				return "Fighter Sweep (Counter-Air)";
			case Mission._FlightTask.const_6:
				return "SEAD (Suppression of Enemy Air Defences) Sweep";
			case Mission._FlightTask.const_7:
				return "BAI (Battlefield Air Interdiction)";
			case Mission._FlightTask.const_8:
				return "CAS (Close Air Support)";
			case Mission._FlightTask.const_9:
				return "CAP (Combat Air Patrol)";
			case Mission._FlightTask.const_10:
				return "TARCAP (Target Combat Air Patrol)";
			case Mission._FlightTask.const_11:
				return "BARCAP (Barrier Combat Air Patrol)";
			case Mission._FlightTask.const_12:
				return "GLI (Ground-Launched Intercept)";
			case Mission._FlightTask.const_13:
				return "DLI (Deck-Launched Intercept)";
			case Mission._FlightTask.const_14:
				return "Escort, Fighter Sweep";
			case Mission._FlightTask.const_15:
				return "Escort, TARCAP";
			case Mission._FlightTask.const_16:
				return "Escort, SEAD (Suppression of Enemy Air Defences) Sweep";
			case Mission._FlightTask.const_17:
				return "ASAT (Anti-Satellite)";
			case Mission._FlightTask.const_18:
				return "Airborne Laser";
			case Mission._FlightTask.const_19:
				return "Buddy Illumination";
			case Mission._FlightTask.const_20:
				return "OECM (Offensive ECM)";
			case Mission._FlightTask.const_21:
				return "AEW (Airborne Early Warning)";
			case Mission._FlightTask.const_22:
				return "Airborne Command Post";
			case Mission._FlightTask.const_23:
				return "Chaff Laying";
			case Mission._FlightTask.const_24:
				return "SAR (Search And Rescue)";
			case Mission._FlightTask.const_25:
				return "CSAR (Combat Search And Rescue)";
			case Mission._FlightTask.const_26:
				return "Mine Sweeping";
			case Mission._FlightTask.const_27:
				return "Mine Recon";
			case Mission._FlightTask.const_28:
				return "Naval Mine Laying";
			case Mission._FlightTask.const_29:
				return "ASW (Anti-Submarine Warfare)";
			case Mission._FlightTask.const_30:
				return "FAC (Forward Air Controller)";
			case Mission._FlightTask.const_31:
				return "Surveillance";
			case Mission._FlightTask.const_32:
				return "Armed Recon";
			case Mission._FlightTask.const_33:
				return "Unarmed Recon";
			case Mission._FlightTask.const_34:
				return "Maritime Surveillance";
			case Mission._FlightTask.const_35:
				return "Para Drop";
			case Mission._FlightTask.const_36:
				return "Troop Transport";
			case Mission._FlightTask.const_37:
				return "Cargo";
			case Mission._FlightTask.const_38:
				return "Air Refuelling";
			case Mission._FlightTask.const_39:
				return "Training";
			case Mission._FlightTask.const_40:
				return "Target Tow";
			case Mission._FlightTask.const_41:
				return "Target Drone";
			case Mission._FlightTask.const_42:
				return "Ferry";
			case Mission._FlightTask.const_43:
				return "HAVCAP (High Value Asset Combat Air Patrol)";
			case Mission._FlightTask.const_44:
				return "RESCAP (Rescue Combat Air Patrol)";
			case Mission._FlightTask.const_45:
				return "Strike, Interdiction (attack on logistics and reinforcements)";
			case Mission._FlightTask.const_46:
				return "Support";
			case Mission._FlightTask.const_47:
				return "Escort, Support";
			case Mission._FlightTask.const_48:
				return "QRA (Quick Reaction Alert)";
			}
			return "Not Configured";
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0017FE3C File Offset: 0x0017E03C
		public static string smethod_4(Mission.Enum101 enum101_0)
		{
			string result;
			if (enum101_0 == Mission.Enum101.const_1)
			{
				result = "Mandatory";
			}
			else
			{
				result = "None";
			}
			return result;
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0017FE60 File Offset: 0x0017E060
		public static string smethod_5(Mission.Enum102 enum102_0)
		{
			string result;
			switch (enum102_0)
			{
			case Mission.Enum102.const_1:
				result = "Looking for available aircraft";
				break;
			case Mission.Enum102.const_2:
				result = "Waiting for package activation";
				break;
			case Mission.Enum102.const_3:
				result = "Waiting for package to become ready";
				break;
			case Mission.Enum102.const_4:
				result = "Taking off";
				break;
			case Mission.Enum102.const_5:
				result = "Airborne";
				break;
			case Mission.Enum102.const_6:
				result = "Completed";
				break;
			case Mission.Enum102.const_7:
				result = "Package cancelled";
				break;
			case Mission.Enum102.const_8:
				result = "Airborne";
				break;
			default:
				result = "Planning";
				break;
			}
			return result;
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0017FEE0 File Offset: 0x0017E0E0
		public virtual void vmethod_6(ref Scenario scenario_0, Side side_0, bool bool_22)
		{
			try
			{
				if (this.list_3.Count > 0)
				{
					foreach (Side side in scenario_0.method_44())
					{
						try
						{
							foreach (Mission mission in side.method_35())
							{
								if (this.list_3.Contains(mission.string_0))
								{
									this.list_4.Add(mission);
								}
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
				if (this.method_54())
				{
					try
					{
						foreach (Mission.Flight flight in this.list_1)
						{
							if (!string.IsNullOrEmpty(flight.string_11) && scenario_0.vmethod_0().ContainsKey(flight.string_11))
							{
								flight.method_33(null, scenario_0.vmethod_0()[flight.string_11]);
							}
							if (!string.IsNullOrEmpty(flight.string_14))
							{
								foreach (Side side2 in scenario_0.method_44())
								{
									try
									{
										foreach (Mission mission2 in side2.method_35())
										{
											if (flight.string_14.Contains(mission2.string_0))
											{
												flight.mission_0 = mission2;
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
							if (!string.IsNullOrEmpty(flight.string_20))
							{
								foreach (Side side3 in scenario_0.method_44())
								{
									if (side3.method_11().ContainsKey(flight.string_20))
									{
										flight.contact_0 = side3.method_11()[flight.string_20];
										break;
									}
								}
							}
						}
					}
					finally
					{
						List<Mission.Flight>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
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

		// Token: 0x06001439 RID: 5177 RVA: 0x00180160 File Offset: 0x0017E360
		public bool method_54()
		{
			return !Information.IsNothing(this.list_1) && this.list_1.Count != 0;
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00180190 File Offset: 0x0017E390
		public bool method_55()
		{
			bool result;
			if (!this.method_54())
			{
				result = false;
			}
			else
			{
				try
				{
					foreach (Mission.Flight flight in this.list_1)
					{
						if (!Information.IsNothing(flight.method_15()) && Enumerable.Count<Waypoint>(flight.method_15()) > 0)
						{
							return true;
						}
					}
				}
				finally
				{
					List<Mission.Flight>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0018020C File Offset: 0x0017E40C
		public void method_56(Scenario scenario_0, Side side_0)
		{
			try
			{
				List<ActiveUnit> list = new List<ActiveUnit>();
				foreach (ActiveUnit activeUnit in side_0.activeUnit_0)
				{
					if (!activeUnit.method_120() && (!activeUnit.bool_2 || ((Weapon)activeUnit).method_167() != Weapon._WeaponType.Sonobuoy) && activeUnit.vmethod_101() == this && activeUnit.bool_3 && !Information.IsNothing(activeUnit.vmethod_85().method_7()))
					{
						list.Add(activeUnit);
					}
				}
				bool flag = false;
				List<Mission.Flight> list2 = new List<Mission.Flight>();
				try
				{
					foreach (Mission.Flight flight in this.list_1)
					{
						flag = false;
						try
						{
							foreach (ActiveUnit activeUnit2 in list)
							{
								if (activeUnit2.vmethod_85().method_7() == flight)
								{
									flag = true;
									list.Remove(activeUnit2);
									break;
								}
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						if (!flag)
						{
							if (!Information.IsNothing(this.list_2))
							{
								try
								{
									foreach (Mission.EmptyAircraftSlot emptyAircraftSlot in this.list_2)
									{
										if (!Information.IsNothing(emptyAircraftSlot.method_5(scenario_0)) && emptyAircraftSlot.method_5(scenario_0) == flight)
										{
											flag = true;
											break;
										}
									}
								}
								finally
								{
									List<Mission.EmptyAircraftSlot>.Enumerator enumerator3;
									((IDisposable)enumerator3).Dispose();
								}
							}
							if (!flag)
							{
								list2.Add(flight);
							}
						}
					}
				}
				finally
				{
					List<Mission.Flight>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (Mission.Flight flight2 in list2)
					{
						this.method_57(ref scenario_0, ref side_0, ref flight2, flight2.string_0);
					}
				}
				finally
				{
					List<Mission.Flight>.Enumerator enumerator4;
					((IDisposable)enumerator4).Dispose();
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

		// Token: 0x0600143C RID: 5180 RVA: 0x00180480 File Offset: 0x0017E680
		public void method_57(ref Scenario scenario_0, ref Side side_0, ref Mission.Flight flight_0, string string_3)
		{
			try
			{
				if (!Information.IsNothing(flight_0))
				{
					foreach (ActiveUnit activeUnit in side_0.activeUnit_0)
					{
						if (activeUnit.vmethod_85().method_48() && Operators.CompareString(activeUnit.vmethod_85().method_7().string_0, string_3, false) == 0)
						{
							activeUnit.vmethod_85().vmethod_10();
						}
					}
					if (!Information.IsNothing(this.list_2))
					{
						for (int j = this.list_2.Count - 1; j >= 0; j += -1)
						{
							Mission.EmptyAircraftSlot emptyAircraftSlot = this.list_2[j];
							if (emptyAircraftSlot.method_5(scenario_0) == flight_0)
							{
								this.list_2.Remove(emptyAircraftSlot);
							}
						}
					}
					for (int k = scenario_0.MissionPlannerErrorList.Count - 1; k >= 0; k += -1)
					{
						string text = scenario_0.MissionPlannerErrorList[k];
						if (text.Contains(flight_0.string_4))
						{
							scenario_0.MissionPlannerErrorList.Remove(text);
						}
					}
					this.method_59(flight_0);
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

		// Token: 0x0600143D RID: 5181 RVA: 0x001805E4 File Offset: 0x0017E7E4
		public void method_58(ref Scenario scenario_0, ref Side side_0, ref Mission.Flight flight_0)
		{
			try
			{
				flight_0.method_17();
				for (int i = scenario_0.MissionPlannerErrorList.Count - 1; i >= 0; i += -1)
				{
					string text = scenario_0.MissionPlannerErrorList[i];
					if (text.Contains(flight_0.string_4))
					{
						scenario_0.MissionPlannerErrorList.Remove(text);
					}
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

		// Token: 0x0600143E RID: 5182 RVA: 0x00180684 File Offset: 0x0017E884
		public void method_59(Mission.Flight flight_0)
		{
			try
			{
				if (!Information.IsNothing(flight_0))
				{
					if (this.list_1.Contains(flight_0))
					{
						this.list_1.Remove(flight_0);
						flight_0 = null;
					}
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

		// Token: 0x0600143F RID: 5183 RVA: 0x00180704 File Offset: 0x0017E904
		public void method_60(ref Mission.Flight flight_0)
		{
			try
			{
				if (!Information.IsNothing(flight_0))
				{
					if (!this.list_1.Contains(flight_0))
					{
						this.list_1.Add(flight_0);
					}
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

		// Token: 0x06001440 RID: 5184 RVA: 0x00180780 File Offset: 0x0017E980
		public void method_61(ref Mission.Flight flight_0)
		{
			try
			{
				if (!Information.IsNothing(flight_0))
				{
					if (!this.list_0.Contains(flight_0))
					{
						this.list_0.Add(flight_0);
					}
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

		// Token: 0x06001441 RID: 5185 RVA: 0x001807FC File Offset: 0x0017E9FC
		public void method_62(ref Scenario scenario_0, ref Side side_0)
		{
			try
			{
				foreach (ActiveUnit activeUnit in side_0.activeUnit_0)
				{
					if (activeUnit.vmethod_101() == this)
					{
						ActiveUnit activeUnit2 = activeUnit;
						Mission value = null;
						bool setMissionOnly = false;
						Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
						activeUnit2.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
					}
				}
				if (this.enum88_0 == Mission.Enum88.const_2)
				{
					Class342 @class = (Class342)this;
					foreach (ActiveUnit activeUnit3 in side_0.activeUnit_0)
					{
						if (activeUnit3.vmethod_103() == this)
						{
							activeUnit3.vmethod_104(null);
						}
					}
					for (int k = @class.list_5.Count - 1; k >= 0; k += -1)
					{
						Mission mission = @class.list_5[k];
						foreach (ActiveUnit activeUnit4 in side_0.activeUnit_0)
						{
							if (activeUnit4.vmethod_101() == mission)
							{
								activeUnit4.vmethod_104(null);
							}
						}
						mission.method_62(ref scenario_0, ref side_0);
					}
				}
				try
				{
					foreach (Mission mission2 in side_0.method_36(scenario_0))
					{
						if (!Information.IsNothing(mission2))
						{
							if (mission2.list_4.Contains(this))
							{
								mission2.list_4.Remove(this);
							}
							if (mission2.list_3.Contains(this.string_0))
							{
								mission2.list_3.Remove(this.string_0);
							}
							try
							{
								foreach (Mission.Flight flight in mission2.list_1)
								{
									if (!Information.IsNothing(flight) && Enumerable.Count<Waypoint>(flight.method_15()) != 0)
									{
										foreach (Waypoint waypoint in flight.method_15())
										{
											if (waypoint.list_1.Contains(this))
											{
												waypoint.list_1.Remove(this);
											}
											if (waypoint.list_0.Contains(this.string_0))
											{
												waypoint.list_0.Remove(this.string_0);
											}
										}
									}
								}
							}
							finally
							{
								List<Mission.Flight>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
						}
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
				this.method_63(ref scenario_0, ref side_0);
				side_0.method_39(this);
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

		// Token: 0x06001442 RID: 5186 RVA: 0x00180AC4 File Offset: 0x0017ECC4
		public void method_63(ref Scenario scenario_0, ref Side side_0)
		{
			for (int i = this.list_1.Count - 1; i >= 0; i += -1)
			{
				Mission.Flight flight = this.list_1[i];
				this.method_57(ref scenario_0, ref side_0, ref flight, flight.string_0);
			}
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00180B08 File Offset: 0x0017ED08
		public Aircraft method_64(ref Scenario scenario_0, ref Side side_0, int int_7, int int_8, ref ActiveUnit activeUnit_0, ref Mission.Flight flight_0, bool bool_22, int int_9)
		{
			Aircraft result;
			try
			{
				Aircraft aircraft = new Aircraft(ref scenario_0, null);
				if (int_7 > 0)
				{
					DBFunctions.smethod_19(ref scenario_0, ref aircraft, int_7, true);
				}
				aircraft.Name = string.Concat(new string[]
				{
					"Empty Slot ",
					Conversions.ToString(int_9),
					" (",
					aircraft.string_2,
					")"
				});
				aircraft.vmethod_8(false, side_0);
				aircraft.method_158().bool_2 = bool_22;
				if (!Information.IsNothing(activeUnit_0))
				{
					aircraft.method_164().method_31(activeUnit_0);
					if (!Information.IsNothing(aircraft.method_164().method_30()))
					{
						aircraft.vmethod_31(null, aircraft.method_164().method_30().vmethod_30(null));
						aircraft.vmethod_29(null, aircraft.method_164().method_30().vmethod_28(null));
					}
				}
				if (int_8 > 0)
				{
					Loadout loadout_ = DBFunctions.smethod_47(ref scenario_0, int_8, false, true);
					aircraft.method_168(loadout_);
				}
				else
				{
					Loadout loadout_2 = new Loadout(0, "No loadout", 0, 0, 0, 0, Loadout.LoadoutRole.None, Loadout._LoadoutDayNight.None, Loadout._LoadoutWeather.None, 0f, int.MaxValue, 0, false, false, false, 0, 0, 0, 0, Loadout._LoadoutDayNight.None, Doctrine._WeaponState.NotConfigured);
					aircraft.method_168(loadout_2);
				}
				ActiveUnit activeUnit = aircraft;
				bool setMissionOnly = true;
				Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
				activeUnit.vmethod_102(this, setMissionOnly, ref missionAssignmentAttemptResult);
				aircraft.method_157().method_8(flight_0);
				result = aircraft;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00180CC8 File Offset: 0x0017EEC8
		public static Mission.Enum104 smethod_6(int int_7)
		{
			Mission.Enum104 result;
			try
			{
				switch (int_7)
				{
				case 0:
					result = Mission.Enum104.const_0;
					break;
				case 1:
					result = Mission.Enum104.const_1;
					break;
				case 2:
					result = Mission.Enum104.const_2;
					break;
				case 3:
					result = Mission.Enum104.const_3;
					break;
				case 4:
					result = Mission.Enum104.const_4;
					break;
				case 5:
					result = Mission.Enum104.const_5;
					break;
				case 6:
					result = Mission.Enum104.const_6;
					break;
				default:
					result = Mission.Enum104.const_0;
					break;
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
				result = Mission.Enum104.const_0;
			}
			return result;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00180D68 File Offset: 0x0017EF68
		public static int smethod_7(int int_7)
		{
			int result;
			try
			{
				switch (int_7)
				{
				case -99:
					result = 6;
					break;
				case -98:
					result = 5;
					break;
				case -97:
					result = 4;
					break;
				default:
					switch (int_7)
					{
					case 0:
						result = 0;
						break;
					case 1:
						result = 1;
						break;
					case 2:
						result = 2;
						break;
					case 3:
						result = 3;
						break;
					default:
						result = 0;
						break;
					}
					break;
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
				result = 0;
			}
			return result;
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00180E0C File Offset: 0x0017F00C
		public static string smethod_8(Mission.Enum104 enum104_0)
		{
			string result;
			switch (enum104_0)
			{
			case Mission.Enum104.const_6:
				result = "...until the next Landing Marshal waypoint";
				break;
			case Mission.Enum104.const_5:
				result = "...until the next Station waypoint";
				break;
			case Mission.Enum104.const_4:
				result = "...until the next Hold End waypoint";
				break;
			default:
				switch (enum104_0)
				{
				case Mission.Enum104.const_0:
					result = "...until receiver is full or reaches waypoint where refuelling is not allowed, whatever comes first.";
					break;
				case Mission.Enum104.const_1:
					result = "...to next waypoint (1x)";
					break;
				case Mission.Enum104.const_2:
					result = "...to waypoint after next (2x)";
					break;
				case Mission.Enum104.const_3:
					result = "...for three waypoints (3x)";
					break;
				default:
					result = "None";
					break;
				}
				break;
			}
			return result;
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00180E88 File Offset: 0x0017F088
		public static string smethod_9(Mission.Enum93 enum93_0)
		{
			string result;
			if (enum93_0 != Mission.Enum93.const_0)
			{
				if (enum93_0 != Mission.Enum93.const_1)
				{
					result = "Not Configured";
				}
				else
				{
					result = "Flightplan Template";
				}
			}
			else
			{
				result = "Flightplan";
			}
			return result;
		}

		// Token: 0x04000EDC RID: 3804
		public Doctrine doctrine_0;

		// Token: 0x04000EDD RID: 3805
		public Mission.Enum88 enum88_0;

		// Token: 0x04000EDE RID: 3806
		public Mission._MissionClass _MissionClass_0;

		// Token: 0x04000EDF RID: 3807
		protected DateTime? nullable_0;

		// Token: 0x04000EE0 RID: 3808
		protected DateTime? nullable_1;

		// Token: 0x04000EE1 RID: 3809
		protected DateTime? nullable_2;

		// Token: 0x04000EE2 RID: 3810
		protected DateTime? nullable_3;

		// Token: 0x04000EE3 RID: 3811
		public bool bool_11;

		// Token: 0x04000EE4 RID: 3812
		private Mission.Enum89 enum89_0;

		// Token: 0x04000EE5 RID: 3813
		public bool bool_12;

		// Token: 0x04000EE6 RID: 3814
		public bool bool_13;

		// Token: 0x04000EE7 RID: 3815
		public int int_0;

		// Token: 0x04000EE8 RID: 3816
		public List<Mission.Flight> list_0;

		// Token: 0x04000EE9 RID: 3817
		public List<Mission.Flight> list_1;

		// Token: 0x04000EEA RID: 3818
		public Mission._FlightSize _FlightSize_0;

		// Token: 0x04000EEB RID: 3819
		public Mission._GroupSize _GroupSize_0;

		// Token: 0x04000EEC RID: 3820
		private string string_2;

		// Token: 0x04000EED RID: 3821
		public List<Mission.EmptyAircraftSlot> list_2;

		// Token: 0x04000EEE RID: 3822
		public bool bool_14;

		// Token: 0x04000EEF RID: 3823
		public bool bool_15;

		// Token: 0x04000EF0 RID: 3824
		public bool bool_16;

		// Token: 0x04000EF1 RID: 3825
		public Mission.TankerMethod tankerMethod_0;

		// Token: 0x04000EF2 RID: 3826
		public List<string> list_3;

		// Token: 0x04000EF3 RID: 3827
		public List<Mission> list_4;

		// Token: 0x04000EF4 RID: 3828
		public int int_1;

		// Token: 0x04000EF5 RID: 3829
		public int int_2;

		// Token: 0x04000EF6 RID: 3830
		public int int_3;

		// Token: 0x04000EF7 RID: 3831
		public bool bool_17;

		// Token: 0x04000EF8 RID: 3832
		public int int_4;

		// Token: 0x04000EF9 RID: 3833
		public int int_5;

		// Token: 0x04000EFA RID: 3834
		public int int_6;

		// Token: 0x04000EFB RID: 3835
		public bool bool_18;

		// Token: 0x04000EFC RID: 3836
		public bool bool_19;

		// Token: 0x04000EFD RID: 3837
		public bool bool_20;

		// Token: 0x04000EFE RID: 3838
		public bool bool_21;

		// Token: 0x04000EFF RID: 3839
		[CompilerGenerated]
		private static Mission.Delegate36 delegate36_0;

		// Token: 0x04000F00 RID: 3840
		[CompilerGenerated]
		private static Mission.Delegate37 delegate37_0;

		// Token: 0x04000F01 RID: 3841
		[CompilerGenerated]
		private static Mission.Delegate38 delegate38_0;

		// Token: 0x04000F02 RID: 3842
		[CompilerGenerated]
		private static Mission.Delegate39 delegate39_0;

		// Token: 0x02000293 RID: 659
		public enum TankerMethod : byte
		{
			// Token: 0x04000F04 RID: 3844
			Automatic,
			// Token: 0x04000F05 RID: 3845
			Mission
		}

		// Token: 0x02000294 RID: 660
		internal enum Enum88
		{
			// Token: 0x04000F07 RID: 3847
			const_0,
			// Token: 0x04000F08 RID: 3848
			const_1,
			// Token: 0x04000F09 RID: 3849
			const_2
		}

		// Token: 0x02000295 RID: 661
		// (Invoke) Token: 0x0600144B RID: 5195
		internal delegate void Delegate36(Mission theM);

		// Token: 0x02000296 RID: 662
		// (Invoke) Token: 0x0600144F RID: 5199
		internal delegate void Delegate37(Mission theM);

		// Token: 0x02000297 RID: 663
		// (Invoke) Token: 0x06001453 RID: 5203
		internal delegate void Delegate38(Mission theM);

		// Token: 0x02000298 RID: 664
		// (Invoke) Token: 0x06001457 RID: 5207
		internal delegate void Delegate39(Mission theM);

		// Token: 0x02000299 RID: 665
		public enum _FlightQty
		{
			// Token: 0x04000F0B RID: 3851
			NoPreferences,
			// Token: 0x04000F0C RID: 3852
			All = -99,
			// Token: 0x04000F0D RID: 3853
			None = -100,
			// Token: 0x04000F0E RID: 3854
			Flight_x1 = -97,
			// Token: 0x04000F0F RID: 3855
			Flight_x2,
			// Token: 0x04000F10 RID: 3856
			Flight_x3,
			// Token: 0x04000F11 RID: 3857
			Flight_x4,
			// Token: 0x04000F12 RID: 3858
			Flight_x6,
			// Token: 0x04000F13 RID: 3859
			Flight_x8,
			// Token: 0x04000F14 RID: 3860
			Flight_x12,
			// Token: 0x04000F15 RID: 3861
			Aircraft_x1 = -87,
			// Token: 0x04000F16 RID: 3862
			Aircraft_x2,
			// Token: 0x04000F17 RID: 3863
			Aircraft_x3,
			// Token: 0x04000F18 RID: 3864
			Aircraft_x4,
			// Token: 0x04000F19 RID: 3865
			Aircraft_x6,
			// Token: 0x04000F1A RID: 3866
			Aircraft_x8,
			// Token: 0x04000F1B RID: 3867
			Aircraft_x12
		}

		// Token: 0x0200029A RID: 666
		public enum MissionAssignmentAttemptResult
		{
			// Token: 0x04000F1D RID: 3869
			None,
			// Token: 0x04000F1E RID: 3870
			Success,
			// Token: 0x04000F1F RID: 3871
			Fail_OutOfComms,
			// Token: 0x04000F20 RID: 3872
			Fail_Other
		}

		// Token: 0x0200029B RID: 667
		public enum _MissionClass : byte
		{
			// Token: 0x04000F22 RID: 3874
			None,
			// Token: 0x04000F23 RID: 3875
			Strike,
			// Token: 0x04000F24 RID: 3876
			Patrol,
			// Token: 0x04000F25 RID: 3877
			Support,
			// Token: 0x04000F26 RID: 3878
			Ferry,
			// Token: 0x04000F27 RID: 3879
			Mining,
			// Token: 0x04000F28 RID: 3880
			MineClearing,
			// Token: 0x04000F29 RID: 3881
			Escort,
			// Token: 0x04000F2A RID: 3882
			Cargo
		}

		// Token: 0x0200029C RID: 668
		internal enum Enum89 : byte
		{
			// Token: 0x04000F2C RID: 3884
			const_0,
			// Token: 0x04000F2D RID: 3885
			const_1
		}

		// Token: 0x0200029D RID: 669
		internal enum Enum90 : byte
		{
			// Token: 0x04000F2F RID: 3887
			const_0,
			// Token: 0x04000F30 RID: 3888
			const_1,
			// Token: 0x04000F31 RID: 3889
			const_2
		}

		// Token: 0x0200029E RID: 670
		public enum _FlightSize
		{
			// Token: 0x04000F33 RID: 3891
			None,
			// Token: 0x04000F34 RID: 3892
			SingleAircraft,
			// Token: 0x04000F35 RID: 3893
			TwoAircraft,
			// Token: 0x04000F36 RID: 3894
			ThreeAircraft,
			// Token: 0x04000F37 RID: 3895
			FourAircraft,
			// Token: 0x04000F38 RID: 3896
			SixAircraft = 6
		}

		// Token: 0x0200029F RID: 671
		public enum _GroupSize
		{
			// Token: 0x04000F3A RID: 3898
			None,
			// Token: 0x04000F3B RID: 3899
			SingleVessel,
			// Token: 0x04000F3C RID: 3900
			TwoVessels,
			// Token: 0x04000F3D RID: 3901
			ThreeVessels,
			// Token: 0x04000F3E RID: 3902
			FourVessels,
			// Token: 0x04000F3F RID: 3903
			SixVessels = 6
		}

		// Token: 0x020002A0 RID: 672
		internal enum Enum91
		{
			// Token: 0x04000F41 RID: 3905
			const_0 = 1
		}

		// Token: 0x020002A1 RID: 673
		internal enum Enum92
		{
			// Token: 0x04000F43 RID: 3907
			const_0,
			// Token: 0x04000F44 RID: 3908
			const_1,
			// Token: 0x04000F45 RID: 3909
			const_2,
			// Token: 0x04000F46 RID: 3910
			const_3
		}

		// Token: 0x020002A2 RID: 674
		public enum _FlightTask
		{
			// Token: 0x04000F48 RID: 3912
			const_0,
			// Token: 0x04000F49 RID: 3913
			const_1,
			// Token: 0x04000F4A RID: 3914
			const_2,
			// Token: 0x04000F4B RID: 3915
			const_3,
			// Token: 0x04000F4C RID: 3916
			const_4,
			// Token: 0x04000F4D RID: 3917
			const_5,
			// Token: 0x04000F4E RID: 3918
			const_6,
			// Token: 0x04000F4F RID: 3919
			const_7,
			// Token: 0x04000F50 RID: 3920
			const_8,
			// Token: 0x04000F51 RID: 3921
			const_9,
			// Token: 0x04000F52 RID: 3922
			const_10,
			// Token: 0x04000F53 RID: 3923
			const_11,
			// Token: 0x04000F54 RID: 3924
			const_12,
			// Token: 0x04000F55 RID: 3925
			const_13,
			// Token: 0x04000F56 RID: 3926
			const_14,
			// Token: 0x04000F57 RID: 3927
			const_15,
			// Token: 0x04000F58 RID: 3928
			const_16,
			// Token: 0x04000F59 RID: 3929
			const_17,
			// Token: 0x04000F5A RID: 3930
			const_18,
			// Token: 0x04000F5B RID: 3931
			const_19,
			// Token: 0x04000F5C RID: 3932
			const_20,
			// Token: 0x04000F5D RID: 3933
			const_21,
			// Token: 0x04000F5E RID: 3934
			const_22,
			// Token: 0x04000F5F RID: 3935
			const_23,
			// Token: 0x04000F60 RID: 3936
			const_24,
			// Token: 0x04000F61 RID: 3937
			const_25,
			// Token: 0x04000F62 RID: 3938
			const_26,
			// Token: 0x04000F63 RID: 3939
			const_27,
			// Token: 0x04000F64 RID: 3940
			const_28,
			// Token: 0x04000F65 RID: 3941
			const_29,
			// Token: 0x04000F66 RID: 3942
			const_30,
			// Token: 0x04000F67 RID: 3943
			const_31,
			// Token: 0x04000F68 RID: 3944
			const_32,
			// Token: 0x04000F69 RID: 3945
			const_33,
			// Token: 0x04000F6A RID: 3946
			const_34,
			// Token: 0x04000F6B RID: 3947
			const_35,
			// Token: 0x04000F6C RID: 3948
			const_36,
			// Token: 0x04000F6D RID: 3949
			const_37,
			// Token: 0x04000F6E RID: 3950
			const_38,
			// Token: 0x04000F6F RID: 3951
			const_39,
			// Token: 0x04000F70 RID: 3952
			const_40,
			// Token: 0x04000F71 RID: 3953
			const_41,
			// Token: 0x04000F72 RID: 3954
			const_42,
			// Token: 0x04000F73 RID: 3955
			const_43 = 44,
			// Token: 0x04000F74 RID: 3956
			const_44,
			// Token: 0x04000F75 RID: 3957
			const_45,
			// Token: 0x04000F76 RID: 3958
			const_46,
			// Token: 0x04000F77 RID: 3959
			const_47,
			// Token: 0x04000F78 RID: 3960
			const_48
		}

		// Token: 0x020002A3 RID: 675
		internal enum Enum93
		{
			// Token: 0x04000F7A RID: 3962
			const_0,
			// Token: 0x04000F7B RID: 3963
			const_1
		}

		// Token: 0x020002A4 RID: 676
		internal enum Enum94
		{
			// Token: 0x04000F7D RID: 3965
			const_0 = -1,
			// Token: 0x04000F7E RID: 3966
			const_1,
			// Token: 0x04000F7F RID: 3967
			const_2,
			// Token: 0x04000F80 RID: 3968
			const_3,
			// Token: 0x04000F81 RID: 3969
			const_4,
			// Token: 0x04000F82 RID: 3970
			const_5,
			// Token: 0x04000F83 RID: 3971
			const_6,
			// Token: 0x04000F84 RID: 3972
			const_7,
			// Token: 0x04000F85 RID: 3973
			const_8,
			// Token: 0x04000F86 RID: 3974
			const_9,
			// Token: 0x04000F87 RID: 3975
			const_10,
			// Token: 0x04000F88 RID: 3976
			const_11,
			// Token: 0x04000F89 RID: 3977
			const_12,
			// Token: 0x04000F8A RID: 3978
			const_13,
			// Token: 0x04000F8B RID: 3979
			const_14,
			// Token: 0x04000F8C RID: 3980
			const_15
		}

		// Token: 0x020002A5 RID: 677
		internal enum Enum95
		{
			// Token: 0x04000F8E RID: 3982
			const_0,
			// Token: 0x04000F8F RID: 3983
			const_1,
			// Token: 0x04000F90 RID: 3984
			const_2
		}

		// Token: 0x020002A6 RID: 678
		internal enum Enum96
		{
			// Token: 0x04000F92 RID: 3986
			const_0,
			// Token: 0x04000F93 RID: 3987
			const_1
		}

		// Token: 0x020002A7 RID: 679
		internal enum Enum97
		{
			// Token: 0x04000F95 RID: 3989
			const_0,
			// Token: 0x04000F96 RID: 3990
			const_1,
			// Token: 0x04000F97 RID: 3991
			const_2,
			// Token: 0x04000F98 RID: 3992
			const_3,
			// Token: 0x04000F99 RID: 3993
			const_4,
			// Token: 0x04000F9A RID: 3994
			const_5,
			// Token: 0x04000F9B RID: 3995
			const_6,
			// Token: 0x04000F9C RID: 3996
			const_7,
			// Token: 0x04000F9D RID: 3997
			const_8,
			// Token: 0x04000F9E RID: 3998
			const_9,
			// Token: 0x04000F9F RID: 3999
			const_10,
			// Token: 0x04000FA0 RID: 4000
			const_11,
			// Token: 0x04000FA1 RID: 4001
			const_12,
			// Token: 0x04000FA2 RID: 4002
			const_13,
			// Token: 0x04000FA3 RID: 4003
			const_14,
			// Token: 0x04000FA4 RID: 4004
			const_15,
			// Token: 0x04000FA5 RID: 4005
			const_16,
			// Token: 0x04000FA6 RID: 4006
			const_17,
			// Token: 0x04000FA7 RID: 4007
			const_18,
			// Token: 0x04000FA8 RID: 4008
			const_19,
			// Token: 0x04000FA9 RID: 4009
			const_20,
			// Token: 0x04000FAA RID: 4010
			const_21
		}

		// Token: 0x020002A8 RID: 680
		internal enum Enum98
		{
			// Token: 0x04000FAC RID: 4012
			const_0,
			// Token: 0x04000FAD RID: 4013
			const_1,
			// Token: 0x04000FAE RID: 4014
			const_2
		}

		// Token: 0x020002A9 RID: 681
		internal enum Enum99
		{
			// Token: 0x04000FB0 RID: 4016
			const_0,
			// Token: 0x04000FB1 RID: 4017
			const_1,
			// Token: 0x04000FB2 RID: 4018
			const_2,
			// Token: 0x04000FB3 RID: 4019
			const_3,
			// Token: 0x04000FB4 RID: 4020
			const_4
		}

		// Token: 0x020002AA RID: 682
		internal enum Enum100
		{
			// Token: 0x04000FB6 RID: 4022
			const_0,
			// Token: 0x04000FB7 RID: 4023
			const_1 = -99,
			// Token: 0x04000FB8 RID: 4024
			const_2 = -100,
			// Token: 0x04000FB9 RID: 4025
			const_3 = -97,
			// Token: 0x04000FBA RID: 4026
			const_4,
			// Token: 0x04000FBB RID: 4027
			const_5,
			// Token: 0x04000FBC RID: 4028
			const_6,
			// Token: 0x04000FBD RID: 4029
			const_7,
			// Token: 0x04000FBE RID: 4030
			const_8,
			// Token: 0x04000FBF RID: 4031
			const_9,
			// Token: 0x04000FC0 RID: 4032
			const_10 = -87,
			// Token: 0x04000FC1 RID: 4033
			const_11,
			// Token: 0x04000FC2 RID: 4034
			const_12,
			// Token: 0x04000FC3 RID: 4035
			const_13,
			// Token: 0x04000FC4 RID: 4036
			const_14,
			// Token: 0x04000FC5 RID: 4037
			const_15,
			// Token: 0x04000FC6 RID: 4038
			const_16
		}

		// Token: 0x020002AB RID: 683
		internal enum Enum101
		{
			// Token: 0x04000FC8 RID: 4040
			const_0,
			// Token: 0x04000FC9 RID: 4041
			const_1
		}

		// Token: 0x020002AC RID: 684
		internal enum Enum102
		{
			// Token: 0x04000FCB RID: 4043
			const_0,
			// Token: 0x04000FCC RID: 4044
			const_1,
			// Token: 0x04000FCD RID: 4045
			const_2,
			// Token: 0x04000FCE RID: 4046
			const_3,
			// Token: 0x04000FCF RID: 4047
			const_4,
			// Token: 0x04000FD0 RID: 4048
			const_5,
			// Token: 0x04000FD1 RID: 4049
			const_6,
			// Token: 0x04000FD2 RID: 4050
			const_7,
			// Token: 0x04000FD3 RID: 4051
			const_8
		}

		// Token: 0x020002AD RID: 685
		internal enum Enum103
		{
			// Token: 0x04000FD5 RID: 4053
			const_0,
			// Token: 0x04000FD6 RID: 4054
			const_1,
			// Token: 0x04000FD7 RID: 4055
			const_2
		}

		// Token: 0x020002AE RID: 686
		internal enum Enum104
		{
			// Token: 0x04000FD9 RID: 4057
			const_0,
			// Token: 0x04000FDA RID: 4058
			const_1,
			// Token: 0x04000FDB RID: 4059
			const_2,
			// Token: 0x04000FDC RID: 4060
			const_3,
			// Token: 0x04000FDD RID: 4061
			const_4 = -97,
			// Token: 0x04000FDE RID: 4062
			const_5 = -98,
			// Token: 0x04000FDF RID: 4063
			const_6 = -99
		}

		// Token: 0x020002AF RID: 687
		internal enum Enum105
		{
			// Token: 0x04000FE1 RID: 4065
			const_0,
			// Token: 0x04000FE2 RID: 4066
			const_1,
			// Token: 0x04000FE3 RID: 4067
			const_2
		}

		// Token: 0x020002B0 RID: 688
		public sealed class Flight : Class310
		{
			// Token: 0x06001458 RID: 5208 RVA: 0x00180EB8 File Offset: 0x0017F0B8
			public Flight()
			{
				this.bool_13 = false;
				this.waypoint_0 = new Waypoint[0];
				this.waypoint_1 = new Waypoint[0];
				this.waypoint_2 = new Waypoint[0];
				this.waypoint_3 = new Waypoint[0];
				this.waypoint_4 = new Waypoint[0];
				this.string_16 = "-";
				this.string_17 = "-";
				this.string_18 = "-";
				this.string_19 = "-";
				this.enum82_0 = Waypoint.Enum82.const_4;
				this.enum82_1 = Waypoint.Enum82.const_4;
				this.bool_14 = false;
				this.bool_15 = false;
				this.bool_16 = false;
				this.bool_17 = false;
				this.string_21 = "";
			}

			// Token: 0x06001459 RID: 5209 RVA: 0x00180F70 File Offset: 0x0017F170
			public Flight(ref Scenario scenario_0, ref Mission mission_1, ref Mission.Flight flight_0, string string_22, string string_23, string string_24, int int_5, Contact contact_1, ActiveUnit activeUnit_1, Mission._FlightSize _FlightSize_2, bool bool_18)
			{
				this.bool_13 = false;
				this.waypoint_0 = new Waypoint[0];
				this.waypoint_1 = new Waypoint[0];
				this.waypoint_2 = new Waypoint[0];
				this.waypoint_3 = new Waypoint[0];
				this.waypoint_4 = new Waypoint[0];
				this.string_16 = "-";
				this.string_17 = "-";
				this.string_18 = "-";
				this.string_19 = "-";
				this.enum82_0 = Waypoint.Enum82.const_4;
				this.enum82_1 = Waypoint.Enum82.const_4;
				this.bool_14 = false;
				this.bool_15 = false;
				this.bool_16 = false;
				this.bool_17 = false;
				this.string_21 = "";
				try
				{
					this.string_2 = mission_1.string_0;
					this.string_3 = mission_1.Name;
					this.string_4 = string_22;
					this.string_5 = string_23;
					this.string_6 = string_24;
					this.string_7 = string_23;
					this.string_8 = string_24;
					this.int_3 = int_5;
					this.contact_0 = contact_1;
					if (!Information.IsNothing(contact_1))
					{
						this.string_20 = contact_1.string_0;
					}
					this.method_33(scenario_0, activeUnit_1);
					this._FlightSize_0 = _FlightSize_2;
					this.enum101_0 = Mission.Enum101.const_1;
					this.bool_12 = bool_18;
					if (mission_1.bool_12)
					{
						this._FlightSize_1 = _FlightSize_2;
					}
					else
					{
						this._FlightSize_1 = Mission._FlightSize.None;
					}
					if (!Information.IsNothing(flight_0))
					{
						foreach (Waypoint waypoint in flight_0.method_15())
						{
							Waypoint[] waypoint_ = this.method_15();
							bool flag = true;
							bool bool_19 = true;
							Doctrine doctrine = null;
							Class429.smethod_36(ref waypoint_, Waypoint.smethod_14(ref scenario_0, ref waypoint, flag, bool_19, ref doctrine));
							this.method_16(waypoint_);
						}
					}
					switch (mission_1._MissionClass_0)
					{
					case Mission._MissionClass.Strike:
						if (this.bool_12)
						{
							if (!Information.IsNothing(this.method_32(scenario_0)) && this.method_32(scenario_0).vmethod_86().bool_2)
							{
								Aircraft aircraft = (Aircraft)this.method_32(scenario_0);
								if (Information.IsNothing(aircraft.method_167()))
								{
									this._FlightTask_0 = Mission._FlightTask.const_47;
								}
								else if (aircraft.method_167().method_12())
								{
									this._FlightTask_0 = Mission._FlightTask.const_47;
								}
								else if (aircraft.method_167().method_10())
								{
									this._FlightTask_0 = Mission._FlightTask.const_14;
								}
								else if (aircraft.method_167().method_13())
								{
									this._FlightTask_0 = Mission._FlightTask.const_16;
								}
								else
								{
									this._FlightTask_0 = Mission._FlightTask.const_47;
								}
							}
							else
							{
								this._FlightTask_0 = Mission._FlightTask.const_47;
							}
						}
						else
						{
							switch (((Strike)mission_1).strikeType_0)
							{
							case Strike.StrikeType.Air_Intercept:
								this._FlightTask_0 = Mission._FlightTask.const_12;
								break;
							case Strike.StrikeType.Land_Strike:
								this._FlightTask_0 = Mission._FlightTask.const_1;
								break;
							case Strike.StrikeType.Maritime_Strike:
								this._FlightTask_0 = Mission._FlightTask.const_2;
								break;
							case Strike.StrikeType.Sub_Strike:
								this._FlightTask_0 = Mission._FlightTask.const_29;
								break;
							}
						}
						break;
					case Mission._MissionClass.Patrol:
						switch (((Class343)mission_1).patrolType_0)
						{
						case GlobalVariables.PatrolType.ASW:
							this._FlightTask_0 = Mission._FlightTask.const_29;
							break;
						case GlobalVariables.PatrolType.ASuW_Naval:
							this._FlightTask_0 = Mission._FlightTask.const_34;
							break;
						case GlobalVariables.PatrolType.AAW:
							this._FlightTask_0 = Mission._FlightTask.const_9;
							break;
						case GlobalVariables.PatrolType.ASuW_Land:
							this._FlightTask_0 = Mission._FlightTask.const_31;
							break;
						case GlobalVariables.PatrolType.ASuW_Mixed:
							this._FlightTask_0 = Mission._FlightTask.const_31;
							break;
						case GlobalVariables.PatrolType.SEAD:
							this._FlightTask_0 = Mission._FlightTask.const_4;
							break;
						case GlobalVariables.PatrolType.SeaControl:
							this._FlightTask_0 = Mission._FlightTask.const_34;
							break;
						}
						break;
					case Mission._MissionClass.Support:
						this._FlightTask_0 = Mission._FlightTask.const_46;
						break;
					case Mission._MissionClass.Ferry:
						this._FlightTask_0 = Mission._FlightTask.const_42;
						break;
					case Mission._MissionClass.Mining:
						this._FlightTask_0 = Mission._FlightTask.const_28;
						break;
					case Mission._MissionClass.MineClearing:
						this._FlightTask_0 = Mission._FlightTask.const_26;
						break;
					case Mission._MissionClass.Escort:
						this._FlightTask_0 = Mission._FlightTask.const_47;
						break;
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

			// Token: 0x0600145A RID: 5210 RVA: 0x00181368 File Offset: 0x0017F568
			public bool method_8()
			{
				Mission._FlightTask flightTask_ = this._FlightTask_0;
				if (flightTask_ - Mission._FlightTask.const_14 > 2)
				{
					if (flightTask_ != Mission._FlightTask.const_47)
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x0600145B RID: 5211 RVA: 0x00181394 File Offset: 0x0017F594
			public void method_9(ref Scenario scenario_0)
			{
				try
				{
					DateTime dateTime_ = scenario_0.method_31();
					bool bool_ = scenario_0.method_33();
					string string_ = scenario_0.method_35();
					string string_2 = scenario_0.method_37();
					DateTime? dateTime = null;
					DateTime? dateTime2 = null;
					DateTime? dateTime3 = null;
					DateTime? dateTime4 = null;
					string str = "";
					string str2 = "";
					bool? flag = null;
					if (Enumerable.Count<Waypoint>(this.method_15()) > 0)
					{
						int num = Enumerable.Count<Waypoint>(this.method_15()) - 1;
						for (int i = 0; i <= num; i++)
						{
							Waypoint waypoint = this.method_15()[i];
							if (Information.IsNothing(waypoint.nullable_7))
							{
								this.string_16 = "-";
								this.string_17 = "-";
								this.string_18 = "-";
								this.string_19 = "-";
								this.enum82_0 = Waypoint.Enum82.const_4;
								this.enum82_1 = Waypoint.Enum82.const_4;
								break;
							}
							flag = new bool?(false);
							if (waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
							{
								dateTime = waypoint.nullable_7;
								this.enum82_0 = waypoint.enum82_0;
								Waypoint waypoint2 = waypoint;
								Scenario scenario_ = null;
								DateTime value = dateTime.Value;
								int year = value.Year;
								value = dateTime.Value;
								int month = value.Month;
								value = dateTime.Value;
								int day = value.Day;
								value = dateTime.Value;
								int hour = value.Hour;
								value = dateTime.Value;
								int minute = value.Minute;
								value = dateTime.Value;
								waypoint2.ttimeOfDayType_0 = Class418.smethod_1(scenario_, year, month, day, hour, minute, value.Second, false, waypoint.imethod_2(), waypoint.imethod_0(), 0.0);
								waypoint.nullable_9 = new DateTime?(Misc.smethod_10(waypoint.nullable_7.Value, waypoint.imethod_0(), bool_, string_, string_2));
								dateTime2 = waypoint.nullable_9;
								str = " (" + Class418.smethod_0(waypoint.ttimeOfDayType_0, dateTime_, waypoint.imethod_0(), bool_, string_, string_2) + ")";
							}
							else if (waypoint.waypointType_0 == Waypoint.WaypointType.Target || waypoint.waypointType_0 == Waypoint.WaypointType.WeaponTarget || waypoint.method_40())
							{
								flag = new bool?(true);
								this.enum82_1 = waypoint.enum82_0;
								if (Information.IsNothing(waypoint.nullable_8))
								{
									dateTime3 = waypoint.nullable_7;
								}
								else
								{
									dateTime3 = waypoint.nullable_8;
								}
								Waypoint waypoint3 = waypoint;
								Scenario scenario_2 = null;
								DateTime value = dateTime3.Value;
								int year2 = value.Year;
								value = dateTime3.Value;
								int month2 = value.Month;
								value = dateTime3.Value;
								int day2 = value.Day;
								value = dateTime3.Value;
								int hour2 = value.Hour;
								value = dateTime3.Value;
								int minute2 = value.Minute;
								value = dateTime3.Value;
								waypoint3.ttimeOfDayType_0 = Class418.smethod_1(scenario_2, year2, month2, day2, hour2, minute2, value.Second, false, waypoint.imethod_2(), waypoint.imethod_0(), 0.0);
								if (Information.IsNothing(waypoint.nullable_8))
								{
									waypoint.nullable_9 = new DateTime?(Misc.smethod_10(waypoint.nullable_7.Value, waypoint.imethod_0(), bool_, string_, string_2));
								}
								else
								{
									waypoint.nullable_9 = new DateTime?(Misc.smethod_10(waypoint.nullable_8.Value, waypoint.imethod_0(), bool_, string_, string_2));
								}
								dateTime4 = waypoint.nullable_9;
								str2 = " (" + Class418.smethod_0(waypoint.ttimeOfDayType_0, dateTime_, waypoint.imethod_0(), bool_, string_, string_2) + ")";
								break;
							}
						}
					}
					if (!Information.IsNothing(dateTime))
					{
						DateTime value = dateTime.Value;
						GameGeneral.smethod_46(ref value, ref this.string_16);
					}
					else
					{
						this.string_16 = "-";
					}
					if (!Information.IsNothing(dateTime2))
					{
						this.string_17 = "";
						DateTime value = dateTime2.Value;
						GameGeneral.smethod_47(ref value, ref this.string_17);
						ref string ptr = ref this.string_17;
						this.string_17 = ptr + str;
					}
					else
					{
						this.string_17 = "-";
					}
					if (!Information.IsNothing(dateTime3))
					{
						DateTime value = dateTime3.Value;
						GameGeneral.smethod_46(ref value, ref this.string_18);
					}
					else if (((!Information.IsNothing(flag)) ? ((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag) : new bool?(false)).GetValueOrDefault())
					{
						this.string_18 = "No waypoint found";
					}
					else
					{
						this.string_18 = "-";
					}
					if (!Information.IsNothing(dateTime4))
					{
						this.string_19 = "";
						DateTime value = dateTime4.Value;
						GameGeneral.smethod_47(ref value, ref this.string_19);
						ref string ptr = ref this.string_19;
						this.string_19 = ptr + str2;
					}
					else if (((!Information.IsNothing(flag)) ? ((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag) : new bool?(false)).GetValueOrDefault())
					{
						this.string_19 = "No waypoint found";
					}
					else
					{
						this.string_19 = "-";
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

			// Token: 0x0600145C RID: 5212 RVA: 0x0000B2C9 File Offset: 0x000094C9
			public Mission.Enum102 method_10(Scenario scenario_0)
			{
				return this.enum102_0;
			}

			// Token: 0x0600145D RID: 5213 RVA: 0x00181900 File Offset: 0x0017FB00
			public void method_11(Scenario scenario_0, Mission.Enum102 enum102_1)
			{
				bool flag = enum102_1 != this.enum102_0;
				this.enum102_0 = enum102_1;
				if (flag)
				{
					for (int i = scenario_0.MissionPlannerErrorList.Count - 1; i >= 0; i += -1)
					{
						string text = scenario_0.MissionPlannerErrorList[i];
						if (text.Contains(this.string_4))
						{
							scenario_0.MissionPlannerErrorList.Remove(text);
						}
					}
				}
			}

			// Token: 0x0600145E RID: 5214 RVA: 0x00181964 File Offset: 0x0017FB64
			public bool method_12()
			{
				Mission.Enum102 @enum = this.enum102_0;
				return @enum - Mission.Enum102.const_4 <= 4;
			}

			// Token: 0x0600145F RID: 5215 RVA: 0x00181988 File Offset: 0x0017FB88
			public string method_13(Scenario scenario_0)
			{
				if (string.IsNullOrEmpty(this.string_13))
				{
					try
					{
						if (this.int_3 == 0)
						{
							return "Not set";
						}
						if (!Information.IsNothing(this.method_32(scenario_0)) && !Information.IsNothing(((Aircraft)this.method_32(scenario_0)).method_167()))
						{
							this.string_13 = ((Aircraft)this.method_32(scenario_0)).method_167().Name;
						}
						else
						{
							Loadout loadout = DBFunctions.smethod_47(ref scenario_0, this.int_3, false, false);
							if (!Information.IsNothing(loadout))
							{
								this.string_13 = loadout.Name;
							}
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
				return this.string_13;
			}

			// Token: 0x06001460 RID: 5216 RVA: 0x0000B2D1 File Offset: 0x000094D1
			public void method_14(Scenario scenario_0, string string_22)
			{
				this.string_13 = string_22;
			}

			// Token: 0x06001461 RID: 5217 RVA: 0x0000B2DA File Offset: 0x000094DA
			public Waypoint[] method_15()
			{
				return this.waypoint_0;
			}

			// Token: 0x06001462 RID: 5218 RVA: 0x0000B2E2 File Offset: 0x000094E2
			public void method_16(Waypoint[] waypoint_5)
			{
				this.waypoint_0 = waypoint_5;
			}

			// Token: 0x06001463 RID: 5219 RVA: 0x0000B2EB File Offset: 0x000094EB
			public void method_17()
			{
				Class429.smethod_38(ref this.waypoint_0);
			}

			// Token: 0x06001464 RID: 5220 RVA: 0x0000B2F8 File Offset: 0x000094F8
			public Waypoint[] method_18()
			{
				return this.waypoint_1;
			}

			// Token: 0x06001465 RID: 5221 RVA: 0x0000B300 File Offset: 0x00009500
			public void method_19(Waypoint[] waypoint_5)
			{
				this.waypoint_1 = waypoint_5;
			}

			// Token: 0x06001466 RID: 5222 RVA: 0x0000B309 File Offset: 0x00009509
			public Waypoint[] method_20()
			{
				return this.waypoint_2;
			}

			// Token: 0x06001467 RID: 5223 RVA: 0x0000B311 File Offset: 0x00009511
			public void method_21(Waypoint[] waypoint_5)
			{
				this.waypoint_2 = waypoint_5;
			}

			// Token: 0x06001468 RID: 5224 RVA: 0x0000B31A File Offset: 0x0000951A
			public Waypoint[] method_22()
			{
				return this.waypoint_3;
			}

			// Token: 0x06001469 RID: 5225 RVA: 0x0000B322 File Offset: 0x00009522
			public void method_23(Waypoint[] waypoint_5)
			{
				this.waypoint_3 = waypoint_5;
			}

			// Token: 0x0600146A RID: 5226 RVA: 0x0000B32B File Offset: 0x0000952B
			public Waypoint[] method_24()
			{
				return this.waypoint_4;
			}

			// Token: 0x0600146B RID: 5227 RVA: 0x0000B333 File Offset: 0x00009533
			public void method_25(Waypoint[] waypoint_5)
			{
				this.waypoint_4 = waypoint_5;
			}

			// Token: 0x0600146C RID: 5228 RVA: 0x00181A70 File Offset: 0x0017FC70
			public void method_26(ref Scenario scenario_0, ref Mission mission_1, Mission._FlightSize _FlightSize_2)
			{
				try
				{
					if (this.method_10(scenario_0) != Mission.Enum102.const_0)
					{
						GameGeneral.smethod_1("Cannot change flight size for airborne flights.");
					}
					else if (_FlightSize_2 != this._FlightSize_0)
					{
						bool flag = _FlightSize_2 > this._FlightSize_0;
						if (this.method_28())
						{
							if (flag)
							{
								int num = Enumerable.Count<Waypoint>(this.method_15()) - 2;
								for (int i = 1; i <= num; i++)
								{
									Waypoint waypoint = this.method_15()[i];
									Waypoint waypoint2 = this.method_15()[i - 1];
									Waypoint waypoint3 = this.method_15()[i + 1];
									if (!Information.IsNothing(waypoint) && waypoint.enum83_0 == Waypoint.Enum83.const_2)
									{
										waypoint.method_20(ref scenario_0, ref _FlightSize_2, ref waypoint2, ref waypoint3, false);
									}
								}
							}
							else
							{
								int num2 = Enumerable.Count<Waypoint>(this.method_15()) - 1;
								for (int j = 0; j <= num2; j++)
								{
									Waypoint waypoint4 = this.method_15()[j];
									if (!Information.IsNothing(waypoint4))
									{
										if (!Information.IsNothing(waypoint4.waypoint_0) && _FlightSize_2 < Mission._FlightSize.TwoAircraft)
										{
											waypoint4.waypoint_0 = null;
										}
										if (!Information.IsNothing(waypoint4.waypoint_1) && _FlightSize_2 < Mission._FlightSize.ThreeAircraft)
										{
											waypoint4.waypoint_1 = null;
										}
										if (!Information.IsNothing(waypoint4.waypoint_2) && _FlightSize_2 < Mission._FlightSize.FourAircraft)
										{
											waypoint4.waypoint_2 = null;
										}
										if (!Information.IsNothing(waypoint4.waypoint_3) && _FlightSize_2 < Mission._FlightSize.SixAircraft)
										{
											waypoint4.waypoint_3 = null;
										}
										if (!Information.IsNothing(waypoint4.waypoint_4) && _FlightSize_2 < Mission._FlightSize.SixAircraft)
										{
											waypoint4.waypoint_4 = null;
										}
									}
								}
							}
						}
						if (flag)
						{
							int num3 = _FlightSize_2 - this._FlightSize_0;
							if (Information.IsNothing(mission_1.list_2))
							{
								mission_1.list_2 = new List<Mission.EmptyAircraftSlot>();
							}
							int num4 = num3;
							for (int k = 1; k <= num4; k++)
							{
								if (Information.IsNothing(mission_1.list_2))
								{
									mission_1.list_2 = new List<Mission.EmptyAircraftSlot>();
								}
								ActiveUnit activeUnit_ = null;
								int int_ = this.int_2;
								string text = this.string_12;
								int int_2 = this.int_3;
								string text2 = this.method_13(scenario_0);
								ActiveUnit activeUnit = null;
								Mission.EmptyAircraftSlot emptyAircraftSlot = new Mission.EmptyAircraftSlot(activeUnit_, int_, text, int_2, text2, ref activeUnit, this.string_5, this.string_6, this.bool_12);
								mission_1.list_2.Add(emptyAircraftSlot);
								emptyAircraftSlot.method_7(scenario_0, this, 0);
								if (scenario_0.vmethod_0().ContainsKey(this.string_5))
								{
									emptyAircraftSlot.method_4(scenario_0, scenario_0.vmethod_0()[this.string_5]);
								}
							}
						}
						else
						{
							int num5 = this._FlightSize_0 - _FlightSize_2;
							if (!Information.IsNothing(mission_1.list_2))
							{
								for (int l = mission_1.list_2.Count - 1; l >= 0; l += -1)
								{
									Mission.EmptyAircraftSlot emptyAircraftSlot2 = mission_1.list_2[l];
									if (Operators.CompareString(emptyAircraftSlot2.string_2, this.string_0, false) == 0)
									{
										mission_1.list_2.Remove(emptyAircraftSlot2);
										num5--;
										if (num5 == 0)
										{
											break;
										}
									}
								}
							}
							if (num5 > 0)
							{
								List<ActiveUnit> list = Enumerable.ToList<ActiveUnit>(mission_1.method_15(scenario_0));
								for (int m = list.Count - 1; m >= 0; m += -1)
								{
									ActiveUnit activeUnit2 = list[m];
									if (activeUnit2.vmethod_85().method_48() && activeUnit2.vmethod_85().method_7() == this)
									{
										activeUnit2.vmethod_85().vmethod_10();
										num5--;
										if (num5 == 0)
										{
											break;
										}
									}
								}
							}
						}
						this._FlightSize_0 = _FlightSize_2;
						if (this._FlightSize_1 > this._FlightSize_0)
						{
							this._FlightSize_1 = this._FlightSize_0;
						}
						Scenario scenario_ = scenario_0;
						Mission mission = mission_1;
						ActiveUnit activeUnit3 = this.method_32(scenario_0);
						Waypoint[] waypoint_ = this.method_15();
						float num6 = 0f;
						float num7 = 0f;
						Class514.smethod_28(scenario_, mission, activeUnit3, this, ref waypoint_, ref num6, ref num7, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
						this.method_16(waypoint_);
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

			// Token: 0x0600146D RID: 5229 RVA: 0x0000B33C File Offset: 0x0000953C
			public void method_27(ref Scenario scenario_0, ref Mission mission_1, Mission._FlightSize _FlightSize_2)
			{
				if (this.method_10(scenario_0) != Mission.Enum102.const_0)
				{
					GameGeneral.smethod_1("Cannot change flight size for airborne flights.");
					return;
				}
				if (_FlightSize_2 > this._FlightSize_0)
				{
					GameGeneral.smethod_1("Minimum flight size cannot be larger than desired flight size.");
					return;
				}
				this._FlightSize_1 = _FlightSize_2;
			}

			// Token: 0x0600146E RID: 5230 RVA: 0x00181E8C File Offset: 0x0018008C
			public bool method_28()
			{
				int num = Enumerable.Count<Waypoint>(this.method_15()) - 1;
				for (int i = 0; i <= num; i++)
				{
					Waypoint waypoint = this.method_15()[i];
					if (!Information.IsNothing(waypoint) && waypoint.method_21())
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x0600146F RID: 5231 RVA: 0x00181ED4 File Offset: 0x001800D4
			public void method_29(ref Scenario scenario_0, ref Mission.Flight flight_0, string string_22, string string_23)
			{
				try
				{
					if (!Information.IsNothing(scenario_0) && !Information.IsNothing(scenario_0.MissionPlannerErrorList) && scenario_0.MissionPlannerErrorList.Count > 0 && !string.IsNullOrEmpty(flight_0.string_4))
					{
						for (int i = scenario_0.MissionPlannerErrorList.Count - 1; i >= 0; i += -1)
						{
							string text = scenario_0.MissionPlannerErrorList[i];
							if (string.IsNullOrEmpty(text))
							{
								scenario_0.MissionPlannerErrorList.Remove(scenario_0.MissionPlannerErrorList[i]);
							}
							else if (text.Contains(string_22))
							{
								scenario_0.MissionPlannerErrorList[i] = text.Replace(string_22, string_23);
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101383", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}

			// Token: 0x06001470 RID: 5232 RVA: 0x00181FD0 File Offset: 0x001801D0
			public void method_30(ref Scenario scenario_0, ref Mission.Flight flight_0)
			{
				try
				{
					if (!Information.IsNothing(flight_0.list_0) && flight_0.list_0.Count > 0 && !string.IsNullOrEmpty(flight_0.string_4))
					{
						string text = "Master Flightplan AircraftDBID: " + Conversions.ToString(flight_0.int_2) + " LoadoutDBID: " + Conversions.ToString(flight_0.int_3);
						for (int i = flight_0.list_0.Count - 1; i >= 0; i += -1)
						{
							string text2 = flight_0.list_0[i];
							if (string.IsNullOrEmpty(text2))
							{
								flight_0.list_0.Remove(flight_0.list_0[i]);
							}
							else
							{
								string text3 = text2;
								if (text3.Contains(text))
								{
									text3 = text3.Replace(text, this.string_4);
								}
								scenario_0.MissionPlannerErrorList.Add(text3);
							}
						}
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

			// Token: 0x06001471 RID: 5233 RVA: 0x001820F4 File Offset: 0x001802F4
			public void method_31(ref Scenario scenario_0, ref Mission.Flight flight_0, ref Mission.Flight flight_1, bool bool_18, ref Mission mission_1, ref int int_5, ref int int_6, bool bool_19, bool bool_20)
			{
				try
				{
					if (!Information.IsNothing(flight_0) && !Information.IsNothing(flight_1))
					{
						string newValue;
						if (!Information.IsNothing(mission_1))
						{
							newValue = Class163.smethod_6(ref mission_1);
						}
						else
						{
							newValue = "Temporary flightplan";
						}
						flight_1.string_2 = flight_0.string_2;
						flight_1.string_3 = flight_0.string_3;
						flight_1.string_4 = newValue;
						flight_1._FlightTask_0 = flight_0._FlightTask_0;
						flight_1.enum93_0 = flight_0.enum93_0;
						flight_1.enum101_0 = flight_0.enum101_0;
						flight_1.string_5 = flight_0.string_5;
						flight_1.string_6 = flight_0.string_6;
						flight_1.string_7 = flight_0.string_7;
						flight_1.string_8 = flight_0.string_8;
						flight_1.string_9 = flight_0.string_9;
						flight_1.string_10 = flight_0.string_10;
						if (bool_18)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
						else
						{
							flight_1._FlightSize_0 = flight_0._FlightSize_0;
						}
						flight_1.bool_12 = flight_0.bool_12;
						flight_1.nullable_0 = flight_0.nullable_0;
						flight_1.nullable_1 = flight_0.nullable_1;
						flight_1.float_0 = flight_0.float_0;
						flight_1.nullable_2 = flight_0.nullable_2;
						flight_1.nullable_3 = flight_0.nullable_3;
						flight_1.enum101_0 = flight_0.enum101_0;
						flight_1.method_11(scenario_0, Mission.Enum102.const_0);
						flight_1.enum103_0 = flight_0.enum103_0;
						flight_1.enum103_1 = flight_0.enum103_1;
						flight_1._FlightSize_1 = flight_0._FlightSize_1;
						flight_1.int_0 = flight_0.int_0;
						flight_1.int_1 = flight_0.int_1;
						flight_1.bool_13 = false;
						flight_1.method_33(null, null);
						flight_1.int_2 = flight_0.int_2;
						flight_1.string_11 = "";
						flight_1.string_12 = flight_0.string_12;
						flight_1.int_3 = flight_0.int_3;
						flight_1.method_14(scenario_0, flight_0.method_13(scenario_0));
						if (!Information.IsNothing(flight_0.method_15()) && Enumerable.Count<Waypoint>(flight_0.method_15()) > 0)
						{
							foreach (Waypoint waypoint in flight_0.method_15())
							{
								Mission.Flight flight = flight_1;
								Waypoint[] array2 = flight.method_15();
								bool flag = true;
								bool bool_21 = true;
								Doctrine doctrine = null;
								Class429.smethod_36(ref array2, Waypoint.smethod_14(ref scenario_0, ref waypoint, flag, bool_21, ref doctrine));
								flight.method_16(array2);
							}
						}
						if (!Information.IsNothing(flight_0.method_18()) && Enumerable.Count<Waypoint>(flight_0.method_18()) > 0)
						{
							foreach (Waypoint waypoint2 in flight_0.method_18())
							{
								Mission.Flight flight2 = flight_1;
								Waypoint[] array3 = flight2.method_18();
								bool flag2 = true;
								bool bool_22 = true;
								Doctrine doctrine = null;
								Class429.smethod_36(ref array3, Waypoint.smethod_14(ref scenario_0, ref waypoint2, flag2, bool_22, ref doctrine));
								flight2.method_19(array3);
							}
						}
						if (!Information.IsNothing(flight_0.method_20()) && Enumerable.Count<Waypoint>(flight_0.method_20()) > 0)
						{
							foreach (Waypoint waypoint3 in flight_0.method_20())
							{
								Mission.Flight flight3 = flight_1;
								Waypoint[] array4 = flight3.method_20();
								bool flag3 = true;
								bool bool_23 = true;
								Doctrine doctrine = null;
								Class429.smethod_36(ref array4, Waypoint.smethod_14(ref scenario_0, ref waypoint3, flag3, bool_23, ref doctrine));
								flight3.method_21(array4);
							}
						}
						if (!Information.IsNothing(flight_0.method_22()) && Enumerable.Count<Waypoint>(flight_0.method_22()) > 0)
						{
							foreach (Waypoint waypoint4 in flight_0.method_22())
							{
								Mission.Flight flight4 = flight_1;
								Waypoint[] array5 = flight4.method_22();
								bool flag4 = true;
								bool bool_24 = true;
								Doctrine doctrine = null;
								Class429.smethod_36(ref array5, Waypoint.smethod_14(ref scenario_0, ref waypoint4, flag4, bool_24, ref doctrine));
								flight4.method_23(array5);
							}
						}
						if (!Information.IsNothing(flight_0.method_24()) && Enumerable.Count<Waypoint>(flight_0.method_24()) > 0)
						{
							foreach (Waypoint waypoint5 in flight_0.method_24())
							{
								Mission.Flight flight5 = flight_1;
								Waypoint[] waypoint_ = flight5.method_24();
								bool flag5 = true;
								bool bool_25 = true;
								Doctrine doctrine = null;
								Class429.smethod_36(ref waypoint_, Waypoint.smethod_14(ref scenario_0, ref waypoint5, flag5, bool_25, ref doctrine));
								flight5.method_25(waypoint_);
							}
						}
						flight_1.mission_0 = flight_0.mission_0;
						flight_1.int_4 = 0;
						flight_1.contact_0 = flight_0.contact_0;
						flight_1.string_20 = flight_0.string_20;
						flight_1.bool_14 = false;
						flight_1.bool_15 = false;
						flight_1.bool_16 = false;
						flight_1.bool_17 = false;
						flight_1.string_21 = "";
						if (!Information.IsNothing(mission_1))
						{
							mission_1.method_60(ref flight_1);
						}
						if (!Information.IsNothing(mission_1) && bool_19)
						{
							if (Information.IsNothing(mission_1.list_2))
							{
								mission_1.list_2 = new List<Mission.EmptyAircraftSlot>();
							}
							ActiveUnit activeUnit;
							if (scenario_0.vmethod_0().ContainsKey(flight_1.string_5))
							{
								activeUnit = scenario_0.vmethod_0()[flight_1.string_5];
							}
							int flightSize_ = (int)flight_1._FlightSize_0;
							for (int n = 1; n <= flightSize_; n++)
							{
								Mission.EmptyAircraftSlot emptyAircraftSlot = new Mission.EmptyAircraftSlot(null, flight_1.int_2, flight_1.string_12, flight_1.int_3, flight_1.method_13(scenario_0), ref activeUnit, flight_1.string_5, flight_1.string_8, flight_1.bool_12);
								mission_1.list_2.Add(emptyAircraftSlot);
								emptyAircraftSlot.method_7(scenario_0, flight_1, n);
							}
						}
						if (bool_20)
						{
							for (int num = scenario_0.MissionPlannerErrorList.Count - 1; num >= 0; num += -1)
							{
								string text = scenario_0.MissionPlannerErrorList[num];
								if (string.IsNullOrEmpty(text))
								{
									scenario_0.MissionPlannerErrorList.Remove(scenario_0.MissionPlannerErrorList[num]);
								}
								else if (text.Contains(flight_0.string_4))
								{
									string item = text.Replace(flight_0.string_4, newValue);
									scenario_0.MissionPlannerErrorList.Add(item);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101384", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}

			// Token: 0x06001472 RID: 5234 RVA: 0x0018271C File Offset: 0x0018091C
			public ActiveUnit method_32(Scenario scenario_0)
			{
				ActiveUnit result;
				try
				{
					if (Information.IsNothing(this.activeUnit_0) && !Information.IsNothing(scenario_0))
					{
						if (!string.IsNullOrEmpty(this.string_11) && scenario_0.vmethod_0().ContainsKey(this.string_11))
						{
							this.activeUnit_0 = scenario_0.vmethod_0()[this.string_11];
						}
						if (Information.IsNothing(this.activeUnit_0))
						{
							try
							{
								foreach (ActiveUnit activeUnit in scenario_0.vmethod_0().Values)
								{
									if (!Information.IsNothing(activeUnit) && activeUnit.vmethod_85().method_49() && activeUnit.vmethod_85().method_7() == this)
									{
										this.method_33(scenario_0, activeUnit);
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
						if (Information.IsNothing(this.activeUnit_0) && this.int_2 > 0)
						{
							bool flag = false;
							foreach (Side side in scenario_0.method_44())
							{
								try
								{
									foreach (Mission mission in side.method_35())
									{
										if (mission.method_54())
										{
											try
											{
												foreach (Mission.Flight flight in mission.list_1)
												{
													if (flight == this)
													{
														Mission mission2 = mission;
														int int_ = this.int_2;
														int int_2 = this.int_3;
														ObservableDictionary<string, ActiveUnit> observableDictionary;
														string key;
														ActiveUnit value = (observableDictionary = scenario_0.vmethod_0())[key = this.string_5];
														ActiveUnit activeUnit2 = mission2.method_64(ref scenario_0, ref side, int_, int_2, ref value, ref flight, false, 1);
														observableDictionary[key] = value;
														this.activeUnit_0 = activeUnit2;
														flag = true;
														break;
													}
												}
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
					result = this.activeUnit_0;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101385", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = null;
				}
				return result;
			}

			// Token: 0x06001473 RID: 5235 RVA: 0x001829A0 File Offset: 0x00180BA0
			public void method_33(Scenario scenario_0, ActiveUnit activeUnit_1)
			{
				this.activeUnit_0 = activeUnit_1;
				if (!Information.IsNothing(activeUnit_1))
				{
					this.int_2 = this.activeUnit_0.DBID;
					this.string_11 = this.activeUnit_0.string_0;
					this.string_12 = this.activeUnit_0.string_2;
					return;
				}
				this.string_11 = "";
			}

			// Token: 0x06001474 RID: 5236 RVA: 0x001829FC File Offset: 0x00180BFC
			public static List<Mission.Flight> smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, Scenario scenario_0)
			{
				List<Mission.Flight> result;
				try
				{
					List<Mission.Flight> list = new List<Mission.Flight>();
					try
					{
						foreach (object obj in xmlNode_0.ChildNodes)
						{
							XmlNode xmlNode = (XmlNode)obj;
							string name = xmlNode.Name;
							if (Operators.CompareString(name, "Flight", false) == 0)
							{
								Mission.Flight flight = new Mission.Flight();
								try
								{
									foreach (object obj2 in xmlNode.ChildNodes)
									{
										XmlNode xmlNode2 = (XmlNode)obj2;
										string name2 = xmlNode2.Name;
										uint num = Class582.smethod_0(name2);
										if (num <= 2107721701U)
										{
											if (num <= 868649010U)
											{
												if (num <= 549423346U)
												{
													if (num <= 66428795U)
													{
														if (num != 6222351U)
														{
															if (num == 66428795U)
															{
																if (Operators.CompareString(name2, "MinimumAircraftQty", false) == 0)
																{
																	flight._FlightSize_1 = (Mission._FlightSize)Conversions.ToByte(xmlNode2.InnerText);
																}
															}
														}
														else if (Operators.CompareString(name2, "Status", false) == 0)
														{
															flight.method_11(scenario_0, (Mission.Enum102)Conversions.ToByte(xmlNode2.InnerText));
														}
													}
													else if (num != 211111892U)
													{
														if (num != 436022125U)
														{
															if (num == 549423346U)
															{
																if (Operators.CompareString(name2, "LandingLocation_HostUnitObjectID", false) == 0)
																{
																	flight.string_7 = xmlNode2.InnerText;
																}
															}
														}
														else if (Operators.CompareString(name2, "TakeOffLocation_HostUnitObjectName", false) == 0)
														{
															flight.string_6 = xmlNode2.InnerText;
														}
													}
													else if (Operators.CompareString(name2, "TaskPool_Name", false) == 0)
													{
														flight.string_15 = xmlNode2.InnerText;
													}
												}
												else if (num <= 648502632U)
												{
													if (num != 600539979U)
													{
														if (num == 648502632U)
														{
															if (Operators.CompareString(name2, "LoadoutName", false) == 0)
															{
																flight.method_14(scenario_0, xmlNode2.InnerText);
															}
														}
													}
													else if (Operators.CompareString(name2, "UsedByFlight", false) == 0)
													{
														flight.bool_13 = Conversions.ToBoolean(xmlNode2.InnerText);
													}
												}
												else if (num != 709636896U)
												{
													if (num != 777311749U)
													{
														if (num == 868649010U)
														{
															if (Operators.CompareString(name2, "ReferenceUnit_Name", false) == 0)
															{
																flight.string_12 = xmlNode2.InnerText;
															}
														}
													}
													else if (Operators.CompareString(name2, "EditedBy", false) == 0)
													{
														flight.enum103_1 = (Mission.Enum103)Conversions.ToByte(xmlNode2.InnerText);
													}
												}
												else if (Operators.CompareString(name2, "LoadoutDBID", false) == 0)
												{
													flight.int_3 = Conversions.ToInteger(xmlNode2.InnerText);
												}
											}
											else if (num <= 1459831884U)
											{
												if (num <= 971413330U)
												{
													if (num != 897693746U)
													{
														if (num != 971413330U)
														{
															continue;
														}
														if (Operators.CompareString(name2, "NotificationList", false) != 0)
														{
															continue;
														}
														if (Information.IsNothing(flight.list_1))
														{
															flight.list_1 = new List<string>();
														}
														try
														{
															foreach (object obj3 in xmlNode2.ChildNodes)
															{
																string innerText = ((XmlNode)obj3).InnerText;
																flight.list_1.Add(innerText);
															}
															continue;
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
													if (Operators.CompareString(name2, "ParentMissionOrPackageObjectID", false) == 0)
													{
														flight.string_2 = xmlNode2.InnerText;
													}
												}
												else if (num != 1095917180U)
												{
													if (num != 1458105184U)
													{
														if (num == 1459831884U)
														{
															if (Operators.CompareString(name2, "PrimaryTarget_ID", false) == 0)
															{
																flight.string_20 = xmlNode2.InnerText;
															}
														}
													}
													else if (Operators.CompareString(name2, "ID", false) == 0)
													{
														flight.vmethod_0(xmlNode2.InnerText);
													}
												}
												else if (Operators.CompareString(name2, "LatestTaskingTime", false) == 0)
												{
													DateTime value = DateTime.FromBinary(Conversions.ToLong(xmlNode2.InnerText));
													flight.nullable_1 = new DateTime?(value);
												}
											}
											else if (num <= 1581646654U)
											{
												if (num != 1533607987U)
												{
													if (num == 1581646654U)
													{
														if (Operators.CompareString(name2, "EarliestTaskingTime", false) == 0)
														{
															DateTime value2 = DateTime.FromBinary(Conversions.ToLong(xmlNode2.InnerText));
															flight.nullable_0 = new DateTime?(value2);
														}
													}
												}
												else if (Operators.CompareString(name2, "AlternativeLandingLocation_HostUnitObjectID", false) == 0)
												{
													flight.string_9 = xmlNode2.InnerText;
												}
											}
											else if (num != 1902930894U)
											{
												if (num != 1995390348U)
												{
													if (num == 2107721701U)
													{
														if (Operators.CompareString(name2, "IsEscort", false) == 0)
														{
															flight.bool_12 = Conversions.ToBoolean(xmlNode2.InnerText);
														}
													}
												}
												else if (Operators.CompareString(name2, "Task", false) == 0)
												{
													flight._FlightTask_0 = (Mission._FlightTask)Conversions.ToByte(xmlNode2.InnerText);
												}
											}
											else if (Operators.CompareString(name2, "EarliestLaunchTime", false) == 0)
											{
												DateTime value3 = DateTime.FromBinary(Conversions.ToLong(xmlNode2.InnerText));
												flight.nullable_2 = new DateTime?(value3);
											}
										}
										else if (num <= 2788569304U)
										{
											if (num <= 2497091493U)
											{
												if (num <= 2379306221U)
												{
													if (num != 2220975494U)
													{
														if (num == 2379306221U)
														{
															if (Operators.CompareString(name2, "AlternativeLandingLocation_HostUnitObjectName", false) == 0)
															{
																flight.string_10 = xmlNode2.InnerText;
															}
														}
													}
													else if (Operators.CompareString(name2, "CreatedBy", false) == 0)
													{
														flight.enum103_0 = (Mission.Enum103)Conversions.ToByte(xmlNode2.InnerText);
													}
												}
												else if (num != 2395726140U)
												{
													if (num != 2457162696U)
													{
														if (num == 2497091493U)
														{
															if (Operators.CompareString(name2, "AssignedAircraftQty", false) == 0)
															{
																flight.int_0 = (int)Conversions.ToByte(xmlNode2.InnerText);
															}
														}
													}
													else if (Operators.CompareString(name2, "LatestLaunchTime", false) == 0)
													{
														DateTime value4 = DateTime.FromBinary(Conversions.ToLong(xmlNode2.InnerText));
														flight.nullable_3 = new DateTime?(value4);
													}
												}
												else if (Operators.CompareString(name2, "Age", false) == 0)
												{
													flight.int_4 = Conversions.ToInteger(xmlNode2.InnerText);
												}
											}
											else if (num <= 2747075645U)
											{
												if (num != 2645056075U)
												{
													if (num != 2747075645U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "ErrorList", false) != 0)
													{
														continue;
													}
													if (Information.IsNothing(flight.list_0))
													{
														flight.list_0 = new List<string>();
													}
													try
													{
														foreach (object obj4 in xmlNode2.ChildNodes)
														{
															string innerText2 = ((XmlNode)obj4).InnerText;
															flight.list_0.Add(innerText2);
														}
														continue;
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
												if (Operators.CompareString(name2, "ReferenceUnit_ObjectID", false) == 0)
												{
													flight.string_11 = xmlNode2.InnerText;
												}
											}
											else if (num != 2763503243U)
											{
												if (num != 2781397394U)
												{
													if (num == 2788569304U)
													{
														if (Operators.CompareString(name2, "Callsign", false) == 0)
														{
															flight.string_4 = xmlNode2.InnerText;
														}
													}
												}
												else if (Operators.CompareString(name2, "ReferenceUnit_DBID", false) == 0)
												{
													flight.int_2 = Conversions.ToInteger(xmlNode2.InnerText);
												}
											}
											else if (Operators.CompareString(name2, "ParentMissionOrPackageName", false) == 0)
											{
												flight.string_3 = xmlNode2.InnerText;
											}
										}
										else
										{
											if (num <= 3597454893U)
											{
												if (num <= 3404178554U)
												{
													if (num != 2889503411U)
													{
														if (num != 3404178554U)
														{
															continue;
														}
														if (Operators.CompareString(name2, "ReadyAircraftQty", false) == 0)
														{
															flight.int_1 = (int)Conversions.ToByte(xmlNode2.InnerText);
															continue;
														}
														continue;
													}
													else
													{
														if (Operators.CompareString(name2, "TakeOffLocation_HostUnitObjectID", false) == 0)
														{
															flight.string_5 = xmlNode2.InnerText;
															continue;
														}
														continue;
													}
												}
												else if (num != 3459419260U)
												{
													if (num != 3512062061U)
													{
														if (num != 3597454893U)
														{
															continue;
														}
														if (Operators.CompareString(name2, "DesiredAircraftQty", false) == 0)
														{
															flight._FlightSize_0 = (Mission._FlightSize)Conversions.ToByte(xmlNode2.InnerText);
															continue;
														}
														continue;
													}
													else
													{
														if (Operators.CompareString(name2, "Type", false) == 0)
														{
															flight.enum93_0 = (Mission.Enum93)Conversions.ToByte(xmlNode2.InnerText);
															continue;
														}
														continue;
													}
												}
												else
												{
													if (Operators.CompareString(name2, "FlightPlan", false) != 0)
													{
														continue;
													}
													try
													{
														foreach (object obj5 in xmlNode2.ChildNodes)
														{
															XmlNode xmlNode3 = (XmlNode)obj5;
															Waypoint waypoint = Waypoint.smethod_13(ref xmlNode3, ref dictionary_0, scenario_0);
															Mission.Flight flight2 = flight;
															Waypoint[] waypoint_ = flight2.method_15();
															Class429.smethod_36(ref waypoint_, waypoint);
															flight2.method_16(waypoint_);
														}
														continue;
													}
													finally
													{
														IEnumerator enumerator5;
														if (enumerator5 is IDisposable)
														{
															(enumerator5 as IDisposable).Dispose();
														}
													}
												}
											}
											if (num <= 3791178810U)
											{
												if (num != 3779853785U)
												{
													if (num == 3791178810U)
													{
														if (Operators.CompareString(name2, "TaskPool_ID", false) == 0)
														{
															flight.string_14 = xmlNode2.InnerText;
														}
													}
												}
												else if (Operators.CompareString(name2, "MaxReadyTime", false) == 0)
												{
													flight.float_0 = (float)Conversions.ToShort(xmlNode2.InnerText);
												}
											}
											else if (num != 3868041001U)
											{
												if (num != 3952356980U)
												{
													if (num == 3973949212U)
													{
														if (Operators.CompareString(name2, "LandingLocation_HostUnitObjectName", false) == 0)
														{
															flight.string_8 = xmlNode2.InnerText;
														}
													}
												}
												else if (Operators.CompareString(name2, "HasCriticalError", false) == 0)
												{
													flight.bool_11 = Conversions.ToBoolean(xmlNode2.InnerText);
												}
											}
											else if (Operators.CompareString(name2, "Priority", false) == 0)
											{
												flight.enum101_0 = (Mission.Enum101)Conversions.ToByte(xmlNode2.InnerText);
											}
										}
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
								list.Add(flight);
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
					result = list;
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
				return result;
			}

			// Token: 0x06001475 RID: 5237 RVA: 0x00183564 File Offset: 0x00181764
			public static void smethod_1(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0, ref List<Mission.Flight> list_2)
			{
				xmlWriter_0.WriteStartElement("FlightList");
				try
				{
					foreach (Mission.Flight flight in list_2)
					{
						xmlWriter_0.WriteStartElement("Flight");
						xmlWriter_0.WriteElementString("ID", flight.string_0);
						xmlWriter_0.WriteElementString("ParentMissionOrPackageObjectID", flight.string_2);
						xmlWriter_0.WriteElementString("ParentMissionOrPackageName", flight.string_3);
						xmlWriter_0.WriteElementString("Callsign", flight.string_4);
						xmlWriter_0.WriteElementString("Task", ((byte)flight._FlightTask_0).ToString());
						xmlWriter_0.WriteElementString("Type", ((byte)flight.enum93_0).ToString());
						xmlWriter_0.WriteElementString("TakeOffLocation_HostUnitObjectID", flight.string_5);
						xmlWriter_0.WriteElementString("TakeOffLocation_HostUnitObjectName", flight.string_6);
						xmlWriter_0.WriteElementString("LandingLocation_HostUnitObjectID", flight.string_7);
						xmlWriter_0.WriteElementString("LandingLocation_HostUnitObjectName", flight.string_8);
						xmlWriter_0.WriteElementString("AlternativeLandingLocation_HostUnitObjectID", flight.string_9);
						xmlWriter_0.WriteElementString("AlternativeLandingLocation_HostUnitObjectName", flight.string_10);
						if (flight.nullable_0 != null)
						{
							xmlWriter_0.WriteElementString("EarliestTaskingTime", flight.nullable_0.Value.ToBinary().ToString());
						}
						if (flight.nullable_1 != null)
						{
							xmlWriter_0.WriteElementString("LatestTaskingTime", flight.nullable_1.Value.ToBinary().ToString());
						}
						if (flight.nullable_2 != null)
						{
							xmlWriter_0.WriteElementString("EarliestLaunchTime", flight.nullable_2.Value.ToBinary().ToString());
						}
						if (flight.nullable_3 != null)
						{
							xmlWriter_0.WriteElementString("LatestLaunchTime", flight.nullable_3.Value.ToBinary().ToString());
						}
						xmlWriter_0.WriteElementString("MaxReadyTime", flight.float_0.ToString());
						XmlWriter xmlWriter = xmlWriter_0;
						string localName = "Priority";
						int num = (int)flight.enum101_0;
						xmlWriter.WriteElementString(localName, num.ToString());
						xmlWriter_0.WriteElementString("Status", ((int)flight.method_10(scenario_0)).ToString());
						XmlWriter xmlWriter2 = xmlWriter_0;
						string localName2 = "CreatedBy";
						num = (int)flight.enum103_0;
						xmlWriter2.WriteElementString(localName2, num.ToString());
						XmlWriter xmlWriter3 = xmlWriter_0;
						string localName3 = "EditedBy";
						num = (int)flight.enum103_1;
						xmlWriter3.WriteElementString(localName3, num.ToString());
						XmlWriter xmlWriter4 = xmlWriter_0;
						string localName4 = "DesiredAircraftQty";
						num = (int)flight._FlightSize_0;
						xmlWriter4.WriteElementString(localName4, num.ToString());
						XmlWriter xmlWriter5 = xmlWriter_0;
						string localName5 = "MinimumAircraftQty";
						num = (int)flight._FlightSize_1;
						xmlWriter5.WriteElementString(localName5, num.ToString());
						xmlWriter_0.WriteElementString("AssignedAircraftQty", flight.int_0.ToString());
						xmlWriter_0.WriteElementString("ReadyAircraftQty", flight.int_1.ToString());
						xmlWriter_0.WriteElementString("ReferenceUnit_DBID", flight.int_2.ToString());
						xmlWriter_0.WriteElementString("ReferenceUnit_ObjectID", flight.string_11);
						xmlWriter_0.WriteElementString("ReferenceUnit_Name", flight.string_12);
						xmlWriter_0.WriteElementString("LoadoutDBID", flight.int_3.ToString());
						xmlWriter_0.WriteElementString("LoadoutName", flight.method_13(scenario_0));
						xmlWriter_0.WriteElementString("UsedByFlight", flight.bool_13.ToString());
						xmlWriter_0.WriteElementString("IsEscort", flight.bool_12.ToString());
						if (!Information.IsNothing(flight.mission_0))
						{
							xmlWriter_0.WriteElementString("TaskPool_ID", flight.mission_0.string_0);
						}
						else
						{
							xmlWriter_0.WriteElementString("TaskPool_ID", flight.string_14);
						}
						if (!Information.IsNothing(flight.contact_0))
						{
							xmlWriter_0.WriteElementString("PrimaryTarget_ID", flight.contact_0.string_0);
						}
						else
						{
							xmlWriter_0.WriteElementString("PrimaryTarget_ID", flight.string_20);
						}
						xmlWriter_0.WriteElementString("TaskPool_Name", flight.string_15);
						xmlWriter_0.WriteElementString("Age", flight.int_4.ToString());
						if (!Information.IsNothing(flight.method_15()) && Enumerable.Count<Waypoint>(flight.method_15()) > 0)
						{
							xmlWriter_0.WriteStartElement("FlightPlan");
							List<Waypoint> list = new List<Waypoint>();
							list.AddRange(flight.method_15());
							try
							{
								foreach (Waypoint waypoint in list)
								{
									if (!Information.IsNothing(waypoint))
									{
										waypoint.method_19(ref xmlWriter_0, ref hashSet_0);
									}
								}
							}
							finally
							{
								List<Waypoint>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							xmlWriter_0.WriteEndElement();
						}
						if (!Information.IsNothing(flight.list_0) && flight.list_0.Count > 0)
						{
							xmlWriter_0.WriteStartElement("ErrorList");
							try
							{
								foreach (string value in flight.list_0)
								{
									xmlWriter_0.WriteElementString("Message", value);
								}
							}
							finally
							{
								List<string>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
							xmlWriter_0.WriteEndElement();
						}
						if (!Information.IsNothing(flight.list_1) && flight.list_1.Count > 0)
						{
							xmlWriter_0.WriteStartElement("NotificationList");
							try
							{
								foreach (string value2 in flight.list_1)
								{
									xmlWriter_0.WriteElementString("Message", value2);
								}
							}
							finally
							{
								List<string>.Enumerator enumerator4;
								((IDisposable)enumerator4).Dispose();
							}
							xmlWriter_0.WriteEndElement();
						}
						xmlWriter_0.WriteElementString("HasCriticalError", flight.bool_11.ToString());
						xmlWriter_0.WriteEndElement();
					}
				}
				finally
				{
					List<Mission.Flight>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				xmlWriter_0.WriteEndElement();
			}

			// Token: 0x06001476 RID: 5238 RVA: 0x00183B78 File Offset: 0x00181D78
			public static void smethod_2(ref Scenario scenario_0, ref Mission mission_1, ref DateTime? nullable_4, ref DateTime? nullable_5)
			{
				try
				{
					nullable_4 = null;
					nullable_5 = null;
					if (!Information.IsNothing(mission_1.method_29()))
					{
						nullable_4 = new DateTime?(mission_1.method_29().Value);
					}
					else if (!Information.IsNothing(mission_1.method_31()))
					{
						nullable_5 = new DateTime?(mission_1.method_31().Value);
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

			// Token: 0x06001477 RID: 5239 RVA: 0x00183C38 File Offset: 0x00181E38
			public static string smethod_3(ref Scenario scenario_0, ref Mission mission_1, Waypoint[] waypoint_5, bool bool_18, DateTime? nullable_4, DateTime? nullable_5)
			{
				string result;
				try
				{
					if (Enumerable.Count<Waypoint>(waypoint_5) == 0)
					{
						result = null;
					}
					else
					{
						if (!Information.IsNothing(nullable_4) || !Information.IsNothing(nullable_5))
						{
							bool flag = false;
							DateTime value;
							if (!Information.IsNothing(nullable_4))
							{
								value = nullable_4.Value;
								flag = true;
							}
							else if (!Information.IsNothing(nullable_5))
							{
								value = nullable_5.Value;
								flag = false;
							}
							if (mission_1._MissionClass_0 == Mission._MissionClass.Strike && ((Strike)mission_1).enum94_0 == Mission.Enum94.const_15 && !bool_18)
							{
								value = value.AddSeconds((double)((float)(((Strike)mission_1)._FlightSize_0 - Mission._FlightSize.SingleAircraft) * 10f));
							}
							int i = 0;
							while (i < waypoint_5.Length)
							{
								Waypoint waypoint = waypoint_5[i];
								Waypoint waypoint2;
								checked
								{
									if (flag && waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
									{
										waypoint2 = waypoint;
									}
									else
									{
										if (waypoint.waypointType_0 != Waypoint.WaypointType.Target)
										{
											if (waypoint.waypointType_0 != Waypoint.WaypointType.WeaponTarget)
											{
												if (!waypoint.method_40())
												{
													i++;
													continue;
												}
												waypoint2 = waypoint;
												break;
											}
										}
										waypoint2 = waypoint;
									}
									IL_102:;
								}
								if (!Information.IsNothing(waypoint2))
								{
									waypoint2.enum82_0 = Waypoint.Enum82.const_1;
									if (!float.IsNaN(waypoint2.float_6) && !float.IsInfinity(waypoint2.float_6) && waypoint2.float_6 > 0f)
									{
										waypoint2.nullable_7 = new DateTime?(value.AddSeconds((double)(-(double)waypoint2.float_6)));
										waypoint2.nullable_8 = new DateTime?(value);
									}
									else
									{
										waypoint2.nullable_7 = new DateTime?(value);
										waypoint2.nullable_8 = null;
									}
									return "OK";
								}
								if (flag)
								{
									return "Could not find the take-off waypoint, so could not set flightplan waypoint times.";
								}
								return "Could not find the target or station waypoint, so could not set flightplan waypoint times.";
							}
							goto IL_102;
						}
						result = "OK";
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200645", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = "Something went wrong.";
				}
				return result;
			}

			// Token: 0x06001478 RID: 5240 RVA: 0x00183E3C File Offset: 0x0018203C
			public static void smethod_4(ref DataTable dataTable_0)
			{
				if (!dataTable_0.Columns.Contains("ID"))
				{
					dataTable_0.Columns.Add("ID", typeof(int));
				}
				if (!dataTable_0.Columns.Contains("Description"))
				{
					dataTable_0.Columns.Add("Description", typeof(string));
				}
				dataTable_0.Rows.Add(new object[]
				{
					0,
					Mission.smethod_3(Mission._FlightTask.const_1)
				});
				dataTable_0.Rows.Add(new object[]
				{
					1,
					Mission.smethod_3(Mission._FlightTask.const_3)
				});
				dataTable_0.Rows.Add(new object[]
				{
					2,
					Mission.smethod_3(Mission._FlightTask.const_45)
				});
				dataTable_0.Rows.Add(new object[]
				{
					3,
					Mission.smethod_3(Mission._FlightTask.const_4)
				});
				dataTable_0.Rows.Add(new object[]
				{
					4,
					Mission.smethod_3(Mission._FlightTask.const_2)
				});
				dataTable_0.Rows.Add(new object[]
				{
					5,
					Mission.smethod_3(Mission._FlightTask.const_7)
				});
				dataTable_0.Rows.Add(new object[]
				{
					6,
					Mission.smethod_3(Mission._FlightTask.const_8)
				});
				dataTable_0.Rows.Add(new object[]
				{
					7,
					Mission.smethod_3(Mission._FlightTask.const_19)
				});
				dataTable_0.Rows.Add(new object[]
				{
					8,
					Mission.smethod_3(Mission._FlightTask.const_9)
				});
				dataTable_0.Rows.Add(new object[]
				{
					9,
					Mission.smethod_3(Mission._FlightTask.const_11)
				});
				dataTable_0.Rows.Add(new object[]
				{
					10,
					Mission.smethod_3(Mission._FlightTask.const_10)
				});
				dataTable_0.Rows.Add(new object[]
				{
					11,
					Mission.smethod_3(Mission._FlightTask.const_43)
				});
				dataTable_0.Rows.Add(new object[]
				{
					12,
					Mission.smethod_3(Mission._FlightTask.const_44)
				});
				dataTable_0.Rows.Add(new object[]
				{
					13,
					Mission.smethod_3(Mission._FlightTask.const_12)
				});
				dataTable_0.Rows.Add(new object[]
				{
					14,
					Mission.smethod_3(Mission._FlightTask.const_13)
				});
				dataTable_0.Rows.Add(new object[]
				{
					15,
					Mission.smethod_3(Mission._FlightTask.const_5)
				});
				dataTable_0.Rows.Add(new object[]
				{
					16,
					Mission.smethod_3(Mission._FlightTask.const_6)
				});
				dataTable_0.Rows.Add(new object[]
				{
					17,
					Mission.smethod_3(Mission._FlightTask.const_48)
				});
				dataTable_0.Rows.Add(new object[]
				{
					18,
					Mission.smethod_3(Mission._FlightTask.const_15)
				});
				dataTable_0.Rows.Add(new object[]
				{
					19,
					Mission.smethod_3(Mission._FlightTask.const_14)
				});
				dataTable_0.Rows.Add(new object[]
				{
					20,
					Mission.smethod_3(Mission._FlightTask.const_16)
				});
				dataTable_0.Rows.Add(new object[]
				{
					21,
					Mission.smethod_3(Mission._FlightTask.const_47)
				});
				dataTable_0.Rows.Add(new object[]
				{
					22,
					Mission.smethod_3(Mission._FlightTask.const_17)
				});
				dataTable_0.Rows.Add(new object[]
				{
					23,
					Mission.smethod_3(Mission._FlightTask.const_18)
				});
				dataTable_0.Rows.Add(new object[]
				{
					24,
					Mission.smethod_3(Mission._FlightTask.const_20)
				});
				dataTable_0.Rows.Add(new object[]
				{
					25,
					Mission.smethod_3(Mission._FlightTask.const_21)
				});
				dataTable_0.Rows.Add(new object[]
				{
					26,
					Mission.smethod_3(Mission._FlightTask.const_22)
				});
				dataTable_0.Rows.Add(new object[]
				{
					27,
					Mission.smethod_3(Mission._FlightTask.const_23)
				});
				dataTable_0.Rows.Add(new object[]
				{
					28,
					Mission.smethod_3(Mission._FlightTask.const_24)
				});
				dataTable_0.Rows.Add(new object[]
				{
					29,
					Mission.smethod_3(Mission._FlightTask.const_25)
				});
				dataTable_0.Rows.Add(new object[]
				{
					30,
					Mission.smethod_3(Mission._FlightTask.const_26)
				});
				dataTable_0.Rows.Add(new object[]
				{
					31,
					Mission.smethod_3(Mission._FlightTask.const_27)
				});
				dataTable_0.Rows.Add(new object[]
				{
					32,
					Mission.smethod_3(Mission._FlightTask.const_28)
				});
				dataTable_0.Rows.Add(new object[]
				{
					33,
					Mission.smethod_3(Mission._FlightTask.const_29)
				});
				dataTable_0.Rows.Add(new object[]
				{
					34,
					Mission.smethod_3(Mission._FlightTask.const_30)
				});
				dataTable_0.Rows.Add(new object[]
				{
					35,
					Mission.smethod_3(Mission._FlightTask.const_31)
				});
				dataTable_0.Rows.Add(new object[]
				{
					36,
					Mission.smethod_3(Mission._FlightTask.const_32)
				});
				dataTable_0.Rows.Add(new object[]
				{
					37,
					Mission.smethod_3(Mission._FlightTask.const_33)
				});
				dataTable_0.Rows.Add(new object[]
				{
					38,
					Mission.smethod_3(Mission._FlightTask.const_34)
				});
				dataTable_0.Rows.Add(new object[]
				{
					39,
					Mission.smethod_3(Mission._FlightTask.const_35)
				});
				dataTable_0.Rows.Add(new object[]
				{
					40,
					Mission.smethod_3(Mission._FlightTask.const_36)
				});
				dataTable_0.Rows.Add(new object[]
				{
					41,
					Mission.smethod_3(Mission._FlightTask.const_37)
				});
				dataTable_0.Rows.Add(new object[]
				{
					42,
					Mission.smethod_3(Mission._FlightTask.const_38)
				});
				dataTable_0.Rows.Add(new object[]
				{
					43,
					Mission.smethod_3(Mission._FlightTask.const_46)
				});
				dataTable_0.Rows.Add(new object[]
				{
					44,
					Mission.smethod_3(Mission._FlightTask.const_39)
				});
				dataTable_0.Rows.Add(new object[]
				{
					45,
					Mission.smethod_3(Mission._FlightTask.const_40)
				});
				dataTable_0.Rows.Add(new object[]
				{
					46,
					Mission.smethod_3(Mission._FlightTask.const_41)
				});
				dataTable_0.Rows.Add(new object[]
				{
					47,
					Mission.smethod_3(Mission._FlightTask.const_42)
				});
			}

			// Token: 0x06001479 RID: 5241 RVA: 0x001845E8 File Offset: 0x001827E8
			public static Mission._FlightTask smethod_5(int int_5)
			{
				Mission._FlightTask result;
				try
				{
					switch (int_5)
					{
					case 0:
						result = Mission._FlightTask.const_1;
						break;
					case 1:
						result = Mission._FlightTask.const_3;
						break;
					case 2:
						result = Mission._FlightTask.const_45;
						break;
					case 3:
						result = Mission._FlightTask.const_4;
						break;
					case 4:
						result = Mission._FlightTask.const_2;
						break;
					case 5:
						result = Mission._FlightTask.const_7;
						break;
					case 6:
						result = Mission._FlightTask.const_8;
						break;
					case 7:
						result = Mission._FlightTask.const_19;
						break;
					case 8:
						result = Mission._FlightTask.const_9;
						break;
					case 9:
						result = Mission._FlightTask.const_11;
						break;
					case 10:
						result = Mission._FlightTask.const_10;
						break;
					case 11:
						result = Mission._FlightTask.const_43;
						break;
					case 12:
						result = Mission._FlightTask.const_44;
						break;
					case 13:
						result = Mission._FlightTask.const_12;
						break;
					case 14:
						result = Mission._FlightTask.const_13;
						break;
					case 15:
						result = Mission._FlightTask.const_5;
						break;
					case 16:
						result = Mission._FlightTask.const_6;
						break;
					case 17:
						result = Mission._FlightTask.const_48;
						break;
					case 18:
						result = Mission._FlightTask.const_15;
						break;
					case 19:
						result = Mission._FlightTask.const_14;
						break;
					case 20:
						result = Mission._FlightTask.const_16;
						break;
					case 21:
						result = Mission._FlightTask.const_47;
						break;
					case 22:
						result = Mission._FlightTask.const_17;
						break;
					case 23:
						result = Mission._FlightTask.const_18;
						break;
					case 24:
						result = Mission._FlightTask.const_20;
						break;
					case 25:
						result = Mission._FlightTask.const_21;
						break;
					case 26:
						result = Mission._FlightTask.const_22;
						break;
					case 27:
						result = Mission._FlightTask.const_23;
						break;
					case 28:
						result = Mission._FlightTask.const_24;
						break;
					case 29:
						result = Mission._FlightTask.const_25;
						break;
					case 30:
						result = Mission._FlightTask.const_26;
						break;
					case 31:
						result = Mission._FlightTask.const_27;
						break;
					case 32:
						result = Mission._FlightTask.const_28;
						break;
					case 33:
						result = Mission._FlightTask.const_29;
						break;
					case 34:
						result = Mission._FlightTask.const_30;
						break;
					case 35:
						result = Mission._FlightTask.const_31;
						break;
					case 36:
						result = Mission._FlightTask.const_32;
						break;
					case 37:
						result = Mission._FlightTask.const_33;
						break;
					case 38:
						result = Mission._FlightTask.const_34;
						break;
					case 39:
						result = Mission._FlightTask.const_35;
						break;
					case 40:
						result = Mission._FlightTask.const_36;
						break;
					case 41:
						result = Mission._FlightTask.const_37;
						break;
					case 42:
						result = Mission._FlightTask.const_38;
						break;
					case 43:
						result = Mission._FlightTask.const_46;
						break;
					case 44:
						result = Mission._FlightTask.const_39;
						break;
					case 45:
						result = Mission._FlightTask.const_40;
						break;
					case 46:
						result = Mission._FlightTask.const_41;
						break;
					case 47:
						result = Mission._FlightTask.const_42;
						break;
					default:
						result = Mission._FlightTask.const_0;
						break;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101297", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				return result;
			}

			// Token: 0x0600147A RID: 5242 RVA: 0x00184864 File Offset: 0x00182A64
			public static int smethod_6(int int_5)
			{
				int result;
				try
				{
					switch (int_5)
					{
					case 1:
						return 0;
					case 2:
						return 4;
					case 3:
						return 1;
					case 4:
						return 3;
					case 5:
						return 15;
					case 6:
						return 16;
					case 7:
						return 5;
					case 8:
						return 6;
					case 9:
						return 8;
					case 10:
						return 10;
					case 11:
						return 9;
					case 12:
						return 13;
					case 13:
						return 14;
					case 14:
						return 19;
					case 15:
						return 18;
					case 16:
						return 20;
					case 17:
						return 22;
					case 18:
						return 23;
					case 19:
						return 7;
					case 20:
						return 24;
					case 21:
						return 25;
					case 22:
						return 26;
					case 23:
						return 27;
					case 24:
						return 28;
					case 25:
						return 29;
					case 26:
						return 30;
					case 27:
						return 31;
					case 28:
						return 32;
					case 29:
						return 33;
					case 30:
						return 34;
					case 31:
						return 35;
					case 32:
						return 36;
					case 33:
						return 37;
					case 34:
						return 38;
					case 35:
						return 39;
					case 36:
						return 40;
					case 37:
						return 41;
					case 38:
						return 42;
					case 39:
						return 44;
					case 40:
						return 45;
					case 41:
						return 46;
					case 42:
						return 47;
					case 44:
						return 11;
					case 45:
						return 12;
					case 46:
						return 2;
					case 47:
						return 43;
					case 48:
						return 21;
					case 49:
						return 17;
					}
					result = 0;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101307", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				return result;
			}

			// Token: 0x0600147B RID: 5243 RVA: 0x00184AE8 File Offset: 0x00182CE8
			public static void smethod_7(ref DataTable dataTable_0)
			{
				if (!dataTable_0.Columns.Contains("ID"))
				{
					dataTable_0.Columns.Add("ID", typeof(int));
				}
				if (!dataTable_0.Columns.Contains("Description"))
				{
					dataTable_0.Columns.Add("Description", typeof(string));
				}
				dataTable_0.Rows.Add(new object[]
				{
					0,
					Mission.smethod_4(Mission.Enum101.const_1)
				});
				dataTable_0.Rows.Add(new object[]
				{
					1,
					Mission.smethod_4(Mission.Enum101.const_0)
				});
			}

			// Token: 0x0600147C RID: 5244 RVA: 0x00184BA0 File Offset: 0x00182DA0
			public static Mission.Enum101 smethod_8(int int_5)
			{
				Mission.Enum101 result;
				try
				{
					if (int_5 != 0)
					{
						if (int_5 != 1)
						{
							result = Mission.Enum101.const_0;
						}
						else
						{
							result = Mission.Enum101.const_0;
						}
					}
					else
					{
						result = Mission.Enum101.const_1;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101298", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = Mission.Enum101.const_0;
				}
				return result;
			}

			// Token: 0x0600147D RID: 5245 RVA: 0x00184C0C File Offset: 0x00182E0C
			public static int smethod_9(int int_5)
			{
				int result;
				try
				{
					if (int_5 != 0)
					{
						if (int_5 == 1)
						{
							result = 0;
						}
						else
						{
							result = 1;
						}
					}
					else
					{
						result = 1;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101308", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = 0;
				}
				return result;
			}

			// Token: 0x0600147E RID: 5246 RVA: 0x00184C78 File Offset: 0x00182E78
			public static void smethod_10(ref int int_5, ref Mission.Enum94 enum94_0)
			{
				switch (int_5)
				{
				case 0:
					enum94_0 = Mission.Enum94.const_1;
					return;
				case 1:
					enum94_0 = Mission.Enum94.const_2;
					return;
				case 2:
					enum94_0 = Mission.Enum94.const_3;
					return;
				case 3:
					enum94_0 = Mission.Enum94.const_4;
					return;
				default:
					enum94_0 = Mission.Enum94.const_1;
					return;
				}
			}

			// Token: 0x0600147F RID: 5247 RVA: 0x00184CB4 File Offset: 0x00182EB4
			public static void smethod_11(ref DataTable dataTable_0)
			{
				if (!dataTable_0.Columns.Contains("ID"))
				{
					dataTable_0.Columns.Add("ID", typeof(int));
				}
				if (!dataTable_0.Columns.Contains("Description"))
				{
					dataTable_0.Columns.Add("Description", typeof(string));
				}
				dataTable_0.Rows.Add(new object[]
				{
					0,
					Mission.smethod_1(Mission._FlightSize.SingleAircraft)
				});
				dataTable_0.Rows.Add(new object[]
				{
					1,
					Mission.smethod_1(Mission._FlightSize.TwoAircraft)
				});
				dataTable_0.Rows.Add(new object[]
				{
					2,
					Mission.smethod_1(Mission._FlightSize.ThreeAircraft)
				});
				dataTable_0.Rows.Add(new object[]
				{
					3,
					Mission.smethod_1(Mission._FlightSize.FourAircraft)
				});
				dataTable_0.Rows.Add(new object[]
				{
					4,
					Mission.smethod_1(Mission._FlightSize.SixAircraft)
				});
			}

			// Token: 0x06001480 RID: 5248 RVA: 0x00184DD8 File Offset: 0x00182FD8
			public static Mission._FlightSize smethod_12(int int_5)
			{
				Mission._FlightSize result;
				try
				{
					switch (int_5)
					{
					case 0:
						result = Mission._FlightSize.SingleAircraft;
						break;
					case 1:
						result = Mission._FlightSize.TwoAircraft;
						break;
					case 2:
						result = Mission._FlightSize.ThreeAircraft;
						break;
					case 3:
						result = Mission._FlightSize.FourAircraft;
						break;
					case 4:
						result = Mission._FlightSize.SixAircraft;
						break;
					default:
						result = Mission._FlightSize.SingleAircraft;
						break;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101299", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = Mission._FlightSize.None;
				}
				return result;
			}

			// Token: 0x06001481 RID: 5249 RVA: 0x00184E64 File Offset: 0x00183064
			public static int smethod_13(int int_5)
			{
				int result;
				try
				{
					switch (int_5)
					{
					case 1:
						return 0;
					case 2:
						return 1;
					case 3:
						return 2;
					case 4:
						return 3;
					case 6:
						return 4;
					}
					result = 0;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101310", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = 0;
				}
				return result;
			}

			// Token: 0x06001482 RID: 5250 RVA: 0x00184EF8 File Offset: 0x001830F8
			public static void smethod_14(ref DataTable dataTable_0)
			{
				if (!dataTable_0.Columns.Contains("ID"))
				{
					dataTable_0.Columns.Add("ID", typeof(int));
				}
				if (!dataTable_0.Columns.Contains("Description"))
				{
					dataTable_0.Columns.Add("Description", typeof(string));
				}
				dataTable_0.Rows.Add(new object[]
				{
					0,
					Mission.smethod_9(Mission.Enum93.const_0)
				});
				dataTable_0.Rows.Add(new object[]
				{
					1,
					Mission.smethod_9(Mission.Enum93.const_1)
				});
			}

			// Token: 0x06001483 RID: 5251 RVA: 0x00184FB0 File Offset: 0x001831B0
			public static Mission.Enum93 smethod_15(int int_5)
			{
				Mission.Enum93 result;
				try
				{
					if (int_5 != 0)
					{
						if (int_5 != 1)
						{
							result = Mission.Enum93.const_0;
						}
						else
						{
							result = Mission.Enum93.const_1;
						}
					}
					else
					{
						result = Mission.Enum93.const_0;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101297", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = Mission.Enum93.const_0;
				}
				return result;
			}

			// Token: 0x06001484 RID: 5252 RVA: 0x0018501C File Offset: 0x0018321C
			public static int smethod_16(int int_5)
			{
				int result;
				try
				{
					if (int_5 != 0)
					{
						if (int_5 != 1)
						{
							result = 0;
						}
						else
						{
							result = 1;
						}
					}
					else
					{
						result = 0;
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
					result = 0;
				}
				return result;
			}

			// Token: 0x04000FE4 RID: 4068
			public string string_2;

			// Token: 0x04000FE5 RID: 4069
			public string string_3;

			// Token: 0x04000FE6 RID: 4070
			public string string_4;

			// Token: 0x04000FE7 RID: 4071
			public Mission._FlightTask _FlightTask_0;

			// Token: 0x04000FE8 RID: 4072
			public Mission.Enum93 enum93_0;

			// Token: 0x04000FE9 RID: 4073
			public string string_5;

			// Token: 0x04000FEA RID: 4074
			public string string_6;

			// Token: 0x04000FEB RID: 4075
			public string string_7;

			// Token: 0x04000FEC RID: 4076
			public string string_8;

			// Token: 0x04000FED RID: 4077
			public string string_9;

			// Token: 0x04000FEE RID: 4078
			public string string_10;

			// Token: 0x04000FEF RID: 4079
			public List<string> list_0;

			// Token: 0x04000FF0 RID: 4080
			public List<string> list_1;

			// Token: 0x04000FF1 RID: 4081
			public bool bool_11;

			// Token: 0x04000FF2 RID: 4082
			public DateTime? nullable_0;

			// Token: 0x04000FF3 RID: 4083
			public DateTime? nullable_1;

			// Token: 0x04000FF4 RID: 4084
			public float float_0;

			// Token: 0x04000FF5 RID: 4085
			public DateTime? nullable_2;

			// Token: 0x04000FF6 RID: 4086
			public DateTime? nullable_3;

			// Token: 0x04000FF7 RID: 4087
			public bool bool_12;

			// Token: 0x04000FF8 RID: 4088
			public Mission.Enum101 enum101_0;

			// Token: 0x04000FF9 RID: 4089
			private Mission.Enum102 enum102_0;

			// Token: 0x04000FFA RID: 4090
			public Mission.Enum103 enum103_0;

			// Token: 0x04000FFB RID: 4091
			public Mission.Enum103 enum103_1;

			// Token: 0x04000FFC RID: 4092
			public Mission._FlightSize _FlightSize_0;

			// Token: 0x04000FFD RID: 4093
			public Mission._FlightSize _FlightSize_1;

			// Token: 0x04000FFE RID: 4094
			public int int_0;

			// Token: 0x04000FFF RID: 4095
			public int int_1;

			// Token: 0x04001000 RID: 4096
			public bool bool_13;

			// Token: 0x04001001 RID: 4097
			private ActiveUnit activeUnit_0;

			// Token: 0x04001002 RID: 4098
			public int int_2;

			// Token: 0x04001003 RID: 4099
			public string string_11;

			// Token: 0x04001004 RID: 4100
			public string string_12;

			// Token: 0x04001005 RID: 4101
			public int int_3;

			// Token: 0x04001006 RID: 4102
			private string string_13;

			// Token: 0x04001007 RID: 4103
			protected Waypoint[] waypoint_0;

			// Token: 0x04001008 RID: 4104
			protected Waypoint[] waypoint_1;

			// Token: 0x04001009 RID: 4105
			protected Waypoint[] waypoint_2;

			// Token: 0x0400100A RID: 4106
			protected Waypoint[] waypoint_3;

			// Token: 0x0400100B RID: 4107
			protected Waypoint[] waypoint_4;

			// Token: 0x0400100C RID: 4108
			public Mission mission_0;

			// Token: 0x0400100D RID: 4109
			public string string_14;

			// Token: 0x0400100E RID: 4110
			public string string_15;

			// Token: 0x0400100F RID: 4111
			public string string_16;

			// Token: 0x04001010 RID: 4112
			public string string_17;

			// Token: 0x04001011 RID: 4113
			public string string_18;

			// Token: 0x04001012 RID: 4114
			public string string_19;

			// Token: 0x04001013 RID: 4115
			public Waypoint.Enum82 enum82_0;

			// Token: 0x04001014 RID: 4116
			public Waypoint.Enum82 enum82_1;

			// Token: 0x04001015 RID: 4117
			public int int_4;

			// Token: 0x04001016 RID: 4118
			public Contact contact_0;

			// Token: 0x04001017 RID: 4119
			public string string_20;

			// Token: 0x04001018 RID: 4120
			public bool bool_14;

			// Token: 0x04001019 RID: 4121
			public bool bool_15;

			// Token: 0x0400101A RID: 4122
			public bool bool_16;

			// Token: 0x0400101B RID: 4123
			public bool bool_17;

			// Token: 0x0400101C RID: 4124
			public string string_21;

			// Token: 0x020002B1 RID: 689
			internal enum Enum106 : byte
			{
				// Token: 0x0400101E RID: 4126
				const_0,
				// Token: 0x0400101F RID: 4127
				const_1,
				// Token: 0x04001020 RID: 4128
				const_2,
				// Token: 0x04001021 RID: 4129
				const_3,
				// Token: 0x04001022 RID: 4130
				const_4,
				// Token: 0x04001023 RID: 4131
				const_5,
				// Token: 0x04001024 RID: 4132
				const_6
			}
		}

		// Token: 0x020002B2 RID: 690
		internal sealed class Class286
		{
			// Token: 0x06001485 RID: 5253 RVA: 0x0000B36E File Offset: 0x0000956E
			public Class286(string string_4, string string_5, int int_2, string string_6, int int_3, string string_7)
			{
				this.string_0 = string_4;
				this.string_1 = string_5;
				this.int_0 = int_2;
				this.string_2 = string_6;
				this.int_1 = int_3;
				this.string_3 = string_7;
			}

			// Token: 0x04001025 RID: 4133
			public string string_0;

			// Token: 0x04001026 RID: 4134
			public string string_1;

			// Token: 0x04001027 RID: 4135
			public int int_0;

			// Token: 0x04001028 RID: 4136
			public string string_2;

			// Token: 0x04001029 RID: 4137
			public int int_1;

			// Token: 0x0400102A RID: 4138
			public string string_3;
		}

		// Token: 0x020002B3 RID: 691
		internal sealed class Class287
		{
			// Token: 0x06001486 RID: 5254 RVA: 0x0000B3A3 File Offset: 0x000095A3
			public Class287(string string_3, int int_2, int int_3, string string_4, DateTime? nullable_2, DateTime? nullable_3, string string_5)
			{
				this.string_0 = string_3;
				this.int_0 = int_2;
				this.int_1 = int_3;
				this.string_1 = string_4;
				this.nullable_0 = nullable_2;
				this.nullable_1 = nullable_3;
				this.string_2 = string_5;
			}

			// Token: 0x06001487 RID: 5255 RVA: 0x00002977 File Offset: 0x00000B77
			public Class287()
			{
			}

			// Token: 0x06001488 RID: 5256 RVA: 0x00185088 File Offset: 0x00183288
			public static void smethod_0(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0, ref List<Mission.Class287> list_0)
			{
				try
				{
					try
					{
						foreach (Mission.Class287 @class in list_0)
						{
							xmlWriter_0.WriteStartElement("CCS");
							xmlWriter_0.WriteElementString("FlightObjectID", @class.string_0);
							xmlWriter_0.WriteElementString("AircraftDBID", @class.int_0.ToString());
							xmlWriter_0.WriteElementString("LoadoutDBID", @class.int_1.ToString());
							xmlWriter_0.WriteElementString("HostUnitObjectID", @class.string_1);
							if (@class.nullable_0 != null)
							{
								xmlWriter_0.WriteElementString("StationStartTime", @class.nullable_0.Value.ToBinary().ToString());
							}
							if (@class.nullable_1 != null)
							{
								xmlWriter_0.WriteElementString("StationEndTime", @class.nullable_1.Value.ToBinary().ToString());
							}
							xmlWriter_0.WriteElementString("FlightplanTemplateObjectID", @class.string_2);
							xmlWriter_0.WriteEndElement();
						}
					}
					finally
					{
						List<Mission.Class287>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
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

			// Token: 0x06001489 RID: 5257 RVA: 0x00185214 File Offset: 0x00183414
			public static List<Mission.Class287> smethod_1(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, Scenario scenario_0)
			{
				List<Mission.Class287> result;
				try
				{
					List<Mission.Class287> list = new List<Mission.Class287>();
					try
					{
						foreach (object obj in xmlNode_0.ChildNodes)
						{
							XmlNode xmlNode = (XmlNode)obj;
							string name = xmlNode.Name;
							if (Operators.CompareString(name, "CCS", false) == 0)
							{
								Mission.Class287 @class = new Mission.Class287();
								try
								{
									foreach (object obj2 in xmlNode.ChildNodes)
									{
										XmlNode xmlNode2 = (XmlNode)obj2;
										string name2 = xmlNode2.Name;
										uint num = Class582.smethod_0(name2);
										if (num <= 709636896U)
										{
											if (num != 364500985U)
											{
												if (num != 577202053U)
												{
													if (num == 709636896U)
													{
														if (Operators.CompareString(name2, "LoadoutDBID", false) == 0)
														{
															@class.int_1 = Conversions.ToInteger(xmlNode2.InnerText);
														}
													}
												}
												else if (Operators.CompareString(name2, "FlightObjectID", false) == 0)
												{
													@class.string_0 = xmlNode2.InnerText;
												}
											}
											else if (Operators.CompareString(name2, "StationEndTime", false) == 0)
											{
												DateTime value = DateTime.FromBinary(Conversions.ToLong(xmlNode2.InnerText));
												@class.nullable_1 = new DateTime?(value);
											}
										}
										else if (num <= 2562882560U)
										{
											if (num != 2075003704U)
											{
												if (num == 2562882560U)
												{
													if (Operators.CompareString(name2, "FlightplanTemplateObjectID", false) == 0)
													{
														@class.string_2 = xmlNode2.InnerText;
													}
												}
											}
											else if (Operators.CompareString(name2, "StationStartTime", false) == 0)
											{
												DateTime value2 = DateTime.FromBinary(Conversions.ToLong(xmlNode2.InnerText));
												@class.nullable_0 = new DateTime?(value2);
											}
										}
										else if (num != 2773676336U)
										{
											if (num == 3296419567U)
											{
												if (Operators.CompareString(name2, "HostUnitObjectID", false) == 0)
												{
													@class.string_1 = xmlNode2.InnerText;
												}
											}
										}
										else if (Operators.CompareString(name2, "AircraftDBID", false) == 0)
										{
											@class.int_0 = Conversions.ToInteger(xmlNode2.InnerText);
										}
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
								list.Add(@class);
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
					result = list;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 999999", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<Mission.Class287>();
				}
				return result;
			}

			// Token: 0x0400102B RID: 4139
			public string string_0;

			// Token: 0x0400102C RID: 4140
			public int int_0;

			// Token: 0x0400102D RID: 4141
			public int int_1;

			// Token: 0x0400102E RID: 4142
			public string string_1;

			// Token: 0x0400102F RID: 4143
			public DateTime? nullable_0;

			// Token: 0x04001030 RID: 4144
			public DateTime? nullable_1;

			// Token: 0x04001031 RID: 4145
			public string string_2;
		}

		// Token: 0x020002B4 RID: 692
		public sealed class EmptyAircraftSlot
		{
			// Token: 0x0600148A RID: 5258 RVA: 0x0000B3E0 File Offset: 0x000095E0
			public EmptyAircraftSlot()
			{
				this.bool_0 = false;
			}

			// Token: 0x0600148B RID: 5259 RVA: 0x001854F4 File Offset: 0x001836F4
			public EmptyAircraftSlot(ActiveUnit activeUnit_2, int int_5, string string_5, int int_6, string string_6, ref ActiveUnit activeUnit_3, string string_7, string string_8, bool bool_3)
			{
				this.bool_0 = false;
				this.activeUnit_0 = activeUnit_2;
				this.int_0 = int_5;
				this.string_0 = string_5;
				this.int_1 = int_6;
				this.string_1 = string_6;
				this.bool_2 = bool_3;
				this.activeUnit_1 = activeUnit_3;
				this.string_3 = string_7;
				this.string_4 = string_8;
			}

			// Token: 0x0600148C RID: 5260 RVA: 0x0000B3EF File Offset: 0x000095EF
			public void method_0()
			{
				this.activeUnit_0 = null;
				this.flight_0 = null;
				this.activeUnit_1 = null;
			}

			// Token: 0x0600148D RID: 5261 RVA: 0x00185554 File Offset: 0x00183754
			public ActiveUnit method_1(Scenario scenario_0, Mission mission_0)
			{
				if (Information.IsNothing(this.activeUnit_0) && this.int_0 > 0)
				{
					try
					{
						foreach (ActiveUnit activeUnit in scenario_0.vmethod_0().Values)
						{
							if (activeUnit.bool_3 && activeUnit.DBID == this.int_0)
							{
								Aircraft aircraft = (Aircraft)activeUnit;
								if (!Information.IsNothing(aircraft.method_167()) && aircraft.method_167().DBID == this.int_1 && !Information.IsNothing(aircraft.method_164().method_30()) && (Information.IsNothing(this.activeUnit_1) || aircraft.method_164().method_30() == this.activeUnit_1) && !Information.IsNothing(activeUnit.vmethod_103()) && activeUnit.vmethod_103() == mission_0)
								{
									this.activeUnit_0 = activeUnit;
									break;
								}
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
				return this.activeUnit_0;
			}

			// Token: 0x0600148E RID: 5262 RVA: 0x0000B406 File Offset: 0x00009606
			public void method_2(Scenario scenario_0, Mission mission_0, ActiveUnit activeUnit_2)
			{
				this.activeUnit_0 = activeUnit_2;
				if (!Information.IsNothing(activeUnit_2))
				{
					this.int_0 = this.activeUnit_0.DBID;
					this.string_0 = this.activeUnit_0.string_2;
				}
			}

			// Token: 0x0600148F RID: 5263 RVA: 0x00185658 File Offset: 0x00183858
			public ActiveUnit method_3(Scenario scenario_0)
			{
				if (Information.IsNothing(this.activeUnit_1) && !string.IsNullOrEmpty(this.string_3))
				{
					try
					{
						foreach (ActiveUnit activeUnit in scenario_0.vmethod_0().Values)
						{
							if (Operators.CompareString(activeUnit.string_0, this.string_3, false) == 0)
							{
								this.activeUnit_1 = activeUnit;
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
				return this.activeUnit_1;
			}

			// Token: 0x06001490 RID: 5264 RVA: 0x0000B439 File Offset: 0x00009639
			public void method_4(Scenario scenario_0, ActiveUnit activeUnit_2)
			{
				this.activeUnit_1 = activeUnit_2;
			}

			// Token: 0x06001491 RID: 5265 RVA: 0x001856E0 File Offset: 0x001838E0
			public Mission.Flight method_5(Scenario scenario_0)
			{
				checked
				{
					if (Information.IsNothing(this.flight_0) && !string.IsNullOrEmpty(this.string_2))
					{
						bool flag = false;
						Side[] array = scenario_0.method_44();
						int i = 0;
						while (i < array.Length)
						{
							Side side = array[i];
							try
							{
								foreach (Mission mission in side.method_35())
								{
									if (mission.method_54())
									{
										try
										{
											foreach (Mission.Flight flight in mission.list_1)
											{
												if (Operators.CompareString(flight.string_0, this.string_2, false) == 0)
												{
													this.flight_0 = flight;
													flag = true;
													break;
												}
											}
										}
										finally
										{
											List<Mission.Flight>.Enumerator enumerator2;
											((IDisposable)enumerator2).Dispose();
										}
									}
									if (flag)
									{
										break;
									}
								}
								goto IL_D1;
							}
							finally
							{
								IEnumerator<Mission> enumerator;
								if (enumerator != null)
								{
									enumerator.Dispose();
								}
							}
							IL_C8:
							i++;
							continue;
							IL_D1:
							if (flag)
							{
								break;
							}
							goto IL_C8;
						}
					}
					return this.flight_0;
				}
			}

			// Token: 0x06001492 RID: 5266 RVA: 0x0000B442 File Offset: 0x00009642
			public void method_6(Scenario scenario_0, Mission.Flight flight_1)
			{
				this.flight_0 = flight_1;
				if (!Information.IsNothing(flight_1))
				{
					this.string_2 = this.flight_0.string_0;
				}
			}

			// Token: 0x06001493 RID: 5267 RVA: 0x001857E4 File Offset: 0x001839E4
			public static void smethod_0(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0, ref List<Mission.EmptyAircraftSlot> list_0)
			{
				try
				{
					xmlWriter_0.WriteStartElement("EmptySlotsList");
					try
					{
						foreach (Mission.EmptyAircraftSlot emptyAircraftSlot in list_0)
						{
							xmlWriter_0.WriteStartElement("EmptySlot");
							xmlWriter_0.WriteElementString("DBID", emptyAircraftSlot.int_0.ToString());
							if (!Information.IsNothing(emptyAircraftSlot.string_0))
							{
								xmlWriter_0.WriteElementString("UnitClass", emptyAircraftSlot.string_0.ToString());
							}
							else
							{
								xmlWriter_0.WriteElementString("UnitClass", "Any type");
							}
							xmlWriter_0.WriteElementString("LoadoutDBID", emptyAircraftSlot.int_1.ToString());
							xmlWriter_0.WriteElementString("LoadoutName", emptyAircraftSlot.string_1.ToString());
							xmlWriter_0.WriteElementString("Loadout_ExcludeOptionalWeapons", emptyAircraftSlot.bool_0.ToString());
							xmlWriter_0.WriteElementString("Loadout_QuickTurnaround", emptyAircraftSlot.bool_1.ToString());
							xmlWriter_0.WriteElementString("Loadout_QuickTurnaround_NumberOfSorties", emptyAircraftSlot.int_2.ToString());
							xmlWriter_0.WriteElementString("Loadout_QuickTurnaround_MaxSorties", emptyAircraftSlot.int_3.ToString());
							xmlWriter_0.WriteElementString("CurrentHostUnit_ObjectID", emptyAircraftSlot.string_3.ToString());
							xmlWriter_0.WriteElementString("CurrentHostUnit_Name", emptyAircraftSlot.string_4.ToString());
							xmlWriter_0.WriteElementString("IsEscort", emptyAircraftSlot.bool_2.ToString());
							if (!string.IsNullOrEmpty(emptyAircraftSlot.string_2))
							{
								xmlWriter_0.WriteElementString("MissionFlight_ObjectID", emptyAircraftSlot.string_2.ToString());
							}
							xmlWriter_0.WriteEndElement();
						}
					}
					finally
					{
						List<Mission.EmptyAircraftSlot>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					xmlWriter_0.WriteEndElement();
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200646", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}

			// Token: 0x06001494 RID: 5268 RVA: 0x001859F8 File Offset: 0x00183BF8
			public static List<Mission.EmptyAircraftSlot> smethod_1(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, Scenario scenario_0)
			{
				List<Mission.EmptyAircraftSlot> result;
				try
				{
					List<Mission.EmptyAircraftSlot> list = new List<Mission.EmptyAircraftSlot>();
					try
					{
						foreach (object obj in xmlNode_0.ChildNodes)
						{
							XmlNode xmlNode = (XmlNode)obj;
							string name = xmlNode.Name;
							if (Operators.CompareString(name, "EmptySlot", false) == 0)
							{
								Mission.EmptyAircraftSlot emptyAircraftSlot = new Mission.EmptyAircraftSlot();
								try
								{
									foreach (object obj2 in xmlNode.ChildNodes)
									{
										XmlNode xmlNode2 = (XmlNode)obj2;
										string name2 = xmlNode2.Name;
										uint num = Class582.smethod_0(name2);
										if (num <= 1848783177U)
										{
											if (num <= 772711297U)
											{
												if (num != 648502632U)
												{
													if (num != 709636896U)
													{
														if (num == 772711297U)
														{
															if (Operators.CompareString(name2, "CurrentHostUnit_ObjectID", false) == 0)
															{
																emptyAircraftSlot.string_3 = xmlNode2.InnerText;
															}
														}
													}
													else if (Operators.CompareString(name2, "LoadoutDBID", false) == 0)
													{
														emptyAircraftSlot.int_1 = Conversions.ToInteger(xmlNode2.InnerText);
													}
												}
												else if (Operators.CompareString(name2, "LoadoutName", false) == 0)
												{
													emptyAircraftSlot.string_1 = xmlNode2.InnerText;
												}
											}
											else if (num != 1275478188U)
											{
												if (num != 1535121917U)
												{
													if (num == 1848783177U)
													{
														if (Operators.CompareString(name2, "UnitClass", false) == 0)
														{
															emptyAircraftSlot.string_0 = xmlNode2.InnerText;
														}
													}
												}
												else if (Operators.CompareString(name2, "Loadout_QuickTurnaround_NumberOfSorties", false) == 0)
												{
													emptyAircraftSlot.int_2 = Conversions.ToInteger(xmlNode2.InnerText);
												}
											}
											else if (Operators.CompareString(name2, "CurrentHostUnit_Name", false) == 0)
											{
												emptyAircraftSlot.string_4 = xmlNode2.InnerText;
											}
										}
										else if (num <= 2275586905U)
										{
											if (num != 2107721701U)
											{
												if (num != 2187602126U)
												{
													if (num == 2275586905U)
													{
														if (Operators.CompareString(name2, "Loadout_QuickTurnaround", false) == 0)
														{
															emptyAircraftSlot.bool_1 = Conversions.ToBoolean(xmlNode2.InnerText);
														}
													}
												}
												else if (Operators.CompareString(name2, "DBID", false) == 0)
												{
													emptyAircraftSlot.int_0 = Conversions.ToInteger(xmlNode2.InnerText);
												}
											}
											else if (Operators.CompareString(name2, "IsEscort", false) == 0)
											{
												emptyAircraftSlot.bool_2 = Conversions.ToBoolean(xmlNode2.InnerText);
											}
										}
										else if (num != 3678242795U)
										{
											if (num != 3767094375U)
											{
												if (num == 4045740866U)
												{
													if (Operators.CompareString(name2, "MissionFlight_ObjectID", false) == 0)
													{
														emptyAircraftSlot.string_2 = xmlNode2.InnerText;
													}
												}
											}
											else if (Operators.CompareString(name2, "Loadout_ExcludeOptionalWeapons", false) == 0)
											{
												emptyAircraftSlot.bool_0 = Conversions.ToBoolean(xmlNode2.InnerText);
											}
										}
										else if (Operators.CompareString(name2, "Loadout_QuickTurnaround_MaxSorties", false) == 0)
										{
											emptyAircraftSlot.int_3 = Conversions.ToInteger(xmlNode2.InnerText);
										}
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
								list.Add(emptyAircraftSlot);
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
					result = list;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200647", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<Mission.EmptyAircraftSlot>();
				}
				return result;
			}

			// Token: 0x06001495 RID: 5269 RVA: 0x0000B464 File Offset: 0x00009664
			public void method_7(Scenario scenario_0, Mission.Flight flight_1, int int_5)
			{
				this.method_6(scenario_0, flight_1);
			}

			// Token: 0x04001032 RID: 4146
			private ActiveUnit activeUnit_0;

			// Token: 0x04001033 RID: 4147
			public int int_0;

			// Token: 0x04001034 RID: 4148
			public string string_0;

			// Token: 0x04001035 RID: 4149
			public int int_1;

			// Token: 0x04001036 RID: 4150
			public string string_1;

			// Token: 0x04001037 RID: 4151
			public bool bool_0;

			// Token: 0x04001038 RID: 4152
			public bool bool_1;

			// Token: 0x04001039 RID: 4153
			public int int_2;

			// Token: 0x0400103A RID: 4154
			public int int_3;

			// Token: 0x0400103B RID: 4155
			private Mission.Flight flight_0;

			// Token: 0x0400103C RID: 4156
			public string string_2;

			// Token: 0x0400103D RID: 4157
			private ActiveUnit activeUnit_1;

			// Token: 0x0400103E RID: 4158
			public string string_3;

			// Token: 0x0400103F RID: 4159
			public string string_4;

			// Token: 0x04001040 RID: 4160
			public int int_4;

			// Token: 0x04001041 RID: 4161
			public bool bool_2;
		}

		// Token: 0x020002B5 RID: 693
		internal sealed class Class288
		{
			// Token: 0x06001496 RID: 5270 RVA: 0x00002977 File Offset: 0x00000B77
			public Class288()
			{
			}

			// Token: 0x06001497 RID: 5271 RVA: 0x00185DC4 File Offset: 0x00183FC4
			public Class288(string string_4, int int_2, string string_5, string string_6, string string_7, int int_3, double double_2, double double_3, GeoPoint geoPoint_1, GeoPoint geoPoint_2, List<GeoPoint> list_1)
			{
				this.string_0 = string_4;
				this.int_0 = int_2;
				this.string_1 = string_5;
				this.string_2 = string_6;
				this.string_3 = string_7;
				this.int_1 = int_3;
				this.double_0 = double_2;
				this.double_1 = double_3;
				this.geoPoint_0 = geoPoint_1;
				this.list_0 = list_1;
			}

			// Token: 0x06001498 RID: 5272 RVA: 0x00185E24 File Offset: 0x00184024
			public static void smethod_0(ref XmlWriter xmlWriter_0, ref Mission.Class288 class288_0)
			{
				try
				{
					xmlWriter_0.WriteStartElement("TargeteeringEntry");
					xmlWriter_0.WriteElementString("ID", class288_0.string_0.ToString());
					xmlWriter_0.WriteElementString("Target_Type", class288_0.int_0.ToString());
					xmlWriter_0.WriteElementString("Target_Description", class288_0.string_1.ToString());
					xmlWriter_0.WriteElementString("Target_ContactObjectID", class288_0.string_2.ToString());
					xmlWriter_0.WriteElementString("Target_ActualUnitObjectID", class288_0.string_3.ToString());
					xmlWriter_0.WriteElementString("Target_ActualUnitDBID", class288_0.int_1.ToString());
					xmlWriter_0.WriteElementString("Target_Latitude", class288_0.double_0.ToString());
					xmlWriter_0.WriteElementString("Target_Longitude", class288_0.double_1.ToString());
					xmlWriter_0.WriteEndElement();
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

			// Token: 0x06001499 RID: 5273 RVA: 0x00185F4C File Offset: 0x0018414C
			public static Mission.Class288 smethod_1(ref XmlNode xmlNode_0)
			{
				Mission.Class288 result;
				try
				{
					Mission.Class288 @class = new Mission.Class288();
					try
					{
						foreach (object obj in xmlNode_0.ChildNodes)
						{
							XmlNode xmlNode = (XmlNode)obj;
							string name = xmlNode.Name;
							uint num = Class582.smethod_0(name);
							if (num <= 1458105184U)
							{
								if (num <= 593664221U)
								{
									if (num != 579374325U)
									{
										if (num == 593664221U)
										{
											if (Operators.CompareString(name, "Target_Type", false) == 0)
											{
												@class.int_0 = Conversions.ToInteger(xmlNode.InnerText);
											}
										}
									}
									else if (Operators.CompareString(name, "Target_ContactObjectID", false) == 0)
									{
										@class.string_2 = xmlNode.InnerText;
									}
								}
								else if (num != 989487253U)
								{
									if (num == 1458105184U)
									{
										if (Operators.CompareString(name, "ID", false) == 0)
										{
											@class.string_0 = xmlNode.InnerText;
										}
									}
								}
								else if (Operators.CompareString(name, "Target_Latitude", false) == 0)
								{
									@class.double_0 = Conversions.ToDouble(xmlNode.InnerText);
								}
							}
							else if (num <= 3112103319U)
							{
								if (num != 2337219470U)
								{
									if (num == 3112103319U)
									{
										if (Operators.CompareString(name, "Target_ActualUnitObjectID", false) == 0)
										{
											@class.string_3 = xmlNode.InnerText;
										}
									}
								}
								else if (Operators.CompareString(name, "Target_ActualUnitDBID", false) == 0)
								{
									@class.int_1 = Conversions.ToInteger(xmlNode.InnerText);
								}
							}
							else if (num != 3267862046U)
							{
								if (num == 3823980409U)
								{
									if (Operators.CompareString(name, "Target_Description", false) == 0)
									{
										@class.string_1 = xmlNode.InnerText;
									}
								}
							}
							else if (Operators.CompareString(name, "Target_Longitude", false) == 0)
							{
								@class.double_1 = Conversions.ToDouble(xmlNode.InnerText);
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
					result = @class;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 999999", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = null;
				}
				return result;
			}

			// Token: 0x04001042 RID: 4162
			public string string_0;

			// Token: 0x04001043 RID: 4163
			public int int_0;

			// Token: 0x04001044 RID: 4164
			public string string_1;

			// Token: 0x04001045 RID: 4165
			public string string_2;

			// Token: 0x04001046 RID: 4166
			public string string_3;

			// Token: 0x04001047 RID: 4167
			public int int_1;

			// Token: 0x04001048 RID: 4168
			public double double_0;

			// Token: 0x04001049 RID: 4169
			public double double_1;

			// Token: 0x0400104A RID: 4170
			public GeoPoint geoPoint_0;

			// Token: 0x0400104B RID: 4171
			public List<GeoPoint> list_0;
		}

		// Token: 0x020002B6 RID: 694
		internal sealed class Class289
		{
			// Token: 0x0600149A RID: 5274 RVA: 0x0000B46E File Offset: 0x0000966E
			public Class289()
			{
				this.bool_1 = false;
			}

			// Token: 0x0600149B RID: 5275 RVA: 0x001861B0 File Offset: 0x001843B0
			public Class289(int int_5, Weapon._WeaponType _WeaponType_1, string string_2, float float_2, float float_3, bool bool_2, string string_3, int int_6, int int_7, int int_8, int int_9, ref Waypoint[] waypoint_1)
			{
				this.bool_1 = false;
				this.int_0 = int_5;
				this._WeaponType_0 = _WeaponType_1;
				this.string_0 = string_2;
				this.float_0 = float_2;
				this.float_1 = float_3;
				this.bool_0 = bool_2;
				this.string_1 = string_3;
				this.int_1 = int_6;
				this.int_2 = int_7;
				this.int_3 = int_8;
				this.int_4 = int_9;
				this.waypoint_0 = waypoint_1;
			}

			// Token: 0x0600149C RID: 5276 RVA: 0x00186228 File Offset: 0x00184428
			public static void smethod_0(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Mission.Class289 class289_0)
			{
				try
				{
					xmlWriter_0.WriteStartElement("WeaponeeringEntry");
					xmlWriter_0.WriteElementString("WeaponDBID", class289_0.int_0.ToString());
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "WeaponType";
					int weaponType_ = (int)class289_0._WeaponType_0;
					xmlWriter.WriteElementString(localName, weaponType_.ToString());
					xmlWriter_0.WriteElementString("WeaponName", class289_0.string_0.ToString());
					xmlWriter_0.WriteElementString("WeaponMaxRange", class289_0.float_0.ToString());
					xmlWriter_0.WriteElementString("WeaponMinRange", class289_0.float_1.ToString());
					xmlWriter_0.WriteElementString("WeaponIsBOLCapable", class289_0.bool_0.ToString());
					xmlWriter_0.WriteElementString("TargeteeringEntryObjectID", class289_0.string_1.ToString());
					xmlWriter_0.WriteElementString("LostTarget", class289_0.int_1.ToString());
					xmlWriter_0.WriteElementString("WeaponQty", class289_0.int_2.ToString());
					xmlWriter_0.WriteElementString("WeaponMaxQty", class289_0.int_3.ToString());
					xmlWriter_0.WriteElementString("FiringRange", class289_0.int_4.ToString());
					xmlWriter_0.WriteElementString("IsRouteReference", class289_0.bool_1.ToString());
					if (!Information.IsNothing(class289_0.waypoint_0) && Enumerable.Count<Waypoint>(class289_0.waypoint_0) > 0)
					{
						xmlWriter_0.WriteStartElement("Route");
						List<Waypoint> list = new List<Waypoint>();
						list.AddRange(class289_0.waypoint_0);
						try
						{
							foreach (Waypoint waypoint in list)
							{
								if (!Information.IsNothing(waypoint))
								{
									waypoint.method_19(ref xmlWriter_0, ref hashSet_0);
								}
							}
						}
						finally
						{
							List<Waypoint>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteEndElement();
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

			// Token: 0x0600149D RID: 5277 RVA: 0x00186464 File Offset: 0x00184664
			public static Mission.Class289 smethod_1(ref XmlNode xmlNode_0, ref Scenario scenario_0, ref Dictionary<string, Class310> dictionary_0)
			{
				Mission.Class289 result;
				try
				{
					Mission.Class289 @class = new Mission.Class289();
					try
					{
						foreach (object obj in xmlNode_0.ChildNodes)
						{
							XmlNode xmlNode = (XmlNode)obj;
							string name = xmlNode.Name;
							uint num = Class582.smethod_0(name);
							if (num <= 2451006171U)
							{
								if (num <= 1722209463U)
								{
									if (num != 1262517171U)
									{
										if (num != 1627332560U)
										{
											if (num == 1722209463U)
											{
												if (Operators.CompareString(name, "FiringRange", false) == 0)
												{
													@class.int_4 = Conversions.ToInteger(xmlNode.InnerText);
												}
											}
										}
										else if (Operators.CompareString(name, "WeaponMinRange", false) == 0)
										{
											@class.float_1 = (float)Conversions.ToInteger(xmlNode.InnerText);
										}
									}
									else if (Operators.CompareString(name, "WeaponMaxQty", false) == 0)
									{
										@class.int_3 = Conversions.ToInteger(xmlNode.InnerText);
									}
								}
								else if (num != 1773543567U)
								{
									if (num != 1878684297U)
									{
										if (num == 2451006171U)
										{
											if (Operators.CompareString(name, "IsRouteReference", false) == 0)
											{
												@class.bool_1 = Conversions.ToBoolean(xmlNode.InnerText);
											}
										}
									}
									else if (Operators.CompareString(name, "WeaponType", false) == 0)
									{
										@class._WeaponType_0 = (Weapon._WeaponType)Conversions.ToShort(xmlNode.InnerText);
									}
								}
								else if (Operators.CompareString(name, "WeaponQty", false) == 0)
								{
									@class.int_2 = Conversions.ToInteger(xmlNode.InnerText);
								}
							}
							else if (num <= 3158151354U)
							{
								if (num != 2635420018U)
								{
									if (num != 2660991866U)
									{
										if (num == 3158151354U)
										{
											if (Operators.CompareString(name, "WeaponName", false) == 0)
											{
												@class.string_0 = xmlNode.InnerText;
											}
										}
									}
									else if (Operators.CompareString(name, "TargeteeringEntryObjectID", false) == 0)
									{
										@class.string_1 = xmlNode.InnerText;
									}
								}
								else if (Operators.CompareString(name, "WeaponMaxRange", false) == 0)
								{
									@class.float_0 = (float)Conversions.ToInteger(xmlNode.InnerText);
								}
							}
							else if (num <= 3621138622U)
							{
								if (num != 3611682378U)
								{
									if (num != 3621138622U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Route", false) != 0)
									{
										continue;
									}
									@class.waypoint_0 = new Waypoint[0];
									try
									{
										foreach (object obj2 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode2 = (XmlNode)obj2;
											Waypoint waypoint_ = Waypoint.smethod_13(ref xmlNode2, ref dictionary_0, scenario_0);
											Class429.smethod_36(ref @class.waypoint_0, waypoint_);
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
								if (Operators.CompareString(name, "WeaponDBID", false) == 0)
								{
									@class.int_0 = Conversions.ToInteger(xmlNode.InnerText);
								}
							}
							else if (num != 3760900574U)
							{
								if (num == 3789685630U)
								{
									if (Operators.CompareString(name, "WeaponIsBOLCapable", false) == 0)
									{
										@class.bool_0 = Conversions.ToBoolean(xmlNode.InnerText);
									}
								}
							}
							else if (Operators.CompareString(name, "LostTarget", false) == 0)
							{
								@class.int_1 = Conversions.ToInteger(xmlNode.InnerText);
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
					result = @class;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 999999", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = null;
				}
				return result;
			}

			// Token: 0x0400104C RID: 4172
			public int int_0;

			// Token: 0x0400104D RID: 4173
			public Weapon._WeaponType _WeaponType_0;

			// Token: 0x0400104E RID: 4174
			public string string_0;

			// Token: 0x0400104F RID: 4175
			public float float_0;

			// Token: 0x04001050 RID: 4176
			public float float_1;

			// Token: 0x04001051 RID: 4177
			public bool bool_0;

			// Token: 0x04001052 RID: 4178
			public string string_1;

			// Token: 0x04001053 RID: 4179
			public int int_1;

			// Token: 0x04001054 RID: 4180
			public int int_2;

			// Token: 0x04001055 RID: 4181
			public int int_3;

			// Token: 0x04001056 RID: 4182
			public int int_4;

			// Token: 0x04001057 RID: 4183
			public Waypoint[] waypoint_0;

			// Token: 0x04001058 RID: 4184
			public bool bool_1;
		}

		// Token: 0x020002B7 RID: 695
		[CompilerGenerated]
		internal sealed class Class290
		{
			// Token: 0x0600149E RID: 5278 RVA: 0x0000B47D File Offset: 0x0000967D
			public Class290(Mission.Class290 class290_0)
			{
				if (class290_0 != null)
				{
					this.scenario_0 = class290_0.scenario_0;
				}
			}

			// Token: 0x0600149F RID: 5279 RVA: 0x0018684C File Offset: 0x00184A4C
			internal bool method_0(Mission.EmptyAircraftSlot emptyAircraftSlot_0)
			{
				return emptyAircraftSlot_0.bool_2 && !Information.IsNothing(emptyAircraftSlot_0.method_5(this.scenario_0)) && !Information.IsNothing(emptyAircraftSlot_0.method_5(this.scenario_0).method_15()) && Enumerable.Count<Waypoint>(emptyAircraftSlot_0.method_5(this.scenario_0).method_15()) == 0;
			}

			// Token: 0x060014A0 RID: 5280 RVA: 0x0000B494 File Offset: 0x00009694
			internal string method_1(Mission.EmptyAircraftSlot emptyAircraftSlot_0)
			{
				return emptyAircraftSlot_0.method_5(this.scenario_0).string_4;
			}

			// Token: 0x060014A1 RID: 5281 RVA: 0x001868A8 File Offset: 0x00184AA8
			internal bool method_2(Mission.EmptyAircraftSlot emptyAircraftSlot_0)
			{
				return !Information.IsNothing(emptyAircraftSlot_0.method_5(this.scenario_0)) && !Information.IsNothing(emptyAircraftSlot_0.method_5(this.scenario_0).method_15()) && Enumerable.Count<Waypoint>(emptyAircraftSlot_0.method_5(this.scenario_0).method_15()) > 0;
			}

			// Token: 0x060014A2 RID: 5282 RVA: 0x0000B4A7 File Offset: 0x000096A7
			internal DateTime? method_3(Mission.EmptyAircraftSlot emptyAircraftSlot_0)
			{
				return emptyAircraftSlot_0.method_5(this.scenario_0).method_15()[0].nullable_7;
			}

			// Token: 0x060014A3 RID: 5283 RVA: 0x0000B494 File Offset: 0x00009694
			internal string method_4(Mission.EmptyAircraftSlot emptyAircraftSlot_0)
			{
				return emptyAircraftSlot_0.method_5(this.scenario_0).string_4;
			}

			// Token: 0x060014A4 RID: 5284 RVA: 0x001868FC File Offset: 0x00184AFC
			internal bool method_5(Mission.EmptyAircraftSlot emptyAircraftSlot_0)
			{
				return !emptyAircraftSlot_0.bool_2 && !Information.IsNothing(emptyAircraftSlot_0.method_5(this.scenario_0)) && !Information.IsNothing(emptyAircraftSlot_0.method_5(this.scenario_0).method_15()) && Enumerable.Count<Waypoint>(emptyAircraftSlot_0.method_5(this.scenario_0).method_15()) == 0;
			}

			// Token: 0x04001059 RID: 4185
			public Scenario scenario_0;
		}
	}
}
