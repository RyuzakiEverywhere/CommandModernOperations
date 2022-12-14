using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns13;
using ns14;
using ns9;

namespace Command_Core
{
	// Token: 0x0200038A RID: 906
	public class Weapon_AI : ActiveUnit_AI
	{
		// Token: 0x06001B8C RID: 7052 RVA: 0x0000DC83 File Offset: 0x0000BE83
		protected Weapon method_112()
		{
			if (this.weapon_0 == null)
			{
				this.weapon_0 = (Weapon)this.activeUnit_0;
			}
			return this.weapon_0;
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0000DCA4 File Offset: 0x0000BEA4
		public bool method_113()
		{
			return this.bool_11;
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0000DCAC File Offset: 0x0000BEAC
		public void method_114(bool bool_12)
		{
			this.bool_11 = bool_12;
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x001F5160 File Offset: 0x001F3360
		public static void smethod_1(XmlNode xmlNode_0, Dictionary<string, Class310> dictionary_0, Weapon weapon_1)
		{
			try
			{
				if (Operators.CompareString(xmlNode_0.ChildNodes[0].Name, "ActiveUnit_AI", false) == 0)
				{
					xmlNode_0 = xmlNode_0.ChildNodes[0];
				}
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						try
						{
							string name = xmlNode.Name;
							uint num = Class582.smethod_0(name);
							if (num <= 1641464439U)
							{
								if (num <= 467450941U)
								{
									if (num != 106934956U)
									{
										if (num != 402376870U)
										{
											if (num == 467450941U)
											{
												if (Operators.CompareString(name, "PrimaryThreat", false) == 0)
												{
													weapon_1.vmethod_142().contact_1 = Contact.smethod_0(xmlNode.InnerText, ref dictionary_0);
												}
											}
										}
										else if (Operators.CompareString(name, "SnakeAxis", false) == 0)
										{
											weapon_1.vmethod_142().nullable_1 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										}
									}
									else if (Operators.CompareString(name, "PrimaryTarget", false) == 0)
									{
										if (xmlNode.InnerText.Contains("Aimpoint"))
										{
											weapon_1.vmethod_142().vmethod_4(Class355.smethod_6(xmlNode.InnerText));
										}
										else if (xmlNode.InnerText.Contains("ActivationPoint"))
										{
											weapon_1.vmethod_142().vmethod_4(Class356.smethod_6(xmlNode.InnerText));
										}
										else
										{
											weapon_1.vmethod_142().vmethod_4(Contact.smethod_0(xmlNode.InnerText, ref dictionary_0));
										}
									}
								}
								else
								{
									if (num <= 1103999922U)
									{
										if (num != 592141878U)
										{
											if (num != 1103999922U)
											{
												continue;
											}
											if (Operators.CompareString(name, "VirtualTargetVelocity", false) == 0)
											{
												weapon_1.vmethod_142().float_4 = XmlConvert.ToSingle(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Threats", false) != 0)
											{
												continue;
											}
											try
											{
												foreach (object obj2 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode2 = (XmlNode)obj2;
													Contact contact = Contact.smethod_1(ref xmlNode2, ref dictionary_0);
													if (!Information.IsNothing(contact))
													{
														Class429.smethod_13(ref weapon_1.vmethod_142().contact_2, contact);
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
									}
									if (num != 1474882803U)
									{
										if (num == 1641464439U)
										{
											if (Operators.CompareString(name, "VirtualTargetAltitude", false) == 0)
											{
												weapon_1.vmethod_142().float_3 = XmlConvert.ToSingle(xmlNode.InnerText);
											}
										}
									}
									else if (Operators.CompareString(name, "IE", false) == 0)
									{
										weapon_1.vmethod_142().bool_2 = true;
									}
								}
							}
							else if (num <= 2276842832U)
							{
								if (num != 1966596370U)
								{
									if (num != 2133975202U)
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
													weapon_1.vmethod_142().vmethod_0().Add(targetingEntry.contact_0.string_0, targetingEntry);
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
									if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Lat", false) == 0)
									{
										weapon_1.vmethod_142().method_3(XmlConvert.ToDouble(xmlNode.InnerText));
									}
								}
								else if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Lon", false) == 0)
								{
									weapon_1.vmethod_142().method_5(XmlConvert.ToDouble(xmlNode.InnerText));
								}
							}
							else if (num <= 3761246852U)
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
								weapon_1.vmethod_142().bool_0 = Conversions.ToBoolean(xmlNode.InnerText);
							}
							else if (num != 4025372673U)
							{
								if (num == 4076649232U)
								{
									if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Alt", false) == 0)
									{
										weapon_1.vmethod_142().method_7(XmlConvert.ToSingle(xmlNode.InnerText));
									}
								}
							}
							else if (Operators.CompareString(name, "PrimaryTarget_Type", false) == 0)
							{
								if (Versioned.IsNumeric(xmlNode.InnerText))
								{
									weapon_1.vmethod_142().contactType_0 = (Contact_Base.ContactType)Conversions.ToByte(xmlNode.InnerText);
								}
								else
								{
									weapon_1.vmethod_142().contactType_0 = (Contact_Base.ContactType)Enum.Parse(typeof(Contact_Base.ContactType), xmlNode.InnerText, true);
								}
							}
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 200049", ex.Message);
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
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100964", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x001F572C File Offset: 0x001F392C
		public void method_115(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			try
			{
				if (!Information.IsNothing(this.vmethod_3()))
				{
					xmlWriter_0.WriteElementString("PrimaryTarget", this.vmethod_3().string_0);
				}
				if (!Information.IsNothing(this.contactType_0))
				{
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "PrimaryTarget_Type";
					int contactType_ = (int)this.contactType_0;
					xmlWriter.WriteElementString(localName, contactType_.ToString());
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
				if (this.float_3 != 0f)
				{
					xmlWriter_0.WriteElementString("VirtualTargetAltitude", XmlConvert.ToString(this.float_3));
				}
				if (this.float_4 != 0f)
				{
					xmlWriter_0.WriteElementString("VirtualTargetVelocity", XmlConvert.ToString(this.float_4));
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
				if (this.bool_4)
				{
					xmlWriter_0.WriteElementString("HPos", this.bool_4.ToString());
				}
				if (this.bool_1)
				{
					xmlWriter_0.WriteElementString("FCLIO", this.bool_1.ToString());
				}
				if (this.bool_2)
				{
					xmlWriter_0.WriteElementString("IE", this.bool_2.ToString());
				}
				if (!Information.IsNothing(this.geoPoint_0))
				{
					xmlWriter_0.WriteStartElement("LKTL");
					xmlWriter_0.WriteRaw(this.geoPoint_0.method_8(hashSet_1));
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
								xmlWriter_0.WriteRaw(contact.method_61(hashSet_1));
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
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100021", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0000DCB5 File Offset: 0x0000BEB5
		public Weapon_AI(Weapon weapon_1) : base(weapon_1)
		{
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0000378C File Offset: 0x0000198C
		public override void vmethod_10(float float_5, bool bool_12, bool bool_13)
		{
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0000378C File Offset: 0x0000198C
		public override void vmethod_25()
		{
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x00007446 File Offset: 0x00005646
		public override Contact vmethod_3()
		{
			return this.contact_0;
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x001F5AE0 File Offset: 0x001F3CE0
		public override void vmethod_4(Contact contact_8)
		{
			try
			{
				Contact contact_9 = this.contact_0;
				if (contact_8 != this.contact_0)
				{
					if (!Information.IsNothing(this.contact_0) && Information.IsNothing(contact_8))
					{
						this.geoPoint_0 = new GeoPoint(this.contact_0.vmethod_28(null), this.contact_0.vmethod_30(null), this.contact_0.vmethod_14(false));
					}
					if (Information.IsNothing(contact_8))
					{
						if (!Information.IsNothing(this.contact_0) && this.contact_0.method_103() && this.contact_0.bool_19)
						{
							this.activeUnit_0.vmethod_73(this.contact_0.vmethod_14(false));
						}
					}
					else if (!base.method_11(contact_8) && this.method_112().class394_0.bool_5)
					{
						this.activeUnit_0.vmethod_86().vmethod_12(contact_8, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
						if (!this.method_112().bool_28)
						{
							Weapon weapon = this.method_112();
							ObservableDictionary<int, EmissionContainer> observableDictionary_ = contact_8.method_68();
							Side side_ = this.method_112().vmethod_7(false);
							bool bool_ = false;
							Random random = GameGeneral.smethod_5();
							if (weapon.method_217(observableDictionary_, side_, contact_8, bool_, ref random))
							{
								this.method_112().bool_28 = true;
							}
						}
					}
				}
				if (this.method_112().method_199() && this.method_112().method_277())
				{
					this.contact_0 = contact_8;
				}
				else if (Information.IsNothing(contact_8) && !Information.IsNothing(this.contact_0) && this.contact_0.method_107() && !this.method_112().class394_0.bool_5 && Enumerable.Count<CommDevice>(this.method_112().vmethod_94()) == 0)
				{
					this.method_112().method_235(true);
				}
				else if (Information.IsNothing(contact_8) && !Information.IsNothing(this.contact_0) && this.contact_0.method_108() && !this.method_112().class394_0.bool_5 && Enumerable.Count<CommDevice>(this.method_112().vmethod_94()) == 0)
				{
					if (this.method_112().method_169() == Weapon.WeaponGuidanceType.SemiActive)
					{
						this.method_112().method_235(true);
					}
					else if (this.method_112().float_27 == 0f && this.method_112().method_145() == 0f && Enumerable.Count<CommDevice>(this.method_112().vmethod_94()) == 0)
					{
						this.method_112().method_235(true);
					}
					else
					{
						this.contact_0 = contact_8;
					}
				}
				else if (Information.IsNothing(contact_8) && !Information.IsNothing(contact_9) && contact_9.contactType_0 != Contact_Base.ContactType.ActivationPoint && !Information.IsNothing(this.contact_0) && this.method_112().class394_0.bool_5 && Enumerable.Count<CommDevice>(this.method_112().vmethod_94()) == 0 && this.method_112().struct36_0.bool_10)
				{
					this.method_112().method_235(true);
				}
				else
				{
					this.contact_0 = contact_8;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100965", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x001F5E18 File Offset: 0x001F4018
		public override void vmethod_17(float float_5, bool bool_12, bool bool_13)
		{
			if (this.bool_10 && this.activeUnit_0 != null && this.method_112().method_167() != Weapon._WeaponType.Sonobuoy)
			{
				this.method_112().method_271();
				if (this.method_112().method_169() != Weapon.WeaponGuidanceType.Inertial || (!this.activeUnit_0.bool_7 && !this.method_112().method_204()))
				{
					try
					{
						if (this.vmethod_3() != null)
						{
							base.method_3(this.vmethod_3().vmethod_30(null));
							base.method_5(this.vmethod_3().vmethod_28(null));
							if (this.vmethod_3().contactType_0 == Contact_Base.ContactType.ActivationPoint && this.method_112().method_187().method_47())
							{
								base.method_7(this.method_112().method_187().method_4()[0].imethod_4());
							}
							else
							{
								base.method_7(this.vmethod_3().vmethod_14(false));
							}
						}
						if (base.method_12().Length != 0)
						{
							List<Contact> list = new List<Contact>();
							list.AddRange(base.method_12());
							if (this.method_112().method_205())
							{
								if (!this.activeUnit_0.vmethod_85().method_46())
								{
									if (!Information.IsNothing(this.vmethod_3()))
									{
										if (this.method_112().class394_0.bool_5 && !this.method_112().struct36_0.bool_10)
										{
											this.vmethod_4(null);
										}
										else
										{
											try
											{
												foreach (Contact contact in list)
												{
													if (!Information.IsNothing(this.vmethod_3().activeUnit_0))
													{
														if (contact.activeUnit_0 != this.vmethod_3().activeUnit_0)
														{
															continue;
														}
													}
													this.vmethod_4(contact);
													return;
												}
											}
											finally
											{
												List<Contact>.Enumerator enumerator;
												((IDisposable)enumerator).Dispose();
											}
										}
										if (!this.method_112().method_164() && !this.method_112().method_165() && (Information.IsNothing(this.vmethod_3()) || !this.vmethod_3().activeUnit_0.method_5()))
										{
											IEnumerable<Contact> enumerable = Enumerable.OrderBy<Contact, double>(list, new Func<Contact, double>(this.method_127));
											this.vmethod_4(Enumerable.ElementAtOrDefault<Contact>(enumerable, 0));
										}
										if (this.method_112().class394_0.bool_5 && Information.IsNothing(this.method_112().keyValuePair_0))
										{
											Weapon weapon = this.method_112();
											ObservableDictionary<int, EmissionContainer> observableDictionary_ = this.vmethod_3().method_68();
											Side side_ = this.activeUnit_0.vmethod_7(false);
											Contact contact_ = this.vmethod_3();
											bool bool_14 = false;
											Random random = GameGeneral.smethod_5();
											weapon.method_217(observableDictionary_, side_, contact_, bool_14, ref random);
										}
									}
									else
									{
										IEnumerable<Contact> enumerable2 = Enumerable.OrderBy<Contact, double>(Enumerable.Select<Contact, Contact>(list, (Weapon_AI._Closure$__.$I21-1 == null) ? (Weapon_AI._Closure$__.$I21-1 = new Func<Contact, Contact>(Weapon_AI._Closure$__.$I.method_0)) : Weapon_AI._Closure$__.$I21-1), new Func<Contact, double>(this.method_128));
										if (Enumerable.Count<Contact>(enumerable2) > 0)
										{
											this.vmethod_4(Enumerable.ElementAtOrDefault<Contact>(enumerable2, 0));
										}
									}
								}
							}
							else
							{
								Weapon.WeaponGuidanceType weaponGuidanceType = this.method_112().method_169();
								if (weaponGuidanceType != Weapon.WeaponGuidanceType.Passive)
								{
									if (weaponGuidanceType != Weapon.WeaponGuidanceType.SemiActive_Plus_Active)
									{
										if (weaponGuidanceType == Weapon.WeaponGuidanceType.TimesharedSemiActive_Plus_Active && Information.IsNothing(this.method_112().method_179()) && list.Count > 0)
										{
											if (list.Count == 1)
											{
												this.vmethod_4(list[0]);
											}
											else
											{
												if (!Information.IsNothing(this.vmethod_3()))
												{
													try
													{
														foreach (Contact contact2 in list)
														{
															if (!Information.IsNothing(contact2) && !Information.IsNothing(contact2.activeUnit_0) && !Information.IsNothing(this.vmethod_3()) && !Information.IsNothing(this.vmethod_3().activeUnit_0) && Operators.CompareString(contact2.activeUnit_0.string_0, this.vmethod_3().activeUnit_0.string_0, false) == 0)
															{
																return;
															}
														}
													}
													finally
													{
														List<Contact>.Enumerator enumerator2;
														((IDisposable)enumerator2).Dispose();
													}
												}
												IEnumerable<Contact> enumerable3 = Enumerable.OrderBy<Contact, float>(list, new Func<Contact, float>(this.method_129));
												this.vmethod_4(Enumerable.ElementAtOrDefault<Contact>(enumerable3, 0));
											}
										}
									}
									else if (this.activeUnit_0.vmethod_96()[0].method_43() && list.Count > 0)
									{
										if (base.method_12().Length == 1)
										{
											this.vmethod_4(list[0]);
										}
										else
										{
											if (!Information.IsNothing(this.vmethod_3()))
											{
												try
												{
													foreach (Contact contact3 in list)
													{
														if (!Information.IsNothing(contact3) && !Information.IsNothing(contact3.activeUnit_0) && !Information.IsNothing(this.vmethod_3()) && !Information.IsNothing(this.vmethod_3().activeUnit_0) && Operators.CompareString(contact3.activeUnit_0.string_0, this.vmethod_3().activeUnit_0.string_0, false) == 0)
														{
															return;
														}
													}
												}
												finally
												{
													List<Contact>.Enumerator enumerator3;
													((IDisposable)enumerator3).Dispose();
												}
											}
											IEnumerable<Contact> enumerable4 = Enumerable.OrderBy<Contact, float>(list, new Func<Contact, float>(this.method_130));
											this.vmethod_4(Enumerable.ElementAtOrDefault<Contact>(enumerable4, 0));
										}
									}
								}
								else
								{
									if (!Information.IsNothing(this.vmethod_3()) && this.method_112().class394_0.bool_5 && !this.method_112().struct36_0.bool_10 && list.Count > 1)
									{
										try
										{
											IEnumerator<int> enumerator4 = this.vmethod_3().method_68().Keys.GetEnumerator();
											while (enumerator4.MoveNext())
											{
												if (enumerator4.Current == this.method_112().keyValuePair_0.Key && this.method_112().keyValuePair_0.Value.float_0 > 20f)
												{
													this.vmethod_15(this.vmethod_3(), true);
													break;
												}
											}
										}
										finally
										{
											IEnumerator<int> enumerator4;
											if (enumerator4 != null)
											{
												enumerator4.Dispose();
											}
										}
									}
									if ((Information.IsNothing(this.vmethod_3()) || (this.method_112().class394_0.bool_5 && !list.Contains(this.vmethod_3()))) && (this.method_112().method_199() || this.method_112().class394_0.bool_0 || this.method_112().class394_0.bool_5))
									{
										if (this.method_112().class394_0.bool_5)
										{
											if (!Information.IsNothing(this.method_112().keyValuePair_0))
											{
												list = Enumerable.ToList<Contact>(Enumerable.Where<Contact>(list, new Func<Contact, bool>(this.method_131)));
											}
											if (list.Count > 0)
											{
												this.method_112().keyValuePair_0.Value.float_0 = 0f;
											}
										}
										if (list.Count > 0)
										{
											if (list.Count == 1)
											{
												this.vmethod_4(list[0]);
											}
											else
											{
												IEnumerable<Contact> enumerable5 = Enumerable.OrderBy<Contact, float>(list, new Func<Contact, float>(this.method_132));
												this.vmethod_4(Enumerable.ElementAtOrDefault<Contact>(enumerable5, 0));
											}
										}
									}
								}
							}
						}
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 100967", "");
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
				}
			}
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0000378C File Offset: 0x0000198C
		public override void vmethod_22(float float_5)
		{
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x001F65C0 File Offset: 0x001F47C0
		protected void method_116()
		{
			try
			{
				if (this.method_112().bool_7)
				{
					this.int_0 = 15;
				}
				else
				{
					this.int_0 = 8;
				}
				if (Information.IsNothing(this.nullable_1))
				{
					if (!Information.IsNothing(this.vmethod_3()))
					{
						this.nullable_1 = new float?(Math2.smethod_17(this.method_112().vmethod_30(null), this.method_112().vmethod_28(null), this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null)));
					}
					else
					{
						this.nullable_1 = new float?(this.activeUnit_0.vmethod_9());
					}
				}
				if (Information.IsNothing(this.nullable_10))
				{
					this.nullable_10 = new Weapon_AI.Enum131?((Weapon_AI.Enum131)GameGeneral.smethod_5().Next(0, 1));
				}
				float float_ = Math2.smethod_7(this.nullable_1.Value - (float)this.int_0);
				float float_2 = Math2.smethod_7(this.nullable_1.Value + (float)this.int_0);
				Weapon_AI.Enum131? @enum = this.nullable_10;
				byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					if (Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_9(), this.nullable_1.Value)) >= (float)this.int_0)
					{
						this.nullable_10 = new Weapon_AI.Enum131?(Weapon_AI.Enum131.const_1);
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, float_2);
					}
					else
					{
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, float_);
					}
				}
				else
				{
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						if (Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_9(), this.nullable_1.Value)) >= (float)this.int_0)
						{
							this.nullable_10 = new Weapon_AI.Enum131?(Weapon_AI.Enum131.const_0);
							this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, float_);
						}
						else
						{
							this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, float_2);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100968", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0000378C File Offset: 0x0000198C
		public override void vmethod_18()
		{
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x001F688C File Offset: 0x001F4A8C
		public override void vmethod_19(float float_5)
		{
			if (this.vmethod_3() != null)
			{
				try
				{
					this.activeUnit_0.vmethod_9();
					float num = Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null));
					if (this.activeUnit_0.vmethod_9() != num)
					{
						float num2 = Class437.smethod_11(this.activeUnit_0.vmethod_9(), Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null)));
						if (315f > num2 && num2 > 45f && this.activeUnit_0.vmethod_40() > this.vmethod_3().vmethod_40())
						{
							base.method_63(float_5, 0f, 0f);
						}
						else
						{
							Weapon.WeaponGuidanceType weaponGuidanceType = this.method_112().method_169();
							if (weaponGuidanceType == Weapon.WeaponGuidanceType.BeamRiding)
							{
								base.method_63(float_5, 0f, 0f);
							}
							else
							{
								float? num3 = new float?(this.activeUnit_0.vmethod_70());
								bool flag = false;
								this.vmethod_21(float_5, num3, ref flag);
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100969", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0000378C File Offset: 0x0000198C
		public override void vmethod_11(float float_5, bool bool_12, bool bool_13)
		{
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x001F6A54 File Offset: 0x001F4C54
		public override void vmethod_26(float float_5)
		{
			try
			{
				if (this.method_112().method_167() != Weapon._WeaponType.Sonobuoy)
				{
					if (this.method_112().method_141() <= 0f)
					{
						if (this.method_112().method_183() > 0f)
						{
							if (this.method_112().method_169() == Weapon.WeaponGuidanceType.Inertial_Plus_SemiActive)
							{
								this.vmethod_33(float_5);
							}
							if (!this.method_113())
							{
								this.method_114(true);
							}
						}
						else
						{
							if (!this.method_112().bool_31)
							{
								Weapon weapon = this.method_112();
								if (!base.method_69(ref weapon))
								{
									if (this.activeUnit_0.vmethod_85().method_46())
									{
										this.activeUnit_0.vmethod_85().vmethod_16(float_5);
										this.vmethod_33(float_5);
										return;
									}
									if (this.activeUnit_0.bool_7 && this.method_112().method_169() == Weapon.WeaponGuidanceType.Inertial)
									{
										return;
									}
									if (!this.method_112().struct36_0.bool_12 && this.method_112().enum127_0 == Weapon.Enum127.const_0)
									{
										if (this.method_112().struct36_0.bool_11)
										{
											this.method_112().vmethod_143().vmethod_27(float_5, false, false);
										}
										else
										{
											this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.vmethod_9());
										}
									}
									else if (!Information.IsNothing(this.vmethod_3()) && !Information.IsNothing(this.vmethod_3().activeUnit_0) && !this.vmethod_3().activeUnit_0.method_5())
									{
										if (this.method_112().enum127_0 == Weapon.Enum127.const_2)
										{
											this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, Math2.smethod_7(this.activeUnit_0.vmethod_68() + 10f * float_5));
											if (this.activeUnit_0.vmethod_87().method_9())
											{
												this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
											}
											else
											{
												this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
											}
										}
										else if (this.method_112().enum127_0 == Weapon.Enum127.const_1)
										{
											this.method_116();
										}
										else
										{
											this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.vmethod_9());
										}
									}
									else if (!this.method_112().method_187().method_47() && this.method_112().enum127_0 == Weapon.Enum127.const_2)
									{
										this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, Math2.smethod_7(this.activeUnit_0.vmethod_68() + 10f * float_5));
										if (this.activeUnit_0.vmethod_87().method_9())
										{
											this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
										}
										else
										{
											this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
										}
									}
									else if (this.vmethod_3() != null && this.vmethod_3().activeUnit_0 != null && this.vmethod_3().activeUnit_0.method_5())
									{
										this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, base.method_68(this.vmethod_3()));
									}
									else
									{
										this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.vmethod_9());
									}
									this.vmethod_33(float_5);
									goto IL_719;
								}
							}
							if (this.vmethod_3() != null && this.vmethod_3().contactType_0 != Contact_Base.ContactType.Aimpoint && this.vmethod_3().contactType_0 != Contact_Base.ContactType.ActivationPoint)
							{
								base.method_3(this.vmethod_3().vmethod_30(null));
								base.method_5(this.vmethod_3().vmethod_28(null));
								base.method_7(this.vmethod_3().vmethod_14(false));
							}
							if (this.activeUnit_0.vmethod_85().method_46() && !Information.IsNothing(this.method_112().method_179()))
							{
								if (!this.vmethod_3().method_5())
								{
									Weapon.WeaponGuidanceType weaponGuidanceType = this.method_112().method_169();
									if (weaponGuidanceType <= Weapon.WeaponGuidanceType.DataLink_Plus_Passive)
									{
										if (weaponGuidanceType != Weapon.WeaponGuidanceType.Datalink_Plus_SemiActive && weaponGuidanceType != Weapon.WeaponGuidanceType.DataLink_Plus_Passive)
										{
											goto IL_46C;
										}
									}
									else if (weaponGuidanceType != Weapon.WeaponGuidanceType.Datalink_Plus_Active && weaponGuidanceType != Weapon.WeaponGuidanceType.SemiActive_Plus_Active)
									{
										goto IL_46C;
									}
									float float_6;
									if (this.vmethod_3().method_91())
									{
										float_6 = this.method_117(this.vmethod_3());
									}
									else
									{
										float_6 = (float)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), this.activeUnit_0.vmethod_82(), false);
									}
									((Weapon_Navigator)this.activeUnit_0.vmethod_85()).method_64(float_6, this.method_112().method_179() != null && this.method_112().method_179().bool_3 && this.method_112().bool_7);
								}
								IL_46C:
								this.activeUnit_0.vmethod_85().vmethod_16(float_5);
							}
							else if (this.activeUnit_0.vmethod_85().method_47())
							{
								this.activeUnit_0.vmethod_85().vmethod_16(float_5);
							}
							else
							{
								if (!Information.IsNothing(this.vmethod_3()) && this.vmethod_3().contactType_0 == Contact_Base.ContactType.ActivationPoint)
								{
									return;
								}
								Weapon.WeaponGuidanceType weaponGuidanceType2 = this.method_112().method_169();
								if (weaponGuidanceType2 != Weapon.WeaponGuidanceType.CommandGuided_Datalinked)
								{
									if (weaponGuidanceType2 == Weapon.WeaponGuidanceType.Inertial)
									{
										if (this.vmethod_3() != null)
										{
											this.method_112().method_187().method_50(new Waypoint(this.vmethod_3().vmethod_28(null), this.vmethod_3().vmethod_30(null), 0f, Waypoint.WaypointType.TerminalPoint, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0));
										}
									}
									else if (!Information.IsNothing(this.vmethod_3().activeUnit_0))
									{
										if (!this.method_112().bool_29)
										{
											this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, base.method_70(this.vmethod_3().activeUnit_0));
										}
										else
										{
											this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.vmethod_9());
										}
									}
									else
									{
										this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, base.method_68(this.vmethod_3()));
									}
								}
								else
								{
									this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, base.method_68(this.vmethod_3()));
								}
							}
							this.vmethod_33(float_5);
							if (this.method_112().vmethod_14(false) != this.method_112().method_145() && !Information.IsNothing(this.vmethod_3()))
							{
								Contact_Base.ContactType contactType_ = this.vmethod_3().contactType_0;
								if (contactType_ <= Contact_Base.ContactType.Missile || contactType_ == Contact_Base.ContactType.Orbital || contactType_ == Contact_Base.ContactType.Decoy_Air)
								{
									float num = Math.Abs(this.vmethod_3().vmethod_14(false) - this.activeUnit_0.vmethod_14(false));
									float num2 = (this.vmethod_3().vmethod_14(false) >= this.activeUnit_0.vmethod_14(false)) ? this.activeUnit_0.vmethod_87().vmethod_14(true) : this.activeUnit_0.vmethod_87().vmethod_21();
									float num3 = num / num2;
									float num4 = this.activeUnit_0.method_39(this.vmethod_3(), this.activeUnit_0.vmethod_40(), this.activeUnit_0.method_32(this.vmethod_3()));
									float num5 = this.activeUnit_0.method_36(this.vmethod_3());
									long num6;
									if (num4 <= 0f)
									{
										num6 = long.MaxValue;
									}
									else
									{
										num6 = (long)Math.Round((double)(num5 / num4 * 3600f));
									}
									if ((float)num6 < num3)
									{
										float value = (float)((double)num / ((double)num6 + 0.001));
										this.method_112().vmethod_143().vmethod_15(true, value);
									}
								}
							}
							IL_719:;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100970", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x001F71D0 File Offset: 0x001F53D0
		public float method_117(Contact contact_8)
		{
			float result;
			try
			{
				GeoPoint geoPoint;
				float num;
				if (contact_8.method_91())
				{
					this.method_112().vmethod_89().method_52(this.method_112().scenario_0, this.method_112().DBID, this.method_112(), this.method_112().vmethod_28(null), this.method_112().vmethod_30(null), this.method_112().vmethod_14(false), (int)Math.Round((double)this.method_112().vmethod_40()), contact_8, 0f, ActiveUnit.Throttle.Cruise, ref geoPoint, ref num);
				}
				else
				{
					Scenario scenario_ = this.method_112().scenario_0;
					int dbid = this.method_112().DBID;
					ActiveUnit firingUnit = this.method_112();
					double launchLongitude = this.method_112().vmethod_28(null);
					double launchLatitude = this.method_112().vmethod_30(null);
					float launchAltitude = this.method_112().vmethod_14(false);
					int launchSpeed = (int)Math.Round((double)this.method_112().vmethod_40());
					double targetLongitude = contact_8.vmethod_28(null);
					double targetLatitude = contact_8.vmethod_30(null);
					float targetHeading = contact_8.vmethod_9();
					bool bool_ = contact_8.bool_18;
					int targetSpeed = (int)Math.Round((double)contact_8.vmethod_40());
					bool bool_2 = contact_8.bool_17;
					float targetAltitude = contact_8.vmethod_14(false);
					bool bool_3 = contact_8.bool_19;
					Contact_Base.ContactType contactType_ = contact_8.contactType_0;
					string empty = string.Empty;
					ActiveUnit_Weaponry.smethod_5(scenario_, dbid, firingUnit, launchLongitude, launchLatitude, launchAltitude, launchSpeed, targetLongitude, targetLatitude, targetHeading, bool_, targetSpeed, bool_2, targetAltitude, bool_3, contactType_, ref geoPoint, ref empty, 0f, ActiveUnit.Throttle.Cruise, 0, null, null, ref num);
				}
				if (geoPoint == null)
				{
					result = (float)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), this.activeUnit_0.vmethod_82(), false);
				}
				else
				{
					result = this.method_112().method_23(geoPoint) / (num / 3600f);
				}
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

		// Token: 0x06001B9E RID: 7070 RVA: 0x001F73B8 File Offset: 0x001F55B8
		protected void method_118(GeoPoint geoPoint_2, float float_5)
		{
			if (this.method_112().vmethod_6())
			{
				if (geoPoint_2 == null)
				{
					float num = Math.Abs(this.method_112().vmethod_72() - this.method_112().vmethod_14(false));
					if (this.activeUnit_0.vmethod_72() > this.activeUnit_0.vmethod_14(false))
					{
						if (num < 2000f)
						{
							this.activeUnit_0.vmethod_23(num / 2000f * 89f);
							return;
						}
						this.activeUnit_0.vmethod_23(89f);
						return;
					}
					else
					{
						if (num < 2000f)
						{
							this.activeUnit_0.vmethod_23(num / 2000f * -89f);
							return;
						}
						this.activeUnit_0.vmethod_23(-89f);
						return;
					}
				}
				else
				{
					this.method_120(geoPoint_2.imethod_2(), geoPoint_2.imethod_0(), float_5);
				}
			}
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x001F748C File Offset: 0x001F568C
		private void method_119(Geopoint_Struct geopoint_Struct_1, float float_5)
		{
			if (this.method_112().vmethod_6())
			{
				if (geopoint_Struct_1.method_0())
				{
					float num = Math.Abs(this.method_112().vmethod_72() - this.method_112().vmethod_14(false));
					if (this.activeUnit_0.vmethod_72() > this.activeUnit_0.vmethod_14(false))
					{
						if (num < 2000f)
						{
							this.activeUnit_0.vmethod_23(num / 2000f * 89f);
							return;
						}
						this.activeUnit_0.vmethod_23(89f);
						return;
					}
					else
					{
						if (num < 2000f)
						{
							this.activeUnit_0.vmethod_23(num / 2000f * -89f);
							return;
						}
						this.activeUnit_0.vmethod_23(-89f);
						return;
					}
				}
				else
				{
					this.method_120(geopoint_Struct_1.double_1, geopoint_Struct_1.double_0, float_5);
				}
			}
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x001F7564 File Offset: 0x001F5764
		protected void method_120(double double_4, double double_5, float float_5)
		{
			if (this.method_112().vmethod_6())
			{
				double num = Math.Atan2((double)(this.method_112().vmethod_14(false) - this.method_112().vmethod_72()), (double)this.method_112().method_25(double_4, double_5) * 1852.0) * 57.2957795130823;
				if (num > 0.0 && this.method_112().vmethod_14(false) > this.method_112().vmethod_72())
				{
					num = -num;
				}
				if (num < 0.0 && this.method_112().vmethod_14(false) < this.method_112().vmethod_72())
				{
					num = -num;
				}
				this.method_112().vmethod_23((float)num);
			}
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x001F7620 File Offset: 0x001F5820
		private void method_121(float float_5)
		{
			Geopoint_Struct? geopoint_Struct = null;
			if (this.vmethod_3() != null)
			{
				float num;
				if (this.vmethod_3().vmethod_40() == 0f)
				{
					num = this.activeUnit_0.method_36(this.vmethod_3());
				}
				else
				{
					float float_6;
					if (this.method_112().vmethod_6())
					{
						float_6 = (float)((double)this.method_112().vmethod_143().vmethod_38() * 0.5);
					}
					else
					{
						float_6 = (float)this.method_112().vmethod_143().vmethod_38();
					}
					geopoint_Struct = new Geopoint_Struct?(this.method_112().method_187().method_62(float_6, this.vmethod_3(), null));
					if (Information.IsNothing(geopoint_Struct))
					{
						num = this.activeUnit_0.method_36(this.vmethod_3());
					}
					else
					{
						num = this.method_112().method_24(geopoint_Struct.Value);
					}
				}
				if ((this.vmethod_3().contactType_0 == Contact_Base.ContactType.Air || this.vmethod_3().contactType_0 == Contact_Base.ContactType.Missile) && !this.method_112().struct36_0.bool_0)
				{
					this.activeUnit_0.vmethod_73(this.method_112().vmethod_16());
					if (Information.IsNothing(geopoint_Struct))
					{
						this.method_120(this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null), float_5);
						return;
					}
					this.method_120(geopoint_Struct.Value.double_1, geopoint_Struct.Value.double_0, float_5);
					return;
				}
				else if (this.method_112().method_199())
				{
					float num2 = this.activeUnit_0.vmethod_40() * float_5 / 3600f;
					float num3 = this.method_112().vmethod_16() - this.activeUnit_0.vmethod_14(false);
					if ((this.vmethod_3().bool_5 || this.vmethod_3().method_135()) && !Information.IsNothing(this.method_112().geoPoint_0) && this.method_112().geoPoint_0.method_9() <= 50f && Math.Abs(num3) < num / 4f * 1852f)
					{
						if (!this.method_113())
						{
							this.activeUnit_0.vmethod_73(this.method_112().vmethod_143().vmethod_30());
							this.method_119(geopoint_Struct.Value, float_5);
							return;
						}
					}
					else if (this.method_112().vmethod_6())
					{
						this.method_112().vmethod_73(this.method_112().vmethod_16());
						if (Information.IsNothing(geopoint_Struct))
						{
							this.method_120(this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null), float_5);
							return;
						}
						this.method_120(geopoint_Struct.Value.double_1, geopoint_Struct.Value.double_0, float_5);
						return;
					}
					else
					{
						if (num3 < 0f)
						{
							this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false) - num2 * Math.Abs(num3) / num);
							return;
						}
						this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false) + num2 * Math.Abs(num3) / num);
						return;
					}
				}
				else
				{
					float num4 = num / this.activeUnit_0.vmethod_40() * 3600f;
					float num5 = Math.Abs(this.activeUnit_0.vmethod_14(false) - this.method_112().vmethod_16()) / num4;
					float num6 = this.method_112().vmethod_16() - this.activeUnit_0.vmethod_14(false);
					if (this.method_112().vmethod_6())
					{
						this.method_112().vmethod_73(this.method_112().vmethod_16());
						if (geopoint_Struct == null)
						{
							this.method_120(this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null), float_5);
							return;
						}
						this.method_120(geopoint_Struct.Value.double_1, geopoint_Struct.Value.double_0, float_5);
						return;
					}
					else if (num6 < 0f)
					{
						this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false) - num5 * float_5);
						if (this.method_112().method_0())
						{
							this.method_112().vmethod_143().vmethod_15(true, num5);
							return;
						}
					}
					else
					{
						this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false) + num5);
						if (this.method_112().method_0())
						{
							this.method_112().vmethod_143().vmethod_15(true, num5);
						}
					}
				}
			}
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x001F7A98 File Offset: 0x001F5C98
		public virtual void vmethod_32()
		{
			try
			{
				float num;
				if (!Information.IsNothing(this.method_112().vmethod_142().vmethod_3()))
				{
					if (this.method_112().vmethod_142().vmethod_3().method_103())
					{
						this.method_112().vmethod_17(this.vmethod_3().vmethod_14(false));
						return;
					}
					if (this.method_112().vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Aimpoint && !Information.IsNothing(this.method_112().vmethod_142().vmethod_7()))
					{
						switch (this.method_112().vmethod_142().vmethod_7())
						{
						case Contact_Base.ContactType.Surface:
							num = 0f;
							goto IL_1D0;
						case Contact_Base.ContactType.Submarine:
							num = (float)Math.Max(this.method_112().vmethod_142().vmethod_3().method_9(false, false, false), -100);
							goto IL_1D0;
						case Contact_Base.ContactType.Aimpoint:
							if ((float)this.method_112().vmethod_142().vmethod_3().method_9(false, false, false) >= 0f)
							{
								num = (float)this.method_112().vmethod_142().vmethod_3().method_9(false, false, false);
								goto IL_1D0;
							}
							if (this.method_112().method_197())
							{
								num = (float)Math.Max(this.method_112().vmethod_142().vmethod_3().method_9(false, false, false), -100);
								goto IL_1D0;
							}
							num = 0f;
							goto IL_1D0;
						case Contact_Base.ContactType.Facility_Fixed:
						case Contact_Base.ContactType.Facility_Mobile:
							num = (float)this.method_112().vmethod_142().vmethod_3().method_9(false, false, false);
							goto IL_1D0;
						}
						num = (float)this.method_112().vmethod_142().vmethod_3().method_9(false, false, false);
					}
					else
					{
						num = (float)this.method_112().vmethod_142().vmethod_3().method_9(false, false, false);
					}
				}
				else
				{
					num = (float)this.method_112().method_9(false, false, false);
				}
				IL_1D0:
				if ((this.method_112().method_169() == Weapon.WeaponGuidanceType.Inertial || (!Information.IsNothing(this.method_112().vmethod_142().vmethod_3()) && (this.method_112().vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Aimpoint || (Enumerable.Count<Warhead>(this.method_112().warhead_0) > 0 && this.method_112().warhead_0[0].method_16(this.method_112(), this.activeUnit_0.vmethod_86().vmethod_3().activeUnit_0))))) && !this.method_112().bool_7 && this.method_112().method_187().method_47())
				{
					this.method_112().vmethod_17(this.activeUnit_0.vmethod_85().method_4()[0].imethod_4());
					if (!Information.IsNothing(this.vmethod_3()))
					{
						if (this.method_112().vmethod_16() < num)
						{
							if (num < 0f)
							{
								this.method_112().vmethod_17((float)this.method_112().method_206(this.activeUnit_0.vmethod_86().vmethod_3().activeUnit_0));
							}
							else
							{
								this.method_112().vmethod_17(num + (float)this.method_112().method_206(this.activeUnit_0.vmethod_86().vmethod_3().activeUnit_0));
							}
						}
					}
					else
					{
						Weapon._WeaponType weaponType = this.method_112().method_167();
						if (weaponType <= Weapon._WeaponType.GuidedProjectile)
						{
							if (weaponType != Weapon._WeaponType.GuidedWeapon && weaponType != Weapon._WeaponType.GuidedProjectile)
							{
								goto IL_4BB;
							}
						}
						else if (weaponType - Weapon._WeaponType.BallisticMissile > 1 && weaponType != Weapon._WeaponType.HGV)
						{
							goto IL_4BB;
						}
						if (this.method_112().vmethod_16() < num)
						{
							this.method_112().vmethod_17(num);
						}
						else if (num < 0f)
						{
							this.method_112().vmethod_17(0f);
						}
					}
				}
				else if (!Information.IsNothing(this.vmethod_3()) && num < 0f)
				{
					Weapon._WeaponType weaponType2 = this.method_112().method_167();
					if (weaponType2 <= Weapon._WeaponType.GuidedProjectile)
					{
						if (weaponType2 == Weapon._WeaponType.GuidedWeapon || weaponType2 == Weapon._WeaponType.GuidedProjectile)
						{
							goto IL_40D;
						}
					}
					else
					{
						if (weaponType2 - Weapon._WeaponType.BallisticMissile <= 1)
						{
							goto IL_40D;
						}
						if (weaponType2 == Weapon._WeaponType.HGV)
						{
							goto IL_40D;
						}
					}
					this.method_112().vmethod_17(num);
					goto IL_4BB;
					IL_40D:
					if (this.method_112().vmethod_16() < num)
					{
						this.method_112().vmethod_17(num);
					}
					else if (num < 0f)
					{
						this.method_112().vmethod_17(0f);
					}
				}
				else
				{
					Weapon._WeaponType weaponType3 = this.method_112().method_167();
					if (weaponType3 <= Weapon._WeaponType.GuidedProjectile)
					{
						if (weaponType3 != Weapon._WeaponType.GuidedWeapon && weaponType3 != Weapon._WeaponType.GuidedProjectile)
						{
							goto IL_4BB;
						}
					}
					else if (weaponType3 - Weapon._WeaponType.BallisticMissile > 1 && weaponType3 != Weapon._WeaponType.HGV)
					{
						goto IL_4BB;
					}
					if (this.method_112().vmethod_16() < num)
					{
						this.method_112().vmethod_17(num);
					}
					else if (num < 0f)
					{
						this.method_112().vmethod_17(0f);
					}
				}
				IL_4BB:;
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

		// Token: 0x06001BA3 RID: 7075 RVA: 0x001F7FB8 File Offset: 0x001F61B8
		public virtual void vmethod_33(float float_5)
		{
			try
			{
				this.vmethod_32();
				if (this.method_112().method_204() && this.method_112().vmethod_6() && this.method_112().method_221() && this.method_112().method_187().method_47())
				{
					this.method_112().vmethod_73(Enumerable.First<Waypoint>(this.method_112().method_187().method_4()).imethod_4());
					this.method_118(Enumerable.First<Waypoint>(this.method_112().method_187().method_4()), float_5);
				}
				else if (this.method_112().method_204() && this.method_112().method_221())
				{
					if (this.method_112().method_187().method_47())
					{
						this.method_112().vmethod_73(Enumerable.First<Waypoint>(this.method_112().method_187().method_4()).imethod_4());
						this.method_118(Enumerable.First<Waypoint>(this.method_112().method_187().method_4()), float_5);
					}
					else if (!this.method_112().vmethod_6())
					{
						this.method_112().vmethod_73(0f);
					}
					else if (this.method_112().method_78().Length > 0)
					{
						if (!Information.IsNothing(this.vmethod_3()))
						{
							this.method_112().vmethod_73(this.method_112().vmethod_16());
							this.method_120(this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null), float_5);
						}
						else
						{
							this.method_112().vmethod_23(this.method_112().vmethod_18());
						}
					}
				}
				else
				{
					if (!this.method_113())
					{
						if (this.method_112().bool_7)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							((Class171)this.method_112().vmethod_142()).vmethod_33(float_5);
						}
						else
						{
							if (this.method_112().method_187().method_47())
							{
								Waypoint waypoint = this.method_112().method_187().method_4()[0];
								if (this.activeUnit_0.vmethod_14(false) < waypoint.imethod_4())
								{
									float num = Math.Abs(this.activeUnit_0.vmethod_87().vmethod_48(this.activeUnit_0, waypoint.imethod_4(), 0f));
									if ((double)this.method_112().method_23(waypoint) < (double)num * 1.1)
									{
										this.activeUnit_0.vmethod_73(waypoint.imethod_4());
										this.method_118(null, float_5);
										return;
									}
								}
							}
							if (this.method_112().float_27 != 0f && this.method_112().vmethod_14(false) <= this.method_112().vmethod_143().vmethod_14(true))
							{
								if (this.method_112().method_204() && this.method_112().method_221())
								{
									this.method_112().vmethod_73(0f);
								}
								else
								{
									this.activeUnit_0.vmethod_73(this.method_112().float_27 + (float)Math.Max(0, (int)Terrain.smethod_7(this.method_112().vmethod_30(null), this.method_112().vmethod_28(null), false)));
								}
								if (!base.method_87())
								{
									this.method_118(null, float_5);
								}
								return;
							}
						}
					}
					if (this.method_112().float_27 != 0f && this.method_112().vmethod_14(false) < 8850f)
					{
						int num2 = (int)Terrain.smethod_7(this.method_112().vmethod_30(null), this.method_112().vmethod_28(null), false);
						if (num2 > 0 && this.method_112().vmethod_14(false) - (float)num2 <= this.method_112().vmethod_143().vmethod_14(true))
						{
							this.activeUnit_0.vmethod_73((float)num2 + this.method_112().float_27);
							if (!base.method_87())
							{
								this.method_118(null, float_5);
							}
							return;
						}
					}
					if (Information.IsNothing(this.vmethod_3()))
					{
						this.activeUnit_0.vmethod_73(base.method_6());
						this.method_120(base.method_2(), base.method_4(), float_5);
					}
					else if (this.method_112().float_27 == 0f && this.method_112().method_145() == 0f && this.activeUnit_0.vmethod_14(false) == this.method_112().vmethod_16() && !this.method_112().method_87())
					{
						this.activeUnit_0.vmethod_73(this.method_112().vmethod_16());
						this.method_120(this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null), float_5);
					}
					else if (this.method_112().float_27 == 0f && this.method_112().method_145() == 0f)
					{
						if (this.method_112().method_87())
						{
							this.method_112().vmethod_73(this.method_112().vmethod_14(false));
							this.method_118(null, float_5);
						}
						else if (this.activeUnit_0.vmethod_14(false) != this.method_112().vmethod_16())
						{
							this.method_121(float_5);
						}
					}
					else
					{
						this.vmethod_34(float_5);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100971", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x001F854C File Offset: 0x001F674C
		protected void method_122(float float_5)
		{
			float num = this.method_112().vmethod_14(false) / Math.Max(this.method_112().method_145(), this.method_112().float_27);
			double num2 = (double)(90f - 90f * num);
			if (this.method_112().vmethod_16() > this.method_112().vmethod_14(false) && !Information.IsNothing(new Geopoint_Struct?(this.method_112().method_187().method_62(this.method_112().method_20(), this.vmethod_3(), null))))
			{
				double num3 = Math.Atan2((double)(this.method_112().vmethod_16() - this.method_112().vmethod_14(false)), (double)(this.method_112().method_36(this.vmethod_3()) * 1852f)) * 57.2957795130823;
				if (num3 > num2)
				{
					num2 = num3;
				}
			}
			this.method_112().vmethod_23((float)num2);
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x001F863C File Offset: 0x001F683C
		private bool method_123()
		{
			bool result;
			if (Information.IsNothing(this.vmethod_3()))
			{
				result = false;
			}
			else
			{
				Contact_Base.ContactType contactType_ = this.vmethod_3().contactType_0;
				if (contactType_ != Contact_Base.ContactType.Aimpoint)
				{
					if (contactType_ != Contact_Base.ContactType.ActivationPoint)
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x001F8678 File Offset: 0x001F6878
		private void method_124(float float_5)
		{
			Geopoint_Struct? geopoint_Struct = null;
			try
			{
				if (this.vmethod_3() != null)
				{
					float num;
					float? nullable_;
					if (this.vmethod_3().vmethod_40() == 0f)
					{
						num = this.activeUnit_0.method_36(this.vmethod_3());
						geopoint_Struct = new Geopoint_Struct?(new Geopoint_Struct(this.vmethod_3().vmethod_28(null), this.vmethod_3().vmethod_30(null)));
					}
					else
					{
						float float_6;
						if (this.method_112().vmethod_6())
						{
							float_6 = (float)((double)this.method_112().vmethod_143().vmethod_38() * 0.5);
						}
						else
						{
							float_6 = (float)this.method_112().vmethod_143().vmethod_38();
						}
						nullable_ = new float?(this.activeUnit_0.method_39(this.vmethod_3(), this.method_112().method_20(), this.activeUnit_0.vmethod_9()));
						geopoint_Struct = new Geopoint_Struct?(this.method_112().method_187().method_62(float_6, this.vmethod_3(), nullable_));
						if (geopoint_Struct == null)
						{
							num = this.activeUnit_0.method_36(this.vmethod_3());
							geopoint_Struct = new Geopoint_Struct?(new Geopoint_Struct(this.vmethod_3().vmethod_28(null), this.vmethod_3().vmethod_30(null)));
						}
						else
						{
							num = this.method_112().method_24(geopoint_Struct.Value);
						}
					}
					int num2;
					if (this.method_112().method_187().method_47())
					{
						num2 = (int)Math.Round((double)this.method_112().method_187().method_4()[0].imethod_4());
					}
					else
					{
						num2 = (int)Math.Round((double)this.method_112().vmethod_16());
					}
					float float_7 = (float)num2 - this.activeUnit_0.vmethod_14(false);
					if (nullable_ == null)
					{
						nullable_ = new float?(this.activeUnit_0.method_39(this.vmethod_3(), this.method_112().method_20(), this.activeUnit_0.vmethod_9()));
					}
					Math.Abs(this.activeUnit_0.vmethod_87().vmethod_48(this.activeUnit_0, (float)num2, nullable_.Value));
					if (this.method_123() && this.vmethod_3().contactType_0 == Contact_Base.ContactType.ActivationPoint && this.method_112().method_277())
					{
						if (this.method_112().float_27 > 0f)
						{
							this.activeUnit_0.vmethod_73(this.method_112().float_27 + (float)Math.Max(0, this.method_112().method_10(false, 1f)));
						}
						else
						{
							this.activeUnit_0.vmethod_73(this.method_112().method_145());
						}
						if (this.activeUnit_0.vmethod_72() > this.activeUnit_0.vmethod_14(false) + 500f)
						{
							this.method_122(float_5);
						}
						else
						{
							this.method_118(null, float_5);
						}
					}
					else
					{
						float num3 = (float)((double)Math2.smethod_15(geopoint_Struct.Value.double_1, geopoint_Struct.Value.double_0, this.method_112().geoPoint_0.imethod_2(), this.method_112().geoPoint_0.imethod_0()) * 0.75);
						if (num > num3)
						{
							if (!this.method_113())
							{
								if (this.method_112().float_27 > 0f)
								{
									this.activeUnit_0.vmethod_73(this.method_112().float_27 + (float)Math.Max(0, this.method_112().method_10(false, 1f)));
								}
								else
								{
									this.activeUnit_0.vmethod_73(this.method_112().method_145());
								}
								if (this.activeUnit_0.vmethod_72() > this.activeUnit_0.vmethod_14(false) + 500f)
								{
									this.method_122(float_5);
								}
								else if (this.method_112().vmethod_6())
								{
									this.method_118(null, float_5);
								}
							}
							else
							{
								this.method_126(float_7, float_5);
							}
						}
						else
						{
							this.method_126(float_7, float_5);
						}
					}
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x001F8A9C File Offset: 0x001F6C9C
		private void method_125(float float_5)
		{
			try
			{
				Geopoint_Struct? geopoint_Struct = null;
				if (this.vmethod_3() != null)
				{
					float num;
					if (this.vmethod_3().vmethod_40() == 0f)
					{
						num = this.activeUnit_0.method_36(this.vmethod_3());
					}
					else
					{
						float float_6;
						if (this.method_112().vmethod_6())
						{
							float_6 = (float)((double)this.method_112().vmethod_143().vmethod_38() * 0.5);
						}
						else
						{
							float_6 = (float)this.method_112().vmethod_143().vmethod_38();
						}
						geopoint_Struct = new Geopoint_Struct?(this.method_112().method_187().method_62(float_6, this.vmethod_3(), null));
						if (Information.IsNothing(geopoint_Struct))
						{
							num = this.activeUnit_0.method_36(this.vmethod_3());
						}
						else
						{
							num = this.method_112().method_24(geopoint_Struct.Value);
						}
					}
					int num2;
					if (this.method_112().method_187().method_47())
					{
						num2 = (int)Math.Round((double)this.method_112().method_187().method_4()[0].imethod_4());
					}
					else
					{
						num2 = (int)Math.Round((double)this.method_112().vmethod_16());
					}
					float float_7 = (float)num2 - this.activeUnit_0.vmethod_14(false);
					float closureSpeed = this.activeUnit_0.method_39(this.vmethod_3(), this.method_112().method_20(), this.activeUnit_0.vmethod_9());
					float num3 = Math.Abs(this.activeUnit_0.vmethod_87().vmethod_48(this.activeUnit_0, (float)num2, closureSpeed));
					if (this.method_112().method_204())
					{
						if (!this.method_112().method_221())
						{
							if (this.method_112().float_27 > 0f)
							{
								this.activeUnit_0.vmethod_73(this.method_112().float_27);
							}
							else
							{
								this.activeUnit_0.vmethod_73(this.method_112().method_145());
							}
							if (this.activeUnit_0.vmethod_72() > this.activeUnit_0.vmethod_14(false))
							{
								this.method_122(float_5);
							}
							else
							{
								this.method_118(null, float_5);
							}
						}
						else if (this.method_112().method_187().method_47())
						{
							if (Enumerable.First<Waypoint>(this.method_112().method_187().method_4()).imethod_4() < this.activeUnit_0.vmethod_14(false) && this.method_112().method_276())
							{
								this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false));
							}
							else
							{
								this.activeUnit_0.vmethod_73(Enumerable.First<Waypoint>(this.method_112().method_187().method_4()).imethod_4());
								this.method_118(Enumerable.First<Waypoint>(this.method_112().method_187().method_4()), float_5);
							}
						}
						else
						{
							this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false) - float_5 * this.activeUnit_0.vmethod_87().vmethod_21());
							this.method_118(null, float_5);
						}
					}
					else if (this.method_123() && this.vmethod_3().contactType_0 == Contact_Base.ContactType.ActivationPoint)
					{
						if (this.method_112().float_27 > 0f)
						{
							this.activeUnit_0.vmethod_73(this.method_112().float_27 + (float)Math.Max(0, this.method_112().method_10(false, 1f)));
						}
						else
						{
							this.activeUnit_0.vmethod_73(this.method_112().method_145());
						}
						if (this.activeUnit_0.vmethod_72() > this.activeUnit_0.vmethod_14(false) + 500f)
						{
							this.method_122(float_5);
						}
						else
						{
							this.method_118(null, float_5);
						}
					}
					else
					{
						float num4 = (float)((double)this.method_112().method_159() * 0.25);
						if (num <= num3 && (num <= num4 || (this.vmethod_3().contactType_0 != Contact_Base.ContactType.Air && this.vmethod_3().contactType_0 != Contact_Base.ContactType.Missile) || !Information.IsNothing(this.method_112().method_179())))
						{
							this.method_126(float_7, float_5);
						}
						else if (!this.method_113())
						{
							if (this.method_112().float_27 > 0f)
							{
								this.activeUnit_0.vmethod_73(this.method_112().float_27 + (float)Math.Max(0, this.method_112().method_10(false, 1f)));
							}
							else
							{
								this.activeUnit_0.vmethod_73(this.method_112().method_145());
							}
							if (this.activeUnit_0.vmethod_72() > this.activeUnit_0.vmethod_14(false) + 500f)
							{
								this.method_122(float_5);
							}
							else
							{
								this.method_118(null, float_5);
							}
						}
						else
						{
							this.method_126(float_7, float_5);
						}
					}
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0000DCBE File Offset: 0x0000BEBE
		protected virtual void vmethod_34(float float_5)
		{
			if (!Information.IsNothing(this.vmethod_3()))
			{
				if (this.vmethod_3().method_103())
				{
					this.method_124(float_5);
					return;
				}
				this.method_125(float_5);
			}
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x001F8F7C File Offset: 0x001F717C
		private void method_126(float float_5, float float_6)
		{
			if (!this.method_113())
			{
				this.method_114(true);
			}
			Geopoint_Struct? geopoint_Struct = new Geopoint_Struct?(this.method_112().method_187().method_62(this.method_112().method_20(), this.vmethod_3(), null));
			float num;
			if (Information.IsNothing(geopoint_Struct))
			{
				num = this.activeUnit_0.method_36(this.vmethod_3());
			}
			else
			{
				num = this.activeUnit_0.method_24(geopoint_Struct.Value);
			}
			if (float_5 < 0f)
			{
				if (!this.method_112().vmethod_6())
				{
					float num2 = this.activeUnit_0.vmethod_40() * float_6 / 3600f;
					this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false) - num2 * Math.Abs(float_5) / num);
					return;
				}
				this.activeUnit_0.vmethod_73(this.method_112().vmethod_16());
				if (Information.IsNothing(geopoint_Struct))
				{
					this.method_120(this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null), float_6);
					return;
				}
				this.method_120(geopoint_Struct.Value.double_1, geopoint_Struct.Value.double_0, float_6);
				return;
			}
			else
			{
				if (!this.method_112().vmethod_6())
				{
					float num3 = this.activeUnit_0.vmethod_40() * float_6 / 3600f;
					this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_14(false) + num3 * Math.Abs(float_5) / num);
					return;
				}
				this.activeUnit_0.vmethod_73(this.method_112().vmethod_16());
				if (Information.IsNothing(geopoint_Struct))
				{
					this.method_120(this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null), float_6);
					return;
				}
				this.method_120(geopoint_Struct.Value.double_1, geopoint_Struct.Value.double_0, float_6);
				return;
			}
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0000DCE9 File Offset: 0x0000BEE9
		[CompilerGenerated]
		private double method_127(Contact contact_8)
		{
			return contact_8.method_31(this.activeUnit_0);
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0000DCE9 File Offset: 0x0000BEE9
		[CompilerGenerated]
		private double method_128(Contact contact_8)
		{
			return contact_8.method_31(this.activeUnit_0);
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0000DCF7 File Offset: 0x0000BEF7
		[CompilerGenerated]
		private float method_129(Contact contact_8)
		{
			return this.activeUnit_0.method_37(contact_8, 0f);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0000DCF7 File Offset: 0x0000BEF7
		[CompilerGenerated]
		private float method_130(Contact contact_8)
		{
			return this.activeUnit_0.method_37(contact_8, 0f);
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x0000DD0A File Offset: 0x0000BF0A
		[CompilerGenerated]
		private bool method_131(Contact contact_8)
		{
			return contact_8.method_68().Keys.Contains(this.method_112().keyValuePair_0.Key);
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0000DD2C File Offset: 0x0000BF2C
		[CompilerGenerated]
		private float method_132(Contact contact_8)
		{
			return this.activeUnit_0.method_32(contact_8);
		}

		// Token: 0x040018C0 RID: 6336
		private Weapon_AI.Enum131? nullable_10;

		// Token: 0x040018C1 RID: 6337
		private bool bool_11;

		// Token: 0x040018C2 RID: 6338
		private float float_3;

		// Token: 0x040018C3 RID: 6339
		private float float_4;

		// Token: 0x040018C4 RID: 6340
		private Weapon weapon_0;

		// Token: 0x0200038B RID: 907
		internal enum Enum131 : byte
		{
			// Token: 0x040018C6 RID: 6342
			const_0,
			// Token: 0x040018C7 RID: 6343
			const_1
		}
	}
}
