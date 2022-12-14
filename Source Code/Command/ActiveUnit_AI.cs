using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
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
	// Token: 0x0200012D RID: 301
	public class ActiveUnit_AI
	{
		// Token: 0x060007CA RID: 1994 RVA: 0x000073D3 File Offset: 0x000055D3
		[CompilerGenerated]
		protected virtual ObservableDictionary<string, ActiveUnit_AI.TargetingEntry> vmethod_0()
		{
			return this.observableDictionary_0;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0007E5EC File Offset: 0x0007C7EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		protected virtual void vmethod_1(ObservableDictionary<string, ActiveUnit_AI.TargetingEntry> observableDictionary_1)
		{
			INotifyDictionaryChanged<string, ActiveUnit_AI.TargetingEntry>.DictionaryChangedEventHandler obj = new INotifyDictionaryChanged<string, ActiveUnit_AI.TargetingEntry>.DictionaryChangedEventHandler(this.method_85);
			ObservableDictionary<string, ActiveUnit_AI.TargetingEntry> observableDictionary = this.observableDictionary_0;
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

		// Token: 0x060007CC RID: 1996 RVA: 0x000073DB File Offset: 0x000055DB
		internal List<Contact> method_0()
		{
			return this.list_0;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000073E3 File Offset: 0x000055E3
		internal void method_1(List<Contact> list_2)
		{
			this.list_0 = list_2;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0007E630 File Offset: 0x0007C830
		public virtual void vmethod_2(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			try
			{
				if (this.vmethod_3() != null)
				{
					xmlWriter_0.WriteElementString("PrimaryTarget", this.vmethod_3().string_0);
				}
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "PrimaryTarget_Type";
				int i = (int)this.contactType_0;
				xmlWriter.WriteElementString(localName, i.ToString());
				if (this.contact_1 != null)
				{
					xmlWriter_0.WriteElementString("PrimaryThreat", this.contact_1.string_0);
				}
				if (this.method_2() != 0.0)
				{
					xmlWriter_0.WriteElementString("PrimaryTarget_LastKnown_Lat", XmlConvert.ToString(this.method_2()));
				}
				if (this.method_4() != 0.0)
				{
					xmlWriter_0.WriteElementString("PrimaryTarget_LastKnown_Lon", XmlConvert.ToString(this.method_4()));
				}
				if (this.method_6() != 0f)
				{
					xmlWriter_0.WriteElementString("PrimaryTarget_LastKnown_Alt", XmlConvert.ToString(this.method_6()));
				}
				xmlWriter_0.WriteElementString("TTNPTE", this.float_1.ToString());
				xmlWriter_0.WriteElementString("PTOE", this.bool_0.ToString());
				xmlWriter_0.WriteElementString("HPos", this.bool_4.ToString());
				xmlWriter_0.WriteElementString("FCLIO", this.bool_1.ToString());
				if (!this.bool_9)
				{
					xmlWriter_0.WriteElementString("ET_E", "False");
				}
				if (!this.bool_10)
				{
					xmlWriter_0.WriteElementString("DPT_E", "False");
				}
				if (this.bool_2)
				{
					xmlWriter_0.WriteElementString("IE", this.bool_2.ToString());
				}
				if (this.geoPoint_0 != null)
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
							xmlWriter_0.WriteRaw(targetingEntry.method_0(this.activeUnit_0.vmethod_7(false)));
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
				if (this.method_15().Length > 0)
				{
					xmlWriter_0.WriteStartElement("Threats");
					foreach (Contact contact in Enumerable.ToArray<Contact>(this.contact_2))
					{
						if (contact != null)
						{
							xmlWriter_0.WriteRaw(contact.method_61(hashSet_1));
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (this.nullable_1 != null)
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

		// Token: 0x060007CF RID: 1999 RVA: 0x0007E938 File Offset: 0x0007CB38
		public static void smethod_0(XmlNode xmlNode_0, Dictionary<string, Class310> dictionary_0, ActiveUnit activeUnit_1)
		{
			try
			{
				ActiveUnit_AI activeUnit_AI = new ActiveUnit_AI();
				activeUnit_AI.activeUnit_0 = activeUnit_1;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num > 1925531877U)
						{
							if (num <= 2722719197U)
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
											activeUnit_AI.method_3(XmlConvert.ToDouble(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Lon", false) == 0)
										{
											activeUnit_AI.method_5(XmlConvert.ToDouble(xmlNode.InnerText));
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
											if (num != 2722719197U)
											{
												continue;
											}
											if (Operators.CompareString(name, "PTOE", false) != 0)
											{
												continue;
											}
											goto IL_45F;
										}
										else
										{
											if (Operators.CompareString(name, "TargetList", false) != 0)
											{
												continue;
											}
											try
											{
												foreach (object obj2 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode2 = (XmlNode)obj2;
													ActiveUnit_AI.TargetingEntry targetingEntry = ActiveUnit_AI.TargetingEntry.smethod_0(ref xmlNode2, ref dictionary_0);
													activeUnit_AI.vmethod_0().Add(targetingEntry.contact_0.string_0, targetingEntry);
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
									if (Operators.CompareString(name, "FCLIO", false) == 0)
									{
										goto IL_3E5;
									}
									continue;
								}
							}
							else if (num <= 3770421268U)
							{
								if (num != 2783884855U)
								{
									if (num != 3761246852U)
									{
										if (num != 3770421268U)
										{
											continue;
										}
										if (Operators.CompareString(name, "ET_E", false) == 0)
										{
											activeUnit_AI.bool_9 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else if (Operators.CompareString(name, "PrimaryTargetOverrideExists", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "HPos", false) == 0)
									{
										goto IL_486;
									}
									continue;
								}
							}
							else if (num != 3957045325U)
							{
								if (num != 4025372673U)
								{
									if (num != 4076649232U)
									{
										continue;
									}
									if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Alt", false) == 0)
									{
										activeUnit_AI.method_7(XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "PrimaryTarget_Type", false) != 0)
									{
										continue;
									}
									if (Versioned.IsNumeric(xmlNode.InnerText))
									{
										activeUnit_AI.contactType_0 = (Contact_Base.ContactType)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									activeUnit_AI.contactType_0 = (Contact_Base.ContactType)Enum.Parse(typeof(Contact_Base.ContactType), xmlNode.InnerText, true);
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "IPC", false) == 0)
								{
									goto IL_551;
								}
								continue;
							}
							IL_45F:
							activeUnit_AI.bool_0 = Conversions.ToBoolean(xmlNode.InnerText);
							continue;
						}
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
									goto IL_551;
								}
								else
								{
									if (Operators.CompareString(name, "PrimaryTarget", false) == 0)
									{
										activeUnit_AI.contact_0 = Contact.smethod_0(xmlNode.InnerText, ref dictionary_0);
										continue;
									}
									continue;
								}
							}
							else if (num != 402376870U)
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
										foreach (object obj3 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode3 = (XmlNode)obj3;
											Contact contact = Contact.smethod_1(ref xmlNode3, ref dictionary_0);
											Class429.smethod_13(ref activeUnit_AI.contact_2, contact);
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
								if (Operators.CompareString(name, "PrimaryThreat", false) == 0)
								{
									activeUnit_AI.contact_1 = Contact.smethod_0(xmlNode.InnerText, ref dictionary_0);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "SnakeAxis", false) == 0)
								{
									activeUnit_AI.nullable_1 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
									continue;
								}
								continue;
							}
						}
						else if (num <= 1474882803U)
						{
							if (num != 866975591U)
							{
								if (num != 868927472U)
								{
									if (num != 1474882803U)
									{
										continue;
									}
									if (Operators.CompareString(name, "IE", false) == 0)
									{
										activeUnit_AI.bool_2 = true;
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "LKTL", false) == 0)
									{
										activeUnit_AI.geoPoint_0 = GeoPoint.smethod_0(ref xmlNode, ref dictionary_0);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "DPT_E", false) == 0)
								{
									activeUnit_AI.bool_10 = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num != 1610968176U)
						{
							if (num != 1894470373U)
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
								if (Operators.CompareString(name, "HP", false) != 0)
								{
									continue;
								}
								goto IL_486;
							}
						}
						else
						{
							if (Operators.CompareString(name, "TTNPTE", false) == 0)
							{
								activeUnit_AI.float_1 = Conversions.ToSingle(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						IL_3E5:
						activeUnit_AI.bool_1 = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_486:
						activeUnit_AI.bool_4 = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_551:
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
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100022", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0007EFE8 File Offset: 0x0007D1E8
		private ActiveUnit_AI()
		{
			this.hashSet_0 = new HashSet<string>();
			this.vmethod_1(new ObservableDictionary<string, ActiveUnit_AI.TargetingEntry>());
			this.contact_2 = new Contact[0];
			this.geopoint_Struct_0 = default(Geopoint_Struct);
			this.bool_3 = false;
			this.list_0 = new List<Contact>();
			this.bool_8 = false;
			this.bool_9 = true;
			this.bool_10 = true;
			this.double_2 = 0.0;
			this.double_3 = 0.0;
			this.list_1 = new List<ValueTuple<ValueTuple<double, double, float, short>>>();
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x000073EC File Offset: 0x000055EC
		public double method_2()
		{
			return this.double_0;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x000073F4 File Offset: 0x000055F4
		public void method_3(double double_4)
		{
			if (!Information.IsNothing(double_4))
			{
				this.double_0 = double_4;
			}
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0000740A File Offset: 0x0000560A
		public double method_4()
		{
			return this.double_1;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00007412 File Offset: 0x00005612
		public void method_5(double double_4)
		{
			if (!Information.IsNothing(double_4))
			{
				this.double_1 = double_4;
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00007428 File Offset: 0x00005628
		public float method_6()
		{
			return this.float_0;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00007430 File Offset: 0x00005630
		public void method_7(float float_3)
		{
			if (!Information.IsNothing(float_3))
			{
				this.float_0 = float_3;
			}
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00007446 File Offset: 0x00005646
		public virtual Contact vmethod_3()
		{
			return this.contact_0;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0007F074 File Offset: 0x0007D274
		public virtual void vmethod_4(Contact contact_8)
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (contact_8 != this.contact_0)
					{
						if (!Information.IsNothing(this.contact_0))
						{
							this.contact_0.method_120(this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_7(false), false, null).TryRemove(this.activeUnit_0.string_0, ref this.activeUnit_0);
						}
						if (!Information.IsNothing(contact_8))
						{
							try
							{
								if (Information.IsNothing(this.activeUnit_0))
								{
									return;
								}
								contact_8.method_120(this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_7(false), false, null).TryAdd(this.activeUnit_0.string_0, this.activeUnit_0);
							}
							catch (Exception ex)
							{
								ex.Data.Add("Error at 101190", "");
								GameGeneral.smethod_25(ref ex);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
							}
						}
						if (!Information.IsNothing(this.activeUnit_0) && !Information.IsNothing(this.activeUnit_0.vmethod_85()) && this.activeUnit_0.vmethod_85().method_44())
						{
							this.activeUnit_0.vmethod_85().method_18();
						}
						this.contact_0 = contact_8;
						if (!Information.IsNothing(contact_8))
						{
							this.contactType_0 = contact_8.contactType_0;
						}
					}
					if (!Information.IsNothing(contact_8))
					{
						this.method_3(contact_8.vmethod_30(null));
						this.method_5(contact_8.vmethod_28(null));
						this.method_7(contact_8.vmethod_14(false));
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100023", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0000744E File Offset: 0x0000564E
		public virtual Contact vmethod_5()
		{
			return this.contact_1;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00007456 File Offset: 0x00005656
		public virtual void vmethod_6(Contact contact_8)
		{
			this.contact_1 = contact_8;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0000745F File Offset: 0x0000565F
		public virtual Contact_Base.ContactType vmethod_7()
		{
			return this.contactType_0;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00007467 File Offset: 0x00005667
		public virtual void vmethod_8(Contact_Base.ContactType contactType_1)
		{
			this.contactType_0 = contactType_1;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00007470 File Offset: 0x00005670
		internal Unit method_8()
		{
			return this.unit_0;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0007F280 File Offset: 0x0007D480
		internal void method_9(Unit unit_1)
		{
			try
			{
				this.unit_0 = unit_1;
				if (Information.IsNothing(unit_1) && !Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.vmethod_85().method_47() && Enumerable.Last<Waypoint>(this.activeUnit_0.vmethod_85().method_4()).waypointType_0 == Waypoint.WaypointType.PickupPoint)
				{
					this.activeUnit_0.vmethod_85().vmethod_9();
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

		// Token: 0x060007DF RID: 2015 RVA: 0x0007F334 File Offset: 0x0007D534
		internal void method_10()
		{
			try
			{
				if (this.hashSet_0.Count == 0)
				{
					this.method_9(null);
				}
				else
				{
					List<Unit> list = new List<Unit>();
					int num = this.hashSet_0.Count - 1;
					int num2;
					for (int i = 0; i <= num; i++)
					{
						string text = Enumerable.ElementAtOrDefault<string>(this.hashSet_0, i);
						if (text.StartsWith("ActiveUnit_"))
						{
							string text2 = text.Split(new char[]
							{
								'_'
							})[1];
							if (this.activeUnit_0.scenario_0.vmethod_0().ContainsKey(text2))
							{
								ActiveUnit activeUnit = this.activeUnit_0.scenario_0.vmethod_0()[text2];
								if (activeUnit.method_82())
								{
									this.hashSet_0.Remove(text);
									if (activeUnit == this.method_8())
									{
										this.method_9(null);
									}
								}
								else
								{
									Dictionary<int, int> dictionary = new Dictionary<int, int>();
									Cargo[] cargo_ = activeUnit.cargo_0;
									checked
									{
										for (int j = 0; j < cargo_.Length; j++)
										{
											Mount mount = (Mount)cargo_[j].method_25();
											if (dictionary.ContainsKey(mount.DBID))
											{
												Dictionary<int, int> dictionary2;
												(dictionary2 = dictionary)[num2 = mount.DBID] = unchecked(dictionary2[num2] + 1);
											}
											else
											{
												dictionary.Add(mount.DBID, 1);
											}
										}
									}
									try
									{
										foreach (Mount mount2 in activeUnit.vmethod_51())
										{
											if (mount2.cargoType_0 != CargoType.NoCargo)
											{
												if (dictionary.ContainsKey(mount2.DBID))
												{
													Dictionary<int, int> dictionary2;
													(dictionary2 = dictionary)[num2 = mount2.DBID] = dictionary2[num2] + 1;
												}
												else
												{
													dictionary.Add(mount2.DBID, 1);
												}
											}
										}
									}
									finally
									{
										List<Mount>.Enumerator enumerator;
										((IDisposable)enumerator).Dispose();
									}
									if (dictionary.Count == 0)
									{
										this.activeUnit_0.method_124(this.activeUnit_0.Name + " is aborting pickup from " + activeUnit.Name + " (Reason: The transfer source does not have any cargo item to retrieve)", this.activeUnit_0.Name + " borting pickup", LoggedMessage.MessageType.UnitAI, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
										this.hashSet_0.Remove(text);
										if (activeUnit == this.method_8())
										{
											this.method_9(null);
										}
									}
									else if (ActiveUnit_DockingOps.smethod_11((Interface3)activeUnit, (Interface3)this.activeUnit_0, dictionary).Count == 0)
									{
										this.activeUnit_0.method_124(this.activeUnit_0.Name + " is aborting pickup from " + activeUnit.Name + " (Reason: Cannot transfer any of the available cargo items)", this.activeUnit_0.Name + " borting pickup", LoggedMessage.MessageType.UnitAI, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
										this.hashSet_0.Remove(text);
										if (activeUnit == this.method_8())
										{
											this.method_9(null);
										}
									}
									else
									{
										list.Add(activeUnit);
									}
								}
							}
							else
							{
								this.hashSet_0.Remove(text);
								if (!Information.IsNothing(this.method_8()) && this.method_8().bool_0 && Operators.CompareString(this.method_8().string_0, text2, false) == 0)
								{
									this.method_9(null);
								}
							}
						}
					}
					num2 = list.Count;
					if (num2 != 0)
					{
						if (num2 != 1)
						{
							this.method_9(Enumerable.ElementAtOrDefault<Unit>(Enumerable.OrderBy<Unit, float>(list, new Func<Unit, float>(this.method_89)), 0));
						}
						else
						{
							this.method_9(list[0]);
						}
					}
					else
					{
						this.method_9(null);
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

		// Token: 0x060007E0 RID: 2016 RVA: 0x00003024 File Offset: 0x00001224
		public virtual bool vmethod_9()
		{
			return false;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0007F768 File Offset: 0x0007D968
		public bool method_11(Contact contact_8)
		{
			return (!Information.IsNothing(this.vmethod_3()) && this.vmethod_3() == contact_8) || this.vmethod_0().ContainsKey(contact_8.string_0);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0007F7AC File Offset: 0x0007D9AC
		public Contact[] method_12()
		{
			Contact[] result;
			try
			{
				if (this.contact_3 == null)
				{
					Contact[] array = new Contact[0];
					if (this.vmethod_0().Count > 0)
					{
						List<Contact> list = new List<Contact>();
						foreach (KeyValuePair<string, ActiveUnit_AI.TargetingEntry> keyValuePair in this.vmethod_0())
						{
							ActiveUnit_AI.TargetingEntry value = keyValuePair.Value;
							if (value.contact_0 != null)
							{
								list.Add(value.contact_0);
							}
						}
						array = list.ToArray();
					}
					this.contact_3 = array;
				}
				result = this.contact_3;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100024", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				Contact[] array2 = new Contact[0];
				this.contact_3 = array2;
				result = this.contact_3;
			}
			return result;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0007F890 File Offset: 0x0007DA90
		public HashSet<string> method_13()
		{
			HashSet<string> result;
			try
			{
				HashSet<string> hashSet = new HashSet<string>();
				foreach (Contact contact in this.method_12())
				{
					hashSet.Add(contact.string_0);
				}
				result = hashSet;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101298", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0007F91C File Offset: 0x0007DB1C
		public ActiveUnit_AI.TargetingEntry[] method_14()
		{
			ActiveUnit_AI.TargetingEntry[] result;
			try
			{
				bool flag = false;
				if (Information.IsNothing(this.targetingEntry_0))
				{
					flag = true;
				}
				else if (this.method_12().Length != Enumerable.Count<ActiveUnit_AI.TargetingEntry>(this.targetingEntry_0))
				{
					flag = true;
				}
				else if (this.activeUnit_0.bool_3 && (Math.Abs(this.activeUnit_0.vmethod_30(null) - this.double_2) > 0.2 || Math.Abs(this.activeUnit_0.vmethod_28(null) - this.double_3) > 0.2))
				{
					flag = true;
				}
				else if (!this.activeUnit_0.bool_3 && (Math.Abs(this.activeUnit_0.vmethod_30(null) - this.double_2) > 0.05 || Math.Abs(this.activeUnit_0.vmethod_28(null) - this.double_3) > 0.05))
				{
					flag = true;
				}
				else
				{
					bool? flag2;
					bool? flag6;
					if (Information.IsNothing(this.nullable_6))
					{
						flag2 = new bool?(false);
					}
					else
					{
						float? num = this.nullable_6;
						bool? flag4;
						bool? flag3 = flag4 = ((num != null) ? new bool?(num.GetValueOrDefault() < 15f) : null);
						if (flag4 != null && flag3.GetValueOrDefault())
						{
							flag2 = new bool?(true);
						}
						else
						{
							bool? flag5;
							if (Information.IsNothing(this.activeUnit_0.vmethod_89().method_54()))
							{
								flag5 = new bool?(false);
							}
							else
							{
								num = this.nullable_6;
								double? num2 = (num != null) ? new double?((double)num.GetValueOrDefault()) : null;
								double num3 = (double)this.activeUnit_0.vmethod_89().method_54().float_29 * 1.5;
								flag5 = ((num2 != null) ? new bool?(num2.GetValueOrDefault() < num3) : null);
							}
							flag6 = (flag4 = flag5);
							flag2 = ((flag4 != null) ? (flag3 | flag6.GetValueOrDefault()) : null);
						}
					}
					flag6 = flag2;
					if (flag6.GetValueOrDefault())
					{
						flag = true;
					}
					else
					{
						bool? flag3;
						bool? flag7;
						if (Information.IsNothing(this.nullable_7))
						{
							flag7 = new bool?(false);
						}
						else
						{
							float? num = this.nullable_7;
							bool? flag4;
							flag6 = (flag4 = ((num != null) ? new bool?(num.GetValueOrDefault() < 15f) : null));
							if (flag4 != null && flag6.GetValueOrDefault())
							{
								flag7 = new bool?(true);
							}
							else
							{
								bool? flag8;
								if (Information.IsNothing(this.activeUnit_0.vmethod_89().method_55(false)))
								{
									flag8 = new bool?(false);
								}
								else
								{
									num = this.nullable_7;
									double? num2 = (num != null) ? new double?((double)num.GetValueOrDefault()) : null;
									double num3 = (double)this.activeUnit_0.vmethod_89().method_55(false).float_31 * 1.2;
									flag8 = ((num2 != null) ? new bool?(num2.GetValueOrDefault() < num3) : null);
								}
								flag3 = (flag4 = flag8);
								flag7 = ((flag4 != null) ? (flag6 | flag3.GetValueOrDefault()) : null);
							}
						}
						flag3 = flag7;
						if (flag3.GetValueOrDefault())
						{
							flag = true;
						}
						else
						{
							bool? flag9;
							if (Information.IsNothing(this.nullable_8))
							{
								flag9 = new bool?(false);
							}
							else
							{
								float? num = this.nullable_8;
								bool? flag4;
								flag3 = (flag4 = ((num != null) ? new bool?(num.GetValueOrDefault() < 15f) : null));
								if (flag4 != null && flag3.GetValueOrDefault())
								{
									flag9 = new bool?(true);
								}
								else
								{
									bool? flag10;
									if (Information.IsNothing(this.activeUnit_0.vmethod_89().method_57()))
									{
										flag10 = new bool?(false);
									}
									else
									{
										num = this.nullable_8;
										double? num2 = (num != null) ? new double?((double)num.GetValueOrDefault()) : null;
										double num3 = (double)this.activeUnit_0.vmethod_89().method_57().float_35 * 1.2;
										flag10 = ((num2 != null) ? new bool?(num2.GetValueOrDefault() < num3) : null);
									}
									flag6 = (flag4 = flag10);
									flag9 = ((flag4 != null) ? (flag3 | flag6.GetValueOrDefault()) : null);
								}
							}
							flag6 = flag9;
							if (flag6.GetValueOrDefault())
							{
								flag = true;
							}
							else
							{
								bool? flag11;
								if (Information.IsNothing(this.nullable_9))
								{
									flag11 = new bool?(false);
								}
								else
								{
									float? num = this.nullable_9;
									bool? flag4;
									flag6 = (flag4 = ((num != null) ? new bool?(num.GetValueOrDefault() < 15f) : null));
									if (flag4 != null && flag6.GetValueOrDefault())
									{
										flag11 = new bool?(true);
									}
									else
									{
										bool? flag12;
										if (Information.IsNothing(this.activeUnit_0.vmethod_89().method_56(false)))
										{
											flag12 = new bool?(false);
										}
										else
										{
											num = this.nullable_9;
											double? num2 = (num != null) ? new double?((double)num.GetValueOrDefault()) : null;
											double num3 = (double)this.activeUnit_0.vmethod_89().method_56(false).float_33 * 1.2;
											flag12 = ((num2 != null) ? new bool?(num2.GetValueOrDefault() < num3) : null);
										}
										flag3 = (flag4 = flag12);
										flag11 = ((flag4 != null) ? (flag6 | flag3.GetValueOrDefault()) : null);
									}
								}
								flag3 = flag11;
								if (flag3.GetValueOrDefault())
								{
									flag = true;
								}
								else
								{
									try
									{
										foreach (ActiveUnit_AI.TargetingEntry targetingEntry in this.vmethod_0().Values)
										{
											if (!Information.IsNothing(targetingEntry.contact_0))
											{
												if (targetingEntry.contact_0.method_103())
												{
													if (Math.Abs(targetingEntry.contact_0.vmethod_30(null) - targetingEntry.double_0) <= 0.2)
													{
														if (Math.Abs(targetingEntry.contact_0.vmethod_28(null) - targetingEntry.double_1) <= 0.2)
														{
															continue;
														}
													}
													flag = true;
												}
												else
												{
													if (Math.Abs(targetingEntry.contact_0.vmethod_30(null) - targetingEntry.double_0) <= 0.05 && Math.Abs(targetingEntry.contact_0.vmethod_28(null) - targetingEntry.double_1) <= 0.05)
													{
														continue;
													}
													flag = true;
												}
												break;
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
								}
							}
						}
					}
				}
				if (flag)
				{
					this.targetingEntry_0 = this.method_66(this.vmethod_0());
					this.contact_4 = null;
					this.contact_5 = null;
					this.contact_6 = null;
					this.contact_7 = null;
					foreach (ActiveUnit_AI.TargetingEntry targetingEntry2 in this.targetingEntry_0)
					{
						if (!Information.IsNothing(targetingEntry2.contact_0))
						{
							if (targetingEntry2.contact_0.method_103())
							{
								if (Information.IsNothing(this.contact_4))
								{
									this.contact_4 = targetingEntry2.contact_0;
								}
							}
							else if (targetingEntry2.contact_0.method_108())
							{
								if (Information.IsNothing(this.contact_5))
								{
									this.contact_5 = targetingEntry2.contact_0;
								}
							}
							else if (targetingEntry2.contact_0.method_136())
							{
								if (Information.IsNothing(this.contact_6))
								{
									this.contact_6 = targetingEntry2.contact_0;
								}
							}
							else if (targetingEntry2.contact_0.method_135() && Information.IsNothing(this.contact_7))
							{
								this.contact_7 = targetingEntry2.contact_0;
							}
							targetingEntry2.double_0 = targetingEntry2.contact_0.vmethod_30(null);
							targetingEntry2.double_1 = targetingEntry2.contact_0.vmethod_28(null);
						}
					}
					this.double_2 = this.activeUnit_0.vmethod_30(null);
					this.double_3 = this.activeUnit_0.vmethod_28(null);
				}
				if (!Information.IsNothing(this.contact_4))
				{
					this.nullable_6 = new float?(this.activeUnit_0.method_37(this.contact_4, 0f));
				}
				if (!Information.IsNothing(this.contact_5))
				{
					this.nullable_7 = new float?(this.activeUnit_0.method_37(this.contact_5, 0f));
				}
				if (!Information.IsNothing(this.contact_6))
				{
					this.nullable_8 = new float?(this.activeUnit_0.method_37(this.contact_6, 0f));
				}
				if (!Information.IsNothing(this.contact_7))
				{
					this.nullable_9 = new float?(this.activeUnit_0.method_37(this.contact_7, 0f));
				}
				result = this.targetingEntry_0;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101271", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00007478 File Offset: 0x00005678
		public Contact[] method_15()
		{
			return this.contact_2;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00007480 File Offset: 0x00005680
		public void method_16(string string_1)
		{
			this.hashSet_0.Add(string_1);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0000748F File Offset: 0x0000568F
		public void method_17(string string_1)
		{
			this.hashSet_0.Remove(string_1);
			if (!Information.IsNothing(this.method_8()) && Operators.CompareString(this.method_8().string_0, string_1, false) == 0)
			{
				this.method_9(null);
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x000802F0 File Offset: 0x0007E4F0
		public GeoPoint method_18()
		{
			GeoPoint result;
			try
			{
				GeoPoint geoPoint = null;
				ActiveUnit._ActiveUnitStatus activeUnitStatus = this.activeUnit_0.vmethod_108();
				if (activeUnitStatus <= ActiveUnit._ActiveUnitStatus.RTB_Manual)
				{
					if (activeUnitStatus != ActiveUnit._ActiveUnitStatus.OnPlottedCourse)
					{
						if (activeUnitStatus != ActiveUnit._ActiveUnitStatus.RTB && activeUnitStatus != ActiveUnit._ActiveUnitStatus.RTB_Manual)
						{
							goto IL_FC;
						}
					}
					else
					{
						if (this.activeUnit_0.vmethod_85().method_47())
						{
							geoPoint = Enumerable.Last<Waypoint>(this.activeUnit_0.vmethod_85().method_4());
							goto IL_FC;
						}
						geoPoint = new GeoPoint(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null));
						goto IL_FC;
					}
				}
				else if (activeUnitStatus != ActiveUnit._ActiveUnitStatus.OnFerryMission)
				{
					if (activeUnitStatus != ActiveUnit._ActiveUnitStatus.RTB_MissionOver && activeUnitStatus - ActiveUnit._ActiveUnitStatus.RTB_Group > 1)
					{
						goto IL_FC;
					}
				}
				else
				{
					ActiveUnit activeUnit;
					if (this.activeUnit_0.bool_3)
					{
						activeUnit = ((Aircraft)this.activeUnit_0).method_164().method_21();
					}
					else
					{
						activeUnit = this.activeUnit_0.vmethod_93().method_2();
					}
					if (activeUnit != null)
					{
						geoPoint = new GeoPoint(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null));
						goto IL_FC;
					}
					goto IL_FC;
				}
				return null;
				IL_FC:
				if (this.activeUnit_0.vmethod_85().method_47())
				{
					geoPoint = Enumerable.Last<Waypoint>(this.activeUnit_0.vmethod_85().method_4());
				}
				checked
				{
					if (this.activeUnit_0.vmethod_101() != null)
					{
						switch (this.activeUnit_0.vmethod_101()._MissionClass_0)
						{
						case Mission._MissionClass.Strike:
							if (this.vmethod_3() != null)
							{
								if ((this.vmethod_3().contactType_0 != Contact_Base.ContactType.Air && this.vmethod_3().contactType_0 != Contact_Base.ContactType.Missile) || this.activeUnit_0.method_36(this.vmethod_3()) >= 150f)
								{
									geoPoint = new GeoPoint(this.vmethod_3().vmethod_28(null), this.vmethod_3().vmethod_30(null));
								}
							}
							else if (Enumerable.Count<Waypoint>(this.activeUnit_0.vmethod_85().method_4()) > 0)
							{
								Waypoint[] array = this.activeUnit_0.vmethod_85().method_4();
								int i = 0;
								while (i < array.Length)
								{
									Waypoint waypoint = array[i];
									if (waypoint.waypointType_0 != Waypoint.WaypointType.Target)
									{
										if (waypoint.waypointType_0 != Waypoint.WaypointType.WeaponLaunch)
										{
											i++;
											continue;
										}
									}
									geoPoint = new GeoPoint(waypoint.imethod_0(), waypoint.imethod_2());
									break;
								}
							}
							break;
						case Mission._MissionClass.Patrol:
							geoPoint = Misc.smethod_48(((Class343)this.activeUnit_0.vmethod_101()).list_5).method_1();
							break;
						case Mission._MissionClass.Support:
							geoPoint = this.activeUnit_0.vmethod_85().referencePoint_0;
							break;
						}
					}
					result = geoPoint;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100025", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000805D8 File Offset: 0x0007E7D8
		public ActiveUnit_AI(ActiveUnit activeUnit_1)
		{
			this.hashSet_0 = new HashSet<string>();
			this.vmethod_1(new ObservableDictionary<string, ActiveUnit_AI.TargetingEntry>());
			this.contact_2 = new Contact[0];
			this.geopoint_Struct_0 = default(Geopoint_Struct);
			this.bool_3 = false;
			this.list_0 = new List<Contact>();
			this.bool_8 = false;
			this.bool_9 = true;
			this.bool_10 = true;
			this.double_2 = 0.0;
			this.double_3 = 0.0;
			this.list_1 = new List<ValueTuple<ValueTuple<double, double, float, short>>>();
			this.activeUnit_0 = activeUnit_1;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0008066C File Offset: 0x0007E86C
		public float method_19(Contact contact_8)
		{
			float result;
			try
			{
				if (Information.IsNothing(contact_8))
				{
					result = 30f;
				}
				else if (Information.IsNothing(this.activeUnit_0))
				{
					result = 30f;
				}
				else if (contact_8.contactType_0 == Contact_Base.ContactType.ActivationPoint)
				{
					result = 0f;
				}
				else
				{
					float num = 0f;
					if (!Information.IsNothing(contact_8.activeUnit_0))
					{
						if (contact_8.activeUnit_0.method_92(this.activeUnit_0.vmethod_7(false)))
						{
							num = contact_8.float_9;
						}
						if (num == 0f && contact_8.activeUnit_0.method_5())
						{
							num = contact_8.float_9;
						}
						if (num == 0f && this.activeUnit_0.bool_3 && !contact_8.method_103())
						{
							num = contact_8.float_9;
						}
					}
					if (num == 0f)
					{
						float? num2 = this.activeUnit_0.vmethod_88().method_65(ref contact_8);
						if (!Information.IsNothing(num2))
						{
							num = num2.Value;
						}
						else
						{
							num = contact_8.float_9;
						}
					}
					result = Math.Max((float)this.activeUnit_0.method_62() - num, 0f);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100026", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 30f;
			}
			return result;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x000807DC File Offset: 0x0007E9DC
		public ActiveUnit_AI.TargetingEntry._TargetingBehavior method_20(Contact contact_8)
		{
			ActiveUnit_AI.TargetingEntry._TargetingBehavior result;
			try
			{
				ActiveUnit_AI.TargetingEntry targetingEntry = null;
				if (this.vmethod_0().TryGetValue(contact_8.string_0, ref targetingEntry))
				{
					result = targetingEntry.method_1();
				}
				else
				{
					result = ActiveUnit_AI.TargetingEntry._TargetingBehavior.NotTargeted;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100027", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = ActiveUnit_AI.TargetingEntry._TargetingBehavior.NotTargeted;
			}
			return result;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00080858 File Offset: 0x0007EA58
		public bool method_21(Contact contact_8)
		{
			return !Information.IsNothing(this.activeUnit_0) && !Information.IsNothing(contact_8) && (contact_8.bool_18 && Math.Abs(Class437.smethod_3(contact_8.vmethod_9(), contact_8.method_32(this.activeUnit_0))) < 5f);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x000808B0 File Offset: 0x0007EAB0
		public void method_22()
		{
			try
			{
				ActiveUnit[] array = Enumerable.ToArray<ActiveUnit>(this.activeUnit_0.vmethod_7(false).activeUnit_0);
				List<ActiveUnit> list = new List<ActiveUnit>();
				foreach (ActiveUnit activeUnit in array)
				{
					if (activeUnit.vmethod_127() && !activeUnit.bool_1 && !Information.IsNothing(activeUnit.vmethod_101()) && activeUnit.vmethod_101() == this.activeUnit_0.vmethod_101() && !activeUnit.vmethod_86().bool_2)
					{
						list.Add(activeUnit);
					}
				}
				if (list.Count != 0)
				{
					ActiveUnit activeUnit2 = Enumerable.ToList<ActiveUnit>(Enumerable.OrderBy<ActiveUnit, float>(list, new Func<ActiveUnit, float>(this.method_90)))[0];
					float num = Enumerable.Max(Enumerable.Select<Weapon, float>(this.activeUnit_0.vmethod_89().vmethod_4(), (ActiveUnit_AI._Closure$__.$I102-1 == null) ? (ActiveUnit_AI._Closure$__.$I102-1 = new Func<Weapon, float>(ActiveUnit_AI._Closure$__.$I.method_0)) : ActiveUnit_AI._Closure$__.$I102-1));
					float num2 = Math.Min(5f, num / 3f);
					if (this.activeUnit_0.method_36(activeUnit2) > num2)
					{
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, this.activeUnit_0.method_32(activeUnit2));
						this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Full, null);
					}
					else
					{
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, activeUnit2.vmethod_9());
						this.activeUnit_0.vmethod_71(activeUnit2.vmethod_40());
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101347", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00080A74 File Offset: 0x0007EC74
		public void method_23(float float_3, ref Aircraft_AirOps aircraft_AirOps_0)
		{
			try
			{
				if (Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()))
				{
					this.bool_3 = false;
				}
				else
				{
					ActiveUnit activeUnit = this.activeUnit_0.vmethod_65(false).method_147();
					bool flag;
					if (!this.activeUnit_0.method_122() && ((this.activeUnit_0.vmethod_85().method_47() && (this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.Assemble || this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.HoldStart || this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.HoldEnd)) || (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false)) && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_47() && (this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.Assemble || this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.HoldStart || this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.HoldEnd))))
					{
						flag = true;
					}
					else
					{
						if (!this.activeUnit_0.vmethod_85().method_47() && this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false)) && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_47() && this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_4()[0].method_21())
						{
							((Aircraft)this.activeUnit_0).method_159().vmethod_27(float_3, false, false);
							return;
						}
						flag = false;
					}
					if ((this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || aircraft_AirOps_0.method_36() == Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel) && ((!Information.IsNothing(aircraft_AirOps_0.method_24()) && this.activeUnit_0.method_36(aircraft_AirOps_0.method_24()) < aircraft_AirOps_0.float_4) || (Information.IsNothing(aircraft_AirOps_0.method_24()) && activeUnit.vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling && this.activeUnit_0.method_36(((Aircraft)activeUnit).method_164().method_24()) < aircraft_AirOps_0.float_4)))
					{
						if (Information.IsNothing(aircraft_AirOps_0.method_24()) && !Information.IsNothing(((Aircraft)activeUnit).method_164().method_24()) && this.activeUnit_0 != ((Aircraft)this.activeUnit_0.vmethod_65(false).method_147()).method_164().method_24())
						{
							aircraft_AirOps_0.method_25(((Aircraft)this.activeUnit_0.vmethod_65(false).method_147()).method_164().method_24());
						}
						aircraft_AirOps_0.method_82(true);
						this.bool_3 = false;
					}
					else if ((this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || aircraft_AirOps_0.method_36() == Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel) && Information.IsNothing(aircraft_AirOps_0.method_24()) && this.activeUnit_0.bool_3 && ((Aircraft)this.activeUnit_0).method_146())
					{
						((Aircraft)this.activeUnit_0).method_158().method_139();
						this.bool_3 = false;
					}
					else if (this.activeUnit_0.method_36(activeUnit) >= 1f && (!flag || this.activeUnit_0.method_36(activeUnit) >= 4f))
					{
						this.bool_3 = false;
						if (!this.activeUnit_0.vmethod_87().vmethod_12())
						{
							this.activeUnit_0.vmethod_73(activeUnit.vmethod_72());
							this.activeUnit_0.vmethod_75(activeUnit.vmethod_74());
							this.activeUnit_0.vmethod_77(this.activeUnit_0, activeUnit.vmethod_76(this.activeUnit_0));
						}
						if (this.activeUnit_0.vmethod_85().method_44())
						{
							if (this.activeUnit_0.method_36(activeUnit) > 50f)
							{
								this.activeUnit_0.vmethod_85().vmethod_16(float_3);
							}
							else
							{
								this.activeUnit_0.vmethod_85().method_18();
							}
						}
						else if (this.activeUnit_0.vmethod_40() > 0f && !flag)
						{
							float num = activeUnit.method_33(this.activeUnit_0);
							if (num >= 90f && num <= 270f)
							{
								float num2 = this.activeUnit_0.method_53(this.activeUnit_0.vmethod_40(), this.activeUnit_0.method_25(activeUnit.vmethod_30(null), activeUnit.vmethod_28(null)));
								float num3 = this.activeUnit_0.vmethod_40() * num2 / 3600f;
								double num4;
								double num5;
								Class411.smethod_1(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null), ref num4, ref num5, (double)num3, (double)activeUnit.vmethod_9());
								this.activeUnit_0.vmethod_69(activeUnit.vmethod_78(), Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), num5, num4));
							}
							else
							{
								this.activeUnit_0.vmethod_69(activeUnit.vmethod_78(), Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), activeUnit.vmethod_30(null), activeUnit.vmethod_28(null)));
							}
							if (this.activeUnit_0.vmethod_85().bool_1 && !this.activeUnit_0.vmethod_85().method_44() && !this.activeUnit_0.vmethod_85().bool_2 && this.activeUnit_0.method_36(activeUnit) > 50f)
							{
								double double_ = this.activeUnit_0.vmethod_30(null);
								double double_2 = this.activeUnit_0.vmethod_28(null);
								double num6 = activeUnit.vmethod_30(null);
								double num7 = activeUnit.vmethod_28(null);
								if (this.activeUnit_0.vmethod_85().vmethod_29(double_, double_2, num6, num7, true, 0f, true, null, true, false, false, new float?(Class522.interface9_1.imethod_1())))
								{
									this.activeUnit_0.vmethod_85().method_16(null, this.activeUnit_0, null, false, 0.15f, num6, num7, this.activeUnit_0.scenario_0, false);
								}
							}
						}
						else
						{
							this.activeUnit_0.vmethod_69(activeUnit.vmethod_78(), Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), activeUnit.vmethod_30(null), activeUnit.vmethod_28(null)));
						}
						this.activeUnit_0.vmethod_87().vmethod_11(null);
						if (activeUnit.vmethod_108() != ActiveUnit._ActiveUnitStatus.EngagedDefensive)
						{
							if (this.activeUnit_0.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IsBingo)
							{
								if (this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_32())
								{
									this.activeUnit_0.vmethod_134(activeUnit.vmethod_84(), null);
								}
								else if (activeUnit.vmethod_84() <= ActiveUnit.Throttle.Cruise)
								{
									this.activeUnit_0.vmethod_134(activeUnit.vmethod_84(), null);
								}
								else
								{
									this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
								}
							}
							else if (this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_32())
							{
								if (activeUnit.vmethod_84() <= ActiveUnit.Throttle.Cruise)
								{
									this.activeUnit_0.vmethod_134(activeUnit.vmethod_84() + 1, null);
								}
								else
								{
									this.activeUnit_0.vmethod_134(activeUnit.vmethod_84(), null);
								}
							}
							else
							{
								this.activeUnit_0.vmethod_134(activeUnit.vmethod_84() + 1, null);
							}
						}
					}
					else
					{
						this.method_24();
						this.bool_3 = true;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200334", ex.Message);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				GameGeneral.smethod_25(ref ex);
			}
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00081380 File Offset: 0x0007F580
		public void method_24()
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()))
				{
					if (!this.activeUnit_0.vmethod_87().vmethod_12() && !this.activeUnit_0.vmethod_65(false).method_147().bool_6)
					{
						if (this.activeUnit_0.vmethod_72() != this.activeUnit_0.vmethod_65(false).method_147().vmethod_72())
						{
							this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_65(false).method_147().vmethod_72());
						}
						if (this.activeUnit_0.vmethod_74() != this.activeUnit_0.vmethod_65(false).method_147().vmethod_74())
						{
							this.activeUnit_0.vmethod_75(this.activeUnit_0.vmethod_65(false).method_147().vmethod_74());
						}
						if (this.activeUnit_0.vmethod_76(this.activeUnit_0) != this.activeUnit_0.vmethod_65(false).method_147().vmethod_76(this.activeUnit_0.vmethod_65(false).method_147()))
						{
							this.activeUnit_0.vmethod_77(this.activeUnit_0, this.activeUnit_0.vmethod_65(false).method_147().vmethod_76(this.activeUnit_0.vmethod_65(false).method_147()));
						}
					}
					this.activeUnit_0.vmethod_69(this.activeUnit_0.vmethod_65(false).method_147().vmethod_78(), this.activeUnit_0.vmethod_65(false).method_147().vmethod_68());
					if (this.activeUnit_0.vmethod_65(false).method_147().vmethod_78() == ActiveUnit.Enum28.const_1)
					{
						this.activeUnit_0.vmethod_71(this.activeUnit_0.vmethod_65(false).method_147().vmethod_40());
					}
					else
					{
						this.activeUnit_0.vmethod_71(this.activeUnit_0.vmethod_65(false).method_147().vmethod_70());
					}
					if (this.activeUnit_0.vmethod_84() != this.activeUnit_0.vmethod_65(false).method_147().vmethod_84())
					{
						this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_65(false).method_147().vmethod_84(), null);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100029", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0008160C File Offset: 0x0007F80C
		public void method_25()
		{
			try
			{
				if (this.activeUnit_0.bool_1)
				{
					try
					{
						foreach (ActiveUnit activeUnit in ((Group)this.activeUnit_0).vmethod_141().Values)
						{
							if (!activeUnit.method_122())
							{
								activeUnit.vmethod_86().method_24();
							}
						}
						goto IL_D3;
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
				if (this.activeUnit_0.method_121())
				{
					this.activeUnit_0.vmethod_86().method_24();
				}
				else if (this.activeUnit_0.method_122())
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
						{
							if (!activeUnit2.method_122())
							{
								activeUnit2.vmethod_86().method_24();
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
				IL_D3:;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101348", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00081750 File Offset: 0x0007F950
		public bool method_26(double double_4, double double_5, float float_3, float? nullable_10)
		{
			bool result;
			try
			{
				Aircraft aircraft = (Aircraft)this.activeUnit_0;
				Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
				bool flag = false;
				ActiveUnit activeUnit = null;
				bool flag2 = false;
				List<Mission> list = null;
				string text = "";
				List<Aircraft> list2 = aircraft_AirOps.method_78(ref flag, ref activeUnit, flag2, list, ref text);
				float num = aircraft.method_159().vmethod_24(false, null, nullable_10);
				if (list2.Count > 1)
				{
					List<Aircraft> list3 = new List<Aircraft>();
					try
					{
						List<Aircraft>.Enumerator enumerator = list2.GetEnumerator();
						while (enumerator.MoveNext())
						{
							ActiveUnit_AI.Class172 @class = new ActiveUnit_AI.Class172(@class);
							@class.aircraft_0 = enumerator.Current;
							bool flag3 = false;
							try
							{
								foreach (Aircraft aircraft2 in Enumerable.ToList<Aircraft>(Enumerable.Where<Aircraft>(list2, (@class.func_0 == null) ? (@class.func_0 = new Func<Aircraft, bool>(@class.method_0)) : @class.func_0)))
								{
									if (@class.aircraft_0.method_36(aircraft2) < num)
									{
										flag3 = true;
										break;
									}
								}
							}
							finally
							{
								List<Aircraft>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							if (!flag3)
							{
								list3.Add(@class.aircraft_0);
							}
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					try
					{
						foreach (Aircraft item in list3)
						{
							list2.Remove(item);
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				bool flag4;
				try
				{
					List<Aircraft>.Enumerator enumerator4 = list2.GetEnumerator();
					while (enumerator4.MoveNext())
					{
						if (enumerator4.Current.method_36(this.activeUnit_0) < num)
						{
							flag4 = true;
							break;
						}
					}
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator4;
					((IDisposable)enumerator4).Dispose();
				}
				if (!flag4)
				{
					result = false;
				}
				else
				{
					bool flag5;
					try
					{
						List<Aircraft>.Enumerator enumerator5 = list2.GetEnumerator();
						while (enumerator5.MoveNext())
						{
							if (enumerator5.Current.method_25(double_4, double_5) < float_3)
							{
								flag5 = true;
								break;
							}
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
					if (flag5)
					{
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101349", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00081A14 File Offset: 0x0007FC14
		public bool method_27(Contact contact_8, int int_1, int int_2, Doctrine.Enum56? nullable_10, bool bool_11, ref string string_1)
		{
			bool result;
			try
			{
				if (Information.IsNothing(contact_8))
				{
					string_1 = "The target does not exist!";
					result = false;
				}
				else
				{
					float num = this.activeUnit_0.method_36(contact_8);
					if (int_2 != 0 && num > (float)int_2)
					{
						string_1 = string.Concat(new string[]
						{
							"The mission is configured to not launch for targets beyond ",
							Conversions.ToString(int_2),
							" nm while the distance to the target is ",
							Conversions.ToString((int)Math.Round((double)num)),
							" nm."
						});
						result = false;
					}
					else if (int_1 != 0 && num < (float)int_1)
					{
						string_1 = string.Concat(new string[]
						{
							"The mission is configured to not launch for targets closer than ",
							Conversions.ToString(int_1),
							" nm while the distance to the target is ",
							Conversions.ToString((int)Math.Round((double)num)),
							" nm."
						});
						result = false;
					}
					else
					{
						Aircraft aircraft = (Aircraft)this.activeUnit_0;
						float num2 = aircraft.method_159().vmethod_26();
						Weapon weapon = aircraft.method_161().method_54();
						if (!Information.IsNothing(weapon))
						{
							num2 += weapon.float_29;
						}
						if (num < num2)
						{
							result = true;
						}
						else if (!aircraft.bool_28 && !aircraft.bool_27)
						{
							string_1 = "The target is out of range.";
							result = false;
						}
						else
						{
							byte? b = (nullable_10 != null) ? new byte?((byte)nullable_10.GetValueOrDefault()) : null;
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								string_1 = "The mission is configured to NOT use air-to-air refuelling and the target is out of range.";
								result = false;
							}
							else
							{
								float value;
								if (!bool_11)
								{
									Class211 @class = aircraft.method_157();
									bool flag = false;
									value = @class.method_73(ref flag);
								}
								if (!bool_11 && !this.method_26(contact_8.vmethod_30(null), contact_8.vmethod_28(null), (float)aircraft.method_167().int_4, new float?(value)))
								{
									string_1 = string.Concat(new string[]
									{
										"The mission is configured to use air-to-air refuelling. However there is no tanker available within reasonable reach. The tanker must be located between the interceptor's take-off location and the target, within tactical radius of the target (",
										Conversions.ToString(aircraft.method_167().int_4),
										"nm), or within range of the interceptor's take-off location (",
										Conversions.ToString(aircraft.method_159().vmethod_24(false, null, new float?(value))),
										"nm)."
									});
									result = false;
								}
								else
								{
									result = true;
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101249", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00081CBC File Offset: 0x0007FEBC
		public float method_28(ref Strike.StrikeType strikeType_0)
		{
			float result;
			try
			{
				Aircraft aircraft = (Aircraft)this.activeUnit_0;
				switch (strikeType_0)
				{
				case Strike.StrikeType.Land_Strike:
				{
					Weapon weapon = aircraft.method_161().method_56(false);
					if (!Information.IsNothing(weapon))
					{
						return weapon.float_33;
					}
					break;
				}
				case Strike.StrikeType.Maritime_Strike:
				{
					Weapon weapon = aircraft.method_161().method_55(false);
					if (!Information.IsNothing(weapon))
					{
						return weapon.float_31;
					}
					break;
				}
				case Strike.StrikeType.Sub_Strike:
				{
					Weapon weapon = aircraft.method_161().method_57();
					if (!Information.IsNothing(weapon))
					{
						return weapon.float_35;
					}
					break;
				}
				}
				result = 0f;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101350", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00081DA4 File Offset: 0x0007FFA4
		public bool method_29(ref Mission.Flight flight_0, ref float float_3, Contact contact_8, ref string string_1)
		{
			bool result;
			if (!Information.IsNothing(flight_0) && !Information.IsNothing(flight_0.method_15()))
			{
				Waypoint[] array = new Waypoint[0];
				foreach (Waypoint waypoint in flight_0.method_15())
				{
					if (waypoint.waypointType_0 != Waypoint.WaypointType.InitialPoint && waypoint.waypointType_0 != Waypoint.WaypointType.WeaponLaunch)
					{
						ActiveUnit activeUnit = this.activeUnit_0;
						bool bool_ = false;
						bool bool_2 = false;
						Doctrine doctrine = null;
						Waypoint waypoint2 = Waypoint.smethod_14(ref activeUnit.scenario_0, ref waypoint, bool_, bool_2, ref doctrine);
						if (waypoint2.waypointType_0 == Waypoint.WaypointType.Target || waypoint.waypointType_0 == Waypoint.WaypointType.WeaponTarget)
						{
							waypoint2.imethod_3(contact_8.vmethod_30(null));
							waypoint2.imethod_1(contact_8.vmethod_28(null));
						}
						Class429.smethod_36(ref array, waypoint2);
					}
				}
				Aircraft aircraft = (Aircraft)this.activeUnit_0;
				float num;
				if (Class514.smethod_28(aircraft.scenario_0, aircraft.vmethod_101(), aircraft, aircraft.method_157().method_7(), ref array, ref float_3, ref num, true, false, false, false, false, true, false, 0f, 0f, Misc.Enum143.const_0, null, true, false, null, null, true))
				{
					result = true;
				}
				else
				{
					string_1 = string.Concat(new string[]
					{
						"Not enough fuel to reach the target. Mission fuel (not counting reserves) is ",
						Conversions.ToString((int)Math.Round((double)num)),
						" kg while fuel requirement for flightplan would be ",
						Conversions.ToString((int)Math.Round((double)float_3)),
						" kg."
					});
					result = false;
				}
			}
			else
			{
				string_1 = "No flightplan found!";
				result = false;
			}
			return result;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00081F38 File Offset: 0x00080138
		public bool method_30(ref Scenario scenario_0, ref Side side_0, ref Mission mission_0, ref Mission.Flight flight_0, ref Contact contact_8, int int_1, int int_2, Doctrine.Enum56? nullable_10, bool bool_11, Mission.Enum92 enum92_0, bool bool_12, bool bool_13, bool bool_14, bool bool_15, ref float float_3, ref string string_1, bool bool_16, ref bool bool_17, bool bool_18, ref float float_4, ref float float_5, bool bool_19, Contact contact_9, bool bool_20, DateTime? nullable_11, DateTime? nullable_12, bool bool_21, bool bool_22)
		{
			bool result;
			if (Information.IsNothing(this.activeUnit_0))
			{
				result = false;
			}
			else
			{
				Aircraft aircraft = (Aircraft)this.activeUnit_0;
				try
				{
					if (Information.IsNothing(contact_8))
					{
						string_1 = "The target does not exist!";
						result = false;
					}
					else
					{
						float num;
						if (!Information.IsNothing(aircraft.method_164().method_21()))
						{
							num = aircraft.method_164().method_21().method_36(contact_8);
						}
						else
						{
							num = aircraft.method_36(contact_8);
						}
						if (int_2 != 0 && num > (float)int_2)
						{
							if (Enumerable.Count<Waypoint>(flight_0.method_18()) > 0)
							{
								Mission.Flight flight = flight_0;
								Waypoint[] waypoint_ = flight.method_18();
								Class429.smethod_38(ref waypoint_);
								flight.method_19(waypoint_);
							}
							string_1 = string.Concat(new string[]
							{
								"The mission is configured to not strike targets beyond ",
								Conversions.ToString(int_2),
								" nm while the distance from base to the target is ",
								Conversions.ToString((int)Math.Round((double)num)),
								" nm. No flightplan has been generated and the mission will not launch."
							});
							result = false;
						}
						else if (int_1 != 0 && num < (float)int_1)
						{
							if (Enumerable.Count<Waypoint>(flight_0.method_18()) > 0)
							{
								Mission.Flight flight2 = flight_0;
								Waypoint[] waypoint_ = flight2.method_18();
								Class429.smethod_38(ref waypoint_);
								flight2.method_19(waypoint_);
							}
							string_1 = string.Concat(new string[]
							{
								"The mission is configured to not strike targets closer than ",
								Conversions.ToString(int_1),
								" nm while the distance from base to the target is ",
								Conversions.ToString((int)Math.Round((double)num)),
								" nm. No flightplan has been generated and the mission will not launch."
							});
							result = false;
						}
						else
						{
							Weapon weapon = aircraft.method_161().method_16(contact_8, false, false, true, aircraft.doctrine_0);
							if (Information.IsNothing(weapon))
							{
								string_1 = "Could not determine the most suitable weapon. Are the aircraft loaded with correct weapons for the mission type? No flightplan has been created.";
								result = false;
							}
							else
							{
								float num2 = weapon.method_181(aircraft, contact_8, true, aircraft.doctrine_0, false);
								bool flag = false;
								if (aircraft.method_167().int_4 > 0 && aircraft.method_167().short_0 == 0)
								{
									flag = true;
								}
								float num3;
								if (flag)
								{
									num3 = (float)aircraft.method_167().int_4;
								}
								else
								{
									num3 = aircraft.method_159().vmethod_26();
								}
								if (num <= num3 + num2)
								{
									if (bool_19)
									{
										result = Class514.smethod_3(ref scenario_0, ref side_0, ref mission_0, ref flight_0, ref aircraft, null, contact_8, enum92_0, ref bool_12, bool_13, bool_14, bool_15, ref float_3, ref string_1, bool_16, ref bool_17, bool_18, ref float_4, ref float_5, false, num, ref weapon, num2, bool_20, nullable_11, nullable_12, bool_22);
									}
									else if (!Information.IsNothing(contact_9))
									{
										result = this.method_29(ref flight_0, ref float_3, contact_9, ref string_1);
									}
									else
									{
										result = true;
									}
								}
								else if (!aircraft.bool_28 && !aircraft.bool_27)
								{
									string_1 = string.Concat(new string[]
									{
										"The target is out of range. Distance to target is ",
										Conversions.ToString((int)Math.Round((double)num)),
										" nm while combat radius is ",
										Conversions.ToString(num3),
										" nm and max weapon range is ",
										Conversions.ToString(num2),
										" nm."
									});
									result = false;
								}
								else
								{
									byte? b = (nullable_10 != null) ? new byte?((byte)nullable_10.GetValueOrDefault()) : null;
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
									{
										if (Enumerable.Count<Waypoint>(flight_0.method_18()) > 0)
										{
											Mission.Flight flight3 = flight_0;
											Waypoint[] waypoint_ = flight3.method_18();
											Class429.smethod_38(ref waypoint_);
											flight3.method_19(waypoint_);
										}
										string_1 = "The mission is configured to NOT use air-to-air refuelling and the target is out of range. No flightplan has been generated and the mission will not launch.";
										result = false;
									}
									else
									{
										Doctrine.Enum56? @enum = this.activeUnit_0.doctrine_0.method_152(this.activeUnit_0.scenario_0, false, false, false, false);
										b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
										if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											if (Enumerable.Count<Waypoint>(flight_0.method_18()) > 0)
											{
												Mission.Flight flight4 = flight_0;
												Waypoint[] waypoint_ = flight4.method_18();
												Class429.smethod_38(ref waypoint_);
												flight4.method_19(waypoint_);
											}
											string str = "";
											if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
											{
												str = " (" + this.activeUnit_0.string_2 + ")";
											}
											string_1 = this.activeUnit_0.Name + str + " has a doctrine setting that forbids air-to-air refuelling and the target is out of range. No flightplan has been generated and the mission will not launch.";
											result = false;
										}
										else
										{
											float value;
											if (!bool_11)
											{
												Class211 @class = aircraft.method_157();
												bool flag2 = false;
												value = @class.method_73(ref flag2);
											}
											if (!bool_11 && !this.method_26(contact_8.vmethod_30(null), contact_8.vmethod_28(null), num3, new float?(value)))
											{
												if (Enumerable.Count<Waypoint>(flight_0.method_18()) > 0)
												{
													Mission.Flight flight5 = flight_0;
													Waypoint[] waypoint_ = flight5.method_18();
													Class429.smethod_38(ref waypoint_);
													flight5.method_19(waypoint_);
												}
												string_1 = string.Concat(new string[]
												{
													"The mission is configured to use air-to-air refuelling. However there is no tanker available within reasonable reach. The tanker must be located between the strike aircraft's take-off location and the target, within tactical radius of the target (",
													Conversions.ToString(num3),
													" nm), and within range of the strike aircraft's current location (",
													Conversions.ToString((int)Math.Round((double)aircraft.method_159().vmethod_24(false, null, new float?(value)))),
													" nm). No flightplan has been generated and the mission will not launch."
												});
												result = false;
											}
											else if (bool_19)
											{
												result = Class514.smethod_3(ref scenario_0, ref side_0, ref mission_0, ref flight_0, ref aircraft, new bool?(true), contact_8, enum92_0, ref bool_12, bool_13, bool_14, bool_15, ref float_3, ref string_1, bool_16, ref bool_17, bool_18, ref float_4, ref float_5, true, num, ref weapon, num2, bool_20, nullable_11, nullable_12, bool_22);
											}
											else
											{
												result = true;
											}
										}
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100399", "");
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

		// Token: 0x060007F6 RID: 2038 RVA: 0x00082510 File Offset: 0x00080710
		public bool method_31(ref Strike strike_0, Misc.PostureStance postureStance_0)
		{
			bool result;
			if (Information.IsNothing(postureStance_0))
			{
				result = false;
			}
			else
			{
				switch (strike_0.postureStance_0)
				{
				case Misc.PostureStance.Unfriendly:
					result = (postureStance_0 == Misc.PostureStance.Hostile || postureStance_0 == Misc.PostureStance.Unfriendly);
					break;
				case Misc.PostureStance.Hostile:
					result = (postureStance_0 == Misc.PostureStance.Hostile);
					break;
				case Misc.PostureStance.Unknown:
					result = true;
					break;
				default:
					result = false;
					break;
				}
			}
			return result;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00082570 File Offset: 0x00080770
		public void method_32(ref Contact contact_8, ref Side side_0)
		{
			try
			{
				if (this.activeUnit_0 == null || side_0 == this.activeUnit_0.vmethod_7(false))
				{
					if (this.vmethod_0() != null && this.vmethod_0().ContainsKey(contact_8.string_0))
					{
						this.vmethod_15(contact_8, true);
					}
					if (this.contact_2 != null && Class429.smethod_16(ref this.contact_2, contact_8))
					{
						this.vmethod_14(contact_8);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100031", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00082624 File Offset: 0x00080824
		public void method_33(ref ActiveUnit activeUnit_1)
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (!activeUnit_1.bool_2)
					{
						Side side = this.activeUnit_0.vmethod_7(false);
						ActiveUnit activeUnit = this.activeUnit_0;
						Contact contact = null;
						Class316 @class = null;
						side.method_83(ref activeUnit.scenario_0, ref this.activeUnit_0, ref contact, ref @class);
					}
					this.vmethod_0().Clear();
					this.vmethod_4(null);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200327", ex.Message);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				GameGeneral.smethod_25(ref ex);
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000074C6 File Offset: 0x000056C6
		public void method_34()
		{
			Class429.smethod_15(ref this.contact_2);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x000826D0 File Offset: 0x000808D0
		public bool method_35(Contact contact_8, ActiveUnit activeUnit_1, int int_1)
		{
			bool result;
			try
			{
				if (contact_8.contactType_0 != Contact_Base.ContactType.Aimpoint)
				{
					if (contact_8.contactType_0 != Contact_Base.ContactType.ActivationPoint)
					{
						Misc.PostureStance postureStance;
						if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(contact_8.string_0, out postureStance))
						{
							postureStance = contact_8.method_130(this.activeUnit_0.vmethod_7(false));
						}
						if (postureStance == Misc.PostureStance.Friendly || postureStance == Misc.PostureStance.Neutral)
						{
							return false;
						}
						float num = activeUnit_1.method_36(contact_8);
						float num2;
						switch (activeUnit_1.vmethod_56())
						{
						case GlobalVariables.ActiveUnitType.Aircraft:
						case GlobalVariables.ActiveUnitType.Weapon:
							num2 = (float)Math.Min(1.5 * (double)contact_8.method_81().GetValueOrDefault(), (double)int_1);
							break;
						case GlobalVariables.ActiveUnitType.Ship:
							num2 = (float)Math.Min(1.5 * (double)contact_8.method_82().GetValueOrDefault(), (double)int_1);
							break;
						case GlobalVariables.ActiveUnitType.Submarine:
							num2 = (float)Math.Min(1.5 * (double)contact_8.method_84().GetValueOrDefault(), (double)int_1);
							break;
						case GlobalVariables.ActiveUnitType.Facility:
							num2 = (float)Math.Min(1.5 * (double)contact_8.method_83().GetValueOrDefault(), (double)int_1);
							break;
						case GlobalVariables.ActiveUnitType.Aimpoint:
							return false;
						}
						if (num < num2)
						{
							return true;
						}
						if (contact_8.contactType_0 == Contact_Base.ContactType.Air)
						{
							if (int_1 > 0)
							{
								if (num < (float)int_1 && activeUnit_1.method_39(contact_8, this.activeUnit_0.vmethod_40(), this.activeUnit_0.vmethod_9()) > 0f)
								{
									return true;
								}
							}
							else if (num < 30f && activeUnit_1.method_39(contact_8, this.activeUnit_0.vmethod_40(), this.activeUnit_0.vmethod_9()) > 0f)
							{
								return true;
							}
						}
						try
						{
							if ((contact_8.method_135() || contact_8.method_108()) && num < (float)int_1 && contact_8.method_67())
							{
								try
								{
									foreach (KeyValuePair<int, EmissionContainer> keyValuePair in contact_8.method_68())
									{
										Sensor sensor = keyValuePair.Value.method_0(keyValuePair.Key, this.activeUnit_0.scenario_0);
										if (sensor.method_49() || sensor.method_51())
										{
											return true;
										}
									}
								}
								finally
								{
									IEnumerator<KeyValuePair<int, EmissionContainer>> enumerator;
									if (enumerator != null)
									{
										enumerator.Dispose();
									}
								}
							}
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 200275", ex.Message);
							bool isAttached = Debugger.IsAttached;
							GameGeneral.smethod_25(ref ex);
						}
						return false;
					}
				}
				result = false;
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100033", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000829D0 File Offset: 0x00080BD0
		public bool method_36(Contact contact_8)
		{
			bool result;
			try
			{
				if (Information.IsNothing(this.activeUnit_0.vmethod_101()))
				{
					result = false;
				}
				else if (Information.IsNothing(contact_8.activeUnit_0))
				{
					result = false;
				}
				else if (this.activeUnit_0.vmethod_101()._MissionClass_0 != Mission._MissionClass.Strike)
				{
					result = false;
				}
				else if (this.activeUnit_0.bool_3 && !((Aircraft)this.activeUnit_0).method_158().method_129(contact_8))
				{
					result = false;
				}
				else
				{
					Weapon weapon = this.activeUnit_0.vmethod_89().method_54();
					Weapon weapon2 = this.activeUnit_0.vmethod_89().method_56(false);
					Weapon weapon3 = this.activeUnit_0.vmethod_89().method_55(false);
					Weapon weapon4 = this.activeUnit_0.vmethod_89().method_57();
					int int_;
					if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
					{
						int_ = ((Strike)this.activeUnit_0.vmethod_101()).int_7;
					}
					ActiveUnit[] array = Enumerable.ToArray<ActiveUnit>(this.activeUnit_0.vmethod_7(false).activeUnit_0);
					if (this.activeUnit_0.vmethod_85().method_49())
					{
						switch (contact_8.contactType_0)
						{
						case Contact_Base.ContactType.Air:
							if (!Information.IsNothing(weapon) && this.activeUnit_0.method_37(contact_8, 0f) < Math.Min(Math.Max(5f, (float)contact_8.method_80() * weapon.float_29), (float)int_))
							{
								return true;
							}
							break;
						case Contact_Base.ContactType.Surface:
						case Contact_Base.ContactType.UndeterminedNaval:
						case Contact_Base.ContactType.Mine:
							if (!Information.IsNothing(weapon3) && this.activeUnit_0.method_36(contact_8) < Math.Min(Math.Max(5f, (float)contact_8.method_80() * weapon3.float_31), (float)int_))
							{
								return true;
							}
							break;
						case Contact_Base.ContactType.Submarine:
							if (!Information.IsNothing(weapon4) && this.activeUnit_0.method_36(contact_8) < Math.Min(Math.Max(5f, (float)contact_8.method_80() * weapon4.float_35), (float)int_))
							{
								return true;
							}
							break;
						case Contact_Base.ContactType.Aimpoint:
						case Contact_Base.ContactType.Facility_Fixed:
						case Contact_Base.ContactType.Facility_Mobile:
							if (!Information.IsNothing(weapon2) && this.activeUnit_0.method_36(contact_8) < Math.Min(Math.Max(5f, (float)contact_8.method_80() * weapon2.float_33), (float)int_))
							{
								return true;
							}
							break;
						}
					}
					foreach (ActiveUnit activeUnit in array)
					{
						if (activeUnit.vmethod_127() && !activeUnit.bool_1 && !Information.IsNothing(activeUnit.vmethod_101()) && activeUnit.vmethod_101() == this.activeUnit_0.vmethod_101() && !activeUnit.vmethod_86().bool_2)
						{
							switch (contact_8.contactType_0)
							{
							case Contact_Base.ContactType.Air:
								if (!Information.IsNothing(weapon))
								{
									if (this.activeUnit_0.vmethod_85().method_49())
									{
										if (activeUnit.method_37(contact_8, 0f) < (float)int_)
										{
											return true;
										}
									}
									else if (activeUnit.method_37(contact_8, 0f) < Math.Min(Math.Max(5f, (float)contact_8.method_80() * weapon.float_29), (float)int_))
									{
										return true;
									}
								}
								break;
							case Contact_Base.ContactType.Surface:
							case Contact_Base.ContactType.UndeterminedNaval:
							case Contact_Base.ContactType.Mine:
								if (!Information.IsNothing(weapon3))
								{
									if (this.activeUnit_0.vmethod_85().method_49())
									{
										if (activeUnit.method_36(contact_8) < (float)int_)
										{
											return true;
										}
									}
									else if (activeUnit.method_36(contact_8) < Math.Min(Math.Max(5f, (float)contact_8.method_80() * weapon3.float_31), (float)int_))
									{
										return true;
									}
								}
								break;
							case Contact_Base.ContactType.Submarine:
								if (!Information.IsNothing(weapon4))
								{
									if (this.activeUnit_0.vmethod_85().method_49())
									{
										if (activeUnit.method_36(contact_8) < (float)int_)
										{
											return true;
										}
									}
									else if (activeUnit.method_36(contact_8) < Math.Min(Math.Max(5f, (float)contact_8.method_80() * weapon4.float_35), (float)int_))
									{
										return true;
									}
								}
								break;
							case Contact_Base.ContactType.Aimpoint:
							case Contact_Base.ContactType.Facility_Fixed:
							case Contact_Base.ContactType.Facility_Mobile:
								if (!Information.IsNothing(weapon2))
								{
									if (this.activeUnit_0.vmethod_85().method_49())
									{
										if (activeUnit.method_36(contact_8) < (float)int_)
										{
											return true;
										}
									}
									else if (activeUnit.method_36(contact_8) < Math.Min(Math.Max(5f, (float)contact_8.method_80() * weapon2.float_33), (float)int_))
									{
										return true;
									}
								}
								break;
							}
							if (this.method_35(contact_8, activeUnit, int_))
							{
								return true;
							}
						}
					}
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101352", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00082F00 File Offset: 0x00081100
		public bool method_37()
		{
			bool result;
			if (Information.IsNothing(this.activeUnit_0.vmethod_101()))
			{
				result = false;
			}
			else if (this.activeUnit_0.vmethod_101()._MissionClass_0 != Mission._MissionClass.Patrol)
			{
				result = false;
			}
			else
			{
				Class343 @class = (Class343)this.activeUnit_0.vmethod_101();
				result = this.activeUnit_0.vmethod_85().method_40(ref @class.list_5, ref @class.list_13, ref @class.list_9, 10, false, false);
			}
			return result;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00082F7C File Offset: 0x0008117C
		public bool method_38()
		{
			bool result;
			if (Information.IsNothing(this.activeUnit_0.vmethod_101()))
			{
				result = false;
			}
			else if (this.activeUnit_0.vmethod_101()._MissionClass_0 != Mission._MissionClass.Patrol)
			{
				result = false;
			}
			else
			{
				Class343 @class = (Class343)this.activeUnit_0.vmethod_101();
				ActiveUnit_Navigator activeUnit_Navigator = this.activeUnit_0.vmethod_85();
				Class343 class2 = @class;
				List<ReferencePoint> list = null;
				result = activeUnit_Navigator.method_40(ref class2.list_5, ref list, ref @class.list_6, 0, false, false);
			}
			return result;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00082FF4 File Offset: 0x000811F4
		public bool method_39(Contact contact_8, Mission mission_0, Doctrine.Enum59? nullable_10, bool bool_11, bool bool_12, bool bool_13, Misc.PostureStance? nullable_11, ref string string_1, ref int int_1)
		{
			bool result;
			if (this.activeUnit_0 == null)
			{
				result = false;
			}
			else
			{
				try
				{
					if (mission_0 == null)
					{
						if (int_1 < 1)
						{
							string_1 = "Mission not found!";
							int_1 = 1;
						}
						result = false;
					}
					else if (contact_8.activeUnit_0 == null)
					{
						if (int_1 < 1)
						{
							string_1 = "Contact's unit does not exist!";
							int_1 = 1;
						}
						result = false;
					}
					else
					{
						Side side = this.activeUnit_0.vmethod_7(false);
						Misc.PostureStance postureStance;
						if (nullable_11 != null)
						{
							postureStance = nullable_11.Value;
						}
						else
						{
							string key = contact_8.string_0;
							if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(key, out postureStance))
							{
								postureStance = contact_8.method_130(this.activeUnit_0.vmethod_7(false));
							}
						}
						if (postureStance == Misc.PostureStance.Friendly)
						{
							if (int_1 < 2)
							{
								string_1 = "Contacts are friendly.";
								int_1 = 2;
							}
							result = false;
						}
						else if (bool_13 && postureStance == Misc.PostureStance.Neutral)
						{
							if (int_1 < 3)
							{
								string_1 = "Contacts are neutral.";
								int_1 = 3;
							}
							result = false;
						}
						else
						{
							if (this.activeUnit_0.vmethod_56() == GlobalVariables.ActiveUnitType.Aircraft)
							{
								try
								{
									foreach (NoNavZone noNavZone in side.list_7)
									{
										if (noNavZone.list_0.Count != 0 && noNavZone.method_8(this.activeUnit_0) && contact_8.vmethod_46(noNavZone.list_0, this.activeUnit_0.scenario_0, true))
										{
											if (int_1 < 4)
											{
												string_1 = "Contacts are inside No-Navigation Zones.";
												int_1 = 4;
											}
											return false;
										}
									}
								}
								finally
								{
									List<NoNavZone>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
							}
							Mission._MissionClass missionClass_ = mission_0._MissionClass_0;
							if (missionClass_ != Mission._MissionClass.Strike)
							{
								if (missionClass_ == Mission._MissionClass.Patrol)
								{
									byte? b = (nullable_10 != null) ? new byte?((byte)nullable_10.GetValueOrDefault()) : null;
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										switch (((Class343)mission_0).patrolType_0)
										{
										case GlobalVariables.PatrolType.ASW:
										{
											Contact_Base.ContactType contactType = contact_8.contactType_0;
											if (contactType - Contact_Base.ContactType.Submarine > 1)
											{
												if (int_1 < 5)
												{
													string_1 = "No relevant contact types found.";
													int_1 = 5;
												}
												return false;
											}
											ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
											bool checkWRA = true;
											Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
											string text = "";
											int num = 0;
											if (!activeUnit_Weaponry.method_6(contact_8, checkWRA, doctrine_, ref text, ref num, null) && contact_8.method_130(this.activeUnit_0.vmethod_7(false)) != Misc.PostureStance.Unknown)
											{
												return false;
											}
											break;
										}
										case GlobalVariables.PatrolType.ASuW_Naval:
										{
											Contact_Base.ContactType contactType2 = contact_8.contactType_0;
											if (contactType2 != Contact_Base.ContactType.Surface)
											{
												if (contactType2 != Contact_Base.ContactType.UndeterminedNaval)
												{
													if (int_1 < 5)
													{
														string_1 = "No relevant contact types found.";
														int_1 = 5;
													}
													return false;
												}
											}
											ActiveUnit_Weaponry activeUnit_Weaponry2 = this.activeUnit_0.vmethod_89();
											bool checkWRA2 = true;
											Doctrine doctrine_2 = this.activeUnit_0.doctrine_0;
											string text = "";
											int num = 0;
											if (!activeUnit_Weaponry2.method_6(contact_8, checkWRA2, doctrine_2, ref text, ref num, null) && contact_8.method_130(this.activeUnit_0.vmethod_7(false)) != Misc.PostureStance.Unknown)
											{
												return false;
											}
											break;
										}
										case GlobalVariables.PatrolType.AAW:
										{
											Contact_Base.ContactType contactType3 = contact_8.contactType_0;
											if (contactType3 != Contact_Base.ContactType.Air)
											{
												if (contactType3 != Contact_Base.ContactType.Missile)
												{
													if (contactType3 != Contact_Base.ContactType.Orbital)
													{
														if (int_1 < 5)
														{
															string_1 = "No relevant contact types found.";
															int_1 = 5;
														}
														return false;
													}
													if (this.activeUnit_0.bool_3 && ((Aircraft)this.activeUnit_0).method_167().loadoutRole_0 != Loadout.LoadoutRole.AntiSatellite_Intercept)
													{
														return false;
													}
												}
												else if (((Weapon)contact_8.activeUnit_0).method_199())
												{
													if (int_1 < 5)
													{
														string_1 = "No relevant contact types found.";
														int_1 = 5;
													}
													return false;
												}
											}
											break;
										}
										case GlobalVariables.PatrolType.ASuW_Land:
										{
											Contact_Base.ContactType contactType4 = contact_8.contactType_0;
											if (contactType4 != Contact_Base.ContactType.Aimpoint && contactType4 - Contact_Base.ContactType.Facility_Fixed > 1)
											{
												if (int_1 < 5)
												{
													string_1 = "No relevant contact types found.";
													int_1 = 5;
												}
												return false;
											}
											break;
										}
										case GlobalVariables.PatrolType.ASuW_Mixed:
											switch (contact_8.contactType_0)
											{
											case Contact_Base.ContactType.Surface:
											{
												ActiveUnit_Weaponry activeUnit_Weaponry3 = this.activeUnit_0.vmethod_89();
												bool checkWRA3 = true;
												Doctrine doctrine_3 = this.activeUnit_0.doctrine_0;
												string text = "";
												int num = 0;
												if (!activeUnit_Weaponry3.method_6(contact_8, checkWRA3, doctrine_3, ref text, ref num, null) && contact_8.method_130(this.activeUnit_0.vmethod_7(false)) != Misc.PostureStance.Unknown)
												{
													return false;
												}
												goto IL_90D;
											}
											case Contact_Base.ContactType.UndeterminedNaval:
											case Contact_Base.ContactType.Aimpoint:
											case Contact_Base.ContactType.Facility_Fixed:
											case Contact_Base.ContactType.Facility_Mobile:
												goto IL_90D;
											}
											if (int_1 < 5)
											{
												string_1 = "No relevant contact types found.";
												int_1 = 5;
											}
											return false;
										case GlobalVariables.PatrolType.SEAD:
										{
											float? num2 = contact_8.method_85();
											if (((num2 != null) ? new bool?(num2.GetValueOrDefault() < 10f) : null).GetValueOrDefault())
											{
												if (int_1 < 5)
												{
													string_1 = "No relevant contact types found (air-search radars with range greater than 10nm).";
													int_1 = 5;
												}
												return false;
											}
											switch (contact_8.method_125())
											{
											case Contact_Base.IdentificationStatus.Unknown:
											case Contact_Base.IdentificationStatus.KnownDomain:
											{
												bool flag = false;
												List<KeyValuePair<int, EmissionContainer>> list = new List<KeyValuePair<int, EmissionContainer>>(contact_8.method_68().Count);
												try
												{
													foreach (KeyValuePair<int, EmissionContainer> item in contact_8.method_68())
													{
														list.Add(item);
													}
												}
												finally
												{
													IEnumerator<KeyValuePair<int, EmissionContainer>> enumerator2;
													if (enumerator2 != null)
													{
														enumerator2.Dispose();
													}
												}
												try
												{
													foreach (KeyValuePair<int, EmissionContainer> keyValuePair in list)
													{
														if (keyValuePair.Value.float_0 <= 30f && keyValuePair.Value.method_0(keyValuePair.Key, this.activeUnit_0.scenario_0).method_51())
														{
															flag = true;
															break;
														}
													}
												}
												finally
												{
													List<KeyValuePair<int, EmissionContainer>>.Enumerator enumerator3;
													((IDisposable)enumerator3).Dispose();
												}
												if (!flag)
												{
													if (int_1 < 6)
													{
														string_1 = "No relevant contact types found.";
														int_1 = 6;
													}
													return false;
												}
												break;
											}
											case Contact_Base.IdentificationStatus.KnownType:
											{
												if (contact_8.activeUnit_0.bool_8)
												{
													Facility._MobileUnitCategory mobileUnitCategory = ((Facility)contact_8.activeUnit_0).method_143();
													if (mobileUnitCategory - Facility._MobileUnitCategory.const_5 > 1)
													{
														if (int_1 < 6)
														{
															string_1 = "No relevant contact types found.";
															int_1 = 6;
														}
														return false;
													}
												}
												bool flag2 = false;
												ActiveUnit_Weaponry activeUnit_Weaponry4 = this.activeUnit_0.vmethod_89();
												Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = null;
												IEnumerable<Weapon> enumerable = activeUnit_Weaponry4.method_13(contact_8, ref gunStrafeGroundTargets);
												try
												{
													IEnumerator<Weapon> enumerator4 = enumerable.GetEnumerator();
													while (enumerator4.MoveNext())
													{
														if (!enumerator4.Current.method_198())
														{
															flag2 = true;
															break;
														}
													}
												}
												finally
												{
													IEnumerator<Weapon> enumerator4;
													if (enumerator4 != null)
													{
														enumerator4.Dispose();
													}
												}
												if (!flag2 && contact_8.method_68().Count == 0)
												{
													if (int_1 < 6)
													{
														string_1 = "No relevant contact types found.";
														int_1 = 6;
													}
													return false;
												}
												break;
											}
											case Contact_Base.IdentificationStatus.KnownClass:
											case Contact_Base.IdentificationStatus.PreciseID:
											{
												num2 = contact_8.method_81();
												if (((num2 != null) ? new bool?(num2.GetValueOrDefault() < 1f) : null).GetValueOrDefault())
												{
													num2 = contact_8.method_85();
													if (((num2 != null) ? new bool?(num2.GetValueOrDefault() < 10f) : null).GetValueOrDefault())
													{
														if (int_1 < 6)
														{
															string_1 = "No relevant contact types found.";
															int_1 = 6;
														}
														return false;
													}
												}
												bool flag3 = false;
												ActiveUnit_Weaponry activeUnit_Weaponry5 = this.activeUnit_0.vmethod_89();
												Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = null;
												IEnumerable<Weapon> enumerable2 = activeUnit_Weaponry5.method_13(contact_8, ref gunStrafeGroundTargets);
												try
												{
													IEnumerator<Weapon> enumerator5 = enumerable2.GetEnumerator();
													while (enumerator5.MoveNext())
													{
														if (!enumerator5.Current.method_198())
														{
															flag3 = true;
															break;
														}
													}
												}
												finally
												{
													IEnumerator<Weapon> enumerator5;
													if (enumerator5 != null)
													{
														enumerator5.Dispose();
													}
												}
												if (!flag3 && contact_8.method_68().Count == 0)
												{
													if (int_1 < 6)
													{
														string_1 = "No relevant contact types found.";
														int_1 = 6;
													}
													return false;
												}
												break;
											}
											}
											break;
										}
										case GlobalVariables.PatrolType.SeaControl:
										{
											Contact_Base.ContactType contactType5 = contact_8.contactType_0;
											if (contactType5 - Contact_Base.ContactType.Surface > 2)
											{
												if (int_1 < 5)
												{
													string_1 = "No relevant contact types found.";
													int_1 = 5;
												}
												return false;
											}
											ActiveUnit_Weaponry activeUnit_Weaponry6 = this.activeUnit_0.vmethod_89();
											bool checkWRA4 = true;
											Doctrine doctrine_4 = this.activeUnit_0.doctrine_0;
											string text = "";
											int num = 0;
											if (!activeUnit_Weaponry6.method_6(contact_8, checkWRA4, doctrine_4, ref text, ref num, null) && contact_8.method_130(this.activeUnit_0.vmethod_7(false)) != Misc.PostureStance.Unknown)
											{
												return false;
											}
											break;
										}
										}
									}
									else
									{
										ActiveUnit_Weaponry activeUnit_Weaponry7 = this.activeUnit_0.vmethod_89();
										bool checkWRA5 = true;
										Doctrine doctrine_5 = this.activeUnit_0.doctrine_0;
										string text = "";
										int num = 0;
										if (!activeUnit_Weaponry7.method_6(contact_8, checkWRA5, doctrine_5, ref text, ref num, null))
										{
											if (!this.activeUnit_0.bool_3)
											{
												if (int_1 < 5)
												{
													string_1 = "No relevant contacts can be engaged by the available weapons.";
													int_1 = 5;
												}
												return false;
											}
											Aircraft aircraft = (Aircraft)this.activeUnit_0;
											if (Information.IsNothing(aircraft.method_167()))
											{
												if (int_1 < 6)
												{
													string_1 = "No relevant contact types found.";
													int_1 = 6;
												}
												return false;
											}
											if ((aircraft.method_167().loadoutRole_0 != Loadout.LoadoutRole.Maritime_Surveillance || contact_8.contactType_0 != Contact_Base.ContactType.Surface) && (aircraft.method_167().loadoutRole_0 != Loadout.LoadoutRole.ASW_Patrol || contact_8.contactType_0 != Contact_Base.ContactType.Surface) && (aircraft.method_167().loadoutRole_0 != Loadout.LoadoutRole.Area_Surveillance || !contact_8.method_135()))
											{
												if (int_1 < 6)
												{
													string_1 = "No relevant contact types found.";
													int_1 = 6;
												}
												return false;
											}
										}
									}
									IL_90D:
									Class343 @class = (Class343)mission_0;
									bool flag4 = false;
									if (@class.method_68(this.activeUnit_0.scenario_0) && postureStance == Misc.PostureStance.Unknown)
									{
										Weapon weapon_ = this.activeUnit_0.vmethod_89().method_54();
										Weapon weapon_2 = this.activeUnit_0.vmethod_89().method_57();
										Weapon weapon_3 = this.activeUnit_0.vmethod_89().method_55(true);
										Weapon weapon_4 = this.activeUnit_0.vmethod_89().method_56(true);
										ActiveUnit_Weaponry activeUnit_Weaponry8 = this.activeUnit_0.vmethod_89();
										bool checkWRA6 = true;
										Doctrine doctrine_6 = this.activeUnit_0.doctrine_0;
										string text = "";
										int num = 0;
										if (activeUnit_Weaponry8.method_6(contact_8, checkWRA6, doctrine_6, ref text, ref num, null) && this.method_47(contact_8, postureStance, true, Doctrine.Enum59.const_0, weapon_, weapon_3, weapon_4, weapon_2))
										{
											flag4 = true;
										}
									}
									if (!((Class343)mission_0).method_66(this.activeUnit_0.scenario_0) && !flag4)
									{
										if (!contact_8.vmethod_46(@class.list_5, this.activeUnit_0.scenario_0, true))
										{
											if (int_1 < 7)
											{
												string_1 = "No relevant contact types found inside the station area.";
												int_1 = 7;
											}
											return false;
										}
									}
									else if (@class.method_65() && !flag4 && !contact_8.vmethod_46(@class.list_5, this.activeUnit_0.scenario_0, true) && !contact_8.vmethod_46(@class.list_15, this.activeUnit_0.scenario_0, true))
									{
										if (int_1 < 7)
										{
											string_1 = "No relevant contact types found inside the prosecution area.";
											int_1 = 7;
										}
										return false;
									}
									return true;
								}
							}
							else if (this.bool_2)
							{
								if (this.activeUnit_0.bool_3)
								{
									bool flag5 = ((Aircraft)this.activeUnit_0).method_158().method_129(contact_8);
									byte? b = (nullable_10 != null) ? new byte?((byte)nullable_10.GetValueOrDefault()) : null;
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && flag5)
									{
										return true;
									}
									if (!flag5)
									{
										if (int_1 < 5)
										{
											string_1 = "No contact is relevant for the escort's loadout.";
											int_1 = 5;
										}
										return false;
									}
								}
								int i = side.activeUnit_0.Length - 1;
								while (i >= 0)
								{
									ActiveUnit activeUnit;
									try
									{
										activeUnit = side.activeUnit_0[i];
									}
									catch (Exception ex)
									{
										goto IL_B9A;
									}
									goto IL_B4D;
									IL_B9A:
									i += -1;
									continue;
									IL_B4D:
									if (activeUnit.bool_1 || activeUnit.vmethod_86().bool_2)
									{
										goto IL_B9A;
									}
									Mission mission = activeUnit.vmethod_101();
									if (Information.IsNothing(mission) || mission != mission_0 || !activeUnit.vmethod_127() || !this.method_35(contact_8, activeUnit, ((Strike)mission_0).int_7))
									{
										goto IL_B9A;
									}
									return true;
								}
							}
							else
							{
								Strike strike = (Strike)mission_0;
								if (!bool_11 && !this.method_31(ref strike, postureStance))
								{
									if (int_1 < 6)
									{
										string_1 = "No contact with relevant posture stance found .";
										int_1 = 6;
									}
									return false;
								}
								switch (((Strike)mission_0).strikeType_0)
								{
								case Strike.StrikeType.Air_Intercept:
								{
									Contact_Base.ContactType contactType6 = contact_8.contactType_0;
									if (contactType6 == Contact_Base.ContactType.Air)
									{
										return true;
									}
									if (contactType6 == Contact_Base.ContactType.Missile)
									{
										return !((Weapon)contact_8.activeUnit_0).method_199();
									}
									if (contactType6 != Contact_Base.ContactType.Orbital)
									{
										if (int_1 < 7)
										{
											string_1 = "No relevant contact found for this mission type (Air Intercept).";
											int_1 = 7;
										}
										return false;
									}
									if (this.activeUnit_0.bool_3 && ((Aircraft)this.activeUnit_0).method_167().loadoutRole_0 != Loadout.LoadoutRole.AntiSatellite_Intercept)
									{
										return false;
									}
									break;
								}
								case Strike.StrikeType.Land_Strike:
								{
									Contact_Base.ContactType contactType7 = contact_8.contactType_0;
									if (contactType7 != Contact_Base.ContactType.Aimpoint && contactType7 - Contact_Base.ContactType.Facility_Fixed > 1)
									{
										if (int_1 < 7)
										{
											string_1 = "No relevant contact types found.";
											int_1 = 7;
										}
										return false;
									}
									if (strike.hashSet_0.Count > 0)
									{
										if (contact_8.method_92(strike))
										{
											return true;
										}
										if (!strike.bool_27)
										{
											byte? b = (nullable_10 != null) ? new byte?((byte)nullable_10.GetValueOrDefault()) : null;
											if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
											{
												ActiveUnit_Weaponry activeUnit_Weaponry9 = this.activeUnit_0.vmethod_89();
												bool checkWRA7 = true;
												Doctrine doctrine_7 = this.activeUnit_0.doctrine_0;
												string text = "";
												int num = 0;
												if (!activeUnit_Weaponry9.method_6(contact_8, checkWRA7, doctrine_7, ref text, ref num, null))
												{
													if (int_1 < 8)
													{
														string_1 = "No relevant contacts can be engaged by the available weapons.";
														int_1 = 8;
													}
													return false;
												}
												b = ((nullable_10 != null) ? new byte?((byte)nullable_10.GetValueOrDefault()) : null);
												if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
												{
													return true;
												}
											}
										}
									}
									else
									{
										if (strike.bool_27 && strike.hashSet_0.Count == 0)
										{
											if (int_1 < 9)
											{
												string_1 = "The mission can only target pre-planned targets, and no targets remain.";
												int_1 = 9;
											}
											return false;
										}
										return true;
									}
									break;
								}
								case Strike.StrikeType.Maritime_Strike:
								{
									Contact_Base.ContactType contactType8 = contact_8.contactType_0;
									if (contactType8 != Contact_Base.ContactType.Surface && contactType8 - Contact_Base.ContactType.UndeterminedNaval > 1)
									{
										if (int_1 < 7)
										{
											string_1 = "No relevant contact types found.";
											int_1 = 7;
										}
										return false;
									}
									if (strike.hashSet_0.Count > 0)
									{
										if (contact_8.method_92(strike))
										{
											return true;
										}
										if (!strike.bool_27)
										{
											byte? b = (nullable_10 != null) ? new byte?((byte)nullable_10.GetValueOrDefault()) : null;
											if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
											{
												ActiveUnit_Weaponry activeUnit_Weaponry10 = this.activeUnit_0.vmethod_89();
												bool checkWRA8 = true;
												Doctrine doctrine_8 = this.activeUnit_0.doctrine_0;
												string text = "";
												int num = 0;
												if (!activeUnit_Weaponry10.method_6(contact_8, checkWRA8, doctrine_8, ref text, ref num, null))
												{
													if (int_1 < 8)
													{
														string_1 = "No relevant contacts can be engaged by the available weapons.";
														int_1 = 8;
													}
													return false;
												}
												b = ((nullable_10 != null) ? new byte?((byte)nullable_10.GetValueOrDefault()) : null);
												if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
												{
													return true;
												}
											}
										}
									}
									else
									{
										if (strike.bool_27 && strike.hashSet_0.Count == 0)
										{
											if (int_1 < 9)
											{
												string_1 = "The mission can only target pre-planned targets, and no targets remain.";
												int_1 = 9;
											}
											return false;
										}
										return true;
									}
									break;
								}
								case Strike.StrikeType.Sub_Strike:
								{
									Contact_Base.ContactType contactType9 = contact_8.contactType_0;
									if (contactType9 - Contact_Base.ContactType.Submarine > 1)
									{
										if (int_1 < 7)
										{
											string_1 = "No relevant contact types found.";
											int_1 = 7;
										}
										return false;
									}
									if (strike.hashSet_0.Count > 0)
									{
										if (contact_8.method_92(strike))
										{
											return true;
										}
										if (!strike.bool_27)
										{
											byte? b = (nullable_10 != null) ? new byte?((byte)nullable_10.GetValueOrDefault()) : null;
											if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
											{
												ActiveUnit_Weaponry activeUnit_Weaponry11 = this.activeUnit_0.vmethod_89();
												bool checkWRA9 = true;
												Doctrine doctrine_9 = this.activeUnit_0.doctrine_0;
												string text = "";
												int num = 0;
												if (!activeUnit_Weaponry11.method_6(contact_8, checkWRA9, doctrine_9, ref text, ref num, null))
												{
													if (int_1 < 8)
													{
														string_1 = "No relevant contacts can be engaged by the available weapons.";
														int_1 = 8;
													}
													return false;
												}
												b = ((nullable_10 != null) ? new byte?((byte)nullable_10.GetValueOrDefault()) : null);
												if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
												{
													return true;
												}
											}
										}
									}
									else
									{
										if (strike.bool_27 && strike.hashSet_0.Count == 0)
										{
											if (int_1 < 9)
											{
												string_1 = "The mission can only target pre-planned targets, and no targets remain.";
												int_1 = 9;
											}
											return false;
										}
										return true;
									}
									break;
								}
								}
							}
							if (int_1 < 1)
							{
								string_1 = "No relevant contact types found.";
								int_1 = 1;
							}
							result = false;
						}
					}
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 100034", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000074D3 File Offset: 0x000056D3
		public void method_40()
		{
			this.bool_1 = true;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x000074DC File Offset: 0x000056DC
		public void method_41()
		{
			this.bool_1 = !this.bool_1;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0008422C File Offset: 0x0008242C
		public bool method_42()
		{
			return this.activeUnit_0.vmethod_59();
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000074ED File Offset: 0x000056ED
		public bool method_43()
		{
			return this.bool_1;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00084250 File Offset: 0x00082450
		public void method_44(List<Contact> list_2, int int_1, float float_3)
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0.vmethod_101()))
				{
					List<Contact> list = Enumerable.ToList<Contact>(Enumerable.OrderByDescending<Contact, float?>(Enumerable.Where<Contact>(list_2, (ActiveUnit_AI._Closure$__.$I133-0 == null) ? (ActiveUnit_AI._Closure$__.$I133-0 = new Func<Contact, bool>(ActiveUnit_AI._Closure$__.$I.method_1)) : ActiveUnit_AI._Closure$__.$I133-0), (ActiveUnit_AI._Closure$__.$I133-1 == null) ? (ActiveUnit_AI._Closure$__.$I133-1 = new Func<Contact, float?>(ActiveUnit_AI._Closure$__.$I.method_2)) : ActiveUnit_AI._Closure$__.$I133-1));
					if (!Information.IsNothing(list) && list.Count > 0)
					{
						if (this.activeUnit_0.vmethod_90().vmethod_1())
						{
							if (this.activeUnit_0.method_121())
							{
								this.method_57(list, float_3);
							}
							else
							{
								this.method_58(list, int_1);
							}
						}
						else
						{
							this.vmethod_4(list[0]);
						}
					}
					else
					{
						this.vmethod_4(null);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100035", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x000074F5 File Offset: 0x000056F5
		private HashSet<Contact> method_45()
		{
			return new HashSet<Contact>(this.method_12());
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00084370 File Offset: 0x00082570
		private void method_46()
		{
			try
			{
				int num = this.activeUnit_0.vmethod_7(false).class316_0.Length;
				if (num > 0)
				{
					Lazy<HashSet<Contact>> lazy = new Lazy<HashSet<Contact>>(new Func<HashSet<Contact>>(this.method_45));
					int i = num - 1;
					while (i >= 0)
					{
						Class316 @class;
						try
						{
							if (this.activeUnit_0.vmethod_7(false).class316_0.Length == 0)
							{
								goto IL_214;
							}
							if (this.activeUnit_0.vmethod_7(false).class316_0.Length - 1 < i)
							{
								i = this.activeUnit_0.vmethod_7(false).class316_0.Length - 1;
							}
							@class = this.activeUnit_0.vmethod_7(false).class316_0[i];
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 200425", ex.Message);
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							goto IL_214;
						}
						goto IL_D9;
						IL_214:
						i += -1;
						continue;
						IL_D9:
						if (@class == null || @class.class273_0 == null)
						{
							goto IL_214;
						}
						int num2 = @class.class273_0.Length;
						if (num2 > 0)
						{
							int j = num2 - 1;
							while (j >= 0)
							{
								Class316.Class273 class2;
								try
								{
									if (@class.class273_0.Length == 0)
									{
										goto IL_21F;
									}
									if (@class.class273_0.Length - 1 < j)
									{
										j = @class.class273_0.Length - 1;
									}
									class2 = @class.class273_0[j];
								}
								catch (Exception ex2)
								{
									ex2.Data.Add("Error at 200426", ex2.Message);
									GameGeneral.smethod_25(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									goto IL_21F;
								}
								goto IL_17B;
								IL_21F:
								j += -1;
								continue;
								IL_17B:
								if (Information.IsNothing(class2) || Operators.CompareString(class2.string_0, this.activeUnit_0.string_0, false) != 0 || class2.int_0 <= class2.int_1 || lazy.Value.Contains(@class.contact_0))
								{
									goto IL_21F;
								}
								ActiveUnit_AI.TargetingEntry targetingEntry = new ActiveUnit_AI.TargetingEntry();
								targetingEntry.contact_0 = @class.contact_0;
								targetingEntry.method_2(ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc);
								if (!this.vmethod_0().ContainsKey(targetingEntry.contact_0.string_0))
								{
									this.vmethod_0().Add(targetingEntry.contact_0.string_0, targetingEntry);
									goto IL_21F;
								}
								goto IL_21F;
							}
							goto IL_214;
						}
						goto IL_214;
					}
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 200640", ex3.Message);
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00084630 File Offset: 0x00082830
		public virtual void vmethod_10(float float_3, bool bool_11, bool bool_12)
		{
			if (this.bool_9)
			{
				try
				{
					this.method_46();
					this.method_37();
					if (this.vmethod_3() != null)
					{
						if (this.vmethod_3().method_124(this.activeUnit_0.scenario_0))
						{
							this.vmethod_15(this.vmethod_3(), true);
						}
						else if (this.vmethod_3().contactType_0 == Contact_Base.ContactType.Aimpoint || this.vmethod_3().contactType_0 == Contact_Base.ContactType.ActivationPoint)
						{
							Side side = this.activeUnit_0.vmethod_7(false);
							Contact contact_ = this.vmethod_3();
							bool flag = side.method_75(ref this.activeUnit_0, ref contact_) != 0;
							this.vmethod_4(contact_);
							if (!flag)
							{
								this.vmethod_15(this.vmethod_3(), true);
							}
						}
					}
					bool flag2 = this.activeUnit_0.vmethod_101() != null && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol && ((Class343)this.activeUnit_0.vmethod_101()).method_66(this.activeUnit_0.scenario_0);
					if (this.method_12().Length > 0)
					{
						List<Contact> list = new List<Contact>();
						bool bool_13;
						Doctrine.Enum59 value;
						if (bool_13 = (this.activeUnit_0.doctrine_0.method_162(this.activeUnit_0.scenario_0, false, false, false) != null))
						{
							value = this.activeUnit_0.doctrine_0.method_162(this.activeUnit_0.scenario_0, false, false, false).Value;
						}
						foreach (Contact contact in this.method_12())
						{
							if (!Information.IsNothing(contact))
							{
								ActiveUnit_AI.TargetingEntry._TargetingBehavior? targetingBehavior = null;
								Misc.PostureStance postureStance;
								if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(contact.string_0, out postureStance))
								{
									postureStance = contact.method_130(this.activeUnit_0.vmethod_7(false));
								}
								if (postureStance == Misc.PostureStance.Friendly)
								{
									list.Add(contact);
								}
								else
								{
									if (contact.method_124(this.activeUnit_0.scenario_0))
									{
										if (!this.activeUnit_0.vmethod_88().method_40(contact))
										{
											list.Add(contact);
											goto IL_1431;
										}
									}
									else if ((bool_12 || this.activeUnit_0.scenario_0.FifthSecondIsChangingOnThisPulse) && this.activeUnit_0.bool_3)
									{
										if (contact.contactType_0 == Contact_Base.ContactType.Submarine)
										{
											ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
											Contact theTarget = contact;
											bool checkWRA = true;
											Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
											string text = "";
											int num = 0;
											if (!activeUnit_Weaponry.method_6(theTarget, checkWRA, doctrine_, ref text, ref num, null) && postureStance != Misc.PostureStance.Unknown && !this.activeUnit_0.vmethod_88().method_40(contact))
											{
												list.Add(contact);
												if (Information.IsNothing(targetingBehavior))
												{
													targetingBehavior = new ActiveUnit_AI.TargetingEntry._TargetingBehavior?(this.method_20(contact));
												}
												short? num2 = (targetingBehavior != null) ? new short?((short)targetingBehavior.GetValueOrDefault()) : null;
												if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 2) : null).GetValueOrDefault())
												{
													string text2 = "";
													if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
													{
														text2 = " (" + this.activeUnit_0.string_2 + ")";
													}
													this.activeUnit_0.method_124(string.Concat(new string[]
													{
														this.activeUnit_0.Name,
														text2,
														" is dropping ",
														contact.Name,
														" from its target list (Reason: No suitable available weaponry)."
													}), "Targetting issue", LoggedMessage.MessageType.UnitAI, 5, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
													goto IL_1431;
												}
												goto IL_1431;
											}
										}
										else if (contact.method_134())
										{
											if (Information.IsNothing(targetingBehavior))
											{
												targetingBehavior = new ActiveUnit_AI.TargetingEntry._TargetingBehavior?(this.method_20(contact));
											}
											short? num2 = (targetingBehavior != null) ? new short?((short)targetingBehavior.GetValueOrDefault()) : null;
											if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 2) : null).GetValueOrDefault())
											{
												ActiveUnit_Weaponry activeUnit_Weaponry2 = this.activeUnit_0.vmethod_89();
												Contact theTarget2 = contact;
												bool checkWRA2 = true;
												Doctrine doctrine_2 = this.activeUnit_0.doctrine_0;
												string text = "";
												int num = 0;
												if (!activeUnit_Weaponry2.method_6(theTarget2, checkWRA2, doctrine_2, ref text, ref num, null) && postureStance != Misc.PostureStance.Unknown && !this.activeUnit_0.method_94() && !this.activeUnit_0.method_95())
												{
													list.Add(contact);
													string text3 = "";
													if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
													{
														text3 = " (" + this.activeUnit_0.string_2 + ")";
													}
													this.activeUnit_0.method_124(string.Concat(new string[]
													{
														this.activeUnit_0.Name,
														text3,
														" is dropping ",
														contact.Name,
														" from its target list (Reason: No suitable available weaponry)."
													}), "Targetting issue", LoggedMessage.MessageType.UnitAI, 5, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
													goto IL_1431;
												}
											}
										}
									}
									if ((bool_12 || this.activeUnit_0.scenario_0.FifthSecondIsChangingOnThisPulse) && (!this.activeUnit_0.vmethod_85().method_49() || Enumerable.Count<Contact>(this.method_12()) > 1) && this.method_65(contact))
									{
										if (Information.IsNothing(targetingBehavior))
										{
											targetingBehavior = new ActiveUnit_AI.TargetingEntry._TargetingBehavior?(this.method_20(contact));
										}
										short? num2 = (targetingBehavior != null) ? new short?((short)targetingBehavior.GetValueOrDefault()) : null;
										if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											string text4 = "";
											if (this.activeUnit_0.bool_3 && Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
											{
												text4 = " (" + this.activeUnit_0.string_2 + ")";
											}
											this.activeUnit_0.method_124(string.Concat(new string[]
											{
												this.activeUnit_0.Name,
												text4,
												" is dropping ",
												contact.Name,
												" from its target list (Reason: The target is a waste of ammo)."
											}), "Targetting issue", LoggedMessage.MessageType.UnitAI, 5, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
											list.Add(contact);
											goto IL_1431;
										}
									}
									Contact_Base.ContactType contactType = contact.contactType_0;
									if (contactType != Contact_Base.ContactType.Sonobuoy)
									{
										if (contactType - Contact_Base.ContactType.Installation <= 3)
										{
											list.Add(contact);
										}
										else if (contact.method_72())
										{
											list.Add(contact);
										}
										else if (contact.method_136() && (this.activeUnit_0.bool_6 || this.activeUnit_0.bool_3) && Class442.smethod_1(contact.vmethod_28(null), contact.vmethod_30(null)))
										{
											list.Add(contact);
										}
										else
										{
											if ((bool_12 || this.activeUnit_0.scenario_0.FifteenthSecondIsChangingOnThisPulse) && postureStance <= Misc.PostureStance.Friendly)
											{
												if (Information.IsNothing(targetingBehavior))
												{
													targetingBehavior = new ActiveUnit_AI.TargetingEntry._TargetingBehavior?(this.method_20(contact));
												}
												ActiveUnit_AI.TargetingEntry._TargetingBehavior? targetingBehavior2 = targetingBehavior;
												short? num2 = (targetingBehavior2 != null) ? new short?((short)targetingBehavior2.GetValueOrDefault()) : null;
												if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
												{
													list.Add(contact);
												}
												else
												{
													num2 = ((targetingBehavior2 != null) ? new short?((short)targetingBehavior2.GetValueOrDefault()) : null);
													if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 2) : null).GetValueOrDefault())
													{
														list.Add(contact);
													}
													else
													{
														num2 = ((targetingBehavior2 != null) ? new short?((short)targetingBehavior2.GetValueOrDefault()) : null);
														((num2 != null) ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault();
													}
												}
											}
											if (bool_12 || this.activeUnit_0.scenario_0.FifteenthSecondIsChangingOnThisPulse)
											{
												if (this.activeUnit_0.method_68())
												{
													if (!contact.method_106())
													{
														Class343 @class = (Class343)this.activeUnit_0.vmethod_101();
														if (@class.method_65())
														{
															if (!contact.vmethod_46(@class.list_5, this.activeUnit_0.scenario_0, true) && !contact.vmethod_46(@class.list_15, this.activeUnit_0.scenario_0, true))
															{
																if (Information.IsNothing(targetingBehavior))
																{
																	targetingBehavior = new ActiveUnit_AI.TargetingEntry._TargetingBehavior?(this.method_20(contact));
																}
																short? num2 = (targetingBehavior != null) ? new short?((short)targetingBehavior.GetValueOrDefault()) : null;
																if (((num2 != null) ? new bool?(num2.GetValueOrDefault() != 1) : null).GetValueOrDefault() && !this.activeUnit_0.vmethod_88().method_40(contact))
																{
																	if (!@class.method_68(this.activeUnit_0.scenario_0))
																	{
																		list.Add(contact);
																		string text5 = "";
																		if (this.activeUnit_0.bool_3 && Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
																		{
																			text5 = " (" + this.activeUnit_0.string_2 + ")";
																		}
																		this.activeUnit_0.method_124(string.Concat(new string[]
																		{
																			this.activeUnit_0.Name,
																			text5,
																			" is dropping ",
																			contact.Name,
																			" from its target list (Reason: The target is outside the unit's station/prosecution area)."
																		}), this.activeUnit_0.Name + " drops " + contact.Name, LoggedMessage.MessageType.UnitAI, 5, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
																		goto IL_1431;
																	}
																	Weapon expression;
																	if (Information.IsNothing(expression))
																	{
																		expression = this.activeUnit_0.vmethod_89().method_55(false);
																	}
																	Weapon expression2;
																	if (Information.IsNothing(expression2))
																	{
																		expression2 = this.activeUnit_0.vmethod_89().method_56(false);
																	}
																	if (!this.method_47(contact, postureStance, bool_13, value, this.activeUnit_0.vmethod_89().method_54(), this.activeUnit_0.vmethod_89().method_55(false), this.activeUnit_0.vmethod_89().method_56(false), this.activeUnit_0.vmethod_89().method_57()))
																	{
																		list.Add(contact);
																		string text6 = "";
																		if (this.activeUnit_0.bool_3 && Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
																		{
																			text6 = " (" + this.activeUnit_0.string_2 + ")";
																		}
																		this.activeUnit_0.method_124(string.Concat(new string[]
																		{
																			this.activeUnit_0.Name,
																			text6,
																			" is dropping ",
																			contact.Name,
																			" from its target list (Reason: The target is outside the unit's station/prosecution area and outside weapon range)."
																		}), this.activeUnit_0.Name + " drops " + contact.Name, LoggedMessage.MessageType.UnitAI, 5, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
																		goto IL_1431;
																	}
																}
															}
														}
														else if (!flag2 && contact.contactType_0 != Contact_Base.ContactType.Missile && !contact.vmethod_46(@class.list_5, this.activeUnit_0.scenario_0, true))
														{
															if (Information.IsNothing(targetingBehavior))
															{
																targetingBehavior = new ActiveUnit_AI.TargetingEntry._TargetingBehavior?(this.method_20(contact));
															}
															short? num2 = (targetingBehavior != null) ? new short?((short)targetingBehavior.GetValueOrDefault()) : null;
															if (((num2 != null) ? new bool?(num2.GetValueOrDefault() != 1) : null).GetValueOrDefault() && !this.activeUnit_0.vmethod_88().method_40(contact))
															{
																if (!@class.method_68(this.activeUnit_0.scenario_0))
																{
																	list.Add(contact);
																	string text7 = "";
																	if (this.activeUnit_0.bool_3 && Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
																	{
																		text7 = " (" + this.activeUnit_0.string_2 + ")";
																	}
																	this.activeUnit_0.method_124(string.Concat(new string[]
																	{
																		this.activeUnit_0.Name,
																		text7,
																		" is dropping ",
																		contact.Name,
																		" from its target list (Reason: The target is outside the unit's station area, and the unit is not authorize to prosecute outside the area)."
																	}), this.activeUnit_0.Name + " drops " + contact.Name, LoggedMessage.MessageType.UnitAI, 5, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
																	goto IL_1431;
																}
																Weapon expression;
																if (Information.IsNothing(expression))
																{
																	expression = this.activeUnit_0.vmethod_89().method_55(false);
																}
																Weapon expression2;
																if (Information.IsNothing(expression2))
																{
																	expression2 = this.activeUnit_0.vmethod_89().method_56(false);
																}
																if (!this.method_47(contact, postureStance, bool_13, value, this.activeUnit_0.vmethod_89().method_54(), this.activeUnit_0.vmethod_89().method_55(false), this.activeUnit_0.vmethod_89().method_56(false), this.activeUnit_0.vmethod_89().method_57()))
																{
																	list.Add(contact);
																	string text8 = "";
																	if (this.activeUnit_0.bool_3 && Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
																	{
																		text8 = " (" + this.activeUnit_0.string_2 + ")";
																	}
																	this.activeUnit_0.method_124(string.Concat(new string[]
																	{
																		this.activeUnit_0.Name,
																		text8,
																		" is dropping ",
																		contact.Name,
																		" from its target list (Reason: The target is outside the unit's station area and outside weapon range, and the unit is not authorize to prosecute outside the area)."
																	}), this.activeUnit_0.Name + " drops " + contact.Name, LoggedMessage.MessageType.UnitAI, 5, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
																	goto IL_1431;
																}
															}
														}
													}
												}
												else if (this.activeUnit_0.method_69() && (Strike)this.activeUnit_0.vmethod_101() != null)
												{
													Strike strike = (Strike)this.activeUnit_0.vmethod_101();
													if (strike.bool_27 && strike.hashSet_0.Count > 0 && !contact.method_92(strike))
													{
														list.Add(contact);
													}
												}
											}
											if (bool_12 || this.activeUnit_0.scenario_0.FifthSecondIsChangingOnThisPulse)
											{
												if (Information.IsNothing(targetingBehavior))
												{
													targetingBehavior = new ActiveUnit_AI.TargetingEntry._TargetingBehavior?(this.method_20(contact));
												}
												short? num2 = (targetingBehavior != null) ? new short?((short)targetingBehavior.GetValueOrDefault()) : null;
												if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault() && this.activeUnit_0.vmethod_7(false).method_75(ref this.activeUnit_0, ref contact) == 0 && contact.method_100().Length == 0)
												{
													list.Add(contact);
													string text9 = "";
													if (this.activeUnit_0.bool_3 && Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
													{
														text9 = " (" + this.activeUnit_0.string_2 + ")";
													}
													if (contact.contactType_0 != Contact_Base.ContactType.Aimpoint)
													{
														if (contact.contactType_0 != Contact_Base.ContactType.ActivationPoint)
														{
															this.activeUnit_0.method_124(string.Concat(new string[]
															{
																this.activeUnit_0.Name,
																text9,
																" is dropping ",
																contact.Name,
																" from its target list (Reason: The target is not auto-targeted, and no outstanding weapons or assignments against it exist)."
															}), "Targetting issue", LoggedMessage.MessageType.UnitAI, 5, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
															goto IL_1431;
														}
													}
													this.activeUnit_0.method_124(string.Concat(new string[]
													{
														this.activeUnit_0.Name,
														text9,
														" has finished firing at ",
														contact.Name,
														"."
													}), "Targetting issue", LoggedMessage.MessageType.UnitAI, 5, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
													goto IL_1431;
												}
											}
											Contact.Enum47? @enum = contact.method_74(this.activeUnit_0.vmethod_7(false));
											byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
											if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
											{
												list.Add(contact);
											}
											else
											{
												if ((bool_12 || this.activeUnit_0.scenario_0.FifthSecondIsChangingOnThisPulse) && this.bool_2)
												{
													ActiveUnit_Weaponry activeUnit_Weaponry3 = this.activeUnit_0.vmethod_89();
													Contact theTarget3 = contact;
													bool checkWRA3 = true;
													Doctrine doctrine_3 = this.activeUnit_0.doctrine_0;
													string text = "";
													int num = 0;
													if (!activeUnit_Weaponry3.method_6(theTarget3, checkWRA3, doctrine_3, ref text, ref num, null))
													{
														list.Add(contact);
														goto IL_1431;
													}
													if (this.method_20(contact) == ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted && postureStance == Misc.PostureStance.Friendly)
													{
														list.Add(contact);
														goto IL_1431;
													}
												}
												if ((bool_12 || this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse) && this.activeUnit_0.bool_5 && contact.bool_18 && contact.bool_17 && !this.method_48(contact, false))
												{
													list.Add(contact);
													string text10 = "";
													if (this.activeUnit_0.bool_3 && Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
													{
														text10 = " (" + this.activeUnit_0.string_2 + ")";
													}
													this.activeUnit_0.method_124(string.Concat(new string[]
													{
														this.activeUnit_0.Name,
														text10,
														" is dropping ",
														contact.Name,
														" from its target list (Reason: Cannot intercept target at max speed at current depth)."
													}), "Targetting issue", LoggedMessage.MessageType.UnitAI, 5, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
												}
											}
										}
									}
									else
									{
										list.Add(contact);
									}
								}
							}
							IL_1431:;
						}
						try
						{
							foreach (Contact theTarget4 in list)
							{
								this.vmethod_15(theTarget4, true);
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200328", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00085B28 File Offset: 0x00083D28
		protected bool method_47(Contact contact_8, Misc.PostureStance postureStance_0, bool bool_11, Doctrine.Enum59 enum59_0, Weapon weapon_0, Weapon weapon_1, Weapon weapon_2, Weapon weapon_3)
		{
			bool result;
			try
			{
				switch (contact_8.contactType_0)
				{
				case Contact_Base.ContactType.Air:
					if (this.activeUnit_0.bool_5)
					{
						if (contact_8.activeUnit_0 != null && contact_8.activeUnit_0.bool_3 && contact_8.method_125() >= Contact_Base.IdentificationStatus.KnownType)
						{
							Aircraft._AircraftType aircraftType_ = ((Aircraft)contact_8.activeUnit_0)._AircraftType_0;
							if (aircraftType_ - Aircraft._AircraftType.ASW <= 1 && (postureStance_0 == Misc.PostureStance.Hostile || postureStance_0 == Misc.PostureStance.Unfriendly) && weapon_0 != null)
							{
								float num = (float)contact_8.method_80() * weapon_0.float_29;
								if (Class410.smethod_3(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), contact_8.vmethod_30(null), contact_8.vmethod_28(null), num))
								{
									return true;
								}
							}
						}
					}
					else if (weapon_0 != null && this.activeUnit_0.method_37(contact_8, 0f) < (float)contact_8.method_80() * weapon_0.float_29)
					{
						return true;
					}
					break;
				case Contact_Base.ContactType.Missile:
					if (this.activeUnit_0.bool_5)
					{
						return false;
					}
					if (weapon_0 != null && this.activeUnit_0.method_37(contact_8, 0f) < (float)contact_8.method_80() * weapon_0.float_29)
					{
						return true;
					}
					break;
				case Contact_Base.ContactType.Surface:
				case Contact_Base.ContactType.UndeterminedNaval:
					if (bool_11 && enum59_0 == Doctrine.Enum59.const_1 && weapon_1 != null)
					{
						if (this.activeUnit_0.bool_5)
						{
							float float_ = weapon_1.float_31;
							if (Class410.smethod_3(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), contact_8.vmethod_30(null), contact_8.vmethod_28(null), float_))
							{
								return true;
							}
						}
						else if (!this.activeUnit_0.bool_8 && !this.activeUnit_0.bool_6)
						{
							float num2 = (float)contact_8.method_80() * weapon_1.float_31;
							if (Class410.smethod_3(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), contact_8.vmethod_30(null), contact_8.vmethod_28(null), num2))
							{
								return true;
							}
						}
						else
						{
							float float_2 = weapon_1.float_31;
							if (Class410.smethod_3(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), contact_8.vmethod_30(null), contact_8.vmethod_28(null), float_2))
							{
								return true;
							}
						}
					}
					break;
				case Contact_Base.ContactType.Submarine:
					if (weapon_3 != null)
					{
						if (contact_8.method_72())
						{
							return false;
						}
						if (this.activeUnit_0.bool_5)
						{
							float float_3 = weapon_3.float_35;
							if (Class410.smethod_3(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), contact_8.vmethod_30(null), contact_8.vmethod_28(null), float_3))
							{
								return true;
							}
						}
						else if (!this.activeUnit_0.bool_8 && !this.activeUnit_0.bool_6)
						{
							if (Class442.smethod_1(contact_8.vmethod_28(null), contact_8.vmethod_30(null)))
							{
								return false;
							}
							float num3 = (float)contact_8.method_80() * weapon_3.float_35;
							if (Class410.smethod_3(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), contact_8.vmethod_30(null), contact_8.vmethod_28(null), num3))
							{
								return true;
							}
						}
						else
						{
							if (Class442.smethod_1(contact_8.vmethod_28(null), contact_8.vmethod_30(null)))
							{
								return false;
							}
							float float_4 = weapon_3.float_35;
							if (Class410.smethod_3(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), contact_8.vmethod_30(null), contact_8.vmethod_28(null), float_4))
							{
								return true;
							}
						}
					}
					break;
				case Contact_Base.ContactType.Aimpoint:
				case Contact_Base.ContactType.Facility_Fixed:
				case Contact_Base.ContactType.Facility_Mobile:
					if (bool_11 && enum59_0 == Doctrine.Enum59.const_1 && weapon_2 != null)
					{
						if (!this.activeUnit_0.bool_5 && !this.activeUnit_0.bool_8 && !this.activeUnit_0.bool_6)
						{
							float num4 = weapon_2.float_33 * (float)contact_8.method_80();
							if (Class410.smethod_3(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), contact_8.vmethod_30(null), contact_8.vmethod_28(null), num4))
							{
								return true;
							}
						}
						else
						{
							float float_5 = weapon_2.float_33;
							if (Class410.smethod_3(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), contact_8.vmethod_30(null), contact_8.vmethod_28(null), float_5))
							{
								return true;
							}
						}
					}
					break;
				case Contact_Base.ContactType.Orbital:
					if (bool_11 && enum59_0 == Doctrine.Enum59.const_1)
					{
						ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
						bool checkWRA = true;
						Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
						string text = "";
						int num5 = 0;
						if (activeUnit_Weaponry.method_6(contact_8, checkWRA, doctrine_, ref text, ref num5, null) && weapon_0 != null && this.activeUnit_0.method_37(contact_8, 0f) < (float)contact_8.method_80() * weapon_0.float_29)
						{
							return true;
						}
					}
					break;
				case Contact_Base.ContactType.Torpedo:
					if (this.activeUnit_0.bool_6 && weapon_3 != null && this.activeUnit_0.method_37(contact_8, 0f) < weapon_3.float_35 * 2f)
					{
						return true;
					}
					break;
				}
				result = false;
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

		// Token: 0x06000808 RID: 2056 RVA: 0x00086220 File Offset: 0x00084420
		public bool method_48(Contact contact_8, bool bool_11)
		{
			bool result;
			try
			{
				Weapon weapon = this.activeUnit_0.vmethod_89().method_16(contact_8, false, false, true, this.activeUnit_0.doctrine_0);
				double double_;
				double double_2;
				if (Information.IsNothing(weapon))
				{
					double_ = contact_8.vmethod_30(null);
					double_2 = contact_8.vmethod_28(null);
				}
				else
				{
					float num = this.activeUnit_0.method_36(contact_8);
					if (num < weapon.method_181(this.activeUnit_0, contact_8, false, this.activeUnit_0.doctrine_0, false))
					{
						return true;
					}
					Weapon._WeaponType weaponType = weapon.method_167();
					if (weaponType - Weapon._WeaponType.GuidedWeapon > 1 && weaponType != Weapon._WeaponType.Gun)
					{
						if (weaponType != Weapon._WeaponType.Laser)
						{
							double_ = contact_8.vmethod_30(null);
							double_2 = contact_8.vmethod_28(null);
							goto IL_17E;
						}
					}
					float num2 = weapon.method_181(this.activeUnit_0, contact_8, true, this.activeUnit_0.doctrine_0, false);
					if (num <= num2)
					{
						return true;
					}
					Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref double_2, ref double_, (double)(num - num2), (double)Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), contact_8.vmethod_30(null), contact_8.vmethod_28(null)));
				}
				IL_17E:
				if (!this.vmethod_20(double_, double_2, contact_8.vmethod_9(), contact_8.vmethod_40(), this.activeUnit_0.vmethod_14(false), (float)this.activeUnit_0.vmethod_87().vmethod_39(this.activeUnit_0.vmethod_14(false)), this.activeUnit_0.vmethod_9(), null, false, bool_11))
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
				ex.Data.Add("Error at 200591", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00086464 File Offset: 0x00084664
		public virtual void vmethod_11(float float_3, bool bool_11, bool bool_12)
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0))
				{
					Doctrine.Enum61? @enum = this.activeUnit_0.doctrine_0.method_137(this.activeUnit_0.scenario_0, false, false, false);
					byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						if (!Information.IsNothing(this.contact_1))
						{
							this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedDefensive);
							return;
						}
						if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
						{
							this.activeUnit_0.vmethod_109(this.activeUnit_0._ActiveUnitStatus_3);
						}
					}
					ActiveUnit activeUnit = this.activeUnit_0;
					Mission.Flight flight_ = null;
					Exception ex = null;
					if (Class522.smethod_8(activeUnit, flight_, ref ex))
					{
						this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.WaitForPathfinder);
					}
					else if (!this.activeUnit_0.method_85())
					{
						if (this.activeUnit_0.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsWinchester && this.activeUnit_0.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsShotgun)
						{
							ActiveUnit._ActiveUnitWeaponState activeUnitWeaponState = this.activeUnit_0.vmethod_89().vmethod_5();
							if ((activeUnitWeaponState == ActiveUnit._ActiveUnitWeaponState.IsWinchester || activeUnitWeaponState == ActiveUnit._ActiveUnitWeaponState.IsShotgun) && this.activeUnit_0.bool_3 && ((Aircraft)this.activeUnit_0).method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true))
							{
								return;
							}
						}
						bool? flag;
						bool? flag3;
						if (!this.activeUnit_0.vmethod_85().method_46())
						{
							flag = new bool?(false);
						}
						else
						{
							bool? flag2;
							if (Information.IsNothing(this.vmethod_3()))
							{
								flag2 = new bool?(false);
							}
							else
							{
								Doctrine.Enum64? enum2 = this.activeUnit_0.doctrine_0.method_83(this.activeUnit_0.scenario_0, false, null, false, false);
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null);
							}
							flag3 = flag2;
							flag = ((flag3 != null) ? new bool?(!flag3.GetValueOrDefault()) : flag3);
						}
						flag3 = flag;
						if (flag3.GetValueOrDefault())
						{
							this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
						}
						else if (!Information.IsNothing(this.vmethod_3()))
						{
							this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
						}
						else if (this.activeUnit_0.method_120() && (this.activeUnit_0.vmethod_65(false).method_143() == Group.GroupType.AirGroup && this.activeUnit_0.vmethod_65(false).vmethod_108() == ActiveUnit._ActiveUnitStatus.FormingUp))
						{
							this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.FormingUp);
						}
						else
						{
							if (!this.activeUnit_0.bool_1 && !this.activeUnit_0.bool_2 && this.activeUnit_0.vmethod_101() != null && this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.RTB_MissionOver)
							{
								if (this.activeUnit_0.vmethod_101().method_12())
								{
									if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPatrol);
										return;
									}
									if (!this.activeUnit_0.method_94() && !this.activeUnit_0.method_95())
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Tasked);
										return;
									}
									this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
								}
								else
								{
									this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
								}
							}
							this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
						}
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 200345", ex2.Message);
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0008682C File Offset: 0x00084A2C
		internal Contact method_49(List<Contact> list_2)
		{
			Contact result;
			try
			{
				Contact contact = null;
				double num = 20000.0;
				try
				{
					foreach (Contact contact2 in list_2)
					{
						double num2 = (double)this.activeUnit_0.method_37(contact2, 0f);
						if (num2 < num)
						{
							contact = contact2;
							num = num2;
						}
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = contact;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100038", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000868EC File Offset: 0x00084AEC
		public void method_50()
		{
			try
			{
				Weapon[] array = Enumerable.ToArray<Weapon>(Enumerable.Where<Weapon>(this.activeUnit_0.vmethod_89().vmethod_4(), (ActiveUnit_AI._Closure$__.$I141-0 == null) ? (ActiveUnit_AI._Closure$__.$I141-0 = new Func<Weapon, bool>(ActiveUnit_AI._Closure$__.$I.method_3)) : ActiveUnit_AI._Closure$__.$I141-0));
				if (Enumerable.Count<Weapon>(array) != 0)
				{
					float num;
					float num2;
					if (this.activeUnit_0.scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(this.activeUnit_0.scenario_0.method_39()))
					{
						num = Enumerable.Max(Enumerable.Select<Weapon, float>(array, (ActiveUnit_AI._Closure$__.$I141-1 == null) ? (ActiveUnit_AI._Closure$__.$I141-1 = new Func<Weapon, float>(ActiveUnit_AI._Closure$__.$I.method_4)) : ActiveUnit_AI._Closure$__.$I141-1));
						num2 = Enumerable.Min(Enumerable.Select<Weapon, float>(array, (ActiveUnit_AI._Closure$__.$I141-2 == null) ? (ActiveUnit_AI._Closure$__.$I141-2 = new Func<Weapon, float>(ActiveUnit_AI._Closure$__.$I.method_5)) : ActiveUnit_AI._Closure$__.$I141-2));
					}
					else
					{
						num = Enumerable.Max(Enumerable.Select<Weapon, float>(array, (ActiveUnit_AI._Closure$__.$I141-3 == null) ? (ActiveUnit_AI._Closure$__.$I141-3 = new Func<Weapon, float>(ActiveUnit_AI._Closure$__.$I.method_6)) : ActiveUnit_AI._Closure$__.$I141-3));
						num2 = Enumerable.Min(Enumerable.Select<Weapon, float>(array, (ActiveUnit_AI._Closure$__.$I141-4 == null) ? (ActiveUnit_AI._Closure$__.$I141-4 = new Func<Weapon, float>(ActiveUnit_AI._Closure$__.$I.method_7)) : ActiveUnit_AI._Closure$__.$I141-4));
					}
					if (this.activeUnit_0.vmethod_14(false) > num)
					{
						this.activeUnit_0.vmethod_73(num - 10f);
					}
					if (this.activeUnit_0.vmethod_14(false) < num2)
					{
						this.activeUnit_0.vmethod_73(num2 + 10f);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100039", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00086AC4 File Offset: 0x00084CC4
		public bool method_51(float float_3)
		{
			bool result;
			try
			{
				if (Information.IsNothing(this.activeUnit_0))
				{
					result = false;
				}
				else if (!this.activeUnit_0.vmethod_60())
				{
					result = false;
				}
				else if (Information.IsNothing(this.activeUnit_0.vmethod_101()))
				{
					result = false;
				}
				else if (this.activeUnit_0.vmethod_101()._MissionClass_0 != Mission._MissionClass.Mining)
				{
					result = false;
				}
				else if (!this.activeUnit_0.vmethod_101().method_12())
				{
					result = false;
				}
				else
				{
					bool flag = false;
					if (Enumerable.Count<Weapon>(Enumerable.ToArray<Weapon>(Enumerable.Where<Weapon>(this.activeUnit_0.vmethod_89().vmethod_4(), (ActiveUnit_AI._Closure$__.$I142-0 == null) ? (ActiveUnit_AI._Closure$__.$I142-0 = new Func<Weapon, bool>(ActiveUnit_AI._Closure$__.$I.method_8)) : ActiveUnit_AI._Closure$__.$I142-0))) > 0)
					{
						if (this.activeUnit_0.method_15())
						{
							flag = false;
						}
						else if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Mining)
						{
							Class340 @class = (Class340)this.activeUnit_0.vmethod_101();
							if (@class.list_5.Count > 2)
							{
								if (this.activeUnit_0.vmethod_85().method_40(ref @class.list_5, ref @class.list_5, ref @class.list_6, 0, false, false))
								{
									flag = true;
								}
							}
							else if (this.activeUnit_0.vmethod_85().method_40(ref @class.list_5, ref @class.list_15, ref @class.list_10, 10, false, false))
							{
								flag = true;
							}
						}
					}
					result = flag;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100040", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00086C9C File Offset: 0x00084E9C
		public void method_52(ref Weapon weapon_0, Contact contact_8)
		{
			try
			{
				if (!Information.IsNothing(contact_8))
				{
					if (!Information.IsNothing(weapon_0))
					{
						Mount mount = null;
						try
						{
							foreach (Mount mount2 in this.activeUnit_0.vmethod_51())
							{
								if (!Information.IsNothing(mount))
								{
									break;
								}
								if ((!this.activeUnit_0.bool_3 || mount2.bool_14) && mount2.vmethod_5() == PlatformComponent._ComponentStatus.Operational && mount2.enum113_0 == Mount.Enum113.const_0)
								{
									try
									{
										foreach (WeaponRec weaponRec in mount2.vmethod_10())
										{
											if (weaponRec.int_5 == weapon_0.DBID && weaponRec.method_9() > 0)
											{
												mount = mount2;
												break;
											}
										}
									}
									finally
									{
										List<WeaponRec>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
								}
							}
						}
						finally
						{
							List<Mount>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (!Information.IsNothing(mount) && !mount.method_20(contact_8, null))
						{
							if (weapon_0.method_167() == Weapon._WeaponType.DepthCharge)
							{
								this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.method_32(contact_8));
							}
							else
							{
								int num = 1;
								int num2;
								for (;;)
								{
									num2 = Math2.smethod_8((int)Math.Round((double)(this.activeUnit_0.vmethod_9() + (float)num)));
									if (mount.method_20(contact_8, new float?((float)num2)))
									{
										break;
									}
									num2 = Math2.smethod_8((int)Math.Round((double)(this.activeUnit_0.vmethod_9() - (float)num)));
									if (mount.method_20(contact_8, new float?((float)num2)))
									{
										goto IL_19F;
									}
									num++;
									if (num > 180)
									{
										goto IL_1B0;
									}
								}
								this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, (float)num2);
								return;
								IL_19F:
								this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, (float)num2);
							}
						}
						IL_1B0:;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101353", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00086EE0 File Offset: 0x000850E0
		public void method_53(ref Contact contact_8, bool bool_11)
		{
			if (bool_11 && contact_8.contactType_0 != Contact_Base.ContactType.Aimpoint && contact_8.contactType_0 != Contact_Base.ContactType.ActivationPoint && contact_8.method_130(this.activeUnit_0.vmethod_7(false)) != Misc.PostureStance.Hostile)
			{
				contact_8.method_131(this.activeUnit_0.vmethod_7(false), true, Misc.PostureStance.Hostile);
				this.activeUnit_0.method_124("Contact: " + contact_8.Name + " has been manually marked as hostile!", "Manual target classification", LoggedMessage.MessageType.ContactChange, 0, false, default(Geopoint_Struct));
			}
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00086F64 File Offset: 0x00085164
		public virtual void vmethod_12(Contact contact_8, bool bool_11, bool bool_12, ActiveUnit_AI.TargetingEntry._TargetingBehavior _TargetingBehavior_0)
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (contact_8.contactType_0 != Contact_Base.ContactType.Sonobuoy)
					{
						if (!contact_8.method_124(this.activeUnit_0.scenario_0))
						{
							if (bool_11 || !this.method_65(contact_8))
							{
								if (contact_8.contactType_0 == Contact_Base.ContactType.Missile)
								{
									Weapon weapon = (Weapon)contact_8.activeUnit_0;
									if (weapon.method_199())
									{
										ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
										Contact theTarget = contact_8;
										bool checkWRA = false;
										Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
										string empty = string.Empty;
										int num = 0;
										if (!activeUnit_Weaponry.method_6(theTarget, checkWRA, doctrine_, ref empty, ref num, null))
										{
											if (Information.IsNothing(weapon.vmethod_142().vmethod_3()) || Information.IsNothing(weapon.vmethod_142().vmethod_3().activeUnit_0))
											{
												if (bool_11)
												{
													this.activeUnit_0.string_3 = "Cannot shoot at an AAW weapon!";
												}
												return;
											}
											if (!weapon.vmethod_142().vmethod_3().activeUnit_0.bool_6 && (!weapon.vmethod_142().vmethod_3().activeUnit_0.bool_5 || !((Submarine)weapon.vmethod_142().vmethod_3().activeUnit_0).method_161()))
											{
												if (bool_11)
												{
													this.activeUnit_0.string_3 = "Cannot shoot at an AAW weapon!";
												}
												return;
											}
										}
									}
								}
								if (this.activeUnit_0.bool_2 && bool_12)
								{
									ActiveUnit_Weaponry activeUnit_Weaponry2 = this.activeUnit_0.vmethod_89();
									Weapon theWeapon = (Weapon)this.activeUnit_0;
									Contact theTarget2 = contact_8;
									short? num2 = new short?((short)Math.Max(0, this.activeUnit_0.method_9(false, false, false)));
									bool manualFire = false;
									bool ignoreAircraftOrientation = false;
									Mount theMount = null;
									Sensor sensor = null;
									ValueTuple<string, ActiveUnit_Weaponry.Enum36> valueTuple = activeUnit_Weaponry2.method_23(theWeapon, theTarget2, ref num2, manualFire, ignoreAircraftOrientation, theMount, ref sensor);
									if (valueTuple.Item2 != ActiveUnit_Weaponry.Enum36.const_0)
									{
										this.activeUnit_0.method_124("Weapon " + this.activeUnit_0.Name + " is not capable against this target type! Reason: " + valueTuple.Item1, "Weapon not capable against this target!", LoggedMessage.MessageType.WeaponLogic, 0, false, default(Geopoint_Struct));
										return;
									}
								}
								this.method_53(ref contact_8, bool_11);
								if (this.vmethod_0().ContainsKey(contact_8.string_0))
								{
									if (this.vmethod_0()[contact_8.string_0].method_1() != _TargetingBehavior_0)
									{
										this.vmethod_0()[contact_8.string_0].method_2(_TargetingBehavior_0);
									}
								}
								else
								{
									ActiveUnit_AI.TargetingEntry targetingEntry = new ActiveUnit_AI.TargetingEntry();
									targetingEntry.contact_0 = contact_8;
									targetingEntry.method_2(_TargetingBehavior_0);
									this.vmethod_0().Add(contact_8.string_0, targetingEntry);
								}
								if (bool_12 || (bool_11 && this.activeUnit_0.bool_2))
								{
									this.vmethod_4(contact_8);
									this.bool_0 = true;
								}
								this.float_1 = 0f;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100041", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00007502 File Offset: 0x00005702
		public virtual void vmethod_13(Contact contact_8)
		{
			if (!Class429.smethod_16(ref this.contact_2, contact_8))
			{
				Class429.smethod_13(ref this.contact_2, contact_8);
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0000751E File Offset: 0x0000571E
		public virtual void vmethod_14(Contact contact_8)
		{
			if (Class429.smethod_16(ref this.contact_2, contact_8))
			{
				if (contact_8 == this.contact_1)
				{
					this.contact_1 = null;
				}
				Class429.smethod_14(ref this.contact_2, contact_8);
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00087258 File Offset: 0x00085458
		public virtual void vmethod_15(Contact theTarget, bool IgnoreTargetIllumination = true)
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (!this.activeUnit_0.method_82())
					{
						if (!this.activeUnit_0.bool_6 || !((Ship)this.activeUnit_0).method_152())
						{
							if (IgnoreTargetIllumination || !this.activeUnit_0.method_96(theTarget))
							{
								if (theTarget == this.vmethod_3())
								{
									this.vmethod_4(null);
									this.bool_0 = false;
								}
								this.method_54(theTarget);
								if (!Information.IsNothing(this.activeUnit_0))
								{
									if (!this.activeUnit_0.bool_2)
									{
										Side side = this.activeUnit_0.vmethod_7(false);
										ActiveUnit activeUnit = this.activeUnit_0;
										Class316 @class = null;
										side.method_83(ref activeUnit.scenario_0, ref this.activeUnit_0, ref theTarget, ref @class);
									}
									if (!Information.IsNothing(this.activeUnit_0))
									{
										if (!Information.IsNothing(this.activeUnit_0))
										{
											foreach (Sensor sensor in Enumerable.ToArray<Sensor>(this.activeUnit_0.method_78()))
											{
												if (sensor.method_82(ref theTarget))
												{
													sensor.method_84(theTarget, false);
												}
												if (Information.IsNothing(this.activeUnit_0))
												{
													break;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200326", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0000754A File Offset: 0x0000574A
		private void method_54(Contact contact_8)
		{
			if (!Information.IsNothing(contact_8) && this.vmethod_0().ContainsKey(contact_8.string_0))
			{
				this.vmethod_0().Remove(contact_8.string_0);
				Information.IsNothing(this.activeUnit_0);
			}
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x000873E4 File Offset: 0x000855E4
		public bool method_55(ref Contact contact_8)
		{
			bool result;
			try
			{
				foreach (Class316 @class in this.activeUnit_0.vmethod_7(false).class316_0)
				{
					if (@class.bool_12 && @class.contact_0 == contact_8 && @class.method_8() != @class.method_9())
					{
						foreach (Class316.Class273 class2 in Enumerable.ToArray<Class316.Class273>(@class.class273_0))
						{
							if (Operators.CompareString(this.activeUnit_0.string_0, class2.string_0, false) == 0 && class2.int_1 == 0 && class2.bool_0 && class2.int_3 > 0)
							{
								return true;
							}
						}
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101354", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x0000378C File Offset: 0x0000198C
		public virtual void vmethod_16()
		{
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x000874EC File Offset: 0x000856EC
		public virtual void vmethod_17(float float_3, bool bool_11, bool bool_12)
		{
			if (this.bool_10)
			{
				try
				{
					ActiveUnit_AI.Class173 @class = new ActiveUnit_AI.Class173(@class);
					@class.activeUnit_AI_0 = this;
					if (this.activeUnit_0 != null)
					{
						if (this.activeUnit_0.vmethod_101() != null && !this.activeUnit_0.vmethod_101().method_12())
						{
							this.vmethod_4(null);
						}
						else if (this.activeUnit_0.method_86())
						{
							this.vmethod_4(null);
						}
						else if (!this.bool_0 || this.contact_1 != null)
						{
							if (!this.activeUnit_0.bool_2)
							{
								ActiveUnit_AI.TargetingEntry[] array;
								if (this.vmethod_0().Count > 0)
								{
									array = Enumerable.ToArray<ActiveUnit_AI.TargetingEntry>(this.vmethod_0().Values);
								}
								else
								{
									array = new ActiveUnit_AI.TargetingEntry[0];
								}
								List<ActiveUnit_AI.TargetingEntry> list = new List<ActiveUnit_AI.TargetingEntry>();
								if (this.activeUnit_0.bool_6)
								{
									foreach (ActiveUnit_AI.TargetingEntry targetingEntry in array)
									{
										@class.contact_0 = targetingEntry.contact_0;
										if (@class.contact_0.method_108() || @class.contact_0.method_136() || @class.contact_0.method_107())
										{
											list.Add(targetingEntry);
										}
									}
								}
								else if (this.activeUnit_0.bool_5)
								{
									foreach (ActiveUnit_AI.TargetingEntry targetingEntry in array)
									{
										@class.contact_0 = targetingEntry.contact_0;
										if (@class.contact_0.activeUnit_0 != null && !@class.contact_0.activeUnit_0.method_2() && !@class.contact_0.activeUnit_0.bool_7 && (@class.contact_0.method_108() || @class.contact_0.method_136() || (@class.contact_0.method_107() && this.activeUnit_0.vmethod_86().method_73(@class.contact_0))))
										{
											list.Add(targetingEntry);
										}
									}
								}
								else if (this.activeUnit_0.bool_8)
								{
									foreach (ActiveUnit_AI.TargetingEntry targetingEntry in array)
									{
										@class.contact_0 = targetingEntry.contact_0;
										if (@class.contact_0.method_107())
										{
											list.Add(targetingEntry);
										}
									}
								}
								else if (!this.activeUnit_0.method_1())
								{
									list = Enumerable.ToList<ActiveUnit_AI.TargetingEntry>(array);
								}
								if (list.Count == 0)
								{
									this.vmethod_4(null);
								}
								else
								{
									List<Contact> list2 = new List<Contact>();
									try
									{
										foreach (ActiveUnit_AI.TargetingEntry targetingEntry2 in list)
										{
											@class.contact_0 = targetingEntry2.contact_0;
											ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = targetingEntry2.method_1();
											if (targetingBehavior != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
											{
												if (targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted)
												{
													if (this.activeUnit_0.bool_6)
													{
														if (@class.contact_0.method_108() || @class.contact_0.method_136() || @class.contact_0.method_107())
														{
															list2.Add(@class.contact_0);
														}
													}
													else if (this.activeUnit_0.bool_5)
													{
														if (@class.contact_0.method_108() || @class.contact_0.method_136())
														{
															list2.Add(@class.contact_0);
														}
													}
													else if (this.activeUnit_0.bool_8)
													{
														if (@class.contact_0.method_107())
														{
															list2.Add(@class.contact_0);
														}
													}
													else if (!this.activeUnit_0.method_1())
													{
														list2.Add(@class.contact_0);
													}
												}
											}
											else if (this.activeUnit_0.bool_6)
											{
												if ((@class.contact_0.method_108() || @class.contact_0.method_136() || @class.contact_0.method_107()) && this.method_55(ref @class.contact_0))
												{
													list2.Add(@class.contact_0);
												}
											}
											else if (this.activeUnit_0.bool_5)
											{
												if ((@class.contact_0.method_108() || @class.contact_0.method_136()) && this.method_55(ref @class.contact_0))
												{
													list2.Add(@class.contact_0);
												}
											}
											else if (this.activeUnit_0.bool_8)
											{
												if (@class.contact_0.method_107() && this.method_55(ref @class.contact_0))
												{
													list2.Add(@class.contact_0);
												}
											}
											else if (!this.activeUnit_0.method_1() && this.method_55(ref @class.contact_0))
											{
												list2.Add(@class.contact_0);
											}
										}
									}
									finally
									{
										List<ActiveUnit_AI.TargetingEntry>.Enumerator enumerator;
										((IDisposable)enumerator).Dispose();
									}
									if (list2.Count > 0)
									{
										if (list2.Count == 1)
										{
											this.vmethod_4(list2[0]);
										}
										else
										{
											Contact[] array5 = Enumerable.ToArray<Contact>(Enumerable.OrderBy<Contact, float>(Enumerable.Select<Contact, Contact>(list2, (ActiveUnit_AI._Closure$__.$I152-0 == null) ? (ActiveUnit_AI._Closure$__.$I152-0 = new Func<Contact, Contact>(ActiveUnit_AI._Closure$__.$I.method_9)) : ActiveUnit_AI._Closure$__.$I152-0), new Func<Contact, float>(this.method_91)));
											this.vmethod_4(array5[0]);
										}
									}
									else if (this.activeUnit_0.vmethod_101() == null)
									{
										this.vmethod_4(null);
									}
									else
									{
										List<Contact> list3 = Enumerable.ToList<Contact>(Enumerable.Select<ActiveUnit_AI.TargetingEntry, Contact>(list, (ActiveUnit_AI._Closure$__.$I152-2 == null) ? (ActiveUnit_AI._Closure$__.$I152-2 = new Func<ActiveUnit_AI.TargetingEntry, Contact>(ActiveUnit_AI._Closure$__.$I.method_10)) : ActiveUnit_AI._Closure$__.$I152-2));
										if (this.bool_2)
										{
											if (!this.activeUnit_0.bool_6 && !this.activeUnit_0.bool_5)
											{
												List<Contact> list4 = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, float>(Enumerable.Where<Contact>(list3, new Func<Contact, bool>(this.method_92)), new Func<Contact, float>(this.method_93)));
												if (list4.Count > 0)
												{
													this.vmethod_4(list4[0]);
												}
												else
												{
													this.vmethod_4(null);
												}
											}
											else
											{
												Strike strike = (Strike)this.activeUnit_0.vmethod_101();
												List<Contact> list_ = list3;
												Mission mission = strike;
												Mission._GroupSize groupSize = Mission._GroupSize.SingleVessel;
												int int_ = mission.method_51(ref groupSize, ref strike.enum100_1);
												Mission mission2 = strike;
												groupSize = Mission._GroupSize.SingleVessel;
												this.method_56(list_, int_, mission2.method_51(ref groupSize, ref strike.enum100_0), (float)strike.int_9);
											}
										}
										else if (this.activeUnit_0.method_68() && (this.activeUnit_0.bool_6 || this.activeUnit_0.bool_5))
										{
											Class343 class2 = (Class343)this.activeUnit_0.vmethod_101();
											GlobalVariables.PatrolType patrolType_ = ((Class343)this.activeUnit_0.vmethod_101()).patrolType_0;
											if (patrolType_ == GlobalVariables.PatrolType.SEAD)
											{
												this.method_44(list3, (int)class2._FlightQty_2, (float)class2.int_8);
											}
											else if (this.activeUnit_0.bool_6 || this.activeUnit_0.bool_5)
											{
												List<Contact> list_2 = list3;
												Mission mission3 = class2;
												Mission._GroupSize groupSize = Mission._GroupSize.SingleVessel;
												int int_2 = mission3.method_51(ref groupSize, ref class2.enum100_1);
												Mission mission4 = class2;
												groupSize = Mission._GroupSize.SingleVessel;
												this.method_56(list_2, int_2, mission4.method_51(ref groupSize, ref class2.enum100_0), (float)class2.int_9);
											}
										}
										else if (this.activeUnit_0.method_69() && ((Strike)this.activeUnit_0.vmethod_101()).bool_27 && ((Strike)this.activeUnit_0.vmethod_101()).hashSet_0.Count > 0)
										{
											Strike strike2 = (Strike)this.activeUnit_0.vmethod_101();
											if (strike2.hashSet_0.Count > 0)
											{
												List<Tuple<int, Contact>> list5 = new List<Tuple<int, Contact>>();
												int num = 0;
												try
												{
													List<Contact>.Enumerator enumerator2 = list3.GetEnumerator();
													while (enumerator2.MoveNext())
													{
														if (enumerator2.Current.method_92(strike2))
														{
															list5.Add(new Tuple<int, Contact>(num, @class.contact_0));
														}
														num++;
													}
												}
												finally
												{
													List<Contact>.Enumerator enumerator2;
													((IDisposable)enumerator2).Dispose();
												}
												if (list5.Count > 0)
												{
													List<Tuple<int, Contact>> list6 = Enumerable.ToList<Tuple<int, Contact>>(Enumerable.OrderBy<Tuple<int, Contact>, int>(Enumerable.Select<Tuple<int, Contact>, Tuple<int, Contact>>(list5, (ActiveUnit_AI._Closure$__.$I152-5 == null) ? (ActiveUnit_AI._Closure$__.$I152-5 = new Func<Tuple<int, Contact>, Tuple<int, Contact>>(ActiveUnit_AI._Closure$__.$I.method_11)) : ActiveUnit_AI._Closure$__.$I152-5), (ActiveUnit_AI._Closure$__.$I152-6 == null) ? (ActiveUnit_AI._Closure$__.$I152-6 = new Func<Tuple<int, Contact>, int>(ActiveUnit_AI._Closure$__.$I.method_12)) : ActiveUnit_AI._Closure$__.$I152-6));
													this.vmethod_4(list6[0].Item2);
												}
												else
												{
													this.vmethod_4(null);
												}
											}
										}
										else if (this.activeUnit_0.vmethod_90().vmethod_1())
										{
											try
											{
												foreach (Contact contact in list3)
												{
													if (!this.activeUnit_0.vmethod_7(false).dictionary_5.ContainsKey(contact.string_0))
													{
														this.activeUnit_0.vmethod_7(false).dictionary_5.Add(contact.string_0, contact.method_100().Length);
													}
												}
											}
											finally
											{
												List<Contact>.Enumerator enumerator3;
												((IDisposable)enumerator3).Dispose();
											}
											List<IGrouping<int, Contact>> list7 = Enumerable.ToList<IGrouping<int, Contact>>(Enumerable.GroupBy<Contact, int>(Enumerable.Select<Contact, Contact>(list3, (ActiveUnit_AI._Closure$__.$I152-7 == null) ? (ActiveUnit_AI._Closure$__.$I152-7 = new Func<Contact, Contact>(ActiveUnit_AI._Closure$__.$I.method_13)) : ActiveUnit_AI._Closure$__.$I152-7), new Func<Contact, int>(@class.method_0)));
											this.vmethod_4(Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, float>(list7[0], new Func<Contact, float>(@class.method_1)))[0]);
										}
										else
										{
											this.vmethod_4(Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, float>(list3, new Func<Contact, float>(@class.method_2)))[0]);
										}
										List<Contact> list8 = new List<Contact>();
										try
										{
											foreach (Contact contact2 in list3)
											{
												if (Information.IsNothing(this.activeUnit_0))
												{
													return;
												}
												if (Enumerable.Contains<Contact>(this.method_15(), contact2) && this.activeUnit_0.method_37(contact2, 0f) < 10f)
												{
													list8.Add(contact2);
												}
												if (list8.Count == 1)
												{
													this.vmethod_4(list8[0]);
												}
												double num2 = 20000.0;
												try
												{
													foreach (Contact contact3 in list8)
													{
														double num3 = (double)this.activeUnit_0.method_37(contact3, 0f);
														if (num3 < num2)
														{
															this.vmethod_4(contact3);
															num2 = num3;
														}
													}
												}
												finally
												{
													List<Contact>.Enumerator enumerator5;
													((IDisposable)enumerator5).Dispose();
												}
											}
										}
										finally
										{
											List<Contact>.Enumerator enumerator4;
											((IDisposable)enumerator4).Dispose();
										}
										list8 = null;
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100043", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00088000 File Offset: 0x00086200
		public void method_56(List<Contact> list_2, int int_1, int int_2, float float_3)
		{
			try
			{
				ActiveUnit_AI.Class174 @class = new ActiveUnit_AI.Class174(@class);
				@class.activeUnit_AI_0 = this;
				if (this.activeUnit_0 != null)
				{
					if (this.activeUnit_0.vmethod_101() != null)
					{
						List<Contact> list = new List<Contact>();
						if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
						{
							@class.bool_0 = this.method_37();
							try
							{
								foreach (Contact contact in list_2)
								{
									if (contact != null)
									{
										Contact contact_ = contact;
										Mission mission_ = this.activeUnit_0.vmethod_101();
										Doctrine.Enum59? nullable_ = this.activeUnit_0.doctrine_0.method_162(this.activeUnit_0.scenario_0, false, false, false);
										bool bool_ = false;
										bool bool_2 = @class.bool_0;
										bool bool_3 = true;
										Misc.PostureStance? nullable_2 = null;
										string text = "";
										int num = 0;
										if (this.method_39(contact_, mission_, nullable_, bool_, bool_2, bool_3, nullable_2, ref text, ref num) && this.activeUnit_0.vmethod_86().method_73(contact))
										{
											ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
											Contact theTarget = contact;
											bool checkWRA = true;
											Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
											text = "";
											num = 0;
											if (activeUnit_Weaponry.method_6(theTarget, checkWRA, doctrine_, ref text, ref num, null))
											{
												list.Add(contact);
											}
										}
									}
								}
								goto IL_1C7;
							}
							finally
							{
								List<Contact>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
						{
							try
							{
								foreach (Contact contact2 in list_2)
								{
									if (contact2 != null)
									{
										ActiveUnit_Weaponry activeUnit_Weaponry2 = this.activeUnit_0.vmethod_89();
										Contact theTarget2 = contact2;
										bool checkWRA2 = true;
										Doctrine doctrine_2 = this.activeUnit_0.doctrine_0;
										string text = "";
										int num = 0;
										if (activeUnit_Weaponry2.method_6(theTarget2, checkWRA2, doctrine_2, ref text, ref num, null) && this.method_36(contact2))
										{
											list.Add(contact2);
										}
									}
								}
							}
							finally
							{
								List<Contact>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							list = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(list, new Func<Contact, double>(this.method_94)));
						}
						IL_1C7:
						if (list != null && list.Count > 0)
						{
							if (this.activeUnit_0.vmethod_90().vmethod_1())
							{
								if (this.activeUnit_0.method_121())
								{
									this.method_57(list, float_3);
								}
								else
								{
									this.method_58(list, int_1);
								}
							}
							else
							{
								List<Contact> list2 = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(list, new Func<Contact, double>(this.method_95)));
								this.vmethod_4(list2[0]);
							}
						}
						if (list.Count == 0 || (list.Count > 0 && Information.IsNothing(this.vmethod_3())))
						{
							if (this.activeUnit_0.vmethod_90().vmethod_1())
							{
								IEnumerable<Contact> enumerable;
								if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
								{
									enumerable = Enumerable.ToList<Contact>(Enumerable.Where<Contact>(list_2, new Func<Contact, bool>(@class.method_0)));
								}
								else if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
								{
									enumerable = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(Enumerable.Where<Contact>(list_2, new Func<Contact, bool>(this.method_96)), new Func<Contact, double>(this.method_97)));
								}
								if (!Information.IsNothing(enumerable) && Enumerable.Count<Contact>(enumerable) > 0)
								{
									if (this.activeUnit_0.method_121())
									{
										this.method_57(enumerable, float_3);
									}
									else
									{
										this.method_58(enumerable, int_2);
									}
								}
								else
								{
									this.vmethod_4(null);
								}
							}
							else
							{
								List<Contact> list3;
								if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
								{
									list3 = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(Enumerable.Where<Contact>(list_2, new Func<Contact, bool>(@class.method_1)), new Func<Contact, double>(this.method_98)));
								}
								else if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
								{
									list3 = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(Enumerable.Where<Contact>(list_2, new Func<Contact, bool>(this.method_99)), new Func<Contact, double>(this.method_100)));
								}
								if (!Information.IsNothing(list3) && list3.Count > 0)
								{
									this.vmethod_4(list3[0]);
								}
								else
								{
									this.vmethod_4(null);
								}
							}
							if (Information.IsNothing(this.vmethod_3()))
							{
								if (this.activeUnit_0.vmethod_90().vmethod_1())
								{
									IEnumerable<Contact> enumerable2;
									if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
									{
										enumerable2 = Enumerable.ToList<Contact>(Enumerable.Where<Contact>(list_2, new Func<Contact, bool>(@class.method_2)));
									}
									else if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
									{
										enumerable2 = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(Enumerable.Where<Contact>(list_2, new Func<Contact, bool>(this.method_101)), new Func<Contact, double>(this.method_102)));
									}
									if (!Information.IsNothing(enumerable2) && Enumerable.Count<Contact>(enumerable2) > 0)
									{
										if (this.activeUnit_0.method_121())
										{
											this.method_57(enumerable2, float_3);
										}
										else
										{
											this.method_58(enumerable2, int_2);
										}
									}
									else
									{
										this.vmethod_4(null);
									}
								}
								else
								{
									List<Contact> list4;
									if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
									{
										list4 = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(Enumerable.Where<Contact>(list_2, new Func<Contact, bool>(@class.method_3)), new Func<Contact, double>(this.method_103)));
									}
									else if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
									{
										list4 = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(Enumerable.Where<Contact>(list_2, new Func<Contact, bool>(this.method_104)), new Func<Contact, double>(this.method_105)));
									}
									if (!Information.IsNothing(list4) && list4.Count > 0)
									{
										this.vmethod_4(list4[0]);
									}
									else
									{
										this.vmethod_4(null);
									}
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

		// Token: 0x06000818 RID: 2072 RVA: 0x000885D4 File Offset: 0x000867D4
		public void method_57(IEnumerable<Contact> ienumerable_0, float float_3)
		{
			ActiveUnit_AI.Class175 @class = new ActiveUnit_AI.Class175();
			@class.activeUnit_AI_0 = this;
			@class.float_0 = float_3;
			try
			{
				if (@class.float_0 > 0f)
				{
					List<Contact> list = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(ienumerable_0, new Func<Contact, double>(this.method_106)));
					float num = Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), list[0].vmethod_30(null), list[0].vmethod_28(null));
					if (@class.float_0 > num)
					{
						if (!Information.IsNothing(this.activeUnit_0.vmethod_65(false)) && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147().vmethod_86().vmethod_3()) && Enumerable.Contains<Contact>(ienumerable_0, this.activeUnit_0.vmethod_65(false).method_147().vmethod_86().vmethod_3()))
						{
							List<Contact> list2 = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(Enumerable.Where<Contact>(ienumerable_0, new Func<Contact, bool>(@class.method_0)), new Func<Contact, double>(this.method_107)));
							if (list2.Count == 0)
							{
								this.vmethod_4(null);
							}
							else if (list2.Count == 1)
							{
								this.vmethod_4(list2[0]);
							}
							else
							{
								list2.Remove(this.activeUnit_0.vmethod_65(false).method_147().vmethod_86().vmethod_3());
								this.vmethod_4(list2[0]);
							}
						}
						else
						{
							this.vmethod_4(list[0]);
						}
					}
					else
					{
						Weapon weapon = this.activeUnit_0.vmethod_89().method_15(list[0]);
						Contact contact;
						if (Information.IsNothing(weapon))
						{
							contact = null;
						}
						else
						{
							float num2 = weapon.method_181(this.activeUnit_0, list[0], true, this.activeUnit_0.doctrine_0, false);
							if (Math.Max((double)num2 * 1.2, (double)(num2 + 5f)) > (double)Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), list[0].vmethod_30(null), list[0].vmethod_28(null)))
							{
								contact = list[0];
							}
							else
							{
								contact = null;
							}
						}
						if (!Information.IsNothing(contact))
						{
							this.vmethod_4(contact);
						}
						else if (!Information.IsNothing(this.activeUnit_0.vmethod_65(false)) && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147().vmethod_86().vmethod_3()) && (this.activeUnit_0.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive || this.activeUnit_0.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedDefensive) && Enumerable.Contains<Contact>(ienumerable_0, this.activeUnit_0.vmethod_65(false).method_147().vmethod_86().vmethod_3()))
						{
							Contact contact_ = this.activeUnit_0.vmethod_65(false).method_147().vmethod_86().vmethod_3();
							this.vmethod_4(contact_);
						}
						else
						{
							this.vmethod_4(null);
						}
					}
				}
				else if (!Information.IsNothing(this.activeUnit_0.vmethod_65(false)) && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147().vmethod_86().vmethod_3()) && Enumerable.Contains<Contact>(ienumerable_0, this.activeUnit_0.vmethod_65(false).method_147().vmethod_86().vmethod_3()))
				{
					Contact contact_2 = this.activeUnit_0.vmethod_65(false).method_147().vmethod_86().vmethod_3();
					this.vmethod_4(contact_2);
				}
				else
				{
					this.vmethod_4(null);
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

		// Token: 0x06000819 RID: 2073 RVA: 0x00088A60 File Offset: 0x00086C60
		public void method_58(IEnumerable<Contact> ienumerable_0, int int_1)
		{
			try
			{
				int num = Enumerable.Count<Contact>(ienumerable_0);
				double num2 = double.MaxValue;
				double num3 = double.MaxValue;
				double num4 = double.MaxValue;
				Contact contact2;
				Contact contact3;
				Contact contact4;
				for (int i = num - 1; i >= 0; i += -1)
				{
					Contact contact = Enumerable.ElementAtOrDefault<Contact>(ienumerable_0, i);
					int count = contact.method_120(this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_7(false), true, this.activeUnit_0).Count;
					double num5 = this.activeUnit_0.method_31(contact);
					if (count < int_1)
					{
						if (count > 0)
						{
							if (num5 < num3)
							{
								contact2 = contact;
								num3 = num5;
							}
						}
						else if (num5 < num2)
						{
							contact3 = contact;
							num2 = num5;
						}
						if (num5 < num4)
						{
							contact4 = contact;
							num4 = num5;
						}
					}
					else if (this.vmethod_3() != null)
					{
						this.vmethod_4(null);
					}
				}
				Contact contact5;
				if (!Information.IsNothing(contact4))
				{
					Weapon weapon = this.activeUnit_0.vmethod_89().method_15(contact4);
					if (Information.IsNothing(weapon))
					{
						contact5 = null;
					}
					else
					{
						float num6 = weapon.method_181(this.activeUnit_0, contact4, true, this.activeUnit_0.doctrine_0, false);
						if (Math.Max((double)num6 * 1.2, (double)(num6 + 5f)) > (double)Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), contact4.vmethod_30(null), contact4.vmethod_28(null)))
						{
							contact5 = contact4;
						}
						else
						{
							contact5 = null;
						}
					}
				}
				if (!Information.IsNothing(contact5))
				{
					this.vmethod_4(contact5);
				}
				else if (!Information.IsNothing(contact3))
				{
					this.vmethod_4(contact3);
				}
				else if (!Information.IsNothing(contact2))
				{
					this.vmethod_4(contact2);
				}
				else
				{
					this.vmethod_4(null);
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

		// Token: 0x0600081A RID: 2074 RVA: 0x00088C88 File Offset: 0x00086E88
		public virtual void vmethod_18()
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (!this.activeUnit_0.bool_2)
					{
						this.contact_1 = null;
						int num = this.method_15().Length;
						if (num != 0)
						{
							if (num != 1)
							{
								float num2 = 20000f;
								foreach (Contact contact in this.method_15())
								{
									if (contact.vmethod_28(null) != 0.0 && contact.vmethod_30(null) != 0.0 && contact.vmethod_40() != 0f)
									{
										float num3 = this.activeUnit_0.method_39(contact, this.activeUnit_0.vmethod_40(), this.activeUnit_0.vmethod_9());
										if (num3 > 0f)
										{
											float num4 = this.activeUnit_0.method_53(num3, this.method_71(this.activeUnit_0, ref contact));
											if (num4 < num2)
											{
												this.contact_1 = contact;
												num2 = num4;
											}
										}
									}
								}
							}
							else
							{
								this.contact_1 = this.method_15()[0];
							}
						}
						else
						{
							this.contact_1 = null;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100044", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00088E14 File Offset: 0x00087014
		public virtual void vmethod_19(float float_3)
		{
			ActiveUnit_AI.Class176 @class = new ActiveUnit_AI.Class176();
			@class.activeUnit_AI_0 = this;
			@class.float_0 = float_3;
			try
			{
				if (this.vmethod_3() != null)
				{
					if (!this.activeUnit_0.vmethod_85().method_44())
					{
						if (this.vmethod_3().bool_18)
						{
							double num = (double)Math.Abs(Class437.smethod_3(this.vmethod_3().method_32(this.activeUnit_0), this.vmethod_3().vmethod_9()));
							bool flag = num > 60.0 && num < 120.0;
							if (flag)
							{
								this.method_63(@class.float_0, 0f, 0f);
							}
							else
							{
								float float_4 = @class.float_0;
								float? nullable_ = new float?(this.activeUnit_0.vmethod_70());
								bool flag2 = false;
								this.vmethod_21(float_4, nullable_, ref flag2);
							}
						}
						else
						{
							this.method_63(@class.float_0, 0f, 0f);
						}
						if (this.activeUnit_0.vmethod_85().bool_1 && !this.bool_5)
						{
							Task.Factory.StartNew(new Action(@class.method_0));
						}
						if (this.activeUnit_0.method_36(this.vmethod_3()) < 1f && this.vmethod_3().method_112() != null && !this.activeUnit_0.vmethod_89().method_17(this.vmethod_3(), true))
						{
							this.activeUnit_0.vmethod_85().method_52();
							this.activeUnit_0.vmethod_85().vmethod_16(@class.float_0);
						}
					}
					else
					{
						this.activeUnit_0.vmethod_85().vmethod_16(@class.float_0);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100045", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00089004 File Offset: 0x00087204
		private void method_59(float float_3, bool bool_11)
		{
			if (!this.activeUnit_0.vmethod_86().bool_4)
			{
				this.bool_5 = true;
				try
				{
					if (!this.activeUnit_0.vmethod_85().bool_2)
					{
						if (this.activeUnit_0.vmethod_85().vmethod_29(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null), true, 0f, true, null, true, false, true, new float?(Class522.interface9_1.imethod_1())))
						{
							Waypoint[] array = Enumerable.ToArray<Waypoint>(this.activeUnit_0.vmethod_85().method_4());
							if (this.activeUnit_0.vmethod_85().method_44())
							{
								Waypoint waypoint = Enumerable.Last<Waypoint>(Enumerable.Where<Waypoint>(array, (ActiveUnit_AI._Closure$__.$I158-0 == null) ? (ActiveUnit_AI._Closure$__.$I158-0 = new Func<Waypoint, bool>(ActiveUnit_AI._Closure$__.$I.method_14)) : ActiveUnit_AI._Closure$__.$I158-0));
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
						else if (this.activeUnit_0.vmethod_85().method_44())
						{
							this.activeUnit_0.vmethod_85().method_18();
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100046", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				this.bool_5 = false;
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000892E4 File Offset: 0x000874E4
		public virtual bool vmethod_20(double double_4, double double_5, float float_3, float float_4, float float_5, float float_6, float float_7, float? nullable_10, bool bool_11, bool bool_12)
		{
			bool result;
			try
			{
				if (Information.IsNothing(nullable_10))
				{
					nullable_10 = new float?(0.1f);
				}
				float num = this.activeUnit_0.method_25(double_4, double_5);
				if (float.IsNaN(num))
				{
					result = true;
				}
				else
				{
					float num2;
					if (bool_11)
					{
						num2 = float_6;
						if (float_6 <= 0f || double.IsNaN((double)float_6))
						{
							return false;
						}
					}
					else
					{
						if (bool_12)
						{
							num2 = this.activeUnit_0.method_38(double_4, double_5, float_3, float_4, float_6, float_7);
						}
						else
						{
							float float_8 = Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.vmethod_5().vmethod_30(null), this.vmethod_5().vmethod_28(null));
							num2 = this.activeUnit_0.method_38(double_4, double_5, float_3, float_4, float_6, float_8);
						}
						if (num2 <= 0f || double.IsNaN((double)num2))
						{
							return false;
						}
					}
					long num3 = (long)Math.Round((double)(num / num2 * 3600f));
					float? num4 = (float)this.activeUnit_0.vmethod_87().vmethod_36(float_6, float_5, !this.activeUnit_0.bool_3, this.activeUnit_0.bool_3) * (1f + nullable_10);
					float num5 = (float)num3;
					if (((num4 != null) ? new bool?(num4.GetValueOrDefault() > num5) : null).GetValueOrDefault())
					{
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100047", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00089518 File Offset: 0x00087718
		public bool method_60(Unit unit_1, float? nullable_10, float float_3, float float_4, float float_5, float? nullable_11, bool bool_11, bool bool_12, bool bool_13)
		{
			bool result;
			try
			{
				if (Information.IsNothing(nullable_11))
				{
					nullable_11 = new float?(0.1f);
				}
				if (Information.IsNothing(nullable_10))
				{
					nullable_10 = new float?(this.activeUnit_0.method_36(unit_1));
				}
				if (Information.IsNothing(nullable_10))
				{
					result = true;
				}
				else
				{
					float num;
					if (bool_11)
					{
						num = float_4;
						if (float_4 <= 0f || double.IsNaN((double)float_4))
						{
							return false;
						}
					}
					else
					{
						num = this.activeUnit_0.method_39(unit_1, float_4, float_5);
						if (num <= 0f || double.IsNaN((double)num))
						{
							return false;
						}
					}
					long num2 = (long)Math.Round((double)(nullable_10 / num * 3600f).Value);
					float? num3 = (float)this.activeUnit_0.vmethod_87().vmethod_36(float_4, float_3, bool_12, bool_13) * (1f + nullable_11);
					float num4 = (float)num2;
					if (((num3 != null) ? new bool?(num3.GetValueOrDefault() > num4) : null).GetValueOrDefault())
					{
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100047", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0008971C File Offset: 0x0008791C
		public bool method_61(Unit unit_1, float? nullable_10, float float_3, float? nullable_11, float float_4, ActiveUnit.Throttle throttle_0, float? nullable_12, bool bool_11, bool bool_12, ref bool bool_13)
		{
			bool result;
			try
			{
				if (this.activeUnit_0 == null)
				{
					result = false;
				}
				else
				{
					if (nullable_11 == null)
					{
						nullable_11 = new float?((float)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), throttle_0, false));
					}
					result = this.method_60(unit_1, nullable_10, float_3, nullable_11.Value, float_4, nullable_12, bool_11, bool_12, bool_13);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100048", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000897D0 File Offset: 0x000879D0
		public int? method_62(ActiveUnit activeUnit_1)
		{
			int? result;
			try
			{
				int num = this.activeUnit_0.vmethod_87().vmethod_38();
				int num2 = Math.Max(1, (int)Math.Round((double)num / 100.0));
				int num3 = num;
				int num4 = num2;
				int num5 = 1;
				while ((num4 >> 31 ^ num5) <= (num4 >> 31 ^ num3))
				{
					if (ActiveUnit_Navigator.smethod_5(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), (double)this.activeUnit_0.vmethod_9(), activeUnit_1, (float)num5) != null)
					{
						return new int?(num5);
					}
					num5 += num4;
				}
				result = null;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100049", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x000898CC File Offset: 0x00087ACC
		public void method_63(float float_3, float float_4, float float_5)
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0.vmethod_85().method_4()) && Enumerable.Count<Waypoint>(this.activeUnit_0.vmethod_85().method_4()) > 0 && this.activeUnit_0.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.LocalizationRun)
				{
					if (!Information.IsNothing(this.vmethod_3().method_112()))
					{
						return;
					}
					this.activeUnit_0.vmethod_85().method_53(this.activeUnit_0.vmethod_85().method_4()[0], false);
				}
				if (this.vmethod_3().method_104())
				{
					Weapon weapon = this.activeUnit_0.vmethod_89().method_16(this.vmethod_3(), true, true, true, this.activeUnit_0.doctrine_0);
					if (!Information.IsNothing(weapon))
					{
						if (weapon.float_30 > 0f && this.activeUnit_0.method_36(this.vmethod_3()) <= weapon.float_30)
						{
							this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, Math2.smethod_7(this.activeUnit_0.method_32(this.vmethod_3()) + 90f));
							return;
						}
						if (weapon.struct36_0.bool_5 || weapon.struct36_0.bool_4)
						{
							double num;
							double num2;
							Class411.smethod_1(this.vmethod_3().vmethod_28(null), this.vmethod_3().vmethod_30(null), ref num, ref num2, (double)weapon.float_30 + 0.5, (double)Math2.smethod_7(this.vmethod_3().vmethod_9() + 180f));
							this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.method_34(num2, num));
							return;
						}
					}
				}
				float float_6 = Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null));
				this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, float_6);
				if (this.vmethod_3().vmethod_40() <= this.activeUnit_0.vmethod_40() / 2f)
				{
					ActiveUnit_Navigator activeUnit_Navigator = this.activeUnit_0.vmethod_85();
					Waypoint waypoint = null;
					activeUnit_Navigator.vmethod_11(float_3, ref waypoint, this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null), float_4, float_5, this.activeUnit_0.vmethod_87().vmethod_49());
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100050", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00089BB4 File Offset: 0x00087DB4
		public virtual void vmethod_21(float float_3, float? nullable_10, ref bool bool_11)
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
						float num;
						if (nullable_10 != null)
						{
							num = nullable_10.Value;
						}
						else
						{
							num = this.activeUnit_0.vmethod_40();
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
								double num2;
								double num3;
								Class411.smethod_1(this.vmethod_3().vmethod_28(null), this.vmethod_3().vmethod_30(null), ref num2, ref num3, (double)(weapon.float_30 + 1f), (double)Math2.smethod_7(this.vmethod_3().vmethod_9() + 180f));
								this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.method_34(num3, num2));
								return;
							}
						}
						double? num4 = ActiveUnit_Navigator.smethod_5(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), (double)this.activeUnit_0.vmethod_9(), this.vmethod_3(), num);
						if (num4 == null)
						{
							ValueTuple<Geopoint_Struct, TimeSpan> valueTuple = ActiveUnit_Navigator.smethod_4(this.activeUnit_0, num, this.vmethod_3());
							if (!Information.IsNothing(valueTuple))
							{
								num4 = new double?((double)this.activeUnit_0.method_34(valueTuple.Item1.double_1, valueTuple.Item1.double_0));
							}
						}
						if (num4 != null)
						{
							this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, (float)num4.Value);
						}
						else if (this.activeUnit_0.vmethod_40() < this.vmethod_3().vmethod_40())
						{
							if (Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_68(), this.activeUnit_0.method_32(this.vmethod_3()))) > 15f)
							{
								this.method_64(float_3);
							}
							bool_11 = true;
						}
						else
						{
							this.method_64(float_3);
							bool_11 = true;
						}
					}
					else
					{
						this.method_64(float_3);
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

		// Token: 0x06000823 RID: 2083 RVA: 0x00089F1C File Offset: 0x0008811C
		public void method_64(float float_3)
		{
			try
			{
				float num2;
				if (this.activeUnit_0.bool_2)
				{
					float num = this.activeUnit_0.method_36(this.vmethod_3());
					num2 = Math.Min(20f, num / (this.activeUnit_0.vmethod_40() / 3600f));
				}
				else
				{
					num2 = 1f;
				}
				float num3 = Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null));
				if (270f > num3 && num3 > 90f)
				{
					this.method_63(float_3, 0f, 0f);
				}
				else
				{
					float num4 = this.vmethod_3().method_138(this.activeUnit_0);
					if (float.IsNaN(num4))
					{
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, num3);
					}
					else
					{
						string left = this.vmethod_3().method_55(this.activeUnit_0);
						if (Operators.CompareString(left, "Port", false) != 0)
						{
							if (Operators.CompareString(left, "Starboard", false) == 0)
							{
								this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, Math2.smethod_7(num3 + num2 * num4));
							}
						}
						else
						{
							this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, Math2.smethod_7(num3 - num2 * num4));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100053", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0008A0CC File Offset: 0x000882CC
		public bool method_65(Contact contact_8)
		{
			bool result;
			try
			{
				if ((contact_8.contactType_0 != Contact_Base.ContactType.ActivationPoint || contact_8.contactType_0 == Contact_Base.ContactType.Aimpoint) && Information.IsNothing(contact_8.activeUnit_0))
				{
					result = true;
				}
				else
				{
					ActiveUnit activeUnit = contact_8.activeUnit_0;
					if (Information.IsNothing(activeUnit))
					{
						if (contact_8.contactType_0 != Contact_Base.ContactType.Aimpoint)
						{
							if (contact_8.contactType_0 != Contact_Base.ContactType.ActivationPoint)
							{
								return true;
							}
						}
						result = false;
					}
					else if (activeUnit.bool_8 && contact_8.method_74(this.activeUnit_0.vmethod_7(false)) != null && contact_8.method_74(this.activeUnit_0.vmethod_7(false)).Value == Contact.Enum47.const_3 && (activeUnit.vmethod_99().Length > 0 && activeUnit.vmethod_99().Length == Enumerable.Count<AirFacility>(Enumerable.Where<AirFacility>(activeUnit.vmethod_99(), (ActiveUnit_AI._Closure$__.$I167-0 == null) ? (ActiveUnit_AI._Closure$__.$I167-0 = new Func<AirFacility, bool>(ActiveUnit_AI._Closure$__.$I.method_15)) : ActiveUnit_AI._Closure$__.$I167-0))))
					{
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101355", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0008A218 File Offset: 0x00088418
		public virtual void vmethod_22(float float_3)
		{
			try
			{
				if (this.activeUnit_0 != null)
				{
					if (this.method_51(float_3))
					{
						ActiveUnit_AI.Class177 @class = new ActiveUnit_AI.Class177(@class);
						@class.activeUnit_AI_0 = this;
						@class.bool_0 = true;
						if (!Information.IsNothing(this.activeUnit_0.scenario_0.Mines) && this.activeUnit_0.scenario_0.Mines.Count != 0)
						{
							Parallel.ForEach<UnguidedWeapon>(Enumerable.ToArray<UnguidedWeapon>(Enumerable.Where<UnguidedWeapon>(this.activeUnit_0.scenario_0.Mines, new Func<UnguidedWeapon, bool>(this.method_108))), new Action<UnguidedWeapon, ParallelLoopState>(@class.method_0));
						}
						if (@class.bool_0)
						{
							long long_;
							if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Mining)
							{
								long_ = ((Class340)this.activeUnit_0.vmethod_101()).long_0;
							}
							else if (this.activeUnit_0.bool_3)
							{
								long_ = 0L;
							}
							else
							{
								long_ = 3600L;
							}
							this.activeUnit_0.vmethod_89().method_7(float_3, long_);
						}
					}
					if (this.method_12().Length != 0)
					{
						Doctrine.Enum52? @enum = new Doctrine.Enum52?(this.activeUnit_0.doctrine_0.method_63(this.activeUnit_0.scenario_0, false, null, false, false).Value);
						Doctrine.Enum52? enum2 = new Doctrine.Enum52?(this.activeUnit_0.doctrine_0.method_68(this.activeUnit_0.scenario_0, false, null, false, false).Value);
						Doctrine.Enum52? enum3 = new Doctrine.Enum52?(this.activeUnit_0.doctrine_0.method_73(this.activeUnit_0.scenario_0, false, null, false, false).Value);
						Doctrine.Enum52? enum4 = new Doctrine.Enum52?(this.activeUnit_0.doctrine_0.method_78(this.activeUnit_0.scenario_0, false, null, false, false).Value);
						byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								b = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									b = ((enum4 != null) ? new byte?((byte)enum4.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										return;
									}
								}
							}
						}
						ActiveUnit_AI.TargetingEntry[] array = this.method_14();
						bool flag = true;
						if (!Information.IsNothing(this.nullable_6))
						{
							float? num = this.nullable_6;
							if (((num != null) ? new bool?(num.GetValueOrDefault() < 15f) : null).GetValueOrDefault())
							{
								flag = false;
							}
							else if (!Information.IsNothing(this.activeUnit_0.vmethod_89().method_54()))
							{
								num = this.nullable_6;
								double? num2 = (num != null) ? new double?((double)num.GetValueOrDefault()) : null;
								double num3 = (double)this.activeUnit_0.vmethod_89().method_54().float_29 * 1.5;
								if (((num2 != null) ? new bool?(num2.GetValueOrDefault() < num3) : null).GetValueOrDefault())
								{
									flag = false;
								}
							}
						}
						bool flag2 = true;
						if (!Information.IsNothing(this.nullable_7))
						{
							float? num = this.nullable_7;
							if (((num != null) ? new bool?(num.GetValueOrDefault() < 15f) : null).GetValueOrDefault())
							{
								flag2 = false;
							}
							else
							{
								Weapon weapon = this.activeUnit_0.vmethod_89().method_55(false);
								bool? flag3;
								if (Information.IsNothing(weapon))
								{
									flag3 = new bool?(false);
								}
								else if (!weapon.bool_7)
								{
									num = this.nullable_7;
									double? num2 = (num != null) ? new double?((double)num.GetValueOrDefault()) : null;
									double num3 = (double)weapon.float_31 * 1.2;
									flag3 = ((num2 != null) ? new bool?(num2.GetValueOrDefault() < num3) : null);
								}
								else
								{
									flag3 = new bool?(true);
								}
								bool? flag4 = flag3;
								if (flag4.GetValueOrDefault())
								{
									flag2 = false;
								}
							}
						}
						bool flag5 = true;
						if (!Information.IsNothing(this.nullable_9))
						{
							float? num = this.nullable_9;
							if (((num != null) ? new bool?(num.GetValueOrDefault() < 15f) : null).GetValueOrDefault())
							{
								flag5 = false;
							}
							else if (!Information.IsNothing(this.activeUnit_0.vmethod_89().method_56(false)))
							{
								num = this.nullable_9;
								double? num2 = (num != null) ? new double?((double)num.GetValueOrDefault()) : null;
								double num3 = (double)this.activeUnit_0.vmethod_89().method_56(false).float_33 * 1.2;
								if (((num2 != null) ? new bool?(num2.GetValueOrDefault() < num3) : null).GetValueOrDefault())
								{
									flag5 = false;
								}
							}
						}
						foreach (ActiveUnit_AI.TargetingEntry targetingEntry in array)
						{
							Contact contact = targetingEntry.contact_0;
							ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = targetingEntry.method_1();
							if (targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted || targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted)
							{
								if (contact.method_103())
								{
									if (flag)
									{
										goto IL_A77;
									}
									b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										goto IL_A77;
									}
								}
								else if (contact.method_108())
								{
									if (flag2)
									{
										goto IL_A77;
									}
									b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										goto IL_A77;
									}
								}
								else if (contact.method_136())
								{
									b = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										goto IL_A77;
									}
								}
								else if (contact.method_135())
								{
									if (flag5)
									{
										goto IL_A77;
									}
									b = ((enum4 != null) ? new byte?((byte)enum4.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										goto IL_A77;
									}
								}
								Misc.PostureStance postureStance;
								if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(contact.string_0, out postureStance))
								{
									postureStance = contact.method_130(this.activeUnit_0.vmethod_7(false));
								}
								if (postureStance != Misc.PostureStance.Hostile)
								{
									if (contact.method_103())
									{
										b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
										bool? flag4 = (b != null) ? new bool?(b.GetValueOrDefault() == 0) : null;
										if (((flag4 != null) ? new bool?(!flag4.GetValueOrDefault()) : flag4).GetValueOrDefault())
										{
											goto IL_A77;
										}
									}
									else if (contact.method_108())
									{
										b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
										bool? flag4 = (b != null) ? new bool?(b.GetValueOrDefault() == 0) : null;
										if (((flag4 != null) ? new bool?(!flag4.GetValueOrDefault()) : flag4).GetValueOrDefault())
										{
											goto IL_A77;
										}
									}
									else if (contact.method_136())
									{
										if (contact.contactType_0 != Contact_Base.ContactType.Torpedo)
										{
											b = ((enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null);
											bool? flag4 = (b != null) ? new bool?(b.GetValueOrDefault() == 0) : null;
											if (((flag4 != null) ? new bool?(!flag4.GetValueOrDefault()) : flag4).GetValueOrDefault())
											{
												goto IL_A77;
											}
										}
									}
									else
									{
										b = ((enum4 != null) ? new byte?((byte)enum4.GetValueOrDefault()) : null);
										bool? flag4 = (b != null) ? new bool?(b.GetValueOrDefault() == 0) : null;
										if (((flag4 != null) ? new bool?(!flag4.GetValueOrDefault()) : flag4).GetValueOrDefault())
										{
											goto IL_A77;
										}
									}
								}
								Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets;
								if (this.method_73(contact) && this.activeUnit_0.vmethod_89().method_11(contact, 0, 0, false, ref gunStrafeGroundTargets, DateTime.MinValue))
								{
									break;
								}
							}
							IL_A77:;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100054", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0008AD04 File Offset: 0x00088F04
		private ActiveUnit_AI.TargetingEntry[] method_66(ObservableDictionary<string, ActiveUnit_AI.TargetingEntry> observableDictionary_1)
		{
			ActiveUnit_AI.TargetingEntry[] result;
			if (this.activeUnit_0 != null && observableDictionary_1.Count != 0)
			{
				if (observableDictionary_1.Count == 1)
				{
					result = new ActiveUnit_AI.TargetingEntry[]
					{
						Enumerable.ElementAtOrDefault<ActiveUnit_AI.TargetingEntry>(observableDictionary_1.Values, 0)
					};
				}
				else
				{
					result = Enumerable.ToArray<ActiveUnit_AI.TargetingEntry>(Enumerable.OrderBy<ActiveUnit_AI.TargetingEntry, float>(Enumerable.Select<ActiveUnit_AI.TargetingEntry, ActiveUnit_AI.TargetingEntry>(observableDictionary_1.Values, (ActiveUnit_AI._Closure$__.$I169-0 == null) ? (ActiveUnit_AI._Closure$__.$I169-0 = new Func<ActiveUnit_AI.TargetingEntry, ActiveUnit_AI.TargetingEntry>(ActiveUnit_AI._Closure$__.$I.method_16)) : ActiveUnit_AI._Closure$__.$I169-0), new Func<ActiveUnit_AI.TargetingEntry, float>(this.method_109)));
				}
			}
			else
			{
				result = new ActiveUnit_AI.TargetingEntry[0];
			}
			return result;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0000710A File Offset: 0x0000530A
		public virtual void vmethod_23(float float_3)
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0008AD94 File Offset: 0x00088F94
		public float method_67(ref Contact contact_8)
		{
			float result;
			try
			{
				float num = contact_8.vmethod_9();
				float num2 = Math2.smethod_17(contact_8.vmethod_30(null), contact_8.vmethod_28(null), this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null));
				num2 = Math2.smethod_7(num2 - num);
				if (num2 > 180f)
				{
					result = -(360f - num2);
				}
				else
				{
					result = num2;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100056", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0008AE6C File Offset: 0x0008906C
		public float method_68(Unit unit_1)
		{
			return Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), unit_1.vmethod_30(null), unit_1.vmethod_28(null));
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0008AEC4 File Offset: 0x000890C4
		public bool method_69(ref Weapon weapon_0)
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
					if ((weapon_0.method_205() && weapon_0.method_225()) || weapon_0.method_227())
					{
						foreach (Contact contact in this.method_12())
						{
							if (contact != null && contact.activeUnit_0 != null && this.vmethod_3() != null && this.vmethod_3().activeUnit_0 != null && Operators.CompareString(contact.activeUnit_0.string_0, this.vmethod_3().activeUnit_0.string_0, false) == 0)
							{
								return true;
							}
						}
					}
					if (weapon_0.method_179() != null)
					{
						if (weapon_0.method_199() && this.vmethod_3().method_105() && weapon_0.method_226())
						{
							if (weapon_0.method_179().vmethod_88().method_1(weapon_0.vmethod_142().vmethod_3(), 5f, ActiveUnit_Sensory.Enum34.const_1))
							{
								result = true;
							}
							else
							{
								result = false;
							}
						}
						else
						{
							result = true;
						}
					}
					else
					{
						Weapon.WeaponGuidanceType weaponGuidanceType = weapon_0.method_169();
						if ((weaponGuidanceType <= Weapon.WeaponGuidanceType.Datalink_Plus_SemiActive || weaponGuidanceType - Weapon.WeaponGuidanceType.SemiActive_Plus_Active <= 1) && weapon_0.method_177() != null)
						{
							ActiveUnit_Sensory activeUnit_Sensory = weapon_0.method_177().vmethod_88();
							Contact contact2 = weapon_0.vmethod_142().vmethod_3();
							Weapon weapon_ = weapon_0;
							Sensor sensor = null;
							bool? flag = null;
							bool? flag2 = null;
							Unit.Enum123? @enum = null;
							bool? flag3 = null;
							if (activeUnit_Sensory.method_41(contact2, weapon_, ref sensor, ref flag, ref flag2, ref @enum, ref flag3))
							{
								return true;
							}
						}
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100057", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0008B090 File Offset: 0x00089290
		public float method_70(Unit unit_1)
		{
			float result;
			try
			{
				float num = unit_1.method_48(1f);
				float num2 = this.activeUnit_0.method_48(1f);
				double num3;
				double num4;
				Class411.smethod_1(unit_1.vmethod_28(null), unit_1.vmethod_30(null), ref num3, ref num4, (double)num, (double)unit_1.vmethod_9());
				float num5 = Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), num4, num3);
				double num6;
				double num7;
				Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref num6, ref num7, (double)num2, (double)num5);
				result = Math2.smethod_17(num7, num6, num4, num3);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100058", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0008B1B8 File Offset: 0x000893B8
		public float method_71(Unit unit_1, ref Contact contact_8)
		{
			return Math2.smethod_15(unit_1.vmethod_30(null), unit_1.vmethod_28(null), contact_8.vmethod_30(null), contact_8.vmethod_28(null));
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0008B208 File Offset: 0x00089408
		public void method_72(ref int int_1)
		{
			try
			{
				float num = (float)Math2.smethod_8(int_1 + 180);
				if (this.activeUnit_0.bool_6 || this.activeUnit_0.bool_5)
				{
					float num2 = 2f;
					bool flag = false;
					int num3 = 0;
					while (!flag && num3 < 72)
					{
						num3++;
						double double_;
						double double_2;
						Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref double_, ref double_2, (double)num2, (double)num);
						if (this.activeUnit_0.vmethod_85().vmethod_29(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), double_2, double_, true, 0f, false, null, true, false, true, new float?(Class522.interface9_1.imethod_1())))
						{
							num += 5f;
						}
						else
						{
							flag = true;
						}
					}
				}
				this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, num);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100061", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0008B370 File Offset: 0x00089570
		public bool method_73(Contact contact_8)
		{
			bool result;
			if (Information.IsNothing(this.activeUnit_0))
			{
				result = false;
			}
			else
			{
				try
				{
					Misc.PostureStance postureStance;
					if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(contact_8.string_0, out postureStance))
					{
						postureStance = contact_8.method_130(this.activeUnit_0.vmethod_7(false));
					}
					if (contact_8.contactType_0 != Contact_Base.ContactType.Aimpoint)
					{
						if (contact_8.contactType_0 != Contact_Base.ContactType.ActivationPoint)
						{
							if (this.method_20(contact_8) == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted)
							{
								return true;
							}
							if (postureStance == Misc.PostureStance.Hostile)
							{
								if (contact_8.method_103())
								{
									Doctrine.Enum52? @enum = this.activeUnit_0.doctrine_0.method_63(this.activeUnit_0.scenario_0, false, null, false, false);
									byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										return false;
									}
								}
								else if (contact_8.method_108())
								{
									Doctrine.Enum52? @enum = this.activeUnit_0.doctrine_0.method_68(this.activeUnit_0.scenario_0, false, null, false, false);
									byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										return false;
									}
								}
								else if (contact_8.method_136())
								{
									Doctrine.Enum52? @enum = this.activeUnit_0.doctrine_0.method_73(this.activeUnit_0.scenario_0, false, null, false, false);
									byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										return false;
									}
								}
								else
								{
									Doctrine.Enum52? @enum = this.activeUnit_0.doctrine_0.method_78(this.activeUnit_0.scenario_0, false, null, false, false);
									byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										return false;
									}
								}
								return true;
							}
							if (postureStance == Misc.PostureStance.Unknown || postureStance == Misc.PostureStance.Unfriendly)
							{
								if (contact_8.method_103())
								{
									Doctrine.Enum52? @enum = this.activeUnit_0.doctrine_0.method_63(this.activeUnit_0.scenario_0, false, null, false, false);
									byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										return true;
									}
								}
								else if (contact_8.method_108())
								{
									Doctrine.Enum52? @enum = this.activeUnit_0.doctrine_0.method_68(this.activeUnit_0.scenario_0, false, null, false, false);
									byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										return true;
									}
								}
								else if (contact_8.method_136())
								{
									if (contact_8.contactType_0 == Contact_Base.ContactType.Torpedo)
									{
										return true;
									}
									Doctrine.Enum52? @enum = this.activeUnit_0.doctrine_0.method_73(this.activeUnit_0.scenario_0, false, null, false, false);
									byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										return true;
									}
								}
								else
								{
									Doctrine.Enum52? @enum = this.activeUnit_0.doctrine_0.method_78(this.activeUnit_0.scenario_0, false, null, false, false);
									byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										return true;
									}
								}
							}
							if (this.activeUnit_0.vmethod_7(false).method_75(ref this.activeUnit_0, ref contact_8) > 0)
							{
								return true;
							}
							return false;
						}
					}
					result = true;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100062", "");
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

		// Token: 0x0600082F RID: 2095 RVA: 0x0008B8F4 File Offset: 0x00089AF4
		public virtual void vmethod_24(float float_3, ref Weapon weapon_0)
		{
			try
			{
				ActiveUnit_AI.Class178 @class = new ActiveUnit_AI.Class178();
				@class.activeUnit_AI_0 = this;
				if (!Information.IsNothing(this.vmethod_3()))
				{
					@class.doctrine_0 = this.activeUnit_0.doctrine_0;
					if (Information.IsNothing(weapon_0))
					{
						Side side = this.activeUnit_0.vmethod_7(false);
						Contact contact_ = this.vmethod_3();
						List<Weapon> list = side.method_74(ref this.activeUnit_0, ref contact_);
						this.vmethod_4(contact_);
						List<Weapon> list2 = list;
						if (list2.Count > 0)
						{
							weapon_0 = Enumerable.ElementAtOrDefault<Weapon>(Enumerable.OrderByDescending<Weapon, float>(list2, new Func<Weapon, float>(@class.method_0)), 0);
						}
						else
						{
							weapon_0 = this.activeUnit_0.vmethod_89().method_16(this.vmethod_3(), false, false, true, @class.doctrine_0);
						}
					}
					if (!Information.IsNothing(weapon_0))
					{
						float num = weapon_0.method_181(this.activeUnit_0, this.vmethod_3(), true, @class.doctrine_0, false);
						float float_4;
						if (this.vmethod_3().vmethod_40() == 0f)
						{
							float_4 = this.activeUnit_0.vmethod_40();
						}
						else
						{
							float_4 = this.activeUnit_0.method_39(this.vmethod_3(), this.activeUnit_0.vmethod_40(), this.activeUnit_0.vmethod_9());
						}
						Weapon._WeaponType weaponType = weapon_0.method_167();
						float num2;
						if (weaponType != Weapon._WeaponType.Rocket)
						{
							if (weaponType != Weapon._WeaponType.Gun)
							{
								num2 = weapon_0.float_40;
								goto IL_188;
							}
						}
						if (this.activeUnit_0.method_37(this.vmethod_3(), 0f) > num)
						{
							num2 = (float)(Math.Sqrt(2.0) / 2.0 * (double)num * 1852.0);
						}
						IL_188:
						float num3;
						if (num2 < this.activeUnit_0.vmethod_72())
						{
							num3 = (this.activeUnit_0.vmethod_72() - num2) / this.activeUnit_0.vmethod_87().vmethod_21();
						}
						if (weapon_0.float_39 > this.activeUnit_0.vmethod_72())
						{
							num3 = (weapon_0.float_39 - this.activeUnit_0.vmethod_72()) / this.activeUnit_0.vmethod_87().vmethod_14(true);
						}
						float num4 = this.activeUnit_0.method_36(this.vmethod_3());
						float num5;
						if (num4 > num)
						{
							float float_5 = num4 - num;
							num5 = this.activeUnit_0.method_53(float_4, float_5);
						}
						else
						{
							num5 = 0f;
						}
						if (num5 >= 0f)
						{
							if (!this.activeUnit_0.vmethod_87().vmethod_12())
							{
								bool flag = false;
								if (num3 >= num5)
								{
									if (num2 < this.activeUnit_0.vmethod_72())
									{
										this.activeUnit_0.vmethod_73(num2 - 100f);
										flag = true;
									}
									if (weapon_0.float_39 > this.activeUnit_0.vmethod_72())
									{
										this.activeUnit_0.vmethod_73(weapon_0.float_39 + 100f);
										flag = true;
									}
									if (!flag)
									{
										this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_72());
									}
								}
							}
							if ((double)num * 1.2 < (double)num4)
							{
								this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
							}
							else
							{
								if (weapon_0.int_17 != 0 && (float)weapon_0.int_17 < this.activeUnit_0.vmethod_40())
								{
									this.activeUnit_0.vmethod_71((float)(weapon_0.int_17 - 10));
								}
								if (weapon_0.int_18 != 0 && (float)weapon_0.int_18 > this.activeUnit_0.vmethod_40())
								{
									this.activeUnit_0.vmethod_71((float)(weapon_0.int_18 + 10));
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100063", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0008BCA4 File Offset: 0x00089EA4
		public void method_74(int int_1)
		{
			try
			{
				int num = (int)Math.Round((double)this.activeUnit_0.vmethod_9());
				int num2 = 0;
				int num3 = 0;
				int num4 = num;
				while (!Class437.smethod_5(num4, int_1))
				{
					num4 = Math2.smethod_8(num4 - 1);
					num2++;
				}
				int num5 = num;
				while (!Class437.smethod_5(num5, int_1))
				{
					num5 = Math2.smethod_8(num5 + 1);
					num3++;
				}
				if (num2 < num3)
				{
					this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, (float)num4);
				}
				else
				{
					this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, (float)num5);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100064", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0000378C File Offset: 0x0000198C
		public virtual void vmethod_25()
		{
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0008BD6C File Offset: 0x00089F6C
		protected void method_75(UnguidedWeapon unguidedWeapon_0, float float_3)
		{
			try
			{
				if (this.activeUnit_0.vmethod_95().Count != 0)
				{
					if (float_3 * 1852f < 20f)
					{
						try
						{
							foreach (Sensor sensor in this.activeUnit_0.vmethod_95())
							{
								if (sensor.method_66() && sensor.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
								{
									this.activeUnit_0.method_106(unguidedWeapon_0, sensor);
									return;
								}
							}
						}
						finally
						{
							List<Sensor>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					GeoPoint geoPoint = new GeoPoint();
					if ((double)float_3 > 0.6)
					{
						double num = this.activeUnit_0.vmethod_28(null);
						double num2 = this.activeUnit_0.vmethod_30(null);
						GeoPoint geoPoint2;
						double num3 = (geoPoint2 = geoPoint).imethod_0();
						GeoPoint geoPoint3;
						double num4 = (geoPoint3 = geoPoint).imethod_2();
						Class411.smethod_1(num, num2, ref num3, ref num4, (double)(float_3 / 2f), (double)Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), unguidedWeapon_0.vmethod_30(null), unguidedWeapon_0.vmethod_28(null)));
						geoPoint3.imethod_3(num4);
						geoPoint2.imethod_1(num3);
						if (this.activeUnit_0.vmethod_85().method_47())
						{
							this.activeUnit_0.vmethod_85().method_4()[0].imethod_3(geoPoint.imethod_2());
							this.activeUnit_0.vmethod_85().method_4()[0].imethod_1(geoPoint.imethod_0());
						}
						else
						{
							this.activeUnit_0.vmethod_85().method_50(new Waypoint(geoPoint.imethod_0(), geoPoint.imethod_2(), geoPoint.imethod_4(), Waypoint.WaypointType.PatrolStation, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0));
						}
					}
					else
					{
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), unguidedWeapon_0.vmethod_30(null), unguidedWeapon_0.vmethod_28(null)));
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100065", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0008C004 File Offset: 0x0008A204
		protected void method_76(UnguidedWeapon unguidedWeapon_0, float float_3)
		{
			try
			{
				if (this.activeUnit_0.vmethod_95().Count != 0)
				{
					if ((double)float_3 >= 0.5 || !this.activeUnit_0.vmethod_85().method_47())
					{
						Sensor sensor = this.activeUnit_0.vmethod_95()[0];
						if (Information.IsNothing(sensor.method_60()))
						{
							if (!this.activeUnit_0.vmethod_85().method_47() && !Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.MineClearing)
							{
								this.activeUnit_0.vmethod_85().vmethod_22(((Class341)this.activeUnit_0.vmethod_101()).list_5);
							}
						}
						else
						{
							Geopoint_Struct geopoint_Struct = Misc.smethod_47(sensor.method_60());
							float num;
							if (this.activeUnit_0.bool_3)
							{
								num = 0f;
							}
							else
							{
								num = Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_9(), Math2.smethod_17(geopoint_Struct.double_1, geopoint_Struct.double_0, this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null)))) + 15f;
							}
							float num2 = (float)((double)Math2.smethod_15(geopoint_Struct.double_1, geopoint_Struct.double_0, this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null)) + 0.1);
							if (this.activeUnit_0.bool_3)
							{
								num2 *= 4f;
							}
							GeoPoint geoPoint = new GeoPoint();
							double num3 = unguidedWeapon_0.vmethod_28(null);
							double num4 = unguidedWeapon_0.vmethod_30(null);
							GeoPoint geoPoint2;
							double num5 = (geoPoint2 = geoPoint).imethod_0();
							GeoPoint geoPoint3;
							double num6 = (geoPoint3 = geoPoint).imethod_2();
							Class411.smethod_1(num3, num4, ref num5, ref num6, (double)num2, (double)Math2.smethod_7(num + Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), unguidedWeapon_0.vmethod_30(null), unguidedWeapon_0.vmethod_28(null))));
							geoPoint3.imethod_3(num6);
							geoPoint2.imethod_1(num5);
							if (this.activeUnit_0.vmethod_85().method_47())
							{
								this.activeUnit_0.vmethod_85().method_4()[0].imethod_3(geoPoint.imethod_2());
								this.activeUnit_0.vmethod_85().method_4()[0].imethod_1(geoPoint.imethod_0());
							}
							else
							{
								this.activeUnit_0.vmethod_85().method_50(new Waypoint(geoPoint.imethod_0(), geoPoint.imethod_2(), 0f, Waypoint.WaypointType.PatrolStation, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0));
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100066", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0008C328 File Offset: 0x0008A528
		public bool method_77()
		{
			bool result;
			try
			{
				if (Information.IsNothing(this.activeUnit_0))
				{
					result = false;
				}
				else if (!this.activeUnit_0.method_122())
				{
					result = false;
				}
				else if (!this.activeUnit_0.vmethod_65(false).method_145().method_17())
				{
					result = false;
				}
				else if (this.activeUnit_0.vmethod_65(false).method_143() != Group.GroupType.SurfaceGroup)
				{
					result = false;
				}
				else
				{
					IEnumerable<ActiveUnit> enumerable = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(this.activeUnit_0.vmethod_65(false).vmethod_141().Values, new Func<ActiveUnit, bool>(this.method_110)));
					for (int i = Enumerable.Count<ActiveUnit>(enumerable) - 1; i >= 0; i += -1)
					{
						ActiveUnit activeUnit = Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable, i);
						if (!activeUnit.vmethod_85().vmethod_3() && !activeUnit.vmethod_85().vmethod_20())
						{
							return true;
						}
					}
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200356", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0008C450 File Offset: 0x0008A650
		public virtual void vmethod_26(float float_3)
		{
			try
			{
				if (!this.activeUnit_0.method_1())
				{
					if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedDefensive && (this.activeUnit_0.bool_3 || this.activeUnit_0.bool_6 || this.activeUnit_0.bool_5))
					{
						this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
						this.vmethod_23(float_3);
					}
					else
					{
						if (this.activeUnit_0.vmethod_85().method_46())
						{
							Doctrine.Enum64? @enum = this.activeUnit_0.doctrine_0.method_83(this.activeUnit_0.scenario_0, false, null, false, false);
							byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								this.activeUnit_0.vmethod_85().vmethod_16(float_3);
								return;
							}
						}
						if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.WaitForPathfinder)
						{
							this.activeUnit_0.vmethod_71(0f);
							this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.FullStop, new float?(0f));
						}
						else
						{
							if (this.activeUnit_0.method_85())
							{
								if (((Aircraft)this.activeUnit_0).method_157().method_76(((Aircraft)this.activeUnit_0).method_164().method_32(true)))
								{
									if (!Enumerable.Contains<Aircraft>(((Aircraft)this.activeUnit_0).method_164().method_32(true).vmethod_92().method_4(), (Aircraft)this.activeUnit_0))
									{
										((Aircraft)this.activeUnit_0).method_164().method_32(true).vmethod_92().method_7((Aircraft)this.activeUnit_0);
									}
									((Aircraft)this.activeUnit_0).method_159().vmethod_27(float_3, false, false);
								}
								else
								{
									Class211 @class = ((Aircraft)this.activeUnit_0).method_157();
									ActiveUnit activeUnit_ = ((Aircraft)this.activeUnit_0).method_164().method_32(true);
									float float_4 = (float)this.activeUnit_0.vmethod_87().vmethod_40(((Aircraft)this.activeUnit_0).vmethod_14(false), ActiveUnit.Throttle.Cruise, false);
									Class211 class2 = ((Aircraft)this.activeUnit_0).method_157();
									ActiveUnit activeUnit;
									ActiveUnit activeUnit2;
									bool bool_ = (activeUnit = this.activeUnit_0).vmethod_76(activeUnit2 = this.activeUnit_0);
									float float_5 = class2.method_73(ref bool_);
									activeUnit.vmethod_77(activeUnit2, bool_);
									ActiveUnit activeUnit3;
									ActiveUnit activeUnit4;
									bool bool_2 = (activeUnit3 = this.activeUnit_0).vmethod_76(activeUnit4 = this.activeUnit_0);
									@class.method_78(float_3, activeUnit_, float_4, float_5, ref bool_2);
									activeUnit3.vmethod_77(activeUnit4, bool_2);
								}
							}
							if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
							{
								if (!Information.IsNothing(this.vmethod_3()))
								{
									Contact_Base.ContactType contactType = this.vmethod_3().contactType_0;
									if (contactType <= Contact_Base.ContactType.Missile)
									{
										this.activeUnit_0.vmethod_71(0f);
									}
									else
									{
										if (this.activeUnit_0.vmethod_84() < ActiveUnit.Throttle.Full)
										{
											this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Full, null);
										}
										this.vmethod_19(float_3);
										Weapon weapon = null;
										this.vmethod_24(float_3, ref weapon);
									}
								}
							}
							else if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.OnPlottedCourse)
							{
								this.activeUnit_0.vmethod_85().vmethod_16(float_3);
								if (this.activeUnit_0.method_122())
								{
									this.activeUnit_0.vmethod_71(this.activeUnit_0.vmethod_65(false).vmethod_70());
								}
							}
							else
							{
								if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.OnPatrol)
								{
									Class343 class3 = (Class343)this.activeUnit_0.vmethod_101();
									if (Information.IsNothing(class3))
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
										if (this.activeUnit_0.bool_5 && !this.activeUnit_0.vmethod_87().vmethod_12())
										{
											if (this.activeUnit_0.vmethod_65(false).vmethod_85().method_37(ref class3.list_5, ref class3.list_11, ref class3.list_7, 2f, false))
											{
												if (class3.imethod_26().Value < 0f)
												{
													this.activeUnit_0.vmethod_73(class3.imethod_26().Value);
												}
											}
											else if (class3.imethod_28().Value < 0f)
											{
												this.activeUnit_0.vmethod_73(class3.imethod_28().Value);
											}
										}
									}
									else
									{
										if (!this.activeUnit_0.method_120())
										{
											if (this.activeUnit_0.vmethod_85().method_46())
											{
												if (!this.activeUnit_0.vmethod_85().method_37(ref class3.list_5, ref class3.list_14, ref class3.list_10, 30f, false))
												{
													this.activeUnit_0.vmethod_85().vmethod_23(float_3, false);
												}
												this.activeUnit_0.vmethod_85().vmethod_16(float_3);
											}
											else
											{
												this.activeUnit_0.vmethod_85().vmethod_23(float_3, false);
											}
											return;
										}
										if (this.activeUnit_0.method_122())
										{
											if (this.activeUnit_0.vmethod_85().method_46())
											{
												if (!this.activeUnit_0.vmethod_65(false).vmethod_85().method_37(ref class3.list_5, ref class3.list_14, ref class3.list_10, 30f, false))
												{
													this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_23(float_3, false);
												}
												this.activeUnit_0.vmethod_85().vmethod_16(float_3);
											}
											else
											{
												this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_23(float_3, false);
											}
											return;
										}
										this.activeUnit_0.vmethod_85().vmethod_21(float_3);
										return;
									}
								}
								if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.OnSupportMission)
								{
									if (Information.IsNothing(this.activeUnit_0.vmethod_101()))
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
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
								if (this.activeUnit_0.method_120() && this.activeUnit_0.vmethod_90().vmethod_1())
								{
									this.activeUnit_0.vmethod_85().vmethod_21(float_3);
								}
								else if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.Unassigned)
								{
									this.activeUnit_0.vmethod_71(0f);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100068", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0008CB80 File Offset: 0x0008AD80
		public virtual void vmethod_27()
		{
			if (this.activeUnit_0 != null && this.activeUnit_0.vmethod_87().vmethod_12())
			{
				switch (((Aircraft)this.activeUnit_0).method_158().method_114())
				{
				case ActiveUnit_AI.AircraftAltitudePreset.None:
					break;
				case ActiveUnit_AI.AircraftAltitudePreset.MinAltitude:
					if (this.activeUnit_0.vmethod_76(this.activeUnit_0))
					{
						this.activeUnit_0.vmethod_75(0f);
						return;
					}
					this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_87().vmethod_31());
					return;
				case ActiveUnit_AI.AircraftAltitudePreset.Low1000:
					if (this.activeUnit_0.vmethod_76(this.activeUnit_0))
					{
						this.activeUnit_0.vmethod_75(304.8f);
						return;
					}
					this.activeUnit_0.vmethod_73(304.8f);
					return;
				case ActiveUnit_AI.AircraftAltitudePreset.Low2000:
					if (this.activeUnit_0.vmethod_76(this.activeUnit_0))
					{
						this.activeUnit_0.vmethod_75(609.6f);
						return;
					}
					this.activeUnit_0.vmethod_73(609.6f);
					return;
				case ActiveUnit_AI.AircraftAltitudePreset.Medium12000:
					if (this.activeUnit_0.vmethod_76(this.activeUnit_0))
					{
						this.activeUnit_0.vmethod_75(3657.6f);
						return;
					}
					this.activeUnit_0.vmethod_73(3657.6f);
					return;
				case ActiveUnit_AI.AircraftAltitudePreset.High25000:
					if (this.activeUnit_0.vmethod_76(this.activeUnit_0))
					{
						this.activeUnit_0.vmethod_75(7620f);
						return;
					}
					this.activeUnit_0.vmethod_73(7620f);
					return;
				case ActiveUnit_AI.AircraftAltitudePreset.High36000:
					if (this.activeUnit_0.vmethod_76(this.activeUnit_0))
					{
						this.activeUnit_0.vmethod_75(10972.8f);
						return;
					}
					this.activeUnit_0.vmethod_73(10972.8f);
					return;
				case ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude:
					if (this.activeUnit_0.vmethod_76(this.activeUnit_0))
					{
						this.activeUnit_0.vmethod_75(this.activeUnit_0.vmethod_87().vmethod_30());
						return;
					}
					this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_87().vmethod_30());
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0008CD80 File Offset: 0x0008AF80
		public bool method_78()
		{
			Doctrine._DamageThreshold? damageThreshold = this.activeUnit_0.doctrine_0.method_105(this.activeUnit_0.scenario_0, false, false, false);
			short? num = (damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null;
			if (!((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					if (this.activeUnit_0.vmethod_91().method_0() >= 5f)
					{
						return false;
					}
				}
				else
				{
					num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						if (this.activeUnit_0.vmethod_91().method_0() >= 25f)
						{
							return false;
						}
					}
					else
					{
						num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							if (this.activeUnit_0.vmethod_91().method_0() >= 50f)
							{
								return false;
							}
						}
						else
						{
							num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault() && this.activeUnit_0.vmethod_91().method_0() >= 75f)
							{
								return false;
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0008CFBC File Offset: 0x0008B1BC
		public bool method_79()
		{
			Doctrine._FuelQuantityThreshold? fuelQuantityThreshold = this.activeUnit_0.doctrine_0.method_108(this.activeUnit_0.scenario_0, false, false, false);
			short? num = (fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null;
			if (!((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					if (this.activeUnit_0.vmethod_61(null, null) == ActiveUnit._ActiveUnitFuelState.IsBingo)
					{
						return false;
					}
				}
				else
				{
					num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						double num2;
						double num3;
						if ((int)Math.Round(this.activeUnit_0.vmethod_119(ref num2, ref num3, false) * 100.0) < 25)
						{
							return false;
						}
					}
					else
					{
						num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							double num4;
							double num5;
							if ((int)Math.Round(this.activeUnit_0.vmethod_119(ref num4, ref num5, false) * 100.0) < 50)
							{
								return false;
							}
						}
						else
						{
							num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								double num6;
								double num7;
								if ((int)Math.Round(this.activeUnit_0.vmethod_119(ref num6, ref num7, false) * 100.0) < 75)
								{
									return false;
								}
							}
							else
							{
								num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								double num8;
								double num9;
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault() && (int)Math.Round(this.activeUnit_0.vmethod_119(ref num8, ref num9, false) * 100.0) < 100)
								{
									return false;
								}
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0008D2A0 File Offset: 0x0008B4A0
		public bool method_80()
		{
			bool result;
			try
			{
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = this.activeUnit_0.doctrine_0.method_111(this.activeUnit_0.scenario_0, false, false, false);
				short? num = (weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null;
				if (!((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						Weapon weapon = this.activeUnit_0.vmethod_89().vmethod_13();
						if (!Information.IsNothing(weapon) && this.activeUnit_0.vmethod_89().method_5(weapon.DBID, false) == 0)
						{
							return false;
						}
					}
					else
					{
						num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							Weapon weapon2 = this.activeUnit_0.vmethod_89().vmethod_13();
							if (!Information.IsNothing(weapon2))
							{
								int num2 = this.activeUnit_0.vmethod_89().method_5(weapon2.DBID, false);
								int num3 = this.activeUnit_0.vmethod_89().method_4(weapon2.DBID);
								if (num2 == 0 || (double)num2 / (double)num3 < 0.25)
								{
									return false;
								}
							}
						}
						else
						{
							num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								Weapon weapon3 = this.activeUnit_0.vmethod_89().vmethod_13();
								if (!Information.IsNothing(weapon3))
								{
									int num4 = this.activeUnit_0.vmethod_89().method_5(weapon3.DBID, false);
									int num5 = this.activeUnit_0.vmethod_89().method_4(weapon3.DBID);
									if (num4 == 0 || (double)num4 / (double)num5 < 0.5)
									{
										return false;
									}
								}
							}
							else
							{
								num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									Weapon weapon4 = this.activeUnit_0.vmethod_89().vmethod_13();
									if (!Information.IsNothing(weapon4))
									{
										int num6 = this.activeUnit_0.vmethod_89().method_5(weapon4.DBID, false);
										int num7 = this.activeUnit_0.vmethod_89().method_4(weapon4.DBID);
										if (num6 == 0 || (double)num6 / (double)num7 < 0.75)
										{
											return false;
										}
									}
								}
								else
								{
									num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										Weapon weapon5 = this.activeUnit_0.vmethod_89().vmethod_13();
										if (!Information.IsNothing(weapon5))
										{
											int num8 = this.activeUnit_0.vmethod_89().method_5(weapon5.DBID, false);
											int num9 = this.activeUnit_0.vmethod_89().method_4(weapon5.DBID);
											if (num8 == 0 || num8 != num9)
											{
												return false;
											}
										}
									}
									else
									{
										num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
										{
											List<WeaponRec> list = this.activeUnit_0.vmethod_89().method_0(false);
											try
											{
												foreach (WeaponRec weaponRec in list)
												{
													if (weaponRec.int_0 != 0)
													{
														Weapon weapon6 = weaponRec.method_12(this.activeUnit_0.scenario_0);
														if (weapon6.method_195() || weapon6.method_196())
														{
															int num10 = this.activeUnit_0.vmethod_89().method_5(weapon6.DBID, false);
															int num11 = this.activeUnit_0.vmethod_89().method_4(weapon6.DBID);
															if (num10 != 0)
															{
																if (num10 == num11)
																{
																	continue;
																}
															}
															return false;
														}
													}
												}
											}
											finally
											{
												List<WeaponRec>.Enumerator enumerator;
												((IDisposable)enumerator).Dispose();
											}
										}
									}
								}
							}
						}
					}
				}
				result = true;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101356", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0008D824 File Offset: 0x0008BA24
		public bool method_81()
		{
			bool result;
			try
			{
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = this.activeUnit_0.doctrine_0.method_114(this.activeUnit_0.scenario_0, false, false, false);
				short? num = (weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null;
				if (!((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						Weapon weapon = this.activeUnit_0.vmethod_89().vmethod_15();
						if (!Information.IsNothing(weapon) && this.activeUnit_0.vmethod_89().method_5(weapon.DBID, false) == 0)
						{
							return false;
						}
					}
					else
					{
						num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							Weapon weapon2 = this.activeUnit_0.vmethod_89().vmethod_15();
							if (!Information.IsNothing(weapon2))
							{
								int num2 = this.activeUnit_0.vmethod_89().method_5(weapon2.DBID, false);
								int num3 = this.activeUnit_0.vmethod_89().method_4(weapon2.DBID);
								if (num2 == 0 || (double)num2 / (double)num3 < 0.25)
								{
									return false;
								}
							}
						}
						else
						{
							num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								Weapon weapon3 = this.activeUnit_0.vmethod_89().vmethod_15();
								if (!Information.IsNothing(weapon3))
								{
									int num4 = this.activeUnit_0.vmethod_89().method_5(weapon3.DBID, false);
									int num5 = this.activeUnit_0.vmethod_89().method_4(weapon3.DBID);
									if (num4 == 0 || (double)num4 / (double)num5 < 0.5)
									{
										return false;
									}
								}
							}
							else
							{
								num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									Weapon weapon4 = this.activeUnit_0.vmethod_89().vmethod_15();
									if (!Information.IsNothing(weapon4))
									{
										int num6 = this.activeUnit_0.vmethod_89().method_5(weapon4.DBID, false);
										int num7 = this.activeUnit_0.vmethod_89().method_4(weapon4.DBID);
										if (num6 == 0 || (double)num6 / (double)num7 < 0.75)
										{
											return false;
										}
									}
								}
								else
								{
									num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 5) : null).GetValueOrDefault())
									{
										Weapon weapon5 = this.activeUnit_0.vmethod_89().vmethod_15();
										if (!Information.IsNothing(weapon5))
										{
											int num8 = this.activeUnit_0.vmethod_89().method_5(weapon5.DBID, false);
											int num9 = this.activeUnit_0.vmethod_89().method_4(weapon5.DBID);
											if (num8 == 0 || num8 != num9)
											{
												return false;
											}
										}
									}
									else
									{
										num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 6) : null).GetValueOrDefault())
										{
											List<WeaponRec> list = this.activeUnit_0.vmethod_89().method_0(false);
											try
											{
												foreach (WeaponRec weaponRec in list)
												{
													if (weaponRec.int_0 != 0)
													{
														Weapon weapon6 = weaponRec.method_12(this.activeUnit_0.scenario_0);
														if (weapon6.method_199() || weapon6.method_197())
														{
															int num10 = this.activeUnit_0.vmethod_89().method_5(weapon6.DBID, false);
															int num11 = this.activeUnit_0.vmethod_89().method_4(weapon6.DBID);
															if (num10 != 0)
															{
																if (num10 == num11)
																{
																	continue;
																}
															}
															return false;
														}
													}
												}
											}
											finally
											{
												List<WeaponRec>.Enumerator enumerator;
												((IDisposable)enumerator).Dispose();
											}
										}
									}
								}
							}
						}
					}
				}
				result = true;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101357", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0008DDA8 File Offset: 0x0008BFA8
		public bool method_82()
		{
			return this.method_78() && this.method_79() && this.method_80() && this.method_81();
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0008DDE8 File Offset: 0x0008BFE8
		public bool method_83(ActiveUnit_AI.Enum30 enum30_0, string string_1)
		{
			bool result;
			try
			{
				switch (enum30_0)
				{
				case ActiveUnit_AI.Enum30.const_0:
					if (this.activeUnit_0.vmethod_93().method_5(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true))
					{
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " is withdrawing (Reason: " + string_1 + "). ", "Unit withdrawing", LoggedMessage.MessageType.DockingOps, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
					}
					result = true;
					break;
				case ActiveUnit_AI.Enum30.const_1:
				{
					bool flag = false;
					if (this.activeUnit_0.vmethod_93().method_54(this.activeUnit_0.vmethod_86().method_18(), null, null, false, null).Item1 == ActiveUnit_DockingOps.Enum32.const_1)
					{
						this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
						flag = true;
					}
					else if (this.activeUnit_0.vmethod_93().method_5(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true))
					{
						flag = true;
					}
					if (flag)
					{
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " is withdrawing (Reason: " + string_1 + "). ", "Unit withdrawing", LoggedMessage.MessageType.DockingOps, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
					}
					result = flag;
					break;
				}
				case ActiveUnit_AI.Enum30.const_2:
				case ActiveUnit_AI.Enum30.const_3:
				{
					bool flag2 = false;
					ActiveUnit_DockingOps activeUnit_DockingOps = this.activeUnit_0.vmethod_93();
					bool flag3 = true;
					List<Mission> list = null;
					string text = null;
					List<ActiveUnit> list2 = activeUnit_DockingOps.method_53(flag3, list, ref text);
					if (list2.Count > 0)
					{
						Weapon weapon;
						if (enum30_0 == ActiveUnit_AI.Enum30.const_2)
						{
							weapon = this.activeUnit_0.vmethod_89().vmethod_14();
						}
						else
						{
							weapon = this.activeUnit_0.vmethod_89().vmethod_15();
						}
						try
						{
							foreach (ActiveUnit activeUnit in list2)
							{
								if (activeUnit.vmethod_89().method_5(weapon.DBID, false) > 0 && this.activeUnit_0.vmethod_93().method_54(this.activeUnit_0.vmethod_86().method_18(), activeUnit, null, false, null).Item1 == ActiveUnit_DockingOps.Enum32.const_1)
								{
									this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
									flag2 = true;
									IL_236:
									goto IL_262;
								}
							}
							goto IL_236;
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					if (this.activeUnit_0.vmethod_93().method_5(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true))
					{
						flag2 = true;
					}
					IL_262:
					if (flag2)
					{
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " is withdrawing (Reason: " + string_1 + "). ", "Unit withdrawing", LoggedMessage.MessageType.DockingOps, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
					}
					result = flag2;
					break;
				}
				default:
					result = false;
					break;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101358", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0008E12C File Offset: 0x0008C32C
		public bool method_84()
		{
			bool result;
			try
			{
				Doctrine._DamageThreshold? damageThreshold = this.activeUnit_0.doctrine_0.method_93(this.activeUnit_0.scenario_0, false, false, false);
				short? num = (damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null;
				if (!((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						if (this.activeUnit_0.vmethod_91().method_0() >= 5f)
						{
							return this.method_83(ActiveUnit_AI.Enum30.const_0, "Damage now at more than 5%");
						}
					}
					else
					{
						num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							if (this.activeUnit_0.vmethod_91().method_0() >= 25f)
							{
								return this.method_83(ActiveUnit_AI.Enum30.const_0, "Damage now at more than 25%");
							}
						}
						else
						{
							num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								if (this.activeUnit_0.vmethod_91().method_0() >= 50f)
								{
									return this.method_83(ActiveUnit_AI.Enum30.const_0, "Damage now at more than 50%");
								}
							}
							else
							{
								num = ((damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault() && this.activeUnit_0.vmethod_91().method_0() >= 75f)
								{
									return this.method_83(ActiveUnit_AI.Enum30.const_0, "Damage now at more than 75%");
								}
							}
						}
					}
				}
				Doctrine._FuelQuantityThreshold? fuelQuantityThreshold = this.activeUnit_0.doctrine_0.method_96(this.activeUnit_0.scenario_0, false, false, false);
				num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
				if (!((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						ActiveUnit._ActiveUnitFuelState activeUnitFuelState = this.activeUnit_0.vmethod_61(null, null);
						if (activeUnitFuelState == ActiveUnit._ActiveUnitFuelState.IsBingo)
						{
							this.activeUnit_0.vmethod_111(activeUnitFuelState);
							return this.method_83(ActiveUnit_AI.Enum30.const_1, "Fuel level now at bingo");
						}
					}
					else
					{
						num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							double num2;
							double num3;
							if ((int)Math.Round(this.activeUnit_0.vmethod_119(ref num2, ref num3, false) * 100.0) < 25)
							{
								return this.method_83(ActiveUnit_AI.Enum30.const_1, "Fuel level now at less than 25%");
							}
						}
						else
						{
							num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								double num4;
								double num5;
								if ((int)Math.Round(this.activeUnit_0.vmethod_119(ref num4, ref num5, false) * 100.0) < 50)
								{
									return this.method_83(ActiveUnit_AI.Enum30.const_1, "Fuel level now at less than 50%");
								}
							}
							else
							{
								num = ((fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null);
								double num6;
								double num7;
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault() && (int)Math.Round(this.activeUnit_0.vmethod_119(ref num6, ref num7, false) * 100.0) < 75)
								{
									return this.method_83(ActiveUnit_AI.Enum30.const_1, "Fuel level now at less than 75%");
								}
							}
						}
					}
				}
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = this.activeUnit_0.doctrine_0.method_99(this.activeUnit_0.scenario_0, false, false, false);
				num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
				if (!((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						Weapon weapon = this.activeUnit_0.vmethod_89().vmethod_13();
						if (!Information.IsNothing(weapon) && this.activeUnit_0.vmethod_89().method_5(weapon.DBID, false) == 0)
						{
							return this.method_83(ActiveUnit_AI.Enum30.const_2, "Primary attack weapon (" + weapon.Name + ") now exhausted");
						}
					}
					else
					{
						num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							Weapon weapon2 = this.activeUnit_0.vmethod_89().vmethod_13();
							if (!Information.IsNothing(weapon2))
							{
								int num8 = this.activeUnit_0.vmethod_89().method_5(weapon2.DBID, false);
								int num9 = this.activeUnit_0.vmethod_89().method_4(weapon2.DBID);
								if (num8 == 0 || (double)num8 / (double)num9 < 0.25)
								{
									return this.method_83(ActiveUnit_AI.Enum30.const_2, "Primary attack weapon (" + weapon2.Name + ") now at less than 25%");
								}
							}
						}
						else
						{
							num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								Weapon weapon3 = this.activeUnit_0.vmethod_89().vmethod_13();
								if (!Information.IsNothing(weapon3))
								{
									int num10 = this.activeUnit_0.vmethod_89().method_5(weapon3.DBID, false);
									int num11 = this.activeUnit_0.vmethod_89().method_4(weapon3.DBID);
									if (num10 == 0 || (double)num10 / (double)num11 < 0.5)
									{
										return this.method_83(ActiveUnit_AI.Enum30.const_2, "Primary attack weapon (" + weapon3.Name + ") now at less than 50%");
									}
								}
							}
							else
							{
								num = ((weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									Weapon weapon4 = this.activeUnit_0.vmethod_89().vmethod_13();
									if (!Information.IsNothing(weapon4))
									{
										int num12 = this.activeUnit_0.vmethod_89().method_5(weapon4.DBID, false);
										int num13 = this.activeUnit_0.vmethod_89().method_4(weapon4.DBID);
										if (num12 == 0 || (double)num12 / (double)num13 < 0.75)
										{
											return this.method_83(ActiveUnit_AI.Enum30.const_2, "Primary attack weapon (" + weapon4.Name + ") now at less than 75%");
										}
									}
								}
							}
						}
					}
				}
				Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold2 = this.activeUnit_0.doctrine_0.method_102(this.activeUnit_0.scenario_0, false, false, false);
				num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
				if (!((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						Weapon weapon5 = this.activeUnit_0.vmethod_89().vmethod_15();
						if (!Information.IsNothing(weapon5) && this.activeUnit_0.vmethod_89().method_5(weapon5.DBID, false) == 0)
						{
							return this.method_83(ActiveUnit_AI.Enum30.const_3, "Primary defence weapon (" + weapon5.Name + ") now exhausted");
						}
					}
					else
					{
						num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							Weapon weapon6 = this.activeUnit_0.vmethod_89().vmethod_15();
							if (!Information.IsNothing(weapon6))
							{
								int num14 = this.activeUnit_0.vmethod_89().method_5(weapon6.DBID, false);
								int num15 = this.activeUnit_0.vmethod_89().method_4(weapon6.DBID);
								if (num14 == 0 || (double)num14 / (double)num15 < 0.25)
								{
									return this.method_83(ActiveUnit_AI.Enum30.const_3, "Primary defence weapon (" + weapon6.Name + ") now at less than 25%");
								}
							}
						}
						else
						{
							num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								Weapon weapon7 = this.activeUnit_0.vmethod_89().vmethod_15();
								if (!Information.IsNothing(weapon7))
								{
									int num16 = this.activeUnit_0.vmethod_89().method_5(weapon7.DBID, false);
									int num17 = this.activeUnit_0.vmethod_89().method_4(weapon7.DBID);
									if (num16 == 0 || (double)num16 / (double)num17 < 0.5)
									{
										return this.method_83(ActiveUnit_AI.Enum30.const_3, "Primary defence weapon (" + weapon7.Name + ") now at less than 50%");
									}
								}
							}
							else
							{
								num = ((weaponQuantityThreshold2 != null) ? new short?((short)weaponQuantityThreshold2.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									Weapon weapon8 = this.activeUnit_0.vmethod_89().vmethod_15();
									if (!Information.IsNothing(weapon8))
									{
										int num18 = this.activeUnit_0.vmethod_89().method_5(weapon8.DBID, false);
										int num19 = this.activeUnit_0.vmethod_89().method_4(weapon8.DBID);
										if (num18 == 0 || (double)num18 / (double)num19 < 0.75)
										{
											return this.method_83(ActiveUnit_AI.Enum30.const_3, "Primary defence weapon (" + weapon8.Name + ") now at less than 75%");
										}
									}
								}
							}
						}
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101359", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0008EE00 File Offset: 0x0008D000
		public virtual void vmethod_28(bool bool_11)
		{
			try
			{
				if (this.activeUnit_0 != null)
				{
					if (this.activeUnit_0.vmethod_87().vmethod_12())
					{
						Submarine_AI submarine_AI = ((Submarine)this.activeUnit_0).method_153();
						float num;
						switch (submarine_AI.method_114())
						{
						case ActiveUnit_AI.SubmarineDepthPreset.None:
							return;
						case ActiveUnit_AI.SubmarineDepthPreset.Periscope:
							num = -20f;
							break;
						case ActiveUnit_AI.SubmarineDepthPreset.Shallow:
							num = -40f;
							break;
						case ActiveUnit_AI.SubmarineDepthPreset.OverLayer:
							num = Submarine_AI.smethod_2(this.activeUnit_0);
							break;
						case ActiveUnit_AI.SubmarineDepthPreset.UnderLayer:
							num = Submarine_AI.smethod_3(this.activeUnit_0);
							break;
						case ActiveUnit_AI.SubmarineDepthPreset.MaxDepth:
							num = this.activeUnit_0.vmethod_87().vmethod_31();
							break;
						case ActiveUnit_AI.SubmarineDepthPreset.Surface:
							num = 0f;
							break;
						}
						if (bool_11)
						{
							if (Math.Round((double)num) >= -20.0 && !submarine_AI.method_123(this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedDefensive || this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive, null, -1.0, -1.0))
							{
								this.activeUnit_0.vmethod_73(-40f);
							}
							else
							{
								this.activeUnit_0.vmethod_73(num);
							}
						}
						else
						{
							this.activeUnit_0.vmethod_73(num);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101360", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00007585 File Offset: 0x00005785
		private void method_85(object sender, NotifyDictionaryChangedEventArgs<string, ActiveUnit_AI.TargetingEntry> e)
		{
			this.contact_3 = null;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0008EF90 File Offset: 0x0008D190
		public float method_86(ref double double_4, ref double double_5)
		{
			float result;
			try
			{
				Aircraft aircraft = (Aircraft)this.activeUnit_0;
				float num = (float)Terrain.smethod_7(double_4, double_5, false);
				if (num > 0f)
				{
					num = (float)(Math.Round((double)(num * 3.28084f / 1000f), 0) * 1000.0 / 3.2808399200439453);
				}
				else
				{
					num = 0f;
				}
				if (!Information.IsNothing(aircraft.method_167()) && !Information.IsNothing(aircraft.method_167().method_15(aircraft.scenario_0).float_0) && aircraft.method_167().method_15(aircraft.scenario_0).float_0 > 0f)
				{
					result = aircraft.method_167().method_15(aircraft.scenario_0).float_0 + num;
				}
				else
				{
					result = 609.6f + num;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101361", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 609.6f;
			}
			return result;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0008F0B0 File Offset: 0x0008D2B0
		public virtual void vmethod_29(float float_3)
		{
			if (!Information.IsNothing(this.activeUnit_0))
			{
				try
				{
					ActiveUnit activeUnit = this.activeUnit_0.vmethod_93().method_2();
					if (!Information.IsNothing(activeUnit) && !activeUnit.method_82())
					{
						ActiveUnit_DockingOps activeUnit_DockingOps = activeUnit.vmethod_93();
						ActiveUnit theBoat = this.activeUnit_0;
						DockFacility dockFacility = null;
						if (activeUnit_DockingOps.method_40(theBoat, ref dockFacility))
						{
							goto IL_6B;
						}
					}
					this.activeUnit_0.vmethod_93().method_43(null);
					activeUnit = this.activeUnit_0.vmethod_93().method_2();
					IL_6B:
					if (Information.IsNothing(activeUnit))
					{
						if (this.activeUnit_0.vmethod_85().method_47())
						{
							this.activeUnit_0.vmethod_85().vmethod_16(float_3);
						}
					}
					else
					{
						float num = this.activeUnit_0.method_36(activeUnit);
						if (this.activeUnit_0.vmethod_40() == 0f && num < 1f && this.activeUnit_0.vmethod_116() == 0)
						{
							this.activeUnit_0.vmethod_93().method_48(activeUnit, false);
						}
						else if (num * 1852f < 100f)
						{
							this.activeUnit_0.vmethod_93().method_48(activeUnit, false);
						}
						else
						{
							if (!this.activeUnit_0.vmethod_85().method_44())
							{
								this.activeUnit_0.vmethod_85().vmethod_9();
								this.activeUnit_0.vmethod_85().method_50(new Waypoint(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null), 0f, Waypoint.WaypointType.ManualPlottedCourseWaypoint, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0));
								this.activeUnit_0.vmethod_85().vmethod_16(float_3);
							}
							else
							{
								this.activeUnit_0.vmethod_85().vmethod_16(float_3);
							}
							this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100819", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00003024 File Offset: 0x00001224
		public virtual bool vmethod_30(DateTime? nullable_10, ref Waypoint waypoint_0, bool bool_11)
		{
			return false;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00003024 File Offset: 0x00001224
		public virtual bool vmethod_31(ref Scenario scenario_0, ref Waypoint waypoint_0, ref Waypoint waypoint_1)
		{
			return false;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0008F2B8 File Offset: 0x0008D4B8
		public bool method_87()
		{
			bool result;
			if (this.activeUnit_0.vmethod_13() < 1000f && (this.activeUnit_0.vmethod_74() != 0f || this.activeUnit_0.vmethod_72() < 3000f))
			{
				float value = ((Interface6)this.activeUnit_0).imethod_4().Value;
				this.list_1.Clear();
				float num = 0.2f;
				do
				{
					double item;
					double item2;
					Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref item, ref item2, (double)num, (double)this.activeUnit_0.vmethod_9());
					short num2 = Terrain.smethod_7(item2, item, false);
					ValueTuple<ValueTuple<double, double, float, short>> item3 = default(ValueTuple<ValueTuple<double, double, float, short>>);
					item3.Item1.Item1 = item2;
					item3.Item1.Item2 = item;
					item3.Item1.Item3 = num;
					item3.Item1.Item4 = num2;
					if ((float)num2 > this.activeUnit_0.vmethod_14(false))
					{
						this.list_1.Add(item3);
					}
					num += 0.2f;
				}
				while (num <= 2f);
				if (this.list_1.Count > 0)
				{
					ValueTuple<ValueTuple<double, double, float, short>> valueTuple = Enumerable.ElementAtOrDefault<ValueTuple<ValueTuple<double, double, float, short>>>(Enumerable.OrderByDescending<ValueTuple<ValueTuple<double, double, float, short>>, double>(this.list_1, new Func<ValueTuple<ValueTuple<double, double, float, short>>, double>(this.method_111)), 0);
					if ((float)valueTuple.Item1.Item4 + value > this.activeUnit_0.vmethod_14(false))
					{
						this.method_88(valueTuple.Item1.Item1, valueTuple.Item1.Item2, (double)((float)valueTuple.Item1.Item4 + value));
						this.bool_6 = true;
					}
					else
					{
						this.method_88(valueTuple.Item1.Item1, valueTuple.Item1.Item2, (double)this.activeUnit_0.vmethod_72());
						this.bool_6 = true;
					}
					result = true;
				}
				else
				{
					result = false;
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0008F4BC File Offset: 0x0008D6BC
		public void method_88(double double_4, double double_5, double double_6)
		{
			if (this.activeUnit_0.vmethod_6())
			{
				double num = Math.Atan2((double)this.activeUnit_0.vmethod_14(false) - double_6, (double)this.activeUnit_0.method_25(double_4, double_5) * 1852.0) * 57.2957795130823;
				if (num > 0.0 && (double)this.activeUnit_0.vmethod_14(false) > double_6)
				{
					num = -num;
				}
				if (num < 0.0 && (double)this.activeUnit_0.vmethod_14(false) < double_6)
				{
					num = -num;
				}
				this.activeUnit_0.vmethod_23((float)num);
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0000758E File Offset: 0x0000578E
		[CompilerGenerated]
		private float method_89(Unit unit_1)
		{
			return this.activeUnit_0.method_36(unit_1);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0000759C File Offset: 0x0000579C
		[CompilerGenerated]
		private float method_90(ActiveUnit activeUnit_1)
		{
			return activeUnit_1.method_36(this.activeUnit_0);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0000758E File Offset: 0x0000578E
		[CompilerGenerated]
		private float method_91(Contact contact_8)
		{
			return this.activeUnit_0.method_36(contact_8);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0008F55C File Offset: 0x0008D75C
		[CompilerGenerated]
		private bool method_92(Contact contact_8)
		{
			ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
			bool checkWRA = true;
			Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
			string text = "";
			int num = 0;
			return activeUnit_Weaponry.method_6(contact_8, checkWRA, doctrine_, ref text, ref num, null) && this.method_36(contact_8);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0000758E File Offset: 0x0000578E
		[CompilerGenerated]
		private float method_93(Contact contact_8)
		{
			return this.activeUnit_0.method_36(contact_8);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_94(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_95(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0008F5A0 File Offset: 0x0008D7A0
		[CompilerGenerated]
		private bool method_96(Contact contact_8)
		{
			if (contact_8.method_125() < Contact_Base.IdentificationStatus.KnownClass)
			{
				ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
				bool checkWRA = true;
				Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
				string text = "";
				int num = 0;
				if (activeUnit_Weaponry.method_6(contact_8, checkWRA, doctrine_, ref text, ref num, null))
				{
					return this.method_36(contact_8);
				}
			}
			return false;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_97(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_98(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0008F55C File Offset: 0x0008D75C
		[CompilerGenerated]
		private bool method_99(Contact contact_8)
		{
			ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
			bool checkWRA = true;
			Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
			string text = "";
			int num = 0;
			return activeUnit_Weaponry.method_6(contact_8, checkWRA, doctrine_, ref text, ref num, null) && this.method_36(contact_8);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_100(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0008F5EC File Offset: 0x0008D7EC
		[CompilerGenerated]
		private bool method_101(Contact contact_8)
		{
			if (contact_8.method_130(this.activeUnit_0.vmethod_7(false)) == Misc.PostureStance.Unfriendly)
			{
				ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
				bool checkWRA = true;
				Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
				string text = "";
				int num = 0;
				if (activeUnit_Weaponry.method_6(contact_8, checkWRA, doctrine_, ref text, ref num, null))
				{
					return this.method_36(contact_8);
				}
			}
			return false;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_102(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_103(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0008F55C File Offset: 0x0008D75C
		[CompilerGenerated]
		private bool method_104(Contact contact_8)
		{
			ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
			bool checkWRA = true;
			Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
			string text = "";
			int num = 0;
			return activeUnit_Weaponry.method_6(contact_8, checkWRA, doctrine_, ref text, ref num, null) && this.method_36(contact_8);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_105(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_106(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_107(Contact contact_8)
		{
			return this.activeUnit_0.method_31(contact_8);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000075B8 File Offset: 0x000057B8
		[CompilerGenerated]
		private bool method_108(UnguidedWeapon unguidedWeapon_0)
		{
			return unguidedWeapon_0.vmethod_7(false) == this.activeUnit_0.vmethod_7(false) || this.activeUnit_0.vmethod_7(false).method_67(unguidedWeapon_0.vmethod_7(false));
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000075E9 File Offset: 0x000057E9
		[CompilerGenerated]
		private float method_109(ActiveUnit_AI.TargetingEntry targetingEntry_1)
		{
			return this.activeUnit_0.method_36(targetingEntry_1.contact_0);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x000075FC File Offset: 0x000057FC
		[CompilerGenerated]
		private bool method_110(ActiveUnit activeUnit_1)
		{
			return activeUnit_1 != this.activeUnit_0 && activeUnit_1.vmethod_127() && activeUnit_1.GetType() == this.activeUnit_0.GetType();
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0008F644 File Offset: 0x0008D844
		[CompilerGenerated]
		private double method_111(ValueTuple<ValueTuple<double, double, float, short>> valueTuple_0)
		{
			return Math.Atan2((double)Math.Abs((float)valueTuple_0.Item1.Item4 - this.activeUnit_0.vmethod_14(false)), (double)valueTuple_0.Item1.Item3 * 1852.0) * 57.2957795130823;
		}

		// Token: 0x04000586 RID: 1414
		internal ActiveUnit activeUnit_0;

		// Token: 0x04000587 RID: 1415
		protected Contact contact_0;

		// Token: 0x04000588 RID: 1416
		protected Contact_Base.ContactType contactType_0;

		// Token: 0x04000589 RID: 1417
		protected double double_0;

		// Token: 0x0400058A RID: 1418
		protected double double_1;

		// Token: 0x0400058B RID: 1419
		protected float float_0;

		// Token: 0x0400058C RID: 1420
		protected Contact contact_1;

		// Token: 0x0400058D RID: 1421
		protected HashSet<string> hashSet_0;

		// Token: 0x0400058E RID: 1422
		public string string_0;

		// Token: 0x0400058F RID: 1423
		public float float_1;

		// Token: 0x04000590 RID: 1424
		public float float_2;

		// Token: 0x04000591 RID: 1425
		public float? nullable_0;

		// Token: 0x04000592 RID: 1426
		protected bool bool_0;

		// Token: 0x04000593 RID: 1427
		[CompilerGenerated]
		[AccessedThroughProperty("_TargetList")]
		private ObservableDictionary<string, ActiveUnit_AI.TargetingEntry> observableDictionary_0;

		// Token: 0x04000594 RID: 1428
		protected Contact[] contact_2;

		// Token: 0x04000595 RID: 1429
		protected bool bool_1;

		// Token: 0x04000596 RID: 1430
		protected GeoPoint geoPoint_0;

		// Token: 0x04000597 RID: 1431
		protected float? nullable_1;

		// Token: 0x04000598 RID: 1432
		protected int int_0;

		// Token: 0x04000599 RID: 1433
		public Geopoint_Struct geopoint_Struct_0;

		// Token: 0x0400059A RID: 1434
		public bool bool_2;

		// Token: 0x0400059B RID: 1435
		public bool bool_3;

		// Token: 0x0400059C RID: 1436
		public bool bool_4;

		// Token: 0x0400059D RID: 1437
		public GeoPoint geoPoint_1;

		// Token: 0x0400059E RID: 1438
		protected bool bool_5;

		// Token: 0x0400059F RID: 1439
		public bool bool_6;

		// Token: 0x040005A0 RID: 1440
		private List<Contact> list_0;

		// Token: 0x040005A1 RID: 1441
		internal Tuple<Contact, Misc.PostureStance>[] tuple_0;

		// Token: 0x040005A2 RID: 1442
		public bool bool_7;

		// Token: 0x040005A3 RID: 1443
		public float? nullable_2;

		// Token: 0x040005A4 RID: 1444
		public float? nullable_3;

		// Token: 0x040005A5 RID: 1445
		public ActiveUnit.Throttle? nullable_4;

		// Token: 0x040005A6 RID: 1446
		public ActiveUnit_Kinematics.UnitThrottlePreset? nullable_5;

		// Token: 0x040005A7 RID: 1447
		public bool bool_8;

		// Token: 0x040005A8 RID: 1448
		public bool bool_9;

		// Token: 0x040005A9 RID: 1449
		public bool bool_10;

		// Token: 0x040005AA RID: 1450
		private Unit unit_0;

		// Token: 0x040005AB RID: 1451
		private Contact[] contact_3;

		// Token: 0x040005AC RID: 1452
		private ActiveUnit_AI.TargetingEntry[] targetingEntry_0;

		// Token: 0x040005AD RID: 1453
		private double double_2;

		// Token: 0x040005AE RID: 1454
		private double double_3;

		// Token: 0x040005AF RID: 1455
		private Contact contact_4;

		// Token: 0x040005B0 RID: 1456
		private Contact contact_5;

		// Token: 0x040005B1 RID: 1457
		private Contact contact_6;

		// Token: 0x040005B2 RID: 1458
		private Contact contact_7;

		// Token: 0x040005B3 RID: 1459
		private float? nullable_6;

		// Token: 0x040005B4 RID: 1460
		private float? nullable_7;

		// Token: 0x040005B5 RID: 1461
		private float? nullable_8;

		// Token: 0x040005B6 RID: 1462
		private float? nullable_9;

		// Token: 0x040005B7 RID: 1463
		private List<ValueTuple<ValueTuple<double, double, float, short>>> list_1;

		// Token: 0x0200012E RID: 302
		public enum SubmarineDepthPreset : byte
		{
			// Token: 0x040005B9 RID: 1465
			None,
			// Token: 0x040005BA RID: 1466
			Periscope,
			// Token: 0x040005BB RID: 1467
			Shallow,
			// Token: 0x040005BC RID: 1468
			OverLayer,
			// Token: 0x040005BD RID: 1469
			UnderLayer,
			// Token: 0x040005BE RID: 1470
			MaxDepth,
			// Token: 0x040005BF RID: 1471
			Surface
		}

		// Token: 0x0200012F RID: 303
		public enum AircraftAltitudePreset : byte
		{
			// Token: 0x040005C1 RID: 1473
			None,
			// Token: 0x040005C2 RID: 1474
			MinAltitude,
			// Token: 0x040005C3 RID: 1475
			Low1000,
			// Token: 0x040005C4 RID: 1476
			Low2000,
			// Token: 0x040005C5 RID: 1477
			Medium12000,
			// Token: 0x040005C6 RID: 1478
			High25000,
			// Token: 0x040005C7 RID: 1479
			High36000,
			// Token: 0x040005C8 RID: 1480
			MaxAltitude
		}

		// Token: 0x02000130 RID: 304
		internal enum Enum30
		{
			// Token: 0x040005CA RID: 1482
			const_0,
			// Token: 0x040005CB RID: 1483
			const_1,
			// Token: 0x040005CC RID: 1484
			const_2,
			// Token: 0x040005CD RID: 1485
			const_3
		}

		// Token: 0x02000131 RID: 305
		public sealed class TargetingEntry
		{
			// Token: 0x0600085D RID: 2141 RVA: 0x0008F698 File Offset: 0x0008D898
			public string method_0(Side side_0)
			{
				string result;
				try
				{
					if (this.stringBuilder_0 == null)
					{
						this.stringBuilder_0 = new StringBuilder(500);
					}
					else
					{
						this.stringBuilder_0.Clear();
					}
					if (this.contact_0 == null)
					{
						result = null;
					}
					else
					{
						this.stringBuilder_0.Clear();
						this.stringBuilder_0.Append("<TE>");
						StringBuilder stringBuilder = this.stringBuilder_0.Append("<BHVR>");
						short targetingBehavior_ = (short)this._TargetingBehavior_0;
						stringBuilder.Append(targetingBehavior_.ToString()).Append("</BHVR>");
						if (!Information.IsNothing(this.contact_0.activeUnit_0) && side_0.method_11().ContainsKey(this.contact_0.activeUnit_0.string_0))
						{
							this.stringBuilder_0.Append("<TGT>").Append(this.contact_0.string_0).Append("</TGT>");
						}
						else
						{
							this.stringBuilder_0.Append("<TGT>");
							this.stringBuilder_0.Append(this.contact_0.method_61(null));
							this.stringBuilder_0.Append("</TGT>");
						}
						this.stringBuilder_0.Append("</TE>");
						result = this.stringBuilder_0.ToString();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100069", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
				return result;
			}

			// Token: 0x0600085E RID: 2142 RVA: 0x0008F828 File Offset: 0x0008DA28
			public static ActiveUnit_AI.TargetingEntry smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0)
			{
				ActiveUnit_AI.TargetingEntry result;
				try
				{
					ActiveUnit_AI.TargetingEntry targetingEntry = new ActiveUnit_AI.TargetingEntry();
					try
					{
						foreach (object obj in xmlNode_0.ChildNodes)
						{
							XmlNode xmlNode = (XmlNode)obj;
							string name = xmlNode.Name;
							if (Operators.CompareString(name, "Behavior", false) != 0 && Operators.CompareString(name, "BHVR", false) != 0)
							{
								if (Operators.CompareString(name, "Target", false) == 0 || Operators.CompareString(name, "TGT", false) == 0)
								{
									if (xmlNode.InnerText.StartsWith("ActivationPoint_"))
									{
										targetingEntry.contact_0 = Class356.smethod_6(xmlNode.ChildNodes[0].ChildNodes[0].InnerText);
									}
									else if (xmlNode.InnerText.StartsWith("Aimpoint_"))
									{
										targetingEntry.contact_0 = Class355.smethod_6(xmlNode.ChildNodes[0].ChildNodes[0].InnerText);
									}
									else if (xmlNode.ChildNodes.Count > 1)
									{
										targetingEntry.contact_0 = Contact.smethod_1(ref xmlNode, ref dictionary_0);
									}
									else
									{
										targetingEntry.contact_0 = Contact.smethod_0(xmlNode.InnerText, ref dictionary_0);
									}
								}
							}
							else if (Versioned.IsNumeric(xmlNode.InnerText))
							{
								targetingEntry._TargetingBehavior_0 = (ActiveUnit_AI.TargetingEntry._TargetingBehavior)Conversions.ToShort(xmlNode.InnerText);
							}
							else
							{
								targetingEntry._TargetingBehavior_0 = (ActiveUnit_AI.TargetingEntry._TargetingBehavior)Enum.Parse(typeof(ActiveUnit_AI.TargetingEntry._TargetingBehavior), xmlNode.InnerText, true);
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
					result = targetingEntry;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100070", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new ActiveUnit_AI.TargetingEntry();
				}
				return result;
			}

			// Token: 0x0600085F RID: 2143 RVA: 0x00007624 File Offset: 0x00005824
			public ActiveUnit_AI.TargetingEntry._TargetingBehavior method_1()
			{
				return this._TargetingBehavior_0;
			}

			// Token: 0x06000860 RID: 2144 RVA: 0x0000762C File Offset: 0x0000582C
			public void method_2(ActiveUnit_AI.TargetingEntry._TargetingBehavior _TargetingBehavior_1)
			{
				this._TargetingBehavior_0 = _TargetingBehavior_1;
			}

			// Token: 0x06000861 RID: 2145 RVA: 0x00007635 File Offset: 0x00005835
			public TargetingEntry()
			{
				this.double_0 = 0.0;
				this.double_1 = 0.0;
			}

			// Token: 0x040005CE RID: 1486
			private ActiveUnit_AI.TargetingEntry._TargetingBehavior _TargetingBehavior_0;

			// Token: 0x040005CF RID: 1487
			public Contact contact_0;

			// Token: 0x040005D0 RID: 1488
			public double double_0;

			// Token: 0x040005D1 RID: 1489
			public double double_1;

			// Token: 0x040005D2 RID: 1490
			private StringBuilder stringBuilder_0;

			// Token: 0x02000132 RID: 306
			public enum _TargetingBehavior : short
			{
				// Token: 0x040005D4 RID: 1492
				NotTargeted = -1,
				// Token: 0x040005D5 RID: 1493
				AutoTargeted,
				// Token: 0x040005D6 RID: 1494
				ManualWeaponAlloc,
				// Token: 0x040005D7 RID: 1495
				ManualTargeted
			}
		}

		// Token: 0x02000134 RID: 308
		[CompilerGenerated]
		internal sealed class Class172
		{
			// Token: 0x06000875 RID: 2165 RVA: 0x000076B6 File Offset: 0x000058B6
			public Class172(ActiveUnit_AI.Class172 class172_0)
			{
				if (class172_0 != null)
				{
					this.aircraft_0 = class172_0.aircraft_0;
				}
			}

			// Token: 0x06000876 RID: 2166 RVA: 0x000076CD File Offset: 0x000058CD
			internal bool method_0(Aircraft aircraft_1)
			{
				return aircraft_1 != this.aircraft_0;
			}

			// Token: 0x040005EA RID: 1514
			public Aircraft aircraft_0;

			// Token: 0x040005EB RID: 1515
			public Func<Aircraft, bool> func_0;
		}

		// Token: 0x02000135 RID: 309
		[CompilerGenerated]
		internal sealed class Class173
		{
			// Token: 0x06000877 RID: 2167 RVA: 0x000076DB File Offset: 0x000058DB
			public Class173(ActiveUnit_AI.Class173 class173_0)
			{
				if (class173_0 != null)
				{
					this.contact_0 = class173_0.contact_0;
				}
			}

			// Token: 0x06000878 RID: 2168 RVA: 0x000076F2 File Offset: 0x000058F2
			internal int method_0(Contact contact_1)
			{
				return this.activeUnit_AI_0.activeUnit_0.vmethod_7(false).dictionary_5[this.contact_0.string_0];
			}

			// Token: 0x06000879 RID: 2169 RVA: 0x0000771A File Offset: 0x0000591A
			internal float method_1(Contact contact_1)
			{
				return this.activeUnit_AI_0.activeUnit_0.method_36(this.contact_0);
			}

			// Token: 0x0600087A RID: 2170 RVA: 0x0000771A File Offset: 0x0000591A
			internal float method_2(Contact contact_1)
			{
				return this.activeUnit_AI_0.activeUnit_0.method_36(this.contact_0);
			}

			// Token: 0x040005EC RID: 1516
			public Contact contact_0;

			// Token: 0x040005ED RID: 1517
			public ActiveUnit_AI activeUnit_AI_0;
		}

		// Token: 0x02000136 RID: 310
		[CompilerGenerated]
		internal sealed class Class174
		{
			// Token: 0x0600087B RID: 2171 RVA: 0x00007732 File Offset: 0x00005932
			public Class174(ActiveUnit_AI.Class174 class174_0)
			{
				if (class174_0 != null)
				{
					this.bool_0 = class174_0.bool_0;
				}
			}

			// Token: 0x0600087C RID: 2172 RVA: 0x0008FB6C File Offset: 0x0008DD6C
			internal bool method_0(Contact contact_0)
			{
				if (contact_0.method_125() < Contact_Base.IdentificationStatus.KnownClass)
				{
					ActiveUnit_AI activeUnit_AI = this.activeUnit_AI_0;
					Mission mission_ = this.activeUnit_AI_0.activeUnit_0.vmethod_101();
					Doctrine.Enum59? nullable_ = this.activeUnit_AI_0.activeUnit_0.doctrine_0.method_162(this.activeUnit_AI_0.activeUnit_0.scenario_0, false, false, false);
					bool bool_ = false;
					bool bool_2 = this.bool_0;
					bool bool_3 = true;
					Misc.PostureStance? nullable_2 = null;
					string text = "";
					int num = 0;
					return activeUnit_AI.method_39(contact_0, mission_, nullable_, bool_, bool_2, bool_3, nullable_2, ref text, ref num);
				}
				return false;
			}

			// Token: 0x0600087D RID: 2173 RVA: 0x0008FB6C File Offset: 0x0008DD6C
			internal bool method_1(Contact contact_0)
			{
				if (contact_0.method_125() < Contact_Base.IdentificationStatus.KnownClass)
				{
					ActiveUnit_AI activeUnit_AI = this.activeUnit_AI_0;
					Mission mission_ = this.activeUnit_AI_0.activeUnit_0.vmethod_101();
					Doctrine.Enum59? nullable_ = this.activeUnit_AI_0.activeUnit_0.doctrine_0.method_162(this.activeUnit_AI_0.activeUnit_0.scenario_0, false, false, false);
					bool bool_ = false;
					bool bool_2 = this.bool_0;
					bool bool_3 = true;
					Misc.PostureStance? nullable_2 = null;
					string text = "";
					int num = 0;
					return activeUnit_AI.method_39(contact_0, mission_, nullable_, bool_, bool_2, bool_3, nullable_2, ref text, ref num);
				}
				return false;
			}

			// Token: 0x0600087E RID: 2174 RVA: 0x0008FBE8 File Offset: 0x0008DDE8
			internal bool method_2(Contact contact_0)
			{
				if (contact_0.method_130(this.activeUnit_AI_0.activeUnit_0.vmethod_7(false)) == Misc.PostureStance.Unfriendly)
				{
					ActiveUnit_AI activeUnit_AI = this.activeUnit_AI_0;
					Mission mission_ = this.activeUnit_AI_0.activeUnit_0.vmethod_101();
					Doctrine.Enum59? nullable_ = this.activeUnit_AI_0.activeUnit_0.doctrine_0.method_162(this.activeUnit_AI_0.activeUnit_0.scenario_0, false, false, false);
					bool bool_ = false;
					bool bool_2 = this.bool_0;
					bool bool_3 = true;
					Misc.PostureStance? nullable_2 = null;
					string text = "";
					int num = 0;
					return activeUnit_AI.method_39(contact_0, mission_, nullable_, bool_, bool_2, bool_3, nullable_2, ref text, ref num);
				}
				return false;
			}

			// Token: 0x0600087F RID: 2175 RVA: 0x0008FBE8 File Offset: 0x0008DDE8
			internal bool method_3(Contact contact_0)
			{
				if (contact_0.method_130(this.activeUnit_AI_0.activeUnit_0.vmethod_7(false)) == Misc.PostureStance.Unfriendly)
				{
					ActiveUnit_AI activeUnit_AI = this.activeUnit_AI_0;
					Mission mission_ = this.activeUnit_AI_0.activeUnit_0.vmethod_101();
					Doctrine.Enum59? nullable_ = this.activeUnit_AI_0.activeUnit_0.doctrine_0.method_162(this.activeUnit_AI_0.activeUnit_0.scenario_0, false, false, false);
					bool bool_ = false;
					bool bool_2 = this.bool_0;
					bool bool_3 = true;
					Misc.PostureStance? nullable_2 = null;
					string text = "";
					int num = 0;
					return activeUnit_AI.method_39(contact_0, mission_, nullable_, bool_, bool_2, bool_3, nullable_2, ref text, ref num);
				}
				return false;
			}

			// Token: 0x040005EE RID: 1518
			public bool bool_0;

			// Token: 0x040005EF RID: 1519
			public ActiveUnit_AI activeUnit_AI_0;
		}

		// Token: 0x02000137 RID: 311
		[CompilerGenerated]
		internal sealed class Class175
		{
			// Token: 0x06000881 RID: 2177 RVA: 0x00007749 File Offset: 0x00005949
			internal bool method_0(Contact contact_0)
			{
				return this.activeUnit_AI_0.activeUnit_0.method_36(contact_0) <= this.float_0;
			}

			// Token: 0x040005F0 RID: 1520
			public float float_0;

			// Token: 0x040005F1 RID: 1521
			public ActiveUnit_AI activeUnit_AI_0;
		}

		// Token: 0x02000138 RID: 312
		[CompilerGenerated]
		internal sealed class Class176
		{
			// Token: 0x06000883 RID: 2179 RVA: 0x00007767 File Offset: 0x00005967
			internal void method_0()
			{
				this.activeUnit_AI_0.method_59(this.float_0, true);
			}

			// Token: 0x040005F2 RID: 1522
			public float float_0;

			// Token: 0x040005F3 RID: 1523
			public ActiveUnit_AI activeUnit_AI_0;
		}

		// Token: 0x02000139 RID: 313
		[CompilerGenerated]
		internal sealed class Class177
		{
			// Token: 0x06000884 RID: 2180 RVA: 0x0000777B File Offset: 0x0000597B
			public Class177(ActiveUnit_AI.Class177 class177_0)
			{
				if (class177_0 != null)
				{
					this.bool_0 = class177_0.bool_0;
				}
			}

			// Token: 0x06000885 RID: 2181 RVA: 0x0008FC74 File Offset: 0x0008DE74
			internal void method_0(UnguidedWeapon unguidedWeapon_0, ParallelLoopState parallelLoopState_0)
			{
				if ((double)this.activeUnit_AI_0.activeUnit_0.method_36(unguidedWeapon_0) < (double)this.activeUnit_AI_0.activeUnit_0.vmethod_132(unguidedWeapon_0.method_63(), false) / 1852.0)
				{
					this.bool_0 = false;
					parallelLoopState_0.Stop();
				}
			}

			// Token: 0x040005F4 RID: 1524
			public bool bool_0;

			// Token: 0x040005F5 RID: 1525
			public ActiveUnit_AI activeUnit_AI_0;
		}

		// Token: 0x0200013A RID: 314
		[CompilerGenerated]
		internal sealed class Class178
		{
			// Token: 0x06000887 RID: 2183 RVA: 0x00007792 File Offset: 0x00005992
			internal float method_0(Weapon weapon_0)
			{
				return weapon_0.method_181(this.activeUnit_AI_0.activeUnit_0, this.activeUnit_AI_0.vmethod_3(), true, this.doctrine_0, false);
			}

			// Token: 0x040005F6 RID: 1526
			public Doctrine doctrine_0;

			// Token: 0x040005F7 RID: 1527
			public ActiveUnit_AI activeUnit_AI_0;
		}
	}
}
