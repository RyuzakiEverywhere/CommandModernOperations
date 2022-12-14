using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns13;
using ns14;

namespace Command_Core
{
	// Token: 0x020002F6 RID: 758
	public sealed class Satellite : Class350
	{
		// Token: 0x06001676 RID: 5750 RVA: 0x001A1E8C File Offset: 0x001A008C
		public Class201 method_142()
		{
			if (Information.IsNothing(this.class201_0))
			{
				ActiveUnit activeUnit = this;
				this.class201_0 = new Class201(ref activeUnit);
			}
			return this.class201_0;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x001A1EBC File Offset: 0x001A00BC
		public Class185 method_143()
		{
			if (Information.IsNothing(this.class185_0))
			{
				ActiveUnit activeUnit = this;
				this.class185_0 = new Class185(ref activeUnit);
			}
			return this.class185_0;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x0000BF28 File Offset: 0x0000A128
		public override float vmethod_139()
		{
			return this.float_13 * this.float_25;
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x001A1EEC File Offset: 0x001A00EC
		public bool method_144()
		{
			return this.method_142().method_17() < 40000000L && this.method_142().method_18() > 30000000L;
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x0000BF37 File Offset: 0x0000A137
		public Satellite(ref Scenario theScen, string theGUID = null) : base(ref theScen, theGUID)
		{
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x001A1F2C File Offset: 0x001A012C
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				if (!Information.IsNothing(this.vmethod_7(false)))
				{
					xmlWriter_0.WriteStartElement("Satellite");
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
						xmlWriter_0.WriteElementString("SID", this.string_9);
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
								List<string>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							xmlWriter_0.WriteEndElement();
						}
						xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
						if (!Information.IsNothing(this.class296_0))
						{
							xmlWriter_0.WriteStartElement("Anchor");
							xmlWriter_0.WriteElementString("Lon", XmlConvert.ToString(this.class296_0.double_0));
							xmlWriter_0.WriteElementString("Lat", XmlConvert.ToString(this.class296_0.double_1));
							xmlWriter_0.WriteElementString("Alt", XmlConvert.ToString(this.class296_0.float_0));
							xmlWriter_0.WriteEndElement();
						}
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
						if (this.vmethod_51().Count > 0)
						{
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
						}
						xmlWriter_0.WriteElementString("Status", ((byte)this.vmethod_108()).ToString());
						if (!Information.IsNothing(this.vmethod_101()))
						{
							xmlWriter_0.WriteElementString("AssignedMission", this.mission_0.string_0);
						}
						if (!Information.IsNothing(this.vmethod_103()))
						{
							xmlWriter_0.WriteElementString("AssignedTaskPool", this.mission_1.string_0);
						}
						if (!Information.IsNothing(this.vmethod_65(false)))
						{
							xmlWriter_0.WriteElementString("ParentGroup", this.group_0.string_0);
						}
						if (base.method_92(null))
						{
							xmlWriter_0.WriteElementString("IsAD", base.method_92(null).ToString());
						}
						this.doctrine_0.method_282(ref xmlWriter_0, ref this.scenario_0, "Doctrine");
						xmlWriter_0.WriteStartElement("ActiveUnit_AI");
						this.vmethod_86().vmethod_2(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("ActiveUnit_Sensory");
						this.vmethod_88().vmethod_2(ref xmlWriter_0);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("ActiveUnit_CommStuff");
						this.vmethod_90().vmethod_0(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteEndElement();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100753", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x001A24A0 File Offset: 0x001A06A0
		public static Satellite smethod_10(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_1)
		{
			Satellite satellite;
			try
			{
				satellite = Satellite.smethod_11(ref xmlNode_0, ref dictionary_0, ref scenario_1, scenario_1.LoadStockUnits);
			}
			catch (Exception1 exception)
			{
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				dictionary_0.Remove(innerText);
				satellite = Satellite.smethod_11(ref xmlNode_0, ref dictionary_0, ref scenario_1, true);
				string text = "";
				if (satellite.method_120())
				{
					text = "(member of group: [" + satellite.vmethod_65(false).Name + "])";
				}
				scenario_1.LoadingNotices.Add(string.Concat(new string[]
				{
					"The following satellite:[",
					satellite.Name,
					"]",
					text,
					" failed to shallow-rebuild because of a component missing. The satellite was instead deep-rebuilt, and instantiated in its pristine DB-stock condition. All customizations present in the satellite's components (damaged components, weapon additions/removals etc. etc.) have been lost. Please re-apply any necessary customizations either manually or using an SBR script."
				}));
			}
			return satellite;
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x001A2574 File Offset: 0x001A0774
		private static Satellite smethod_11(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_1, bool bool_27)
		{
			Satellite result;
			try
			{
				Satellite satellite = new Satellite(ref scenario_1, null);
				satellite.scenario_0 = scenario_1;
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					result = (Satellite)dictionary_0[innerText];
				}
				else
				{
					satellite.vmethod_0(innerText);
					if (xmlNode_0.ChildNodes.Count == 1)
					{
						scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
						result = satellite;
					}
					else
					{
						dictionary_0.Add(satellite.string_0, satellite);
						int num = Conversions.ToInteger(Misc.smethod_44(xmlNode_0.ChildNodes, "DBID").InnerText);
						int spacecraftNumber = Conversions.ToInteger(Misc.smethod_44(xmlNode_0.ChildNodes, "SID").InnerText.Split(new char[]
						{
							'_'
						})[1]);
						try
						{
							DBFunctions.smethod_74(ref scenario_1, ref satellite, num, spacecraftNumber, bool_27);
						}
						catch (Exception ex)
						{
							dictionary_0.Remove(satellite.string_0);
							scenario_1.LoadingNotices.Add("Satellite with Database ID " + Conversions.ToString(num) + " is missing from the database and has not been loaded.");
							return result;
						}
						if (bool_27)
						{
							satellite.method_99(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						}
						if (!bool_27)
						{
							try
							{
								foreach (object obj in xmlNode_0.ChildNodes)
								{
									XmlNode xmlNode = (XmlNode)obj;
									string name = xmlNode.Name;
									if (Operators.CompareString(name, "Sensors", false) != 0)
									{
										if (Operators.CompareString(name, "Comms", false) != 0)
										{
											if (Operators.CompareString(name, "Mounts", false) != 0)
											{
												continue;
											}
											try
											{
												foreach (object obj2 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode2 = (XmlNode)obj2;
													Mount mount = Mount.smethod_6(ref xmlNode2, ref dictionary_0, satellite);
													satellite.vmethod_51().method_4(mount);
													mount.method_19(satellite);
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
										try
										{
											foreach (object obj3 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode3 = (XmlNode)obj3;
												CommDevice commDevice = CommDevice.smethod_2(ref xmlNode3, ref dictionary_0, satellite);
												satellite.method_101(commDevice);
												commDevice.method_19(satellite);
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
									try
									{
										foreach (object obj4 in xmlNode.ChildNodes)
										{
											Sensor sensor = Sensor.smethod_2((XmlNode)obj4, dictionary_0, satellite);
											if (!sensor.method_98())
											{
												Class429.smethod_24(ref satellite.sensor_0, sensor);
												sensor.method_19(satellite);
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
							foreach (object obj5 in xmlNode_0.ChildNodes)
							{
								XmlNode xmlNode4 = (XmlNode)obj5;
								string name2 = xmlNode4.Name;
								uint num2 = Class582.smethod_0(name2);
								if (num2 <= 1992083866U)
								{
									if (num2 <= 597886640U)
									{
										if (num2 <= 266367750U)
										{
											if (num2 != 6222351U)
											{
												if (num2 != 266367750U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Name", false) == 0)
												{
													satellite.Name = xmlNode4.InnerText;
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
												if (Versioned.IsNumeric(xmlNode4.InnerText))
												{
													satellite.vmethod_109((ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode4.InnerText));
												}
												else
												{
													satellite.vmethod_109((ActiveUnit._ActiveUnitStatus)Enum.Parse(typeof(ActiveUnit._ActiveUnitStatus), xmlNode4.InnerText, true));
												}
												if (satellite.vmethod_108() == (ActiveUnit._ActiveUnitStatus)9)
												{
													satellite.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 485784328U)
										{
											if (num2 != 597886640U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "ActiveUnit_CommStuff", false) == 0)
											{
												ActiveUnit activeUnit = satellite;
												ActiveUnit activeUnit2 = satellite;
												activeUnit.activeUnit_CommStuff_0 = ActiveUnit_CommStuff.smethod_0(ref xmlNode4, ref dictionary_0, ref activeUnit2);
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name2, "IsAD", false) != 0)
										{
											continue;
										}
									}
									else if (num2 <= 1339890663U)
									{
										if (num2 != 812114866U)
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
												foreach (object obj6 in xmlNode4.ChildNodes)
												{
													string innerText2 = ((XmlNode)obj6).InnerText;
													satellite.list_0.Add(innerText2);
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
										if (Operators.CompareString(name2, "COA", false) == 0)
										{
											satellite.int_5 = Conversions.ToInteger(xmlNode4.InnerText);
											continue;
										}
										continue;
									}
									else if (num2 != 1406576475U)
									{
										if (num2 != 1493866095U)
										{
											if (num2 != 1992083866U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "Latitude_UnitEntersAreaCheck", false) == 0)
											{
												satellite.vmethod_39(new double?(XmlConvert.ToDouble(xmlNode4.InnerText)));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "SID", false) == 0)
											{
												satellite.string_9 = xmlNode4.InnerText;
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "ActiveUnit_Sensory", false) == 0)
										{
											ActiveUnit activeUnit3 = satellite;
											ActiveUnit activeUnit2 = satellite;
											activeUnit3.activeUnit_Sensory_0 = ActiveUnit_Sensory.smethod_1(ref xmlNode4, ref dictionary_0, ref activeUnit2);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (num2 <= 2874698282U)
									{
										if (num2 <= 2247649009U)
										{
											if (num2 != 2047910612U)
											{
												if (num2 != 2247649009U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "AssignedMission", false) == 0 && xmlNode4.HasChildNodes)
												{
													XmlNode xmlNode5 = xmlNode4.ChildNodes[0];
													satellite.string_4 = xmlNode5.InnerText;
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "ActiveUnit_AI", false) == 0)
												{
													ActiveUnit_AI.smethod_0(xmlNode4, dictionary_0, satellite);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 2496321123U)
										{
											if (num2 != 2590053246U)
											{
												if (num2 != 2874698282U)
												{
													continue;
												}
												if (Operators.CompareString(name2, "AssignedTaskPool", false) == 0 && xmlNode4.HasChildNodes)
												{
													XmlNode xmlNode6 = xmlNode4.ChildNodes[0];
													satellite.string_5 = xmlNode6.InnerText;
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Side", false) == 0)
												{
													satellite.string_7 = xmlNode4.InnerText;
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
												foreach (object obj7 in xmlNode4.ChildNodes)
												{
													RangeSymbol item = RangeSymbol.smethod_0((XmlNode)obj7, dictionary_0);
													satellite.method_17().Add(item);
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
									}
									if (num2 <= 3040892372U)
									{
										if (num2 != 2920208772U)
										{
											if (num2 != 3040892372U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "Anchor", false) != 0)
											{
												continue;
											}
											satellite.class296_0 = new Satellite.Class296();
											try
											{
												foreach (object obj8 in xmlNode4.ChildNodes)
												{
													XmlNode xmlNode7 = (XmlNode)obj8;
													string name3 = xmlNode7.Name;
													if (Operators.CompareString(name3, "Lon", false) != 0)
													{
														if (Operators.CompareString(name3, "Lat", false) != 0)
														{
															if (Operators.CompareString(name3, "Alt", false) == 0)
															{
																satellite.class296_0.float_0 = XmlConvert.ToSingle(xmlNode7.InnerText);
															}
														}
														else
														{
															satellite.class296_0.double_1 = XmlConvert.ToDouble(xmlNode7.InnerText);
														}
													}
													else
													{
														satellite.class296_0.double_0 = XmlConvert.ToDouble(xmlNode7.InnerText);
													}
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
										if (Operators.CompareString(name2, "Message", false) == 0)
										{
											satellite.string_3 = xmlNode4.InnerText;
											continue;
										}
										continue;
									}
									else if (num2 != 3736393060U)
									{
										if (num2 != 3792306253U)
										{
											if (num2 != 4080539297U)
											{
												continue;
											}
											if (Operators.CompareString(name2, "IsAutoDetectable", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "Longitude_UnitEntersAreaCheck", false) == 0)
											{
												satellite.vmethod_37(new double?(XmlConvert.ToDouble(xmlNode4.InnerText)));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "ParentGroup", false) == 0)
										{
											satellite.string_6 = xmlNode4.InnerText;
											continue;
										}
										continue;
									}
								}
								satellite.method_93(null, Conversions.ToBoolean(xmlNode4.InnerText));
							}
						}
						finally
						{
							IEnumerator enumerator5;
							if (enumerator5 is IDisposable)
							{
								(enumerator5 as IDisposable).Dispose();
							}
						}
						satellite.method_142().vmethod_46(1f, false, false, scenario_1.method_31());
						satellite.method_134();
						result = satellite;
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100754", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x000041ED File Offset: 0x000023ED
		public override bool vmethod_43()
		{
			return true;
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x0000BF41 File Offset: 0x0000A141
		public override GlobalVariables.ActiveUnitType vmethod_56()
		{
			return GlobalVariables.ActiveUnitType.Satellite;
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x001A2F9C File Offset: 0x001A119C
		public override bool vmethod_127()
		{
			return DateTime.Compare(this.scenario_0.method_31(), this.dateTime_0) >= 0 && (DateTime.Compare(this.scenario_0.method_31(), this.dateTime_1) <= 0 || DateTime.Compare(this.dateTime_1, new DateTime(1900, 1, 1)) <= 0);
		}

		// Token: 0x040013D4 RID: 5076
		public string string_9;

		// Token: 0x040013D5 RID: 5077
		public DateTime dateTime_0;

		// Token: 0x040013D6 RID: 5078
		public DateTime dateTime_1;

		// Token: 0x040013D7 RID: 5079
		public Satellite._SatelliteCategory _SatelliteCategory_0;

		// Token: 0x040013D8 RID: 5080
		public Satellite._SatelliteType _SatelliteType_0;

		// Token: 0x040013D9 RID: 5081
		public GlobalVariables.ArmorRating armorRating_0;

		// Token: 0x040013DA RID: 5082
		public double double_4;

		// Token: 0x040013DB RID: 5083
		public double double_5;

		// Token: 0x040013DC RID: 5084
		public double double_6;

		// Token: 0x040013DD RID: 5085
		public float float_25;

		// Token: 0x040013DE RID: 5086
		public float float_26;

		// Token: 0x040013DF RID: 5087
		public float float_27;

		// Token: 0x040013E0 RID: 5088
		public Satellite.Class296 class296_0;

		// Token: 0x040013E1 RID: 5089
		private Class201 class201_0;

		// Token: 0x040013E2 RID: 5090
		private Class185 class185_0;

		// Token: 0x020002F7 RID: 759
		public enum _SatelliteCategory
		{
			// Token: 0x040013E4 RID: 5092
			None = 1001,
			// Token: 0x040013E5 RID: 5093
			GeoStationary = 2001
		}

		// Token: 0x020002F8 RID: 760
		public enum _SatelliteType
		{
			// Token: 0x040013E7 RID: 5095
			None = 1001,
			// Token: 0x040013E8 RID: 5096
			IMGSAT = 2001,
			// Token: 0x040013E9 RID: 5097
			RORSAT,
			// Token: 0x040013EA RID: 5098
			EORSAT,
			// Token: 0x040013EB RID: 5099
			SIGINT,
			// Token: 0x040013EC RID: 5100
			ELINT,
			// Token: 0x040013ED RID: 5101
			NOSS,
			// Token: 0x040013EE RID: 5102
			MASINT
		}

		// Token: 0x020002F9 RID: 761
		internal sealed class Class296
		{
			// Token: 0x040013EF RID: 5103
			public double double_0;

			// Token: 0x040013F0 RID: 5104
			public double double_1;

			// Token: 0x040013F1 RID: 5105
			public float float_0;
		}
	}
}
