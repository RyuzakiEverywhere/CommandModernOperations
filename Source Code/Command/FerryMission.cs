using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns14;

namespace Command_Core
{
	// Token: 0x02000290 RID: 656
	public sealed class FerryMission : Mission
	{
		// Token: 0x060013F8 RID: 5112 RVA: 0x00179570 File Offset: 0x00177770
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("FerryMission");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				xmlWriter_0.WriteElementString("Name", this.Name);
				xmlWriter_0.WriteElementString("Category", ((byte)this.enum88_0).ToString());
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "Behavior";
				byte tankerMethod_ = (byte)this.ferryMissionBehavior_0;
				xmlWriter.WriteElementString(localName, tankerMethod_.ToString());
				this.doctrine_0.method_282(ref xmlWriter_0, ref scenario_0, "Doctrine");
				if (this.nullable_0 != null)
				{
					xmlWriter_0.WriteElementString("START", this.nullable_0.Value.ToBinary().ToString());
				}
				if (this.nullable_1 != null)
				{
					xmlWriter_0.WriteElementString("END", this.nullable_1.Value.ToBinary().ToString());
				}
				if (this.nullable_2 != null)
				{
					xmlWriter_0.WriteElementString("TakeOffTime", this.nullable_2.Value.ToBinary().ToString());
				}
				if (this.nullable_3 != null)
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
				xmlWriter_0.WriteElementString("NDH", this.string_3);
				if (base.method_10(scenario_0) != Mission.Enum89.const_0)
				{
					xmlWriter_0.WriteElementString("Status", ((byte)base.method_10(scenario_0)).ToString());
				}
				if (this.nullable_4 != null)
				{
					xmlWriter_0.WriteElementString("FerryThrottle_Aircraft", Conversions.ToString((int)this.nullable_4.Value));
				}
				if (this.nullable_5 != null)
				{
					xmlWriter_0.WriteElementString("FerryAltitude_Aircraft", this.nullable_5.Value.ToString());
				}
				xmlWriter_0.WriteElementString("FerryTerrainFollowing_Aircraft", this.bool_22.ToString());
				if (this.nullable_6 != null)
				{
					xmlWriter_0.WriteElementString("FerryThrottle_Ship", Conversions.ToString((int)this.nullable_6.Value));
				}
				if (this.nullable_7 != null)
				{
					xmlWriter_0.WriteElementString("FerryThrottle_Submarine", Conversions.ToString((int)this.nullable_7.Value));
				}
				if (this.nullable_8 != null)
				{
					xmlWriter_0.WriteElementString("FerryAltitude_Submarine", this.nullable_8.Value.ToString());
				}
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "FlightSize";
				int num = (int)this._FlightSize_0;
				xmlWriter2.WriteElementString(localName2, num.ToString());
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = "Formation_Cruise";
				num = (int)this.enum91_0;
				xmlWriter3.WriteElementString(localName3, num.ToString());
				XmlWriter xmlWriter4 = xmlWriter_0;
				string localName4 = "MinAircraftReq";
				num = (int)this._FlightQty_0;
				xmlWriter4.WriteElementString(localName4, num.ToString());
				xmlWriter_0.WriteElementString("UseFlightSizeHardLimit", this.bool_12.ToString());
				XmlWriter xmlWriter5 = xmlWriter_0;
				string localName5 = "TankerUsage";
				tankerMethod_ = (byte)this.tankerMethod_0;
				xmlWriter5.WriteElementString(localName5, tankerMethod_.ToString());
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
				if (base.method_54())
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
				ex.Data.Add("Error at 100633", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0000B243 File Offset: 0x00009443
		private FerryMission(Side side_0, Scenario scenario_0) : base(side_0, scenario_0)
		{
			this.bool_9 = true;
			this._MissionClass_0 = Mission._MissionClass.Ferry;
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00179AE0 File Offset: 0x00177CE0
		public static FerryMission smethod_10(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, Scenario scenario_0)
		{
			FerryMission result;
			try
			{
				FerryMission ferryMission = new FerryMission(null, scenario_0);
				bool flag = false;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num > 1864098670U)
						{
							if (num <= 2667312101U)
							{
								if (num <= 2284267453U)
								{
									if (num <= 2045435587U)
									{
										if (num != 1908276361U)
										{
											if (num != 2045435587U)
											{
												continue;
											}
											if (Operators.CompareString(name, "FerryThrottle", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "CheckBox_OrderRTB", false) == 0)
											{
												ferryMission.bool_20 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num != 2180604875U)
									{
										if (num != 2233408560U)
										{
											if (num != 2284267453U)
											{
												continue;
											}
											if (Operators.CompareString(name, "FerryAltitude", false) != 0)
											{
												continue;
											}
											goto IL_8B2;
										}
										else
										{
											if (Operators.CompareString(name, "Deactivation_UnassignUnits", false) == 0)
											{
												ferryMission.bool_19 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "FlightList", false) == 0)
										{
											ferryMission.list_1 = Mission.Flight.smethod_0(ref xmlNode, ref dictionary_0, scenario_0);
											continue;
										}
										continue;
									}
								}
								else if (num <= 2388336606U)
								{
									if (num != 2344440002U)
									{
										if (num != 2367170728U)
										{
											if (num != 2388336606U)
											{
												continue;
											}
											if (Operators.CompareString(name, "FerryThrottle_Ship", false) == 0)
											{
												ferryMission.nullable_6 = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "FuelQtyToStartLookingForTanker_Airborne", false) == 0)
											{
												ferryMission.int_5 = Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (Operators.CompareString(name, "FerryThrottle_Aircraft", false) != 0)
									{
										continue;
									}
								}
								else if (num != 2435049132U)
								{
									if (num != 2487526210U)
									{
										if (num != 2667312101U)
										{
											continue;
										}
										if (Operators.CompareString(name, "UseFlightSizeHardLimit", false) == 0)
										{
											ferryMission.bool_12 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "FlightSize", false) == 0)
										{
											ferryMission._FlightSize_0 = (Mission._FlightSize)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "TankerMissionList", false) == 0)
									{
										try
										{
											foreach (object obj2 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode2 = (XmlNode)obj2;
												ferryMission.list_3.Add(xmlNode2.InnerText);
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
										goto IL_7C4;
									}
									continue;
								}
								ferryMission.nullable_4 = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
								continue;
							}
							IL_7C4:
							if (num <= 3718927628U)
							{
								if (num <= 3107456787U)
								{
									if (num != 2940441098U)
									{
										if (num != 2947802513U)
										{
											if (num != 3107456787U)
											{
												continue;
											}
											if (Operators.CompareString(name, "NominalDestinationHost", false) == 0)
											{
												goto IL_80E;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Category", false) == 0)
											{
												ferryMission.enum88_0 = (Mission.Enum88)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "END", false) == 0)
										{
											DateTime value = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
											ferryMission.nullable_1 = new DateTime?(value);
											continue;
										}
										continue;
									}
								}
								else if (num != 3322127180U)
								{
									if (num != 3591985774U)
									{
										if (num != 3718927628U)
										{
											continue;
										}
										if (Operators.CompareString(name, "FerryAltitude_Aircraft", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "StartTime", false) != 0)
										{
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "CheckBox_DeleteMission", false) == 0)
									{
										ferryMission.bool_21 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 3838663019U)
							{
								if (num != 3749943133U)
								{
									if (num != 3802618614U)
									{
										if (num != 3838663019U)
										{
											continue;
										}
										if (Operators.CompareString(name, "MinAircraftReq", false) == 0)
										{
											ferryMission._FlightQty_0 = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TankerFollowsReceivers", false) == 0)
										{
											ferryMission.bool_18 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "TankerUsage", false) == 0)
									{
										ferryMission.tankerMethod_0 = (Mission.TankerMethod)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 3905033942U)
							{
								if (num != 4100651282U)
								{
									if (num != 4129161940U)
									{
										continue;
									}
									if (Operators.CompareString(name, "FerryThrottle_Submarine", false) == 0)
									{
										ferryMission.nullable_7 = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "MaxReceiversInQueuePerTanker_Airborne", false) == 0)
									{
										ferryMission.int_4 = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Formation_Cruise", false) == 0)
								{
									ferryMission.enum91_0 = (Mission.Enum91)Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							IL_8B2:
							ferryMission.nullable_5 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
							continue;
						}
						if (num <= 985231712U)
						{
							if (num <= 444307777U)
							{
								if (num <= 227845695U)
								{
									if (num != 6222351U)
									{
										if (num != 227845695U)
										{
											continue;
										}
										if (Operators.CompareString(name, "START", false) == 0)
										{
											DateTime value2 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
											ferryMission.nullable_0 = new DateTime?(value2);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Status", false) == 0)
										{
											ferryMission.method_11(scenario_0, (Mission.Enum89)Conversions.ToByte(xmlNode.InnerText));
											continue;
										}
										continue;
									}
								}
								else if (num != 266367750U)
								{
									if (num != 302524802U)
									{
										if (num != 444307777U)
										{
											continue;
										}
										if (Operators.CompareString(name, "UseFlightplan", false) == 0)
										{
											ferryMission.bool_14 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "IncludeInATO", false) == 0)
										{
											ferryMission.bool_16 = Conversions.ToBoolean(xmlNode.InnerText);
											flag = true;
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "Name", false) == 0)
									{
										ferryMission.Name = xmlNode.InnerText;
										continue;
									}
									continue;
								}
							}
							else if (num <= 620569374U)
							{
								if (num != 461095311U)
								{
									if (num != 521774151U)
									{
										if (num != 620569374U)
										{
											continue;
										}
										if (Operators.CompareString(name, "TankerMinNumber_Airborne", false) == 0)
										{
											ferryMission.int_2 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Behavior", false) == 0)
										{
											ferryMission.ferryMissionBehavior_0 = (FerryMission.FerryMissionBehavior)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "SISIH", false) == 0)
									{
										ferryMission.bool_11 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 721363522U)
							{
								if (num != 882301358U)
								{
									if (num != 985231712U)
									{
										continue;
									}
									if (Operators.CompareString(name, "UseFlightplansOnly", false) == 0)
									{
										ferryMission.bool_15 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "LaunchMissionWithoutTankersInPlace", false) == 0)
									{
										ferryMission.bool_17 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "TankerMaxDistance_Airborne", false) == 0)
								{
									ferryMission.int_6 = Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 1458105184U)
						{
							if (num <= 1062263555U)
							{
								if (num != 1025497782U)
								{
									if (num != 1062263555U)
									{
										continue;
									}
									if (Operators.CompareString(name, "EmptySlotsList", false) == 0)
									{
										ferryMission.list_2 = Mission.EmptyAircraftSlot.smethod_1(ref xmlNode, ref dictionary_0, scenario_0);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TankerMinNumber_Total", false) == 0)
									{
										ferryMission.int_1 = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 1074512784U)
							{
								if (num != 1422437055U)
								{
									if (num != 1458105184U)
									{
										continue;
									}
									if (Operators.CompareString(name, "ID", false) != 0)
									{
										continue;
									}
									if (!dictionary_0.ContainsKey(xmlNode.InnerText))
									{
										ferryMission.vmethod_0(xmlNode.InnerText);
										dictionary_0.Add(ferryMission.string_0, ferryMission);
										continue;
									}
									return (FerryMission)dictionary_0[xmlNode.InnerText];
								}
								else
								{
									if (Operators.CompareString(name, "Doctrine", false) == 0)
									{
										ferryMission.doctrine_0 = Doctrine.smethod_9(ref xmlNode, ferryMission);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "TimeOnTarget", false) == 0)
								{
									DateTime value3 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
									ferryMission.method_32(new DateTime?(value3));
									continue;
								}
								continue;
							}
						}
						else if (num <= 1631693882U)
						{
							if (num != 1507328069U)
							{
								if (num != 1579537194U)
								{
									if (num != 1631693882U)
									{
										continue;
									}
									if (Operators.CompareString(name, "FerryAltitude_Submarine", false) == 0)
									{
										ferryMission.nullable_8 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TakeOffTime", false) == 0)
									{
										DateTime value4 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
										ferryMission.method_30(new DateTime?(value4));
										continue;
									}
									continue;
								}
							}
							else if (Operators.CompareString(name, "NDH", false) != 0)
							{
								continue;
							}
						}
						else if (num != 1688531320U)
						{
							if (num != 1795334850U)
							{
								if (num != 1864098670U)
								{
									continue;
								}
								if (Operators.CompareString(name, "FerryTerrainFollowing_Aircraft", false) == 0)
								{
									ferryMission.bool_22 = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "ST", false) != 0)
								{
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "TankerMinNumber_Station", false) == 0)
							{
								ferryMission.int_3 = Conversions.ToInteger(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						IL_80E:
						ferryMission.string_3 = xmlNode.InnerText;
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
				ActiveUnit.Throttle? throttle = ferryMission.nullable_4;
				byte? b = (throttle != null) ? new byte?((byte)throttle.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					ferryMission.nullable_4 = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
				}
				if (ferryMission.doctrine_0.method_159())
				{
					ferryMission.doctrine_0.method_158(scenario_0, false, false, false, false, new Doctrine.Enum57?(Doctrine.Enum57.const_2));
				}
				if (!flag)
				{
					ferryMission.bool_16 = false;
				}
				result = ferryMission;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100634", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new FerryMission(null, scenario_0);
			}
			return result;
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0000B25B File Offset: 0x0000945B
		public FerryMission.FerryMissionBehavior method_65()
		{
			return this.ferryMissionBehavior_0;
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x0000B263 File Offset: 0x00009463
		public void method_66(FerryMission.FerryMissionBehavior ferryMissionBehavior_1)
		{
			this.ferryMissionBehavior_0 = ferryMissionBehavior_1;
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x0017A698 File Offset: 0x00178898
		public override string vmethod_5(Scenario scenario_0)
		{
			string str = "Ferry Mission";
			if (!Information.IsNothing(this.method_67(scenario_0)))
			{
				str = str + " - Destination: " + this.method_67(scenario_0).Name;
			}
			return str + " (" + this.ferryMissionBehavior_0.ToString() + ")";
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x0017A6F4 File Offset: 0x001788F4
		public ActiveUnit method_67(Scenario scenario_0)
		{
			ActiveUnit result;
			if (!Information.IsNothing(this.activeUnit_0))
			{
				result = this.activeUnit_0;
			}
			else
			{
				if (!string.IsNullOrEmpty(this.string_3))
				{
					this.activeUnit_0 = scenario_0.vmethod_0()[this.string_3];
				}
				result = this.activeUnit_0;
			}
			return result;
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x0000B26C File Offset: 0x0000946C
		public void method_68(Scenario scenario_0, ActiveUnit activeUnit_1)
		{
			this.activeUnit_0 = activeUnit_1;
			this.string_3 = this.activeUnit_0.string_0;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x0017A744 File Offset: 0x00178944
		public FerryMission(Side side_0, Scenario scenario_0, string string_4, Mission.Enum88 enum88_1, ActiveUnit activeUnit_1) : base(side_0, scenario_0)
		{
			this.bool_9 = true;
			this._MissionClass_0 = Mission._MissionClass.Ferry;
			this.Name = string_4;
			this.enum88_0 = enum88_1;
			this.method_68(scenario_0, activeUnit_1);
			this.nullable_4 = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
			this._FlightSize_0 = Mission._FlightSize.FourAircraft;
			this.bool_12 = true;
			this.bool_16 = false;
			this.doctrine_0.method_158(scenario_0, false, false, false, false, new Doctrine.Enum57?(Doctrine.Enum57.const_2));
		}

		// Token: 0x04000ECD RID: 3789
		private FerryMission.FerryMissionBehavior ferryMissionBehavior_0;

		// Token: 0x04000ECE RID: 3790
		private ActiveUnit activeUnit_0;

		// Token: 0x04000ECF RID: 3791
		private string string_3;

		// Token: 0x04000ED0 RID: 3792
		public Mission._FlightQty _FlightQty_0;

		// Token: 0x04000ED1 RID: 3793
		public ActiveUnit.Throttle? nullable_4;

		// Token: 0x04000ED2 RID: 3794
		public float? nullable_5;

		// Token: 0x04000ED3 RID: 3795
		public bool bool_22;

		// Token: 0x04000ED4 RID: 3796
		public ActiveUnit.Throttle? nullable_6;

		// Token: 0x04000ED5 RID: 3797
		public ActiveUnit.Throttle? nullable_7;

		// Token: 0x04000ED6 RID: 3798
		public float? nullable_8;

		// Token: 0x04000ED7 RID: 3799
		public Mission.Enum91 enum91_0;

		// Token: 0x02000291 RID: 657
		public enum FerryMissionBehavior : byte
		{
			// Token: 0x04000ED9 RID: 3801
			OneWay,
			// Token: 0x04000EDA RID: 3802
			Cycle,
			// Token: 0x04000EDB RID: 3803
			Random
		}
	}
}
