using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml;
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
	// Token: 0x02000186 RID: 390
	public sealed class Aircraft_AI : ActiveUnit_AI
	{
		// Token: 0x06000BC8 RID: 3016 RVA: 0x000086B1 File Offset: 0x000068B1
		private Aircraft method_112()
		{
			if (this.aircraft_0 == null)
			{
				this.aircraft_0 = (Aircraft)this.activeUnit_0;
			}
			return this.aircraft_0;
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x000DD798 File Offset: 0x000DB998
		public static Aircraft_AI smethod_1(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Aircraft_AI result;
			try
			{
				Aircraft_AI aircraft_AI = new Aircraft_AI(ref activeUnit_1);
				aircraft_AI.activeUnit_0 = activeUnit_1;
				if (Operators.CompareString(xmlNode_0.ChildNodes[0].Name, "ActiveUnit_AI", false) == 0)
				{
					xmlNode_0 = xmlNode_0.ChildNodes[0];
				}
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 1925531877U)
						{
							if (num <= 592141878U)
							{
								if (num <= 106934956U)
								{
									if (num != 24194140U)
									{
										if (num != 94512562U)
										{
											if (num != 106934956U)
											{
												continue;
											}
											if (Operators.CompareString(name, "PrimaryTarget", false) != 0)
											{
												continue;
											}
										}
										else if (Operators.CompareString(name, "PTarget", false) != 0)
										{
											continue;
										}
										aircraft_AI.contact_0 = Contact.smethod_0(xmlNode.InnerText, ref dictionary_0);
										continue;
									}
									if (Operators.CompareString(name, "SpeedAdjustmentToT_OriginalThrottle", false) == 0)
									{
										aircraft_AI.nullable_4 = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else if (num != 357111700U)
								{
									if (num != 467450941U)
									{
										if (num != 592141878U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Threats", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj2 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode2 = (XmlNode)obj2;
												Contact contact_ = Contact.smethod_1(ref xmlNode2, ref dictionary_0);
												Class429.smethod_13(ref aircraft_AI.contact_2, contact_);
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
									if (Operators.CompareString(name, "PrimaryThreat", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "IgnorePlottedCourse", false) != 0)
									{
										continue;
									}
									goto IL_6A3;
								}
							}
							else if (num <= 987051924U)
							{
								if (num != 864394351U)
								{
									if (num != 866975591U)
									{
										if (num != 987051924U)
										{
											continue;
										}
										if (Operators.CompareString(name, "AP", false) == 0)
										{
											aircraft_AI.method_115((ActiveUnit_AI.AircraftAltitudePreset)Conversions.ToByte(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "DPT_E", false) == 0)
										{
											aircraft_AI.bool_10 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (Operators.CompareString(name, "PThreat", false) != 0)
								{
									continue;
								}
							}
							else if (num <= 1474882803U)
							{
								if (num != 1359263885U)
								{
									if (num != 1474882803U)
									{
										continue;
									}
									if (Operators.CompareString(name, "IE", false) == 0)
									{
										aircraft_AI.bool_2 = true;
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "LeadMustSlowDownDueToBingo", false) == 0)
									{
										aircraft_AI.bool_8 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 1610968176U)
							{
								if (num != 1925531877U)
								{
									continue;
								}
								if (Operators.CompareString(name, "FerryCycleLegIsOutbound", false) != 0)
								{
									continue;
								}
								goto IL_4C3;
							}
							else
							{
								if (Operators.CompareString(name, "TTNPTE", false) == 0)
								{
									aircraft_AI.float_1 = Conversions.ToSingle(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							aircraft_AI.contact_1 = Contact.smethod_0(xmlNode.InnerText, ref dictionary_0);
							continue;
						}
						if (num > 2473769731U)
						{
							if (num <= 3751974105U)
							{
								if (num != 2485645227U)
								{
									if (num != 2722719197U)
									{
										if (num != 3751974105U)
										{
											continue;
										}
										if (Operators.CompareString(name, "IsPerformingSpeedAdjustmentToT", false) == 0)
										{
											aircraft_AI.bool_7 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else if (Operators.CompareString(name, "PTOE", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "SpeedAdjustmentToT_OriginalSpeedOverride", false) == 0)
									{
										aircraft_AI.nullable_3 = new float?(Conversions.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else if (num <= 3770421268U)
							{
								if (num != 3761246852U)
								{
									if (num != 3770421268U)
									{
										continue;
									}
									if (Operators.CompareString(name, "ET_E", false) == 0)
									{
										aircraft_AI.bool_9 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name, "PrimaryTargetOverrideExists", false) != 0)
								{
									continue;
								}
							}
							else if (num != 3957045325U)
							{
								if (num != 4076649232U)
								{
									continue;
								}
								if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Alt", false) == 0)
								{
									aircraft_AI.method_7(XmlConvert.ToSingle(xmlNode.InnerText));
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "IPC", false) == 0)
								{
									goto IL_6A3;
								}
								continue;
							}
							aircraft_AI.bool_0 = Conversions.ToBoolean(xmlNode.InnerText);
							continue;
						}
						if (num <= 2177917648U)
						{
							if (num != 1966596370U)
							{
								if (num != 2133975202U)
								{
									if (num != 2177917648U)
									{
										continue;
									}
									if (Operators.CompareString(name, "TimeToNextSpeedAdjustmentForToTEvaluation", false) == 0)
									{
										aircraft_AI.nullable_0 = new float?(Conversions.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Lat", false) == 0)
									{
										aircraft_AI.method_3(XmlConvert.ToDouble(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Lon", false) == 0)
								{
									aircraft_AI.method_5(XmlConvert.ToDouble(xmlNode.InnerText));
									continue;
								}
								continue;
							}
						}
						else if (num <= 2276842832U)
						{
							if (num != 2273311670U)
							{
								if (num != 2276842832U)
								{
									continue;
								}
								if (Operators.CompareString(name, "TargetList", false) != 0)
								{
									continue;
								}
								try
								{
									foreach (object obj3 in xmlNode.ChildNodes)
									{
										XmlNode xmlNode3 = (XmlNode)obj3;
										ActiveUnit_AI.TargetingEntry targetingEntry = ActiveUnit_AI.TargetingEntry.smethod_0(ref xmlNode3, ref dictionary_0);
										if (!Information.IsNothing(targetingEntry.contact_0) && !aircraft_AI.vmethod_0().ContainsKey(targetingEntry.contact_0.string_0))
										{
											aircraft_AI.vmethod_0().Add(targetingEntry.contact_0.string_0, targetingEntry);
										}
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
							if (Operators.CompareString(name, "FCLIO", false) != 0)
							{
								continue;
							}
						}
						else if (num != 2326749763U)
						{
							if (num != 2473769731U)
							{
								continue;
							}
							if (Operators.CompareString(name, "SpeedAdjustmentToT_OriginalThrottlePreset", false) == 0)
							{
								aircraft_AI.nullable_5 = new ActiveUnit_Kinematics.UnitThrottlePreset?((ActiveUnit_Kinematics.UnitThrottlePreset)Conversions.ToByte(xmlNode.InnerText));
								continue;
							}
							continue;
						}
						else
						{
							if (Operators.CompareString(name, "SpeedAdjustmentToT_OriginalSpeed", false) == 0)
							{
								aircraft_AI.nullable_2 = new float?(Conversions.ToSingle(xmlNode.InnerText));
								continue;
							}
							continue;
						}
						IL_4C3:
						aircraft_AI.bool_1 = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_6A3:
						bool flag = Conversions.ToBoolean(xmlNode.InnerText);
						if (activeUnit_1.doctrine_0 != null)
						{
							activeUnit_1.doctrine_0.method_84(activeUnit_1.scenario_0, false, null, false, false, new Doctrine.Enum64?((-((Conversions.ToBoolean(xmlNode.InnerText) > false) ? Doctrine.Enum64.const_1 : Doctrine.Enum64.const_0)) ? Doctrine.Enum64.const_1 : Doctrine.Enum64.const_0));
						}
						if (flag && !Information.IsNothing(activeUnit_1.vmethod_101()))
						{
							Mission mission = activeUnit_1.vmethod_101();
							if (mission._MissionClass_0 == Mission._MissionClass.Patrol)
							{
								mission.doctrine_0.method_84(activeUnit_1.scenario_0, false, null, false, false, new Doctrine.Enum64?(Doctrine.Enum64.const_1));
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
				result = aircraft_AI;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100375", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Aircraft_AI(ref activeUnit_1);
			}
			return result;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x000DDFA4 File Offset: 0x000DC1A4
		public override void vmethod_2(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_2)
		{
			try
			{
				if (!Information.IsNothing(this.vmethod_3()))
				{
					xmlWriter_0.WriteElementString("PrimaryTarget", this.vmethod_3().string_0);
				}
				if (!Information.IsNothing(this.contact_1))
				{
					xmlWriter_0.WriteElementString("PrimaryThreat", this.contact_1.string_0);
				}
				if (base.method_2() != 0.0)
				{
					xmlWriter_0.WriteElementString("PrimaryTarget_LastKnown_Lat", XmlConvert.ToString(base.method_2()));
				}
				if (base.method_4() != 0.0)
				{
					xmlWriter_0.WriteElementString("PrimaryTarget_LastKnown_Lon", XmlConvert.ToString(base.method_4()));
				}
				if (base.method_6() != 0f)
				{
					xmlWriter_0.WriteElementString("PrimaryTarget_LastKnown_Alt", XmlConvert.ToString(base.method_6()));
				}
				if (this.float_1 != 0f)
				{
					xmlWriter_0.WriteElementString("TTNPTE", this.float_1.ToString());
				}
				if (this.bool_0)
				{
					xmlWriter_0.WriteElementString("PTOE", this.bool_0.ToString());
				}
				if (this.bool_1)
				{
					xmlWriter_0.WriteElementString("FCLIO", this.bool_1.ToString());
				}
				if (!this.bool_9)
				{
					xmlWriter_0.WriteElementString("ET_E", "False");
				}
				if (!this.bool_10)
				{
					xmlWriter_0.WriteElementString("DPT_E", "False");
				}
				xmlWriter_0.WriteElementString("AP", ((byte)this.method_114()).ToString());
				if (this.bool_2)
				{
					xmlWriter_0.WriteElementString("IE", this.bool_2.ToString());
				}
				if (!Information.IsNothing(this.geoPoint_0))
				{
					xmlWriter_0.WriteStartElement("LKTL");
					xmlWriter_0.WriteRaw(this.geoPoint_0.method_8(hashSet_2));
					xmlWriter_0.WriteEndElement();
				}
				if (this.vmethod_0().Count > 0)
				{
					xmlWriter_0.WriteStartElement("TargetList");
					try
					{
						foreach (ActiveUnit_AI.TargetingEntry targetingEntry in this.vmethod_0().Values)
						{
							if (!Information.IsNothing(targetingEntry.contact_0.activeUnit_0))
							{
								xmlWriter_0.WriteRaw(targetingEntry.method_0(this.activeUnit_0.vmethod_7(false)));
							}
						}
					}
					finally
					{
						IEnumerator<ActiveUnit_AI.TargetingEntry> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (base.method_15().Length > 0)
				{
					xmlWriter_0.WriteStartElement("Threats");
					List<Contact> list = new List<Contact>();
					list.AddRange(this.contact_2);
					try
					{
						foreach (Contact contact in list)
						{
							if (!Information.IsNothing(contact))
							{
								xmlWriter_0.WriteRaw(contact.method_61(hashSet_2));
							}
						}
					}
					finally
					{
						List<Contact>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					xmlWriter_0.WriteEndElement();
				}
				if (!Information.IsNothing(this.nullable_1))
				{
					xmlWriter_0.WriteElementString("SnakeAxis", Conversions.ToString(this.nullable_1.Value));
				}
				if (!Information.IsNothing(this.nullable_0))
				{
					xmlWriter_0.WriteElementString("TimeToNextSpeedAdjustmentForToTEvaluation", Conversions.ToString(this.nullable_0.Value));
				}
				if (!Information.IsNothing(this.nullable_2))
				{
					xmlWriter_0.WriteElementString("SpeedAdjustmentToT_OriginalSpeed", Conversions.ToString(this.nullable_2.Value));
				}
				if (!Information.IsNothing(this.nullable_3))
				{
					xmlWriter_0.WriteElementString("SpeedAdjustmentToT_OriginalSpeedOverride", Conversions.ToString(this.nullable_3.Value));
				}
				if (!Information.IsNothing(this.nullable_4))
				{
					xmlWriter_0.WriteElementString("SpeedAdjustmentToT_OriginalThrottle", Conversions.ToString((byte)this.nullable_4.Value));
				}
				if (!Information.IsNothing(this.nullable_5))
				{
					xmlWriter_0.WriteElementString("SpeedAdjustmentToT_OriginalThrottlePreset", Conversions.ToString((byte)this.nullable_5.Value));
				}
				if (this.bool_7)
				{
					xmlWriter_0.WriteElementString("IsPerformingSpeedAdjustmentToT", this.bool_7.ToString());
				}
				if (this.bool_8)
				{
					xmlWriter_0.WriteElementString("LeadMustSlowDownDueToBingo", this.bool_8.ToString());
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100374", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x000086D2 File Offset: 0x000068D2
		public Aircraft_AI(ref ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
			this.hashSet_1 = new HashSet<string>();
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x000DE438 File Offset: 0x000DC638
		public override void vmethod_23(float float_3)
		{
			if (this.method_112().int_6 != 0 || this.method_112().method_162().vmethod_1() || this.method_112().method_85())
			{
				try
				{
					double num = Math.Round((double)Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.contact_1.vmethod_30(null), this.contact_1.vmethod_28(null)), 0);
					if (!double.IsNaN(num))
					{
						if (this.method_112().vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling)
						{
							this.method_112().method_164().method_45();
						}
						Contact_Base.ContactType contactType_ = this.contact_1.contactType_0;
						if (contactType_ != Contact_Base.ContactType.Air)
						{
							if (contactType_ == Contact_Base.ContactType.Missile)
							{
								bool flag = false;
								if (!Information.IsNothing(this.contact_1.activeUnit_0) && this.contact_1.activeUnit_0.method_2())
								{
									Weapon weapon = (Weapon)this.contact_1.activeUnit_0;
									if (!Information.IsNothing(weapon.method_170()))
									{
										Sensor sensor = weapon.method_170();
										if ((sensor.struct33_0.bool_13 || sensor.struct33_0.bool_12) && !sensor.struct33_0.bool_19 && !sensor.struct33_0.bool_20 && !sensor.struct33_0.bool_25)
										{
											Aircraft_AI.Class239 @class = new Aircraft_AI.Class239();
											@class.activeUnit_0 = sensor.method_18();
											IEnumerable<Contact> enumerable = Enumerable.Where<Contact>(this.method_112().method_160().method_0(), new Func<Contact, bool>(@class.method_0));
											if (Enumerable.Count<Contact>(enumerable) > 0)
											{
												base.method_74((int)Math.Round((double)this.method_112().method_32(Enumerable.ElementAtOrDefault<Contact>(enumerable, 0))));
												this.activeUnit_0.vmethod_73(0f);
											}
											flag = true;
										}
									}
									else if (!Information.IsNothing(weapon.method_179()))
									{
										Aircraft_AI.Class240 class2 = new Aircraft_AI.Class240();
										class2.activeUnit_0 = weapon.method_179();
										IEnumerable<Contact> enumerable2 = Enumerable.Where<Contact>(this.method_112().method_160().method_0(), new Func<Contact, bool>(class2.method_0));
										if (Enumerable.Count<Contact>(enumerable2) > 0)
										{
											base.method_74((int)Math.Round((double)this.method_112().method_32(Enumerable.ElementAtOrDefault<Contact>(enumerable2, 0))));
											this.activeUnit_0.vmethod_73(0f);
										}
										flag = true;
									}
								}
								if (!flag)
								{
									base.method_74((int)Math.Round(num));
									this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
									this.activeUnit_0.vmethod_73(0f);
								}
							}
						}
						else
						{
							Contact[] array = base.method_12();
							if (Class429.smethod_16(ref array, this.contact_1))
							{
								double double_;
								double double_2;
								Class411.smethod_1(this.contact_1.vmethod_28(null), this.contact_1.vmethod_30(null), ref double_, ref double_2, 0.5, (double)Math2.smethod_7(this.contact_1.vmethod_9() + 180f));
								this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.method_34(double_2, double_));
							}
							else
							{
								float num2 = 2f;
								if (this.method_112().method_36(this.contact_1) <= num2)
								{
									base.method_74((int)Math.Round(num));
									this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
								}
								else
								{
									int num3 = (int)Math.Round(num);
									base.method_72(ref num3);
								}
							}
						}
						Doctrine._JettisonOrdnance? jettisonOrdnance = this.method_112().doctrine_0.method_127(this.method_112().scenario_0, false, false, false);
						byte? b = (jettisonOrdnance != null) ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null;
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							this.method_112().method_161().method_67(false, true, true, true, false, false, false);
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100376", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x000DE8B0 File Offset: 0x000DCAB0
		public override void vmethod_17(float float_3, bool bool_11, bool bool_12)
		{
			if (this.bool_10)
			{
				try
				{
					if (this.activeUnit_0 != null)
					{
						Contact contact = this.activeUnit_0.method_97();
						if (contact != null)
						{
							this.vmethod_4(contact);
						}
						else if (this.activeUnit_0.vmethod_101() != null && !this.activeUnit_0.vmethod_101().method_12())
						{
							this.vmethod_4(null);
						}
						else if (this.activeUnit_0.method_86())
						{
							this.vmethod_4(null);
						}
						else
						{
							if (this.method_112().vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsWinchester)
							{
								if (this.method_112().vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsShotgun)
								{
									List<Contact> list = new List<Contact>();
									if (this.method_112().method_167() != null && this.method_112().method_167().loadoutRole_0 == Loadout.LoadoutRole.AntiSatellite_Intercept)
									{
										list = Enumerable.ToList<Contact>(Enumerable.Where<Contact>(base.method_12(), (Aircraft_AI._Closure$__.$I12-0 == null) ? (Aircraft_AI._Closure$__.$I12-0 = new Func<Contact, bool>(Aircraft_AI._Closure$__.$I.method_0)) : Aircraft_AI._Closure$__.$I12-0));
									}
									else
									{
										list = Enumerable.ToList<Contact>(Enumerable.Where<Contact>(base.method_12(), (Aircraft_AI._Closure$__.$I12-1 == null) ? (Aircraft_AI._Closure$__.$I12-1 = new Func<Contact, bool>(Aircraft_AI._Closure$__.$I.method_1)) : Aircraft_AI._Closure$__.$I12-1));
									}
									if (list.Count == 0)
									{
										this.vmethod_4(null);
										return;
									}
									List<Contact> list2 = new List<Contact>();
									if (!Information.IsNothing(this.method_112().method_167()) && this.method_112().method_167().loadoutRole_0 == Loadout.LoadoutRole.AntiSatellite_Intercept)
									{
										try
										{
											foreach (Contact contact2 in list)
											{
												ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = base.method_20(contact2);
												if (targetingBehavior != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
												{
													if (targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted && contact2.contactType_0 == Contact_Base.ContactType.Orbital)
													{
														list2.Add(contact2);
													}
												}
												else if (contact2.contactType_0 == Contact_Base.ContactType.Orbital && base.method_55(ref contact2))
												{
													list2.Add(contact2);
												}
											}
											goto IL_296;
										}
										finally
										{
											List<Contact>.Enumerator enumerator;
											((IDisposable)enumerator).Dispose();
										}
									}
									try
									{
										foreach (Contact contact3 in list)
										{
											ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior2 = base.method_20(contact3);
											if (targetingBehavior2 != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
											{
												if (targetingBehavior2 == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted && (contact3.method_105() || contact3.method_108() || contact3.method_136() || contact3.method_107()))
												{
													list2.Add(contact3);
												}
											}
											else if ((contact3.method_105() || contact3.method_108() || contact3.method_136() || contact3.method_107()) && base.method_55(ref contact3))
											{
												list2.Add(contact3);
											}
										}
									}
									finally
									{
										List<Contact>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
									IL_296:
									if (list2.Count > 0)
									{
										if (list2.Count == 1)
										{
											this.vmethod_4(list2[0]);
											return;
										}
										List<Contact> list3 = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(Enumerable.Select<Contact, Contact>(list2, (Aircraft_AI._Closure$__.$I12-2 == null) ? (Aircraft_AI._Closure$__.$I12-2 = new Func<Contact, Contact>(Aircraft_AI._Closure$__.$I.method_2)) : Aircraft_AI._Closure$__.$I12-2), new Func<Contact, double>(this.method_144)));
										this.vmethod_4(list3[0]);
										return;
									}
									else
									{
										if (Information.IsNothing(this.activeUnit_0.vmethod_101()))
										{
											this.vmethod_4(null);
											return;
										}
										if (this.activeUnit_0.method_69())
										{
											if (!this.activeUnit_0.vmethod_86().bool_2)
											{
												Aircraft_AI.Class241 @class = new Aircraft_AI.Class241(@class);
												@class.aircraft_AI_0 = this;
												@class.strike_0 = (Strike)this.activeUnit_0.vmethod_101();
												if (@class.strike_0.hashSet_0.Count > 0)
												{
													if (Information.IsNothing(this.vmethod_3()))
													{
														List<Contact> list4 = Enumerable.ToList<Contact>(Enumerable.OrderByDescending<Contact, GlobalVariables.TargetVisualSizeClass>(Enumerable.Where<Contact>(list, new Func<Contact, bool>(@class.method_0)), new Func<Contact, GlobalVariables.TargetVisualSizeClass>(this.method_145)));
														if (list4.Count > 0)
														{
															this.vmethod_4(list4[0]);
															return;
														}
													}
												}
												else if (@class.strike_0.bool_27 && @class.strike_0.hashSet_0.Count == 0)
												{
													this.vmethod_4(null);
													return;
												}
												if (@class.strike_0.strikeType_0 == Strike.StrikeType.Air_Intercept)
												{
													Aircraft_AI.Class242 class2 = new Aircraft_AI.Class242(class2);
													Contact contact4 = null;
													List<Contact> list5 = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(Enumerable.Select<Contact, Contact>(list, (Aircraft_AI._Closure$__.$I12-6 == null) ? (Aircraft_AI._Closure$__.$I12-6 = new Func<Contact, Contact>(Aircraft_AI._Closure$__.$I.method_3)) : Aircraft_AI._Closure$__.$I12-6), new Func<Contact, double>(this.method_146)));
													List<ActiveUnit> list6 = Enumerable.ToList<ActiveUnit>(this.activeUnit_0.vmethod_7(false).activeUnit_0);
													try
													{
														List<Contact>.Enumerator enumerator3 = list5.GetEnumerator();
														while (enumerator3.MoveNext())
														{
															Aircraft_AI.Class243 class3 = new Aircraft_AI.Class243(class3);
															class3.contact_0 = enumerator3.Current;
															class2.string_0 = class3.contact_0.string_0;
															List<ActiveUnit> list7 = Enumerable.ToList<ActiveUnit>(Enumerable.OrderBy<ActiveUnit, double>(Enumerable.Where<ActiveUnit>(list6, (class2.func_0 == null) ? (class2.func_0 = new Func<ActiveUnit, bool>(class2.method_0)) : class2.func_0), new Func<ActiveUnit, double>(class3.method_0)));
															if (list7.Count != 0)
															{
																if (list7[0] != this.activeUnit_0)
																{
																	continue;
																}
																contact4 = class3.contact_0;
															}
															else
															{
																contact4 = class3.contact_0;
															}
															break;
														}
													}
													finally
													{
														List<Contact>.Enumerator enumerator3;
														((IDisposable)enumerator3).Dispose();
													}
													if (contact4 == null)
													{
														List<Contact> list8;
														if (this.activeUnit_0.vmethod_90().vmethod_1())
														{
															list8 = ParallelEnumerable.ToList<Contact>(ParallelEnumerable.ThenBy<Contact, double>(ParallelEnumerable.OrderBy<Contact, int>(ParallelEnumerable.Select<Contact, Contact>(ParallelEnumerable.AsParallel<Contact>(list), (Aircraft_AI._Closure$__.$I12-10 == null) ? (Aircraft_AI._Closure$__.$I12-10 = new Func<Contact, Contact>(Aircraft_AI._Closure$__.$I.method_4)) : Aircraft_AI._Closure$__.$I12-10), new Func<Contact, int>(this.method_147)), new Func<Contact, double>(this.method_148)));
														}
														else
														{
															list8 = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(Enumerable.Select<Contact, Contact>(list, (Aircraft_AI._Closure$__.$I12-14 == null) ? (Aircraft_AI._Closure$__.$I12-14 = new Func<Contact, Contact>(Aircraft_AI._Closure$__.$I.method_6)) : Aircraft_AI._Closure$__.$I12-14), new Func<Contact, double>(this.method_149)));
														}
														this.vmethod_4(list8[0]);
													}
													else
													{
														this.vmethod_4(contact4);
													}
												}
												else
												{
													if (this.vmethod_3() != null)
													{
														Contact contact_ = this.vmethod_3();
														Mission mission_ = this.method_112().vmethod_101();
														Doctrine.Enum59? nullable_ = this.activeUnit_0.doctrine_0.method_162(this.activeUnit_0.scenario_0, false, false, false);
														bool bool_13 = false;
														bool bool_14 = false;
														bool bool_15 = true;
														Misc.PostureStance? nullable_2 = null;
														string text = "";
														int num = 0;
														if (base.method_39(contact_, mission_, nullable_, bool_13, bool_14, bool_15, nullable_2, ref text, ref num))
														{
															goto IL_D57;
														}
													}
													if (this.method_112().method_157().method_49() && !this.method_112().method_157().method_21())
													{
														this.vmethod_4(null);
													}
													else
													{
														List<Contact> list9 = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(Enumerable.Where<Contact>(list, new Func<Contact, bool>(this.method_150)), new Func<Contact, double>(this.method_151)));
														if (list9.Count > 0)
														{
															if ((@class.strike_0.strikeType_0 == Strike.StrikeType.Land_Strike || @class.strike_0.strikeType_0 == Strike.StrikeType.Maritime_Strike) && bool_12 && this.method_112().method_157().method_48())
															{
																if (!this.method_112().method_157().method_49())
																{
																	this.vmethod_4(list9[0]);
																}
																else
																{
																	Aircraft aircraft;
																	if (this.method_112().method_120())
																	{
																		aircraft = (Aircraft)this.method_112().vmethod_65(false).method_147();
																	}
																	else
																	{
																		aircraft = this.method_112();
																	}
																	Mission mission = this.activeUnit_0.vmethod_101();
																	ActiveUnit_AI activeUnit_AI = aircraft.method_158();
																	ActiveUnit activeUnit_ = this.activeUnit_0;
																	ActiveUnit activeUnit_2;
																	Side value = (activeUnit_2 = this.activeUnit_0).vmethod_7(false);
																	Class211 class4;
																	Mission.Flight flight_ = (class4 = aircraft.method_157()).method_7();
																	List<Contact> list10;
																	Contact value2 = (list10 = list9)[0];
																	int int_ = @class.strike_0.int_10;
																	int int_2 = @class.strike_0.int_11;
																	Doctrine.Enum56? nullable_3 = @class.strike_0.doctrine_0.method_152(this.activeUnit_0.scenario_0, false, false, false, false);
																	bool bool_16 = this.activeUnit_0.vmethod_101().bool_17;
																	Mission.Enum92 enum92_ = @class.strike_0.enum92_0;
																	bool bool_17 = true;
																	bool bool_18 = true;
																	bool bool_19 = true;
																	bool bool_20 = @class.strike_0.bool_22;
																	float num2 = 0f;
																	bool bool_21 = false;
																	bool flag = true;
																	bool bool_22 = false;
																	float num3 = 0f;
																	float num4 = 0f;
																	string text2;
																	bool flag2 = activeUnit_AI.method_30(ref activeUnit_.scenario_0, ref value, ref mission, ref flight_, ref value2, int_, int_2, nullable_3, bool_16, enum92_, bool_17, bool_18, bool_19, bool_20, ref num2, ref text2, bool_21, ref flag, bool_22, ref num3, ref num4, false, list9[0], true, null, null, false, true);
																	list10[0] = value2;
																	class4.method_8(flight_);
																	activeUnit_2.vmethod_8(false, value);
																	if (flag2)
																	{
																		this.vmethod_4(list9[0]);
																	}
																	else
																	{
																		if (!string.IsNullOrEmpty(text2))
																		{
																			string text3 = "";
																			if (this.method_112().bool_3 && Operators.CompareString(this.method_112().Name, this.method_112().string_2, false) != 0)
																			{
																				text3 = " (" + this.method_112().string_2 + ")";
																			}
																			this.method_112().scenario_0.method_59(string.Concat(new string[]
																			{
																				"Aircraft ",
																				this.method_112().Name,
																				text3,
																				" with loadout ",
																				this.method_112().method_165(),
																				" is not allowed to engage a new target. Reason: ",
																				text2
																			}), this.method_112().Name + " not allowed to engage", LoggedMessage.MessageType.AirOps, 0, null, this.method_112().vmethod_7(false), new Geopoint_Struct(this.method_112().vmethod_28(null), this.method_112().vmethod_30(null)));
																		}
																		this.vmethod_4(null);
																	}
																}
															}
															else
															{
																this.vmethod_4(list9[0]);
															}
														}
													}
												}
											}
											else
											{
												Strike strike = (Strike)this.activeUnit_0.vmethod_101();
												List<Contact> list_ = list;
												Mission mission2 = strike;
												Mission._FlightSize flightSize = Mission._FlightSize.SingleAircraft;
												int num5 = mission2.method_34(ref flightSize, ref strike._FlightQty_7);
												Mission mission3 = strike;
												flightSize = Mission._FlightSize.SingleAircraft;
												base.method_56(list_, num5, mission3.method_34(ref flightSize, ref strike._FlightQty_6), (float)strike.int_8);
											}
										}
										else if (this.activeUnit_0.method_68())
										{
											Class343 class5 = (Class343)this.activeUnit_0.vmethod_101();
											GlobalVariables.PatrolType patrolType_ = ((Class343)this.activeUnit_0.vmethod_101()).patrolType_0;
											if (patrolType_ == GlobalVariables.PatrolType.SEAD)
											{
												List<Contact> list_2 = list;
												Mission mission4 = class5;
												Mission._FlightSize flightSize = Mission._FlightSize.SingleAircraft;
												base.method_44(list_2, mission4.method_34(ref flightSize, ref class5._FlightQty_2), (float)class5.int_8);
											}
											else
											{
												List<Contact> list_3 = list;
												Mission mission5 = class5;
												Mission._FlightSize flightSize = Mission._FlightSize.SingleAircraft;
												int num6 = mission5.method_34(ref flightSize, ref class5._FlightQty_2);
												Mission mission6 = class5;
												flightSize = Mission._FlightSize.SingleAircraft;
												base.method_56(list_3, num6, mission6.method_34(ref flightSize, ref class5._FlightQty_1), (float)class5.int_8);
											}
										}
										else if (!Information.IsNothing(this.method_112().method_167()))
										{
											if (this.method_112().method_167().method_10())
											{
												Aircraft_AI.Class244 class6 = new Aircraft_AI.Class244(class6);
												Contact contact5 = null;
												List<Contact> list11 = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(Enumerable.Select<Contact, Contact>(list, (Aircraft_AI._Closure$__.$I12-18 == null) ? (Aircraft_AI._Closure$__.$I12-18 = new Func<Contact, Contact>(Aircraft_AI._Closure$__.$I.method_7)) : Aircraft_AI._Closure$__.$I12-18), new Func<Contact, double>(this.method_152)));
												List<ActiveUnit> list12 = Enumerable.ToList<ActiveUnit>(this.activeUnit_0.vmethod_7(false).activeUnit_0);
												try
												{
													List<Contact>.Enumerator enumerator4 = list11.GetEnumerator();
													while (enumerator4.MoveNext())
													{
														Aircraft_AI.Class245 class7 = new Aircraft_AI.Class245(class7);
														class7.contact_0 = enumerator4.Current;
														class6.string_0 = class7.contact_0.string_0;
														List<ActiveUnit> list13 = Enumerable.ToList<ActiveUnit>(Enumerable.OrderBy<ActiveUnit, double>(Enumerable.Where<ActiveUnit>(list12, (class6.func_0 == null) ? (class6.func_0 = new Func<ActiveUnit, bool>(class6.method_0)) : class6.func_0), new Func<ActiveUnit, double>(class7.method_0)));
														if (list13.Count != 0)
														{
															if (list13[0] != this.activeUnit_0)
															{
																continue;
															}
															contact5 = class7.contact_0;
														}
														else
														{
															contact5 = class7.contact_0;
														}
														break;
													}
												}
												finally
												{
													List<Contact>.Enumerator enumerator4;
													((IDisposable)enumerator4).Dispose();
												}
												if (Information.IsNothing(contact5))
												{
													List<Contact> list14;
													if (this.activeUnit_0.vmethod_90().vmethod_1())
													{
														list14 = ParallelEnumerable.ToList<Contact>(ParallelEnumerable.ThenBy<Contact, double>(ParallelEnumerable.OrderBy<Contact, int>(ParallelEnumerable.Select<Contact, Contact>(ParallelEnumerable.AsParallel<Contact>(list), (Aircraft_AI._Closure$__.$I12-22 == null) ? (Aircraft_AI._Closure$__.$I12-22 = new Func<Contact, Contact>(Aircraft_AI._Closure$__.$I.method_8)) : Aircraft_AI._Closure$__.$I12-22), new Func<Contact, int>(this.method_153)), new Func<Contact, double>(this.method_154)));
													}
													else
													{
														list14 = ParallelEnumerable.ToList<Contact>(ParallelEnumerable.OrderBy<Contact, double>(ParallelEnumerable.Select<Contact, Contact>(ParallelEnumerable.AsParallel<Contact>(list), (Aircraft_AI._Closure$__.$I12-26 == null) ? (Aircraft_AI._Closure$__.$I12-26 = new Func<Contact, Contact>(Aircraft_AI._Closure$__.$I.method_10)) : Aircraft_AI._Closure$__.$I12-26), new Func<Contact, double>(this.method_155)));
													}
													this.vmethod_4(list14[0]);
												}
												else
												{
													this.vmethod_4(contact5);
												}
											}
											else
											{
												List<Contact> list15 = Enumerable.ToList<Contact>(Enumerable.OrderByDescending<Contact, GlobalVariables.TargetVisualSizeClass>(Enumerable.Where<Contact>(list, (Aircraft_AI._Closure$__.$I12-28 == null) ? (Aircraft_AI._Closure$__.$I12-28 = new Func<Contact, bool>(Aircraft_AI._Closure$__.$I.method_11)) : Aircraft_AI._Closure$__.$I12-28), new Func<Contact, GlobalVariables.TargetVisualSizeClass>(this.method_156)));
												if (list15.Count > 0)
												{
													this.vmethod_4(list15[0]);
												}
											}
										}
										IL_D57:
										if (Information.IsNothing(this.activeUnit_0))
										{
											return;
										}
										List<Contact> list16 = new List<Contact>();
										try
										{
											foreach (Contact contact6 in list)
											{
												if (Information.IsNothing(this.activeUnit_0))
												{
													break;
												}
												if (Enumerable.Contains<Contact>(base.method_15(), contact6) && this.activeUnit_0.method_37(contact6, 0f) < 5f)
												{
													list16.Add(contact6);
												}
												if (list16.Count == 1)
												{
													this.vmethod_4(list16[0]);
												}
												double num7 = 20000.0;
												try
												{
													foreach (Contact contact7 in list16)
													{
														double num8 = (double)this.activeUnit_0.method_37(contact7, 0f);
														if (num8 < num7)
														{
															this.vmethod_4(contact7);
															num7 = num8;
														}
													}
												}
												finally
												{
													List<Contact>.Enumerator enumerator6;
													((IDisposable)enumerator6).Dispose();
												}
											}
										}
										finally
										{
											List<Contact>.Enumerator enumerator5;
											((IDisposable)enumerator5).Dispose();
										}
										list16 = null;
										return;
									}
								}
							}
							this.vmethod_4(null);
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100377", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x000DF804 File Offset: 0x000DDA04
		private void method_113(double double_4, Doctrine.Enum57 enum57_0)
		{
			if (!this.method_112().method_121() && (this.method_112().bool_28 || this.method_112().bool_27))
			{
				Doctrine.Enum56? @enum = this.method_112().doctrine_0.method_152(this.method_112().scenario_0, false, false, false, false);
				byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
				if (!((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					try
					{
						float num = float.MaxValue;
						ActiveUnit activeUnit = this.activeUnit_0;
						if (this.activeUnit_0.method_120())
						{
							try
							{
								foreach (ActiveUnit activeUnit2 in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
								{
									if ((float)activeUnit2.vmethod_116() < num)
									{
										num = (float)activeUnit2.vmethod_116();
										activeUnit = activeUnit2;
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
						ActiveUnit activeUnit3 = activeUnit;
						double num2 = 0.0;
						double num3 = 0.0;
						if (activeUnit3.vmethod_119(ref num2, ref num3, true) < double_4)
						{
							GeoPoint geoPoint = base.method_18();
							if (!Information.IsNothing(geoPoint))
							{
								Aircraft_AirOps aircraft_AirOps = this.method_112().method_164();
								GeoPoint geoPoint_ = geoPoint;
								bool flag = false;
								bool bool_ = false;
								ActiveUnit activeUnit4 = null;
								List<Mission> list = null;
								string text = "";
								bool flag2 = false;
								bool flag3 = false;
								aircraft_AirOps.method_80(geoPoint_, enum57_0, ref flag, bool_, ref activeUnit4, ref list, ref text, ref flag2, ref flag3);
							}
						}
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 100378", "");
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
				}
			}
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x000DF9E8 File Offset: 0x000DDBE8
		public override void vmethod_11(float float_3, bool bool_11, bool bool_12)
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0))
				{
					Aircraft_AirOps aircraft_AirOps = this.method_112().method_164();
					if (aircraft_AirOps.method_36() != Aircraft_AirOps._AirOpsCondition.EmergencyLanding)
					{
						bool flag = base.method_37();
						bool flag2 = false;
						if (this.activeUnit_0.vmethod_85().method_46())
						{
							flag2 = true;
						}
						else if (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_46())
						{
							flag2 = true;
						}
						Doctrine.Enum61? @enum = this.activeUnit_0.doctrine_0.method_137(this.activeUnit_0.scenario_0, false, false, false);
						byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							if (!Information.IsNothing(this.contact_1))
							{
								if (Information.IsNothing(this.activeUnit_0.vmethod_101()) || this.activeUnit_0.vmethod_101()._MissionClass_0 != Mission._MissionClass.Strike || (!this.method_112().method_157().method_22() && (!this.activeUnit_0.method_121() || Information.IsNothing(this.activeUnit_0.method_122()) || !this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_22())))
								{
									this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedDefensive);
									return;
								}
							}
							else if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
							{
								this.activeUnit_0.vmethod_109(this.activeUnit_0._ActiveUnitStatus_3);
							}
						}
						if (this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
						{
							if (aircraft_AirOps.method_36() != Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel)
							{
								if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling && aircraft_AirOps.method_36() == Aircraft_AirOps._AirOpsCondition.Refuelling)
								{
									return;
								}
								if (aircraft_AirOps.method_36() == Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown)
								{
									this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB_Manual);
									return;
								}
								ActiveUnit activeUnit_ = this.activeUnit_0;
								Mission.Flight flight_ = null;
								Exception ex = null;
								if (Class522.smethod_8(activeUnit_, flight_, ref ex))
								{
									this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.WaitForPathfinder);
									return;
								}
								if (this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse)
								{
									Unit activeUnit_2 = this.activeUnit_0;
									double double_ = this.activeUnit_0.vmethod_30(null);
									double double_2 = this.activeUnit_0.vmethod_28(null);
									int num = 0;
									bool bool_13 = true;
									bool bool_14 = true;
									bool bool_15 = false;
									bool flag3 = true;
									bool bool_16 = true;
									bool flag4 = true;
									float? nullable_ = null;
									short? nullable_2 = null;
									List<ActiveUnit> list = null;
									float float_4 = 0f;
									bool bool_17 = false;
									bool bool_18 = true;
									string text = "";
									bool flag5 = false;
									if (!activeUnit_2.vmethod_47(double_, double_2, ref num, bool_13, bool_14, bool_15, ref flag3, bool_16, ref flag4, nullable_, nullable_2, ref list, float_4, bool_17, bool_18, ref text, ref flag5))
									{
										if (!this.activeUnit_0.vmethod_85().method_47())
										{
											ActiveUnit_Navigator activeUnit_Navigator = this.activeUnit_0.vmethod_85();
											double double_3 = this.activeUnit_0.vmethod_30(null);
											double double_4 = this.activeUnit_0.vmethod_28(null);
											list = null;
											Waypoint waypoint = activeUnit_Navigator.method_9(double_3, double_4, ref list);
											if (!Information.IsNothing(waypoint))
											{
												ActiveUnit_Navigator activeUnit_Navigator2 = this.activeUnit_0.vmethod_85();
												Waypoint[] waypoint_ = activeUnit_Navigator2.method_4();
												Class429.smethod_39(ref waypoint_, 0, waypoint);
												activeUnit_Navigator2.method_5(waypoint_);
												this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
												return;
											}
										}
										else
										{
											Waypoint waypoint2 = this.activeUnit_0.vmethod_85().method_4()[0];
											if (waypoint2.waypointType_0 != Waypoint.WaypointType.PathfindingPoint)
											{
												ActiveUnit_Navigator activeUnit_Navigator3 = this.activeUnit_0.vmethod_85();
												double double_5 = this.activeUnit_0.vmethod_30(null);
												double double_6 = this.activeUnit_0.vmethod_28(null);
												list = null;
												Waypoint waypoint3 = activeUnit_Navigator3.method_9(double_5, double_6, ref list);
												Unit activeUnit_3 = this.activeUnit_0;
												double double_7 = waypoint2.imethod_2();
												double double_8 = waypoint2.imethod_0();
												num = 0;
												bool bool_19 = true;
												bool bool_20 = true;
												bool bool_21 = false;
												flag5 = true;
												bool bool_22 = true;
												flag4 = true;
												float? nullable_3 = null;
												short? nullable_4 = null;
												list = null;
												float float_5 = 0f;
												bool bool_23 = false;
												bool bool_24 = true;
												text = "";
												flag3 = false;
												if (!activeUnit_3.vmethod_47(double_7, double_8, ref num, bool_19, bool_20, bool_21, ref flag5, bool_22, ref flag4, nullable_3, nullable_4, ref list, float_5, bool_23, bool_24, ref text, ref flag3))
												{
													ActiveUnit_Navigator activeUnit_Navigator4 = this.activeUnit_0.vmethod_85();
													Waypoint[] waypoint_ = activeUnit_Navigator4.method_4();
													Class429.smethod_39(ref waypoint_, 0, waypoint3);
													activeUnit_Navigator4.method_5(waypoint_);
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
													return;
												}
												if (this.activeUnit_0.method_28(waypoint3) + 0.2 < this.activeUnit_0.method_28(waypoint2))
												{
													ActiveUnit_Navigator activeUnit_Navigator5 = this.activeUnit_0.vmethod_85();
													Waypoint[] waypoint_ = activeUnit_Navigator5.method_4();
													Class429.smethod_39(ref waypoint_, 0, waypoint3);
													activeUnit_Navigator5.method_5(waypoint_);
												}
												this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
												return;
											}
										}
									}
								}
								bool? flag9;
								if (this.activeUnit_0.scenario_0.FifteenthSecondIsChangingOnThisPulse || bool_11)
								{
									if (this.method_112().vmethod_110() != ActiveUnit._ActiveUnitFuelState.IgnoreBingoAndJoker)
									{
										ActiveUnit._ActiveUnitFuelState activeUnitFuelState = this.method_112().vmethod_61(null, this.method_112().doctrine_0.method_206(this.method_112().scenario_0, false, true, false, false));
										if ((activeUnitFuelState == ActiveUnit._ActiveUnitFuelState.IsBingo || activeUnitFuelState == ActiveUnit._ActiveUnitFuelState.IsJoker) && aircraft_AirOps.method_36() != Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue)
										{
											bool flag6 = this.method_112().vmethod_108() == ActiveUnit._ActiveUnitStatus.RTB_Manual || this.method_112().vmethod_108() == ActiveUnit._ActiveUnitStatus.RTB_MissionOver || (this.method_112().vmethod_108() == ActiveUnit._ActiveUnitStatus.RTB && this.activeUnit_0.vmethod_110() == ActiveUnit._ActiveUnitFuelState.None) || this.method_112()._ActiveUnitStatus_2 == ActiveUnit._ActiveUnitStatus.RTB_Manual || this.method_112()._ActiveUnitStatus_2 == ActiveUnit._ActiveUnitStatus.RTB_MissionOver || (this.method_112()._ActiveUnitStatus_2 == ActiveUnit._ActiveUnitStatus.RTB && this.activeUnit_0.vmethod_110() == ActiveUnit._ActiveUnitFuelState.None);
											bool flag7 = false;
											if (this.method_112().vmethod_110() != activeUnitFuelState)
											{
												this.method_112().method_142();
											}
											this.method_112().vmethod_111(activeUnitFuelState);
											if (!this.activeUnit_0.method_94() && !this.activeUnit_0.method_95() && this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.RTB_CalledOff)
											{
												GeoPoint geoPoint = base.method_18();
												if (flag6)
												{
													Aircraft_AirOps aircraft_AirOps2 = aircraft_AirOps;
													GeoPoint geoPoint_ = geoPoint;
													Doctrine.Enum57 enum57_ = Doctrine.Enum57.const_2;
													bool flag3 = false;
													bool bool_25 = false;
													ActiveUnit activeUnit = null;
													List<Mission> list2 = null;
													string text = "";
													bool flag4 = true;
													if (aircraft_AirOps2.method_80(geoPoint_, enum57_, ref flag3, bool_25, ref activeUnit, ref list2, ref text, ref flag4, ref flag7))
													{
														return;
													}
												}
												else if (!Information.IsNothing(geoPoint))
												{
													Doctrine.Enum56? enum2;
													bool? flag8;
													bool? flag12;
													if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Ferry && this.activeUnit_0.vmethod_101().int_5 > 0)
													{
														enum2 = this.activeUnit_0.doctrine_0.method_152(this.activeUnit_0.scenario_0, false, false, false, false);
														b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
														flag8 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null);
														flag9 = (flag8 = ((flag8 != null) ? new bool?(!flag8.GetValueOrDefault()) : flag8));
														bool? flag10;
														if (flag8 != null && !flag9.GetValueOrDefault())
														{
															flag10 = new bool?(false);
														}
														else
														{
															bool? flag11;
															if (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()))
															{
																enum2 = this.activeUnit_0.vmethod_65(false).method_147().doctrine_0.method_152(this.activeUnit_0.scenario_0, false, false, false, false);
																b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
																flag11 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null);
															}
															else
															{
																flag11 = new bool?(false);
															}
															flag8 = flag11;
															flag12 = (flag8 = ((flag8 != null) ? new bool?(!flag8.GetValueOrDefault()) : flag8));
															flag10 = ((flag8 != null) ? (flag9 & flag12.GetValueOrDefault()) : null);
														}
														flag12 = flag10;
														if (flag12.GetValueOrDefault())
														{
															float num2 = float.MaxValue;
															ActiveUnit activeUnit2 = this.activeUnit_0;
															if (this.activeUnit_0.method_120())
															{
																try
																{
																	foreach (ActiveUnit activeUnit3 in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
																	{
																		if ((float)activeUnit3.vmethod_116() < num2)
																		{
																			num2 = (float)activeUnit3.vmethod_116();
																			activeUnit2 = activeUnit3;
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
															ActiveUnit activeUnit4 = activeUnit2;
															double num3 = 0.0;
															double num4 = 0.0;
															if (activeUnit4.vmethod_119(ref num3, ref num4, true) > (double)((float)((double)this.activeUnit_0.vmethod_101().int_5 / 100.0)))
															{
																return;
															}
														}
													}
													enum2 = this.activeUnit_0.doctrine_0.method_152(this.activeUnit_0.scenario_0, false, false, false, false);
													b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
													flag8 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null);
													flag12 = (flag8 = ((flag8 != null) ? new bool?(!flag8.GetValueOrDefault()) : flag8));
													bool? flag13;
													if (flag8 != null && !flag12.GetValueOrDefault())
													{
														flag13 = new bool?(false);
													}
													else
													{
														bool? flag14;
														if (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()))
														{
															enum2 = this.activeUnit_0.vmethod_65(false).method_147().doctrine_0.method_152(this.activeUnit_0.scenario_0, false, false, false, false);
															b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
															flag14 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null);
														}
														else
														{
															flag14 = new bool?(false);
														}
														flag8 = flag14;
														flag9 = (flag8 = ((flag8 != null) ? new bool?(!flag8.GetValueOrDefault()) : flag8));
														flag13 = ((flag8 != null) ? (flag12 & flag9.GetValueOrDefault()) : null);
													}
													flag9 = flag13;
													if (flag9.GetValueOrDefault())
													{
														Aircraft_AirOps aircraft_AirOps3 = aircraft_AirOps;
														GeoPoint geoPoint_2 = geoPoint;
														Doctrine.Enum57 value = this.activeUnit_0.doctrine_0.method_157(this.activeUnit_0.scenario_0, false, false, false, false).Value;
														bool flag4 = false;
														bool bool_26 = false;
														ActiveUnit activeUnit = null;
														List<Mission> list2 = null;
														string text = "";
														bool flag3 = false;
														if (aircraft_AirOps3.method_80(geoPoint_2, value, ref flag4, bool_26, ref activeUnit, ref list2, ref text, ref flag3, ref flag7))
														{
															return;
														}
													}
													if (!flag7)
													{
														if (this.activeUnit_0.vmethod_85().method_32())
														{
															if (this.activeUnit_0.vmethod_85().method_28() || this.activeUnit_0.vmethod_85().method_25() || (this.activeUnit_0.vmethod_85().method_48() && this.activeUnit_0.vmethod_85().method_7().method_10(this.activeUnit_0.scenario_0) != Mission.Enum102.const_8 && ((!Information.IsNothing(this.activeUnit_0.vmethod_101()) && (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol || this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support)) || this.activeUnit_0.vmethod_86().bool_2)))
															{
																bool flag15 = false;
																Doctrine._FuelStateRTB? fuelStateRTB = this.activeUnit_0.doctrine_0.method_122(this.activeUnit_0.scenario_0, false, false, false);
																if (!this.activeUnit_0.method_120())
																{
																	b = ((fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
																	flag9 = ((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null);
																	if (((flag9 != null) ? new bool?(!flag9.GetValueOrDefault()) : flag9).GetValueOrDefault() && this.method_112().method_164().method_36() != Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue)
																	{
																		flag15 = true;
																	}
																}
																else
																{
																	b = ((fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
																	if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
																	{
																		this.activeUnit_0.method_129(false, false, true);
																		flag15 = true;
																	}
																	else
																	{
																		b = ((fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
																		if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
																		{
																			flag15 = true;
																		}
																		else
																		{
																			b = ((fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null);
																			if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
																			{
																				bool flag16 = true;
																				try
																				{
																					IEnumerator<ActiveUnit> enumerator2 = this.activeUnit_0.vmethod_65(false).vmethod_141().Values.GetEnumerator();
																					while (enumerator2.MoveNext())
																					{
																						if (enumerator2.Current.vmethod_110() == ActiveUnit._ActiveUnitFuelState.None)
																						{
																							flag16 = false;
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
																				if (flag16)
																				{
																					flag15 = true;
																				}
																			}
																		}
																	}
																}
																if (flag15)
																{
																	this.activeUnit_0.vmethod_85().vmethod_12(float_3, false);
																	this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB_CalledOff);
																	return;
																}
															}
														}
														else if (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_32() && (this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_28() || this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_25() || (this.activeUnit_0.vmethod_85().method_48() && this.activeUnit_0.vmethod_85().method_7().method_10(this.activeUnit_0.scenario_0) != Mission.Enum102.const_8 && ((!Information.IsNothing(this.activeUnit_0.vmethod_101()) && (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol || this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support)) || this.activeUnit_0.vmethod_86().bool_2))))
														{
															bool flag17 = false;
															Doctrine._FuelStateRTB? fuelStateRTB2 = this.activeUnit_0.doctrine_0.method_122(this.activeUnit_0.scenario_0, false, false, false);
															b = ((fuelStateRTB2 != null) ? new byte?((byte)fuelStateRTB2.GetValueOrDefault()) : null);
															if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
															{
																this.activeUnit_0.method_129(false, false, true);
																flag17 = true;
															}
															else
															{
																b = ((fuelStateRTB2 != null) ? new byte?((byte)fuelStateRTB2.GetValueOrDefault()) : null);
																if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
																{
																	if (this.activeUnit_0.vmethod_65(false).method_147().vmethod_108() != ActiveUnit._ActiveUnitStatus.RTB_CalledOff)
																	{
																		this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().vmethod_12(float_3, false);
																		this.activeUnit_0.vmethod_65(false).method_147().vmethod_109(ActiveUnit._ActiveUnitStatus.RTB_CalledOff);
																	}
																	flag17 = true;
																}
															}
															if (flag17)
															{
																this.activeUnit_0.vmethod_85().vmethod_12(float_3, false);
																this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB_CalledOff);
																return;
															}
														}
													}
													if ((this.activeUnit_0.vmethod_85().method_32() || (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_32())) && this.activeUnit_0.vmethod_85().vmethod_13(float_3))
													{
														return;
													}
												}
												else
												{
													if (this.method_112().vmethod_108() != ActiveUnit._ActiveUnitStatus.RTB_Manual && this.method_112().vmethod_108() != ActiveUnit._ActiveUnitStatus.RTB_MissionOver && this.method_112().vmethod_108() != ActiveUnit._ActiveUnitStatus.RTB && this.method_112()._ActiveUnitStatus_2 != ActiveUnit._ActiveUnitStatus.RTB_MissionOver && this.method_112()._ActiveUnitStatus_2 != ActiveUnit._ActiveUnitStatus.RTB && this.method_112().vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsBingo && this.method_112().vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsJoker)
													{
														Aircraft_AirOps aircraft_AirOps4 = aircraft_AirOps;
														GeoPoint geoPoint_3 = null;
														Doctrine.Enum57 value2 = this.activeUnit_0.doctrine_0.method_157(this.activeUnit_0.scenario_0, false, false, false, false).Value;
														bool flag3 = false;
														bool bool_27 = false;
														ActiveUnit activeUnit = null;
														List<Mission> list2 = null;
														string text = "";
														bool flag4 = false;
														if (aircraft_AirOps4.method_80(geoPoint_3, value2, ref flag3, bool_27, ref activeUnit, ref list2, ref text, ref flag4, ref flag7))
														{
															return;
														}
													}
													else
													{
														Aircraft_AirOps aircraft_AirOps5 = aircraft_AirOps;
														GeoPoint geoPoint_4 = null;
														Doctrine.Enum57 enum57_2 = Doctrine.Enum57.const_2;
														bool flag4 = false;
														bool bool_28 = false;
														ActiveUnit activeUnit = null;
														List<Mission> list2 = null;
														string text = "";
														bool flag3 = true;
														if (aircraft_AirOps5.method_80(geoPoint_4, enum57_2, ref flag4, bool_28, ref activeUnit, ref list2, ref text, ref flag3, ref flag7))
														{
															return;
														}
													}
													if (!flag7 && this.activeUnit_0.vmethod_85().method_49() && Enumerable.Count<Waypoint>(this.activeUnit_0.vmethod_85().method_4()) > 0 && (this.activeUnit_0.vmethod_85().method_28() || this.activeUnit_0.vmethod_85().method_25() || (this.activeUnit_0.vmethod_85().method_48() && this.activeUnit_0.vmethod_85().method_7().method_10(this.activeUnit_0.scenario_0) != Mission.Enum102.const_8 && ((!Information.IsNothing(this.activeUnit_0.vmethod_101()) && (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol || this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support)) || this.activeUnit_0.vmethod_86().bool_2))))
													{
														this.activeUnit_0.vmethod_85().vmethod_12(float_3, false);
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB_CalledOff);
														return;
													}
												}
												if (aircraft_AirOps.method_36() != Aircraft_AirOps._AirOpsCondition.RTB || !this.activeUnit_0.method_85())
												{
													if (!this.activeUnit_0.vmethod_85().method_32() && (!this.activeUnit_0.method_121() || Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) || !this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_32()))
													{
														Doctrine._FuelStateRTB? fuelStateRTB3 = this.activeUnit_0.doctrine_0.method_122(this.activeUnit_0.scenario_0, false, false, false);
														if (!this.activeUnit_0.method_120())
														{
															b = ((fuelStateRTB3 != null) ? new byte?((byte)fuelStateRTB3.GetValueOrDefault()) : null);
															flag9 = ((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null);
															if (((flag9 != null) ? new bool?(!flag9.GetValueOrDefault()) : flag9).GetValueOrDefault() && !this.method_112().method_161().method_59())
															{
																this.method_112().method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
															}
														}
														else
														{
															b = ((fuelStateRTB3 != null) ? new byte?((byte)fuelStateRTB3.GetValueOrDefault()) : null);
															if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
															{
																if (!this.method_112().method_161().method_59())
																{
																	this.method_112().method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
																}
															}
															else
															{
																b = ((fuelStateRTB3 != null) ? new byte?((byte)fuelStateRTB3.GetValueOrDefault()) : null);
																if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
																{
																	if (!this.method_112().method_161().method_59())
																	{
																		this.method_112().method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB, true, ActiveUnit._ActiveUnitStatus.RTB_Group, false, true);
																	}
																}
																else
																{
																	b = ((fuelStateRTB3 != null) ? new byte?((byte)fuelStateRTB3.GetValueOrDefault()) : null);
																	if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
																	{
																		bool flag18 = true;
																		try
																		{
																			IEnumerator<ActiveUnit> enumerator3 = this.activeUnit_0.vmethod_65(false).vmethod_141().Values.GetEnumerator();
																			while (enumerator3.MoveNext())
																			{
																				if (enumerator3.Current.vmethod_110() == ActiveUnit._ActiveUnitFuelState.None)
																				{
																					flag18 = false;
																					break;
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
																		if (flag18 && !this.method_112().method_161().method_59())
																		{
																			this.method_112().method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB, true, ActiveUnit._ActiveUnitStatus.RTB_Group, false, true);
																		}
																	}
																}
															}
														}
														return;
													}
													if (!flag7 && this.activeUnit_0.vmethod_85().method_49() && Enumerable.Count<Waypoint>(this.activeUnit_0.vmethod_85().method_4()) > 0 && (this.activeUnit_0.vmethod_85().method_28() || this.activeUnit_0.vmethod_85().method_25() || (this.activeUnit_0.vmethod_85().method_48() && this.activeUnit_0.vmethod_85().method_7().method_10(this.activeUnit_0.scenario_0) != Mission.Enum102.const_8 && ((!Information.IsNothing(this.activeUnit_0.vmethod_101()) && (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol || this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support)) || this.activeUnit_0.vmethod_86().bool_2))))
													{
														this.activeUnit_0.vmethod_85().vmethod_12(float_3, false);
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB_CalledOff);
														return;
													}
												}
											}
										}
										else if (this.method_112().vmethod_110() != activeUnitFuelState)
										{
											this.method_112().vmethod_111(activeUnitFuelState);
										}
									}
									if (this.method_112().method_157().method_47() && this.method_112().scenario_0.MinuteIsChangingOnThisPulse)
									{
										if (this.activeUnit_0.vmethod_85().method_21())
										{
											float num5;
											if (!Information.IsNothing(this.method_112().vmethod_101()))
											{
												if (this.activeUnit_0.vmethod_101().int_5 > 0)
												{
													num5 = (float)((double)this.activeUnit_0.vmethod_101().int_5 / 100.0);
												}
												else
												{
													num5 = 0f;
												}
											}
											else
											{
												num5 = 0.85f;
											}
											this.method_113((double)num5, this.activeUnit_0.doctrine_0.method_157(this.activeUnit_0.scenario_0, false, false, false, false).Value);
										}
										else if (this.method_112().method_157().method_4()[0].waypointType_0 == Waypoint.WaypointType.PatrolStation)
										{
											float num6;
											if (!Information.IsNothing(this.method_112().vmethod_101()))
											{
												if (this.activeUnit_0.vmethod_101().int_5 > 0)
												{
													num6 = (float)((double)this.activeUnit_0.vmethod_101().int_5 / 100.0);
												}
												else
												{
													num6 = 0f;
												}
											}
											else
											{
												num6 = 0.6f;
											}
											if (num6 > 0f)
											{
												this.method_113((double)num6, this.activeUnit_0.doctrine_0.method_157(this.activeUnit_0.scenario_0, false, false, false, false).Value);
											}
										}
									}
									if (this.bool_2 && this.activeUnit_0.method_85())
									{
										bool flag19 = false;
										bool flag20 = false;
										List<ActiveUnit> list3 = Enumerable.ToList<ActiveUnit>(this.activeUnit_0.vmethod_7(false).activeUnit_0);
										if (!Information.IsNothing(this.method_112().vmethod_101()) && this.method_112().vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
										{
											try
											{
												foreach (ActiveUnit activeUnit5 in list3)
												{
													if (!activeUnit5.bool_1 && !Information.IsNothing(activeUnit5.vmethod_101()) && activeUnit5.vmethod_101() == this.activeUnit_0.vmethod_101())
													{
														if (activeUnit5.vmethod_127())
														{
															if (!activeUnit5.vmethod_86().bool_2)
															{
																flag19 = true;
																break;
															}
														}
														else if (!activeUnit5.vmethod_86().bool_2)
														{
															Aircraft_AirOps aircraft_AirOps6 = ((Aircraft)activeUnit5).method_164();
															if (aircraft_AirOps6.method_36() != Aircraft_AirOps._AirOpsCondition.Readying && aircraft_AirOps6.method_36() != Aircraft_AirOps._AirOpsCondition.TaxyingToPark && aircraft_AirOps6.method_36() != Aircraft_AirOps._AirOpsCondition.Landing_PostTouchdown && aircraft_AirOps6.method_36() != Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck)
															{
																flag20 = true;
															}
														}
													}
												}
											}
											finally
											{
												List<ActiveUnit>.Enumerator enumerator4;
												((IDisposable)enumerator4).Dispose();
											}
										}
										if (!flag20 && !flag19)
										{
											this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
											this.vmethod_29(float_3);
										}
									}
								}
								if (this.activeUnit_0.method_85())
								{
									if (this.activeUnit_0.method_94())
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
										return;
									}
									if (aircraft_AirOps.method_36() != Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue && aircraft_AirOps.method_36() != Aircraft_AirOps._AirOpsCondition.RTB)
									{
										aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.RTB);
									}
								}
								if (aircraft_AirOps.method_36() == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar | aircraft_AirOps.method_36() == Aircraft_AirOps._AirOpsCondition.TransferringCargo)
								{
									return;
								}
								if (this.method_112().vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IgnoreWinchesterAndShotgun)
								{
									ActiveUnit._ActiveUnitWeaponState activeUnitWeaponState = this.method_112().method_161().vmethod_5();
									if (activeUnitWeaponState != ActiveUnit._ActiveUnitWeaponState.IsWinchester)
									{
										if (activeUnitWeaponState != ActiveUnit._ActiveUnitWeaponState.IsShotgun)
										{
											if (this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse && this.activeUnit_0.vmethod_85().method_23())
											{
												Doctrine.Enum56? enum2 = this.method_112().doctrine_0.method_152(this.activeUnit_0.scenario_0, false, false, false, false);
												b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
												flag9 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null);
												if (((flag9 != null) ? new bool?(!flag9.GetValueOrDefault()) : flag9).GetValueOrDefault())
												{
													Class211 @class = (Class211)this.activeUnit_0.vmethod_85();
													ActiveUnit.Throttle throttle_ = @class.method_72();
													bool flag5 = false;
													float num7 = @class.method_73(ref flag5);
													float num8 = float.MaxValue;
													ActiveUnit activeUnit6 = this.activeUnit_0;
													if (this.activeUnit_0.method_120())
													{
														try
														{
															foreach (ActiveUnit activeUnit7 in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
															{
																if ((float)activeUnit7.vmethod_116() < num8)
																{
																	num8 = (float)activeUnit7.vmethod_116();
																	activeUnit6 = activeUnit7;
																}
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
													ActiveUnit activeUnit8 = ((Aircraft_AirOps)activeUnit6.vmethod_92()).method_21();
													if (!Information.IsNothing(activeUnit8) && (double)activeUnit6.vmethod_87().method_4(activeUnit6.method_36(activeUnit8), throttle_, num7, new float?((float)activeUnit6.vmethod_87().vmethod_40(num7, throttle_, false)), false, false, false) > (double)((float)activeUnit6.vmethod_116() - activeUnit6.vmethod_87().vmethod_4()) * 0.9)
													{
														float num9;
														if (!Information.IsNothing(this.method_112().vmethod_101()))
														{
															if (this.activeUnit_0.vmethod_101().int_5 > 0)
															{
																num9 = (float)((double)this.activeUnit_0.vmethod_101().int_5 / 100.0);
															}
															else
															{
																num9 = 0f;
															}
														}
														else
														{
															num9 = 0.85f;
														}
														if (num9 > 0f)
														{
															this.method_113((double)num9, this.activeUnit_0.doctrine_0.method_157(this.activeUnit_0.scenario_0, false, false, false, false).Value);
														}
													}
												}
											}
											if (this.method_112().vmethod_112() != activeUnitWeaponState)
											{
												this.method_112().vmethod_113(activeUnitWeaponState);
												goto IL_2968;
											}
											goto IL_2968;
										}
									}
									this.activeUnit_0.vmethod_113(activeUnitWeaponState);
									if (!this.activeUnit_0.method_94() && !this.activeUnit_0.method_95() && this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.RTB_CalledOff)
									{
										if (this.activeUnit_0.vmethod_85().method_21())
										{
											this.activeUnit_0.vmethod_85().vmethod_12(float_3, false);
											this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
											return;
										}
										if (this.activeUnit_0.vmethod_85().method_23())
										{
											if (this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse)
											{
												bool? flag21;
												if (Information.IsNothing(this.activeUnit_0.vmethod_101()))
												{
													flag21 = new bool?(false);
												}
												else
												{
													Doctrine.Enum56? enum2 = this.method_112().doctrine_0.method_152(this.activeUnit_0.scenario_0, false, false, false, false);
													b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
													flag9 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null);
													flag21 = ((flag9 != null) ? new bool?(!flag9.GetValueOrDefault()) : flag9);
												}
												flag9 = flag21;
												if (flag9.GetValueOrDefault())
												{
													ActiveUnit.Throttle throttle_2 = this.method_112().method_157().method_72();
													Class211 class2 = this.method_112().method_157();
													bool flag3 = false;
													float num10 = class2.method_73(ref flag3);
													float num11 = float.MaxValue;
													Aircraft aircraft = this.method_112();
													if (this.activeUnit_0.method_120())
													{
														try
														{
															foreach (ActiveUnit activeUnit9 in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
															{
																if ((float)activeUnit9.vmethod_116() < num11)
																{
																	num11 = (float)activeUnit9.vmethod_116();
																	aircraft = (Aircraft)activeUnit9;
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
													}
													ActiveUnit activeUnit10 = aircraft.method_164().method_21();
													if (!Information.IsNothing(activeUnit10) && (double)aircraft.method_159().method_4(aircraft.method_36(activeUnit10), throttle_2, num10, new float?((float)aircraft.method_159().vmethod_40(num10, throttle_2, false)), false, false, false) > (double)((float)aircraft.vmethod_116() - aircraft.method_159().vmethod_4()) * 0.9)
													{
														GeoPoint geoPoint2 = base.method_18();
														Aircraft_AirOps aircraft_AirOps7 = aircraft_AirOps;
														GeoPoint geoPoint_5 = geoPoint2;
														Doctrine.Enum57 value3 = this.activeUnit_0.doctrine_0.method_157(this.activeUnit_0.scenario_0, false, false, false, false).Value;
														flag3 = false;
														bool bool_29 = false;
														ActiveUnit activeUnit = null;
														List<Mission> list2 = null;
														string text = "";
														bool flag4 = true;
														bool flag5 = false;
														if (aircraft_AirOps7.method_80(geoPoint_5, value3, ref flag3, bool_29, ref activeUnit, ref list2, ref text, ref flag4, ref flag5))
														{
															return;
														}
													}
												}
											}
											this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
											return;
										}
										if (this.activeUnit_0.vmethod_85().method_32())
										{
											if (this.activeUnit_0.vmethod_85().method_28() || this.activeUnit_0.vmethod_85().method_25() || (this.activeUnit_0.vmethod_85().method_48() && this.activeUnit_0.vmethod_85().method_7().method_10(this.activeUnit_0.scenario_0) != Mission.Enum102.const_8 && ((!Information.IsNothing(this.activeUnit_0.vmethod_101()) && (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol || this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support)) || this.activeUnit_0.vmethod_86().bool_2)))
											{
												bool flag22 = false;
												Doctrine._WeaponStateRTB? weaponStateRTB = this.activeUnit_0.doctrine_0.method_117(this.activeUnit_0.scenario_0, false, false, false);
												if (!this.activeUnit_0.method_120())
												{
													b = ((weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
													flag9 = ((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null);
													if (((flag9 != null) ? new bool?(!flag9.GetValueOrDefault()) : flag9).GetValueOrDefault() && this.method_112().method_164().method_36() != Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue)
													{
														flag22 = true;
													}
												}
												else
												{
													b = ((weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
													if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
													{
														this.activeUnit_0.method_129(false, false, true);
														flag22 = true;
													}
													else
													{
														b = ((weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
														if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
														{
															flag22 = true;
														}
														else
														{
															b = ((weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null);
															if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
															{
																bool flag23 = true;
																try
																{
																	foreach (ActiveUnit activeUnit11 in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
																	{
																		if (activeUnit11.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.None && activeUnit11.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO)
																		{
																			if (activeUnit11.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO)
																			{
																				continue;
																			}
																		}
																		flag23 = false;
																		break;
																	}
																}
																finally
																{
																	IEnumerator<ActiveUnit> enumerator7;
																	if (enumerator7 != null)
																	{
																		enumerator7.Dispose();
																	}
																}
																if (flag23)
																{
																	flag22 = true;
																}
															}
														}
													}
												}
												if (flag22)
												{
													this.activeUnit_0.vmethod_85().vmethod_12(float_3, false);
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
													return;
												}
											}
										}
										else if (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_32())
										{
											if (this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_28() || this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_25() || (this.activeUnit_0.vmethod_85().method_48() && this.activeUnit_0.vmethod_85().method_7().method_10(this.activeUnit_0.scenario_0) != Mission.Enum102.const_8 && ((!Information.IsNothing(this.activeUnit_0.vmethod_101()) && (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol || this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support)) || this.activeUnit_0.vmethod_86().bool_2)))
											{
												bool flag24 = false;
												Doctrine._WeaponStateRTB? weaponStateRTB2 = this.activeUnit_0.doctrine_0.method_117(this.activeUnit_0.scenario_0, false, false, false);
												b = ((weaponStateRTB2 != null) ? new byte?((byte)weaponStateRTB2.GetValueOrDefault()) : null);
												if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
												{
													this.activeUnit_0.method_129(false, false, true);
													flag24 = true;
												}
												else
												{
													b = ((weaponStateRTB2 != null) ? new byte?((byte)weaponStateRTB2.GetValueOrDefault()) : null);
													if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
													{
														this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().vmethod_12(float_3, false);
														this.activeUnit_0.vmethod_65(false).method_147().vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
													}
												}
												if (flag24)
												{
													this.activeUnit_0.vmethod_85().vmethod_12(float_3, false);
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
													return;
												}
												if (!Information.IsNothing(this.activeUnit_0.vmethod_87().vmethod_10()))
												{
													this.activeUnit_0.vmethod_87().vmethod_11(null);
												}
												if (this.activeUnit_0.vmethod_87().vmethod_1() != ActiveUnit_Kinematics.UnitThrottlePreset.None)
												{
													this.activeUnit_0.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.None);
												}
												if ((Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) || this.activeUnit_0.vmethod_65(false).method_147().vmethod_108() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint) && !Information.IsNothing(this.activeUnit_0.vmethod_101()))
												{
													switch (this.activeUnit_0.vmethod_101()._MissionClass_0)
													{
													case Mission._MissionClass.Strike:
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Tasked);
														return;
													case Mission._MissionClass.Patrol:
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPatrol);
														return;
													case Mission._MissionClass.Support:
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnSupportMission);
														return;
													}
												}
											}
										}
										else if (aircraft_AirOps.method_36() != Aircraft_AirOps._AirOpsCondition.RTB || (!this.activeUnit_0.method_85() && this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.Refuelling))
										{
											Doctrine._WeaponStateRTB? weaponStateRTB3 = this.activeUnit_0.doctrine_0.method_117(this.activeUnit_0.scenario_0, false, false, false);
											if (!this.activeUnit_0.method_120())
											{
												b = ((weaponStateRTB3 != null) ? new byte?((byte)weaponStateRTB3.GetValueOrDefault()) : null);
												flag9 = ((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null);
												if (((flag9 != null) ? new bool?(!flag9.GetValueOrDefault()) : flag9).GetValueOrDefault() && this.method_112().method_164().method_36() != Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue && !this.method_112().method_161().method_59() && this.method_112().method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true))
												{
													return;
												}
											}
											else
											{
												b = ((weaponStateRTB3 != null) ? new byte?((byte)weaponStateRTB3.GetValueOrDefault()) : null);
												if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
												{
													if (!this.method_112().method_161().method_59() && this.method_112().method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true))
													{
														return;
													}
												}
												else
												{
													b = ((weaponStateRTB3 != null) ? new byte?((byte)weaponStateRTB3.GetValueOrDefault()) : null);
													if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
													{
														if (!this.method_112().method_161().method_59() && this.method_112().method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB, true, ActiveUnit._ActiveUnitStatus.RTB_Group, false, true))
														{
															return;
														}
													}
													else
													{
														b = ((weaponStateRTB3 != null) ? new byte?((byte)weaponStateRTB3.GetValueOrDefault()) : null);
														if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
														{
															bool flag25 = true;
															try
															{
																foreach (ActiveUnit activeUnit12 in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
																{
																	if (activeUnit12.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.None && activeUnit12.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO)
																	{
																		if (activeUnit12.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO)
																		{
																			continue;
																		}
																	}
																	flag25 = false;
																	break;
																}
															}
															finally
															{
																IEnumerator<ActiveUnit> enumerator8;
																if (enumerator8 != null)
																{
																	enumerator8.Dispose();
																}
															}
															if (flag25 && !this.method_112().method_161().method_59() && this.method_112().method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB, true, ActiveUnit._ActiveUnitStatus.RTB_Group, false, true))
															{
																return;
															}
														}
													}
												}
											}
										}
									}
								}
								IL_2968:
								if (this.activeUnit_0.method_85())
								{
									return;
								}
								if (this.activeUnit_0.vmethod_86().vmethod_3() == null && aircraft_AirOps.method_36() == Aircraft_AirOps._AirOpsCondition.BVRAttack)
								{
									aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
									this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
								}
								bool? flag26;
								if (!flag2)
								{
									flag26 = new bool?(false);
								}
								else
								{
									Doctrine.Enum64? enum3 = this.method_112().doctrine_0.method_83(this.method_112().scenario_0, false, new bool?(false), false, false);
									b = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
									flag26 = ((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null);
								}
								flag9 = flag26;
								if (((flag9 != null) ? new bool?(!flag9.GetValueOrDefault()) : flag9).GetValueOrDefault() && this.method_112().method_161().method_59())
								{
									this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
									return;
								}
								if (this.activeUnit_0.vmethod_85().method_46())
								{
									if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.RTB_CalledOff)
									{
										return;
									}
									if (!Information.IsNothing(this.vmethod_3()))
									{
										Doctrine.Enum64? enum3 = this.activeUnit_0.doctrine_0.method_83(this.activeUnit_0.scenario_0, false, null, false, false);
										b = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
										if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
											Contact theTarget = this.vmethod_3();
											bool checkWRA = true;
											Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
											string text = "";
											int num = 0;
											if (activeUnit_Weaponry.method_6(theTarget, checkWRA, doctrine_, ref text, ref num, null))
											{
												if (this.method_112().method_68())
												{
													Doctrine.Enum59? enum4 = this.activeUnit_0.doctrine_0.method_162(this.activeUnit_0.scenario_0, false, false, false);
													Contact contact_ = this.vmethod_3();
													Mission mission_ = this.method_112().vmethod_101();
													Doctrine.Enum59? nullable_5 = enum4;
													bool bool_30 = false;
													bool bool_31 = flag;
													bool bool_32 = true;
													Misc.PostureStance? nullable_6 = null;
													text = "";
													num = 0;
													if (base.method_39(contact_, mission_, nullable_5, bool_30, bool_31, bool_32, nullable_6, ref text, ref num))
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
													}
													else if (this.activeUnit_0.vmethod_85().method_49())
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
													}
													else
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPatrol);
													}
												}
												else
												{
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
												}
											}
											else if (this.method_112().method_68())
											{
												if (this.vmethod_3().method_125() < Contact_Base.IdentificationStatus.KnownClass)
												{
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
												}
												else if (!this.activeUnit_0.method_94() && !this.activeUnit_0.method_95())
												{
													if (this.activeUnit_0.vmethod_85().method_49())
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
													}
													else
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPatrol);
													}
												}
												else
												{
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
												}
											}
											return;
										}
									}
									if (!Information.IsNothing(this.vmethod_3()) && this.activeUnit_0.vmethod_85().method_22())
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
										return;
									}
									if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol && !Information.IsNothing(this.vmethod_3()))
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
										return;
									}
									if (aircraft_AirOps.method_36() == Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel)
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
										return;
									}
									if (this.activeUnit_0.vmethod_85().method_47() && (this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.Assemble || this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.HoldStart || this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.HoldEnd) && this.activeUnit_0.method_120() && this.activeUnit_0.vmethod_65(false).method_151())
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.FormingUp);
										return;
									}
									this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
									return;
								}
								else
								{
									if (this.activeUnit_0.method_120() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()))
									{
										if (this.activeUnit_0.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
										{
											if (this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
											{
												this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
											}
											return;
										}
										if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && this.activeUnit_0.vmethod_65(false).method_147().vmethod_108() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
										{
											this.activeUnit_0.vmethod_109(this.activeUnit_0._ActiveUnitStatus_2);
										}
										else if (this.activeUnit_0.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling)
										{
											if (this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.Refuelling)
											{
												ActiveUnit activeUnit_4 = this.activeUnit_0;
												double num4 = 0.0;
												double num3 = 0.0;
												if (activeUnit_4.vmethod_119(ref num4, ref num3, false) < 0.95)
												{
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
												}
											}
											return;
										}
									}
									if (this.activeUnit_0.method_120())
									{
										if (this.activeUnit_0.vmethod_65(false).method_143() == Group.GroupType.AirGroup && this.activeUnit_0.vmethod_65(false).method_151())
										{
											this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.FormingUp);
											return;
										}
										if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.FormingUp)
										{
											this.vmethod_10(float_3, false, true);
										}
									}
									if (this.activeUnit_0.vmethod_101() != null && this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.RTB_MissionOver && this.activeUnit_0.vmethod_101().method_12())
									{
										switch (this.activeUnit_0.vmethod_101()._MissionClass_0)
										{
										case Mission._MissionClass.Strike:
											if (this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.RTB_CalledOff)
											{
												if (this.vmethod_0().Count == 0)
												{
													if (this.bool_2 && !this.activeUnit_0.vmethod_85().method_32() && (!this.activeUnit_0.method_121() || Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) || !this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_32()))
													{
														List<Aircraft> list4 = new List<Aircraft>();
														List<ActiveUnit> list5 = Enumerable.ToList<ActiveUnit>(this.activeUnit_0.vmethod_7(false).activeUnit_0);
														try
														{
															foreach (ActiveUnit activeUnit13 in list5)
															{
																if (activeUnit13.bool_3 && activeUnit13 != this.method_112() && !Information.IsNothing(activeUnit13.vmethod_101()) && activeUnit13.vmethod_101() == this.method_112().vmethod_101() && !activeUnit13.vmethod_86().bool_2)
																{
																	if (activeUnit13.vmethod_127())
																	{
																		list4.Add((Aircraft)activeUnit13);
																	}
																	else if (((Aircraft)activeUnit13).method_164().method_22())
																	{
																		list4.Add((Aircraft)activeUnit13);
																	}
																}
															}
														}
														finally
														{
															List<ActiveUnit>.Enumerator enumerator9;
															((IDisposable)enumerator9).Dispose();
														}
														if (list4.Count > 0)
														{
															if (this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse)
															{
																Doctrine.Enum57 enum5 = Doctrine.Enum57.const_2;
																bool flag27 = false;
																GeoPoint geoPoint3 = null;
																try
																{
																	foreach (Aircraft aircraft2 in list4)
																	{
																		if (!aircraft2.method_158().bool_2)
																		{
																			if (aircraft2.method_122() || !aircraft2.method_120())
																			{
																				if (aircraft2.method_157().method_21())
																				{
																					enum5 = Doctrine.Enum57.const_1;
																					if (Information.IsNothing(geoPoint3))
																					{
																						geoPoint3 = aircraft2.method_158().method_18();
																					}
																				}
																				if (aircraft2.vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || aircraft2.vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling)
																				{
																					flag27 = true;
																				}
																			}
																			if (flag27 && enum5 == Doctrine.Enum57.const_2)
																			{
																				break;
																			}
																		}
																	}
																}
																finally
																{
																	List<Aircraft>.Enumerator enumerator10;
																	((IDisposable)enumerator10).Dispose();
																}
																if (flag27 && this.method_112().doctrine_0.method_152(this.method_112().scenario_0, false, false, false, false).Value != Doctrine.Enum56.const_1)
																{
																	Aircraft_AirOps aircraft_AirOps8 = aircraft_AirOps;
																	GeoPoint geoPoint_6 = geoPoint3;
																	Doctrine.Enum57 enum57_3 = enum5;
																	bool flag5 = false;
																	bool bool_33 = false;
																	ActiveUnit activeUnit = null;
																	List<Mission> list2 = null;
																	string text = "";
																	bool flag4 = false;
																	bool flag3 = false;
																	if (aircraft_AirOps8.method_80(geoPoint_6, enum57_3, ref flag5, bool_33, ref activeUnit, ref list2, ref text, ref flag4, ref flag3))
																	{
																		return;
																	}
																}
															}
															this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Tasked);
														}
														else
														{
															this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
														}
													}
													else if (!flag2)
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
													}
													else
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Tasked);
													}
												}
												else if (this.bool_2)
												{
													if (Information.IsNothing(this.vmethod_3()))
													{
														List<Aircraft> list6 = new List<Aircraft>();
														List<ActiveUnit> list7 = Enumerable.ToList<ActiveUnit>(this.activeUnit_0.vmethod_7(false).activeUnit_0);
														try
														{
															foreach (ActiveUnit activeUnit14 in list7)
															{
																if (activeUnit14.bool_3 && activeUnit14 != this.method_112() && !Information.IsNothing(activeUnit14.vmethod_101()) && activeUnit14.vmethod_101() == this.method_112().vmethod_101() && !activeUnit14.vmethod_86().bool_2)
																{
																	if (activeUnit14.vmethod_127())
																	{
																		list6.Add((Aircraft)activeUnit14);
																	}
																	else if (((Aircraft)activeUnit14).method_164().method_22())
																	{
																		list6.Add((Aircraft)activeUnit14);
																	}
																}
															}
														}
														finally
														{
															List<ActiveUnit>.Enumerator enumerator11;
															((IDisposable)enumerator11).Dispose();
														}
														if (this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse)
														{
															Doctrine.Enum57 enum6 = Doctrine.Enum57.const_2;
															bool flag28 = false;
															GeoPoint geoPoint4 = null;
															try
															{
																foreach (Aircraft aircraft3 in list6)
																{
																	if (!aircraft3.method_158().bool_2)
																	{
																		if (aircraft3.method_122() || !aircraft3.method_120())
																		{
																			if (aircraft3.method_157().method_21())
																			{
																				enum6 = Doctrine.Enum57.const_1;
																				if (Information.IsNothing(geoPoint4))
																				{
																					geoPoint4 = aircraft3.method_158().method_18();
																				}
																			}
																			if (aircraft3.vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || aircraft3.vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling)
																			{
																				flag28 = true;
																			}
																		}
																		if (flag28 && enum6 == Doctrine.Enum57.const_2)
																		{
																			break;
																		}
																	}
																}
															}
															finally
															{
																List<Aircraft>.Enumerator enumerator12;
																((IDisposable)enumerator12).Dispose();
															}
															if (flag28 && this.method_112().doctrine_0.method_152(this.method_112().scenario_0, false, false, false, false).Value != Doctrine.Enum56.const_1)
															{
																Aircraft_AirOps aircraft_AirOps9 = aircraft_AirOps;
																GeoPoint geoPoint_7 = geoPoint4;
																Doctrine.Enum57 enum57_4 = enum6;
																bool flag3 = false;
																bool bool_34 = false;
																ActiveUnit activeUnit = null;
																List<Mission> list2 = null;
																string text = "";
																bool flag4 = false;
																bool flag5 = false;
																if (aircraft_AirOps9.method_80(geoPoint_7, enum57_4, ref flag3, bool_34, ref activeUnit, ref list2, ref text, ref flag4, ref flag5))
																{
																	return;
																}
															}
														}
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Tasked);
													}
													else
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
													}
												}
												else if (!flag2)
												{
													Aircraft_AI.Class246 class3 = new Aircraft_AI.Class246(class3);
													class3.strike_0 = (Strike)this.activeUnit_0.vmethod_101();
													if (class3.strike_0.hashSet_0.Count > 0)
													{
														List<Contact> list8 = new List<Contact>();
														list8.AddRange(base.method_12());
														if (Enumerable.ToList<Contact>(Enumerable.Where<Contact>(list8, new Func<Contact, bool>(class3.method_0))).Count == 0)
														{
															this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
															return;
														}
													}
													else
													{
														if (class3.strike_0.bool_27 && class3.strike_0.hashSet_0.Count == 0)
														{
															this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
															return;
														}
														if (this.vmethod_3() != null && this.activeUnit_0.scenario_0.SecondIsChangingOnThisPulse)
														{
															bool flag29 = false;
															Doctrine.Enum59? enum7 = this.activeUnit_0.doctrine_0.method_162(this.activeUnit_0.scenario_0, false, false, false);
															Contact contact_2 = this.vmethod_3();
															Mission mission_2 = this.method_112().vmethod_101();
															Doctrine.Enum59? nullable_7 = enum7;
															bool bool_35 = true;
															bool bool_36 = flag;
															bool bool_37 = true;
															Misc.PostureStance? nullable_8 = null;
															string text = "";
															int num = 0;
															if (base.method_39(contact_2, mission_2, nullable_7, bool_35, bool_36, bool_37, nullable_8, ref text, ref num))
															{
																flag29 = true;
															}
															if (!flag29)
															{
																this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
																return;
															}
														}
													}
													Weapon weapon = this.activeUnit_0.vmethod_89().method_16(this.vmethod_3(), true, true, true, this.activeUnit_0.doctrine_0);
													if (!Information.IsNothing(weapon))
													{
														double num12 = (double)weapon.method_181(this.activeUnit_0, this.vmethod_3(), false, null, false);
														double num13 = (double)this.activeUnit_0.method_36(this.vmethod_3());
														if (num12 * 2.0 > num13)
														{
															this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
															return;
														}
													}
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Tasked);
												}
												else if (!Information.IsNothing(this.vmethod_3()) && this.method_112().method_120() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && (this.method_112().vmethod_65(false).method_147().vmethod_85().method_22() || this.method_112().vmethod_65(false).method_147().vmethod_85().method_23()) && !this.method_112().vmethod_65(false).method_147().vmethod_85().method_30())
												{
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
												}
												else
												{
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Tasked);
												}
											}
											if (this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse && this.activeUnit_0.vmethod_101().int_5 > 0)
											{
												this.method_113((double)((float)((double)this.activeUnit_0.vmethod_101().int_5 / 100.0)), this.activeUnit_0.doctrine_0.method_157(this.activeUnit_0.scenario_0, false, false, false, false).Value);
											}
											return;
										case Mission._MissionClass.Patrol:
											if (this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.RTB_CalledOff)
											{
												if (!Information.IsNothing(this.vmethod_3()))
												{
													ActiveUnit_Weaponry activeUnit_Weaponry2 = this.activeUnit_0.vmethod_89();
													Contact theTarget2 = this.vmethod_3();
													bool checkWRA2 = true;
													Doctrine doctrine_2 = this.activeUnit_0.doctrine_0;
													string text = "";
													int num = 0;
													if (activeUnit_Weaponry2.method_6(theTarget2, checkWRA2, doctrine_2, ref text, ref num, null))
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
													}
													else if (!this.activeUnit_0.method_94() && !this.activeUnit_0.method_95())
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPatrol);
													}
													else
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
													}
												}
												else
												{
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPatrol);
												}
											}
											if (this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse && this.activeUnit_0.vmethod_101().int_5 > 0)
											{
												this.method_113((double)((float)((double)this.activeUnit_0.vmethod_101().int_5 / 100.0)), this.activeUnit_0.doctrine_0.method_157(this.activeUnit_0.scenario_0, false, false, false, false).Value);
											}
											return;
										case Mission._MissionClass.Support:
											if (this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.RTB_CalledOff)
											{
												if (!Information.IsNothing(this.vmethod_3()))
												{
													Doctrine.Enum59? enum8 = this.activeUnit_0.doctrine_0.method_162(this.activeUnit_0.scenario_0, false, false, false);
													b = ((enum8 != null) ? new byte?((byte)enum8.GetValueOrDefault()) : null);
													if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
														return;
													}
												}
												if (this.activeUnit_0.vmethod_85().method_13(float_3))
												{
													if (!this.method_112().method_161().method_59())
													{
														this.method_112().method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, false, true);
													}
												}
												else
												{
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnSupportMission);
												}
											}
											if (this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse && this.activeUnit_0.vmethod_101().int_5 > 0)
											{
												this.method_113((double)((float)((double)this.activeUnit_0.vmethod_101().int_5 / 100.0)), this.activeUnit_0.doctrine_0.method_157(this.activeUnit_0.scenario_0, false, false, false, false).Value);
											}
											return;
										case Mission._MissionClass.Ferry:
										{
											if (!Information.IsNothing(this.vmethod_3()))
											{
												Doctrine.Enum59? enum8 = this.activeUnit_0.doctrine_0.method_162(this.activeUnit_0.scenario_0, false, false, false);
												b = ((enum8 != null) ? new byte?((byte)enum8.GetValueOrDefault()) : null);
												if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
												{
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
													return;
												}
											}
											ActiveUnit activeUnit_5 = this.method_112().method_164().method_21();
											if (this.method_112().method_157().method_76(activeUnit_5))
											{
												if (!this.method_112().method_161().method_59())
												{
													this.method_112().method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
												}
											}
											else
											{
												this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnFerryMission);
											}
											return;
										}
										case Mission._MissionClass.Mining:
											this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Tasked);
											return;
										case Mission._MissionClass.MineClearing:
											this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Tasked);
											return;
										case Mission._MissionClass.Cargo:
											this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Tasked);
											return;
										}
									}
									if (!Information.IsNothing(this.vmethod_3()))
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
										return;
									}
									if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.RTB_MissionOver)
									{
										return;
									}
									if (!Information.IsNothing(base.method_8()) && !this.activeUnit_0.vmethod_85().method_47())
									{
										this.activeUnit_0.vmethod_85().method_43();
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
										return;
									}
									if (this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.Unassigned)
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
									}
									return;
								}
							}
						}
						if (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_108() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && this.activeUnit_0.vmethod_65(false).method_147().vmethod_108() != ActiveUnit._ActiveUnitStatus.Refuelling)
						{
							this.activeUnit_0.vmethod_109(this.activeUnit_0._ActiveUnitStatus_2);
							aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
						}
						else
						{
							this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
						}
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 200344", ex2.Message);
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x000086E7 File Offset: 0x000068E7
		public ActiveUnit_AI.AircraftAltitudePreset method_114()
		{
			return this.aircraftAltitudePreset_0;
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x000086EF File Offset: 0x000068EF
		public void method_115(ActiveUnit_AI.AircraftAltitudePreset aircraftAltitudePreset_1)
		{
			this.aircraftAltitudePreset_0 = aircraftAltitudePreset_1;
			if (aircraftAltitudePreset_1 != ActiveUnit_AI.AircraftAltitudePreset.None)
			{
				this.activeUnit_0.vmethod_87().vmethod_13(true);
			}
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x000E37C0 File Offset: 0x000E19C0
		public override void vmethod_25()
		{
			if (this.activeUnit_0 != null && this.activeUnit_0.vmethod_7(false) != null)
			{
				base.method_34();
				try
				{
					try
					{
						foreach (Contact contact_ in base.method_0())
						{
							try
							{
								if (this.method_117(contact_))
								{
									this.vmethod_13(contact_);
								}
							}
							catch (Exception ex)
							{
								ex.Data.Add("Error at 100381", "");
								GameGeneral.smethod_25(ref ex);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
							}
						}
					}
					finally
					{
						List<Contact>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 100382", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0000870C File Offset: 0x0000690C
		private Weapon[] method_116()
		{
			return this.activeUnit_0.vmethod_89().vmethod_4().ToArray();
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000E38C8 File Offset: 0x000E1AC8
		public override void vmethod_10(float float_3, bool bool_11, bool bool_12)
		{
			if (this.bool_9 && this.activeUnit_0 != null)
			{
				Side side = this.activeUnit_0.vmethod_7(false);
				try
				{
					if (this.activeUnit_0.vmethod_51().Count == 0 && this.activeUnit_0.method_78().Length == 0 && (this.method_112().method_167() == null || this.method_112().method_167().weaponRec_0.Length == 0))
					{
						if (this.vmethod_3() != null)
						{
							this.vmethod_15(this.vmethod_3(), true);
						}
						if (base.method_12().Length > 0)
						{
							List<Contact> list = new List<Contact>();
							foreach (Contact item in base.method_12())
							{
								list.Add(item);
							}
							try
							{
								foreach (Contact contact in list)
								{
									this.vmethod_15(contact, true);
								}
							}
							finally
							{
								List<Contact>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
					}
					else
					{
						base.vmethod_10(float_3, bool_11, bool_12);
						if (this.activeUnit_0 != null)
						{
							Mission mission = this.activeUnit_0.vmethod_101();
							Contact[] array2 = base.method_12();
							bool flag = base.method_37();
							List<Contact> list2 = new List<Contact>();
							if (side.list_7.Count > 0)
							{
								for (int j = array2.Length - 1; j >= 0; j += -1)
								{
									Contact contact2 = array2[j];
									if (contact2 != null && (side.method_75(ref this.activeUnit_0, ref contact2) <= 0 || base.method_20(contact2) != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc))
									{
										try
										{
											foreach (NoNavZone noNavZone in Enumerable.Where<NoNavZone>(side.list_7, new Func<NoNavZone, bool>(this.method_157)))
											{
												if (noNavZone.list_0.Count != 0 && contact2.vmethod_46(noNavZone.list_0, this.activeUnit_0.scenario_0, true))
												{
													list2.Add(contact2);
												}
											}
										}
										finally
										{
											IEnumerator<NoNavZone> enumerator2;
											if (enumerator2 != null)
											{
												enumerator2.Dispose();
											}
										}
									}
								}
								try
								{
									foreach (Contact contact in list2)
									{
										this.vmethod_15(contact, true);
									}
								}
								finally
								{
									List<Contact>.Enumerator enumerator3;
									((IDisposable)enumerator3).Dispose();
								}
							}
							Lazy<Weapon[]> lazy = new Lazy<Weapon[]>(new Func<Weapon[]>(this.method_116));
							Doctrine.Enum59? @enum = this.activeUnit_0.doctrine_0.method_162(this.activeUnit_0.scenario_0, false, false, false);
							if (base.method_0() == null)
							{
								base.method_1(this.activeUnit_0.vmethod_88().method_0());
							}
							int count = base.method_0().Count;
							if (this.tuple_0 == null)
							{
								this.tuple_0 = new Tuple<Contact, Misc.PostureStance>[count - 1 + 1];
							}
							if (this.hashSet_1.Count > 0)
							{
								this.hashSet_1.Clear();
							}
							try
							{
								foreach (Contact contact3 in base.method_0())
								{
									if (base.method_20(contact3) != ActiveUnit_AI.TargetingEntry._TargetingBehavior.NotTargeted)
									{
										this.hashSet_1.Add(contact3.string_0);
									}
								}
							}
							finally
							{
								List<Contact>.Enumerator enumerator4;
								((IDisposable)enumerator4).Dispose();
							}
							int num2;
							if (mission != null && mission.method_12())
							{
								int num = count - 1;
								for (int k = 0; k <= num; k++)
								{
									Contact contact = base.method_0()[k];
									string string_ = contact.string_0;
									if (!Enumerable.Contains<Contact>(base.method_12(), contact) && !list2.Contains(contact))
									{
										Contact.Enum47? enum2 = contact.method_74(side);
										byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
										if (!((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
										{
											Misc.PostureStance postureStance;
											if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(string_, out postureStance))
											{
												if (this.tuple_0[k] != null)
												{
													postureStance = contact.method_130(this.activeUnit_0.vmethod_7(false));
													postureStance = this.tuple_0[k].Item2;
												}
												else
												{
													if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(string_, out postureStance))
													{
														postureStance = contact.method_130(this.activeUnit_0.vmethod_7(false));
													}
													this.tuple_0[k] = new Tuple<Contact, Misc.PostureStance>(contact, postureStance);
												}
											}
											switch (postureStance)
											{
											case Misc.PostureStance.Unfriendly:
											case Misc.PostureStance.Hostile:
											{
												Contact contact_ = contact;
												Mission mission_ = mission;
												Doctrine.Enum59? nullable_ = @enum;
												bool bool_13 = flag;
												bool bool_14 = true;
												Misc.PostureStance? nullable_2 = new Misc.PostureStance?(postureStance);
												string text = "";
												num2 = 0;
												if (base.method_39(contact_, mission_, nullable_, bool_11, bool_13, bool_14, nullable_2, ref text, ref num2))
												{
													if (contact.contactType_0 == Contact_Base.ContactType.Submarine)
													{
														if (!contact.method_72() && !Class442.smethod_1(contact.vmethod_28(null), contact.vmethod_30(null)))
														{
															this.vmethod_12(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
															this.hashSet_1.Add(contact.string_0);
														}
													}
													else
													{
														ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
														Contact theTarget = contact;
														bool checkWRA = true;
														Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
														text = "";
														num2 = 0;
														if (activeUnit_Weaponry.method_6(theTarget, checkWRA, doctrine_, ref text, ref num2, lazy.Value))
														{
															this.vmethod_12(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
															this.hashSet_1.Add(contact.string_0);
														}
													}
												}
												break;
											}
											case Misc.PostureStance.Unknown:
											{
												Contact contact_2 = contact;
												Mission mission_2 = mission;
												Doctrine.Enum59? nullable_3 = @enum;
												bool bool_15 = flag;
												bool bool_16 = true;
												Misc.PostureStance? nullable_4 = new Misc.PostureStance?(postureStance);
												string text = "";
												num2 = 0;
												if (base.method_39(contact_2, mission_2, nullable_3, bool_11, bool_15, bool_16, nullable_4, ref text, ref num2) && (contact.contactType_0 != Contact_Base.ContactType.Submarine || !Class442.smethod_1(contact.vmethod_28(null), contact.vmethod_30(null))))
												{
													this.vmethod_12(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
												}
												break;
											}
											}
										}
									}
								}
							}
							Weapon weapon_ = this.activeUnit_0.vmethod_89().method_54();
							Weapon weapon_2 = this.activeUnit_0.vmethod_89().method_57();
							Weapon weapon_3;
							Weapon weapon_4;
							if (this.activeUnit_0.method_68())
							{
								Class343 @class = (Class343)mission;
								GlobalVariables.PatrolType patrolType_ = @class.patrolType_0;
								if (patrolType_ <= GlobalVariables.PatrolType.ASuW_Naval || patrolType_ - GlobalVariables.PatrolType.ASuW_Land <= 3)
								{
									if (@class.method_68(this.activeUnit_0.scenario_0))
									{
										weapon_3 = this.activeUnit_0.vmethod_89().method_55(false);
										weapon_4 = this.activeUnit_0.vmethod_89().method_56(false);
									}
									else
									{
										weapon_3 = null;
										weapon_4 = null;
									}
								}
							}
							else
							{
								weapon_3 = this.activeUnit_0.vmethod_89().method_55(false);
								weapon_4 = this.activeUnit_0.vmethod_89().method_56(false);
							}
							bool flag2 = this.activeUnit_0.method_68() && ((Class343)mission).method_65();
							bool bool_17;
							Doctrine.Enum59 value;
							if (bool_17 = (@enum != null))
							{
								value = @enum.Value;
							}
							num2 = count - 1;
							for (int l = 0; l <= num2; l++)
							{
								Contact contact = base.method_0()[l];
								string string_2 = contact.string_0;
								Misc.PostureStance postureStance2;
								if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(string_2, out postureStance2))
								{
									if (this.tuple_0[l] != null)
									{
										postureStance2 = this.tuple_0[l].Item2;
									}
									else
									{
										if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(string_2, out postureStance2))
										{
											postureStance2 = contact.method_130(this.activeUnit_0.vmethod_7(false));
										}
										this.tuple_0[l] = new Tuple<Contact, Misc.PostureStance>(contact, postureStance2);
									}
								}
								if (postureStance2 != Misc.PostureStance.Friendly && postureStance2 != Misc.PostureStance.Neutral)
								{
									new bool?(contact.method_124(this.activeUnit_0.scenario_0));
									if (!this.hashSet_1.Contains(string_2) && !list2.Contains(contact))
									{
										Contact.Enum47? enum2 = contact.method_74(side);
										byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
										if (!((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
										{
											if (!flag2 && mission != null && mission._MissionClass_0 == Mission._MissionClass.Patrol && !contact.method_106() && !((Class343)mission).method_66(this.activeUnit_0.scenario_0))
											{
												Class343 class2 = (Class343)mission;
												if (!contact.vmethod_46(class2.list_5, this.activeUnit_0.scenario_0, true) && base.method_20(contact) != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc && !this.activeUnit_0.vmethod_88().method_40(contact))
												{
													goto IL_8CA;
												}
											}
											if (!this.hashSet_1.Contains(string_2))
											{
												ActiveUnit_Weaponry activeUnit_Weaponry2 = this.activeUnit_0.vmethod_89();
												Contact theTarget2 = contact;
												bool checkWRA2 = true;
												Doctrine doctrine_2 = this.activeUnit_0.doctrine_0;
												string text = "";
												int num3 = 0;
												if (activeUnit_Weaponry2.method_6(theTarget2, checkWRA2, doctrine_2, ref text, ref num3, lazy.Value) && base.method_47(contact, postureStance2, bool_17, value, weapon_, weapon_3, weapon_4, weapon_2))
												{
													this.vmethod_12(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
													this.hashSet_1.Add(contact.string_0);
												}
											}
										}
									}
								}
								IL_8CA:;
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100383", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000E4264 File Offset: 0x000E2464
		private bool method_117(Contact contact_8)
		{
			bool result;
			if (contact_8 == null)
			{
				result = false;
			}
			else if (contact_8.method_110())
			{
				if (contact_8.activeUnit_0 == null)
				{
					result = false;
				}
				else if (contact_8.method_124(this.activeUnit_0.scenario_0))
				{
					result = false;
				}
				else
				{
					Misc.PostureStance postureStance;
					if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(contact_8.string_0, out postureStance))
					{
						postureStance = contact_8.method_130(this.activeUnit_0.vmethod_7(false));
					}
					if (postureStance == Misc.PostureStance.Friendly)
					{
						result = false;
					}
					else
					{
						Weapon weapon = (Weapon)contact_8.activeUnit_0;
						result = (weapon.class394_0.bool_2 && weapon.method_167() != Weapon._WeaponType.Decoy_Vehicle && Math.Abs(base.method_67(ref contact_8)) <= 90f && this.activeUnit_0.method_37(contact_8, 0f) <= 15f);
					}
				}
			}
			else if (contact_8.method_104())
			{
				if (contact_8.activeUnit_0 == null)
				{
					result = false;
				}
				else
				{
					if (contact_8.method_125() >= Contact_Base.IdentificationStatus.KnownType)
					{
						Aircraft._AircraftType aircraftType_ = ((Aircraft)contact_8.activeUnit_0)._AircraftType_0;
						if (aircraftType_ - Aircraft._AircraftType.Fighter > 1 && aircraftType_ - Aircraft._AircraftType.Attack > 1)
						{
							return false;
						}
					}
					if (Math.Abs(base.method_67(ref contact_8)) > 90f)
					{
						result = false;
					}
					else if (Math.Abs(Class437.smethod_3(this.method_112().vmethod_9(), this.method_112().method_32(contact_8))) < 20f)
					{
						result = false;
					}
					else
					{
						float num = 0f;
						try
						{
							foreach (Weapon weapon2 in contact_8.activeUnit_0.vmethod_89().vmethod_4())
							{
								if (weapon2.method_167() == Weapon._WeaponType.Gun && weapon2.float_29 > num)
								{
									num = weapon2.float_29;
								}
							}
						}
						finally
						{
							List<Weapon>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						result = ((double)this.activeUnit_0.method_37(contact_8, 0f) <= (double)num * 1.1);
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000E449C File Offset: 0x000E269C
		private void method_118(float float_3)
		{
			if (this.activeUnit_0.method_36(this.vmethod_3().activeUnit_0) > 4f && Math.Abs(this.vmethod_3().method_46(this.activeUnit_0, true)) < 90f)
			{
				this.method_119(float_3);
				return;
			}
			this.method_120(float_3);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x000E44F4 File Offset: 0x000E26F4
		private void method_119(float float_3)
		{
			try
			{
				if (!this.activeUnit_0.vmethod_87().vmethod_12() || Information.IsNothing(this.activeUnit_0.vmethod_87().vmethod_10()) || this.activeUnit_0.vmethod_85().method_32())
				{
					Aircraft_AirOps aircraft_AirOps = this.method_112().method_164();
					aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.BVRAttack);
					Weapon weapon = this.activeUnit_0.vmethod_89().method_16(this.vmethod_3(), true, true, true, this.activeUnit_0.doctrine_0);
					if (!Information.IsNothing(weapon))
					{
						if (weapon.method_192())
						{
							aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.BVRAttack);
						}
						else
						{
							aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
						}
					}
					else
					{
						aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
					}
					Weapon weapon2 = this.activeUnit_0.vmethod_89().method_54();
					ActiveUnit_Sensory activeUnit_Sensory = this.activeUnit_0.vmethod_88();
					bool bool_ = true;
					bool bool_2 = true;
					bool bool_3 = true;
					bool bool_4 = false;
					Sensor[] array = null;
					Sensor sensor = Enumerable.FirstOrDefault<Sensor>(activeUnit_Sensory.method_51(bool_, bool_2, bool_3, bool_4, ref array));
					float num = this.activeUnit_0.method_36(this.vmethod_3());
					float num2;
					if (Information.IsNothing(weapon2))
					{
						num2 = 0f;
					}
					else
					{
						num2 = weapon2.float_29;
					}
					float? num3 = null;
					ActiveUnit.Throttle? throttle = null;
					float? num4 = null;
					Class343 @class;
					float num5;
					if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
					{
						@class = (Class343)this.activeUnit_0.vmethod_101();
						num4 = @class.imethod_12();
						if (Information.IsNothing(num4))
						{
							num5 = (float)Math.Max((double)(10f + num2), (double)num2 * 1.2);
						}
						else
						{
							num5 = (num4 + num2).Value;
						}
					}
					else
					{
						num5 = (float)Math.Max((double)(10f + num2), (double)num2 * 1.2);
					}
					if (!this.activeUnit_0.vmethod_87().vmethod_12() || this.activeUnit_0.vmethod_85().method_32())
					{
						this.activeUnit_0.vmethod_72();
						if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
						{
							if (Information.IsNothing(@class))
							{
								@class = (Class343)this.activeUnit_0.vmethod_101();
							}
							if (!Information.IsNothing(num4) && num > num5)
							{
								num3 = @class.imethod_6();
							}
							else
							{
								num3 = @class.imethod_10();
							}
						}
						if (!Information.IsNothing(num3))
						{
							this.activeUnit_0.vmethod_73(num3.Value);
						}
						else if (num > num5)
						{
							if (!this.activeUnit_0.vmethod_87().vmethod_12())
							{
								this.method_112().method_157().method_70(aircraft_AirOps.method_36());
							}
						}
						else if (this.vmethod_3().bool_19 && this.vmethod_3().vmethod_14(false) < this.method_112().vmethod_14(false) && !this.method_112().method_160().method_79() && !Information.IsNothing(sensor) && num < sensor.float_0)
						{
							if (!this.activeUnit_0.vmethod_87().vmethod_12())
							{
								this.activeUnit_0.vmethod_73(this.vmethod_3().vmethod_14(false) - 30.48f);
							}
						}
						else if (this.vmethod_3().bool_19 && num < (float)Math.Max((double)num2 * 0.75, 10.0))
						{
							if (!this.activeUnit_0.vmethod_87().vmethod_12())
							{
								float num6 = Math.Abs(this.method_112().vmethod_14(false) - this.vmethod_3().vmethod_14(false));
								if (num6 == 0f)
								{
									this.activeUnit_0.vmethod_73(this.vmethod_3().vmethod_14(false));
								}
								else if (this.vmethod_3().vmethod_14(false) > this.method_112().vmethod_14(false))
								{
									float num7 = this.method_112().method_54(this.vmethod_3());
									this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false) + num6 / num7 * float_3);
								}
								else
								{
									float num8 = this.method_112().method_54(this.vmethod_3());
									this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false) - num6 / num8 * float_3);
								}
							}
						}
						else if (!this.activeUnit_0.vmethod_87().vmethod_12())
						{
							this.method_112().method_157().method_70(aircraft_AirOps.method_36());
						}
						if (!Information.IsNothing(weapon2) && weapon2.method_167() == Weapon._WeaponType.GuidedWeapon)
						{
							float val = (float)this.vmethod_3().method_9(true, false, false);
							float val2 = (float)this.activeUnit_0.method_9(true, false, false);
							float val3 = (float)this.activeUnit_0.method_10(true, float_3);
							float num9 = Math.Max(Math.Max(val2, val), val3);
							float num10;
							float num11;
							if (weapon2.float_40 != 0f && weapon2.float_44 == 0f)
							{
								num10 = weapon2.float_40 + num9;
								num11 = weapon2.float_40;
							}
							else if (weapon2.float_40 == 0f && weapon2.float_44 != 0f)
							{
								num10 = weapon2.float_44;
								num11 = weapon2.float_44 - num9;
							}
							else if (weapon2.float_40 != 0f && weapon2.float_44 != 0f)
							{
								num10 = Math.Min(weapon2.float_40 + num9, weapon2.float_44);
								num11 = Math.Min(weapon2.float_44 - num9, weapon2.float_40);
							}
							float num12;
							float num13;
							if (weapon2.float_39 != 0f && weapon2.float_43 == 0f)
							{
								num12 = weapon2.float_39 + num9;
								num13 = weapon2.float_39;
							}
							else if (weapon2.float_39 == 0f && weapon2.float_43 != 0f)
							{
								num12 = weapon2.float_43;
								num13 = weapon2.float_43 - num9;
							}
							else if (weapon2.float_39 != 0f && weapon2.float_43 != 0f)
							{
								num12 = Math.Max(weapon2.float_39 + num9, weapon2.float_43);
								num13 = Math.Max(weapon2.float_43 - num9, weapon2.float_39);
							}
							if (num12 > this.activeUnit_0.vmethod_72())
							{
								this.activeUnit_0.vmethod_73(num12);
							}
							else if (num10 < this.activeUnit_0.vmethod_72())
							{
								this.activeUnit_0.vmethod_73(num10);
							}
							else
							{
								if (this.activeUnit_0.vmethod_72() > num10)
								{
									this.activeUnit_0.vmethod_73(num10);
								}
								if (this.activeUnit_0.vmethod_72() < num12)
								{
									this.activeUnit_0.vmethod_73(num12);
								}
							}
							if (num13 > this.activeUnit_0.vmethod_74())
							{
								this.activeUnit_0.vmethod_75(num13);
							}
							else if (num11 < this.activeUnit_0.vmethod_74())
							{
								this.activeUnit_0.vmethod_75(num11);
							}
							else
							{
								if (this.activeUnit_0.vmethod_74() > num11)
								{
									this.activeUnit_0.vmethod_75(num11);
								}
								if (this.activeUnit_0.vmethod_74() < num13)
								{
									this.activeUnit_0.vmethod_75(num13);
								}
							}
						}
					}
					if (Information.IsNothing(this.activeUnit_0.vmethod_87().vmethod_10()) || this.activeUnit_0.vmethod_85().method_32())
					{
						if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
						{
							if (Information.IsNothing(@class))
							{
								@class = (Class343)this.activeUnit_0.vmethod_101();
							}
							if (!Information.IsNothing(num4) && num > num5)
							{
								throttle = @class.imethod_0();
							}
							else
							{
								throttle = @class.imethod_4();
							}
						}
						if (!Information.IsNothing(throttle))
						{
							this.activeUnit_0.vmethod_134(throttle.Value, null);
						}
						else
						{
							this.method_112().method_157().method_71(this.activeUnit_0.vmethod_72(), null, true, aircraft_AirOps.method_36());
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100384", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x000E4D68 File Offset: 0x000E2F68
		private void method_120(float float_3)
		{
			try
			{
				base.method_63(float_3, 0f, 0f);
				Doctrine doctrine_;
				Weapon weapon;
				if (Information.IsNothing(this.activeUnit_0.vmethod_87().vmethod_10()))
				{
					float num = Class437.smethod_11(this.activeUnit_0.vmethod_9(), base.method_68(this.vmethod_3()));
					if (num <= 330f && num >= 30f)
					{
						float num2 = (float)this.method_112().method_159().method_25();
						if (this.activeUnit_0.vmethod_40() < num2)
						{
							this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
						}
						else
						{
							this.activeUnit_0.vmethod_71(num2);
						}
					}
					else
					{
						doctrine_ = this.activeUnit_0.doctrine_0;
						weapon = this.activeUnit_0.vmethod_89().method_16(this.vmethod_3(), true, true, true, doctrine_);
						if (!Information.IsNothing(weapon))
						{
							ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
							Weapon theWeapon = weapon;
							Contact theTarget = this.vmethod_3();
							bool manualFire = false;
							bool ignoreAircraftOrientation = false;
							Mount theMount = null;
							Sensor sensor = null;
							short? num3;
							if (activeUnit_Weaponry.method_23(theWeapon, theTarget, ref num3, manualFire, ignoreAircraftOrientation, theMount, ref sensor).Item2 == ActiveUnit_Weaponry.Enum36.const_0)
							{
								if ((double)this.activeUnit_0.method_36(this.vmethod_3()) > (double)weapon.method_181(this.activeUnit_0, this.vmethod_3(), true, doctrine_, false) * 0.5)
								{
									this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
									goto IL_218;
								}
								bool flag;
								if (this.vmethod_3().method_125() >= Contact_Base.IdentificationStatus.KnownClass)
								{
									try
									{
										foreach (Mount mount in this.vmethod_3().activeUnit_0.vmethod_51())
										{
											if (mount.method_38() && mount.method_20(this.activeUnit_0, new float?(this.vmethod_3().vmethod_9())))
											{
												flag = true;
												break;
											}
										}
									}
									finally
									{
										List<Mount>.Enumerator enumerator;
										((IDisposable)enumerator).Dispose();
									}
								}
								if (flag)
								{
									this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
									goto IL_218;
								}
								this.activeUnit_0.vmethod_71(this.vmethod_3().vmethod_40());
								goto IL_218;
							}
						}
						this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
					}
				}
				IL_218:
				if (!this.activeUnit_0.vmethod_87().vmethod_12() && this.vmethod_3().bool_19)
				{
					if (this.method_112().vmethod_6())
					{
						this.activeUnit_0.vmethod_73(this.vmethod_3().vmethod_14(false));
						base.method_88(this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null), (double)this.activeUnit_0.vmethod_72());
					}
					else
					{
						float num4 = Math.Abs(this.method_112().vmethod_14(false) - this.vmethod_3().vmethod_14(false));
						if (num4 == 0f)
						{
							this.activeUnit_0.vmethod_73(this.vmethod_3().vmethod_14(false));
						}
						else if (this.vmethod_3().vmethod_14(false) > this.method_112().vmethod_14(false))
						{
							float num5 = this.method_112().method_54(this.vmethod_3());
							if (num5 > 0f)
							{
								this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false) + num4 / num5 * float_3);
							}
							else
							{
								float num6 = this.activeUnit_0.vmethod_40() * float_3 / 3600f;
								float num7 = this.activeUnit_0.method_36(this.vmethod_3());
								this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false) + num6 * Math.Abs(num4) / num7);
							}
						}
						else
						{
							float num8 = this.method_112().method_54(this.vmethod_3());
							if (num8 > 0f)
							{
								this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false) - num4 / num8 * float_3);
							}
							else
							{
								float num9 = this.activeUnit_0.vmethod_40() * float_3 / 3600f;
								float num10 = this.activeUnit_0.method_36(this.vmethod_3());
								this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false) - num9 * Math.Abs(num4) / num10);
							}
						}
					}
					if (Information.IsNothing(doctrine_))
					{
						doctrine_ = this.activeUnit_0.doctrine_0;
					}
					if (Information.IsNothing(weapon))
					{
						weapon = this.activeUnit_0.vmethod_89().method_16(this.vmethod_3(), true, true, true, doctrine_);
					}
					if (!Information.IsNothing(weapon) && weapon.method_167() == Weapon._WeaponType.GuidedWeapon)
					{
						float val = (float)this.vmethod_3().method_9(true, false, false);
						float val2 = (float)this.activeUnit_0.method_9(true, false, false);
						float val3 = (float)this.activeUnit_0.method_10(true, float_3);
						float num11 = Math.Max(Math.Max(val2, val), val3);
						float num12;
						float num13;
						if (weapon.float_40 != 0f && weapon.float_44 == 0f)
						{
							num12 = weapon.float_40 + num11;
							num13 = weapon.float_40;
						}
						else if (weapon.float_40 == 0f && weapon.float_44 != 0f)
						{
							num12 = weapon.float_44;
							num13 = weapon.float_44 - num11;
						}
						else if (weapon.float_40 != 0f && weapon.float_44 != 0f)
						{
							num12 = Math.Min(weapon.float_40 + num11, weapon.float_44);
							num13 = Math.Min(weapon.float_44 - num11, weapon.float_40);
						}
						float num14;
						float num15;
						if (weapon.float_39 != 0f && weapon.float_43 == 0f)
						{
							num14 = weapon.float_39 + num11;
							num15 = weapon.float_39;
						}
						else if (weapon.float_39 == 0f && weapon.float_43 != 0f)
						{
							num14 = weapon.float_43;
							num15 = weapon.float_43 - num11;
						}
						else if (weapon.float_39 != 0f && weapon.float_43 != 0f)
						{
							num14 = Math.Max(weapon.float_39 + num11, weapon.float_43);
							num15 = Math.Max(weapon.float_43 - num11, weapon.float_39);
						}
						if (num14 > this.activeUnit_0.vmethod_72())
						{
							this.activeUnit_0.vmethod_73(num14);
						}
						else if (num12 < this.activeUnit_0.vmethod_72())
						{
							this.activeUnit_0.vmethod_73(num12);
						}
						else
						{
							if (this.activeUnit_0.vmethod_72() > num12)
							{
								this.activeUnit_0.vmethod_73(num12);
							}
							if (this.activeUnit_0.vmethod_72() < num14)
							{
								this.activeUnit_0.vmethod_73(num14);
							}
						}
						if (num15 > this.activeUnit_0.vmethod_74())
						{
							this.activeUnit_0.vmethod_75(num15);
						}
						else if (num13 < this.activeUnit_0.vmethod_74())
						{
							this.activeUnit_0.vmethod_75(num13);
						}
						else
						{
							if (this.activeUnit_0.vmethod_74() > num13)
							{
								this.activeUnit_0.vmethod_75(num13);
							}
							if (this.activeUnit_0.vmethod_74() < num15)
							{
								this.activeUnit_0.vmethod_75(num15);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100385", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x000E54CC File Offset: 0x000E36CC
		public float method_121(float float_3)
		{
			float result;
			try
			{
				if (float_3 == this.activeUnit_0.vmethod_18())
				{
					result = 0f;
				}
				else
				{
					float num = 0f;
					float num2 = this.activeUnit_0.vmethod_18();
					if (num2 > 0f)
					{
						while (num2 > float_3)
						{
							num += (float)((double)this.activeUnit_0.vmethod_40() * 0.514444 * Math2.smethod_1((double)num2));
							num2 -= this.activeUnit_0.vmethod_87().vmethod_20();
						}
					}
					else
					{
						while (num2 < float_3)
						{
							num += (float)((double)this.activeUnit_0.vmethod_40() * 0.514444 * Math2.smethod_1((double)num2));
							num2 += this.activeUnit_0.vmethod_87().vmethod_19();
						}
					}
					result = num;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at ¨999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000E55D4 File Offset: 0x000E37D4
		internal void method_122(float float_3)
		{
			float num3;
			if (this.method_112().vmethod_14(false) < 8850f)
			{
				float? num = this.method_112().imethod_4();
				float num2 = this.method_112().vmethod_72();
				if (((num != null) ? new bool?(num2 < num.GetValueOrDefault()) : null).GetValueOrDefault())
				{
					num3 = num.Value;
				}
				else
				{
					num3 = this.method_112().vmethod_72();
				}
			}
			else
			{
				num3 = this.method_112().vmethod_72();
			}
			float num4 = num3 - this.method_112().vmethod_14(false);
			if (num4 == 0f)
			{
				this.activeUnit_0.vmethod_23(0f);
				return;
			}
			if (num4 > 0f)
			{
				if (this.activeUnit_0.vmethod_18() < 0f)
				{
					this.activeUnit_0.vmethod_23(0f);
					return;
				}
				if (this.method_121(0f) < num4)
				{
					if (this.activeUnit_0.vmethod_78() == ActiveUnit.Enum28.const_1)
					{
						float num5 = (float)((double)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), ActiveUnit.Throttle.Cruise, false) * 0.514444);
						float num6 = this.activeUnit_0.vmethod_87().vmethod_14(true);
						if (num6 > num5)
						{
							this.int_1 = 89;
						}
						else
						{
							this.int_1 = (int)Math.Round(Math2.smethod_4((double)(num6 / num5)));
							if (this.int_1 > 89)
							{
								this.int_1 = 89;
							}
						}
					}
					else
					{
						this.int_1 = this.method_112().method_159().method_18();
					}
					this.activeUnit_0.vmethod_23((float)this.int_1);
					return;
				}
				if (num4 < 10f && (double)this.activeUnit_0.vmethod_18() < 0.5)
				{
					this.activeUnit_0.vmethod_23(this.activeUnit_0.vmethod_18());
					return;
				}
				this.activeUnit_0.vmethod_23(0f);
				return;
			}
			else
			{
				if (this.method_121(0f) > num4)
				{
					if (this.activeUnit_0.vmethod_78() == ActiveUnit.Enum28.const_1)
					{
						float num7 = (float)((double)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), ActiveUnit.Throttle.Cruise, false) * 0.514444);
						float num8 = this.activeUnit_0.vmethod_87().vmethod_21();
						if (num8 > num7)
						{
							this.int_2 = -89;
						}
						else
						{
							this.int_2 = -(int)Math.Round(Math2.smethod_4((double)(num8 / num7)));
							if (this.int_2 < -89)
							{
								this.int_2 = -89;
							}
						}
					}
					else
					{
						this.int_2 = -80;
					}
					this.activeUnit_0.vmethod_23((float)this.int_2);
					return;
				}
				if (num4 > -10f && (double)this.activeUnit_0.vmethod_18() > -0.5)
				{
					this.activeUnit_0.vmethod_23(this.activeUnit_0.vmethod_18());
					return;
				}
				this.activeUnit_0.vmethod_23(0f);
				return;
			}
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x000E58B8 File Offset: 0x000E3AB8
		internal void method_123(GeoPoint geoPoint_2, float float_3)
		{
			try
			{
				if (this.method_112().vmethod_6())
				{
					if (geoPoint_2 == null)
					{
						this.method_122(float_3);
					}
					else
					{
						this.method_124(geoPoint_2.imethod_2(), geoPoint_2.imethod_0());
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

		// Token: 0x06000BDC RID: 3036 RVA: 0x000E593C File Offset: 0x000E3B3C
		protected void method_124(double double_4, double double_5)
		{
			if (this.activeUnit_0.vmethod_6())
			{
				float num3;
				if (this.method_112().vmethod_14(false) < 8850f)
				{
					float? num = this.method_112().imethod_4();
					float num2 = this.method_112().vmethod_72();
					if (((num != null) ? new bool?(num2 < num.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						num3 = num.Value;
					}
					else
					{
						num3 = this.method_112().vmethod_72();
					}
				}
				else
				{
					num3 = this.method_112().vmethod_72();
				}
				base.method_88(double_4, double_5, (double)num3);
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000E59E0 File Offset: 0x000E3BE0
		public override void vmethod_29(float float_3)
		{
			if (this.activeUnit_0 != null && this.activeUnit_0.vmethod_85() != null)
			{
				try
				{
					if (this.activeUnit_0.scenario_0.FifthMinuteIsChangingOnThisPulse)
					{
						this.method_125(float_3);
					}
					if (this.activeUnit_0.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IgnoreBingoAndJoker)
					{
						this.activeUnit_0.vmethod_111(ActiveUnit._ActiveUnitFuelState.None);
					}
					ActiveUnit activeUnit = this.method_112().method_164().method_21();
					if (activeUnit == null)
					{
						if (this.method_112().method_157().method_47())
						{
							this.method_112().method_157().vmethod_16(float_3);
						}
						else
						{
							this.method_112().method_159().vmethod_27(float_3, false, false);
						}
					}
					else
					{
						Class211 @class = this.method_112().method_157();
						if (@class.bool_1 && !@class.method_44() && !@class.bool_2)
						{
							double double_ = this.activeUnit_0.vmethod_30(null);
							double double_2 = this.activeUnit_0.vmethod_28(null);
							double num = activeUnit.vmethod_30(null);
							double num2 = activeUnit.vmethod_28(null);
							if (@class.vmethod_29(double_, double_2, num, num2, true, 0f, true, null, true, false, false, null))
							{
								@class.method_16(null, this.activeUnit_0, null, false, 0.15f, num, num2, this.activeUnit_0.scenario_0, false);
							}
						}
						if (!@class.method_76(activeUnit))
						{
							if (this.activeUnit_0.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IsBingo)
							{
								if (!Information.IsNothing(this.activeUnit_0.vmethod_87().vmethod_10()) || this.activeUnit_0.vmethod_87().vmethod_12())
								{
									this.activeUnit_0.vmethod_87().vmethod_11(null);
									this.activeUnit_0.vmethod_87().vmethod_13(false);
									string str = "";
									if (this.method_112().bool_3 && Operators.CompareString(this.method_112().Name, this.method_112().string_2, false) != 0)
									{
										str = " (" + this.method_112().string_2 + ")";
									}
									this.method_112().method_124(this.method_112().Name + str + " has reached Bingo fuel and cancels altitude and speed overrides. If you want to manually control the speed or altitude for this aircraft, unassign it from the current Bingo fuel state (U hotkey). Please note that if you do, all safety measures will be disabled and you are be responsible for bringing the aircraft safely back to base yourself.", this.method_112().Name + " cancels throttle/alt overrides (Bingo)", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_112().vmethod_28(null), this.method_112().vmethod_30(null)));
								}
								bool flag;
								float num3 = @class.method_73(ref flag);
								float num4 = (float)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), ActiveUnit.Throttle.Cruise, false);
								if (@class.method_47())
								{
									this.activeUnit_0.vmethod_85().vmethod_16(float_3);
									this.activeUnit_0.vmethod_71(num4);
									this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_87().vmethod_41(this.activeUnit_0.vmethod_14(false), (float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), null);
									this.activeUnit_0.vmethod_77(this.activeUnit_0, flag);
									if (flag)
									{
										this.activeUnit_0.vmethod_75(num3);
									}
									else
									{
										this.activeUnit_0.vmethod_73(num3);
									}
								}
								else
								{
									@class.method_78(float_3, activeUnit, num4, num3, ref flag);
								}
							}
							else if (this.method_112().method_121())
							{
								this.method_112().method_157().vmethod_21(float_3);
							}
							else
							{
								float num4;
								if (Information.IsNothing(this.activeUnit_0.vmethod_87().vmethod_10()))
								{
									num4 = (float)this.activeUnit_0.vmethod_87().vmethod_40(this.method_112().vmethod_14(false), ActiveUnit.Throttle.Full, false);
								}
								else
								{
									num4 = this.activeUnit_0.vmethod_87().vmethod_10().Value;
								}
								bool flag;
								float num3;
								if (!this.activeUnit_0.vmethod_87().vmethod_12())
								{
									num3 = @class.method_73(ref flag);
								}
								else
								{
									num3 = this.activeUnit_0.vmethod_72();
								}
								if (@class.method_47())
								{
									this.activeUnit_0.vmethod_85().vmethod_16(float_3);
									this.activeUnit_0.vmethod_71(num4);
									this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_87().vmethod_41(this.activeUnit_0.vmethod_14(false), (float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), null);
									this.activeUnit_0.vmethod_77(this.activeUnit_0, flag);
									if (flag)
									{
										this.activeUnit_0.vmethod_75(num3);
									}
									else
									{
										this.activeUnit_0.vmethod_73(num3);
									}
								}
								else
								{
									@class.method_78(float_3, activeUnit, num4, num3, ref flag);
								}
							}
						}
						else
						{
							if (this.activeUnit_0.method_120())
							{
								this.activeUnit_0.method_129(false, true, false);
							}
							this.method_112().vmethod_134(ActiveUnit.Throttle.Loiter, null);
							this.method_112().vmethod_71((float)this.method_112().method_159().vmethod_40(this.method_112().vmethod_14(false), ActiveUnit.Throttle.Loiter, false));
							this.method_112().vmethod_77(this.method_112(), false);
							this.method_112().method_164().method_47(activeUnit);
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100386", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x000E5FA4 File Offset: 0x000E41A4
		private void method_125(float float_3)
		{
			try
			{
				ActiveUnit activeUnit = this.method_112().method_164().method_21();
				if (Information.IsNothing(activeUnit))
				{
					this.method_112().method_164().method_28();
				}
				else
				{
					string text = this.method_112().method_164().method_26(activeUnit);
					if (activeUnit.method_82() || Operators.CompareString(text, "OK", false) != 0)
					{
						string text2 = "";
						if (this.method_112().bool_3 && Operators.CompareString(this.method_112().Name, this.method_112().string_2, false) != 0)
						{
							text2 = " (" + this.method_112().string_2 + ")";
						}
						this.method_112().method_124(string.Concat(new string[]
						{
							this.method_112().Name,
							text2,
							" cannot be hosted by its current assigned base (",
							activeUnit.Name,
							"). Reason: ",
							text
						}), this.method_112().Name + " cannot be hosted by its current base", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_112().vmethod_28(null), this.method_112().vmethod_30(null)));
						this.method_112().method_164().method_27(activeUnit);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100387", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x000E6148 File Offset: 0x000E4348
		private void method_126(float float_3, ref Weapon weapon_0)
		{
			try
			{
				if (!Information.IsNothing(this.vmethod_3()))
				{
					if (this.vmethod_3().method_135() || this.vmethod_3().method_108())
					{
						if (Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_112().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_158))) > 0)
						{
							float num = 50f;
							IEnumerable<Weapon> enumerable = Enumerable.Where<Weapon>(this.method_112().method_161().vmethod_4(), (Aircraft_AI._Closure$__.$I34-1 == null) ? (Aircraft_AI._Closure$__.$I34-1 = new Func<Weapon, bool>(Aircraft_AI._Closure$__.$I.method_12)) : Aircraft_AI._Closure$__.$I34-1);
							if (!Information.IsNothing(enumerable) && Enumerable.Count<Weapon>(enumerable) > 0)
							{
								float num2 = Enumerable.Max(Enumerable.Select<Weapon, float>(enumerable, new Func<Weapon, float>(this.method_159)));
								float num3 = this.method_112().method_36(this.vmethod_3());
								if (num3 > num)
								{
									return;
								}
								if ((double)num3 > (double)num2 * 0.75)
								{
									return;
								}
							}
						}
						List<Weapon> list = new List<Weapon>();
						try
						{
							foreach (Weapon weapon in this.activeUnit_0.scenario_0.method_17())
							{
								if (weapon.vmethod_142().vmethod_3() == this.vmethod_3())
								{
									if (weapon.method_177() == this.method_112())
									{
										list.Add(weapon);
										if (!weapon.struct36_0.bool_1 && !weapon.struct36_0.bool_0)
										{
											if (weapon.method_169() == Weapon.WeaponGuidanceType.CommandGuided_Datalinked)
											{
												weapon_0 = weapon;
											}
										}
										else
										{
											weapon_0 = weapon;
										}
										break;
									}
									if (this.method_112().method_120() && weapon.method_177().method_120() && weapon.method_177().vmethod_65(false) == this.method_112().vmethod_65(false))
									{
										list.Add(weapon);
									}
								}
							}
						}
						finally
						{
							List<Weapon>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (list.Count != 0)
						{
							bool flag = false;
							Class316[] class316_ = this.activeUnit_0.vmethod_7(false).class316_0;
							int i = 0;
							IL_266:
							checked
							{
								while (i < class316_.Length)
								{
									Class316.Class273[] class273_ = class316_[i].class273_0;
									int j = 0;
									while (j < class273_.Length)
									{
										Class316.Class273 @class = class273_[j];
										if (Operators.CompareString(@class.string_0, this.activeUnit_0.string_0, false) != 0)
										{
											j++;
										}
										else
										{
											if (unchecked(@class.int_0 - @class.int_1) > 0)
											{
												flag = true;
											}
											IL_25D:
											if (!flag)
											{
												i++;
												goto IL_266;
											}
											goto IL_26E;
										}
									}
									goto IL_25D;
								}
								IL_26E:;
							}
							if (!flag || !this.method_112().method_161().method_10(this.vmethod_3(), true, true))
							{
								if (list.Count > 0)
								{
									try
									{
										foreach (Weapon weapon2 in list)
										{
											if ((weapon2.struct36_0.bool_1 | weapon2.struct36_0.bool_0) && !this.activeUnit_0.vmethod_88().method_40(weapon2.vmethod_142().vmethod_3()) && (!weapon2.struct36_0.bool_2 || !weapon2.method_222()))
											{
												Unit.Enum123? @enum = null;
												bool? flag2 = null;
												bool? flag3 = null;
												bool? flag4 = null;
												ActiveUnit_Sensory activeUnit_Sensory = this.activeUnit_0.vmethod_88();
												Contact contact_ = weapon2.vmethod_142().vmethod_3();
												Weapon weapon_ = weapon2;
												Sensor sensor = null;
												if (!activeUnit_Sensory.method_41(contact_, weapon_, ref sensor, ref flag2, ref flag3, ref @enum, ref flag4))
												{
													ActiveUnit activeUnit_ = weapon2.vmethod_142().vmethod_3().activeUnit_0;
													if (!Information.IsNothing(activeUnit_))
													{
														List<ActiveUnit> list2 = null;
														foreach (Sensor sensor2 in this.activeUnit_0.method_78())
														{
															if (sensor2.vmethod_5() == PlatformComponent._ComponentStatus.Operational && sensor2.method_79(ref weapon2) && sensor2.method_85())
															{
																if (sensor2.sensor_Type_0 == Sensor.Sensor_Type.Radar && Information.IsNothing(list2))
																{
																	list2 = this.activeUnit_0.vmethod_88().method_10(false);
																}
																Sensor.Enum115 enum2 = sensor2.method_123(this.activeUnit_0, activeUnit_, this.activeUnit_0.method_36(weapon2.vmethod_142().vmethod_3()), list2, this.activeUnit_0.bool_6, false, ref flag2, ref flag3, ref @enum, ref flag4);
																switch (enum2)
																{
																case Sensor.Enum115.const_1:
																case Sensor.Enum115.const_4:
																case Sensor.Enum115.const_5:
																case Sensor.Enum115.const_8:
																case Sensor.Enum115.const_9:
																	goto IL_466;
																case Sensor.Enum115.const_2:
																case Sensor.Enum115.const_10:
																	break;
																case Sensor.Enum115.const_3:
																case Sensor.Enum115.const_6:
																	this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.method_32(weapon2.vmethod_142().vmethod_3()));
																	if (!this.activeUnit_0.vmethod_87().vmethod_12())
																	{
																		this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false) + this.activeUnit_0.vmethod_87().vmethod_16() * float_3 * 2f);
																	}
																	return;
																case Sensor.Enum115.const_7:
																	this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.method_32(weapon2.vmethod_142().vmethod_3()));
																	return;
																default:
																	if (enum2 != Sensor.Enum115.const_11)
																	{
																		goto IL_466;
																	}
																	break;
																}
																this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.method_32(weapon2.vmethod_142().vmethod_3()));
																return;
															}
															IL_466:;
														}
													}
												}
											}
										}
									}
									finally
									{
										List<Weapon>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
								}
								float num4 = this.vmethod_3().method_32(this.method_112());
								float num5 = Math2.smethod_7(num4 + 90f);
								float num6 = Math2.smethod_7(num4 - 90f);
								if (!this.activeUnit_0.vmethod_85().method_47() && (!this.activeUnit_0.method_120() || !this.activeUnit_0.vmethod_65(false).vmethod_85().method_47()))
								{
									if (Math.Abs(Class437.smethod_3(this.method_112().vmethod_9(), num5)) < Math.Abs(Class437.smethod_3(this.method_112().vmethod_9(), num6)))
									{
										this.method_112().vmethod_69(ActiveUnit.Enum28.const_0, num5);
									}
									else
									{
										this.method_112().vmethod_69(ActiveUnit.Enum28.const_0, num6);
									}
								}
								else
								{
									Waypoint waypoint;
									if (this.activeUnit_0.vmethod_85().method_47())
									{
										if (this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 != Waypoint.WaypointType.Target && this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 != Waypoint.WaypointType.WeaponTarget)
										{
											waypoint = this.activeUnit_0.vmethod_85().method_4()[0];
										}
										else if (Enumerable.Count<Waypoint>(this.activeUnit_0.vmethod_85().method_4()) > 1)
										{
											waypoint = this.activeUnit_0.vmethod_85().method_4()[1];
										}
										else
										{
											waypoint = this.activeUnit_0.vmethod_85().method_4()[0];
										}
									}
									else if (this.activeUnit_0.vmethod_65(false).vmethod_85().method_4()[0].waypointType_0 != Waypoint.WaypointType.Target && this.activeUnit_0.vmethod_65(false).vmethod_85().method_4()[0].waypointType_0 != Waypoint.WaypointType.WeaponTarget)
									{
										waypoint = this.activeUnit_0.vmethod_65(false).vmethod_85().method_4()[0];
									}
									else if (Enumerable.Count<Waypoint>(this.activeUnit_0.vmethod_65(false).vmethod_85().method_4()) > 1)
									{
										waypoint = this.activeUnit_0.vmethod_65(false).vmethod_85().method_4()[1];
									}
									else
									{
										waypoint = this.activeUnit_0.vmethod_65(false).vmethod_85().method_4()[0];
									}
									float num7 = Class437.smethod_3(Math2.smethod_17(this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null), waypoint.imethod_2(), waypoint.imethod_0()), num4);
									if (num7 > 0f)
									{
										if (num7 < 60f)
										{
											if (Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_9(), num5)) < 90f)
											{
												this.method_112().vmethod_69(ActiveUnit.Enum28.const_0, num5);
											}
											else
											{
												this.method_112().vmethod_69(ActiveUnit.Enum28.const_0, num6);
											}
										}
										else
										{
											this.method_112().vmethod_69(ActiveUnit.Enum28.const_0, num6);
										}
									}
									else if (num7 > -60f)
									{
										if (Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_9(), num6)) < 90f)
										{
											this.method_112().vmethod_69(ActiveUnit.Enum28.const_0, num6);
										}
										else
										{
											this.method_112().vmethod_69(ActiveUnit.Enum28.const_0, num5);
										}
									}
									else
									{
										this.method_112().vmethod_69(ActiveUnit.Enum28.const_0, num5);
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 1007843634777711", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000E6A3C File Offset: 0x000E4C3C
		public override void vmethod_16()
		{
			if (!Information.IsNothing(this.activeUnit_0))
			{
				float num = Class437.smethod_11(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_68());
				bool flag;
				if (this.activeUnit_0.vmethod_13() < 500f)
				{
					flag = false;
				}
				else
				{
					ActiveUnit._ActiveUnitStatus activeUnitStatus = this.activeUnit_0.vmethod_108();
					flag = (activeUnitStatus - ActiveUnit._ActiveUnitStatus.EngagedOffensive <= 1);
				}
				float num2 = 89f;
				if (num == 0f)
				{
					this.activeUnit_0.vmethod_25(0f);
				}
				else if (num > 0f && num <= 40f)
				{
					this.activeUnit_0.vmethod_25(4f * num);
				}
				else if (num > 40f && num <= 180f)
				{
					this.activeUnit_0.vmethod_25(flag ? 90f : num2);
				}
				else if (num > 180f && num <= 320f)
				{
					this.activeUnit_0.vmethod_25(flag ? -90f : (-num2));
				}
				else
				{
					this.activeUnit_0.vmethod_25(-4f * (360f - num));
				}
				if (this.method_112().method_159().enum45_0 == Aircraft_Kinematics.Enum45.const_1)
				{
					num2 = 45f;
				}
				if (this.activeUnit_0.vmethod_24() > num2)
				{
					this.activeUnit_0.vmethod_25(num2);
				}
				if (this.activeUnit_0.vmethod_24() < -num2)
				{
					this.activeUnit_0.vmethod_25(-num2);
				}
			}
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x000E6BA4 File Offset: 0x000E4DA4
		public override void vmethod_19(float float_3)
		{
			Aircraft_AI.Class247 @class = new Aircraft_AI.Class247();
			@class.aircraft_AI_0 = this;
			@class.float_0 = float_3;
			try
			{
				if (this.vmethod_3() != null)
				{
					if (this.vmethod_3().contactType_0 == Contact_Base.ContactType.Air)
					{
						if (this.method_131())
						{
							this.method_142();
							return;
						}
						if (this.method_130())
						{
							this.method_141();
							return;
						}
					}
					if (!this.method_127())
					{
						Weapon weapon = null;
						float float_4 = 0f;
						bool bool_ = false;
						if (this.vmethod_3() != null)
						{
							weapon = this.activeUnit_0.vmethod_89().method_16(this.vmethod_3(), true, true, true, this.activeUnit_0.doctrine_0);
							if (weapon != null)
							{
								float_4 = weapon.method_257(this.vmethod_3());
							}
						}
						if (this.vmethod_3().bool_18 && this.vmethod_3().vmethod_40() > 0f)
						{
							if (Math.Abs(Math.Abs(Class437.smethod_3(this.vmethod_3().vmethod_9(), this.vmethod_3().method_32(this.activeUnit_0)))) <= 90f)
							{
								if (this.method_112().method_161().method_60(this.vmethod_3()))
								{
									base.method_63(@class.float_0, 10f, float_4);
								}
								else if (this.vmethod_3().activeUnit_0 != null && this.vmethod_3().activeUnit_0.vmethod_86().vmethod_3() != null && this.vmethod_3().activeUnit_0.vmethod_86().vmethod_3().activeUnit_0 == this.method_112())
								{
									base.method_63(@class.float_0, 10f, float_4);
								}
								else
								{
									this.vmethod_21(@class.float_0, null, ref bool_);
								}
							}
							else
							{
								base.method_63(@class.float_0, 10f, float_4);
							}
						}
						else
						{
							base.method_63(@class.float_0, 10f, float_4);
						}
						base.method_52(ref weapon, this.vmethod_3());
						Weapon weapon2 = null;
						if (base.method_73(this.vmethod_3()))
						{
							Doctrine.Enum62? @enum = this.activeUnit_0.doctrine_0.method_142(this.activeUnit_0.scenario_0, false, false, false);
							byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								this.method_126(@class.float_0, ref weapon2);
							}
						}
						if (this.activeUnit_0.vmethod_85().bool_1 && !this.bool_5)
						{
							Task.Factory.StartNew(new Action(@class.method_0));
						}
						else if (this.activeUnit_0.vmethod_85().method_44())
						{
							this.activeUnit_0.vmethod_85().vmethod_16(@class.float_0);
						}
						if (this.vmethod_3().contactType_0 == Contact_Base.ContactType.Submarine && !Information.IsNothing(this.vmethod_3().method_112()))
						{
							if (!this.method_112().method_161().method_17(this.vmethod_3(), false))
							{
								this.method_112().method_157().method_52();
								this.method_112().method_157().vmethod_16(@class.float_0);
								Aircraft_AirOps aircraft_AirOps = this.method_112().method_164();
								if (Information.IsNothing(this.activeUnit_0.vmethod_87().vmethod_10()) && aircraft_AirOps.method_36() != Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
								{
									this.method_112().vmethod_134(ActiveUnit.Throttle.Full, null);
								}
								if (!this.activeUnit_0.vmethod_87().vmethod_12())
								{
									if (!Information.IsNothing(this.activeUnit_0.vmethod_101()))
									{
										if (this.activeUnit_0.vmethod_101()._MissionClass_0 != Mission._MissionClass.Patrol && this.activeUnit_0.vmethod_101()._MissionClass_0 != Mission._MissionClass.Mining)
										{
											if (this.activeUnit_0.vmethod_101()._MissionClass_0 != Mission._MissionClass.MineClearing)
											{
												this.method_112().method_157().method_67();
												goto IL_418;
											}
										}
										this.method_112().method_157().method_68(true, aircraft_AirOps.method_36());
									}
									else
									{
										this.method_112().method_157().method_67();
									}
								}
								IL_418:
								this.vmethod_24(@class.float_0, ref weapon2);
								return;
							}
							if (this.method_112().method_157().method_47())
							{
								Doctrine.Enum64? enum2 = this.activeUnit_0.doctrine_0.method_83(this.activeUnit_0.scenario_0, false, null, false, false);
								byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									this.method_112().method_157().vmethod_16(@class.float_0);
								}
							}
						}
						if (!this.activeUnit_0.vmethod_87().vmethod_12())
						{
							if (base.method_73(this.vmethod_3()))
							{
								this.vmethod_24(@class.float_0, ref weapon2);
							}
							else if (this.vmethod_3().method_125() < Contact_Base.IdentificationStatus.KnownClass)
							{
								this.method_132(bool_);
							}
							else
							{
								Aircraft_AirOps aircraft_AirOps2 = this.method_112().method_164();
								this.method_112().method_157().method_70(aircraft_AirOps2.method_36());
							}
						}
						if (Math.Abs(Class437.smethod_3(this.method_112().vmethod_9(), this.method_112().vmethod_68())) > 90f)
						{
							int num = this.method_112().method_159().method_25();
							if (this.method_112().vmethod_40() > (float)num)
							{
								this.method_112().vmethod_71((float)num);
								this.method_112().vmethod_134(this.method_112().method_159().vmethod_41(this.method_112().vmethod_40(), (float)num), null);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100388", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x000E71D0 File Offset: 0x000E53D0
		private bool method_127()
		{
			bool result;
			try
			{
				if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
				{
					if (this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.EngagedDefensive)
					{
						if ((this.activeUnit_0.vmethod_85().method_49() && this.activeUnit_0.vmethod_85().method_47()) || (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_49() && this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_47()))
						{
							Waypoint waypoint;
							DateTime? nullable_;
							if (this.activeUnit_0.vmethod_85().method_47())
							{
								waypoint = this.activeUnit_0.vmethod_85().method_4()[0];
								nullable_ = this.activeUnit_0.vmethod_85().nullable_2;
							}
							else
							{
								waypoint = this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_4()[0];
								nullable_ = this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().nullable_2;
							}
							if ((waypoint.waypointType_0 == Waypoint.WaypointType.Target || waypoint.waypointType_0 == Waypoint.WaypointType.WeaponTarget) && (waypoint.enum94_0 == Mission.Enum94.const_4 || waypoint.enum94_0 == Mission.Enum94.const_3) && (waypoint.float_27 > 0f & waypoint.float_26 > 0f))
							{
								DateTime? dateTime;
								if (!Information.IsNothing(nullable_))
								{
									dateTime = new DateTime?(nullable_.Value.AddSeconds((double)(waypoint.float_4 + waypoint.float_5 + waypoint.float_24 + waypoint.float_25 + waypoint.float_26)));
								}
								else if (!Information.IsNothing(waypoint.nullable_7))
								{
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									dateTime = waypoint.nullable_7;
								}
								if (Information.IsNothing(dateTime))
								{
									return false;
								}
								switch (this.activeUnit_0.enum106_0)
								{
								case Mission.Flight.Enum106.const_1:
									if (this.activeUnit_0.method_122())
									{
										dateTime = new DateTime?(dateTime.Value.AddSeconds((double)((float)(this.activeUnit_0.vmethod_65(false).vmethod_141().Count - 1) * waypoint.float_27)));
									}
									break;
								case Mission.Flight.Enum106.const_2:
									if (this.activeUnit_0.method_122())
									{
										dateTime = new DateTime?(dateTime.Value.AddSeconds((double)((float)(this.activeUnit_0.vmethod_65(false).vmethod_141().Count - 1) * waypoint.float_27)));
									}
									else if (this.activeUnit_0.method_120())
									{
										int num = 0;
										for (int i = this.activeUnit_0.vmethod_65(false).vmethod_141().Count - 1; i >= 0; i += -1)
										{
											ActiveUnit activeUnit = Enumerable.ElementAtOrDefault<ActiveUnit>(this.activeUnit_0.vmethod_65(false).vmethod_141().Values, i);
											if (!activeUnit.method_122())
											{
												if (activeUnit == this.activeUnit_0)
												{
													dateTime = new DateTime?(dateTime.Value.AddSeconds((double)((float)num * waypoint.float_27)));
													break;
												}
												num++;
											}
										}
									}
									break;
								case Mission.Flight.Enum106.const_3:
									if (this.activeUnit_0.method_122())
									{
										dateTime = new DateTime?(dateTime.Value.AddSeconds((double)((float)(this.activeUnit_0.vmethod_65(false).vmethod_141().Count - 1) * waypoint.float_27)));
									}
									else if (this.activeUnit_0.method_120())
									{
										int num2 = 0;
										for (int j = this.activeUnit_0.vmethod_65(false).vmethod_141().Count - 1; j >= 0; j += -1)
										{
											ActiveUnit activeUnit2 = Enumerable.ElementAtOrDefault<ActiveUnit>(this.activeUnit_0.vmethod_65(false).vmethod_141().Values, j);
											if (!activeUnit2.method_122())
											{
												if (activeUnit2 == this.activeUnit_0)
												{
													dateTime = new DateTime?(dateTime.Value.AddSeconds((double)((float)num2 * waypoint.float_27)));
													break;
												}
												num2++;
											}
										}
									}
									break;
								case Mission.Flight.Enum106.const_4:
									if (this.activeUnit_0.method_122())
									{
										dateTime = new DateTime?(dateTime.Value.AddSeconds((double)((float)(this.activeUnit_0.vmethod_65(false).vmethod_141().Count - 1) * waypoint.float_27)));
									}
									else if (this.activeUnit_0.method_120())
									{
										int num3 = 0;
										for (int k = this.activeUnit_0.vmethod_65(false).vmethod_141().Count - 1; k >= 0; k += -1)
										{
											ActiveUnit activeUnit3 = Enumerable.ElementAtOrDefault<ActiveUnit>(this.activeUnit_0.vmethod_65(false).vmethod_141().Values, k);
											if (!activeUnit3.method_122())
											{
												if (activeUnit3 == this.activeUnit_0)
												{
													dateTime = new DateTime?(dateTime.Value.AddSeconds((double)((float)num3 * waypoint.float_27)));
													break;
												}
												num3++;
											}
										}
									}
									break;
								case Mission.Flight.Enum106.const_5:
									if (this.activeUnit_0.method_122())
									{
										dateTime = new DateTime?(dateTime.Value.AddSeconds((double)((float)(this.activeUnit_0.vmethod_65(false).vmethod_141().Count - 1) * waypoint.float_27)));
									}
									else if (this.activeUnit_0.method_120())
									{
										int num4 = 0;
										for (int l = this.activeUnit_0.vmethod_65(false).vmethod_141().Count - 1; l >= 0; l += -1)
										{
											ActiveUnit activeUnit4 = Enumerable.ElementAtOrDefault<ActiveUnit>(this.activeUnit_0.vmethod_65(false).vmethod_141().Values, l);
											if (!activeUnit4.method_122())
											{
												if (activeUnit4 == this.activeUnit_0)
												{
													dateTime = new DateTime?(dateTime.Value.AddSeconds((double)((float)num4 * waypoint.float_27)));
													break;
												}
												num4++;
											}
										}
									}
									break;
								case Mission.Flight.Enum106.const_6:
									if (this.activeUnit_0.method_122())
									{
										dateTime = new DateTime?(dateTime.Value.AddSeconds((double)((float)(this.activeUnit_0.vmethod_65(false).vmethod_141().Count - 1) * waypoint.float_27)));
									}
									else if (this.activeUnit_0.method_120())
									{
										int num5 = 0;
										for (int m = this.activeUnit_0.vmethod_65(false).vmethod_141().Count - 1; m >= 0; m += -1)
										{
											ActiveUnit activeUnit5 = Enumerable.ElementAtOrDefault<ActiveUnit>(this.activeUnit_0.vmethod_65(false).vmethod_141().Values, m);
											if (!activeUnit5.method_122())
											{
												if (activeUnit5 == this.activeUnit_0)
												{
													dateTime = new DateTime?(dateTime.Value.AddSeconds((double)((float)num5 * waypoint.float_27)));
													break;
												}
												num5++;
											}
										}
									}
									break;
								}
								return this.activeUnit_0.vmethod_86().vmethod_30(dateTime, ref waypoint, false);
							}
						}
						return false;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101373", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x000E7944 File Offset: 0x000E5B44
		public override bool vmethod_30(DateTime? nullable_10, ref Waypoint waypoint_0, bool bool_11)
		{
			bool result;
			try
			{
				if (this.activeUnit_0.vmethod_40() == 0f)
				{
					result = false;
				}
				else if (Information.IsNothing(waypoint_0))
				{
					result = false;
				}
				else
				{
					if (Information.IsNothing(nullable_10))
					{
						if (Information.IsNothing(this.activeUnit_0.vmethod_85().nullable_2))
						{
							return false;
						}
						nullable_10 = new DateTime?(this.activeUnit_0.vmethod_85().nullable_2.Value.AddSeconds((double)(waypoint_0.float_4 + waypoint_0.float_5 + waypoint_0.float_24 + waypoint_0.float_25 + waypoint_0.float_26)));
					}
					double num = this.method_128(ref this.activeUnit_0.scenario_0, ref nullable_10, ref waypoint_0, bool_11);
					if (num <= 0.0 && (num != -3.4028234663852886E+38 || (nullable_10.Value - this.activeUnit_0.scenario_0.method_31()).TotalSeconds <= 60.0))
					{
						result = false;
					}
					else
					{
						float num2;
						if (!Information.IsNothing(this.activeUnit_0.vmethod_85().nullable_3) && !Information.IsNothing(this.activeUnit_0.vmethod_85().nullable_4))
						{
							num2 = Math2.smethod_17(this.activeUnit_0.vmethod_85().nullable_3.Value, this.activeUnit_0.vmethod_85().nullable_4.Value, waypoint_0.imethod_2(), waypoint_0.imethod_0());
						}
						else
						{
							num2 = Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), waypoint_0.imethod_2(), waypoint_0.imethod_0());
						}
						if (bool_11)
						{
							if (Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), waypoint_0.imethod_2(), waypoint_0.imethod_0()) > 6f)
							{
								result = false;
							}
							else if (num % 120.0 > 60.0)
							{
								this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(num2 + 90f));
								result = true;
							}
							else
							{
								this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(num2 - 90f));
								result = true;
							}
						}
						else
						{
							if (waypoint_0.waypointType_0 == Waypoint.WaypointType.Target || waypoint_0.waypointType_0 == Waypoint.WaypointType.WeaponTarget)
							{
								switch (this.activeUnit_0.enum106_0)
								{
								case Mission.Flight.Enum106.const_1:
									if (waypoint_0.enum94_0 == Mission.Enum94.const_3)
									{
										this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(num2 + 90f));
										return true;
									}
									this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(num2 - 90f));
									return true;
								case Mission.Flight.Enum106.const_2:
									this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(num2 - 90f));
									return true;
								case Mission.Flight.Enum106.const_3:
									if (waypoint_0.enum94_0 == Mission.Enum94.const_3)
									{
										this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(num2 + 90f));
										return true;
									}
									this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(num2 - 90f));
									return true;
								case Mission.Flight.Enum106.const_4:
									this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(num2 - 90f));
									return true;
								case Mission.Flight.Enum106.const_5:
									if (waypoint_0.enum94_0 == Mission.Enum94.const_3)
									{
										this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(num2 + 90f));
										return true;
									}
									this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(num2 - 90f));
									return true;
								case Mission.Flight.Enum106.const_6:
									this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(num2 - 90f));
									return true;
								}
							}
							float num3 = (float)(nullable_10.Value - this.activeUnit_0.scenario_0.method_31()).TotalSeconds;
							if (num3 >= 90f && num / (double)num3 <= 0.1)
							{
								if (num != -3.4028234663852886E+38)
								{
									if (num % 60.0 < 30.0)
									{
										this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(num2 + 45f));
										return true;
									}
									this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(num2 - 45f));
									return true;
								}
							}
							if (num % 240.0 > 120.0)
							{
								this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(num2 + 90f));
								result = true;
							}
							else
							{
								this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(num2 - 90f));
								result = true;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101374", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x000E7E88 File Offset: 0x000E6088
		public override bool vmethod_31(ref Scenario scenario_0, ref Waypoint waypoint_0, ref Waypoint waypoint_1)
		{
			bool result;
			try
			{
				if (this.activeUnit_0.vmethod_40() == 0f)
				{
					this.geoPoint_1 = null;
					result = false;
				}
				else if (Information.IsNothing(waypoint_0))
				{
					this.geoPoint_1 = null;
					result = false;
				}
				else if (Information.IsNothing(waypoint_1))
				{
					this.geoPoint_1 = null;
					result = false;
				}
				else if (Information.IsNothing(waypoint_1.nullable_7))
				{
					this.geoPoint_1 = null;
					result = false;
				}
				else
				{
					if (Information.IsNothing(this.geoPoint_1))
					{
						this.geoPoint_1 = new GeoPoint(waypoint_0.imethod_0(), waypoint_0.imethod_2());
					}
					if (this.activeUnit_0.vmethod_85().vmethod_18(this.geoPoint_1.imethod_2(), this.geoPoint_1.imethod_0(), 1f))
					{
						if (waypoint_0.imethod_0() == this.geoPoint_1.imethod_0() && waypoint_0.imethod_2() == this.geoPoint_1.imethod_2())
						{
							if (waypoint_0.method_44() && !Information.IsNothing(waypoint_0.geoPoint_0))
							{
								this.geoPoint_1.imethod_1(waypoint_0.geoPoint_0.imethod_0());
								this.geoPoint_1.imethod_3(waypoint_0.geoPoint_0.imethod_2());
							}
							else
							{
								if (Information.IsNothing(this.activeUnit_0.vmethod_85().nullable_3) || Information.IsNothing(this.activeUnit_0.vmethod_85().nullable_4))
								{
									this.geoPoint_1 = null;
									return false;
								}
								this.geoPoint_1.imethod_1(this.activeUnit_0.vmethod_85().nullable_4.Value);
								this.geoPoint_1.imethod_3(this.activeUnit_0.vmethod_85().nullable_3.Value);
							}
						}
						else
						{
							this.geoPoint_1.imethod_1(waypoint_0.imethod_0());
							this.geoPoint_1.imethod_3(waypoint_0.imethod_2());
						}
					}
					DateTime value = waypoint_1.nullable_7.Value;
					float num = Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), waypoint_1.imethod_2(), waypoint_1.imethod_0());
					Misc.Enum143 @enum = Misc.smethod_63(this.activeUnit_0.vmethod_9(), num);
					float float_;
					if (@enum != Misc.Enum143.const_0)
					{
						if (@enum == Misc.Enum143.const_1)
						{
							float_ = 9f;
						}
					}
					else
					{
						float_ = -9f;
					}
					float num2 = this.activeUnit_0.vmethod_9();
					float num3;
					if (!Information.IsNothing(waypoint_0.nullable_0))
					{
						num3 = waypoint_0.nullable_0.Value;
					}
					else
					{
						num3 = this.activeUnit_0.vmethod_40();
					}
					if (!Information.IsNothing(waypoint_0.nullable_7) && waypoint_0.nullable_1 != null)
					{
						DateTime? nullable_ = waypoint_0.nullable_7;
						DateTime t = this.activeUnit_0.scenario_0.method_31();
						if (((nullable_ != null) ? new bool?(DateTime.Compare(nullable_.GetValueOrDefault(), t) < 0) : null).GetValueOrDefault())
						{
							float? nullable_2 = waypoint_0.nullable_1;
							float num4 = this.activeUnit_0.vmethod_72();
							if (((nullable_2 != null) ? new bool?(nullable_2.GetValueOrDefault() > num4) : null).GetValueOrDefault())
							{
								this.activeUnit_0.vmethod_73(waypoint_0.nullable_1.Value);
								float num5 = this.activeUnit_0.vmethod_87().vmethod_30();
								float num6 = this.activeUnit_0.vmethod_87().vmethod_31();
								if (this.activeUnit_0.vmethod_72() > num5)
								{
									this.activeUnit_0.vmethod_73(num5);
								}
								else if (this.activeUnit_0.vmethod_72() < num6)
								{
									this.activeUnit_0.vmethod_73(num6);
								}
							}
						}
					}
					float num7 = this.activeUnit_0.vmethod_40();
					List<Waypoint.Class281> list = new List<Waypoint.Class281>();
					bool flag = false;
					Waypoint[] array = new Waypoint[0];
					ActiveUnit activeUnit_ = this.activeUnit_0;
					bool bool_ = false;
					bool bool_2 = false;
					Doctrine doctrine = null;
					Waypoint waypoint = Waypoint.smethod_14(ref activeUnit_.scenario_0, ref waypoint_1, bool_, bool_2, ref doctrine);
					ActiveUnit activeUnit_2 = this.activeUnit_0;
					bool bool_3 = false;
					bool bool_4 = false;
					doctrine = null;
					Waypoint waypoint2 = Waypoint.smethod_14(ref activeUnit_2.scenario_0, ref waypoint_0, bool_3, bool_4, ref doctrine);
					waypoint2.imethod_3(this.activeUnit_0.vmethod_30(null));
					waypoint2.imethod_1(this.activeUnit_0.vmethod_28(null));
					Class429.smethod_36(ref array, waypoint2);
					Class429.smethod_36(ref array, waypoint);
					Waypoint waypoint3 = null;
					float float_2 = num7;
					Mission.Flight flight = null;
					Class514.smethod_40(ref num2, ref list, ref waypoint, ref waypoint3, ref waypoint2, ref num3, float_2, ref flight, float_, @enum, num, ref flag, true, "", this.activeUnit_0.vmethod_85().method_4());
					float num8;
					if (flag)
					{
						num8 = float.MinValue;
					}
					else
					{
						Mission mission = null;
						flight = null;
						float num4 = 0f;
						float num9 = 0f;
						bool flag2 = false;
						Class514.smethod_35(ref scenario_0, ref mission, ref flight, ref array, ref this.activeUnit_0, ref num4, ref num9, ref flag2, false, false, "", true);
						float num10 = waypoint.float_5 + waypoint.float_4;
						DateTime d = this.activeUnit_0.scenario_0.method_31().AddSeconds((double)num10);
						num8 = (float)(value - d).TotalSeconds;
					}
					if (num8 <= 0f && (num8 != -3.4028235E+38f || (value - this.activeUnit_0.scenario_0.method_31()).TotalSeconds <= 60.0))
					{
						this.geoPoint_1 = null;
						Class211 @class = this.method_112().method_157();
						float float_3 = 1f;
						bool flag2 = true;
						bool flag3 = false;
						@class.vmethod_19(float_3, ref flag2, ref flag3);
						result = false;
					}
					else
					{
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.geoPoint_1.imethod_2(), this.geoPoint_1.imethod_0()));
						result = true;
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
				this.geoPoint_1 = null;
				result = false;
			}
			return result;
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x000E84E0 File Offset: 0x000E66E0
		private double method_128(ref Scenario scenario_0, ref DateTime? nullable_10, ref Waypoint waypoint_0, bool bool_11)
		{
			double result;
			try
			{
				if (Information.IsNothing(waypoint_0))
				{
					result = 0.0;
				}
				else if (Information.IsNothing(nullable_10))
				{
					result = 0.0;
				}
				else
				{
					DateTime t = this.activeUnit_0.scenario_0.method_31();
					DateTime? dateTime = nullable_10;
					if (!((dateTime != null) ? new bool?(DateTime.Compare(t, dateTime.GetValueOrDefault()) >= 0) : null).GetValueOrDefault())
					{
						if (!bool_11 && !Information.IsNothing(waypoint_0) && !Information.IsNothing(waypoint_0.nullable_7) && !Information.IsNothing(this.activeUnit_0.vmethod_85().nullable_2))
						{
							DateTime t2 = this.activeUnit_0.vmethod_85().nullable_2.Value.AddSeconds((double)(waypoint_0.float_4 + waypoint_0.float_5));
							if (DateTime.Compare(t2, nullable_10.Value) >= 0)
							{
								return -1.0;
							}
						}
						DateTime value;
						if (this.activeUnit_0.vmethod_85().method_47())
						{
							if (!this.activeUnit_0.vmethod_85().method_49())
							{
								return -1.0;
							}
							this.activeUnit_0.vmethod_85().method_7();
							if (!bool_11)
							{
								if (Information.IsNothing(this.activeUnit_0.vmethod_85().nullable_2))
								{
									return -1.0;
								}
								value = this.activeUnit_0.vmethod_85().nullable_2.Value;
							}
						}
						else
						{
							if (!this.activeUnit_0.method_121() || Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) || !this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_47())
							{
								return -1.0;
							}
							if (!this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_49())
							{
								return -1.0;
							}
							this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_7();
							if (!bool_11)
							{
								if (Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().nullable_2))
								{
									return -1.0;
								}
								value = this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().nullable_2.Value;
							}
						}
						int num = Enumerable.Count<Waypoint>(this.activeUnit_0.vmethod_85().method_7().method_15()) - 1;
						int i = 1;
						while (i <= num)
						{
							Waypoint waypoint = this.activeUnit_0.vmethod_85().method_7().method_15()[i];
							Waypoint waypoint2;
							if (waypoint == waypoint_0)
							{
								waypoint2 = this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1];
							}
							else if (!Information.IsNothing(waypoint.waypoint_0) && waypoint.waypoint_0 == waypoint_0)
							{
								if (!Information.IsNothing(this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1].waypoint_0))
								{
									waypoint2 = this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1].waypoint_0;
								}
								else
								{
									waypoint2 = this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1];
								}
								waypoint = waypoint.waypoint_0;
							}
							else if (!Information.IsNothing(waypoint.waypoint_1) && waypoint.waypoint_1 == waypoint_0)
							{
								if (!Information.IsNothing(this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1].waypoint_1))
								{
									waypoint2 = this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1].waypoint_1;
								}
								else
								{
									waypoint2 = this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1];
								}
								waypoint = waypoint.waypoint_1;
							}
							else if (!Information.IsNothing(waypoint.waypoint_2) && waypoint.waypoint_2 == waypoint_0)
							{
								if (!Information.IsNothing(this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1].waypoint_2))
								{
									waypoint2 = this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1].waypoint_2;
								}
								else
								{
									waypoint2 = this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1];
								}
								waypoint = waypoint.waypoint_2;
							}
							else if (!Information.IsNothing(waypoint.waypoint_3) && waypoint.waypoint_3 == waypoint_0)
							{
								if (!Information.IsNothing(this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1].waypoint_3))
								{
									waypoint2 = this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1].waypoint_3;
								}
								else
								{
									waypoint2 = this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1];
								}
								waypoint = waypoint.waypoint_3;
							}
							else
							{
								if (Information.IsNothing(waypoint.waypoint_4) || waypoint.waypoint_4 != waypoint_0)
								{
									i++;
									continue;
								}
								if (!Information.IsNothing(this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1].waypoint_4))
								{
									waypoint2 = this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1].waypoint_4;
								}
								else
								{
									waypoint2 = this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1];
								}
								waypoint = waypoint.waypoint_3;
							}
							IL_5CA:
							if (Information.IsNothing(waypoint) || Information.IsNothing(waypoint2))
							{
								return -1.0;
							}
							if (!bool_11 && !Information.IsNothing(nullable_10) && !Information.IsNothing(waypoint2.nullable_7))
							{
								t = value;
								dateTime = waypoint2.nullable_7;
								if (((dateTime != null) ? new bool?(DateTime.Compare(t, dateTime.GetValueOrDefault()) > 0) : null).GetValueOrDefault())
								{
									nullable_10 = new DateTime?(nullable_10.Value.AddSeconds((value - waypoint2.nullable_7.Value).TotalSeconds));
								}
							}
							float num2 = Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), waypoint.imethod_2(), waypoint.imethod_0());
							Misc.Enum143 @enum = Misc.smethod_63(this.activeUnit_0.vmethod_9(), num2);
							float float_;
							if (@enum != Misc.Enum143.const_0)
							{
								if (@enum == Misc.Enum143.const_1)
								{
									float_ = 9f;
								}
							}
							else
							{
								float_ = -9f;
							}
							float num3 = this.activeUnit_0.vmethod_9();
							float num4 = this.activeUnit_0.vmethod_70();
							float num5 = this.activeUnit_0.vmethod_40();
							List<Waypoint.Class281> list = new List<Waypoint.Class281>();
							bool flag = false;
							Waypoint[] array = new Waypoint[0];
							ActiveUnit activeUnit_ = this.activeUnit_0;
							bool bool_12 = false;
							bool bool_13 = false;
							Doctrine doctrine = null;
							waypoint = Waypoint.smethod_14(ref activeUnit_.scenario_0, ref waypoint, bool_12, bool_13, ref doctrine);
							ActiveUnit activeUnit_2 = this.activeUnit_0;
							bool bool_14 = false;
							bool bool_15 = false;
							doctrine = null;
							waypoint2 = Waypoint.smethod_14(ref activeUnit_2.scenario_0, ref waypoint2, bool_14, bool_15, ref doctrine);
							waypoint.waypointType_0 = Waypoint.WaypointType.TurningPoint;
							waypoint2.waypointType_0 = Waypoint.WaypointType.TurningPoint;
							waypoint2.imethod_3(this.activeUnit_0.vmethod_30(null));
							waypoint2.imethod_1(this.activeUnit_0.vmethod_28(null));
							Class429.smethod_36(ref array, waypoint2);
							Class429.smethod_36(ref array, waypoint);
							Waypoint waypoint3 = null;
							float float_2 = num5;
							Mission.Flight flight = null;
							Class514.smethod_40(ref num3, ref list, ref waypoint, ref waypoint2, ref waypoint3, ref num4, float_2, ref flight, float_, @enum, num2, ref flag, true, "", this.activeUnit_0.vmethod_85().method_4());
							if (flag)
							{
								return -3.4028234663852886E+38;
							}
							Mission mission = null;
							flight = null;
							float num6 = 0f;
							float num7 = 0f;
							bool flag2 = false;
							Class514.smethod_35(ref scenario_0, ref mission, ref flight, ref array, ref this.activeUnit_0, ref num6, ref num7, ref flag2, false, false, "", true);
							float num8 = waypoint.float_5 + waypoint.float_4;
							DateTime d = this.activeUnit_0.scenario_0.method_31().AddSeconds((double)num8);
							return (double)((float)(nullable_10.Value - d).TotalSeconds);
						}
						goto IL_5CA;
					}
					result = -1.0;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101375", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = -1.0;
			}
			return result;
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x000E8DEC File Offset: 0x000E6FEC
		public bool method_129(Contact contact_8)
		{
			bool result;
			if (Information.IsNothing(contact_8.activeUnit_0))
			{
				result = false;
			}
			else if (Information.IsNothing(this.method_112().method_167()))
			{
				result = false;
			}
			else
			{
				Loadout loadout = this.method_112().method_167();
				switch (contact_8.contactType_0)
				{
				case Contact_Base.ContactType.Air:
				{
					Loadout.LoadoutRole loadoutRole_ = loadout.loadoutRole_0;
					return loadoutRole_ - Loadout.LoadoutRole.Intercept_BVR <= 6;
				}
				case Contact_Base.ContactType.Surface:
				{
					Loadout.LoadoutRole loadoutRole_2 = loadout.loadoutRole_0;
					if (loadoutRole_2 <= Loadout.LoadoutRole.NavalOnly_SEAD_ARM)
					{
						if (loadoutRole_2 - Loadout.LoadoutRole.LandNaval_Strike <= 2 || loadoutRole_2 == Loadout.LoadoutRole.LandNaval_DEAD || loadoutRole_2 - Loadout.LoadoutRole.NavalOnly_Strike <= 2)
						{
							goto IL_E1;
						}
					}
					else
					{
						if (loadoutRole_2 == Loadout.LoadoutRole.NavalOnly_DEAD || loadoutRole_2 == Loadout.LoadoutRole.BAI_CAS)
						{
							goto IL_E1;
						}
						if (loadoutRole_2 == Loadout.LoadoutRole.Forward_Observer)
						{
							goto IL_E1;
						}
					}
					return false;
					IL_E1:
					return true;
				}
				case Contact_Base.ContactType.Submarine:
				{
					Loadout.LoadoutRole loadoutRole_3 = loadout.loadoutRole_0;
					return loadoutRole_3 - Loadout.LoadoutRole.ASW_Patrol <= 1;
				}
				case Contact_Base.ContactType.Facility_Fixed:
				case Contact_Base.ContactType.Facility_Mobile:
				{
					Loadout.LoadoutRole loadoutRole_4 = loadout.loadoutRole_0;
					if (loadoutRole_4 <= Loadout.LoadoutRole.LandOnly_SEAD_ARM)
					{
						if (loadoutRole_4 - Loadout.LoadoutRole.LandNaval_Standoff <= 1 || loadoutRole_4 == Loadout.LoadoutRole.LandNaval_DEAD || loadoutRole_4 - Loadout.LoadoutRole.LandOnly_Strike <= 2)
						{
							goto IL_157;
						}
					}
					else
					{
						if (loadoutRole_4 == Loadout.LoadoutRole.LandOnly_DEAD || loadoutRole_4 == Loadout.LoadoutRole.BAI_CAS)
						{
							goto IL_157;
						}
						if (loadoutRole_4 == Loadout.LoadoutRole.Forward_Observer)
						{
							goto IL_157;
						}
					}
					return false;
					IL_157:
					return true;
				}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x000E8F54 File Offset: 0x000E7154
		private bool method_130()
		{
			Doctrine._BVRLogicEnum? bvrlogicEnum = this.method_112().doctrine_0.method_132(this.method_112().scenario_0, false, false, false);
			byte? b = (bvrlogicEnum != null) ? new byte?((byte)bvrlogicEnum.GetValueOrDefault()) : null;
			bool result;
			if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				result = false;
			}
			else
			{
				try
				{
					if (base.method_12().Length == 0)
					{
						result = false;
					}
					else if (this.method_112().scenario_0.method_17().Count == 0)
					{
						result = false;
					}
					else if (Enumerable.ToList<Weapon>(Enumerable.Where<Weapon>(this.method_112().method_161().method_58(), (Aircraft_AI._Closure$__.$I42-0 == null) ? (Aircraft_AI._Closure$__.$I42-0 = new Func<Weapon, bool>(Aircraft_AI._Closure$__.$I.method_13)) : Aircraft_AI._Closure$__.$I42-0)).Count == 0)
					{
						result = false;
					}
					else
					{
						bool flag = false;
						try
						{
							foreach (Contact contact in this.activeUnit_0.vmethod_7(false).method_44())
							{
								if (contact.method_130(this.activeUnit_0.vmethod_7(false)) != Misc.PostureStance.Friendly && contact.method_130(this.activeUnit_0.vmethod_7(false)) != Misc.PostureStance.Neutral && contact.contactType_0 == Contact_Base.ContactType.Air && Math.Abs(this.activeUnit_0.method_46(contact, true)) < 70f)
								{
									Math.Abs(contact.method_46(this.activeUnit_0, true));
									foreach (Sensor sensor in this.method_112().method_78())
									{
										if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar && sensor.method_20(contact, null))
										{
											flag = true;
											break;
										}
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
							List<Contact>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_112().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_160))) == 0 && flag)
						{
							result = true;
						}
						else
						{
							IEnumerable<Weapon> enumerable = Enumerable.Where<Weapon>(this.method_112().method_161().vmethod_4(), (Aircraft_AI._Closure$__.$I42-2 == null) ? (Aircraft_AI._Closure$__.$I42-2 = new Func<Weapon, bool>(Aircraft_AI._Closure$__.$I.method_14)) : Aircraft_AI._Closure$__.$I42-2);
							if (Enumerable.Count<Weapon>(enumerable) == 0)
							{
								result = true;
							}
							else
							{
								float num = Enumerable.Max(Enumerable.Select<Weapon, float>(enumerable, (Aircraft_AI._Closure$__.$I42-3 == null) ? (Aircraft_AI._Closure$__.$I42-3 = new Func<Weapon, float>(Aircraft_AI._Closure$__.$I.method_15)) : Aircraft_AI._Closure$__.$I42-3));
								foreach (Class316 @class in this.activeUnit_0.vmethod_7(false).class316_0)
								{
									foreach (Class316.Class273 class2 in @class.class273_0)
									{
										if (Operators.CompareString(class2.string_0, this.activeUnit_0.string_0, false) == 0)
										{
											if (this.method_112().method_36(@class.contact_0) < num)
											{
												return false;
											}
											if (class2.int_0 - class2.int_1 > 0)
											{
												return false;
											}
										}
									}
								}
								if (flag)
								{
									result = true;
								}
								else
								{
									result = false;
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100389", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x000E9318 File Offset: 0x000E7518
		private bool method_131()
		{
			Doctrine._BVRLogicEnum? bvrlogicEnum = this.method_112().doctrine_0.method_132(this.method_112().scenario_0, false, false, false);
			byte? b = (bvrlogicEnum != null) ? new byte?((byte)bvrlogicEnum.GetValueOrDefault()) : null;
			bool result;
			if (((b != null) ? new bool?(b.GetValueOrDefault() != 2) : null).GetValueOrDefault())
			{
				result = false;
			}
			else
			{
				try
				{
					if (base.method_12().Length == 0)
					{
						result = false;
					}
					else if (this.method_112().scenario_0.method_17().Count == 0)
					{
						result = false;
					}
					else
					{
						List<Weapon> list = Enumerable.ToList<Weapon>(Enumerable.Where<Weapon>(this.method_112().scenario_0.method_17(), new Func<Weapon, bool>(this.method_161)));
						if (list.Count == 0)
						{
							result = false;
						}
						else
						{
							try
							{
								List<Weapon>.Enumerator enumerator = list.GetEnumerator();
								while (enumerator.MoveNext())
								{
									if (!enumerator.Current.method_225())
									{
										return false;
									}
								}
							}
							finally
							{
								List<Weapon>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							bool flag = false;
							try
							{
								foreach (Contact contact in this.activeUnit_0.vmethod_7(false).method_44())
								{
									if (contact.method_130(this.activeUnit_0.vmethod_7(false)) == Misc.PostureStance.Friendly || contact.method_130(this.activeUnit_0.vmethod_7(false)) == Misc.PostureStance.Neutral || contact.contactType_0 != Contact_Base.ContactType.Air || Math.Abs(this.activeUnit_0.method_46(contact, true)) >= 70f)
									{
										if (!flag)
										{
											continue;
										}
									}
									else
									{
										flag = true;
									}
									break;
								}
							}
							finally
							{
								List<Contact>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							if (Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_112().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_162))) == 0 && flag)
							{
								result = true;
							}
							else
							{
								IEnumerable<Weapon> enumerable = Enumerable.Where<Weapon>(this.method_112().method_161().vmethod_4(), (Aircraft_AI._Closure$__.$I43-2 == null) ? (Aircraft_AI._Closure$__.$I43-2 = new Func<Weapon, bool>(Aircraft_AI._Closure$__.$I.method_16)) : Aircraft_AI._Closure$__.$I43-2);
								if (Enumerable.Count<Weapon>(enumerable) == 0)
								{
									result = true;
								}
								else
								{
									float num = Enumerable.Max(Enumerable.Select<Weapon, float>(enumerable, (Aircraft_AI._Closure$__.$I43-3 == null) ? (Aircraft_AI._Closure$__.$I43-3 = new Func<Weapon, float>(Aircraft_AI._Closure$__.$I.method_17)) : Aircraft_AI._Closure$__.$I43-3));
									foreach (Class316 @class in this.activeUnit_0.vmethod_7(false).class316_0)
									{
										foreach (Class316.Class273 class2 in @class.class273_0)
										{
											if (Operators.CompareString(class2.string_0, this.activeUnit_0.string_0, false) == 0)
											{
												if (this.method_112().method_36(@class.contact_0) < num)
												{
													return false;
												}
												if (class2.int_0 - class2.int_1 > 0)
												{
													return false;
												}
											}
										}
									}
									if (flag)
									{
										result = true;
									}
									else
									{
										result = false;
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100389", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x000E96B4 File Offset: 0x000E78B4
		private void method_132(bool bool_11)
		{
			try
			{
				if (Information.IsNothing(this.vmethod_3().activeUnit_0))
				{
					ActiveUnit activeUnit_ = this.activeUnit_0;
					Aircraft aircraft = this.method_112();
					ActiveUnit.Throttle throttle_ = ActiveUnit.Throttle.Cruise;
					ActiveUnit activeUnit_2;
					ActiveUnit activeUnit_3;
					bool bool_12 = (activeUnit_2 = this.activeUnit_0).vmethod_76(activeUnit_3 = this.activeUnit_0);
					float float_ = Aircraft_AI.smethod_2(ref aircraft, throttle_, ref bool_12);
					activeUnit_2.vmethod_77(activeUnit_3, bool_12);
					activeUnit_.vmethod_73(float_);
				}
				else
				{
					IEnumerable<Sensor> enumerable = Enumerable.OrderByDescending<Sensor, float>(Enumerable.Where<Sensor>(this.method_112().vmethod_96(), new Func<Sensor, bool>(this.method_163)), new Func<Sensor, float>(this.method_164));
					if (Enumerable.Count<Sensor>(enumerable) != 0)
					{
						float num = Enumerable.ElementAtOrDefault<Sensor>(enumerable, 0).method_91(this.method_112(), this.vmethod_3().activeUnit_0);
						if (num > 20f)
						{
							num = 20f;
						}
						float num2 = this.method_112().method_36(this.vmethod_3());
						if (this.vmethod_3().bool_19 && num2 < 2f * num)
						{
							this.method_112().vmethod_73(this.vmethod_3().vmethod_14(false));
							this.activeUnit_0.vmethod_77(this.activeUnit_0, false);
						}
						else if ((this.vmethod_3().method_134() || this.vmethod_3().method_136()) && num2 < num)
						{
							this.method_112().vmethod_73(304.80002f);
							this.activeUnit_0.vmethod_77(this.activeUnit_0, false);
						}
						else
						{
							Class211 @class = this.method_112().method_157();
							Aircraft_AirOps aircraft_AirOps = this.method_112().method_164();
							@class.method_70(aircraft_AirOps.method_36());
							@class.method_71(this.activeUnit_0.vmethod_72(), new float?((float)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_72(), ActiveUnit.Throttle.Cruise, false)), bool_11, aircraft_AirOps.method_36());
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100391", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x000E98D0 File Offset: 0x000E7AD0
		public override void vmethod_26(float float_3)
		{
			if (this.activeUnit_0 != null)
			{
				try
				{
					Aircraft_AirOps aircraft_AirOps = this.method_112().method_164();
					ActiveUnit._ActiveUnitStatus activeUnitStatus = this.activeUnit_0.vmethod_108();
					if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.WaitForPathfinder)
					{
						this.method_112().vmethod_71((float)this.method_112().method_159().vmethod_40(this.method_112().vmethod_14(false), ActiveUnit.Throttle.Loiter, false));
						this.method_112().vmethod_134(ActiveUnit.Throttle.Loiter, null);
					}
					else
					{
						if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.RTB_CalledOff)
						{
							if (this.method_112().method_121() && this.method_112().vmethod_65(false).method_147() != null && this.method_112().vmethod_65(false).method_147().vmethod_85().method_47())
							{
								activeUnitStatus = ActiveUnit._ActiveUnitStatus.Tasked;
							}
							else if (this.method_112().method_157().method_47())
							{
								activeUnitStatus = ActiveUnit._ActiveUnitStatus.OnPlottedCourse;
							}
						}
						else if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && this.method_112().vmethod_7(false).list_7.Count > 0 && aircraft_AirOps.method_24() != null && ((this.method_112().method_121() && this.method_112().vmethod_65(false).method_147() != null && this.method_112().vmethod_65(false).method_147().vmethod_85().method_47()) || this.method_112().method_157().method_47()))
						{
							if (this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse)
							{
								if (this.activeUnit_0.vmethod_85().vmethod_29(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), aircraft_AirOps.method_24().vmethod_30(null), aircraft_AirOps.method_24().vmethod_28(null), false, 0f, false, null, true, false, true, null))
								{
									this.method_112().method_157().bool_3 = true;
									if (this.activeUnit_0.scenario_0.FifthMinuteIsChangingOnThisPulse)
									{
										string text = "";
										if (Operators.CompareString(this.method_112().Name, this.method_112().string_2, false) != 0)
										{
											text = " (" + this.method_112().string_2 + ")";
										}
										string text2 = "";
										if (Operators.CompareString(aircraft_AirOps.method_24().Name, aircraft_AirOps.method_24().string_2, false) != 0)
										{
											text2 = " (" + aircraft_AirOps.method_24().string_2 + ")";
										}
										this.method_112().method_124(string.Concat(new string[]
										{
											this.method_112().Name,
											text,
											" has been ordered to refuel from tanker ",
											aircraft_AirOps.method_24().Name,
											text2,
											", however the tanker is blocked by a No-Navigation Zone. Carrying on with assigned task and will proceed to tanker as soon as there is a clear path to it."
										}), this.method_112().Name + " can't hookup to tanker", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_112().vmethod_28(null), this.method_112().vmethod_30(null)));
									}
								}
								else
								{
									this.method_112().method_157().bool_3 = false;
								}
							}
							if (this.method_112().method_157().bool_3)
							{
								activeUnitStatus = this.activeUnit_0.method_84();
							}
						}
						Aircraft_AirOps._AirOpsCondition airOpsCondition = aircraft_AirOps.method_36();
						if (airOpsCondition != Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
						{
							if (airOpsCondition != Aircraft_AirOps._AirOpsCondition.TransferringCargo)
							{
								if (this.method_112().int_6 == 0 && !this.method_112().method_162().vmethod_1() && !this.method_112().method_85())
								{
									this.method_112().method_159().vmethod_27(float_3, false, false);
								}
								else
								{
									switch (activeUnitStatus)
									{
									case ActiveUnit._ActiveUnitStatus.Unassigned:
										if (this.activeUnit_0.method_122())
										{
											this.method_112().method_159().vmethod_27(float_3, false, false);
										}
										else if (this.activeUnit_0.method_120())
										{
											if (this.activeUnit_0.vmethod_65(false).method_143() == Group.GroupType.AirGroup)
											{
												this.method_112().method_157().vmethod_21(float_3);
											}
											else
											{
												this.method_112().method_159().vmethod_27(float_3, false, false);
											}
										}
										else
										{
											if (this.method_112().method_169() && this.activeUnit_0.vmethod_88().method_46() && this.activeUnit_0.vmethod_14(false) <= 45.72f && this.activeUnit_0.vmethod_72() <= 45.72f && this.activeUnit_0.method_10(false, float_3) < 0)
											{
												Doctrine._UseDippingSonar? useDippingSonar = this.activeUnit_0.doctrine_0.method_276(this.activeUnit_0.scenario_0, false, false, false);
												byte? b = (useDippingSonar != null) ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null;
												if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
												{
													this.activeUnit_0.vmethod_87().vmethod_11(null);
													this.activeUnit_0.vmethod_71(0f);
													aircraft_AirOps.method_39(240f);
													goto IL_5C3;
												}
											}
											if (!this.method_112().method_169() || this.activeUnit_0.vmethod_70() != 0f)
											{
												this.method_112().method_159().vmethod_27(float_3, false, false);
											}
										}
										IL_5C3:
										base.method_87();
										if (this.method_112().method_146())
										{
											this.method_139();
										}
										break;
									case ActiveUnit._ActiveUnitStatus.OnPlottedCourse:
										if (this.activeUnit_0.vmethod_101() != null && this.activeUnit_0.vmethod_101()._MissionClass_0 != Mission._MissionClass.Strike && this.activeUnit_0.method_68())
										{
											Class343 @class = (Class343)this.activeUnit_0.vmethod_101();
											if (!this.activeUnit_0.vmethod_85().method_49())
											{
												if (this.activeUnit_0.vmethod_85().method_47())
												{
													if (!this.activeUnit_0.vmethod_85().method_45() && this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 != Waypoint.WaypointType.LocalizationRun && !this.activeUnit_0.vmethod_85().method_37(ref @class.list_5, ref @class.list_14, ref @class.list_10, 30f, false))
													{
														this.activeUnit_0.vmethod_85().vmethod_9();
														this.activeUnit_0.vmethod_85().vmethod_23(float_3, false);
													}
												}
												else
												{
													this.activeUnit_0.vmethod_85().vmethod_23(float_3, false);
												}
											}
										}
										this.activeUnit_0.vmethod_85().vmethod_16(float_3);
										if (this.activeUnit_0.vmethod_101() != null)
										{
											if (this.activeUnit_0.vmethod_101()._MissionClass_0 != Mission._MissionClass.Strike)
											{
												if (this.activeUnit_0.vmethod_101()._MissionClass_0 != Mission._MissionClass.Ferry)
												{
													if (!this.activeUnit_0.method_121())
													{
														Class211 class2 = this.method_112().method_157();
														class2.method_69(false, aircraft_AirOps.method_36());
														class2.method_68(false, aircraft_AirOps.method_36());
													}
												}
												else
												{
													FerryMission ferryMission = (FerryMission)this.activeUnit_0.vmethod_101();
													if (this.activeUnit_0.vmethod_87().vmethod_10() == null)
													{
														if (!Information.IsNothing(this.method_112().method_167()))
														{
															if (!Information.IsNothing(ferryMission.nullable_4))
															{
																this.activeUnit_0.vmethod_134(ferryMission.nullable_4.Value, null);
															}
															else
															{
																this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
															}
														}
														else
														{
															this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
														}
													}
													else
													{
														this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_84(), null);
													}
													if (!this.activeUnit_0.vmethod_87().vmethod_12())
													{
														if (!Information.IsNothing(this.method_112().method_167()))
														{
															if (!Information.IsNothing(ferryMission.nullable_5))
															{
																this.activeUnit_0.vmethod_73(ferryMission.nullable_5.Value);
															}
															else
															{
																ActiveUnit activeUnit_ = this.activeUnit_0;
																Aircraft aircraft = this.method_112();
																ActiveUnit.Throttle throttle_ = this.activeUnit_0.vmethod_84();
																ActiveUnit activeUnit;
																ActiveUnit activeUnit2;
																bool flag = (activeUnit = this.activeUnit_0).vmethod_76(activeUnit2 = this.activeUnit_0);
																float num = Aircraft_AI.smethod_2(ref aircraft, throttle_, ref flag);
																activeUnit.vmethod_77(activeUnit2, flag);
																activeUnit_.vmethod_73(num);
															}
														}
														else
														{
															ActiveUnit activeUnit_2 = this.activeUnit_0;
															Aircraft aircraft = this.method_112();
															ActiveUnit.Throttle throttle_2 = this.activeUnit_0.vmethod_84();
															ActiveUnit activeUnit;
															ActiveUnit activeUnit2;
															bool flag = (activeUnit2 = this.activeUnit_0).vmethod_76(activeUnit = this.activeUnit_0);
															float num2 = Aircraft_AI.smethod_2(ref aircraft, throttle_2, ref flag);
															activeUnit2.vmethod_77(activeUnit, flag);
															activeUnit_2.vmethod_73(num2);
														}
													}
													else
													{
														this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_72());
													}
													if (this.method_112().method_146())
													{
														this.method_139();
													}
												}
											}
											else if (this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse)
											{
												if (this.activeUnit_0.vmethod_85().method_23())
												{
													this.bool_8 = false;
													if (this.activeUnit_0.method_120())
													{
														try
														{
															IEnumerator<ActiveUnit> enumerator = this.activeUnit_0.vmethod_65(false).vmethod_141().Values.GetEnumerator();
															while (enumerator.MoveNext())
															{
																if (enumerator.Current.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IsBingo)
																{
																	if (this.activeUnit_0.vmethod_84() > ActiveUnit.Throttle.Cruise)
																	{
																		this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
																		if (!Information.IsNothing(this.activeUnit_0.vmethod_87().vmethod_10()))
																		{
																			this.activeUnit_0.vmethod_87().vmethod_11(null);
																		}
																		this.activeUnit_0.scenario_0.method_59("One of the aircraft in " + this.activeUnit_0.vmethod_65(false).Name + " has reached Bingo fuel, so the flight goes to cruise speed to prevent running any of the wingmen dry!", this.activeUnit_0.vmethod_65(false).Name + " slowing to cruise (thirsty member)", LoggedMessage.MessageType.AirOps, 0, null, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
																		IL_AA9:
																		goto IL_C61;
																	}
																	this.bool_8 = true;
																}
															}
															goto IL_AA9;
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
													if (this.activeUnit_0.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IsBingo)
													{
														if (this.activeUnit_0.vmethod_84() > ActiveUnit.Throttle.Cruise)
														{
															string str = "";
															if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
															{
																str = " (" + this.activeUnit_0.string_2 + ")";
															}
															this.activeUnit_0.scenario_0.method_59("Aircraft " + this.activeUnit_0.Name + str + " has reached Bingo fuel, so the aircraft goes to cruise speed to prevent running dry", this.activeUnit_0.Name + " slowing to cruise (Bingo)", LoggedMessage.MessageType.AirOps, 0, null, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
															this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
														}
														this.bool_8 = true;
													}
												}
												else
												{
													this.bool_8 = false;
												}
											}
										}
										else if (this.activeUnit_0.vmethod_85().method_47() && !Information.IsNothing(this.activeUnit_0.vmethod_86().vmethod_3()) && (this.activeUnit_0.vmethod_86().vmethod_3().contactType_0 == Contact_Base.ContactType.Submarine || this.activeUnit_0.vmethod_86().vmethod_3().contactType_0 == Contact_Base.ContactType.Surface) && this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.LocalizationRun)
										{
											Class211 class3 = this.method_112().method_157();
											class3.method_69(false, aircraft_AirOps.method_36());
											class3.method_68(false, aircraft_AirOps.method_36());
										}
										IL_C61:
										if (Enumerable.Count<Waypoint>(this.activeUnit_0.vmethod_85().method_4()) != 0 && Enumerable.First<Waypoint>(this.activeUnit_0.vmethod_85().method_4()).waypointType_0 == Waypoint.WaypointType.LocalizationRun && this.activeUnit_0.vmethod_56() == GlobalVariables.ActiveUnitType.Aircraft && !Information.IsNothing(this.vmethod_3()) && this.vmethod_3().contactType_0 == Contact_Base.ContactType.Submarine)
										{
											if (!Information.IsNothing(this.vmethod_3().method_112()))
											{
												if (!GeoPoint.smethod_3(this.activeUnit_0.vmethod_85().method_4()[0].imethod_2(), this.activeUnit_0.vmethod_85().method_4()[0].imethod_0(), this.vmethod_3().method_112(), true))
												{
													this.activeUnit_0.vmethod_85().vmethod_9();
												}
											}
											else
											{
												this.activeUnit_0.vmethod_85().vmethod_9();
											}
										}
										this.method_134(float_3);
										base.method_87();
										if (this.method_112().method_146())
										{
											this.method_139();
										}
										break;
									case ActiveUnit._ActiveUnitStatus.EngagedOffensive:
										if (this.vmethod_3() != null)
										{
											if (this.activeUnit_0.method_120())
											{
												if (this.activeUnit_0.vmethod_65(false).vmethod_85().method_46())
												{
													if (this.activeUnit_0.method_122())
													{
														Doctrine.Enum64? @enum = this.activeUnit_0.doctrine_0.method_83(this.activeUnit_0.scenario_0, false, null, false, false);
														byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
														if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
														{
															this.vmethod_19(float_3);
														}
														else
														{
															this.method_112().method_157().vmethod_16(float_3);
														}
													}
													else if (!this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_22() && !this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_23())
													{
														Doctrine.Enum64? @enum = this.activeUnit_0.doctrine_0.method_83(this.activeUnit_0.scenario_0, false, null, false, false);
														byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
														if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && (this.activeUnit_0.vmethod_112() == ActiveUnit._ActiveUnitWeaponState.None || this.activeUnit_0.vmethod_112() == ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO || this.activeUnit_0.vmethod_112() == ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO))
														{
															this.vmethod_19(float_3);
														}
														else
														{
															this.method_112().method_157().vmethod_21(float_3);
														}
													}
													else
													{
														this.vmethod_19(float_3);
													}
													break;
												}
												this.vmethod_19(float_3);
											}
											else
											{
												this.vmethod_19(float_3);
											}
											base.method_87();
										}
										break;
									case ActiveUnit._ActiveUnitStatus.EngagedDefensive:
										if (this.contact_1 != null)
										{
											this.activeUnit_0.vmethod_87().vmethod_11(null);
											this.vmethod_23(float_3);
										}
										break;
									case ActiveUnit._ActiveUnitStatus.OnPatrol:
										if (!Information.IsNothing(this.activeUnit_0.vmethod_101()))
										{
											if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
											{
												Class343 class4 = (Class343)this.activeUnit_0.vmethod_101();
												if (aircraft_AirOps.method_36() == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
												{
													this.method_112().method_157().vmethod_9();
													aircraft_AirOps.method_77();
												}
												else if (class4 != null)
												{
													if (this.activeUnit_0.method_120())
													{
														if (this.activeUnit_0.method_122())
														{
															if (!this.activeUnit_0.vmethod_85().method_49())
															{
																if (this.activeUnit_0.vmethod_85().method_46())
																{
																	if (!this.activeUnit_0.vmethod_65(false).vmethod_85().method_37(ref class4.list_5, ref class4.list_14, ref class4.list_10, 30f, false))
																	{
																		this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_23(float_3, false);
																	}
																	this.activeUnit_0.vmethod_85().vmethod_16(float_3);
																}
																else
																{
																	this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_23(float_3, false);
																}
															}
														}
														else
														{
															this.method_112().method_157().vmethod_21(float_3);
														}
													}
													else if (this.activeUnit_0.vmethod_85().method_46())
													{
														if (!this.activeUnit_0.vmethod_85().method_49())
														{
															if (this.activeUnit_0.vmethod_85().method_45())
															{
																this.activeUnit_0.vmethod_85().vmethod_16(float_3);
															}
															else if (this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.PatrolStation)
															{
																if (!this.activeUnit_0.vmethod_85().method_37(ref class4.list_5, ref class4.list_14, ref class4.list_10, 30f, false))
																{
																	this.activeUnit_0.vmethod_85().vmethod_23(float_3, false);
																}
																this.activeUnit_0.vmethod_85().vmethod_16(float_3);
															}
														}
													}
													else
													{
														this.activeUnit_0.vmethod_85().vmethod_23(float_3, false);
													}
												}
											}
										}
										break;
									case ActiveUnit._ActiveUnitStatus.RTB:
									case ActiveUnit._ActiveUnitStatus.RTB_Manual:
									case ActiveUnit._ActiveUnitStatus.RTB_MissionOver:
									case ActiveUnit._ActiveUnitStatus.RTB_Group:
									case ActiveUnit._ActiveUnitStatus.RTB_CalledOff:
									{
										Aircraft_AirOps._AirOpsCondition airOpsCondition2 = aircraft_AirOps.method_36();
										if (airOpsCondition2 <= Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown)
										{
											if (airOpsCondition2 == Aircraft_AirOps._AirOpsCondition.Airborne)
											{
												aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.RTB);
												break;
											}
											if (airOpsCondition2 != Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown)
											{
												break;
											}
										}
										else
										{
											if (airOpsCondition2 == Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue)
											{
												this.vmethod_29(float_3);
												this.method_112().vmethod_134(ActiveUnit.Throttle.Loiter, null);
												break;
											}
											if (airOpsCondition2 != Aircraft_AirOps._AirOpsCondition.RTB)
											{
												if (airOpsCondition2 != Aircraft_AirOps._AirOpsCondition.EmergencyLanding)
												{
													break;
												}
											}
											else
											{
												if (this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse && aircraft_AirOps.method_21() != null)
												{
													ActiveUnit activeUnit2;
													bool flag;
													bool flag2;
													List<Mission> list;
													string text3;
													bool flag3;
													if (this.activeUnit_0.vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsBingo)
													{
														if (this.activeUnit_0.vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsJoker)
														{
															Class211 class5 = this.method_112().method_157();
															ActiveUnit.Throttle throttle_3 = class5.method_72();
															flag2 = false;
															float num3 = class5.method_73(ref flag2);
															if ((double)this.method_112().method_159().method_4(this.method_112().method_36(aircraft_AirOps.method_21()), throttle_3, num3, new float?((float)this.method_112().method_159().vmethod_40(num3, throttle_3, false)), false, false, false) <= (double)this.method_112().vmethod_116() * 0.9)
															{
																goto IL_2387;
															}
															Aircraft_AirOps aircraft_AirOps2 = aircraft_AirOps;
															GeoPoint geoPoint_ = null;
															Doctrine.Enum57 enum57_ = Doctrine.Enum57.const_2;
															flag2 = false;
															bool bool_ = false;
															activeUnit2 = null;
															list = null;
															text3 = "";
															flag3 = true;
															flag = false;
															if (aircraft_AirOps2.method_80(geoPoint_, enum57_, ref flag2, bool_, ref activeUnit2, ref list, ref text3, ref flag3, ref flag))
															{
																break;
															}
															goto IL_2387;
														}
													}
													Aircraft_AirOps aircraft_AirOps3 = aircraft_AirOps;
													GeoPoint geoPoint_2 = null;
													Doctrine.Enum57 enum57_2 = Doctrine.Enum57.const_2;
													flag = false;
													bool bool_2 = false;
													activeUnit2 = null;
													list = null;
													text3 = "";
													flag3 = true;
													flag2 = false;
													if (aircraft_AirOps3.method_80(geoPoint_2, enum57_2, ref flag, bool_2, ref activeUnit2, ref list, ref text3, ref flag3, ref flag2))
													{
														break;
													}
												}
												IL_2387:
												if (this.activeUnit_0.vmethod_85().method_47() && !this.activeUnit_0.method_85())
												{
													this.activeUnit_0.vmethod_85().vmethod_16(float_3);
												}
												else
												{
													this.vmethod_29(float_3);
												}
												if (!this.activeUnit_0.method_120() || this.activeUnit_0.vmethod_65(false).method_143() != Group.GroupType.AirGroup)
												{
													break;
												}
												Doctrine._WeaponState? weaponState = this.activeUnit_0.doctrine_0.method_211(this.activeUnit_0.scenario_0, false, true, false, false);
												int? num4 = (weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null;
												if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 3) : null).GetValueOrDefault())
												{
													this.activeUnit_0.method_129(false, true, false);
													break;
												}
												break;
											}
										}
										if (!this.method_112().method_157().method_81(float_3))
										{
											this.method_112().method_157().method_80(float_3);
										}
										else
										{
											aircraft_AirOps.method_39(0f);
										}
										break;
									}
									case ActiveUnit._ActiveUnitStatus.Tasked:
										if (this.activeUnit_0.method_72())
										{
											this.method_143(float_3);
										}
										else if (!Information.IsNothing(this.activeUnit_0.vmethod_101()))
										{
											if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Mining)
											{
												Class340 class6 = (Class340)this.activeUnit_0.vmethod_101();
												if (this.activeUnit_0.method_120())
												{
													if (this.activeUnit_0.method_122())
													{
														if (this.activeUnit_0.vmethod_85().method_46())
														{
															if (!this.activeUnit_0.vmethod_65(false).vmethod_85().method_37(ref class6.list_5, ref class6.list_16, ref class6.list_11, 30f, false))
															{
																this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_22(class6.list_5);
															}
															this.activeUnit_0.vmethod_85().vmethod_16(float_3);
														}
														else
														{
															this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_22(class6.list_5);
														}
													}
													else
													{
														this.method_112().method_157().vmethod_21(float_3);
													}
												}
												else if (this.activeUnit_0.vmethod_85().method_46())
												{
													if (!this.activeUnit_0.vmethod_85().method_37(ref class6.list_5, ref class6.list_16, ref class6.list_11, 30f, false))
													{
														this.activeUnit_0.vmethod_85().vmethod_22(class6.list_5);
													}
													this.activeUnit_0.vmethod_85().vmethod_16(float_3);
												}
												else
												{
													this.activeUnit_0.vmethod_85().vmethod_22(class6.list_5);
												}
												if (!this.activeUnit_0.vmethod_87().vmethod_12() && this.activeUnit_0.vmethod_85().method_40(ref class6.list_5, ref class6.list_13, ref class6.list_8, 2, false, false))
												{
													base.method_50();
												}
											}
											else if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.MineClearing)
											{
												Aircraft_AI.Class248 class7 = new Aircraft_AI.Class248(class7);
												class7.aircraft_AI_0 = this;
												Class341 class8 = (Class341)this.activeUnit_0.vmethod_101();
												class7.observableDictionary_0 = this.activeUnit_0.scenario_0.vmethod_20();
												class7.list_0 = class8.list_5;
												class7.concurrentBag_0 = new ConcurrentBag<UnguidedWeapon>();
												if (this.method_112().method_117())
												{
													Parallel.ForEach<string>(this.activeUnit_0.vmethod_7(false).hashSet_0, new Action<string>(class7.method_0));
												}
												if (class7.concurrentBag_0.Count > 0)
												{
													UnguidedWeapon unguidedWeapon = Enumerable.ElementAtOrDefault<UnguidedWeapon>(Enumerable.OrderBy<UnguidedWeapon, double>(Enumerable.Where<UnguidedWeapon>(Enumerable.ToList<UnguidedWeapon>(class7.concurrentBag_0), (Aircraft_AI._Closure$__.$I45-1 == null) ? (Aircraft_AI._Closure$__.$I45-1 = new Func<UnguidedWeapon, bool>(Aircraft_AI._Closure$__.$I.method_18)) : Aircraft_AI._Closure$__.$I45-1), new Func<UnguidedWeapon, double>(this.method_165)), 0);
													float float_4 = this.activeUnit_0.method_36(unguidedWeapon);
													base.method_76(unguidedWeapon, float_4);
													this.activeUnit_0.vmethod_85().vmethod_16(float_3);
												}
												else if (this.activeUnit_0.method_120())
												{
													if (this.activeUnit_0.method_122())
													{
														if (this.activeUnit_0.vmethod_85().method_46())
														{
															if (!this.activeUnit_0.vmethod_65(false).vmethod_85().method_37(ref class8.list_5, ref class8.list_14, ref class8.list_10, 30f, false))
															{
																this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_22(class8.list_5);
															}
															this.activeUnit_0.vmethod_85().vmethod_16(float_3);
														}
														else
														{
															this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_22(class8.list_5);
														}
													}
													else if (this.activeUnit_0.vmethod_90().vmethod_1())
													{
														this.activeUnit_0.vmethod_85().vmethod_21(float_3);
													}
												}
												else if (this.activeUnit_0.vmethod_85().method_46())
												{
													if (!this.activeUnit_0.vmethod_85().method_37(ref class8.list_5, ref class8.list_14, ref class8.list_10, 30f, false))
													{
														this.activeUnit_0.vmethod_85().vmethod_22(class8.list_5);
													}
													this.activeUnit_0.vmethod_85().vmethod_16(float_3);
												}
												else
												{
													this.activeUnit_0.vmethod_85().vmethod_22(class8.list_5);
												}
											}
											else
											{
												if (Information.IsNothing(this.vmethod_3()) && !this.activeUnit_0.vmethod_86().bool_2 && !this.activeUnit_0.method_121() && this.activeUnit_0.vmethod_87().vmethod_10() == null)
												{
													this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
												}
												if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
												{
													Strike.StrikeType strikeType_ = ((Strike)this.activeUnit_0.vmethod_101()).strikeType_0;
													if (strikeType_ != Strike.StrikeType.Air_Intercept)
													{
														if (strikeType_ - Strike.StrikeType.Land_Strike <= 2)
														{
															if (this.vmethod_3() == null && !this.activeUnit_0.method_121())
															{
																bool flag = false;
																if (!this.method_133(ref flag))
																{
																	if (!this.activeUnit_0.vmethod_87().vmethod_12())
																	{
																		ActiveUnit activeUnit_3 = this.activeUnit_0;
																		Aircraft aircraft = this.method_112();
																		ActiveUnit.Throttle throttle_4 = ActiveUnit.Throttle.Loiter;
																		ActiveUnit activeUnit;
																		ActiveUnit activeUnit2;
																		flag = (activeUnit2 = this.activeUnit_0).vmethod_76(activeUnit = this.activeUnit_0);
																		float float_5 = Aircraft_AI.smethod_2(ref aircraft, throttle_4, ref flag);
																		activeUnit2.vmethod_77(activeUnit, flag);
																		activeUnit_3.vmethod_73(float_5);
																	}
																	this.activeUnit_0.vmethod_87().vmethod_27(float_3, false, false);
																}
															}
															else if (this.activeUnit_0.method_120())
															{
																if (this.activeUnit_0.method_122())
																{
																	this.vmethod_19(float_3);
																}
																else
																{
																	this.method_112().method_157().vmethod_21(float_3);
																}
															}
															else
															{
																this.vmethod_19(float_3);
															}
														}
													}
													else if (!Information.IsNothing(this.vmethod_3()))
													{
														this.vmethod_19(float_3);
													}
													else
													{
														if (!this.activeUnit_0.vmethod_87().vmethod_12())
														{
															ActiveUnit activeUnit_4 = this.activeUnit_0;
															Aircraft aircraft2 = this.method_112();
															ActiveUnit.Throttle throttle_5 = ActiveUnit.Throttle.Loiter;
															Aircraft aircraft;
															ActiveUnit activeUnit2;
															bool flag = (aircraft = this.method_112()).vmethod_76(activeUnit2 = this.method_112());
															float float_6 = Aircraft_AI.smethod_2(ref aircraft2, throttle_5, ref flag);
															aircraft.vmethod_77(activeUnit2, flag);
															activeUnit_4.vmethod_73(float_6);
														}
														this.activeUnit_0.vmethod_87().vmethod_27(float_3, false, false);
													}
												}
												else if (this.activeUnit_0.method_121())
												{
													this.method_112().method_157().vmethod_21(float_3);
												}
											}
										}
										break;
									case ActiveUnit._ActiveUnitStatus.FormingUp:
										if (this.activeUnit_0.method_122())
										{
											if (this.activeUnit_0.vmethod_85().method_47())
											{
												this.activeUnit_0.vmethod_85().vmethod_16(float_3);
											}
											else
											{
												this.method_112().method_159().vmethod_27(float_3, false, false);
											}
										}
										else if (this.activeUnit_0.method_120())
										{
											if (this.activeUnit_0.vmethod_65(false).method_143() == Group.GroupType.AirGroup)
											{
												this.method_112().method_157().vmethod_21(float_3);
											}
											else
											{
												this.method_112().method_159().vmethod_27(float_3, false, false);
											}
										}
										else
										{
											this.method_112().method_159().vmethod_27(float_3, true, false);
										}
										break;
									case ActiveUnit._ActiveUnitStatus.OnSupportMission:
										if (!Information.IsNothing(this.activeUnit_0.vmethod_101()))
										{
											if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support)
											{
												if (this.activeUnit_0.method_120())
												{
													if (this.activeUnit_0.method_122())
													{
														this.activeUnit_0.vmethod_85().vmethod_14(float_3, this.activeUnit_0.vmethod_85().method_15());
													}
													else
													{
														this.method_112().method_157().vmethod_21(float_3);
													}
												}
												else
												{
													this.activeUnit_0.vmethod_85().vmethod_14(float_3, this.activeUnit_0.vmethod_85().method_15());
													if (this.method_112().method_146())
													{
														this.method_139();
													}
												}
											}
										}
										break;
									case ActiveUnit._ActiveUnitStatus.OnFerryMission:
										if (!Information.IsNothing(this.activeUnit_0.vmethod_101()))
										{
											if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Ferry)
											{
												FerryMission ferryMission2 = (FerryMission)this.activeUnit_0.vmethod_101();
												ActiveUnit.Throttle throttle;
												if (this.activeUnit_0.vmethod_87().vmethod_10() == null)
												{
													if (!Information.IsNothing(this.method_112().method_167()))
													{
														if (!Information.IsNothing(ferryMission2.nullable_4))
														{
															throttle = ferryMission2.nullable_4.Value;
														}
														else
														{
															throttle = ActiveUnit.Throttle.Cruise;
														}
													}
													else
													{
														throttle = ActiveUnit.Throttle.Cruise;
													}
												}
												else
												{
													throttle = this.activeUnit_0.vmethod_84();
												}
												float num5;
												if (!this.activeUnit_0.vmethod_87().vmethod_12())
												{
													if (this.method_112().method_167() != null)
													{
														if (ferryMission2.nullable_5 != null)
														{
															num5 = ferryMission2.nullable_5.Value;
														}
														else
														{
															Aircraft aircraft = this.method_112();
															ActiveUnit.Throttle throttle_6 = throttle;
															ActiveUnit activeUnit;
															Aircraft aircraft2;
															bool flag = (aircraft2 = this.method_112()).vmethod_76(activeUnit = this.method_112());
															float num6 = Aircraft_AI.smethod_2(ref aircraft, throttle_6, ref flag);
															aircraft2.vmethod_77(activeUnit, flag);
															num5 = num6;
														}
													}
													else
													{
														Aircraft aircraft2 = this.method_112();
														ActiveUnit.Throttle throttle_7 = throttle;
														Aircraft aircraft;
														ActiveUnit activeUnit;
														bool flag = (aircraft = this.method_112()).vmethod_76(activeUnit = this.method_112());
														float num7 = Aircraft_AI.smethod_2(ref aircraft2, throttle_7, ref flag);
														aircraft.vmethod_77(activeUnit, flag);
														num5 = num7;
													}
												}
												else
												{
													num5 = this.activeUnit_0.vmethod_72();
												}
												if (!this.activeUnit_0.method_121())
												{
													if (aircraft_AirOps.method_21() != null)
													{
														Class211 class9 = this.method_112().method_157();
														ActiveUnit activeUnit_5 = aircraft_AirOps.method_21();
														float float_7 = (float)this.activeUnit_0.vmethod_87().vmethod_40(this.method_112().vmethod_14(false), throttle, false);
														float float_8 = num5;
														bool flag = false;
														class9.method_78(float_3, activeUnit_5, float_7, float_8, ref flag);
													}
													else
													{
														string str2 = "";
														if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
														{
															str2 = " (" + this.activeUnit_0.string_2 + ")";
														}
														this.activeUnit_0.scenario_0.method_59("Aircraft " + this.activeUnit_0.Name + str2 + " is assigned to a ferry mission but it cannot land at the desired destination. Unassigning aircraft and returning to nearest base.", this.activeUnit_0.Name + " cannot do ferry mission; aborting", LoggedMessage.MessageType.AirOps, 0, null, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
														ActiveUnit activeUnit_6 = this.activeUnit_0;
														Mission value = null;
														bool setMissionOnly = false;
														Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
														activeUnit_6.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
														this.activeUnit_0.vmethod_92().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
													}
												}
												else
												{
													this.method_112().method_157().vmethod_21(float_3);
												}
												if (this.method_112().method_146())
												{
													this.method_139();
												}
											}
										}
										break;
									case ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint:
									{
										if (this.method_112().method_121() && this.method_112().vmethod_65(false).method_143() == Group.GroupType.AirGroup && this.method_112().vmethod_65(false).method_147() != null)
										{
											ActiveUnit activeUnit3 = this.method_112().vmethod_65(false).method_147();
											if (activeUnit3.vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || activeUnit3.vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling)
											{
												base.method_23(float_3, ref aircraft_AirOps);
												break;
											}
										}
										bool flag4 = true;
										if (this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse || aircraft_AirOps.method_24() == null)
										{
											GeoPoint geoPoint = base.method_18();
											Aircraft_AirOps aircraft_AirOps4 = aircraft_AirOps;
											bool flag = false;
											ActiveUnit activeUnit2 = null;
											bool bool_3 = true;
											List<Mission> list_ = null;
											string text3 = "";
											List<Aircraft> list2 = aircraft_AirOps4.method_78(ref flag, ref activeUnit2, bool_3, list_, ref text3);
											if (aircraft_AirOps.method_24() != null && list2.Contains(aircraft_AirOps.method_24()))
											{
												Aircraft_AirOps aircraft_AirOps5 = aircraft_AirOps;
												Aircraft aircraft_ = aircraft_AirOps.method_24();
												flag = false;
												if (aircraft_AirOps5.method_79(aircraft_, ref flag, true, false))
												{
													flag4 = true;
												}
												else
												{
													Aircraft_AirOps aircraft_AirOps6 = aircraft_AirOps;
													GeoPoint geoPoint_3 = geoPoint;
													Doctrine.Enum57 value2 = this.activeUnit_0.doctrine_0.method_157(this.activeUnit_0.scenario_0, false, false, false, false).Value;
													flag = false;
													bool bool_4 = false;
													activeUnit2 = null;
													List<Mission> list = null;
													text3 = "";
													bool flag3 = false;
													bool flag2 = false;
													flag4 = aircraft_AirOps6.method_80(geoPoint_3, value2, ref flag, bool_4, ref activeUnit2, ref list, ref text3, ref flag3, ref flag2);
												}
											}
											else if (list2.Count > 0)
											{
												Aircraft_AirOps aircraft_AirOps7 = aircraft_AirOps;
												GeoPoint geoPoint_4 = geoPoint;
												Doctrine.Enum57 value3 = this.activeUnit_0.doctrine_0.method_157(this.activeUnit_0.scenario_0, false, false, false, false).Value;
												bool flag2 = false;
												bool bool_5 = false;
												activeUnit2 = null;
												List<Mission> list = null;
												text3 = "";
												bool flag3 = false;
												flag = false;
												flag4 = aircraft_AirOps7.method_80(geoPoint_4, value3, ref flag2, bool_5, ref activeUnit2, ref list, ref text3, ref flag3, ref flag);
											}
											else
											{
												if (!Information.IsNothing(aircraft_AirOps.method_24()))
												{
													aircraft_AirOps.method_45();
												}
												flag4 = false;
											}
										}
										if (aircraft_AirOps.method_24() != null && flag4)
										{
											Aircraft aircraft3 = aircraft_AirOps.method_24();
											float num8 = this.method_112().method_36(aircraft3);
											if (aircraft3.method_162().vmethod_1())
											{
												this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.method_32(aircraft3));
											}
											else
											{
												this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.method_34(aircraft3.method_56().Value, aircraft3.method_58().Value));
											}
											if ((double)num8 < 0.1)
											{
												this.method_112().vmethod_71(aircraft3.vmethod_40());
												this.method_112().vmethod_73(aircraft3.vmethod_14(false));
												this.method_112().vmethod_134(this.method_112().method_159().vmethod_41(aircraft3.vmethod_14(false), (float)((int)Math.Round((double)this.method_112().vmethod_70()))), null);
											}
											else
											{
												this.method_112().vmethod_71((float)this.method_112().method_159().vmethod_40(this.method_112().vmethod_14(false), ActiveUnit.Throttle.Cruise, false));
												this.method_112().vmethod_134(ActiveUnit.Throttle.Cruise, null);
												if (num8 > 10f)
												{
													if (!this.activeUnit_0.vmethod_87().vmethod_12())
													{
														if (this.method_112().vmethod_76(this.method_112()))
														{
															Aircraft aircraft4 = this.method_112();
															Class211 class10 = this.method_112().method_157();
															bool flag = false;
															aircraft4.vmethod_75(class10.method_73(ref flag));
														}
														else
														{
															Aircraft aircraft5 = this.method_112();
															Class211 class11 = this.method_112().method_157();
															bool flag = false;
															aircraft5.vmethod_73(class11.method_73(ref flag));
														}
													}
												}
												else
												{
													this.method_112().vmethod_73(aircraft3.vmethod_14(false));
													this.method_112().vmethod_77(this.method_112(), false);
												}
											}
										}
										else
										{
											if (this.method_112().vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || this.method_112().vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling)
											{
												this.method_112().vmethod_109(this.method_112()._ActiveUnitStatus_2);
											}
											if (aircraft_AirOps.method_36() == Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel || aircraft_AirOps.method_36() == Aircraft_AirOps._AirOpsCondition.Refuelling)
											{
												aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
											}
										}
										break;
									}
									case ActiveUnit._ActiveUnitStatus.Refuelling:
										if (!this.activeUnit_0.vmethod_86().bool_2)
										{
											if (!this.activeUnit_0.method_121() && this.activeUnit_0.vmethod_101() != null)
											{
												if (this.activeUnit_0.vmethod_85().nullable_0 != null)
												{
													if (this.activeUnit_0.vmethod_85().nullable_0.GetValueOrDefault() && this.activeUnit_0.vmethod_85().method_47())
													{
														this.activeUnit_0.vmethod_85().vmethod_16(float_3);
													}
												}
												else if (this.activeUnit_0.vmethod_101().bool_18 && this.activeUnit_0.vmethod_85().method_47())
												{
													this.activeUnit_0.vmethod_85().vmethod_16(float_3);
												}
											}
										}
										else if (this.activeUnit_0.vmethod_101() != null)
										{
											if (this.activeUnit_0.vmethod_85().nullable_0 != null)
											{
												if (this.activeUnit_0.vmethod_85().nullable_0.GetValueOrDefault() && this.activeUnit_0.vmethod_101().bool_18)
												{
													bool flag = true;
													this.method_133(ref flag);
												}
											}
											else if (this.activeUnit_0.vmethod_101().bool_18)
											{
												bool flag = true;
												this.method_133(ref flag);
											}
										}
										break;
									}
								}
							}
							else
							{
								this.activeUnit_0.vmethod_87().vmethod_11(null);
								this.method_112().vmethod_134(ActiveUnit.Throttle.FullStop, null);
								this.method_112().vmethod_69(ActiveUnit.Enum28.const_0, this.method_112().vmethod_9());
								this.method_112().vmethod_73(0f);
								this.method_112().vmethod_75(0f);
								if (!this.method_112().method_15())
								{
									aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
									aircraft_AirOps.method_39(0f);
								}
								else if (this.activeUnit_0.vmethod_13() > 45.72f | this.activeUnit_0.vmethod_40() > 10f)
								{
									aircraft_AirOps.method_39(120f);
								}
							}
						}
						else
						{
							this.activeUnit_0.vmethod_87().vmethod_11(null);
							this.method_112().vmethod_134(ActiveUnit.Throttle.FullStop, null);
							this.method_112().vmethod_69(ActiveUnit.Enum28.const_0, this.method_112().vmethod_9());
							this.method_112().vmethod_73(45.72f);
							if (!this.method_112().method_15() && !Class442.smethod_1(this.method_112().vmethod_28(null), this.method_112().vmethod_30(null)))
							{
								if (this.activeUnit_0.vmethod_14(false) > 45.72f)
								{
									aircraft_AirOps.method_39(240f);
								}
							}
							else
							{
								aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
								aircraft_AirOps.method_39(0f);
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100392", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x000EBF54 File Offset: 0x000EA154
		private bool method_133(ref bool bool_11)
		{
			bool result;
			try
			{
				List<Aircraft> list = new List<Aircraft>();
				List<ActiveUnit> list2 = Enumerable.ToList<ActiveUnit>(this.activeUnit_0.vmethod_7(false).activeUnit_0);
				try
				{
					foreach (ActiveUnit activeUnit in list2)
					{
						if (activeUnit.bool_3 && activeUnit.vmethod_127() && activeUnit != this.method_112() && activeUnit.vmethod_101() == this.method_112().vmethod_101() && !activeUnit.vmethod_86().bool_2)
						{
							list.Add((Aircraft)activeUnit);
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (list.Count != 0)
				{
					GeoPoint geoPoint = new GeoPoint();
					int num = 0;
					float num2 = 0f;
					int count = list.Count;
					if (count == 1)
					{
						geoPoint.imethod_1(list[0].vmethod_28(null));
						geoPoint.imethod_3(list[0].vmethod_30(null));
					}
					else
					{
						geoPoint.imethod_1(Enumerable.Sum(Enumerable.Select<Aircraft, double>(list, (Aircraft_AI._Closure$__.$I46-0 == null) ? (Aircraft_AI._Closure$__.$I46-0 = new Func<Aircraft, double>(Aircraft_AI._Closure$__.$I.method_19)) : Aircraft_AI._Closure$__.$I46-0)) / (double)list.Count);
						geoPoint.imethod_3(Enumerable.Sum(Enumerable.Select<Aircraft, double>(list, (Aircraft_AI._Closure$__.$I46-1 == null) ? (Aircraft_AI._Closure$__.$I46-1 = new Func<Aircraft, double>(Aircraft_AI._Closure$__.$I.method_20)) : Aircraft_AI._Closure$__.$I46-1)) / (double)list.Count);
					}
					this.method_112().vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_17(this.method_112().vmethod_30(null), this.method_112().vmethod_28(null), geoPoint.imethod_2(), geoPoint.imethod_0()));
					if (!bool_11)
					{
						try
						{
							foreach (Aircraft aircraft in list)
							{
								num = (int)Math.Round((double)((float)num + aircraft.vmethod_40()));
								num2 += aircraft.vmethod_14(false);
							}
						}
						finally
						{
							List<Aircraft>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						if (this.method_112().method_159().vmethod_10() == null)
						{
							float num3 = (float)((double)num / (double)list.Count);
							this.method_112().vmethod_134(this.method_112().method_159().vmethod_41(this.method_112().vmethod_14(false), (float)((int)Math.Round((double)num3))), null);
							this.method_112().vmethod_71(num3);
						}
						if (!this.activeUnit_0.vmethod_87().vmethod_12())
						{
							float num4 = 0f;
							float num5 = 9999999f;
							try
							{
								foreach (Mount mount in this.activeUnit_0.vmethod_51())
								{
									if (mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
									{
										try
										{
											foreach (WeaponRec weaponRec in mount.vmethod_10())
											{
												WeaponRec weaponRec2;
												Weapon weapon = (weaponRec2 = weaponRec).method_12(this.activeUnit_0.scenario_0);
												if (!weapon.method_176() && !weapon.method_214() && !weapon.method_215() && weaponRec2.method_9() != 0)
												{
													if (weapon.method_191())
													{
														Doctrine.Enum65? @enum = this.activeUnit_0.doctrine_0.method_31(this.activeUnit_0.scenario_0, false, false, false);
														byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
														bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
														if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
														{
															continue;
														}
													}
													if (weapon.float_39 != 0f && weapon.float_39 > num4)
													{
														num4 = weapon.float_39;
													}
													if (weapon.float_40 != 0f && weapon.float_40 < num5)
													{
														num5 = weapon.float_40;
													}
												}
											}
										}
										finally
										{
											List<WeaponRec>.Enumerator enumerator4;
											((IDisposable)enumerator4).Dispose();
										}
									}
								}
							}
							finally
							{
								List<Mount>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
							float num6;
							checked
							{
								if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
								{
									WeaponRec[] weaponRec_ = ((Aircraft)this.activeUnit_0).method_167().weaponRec_0;
									for (int i = 0; i < weaponRec_.Length; i++)
									{
										WeaponRec weaponRec3;
										Weapon weapon2 = (weaponRec3 = weaponRec_[i]).method_12(this.activeUnit_0.scenario_0);
										if (!weapon2.method_176() && !weapon2.method_214() && !weapon2.method_215() && weaponRec3.method_9() != 0)
										{
											if (weapon2.method_191())
											{
												Doctrine.Enum65? @enum = this.activeUnit_0.doctrine_0.method_31(this.activeUnit_0.scenario_0, false, false, false);
												byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
												bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
												if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
												{
													goto IL_5C8;
												}
											}
											if (weapon2.float_39 != 0f && weapon2.float_39 > num4)
											{
												num4 = weapon2.float_39;
											}
											if (weapon2.float_40 != 0f && weapon2.float_40 < num5)
											{
												num5 = weapon2.float_40;
											}
										}
										IL_5C8:;
									}
								}
								num6 = num2 / (float)list.Count;
							}
							if (num4 > num5)
							{
								if (num6 < num4)
								{
									num6 = num4;
									float num7 = (float)Math.Max(0, this.activeUnit_0.method_9(false, false, false));
									if (num7 > 0f)
									{
										num6 += num7;
									}
								}
							}
							else
							{
								if (num6 < num4)
								{
									num6 = num4;
									float num8 = (float)Math.Max(0, this.activeUnit_0.method_9(false, false, false));
									if (num8 > 0f)
									{
										num6 += num8;
									}
								}
								if (num6 < num4)
								{
									num6 = num4;
								}
							}
							this.activeUnit_0.vmethod_73(num6);
						}
					}
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100392", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x000EC688 File Offset: 0x000EA888
		private void method_134(float float_3)
		{
			try
			{
				if (this.method_112().method_157().method_46() && Information.IsNothing(this.method_112().method_157().method_4()[0].nullable_7))
				{
					float? nullable_ = this.nullable_0;
					if (((nullable_ != null) ? new bool?(nullable_.GetValueOrDefault() > 0f) : null).GetValueOrDefault())
					{
						this.nullable_2 = null;
						this.nullable_3 = null;
						this.nullable_4 = null;
						this.nullable_5 = null;
					}
				}
				else
				{
					if (!Information.IsNothing(this.nullable_0))
					{
						this.nullable_0 -= (float)((short)Math.Round((double)float_3));
						float? nullable_ = this.nullable_0;
						if (((nullable_ != null) ? new bool?(nullable_.GetValueOrDefault() < 0f) : null).GetValueOrDefault() || this.activeUnit_0.method_86() || this.activeUnit_0.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IsBingo)
						{
							this.nullable_0 = null;
							if (this.bool_7)
							{
								if (this.method_112().method_157().method_49())
								{
									this.activeUnit_0.vmethod_71(this.nullable_2.Value);
									this.activeUnit_0.vmethod_87().vmethod_11(this.nullable_3);
									this.activeUnit_0.vmethod_134(this.nullable_4.Value, null);
									this.activeUnit_0.vmethod_87().vmethod_2(this.nullable_5.Value);
								}
								this.nullable_2 = null;
								this.nullable_3 = null;
								this.nullable_4 = null;
								this.nullable_5 = null;
								this.bool_7 = false;
							}
						}
					}
					if (!this.activeUnit_0.method_86())
					{
						if (this.activeUnit_0.vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsBingo)
						{
							if (Information.IsNothing(this.nullable_0))
							{
								if (this.method_112().vmethod_14(false) != this.method_112().vmethod_72())
								{
									this.nullable_0 = new float?(60f);
								}
								else if (this.method_112().vmethod_40() > 0f && this.method_112().method_157().method_49() && this.method_112().method_157().method_46() && !Information.IsNothing(this.method_112().method_157().method_4()[0].nullable_7) && this.method_112().method_157().method_4()[0].enum84_0 > Waypoint.Enum84.const_0)
								{
									Waypoint waypoint = this.method_112().method_157().method_4()[0];
									if (waypoint.enum84_0 != Waypoint.Enum84.const_0)
									{
										bool? flag;
										bool? flag3;
										if (waypoint.waypointType_0 != Waypoint.WaypointType.StationEnd)
										{
											Waypoint.WaypointType? nullable_2 = this.activeUnit_0.vmethod_85().nullable_5;
											int? num = (nullable_2 != null) ? new int?((int)nullable_2.GetValueOrDefault()) : null;
											bool? flag2;
											flag = (flag2 = ((num != null) ? new bool?(num.GetValueOrDefault() == 24) : null));
											flag3 = ((flag2 == null || flag.GetValueOrDefault()) ? (flag & waypoint.method_40()) : new bool?(false));
										}
										else
										{
											flag3 = new bool?(true);
										}
										flag = flag3;
										if (!flag.GetValueOrDefault())
										{
											float float_4 = Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), waypoint.imethod_2(), waypoint.imethod_0());
											if (Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_9(), float_4)) < 5f)
											{
												float num2 = this.activeUnit_0.vmethod_70();
												float num3 = Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), waypoint.imethod_2(), waypoint.imethod_0()) / num2 * 3600f;
												DateTime? nullable_3 = waypoint.nullable_7;
												DateTime? dateTime = new DateTime?(this.activeUnit_0.scenario_0.method_31().AddSeconds((double)num3));
												double totalSeconds = (nullable_3.Value - dateTime.Value).TotalSeconds;
												if (Math.Abs(totalSeconds) > 5.0)
												{
													if (totalSeconds < 0.0 && this.bool_8)
													{
														this.nullable_0 = new float?(60f);
													}
													else if (totalSeconds < 0.0 && waypoint.enum84_0 == Waypoint.Enum84.const_1)
													{
														this.nullable_0 = new float?(60f);
													}
													else
													{
														bool flag4;
														ActiveUnit.Throttle throttle;
														if (totalSeconds < 0.0)
														{
															switch (this.activeUnit_0.vmethod_84())
															{
															case ActiveUnit.Throttle.FullStop:
																flag4 = true;
																break;
															case ActiveUnit.Throttle.Loiter:
																throttle = ActiveUnit.Throttle.Cruise;
																break;
															case ActiveUnit.Throttle.Cruise:
																throttle = ActiveUnit.Throttle.Full;
																break;
															case ActiveUnit.Throttle.Full:
																if (waypoint.enum84_0 == Waypoint.Enum84.const_3)
																{
																	throttle = ActiveUnit.Throttle.Flank;
																}
																else if (this.activeUnit_0.vmethod_70() < (float)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), this.activeUnit_0.vmethod_84(), false))
																{
																	throttle = ActiveUnit.Throttle.Full;
																}
																else
																{
																	flag4 = true;
																}
																break;
															case ActiveUnit.Throttle.Flank:
																if (this.activeUnit_0.vmethod_70() < (float)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), this.activeUnit_0.vmethod_84(), false))
																{
																	throttle = ActiveUnit.Throttle.Flank;
																}
																else
																{
																	flag4 = true;
																}
																break;
															}
														}
														else
														{
															if (waypoint.float_24 > 0f)
															{
																this.nullable_0 = new float?(60f);
																return;
															}
															switch (this.activeUnit_0.vmethod_84())
															{
															case ActiveUnit.Throttle.FullStop:
															case ActiveUnit.Throttle.Loiter:
																flag4 = true;
																break;
															case ActiveUnit.Throttle.Cruise:
																throttle = ActiveUnit.Throttle.Loiter;
																break;
															case ActiveUnit.Throttle.Full:
																throttle = ActiveUnit.Throttle.Cruise;
																break;
															case ActiveUnit.Throttle.Flank:
																throttle = ActiveUnit.Throttle.Full;
																break;
															}
														}
														if (flag4)
														{
															this.nullable_0 = new float?(60f);
														}
														else
														{
															float num4 = (float)this.method_112().method_159().vmethod_40(this.activeUnit_0.vmethod_72(), throttle, false) - this.activeUnit_0.vmethod_70();
															float value = (float)((double)this.activeUnit_0.vmethod_70() * totalSeconds / 3600.0) / num4 * 3600f;
															this.nullable_2 = new float?(this.activeUnit_0.vmethod_70());
															this.nullable_3 = this.activeUnit_0.vmethod_87().vmethod_10();
															this.nullable_4 = new ActiveUnit.Throttle?(this.activeUnit_0.vmethod_84());
															this.nullable_5 = new ActiveUnit_Kinematics.UnitThrottlePreset?(this.activeUnit_0.vmethod_87().vmethod_1());
															this.activeUnit_0.vmethod_87().vmethod_11(null);
															this.activeUnit_0.vmethod_87().vmethod_2((ActiveUnit_Kinematics.UnitThrottlePreset)throttle);
															this.activeUnit_0.vmethod_134(throttle, null);
															this.bool_7 = true;
															if (Math.Abs(value) > 75f)
															{
																this.nullable_0 = new float?(60f);
															}
															else
															{
																this.nullable_0 = new float?(Math.Max(Math.Abs(value) - 5f, 5f));
															}
														}
													}
												}
												else
												{
													this.nullable_0 = new float?(60f);
												}
											}
											else
											{
												this.nullable_0 = new float?(30f);
											}
										}
									}
								}
								else
								{
									this.nullable_0 = new float?(60f);
								}
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

		// Token: 0x06000BED RID: 3053 RVA: 0x000ECEFC File Offset: 0x000EB0FC
		public static float smethod_2(ref Aircraft aircraft_1, ActiveUnit.Throttle throttle_0, ref bool bool_11)
		{
			float result;
			try
			{
				float num = aircraft_1.method_159().vmethod_30();
				bool_11 = false;
				if (aircraft_1.vmethod_49()[0].altBand_0.Length >= 4)
				{
					if (num * 3.28084f > 60001f)
					{
						if (!Information.IsNothing(throttle_0))
						{
							result = aircraft_1.vmethod_49()[0].method_24(throttle_0).float_0;
						}
						else
						{
							result = num;
						}
					}
					else if (!Information.IsNothing(throttle_0))
					{
						result = aircraft_1.vmethod_49()[0].method_24(throttle_0).float_1;
					}
					else
					{
						result = 10972.8f;
					}
				}
				else if (aircraft_1.vmethod_49()[0].altBand_0.Length != 1 && !aircraft_1.method_169())
				{
					if (!Information.IsNothing(throttle_0))
					{
						result = aircraft_1.vmethod_49()[0].method_24(throttle_0).float_0;
					}
					else
					{
						result = num;
					}
				}
				else if (num >= 609.60004f)
				{
					result = 609.60004f;
				}
				else
				{
					result = num;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101362", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x000ED054 File Offset: 0x000EB254
		public float method_135(ref Aircraft aircraft_1, ActiveUnit.Throttle throttle_0, bool bool_11, ref bool bool_12)
		{
			float num = 0f;
			float result;
			try
			{
				if (!Information.IsNothing(aircraft_1.method_167()))
				{
					Class237 @class = aircraft_1.method_167().method_15(this.activeUnit_0.scenario_0);
					num = @class.float_5;
					bool_12 = @class.bool_7;
					if (num > 0f)
					{
						return num;
					}
					num = @class.float_3;
					bool_12 = @class.bool_4;
					if (num > 0f)
					{
						return num;
					}
					num = @class.float_1;
					bool_12 = @class.bool_0;
					if (num > 0f)
					{
						return num;
					}
				}
				if (!bool_11)
				{
					if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && ((Strike)this.activeUnit_0.vmethod_101()).strikeType_0 == Strike.StrikeType.Sub_Strike)
					{
						num = 304.80002f;
						bool_12 = false;
					}
					else
					{
						num = Aircraft_AI.smethod_2(ref aircraft_1, throttle_0, ref bool_12);
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x000ED16C File Offset: 0x000EB36C
		private bool method_136()
		{
			checked
			{
				bool result;
				try
				{
					if (Information.IsNothing(this.activeUnit_0))
					{
						result = false;
					}
					else if (this.method_112().method_164().method_36() == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
					{
						result = false;
					}
					else if (this.method_112().method_85())
					{
						result = false;
					}
					else
					{
						bool flag = false;
						bool flag2 = false;
						if (Information.IsNothing(this.vmethod_3()) || this.vmethod_3().method_136())
						{
							bool flag3 = false;
							CommDevice[] array = this.activeUnit_0.vmethod_94();
							int i = 0;
							while (i < array.Length)
							{
								CommDevice commDevice = array[i];
								if (!commDevice.method_26() || commDevice.method_24() >= commDevice.int_0)
								{
									i++;
								}
								else
								{
									flag3 = true;
									IL_AE:
									if (!flag3)
									{
										return false;
									}
									List<Weapon> list = this.method_112().method_161().vmethod_4();
									try
									{
										foreach (Weapon weapon in list)
										{
											if (weapon.method_167() == Weapon._WeaponType.Sonobuoy && this.method_112().method_161().method_5(weapon.DBID, false) > 0)
											{
												flag = true;
												break;
											}
										}
									}
									finally
									{
										List<Weapon>.Enumerator enumerator;
										((IDisposable)enumerator).Dispose();
									}
									if (flag)
									{
										if ((float)this.activeUnit_0.method_9(false, false, false) > -20f)
										{
											flag2 = false;
										}
										else if (Class442.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)))
										{
											flag2 = false;
										}
										else
										{
											Contact contact = this.vmethod_3();
											if (!Information.IsNothing(contact))
											{
												if (!Information.IsNothing(contact.method_112()))
												{
													ActiveUnit_Navigator activeUnit_Navigator = this.activeUnit_0.vmethod_85();
													Contact contact2;
													List<GeoPoint> list_ = (contact2 = contact).method_112();
													Contact contact3;
													List<GeoPoint> list_2 = (contact3 = contact).method_114();
													Contact contact4;
													List<GeoPoint> list_3 = (contact4 = contact).method_118();
													bool flag4 = activeUnit_Navigator.method_41(ref list_, ref list_2, ref list_3, 1f);
													contact4.method_119(list_3);
													contact3.method_115(list_2);
													contact2.method_113(list_);
													if (flag4)
													{
														flag2 = true;
													}
												}
												else if (!contact.method_121() && this.method_112().method_36(contact) < 2f)
												{
													flag2 = true;
												}
											}
											if (!flag2)
											{
												Mission mission = this.method_112().vmethod_101();
												if (!Information.IsNothing(mission))
												{
													Mission._MissionClass missionClass_ = mission._MissionClass_0;
													if (missionClass_ == Mission._MissionClass.Patrol)
													{
														Class343 @class = (Class343)mission;
														GlobalVariables.PatrolType patrolType_ = @class.patrolType_0;
														if (patrolType_ != GlobalVariables.PatrolType.ASW)
														{
															if (patrolType_ != GlobalVariables.PatrolType.SeaControl)
															{
																flag2 = false;
																goto IL_310;
															}
														}
														if (!Information.IsNothing(@class.list_5))
														{
															if (!Information.IsNothing(contact))
															{
																if (!Information.IsNothing(contact.method_112()))
																{
																	ActiveUnit_Navigator activeUnit_Navigator2 = this.activeUnit_0.vmethod_85();
																	Contact contact4;
																	List<GeoPoint> list_3 = (contact4 = contact).method_112();
																	Contact contact3;
																	List<GeoPoint> list_2 = (contact3 = contact).method_116();
																	Contact contact2;
																	List<GeoPoint> list_ = (contact2 = contact).method_118();
																	bool flag5 = activeUnit_Navigator2.method_41(ref list_3, ref list_2, ref list_, 5f);
																	contact2.method_119(list_);
																	contact3.method_117(list_2);
																	contact4.method_113(list_3);
																	if (flag5)
																	{
																		flag2 = true;
																	}
																}
															}
															else if (this.method_112().method_158().method_38())
															{
																flag2 = true;
															}
														}
													}
												}
											}
										}
									}
									IL_310:
									return flag2;
								}
							}
							goto IL_AE;
						}
						result = false;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100393", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x000ED4FC File Offset: 0x000EB6FC
		public override void vmethod_22(float float_3)
		{
			try
			{
				if (this.method_112().int_6 != 0 || this.method_112().method_162().vmethod_1() || this.method_112().method_85())
				{
					if (this.method_136())
					{
						Aircraft_AI.Class249 @class = new Aircraft_AI.Class249(@class);
						@class.aircraft_AI_0 = this;
						@class.bool_0 = true;
						List<Weapon> list = new List<Weapon>();
						list.AddRange(this.method_112().scenario_0.method_19());
						Parallel.ForEach<Weapon>(list, new Action<Weapon, ParallelLoopState>(@class.method_0));
						if (@class.bool_0)
						{
							Aircraft_Weaponry aircraft_Weaponry = this.method_112().method_161();
							bool isManual = false;
							string text = null;
							aircraft_Weaponry.method_73(float_3, isManual, ref text, null, null);
						}
					}
					bool flag = false;
					if (!Information.IsNothing(this.method_112().vmethod_101()) && this.method_112().vmethod_101()._MissionClass_0 == Mission._MissionClass.Support && !Information.IsNothing(this.method_112().method_167()) && this.method_112().method_167().loadoutRole_0 == Loadout.LoadoutRole.ChaffLaying && !this.method_112().method_157().method_15())
					{
						flag = true;
					}
					if ((this.method_112().method_161().bool_1 || flag) && this.method_112().method_161().method_42())
					{
						bool flag2 = false;
						try
						{
							foreach (ChaffCorridorCloud unit_ in this.activeUnit_0.scenario_0.ChaffClouds)
							{
								if ((double)this.activeUnit_0.method_36(unit_) <= 3.2397419999999997)
								{
									flag2 = true;
									break;
								}
							}
						}
						finally
						{
							List<ChaffCorridorCloud>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (!flag2)
						{
							this.method_112().method_161().method_40(float_3);
						}
					}
					base.vmethod_22(float_3);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100395", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x000ED72C File Offset: 0x000EB92C
		public override void vmethod_24(float float_3, ref Weapon weapon_0)
		{
			if (this.vmethod_3().activeUnit_0 == null)
			{
				ActiveUnit activeUnit_ = this.activeUnit_0;
				Aircraft aircraft = this.method_112();
				ActiveUnit.Throttle throttle_ = ActiveUnit.Throttle.Cruise;
				ActiveUnit activeUnit_2;
				ActiveUnit activeUnit_3;
				bool bool_ = (activeUnit_2 = this.activeUnit_0).vmethod_76(activeUnit_3 = this.activeUnit_0);
				float float_4 = Aircraft_AI.smethod_2(ref aircraft, throttle_, ref bool_);
				activeUnit_2.vmethod_77(activeUnit_3, bool_);
				activeUnit_.vmethod_73(float_4);
				return;
			}
			try
			{
				switch (this.vmethod_3().contactType_0)
				{
				case Contact_Base.ContactType.Air:
				case Contact_Base.ContactType.Missile:
				case Contact_Base.ContactType.Orbital:
				case Contact_Base.ContactType.Decoy_Air:
					if (this.vmethod_3().activeUnit_0.bool_3 && ((Aircraft)this.vmethod_3().activeUnit_0).method_144())
					{
						this.method_137(float_3, this.vmethod_3().contactType_0, weapon_0);
					}
					else
					{
						this.method_118(float_3);
					}
					break;
				case Contact_Base.ContactType.Surface:
				case Contact_Base.ContactType.UndeterminedNaval:
				case Contact_Base.ContactType.Aimpoint:
				case Contact_Base.ContactType.Facility_Fixed:
				case Contact_Base.ContactType.Facility_Mobile:
				case Contact_Base.ContactType.Mine:
				case Contact_Base.ContactType.Decoy_Surface:
				case Contact_Base.ContactType.Decoy_Land:
				case Contact_Base.ContactType.Sonobuoy:
				case Contact_Base.ContactType.Installation:
				case Contact_Base.ContactType.AirBase:
				case Contact_Base.ContactType.NavalBase:
				case Contact_Base.ContactType.MobileGroup:
				case Contact_Base.ContactType.ActivationPoint:
					this.method_137(float_3, this.vmethod_3().contactType_0, weapon_0);
					break;
				case Contact_Base.ContactType.Submarine:
				case Contact_Base.ContactType.Torpedo:
				case Contact_Base.ContactType.Decoy_Sub:
					this.method_137(float_3, this.vmethod_3().contactType_0, weapon_0);
					break;
				default:
					throw new NotImplementedException();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100397", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x000ED8B4 File Offset: 0x000EBAB4
		private void method_137(float float_3, Contact_Base.ContactType contactType_1, Weapon weapon_0)
		{
			if (Information.IsNothing(this.vmethod_3()))
			{
				ActiveUnit activeUnit_ = this.activeUnit_0;
				Aircraft aircraft = this.method_112();
				bool bool_;
				activeUnit_.vmethod_73(this.method_135(ref aircraft, ActiveUnit.Throttle.Cruise, false, ref bool_));
				if (!this.activeUnit_0.method_121())
				{
					this.activeUnit_0.vmethod_77(this.activeUnit_0, bool_);
					return;
				}
			}
			else
			{
				try
				{
					Aircraft_AI.Class250 @class = new Aircraft_AI.Class250();
					@class.aircraft_AI_0 = this;
					@class.doctrine_0 = this.activeUnit_0.doctrine_0;
					Weapon weapon = weapon_0;
					if (Information.IsNothing(weapon))
					{
						Side side = this.activeUnit_0.vmethod_7(false);
						Contact contact_ = this.vmethod_3();
						List<Weapon> list = side.method_74(ref this.activeUnit_0, ref contact_);
						this.vmethod_4(contact_);
						List<Weapon> list2 = list;
						if (list2.Count > 0)
						{
							weapon = Enumerable.ElementAtOrDefault<Weapon>(Enumerable.OrderByDescending<Weapon, float>(list2, new Func<Weapon, float>(@class.method_0)), 0);
						}
						else
						{
							weapon = this.activeUnit_0.vmethod_89().method_16(this.vmethod_3(), true, true, true, @class.doctrine_0);
						}
					}
					if (Information.IsNothing(weapon))
					{
						weapon = this.activeUnit_0.vmethod_89().method_16(this.vmethod_3(), false, false, true, @class.doctrine_0);
					}
					if (Information.IsNothing(weapon))
					{
						ActiveUnit activeUnit_2 = this.activeUnit_0;
						Aircraft aircraft = this.method_112();
						bool bool_2;
						activeUnit_2.vmethod_73(this.method_135(ref aircraft, ActiveUnit.Throttle.Cruise, false, ref bool_2));
						if (!this.activeUnit_0.method_121())
						{
							this.activeUnit_0.vmethod_77(this.activeUnit_0, bool_2);
						}
					}
					else
					{
						float num = weapon.method_181(this.activeUnit_0, this.vmethod_3(), true, @class.doctrine_0, false);
						float num2 = this.activeUnit_0.method_36(this.vmethod_3());
						float? num3 = null;
						bool flag = false;
						ActiveUnit.Throttle? throttle = null;
						float? num4 = null;
						Class343 class2;
						float num5;
						if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
						{
							class2 = (Class343)this.activeUnit_0.vmethod_101();
							num4 = class2.imethod_12();
							if (Information.IsNothing(num4))
							{
								num5 = (float)Math.Max((double)(10f + num), (double)num * 1.2);
							}
							else
							{
								num5 = (num4 + num).Value;
							}
						}
						else
						{
							num5 = (float)Math.Max((double)(10f + num), (double)num * 1.2);
						}
						Class211 class3;
						Aircraft_AirOps aircraft_AirOps;
						if (!this.activeUnit_0.method_94())
						{
							float val = (float)this.vmethod_3().method_9(true, false, false);
							float val2 = (float)this.activeUnit_0.method_9(true, false, false);
							float val3 = (float)this.activeUnit_0.method_10(true, float_3);
							float num6 = Math.Max(Math.Max(val2, val), val3);
							float num7 = this.activeUnit_0.vmethod_72();
							float num8 = this.activeUnit_0.vmethod_74();
							bool bool_3 = false;
							if ((!this.activeUnit_0.vmethod_87().vmethod_12() || this.activeUnit_0.vmethod_85().method_32()) && !Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
							{
								if (Information.IsNothing(class2))
								{
									class2 = (Class343)this.activeUnit_0.vmethod_101();
								}
								if (!Information.IsNothing(num4) && num2 > num5)
								{
									num3 = class2.imethod_6();
									flag = class2.imethod_14();
								}
								else
								{
									num3 = class2.imethod_10();
									flag = class2.imethod_18();
								}
							}
							float num9;
							float num10;
							bool flag2;
							float num11;
							if (!Information.IsNothing(num3))
							{
								num9 = num3.Value;
								num10 = num3.Value;
								if (flag2 = flag)
								{
									num11 = num9;
								}
								if (flag2)
								{
									num10 += num6;
								}
							}
							else
							{
								Aircraft aircraft = this.method_112();
								num9 = this.method_135(ref aircraft, ActiveUnit.Throttle.Cruise, true, ref flag2);
								num10 = num9;
								if (flag2)
								{
									num11 = num9;
								}
								if (flag2)
								{
									num10 += num6;
								}
							}
							float? num12 = null;
							Weapon._WeaponType weaponType = weapon.method_167();
							float num13;
							float num14;
							if (weaponType != Weapon._WeaponType.Rocket)
							{
								if (weaponType != Weapon._WeaponType.Gun)
								{
									if (weapon.float_40 > 0f && weapon.float_44 == 0f)
									{
										num13 = weapon.float_40 + num6;
										num14 = weapon.float_40;
										goto IL_526;
									}
									if (weapon.float_40 == 0f && weapon.float_44 > 0f)
									{
										num13 = weapon.float_44;
										num14 = weapon.float_44 - num6;
										goto IL_526;
									}
									if (weapon.float_40 > 0f && weapon.float_44 > 0f)
									{
										num13 = Math.Min(weapon.float_40 + num6, weapon.float_44);
										num14 = Math.Min(weapon.float_44 - num6, weapon.float_40);
										goto IL_526;
									}
									goto IL_526;
								}
							}
							if (this.activeUnit_0.method_37(this.vmethod_3(), 0f) > num)
							{
								num13 = (float)(Math.Sqrt(2.0) / 2.0 * (double)num * 1852.0 + (double)num6);
								num14 = (float)(Math.Sqrt(2.0) / 2.0 * (double)num * 1852.0);
							}
							IL_526:
							float num15;
							float num16;
							if (weapon.float_39 > 0f && weapon.float_43 == 0f)
							{
								num15 = weapon.float_39 + num6;
								num16 = weapon.float_39;
							}
							else if (weapon.float_39 == 0f && weapon.float_43 > 0f)
							{
								num15 = weapon.float_43;
								num16 = weapon.float_43 - num6;
							}
							else if (weapon.float_39 > 0f && weapon.float_43 > 0f)
							{
								num15 = Math.Max(weapon.float_39 + num6, weapon.float_43);
								num16 = Math.Max(weapon.float_43 - num6, weapon.float_39);
							}
							else if (weapon.float_39 == 0f && weapon.float_43 < 0f)
							{
								num15 = weapon.float_39 + num6;
								num16 = weapon.float_39;
							}
							bool flag3;
							if (!Information.IsNothing(num3))
							{
								flag3 = true;
							}
							else if (num10 > 0f)
							{
								if (!flag2 && num13 >= num10 && num15 <= num10)
								{
									flag3 = (this.activeUnit_0.vmethod_72() == num9 && this.activeUnit_0.vmethod_76(this.activeUnit_0) == flag2);
								}
								else
								{
									flag3 = (flag2 && num14 + num6 >= num10 && num16 + num6 <= num10 && (this.activeUnit_0.vmethod_74() == num11 && this.activeUnit_0.vmethod_76(this.activeUnit_0) == flag2));
								}
							}
							else
							{
								flag3 = false;
							}
							if (flag3)
							{
								num7 = num10;
								num8 = num11;
								bool_3 = flag2;
								if (!Information.IsNothing(weapon_0))
								{
									float num17 = num7;
									float? num18 = num6 + this.method_112().imethod_4();
									if (((num18 != null) ? new bool?(num17 < num18.GetValueOrDefault()) : null).GetValueOrDefault())
									{
										num7 += num6;
									}
									num17 = num8;
									num18 = num6 + this.method_112().imethod_4();
									if (((num18 != null) ? new bool?(num17 < num18.GetValueOrDefault()) : null).GetValueOrDefault())
									{
										num8 += num6;
									}
								}
								if (num10 <= 0f && num11 <= 0f)
								{
									if (num7 > num13)
									{
										num7 = num13;
									}
									if (num7 < num15)
									{
										num7 = num15;
									}
									if (num8 > num14)
									{
										num8 = num14;
									}
									if (num8 < num16)
									{
										num8 = num16;
									}
								}
								else
								{
									if (num15 > num7)
									{
										num7 = num15;
									}
									else if (num13 < num7)
									{
										num7 = num13;
									}
									else
									{
										if (num7 > num13)
										{
											num7 = num13;
										}
										if (num7 < num15)
										{
											num7 = num15;
										}
									}
									if (num16 > num8)
									{
										num8 = num16;
									}
									else if (num14 < num8)
									{
										num8 = num14;
									}
									else
									{
										if (num8 > num14)
										{
											num8 = num14;
										}
										if (num8 < num16)
										{
											num8 = num16;
										}
									}
								}
								if (weapon.method_149(this.vmethod_3().method_134()))
								{
									num12 = this.method_138(2.1474836E+09f);
								}
								if (!Information.IsNothing(num12))
								{
									if (((num12 != null) ? new bool?(num15 > num12.GetValueOrDefault()) : null).GetValueOrDefault())
									{
										if (this.activeUnit_0.scenario_0.ThirtiethSecondIsChangingOnThisPulse)
										{
											string str = "";
											if (Operators.CompareString(this.method_112().Name, this.method_112().string_2, false) != 0)
											{
												str = " (" + this.method_112().string_2 + ")";
											}
											this.method_112().method_124(this.method_112().Name + str + " cannot engage ground targets because the cloud cover is too low. There will not be enough altitude clearance to deploy weapon.", this.method_112().Name + " cannot engage target", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_112().vmethod_28(null), this.method_112().vmethod_30(null)));
										}
									}
									else if (((num12 != null) ? new bool?(num7 > num12.GetValueOrDefault()) : null).GetValueOrDefault())
									{
										num7 = num12.Value;
										num8 = (num12 - num6).Value;
										num13 = num7;
										num14 = num8;
									}
								}
								if (this.activeUnit_0.vmethod_87().vmethod_12())
								{
									if (this.activeUnit_0.vmethod_72() > num13)
									{
										this.activeUnit_0.vmethod_73(num13);
									}
									if (this.activeUnit_0.vmethod_72() < num15)
									{
										this.activeUnit_0.vmethod_73(num15);
									}
									if (this.activeUnit_0.vmethod_74() > num14)
									{
										this.activeUnit_0.vmethod_75(num14);
									}
									if (this.activeUnit_0.vmethod_74() < num16)
									{
										this.activeUnit_0.vmethod_75(num16);
									}
								}
								else if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && (this.method_112().method_157().method_32() || (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.method_122()) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_32())))
								{
									if (num7 != this.activeUnit_0.vmethod_14(false))
									{
										this.activeUnit_0.vmethod_73(num7);
										this.activeUnit_0.vmethod_75(num8);
									}
									else
									{
										this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false));
										this.activeUnit_0.vmethod_75(num8);
									}
								}
								else if (!Information.IsNothing(num3))
								{
									this.activeUnit_0.vmethod_73(num7);
									this.activeUnit_0.vmethod_75(num8);
									this.activeUnit_0.vmethod_77(this.activeUnit_0, bool_3);
								}
								else
								{
									float num19 = Math.Abs(this.activeUnit_0.vmethod_87().vmethod_48(this.activeUnit_0, num7, 0f));
									if (num2 <= num5 + num19)
									{
										if (num7 != this.activeUnit_0.vmethod_14(false))
										{
											this.activeUnit_0.vmethod_73(num7);
											this.activeUnit_0.vmethod_75(num8);
										}
										else
										{
											this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false));
											this.activeUnit_0.vmethod_75(num8);
										}
									}
									else if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
									{
										ActiveUnit activeUnit_3 = this.activeUnit_0;
										Aircraft aircraft = this.method_112();
										ActiveUnit.Throttle throttle_ = ActiveUnit.Throttle.Cruise;
										ActiveUnit activeUnit_4;
										ActiveUnit activeUnit_5;
										bool bool_4 = (activeUnit_4 = this.activeUnit_0).vmethod_76(activeUnit_5 = this.activeUnit_0);
										float float_4 = Aircraft_AI.smethod_2(ref aircraft, throttle_, ref bool_4);
										activeUnit_4.vmethod_77(activeUnit_5, bool_4);
										activeUnit_3.vmethod_73(float_4);
									}
									else if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
									{
										if (!Information.IsNothing(num4) && num2 > num5)
										{
											if (Information.IsNothing(class3))
											{
												class3 = this.method_112().method_157();
											}
											if (Information.IsNothing(aircraft_AirOps))
											{
												aircraft_AirOps = this.method_112().method_164();
											}
											class3.method_68(false, aircraft_AirOps.method_36());
										}
										else
										{
											Aircraft aircraft = this.method_112();
											ActiveUnit.Throttle throttle_2 = ActiveUnit.Throttle.Cruise;
											bool bool_5 = false;
											ActiveUnit activeUnit_4;
											ActiveUnit activeUnit_5;
											bool bool_4 = (activeUnit_5 = this.activeUnit_0).vmethod_76(activeUnit_4 = this.activeUnit_0);
											float num20 = this.method_135(ref aircraft, throttle_2, bool_5, ref bool_4);
											activeUnit_5.vmethod_77(activeUnit_4, bool_4);
											num7 = num20;
											this.activeUnit_0.vmethod_73(num7);
											this.activeUnit_0.vmethod_75(num7);
										}
									}
									else
									{
										if (Information.IsNothing(class3))
										{
											class3 = this.method_112().method_157();
										}
										Class211 class4 = class3;
										ActiveUnit activeUnit_4;
										ActiveUnit activeUnit_5;
										bool bool_4 = (activeUnit_4 = this.activeUnit_0).vmethod_76(activeUnit_5 = this.activeUnit_0);
										float num21 = class4.method_73(ref bool_4);
										activeUnit_4.vmethod_77(activeUnit_5, bool_4);
										num7 = num21;
										this.activeUnit_0.vmethod_73(num7);
										this.activeUnit_0.vmethod_75(num7);
										this.activeUnit_0.vmethod_77(this.activeUnit_0, bool_3);
									}
								}
							}
							else
							{
								if (!Information.IsNothing(weapon_0))
								{
									float num17 = num7;
									float? num18 = num6 + this.method_112().imethod_4();
									if (((num18 != null) ? new bool?(num17 < num18.GetValueOrDefault()) : null).GetValueOrDefault())
									{
										num7 += num6;
									}
									num17 = num8;
									num18 = num6 + this.method_112().imethod_4();
									if (((num18 != null) ? new bool?(num17 < num18.GetValueOrDefault()) : null).GetValueOrDefault())
									{
										num8 += num6;
									}
								}
								if (num7 > num13)
								{
									num7 = num13;
								}
								if (num7 < num15)
								{
									num7 = num15;
								}
								if (num8 > num14)
								{
									num8 = num14;
								}
								if (num8 < num16)
								{
									num8 = num16;
								}
								if (weapon.method_149(this.vmethod_3().method_134()))
								{
									num12 = this.method_138(2.1474836E+09f);
								}
								if (!Information.IsNothing(num12))
								{
									if (((num12 != null) ? new bool?(num15 > num12.GetValueOrDefault()) : null).GetValueOrDefault())
									{
										if (this.activeUnit_0.scenario_0.ThirtiethSecondIsChangingOnThisPulse)
										{
											string str2 = "";
											if (Operators.CompareString(this.method_112().Name, this.method_112().string_2, false) != 0)
											{
												str2 = " (" + this.method_112().string_2 + ")";
											}
											this.method_112().method_124(this.method_112().Name + str2 + " cannot engage ground targets because the cloud cover is too low. There will not be enough altitude clearance to deploy weapon.", this.method_112().Name + " cannot engage targets", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_112().vmethod_28(null), this.method_112().vmethod_30(null)));
										}
									}
									else if (((num12 != null) ? new bool?(num7 > num12.GetValueOrDefault()) : null).GetValueOrDefault())
									{
										num7 = (num12 - 10f).Value;
										num8 = (num12 - num6).Value;
										num13 = num7;
										num14 = num8;
									}
								}
								if (this.activeUnit_0.vmethod_87().vmethod_12())
								{
									if (this.activeUnit_0.vmethod_72() > num13)
									{
										this.activeUnit_0.vmethod_73(num13);
									}
									if (this.activeUnit_0.vmethod_72() < num15)
									{
										this.activeUnit_0.vmethod_73(num15);
									}
									if (this.activeUnit_0.vmethod_74() > num14)
									{
										this.activeUnit_0.vmethod_75(num14);
									}
									if (this.activeUnit_0.vmethod_74() < num16)
									{
										this.activeUnit_0.vmethod_75(num16);
									}
								}
								else if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && (this.method_112().method_157().method_32() || (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.method_122()) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_32())))
								{
									if (num7 != this.activeUnit_0.vmethod_14(false))
									{
										this.activeUnit_0.vmethod_73(num7);
										this.activeUnit_0.vmethod_75(num8);
									}
									else
									{
										this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false));
										this.activeUnit_0.vmethod_75(num8);
									}
								}
								else if (!Information.IsNothing(num3))
								{
									this.activeUnit_0.vmethod_73(num7);
									this.activeUnit_0.vmethod_75(num8);
									this.activeUnit_0.vmethod_77(this.activeUnit_0, bool_3);
								}
								else
								{
									float num19 = Math.Abs(this.activeUnit_0.vmethod_87().vmethod_48(this.activeUnit_0, num7, 0f));
									if (num2 <= num5 + num19)
									{
										if (num7 != this.activeUnit_0.vmethod_14(false))
										{
											this.activeUnit_0.vmethod_73(num7);
											this.activeUnit_0.vmethod_75(num8);
										}
										else
										{
											this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false));
											this.activeUnit_0.vmethod_75(num8);
										}
									}
									else if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
									{
										ActiveUnit activeUnit_6 = this.activeUnit_0;
										Aircraft aircraft = this.method_112();
										ActiveUnit.Throttle throttle_3 = ActiveUnit.Throttle.Cruise;
										ActiveUnit activeUnit_4;
										ActiveUnit activeUnit_5;
										bool bool_4 = (activeUnit_5 = this.activeUnit_0).vmethod_76(activeUnit_4 = this.activeUnit_0);
										float float_5 = Aircraft_AI.smethod_2(ref aircraft, throttle_3, ref bool_4);
										activeUnit_5.vmethod_77(activeUnit_4, bool_4);
										activeUnit_6.vmethod_73(float_5);
									}
									else if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
									{
										if (!Information.IsNothing(num4) && num2 > num5)
										{
											if (Information.IsNothing(class3))
											{
												class3 = this.method_112().method_157();
											}
											if (Information.IsNothing(aircraft_AirOps))
											{
												aircraft_AirOps = this.method_112().method_164();
											}
											class3.method_68(false, aircraft_AirOps.method_36());
										}
										else
										{
											Aircraft aircraft = this.method_112();
											ActiveUnit.Throttle throttle_4 = ActiveUnit.Throttle.Cruise;
											bool bool_6 = false;
											ActiveUnit activeUnit_4;
											ActiveUnit activeUnit_5;
											bool bool_4 = (activeUnit_4 = this.activeUnit_0).vmethod_76(activeUnit_5 = this.activeUnit_0);
											float num22 = this.method_135(ref aircraft, throttle_4, bool_6, ref bool_4);
											activeUnit_4.vmethod_77(activeUnit_5, bool_4);
											num7 = num22;
											this.activeUnit_0.vmethod_73(num7);
											this.activeUnit_0.vmethod_75(num8);
										}
									}
									else
									{
										if (Information.IsNothing(class3))
										{
											class3 = this.method_112().method_157();
										}
										Class211 class5 = class3;
										ActiveUnit activeUnit_4;
										ActiveUnit activeUnit_5;
										bool bool_4 = (activeUnit_5 = this.activeUnit_0).vmethod_76(activeUnit_4 = this.activeUnit_0);
										float num23 = class5.method_73(ref bool_4);
										activeUnit_5.vmethod_77(activeUnit_4, bool_4);
										num7 = num23;
										this.activeUnit_0.vmethod_73(num7);
										this.activeUnit_0.vmethod_75(num8);
										this.activeUnit_0.vmethod_77(this.activeUnit_0, bool_3);
									}
								}
							}
						}
						if (this.method_112().method_159().vmethod_10() == null || this.activeUnit_0.vmethod_85().method_32())
						{
							if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
							{
								if (Information.IsNothing(class2))
								{
									class2 = (Class343)this.activeUnit_0.vmethod_101();
								}
								if (!Information.IsNothing(num4) && num2 > num5)
								{
									throttle = class2.imethod_0();
								}
								else
								{
									throttle = class2.imethod_4();
								}
							}
							if (!Information.IsNothing(throttle))
							{
								this.activeUnit_0.vmethod_134(throttle.Value, null);
							}
							else if (num2 > num5)
							{
								this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
							}
							else
							{
								if (Information.IsNothing(class3))
								{
									class3 = this.method_112().method_157();
								}
								if (Information.IsNothing(aircraft_AirOps))
								{
									aircraft_AirOps = this.method_112().method_164();
								}
								class3.method_71(this.activeUnit_0.vmethod_72(), new float?((float)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_72(), ActiveUnit.Throttle.Cruise, false)), false, aircraft_AirOps.method_36());
								if (weapon.int_17 != 0 && (float)weapon.int_17 < this.activeUnit_0.vmethod_70())
								{
									this.activeUnit_0.vmethod_71((float)weapon.int_17);
								}
								if (weapon.int_18 != 0 && (float)weapon.int_18 > this.activeUnit_0.vmethod_70())
								{
									this.activeUnit_0.vmethod_71((float)weapon.int_18);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200351", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x000EEF3C File Offset: 0x000ED13C
		private float? method_138(float float_3)
		{
			Weather.WeatherProfile weatherProfile = Weather.smethod_0(this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), (int)Math.Round((double)this.activeUnit_0.vmethod_14(false)));
			float? num = null;
			if (weatherProfile.struct45_0.int_8 > 0 && float_3 >= (float)weatherProfile.struct45_0.int_6)
			{
				if ((float)weatherProfile.struct45_0.int_7 > float_3)
				{
					return num;
				}
				num = new float?((float)weatherProfile.struct45_0.int_6);
			}
			if (weatherProfile.struct45_0.int_5 > 0 && float_3 >= (float)weatherProfile.struct45_0.int_3)
			{
				if (Information.IsNothing(num) && (float)weatherProfile.struct45_0.int_4 > float_3)
				{
					num = null;
				}
				else
				{
					num = new float?((float)weatherProfile.struct45_0.int_3);
				}
			}
			if (weatherProfile.struct45_0.int_2 > 0 && float_3 >= (float)weatherProfile.struct45_0.int_0)
			{
				if (Information.IsNothing(num) && (float)weatherProfile.struct45_0.int_1 > float_3)
				{
					num = null;
				}
				else
				{
					num = new float?((float)weatherProfile.struct45_0.int_0);
				}
			}
			return num;
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x000EF094 File Offset: 0x000ED294
		public void method_139()
		{
			try
			{
				List<Aircraft> list = new List<Aircraft>();
				if (this.method_112().method_164().concurrentDictionary_0.Count > 0)
				{
					try
					{
						foreach (string text in this.method_112().method_164().concurrentDictionary_0.Keys)
						{
							if (string.IsNullOrEmpty(text))
							{
								ConcurrentDictionary<string, byte> concurrentDictionary_ = this.method_112().method_164().concurrentDictionary_0;
								string text2 = text;
								byte b = 0;
								concurrentDictionary_.TryRemove(text2, ref b);
							}
							else
							{
								Aircraft aircraft = (Aircraft)this.method_112().scenario_0.vmethod_0()[text];
								if (aircraft == null)
								{
									ConcurrentDictionary<string, byte> concurrentDictionary_2 = this.method_112().method_164().concurrentDictionary_0;
									string text3 = text;
									byte b = 0;
									concurrentDictionary_2.TryRemove(text3, ref b);
								}
								else if (!aircraft.method_157().bool_3 && aircraft != null)
								{
									ActiveUnit activeUnit = aircraft;
									double num = 0.0;
									double num2;
									if (activeUnit.vmethod_119(ref num2, ref num, false) < 0.15)
									{
										list.Add(aircraft);
									}
									else if (aircraft.vmethod_101() != null && aircraft.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && aircraft.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IsBingo)
									{
										list.Add(aircraft);
									}
								}
							}
						}
					}
					finally
					{
						IEnumerator<string> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				if (list.Count > 0)
				{
					if (this.method_112().method_36(list[0]) > 10f)
					{
						this.method_112().vmethod_69(ActiveUnit.Enum28.const_0, Math2.smethod_17(this.method_112().vmethod_30(null), this.method_112().vmethod_28(null), list[0].vmethod_30(null), list[0].vmethod_28(null)));
					}
					if (this.method_112().method_164().method_36() != Aircraft_AirOps._AirOpsCondition.OffloadingFuel && this.method_112().vmethod_84() < ActiveUnit.Throttle.Cruise)
					{
						this.method_112().vmethod_134(ActiveUnit.Throttle.Cruise, null);
					}
				}
				else if (this.method_112().method_164().method_36() == Aircraft_AirOps._AirOpsCondition.OffloadingFuel)
				{
					List<KeyValuePair<string, Aircraft_AirOps.Enum43>> list2 = new List<KeyValuePair<string, Aircraft_AirOps.Enum43>>();
					ActiveUnit activeUnit2 = null;
					ActiveUnit activeUnit3 = null;
					list2.AddRange(this.method_112().method_164().concurrentDictionary_1);
					try
					{
						foreach (KeyValuePair<string, Aircraft_AirOps.Enum43> keyValuePair in list2)
						{
							if (this.method_112().scenario_0.vmethod_0().ContainsKey(keyValuePair.Key))
							{
								Aircraft aircraft2 = (Aircraft)this.method_112().scenario_0.vmethod_0()[keyValuePair.Key];
								if (!aircraft2.method_158().bool_2)
								{
									if (!aircraft2.method_121() && aircraft2.vmethod_101() != null)
									{
										if (aircraft2.method_157().nullable_0 != null)
										{
											if (!aircraft2.method_157().nullable_0.GetValueOrDefault() || !aircraft2.method_157().method_47())
											{
												continue;
											}
											activeUnit2 = aircraft2;
										}
										else
										{
											if (!aircraft2.vmethod_101().bool_18 || !aircraft2.method_157().method_47())
											{
												continue;
											}
											activeUnit2 = aircraft2;
										}
										break;
									}
								}
								else if (activeUnit3 == null && aircraft2.vmethod_101() != null)
								{
									if (aircraft2.method_157().nullable_0 != null)
									{
										if (aircraft2.method_157().nullable_0.GetValueOrDefault() && aircraft2.vmethod_101().bool_18)
										{
											activeUnit3 = aircraft2;
										}
									}
									else if (aircraft2.vmethod_101().bool_18)
									{
										activeUnit3 = aircraft2;
									}
								}
							}
							else
							{
								ConcurrentDictionary<string, Aircraft_AirOps.Enum43> concurrentDictionary_3 = this.method_112().method_164().concurrentDictionary_1;
								string key = keyValuePair.Key;
								Aircraft_AirOps.Enum43 @enum = Aircraft_AirOps.Enum43.const_0;
								concurrentDictionary_3.TryRemove(key, ref @enum);
							}
						}
					}
					finally
					{
						List<KeyValuePair<string, Aircraft_AirOps.Enum43>>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					if (!Information.IsNothing(activeUnit2))
					{
						this.method_112().vmethod_69(ActiveUnit.Enum28.const_1, activeUnit2.vmethod_68());
						this.method_112().vmethod_81(activeUnit2.vmethod_80());
					}
					else if (!Information.IsNothing(activeUnit3))
					{
						this.method_112().vmethod_69(ActiveUnit.Enum28.const_1, activeUnit3.vmethod_68());
						this.method_112().vmethod_81(activeUnit3.vmethod_80());
					}
				}
				if (this.method_112().method_164().concurrentDictionary_0.Count > 0)
				{
					try
					{
						foreach (string text4 in this.method_112().method_164().concurrentDictionary_0.Keys)
						{
							if (string.IsNullOrEmpty(text4))
							{
								ConcurrentDictionary<string, byte> concurrentDictionary_4 = this.method_112().method_164().concurrentDictionary_0;
								string text5 = text4;
								byte b = 0;
								concurrentDictionary_4.TryRemove(text5, ref b);
							}
							else
							{
								Aircraft aircraft3 = (Aircraft)this.method_112().scenario_0.vmethod_0()[text4];
								if (aircraft3 == null)
								{
									ConcurrentDictionary<string, byte> concurrentDictionary_5 = this.method_112().method_164().concurrentDictionary_0;
									string text6 = text4;
									byte b = 0;
									concurrentDictionary_5.TryRemove(text6, ref b);
								}
								else
								{
									if (this.method_112().vmethod_14(false) > aircraft3.method_159().vmethod_30())
									{
										this.method_112().vmethod_73(aircraft3.method_159().vmethod_30() - 100f);
									}
									if (this.method_112().vmethod_84() > ActiveUnit.Throttle.Loiter)
									{
										float num3 = aircraft3.method_46(this.method_112(), false);
										if (num3 <= 315f && num3 >= 135f)
										{
											if (this.method_112().method_36(aircraft3) < 25f)
											{
												this.method_112().vmethod_134(ActiveUnit.Throttle.Loiter, null);
											}
											else if (aircraft3.method_157().method_32())
											{
												this.method_112().vmethod_134(ActiveUnit.Throttle.Loiter, null);
											}
											else if (this.method_112().vmethod_101() != null && this.method_112().vmethod_101()._MissionClass_0 == Mission._MissionClass.Ferry)
											{
												this.method_112().vmethod_134(ActiveUnit.Throttle.Loiter, null);
											}
										}
									}
								}
							}
						}
					}
					finally
					{
						IEnumerator<string> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
				}
				if (this.method_112().method_164().method_36() == Aircraft_AirOps._AirOpsCondition.OffloadingFuel && this.method_112().vmethod_84() > ActiveUnit.Throttle.Loiter)
				{
					this.method_112().vmethod_134(ActiveUnit.Throttle.Loiter, null);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100401", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x000EF758 File Offset: 0x000ED958
		private void method_140(float float_3, bool bool_11)
		{
			this.bool_5 = true;
			if (this.vmethod_3() != null)
			{
				try
				{
					if (!this.activeUnit_0.vmethod_85().bool_2)
					{
						if (this.activeUnit_0.vmethod_85().vmethod_29(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null), true, 0f, false, null, true, false, false, null))
						{
							Aircraft_AI.Class251 @class = new Aircraft_AI.Class251();
							@class.list_0 = new List<Waypoint>();
							@class.list_0.AddRange(this.activeUnit_0.vmethod_85().method_4());
							if (!this.activeUnit_0.vmethod_85().bool_2)
							{
								if (this.activeUnit_0.vmethod_85().method_44())
								{
									Waypoint waypoint = Enumerable.ElementAtOrDefault<Waypoint>(Enumerable.OrderByDescending<Waypoint, int>(Enumerable.Where<Waypoint>(@class.list_0, (Aircraft_AI._Closure$__.$I57-0 == null) ? (Aircraft_AI._Closure$__.$I57-0 = new Func<Waypoint, bool>(Aircraft_AI._Closure$__.$I.method_21)) : Aircraft_AI._Closure$__.$I57-0), new Func<Waypoint, int>(@class.method_0)), 0);
									Weapon weapon = this.activeUnit_0.vmethod_89().method_15(this.vmethod_3());
									float num;
									if (Information.IsNothing(weapon))
									{
										num = 1f;
									}
									else
									{
										num = weapon.method_181(this.activeUnit_0, this.vmethod_3(), false, null, false);
									}
									if (Math2.smethod_15(waypoint.imethod_2(), waypoint.imethod_0(), this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null)) > num)
									{
										this.activeUnit_0.vmethod_85().method_16(waypoint, this.activeUnit_0, null, false, 0.15f, this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null), this.activeUnit_0.scenario_0, bool_11);
									}
									else
									{
										this.activeUnit_0.vmethod_85().vmethod_16(float_3);
									}
								}
								else
								{
									this.activeUnit_0.vmethod_85().method_16(null, this.activeUnit_0, null, false, 0.15f, this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null), this.activeUnit_0.scenario_0, bool_11);
								}
							}
						}
						else if (this.activeUnit_0.vmethod_85().method_44())
						{
							this.activeUnit_0.vmethod_85().method_18();
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100402", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				this.bool_5 = false;
			}
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x000EFA6C File Offset: 0x000EDC6C
		private void method_141()
		{
			try
			{
				if (base.method_12().Length != 0)
				{
					if (this.method_112().scenario_0.method_17().Count != 0)
					{
						List<Weapon> list = this.method_112().method_161().method_58();
						List<Contact> list2 = new List<Contact>();
						foreach (Contact contact in base.method_12())
						{
							Weapon[] array2 = contact.method_100();
							if (Enumerable.Count<Weapon>(Enumerable.Intersect<Weapon>(list, array2)) > 0)
							{
								list2.Add(contact);
							}
						}
						if (list2.Count != 0)
						{
							this.method_112().method_164().method_37(Aircraft_AirOps._AirOpsCondition.BVRCrank);
							Contact contact2;
							if (Information.IsNothing(this.vmethod_3()))
							{
								contact2 = base.method_12()[0];
							}
							else
							{
								contact2 = this.vmethod_3();
							}
							int num = (int)Math.Round((double)Math2.smethod_17(this.method_112().vmethod_30(null), this.method_112().vmethod_28(null), contact2.vmethod_30(null), contact2.vmethod_28(null)));
							int num2 = 5;
							int num5;
							do
							{
								int num3 = Math2.smethod_8(num - num2);
								int num4 = 0;
								try
								{
									foreach (Contact theTarget in list2)
									{
										foreach (Sensor sensor in this.method_112().method_78())
										{
											if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar && sensor.method_20(theTarget, new float?((float)num3)))
											{
												num4++;
												break;
											}
										}
									}
								}
								finally
								{
									List<Contact>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
								if (num4 != list2.Count)
								{
									break;
								}
								num5 = num3;
								num2 += 5;
							}
							while (num2 <= 360);
							num5++;
							this.method_112().vmethod_69(ActiveUnit.Enum28.const_0, (float)num5);
							if (Information.IsNothing(this.method_112().method_159().vmethod_10()))
							{
								this.method_112().vmethod_134(ActiveUnit.Throttle.Loiter, null);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100403", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x000EFCFC File Offset: 0x000EDEFC
		private void method_142()
		{
			try
			{
				if (base.method_12().Length != 0)
				{
					if (this.method_112().scenario_0.method_17().Count != 0)
					{
						List<Weapon> list = Enumerable.ToList<Weapon>(Enumerable.Where<Weapon>(this.method_112().scenario_0.method_17(), new Func<Weapon, bool>(this.method_166)));
						List<Contact> list2 = new List<Contact>();
						foreach (Contact contact in base.method_12())
						{
							Weapon[] array2 = contact.method_100();
							if (Enumerable.Count<Weapon>(Enumerable.Intersect<Weapon>(list, array2)) > 0)
							{
								list2.Add(contact);
							}
						}
						if (list2.Count != 0)
						{
							this.method_112().method_164().method_37(Aircraft_AirOps._AirOpsCondition.BVRDrag);
							Contact unit_ = Enumerable.ElementAtOrDefault<Contact>(Enumerable.OrderByDescending<Contact, float>(list2, new Func<Contact, float>(this.method_167)), 0);
							this.method_112().vmethod_69(ActiveUnit.Enum28.const_0, Math2.smethod_7(this.method_112().method_32(unit_) + 180f));
							if (Information.IsNothing(this.method_112().method_159().vmethod_10()))
							{
								this.method_112().vmethod_134(ActiveUnit.Throttle.Flank, null);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 10324523409589238590238095", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x000EFE84 File Offset: 0x000EE084
		private void method_143(float float_3)
		{
			Class338 @class = (Class338)this.activeUnit_0.vmethod_101();
			Aircraft aircraft = (Aircraft)this.activeUnit_0;
			if (Enumerable.Count<Cargo>(this.activeUnit_0.cargo_0) == 0)
			{
				this.activeUnit_0.vmethod_92().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB_MissionOver, true, ActiveUnit._ActiveUnitStatus.RTB_Group, true, true);
				return;
			}
			if (this.activeUnit_0.vmethod_85().method_40(ref @class.list_5, ref @class.list_8, ref @class.list_9, 1, false, false) && (this.activeUnit_0.method_15() | this.activeUnit_0.method_16(float_3)))
			{
				if (aircraft.method_167().bool_15)
				{
					aircraft.method_164().method_88();
				}
				if (Enumerable.Count<Cargo>(aircraft.cargo_0) != 0)
				{
					if (aircraft.method_169())
					{
						aircraft.method_164().method_37(Aircraft_AirOps._AirOpsCondition.TransferringCargo);
						aircraft.method_164().method_39(120f);
						return;
					}
					aircraft.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
					return;
				}
			}
			else
			{
				if (this.activeUnit_0.method_120())
				{
					if (this.activeUnit_0.method_122())
					{
						if (this.activeUnit_0.vmethod_85().method_46())
						{
							if (!this.activeUnit_0.vmethod_65(false).vmethod_85().method_37(ref @class.list_5, ref @class.list_7, ref @class.list_6, 30f, false))
							{
								this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_22(@class.list_5);
							}
							this.activeUnit_0.vmethod_85().vmethod_16(float_3);
						}
						else
						{
							this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_22(@class.list_5);
						}
					}
					else if (this.activeUnit_0.vmethod_90().vmethod_1())
					{
						this.activeUnit_0.vmethod_85().vmethod_21(float_3);
					}
				}
				else if (this.activeUnit_0.vmethod_85().method_46())
				{
					if (!this.activeUnit_0.vmethod_85().method_37(ref @class.list_5, ref @class.list_7, ref @class.list_6, 30f, false))
					{
						this.activeUnit_0.vmethod_85().vmethod_22(@class.list_5);
					}
					this.activeUnit_0.vmethod_85().vmethod_16(float_3);
				}
				else
				{
					this.activeUnit_0.vmethod_85().vmethod_22(@class.list_5);
				}
				if (this.activeUnit_0.vmethod_87().vmethod_10() == null)
				{
					if (this.activeUnit_0.vmethod_85().method_40(ref @class.list_5, ref @class.list_8, ref @class.list_9, 1, false, false))
					{
						this.activeUnit_0.vmethod_134(@class.throttle_1, null);
					}
					else
					{
						this.activeUnit_0.vmethod_134(@class.throttle_0, null);
					}
				}
				if (!this.activeUnit_0.vmethod_87().vmethod_12())
				{
					if (this.activeUnit_0.vmethod_85().method_40(ref @class.list_5, ref @class.list_8, ref @class.list_9, 1, false, false))
					{
						this.activeUnit_0.vmethod_73(@class.float_1);
						return;
					}
					this.activeUnit_0.vmethod_73(@class.float_0);
				}
			}
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_144(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00008723 File Offset: 0x00006923
		[CompilerGenerated]
		private GlobalVariables.TargetVisualSizeClass method_145(Contact contact_8)
		{
			return contact_8.method_102(this.activeUnit_0.scenario_0);
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_146(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x000F01A0 File Offset: 0x000EE3A0
		[CompilerGenerated]
		private int method_147(Contact contact_8)
		{
			return Enumerable.Count<ActiveUnit>(Enumerable.Where<ActiveUnit>(contact_8.method_120(this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_7(false), false, this.activeUnit_0).Values, (Aircraft_AI._Closure$__.$I12-12 == null) ? (Aircraft_AI._Closure$__.$I12-12 = new Func<ActiveUnit, bool>(Aircraft_AI._Closure$__.$I.method_5)) : Aircraft_AI._Closure$__.$I12-12));
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_148(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_149(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x000F0204 File Offset: 0x000EE404
		[CompilerGenerated]
		private bool method_150(Contact contact_8)
		{
			if (!contact_8.method_103())
			{
				Mission mission_ = this.method_112().vmethod_101();
				Doctrine.Enum59? nullable_ = this.activeUnit_0.doctrine_0.method_162(this.activeUnit_0.scenario_0, false, false, false);
				bool bool_ = false;
				bool bool_2 = false;
				bool bool_3 = true;
				Misc.PostureStance? nullable_2 = null;
				string text = "";
				int num = 0;
				if (base.method_39(contact_8, mission_, nullable_, bool_, bool_2, bool_3, nullable_2, ref text, ref num))
				{
					ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
					bool checkWRA = true;
					Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
					text = "";
					num = 0;
					return activeUnit_Weaponry.method_6(contact_8, checkWRA, doctrine_, ref text, ref num, null);
				}
			}
			return false;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_151(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_152(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x000F0290 File Offset: 0x000EE490
		[CompilerGenerated]
		private int method_153(Contact contact_8)
		{
			return Enumerable.Count<ActiveUnit>(Enumerable.Where<ActiveUnit>(contact_8.method_120(this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_7(false), false, this.activeUnit_0).Values, (Aircraft_AI._Closure$__.$I12-24 == null) ? (Aircraft_AI._Closure$__.$I12-24 = new Func<ActiveUnit, bool>(Aircraft_AI._Closure$__.$I.method_9)) : Aircraft_AI._Closure$__.$I12-24));
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_154(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_155(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00008723 File Offset: 0x00006923
		[CompilerGenerated]
		private GlobalVariables.TargetVisualSizeClass method_156(Contact contact_8)
		{
			return contact_8.method_102(this.activeUnit_0.scenario_0);
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00008736 File Offset: 0x00006936
		[CompilerGenerated]
		private bool method_157(NoNavZone noNavZone_0)
		{
			return noNavZone_0.method_8(this.activeUnit_0);
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00008744 File Offset: 0x00006944
		[CompilerGenerated]
		private bool method_158(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_2() && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_194() && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00008781 File Offset: 0x00006981
		[CompilerGenerated]
		private float method_159(Weapon weapon_0)
		{
			return weapon_0.method_181(this.activeUnit_0, this.vmethod_3(), true, this.activeUnit_0.doctrine_0, false);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x000087A2 File Offset: 0x000069A2
		[CompilerGenerated]
		private bool method_160(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_2() && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_192() && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x000087DF File Offset: 0x000069DF
		[CompilerGenerated]
		private bool method_161(Weapon weapon_0)
		{
			return weapon_0.method_177() == this.method_112() && weapon_0.method_192();
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000087A2 File Offset: 0x000069A2
		[CompilerGenerated]
		private bool method_162(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_2() && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_192() && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x000087F7 File Offset: 0x000069F7
		[CompilerGenerated]
		private bool method_163(Sensor sensor_0)
		{
			return sensor_0.struct33_0.bool_1 && sensor_0.method_63(this.vmethod_3().activeUnit_0);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00008819 File Offset: 0x00006A19
		[CompilerGenerated]
		private float method_164(Sensor sensor_0)
		{
			return sensor_0.method_91(this.method_112(), this.vmethod_3().activeUnit_0);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_165(UnguidedWeapon unguidedWeapon_0)
		{
			return this.activeUnit_0.method_31(unguidedWeapon_0);
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x000087DF File Offset: 0x000069DF
		[CompilerGenerated]
		private bool method_166(Weapon weapon_0)
		{
			return weapon_0.method_177() == this.method_112() && weapon_0.method_192();
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00008832 File Offset: 0x00006A32
		[CompilerGenerated]
		private float method_167(Contact contact_8)
		{
			return contact_8.method_36(this.method_112());
		}

		// Token: 0x04000800 RID: 2048
		private Aircraft aircraft_0;

		// Token: 0x04000801 RID: 2049
		private ActiveUnit_AI.AircraftAltitudePreset aircraftAltitudePreset_0;

		// Token: 0x04000802 RID: 2050
		private int int_1;

		// Token: 0x04000803 RID: 2051
		private int int_2;

		// Token: 0x04000804 RID: 2052
		private HashSet<string> hashSet_1;

		// Token: 0x02000187 RID: 391
		[CompilerGenerated]
		internal sealed class Class239
		{
			// Token: 0x06000C12 RID: 3090 RVA: 0x00008840 File Offset: 0x00006A40
			internal bool method_0(Contact contact_0)
			{
				return Operators.CompareString(contact_0.activeUnit_0.string_0, this.activeUnit_0.string_0, false) == 0;
			}

			// Token: 0x04000805 RID: 2053
			public ActiveUnit activeUnit_0;
		}

		// Token: 0x02000188 RID: 392
		[CompilerGenerated]
		internal sealed class Class240
		{
			// Token: 0x06000C14 RID: 3092 RVA: 0x00008861 File Offset: 0x00006A61
			internal bool method_0(Contact contact_0)
			{
				return Operators.CompareString(contact_0.activeUnit_0.string_0, this.activeUnit_0.string_0, false) == 0;
			}

			// Token: 0x04000806 RID: 2054
			public ActiveUnit activeUnit_0;
		}

		// Token: 0x02000189 RID: 393
		[CompilerGenerated]
		internal sealed class Class241
		{
			// Token: 0x06000C15 RID: 3093 RVA: 0x00008882 File Offset: 0x00006A82
			public Class241(Aircraft_AI.Class241 class241_0)
			{
				if (class241_0 != null)
				{
					this.strike_0 = class241_0.strike_0;
				}
			}

			// Token: 0x06000C16 RID: 3094 RVA: 0x000F02F4 File Offset: 0x000EE4F4
			internal bool method_0(Contact contact_0)
			{
				if (contact_0.method_92(this.strike_0))
				{
					ActiveUnit_Weaponry activeUnit_Weaponry = this.aircraft_AI_0.activeUnit_0.vmethod_89();
					bool checkWRA = true;
					Doctrine doctrine_ = this.aircraft_AI_0.activeUnit_0.doctrine_0;
					string text = "";
					int num = 0;
					return activeUnit_Weaponry.method_6(contact_0, checkWRA, doctrine_, ref text, ref num, null);
				}
				return false;
			}

			// Token: 0x04000807 RID: 2055
			public Strike strike_0;

			// Token: 0x04000808 RID: 2056
			public Aircraft_AI aircraft_AI_0;
		}

		// Token: 0x0200018A RID: 394
		[CompilerGenerated]
		internal sealed class Class242
		{
			// Token: 0x06000C17 RID: 3095 RVA: 0x00008899 File Offset: 0x00006A99
			public Class242(Aircraft_AI.Class242 class242_0)
			{
				if (class242_0 != null)
				{
					this.string_0 = class242_0.string_0;
				}
			}

			// Token: 0x06000C18 RID: 3096 RVA: 0x000088B0 File Offset: 0x00006AB0
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return !activeUnit_0.bool_1 && activeUnit_0.vmethod_127() && activeUnit_0.vmethod_86().method_13().Contains(this.string_0);
			}

			// Token: 0x04000809 RID: 2057
			public string string_0;

			// Token: 0x0400080A RID: 2058
			public Func<ActiveUnit, bool> func_0;
		}

		// Token: 0x0200018B RID: 395
		[CompilerGenerated]
		internal sealed class Class243
		{
			// Token: 0x06000C19 RID: 3097 RVA: 0x000088DA File Offset: 0x00006ADA
			public Class243(Aircraft_AI.Class243 class243_0)
			{
				if (class243_0 != null)
				{
					this.contact_0 = class243_0.contact_0;
				}
			}

			// Token: 0x06000C1A RID: 3098 RVA: 0x000088F1 File Offset: 0x00006AF1
			internal double method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.method_31(this.contact_0);
			}

			// Token: 0x0400080B RID: 2059
			public Contact contact_0;
		}

		// Token: 0x0200018C RID: 396
		[CompilerGenerated]
		internal sealed class Class244
		{
			// Token: 0x06000C1B RID: 3099 RVA: 0x000088FF File Offset: 0x00006AFF
			public Class244(Aircraft_AI.Class244 class244_0)
			{
				if (class244_0 != null)
				{
					this.string_0 = class244_0.string_0;
				}
			}

			// Token: 0x06000C1C RID: 3100 RVA: 0x00008916 File Offset: 0x00006B16
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return !activeUnit_0.bool_1 && activeUnit_0.vmethod_127() && activeUnit_0.vmethod_86().method_13().Contains(this.string_0);
			}

			// Token: 0x0400080C RID: 2060
			public string string_0;

			// Token: 0x0400080D RID: 2061
			public Func<ActiveUnit, bool> func_0;
		}

		// Token: 0x0200018D RID: 397
		[CompilerGenerated]
		internal sealed class Class245
		{
			// Token: 0x06000C1D RID: 3101 RVA: 0x00008940 File Offset: 0x00006B40
			public Class245(Aircraft_AI.Class245 class245_0)
			{
				if (class245_0 != null)
				{
					this.contact_0 = class245_0.contact_0;
				}
			}

			// Token: 0x06000C1E RID: 3102 RVA: 0x00008957 File Offset: 0x00006B57
			internal double method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.method_31(this.contact_0);
			}

			// Token: 0x0400080E RID: 2062
			public Contact contact_0;
		}

		// Token: 0x0200018F RID: 399
		[CompilerGenerated]
		internal sealed class Class246
		{
			// Token: 0x06000C37 RID: 3127 RVA: 0x000089F3 File Offset: 0x00006BF3
			public Class246(Aircraft_AI.Class246 class246_0)
			{
				if (class246_0 != null)
				{
					this.strike_0 = class246_0.strike_0;
				}
			}

			// Token: 0x06000C38 RID: 3128 RVA: 0x00008A0A File Offset: 0x00006C0A
			internal bool method_0(Contact contact_0)
			{
				return contact_0.method_92(this.strike_0);
			}

			// Token: 0x04000826 RID: 2086
			public Strike strike_0;
		}

		// Token: 0x02000190 RID: 400
		[CompilerGenerated]
		internal sealed class Class247
		{
			// Token: 0x06000C3A RID: 3130 RVA: 0x00008A18 File Offset: 0x00006C18
			internal void method_0()
			{
				this.aircraft_AI_0.method_140(this.float_0, true);
			}

			// Token: 0x04000827 RID: 2087
			public float float_0;

			// Token: 0x04000828 RID: 2088
			public Aircraft_AI aircraft_AI_0;
		}

		// Token: 0x02000191 RID: 401
		[CompilerGenerated]
		internal sealed class Class248
		{
			// Token: 0x06000C3B RID: 3131 RVA: 0x00008A2C File Offset: 0x00006C2C
			public Class248(Aircraft_AI.Class248 class248_0)
			{
				if (class248_0 != null)
				{
					this.observableDictionary_0 = class248_0.observableDictionary_0;
					this.list_0 = class248_0.list_0;
					this.concurrentBag_0 = class248_0.concurrentBag_0;
				}
			}

			// Token: 0x06000C3C RID: 3132 RVA: 0x000F0380 File Offset: 0x000EE580
			internal void method_0(string string_0)
			{
				UnguidedWeapon unguidedWeapon;
				this.observableDictionary_0.TryGetValue(string_0, ref unguidedWeapon);
				if (!Information.IsNothing(unguidedWeapon) && unguidedWeapon.method_65() && unguidedWeapon.vmethod_46(this.list_0, this.aircraft_AI_0.activeUnit_0.scenario_0, true))
				{
					this.concurrentBag_0.Add(unguidedWeapon);
				}
			}

			// Token: 0x04000829 RID: 2089
			public ObservableDictionary<string, UnguidedWeapon> observableDictionary_0;

			// Token: 0x0400082A RID: 2090
			public List<ReferencePoint> list_0;

			// Token: 0x0400082B RID: 2091
			public ConcurrentBag<UnguidedWeapon> concurrentBag_0;

			// Token: 0x0400082C RID: 2092
			public Aircraft_AI aircraft_AI_0;
		}

		// Token: 0x02000192 RID: 402
		[CompilerGenerated]
		internal sealed class Class249
		{
			// Token: 0x06000C3D RID: 3133 RVA: 0x00008A5B File Offset: 0x00006C5B
			public Class249(Aircraft_AI.Class249 class249_0)
			{
				if (class249_0 != null)
				{
					this.bool_0 = class249_0.bool_0;
				}
			}

			// Token: 0x06000C3E RID: 3134 RVA: 0x000F03D8 File Offset: 0x000EE5D8
			internal void method_0(Weapon weapon_0, ParallelLoopState parallelLoopState_0)
			{
				if (weapon_0.method_167() == Weapon._WeaponType.Sonobuoy && weapon_0.vmethod_96().Length > 0 && (this.aircraft_AI_0.method_112().vmethod_7(false) == weapon_0.vmethod_7(false) || this.aircraft_AI_0.method_112().vmethod_7(false).method_67(weapon_0.vmethod_7(false))) && (double)this.aircraft_AI_0.method_112().method_36(weapon_0) < Math.Min(9.5, (double)weapon_0.vmethod_96()[0].float_0 * 1.5))
				{
					this.bool_0 = false;
					parallelLoopState_0.Stop();
				}
			}

			// Token: 0x0400082D RID: 2093
			public bool bool_0;

			// Token: 0x0400082E RID: 2094
			public Aircraft_AI aircraft_AI_0;
		}

		// Token: 0x02000193 RID: 403
		[CompilerGenerated]
		internal sealed class Class250
		{
			// Token: 0x06000C40 RID: 3136 RVA: 0x00008A72 File Offset: 0x00006C72
			internal float method_0(Weapon weapon_0)
			{
				return weapon_0.method_181(this.aircraft_AI_0.activeUnit_0, this.aircraft_AI_0.vmethod_3(), true, this.doctrine_0, false);
			}

			// Token: 0x0400082F RID: 2095
			public Doctrine doctrine_0;

			// Token: 0x04000830 RID: 2096
			public Aircraft_AI aircraft_AI_0;
		}

		// Token: 0x02000194 RID: 404
		[CompilerGenerated]
		internal sealed class Class251
		{
			// Token: 0x06000C42 RID: 3138 RVA: 0x00008A98 File Offset: 0x00006C98
			internal int method_0(Waypoint waypoint_0)
			{
				return this.list_0.IndexOf(waypoint_0);
			}

			// Token: 0x04000831 RID: 2097
			public List<Waypoint> list_0;
		}
	}
}
