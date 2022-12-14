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
	// Token: 0x02000329 RID: 809
	public sealed class Ship_AI : ActiveUnit_AI
	{
		// Token: 0x060017EF RID: 6127 RVA: 0x001B2DA0 File Offset: 0x001B0FA0
		public static Ship_AI smethod_1(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Ship_AI result;
			try
			{
				Ship_AI ship_AI = new Ship_AI(ref activeUnit_1);
				ship_AI.activeUnit_0 = activeUnit_1;
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
								if (num <= 357111700U)
								{
									if (num != 106934956U)
									{
										if (num != 357111700U)
										{
											continue;
										}
										if (Operators.CompareString(name, "IgnorePlottedCourse", false) != 0)
										{
											continue;
										}
										goto IL_487;
									}
									else
									{
										if (Operators.CompareString(name, "PrimaryTarget", false) == 0)
										{
											ship_AI.contact_0 = Contact.smethod_0(xmlNode.InnerText, ref dictionary_0);
											continue;
										}
										continue;
									}
								}
								else
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
												Class429.smethod_13(ref ship_AI.contact_2, contact_);
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
									if (Operators.CompareString(name, "PrimaryThreat", false) == 0)
									{
										ship_AI.contact_1 = Contact.smethod_0(xmlNode.InnerText, ref dictionary_0);
										continue;
									}
									continue;
								}
							}
							else if (num <= 1474882803U)
							{
								if (num != 866975591U)
								{
									if (num != 1474882803U)
									{
										continue;
									}
									if (Operators.CompareString(name, "IE", false) == 0)
									{
										ship_AI.bool_2 = true;
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "DPT_E", false) == 0)
									{
										ship_AI.bool_10 = Conversions.ToBoolean(xmlNode.InnerText);
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
							}
							else
							{
								if (Operators.CompareString(name, "TTNPTE", false) == 0)
								{
									ship_AI.float_1 = Conversions.ToSingle(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 2276842832U)
						{
							if (num <= 2133975202U)
							{
								if (num != 1966596370U)
								{
									if (num != 2133975202U)
									{
										continue;
									}
									if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Lat", false) == 0)
									{
										ship_AI.method_3(XmlConvert.ToDouble(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Lon", false) == 0)
									{
										ship_AI.method_5(XmlConvert.ToDouble(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else
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
											if (!Information.IsNothing(targetingEntry.contact_0))
											{
												try
												{
													ship_AI.vmethod_0().Add(targetingEntry.contact_0.string_0, targetingEntry);
												}
												catch (Exception ex)
												{
													ex.Data.Add("Error at 200037", ex.Message);
													GameGeneral.smethod_25(ref ex);
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
												}
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
						}
						else
						{
							if (num <= 3761246852U)
							{
								if (num != 2722719197U)
								{
									if (num != 3761246852U)
									{
										continue;
									}
									if (Operators.CompareString(name, "PrimaryTargetOverrideExists", false) != 0)
									{
										continue;
									}
								}
								else if (Operators.CompareString(name, "PTOE", false) != 0)
								{
									continue;
								}
								ship_AI.bool_0 = Conversions.ToBoolean(xmlNode.InnerText);
								continue;
							}
							if (num != 3770421268U)
							{
								if (num != 3957045325U)
								{
									if (num != 4076649232U)
									{
										continue;
									}
									if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Alt", false) == 0)
									{
										ship_AI.method_7(XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "IPC", false) == 0)
									{
										goto IL_487;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "ET_E", false) == 0)
								{
									ship_AI.bool_9 = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						ship_AI.bool_1 = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_487:
						bool flag = Conversions.ToBoolean(xmlNode.InnerText);
						if (!Information.IsNothing(activeUnit_1.doctrine_0))
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
				result = ship_AI;
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100773", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x001B33C8 File Offset: 0x001B15C8
		public override bool vmethod_9()
		{
			bool result;
			try
			{
				if (!Information.IsNothing(this.activeUnit_0))
				{
					foreach (Contact contact in base.method_15())
					{
						if (!Information.IsNothing(contact.activeUnit_0) && !Information.IsNothing(contact.activeUnit_0.vmethod_86().vmethod_3()) && !Information.IsNothing(contact.activeUnit_0.vmethod_86().vmethod_3().activeUnit_0) && contact.activeUnit_0.vmethod_86().vmethod_3().activeUnit_0 == this.activeUnit_0)
						{
							result = true;
							break;
						}
						if (base.method_21(contact))
						{
							result = true;
							break;
						}
						if (this.activeUnit_0.method_120())
						{
							try
							{
								IEnumerator<ActiveUnit> enumerator = this.activeUnit_0.vmethod_65(false).vmethod_141().Values.GetEnumerator();
								while (enumerator.MoveNext())
								{
									if (enumerator.Current.vmethod_86().method_21(contact))
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
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100774", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x0000C719 File Offset: 0x0000A919
		public Ship_AI(ref ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
			this.hashSet_1 = new HashSet<string>();
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x001B3528 File Offset: 0x001B1728
		public override void vmethod_21(float float_3, float? nullable_10, ref bool bool_11)
		{
			try
			{
				if (!Information.IsNothing(this.vmethod_3()))
				{
					if (!Information.IsNothing(this.activeUnit_0.vmethod_85().method_4()) && Enumerable.Count<Waypoint>(this.activeUnit_0.vmethod_85().method_4()) > 0 && this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.LocalizationRun)
					{
						if (!Information.IsNothing(this.vmethod_3().method_112()))
						{
							return;
						}
						this.activeUnit_0.vmethod_85().method_53(this.activeUnit_0.vmethod_85().method_4()[0], false);
					}
					if (this.vmethod_3().bool_18 && this.vmethod_3().bool_17)
					{
						float float_4;
						if (nullable_10 != null)
						{
							float_4 = nullable_10.Value;
						}
						else
						{
							float_4 = this.activeUnit_0.vmethod_40();
						}
						Weapon weapon = this.activeUnit_0.vmethod_89().method_16(this.vmethod_3(), false, false, true, this.activeUnit_0.doctrine_0);
						if (!Information.IsNothing(weapon))
						{
							if (weapon.float_30 > 0f && this.activeUnit_0.method_36(this.vmethod_3()) <= weapon.float_30)
							{
								this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, Math2.smethod_7(this.activeUnit_0.method_32(this.vmethod_3()) + 90f));
								return;
							}
							if (weapon.struct36_0.bool_5 || weapon.struct36_0.bool_4)
							{
								double double_;
								double double_2;
								Class411.smethod_1(this.vmethod_3().vmethod_28(null), this.vmethod_3().vmethod_30(null), ref double_, ref double_2, (double)(weapon.float_30 + 1f), (double)Math2.smethod_7(this.vmethod_3().vmethod_9() + 180f));
								this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.method_34(double_2, double_));
								return;
							}
						}
						double? num = ActiveUnit_Navigator.smethod_5(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), (double)this.activeUnit_0.vmethod_9(), this.vmethod_3(), float_4);
						if (num != null)
						{
							this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, (float)num.Value);
						}
						else if (this.activeUnit_0.vmethod_40() < this.vmethod_3().vmethod_40())
						{
							if (Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_68(), this.activeUnit_0.method_32(this.vmethod_3()))) > 15f)
							{
								base.method_64(float_3);
							}
							bool_11 = true;
						}
						else
						{
							base.method_64(float_3);
							bool_11 = true;
						}
					}
					else
					{
						base.method_64(float_3);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100052", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x001B383C File Offset: 0x001B1A3C
		public override void vmethod_23(float float_3)
		{
			try
			{
				if (!Information.IsNothing(this.contact_1))
				{
					double num = Math.Round((double)Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.contact_1.vmethod_30(null), this.contact_1.vmethod_28(null)), 0);
					if (!double.IsNaN(num))
					{
						Contact_Base.ContactType contactType_ = this.contact_1.contactType_0;
						if (contactType_ != Contact_Base.ContactType.Missile)
						{
							if (contactType_ == Contact_Base.ContactType.Torpedo)
							{
								int num2 = (int)Math.Round(num);
								base.method_72(ref num2);
								this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
								Weapon weapon = null;
								if (!Information.IsNothing(this.vmethod_5()))
								{
									weapon = this.activeUnit_0.vmethod_89().method_16(this.vmethod_5(), true, true, true, this.activeUnit_0.doctrine_0);
								}
								if (!Information.IsNothing(weapon) && base.method_73(this.vmethod_5()) && this.activeUnit_0.method_36(this.vmethod_5()) <= weapon.method_181(this.activeUnit_0, this.vmethod_5(), true, this.activeUnit_0.doctrine_0, false))
								{
									base.method_52(ref weapon, this.vmethod_5());
								}
							}
						}
						else
						{
							base.method_74((int)Math.Round(num));
							this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
							Weapon expression = null;
							if (!Information.IsNothing(this.vmethod_5()))
							{
								expression = this.activeUnit_0.vmethod_89().method_16(this.vmethod_5(), false, false, true, this.activeUnit_0.doctrine_0);
							}
							if (!Information.IsNothing(expression) && base.method_73(this.vmethod_5()))
							{
								base.method_52(ref expression, this.vmethod_5());
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100775", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x0000870C File Offset: 0x0000690C
		private Weapon[] method_112()
		{
			return this.activeUnit_0.vmethod_89().vmethod_4().ToArray();
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x001B3A74 File Offset: 0x001B1C74
		public override void vmethod_10(float float_3, bool bool_11, bool bool_12)
		{
			if (this.bool_9 && this.activeUnit_0 != null && !this.activeUnit_0.method_82())
			{
				Side side = this.activeUnit_0.vmethod_7(false);
				try
				{
					if (this.activeUnit_0.vmethod_51().Count == 0 && this.activeUnit_0.method_78().Length == 0)
					{
						if (!Information.IsNothing(this.vmethod_3()))
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
							if (this.activeUnit_0.vmethod_7(false).list_7.Count > 0)
							{
								for (int j = Enumerable.Count<Contact>(array2) - 1; j >= 0; j += -1)
								{
									Contact contact2 = array2[j];
									if (contact2 != null && (side.method_75(ref this.activeUnit_0, ref contact2) <= 0 || base.method_20(contact2) != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc))
									{
										try
										{
											foreach (NoNavZone noNavZone in Enumerable.Where<NoNavZone>(side.list_7, new Func<NoNavZone, bool>(this.method_120)))
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
							Lazy<Weapon[]> lazy = new Lazy<Weapon[]>(new Func<Weapon[]>(this.method_112));
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
									if (!this.hashSet_1.Contains(contact.string_0) && !list2.Contains(contact))
									{
										Contact.Enum47? enum2 = contact.method_74(side);
										byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
										if (!((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
										{
											string string_ = contact.string_0;
											Misc.PostureStance postureStance;
											if (this.tuple_0[k] != null)
											{
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
												switch (postureStance)
												{
												case Misc.PostureStance.Unfriendly:
												case Misc.PostureStance.Hostile:
													if (contact.contactType_0 != Contact_Base.ContactType.Submarine || (!contact.method_72() && !Class442.smethod_1(contact.vmethod_28(null), contact.vmethod_30(null))))
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
													break;
												case Misc.PostureStance.Unknown:
													if (contact.contactType_0 != Contact_Base.ContactType.Submarine || !Class442.smethod_1(contact.vmethod_28(null), contact.vmethod_30(null)))
													{
														this.vmethod_12(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
														this.hashSet_1.Add(contact.string_0);
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
							bool bool_15;
							Doctrine.Enum59 value;
							if (bool_15 = (@enum != null))
							{
								value = @enum.Value;
							}
							num2 = count - 1;
							for (int l = 0; l <= num2; l++)
							{
								Contact contact = base.method_0()[l];
								string string_2 = contact.string_0;
								if (!base.method_13().Contains(contact.string_0) && !list2.Contains(contact))
								{
									Misc.PostureStance postureStance;
									if (this.tuple_0[l] != null)
									{
										postureStance = this.tuple_0[l].Item2;
									}
									else if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(string_2, out postureStance))
									{
										postureStance = contact.method_130(this.activeUnit_0.vmethod_7(false));
									}
									if (postureStance != Misc.PostureStance.Friendly && postureStance != Misc.PostureStance.Neutral)
									{
										Contact.Enum47? enum2 = contact.method_74(side);
										byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
										if (!((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
										{
											if (!flag2 && !Information.IsNothing(mission) && mission._MissionClass_0 == Mission._MissionClass.Patrol && !contact.method_106() && !((Class343)mission).method_66(this.activeUnit_0.scenario_0))
											{
												Class343 class2 = (Class343)mission;
												if (!contact.vmethod_46(class2.list_5, this.activeUnit_0.scenario_0, true) && base.method_20(contact) != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc && !this.activeUnit_0.vmethod_88().method_40(contact))
												{
													goto IL_833;
												}
											}
											if (!this.hashSet_1.Contains(contact.string_0))
											{
												ActiveUnit_Weaponry activeUnit_Weaponry2 = this.activeUnit_0.vmethod_89();
												Contact theTarget2 = contact;
												bool checkWRA2 = true;
												Doctrine doctrine_2 = this.activeUnit_0.doctrine_0;
												string text = "";
												int num3 = 0;
												if (activeUnit_Weaponry2.method_6(theTarget2, checkWRA2, doctrine_2, ref text, ref num3, lazy.Value) && base.method_47(contact, postureStance, bool_15, value, weapon_, weapon_3, weapon_4, weapon_2))
												{
													this.vmethod_12(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
													this.hashSet_1.Add(contact.string_0);
												}
											}
										}
									}
								}
								IL_833:;
							}
							if (this.vmethod_3() != null && this.vmethod_3() is Class355)
							{
								Side side2 = side;
								Contact contact_2 = this.vmethod_3();
								List<Weapon> list3 = side2.method_74(ref this.activeUnit_0, ref contact_2);
								this.vmethod_4(contact_2);
								List<Weapon> list4 = list3;
								bool flag3 = false;
								try
								{
									foreach (Mount mount in this.activeUnit_0.vmethod_51())
									{
										try
										{
											foreach (WeaponRec weaponRec in mount.vmethod_10())
											{
												int int_ = weaponRec.int_5;
												try
												{
													List<Weapon>.Enumerator enumerator7 = list4.GetEnumerator();
													while (enumerator7.MoveNext())
													{
														if (enumerator7.Current.DBID == int_)
														{
															flag3 = true;
															break;
														}
													}
												}
												finally
												{
													List<Weapon>.Enumerator enumerator7;
													((IDisposable)enumerator7).Dispose();
												}
												if (flag3)
												{
													break;
												}
											}
										}
										finally
										{
											List<WeaponRec>.Enumerator enumerator6;
											((IDisposable)enumerator6).Dispose();
										}
										if (flag3)
										{
											break;
										}
									}
								}
								finally
								{
									List<Mount>.Enumerator enumerator5;
									((IDisposable)enumerator5).Dispose();
								}
								if (!flag3)
								{
									this.vmethod_15(this.vmethod_3(), true);
								}
							}
							if (base.method_42())
							{
								this.method_113();
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100776", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x0000378C File Offset: 0x0000198C
		public void method_113()
		{
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x001B44D4 File Offset: 0x001B26D4
		public override void vmethod_25()
		{
			if (!Information.IsNothing(this.activeUnit_0) && !this.activeUnit_0.method_82())
			{
				try
				{
					base.method_34();
					Weapon[] availableWeapons = this.activeUnit_0.vmethod_89().vmethod_4().ToArray();
					try
					{
						foreach (Contact contact in base.method_0())
						{
							bool flag;
							if (!Information.IsNothing(contact.activeUnit_0) && !flag && contact.activeUnit_0.bool_2)
							{
								Misc.PostureStance postureStance;
								if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(contact.string_0, out postureStance))
								{
									postureStance = contact.method_130(this.activeUnit_0.vmethod_7(false));
								}
								if (postureStance != Misc.PostureStance.Friendly && ((Weapon)contact.activeUnit_0).class394_0.bool_0)
								{
									this.vmethod_13(contact);
									Weapon._WeaponType weaponType = ((Weapon)contact.activeUnit_0).method_167();
									if (weaponType == Weapon._WeaponType.Torpedo)
									{
										Weapon weapon = this.activeUnit_0.vmethod_89().method_57();
										if (!Information.IsNothing(weapon))
										{
											ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
											Contact theTarget = contact;
											bool checkWRA = true;
											Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
											string text = "";
											int num = 0;
											if (activeUnit_Weaponry.method_6(theTarget, checkWRA, doctrine_, ref text, ref num, availableWeapons) && (double)this.activeUnit_0.method_37(contact, 0f) < 1.5 * (double)weapon.float_35)
											{
												this.vmethod_12(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
											}
										}
									}
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
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100777", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x001B46E0 File Offset: 0x001B28E0
		public override void vmethod_11(float float_3, bool bool_11, bool bool_12)
		{
			if (this.activeUnit_0 != null)
			{
				try
				{
					Doctrine.Enum61? @enum = this.activeUnit_0.doctrine_0.method_137(this.activeUnit_0.scenario_0, false, false, false);
					byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						if (this.contact_1 != null)
						{
							double num = (double)this.activeUnit_0.method_36(this.contact_1);
							Contact_Base.ContactType contactType_ = this.contact_1.contactType_0;
							if (contactType_ > Contact_Base.ContactType.Missile)
							{
								if (contactType_ == Contact_Base.ContactType.Torpedo)
								{
									if (num < 3.0)
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedDefensive);
										return;
									}
									if (num < 10.0 && base.method_67(ref this.contact_1) < 90f)
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedDefensive);
										return;
									}
								}
							}
							else
							{
								if (this.activeUnit_0.method_37(this.contact_1, 0f) < 50f)
								{
									this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedDefensive);
									return;
								}
								Weapon weapon = this.activeUnit_0.vmethod_89().method_15(this.contact_1);
								if (!Information.IsNothing(weapon))
								{
									float num2 = weapon.method_181(this.activeUnit_0, this.contact_1, false, this.activeUnit_0.doctrine_0, false);
									if (this.activeUnit_0.method_37(this.contact_1, 0f) < num2 * 2f)
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedDefensive);
										return;
									}
								}
							}
						}
						else if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
						{
							this.activeUnit_0.vmethod_109(this.activeUnit_0._ActiveUnitStatus_3);
						}
					}
					if (this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
					{
						if (this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.Refuelling)
						{
							ActiveUnit activeUnit_ = this.activeUnit_0;
							Mission.Flight flight_ = null;
							Exception ex = null;
							if (Class522.smethod_8(activeUnit_, flight_, ref ex))
							{
								this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.WaitForPathfinder);
							}
							else if (!this.activeUnit_0.method_85())
							{
								if (!this.activeUnit_0.scenario_0.FifthSecondIsChangingOnThisPulse || this.activeUnit_0.method_85() || this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || !base.method_84())
								{
									if (this.activeUnit_0.vmethod_85().method_46())
									{
										Doctrine.Enum64? enum2 = this.activeUnit_0.doctrine_0.method_83(this.activeUnit_0.scenario_0, false, null, false, false);
										b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
										bool? flag2;
										bool? flag = flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null);
										if (((flag2 == null || flag.GetValueOrDefault()) ? (flag & !Information.IsNothing(this.vmethod_3())) : new bool?(false)).GetValueOrDefault())
										{
											bool flag3 = true;
											if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
											{
												Strike strike = (Strike)this.activeUnit_0.vmethod_101();
												if (strike.int_13 > 0 || strike.int_12 > 0)
												{
													float num3 = Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null));
													if (num3 > (float)strike.int_13 || num3 < (float)strike.int_12)
													{
														flag3 = false;
													}
												}
											}
											if (flag3)
											{
												this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
												return;
											}
										}
										else
										{
											if (this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.LocalizationRun && !Information.IsNothing(this.vmethod_3()))
											{
												if (Information.IsNothing(this.vmethod_3().method_112()))
												{
													this.activeUnit_0.vmethod_85().vmethod_9();
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
												}
												else if (!GeoPoint.smethod_3(this.activeUnit_0.vmethod_85().method_4()[0].imethod_2(), this.activeUnit_0.vmethod_85().method_4()[0].imethod_0(), this.vmethod_3().method_112(), true))
												{
													this.activeUnit_0.vmethod_85().vmethod_9();
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
												}
												else
												{
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
												}
												return;
											}
											this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
											return;
										}
									}
									if (!Information.IsNothing(this.vmethod_3()))
									{
										Contact_Base.ContactType contactType_2 = this.vmethod_3().contactType_0;
										if (contactType_2 <= Contact_Base.ContactType.Missile)
										{
											if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
											{
												this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
											}
										}
										else
										{
											bool flag4 = true;
											if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
											{
												Strike strike2 = (Strike)this.activeUnit_0.vmethod_101();
												if (strike2.int_13 > 0 || strike2.int_12 > 0)
												{
													float num4 = Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null));
													if (num4 > (float)strike2.int_13 || num4 < (float)strike2.int_12)
													{
														flag4 = false;
													}
												}
											}
											if (flag4)
											{
												this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
												return;
											}
										}
									}
									if (this.activeUnit_0.method_120())
									{
										if (this.activeUnit_0.vmethod_65(false).method_143() == Group.GroupType.AirGroup && this.activeUnit_0.vmethod_65(false).vmethod_108() == ActiveUnit._ActiveUnitStatus.FormingUp)
										{
											this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.FormingUp);
											return;
										}
										if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.FormingUp)
										{
											this.vmethod_10(float_3, false, true);
										}
									}
									if (this.activeUnit_0.vmethod_101() != null && this.activeUnit_0.vmethod_101().method_12())
									{
										if (this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.RTB_MissionOver)
										{
											switch (this.activeUnit_0.vmethod_101()._MissionClass_0)
											{
											case Mission._MissionClass.Strike:
												this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Tasked);
												return;
											case Mission._MissionClass.Patrol:
												if (!Information.IsNothing(this.vmethod_3()))
												{
													Contact_Base.ContactType contactType_3 = this.vmethod_3().contactType_0;
													if (contactType_3 > Contact_Base.ContactType.Missile)
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
														return;
													}
													if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
													}
												}
												this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPatrol);
												return;
											case Mission._MissionClass.Support:
												if (!Information.IsNothing(this.vmethod_3()))
												{
													Doctrine.Enum59? enum3 = this.activeUnit_0.doctrine_0.method_162(this.activeUnit_0.scenario_0, false, false, false);
													b = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
													if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
														return;
													}
												}
												this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnSupportMission);
												return;
											case Mission._MissionClass.Ferry:
												if (!Information.IsNothing(this.vmethod_3()))
												{
													Doctrine.Enum59? enum3 = this.activeUnit_0.doctrine_0.method_162(this.activeUnit_0.scenario_0, false, false, false);
													b = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
													if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
													{
														this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
														return;
													}
												}
												this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnFerryMission);
												return;
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
										else
										{
											this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
										}
									}
									if (this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.RTB_MissionOver)
									{
										if (this.activeUnit_0.vmethod_110() != ActiveUnit._ActiveUnitFuelState.IgnoreBingoAndJoker)
										{
											if (this.activeUnit_0.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IgnoreWinchesterAndShotgun)
											{
												if (this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.Unassigned)
												{
													this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
												}
											}
										}
									}
								}
							}
						}
					}
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 200348", ex2.Message);
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x001B505C File Offset: 0x001B325C
		private void method_114()
		{
			if (this.activeUnit_0.vmethod_87().vmethod_10() == null)
			{
				if (this.vmethod_3().contactType_0 == Contact_Base.ContactType.Submarine)
				{
					ActiveUnit_Sensory activeUnit_Sensory = this.activeUnit_0.vmethod_88();
					bool activeCapableSensorsOnly = false;
					bool emmittingSensorsOnly = false;
					bool onlyOperatingSensors = true;
					bool onlySensorsScanningThisPulse = false;
					Sensor[] array = null;
					List<Sensor> list = activeUnit_Sensory.method_55(activeCapableSensorsOnly, emmittingSensorsOnly, onlyOperatingSensors, onlySensorsScanningThisPulse, ref array, true);
					float num;
					if (list.Count > 0)
					{
						num = list[0].float_0;
					}
					else
					{
						num = 0f;
					}
					if ((double)this.activeUnit_0.method_36(this.vmethod_3()) > Math.Max(3.0, (double)num * 1.1))
					{
						this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
						return;
					}
					ActiveUnit_AI activeUnit_AI = this.activeUnit_0.vmethod_86();
					Unit unit_ = this.vmethod_3();
					float? nullable_ = null;
					float float_ = 0f;
					float? nullable_2 = null;
					float float_2 = this.activeUnit_0.vmethod_9();
					ActiveUnit.Throttle throttle_ = ActiveUnit.Throttle.Loiter;
					float? nullable_3 = new float?(0.1f);
					bool bool_ = false;
					bool bool_2 = false;
					bool flag = false;
					if (activeUnit_AI.method_61(unit_, nullable_, float_, nullable_2, float_2, throttle_, nullable_3, bool_, bool_2, ref flag))
					{
						this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
						return;
					}
					this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
					this.activeUnit_0.vmethod_87().method_13();
					return;
				}
				else
				{
					if (this.activeUnit_0.vmethod_84() != ActiveUnit.Throttle.Full)
					{
						this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Full, null);
					}
					ActiveUnit_AI activeUnit_AI2 = this.activeUnit_0.vmethod_86();
					Unit unit_2 = this.vmethod_3();
					float? nullable_4 = null;
					float float_3 = 0f;
					float? nullable_5 = null;
					float float_4 = this.activeUnit_0.vmethod_9();
					ActiveUnit.Throttle throttle_2 = ActiveUnit.Throttle.Full;
					float? nullable_6 = new float?(0.1f);
					bool bool_3 = false;
					bool bool_4 = false;
					bool flag = false;
					if (!activeUnit_AI2.method_61(unit_2, nullable_4, float_3, nullable_5, float_4, throttle_2, nullable_6, bool_3, bool_4, ref flag))
					{
						this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
					}
				}
			}
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x001B5220 File Offset: 0x001B3420
		public override void vmethod_26(float float_3)
		{
			if (this.activeUnit_0 != null && !this.activeUnit_0.method_82())
			{
				try
				{
					ActiveUnit._ActiveUnitStatus activeUnitStatus = this.activeUnit_0.vmethod_108();
					this.activeUnit_0.vmethod_87().bool_1 = false;
					if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
					{
						this.activeUnit_0.vmethod_87().vmethod_11(null);
						this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
						this.vmethod_23(float_3);
					}
					else if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
					{
						bool flag = true;
						GeoPoint intermediateTargetPoint = base.method_18();
						ActiveUnit_DockingOps activeUnit_DockingOps = this.activeUnit_0.vmethod_93();
						bool bool_ = true;
						List<Mission> list_ = null;
						string text = "";
						List<ActiveUnit> list = activeUnit_DockingOps.method_53(bool_, list_, ref text);
						if (this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse || Information.IsNothing(this.activeUnit_0.vmethod_93().method_6()))
						{
							if (this.activeUnit_0.vmethod_93().method_6() != null && list.Contains(this.activeUnit_0.vmethod_93().method_6()))
							{
								flag = (this.activeUnit_0.vmethod_93().method_55(this.activeUnit_0.vmethod_93().method_6()) == ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Success || this.activeUnit_0.vmethod_93().method_54(intermediateTargetPoint, null, null, false, null).Item1 == ActiveUnit_DockingOps.Enum32.const_1);
							}
							else if (list.Count > 0)
							{
								flag = (this.activeUnit_0.vmethod_93().method_54(intermediateTargetPoint, null, null, false, new int?(100)).Item1 == ActiveUnit_DockingOps.Enum32.const_1);
							}
							else
							{
								if (!Information.IsNothing(this.activeUnit_0.vmethod_93().method_6()))
								{
									this.activeUnit_0.vmethod_93().method_26();
								}
								flag = false;
							}
						}
						if (this.activeUnit_0.vmethod_93().method_6() != null && flag)
						{
							ActiveUnit activeUnit = this.activeUnit_0.vmethod_93().method_6();
							if (this.activeUnit_0.method_122() && activeUnit.method_120() && this.activeUnit_0.vmethod_65(false) == activeUnit.vmethod_65(false))
							{
								activeUnit.vmethod_69(ActiveUnit.Enum28.const_1, activeUnit.method_32(this.activeUnit_0));
								activeUnit.vmethod_134(ActiveUnit.Throttle.Full, null);
								this.activeUnit_0.vmethod_71(Math.Max(5f, activeUnit.vmethod_40() - 10f));
								this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_87().vmethod_41(0f, (float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))));
							}
							else
							{
								if (activeUnit.vmethod_90().vmethod_1())
								{
									this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, this.activeUnit_0.method_32(activeUnit));
								}
								else
								{
									this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, this.activeUnit_0.method_34(activeUnit.method_56().Value, activeUnit.method_58().Value));
								}
								if ((double)this.activeUnit_0.method_36(activeUnit) < 0.1)
								{
									this.activeUnit_0.vmethod_71(activeUnit.vmethod_40());
									this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_87().vmethod_41(0f, (float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))));
								}
								else if ((float)(this.activeUnit_0.vmethod_87().vmethod_40(0f, ActiveUnit.Throttle.Cruise, false) - 5) < activeUnit.vmethod_70())
								{
									float num = (float)this.activeUnit_0.vmethod_87().vmethod_40(0f, ActiveUnit.Throttle.Full, false);
									ActiveUnit.Throttle newThrottleSetting = ActiveUnit.Throttle.Full;
									if (num - (float)5 < activeUnit.vmethod_70())
									{
										newThrottleSetting = ActiveUnit.Throttle.Flank;
									}
									this.activeUnit_0.vmethod_134(newThrottleSetting, null);
								}
								else
								{
									this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
								}
							}
						}
						else
						{
							if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling)
							{
								this.activeUnit_0.vmethod_109(this.activeUnit_0._ActiveUnitStatus_2);
							}
							if (this.activeUnit_0.vmethod_93().method_8() == ActiveUnit_DockingOps._DockingOpsCondition.ManoeuveringToRefuel || this.activeUnit_0.vmethod_93().method_8() == ActiveUnit_DockingOps._DockingOpsCondition.Replenishing)
							{
								this.activeUnit_0.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
							}
						}
					}
					else if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.Refuelling)
					{
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.vmethod_93().method_6().vmethod_68());
						this.activeUnit_0.vmethod_71(this.activeUnit_0.vmethod_93().method_6().vmethod_70());
						this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_87().vmethod_41(0f, (float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))));
					}
					else if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.WaitForPathfinder)
					{
						this.activeUnit_0.vmethod_71(0f);
						this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.FullStop, new float?(0f));
					}
					else
					{
						if (activeUnitStatus != ActiveUnit._ActiveUnitStatus.RTB && activeUnitStatus != ActiveUnit._ActiveUnitStatus.RTB_Manual)
						{
							if (activeUnitStatus != ActiveUnit._ActiveUnitStatus.RTB_MissionOver)
							{
								if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
								{
									if (this.vmethod_3() == null)
									{
										return;
									}
									if (this.activeUnit_0.method_120())
									{
										if (this.activeUnit_0.method_122())
										{
											Contact_Base.ContactType contactType_ = this.vmethod_3().contactType_0;
											if (contactType_ > Contact_Base.ContactType.Missile)
											{
												if (contactType_ != Contact_Base.ContactType.Orbital)
												{
													this.vmethod_19(float_3);
													this.method_114();
													goto IL_618;
												}
											}
											this.activeUnit_0.vmethod_85().vmethod_16(float_3);
										}
										else if (this.activeUnit_0.vmethod_101() == this.activeUnit_0.vmethod_65(false).vmethod_101())
										{
											if (this.activeUnit_0.vmethod_90().vmethod_1())
											{
												this.activeUnit_0.vmethod_85().vmethod_21(float_3);
											}
										}
										else
										{
											this.vmethod_19(float_3);
											this.method_114();
										}
									}
									else
									{
										this.vmethod_19(float_3);
										this.method_114();
									}
									IL_618:
									if (!this.activeUnit_0.method_121() && this.activeUnit_0.vmethod_87().vmethod_10() == null)
									{
										float? num2 = null;
										ActiveUnit.Throttle? throttle;
										if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
										{
											Class343 @class = (Class343)this.activeUnit_0.vmethod_101();
											if (!Information.IsNothing(@class.imethod_38()))
											{
												num2 = @class.imethod_40();
												if (!Information.IsNothing(num2))
												{
													float num3 = this.activeUnit_0.method_36(this.vmethod_3());
													if (((num2 != null) ? new bool?(num3 > num2.GetValueOrDefault()) : null).GetValueOrDefault())
													{
														throttle = new ActiveUnit.Throttle?(@class.imethod_34());
													}
													else
													{
														throttle = @class.imethod_38();
													}
												}
												else
												{
													throttle = @class.imethod_38();
												}
											}
										}
										if (!Information.IsNothing(throttle))
										{
											this.activeUnit_0.vmethod_134(throttle.Value, null);
										}
										else if (this.vmethod_3().contactType_0 == Contact_Base.ContactType.Submarine)
										{
											ActiveUnit_AI activeUnit_AI = this.activeUnit_0.vmethod_86();
											Unit unit_ = this.vmethod_3();
											float? nullable_ = null;
											float float_4 = 0f;
											float? nullable_2 = null;
											float float_5 = this.activeUnit_0.vmethod_9();
											ActiveUnit.Throttle throttle_ = ActiveUnit.Throttle.Loiter;
											float? nullable_3 = new float?(0.1f);
											bool bool_2 = false;
											bool bool_3 = false;
											bool flag2 = false;
											if (activeUnit_AI.method_61(unit_, nullable_, float_4, nullable_2, float_5, throttle_, nullable_3, bool_2, bool_3, ref flag2))
											{
												this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
											}
											else
											{
												this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
												this.activeUnit_0.vmethod_87().method_13();
											}
										}
										else
										{
											if (this.activeUnit_0.vmethod_84() != ActiveUnit.Throttle.Full)
											{
												this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Full, null);
											}
											ActiveUnit_AI activeUnit_AI2 = this.activeUnit_0.vmethod_86();
											Unit unit_2 = this.vmethod_3();
											float? nullable_4 = null;
											float float_6 = 0f;
											float? nullable_5 = null;
											float float_7 = this.activeUnit_0.vmethod_9();
											ActiveUnit.Throttle throttle_2 = ActiveUnit.Throttle.Full;
											float? nullable_6 = new float?(0.1f);
											bool bool_4 = false;
											bool bool_5 = false;
											bool flag2 = false;
											if (!activeUnit_AI2.method_61(unit_2, nullable_4, float_6, nullable_5, float_7, throttle_2, nullable_6, bool_4, bool_5, ref flag2))
											{
												this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
											}
										}
									}
									return;
								}
								else if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.OnPlottedCourse)
								{
									if (this.activeUnit_0.method_68() && !this.activeUnit_0.vmethod_85().method_45())
									{
										if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive && this.activeUnit_0.vmethod_85().method_4().Length == 1 && this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.PatrolStation)
										{
											this.activeUnit_0.vmethod_85().vmethod_9();
											return;
										}
										Class343 class2 = (Class343)this.activeUnit_0.vmethod_101();
										if (!this.activeUnit_0.vmethod_85().method_37(ref class2.list_5, ref class2.list_14, ref class2.list_10, 30f, false))
										{
											this.activeUnit_0.vmethod_85().vmethod_9();
											this.activeUnit_0.vmethod_85().vmethod_23(float_3, false);
										}
									}
									this.activeUnit_0.vmethod_85().vmethod_16(float_3);
									if (!this.activeUnit_0.vmethod_85().method_47() && this.activeUnit_0.vmethod_87().vmethod_1() != ActiveUnit_Kinematics.UnitThrottlePreset.FullStop && this.activeUnit_0.vmethod_70() != 0f)
									{
										this.activeUnit_0.vmethod_87().vmethod_11(null);
										this.activeUnit_0.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.None);
										this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.FullStop, null);
										this.activeUnit_0.vmethod_109(this.activeUnit_0._ActiveUnitStatus_1);
										return;
									}
									if (this.activeUnit_0.vmethod_85().method_47() && this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.LocalizationRun && !Information.IsNothing(this.vmethod_3()) && !Information.IsNothing(this.vmethod_3().method_112()) && !this.activeUnit_0.vmethod_45(this.vmethod_3().method_112(), this.activeUnit_0.scenario_0, true))
									{
										this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Full, null);
										if (!base.method_60(this.vmethod_3(), new float?(this.activeUnit_0.method_36(this.vmethod_3())), 0f, this.activeUnit_0.vmethod_40(), this.activeUnit_0.vmethod_9(), null, true, true, false))
										{
											this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
										}
										return;
									}
									if (this.activeUnit_0.vmethod_87().vmethod_10() == null && !this.activeUnit_0.vmethod_85().vmethod_3())
									{
										if (this.activeUnit_0.method_68())
										{
											Class343 class3 = (Class343)this.activeUnit_0.vmethod_101();
											if (this.activeUnit_0.vmethod_85().method_40(ref class3.list_5, ref class3.list_11, ref class3.list_7, 2, false, false))
											{
												this.activeUnit_0.vmethod_134(class3.imethod_36(), null);
											}
											else
											{
												this.activeUnit_0.vmethod_134(class3.imethod_34(), null);
											}
										}
										else if (this.activeUnit_0.method_70())
										{
											Class340 class4 = (Class340)this.activeUnit_0.vmethod_101();
											if (this.activeUnit_0.vmethod_85().method_40(ref class4.list_5, ref class4.list_13, ref class4.list_8, 2, false, false))
											{
												this.activeUnit_0.vmethod_134(class4.throttle_3, null);
											}
											else
											{
												this.activeUnit_0.vmethod_134(class4.throttle_2, null);
											}
										}
										else if (this.activeUnit_0.method_71())
										{
											Class341 class5 = (Class341)this.activeUnit_0.vmethod_101();
											if (this.activeUnit_0.vmethod_85().method_40(ref class5.list_5, ref class5.list_11, ref class5.list_7, 2, false, false))
											{
												this.activeUnit_0.vmethod_134(class5.throttle_3, null);
											}
											else
											{
												this.activeUnit_0.vmethod_134(class5.throttle_2, null);
											}
										}
										else if (this.activeUnit_0.method_73())
										{
											FerryMission ferryMission = (FerryMission)this.activeUnit_0.vmethod_101();
											if (this.activeUnit_0.vmethod_87().vmethod_10() == null)
											{
												if (ferryMission.nullable_6 != null)
												{
													this.activeUnit_0.vmethod_134(ferryMission.nullable_6.Value, null);
												}
												else
												{
													this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
												}
											}
										}
										else
										{
											this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
										}
									}
									if (this.activeUnit_0.vmethod_86().method_77())
									{
										float num4 = float.MaxValue;
										try
										{
											foreach (ActiveUnit activeUnit2 in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
											{
												if (!activeUnit2.method_122() && !activeUnit2.vmethod_85().vmethod_3() && !activeUnit2.vmethod_85().vmethod_20() && activeUnit2.vmethod_70() > 0f)
												{
													if (activeUnit2.vmethod_87().bool_1 && !activeUnit2.method_122())
													{
														if ((double)activeUnit2.vmethod_70() * 0.8 < (double)num4)
														{
															num4 = (float)((double)activeUnit2.vmethod_70() * 0.8);
														}
													}
													else if (activeUnit2.vmethod_70() / 2f < num4)
													{
														num4 = activeUnit2.vmethod_70() / 2f;
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
										if (this.activeUnit_0.vmethod_85().vmethod_3())
										{
											this.activeUnit_0.vmethod_85().vmethod_6(new float?(num4));
										}
										else
										{
											this.activeUnit_0.vmethod_71(num4);
										}
									}
									else if (this.activeUnit_0.vmethod_87().vmethod_10() == null && this.activeUnit_0.method_120())
									{
										if (this.activeUnit_0.method_122())
										{
											float num5 = float.MaxValue;
											try
											{
												foreach (ActiveUnit activeUnit3 in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
												{
													if (activeUnit3 != this.activeUnit_0)
													{
														if (activeUnit3.vmethod_87().bool_1)
														{
															num5 = activeUnit3.vmethod_70();
														}
														else if (activeUnit3.vmethod_85().vmethod_3())
														{
															if (!Information.IsNothing(activeUnit3.vmethod_85().vmethod_5()))
															{
																num5 = activeUnit3.vmethod_85().vmethod_5().Value;
															}
														}
														else
														{
															float num6 = (float)activeUnit3.vmethod_87().vmethod_40(activeUnit3.vmethod_14(false), ActiveUnit.Throttle.Cruise, false);
															if (num6 < num5)
															{
																num5 = num6;
															}
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
											if (this.activeUnit_0.vmethod_85().vmethod_3())
											{
												this.activeUnit_0.vmethod_85().vmethod_6(new float?(num5));
											}
											else
											{
												this.activeUnit_0.vmethod_71(num5);
											}
										}
										else if (this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_3() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_5()))
										{
											if (this.activeUnit_0.vmethod_85().vmethod_3())
											{
												this.activeUnit_0.vmethod_85().vmethod_6(this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_5());
											}
											else
											{
												this.activeUnit_0.vmethod_71(this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_5().Value);
											}
										}
										else if (this.activeUnit_0.vmethod_85().vmethod_3())
										{
											this.activeUnit_0.vmethod_85().vmethod_6(new float?(this.activeUnit_0.vmethod_65(false).vmethod_70()));
										}
										else
										{
											this.activeUnit_0.vmethod_71(this.activeUnit_0.vmethod_65(false).vmethod_70());
										}
									}
									if (this.activeUnit_0.method_70())
									{
										this.method_115(float_3);
									}
									if (this.activeUnit_0.vmethod_85().vmethod_3())
									{
										this.activeUnit_0.vmethod_85().method_1(float_3);
									}
									else
									{
										this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_87().vmethod_41(this.activeUnit_0.vmethod_14(false), (float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))));
									}
									if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.MineClearing)
									{
										if (this.activeUnit_0.scenario_0.FifteenthSecondIsChangingOnThisPulse)
										{
											Ship_AI.Class361 class6 = new Ship_AI.Class361(class6);
											class6.ship_AI_0 = this;
											Class341 class7 = (Class341)this.activeUnit_0.vmethod_101();
											class6.list_0 = class7.list_5;
											class6.concurrentBag_0 = new ConcurrentBag<UnguidedWeapon>();
											class6.observableDictionary_0 = this.activeUnit_0.scenario_0.vmethod_20();
											Parallel.ForEach<string>(this.activeUnit_0.vmethod_7(false).hashSet_0, new Action<string>(class6.method_0));
											if (class6.concurrentBag_0.Count > 0)
											{
												UnguidedWeapon unguidedWeapon = Enumerable.ElementAtOrDefault<UnguidedWeapon>(Enumerable.OrderBy<UnguidedWeapon, double>(Enumerable.Where<UnguidedWeapon>(Enumerable.ToList<UnguidedWeapon>(class6.concurrentBag_0), (Ship_AI._Closure$__.$I13-1 == null) ? (Ship_AI._Closure$__.$I13-1 = new Func<UnguidedWeapon, bool>(Ship_AI._Closure$__.$I.method_0)) : Ship_AI._Closure$__.$I13-1), new Func<UnguidedWeapon, double>(this.method_121)), 0);
												float num7 = this.activeUnit_0.method_36(unguidedWeapon);
												base.method_76(unguidedWeapon, num7);
												if (num7 < 3f)
												{
													this.activeUnit_0.vmethod_71(num7 + 1f);
												}
											}
											else if (Information.IsNothing(this.activeUnit_0.vmethod_87().vmethod_10()))
											{
												this.activeUnit_0.vmethod_71(3f);
												this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_87().vmethod_41(this.activeUnit_0.vmethod_14(false), (float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))));
											}
										}
										try
										{
											foreach (ActiveUnit activeUnit4 in this.activeUnit_0.scenario_0.method_42())
											{
												if (!Information.IsNothing(activeUnit4) && activeUnit4.bool_5 && (((Submarine)activeUnit4)._SubmarineType_0 == Submarine._SubmarineType.ROV || ((Submarine)activeUnit4)._SubmarineType_0 == Submarine._SubmarineType.UUV) && activeUnit4.vmethod_127() && activeUnit4.vmethod_93().method_11(false) == this.activeUnit_0)
												{
													ActiveUnit._ActiveUnitFuelState activeUnitFuelState = activeUnit4.vmethod_61(null, null);
													if (activeUnitFuelState != ActiveUnit._ActiveUnitFuelState.IsBingo)
													{
														if (activeUnitFuelState != ActiveUnit._ActiveUnitFuelState.IsJoker)
														{
															continue;
														}
													}
													if ((float)activeUnit4.vmethod_87().vmethod_40(activeUnit4.vmethod_14(false), ActiveUnit.Throttle.Cruise, false) >= 5f)
													{
														this.activeUnit_0.vmethod_71((float)(0.5 * (double)activeUnit4.vmethod_87().vmethod_40(activeUnit4.vmethod_14(false), ActiveUnit.Throttle.Cruise, false)));
													}
													else
													{
														this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
													}
													this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.method_32(activeUnit4));
													break;
												}
											}
										}
										finally
										{
											List<ActiveUnit>.Enumerator enumerator3;
											((IDisposable)enumerator3).Dispose();
										}
									}
									return;
								}
								else
								{
									if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.OnPatrol)
									{
										if (Information.IsNothing(this.activeUnit_0.vmethod_101()))
										{
											activeUnitStatus = ActiveUnit._ActiveUnitStatus.Unassigned;
										}
										else if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
										{
											Class343 class8 = (Class343)this.activeUnit_0.vmethod_101();
											if (!Information.IsNothing(class8))
											{
												if (this.activeUnit_0.method_120())
												{
													if (this.activeUnit_0.method_122())
													{
														if (this.activeUnit_0.vmethod_85().method_46())
														{
															if (!this.activeUnit_0.vmethod_65(false).vmethod_85().method_37(ref class8.list_5, ref class8.list_14, ref class8.list_10, 30f, false))
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
													else if (this.activeUnit_0.vmethod_90().vmethod_1())
													{
														this.activeUnit_0.vmethod_85().vmethod_21(float_3);
													}
												}
												else if (this.activeUnit_0.vmethod_85().method_46())
												{
													if (!this.activeUnit_0.vmethod_85().method_37(ref class8.list_5, ref class8.list_14, ref class8.list_10, 30f, false))
													{
														this.activeUnit_0.vmethod_85().vmethod_23(float_3, false);
													}
													this.activeUnit_0.vmethod_85().vmethod_16(float_3);
												}
												else
												{
													this.activeUnit_0.vmethod_85().vmethod_23(float_3, false);
												}
												if (!Information.IsNothing(this.activeUnit_0.vmethod_101()))
												{
													GlobalVariables.PatrolType patrolType_ = ((Class343)this.activeUnit_0.vmethod_101()).patrolType_0;
													if (patrolType_ == GlobalVariables.PatrolType.ASW || patrolType_ == GlobalVariables.PatrolType.SeaControl)
													{
														Class343 class9 = (Class343)this.activeUnit_0.vmethod_101();
														if (this.activeUnit_0.vmethod_85().method_40(ref class9.list_5, ref class9.list_11, ref class9.list_7, 2, false, false))
														{
															this.activeUnit_0.vmethod_87().method_13();
														}
													}
												}
											}
											return;
										}
									}
									if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.OnSupportMission)
									{
										if (Information.IsNothing(this.activeUnit_0.vmethod_101()))
										{
											activeUnitStatus = ActiveUnit._ActiveUnitStatus.Unassigned;
										}
										else if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support)
										{
											if (Information.IsNothing(this.activeUnit_0.vmethod_101()))
											{
												activeUnitStatus = ActiveUnit._ActiveUnitStatus.Unassigned;
											}
											else
											{
												if (!this.activeUnit_0.method_120())
												{
													this.activeUnit_0.vmethod_85().vmethod_14(float_3, this.activeUnit_0.vmethod_85().method_15());
													return;
												}
												if (this.activeUnit_0.method_122())
												{
													this.activeUnit_0.vmethod_85().vmethod_14(float_3, this.activeUnit_0.vmethod_85().method_15());
													return;
												}
												if (this.activeUnit_0.vmethod_90().vmethod_1())
												{
													this.activeUnit_0.vmethod_85().vmethod_21(float_3);
													return;
												}
											}
										}
									}
									if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.OnFerryMission)
									{
										if (Information.IsNothing(this.activeUnit_0.vmethod_101()))
										{
											activeUnitStatus = ActiveUnit._ActiveUnitStatus.Unassigned;
										}
										else if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Ferry)
										{
											FerryMission ferryMission2 = (FerryMission)this.activeUnit_0.vmethod_101();
											if (this.activeUnit_0.vmethod_87().vmethod_10() == null && ferryMission2.nullable_6 != null)
											{
												ActiveUnit.Throttle value = ferryMission2.nullable_6.Value;
											}
											if (!this.activeUnit_0.method_121())
											{
												if (!Information.IsNothing(this.activeUnit_0.vmethod_93().method_2()))
												{
													this.vmethod_29(float_3);
												}
												else
												{
													string str = "";
													if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
													{
														str = " (" + this.activeUnit_0.string_2 + ")";
													}
													this.activeUnit_0.scenario_0.method_59("Ship: " + this.activeUnit_0.Name + str + " is assigned to a ferry mission but it cannot dock at the desired destination. Unassigning ship and returning to nearest base.", this.activeUnit_0.Name + " cannot dock at destination; aborting ferry", LoggedMessage.MessageType.DockingOps, 0, null, this.activeUnit_0.vmethod_7(false), default(Geopoint_Struct));
													ActiveUnit activeUnit_ = this.activeUnit_0;
													Mission value2 = null;
													bool setMissionOnly = false;
													Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
													activeUnit_.vmethod_102(value2, setMissionOnly, ref missionAssignmentAttemptResult);
													this.activeUnit_0.vmethod_93().method_5(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
												}
											}
											else
											{
												this.activeUnit_0.vmethod_85().vmethod_21(float_3);
											}
										}
									}
									if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.Tasked)
									{
										if (this.bool_2)
										{
											base.method_22();
											return;
										}
										if (this.activeUnit_0.method_70())
										{
											this.method_115(float_3);
											return;
										}
										if (this.activeUnit_0.method_72())
										{
											this.method_118(float_3);
											return;
										}
										if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.MineClearing)
										{
											Ship_AI.Class362 class10 = new Ship_AI.Class362(class10);
											class10.ship_AI_0 = this;
											Class341 class11 = (Class341)this.activeUnit_0.vmethod_101();
											class10.observableDictionary_0 = this.activeUnit_0.scenario_0.vmethod_20();
											class10.list_0 = class11.list_5;
											class10.concurrentBag_0 = new ConcurrentBag<UnguidedWeapon>();
											Parallel.ForEach<string>(this.activeUnit_0.vmethod_7(false).hashSet_0, new Action<string>(class10.method_0));
											if (class10.concurrentBag_0.Count > 0 && this.activeUnit_0.vmethod_95().Count > 0)
											{
												UnguidedWeapon unguidedWeapon2 = Enumerable.ElementAtOrDefault<UnguidedWeapon>(Enumerable.OrderBy<UnguidedWeapon, double>(Enumerable.Where<UnguidedWeapon>(Enumerable.ToList<UnguidedWeapon>(class10.concurrentBag_0), (Ship_AI._Closure$__.$I13-4 == null) ? (Ship_AI._Closure$__.$I13-4 = new Func<UnguidedWeapon, bool>(Ship_AI._Closure$__.$I.method_1)) : Ship_AI._Closure$__.$I13-4), new Func<UnguidedWeapon, double>(this.method_122)), 0);
												float float_8 = this.activeUnit_0.method_36(unguidedWeapon2);
												base.method_76(unguidedWeapon2, float_8);
												this.activeUnit_0.vmethod_85().vmethod_16(float_3);
											}
											else if (this.activeUnit_0.method_120())
											{
												if (this.activeUnit_0.method_122())
												{
													if (this.activeUnit_0.vmethod_85().method_46())
													{
														if (!this.activeUnit_0.vmethod_65(false).vmethod_85().method_37(ref class11.list_5, ref class11.list_14, ref class11.list_10, 30f, false))
														{
															this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_22(class11.list_5);
														}
														this.activeUnit_0.vmethod_85().vmethod_16(float_3);
													}
													else
													{
														this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_22(class11.list_5);
													}
												}
												else if (this.activeUnit_0.vmethod_90().vmethod_1())
												{
													this.activeUnit_0.vmethod_85().vmethod_21(float_3);
												}
											}
											else if (this.activeUnit_0.vmethod_85().method_46())
											{
												if (!this.activeUnit_0.vmethod_85().method_37(ref class11.list_5, ref class11.list_14, ref class11.list_10, 30f, false))
												{
													this.activeUnit_0.vmethod_85().vmethod_22(class11.list_5);
												}
												this.activeUnit_0.vmethod_85().vmethod_16(float_3);
											}
											else
											{
												this.activeUnit_0.vmethod_85().vmethod_22(class11.list_5);
											}
											if (this.activeUnit_0.vmethod_87().vmethod_10() == null)
											{
												if (this.activeUnit_0.vmethod_85().method_40(ref class11.list_5, ref class11.list_11, ref class11.list_7, 2, false, false))
												{
													this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
												}
												else
												{
													this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
												}
											}
											return;
										}
										if (Information.IsNothing(this.vmethod_3()) && this.activeUnit_0.vmethod_87().vmethod_10() == null)
										{
											this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.FullStop, null);
										}
									}
									if (this.activeUnit_0.method_120())
									{
										if (!this.activeUnit_0.method_122() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_93().method_6() == this.activeUnit_0)
										{
											ActiveUnit._ActiveUnitStatus activeUnitStatus2 = this.activeUnit_0.vmethod_65(false).method_147().vmethod_108();
											if (activeUnitStatus2 != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
											{
												if (activeUnitStatus2 != ActiveUnit._ActiveUnitStatus.Refuelling)
												{
													if (this.activeUnit_0.vmethod_90().vmethod_1())
													{
														this.activeUnit_0.vmethod_85().vmethod_21(float_3);
													}
												}
												else
												{
													this.activeUnit_0.vmethod_69(this.activeUnit_0.vmethod_65(false).method_147().vmethod_78(), this.activeUnit_0.vmethod_65(false).method_147().vmethod_68());
													this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
												}
											}
											else
											{
												this.activeUnit_0.vmethod_69(this.activeUnit_0.vmethod_65(false).method_147().vmethod_78(), this.activeUnit_0.method_32(this.activeUnit_0.vmethod_65(false).method_147()));
												this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Full, null);
											}
										}
										else if (this.activeUnit_0.vmethod_90().vmethod_1())
										{
											this.activeUnit_0.vmethod_85().vmethod_21(float_3);
										}
										return;
									}
									if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.Unassigned)
									{
										if (!Information.IsNothing(this.vmethod_5()))
										{
											this.vmethod_23(float_3);
										}
										else
										{
											this.activeUnit_0.vmethod_71(0f);
										}
									}
									return;
								}
							}
						}
						ActiveUnit_DockingOps._DockingOpsCondition dockingOpsCondition = this.activeUnit_0.vmethod_93().method_8();
						if (dockingOpsCondition != ActiveUnit_DockingOps._DockingOpsCondition.Underway)
						{
							if (dockingOpsCondition == ActiveUnit_DockingOps._DockingOpsCondition.RTB)
							{
								if (this.activeUnit_0.method_120())
								{
									this.activeUnit_0.method_129(false, true, false);
								}
								this.vmethod_29(float_3);
							}
						}
						else
						{
							this.activeUnit_0.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.RTB);
							this.vmethod_29(float_3);
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100780", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x001B7164 File Offset: 0x001B5364
		private void method_115(float float_3)
		{
			Class340 @class = (Class340)this.activeUnit_0.vmethod_101();
			if (this.activeUnit_0.method_120())
			{
				if (this.activeUnit_0.method_122())
				{
					if (this.activeUnit_0.vmethod_85().method_46())
					{
						if (!this.activeUnit_0.vmethod_65(false).vmethod_85().method_37(ref @class.list_5, ref @class.list_16, ref @class.list_11, 30f, false))
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
				if (!this.activeUnit_0.vmethod_85().method_37(ref @class.list_5, ref @class.list_16, ref @class.list_11, 30f, false))
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
				if (this.activeUnit_0.vmethod_85().method_40(ref @class.list_5, ref @class.list_13, ref @class.list_8, 2, false, false))
				{
					this.activeUnit_0.vmethod_134(@class.throttle_3, null);
					return;
				}
				this.activeUnit_0.vmethod_134(@class.throttle_2, null);
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x001B7350 File Offset: 0x001B5550
		private bool method_116(GeoPoint geoPoint_2, Class338 class338_0)
		{
			List<GeoPoint> list = this.method_117(geoPoint_2, class338_0);
			return list != null && Enumerable.Any<GeoPoint>(list);
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x001B7378 File Offset: 0x001B5578
		private List<GeoPoint> method_117(GeoPoint geoPoint_2, Class338 class338_0)
		{
			List<GeoPoint> result;
			if (!GeoPoint.smethod_4(geoPoint_2.imethod_2(), geoPoint_2.imethod_0(), class338_0.list_5, true))
			{
				result = null;
			}
			else
			{
				short num = 0;
				short num2 = -20;
				if (this.activeUnit_0.vmethod_57() == 4002)
				{
					num = 50;
					num2 = 0;
				}
				GeoPoint geoPoint = new GeoPoint();
				List<GeoPoint> list = new List<GeoPoint>();
				short num3 = Terrain.smethod_7(geoPoint_2.imethod_2(), geoPoint_2.imethod_0(), false);
				if (num3 < num && num3 > num2)
				{
					int num4 = 1;
					do
					{
						float num5 = 0f;
						do
						{
							double double_ = geoPoint_2.imethod_0();
							double double_2 = geoPoint_2.imethod_2();
							GeoPoint geoPoint2;
							double double_3 = (geoPoint2 = geoPoint).imethod_0();
							GeoPoint geoPoint3;
							double double_4 = (geoPoint3 = geoPoint).imethod_2();
							Class411.smethod_1(double_, double_2, ref double_3, ref double_4, (double)num5, (double)num4);
							geoPoint3.imethod_3(double_4);
							geoPoint2.imethod_1(double_3);
							if (GeoPoint.smethod_4(geoPoint.imethod_2(), geoPoint.imethod_0(), class338_0.list_5, true))
							{
								short num6 = Terrain.smethod_7(geoPoint.imethod_2(), geoPoint.imethod_0(), false);
								if (num6 > 0 && num6 < 50)
								{
									list.Add(geoPoint);
								}
							}
							num5 += 0.1f;
						}
						while (num5 <= 2f);
						num4++;
					}
					while (num4 <= 360);
					result = list;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x001B74C4 File Offset: 0x001B56C4
		private void method_118(float float_3)
		{
			Class338 @class = (Class338)this.activeUnit_0.vmethod_101();
			if (Enumerable.Count<Cargo>(this.activeUnit_0.cargo_0) == 0)
			{
				this.activeUnit_0.vmethod_93().method_5(false, ActiveUnit._ActiveUnitStatus.RTB_MissionOver, true, ActiveUnit._ActiveUnitStatus.RTB_Group, true, true);
				return;
			}
			if (!this.activeUnit_0.vmethod_85().method_40(ref @class.list_5, ref @class.list_8, ref @class.list_9, 1, false, false))
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
						this.activeUnit_0.vmethod_134(@class.throttle_3, null);
						return;
					}
					this.activeUnit_0.vmethod_134(@class.throttle_2, null);
				}
				return;
			}
			if ((this.activeUnit_0.method_15() | this.activeUnit_0.method_16(float_3)) & this.method_116(new GeoPoint(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)), @class))
			{
				this.activeUnit_0.vmethod_93().method_20();
				return;
			}
			if (this.method_116(new GeoPoint(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)), @class))
			{
				this.activeUnit_0.vmethod_93().method_20();
				return;
			}
			Ship_AI.Class363 class2 = new Ship_AI.Class363(class2);
			class2.geopoint_Struct_0 = default(Geopoint_Struct);
			int num = 0;
			Geopoint_Struct geopoint_Struct = default(Geopoint_Struct);
			List<Geopoint_Struct> list = new List<Geopoint_Struct>();
			short num2 = 0;
			short num3 = -20;
			if (this.activeUnit_0.vmethod_57() == 4002)
			{
				num2 = 50;
				num3 = 0;
			}
			for (;;)
			{
				num++;
				class2.geopoint_Struct_0 = Math2.smethod_23(@class.list_5);
				if (num > 1000)
				{
					break;
				}
				short num4 = Terrain.smethod_7(class2.geopoint_Struct_0.double_1, class2.geopoint_Struct_0.double_0, false);
				if (num4 > num3 && num4 < num2)
				{
					int num5 = 1;
					do
					{
						float num6 = 0f;
						do
						{
							Geopoint_Struct geopoint_Struct2 = default(Geopoint_Struct);
							Class411.smethod_1(class2.geopoint_Struct_0.double_0, class2.geopoint_Struct_0.double_1, ref geopoint_Struct2.double_0, ref geopoint_Struct2.double_1, (double)num6, (double)num5);
							if (GeoPoint.smethod_4(geopoint_Struct2.double_1, geopoint_Struct2.double_0, @class.list_5, true))
							{
								short num7 = Terrain.smethod_7(geopoint_Struct2.double_1, geopoint_Struct2.double_0, false);
								if (num7 < 50 && num7 > 0)
								{
									list.Add(geopoint_Struct2);
								}
							}
							num6 += 0.1f;
						}
						while (num6 <= 2f);
						num5++;
					}
					while (num5 <= 360);
					if (Enumerable.Any<Geopoint_Struct>(list))
					{
						goto IL_2B2;
					}
				}
			}
			this.activeUnit_0.method_124(this.activeUnit_0.Name + " is unable to pick a suitable point inside cargo landing area defined by Ref. Points", this.activeUnit_0.Name + " unable to pick point", LoggedMessage.MessageType.DockingOps, 1, true, class2.geopoint_Struct_0);
			return;
			IL_2B2:
			geopoint_Struct = Enumerable.First<Geopoint_Struct>(Enumerable.ThenBy<Geopoint_Struct, short>(Enumerable.OrderByDescending<Geopoint_Struct, double>(list, (class2.func_0 == null) ? (class2.func_0 = new Func<Geopoint_Struct, double>(class2.method_0)) : class2.func_0), (Ship_AI._Closure$__.$I17-1 == null) ? (Ship_AI._Closure$__.$I17-1 = new Func<Geopoint_Struct, short>(Ship_AI._Closure$__.$I.method_2)) : Ship_AI._Closure$__.$I17-1));
			this.activeUnit_0.vmethod_85().vmethod_9();
			this.activeUnit_0.vmethod_85().vmethod_24(geopoint_Struct.double_1, geopoint_Struct.double_0, 0f, Waypoint.WaypointType.PatrolStation, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0);
			this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), geopoint_Struct.double_1, geopoint_Struct.double_0));
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x001B7A30 File Offset: 0x001B5C30
		public override void vmethod_19(float float_3)
		{
			bool flag = false;
			if (base.method_73(this.vmethod_3()))
			{
				Doctrine.Enum62? @enum = this.activeUnit_0.doctrine_0.method_142(this.activeUnit_0.scenario_0, false, false, false);
				byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					flag = this.method_119(float_3);
				}
			}
			bool flag2 = false;
			if (!flag)
			{
				Weapon weapon = null;
				if (!Information.IsNothing(this.vmethod_3()))
				{
					weapon = this.activeUnit_0.vmethod_89().method_16(this.vmethod_3(), true, true, true, this.activeUnit_0.doctrine_0);
				}
				if (!Information.IsNothing(weapon) && base.method_73(this.vmethod_3()) && this.activeUnit_0.method_36(this.vmethod_3()) <= weapon.method_181(this.activeUnit_0, this.vmethod_3(), true, this.activeUnit_0.doctrine_0, false))
				{
					base.method_52(ref weapon, this.vmethod_3());
					flag2 = true;
				}
			}
			if (!flag2 && !flag)
			{
				base.vmethod_19(float_3);
			}
			if (this.vmethod_3().contactType_0 == Contact_Base.ContactType.Submarine && !Information.IsNothing(this.vmethod_3().method_112()))
			{
				if (!this.activeUnit_0.vmethod_89().method_17(this.vmethod_3(), false))
				{
					this.activeUnit_0.vmethod_85().method_52();
					this.activeUnit_0.vmethod_85().vmethod_16(float_3);
					return;
				}
				if (this.activeUnit_0.vmethod_85().method_47())
				{
					Doctrine.Enum64? enum2 = this.activeUnit_0.doctrine_0.method_83(this.activeUnit_0.scenario_0, false, null, false, false);
					byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						this.activeUnit_0.vmethod_85().vmethod_16(float_3);
					}
				}
			}
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x001B7C6C File Offset: 0x001B5E6C
		public bool method_119(float float_3)
		{
			bool result;
			try
			{
				if (this.vmethod_3() == null)
				{
					result = false;
				}
				else
				{
					if (this.vmethod_3().contactType_0 != Contact_Base.ContactType.Air)
					{
						if (this.vmethod_3().contactType_0 != Contact_Base.ContactType.Missile)
						{
							Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
							Weapon weapon = this.activeUnit_0.vmethod_89().method_16(this.vmethod_3(), true, true, true, doctrine_);
							if (Information.IsNothing(weapon))
							{
								return false;
							}
							float num = weapon.method_181(this.activeUnit_0, this.vmethod_3(), true, doctrine_, false);
							float? num2 = this.vmethod_3().method_82();
							float num3;
							if (num2 != null)
							{
								num3 = num2.Value;
							}
							else
							{
								num3 = 0f;
							}
							if (num3 >= num)
							{
								return false;
							}
							float num4 = num3 + (num - num3) / 4f;
							Geopoint_Struct geopoint_Struct = default(Geopoint_Struct);
							Class411.smethod_1(this.vmethod_3().vmethod_28(null), this.vmethod_3().vmethod_30(null), ref geopoint_Struct.double_0, ref geopoint_Struct.double_1, (double)num4, (double)Math2.smethod_17(this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null), this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null)));
							this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), geopoint_Struct.double_1, geopoint_Struct.double_0));
							return true;
						}
					}
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100781", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00008736 File Offset: 0x00006936
		[CompilerGenerated]
		private bool method_120(NoNavZone noNavZone_0)
		{
			return noNavZone_0.method_8(this.activeUnit_0);
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_121(UnguidedWeapon unguidedWeapon_0)
		{
			return this.activeUnit_0.method_31(unguidedWeapon_0);
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_122(UnguidedWeapon unguidedWeapon_0)
		{
			return this.activeUnit_0.method_31(unguidedWeapon_0);
		}

		// Token: 0x040015BD RID: 5565
		private HashSet<string> hashSet_1;

		// Token: 0x0200032A RID: 810
		[CompilerGenerated]
		internal sealed class Class361
		{
			// Token: 0x06001804 RID: 6148 RVA: 0x0000C72E File Offset: 0x0000A92E
			public Class361(Ship_AI.Class361 class361_0)
			{
				if (class361_0 != null)
				{
					this.observableDictionary_0 = class361_0.observableDictionary_0;
					this.list_0 = class361_0.list_0;
					this.concurrentBag_0 = class361_0.concurrentBag_0;
				}
			}

			// Token: 0x06001805 RID: 6149 RVA: 0x001B7E84 File Offset: 0x001B6084
			internal void method_0(string string_0)
			{
				UnguidedWeapon unguidedWeapon;
				this.observableDictionary_0.TryGetValue(string_0, ref unguidedWeapon);
				if (!Information.IsNothing(unguidedWeapon) && unguidedWeapon.method_65() && unguidedWeapon.vmethod_46(this.list_0, this.ship_AI_0.activeUnit_0.scenario_0, true))
				{
					this.concurrentBag_0.Add(unguidedWeapon);
				}
			}

			// Token: 0x040015BE RID: 5566
			public ObservableDictionary<string, UnguidedWeapon> observableDictionary_0;

			// Token: 0x040015BF RID: 5567
			public List<ReferencePoint> list_0;

			// Token: 0x040015C0 RID: 5568
			public ConcurrentBag<UnguidedWeapon> concurrentBag_0;

			// Token: 0x040015C1 RID: 5569
			public Ship_AI ship_AI_0;
		}

		// Token: 0x0200032B RID: 811
		[CompilerGenerated]
		internal sealed class Class362
		{
			// Token: 0x06001806 RID: 6150 RVA: 0x0000C75D File Offset: 0x0000A95D
			public Class362(Ship_AI.Class362 class362_0)
			{
				if (class362_0 != null)
				{
					this.observableDictionary_0 = class362_0.observableDictionary_0;
					this.list_0 = class362_0.list_0;
					this.concurrentBag_0 = class362_0.concurrentBag_0;
				}
			}

			// Token: 0x06001807 RID: 6151 RVA: 0x001B7EDC File Offset: 0x001B60DC
			internal void method_0(string string_0)
			{
				UnguidedWeapon unguidedWeapon;
				this.observableDictionary_0.TryGetValue(string_0, ref unguidedWeapon);
				if (!Information.IsNothing(unguidedWeapon) && unguidedWeapon.method_65() && unguidedWeapon.vmethod_46(this.list_0, this.ship_AI_0.activeUnit_0.scenario_0, true))
				{
					this.concurrentBag_0.Add(unguidedWeapon);
				}
			}

			// Token: 0x040015C2 RID: 5570
			public ObservableDictionary<string, UnguidedWeapon> observableDictionary_0;

			// Token: 0x040015C3 RID: 5571
			public List<ReferencePoint> list_0;

			// Token: 0x040015C4 RID: 5572
			public ConcurrentBag<UnguidedWeapon> concurrentBag_0;

			// Token: 0x040015C5 RID: 5573
			public Ship_AI ship_AI_0;
		}

		// Token: 0x0200032D RID: 813
		[CompilerGenerated]
		internal sealed class Class363
		{
			// Token: 0x0600180D RID: 6157 RVA: 0x0000C7AC File Offset: 0x0000A9AC
			public Class363(Ship_AI.Class363 class363_0)
			{
				if (class363_0 != null)
				{
					this.geopoint_Struct_0 = class363_0.geopoint_Struct_0;
				}
			}

			// Token: 0x0600180E RID: 6158 RVA: 0x0000C7C3 File Offset: 0x0000A9C3
			internal double method_0(Geopoint_Struct geopoint_Struct_1)
			{
				return Math2.smethod_14(geopoint_Struct_1.double_1, geopoint_Struct_1.double_0, this.geopoint_Struct_0.double_1, this.geopoint_Struct_0.double_0);
			}

			// Token: 0x040015CA RID: 5578
			public Geopoint_Struct geopoint_Struct_0;

			// Token: 0x040015CB RID: 5579
			public Func<Geopoint_Struct, double> func_0;
		}
	}
}
