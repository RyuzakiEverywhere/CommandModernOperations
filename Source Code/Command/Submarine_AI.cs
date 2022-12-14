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

namespace Command_Core
{
	// Token: 0x02000350 RID: 848
	public sealed class Submarine_AI : ActiveUnit_AI
	{
		// Token: 0x06001932 RID: 6450 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		private Submarine method_112()
		{
			if (this.submarine_0 == null)
			{
				this.submarine_0 = (Submarine)this.activeUnit_0;
			}
			return this.submarine_0;
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x0000CE01 File Offset: 0x0000B001
		public Submarine_AI(ref ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
			this.hashSet_1 = new HashSet<string>();
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x001C68F4 File Offset: 0x001C4AF4
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
				xmlWriter_0.WriteElementString("TTNPTE", this.float_1.ToString());
				xmlWriter_0.WriteElementString("PTOE", this.bool_0.ToString());
				xmlWriter_0.WriteElementString("FCLIO", this.bool_1.ToString());
				if (!this.bool_9)
				{
					xmlWriter_0.WriteElementString("ET_E", "False");
				}
				if (!this.bool_10)
				{
					xmlWriter_0.WriteElementString("DPT_E", "False");
				}
				xmlWriter_0.WriteElementString("DP", ((byte)this.method_114()).ToString());
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
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100815", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x001C6C44 File Offset: 0x001C4E44
		public static Submarine_AI smethod_1(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Submarine_AI result;
			try
			{
				Submarine_AI submarine_AI = new Submarine_AI(ref activeUnit_1);
				submarine_AI.activeUnit_0 = activeUnit_1;
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
						if (num <= 1610968176U)
						{
							if (num <= 684613497U)
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
										goto IL_4E6;
									}
									else
									{
										if (Operators.CompareString(name, "PrimaryTarget", false) == 0)
										{
											submarine_AI.contact_0 = Contact.smethod_0(xmlNode.InnerText, ref dictionary_0);
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
											if (num != 684613497U)
											{
												continue;
											}
											if (Operators.CompareString(name, "DP", false) == 0)
											{
												submarine_AI.method_115((ActiveUnit_AI.SubmarineDepthPreset)Conversions.ToByte(xmlNode.InnerText));
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
													Contact contact_ = Contact.smethod_1(ref xmlNode2, ref dictionary_0);
													Class429.smethod_13(ref submarine_AI.contact_2, contact_);
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
									if (Operators.CompareString(name, "PrimaryThreat", false) == 0)
									{
										submarine_AI.contact_1 = Contact.smethod_0(xmlNode.InnerText, ref dictionary_0);
										continue;
									}
									continue;
								}
							}
							else if (num <= 868927472U)
							{
								if (num != 866975591U)
								{
									if (num != 868927472U)
									{
										continue;
									}
									if (Operators.CompareString(name, "LKTL", false) == 0)
									{
										submarine_AI.geoPoint_0 = GeoPoint.smethod_0(ref xmlNode, ref dictionary_0);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "DPT_E", false) == 0)
									{
										submarine_AI.bool_10 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 1474882803U)
							{
								if (num != 1533721748U)
								{
									if (num != 1610968176U)
									{
										continue;
									}
									if (Operators.CompareString(name, "TTNPTE", false) == 0)
									{
										submarine_AI.float_1 = Conversions.ToSingle(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name, "PrimaryTargetOverride", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "IE", false) == 0)
								{
									submarine_AI.bool_2 = true;
									continue;
								}
								continue;
							}
						}
						else
						{
							if (num <= 2276842832U)
							{
								if (num <= 1966596370U)
								{
									if (num != 1925531877U)
									{
										if (num != 1966596370U)
										{
											continue;
										}
										if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Lon", false) == 0)
										{
											submarine_AI.method_5(XmlConvert.ToDouble(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else if (Operators.CompareString(name, "FerryCycleLegIsOutbound", false) != 0)
									{
										continue;
									}
								}
								else if (num != 2133975202U)
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
												if (!Information.IsNothing(targetingEntry.contact_0) && !submarine_AI.vmethod_0().ContainsKey(targetingEntry.contact_0.string_0))
												{
													submarine_AI.vmethod_0().Add(targetingEntry.contact_0.string_0, targetingEntry);
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
								else
								{
									if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Lat", false) == 0)
									{
										submarine_AI.method_3(XmlConvert.ToDouble(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								submarine_AI.bool_1 = Conversions.ToBoolean(xmlNode.InnerText);
								continue;
							}
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
							}
							else if (num != 3770421268U)
							{
								if (num != 3957045325U)
								{
									if (num != 4076649232U)
									{
										continue;
									}
									if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Alt", false) == 0)
									{
										submarine_AI.method_7(XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "IPC", false) == 0)
									{
										goto IL_4E6;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "ET_E", false) == 0)
								{
									submarine_AI.bool_9 = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						submarine_AI.bool_0 = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_4E6:
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
				result = submarine_AI;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100816", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Submarine_AI(ref activeUnit_1);
			}
			return result;
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x0000744E File Offset: 0x0000564E
		public override Contact vmethod_5()
		{
			return this.contact_1;
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x0000CE16 File Offset: 0x0000B016
		public override void vmethod_6(Contact contact_9)
		{
			if (this.contact_1 != contact_9)
			{
				this.contact_8 = this.contact_1;
			}
			this.contact_1 = contact_9;
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x0000CE34 File Offset: 0x0000B034
		public Contact method_113()
		{
			return this.contact_8;
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x0000CE3C File Offset: 0x0000B03C
		public ActiveUnit_AI.SubmarineDepthPreset method_114()
		{
			return this.submarineDepthPreset_0;
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x0000CE44 File Offset: 0x0000B044
		public void method_115(ActiveUnit_AI.SubmarineDepthPreset submarineDepthPreset_1)
		{
			this.submarineDepthPreset_0 = submarineDepthPreset_1;
			if (submarineDepthPreset_1 != ActiveUnit_AI.SubmarineDepthPreset.None)
			{
				this.activeUnit_0.vmethod_87().vmethod_13(true);
			}
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x001C72BC File Offset: 0x001C54BC
		public FuelRec._FuelType method_116(Engine engine_0)
		{
			Engine.Enum112 enum112_ = engine_0.enum112_0;
			FuelRec._FuelType result;
			if (enum112_ != Engine.Enum112.const_6)
			{
				if (enum112_ != Engine.Enum112.const_10)
				{
					if (enum112_ != Engine.Enum112.const_11)
					{
						result = FuelRec._FuelType.NoFuel;
					}
					else if (Enumerable.Count<Engine>(Enumerable.Where<Engine>(this.activeUnit_0.vmethod_49(), (Submarine_AI._Closure$__.$I19-0 == null) ? (Submarine_AI._Closure$__.$I19-0 = new Func<Engine, bool>(Submarine_AI._Closure$__.$I.method_0)) : Submarine_AI._Closure$__.$I19-0)) == 0)
					{
						result = FuelRec._FuelType.Battery;
					}
					else
					{
						result = FuelRec._FuelType.AirIndepedent;
					}
				}
				else
				{
					result = FuelRec._FuelType.Battery;
				}
			}
			else
			{
				result = FuelRec._FuelType.DieselFuel;
			}
			return result;
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x001C734C File Offset: 0x001C554C
		public Dictionary<int, Engine> method_117()
		{
			Dictionary<int, Engine> result;
			if (Information.IsNothing(this.activeUnit_0))
			{
				result = new Dictionary<int, Engine>();
			}
			else if (this.activeUnit_0.vmethod_49().Count == 0)
			{
				result = new Dictionary<int, Engine>();
			}
			else
			{
				Dictionary<int, Engine> dictionary = new Dictionary<int, Engine>();
				if (this.activeUnit_0.vmethod_49().Count == 1)
				{
					this.method_112().method_147(this.activeUnit_0.vmethod_49()[0]);
					this.method_112().method_149(0);
					dictionary.Add(0, this.activeUnit_0.vmethod_49()[0]);
					result = dictionary;
				}
				else
				{
					try
					{
						if (Math.Round((double)this.method_112().vmethod_14(false)) >= -20.0)
						{
							if (this.method_120())
							{
								if (!Information.IsNothing(this.method_112().vmethod_49()) && this.method_112().vmethod_49().Count > 0)
								{
									int num = this.method_112().vmethod_49().Count - 1;
									for (int i = 0; i <= num; i++)
									{
										Engine engine = this.method_112().vmethod_49()[i];
										if (engine.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed)
										{
											if (engine.enum112_0 == Engine.Enum112.const_6)
											{
												dictionary.Add(i, engine);
												this.method_112().method_147(engine);
												this.method_112().method_149(i);
											}
											if (engine.enum112_0 == Engine.Enum112.const_10)
											{
												dictionary.Add(i, engine);
											}
										}
									}
								}
							}
							else if (!Information.IsNothing(this.method_112().vmethod_49()) && this.method_112().vmethod_49().Count > 0)
							{
								int num2 = this.method_112().vmethod_49().Count - 1;
								for (int j = 0; j <= num2; j++)
								{
									Engine engine = this.method_112().vmethod_49()[j];
									if (engine.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed && engine.enum112_0 == Engine.Enum112.const_10)
									{
										dictionary.Add(j, engine);
										this.method_112().method_147(engine);
										this.method_112().method_149(j);
										break;
									}
								}
							}
						}
						else
						{
							if (!Information.IsNothing(this.method_112().vmethod_49()) && this.method_112().vmethod_49().Count > 0)
							{
								int num3 = this.method_112().vmethod_49().Count - 1;
								int k = 0;
								while (k <= num3)
								{
									Engine engine = this.method_112().vmethod_49()[k];
									if (engine.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed && engine.enum112_0 == Engine.Enum112.const_10)
									{
										dictionary.Add(k, engine);
										this.method_112().method_147(engine);
										this.method_112().method_149(k);
										IL_2BB:
										if (dictionary.Count == 0)
										{
											int num4 = this.method_112().vmethod_49().Count - 1;
											for (int l = 0; l <= num4; l++)
											{
												engine = this.method_112().vmethod_49()[l];
												if (engine.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed && engine.enum112_0 == Engine.Enum112.const_11)
												{
													dictionary.Add(l, engine);
													this.method_112().method_147(engine);
													this.method_112().method_149(l);
													break;
												}
											}
											goto IL_337;
										}
										goto IL_337;
									}
									else
									{
										k++;
									}
								}
								goto IL_2BB;
							}
							IL_337:
							if (this.method_112().method_169())
							{
								Doctrine._UseAIP? useAIP = this.activeUnit_0.doctrine_0.method_270(this.activeUnit_0.scenario_0, false, false, false);
								byte? b = (useAIP != null) ? new byte?((byte)useAIP.GetValueOrDefault()) : null;
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									if (!Information.IsNothing(this.method_112().vmethod_49()) && this.method_112().vmethod_49().Count > 0)
									{
										int num5 = this.method_112().vmethod_49().Count - 1;
										for (int m = 0; m <= num5; m++)
										{
											Engine engine = this.method_112().vmethod_49()[m];
											if (engine.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed && engine.enum112_0 == Engine.Enum112.const_11)
											{
												dictionary.Add(m, engine);
												break;
											}
										}
									}
								}
								else if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedDefensive || this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
								{
									b = ((useAIP != null) ? new byte?((byte)useAIP.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && !Information.IsNothing(this.method_112().vmethod_49()) && this.method_112().vmethod_49().Count > 0)
									{
										int num6 = this.method_112().vmethod_49().Count - 1;
										for (int n = 0; n <= num6; n++)
										{
											Engine engine = this.method_112().vmethod_49()[n];
											if (engine.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed && engine.enum112_0 == Engine.Enum112.const_11)
											{
												dictionary.Add(n, engine);
												break;
											}
										}
									}
								}
							}
						}
						result = dictionary;
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 100812", "");
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						result = new Dictionary<int, Engine>();
					}
				}
			}
			return result;
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x001C78F8 File Offset: 0x001C5AF8
		public override void vmethod_11(float float_4, bool bool_11, bool bool_12)
		{
			if (!Information.IsNothing(this.activeUnit_0))
			{
				try
				{
					Doctrine.Enum61? @enum = this.activeUnit_0.doctrine_0.method_137(this.activeUnit_0.scenario_0, false, false, false);
					byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						if (!Information.IsNothing(this.contact_1))
						{
							if (this.contact_1.contactType_0 == Contact_Base.ContactType.Torpedo)
							{
								if (this.activeUnit_0.method_36(this.contact_1) < 3f)
								{
									this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedDefensive);
									return;
								}
								if (this.activeUnit_0.method_36(this.contact_1) < 10f && base.method_67(ref this.contact_1) < 90f)
								{
									this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedDefensive);
									return;
								}
							}
							else
							{
								Submarine._SubmarineType submarineType_ = this.method_112()._SubmarineType_0;
								if (submarineType_ - Submarine._SubmarineType.SSB <= 1 && this.method_112().method_36(this.contact_1) < 30f)
								{
									this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedDefensive);
									return;
								}
							}
						}
						else if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
						{
							this.activeUnit_0.vmethod_109(this.activeUnit_0._ActiveUnitStatus_3);
						}
					}
					if (this.activeUnit_0.vmethod_90().method_3())
					{
						this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.AttemptingToReestablishComms);
					}
					else
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
							if (!this.activeUnit_0.scenario_0.FifteenthSecondIsChangingOnThisPulse || this.activeUnit_0.method_85() || !base.method_84())
							{
								if (this.activeUnit_0.vmethod_85().method_46())
								{
									if (Information.IsNothing(this.vmethod_3()))
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
										return;
									}
									Doctrine.Enum64? enum2 = this.activeUnit_0.doctrine_0.method_83(this.activeUnit_0.scenario_0, false, null, false, false);
									b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
										return;
									}
								}
								if (!Information.IsNothing(this.vmethod_3()))
								{
									Contact_Base.ContactType contactType_ = this.vmethod_3().contactType_0;
									if (contactType_ > Contact_Base.ContactType.Missile)
									{
										bool flag = true;
										if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
										{
											Strike strike = (Strike)this.activeUnit_0.vmethod_101();
											if (strike.int_13 > 0 || strike.int_12 > 0)
											{
												float num = Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.vmethod_3().vmethod_30(null), this.vmethod_3().vmethod_28(null));
												if (num > (float)strike.int_13 || num < (float)strike.int_12)
												{
													flag = false;
												}
											}
										}
										if (flag)
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
										this.vmethod_10(float_4, false, true);
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
												this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
												return;
											}
											this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPatrol);
											return;
										case Mission._MissionClass.Support:
											if (!Information.IsNothing(this.vmethod_3()))
											{
												this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
												return;
											}
											this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnSupportMission);
											return;
										case Mission._MissionClass.Ferry:
											if (!Information.IsNothing(this.vmethod_3()))
											{
												this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
												return;
											}
											this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnFerryMission);
											return;
										case Mission._MissionClass.Mining:
											this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Tasked);
											return;
										case Mission._MissionClass.MineClearing:
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
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 200347", ex2.Message);
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x001C7EF8 File Offset: 0x001C60F8
		public override bool vmethod_20(double double_4, double double_5, float float_4, float float_5, float float_6, float float_7, float float_8, float? nullable_10, bool bool_11, bool bool_12)
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
						num2 = float_7;
						if (float_7 <= 0f || double.IsNaN((double)float_7))
						{
							return false;
						}
					}
					else
					{
						if (bool_12)
						{
							num2 = this.activeUnit_0.method_38(double_4, double_5, float_4, float_5, float_7, float_8);
						}
						else
						{
							float float_9 = Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), double_4, double_5);
							num2 = this.activeUnit_0.method_38(double_4, double_5, float_4, float_5, float_7, float_9);
						}
						if (num2 <= 0f || double.IsNaN((double)num2))
						{
							return false;
						}
					}
					long num3 = (long)Math.Round((double)(num / num2 * 3600f));
					float? num4 = (float)this.method_112().method_154().vmethod_36(float_7, float_6, true, false) * (1f + nullable_10);
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

		// Token: 0x0600193F RID: 6463 RVA: 0x0000870C File Offset: 0x0000690C
		private Weapon[] method_118()
		{
			return this.activeUnit_0.vmethod_89().vmethod_4().ToArray();
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x001C80EC File Offset: 0x001C62EC
		public override void vmethod_10(float float_4, bool bool_11, bool bool_12)
		{
			if (this.bool_9)
			{
				try
				{
					if (this.activeUnit_0 != null)
					{
						if (!this.method_112().method_142())
						{
							if (!this.method_112().method_143())
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
									base.vmethod_10(float_4, bool_11, bool_12);
									if (!Information.IsNothing(this.activeUnit_0))
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
												if (!Information.IsNothing(contact2) && (this.activeUnit_0.vmethod_7(false).method_75(ref this.activeUnit_0, ref contact2) <= 0 || base.method_20(contact2) != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc))
												{
													try
													{
														foreach (NoNavZone noNavZone in Enumerable.Where<NoNavZone>(this.activeUnit_0.vmethod_7(false).list_7, new Func<NoNavZone, bool>(this.method_127)))
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
										Lazy<Weapon[]> lazy = new Lazy<Weapon[]>(new Func<Weapon[]>(this.method_118));
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
													Contact.Enum47? enum2 = contact.method_74(this.activeUnit_0.vmethod_7(false));
													byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
													if (!((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
													{
														Misc.PostureStance postureStance;
														if (this.tuple_0[k] != null)
														{
															postureStance = this.tuple_0[k].Item2;
														}
														else
														{
															if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(contact.string_0, out postureStance))
															{
																postureStance = contact.method_130(this.activeUnit_0.vmethod_7(false));
															}
															this.tuple_0[k] = new Tuple<Contact, Misc.PostureStance>(contact, postureStance);
														}
														Contact contact4 = contact;
														Mission mission_ = mission;
														Doctrine.Enum59? nullable_ = @enum;
														bool bool_13 = flag;
														bool bool_14 = true;
														Misc.PostureStance? nullable_2 = new Misc.PostureStance?(postureStance);
														string text = "";
														num2 = 0;
														if (base.method_39(contact4, mission_, nullable_, bool_11, bool_13, bool_14, nullable_2, ref text, ref num2))
														{
															switch (postureStance)
															{
															case Misc.PostureStance.Unfriendly:
															case Misc.PostureStance.Hostile:
															{
																ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
																Contact theTarget = contact;
																bool checkWRA = true;
																Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
																text = "";
																num2 = 0;
																if (activeUnit_Weaponry.method_6(theTarget, checkWRA, doctrine_, ref text, ref num2, lazy.Value) && (contact.contactType_0 != Contact_Base.ContactType.Submarine || !contact.method_72()))
																{
																	if (contact.bool_18 && contact.bool_17 && contact.vmethod_40() > 0f && this.activeUnit_0.vmethod_40() > 0f)
																	{
																		if (base.method_48(contact, true))
																		{
																			this.vmethod_12(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
																			this.hashSet_1.Add(contact.string_0);
																		}
																	}
																	else
																	{
																		this.vmethod_12(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
																		this.hashSet_1.Add(contact.string_0);
																	}
																}
																break;
															}
															case Misc.PostureStance.Unknown:
																if (contact.bool_18 && contact.bool_17 && contact.vmethod_40() > 0f && this.activeUnit_0.vmethod_40() > 0f)
																{
																	if (base.method_48(contact, true))
																	{
																		this.vmethod_12(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
																		this.hashSet_1.Add(contact.string_0);
																	}
																}
																else
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
											if (!this.hashSet_1.Contains(contact.string_0) && !list2.Contains(contact))
											{
												Misc.PostureStance postureStance;
												if (this.tuple_0[l] != null)
												{
													postureStance = this.tuple_0[l].Item2;
												}
												else if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(contact.string_0, out postureStance))
												{
													postureStance = contact.method_130(this.activeUnit_0.vmethod_7(false));
												}
												if (postureStance != Misc.PostureStance.Neutral && postureStance != Misc.PostureStance.Friendly)
												{
													Contact.Enum47? enum2 = contact.method_74(this.activeUnit_0.vmethod_7(false));
													byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
													if (!((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault() && base.method_48(contact, true))
													{
														if (!flag2 && !Information.IsNothing(mission) && mission._MissionClass_0 == Mission._MissionClass.Patrol && !contact.method_106() && !((Class343)mission).method_66(this.activeUnit_0.scenario_0))
														{
															Class343 class2 = (Class343)mission;
															if (!contact.vmethod_46(class2.list_5, this.activeUnit_0.scenario_0, true) && base.method_20(contact) != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc && !this.activeUnit_0.vmethod_88().method_40(contact))
															{
																goto IL_8D3;
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
											IL_8D3:;
										}
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100815", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x001C8A94 File Offset: 0x001C6C94
		internal void method_119()
		{
			if (this.method_112().vmethod_72() > this.method_112().vmethod_14(false))
			{
				if (this.method_112().vmethod_72() > this.method_112().vmethod_14(false) + 150f)
				{
					this.method_112().vmethod_23(30f);
					return;
				}
				this.method_112().vmethod_23((this.method_112().vmethod_72() - this.method_112().vmethod_14(false)) / 5f);
				return;
			}
			else
			{
				if (this.method_112().vmethod_72() >= this.method_112().vmethod_14(false))
				{
					this.method_112().vmethod_23(0f);
					return;
				}
				if (this.method_112().vmethod_72() < this.method_112().vmethod_14(false) - 150f)
				{
					this.method_112().vmethod_23(-30f);
					return;
				}
				this.method_112().vmethod_23((this.method_112().vmethod_72() - this.method_112().vmethod_14(false)) / 5f);
				return;
			}
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x001C8B98 File Offset: 0x001C6D98
		public override void vmethod_23(float float_4)
		{
			if (this.activeUnit_0 != null && this.vmethod_5() != null)
			{
				try
				{
					float num = (float)Math.Round((double)Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.vmethod_5().vmethod_30(null), this.vmethod_5().vmethod_28(null)), 0);
					if (!float.IsNegativeInfinity(num))
					{
						Contact_Base.ContactType contactType_ = this.vmethod_5().contactType_0;
						if (contactType_ - Contact_Base.ContactType.Surface > 1)
						{
							if (contactType_ == Contact_Base.ContactType.Torpedo)
							{
								int num2 = (int)Math.Round((double)num);
								base.method_72(ref num2);
								if (this.method_112().method_160())
								{
									this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
									this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_87().vmethod_31());
								}
							}
						}
						else
						{
							if (!Information.IsNothing(this.method_113()) && (double)Math.Abs(this.method_113().method_36(this.activeUnit_0) - this.vmethod_5().method_36(this.activeUnit_0)) < 0.5)
							{
								float num3 = (float)Math.Round((double)Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.method_113().vmethod_30(null), this.method_113().vmethod_28(null)), 0);
								double x = Math.Cos(0.0174532925199433 * (double)num) + Math.Cos(0.0174532925199433 * (double)num3);
								double y = Math.Sin(0.0174532925199433 * (double)num) + Math.Sin(0.0174532925199433 * (double)num3);
								num = (float)(57.2957795130823 * Math.Atan2(y, x));
							}
							int num2 = (int)Math.Round((double)num);
							base.method_72(ref num2);
							if (this.vmethod_5().bool_17 && this.method_112().method_160())
							{
								this.method_112().vmethod_71(this.vmethod_5().vmethod_40());
							}
							else
							{
								this.method_112().vmethod_134(ActiveUnit.Throttle.Loiter, null);
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100816", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x001C8E50 File Offset: 0x001C7050
		public override void vmethod_18()
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (base.method_15().Length == 0)
					{
						this.vmethod_6(null);
					}
					else
					{
						IEnumerable<Contact> enumerable = Enumerable.OrderBy<Contact, double>(Enumerable.Select<Contact, Contact>(Enumerable.Where<Contact>(base.method_15(), (Submarine_AI._Closure$__.$I28-0 == null) ? (Submarine_AI._Closure$__.$I28-0 = new Func<Contact, bool>(Submarine_AI._Closure$__.$I.method_1)) : Submarine_AI._Closure$__.$I28-0), (Submarine_AI._Closure$__.$I28-1 == null) ? (Submarine_AI._Closure$__.$I28-1 = new Func<Contact, Contact>(Submarine_AI._Closure$__.$I.method_2)) : Submarine_AI._Closure$__.$I28-1), new Func<Contact, double>(this.method_128));
						if (Enumerable.Count<Contact>(enumerable) > 0)
						{
							this.vmethod_6(Enumerable.ElementAtOrDefault<Contact>(enumerable, 0));
						}
						else
						{
							IEnumerable<Contact> enumerable2 = Enumerable.OrderBy<Contact, double>(Enumerable.Select<Contact, Contact>(base.method_15(), (Submarine_AI._Closure$__.$I28-3 == null) ? (Submarine_AI._Closure$__.$I28-3 = new Func<Contact, Contact>(Submarine_AI._Closure$__.$I.method_3)) : Submarine_AI._Closure$__.$I28-3), new Func<Contact, double>(this.method_129));
							this.vmethod_6(Enumerable.ElementAtOrDefault<Contact>(enumerable2, 0));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100817", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x001C8FA0 File Offset: 0x001C71A0
		public override void vmethod_25()
		{
			if (!Information.IsNothing(this.activeUnit_0) && !this.method_112().method_142() && !this.method_112().method_143())
			{
				try
				{
					base.method_34();
					try
					{
						foreach (Contact contact in base.method_0())
						{
							if (!contact.method_124(this.activeUnit_0.scenario_0))
							{
								if (contact.method_125() >= Contact_Base.IdentificationStatus.KnownType && !Information.IsNothing(contact.activeUnit_0) && contact.activeUnit_0.bool_5)
								{
									Submarine submarine = (Submarine)contact.activeUnit_0;
									if (submarine._SubmarineType_0 == Submarine._SubmarineType.Biologics || submarine._SubmarineType_0 == Submarine._SubmarineType.FalseTarget)
									{
										continue;
									}
								}
								if (!Information.IsNothing(contact.activeUnit_0))
								{
									Misc.PostureStance postureStance;
									if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(contact.string_0, out postureStance))
									{
										postureStance = contact.method_130(this.activeUnit_0.vmethod_7(false));
									}
									if (postureStance != Misc.PostureStance.Friendly && contact.activeUnit_0.bool_2)
									{
										Weapon._WeaponType weaponType = ((Weapon)contact.activeUnit_0).method_167();
										if (weaponType == Weapon._WeaponType.Torpedo)
										{
											this.vmethod_13(contact);
											Weapon weapon = this.activeUnit_0.vmethod_89().method_57();
											if (weapon == null)
											{
												continue;
											}
											ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
											Contact theTarget = contact;
											bool checkWRA = true;
											Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
											string text = "";
											int num = 0;
											if (activeUnit_Weaponry.method_6(theTarget, checkWRA, doctrine_, ref text, ref num, null) && (double)this.activeUnit_0.method_37(contact, 0f) < 1.5 * (double)weapon.float_35)
											{
												this.vmethod_12(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
												continue;
											}
											continue;
										}
									}
									Contact_Base.ContactType contactType_ = contact.contactType_0;
									if (contactType_ != Contact_Base.ContactType.Surface)
									{
										if (contactType_ - Contact_Base.ContactType.Submarine <= 1 && !contact.method_72() && (postureStance == Misc.PostureStance.Hostile || postureStance == Misc.PostureStance.Unfriendly || postureStance == Misc.PostureStance.Unknown))
										{
											this.vmethod_13(contact);
										}
									}
									else
									{
										Ship ship = (Ship)contact.activeUnit_0;
										if (contact.method_125() >= Contact_Base.IdentificationStatus.KnownType)
										{
											Ship.Enum118 enum118_ = ship.enum118_0;
											if ((enum118_ - Ship.Enum118.const_2 <= 1 || enum118_ - Ship.Enum118.const_7 <= 1) && (postureStance == Misc.PostureStance.Hostile || postureStance == Misc.PostureStance.Unfriendly))
											{
												this.vmethod_13(contact);
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
					ex.Data.Add("Error at 100818", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x001C9260 File Offset: 0x001C7460
		public static float smethod_2(ActiveUnit activeUnit_1)
		{
			return (float)Math.Min(Class568.smethod_2(activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), activeUnit_1.method_9(false, false, false)).int_0 + 10, -25);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x001C92AC File Offset: 0x001C74AC
		public static float smethod_3(ActiveUnit activeUnit_1)
		{
			return (float)Math.Min(Class568.smethod_2(activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), activeUnit_1.method_9(false, false, false)).int_1 - 10, -25);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x001C92F8 File Offset: 0x001C74F8
		public bool method_120()
		{
			return Math.Round((double)this.method_112().vmethod_14(false)) < -20.0 || (Math.Round((double)this.method_112().vmethod_72()) >= -20.0 && Enumerable.Count<Engine>(Enumerable.Where<Engine>(this.method_112().vmethod_49(), (Submarine_AI._Closure$__.$I32-0 == null) ? (Submarine_AI._Closure$__.$I32-0 = new Func<Engine, bool>(Submarine_AI._Closure$__.$I.method_4)) : Submarine_AI._Closure$__.$I32-0)) != 0 && Enumerable.Count<Engine>(Enumerable.Where<Engine>(this.method_112().vmethod_49(), (Submarine_AI._Closure$__.$I32-1 == null) ? (Submarine_AI._Closure$__.$I32-1 = new Func<Engine, bool>(Submarine_AI._Closure$__.$I.method_5)) : Submarine_AI._Closure$__.$I32-1)) != 0);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x001C93D0 File Offset: 0x001C75D0
		private bool method_121(float float_4)
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
					if (this.method_112().method_160())
					{
						result = false;
					}
					else
					{
						FuelRec fuelRec = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Where<FuelRec>(this.method_112().vmethod_67(), (Submarine_AI._Closure$__.$I33-0 == null) ? (Submarine_AI._Closure$__.$I33-0 = new Func<FuelRec, bool>(Submarine_AI._Closure$__.$I.method_6)) : Submarine_AI._Closure$__.$I33-0), 0);
						if ((Information.IsNothing(fuelRec) || fuelRec.float_0 <= 0f) && this.method_112().method_169())
						{
							fuelRec = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Where<FuelRec>(this.method_112().vmethod_67(), (Submarine_AI._Closure$__.$I33-1 == null) ? (Submarine_AI._Closure$__.$I33-1 = new Func<FuelRec, bool>(Submarine_AI._Closure$__.$I.method_7)) : Submarine_AI._Closure$__.$I33-1), 0);
						}
						if (!Information.IsNothing(fuelRec) && fuelRec.float_0 > 0f)
						{
							FuelRec fuelRec2 = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Where<FuelRec>(this.method_112().vmethod_67(), (Submarine_AI._Closure$__.$I33-2 == null) ? (Submarine_AI._Closure$__.$I33-2 = new Func<FuelRec, bool>(Submarine_AI._Closure$__.$I.method_8)) : Submarine_AI._Closure$__.$I33-2), 0);
							if (!Information.IsNothing(fuelRec2))
							{
								double num = (double)fuelRec2.method_9();
								if (num == 0.0)
								{
									result = true;
								}
								else if (num <= (double)(float_4 / 100f))
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
								result = false;
							}
						}
						else
						{
							this.method_112().method_165();
							result = false;
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100820", "");
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

		// Token: 0x06001949 RID: 6473 RVA: 0x001C958C File Offset: 0x001C778C
		public bool method_122(bool bool_11, ActiveUnit_DockingOps._DockingOpsCondition? nullable_10)
		{
			bool result;
			if (Information.IsNothing(this.activeUnit_0))
			{
				result = false;
			}
			else if (this.method_112().method_160())
			{
				result = false;
			}
			else
			{
				try
				{
					double num = (double)this.activeUnit_0.doctrine_0.method_264(this.activeUnit_0.scenario_0, false, false, false).Value / 100.0;
					FuelRec fuelRec = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Where<FuelRec>(this.method_112().vmethod_67(), (Submarine_AI._Closure$__.$I34-0 == null) ? (Submarine_AI._Closure$__.$I34-0 = new Func<FuelRec, bool>(Submarine_AI._Closure$__.$I.method_9)) : Submarine_AI._Closure$__.$I34-0), 0);
					if (Information.IsNothing(fuelRec))
					{
						this.method_112().method_165();
						result = false;
					}
					else
					{
						double num2 = (double)fuelRec.method_9();
						if (num2 < num)
						{
							result = true;
						}
						else
						{
							if (Information.IsNothing(nullable_10))
							{
								nullable_10 = new ActiveUnit_DockingOps._DockingOpsCondition?(this.method_112().vmethod_93().method_8());
							}
							byte? b = (nullable_10 != null) ? new byte?((byte)nullable_10.GetValueOrDefault()) : null;
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 9) : null).GetValueOrDefault())
							{
								double num3 = (double)this.activeUnit_0.doctrine_0.method_258(this.activeUnit_0.scenario_0, false, false, false).Value / 100.0;
								if (num2 < num3)
								{
									return true;
								}
							}
							result = this.method_123(bool_11, nullable_10, num, num2);
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100822", "");
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

		// Token: 0x0600194A RID: 6474 RVA: 0x001C9778 File Offset: 0x001C7978
		public bool method_123(bool bool_11, ActiveUnit_DockingOps._DockingOpsCondition? nullable_10, double double_4, double double_5)
		{
			bool result;
			try
			{
				if (this.method_112().method_142())
				{
					result = true;
				}
				else if (this.method_112().method_143())
				{
					result = false;
				}
				else
				{
					if (!this.method_112().method_160())
					{
						if (double_4 < 0.0)
						{
							double_4 = (double)this.activeUnit_0.doctrine_0.method_264(this.activeUnit_0.scenario_0, false, false, false).Value / 100.0;
						}
						if (double_5 < 0.0)
						{
							double_5 = (double)Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Where<FuelRec>(this.method_112().vmethod_67(), (Submarine_AI._Closure$__.$I35-0 == null) ? (Submarine_AI._Closure$__.$I35-0 = new Func<FuelRec, bool>(Submarine_AI._Closure$__.$I.method_10)) : Submarine_AI._Closure$__.$I35-0), 0).method_9();
						}
					}
					Doctrine._DiveOnContact? diveOnContact = this.activeUnit_0.doctrine_0.method_252(this.activeUnit_0.scenario_0, false, false, false);
					byte? b = (diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null;
					bool? flag2;
					bool? flag = flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null);
					bool? flag3;
					bool? flag4;
					if (flag2 != null && flag.GetValueOrDefault())
					{
						flag3 = new bool?(true);
					}
					else
					{
						b = ((diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
						flag4 = (flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null));
						flag3 = ((flag2 != null) ? (flag | flag4.GetValueOrDefault()) : null);
					}
					flag4 = flag3;
					bool value = flag4.Value;
					b = ((diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
					flag4 = (flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null));
					bool? flag5;
					if (flag2 != null && flag4.GetValueOrDefault())
					{
						flag5 = new bool?(true);
					}
					else
					{
						b = ((diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null);
						flag = (flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null));
						flag5 = ((flag2 != null) ? (flag4 | flag.GetValueOrDefault()) : null);
					}
					flag = flag5;
					bool value2 = flag.Value;
					if (this.activeUnit_0.float_24 < 1800f && value)
					{
						if (Math.Round((double)this.activeUnit_0.vmethod_72()) >= -20.0)
						{
							string str = "";
							if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
							{
								str = " (" + this.activeUnit_0.string_2 + ")";
							}
							if (this.activeUnit_0.vmethod_87().vmethod_12())
							{
								this.activeUnit_0.scenario_0.method_59("Submarine: " + this.activeUnit_0.Name + str + " has been ordered to periscope depth or surface, but the doctrine has been set to dive on threat proximity. The submarine will now dive. To allow the sub to come to periscope depth or surface, change the Dive when threat is detected doctrine setting to No.", this.activeUnit_0.Name + " dives (nearby threats!)", LoggedMessage.MessageType.SpecialMessage, 0, null, this.activeUnit_0.vmethod_7(false), default(Geopoint_Struct));
							}
						}
						if (this.method_112().method_160())
						{
							return false;
						}
						if (!bool_11 && double_4 <= double_5)
						{
							this.method_112().method_165();
							return false;
						}
					}
					if (value2)
					{
						try
						{
							foreach (Contact contact in base.method_0())
							{
								Misc.PostureStance postureStance;
								if (!this.activeUnit_0.vmethod_7(false).dictionary_4.TryGetValue(contact.string_0, out postureStance))
								{
									postureStance = contact.method_130(this.activeUnit_0.vmethod_7(false));
								}
								if (contact.method_125() > Contact_Base.IdentificationStatus.KnownType)
								{
									if (contact.method_136() && !Information.IsNothing(contact.activeUnit_0) && contact.activeUnit_0.bool_5)
									{
										Submarine submarine = (Submarine)contact.activeUnit_0;
										if (submarine._SubmarineType_0 == Submarine._SubmarineType.Biologics || submarine._SubmarineType_0 == Submarine._SubmarineType.FalseTarget)
										{
											continue;
										}
									}
									if (postureStance != Misc.PostureStance.Friendly && postureStance != Misc.PostureStance.Neutral)
									{
										Contact_Base.ContactType contactType_ = contact.contactType_0;
										int num;
										if (contactType_ != Contact_Base.ContactType.Air)
										{
											if (contactType_ - Contact_Base.ContactType.Surface > 1 && contactType_ != Contact_Base.ContactType.Sonobuoy)
											{
												continue;
											}
											num = 20;
										}
										else
										{
											num = 30;
										}
										if (this.method_112().method_36(contact) < (float)num)
										{
											if (!this.method_112().method_160())
											{
												this.method_112().method_165();
											}
											if (Math.Round((double)this.activeUnit_0.vmethod_72()) >= -20.0)
											{
												string str2 = "";
												if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
												{
													str2 = " (" + this.activeUnit_0.string_2 + ")";
												}
												if (this.activeUnit_0.vmethod_87().vmethod_12())
												{
													this.activeUnit_0.scenario_0.method_59("Submarine: " + this.activeUnit_0.Name + str2 + " has been ordered to periscope depth or surface, but the doctrine has been configured to order the submarine to dive when threats are nearby. The submarine will now dive. To allow the sub to come to periscope depth or surface, change the Dive when threat is detected doctrine to No.", this.activeUnit_0.Name + " dives (nearby threats!)", LoggedMessage.MessageType.SpecialMessage, 0, null, this.activeUnit_0.vmethod_7(false), default(Geopoint_Struct));
												}
											}
											return false;
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
					result = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101280", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x001C9DB8 File Offset: 0x001C7FB8
		public bool method_124(float float_4, bool bool_11, bool bool_12)
		{
			ActiveUnit_DockingOps._DockingOpsCondition dockingOpsCondition = this.method_112().vmethod_93().method_8();
			bool result;
			if (dockingOpsCondition == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
			{
				if (!this.method_122(bool_12, new ActiveUnit_DockingOps._DockingOpsCondition?(dockingOpsCondition)))
				{
					this.method_112().vmethod_73(-40f);
					result = false;
				}
				else
				{
					if (Math.Round((double)this.method_112().vmethod_72()) < -20.0)
					{
						this.method_112().vmethod_73(-20f);
					}
					result = true;
				}
			}
			else
			{
				try
				{
					if (Information.IsNothing(this.activeUnit_0))
					{
						result = false;
					}
					else if (this.method_112().method_160())
					{
						result = false;
					}
					else
					{
						this.method_112().vmethod_72();
						if (this.method_121(float_4) && (bool_12 || this.method_122(bool_12, null)))
						{
							this.method_112().vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries);
							if (Math.Round((double)this.method_112().vmethod_72()) < -20.0)
							{
								this.method_112().vmethod_73(-20f);
							}
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
					ex.Data.Add("Error at 100823", "");
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

		// Token: 0x0600194C RID: 6476 RVA: 0x001C9F18 File Offset: 0x001C8118
		private void method_125(float float_4)
		{
			if (this.activeUnit_0 != null && this.activeUnit_0.vmethod_101() != null && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
			{
				try
				{
					if (this.method_112().vmethod_93().method_8() != ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
					{
						Class343 @class = (Class343)this.activeUnit_0.vmethod_101();
						if (@class.imethod_28() != null)
						{
							float value;
							if (!this.activeUnit_0.vmethod_46(@class.list_5, this.activeUnit_0.scenario_0, false))
							{
								if (@class.imethod_26() != null)
								{
									value = @class.imethod_26().Value;
								}
								else
								{
									value = @class.imethod_28().Value;
								}
							}
							if (Math.Round((double)value) >= -20.0 && !this.method_122(false, null))
							{
								this.activeUnit_0.vmethod_73(-40f);
							}
							else
							{
								this.activeUnit_0.vmethod_73(value);
							}
						}
						else
						{
							switch (@class.patrolType_0)
							{
							case GlobalVariables.PatrolType.ASW:
							case GlobalVariables.PatrolType.ASuW_Naval:
							case GlobalVariables.PatrolType.SeaControl:
								this.float_3 -= float_4;
								if (this.float_3 <= 0f)
								{
									this.float_3 = (float)GameGeneral.smethod_5().Next(1, 901);
									Class568.Class569 class2 = Class568.smethod_2(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), (int)Terrain.smethod_7(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), false));
									int num = -40;
									int num2;
									if (this.activeUnit_0.vmethod_88().method_2())
									{
										num2 = class2.int_0 + 10;
									}
									else
									{
										num2 = class2.int_1 - 10;
									}
									if (num < num2)
									{
										num = num2 + 1;
									}
									if (GameGeneral.smethod_5().Next(1, 101) < 50)
									{
										this.activeUnit_0.vmethod_73((float)num);
									}
									else
									{
										this.activeUnit_0.vmethod_73((float)num2);
									}
								}
								break;
							case GlobalVariables.PatrolType.AAW:
							case GlobalVariables.PatrolType.ASuW_Land:
							case GlobalVariables.PatrolType.ASuW_Mixed:
							case GlobalVariables.PatrolType.SEAD:
								if (@class.imethod_28() != null)
								{
									if (Math.Round((double)@class.imethod_28().Value) >= -20.0 && !this.method_122(false, null))
									{
										this.activeUnit_0.vmethod_73(-40f);
									}
									else
									{
										this.activeUnit_0.vmethod_73(-20f);
									}
								}
								else
								{
									this.activeUnit_0.vmethod_73(-40f);
								}
								break;
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100824", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x001CA234 File Offset: 0x001C8434
		public override void vmethod_26(float float_4)
		{
			if (this.activeUnit_0 != null)
			{
				try
				{
					ActiveUnit._ActiveUnitStatus activeUnitStatus = this.activeUnit_0.vmethod_108();
					if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
					{
						int value = (int)this.activeUnit_0.doctrine_0.method_264(this.activeUnit_0.scenario_0, false, false, false).Value;
						if (!this.method_124((float)value, true, true))
						{
							this.activeUnit_0.vmethod_87().vmethod_11(null);
							this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
						}
						this.vmethod_23(float_4);
					}
					else if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.AttemptingToReestablishComms)
					{
						this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
						this.method_115(ActiveUnit_AI.SubmarineDepthPreset.Shallow);
						this.vmethod_28(true);
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
							if (!Information.IsNothing(this.activeUnit_0.vmethod_93().method_6()) && list.Contains(this.activeUnit_0.vmethod_93().method_6()))
							{
								flag = (this.activeUnit_0.vmethod_93().method_55(this.activeUnit_0.vmethod_93().method_6()) == ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Success || this.activeUnit_0.vmethod_93().method_54(intermediateTargetPoint, null, null, false, new int?(100)).Item1 == ActiveUnit_DockingOps.Enum32.const_1);
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
						if (!Information.IsNothing(this.activeUnit_0.vmethod_93().method_6()) && flag)
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
									Contact_Base.ContactType contactType_ = this.vmethod_3().contactType_0;
									if (contactType_ > Contact_Base.ContactType.Missile && contactType_ != Contact_Base.ContactType.Orbital)
									{
										this.vmethod_19(float_4);
									}
									float? num2 = null;
									float num3 = float.MaxValue;
									int value2 = (int)this.activeUnit_0.doctrine_0.method_264(this.activeUnit_0.scenario_0, false, false, false).Value;
									Class343 @class;
									if (!this.method_124((float)value2, true, true) && this.activeUnit_0.vmethod_87().vmethod_10() == null)
									{
										ActiveUnit.Throttle? throttle;
										if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
										{
											@class = (Class343)this.activeUnit_0.vmethod_101();
											if (!Information.IsNothing(@class.imethod_24()))
											{
												num2 = @class.imethod_32();
												if (!Information.IsNothing(num2))
												{
													num3 = this.activeUnit_0.method_36(this.vmethod_3());
													if (((num2 != null) ? new bool?(num3 > num2.GetValueOrDefault()) : null).GetValueOrDefault())
													{
														throttle = new ActiveUnit.Throttle?(@class.imethod_20());
													}
													else
													{
														throttle = @class.imethod_24();
													}
												}
												else
												{
													throttle = @class.imethod_24();
												}
											}
										}
										if (!Information.IsNothing(throttle))
										{
											this.activeUnit_0.vmethod_134(throttle.Value, null);
										}
										else if (!this.vmethod_3().method_108() && !this.vmethod_3().method_136())
										{
											this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
										}
										else
										{
											int? num4 = base.method_62(this.vmethod_3().activeUnit_0);
											if (this.vmethod_3().bool_18 && this.vmethod_3().bool_17)
											{
												float num5 = Math.Abs(Class437.smethod_11(this.method_112().method_32(this.vmethod_3()), this.vmethod_3().vmethod_9()));
												if (num5 < 20f)
												{
													if (num4 != null)
													{
														this.activeUnit_0.vmethod_71(Math.Max((float)num4.Value, this.vmethod_3().vmethod_40() * 2f + 1f));
													}
													else
													{
														this.activeUnit_0.vmethod_71(this.vmethod_3().vmethod_40() * 2f + 1f);
													}
													this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_87().vmethod_41(this.activeUnit_0.vmethod_14(false), (float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), null);
												}
												else if (num5 < 90f)
												{
													if (num4 != null)
													{
														this.activeUnit_0.vmethod_71(Math.Max((float)num4.Value, this.vmethod_3().vmethod_40() * 2f + 1f));
													}
													else
													{
														this.activeUnit_0.vmethod_71((float)((double)this.vmethod_3().vmethod_40() * 1.5) + 1f);
													}
													this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_87().vmethod_41(this.activeUnit_0.vmethod_14(false), (float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), null);
												}
												else if (num4 != null)
												{
													this.activeUnit_0.vmethod_71((float)num4.Value);
													this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_87().vmethod_41(this.activeUnit_0.vmethod_14(false), (float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), null);
												}
												else
												{
													this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
												}
											}
											else if (this.vmethod_3().bool_18 && this.vmethod_3().bool_17)
											{
												if (this.activeUnit_0.method_39(this.vmethod_3(), this.activeUnit_0.vmethod_40(), this.activeUnit_0.vmethod_9()) > 0f)
												{
													this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
												}
												else
												{
													this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Full, null);
												}
											}
											else
											{
												this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
											}
										}
									}
									if (!this.activeUnit_0.vmethod_87().vmethod_12() && this.method_112().vmethod_93().method_8() != ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
									{
										float? num6 = null;
										if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
										{
											if (Information.IsNothing(@class))
											{
												@class = (Class343)this.activeUnit_0.vmethod_101();
											}
											if (!Information.IsNothing(@class.imethod_30()))
											{
												if (Information.IsNothing(num2))
												{
													num2 = @class.imethod_32();
												}
												if (!Information.IsNothing(num2))
												{
													if (num3 == 3.4028235E+38f)
													{
														num3 = this.activeUnit_0.method_36(this.vmethod_3());
													}
													if (((num2 != null) ? new bool?(num3 > num2.GetValueOrDefault()) : null).GetValueOrDefault())
													{
														num6 = @class.imethod_26();
													}
													else
													{
														num6 = @class.imethod_30();
													}
												}
												else
												{
													num6 = @class.imethod_30();
												}
											}
										}
										if (!Information.IsNothing(num6))
										{
											float value3 = num6.Value;
											if (Math.Round((double)value3) >= -20.0 && !this.method_122(false, null))
											{
												this.activeUnit_0.vmethod_73(-40f);
											}
											else
											{
												this.activeUnit_0.vmethod_73(value3);
											}
										}
										else
										{
											if ((float)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), this.activeUnit_0.vmethod_84(), false) < this.activeUnit_0.vmethod_70())
											{
												if (this.activeUnit_0.float_24 < 1800f && !this.method_122(false, null))
												{
													this.activeUnit_0.vmethod_73(-40f);
												}
												else
												{
													int num7 = 1;
													do
													{
														ActiveUnit.Throttle throttle2 = (ActiveUnit.Throttle)num7;
														int? num8 = ((Submarine_Kinematics)this.activeUnit_0.vmethod_87()).method_18(this.activeUnit_0.vmethod_70(), throttle2);
														float? num9 = (num8 != null) ? new float?((float)num8.GetValueOrDefault()) : null;
														if (num9 != null)
														{
															this.activeUnit_0.vmethod_134(throttle2, null);
															float? num10 = num9;
															if (((num10 != null) ? new bool?(num10.GetValueOrDefault() < -40f) : null).GetValueOrDefault())
															{
																this.activeUnit_0.vmethod_73(num9.Value);
															}
														}
														num7++;
													}
													while (num7 <= 4);
												}
											}
											else
											{
												Contact_Base.ContactType contactType_2 = this.vmethod_3().contactType_0;
												if (contactType_2 != Contact_Base.ContactType.Surface)
												{
													if (contactType_2 != Contact_Base.ContactType.Submarine)
													{
														this.activeUnit_0.vmethod_73(-40f);
													}
													else if (this.vmethod_3().bool_19)
													{
														if (this.vmethod_3().vmethod_14(false) > -40f)
														{
															this.activeUnit_0.vmethod_73(-40f);
														}
														else
														{
															this.activeUnit_0.vmethod_73(this.vmethod_3().vmethod_14(false));
														}
													}
													else
													{
														this.activeUnit_0.vmethod_73(-40f);
													}
												}
												else
												{
													this.activeUnit_0.vmethod_73(-40f);
												}
											}
											Weapon weapon = null;
											this.vmethod_24(float_4, ref weapon);
										}
									}
									else if (this.method_112().vmethod_93().method_8() == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
									{
										if (this.method_122(false, null))
										{
											if (Math.Round((double)this.activeUnit_0.vmethod_72()) < -20.0)
											{
												this.activeUnit_0.vmethod_73(-20f);
											}
										}
										else
										{
											Weapon weapon = null;
											this.vmethod_24(float_4, ref weapon);
										}
									}
									else
									{
										this.vmethod_28(true);
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
											this.activeUnit_0.vmethod_85().vmethod_23(float_4, false);
										}
									}
									this.activeUnit_0.vmethod_85().vmethod_16(float_4);
									if (!this.activeUnit_0.vmethod_85().method_47() && this.activeUnit_0.vmethod_87().vmethod_1() != ActiveUnit_Kinematics.UnitThrottlePreset.FullStop && this.activeUnit_0.vmethod_70() != 0f)
									{
										this.activeUnit_0.vmethod_87().vmethod_11(null);
										this.activeUnit_0.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.None);
										this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.FullStop, null);
										this.activeUnit_0.vmethod_109(this.activeUnit_0._ActiveUnitStatus_1);
										return;
									}
									if (this.method_112().method_70())
									{
										this.method_126(float_4);
										return;
									}
									if (this.activeUnit_0.vmethod_85().vmethod_3())
									{
										this.activeUnit_0.vmethod_85().method_1(float_4);
									}
									bool flag2 = false;
									Class341 class3 = null;
									if (this.method_112().method_68())
									{
										Class343 class4 = (Class343)this.activeUnit_0.vmethod_101();
										flag2 = this.activeUnit_0.vmethod_85().method_40(ref class4.list_5, ref class4.list_11, ref class4.list_7, 2, false, false);
									}
									else if (this.method_112().method_71())
									{
										class3 = (Class341)this.activeUnit_0.vmethod_101();
										flag2 = this.activeUnit_0.vmethod_85().method_40(ref class3.list_5, ref class3.list_11, ref class3.list_7, 2, false, false);
									}
									if (this.method_112().vmethod_93().method_8() != ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries && this.activeUnit_0.vmethod_87().vmethod_10() == null && !this.activeUnit_0.vmethod_85().vmethod_3())
									{
										if (this.method_112().method_68())
										{
											Class343 class5 = (Class343)this.activeUnit_0.vmethod_101();
											if (flag2)
											{
												this.activeUnit_0.vmethod_134(class5.imethod_22(), null);
											}
											else
											{
												this.activeUnit_0.vmethod_134(class5.imethod_20(), null);
											}
										}
										else if (this.method_112().method_71())
										{
											if (flag2)
											{
												this.activeUnit_0.vmethod_134(class3.throttle_1, null);
											}
											else
											{
												this.activeUnit_0.vmethod_134(class3.throttle_0, null);
											}
										}
										else if (this.method_112().method_73())
										{
											FerryMission ferryMission = (FerryMission)this.method_112().vmethod_101();
											if (this.method_112().method_154().vmethod_10() == null)
											{
												if (ferryMission.nullable_7 != null)
												{
													this.method_112().vmethod_134(ferryMission.nullable_7.Value, null);
												}
												else
												{
													this.method_112().vmethod_134(ActiveUnit.Throttle.Cruise, null);
												}
											}
										}
										else if (this.method_112().method_159())
										{
											this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
										}
										else if (!this.activeUnit_0.vmethod_85().vmethod_3())
										{
											if (this.method_112().method_160())
											{
												this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
												this.activeUnit_0.vmethod_87().method_13();
											}
											else
											{
												FuelRec fuelRec = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Select<FuelRec, FuelRec>(Enumerable.Where<FuelRec>(this.activeUnit_0.vmethod_67(), (Submarine_AI._Closure$__.$I38-0 == null) ? (Submarine_AI._Closure$__.$I38-0 = new Func<FuelRec, bool>(Submarine_AI._Closure$__.$I.method_11)) : Submarine_AI._Closure$__.$I38-0), (Submarine_AI._Closure$__.$I38-1 == null) ? (Submarine_AI._Closure$__.$I38-1 = new Func<FuelRec, FuelRec>(Submarine_AI._Closure$__.$I.method_12)) : Submarine_AI._Closure$__.$I38-1), 0);
												if (!Information.IsNothing(fuelRec))
												{
													if ((double)fuelRec.method_9() < 0.0001)
													{
														this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.FullStop, null);
														this.activeUnit_0.vmethod_87().method_13();
													}
													else if (fuelRec.method_9() < 1f)
													{
														this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
														this.activeUnit_0.vmethod_87().method_13();
													}
													else
													{
														this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
														this.activeUnit_0.vmethod_87().method_13();
													}
												}
												else
												{
													this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
													this.activeUnit_0.vmethod_87().method_13();
												}
											}
										}
									}
									int value4 = (int)this.activeUnit_0.doctrine_0.method_258(this.activeUnit_0.scenario_0, false, false, false).Value;
									if (this.method_112().vmethod_93().method_8() != ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
									{
										if (this.activeUnit_0.vmethod_87().vmethod_12())
										{
											this.vmethod_28(true);
										}
										else if (this.activeUnit_0.method_68())
										{
											if (flag2)
											{
												if (!this.method_124((float)value4, false, false))
												{
													Class343 class6 = (Class343)this.activeUnit_0.vmethod_101();
													if (class6.imethod_28() != null)
													{
														int num11 = (int)Math.Round((double)class6.imethod_28().Value);
														if (num11 >= -20 && !this.method_122(false, null))
														{
															this.activeUnit_0.vmethod_73(-40f);
														}
														else
														{
															this.activeUnit_0.vmethod_73((float)num11);
														}
													}
													else
													{
														this.method_125(float_4);
													}
												}
											}
											else if (!this.method_124((float)value4, false, false))
											{
												Class343 class7 = (Class343)this.activeUnit_0.vmethod_101();
												if (class7.imethod_26() != null)
												{
													int num12 = (int)Math.Round((double)class7.imethod_26().Value);
													if (num12 >= -20 && !this.method_122(false, null))
													{
														this.activeUnit_0.vmethod_73((float)((int)Math.Round((double)Submarine_AI.smethod_2(this.method_112()))));
													}
													else
													{
														this.activeUnit_0.vmethod_73((float)num12);
													}
												}
												else
												{
													this.method_112().vmethod_73(Submarine_AI.smethod_2(this.method_112()));
												}
											}
										}
										else if (this.method_112().method_71())
										{
											if (flag2)
											{
												if (!this.method_124((float)value4, false, false))
												{
													if (class3.nullable_9 != null)
													{
														int num13 = (int)Math.Round((double)class3.nullable_9.Value);
														if (num13 >= -20 && !this.method_122(false, null))
														{
															this.activeUnit_0.vmethod_73(-40f);
														}
														else
														{
															this.activeUnit_0.vmethod_73((float)num13);
														}
													}
													else
													{
														this.method_125(float_4);
													}
												}
											}
											else if (!this.method_124((float)value4, false, false))
											{
												if (class3.nullable_8 != null)
												{
													int num14 = (int)Math.Round((double)class3.nullable_8.Value);
													if (num14 >= -20 && !this.method_122(false, null))
													{
														this.activeUnit_0.vmethod_73((float)((int)Math.Round((double)Submarine_AI.smethod_2(this.method_112()))));
													}
													else
													{
														this.activeUnit_0.vmethod_73((float)num14);
													}
												}
												else
												{
													this.method_112().vmethod_73(Submarine_AI.smethod_2(this.method_112()));
												}
											}
										}
										else if (this.method_112().method_73())
										{
											FerryMission ferryMission2 = (FerryMission)this.method_112().vmethod_101();
											if (!this.method_124((float)value4, false, false))
											{
												if (ferryMission2.nullable_8 != null)
												{
													int num15 = (int)Math.Round((double)ferryMission2.nullable_8.Value);
													if (num15 >= -20 && !this.method_122(false, null))
													{
														this.method_112().vmethod_73((float)((int)Math.Round((double)Submarine_AI.smethod_2(this.method_112()))));
													}
													else
													{
														this.method_112().vmethod_73((float)num15);
													}
												}
												else
												{
													this.method_112().vmethod_73(Submarine_AI.smethod_2(this.method_112()));
												}
											}
										}
										else if (!this.method_112().method_154().vmethod_12() && !this.method_124((float)value4, true, false))
										{
											this.method_112().vmethod_73(Math.Min(-20f, Submarine_AI.smethod_2(this.method_112())));
										}
									}
									return;
								}
								else
								{
									if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.Tasked)
									{
										if (this.bool_2)
										{
											base.method_22();
											return;
										}
										if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Mining)
										{
											this.method_126(float_4);
											return;
										}
										if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.MineClearing)
										{
											Submarine_AI.Class377 class8 = new Submarine_AI.Class377(class8);
											class8.submarine_AI_0 = this;
											Class341 class9 = (Class341)this.activeUnit_0.vmethod_101();
											class8.observableDictionary_0 = this.activeUnit_0.scenario_0.vmethod_20();
											class8.list_0 = class9.list_5;
											if (this.activeUnit_0.method_83())
											{
												Submarine_AI.Class378 class10 = new Submarine_AI.Class378(class10);
												class10.class377_0 = class8;
												class10.concurrentBag_0 = new ConcurrentBag<UnguidedWeapon>();
												Parallel.ForEach<string>(this.activeUnit_0.vmethod_7(false).hashSet_0, new Action<string>(class10.method_0));
												UnguidedWeapon unguidedWeapon;
												float num16;
												if (class10.concurrentBag_0.Count > 0)
												{
													unguidedWeapon = Enumerable.ElementAtOrDefault<UnguidedWeapon>(Enumerable.OrderBy<UnguidedWeapon, double>(Enumerable.Where<UnguidedWeapon>(Enumerable.ToList<UnguidedWeapon>(class10.concurrentBag_0), (Submarine_AI._Closure$__.$I38-3 == null) ? (Submarine_AI._Closure$__.$I38-3 = new Func<UnguidedWeapon, bool>(Submarine_AI._Closure$__.$I.method_13)) : Submarine_AI._Closure$__.$I38-3), new Func<UnguidedWeapon, double>(this.method_130)), 0);
													num16 = this.activeUnit_0.method_36(unguidedWeapon);
												}
												if (this.method_112().method_159())
												{
													if ((double)num16 > (double)this.method_112().short_3 / 1852.0 * 2.0)
													{
														class10.concurrentBag_0 = new ConcurrentBag<UnguidedWeapon>();
													}
													else
													{
														ActiveUnit activeUnit2 = this.activeUnit_0.vmethod_93().method_11(false);
														if (!Information.IsNothing(activeUnit2) && (double)activeUnit2.method_36(this.method_112()) > (double)this.method_112().short_3 / 1852.0)
														{
															class10.concurrentBag_0 = new ConcurrentBag<UnguidedWeapon>();
														}
													}
												}
												if (class10.concurrentBag_0.Count > 0)
												{
													if (this.activeUnit_0.method_83())
													{
														base.method_75(unguidedWeapon, num16);
													}
													else
													{
														base.method_76(unguidedWeapon, num16);
													}
													if ((double)num16 > 0.5)
													{
														this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
													}
													else
													{
														this.activeUnit_0.vmethod_71(num16 * 10f);
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
																if (!this.activeUnit_0.vmethod_65(false).vmethod_85().method_37(ref class9.list_5, ref class9.list_14, ref class9.list_10, 30f, false))
																{
																	this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_22(class9.list_5);
																}
																this.activeUnit_0.vmethod_85().vmethod_16(float_4);
															}
															else
															{
																this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_22(class9.list_5);
															}
														}
														else if (this.activeUnit_0.vmethod_90().vmethod_1())
														{
															this.activeUnit_0.vmethod_85().vmethod_21(float_4);
														}
													}
													else if (this.activeUnit_0.vmethod_85().method_46())
													{
														if (!this.activeUnit_0.vmethod_85().method_37(ref class9.list_5, ref class9.list_14, ref class9.list_10, 30f, false))
														{
															this.activeUnit_0.vmethod_85().vmethod_22(class9.list_5);
														}
														this.activeUnit_0.vmethod_85().vmethod_16(float_4);
													}
													else
													{
														if (this.method_112().method_159())
														{
															ActiveUnit activeUnit3 = this.method_112().vmethod_93().method_11(false);
															if (Information.IsNothing(activeUnit3))
															{
																goto IL_1C09;
															}
															try
															{
																if (this.activeUnit_0.method_36(activeUnit3) * 1852f > (float)((Submarine)this.activeUnit_0).short_3)
																{
																	this.method_112().vmethod_69(ActiveUnit.Enum28.const_1, this.method_112().method_32(activeUnit3));
																}
																else if (this.activeUnit_0.scenario_0.FifteenthMinuteIsChangingOnThisPulse)
																{
																	int num17 = GameGeneral.smethod_5().Next((int)Math.Round((double)Math2.smethod_7(activeUnit3.vmethod_9() - 45f)), (int)Math.Round((double)Math2.smethod_7(activeUnit3.vmethod_9() + 46f)));
																	double double_;
																	double double_2;
																	Class411.smethod_1(activeUnit3.vmethod_28(null), activeUnit3.vmethod_30(null), ref double_, ref double_2, (double)((float)((double)this.method_112().short_3 / 1852.0)), (double)num17);
																	this.method_112().vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_17(this.method_112().vmethod_30(null), this.method_112().vmethod_28(null), double_2, double_));
																}
																goto IL_1C09;
															}
															catch (Exception ex)
															{
																goto IL_1C09;
															}
														}
														this.activeUnit_0.vmethod_85().vmethod_22(class9.list_5);
													}
													IL_1C09:
													if (this.activeUnit_0.vmethod_87().vmethod_10() == null)
													{
														if (this.activeUnit_0.vmethod_85().method_40(ref class9.list_5, ref class9.list_11, ref class9.list_7, 2, false, false))
														{
															if (this.method_112().method_159())
															{
																this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
															}
															else
															{
																this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
															}
														}
														else
														{
															this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
														}
													}
												}
											}
											else if (this.activeUnit_0.vmethod_85().method_46())
											{
												if (!this.activeUnit_0.vmethod_85().method_37(ref class9.list_5, ref class9.list_14, ref class9.list_10, 30f, false))
												{
													this.activeUnit_0.vmethod_85().vmethod_22(class9.list_5);
												}
												this.activeUnit_0.vmethod_85().vmethod_16(float_4);
											}
											else
											{
												this.activeUnit_0.vmethod_85().vmethod_22(class9.list_5);
											}
											return;
										}
									}
									if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.OnPatrol)
									{
										if (Information.IsNothing(this.activeUnit_0.vmethod_101()))
										{
											activeUnitStatus = ActiveUnit._ActiveUnitStatus.Unassigned;
										}
										else if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
										{
											Class343 class11 = (Class343)this.activeUnit_0.vmethod_101();
											if (Information.IsNothing(class11))
											{
												activeUnitStatus = ActiveUnit._ActiveUnitStatus.Unassigned;
											}
											else
											{
												if (this.activeUnit_0.method_120())
												{
													if (this.activeUnit_0.method_122())
													{
														if (this.activeUnit_0.vmethod_85().method_46())
														{
															if (!this.activeUnit_0.vmethod_65(false).vmethod_85().method_37(ref class11.list_5, ref class11.list_14, ref class11.list_10, 30f, false))
															{
																this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_23(float_4, false);
															}
															this.activeUnit_0.vmethod_85().vmethod_16(float_4);
														}
														else
														{
															this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_23(float_4, false);
														}
													}
													else if (this.activeUnit_0.vmethod_90().vmethod_1())
													{
														this.activeUnit_0.vmethod_85().vmethod_21(float_4);
													}
												}
												else if (this.activeUnit_0.vmethod_85().method_46())
												{
													if (!this.activeUnit_0.vmethod_85().method_37(ref class11.list_5, ref class11.list_14, ref class11.list_10, 30f, false))
													{
														this.activeUnit_0.vmethod_85().vmethod_23(float_4, false);
													}
													this.activeUnit_0.vmethod_85().vmethod_16(float_4);
												}
												else
												{
													this.activeUnit_0.vmethod_85().vmethod_23(float_4, false);
												}
												if (this.activeUnit_0.vmethod_87().vmethod_10() == null)
												{
													this.activeUnit_0.vmethod_87().method_13();
												}
											}
											int value5 = (int)this.activeUnit_0.doctrine_0.method_258(this.activeUnit_0.scenario_0, false, false, false).Value;
											if (!this.method_124((float)value5, false, false) && !this.method_112().method_154().vmethod_12())
											{
												this.method_125(float_4);
											}
										}
									}
									if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.OnSupportMission)
									{
										if (!Information.IsNothing(this.activeUnit_0.vmethod_101()))
										{
											if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support)
											{
												if (this.activeUnit_0.method_120())
												{
													if (this.activeUnit_0.method_122())
													{
														this.activeUnit_0.vmethod_85().vmethod_14(float_4, this.activeUnit_0.vmethod_85().method_15());
													}
													else
													{
														if (this.activeUnit_0.vmethod_90().vmethod_1())
														{
															this.activeUnit_0.vmethod_85().vmethod_21(float_4);
														}
														int value6 = (int)this.activeUnit_0.doctrine_0.method_258(this.activeUnit_0.scenario_0, false, false, false).Value;
														this.method_124((float)value6, false, false);
													}
												}
												else
												{
													this.activeUnit_0.vmethod_85().vmethod_14(float_4, this.activeUnit_0.vmethod_85().method_15());
												}
											}
										}
										return;
									}
									if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.OnFerryMission)
									{
										if (!Information.IsNothing(this.activeUnit_0.vmethod_101()))
										{
											if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Ferry)
											{
												FerryMission ferryMission3 = (FerryMission)this.activeUnit_0.vmethod_101();
												if (this.activeUnit_0.vmethod_87().vmethod_10() == null && ferryMission3.nullable_7 != null)
												{
													ActiveUnit.Throttle value7 = ferryMission3.nullable_7.Value;
												}
												if (!this.activeUnit_0.vmethod_87().vmethod_12())
												{
													if (!Information.IsNothing(ferryMission3.nullable_8))
													{
														float value8 = ferryMission3.nullable_8.Value;
													}
													else
													{
														this.method_112().method_154().vmethod_31();
													}
												}
												else
												{
													this.activeUnit_0.vmethod_72();
												}
												if (!this.activeUnit_0.method_121())
												{
													if (!Information.IsNothing(this.activeUnit_0.vmethod_93().method_2()))
													{
														this.vmethod_29(float_4);
													}
													else
													{
														string str = "";
														if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
														{
															str = " (" + this.activeUnit_0.string_2 + ")";
														}
														this.activeUnit_0.scenario_0.method_59("Submarine: " + this.activeUnit_0.Name + str + " is assigned to a ferry mission but it cannot dock at the desired destination. Unassigning submarine and returning to nearest base.", this.activeUnit_0.Name + " cannot dock at destination; aborting", LoggedMessage.MessageType.DockingOps, 0, null, this.activeUnit_0.vmethod_7(false), default(Geopoint_Struct));
														ActiveUnit activeUnit_ = this.activeUnit_0;
														Mission value9 = null;
														bool setMissionOnly = false;
														Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
														activeUnit_.vmethod_102(value9, setMissionOnly, ref missionAssignmentAttemptResult);
														this.activeUnit_0.vmethod_93().method_5(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
													}
												}
												else
												{
													this.activeUnit_0.vmethod_85().vmethod_21(float_4);
												}
											}
										}
									}
									if (this.activeUnit_0.method_120())
									{
										if (this.activeUnit_0.vmethod_90().vmethod_1())
										{
											this.activeUnit_0.vmethod_85().vmethod_21(float_4);
										}
										int value10 = (int)this.activeUnit_0.doctrine_0.method_258(this.activeUnit_0.scenario_0, false, false, false).Value;
										this.method_124((float)value10, false, false);
										return;
									}
									if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.Unassigned)
									{
										if (this.activeUnit_0.vmethod_87().vmethod_10() == null)
										{
											this.activeUnit_0.vmethod_71(0f);
										}
										if (this.activeUnit_0.vmethod_87().vmethod_12())
										{
											this.vmethod_28(true);
										}
									}
									return;
								}
							}
						}
						ActiveUnit_DockingOps._DockingOpsCondition dockingOpsCondition = this.activeUnit_0.vmethod_93().method_8();
						if (dockingOpsCondition != ActiveUnit_DockingOps._DockingOpsCondition.Underway)
						{
							if (dockingOpsCondition != ActiveUnit_DockingOps._DockingOpsCondition.RTB)
							{
								if (dockingOpsCondition == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
								{
									this.activeUnit_0.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.RTB);
									this.vmethod_29(float_4);
								}
							}
							else
							{
								if (this.activeUnit_0.method_120())
								{
									this.activeUnit_0.method_129(false, true, false);
								}
								this.vmethod_29(float_4);
								if (!Information.IsNothing(this.activeUnit_0))
								{
									int value11 = (int)this.activeUnit_0.doctrine_0.method_258(this.activeUnit_0.scenario_0, false, false, false).Value;
									this.method_124((float)value11, true, false);
								}
							}
						}
						else
						{
							this.vmethod_29(float_4);
							int value12 = (int)this.activeUnit_0.doctrine_0.method_258(this.activeUnit_0.scenario_0, false, false, false).Value;
							this.method_124((float)value12, true, false);
						}
					}
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 100825", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x001CC678 File Offset: 0x001CA878
		private void method_126(float float_4)
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
						this.activeUnit_0.vmethod_85().vmethod_16(float_4);
					}
					else
					{
						this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_22(@class.list_5);
					}
				}
				else if (this.activeUnit_0.vmethod_90().vmethod_1())
				{
					this.activeUnit_0.vmethod_85().vmethod_21(float_4);
				}
			}
			else if (this.activeUnit_0.vmethod_85().method_46())
			{
				if (!this.activeUnit_0.vmethod_85().method_37(ref @class.list_5, ref @class.list_16, ref @class.list_11, 30f, false))
				{
					this.activeUnit_0.vmethod_85().vmethod_22(@class.list_5);
				}
				this.activeUnit_0.vmethod_85().vmethod_16(float_4);
			}
			else
			{
				this.activeUnit_0.vmethod_85().vmethod_22(@class.list_5);
			}
			if (Information.IsNothing(this.method_112().method_154().vmethod_10()))
			{
				if (this.activeUnit_0.vmethod_85().method_40(ref @class.list_5, ref @class.list_13, ref @class.list_8, 2, false, false))
				{
					this.activeUnit_0.vmethod_134(@class.throttle_1, null);
				}
				else
				{
					this.activeUnit_0.vmethod_134(@class.throttle_0, null);
				}
			}
			if (this.method_112().method_154().vmethod_12())
			{
				if (!this.method_112().method_160() && !this.method_122(false, null))
				{
					if (this.method_112().vmethod_72() >= -20f)
					{
						this.method_112().method_154().vmethod_13(false);
						return;
					}
					if (Math.Round((double)Math.Min(-20f, Submarine_AI.smethod_2(this.method_112()))) < -20.0)
					{
						this.method_112().vmethod_73(Math.Min(-20f, Submarine_AI.smethod_2(this.method_112())));
						return;
					}
				}
				else
				{
					this.vmethod_28(true);
				}
				return;
			}
			if (this.activeUnit_0.vmethod_85().method_40(ref @class.list_5, ref @class.list_13, ref @class.list_8, 2, false, false))
			{
				if (@class.nullable_9 != null)
				{
					float value = @class.nullable_9.Value;
					if (Math.Round((double)value) >= -20.0 && !this.method_122(false, null))
					{
						this.activeUnit_0.vmethod_73(-40f);
						return;
					}
					this.activeUnit_0.vmethod_73(value);
					return;
				}
				else
				{
					if (this.activeUnit_0.float_24 < 1800f && !this.method_122(false, null))
					{
						this.activeUnit_0.vmethod_73(-40f);
						return;
					}
					this.activeUnit_0.vmethod_73(-20f);
					return;
				}
			}
			else
			{
				if (@class.nullable_8 == null)
				{
					this.method_112().vmethod_73(Math.Min(-20f, Submarine_AI.smethod_2(this.method_112())));
					return;
				}
				float value2 = @class.nullable_8.Value;
				if (Math.Round((double)value2) >= -20.0 && !this.method_122(false, null))
				{
					this.activeUnit_0.vmethod_73(Math.Min(-20f, Submarine_AI.smethod_2(this.method_112())));
					return;
				}
				this.activeUnit_0.vmethod_73(value2);
				return;
			}
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x001CCA68 File Offset: 0x001CAC68
		public override void vmethod_24(float float_4, ref Weapon weapon_0)
		{
			if (!Information.IsNothing(this.activeUnit_0) && !Information.IsNothing(this.vmethod_3()))
			{
				try
				{
					Submarine_AI.Class379 @class = new Submarine_AI.Class379();
					@class.submarine_AI_0 = this;
					@class.doctrine_0 = this.activeUnit_0.doctrine_0;
					if (Information.IsNothing(weapon_0))
					{
						Side side = this.activeUnit_0.vmethod_7(false);
						Contact contact = this.vmethod_3();
						List<Weapon> list = side.method_74(ref this.activeUnit_0, ref contact);
						this.vmethod_4(contact);
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
						float num2 = this.activeUnit_0.method_36(this.vmethod_3());
						if (!this.activeUnit_0.vmethod_87().vmethod_12())
						{
							float float_5;
							if (this.vmethod_3().vmethod_40() == 0f)
							{
								float_5 = this.activeUnit_0.vmethod_40();
							}
							else
							{
								float_5 = this.activeUnit_0.method_39(this.vmethod_3(), this.activeUnit_0.vmethod_40(), this.activeUnit_0.vmethod_9());
							}
							Weapon._WeaponType weaponType = weapon_0.method_167();
							float num3;
							if (weaponType != Weapon._WeaponType.Rocket)
							{
								if (weaponType != Weapon._WeaponType.Gun)
								{
									if (weapon_0.scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(weapon_0.scenario_0.method_39()) && weapon_0.float_39 == 0f && weapon_0.float_40 == 0f)
									{
										num3 = weapon_0.float_43;
										goto IL_204;
									}
									num3 = weapon_0.float_39;
									goto IL_204;
								}
							}
							if (this.activeUnit_0.method_37(this.vmethod_3(), 0f) > num)
							{
								num3 = (float)(Math.Sqrt(2.0) / 2.0 * (double)num * 1852.0);
							}
							IL_204:
							float num4;
							if (num3 < this.activeUnit_0.vmethod_72())
							{
								num4 = (this.activeUnit_0.vmethod_72() - num3) / this.activeUnit_0.vmethod_87().vmethod_21();
							}
							float num5;
							if (num2 > num)
							{
								float float_6 = num2 - num;
								num5 = this.activeUnit_0.method_53(float_5, float_6);
							}
							else
							{
								num5 = 0f;
							}
							if (num5 < 0f)
							{
								return;
							}
							if (num4 >= num5)
							{
								if (num3 < this.activeUnit_0.vmethod_72())
								{
									if (this.vmethod_3().bool_19)
									{
										if (this.vmethod_3().vmethod_14(false) < num3 && this.activeUnit_0.vmethod_72() < num3)
										{
											this.activeUnit_0.vmethod_73(num3);
										}
									}
									else if (Math.Round((double)this.activeUnit_0.vmethod_72()) > -20.0)
									{
										this.activeUnit_0.vmethod_73(-20f);
									}
								}
								else if (num3 > this.activeUnit_0.vmethod_72())
								{
									this.activeUnit_0.vmethod_73(num3);
								}
							}
						}
						if (this.activeUnit_0.vmethod_87().vmethod_10() == null && (double)num * 1.2 < (double)num2)
						{
							if (weapon_0.int_17 != 0 && (float)weapon_0.int_17 < this.activeUnit_0.vmethod_40())
							{
								this.activeUnit_0.vmethod_71((float)weapon_0.int_17);
							}
							if (weapon_0.int_18 != 0 && (float)weapon_0.int_18 > this.activeUnit_0.vmethod_40())
							{
								this.activeUnit_0.vmethod_71((float)weapon_0.int_18);
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100826", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00008736 File Offset: 0x00006936
		[CompilerGenerated]
		private bool method_127(NoNavZone noNavZone_0)
		{
			return noNavZone_0.method_8(this.activeUnit_0);
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_128(Contact contact_9)
		{
			return this.activeUnit_0.method_31(contact_9);
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_129(Contact contact_9)
		{
			return this.activeUnit_0.method_31(contact_9);
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x000075AA File Offset: 0x000057AA
		[CompilerGenerated]
		private double method_130(UnguidedWeapon unguidedWeapon_0)
		{
			return this.activeUnit_0.method_31(unguidedWeapon_0);
		}

		// Token: 0x04001673 RID: 5747
		private float float_3;

		// Token: 0x04001674 RID: 5748
		private ActiveUnit_AI.SubmarineDepthPreset submarineDepthPreset_0;

		// Token: 0x04001675 RID: 5749
		private Submarine submarine_0;

		// Token: 0x04001676 RID: 5750
		protected Contact contact_8;

		// Token: 0x04001677 RID: 5751
		private HashSet<string> hashSet_1;

		// Token: 0x02000352 RID: 850
		[CompilerGenerated]
		internal sealed class Class377
		{
			// Token: 0x06001964 RID: 6500 RVA: 0x0000CEC4 File Offset: 0x0000B0C4
			public Class377(Submarine_AI.Class377 class377_0)
			{
				if (class377_0 != null)
				{
					this.observableDictionary_0 = class377_0.observableDictionary_0;
					this.list_0 = class377_0.list_0;
				}
			}

			// Token: 0x04001687 RID: 5767
			public ObservableDictionary<string, UnguidedWeapon> observableDictionary_0;

			// Token: 0x04001688 RID: 5768
			public List<ReferencePoint> list_0;

			// Token: 0x04001689 RID: 5769
			public Submarine_AI submarine_AI_0;
		}

		// Token: 0x02000353 RID: 851
		[CompilerGenerated]
		internal sealed class Class378
		{
			// Token: 0x06001965 RID: 6501 RVA: 0x0000CEE7 File Offset: 0x0000B0E7
			public Class378(Submarine_AI.Class378 class378_0)
			{
				if (class378_0 != null)
				{
					this.concurrentBag_0 = class378_0.concurrentBag_0;
				}
			}

			// Token: 0x06001966 RID: 6502 RVA: 0x001CCE5C File Offset: 0x001CB05C
			internal void method_0(string string_0)
			{
				UnguidedWeapon unguidedWeapon;
				this.class377_0.observableDictionary_0.TryGetValue(string_0, ref unguidedWeapon);
				if (!Information.IsNothing(unguidedWeapon) && unguidedWeapon.method_65() && unguidedWeapon.vmethod_46(this.class377_0.list_0, this.class377_0.submarine_AI_0.activeUnit_0.scenario_0, true))
				{
					this.concurrentBag_0.Add(unguidedWeapon);
				}
			}

			// Token: 0x0400168A RID: 5770
			public ConcurrentBag<UnguidedWeapon> concurrentBag_0;

			// Token: 0x0400168B RID: 5771
			public Submarine_AI.Class377 class377_0;
		}

		// Token: 0x02000354 RID: 852
		[CompilerGenerated]
		internal sealed class Class379
		{
			// Token: 0x06001968 RID: 6504 RVA: 0x0000CEFE File Offset: 0x0000B0FE
			internal float method_0(Weapon weapon_0)
			{
				return weapon_0.method_181(this.submarine_AI_0.activeUnit_0, this.submarine_AI_0.vmethod_3(), true, this.doctrine_0, false);
			}

			// Token: 0x0400168C RID: 5772
			public Doctrine doctrine_0;

			// Token: 0x0400168D RID: 5773
			public Submarine_AI submarine_AI_0;
		}
	}
}
