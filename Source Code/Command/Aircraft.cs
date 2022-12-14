using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SQLite;
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
	// Token: 0x0200017E RID: 382
	public sealed class Aircraft : Class350, Interface3, Interface6
	{
		// Token: 0x06000B4B RID: 2891 RVA: 0x000D2DCC File Offset: 0x000D0FCC
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			if (this.vmethod_7(false) != null)
			{
				try
				{
					xmlWriter_0.WriteStartElement("Aircraft");
					xmlWriter_0.WriteElementString("ID", this.string_0);
					if (hashSet_0.Contains(this.string_0))
					{
						xmlWriter_0.WriteEndElement();
					}
					else
					{
						hashSet_0.Add(this.string_0);
						xmlWriter_0.WriteElementString("Name", this.Name.Replace("\0", "").Replace("\u0010", ""));
						if (this.int_5 != 0)
						{
							xmlWriter_0.WriteElementString("COA", Conversions.ToString(this.int_5));
						}
						xmlWriter_0.WriteElementString("CH", XmlConvert.ToString(this.vmethod_9()));
						xmlWriter_0.WriteElementString("CS", XmlConvert.ToString(this.vmethod_40()));
						xmlWriter_0.WriteElementString("CA", XmlConvert.ToString(this.vmethod_14(false)));
						xmlWriter_0.WriteElementString("Lon", XmlConvert.ToString(this.double_1));
						xmlWriter_0.WriteElementString("Lat", XmlConvert.ToString(this.double_0));
						if (base.method_58() != null)
						{
							xmlWriter_0.WriteElementString("LonLR", XmlConvert.ToString(base.method_58().Value));
						}
						if (base.method_56() != null)
						{
							xmlWriter_0.WriteElementString("LatLR", XmlConvert.ToString(base.method_56().Value));
						}
						if (this.vmethod_36() != null)
						{
							xmlWriter_0.WriteElementString("Longitude_UnitEntersAreaCheck", XmlConvert.ToString(this.vmethod_36().Value));
						}
						if (this.vmethod_38() != null)
						{
							xmlWriter_0.WriteElementString("Latitude_UnitEntersAreaCheck", XmlConvert.ToString(this.vmethod_38().Value));
						}
						if (this.list_0.Count > 0)
						{
							xmlWriter_0.WriteStartElement("ActiveEnterAreaTriggers");
							try
							{
								foreach (string value in this.list_0)
								{
									xmlWriter_0.WriteElementString("ActiveEnterAreaTrigger", value);
								}
							}
							finally
							{
								List<string>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							xmlWriter_0.WriteEndElement();
						}
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
								List<RangeSymbol>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							xmlWriter_0.WriteEndElement();
						}
						xmlWriter_0.WriteElementString("Side", this.vmethod_7(false).method_51());
						if (!string.IsNullOrEmpty(this.string_3))
						{
							xmlWriter_0.WriteElementString("Message", this.string_3);
						}
						xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
						xmlWriter_0.WriteElementString("DH", XmlConvert.ToString(this.vmethod_68()));
						xmlWriter_0.WriteElementString("DS", XmlConvert.ToString(this.vmethod_70()));
						xmlWriter_0.WriteElementString("DA", XmlConvert.ToString(this.vmethod_72()));
						xmlWriter_0.WriteElementString("DT", ((byte)this.vmethod_78()).ToString());
						xmlWriter_0.WriteElementString("DTN", ((byte)this.vmethod_80()).ToString());
						if (this.vmethod_74() != 0f)
						{
							xmlWriter_0.WriteElementString("DesiredAltitude_TerrainFollowing", XmlConvert.ToString(this.vmethod_74()));
						}
						if (this.vmethod_76(this))
						{
							xmlWriter_0.WriteElementString("TerrainFollowing", this.vmethod_76(this).ToString());
						}
						XmlWriter xmlWriter = xmlWriter_0;
						string localName = "FlightRole";
						byte b = (byte)this.enum106_0;
						xmlWriter.WriteElementString(localName, b.ToString());
						xmlWriter_0.WriteElementString("Thr", ((byte)this.vmethod_84()).ToString());
						xmlWriter_0.WriteElementString("AbnTime", XmlConvert.ToString(this.float_26));
						if (this.nullable_15 != null)
						{
							xmlWriter_0.WriteElementString("Prof", ((int)this.nullable_15.Value).ToString());
						}
						Sensor[] array;
						if (base.method_78() == null)
						{
							array = this.vmethod_96();
						}
						else
						{
							array = base.method_78();
						}
						if (array.Length > 0)
						{
							xmlWriter_0.WriteStartElement("Sensors");
							foreach (Sensor sensor in this.sensor_0)
							{
								xmlWriter_0.WriteRaw(sensor.method_23(hashSet_0));
							}
							xmlWriter_0.WriteEndElement();
							if (this.method_167() != null && this.method_167().method_9(this.scenario_0).Length > 0)
							{
								xmlWriter_0.WriteStartElement("PoddedSensors");
								foreach (Sensor sensor2 in this.method_167().method_9(this.scenario_0))
								{
									HashSet<string> hashSet_ = new HashSet<string>();
									xmlWriter_0.WriteRaw(sensor2.method_23(hashSet_));
								}
								xmlWriter_0.WriteEndElement();
							}
						}
						if (this.vmethod_94().Length > 0)
						{
							xmlWriter_0.WriteStartElement("Comms");
							foreach (CommDevice commDevice in this.commDevice_0)
							{
								xmlWriter_0.WriteRaw(commDevice.method_23(ref hashSet_0));
							}
							xmlWriter_0.WriteEndElement();
						}
						if (this.vmethod_49().Count > 0)
						{
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
								List<Engine>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
							xmlWriter_0.WriteEndElement();
						}
						if (Enumerable.Count<FuelRec>(this.fuelRec_0) > 0)
						{
							xmlWriter_0.WriteStartElement("Fuel");
							foreach (FuelRec fuelRec in this.fuelRec_0)
							{
								xmlWriter_0.WriteRaw(fuelRec.method_8());
							}
							xmlWriter_0.WriteEndElement();
						}
						if (this.vmethod_51().Count > 0)
						{
							xmlWriter_0.WriteStartElement("Mounts");
							try
							{
								foreach (Mount mount in this.vmethod_51())
								{
									if (mount.method_18() == null)
									{
										mount.method_19(this);
									}
									xmlWriter_0.WriteRaw(mount.method_23(ref hashSet_0, this.scenario_0));
								}
							}
							finally
							{
								List<Mount>.Enumerator enumerator4;
								((IDisposable)enumerator4).Dispose();
							}
							xmlWriter_0.WriteEndElement();
						}
						if (Enumerable.Count<Cargo>(this.cargo_0) > 0)
						{
							xmlWriter_0.WriteStartElement("OnboardCargo");
							foreach (Cargo cargo in this.cargo_0)
							{
								xmlWriter_0.WriteRaw(cargo.method_27(hashSet_0, this.scenario_0));
							}
							xmlWriter_0.WriteEndElement();
						}
						XmlWriter xmlWriter2 = xmlWriter_0;
						string localName2 = "Status";
						b = (byte)this._ActiveUnitStatus_0;
						xmlWriter2.WriteElementString(localName2, b.ToString());
						XmlWriter xmlWriter3 = xmlWriter_0;
						string localName3 = "FuelState";
						b = (byte)this._ActiveUnitFuelState_0;
						xmlWriter3.WriteElementString(localName3, b.ToString());
						XmlWriter xmlWriter4 = xmlWriter_0;
						string localName4 = "WeaponState";
						b = (byte)this._ActiveUnitWeaponState_0;
						xmlWriter4.WriteElementString(localName4, b.ToString());
						XmlWriter xmlWriter5 = xmlWriter_0;
						string localName5 = "SBR";
						b = (byte)this._ActiveUnitStatus_2;
						xmlWriter5.WriteElementString(localName5, b.ToString());
						XmlWriter xmlWriter6 = xmlWriter_0;
						string localName6 = "SBED";
						b = (byte)this._ActiveUnitStatus_3;
						xmlWriter6.WriteElementString(localName6, b.ToString());
						XmlWriter xmlWriter7 = xmlWriter_0;
						string localName7 = "SBEO";
						b = (byte)this._ActiveUnitStatus_4;
						xmlWriter7.WriteElementString(localName7, b.ToString());
						XmlWriter xmlWriter8 = xmlWriter_0;
						string localName8 = "FSBR";
						b = (byte)this._ActiveUnitFuelState_1;
						xmlWriter8.WriteElementString(localName8, b.ToString());
						xmlWriter_0.WriteElementString("SBR_Altitude", XmlConvert.ToString(this.float_17));
						xmlWriter_0.WriteElementString("SBR_Altitude_TF", XmlConvert.ToString(this.float_18));
						xmlWriter_0.WriteElementString("SBR_TF", XmlConvert.ToString(this.bool_19));
						XmlWriter xmlWriter9 = xmlWriter_0;
						string localName9 = "SBR_ThrottleSetting";
						b = (byte)this.throttle_1;
						xmlWriter9.WriteElementString(localName9, b.ToString());
						xmlWriter_0.WriteElementString("SBED_Altitude", XmlConvert.ToString(this.float_19));
						if (this.nullable_14 != null)
						{
							xmlWriter_0.WriteElementString("SBED_Altitude_TF", XmlConvert.ToString(this.nullable_14.Value));
						}
						xmlWriter_0.WriteElementString("SBED_TF", XmlConvert.ToString(this.bool_20));
						XmlWriter xmlWriter10 = xmlWriter_0;
						string localName10 = "SBED_ThrottleSetting";
						b = (byte)this.throttle_2;
						xmlWriter10.WriteElementString(localName10, b.ToString());
						xmlWriter_0.WriteElementString("SBEO_Altitude", XmlConvert.ToString(this.float_20));
						xmlWriter_0.WriteElementString("SBEO_Altitude_TF", XmlConvert.ToString(this.float_21));
						xmlWriter_0.WriteElementString("SBEO_TF", XmlConvert.ToString(this.bool_21));
						XmlWriter xmlWriter11 = xmlWriter_0;
						string localName11 = "SBEO_ThrottleSetting";
						b = (byte)this.throttle_3;
						xmlWriter11.WriteElementString(localName11, b.ToString());
						xmlWriter_0.WriteElementString("SBPF_Altitude", XmlConvert.ToString(this.float_22));
						xmlWriter_0.WriteElementString("SBPF_Altitude_TF", XmlConvert.ToString(this.float_23));
						xmlWriter_0.WriteElementString("SBPF_TF", XmlConvert.ToString(this.bool_22));
						XmlWriter xmlWriter12 = xmlWriter_0;
						string localName12 = "SBPF_ThrottleSetting";
						b = (byte)this.throttle_4;
						xmlWriter12.WriteElementString(localName12, b.ToString());
						xmlWriter_0.WriteElementString("AMP_OC", this.bool_17.ToString());
						if (this.nullable_13 != null)
						{
							xmlWriter_0.WriteElementString("AMP_OC_DSO", this.nullable_13.ToString());
						}
						xmlWriter_0.WriteElementString("AMP_OC_DAO", this.bool_18.ToString());
						xmlWriter_0.WriteElementString("AMP_OC_Speed", XmlConvert.ToString(this.float_16));
						xmlWriter_0.WriteElementString("DamagePts", XmlConvert.ToString(this.vmethod_63(false, null)));
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
						if (base.method_92(null))
						{
							xmlWriter_0.WriteElementString("IsAD", base.method_92(null).ToString());
						}
						this.doctrine_0.method_282(ref xmlWriter_0, ref this.scenario_0, "Doctrine");
						if (this.method_167() != null)
						{
							xmlWriter_0.WriteStartElement("Loadout");
							xmlWriter_0.WriteRaw(this.loadout_0.method_8(ref hashSet_0, this.scenario_0));
							xmlWriter_0.WriteEndElement();
						}
						this.method_157().vmethod_0(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteStartElement("AI");
						if (this.method_158().activeUnit_0 == null)
						{
							this.method_158().activeUnit_0 = this;
						}
						this.method_158().vmethod_2(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Kinematics");
						this.method_159().vmethod_0(ref xmlWriter_0);
						xmlWriter_0.WriteEndElement();
						this.method_160().vmethod_2(ref xmlWriter_0);
						this.method_161().vmethod_2(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteStartElement("CommStuff");
						this.method_162().vmethod_0(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						this.method_163().vmethod_0(ref xmlWriter_0);
						this.method_164().vmethod_0(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100348", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
			}
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x000D3A5C File Offset: 0x000D1C5C
		private Aircraft()
		{
			Scenario scenario = null;
			base..ctor(ref scenario, null);
			this.float_31 = 45f;
			this.armorRating_0 = GlobalVariables.ArmorRating.None;
			this.armorRating_1 = GlobalVariables.ArmorRating.None;
			this.armorRating_2 = GlobalVariables.ArmorRating.None;
			this.float_33 = 0f;
			this.float_34 = 0f;
			this.enum38_0 = Aircraft.Enum38.const_1;
			this.enum38_1 = Aircraft.Enum38.const_1;
			this.enum38_2 = Aircraft.Enum38.const_1;
			this.bool_3 = true;
			ActiveUnit activeUnit = this;
			this.aircraft_AirOps_0 = new Aircraft_AirOps(ref activeUnit);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x000D3AE4 File Offset: 0x000D1CE4
		public static Aircraft smethod_10(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_1)
		{
			Aircraft aircraft;
			try
			{
				aircraft = Aircraft.smethod_11(ref xmlNode_0, ref dictionary_0, ref scenario_1, scenario_1.LoadStockUnits);
			}
			catch (Exception1 exception)
			{
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				dictionary_0.Remove(innerText);
				aircraft = Aircraft.smethod_11(ref xmlNode_0, ref dictionary_0, ref scenario_1, true);
				string text = "";
				if (aircraft.method_120())
				{
					text = "(member of group: [" + aircraft.vmethod_65(false).Name + "])";
				}
				scenario_1.LoadingNotices.Add(string.Concat(new string[]
				{
					"The following aircraft:[",
					aircraft.Name,
					"]",
					text,
					" failed to shallow-rebuild because of a component missing. The aircraft was instead deep-rebuilt, and instantiated in its pristine DB-stock condition. All customizations present in the aircraft's components (damaged components, weapon additions/removals etc. etc.) have been lost. Please re-apply any necessary customizations either manually or using an SBR script."
				}));
			}
			if (aircraft.vmethod_26())
			{
				aircraft.vmethod_15(false, (float)(Terrain.smethod_7(aircraft.vmethod_30(null), aircraft.vmethod_28(null), false) + 1));
			}
			return aircraft;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x000D3BEC File Offset: 0x000D1DEC
		private static Aircraft smethod_11(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_1, bool bool_42)
		{
			Aircraft aircraft = new Aircraft();
			Sensor[] array = new Sensor[0];
			Aircraft result;
			try
			{
				aircraft.scenario_0 = scenario_1;
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					result = (Aircraft)dictionary_0[innerText];
				}
				else
				{
					aircraft.vmethod_0(innerText);
					if (xmlNode_0.ChildNodes.Count == 1)
					{
						scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
						result = aircraft;
					}
					else
					{
						dictionary_0.Add(aircraft.string_0, aircraft);
						int num = Conversions.ToInteger(Misc.smethod_44(xmlNode_0.ChildNodes, "DBID").InnerText);
						try
						{
							DBFunctions.smethod_19(ref scenario_1, ref aircraft, num, bool_42);
						}
						catch (Exception ex)
						{
							dictionary_0.Remove(aircraft.string_0);
							scenario_1.LoadingNotices.Add("Aircraft with Database ID " + Conversions.ToString(num) + " is missing from the database and has not been loaded.");
							return result;
						}
						if (bool_42)
						{
							aircraft.method_99(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						}
						if (!bool_42)
						{
							try
							{
								foreach (object obj in xmlNode_0.ChildNodes)
								{
									XmlNode xmlNode = (XmlNode)obj;
									string name = xmlNode.Name;
									uint num2 = Class582.smethod_0(name);
									if (num2 <= 2241118125U)
									{
										if (num2 <= 2008421230U)
										{
											if (num2 != 1305748348U)
											{
												if (num2 != 2008421230U)
												{
													continue;
												}
												if (Operators.CompareString(name, "Comms", false) == 0)
												{
													int num3 = xmlNode.ChildNodes.Count - 1;
													int i = 0;
													while (i <= num3)
													{
														XmlNode xmlNode2 = xmlNode.ChildNodes[i];
														CommDevice commDevice = CommDevice.smethod_2(ref xmlNode2, ref dictionary_0, aircraft);
														if (commDevice.DBID == 0)
														{
															Aircraft aircraft2 = new Aircraft(ref scenario_1, null);
															aircraft2.scenario_0 = scenario_1;
															DBFunctions.smethod_19(ref scenario_1, ref aircraft2, num, true);
															try
															{
																commDevice = aircraft2.vmethod_94()[i];
																aircraft2 = null;
															}
															catch (Exception ex2)
															{
																ex2.Data.Add("Error at 200018", ex2.Message);
																GameGeneral.smethod_25(ref ex2);
																if (Debugger.IsAttached)
																{
																	Debugger.Break();
																}
																goto IL_23B;
															}
															goto IL_21B;
														}
														goto IL_21B;
														IL_23B:
														i++;
														continue;
														IL_21B:
														dictionary_0.Add(commDevice.string_0, commDevice);
														aircraft.method_101(commDevice);
														commDevice.method_19(aircraft);
														goto IL_23B;
													}
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "OnboardCargo", false) != 0)
												{
													continue;
												}
												try
												{
													foreach (object obj2 in xmlNode.ChildNodes)
													{
														XmlNode xmlNode3 = (XmlNode)obj2;
														Cargo cargo = Cargo.smethod_2(ref xmlNode3, ref dictionary_0, aircraft);
														Class429.smethod_6(ref aircraft.cargo_0, cargo);
														cargo.method_19(aircraft);
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
										if (num2 != 2096367071U)
										{
											if (num2 != 2241118125U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Fuel", false) != 0)
											{
												continue;
											}
											try
											{
												foreach (object obj3 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode4 = (XmlNode)obj3;
													FuelRec fuelRec_ = FuelRec.smethod_0(ref xmlNode4, ref dictionary_0);
													Class429.smethod_19(ref aircraft.fuelRec_0, fuelRec_);
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
										if (Operators.CompareString(name, "DockFacilities", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj4 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode5 = (XmlNode)obj4;
												DockFacility dockFacility = DockFacility.smethod_2(ref xmlNode5, ref dictionary_0, ref scenario_1);
												aircraft.method_104(dockFacility);
												dockFacility.method_19(aircraft);
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
									if (num2 <= 2424405304U)
									{
										if (num2 != 2246682072U)
										{
											if (num2 != 2424405304U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Sensors", false) != 0)
											{
												continue;
											}
											try
											{
												foreach (object obj5 in xmlNode.ChildNodes)
												{
													Sensor sensor = Sensor.smethod_2((XmlNode)obj5, dictionary_0, aircraft);
													Class429.smethod_24(ref aircraft.sensor_0, sensor);
													sensor.method_19(aircraft);
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
										if (Operators.CompareString(name, "Propulsion", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj6 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode6 = (XmlNode)obj6;
												ActiveUnit activeUnit = aircraft;
												Engine engine = Engine.smethod_2(ref xmlNode6, ref dictionary_0, ref activeUnit);
												aircraft.vmethod_49().method_4(engine);
												engine.method_19(aircraft);
											}
											continue;
										}
										finally
										{
											IEnumerator enumerator6;
											if (enumerator6 is IDisposable)
											{
												(enumerator6 as IDisposable).Dispose();
											}
										}
									}
									if (num2 != 3520996972U)
									{
										if (num2 != 3760177291U)
										{
											if (num2 != 3989581338U)
											{
												continue;
											}
											if (Operators.CompareString(name, "AirFacilities", false) != 0)
											{
												continue;
											}
											try
											{
												foreach (object obj7 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode7 = (XmlNode)obj7;
													AirFacility airFacility = AirFacility.smethod_3(ref xmlNode7, ref dictionary_0, ref scenario_1);
													aircraft.method_103(airFacility);
													airFacility.method_19(aircraft);
												}
												continue;
											}
											finally
											{
												IEnumerator enumerator7;
												if (enumerator7 is IDisposable)
												{
													(enumerator7 as IDisposable).Dispose();
												}
											}
										}
										if (Operators.CompareString(name, "Mounts", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj8 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode8 = (XmlNode)obj8;
												Mount mount = Mount.smethod_6(ref xmlNode8, ref dictionary_0, aircraft);
												aircraft.vmethod_51().method_4(mount);
												mount.method_19(aircraft);
											}
											continue;
										}
										finally
										{
											IEnumerator enumerator8;
											if (enumerator8 is IDisposable)
											{
												(enumerator8 as IDisposable).Dispose();
											}
										}
									}
									if (Operators.CompareString(name, "PoddedSensors", false) == 0)
									{
										try
										{
											foreach (object obj9 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode_ = (XmlNode)obj9;
												Dictionary<string, Class310> dictionary_ = new Dictionary<string, Class310>();
												Sensor sensor_ = Sensor.smethod_2(xmlNode_, dictionary_, aircraft);
												Class429.smethod_24(ref array, sensor_);
											}
										}
										finally
										{
											IEnumerator enumerator9;
											if (enumerator9 is IDisposable)
											{
												(enumerator9 as IDisposable).Dispose();
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
						try
						{
							foreach (object obj10 in xmlNode_0.ChildNodes)
							{
								XmlNode xmlNode9 = (XmlNode)obj10;
								string name2 = xmlNode9.Name;
								uint num2 = Class582.smethod_0(name2);
								if (num2 > 1708783731U)
								{
									if (num2 <= 2834497881U)
									{
										if (num2 <= 2247649009U)
										{
											if (num2 <= 1953443573U)
											{
												if (num2 <= 1738278884U)
												{
													if (num2 != 1729717486U)
													{
														if (num2 != 1738278884U)
														{
															continue;
														}
														if (Operators.CompareString(name2, "SBED_TF", false) == 0)
														{
															aircraft.bool_20 = Conversions.ToBoolean(xmlNode9.InnerText);
															continue;
														}
														continue;
													}
													else if (Operators.CompareString(name2, "Longitude", false) != 0)
													{
														continue;
													}
												}
												else if (num2 != 1836990821U)
												{
													if (num2 != 1953416793U)
													{
														if (num2 != 1953443573U)
														{
															continue;
														}
														if (Operators.CompareString(name2, "Aircraft_Damage", false) == 0)
														{
															goto IL_13A7;
														}
														continue;
													}
													else
													{
														if (Operators.CompareString(name2, "AMP_OC_DSO", false) == 0)
														{
															aircraft.nullable_13 = new float?(XmlConvert.ToSingle(xmlNode9.InnerText));
															continue;
														}
														continue;
													}
												}
												else
												{
													if (Operators.CompareString(name2, "Latitude", false) != 0)
													{
														continue;
													}
													goto IL_1A78;
												}
											}
											else if (num2 <= 2066337159U)
											{
												if (num2 != 1992083866U)
												{
													if (num2 != 2010780873U)
													{
														if (num2 != 2066337159U)
														{
															continue;
														}
														if (Operators.CompareString(name2, "DesiredAltitude", false) == 0)
														{
															goto IL_1442;
														}
														continue;
													}
													else
													{
														if (Operators.CompareString(name2, "CA", false) == 0)
														{
															goto IL_146B;
														}
														continue;
													}
												}
												else
												{
													if (Operators.CompareString(name2, "Latitude_UnitEntersAreaCheck", false) == 0)
													{
														aircraft.vmethod_39(new double?(XmlConvert.ToDouble(xmlNode9.InnerText)));
														continue;
													}
													continue;
												}
											}
											else if (num2 != 2077651438U)
											{
												if (num2 != 2128224206U)
												{
													if (num2 != 2247649009U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "AssignedMission", false) == 0 && xmlNode9.HasChildNodes)
													{
														XmlNode xmlNode10 = xmlNode9.ChildNodes[0];
														aircraft.string_4 = xmlNode10.InnerText;
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "CH", false) != 0)
													{
														continue;
													}
													goto IL_1E93;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "Aircraft_Kinematics", false) == 0)
												{
													goto IL_1539;
												}
												continue;
											}
										}
										else
										{
											if (num2 <= 2564648390U)
											{
												if (num2 <= 2450333180U)
												{
													if (num2 != 2323739590U)
													{
														if (num2 != 2450333180U)
														{
															continue;
														}
														if (Operators.CompareString(name2, "Aircraft_AirOps", false) == 0)
														{
															goto IL_1586;
														}
														continue;
													}
													else
													{
														if (Operators.CompareString(name2, "Sensory", false) == 0)
														{
															goto IL_15B0;
														}
														continue;
													}
												}
												else if (num2 != 2496321123U)
												{
													if (num2 != 2527167325U)
													{
														if (num2 != 2564648390U)
														{
															continue;
														}
														if (Operators.CompareString(name2, "Lon", false) == 0)
														{
															goto IL_15FA;
														}
														continue;
													}
													else
													{
														if (Operators.CompareString(name2, "TerrainFollowing", false) == 0)
														{
															aircraft.vmethod_77(aircraft, Conversions.ToBoolean(xmlNode9.InnerText));
															continue;
														}
														continue;
													}
												}
												else
												{
													if (Operators.CompareString(name2, "RangeSymbols", false) != 0)
													{
														continue;
													}
													try
													{
														foreach (object obj11 in xmlNode9.ChildNodes)
														{
															RangeSymbol item = RangeSymbol.smethod_0((XmlNode)obj11, dictionary_0);
															aircraft.method_17().Add(item);
														}
														continue;
													}
													finally
													{
														IEnumerator enumerator11;
														if (enumerator11 is IDisposable)
														{
															(enumerator11 as IDisposable).Dispose();
														}
													}
												}
											}
											if (num2 <= 2691982084U)
											{
												if (num2 != 2571339398U)
												{
													if (num2 != 2590053246U)
													{
														if (num2 != 2691982084U)
														{
															continue;
														}
														if (Operators.CompareString(name2, "DesiredAltitude_TerrainFollowing", false) == 0)
														{
															aircraft.vmethod_75(XmlConvert.ToSingle(xmlNode9.InnerText));
															continue;
														}
														continue;
													}
													else
													{
														if (Operators.CompareString(name2, "Side", false) == 0)
														{
															aircraft.string_7 = xmlNode9.InnerText;
															continue;
														}
														continue;
													}
												}
												else
												{
													if (Operators.CompareString(name2, "Aircraft_CommStuff", false) == 0)
													{
														goto IL_173E;
													}
													continue;
												}
											}
											else if (num2 != 2715347842U)
											{
												if (num2 != 2749693904U)
												{
													if (num2 != 2834497881U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "SBPF_Altitude", false) == 0)
													{
														aircraft.float_22 = XmlConvert.ToSingle(xmlNode9.InnerText);
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "DesiredSpeed", false) == 0)
													{
														goto IL_17B1;
													}
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "Aircraft_AI", false) == 0)
												{
													goto IL_17DA;
												}
												continue;
											}
										}
										IL_15FA:
										aircraft.double_1 = XmlConvert.ToDouble(xmlNode9.InnerText.Replace(",", "."));
										continue;
									}
									if (num2 <= 3251319825U)
									{
										if (num2 <= 2923116889U)
										{
											if (num2 <= 2874698282U)
											{
												if (num2 != 2844845263U)
												{
													if (num2 != 2874698282U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "AssignedTaskPool", false) == 0 && xmlNode9.HasChildNodes)
													{
														XmlNode xmlNode11 = xmlNode9.ChildNodes[0];
														aircraft.string_5 = xmlNode11.InnerText;
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "SBEO_Altitude", false) == 0)
													{
														aircraft.float_20 = XmlConvert.ToSingle(xmlNode9.InnerText);
														continue;
													}
													continue;
												}
											}
											else if (num2 != 2904824734U)
											{
												if (num2 != 2920208772U)
												{
													if (num2 != 2923116889U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "SBR_ThrottleSetting", false) != 0)
													{
														continue;
													}
													string innerText2 = xmlNode9.InnerText;
													if (Operators.CompareString(innerText2, "FullStop", false) == 0)
													{
														aircraft.throttle_1 = ActiveUnit.Throttle.FullStop;
														continue;
													}
													if (Operators.CompareString(innerText2, "Loiter", false) == 0)
													{
														aircraft.throttle_1 = ActiveUnit.Throttle.Loiter;
														continue;
													}
													if (Operators.CompareString(innerText2, "Cruise", false) == 0)
													{
														aircraft.throttle_1 = ActiveUnit.Throttle.Cruise;
														continue;
													}
													if (Operators.CompareString(innerText2, "Full", false) == 0)
													{
														aircraft.throttle_1 = ActiveUnit.Throttle.Full;
														continue;
													}
													if (Operators.CompareString(innerText2, "Flank", false) != 0)
													{
														aircraft.throttle_1 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode9.InnerText);
														continue;
													}
													aircraft.throttle_1 = ActiveUnit.Throttle.Flank;
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Message", false) == 0)
													{
														aircraft.string_3 = xmlNode9.InnerText;
														continue;
													}
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "SBEO_Altitude_TF", false) == 0)
												{
													aircraft.float_21 = XmlConvert.ToSingle(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (num2 <= 3164489068U)
										{
											if (num2 != 3001749054U)
											{
												if (num2 != 3070770765U)
												{
													if (num2 != 3164489068U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "AMP_OC", false) == 0)
													{
														aircraft.bool_17 = Conversions.ToBoolean(xmlNode9.InnerText);
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "SBR_Altitude", false) == 0)
													{
														aircraft.float_17 = XmlConvert.ToSingle(xmlNode9.InnerText);
														continue;
													}
													continue;
												}
											}
											else if (Operators.CompareString(name2, "Lat", false) != 0)
											{
												continue;
											}
										}
										else if (num2 != 3189373444U)
										{
											if (num2 != 3204468496U)
											{
												if (num2 != 3251319825U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "SBR_TF", false) == 0)
												{
													aircraft.bool_19 = Conversions.ToBoolean(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBEO", false) == 0)
												{
													aircraft._ActiveUnitStatus_4 = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "LonLR", false) == 0)
											{
												aircraft.method_59(new double?(XmlConvert.ToDouble(xmlNode9.InnerText.Replace(",", "."))));
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 3636905136U)
									{
										if (num2 <= 3389022305U)
										{
											if (num2 != 3283119613U)
											{
												if (num2 != 3370184216U)
												{
													if (num2 != 3389022305U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "SBED", false) == 0)
													{
														aircraft._ActiveUnitStatus_3 = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode9.InnerText);
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "DesiredTurnRate", false) == 0)
													{
														goto IL_1BC0;
													}
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "CurrentSpeed", false) == 0)
												{
													goto IL_1BE9;
												}
												continue;
											}
										}
										else if (num2 != 3533666526U)
										{
											if (num2 != 3559367371U)
											{
												if (num2 != 3636905136U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Weaponry", false) == 0)
												{
													goto IL_1C35;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBEO_ThrottleSetting", false) != 0)
												{
													continue;
												}
												string innerText3 = xmlNode9.InnerText;
												if (Operators.CompareString(innerText3, "FullStop", false) == 0)
												{
													aircraft.throttle_3 = ActiveUnit.Throttle.FullStop;
													continue;
												}
												if (Operators.CompareString(innerText3, "Loiter", false) == 0)
												{
													aircraft.throttle_3 = ActiveUnit.Throttle.Loiter;
													continue;
												}
												if (Operators.CompareString(innerText3, "Cruise", false) == 0)
												{
													aircraft.throttle_3 = ActiveUnit.Throttle.Cruise;
													continue;
												}
												if (Operators.CompareString(innerText3, "Full", false) == 0)
												{
													aircraft.throttle_3 = ActiveUnit.Throttle.Full;
													continue;
												}
												if (Operators.CompareString(innerText3, "Flank", false) != 0)
												{
													aircraft.throttle_3 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode9.InnerText);
													continue;
												}
												aircraft.throttle_3 = ActiveUnit.Throttle.Flank;
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "Navigator", false) == 0)
											{
												goto IL_1D1B;
											}
											continue;
										}
									}
									else if (num2 <= 3792306253U)
									{
										if (num2 != 3736393060U)
										{
											if (num2 != 3766013955U)
											{
												if (num2 != 3792306253U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Longitude_UnitEntersAreaCheck", false) == 0)
												{
													aircraft.vmethod_37(new double?(XmlConvert.ToDouble(xmlNode9.InnerText)));
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Loadout", false) == 0)
												{
													if (bool_42)
													{
														aircraft.method_168(Loadout.smethod_4(xmlNode9.ChildNodes[0], dictionary_0, ref aircraft, ref scenario_1));
														bool bool_43;
														if (aircraft.method_167() != null && aircraft.method_167().bool_11)
														{
															bool_43 = true;
														}
														aircraft.method_168(null);
														int int_ = Conversions.ToInteger(Misc.smethod_44(xmlNode9.ChildNodes[0].ChildNodes, "DBID").InnerText);
														DBFunctions.smethod_48(ref aircraft, int_, bool_43);
													}
													else
													{
														aircraft.method_168(Loadout.smethod_4(xmlNode9.ChildNodes[0], dictionary_0, ref aircraft, ref scenario_1));
													}
													aircraft.method_159().vmethod_7();
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "ParentGroup", false) == 0)
											{
												aircraft.string_6 = xmlNode9.InnerText;
												continue;
											}
											continue;
										}
									}
									else if (num2 != 3956256525U)
									{
										if (num2 != 4080539297U)
										{
											if (num2 != 4152621540U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "CurrentHeading", false) == 0)
											{
												goto IL_1E93;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "IsAutoDetectable", false) == 0)
											{
												goto IL_1EB6;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "AbnTime", false) == 0)
										{
											goto IL_1EDA;
										}
										continue;
									}
									IL_1A78:
									aircraft.double_0 = XmlConvert.ToDouble(xmlNode9.InnerText.Replace(",", "."));
									continue;
									IL_1E93:
									aircraft.vmethod_10(XmlConvert.ToSingle(xmlNode9.InnerText));
									continue;
								}
								if (num2 <= 788394383U)
								{
									if (num2 <= 454106749U)
									{
										if (num2 > 273958740U)
										{
											if (num2 <= 392185441U)
											{
												if (num2 != 276801030U)
												{
													if (num2 != 334092753U)
													{
														if (num2 != 392185441U)
														{
															continue;
														}
														if (Operators.CompareString(name2, "AirOps", false) != 0)
														{
															continue;
														}
														goto IL_1586;
													}
													else if (Operators.CompareString(name2, "DTN", false) != 0)
													{
														continue;
													}
												}
												else
												{
													if (Operators.CompareString(name2, "AirborneTime", false) != 0)
													{
														continue;
													}
													goto IL_1EDA;
												}
											}
											else if (num2 != 429749699U)
											{
												if (num2 != 441941816U)
												{
													if (num2 != 454106749U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "SBPF_TF", false) == 0)
													{
														aircraft.bool_22 = Conversions.ToBoolean(xmlNode9.InnerText);
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "CurrentAltitude", false) != 0)
													{
														continue;
													}
													goto IL_146B;
												}
											}
											else if (Operators.CompareString(name2, "DesiredTurnRate_Navigation", false) != 0)
											{
												continue;
											}
											aircraft.vmethod_81((Waypoint.Enum81)Conversions.ToByte(xmlNode9.InnerText));
											continue;
										}
										if (num2 <= 93925113U)
										{
											if (num2 != 6222351U)
											{
												if (num2 != 93925113U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Thr", false) != 0)
												{
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "Status", false) != 0)
												{
													continue;
												}
												if (Versioned.IsNumeric(xmlNode9.InnerText))
												{
													aircraft.vmethod_109((ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode9.InnerText));
												}
												else
												{
													aircraft.vmethod_109((ActiveUnit._ActiveUnitStatus)Enum.Parse(typeof(ActiveUnit._ActiveUnitStatus), xmlNode9.InnerText, true));
												}
												if (aircraft.vmethod_108() == (ActiveUnit._ActiveUnitStatus)9)
												{
													aircraft.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB);
												}
												if (aircraft._ActiveUnitStatus_0 != ActiveUnit._ActiveUnitStatus.Refuelling)
												{
													if (aircraft._ActiveUnitStatus_0 != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
													{
														if (aircraft._ActiveUnitStatus_0 == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
														{
															if (aircraft._ActiveUnitStatus_3 == ActiveUnit._ActiveUnitStatus.Unassigned)
															{
																aircraft._ActiveUnitStatus_3 = ActiveUnit._ActiveUnitStatus.Unassigned;
																aircraft.throttle_2 = ActiveUnit.Throttle.Cruise;
																aircraft.float_19 = aircraft.vmethod_14(false);
																aircraft.nullable_14 = new float?(0f);
																aircraft.bool_20 = false;
																continue;
															}
															continue;
														}
														else if (aircraft._ActiveUnitStatus_0 == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
														{
															if (aircraft._ActiveUnitStatus_4 == ActiveUnit._ActiveUnitStatus.Unassigned)
															{
																aircraft._ActiveUnitStatus_4 = ActiveUnit._ActiveUnitStatus.Unassigned;
																aircraft.throttle_3 = ActiveUnit.Throttle.Cruise;
																aircraft.float_20 = aircraft.vmethod_14(false);
																aircraft.float_21 = 0f;
																aircraft.bool_21 = false;
																continue;
															}
															continue;
														}
														else
														{
															if (aircraft.vmethod_108() == ActiveUnit._ActiveUnitStatus.WaitForPathfinder && aircraft._ActiveUnitStatus_4 == ActiveUnit._ActiveUnitStatus.Unassigned)
															{
																aircraft._ActiveUnitStatus_4 = ActiveUnit._ActiveUnitStatus.Unassigned;
																aircraft.throttle_3 = ActiveUnit.Throttle.Cruise;
																aircraft.float_20 = aircraft.vmethod_14(false);
																aircraft.float_21 = 0f;
																aircraft.bool_21 = false;
																continue;
															}
															continue;
														}
													}
												}
												if (aircraft._ActiveUnitStatus_2 == ActiveUnit._ActiveUnitStatus.Unassigned)
												{
													aircraft._ActiveUnitStatus_2 = ActiveUnit._ActiveUnitStatus.Unassigned;
													aircraft.throttle_1 = ActiveUnit.Throttle.Cruise;
													aircraft.float_17 = aircraft.vmethod_14(false);
													aircraft.float_18 = 0f;
													aircraft.bool_19 = false;
													continue;
												}
												continue;
											}
										}
										else if (num2 != 263373746U)
										{
											if (num2 != 266367750U)
											{
												if (num2 != 273958740U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "AMP_OC_Speed", false) == 0)
												{
													aircraft.float_16 = XmlConvert.ToSingle(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Name", false) == 0)
												{
													aircraft.Name = xmlNode9.InnerText;
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "FSBR", false) == 0)
											{
												aircraft._ActiveUnitFuelState_1 = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode9.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 575329799U)
									{
										if (num2 <= 485784328U)
										{
											if (num2 != 468031071U)
											{
												if (num2 != 485784328U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "IsAD", false) != 0)
												{
													continue;
												}
												goto IL_1EB6;
											}
											else
											{
												if (Operators.CompareString(name2, "SBED_Altitude_TF", false) == 0 && Conversions.ToSingle(xmlNode9.InnerText) != 0f)
												{
													aircraft.nullable_14 = new float?(XmlConvert.ToSingle(xmlNode9.InnerText));
													continue;
												}
												continue;
											}
										}
										else if (num2 != 506380204U)
										{
											if (num2 != 525186425U)
											{
												if (num2 != 575329799U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "FlightRole", false) == 0)
												{
													aircraft.enum106_0 = (Mission.Flight.Enum106)Conversions.ToByte(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Aircraft_Sensory", false) != 0)
												{
													continue;
												}
												goto IL_15B0;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "LatLR", false) == 0)
											{
												aircraft.method_57(new double?(XmlConvert.ToDouble(xmlNode9.InnerText.Replace(",", "."))));
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 664498478U)
									{
										if (num2 != 601166687U)
										{
											if (num2 != 634280640U)
											{
												if (num2 != 664498478U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "FuelState", false) == 0)
												{
													aircraft._ActiveUnitFuelState_0 = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "DS", false) != 0)
												{
													continue;
												}
												goto IL_17B1;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "AI", false) != 0)
											{
												continue;
											}
											goto IL_17DA;
										}
									}
									else if (num2 != 751723973U)
									{
										if (num2 != 771216480U)
										{
											if (num2 != 788394383U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "Kinematics", false) != 0)
											{
												continue;
											}
											goto IL_1539;
										}
										else
										{
											if (Operators.CompareString(name2, "Damage", false) != 0)
											{
												continue;
											}
											goto IL_13A7;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "DT", false) != 0)
										{
											continue;
										}
										goto IL_1BC0;
									}
								}
								else if (num2 <= 1143797280U)
								{
									if (num2 > 882606391U)
									{
										if (num2 <= 967155461U)
										{
											if (num2 != 892023141U)
											{
												if (num2 != 936277782U)
												{
													if (num2 != 967155461U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "SBPF_ThrottleSetting", false) != 0)
													{
														continue;
													}
													string innerText4 = xmlNode9.InnerText;
													if (Operators.CompareString(innerText4, "FullStop", false) == 0)
													{
														aircraft.throttle_4 = ActiveUnit.Throttle.FullStop;
														continue;
													}
													if (Operators.CompareString(innerText4, "Loiter", false) == 0)
													{
														aircraft.throttle_4 = ActiveUnit.Throttle.Loiter;
														continue;
													}
													if (Operators.CompareString(innerText4, "Cruise", false) == 0)
													{
														aircraft.throttle_4 = ActiveUnit.Throttle.Cruise;
														continue;
													}
													if (Operators.CompareString(innerText4, "Full", false) == 0)
													{
														aircraft.throttle_4 = ActiveUnit.Throttle.Full;
														continue;
													}
													if (Operators.CompareString(innerText4, "Flank", false) != 0)
													{
														aircraft.throttle_4 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode9.InnerText);
														continue;
													}
													aircraft.throttle_4 = ActiveUnit.Throttle.Flank;
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "DA", false) != 0)
													{
														continue;
													}
													goto IL_1442;
												}
											}
											else if (Operators.CompareString(name2, "DesiredHeading", false) != 0)
											{
												continue;
											}
										}
										else if (num2 != 1087276353U)
										{
											if (num2 != 1099941372U)
											{
												if (num2 != 1143797280U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "SBR_Altitude_TF", false) == 0)
												{
													aircraft.float_18 = XmlConvert.ToSingle(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBPF_Altitude_TF", false) == 0)
												{
													aircraft.float_23 = XmlConvert.ToSingle(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (Operators.CompareString(name2, "DH", false) != 0)
										{
											continue;
										}
										aircraft.vmethod_69(ActiveUnit.Enum28.const_0, XmlConvert.ToSingle(xmlNode9.InnerText));
										continue;
									}
									if (num2 <= 812114866U)
									{
										if (num2 != 803760973U)
										{
											if (num2 != 812114866U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "COA", false) == 0)
											{
												aircraft.int_5 = Conversions.ToInteger(xmlNode9.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "DamagePts", false) != 0 || bool_42)
											{
												continue;
											}
											float num4 = XmlConvert.ToSingle(xmlNode9.InnerText);
											if ((int)Math.Round((double)num4) > 50 || (int)Math.Round((double)num4) > aircraft.method_60())
											{
												aircraft.vmethod_64(false, null, (float)aircraft.method_60());
												continue;
											}
											if ((int)Math.Round((double)num4) == 0)
											{
												aircraft.vmethod_64(false, null, (float)aircraft.method_60());
												continue;
											}
											aircraft.vmethod_64(false, null, num4);
											continue;
										}
									}
									else if (num2 != 827630232U)
									{
										if (num2 != 877330709U)
										{
											if (num2 != 882606391U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "AMP_OC_DAO", false) == 0)
											{
												aircraft.bool_18 = Conversions.ToBoolean(xmlNode9.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "Aircraft_Weaponry", false) != 0)
											{
												continue;
											}
											goto IL_1C35;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "SBED_Altitude", false) == 0)
										{
											aircraft.float_19 = XmlConvert.ToSingle(xmlNode9.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num2 <= 1422437055U)
								{
									if (num2 <= 1255847155U)
									{
										if (num2 != 1156592502U)
										{
											if (num2 != 1255847155U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "ThrottleSetting", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "SBR", false) == 0)
											{
												aircraft._ActiveUnitStatus_2 = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode9.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (num2 != 1259548010U)
										{
											if (num2 != 1339890663U)
											{
												if (num2 != 1422437055U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Doctrine", false) == 0)
												{
													aircraft.doctrine_0 = Doctrine.smethod_9(ref xmlNode9, aircraft);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "ActiveEnterAreaTriggers", false) != 0)
												{
													continue;
												}
												try
												{
													foreach (object obj12 in xmlNode9.ChildNodes)
													{
														string innerText5 = ((XmlNode)obj12).InnerText;
														aircraft.list_0.Add(innerText5);
													}
													continue;
												}
												finally
												{
													IEnumerator enumerator12;
													if (enumerator12 is IDisposable)
													{
														(enumerator12 as IDisposable).Dispose();
													}
												}
											}
										}
										if (Operators.CompareString(name2, "SBED_ThrottleSetting", false) != 0)
										{
											continue;
										}
										string innerText6 = xmlNode9.InnerText;
										if (Operators.CompareString(innerText6, "FullStop", false) == 0)
										{
											aircraft.throttle_2 = ActiveUnit.Throttle.FullStop;
											continue;
										}
										if (Operators.CompareString(innerText6, "Loiter", false) == 0)
										{
											aircraft.throttle_2 = ActiveUnit.Throttle.Loiter;
											continue;
										}
										if (Operators.CompareString(innerText6, "Cruise", false) == 0)
										{
											aircraft.throttle_2 = ActiveUnit.Throttle.Cruise;
											continue;
										}
										if (Operators.CompareString(innerText6, "Full", false) == 0)
										{
											aircraft.throttle_2 = ActiveUnit.Throttle.Full;
											continue;
										}
										if (Operators.CompareString(innerText6, "Flank", false) != 0)
										{
											aircraft.throttle_2 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode9.InnerText);
											continue;
										}
										aircraft.throttle_2 = ActiveUnit.Throttle.Flank;
										continue;
									}
								}
								else if (num2 <= 1476905714U)
								{
									if (num2 != 1444793274U)
									{
										if (num2 != 1459814733U)
										{
											if (num2 != 1476905714U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "WeaponState", false) == 0)
											{
												aircraft._ActiveUnitWeaponState_0 = (ActiveUnit._ActiveUnitWeaponState)Conversions.ToByte(xmlNode9.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "Aircraft_Navigator", false) != 0)
											{
												continue;
											}
											goto IL_1D1B;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "Prof", false) == 0)
										{
											aircraft.vmethod_54(new GlobalVariables.ProficiencyLevel?((GlobalVariables.ProficiencyLevel)Conversions.ToInteger(xmlNode9.InnerText)));
											continue;
										}
										continue;
									}
								}
								else if (num2 != 1488303767U)
								{
									if (num2 != 1614652377U)
									{
										if (num2 != 1708783731U)
										{
											continue;
										}
										if (Operators.CompareString(name2, "CS", false) != 0)
										{
											continue;
										}
										goto IL_1BE9;
									}
									else
									{
										if (Operators.CompareString(name2, "CommStuff", false) != 0)
										{
											continue;
										}
										goto IL_173E;
									}
								}
								else
								{
									if (Operators.CompareString(name2, "SBEO_TF", false) == 0)
									{
										aircraft.bool_21 = Conversions.ToBoolean(xmlNode9.InnerText);
										continue;
									}
									continue;
								}
								string innerText7 = xmlNode9.InnerText;
								if (Operators.CompareString(innerText7, "FullStop", false) != 0)
								{
									if (Operators.CompareString(innerText7, "Loiter", false) != 0)
									{
										if (Operators.CompareString(innerText7, "Cruise", false) != 0)
										{
											if (Operators.CompareString(innerText7, "Full", false) != 0)
											{
												if (Operators.CompareString(innerText7, "Flank", false) != 0)
												{
													aircraft.throttle_0 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode9.InnerText);
												}
												else
												{
													aircraft.throttle_0 = ActiveUnit.Throttle.Flank;
												}
											}
											else
											{
												aircraft.throttle_0 = ActiveUnit.Throttle.Full;
											}
										}
										else
										{
											aircraft.throttle_0 = ActiveUnit.Throttle.Cruise;
										}
									}
									else
									{
										aircraft.throttle_0 = ActiveUnit.Throttle.Loiter;
									}
								}
								else
								{
									aircraft.throttle_0 = ActiveUnit.Throttle.FullStop;
								}
								if (aircraft.throttle_0 == ActiveUnit.Throttle.FullStop && !aircraft.method_150(false))
								{
									aircraft.throttle_0 = ActiveUnit.Throttle.Cruise;
									continue;
								}
								continue;
								IL_13A7:
								Aircraft aircraft3 = aircraft;
								ActiveUnit activeUnit = aircraft;
								aircraft3.aircraft_Damage_0 = Aircraft_Damage.smethod_1(ref xmlNode9, ref dictionary_0, ref activeUnit);
								continue;
								IL_1442:
								aircraft.vmethod_73(XmlConvert.ToSingle(xmlNode9.InnerText));
								continue;
								IL_146B:
								aircraft.vmethod_15(true, XmlConvert.ToSingle(xmlNode9.InnerText));
								continue;
								IL_1539:
								ActiveUnit_Kinematics.smethod_0(xmlNode9, dictionary_0, aircraft);
								continue;
								IL_1586:
								Aircraft aircraft4 = aircraft;
								activeUnit = aircraft;
								aircraft4.aircraft_AirOps_0 = Aircraft_AirOps.smethod_7(ref xmlNode9, ref dictionary_0, ref activeUnit);
								continue;
								IL_15B0:
								Aircraft aircraft5 = aircraft;
								activeUnit = aircraft;
								aircraft5.class218_0 = Class218.smethod_10(ref xmlNode9, ref dictionary_0, ref activeUnit);
								continue;
								IL_173E:
								Aircraft aircraft6 = aircraft;
								activeUnit = aircraft;
								aircraft6.class180_0 = Class180.smethod_1(ref xmlNode9, ref dictionary_0, ref activeUnit);
								continue;
								IL_17B1:
								aircraft.vmethod_71(XmlConvert.ToSingle(xmlNode9.InnerText));
								continue;
								IL_17DA:
								Aircraft aircraft7 = aircraft;
								activeUnit = aircraft;
								aircraft7.aircraft_AI_0 = Aircraft_AI.smethod_1(ref xmlNode9, ref dictionary_0, ref activeUnit);
								if (aircraft.vmethod_76(aircraft) && aircraft.vmethod_74() == 0f)
								{
									aircraft.vmethod_75(60.96f);
									continue;
								}
								continue;
								IL_1BC0:
								aircraft.vmethod_79((ActiveUnit.Enum28)Conversions.ToByte(xmlNode9.InnerText));
								continue;
								IL_1BE9:
								aircraft.vmethod_41(XmlConvert.ToSingle(xmlNode9.InnerText));
								continue;
								IL_1C35:
								Aircraft aircraft8 = aircraft;
								activeUnit = aircraft;
								aircraft8.aircraft_Weaponry_0 = Aircraft_Weaponry.smethod_6(ref xmlNode9, ref dictionary_0, ref activeUnit);
								continue;
								IL_1D1B:
								Aircraft aircraft9 = aircraft;
								activeUnit = aircraft;
								aircraft9.class211_0 = Class211.smethod_8(ref xmlNode9, ref dictionary_0, ref activeUnit);
								continue;
								IL_1EB6:
								aircraft.method_93(null, Conversions.ToBoolean(xmlNode9.InnerText));
								continue;
								IL_1EDA:
								aircraft.float_26 = XmlConvert.ToSingle(xmlNode9.InnerText);
							}
						}
						finally
						{
							IEnumerator enumerator10;
							if (enumerator10 is IDisposable)
							{
								(enumerator10 as IDisposable).Dispose();
							}
						}
						float num5 = aircraft.method_159().vmethod_30();
						if (aircraft.vmethod_14(false) > num5)
						{
							aircraft.vmethod_15(false, num5);
						}
						if (aircraft.vmethod_72() > num5)
						{
							aircraft.vmethod_73(num5);
						}
						if (!bool_42 && array.Length > 0)
						{
							try
							{
								foreach (Sensor sensor2 in array)
								{
									foreach (Sensor sensor3 in aircraft.vmethod_96())
									{
										if (sensor3.DBID == sensor2.DBID && sensor2.method_43())
										{
											sensor3.method_77();
										}
									}
								}
							}
							catch (Exception ex3)
							{
								ex3.Data.Add("Error at 200019", ex3.Message);
								GameGeneral.smethod_25(ref ex3);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
							}
						}
						result = aircraft;
					}
				}
			}
			catch (Exception ex4)
			{
				ex4.Data.Add("Error at 100350", "");
				GameGeneral.smethod_25(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x000D5DAC File Offset: 0x000D3FAC
		public override bool vmethod_6()
		{
			return !(this.method_144() | this.method_145() | this.method_169());
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x000084BD File Offset: 0x000066BD
		public override float vmethod_139()
		{
			return this.float_13 * this.float_27;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x000041ED File Offset: 0x000023ED
		public override GlobalVariables.ActiveUnitType vmethod_56()
		{
			return GlobalVariables.ActiveUnitType.Aircraft;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x000D5DD8 File Offset: 0x000D3FD8
		public override bool vmethod_59()
		{
			bool result;
			if (this.method_167() != null)
			{
				result = (this.method_167().loadoutRole_0 == Loadout.LoadoutRole.MineSweeping);
			}
			else
			{
				result = (this._AircraftType_0 == Aircraft._AircraftType.MCM);
			}
			return result;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x000D5E14 File Offset: 0x000D4014
		public override bool vmethod_60()
		{
			return this.method_167() != null && this.method_167().loadoutRole_0 == Loadout.LoadoutRole.NavalMineLaying;
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x000D5E44 File Offset: 0x000D4044
		public override bool vmethod_55()
		{
			bool result;
			if (this.vmethod_127())
			{
				result = true;
			}
			else
			{
				Aircraft_AirOps._AirOpsCondition airOpsCondition = this.method_164().method_36();
				if (airOpsCondition != Aircraft_AirOps._AirOpsCondition.Parked)
				{
					if (airOpsCondition != Aircraft_AirOps._AirOpsCondition.Readying)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x000D5E7C File Offset: 0x000D407C
		public override bool vmethod_128()
		{
			return !this.vmethod_127() && this.method_164().method_34() != null && this.method_164().method_34().method_33();
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00003024 File Offset: 0x00001224
		public override int vmethod_131(bool bool_42)
		{
			return 0;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00003024 File Offset: 0x00001224
		public override int vmethod_132(Weapon._WeaponType _WeaponType_0, bool bool_42)
		{
			return 0;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x000D5EC0 File Offset: 0x000D40C0
		public override void vmethod_122(ref Scenario scenario_1, Dictionary<string, Class310> dictionary_0, List<ActiveUnit> list_3, bool bool_42)
		{
			try
			{
				base.vmethod_122(ref scenario_1, dictionary_0, list_3, bool_42);
				if (this.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Parked && this.method_164().method_30() == null && this.method_164().method_34() == null)
				{
					Class429.smethod_1(ref this.vmethod_7(false).activeUnit_0, this);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100351", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x000084CC File Offset: 0x000066CC
		public override ActiveUnit._ActiveUnitStatus vmethod_108()
		{
			return base.vmethod_108();
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x000D5F5C File Offset: 0x000D415C
		public override void vmethod_109(ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_6)
		{
			try
			{
				if (_ActiveUnitStatus_6 != this.vmethod_108() && _ActiveUnitStatus_6 == ActiveUnit._ActiveUnitStatus.RTB && (this.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IsBingo || this.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IsJoker))
				{
					this.method_142();
				}
				base.vmethod_109(_ActiveUnitStatus_6);
				if (_ActiveUnitStatus_6 == ActiveUnit._ActiveUnitStatus.Refuelling)
				{
					this.method_164().method_37(Aircraft_AirOps._AirOpsCondition.Refuelling);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100352", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x000D5FF4 File Offset: 0x000D41F4
		public void method_142()
		{
			try
			{
				if (this.method_146())
				{
					List<string> list = new List<string>();
					list.AddRange(this.aircraft_AirOps_0.concurrentDictionary_0.Keys);
					try
					{
						foreach (string text in list)
						{
							if (this.scenario_0.vmethod_0().ContainsKey(text))
							{
								((Aircraft)this.scenario_0.vmethod_0()[text]).aircraft_AirOps_0.method_45();
							}
							else
							{
								ConcurrentDictionary<string, byte> concurrentDictionary_ = this.aircraft_AirOps_0.concurrentDictionary_0;
								string text2 = text;
								byte b = 0;
								concurrentDictionary_.TryRemove(text2, ref b);
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					List<KeyValuePair<string, Aircraft_AirOps.Enum43>> list2 = new List<KeyValuePair<string, Aircraft_AirOps.Enum43>>();
					list2.AddRange(this.aircraft_AirOps_0.concurrentDictionary_1);
					try
					{
						foreach (KeyValuePair<string, Aircraft_AirOps.Enum43> keyValuePair in list2)
						{
							if (this.scenario_0.vmethod_0().ContainsKey(keyValuePair.Key))
							{
								((Aircraft)this.scenario_0.vmethod_0()[keyValuePair.Key]).aircraft_AirOps_0.method_45();
							}
							else
							{
								ConcurrentDictionary<string, Aircraft_AirOps.Enum43> concurrentDictionary_2 = this.aircraft_AirOps_0.concurrentDictionary_1;
								string key = keyValuePair.Key;
								Aircraft_AirOps.Enum43 @enum = Aircraft_AirOps.Enum43.const_0;
								concurrentDictionary_2.TryRemove(key, ref @enum);
							}
						}
					}
					finally
					{
						List<KeyValuePair<string, Aircraft_AirOps.Enum43>>.Enumerator enumerator2;
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

		// Token: 0x06000B5C RID: 2908 RVA: 0x000D61C8 File Offset: 0x000D43C8
		public bool method_143()
		{
			checked
			{
				bool result;
				if (this.method_167() == null)
				{
					result = false;
				}
				else
				{
					WeaponRec[] weaponRec_ = this.method_167().weaponRec_0;
					for (int i = 0; i < weaponRec_.Length; i++)
					{
						if (weaponRec_[i].method_12(this.scenario_0).method_167() == Weapon._WeaponType.BuddyStore)
						{
							return true;
						}
					}
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x000D6220 File Offset: 0x000D4420
		public override bool vmethod_105(ActiveUnit activeUnit_1)
		{
			checked
			{
				bool result;
				try
				{
					if (!activeUnit_1.bool_3)
					{
						result = false;
					}
					else
					{
						Aircraft aircraft = (Aircraft)activeUnit_1;
						if (this.bool_31 && aircraft.bool_28)
						{
							result = true;
						}
						else if ((this.bool_29 || this.bool_30) && aircraft.bool_27)
						{
							result = true;
						}
						else
						{
							if (aircraft.bool_27 && this.method_167() != null)
							{
								WeaponRec[] weaponRec_ = this.method_167().weaponRec_0;
								for (int i = 0; i < weaponRec_.Length; i++)
								{
									if (weaponRec_[i].method_12(this.scenario_0).method_167() == Weapon._WeaponType.BuddyStore)
									{
										return true;
									}
								}
							}
							result = false;
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100353", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				return result;
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x000D6314 File Offset: 0x000D4514
		public override bool vmethod_107(ActiveUnit activeUnit_1, Aircraft_AirOps aircraft_AirOps_1, float float_35, bool bool_42)
		{
			bool result;
			try
			{
				int num;
				foreach (FuelRec fuelRec in this.vmethod_67())
				{
					num = (int)Math.Round((double)((float)num + fuelRec.float_0));
				}
				int num2 = 0;
				ActiveUnit activeUnit = this.method_164().method_21();
				if (activeUnit != null)
				{
					float float_36 = base.method_36(activeUnit);
					Class211 @class = this.method_157();
					bool flag = false;
					float num3 = @class.method_73(ref flag);
					float value = (float)this.method_159().vmethod_40(num3, ActiveUnit.Throttle.Cruise, false);
					num2 = (int)Math.Round((double)this.method_159().method_4(float_36, ActiveUnit.Throttle.Cruise, num3, new float?(value), false, false, false));
				}
				if ((float)(num - num2 - (int)Math.Round((double)this.method_159().vmethod_4()) - aircraft_AirOps_1.method_23(activeUnit_1, activeUnit_1.vmethod_65(false), bool_42)) < (float)activeUnit_1.vmethod_115() * float_35)
				{
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100354", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x000084D4 File Offset: 0x000066D4
		public bool method_144()
		{
			return this.enum40_0 == Aircraft.Enum40.const_6;
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x000084E3 File Offset: 0x000066E3
		public bool method_145()
		{
			return this.enum40_0 == Aircraft.Enum40.const_6 && this._AircraftType_0 == Aircraft._AircraftType.AirShip;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x000D643C File Offset: 0x000D463C
		public bool method_146()
		{
			return this._AircraftType_0 == Aircraft._AircraftType.Tanker || (this.method_167() != null && this.method_167().loadoutRole_0 == Loadout.LoadoutRole.AirRefueling);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x000D6480 File Offset: 0x000D4680
		public Aircraft_AirOps.Enum44 method_147(ref string string_9)
		{
			Aircraft_AirOps.Enum44 result;
			if (this.method_167() != null)
			{
				if (this.method_167().loadoutRole_0 == Loadout.LoadoutRole.Unavailable)
				{
					result = Aircraft_AirOps.Enum44.const_2;
				}
				else if (this.method_167().loadoutRole_0 == Loadout.LoadoutRole.Reserve)
				{
					result = Aircraft_AirOps.Enum44.const_3;
				}
				else
				{
					ActiveUnit._ActiveUnitWeaponState activeUnitWeaponState = this.method_161().vmethod_5();
					if (activeUnitWeaponState != ActiveUnit._ActiveUnitWeaponState.None && activeUnitWeaponState != ActiveUnit._ActiveUnitWeaponState.IgnoreWinchesterAndShotgun)
					{
						result = Aircraft_AirOps.Enum44.const_1;
					}
					else
					{
						result = Aircraft_AirOps.Enum44.const_0;
					}
				}
			}
			else
			{
				result = Aircraft_AirOps.Enum44.const_4;
			}
			return result;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x000D64E0 File Offset: 0x000D46E0
		public string method_148()
		{
			string result;
			if (this.method_167() != null)
			{
				if (this.method_167().bool_13)
				{
					Doctrine.Enum53? @enum = this.doctrine_0.method_196(this.scenario_0, false, false, false, false);
					byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						result = "Disabled (Doctrine)";
					}
					else
					{
						@enum = this.doctrine_0.method_196(this.scenario_0, false, false, false, false);
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							Loadout loadout = this.method_167();
							if (!loadout.method_10() && !loadout.method_12() && !loadout.method_11())
							{
								return "Disabled (Doctrine)";
							}
						}
						Aircraft_AirOps aircraft_AirOps = this.method_164();
						if (aircraft_AirOps.bool_0)
						{
							result = string.Concat(new string[]
							{
								"Enabled, ",
								Misc.smethod_28(this.method_167()._LoadoutDayNight_1),
								": ",
								Conversions.ToString(aircraft_AirOps.int_1),
								" / ",
								Conversions.ToString(aircraft_AirOps.int_2),
								" sorties, ",
								Misc.smethod_11((long)Math.Round((double)aircraft_AirOps.float_1), Aircraft_AirOps.Enum44.const_0, false, true),
								" / ",
								Misc.smethod_11((long)(this.method_167().int_12 * 60), Aircraft_AirOps.Enum44.const_0, true, false),
								" flying time, ",
								Misc.smethod_11((long)(aircraft_AirOps.int_3 * 60), Aircraft_AirOps.Enum44.const_0, true, false),
								" downtime"
							});
						}
						else
						{
							result = "-";
						}
					}
				}
				else
				{
					result = "-";
				}
			}
			else
			{
				result = "-";
			}
			return result;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00008501 File Offset: 0x00006701
		public override float vmethod_72()
		{
			return base.vmethod_72();
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00008509 File Offset: 0x00006709
		public override void vmethod_73(float float_35)
		{
			if (float_35 < 6.0959997f)
			{
				float_35 = 6.0959997f;
			}
			base.vmethod_73(float_35);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00008521 File Offset: 0x00006721
		public override float vmethod_74()
		{
			return base.vmethod_74();
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00008529 File Offset: 0x00006729
		public override void vmethod_75(float float_35)
		{
			if (float_35 != 0f)
			{
				base.vmethod_75(float_35);
				if (!base.method_15())
				{
					this.vmethod_73(float_35);
				}
			}
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x000D66FC File Offset: 0x000D48FC
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
				result = this.double_1;
			}
			else
			{
				ActiveUnit activeUnit = this.method_164().method_30();
				if (activeUnit == null)
				{
					result = 0.0;
				}
				else
				{
					result = activeUnit.vmethod_28(null);
				}
			}
			return result;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00008549 File Offset: 0x00006749
		public override void vmethod_29(bool? _HintIsOperating = null, double value)
		{
			this.double_1 = value;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x000783F4 File Offset: 0x000765F4
		private CommDevice[] method_149()
		{
			CommDevice[] array = new CommDevice[this.commDevice_0.Length - 1 + 1];
			if (this.commDevice_0.Length > 0)
			{
				Array.Copy(this.commDevice_0, array, this.commDevice_0.Length);
			}
			return array;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x000D675C File Offset: 0x000D495C
		public override CommDevice[] vmethod_94()
		{
			CommDevice[] result;
			try
			{
				if (this.method_167() == null)
				{
					result = this.commDevice_0;
				}
				else
				{
					CommDevice[] array = null;
					int num = Enumerable.Count<WeaponRec>(this.method_167().weaponRec_0) - 1;
					for (int i = 0; i <= num; i++)
					{
						WeaponRec weaponRec = this.method_167().weaponRec_0[i];
						if (weaponRec.method_12(this.scenario_0).method_167() == Weapon._WeaponType.SensorPod)
						{
							int num2 = weaponRec.method_12(this.scenario_0).vmethod_94().Length - 1;
							for (int j = 0; j <= num2; j++)
							{
								if (array == null)
								{
									array = this.method_149();
								}
								CommDevice commDevice_ = weaponRec.method_12(this.scenario_0).vmethod_94()[j];
								Class429.smethod_9(ref array, commDevice_);
							}
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
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100355", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x000D6878 File Offset: 0x000D4A78
		public override ActiveUnit.Throttle vmethod_82()
		{
			ActiveUnit.Throttle result;
			if (this.method_152())
			{
				result = ActiveUnit.Throttle.Flank;
			}
			else
			{
				result = ActiveUnit.Throttle.Full;
			}
			return result;
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x000D6894 File Offset: 0x000D4A94
		public override GlobalVariables.TargetVisualSizeClass vmethod_121()
		{
			float float_ = this.float_13;
			GlobalVariables.TargetVisualSizeClass result;
			if (float_ > 40f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VLarge;
			}
			else if (float_ > 30f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Large;
			}
			else if (float_ > 25f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Medium;
			}
			else if (float_ > 10f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Small;
			}
			else if (float_ > 5f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VSmall;
			}
			else
			{
				result = GlobalVariables.TargetVisualSizeClass.Stealthy;
			}
			return result;
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x000D68E8 File Offset: 0x000D4AE8
		public bool method_150(bool bool_42)
		{
			Aircraft.Enum40 @enum = this.enum40_0;
			return @enum - Aircraft.Enum40.const_3 <= 1 || (bool_42 && this.enum146_0 == GlobalVariables.Enum146.const_1);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00008552 File Offset: 0x00006752
		public override float vmethod_24()
		{
			return base.vmethod_24();
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0000855A File Offset: 0x0000675A
		public override void vmethod_25(float float_35)
		{
			base.vmethod_25(float_35);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00008563 File Offset: 0x00006763
		public override float vmethod_22()
		{
			return base.vmethod_22();
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0000856B File Offset: 0x0000676B
		public override void vmethod_23(float float_35)
		{
			base.vmethod_23(float_35);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00008574 File Offset: 0x00006774
		public override float vmethod_18()
		{
			return base.vmethod_18();
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0000857C File Offset: 0x0000677C
		public override void vmethod_19(float float_35)
		{
			base.vmethod_19(float_35);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x000D6920 File Offset: 0x000D4B20
		public float method_151()
		{
			float num = this.vmethod_14(false) - base.method_18();
			float result;
			if (num == 0f)
			{
				result = 0f;
			}
			else
			{
				double x = (double)Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), this.vmethod_34(), this.vmethod_32()) * 1852.0;
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
			return result;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00008585 File Offset: 0x00006785
		public override float vmethod_20()
		{
			return base.vmethod_20();
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0000858D File Offset: 0x0000678D
		public override void vmethod_21(float float_35)
		{
			base.vmethod_21(float_35);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00008596 File Offset: 0x00006796
		public override float vmethod_40()
		{
			return base.vmethod_40();
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0000859E File Offset: 0x0000679E
		public override void vmethod_41(float float_35)
		{
			base.vmethod_41(float_35);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x000D69B4 File Offset: 0x000D4BB4
		public override float vmethod_14(bool DoSanityCheck = false)
		{
			float result;
			if (!this.vmethod_127())
			{
				if (this.method_164().method_30() != null)
				{
					result = this.method_164().method_30().vmethod_14(false);
				}
				else
				{
					result = (float)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false);
				}
			}
			else
			{
				result = base.vmethod_14(false);
			}
			return result;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x000D6A1C File Offset: 0x000D4C1C
		public override void vmethod_15(bool DoSanityCheck = false, float value)
		{
			try
			{
				if (DoSanityCheck)
				{
					short num = Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false);
					if (value < (float)(num + 1))
					{
						value = (float)(num + 1);
						if (this.vmethod_18() < 0f)
						{
							this.vmethod_19(0f);
						}
					}
				}
				base.vmethod_15(DoSanityCheck, value);
				checked
				{
					if (this.method_167() != null)
					{
						WeaponRec[] weaponRec_ = this.method_167().weaponRec_0;
						for (int i = 0; i < weaponRec_.Length; i++)
						{
							weaponRec_[i].method_12(this.scenario_0).vmethod_15(false, value);
						}
					}
				}
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

		// Token: 0x06000B7C RID: 2940 RVA: 0x000D6B00 File Offset: 0x000D4D00
		public override long vmethod_114(ActiveUnit.Throttle throttle_5, AltBand altBand_0, float? nullable_17, float? nullable_18)
		{
			long result;
			try
			{
				if (this._AircraftType_0 == Aircraft._AircraftType.Aerostat)
				{
					result = long.MaxValue;
				}
				else
				{
					float num;
					foreach (FuelRec fuelRec in this.vmethod_67())
					{
						num += fuelRec.float_0;
					}
					if (throttle_5 == ActiveUnit.Throttle.FullStop)
					{
						result = 2147483647L;
					}
					else
					{
						float num2 = this.vmethod_98(throttle_5, altBand_0, nullable_17, nullable_18, false, false, false, false, false);
						if (num2 == 0f)
						{
							result = long.MaxValue;
						}
						else
						{
							result = (long)Math.Round((double)(num / num2));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100356", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 2147483647L;
			}
			return result;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x000D6BE4 File Offset: 0x000D4DE4
		public override void vmethod_134(ActiveUnit.Throttle newThrottleSetting, float? SpecificDesiredSpeed = null)
		{
			try
			{
				if (newThrottleSetting == ActiveUnit.Throttle.Flank && !this.method_152())
				{
					newThrottleSetting = ActiveUnit.Throttle.Full;
				}
				if (!this.method_169() && newThrottleSetting == ActiveUnit.Throttle.FullStop)
				{
					newThrottleSetting = ActiveUnit.Throttle.Loiter;
				}
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
							this.vmethod_71((float)this.method_159().vmethod_40(this.vmethod_14(false), this.throttle_0, false));
						}
						else if (this.method_159().vmethod_1() == ActiveUnit_Kinematics.UnitThrottlePreset.None)
						{
							float? num = SpecificDesiredSpeed;
							float num2 = (float)this.method_159().vmethod_40(this.vmethod_14(false), newThrottleSetting, false);
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
								num2 = (float)this.method_159().vmethod_33((float)((int)Math.Round((double)this.vmethod_14(false))), newThrottleSetting, false);
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
								this.throttle_0 = this.method_159().vmethod_41(this.vmethod_14(false), SpecificDesiredSpeed.Value);
								num = SpecificDesiredSpeed;
								num2 = (float)this.method_159().vmethod_40(this.vmethod_14(false), this.throttle_0, false);
								if (((num != null) ? new bool?(num.GetValueOrDefault() > num2) : null).GetValueOrDefault())
								{
									this.vmethod_71((float)this.method_159().vmethod_40(this.vmethod_14(false), this.throttle_0, false));
								}
							}
						}
						else
						{
							this.vmethod_71((float)this.method_159().vmethod_40(this.vmethod_14(false), (ActiveUnit.Throttle)this.method_159().vmethod_1(), false));
						}
					}
					base.method_110(this, this.throttle_0);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100357", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x000D6ED8 File Offset: 0x000D50D8
		private bool method_152()
		{
			bool result;
			try
			{
				foreach (AltBand altBand in this.vmethod_49()[0].altBand_0)
				{
					if (altBand.nullable_3 != null && altBand.nullable_1 != null)
					{
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100358", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x000D6F74 File Offset: 0x000D5174
		public bool method_153()
		{
			ActiveUnit._ActiveUnitStatus activeUnitStatus = this.vmethod_108();
			if (activeUnitStatus <= ActiveUnit._ActiveUnitStatus.RTB_Manual)
			{
				if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.RTB || activeUnitStatus == ActiveUnit._ActiveUnitStatus.RTB_Manual)
				{
					goto IL_2C;
				}
			}
			else if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.OnFerryMission || activeUnitStatus == ActiveUnit._ActiveUnitStatus.RTB_MissionOver || activeUnitStatus - ActiveUnit._ActiveUnitStatus.RTB_Group <= 1)
			{
				goto IL_2C;
			}
			return false;
			IL_2C:
			return true;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x000D6FB0 File Offset: 0x000D51B0
		public override ActiveUnit._ActiveUnitFuelState vmethod_62(ActiveUnit activeUnit_1, GeoPoint geoPoint_0, Doctrine._FuelState? nullable_17)
		{
			List<Waypoint> list = new List<Waypoint>();
			ActiveUnit._ActiveUnitFuelState result;
			try
			{
				if (activeUnit_1 == null)
				{
					this.float_32 = 0f;
					this.activeUnit_0 = null;
					result = ActiveUnit._ActiveUnitFuelState.None;
				}
				else if (Enumerable.Count<FuelRec>(this.vmethod_67()) == 0)
				{
					result = ActiveUnit._ActiveUnitFuelState.IsBingo;
				}
				else
				{
					if (geoPoint_0 == null)
					{
						float f;
						if (activeUnit_1.method_111())
						{
							if (!this.method_169())
							{
								Geopoint_Struct geopoint_Struct = activeUnit_1.vmethod_92().method_5();
								float num = Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), geopoint_Struct.double_1, geopoint_Struct.double_0);
								float num2 = Math2.smethod_15(activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), geopoint_Struct.double_1, geopoint_Struct.double_0);
								if (float.IsNaN(num) || float.IsNaN(num2))
								{
									return ActiveUnit._ActiveUnitFuelState.None;
								}
								f = num + num2;
							}
							else
							{
								f = base.method_36(activeUnit_1);
								if (float.IsNaN(f))
								{
									return ActiveUnit._ActiveUnitFuelState.None;
								}
							}
						}
						else
						{
							f = base.method_36(activeUnit_1);
							if (float.IsNaN(f))
							{
								return ActiveUnit._ActiveUnitFuelState.None;
							}
						}
						this.float_32 = f;
						this.activeUnit_0 = activeUnit_1;
					}
					else
					{
						float num5;
						if (activeUnit_1.method_111())
						{
							if (!this.method_169())
							{
								Geopoint_Struct geopoint_Struct2 = activeUnit_1.vmethod_92().method_5();
								float num3 = Math2.smethod_15(geoPoint_0.imethod_2(), geoPoint_0.imethod_0(), geopoint_Struct2.double_1, geopoint_Struct2.double_0);
								float num4 = Math2.smethod_15(activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), geopoint_Struct2.double_1, geopoint_Struct2.double_0);
								if (float.IsNaN(num3) || float.IsNaN(num4))
								{
									return ActiveUnit._ActiveUnitFuelState.None;
								}
								num5 = num3 + num4;
							}
							else
							{
								num5 = Math2.smethod_15(geoPoint_0.imethod_2(), geoPoint_0.imethod_0(), activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null));
								if (float.IsNaN(num5))
								{
									return ActiveUnit._ActiveUnitFuelState.None;
								}
							}
						}
						else
						{
							num5 = activeUnit_1.method_23(geoPoint_0);
							if (float.IsNaN(num5))
							{
								return ActiveUnit._ActiveUnitFuelState.None;
							}
						}
						float num6 = base.method_23(geoPoint_0);
						this.float_32 = num6 + num5;
						this.activeUnit_0 = activeUnit_1;
					}
					if (!activeUnit_1.bool_3 && ((this.method_157().method_49() && Enumerable.Count<Waypoint>(this.method_157().method_4()) > 0 && this.method_157().method_4()[Enumerable.Count<Waypoint>(this.method_157().method_4()) - 1].waypointType_0 == Waypoint.WaypointType.Land) || (base.method_121() && this.vmethod_65(false).method_147() != null && this.vmethod_65(false).method_147().vmethod_85().method_49() && Enumerable.Count<Waypoint>(this.vmethod_65(false).method_147().vmethod_85().method_4()) > 0 && this.vmethod_65(false).method_147().vmethod_85().method_4()[Enumerable.Count<Waypoint>(this.vmethod_65(false).method_147().vmethod_85().method_4()) - 1].waypointType_0 == Waypoint.WaypointType.Land)))
					{
						Doctrine.Enum56? @enum = this.doctrine_0.method_152(this.scenario_0, false, false, false, false);
						Waypoint.WaypointType? nullable_18;
						Aircraft aircraft;
						checked
						{
							if (this.method_157().method_49() && Enumerable.Count<Waypoint>(this.method_157().method_4()) > 0)
							{
								if (base.method_121())
								{
									foreach (Waypoint waypoint in this.method_157().method_4())
									{
										if (waypoint.waypointType_0 != Waypoint.WaypointType.PathfindingPoint)
										{
											list.Add(waypoint);
										}
									}
									Waypoint waypoint2 = Enumerable.LastOrDefault<Waypoint>(list);
									bool flag = false;
									Waypoint[] array2 = this.method_157().method_7().method_15();
									int j = 0;
									while (j < array2.Length)
									{
										Waypoint waypoint3 = array2[j];
										if (flag)
										{
											list.Add(waypoint3);
											goto IL_49C;
										}
										if (waypoint3.enum83_0 == Waypoint.Enum83.const_2 || !waypoint3.method_21())
										{
											goto IL_49C;
										}
										if (waypoint3.waypoint_0 != null && waypoint3.waypoint_0 == waypoint2)
										{
											flag = true;
										}
										else if (waypoint3.waypoint_1 != null && waypoint3.waypoint_1 == waypoint2)
										{
											flag = true;
										}
										else if (waypoint3.waypoint_2 != null && waypoint3.waypoint_2 == waypoint2)
										{
											flag = true;
										}
										else if (waypoint3.waypoint_3 != null && waypoint3.waypoint_3 == waypoint2)
										{
											flag = true;
										}
										else
										{
											if (waypoint3.waypoint_4 == null || waypoint3.waypoint_4 != waypoint2)
											{
												goto IL_49C;
											}
											flag = true;
										}
										IL_58A:
										j++;
										continue;
										IL_49C:
										if (@enum == null)
										{
											goto IL_579;
										}
										byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
										if (!((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											goto IL_579;
										}
										Doctrine.Enum56? enum2 = waypoint3.method_18().method_152(this.scenario_0, false, false, false, false);
										b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
										bool? flag2 = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
										bool? flag3 = (flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2;
										IL_57F:
										flag2 = flag3;
										if (!flag2.GetValueOrDefault())
										{
											goto IL_58A;
										}
										break;
										IL_579:
										flag3 = new bool?(false);
										goto IL_57F;
									}
									nullable_18 = this.method_157().nullable_5;
									aircraft = this;
								}
								else
								{
									foreach (Waypoint waypoint4 in this.method_157().method_4())
									{
										if (waypoint4.waypointType_0 != Waypoint.WaypointType.PathfindingPoint)
										{
											list.Add(waypoint4);
											if (@enum == null)
											{
												goto IL_6BF;
											}
											byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
											if (!((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
											{
												goto IL_6BF;
											}
											Doctrine.Enum56? enum2 = waypoint4.method_18().method_152(this.scenario_0, false, false, false, false);
											b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
											bool? flag2 = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
											bool? flag4 = (flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2;
											IL_6C5:
											flag2 = flag4;
											if (!flag2.GetValueOrDefault())
											{
												goto IL_6D0;
											}
											break;
											IL_6BF:
											flag4 = new bool?(false);
											goto IL_6C5;
										}
										IL_6D0:;
									}
									nullable_18 = this.method_157().nullable_5;
									aircraft = this;
								}
							}
							else
							{
								foreach (Waypoint waypoint5 in this.vmethod_65(false).method_147().vmethod_85().method_4())
								{
									if (waypoint5.waypointType_0 != Waypoint.WaypointType.PathfindingPoint)
									{
										list.Add(waypoint5);
										if (@enum == null)
										{
											goto IL_810;
										}
										byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
										if (!((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											goto IL_810;
										}
										Doctrine.Enum56? enum2 = waypoint5.method_18().method_152(this.scenario_0, false, false, false, false);
										b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
										bool? flag2 = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
										bool? flag5 = (flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2;
										IL_816:
										flag2 = flag5;
										if (!flag2.GetValueOrDefault())
										{
											goto IL_821;
										}
										break;
										IL_810:
										flag5 = new bool?(false);
										goto IL_816;
									}
									IL_821:;
								}
								nullable_18 = this.vmethod_65(false).method_147().vmethod_85().nullable_5;
								aircraft = (Aircraft)this.vmethod_65(false).method_147();
							}
						}
						if (list.Count == 0)
						{
							result = ActiveUnit._ActiveUnitFuelState.None;
						}
						else
						{
							float num7;
							float float_;
							float num8;
							int num9;
							if (list[0].waypointType_0 == Waypoint.WaypointType.StationEnd && list.Count > 1)
							{
								num7 = base.method_23(list[1]);
								float_ = list[1].float_2;
								num8 = list[1].float_9 + list[1].float_10;
								num9 = 1;
							}
							else
							{
								if (nullable_18 != null)
								{
									int? num10 = (nullable_18 != null) ? new int?((int)nullable_18.GetValueOrDefault()) : null;
									if (((num10 != null) ? new bool?(num10.GetValueOrDefault() == 24) : null).GetValueOrDefault() && list[0].method_40() && list.Count > 1 && list[1].waypointType_0 == Waypoint.WaypointType.StationEnd)
									{
										num7 = base.method_23(list[2]);
										if (list.Count == 0)
										{
											return ActiveUnit._ActiveUnitFuelState.None;
										}
										float_ = list[2].float_2;
										num8 = list[2].float_9 + list[2].float_10;
										num9 = 2;
										goto IL_A18;
									}
								}
								if (!base.method_86() && aircraft != null)
								{
									aircraft.method_157().method_79(ref list, false, true);
									aircraft.method_164().method_46(ref list, false, true);
									num9 = 0;
								}
								if (list.Count == 0)
								{
									return ActiveUnit._ActiveUnitFuelState.None;
								}
								float_ = list[num9].float_2;
								num8 = list[num9].float_9 + list[num9].float_10;
								num7 = base.method_23(list[num9]);
							}
							IL_A18:
							float num11 = 0f;
							if (num8 > 0f)
							{
								num11 = float_ / num8 * num7;
							}
							if (list.Count >= num9 + 1)
							{
								int num12 = num9 + 1;
								int num13 = list.Count - 1;
								for (int m = num12; m <= num13; m++)
								{
									Waypoint waypoint6 = list[m];
									num11 += waypoint6.float_2;
								}
							}
							float num14;
							foreach (FuelRec fuelRec in this.vmethod_67())
							{
								num14 += fuelRec.float_0;
							}
							num14 -= this.method_159().vmethod_4();
							float num15 = num14 - this.method_159().vmethod_6();
							if (num14 < 0f)
							{
								byte? b = (nullable_17 != null) ? new byte?((byte)nullable_17.GetValueOrDefault()) : null;
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									this.float_33 = 0f;
									this.float_34 = 0f;
									return ActiveUnit._ActiveUnitFuelState.IsBingo;
								}
							}
							if (num14 < num11)
							{
								this.float_33 = 0f;
								this.float_34 = 0f;
								result = ActiveUnit._ActiveUnitFuelState.IsBingo;
							}
							else if (num15 < num11)
							{
								this.float_33 = num14 - num11;
								this.float_34 = 0f;
								result = ActiveUnit._ActiveUnitFuelState.IsJoker;
							}
							else
							{
								this.float_33 = num14 - num11;
								this.float_34 = num15 - num11;
								if (this.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IsBingo)
								{
									if ((double)num14 * 0.9 >= (double)num11)
									{
										result = ActiveUnit._ActiveUnitFuelState.None;
									}
									else
									{
										result = ActiveUnit._ActiveUnitFuelState.IsBingo;
									}
								}
								else
								{
									result = ActiveUnit._ActiveUnitFuelState.None;
								}
							}
						}
					}
					else
					{
						if (geoPoint_0 == null)
						{
							float f2;
							if (activeUnit_1.method_111())
							{
								if (!this.method_169())
								{
									Geopoint_Struct geopoint_Struct3 = activeUnit_1.vmethod_92().method_5();
									float num16 = Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), geopoint_Struct3.double_1, geopoint_Struct3.double_0);
									float num17 = Math2.smethod_15(activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), geopoint_Struct3.double_1, geopoint_Struct3.double_0);
									if (float.IsNaN(num16) || float.IsNaN(num17))
									{
										return ActiveUnit._ActiveUnitFuelState.None;
									}
									f2 = num16 + num17;
								}
								else
								{
									f2 = base.method_36(activeUnit_1);
									if (float.IsNaN(f2))
									{
										return ActiveUnit._ActiveUnitFuelState.None;
									}
								}
							}
							else
							{
								f2 = base.method_36(activeUnit_1);
								if (float.IsNaN(f2))
								{
									return ActiveUnit._ActiveUnitFuelState.None;
								}
							}
							this.float_32 = f2;
							this.activeUnit_0 = activeUnit_1;
						}
						else
						{
							float num20;
							if (activeUnit_1.method_111())
							{
								if (!this.method_169())
								{
									Geopoint_Struct geopoint_Struct4 = activeUnit_1.vmethod_92().method_5();
									float num18 = Math2.smethod_15(geoPoint_0.imethod_2(), geoPoint_0.imethod_0(), geopoint_Struct4.double_1, geopoint_Struct4.double_0);
									float num19 = Math2.smethod_15(activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), geopoint_Struct4.double_1, geopoint_Struct4.double_0);
									if (float.IsNaN(num18) || float.IsNaN(num19))
									{
										return ActiveUnit._ActiveUnitFuelState.None;
									}
									num20 = num18 + num19;
								}
								else
								{
									num20 = Math2.smethod_15(geoPoint_0.imethod_2(), geoPoint_0.imethod_0(), activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null));
									if (float.IsNaN(num20))
									{
										return ActiveUnit._ActiveUnitFuelState.None;
									}
								}
							}
							else
							{
								num20 = activeUnit_1.method_23(geoPoint_0);
								if (float.IsNaN(num20))
								{
									return ActiveUnit._ActiveUnitFuelState.None;
								}
							}
							float num21 = base.method_23(geoPoint_0);
							this.float_32 = num21 + num20;
							this.activeUnit_0 = activeUnit_1;
						}
						double num22 = (double)this.method_159().vmethod_29(nullable_17);
						if (this.vmethod_114(ActiveUnit.Throttle.Cruise, null, null, null) <= 900L)
						{
							result = ActiveUnit._ActiveUnitFuelState.IsBingo;
						}
						else
						{
							int num23 = (int)Math.Round(Math.Min(2000.0, (double)this.vmethod_67()[0].int_0 * 0.05));
							if (this.vmethod_67()[0].float_0 < (float)num23)
							{
								result = ActiveUnit._ActiveUnitFuelState.IsBingo;
							}
							else
							{
								if (activeUnit_1.bool_3)
								{
									if (((Aircraft)activeUnit_1).method_146())
									{
										num22 *= 0.7;
									}
								}
								else if (this.vmethod_84() == ActiveUnit.Throttle.Flank)
								{
									num22 *= 0.9;
								}
								else if (this.method_167() != null && this.method_167().loadoutRole_0 == Loadout.LoadoutRole.AirRefueling)
								{
									num22 *= 0.9;
								}
								if (num22 >= (double)this.float_32)
								{
									if (this.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IsBingo)
									{
										if (num22 * 0.9 >= (double)this.float_32)
										{
											result = ActiveUnit._ActiveUnitFuelState.None;
										}
										else
										{
											result = ActiveUnit._ActiveUnitFuelState.IsBingo;
										}
									}
									else
									{
										result = ActiveUnit._ActiveUnitFuelState.None;
									}
								}
								else
								{
									byte? b = (nullable_17 != null) ? new byte?((byte)nullable_17.GetValueOrDefault()) : null;
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										result = ActiveUnit._ActiveUnitFuelState.IsBingo;
									}
									else if (this.float_33 <= 0f)
									{
										result = ActiveUnit._ActiveUnitFuelState.IsBingo;
									}
									else
									{
										result = ActiveUnit._ActiveUnitFuelState.IsJoker;
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100359", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = ActiveUnit._ActiveUnitFuelState.None;
			}
			return result;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x000D7F78 File Offset: 0x000D6178
		public override ActiveUnit._ActiveUnitFuelState vmethod_61(GeoPoint geoPoint_0, Doctrine._FuelState? nullable_17)
		{
			ActiveUnit._ActiveUnitFuelState result;
			try
			{
				if (this.method_144())
				{
					result = ActiveUnit._ActiveUnitFuelState.None;
				}
				else
				{
					Aircraft aircraft = null;
					bool? flag = null;
					ActiveUnit activeUnit = this.method_164().method_21();
					if (activeUnit == null)
					{
						result = ActiveUnit._ActiveUnitFuelState.None;
					}
					else if (activeUnit.method_82())
					{
						result = ActiveUnit._ActiveUnitFuelState.None;
					}
					else
					{
						if (this.vmethod_101() != null)
						{
							Doctrine.Enum56? @enum = this.doctrine_0.method_152(this.scenario_0, false, false, false, false);
							byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								if (!this.method_157().method_32() && (!base.method_121() || this.vmethod_65(false).method_147() == null || !this.vmethod_65(false).method_147().vmethod_85().method_32()))
								{
									flag = new bool?(false);
								}
							}
							else
							{
								@enum = this.doctrine_0.method_152(this.scenario_0, false, false, false, false);
								b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault() && this._AircraftType_0 == Aircraft._AircraftType.Tanker)
								{
									flag = new bool?(false);
								}
							}
						}
						if (flag == null && this.method_155())
						{
							bool flag2 = false;
							if (this._AircraftType_0 == Aircraft._AircraftType.Tanker && this.vmethod_101() != null)
							{
								Mission._MissionClass missionClass_ = this.vmethod_101()._MissionClass_0;
								if (missionClass_ != Mission._MissionClass.Strike)
								{
									flag2 = true;
								}
							}
							if (!flag2)
							{
								Aircraft_AirOps aircraft_AirOps = this.method_164();
								bool flag3 = false;
								ActiveUnit activeUnit2 = null;
								bool bool_ = true;
								List<Mission> list_ = null;
								string text = "";
								List<Aircraft> list = aircraft_AirOps.method_78(ref flag3, ref activeUnit2, bool_, list_, ref text);
								if (list.Count == 0)
								{
									flag = new bool?(false);
								}
								else if (this.method_153())
								{
									flag = new bool?(false);
								}
								else if (!this.method_157().method_23() && (!base.method_120() || this.vmethod_65(false).method_147() == null || !this.vmethod_65(false).method_147().vmethod_85().method_23()))
								{
									aircraft = Enumerable.ElementAtOrDefault<Aircraft>(Enumerable.OrderBy<Aircraft, double>(list, new Func<Aircraft, double>(this.method_181)), 0);
									byte? b = (nullable_17 != null) ? new byte?((byte)nullable_17.GetValueOrDefault()) : null;
									bool? flag4 = (b != null) ? new bool?(b.GetValueOrDefault() == 13) : null;
									if (((flag4 != null) ? new bool?(!flag4.GetValueOrDefault()) : flag4).GetValueOrDefault())
									{
										if ((double)base.method_36(aircraft) * 0.7 < (double)base.method_36(activeUnit))
										{
											flag = new bool?(true);
										}
										else
										{
											flag = new bool?(false);
										}
									}
									else if (base.method_36(aircraft) < base.method_36(activeUnit))
									{
										flag = new bool?(true);
									}
									else
									{
										flag = new bool?(false);
									}
								}
								else
								{
									double num;
									if (this.method_157().method_49() && Enumerable.Count<Waypoint>(this.method_157().method_4()) > 0 && this.method_157().method_4()[Enumerable.Count<Waypoint>(this.method_157().method_4()) - 1].waypointType_0 == Waypoint.WaypointType.Land)
									{
										num = (double)base.method_23(this.method_157().method_4()[0]);
										int num2 = Enumerable.Count<Waypoint>(this.method_157().method_4()) - 1;
										for (int i = 1; i <= num2; i++)
										{
											Waypoint waypoint = this.method_157().method_4()[i];
											num += (double)(waypoint.float_9 + waypoint.float_10);
										}
									}
									else
									{
										num = (double)base.method_36(activeUnit);
									}
									flag = new bool?(false);
									aircraft = list[0];
									if (list.Count == 1)
									{
										if ((double)base.method_36(list[0]) < num)
										{
											flag = new bool?(true);
										}
									}
									else
									{
										double num3 = (double)base.method_36(list[0]);
										if (num3 < num)
										{
											flag = new bool?(true);
										}
										try
										{
											foreach (Aircraft aircraft2 in list)
											{
												if (aircraft2 != list[0])
												{
													double num4 = (double)base.method_36(aircraft2);
													if (num4 <= num && num4 < num3)
													{
														aircraft = aircraft2;
														flag = new bool?(true);
													}
												}
											}
										}
										finally
										{
											List<Aircraft>.Enumerator enumerator;
											((IDisposable)enumerator).Dispose();
										}
									}
								}
							}
						}
						if (flag.GetValueOrDefault())
						{
							result = this.vmethod_62(aircraft, null, nullable_17);
						}
						else
						{
							ActiveUnit._ActiveUnitFuelState activeUnitFuelState = this.vmethod_62(activeUnit, null, nullable_17);
							if (activeUnitFuelState == ActiveUnit._ActiveUnitFuelState.IsBingo || activeUnitFuelState == ActiveUnit._ActiveUnitFuelState.IsJoker)
							{
								Aircraft_AirOps aircraft_AirOps2 = this.method_164();
								if (aircraft_AirOps2.method_24() != null)
								{
									aircraft_AirOps2.method_45();
								}
								if (this.method_164().method_36() != Aircraft_AirOps._AirOpsCondition.EmergencyLanding && this.float_32 < 20f)
								{
									float num5 = (float)this.vmethod_114(this.vmethod_84(), null, new float?(this.vmethod_40()), new float?(this.vmethod_14(false))) * this.vmethod_40() / 3600f;
									if ((double)this.float_32 >= (double)num5 * 1.5)
									{
										if (this.method_157().method_47())
										{
											if (this.method_157().method_4()[0].waypointType_0 == Waypoint.WaypointType.LandingMarshal || this.method_157().method_4()[0].waypointType_0 == Waypoint.WaypointType.Land)
											{
												this.method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
												this.method_164().method_37(Aircraft_AirOps._AirOpsCondition.EmergencyLanding);
											}
										}
										else
										{
											this.method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
											this.method_164().method_37(Aircraft_AirOps._AirOpsCondition.EmergencyLanding);
										}
									}
								}
							}
							result = activeUnitFuelState;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200329", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = ActiveUnit._ActiveUnitFuelState.None;
			}
			return result;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x000D85CC File Offset: 0x000D67CC
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
				result = this.double_0;
			}
			else
			{
				ActiveUnit activeUnit = this.method_164().method_30();
				if (activeUnit == null)
				{
					result = 0.0;
				}
				else
				{
					result = activeUnit.vmethod_30(null);
				}
			}
			return result;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x000085A7 File Offset: 0x000067A7
		public override void vmethod_31(bool? _HintIsOperating = null, double value)
		{
			this.double_0 = value;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x000D862C File Offset: 0x000D682C
		public bool method_154()
		{
			Aircraft.Enum40 @enum = this.enum40_0;
			return @enum - Aircraft.Enum40.const_3 <= 1 || this.enum146_0 == GlobalVariables.Enum146.const_1;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x000085B0 File Offset: 0x000067B0
		public bool method_155()
		{
			return this.bool_27 || this.bool_28;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x000D8660 File Offset: 0x000D6860
		public override FuelRec[] vmethod_67()
		{
			FuelRec[] array = new FuelRec[0];
			FuelRec[] result;
			try
			{
				foreach (FuelRec fuelRec_2 in this.fuelRec_0)
				{
					Class429.smethod_19(ref array, fuelRec_2);
				}
				if (this.method_167() != null)
				{
					foreach (WeaponRec weaponRec in this.method_167().weaponRec_0)
					{
						if (weaponRec.method_12(this.scenario_0).method_214())
						{
							int num = weaponRec.method_9();
							for (int k = 1; k <= num; k++)
							{
								Class429.smethod_19(ref array, weaponRec.method_12(this.scenario_0).vmethod_67()[0]);
							}
						}
					}
				}
				result = array;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100361", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x000D8760 File Offset: 0x000D6960
		public override int vmethod_115()
		{
			int result;
			try
			{
				int num;
				foreach (FuelRec fuelRec in this.vmethod_67())
				{
					num += fuelRec.int_0;
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100362", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x000D87E0 File Offset: 0x000D69E0
		public override int vmethod_116()
		{
			int result;
			try
			{
				int num;
				foreach (FuelRec fuelRec in this.vmethod_67())
				{
					num = (int)Math.Round((double)((float)num + fuelRec.float_0));
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100363", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x000D8868 File Offset: 0x000D6A68
		public void method_156(float float_35)
		{
			try
			{
				FuelRec fuelRec = this.fuelRec_0[0];
				if (float_35 >= (float)fuelRec.int_0)
				{
					fuelRec.float_0 = (float)fuelRec.int_0;
					float_35 -= (float)fuelRec.int_0;
				}
				else
				{
					fuelRec.float_0 = float_35;
					float_35 = 0f;
				}
				if (this.method_167() != null)
				{
					foreach (WeaponRec weaponRec in this.method_167().weaponRec_0)
					{
						if (weaponRec.method_12(this.scenario_0).method_214())
						{
							FuelRec fuelRec2 = weaponRec.method_12(this.scenario_0).vmethod_67()[0];
							FuelRec fuelRec3 = new FuelRec(0, (short)fuelRec2._FuelType_0);
							int num = weaponRec.method_9();
							fuelRec3.int_0 = fuelRec2.int_0 * num;
							if (float_35 >= (float)fuelRec3.int_0)
							{
								fuelRec2.float_0 = (float)fuelRec2.int_0;
								float_35 -= (float)fuelRec3.int_0;
							}
							else if (float_35 > 0f)
							{
								fuelRec2.float_0 = float_35 / (float)num;
								float_35 = 0f;
							}
							else
							{
								fuelRec2.float_0 = 0f;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101227", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x000D89DC File Offset: 0x000D6BDC
		public Class211 method_157()
		{
			if (this.class211_0 == null)
			{
				ActiveUnit activeUnit = this;
				this.class211_0 = new Class211(ref activeUnit);
			}
			return this.class211_0;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x000D8A08 File Offset: 0x000D6C08
		public Aircraft_AI method_158()
		{
			if (this.aircraft_AI_0 == null)
			{
				ActiveUnit activeUnit = this;
				this.aircraft_AI_0 = new Aircraft_AI(ref activeUnit);
			}
			return this.aircraft_AI_0;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x000D8A34 File Offset: 0x000D6C34
		public Aircraft_Kinematics method_159()
		{
			if (this.aircraft_Kinematics_0 == null)
			{
				ActiveUnit activeUnit = this;
				this.aircraft_Kinematics_0 = new Aircraft_Kinematics(ref activeUnit);
			}
			return this.aircraft_Kinematics_0;
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000D8A60 File Offset: 0x000D6C60
		public Class218 method_160()
		{
			if (this.class218_0 == null)
			{
				ActiveUnit activeUnit = this;
				this.class218_0 = new Class218(ref activeUnit);
			}
			return this.class218_0;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000D8A8C File Offset: 0x000D6C8C
		public Aircraft_Weaponry method_161()
		{
			if (this.aircraft_Weaponry_0 == null)
			{
				ActiveUnit activeUnit = this;
				this.aircraft_Weaponry_0 = new Aircraft_Weaponry(ref activeUnit);
			}
			return this.aircraft_Weaponry_0;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000D8AB8 File Offset: 0x000D6CB8
		public Class180 method_162()
		{
			if (this.class180_0 == null)
			{
				ActiveUnit activeUnit = this;
				this.class180_0 = new Class180(ref activeUnit);
			}
			return this.class180_0;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000D8AE4 File Offset: 0x000D6CE4
		public Aircraft_Damage method_163()
		{
			if (this.aircraft_Damage_0 == null)
			{
				ActiveUnit activeUnit = this;
				this.aircraft_Damage_0 = new Aircraft_Damage(ref activeUnit);
			}
			return this.aircraft_Damage_0;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000D8B10 File Offset: 0x000D6D10
		public Aircraft_AirOps method_164()
		{
			if (this.aircraft_AirOps_0 == null)
			{
				ActiveUnit activeUnit = this;
				this.aircraft_AirOps_0 = new Aircraft_AirOps(ref activeUnit);
			}
			return this.aircraft_AirOps_0;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x000D8B3C File Offset: 0x000D6D3C
		public string method_165()
		{
			string result;
			if (this.loadout_0 == null)
			{
				result = "Nothing";
			}
			else
			{
				result = this.loadout_0.Name;
			}
			return result;
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x000D8B68 File Offset: 0x000D6D68
		public int method_166()
		{
			int result;
			if (this.loadout_0 == null)
			{
				result = 0;
			}
			else
			{
				result = this.loadout_0.DBID;
			}
			return result;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x000085C2 File Offset: 0x000067C2
		public Loadout method_167()
		{
			return this.loadout_0;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x000085CA File Offset: 0x000067CA
		public void method_168(Loadout loadout_1)
		{
			this.loadout_0 = loadout_1;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x000D8B90 File Offset: 0x000D6D90
		public override List<Sensor> vmethod_95()
		{
			List<Sensor> result;
			try
			{
				if (!this.vmethod_59())
				{
					result = new List<Sensor>();
				}
				else
				{
					List<Sensor> list = new List<Sensor>();
					list.AddRange(base.vmethod_95());
					try
					{
						foreach (Mount mount in this.vmethod_51())
						{
							foreach (Sensor sensor in mount.method_36())
							{
								if (sensor.method_65())
								{
									list.Add(sensor);
								}
							}
						}
					}
					finally
					{
						List<Mount>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (this.method_167() != null)
					{
						Sensor[] array2 = this.method_167().method_9(this.scenario_0);
						if (array2.Length > 0)
						{
							list.AddRange(array2);
						}
						if (this.method_167().weaponRec_0 != null)
						{
							foreach (WeaponRec weaponRec in this.method_167().weaponRec_0)
							{
								if (weaponRec.method_9() > 0)
								{
									try
									{
										foreach (Sensor sensor2 in weaponRec.method_12(this.scenario_0).vmethod_95())
										{
											if (sensor2.method_65())
											{
												list.Add(sensor2);
											}
										}
									}
									finally
									{
										List<Sensor>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
								}
							}
						}
					}
					result = list;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100364", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Sensor>();
			}
			return result;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x000D8D68 File Offset: 0x000D6F68
		public bool method_169()
		{
			Aircraft.Enum40 @enum = this.enum40_0;
			return @enum - Aircraft.Enum40.const_3 <= 1;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x000D8D90 File Offset: 0x000D6F90
		public bool method_170()
		{
			bool result;
			try
			{
				if (this.method_167() != null)
				{
					foreach (WeaponRec weaponRec in this.method_167().weaponRec_0)
					{
						if (weaponRec.method_12(this.scenario_0).method_167() == Weapon._WeaponType.SensorPod && weaponRec.method_12(this.scenario_0).struct36_0.bool_21)
						{
							return true;
						}
					}
				}
				result = this.bool_33;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100365", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x000085D3 File Offset: 0x000067D3
		public void method_171(bool bool_42)
		{
			this.bool_33 = bool_42;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x000D8E50 File Offset: 0x000D7050
		public bool method_172()
		{
			bool result;
			try
			{
				if (this.method_167() != null)
				{
					foreach (WeaponRec weaponRec in this.method_167().weaponRec_0)
					{
						if (weaponRec.method_12(this.scenario_0).method_167() == Weapon._WeaponType.SensorPod && weaponRec.method_12(this.scenario_0).struct36_0.bool_20)
						{
							return true;
						}
					}
				}
				result = this.bool_32;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100365", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x000085DC File Offset: 0x000067DC
		public void method_173(bool bool_42)
		{
			this.bool_32 = bool_42;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x000085E5 File Offset: 0x000067E5
		public override bool vmethod_76(ActiveUnit activeUnit_1)
		{
			return this.bool_34;
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x000085ED File Offset: 0x000067ED
		public override void vmethod_77(ActiveUnit activeUnit_1, bool bool_42)
		{
			this.bool_34 = bool_42;
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x000D8F10 File Offset: 0x000D7110
		public float? imethod_4()
		{
			float? result;
			try
			{
				if (this.nullable_16 != null)
				{
					result = this.nullable_16;
				}
				else
				{
					int num = base.method_9(false, false, false);
					if (num < 0)
					{
						num = 0;
					}
					bool flag = num > 0;
					Weather.WeatherProfile weatherProfile = Weather.smethod_0(this.scenario_0, this.vmethod_30(null), this.vmethod_28(null), (int)Math.Round((double)this.vmethod_14(false)));
					float num2;
					if (flag)
					{
						DateTime dateTime = this.scenario_0.method_31();
						if (Class418.smethod_1(this.scenario_0, dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, true, this.vmethod_30(null), this.vmethod_28(null), 0.0) == Weather.TTimeOfDayType.const_0)
						{
							Aircraft.Enum40 @enum = this.enum40_0;
							if (@enum != Aircraft.Enum40.const_3)
							{
								if (@enum != Aircraft.Enum40.const_4)
								{
									if (this.method_172())
									{
										num2 = 91.44f;
									}
									else if (this.method_170())
									{
										num2 = 60.96f;
									}
									else
									{
										num2 = 152.4f;
										switch (weatherProfile.int_0)
										{
										case 0:
											if (weatherProfile.float_0 < 5f && this.aircraftSizeClass_0 <= GlobalVariables.AircraftSizeClass.Large)
											{
												GlobalVariables.ProficiencyLevel? proficiencyLevel = this.vmethod_53();
												int? num3 = (proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
												if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
												{
													num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
													if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
													{
														num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
														if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
														{
															num2 = 121.92f;
														}
														else
														{
															num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
															if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
															{
																num2 = 91.44f;
															}
															else
															{
																num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
																if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
																{
																	num2 = 60.96f;
																}
															}
														}
													}
												}
											}
											break;
										case 1:
											if (weatherProfile.float_0 < 5f && this.aircraftSizeClass_0 <= GlobalVariables.AircraftSizeClass.Large)
											{
												GlobalVariables.ProficiencyLevel? proficiencyLevel2 = this.vmethod_53();
												int? num3 = (proficiencyLevel2 != null) ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null;
												if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
												{
													num3 = ((proficiencyLevel2 != null) ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
													if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
													{
														num3 = ((proficiencyLevel2 != null) ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
														if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
														{
															num2 = 121.92f;
														}
														else
														{
															num3 = ((proficiencyLevel2 != null) ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
															if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
															{
																num2 = 91.44f;
															}
															else
															{
																num3 = ((proficiencyLevel2 != null) ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
																if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
																{
																	num2 = 60.96f;
																}
															}
														}
													}
												}
											}
											break;
										case 2:
											if (weatherProfile.float_0 < 5f && this.aircraftSizeClass_0 <= GlobalVariables.AircraftSizeClass.Large)
											{
												GlobalVariables.ProficiencyLevel? proficiencyLevel3 = this.vmethod_53();
												int? num3 = (proficiencyLevel3 != null) ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null;
												if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
												{
													num3 = ((proficiencyLevel3 != null) ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
													if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
													{
														num3 = ((proficiencyLevel3 != null) ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
														if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
														{
															num2 = 121.92f;
														}
														else
														{
															num3 = ((proficiencyLevel3 != null) ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
															if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
															{
																num2 = 91.44f;
															}
															else
															{
																num3 = ((proficiencyLevel3 != null) ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
																if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
																{
																	num2 = 60.96f;
																}
															}
														}
													}
												}
											}
											break;
										case 3:
											if (weatherProfile.float_0 < 5f && this.aircraftSizeClass_0 <= GlobalVariables.AircraftSizeClass.Large)
											{
												GlobalVariables.ProficiencyLevel? proficiencyLevel4 = this.vmethod_53();
												int? num3 = (proficiencyLevel4 != null) ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null;
												if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
												{
													num3 = ((proficiencyLevel4 != null) ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
													if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
													{
														num3 = ((proficiencyLevel4 != null) ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
														if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
														{
															num2 = 121.92f;
														}
														else
														{
															num3 = ((proficiencyLevel4 != null) ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
															if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
															{
																num2 = 91.44f;
															}
															else
															{
																num3 = ((proficiencyLevel4 != null) ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
																if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
																{
																	num2 = 60.96f;
																}
															}
														}
													}
												}
											}
											break;
										case 4:
											if (weatherProfile.float_0 < 5f && this.aircraftSizeClass_0 <= GlobalVariables.AircraftSizeClass.Large)
											{
												GlobalVariables.ProficiencyLevel? proficiencyLevel5 = this.vmethod_53();
												int? num3 = (proficiencyLevel5 != null) ? new int?((int)proficiencyLevel5.GetValueOrDefault()) : null;
												if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
												{
													num3 = ((proficiencyLevel5 != null) ? new int?((int)proficiencyLevel5.GetValueOrDefault()) : null);
													if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
													{
														num3 = ((proficiencyLevel5 != null) ? new int?((int)proficiencyLevel5.GetValueOrDefault()) : null);
														if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
														{
															num2 = 121.92f;
														}
														else
														{
															num3 = ((proficiencyLevel5 != null) ? new int?((int)proficiencyLevel5.GetValueOrDefault()) : null);
															if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
															{
																num2 = 91.44f;
															}
															else
															{
																num3 = ((proficiencyLevel5 != null) ? new int?((int)proficiencyLevel5.GetValueOrDefault()) : null);
																if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
																{
																	num2 = 60.96f;
																}
															}
														}
													}
												}
											}
											break;
										case 5:
											if (weatherProfile.float_0 < 5f && this.aircraftSizeClass_0 <= GlobalVariables.AircraftSizeClass.Large)
											{
												GlobalVariables.ProficiencyLevel? proficiencyLevel6 = this.vmethod_53();
												int? num3 = (proficiencyLevel6 != null) ? new int?((int)proficiencyLevel6.GetValueOrDefault()) : null;
												if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
												{
													num3 = ((proficiencyLevel6 != null) ? new int?((int)proficiencyLevel6.GetValueOrDefault()) : null);
													if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
													{
														num3 = ((proficiencyLevel6 != null) ? new int?((int)proficiencyLevel6.GetValueOrDefault()) : null);
														if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
														{
															num2 = 121.92f;
														}
														else
														{
															num3 = ((proficiencyLevel6 != null) ? new int?((int)proficiencyLevel6.GetValueOrDefault()) : null);
															if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
															{
																num2 = 91.44f;
															}
															else
															{
																num3 = ((proficiencyLevel6 != null) ? new int?((int)proficiencyLevel6.GetValueOrDefault()) : null);
																if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
																{
																	num2 = 60.96f;
																}
															}
														}
													}
												}
											}
											break;
										case 6:
										case 7:
										case 8:
										case 9:
										case 10:
											break;
										default:
											throw new NotImplementedException();
										}
									}
								}
								else
								{
									ActiveUnit.Throttle throttle = this.vmethod_84();
									if (throttle != ActiveUnit.Throttle.FullStop)
									{
										if (throttle == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else if (this.method_172())
										{
											num2 = 91.44f;
										}
										else if (this.method_170())
										{
											num2 = 60.96f;
										}
										else
										{
											num2 = 152.4f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
								}
							}
							else
							{
								switch (weatherProfile.int_0)
								{
								case 0:
								{
									ActiveUnit.Throttle throttle2 = this.vmethod_84();
									if (throttle2 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle2 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 30.48f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 1:
								{
									ActiveUnit.Throttle throttle3 = this.vmethod_84();
									if (throttle3 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle3 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 30.48f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 2:
								{
									ActiveUnit.Throttle throttle4 = this.vmethod_84();
									if (throttle4 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle4 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 30.48f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 3:
								{
									ActiveUnit.Throttle throttle5 = this.vmethod_84();
									if (throttle5 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle5 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 30.48f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 4:
								{
									ActiveUnit.Throttle throttle6 = this.vmethod_84();
									if (throttle6 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle6 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 30.48f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 5:
								{
									ActiveUnit.Throttle throttle7 = this.vmethod_84();
									if (throttle7 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle7 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 45.72f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 6:
								{
									ActiveUnit.Throttle throttle8 = this.vmethod_84();
									if (throttle8 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle8 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 45.72f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 7:
								{
									ActiveUnit.Throttle throttle9 = this.vmethod_84();
									if (throttle9 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle9 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 60.96f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 8:
								{
									ActiveUnit.Throttle throttle10 = this.vmethod_84();
									if (throttle10 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle10 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 60.96f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 9:
								{
									ActiveUnit.Throttle throttle11 = this.vmethod_84();
									if (throttle11 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle11 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 60.96f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 10:
								{
									ActiveUnit.Throttle throttle12 = this.vmethod_84();
									if (throttle12 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle12 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 60.96f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								}
							}
						}
						else
						{
							Aircraft.Enum40 enum2 = this.enum40_0;
							if (enum2 - Aircraft.Enum40.const_3 <= 1)
							{
								ActiveUnit.Throttle throttle13 = this.vmethod_84();
								if (throttle13 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle13 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else if (this.method_172())
									{
										num2 = 91.44f;
									}
									else if (this.method_170())
									{
										num2 = 60.96f;
									}
									else
									{
										num2 = 152.4f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
							}
							else if (this.method_172())
							{
								num2 = 91.44f;
							}
							else if (this.method_170())
							{
								num2 = 60.96f;
							}
							else
							{
								num2 = 304.8f;
							}
						}
					}
					else
					{
						DateTime dateTime2 = this.scenario_0.method_31();
						if (Class418.smethod_1(this.scenario_0, dateTime2.Year, dateTime2.Month, dateTime2.Day, dateTime2.Hour, dateTime2.Minute, dateTime2.Second, true, this.vmethod_30(null), this.vmethod_28(null), 0.0) == Weather.TTimeOfDayType.const_0)
						{
							Aircraft.Enum40 enum3 = this.enum40_0;
							if (enum3 - Aircraft.Enum40.const_3 <= 1)
							{
								switch (weatherProfile.int_0)
								{
								case 0:
									num2 = 15.24f;
									break;
								case 1:
									num2 = 15.24f;
									break;
								case 2:
									num2 = 15.24f;
									break;
								case 3:
									num2 = 15.24f;
									break;
								case 4:
									num2 = 15.24f;
									break;
								case 5:
									num2 = 15.24f;
									break;
								case 6:
								{
									ActiveUnit.Throttle throttle14 = this.vmethod_84();
									if (throttle14 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle14 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 30.48f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 7:
								{
									ActiveUnit.Throttle throttle15 = this.vmethod_84();
									if (throttle15 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle15 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 30.48f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 8:
								{
									ActiveUnit.Throttle throttle16 = this.vmethod_84();
									if (throttle16 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle16 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 60.96f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 9:
								{
									ActiveUnit.Throttle throttle17 = this.vmethod_84();
									if (throttle17 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle17 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 60.96f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 10:
								{
									ActiveUnit.Throttle throttle18 = this.vmethod_84();
									if (throttle18 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle18 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 60.96f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								}
							}
							else if (!this.method_172() && !this.method_170())
							{
								num2 = 91.44f;
								switch (weatherProfile.int_0)
								{
								case 0:
									if (weatherProfile.float_0 < 5f && this.aircraftSizeClass_0 <= GlobalVariables.AircraftSizeClass.Large)
									{
										GlobalVariables.ProficiencyLevel? proficiencyLevel7 = this.vmethod_53();
										int? num3 = (proficiencyLevel7 != null) ? new int?((int)proficiencyLevel7.GetValueOrDefault()) : null;
										if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											num2 = 45.72f;
										}
										else
										{
											num3 = ((proficiencyLevel7 != null) ? new int?((int)proficiencyLevel7.GetValueOrDefault()) : null);
											if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
											{
												num2 = 30.48f;
											}
											else
											{
												num3 = ((proficiencyLevel7 != null) ? new int?((int)proficiencyLevel7.GetValueOrDefault()) : null);
												if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
												{
													num2 = 24.383999f;
												}
												else
												{
													num3 = ((proficiencyLevel7 != null) ? new int?((int)proficiencyLevel7.GetValueOrDefault()) : null);
													if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
													{
														num2 = 24.383999f;
													}
													else
													{
														num3 = ((proficiencyLevel7 != null) ? new int?((int)proficiencyLevel7.GetValueOrDefault()) : null);
														if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
														{
															num2 = 24.383999f;
														}
													}
												}
											}
										}
									}
									break;
								case 1:
									if (weatherProfile.float_0 < 5f && this.aircraftSizeClass_0 <= GlobalVariables.AircraftSizeClass.Large)
									{
										GlobalVariables.ProficiencyLevel? proficiencyLevel8 = this.vmethod_53();
										int? num3 = (proficiencyLevel8 != null) ? new int?((int)proficiencyLevel8.GetValueOrDefault()) : null;
										if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											num2 = 45.72f;
										}
										else
										{
											num3 = ((proficiencyLevel8 != null) ? new int?((int)proficiencyLevel8.GetValueOrDefault()) : null);
											if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
											{
												num2 = 30.48f;
											}
											else
											{
												num3 = ((proficiencyLevel8 != null) ? new int?((int)proficiencyLevel8.GetValueOrDefault()) : null);
												if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
												{
													num2 = 24.383999f;
												}
												else
												{
													num3 = ((proficiencyLevel8 != null) ? new int?((int)proficiencyLevel8.GetValueOrDefault()) : null);
													if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
													{
														num2 = 24.383999f;
													}
													else
													{
														num3 = ((proficiencyLevel8 != null) ? new int?((int)proficiencyLevel8.GetValueOrDefault()) : null);
														if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
														{
															num2 = 24.383999f;
														}
													}
												}
											}
										}
									}
									break;
								case 2:
									if (weatherProfile.float_0 < 5f && this.aircraftSizeClass_0 <= GlobalVariables.AircraftSizeClass.Large)
									{
										GlobalVariables.ProficiencyLevel? proficiencyLevel9 = this.vmethod_53();
										int? num3 = (proficiencyLevel9 != null) ? new int?((int)proficiencyLevel9.GetValueOrDefault()) : null;
										if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											num2 = 45.72f;
										}
										else
										{
											num3 = ((proficiencyLevel9 != null) ? new int?((int)proficiencyLevel9.GetValueOrDefault()) : null);
											if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
											{
												num2 = 30.48f;
											}
											else
											{
												num3 = ((proficiencyLevel9 != null) ? new int?((int)proficiencyLevel9.GetValueOrDefault()) : null);
												if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
												{
													num2 = 24.383999f;
												}
												else
												{
													num3 = ((proficiencyLevel9 != null) ? new int?((int)proficiencyLevel9.GetValueOrDefault()) : null);
													if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
													{
														num2 = 24.383999f;
													}
													else
													{
														num3 = ((proficiencyLevel9 != null) ? new int?((int)proficiencyLevel9.GetValueOrDefault()) : null);
														if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
														{
															num2 = 24.383999f;
														}
													}
												}
											}
										}
									}
									break;
								case 3:
									if (weatherProfile.float_0 < 5f && this.aircraftSizeClass_0 <= GlobalVariables.AircraftSizeClass.Large)
									{
										GlobalVariables.ProficiencyLevel? proficiencyLevel10 = this.vmethod_53();
										int? num3 = (proficiencyLevel10 != null) ? new int?((int)proficiencyLevel10.GetValueOrDefault()) : null;
										if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											num2 = 45.72f;
										}
										else
										{
											num3 = ((proficiencyLevel10 != null) ? new int?((int)proficiencyLevel10.GetValueOrDefault()) : null);
											if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
											{
												num2 = 30.48f;
											}
											else
											{
												num3 = ((proficiencyLevel10 != null) ? new int?((int)proficiencyLevel10.GetValueOrDefault()) : null);
												if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
												{
													num2 = 24.383999f;
												}
												else
												{
													num3 = ((proficiencyLevel10 != null) ? new int?((int)proficiencyLevel10.GetValueOrDefault()) : null);
													if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
													{
														num2 = 24.383999f;
													}
													else
													{
														num3 = ((proficiencyLevel10 != null) ? new int?((int)proficiencyLevel10.GetValueOrDefault()) : null);
														if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
														{
															num2 = 24.383999f;
														}
													}
												}
											}
										}
									}
									break;
								case 4:
									if (weatherProfile.float_0 < 5f && this.aircraftSizeClass_0 <= GlobalVariables.AircraftSizeClass.Large)
									{
										GlobalVariables.ProficiencyLevel? proficiencyLevel11 = this.vmethod_53();
										int? num3 = (proficiencyLevel11 != null) ? new int?((int)proficiencyLevel11.GetValueOrDefault()) : null;
										if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											num2 = 45.72f;
										}
										else
										{
											num3 = ((proficiencyLevel11 != null) ? new int?((int)proficiencyLevel11.GetValueOrDefault()) : null);
											if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
											{
												num2 = 30.48f;
											}
											else
											{
												num3 = ((proficiencyLevel11 != null) ? new int?((int)proficiencyLevel11.GetValueOrDefault()) : null);
												if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
												{
													num2 = 24.383999f;
												}
												else
												{
													num3 = ((proficiencyLevel11 != null) ? new int?((int)proficiencyLevel11.GetValueOrDefault()) : null);
													if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
													{
														num2 = 24.383999f;
													}
													else
													{
														num3 = ((proficiencyLevel11 != null) ? new int?((int)proficiencyLevel11.GetValueOrDefault()) : null);
														if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
														{
															num2 = 24.383999f;
														}
													}
												}
											}
										}
									}
									break;
								case 5:
									if (weatherProfile.float_0 < 5f && this.aircraftSizeClass_0 <= GlobalVariables.AircraftSizeClass.Large)
									{
										GlobalVariables.ProficiencyLevel? proficiencyLevel12 = this.vmethod_53();
										int? num3 = (proficiencyLevel12 != null) ? new int?((int)proficiencyLevel12.GetValueOrDefault()) : null;
										if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											num2 = 45.72f;
										}
										else
										{
											num3 = ((proficiencyLevel12 != null) ? new int?((int)proficiencyLevel12.GetValueOrDefault()) : null);
											if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
											{
												num2 = 45.72f;
											}
											else
											{
												num3 = ((proficiencyLevel12 != null) ? new int?((int)proficiencyLevel12.GetValueOrDefault()) : null);
												if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
												{
													num2 = 30.48f;
												}
												else
												{
													num3 = ((proficiencyLevel12 != null) ? new int?((int)proficiencyLevel12.GetValueOrDefault()) : null);
													if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
													{
														num2 = 30.48f;
													}
													else
													{
														num3 = ((proficiencyLevel12 != null) ? new int?((int)proficiencyLevel12.GetValueOrDefault()) : null);
														if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
														{
															num2 = 24.383999f;
														}
													}
												}
											}
										}
									}
									break;
								case 6:
								case 7:
								case 8:
								case 9:
								case 10:
									break;
								default:
									throw new NotImplementedException();
								}
							}
							else
							{
								num2 = 30.48f;
								switch (weatherProfile.int_0)
								{
								case 0:
								case 1:
								case 2:
								case 3:
								case 4:
								case 5:
								case 6:
								case 7:
									break;
								case 8:
									num2 = 60.96f;
									break;
								case 9:
									num2 = 60.96f;
									break;
								case 10:
									num2 = 60.96f;
									break;
								default:
									throw new NotImplementedException();
								}
							}
						}
						else
						{
							Aircraft.Enum40 enum4 = this.enum40_0;
							if (enum4 - Aircraft.Enum40.const_3 <= 1)
							{
								switch (weatherProfile.int_0)
								{
								case 0:
								{
									ActiveUnit.Throttle throttle19 = this.vmethod_84();
									if (throttle19 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle19 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 30.48f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 1:
								{
									ActiveUnit.Throttle throttle20 = this.vmethod_84();
									if (throttle20 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle20 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 30.48f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 2:
								{
									ActiveUnit.Throttle throttle21 = this.vmethod_84();
									if (throttle21 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle21 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 30.48f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 3:
								{
									ActiveUnit.Throttle throttle22 = this.vmethod_84();
									if (throttle22 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle22 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 30.48f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 4:
								{
									ActiveUnit.Throttle throttle23 = this.vmethod_84();
									if (throttle23 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle23 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 30.48f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 5:
								{
									ActiveUnit.Throttle throttle24 = this.vmethod_84();
									if (throttle24 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle24 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 30.48f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 6:
								{
									ActiveUnit.Throttle throttle25 = this.vmethod_84();
									if (throttle25 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle25 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 30.48f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 7:
								{
									ActiveUnit.Throttle throttle26 = this.vmethod_84();
									if (throttle26 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle26 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 60.96f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 8:
								{
									ActiveUnit.Throttle throttle27 = this.vmethod_84();
									if (throttle27 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle27 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 60.96f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 9:
								{
									ActiveUnit.Throttle throttle28 = this.vmethod_84();
									if (throttle28 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle28 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 60.96f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								case 10:
								{
									ActiveUnit.Throttle throttle29 = this.vmethod_84();
									if (throttle29 != ActiveUnit.Throttle.FullStop)
									{
										if (throttle29 == ActiveUnit.Throttle.Loiter)
										{
											num2 = 15.24f;
										}
										else
										{
											num2 = 60.96f;
										}
									}
									else
									{
										num2 = 15.24f;
									}
									break;
								}
								}
							}
							else if (!this.method_172() && !this.method_170())
							{
								num2 = 91.44f;
								switch (weatherProfile.int_0)
								{
								case 0:
								case 1:
								case 2:
								case 3:
								case 4:
								case 5:
								case 6:
								case 7:
								case 8:
								case 9:
								case 10:
									break;
								default:
									throw new NotImplementedException();
								}
							}
							else
							{
								num2 = 30.48f;
								switch (weatherProfile.int_0)
								{
								case 0:
								case 1:
								case 2:
								case 3:
								case 4:
								case 5:
								case 6:
								case 7:
									break;
								case 8:
									num2 = 60.96f;
									break;
								case 9:
									num2 = 60.96f;
									break;
								case 10:
									num2 = 60.96f;
									break;
								default:
									throw new NotImplementedException();
								}
							}
						}
					}
					result = new float?((float)num + num2);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100366", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new float?(15.24f);
			}
			return result;
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x000DB188 File Offset: 0x000D9388
		public void imethod_5(float? nullable_17)
		{
			try
			{
				this.nullable_16 = nullable_17;
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

		// Token: 0x06000BA0 RID: 2976 RVA: 0x000DB1E4 File Offset: 0x000D93E4
		public Aircraft(ref Scenario theScen, string theGUID = null) : base(ref theScen, theGUID)
		{
			this.float_31 = 45f;
			this.armorRating_0 = GlobalVariables.ArmorRating.None;
			this.armorRating_1 = GlobalVariables.ArmorRating.None;
			this.armorRating_2 = GlobalVariables.ArmorRating.None;
			this.float_33 = 0f;
			this.float_34 = 0f;
			this.enum38_0 = Aircraft.Enum38.const_1;
			this.enum38_1 = Aircraft.Enum38.const_1;
			this.enum38_2 = Aircraft.Enum38.const_1;
			this.bool_3 = true;
			ActiveUnit activeUnit = this;
			this.aircraft_AirOps_0 = new Aircraft_AirOps(ref activeUnit);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000DB268 File Offset: 0x000D9468
		public static int smethod_12(int int_8)
		{
			int result;
			if (int_8 < 20)
			{
				result = 100;
			}
			else if (int_8 < 50)
			{
				result = 200;
			}
			else if (int_8 < 100)
			{
				result = 400;
			}
			else if (int_8 < 120)
			{
				result = 800;
			}
			else if (int_8 < 150)
			{
				result = 1600;
			}
			else
			{
				result = 3200;
			}
			return result;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x000DB2C0 File Offset: 0x000D94C0
		public override void vmethod_133(bool bool_42, bool bool_43, bool bool_44)
		{
			try
			{
				this.bool_24 = true;
				this.method_164().method_35(null);
				if (this.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.OffloadingFuel)
				{
					List<KeyValuePair<string, Aircraft_AirOps.Enum43>> list = new List<KeyValuePair<string, Aircraft_AirOps.Enum43>>();
					list.AddRange(this.aircraft_AirOps_0.concurrentDictionary_1);
					try
					{
						foreach (KeyValuePair<string, Aircraft_AirOps.Enum43> keyValuePair in list)
						{
							Aircraft aircraft = (Aircraft)this.scenario_0.vmethod_0()[keyValuePair.Key];
							if (aircraft != null)
							{
								aircraft.aircraft_AirOps_0.method_45();
							}
						}
					}
					finally
					{
						List<KeyValuePair<string, Aircraft_AirOps.Enum43>>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					List<string> list2 = new List<string>();
					list2.AddRange(this.aircraft_AirOps_0.concurrentDictionary_0.Keys);
					try
					{
						foreach (string text in list2)
						{
							ConcurrentDictionary<string, byte> concurrentDictionary_ = this.aircraft_AirOps_0.concurrentDictionary_0;
							string text2 = text;
							byte b = 0;
							concurrentDictionary_.TryRemove(text2, ref b);
						}
					}
					finally
					{
						List<string>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				try
				{
					foreach (ActiveUnit activeUnit in this.scenario_0.method_42())
					{
						if (activeUnit != null)
						{
							if (Enumerable.Contains<Aircraft>(activeUnit.vmethod_92().method_4(), this))
							{
								activeUnit.vmethod_92().method_8(this);
							}
							if (activeUnit.bool_3 && ((Aircraft)activeUnit).method_164().concurrentDictionary_0 != null && ((Aircraft)activeUnit).method_164().concurrentDictionary_0.Count > 0)
							{
								ConcurrentDictionary<string, byte> concurrentDictionary_2 = ((Aircraft)activeUnit).method_164().concurrentDictionary_0;
								string string_ = this.string_0;
								byte b = 0;
								concurrentDictionary_2.TryRemove(string_, ref b);
							}
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				base.vmethod_133(bool_42, bool_43, bool_44);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100367", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000085F6 File Offset: 0x000067F6
		public override void vmethod_126(float float_35, ref Random random_0)
		{
			this.method_164().method_42(float_35);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x000DB520 File Offset: 0x000D9720
		public override void vmethod_138(ActiveUnit activeUnit_1)
		{
			bool flag = !activeUnit_1.bool_1;
			bool flag2 = false;
			bool flag3 = false;
			if (activeUnit_1.bool_1)
			{
				if (((Group)activeUnit_1).method_143() == Group.GroupType.AirBase)
				{
					flag3 = true;
				}
				else
				{
					flag2 = true;
				}
			}
			string text = "";
			if (Operators.CompareString(this.Name, this.string_2, false) != 0)
			{
				text = " (" + this.string_2 + ")";
			}
			if (flag || flag3)
			{
				string text2 = this.method_164().method_26(activeUnit_1);
				if (Operators.CompareString(text2, "OK", false) == 0)
				{
					this.method_164().method_33(false, activeUnit_1);
					this.scenario_0.method_59(activeUnit_1.Name + " is now the base for " + this.Name + text, this.Name + " has new base", LoggedMessage.MessageType.AirOps, 5, this.string_0, this.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
				}
				else
				{
					this.scenario_0.method_59(string.Concat(new string[]
					{
						"Failed to set ",
						activeUnit_1.Name,
						" as the new base for ",
						this.Name,
						text,
						". Reason: ",
						text2
					}), this.Name + " failed to set new base", LoggedMessage.MessageType.AirOps, 5, this.string_0, this.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
				}
			}
			if (flag2)
			{
				Unit unit = null;
				try
				{
					foreach (ActiveUnit activeUnit in ((Group)activeUnit_1).vmethod_141().Values)
					{
						if (Operators.CompareString(this.method_164().method_26(activeUnit), "OK", false) == 0)
						{
							this.method_164().method_33(false, activeUnit);
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
					this.scenario_0.method_59(string.Concat(new string[]
					{
						"Failed to set ",
						activeUnit_1.Name,
						" as the new base for ",
						this.Name,
						text
					}), this.Name + " failed to set new base", LoggedMessage.MessageType.AirOps, 5, this.string_0, this.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					return;
				}
				this.scenario_0.method_59(activeUnit_1.Name + " is now the base for " + this.Name + text, this.Name + " has new base", LoggedMessage.MessageType.AirOps, 5, this.string_0, this.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
			}
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000DB81C File Offset: 0x000D9A1C
		public override bool vmethod_47(double double_4, double double_5, ref int int_8, bool bool_42, bool bool_43, bool bool_44, ref bool bool_45, bool bool_46, ref bool bool_47, float? nullable_17, short? nullable_18, ref List<ActiveUnit> list_3, float float_35, bool bool_48, bool bool_49, ref string string_9, ref bool bool_50)
		{
			bool result;
			try
			{
				int_8 = 1;
				if (!double.IsNaN(double_4) && !double.IsNaN(double_5))
				{
					if (bool_48 && this.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive && this.vmethod_101() != null && this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
					{
						Class343 @class = (Class343)this.vmethod_101();
						GeoPoint geoPoint = new GeoPoint(double_5, double_4);
						if (this.vmethod_46(@class.list_15, this.scenario_0, true) && !GeoPoint.smethod_4(geoPoint.imethod_2(), geoPoint.imethod_0(), @class.list_15, true))
						{
							bool_45 = false;
							bool_47 = false;
							string_9 = "The target has left the prosecution area.";
							return false;
						}
					}
					if (bool_49)
					{
						bool_45 = base.method_131();
					}
					if ((bool_45 || bool_42) && base.method_130(double_4, double_5, float_35))
					{
						bool_45 = true;
						bool_47 = false;
						string_9 = "The point is inside a No-Nav Zone.";
						result = false;
					}
					else
					{
						bool_45 = false;
						bool_47 = false;
						result = true;
					}
				}
				else
				{
					bool_45 = false;
					bool_47 = false;
					string_9 = "Unknown.";
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200284", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				bool_45 = false;
				bool_47 = false;
				string_9 = "Error.";
				result = false;
			}
			return result;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00008604 File Offset: 0x00006804
		public bool method_174()
		{
			return this.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Parked;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00008614 File Offset: 0x00006814
		public override bool vmethod_123()
		{
			return this.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Parked && this.method_164().method_38() == 0f;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x000DB970 File Offset: 0x000D9B70
		public bool method_175()
		{
			return (this.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Parked && this.method_164().method_38() == 0f) || this.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway || this.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00008638 File Offset: 0x00006838
		public override bool vmethod_124()
		{
			return this.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Parked && this.method_164().method_38() > 0f;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x000DB9CC File Offset: 0x000D9BCC
		public override bool vmethod_127()
		{
			bool result;
			try
			{
				switch (this.method_164().method_36())
				{
				case Aircraft_AirOps._AirOpsCondition.Airborne:
				case Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown:
				case Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue:
				case Aircraft_AirOps._AirOpsCondition.RTB:
				case Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel:
				case Aircraft_AirOps._AirOpsCondition.Refuelling:
				case Aircraft_AirOps._AirOpsCondition.OffloadingFuel:
				case Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar:
				case Aircraft_AirOps._AirOpsCondition.EmergencyLanding:
				case Aircraft_AirOps._AirOpsCondition.BVRAttack:
				case Aircraft_AirOps._AirOpsCondition.BVRCrank:
				case Aircraft_AirOps._AirOpsCondition.Dogfight:
				case Aircraft_AirOps._AirOpsCondition.TransferringCargo:
				case Aircraft_AirOps._AirOpsCondition.BVRDrag:
					result = true;
					break;
				default:
					result = false;
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
				result = false;
			}
			return result;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x000DBA9C File Offset: 0x000D9C9C
		public override float vmethod_129()
		{
			float result;
			try
			{
				float num;
				foreach (FuelRec fuelRec in this.vmethod_67())
				{
					num += (float)fuelRec.int_0 - fuelRec.float_0;
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100369", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000DBB24 File Offset: 0x000D9D24
		public override void vmethod_136(float float_35, FuelRec._FuelType _FuelType_0)
		{
			try
			{
				float num = float_35;
				if (this.method_167() != null)
				{
					foreach (WeaponRec weaponRec in this.method_167().weaponRec_0)
					{
						if (num == 0f)
						{
							break;
						}
						if (weaponRec.method_12(this.scenario_0).method_214())
						{
							FuelRec fuelRec = weaponRec.method_12(this.scenario_0).vmethod_67()[0];
							FuelRec fuelRec2 = new FuelRec(0, (short)fuelRec._FuelType_0);
							int num2 = weaponRec.method_9();
							fuelRec2.float_0 = fuelRec.float_0 * (float)num2;
							fuelRec2.int_0 = fuelRec.int_0 * num2;
							if (fuelRec2.float_0 >= num)
							{
								fuelRec2.float_0 -= num;
								fuelRec.float_0 = fuelRec2.float_0 / (float)num2;
								num = 0f;
								break;
							}
							num -= fuelRec2.float_0;
							fuelRec2.float_0 = 0f;
							fuelRec.float_0 = 0f;
						}
					}
				}
				if (num != 0f)
				{
					FuelRec fuelRec3 = this.fuelRec_0[0];
					if (fuelRec3.float_0 > num)
					{
						fuelRec3.float_0 -= num;
					}
					else
					{
						string str = "";
						if (Operators.CompareString(this.Name, this.string_2, false) != 0)
						{
							str = " (" + this.string_2 + ")";
						}
						base.method_124(this.Name + str + " has run out of fuel and crashed!", this.Name + " has ditched!", LoggedMessage.MessageType.UnitLost, 1, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
						this.scenario_0.method_65(this);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100370", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x000DBD40 File Offset: 0x000D9F40
		public override void vmethod_135(float float_35, FuelRec._FuelType _FuelType_0)
		{
			try
			{
				FuelRec fuelRec = this.fuelRec_0[0];
				float num = (float)fuelRec.int_0 - fuelRec.float_0;
				float num2;
				if (num > float_35)
				{
					FuelRec fuelRec2 = fuelRec;
					ref float ptr = ref fuelRec2.float_0;
					fuelRec2.float_0 = ptr + float_35;
					num2 = 0f;
				}
				else
				{
					fuelRec.float_0 = (float)fuelRec.int_0;
					num2 = float_35 - num;
				}
				if (num2 != 0f)
				{
					if (this.method_167() != null)
					{
						foreach (WeaponRec weaponRec in this.method_167().weaponRec_0)
						{
							if (weaponRec.method_12(this.scenario_0).method_214() && num2 > 0f)
							{
								FuelRec fuelRec3 = weaponRec.method_12(this.scenario_0).vmethod_67()[0];
								FuelRec fuelRec4 = new FuelRec(0, (short)fuelRec3._FuelType_0);
								int num3 = weaponRec.method_9();
								fuelRec4.float_0 = fuelRec3.float_0 * (float)num3;
								fuelRec4.int_0 = fuelRec3.int_0 * num3;
								num = (float)fuelRec4.int_0 - fuelRec4.float_0;
								if (num > num2)
								{
									FuelRec fuelRec5 = fuelRec4;
									ref float ptr = ref fuelRec5.float_0;
									fuelRec5.float_0 = ptr + num2;
									num2 = 0f;
								}
								else
								{
									fuelRec4.float_0 = (float)fuelRec4.int_0;
									num2 -= num;
								}
								fuelRec3.float_0 = fuelRec4.float_0 / (float)num3;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100371", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x000DBEF0 File Offset: 0x000DA0F0
		public override void vmethod_137(float float_35)
		{
			try
			{
				if (Enumerable.Count<Engine>(Enumerable.Where<Engine>(this.vmethod_49(), (Aircraft._Closure$__.$I222-0 == null) ? (Aircraft._Closure$__.$I222-0 = new Func<Engine, bool>(Aircraft._Closure$__.$I.method_0)) : Aircraft._Closure$__.$I222-0)) == 0)
				{
					base.method_124(this.Name + " (" + this.string_2 + ") has no functioning engines and is being abandoned!", this.Name + " bailing out!", LoggedMessage.MessageType.UnitLost, 0, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					this.scenario_0.method_65(this);
				}
				float float_36 = this.vmethod_98(this.vmethod_84(), null, new float?((float)((int)Math.Round((double)this.vmethod_70()))), new float?(this.vmethod_14(false)), false, false, false, false, false) * float_35;
				this.vmethod_136(float_36, FuelRec._FuelType.AviationFuel);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100372", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x000041ED File Offset: 0x000023ED
		public override bool vmethod_43()
		{
			return true;
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x000DC020 File Offset: 0x000DA220
		public int method_176()
		{
			int num = 0;
			if (this.method_167() != null)
			{
				num = this.method_167().int_5;
			}
			int num2 = 0;
			foreach (FuelRec fuelRec in this.vmethod_67())
			{
				num2 += (int)Math.Round((double)fuelRec.float_0);
			}
			return num + num2;
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x000DC074 File Offset: 0x000DA274
		public int method_177()
		{
			int num = 0;
			foreach (FuelRec fuelRec in this.fuelRec_0)
			{
				num += (int)Math.Round((double)fuelRec.float_0 * 0.6);
			}
			return this.int_0 + num;
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x000DC0C0 File Offset: 0x000DA2C0
		public float method_178()
		{
			float result;
			if (this.method_176() == 0)
			{
				result = 0f;
			}
			else
			{
				int num = this.int_0 + this.method_176();
				int num2 = this.int_1 - this.method_177();
				float num3 = (float)Math.Min(0.99, (double)(num - this.method_177()) / (double)num2);
				if (num3 < 0f)
				{
					num3 = 0f;
				}
				result = num3;
			}
			return result;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x000DC128 File Offset: 0x000DA328
		private float method_179()
		{
			Aircraft._AircraftType aircraftType_ = this._AircraftType_0;
			float result;
			if (aircraftType_ != Aircraft._AircraftType.Fighter && aircraftType_ != Aircraft._AircraftType.Attack)
			{
				if (aircraftType_ != Aircraft._AircraftType.CAS)
				{
					result = 0.1f;
				}
				else
				{
					result = 0.5f;
				}
			}
			else
			{
				result = 0.3f;
			}
			return result;
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0000865C File Offset: 0x0000685C
		public override float vmethod_63(bool ScenEditAction = false, Weapon theWeapon = null)
		{
			return base.vmethod_63(ScenEditAction, theWeapon);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x000DC16C File Offset: 0x000DA36C
		public override void vmethod_64(bool ScenEditAction = false, Weapon theWeapon = null, float value)
		{
			bool flag = value != base.vmethod_63(false, null);
			float num = this.method_163().method_0();
			base.vmethod_64(ScenEditAction, theWeapon, value);
			float num2 = this.method_163().method_0();
			if (flag && !ScenEditAction)
			{
				float num3 = this.method_179();
				if (num < num3 * 100f && num2 >= num3 * 100f && !this.bool_24 && !base.method_82())
				{
					this.method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.RTB_Group, true, true);
					this.method_161().method_67(false, true, true, true, false, false, false);
				}
			}
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x000DC200 File Offset: 0x000DA400
		public override float vmethod_98(ActiveUnit.Throttle throttle_5, AltBand altBand_0, float? nullable_17, float? nullable_18, bool bool_42, bool bool_43, bool bool_44, bool bool_45, bool bool_46)
		{
			Aircraft.Class238 @class = new Aircraft.Class238();
			@class.altBand_0 = null;
			float result;
			if (this.vmethod_49().Count == 0)
			{
				result = 0f;
			}
			else
			{
				try
				{
					IEnumerable<Engine> enumerable = Enumerable.Where<Engine>(this.vmethod_49(), (Aircraft._Closure$__.$I236-0 == null) ? (Aircraft._Closure$__.$I236-0 = new Func<Engine, bool>(Aircraft._Closure$__.$I.method_1)) : Aircraft._Closure$__.$I236-0);
					if (Enumerable.Count<Engine>(enumerable) == 0)
					{
						result = 0f;
					}
					else
					{
						Engine engine = Enumerable.ElementAtOrDefault<Engine>(enumerable, 0);
						if (engine.altBand_0.Length == 0)
						{
							result = 0f;
						}
						else
						{
							if (altBand_0 == null)
							{
								if (nullable_18 != null)
								{
									@class.altBand_0 = ActiveUnit_Kinematics.smethod_1(this, nullable_18.Value, null, false);
								}
								else
								{
									@class.altBand_0 = this.method_159().vmethod_42(this.vmethod_14(false), false);
								}
							}
							else
							{
								@class.altBand_0 = altBand_0;
							}
							if (@class.altBand_0 == null)
							{
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								throw new Exception();
							}
							float num;
							bool flag;
							float num2;
							switch (throttle_5)
							{
							case ActiveUnit.Throttle.FullStop:
								if (@class.altBand_0.nullable_0 == null)
								{
									throw new Exception("Aircraft has full throttle but no full-throttle consumption params exists in database!");
								}
								num = @class.altBand_0.nullable_2.Value;
								flag = true;
								break;
							case ActiveUnit.Throttle.Loiter:
								num = @class.altBand_0.float_2;
								if (!this.method_150(false))
								{
									flag = true;
								}
								else
								{
									num2 = @class.altBand_0.nullable_2.Value;
								}
								break;
							case ActiveUnit.Throttle.Cruise:
								num = @class.altBand_0.float_3;
								num2 = @class.altBand_0.float_2;
								break;
							case ActiveUnit.Throttle.Full:
								if (@class.altBand_0.nullable_0 != null)
								{
									num = @class.altBand_0.nullable_2.Value;
									float num3 = (float)@class.altBand_0.nullable_0.Value;
									num2 = @class.altBand_0.float_3;
								}
								else
								{
									if (!bool_45)
									{
										throw new Exception("Aircraft has military throttle but no fuel consumption params exist in database!");
									}
									num = @class.altBand_0.float_3;
									num2 = @class.altBand_0.float_2;
									throttle_5 = ActiveUnit.Throttle.Cruise;
								}
								break;
							case ActiveUnit.Throttle.Flank:
								if (@class.altBand_0.nullable_1 != null)
								{
									num = @class.altBand_0.nullable_3.Value;
									float num4 = (float)@class.altBand_0.nullable_1.Value;
									if (@class.altBand_0.nullable_0 != null)
									{
										num2 = @class.altBand_0.nullable_2.Value;
									}
									else
									{
										num2 = @class.altBand_0.float_3;
									}
								}
								else
								{
									if (!bool_45)
									{
										throw new Exception("Aircraft has afterburner throttle but no fuel consumption params exist in database!");
									}
									if (@class.altBand_0.nullable_0 != null)
									{
										num = @class.altBand_0.nullable_2.Value;
										float num5 = (float)@class.altBand_0.nullable_0.Value;
										num2 = @class.altBand_0.float_3;
										throttle_5 = ActiveUnit.Throttle.Full;
									}
									else
									{
										num = @class.altBand_0.float_3;
										num2 = @class.altBand_0.float_2;
										throttle_5 = ActiveUnit.Throttle.Cruise;
									}
								}
								break;
							default:
								return 0f;
							}
							float num6 = num;
							if (nullable_17 != null && nullable_18 != null)
							{
								if (@class.altBand_0 != this.method_159().method_11(engine))
								{
									AltBand[] altBand_ = engine.altBand_0;
									if (altBand_.Length == 0)
									{
										return 0f;
									}
									AltBand altBand = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderBy<AltBand, float>(Enumerable.Where<AltBand>(altBand_, new Func<AltBand, bool>(@class.method_0)), (Aircraft._Closure$__.$I236-2 == null) ? (Aircraft._Closure$__.$I236-2 = new Func<AltBand, float>(Aircraft._Closure$__.$I.method_2)) : Aircraft._Closure$__.$I236-2), 0);
									if (altBand != null)
									{
										float num7;
										float num8;
										switch (throttle_5)
										{
										case ActiveUnit.Throttle.FullStop:
											if (altBand.nullable_0 == null)
											{
												throw new Exception("Helicopter is at Full Stop throttle but no full-throttle consumption params exists in database!");
											}
											num7 = @class.altBand_0.nullable_2.Value;
											break;
										case ActiveUnit.Throttle.Loiter:
											num7 = altBand.float_2;
											if (!flag)
											{
												num8 = altBand.nullable_2.Value;
											}
											break;
										case ActiveUnit.Throttle.Cruise:
											num7 = altBand.float_3;
											num8 = altBand.float_2;
											break;
										case ActiveUnit.Throttle.Full:
											if (altBand.nullable_0 != null)
											{
												num7 = altBand.nullable_2.Value;
												float num9 = (float)altBand.nullable_0.Value;
												num8 = altBand.float_3;
											}
											else
											{
												if (!bool_45)
												{
													throw new Exception("Aircraft has military throttle but no fuel consumption params exist in database!");
												}
												num = @class.altBand_0.float_3;
												num2 = @class.altBand_0.float_2;
												throttle_5 = ActiveUnit.Throttle.Cruise;
											}
											break;
										case ActiveUnit.Throttle.Flank:
											if (altBand.nullable_1 != null)
											{
												num7 = altBand.nullable_3.Value;
												float num10 = (float)altBand.nullable_1.Value;
												if (altBand.nullable_0 != null)
												{
													num8 = altBand.nullable_2.Value;
												}
												else
												{
													num8 = altBand.float_3;
												}
											}
											else
											{
												if (!bool_45)
												{
													throw new Exception("Aircraft has afterburner throttle but no fuel consumption params exist in database!");
												}
												if (@class.altBand_0.nullable_0 != null)
												{
													num = @class.altBand_0.nullable_2.Value;
													float num11 = (float)@class.altBand_0.nullable_0.Value;
													num2 = @class.altBand_0.float_3;
													throttle_5 = ActiveUnit.Throttle.Full;
												}
												else
												{
													num = @class.altBand_0.float_3;
													num2 = @class.altBand_0.float_2;
													throttle_5 = ActiveUnit.Throttle.Cruise;
												}
											}
											break;
										default:
											return 0f;
										}
										if (num != num7)
										{
											float? num12 = nullable_18;
											float float_ = @class.altBand_0.float_1;
											if (((num12 != null) ? new bool?(num12.GetValueOrDefault() != float_) : null).GetValueOrDefault())
											{
												float num13 = ((nullable_18 - @class.altBand_0.float_1) / (@class.altBand_0.float_0 - @class.altBand_0.float_1)).Value;
												num13 = Math.Abs(num13);
												num += (num7 - num) * num13;
												num6 = num;
												if (!flag)
												{
													num2 += (num8 - num2) * num13;
												}
											}
										}
									}
								}
								if (!flag && (!this.method_150(false) || this.vmethod_70() > (float)this.method_159().vmethod_40(this.vmethod_14(false), ActiveUnit.Throttle.Loiter, false)))
								{
									float num14 = (float)this.method_159().vmethod_40(nullable_18.Value, throttle_5, false);
									float? num12 = nullable_17;
									if (((num12 != null) ? new bool?(num12.GetValueOrDefault() < num14) : null).GetValueOrDefault())
									{
										float num15 = (float)this.method_159().vmethod_40(nullable_18.Value, (ActiveUnit.Throttle)(throttle_5 - ActiveUnit.Throttle.Loiter), false);
										num12 = nullable_17;
										float num16;
										if (((num12 != null) ? new bool?(num12.GetValueOrDefault() >= num15) : null).GetValueOrDefault())
										{
											num16 = ((nullable_17 - num15) / (num14 - num15)).Value;
											num16 = Math.Abs(num16);
										}
										else
										{
											num16 = 0f;
										}
										if (num15 == 0f)
										{
											num6 = num2 + (num - num2) * num16;
										}
										else
										{
											num6 = num2 + (num - num2) * num16;
										}
									}
								}
							}
							if (this.method_167() != null)
							{
								float float_2 = this.method_167().float_0;
								int num17 = 0;
								int int_;
								if (bool_46)
								{
									int_ = this.method_167().int_7;
								}
								else
								{
									int_ = this.method_167().int_5;
								}
								if (int_ > 0 && float_2 > 0f)
								{
									if (bool_42 && this.method_167().int_6 > 0 && this.vmethod_101() != null && this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && !this.method_158().bool_2)
									{
										Strike strike = (Strike)this.vmethod_101();
										if (strike.enum90_0 == Mission.Enum90.const_0)
										{
											if (this.method_167() != null && this.method_167().method_15(this.scenario_0).bool_6)
											{
												num17 = this.method_167().int_6;
											}
										}
										else if (strike.enum90_0 == Mission.Enum90.const_1)
										{
											num17 = this.method_167().int_6;
										}
									}
									if (bool_43 && this.vmethod_101() != null && this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && !this.method_158().bool_2)
									{
										Strike strike2 = (Strike)this.vmethod_101();
										if (strike2.enum90_0 == Mission.Enum90.const_0)
										{
											if (this.method_167() != null && this.method_167().method_15(this.scenario_0).bool_6)
											{
												num17 = this.method_167().int_6;
											}
										}
										else if (strike2.enum90_0 == Mission.Enum90.const_1)
										{
											num17 = this.method_167().int_6;
										}
									}
									if (bool_44 && this.vmethod_101() != null && this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && !this.method_158().bool_2)
									{
										Strike strike3 = (Strike)this.vmethod_101();
										if (strike3.enum90_0 == Mission.Enum90.const_0)
										{
											if (this.method_167() != null && this.method_167().method_15(this.scenario_0).bool_6)
											{
												if (bool_46)
												{
													num17 = this.method_167().int_8;
												}
												else
												{
													num17 = this.method_167().int_6;
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
												}
											}
										}
										else if (strike3.enum90_0 == Mission.Enum90.const_1)
										{
											if (bool_46)
											{
												num17 = this.method_167().int_8;
											}
											else
											{
												num17 = this.method_167().int_6;
												if (Debugger.IsAttached)
												{
													Debugger.Break();
												}
											}
										}
									}
									float num18 = float_2 * (num6 * (float)(int_ - num17)) / 100f;
									num6 += num18;
								}
							}
							double num19 = (double)Enumerable.Count<Engine>(Enumerable.Where<Engine>(this.vmethod_49(), (Aircraft._Closure$__.$I236-3 == null) ? (Aircraft._Closure$__.$I236-3 = new Func<Engine, bool>(Aircraft._Closure$__.$I.method_3)) : Aircraft._Closure$__.$I236-3)) / (double)this.vmethod_49().Count;
							num6 = (float)((double)num6 * num19);
							result = num6 / 60f;
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100373", "");
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = 0f;
				}
			}
			return result;
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x000DCCC0 File Offset: 0x000DAEC0
		public static string smethod_13(int int_8, int int_9, Loadout.LoadoutRole loadoutRole_0, Scenario scenario_1)
		{
			if (int_9 <= 4002)
			{
				if (int_9 <= 2002)
				{
					if (int_9 == 2001)
					{
						return "Winchester: Return to base when mission-specific weapons have been expended. Disengage immediately.";
					}
					if (int_9 == 2002)
					{
						if (loadoutRole_0 - Loadout.LoadoutRole.Intercept_BVR <= 6)
						{
							return "Winchester: Return to base when mission-specific weapons have been expended. Allow targets of opportunity with air-to-air guns.";
						}
						return "Winchester: Return to base when mission-specific weapons have been expended. Disengage immediately.";
					}
				}
				else
				{
					switch (int_9)
					{
					case 3001:
						if (loadoutRole_0 - Loadout.LoadoutRole.Intercept_BVR <= 6)
						{
							return "Shotgun: Return to base when all BVR weapons have been expended. Disengage immediately.";
						}
						return "Shotgun: Return to base when all Stand-Off weapons have been expended. Disengage immediately.";
					case 3002:
						if (loadoutRole_0 - Loadout.LoadoutRole.Intercept_BVR <= 6)
						{
							return "Shotgun: Return to base when all BVR weapons have been expended. Allow easy targets of opportunity with WVR weapons. No air-to-air guns.";
						}
						return "Shotgun: Return to base when all Stand-Off weapons have been expended. Allow easy targets of opportunity with Strike weapons.";
					case 3003:
						if (loadoutRole_0 - Loadout.LoadoutRole.Intercept_BVR <= 6)
						{
							return "Shotgun: Return to base when all BVR weapons have been expended. Allow easy targets of opportunity with WVR weapons, and air-to-air guns.";
						}
						return "Shotgun: Return to base when all Stand-Off weapons have been expended. Allow easy targets of opportunity with Strike weapons.";
					default:
						if (int_9 == 4001)
						{
							return "Shotgun: Return to base when 25% of relevant weapons have been expended. Disengage immediately.";
						}
						if (int_9 == 4002)
						{
							return "Shotgun: Return to base when 25% of relevant weapons have been expended. Allow targets of opportunity, including air-to-air guns.";
						}
						break;
					}
				}
			}
			else if (int_9 <= 4012)
			{
				if (int_9 == 4011)
				{
					return "Shotgun: Return to base when 50% of relevant weapons have been expended. Disengage immediately.";
				}
				if (int_9 == 4012)
				{
					return "Shotgun: Return to base when 50% of relevant weapons have been expended. Allow targets of opportunity, including air-to-air guns.";
				}
			}
			else
			{
				if (int_9 == 4021)
				{
					return "Shotgun: Return to base when 75% of relevant weapons have been expended. Disengage immediately.";
				}
				if (int_9 == 4022)
				{
					return "Shotgun: Return to base when 75% of relevant weapons have been expended. Allow targets of opportunity, including air-to-air guns.";
				}
				switch (int_9)
				{
				case 5001:
					if (loadoutRole_0 - Loadout.LoadoutRole.Intercept_BVR <= 6)
					{
						return "Shotgun: Return to base after one engagement with BVR weapons. Disengage immediately.";
					}
					return "Shotgun: Return to base after one engagement with Stand-Off weapons. Disengage immediately.";
				case 5002:
					if (loadoutRole_0 - Loadout.LoadoutRole.Intercept_BVR <= 6)
					{
						return "Shotgun: Return to base after one engagement with BVR weapons. Allow easy targets of opportunity with WVR weapons. No air-to-air guns.";
					}
					return "Shotgun: Return to base after one engagement with Stand-Off weapons. Allow easy targets of opportunity with Strike weapons.";
				case 5003:
					if (loadoutRole_0 - Loadout.LoadoutRole.Intercept_BVR <= 6)
					{
						return "Shotgun: Return to base after one engagement with BVR weapons. Allow easy targets of opportunity with WVR weapons, and air-to-air guns.";
					}
					return "Shotgun: Return to base after one engagement with Stand-Off weapons. Allow easy targets of opportunity with Strike weapons.";
				case 5005:
					if (loadoutRole_0 - Loadout.LoadoutRole.Intercept_BVR <= 6)
					{
						return "Shotgun: Return to base after one engagement with both BVR and WVR weapons. No air-to-air guns.";
					}
					return "Shotgun: Return to base after one engagement with both Stand-Off and Strike weapons.";
				case 5006:
					if (loadoutRole_0 - Loadout.LoadoutRole.Intercept_BVR <= 6)
					{
						return "Shotgun: Return to base after one engagement with both BVR and WVR weapons. Allow easy targets of opportunity with air-to-air guns.";
					}
					return "Shotgun: Return to base after one engagement with both Stand-Off and Strike weapons.";
				case 5011:
					if (loadoutRole_0 - Loadout.LoadoutRole.Intercept_BVR <= 6)
					{
						return "Shotgun: Return to base after one engagement with WVR. Disengage immediately.";
					}
					return "Shotgun: Return to base after one engagement with Strike weapons. Disengage immediately.";
				case 5012:
					if (loadoutRole_0 - Loadout.LoadoutRole.Intercept_BVR <= 6)
					{
						return "Shotgun: Return to base after one engagement with WVR weapons. Allow targets of opportunity with air-to-air guns.";
					}
					return "Shotgun: Return to base after one engagement with Strike weapons.";
				}
			}
			SQLiteConnection sqliteConnection = scenario_1.method_39();
			return DBFunctions.smethod_37(int_8, int_9, ref sqliteConnection, scenario_1, true, loadoutRole_0);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00008666 File Offset: 0x00006866
		public float imethod_0()
		{
			return this.method_167().float_1;
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00008673 File Offset: 0x00006873
		public float imethod_1()
		{
			return this.method_167().float_2;
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x000DCF68 File Offset: 0x000DB168
		public CargoType imethod_2()
		{
			CargoType result;
			if (this.method_167() == null)
			{
				result = CargoType.NoCargo;
			}
			else
			{
				result = this.method_167().cargoType_0;
			}
			return result;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00008680 File Offset: 0x00006880
		public float imethod_3()
		{
			return this.method_167().float_3;
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x000DCF90 File Offset: 0x000DB190
		private void method_180(ref int? nullable_17, ref Sensor[] sensor_2)
		{
			int num = 0;
			foreach (Sensor sensor in this.sensor_0)
			{
				if (!sensor.method_65())
				{
					if (nullable_17 != null)
					{
						nullable_17++;
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
					if (nullable_17 != null)
					{
						nullable_17++;
					}
					if (sensor_2 != null)
					{
						sensor_2[num] = sensor2;
						num++;
					}
				}
			}
			if (this.method_167() != null)
			{
				foreach (Sensor sensor3 in this.method_167().method_9(this.scenario_0))
				{
					if (nullable_17 != null)
					{
						nullable_17++;
					}
					if (sensor_2 != null)
					{
						sensor_2[num] = sensor3;
						num++;
					}
				}
				HashSet<int> hashSet = new HashSet<int>();
				if (this.method_167().weaponRec_0 != null)
				{
					foreach (WeaponRec weaponRec in this.method_167().weaponRec_0)
					{
						if (weaponRec.method_9() > 0)
						{
							Weapon weapon = weaponRec.method_12(this.scenario_0);
							if (weapon.bool_27 || weapon.method_167() == Weapon._WeaponType.HeliTowedPackage)
							{
								Sensor[] array3 = weapon.vmethod_96();
								int n = 0;
								while (n < array3.Length)
								{
									Sensor sensor4 = array3[n];
									if (weapon.method_167() == Weapon._WeaponType.SensorPod)
									{
										goto IL_2A1;
									}
									if (weapon.method_167() == Weapon._WeaponType.HeliTowedPackage)
									{
										goto IL_2A1;
									}
									if (!hashSet.Contains(sensor4.DBID))
									{
										hashSet.Add(sensor4.DBID);
										if (nullable_17 != null)
										{
											nullable_17++;
										}
										if (sensor_2 != null)
										{
											sensor_2[num] = sensor4;
											num++;
										}
										if (sensor4.method_47() < 10)
										{
											sensor4.method_48(10);
										}
									}
									IL_2E8:
									checked
									{
										n++;
										continue;
										IL_2A1:;
									}
									if (nullable_17 != null)
									{
										nullable_17++;
									}
									if (sensor_2 != null)
									{
										sensor_2[num] = sensor4;
										num++;
										goto IL_2E8;
									}
									goto IL_2E8;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x000DD2A8 File Offset: 0x000DB4A8
		public override Sensor[] vmethod_96()
		{
			Sensor[] result;
			try
			{
				int? num = new int?(0);
				Sensor[] array = null;
				this.method_180(ref num, ref array);
				Sensor[] array2 = new Sensor[num.Value - 1 + 1];
				int? num2 = new int?(0);
				this.method_180(ref num2, ref array2);
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

		// Token: 0x06000BBE RID: 3006 RVA: 0x000DD34C File Offset: 0x000DB54C
		public override void vmethod_48(float float_35, bool bool_42)
		{
			if (this.vmethod_40() != 0f)
			{
				this.vmethod_33(this.vmethod_28(null));
				this.vmethod_35(this.vmethod_30(null));
				try
				{
					float num;
					if (this.bool_0)
					{
						num = this.vmethod_87().vmethod_47(float_35);
					}
					else
					{
						num = base.method_48(float_35);
					}
					double num2;
					double num3;
					Class411.smethod_1(this.vmethod_32(), this.vmethod_34(), ref num2, ref num3, (double)num, (double)this.vmethod_9());
					if (double.IsNaN(num3))
					{
						num3 = this.vmethod_34();
					}
					if (double.IsNaN(num2))
					{
						num2 = this.vmethod_32();
					}
					bool flag = false;
					bool flag2 = true;
					bool flag3 = true;
					double double_ = num3;
					double double_2 = num2;
					int num4 = 0;
					bool bool_43 = false;
					bool bool_44 = false;
					bool bool_45 = true;
					bool bool_46 = true;
					float? nullable_ = null;
					short? nullable_2 = null;
					float float_36 = 0f;
					bool bool_47 = false;
					bool bool_48 = true;
					string text = "";
					List<ActiveUnit> list;
					if (this.vmethod_47(double_, double_2, ref num4, bool_43, bool_44, bool_45, ref flag2, bool_46, ref flag, nullable_, nullable_2, ref list, float_36, bool_47, bool_48, ref text, ref flag3))
					{
						this.vmethod_31(null, num3);
						this.vmethod_29(null, num2);
						if (this.scenario_0.MinuteIsChangingOnThisPulse)
						{
							this.vmethod_85().nullable_1 = null;
						}
					}
					else if (!flag && !flag2)
					{
						double double_3 = this.vmethod_34();
						double double_4 = this.vmethod_32();
						num4 = 0;
						bool bool_49 = false;
						bool bool_50 = false;
						bool bool_51 = true;
						bool bool_52 = true;
						float? nullable_3 = null;
						short? nullable_4 = null;
						float float_37 = 0f;
						bool bool_53 = false;
						bool bool_54 = true;
						text = "";
						if (this.vmethod_47(double_3, double_4, ref num4, bool_49, bool_50, bool_51, ref flag2, bool_52, ref flag, nullable_3, nullable_4, ref list, float_37, bool_53, bool_54, ref text, ref flag3))
						{
							flag3 = true;
						}
						if (flag3)
						{
							this.vmethod_10(base.method_52(this.vmethod_9(), num, false));
							Class411.smethod_1(this.vmethod_28(null), this.vmethod_30(null), ref num2, ref num3, (double)num, (double)this.vmethod_9());
							if (this.scenario_0.MinuteIsChangingOnThisPulse)
							{
								double double_5 = num3;
								double double_6 = num2;
								num4 = 0;
								bool bool_55 = false;
								bool bool_56 = false;
								bool bool_57 = true;
								bool flag4 = false;
								bool bool_58 = true;
								float? nullable_5 = null;
								short? nullable_6 = null;
								float float_38 = 0f;
								bool bool_59 = false;
								bool bool_60 = false;
								text = "";
								bool flag5 = false;
								double num5;
								double num6;
								if (!this.vmethod_47(double_5, double_6, ref num4, bool_55, bool_56, bool_57, ref flag4, bool_58, ref flag, nullable_5, nullable_6, ref list, float_38, bool_59, bool_60, ref text, ref flag5) && this.vmethod_85().method_10(num3, num2, ref num5, ref num6, false, false, true, 0f, ref list, false))
								{
									num3 = num5;
									num2 = num6;
									this.vmethod_85().vmethod_2();
								}
								this.vmethod_85().nullable_1 = null;
							}
						}
					}
					else
					{
						if (!this.scenario_0.MinuteIsChangingOnThisPulse && !Information.IsNothing(this.vmethod_85().nullable_1))
						{
							this.vmethod_10(this.vmethod_85().nullable_1.Value);
						}
						else
						{
							if (flag && this.vmethod_85().method_44())
							{
								this.vmethod_85().method_18();
							}
							double double_7;
							double double_8;
							if (this.vmethod_85().method_10(num3, num2, ref double_7, ref double_8, false, false, true, 0f, ref list, false))
							{
								this.vmethod_85().nullable_1 = new float?(Math2.smethod_17(this.vmethod_30(null), this.vmethod_28(null), double_7, double_8));
								this.vmethod_10(this.vmethod_85().nullable_1.Value);
								this.vmethod_85().vmethod_2();
							}
						}
						this.vmethod_31(null, num3);
						this.vmethod_29(null, num2);
					}
					this.vmethod_31(null, num3);
					this.vmethod_29(null, num2);
					if (double.IsNaN(this.vmethod_30(null)))
					{
						this.vmethod_31(null, this.vmethod_34());
					}
					if (double.IsNaN(this.vmethod_28(null)))
					{
						this.vmethod_29(null, this.vmethod_32());
					}
					if (!bool_42)
					{
						base.method_49(float_35);
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100875", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00007348 File Offset: 0x00005548
		[CompilerGenerated]
		private double method_181(Aircraft aircraft_0)
		{
			return base.method_31(aircraft_0);
		}

		// Token: 0x0400077B RID: 1915
		public float float_25;

		// Token: 0x0400077C RID: 1916
		public Aircraft._AircraftType _AircraftType_0;

		// Token: 0x0400077D RID: 1917
		public Aircraft.Enum40 enum40_0;

		// Token: 0x0400077E RID: 1918
		public Aircraft.Enum41 enum41_0;

		// Token: 0x0400077F RID: 1919
		public int int_7;

		// Token: 0x04000780 RID: 1920
		public float float_26;

		// Token: 0x04000781 RID: 1921
		public float float_27;

		// Token: 0x04000782 RID: 1922
		public float float_28;

		// Token: 0x04000783 RID: 1923
		private Loadout loadout_0;

		// Token: 0x04000784 RID: 1924
		internal float float_29;

		// Token: 0x04000785 RID: 1925
		public float float_30;

		// Token: 0x04000786 RID: 1926
		public float float_31;

		// Token: 0x04000787 RID: 1927
		public GlobalVariables.ArmorRating armorRating_0;

		// Token: 0x04000788 RID: 1928
		public GlobalVariables.ArmorRating armorRating_1;

		// Token: 0x04000789 RID: 1929
		public GlobalVariables.ArmorRating armorRating_2;

		// Token: 0x0400078A RID: 1930
		public bool bool_27;

		// Token: 0x0400078B RID: 1931
		public bool bool_28;

		// Token: 0x0400078C RID: 1932
		public bool bool_29;

		// Token: 0x0400078D RID: 1933
		public bool bool_30;

		// Token: 0x0400078E RID: 1934
		public bool bool_31;

		// Token: 0x0400078F RID: 1935
		private bool bool_32;

		// Token: 0x04000790 RID: 1936
		private bool bool_33;

		// Token: 0x04000791 RID: 1937
		private bool bool_34;

		// Token: 0x04000792 RID: 1938
		public bool bool_35;

		// Token: 0x04000793 RID: 1939
		public bool bool_36;

		// Token: 0x04000794 RID: 1940
		public bool bool_37;

		// Token: 0x04000795 RID: 1941
		public bool bool_38;

		// Token: 0x04000796 RID: 1942
		public GlobalVariables.AircraftSizeClass aircraftSizeClass_0;

		// Token: 0x04000797 RID: 1943
		public GlobalVariables.Enum146 enum146_0;

		// Token: 0x04000798 RID: 1944
		public Aircraft.Enum39 enum39_0;

		// Token: 0x04000799 RID: 1945
		public bool bool_39;

		// Token: 0x0400079A RID: 1946
		public bool bool_40;

		// Token: 0x0400079B RID: 1947
		public bool bool_41;

		// Token: 0x0400079C RID: 1948
		public float float_32;

		// Token: 0x0400079D RID: 1949
		public ActiveUnit activeUnit_0;

		// Token: 0x0400079E RID: 1950
		public float float_33;

		// Token: 0x0400079F RID: 1951
		public float float_34;

		// Token: 0x040007A0 RID: 1952
		public Aircraft.Enum38 enum38_0;

		// Token: 0x040007A1 RID: 1953
		public Aircraft.Enum38 enum38_1;

		// Token: 0x040007A2 RID: 1954
		public Aircraft.Enum38 enum38_2;

		// Token: 0x040007A3 RID: 1955
		private Class211 class211_0;

		// Token: 0x040007A4 RID: 1956
		private Aircraft_AI aircraft_AI_0;

		// Token: 0x040007A5 RID: 1957
		private Aircraft_Kinematics aircraft_Kinematics_0;

		// Token: 0x040007A6 RID: 1958
		private Class218 class218_0;

		// Token: 0x040007A7 RID: 1959
		private Aircraft_Weaponry aircraft_Weaponry_0;

		// Token: 0x040007A8 RID: 1960
		private Class180 class180_0;

		// Token: 0x040007A9 RID: 1961
		private Aircraft_Damage aircraft_Damage_0;

		// Token: 0x040007AA RID: 1962
		private Aircraft_AirOps aircraft_AirOps_0;

		// Token: 0x040007AB RID: 1963
		private float? nullable_16;

		// Token: 0x0200017F RID: 383
		internal enum Enum38
		{
			// Token: 0x040007AD RID: 1965
			const_0,
			// Token: 0x040007AE RID: 1966
			const_1,
			// Token: 0x040007AF RID: 1967
			const_2,
			// Token: 0x040007B0 RID: 1968
			const_3
		}

		// Token: 0x02000180 RID: 384
		internal enum Enum39 : byte
		{
			// Token: 0x040007B2 RID: 1970
			const_0,
			// Token: 0x040007B3 RID: 1971
			const_1,
			// Token: 0x040007B4 RID: 1972
			const_2,
			// Token: 0x040007B5 RID: 1973
			const_3
		}

		// Token: 0x02000181 RID: 385
		internal enum Enum40 : short
		{
			// Token: 0x040007B7 RID: 1975
			const_0 = 1001,
			// Token: 0x040007B8 RID: 1976
			const_1 = 2001,
			// Token: 0x040007B9 RID: 1977
			const_2,
			// Token: 0x040007BA RID: 1978
			const_3,
			// Token: 0x040007BB RID: 1979
			const_4,
			// Token: 0x040007BC RID: 1980
			const_5,
			// Token: 0x040007BD RID: 1981
			const_6,
			// Token: 0x040007BE RID: 1982
			const_7,
			// Token: 0x040007BF RID: 1983
			const_8
		}

		// Token: 0x02000182 RID: 386
		internal enum Enum41
		{
			// Token: 0x040007C1 RID: 1985
			const_0,
			// Token: 0x040007C2 RID: 1986
			const_1 = 9101,
			// Token: 0x040007C3 RID: 1987
			const_2,
			// Token: 0x040007C4 RID: 1988
			const_3,
			// Token: 0x040007C5 RID: 1989
			const_4,
			// Token: 0x040007C6 RID: 1990
			const_5 = 9111,
			// Token: 0x040007C7 RID: 1991
			const_6,
			// Token: 0x040007C8 RID: 1992
			const_7,
			// Token: 0x040007C9 RID: 1993
			const_8,
			// Token: 0x040007CA RID: 1994
			const_9 = 9121,
			// Token: 0x040007CB RID: 1995
			const_10,
			// Token: 0x040007CC RID: 1996
			const_11,
			// Token: 0x040007CD RID: 1997
			const_12,
			// Token: 0x040007CE RID: 1998
			const_13 = 9185,
			// Token: 0x040007CF RID: 1999
			const_14,
			// Token: 0x040007D0 RID: 2000
			const_15 = 9191,
			// Token: 0x040007D1 RID: 2001
			const_16,
			// Token: 0x040007D2 RID: 2002
			const_17 = 9199
		}

		// Token: 0x02000183 RID: 387
		public enum _AircraftType
		{
			// Token: 0x040007D4 RID: 2004
			None = 1001,
			// Token: 0x040007D5 RID: 2005
			Fighter = 2001,
			// Token: 0x040007D6 RID: 2006
			Multirole,
			// Token: 0x040007D7 RID: 2007
			ASAT = 2101,
			// Token: 0x040007D8 RID: 2008
			AirborneLaserPlatform,
			// Token: 0x040007D9 RID: 2009
			Attack = 3001,
			// Token: 0x040007DA RID: 2010
			WildWeasel,
			// Token: 0x040007DB RID: 2011
			Bomber = 3101,
			// Token: 0x040007DC RID: 2012
			CAS = 3401,
			// Token: 0x040007DD RID: 2013
			OECM = 4001,
			// Token: 0x040007DE RID: 2014
			AEW,
			// Token: 0x040007DF RID: 2015
			AirborneCP,
			// Token: 0x040007E0 RID: 2016
			SAR = 4101,
			// Token: 0x040007E1 RID: 2017
			MCM = 4201,
			// Token: 0x040007E2 RID: 2018
			ASW = 6001,
			// Token: 0x040007E3 RID: 2019
			MPA,
			// Token: 0x040007E4 RID: 2020
			ForwardObserver = 7001,
			// Token: 0x040007E5 RID: 2021
			AreaSurveillance,
			// Token: 0x040007E6 RID: 2022
			Recon,
			// Token: 0x040007E7 RID: 2023
			ELINT,
			// Token: 0x040007E8 RID: 2024
			SIGINT,
			// Token: 0x040007E9 RID: 2025
			Transport = 7101,
			// Token: 0x040007EA RID: 2026
			Cargo = 7201,
			// Token: 0x040007EB RID: 2027
			Commercial = 7301,
			// Token: 0x040007EC RID: 2028
			Civilian,
			// Token: 0x040007ED RID: 2029
			Utility = 7401,
			// Token: 0x040007EE RID: 2030
			Utility_Naval,
			// Token: 0x040007EF RID: 2031
			Tanker = 8001,
			// Token: 0x040007F0 RID: 2032
			Trainer = 8101,
			// Token: 0x040007F1 RID: 2033
			TargetTowing,
			// Token: 0x040007F2 RID: 2034
			TargetDrone,
			// Token: 0x040007F3 RID: 2035
			UAV = 8201,
			// Token: 0x040007F4 RID: 2036
			UCAV,
			// Token: 0x040007F5 RID: 2037
			AirShip = 8901,
			// Token: 0x040007F6 RID: 2038
			Aerostat,
			// Token: 0x040007F7 RID: 2039
			IMGSAT = 9001,
			// Token: 0x040007F8 RID: 2040
			RORSAT,
			// Token: 0x040007F9 RID: 2041
			EORSAT
		}

		// Token: 0x02000185 RID: 389
		[CompilerGenerated]
		internal sealed class Class238
		{
			// Token: 0x06000BC7 RID: 3015 RVA: 0x00008699 File Offset: 0x00006899
			internal bool method_0(AltBand altBand_1)
			{
				return altBand_1.float_1 >= this.altBand_0.float_0;
			}

			// Token: 0x040007FF RID: 2047
			public AltBand altBand_0;
		}
	}
}
