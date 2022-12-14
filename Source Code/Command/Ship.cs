using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
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
	// Token: 0x02000320 RID: 800
	public sealed class Ship : Class350, Interface3, Interface5
	{
		// Token: 0x060017A6 RID: 6054 RVA: 0x001AE960 File Offset: 0x001ACB60
		private Ship()
		{
			Scenario scenario = null;
			base..ctor(ref scenario, null);
			this.struct34_0 = default(Ship.Struct34);
			this.class347_0 = new Class347(this);
			this.class345_0 = new Class345(this, "Bridge / CIC");
			this.bool_6 = true;
			this.bool_4 = true;
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x001AE9B0 File Offset: 0x001ACBB0
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				if (this.vmethod_7(false) != null)
				{
					xmlWriter_0.WriteStartElement("Ship");
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
						xmlWriter_0.WriteElementString("Lon", XmlConvert.ToString(this.vmethod_28(null)));
						xmlWriter_0.WriteElementString("Lat", XmlConvert.ToString(this.vmethod_30(null)));
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
						if (this.nullable_15 != null)
						{
							xmlWriter_0.WriteElementString("Prof", ((int)this.nullable_15.Value).ToString());
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
						xmlWriter_0.WriteElementString("TS", ((byte)this.vmethod_84()).ToString());
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
							List<Engine>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
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
						xmlWriter_0.WriteStartElement("Magazines");
						foreach (Magazine magazine in this.magazine_0)
						{
							xmlWriter_0.WriteRaw(magazine.method_23(hashSet_0, this.scenario_0));
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
						xmlWriter_0.WriteElementString("SBR_TF", XmlConvert.ToString(this.bool_19));
						XmlWriter xmlWriter8 = xmlWriter_0;
						string localName8 = "SBR_ThrottleSetting";
						b = (byte)this.throttle_1;
						xmlWriter8.WriteElementString(localName8, b.ToString());
						xmlWriter_0.WriteElementString("SBED_TF", XmlConvert.ToString(this.bool_20));
						XmlWriter xmlWriter9 = xmlWriter_0;
						string localName9 = "SBED_ThrottleSetting";
						b = (byte)this.throttle_2;
						xmlWriter9.WriteElementString(localName9, b.ToString());
						xmlWriter_0.WriteElementString("SBEO_TF", XmlConvert.ToString(this.bool_21));
						XmlWriter xmlWriter10 = xmlWriter_0;
						string localName10 = "SBEO_ThrottleSetting";
						b = (byte)this.throttle_3;
						xmlWriter10.WriteElementString(localName10, b.ToString());
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
						if (this.bool_26)
						{
							xmlWriter_0.WriteElementString("DEC", this.bool_26.ToString());
						}
						this.doctrine_0.method_282(ref xmlWriter_0, ref this.scenario_0, "Doctrine");
						xmlWriter_0.WriteStartElement("Rudder");
						this.class347_0.method_23(ref xmlWriter_0, ref hashSet_0, this.scenario_0);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("CIC");
						this.class345_0.method_23(ref xmlWriter_0, ref hashSet_0, this.scenario_0);
						xmlWriter_0.WriteEndElement();
						this.method_144().vmethod_0(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteStartElement("Ship_AI");
						if (this.method_145().activeUnit_0 == null)
						{
							this.method_145().activeUnit_0 = this;
						}
						this.method_145().vmethod_2(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Ship_Kinematics");
						this.method_146().vmethod_0(ref xmlWriter_0);
						xmlWriter_0.WriteEndElement();
						this.method_147().vmethod_2(ref xmlWriter_0);
						this.method_148().vmethod_2(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteStartElement("Ship_CommStuff");
						this.method_149().vmethod_0(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						this.method_150().vmethod_0(ref xmlWriter_0);
						this.vmethod_92().vmethod_0(ref xmlWriter_0, ref hashSet_0);
						ActiveUnit_DockingOps.smethod_6(this.vmethod_93(), ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100761", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x001AF4C4 File Offset: 0x001AD6C4
		public static Ship smethod_10(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_1)
		{
			Ship ship;
			try
			{
				ship = Ship.smethod_11(ref xmlNode_0, ref dictionary_0, ref scenario_1, scenario_1.LoadStockUnits);
			}
			catch (Exception1 exception)
			{
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				dictionary_0.Remove(innerText);
				ship = Ship.smethod_11(ref xmlNode_0, ref dictionary_0, ref scenario_1, true);
				string text = "";
				if (ship.method_120())
				{
					text = "(member of group: [" + ship.vmethod_65(false).Name + "])";
				}
				scenario_1.LoadingNotices.Add(string.Concat(new string[]
				{
					"The following ship:[",
					ship.Name,
					"]",
					text,
					" failed to shallow-rebuild because of a component missing. The ship was instead deep-rebuilt, and instantiated in its pristine DB-stock condition. All customizations present in the ship's components (damaged components, weapon additions/removals etc. etc.) have been lost. Please re-apply any necessary customizations either manually or using an SBR script."
				}));
			}
			return ship;
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x001AF598 File Offset: 0x001AD798
		private static Ship smethod_11(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_1, bool bool_27)
		{
			Ship result;
			try
			{
				Ship ship = new Ship();
				ship.scenario_0 = scenario_1;
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					result = (Ship)dictionary_0[innerText];
				}
				else
				{
					ship.vmethod_0(innerText);
					if (xmlNode_0.ChildNodes.Count == 1)
					{
						scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
						result = ship;
					}
					else
					{
						dictionary_0.Add(ship.string_0, ship);
						int num = Conversions.ToInteger(Misc.smethod_44(xmlNode_0.ChildNodes, "DBID").InnerText);
						try
						{
							DBFunctions.smethod_53(ref scenario_1, ref ship, num, bool_27);
						}
						catch (Exception ex)
						{
							dictionary_0.Remove(ship.string_0);
							scenario_1.LoadingNotices.Add("Ship with Database ID " + Conversions.ToString(num) + " is missing from the database and has not been loaded.");
							return null;
						}
						if (bool_27)
						{
							ship.method_99(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						}
						if (!bool_27)
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
										if (num2 <= 1717708934U)
										{
											if (num2 != 1305748348U)
											{
												if (num2 != 1717708934U)
												{
													continue;
												}
												if (Operators.CompareString(name, "CIC", false) == 0)
												{
													ship.class345_0 = Class345.smethod_2(ref xmlNode, ref dictionary_0);
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
														XmlNode xmlNode2 = (XmlNode)obj2;
														Cargo cargo = Cargo.smethod_2(ref xmlNode2, ref dictionary_0, ship);
														Class429.smethod_6(ref ship.cargo_0, cargo);
														cargo.method_19(ship);
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
										if (num2 != 2008421230U)
										{
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
														XmlNode xmlNode3 = (XmlNode)obj3;
														FuelRec fuelRec_ = FuelRec.smethod_0(ref xmlNode3, ref dictionary_0);
														Class429.smethod_19(ref ship.fuelRec_0, fuelRec_);
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
													XmlNode xmlNode4 = (XmlNode)obj4;
													DockFacility dockFacility = DockFacility.smethod_2(ref xmlNode4, ref dictionary_0, ref scenario_1);
													ship.method_104(dockFacility);
													dockFacility.method_19(ship);
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
										if (Operators.CompareString(name, "Comms", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj5 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode5 = (XmlNode)obj5;
												CommDevice commDevice = CommDevice.smethod_2(ref xmlNode5, ref dictionary_0, ship);
												ship.method_101(commDevice);
												commDevice.method_19(ship);
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
									if (num2 <= 3109521583U)
									{
										if (num2 != 2246682072U)
										{
											if (num2 != 2424405304U)
											{
												if (num2 != 3109521583U)
												{
													continue;
												}
												if (Operators.CompareString(name, "Rudder", false) == 0)
												{
													ship.class347_0 = Class347.smethod_2(ref xmlNode, ref dictionary_0);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "Sensors", false) != 0)
												{
													continue;
												}
												try
												{
													foreach (object obj6 in xmlNode.ChildNodes)
													{
														Sensor sensor = Sensor.smethod_2((XmlNode)obj6, dictionary_0, ship);
														Class429.smethod_24(ref ship.sensor_0, sensor);
														sensor.method_19(ship);
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
										}
										if (Operators.CompareString(name, "Propulsion", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj7 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode6 = (XmlNode)obj7;
												ActiveUnit activeUnit = ship;
												Engine engine = Engine.smethod_2(ref xmlNode6, ref dictionary_0, ref activeUnit);
												ship.vmethod_49().method_4(engine);
												engine.method_19(ship);
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
									if (num2 != 3760177291U)
									{
										if (num2 != 3847206928U)
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
												foreach (object obj8 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode7 = (XmlNode)obj8;
													AirFacility airFacility = AirFacility.smethod_3(ref xmlNode7, ref dictionary_0, ref scenario_1);
													ship.method_103(airFacility);
													airFacility.method_19(ship);
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
										if (Operators.CompareString(name, "Magazines", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj9 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode8 = (XmlNode)obj9;
												Magazine magazine = Magazine.smethod_6(ref xmlNode8, ref dictionary_0, ref scenario_1);
												ship.method_140(magazine);
												magazine.method_19(ship);
											}
											continue;
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
									if (Operators.CompareString(name, "Mounts", false) == 0)
									{
										try
										{
											foreach (object obj10 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode9 = (XmlNode)obj10;
												Mount mount = Mount.smethod_6(ref xmlNode9, ref dictionary_0, ship);
												if (mount != null)
												{
													ship.vmethod_51().method_4(mount);
													mount.method_19(ship);
												}
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
							foreach (object obj11 in xmlNode_0.ChildNodes)
							{
								XmlNode xmlNode10 = (XmlNode)obj11;
								string name2 = xmlNode10.Name;
								uint num2 = Class582.smethod_0(name2);
								ActiveUnit activeUnit;
								if (num2 > 1488303767U)
								{
									if (num2 <= 2923116889U)
									{
										if (num2 <= 2128224206U)
										{
											if (num2 <= 1836990821U)
											{
												if (num2 <= 1729717486U)
												{
													if (num2 != 1708783731U)
													{
														if (num2 != 1729717486U)
														{
															continue;
														}
														if (Operators.CompareString(name2, "Longitude", false) != 0)
														{
															continue;
														}
													}
													else
													{
														if (Operators.CompareString(name2, "CS", false) != 0)
														{
															continue;
														}
														goto IL_16F6;
													}
												}
												else if (num2 != 1738278884U)
												{
													if (num2 != 1836990821U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "Latitude", false) != 0)
													{
														continue;
													}
													goto IL_150E;
												}
												else
												{
													if (Operators.CompareString(name2, "SBED_TF", false) == 0)
													{
														ship.bool_20 = Conversions.ToBoolean(xmlNode10.InnerText);
														continue;
													}
													continue;
												}
											}
											else if (num2 <= 1992083866U)
											{
												if (num2 != 1953416793U)
												{
													if (num2 != 1992083866U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "Latitude_UnitEntersAreaCheck", false) == 0)
													{
														ship.vmethod_39(new double?(XmlConvert.ToDouble(xmlNode10.InnerText)));
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "AMP_OC_DSO", false) == 0)
													{
														ship.nullable_13 = new float?(XmlConvert.ToSingle(xmlNode10.InnerText));
														continue;
													}
													continue;
												}
											}
											else if (num2 != 2010780873U)
											{
												if (num2 != 2128224206U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "CH", false) != 0)
												{
													continue;
												}
												goto IL_18B3;
											}
											else
											{
												if (Operators.CompareString(name2, "CA", false) == 0)
												{
													goto IL_1164;
												}
												continue;
											}
										}
										else
										{
											if (num2 <= 2564648390U)
											{
												if (num2 <= 2323739590U)
												{
													if (num2 != 2247649009U)
													{
														if (num2 != 2323739590U)
														{
															continue;
														}
														if (Operators.CompareString(name2, "Sensory", false) == 0)
														{
															goto IL_11CC;
														}
														continue;
													}
													else
													{
														if (Operators.CompareString(name2, "AssignedMission", false) == 0 && xmlNode10.HasChildNodes)
														{
															XmlNode xmlNode11 = xmlNode10.ChildNodes[0];
															ship.string_4 = xmlNode11.InnerText;
															continue;
														}
														continue;
													}
												}
												else if (num2 != 2496321123U)
												{
													if (num2 != 2564648390U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "Lon", false) == 0)
													{
														goto IL_124C;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "RangeSymbols", false) != 0)
													{
														continue;
													}
													try
													{
														foreach (object obj12 in xmlNode10.ChildNodes)
														{
															RangeSymbol item = RangeSymbol.smethod_0((XmlNode)obj12, dictionary_0);
															ship.method_17().Add(item);
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
											if (num2 <= 2749693904U)
											{
												if (num2 != 2590053246U)
												{
													if (num2 != 2749693904U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "DesiredSpeed", false) == 0)
													{
														goto IL_1317;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Side", false) == 0)
													{
														ship.string_7 = xmlNode10.InnerText;
														continue;
													}
													continue;
												}
											}
											else if (num2 != 2874698282U)
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
													string innerText2 = xmlNode10.InnerText;
													if (Operators.CompareString(innerText2, "FullStop", false) == 0)
													{
														ship.throttle_1 = ActiveUnit.Throttle.FullStop;
														continue;
													}
													if (Operators.CompareString(innerText2, "Loiter", false) == 0)
													{
														ship.throttle_1 = ActiveUnit.Throttle.Loiter;
														continue;
													}
													if (Operators.CompareString(innerText2, "Cruise", false) == 0)
													{
														ship.throttle_1 = ActiveUnit.Throttle.Cruise;
														continue;
													}
													if (Operators.CompareString(innerText2, "Full", false) == 0)
													{
														ship.throttle_1 = ActiveUnit.Throttle.Full;
														continue;
													}
													if (Operators.CompareString(innerText2, "Flank", false) != 0)
													{
														ship.throttle_1 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
														continue;
													}
													ship.throttle_1 = ActiveUnit.Throttle.Flank;
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Message", false) == 0)
													{
														ship.string_3 = xmlNode10.InnerText;
														continue;
													}
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "AssignedTaskPool", false) == 0 && xmlNode10.HasChildNodes)
												{
													XmlNode xmlNode12 = xmlNode10.ChildNodes[0];
													ship.string_5 = xmlNode12.InnerText;
													continue;
												}
												continue;
											}
										}
										IL_124C:
										ship.vmethod_29(null, XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", ".")));
										continue;
									}
									if (num2 <= 3251319825U)
									{
										if (num2 <= 3137208970U)
										{
											if (num2 <= 3020647921U)
											{
												if (num2 != 3001749054U)
												{
													if (num2 != 3020647921U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "ActiveUnit_DockingOps", false) == 0)
													{
														ActiveUnit activeUnit2 = ship;
														activeUnit = ship;
														activeUnit2.activeUnit_DockingOps_0 = ActiveUnit_DockingOps.smethod_7(ref xmlNode10, ref dictionary_0, ref activeUnit);
														continue;
													}
													continue;
												}
												else if (Operators.CompareString(name2, "Lat", false) != 0)
												{
													continue;
												}
											}
											else if (num2 != 3045369646U)
											{
												if (num2 != 3137208970U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Ship_Kinematics", false) == 0)
												{
													ActiveUnit_Kinematics.smethod_0(xmlNode10, dictionary_0, ship);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Ship_AI", false) == 0)
												{
													Ship ship2 = ship;
													activeUnit = ship;
													ship2.ship_AI_0 = Ship_AI.smethod_1(ref xmlNode10, ref dictionary_0, ref activeUnit);
													continue;
												}
												continue;
											}
										}
										else if (num2 <= 3189373444U)
										{
											if (num2 != 3164489068U)
											{
												if (num2 != 3189373444U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "LonLR", false) == 0)
												{
													ship.method_59(new double?(XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", "."))));
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "AMP_OC", false) == 0)
												{
													ship.bool_17 = Conversions.ToBoolean(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 3204468496U)
										{
											if (num2 != 3251319825U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "SBR_TF", false) == 0)
											{
												ship.bool_19 = Conversions.ToBoolean(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "SBEO", false) == 0)
											{
												ship._ActiveUnitStatus_4 = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 3559367371U)
									{
										if (num2 <= 3370184216U)
										{
											if (num2 != 3283119613U)
											{
												if (num2 != 3370184216U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "DesiredTurnRate", false) == 0)
												{
													goto IL_16CD;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "CurrentSpeed", false) == 0)
												{
													goto IL_16F6;
												}
												continue;
											}
										}
										else if (num2 != 3389022305U)
										{
											if (num2 != 3559367371U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "SBEO_ThrottleSetting", false) != 0)
											{
												continue;
											}
											string innerText3 = xmlNode10.InnerText;
											if (Operators.CompareString(innerText3, "FullStop", false) == 0)
											{
												ship.throttle_3 = ActiveUnit.Throttle.FullStop;
												continue;
											}
											if (Operators.CompareString(innerText3, "Loiter", false) == 0)
											{
												ship.throttle_3 = ActiveUnit.Throttle.Loiter;
												continue;
											}
											if (Operators.CompareString(innerText3, "Cruise", false) == 0)
											{
												ship.throttle_3 = ActiveUnit.Throttle.Cruise;
												continue;
											}
											if (Operators.CompareString(innerText3, "Full", false) == 0)
											{
												ship.throttle_3 = ActiveUnit.Throttle.Full;
												continue;
											}
											if (Operators.CompareString(innerText3, "Flank", false) != 0)
											{
												ship.throttle_3 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											ship.throttle_3 = ActiveUnit.Throttle.Flank;
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "SBED", false) == 0)
											{
												ship._ActiveUnitStatus_3 = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 3736393060U)
									{
										if (num2 != 3561877201U)
										{
											if (num2 != 3736393060U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "ParentGroup", false) == 0)
											{
												ship.string_6 = xmlNode10.InnerText;
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "Ship_Damage", false) == 0)
											{
												Ship ship3 = ship;
												activeUnit = ship;
												ship3.class186_0 = Class186.smethod_1(ref xmlNode10, ref dictionary_0, ref activeUnit);
												continue;
											}
											continue;
										}
									}
									else if (num2 != 3792306253U)
									{
										if (num2 != 4080539297U)
										{
											if (num2 == 4152621540U && Operators.CompareString(name2, "CurrentHeading", false) == 0)
											{
												goto IL_18B3;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "IsAutoDetectable", false) == 0)
											{
												goto IL_18E5;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "Longitude_UnitEntersAreaCheck", false) == 0)
										{
											ship.vmethod_37(new double?(XmlConvert.ToDouble(xmlNode10.InnerText)));
											continue;
										}
										continue;
									}
									IL_150E:
									ship.vmethod_31(null, XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", ".")));
									continue;
									IL_16F6:
									ship.vmethod_41(XmlConvert.ToSingle(xmlNode10.InnerText.Replace(",", ".")));
									continue;
									IL_18B3:
									ship.vmethod_10(XmlConvert.ToSingle(xmlNode10.InnerText.Replace(",", ".")));
									continue;
								}
								if (num2 <= 803760973U)
								{
									if (num2 <= 441941816U)
									{
										if (num2 > 266367750U)
										{
											if (num2 <= 334092753U)
											{
												if (num2 != 273958740U)
												{
													if (num2 != 334092753U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "DTN", false) != 0)
													{
														continue;
													}
												}
												else
												{
													if (Operators.CompareString(name2, "AMP_OC_Speed", false) == 0)
													{
														ship.float_16 = XmlConvert.ToSingle(xmlNode10.InnerText);
														continue;
													}
													continue;
												}
											}
											else if (num2 != 429749699U)
											{
												if (num2 != 441941816U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "CurrentAltitude", false) != 0)
												{
													continue;
												}
												goto IL_1164;
											}
											else if (Operators.CompareString(name2, "DesiredTurnRate_Navigation", false) != 0)
											{
												continue;
											}
											ship.vmethod_81((Waypoint.Enum81)Conversions.ToByte(xmlNode10.InnerText));
											continue;
										}
										if (num2 <= 100238421U)
										{
											if (num2 != 6222351U)
											{
												if (num2 != 100238421U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Ship_Sensory", false) != 0)
												{
													continue;
												}
												goto IL_11CC;
											}
											else
											{
												if (Operators.CompareString(name2, "Status", false) != 0)
												{
													continue;
												}
												if (Versioned.IsNumeric(xmlNode10.InnerText))
												{
													ship.vmethod_109((ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText));
												}
												else
												{
													ship.vmethod_109((ActiveUnit._ActiveUnitStatus)Enum.Parse(typeof(ActiveUnit._ActiveUnitStatus), xmlNode10.InnerText, true));
												}
												if (ship.vmethod_108() == (ActiveUnit._ActiveUnitStatus)9)
												{
													ship.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 263373746U)
										{
											if (num2 != 266367750U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "Name", false) == 0)
											{
												ship.Name = xmlNode10.InnerText;
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "FSBR", false) == 0)
											{
												ship._ActiveUnitFuelState_1 = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 634280640U)
									{
										if (num2 <= 485784328U)
										{
											if (num2 != 454106749U)
											{
												if (num2 != 485784328U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "IsAD", false) != 0)
												{
													continue;
												}
												goto IL_18E5;
											}
											else
											{
												if (Operators.CompareString(name2, "SBPF_TF", false) == 0)
												{
													ship.bool_22 = Conversions.ToBoolean(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 506380204U)
										{
											if (num2 != 634280640U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "DS", false) != 0)
											{
												continue;
											}
											goto IL_1317;
										}
										else
										{
											if (Operators.CompareString(name2, "LatLR", false) == 0)
											{
												ship.method_57(new double?(XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", "."))));
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 664498478U)
									{
										if (num2 != 636840496U)
										{
											if (num2 != 664498478U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "FuelState", false) == 0)
											{
												ship._ActiveUnitFuelState_0 = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name2, "TS", false) != 0)
										{
											continue;
										}
									}
									else if (num2 != 742107497U)
									{
										if (num2 != 751723973U)
										{
											if (num2 != 803760973U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "DamagePts", false) == 0 && !bool_27)
											{
												ship.vmethod_64(true, null, XmlConvert.ToSingle(xmlNode10.InnerText));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "DT", false) != 0)
											{
												continue;
											}
											goto IL_16CD;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "Ship_Navigator", false) == 0)
										{
											Ship ship4 = ship;
											activeUnit = ship;
											ship4.class214_0 = Class214.smethod_8(ref xmlNode10, ref dictionary_0, ref activeUnit);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (num2 <= 1156592502U)
									{
										if (num2 <= 892023141U)
										{
											if (num2 <= 882606391U)
											{
												if (num2 != 812114866U)
												{
													if (num2 != 882606391U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "AMP_OC_DAO", false) == 0)
													{
														ship.bool_18 = Conversions.ToBoolean(xmlNode10.InnerText);
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "COA", false) == 0)
													{
														ship.int_5 = Conversions.ToInteger(xmlNode10.InnerText);
														continue;
													}
													continue;
												}
											}
											else if (num2 != 889154257U)
											{
												if (num2 != 892023141U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "DesiredHeading", false) != 0)
												{
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "Ship_Weaponry", false) == 0)
												{
													Ship ship5 = ship;
													activeUnit = ship;
													ship5.class228_0 = Class228.smethod_6(ref xmlNode10, ref dictionary_0, ref activeUnit);
													continue;
												}
												continue;
											}
										}
										else if (num2 <= 1078362002U)
										{
											if (num2 != 967155461U)
											{
												if (num2 != 1078362002U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Ship_CommStuff", false) == 0)
												{
													Ship ship6 = ship;
													activeUnit = ship;
													ship6.class183_0 = Class183.smethod_1(ref xmlNode10, ref dictionary_0, ref activeUnit);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBPF_ThrottleSetting", false) != 0)
												{
													continue;
												}
												string innerText4 = xmlNode10.InnerText;
												if (Operators.CompareString(innerText4, "FullStop", false) == 0)
												{
													ship.throttle_4 = ActiveUnit.Throttle.FullStop;
													continue;
												}
												if (Operators.CompareString(innerText4, "Loiter", false) == 0)
												{
													ship.throttle_4 = ActiveUnit.Throttle.Loiter;
													continue;
												}
												if (Operators.CompareString(innerText4, "Cruise", false) == 0)
												{
													ship.throttle_4 = ActiveUnit.Throttle.Cruise;
													continue;
												}
												if (Operators.CompareString(innerText4, "Full", false) == 0)
												{
													ship.throttle_4 = ActiveUnit.Throttle.Full;
													continue;
												}
												if (Operators.CompareString(innerText4, "Flank", false) != 0)
												{
													ship.throttle_4 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
													continue;
												}
												ship.throttle_4 = ActiveUnit.Throttle.Flank;
												continue;
											}
										}
										else if (num2 != 1087276353U)
										{
											if (num2 != 1156592502U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "SBR", false) == 0)
											{
												ship._ActiveUnitStatus_2 = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name2, "DH", false) != 0)
										{
											continue;
										}
										ship.vmethod_69(ActiveUnit.Enum28.const_0, XmlConvert.ToSingle(xmlNode10.InnerText));
										continue;
									}
									if (num2 <= 1259548010U)
									{
										if (num2 <= 1192164083U)
										{
											if (num2 != 1175569298U)
											{
												if (num2 != 1192164083U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "DEC", false) == 0)
												{
													ship.bool_26 = Conversions.ToBoolean(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "ActiveUnit_AirOps", false) == 0)
												{
													ActiveUnit activeUnit3 = ship;
													activeUnit = ship;
													activeUnit3.activeUnit_AirOps_0 = ActiveUnit_AirOps.smethod_0(ref xmlNode10, ref dictionary_0, ref activeUnit);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 1255847155U)
										{
											if (num2 != 1259548010U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "SBED_ThrottleSetting", false) != 0)
											{
												continue;
											}
											string innerText5 = xmlNode10.InnerText;
											if (Operators.CompareString(innerText5, "FullStop", false) == 0)
											{
												ship.throttle_2 = ActiveUnit.Throttle.FullStop;
												continue;
											}
											if (Operators.CompareString(innerText5, "Loiter", false) == 0)
											{
												ship.throttle_2 = ActiveUnit.Throttle.Loiter;
												continue;
											}
											if (Operators.CompareString(innerText5, "Cruise", false) == 0)
											{
												ship.throttle_2 = ActiveUnit.Throttle.Cruise;
												continue;
											}
											if (Operators.CompareString(innerText5, "Full", false) == 0)
											{
												ship.throttle_2 = ActiveUnit.Throttle.Full;
												continue;
											}
											if (Operators.CompareString(innerText5, "Flank", false) != 0)
											{
												ship.throttle_2 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											ship.throttle_2 = ActiveUnit.Throttle.Flank;
											continue;
										}
										else if (Operators.CompareString(name2, "ThrottleSetting", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (num2 <= 1422437055U)
										{
											if (num2 != 1339890663U)
											{
												if (num2 != 1422437055U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Doctrine", false) == 0)
												{
													ship.doctrine_0 = Doctrine.smethod_9(ref xmlNode10, ship);
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
													foreach (object obj13 in xmlNode10.ChildNodes)
													{
														string innerText6 = ((XmlNode)obj13).InnerText;
														ship.list_0.Add(innerText6);
													}
													continue;
												}
												finally
												{
													IEnumerator enumerator13;
													if (enumerator13 is IDisposable)
													{
														(enumerator13 as IDisposable).Dispose();
													}
												}
											}
										}
										if (num2 != 1444793274U)
										{
											if (num2 != 1476905714U)
											{
												if (num2 != 1488303767U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "SBEO_TF", false) == 0)
												{
													ship.bool_21 = Conversions.ToBoolean(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "WeaponState", false) == 0)
												{
													ship._ActiveUnitWeaponState_0 = (ActiveUnit._ActiveUnitWeaponState)Conversions.ToByte(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "Prof", false) == 0)
											{
												ship.vmethod_54(new GlobalVariables.ProficiencyLevel?((GlobalVariables.ProficiencyLevel)Conversions.ToInteger(xmlNode10.InnerText)));
												continue;
											}
											continue;
										}
									}
								}
								string innerText7 = xmlNode10.InnerText;
								if (Operators.CompareString(innerText7, "FullStop", false) == 0)
								{
									ship.throttle_0 = ActiveUnit.Throttle.FullStop;
									continue;
								}
								if (Operators.CompareString(innerText7, "Loiter", false) == 0)
								{
									ship.throttle_0 = ActiveUnit.Throttle.Loiter;
									continue;
								}
								if (Operators.CompareString(innerText7, "Cruise", false) == 0)
								{
									ship.throttle_0 = ActiveUnit.Throttle.Cruise;
									continue;
								}
								if (Operators.CompareString(innerText7, "Full", false) == 0)
								{
									ship.throttle_0 = ActiveUnit.Throttle.Full;
									continue;
								}
								if (Operators.CompareString(innerText7, "Flank", false) != 0)
								{
									ship.throttle_0 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
									continue;
								}
								ship.throttle_0 = ActiveUnit.Throttle.Flank;
								continue;
								IL_1164:
								ship.vmethod_15(false, XmlConvert.ToSingle(xmlNode10.InnerText.Replace(",", ".")));
								continue;
								IL_11CC:
								Ship ship7 = ship;
								activeUnit = ship;
								ship7.class221_0 = Class221.smethod_10(ref xmlNode10, ref dictionary_0, ref activeUnit);
								continue;
								IL_1317:
								ship.vmethod_71(XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_16CD:
								ship.vmethod_79((ActiveUnit.Enum28)Conversions.ToByte(xmlNode10.InnerText));
								continue;
								IL_18E5:
								ship.method_93(null, Conversions.ToBoolean(xmlNode10.InnerText));
							}
						}
						finally
						{
							IEnumerator enumerator11;
							if (enumerator11 is IDisposable)
							{
								(enumerator11 as IDisposable).Dispose();
							}
						}
						result = ship;
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100762", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Ship();
			}
			return result;
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x0000C61A File Offset: 0x0000A81A
		public override float vmethod_139()
		{
			return this.float_13 * this.float_25;
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0000C629 File Offset: 0x0000A829
		public override GlobalVariables.ActiveUnitType vmethod_56()
		{
			return GlobalVariables.ActiveUnitType.Ship;
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x001B1098 File Offset: 0x001AF298
		public unsafe override void vmethod_102(Mission value, bool SetMissionOnly, ref Mission.MissionAssignmentAttemptResult Result = Mission.MissionAssignmentAttemptResult*.None)
		{
			try
			{
				base.vmethod_102(value, SetMissionOnly, ref Result);
				if (Result == Mission.MissionAssignmentAttemptResult.Success)
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.scenario_0.method_42())
						{
							if (activeUnit != null && activeUnit.bool_5 && ((Submarine)activeUnit).method_159() && activeUnit.vmethod_93().method_11(true) == this)
							{
								ActiveUnit activeUnit2 = activeUnit;
								Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
								activeUnit2.vmethod_102(value, SetMissionOnly, ref missionAssignmentAttemptResult);
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100763", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x001B1174 File Offset: 0x001AF374
		public override int vmethod_131(bool bool_27)
		{
			int result;
			if (this.vmethod_59())
			{
				if (bool_27)
				{
					result = Math.Max((int)Math.Round((double)base.vmethod_131(bool_27) * 0.3), 1000);
				}
				else
				{
					result = (int)Math.Round((double)base.vmethod_131(bool_27) * 0.1);
				}
			}
			else if (bool_27)
			{
				result = base.vmethod_131(bool_27) * 3;
			}
			else
			{
				result = base.vmethod_131(bool_27);
			}
			return result;
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x001B11E4 File Offset: 0x001AF3E4
		public override bool vmethod_59()
		{
			Ship._ShipType shipType_ = this._ShipType_0;
			checked
			{
				if (shipType_ != Ship._ShipType.MCDV)
				{
					switch (shipType_)
					{
					case Ship._ShipType.MCD:
					case Ship._ShipType.MCM:
					case Ship._ShipType.MCS:
					case Ship._ShipType.MHC:
					case Ship._ShipType.MSC:
					case Ship._ShipType.MSF:
					case Ship._ShipType.MSI:
					case Ship._ShipType.MSO:
						break;
					default:
					{
						if (this.vmethod_95().Count > 0)
						{
							return true;
						}
						Sensor[] array = base.method_78();
						for (int i = 0; i < array.Length; i++)
						{
							if (array[i].method_70())
							{
								return true;
							}
						}
						return false;
					}
					}
				}
				return true;
			}
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x000041ED File Offset: 0x000023ED
		public override bool vmethod_60()
		{
			return true;
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x000084CC File Offset: 0x000066CC
		public override ActiveUnit._ActiveUnitStatus vmethod_108()
		{
			return base.vmethod_108();
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x0000C62C File Offset: 0x0000A82C
		public override void vmethod_109(ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_6)
		{
			bool flag = _ActiveUnitStatus_6 != this.vmethod_108();
			base.vmethod_109(_ActiveUnitStatus_6);
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x0000C642 File Offset: 0x0000A842
		public override float vmethod_68()
		{
			return base.vmethod_68();
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x0000C64A File Offset: 0x0000A84A
		public override float vmethod_70()
		{
			return base.vmethod_70();
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x001B1270 File Offset: 0x001AF470
		public override void vmethod_71(float float_34)
		{
			if (this.method_144().bool_15 && this.vmethod_108() != ActiveUnit._ActiveUnitStatus.EngagedDefensive)
			{
				float num = (float)this.method_146().method_7(0f);
				if (float_34 >= num)
				{
					float_34 = (float)((double)num - 0.1);
				}
			}
			if (float_34 != this.vmethod_70())
			{
				base.vmethod_71(float_34);
			}
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x001B12D0 File Offset: 0x001AF4D0
		public bool method_142()
		{
			return this._ShipType_0 != Ship._ShipType.LCAC && this.vmethod_40() >= (float)this.method_146().method_7(0f);
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x001B130C File Offset: 0x001AF50C
		public Ship.Enum119 method_143()
		{
			Ship.Enum119 result;
			if (this.vmethod_40() == 0f)
			{
				result = Ship.Enum119.const_0;
			}
			else if (this._ShipType_0 == Ship._ShipType.LCAC && !base.method_15())
			{
				result = Ship.Enum119.const_5;
			}
			else
			{
				float num = this.vmethod_40();
				if (num < 10f)
				{
					result = (Ship.Enum119)Math.Max(0, (int)(this.vmethod_121() - GlobalVariables.TargetVisualSizeClass.VSmall));
				}
				else if (num < 20f)
				{
					result = (Ship.Enum119)this.vmethod_121();
				}
				else if (num < 30f)
				{
					result = (Ship.Enum119)Math.Min(5, (int)(this.vmethod_121() + 1));
				}
				else if (num < 40f)
				{
					result = (Ship.Enum119)Math.Min(5, (int)(this.vmethod_121() + 2));
				}
				else
				{
					result = (Ship.Enum119)Math.Min(5, (int)(this.vmethod_121() + 3));
				}
			}
			return result;
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x001B13C0 File Offset: 0x001AF5C0
		public Class214 method_144()
		{
			if (Information.IsNothing(this.class214_0))
			{
				ActiveUnit activeUnit = this;
				this.class214_0 = new Class214(ref activeUnit);
			}
			return this.class214_0;
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x001B13F0 File Offset: 0x001AF5F0
		public Ship_AI method_145()
		{
			if (Information.IsNothing(this.ship_AI_0))
			{
				ActiveUnit activeUnit = this;
				this.ship_AI_0 = new Ship_AI(ref activeUnit);
			}
			return this.ship_AI_0;
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x001B1420 File Offset: 0x001AF620
		public Class202 method_146()
		{
			if (Information.IsNothing(this.class202_0))
			{
				ActiveUnit activeUnit = this;
				this.class202_0 = new Class202(ref activeUnit);
			}
			return this.class202_0;
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x001B1450 File Offset: 0x001AF650
		public Class221 method_147()
		{
			if (Information.IsNothing(this.class221_0))
			{
				ActiveUnit activeUnit = this;
				this.class221_0 = new Class221(ref activeUnit);
			}
			return this.class221_0;
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x001B1480 File Offset: 0x001AF680
		public Class228 method_148()
		{
			if (Information.IsNothing(this.class228_0))
			{
				ActiveUnit activeUnit = this;
				this.class228_0 = new Class228(ref activeUnit);
			}
			return this.class228_0;
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x001B14B0 File Offset: 0x001AF6B0
		public Class183 method_149()
		{
			if (Information.IsNothing(this.class183_0))
			{
				ActiveUnit activeUnit = this;
				this.class183_0 = new Class183(ref activeUnit);
			}
			return this.class183_0;
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x001B14E0 File Offset: 0x001AF6E0
		public Class186 method_150()
		{
			if (Information.IsNothing(this.class186_0))
			{
				ActiveUnit activeUnit = this;
				this.class186_0 = new Class186(ref activeUnit);
			}
			return this.class186_0;
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x001B1510 File Offset: 0x001AF710
		public override int vmethod_11()
		{
			int result;
			switch (this.vmethod_121())
			{
			case GlobalVariables.TargetVisualSizeClass.Stealthy:
				result = 3;
				break;
			case GlobalVariables.TargetVisualSizeClass.VSmall:
				result = 7;
				break;
			case GlobalVariables.TargetVisualSizeClass.Small:
				result = 14;
				break;
			case GlobalVariables.TargetVisualSizeClass.Medium:
				result = 25;
				break;
			case GlobalVariables.TargetVisualSizeClass.Large:
				result = 40;
				break;
			case GlobalVariables.TargetVisualSizeClass.VLarge:
				result = 50;
				break;
			default:
				result = 0;
				break;
			}
			return result;
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x001B1564 File Offset: 0x001AF764
		public override int vmethod_12()
		{
			int result;
			switch (this.vmethod_121())
			{
			case GlobalVariables.TargetVisualSizeClass.Stealthy:
				result = 2;
				break;
			case GlobalVariables.TargetVisualSizeClass.VSmall:
				result = 6;
				break;
			case GlobalVariables.TargetVisualSizeClass.Small:
				result = 10;
				break;
			case GlobalVariables.TargetVisualSizeClass.Medium:
				result = 15;
				break;
			case GlobalVariables.TargetVisualSizeClass.Large:
				result = 20;
				break;
			case GlobalVariables.TargetVisualSizeClass.VLarge:
				result = 25;
				break;
			default:
				result = 0;
				break;
			}
			return result;
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x001B15B8 File Offset: 0x001AF7B8
		public bool method_151()
		{
			if (this.nullable_16 == null)
			{
				this.nullable_16 = new bool?(false);
				try
				{
					List<Engine>.Enumerator enumerator = this.vmethod_49().GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.enum112_0 == Engine.Enum112.const_9)
						{
							this.nullable_16 = new bool?(true);
							break;
						}
					}
				}
				finally
				{
					List<Engine>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			return this.nullable_16.Value;
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x0000C652 File Offset: 0x0000A852
		public bool method_152()
		{
			return this.vmethod_63(false, null) <= 0f;
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x001B1644 File Offset: 0x001AF844
		public override GlobalVariables.TargetVisualSizeClass vmethod_121()
		{
			float float_ = this.float_13;
			GlobalVariables.TargetVisualSizeClass result;
			if (float_ > 280f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VLarge;
			}
			else if (float_ > 220f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Large;
			}
			else if (float_ > 120f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Medium;
			}
			else if (float_ > 45f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Small;
			}
			else if (float_ > 10f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VSmall;
			}
			else
			{
				result = GlobalVariables.TargetVisualSizeClass.Stealthy;
			}
			return result;
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x0000C666 File Offset: 0x0000A866
		public override void vmethod_122(ref Scenario scenario_1, Dictionary<string, Class310> dictionary_0, List<ActiveUnit> list_3, bool bool_27)
		{
			base.vmethod_122(ref scenario_1, dictionary_0, list_3, bool_27);
			ActiveUnit_DockingOps.smethod_8(this.vmethod_93(), ref scenario_1, dictionary_0, bool_27);
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x0000A4E5 File Offset: 0x000086E5
		public override void vmethod_126(float float_34, ref Random random_0)
		{
			this.vmethod_93().method_22(float_34);
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x001B1698 File Offset: 0x001AF898
		public override void vmethod_134(ActiveUnit.Throttle newThrottleSetting, float? SpecificDesiredSpeed = null)
		{
			try
			{
				if (this.vmethod_84() != newThrottleSetting || !Information.IsNothing(SpecificDesiredSpeed) || this.scenario_0.MinuteIsChangingOnThisPulse)
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
						if (Information.IsNothing(SpecificDesiredSpeed))
						{
							this.vmethod_71((float)this.method_146().vmethod_40(this.vmethod_14(false), this.throttle_0, false));
						}
						else if (!base.method_122() || !this.method_145().method_77())
						{
							if (this.method_146().vmethod_1() == ActiveUnit_Kinematics.UnitThrottlePreset.None)
							{
								float? num = SpecificDesiredSpeed;
								float num2 = (float)this.method_146().vmethod_40(this.vmethod_14(false), newThrottleSetting, false);
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
									num2 = (float)this.method_146().vmethod_33((float)((int)Math.Round((double)this.vmethod_14(false))), newThrottleSetting, false);
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
									this.throttle_0 = this.method_146().vmethod_41(this.vmethod_14(false), SpecificDesiredSpeed.Value);
									num = SpecificDesiredSpeed;
									num2 = (float)this.method_146().vmethod_40(this.vmethod_14(false), this.throttle_0, false);
									if (((num != null) ? new bool?(num.GetValueOrDefault() > num2) : null).GetValueOrDefault())
									{
										this.vmethod_71((float)this.method_146().vmethod_40(this.vmethod_14(false), this.throttle_0, false));
									}
								}
							}
							else
							{
								this.vmethod_71((float)this.method_146().vmethod_40(this.vmethod_14(false), (ActiveUnit.Throttle)this.method_146().vmethod_1(), false));
							}
						}
					}
					base.method_110(this, this.throttle_0);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100034957377", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x001B1990 File Offset: 0x001AFB90
		public override bool vmethod_47(double double_4, double double_5, ref int int_8, bool bool_27, bool bool_28, bool bool_29, ref bool bool_30, bool bool_31, ref bool bool_32, float? nullable_17, short? nullable_18, ref List<ActiveUnit> list_3, float float_34, bool bool_33, bool bool_34, ref string string_9, ref bool bool_35)
		{
			Ship.Class358 @class = new Ship.Class358();
			@class.ship_0 = this;
			@class.double_0 = double_4;
			@class.double_1 = double_5;
			@class.bool_1 = bool_27;
			@class.bool_0 = bool_28;
			@class.bool_2 = bool_29;
			bool result;
			try
			{
				Ship.Class359 class2 = new Ship.Class359();
				class2.class358_0 = @class;
				int_8 = 1;
				if (!double.IsNaN(class2.class358_0.double_0) && !double.IsNaN(class2.class358_0.double_1))
				{
					if (bool_33 && this.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive && this.vmethod_101() != null && this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
					{
						Class343 class3 = (Class343)this.vmethod_101();
						GeoPoint geoPoint = new GeoPoint(class2.class358_0.double_1, class2.class358_0.double_0);
						if (this.vmethod_46(class3.list_15, this.scenario_0, true) && !GeoPoint.smethod_4(geoPoint.imethod_2(), geoPoint.imethod_0(), class3.list_15, true))
						{
							bool_30 = false;
							bool_32 = false;
							string_9 = "The target has left the prosecution area.";
							return false;
						}
					}
					if (bool_34)
					{
						bool_30 = base.method_131();
					}
					if ((bool_30 || class2.class358_0.bool_1) && base.method_130(class2.class358_0.double_0, class2.class358_0.double_1, float_34))
					{
						bool_30 = true;
						bool_32 = false;
						string_9 = "The point is inside a No-Nav Zone.";
						result = false;
					}
					else if (!this.method_154(class2.class358_0.double_0, class2.class358_0.double_1, bool_31, nullable_18, ref list_3))
					{
						bool_30 = false;
						bool_32 = false;
						string_9 = "The unit cannot sail on land.";
						result = false;
					}
					else
					{
						class2.bool_0 = false;
						if (this.vmethod_7(false).hashSet_0.Count > 0)
						{
							Parallel.ForEach<string>(Enumerable.ToList<string>(this.vmethod_7(false).hashSet_0), new Action<string, ParallelLoopState>(class2.method_0));
							if (class2.bool_0)
							{
								bool_30 = false;
								bool_32 = true;
								if (!this.vmethod_59())
								{
									if (this.vmethod_101() == null || this.vmethod_101()._MissionClass_0 != Mission._MissionClass.MineClearing)
									{
										string_9 = "The unit is not a mine sweeper or mine hunter, and known mines are too close.";
										goto IL_218;
									}
								}
								string_9 = "A mine is too close.";
								IL_218:
								return false;
							}
						}
						bool_30 = false;
						bool_32 = false;
						result = true;
					}
				}
				else
				{
					bool_30 = false;
					bool_32 = false;
					string_9 = "Unknown.";
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200285", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				bool_30 = false;
				bool_32 = false;
				string_9 = "Error.";
				result = false;
			}
			return result;
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x000041ED File Offset: 0x000023ED
		public override bool vmethod_43()
		{
			return true;
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x0000C682 File Offset: 0x0000A882
		public bool method_153()
		{
			return this._ShipType_0 == Ship._ShipType.AGB;
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x001B1C44 File Offset: 0x001AFE44
		private bool method_154(double double_4, double double_5, bool bool_27, short? nullable_17, ref List<ActiveUnit> list_3)
		{
			bool result;
			try
			{
				if (this._ShipType_0 == Ship._ShipType.LCAC)
				{
					result = true;
				}
				else if (GeoPoint.smethod_11(double_4, double_5))
				{
					result = true;
				}
				else if ((Information.IsNothing(list_3) || list_3.Count > 0) && GeoPoint.smethod_10(double_4, double_5, this.scenario_0, ref list_3))
				{
					result = true;
				}
				else if (bool_27 && !this.method_153() && Class442.smethod_1(double_5, double_4))
				{
					result = false;
				}
				else
				{
					short num;
					if (Information.IsNothing(nullable_17))
					{
						num = Terrain.smethod_7(double_4, double_5, false);
					}
					else
					{
						num = nullable_17.Value;
					}
					if (num >= -2)
					{
						result = false;
					}
					else
					{
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100765", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x001B1D30 File Offset: 0x001AFF30
		public override long vmethod_114(ActiveUnit.Throttle throttle_5, AltBand altBand_0, float? nullable_17, float? nullable_18)
		{
			try
			{
				if (Enumerable.Count<FuelRec>(this.vmethod_67()) == 0)
				{
					return 0L;
				}
				FuelRec fuelRec = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Where<FuelRec>(Enumerable.Select<FuelRec, FuelRec>(this.vmethod_67(), (Ship._Closure$__.$I98-0 == null) ? (Ship._Closure$__.$I98-0 = new Func<FuelRec, FuelRec>(Ship._Closure$__.$I.method_0)) : Ship._Closure$__.$I98-0), new Func<FuelRec, bool>(this.method_156)), 0);
				if (Information.IsNothing(fuelRec))
				{
					return 0L;
				}
				float float_ = fuelRec.float_0;
				if (float_ == 0f)
				{
					return 0L;
				}
				if (throttle_5 == ActiveUnit.Throttle.FullStop)
				{
					return 2147483647L;
				}
				float num = this.vmethod_98(throttle_5, altBand_0, nullable_17, nullable_18, false, false, false, false, false);
				if (num == 0f)
				{
					return long.MaxValue;
				}
				return (long)Math.Round((double)(float_ / num));
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100766", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return 0L;
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x001B1E6C File Offset: 0x001B006C
		public override ActiveUnit._ActiveUnitFuelState vmethod_62(ActiveUnit activeUnit_0, GeoPoint geoPoint_0, Doctrine._FuelState? nullable_17)
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
					float num = base.method_36(activeUnit_0);
					if ((double)this.method_146().vmethod_29(null) >= (double)num * 1.1)
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
				ex.Data.Add("Error at 100767", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = ActiveUnit._ActiveUnitFuelState.None;
			}
			return result;
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x001B1F20 File Offset: 0x001B0120
		public override ActiveUnit._ActiveUnitFuelState vmethod_61(GeoPoint geoPoint_0, Doctrine._FuelState? nullable_17)
		{
			ActiveUnit._ActiveUnitFuelState result;
			try
			{
				if (this.method_151())
				{
					result = ActiveUnit._ActiveUnitFuelState.None;
				}
				else
				{
					ActiveUnit activeUnit = this.vmethod_93().method_2();
					if (Information.IsNothing(activeUnit))
					{
						result = ActiveUnit._ActiveUnitFuelState.None;
					}
					else if (activeUnit.method_82())
					{
						result = ActiveUnit._ActiveUnitFuelState.None;
					}
					else
					{
						result = this.vmethod_62(activeUnit, null, null);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100768", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = ActiveUnit._ActiveUnitFuelState.None;
			}
			return result;
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x001B1FBC File Offset: 0x001B01BC
		public override bool vmethod_105(ActiveUnit activeUnit_0)
		{
			return !activeUnit_0.bool_3 && (this.struct26_0.byte_5 > 0 || this.struct26_0.byte_7 > 0 || this.struct26_0.byte_3 > 0);
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x001B2010 File Offset: 0x001B0210
		public override bool vmethod_106()
		{
			return this.struct26_0.byte_5 > 0 || this.struct26_0.byte_7 > 0 || this.struct26_0.byte_3 > 0;
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x001B2058 File Offset: 0x001B0258
		public override bool vmethod_97()
		{
			bool result;
			try
			{
				if (this.method_151())
				{
					result = false;
				}
				else if (this.vmethod_49().Count == 0)
				{
					result = false;
				}
				else
				{
					FuelRec fuelRec = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Where<FuelRec>(Enumerable.Select<FuelRec, FuelRec>(this.vmethod_67(), (Ship._Closure$__.$I108-0 == null) ? (Ship._Closure$__.$I108-0 = new Func<FuelRec, FuelRec>(Ship._Closure$__.$I.method_1)) : Ship._Closure$__.$I108-0), new Func<FuelRec, bool>(this.method_157)), 0);
					if (Information.IsNothing(fuelRec))
					{
						result = true;
					}
					else if (fuelRec.float_0 == 0f)
					{
						result = true;
					}
					else
					{
						result = (this.vmethod_67()[0].float_0 == 0f);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100769", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x001B214C File Offset: 0x001B034C
		public override void vmethod_137(float float_34)
		{
			try
			{
				if (!this.method_151())
				{
					if (this.vmethod_84() != ActiveUnit.Throttle.FullStop)
					{
						if (!this.vmethod_97())
						{
							float float_35 = this.vmethod_98(this.vmethod_84(), null, null, null, false, false, false, false, false) * float_34;
							FuelRec fuelRec = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Where<FuelRec>(Enumerable.Select<FuelRec, FuelRec>(this.vmethod_67(), (Ship._Closure$__.$I109-0 == null) ? (Ship._Closure$__.$I109-0 = new Func<FuelRec, FuelRec>(Ship._Closure$__.$I.method_2)) : Ship._Closure$__.$I109-0), new Func<FuelRec, bool>(this.method_158)), 0);
							this.vmethod_136(float_35, fuelRec._FuelType_0);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100770", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x001B2244 File Offset: 0x001B0444
		public override void vmethod_136(float float_34, FuelRec._FuelType _FuelType_0)
		{
			Ship.Class360 @class = new Ship.Class360();
			@class._FuelType_0 = _FuelType_0;
			try
			{
				if (float_34 != 0f)
				{
					FuelRec fuelRec = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Where<FuelRec>(Enumerable.Select<FuelRec, FuelRec>(this.vmethod_67(), (Ship._Closure$__.$I110-0 == null) ? (Ship._Closure$__.$I110-0 = new Func<FuelRec, FuelRec>(Ship._Closure$__.$I.method_3)) : Ship._Closure$__.$I110-0), new Func<FuelRec, bool>(@class.method_0)), 0);
					if (fuelRec.float_0 > float_34)
					{
						fuelRec.float_0 -= float_34;
					}
					else
					{
						bool flag = fuelRec.float_0 > 0f;
						fuelRec.float_0 = 0f;
						this.vmethod_134(ActiveUnit.Throttle.FullStop, null);
						if (flag)
						{
							base.method_124(this.Name + " (" + Misc.smethod_9(this.string_2) + ") has run out of fuel and lies dead in the water!", this.Name + "ran out of fuel!", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100771", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x001B23A4 File Offset: 0x001B05A4
		public override float vmethod_98(ActiveUnit.Throttle throttle_5, AltBand altBand_0, float? nullable_17, float? nullable_18, bool bool_27, bool bool_28, bool bool_29, bool bool_30, bool bool_31)
		{
			float result;
			if (this.vmethod_49().Count == 0)
			{
				result = 0f;
			}
			else
			{
				try
				{
					if (this.vmethod_49()[0].vmethod_5() == PlatformComponent._ComponentStatus.Destroyed)
					{
						result = 0f;
					}
					else if (this.vmethod_49()[0].altBand_0.Length == 0)
					{
						result = 0f;
					}
					else
					{
						AltBand altBand;
						if (altBand_0 == null)
						{
							if (nullable_18 != null)
							{
								altBand = ActiveUnit_Kinematics.smethod_1(this, nullable_18.Value, null, false);
							}
							else
							{
								altBand = this.method_146().vmethod_42(this.vmethod_14(false), false);
							}
						}
						else
						{
							altBand = altBand_0;
						}
						if (altBand == null)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							throw new Exception();
						}
						float num;
						float num2;
						switch (throttle_5)
						{
						case ActiveUnit.Throttle.FullStop:
							return 0f;
						case ActiveUnit.Throttle.Loiter:
							num = altBand.float_2;
							num2 = 0f;
							break;
						case ActiveUnit.Throttle.Cruise:
							if (this.vmethod_49()[0].altBand_0[0].float_3 <= 0f)
							{
								return this.vmethod_98(ActiveUnit.Throttle.Loiter, altBand_0, nullable_17, nullable_18, bool_27, bool_28, bool_29, false, false);
							}
							num = altBand.float_3;
							num2 = altBand.float_2;
							break;
						case ActiveUnit.Throttle.Full:
							if (altBand.nullable_0 != null)
							{
								float? num3 = this.vmethod_49()[0].altBand_0[0].nullable_2;
								if (((num3 != null) ? new bool?(num3.GetValueOrDefault() > 0f) : null).GetValueOrDefault())
								{
									num = altBand.nullable_2.Value;
									float num4 = (float)altBand.nullable_0.Value;
									num2 = altBand.float_3;
									break;
								}
							}
							return this.vmethod_98(ActiveUnit.Throttle.Cruise, altBand_0, nullable_17, nullable_18, bool_27, bool_28, bool_29, false, false);
						case ActiveUnit.Throttle.Flank:
							if (altBand.nullable_1 != null)
							{
								float? num3 = this.vmethod_49()[0].altBand_0[0].nullable_3;
								if (((num3 != null) ? new bool?(num3.GetValueOrDefault() > 0f) : null).GetValueOrDefault())
								{
									num = altBand.nullable_3.Value;
									float num5 = (float)altBand.nullable_1.Value;
									if (altBand.nullable_0 != null)
									{
										num2 = altBand.nullable_2.Value;
										break;
									}
									num2 = altBand.float_3;
									break;
								}
							}
							return this.vmethod_98(ActiveUnit.Throttle.Full, altBand_0, nullable_17, nullable_18, bool_27, bool_28, bool_29, false, false);
						default:
							return 0f;
						}
						float num6 = num;
						if (!Information.IsNothing(nullable_17))
						{
							float num7 = (float)this.method_146().vmethod_40(nullable_18.Value, throttle_5, false);
							float? num3 = nullable_17;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() < num7) : null).GetValueOrDefault())
							{
								float num8 = (float)this.method_146().vmethod_40(nullable_18.Value, (ActiveUnit.Throttle)(throttle_5 - ActiveUnit.Throttle.Loiter), false);
								num3 = nullable_17;
								float num9;
								if (((num3 != null) ? new bool?(num3.GetValueOrDefault() >= num8) : null).GetValueOrDefault())
								{
									num9 = ((nullable_17 - num8) / (num7 - num8)).Value;
									num9 = Math.Abs(num9);
								}
								else
								{
									num9 = 0f;
								}
								num6 = num2 + (num - num2) * num9;
							}
						}
						result = num6 / 60f;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101253", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = 0f;
				}
			}
			return result;
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x0000C691 File Offset: 0x0000A891
		public float imethod_4()
		{
			return this.float_31;
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x0000C699 File Offset: 0x0000A899
		public void imethod_5(float float_34)
		{
			this.float_31 = float_34;
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x0000C6A2 File Offset: 0x0000A8A2
		public float imethod_6()
		{
			return this.float_32;
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x0000C6AA File Offset: 0x0000A8AA
		public void imethod_7(float float_34)
		{
			this.float_32 = float_34;
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x0000C6B3 File Offset: 0x0000A8B3
		public float imethod_8()
		{
			return this.float_33;
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x0000C6BB File Offset: 0x0000A8BB
		public void imethod_9(float float_34)
		{
			this.float_33 = float_34;
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x001B27D0 File Offset: 0x001B09D0
		public bool imethod_10()
		{
			Ship._ShipType shipType_ = this._ShipType_0;
			if (shipType_ != Ship._ShipType.LKA)
			{
				switch (shipType_)
				{
				case Ship._ShipType.AD:
				case Ship._ShipType.AE:
				case Ship._ShipType.AF:
				case Ship._ShipType.AFS:
				case Ship._ShipType.AG:
				case Ship._ShipType.AK:
				case Ship._ShipType.AKA:
				case Ship._ShipType.AKE:
				case Ship._ShipType.AKR:
				case Ship._ShipType.AKS:
				case Ship._ShipType.AO:
				case Ship._ShipType.AOE:
				case Ship._ShipType.AOL:
				case Ship._ShipType.AOT:
				case Ship._ShipType.APA:
				case Ship._ShipType.AS_:
				case Ship._ShipType.AV:
					goto IL_B0;
				case Ship._ShipType.AGB:
				case Ship._ShipType.AGF:
				case Ship._ShipType.AGI:
				case Ship._ShipType.AGMR:
				case Ship._ShipType.AGOR:
				case Ship._ShipType.AGOS:
				case Ship._ShipType.AGR:
				case Ship._ShipType.AGS:
				case Ship._ShipType.AGTR:
				case Ship._ShipType.AH:
				case (Ship._ShipType)5025:
				case Ship._ShipType.APD:
				case Ship._ShipType.AR:
				case Ship._ShipType.ATC:
				case Ship._ShipType.ATA:
				case Ship._ShipType.ATS:
					break;
				default:
					if (shipType_ - Ship._ShipType.TAK <= 5)
					{
						goto IL_B0;
					}
					break;
				}
				return false;
			}
			IL_B0:
			return true;
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x001B2890 File Offset: 0x001B0A90
		public void method_155(float float_34)
		{
			base.method_124(this.Name + " is sinking!!!", this.Name + " sinking!!!", LoggedMessage.MessageType.UnitLost, 1, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
			this.bool_24 = true;
			base.method_107(false, true, float_34, true);
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x001B28FC File Offset: 0x001B0AFC
		public override void vmethod_133(bool bool_27, bool bool_28, bool bool_29)
		{
			bool bool_30 = false;
			checked
			{
				try
				{
					this.bool_24 = true;
					this.vmethod_93().method_16(null);
					if (!this.vmethod_127() && !bool_27)
					{
						this.scenario_0.method_59(this.Name + " has been destroyed!", this.Name + " destroyed!", LoggedMessage.MessageType.UnitLost, 0, this.string_0, this.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					}
					base.method_107(bool_27, bool_30, this.method_150().method_0(), bool_29);
					if (!this.method_152() && !bool_27)
					{
						this.scenario_0.method_59(this.Name + " has been destroyed!", this.Name + " destroyed!", LoggedMessage.MessageType.UnitLost, 0, this.string_0, this.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					}
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
					if (this.vmethod_100().Length > 0)
					{
						try
						{
							foreach (ActiveUnit activeUnit2 in this.vmethod_93().method_14())
							{
								activeUnit2.vmethod_133(bool_27, bool_28, bool_29);
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
					if (this.vmethod_99().Length > 0)
					{
						try
						{
							foreach (Aircraft aircraft in this.vmethod_92().vmethod_4())
							{
								aircraft.vmethod_133(bool_27, bool_28, bool_29);
							}
						}
						finally
						{
							List<Aircraft>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
					}
					if (base.method_120())
					{
						this.vmethod_65(false).vmethod_141().Remove(this.string_0);
					}
					if (bool_27)
					{
						base.method_109();
					}
					else if (bool_29)
					{
						this.scenario_0.method_65(this);
					}
					else
					{
						base.method_109();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100772", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x001B2C68 File Offset: 0x001B0E68
		public Ship(ref Scenario theScen, string theGUID = null) : base(ref theScen, theGUID)
		{
			this.struct34_0 = default(Ship.Struct34);
			this.class347_0 = new Class347(this);
			this.class345_0 = new Class345(this, "Bridge / CIC");
			this.bool_6 = true;
			this.bool_4 = true;
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x0000C6C4 File Offset: 0x0000A8C4
		public float imethod_0()
		{
			return this.float_28;
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x0000C6CC File Offset: 0x0000A8CC
		public float imethod_1()
		{
			return this.float_29;
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		public CargoType imethod_2()
		{
			return this.cargoType_0;
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x0000C6DC File Offset: 0x0000A8DC
		public float imethod_3()
		{
			return this.float_30;
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x0000C6E4 File Offset: 0x0000A8E4
		[CompilerGenerated]
		private bool method_156(FuelRec fuelRec_1)
		{
			return this.vmethod_49()[0].method_25(fuelRec_1._FuelType_0);
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0000C6E4 File Offset: 0x0000A8E4
		[CompilerGenerated]
		private bool method_157(FuelRec fuelRec_1)
		{
			return this.vmethod_49()[0].method_25(fuelRec_1._FuelType_0);
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x0000C6E4 File Offset: 0x0000A8E4
		[CompilerGenerated]
		private bool method_158(FuelRec fuelRec_1)
		{
			return this.vmethod_49()[0].method_25(fuelRec_1._FuelType_0);
		}

		// Token: 0x040014C9 RID: 5321
		public Ship.Enum118 enum118_0;

		// Token: 0x040014CA RID: 5322
		public Ship._ShipType _ShipType_0;

		// Token: 0x040014CB RID: 5323
		public GlobalVariables.ArmorRating armorRating_0;

		// Token: 0x040014CC RID: 5324
		public GlobalVariables.ArmorRating armorRating_1;

		// Token: 0x040014CD RID: 5325
		public GlobalVariables.ArmorRating armorRating_2;

		// Token: 0x040014CE RID: 5326
		public GlobalVariables.ArmorRating armorRating_3;

		// Token: 0x040014CF RID: 5327
		public GlobalVariables.ArmorRating armorRating_4;

		// Token: 0x040014D0 RID: 5328
		public GlobalVariables.ArmorRating armorRating_5;

		// Token: 0x040014D1 RID: 5329
		public GlobalVariables.ArmorRating armorRating_6;

		// Token: 0x040014D2 RID: 5330
		public DockFacility.Enum50 enum50_0;

		// Token: 0x040014D3 RID: 5331
		public byte byte_0;

		// Token: 0x040014D4 RID: 5332
		public short short_3;

		// Token: 0x040014D5 RID: 5333
		public short short_4;

		// Token: 0x040014D6 RID: 5334
		public int int_7;

		// Token: 0x040014D7 RID: 5335
		public short short_5;

		// Token: 0x040014D8 RID: 5336
		public float float_25;

		// Token: 0x040014D9 RID: 5337
		public float float_26;

		// Token: 0x040014DA RID: 5338
		public float float_27;

		// Token: 0x040014DB RID: 5339
		public float float_28;

		// Token: 0x040014DC RID: 5340
		public float float_29;

		// Token: 0x040014DD RID: 5341
		public CargoType cargoType_0;

		// Token: 0x040014DE RID: 5342
		public float float_30;

		// Token: 0x040014DF RID: 5343
		public Ship.Struct34 struct34_0;

		// Token: 0x040014E0 RID: 5344
		public Class347 class347_0;

		// Token: 0x040014E1 RID: 5345
		public Class345 class345_0;

		// Token: 0x040014E2 RID: 5346
		private Class214 class214_0;

		// Token: 0x040014E3 RID: 5347
		private Ship_AI ship_AI_0;

		// Token: 0x040014E4 RID: 5348
		private Class202 class202_0;

		// Token: 0x040014E5 RID: 5349
		private Class221 class221_0;

		// Token: 0x040014E6 RID: 5350
		private Class228 class228_0;

		// Token: 0x040014E7 RID: 5351
		private Class183 class183_0;

		// Token: 0x040014E8 RID: 5352
		private Class186 class186_0;

		// Token: 0x040014E9 RID: 5353
		private bool? nullable_16;

		// Token: 0x040014EA RID: 5354
		private float float_31;

		// Token: 0x040014EB RID: 5355
		private float float_32;

		// Token: 0x040014EC RID: 5356
		private float float_33;

		// Token: 0x02000321 RID: 801
		internal struct Struct34
		{
			// Token: 0x040014ED RID: 5357
			public bool bool_0;

			// Token: 0x040014EE RID: 5358
			public bool bool_1;

			// Token: 0x040014EF RID: 5359
			public bool bool_2;

			// Token: 0x040014F0 RID: 5360
			public bool bool_3;

			// Token: 0x040014F1 RID: 5361
			public bool bool_4;

			// Token: 0x040014F2 RID: 5362
			public bool bool_5;

			// Token: 0x040014F3 RID: 5363
			public bool bool_6;

			// Token: 0x040014F4 RID: 5364
			public bool bool_7;

			// Token: 0x040014F5 RID: 5365
			public bool bool_8;

			// Token: 0x040014F6 RID: 5366
			public bool bool_9;

			// Token: 0x040014F7 RID: 5367
			public bool bool_10;

			// Token: 0x040014F8 RID: 5368
			public bool bool_11;

			// Token: 0x040014F9 RID: 5369
			public bool bool_12;

			// Token: 0x040014FA RID: 5370
			public bool bool_13;

			// Token: 0x040014FB RID: 5371
			public bool bool_14;

			// Token: 0x040014FC RID: 5372
			public bool bool_15;

			// Token: 0x040014FD RID: 5373
			public bool bool_16;

			// Token: 0x040014FE RID: 5374
			public bool bool_17;

			// Token: 0x040014FF RID: 5375
			public bool bool_18;

			// Token: 0x04001500 RID: 5376
			public bool bool_19;

			// Token: 0x04001501 RID: 5377
			public bool bool_20;

			// Token: 0x04001502 RID: 5378
			public bool bool_21;
		}

		// Token: 0x02000322 RID: 802
		internal enum Enum118
		{
			// Token: 0x04001504 RID: 5380
			const_0 = 1001,
			// Token: 0x04001505 RID: 5381
			const_1 = 2002,
			// Token: 0x04001506 RID: 5382
			const_2 = 2001,
			// Token: 0x04001507 RID: 5383
			const_3 = 2003,
			// Token: 0x04001508 RID: 5384
			const_4,
			// Token: 0x04001509 RID: 5385
			const_5,
			// Token: 0x0400150A RID: 5386
			const_6,
			// Token: 0x0400150B RID: 5387
			const_7,
			// Token: 0x0400150C RID: 5388
			const_8
		}

		// Token: 0x02000323 RID: 803
		public enum _ShipType
		{
			// Token: 0x0400150E RID: 5390
			None = 1001,
			// Token: 0x0400150F RID: 5391
			CV = 2001,
			// Token: 0x04001510 RID: 5392
			CVA,
			// Token: 0x04001511 RID: 5393
			CVB,
			// Token: 0x04001512 RID: 5394
			CVE,
			// Token: 0x04001513 RID: 5395
			CVGH,
			// Token: 0x04001514 RID: 5396
			CVH,
			// Token: 0x04001515 RID: 5397
			CVL,
			// Token: 0x04001516 RID: 5398
			CVN,
			// Token: 0x04001517 RID: 5399
			SeaplaneCarrier,
			// Token: 0x04001518 RID: 5400
			CVS,
			// Token: 0x04001519 RID: 5401
			B = 3001,
			// Token: 0x0400151A RID: 5402
			BB,
			// Token: 0x0400151B RID: 5403
			BBC,
			// Token: 0x0400151C RID: 5404
			BBG,
			// Token: 0x0400151D RID: 5405
			BBH,
			// Token: 0x0400151E RID: 5406
			BCGN,
			// Token: 0x0400151F RID: 5407
			BM,
			// Token: 0x04001520 RID: 5408
			C = 3101,
			// Token: 0x04001521 RID: 5409
			CA,
			// Token: 0x04001522 RID: 5410
			CAG,
			// Token: 0x04001523 RID: 5411
			CB,
			// Token: 0x04001524 RID: 5412
			CBG,
			// Token: 0x04001525 RID: 5413
			CG,
			// Token: 0x04001526 RID: 5414
			CGH,
			// Token: 0x04001527 RID: 5415
			CGN,
			// Token: 0x04001528 RID: 5416
			CL,
			// Token: 0x04001529 RID: 5417
			CLAA,
			// Token: 0x0400152A RID: 5418
			CLC,
			// Token: 0x0400152B RID: 5419
			CLG,
			// Token: 0x0400152C RID: 5420
			CLH,
			// Token: 0x0400152D RID: 5421
			CS,
			// Token: 0x0400152E RID: 5422
			D = 3201,
			// Token: 0x0400152F RID: 5423
			DD,
			// Token: 0x04001530 RID: 5424
			DDG,
			// Token: 0x04001531 RID: 5425
			DDH,
			// Token: 0x04001532 RID: 5426
			DDK,
			// Token: 0x04001533 RID: 5427
			DDR,
			// Token: 0x04001534 RID: 5428
			DE,
			// Token: 0x04001535 RID: 5429
			DEG,
			// Token: 0x04001536 RID: 5430
			DER,
			// Token: 0x04001537 RID: 5431
			DL,
			// Token: 0x04001538 RID: 5432
			DLG,
			// Token: 0x04001539 RID: 5433
			DM,
			// Token: 0x0400153A RID: 5434
			F = 3301,
			// Token: 0x0400153B RID: 5435
			FF,
			// Token: 0x0400153C RID: 5436
			FFG,
			// Token: 0x0400153D RID: 5437
			FFL,
			// Token: 0x0400153E RID: 5438
			PF,
			// Token: 0x0400153F RID: 5439
			LCS,
			// Token: 0x04001540 RID: 5440
			OPV,
			// Token: 0x04001541 RID: 5441
			PB = 3401,
			// Token: 0x04001542 RID: 5442
			PC1,
			// Token: 0x04001543 RID: 5443
			PC2,
			// Token: 0x04001544 RID: 5444
			PCE,
			// Token: 0x04001545 RID: 5445
			PCF,
			// Token: 0x04001546 RID: 5446
			PCFG,
			// Token: 0x04001547 RID: 5447
			PG1,
			// Token: 0x04001548 RID: 5448
			PG2,
			// Token: 0x04001549 RID: 5449
			PGM,
			// Token: 0x0400154A RID: 5450
			PH,
			// Token: 0x0400154B RID: 5451
			PHM,
			// Token: 0x0400154C RID: 5452
			PHT,
			// Token: 0x0400154D RID: 5453
			PT,
			// Token: 0x0400154E RID: 5454
			PTS,
			// Token: 0x0400154F RID: 5455
			MTB,
			// Token: 0x04001550 RID: 5456
			WHEC,
			// Token: 0x04001551 RID: 5457
			WMEC,
			// Token: 0x04001552 RID: 5458
			WPB,
			// Token: 0x04001553 RID: 5459
			WPG,
			// Token: 0x04001554 RID: 5460
			MCDV,
			// Token: 0x04001555 RID: 5461
			AGC = 4001,
			// Token: 0x04001556 RID: 5462
			LCAC,
			// Token: 0x04001557 RID: 5463
			LCC,
			// Token: 0x04001558 RID: 5464
			LCM,
			// Token: 0x04001559 RID: 5465
			LCP,
			// Token: 0x0400155A RID: 5466
			LCT,
			// Token: 0x0400155B RID: 5467
			LCU,
			// Token: 0x0400155C RID: 5468
			LCVP,
			// Token: 0x0400155D RID: 5469
			LFR,
			// Token: 0x0400155E RID: 5470
			LHA,
			// Token: 0x0400155F RID: 5471
			LHD,
			// Token: 0x04001560 RID: 5472
			LKA,
			// Token: 0x04001561 RID: 5473
			LPD,
			// Token: 0x04001562 RID: 5474
			LPH,
			// Token: 0x04001563 RID: 5475
			LSD,
			// Token: 0x04001564 RID: 5476
			LSH,
			// Token: 0x04001565 RID: 5477
			LSL,
			// Token: 0x04001566 RID: 5478
			LSM,
			// Token: 0x04001567 RID: 5479
			LSMR,
			// Token: 0x04001568 RID: 5480
			LST,
			// Token: 0x04001569 RID: 5481
			LSU,
			// Token: 0x0400156A RID: 5482
			LSV,
			// Token: 0x0400156B RID: 5483
			A = 5001,
			// Token: 0x0400156C RID: 5484
			AD,
			// Token: 0x0400156D RID: 5485
			AE,
			// Token: 0x0400156E RID: 5486
			AF,
			// Token: 0x0400156F RID: 5487
			AFS,
			// Token: 0x04001570 RID: 5488
			AG,
			// Token: 0x04001571 RID: 5489
			AGB,
			// Token: 0x04001572 RID: 5490
			AGF,
			// Token: 0x04001573 RID: 5491
			AGI,
			// Token: 0x04001574 RID: 5492
			AGMR,
			// Token: 0x04001575 RID: 5493
			AGOR,
			// Token: 0x04001576 RID: 5494
			AGOS,
			// Token: 0x04001577 RID: 5495
			AGR,
			// Token: 0x04001578 RID: 5496
			AGS,
			// Token: 0x04001579 RID: 5497
			AGTR,
			// Token: 0x0400157A RID: 5498
			AH,
			// Token: 0x0400157B RID: 5499
			AK,
			// Token: 0x0400157C RID: 5500
			AKA,
			// Token: 0x0400157D RID: 5501
			AKE,
			// Token: 0x0400157E RID: 5502
			AKR,
			// Token: 0x0400157F RID: 5503
			AKS,
			// Token: 0x04001580 RID: 5504
			AO,
			// Token: 0x04001581 RID: 5505
			AOE,
			// Token: 0x04001582 RID: 5506
			AOL,
			// Token: 0x04001583 RID: 5507
			AOR = 5024,
			// Token: 0x04001584 RID: 5508
			AOT = 5026,
			// Token: 0x04001585 RID: 5509
			APA,
			// Token: 0x04001586 RID: 5510
			APD,
			// Token: 0x04001587 RID: 5511
			AR,
			// Token: 0x04001588 RID: 5512
			AS_,
			// Token: 0x04001589 RID: 5513
			ATC,
			// Token: 0x0400158A RID: 5514
			ATA,
			// Token: 0x0400158B RID: 5515
			ATS,
			// Token: 0x0400158C RID: 5516
			AV,
			// Token: 0x0400158D RID: 5517
			AX,
			// Token: 0x0400158E RID: 5518
			TAGOS = 5101,
			// Token: 0x0400158F RID: 5519
			TAH,
			// Token: 0x04001590 RID: 5520
			TAK,
			// Token: 0x04001591 RID: 5521
			TAKE,
			// Token: 0x04001592 RID: 5522
			TAKR,
			// Token: 0x04001593 RID: 5523
			TAO1,
			// Token: 0x04001594 RID: 5524
			TAO2,
			// Token: 0x04001595 RID: 5525
			TMLP,
			// Token: 0x04001596 RID: 5526
			MCD = 6001,
			// Token: 0x04001597 RID: 5527
			MCM,
			// Token: 0x04001598 RID: 5528
			MCS,
			// Token: 0x04001599 RID: 5529
			MHC,
			// Token: 0x0400159A RID: 5530
			ML,
			// Token: 0x0400159B RID: 5531
			MSC,
			// Token: 0x0400159C RID: 5532
			MSF,
			// Token: 0x0400159D RID: 5533
			MSI,
			// Token: 0x0400159E RID: 5534
			MSO = 6010,
			// Token: 0x0400159F RID: 5535
			MST,
			// Token: 0x040015A0 RID: 5536
			YAG = 7001,
			// Token: 0x040015A1 RID: 5537
			Civilian = 9001,
			// Token: 0x040015A2 RID: 5538
			Merchant,
			// Token: 0x040015A3 RID: 5539
			Platform,
			// Token: 0x040015A4 RID: 5540
			NGSBuoy,
			// Token: 0x040015A5 RID: 5541
			BottomFixedArraySonar,
			// Token: 0x040015A6 RID: 5542
			MooredSonobuoy,
			// Token: 0x040015A7 RID: 5543
			Special
		}

		// Token: 0x02000324 RID: 804
		internal enum Enum119 : byte
		{
			// Token: 0x040015A9 RID: 5545
			const_0,
			// Token: 0x040015AA RID: 5546
			const_1,
			// Token: 0x040015AB RID: 5547
			const_2,
			// Token: 0x040015AC RID: 5548
			const_3,
			// Token: 0x040015AD RID: 5549
			const_4,
			// Token: 0x040015AE RID: 5550
			const_5
		}

		// Token: 0x02000325 RID: 805
		[CompilerGenerated]
		internal sealed class Class358
		{
			// Token: 0x040015AF RID: 5551
			public bool bool_0;

			// Token: 0x040015B0 RID: 5552
			public bool bool_1;

			// Token: 0x040015B1 RID: 5553
			public bool bool_2;

			// Token: 0x040015B2 RID: 5554
			public double double_0;

			// Token: 0x040015B3 RID: 5555
			public double double_1;

			// Token: 0x040015B4 RID: 5556
			public Ship ship_0;
		}

		// Token: 0x02000326 RID: 806
		[CompilerGenerated]
		internal sealed class Class359
		{
			// Token: 0x060017E6 RID: 6118 RVA: 0x001B2CB4 File Offset: 0x001B0EB4
			internal void method_0(string string_0, ParallelLoopState parallelLoopState_0)
			{
				UnguidedWeapon unguidedWeapon = null;
				this.class358_0.ship_0.scenario_0.vmethod_20().TryGetValue(string_0, ref unguidedWeapon);
				if (unguidedWeapon != null && unguidedWeapon.method_65())
				{
					short num = (short)this.class358_0.ship_0.vmethod_132(unguidedWeapon.method_63(), this.class358_0.bool_0);
					if ((this.class358_0.bool_1 || (!this.class358_0.bool_2 && Math.Abs(unguidedWeapon.method_46(this.class358_0.ship_0, true)) <= 45f)) && Math2.smethod_15(this.class358_0.double_0, this.class358_0.double_1, unguidedWeapon.vmethod_30(null), unguidedWeapon.vmethod_28(null)) * 1852f < (float)num)
					{
						this.bool_0 = true;
						parallelLoopState_0.Stop();
					}
				}
			}

			// Token: 0x040015B5 RID: 5557
			public bool bool_0;

			// Token: 0x040015B6 RID: 5558
			public Ship.Class358 class358_0;
		}

		// Token: 0x02000328 RID: 808
		[CompilerGenerated]
		internal sealed class Class360
		{
			// Token: 0x060017EE RID: 6126 RVA: 0x0000C709 File Offset: 0x0000A909
			internal bool method_0(FuelRec fuelRec_0)
			{
				return fuelRec_0._FuelType_0 == this._FuelType_0;
			}

			// Token: 0x040015BC RID: 5564
			public FuelRec._FuelType _FuelType_0;
		}
	}
}
