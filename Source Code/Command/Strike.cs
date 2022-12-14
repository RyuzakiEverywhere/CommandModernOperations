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
	// Token: 0x020002BB RID: 699
	public sealed class Strike : Mission
	{
		// Token: 0x060014EE RID: 5358 RVA: 0x00189AC4 File Offset: 0x00187CC4
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Strike");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				xmlWriter_0.WriteElementString("Name", this.Name);
				xmlWriter_0.WriteElementString("Category", ((byte)this.enum88_0).ToString());
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "Type";
				int num = (int)this.strikeType_0;
				xmlWriter.WriteElementString(localName, num.ToString());
				this.doctrine_0.method_282(ref xmlWriter_0, ref scenario_0, "Doctrine");
				this.doctrine_1.method_282(ref xmlWriter_0, ref scenario_0, "Doctrine_Escorts");
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
				xmlWriter_0.WriteStartElement("SpecificTargets");
				try
				{
					foreach (Unit unit in this.hashSet_0)
					{
						if (!Information.IsNothing(unit))
						{
							xmlWriter_0.WriteElementString("ID", unit.string_0);
						}
					}
				}
				finally
				{
					HashSet<Unit>.Enumerator enumerator;
					enumerator.Dispose();
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteElementString("MCSTT", Conversions.ToString((byte)this.postureStance_0));
				if (base.method_10(scenario_0) != Mission.Enum89.const_0)
				{
					xmlWriter_0.WriteElementString("Status", ((byte)base.method_10(scenario_0)).ToString());
				}
				if (this.bool_22)
				{
					xmlWriter_0.WriteElementString("UP", this.bool_22.ToString());
				}
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "FlightSize";
				num = (int)this._FlightSize_0;
				xmlWriter2.WriteElementString(localName2, num.ToString());
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = "GroupSize";
				num = (int)this._GroupSize_0;
				xmlWriter3.WriteElementString(localName3, num.ToString());
				XmlWriter xmlWriter4 = xmlWriter_0;
				string localName4 = "Formation_Cruise";
				num = (int)this.enum91_0;
				xmlWriter4.WriteElementString(localName4, num.ToString());
				XmlWriter xmlWriter5 = xmlWriter_0;
				string localName5 = "Formation_Attack";
				num = (int)this.enum91_1;
				xmlWriter5.WriteElementString(localName5, num.ToString());
				XmlWriter xmlWriter6 = xmlWriter_0;
				string localName6 = "Bingo";
				num = (int)this.enum90_0;
				xmlWriter6.WriteElementString(localName6, num.ToString());
				XmlWriter xmlWriter7 = xmlWriter_0;
				string localName7 = "TargeteeringMethod";
				num = (int)this.enum105_0;
				xmlWriter7.WriteElementString(localName7, num.ToString());
				XmlWriter xmlWriter8 = xmlWriter_0;
				string localName8 = "Escort_FlightSize_Shooter";
				num = (int)this._FlightSize_1;
				xmlWriter8.WriteElementString(localName8, num.ToString());
				XmlWriter xmlWriter9 = xmlWriter_0;
				string localName9 = "Escort_FlightSize_NonShooter";
				num = (int)this._FlightSize_2;
				xmlWriter9.WriteElementString(localName9, num.ToString());
				XmlWriter xmlWriter10 = xmlWriter_0;
				string localName10 = "Escort_Formation_Cruise";
				num = (int)this.enum91_2;
				xmlWriter10.WriteElementString(localName10, num.ToString());
				XmlWriter xmlWriter11 = xmlWriter_0;
				string localName11 = "Escort_Formation_Attack";
				num = (int)this.enum91_3;
				xmlWriter11.WriteElementString(localName11, num.ToString());
				if (this.nullable_4 != null)
				{
					xmlWriter_0.WriteElementString("Escort_TransitThrottle", ((byte)this.nullable_4.Value).ToString());
				}
				if (this.nullable_5 != null)
				{
					xmlWriter_0.WriteElementString("Escort_StationThrottle", ((byte)this.nullable_5.Value).ToString());
				}
				if (this.nullable_6 != null)
				{
					xmlWriter_0.WriteElementString("Escort_TransitAltitude", this.nullable_6.Value.ToString());
				}
				if (this.nullable_7 != null)
				{
					xmlWriter_0.WriteElementString("Escort_StationAltitude", this.nullable_7.Value.ToString());
				}
				xmlWriter_0.WriteElementString("Escort_TransitTerrainFollowing", this.bool_23.ToString());
				xmlWriter_0.WriteElementString("Escort_AttackTerrainFollowing", this.bool_24.ToString());
				xmlWriter_0.WriteElementString("Escort_ResponseRadius", this.int_7.ToString());
				XmlWriter xmlWriter12 = xmlWriter_0;
				string localName12 = "Escort_GroupSize";
				num = (int)this._GroupSize_1;
				xmlWriter12.WriteElementString(localName12, num.ToString());
				XmlWriter xmlWriter13 = xmlWriter_0;
				string localName13 = "MinAircraftReq_Strikers";
				num = (int)this._FlightQty_0;
				xmlWriter13.WriteElementString(localName13, num.ToString());
				XmlWriter xmlWriter14 = xmlWriter_0;
				string localName14 = "MaxAircraftToFly_Strikers";
				num = (int)this._FlightQty_3;
				xmlWriter14.WriteElementString(localName14, num.ToString());
				XmlWriter xmlWriter15 = xmlWriter_0;
				string localName15 = "MinAircraftReq_Escorts_Shooter";
				num = (int)this._FlightQty_1;
				xmlWriter15.WriteElementString(localName15, num.ToString());
				XmlWriter xmlWriter16 = xmlWriter_0;
				string localName16 = "MaxAircraftToFly_Escort_Shooter";
				num = (int)this._FlightQty_4;
				xmlWriter16.WriteElementString(localName16, num.ToString());
				XmlWriter xmlWriter17 = xmlWriter_0;
				string localName17 = "MinAircraftReq_Escorts_NonShooter";
				num = (int)this._FlightQty_2;
				xmlWriter17.WriteElementString(localName17, num.ToString());
				XmlWriter xmlWriter18 = xmlWriter_0;
				string localName18 = "MaxAircraftToFly_Escort_NonShooter";
				num = (int)this._FlightQty_5;
				xmlWriter18.WriteElementString(localName18, num.ToString());
				xmlWriter_0.WriteElementString("MinResponseRadius_Aircraft", this.int_10.ToString());
				xmlWriter_0.WriteElementString("MaxResponseRadius_Aircraft", this.int_11.ToString());
				xmlWriter_0.WriteElementString("MinResponseRadius_Ship", this.int_12.ToString());
				xmlWriter_0.WriteElementString("MaxResponseRadius_Ship", this.int_13.ToString());
				xmlWriter_0.WriteElementString("PrePlannedOnly", this.bool_27.ToString());
				xmlWriter_0.WriteElementString("OneTimeOnly", this.bool_25.ToString());
				xmlWriter_0.WriteElementString("OneTimeOnlyFlown", this.bool_26.ToString());
				XmlWriter xmlWriter19 = xmlWriter_0;
				string localName19 = "RadarBehaviour";
				num = (int)this.enum92_0;
				xmlWriter19.WriteElementString(localName19, num.ToString());
				XmlWriter xmlWriter20 = xmlWriter_0;
				string localName20 = "AttackMethod";
				num = (int)this.enum94_0;
				xmlWriter20.WriteElementString(localName20, num.ToString());
				XmlWriter xmlWriter21 = xmlWriter_0;
				string localName21 = "SplitDistance";
				num = (int)this.enum95_0;
				xmlWriter21.WriteElementString(localName21, num.ToString());
				xmlWriter_0.WriteElementString("UseFlightSizeHardLimit", this.bool_12.ToString());
				xmlWriter_0.WriteElementString("UseFlightSizeHardLimit_Escort", this.bool_28.ToString());
				xmlWriter_0.WriteElementString("UseGroupSizeHardLimit", this.bool_13.ToString());
				xmlWriter_0.WriteElementString("UseGroupSizeHardLimit_Escort", this.bool_29.ToString());
				XmlWriter xmlWriter22 = xmlWriter_0;
				string localName22 = "TankerUsage";
				byte tankerMethod_ = (byte)this.tankerMethod_0;
				xmlWriter22.WriteElementString(localName22, tankerMethod_.ToString());
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
					List<Mission>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
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
				XmlWriter xmlWriter23 = xmlWriter_0;
				string localName23 = "Escort_NumberOfFlights_Investigate";
				num = (int)this._FlightQty_6;
				xmlWriter23.WriteElementString(localName23, num.ToString());
				XmlWriter xmlWriter24 = xmlWriter_0;
				string localName24 = "Escort_NumberOfFlights_Engage";
				num = (int)this._FlightQty_7;
				xmlWriter24.WriteElementString(localName24, num.ToString());
				xmlWriter_0.WriteElementString("Escort_WingmanEngageDistance", this.int_8.ToString());
				XmlWriter xmlWriter25 = xmlWriter_0;
				string localName25 = "Escort_NumberOfBoats_Investigate";
				num = (int)this.enum100_0;
				xmlWriter25.WriteElementString(localName25, num.ToString());
				XmlWriter xmlWriter26 = xmlWriter_0;
				string localName26 = "Escort_NumberOfBoats_Engage";
				num = (int)this.enum100_1;
				xmlWriter26.WriteElementString(localName26, num.ToString());
				xmlWriter_0.WriteElementString("Escort_GroupMemberEngageDistance", this.int_9.ToString());
				if (base.method_54())
				{
					Mission.Flight.smethod_1(ref xmlWriter_0, ref hashSet_1, ref scenario_0, ref this.list_1);
				}
				if (!Information.IsNothing(this.list_2) && this.list_2.Count > 0)
				{
					Mission.EmptyAircraftSlot.smethod_0(ref xmlWriter_0, ref hashSet_1, ref scenario_0, ref this.list_2);
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100646", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0018A420 File Offset: 0x00188620
		private Strike(Side side_0, Scenario scenario_0) : base(side_0, scenario_0)
		{
			this.hashSet_0 = new HashSet<Unit>();
			this.list_5 = new List<string>();
			List<ActiveUnit> list = null;
			this.doctrine_1 = new Doctrine(this, ref list);
			this.enum94_0 = Mission.Enum94.const_1;
			this.enum95_0 = Mission.Enum95.const_1;
			this.bool_9 = true;
			this._MissionClass_0 = Mission._MissionClass.Strike;
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0018A478 File Offset: 0x00188678
		public static Strike smethod_10(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, Scenario scenario_0)
		{
			Strike result;
			try
			{
				Strike strike = new Strike(null, scenario_0);
				bool flag = false;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 2235309636U)
						{
							if (num <= 1025497782U)
							{
								if (num <= 533572954U)
								{
									if (num <= 266367750U)
									{
										if (num <= 154642767U)
										{
											if (num != 6222351U)
											{
												if (num != 154642767U)
												{
													continue;
												}
												if (Operators.CompareString(name, "Escort_TransitAltitude", false) != 0)
												{
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name, "Status", false) == 0)
												{
													strike.method_11(scenario_0, (Mission.Enum89)Conversions.ToByte(xmlNode.InnerText));
													continue;
												}
												continue;
											}
										}
										else if (num != 207389640U)
										{
											if (num != 227845695U)
											{
												if (num != 266367750U)
												{
													continue;
												}
												if (Operators.CompareString(name, "Name", false) == 0)
												{
													strike.Name = xmlNode.InnerText;
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "START", false) == 0)
												{
													DateTime value = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
													strike.nullable_0 = new DateTime?(value);
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "OneTimeOnly", false) == 0)
											{
												strike.bool_25 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num <= 302524802U)
									{
										if (num != 270724366U)
										{
											if (num != 302524802U)
											{
												continue;
											}
											if (Operators.CompareString(name, "IncludeInATO", false) == 0)
											{
												strike.bool_16 = Conversions.ToBoolean(xmlNode.InnerText);
												flag = true;
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "RadarBehaviour", false) == 0)
											{
												strike.enum92_0 = (Mission.Enum92)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num != 444307777U)
									{
										if (num != 461095311U)
										{
											if (num != 533572954U)
											{
												continue;
											}
											if (Operators.CompareString(name, "UseGroupSizeHardLimit", false) == 0)
											{
												strike.bool_13 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "SISIH", false) == 0)
											{
												strike.bool_11 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "UseFlightplan", false) == 0)
										{
											strike.bool_14 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num <= 712696542U)
								{
									if (num <= 620569374U)
									{
										if (num != 540270923U)
										{
											if (num != 620569374U)
											{
												continue;
											}
											if (Operators.CompareString(name, "TankerMinNumber_Airborne", false) == 0)
											{
												strike.int_2 = Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name, "TAO", false) != 0)
										{
											continue;
										}
									}
									else if (num != 656819206U)
									{
										if (num != 690973717U)
										{
											if (num != 712696542U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Escort_FlightSize_Shooter", false) != 0)
											{
												continue;
											}
											goto IL_F8E;
										}
										else
										{
											if (Operators.CompareString(name, "Escort_TransitTerrainFollowing", false) == 0)
											{
												strike.bool_23 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "OAO", false) != 0)
										{
											continue;
										}
										goto IL_8E0;
									}
								}
								else if (num <= 882301358U)
								{
									if (num != 721363522U)
									{
										if (num != 822842717U)
										{
											if (num != 882301358U)
											{
												continue;
											}
											if (Operators.CompareString(name, "LaunchMissionWithoutTankersInPlace", false) == 0)
											{
												strike.bool_17 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Escort_NumberOfBoats_Investigate", false) == 0)
											{
												strike.enum100_0 = (Mission.Enum100)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "TankerMaxDistance_Airborne", false) == 0)
										{
											strike.int_6 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 985231712U)
								{
									if (num != 1023940475U)
									{
										if (num != 1025497782U)
										{
											continue;
										}
										if (Operators.CompareString(name, "TankerMinNumber_Total", false) == 0)
										{
											strike.int_1 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "MaxResponseRadius_Aircraft", false) != 0)
										{
											continue;
										}
										goto IL_11E3;
									}
								}
								else
								{
									if (Operators.CompareString(name, "UseFlightplansOnly", false) == 0)
									{
										strike.bool_15 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								strike.nullable_6 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
								continue;
							}
							if (num <= 1579537194U)
							{
								if (num <= 1275005184U)
								{
									if (num <= 1074512784U)
									{
										if (num != 1062263555U)
										{
											if (num != 1074512784U)
											{
												continue;
											}
											if (Operators.CompareString(name, "TimeOnTarget", false) == 0)
											{
												DateTime value2 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
												strike.method_32(new DateTime?(value2));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "EmptySlotsList", false) == 0)
											{
												strike.list_2 = Mission.EmptyAircraftSlot.smethod_1(ref xmlNode, ref dictionary_0, scenario_0);
												continue;
											}
											continue;
										}
									}
									else if (num != 1196571045U)
									{
										if (num != 1201386167U)
										{
											if (num != 1275005184U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Escort_GroupSize", false) == 0)
											{
												strike._GroupSize_1 = (Mission._GroupSize)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Escort_GroupMemberEngageDistance", false) == 0)
											{
												strike.int_9 = Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "MinResponseRadius_Ship", false) == 0)
										{
											strike.int_12 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num <= 1299410445U)
								{
									if (num != 1291489113U)
									{
										if (num != 1299410445U)
										{
											continue;
										}
										if (Operators.CompareString(name, "SpecificTargets", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj2 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode2 = (XmlNode)obj2;
												if (Operators.CompareString(xmlNode2.Name, "Contact", false) == 0)
												{
													Contact contact = Contact.smethod_0(xmlNode2.InnerText, ref dictionary_0);
													strike.hashSet_0.Add(contact);
												}
												else
												{
													strike.list_5.Add(xmlNode2.InnerText);
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
									if (Operators.CompareString(name, "Doctrine_Escorts", false) == 0)
									{
										strike.doctrine_1 = Doctrine.smethod_9(ref xmlNode, strike);
										continue;
									}
									continue;
								}
								else if (num != 1422437055U)
								{
									if (num != 1458105184U)
									{
										if (num != 1579537194U)
										{
											continue;
										}
										if (Operators.CompareString(name, "TakeOffTime", false) == 0)
										{
											DateTime value3 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
											strike.method_30(new DateTime?(value3));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "ID", false) != 0)
										{
											continue;
										}
										if (!dictionary_0.ContainsKey(xmlNode.InnerText))
										{
											strike.vmethod_0(xmlNode.InnerText);
											dictionary_0.Add(strike.string_0, strike);
											continue;
										}
										return (Strike)dictionary_0[xmlNode.InnerText];
									}
								}
								else
								{
									if (Operators.CompareString(name, "Doctrine", false) == 0)
									{
										strike.doctrine_0 = Doctrine.smethod_9(ref xmlNode, strike);
										continue;
									}
									continue;
								}
							}
							else if (num <= 1795334850U)
							{
								if (num <= 1657676131U)
								{
									if (num != 1606513349U)
									{
										if (num != 1657676131U)
										{
											continue;
										}
										if (Operators.CompareString(name, "PatrolThrottle", false) != 0)
										{
											continue;
										}
										goto IL_A0D;
									}
									else
									{
										if (Operators.CompareString(name, "Escort_TransitThrottle", false) == 0)
										{
											strike.nullable_4 = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
											continue;
										}
										continue;
									}
								}
								else if (num != 1660128160U)
								{
									if (num != 1688531320U)
									{
										if (num != 1795334850U)
										{
											continue;
										}
										if (Operators.CompareString(name, "ST", false) != 0)
										{
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TankerMinNumber_Station", false) == 0)
										{
											strike.int_3 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "UP", false) == 0)
									{
										strike.bool_22 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (num > 2104796357U)
								{
									if (num != 2124323446U)
									{
										if (num != 2180604875U)
										{
											if (num != 2235309636U)
											{
												continue;
											}
											if (Operators.CompareString(name, "MinimumContactStanceToTrigger", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "FlightList", false) == 0)
											{
												strike.list_1 = Mission.Flight.smethod_0(ref xmlNode, ref dictionary_0, scenario_0);
												continue;
											}
											continue;
										}
									}
									else if (Operators.CompareString(name, "MCSTT", false) != 0)
									{
										continue;
									}
									strike.postureStance_0 = (Misc.PostureStance)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								if (num != 1820006327U)
								{
									if (num != 2104084864U)
									{
										if (num != 2104796357U)
										{
											continue;
										}
										if (Operators.CompareString(name, "MinAircraftReq_Escorts", false) != 0)
										{
											continue;
										}
										goto IL_CE7;
									}
									else if (Operators.CompareString(name, "Escort_StationAltitude", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "MaxResponseRadius_Ship", false) == 0)
									{
										strike.int_13 = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							IL_8E0:
							strike.nullable_7 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
							continue;
						}
						if (num <= 3284322943U)
						{
							if (num > 2878265187U)
							{
								if (num <= 3161520750U)
								{
									if (num <= 2947802513U)
									{
										if (num != 2940441098U)
										{
											if (num != 2947802513U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Category", false) == 0)
											{
												strike.enum88_0 = (Mission.Enum88)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "END", false) == 0)
											{
												DateTime value4 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
												strike.nullable_1 = new DateTime?(value4);
												continue;
											}
											continue;
										}
									}
									else if (num != 3031881553U)
									{
										if (num != 3158266596U)
										{
											if (num != 3161520750U)
											{
												continue;
											}
											if (Operators.CompareString(name, "MinAircraftReq_Escorts_Shooter", false) == 0)
											{
												goto IL_CE7;
											}
											continue;
										}
										else if (Operators.CompareString(name, "MaxAircraftToFly_Escort", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "Formation_Attack", false) == 0)
										{
											strike.enum91_1 = (Mission.Enum91)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num <= 3219336901U)
								{
									if (num != 3171215196U)
									{
										if (num != 3198166091U)
										{
											if (num != 3219336901U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Escort_Formation_Cruise", false) == 0)
											{
												strike.enum91_2 = (Mission.Enum91)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name, "MaxAircraftToFly_Escort_Shooter", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "SplitDistance", false) == 0)
										{
											strike.enum95_0 = (Mission.Enum95)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 3230168329U)
								{
									if (num != 3251257466U)
									{
										if (num != 3284322943U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Escort_WingmanEngageDistance", false) == 0)
										{
											strike.int_8 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Escort_Formation_Attack", false) == 0)
										{
											strike.enum91_3 = (Mission.Enum91)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "Escort_NumberOfFlights_Engage", false) == 0)
									{
										strike._FlightQty_7 = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								strike._FlightQty_4 = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
								continue;
							}
							if (num <= 2435049132U)
							{
								if (num <= 2398227942U)
								{
									if (num != 2367170728U)
									{
										if (num != 2398227942U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Escort_StationThrottle", false) == 0)
										{
											goto IL_A0D;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "FuelQtyToStartLookingForTanker_Airborne", false) == 0)
										{
											strike.int_5 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 2409522962U)
								{
									if (num != 2423849325U)
									{
										if (num != 2435049132U)
										{
											continue;
										}
										if (Operators.CompareString(name, "TankerMissionList", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj3 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode3 = (XmlNode)obj3;
												strike.list_3.Add(xmlNode3.InnerText);
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
									if (Operators.CompareString(name, "MaxAircraftToFly_Strikers", false) == 0)
									{
										strike._FlightQty_3 = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Escort_AttackTerrainFollowing", false) == 0)
									{
										strike.bool_24 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 2637572474U)
							{
								if (num != 2487526210U)
								{
									if (num != 2637572474U)
									{
										continue;
									}
									if (Operators.CompareString(name, "MinResponseRadius", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "FlightSize", false) == 0)
									{
										strike._FlightSize_0 = (Mission._FlightSize)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 2649384959U)
							{
								if (num != 2667312101U)
								{
									if (num != 2878265187U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Escort_FlightSize_NonShooter", false) == 0)
									{
										strike._FlightSize_2 = (Mission._FlightSize)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "UseFlightSizeHardLimit", false) == 0)
									{
										strike.bool_12 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Escort_ResponseRadius", false) == 0)
								{
									strike.int_7 = Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 3749943133U)
						{
							if (num <= 3439309385U)
							{
								if (num <= 3375375901U)
								{
									if (num != 3363423173U)
									{
										if (num != 3375375901U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Escort_NumberOfFlights_Investigate", false) == 0)
										{
											strike._FlightQty_6 = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TargeteeringMethod", false) == 0)
										{
											strike.enum105_0 = (Mission.Enum105)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 3386238231U)
								{
									if (num != 3426070594U)
									{
										if (num != 3439309385U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Escort_NumberOfBoats_Engage", false) == 0)
										{
											strike.enum100_1 = (Mission.Enum100)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "PrePlannedOnly", false) == 0)
										{
											strike.bool_27 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "Escort_FlightSize_Preferred", false) == 0)
									{
										goto IL_F8E;
									}
									continue;
								}
							}
							else if (num <= 3591985774U)
							{
								if (num != 3512062061U)
								{
									if (num != 3563879251U)
									{
										if (num != 3591985774U)
										{
											continue;
										}
										if (Operators.CompareString(name, "StartTime", false) != 0)
										{
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "MinAircraftReq_Escorts_NonShooter", false) == 0)
										{
											strike._FlightQty_2 = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "Type", false) != 0)
									{
										continue;
									}
									if (Versioned.IsNumeric(xmlNode.InnerText))
									{
										strike.strikeType_0 = (Strike.StrikeType)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									strike.strikeType_0 = (Strike.StrikeType)Enum.Parse(typeof(Strike.StrikeType), xmlNode.InnerText, true);
									continue;
								}
							}
							else if (num != 3601981274U)
							{
								if (num != 3707977405U)
								{
									if (num != 3749943133U)
									{
										continue;
									}
									if (Operators.CompareString(name, "TankerUsage", false) == 0)
									{
										strike.tankerMethod_0 = (Mission.TankerMethod)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "MinAircraftReq_Strikers", false) == 0)
									{
										strike._FlightQty_0 = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "OneTimeOnlyFlown", false) == 0)
								{
									strike.bool_26 = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 3863701925U)
						{
							if (num <= 3790255292U)
							{
								if (num != 3767471141U)
								{
									if (num != 3790255292U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Bingo", false) == 0)
									{
										strike.enum90_0 = (Mission.Enum90)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name, "MinResponseRadius_Aircraft", false) != 0)
								{
									continue;
								}
							}
							else if (num != 3802618614U)
							{
								if (num != 3857348560U)
								{
									if (num != 3863701925U)
									{
										continue;
									}
									if (Operators.CompareString(name, "GroupSize", false) == 0)
									{
										strike._GroupSize_0 = (Mission._GroupSize)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "MaxResponseRadius", false) == 0)
									{
										goto IL_11E3;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "TankerFollowsReceivers", false) == 0)
								{
									strike.bool_18 = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 3988052812U)
						{
							if (num != 3864926495U)
							{
								if (num != 3905033942U)
								{
									if (num != 3988052812U)
									{
										continue;
									}
									if (Operators.CompareString(name, "MaxAircraftToFly_Escort_NonShooter", false) == 0)
									{
										strike._FlightQty_5 = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Formation_Cruise", false) == 0)
									{
										strike.enum91_0 = (Mission.Enum91)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "UseGroupSizeHardLimit_Escort", false) == 0)
								{
									strike.bool_29 = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num != 4038753622U)
						{
							if (num != 4100651282U)
							{
								if (num != 4226137208U)
								{
									continue;
								}
								if (Operators.CompareString(name, "AttackMethod", false) == 0)
								{
									strike.enum94_0 = (Mission.Enum94)Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "MaxReceiversInQueuePerTanker_Airborne", false) == 0)
								{
									strike.int_4 = Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "UseFlightSizeHardLimit_Escort", false) == 0)
							{
								strike.bool_28 = Conversions.ToBoolean(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						strike.int_10 = Conversions.ToInteger(xmlNode.InnerText);
						continue;
						IL_A0D:
						strike.nullable_5 = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
						continue;
						IL_CE7:
						strike._FlightQty_1 = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
						continue;
						IL_F8E:
						strike._FlightSize_1 = (Mission._FlightSize)Conversions.ToInteger(xmlNode.InnerText);
						continue;
						IL_11E3:
						strike.int_11 = Conversions.ToInteger(xmlNode.InnerText);
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
				if (strike._FlightSize_0 == Mission._FlightSize.None && strike.strikeType_0 == Strike.StrikeType.Sub_Strike)
				{
					strike.doctrine_0.method_74(scenario_0, false, null, false, false, new Doctrine.Enum52?(Doctrine.Enum52.const_0));
				}
				if (strike.enum92_0 == Mission.Enum92.const_0)
				{
					if (strike.hashSet_0.Count > 0 || strike.list_5.Count > 0)
					{
						strike.bool_27 = true;
					}
					strike.bool_25 = false;
					strike.bool_26 = false;
				}
				if (strike.enum92_0 == Mission.Enum92.const_0)
				{
					if (strike.strikeType_0 == Strike.StrikeType.Maritime_Strike)
					{
						strike.enum92_0 = Mission.Enum92.const_3;
					}
					else
					{
						strike.enum92_0 = Mission.Enum92.const_1;
					}
				}
				if (strike._FlightSize_1 == Mission._FlightSize.None)
				{
					strike._FlightSize_1 = Mission._FlightSize.TwoAircraft;
					strike._FlightSize_2 = Mission._FlightSize.SingleAircraft;
					strike.doctrine_1.method_118(scenario_0, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
					strike.doctrine_1.method_8(false);
					strike.doctrine_1.method_192(Doctrine.Class275.Enum66.const_1, scenario_0);
				}
				ActiveUnit.Throttle? throttle = strike.nullable_4;
				byte? b = (throttle != null) ? new byte?((byte)throttle.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					strike.nullable_4 = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
				}
				throttle = strike.nullable_5;
				b = ((throttle != null) ? new byte?((byte)throttle.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					strike.nullable_5 = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Full);
				}
				if (strike.int_7 == 0)
				{
					strike.int_7 = 80;
				}
				if (strike.doctrine_0.method_159())
				{
					strike.doctrine_0.method_158(scenario_0, false, false, false, false, new Doctrine.Enum57?(Doctrine.Enum57.const_2));
				}
				if (!flag)
				{
					Strike.StrikeType strikeType = strike.strikeType_0;
					if (strikeType != Strike.StrikeType.Air_Intercept)
					{
						if (strikeType != Strike.StrikeType.Sub_Strike)
						{
							strike.bool_16 = true;
						}
						else
						{
							strike.bool_16 = false;
						}
					}
					else
					{
						strike.bool_16 = false;
					}
				}
				if (strike._FlightQty_6 == Mission._FlightQty.NoPreferences)
				{
					strike._FlightQty_6 = Mission._FlightQty.Flight_x1;
					strike._FlightQty_7 = Mission._FlightQty.All;
					strike.int_8 = 5;
					strike.enum100_0 = Mission.Enum100.const_1;
					strike.enum100_1 = Mission.Enum100.const_1;
					strike.int_9 = 5;
				}
				result = strike;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100648", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Strike(null, scenario_0);
			}
			return result;
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0018BAE8 File Offset: 0x00189CE8
		public override string vmethod_5(Scenario scenario_0)
		{
			string result;
			switch (this.strikeType_0)
			{
			case Strike.StrikeType.Air_Intercept:
				result = "Air Intercept";
				break;
			case Strike.StrikeType.Land_Strike:
				result = "Land Strike";
				break;
			case Strike.StrikeType.Maritime_Strike:
				result = "Maritime Strike";
				break;
			case Strike.StrikeType.Sub_Strike:
				result = "ASW Strike";
				break;
			default:
				throw new NotImplementedException();
			}
			return result;
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0018BB38 File Offset: 0x00189D38
		public Strike(Side side_0, Scenario scenario_0, string string_3, Mission.Enum88 enum88_1, Strike.StrikeType strikeType_1) : base(side_0, scenario_0)
		{
			this.hashSet_0 = new HashSet<Unit>();
			this.list_5 = new List<string>();
			List<ActiveUnit> list = null;
			this.doctrine_1 = new Doctrine(this, ref list);
			this.enum94_0 = Mission.Enum94.const_1;
			this.enum95_0 = Mission.Enum95.const_1;
			this.bool_9 = true;
			this._MissionClass_0 = Mission._MissionClass.Strike;
			list = null;
			this.doctrine_1 = new Doctrine(this, ref list);
			this.enum88_0 = enum88_1;
			this.strikeType_0 = strikeType_1;
			this.Name = string_3;
			this.bool_12 = true;
			Strike.StrikeType strikeType = this.strikeType_0;
			if (strikeType != Strike.StrikeType.Air_Intercept)
			{
				if (strikeType != Strike.StrikeType.Sub_Strike)
				{
					this.doctrine_0.method_192(Doctrine.Class275.Enum66.const_0, scenario_0);
					this._FlightSize_0 = Mission._FlightSize.FourAircraft;
					this.bool_16 = true;
				}
				else
				{
					this.doctrine_0.method_192(Doctrine.Class275.Enum66.const_0, scenario_0);
					this.doctrine_0.method_74(scenario_0, false, null, false, false, new Doctrine.Enum52?(Doctrine.Enum52.const_0));
					this._FlightSize_0 = Mission._FlightSize.SingleAircraft;
					this.bool_16 = false;
				}
			}
			else
			{
				this.doctrine_0.method_192(Doctrine.Class275.Enum66.const_1, scenario_0);
				this._FlightSize_0 = Mission._FlightSize.TwoAircraft;
				this.bool_16 = false;
			}
			this._GroupSize_0 = Mission._GroupSize.SingleVessel;
			this.bool_25 = false;
			this.bool_26 = false;
			if (strikeType_1 == Strike.StrikeType.Maritime_Strike)
			{
				this.enum92_0 = Mission.Enum92.const_3;
			}
			else
			{
				this.enum92_0 = Mission.Enum92.const_1;
			}
			this._FlightSize_1 = Mission._FlightSize.TwoAircraft;
			this._FlightSize_2 = Mission._FlightSize.SingleAircraft;
			this.nullable_4 = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
			this.nullable_5 = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Full);
			this.bool_23 = false;
			this.bool_24 = false;
			this.int_7 = 80;
			this.doctrine_0.method_118(scenario_0, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
			this.doctrine_1.method_118(scenario_0, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
			this.doctrine_1.method_192(Doctrine.Class275.Enum66.const_1, scenario_0);
			this.doctrine_0.method_158(scenario_0, false, false, false, false, new Doctrine.Enum57?(Doctrine.Enum57.const_2));
			this.doctrine_1.method_158(scenario_0, false, false, false, false, new Doctrine.Enum57?(Doctrine.Enum57.const_2));
			this._FlightQty_6 = Mission._FlightQty.Flight_x1;
			this._FlightQty_7 = Mission._FlightQty.All;
			this.int_8 = 5;
			this.enum100_0 = Mission.Enum100.const_1;
			this.enum100_1 = Mission.Enum100.const_1;
			this.int_9 = 5;
			this.postureStance_0 = Misc.PostureStance.Unknown;
			this.enum105_0 = Mission.Enum105.const_0;
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0018BD44 File Offset: 0x00189F44
		public override void vmethod_6(ref Scenario scenario_0, Side side_0, bool bool_30)
		{
			try
			{
				if (this.list_5.Count > 0)
				{
					try
					{
						foreach (ActiveUnit activeUnit in scenario_0.method_42())
						{
							if (!Information.IsNothing(activeUnit) && this.list_5.Contains(activeUnit.string_0))
							{
								this.hashSet_0.Add(activeUnit);
								if (base.method_12() && side_0.method_68(activeUnit.vmethod_7(false)) != Misc.PostureStance.Hostile)
								{
									side_0.method_69(activeUnit.vmethod_7(false), Misc.PostureStance.Hostile);
								}
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					try
					{
						foreach (Contact contact in side_0.method_44())
						{
							if (this.list_5.Contains(contact.string_0))
							{
								this.hashSet_0.Add(contact);
								if (base.method_12() && contact.method_130(side_0) != Misc.PostureStance.Hostile)
								{
									contact.method_131(side_0, false, Misc.PostureStance.Hostile);
								}
							}
						}
					}
					finally
					{
						List<Contact>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
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
							IEnumerator<Mission> enumerator3;
							if (enumerator3 != null)
							{
								enumerator3.Dispose();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100649", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x040010AF RID: 4271
		public Strike.StrikeType strikeType_0;

		// Token: 0x040010B0 RID: 4272
		public HashSet<Unit> hashSet_0;

		// Token: 0x040010B1 RID: 4273
		private List<string> list_5;

		// Token: 0x040010B2 RID: 4274
		public bool bool_22;

		// Token: 0x040010B3 RID: 4275
		public Doctrine doctrine_1;

		// Token: 0x040010B4 RID: 4276
		public Mission._FlightQty _FlightQty_0;

		// Token: 0x040010B5 RID: 4277
		public Mission._FlightQty _FlightQty_1;

		// Token: 0x040010B6 RID: 4278
		public Mission._FlightQty _FlightQty_2;

		// Token: 0x040010B7 RID: 4279
		public Mission._FlightQty _FlightQty_3;

		// Token: 0x040010B8 RID: 4280
		public Mission._FlightQty _FlightQty_4;

		// Token: 0x040010B9 RID: 4281
		public Mission._FlightQty _FlightQty_5;

		// Token: 0x040010BA RID: 4282
		public Mission.Enum91 enum91_0;

		// Token: 0x040010BB RID: 4283
		public Mission.Enum91 enum91_1;

		// Token: 0x040010BC RID: 4284
		public Mission.Enum90 enum90_0;

		// Token: 0x040010BD RID: 4285
		public Mission.Enum105 enum105_0;

		// Token: 0x040010BE RID: 4286
		public Mission._FlightSize _FlightSize_1;

		// Token: 0x040010BF RID: 4287
		public Mission._FlightSize _FlightSize_2;

		// Token: 0x040010C0 RID: 4288
		public Mission.Enum91 enum91_2;

		// Token: 0x040010C1 RID: 4289
		public Mission.Enum91 enum91_3;

		// Token: 0x040010C2 RID: 4290
		public ActiveUnit.Throttle? nullable_4;

		// Token: 0x040010C3 RID: 4291
		public ActiveUnit.Throttle? nullable_5;

		// Token: 0x040010C4 RID: 4292
		public bool bool_23;

		// Token: 0x040010C5 RID: 4293
		public bool bool_24;

		// Token: 0x040010C6 RID: 4294
		public Mission._GroupSize _GroupSize_1;

		// Token: 0x040010C7 RID: 4295
		public float? nullable_6;

		// Token: 0x040010C8 RID: 4296
		public float? nullable_7;

		// Token: 0x040010C9 RID: 4297
		public int int_7;

		// Token: 0x040010CA RID: 4298
		public Mission._FlightQty _FlightQty_6;

		// Token: 0x040010CB RID: 4299
		public Mission._FlightQty _FlightQty_7;

		// Token: 0x040010CC RID: 4300
		public int int_8;

		// Token: 0x040010CD RID: 4301
		public Mission.Enum100 enum100_0;

		// Token: 0x040010CE RID: 4302
		public Mission.Enum100 enum100_1;

		// Token: 0x040010CF RID: 4303
		public int int_9;

		// Token: 0x040010D0 RID: 4304
		public int int_10;

		// Token: 0x040010D1 RID: 4305
		public int int_11;

		// Token: 0x040010D2 RID: 4306
		public int int_12;

		// Token: 0x040010D3 RID: 4307
		public int int_13;

		// Token: 0x040010D4 RID: 4308
		public bool bool_25;

		// Token: 0x040010D5 RID: 4309
		public bool bool_26;

		// Token: 0x040010D6 RID: 4310
		public Mission.Enum92 enum92_0;

		// Token: 0x040010D7 RID: 4311
		public bool bool_27;

		// Token: 0x040010D8 RID: 4312
		public bool bool_28;

		// Token: 0x040010D9 RID: 4313
		public bool bool_29;

		// Token: 0x040010DA RID: 4314
		public Mission.Enum94 enum94_0;

		// Token: 0x040010DB RID: 4315
		public Mission.Enum95 enum95_0;

		// Token: 0x040010DC RID: 4316
		public Misc.PostureStance postureStance_0;

		// Token: 0x020002BC RID: 700
		public enum StrikeType
		{
			// Token: 0x040010DE RID: 4318
			Air_Intercept,
			// Token: 0x040010DF RID: 4319
			Land_Strike,
			// Token: 0x040010E0 RID: 4320
			Maritime_Strike,
			// Token: 0x040010E1 RID: 4321
			Sub_Strike
		}
	}
}
