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
	// Token: 0x02000346 RID: 838
	public sealed class Submarine : Class350, Interface3, Interface5
	{
		// Token: 0x060018D2 RID: 6354 RVA: 0x001C192C File Offset: 0x001BFB2C
		private Submarine()
		{
			Scenario scenario = null;
			base..ctor(ref scenario, null);
			this.struct35_0 = default(Submarine.Struct35);
			this.class346_0 = new Class346(this);
			this.class347_0 = new Class347(this);
			this.class345_0 = new Class345(this, "Conn / CIC");
			this.cargo_1 = new Cargo(this);
			this.bool_5 = true;
			this.bool_4 = true;
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x000041ED File Offset: 0x000023ED
		public override bool vmethod_6()
		{
			return true;
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0000CB39 File Offset: 0x0000AD39
		public bool method_142()
		{
			return this._SubmarineType_0 == Submarine._SubmarineType.Biologics;
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0000CB48 File Offset: 0x0000AD48
		public bool method_143()
		{
			return this._SubmarineType_0 == Submarine._SubmarineType.FalseTarget;
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x001C1994 File Offset: 0x001BFB94
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				if (this.vmethod_7(false) != null)
				{
					xmlWriter_0.WriteStartElement("Submarine");
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
						xmlWriter_0.WriteElementString("DT", ((byte)this.vmethod_78()).ToString());
						xmlWriter_0.WriteElementString("DTN", ((byte)this.vmethod_80()).ToString());
						xmlWriter_0.WriteElementString("DA", XmlConvert.ToString(this.vmethod_72()));
						if (this.nullable_15 != null)
						{
							xmlWriter_0.WriteElementString("Prof", ((int)this.nullable_15.Value).ToString());
						}
						xmlWriter_0.WriteElementString("ThrottleSetting", ((byte)this.vmethod_84()).ToString());
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
						xmlWriter_0.WriteElementString("DamagePts", XmlConvert.ToString(this.vmethod_63(false, null)));
						if (this.vmethod_99().Length > 0)
						{
							xmlWriter_0.WriteStartElement("AirFacilities");
							foreach (AirFacility airFacility in this.vmethod_99())
							{
								xmlWriter_0.WriteRaw(airFacility.method_23(hashSet_0));
							}
							xmlWriter_0.WriteEndElement();
						}
						if (this.vmethod_100().Length > 0)
						{
							xmlWriter_0.WriteStartElement("DockFacilities");
							foreach (DockFacility dockFacility in this.vmethod_100())
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
						xmlWriter_0.WriteStartElement("PressureHull");
						this.class346_0.method_23(ref xmlWriter_0, ref hashSet_0, this.scenario_0);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Rudder");
						this.class347_0.method_23(ref xmlWriter_0, ref hashSet_0, this.scenario_0);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("CIC");
						this.class345_0.method_23(ref xmlWriter_0, ref hashSet_0, this.scenario_0);
						xmlWriter_0.WriteEndElement();
						this.method_152().vmethod_0(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteStartElement("Submarine_AI");
						this.method_153().vmethod_2(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Submarine_Kinematics");
						this.method_154().vmethod_0(ref xmlWriter_0);
						xmlWriter_0.WriteEndElement();
						this.method_155().vmethod_2(ref xmlWriter_0);
						this.method_156().vmethod_2(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteStartElement("Submarine_CommStuff");
						this.method_157().vmethod_0(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						this.method_158().vmethod_0(ref xmlWriter_0);
						this.vmethod_92().vmethod_0(ref xmlWriter_0, ref hashSet_0);
						ActiveUnit_DockingOps.smethod_6(this.vmethod_93(), ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100799", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x001C2590 File Offset: 0x001C0790
		public static Submarine smethod_10(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_1, ref Scenario scenario_1)
		{
			Submarine submarine;
			try
			{
				submarine = Submarine.smethod_11(ref xmlNode_0, ref dictionary_1, ref scenario_1, scenario_1.LoadStockUnits);
			}
			catch (Exception1 exception)
			{
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				dictionary_1.Remove(innerText);
				submarine = Submarine.smethod_11(ref xmlNode_0, ref dictionary_1, ref scenario_1, true);
				string text = "";
				if (submarine.method_120())
				{
					text = "(member of group: [" + submarine.vmethod_65(false).Name + "])";
				}
				scenario_1.LoadingNotices.Add(string.Concat(new string[]
				{
					"The following submarine:[",
					submarine.Name,
					"]",
					text,
					" failed to shallow-rebuild because of a component missing. The submarine was instead deep-rebuilt, and instantiated in its pristine DB-stock condition. All customizations present in the submarine's components (damaged components, weapon additions/removals etc. etc.) have been lost. Please re-apply any necessary customizations either manually or using an SBR script."
				}));
			}
			if (Information.IsNothing(submarine))
			{
				string innerText2 = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				dictionary_1.Remove(innerText2);
			}
			return submarine;
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x001C268C File Offset: 0x001C088C
		private static Submarine smethod_11(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_1, ref Scenario scenario_1, bool bool_27)
		{
			Submarine result;
			try
			{
				Submarine submarine = new Submarine();
				submarine.scenario_0 = scenario_1;
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_1.ContainsKey(innerText))
				{
					result = (Submarine)dictionary_1[innerText];
				}
				else
				{
					submarine.vmethod_0(innerText);
					if (xmlNode_0.ChildNodes.Count == 1)
					{
						scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
						result = submarine;
					}
					else
					{
						dictionary_1.Add(submarine.string_0, submarine);
						int num = Conversions.ToInteger(Misc.smethod_44(xmlNode_0.ChildNodes, "DBID").InnerText);
						try
						{
							DBFunctions.smethod_55(ref scenario_1, ref submarine, num, bool_27);
						}
						catch (Exception ex)
						{
							dictionary_1.Remove(submarine.string_0);
							scenario_1.LoadingNotices.Add("Submarine with Database ID " + Conversions.ToString(num) + " is missing from the database and has not been loaded.");
							return result;
						}
						if (bool_27)
						{
							submarine.method_99(ref xmlNode_0, ref dictionary_1, ref scenario_1);
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
										if (num2 <= 2008421230U)
										{
											if (num2 != 1305748348U)
											{
												if (num2 != 1717708934U)
												{
													if (num2 != 2008421230U)
													{
														continue;
													}
													if (Operators.CompareString(name, "Comms", false) != 0)
													{
														continue;
													}
													try
													{
														foreach (object obj2 in xmlNode.ChildNodes)
														{
															XmlNode xmlNode2 = (XmlNode)obj2;
															CommDevice commDevice = CommDevice.smethod_2(ref xmlNode2, ref dictionary_1, submarine);
															submarine.method_101(commDevice);
															commDevice.method_19(submarine);
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
												if (Operators.CompareString(name, "CIC", false) == 0)
												{
													submarine.class345_0 = Class345.smethod_2(ref xmlNode, ref dictionary_1);
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
													foreach (object obj3 in xmlNode.ChildNodes)
													{
														XmlNode xmlNode3 = (XmlNode)obj3;
														Cargo cargo = Cargo.smethod_2(ref xmlNode3, ref dictionary_1, submarine);
														Class429.smethod_6(ref submarine.cargo_0, cargo);
														cargo.method_19(submarine);
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
										}
										if (num2 != 2096367071U)
										{
											if (num2 != 2171969073U)
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
													foreach (object obj4 in xmlNode.ChildNodes)
													{
														XmlNode xmlNode4 = (XmlNode)obj4;
														FuelRec fuelRec_ = FuelRec.smethod_0(ref xmlNode4, ref dictionary_1);
														Class429.smethod_19(ref submarine.fuelRec_0, fuelRec_);
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
											if (Operators.CompareString(name, "PressureHull", false) == 0)
											{
												submarine.class346_0 = Class346.smethod_2(ref xmlNode, ref dictionary_1);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "DockFacilities", false) != 0)
											{
												continue;
											}
											try
											{
												foreach (object obj5 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode5 = (XmlNode)obj5;
													DockFacility dockFacility = DockFacility.smethod_2(ref xmlNode5, ref dictionary_1, ref scenario_1);
													submarine.method_104(dockFacility);
													dockFacility.method_19(submarine);
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
													submarine.class347_0 = Class347.smethod_2(ref xmlNode, ref dictionary_1);
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
														Sensor sensor = Sensor.smethod_2((XmlNode)obj6, dictionary_1, submarine);
														Class429.smethod_24(ref submarine.sensor_0, sensor);
														sensor.method_19(submarine);
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
												ActiveUnit activeUnit = submarine;
												Engine engine = Engine.smethod_2(ref xmlNode6, ref dictionary_1, ref activeUnit);
												submarine.vmethod_49().method_4(engine);
												engine.method_19(submarine);
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
													AirFacility airFacility = AirFacility.smethod_3(ref xmlNode7, ref dictionary_1, ref scenario_1);
													submarine.method_103(airFacility);
													airFacility.method_19(submarine);
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
												Magazine magazine = Magazine.smethod_6(ref xmlNode8, ref dictionary_1, ref scenario_1);
												submarine.method_140(magazine);
												magazine.method_19(submarine);
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
												Mount mount = Mount.smethod_6(ref xmlNode9, ref dictionary_1, submarine);
												submarine.vmethod_51().method_4(mount);
												mount.method_19(submarine);
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
						bool flag = false;
						try
						{
							foreach (object obj11 in xmlNode_0.ChildNodes)
							{
								XmlNode xmlNode10 = (XmlNode)obj11;
								string name2 = xmlNode10.Name;
								uint num2 = Class582.smethod_0(name2);
								if (num2 > 1708783731U)
								{
									if (num2 <= 2874698282U)
									{
										if (num2 <= 2066337159U)
										{
											if (num2 <= 1907898041U)
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
															submarine.bool_20 = Conversions.ToBoolean(xmlNode10.InnerText);
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
													if (num2 != 1907898041U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "Submarine_Weaponry", false) == 0)
													{
														Submarine submarine2 = submarine;
														ActiveUnit activeUnit = submarine;
														submarine2.submarine_Weaponry_0 = Submarine_Weaponry.smethod_6(ref xmlNode10, ref dictionary_1, ref activeUnit);
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Latitude", false) != 0)
													{
														continue;
													}
													goto IL_15DF;
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
														submarine.vmethod_39(new double?(XmlConvert.ToDouble(xmlNode10.InnerText)));
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "AMP_OC_DSO", false) == 0)
													{
														submarine.nullable_13 = new float?(XmlConvert.ToSingle(xmlNode10.InnerText));
														continue;
													}
													continue;
												}
											}
											else if (num2 != 2010780873U)
											{
												if (num2 != 2030505933U)
												{
													if (num2 != 2066337159U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "DesiredAltitude", false) == 0)
													{
														goto IL_1240;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Submarine_Sensory", false) == 0)
													{
														Submarine submarine3 = submarine;
														ActiveUnit activeUnit = submarine;
														submarine3.class222_0 = Class222.smethod_10(ref xmlNode10, ref dictionary_1, ref activeUnit);
														continue;
													}
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "CA", false) == 0)
												{
													goto IL_1293;
												}
												continue;
											}
										}
										else
										{
											if (num2 <= 2590053246U)
											{
												if (num2 <= 2247649009U)
												{
													if (num2 != 2128224206U)
													{
														if (num2 != 2247649009U)
														{
															continue;
														}
														if (Operators.CompareString(name2, "AssignedMission", false) == 0 && xmlNode10.HasChildNodes)
														{
															XmlNode xmlNode11 = xmlNode10.ChildNodes[0];
															submarine.string_4 = xmlNode11.InnerText;
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
														goto IL_1A2C;
													}
												}
												else if (num2 != 2496321123U)
												{
													if (num2 != 2564648390U)
													{
														if (num2 != 2590053246U)
														{
															continue;
														}
														if (Operators.CompareString(name2, "Side", false) == 0)
														{
															submarine.string_7 = xmlNode10.InnerText;
															continue;
														}
														continue;
													}
													else
													{
														if (Operators.CompareString(name2, "Lon", false) == 0)
														{
															goto IL_1383;
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
														foreach (object obj12 in xmlNode10.ChildNodes)
														{
															RangeSymbol item = RangeSymbol.smethod_0((XmlNode)obj12, dictionary_1);
															submarine.method_17().Add(item);
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
												if (num2 != 2617265898U)
												{
													if (num2 != 2749693904U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "DesiredSpeed", false) == 0)
													{
														goto IL_143F;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Submarine_CommStuff", false) == 0)
													{
														Submarine submarine4 = submarine;
														ActiveUnit activeUnit = submarine;
														submarine4.class184_0 = Class184.smethod_1(ref xmlNode10, ref dictionary_1, ref activeUnit);
														continue;
													}
													continue;
												}
											}
											else if (num2 != 2834497881U)
											{
												if (num2 != 2844845263U)
												{
													if (num2 != 2874698282U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "AssignedTaskPool", false) == 0 && xmlNode10.HasChildNodes)
													{
														XmlNode xmlNode12 = xmlNode10.ChildNodes[0];
														submarine.string_5 = xmlNode12.InnerText;
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "SBEO_Altitude", false) == 0)
													{
														submarine.float_20 = XmlConvert.ToSingle(xmlNode10.InnerText);
														continue;
													}
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "SBPF_Altitude", false) == 0)
												{
													submarine.float_22 = XmlConvert.ToSingle(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
										}
										IL_1383:
										submarine.vmethod_29(null, XmlConvert.ToDouble(xmlNode10.InnerText));
										continue;
									}
									if (num2 <= 3204468496U)
									{
										if (num2 <= 3001749054U)
										{
											if (num2 <= 2920208772U)
											{
												if (num2 != 2904824734U)
												{
													if (num2 != 2920208772U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "Message", false) == 0)
													{
														submarine.string_3 = xmlNode10.InnerText;
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "SBEO_Altitude_TF", false) == 0)
													{
														submarine.float_21 = XmlConvert.ToSingle(xmlNode10.InnerText);
														continue;
													}
													continue;
												}
											}
											else if (num2 != 2923116889U)
											{
												if (num2 != 3001749054U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Lat", false) != 0)
												{
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "SBR_ThrottleSetting", false) != 0)
												{
													continue;
												}
												string innerText2 = xmlNode10.InnerText;
												if (Operators.CompareString(innerText2, "FullStop", false) == 0)
												{
													submarine.throttle_1 = ActiveUnit.Throttle.FullStop;
													continue;
												}
												if (Operators.CompareString(innerText2, "Loiter", false) == 0)
												{
													submarine.throttle_1 = ActiveUnit.Throttle.Loiter;
													continue;
												}
												if (Operators.CompareString(innerText2, "Cruise", false) == 0)
												{
													submarine.throttle_1 = ActiveUnit.Throttle.Cruise;
													continue;
												}
												if (Operators.CompareString(innerText2, "Full", false) == 0)
												{
													submarine.throttle_1 = ActiveUnit.Throttle.Full;
													continue;
												}
												if (Operators.CompareString(innerText2, "Flank", false) != 0)
												{
													submarine.throttle_1 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
													continue;
												}
												submarine.throttle_1 = ActiveUnit.Throttle.Flank;
												continue;
											}
										}
										else if (num2 <= 3070770765U)
										{
											if (num2 != 3020647921U)
											{
												if (num2 != 3070770765U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "SBR_Altitude", false) == 0)
												{
													submarine.float_17 = XmlConvert.ToSingle(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "ActiveUnit_DockingOps", false) == 0)
												{
													ActiveUnit activeUnit2 = submarine;
													ActiveUnit activeUnit = submarine;
													activeUnit2.activeUnit_DockingOps_0 = ActiveUnit_DockingOps.smethod_7(ref xmlNode10, ref dictionary_1, ref activeUnit);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 3164489068U)
										{
											if (num2 != 3189373444U)
											{
												if (num2 != 3204468496U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "SBEO", false) == 0)
												{
													submarine._ActiveUnitStatus_4 = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "LonLR", false) == 0)
												{
													submarine.method_59(new double?(XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", "."))));
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "AMP_OC", false) == 0)
											{
												submarine.bool_17 = Conversions.ToBoolean(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 3559367371U)
									{
										if (num2 <= 3283119613U)
										{
											if (num2 != 3251319825U)
											{
												if (num2 != 3283119613U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "CurrentSpeed", false) == 0)
												{
													goto IL_181C;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBR_TF", false) == 0)
												{
													submarine.bool_19 = Conversions.ToBoolean(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 3370184216U)
										{
											if (num2 != 3389022305U)
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
													submarine.throttle_3 = ActiveUnit.Throttle.FullStop;
													continue;
												}
												if (Operators.CompareString(innerText3, "Loiter", false) == 0)
												{
													submarine.throttle_3 = ActiveUnit.Throttle.Loiter;
													continue;
												}
												if (Operators.CompareString(innerText3, "Cruise", false) == 0)
												{
													submarine.throttle_3 = ActiveUnit.Throttle.Cruise;
													continue;
												}
												if (Operators.CompareString(innerText3, "Full", false) == 0)
												{
													submarine.throttle_3 = ActiveUnit.Throttle.Full;
													continue;
												}
												if (Operators.CompareString(innerText3, "Flank", false) != 0)
												{
													submarine.throttle_3 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
													continue;
												}
												submarine.throttle_3 = ActiveUnit.Throttle.Flank;
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBED", false) == 0)
												{
													submarine._ActiveUnitStatus_3 = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "DesiredTurnRate", false) == 0)
											{
												goto IL_1979;
											}
											continue;
										}
									}
									else if (num2 <= 3792306253U)
									{
										if (num2 != 3736393060U)
										{
											if (num2 != 3792306253U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "Longitude_UnitEntersAreaCheck", false) == 0)
											{
												submarine.vmethod_37(new double?(XmlConvert.ToDouble(xmlNode10.InnerText)));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "ParentGroup", false) == 0)
											{
												submarine.string_6 = xmlNode10.InnerText;
												continue;
											}
											continue;
										}
									}
									else if (num2 != 4080539297U)
									{
										if (num2 != 4146159553U)
										{
											if (num2 == 4152621540U && Operators.CompareString(name2, "CurrentHeading", false) == 0)
											{
												goto IL_1A2C;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "Submarine_Navigator", false) == 0)
											{
												Submarine submarine5 = submarine;
												ActiveUnit activeUnit = submarine;
												submarine5.class215_0 = Class215.smethod_8(ref xmlNode10, ref dictionary_1, ref activeUnit);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "IsAutoDetectable", false) == 0)
										{
											goto IL_1A73;
										}
										continue;
									}
									IL_15DF:
									submarine.vmethod_31(null, XmlConvert.ToDouble(xmlNode10.InnerText));
									continue;
									IL_1A2C:
									submarine.vmethod_10(XmlConvert.ToSingle(xmlNode10.InnerText));
									continue;
								}
								if (num2 <= 812114866U)
								{
									if (num2 <= 454106749U)
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
														submarine.float_16 = XmlConvert.ToSingle(xmlNode10.InnerText);
														continue;
													}
													continue;
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
														submarine.bool_22 = Conversions.ToBoolean(xmlNode10.InnerText);
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
													goto IL_1293;
												}
											}
											else if (Operators.CompareString(name2, "DesiredTurnRate_Navigation", false) != 0)
											{
												continue;
											}
											submarine.vmethod_81((Waypoint.Enum81)Conversions.ToByte(xmlNode10.InnerText));
											continue;
										}
										if (num2 <= 11523833U)
										{
											if (num2 != 6222351U)
											{
												if (num2 != 11523833U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Submarine_Damage", false) == 0)
												{
													Submarine submarine6 = submarine;
													ActiveUnit activeUnit = submarine;
													submarine6.class187_0 = Class187.smethod_1(ref xmlNode10, ref dictionary_1, ref activeUnit);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Status", false) != 0)
												{
													continue;
												}
												if (Versioned.IsNumeric(xmlNode10.InnerText))
												{
													if (Conversions.ToByte(xmlNode10.InnerText) == 18)
													{
														flag = true;
													}
													else
													{
														submarine.vmethod_109((ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText));
													}
												}
												else
												{
													submarine.vmethod_109((ActiveUnit._ActiveUnitStatus)Enum.Parse(typeof(ActiveUnit._ActiveUnitStatus), xmlNode10.InnerText, true));
												}
												if (submarine.vmethod_108() == (ActiveUnit._ActiveUnitStatus)9)
												{
													submarine.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB);
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
												submarine.Name = xmlNode10.InnerText;
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "FSBR", false) == 0)
											{
												submarine._ActiveUnitFuelState_1 = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 634280640U)
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
												goto IL_1A73;
											}
											else
											{
												if (Operators.CompareString(name2, "SBED_Altitude_TF", false) == 0)
												{
													submarine.nullable_14 = new float?(XmlConvert.ToSingle(xmlNode10.InnerText));
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
											goto IL_143F;
										}
										else
										{
											if (Operators.CompareString(name2, "LatLR", false) == 0)
											{
												submarine.method_57(new double?(XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", "."))));
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 751723973U)
									{
										if (num2 != 664498478U)
										{
											if (num2 != 751723973U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "DT", false) != 0)
											{
												continue;
											}
											goto IL_1979;
										}
										else
										{
											if (Operators.CompareString(name2, "FuelState", false) == 0)
											{
												submarine._ActiveUnitFuelState_0 = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 != 803468658U)
									{
										if (num2 != 803760973U)
										{
											if (num2 != 812114866U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "COA", false) == 0)
											{
												submarine.int_5 = Conversions.ToInteger(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "DamagePts", false) == 0 && !bool_27)
											{
												submarine.vmethod_64(false, null, XmlConvert.ToSingle(xmlNode10.InnerText));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "Submarine_Kinematics", false) == 0)
										{
											ActiveUnit_Kinematics.smethod_0(xmlNode10, dictionary_1, submarine);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (num2 <= 1143797280U)
									{
										if (num2 <= 936277782U)
										{
											if (num2 <= 882606391U)
											{
												if (num2 != 827630232U)
												{
													if (num2 != 882606391U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "AMP_OC_DAO", false) == 0)
													{
														submarine.bool_18 = Conversions.ToBoolean(xmlNode10.InnerText);
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "SBED_Altitude", false) == 0)
													{
														submarine.float_19 = XmlConvert.ToSingle(xmlNode10.InnerText);
														continue;
													}
													continue;
												}
											}
											else if (num2 != 892023141U)
											{
												if (num2 != 936277782U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "DA", false) != 0)
												{
													continue;
												}
												goto IL_1240;
											}
											else if (Operators.CompareString(name2, "DesiredHeading", false) != 0)
											{
												continue;
											}
										}
										else if (num2 <= 967155461U)
										{
											if (num2 != 944764534U)
											{
												if (num2 != 967155461U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "SBPF_ThrottleSetting", false) != 0)
												{
													continue;
												}
												string innerText4 = xmlNode10.InnerText;
												if (Operators.CompareString(innerText4, "FullStop", false) == 0)
												{
													submarine.throttle_4 = ActiveUnit.Throttle.FullStop;
													continue;
												}
												if (Operators.CompareString(innerText4, "Loiter", false) == 0)
												{
													submarine.throttle_4 = ActiveUnit.Throttle.Loiter;
													continue;
												}
												if (Operators.CompareString(innerText4, "Cruise", false) == 0)
												{
													submarine.throttle_4 = ActiveUnit.Throttle.Cruise;
													continue;
												}
												if (Operators.CompareString(innerText4, "Full", false) == 0)
												{
													submarine.throttle_4 = ActiveUnit.Throttle.Full;
													continue;
												}
												if (Operators.CompareString(innerText4, "Flank", false) != 0)
												{
													submarine.throttle_4 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
													continue;
												}
												submarine.throttle_4 = ActiveUnit.Throttle.Flank;
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Submarine_AI", false) == 0)
												{
													Submarine submarine7 = submarine;
													ActiveUnit activeUnit = submarine;
													submarine7.submarine_AI_0 = Submarine_AI.smethod_1(ref xmlNode10, ref dictionary_1, ref activeUnit);
													continue;
												}
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
													submarine.float_18 = XmlConvert.ToSingle(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBPF_Altitude_TF", false) == 0)
												{
													submarine.float_23 = XmlConvert.ToSingle(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (Operators.CompareString(name2, "DH", false) != 0)
										{
											continue;
										}
										submarine.vmethod_69(ActiveUnit.Enum28.const_0, XmlConvert.ToSingle(xmlNode10.InnerText));
										continue;
									}
									if (num2 <= 1339890663U)
									{
										if (num2 <= 1175569298U)
										{
											if (num2 != 1156592502U)
											{
												if (num2 != 1175569298U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "ActiveUnit_AirOps", false) == 0)
												{
													ActiveUnit activeUnit3 = submarine;
													ActiveUnit activeUnit = submarine;
													activeUnit3.activeUnit_AirOps_0 = ActiveUnit_AirOps.smethod_0(ref xmlNode10, ref dictionary_1, ref activeUnit);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBR", false) == 0)
												{
													submarine._ActiveUnitStatus_2 = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 1255847155U)
										{
											if (num2 != 1259548010U)
											{
												if (num2 != 1339890663U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "ActiveEnterAreaTriggers", false) != 0)
												{
													continue;
												}
												try
												{
													foreach (object obj13 in xmlNode10.ChildNodes)
													{
														string innerText5 = ((XmlNode)obj13).InnerText;
														submarine.list_0.Add(innerText5);
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
											if (Operators.CompareString(name2, "SBED_ThrottleSetting", false) != 0)
											{
												continue;
											}
											string innerText6 = xmlNode10.InnerText;
											if (Operators.CompareString(innerText6, "FullStop", false) == 0)
											{
												submarine.throttle_2 = ActiveUnit.Throttle.FullStop;
												continue;
											}
											if (Operators.CompareString(innerText6, "Loiter", false) == 0)
											{
												submarine.throttle_2 = ActiveUnit.Throttle.Loiter;
												continue;
											}
											if (Operators.CompareString(innerText6, "Cruise", false) == 0)
											{
												submarine.throttle_2 = ActiveUnit.Throttle.Cruise;
												continue;
											}
											if (Operators.CompareString(innerText6, "Full", false) == 0)
											{
												submarine.throttle_2 = ActiveUnit.Throttle.Full;
												continue;
											}
											if (Operators.CompareString(innerText6, "Flank", false) != 0)
											{
												submarine.throttle_2 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											submarine.throttle_2 = ActiveUnit.Throttle.Flank;
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "ThrottleSetting", false) != 0)
											{
												continue;
											}
											string innerText7 = xmlNode10.InnerText;
											if (Operators.CompareString(innerText7, "FullStop", false) == 0)
											{
												submarine.throttle_0 = ActiveUnit.Throttle.FullStop;
												continue;
											}
											if (Operators.CompareString(innerText7, "Loiter", false) == 0)
											{
												submarine.throttle_0 = ActiveUnit.Throttle.Loiter;
												continue;
											}
											if (Operators.CompareString(innerText7, "Cruise", false) == 0)
											{
												submarine.throttle_0 = ActiveUnit.Throttle.Cruise;
												continue;
											}
											if (Operators.CompareString(innerText7, "Full", false) == 0)
											{
												submarine.throttle_0 = ActiveUnit.Throttle.Full;
												continue;
											}
											if (Operators.CompareString(innerText7, "Flank", false) != 0)
											{
												submarine.throttle_0 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											submarine.throttle_0 = ActiveUnit.Throttle.Flank;
											continue;
										}
									}
									else if (num2 <= 1444793274U)
									{
										if (num2 != 1422437055U)
										{
											if (num2 != 1444793274U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "Prof", false) == 0)
											{
												submarine.vmethod_54(new GlobalVariables.ProficiencyLevel?((GlobalVariables.ProficiencyLevel)Conversions.ToInteger(xmlNode10.InnerText)));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "Doctrine", false) == 0)
											{
												submarine.doctrine_0 = Doctrine.smethod_9(ref xmlNode10, submarine);
												continue;
											}
											continue;
										}
									}
									else if (num2 != 1476905714U)
									{
										if (num2 != 1488303767U)
										{
											if (num2 != 1708783731U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "CS", false) != 0)
											{
												continue;
											}
											goto IL_181C;
										}
										else
										{
											if (Operators.CompareString(name2, "SBEO_TF", false) == 0)
											{
												submarine.bool_21 = Conversions.ToBoolean(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "WeaponState", false) == 0)
										{
											submarine._ActiveUnitWeaponState_0 = (ActiveUnit._ActiveUnitWeaponState)Conversions.ToByte(xmlNode10.InnerText);
											continue;
										}
										continue;
									}
								}
								IL_1240:
								submarine.vmethod_73(XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_1293:
								submarine.vmethod_15(false, XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_143F:
								submarine.vmethod_71(XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_181C:
								submarine.vmethod_41(XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_1979:
								submarine.vmethod_79((ActiveUnit.Enum28)Conversions.ToByte(xmlNode10.InnerText));
								continue;
								IL_1A73:
								submarine.method_93(null, Conversions.ToBoolean(xmlNode10.InnerText));
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
						float num3 = submarine.method_154().vmethod_30();
						float num4 = submarine.method_154().vmethod_31();
						if (submarine.vmethod_14(false) > num3)
						{
							submarine.vmethod_15(false, num3);
						}
						else if (submarine.vmethod_14(false) < num4)
						{
							submarine.vmethod_15(false, num4);
						}
						if (submarine.vmethod_72() > num3)
						{
							submarine.vmethod_73(num3);
						}
						else if (submarine.vmethod_72() < num4)
						{
							submarine.vmethod_73(num4);
						}
						if (flag)
						{
							submarine.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries);
						}
						result = submarine;
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100800", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0000CB57 File Offset: 0x0000AD57
		public override float vmethod_139()
		{
			return this.float_13 * this.float_25;
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x000041ED File Offset: 0x000023ED
		public override bool vmethod_43()
		{
			return true;
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x0000CB66 File Offset: 0x0000AD66
		public override GlobalVariables.ActiveUnitType vmethod_56()
		{
			return GlobalVariables.ActiveUnitType.Submarine;
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x001C436C File Offset: 0x001C256C
		public override ActiveUnit._ActiveUnitFuelState vmethod_61(GeoPoint geoPoint_0, Doctrine._FuelState? nullable_17)
		{
			ActiveUnit._ActiveUnitFuelState result;
			try
			{
				if (this.method_160())
				{
					result = ActiveUnit._ActiveUnitFuelState.None;
				}
				else if (this.method_159() && Enumerable.Count<FuelRec>(this.vmethod_67()) == 0)
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
				ex.Data.Add("Error at 100801", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = ActiveUnit._ActiveUnitFuelState.None;
			}
			return result;
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x001C4424 File Offset: 0x001C2624
		public override ActiveUnit._ActiveUnitFuelState vmethod_62(ActiveUnit activeUnit_0, GeoPoint geoPoint_0, Doctrine._FuelState? nullable_17)
		{
			try
			{
				Engine engine_ = null;
				Engine.Enum112 @enum;
				if (Enumerable.Count<Engine>(Enumerable.Where<Engine>(this.vmethod_49(), (Submarine._Closure$__.$I51-0 == null) ? (Submarine._Closure$__.$I51-0 = new Func<Engine, bool>(Submarine._Closure$__.$I.method_0)) : Submarine._Closure$__.$I51-0)) > 0)
				{
					@enum = Engine.Enum112.const_6;
				}
				else
				{
					@enum = Engine.Enum112.const_10;
				}
				int num = this.vmethod_49().Count - 1;
				int i = 0;
				while (i <= num)
				{
					Engine engine = this.vmethod_49()[i];
					if (engine.enum112_0 == @enum)
					{
						engine_ = engine;
						int num2 = i;
						IL_8A:
						float num3 = Math.Max(-20f, this.method_154().vmethod_31());
						float num4 = (float)this.method_154().method_17(num3, ActiveUnit.Throttle.Cruise, engine_, num2, false);
						float num5 = (float)this.method_168(ActiveUnit.Throttle.Cruise, null, new float?(num4), new float?(num3), engine_, num2);
						if (num5 <= 900f)
						{
							return ActiveUnit._ActiveUnitFuelState.IsBingo;
						}
						float num6 = base.method_36(activeUnit_0);
						if ((double)(num5 * (num4 / 3600f)) >= (double)num6 * 1.1)
						{
							return ActiveUnit._ActiveUnitFuelState.None;
						}
						return ActiveUnit._ActiveUnitFuelState.IsBingo;
					}
					else
					{
						i++;
					}
				}
				goto IL_8A;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100802", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			ActiveUnit._ActiveUnitFuelState result;
			return result;
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0000CB69 File Offset: 0x0000AD69
		public Dictionary<int, Engine> method_144()
		{
			if (this.dictionary_0 == null)
			{
				this.dictionary_0 = this.method_153().method_117();
			}
			return this.dictionary_0;
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0000CB8A File Offset: 0x0000AD8A
		public void method_145(Dictionary<int, Engine> dictionary_1)
		{
			this.dictionary_0 = dictionary_1;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0000CB93 File Offset: 0x0000AD93
		public Engine method_146()
		{
			if (this.engine_0 == null)
			{
				this.method_153().method_117();
			}
			return this.engine_0;
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0000CBAF File Offset: 0x0000ADAF
		public void method_147(Engine engine_1)
		{
			this.engine_0 = engine_1;
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		public int method_148()
		{
			if (this.engine_0 == null)
			{
				this.method_153().method_117();
			}
			return this.int_8;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0000CBD4 File Offset: 0x0000ADD4
		public void method_149(int int_11)
		{
			this.int_8 = int_11;
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x0000C64A File Offset: 0x0000A84A
		public override float vmethod_70()
		{
			return base.vmethod_70();
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x001C4590 File Offset: 0x001C2790
		public override void vmethod_71(float float_31)
		{
			if (this.method_154().vmethod_10() == null && float_31 > (float)Submarine.int_10 && this.vmethod_108() != ActiveUnit._ActiveUnitStatus.EngagedDefensive && this.method_156().method_67())
			{
				float_31 = (float)Submarine.int_10;
			}
			if (this.method_152().bool_15 && this.vmethod_108() != ActiveUnit._ActiveUnitStatus.EngagedDefensive)
			{
				float num = (float)Math.Min(this.method_154().method_7(this.vmethod_14(false)), this.method_154().method_7(this.vmethod_72()));
				if (float_31 >= num)
				{
					float_31 = (float)((double)num - 0.1);
				}
			}
			if (float_31 != this.vmethod_70())
			{
				base.vmethod_71(float_31);
			}
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00008501 File Offset: 0x00006701
		public override float vmethod_72()
		{
			return base.vmethod_72();
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x001C4644 File Offset: 0x001C2844
		public override void vmethod_73(float float_31)
		{
			float num = this.vmethod_72();
			if (Math.Round((double)this.vmethod_72()) < -20.0 && this.method_158().vmethod_3() > ActiveUnit_Damage.FireIntensityLevel.Minor)
			{
				float_31 = -20f;
			}
			if (this.method_158().vmethod_1() > ActiveUnit_Damage.FloodingIntensityLevel.Minor)
			{
				float_31 = 0f;
			}
			if (num != float_31 && Math.Round((double)float_31) < -20.0)
			{
				this.method_165();
			}
			float num2 = (float)base.method_9(false, false, false);
			if (float_31 < num2 + 1f)
			{
				float_31 = num2 + 1f;
			}
			base.vmethod_73(float_31);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x001C46DC File Offset: 0x001C28DC
		public override bool vmethod_97()
		{
			return !this.method_160() && Enumerable.Count<FuelRec>(this.vmethod_67()) != 0 && base.vmethod_97();
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0000CBDD File Offset: 0x0000ADDD
		public bool method_150()
		{
			return this.vmethod_40() >= (float)this.method_154().method_7(this.vmethod_14(false));
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x001C4710 File Offset: 0x001C2910
		public Ship.Enum119 method_151()
		{
			Ship.Enum119 result;
			if (this.vmethod_40() == 0f)
			{
				result = Ship.Enum119.const_0;
			}
			else if (this.method_161())
			{
				result = Ship.Enum119.const_2;
			}
			else if (this.method_162())
			{
				result = Ship.Enum119.const_1;
			}
			else
			{
				result = Ship.Enum119.const_0;
			}
			return result;
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x001C474C File Offset: 0x001C294C
		public Class215 method_152()
		{
			if (Information.IsNothing(this.class215_0))
			{
				ActiveUnit activeUnit = this;
				this.class215_0 = new Class215(ref activeUnit);
			}
			return this.class215_0;
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x001C477C File Offset: 0x001C297C
		public Submarine_AI method_153()
		{
			if (Information.IsNothing(this.submarine_AI_0))
			{
				ActiveUnit activeUnit = this;
				this.submarine_AI_0 = new Submarine_AI(ref activeUnit);
			}
			return this.submarine_AI_0;
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x001C47AC File Offset: 0x001C29AC
		public Submarine_Kinematics method_154()
		{
			if (Information.IsNothing(this.submarine_Kinematics_0))
			{
				ActiveUnit activeUnit = this;
				this.submarine_Kinematics_0 = new Submarine_Kinematics(ref activeUnit);
			}
			return this.submarine_Kinematics_0;
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x001C47DC File Offset: 0x001C29DC
		public Class222 method_155()
		{
			if (Information.IsNothing(this.class222_0))
			{
				ActiveUnit activeUnit = this;
				this.class222_0 = new Class222(ref activeUnit);
			}
			return this.class222_0;
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x001C480C File Offset: 0x001C2A0C
		public Submarine_Weaponry method_156()
		{
			if (Information.IsNothing(this.submarine_Weaponry_0))
			{
				ActiveUnit activeUnit = this;
				this.submarine_Weaponry_0 = new Submarine_Weaponry(ref activeUnit);
			}
			return this.submarine_Weaponry_0;
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x001C483C File Offset: 0x001C2A3C
		public Class184 method_157()
		{
			if (Information.IsNothing(this.class184_0))
			{
				ActiveUnit activeUnit = this;
				this.class184_0 = new Class184(ref activeUnit);
			}
			return this.class184_0;
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x001C486C File Offset: 0x001C2A6C
		public Class187 method_158()
		{
			if (Information.IsNothing(this.class187_0))
			{
				ActiveUnit activeUnit = this;
				this.class187_0 = new Class187(ref activeUnit);
			}
			return this.class187_0;
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0000CBFD File Offset: 0x0000ADFD
		public bool method_159()
		{
			return this._SubmarineType_0 == Submarine._SubmarineType.ROV && this.short_3 > 0;
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x001C489C File Offset: 0x001C2A9C
		public bool method_160()
		{
			bool value;
			try
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
				value = this.nullable_16.Value;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100803", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return value;
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x0000CC17 File Offset: 0x0000AE17
		public override int vmethod_11()
		{
			return (int)Math.Round((double)(22f + this.vmethod_14(false)));
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0000CC17 File Offset: 0x0000AE17
		public override int vmethod_12()
		{
			return (int)Math.Round((double)(22f + this.vmethod_14(false)));
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x001C4970 File Offset: 0x001C2B70
		public override ActiveUnit.Throttle vmethod_82()
		{
			AltBand altBand = this.method_154().vmethod_42(this.vmethod_14(false), false);
			ActiveUnit.Throttle result;
			if (altBand.nullable_3 != null && altBand.nullable_1 != null)
			{
				result = ActiveUnit.Throttle.Flank;
			}
			else
			{
				result = ActiveUnit.Throttle.Full;
			}
			return result;
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0000CC2D File Offset: 0x0000AE2D
		public bool method_161()
		{
			return this.vmethod_14(false) >= -5f;
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x0000CC40 File Offset: 0x0000AE40
		public bool method_162()
		{
			return Math.Round((double)this.vmethod_14(false)) >= -20.0 && Math.Round((double)this.vmethod_14(false)) < -5.0;
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x001C49B4 File Offset: 0x001C2BB4
		public override GlobalVariables.TargetVisualSizeClass vmethod_121()
		{
			GlobalVariables.TargetVisualSizeClass result;
			if (this.vmethod_14(false) >= -5f)
			{
				float float_ = this.float_13;
				if (float_ > 150f)
				{
					result = GlobalVariables.TargetVisualSizeClass.VLarge;
				}
				else if (float_ > 100f)
				{
					result = GlobalVariables.TargetVisualSizeClass.Large;
				}
				else if (float_ > 60f)
				{
					result = GlobalVariables.TargetVisualSizeClass.Medium;
				}
				else if (float_ > 35f)
				{
					result = GlobalVariables.TargetVisualSizeClass.Small;
				}
				else
				{
					result = GlobalVariables.TargetVisualSizeClass.VSmall;
				}
			}
			else if (this.vmethod_14(false) >= -20f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Stealthy;
			}
			return result;
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x001C4A1C File Offset: 0x001C2C1C
		public override void vmethod_126(float float_31, ref Random random_0)
		{
			try
			{
				if (this._SubmarineType_0 == Submarine._SubmarineType.ROV && this.vmethod_101() != null && this.vmethod_101()._MissionClass_0 == Mission._MissionClass.MineClearing && this.vmethod_127() && base.method_83())
				{
					bool flag = false;
					try
					{
						foreach (Sensor sensor in this.vmethod_95())
						{
							if (sensor.method_66() && sensor.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
							{
								flag = true;
								break;
							}
						}
					}
					finally
					{
						List<Sensor>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (!flag)
					{
						this.vmethod_113(ActiveUnit._ActiveUnitWeaponState.IsWinchester);
						this.vmethod_93().method_5(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
					}
				}
				this.vmethod_93().method_22(float_31);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100804", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0000C666 File Offset: 0x0000A866
		public override void vmethod_122(ref Scenario scenario_1, Dictionary<string, Class310> dictionary_1, List<ActiveUnit> list_3, bool bool_27)
		{
			base.vmethod_122(ref scenario_1, dictionary_1, list_3, bool_27);
			ActiveUnit_DockingOps.smethod_8(this.vmethod_93(), ref scenario_1, dictionary_1, bool_27);
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x001C4B20 File Offset: 0x001C2D20
		public override void vmethod_134(ActiveUnit.Throttle ThrottleSetting, float? SpecificDesiredSpeed = null)
		{
			try
			{
				if (ThrottleSetting > ActiveUnit.Throttle.Flank)
				{
					ThrottleSetting = ActiveUnit.Throttle.Flank;
				}
				if (ThrottleSetting < ActiveUnit.Throttle.FullStop)
				{
					ThrottleSetting = ActiveUnit.Throttle.FullStop;
				}
				if (ThrottleSetting > this.vmethod_82())
				{
					ThrottleSetting = this.vmethod_82();
				}
				this.throttle_0 = ThrottleSetting;
				if (!this.bool_1)
				{
					if (Information.IsNothing(SpecificDesiredSpeed))
					{
						this.vmethod_71((float)this.method_154().vmethod_40(this.vmethod_14(false), this.throttle_0, false));
					}
					else
					{
						this.vmethod_71(SpecificDesiredSpeed.Value);
					}
				}
				base.method_110(this, this.throttle_0);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200583", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x001C4BF0 File Offset: 0x001C2DF0
		public override bool vmethod_47(double double_4, double double_5, ref int int_11, bool bool_27, bool bool_28, bool bool_29, ref bool bool_30, bool bool_31, ref bool bool_32, float? nullable_17, short? nullable_18, ref List<ActiveUnit> list_3, float float_31, bool bool_33, bool bool_34, ref string string_9, ref bool bool_35)
		{
			bool result;
			try
			{
				int_11 = 1;
				if (!double.IsNaN(double_4) && !double.IsNaN(double_5))
				{
					if (bool_33 && this.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive && this.vmethod_101() != null && this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
					{
						Class343 @class = (Class343)this.vmethod_101();
						if (this.vmethod_46(@class.list_15, this.scenario_0, true) && !GeoPoint.smethod_4(double_4, double_5, @class.list_15, true))
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
					if (GeoPoint.smethod_11(double_4, double_5))
					{
						bool_30 = false;
						bool_32 = false;
						result = true;
					}
					else if ((bool_30 || bool_27) && base.method_130(double_4, double_5, float_31))
					{
						bool_30 = true;
						bool_32 = false;
						string_9 = "The point is inside a No-Nav Zone.";
						result = false;
					}
					else if ((Information.IsNothing(list_3) || list_3.Count > 0) && GeoPoint.smethod_10(double_4, double_5, this.scenario_0, ref list_3))
					{
						bool_30 = false;
						bool_32 = false;
						result = true;
					}
					else if (!this.method_163(double_4, double_5, bool_27, bool_28, bool_29, bool_31, ref bool_32, nullable_18, ref string_9, ref bool_35))
					{
						bool_30 = false;
						bool_32 = false;
						result = false;
					}
					else
					{
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
				ex.Data.Add("Error at 200283", ex.Message);
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

		// Token: 0x060018FE RID: 6398 RVA: 0x001C4DB4 File Offset: 0x001C2FB4
		public override void vmethod_133(bool bool_27, bool bool_28, bool bool_29)
		{
			checked
			{
				try
				{
					this.bool_24 = true;
					this.vmethod_93().method_16(null);
					if (!this.vmethod_127() && !bool_27)
					{
						this.scenario_0.method_59(this.Name + " has been destroyed!", this.Name + " is destroyed!", LoggedMessage.MessageType.UnitLost, 0, this.string_0, this.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					}
					base.method_107(bool_27, false, this.method_158().method_0(), bool_29);
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
					ex.Data.Add("Error at 100807", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x001C5054 File Offset: 0x001C3254
		public override int vmethod_131(bool bool_27)
		{
			int result;
			if (this._SubmarineType_0 == Submarine._SubmarineType.ROV)
			{
				result = 0;
			}
			else
			{
				result = base.vmethod_131(bool_27);
			}
			return result;
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x001C507C File Offset: 0x001C327C
		private bool method_163(double double_4, double double_5, bool bool_27, bool bool_28, bool bool_29, bool bool_30, ref bool bool_31, short? nullable_17, ref string string_9, ref bool bool_32)
		{
			Submarine.Class372 @class = new Submarine.Class372();
			@class.submarine_0 = this;
			@class.double_0 = double_4;
			@class.double_1 = double_5;
			@class.bool_1 = bool_27;
			@class.bool_0 = bool_28;
			@class.bool_2 = bool_29;
			short num;
			if (Information.IsNothing(nullable_17))
			{
				num = Terrain.smethod_7(@class.double_0, @class.double_1, false);
			}
			else
			{
				num = nullable_17.Value;
			}
			short num2 = -10;
			bool result;
			try
			{
				if (num > num2)
				{
					bool_32 = false;
					result = false;
				}
				else if (bool_30 && !this.method_160() && Class442.smethod_1(@class.double_1, @class.double_0))
				{
					string_9 = "Point is under ice and the submarine is not nuclear powered.";
					result = false;
				}
				else
				{
					if (bool_31)
					{
						Submarine.Class373 class2 = new Submarine.Class373();
						class2.class372_0 = @class;
						class2.bool_0 = false;
						if (this.vmethod_131(class2.class372_0.bool_0) > 0 && this.vmethod_7(false).hashSet_0.Count > 0)
						{
							Parallel.ForEach<string>(Enumerable.ToList<string>(this.vmethod_7(false).hashSet_0), new Action<string, ParallelLoopState>(class2.method_0));
						}
						if (class2.bool_0)
						{
							bool_31 = true;
							string_9 = "A mine is too close.";
							return false;
						}
					}
					result = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100808", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				string_9 = "Error!";
				result = false;
			}
			return result;
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x001C5200 File Offset: 0x001C3400
		public Submarine(ref Scenario theScen, string theGUID = null) : base(ref theScen, theGUID)
		{
			this.struct35_0 = default(Submarine.Struct35);
			this.class346_0 = new Class346(this);
			this.class347_0 = new Class347(this);
			this.class345_0 = new Class345(this, "Conn / CIC");
			this.cargo_1 = new Cargo(this);
			this.bool_5 = true;
			this.bool_4 = true;
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x0000CC74 File Offset: 0x0000AE74
		public override float vmethod_14(bool DoSanityCheck = false)
		{
			return base.vmethod_14(DoSanityCheck);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x001C5264 File Offset: 0x001C3464
		public override void vmethod_15(bool DoSanityCheck = false, float value)
		{
			base.vmethod_15(DoSanityCheck, value);
			if (!this.method_159() && this.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_9))
			{
				if (value >= (float)Submarine.int_9)
				{
					this.method_157().method_1(ActiveUnit_CommStuff.Enum31.const_0, true);
					if (this.method_157().method_3())
					{
						this.method_157().method_4(false);
						this.method_153().method_115(ActiveUnit_AI.SubmarineDepthPreset.None);
						this.vmethod_73((float)Submarine.int_9);
						this.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
						return;
					}
				}
				else
				{
					this.method_157().method_1(ActiveUnit_CommStuff.Enum31.const_3, false);
				}
			}
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00008596 File Offset: 0x00006796
		public override float vmethod_40()
		{
			return base.vmethod_40();
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x0000CC7D File Offset: 0x0000AE7D
		public override void vmethod_41(float float_31)
		{
			base.vmethod_41(float_31);
			if (this.scenario_0.FifteenthSecondIsChangingOnThisPulse && float_31 > (float)Submarine.int_10)
			{
				this.method_156().method_68(Submarine_Weaponry.Enum121.const_2);
			}
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		public override void vmethod_69(ActiveUnit.Enum28 enum28_1, float float_31)
		{
			base.vmethod_69(enum28_1, float_31);
			if (this.scenario_0.FifteenthSecondIsChangingOnThisPulse && float_31 == 0f)
			{
				this.method_156().method_68(Submarine_Weaponry.Enum121.const_1);
			}
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x001B1098 File Offset: 0x001AF298
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

		// Token: 0x06001908 RID: 6408 RVA: 0x001C52F4 File Offset: 0x001C34F4
		public override void vmethod_137(float float_31)
		{
			try
			{
				if (!this.method_160())
				{
					if (Enumerable.Count<FuelRec>(this.vmethod_67()) != 0)
					{
						if (this.vmethod_84() != ActiveUnit.Throttle.FullStop || !this.method_160())
						{
							this.method_145(this.method_153().method_117());
							try
							{
								foreach (KeyValuePair<int, Engine> keyValuePair in this.method_144())
								{
									Submarine.Class374 @class = new Submarine.Class374(@class);
									Engine value = keyValuePair.Value;
									int key = keyValuePair.Key;
									@class._FuelType_0 = this.method_153().method_116(value);
									FuelRec fuelRec;
									if (@class._FuelType_0 != FuelRec._FuelType.Battery)
									{
										if (Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Select<FuelRec, FuelRec>(Enumerable.Where<FuelRec>(this.vmethod_67(), new Func<FuelRec, bool>(@class.method_0)), (Submarine._Closure$__.$I121-1 == null) ? (Submarine._Closure$__.$I121-1 = new Func<FuelRec, FuelRec>(Submarine._Closure$__.$I.method_1)) : Submarine._Closure$__.$I121-1), 0).float_0 == 0f)
										{
											continue;
										}
										if (fuelRec == null)
										{
											fuelRec = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Select<FuelRec, FuelRec>(Enumerable.Where<FuelRec>(this.vmethod_67(), (Submarine._Closure$__.$I121-2 == null) ? (Submarine._Closure$__.$I121-2 = new Func<FuelRec, bool>(Submarine._Closure$__.$I.method_2)) : Submarine._Closure$__.$I121-2), (Submarine._Closure$__.$I121-3 == null) ? (Submarine._Closure$__.$I121-3 = new Func<FuelRec, FuelRec>(Submarine._Closure$__.$I.method_3)) : Submarine._Closure$__.$I121-3), 0);
										}
										if (fuelRec != null && fuelRec.method_9() >= 1f)
										{
											continue;
										}
									}
									float num;
									if (@class._FuelType_0 == FuelRec._FuelType.AirIndepedent)
									{
										num = this.method_167(ActiveUnit.Throttle.Loiter, null, null, null, value, key);
									}
									else
									{
										num = this.method_167(this.vmethod_84(), null, new float?((float)((int)Math.Round((double)this.vmethod_70()))), new float?(this.vmethod_14(false)), value, key);
									}
									float float_32 = num * float_31;
									this.method_164(float_32, @class._FuelType_0);
									if (value.enum112_0 == Engine.Enum112.const_6)
									{
										this.method_166(value, fuelRec, float_31);
									}
									else if (value.enum112_0 == Engine.Enum112.const_11)
									{
										this.method_166(value, fuelRec, float_31);
									}
								}
							}
							finally
							{
								Dictionary<int, Engine>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100809", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x001C5598 File Offset: 0x001C3798
		public void method_164(float float_31, FuelRec._FuelType _FuelType_0)
		{
			Submarine.Class375 @class = new Submarine.Class375();
			@class._FuelType_0 = _FuelType_0;
			try
			{
				if (float_31 != 0f)
				{
					FuelRec fuelRec = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Select<FuelRec, FuelRec>(Enumerable.Where<FuelRec>(this.vmethod_67(), new Func<FuelRec, bool>(@class.method_0)), (Submarine._Closure$__.$I122-1 == null) ? (Submarine._Closure$__.$I122-1 = new Func<FuelRec, FuelRec>(Submarine._Closure$__.$I.method_4)) : Submarine._Closure$__.$I122-1), 0);
					if (fuelRec.float_0 > float_31)
					{
						fuelRec.float_0 -= float_31;
					}
					else
					{
						bool flag = fuelRec.float_0 > 0f;
						fuelRec.float_0 = 0f;
						if (Enumerable.Count<FuelRec>(Enumerable.Where<FuelRec>(this.vmethod_67(), (Submarine._Closure$__.$I122-2 == null) ? (Submarine._Closure$__.$I122-2 = new Func<FuelRec, bool>(Submarine._Closure$__.$I.method_5)) : Submarine._Closure$__.$I122-2)) == 0)
						{
							this.vmethod_134(ActiveUnit.Throttle.FullStop, null);
							if (flag)
							{
								base.method_124(this.Name + " (" + Misc.smethod_9(this.string_2) + ") has run out of fuel and lies dead in the water!", this.Name + " ran out of fuel!", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
								this.method_154().vmethod_11(null);
							}
						}
						else if (flag)
						{
							this.vmethod_134(ActiveUnit.Throttle.Loiter, null);
							base.method_124(this.Name + " (" + Misc.smethod_9(this.string_2) + ") has run out of fuel, attempting to use alternative propulsion.", this.Name + " switching propulsion", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							this.method_154().vmethod_11(null);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100810", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x0000CCD3 File Offset: 0x0000AED3
		public void method_165()
		{
			if (this.vmethod_93().method_8() == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
			{
				this.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
			}
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x001C57E8 File Offset: 0x001C39E8
		public void method_166(Engine engine_1, FuelRec fuelRec_1, float float_31)
		{
			try
			{
				if (!Information.IsNothing(fuelRec_1))
				{
					if (engine_1.enum112_0 != Engine.Enum112.const_6 || Math.Round((double)this.vmethod_14(false)) >= -20.0)
					{
						if (engine_1.enum112_0 == Engine.Enum112.const_6 || engine_1.enum112_0 == Engine.Enum112.const_11)
						{
							float num;
							if (engine_1.enum112_0 == Engine.Enum112.const_6)
							{
								if (this.vmethod_93().method_8() != ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
								{
									this.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries);
								}
								num = (float)((double)fuelRec_1.int_0 / 60.0 / 8.0);
							}
							else if (engine_1.enum112_0 == Engine.Enum112.const_11)
							{
								Engine engine = Enumerable.ElementAtOrDefault<Engine>(Enumerable.Where<Engine>(this.vmethod_49(), (Submarine._Closure$__.$I124-0 == null) ? (Submarine._Closure$__.$I124-0 = new Func<Engine, bool>(Submarine._Closure$__.$I.method_6)) : Submarine._Closure$__.$I124-0), 0);
								if (Information.IsNothing(engine))
								{
									engine = Enumerable.ElementAtOrDefault<Engine>(Enumerable.Where<Engine>(this.vmethod_49(), (Submarine._Closure$__.$I124-1 == null) ? (Submarine._Closure$__.$I124-1 = new Func<Engine, bool>(Submarine._Closure$__.$I.method_7)) : Submarine._Closure$__.$I124-1), 0);
								}
								if (Information.IsNothing(engine))
								{
									num = 1f;
								}
								else if (engine.altBand_0[0].float_2 > 0f)
								{
									num = engine.altBand_0[0].float_2;
								}
								else
								{
									num = 1f;
								}
								if (fuelRec_1.float_0 <= 0f)
								{
									fuelRec_1.float_0 = 0.0001f;
								}
							}
							ref float ptr = ref fuelRec_1.float_0;
							fuelRec_1.float_0 = ptr + num / 60f * float_31;
							if (fuelRec_1.float_0 > (float)fuelRec_1.int_0)
							{
								fuelRec_1.float_0 = (float)fuelRec_1.int_0;
							}
							if (fuelRec_1.float_0 == (float)fuelRec_1.int_0)
							{
								this.method_165();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100811", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x001C5A08 File Offset: 0x001C3C08
		public override float vmethod_98(ActiveUnit.Throttle throttle_5, AltBand altBand_0, float? nullable_17, float? nullable_18, bool bool_27, bool bool_28, bool bool_29, bool bool_30, bool bool_31)
		{
			float result;
			if (!this.method_160() && !this.method_142())
			{
				result = this.method_167(throttle_5, null, new float?((float)((int)Math.Round((double)this.vmethod_70()))), new float?(this.vmethod_14(false)), this.method_146(), this.method_148());
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x001C5A64 File Offset: 0x001C3C64
		public float method_167(ActiveUnit.Throttle throttle_5, AltBand altBand_0, float? nullable_17, float? nullable_18, Engine engine_1, int int_11)
		{
			Submarine.Class376 @class = new Submarine.Class376();
			if (!this.method_160() && !this.method_142())
			{
				if (engine_1 == null)
				{
					return 0f;
				}
				if (this.vmethod_49().Count == 0)
				{
					return 0f;
				}
				@class.altBand_0 = null;
				try
				{
					if (engine_1.vmethod_5() == PlatformComponent._ComponentStatus.Destroyed)
					{
						return 0f;
					}
					if (engine_1.altBand_0.Length == 0)
					{
						return 0f;
					}
					if (engine_1 != this.vmethod_49()[int_11])
					{
						this.method_153().method_117();
						engine_1 = this.method_146();
						int_11 = this.method_148();
					}
					if (altBand_0 == null)
					{
						if (nullable_18 != null)
						{
							@class.altBand_0 = ActiveUnit_Kinematics.smethod_1(this, nullable_18.Value, new int?(int_11), false);
						}
						else
						{
							@class.altBand_0 = this.method_154().vmethod_42(this.vmethod_14(false), false);
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
					float num2;
					switch (throttle_5)
					{
					case ActiveUnit.Throttle.FullStop:
						return 0f;
					case ActiveUnit.Throttle.Loiter:
						num = @class.altBand_0.float_2;
						num2 = 0f;
						break;
					case ActiveUnit.Throttle.Cruise:
						if (engine_1.altBand_0[0].float_3 <= 0f)
						{
							return this.method_167(ActiveUnit.Throttle.Loiter, altBand_0, nullable_17, nullable_18, engine_1, int_11);
						}
						num = @class.altBand_0.float_3;
						num2 = @class.altBand_0.float_2;
						break;
					case ActiveUnit.Throttle.Full:
						if (@class.altBand_0.nullable_0 != null)
						{
							float? num3 = engine_1.altBand_0[0].nullable_2;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() > 0f) : null).GetValueOrDefault())
							{
								num = @class.altBand_0.nullable_2.Value;
								float num4 = (float)@class.altBand_0.nullable_0.Value;
								num2 = @class.altBand_0.float_3;
								break;
							}
						}
						return this.method_167(ActiveUnit.Throttle.Cruise, altBand_0, nullable_17, nullable_18, engine_1, int_11);
					case ActiveUnit.Throttle.Flank:
						if (@class.altBand_0.nullable_1 != null)
						{
							float? num3 = engine_1.altBand_0[0].nullable_3;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() > 0f) : null).GetValueOrDefault())
							{
								num = @class.altBand_0.nullable_3.Value;
								float num5 = (float)@class.altBand_0.nullable_1.Value;
								if (@class.altBand_0.nullable_0 != null)
								{
									num2 = @class.altBand_0.nullable_2.Value;
									break;
								}
								num2 = @class.altBand_0.float_3;
								break;
							}
						}
						return this.method_167(ActiveUnit.Throttle.Full, altBand_0, nullable_17, nullable_18, engine_1, int_11);
					default:
						return 0f;
					}
					float num6 = num;
					if (nullable_17 != null && nullable_18 != null)
					{
						float? num3;
						if (@class.altBand_0 != this.method_154().method_11(engine_1))
						{
							AltBand[] altBand_ = engine_1.altBand_0;
							if (altBand_.Length == 0)
							{
								return 0f;
							}
							AltBand altBand = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderBy<AltBand, float>(Enumerable.Where<AltBand>(altBand_, new Func<AltBand, bool>(@class.method_0)), (Submarine._Closure$__.$I128-1 == null) ? (Submarine._Closure$__.$I128-1 = new Func<AltBand, float>(Submarine._Closure$__.$I.method_8)) : Submarine._Closure$__.$I128-1), 0);
							float num7;
							float num8;
							switch (throttle_5)
							{
							case ActiveUnit.Throttle.FullStop:
								num7 = 0f;
								num8 = 0f;
								break;
							case ActiveUnit.Throttle.Loiter:
								num7 = altBand.float_2;
								num8 = 0f;
								break;
							case ActiveUnit.Throttle.Cruise:
								num7 = altBand.float_3;
								num8 = altBand.float_2;
								break;
							case ActiveUnit.Throttle.Full:
							{
								if (altBand.nullable_0 == null)
								{
									throw new Exception("Submarine has full throttle but no fuel consumption params exist in database!");
								}
								num7 = altBand.nullable_2.Value;
								float num9 = (float)altBand.nullable_0.Value;
								num8 = altBand.float_3;
								break;
							}
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
									num7 = num;
									num8 = num2;
								}
								break;
							default:
								return 0f;
							}
							if (num7 != num)
							{
								num3 = nullable_18;
								float float_ = @class.altBand_0.float_1;
								if (((num3 != null) ? new bool?(num3.GetValueOrDefault() != float_) : null).GetValueOrDefault())
								{
									float num11 = ((nullable_18 - @class.altBand_0.float_1) / (@class.altBand_0.float_0 - @class.altBand_0.float_1)).Value;
									num11 = Math.Abs(num11);
									num += (num7 - num) * num11;
									num6 = num;
									num2 += (num8 - num2) * num11;
								}
							}
						}
						float num12 = (float)this.method_154().method_17(nullable_18.Value, throttle_5, engine_1, int_11, false);
						num3 = nullable_17;
						if (((num3 != null) ? new bool?(num3.GetValueOrDefault() < num12) : null).GetValueOrDefault())
						{
							float num13 = (float)this.method_154().method_17(nullable_18.Value, (ActiveUnit.Throttle)(throttle_5 - ActiveUnit.Throttle.Loiter), engine_1, int_11, false);
							num3 = nullable_17;
							float num14;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() >= num13) : null).GetValueOrDefault())
							{
								num14 = ((nullable_17 - num13) / (num12 - num13)).Value;
								num14 = Math.Abs(num14);
							}
							else
							{
								num14 = 0f;
							}
							num6 = num2 + (num - num2) * num14;
						}
					}
					return num6 / 60f;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200349", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					return 0.001f;
				}
			}
			return 0f;
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00007D15 File Offset: 0x00005F15
		public float imethod_0()
		{
			return 0f;
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00007D15 File Offset: 0x00005F15
		public float imethod_1()
		{
			return 0f;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00003024 File Offset: 0x00001224
		public CargoType imethod_2()
		{
			return CargoType.NoCargo;
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00007D15 File Offset: 0x00005F15
		public float imethod_3()
		{
			return 0f;
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x001C6180 File Offset: 0x001C4380
		public long method_168(ActiveUnit.Throttle throttle_5, AltBand altBand_0, float? nullable_17, float? nullable_18, Engine engine_1, int int_11)
		{
			long maxValue;
			if (this.method_160())
			{
				maxValue = long.MaxValue;
			}
			else if (this.method_159())
			{
				maxValue = long.MaxValue;
			}
			else
			{
				if (this._SubmarineType_0 != Submarine._SubmarineType.Biologics)
				{
					if (this._SubmarineType_0 != Submarine._SubmarineType.FalseTarget)
					{
						List<FuelRec> list = new List<FuelRec>(this.vmethod_67().Length);
						foreach (FuelRec fuelRec in this.vmethod_67())
						{
							if (fuelRec._FuelType_0 == this.method_153().method_116(engine_1))
							{
								list.Add(fuelRec);
							}
						}
						int count = list.Count;
						if (count == 0)
						{
							return 0L;
						}
						FuelRec fuelRec2;
						if (count != 1)
						{
							fuelRec2 = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.OrderByDescending<FuelRec, float>(list, (Submarine._Closure$__.$I135-0 == null) ? (Submarine._Closure$__.$I135-0 = new Func<FuelRec, float>(Submarine._Closure$__.$I.method_9)) : Submarine._Closure$__.$I135-0), 0);
						}
						else
						{
							fuelRec2 = list[0];
						}
						if (throttle_5 == ActiveUnit.Throttle.FullStop)
						{
							return 2147483647L;
						}
						if (Information.IsNothing(fuelRec2))
						{
							return 0L;
						}
						float num = this.method_167(throttle_5, altBand_0, nullable_17, nullable_18, engine_1, int_11);
						if (num != 0f)
						{
							return (long)Math.Round((double)(fuelRec2.float_0 / num));
						}
						if (fuelRec2.float_0 == 0f)
						{
							return 0L;
						}
						return long.MaxValue;
					}
				}
				maxValue = long.MaxValue;
			}
			return maxValue;
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x001C6304 File Offset: 0x001C4504
		public bool method_169()
		{
			FuelRec[] fuelRec_ = this.fuelRec_0;
			checked
			{
				for (int i = 0; i < fuelRec_.Length; i++)
				{
					if (fuelRec_[i]._FuelType_0 == FuelRec._FuelType.AirIndepedent)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x000041ED File Offset: 0x000023ED
		public override bool vmethod_60()
		{
			return true;
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		public float imethod_4()
		{
			return this.float_28;
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x0000CCF8 File Offset: 0x0000AEF8
		public void imethod_5(float float_31)
		{
			this.float_28 = float_31;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x0000CD01 File Offset: 0x0000AF01
		public float imethod_6()
		{
			return this.float_29;
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0000CD09 File Offset: 0x0000AF09
		public void imethod_7(float float_31)
		{
			this.float_29 = float_31;
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x0000CD12 File Offset: 0x0000AF12
		public float imethod_8()
		{
			return this.float_30;
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x0000CD1A File Offset: 0x0000AF1A
		public void imethod_9(float float_31)
		{
			this.float_30 = float_31;
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x0000CD23 File Offset: 0x0000AF23
		public bool imethod_10()
		{
			return this._SubmarineType_0 == Submarine._SubmarineType.APSS;
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x001C6340 File Offset: 0x001C4540
		public override void vmethod_48(float float_31, bool bool_27)
		{
			if (this.vmethod_40() != 0f)
			{
				this.vmethod_33(this.vmethod_28(null));
				this.vmethod_35(this.vmethod_30(null));
				try
				{
					float num = base.method_48(float_31);
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
					if (this.vmethod_43())
					{
						bool flag = false;
						bool flag2 = true;
						bool flag3 = true;
						double double_ = num3;
						double double_2 = num2;
						int num4 = 0;
						bool bool_28 = false;
						bool bool_29 = false;
						bool bool_30 = true;
						bool bool_31 = true;
						float? nullable_ = null;
						short? nullable_2 = null;
						float float_32 = 0f;
						bool bool_32 = false;
						bool bool_33 = true;
						string text = "";
						List<ActiveUnit> list;
						if (this.vmethod_47(double_, double_2, ref num4, bool_28, bool_29, bool_30, ref flag2, bool_31, ref flag, nullable_, nullable_2, ref list, float_32, bool_32, bool_33, ref text, ref flag3))
						{
							this.vmethod_31(null, num3);
							this.vmethod_29(null, num2);
							if (this.scenario_0.MinuteIsChangingOnThisPulse)
							{
								this.method_152().nullable_1 = null;
							}
						}
						else if (!flag && !flag2)
						{
							double double_3 = this.vmethod_34();
							double double_4 = this.vmethod_32();
							num4 = 0;
							bool bool_34 = false;
							bool bool_35 = false;
							bool bool_36 = true;
							bool bool_37 = true;
							float? nullable_3 = null;
							short? nullable_4 = null;
							float float_33 = 0f;
							bool bool_38 = false;
							bool bool_39 = true;
							text = "";
							if (this.vmethod_47(double_3, double_4, ref num4, bool_34, bool_35, bool_36, ref flag2, bool_37, ref flag, nullable_3, nullable_4, ref list, float_33, bool_38, bool_39, ref text, ref flag3))
							{
								this.vmethod_10(base.method_52(this.vmethod_9(), num, false));
								Class411.smethod_1(this.vmethod_28(null), this.vmethod_30(null), ref num2, ref num3, (double)num, (double)this.vmethod_9());
								if (this.scenario_0.MinuteIsChangingOnThisPulse)
								{
									double double_5 = num3;
									double double_6 = num2;
									num4 = 0;
									bool bool_40 = false;
									bool bool_41 = false;
									bool bool_42 = true;
									bool flag4 = false;
									bool bool_43 = true;
									float? nullable_5 = null;
									short? nullable_6 = null;
									float float_34 = 0f;
									bool bool_44 = false;
									bool bool_45 = false;
									text = "";
									bool flag5 = false;
									double num5;
									double num6;
									if (!this.vmethod_47(double_5, double_6, ref num4, bool_40, bool_41, bool_42, ref flag4, bool_43, ref flag, nullable_5, nullable_6, ref list, float_34, bool_44, bool_45, ref text, ref flag5) && this.method_152().method_10(this.vmethod_30(null), this.vmethod_28(null), ref num5, ref num6, false, false, true, 0f, ref list, false))
									{
										num3 = num5;
										num2 = num6;
									}
									this.method_152().nullable_1 = null;
								}
							}
							else if (this.method_152().method_10(this.vmethod_30(null), this.vmethod_28(null), ref num3, ref num2, false, false, true, 0f, ref list, false))
							{
								this.method_152().nullable_1 = new float?(Math2.smethod_17(this.vmethod_30(null), this.vmethod_28(null), num3, num2));
								this.vmethod_10(this.method_152().nullable_1.Value);
							}
						}
						else
						{
							if (!this.scenario_0.MinuteIsChangingOnThisPulse && !Information.IsNothing(this.method_152().nullable_1))
							{
								this.vmethod_10(this.method_152().nullable_1.Value);
							}
							else
							{
								if (flag && this.method_152().method_44())
								{
									this.method_152().method_18();
								}
								double double_7;
								double double_8;
								if (this.method_152().method_10(num3, num2, ref double_7, ref double_8, false, false, true, 0f, ref list, false))
								{
									this.method_152().nullable_1 = new float?(Math2.smethod_17(this.vmethod_30(null), this.vmethod_28(null), double_7, double_8));
									this.vmethod_10(this.method_152().nullable_1.Value);
									this.method_152().vmethod_2();
								}
							}
							this.vmethod_31(null, num3);
							this.vmethod_29(null, num2);
						}
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
					if (!bool_27)
					{
						base.method_49(float_31);
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

		// Token: 0x0400161E RID: 5662
		public Submarine.Struct35 struct35_0;

		// Token: 0x0400161F RID: 5663
		public Class346 class346_0;

		// Token: 0x04001620 RID: 5664
		public Class347 class347_0;

		// Token: 0x04001621 RID: 5665
		public Class345 class345_0;

		// Token: 0x04001622 RID: 5666
		public Cargo cargo_1;

		// Token: 0x04001623 RID: 5667
		public Submarine.Enum120 enum120_0;

		// Token: 0x04001624 RID: 5668
		public Submarine._SubmarineType _SubmarineType_0;

		// Token: 0x04001625 RID: 5669
		public DockFacility.Enum50 enum50_0;

		// Token: 0x04001626 RID: 5670
		public int int_7;

		// Token: 0x04001627 RID: 5671
		public float float_25;

		// Token: 0x04001628 RID: 5672
		public float float_26;

		// Token: 0x04001629 RID: 5673
		public float float_27;

		// Token: 0x0400162A RID: 5674
		public short short_3;

		// Token: 0x0400162B RID: 5675
		private Dictionary<int, Engine> dictionary_0;

		// Token: 0x0400162C RID: 5676
		private Engine engine_0;

		// Token: 0x0400162D RID: 5677
		private int int_8;

		// Token: 0x0400162E RID: 5678
		private Class215 class215_0;

		// Token: 0x0400162F RID: 5679
		private Submarine_AI submarine_AI_0;

		// Token: 0x04001630 RID: 5680
		private Submarine_Kinematics submarine_Kinematics_0;

		// Token: 0x04001631 RID: 5681
		private Class222 class222_0;

		// Token: 0x04001632 RID: 5682
		private Submarine_Weaponry submarine_Weaponry_0;

		// Token: 0x04001633 RID: 5683
		private Class184 class184_0;

		// Token: 0x04001634 RID: 5684
		private Class187 class187_0;

		// Token: 0x04001635 RID: 5685
		private bool? nullable_16;

		// Token: 0x04001636 RID: 5686
		public static int int_9 = -40;

		// Token: 0x04001637 RID: 5687
		public static int int_10 = 10;

		// Token: 0x04001638 RID: 5688
		private float float_28;

		// Token: 0x04001639 RID: 5689
		private float float_29;

		// Token: 0x0400163A RID: 5690
		private float float_30;

		// Token: 0x02000347 RID: 839
		internal struct Struct35
		{
			// Token: 0x0400163B RID: 5691
			public bool bool_0;

			// Token: 0x0400163C RID: 5692
			public bool bool_1;

			// Token: 0x0400163D RID: 5693
			public bool bool_2;

			// Token: 0x0400163E RID: 5694
			public bool bool_3;

			// Token: 0x0400163F RID: 5695
			public bool bool_4;

			// Token: 0x04001640 RID: 5696
			public bool bool_5;

			// Token: 0x04001641 RID: 5697
			public bool bool_6;

			// Token: 0x04001642 RID: 5698
			public bool bool_7;

			// Token: 0x04001643 RID: 5699
			public bool bool_8;
		}

		// Token: 0x02000348 RID: 840
		internal enum Enum120
		{
			// Token: 0x04001645 RID: 5701
			const_0 = 1001,
			// Token: 0x04001646 RID: 5702
			const_1 = 2001,
			// Token: 0x04001647 RID: 5703
			const_2,
			// Token: 0x04001648 RID: 5704
			const_3
		}

		// Token: 0x02000349 RID: 841
		public enum _SubmarineType
		{
			// Token: 0x0400164A RID: 5706
			None = 1001,
			// Token: 0x0400164B RID: 5707
			AGSS = 2001,
			// Token: 0x0400164C RID: 5708
			APSS,
			// Token: 0x0400164D RID: 5709
			SS,
			// Token: 0x0400164E RID: 5710
			SSB,
			// Token: 0x0400164F RID: 5711
			SSBN,
			// Token: 0x04001650 RID: 5712
			SSG,
			// Token: 0x04001651 RID: 5713
			SSGN,
			// Token: 0x04001652 RID: 5714
			SSK,
			// Token: 0x04001653 RID: 5715
			SSM,
			// Token: 0x04001654 RID: 5716
			SSN,
			// Token: 0x04001655 RID: 5717
			SSP,
			// Token: 0x04001656 RID: 5718
			SSR,
			// Token: 0x04001657 RID: 5719
			SSRN,
			// Token: 0x04001658 RID: 5720
			SDV = 3001,
			// Token: 0x04001659 RID: 5721
			ROV = 4001,
			// Token: 0x0400165A RID: 5722
			UUV,
			// Token: 0x0400165B RID: 5723
			Biologics = 9001,
			// Token: 0x0400165C RID: 5724
			FalseTarget
		}

		// Token: 0x0200034B RID: 843
		[CompilerGenerated]
		internal sealed class Class372
		{
			// Token: 0x04001668 RID: 5736
			public bool bool_0;

			// Token: 0x04001669 RID: 5737
			public bool bool_1;

			// Token: 0x0400166A RID: 5738
			public bool bool_2;

			// Token: 0x0400166B RID: 5739
			public double double_0;

			// Token: 0x0400166C RID: 5740
			public double double_1;

			// Token: 0x0400166D RID: 5741
			public Submarine submarine_0;
		}

		// Token: 0x0200034C RID: 844
		[CompilerGenerated]
		internal sealed class Class373
		{
			// Token: 0x0600192B RID: 6443 RVA: 0x001C6804 File Offset: 0x001C4A04
			internal void method_0(string string_0, ParallelLoopState parallelLoopState_0)
			{
				UnguidedWeapon unguidedWeapon = null;
				this.class372_0.submarine_0.scenario_0.vmethod_20().TryGetValue(string_0, ref unguidedWeapon);
				if (!Information.IsNothing(unguidedWeapon) && unguidedWeapon.method_65())
				{
					short num = (short)this.class372_0.submarine_0.vmethod_132(unguidedWeapon.method_63(), this.class372_0.bool_0);
					if ((this.class372_0.bool_1 || (!this.class372_0.bool_2 && Math.Abs(unguidedWeapon.method_46(this.class372_0.submarine_0, true)) <= 45f)) && Math2.smethod_15(this.class372_0.double_0, this.class372_0.double_1, unguidedWeapon.vmethod_30(null), unguidedWeapon.vmethod_28(null)) * 1852f < (float)num)
					{
						this.bool_0 = true;
						parallelLoopState_0.Stop();
					}
				}
			}

			// Token: 0x0400166E RID: 5742
			public bool bool_0;

			// Token: 0x0400166F RID: 5743
			public Submarine.Class372 class372_0;
		}

		// Token: 0x0200034D RID: 845
		[CompilerGenerated]
		internal sealed class Class374
		{
			// Token: 0x0600192C RID: 6444 RVA: 0x0000CD91 File Offset: 0x0000AF91
			public Class374(Submarine.Class374 class374_0)
			{
				if (class374_0 != null)
				{
					this._FuelType_0 = class374_0._FuelType_0;
				}
			}

			// Token: 0x0600192D RID: 6445 RVA: 0x0000CDA8 File Offset: 0x0000AFA8
			internal bool method_0(FuelRec fuelRec_0)
			{
				return fuelRec_0._FuelType_0 == this._FuelType_0;
			}

			// Token: 0x04001670 RID: 5744
			public FuelRec._FuelType _FuelType_0;
		}

		// Token: 0x0200034E RID: 846
		[CompilerGenerated]
		internal sealed class Class375
		{
			// Token: 0x0600192F RID: 6447 RVA: 0x0000CDB8 File Offset: 0x0000AFB8
			internal bool method_0(FuelRec fuelRec_0)
			{
				return fuelRec_0._FuelType_0 == this._FuelType_0;
			}

			// Token: 0x04001671 RID: 5745
			public FuelRec._FuelType _FuelType_0;
		}

		// Token: 0x0200034F RID: 847
		[CompilerGenerated]
		internal sealed class Class376
		{
			// Token: 0x06001931 RID: 6449 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
			internal bool method_0(AltBand altBand_1)
			{
				return altBand_1.float_1 >= this.altBand_0.float_0;
			}

			// Token: 0x04001672 RID: 5746
			public AltBand altBand_0;
		}
	}
}
