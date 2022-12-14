using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using DarkUI.Collections;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns13;
using ns14;
using ns8;

namespace Command_Core
{
	// Token: 0x0200026F RID: 623
	public sealed class Group : ActiveUnit
	{
		// Token: 0x060012E6 RID: 4838 RVA: 0x0000AB88 File Offset: 0x00008D88
		[CompilerGenerated]
		public ObservableList<Class343> vmethod_139()
		{
			return this.observableList_2;
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00170068 File Offset: 0x0016E268
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_140(ObservableList<Class343> observableList_3)
		{
			EventHandler<EventArgs5<Class343>> eventHandler_ = new EventHandler<EventArgs5<Class343>>(this.method_157);
			EventHandler<EventArgs5<Class343>> eventHandler_2 = new EventHandler<EventArgs5<Class343>>(this.method_158);
			ObservableList<Class343> observableList = this.observableList_2;
			if (observableList != null)
			{
				observableList.method_1(eventHandler_);
				observableList.method_3(eventHandler_2);
			}
			this.observableList_2 = observableList_3;
			observableList = this.observableList_2;
			if (observableList != null)
			{
				observableList.method_0(eventHandler_);
				observableList.method_2(eventHandler_2);
			}
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0000AB90 File Offset: 0x00008D90
		[CompilerGenerated]
		public ObservableDictionary<string, ActiveUnit> vmethod_141()
		{
			return this.observableDictionary_0;
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x001700C8 File Offset: 0x0016E2C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_142(ObservableDictionary<string, ActiveUnit> observableDictionary_1)
		{
			INotifyDictionaryChanged<string, ActiveUnit>.DictionaryChangedEventHandler obj = new INotifyDictionaryChanged<string, ActiveUnit>.DictionaryChangedEventHandler(this.method_156);
			ObservableDictionary<string, ActiveUnit> observableDictionary = this.observableDictionary_0;
			if (observableDictionary != null)
			{
				observableDictionary.DictionaryChanged -= obj;
			}
			this.observableDictionary_0 = observableDictionary_1;
			observableDictionary = this.observableDictionary_0;
			if (observableDictionary != null)
			{
				observableDictionary.DictionaryChanged += obj;
			}
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0017010C File Offset: 0x0016E30C
		[CompilerGenerated]
		public static void smethod_10(Group.Delegate32 delegate32_1)
		{
			Group.Delegate32 @delegate = Group.delegate32_0;
			Group.Delegate32 delegate2;
			do
			{
				delegate2 = @delegate;
				Group.Delegate32 value = (Group.Delegate32)Delegate.Combine(delegate2, delegate32_1);
				@delegate = Interlocked.CompareExchange<Group.Delegate32>(ref Group.delegate32_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00170140 File Offset: 0x0016E340
		[CompilerGenerated]
		public static void smethod_11(Group.Delegate32 delegate32_1)
		{
			Group.Delegate32 @delegate = Group.delegate32_0;
			Group.Delegate32 delegate2;
			do
			{
				delegate2 = @delegate;
				Group.Delegate32 value = (Group.Delegate32)Delegate.Remove(delegate2, delegate32_1);
				@delegate = Interlocked.CompareExchange<Group.Delegate32>(ref Group.delegate32_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00170174 File Offset: 0x0016E374
		[CompilerGenerated]
		public static void smethod_12(Group.Delegate33 delegate33_1)
		{
			Group.Delegate33 @delegate = Group.delegate33_0;
			Group.Delegate33 delegate2;
			do
			{
				delegate2 = @delegate;
				Group.Delegate33 value = (Group.Delegate33)Delegate.Combine(delegate2, delegate33_1);
				@delegate = Interlocked.CompareExchange<Group.Delegate33>(ref Group.delegate33_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x001701A8 File Offset: 0x0016E3A8
		[CompilerGenerated]
		public static void smethod_13(Group.Delegate33 delegate33_1)
		{
			Group.Delegate33 @delegate = Group.delegate33_0;
			Group.Delegate33 delegate2;
			do
			{
				delegate2 = @delegate;
				Group.Delegate33 value = (Group.Delegate33)Delegate.Remove(delegate2, delegate33_1);
				@delegate = Interlocked.CompareExchange<Group.Delegate33>(ref Group.delegate33_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x001701DC File Offset: 0x0016E3DC
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Group");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				if (hashSet_0.Contains(this.string_0))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(this.string_0);
					xmlWriter_0.WriteElementString("Name", this.Name);
					if (!Information.IsNothing(this.nullable_16))
					{
						xmlWriter_0.WriteElementString("Type", ((int)this.nullable_16.Value).ToString());
					}
					xmlWriter_0.WriteElementString("CurrentHeading", XmlConvert.ToString(this.vmethod_9()));
					xmlWriter_0.WriteElementString("CurrentSpeed", XmlConvert.ToString(this.vmethod_40()));
					xmlWriter_0.WriteElementString("CurrentAltitude", XmlConvert.ToString(this.vmethod_14(false)));
					xmlWriter_0.WriteElementString("Longitude", XmlConvert.ToString(this.vmethod_28(null)));
					xmlWriter_0.WriteElementString("Latitude", XmlConvert.ToString(this.vmethod_30(null)));
					xmlWriter_0.WriteElementString("UnitClass", this.string_2);
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
					xmlWriter_0.WriteElementString("Side", this.vmethod_7(false).method_51());
					xmlWriter_0.WriteElementString("Message", this.string_3);
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
					xmlWriter_0.WriteElementString("DesiredHeading", XmlConvert.ToString(this.vmethod_68()));
					xmlWriter_0.WriteElementString("DesiredSpeed", XmlConvert.ToString(this.vmethod_70()));
					xmlWriter_0.WriteElementString("DesiredAltitude", XmlConvert.ToString(this.vmethod_72()));
					xmlWriter_0.WriteElementString("DesiredTurnRate", ((byte)this.vmethod_78()).ToString());
					xmlWriter_0.WriteElementString("DesiredTurnRate_Navigation", ((byte)this.vmethod_80()).ToString());
					xmlWriter_0.WriteElementString("Weight", XmlConvert.ToString(this.int_0));
					xmlWriter_0.WriteElementString("ThrottleSetting", ((byte)this.vmethod_84()).ToString());
					this.doctrine_0.method_282(ref xmlWriter_0, ref this.scenario_0, "Doctrine");
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
					xmlWriter_0.WriteStartElement("Mounts");
					try
					{
						foreach (Mount mount in this.vmethod_51())
						{
							if (Information.IsNothing(mount.method_18()))
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
					if (!Information.IsNothing(this.nullable_13))
					{
						xmlWriter_0.WriteElementString("AMP_OC_DSO", this.nullable_13.ToString());
					}
					xmlWriter_0.WriteElementString("AMP_OC_DAO", this.bool_18.ToString());
					xmlWriter_0.WriteElementString("AMP_OC_Speed", XmlConvert.ToString(this.float_16));
					xmlWriter_0.WriteElementString("DamagePts", XmlConvert.ToString(this.vmethod_63(false, null)));
					xmlWriter_0.WriteStartElement("AirFacilities");
					foreach (AirFacility airFacility in this.airFacility_0)
					{
						xmlWriter_0.WriteRaw(airFacility.method_23(hashSet_0));
					}
					xmlWriter_0.WriteEndElement();
					this.vmethod_85().vmethod_0(ref xmlWriter_0, ref hashSet_0);
					xmlWriter_0.WriteStartElement("Group_AI");
					this.vmethod_86().vmethod_2(ref xmlWriter_0, ref hashSet_0);
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteStartElement("Group_Kinematics");
					this.method_145().vmethod_0(ref xmlWriter_0);
					xmlWriter_0.WriteEndElement();
					this.vmethod_88().vmethod_2(ref xmlWriter_0);
					this.vmethod_89().vmethod_2(ref xmlWriter_0, ref hashSet_0);
					xmlWriter_0.WriteStartElement("Group_CommStuff");
					this.vmethod_90().vmethod_0(ref xmlWriter_0, ref hashSet_0);
					xmlWriter_0.WriteEndElement();
					this.vmethod_92().vmethod_0(ref xmlWriter_0, ref hashSet_0);
					xmlWriter_0.WriteElementString("Type", ((int)this.method_143()).ToString());
					xmlWriter_0.WriteStartElement("Center");
					xmlWriter_0.WriteRaw(this.geoPoint_0.method_8(hashSet_0));
					xmlWriter_0.WriteEndElement();
					if (!Information.IsNothing(this.method_147()))
					{
						xmlWriter_0.WriteStartElement("GroupLead");
						this.method_147().vmethod_4(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteStartElement("Patrols");
					try
					{
						foreach (Class343 @class in this.vmethod_139())
						{
							@class.vmethod_4(ref xmlWriter_0, ref hashSet_0, ref this.scenario_0);
						}
					}
					finally
					{
						List<Class343>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100589", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00170BFC File Offset: 0x0016EDFC
		private Group()
		{
			this.geoPoint_0 = new GeoPoint();
			this.vmethod_140(new ObservableList<Class343>());
			ActiveUnit activeUnit = this;
			this.class213_0 = new Class213(ref activeUnit);
			activeUnit = this;
			this.class167_0 = new Class167(ref activeUnit);
			activeUnit = this;
			this.class220_0 = new Class220(ref activeUnit);
			activeUnit = this;
			this.class227_0 = new Class227(ref activeUnit);
			activeUnit = this;
			this.class182_0 = new Class182(ref activeUnit);
			activeUnit = this;
			this.class179_0 = new Class179(ref activeUnit);
			this.vmethod_142(new ObservableDictionary<string, ActiveUnit>());
			this.bool_1 = true;
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00170C94 File Offset: 0x0016EE94
		public static Group smethod_14(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_1)
		{
			Group result;
			try
			{
				Group group = new Group();
				group.scenario_0 = scenario_1;
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 2066337159U)
						{
							if (num <= 1305748348U)
							{
								if (num <= 441941816U)
								{
									if (num <= 74041507U)
									{
										if (num != 6222351U)
										{
											if (num == 74041507U)
											{
												if (Operators.CompareString(name, "Group_Kinematics", false) == 0)
												{
													Group group2 = group;
													ActiveUnit activeUnit = group;
													group2.group_Kinematics_0 = Group_Kinematics.smethod_5(ref xmlNode, ref dictionary_0, ref activeUnit);
												}
											}
										}
										else if (Operators.CompareString(name, "Status", false) == 0)
										{
											if (Versioned.IsNumeric(xmlNode.InnerText))
											{
												group.vmethod_109((ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode.InnerText));
											}
											else
											{
												group.vmethod_109((ActiveUnit._ActiveUnitStatus)Enum.Parse(typeof(ActiveUnit._ActiveUnitStatus), xmlNode.InnerText, true));
											}
										}
									}
									else if (num != 266367750U)
									{
										if (num != 429749699U)
										{
											if (num == 441941816U)
											{
												if (Operators.CompareString(name, "CurrentAltitude", false) == 0)
												{
													group.vmethod_15(false, XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
												}
											}
										}
										else if (Operators.CompareString(name, "DesiredTurnRate_Navigation", false) == 0)
										{
											group.vmethod_81((Waypoint.Enum81)Conversions.ToByte(xmlNode.InnerText));
										}
									}
									else if (Operators.CompareString(name, "Name", false) == 0)
									{
										group.Name = xmlNode.InnerText;
									}
								}
								else if (num <= 892023141U)
								{
									if (num != 664498478U)
									{
										if (num != 803760973U)
										{
											if (num == 892023141U)
											{
												if (Operators.CompareString(name, "DesiredHeading", false) == 0)
												{
													group.float_9 = XmlConvert.ToSingle(xmlNode.InnerText);
												}
											}
										}
										else if (Operators.CompareString(name, "DamagePts", false) == 0)
										{
											group.vmethod_64(false, null, XmlConvert.ToSingle(xmlNode.InnerText));
										}
									}
									else if (Operators.CompareString(name, "FuelState", false) == 0)
									{
										group._ActiveUnitFuelState_0 = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode.InnerText);
									}
								}
								else if (num != 1255847155U)
								{
									if (num != 1268760228U)
									{
										if (num != 1305748348U)
										{
											continue;
										}
										if (Operators.CompareString(name, "OnboardCargo", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj2 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode2 = (XmlNode)obj2;
												Cargo cargo = Cargo.smethod_2(ref xmlNode2, ref dictionary_0, group);
												Class429.smethod_6(ref group.cargo_0, cargo);
												cargo.method_19(group);
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
									if (Operators.CompareString(name, "Center", false) == 0)
									{
										Group group3 = group;
										XmlNode xmlNode3 = xmlNode.ChildNodes[0];
										group3.geoPoint_0 = GeoPoint.smethod_0(ref xmlNode3, ref dictionary_0);
									}
								}
								else if (Operators.CompareString(name, "ThrottleSetting", false) == 0)
								{
									string innerText2 = xmlNode.InnerText;
									if (Operators.CompareString(innerText2, "FullStop", false) != 0)
									{
										if (Operators.CompareString(innerText2, "Loiter", false) != 0)
										{
											if (Operators.CompareString(innerText2, "Cruise", false) != 0)
											{
												if (Operators.CompareString(innerText2, "Full", false) != 0)
												{
													if (Operators.CompareString(innerText2, "Flank", false) != 0)
													{
														group.throttle_0 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
													}
													else
													{
														group.throttle_0 = ActiveUnit.Throttle.Flank;
													}
												}
												else
												{
													group.throttle_0 = ActiveUnit.Throttle.Full;
												}
											}
											else
											{
												group.throttle_0 = ActiveUnit.Throttle.Cruise;
											}
										}
										else
										{
											group.throttle_0 = ActiveUnit.Throttle.Loiter;
										}
									}
									else
									{
										group.throttle_0 = ActiveUnit.Throttle.FullStop;
									}
								}
							}
							else if (num <= 1729717486U)
							{
								if (num <= 1422437055U)
								{
									if (num != 1339890663U)
									{
										if (num != 1422437055U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Doctrine", false) == 0)
										{
											group.doctrine_0 = Doctrine.smethod_9(ref xmlNode, group);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "ActiveEnterAreaTriggers", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj3 in xmlNode.ChildNodes)
											{
												string innerText3 = ((XmlNode)obj3).InnerText;
												group.list_0.Add(innerText3);
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
								if (num != 1458105184U)
								{
									if (num != 1476905714U)
									{
										if (num == 1729717486U)
										{
											if (Operators.CompareString(name, "Longitude", false) == 0)
											{
												group.vmethod_29(null, XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", ".")));
											}
										}
									}
									else if (Operators.CompareString(name, "WeaponState", false) == 0)
									{
										group._ActiveUnitWeaponState_0 = (ActiveUnit._ActiveUnitWeaponState)Conversions.ToByte(xmlNode.InnerText);
									}
								}
								else if (Operators.CompareString(name, "ID", false) == 0)
								{
									if (dictionary_0.ContainsKey(xmlNode.InnerText))
									{
										return (Group)dictionary_0[xmlNode.InnerText];
									}
									group.vmethod_0(xmlNode.InnerText);
									if (xmlNode_0.ChildNodes.Count == 1)
									{
										scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
										return group;
									}
									dictionary_0.Add(group.string_0, group);
								}
							}
							else if (num <= 1883345757U)
							{
								if (num != 1836990821U)
								{
									if (num != 1848783177U)
									{
										if (num == 1883345757U)
										{
											if (Operators.CompareString(name, "Group_AirOps", false) == 0)
											{
												Group group4 = group;
												ActiveUnit activeUnit = group;
												group4.class179_0 = Class179.smethod_1(ref xmlNode, ref dictionary_0, ref activeUnit);
											}
										}
									}
									else if (Operators.CompareString(name, "UnitClass", false) == 0)
									{
										group.string_2 = xmlNode.InnerText;
									}
								}
								else if (Operators.CompareString(name, "Latitude", false) == 0)
								{
									group.vmethod_31(null, XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", ".")));
								}
							}
							else
							{
								if (num != 1992083866U)
								{
									if (num != 2008421230U)
									{
										if (num != 2066337159U)
										{
											continue;
										}
										if (Operators.CompareString(name, "DesiredAltitude", false) == 0)
										{
											group.float_11 = XmlConvert.ToSingle(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Comms", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj4 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode4 = (XmlNode)obj4;
												CommDevice commDevice = CommDevice.smethod_2(ref xmlNode4, ref dictionary_0, group);
												group.method_101(commDevice);
												commDevice.method_19(group);
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
								}
								if (Operators.CompareString(name, "Latitude_UnitEntersAreaCheck", false) == 0)
								{
									group.vmethod_39(new double?(XmlConvert.ToDouble(xmlNode.InnerText)));
								}
							}
						}
						else if (num <= 3283119613U)
						{
							if (num <= 2570065113U)
							{
								if (num <= 2246682072U)
								{
									if (num != 2187602126U)
									{
										if (num != 2246682072U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Propulsion", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj5 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode5 = (XmlNode)obj5;
												ActiveUnit activeUnit = group;
												Engine engine = Engine.smethod_2(ref xmlNode5, ref dictionary_0, ref activeUnit);
												group.vmethod_49().method_4(engine);
												engine.method_19(group);
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
									if (Operators.CompareString(name, "DBID", false) == 0)
									{
										group.DBID = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (num != 2424405304U)
									{
										if (num != 2496321123U)
										{
											if (num != 2570065113U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Weight", false) == 0)
											{
												group.int_0 = XmlConvert.ToInt32(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "RangeSymbols", false) != 0)
											{
												continue;
											}
											try
											{
												foreach (object obj6 in xmlNode.ChildNodes)
												{
													RangeSymbol item = RangeSymbol.smethod_0((XmlNode)obj6, dictionary_0);
													group.method_17().Add(item);
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
									if (Operators.CompareString(name, "Sensors", false) != 0)
									{
										continue;
									}
									try
									{
										foreach (object obj7 in xmlNode.ChildNodes)
										{
											Sensor sensor = Sensor.smethod_2((XmlNode)obj7, dictionary_0, group);
											Class429.smethod_24(ref group.sensor_0, sensor);
											sensor.method_19(group);
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
							if (num <= 2749693904U)
							{
								if (num != 2590053246U)
								{
									if (num != 2694467229U)
									{
										if (num == 2749693904U)
										{
											if (Operators.CompareString(name, "DesiredSpeed", false) == 0)
											{
												group.float_10 = XmlConvert.ToSingle(xmlNode.InnerText);
											}
										}
									}
									else if (Operators.CompareString(name, "Group_CommStuff", false) == 0)
									{
										Group group5 = group;
										ActiveUnit activeUnit = group;
										group5.class182_0 = Class182.smethod_1(ref xmlNode, ref dictionary_0, ref activeUnit);
									}
								}
								else if (Operators.CompareString(name, "Side", false) == 0)
								{
									group.string_7 = xmlNode.InnerText;
									foreach (Side side in scenario_1.method_44())
									{
										if (Operators.CompareString(side.method_51(), group.string_7, false) == 0)
										{
											group.vmethod_8(false, side);
										}
									}
								}
							}
							else if (num != 2824222426U)
							{
								if (num != 2920208772U)
								{
									if (num == 3283119613U)
									{
										if (Operators.CompareString(name, "CurrentSpeed", false) == 0)
										{
											group.vmethod_41(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										}
									}
								}
								else if (Operators.CompareString(name, "Message", false) == 0)
								{
									group.string_3 = xmlNode.InnerText;
								}
							}
							else if (Operators.CompareString(name, "Group_Sensory", false) == 0)
							{
								Group group6 = group;
								ActiveUnit activeUnit = group;
								group6.class220_0 = Class220.smethod_10(ref xmlNode, ref dictionary_0, ref activeUnit);
							}
						}
						else if (num <= 3544932644U)
						{
							if (num <= 3370184216U)
							{
								if (num != 3315194562U)
								{
									if (num == 3370184216U)
									{
										if (Operators.CompareString(name, "DesiredTurnRate", false) == 0)
										{
											group.vmethod_79((ActiveUnit.Enum28)Conversions.ToByte(xmlNode.InnerText));
										}
									}
								}
								else if (Operators.CompareString(name, "Group_Navigator", false) == 0)
								{
									Group group7 = group;
									ActiveUnit activeUnit = group;
									group7.class213_0 = Class213.smethod_8(ref xmlNode, ref dictionary_0, ref activeUnit);
								}
							}
							else if (num != 3474221763U)
							{
								if (num != 3512062061U)
								{
									if (num == 3544932644U)
									{
										if (Operators.CompareString(name, "Group_Weaponry", false) == 0)
										{
											Group group8 = group;
											ActiveUnit activeUnit = group;
											group8.class227_0 = Class227.smethod_6(ref xmlNode, ref dictionary_0, ref activeUnit);
										}
									}
								}
								else if (Operators.CompareString(name, "Type", false) == 0)
								{
									group.nullable_16 = new Group.GroupType?((Group.GroupType)Conversions.ToByte(xmlNode.InnerText));
								}
							}
							else if (Operators.CompareString(name, "Group_AI", false) == 0)
							{
								Group group9 = group;
								ActiveUnit activeUnit = group;
								group9.class167_0 = Class167.smethod_1(ref xmlNode, ref dictionary_0, ref activeUnit);
							}
						}
						else
						{
							if (num <= 3989581338U)
							{
								if (num != 3760177291U)
								{
									if (num != 3792306253U)
									{
										if (num != 3989581338U)
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
												XmlNode xmlNode6 = (XmlNode)obj8;
												AirFacility airFacility = AirFacility.smethod_3(ref xmlNode6, ref dictionary_0, ref scenario_1);
												group.method_103(airFacility);
												airFacility.method_19(group);
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
									if (Operators.CompareString(name, "Longitude_UnitEntersAreaCheck", false) == 0)
									{
										group.vmethod_37(new double?(XmlConvert.ToDouble(xmlNode.InnerText)));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Mounts", false) != 0)
									{
										continue;
									}
									try
									{
										foreach (object obj9 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode7 = (XmlNode)obj9;
											Mount mount = Mount.smethod_6(ref xmlNode7, ref dictionary_0, group);
											group.vmethod_51().method_4(mount);
											mount.method_19(group);
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
							}
							if (num != 4077412634U)
							{
								if (num != 4152621540U)
								{
									if (num != 4239247960U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Patrols", false) != 0)
									{
										continue;
									}
									try
									{
										foreach (object obj10 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode8 = (XmlNode)obj10;
											Class343 gparam_ = Class343.smethod_10(ref xmlNode8, ref dictionary_0, ref scenario_1);
											group.vmethod_139().method_4(gparam_);
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
								if (Operators.CompareString(name, "CurrentHeading", false) == 0)
								{
									group.vmethod_10(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
								}
							}
							else if (Operators.CompareString(name, "GroupLead", false) == 0 && xmlNode.HasChildNodes)
							{
								Group group10 = group;
								XmlNode xmlNode3 = xmlNode.ChildNodes[0];
								group10.activeUnit_0 = ActiveUnit.smethod_9(ref xmlNode3, ref dictionary_0, ref scenario_1);
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
				if (group.method_143() == Group.GroupType.AirGroup && group.throttle_0 == ActiveUnit.Throttle.FullStop)
				{
					group.throttle_0 = ActiveUnit.Throttle.Cruise;
				}
				result = group;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100590", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Group();
			}
			return result;
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0000AB98 File Offset: 0x00008D98
		public override GlobalVariables.ProficiencyLevel? vmethod_53()
		{
			return base.vmethod_53();
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00171C58 File Offset: 0x0016FE58
		public override void vmethod_54(GlobalVariables.ProficiencyLevel? nullable_17)
		{
			try
			{
				foreach (ActiveUnit activeUnit in this.vmethod_141().Values)
				{
					activeUnit.vmethod_54(nullable_17);
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

		// Token: 0x060012F3 RID: 4851 RVA: 0x00171CA8 File Offset: 0x0016FEA8
		public override ActiveUnit._ActiveUnitStatus vmethod_108()
		{
			ActiveUnit._ActiveUnitStatus result;
			if (!Information.IsNothing(this.method_147()))
			{
				result = this.method_147().vmethod_108();
			}
			else
			{
				result = ActiveUnit._ActiveUnitStatus.Unassigned;
			}
			return result;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0000ABA0 File Offset: 0x00008DA0
		public override void vmethod_109(ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_6)
		{
			if (!Information.IsNothing(this.method_147()))
			{
				this.method_147().vmethod_109(_ActiveUnitStatus_6);
			}
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0000ABBB File Offset: 0x00008DBB
		public override string vmethod_58()
		{
			return this.method_144();
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00171CD4 File Offset: 0x0016FED4
		public override double vmethod_28(bool? _HintIsOperating = null)
		{
			double result;
			if (!Information.IsNothing(this.method_147()))
			{
				result = this.method_147().vmethod_28(null);
			}
			else
			{
				result = base.vmethod_28(null);
			}
			return result;
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00171D18 File Offset: 0x0016FF18
		public override void vmethod_29(bool? _HintIsOperating = null, double value)
		{
			if (!Information.IsNothing(this.method_147()))
			{
				this.method_147().vmethod_29(null, value);
				return;
			}
			base.vmethod_29(null, value);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00171D58 File Offset: 0x0016FF58
		public override double vmethod_30(bool? _HintIsOperating = null)
		{
			double result;
			if (!Information.IsNothing(this.method_147()))
			{
				result = this.method_147().vmethod_30(null);
			}
			else
			{
				result = base.vmethod_30(null);
			}
			return result;
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00171D9C File Offset: 0x0016FF9C
		public override void vmethod_31(bool? _HintIsOperating = null, double value)
		{
			if (!Information.IsNothing(this.method_147()))
			{
				this.method_147().vmethod_31(null, value);
				return;
			}
			base.vmethod_31(null, value);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00171DDC File Offset: 0x0016FFDC
		public override float vmethod_14(bool DoSanityCheck = false)
		{
			float result;
			if (!Information.IsNothing(this.method_147()))
			{
				result = this.method_147().vmethod_14(false);
			}
			else
			{
				result = base.vmethod_14(false);
			}
			return result;
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x0000ABC3 File Offset: 0x00008DC3
		public override void vmethod_15(bool DoSanityCheck = false, float value)
		{
			if (!Information.IsNothing(this.method_147()))
			{
				this.method_147().vmethod_15(false, value);
				return;
			}
			base.vmethod_15(false, value);
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00171E10 File Offset: 0x00170010
		public override float vmethod_13()
		{
			float result;
			if (!Information.IsNothing(this.method_147()))
			{
				result = this.method_147().vmethod_13();
			}
			else
			{
				result = base.vmethod_13();
			}
			return result;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0000ABE8 File Offset: 0x00008DE8
		public override Side vmethod_7(bool SetSideOnly = false)
		{
			if (this.side_0 == null && this.vmethod_141().Count > 0)
			{
				this.side_0 = Enumerable.ElementAtOrDefault<ActiveUnit>(this.vmethod_141().Values, 0).vmethod_7(false);
			}
			return this.side_0;
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00171E40 File Offset: 0x00170040
		public override void vmethod_8(bool SetSideOnly = false, Side value)
		{
			bool flag = value != this.side_0;
			base.vmethod_8(SetSideOnly, value);
			if (flag && !Information.IsNothing(value))
			{
				List<ActiveUnit> list = Enumerable.ToList<ActiveUnit>(this.vmethod_141().Values);
				try
				{
					foreach (ActiveUnit activeUnit in list)
					{
						activeUnit.vmethod_8(SetSideOnly, value);
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00171EBC File Offset: 0x001700BC
		public override float vmethod_9()
		{
			float result;
			if (!Information.IsNothing(this.method_147()))
			{
				result = this.method_147().vmethod_9();
			}
			else
			{
				result = base.vmethod_9();
			}
			return result;
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x0000AC23 File Offset: 0x00008E23
		public override void vmethod_10(float float_25)
		{
			if (!Information.IsNothing(this.method_147()))
			{
				this.method_147().vmethod_10(float_25);
				return;
			}
			base.vmethod_10(float_25);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00171EEC File Offset: 0x001700EC
		public override float vmethod_40()
		{
			float result;
			if (!Information.IsNothing(this.method_147()))
			{
				result = this.method_147().vmethod_40();
			}
			else
			{
				result = base.vmethod_40();
			}
			return result;
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x0000AC46 File Offset: 0x00008E46
		public override void vmethod_41(float float_25)
		{
			if (!Information.IsNothing(this.method_147()))
			{
				this.method_147().vmethod_41(float_25);
				return;
			}
			base.vmethod_41(float_25);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x0000AC69 File Offset: 0x00008E69
		public override ActiveUnit.Throttle vmethod_82()
		{
			return this.method_147().vmethod_82();
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00171F1C File Offset: 0x0017011C
		public bool method_140()
		{
			List<ActiveUnit> list = Enumerable.ToList<ActiveUnit>(this.vmethod_141().Values);
			try
			{
				foreach (ActiveUnit activeUnit in list)
				{
					if (!Information.IsNothing(activeUnit) && activeUnit.method_5())
					{
						return true;
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return false;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00171F8C File Offset: 0x0017018C
		private bool method_141()
		{
			checked
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.vmethod_141().Values)
					{
						if (!Information.IsNothing(activeUnit.vmethod_99()))
						{
							AirFacility[] array = activeUnit.vmethod_99();
							for (int i = 0; i < array.Length; i++)
							{
								if (array[i].method_28() == AirFacility.Enum110.const_1 && activeUnit.method_5())
								{
									return true;
								}
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
				return false;
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0017201C File Offset: 0x0017021C
		private bool method_142()
		{
			try
			{
				foreach (ActiveUnit activeUnit in this.vmethod_141().Values)
				{
					if (!Information.IsNothing(activeUnit.vmethod_100()) && activeUnit.method_5() && activeUnit.vmethod_100().Length > 0)
					{
						return true;
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
			return false;
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00172090 File Offset: 0x00170290
		public Group.GroupType method_143()
		{
			Group.GroupType value;
			if (this.nullable_16 != null)
			{
				value = this.nullable_16.Value;
			}
			else
			{
				this.nullable_16 = new Group.GroupType?(this.method_148());
				value = this.nullable_16.Value;
			}
			return value;
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x001720D8 File Offset: 0x001702D8
		public string method_144()
		{
			string result;
			switch (this.method_143())
			{
			case Group.GroupType.AirGroup:
				result = "Air Group";
				break;
			case Group.GroupType.SurfaceGroup:
				result = "Surface Group";
				break;
			case Group.GroupType.SubGroup:
				result = "Underwater Group";
				break;
			case Group.GroupType.Installation:
				result = "Land Installation";
				break;
			case Group.GroupType.MobileGroup:
				result = "Mobile Group";
				break;
			case Group.GroupType.AirBase:
				result = "Airfield";
				break;
			case Group.GroupType.NavalBase:
				result = "Naval Base";
				break;
			default:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = this.method_143().ToString();
				break;
			}
			return result;
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00172168 File Offset: 0x00170368
		public override Mission vmethod_101()
		{
			Mission result;
			if (this.method_147() != null)
			{
				result = this.method_147().vmethod_101();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00172190 File Offset: 0x00170390
		public unsafe override void vmethod_102(Mission value, bool SetMissionOnly, ref Mission.MissionAssignmentAttemptResult Result = Mission.MissionAssignmentAttemptResult*.None)
		{
			try
			{
				foreach (ActiveUnit activeUnit in this.vmethod_141().Values)
				{
					Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
					activeUnit.vmethod_102(value, SetMissionOnly, ref missionAssignmentAttemptResult);
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
			if (this.method_147() != null && this.method_147().vmethod_101() == value)
			{
				Result = Mission.MissionAssignmentAttemptResult.Success;
				return;
			}
			Result = Mission.MissionAssignmentAttemptResult.Fail_Other;
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00172204 File Offset: 0x00170404
		public override Mission vmethod_103()
		{
			Mission result;
			if (!Information.IsNothing(this.method_147()))
			{
				result = this.method_147().vmethod_103();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00172230 File Offset: 0x00170430
		public override void vmethod_104(Mission mission_2)
		{
			try
			{
				foreach (ActiveUnit activeUnit in this.vmethod_141().Values)
				{
					activeUnit.vmethod_104(mission_2);
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

		// Token: 0x0600130D RID: 4877 RVA: 0x0000AC76 File Offset: 0x00008E76
		public override ActiveUnit_Navigator vmethod_85()
		{
			return this.class213_0;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0000AC7E File Offset: 0x00008E7E
		public override ActiveUnit_AI vmethod_86()
		{
			return this.class167_0;
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00172280 File Offset: 0x00170480
		public Group_Kinematics method_145()
		{
			if (Information.IsNothing(this.group_Kinematics_0))
			{
				ActiveUnit activeUnit = this;
				this.group_Kinematics_0 = new Group_Kinematics(ref activeUnit);
			}
			return this.group_Kinematics_0;
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0000AC86 File Offset: 0x00008E86
		public override ActiveUnit_Sensory vmethod_88()
		{
			return this.class220_0;
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0000AC8E File Offset: 0x00008E8E
		public override ActiveUnit_Weaponry vmethod_89()
		{
			return this.class227_0;
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0000AC96 File Offset: 0x00008E96
		public override ActiveUnit_CommStuff vmethod_90()
		{
			return this.class182_0;
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x0000AC9E File Offset: 0x00008E9E
		public override ActiveUnit_AirOps vmethod_92()
		{
			return this.class179_0;
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x001722B0 File Offset: 0x001704B0
		public ActiveUnit_Damage method_146()
		{
			if (Information.IsNothing(this.activeUnit_Damage_0))
			{
				ActiveUnit activeUnit = this;
				this.activeUnit_Damage_0 = new ActiveUnit_Damage(ref activeUnit);
			}
			return this.activeUnit_Damage_0;
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0000ACA6 File Offset: 0x00008EA6
		public ActiveUnit method_147()
		{
			if (Information.IsNothing(this.activeUnit_0))
			{
				this.method_149();
			}
			return this.activeUnit_0;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x001722E0 File Offset: 0x001704E0
		public override float vmethod_68()
		{
			if (Information.IsNothing(this.method_147()))
			{
				this.method_149();
			}
			float result;
			if (Information.IsNothing(this.method_147()))
			{
				result = 0f;
			}
			else
			{
				result = this.method_147().vmethod_68();
			}
			return result;
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0000ACC1 File Offset: 0x00008EC1
		public override void vmethod_69(ActiveUnit.Enum28 enum28_1, float float_25)
		{
			if (Information.IsNothing(this.method_147()))
			{
				this.method_149();
			}
			if (!Information.IsNothing(this.method_147()))
			{
				this.method_147().vmethod_69(enum28_1, float_25);
			}
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00172324 File Offset: 0x00170524
		public override float vmethod_72()
		{
			if (Information.IsNothing(this.method_147()))
			{
				this.method_149();
			}
			float result;
			if (Information.IsNothing(this.method_147()))
			{
				result = 0f;
			}
			else
			{
				result = this.method_147().vmethod_72();
			}
			return result;
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00172368 File Offset: 0x00170568
		public override void vmethod_73(float float_25)
		{
			try
			{
				if (Information.IsNothing(this.method_147()))
				{
					this.method_149();
				}
				if (!Information.IsNothing(this.method_147()))
				{
					this.method_147().vmethod_73(float_25);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100591", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x001723EC File Offset: 0x001705EC
		public override float vmethod_74()
		{
			if (Information.IsNothing(this.method_147()))
			{
				this.method_149();
			}
			float result;
			if (Information.IsNothing(this.method_147()))
			{
				result = 0f;
			}
			else
			{
				result = this.method_147().vmethod_74();
			}
			return result;
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00172430 File Offset: 0x00170630
		public override void vmethod_75(float float_25)
		{
			try
			{
				if (Information.IsNothing(this.method_147()))
				{
					this.method_149();
				}
				if (!Information.IsNothing(this.method_147()))
				{
					this.method_147().vmethod_75(float_25);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101257", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x001724B4 File Offset: 0x001706B4
		public override bool vmethod_76(ActiveUnit activeUnit_1)
		{
			return this.method_143() == Group.GroupType.AirGroup && !Information.IsNothing(this.method_147()) && this.method_147().vmethod_76(this.method_147());
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x001724F0 File Offset: 0x001706F0
		public override void vmethod_77(ActiveUnit activeUnit_1, bool bool_28)
		{
			if (this.method_143() == Group.GroupType.AirGroup && !Information.IsNothing(this.method_147()))
			{
				this.method_147().vmethod_77(this.method_147(), bool_28);
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00172528 File Offset: 0x00170728
		public override float vmethod_70()
		{
			if (Information.IsNothing(this.method_147()))
			{
				this.method_149();
			}
			float result;
			if (Information.IsNothing(this.method_147()))
			{
				result = 0f;
			}
			else
			{
				result = this.method_147().vmethod_70();
			}
			return result;
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0000ACF0 File Offset: 0x00008EF0
		public override void vmethod_71(float float_25)
		{
			if (Information.IsNothing(this.method_147()))
			{
				this.method_149();
			}
			if (!Information.IsNothing(this.method_147()))
			{
				this.method_147().vmethod_71(float_25);
			}
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0017256C File Offset: 0x0017076C
		public override ActiveUnit.Enum28 vmethod_78()
		{
			if (Information.IsNothing(this.method_147()))
			{
				this.method_149();
			}
			ActiveUnit.Enum28 result;
			if (Information.IsNothing(this.method_147()))
			{
				result = ActiveUnit.Enum28.const_0;
			}
			else
			{
				result = this.method_147().vmethod_78();
			}
			return result;
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0000AD1E File Offset: 0x00008F1E
		public override void vmethod_79(ActiveUnit.Enum28 enum28_1)
		{
			if (Information.IsNothing(this.method_147()))
			{
				this.method_149();
			}
			if (!Information.IsNothing(this.method_147()))
			{
				this.method_147().vmethod_79(enum28_1);
			}
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x001725AC File Offset: 0x001707AC
		public override Waypoint.Enum81 vmethod_80()
		{
			if (Information.IsNothing(this.method_147()))
			{
				this.method_149();
			}
			Waypoint.Enum81 result;
			if (Information.IsNothing(this.method_147()))
			{
				result = Waypoint.Enum81.const_0;
			}
			else
			{
				result = this.method_147().vmethod_80();
			}
			return result;
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0000AD4C File Offset: 0x00008F4C
		public override void vmethod_81(Waypoint.Enum81 enum81_1)
		{
			if (Information.IsNothing(this.method_147()))
			{
				this.method_149();
			}
			if (!Information.IsNothing(this.method_147()))
			{
				this.method_147().vmethod_81(enum81_1);
			}
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x001725EC File Offset: 0x001707EC
		public override AirFacility[] vmethod_99()
		{
			AirFacility[] result;
			try
			{
				int num;
				try
				{
					foreach (ActiveUnit activeUnit in this.vmethod_141().Values)
					{
						num += activeUnit.vmethod_99().Length;
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
				AirFacility[] array = new AirFacility[num - 1 + 1];
				num = 0;
				try
				{
					foreach (ActiveUnit activeUnit2 in this.vmethod_141().Values)
					{
						foreach (AirFacility airFacility in activeUnit2.vmethod_99())
						{
							array[num] = airFacility;
							num++;
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
				result = array;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100592", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new AirFacility[0];
			}
			return result;
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0017270C File Offset: 0x0017090C
		public override DockFacility[] vmethod_100()
		{
			DockFacility[] result;
			try
			{
				LinkedList<DockFacility> linkedList = new LinkedList<DockFacility>();
				try
				{
					foreach (ActiveUnit activeUnit in this.vmethod_141().Values)
					{
						foreach (DockFacility dockFacility in activeUnit.vmethod_100())
						{
							linkedList.AddLast(dockFacility);
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
				result = Enumerable.ToArray<DockFacility>(linkedList);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100593", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new DockFacility[0];
			}
			return result;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x001727D8 File Offset: 0x001709D8
		public override Magazine[] vmethod_117()
		{
			Magazine[] result;
			try
			{
				Group.GroupType groupType = this.method_143();
				if (groupType - Group.GroupType.Installation <= 3)
				{
					List<Magazine> list = new List<Magazine>();
					try
					{
						foreach (ActiveUnit activeUnit in this.vmethod_141().Values)
						{
							foreach (Magazine item in ((Class350)activeUnit).magazine_0)
							{
								list.Add(item);
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
					result = list.ToArray();
				}
				else
				{
					result = null;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100594", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x001728B8 File Offset: 0x00170AB8
		public override Sensor[] vmethod_96()
		{
			Sensor[] array = new Sensor[0];
			Sensor[] result;
			try
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.vmethod_141().Values)
					{
						if (!Information.IsNothing(activeUnit))
						{
							Sensor[] expression = activeUnit.method_78();
							if (!Information.IsNothing(expression))
							{
								array = Class429.smethod_27(ref array, ref expression);
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
				result = array;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100595", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0017297C File Offset: 0x00170B7C
		public override ActiveUnit.Throttle vmethod_84()
		{
			ActiveUnit.Throttle throttle_;
			if (this.method_143() == Group.GroupType.AirGroup)
			{
				if (this.throttle_0 == ActiveUnit.Throttle.FullStop)
				{
					this.vmethod_134(ActiveUnit.Throttle.Cruise, null);
				}
				throttle_ = this.throttle_0;
			}
			else
			{
				throttle_ = this.throttle_0;
			}
			return throttle_;
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x001729BC File Offset: 0x00170BBC
		private Group.GroupType method_148()
		{
			Group.GroupType result;
			try
			{
				if (this.vmethod_141().Count == 0)
				{
					result = Group.GroupType.AirGroup;
				}
				else if (this.method_140() && this.method_142())
				{
					result = Group.GroupType.NavalBase;
				}
				else if (this.method_141())
				{
					result = Group.GroupType.AirBase;
				}
				else if (this.method_140())
				{
					result = Group.GroupType.Installation;
				}
				else
				{
					for (int i = this.vmethod_141().Count - 1; i >= 0; i += -1)
					{
						ActiveUnit activeUnit = Enumerable.ElementAtOrDefault<ActiveUnit>(this.vmethod_141().Values, i);
						if (!Information.IsNothing(activeUnit) && activeUnit.bool_6)
						{
							return Group.GroupType.SurfaceGroup;
						}
					}
					for (int j = this.vmethod_141().Count - 1; j >= 0; j += -1)
					{
						ActiveUnit activeUnit = Enumerable.ElementAtOrDefault<ActiveUnit>(this.vmethod_141().Values, j);
						if (!Information.IsNothing(activeUnit) && activeUnit.bool_5)
						{
							return Group.GroupType.SubGroup;
						}
					}
					for (int k = this.vmethod_141().Count - 1; k >= 0; k += -1)
					{
						ActiveUnit activeUnit = Enumerable.ElementAtOrDefault<ActiveUnit>(this.vmethod_141().Values, k);
						if (!Information.IsNothing(activeUnit) && activeUnit.bool_3)
						{
							return Group.GroupType.AirGroup;
						}
					}
					result = Group.GroupType.MobileGroup;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100596", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Group.GroupType.SurfaceGroup;
			}
			return result;
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00172B30 File Offset: 0x00170D30
		public Group(ref Scenario theScen, ref Side theSide, List<ActiveUnit> SelectedUnits, bool UsingMissionPlanner = false, string theGUID = null, Mission theMission = null) : base(ref theScen, theGUID)
		{
			this.geoPoint_0 = new GeoPoint();
			this.vmethod_140(new ObservableList<Class343>());
			ActiveUnit activeUnit = this;
			this.class213_0 = new Class213(ref activeUnit);
			activeUnit = this;
			this.class167_0 = new Class167(ref activeUnit);
			activeUnit = this;
			this.class220_0 = new Class220(ref activeUnit);
			activeUnit = this;
			this.class227_0 = new Class227(ref activeUnit);
			activeUnit = this;
			this.class182_0 = new Class182(ref activeUnit);
			activeUnit = this;
			this.class179_0 = new Class179(ref activeUnit);
			this.vmethod_142(new ObservableDictionary<string, ActiveUnit>());
			this.bool_1 = true;
			try
			{
				this.scenario_0 = theScen;
				theScen.UnitsAutoIncrement++;
				this.vmethod_8(false, theSide);
				this.Name = string.Format("TemporaryGroupName{0}", Guid.NewGuid().ToString());
				if (!Information.IsNothing(SelectedUnits))
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in SelectedUnits)
						{
							if (!activeUnit2.bool_6 || !((Ship)activeUnit2).method_152())
							{
								activeUnit2.vmethod_66(UsingMissionPlanner, this);
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.method_149();
				this.method_145().method_19();
				if (!Information.IsNothing(this.method_147()))
				{
					this.vmethod_71(this.method_147().vmethod_70());
					this.vmethod_69(this.method_147().vmethod_78(), this.method_147().vmethod_68());
					this.vmethod_73(this.method_147().vmethod_72());
					this.vmethod_134(this.method_147().vmethod_84(), null);
				}
				HashSet<Mission> hashSet = new HashSet<Mission>();
				HashSet<Mission.Flight> hashSet2 = new HashSet<Mission.Flight>();
				try
				{
					foreach (ActiveUnit activeUnit3 in this.vmethod_141().Values)
					{
						if (!Information.IsNothing(activeUnit3.vmethod_101()))
						{
							hashSet.Add(activeUnit3.vmethod_101());
							if (!Information.IsNothing(activeUnit3.vmethod_85().method_7()))
							{
								hashSet2.Add(activeUnit3.vmethod_85().method_7());
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
				bool flag = false;
				if (hashSet.Count == 1)
				{
					Mission value = Enumerable.ElementAtOrDefault<Mission>(hashSet, 0);
					bool setMissionOnly = false;
					Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
					this.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
					if (hashSet2.Count > 0 && Enumerable.ElementAtOrDefault<Mission>(hashSet, 0).method_54())
					{
						try
						{
							foreach (Mission.Flight flight in Enumerable.ElementAtOrDefault<Mission>(hashSet, 0).list_1)
							{
								try
								{
									foreach (Mission.Flight flight2 in hashSet2)
									{
										if (flight == flight2)
										{
											flag = true;
											break;
										}
									}
								}
								finally
								{
									HashSet<Mission.Flight>.Enumerator enumerator4;
									enumerator4.Dispose();
								}
								if (flag)
								{
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
				}
				if (!flag)
				{
					try
					{
						foreach (ActiveUnit activeUnit4 in this.vmethod_141().Values)
						{
							activeUnit4.vmethod_85().vmethod_10();
						}
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator5;
						if (enumerator5 != null)
						{
							enumerator5.Dispose();
						}
					}
				}
				try
				{
					foreach (ActiveUnit activeUnit5 in this.vmethod_141().Values)
					{
						if (!Information.IsNothing(activeUnit5.vmethod_101()))
						{
							hashSet.Add(activeUnit5.vmethod_101());
						}
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator6;
					if (enumerator6 != null)
					{
						enumerator6.Dispose();
					}
				}
				bool flag2 = false;
				string text = null;
				if (!Information.IsNothing(SelectedUnits))
				{
					try
					{
						foreach (ActiveUnit activeUnit6 in SelectedUnits)
						{
							if (activeUnit6.bool_3 && string.IsNullOrEmpty(text))
							{
								flag2 = true;
								if (activeUnit6.vmethod_85().method_48())
								{
									text = activeUnit6.vmethod_85().method_7().string_4;
								}
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator7;
						((IDisposable)enumerator7).Dispose();
					}
				}
				if (flag2)
				{
					if (!string.IsNullOrEmpty(text))
					{
						this.Name = "Flight " + text;
					}
					else
					{
						this.Name = "Flight " + Conversions.ToString(theScen.UnitsAutoIncrement);
					}
				}
				else
				{
					this.Name = "Group " + Conversions.ToString(theScen.UnitsAutoIncrement);
				}
				activeUnit = this;
				GameGeneral.smethod_22(ref activeUnit, ref theScen);
				theScen.Groups.Add(this);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100597", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00173078 File Offset: 0x00171278
		internal void method_149()
		{
			try
			{
				this.nullable_16 = new Group.GroupType?(this.method_148());
				if (this.vmethod_141().Count == 1)
				{
					this.method_153(Enumerable.ElementAtOrDefault<ActiveUnit>(this.vmethod_141().Values, 0));
				}
				else
				{
					if (this.method_143() != Group.GroupType.AirBase && this.method_143() != Group.GroupType.Installation && this.method_143() != Group.GroupType.MobileGroup)
					{
						if (this.method_143() != Group.GroupType.NavalBase)
						{
							double num = 0.0;
							ActiveUnit activeUnit_;
							try
							{
								foreach (ActiveUnit activeUnit in this.vmethod_141().Values)
								{
									if ((double)activeUnit.int_0 > num)
									{
										activeUnit_ = activeUnit;
										num = (double)activeUnit.int_0;
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
							this.method_153(activeUnit_);
							return;
						}
					}
					this.method_153(Enumerable.ElementAtOrDefault<ActiveUnit>(this.vmethod_141().Values, 0));
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100598", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0000AD7A File Offset: 0x00008F7A
		internal void method_150(ActiveUnit activeUnit_1)
		{
			this.method_153(activeUnit_1);
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x001731A8 File Offset: 0x001713A8
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
			if (flag || flag3)
			{
				short num = (short)this.vmethod_141().Count;
				short num2 = 0;
				try
				{
					foreach (ActiveUnit activeUnit in this.vmethod_141().Values)
					{
						bool flag4;
						if (activeUnit.bool_3)
						{
							if (flag4 = (Operators.CompareString(((Aircraft)activeUnit).method_164().method_26(activeUnit_1), "OK", false) == 0))
							{
								((Aircraft)activeUnit).method_164().method_33(false, activeUnit_1);
							}
						}
						else if (flag4 = (Operators.CompareString(activeUnit.vmethod_93().method_45(activeUnit_1), "OK", false) == 0))
						{
							activeUnit.vmethod_93().method_12(false, activeUnit_1);
						}
						if (flag4)
						{
							num2 += 1;
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
				if (this.method_143() == Group.GroupType.AirGroup)
				{
					if (num2 == num)
					{
						this.scenario_0.method_59("All units in group now have " + activeUnit_1.Name + " as their home base.", this.Name + " now wholly re-based", LoggedMessage.MessageType.AirOps, 5, this.string_0, this.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					}
					else if (num2 == 0)
					{
						this.scenario_0.method_59("No units in group have switched to " + activeUnit_1.Name + " as their home base.", "No units of " + this.Name + " changed base", LoggedMessage.MessageType.AirOps, 5, this.string_0, this.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					}
					else
					{
						this.scenario_0.method_59(string.Concat(new string[]
						{
							"Partial success: Only ",
							Conversions.ToString((int)num2),
							" out of ",
							Conversions.ToString((int)num),
							" units in this group have switched to ",
							activeUnit_1.Name,
							" as their home base."
						}), this.Name + " partially re-based", LoggedMessage.MessageType.AirOps, 5, this.string_0, this.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					}
				}
				else if (num2 == num)
				{
					this.scenario_0.method_59("All units in group now have " + activeUnit_1.Name + " as their home base.", this.Name + " now wholly re-based", LoggedMessage.MessageType.DockingOps, 5, this.string_0, this.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
				}
				else if (num2 == 0)
				{
					this.scenario_0.method_59("No units in group have switched to " + activeUnit_1.Name + " as their home base.", "No units of " + this.Name + " changed base", LoggedMessage.MessageType.DockingOps, 5, this.string_0, this.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
				}
				else
				{
					this.scenario_0.method_59(string.Concat(new string[]
					{
						"Partial success: Only ",
						Conversions.ToString((int)num2),
						" out of ",
						Conversions.ToString((int)num),
						" units in this group have switched to ",
						activeUnit_1.Name,
						" as their home base."
					}), this.Name + " partially re-based", LoggedMessage.MessageType.DockingOps, 5, this.string_0, this.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
				}
			}
			if (flag2)
			{
				short num3 = (short)this.vmethod_141().Count;
				short num4 = 0;
				try
				{
					foreach (ActiveUnit activeUnit2 in this.vmethod_141().Values)
					{
						try
						{
							foreach (ActiveUnit activeUnit3 in ((Group)activeUnit_1).vmethod_141().Values)
							{
								bool flag5;
								if (activeUnit2.bool_3)
								{
									if (flag5 = (Operators.CompareString(((Aircraft)activeUnit2).method_164().method_26(activeUnit3), "OK", false) == 0))
									{
										((Aircraft)activeUnit2).method_164().method_33(false, activeUnit3);
									}
								}
								else if (flag5 = (Operators.CompareString(activeUnit2.vmethod_93().method_45(activeUnit3), "OK", false) == 0))
								{
									activeUnit2.vmethod_93().method_12(false, activeUnit3);
								}
								if (flag5)
								{
									num4 += 1;
								}
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
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
				if (this.method_143() == Group.GroupType.AirGroup)
				{
					if (num4 == num3)
					{
						this.scenario_0.method_59("All units in group now have " + activeUnit_1.Name + " as their home base.", this.Name + " now wholly re-based", LoggedMessage.MessageType.AirOps, 5, this.string_0, this.vmethod_7(false), default(Geopoint_Struct));
						return;
					}
					if (num4 == 0)
					{
						this.scenario_0.method_59("No units in group have switched to " + activeUnit_1.Name + " as their home base.", "No units of " + this.Name + " changed base", LoggedMessage.MessageType.AirOps, 5, this.string_0, this.vmethod_7(false), default(Geopoint_Struct));
						return;
					}
					this.scenario_0.method_59(string.Concat(new string[]
					{
						"Partial success: Only ",
						Conversions.ToString((int)num4),
						" out of ",
						Conversions.ToString((int)num3),
						" units in this group have switched to  units in group: ",
						activeUnit_1.Name,
						" as their home base."
					}), this.Name + " partially re-based", LoggedMessage.MessageType.AirOps, 5, this.string_0, this.vmethod_7(false), default(Geopoint_Struct));
					return;
				}
				else
				{
					if (num4 == num3)
					{
						this.scenario_0.method_59("All units in group now have various units in group " + activeUnit_1.Name + " as their home base.", this.Name + " now wholly re-based", LoggedMessage.MessageType.DockingOps, 5, this.string_0, this.vmethod_7(false), default(Geopoint_Struct));
						return;
					}
					if (num4 == 0)
					{
						this.scenario_0.method_59("No units in group have switched to " + activeUnit_1.Name + " as their home base.", "No units of " + this.Name + " changed base", LoggedMessage.MessageType.DockingOps, 5, this.string_0, this.vmethod_7(false), default(Geopoint_Struct));
						return;
					}
					this.scenario_0.method_59(string.Concat(new string[]
					{
						"Partial success: Only ",
						Conversions.ToString((int)num4),
						" out of ",
						Conversions.ToString((int)num3),
						" units in this group have switched to units in group: ",
						activeUnit_1.Name,
						" as their home base."
					}), this.Name + " partially re-based", LoggedMessage.MessageType.DockingOps, 5, this.string_0, this.vmethod_7(false), default(Geopoint_Struct));
				}
			}
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00173928 File Offset: 0x00171B28
		public override bool vmethod_127()
		{
			Group.GroupType groupType = this.method_143();
			return groupType > Group.GroupType.SubGroup || (this.method_147() != null && this.method_147().vmethod_127());
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00173960 File Offset: 0x00171B60
		public bool method_151()
		{
			bool result;
			try
			{
				bool flag;
				if (this.method_143() != Group.GroupType.AirBase || this.method_143() == Group.GroupType.Installation)
				{
					if (this.method_143() == Group.GroupType.SurfaceGroup || this.method_143() == Group.GroupType.MobileGroup)
					{
						try
						{
							foreach (ActiveUnit activeUnit in this.vmethod_141().Values)
							{
								if (!activeUnit.bool_3 && !activeUnit.vmethod_127())
								{
									flag = true;
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
					if (this.method_143() == Group.GroupType.AirGroup)
					{
						try
						{
							IEnumerator<ActiveUnit> enumerator2 = this.vmethod_141().Values.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								if (!enumerator2.Current.vmethod_127())
								{
									flag = true;
									break;
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
					}
				}
				result = flag;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100599", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00173A84 File Offset: 0x00171C84
		public override void vmethod_134(ActiveUnit.Throttle ThrottleSetting, float? SpecificDesiredSpeed = null)
		{
			if (!Information.IsNothing(this.method_147()))
			{
				if (Information.IsNothing(SpecificDesiredSpeed))
				{
					this.method_147().vmethod_71((float)this.method_145().method_20(ThrottleSetting));
				}
				else
				{
					this.method_147().vmethod_71(SpecificDesiredSpeed.Value);
				}
				this.throttle_0 = ThrottleSetting;
				this.method_147().vmethod_134(ThrottleSetting, SpecificDesiredSpeed);
			}
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x0000AD83 File Offset: 0x00008F83
		public List<Unit> method_152()
		{
			return Enumerable.ToList<Unit>(Enumerable.Select<ActiveUnit, Unit>(this.vmethod_141().Values, (Group._Closure$__.$I139-0 == null) ? (Group._Closure$__.$I139-0 = new Func<ActiveUnit, Unit>(Group._Closure$__.$I.method_0)) : Group._Closure$__.$I139-0));
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00173AEC File Offset: 0x00171CEC
		public override void vmethod_42(ref Scenario scenario_1, double double_4, double double_5)
		{
			try
			{
				this.method_147().vmethod_42(ref scenario_1, double_4, double_5);
				if (this.vmethod_85().method_47())
				{
					this.vmethod_10(base.method_34(this.vmethod_85().method_4()[0].imethod_2(), this.vmethod_85().method_4()[0].imethod_0()));
				}
				try
				{
					foreach (ActiveUnit activeUnit in this.vmethod_141().Values)
					{
						if (!activeUnit.method_122())
						{
							Tuple<double, double> tuple = activeUnit.vmethod_85().method_2().method_0(activeUnit, this.method_147());
							activeUnit.vmethod_31(null, tuple.Item1);
							activeUnit.vmethod_29(null, tuple.Item2);
							activeUnit.vmethod_10(this.vmethod_9());
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
				this.vmethod_31(null, double_5);
				this.vmethod_29(null, double_4);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100600", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00173C40 File Offset: 0x00171E40
		public void method_153(ActiveUnit activeUnit_1)
		{
			this.activeUnit_0 = activeUnit_1;
			if (!Information.IsNothing(this.activeUnit_0))
			{
				this.vmethod_31(null, this.activeUnit_0.vmethod_30(null));
				this.vmethod_29(null, this.activeUnit_0.vmethod_28(null));
			}
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00173CA8 File Offset: 0x00171EA8
		public override void vmethod_133(bool bool_28, bool bool_29, bool bool_30)
		{
			try
			{
				this.scenario_0.Groups.Remove(this);
				List<ActiveUnit> list = new List<ActiveUnit>();
				list.AddRange(this.vmethod_141().Values);
				try
				{
					foreach (ActiveUnit activeUnit in list)
					{
						activeUnit.vmethod_66(false, null);
						activeUnit.vmethod_85().vmethod_9();
						foreach (Waypoint waypoint_ in this.vmethod_85().method_4())
						{
							activeUnit.vmethod_85().method_50(waypoint_);
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				base.vmethod_133(bool_28, bool_29, bool_30);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100601", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00173DAC File Offset: 0x00171FAC
		private void method_154(ActiveUnit activeUnit_1)
		{
			this.nullable_16 = null;
			if (!this.bool_27)
			{
				this.method_149();
			}
			Group.Delegate32 @delegate = Group.delegate32_0;
			if (@delegate != null)
			{
				@delegate(this, activeUnit_1);
			}
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00173DE4 File Offset: 0x00171FE4
		private void method_155(ActiveUnit activeUnit_1)
		{
			this.nullable_16 = null;
			try
			{
				if (!this.bool_27 && this.method_147() == activeUnit_1)
				{
					this.method_149();
				}
				if (this.vmethod_141().Count < 1)
				{
					this.scenario_0.method_65(this);
					if (!string.IsNullOrEmpty(this.Name))
					{
						base.method_124(this.Name + " has no units left; dissolving...", "Grouping", LoggedMessage.MessageType.UI, 5, true, new Geopoint_Struct(0.0, 0.0));
					}
					this.scenario_0.method_66(this.string_0, true);
				}
				Group.Delegate33 @delegate = Group.delegate33_0;
				if (@delegate != null)
				{
					@delegate(this, activeUnit_1);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100602", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00173EDC File Offset: 0x001720DC
		private void method_156(object sender, NotifyDictionaryChangedEventArgs<string, ActiveUnit> e)
		{
			NotifyCollectionChangedAction action = e.Action;
			if (action == null)
			{
				this.method_154(e.NewItem.Value);
				return;
			}
			if (action != 1)
			{
				return;
			}
			this.method_155(e.OldItem.Value);
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00173F24 File Offset: 0x00172124
		public override bool vmethod_47(double double_4, double double_5, ref int int_6, bool bool_28, bool bool_29, bool bool_30, ref bool bool_31, bool bool_32, ref bool bool_33, float? nullable_17, short? nullable_18, ref List<ActiveUnit> list_3, float float_25, bool bool_34, bool bool_35, ref string string_9, ref bool bool_36)
		{
			return !Information.IsNothing(this.method_147()) && this.method_147().bool_0 && this.method_147().vmethod_47(double_4, double_5, ref int_6, bool_28, bool_29, bool_30, ref bool_31, bool_32, ref bool_33, nullable_17, nullable_18, ref list_3, float_25, bool_34, bool_35, ref string_9, ref bool_36);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0000ADBE File Offset: 0x00008FBE
		private void method_157(object sender, EventArgs5<Class343> e)
		{
			this.vmethod_7(false).method_37();
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0000ADBE File Offset: 0x00008FBE
		private void method_158(object sender, EventArgs5<Class343> e)
		{
			this.vmethod_7(false).method_37();
		}

		// Token: 0x04000DC9 RID: 3529
		private Group.GroupType? nullable_16;

		// Token: 0x04000DCA RID: 3530
		public GeoPoint geoPoint_0;

		// Token: 0x04000DCB RID: 3531
		private ActiveUnit activeUnit_0;

		// Token: 0x04000DCC RID: 3532
		[CompilerGenerated]
		[AccessedThroughProperty("Patrols")]
		private ObservableList<Class343> observableList_2;

		// Token: 0x04000DCD RID: 3533
		private Class213 class213_0;

		// Token: 0x04000DCE RID: 3534
		private Class167 class167_0;

		// Token: 0x04000DCF RID: 3535
		private Group_Kinematics group_Kinematics_0;

		// Token: 0x04000DD0 RID: 3536
		private Class220 class220_0;

		// Token: 0x04000DD1 RID: 3537
		private Class227 class227_0;

		// Token: 0x04000DD2 RID: 3538
		private Class182 class182_0;

		// Token: 0x04000DD3 RID: 3539
		private Class179 class179_0;

		// Token: 0x04000DD4 RID: 3540
		[CompilerGenerated]
		[AccessedThroughProperty("Units")]
		private ObservableDictionary<string, ActiveUnit> observableDictionary_0;

		// Token: 0x04000DD5 RID: 3541
		internal bool bool_27;

		// Token: 0x04000DD6 RID: 3542
		[CompilerGenerated]
		private static Group.Delegate32 delegate32_0;

		// Token: 0x04000DD7 RID: 3543
		[CompilerGenerated]
		private static Group.Delegate33 delegate33_0;

		// Token: 0x02000270 RID: 624
		// (Invoke) Token: 0x0600133E RID: 4926
		internal delegate void Delegate32(Group theGroup, ActiveUnit theUnit);

		// Token: 0x02000271 RID: 625
		// (Invoke) Token: 0x06001342 RID: 4930
		internal delegate void Delegate33(Group theGroup, ActiveUnit theUnit);

		// Token: 0x02000272 RID: 626
		public enum GroupType : byte
		{
			// Token: 0x04000DD9 RID: 3545
			AirGroup,
			// Token: 0x04000DDA RID: 3546
			SurfaceGroup,
			// Token: 0x04000DDB RID: 3547
			SubGroup,
			// Token: 0x04000DDC RID: 3548
			Installation,
			// Token: 0x04000DDD RID: 3549
			MobileGroup,
			// Token: 0x04000DDE RID: 3550
			AirBase,
			// Token: 0x04000DDF RID: 3551
			NavalBase
		}
	}
}
