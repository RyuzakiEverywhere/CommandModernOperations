using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns13;
using ns14;
using ns9;

namespace Command_Core
{
	// Token: 0x0200023C RID: 572
	public sealed class Facility : Class350, Interface3
	{
		// Token: 0x060011A3 RID: 4515 RVA: 0x0015E0AC File Offset: 0x0015C2AC
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			if (this.vmethod_7(false) != null)
			{
				try
				{
					xmlWriter_0.WriteStartElement("Facility");
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
						if (this.nullable_15 != null)
						{
							xmlWriter_0.WriteElementString("Prof", ((int)this.nullable_15.Value).ToString());
						}
						xmlWriter_0.WriteElementString("ThrottleSetting", ((byte)this.vmethod_84()).ToString());
						if (this.sensor_0.Length > 0)
						{
							xmlWriter_0.WriteStartElement("Sensors");
							foreach (Sensor sensor in this.sensor_0)
							{
								xmlWriter_0.WriteRaw(sensor.method_23(hashSet_0));
							}
							xmlWriter_0.WriteEndElement();
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
						if (Enumerable.Count<Magazine>(this.magazine_0) > 0)
						{
							xmlWriter_0.WriteStartElement("Magazines");
							foreach (Magazine magazine in this.magazine_0)
							{
								xmlWriter_0.WriteRaw(magazine.method_23(hashSet_0, this.scenario_0));
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
						if (base.method_92(null))
						{
							xmlWriter_0.WriteElementString("IsAD", base.method_92(null).ToString());
						}
						this.doctrine_0.method_282(ref xmlWriter_0, ref this.scenario_0, "Doctrine");
						xmlWriter_0.WriteStartElement("CIC");
						this.class345_0.method_23(ref xmlWriter_0, ref hashSet_0, this.scenario_0);
						xmlWriter_0.WriteEndElement();
						this.method_147().vmethod_0(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteStartElement("AI");
						if (this.method_148().activeUnit_0 == null)
						{
							this.method_148().activeUnit_0 = this;
						}
						this.method_148().vmethod_2(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Kinematics");
						this.method_149().vmethod_0(ref xmlWriter_0);
						xmlWriter_0.WriteEndElement();
						this.method_150().vmethod_2(ref xmlWriter_0);
						this.method_151().vmethod_2(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteStartElement("CommStuff");
						this.method_152().vmethod_0(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						this.method_153().vmethod_0(ref xmlWriter_0);
						if (this.vmethod_92() != null)
						{
							this.activeUnit_AirOps_0.vmethod_0(ref xmlWriter_0, ref hashSet_0);
						}
						if (this.vmethod_93() != null)
						{
							ActiveUnit_DockingOps.smethod_6(this.vmethod_93(), ref xmlWriter_0, ref hashSet_0);
						}
						xmlWriter_0.WriteEndElement();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100540", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
			}
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0015EBCC File Offset: 0x0015CDCC
		private Facility()
		{
			Scenario scenario = null;
			base..ctor(ref scenario, null);
			this.class345_0 = new Class345(this, "Command Post");
			this.cargo_1 = new Cargo(this);
			this.bool_8 = true;
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0015EC08 File Offset: 0x0015CE08
		public static List<Facility> smethod_10(List<Mount> list_3, Scenario scenario_1, Side side_1)
		{
			var enumerable = Enumerable.GroupBy(list_3, (Facility._Closure$__.$I21-0 == null) ? (Facility._Closure$__.$I21-0 = new Func<Mount, Facility._MobileUnitCategory>(Facility._Closure$__.$I.method_0)) : Facility._Closure$__.$I21-0, (Facility._Closure$__.$I21-1 == null) ? (Facility._Closure$__.$I21-1 = new Func<Mount, Mount>(Facility._Closure$__.$I.method_1)) : Facility._Closure$__.$I21-1, (Facility._Closure$__.$I21-2 == null) ? (Facility._Closure$__.$I21-2 = new Func<Facility._MobileUnitCategory, IEnumerable<Mount>, VB$AnonymousType_1<Facility._MobileUnitCategory, IEnumerable<Mount>>>(Facility._Closure$__.$I.method_2)) : Facility._Closure$__.$I21-2);
			List<Facility> list = new List<Facility>();
			checked
			{
				try
				{
					foreach (var vb$AnonymousType_ in enumerable)
					{
						string str = "";
						int facilityDBID;
						string str2;
						switch (vb$AnonymousType_.method_0())
						{
						case Facility._MobileUnitCategory.const_1:
							facilityDBID = 2987;
							str2 = "Inf";
							break;
						case Facility._MobileUnitCategory.const_2:
							facilityDBID = 2983;
							str2 = "Armor";
							break;
						case Facility._MobileUnitCategory.const_3:
							facilityDBID = 2985;
							str2 = "Arty";
							break;
						case Facility._MobileUnitCategory.const_4:
						case Facility._MobileUnitCategory.const_7:
						case Facility._MobileUnitCategory.const_8:
						case Facility._MobileUnitCategory.const_9:
						case Facility._MobileUnitCategory.const_10:
							goto IL_122;
						case Facility._MobileUnitCategory.const_5:
							facilityDBID = 2989;
							str2 = "AAA";
							break;
						case Facility._MobileUnitCategory.const_6:
							facilityDBID = 2988;
							str2 = "SAM";
							break;
						case Facility._MobileUnitCategory.const_11:
							facilityDBID = 2984;
							str2 = "Mech Inf";
							break;
						default:
							goto IL_122;
						}
						IL_140:
						Facility facility = null;
						facility = scenario_1.method_76(side_1, facilityDBID, str + str2 + " #" + Conversions.ToString(scenario_1.UnitsAutoIncrement), 0.0, 0.0, true, Unit.Enum122.const_0, null);
						facility.vmethod_51().Clear();
						try
						{
							foreach (Mount mount in vb$AnonymousType_.method_1())
							{
								facility.vmethod_51().method_4(mount);
								mount.method_19(facility);
							}
						}
						finally
						{
							IEnumerator<Mount> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						Sensor[] array = facility.vmethod_96();
						for (int i = 0; i < array.Length; i++)
						{
							array[i].method_19(facility);
						}
						Class429.smethod_23(ref facility.magazine_0);
						list.Add(facility);
						continue;
						IL_122:
						facilityDBID = 2990;
						str2 = "Landed Detachment";
						goto IL_140;
					}
				}
				finally
				{
					var enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				return list;
			}
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0015EE6C File Offset: 0x0015D06C
		public static Facility smethod_11(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_1)
		{
			Facility facility;
			try
			{
				facility = Facility.smethod_12(ref xmlNode_0, ref dictionary_0, ref scenario_1, scenario_1.LoadStockUnits);
			}
			catch (Exception1 exception)
			{
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				dictionary_0.Remove(innerText);
				facility = Facility.smethod_12(ref xmlNode_0, ref dictionary_0, ref scenario_1, true);
				string text = "";
				if (facility.method_120())
				{
					text = "(member of group: [" + facility.vmethod_65(false).Name + "])";
				}
				scenario_1.LoadingNotices.Add(string.Concat(new string[]
				{
					"The following facility:[",
					facility.Name,
					"]",
					text,
					" failed to shallow-rebuild because of a component missing. The facility was instead deep-rebuilt, and instantiated in its pristine DB-stock condition. All customizations present in the facility's components (damaged components, weapon additions/removals etc. etc.) have been lost. Please re-apply any necessary customizations either manually or using an SBR script."
				}));
			}
			return facility;
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0015EF40 File Offset: 0x0015D140
		private static Facility smethod_12(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_1, bool bool_28)
		{
			Facility result;
			try
			{
				Facility facility = new Facility();
				facility.scenario_0 = scenario_1;
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					result = (Facility)dictionary_0[innerText];
				}
				else
				{
					facility.vmethod_0(innerText);
					if (xmlNode_0.ChildNodes.Count == 1)
					{
						scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
						result = facility;
					}
					else
					{
						dictionary_0.Add(facility.string_0, facility);
						int num = Conversions.ToInteger(Misc.smethod_44(xmlNode_0.ChildNodes, "DBID").InnerText);
						try
						{
							DBFunctions.smethod_57(ref scenario_1, ref facility, num, bool_28);
						}
						catch (Exception ex)
						{
							dictionary_0.Remove(facility.string_0);
							scenario_1.LoadingNotices.Add("Facility with Database ID " + Conversions.ToString(num) + " is missing from the database and has not been loaded.");
							return result;
						}
						if (bool_28)
						{
							facility.method_99(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						}
						if (!bool_28)
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
												if (Operators.CompareString(name, "Comms", false) != 0)
												{
													continue;
												}
												try
												{
													foreach (object obj2 in xmlNode.ChildNodes)
													{
														XmlNode xmlNode2 = (XmlNode)obj2;
														CommDevice commDevice = CommDevice.smethod_2(ref xmlNode2, ref dictionary_0, facility);
														facility.method_101(commDevice);
														commDevice.method_19(facility);
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
											if (Operators.CompareString(name, "OnboardCargo", false) != 0)
											{
												continue;
											}
											try
											{
												foreach (object obj3 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode3 = (XmlNode)obj3;
													Cargo cargo = Cargo.smethod_2(ref xmlNode3, ref dictionary_0, facility);
													Class429.smethod_6(ref facility.cargo_0, cargo);
													cargo.method_19(facility);
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
												foreach (object obj4 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode4 = (XmlNode)obj4;
													FuelRec fuelRec_ = FuelRec.smethod_0(ref xmlNode4, ref dictionary_0);
													Class429.smethod_19(ref facility.fuelRec_0, fuelRec_);
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
										if (Operators.CompareString(name, "DockFacilities", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj5 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode5 = (XmlNode)obj5;
												DockFacility dockFacility = DockFacility.smethod_2(ref xmlNode5, ref dictionary_0, ref scenario_1);
												facility.method_104(dockFacility);
												dockFacility.method_19(facility);
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
												foreach (object obj6 in xmlNode.ChildNodes)
												{
													Sensor sensor = Sensor.smethod_2((XmlNode)obj6, dictionary_0, facility);
													Class429.smethod_24(ref facility.sensor_0, sensor);
													sensor.method_19(facility);
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
										if (Operators.CompareString(name, "Propulsion", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj7 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode6 = (XmlNode)obj7;
												ActiveUnit activeUnit = facility;
												Engine engine = Engine.smethod_2(ref xmlNode6, ref dictionary_0, ref activeUnit);
												facility.vmethod_49().method_4(engine);
												engine.method_19(facility);
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
													facility.method_103(airFacility);
													airFacility.method_19(facility);
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
												facility.method_140(magazine);
												magazine.method_19(facility);
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
												Mount mount = Mount.smethod_6(ref xmlNode9, ref dictionary_0, facility);
												if (mount != null)
												{
													facility.vmethod_51().method_4(mount);
													mount.method_19(facility);
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
								if (num2 <= 1525674614U)
								{
									if (num2 <= 812114866U)
									{
										if (num2 <= 485784328U)
										{
											if (num2 > 273958740U)
											{
												if (num2 <= 392185441U)
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
														goto IL_C42;
													}
													else if (Operators.CompareString(name2, "DTN", false) != 0)
													{
														continue;
													}
												}
												else if (num2 != 429749699U)
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
														goto IL_18D5;
													}
													else
													{
														if (Operators.CompareString(name2, "SBPF_TF", false) == 0)
														{
															facility.bool_22 = Conversions.ToBoolean(xmlNode10.InnerText);
															continue;
														}
														continue;
													}
												}
												else if (Operators.CompareString(name2, "DesiredTurnRate_Navigation", false) != 0)
												{
													continue;
												}
												facility.vmethod_81((Waypoint.Enum81)Conversions.ToByte(xmlNode10.InnerText));
												continue;
											}
											if (num2 <= 263373746U)
											{
												if (num2 != 6222351U)
												{
													if (num2 != 263373746U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "FSBR", false) == 0)
													{
														facility._ActiveUnitFuelState_1 = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode10.InnerText);
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
														facility.vmethod_109((ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText));
													}
													else
													{
														facility.vmethod_109((ActiveUnit._ActiveUnitStatus)Enum.Parse(typeof(ActiveUnit._ActiveUnitStatus), xmlNode10.InnerText, true));
													}
													if (facility.vmethod_108() == (ActiveUnit._ActiveUnitStatus)9)
													{
														facility.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB);
														continue;
													}
													continue;
												}
											}
											else if (num2 != 266367750U)
											{
												if (num2 != 273958740U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "AMP_OC_Speed", false) == 0)
												{
													facility.float_16 = XmlConvert.ToSingle(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Name", false) == 0)
												{
													facility.Name = xmlNode10.InnerText;
													continue;
												}
												continue;
											}
										}
										else if (num2 <= 664498478U)
										{
											if (num2 <= 601166687U)
											{
												if (num2 != 506380204U)
												{
													if (num2 != 601166687U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "AI", false) != 0)
													{
														continue;
													}
												}
												else
												{
													if (Operators.CompareString(name2, "LatLR", false) == 0)
													{
														facility.method_57(new double?(XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", "."))));
														continue;
													}
													continue;
												}
											}
											else if (num2 != 634280640U)
											{
												if (num2 != 664498478U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "FuelState", false) == 0)
												{
													facility._ActiveUnitFuelState_0 = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode10.InnerText);
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
												goto IL_132A;
											}
										}
										else if (num2 <= 771216480U)
										{
											if (num2 != 751723973U)
											{
												if (num2 != 771216480U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Damage", false) != 0)
												{
													continue;
												}
												goto IL_14D0;
											}
											else
											{
												if (Operators.CompareString(name2, "DT", false) != 0)
												{
													continue;
												}
												goto IL_1621;
											}
										}
										else if (num2 != 788394383U)
										{
											if (num2 != 803760973U)
											{
												if (num2 != 812114866U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "COA", false) == 0)
												{
													facility.int_5 = Conversions.ToInteger(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "DamagePts", false) == 0 && !bool_28)
												{
													facility.vmethod_64(false, null, XmlConvert.ToSingle(xmlNode10.InnerText));
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "Kinematics", false) != 0)
											{
												continue;
											}
											goto IL_1879;
										}
									}
									else
									{
										if (num2 <= 1238311391U)
										{
											if (num2 <= 967155461U)
											{
												if (num2 <= 882606391U)
												{
													if (num2 != 825104384U)
													{
														if (num2 != 882606391U)
														{
															continue;
														}
														if (Operators.CompareString(name2, "AMP_OC_DAO", false) == 0)
														{
															facility.bool_18 = Conversions.ToBoolean(xmlNode10.InnerText);
															continue;
														}
														continue;
													}
													else
													{
														if (Operators.CompareString(name2, "OldDamagePercent", false) == 0)
														{
															facility.float_15 = XmlConvert.ToSingle(xmlNode10.InnerText);
															continue;
														}
														continue;
													}
												}
												else if (num2 != 892023141U)
												{
													if (num2 != 967155461U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "SBPF_ThrottleSetting", false) != 0)
													{
														continue;
													}
													string innerText2 = xmlNode10.InnerText;
													if (Operators.CompareString(innerText2, "FullStop", false) == 0)
													{
														facility.throttle_4 = ActiveUnit.Throttle.FullStop;
														continue;
													}
													if (Operators.CompareString(innerText2, "Loiter", false) == 0)
													{
														facility.throttle_4 = ActiveUnit.Throttle.Loiter;
														continue;
													}
													if (Operators.CompareString(innerText2, "Cruise", false) == 0)
													{
														facility.throttle_4 = ActiveUnit.Throttle.Cruise;
														continue;
													}
													if (Operators.CompareString(innerText2, "Full", false) == 0)
													{
														facility.throttle_4 = ActiveUnit.Throttle.Full;
														continue;
													}
													if (Operators.CompareString(innerText2, "Flank", false) != 0)
													{
														facility.throttle_4 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
														continue;
													}
													facility.throttle_4 = ActiveUnit.Throttle.Flank;
													continue;
												}
												else if (Operators.CompareString(name2, "DesiredHeading", false) != 0)
												{
													continue;
												}
											}
											else if (num2 <= 1156592502U)
											{
												if (num2 != 1087276353U)
												{
													if (num2 != 1156592502U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "SBR", false) == 0)
													{
														facility._ActiveUnitStatus_2 = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
														continue;
													}
													continue;
												}
												else if (Operators.CompareString(name2, "DH", false) != 0)
												{
													continue;
												}
											}
											else if (num2 != 1175569298U)
											{
												if (num2 != 1199570758U)
												{
													if (num2 != 1238311391U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "Facility_AI", false) == 0)
													{
														goto IL_C01;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Facility_Sensory", false) != 0)
													{
														continue;
													}
													goto IL_1224;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "ActiveUnit_AirOps", false) == 0)
												{
													goto IL_C42;
												}
												continue;
											}
											facility.vmethod_69(ActiveUnit.Enum28.const_0, XmlConvert.ToSingle(xmlNode10.InnerText));
											continue;
										}
										if (num2 <= 1339890663U)
										{
											if (num2 <= 1255847155U)
											{
												if (num2 != 1243601753U)
												{
													if (num2 != 1255847155U)
													{
														continue;
													}
													if (Operators.CompareString(name2, "ThrottleSetting", false) != 0)
													{
														continue;
													}
													string innerText3 = xmlNode10.InnerText;
													if (Operators.CompareString(innerText3, "FullStop", false) == 0)
													{
														facility.throttle_0 = ActiveUnit.Throttle.FullStop;
														continue;
													}
													if (Operators.CompareString(innerText3, "Loiter", false) == 0)
													{
														facility.throttle_0 = ActiveUnit.Throttle.Loiter;
														continue;
													}
													if (Operators.CompareString(innerText3, "Cruise", false) == 0)
													{
														facility.throttle_0 = ActiveUnit.Throttle.Cruise;
														continue;
													}
													if (Operators.CompareString(innerText3, "Full", false) == 0)
													{
														facility.throttle_0 = ActiveUnit.Throttle.Full;
														continue;
													}
													if (Operators.CompareString(innerText3, "Flank", false) != 0)
													{
														facility.throttle_0 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
														continue;
													}
													facility.throttle_0 = ActiveUnit.Throttle.Flank;
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Facility_CommStuff", false) != 0)
													{
														continue;
													}
													goto IL_1002;
												}
											}
											else
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
														foreach (object obj12 in xmlNode10.ChildNodes)
														{
															string innerText4 = ((XmlNode)obj12).InnerText;
															facility.list_0.Add(innerText4);
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
												if (Operators.CompareString(name2, "SBED_ThrottleSetting", false) != 0)
												{
													continue;
												}
												string innerText5 = xmlNode10.InnerText;
												if (Operators.CompareString(innerText5, "FullStop", false) == 0)
												{
													facility.throttle_2 = ActiveUnit.Throttle.FullStop;
													continue;
												}
												if (Operators.CompareString(innerText5, "Loiter", false) == 0)
												{
													facility.throttle_2 = ActiveUnit.Throttle.Loiter;
													continue;
												}
												if (Operators.CompareString(innerText5, "Cruise", false) == 0)
												{
													facility.throttle_2 = ActiveUnit.Throttle.Cruise;
													continue;
												}
												if (Operators.CompareString(innerText5, "Full", false) == 0)
												{
													facility.throttle_2 = ActiveUnit.Throttle.Full;
													continue;
												}
												if (Operators.CompareString(innerText5, "Flank", false) != 0)
												{
													facility.throttle_2 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
													continue;
												}
												facility.throttle_2 = ActiveUnit.Throttle.Flank;
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
													facility.vmethod_54(new GlobalVariables.ProficiencyLevel?((GlobalVariables.ProficiencyLevel)Conversions.ToInteger(xmlNode10.InnerText)));
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Doctrine", false) == 0)
												{
													facility.doctrine_0 = Doctrine.smethod_9(ref xmlNode10, facility);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 1476905714U)
										{
											if (num2 != 1488303767U)
											{
												if (num2 != 1525674614U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "DockingOps", false) != 0)
												{
													continue;
												}
												goto IL_14FA;
											}
											else
											{
												if (Operators.CompareString(name2, "SBEO_TF", false) == 0)
												{
													facility.bool_21 = Conversions.ToBoolean(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "WeaponState", false) == 0)
											{
												facility._ActiveUnitWeaponState_0 = (ActiveUnit._ActiveUnitWeaponState)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									IL_C01:
									Facility facility2 = facility;
									activeUnit = facility;
									facility2.class166_0 = Class166.smethod_1(ref xmlNode10, ref dictionary_0, ref activeUnit);
									continue;
									IL_C42:
									ActiveUnit activeUnit2 = facility;
									activeUnit = facility;
									activeUnit2.activeUnit_AirOps_0 = ActiveUnit_AirOps.smethod_0(ref xmlNode10, ref dictionary_0, ref activeUnit);
									continue;
								}
								if (num2 <= 3001749054U)
								{
									if (num2 <= 2247649009U)
									{
										if (num2 <= 1738278884U)
										{
											if (num2 <= 1708783731U)
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
													goto IL_164A;
												}
												else
												{
													if (Operators.CompareString(name2, "CommStuff", false) == 0)
													{
														goto IL_1002;
													}
													continue;
												}
											}
											else if (num2 != 1729717486U)
											{
												if (num2 != 1738278884U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "SBED_TF", false) == 0)
												{
													facility.bool_20 = Conversions.ToBoolean(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
											else if (Operators.CompareString(name2, "Longitude", false) != 0)
											{
												continue;
											}
										}
										else if (num2 <= 1953416793U)
										{
											if (num2 != 1836990821U)
											{
												if (num2 != 1953416793U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "AMP_OC_DSO", false) == 0)
												{
													facility.nullable_13 = new float?(XmlConvert.ToSingle(xmlNode10.InnerText));
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
												goto IL_1376;
											}
										}
										else if (num2 != 1992083866U)
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
													facility.string_4 = xmlNode11.InnerText;
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
												goto IL_18B2;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "Latitude_UnitEntersAreaCheck", false) == 0)
											{
												facility.vmethod_39(new double?(XmlConvert.ToDouble(xmlNode10.InnerText)));
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 2590053246U)
									{
										if (num2 <= 2496321123U)
										{
											if (num2 != 2323739590U)
											{
												if (num2 != 2496321123U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "RangeSymbols", false) != 0)
												{
													continue;
												}
												try
												{
													foreach (object obj13 in xmlNode10.ChildNodes)
													{
														RangeSymbol item = RangeSymbol.smethod_0((XmlNode)obj13, dictionary_0);
														facility.method_17().Add(item);
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
											if (Operators.CompareString(name2, "Sensory", false) == 0)
											{
												goto IL_1224;
											}
											continue;
										}
										else if (num2 != 2564648390U)
										{
											if (num2 != 2590053246U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "Side", false) == 0)
											{
												facility.string_7 = xmlNode10.InnerText;
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name2, "Lon", false) != 0)
										{
											continue;
										}
									}
									else if (num2 <= 2874698282U)
									{
										if (num2 != 2749693904U)
										{
											if (num2 != 2874698282U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "AssignedTaskPool", false) == 0 && xmlNode10.HasChildNodes)
											{
												XmlNode xmlNode12 = xmlNode10.ChildNodes[0];
												facility.string_5 = xmlNode12.InnerText;
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "DesiredSpeed", false) == 0)
											{
												goto IL_132A;
											}
											continue;
										}
									}
									else if (num2 != 2920208772U)
									{
										if (num2 != 2923116889U)
										{
											if (num2 != 3001749054U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "Lat", false) == 0)
											{
												goto IL_1376;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "SBR_ThrottleSetting", false) != 0)
											{
												continue;
											}
											string innerText6 = xmlNode10.InnerText;
											if (Operators.CompareString(innerText6, "FullStop", false) == 0)
											{
												facility.throttle_1 = ActiveUnit.Throttle.FullStop;
												continue;
											}
											if (Operators.CompareString(innerText6, "Loiter", false) == 0)
											{
												facility.throttle_1 = ActiveUnit.Throttle.Loiter;
												continue;
											}
											if (Operators.CompareString(innerText6, "Cruise", false) == 0)
											{
												facility.throttle_1 = ActiveUnit.Throttle.Cruise;
												continue;
											}
											if (Operators.CompareString(innerText6, "Full", false) == 0)
											{
												facility.throttle_1 = ActiveUnit.Throttle.Full;
												continue;
											}
											if (Operators.CompareString(innerText6, "Flank", false) != 0)
											{
												facility.throttle_1 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											facility.throttle_1 = ActiveUnit.Throttle.Flank;
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "Message", false) == 0)
										{
											facility.string_3 = xmlNode10.InnerText;
											continue;
										}
										continue;
									}
									facility.vmethod_29(null, XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", ".")));
									continue;
									IL_1376:
									facility.vmethod_31(null, XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", ".")));
									continue;
								}
								if (num2 <= 3370184216U)
								{
									if (num2 <= 3164489068U)
									{
										if (num2 <= 3139717856U)
										{
											if (num2 != 3020647921U)
											{
												if (num2 != 3139717856U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Facility_Damage", false) == 0)
												{
													goto IL_14D0;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "ActiveUnit_DockingOps", false) == 0)
												{
													goto IL_14FA;
												}
												continue;
											}
										}
										else if (num2 != 3162615902U)
										{
											if (num2 != 3164489068U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "AMP_OC", false) == 0)
											{
												facility.bool_17 = Conversions.ToBoolean(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name2, "Facility_Navigator", false) != 0)
										{
											continue;
										}
									}
									else if (num2 <= 3204468496U)
									{
										if (num2 != 3189373444U)
										{
											if (num2 != 3204468496U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "SBEO", false) == 0)
											{
												facility._ActiveUnitStatus_4 = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "LonLR", false) == 0)
											{
												facility.method_59(new double?(XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", "."))));
												continue;
											}
											continue;
										}
									}
									else if (num2 != 3251319825U)
									{
										if (num2 != 3283119613U)
										{
											if (num2 != 3370184216U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "DesiredTurnRate", false) == 0)
											{
												goto IL_1621;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "CurrentSpeed", false) == 0)
											{
												goto IL_164A;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "SBR_TF", false) == 0)
										{
											facility.bool_19 = Conversions.ToBoolean(xmlNode10.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num2 <= 3715915568U)
								{
									if (num2 <= 3533666526U)
									{
										if (num2 != 3389022305U)
										{
											if (num2 != 3533666526U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "Navigator", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "SBED", false) == 0)
											{
												facility._ActiveUnitStatus_3 = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (num2 != 3559367371U)
										{
											if (num2 != 3636905136U)
											{
												if (num2 != 3715915568U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Facility_Weaponry", false) != 0)
												{
													continue;
												}
											}
											else if (Operators.CompareString(name2, "Weaponry", false) != 0)
											{
												continue;
											}
											Facility facility3 = facility;
											activeUnit = facility;
											facility3.class226_0 = Class226.smethod_6(ref xmlNode10, ref dictionary_0, ref activeUnit);
											continue;
										}
										if (Operators.CompareString(name2, "SBEO_ThrottleSetting", false) != 0)
										{
											continue;
										}
										string innerText7 = xmlNode10.InnerText;
										if (Operators.CompareString(innerText7, "FullStop", false) == 0)
										{
											facility.throttle_3 = ActiveUnit.Throttle.FullStop;
											continue;
										}
										if (Operators.CompareString(innerText7, "Loiter", false) == 0)
										{
											facility.throttle_3 = ActiveUnit.Throttle.Loiter;
											continue;
										}
										if (Operators.CompareString(innerText7, "Cruise", false) == 0)
										{
											facility.throttle_3 = ActiveUnit.Throttle.Cruise;
											continue;
										}
										if (Operators.CompareString(innerText7, "Full", false) == 0)
										{
											facility.throttle_3 = ActiveUnit.Throttle.Full;
											continue;
										}
										if (Operators.CompareString(innerText7, "Flank", false) != 0)
										{
											facility.throttle_3 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
											continue;
										}
										facility.throttle_3 = ActiveUnit.Throttle.Flank;
										continue;
									}
								}
								else if (num2 <= 3736393060U)
								{
									if (num2 != 3726331919U)
									{
										if (num2 != 3736393060U)
										{
											continue;
										}
										if (Operators.CompareString(name2, "ParentGroup", false) == 0)
										{
											facility.string_6 = xmlNode10.InnerText;
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name2, "Facility_Kinematics", false) == 0)
										{
											goto IL_1879;
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
											goto IL_18B2;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name2, "IsAutoDetectable", false) == 0)
										{
											goto IL_18D5;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name2, "Longitude_UnitEntersAreaCheck", false) == 0)
									{
										facility.vmethod_37(new double?(XmlConvert.ToDouble(xmlNode10.InnerText)));
										continue;
									}
									continue;
								}
								Facility facility4 = facility;
								activeUnit = facility;
								facility4.class212_0 = Class212.smethod_8(ref xmlNode10, ref dictionary_0, ref activeUnit);
								continue;
								IL_164A:
								facility.vmethod_41(XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_18B2:
								facility.vmethod_10(XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_1002:
								Facility facility5 = facility;
								activeUnit = facility;
								facility5.class181_0 = Class181.smethod_1(ref xmlNode10, ref dictionary_0, ref activeUnit);
								continue;
								IL_1224:
								Facility facility6 = facility;
								activeUnit = facility;
								facility6.class219_0 = Class219.smethod_10(ref xmlNode10, ref dictionary_0, ref activeUnit);
								continue;
								IL_132A:
								facility.vmethod_71(XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_14D0:
								Facility facility7 = facility;
								activeUnit = facility;
								facility7.facility_Damage_0 = Facility_Damage.smethod_1(ref xmlNode10, ref dictionary_0, ref activeUnit);
								continue;
								IL_14FA:
								ActiveUnit activeUnit3 = facility;
								activeUnit = facility;
								activeUnit3.activeUnit_DockingOps_0 = ActiveUnit_DockingOps.smethod_7(ref xmlNode10, ref dictionary_0, ref activeUnit);
								continue;
								IL_1621:
								facility.vmethod_79((ActiveUnit.Enum28)Conversions.ToByte(xmlNode10.InnerText));
								continue;
								IL_1879:
								ActiveUnit_Kinematics.smethod_0(xmlNode10, dictionary_0, facility);
								continue;
								IL_18D5:
								facility.method_93(null, Conversions.ToBoolean(xmlNode10.InnerText));
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
						facility.vmethod_15(false, (float)facility.method_9(false, false, false));
						facility.method_134();
						result = facility;
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100541", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0000A447 File Offset: 0x00008647
		public override float vmethod_139()
		{
			return (float)this.double_4;
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00160A44 File Offset: 0x0015EC44
		public string method_142()
		{
			Facility._FacilityCategory facilityCategory_ = this._FacilityCategory_0;
			if (facilityCategory_ <= Facility._FacilityCategory.Underwater)
			{
				if (facilityCategory_ <= Facility._FacilityCategory.RunwayAccessPoint)
				{
					if (facilityCategory_ == Facility._FacilityCategory.None)
					{
						return "None";
					}
					switch (facilityCategory_)
					{
					case Facility._FacilityCategory.Runway:
						return "Runway";
					case Facility._FacilityCategory.RunwayGrade_Taxiway:
						return "Runway-Grade Taxiway";
					case Facility._FacilityCategory.RunwayAccessPoint:
						return "Runway Access Point";
					}
				}
				else
				{
					switch (facilityCategory_)
					{
					case Facility._FacilityCategory.Building_Surface:
						return "Building (Surface)";
					case Facility._FacilityCategory.Building_Reveted:
						return "Building (Reveted)";
					case Facility._FacilityCategory.Building_Bunker:
						return "Building (Bunker)";
					case Facility._FacilityCategory.Building_Underground:
						return "Building (Underground)";
					case Facility._FacilityCategory.Structure_Open:
						return "Structure (Open)";
					case Facility._FacilityCategory.Structure_Reveted:
						return "Structure (Reveted)";
					default:
						if (facilityCategory_ == Facility._FacilityCategory.Underwater)
						{
							return "Underwater";
						}
						break;
					}
				}
			}
			else if (facilityCategory_ <= Facility._FacilityCategory.Mobile_Personnel)
			{
				if (facilityCategory_ == Facility._FacilityCategory.Mobile_Vehicle)
				{
					return "Mobile Vehicle(s)";
				}
				if (facilityCategory_ == Facility._FacilityCategory.Mobile_Personnel)
				{
					return "Mobile Personnel";
				}
			}
			else
			{
				if (facilityCategory_ == Facility._FacilityCategory.AerostatMooring)
				{
					return "Aerostat Mooring";
				}
				if (facilityCategory_ == Facility._FacilityCategory.AirBase)
				{
					return "Air Base";
				}
			}
			return "None";
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x000041ED File Offset: 0x000023ED
		public override bool vmethod_43()
		{
			return true;
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0000A450 File Offset: 0x00008650
		public override GlobalVariables.ActiveUnitType vmethod_56()
		{
			return GlobalVariables.ActiveUnitType.Facility;
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00160B78 File Offset: 0x0015ED78
		public Facility._MobileUnitCategory method_143()
		{
			if (this.nullable_18 == null)
			{
				if (base.method_5())
				{
					this.nullable_18 = new Facility._MobileUnitCategory?(Facility._MobileUnitCategory.const_0);
				}
				else
				{
					this.nullable_18 = new Facility._MobileUnitCategory?(Facility.smethod_13(this.string_2, this.method_151().vmethod_4().Count));
				}
			}
			return this.nullable_18.Value;
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00160BDC File Offset: 0x0015EDDC
		public static Facility._MobileUnitCategory smethod_13(string string_9, int int_10)
		{
			string text = Misc.smethod_41(string_9);
			uint num = Class582.smethod_0(text);
			if (num <= 716611045U)
			{
				if (num <= 536261884U)
				{
					if (num != 108276744U)
					{
						if (num == 536261884U)
						{
							if (Operators.CompareString(text, "SAM", false) == 0)
							{
								return Facility._MobileUnitCategory.const_6;
							}
						}
					}
					else if (Operators.CompareString(text, "Inf", false) == 0)
					{
						return Facility._MobileUnitCategory.const_1;
					}
				}
				else if (num != 562859689U)
				{
					if (num == 716611045U)
					{
						if (Operators.CompareString(text, "Armored", false) == 0)
						{
							return Facility._MobileUnitCategory.const_2;
						}
					}
				}
				else if (Operators.CompareString(text, "Arty", false) == 0)
				{
					return Facility._MobileUnitCategory.const_3;
				}
			}
			else if (num <= 1267298235U)
			{
				if (num != 1142521834U)
				{
					if (num == 1267298235U)
					{
						if (Operators.CompareString(text, "Radar", false) == 0)
						{
							return Facility._MobileUnitCategory.const_9;
						}
					}
				}
				else if (Operators.CompareString(text, "SSM", false) == 0)
				{
					return Facility._MobileUnitCategory.const_4;
				}
			}
			else if (num != 3061902210U)
			{
				if (num == 3887666188U)
				{
					if (Operators.CompareString(text, "Mech", false) == 0)
					{
						return Facility._MobileUnitCategory.const_11;
					}
				}
			}
			else if (Operators.CompareString(text, "AAA", false) == 0)
			{
				return Facility._MobileUnitCategory.const_5;
			}
			Facility._MobileUnitCategory result;
			if (string_9.ToLower().Contains("truck"))
			{
				if (int_10 > 0)
				{
					result = Facility._MobileUnitCategory.const_10;
				}
				else
				{
					result = Facility._MobileUnitCategory.const_8;
				}
			}
			else
			{
				result = Facility._MobileUnitCategory.const_0;
			}
			return result;
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00160D2C File Offset: 0x0015EF2C
		public string method_144()
		{
			switch (this.method_143())
			{
			case Facility._MobileUnitCategory.const_0:
				return "None";
			case Facility._MobileUnitCategory.const_1:
				return "Infantry";
			case Facility._MobileUnitCategory.const_2:
				return "Armor";
			case Facility._MobileUnitCategory.const_3:
				return "Artillery";
			case Facility._MobileUnitCategory.const_4:
				return "Missile Artillery";
			case Facility._MobileUnitCategory.const_5:
				return "AAA";
			case Facility._MobileUnitCategory.const_6:
				return "SAM";
			case Facility._MobileUnitCategory.const_7:
				return "Engineer";
			case Facility._MobileUnitCategory.const_8:
				return "Supply";
			case Facility._MobileUnitCategory.const_9:
				return "Surveillance";
			case Facility._MobileUnitCategory.const_11:
				return "Mechanized Infantry";
			}
			throw new NotImplementedException();
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00160DD8 File Offset: 0x0015EFD8
		public bool method_145()
		{
			Facility._MobileUnitCategory mobileUnitCategory = this.method_143();
			if (mobileUnitCategory - Facility._MobileUnitCategory.const_3 > 3)
			{
				if (mobileUnitCategory != Facility._MobileUnitCategory.const_9)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00003024 File Offset: 0x00001224
		public override bool vmethod_97()
		{
			return false;
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00160E00 File Offset: 0x0015F000
		public override bool vmethod_105(ActiveUnit activeUnit_0)
		{
			return this.method_143() == Facility._MobileUnitCategory.const_8 && (activeUnit_0.bool_8 && !activeUnit_0.method_5());
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00160E34 File Offset: 0x0015F034
		public override ActiveUnit.Throttle vmethod_82()
		{
			ActiveUnit.Throttle result;
			if (base.method_5())
			{
				result = ActiveUnit.Throttle.FullStop;
			}
			else
			{
				result = ActiveUnit.Throttle.Flank;
			}
			return result;
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x000783F4 File Offset: 0x000765F4
		private CommDevice[] method_146()
		{
			CommDevice[] array = new CommDevice[this.commDevice_0.Length - 1 + 1];
			if (this.commDevice_0.Length > 0)
			{
				Array.Copy(this.commDevice_0, array, this.commDevice_0.Length);
			}
			return array;
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00160E50 File Offset: 0x0015F050
		public override CommDevice[] vmethod_94()
		{
			CommDevice[] result;
			try
			{
				if (!this.bool_27)
				{
					result = base.vmethod_94();
				}
				else
				{
					CommDevice[] array = null;
					int num = this.vmethod_51().Count - 1;
					for (int i = 0; i <= num; i++)
					{
						Mount mount = this.vmethod_51()[i];
						if (mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
						{
							int num2 = mount.commDevice_0.Length - 1;
							for (int j = 0; j <= num2; j++)
							{
								if (Information.IsNothing(array))
								{
									array = this.method_146();
								}
								CommDevice commDevice_ = mount.commDevice_0[j];
								Class429.smethod_9(ref array, commDevice_);
							}
						}
					}
					if (Information.IsNothing(array))
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
				ex.Data.Add("Error at 100542", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x0000A453 File Offset: 0x00008653
		public override int vmethod_11()
		{
			return this.int_7;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00160F44 File Offset: 0x0015F144
		public override int vmethod_12()
		{
			Facility._FacilityCategory facilityCategory_ = this._FacilityCategory_0;
			int result;
			if (facilityCategory_ <= Facility._FacilityCategory.Building_Underground)
			{
				if (facilityCategory_ != Facility._FacilityCategory.Building_Surface)
				{
					if (facilityCategory_ == Facility._FacilityCategory.Building_Underground)
					{
						return 0;
					}
				}
				else
				{
					switch (this.vmethod_121())
					{
					case GlobalVariables.TargetVisualSizeClass.Stealthy:
						return 1;
					case GlobalVariables.TargetVisualSizeClass.VSmall:
						return 4;
					case GlobalVariables.TargetVisualSizeClass.Small:
						return 6;
					case GlobalVariables.TargetVisualSizeClass.Medium:
						return 20;
					case GlobalVariables.TargetVisualSizeClass.Large:
						return 30;
					case GlobalVariables.TargetVisualSizeClass.VLarge:
						return 40;
					default:
						return result;
					}
				}
			}
			else
			{
				if (facilityCategory_ == Facility._FacilityCategory.Mobile_Vehicle)
				{
					return 4;
				}
				if (facilityCategory_ == Facility._FacilityCategory.Mobile_Personnel)
				{
					return 2;
				}
			}
			result = 0;
			return result;
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00160FD4 File Offset: 0x0015F1D4
		public Class212 method_147()
		{
			if (Information.IsNothing(this.class212_0))
			{
				ActiveUnit activeUnit = this;
				this.class212_0 = new Class212(ref activeUnit);
			}
			return this.class212_0;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00161004 File Offset: 0x0015F204
		public Class166 method_148()
		{
			if (Information.IsNothing(this.class166_0))
			{
				ActiveUnit activeUnit = this;
				this.class166_0 = new Class166(ref activeUnit);
			}
			return this.class166_0;
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00161034 File Offset: 0x0015F234
		public Class200 method_149()
		{
			if (Information.IsNothing(this.class200_0))
			{
				ActiveUnit activeUnit = this;
				this.class200_0 = new Class200(ref activeUnit);
			}
			return this.class200_0;
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00161064 File Offset: 0x0015F264
		public Class219 method_150()
		{
			if (Information.IsNothing(this.class219_0))
			{
				ActiveUnit activeUnit = this;
				this.class219_0 = new Class219(ref activeUnit);
			}
			return this.class219_0;
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00161094 File Offset: 0x0015F294
		public Class226 method_151()
		{
			if (Information.IsNothing(this.class226_0))
			{
				ActiveUnit activeUnit = this;
				this.class226_0 = new Class226(ref activeUnit);
			}
			return this.class226_0;
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x001610C4 File Offset: 0x0015F2C4
		public Class181 method_152()
		{
			if (Information.IsNothing(this.class181_0))
			{
				ActiveUnit activeUnit = this;
				this.class181_0 = new Class181(ref activeUnit);
			}
			return this.class181_0;
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x001610F4 File Offset: 0x0015F2F4
		public Facility_Damage method_153()
		{
			if (Information.IsNothing(this.facility_Damage_0))
			{
				ActiveUnit activeUnit = this;
				this.facility_Damage_0 = new Facility_Damage(ref activeUnit);
			}
			return this.facility_Damage_0;
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0000A45B File Offset: 0x0000865B
		public override bool vmethod_26()
		{
			if (this.nullable_16 == null)
			{
				this.nullable_16 = new bool?(base.vmethod_26());
			}
			return this.nullable_16.Value;
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0000A486 File Offset: 0x00008686
		public override bool vmethod_27()
		{
			if (this.nullable_17 == null)
			{
				this.nullable_17 = new bool?(base.vmethod_27());
			}
			return this.nullable_17.Value;
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00161124 File Offset: 0x0015F324
		public bool method_154()
		{
			Facility._FacilityCategory facilityCategory_ = this._FacilityCategory_0;
			return facilityCategory_ - Facility._FacilityCategory.Mobile_Vehicle <= 1;
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0016114C File Offset: 0x0015F34C
		public override GlobalVariables.TargetVisualSizeClass vmethod_121()
		{
			float num = this.vmethod_63(false, null);
			GlobalVariables.TargetVisualSizeClass result;
			if (num > 5000f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VLarge;
			}
			else if (num > 1000f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Large;
			}
			else if (num > 500f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Medium;
			}
			else if (num > 150f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Small;
			}
			else if (num > 30f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VSmall;
			}
			else
			{
				result = GlobalVariables.TargetVisualSizeClass.Stealthy;
			}
			return result;
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0000A4B1 File Offset: 0x000086B1
		public Facility(ref Scenario theScen, string theGUID = null) : base(ref theScen, theGUID)
		{
			this.class345_0 = new Class345(this, "Command Post");
			this.cargo_1 = new Cargo(this);
			this.bool_8 = true;
			base.method_134();
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0000A4E5 File Offset: 0x000086E5
		public override void vmethod_126(float float_26, ref Random random_0)
		{
			this.vmethod_93().method_22(float_26);
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x001611A4 File Offset: 0x0015F3A4
		public Mount method_155()
		{
			IEnumerable<Mount> enumerable = Enumerable.Where<Mount>(this.vmethod_51(), (Facility._Closure$__.$I81-0 == null) ? (Facility._Closure$__.$I81-0 = new Func<Mount, bool>(Facility._Closure$__.$I.method_3)) : Facility._Closure$__.$I81-0);
			Mount result;
			if (Enumerable.Count<Mount>(enumerable) > 0)
			{
				int num = GameGeneral.smethod_5().Next(0, Enumerable.Count<Mount>(enumerable));
				result = Enumerable.ElementAtOrDefault<Mount>(enumerable, num);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0016120C File Offset: 0x0015F40C
		public override bool vmethod_47(double double_5, double double_6, ref int int_10, bool bool_28, bool bool_29, bool bool_30, ref bool bool_31, bool bool_32, ref bool bool_33, float? nullable_19, short? nullable_20, ref List<ActiveUnit> list_3, float float_26, bool bool_34, bool bool_35, ref string string_9, ref bool bool_36)
		{
			bool result;
			try
			{
				int_10 = 1;
				if (!double.IsNaN(double_5) && !double.IsNaN(double_6))
				{
					if (bool_34 && this.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive && !Information.IsNothing(this.vmethod_101()) && this.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
					{
						Class343 @class = (Class343)this.vmethod_101();
						GeoPoint geoPoint = new GeoPoint(double_6, double_5);
						if (this.vmethod_46(@class.list_15, this.scenario_0, true) && !GeoPoint.smethod_4(geoPoint.imethod_2(), geoPoint.imethod_0(), @class.list_15, true))
						{
							bool_31 = false;
							bool_33 = false;
							string_9 = "The target has left the prosecution area.";
							return false;
						}
					}
					if (this.method_149().method_18(double_5, double_6) == 0)
					{
						result = false;
					}
					else
					{
						if (bool_35)
						{
							bool_31 = base.method_131();
						}
						if ((bool_31 || bool_28) && base.method_130(double_5, double_6, float_26))
						{
							bool_31 = true;
							bool_33 = false;
							string_9 = "The point is inside a No-Nav Zone.";
							result = false;
						}
						else if (!this.method_156(double_5, double_6, nullable_20))
						{
							bool_31 = false;
							bool_33 = false;
							string_9 = "The point is not accessible.";
							result = false;
						}
						else if ((double)Terrain.smethod_8(double_5, double_6, false) > 0.75)
						{
							result = false;
						}
						else
						{
							bool_31 = false;
							bool_33 = false;
							result = true;
						}
					}
				}
				else
				{
					bool_31 = false;
					bool_33 = false;
					string_9 = "Unknown.";
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200286", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				bool_31 = false;
				bool_33 = false;
				string_9 = "Error.";
				result = false;
			}
			return result;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x001613C4 File Offset: 0x0015F5C4
		private bool method_156(double theLat, double theLon, short? ProvidedElevation = null)
		{
			bool result;
			try
			{
				short num;
				if (Information.IsNothing(ProvidedElevation))
				{
					num = Terrain.smethod_7(theLat, theLon, false);
				}
				else
				{
					num = ProvidedElevation.Value;
				}
				result = (num >= 0);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100544", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0000A4F3 File Offset: 0x000086F3
		public override void vmethod_42(ref Scenario scenario_1, double double_5, double double_6)
		{
			base.vmethod_42(ref scenario_1, double_5, double_6);
			this.vmethod_15(false, (float)base.method_9(false, false, true));
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0000A50F File Offset: 0x0000870F
		public float imethod_0()
		{
			return Math.Max(1000f, (float)this.double_4);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0000A50F File Offset: 0x0000870F
		public float imethod_1()
		{
			return Math.Max(1000f, (float)this.double_4);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0000A522 File Offset: 0x00008722
		public CargoType imethod_2()
		{
			return CargoType.VLargeCargo;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0000A50F File Offset: 0x0000870F
		public float imethod_3()
		{
			return Math.Max(1000f, (float)this.double_4);
		}

		// Token: 0x04000C66 RID: 3174
		public GlobalVariables.ArmorRating armorRating_0;

		// Token: 0x04000C67 RID: 3175
		public Facility._FacilityCategory _FacilityCategory_0;

		// Token: 0x04000C68 RID: 3176
		public float float_25;

		// Token: 0x04000C69 RID: 3177
		public double double_4;

		// Token: 0x04000C6A RID: 3178
		public int int_7;

		// Token: 0x04000C6B RID: 3179
		public int int_8;

		// Token: 0x04000C6C RID: 3180
		public bool bool_27;

		// Token: 0x04000C6D RID: 3181
		public int int_9;

		// Token: 0x04000C6E RID: 3182
		public Class345 class345_0;

		// Token: 0x04000C6F RID: 3183
		public Cargo cargo_1;

		// Token: 0x04000C70 RID: 3184
		private Class212 class212_0;

		// Token: 0x04000C71 RID: 3185
		private Class166 class166_0;

		// Token: 0x04000C72 RID: 3186
		private Class200 class200_0;

		// Token: 0x04000C73 RID: 3187
		private Class219 class219_0;

		// Token: 0x04000C74 RID: 3188
		private Class226 class226_0;

		// Token: 0x04000C75 RID: 3189
		private Class181 class181_0;

		// Token: 0x04000C76 RID: 3190
		private Facility_Damage facility_Damage_0;

		// Token: 0x04000C77 RID: 3191
		private bool? nullable_16;

		// Token: 0x04000C78 RID: 3192
		private bool? nullable_17;

		// Token: 0x04000C79 RID: 3193
		private Facility._MobileUnitCategory? nullable_18;

		// Token: 0x0200023D RID: 573
		public enum _FacilityCategory : short
		{
			// Token: 0x04000C7B RID: 3195
			None = 1001,
			// Token: 0x04000C7C RID: 3196
			Runway = 2001,
			// Token: 0x04000C7D RID: 3197
			RunwayGrade_Taxiway,
			// Token: 0x04000C7E RID: 3198
			RunwayAccessPoint,
			// Token: 0x04000C7F RID: 3199
			Building_Surface = 3001,
			// Token: 0x04000C80 RID: 3200
			Building_Reveted,
			// Token: 0x04000C81 RID: 3201
			Building_Bunker,
			// Token: 0x04000C82 RID: 3202
			Building_Underground,
			// Token: 0x04000C83 RID: 3203
			Structure_Open,
			// Token: 0x04000C84 RID: 3204
			Structure_Reveted,
			// Token: 0x04000C85 RID: 3205
			Underwater = 4001,
			// Token: 0x04000C86 RID: 3206
			Mobile_Vehicle = 5001,
			// Token: 0x04000C87 RID: 3207
			Mobile_Personnel,
			// Token: 0x04000C88 RID: 3208
			AerostatMooring = 6001,
			// Token: 0x04000C89 RID: 3209
			AirBase = 9001
		}

		// Token: 0x0200023E RID: 574
		public enum _MobileUnitCategory : short
		{
			// Token: 0x04000C8B RID: 3211
			const_0,
			// Token: 0x04000C8C RID: 3212
			const_1,
			// Token: 0x04000C8D RID: 3213
			const_2,
			// Token: 0x04000C8E RID: 3214
			const_3,
			// Token: 0x04000C8F RID: 3215
			const_4,
			// Token: 0x04000C90 RID: 3216
			const_5,
			// Token: 0x04000C91 RID: 3217
			const_6,
			// Token: 0x04000C92 RID: 3218
			const_7,
			// Token: 0x04000C93 RID: 3219
			const_8,
			// Token: 0x04000C94 RID: 3220
			const_9,
			// Token: 0x04000C95 RID: 3221
			const_10,
			// Token: 0x04000C96 RID: 3222
			const_11
		}
	}
}
