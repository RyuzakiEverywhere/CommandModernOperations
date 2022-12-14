using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns12;
using ns14;

namespace Command_Core
{
	// Token: 0x02000261 RID: 609
	public sealed class Waypoint : GeoPoint
	{
		// Token: 0x0600129A RID: 4762 RVA: 0x0000AA1B File Offset: 0x00008C1B
		public bool method_17()
		{
			return this.doctrine_0 != null;
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00169864 File Offset: 0x00167A64
		public Doctrine method_18()
		{
			if (this.doctrine_0 == null)
			{
				List<ActiveUnit> list = null;
				this.doctrine_0 = new Doctrine(this, ref list);
			}
			return this.doctrine_0;
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00169890 File Offset: 0x00167A90
		public void method_19(ref XmlWriter theWriter, ref HashSet<string> ObjectsAlreadySerialized = null)
		{
			try
			{
				theWriter.WriteStartElement("WPoint");
				theWriter.WriteElementString("ID", this.string_0);
				if (ObjectsAlreadySerialized != null)
				{
					if (ObjectsAlreadySerialized.Contains(this.string_0))
					{
						theWriter.WriteEndElement();
						return;
					}
					ObjectsAlreadySerialized.Add(this.string_0);
				}
				theWriter.WriteElementString("Lon", XmlConvert.ToString(base.imethod_0()));
				theWriter.WriteElementString("Lat", XmlConvert.ToString(base.imethod_2()));
				theWriter.WriteElementString("Alt", XmlConvert.ToString(base.imethod_4()));
				if (this.nullable_1 != null)
				{
					theWriter.WriteElementString("DesiredAltitude", this.nullable_1.ToString());
				}
				if (this.nullable_2 != null)
				{
					theWriter.WriteElementString("DesiredAltitude_TerrainFollowing", this.nullable_2.ToString());
				}
				if (this.nullable_0 != null)
				{
					theWriter.WriteElementString("DesiredSpeed", this.nullable_0.ToString());
				}
				theWriter.WriteElementString("Name", this.Name.ToString());
				XmlWriter xmlWriter = theWriter;
				string localName = "Creator";
				int num = (int)this.enum80_0;
				xmlWriter.WriteElementString(localName, num.ToString());
				XmlWriter xmlWriter2 = theWriter;
				string localName2 = "Type";
				num = (int)this.waypointType_0;
				xmlWriter2.WriteElementString(localName2, num.ToString());
				XmlWriter xmlWriter3 = theWriter;
				string localName3 = "Category";
				num = (int)this.enum79_0;
				xmlWriter3.WriteElementString(localName3, num.ToString());
				if (!string.IsNullOrEmpty(this.string_2))
				{
					theWriter.WriteElementString("Description", this.string_2.ToString());
				}
				theWriter.WriteElementString("ThrottlePreset", ((byte)this.method_35()).ToString());
				theWriter.WriteElementString("AltitudePreset", ((byte)this.method_31()).ToString());
				theWriter.WriteElementString("DepthPreset", ((byte)this.method_33()).ToString());
				XmlWriter xmlWriter4 = theWriter;
				string localName4 = "TurnRate";
				byte b = (byte)this.enum81_0;
				xmlWriter4.WriteElementString(localName4, b.ToString());
				if (this.bool_11)
				{
					theWriter.WriteElementString("IME", true.ToString());
				}
				theWriter.WriteElementString("TerrainFollowing", this.method_37().ToString());
				if (this.nullable_3 != null)
				{
					theWriter.WriteElementString("DSO", this.nullable_3.ToString());
				}
				theWriter.WriteElementString("DAO", this.bool_13.ToString());
				if (this.nullable_4 != null)
				{
					theWriter.WriteElementString("SprintDrift", this.nullable_4.ToString());
				}
				if (this.nullable_5 != null)
				{
					theWriter.WriteElementString("SprintDrift_AverageSpeed", this.nullable_5.Value.ToString());
				}
				if (this.nullable_6 != null)
				{
					theWriter.WriteElementString("AvoidCavitation", this.nullable_6.ToString());
				}
				if (this.nullable_7 != null)
				{
					theWriter.WriteElementString("Time_Zulu", this.nullable_7.Value.ToBinary().ToString());
				}
				if (this.nullable_8 != null)
				{
					theWriter.WriteElementString("Time_Zulu_Weapon", this.nullable_8.Value.ToBinary().ToString());
				}
				if (this.nullable_9 != null)
				{
					theWriter.WriteElementString("Time_Local", this.nullable_9.Value.ToBinary().ToString());
				}
				if (this.nullable_10 != null)
				{
					theWriter.WriteElementString("Time_Local_Weapon", this.nullable_10.Value.ToBinary().ToString());
				}
				XmlWriter xmlWriter5 = theWriter;
				string localName5 = "TimeOfDay";
				b = (byte)this.ttimeOfDayType_0;
				xmlWriter5.WriteElementString(localName5, b.ToString());
				XmlWriter xmlWriter6 = theWriter;
				string localName6 = "TimeFixed";
				num = (int)this.enum82_0;
				xmlWriter6.WriteElementString(localName6, num.ToString());
				XmlWriter xmlWriter7 = theWriter;
				string localName7 = "SpeedFixed";
				num = (int)this.enum82_1;
				xmlWriter7.WriteElementString(localName7, num.ToString());
				XmlWriter xmlWriter8 = theWriter;
				string localName8 = "FlightFormation";
				num = (int)this.enum83_0;
				xmlWriter8.WriteElementString(localName8, num.ToString());
				XmlWriter xmlWriter9 = theWriter;
				string localName9 = "SpeedAdjustmentToT";
				num = (int)this.enum84_0;
				xmlWriter9.WriteElementString(localName9, num.ToString());
				XmlWriter xmlWriter10 = theWriter;
				string localName10 = "TankerUsage";
				b = (byte)this.tankerMethod_0;
				xmlWriter10.WriteElementString(localName10, b.ToString());
				theWriter.WriteStartElement("TankerMissionList");
				try
				{
					foreach (Mission mission in this.list_1)
					{
						if (!Information.IsNothing(mission))
						{
							theWriter.WriteElementString("ID", mission.string_0);
						}
					}
				}
				finally
				{
					List<Mission>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				theWriter.WriteEndElement();
				theWriter.WriteElementString("MaxReceiversInQueuePerTanker_Airborne", this.int_0.ToString());
				theWriter.WriteElementString("TankerFollowsReceivers", this.bool_16.ToString());
				theWriter.WriteElementString("TankerFollowsReceivers_NumberOfWaypoints", this.int_2.ToString());
				theWriter.WriteElementString("Leg_FuelRequired", this.float_2.ToString());
				theWriter.WriteElementString("Leg_FuelRemaining", this.float_3.ToString());
				theWriter.WriteElementString("Leg_Time_Turn", this.float_5.ToString());
				theWriter.WriteElementString("Leg_Time_Straight", this.float_4.ToString());
				theWriter.WriteElementString("Leg_Time_Weapon", this.float_6.ToString());
				theWriter.WriteElementString("Leg_TotalTime", this.float_7.ToString());
				theWriter.WriteElementString("Leg_Time_ErrorMargin", this.float_8.ToString());
				theWriter.WriteElementString("Leg_Distance", this.float_9.ToString());
				theWriter.WriteElementString("Leg_TotalDistance", this.float_13.ToString());
				theWriter.WriteElementString("Hold_Time", this.float_24.ToString());
				theWriter.WriteElementString("Station_Time", this.float_25.ToString());
				theWriter.WriteElementString("SpacingManeuver_Time", this.float_26.ToString());
				if (!Information.IsNothing(this.list_2) && this.list_2.Count > 0)
				{
					theWriter.WriteStartElement("FlightplanPointsList");
					try
					{
						foreach (Waypoint.Class281 @class in this.list_2)
						{
							if (!Information.IsNothing(@class))
							{
								theWriter.WriteStartElement("FlightPlanSegment");
								theWriter.WriteElementString("StartLatitude", @class.double_0.ToString());
								theWriter.WriteElementString("StartLongitude", @class.double_1.ToString());
								theWriter.WriteElementString("EndLatitude", @class.double_2.ToString());
								theWriter.WriteElementString("EndLongitude", @class.double_3.ToString());
								theWriter.WriteEndElement();
							}
						}
					}
					finally
					{
						List<Waypoint.Class281>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					theWriter.WriteEndElement();
				}
				theWriter.WriteElementString("PreferredWeaponID", this.int_3.ToString());
				if (!string.IsNullOrEmpty(this.string_3))
				{
					theWriter.WriteElementString("PreferredWeaponName", this.string_3.ToString());
				}
				theWriter.WriteElementString("PreferredWeaponSpeed", this.float_28.ToString());
				theWriter.WriteElementString("PreferredWeaponAltitude", this.float_29.ToString());
				theWriter.WriteElementString("PreferredWeaponRange", this.float_30.ToString());
				if (!Information.IsNothing(this.waypoint_0))
				{
					theWriter.WriteStartElement("WP_LeadElementWingman");
					this.waypoint_0.method_19(ref theWriter, ref ObjectsAlreadySerialized);
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.waypoint_1))
				{
					theWriter.WriteStartElement("WP_SecondElement");
					this.waypoint_1.method_19(ref theWriter, ref ObjectsAlreadySerialized);
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.waypoint_2))
				{
					theWriter.WriteStartElement("WP_SecondElementWingman");
					this.waypoint_2.method_19(ref theWriter, ref ObjectsAlreadySerialized);
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.waypoint_3))
				{
					theWriter.WriteStartElement("WP_ThirdElement");
					this.waypoint_3.method_19(ref theWriter, ref ObjectsAlreadySerialized);
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.waypoint_4))
				{
					theWriter.WriteStartElement("WP_ThirdElementWingman");
					this.waypoint_4.method_19(ref theWriter, ref ObjectsAlreadySerialized);
					theWriter.WriteEndElement();
				}
				theWriter.WriteElementString("Leg_FuelRemaining_LeadElementWingman", this.float_14.ToString());
				theWriter.WriteElementString("Leg_FuelRemaining_SecondElement", this.float_15.ToString());
				theWriter.WriteElementString("Leg_FuelRemaining_SecondElementWingman", this.float_16.ToString());
				theWriter.WriteElementString("Leg_FuelRemaining_ThirdElement", this.float_17.ToString());
				theWriter.WriteElementString("Leg_FuelRemaining_ThirdElementWingman", this.float_18.ToString());
				theWriter.WriteElementString("Leg_TotalDistance_LeadElementWingman", this.float_19.ToString());
				theWriter.WriteElementString("Leg_TotalDistance_SecondElement", this.float_20.ToString());
				theWriter.WriteElementString("Leg_TotalDistance_SecondElementWingman", this.float_21.ToString());
				theWriter.WriteElementString("Leg_TotalDistance_ThirdElement", this.float_22.ToString());
				theWriter.WriteElementString("Leg_TotalDistance_ThirdElementWingman", this.float_23.ToString());
				XmlWriter xmlWriter11 = theWriter;
				string localName11 = "AttackMethod";
				num = (int)this.enum94_0;
				xmlWriter11.WriteElementString(localName11, num.ToString());
				theWriter.WriteElementString("AttackMethod_Time", this.float_27.ToString());
				if (!Information.IsNothing(this.geoPoint_0))
				{
					theWriter.WriteStartElement("RaceTrackHelperPoint");
					theWriter.WriteRaw(this.geoPoint_0.method_8(ObjectsAlreadySerialized));
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.doctrine_0))
				{
					Doctrine doctrine = this.doctrine_0;
					Scenario scenario = null;
					doctrine.method_282(ref theWriter, ref scenario, "Doctrine");
				}
				theWriter.WriteElementString("TargeteeringMethod", ((byte)this.enum105_0).ToString());
				if (!Information.IsNothing(this.list_3))
				{
					theWriter.WriteStartElement("TargeteeringList");
					try
					{
						foreach (Mission.Class288 expression in this.list_3)
						{
							if (!Information.IsNothing(expression))
							{
								Mission.Class288.smethod_0(ref theWriter, ref expression);
							}
						}
					}
					finally
					{
						List<Mission.Class288>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.list_4))
				{
					theWriter.WriteStartElement("TargeteeringList_LeadElementWingman");
					try
					{
						foreach (Mission.Class288 expression2 in this.list_4)
						{
							if (!Information.IsNothing(expression2))
							{
								Mission.Class288.smethod_0(ref theWriter, ref expression2);
							}
						}
					}
					finally
					{
						List<Mission.Class288>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.list_5))
				{
					theWriter.WriteStartElement("TargeteeringList_SecondElement");
					try
					{
						foreach (Mission.Class288 expression3 in this.list_5)
						{
							if (!Information.IsNothing(expression3))
							{
								Mission.Class288.smethod_0(ref theWriter, ref expression3);
							}
						}
					}
					finally
					{
						List<Mission.Class288>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.list_6))
				{
					theWriter.WriteStartElement("TargeteeringList_SecondElementWingman");
					try
					{
						foreach (Mission.Class288 expression4 in this.list_6)
						{
							if (!Information.IsNothing(expression4))
							{
								Mission.Class288.smethod_0(ref theWriter, ref expression4);
							}
						}
					}
					finally
					{
						List<Mission.Class288>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.list_7))
				{
					theWriter.WriteStartElement("TargeteeringList_ThirdElement");
					try
					{
						foreach (Mission.Class288 expression5 in this.list_7)
						{
							if (!Information.IsNothing(expression5))
							{
								Mission.Class288.smethod_0(ref theWriter, ref expression5);
							}
						}
					}
					finally
					{
						List<Mission.Class288>.Enumerator enumerator7;
						((IDisposable)enumerator7).Dispose();
					}
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.list_8))
				{
					theWriter.WriteStartElement("TargeteeringList_ThirdElementWingman");
					try
					{
						foreach (Mission.Class288 expression6 in this.list_8)
						{
							if (!Information.IsNothing(expression6))
							{
								Mission.Class288.smethod_0(ref theWriter, ref expression6);
							}
						}
					}
					finally
					{
						List<Mission.Class288>.Enumerator enumerator8;
						((IDisposable)enumerator8).Dispose();
					}
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.list_9))
				{
					theWriter.WriteStartElement("WeaponeeringList");
					try
					{
						foreach (Mission.Class289 expression7 in this.list_9)
						{
							if (!Information.IsNothing(expression7))
							{
								Mission.Class289.smethod_0(ref theWriter, ref ObjectsAlreadySerialized, ref expression7);
							}
						}
					}
					finally
					{
						List<Mission.Class289>.Enumerator enumerator9;
						((IDisposable)enumerator9).Dispose();
					}
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.list_10))
				{
					theWriter.WriteStartElement("WeaponeeringList_LeadElementWingman");
					try
					{
						foreach (Mission.Class289 expression8 in this.list_10)
						{
							if (!Information.IsNothing(expression8))
							{
								Mission.Class289.smethod_0(ref theWriter, ref ObjectsAlreadySerialized, ref expression8);
							}
						}
					}
					finally
					{
						List<Mission.Class289>.Enumerator enumerator10;
						((IDisposable)enumerator10).Dispose();
					}
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.list_11))
				{
					theWriter.WriteStartElement("WeaponeeringList_SecondElement");
					try
					{
						foreach (Mission.Class289 expression9 in this.list_11)
						{
							if (!Information.IsNothing(expression9))
							{
								Mission.Class289.smethod_0(ref theWriter, ref ObjectsAlreadySerialized, ref expression9);
							}
						}
					}
					finally
					{
						List<Mission.Class289>.Enumerator enumerator11;
						((IDisposable)enumerator11).Dispose();
					}
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.list_12))
				{
					theWriter.WriteStartElement("WeaponeeringList_SecondElementWingman");
					try
					{
						foreach (Mission.Class289 expression10 in this.list_12)
						{
							if (!Information.IsNothing(expression10))
							{
								Mission.Class289.smethod_0(ref theWriter, ref ObjectsAlreadySerialized, ref expression10);
							}
						}
					}
					finally
					{
						List<Mission.Class289>.Enumerator enumerator12;
						((IDisposable)enumerator12).Dispose();
					}
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.list_13))
				{
					theWriter.WriteStartElement("WeaponeeringList_ThirdElement");
					try
					{
						foreach (Mission.Class289 expression11 in this.list_13)
						{
							if (!Information.IsNothing(expression11))
							{
								Mission.Class289.smethod_0(ref theWriter, ref ObjectsAlreadySerialized, ref expression11);
							}
						}
					}
					finally
					{
						List<Mission.Class289>.Enumerator enumerator13;
						((IDisposable)enumerator13).Dispose();
					}
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.list_14))
				{
					theWriter.WriteStartElement("WeaponeeringList_ThirdElementWingman");
					try
					{
						foreach (Mission.Class289 expression12 in this.list_14)
						{
							if (!Information.IsNothing(expression12))
							{
								Mission.Class289.smethod_0(ref theWriter, ref ObjectsAlreadySerialized, ref expression12);
							}
						}
					}
					finally
					{
						List<Mission.Class289>.Enumerator enumerator14;
						((IDisposable)enumerator14).Dispose();
					}
					theWriter.WriteEndElement();
				}
				theWriter.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100587", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0016A8D8 File Offset: 0x00168AD8
		public static Waypoint smethod_13(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, Scenario scenario_0)
		{
			Waypoint result;
			try
			{
				Waypoint waypoint = new Waypoint();
				bool flag = false;
				bool flag2;
				bool flag3;
				bool flag4;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 2435049132U)
						{
							if (num <= 1422437055U)
							{
								if (num <= 268485832U)
								{
									if (num <= 180152164U)
									{
										if (num <= 143933886U)
										{
											if (num != 120541411U)
											{
												if (num != 143933886U)
												{
													continue;
												}
												if (Operators.CompareString(name, "TimeFixed", false) == 0)
												{
													waypoint.enum82_0 = (Waypoint.Enum82)Conversions.ToInteger(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "RaceTrackHelperPoint", false) != 0)
												{
													continue;
												}
												try
												{
													foreach (object obj2 in xmlNode.ChildNodes)
													{
														XmlNode xmlNode2 = (XmlNode)obj2;
														waypoint.geoPoint_0 = GeoPoint.smethod_0(ref xmlNode2, ref dictionary_0);
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
										if (num != 154738112U)
										{
											if (num != 166317542U)
											{
												if (num != 180152164U)
												{
													continue;
												}
												if (Operators.CompareString(name, "AttackMethod_Time", false) == 0)
												{
													waypoint.float_27 = Conversions.ToSingle(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "Leg_TotalDistance_SecondElement", false) == 0)
												{
													waypoint.float_20 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
													continue;
												}
												continue;
											}
										}
										else if (Operators.CompareString(name, "DesiredSpeedOverride", false) != 0)
										{
											continue;
										}
									}
									else if (num <= 264494932U)
									{
										if (num != 208007272U)
										{
											if (num != 237427752U)
											{
												if (num != 264494932U)
												{
													continue;
												}
												if (Operators.CompareString(name, "TargeteeringList", false) != 0)
												{
													continue;
												}
												waypoint.list_3 = new List<Mission.Class288>();
												try
												{
													foreach (object obj3 in xmlNode.ChildNodes)
													{
														XmlNode xmlNode3 = (XmlNode)obj3;
														Mission.Class288 item = Mission.Class288.smethod_1(ref xmlNode3);
														waypoint.list_3.Add(item);
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
											if (Operators.CompareString(name, "TurnRate", false) == 0)
											{
												waypoint.enum81_0 = (Waypoint.Enum81)Conversions.ToByte(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Leg_FuelRemaining", false) == 0)
											{
												waypoint.float_3 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
									}
									else if (num != 266367750U)
									{
										if (num != 267447700U)
										{
											if (num != 268485832U)
											{
												continue;
											}
											if (Operators.CompareString(name, "WP_ThirdElement", false) != 0)
											{
												continue;
											}
											try
											{
												foreach (object obj4 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode4 = (XmlNode)obj4;
													waypoint.waypoint_3 = Waypoint.smethod_13(ref xmlNode4, ref dictionary_0, scenario_0);
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
										if (Operators.CompareString(name, "Time_Local", false) == 0)
										{
											DateTime value = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
											waypoint.nullable_9 = new DateTime?(value);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Name", false) == 0)
										{
											waypoint.Name = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else if (num <= 801598975U)
								{
									if (num <= 477337531U)
									{
										if (num != 316182301U)
										{
											if (num != 358035835U)
											{
												if (num != 477337531U)
												{
													continue;
												}
												if (Operators.CompareString(name, "FlightplanPointsList", false) != 0)
												{
													continue;
												}
												waypoint.list_2 = new List<Waypoint.Class281>();
												try
												{
													foreach (object obj5 in xmlNode.ChildNodes)
													{
														XmlNode xmlNode5 = (XmlNode)obj5;
														Waypoint.Class281 @class = new Waypoint.Class281();
														try
														{
															foreach (object obj6 in xmlNode5.ChildNodes)
															{
																XmlNode xmlNode6 = (XmlNode)obj6;
																string name2 = xmlNode6.Name;
																if (Operators.CompareString(name2, "StartLatitude", false) != 0)
																{
																	if (Operators.CompareString(name2, "StartLongitude", false) != 0)
																	{
																		if (Operators.CompareString(name2, "EndLatitude", false) != 0)
																		{
																			if (Operators.CompareString(name2, "EndLongitude", false) == 0)
																			{
																				@class.double_3 = XmlConvert.ToDouble(xmlNode6.InnerText.Replace(",", "."));
																			}
																		}
																		else
																		{
																			@class.double_2 = XmlConvert.ToDouble(xmlNode6.InnerText.Replace(",", "."));
																		}
																	}
																	else
																	{
																		@class.double_1 = XmlConvert.ToDouble(xmlNode6.InnerText.Replace(",", "."));
																	}
																}
																else
																{
																	@class.double_0 = XmlConvert.ToDouble(xmlNode6.InnerText.Replace(",", "."));
																}
															}
														}
														finally
														{
															IEnumerator enumerator6;
															if (enumerator6 is IDisposable)
															{
																(enumerator6 as IDisposable).Dispose();
															}
														}
														waypoint.list_2.Add(@class);
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
											if (Operators.CompareString(name, "PreferredWeaponRange", false) == 0)
											{
												waypoint.float_30 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name, "DSO", false) != 0)
										{
											continue;
										}
									}
									else if (num != 486878757U)
									{
										if (num != 721363522U)
										{
											if (num != 801598975U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Leg_TotalDistance_SecondElementWingman", false) == 0)
											{
												waypoint.float_21 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "TankerMaxDistance_Airborne", false) == 0)
											{
												waypoint.int_1 = Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "Station_Time", false) == 0)
										{
											waypoint.float_25 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
								}
								else if (num <= 1009497207U)
								{
									if (num != 856023323U)
									{
										if (num != 946283062U)
										{
											if (num != 1009497207U)
											{
												continue;
											}
											if (Operators.CompareString(name, "SprintDrift_AverageSpeed", false) == 0)
											{
												waypoint.nullable_5 = new float?(Conversions.ToSingle(xmlNode.InnerText));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "SonarActive", false) == 0)
											{
												flag = true;
												flag2 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "DAO", false) != 0)
										{
											continue;
										}
										goto IL_144A;
									}
								}
								else
								{
									if (num != 1151347181U)
									{
										if (num != 1241645885U)
										{
											if (num != 1422437055U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Doctrine", false) == 0)
											{
												waypoint.doctrine_0 = Doctrine.smethod_9(ref xmlNode, waypoint);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "WeaponeeringList_LeadElementWingman", false) != 0)
											{
												continue;
											}
											waypoint.list_10 = new List<Mission.Class289>();
											try
											{
												foreach (object obj7 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode7 = (XmlNode)obj7;
													Mission.Class289 item2 = Mission.Class289.smethod_1(ref xmlNode7, ref scenario_0, ref dictionary_0);
													waypoint.list_10.Add(item2);
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
									if (Operators.CompareString(name, "TimeOfDay", false) != 0)
									{
										continue;
									}
									if (Operators.CompareString(xmlNode.InnerText, "", false) == 0)
									{
										waypoint.ttimeOfDayType_0 = Weather.TTimeOfDayType.const_0;
										continue;
									}
									waypoint.ttimeOfDayType_0 = (Weather.TTimeOfDayType)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								if (Operators.CompareString(xmlNode.InnerText, false.ToString(), false) == 0)
								{
									waypoint.nullable_3 = null;
									continue;
								}
								waypoint.nullable_3 = new float?(XmlConvert.ToSingle(xmlNode.InnerText));
								continue;
							}
							else if (num <= 1976795605U)
							{
								if (num <= 1749700877U)
								{
									if (num <= 1496416238U)
									{
										if (num != 1458105184U)
										{
											if (num != 1490777540U)
											{
												if (num != 1496416238U)
												{
													continue;
												}
												if (Operators.CompareString(name, "ECMActive", false) == 0)
												{
													flag = true;
													flag3 = Conversions.ToBoolean(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "Hold_Time", false) == 0)
												{
													waypoint.float_24 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "ID", false) != 0)
											{
												continue;
											}
											if (!dictionary_0.ContainsKey(xmlNode.InnerText))
											{
												waypoint.vmethod_0(xmlNode.InnerText);
												dictionary_0.Add(waypoint.string_0, waypoint);
												continue;
											}
											return (Waypoint)dictionary_0[xmlNode.InnerText];
										}
									}
									else if (num != 1574042996U)
									{
										if (num != 1725856265U)
										{
											if (num != 1749700877U)
											{
												continue;
											}
											if (Operators.CompareString(name, "PreferredWeaponName", false) == 0)
											{
												waypoint.string_3 = xmlNode.InnerText;
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Description", false) == 0)
											{
												waypoint.string_2 = xmlNode.InnerText;
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "Leg_FuelRemaining_SecondElementWingman", false) == 0)
										{
											waypoint.float_16 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (num <= 1873325951U)
									{
										if (num != 1793530741U)
										{
											if (num != 1810534098U)
											{
												if (num != 1873325951U)
												{
													continue;
												}
												if (Operators.CompareString(name, "Leg_FuelRemaining_SecondElement", false) == 0)
												{
													waypoint.float_15 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "Leg_Time_ErrorMargin", false) == 0)
												{
													waypoint.float_8 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "WeaponeeringList_ThirdElement", false) != 0)
											{
												continue;
											}
											waypoint.list_13 = new List<Mission.Class289>();
											try
											{
												foreach (object obj8 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode8 = (XmlNode)obj8;
													Mission.Class289 item3 = Mission.Class289.smethod_1(ref xmlNode8, ref scenario_0, ref dictionary_0);
													waypoint.list_13.Add(item3);
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
									}
									if (num != 1929998051U)
									{
										if (num != 1956989133U)
										{
											if (num != 1976795605U)
											{
												continue;
											}
											if (Operators.CompareString(name, "RadarActive", false) == 0)
											{
												flag = true;
												flag4 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Leg_TotalDistance_LeadElementWingman", false) == 0)
											{
												waypoint.float_19 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "Leg_TotalTime", false) == 0)
										{
											waypoint.float_7 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
								}
							}
							else
							{
								if (num <= 2108926454U)
								{
									if (num <= 2030470334U)
									{
										if (num != 1993028513U)
										{
											if (num != 2022647575U)
											{
												if (num != 2030470334U)
												{
													continue;
												}
												if (Operators.CompareString(name, "SpeedAdjustmentToT", false) == 0)
												{
													waypoint.enum84_0 = (Waypoint.Enum84)Conversions.ToInteger(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else if (Operators.CompareString(name, "Altitude", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "DepthPreset", false) == 0)
											{
												waypoint.method_34((ActiveUnit_AI.SubmarineDepthPreset)Conversions.ToByte(xmlNode.InnerText));
												continue;
											}
											continue;
										}
									}
									else if (num != 2066337159U)
									{
										if (num != 2108682236U)
										{
											if (num != 2108926454U)
											{
												continue;
											}
											if (Operators.CompareString(name, "TargeteeringList_LeadElementWingman", false) != 0)
											{
												continue;
											}
											waypoint.list_4 = new List<Mission.Class288>();
											try
											{
												foreach (object obj9 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode9 = (XmlNode)obj9;
													Mission.Class288 item4 = Mission.Class288.smethod_1(ref xmlNode9);
													waypoint.list_4.Add(item4);
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
										if (Operators.CompareString(name, "Alt", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "DesiredAltitude", false) != 0)
										{
											continue;
										}
										if (Operators.CompareString(xmlNode.InnerText, false.ToString(), false) == 0)
										{
											waypoint.nullable_1 = null;
											continue;
										}
										waypoint.nullable_1 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
									waypoint.imethod_5(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
									continue;
								}
								if (num <= 2399577799U)
								{
									if (num != 2254869984U)
									{
										if (num != 2297250623U)
										{
											if (num != 2399577799U)
											{
												continue;
											}
											if (Operators.CompareString(name, "SpacingManeuver_Time", false) == 0)
											{
												waypoint.float_26 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Time_Zulu", false) == 0)
											{
												DateTime value2 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
												waypoint.nullable_7 = new DateTime?(value2);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "TargeteeringList_SecondElementWingman", false) != 0)
										{
											continue;
										}
										waypoint.list_6 = new List<Mission.Class288>();
										try
										{
											foreach (object obj10 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode10 = (XmlNode)obj10;
												Mission.Class288 item5 = Mission.Class288.smethod_1(ref xmlNode10);
												waypoint.list_6.Add(item5);
											}
											continue;
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
								if (num != 2409420443U)
								{
									if (num != 2429363939U)
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
											foreach (object obj11 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode11 = (XmlNode)obj11;
												waypoint.list_0.Add(xmlNode11.InnerText);
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
									if (Operators.CompareString(name, "TargeteeringList_ThirdElementWingman", false) != 0)
									{
										continue;
									}
									waypoint.list_8 = new List<Mission.Class288>();
									try
									{
										foreach (object obj12 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode12 = (XmlNode)obj12;
											Mission.Class288 item6 = Mission.Class288.smethod_1(ref xmlNode12);
											waypoint.list_8.Add(item6);
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
								if (Operators.CompareString(name, "IsManualEditable", false) != 0)
								{
									continue;
								}
								goto IL_1739;
							}
						}
						else if (num <= 3363423173U)
						{
							if (num <= 2799261787U)
							{
								if (num <= 2600484162U)
								{
									if (num <= 2489793765U)
									{
										if (num != 2489335145U)
										{
											if (num != 2489793765U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Leg_FuelRequired", false) == 0)
											{
												waypoint.float_2 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Leg_TotalDistance", false) == 0)
											{
												waypoint.float_13 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
									}
									else if (num != 2527167325U)
									{
										if (num != 2564648390U)
										{
											if (num != 2600484162U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Leg_FuelRemaining_LeadElementWingman", false) == 0)
											{
												waypoint.float_14 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Lon", false) == 0)
											{
												waypoint.imethod_1(XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", ".")));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "TerrainFollowing", false) == 0)
										{
											waypoint.method_38(Conversions.ToBoolean(xmlNode.InnerText));
											continue;
										}
										continue;
									}
								}
								else if (num <= 2728089754U)
								{
									if (num != 2658629012U)
									{
										if (num != 2691982084U)
										{
											if (num != 2728089754U)
											{
												continue;
											}
											if (Operators.CompareString(name, "SpeedFixed", false) == 0)
											{
												waypoint.enum82_1 = (Waypoint.Enum82)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "DesiredAltitude_TerrainFollowing", false) != 0)
											{
												continue;
											}
											if (Operators.CompareString(xmlNode.InnerText, false.ToString(), false) == 0)
											{
												waypoint.nullable_2 = null;
												continue;
											}
											waypoint.nullable_2 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "Time_Zulu_Weapon", false) == 0)
										{
											DateTime value3 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
											waypoint.nullable_8 = new DateTime?(value3);
											continue;
										}
										continue;
									}
								}
								else if (num != 2746357952U)
								{
									if (num != 2749693904U)
									{
										if (num != 2799261787U)
										{
											continue;
										}
										if (Operators.CompareString(name, "TargeteeringList_SecondElement", false) != 0)
										{
											continue;
										}
										waypoint.list_5 = new List<Mission.Class288>();
										try
										{
											foreach (object obj13 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode13 = (XmlNode)obj13;
												Mission.Class288 item7 = Mission.Class288.smethod_1(ref xmlNode13);
												waypoint.list_5.Add(item7);
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
									if (Operators.CompareString(name, "DesiredSpeed", false) != 0)
									{
										continue;
									}
									if (Operators.CompareString(xmlNode.InnerText, false.ToString(), false) == 0)
									{
										waypoint.nullable_0 = null;
										continue;
									}
									waypoint.nullable_0 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "AltitudePreset", false) == 0)
									{
										waypoint.method_32((ActiveUnit_AI.AircraftAltitudePreset)Conversions.ToByte(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else if (num <= 3126726711U)
							{
								if (num <= 2969831622U)
								{
									if (num != 2894057133U)
									{
										if (num != 2947802513U)
										{
											if (num != 2969831622U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Leg_FuelRemaining_ThirdElement", false) == 0)
											{
												waypoint.float_17 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Category", false) == 0)
											{
												waypoint.enum79_0 = (Waypoint.Enum79)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "Time_Local_Weapon", false) == 0)
										{
											DateTime value4 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
											waypoint.nullable_10 = new DateTime?(value4);
											continue;
										}
										continue;
									}
								}
								else if (num != 3001749054U)
								{
									if (num != 3061425045U)
									{
										if (num != 3126726711U)
										{
											continue;
										}
										if (Operators.CompareString(name, "DesiredAltitudeOverride", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "TankerFollowsReceivers_NumberOfWaypoints", false) == 0)
										{
											waypoint.int_2 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "Lat", false) == 0)
									{
										waypoint.imethod_3(XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
									continue;
								}
							}
							else if (num <= 3257561969U)
							{
								if (num != 3196721555U)
								{
									if (num != 3201174890U)
									{
										if (num != 3257561969U)
										{
											continue;
										}
										if (Operators.CompareString(name, "PreferredWeaponSpeed", false) == 0)
										{
											waypoint.float_28 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Leg_Time_Weapon", false) == 0)
										{
											waypoint.float_6 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "PreferredWeaponID", false) == 0)
									{
										waypoint.int_3 = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (num != 3294118522U)
								{
									if (num != 3324946566U)
									{
										if (num != 3363423173U)
										{
											continue;
										}
										if (Operators.CompareString(name, "TargeteeringMethod", false) == 0)
										{
											waypoint.enum105_0 = (Mission.Enum105)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "WeaponeeringList_ThirdElementWingman", false) != 0)
										{
											continue;
										}
										waypoint.list_14 = new List<Mission.Class289>();
										try
										{
											foreach (object obj14 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode14 = (XmlNode)obj14;
												Mission.Class289 item8 = Mission.Class289.smethod_1(ref xmlNode14, ref scenario_0, ref dictionary_0);
												waypoint.list_14.Add(item8);
											}
											continue;
										}
										finally
										{
											IEnumerator enumerator14;
											if (enumerator14 is IDisposable)
											{
												(enumerator14 as IDisposable).Dispose();
											}
										}
									}
								}
								if (Operators.CompareString(name, "AvoidCavitation", false) == 0)
								{
									waypoint.nullable_6 = new bool?(Conversions.ToBoolean(xmlNode.InnerText));
									continue;
								}
								continue;
							}
						}
						else if (num <= 3802618614U)
						{
							if (num <= 3607250409U)
							{
								if (num <= 3386968880U)
								{
									if (num != 3377934495U)
									{
										if (num != 3384885066U)
										{
											if (num != 3386968880U)
											{
												continue;
											}
											if (Operators.CompareString(name, "WP_LeadElementWingman", false) != 0)
											{
												continue;
											}
											try
											{
												foreach (object obj15 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode15 = (XmlNode)obj15;
													waypoint.waypoint_0 = Waypoint.smethod_13(ref xmlNode15, ref dictionary_0, scenario_0);
												}
												continue;
											}
											finally
											{
												IEnumerator enumerator15;
												if (enumerator15 is IDisposable)
												{
													(enumerator15 as IDisposable).Dispose();
												}
											}
										}
										if (Operators.CompareString(name, "IME", false) == 0)
										{
											goto IL_1739;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Leg_FuelRemaining_ThirdElementWingman", false) == 0)
										{
											waypoint.float_18 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
								}
								else if (num != 3508596436U)
								{
									if (num != 3512062061U)
									{
										if (num != 3607250409U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Leg_Time_Turn", false) == 0)
										{
											waypoint.float_5 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Type", false) != 0)
										{
											continue;
										}
										if (Versioned.IsNumeric(xmlNode.InnerText))
										{
											waypoint.waypointType_0 = (Waypoint.WaypointType)Conversions.ToInteger(xmlNode.InnerText);
										}
										else
										{
											waypoint.waypointType_0 = (Waypoint.WaypointType)Enum.Parse(typeof(Waypoint.WaypointType), xmlNode.InnerText, true);
										}
										if (waypoint.waypointType_0 == Waypoint.WaypointType.Split)
										{
											waypoint.waypointType_0 = Waypoint.WaypointType.StrikeIngress;
											continue;
										}
										if (waypoint.waypointType_0 == Waypoint.WaypointType.Formate)
										{
											waypoint.waypointType_0 = Waypoint.WaypointType.StrikeEgress;
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "SprintDrift", false) == 0)
									{
										waypoint.nullable_4 = new bool?(Conversions.ToBoolean(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (num <= 3749943133U)
								{
									if (num != 3713590415U)
									{
										if (num != 3741050010U)
										{
											if (num != 3749943133U)
											{
												continue;
											}
											if (Operators.CompareString(name, "TankerUsage", false) == 0)
											{
												waypoint.tankerMethod_0 = (Mission.TankerMethod)Conversions.ToByte(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "FlightFormation", false) == 0)
											{
												waypoint.enum83_0 = (Waypoint.Enum83)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "WeaponeeringList_SecondElementWingman", false) != 0)
										{
											continue;
										}
										waypoint.list_12 = new List<Mission.Class289>();
										try
										{
											foreach (object obj16 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode16 = (XmlNode)obj16;
												Mission.Class289 item9 = Mission.Class289.smethod_1(ref xmlNode16, ref scenario_0, ref dictionary_0);
												waypoint.list_12.Add(item9);
											}
											continue;
										}
										finally
										{
											IEnumerator enumerator16;
											if (enumerator16 is IDisposable)
											{
												(enumerator16 as IDisposable).Dispose();
											}
										}
									}
								}
								if (num != 3752039926U)
								{
									if (num != 3784529633U)
									{
										if (num != 3802618614U)
										{
											continue;
										}
										if (Operators.CompareString(name, "TankerFollowsReceivers", false) == 0)
										{
											waypoint.bool_16 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "WP_SecondElement", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj17 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode17 = (XmlNode)obj17;
												waypoint.waypoint_1 = Waypoint.smethod_13(ref xmlNode17, ref dictionary_0, scenario_0);
											}
											continue;
										}
										finally
										{
											IEnumerator enumerator17;
											if (enumerator17 is IDisposable)
											{
												(enumerator17 as IDisposable).Dispose();
											}
										}
									}
								}
								if (Operators.CompareString(name, "Leg_TotalDistance_ThirdElementWingman", false) == 0)
								{
									waypoint.float_23 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
									continue;
								}
								continue;
							}
						}
						else
						{
							if (num <= 3997566245U)
							{
								if (num <= 3870665020U)
								{
									if (num != 3828591074U)
									{
										if (num != 3850654870U)
										{
											if (num != 3870665020U)
											{
												continue;
											}
											if (Operators.CompareString(name, "PreferredWeaponAltitude", false) == 0)
											{
												waypoint.float_29 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "ThrottlePreset", false) == 0)
											{
												waypoint.method_36((ActiveUnit_Kinematics.UnitThrottlePreset)Conversions.ToByte(xmlNode.InnerText));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "WP_SecondElementWingman", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj18 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode18 = (XmlNode)obj18;
												waypoint.waypoint_2 = Waypoint.smethod_13(ref xmlNode18, ref dictionary_0, scenario_0);
											}
											continue;
										}
										finally
										{
											IEnumerator enumerator18;
											if (enumerator18 is IDisposable)
											{
												(enumerator18 as IDisposable).Dispose();
											}
										}
									}
								}
								if (num != 3902552502U)
								{
									if (num != 3980133203U)
									{
										if (num != 3997566245U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Leg_TotalDistance_ThirdElement", false) == 0)
										{
											waypoint.float_22 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Leg_Distance", false) == 0)
										{
											waypoint.float_9 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "WeaponeeringList_SecondElement", false) != 0)
									{
										continue;
									}
									waypoint.list_11 = new List<Mission.Class289>();
									try
									{
										foreach (object obj19 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode19 = (XmlNode)obj19;
											Mission.Class289 item10 = Mission.Class289.smethod_1(ref xmlNode19, ref scenario_0, ref dictionary_0);
											waypoint.list_11.Add(item10);
										}
										continue;
									}
									finally
									{
										IEnumerator enumerator19;
										if (enumerator19 is IDisposable)
										{
											(enumerator19 as IDisposable).Dispose();
										}
									}
								}
							}
							if (num <= 4100651282U)
							{
								if (num != 4027044697U)
								{
									if (num != 4051376797U)
									{
										if (num != 4100651282U)
										{
											continue;
										}
										if (Operators.CompareString(name, "MaxReceiversInQueuePerTanker_Airborne", false) == 0)
										{
											waypoint.int_0 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "WP_ThirdElementWingman", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj20 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode20 = (XmlNode)obj20;
												waypoint.waypoint_4 = Waypoint.smethod_13(ref xmlNode20, ref dictionary_0, scenario_0);
											}
											continue;
										}
										finally
										{
											IEnumerator enumerator20;
											if (enumerator20 is IDisposable)
											{
												(enumerator20 as IDisposable).Dispose();
											}
										}
									}
								}
								if (Operators.CompareString(name, "WeaponeeringList", false) != 0)
								{
									continue;
								}
								waypoint.list_9 = new List<Mission.Class289>();
								try
								{
									foreach (object obj21 in xmlNode.ChildNodes)
									{
										XmlNode xmlNode21 = (XmlNode)obj21;
										Mission.Class289 item11 = Mission.Class289.smethod_1(ref xmlNode21, ref scenario_0, ref dictionary_0);
										waypoint.list_9.Add(item11);
									}
									continue;
								}
								finally
								{
									IEnumerator enumerator21;
									if (enumerator21 is IDisposable)
									{
										(enumerator21 as IDisposable).Dispose();
									}
								}
							}
							if (num != 4224686714U)
							{
								if (num != 4226137208U)
								{
									if (num != 4277317284U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Leg_Time_Straight", false) == 0)
									{
										waypoint.float_4 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "AttackMethod", false) == 0)
									{
										waypoint.enum94_0 = (Mission.Enum94)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "TargeteeringList_ThirdElement", false) == 0)
								{
									waypoint.list_7 = new List<Mission.Class288>();
									try
									{
										foreach (object obj22 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode22 = (XmlNode)obj22;
											Mission.Class288 item12 = Mission.Class288.smethod_1(ref xmlNode22);
											waypoint.list_7.Add(item12);
										}
									}
									finally
									{
										IEnumerator enumerator22;
										if (enumerator22 is IDisposable)
										{
											(enumerator22 as IDisposable).Dispose();
										}
									}
									continue;
								}
								continue;
							}
						}
						IL_144A:
						waypoint.bool_13 = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_1739:
						waypoint.bool_11 = true;
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
				if (waypoint.method_37() && Information.IsNothing(waypoint.nullable_2))
				{
					waypoint.nullable_2 = new float?(60.96f);
				}
				if (flag && waypoint.method_17())
				{
					Doctrine doctrine = waypoint.method_18();
					if (!Information.IsNothing(doctrine))
					{
						if (flag4)
						{
							doctrine.method_192(Doctrine.Class275.Enum66.const_1, scenario_0);
						}
						else
						{
							doctrine.method_192(Doctrine.Class275.Enum66.const_0, scenario_0);
						}
						if (flag2)
						{
							doctrine.method_193(Doctrine.Class275.Enum66.const_1, scenario_0);
						}
						else
						{
							doctrine.method_193(Doctrine.Class275.Enum66.const_0, scenario_0);
						}
						if (flag3)
						{
							doctrine.method_193(Doctrine.Class275.Enum66.const_1, scenario_0);
						}
						else
						{
							doctrine.method_193(Doctrine.Class275.Enum66.const_0, scenario_0);
						}
					}
				}
				result = waypoint;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100588", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Waypoint();
			}
			return result;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0016CAB4 File Offset: 0x0016ACB4
		public Waypoint()
		{
			this.unitThrottlePreset_0 = ActiveUnit_Kinematics.UnitThrottlePreset.None;
			this.aircraftAltitudePreset_0 = ActiveUnit_AI.AircraftAltitudePreset.None;
			this.submarineDepthPreset_0 = ActiveUnit_AI.SubmarineDepthPreset.None;
			this.float_24 = 0f;
			this.float_25 = 0f;
			this.float_26 = 0f;
			this.float_27 = 0f;
			this.enum94_0 = Mission.Enum94.const_0;
			this.list_0 = new List<string>();
			this.list_1 = new List<Mission>();
			this.int_0 = 0;
			this.int_1 = int.MaxValue;
			this.bool_16 = true;
			this.int_2 = 0;
			this.bool_10 = true;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0016CB4C File Offset: 0x0016AD4C
		public Waypoint(double double_2, double double_3, float float_31, Waypoint.WaypointType waypointType_1, Waypoint.Enum80 enum80_1, Waypoint.Enum79 enum79_1)
		{
			this.unitThrottlePreset_0 = ActiveUnit_Kinematics.UnitThrottlePreset.None;
			this.aircraftAltitudePreset_0 = ActiveUnit_AI.AircraftAltitudePreset.None;
			this.submarineDepthPreset_0 = ActiveUnit_AI.SubmarineDepthPreset.None;
			this.float_24 = 0f;
			this.float_25 = 0f;
			this.float_26 = 0f;
			this.float_27 = 0f;
			this.enum94_0 = Mission.Enum94.const_0;
			this.list_0 = new List<string>();
			this.list_1 = new List<Mission>();
			this.int_0 = 0;
			this.int_1 = int.MaxValue;
			this.bool_16 = true;
			this.int_2 = 0;
			this.bool_10 = true;
			base.imethod_1(double_2);
			base.imethod_3(double_3);
			base.imethod_5(float_31);
			this.waypointType_0 = waypointType_1;
			this.enum80_0 = enum80_1;
			this.enum79_0 = enum79_1;
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0016CC14 File Offset: 0x0016AE14
		public static Waypoint smethod_14(ref Scenario scenario_0, ref Waypoint waypoint_5, bool bool_17, bool bool_18, ref Doctrine doctrine_1)
		{
			return new Waypoint(ref scenario_0, waypoint_5.waypointType_0, waypoint_5.enum79_0, waypoint_5.string_2, waypoint_5.method_18(), waypoint_5.bool_11, waypoint_5.unitThrottlePreset_0, waypoint_5.aircraftAltitudePreset_0, waypoint_5.submarineDepthPreset_0, waypoint_5.nullable_0, waypoint_5.nullable_1, waypoint_5.nullable_3, waypoint_5.bool_13, waypoint_5.nullable_4, waypoint_5.nullable_5, waypoint_5.nullable_6, waypoint_5.Name, waypoint_5.imethod_0(), waypoint_5.imethod_2(), waypoint_5.imethod_4(), waypoint_5.enum80_0, waypoint_5.method_37(), waypoint_5.nullable_2, waypoint_5.nullable_7, waypoint_5.nullable_8, waypoint_5.nullable_9, waypoint_5.nullable_10, waypoint_5.ttimeOfDayType_0, waypoint_5.enum82_0, waypoint_5.enum82_1, waypoint_5.enum83_0, waypoint_5.enum84_0, waypoint_5.tankerMethod_0, waypoint_5.list_0, waypoint_5.list_1, waypoint_5.int_0, waypoint_5.int_1, waypoint_5.bool_16, waypoint_5.int_2, waypoint_5.float_2, waypoint_5.float_3, waypoint_5.float_4, waypoint_5.float_5, waypoint_5.float_6, waypoint_5.float_7, waypoint_5.float_8, waypoint_5.float_9, waypoint_5.float_13, waypoint_5.float_24, waypoint_5.float_25, waypoint_5.float_26, waypoint_5.float_10, waypoint_5.float_11, waypoint_5.float_12, waypoint_5.bool_14, waypoint_5.bool_15, waypoint_5.enum81_0, waypoint_5.list_2, waypoint_5.float_1, bool_17, waypoint_5.waypoint_0, waypoint_5.waypoint_1, waypoint_5.waypoint_2, waypoint_5.waypoint_3, waypoint_5.waypoint_4, waypoint_5.float_14, waypoint_5.float_15, waypoint_5.float_16, waypoint_5.float_17, waypoint_5.float_18, waypoint_5.float_19, waypoint_5.float_20, waypoint_5.float_21, waypoint_5.float_22, waypoint_5.float_23, waypoint_5.int_3, waypoint_5.string_3, waypoint_5.float_28, waypoint_5.float_29, waypoint_5.float_30, ref waypoint_5.geoPoint_0, bool_18, ref doctrine_1, waypoint_5.enum94_0, waypoint_5.float_27, waypoint_5.enum105_0, waypoint_5.list_3, waypoint_5.list_4, waypoint_5.list_5, waypoint_5.list_6, waypoint_5.list_7, waypoint_5.list_8, waypoint_5.list_9, waypoint_5.list_10, waypoint_5.list_11, waypoint_5.list_12, waypoint_5.list_13, waypoint_5.list_14);
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0016CEC0 File Offset: 0x0016B0C0
		public void method_20(ref Scenario scenario_0, ref Mission._FlightSize _FlightSize_0, ref Waypoint waypoint_5, ref Waypoint waypoint_6, bool bool_17)
		{
			try
			{
				if (!Information.IsNothing(waypoint_5) && !Information.IsNothing(waypoint_6))
				{
					bool flag = false;
					bool flag2 = false;
					bool flag3 = false;
					bool flag4 = false;
					bool flag5 = false;
					switch (_FlightSize_0)
					{
					case Mission._FlightSize.TwoAircraft:
						if (bool_17 || Information.IsNothing(this.waypoint_0))
						{
							this.waypoint_0 = new Waypoint();
							Waypoint waypoint = this;
							bool bool_18 = false;
							bool bool_19 = false;
							Doctrine doctrine = this.method_18();
							this.waypoint_0 = Waypoint.smethod_14(ref scenario_0, ref waypoint, bool_18, bool_19, ref doctrine);
							this.waypoint_0.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_0.enum82_0 = Waypoint.Enum82.const_0;
							flag = true;
						}
						this.waypoint_1 = null;
						this.waypoint_2 = null;
						this.waypoint_3 = null;
						this.waypoint_4 = null;
						break;
					case Mission._FlightSize.ThreeAircraft:
						if (bool_17 || Information.IsNothing(this.waypoint_0))
						{
							this.waypoint_0 = new Waypoint();
							Waypoint waypoint = this;
							bool bool_20 = false;
							bool bool_21 = false;
							Doctrine doctrine = this.method_18();
							this.waypoint_0 = Waypoint.smethod_14(ref scenario_0, ref waypoint, bool_20, bool_21, ref doctrine);
							this.waypoint_0.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_0.enum82_0 = Waypoint.Enum82.const_0;
							flag = true;
						}
						if (bool_17 || Information.IsNothing(this.waypoint_1))
						{
							this.waypoint_1 = new Waypoint();
							Waypoint waypoint = this;
							bool bool_22 = false;
							bool bool_23 = false;
							Doctrine doctrine = this.method_18();
							this.waypoint_1 = Waypoint.smethod_14(ref scenario_0, ref waypoint, bool_22, bool_23, ref doctrine);
							this.waypoint_1.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_1.enum82_0 = Waypoint.Enum82.const_0;
							flag2 = true;
						}
						this.waypoint_2 = null;
						this.waypoint_3 = null;
						this.waypoint_4 = null;
						break;
					case Mission._FlightSize.FourAircraft:
						if (bool_17 || Information.IsNothing(this.waypoint_0))
						{
							this.waypoint_0 = new Waypoint();
							Waypoint waypoint = this;
							bool bool_24 = false;
							bool bool_25 = false;
							Doctrine doctrine = this.method_18();
							this.waypoint_0 = Waypoint.smethod_14(ref scenario_0, ref waypoint, bool_24, bool_25, ref doctrine);
							this.waypoint_0.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_0.enum82_0 = Waypoint.Enum82.const_0;
							flag = true;
						}
						if (bool_17 || Information.IsNothing(this.waypoint_1))
						{
							this.waypoint_1 = new Waypoint();
							Waypoint waypoint = this;
							bool bool_26 = false;
							bool bool_27 = false;
							Doctrine doctrine = this.method_18();
							this.waypoint_1 = Waypoint.smethod_14(ref scenario_0, ref waypoint, bool_26, bool_27, ref doctrine);
							this.waypoint_1.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_1.enum82_0 = Waypoint.Enum82.const_0;
							flag2 = true;
						}
						if (bool_17 || Information.IsNothing(this.waypoint_2))
						{
							this.waypoint_2 = new Waypoint();
							Waypoint waypoint = this;
							bool bool_28 = false;
							bool bool_29 = false;
							Doctrine doctrine = this.method_18();
							this.waypoint_2 = Waypoint.smethod_14(ref scenario_0, ref waypoint, bool_28, bool_29, ref doctrine);
							this.waypoint_2.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_2.enum82_0 = Waypoint.Enum82.const_0;
							flag3 = true;
						}
						this.waypoint_3 = null;
						this.waypoint_4 = null;
						break;
					case Mission._FlightSize.SixAircraft:
						if (bool_17 || Information.IsNothing(this.waypoint_0))
						{
							this.waypoint_0 = new Waypoint();
							Waypoint waypoint = this;
							bool bool_30 = false;
							bool bool_31 = false;
							Doctrine doctrine = this.method_18();
							this.waypoint_0 = Waypoint.smethod_14(ref scenario_0, ref waypoint, bool_30, bool_31, ref doctrine);
							this.waypoint_0.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_0.enum82_0 = Waypoint.Enum82.const_0;
							flag = true;
						}
						if (bool_17 || Information.IsNothing(this.waypoint_1))
						{
							this.waypoint_1 = new Waypoint();
							Waypoint waypoint = this;
							bool bool_32 = false;
							bool bool_33 = false;
							Doctrine doctrine = this.method_18();
							this.waypoint_1 = Waypoint.smethod_14(ref scenario_0, ref waypoint, bool_32, bool_33, ref doctrine);
							this.waypoint_1.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_1.enum82_0 = Waypoint.Enum82.const_0;
							flag2 = true;
						}
						if (bool_17 || Information.IsNothing(this.waypoint_2))
						{
							this.waypoint_2 = new Waypoint();
							Waypoint waypoint = this;
							bool bool_34 = false;
							bool bool_35 = false;
							Doctrine doctrine = this.method_18();
							this.waypoint_2 = Waypoint.smethod_14(ref scenario_0, ref waypoint, bool_34, bool_35, ref doctrine);
							this.waypoint_2.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_2.enum82_0 = Waypoint.Enum82.const_0;
							flag3 = true;
						}
						if (bool_17 || Information.IsNothing(this.waypoint_3))
						{
							this.waypoint_3 = new Waypoint();
							Waypoint waypoint = this;
							bool bool_36 = false;
							bool bool_37 = false;
							Doctrine doctrine = this.method_18();
							this.waypoint_3 = Waypoint.smethod_14(ref scenario_0, ref waypoint, bool_36, bool_37, ref doctrine);
							this.waypoint_3.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_3.enum82_0 = Waypoint.Enum82.const_0;
							flag4 = true;
						}
						if (bool_17 || Information.IsNothing(this.waypoint_4))
						{
							this.waypoint_4 = new Waypoint();
							Waypoint waypoint = this;
							bool bool_38 = false;
							bool bool_39 = false;
							Doctrine doctrine = this.method_18();
							this.waypoint_4 = Waypoint.smethod_14(ref scenario_0, ref waypoint, bool_38, bool_39, ref doctrine);
							this.waypoint_4.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_4.enum82_0 = Waypoint.Enum82.const_0;
							flag5 = true;
						}
						break;
					}
					if (waypoint_6.enum83_0 != Waypoint.Enum83.const_2)
					{
						if (!Information.IsNothing(this.waypoint_0) && Information.IsNothing(waypoint_6.waypoint_0))
						{
							waypoint_6.waypoint_0 = new Waypoint();
							Waypoint waypoint2 = waypoint_6;
							bool bool_40 = false;
							bool bool_41 = false;
							Doctrine doctrine = this.method_18();
							waypoint2.waypoint_0 = Waypoint.smethod_14(ref scenario_0, ref waypoint_6, bool_40, bool_41, ref doctrine);
							waypoint_6.waypoint_0.enum82_1 = Waypoint.Enum82.const_0;
						}
						if (!Information.IsNothing(this.waypoint_1) && Information.IsNothing(waypoint_6.waypoint_1))
						{
							waypoint_6.waypoint_1 = new Waypoint();
							Waypoint waypoint3 = waypoint_6;
							bool bool_42 = false;
							bool bool_43 = false;
							Doctrine doctrine = this.method_18();
							waypoint3.waypoint_1 = Waypoint.smethod_14(ref scenario_0, ref waypoint_6, bool_42, bool_43, ref doctrine);
							waypoint_6.waypoint_1.enum82_1 = Waypoint.Enum82.const_0;
						}
						if (!Information.IsNothing(this.waypoint_2) && Information.IsNothing(waypoint_6.waypoint_2))
						{
							waypoint_6.waypoint_2 = new Waypoint();
							Waypoint waypoint4 = waypoint_6;
							bool bool_44 = false;
							bool bool_45 = false;
							Doctrine doctrine = this.method_18();
							waypoint4.waypoint_2 = Waypoint.smethod_14(ref scenario_0, ref waypoint_6, bool_44, bool_45, ref doctrine);
							waypoint_6.waypoint_2.enum82_1 = Waypoint.Enum82.const_0;
						}
						if (!Information.IsNothing(this.waypoint_3) && Information.IsNothing(waypoint_6.waypoint_3))
						{
							waypoint_6.waypoint_3 = new Waypoint();
							Waypoint waypoint5 = waypoint_6;
							bool bool_46 = false;
							bool bool_47 = false;
							Doctrine doctrine = this.method_18();
							waypoint5.waypoint_3 = Waypoint.smethod_14(ref scenario_0, ref waypoint_6, bool_46, bool_47, ref doctrine);
							waypoint_6.waypoint_3.enum82_1 = Waypoint.Enum82.const_0;
						}
						if (!Information.IsNothing(this.waypoint_4) && Information.IsNothing(waypoint_6.waypoint_4))
						{
							waypoint_6.waypoint_4 = new Waypoint();
							Waypoint waypoint6 = waypoint_6;
							bool bool_48 = false;
							bool bool_49 = false;
							Doctrine doctrine = this.method_18();
							waypoint6.waypoint_4 = Waypoint.smethod_14(ref scenario_0, ref waypoint_6, bool_48, bool_49, ref doctrine);
							waypoint_6.waypoint_4.enum82_1 = Waypoint.Enum82.const_0;
						}
					}
					float num = Math2.smethod_17(waypoint_5.imethod_2(), waypoint_5.imethod_0(), base.imethod_2(), base.imethod_0());
					if (this.waypointType_0 != Waypoint.WaypointType.Target && this.waypointType_0 != Waypoint.WaypointType.WeaponTarget)
					{
						if (flag && !Information.IsNothing(this.waypoint_0))
						{
							float num2 = Math2.smethod_7(num + 90f);
							double double_ = base.imethod_0();
							double double_2 = base.imethod_2();
							Waypoint waypoint;
							double double_3 = (waypoint = this.waypoint_0).imethod_0();
							Waypoint waypoint7;
							double double_4 = (waypoint7 = this.waypoint_0).imethod_2();
							Class411.smethod_1(double_, double_2, ref double_3, ref double_4, (double)3f, (double)num2);
							waypoint7.imethod_3(double_4);
							waypoint.imethod_1(double_3);
						}
						if (flag2 && !Information.IsNothing(this.waypoint_1))
						{
							float num2 = Math2.smethod_7(num + 90f);
							double double_5 = base.imethod_0();
							double double_6 = base.imethod_2();
							Waypoint waypoint7;
							double double_4 = (waypoint7 = this.waypoint_1).imethod_0();
							Waypoint waypoint;
							double double_3 = (waypoint = this.waypoint_1).imethod_2();
							Class411.smethod_1(double_5, double_6, ref double_4, ref double_3, (double)6f, (double)num2);
							waypoint.imethod_3(double_3);
							waypoint7.imethod_1(double_4);
						}
						if (flag3 && !Information.IsNothing(this.waypoint_2))
						{
							float num2 = Math2.smethod_7(num + 90f);
							double double_7 = base.imethod_0();
							double double_8 = base.imethod_2();
							Waypoint waypoint;
							double double_3 = (waypoint = this.waypoint_2).imethod_0();
							Waypoint waypoint7;
							double double_4 = (waypoint7 = this.waypoint_2).imethod_2();
							Class411.smethod_1(double_7, double_8, ref double_3, ref double_4, (double)9f, (double)num2);
							waypoint7.imethod_3(double_4);
							waypoint.imethod_1(double_3);
						}
						if (flag4 && !Information.IsNothing(this.waypoint_3))
						{
							float num2 = Math2.smethod_7(num + 90f);
							double double_9 = base.imethod_0();
							double double_10 = base.imethod_2();
							Waypoint waypoint7;
							double double_4 = (waypoint7 = this.waypoint_3).imethod_0();
							Waypoint waypoint;
							double double_3 = (waypoint = this.waypoint_3).imethod_2();
							Class411.smethod_1(double_9, double_10, ref double_4, ref double_3, (double)12f, (double)num2);
							waypoint.imethod_3(double_3);
							waypoint7.imethod_1(double_4);
						}
						if (flag5 && !Information.IsNothing(this.waypoint_4))
						{
							float num2 = Math2.smethod_7(num + 90f);
							double double_11 = base.imethod_0();
							double double_12 = base.imethod_2();
							Waypoint waypoint;
							double double_3 = (waypoint = this.waypoint_4).imethod_0();
							Waypoint waypoint7;
							double double_4 = (waypoint7 = this.waypoint_4).imethod_2();
							Class411.smethod_1(double_11, double_12, ref double_3, ref double_4, (double)15f, (double)num2);
							waypoint7.imethod_3(double_4);
							waypoint.imethod_1(double_3);
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

		// Token: 0x060012A2 RID: 4770 RVA: 0x0016D760 File Offset: 0x0016B960
		public bool method_21()
		{
			return !Information.IsNothing(this.waypoint_0) || !Information.IsNothing(this.waypoint_1) || !Information.IsNothing(this.waypoint_2) || !Information.IsNothing(this.waypoint_3) || !Information.IsNothing(this.waypoint_4);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0016D7B8 File Offset: 0x0016B9B8
		public bool method_22()
		{
			return this.method_21() && this.enum83_0 == Waypoint.Enum83.const_2;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x0016D7E0 File Offset: 0x0016B9E0
		public bool method_23()
		{
			return this.method_21() && this.enum83_0 != Waypoint.Enum83.const_2;
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0016D808 File Offset: 0x0016BA08
		public void method_24(ref Waypoint waypoint_5, ref Waypoint waypoint_6)
		{
			try
			{
				if (!Information.IsNothing(waypoint_5) && !Information.IsNothing(waypoint_6))
				{
					if (waypoint_5.method_22())
					{
						if (!Information.IsNothing(this.waypoint_0))
						{
							this.waypoint_0.imethod_3(base.imethod_2());
							this.waypoint_0.imethod_1(base.imethod_0());
							this.waypoint_0.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_0.nullable_0 = this.nullable_0;
							this.waypoint_0.method_28(this.method_27());
							this.waypoint_0.method_36(this.method_35());
						}
						if (!Information.IsNothing(this.waypoint_1))
						{
							this.waypoint_1.imethod_3(base.imethod_2());
							this.waypoint_1.imethod_1(base.imethod_0());
							this.waypoint_1.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_1.nullable_0 = this.nullable_0;
							this.waypoint_1.method_28(this.method_27());
							this.waypoint_1.method_36(this.method_35());
						}
						if (!Information.IsNothing(this.waypoint_2))
						{
							this.waypoint_2.imethod_3(base.imethod_2());
							this.waypoint_2.imethod_1(base.imethod_0());
							this.waypoint_2.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_2.nullable_0 = this.nullable_0;
							this.waypoint_2.method_28(this.method_27());
							this.waypoint_2.method_36(this.method_35());
						}
						if (!Information.IsNothing(this.waypoint_3))
						{
							this.waypoint_3.imethod_3(base.imethod_2());
							this.waypoint_3.imethod_1(base.imethod_0());
							this.waypoint_3.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_3.nullable_0 = this.nullable_0;
							this.waypoint_3.method_28(this.method_27());
							this.waypoint_3.method_36(this.method_35());
						}
						if (!Information.IsNothing(this.waypoint_4))
						{
							this.waypoint_4.imethod_3(base.imethod_2());
							this.waypoint_4.imethod_1(base.imethod_0());
							this.waypoint_4.enum82_1 = Waypoint.Enum82.const_0;
							this.waypoint_4.nullable_0 = this.nullable_0;
							this.waypoint_4.method_28(this.method_27());
							this.waypoint_4.method_36(this.method_35());
						}
					}
					else
					{
						this.waypoint_0 = null;
						this.waypoint_1 = null;
						this.waypoint_2 = null;
						this.waypoint_3 = null;
						this.waypoint_4 = null;
					}
					if (waypoint_6.method_23())
					{
						waypoint_6.waypoint_0 = null;
						waypoint_6.waypoint_1 = null;
						waypoint_6.waypoint_2 = null;
						waypoint_6.waypoint_3 = null;
						waypoint_6.waypoint_4 = null;
					}
				}
				else
				{
					this.waypoint_0 = null;
					this.waypoint_1 = null;
					this.waypoint_2 = null;
					this.waypoint_3 = null;
					this.waypoint_4 = null;
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

		// Token: 0x060012A6 RID: 4774 RVA: 0x0016DB34 File Offset: 0x0016BD34
		public Waypoint(ref Scenario scenario_0, Waypoint.WaypointType waypointType_1, Waypoint.Enum79 enum79_1, string string_4, Doctrine doctrine_1, bool bool_17, ActiveUnit_Kinematics.UnitThrottlePreset unitThrottlePreset_1, ActiveUnit_AI.AircraftAltitudePreset aircraftAltitudePreset_1, ActiveUnit_AI.SubmarineDepthPreset submarineDepthPreset_1, float? nullable_11, float? nullable_12, float? nullable_13, bool bool_18, bool? nullable_14, float? nullable_15, bool? nullable_16, string string_5, double double_2, double double_3, float float_31, Waypoint.Enum80 enum80_1, bool bool_19, float? nullable_17, DateTime? nullable_18, DateTime? nullable_19, DateTime? nullable_20, DateTime? nullable_21, Weather.TTimeOfDayType ttimeOfDayType_1, Waypoint.Enum82 enum82_2, Waypoint.Enum82 enum82_3, Waypoint.Enum83 enum83_1, Waypoint.Enum84 enum84_1, Mission.TankerMethod tankerMethod_1, List<string> list_15, List<Mission> list_16, int int_4, int int_5, bool bool_20, int int_6, float float_32, float float_33, float float_34, float float_35, float float_36, float float_37, float float_38, float float_39, float float_40, float float_41, float float_42, float float_43, float float_44, float float_45, float float_46, bool bool_21, bool bool_22, Waypoint.Enum81 enum81_1, List<Waypoint.Class281> list_17, float float_47, bool bool_23, Waypoint waypoint_5, Waypoint waypoint_6, Waypoint waypoint_7, Waypoint waypoint_8, Waypoint waypoint_9, float float_48, float float_49, float float_50, float float_51, float float_52, float float_53, float float_54, float float_55, float float_56, float float_57, int int_7, string string_6, float float_58, float float_59, float float_60, ref GeoPoint geoPoint_1, bool bool_24, ref Doctrine doctrine_2, Mission.Enum94 enum94_1, float float_61, Mission.Enum105 enum105_1, List<Mission.Class288> list_18, List<Mission.Class288> list_19, List<Mission.Class288> list_20, List<Mission.Class288> list_21, List<Mission.Class288> list_22, List<Mission.Class288> list_23, List<Mission.Class289> list_24, List<Mission.Class289> list_25, List<Mission.Class289> list_26, List<Mission.Class289> list_27, List<Mission.Class289> list_28, List<Mission.Class289> list_29)
		{
			this.unitThrottlePreset_0 = ActiveUnit_Kinematics.UnitThrottlePreset.None;
			this.aircraftAltitudePreset_0 = ActiveUnit_AI.AircraftAltitudePreset.None;
			this.submarineDepthPreset_0 = ActiveUnit_AI.SubmarineDepthPreset.None;
			this.float_24 = 0f;
			this.float_25 = 0f;
			this.float_26 = 0f;
			this.float_27 = 0f;
			this.enum94_0 = Mission.Enum94.const_0;
			this.list_0 = new List<string>();
			this.list_1 = new List<Mission>();
			this.int_0 = 0;
			this.int_1 = int.MaxValue;
			this.bool_16 = true;
			this.int_2 = 0;
			try
			{
				this.bool_10 = true;
				this.waypointType_0 = waypointType_1;
				this.enum79_0 = enum79_1;
				this.string_2 = string_4;
				this.bool_11 = bool_17;
				this.unitThrottlePreset_0 = unitThrottlePreset_1;
				this.aircraftAltitudePreset_0 = aircraftAltitudePreset_1;
				this.submarineDepthPreset_0 = submarineDepthPreset_1;
				this.nullable_0 = nullable_11;
				this.nullable_1 = nullable_12;
				this.nullable_2 = nullable_17;
				this.nullable_3 = nullable_13;
				this.bool_13 = bool_18;
				this.nullable_4 = nullable_14;
				this.nullable_5 = nullable_15;
				this.nullable_6 = nullable_16;
				base.imethod_1(double_2);
				base.imethod_3(double_3);
				base.imethod_5(float_31);
				this.Name = string_5;
				this.enum80_0 = enum80_1;
				this.method_38(bool_19);
				this.nullable_7 = nullable_18;
				this.nullable_8 = nullable_19;
				this.nullable_9 = nullable_20;
				this.nullable_10 = nullable_21;
				this.ttimeOfDayType_0 = ttimeOfDayType_1;
				this.enum82_0 = enum82_2;
				this.enum82_1 = enum82_3;
				this.enum83_0 = enum83_1;
				this.enum84_0 = enum84_1;
				this.tankerMethod_0 = tankerMethod_1;
				try
				{
					foreach (string item in list_15)
					{
						this.list_0.Add(item);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (Mission item2 in list_16)
					{
						this.list_1.Add(item2);
					}
				}
				finally
				{
					List<Mission>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				this.int_0 = int_4;
				this.int_1 = int_5;
				this.bool_16 = bool_20;
				this.int_2 = int_6;
				this.float_2 = float_32;
				this.float_3 = float_33;
				this.float_4 = float_34;
				this.float_5 = float_35;
				this.float_6 = float_36;
				this.float_7 = float_37;
				this.float_8 = float_38;
				this.float_9 = float_39;
				this.float_13 = float_40;
				this.float_10 = float_44;
				this.float_11 = float_45;
				this.float_12 = float_46;
				this.bool_14 = bool_21;
				this.bool_15 = bool_22;
				this.enum81_0 = enum81_1;
				if (bool_24 && !Information.IsNothing(list_17))
				{
					this.list_2 = new List<Waypoint.Class281>();
					try
					{
						foreach (Waypoint.Class281 @class in list_17)
						{
							Waypoint.Class281 item3 = new Waypoint.Class281(ref @class.double_0, @class.double_1, @class.double_2, @class.double_3);
							this.list_2.Add(item3);
						}
					}
					finally
					{
						List<Waypoint.Class281>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				this.float_14 = float_48;
				this.float_19 = float_53;
				this.float_15 = float_49;
				this.float_20 = float_54;
				this.float_16 = float_50;
				this.float_21 = float_55;
				this.float_17 = float_51;
				this.float_22 = float_56;
				this.float_18 = float_52;
				this.float_23 = float_57;
				if (Information.IsNothing(doctrine_2))
				{
					this.doctrine_0 = this.method_18().method_0(ref doctrine_1, this, ref scenario_0);
				}
				else
				{
					this.doctrine_0 = doctrine_2;
				}
				if (bool_23)
				{
					if (!Information.IsNothing(waypoint_5))
					{
						bool bool_25 = false;
						Doctrine doctrine = this.method_18();
						this.waypoint_0 = Waypoint.smethod_14(ref scenario_0, ref waypoint_5, bool_25, bool_24, ref doctrine);
					}
					if (!Information.IsNothing(waypoint_6))
					{
						bool bool_26 = false;
						Doctrine doctrine = this.method_18();
						this.waypoint_1 = Waypoint.smethod_14(ref scenario_0, ref waypoint_6, bool_26, bool_24, ref doctrine);
					}
					if (!Information.IsNothing(waypoint_7))
					{
						bool bool_27 = false;
						Doctrine doctrine = this.method_18();
						this.waypoint_2 = Waypoint.smethod_14(ref scenario_0, ref waypoint_7, bool_27, bool_24, ref doctrine);
					}
					if (!Information.IsNothing(waypoint_8))
					{
						bool bool_28 = false;
						Doctrine doctrine = this.method_18();
						this.waypoint_3 = Waypoint.smethod_14(ref scenario_0, ref waypoint_8, bool_28, bool_24, ref doctrine);
					}
					if (!Information.IsNothing(waypoint_9))
					{
						bool bool_29 = false;
						Doctrine doctrine = this.method_18();
						this.waypoint_4 = Waypoint.smethod_14(ref scenario_0, ref waypoint_9, bool_29, bool_24, ref doctrine);
					}
				}
				this.float_24 = float_41;
				this.float_25 = float_42;
				this.float_26 = float_43;
				this.enum94_0 = enum94_1;
				this.float_27 = float_61;
				this.float_1 = float_47;
				this.int_3 = int_7;
				this.string_3 = string_6;
				this.float_28 = float_58;
				this.float_29 = float_59;
				this.float_30 = float_60;
				if (!Information.IsNothing(geoPoint_1))
				{
					this.geoPoint_0 = new GeoPoint(geoPoint_1.imethod_0(), geoPoint_1.imethod_2());
				}
				this.enum105_0 = enum105_1;
				if (!Information.IsNothing(list_18))
				{
					this.list_3 = new List<Mission.Class288>();
					try
					{
						foreach (Mission.Class288 class2 in list_18)
						{
							Mission.Class288 item4 = new Mission.Class288(class2.string_0, class2.int_0, class2.string_1, class2.string_2, class2.string_3, class2.int_1, class2.double_0, class2.double_1, class2.geoPoint_0, null, null);
							this.list_3.Add(item4);
						}
					}
					finally
					{
						List<Mission.Class288>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				if (!Information.IsNothing(list_19))
				{
					this.list_4 = new List<Mission.Class288>();
					try
					{
						foreach (Mission.Class288 class3 in list_19)
						{
							Mission.Class288 item5 = new Mission.Class288(class3.string_0, class3.int_0, class3.string_1, class3.string_2, class3.string_3, class3.int_1, class3.double_0, class3.double_1, class3.geoPoint_0, null, null);
							this.list_4.Add(item5);
						}
					}
					finally
					{
						List<Mission.Class288>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
				if (!Information.IsNothing(list_20))
				{
					this.list_5 = new List<Mission.Class288>();
					try
					{
						foreach (Mission.Class288 class4 in list_20)
						{
							Mission.Class288 item6 = new Mission.Class288(class4.string_0, class4.int_0, class4.string_1, class4.string_2, class4.string_3, class4.int_1, class4.double_0, class4.double_1, class4.geoPoint_0, null, null);
							this.list_5.Add(item6);
						}
					}
					finally
					{
						List<Mission.Class288>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
				}
				if (!Information.IsNothing(list_21))
				{
					this.list_6 = new List<Mission.Class288>();
					try
					{
						foreach (Mission.Class288 class5 in list_21)
						{
							Mission.Class288 item7 = new Mission.Class288(class5.string_0, class5.int_0, class5.string_1, class5.string_2, class5.string_3, class5.int_1, class5.double_0, class5.double_1, class5.geoPoint_0, null, null);
							this.list_6.Add(item7);
						}
					}
					finally
					{
						List<Mission.Class288>.Enumerator enumerator7;
						((IDisposable)enumerator7).Dispose();
					}
				}
				if (!Information.IsNothing(list_22))
				{
					this.list_7 = new List<Mission.Class288>();
					try
					{
						foreach (Mission.Class288 class6 in list_22)
						{
							Mission.Class288 item8 = new Mission.Class288(class6.string_0, class6.int_0, class6.string_1, class6.string_2, class6.string_3, class6.int_1, class6.double_0, class6.double_1, class6.geoPoint_0, null, null);
							this.list_7.Add(item8);
						}
					}
					finally
					{
						List<Mission.Class288>.Enumerator enumerator8;
						((IDisposable)enumerator8).Dispose();
					}
				}
				if (!Information.IsNothing(list_23))
				{
					this.list_8 = new List<Mission.Class288>();
					try
					{
						foreach (Mission.Class288 class7 in list_23)
						{
							Mission.Class288 item9 = new Mission.Class288(class7.string_0, class7.int_0, class7.string_1, class7.string_2, class7.string_3, class7.int_1, class7.double_0, class7.double_1, class7.geoPoint_0, null, null);
							this.list_8.Add(item9);
						}
					}
					finally
					{
						List<Mission.Class288>.Enumerator enumerator9;
						((IDisposable)enumerator9).Dispose();
					}
				}
				if (!Information.IsNothing(list_24))
				{
					this.list_9 = new List<Mission.Class289>();
					try
					{
						foreach (Mission.Class289 class8 in list_24)
						{
							int int_8 = class8.int_0;
							Weapon._WeaponType weaponType_ = class8._WeaponType_0;
							string string_7 = class8.string_0;
							float float_62 = class8.float_0;
							float num = class8.float_1;
							bool bool_30 = class8.bool_0;
							string string_8 = class8.string_1;
							int int_9 = class8.int_1;
							int int_10 = class8.int_2;
							int int_11 = class8.int_3;
							int int_12 = class8.int_4;
							Waypoint[] array = null;
							Mission.Class289 item10 = new Mission.Class289(int_8, weaponType_, string_7, float_62, num, bool_30, string_8, int_9, int_10, int_11, int_12, ref array);
							this.list_9.Add(item10);
						}
					}
					finally
					{
						List<Mission.Class289>.Enumerator enumerator10;
						((IDisposable)enumerator10).Dispose();
					}
				}
				if (!Information.IsNothing(list_25))
				{
					this.list_10 = new List<Mission.Class289>();
					try
					{
						foreach (Mission.Class289 class9 in list_25)
						{
							int int_13 = class9.int_0;
							Weapon._WeaponType weaponType_2 = class9._WeaponType_0;
							string string_9 = class9.string_0;
							float float_63 = class9.float_0;
							float num2 = class9.float_1;
							bool bool_31 = class9.bool_0;
							string string_10 = class9.string_1;
							int int_14 = class9.int_1;
							int int_15 = class9.int_2;
							int int_16 = class9.int_3;
							int int_17 = class9.int_4;
							Waypoint[] array = null;
							Mission.Class289 item11 = new Mission.Class289(int_13, weaponType_2, string_9, float_63, num2, bool_31, string_10, int_14, int_15, int_16, int_17, ref array);
							this.list_10.Add(item11);
						}
					}
					finally
					{
						List<Mission.Class289>.Enumerator enumerator11;
						((IDisposable)enumerator11).Dispose();
					}
				}
				if (!Information.IsNothing(list_26))
				{
					this.list_11 = new List<Mission.Class289>();
					try
					{
						foreach (Mission.Class289 class10 in list_26)
						{
							int int_18 = class10.int_0;
							Weapon._WeaponType weaponType_3 = class10._WeaponType_0;
							string string_11 = class10.string_0;
							float float_64 = class10.float_0;
							float num3 = class10.float_1;
							bool bool_32 = class10.bool_0;
							string string_12 = class10.string_1;
							int int_19 = class10.int_1;
							int int_20 = class10.int_2;
							int int_21 = class10.int_3;
							int int_22 = class10.int_4;
							Waypoint[] array = null;
							Mission.Class289 item12 = new Mission.Class289(int_18, weaponType_3, string_11, float_64, num3, bool_32, string_12, int_19, int_20, int_21, int_22, ref array);
							this.list_11.Add(item12);
						}
					}
					finally
					{
						List<Mission.Class289>.Enumerator enumerator12;
						((IDisposable)enumerator12).Dispose();
					}
				}
				if (!Information.IsNothing(list_27))
				{
					this.list_12 = new List<Mission.Class289>();
					try
					{
						foreach (Mission.Class289 class11 in list_27)
						{
							int int_23 = class11.int_0;
							Weapon._WeaponType weaponType_4 = class11._WeaponType_0;
							string string_13 = class11.string_0;
							float float_65 = class11.float_0;
							float num4 = class11.float_1;
							bool bool_33 = class11.bool_0;
							string string_14 = class11.string_1;
							int int_24 = class11.int_1;
							int int_25 = class11.int_2;
							int int_26 = class11.int_3;
							int int_27 = class11.int_4;
							Waypoint[] array = null;
							Mission.Class289 item13 = new Mission.Class289(int_23, weaponType_4, string_13, float_65, num4, bool_33, string_14, int_24, int_25, int_26, int_27, ref array);
							this.list_12.Add(item13);
						}
					}
					finally
					{
						List<Mission.Class289>.Enumerator enumerator13;
						((IDisposable)enumerator13).Dispose();
					}
				}
				if (!Information.IsNothing(list_28))
				{
					this.list_13 = new List<Mission.Class289>();
					try
					{
						foreach (Mission.Class289 class12 in list_28)
						{
							int int_28 = class12.int_0;
							Weapon._WeaponType weaponType_5 = class12._WeaponType_0;
							string string_15 = class12.string_0;
							float float_66 = class12.float_0;
							float num5 = class12.float_1;
							bool bool_34 = class12.bool_0;
							string string_16 = class12.string_1;
							int int_29 = class12.int_1;
							int int_30 = class12.int_2;
							int int_31 = class12.int_3;
							int int_32 = class12.int_4;
							Waypoint[] array = null;
							Mission.Class289 item14 = new Mission.Class289(int_28, weaponType_5, string_15, float_66, num5, bool_34, string_16, int_29, int_30, int_31, int_32, ref array);
							this.list_13.Add(item14);
						}
					}
					finally
					{
						List<Mission.Class289>.Enumerator enumerator14;
						((IDisposable)enumerator14).Dispose();
					}
				}
				if (!Information.IsNothing(list_29))
				{
					this.list_14 = new List<Mission.Class289>();
					try
					{
						foreach (Mission.Class289 class13 in list_29)
						{
							int int_33 = class13.int_0;
							Weapon._WeaponType weaponType_6 = class13._WeaponType_0;
							string string_17 = class13.string_0;
							float float_67 = class13.float_0;
							float num6 = class13.float_1;
							bool bool_35 = class13.bool_0;
							string string_18 = class13.string_1;
							int int_34 = class13.int_1;
							int int_35 = class13.int_2;
							int int_36 = class13.int_3;
							int int_37 = class13.int_4;
							Waypoint[] array = null;
							Mission.Class289 item15 = new Mission.Class289(int_33, weaponType_6, string_17, float_67, num6, bool_35, string_18, int_34, int_35, int_36, int_37, ref array);
							this.list_14.Add(item15);
						}
					}
					finally
					{
						List<Mission.Class289>.Enumerator enumerator15;
						((IDisposable)enumerator15).Dispose();
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

		// Token: 0x060012A7 RID: 4775 RVA: 0x0016E948 File Offset: 0x0016CB48
		public void method_25()
		{
			if (!Information.IsNothing(this) && this.method_29())
			{
				switch (this.method_31())
				{
				case ActiveUnit_AI.AircraftAltitudePreset.None:
					this.nullable_1 = null;
					this.nullable_2 = null;
					return;
				case ActiveUnit_AI.AircraftAltitudePreset.MinAltitude:
					this.nullable_1 = new float?(0f);
					this.nullable_2 = new float?(0f);
					return;
				case ActiveUnit_AI.AircraftAltitudePreset.Low1000:
					if (this.method_37())
					{
						this.nullable_1 = null;
						this.nullable_2 = new float?(304.8f);
						return;
					}
					this.nullable_1 = new float?(304.8f);
					this.nullable_2 = null;
					return;
				case ActiveUnit_AI.AircraftAltitudePreset.Low2000:
					if (this.method_37())
					{
						this.nullable_1 = null;
						this.nullable_2 = new float?(609.6f);
						return;
					}
					this.nullable_1 = new float?(609.6f);
					this.nullable_2 = null;
					return;
				case ActiveUnit_AI.AircraftAltitudePreset.Medium12000:
					if (this.method_37())
					{
						this.nullable_1 = null;
						this.nullable_2 = new float?(3657.6f);
						return;
					}
					this.nullable_1 = new float?(3657.6f);
					this.nullable_2 = null;
					return;
				case ActiveUnit_AI.AircraftAltitudePreset.High25000:
					if (this.method_37())
					{
						this.nullable_1 = null;
						this.nullable_2 = new float?(7620f);
						return;
					}
					this.nullable_1 = new float?(7620f);
					this.nullable_2 = null;
					return;
				case ActiveUnit_AI.AircraftAltitudePreset.High36000:
					if (this.method_37())
					{
						this.nullable_1 = null;
						this.nullable_2 = new float?(10972.8f);
						return;
					}
					this.nullable_1 = new float?(10972.8f);
					this.nullable_2 = null;
					return;
				case ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude:
					this.nullable_1 = null;
					this.nullable_2 = null;
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x0016EB38 File Offset: 0x0016CD38
		public void method_26()
		{
			if (!Information.IsNothing(this) && this.method_29())
			{
				switch (this.method_33())
				{
				case ActiveUnit_AI.SubmarineDepthPreset.None:
					this.nullable_1 = null;
					return;
				case ActiveUnit_AI.SubmarineDepthPreset.Periscope:
					this.nullable_1 = new float?(-20f);
					return;
				case ActiveUnit_AI.SubmarineDepthPreset.Shallow:
					this.nullable_1 = new float?(-40f);
					return;
				case ActiveUnit_AI.SubmarineDepthPreset.OverLayer:
					this.nullable_1 = new float?(Waypoint.smethod_15(this));
					return;
				case ActiveUnit_AI.SubmarineDepthPreset.UnderLayer:
					this.nullable_1 = new float?(Waypoint.smethod_16(this));
					return;
				case ActiveUnit_AI.SubmarineDepthPreset.MaxDepth:
					this.nullable_1 = new float?(0f);
					break;
				case ActiveUnit_AI.SubmarineDepthPreset.Surface:
					this.nullable_1 = new float?(0f);
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x0000AA26 File Offset: 0x00008C26
		public static float smethod_15(Waypoint waypoint_5)
		{
			return (float)(Class568.smethod_2(waypoint_5.imethod_2(), waypoint_5.imethod_0(), (int)Terrain.smethod_7(waypoint_5.imethod_2(), waypoint_5.imethod_0(), false)).int_0 + 10);
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x0000AA54 File Offset: 0x00008C54
		public static float smethod_16(Waypoint waypoint_5)
		{
			return (float)(Class568.smethod_2(waypoint_5.imethod_2(), waypoint_5.imethod_0(), (int)Terrain.smethod_7(waypoint_5.imethod_2(), waypoint_5.imethod_0(), false)).int_1 - 10);
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0000AA82 File Offset: 0x00008C82
		public float? method_27()
		{
			return this.nullable_3;
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0000AA8A File Offset: 0x00008C8A
		public void method_28(float? nullable_11)
		{
			this.nullable_3 = nullable_11;
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x0000AA93 File Offset: 0x00008C93
		public bool method_29()
		{
			return this.bool_13;
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0000AA9B File Offset: 0x00008C9B
		public void method_30(bool bool_17)
		{
			if (!bool_17)
			{
				this.method_38(false);
			}
			this.bool_13 = bool_17;
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0000AAAE File Offset: 0x00008CAE
		public ActiveUnit_AI.AircraftAltitudePreset method_31()
		{
			return this.aircraftAltitudePreset_0;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x0000AAB6 File Offset: 0x00008CB6
		public void method_32(ActiveUnit_AI.AircraftAltitudePreset aircraftAltitudePreset_1)
		{
			this.aircraftAltitudePreset_0 = aircraftAltitudePreset_1;
			if (aircraftAltitudePreset_1 != ActiveUnit_AI.AircraftAltitudePreset.None)
			{
				this.method_30(true);
			}
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0000AAC9 File Offset: 0x00008CC9
		public ActiveUnit_AI.SubmarineDepthPreset method_33()
		{
			return this.submarineDepthPreset_0;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0000AAD1 File Offset: 0x00008CD1
		public void method_34(ActiveUnit_AI.SubmarineDepthPreset submarineDepthPreset_1)
		{
			this.submarineDepthPreset_0 = submarineDepthPreset_1;
			if (submarineDepthPreset_1 != ActiveUnit_AI.SubmarineDepthPreset.None)
			{
				this.method_30(true);
			}
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0000AAE4 File Offset: 0x00008CE4
		public ActiveUnit_Kinematics.UnitThrottlePreset method_35()
		{
			return this.unitThrottlePreset_0;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x0000AAEC File Offset: 0x00008CEC
		public void method_36(ActiveUnit_Kinematics.UnitThrottlePreset unitThrottlePreset_1)
		{
			this.unitThrottlePreset_0 = unitThrottlePreset_1;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x0000AAF5 File Offset: 0x00008CF5
		public bool method_37()
		{
			return this.bool_12;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x0000AAFD File Offset: 0x00008CFD
		public void method_38(bool bool_17)
		{
			if (bool_17 && !this.method_29())
			{
				this.method_30(true);
			}
			this.bool_12 = bool_17;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x0016EBFC File Offset: 0x0016CDFC
		public static void smethod_17(ref DataTable dataTable_0)
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
				Waypoint.smethod_23(Waypoint.WaypointType.TakeOff)
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				Waypoint.smethod_23(Waypoint.WaypointType.Assemble)
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				Waypoint.smethod_23(Waypoint.WaypointType.TurningPoint)
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				Waypoint.smethod_23(Waypoint.WaypointType.Refuel)
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				Waypoint.smethod_23(Waypoint.WaypointType.StrikeIngress)
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				Waypoint.smethod_23(Waypoint.WaypointType.InitialPoint)
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				Waypoint.smethod_23(Waypoint.WaypointType.WeaponLaunch)
			});
			dataTable_0.Rows.Add(new object[]
			{
				7,
				Waypoint.smethod_23(Waypoint.WaypointType.Target)
			});
			dataTable_0.Rows.Add(new object[]
			{
				8,
				Waypoint.smethod_23(Waypoint.WaypointType.WeaponTarget)
			});
			dataTable_0.Rows.Add(new object[]
			{
				9,
				Waypoint.smethod_23(Waypoint.WaypointType.StrikeEgress)
			});
			dataTable_0.Rows.Add(new object[]
			{
				10,
				Waypoint.smethod_23(Waypoint.WaypointType.LandingMarshal)
			});
			dataTable_0.Rows.Add(new object[]
			{
				11,
				Waypoint.smethod_23(Waypoint.WaypointType.Land)
			});
			dataTable_0.Rows.Add(new object[]
			{
				12,
				Waypoint.smethod_23(Waypoint.WaypointType.StationStart_Racetrack)
			});
			dataTable_0.Rows.Add(new object[]
			{
				13,
				Waypoint.smethod_23(Waypoint.WaypointType.StationStart_RaceTrackRandom)
			});
			dataTable_0.Rows.Add(new object[]
			{
				14,
				Waypoint.smethod_23(Waypoint.WaypointType.StationStart_FigureEight)
			});
			dataTable_0.Rows.Add(new object[]
			{
				15,
				Waypoint.smethod_23(Waypoint.WaypointType.StationStart_Area)
			});
			dataTable_0.Rows.Add(new object[]
			{
				16,
				Waypoint.smethod_23(Waypoint.WaypointType.StationEnd)
			});
			dataTable_0.Rows.Add(new object[]
			{
				17,
				Waypoint.smethod_23(Waypoint.WaypointType.HoldStart)
			});
			dataTable_0.Rows.Add(new object[]
			{
				18,
				Waypoint.smethod_23(Waypoint.WaypointType.HoldEnd)
			});
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x0016EF40 File Offset: 0x0016D140
		public static int? smethod_18(ref object object_0)
		{
			int? result;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 0:
					result = new int?(15);
					break;
				case 1:
					result = new int?(5);
					break;
				case 2:
					result = new int?(6);
					break;
				case 3:
					result = new int?(14);
					break;
				case 4:
					result = new int?(12);
					break;
				case 5:
					result = new int?(7);
					break;
				case 6:
					result = new int?(17);
					break;
				case 7:
					result = new int?(10);
					break;
				case 8:
					result = new int?(19);
					break;
				case 9:
					result = new int?(13);
					break;
				case 10:
					result = new int?(11);
					break;
				case 11:
					result = new int?(18);
					break;
				case 12:
					result = new int?(20);
					break;
				case 13:
					result = new int?(23);
					break;
				case 14:
					result = new int?(21);
					break;
				case 15:
					result = new int?(22);
					break;
				case 16:
					result = new int?(24);
					break;
				case 17:
					result = new int?(26);
					break;
				case 18:
					result = new int?(27);
					break;
				default:
					result = null;
					break;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101300", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new int?(6);
			}
			return result;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0016F0F0 File Offset: 0x0016D2F0
		public static int smethod_19(object object_0)
		{
			int result;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 5:
					return 1;
				case 6:
					return 2;
				case 7:
					return 5;
				case 10:
					return 7;
				case 11:
					return 10;
				case 12:
					return 4;
				case 13:
					return 9;
				case 14:
					return 3;
				case 15:
					return 0;
				case 17:
					return 6;
				case 18:
					return 11;
				case 19:
					return 8;
				case 20:
					return 12;
				case 21:
					return 14;
				case 22:
					return 15;
				case 23:
					return 13;
				case 24:
					return 16;
				case 26:
					return 17;
				case 27:
					return 18;
				}
				result = 0;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101303", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 2;
			}
			return result;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x0016F21C File Offset: 0x0016D41C
		public static void smethod_20(ref DataTable dataTable_0)
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
				Waypoint.smethod_23(Waypoint.WaypointType.Launch)
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				Waypoint.smethod_23(Waypoint.WaypointType.TurningPoint)
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				Waypoint.smethod_23(Waypoint.WaypointType.TerminalPoint)
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				Waypoint.smethod_23(Waypoint.WaypointType.Activation)
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				Waypoint.smethod_23(Waypoint.WaypointType.Termination)
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				Waypoint.smethod_23(Waypoint.WaypointType.HoldStart)
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				Waypoint.smethod_23(Waypoint.WaypointType.HoldEnd)
			});
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0016F390 File Offset: 0x0016D590
		public static int? smethod_21(ref object object_0)
		{
			int? result;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 0:
					result = new int?(28);
					break;
				case 1:
					result = new int?(6);
					break;
				case 2:
					result = new int?(2);
					break;
				case 3:
					result = new int?(29);
					break;
				case 4:
					result = new int?(30);
					break;
				case 5:
					result = new int?(26);
					break;
				case 6:
					result = new int?(27);
					break;
				default:
					result = null;
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
				result = new int?(6);
			}
			return result;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x0016F468 File Offset: 0x0016D668
		public static int smethod_22(object object_0)
		{
			int result;
			try
			{
				int num = Conversions.ToInteger(object_0);
				if (num != 2)
				{
					if (num != 6)
					{
						switch (num)
						{
						case 26:
							result = 5;
							break;
						case 27:
							result = 6;
							break;
						case 28:
							result = 0;
							break;
						case 29:
							result = 3;
							break;
						case 30:
							result = 4;
							break;
						default:
							result = 1;
							break;
						}
					}
					else
					{
						result = 1;
					}
				}
				else
				{
					result = 2;
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
				result = 1;
			}
			return result;
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0016F50C File Offset: 0x0016D70C
		public static string smethod_23(Waypoint.WaypointType waypointType_1)
		{
			switch (waypointType_1)
			{
			case Waypoint.WaypointType.TerminalPoint:
				return "Terminal Point";
			case Waypoint.WaypointType.Assemble:
				return "Assemble";
			case Waypoint.WaypointType.TurningPoint:
				return "Turning Point";
			case Waypoint.WaypointType.InitialPoint:
				return "Initial Point (IP)";
			case Waypoint.WaypointType.Split:
				return "Split";
			case Waypoint.WaypointType.Formate:
				return "Formate";
			case Waypoint.WaypointType.Target:
				return "Target";
			case Waypoint.WaypointType.LandingMarshal:
				return "Landing Marshal Point";
			case Waypoint.WaypointType.StrikeIngress:
				return "Turning Point (Ingress)";
			case Waypoint.WaypointType.StrikeEgress:
				return "Turning Point (Egress)";
			case Waypoint.WaypointType.Refuel:
				return "Refuel";
			case Waypoint.WaypointType.TakeOff:
				return "Take-Off";
			case Waypoint.WaypointType.Marshal:
				return "Marshal";
			case Waypoint.WaypointType.WeaponLaunch:
				return "Weapon Launch";
			case Waypoint.WaypointType.Land:
				return "Land";
			case Waypoint.WaypointType.WeaponTarget:
				return "Weapon Target";
			case Waypoint.WaypointType.StationStart_Racetrack:
				return "Station Start (Racetrack)";
			case Waypoint.WaypointType.StationStart_FigureEight:
				return "Station Start (Figure Eight)";
			case Waypoint.WaypointType.StationStart_Area:
				return "Station Start (Area)";
			case Waypoint.WaypointType.StationStart_RaceTrackRandom:
				return "Station Start (Racetrack + Random)";
			case Waypoint.WaypointType.StationEnd:
				return "Station End";
			case Waypoint.WaypointType.HoldStart:
				return "Hold Start";
			case Waypoint.WaypointType.HoldEnd:
				return "Hold End";
			case Waypoint.WaypointType.Launch:
				return "Launch";
			case Waypoint.WaypointType.Activation:
				return "Activation";
			case Waypoint.WaypointType.Termination:
				return "Termination";
			}
			return "None";
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0016F694 File Offset: 0x0016D894
		public static void smethod_24(ref DataTable dataTable_0)
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
				Waypoint.smethod_29(Waypoint.Enum83.const_0)
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				Waypoint.smethod_29(Waypoint.Enum83.const_1)
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				Waypoint.smethod_29(Waypoint.Enum83.const_2)
			});
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0016F770 File Offset: 0x0016D970
		public static void smethod_25(ref DataTable dataTable_0)
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
				Waypoint.smethod_30(Waypoint.Enum81.const_0)
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				Waypoint.smethod_30(Waypoint.Enum81.const_1)
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				Waypoint.smethod_30(Waypoint.Enum81.const_2)
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				Waypoint.smethod_30(Waypoint.Enum81.const_3)
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				Waypoint.smethod_30(Waypoint.Enum81.const_4)
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				Waypoint.smethod_30(Waypoint.Enum81.const_5)
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				Waypoint.smethod_30(Waypoint.Enum81.const_6)
			});
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0016F8E0 File Offset: 0x0016DAE0
		public static int? smethod_26(ref object object_0)
		{
			int? result;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 0:
					result = new int?(0);
					break;
				case 1:
					result = new int?(1);
					break;
				case 2:
					result = new int?(100);
					break;
				default:
					result = null;
					break;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101301", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0016F974 File Offset: 0x0016DB74
		public static int? smethod_27(ref object object_0)
		{
			int? result;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 0:
					result = new int?(0);
					break;
				case 1:
					result = new int?(1);
					break;
				case 2:
					result = new int?(2);
					break;
				case 3:
					result = new int?(3);
					break;
				case 4:
					result = new int?(4);
					break;
				case 5:
					result = new int?(5);
					break;
				case 6:
					result = new int?(6);
					break;
				default:
					result = null;
					break;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200642", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0016FA3C File Offset: 0x0016DC3C
		public static int smethod_28(object object_0)
		{
			int result;
			try
			{
				int num = Conversions.ToInteger(object_0);
				if (num != 0)
				{
					if (num != 1)
					{
						if (num != 100)
						{
							result = 0;
						}
						else
						{
							result = 2;
						}
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

		// Token: 0x060012C3 RID: 4803 RVA: 0x0016FAB8 File Offset: 0x0016DCB8
		public static string smethod_29(Waypoint.Enum83 enum83_1)
		{
			string result;
			if (enum83_1 != Waypoint.Enum83.const_0)
			{
				if (enum83_1 != Waypoint.Enum83.const_1)
				{
					if (enum83_1 != Waypoint.Enum83.const_2)
					{
						result = "None";
					}
					else
					{
						result = "Split";
					}
				}
				else
				{
					result = "1nm Trail";
				}
			}
			else
			{
				result = "Spread";
			}
			return result;
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0016FAF4 File Offset: 0x0016DCF4
		public static string smethod_30(Waypoint.Enum81 enum81_1)
		{
			string result;
			switch (enum81_1)
			{
			case Waypoint.Enum81.const_0:
				result = "Standard Rate, 3 degrees per second";
				break;
			case Waypoint.Enum81.const_1:
				result = "Half Standard Rate, 1.5 degrees per second";
				break;
			case Waypoint.Enum81.const_2:
				result = "Double Standard Rate, 6 degrees per second";
				break;
			case Waypoint.Enum81.const_3:
				result = "Flat turn (no bank angle), 0.6 degrees per second";
				break;
			case Waypoint.Enum81.const_4:
				result = "2G turn, 60 degree bank angle";
				break;
			case Waypoint.Enum81.const_5:
				result = "3G turn, 70 degree bank angle";
				break;
			case Waypoint.Enum81.const_6:
				result = "4G turn, 75 degree bank angle";
				break;
			default:
				result = "None";
				break;
			}
			return result;
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0016FB64 File Offset: 0x0016DD64
		public static void smethod_31(ref DataTable dataTable_0)
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
				Waypoint.smethod_33(Waypoint.Enum84.const_0)
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				Waypoint.smethod_33(Waypoint.Enum84.const_1)
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				Waypoint.smethod_33(Waypoint.Enum84.const_2)
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				Waypoint.smethod_33(Waypoint.Enum84.const_3)
			});
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0016FC64 File Offset: 0x0016DE64
		public static int? smethod_32(ref object object_0)
		{
			int? result;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 0:
					result = new int?(0);
					break;
				case 1:
					result = new int?(1);
					break;
				case 2:
					result = new int?(2);
					break;
				case 3:
					result = new int?(3);
					break;
				default:
					result = null;
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
			return result;
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0016FD04 File Offset: 0x0016DF04
		public static string smethod_33(Waypoint.Enum84 enum84_1)
		{
			string result;
			switch (enum84_1)
			{
			case Waypoint.Enum84.const_0:
				result = "No";
				break;
			case Waypoint.Enum84.const_1:
				result = "Yes, down only";
				break;
			case Waypoint.Enum84.const_2:
				result = "Yes, down or up (max: Military)";
				break;
			case Waypoint.Enum84.const_3:
				result = "Yes, down or up (max: Afterburner)";
				break;
			default:
				result = "None";
				break;
			}
			return result;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0016FD50 File Offset: 0x0016DF50
		public bool method_39()
		{
			Waypoint.WaypointType waypointType = this.waypointType_0;
			return waypointType - Waypoint.WaypointType.StationStart_Racetrack <= 4;
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0016FD74 File Offset: 0x0016DF74
		public bool method_40()
		{
			Waypoint.WaypointType waypointType = this.waypointType_0;
			return waypointType - Waypoint.WaypointType.StationStart_Racetrack <= 3;
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0016FD98 File Offset: 0x0016DF98
		public bool method_41()
		{
			Waypoint.WaypointType waypointType = this.waypointType_0;
			return waypointType == Waypoint.WaypointType.StationEnd;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0016FDB8 File Offset: 0x0016DFB8
		public bool method_42()
		{
			Waypoint.WaypointType waypointType = this.waypointType_0;
			return waypointType == Waypoint.WaypointType.HoldStart;
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0016FDD8 File Offset: 0x0016DFD8
		public bool method_43()
		{
			Waypoint.WaypointType waypointType = this.waypointType_0;
			return waypointType == Waypoint.WaypointType.HoldEnd;
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0016FDF8 File Offset: 0x0016DFF8
		public bool method_44()
		{
			Waypoint.WaypointType waypointType = this.waypointType_0;
			return waypointType - Waypoint.WaypointType.HoldStart <= 1;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0016FE1C File Offset: 0x0016E01C
		public bool method_45()
		{
			Waypoint.WaypointType waypointType = this.waypointType_0;
			return waypointType == Waypoint.WaypointType.Assemble || waypointType - Waypoint.WaypointType.HoldStart <= 1;
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0016FE44 File Offset: 0x0016E044
		public void method_46(ref Scenario scenario_0, Side side_0, bool bool_17)
		{
			try
			{
				if (this.list_0.Count > 0)
				{
					foreach (Side side in scenario_0.method_44())
					{
						try
						{
							foreach (Mission mission in side.method_35())
							{
								if (this.list_0.Contains(mission.string_0))
								{
									this.list_1.Add(mission);
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

		// Token: 0x04000D25 RID: 3365
		public Waypoint.WaypointType waypointType_0;

		// Token: 0x04000D26 RID: 3366
		public Waypoint.Enum79 enum79_0;

		// Token: 0x04000D27 RID: 3367
		public string string_2;

		// Token: 0x04000D28 RID: 3368
		public bool bool_11;

		// Token: 0x04000D29 RID: 3369
		private ActiveUnit_Kinematics.UnitThrottlePreset unitThrottlePreset_0;

		// Token: 0x04000D2A RID: 3370
		private ActiveUnit_AI.AircraftAltitudePreset aircraftAltitudePreset_0;

		// Token: 0x04000D2B RID: 3371
		private ActiveUnit_AI.SubmarineDepthPreset submarineDepthPreset_0;

		// Token: 0x04000D2C RID: 3372
		private bool bool_12;

		// Token: 0x04000D2D RID: 3373
		public float? nullable_0;

		// Token: 0x04000D2E RID: 3374
		public float float_1;

		// Token: 0x04000D2F RID: 3375
		public float? nullable_1;

		// Token: 0x04000D30 RID: 3376
		public float? nullable_2;

		// Token: 0x04000D31 RID: 3377
		private float? nullable_3;

		// Token: 0x04000D32 RID: 3378
		private bool bool_13;

		// Token: 0x04000D33 RID: 3379
		public bool? nullable_4;

		// Token: 0x04000D34 RID: 3380
		public float? nullable_5;

		// Token: 0x04000D35 RID: 3381
		public bool? nullable_6;

		// Token: 0x04000D36 RID: 3382
		public Waypoint.Enum80 enum80_0;

		// Token: 0x04000D37 RID: 3383
		public DateTime? nullable_7;

		// Token: 0x04000D38 RID: 3384
		public DateTime? nullable_8;

		// Token: 0x04000D39 RID: 3385
		public DateTime? nullable_9;

		// Token: 0x04000D3A RID: 3386
		public DateTime? nullable_10;

		// Token: 0x04000D3B RID: 3387
		public Weather.TTimeOfDayType ttimeOfDayType_0;

		// Token: 0x04000D3C RID: 3388
		public Waypoint.Enum82 enum82_0;

		// Token: 0x04000D3D RID: 3389
		public Waypoint.Enum82 enum82_1;

		// Token: 0x04000D3E RID: 3390
		public Waypoint.Enum84 enum84_0;

		// Token: 0x04000D3F RID: 3391
		public Waypoint.Enum83 enum83_0;

		// Token: 0x04000D40 RID: 3392
		public float float_2;

		// Token: 0x04000D41 RID: 3393
		public float float_3;

		// Token: 0x04000D42 RID: 3394
		public float float_4;

		// Token: 0x04000D43 RID: 3395
		public float float_5;

		// Token: 0x04000D44 RID: 3396
		public float float_6;

		// Token: 0x04000D45 RID: 3397
		public float float_7;

		// Token: 0x04000D46 RID: 3398
		public float float_8;

		// Token: 0x04000D47 RID: 3399
		public float float_9;

		// Token: 0x04000D48 RID: 3400
		public float float_10;

		// Token: 0x04000D49 RID: 3401
		public float float_11;

		// Token: 0x04000D4A RID: 3402
		public float float_12;

		// Token: 0x04000D4B RID: 3403
		public float float_13;

		// Token: 0x04000D4C RID: 3404
		public bool bool_14;

		// Token: 0x04000D4D RID: 3405
		public bool bool_15;

		// Token: 0x04000D4E RID: 3406
		public Waypoint waypoint_0;

		// Token: 0x04000D4F RID: 3407
		public Waypoint waypoint_1;

		// Token: 0x04000D50 RID: 3408
		public Waypoint waypoint_2;

		// Token: 0x04000D51 RID: 3409
		public Waypoint waypoint_3;

		// Token: 0x04000D52 RID: 3410
		public Waypoint waypoint_4;

		// Token: 0x04000D53 RID: 3411
		public float float_14;

		// Token: 0x04000D54 RID: 3412
		public float float_15;

		// Token: 0x04000D55 RID: 3413
		public float float_16;

		// Token: 0x04000D56 RID: 3414
		public float float_17;

		// Token: 0x04000D57 RID: 3415
		public float float_18;

		// Token: 0x04000D58 RID: 3416
		public float float_19;

		// Token: 0x04000D59 RID: 3417
		public float float_20;

		// Token: 0x04000D5A RID: 3418
		public float float_21;

		// Token: 0x04000D5B RID: 3419
		public float float_22;

		// Token: 0x04000D5C RID: 3420
		public float float_23;

		// Token: 0x04000D5D RID: 3421
		public float float_24;

		// Token: 0x04000D5E RID: 3422
		public float float_25;

		// Token: 0x04000D5F RID: 3423
		public float float_26;

		// Token: 0x04000D60 RID: 3424
		public float float_27;

		// Token: 0x04000D61 RID: 3425
		public Mission.Enum94 enum94_0;

		// Token: 0x04000D62 RID: 3426
		public Waypoint.Enum81 enum81_0;

		// Token: 0x04000D63 RID: 3427
		public Mission.TankerMethod tankerMethod_0;

		// Token: 0x04000D64 RID: 3428
		public List<string> list_0;

		// Token: 0x04000D65 RID: 3429
		public List<Mission> list_1;

		// Token: 0x04000D66 RID: 3430
		public int int_0;

		// Token: 0x04000D67 RID: 3431
		public int int_1;

		// Token: 0x04000D68 RID: 3432
		public bool bool_16;

		// Token: 0x04000D69 RID: 3433
		public int int_2;

		// Token: 0x04000D6A RID: 3434
		public List<Waypoint.Class281> list_2;

		// Token: 0x04000D6B RID: 3435
		public GeoPoint geoPoint_0;

		// Token: 0x04000D6C RID: 3436
		public int int_3;

		// Token: 0x04000D6D RID: 3437
		public string string_3;

		// Token: 0x04000D6E RID: 3438
		public float float_28;

		// Token: 0x04000D6F RID: 3439
		public float float_29;

		// Token: 0x04000D70 RID: 3440
		public float float_30;

		// Token: 0x04000D71 RID: 3441
		public Mission.Enum105 enum105_0;

		// Token: 0x04000D72 RID: 3442
		public List<Mission.Class288> list_3;

		// Token: 0x04000D73 RID: 3443
		public List<Mission.Class288> list_4;

		// Token: 0x04000D74 RID: 3444
		public List<Mission.Class288> list_5;

		// Token: 0x04000D75 RID: 3445
		public List<Mission.Class288> list_6;

		// Token: 0x04000D76 RID: 3446
		public List<Mission.Class288> list_7;

		// Token: 0x04000D77 RID: 3447
		public List<Mission.Class288> list_8;

		// Token: 0x04000D78 RID: 3448
		public List<Mission.Class289> list_9;

		// Token: 0x04000D79 RID: 3449
		public List<Mission.Class289> list_10;

		// Token: 0x04000D7A RID: 3450
		public List<Mission.Class289> list_11;

		// Token: 0x04000D7B RID: 3451
		public List<Mission.Class289> list_12;

		// Token: 0x04000D7C RID: 3452
		public List<Mission.Class289> list_13;

		// Token: 0x04000D7D RID: 3453
		public List<Mission.Class289> list_14;

		// Token: 0x04000D7E RID: 3454
		private Doctrine doctrine_0;

		// Token: 0x02000262 RID: 610
		internal sealed class Class281
		{
			// Token: 0x060012D0 RID: 4816 RVA: 0x0000AB18 File Offset: 0x00008D18
			public Class281(ref double double_4, double double_5, double double_6, double double_7)
			{
				this.double_0 = double_4;
				this.double_1 = double_5;
				this.double_2 = double_6;
				this.double_3 = double_7;
			}

			// Token: 0x060012D1 RID: 4817 RVA: 0x00002977 File Offset: 0x00000B77
			public Class281()
			{
			}

			// Token: 0x04000D7F RID: 3455
			public double double_0;

			// Token: 0x04000D80 RID: 3456
			public double double_1;

			// Token: 0x04000D81 RID: 3457
			public double double_2;

			// Token: 0x04000D82 RID: 3458
			public double double_3;
		}

		// Token: 0x02000263 RID: 611
		public enum WaypointType
		{
			// Token: 0x04000D84 RID: 3460
			ManualPlottedCourseWaypoint,
			// Token: 0x04000D85 RID: 3461
			PatrolStation,
			// Token: 0x04000D86 RID: 3462
			TerminalPoint,
			// Token: 0x04000D87 RID: 3463
			LocalizationRun,
			// Token: 0x04000D88 RID: 3464
			PathfindingPoint,
			// Token: 0x04000D89 RID: 3465
			Assemble,
			// Token: 0x04000D8A RID: 3466
			TurningPoint,
			// Token: 0x04000D8B RID: 3467
			InitialPoint,
			// Token: 0x04000D8C RID: 3468
			Split,
			// Token: 0x04000D8D RID: 3469
			Formate,
			// Token: 0x04000D8E RID: 3470
			Target,
			// Token: 0x04000D8F RID: 3471
			LandingMarshal,
			// Token: 0x04000D90 RID: 3472
			StrikeIngress,
			// Token: 0x04000D91 RID: 3473
			StrikeEgress,
			// Token: 0x04000D92 RID: 3474
			Refuel,
			// Token: 0x04000D93 RID: 3475
			TakeOff,
			// Token: 0x04000D94 RID: 3476
			Marshal,
			// Token: 0x04000D95 RID: 3477
			WeaponLaunch,
			// Token: 0x04000D96 RID: 3478
			Land,
			// Token: 0x04000D97 RID: 3479
			WeaponTarget,
			// Token: 0x04000D98 RID: 3480
			StationStart_Racetrack,
			// Token: 0x04000D99 RID: 3481
			StationStart_FigureEight,
			// Token: 0x04000D9A RID: 3482
			StationStart_Area,
			// Token: 0x04000D9B RID: 3483
			StationStart_RaceTrackRandom,
			// Token: 0x04000D9C RID: 3484
			StationEnd,
			// Token: 0x04000D9D RID: 3485
			PickupPoint,
			// Token: 0x04000D9E RID: 3486
			HoldStart,
			// Token: 0x04000D9F RID: 3487
			HoldEnd,
			// Token: 0x04000DA0 RID: 3488
			Launch,
			// Token: 0x04000DA1 RID: 3489
			Activation,
			// Token: 0x04000DA2 RID: 3490
			Termination
		}

		// Token: 0x02000264 RID: 612
		internal enum Enum79
		{
			// Token: 0x04000DA4 RID: 3492
			const_0,
			// Token: 0x04000DA5 RID: 3493
			const_1,
			// Token: 0x04000DA6 RID: 3494
			const_2
		}

		// Token: 0x02000265 RID: 613
		internal enum Enum80 : byte
		{
			// Token: 0x04000DA8 RID: 3496
			const_0,
			// Token: 0x04000DA9 RID: 3497
			const_1,
			// Token: 0x04000DAA RID: 3498
			const_2,
			// Token: 0x04000DAB RID: 3499
			const_3
		}

		// Token: 0x02000266 RID: 614
		internal enum Enum81 : byte
		{
			// Token: 0x04000DAD RID: 3501
			const_0,
			// Token: 0x04000DAE RID: 3502
			const_1,
			// Token: 0x04000DAF RID: 3503
			const_2,
			// Token: 0x04000DB0 RID: 3504
			const_3,
			// Token: 0x04000DB1 RID: 3505
			const_4,
			// Token: 0x04000DB2 RID: 3506
			const_5,
			// Token: 0x04000DB3 RID: 3507
			const_6
		}

		// Token: 0x02000267 RID: 615
		internal enum Enum82
		{
			// Token: 0x04000DB5 RID: 3509
			const_0,
			// Token: 0x04000DB6 RID: 3510
			const_1,
			// Token: 0x04000DB7 RID: 3511
			const_2,
			// Token: 0x04000DB8 RID: 3512
			const_3,
			// Token: 0x04000DB9 RID: 3513
			const_4
		}

		// Token: 0x02000268 RID: 616
		internal enum Enum83
		{
			// Token: 0x04000DBB RID: 3515
			const_0,
			// Token: 0x04000DBC RID: 3516
			const_1,
			// Token: 0x04000DBD RID: 3517
			const_2 = 100
		}

		// Token: 0x02000269 RID: 617
		internal enum Enum84
		{
			// Token: 0x04000DBF RID: 3519
			const_0,
			// Token: 0x04000DC0 RID: 3520
			const_1,
			// Token: 0x04000DC1 RID: 3521
			const_2,
			// Token: 0x04000DC2 RID: 3522
			const_3
		}
	}
}
