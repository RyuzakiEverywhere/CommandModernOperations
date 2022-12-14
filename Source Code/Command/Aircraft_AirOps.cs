using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns13;
using ns14;
using ns9;

namespace Command_Core
{
	// Token: 0x02000195 RID: 405
	public sealed class Aircraft_AirOps : ActiveUnit_AirOps
	{
		// Token: 0x06000C43 RID: 3139 RVA: 0x000F0484 File Offset: 0x000EE684
		[CompilerGenerated]
		public static void smethod_1(Aircraft_AirOps.Delegate23 delegate23_1)
		{
			Aircraft_AirOps.Delegate23 @delegate = Aircraft_AirOps.delegate23_0;
			Aircraft_AirOps.Delegate23 delegate2;
			do
			{
				delegate2 = @delegate;
				Aircraft_AirOps.Delegate23 value = (Aircraft_AirOps.Delegate23)Delegate.Combine(delegate2, delegate23_1);
				@delegate = Interlocked.CompareExchange<Aircraft_AirOps.Delegate23>(ref Aircraft_AirOps.delegate23_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x000F04B8 File Offset: 0x000EE6B8
		[CompilerGenerated]
		public static void smethod_2(Aircraft_AirOps.Delegate23 delegate23_1)
		{
			Aircraft_AirOps.Delegate23 @delegate = Aircraft_AirOps.delegate23_0;
			Aircraft_AirOps.Delegate23 delegate2;
			do
			{
				delegate2 = @delegate;
				Aircraft_AirOps.Delegate23 value = (Aircraft_AirOps.Delegate23)Delegate.Remove(delegate2, delegate23_1);
				@delegate = Interlocked.CompareExchange<Aircraft_AirOps.Delegate23>(ref Aircraft_AirOps.delegate23_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x000F04EC File Offset: 0x000EE6EC
		[CompilerGenerated]
		public static void smethod_3(Aircraft_AirOps.Delegate24 delegate24_1)
		{
			Aircraft_AirOps.Delegate24 @delegate = Aircraft_AirOps.delegate24_0;
			Aircraft_AirOps.Delegate24 delegate2;
			do
			{
				delegate2 = @delegate;
				Aircraft_AirOps.Delegate24 value = (Aircraft_AirOps.Delegate24)Delegate.Combine(delegate2, delegate24_1);
				@delegate = Interlocked.CompareExchange<Aircraft_AirOps.Delegate24>(ref Aircraft_AirOps.delegate24_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x000F0520 File Offset: 0x000EE720
		[CompilerGenerated]
		public static void smethod_4(Aircraft_AirOps.Delegate24 delegate24_1)
		{
			Aircraft_AirOps.Delegate24 @delegate = Aircraft_AirOps.delegate24_0;
			Aircraft_AirOps.Delegate24 delegate2;
			do
			{
				delegate2 = @delegate;
				Aircraft_AirOps.Delegate24 value = (Aircraft_AirOps.Delegate24)Delegate.Remove(delegate2, delegate24_1);
				@delegate = Interlocked.CompareExchange<Aircraft_AirOps.Delegate24>(ref Aircraft_AirOps.delegate24_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x000F0554 File Offset: 0x000EE754
		[CompilerGenerated]
		public static void smethod_5(Aircraft_AirOps.Delegate25 delegate25_1)
		{
			Aircraft_AirOps.Delegate25 @delegate = Aircraft_AirOps.delegate25_0;
			Aircraft_AirOps.Delegate25 delegate2;
			do
			{
				delegate2 = @delegate;
				Aircraft_AirOps.Delegate25 value = (Aircraft_AirOps.Delegate25)Delegate.Combine(delegate2, delegate25_1);
				@delegate = Interlocked.CompareExchange<Aircraft_AirOps.Delegate25>(ref Aircraft_AirOps.delegate25_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x000F0588 File Offset: 0x000EE788
		[CompilerGenerated]
		public static void smethod_6(Aircraft_AirOps.Delegate25 delegate25_1)
		{
			Aircraft_AirOps.Delegate25 @delegate = Aircraft_AirOps.delegate25_0;
			Aircraft_AirOps.Delegate25 delegate2;
			do
			{
				delegate2 = @delegate;
				Aircraft_AirOps.Delegate25 value = (Aircraft_AirOps.Delegate25)Delegate.Remove(delegate2, delegate25_1);
				@delegate = Interlocked.CompareExchange<Aircraft_AirOps.Delegate25>(ref Aircraft_AirOps.delegate25_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00008AA6 File Offset: 0x00006CA6
		private Aircraft method_20()
		{
			if (this.aircraft_2 == null)
			{
				this.aircraft_2 = (Aircraft)this.activeUnit_0;
			}
			return this.aircraft_2;
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x000F05BC File Offset: 0x000EE7BC
		public override void vmethod_0(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				try
				{
					xmlWriter_0.WriteStartElement("AirOps");
					xmlWriter_0.WriteStartElement("LQ");
					Aircraft[] aircraft_ = this.aircraft_0;
					for (int i = 0; i < aircraft_.Length; i++)
					{
						aircraft_[i].vmethod_4(ref xmlWriter_0, ref hashSet_0);
					}
					xmlWriter_0.WriteEndElement();
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Con";
					int airOpsCondition_ = (int)this._AirOpsCondition_0;
					xmlWriter.WriteElementString(localName, airOpsCondition_.ToString());
					xmlWriter_0.WriteElementString("CT", XmlConvert.ToString(this.method_38()));
					if (!Information.IsNothing(this.method_34()))
					{
						xmlWriter_0.WriteElementString("HAF", this.method_34().string_0);
					}
					if (!Information.IsNothing(this.method_30()))
					{
						xmlWriter_0.WriteElementString("CHU", this.method_30().string_0);
					}
					if (!Information.IsNothing(this.method_32(false)))
					{
						xmlWriter_0.WriteElementString("AHU", this.activeUnit_2.string_0);
					}
					if (!Information.IsNothing(this.method_24()))
					{
						xmlWriter_0.WriteElementString("A2ARD", this.method_24().string_0);
					}
					if (this.concurrentDictionary_0.Count > 0)
					{
						xmlWriter_0.WriteStartElement("RQ");
						try
						{
							foreach (string value in this.concurrentDictionary_0.Keys)
							{
								xmlWriter_0.WriteElementString("ID", value);
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
						xmlWriter_0.WriteEndElement();
					}
					if (this.concurrentDictionary_1.Count > 0)
					{
						xmlWriter_0.WriteStartElement("A2ARC");
						try
						{
							foreach (KeyValuePair<string, Aircraft_AirOps.Enum43> keyValuePair in this.concurrentDictionary_1)
							{
								if (Information.IsNothing(keyValuePair.Key))
								{
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
								}
								else
								{
									xmlWriter_0.WriteElementString("Conn", keyValuePair.Key + "_" + Conversions.ToString((int)keyValuePair.Value));
								}
							}
						}
						finally
						{
							IEnumerator<KeyValuePair<string, Aircraft_AirOps.Enum43>> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						xmlWriter_0.WriteEndElement();
					}
					if (this.int_0 != 0)
					{
						xmlWriter_0.WriteElementString("A2AR_NumberOfReceiverHookups", this.int_0.ToString());
					}
					if (this.bool_0)
					{
						xmlWriter_0.WriteElementString("QuickTurnaround_Enabled", this.bool_0.ToString());
					}
					if (this.int_1 != 0)
					{
						xmlWriter_0.WriteElementString("QuickTurnaround_SortiesFlown", this.int_1.ToString());
					}
					if (this.int_2 != 0)
					{
						xmlWriter_0.WriteElementString("QuickTurnaround_SortiesTotal", this.int_2.ToString());
					}
					if (this.int_3 != 0)
					{
						xmlWriter_0.WriteElementString("QuickTurnaround_TimePentalty", this.int_3.ToString());
					}
					if (this.float_1 != 0f)
					{
						xmlWriter_0.WriteElementString("QuickTurnaround_AirborneTime_Flown", this.float_1.ToString());
					}
					if (this.float_2 != 0f)
					{
						xmlWriter_0.WriteElementString("QuickTurnaround_AirborneTime_SortieAverage", this.float_2.ToString());
					}
					xmlWriter_0.WriteEndElement();
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100404", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x000F093C File Offset: 0x000EEB3C
		public static Aircraft_AirOps smethod_7(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref ActiveUnit activeUnit_3)
		{
			Aircraft_AirOps result;
			try
			{
				Aircraft_AirOps aircraft_AirOps = new Aircraft_AirOps(ref activeUnit_3);
				aircraft_AirOps.activeUnit_0 = activeUnit_3;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 1812259564U)
						{
							if (num <= 1259866850U)
							{
								if (num <= 597234316U)
								{
									if (num != 1179485U)
									{
										if (num != 312808761U)
										{
											if (num != 597234316U)
											{
												continue;
											}
											if (Operators.CompareString(name, "HAF", false) != 0)
											{
												continue;
											}
											goto IL_6D8;
										}
										else
										{
											if (Operators.CompareString(name, "QuickTurnaround_AirborneTime_Flown", false) == 0)
											{
												aircraft_AirOps.float_1 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "QuickTurnaround_TimePentalty", false) == 0)
										{
											aircraft_AirOps.int_3 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 836103370U)
								{
									if (num != 1014590895U)
									{
										if (num != 1259866850U)
										{
											continue;
										}
										if (Operators.CompareString(name, "A2AR_NumberOfReceiverHookups", false) == 0)
										{
											aircraft_AirOps.int_0 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "RefuellingQueue", false) != 0)
										{
											continue;
										}
										goto IL_2CF;
									}
								}
								else if (Operators.CompareString(name, "CurrentHostUnit", false) != 0)
								{
									continue;
								}
							}
							else if (num <= 1324455984U)
							{
								if (num != 1264355206U)
								{
									if (num != 1281343745U)
									{
										if (num != 1324455984U)
										{
											continue;
										}
										if (Operators.CompareString(name, "QuickTurnaround_SortiesTotal", false) == 0)
										{
											aircraft_AirOps.int_2 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else if (Operators.CompareString(name, "CHU", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "A2AR_Destination", false) != 0)
									{
										continue;
									}
									goto IL_4CF;
								}
							}
							else if (num != 1394108651U)
							{
								if (num == 1792671826U)
								{
									goto IL_325;
								}
								if (num != 1812259564U)
								{
									continue;
								}
								if (Operators.CompareString(name, "RQ", false) == 0)
								{
									goto IL_2CF;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Con", false) != 0)
								{
									continue;
								}
								goto IL_635;
							}
							if (string.IsNullOrEmpty(xmlNode.ChildNodes[0].InnerXml))
							{
								aircraft_AirOps.string_2 = xmlNode.InnerXml;
								continue;
							}
							XmlNode xmlNode2 = xmlNode.ChildNodes[0];
							ActiveUnit activeUnit = ActiveUnit.smethod_9(ref xmlNode2, ref dictionary_0, ref activeUnit_3.scenario_0);
							if (!activeUnit_3.scenario_0.vmethod_0().ContainsKey(activeUnit.string_0))
							{
								activeUnit_3.scenario_0.vmethod_0().Add(activeUnit.string_0, activeUnit);
							}
							if (!Enumerable.Contains<AirFacility>(activeUnit.vmethod_99(), aircraft_AirOps.method_34()))
							{
								activeUnit.vmethod_92().method_18((Aircraft)activeUnit_3, false);
								continue;
							}
							continue;
							IL_2CF:
							try
							{
								foreach (object obj2 in xmlNode.ChildNodes)
								{
									XmlNode xmlNode3 = (XmlNode)obj2;
									aircraft_AirOps.concurrentDictionary_0.TryAdd(xmlNode3.InnerText, 0);
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
							IL_325:
							if (Operators.CompareString(name, "CT", false) != 0)
							{
								continue;
							}
						}
						else
						{
							if (num <= 2760552332U)
							{
								if (num <= 2263481407U)
								{
									if (num != 1852486619U)
									{
										if (num != 2011325326U)
										{
											if (num != 2263481407U)
											{
												continue;
											}
											if (Operators.CompareString(name, "ConditionTimer", false) == 0)
											{
												goto IL_397;
											}
											continue;
										}
										else if (Operators.CompareString(name, "LQ", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "AHU", false) != 0)
										{
											continue;
										}
										goto IL_5D8;
									}
								}
								else if (num != 2508349683U)
								{
									if (num != 2563465583U)
									{
										if (num != 2760552332U)
										{
											continue;
										}
										if (Operators.CompareString(name, "QuickTurnaround_SortiesFlown", false) == 0)
										{
											aircraft_AirOps.int_1 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "A2AR_Connections", false) != 0)
										{
											continue;
										}
										goto IL_4F2;
									}
								}
								else if (Operators.CompareString(name, "LandingQueue", false) != 0)
								{
									continue;
								}
								int num2 = xmlNode.ChildNodes.Count - 1;
								for (int i = 0; i <= num2; i++)
								{
									Class429.smethod_32(ref aircraft_AirOps.string_0, xmlNode.ChildNodes[i].InnerText);
								}
								continue;
							}
							if (num <= 3225512471U)
							{
								if (num == 2851748968U)
								{
									goto IL_57B;
								}
								if (num != 3175179614U)
								{
									if (num != 3225512471U)
									{
										continue;
									}
									if (Operators.CompareString(name, "A2ARD", false) == 0)
									{
										goto IL_4CF;
									}
									continue;
								}
								else if (Operators.CompareString(name, "A2ARC", false) != 0)
								{
									continue;
								}
							}
							else if (num <= 3440622149U)
							{
								if (num != 3433242718U)
								{
									if (num != 3440622149U)
									{
										continue;
									}
									if (Operators.CompareString(name, "AssignedHostUnit", false) == 0)
									{
										goto IL_5D8;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Condition", false) == 0)
									{
										goto IL_635;
									}
									continue;
								}
							}
							else if (num != 3998375324U)
							{
								if (num != 4021522466U)
								{
									continue;
								}
								if (Operators.CompareString(name, "QuickTurnaround_AirborneTime_SortieAverage", false) == 0)
								{
									aircraft_AirOps.float_2 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "HostAirFacility", false) == 0)
								{
									goto IL_6D8;
								}
								continue;
							}
							IL_4F2:
							try
							{
								foreach (object obj3 in xmlNode.ChildNodes)
								{
									string[] array = ((XmlNode)obj3).InnerText.Split(new char[]
									{
										'_'
									});
									if (string.IsNullOrEmpty(array[0]))
									{
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
									}
									else
									{
										aircraft_AirOps.concurrentDictionary_1.TryAdd(array[0], (Aircraft_AirOps.Enum43)Conversions.ToByte(array[1]));
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
							IL_57B:
							if (Operators.CompareString(name, "QuickTurnaround_Enabled", false) == 0)
							{
								aircraft_AirOps.bool_0 = Conversions.ToBoolean(xmlNode.InnerText);
								continue;
							}
							continue;
							IL_5D8:
							if (xmlNode.FirstChild.HasChildNodes)
							{
								XmlNode xmlNode2 = xmlNode.ChildNodes[0];
								ActiveUnit value = ActiveUnit.smethod_9(ref xmlNode2, ref dictionary_0, ref activeUnit_3.scenario_0);
								aircraft_AirOps.method_33(false, value);
								continue;
							}
							aircraft_AirOps.string_3 = xmlNode.InnerText;
							continue;
						}
						IL_397:
						aircraft_AirOps.method_39(XmlConvert.ToSingle(xmlNode.InnerText));
						continue;
						IL_4CF:
						aircraft_AirOps.string_4 = xmlNode.InnerText;
						continue;
						IL_635:
						if (Versioned.IsNumeric(xmlNode.InnerText))
						{
							aircraft_AirOps.method_37((Aircraft_AirOps._AirOpsCondition)Conversions.ToByte(xmlNode.InnerText));
							continue;
						}
						aircraft_AirOps.method_37((Aircraft_AirOps._AirOpsCondition)Enum.Parse(typeof(Aircraft_AirOps._AirOpsCondition), xmlNode.InnerText, true));
						continue;
						IL_6D8:
						if (!string.IsNullOrEmpty(xmlNode.ChildNodes[0].InnerXml))
						{
							Aircraft_AirOps aircraft_AirOps2 = aircraft_AirOps;
							XmlNode xmlNode2 = xmlNode.ChildNodes[0];
							aircraft_AirOps2.method_35(AirFacility.smethod_3(ref xmlNode2, ref dictionary_0, ref activeUnit_3.scenario_0));
							aircraft_AirOps.string_1 = Misc.smethod_44(xmlNode.ChildNodes[0].ChildNodes, "ID").InnerText;
						}
						else
						{
							aircraft_AirOps.string_1 = xmlNode.InnerText;
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
				result = aircraft_AirOps;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100405", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Aircraft_AirOps(ref activeUnit_3);
			}
			return result;
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x000F115C File Offset: 0x000EF35C
		public ActiveUnit method_21()
		{
			ActiveUnit result;
			try
			{
				Mission mission = this.activeUnit_0.vmethod_101();
				if (Information.IsNothing(mission))
				{
					result = this.method_32(true);
				}
				else
				{
					ActiveUnit activeUnit;
					if (mission._MissionClass_0 != Mission._MissionClass.Ferry)
					{
						activeUnit = this.method_32(true);
					}
					else
					{
						if (Information.IsNothing(((FerryMission)mission).method_67(this.activeUnit_0.scenario_0)))
						{
							string text = "";
							if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
							{
								text = " (" + this.activeUnit_0.string_2 + ")";
							}
							this.activeUnit_0.method_124(string.Concat(new string[]
							{
								this.activeUnit_0.Name,
								text,
								" is no longer able to execute ferry mission: ",
								mission.Name,
								" (the ferry destination appears to be missing). The unit will be removed from the mission."
							}), this.activeUnit_0.Name + " cannot execute ferry", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							ActiveUnit activeUnit_ = this.activeUnit_0;
							Mission value = null;
							bool setMissionOnly = false;
							Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
							activeUnit_.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
							activeUnit = this.method_32(true);
						}
						switch (((FerryMission)mission).method_65())
						{
						case FerryMission.FerryMissionBehavior.OneWay:
						{
							ActiveUnit activeUnit2 = ((FerryMission)mission).method_67(this.activeUnit_0.scenario_0);
							if (this.activeUnit_0.scenario_0.FifthSecondIsChangingOnThisPulse && Operators.CompareString(this.method_26(activeUnit2), "OK", false) != 0)
							{
								activeUnit = null;
							}
							else
							{
								activeUnit = activeUnit2;
							}
							break;
						}
						case FerryMission.FerryMissionBehavior.Cycle:
							if (this.activeUnit_0.vmethod_86().method_43())
							{
								ActiveUnit activeUnit3 = ((FerryMission)mission).method_67(this.activeUnit_0.scenario_0);
								if (this.activeUnit_0.scenario_0.FifthSecondIsChangingOnThisPulse && Operators.CompareString(this.method_26(activeUnit3), "OK", false) != 0)
								{
									activeUnit = null;
								}
								else
								{
									activeUnit = activeUnit3;
								}
							}
							else
							{
								activeUnit = this.method_32(true);
							}
							break;
						case FerryMission.FerryMissionBehavior.Random:
							activeUnit = this.method_32(true);
							break;
						default:
							activeUnit = this.method_32(true);
							break;
						}
					}
					if (!Information.IsNothing(activeUnit) && activeUnit.method_120() && activeUnit.vmethod_65(false).method_140())
					{
						activeUnit = activeUnit.vmethod_65(false);
					}
					result = activeUnit;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100406", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x000F1408 File Offset: 0x000EF608
		public bool method_22()
		{
			Aircraft_AirOps._AirOpsCondition airOpsCondition = this.method_36();
			if (airOpsCondition != Aircraft_AirOps._AirOpsCondition.TaxyingToTakeOff && airOpsCondition != Aircraft_AirOps._AirOpsCondition.TakingOff)
			{
				switch (airOpsCondition)
				{
				case Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit:
					return this.method_34().method_34();
				case Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway:
				case Aircraft_AirOps._AirOpsCondition.PreparingToLaunch:
					goto IL_46;
				}
				return false;
			}
			IL_46:
			return true;
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000F1460 File Offset: 0x000EF660
		public int method_23(ActiveUnit activeUnit_3, Group group_0, bool bool_1)
		{
			int result;
			try
			{
				List<string> list = Enumerable.ToList<string>(this.concurrentDictionary_0.Keys);
				try
				{
					foreach (string text in list)
					{
						Aircraft aircraft = (Aircraft)this.method_20().scenario_0.vmethod_0()[text];
						if (aircraft == null || aircraft.vmethod_108() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
						{
							ConcurrentDictionary<string, byte> concurrentDictionary = this.concurrentDictionary_0;
							string text2 = text;
							byte b = 0;
							concurrentDictionary.TryRemove(text2, ref b);
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				list = Enumerable.ToList<string>(this.concurrentDictionary_0.Keys);
				if (activeUnit_3 != null && list.Contains(activeUnit_3.string_0))
				{
					list.Remove(activeUnit_3.string_0);
				}
				if (group_0 != null)
				{
					try
					{
						foreach (ActiveUnit activeUnit in group_0.vmethod_141().Values)
						{
							if (list.Contains(activeUnit.string_0))
							{
								list.Remove(activeUnit.string_0);
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
				int num;
				try
				{
					foreach (string key in list)
					{
						Aircraft aircraft2 = (Aircraft)this.method_20().scenario_0.vmethod_0()[key];
						if (!aircraft2.method_82())
						{
							if (bool_1)
							{
								num += (int)Math.Round((double)aircraft2.vmethod_115() * 0.1);
							}
							else
							{
								num += aircraft2.vmethod_115();
							}
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100407", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00008AC7 File Offset: 0x00006CC7
		public Aircraft method_24()
		{
			return this.aircraft_1;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x000F1690 File Offset: 0x000EF890
		public void method_25(Aircraft aircraft_3)
		{
			try
			{
				if (aircraft_3 != this.aircraft_1 && this.aircraft_1 != null && this.aircraft_1.method_164() != null)
				{
					try
					{
						ConcurrentDictionary<string, byte> concurrentDictionary = this.aircraft_1.method_164().concurrentDictionary_0;
						string string_ = this.method_20().string_0;
						byte b = 0;
						concurrentDictionary.TryRemove(string_, ref b);
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 200020", ex.Message);
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
				}
				this.aircraft_1 = aircraft_3;
				if (aircraft_3 != null && !this.aircraft_1.method_164().concurrentDictionary_0.ContainsKey(this.method_20().string_0))
				{
					this.aircraft_1.method_164().concurrentDictionary_0.TryAdd(this.method_20().string_0, 0);
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100408", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x000F17C0 File Offset: 0x000EF9C0
		public string method_26(ActiveUnit activeUnit_3)
		{
			string result;
			try
			{
				if (Information.IsNothing(activeUnit_3))
				{
					result = "Error";
				}
				else if (activeUnit_3.bool_1 && !activeUnit_3.method_111())
				{
					result = "Selected group does not have runways or landing pads";
				}
				else if (activeUnit_3.vmethod_92().vmethod_8(this.method_20()))
				{
					if (this.method_73(activeUnit_3, true))
					{
						result = "OK";
					}
					else
					{
						result = "Cannot land here";
					}
				}
				else
				{
					result = "The aircraft cannot be hosted on any air facility here";
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100409", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = "Error!";
			}
			return result;
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x000F187C File Offset: 0x000EFA7C
		public void method_27(ActiveUnit activeUnit_3)
		{
			Aircraft_AirOps.Class252 @class = new Aircraft_AirOps.Class252(@class);
			@class.activeUnit_0 = activeUnit_3;
			List<ActiveUnit> list = new List<ActiveUnit>();
			try
			{
				if (!Information.IsNothing(this.method_30()))
				{
					this.method_33(false, this.method_30());
				}
				else
				{
					List<ActiveUnit> list2 = Enumerable.ToList<ActiveUnit>(this.activeUnit_0.vmethod_7(false).activeUnit_0);
					try
					{
						foreach (ActiveUnit activeUnit in list2)
						{
							if (Operators.CompareString(this.method_26(activeUnit), "OK", false) == 0)
							{
								list.Add(activeUnit);
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (list.Count > 0)
					{
						this.activeUnit_2 = Enumerable.ElementAtOrDefault<ActiveUnit>(Enumerable.OrderBy<ActiveUnit, double>(list, new Func<ActiveUnit, double>(@class.method_0)), 0);
						string text = "";
						if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
						{
							text = " (" + this.activeUnit_0.string_2 + ")";
						}
						this.method_20().method_124(string.Concat(new string[]
						{
							this.method_20().Name,
							text,
							" selects a new base to land: ",
							this.activeUnit_2.Name,
							"."
						}), this.method_20().Name + " selected new home", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_20().vmethod_28(null), this.method_20().vmethod_30(null)));
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100410", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x000F1A84 File Offset: 0x000EFC84
		public void method_28()
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			try
			{
				if (!Information.IsNothing(this.method_30()))
				{
					this.method_33(false, this.method_30());
				}
				else
				{
					if (this.activeUnit_0.vmethod_85().method_48() && !string.IsNullOrEmpty(this.activeUnit_0.vmethod_85().method_7().string_9) && this.activeUnit_0.scenario_0.vmethod_0().ContainsKey(this.activeUnit_0.vmethod_85().method_7().string_9))
					{
						this.activeUnit_2 = this.activeUnit_0.scenario_0.vmethod_0()[this.activeUnit_0.vmethod_85().method_7().string_9];
						if (!Information.IsNothing(this.activeUnit_2))
						{
							return;
						}
					}
					List<ActiveUnit> list2 = Enumerable.ToList<ActiveUnit>(this.activeUnit_0.vmethod_7(false).activeUnit_0);
					try
					{
						foreach (ActiveUnit activeUnit in list2)
						{
							if (Operators.CompareString(this.method_26(activeUnit), "OK", false) == 0)
							{
								list.Add(activeUnit);
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (list.Count > 0)
					{
						this.activeUnit_2 = Enumerable.ElementAtOrDefault<ActiveUnit>(Enumerable.OrderBy<ActiveUnit, double>(list, new Func<ActiveUnit, double>(this.method_92)), 0);
						string text = "";
						if (Operators.CompareString(this.method_20().Name, this.method_20().string_2, false) != 0)
						{
							text = " (" + this.method_20().string_2 + ")";
						}
						this.method_20().method_124(string.Concat(new string[]
						{
							this.method_20().Name,
							text,
							" selects a new base to land: ",
							this.activeUnit_2.Name,
							"."
						}), this.method_20().Name + " selects new home", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_20().vmethod_28(null), this.method_20().vmethod_30(null)));
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100411", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x000F1D18 File Offset: 0x000EFF18
		public void method_29(ActiveUnit excludeUnit = null)
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			try
			{
				double num = Math2.smethod_13((double)this.activeUnit_0.vmethod_87().vmethod_24(true, null, null));
				List<ActiveUnit> list2 = Enumerable.ToList<ActiveUnit>(this.activeUnit_0.vmethod_7(false).activeUnit_0);
				try
				{
					foreach (ActiveUnit activeUnit in list2)
					{
						if (!activeUnit.bool_3 && !activeUnit.bool_1 && activeUnit.vmethod_127() && activeUnit != this.activeUnit_0 && this.activeUnit_0.method_31(activeUnit) <= num && Operators.CompareString(this.method_26(activeUnit), "OK", false) == 0)
						{
							list.Add(activeUnit);
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (!Information.IsNothing(excludeUnit) && list.Contains(excludeUnit))
				{
					list.Remove(excludeUnit);
				}
				if (list.Count > 0)
				{
					int index = GameGeneral.smethod_5().Next(list.Count);
					this.activeUnit_2 = list[index];
					string text = "";
					if (Operators.CompareString(this.method_20().Name, this.method_20().string_2, false) != 0)
					{
						text = " (" + this.method_20().string_2 + ")";
					}
					this.method_20().method_124(string.Concat(new string[]
					{
						this.method_20().Name,
						text,
						" selects a new base to land: ",
						this.activeUnit_2.Name,
						"."
					}), this.method_20().Name + " selects new home", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_20().vmethod_28(null), this.method_20().vmethod_30(null)));
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100412", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x000F1F6C File Offset: 0x000F016C
		public ActiveUnit method_30()
		{
			ActiveUnit result;
			try
			{
				if (Information.IsNothing(this.activeUnit_1))
				{
					if (Information.IsNothing(this.method_34()))
					{
						return null;
					}
					List<ActiveUnit> list = this.method_20().scenario_0.method_42();
					try
					{
						foreach (ActiveUnit activeUnit in list)
						{
							if (!Information.IsNothing(activeUnit) && Enumerable.Contains<AirFacility>(activeUnit.vmethod_99(), this.method_34()))
							{
								this.activeUnit_1 = activeUnit;
								break;
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (this.activeUnit_1.method_120())
				{
					Group.GroupType groupType = this.activeUnit_1.vmethod_65(false).method_143();
					if (groupType == Group.GroupType.Installation || groupType - Group.GroupType.AirBase <= 1)
					{
						this.activeUnit_1 = this.activeUnit_1.vmethod_65(false);
					}
				}
				result = this.activeUnit_1;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100413", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00008ACF File Offset: 0x00006CCF
		public void method_31(ActiveUnit activeUnit_3)
		{
			this.activeUnit_1 = activeUnit_3;
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x000F2098 File Offset: 0x000F0298
		public ActiveUnit method_32(bool PickNewAssignedHost = false)
		{
			ActiveUnit result;
			try
			{
				if (PickNewAssignedHost && (Information.IsNothing(this.activeUnit_2) || this.activeUnit_2.method_82()))
				{
					this.method_28();
				}
				result = this.activeUnit_2;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100414", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00008AD8 File Offset: 0x00006CD8
		public void method_33(bool PickNewAssignedHost = false, ActiveUnit value)
		{
			this.activeUnit_2 = value;
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00008AE1 File Offset: 0x00006CE1
		public AirFacility method_34()
		{
			return this.airFacility_0;
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000F2118 File Offset: 0x000F0318
		public void method_35(AirFacility airFacility_1)
		{
			try
			{
				if (!Information.IsNothing(this.airFacility_0))
				{
					ConcurrentDictionary<string, Aircraft> concurrentDictionary = this.airFacility_0.method_24();
					string string_ = this.activeUnit_0.string_0;
					Aircraft aircraft = this.method_20();
					concurrentDictionary.TryRemove(string_, ref aircraft);
				}
				if (!Information.IsNothing(airFacility_1) && !airFacility_1.method_24().ContainsKey(this.activeUnit_0.string_0))
				{
					airFacility_1.method_24().TryAdd(this.activeUnit_0.string_0, this.method_20());
				}
				bool flag = this.airFacility_0 != airFacility_1;
				AirFacility airFacility = this.airFacility_0;
				this.airFacility_0 = airFacility_1;
				if (flag)
				{
					if (Information.IsNothing(this.airFacility_0))
					{
						this.method_31(null);
					}
					else
					{
						this.method_31(this.airFacility_0.method_18());
					}
					if (!Information.IsNothing(airFacility) && !Information.IsNothing(this.airFacility_0) && ((this.airFacility_0.method_33() & !airFacility.method_33()) || (!this.airFacility_0.method_33() & airFacility.method_33())))
					{
						bool flag2 = false;
						foreach (Side side in this.method_20().scenario_0.method_44())
						{
							if (flag2)
							{
								break;
							}
							if (side != this.method_20().vmethod_7(false) && !side.method_67(this.method_20().vmethod_7(false)) && side.method_11().ContainsKey(this.airFacility_0.method_18().string_0))
							{
								List<ActiveUnit> list = Enumerable.ToList<ActiveUnit>(Enumerable.OrderBy<ActiveUnit, double>(side.activeUnit_0, new Func<ActiveUnit, double>(this.method_93)));
								for (int j = list.Count - 1; j >= 0; j += -1)
								{
									ActiveUnit activeUnit = list[j];
									if (!Information.IsNothing(activeUnit))
									{
										if (flag2)
										{
											break;
										}
										if (activeUnit.vmethod_127())
										{
											float num = activeUnit.method_37(this.airFacility_0.method_18(), 0f);
											IEnumerable<Sensor> enumerable = Enumerable.Where<Sensor>(activeUnit.method_78(), (Aircraft_AirOps._Closure$__.$I71-1 == null) ? (Aircraft_AirOps._Closure$__.$I71-1 = new Func<Sensor, bool>(Aircraft_AirOps._Closure$__.$I.method_0)) : Aircraft_AirOps._Closure$__.$I71-1);
											if (Enumerable.Any<Sensor>(enumerable))
											{
												float num2 = Enumerable.Max(Enumerable.Select<Sensor, float>(enumerable, (Aircraft_AirOps._Closure$__.$I71-2 == null) ? (Aircraft_AirOps._Closure$__.$I71-2 = new Func<Sensor, float>(Aircraft_AirOps._Closure$__.$I.method_1)) : Aircraft_AirOps._Closure$__.$I71-2));
												if (num2 > 0f && num <= num2)
												{
													try
													{
														foreach (Sensor sensor in enumerable)
														{
															if (flag2)
															{
																break;
															}
															Sensor sensor2 = sensor;
															Sensor.Enum114 enum114_ = Sensor.Enum114.const_3;
															ActiveUnit activeUnit2 = activeUnit;
															ActiveUnit activeUnit3 = this.airFacility_0.method_18();
															List<GeoPoint> list2 = null;
															float float_ = num;
															Lazy<ObservableDictionary<int, EmissionContainer>> lazy = null;
															List<ActiveUnit> list_ = null;
															bool? flag3 = null;
															bool? flag4 = null;
															Unit.Enum123? @enum = null;
															bool? flag5 = null;
															if (sensor2.method_87(enum114_, activeUnit2, activeUnit3, ref list2, float_, ref lazy, list_, ref flag3, ref flag4, ref @enum, ref flag5) && sensor.method_91(sensor.method_18(), this.method_20()) * 3f >= num)
															{
																flag2 = true;
																Contact contact = side.method_11()[airFacility.method_18().string_0];
																Contact contact_ = side.method_11()[this.airFacility_0.method_18().string_0];
																if (!this.airFacility_0.method_33() & airFacility.method_33())
																{
																	activeUnit.vmethod_88().method_29(this.method_20(), contact_, sensor);
																	Contact.Class269 class2;
																	try
																	{
																		foreach (Contact.Class269 @class in contact.method_73(activeUnit.vmethod_7(false)))
																		{
																			if (Operators.CompareString(@class.string_0, this.method_20().string_0, false) == 0)
																			{
																				class2 = @class;
																				break;
																			}
																		}
																	}
																	finally
																	{
																		List<Contact.Class269>.Enumerator enumerator2;
																		((IDisposable)enumerator2).Dispose();
																	}
																	if (!Information.IsNothing(class2))
																	{
																		activeUnit.vmethod_88().method_76(contact, class2);
																	}
																}
																if (this.airFacility_0.method_33() & !airFacility.method_33())
																{
																	Contact.Class269 class4;
																	try
																	{
																		foreach (Contact.Class269 class3 in contact.method_73(activeUnit.vmethod_7(false)))
																		{
																			if (Operators.CompareString(class3.string_0, this.method_20().string_0, false) == 0)
																			{
																				class4 = class3;
																				break;
																			}
																		}
																	}
																	finally
																	{
																		List<Contact.Class269>.Enumerator enumerator3;
																		((IDisposable)enumerator3).Dispose();
																	}
																	if (!Information.IsNothing(class4))
																	{
																		activeUnit.vmethod_88().method_76(contact, class4);
																	}
																}
															}
														}
													}
													finally
													{
														IEnumerator<Sensor> enumerator;
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
							}
						}
					}
					Aircraft_AirOps.Delegate25 @delegate = Aircraft_AirOps.delegate25_0;
					if (@delegate != null)
					{
						@delegate(this.method_20().string_0);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200569", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x000F2678 File Offset: 0x000F0878
		[CompilerGenerated]
		public static void smethod_8(Aircraft_AirOps.Delegate26 delegate26_1)
		{
			Aircraft_AirOps.Delegate26 @delegate = Aircraft_AirOps.delegate26_0;
			Aircraft_AirOps.Delegate26 delegate2;
			do
			{
				delegate2 = @delegate;
				Aircraft_AirOps.Delegate26 value = (Aircraft_AirOps.Delegate26)Delegate.Combine(delegate2, delegate26_1);
				@delegate = Interlocked.CompareExchange<Aircraft_AirOps.Delegate26>(ref Aircraft_AirOps.delegate26_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00008AE9 File Offset: 0x00006CE9
		public Aircraft_AirOps._AirOpsCondition method_36()
		{
			return this._AirOpsCondition_0;
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x000F26AC File Offset: 0x000F08AC
		public void method_37(Aircraft_AirOps._AirOpsCondition _AirOpsCondition_2)
		{
			bool flag = this._AirOpsCondition_0 != _AirOpsCondition_2;
			this._AirOpsCondition_1 = this._AirOpsCondition_0;
			if (flag)
			{
				if (_AirOpsCondition_2 == Aircraft_AirOps._AirOpsCondition.RTB && this._AirOpsCondition_0 == Aircraft_AirOps._AirOpsCondition.Refuelling)
				{
					this.method_45();
				}
				this._AirOpsCondition_0 = _AirOpsCondition_2;
				Aircraft_AirOps._AirOpsCondition airOpsCondition_ = this._AirOpsCondition_0;
				if (airOpsCondition_ != Aircraft_AirOps._AirOpsCondition.Airborne && airOpsCondition_ != Aircraft_AirOps._AirOpsCondition.BVRAttack && airOpsCondition_ != Aircraft_AirOps._AirOpsCondition.BVRCrank && airOpsCondition_ != Aircraft_AirOps._AirOpsCondition.BVRDrag)
				{
					if (airOpsCondition_ != Aircraft_AirOps._AirOpsCondition.Dogfight)
					{
						if ((airOpsCondition_ < Aircraft_AirOps._AirOpsCondition.Parked || airOpsCondition_ > Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck) && airOpsCondition_ != Aircraft_AirOps._AirOpsCondition.TransferringCargo)
						{
							return;
						}
						Aircraft_AirOps.Delegate26 @delegate = Aircraft_AirOps.delegate26_0;
						if (@delegate != null)
						{
							@delegate(this.activeUnit_0, this._AirOpsCondition_1);
							return;
						}
						return;
					}
				}
				if (this._AirOpsCondition_0 == Aircraft_AirOps._AirOpsCondition.Airborne & this._AirOpsCondition_1 < Aircraft_AirOps._AirOpsCondition.BVRAttack)
				{
					Aircraft_AirOps.Delegate26 delegate2 = Aircraft_AirOps.delegate26_0;
					if (delegate2 != null)
					{
						delegate2(this.activeUnit_0, this._AirOpsCondition_1);
						return;
					}
				}
			}
			else
			{
				this._AirOpsCondition_0 = _AirOpsCondition_2;
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00008AF1 File Offset: 0x00006CF1
		public float method_38()
		{
			return this.float_0;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00008AF9 File Offset: 0x00006CF9
		public void method_39(float float_5)
		{
			this.float_0 = float_5;
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00008B02 File Offset: 0x00006D02
		public Aircraft_AirOps(ref ActiveUnit activeUnit_3) : base(ref activeUnit_3)
		{
			this.concurrentDictionary_0 = new ConcurrentDictionary<string, byte>();
			this.concurrentDictionary_1 = new ConcurrentDictionary<string, Aircraft_AirOps.Enum43>();
			this.float_3 = 0.5f;
			this.float_4 = 2f;
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x000F2780 File Offset: 0x000F0980
		public string method_40()
		{
			string result;
			switch (this.method_36())
			{
			case Aircraft_AirOps._AirOpsCondition.Airborne:
				result = "Airborne";
				break;
			case Aircraft_AirOps._AirOpsCondition.Parked:
				if (!Information.IsNothing(this.method_34()) && !Information.IsNothing(this.method_34().method_18()) && this.method_34().method_18().bool_6)
				{
					if (this.method_34().method_28() == AirFacility.Enum110.const_11)
					{
						result = "Parked on flight deck";
						break;
					}
					if (this.method_34().method_28() == AirFacility.Enum110.const_10)
					{
						result = "Parked in hangar";
						break;
					}
				}
				result = "Parked";
				break;
			case Aircraft_AirOps._AirOpsCondition.TaxyingToTakeOff:
			{
				AirFacility.Enum110 @enum = this.method_34().method_28();
				if (@enum == AirFacility.Enum110.const_12)
				{
					result = "On elevator, enroute to takeoff";
				}
				else
				{
					result = "Taxiing to take off";
				}
				break;
			}
			case Aircraft_AirOps._AirOpsCondition.TaxyingToPark:
			{
				AirFacility.Enum110 enum2 = this.method_34().method_28();
				if (enum2 == AirFacility.Enum110.const_12)
				{
					result = "On elevator, enroute to parking spot";
				}
				else
				{
					result = "Taxiing to parking spot";
				}
				break;
			}
			case Aircraft_AirOps._AirOpsCondition.TakingOff:
				result = "Taking off";
				break;
			case Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown:
				result = "On final approach";
				break;
			case Aircraft_AirOps._AirOpsCondition.Landing_PostTouchdown:
				result = "Completing landing";
				break;
			case Aircraft_AirOps._AirOpsCondition.Readying:
				result = "Readying";
				break;
			case Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit:
				result = "Waiting for available taxiway/elevator";
				break;
			case Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway:
				result = "Waiting for runway to become available";
				break;
			case Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue:
				result = "In landing queue";
				break;
			case Aircraft_AirOps._AirOpsCondition.RTB:
				result = "Returning to base";
				break;
			case Aircraft_AirOps._AirOpsCondition.PreparingToLaunch:
				result = "Preparing to launch";
				break;
			case Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel:
				result = "Manoeuvering to refuel";
				break;
			case Aircraft_AirOps._AirOpsCondition.Refuelling:
				result = "Refuelling";
				break;
			case Aircraft_AirOps._AirOpsCondition.OffloadingFuel:
				result = "Offloading fuel";
				break;
			case Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar:
				result = "Deploying Dipping Sonar";
				break;
			case Aircraft_AirOps._AirOpsCondition.EmergencyLanding:
				result = "Chicken, critically low on fuel";
				break;
			case Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck:
			{
				AirFacility.Enum110 enum3 = this.method_34().method_28();
				if (enum3 == AirFacility.Enum110.const_12)
				{
					result = "On elevator, enroute to flight deck";
				}
				else
				{
					result = "Moving to flight deck";
				}
				break;
			}
			case Aircraft_AirOps._AirOpsCondition.BVRAttack:
				result = "Executing BVR attack";
				break;
			case Aircraft_AirOps._AirOpsCondition.BVRCrank:
				result = "Cranking";
				break;
			case Aircraft_AirOps._AirOpsCondition.Dogfight:
				result = "Dogfight";
				break;
			case Aircraft_AirOps._AirOpsCondition.TransferringCargo:
				result = "Transferring Cargo";
				break;
			case Aircraft_AirOps._AirOpsCondition.BVRDrag:
				result = "Dragging";
				break;
			default:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = this.method_36().ToString();
				break;
			}
			return result;
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x000F29C8 File Offset: 0x000F0BC8
		private void method_41()
		{
			if (this.activeUnit_0.vmethod_101() != null && this.activeUnit_0.vmethod_101().method_12() && this.activeUnit_0.vmethod_101() is Class338)
			{
				Class338 @class = (Class338)this.activeUnit_0.vmethod_101();
				if (this.activeUnit_0 is Aircraft)
				{
					Aircraft aircraft = (Aircraft)this.activeUnit_0;
					if (aircraft.method_167().cargoType_0 != CargoType.NoCargo)
					{
						if (Enumerable.Count<Cargo>(aircraft.cargo_0) > 0)
						{
							aircraft.method_164().method_37(Aircraft_AirOps._AirOpsCondition.PreparingToLaunch);
							return;
						}
						List<ActiveUnit> list = new List<ActiveUnit>();
						if (this.method_30() is Ship)
						{
							list.Add(this.method_30());
						}
						else if (this.method_30() is Facility)
						{
							list.Add(this.method_30());
						}
						else if (this.method_30() is Group)
						{
							try
							{
								foreach (KeyValuePair<string, ActiveUnit> keyValuePair in ((Group)this.method_30()).vmethod_141())
								{
									list.Add(keyValuePair.Value);
								}
							}
							finally
							{
								IEnumerator<KeyValuePair<string, ActiveUnit>> enumerator;
								if (enumerator != null)
								{
									enumerator.Dispose();
								}
							}
						}
						object object_ = ActiveUnit_DockingOps.object_0;
						ObjectFlowControl.CheckForSyncLockOnValueType(object_);
						lock (object_)
						{
							try
							{
								foreach (ActiveUnit activeUnit in list)
								{
									List<Cargo> list2 = ActiveUnit_DockingOps.smethod_11((Interface3)activeUnit, (Interface3)this.activeUnit_0, @class.dictionary_0);
									if (list2.Count > 0)
									{
										ActiveUnit_DockingOps.smethod_13(activeUnit, this.activeUnit_0, list2);
										this.method_37(Aircraft_AirOps._AirOpsCondition.Readying);
										this.method_39(Math.Max(this.method_38(), 1800f));
										try
										{
											foreach (Cargo cargo in list2)
											{
												if (@class.dictionary_0[((Mount)cargo.method_25()).DBID] > 0)
												{
													Dictionary<int, int> dictionary_;
													int dbid;
													(dictionary_ = @class.dictionary_0)[dbid = ((Mount)cargo.method_25()).DBID] = dictionary_[dbid] - 1;
												}
											}
										}
										finally
										{
											List<Cargo>.Enumerator enumerator3;
											((IDisposable)enumerator3).Dispose();
										}
									}
								}
							}
							finally
							{
								List<ActiveUnit>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
						}
					}
				}
			}
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x000F2C80 File Offset: 0x000F0E80
		public void method_42(float float_5)
		{
			if (this.method_20().vmethod_127())
			{
				Aircraft aircraft = this.method_20();
				ref float ptr = ref aircraft.float_26;
				aircraft.float_26 = ptr + float_5;
			}
			try
			{
				this.method_39(this.method_38() - float_5);
				if (this.method_38() < 0f)
				{
					this.method_39(0f);
				}
				checked
				{
					if (this.method_38() <= 0f)
					{
						switch (this.method_36())
						{
						case Aircraft_AirOps._AirOpsCondition.Parked:
							if (!Information.IsNothing(this.method_34()))
							{
								this.method_41();
								if (!this.method_34().method_35() && (this.method_20().method_169() || !this.method_34().method_31()))
								{
									if (this.method_34().method_31())
									{
										List<AirFacility> list = new List<AirFacility>();
										foreach (AirFacility airFacility in this.method_30().vmethod_99())
										{
											if (airFacility.method_31())
											{
												list.Add(airFacility);
											}
										}
										if (list.Count == 1 && this.method_34() == list[0])
										{
											this.method_48(true, false, false);
											break;
										}
									}
									if (this.activeUnit_0.scenario_0.FifthMinuteIsChangingOnThisPulse)
									{
										this.method_54();
									}
								}
								else
								{
									this.method_48(true, false, false);
								}
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.TaxyingToTakeOff:
							if (!this.method_69())
							{
								this.method_70();
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.TaxyingToPark:
							if (this.method_20().method_157() != null && this.method_20().method_157().method_7() != null && this.method_20().method_157().method_7().mission_0 == null)
							{
								this.method_20().method_157().vmethod_10();
							}
							this.method_48(true, true, false);
							break;
						case Aircraft_AirOps._AirOpsCondition.TakingOff:
							this.method_61(float_5);
							break;
						case Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown:
							if (this.method_20().method_36(this.method_21()) > 20f)
							{
								this.vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
							}
							if (this.method_20().method_157().method_81(float_5))
							{
								if (this.method_20().method_157() != null && this.method_20().method_157().method_7() != null && this.method_20().method_157().method_7().mission_0 == null)
								{
									this.method_20().method_157().vmethod_10();
								}
								this.method_58(float_5);
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.Landing_PostTouchdown:
							if (this.method_20().method_157() != null && this.method_20().method_157().method_7() != null && this.method_20().method_157().method_7().mission_0 == null)
							{
								this.method_20().method_157().vmethod_10();
							}
							this.method_48(true, true, false);
							break;
						case Aircraft_AirOps._AirOpsCondition.Readying:
							this.method_54();
							break;
						case Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit:
							if (!this.method_69())
							{
								this.method_70();
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway:
							if (!this.method_69())
							{
								this.method_70();
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue:
							this.method_56();
							break;
						case Aircraft_AirOps._AirOpsCondition.RTB:
							if (!Information.IsNothing(this.method_34()))
							{
								if (this.method_20().method_157() != null && this.method_20().method_157().method_7() != null && this.method_20().method_157().method_7().mission_0 == null)
								{
									this.method_20().method_157().vmethod_10();
								}
								if (this.method_34().method_35() || (!this.method_20().method_169() && this.method_34().method_31()))
								{
									this.method_48(true, true, false);
								}
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.PreparingToLaunch:
							if (!this.method_69())
							{
								this.method_70();
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel:
							this.method_82(false);
							break;
						case Aircraft_AirOps._AirOpsCondition.Refuelling:
							if (!Information.IsNothing(this.method_24()) && !this.method_24().method_82())
							{
								if (this.method_24().method_164().method_36() != Aircraft_AirOps._AirOpsCondition.OffloadingFuel)
								{
									this.method_45();
								}
							}
							else
							{
								this.method_20().vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
								this.method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.OffloadingFuel:
							this.method_44(float_5);
							if (this.concurrentDictionary_1.IsEmpty && !this.activeUnit_0.method_85())
							{
								this.method_20().vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
								this.method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar:
							if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.Unassigned && !this.activeUnit_0.vmethod_85().method_47() && this.activeUnit_0.vmethod_86().vmethod_3() == null)
							{
								this.method_39(120f);
							}
							else
							{
								this.method_20().method_158().vmethod_27();
								if (!this.activeUnit_0.vmethod_87().vmethod_12() && this.activeUnit_0.vmethod_72() == (float)Math.Round(45.720001220703125, 1))
								{
									ActiveUnit activeUnit_ = this.activeUnit_0;
									Aircraft aircraft2 = this.method_20();
									ActiveUnit.Throttle throttle_ = ActiveUnit.Throttle.Cruise;
									ActiveUnit activeUnit_2;
									ActiveUnit activeUnit_3;
									bool bool_ = (activeUnit_2 = this.activeUnit_0).vmethod_76(activeUnit_3 = this.activeUnit_0);
									float float_6 = Aircraft_AI.smethod_2(ref aircraft2, throttle_, ref bool_);
									activeUnit_2.vmethod_77(activeUnit_3, bool_);
									activeUnit_.vmethod_73(float_6);
								}
								this.method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.EmergencyLanding:
							if (this.method_20().method_157().method_81(float_5))
							{
								AirFacility[] array2 = this.method_21().vmethod_99();
								int j = 0;
								while (j < array2.Length)
								{
									AirFacility airFacility2 = array2[j];
									if (airFacility2.vmethod_5() != PlatformComponent._ComponentStatus.Operational || !airFacility2.method_34() || !airFacility2.method_38(this.method_20()))
									{
										j++;
									}
									else
									{
										this.method_35(airFacility2);
										IL_5BA:
										if (this.method_20().method_157().method_81(float_5) && this.method_20().method_157() != null && this.method_20().method_157().method_7() != null && this.method_20().method_157().method_7().mission_0 == null)
										{
											this.method_20().method_157().vmethod_10();
										}
										if (!Information.IsNothing(this.method_34()))
										{
											this.method_60(null, false);
											goto IL_724;
										}
										ActiveUnit activeUnit_4 = this.method_21();
										IEnumerable<AirFacility> enumerable = this.method_59(activeUnit_4);
										if (!Information.IsNothing(enumerable) && Enumerable.Count<AirFacility>(enumerable) > 0)
										{
											foreach (AirFacility airFacility3 in this.method_21().vmethod_99())
											{
												if (airFacility3.vmethod_5() == PlatformComponent._ComponentStatus.Operational && airFacility3.method_34() && airFacility3.method_29() >= this.method_20().aircraftSizeClass_0)
												{
													this.method_60(airFacility3, false);
													break;
												}
											}
											goto IL_724;
										}
										goto IL_724;
									}
								}
								goto IL_5BA;
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck:
							if (!this.method_69())
							{
								this.method_54();
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.TransferringCargo:
							if (Information.IsNothing(this.method_20().method_158().method_8()))
							{
								this.method_89();
							}
							else
							{
								this.method_90((ActiveUnit)this.method_20().method_158().method_8());
							}
							this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
							this.method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
							this.method_39(0f);
							break;
						}
					}
					IL_724:;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100416", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000F3408 File Offset: 0x000F1608
		private float method_43(Aircraft aircraft_3, Aircraft_AirOps.Enum43? nullable_0)
		{
			if (Information.IsNothing(nullable_0))
			{
				nullable_0 = new Aircraft_AirOps.Enum43?(Aircraft_AirOps.Enum43.const_1);
			}
			Aircraft_AirOps.Enum43? @enum = nullable_0;
			byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
			float result;
			if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
			{
				if (aircraft_3.aircraftSizeClass_0 >= GlobalVariables.AircraftSizeClass.Medium)
				{
					result = 22.6f;
				}
				else
				{
					result = 12f;
				}
			}
			else
			{
				b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					result = 11f;
				}
				else
				{
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (!((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						throw new NotImplementedException();
					}
					result = 8.33f;
				}
			}
			return result;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x000F3554 File Offset: 0x000F1754
		private void method_44(float float_5)
		{
			Aircraft_AirOps.Class253 @class = new Aircraft_AirOps.Class253(@class);
			@class.aircraft_AirOps_0 = this;
			List<KeyValuePair<string, Aircraft_AirOps.Enum43>> list = new List<KeyValuePair<string, Aircraft_AirOps.Enum43>>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			try
			{
				list.AddRange(this.concurrentDictionary_1);
				try
				{
					foreach (KeyValuePair<string, Aircraft_AirOps.Enum43> keyValuePair in list)
					{
						if (!Information.IsNothing(keyValuePair.Key))
						{
							@class.aircraft_0 = (Aircraft)this.method_20().scenario_0.vmethod_0()[keyValuePair.Key];
							if (@class.aircraft_0 != this.method_20())
							{
								if (Information.IsNothing(@class.aircraft_0))
								{
									list2.Add(keyValuePair.Key);
								}
								else if (@class.aircraft_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.Refuelling)
								{
									@class.aircraft_0.method_164().method_45();
								}
								else
								{
									float num = this.method_43(@class.aircraft_0, new Aircraft_AirOps.Enum43?(keyValuePair.Value)) * float_5;
									if (!Information.IsNothing(@class.aircraft_0))
									{
										if (@class.aircraft_0.method_120())
										{
											if (!list3.Contains(@class.aircraft_0.vmethod_65(false).string_0))
											{
												List<ActiveUnit> list4 = Enumerable.ToList<ActiveUnit>(Enumerable.OrderBy<ActiveUnit, double>(Enumerable.Where<ActiveUnit>(@class.aircraft_0.vmethod_65(false).vmethod_141().Values, (@class.func_0 == null) ? (@class.func_0 = new Func<ActiveUnit, bool>(@class.method_0)) : @class.func_0), (Aircraft_AirOps._Closure$__.$I91-1 == null) ? (Aircraft_AirOps._Closure$__.$I91-1 = new Func<ActiveUnit, double>(Aircraft_AirOps._Closure$__.$I.method_2)) : Aircraft_AirOps._Closure$__.$I91-1));
												if (list4.Count > 0)
												{
													Aircraft aircraft = (Aircraft)list4[0];
													if (aircraft.vmethod_129() > num)
													{
														aircraft.vmethod_135(num, FuelRec._FuelType.AviationFuel);
														this.method_20().vmethod_136(num, FuelRec._FuelType.AviationFuel);
													}
													else if (@class.aircraft_0.method_157().int_0 == 0)
													{
														@class.aircraft_0.method_164().method_45();
													}
													list3.Add(@class.aircraft_0.vmethod_65(false).string_0);
												}
												else
												{
													@class.aircraft_0.method_164().method_45();
												}
											}
										}
										else if (@class.aircraft_0.vmethod_129() > num)
										{
											@class.aircraft_0.vmethod_135(num, FuelRec._FuelType.AviationFuel);
											this.method_20().vmethod_136(num, FuelRec._FuelType.AviationFuel);
										}
										else if (@class.aircraft_0.method_157().int_0 == 0)
										{
											@class.aircraft_0.method_164().method_45();
										}
									}
								}
							}
						}
					}
				}
				finally
				{
					List<KeyValuePair<string, Aircraft_AirOps.Enum43>>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (list2.Count > 0)
				{
					try
					{
						foreach (string text in list2)
						{
							ConcurrentDictionary<string, Aircraft_AirOps.Enum43> concurrentDictionary = this.concurrentDictionary_1;
							string text2 = text;
							Aircraft_AirOps.Enum43 @enum = Aircraft_AirOps.Enum43.const_0;
							concurrentDictionary.TryRemove(text2, ref @enum);
						}
					}
					finally
					{
						List<string>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100417", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x000F38D0 File Offset: 0x000F1AD0
		public void method_45()
		{
			try
			{
				Aircraft aircraft = null;
				if (this.method_24() != null)
				{
					aircraft = this.method_24();
					ConcurrentDictionary<string, Aircraft_AirOps.Enum43> concurrentDictionary = this.method_24().method_164().concurrentDictionary_1;
					string string_ = this.method_20().string_0;
					Aircraft_AirOps.Enum43 @enum = Aircraft_AirOps.Enum43.const_0;
					concurrentDictionary.TryRemove(string_, ref @enum);
					ConcurrentDictionary<string, byte> concurrentDictionary2 = this.method_24().method_164().concurrentDictionary_0;
					string string_2 = this.method_20().string_0;
					byte b = 0;
					concurrentDictionary2.TryRemove(string_2, ref b);
					this.method_25(null);
				}
				else
				{
					try
					{
						foreach (Aircraft aircraft2 in Enumerable.OfType<Aircraft>(this.method_20().scenario_0.method_42()))
						{
							if (!Information.IsNothing(aircraft2) && aircraft2.method_164().concurrentDictionary_1.ContainsKey(this.method_20().string_0))
							{
								aircraft = aircraft2;
								ConcurrentDictionary<string, Aircraft_AirOps.Enum43> concurrentDictionary3 = aircraft2.method_164().concurrentDictionary_1;
								string string_3 = this.method_20().string_0;
								Aircraft_AirOps.Enum43 @enum = Aircraft_AirOps.Enum43.const_0;
								concurrentDictionary3.TryRemove(string_3, ref @enum);
							}
						}
					}
					finally
					{
						IEnumerator<Aircraft> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				bool isAttached = Debugger.IsAttached;
				if (!Information.IsNothing(aircraft))
				{
					Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
					if (this.method_20().vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling)
					{
						Aircraft_AirOps aircraft_AirOps2 = aircraft_AirOps;
						ref int ptr = ref aircraft_AirOps2.int_0;
						aircraft_AirOps2.int_0 = ptr + 1;
					}
					if (this.method_20()._ActiveUnitStatus_2 == ActiveUnit._ActiveUnitStatus.RTB && (this.method_20()._ActiveUnitFuelState_1 == ActiveUnit._ActiveUnitFuelState.IsBingo || this.method_20()._ActiveUnitFuelState_1 == ActiveUnit._ActiveUnitFuelState.IsJoker))
					{
						this.method_20().vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
					}
					else if (this.method_20()._ActiveUnitStatus_2 == ActiveUnit._ActiveUnitStatus.RTB_CalledOff)
					{
						if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && !this.activeUnit_0.vmethod_86().bool_2)
						{
							this.method_20().vmethod_109(this.method_20()._ActiveUnitStatus_2);
						}
						else
						{
							if (this.activeUnit_0.vmethod_85().method_49())
							{
								this.method_20().vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
							}
							else
							{
								this.method_20().vmethod_109(ActiveUnit._ActiveUnitStatus.Tasked);
							}
							if (this.activeUnit_0.vmethod_85().method_48())
							{
								this.activeUnit_0.vmethod_85().method_7().method_11(this.activeUnit_0.scenario_0, Mission.Enum102.const_5);
							}
						}
					}
					else
					{
						this.method_20().vmethod_109(this.method_20()._ActiveUnitStatus_2);
					}
					this.method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
					this.method_20().vmethod_111(this.method_20().vmethod_61(null, this.method_20().doctrine_0.method_206(this.method_20().scenario_0, false, true, false, false)));
					if (!Information.IsNothing(aircraft) && !aircraft.method_85() && !Information.IsNothing(aircraft.vmethod_101()) && aircraft.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support)
					{
						Class344 @class = (Class344)aircraft.vmethod_101();
						if (@class.bool_24 && aircraft_AirOps.concurrentDictionary_0.Count == 0 && aircraft_AirOps.concurrentDictionary_1.IsEmpty)
						{
							string text = "";
							if (Operators.CompareString(aircraft.Name, aircraft.string_2, false) != 0)
							{
								text = " (" + aircraft.string_2 + ")";
							}
							aircraft.scenario_0.method_59(string.Concat(new string[]
							{
								"Aircraft ",
								aircraft.Name,
								text,
								" is returning to base. The mission ",
								aircraft.vmethod_101().Name,
								" allows one refuelling cycle only, and the tanker queue is now empty."
							}), "Tanker operations", LoggedMessage.MessageType.AirOps, 5, aircraft.string_0, aircraft.vmethod_7(false), new Geopoint_Struct(aircraft.vmethod_28(null), aircraft.vmethod_30(null)));
							aircraft_AirOps.vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB_MissionOver, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
						}
						if (@class.int_8 > 0 && aircraft_AirOps.int_0 >= @class.int_8 && aircraft_AirOps.concurrentDictionary_0.Count == 0 && aircraft_AirOps.concurrentDictionary_1.IsEmpty)
						{
							string text2 = "";
							if (Operators.CompareString(aircraft.Name, aircraft.string_2, false) != 0)
							{
								text2 = " (" + aircraft.string_2 + ")";
							}
							aircraft.scenario_0.method_59(string.Concat(new string[]
							{
								"Aircraft ",
								aircraft.Name,
								text2,
								" is returning to base. The mission ",
								aircraft.vmethod_101().Name,
								" allows ",
								Conversions.ToString(@class.int_8),
								" receivers to be served (rounded up to nearest flight), and a total of ",
								Conversions.ToString(aircraft_AirOps.int_0),
								" refuellings have taken place."
							}), "Tanker operations", LoggedMessage.MessageType.AirOps, 5, aircraft.string_0, aircraft.vmethod_7(false), new Geopoint_Struct(aircraft.vmethod_28(null), aircraft.vmethod_30(null)));
							aircraft_AirOps.vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB_MissionOver, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
						}
					}
					if (this.activeUnit_0.vmethod_101() != null && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
					{
						Doctrine.Enum56? enum2 = this.activeUnit_0.doctrine_0.method_152(this.activeUnit_0.scenario_0, false, false, false, false);
						byte? b2 = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
						bool? flag = (b2 != null) ? new bool?(b2.GetValueOrDefault() == 1) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault() && this.activeUnit_0.vmethod_101().int_5 > 0 && !this.activeUnit_0.method_121())
						{
							ActiveUnit activeUnit = this.method_20();
							double num = 0.0;
							double num2 = 0.0;
							if (activeUnit.vmethod_119(ref num, ref num2, false) < (double)this.activeUnit_0.vmethod_101().int_5 / 100.0)
							{
								GeoPoint geoPoint = this.method_20().method_158().method_18();
								GeoPoint geoPoint_ = geoPoint;
								Doctrine.Enum57 enum57_ = Doctrine.Enum57.const_2;
								bool flag2 = false;
								bool bool_ = false;
								ActiveUnit activeUnit2 = null;
								List<Mission> list = null;
								string text3 = "";
								bool flag3 = false;
								bool flag4 = false;
								if (this.method_80(geoPoint_, enum57_, ref flag2, bool_, ref activeUnit2, ref list, ref text3, ref flag3, ref flag4))
								{
									return;
								}
							}
						}
					}
					List<Waypoint> list2 = Enumerable.ToList<Waypoint>(this.activeUnit_0.vmethod_85().method_4());
					this.method_46(ref list2, false, false);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100418", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x000F3FB0 File Offset: 0x000F21B0
		public void method_46(ref List<Waypoint> list_0, bool bool_1, bool bool_2)
		{
			try
			{
				if (list_0.Count > 0)
				{
					double num = double.MaxValue;
					int num2 = 0;
					Waypoint waypoint2;
					if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && !this.activeUnit_0.vmethod_86().bool_2)
					{
						if (!bool_1 && !this.method_20().method_157().method_29() && !this.method_20().method_157().method_24())
						{
							goto IL_53F;
						}
						try
						{
							foreach (Waypoint waypoint in list_0)
							{
								double num3 = Math2.smethod_14(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), waypoint.imethod_2(), waypoint.imethod_0());
								if (num2 == 0)
								{
									waypoint2 = waypoint;
									num = num3;
								}
								else
								{
									double num4 = Math2.smethod_14(waypoint.imethod_2(), waypoint.imethod_0(), waypoint2.imethod_2(), waypoint2.imethod_0());
									if ((num > num3 || num3 <= num4) && !this.activeUnit_0.vmethod_85().vmethod_29(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), waypoint.imethod_2(), waypoint.imethod_0(), false, 0f, false, null, true, true, false, null))
									{
										waypoint2 = waypoint;
										num = num3;
									}
								}
								num2++;
								if ((!bool_1 && (waypoint.waypointType_0 == Waypoint.WaypointType.InitialPoint || waypoint.waypointType_0 == Waypoint.WaypointType.WeaponLaunch || waypoint.waypointType_0 == Waypoint.WaypointType.WeaponTarget || waypoint.waypointType_0 == Waypoint.WaypointType.Target || waypoint.enum83_0 == Waypoint.Enum83.const_2 || waypoint.enum80_0 == Waypoint.Enum80.const_1 || (!Information.IsNothing(waypoint.nullable_7) && waypoint.float_24 > 0f))) || waypoint.waypointType_0 == Waypoint.WaypointType.LandingMarshal || waypoint.waypointType_0 == Waypoint.WaypointType.Land)
								{
									break;
								}
							}
							goto IL_53F;
						}
						finally
						{
							List<Waypoint>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					if (!this.method_20().method_157().method_25() && !this.method_20().method_157().method_27())
					{
						try
						{
							foreach (Waypoint waypoint3 in list_0)
							{
								double num3 = Math2.smethod_14(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), waypoint3.imethod_2(), waypoint3.imethod_0());
								if (num2 == 0)
								{
									waypoint2 = waypoint3;
									num = num3;
								}
								else
								{
									double num4 = Math2.smethod_14(waypoint3.imethod_2(), waypoint3.imethod_0(), waypoint2.imethod_2(), waypoint2.imethod_0());
									if ((num > num3 || num3 <= num4) && !this.activeUnit_0.vmethod_85().vmethod_29(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), waypoint3.imethod_2(), waypoint3.imethod_0(), false, 0f, false, null, true, true, false, null))
									{
										waypoint2 = waypoint3;
										num = num3;
									}
								}
								num2++;
								if ((!bool_1 && (waypoint3.method_39() || waypoint3.enum83_0 == Waypoint.Enum83.const_2 || waypoint3.enum80_0 == Waypoint.Enum80.const_1 || (!Information.IsNothing(waypoint3.nullable_7) && waypoint3.float_24 > 0f))) || waypoint3.waypointType_0 == Waypoint.WaypointType.LandingMarshal || waypoint3.waypointType_0 == Waypoint.WaypointType.Land)
								{
									break;
								}
							}
							goto IL_53F;
						}
						finally
						{
							List<Waypoint>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
					try
					{
						foreach (Waypoint waypoint4 in list_0)
						{
							double num3 = Math2.smethod_14(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), waypoint4.imethod_2(), waypoint4.imethod_0());
							if (num2 == 0)
							{
								waypoint2 = waypoint4;
								num = num3;
							}
							else
							{
								double num4 = Math2.smethod_14(waypoint4.imethod_2(), waypoint4.imethod_0(), waypoint2.imethod_2(), waypoint2.imethod_0());
								if ((num > num3 || num3 <= num4) && !this.activeUnit_0.vmethod_85().vmethod_29(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), waypoint4.imethod_2(), waypoint4.imethod_0(), false, 0f, false, null, true, true, false, null))
								{
									waypoint2 = waypoint4;
									num = num3;
								}
							}
							num2++;
							if ((!bool_1 && (waypoint4.method_39() || waypoint4.enum83_0 == Waypoint.Enum83.const_2 || waypoint4.enum80_0 == Waypoint.Enum80.const_1 || (!Information.IsNothing(waypoint4.nullable_7) && waypoint4.float_24 > 0f))) || waypoint4.waypointType_0 == Waypoint.WaypointType.LandingMarshal || waypoint4.waypointType_0 == Waypoint.WaypointType.Land)
							{
								break;
							}
						}
					}
					finally
					{
						List<Waypoint>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					IL_53F:
					if (!bool_2)
					{
						if (Information.IsNothing(waypoint2) || num2 <= 1)
						{
							if (this.activeUnit_0.vmethod_85().method_32() && this.activeUnit_0.vmethod_85().method_7() != null)
							{
								int num5 = Enumerable.Count<Waypoint>(this.activeUnit_0.vmethod_85().method_7().method_15()) - 1;
								for (int i = 1; i <= num5; i++)
								{
									if (this.activeUnit_0.vmethod_85().method_7().method_15()[i] == this.activeUnit_0.vmethod_85().method_4()[0])
									{
										Waypoint waypoint_ = this.activeUnit_0.vmethod_85().method_7().method_15()[i - 1];
										this.activeUnit_0.vmethod_85().method_34(waypoint_);
										this.activeUnit_0.vmethod_85().method_35(waypoint_);
										break;
									}
								}
							}
							return;
						}
					}
					else if (Information.IsNothing(waypoint2) || num2 <= 1)
					{
						goto IL_850;
					}
					List<Waypoint> list = new List<Waypoint>();
					if (bool_2)
					{
						try
						{
							foreach (Waypoint waypoint5 in list_0)
							{
								if (waypoint5 == waypoint2)
								{
									break;
								}
								list.Add(waypoint5);
							}
							goto IL_6BA;
						}
						finally
						{
							List<Waypoint>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
					}
					foreach (Waypoint waypoint6 in this.activeUnit_0.vmethod_85().method_4())
					{
						if (waypoint6 == waypoint2)
						{
							break;
						}
						list.Add(waypoint6);
					}
					IL_6BA:
					if (!bool_2 && !Information.IsNothing(this.activeUnit_0.vmethod_85().method_7()) && !Information.IsNothing(this.activeUnit_0.vmethod_85().method_7().method_15()) && list.Count == 0)
					{
						if (this.activeUnit_0.vmethod_85().method_32())
						{
							int num6 = Enumerable.Count<Waypoint>(this.activeUnit_0.vmethod_85().method_7().method_15()) - 1;
							for (int k = 1; k <= num6; k++)
							{
								if (this.activeUnit_0.vmethod_85().method_7().method_15()[k] == this.activeUnit_0.vmethod_85().method_4()[0])
								{
									Waypoint waypoint_2 = this.activeUnit_0.vmethod_85().method_7().method_15()[k - 1];
									this.activeUnit_0.vmethod_85().method_34(waypoint_2);
									this.activeUnit_0.vmethod_85().method_35(waypoint_2);
									break;
								}
							}
						}
					}
					else
					{
						if (bool_2)
						{
							try
							{
								foreach (Waypoint waypoint7 in list)
								{
									if (waypoint7 == waypoint2)
									{
										break;
									}
									list_0.Remove(waypoint7);
								}
								goto IL_852;
							}
							finally
							{
								List<Waypoint>.Enumerator enumerator5;
								((IDisposable)enumerator5).Dispose();
							}
						}
						try
						{
							List<Waypoint>.Enumerator enumerator6 = list.GetEnumerator();
							while (enumerator6.MoveNext() && enumerator6.Current != waypoint2)
							{
								Class211 @class = this.method_20().method_157();
								float num7 = 0f;
								bool flag = true;
								bool flag2 = false;
								@class.vmethod_19(num7, ref flag, ref flag2);
							}
						}
						finally
						{
							List<Waypoint>.Enumerator enumerator6;
							((IDisposable)enumerator6).Dispose();
						}
					}
					IL_850:;
				}
				IL_852:;
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

		// Token: 0x06000C68 RID: 3176 RVA: 0x00008B37 File Offset: 0x00006D37
		public void method_47(ActiveUnit activeUnit_3)
		{
			this.method_37(Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue);
			if (!Enumerable.Contains<Aircraft>(activeUnit_3.vmethod_92().method_4(), this.method_20()))
			{
				activeUnit_3.vmethod_92().method_7(this.method_20());
			}
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x000F48F8 File Offset: 0x000F2AF8
		public void method_48(bool NormalLandingSequence = true, bool RearmRefuel = true, bool AbortLaunch = false)
		{
			try
			{
				if (!Information.IsNothing(this.method_30()))
				{
					if (Information.IsNothing(this.method_34()) && !Information.IsNothing(this.method_32(false)))
					{
						this.method_32(false).vmethod_92().method_18(this.method_20(), true);
					}
					if (!NormalLandingSequence)
					{
						for (int i = this.method_30().vmethod_99().Length - 1; i >= 0; i += -1)
						{
							AirFacility airFacility = this.method_30().vmethod_99()[i];
							if (airFacility.method_28() == AirFacility.Enum110.const_10 && airFacility.method_38(this.method_20()))
							{
								this.method_66(airFacility, RearmRefuel, AbortLaunch);
								return;
							}
						}
						for (int j = this.method_30().vmethod_99().Length - 1; j >= 0; j += -1)
						{
							AirFacility airFacility = this.method_30().vmethod_99()[j];
							if (airFacility.method_28() == AirFacility.Enum110.const_11 && airFacility.method_38(this.method_20()))
							{
								this.method_66(airFacility, RearmRefuel, AbortLaunch);
								return;
							}
						}
						int k = this.method_30().vmethod_99().Length - 1;
						while (k >= 0)
						{
							AirFacility airFacility = this.method_30().vmethod_99()[k];
							if (airFacility.method_28() != AirFacility.Enum110.const_11)
							{
								if (airFacility.method_28() != AirFacility.Enum110.const_10)
								{
									k += -1;
									continue;
								}
							}
							this.method_66(airFacility, RearmRefuel, AbortLaunch);
							return;
						}
						this.method_39(5f);
					}
					else
					{
						AirFacility.Enum110 @enum = this.method_34().method_28();
						if (@enum <= AirFacility.Enum110.const_9)
						{
							switch (@enum)
							{
							case AirFacility.Enum110.const_1:
							case AirFacility.Enum110.const_2:
							case AirFacility.Enum110.const_5:
							case AirFacility.Enum110.const_6:
							case AirFacility.Enum110.const_7:
								break;
							case AirFacility.Enum110.const_3:
							case AirFacility.Enum110.const_4:
								goto IL_621;
							default:
								if (@enum - AirFacility.Enum110.const_8 > 1)
								{
									goto IL_7A6;
								}
								break;
							}
							int l = this.method_30().vmethod_99().Length - 1;
							while (l >= 0)
							{
								AirFacility airFacility2 = this.method_30().vmethod_99()[l];
								if (airFacility2.method_28() != AirFacility.Enum110.const_10 || !airFacility2.method_38(this.method_20()))
								{
									l += -1;
								}
								else
								{
									bool flag = true;
									IL_1F2:
									if (!flag)
									{
										for (int m = this.method_30().vmethod_99().Length - 1; m >= 0; m += -1)
										{
											airFacility2 = this.method_30().vmethod_99()[m];
											if (airFacility2.method_28() == AirFacility.Enum110.const_11 && airFacility2.method_38(this.method_20()))
											{
												this.method_66(airFacility2, RearmRefuel, AbortLaunch);
												return;
											}
										}
										int n = this.method_30().vmethod_99().Length - 1;
										while (n >= 0)
										{
											airFacility2 = this.method_30().vmethod_99()[n];
											if (airFacility2.method_28() != AirFacility.Enum110.const_11)
											{
												if (airFacility2.method_28() != AirFacility.Enum110.const_10)
												{
													n += -1;
													continue;
												}
											}
											this.method_66(airFacility2, RearmRefuel, AbortLaunch);
											return;
										}
										this.method_39(5f);
										goto IL_7A6;
									}
									if (this.method_34().method_18().bool_6)
									{
										Ship.Enum118 enum118_ = ((Ship)this.method_34().method_18()).enum118_0;
										if (enum118_ != Ship.Enum118.const_2 && enum118_ != Ship.Enum118.const_7 && enum118_ != Ship.Enum118.const_8)
										{
											for (int num = this.method_30().vmethod_99().Length - 1; num >= 0; num += -1)
											{
												airFacility2 = this.method_30().vmethod_99()[num];
												if (airFacility2.method_34() && airFacility2.method_38(this.method_20()))
												{
													this.method_66(airFacility2, RearmRefuel, AbortLaunch);
													return;
												}
											}
											int num2 = this.method_30().vmethod_99().Length - 1;
											while (num2 >= 0)
											{
												airFacility2 = this.method_30().vmethod_99()[num2];
												if (airFacility2.method_28() != AirFacility.Enum110.const_11)
												{
													if (airFacility2.method_28() != AirFacility.Enum110.const_10)
													{
														num2 += -1;
														continue;
													}
												}
												this.method_66(airFacility2, RearmRefuel, AbortLaunch);
												return;
											}
										}
									}
									IEnumerable<AirFacility> enumerable = Enumerable.OrderBy<AirFacility, GlobalVariables.AircraftSizeClass>(base.method_1(this.method_30()), (Aircraft_AirOps._Closure$__.$I95-0 == null) ? (Aircraft_AirOps._Closure$__.$I95-0 = new Func<AirFacility, GlobalVariables.AircraftSizeClass>(Aircraft_AirOps._Closure$__.$I.method_3)) : Aircraft_AirOps._Closure$__.$I95-0);
									if (!Information.IsNothing(enumerable) && Enumerable.Count<AirFacility>(enumerable) > 0)
									{
										IEnumerable<AirFacility> enumerable2 = base.method_0(new bool?(false), this.method_20(), this.method_30(), enumerable);
										if (!Information.IsNothing(enumerable2) && Enumerable.Count<AirFacility>(enumerable2) > 0)
										{
											this.method_75(Enumerable.ElementAtOrDefault<AirFacility>(enumerable2, 0), Aircraft_AirOps.Enum42.const_1);
											return;
										}
										for (int num3 = this.method_30().vmethod_99().Length - 1; num3 >= 0; num3 += -1)
										{
											airFacility2 = this.method_30().vmethod_99()[num3];
											if (airFacility2.method_28() == AirFacility.Enum110.const_11 && airFacility2.method_38(this.method_20()))
											{
												this.method_66(airFacility2, RearmRefuel, AbortLaunch);
												return;
											}
										}
										int num4 = this.method_30().vmethod_99().Length - 1;
										while (num4 >= 0)
										{
											airFacility2 = this.method_30().vmethod_99()[num4];
											if (airFacility2.method_28() != AirFacility.Enum110.const_11)
											{
												if (airFacility2.method_28() != AirFacility.Enum110.const_10)
												{
													num4 += -1;
													continue;
												}
											}
											this.method_66(airFacility2, RearmRefuel, AbortLaunch);
											return;
										}
										this.method_39(5f);
										this.method_30().vmethod_92().method_11();
										goto IL_7A6;
									}
									else
									{
										if (this.method_34().method_18().bool_6)
										{
											for (int num5 = this.method_30().vmethod_99().Length - 1; num5 >= 0; num5 += -1)
											{
												airFacility2 = this.method_30().vmethod_99()[num5];
												if (airFacility2.method_28() == AirFacility.Enum110.const_11 && airFacility2.method_38(this.method_20()))
												{
													this.method_66(airFacility2, RearmRefuel, AbortLaunch);
													return;
												}
											}
											int num6 = this.method_30().vmethod_99().Length - 1;
											while (num6 >= 0)
											{
												airFacility2 = this.method_30().vmethod_99()[num6];
												if (airFacility2.method_28() != AirFacility.Enum110.const_11)
												{
													if (airFacility2.method_28() != AirFacility.Enum110.const_10)
													{
														num6 += -1;
														continue;
													}
												}
												this.method_66(airFacility2, RearmRefuel, AbortLaunch);
												return;
											}
											this.method_39(5f);
											goto IL_7A6;
										}
										goto IL_7A6;
									}
								}
							}
							goto IL_1F2;
						}
						if (@enum - AirFacility.Enum110.const_10 > 1)
						{
							if (@enum != AirFacility.Enum110.const_12)
							{
								goto IL_7A6;
							}
						}
						else if (AbortLaunch)
						{
							if (!RearmRefuel)
							{
								this.method_37(Aircraft_AirOps._AirOpsCondition.Readying);
							}
							if (!Information.IsNothing(this.activeUnit_0.vmethod_65(false)))
							{
								this.activeUnit_0.vmethod_66(false, null);
								goto IL_7A6;
							}
							goto IL_7A6;
						}
						else
						{
							if (this.method_38() != 0f)
							{
								goto IL_7A6;
							}
							this.method_37(Aircraft_AirOps._AirOpsCondition.Parked);
							if (!Information.IsNothing(this.activeUnit_0.vmethod_65(false)))
							{
								this.activeUnit_0.vmethod_66(false, null);
								goto IL_7A6;
							}
							goto IL_7A6;
						}
						IL_621:
						for (int num7 = this.method_30().vmethod_99().Length - 1; num7 >= 0; num7 += -1)
						{
							AirFacility airFacility3 = this.method_30().vmethod_99()[num7];
							if (airFacility3.method_28() == AirFacility.Enum110.const_10 && airFacility3.method_38(this.method_20()))
							{
								this.method_66(airFacility3, RearmRefuel, AbortLaunch);
								return;
							}
						}
						for (int num8 = this.method_30().vmethod_99().Length - 1; num8 >= 0; num8 += -1)
						{
							AirFacility airFacility3 = this.method_30().vmethod_99()[num8];
							if (airFacility3.method_28() == AirFacility.Enum110.const_11 && airFacility3.method_38(this.method_20()))
							{
								this.method_66(airFacility3, RearmRefuel, AbortLaunch);
								return;
							}
						}
						int num9 = this.method_30().vmethod_99().Length - 1;
						while (num9 >= 0)
						{
							AirFacility airFacility3 = this.method_30().vmethod_99()[num9];
							if (airFacility3.method_28() != AirFacility.Enum110.const_11)
							{
								if (airFacility3.method_28() != AirFacility.Enum110.const_10)
								{
									num9 += -1;
									continue;
								}
							}
							this.method_66(airFacility3, RearmRefuel, AbortLaunch);
							return;
						}
						this.method_39(5f);
						IL_7A6:;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101191", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x000F5104 File Offset: 0x000F3304
		public void method_49(ref Aircraft aircraft_3)
		{
			if (aircraft_3.method_164().bool_0)
			{
				ref int ptr = ref this.int_1;
				this.int_1 = ptr + 1;
				return;
			}
			this.int_1 = 0;
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x000F5134 File Offset: 0x000F3334
		public void method_50(ref Aircraft aircraft_3)
		{
			ref float ptr = ref this.float_1;
			this.float_1 = ptr + aircraft_3.float_26;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x000F5154 File Offset: 0x000F3354
		public void method_51(ref Aircraft_AirOps aircraft_AirOps_0, ref Aircraft aircraft_3)
		{
			if (!Information.IsNothing(aircraft_3.method_167()) && aircraft_AirOps_0.method_38() < (float)(aircraft_AirOps_0.int_3 * 60))
			{
				aircraft_AirOps_0.method_39((float)(aircraft_AirOps_0.int_3 * 60));
			}
			aircraft_AirOps_0.int_1 = 0;
			aircraft_AirOps_0.int_3 = 0;
			aircraft_AirOps_0.float_1 = 0f;
			aircraft_AirOps_0.float_2 = 0f;
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x000F51C0 File Offset: 0x000F33C0
		public void method_52(ref Aircraft_AirOps aircraft_AirOps_0, ref Aircraft aircraft_3)
		{
			if (!Information.IsNothing(aircraft_3.method_167()))
			{
				aircraft_AirOps_0.method_39((float)(aircraft_3.method_167().int_9 * 60));
			}
			aircraft_AirOps_0.float_2 = aircraft_AirOps_0.float_1 / (float)aircraft_AirOps_0.int_1;
			if (float.IsNaN(aircraft_AirOps_0.float_2))
			{
				aircraft_AirOps_0.float_2 = 0f;
			}
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00008B6A File Offset: 0x00006D6A
		public void method_53(ref Aircraft_AirOps aircraft_AirOps_0)
		{
			if (aircraft_AirOps_0.bool_0)
			{
				aircraft_AirOps_0.bool_0 = false;
				aircraft_AirOps_0.int_1 = 0;
				aircraft_AirOps_0.int_3 = 0;
				aircraft_AirOps_0.float_1 = 0f;
				aircraft_AirOps_0.float_2 = 0f;
			}
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000F5224 File Offset: 0x000F3424
		public void method_54()
		{
			try
			{
				if (!Information.IsNothing(this.method_34()))
				{
					if (!Information.IsNothing(this.method_34().method_18()))
					{
						bool flag;
						if (!this.method_34().method_18().bool_6)
						{
							flag = true;
						}
						if (!flag)
						{
							Ship.Enum118 enum118_ = ((Ship)this.method_34().method_18()).enum118_0;
							if (enum118_ != Ship.Enum118.const_2 && enum118_ != Ship.Enum118.const_7 && enum118_ != Ship.Enum118.const_8)
							{
								flag = true;
							}
						}
						if (!flag && this.method_34().method_28() == AirFacility.Enum110.const_11)
						{
							flag = true;
						}
						if (flag)
						{
							if (this.method_36() != Aircraft_AirOps._AirOpsCondition.Parked)
							{
								this.method_37(Aircraft_AirOps._AirOpsCondition.Parked);
								if (!Information.IsNothing(this.method_30()))
								{
									string str = "";
									if (Operators.CompareString(this.method_20().Name, this.method_20().string_2, false) != 0)
									{
										str = " (" + this.method_20().string_2 + ")";
									}
									this.method_20().method_124(this.method_20().Name + str + " is ready at " + this.method_30().Name, this.method_20().Name + " ready", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_30().vmethod_28(null), this.method_30().vmethod_30(null)));
								}
							}
						}
						else if (Information.IsNothing(this.method_20().method_167()))
						{
							if (this.method_36() != Aircraft_AirOps._AirOpsCondition.Parked)
							{
								this.method_37(Aircraft_AirOps._AirOpsCondition.Parked);
								if (!Information.IsNothing(this.method_30()))
								{
									string str2 = "";
									if (Operators.CompareString(this.method_20().Name, this.method_20().string_2, false) != 0)
									{
										str2 = " (" + this.method_20().string_2 + ")";
									}
									this.method_20().method_124(this.method_20().Name + str2 + " is ready at " + this.method_30().Name, this.method_20().Name + " ready", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_30().vmethod_28(null), this.method_30().vmethod_30(null)));
								}
							}
						}
						else
						{
							if (this.method_20().method_167().loadoutRole_0 != Loadout.LoadoutRole.Reserve)
							{
								if (this.method_20().method_167().loadoutRole_0 != Loadout.LoadoutRole.Unavailable)
								{
									AirFacility.Enum110 @enum = this.method_34().method_28();
									if (@enum == AirFacility.Enum110.const_10)
									{
										if (!Information.IsNothing(this.method_30().vmethod_92().method_4()) && !Information.IsNothing(this.method_30().vmethod_92().vmethod_5()))
										{
											List<AirFacility> list = Enumerable.ToList<AirFacility>(Enumerable.Where<AirFacility>(this.method_30().vmethod_99(), (Aircraft_AirOps._Closure$__.$I101-0 == null) ? (Aircraft_AirOps._Closure$__.$I101-0 = new Func<AirFacility, bool>(Aircraft_AirOps._Closure$__.$I.method_4)) : Aircraft_AirOps._Closure$__.$I101-0));
											List<AirFacility> list2 = Enumerable.ToList<AirFacility>(Enumerable.Where<AirFacility>(list, (Aircraft_AirOps._Closure$__.$I101-1 == null) ? (Aircraft_AirOps._Closure$__.$I101-1 = new Func<AirFacility, bool>(Aircraft_AirOps._Closure$__.$I.method_5)) : Aircraft_AirOps._Closure$__.$I101-1));
											if (((Enumerable.Count<Aircraft>(this.method_30().vmethod_92().method_4()) > 0 || Enumerable.Count<Aircraft>(this.method_30().vmethod_92().vmethod_5()) > 0) && list.Count - list2.Count <= 2) || (!Information.IsNothing(this.method_30().vmethod_92().method_10()) && list.Count - list2.Count <= 2))
											{
												goto IL_73A;
											}
										}
										int num;
										for (int i = this.method_30().vmethod_99().Length - 1; i >= 0; i += -1)
										{
											AirFacility airFacility = this.method_30().vmethod_99()[i];
											if (airFacility.method_28() == AirFacility.Enum110.const_12)
											{
												try
												{
													foreach (Aircraft aircraft in airFacility.method_24().Values)
													{
														if (aircraft.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck)
														{
															num = (int)((byte)num + aircraft.aircraftSizeClass_0);
														}
													}
												}
												finally
												{
													IEnumerator<Aircraft> enumerator;
													if (enumerator != null)
													{
														enumerator.Dispose();
													}
												}
											}
										}
										int j = this.method_30().vmethod_99().Length - 1;
										while (j >= 0)
										{
											AirFacility airFacility = this.method_30().vmethod_99()[j];
											if (airFacility.method_28() != AirFacility.Enum110.const_11 || !airFacility.method_38(this.method_20()) || airFacility.vmethod_5() == PlatformComponent._ComponentStatus.Destroyed || (double)airFacility.method_37() / (double)airFacility.method_29() <= (double)(4 + num))
											{
												j += -1;
											}
											else
											{
												bool flag2 = true;
												IL_5AE:
												if (!flag2)
												{
													goto IL_73A;
												}
												IEnumerable<AirFacility> enumerable = Enumerable.OrderBy<AirFacility, GlobalVariables.AircraftSizeClass>(base.method_1(this.method_30()), (Aircraft_AirOps._Closure$__.$I101-2 == null) ? (Aircraft_AirOps._Closure$__.$I101-2 = new Func<AirFacility, GlobalVariables.AircraftSizeClass>(Aircraft_AirOps._Closure$__.$I.method_6)) : Aircraft_AirOps._Closure$__.$I101-2);
												if (Information.IsNothing(enumerable) || Enumerable.Count<AirFacility>(enumerable) <= 0)
												{
													goto IL_73A;
												}
												IEnumerable<AirFacility> enumerable2 = base.method_0(null, this.method_20(), this.method_30(), enumerable);
												if (!Information.IsNothing(enumerable2) && Enumerable.Count<AirFacility>(enumerable2) > 0)
												{
													if (this.method_36() != Aircraft_AirOps._AirOpsCondition.Parked && !Information.IsNothing(this.method_30()))
													{
														string text = "";
														if (Operators.CompareString(this.method_20().Name, this.method_20().string_2, false) != 0)
														{
															text = " (" + this.method_20().string_2 + ")";
														}
														this.method_20().method_124(string.Concat(new string[]
														{
															this.method_20().Name,
															text,
															" is ready at ",
															this.method_30().Name,
															", moving to flight deck..."
														}), this.method_20().Name + " ready", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_30().vmethod_28(null), this.method_30().vmethod_30(null)));
													}
													this.method_75(Enumerable.ElementAtOrDefault<AirFacility>(enumerable2, 0), Aircraft_AirOps.Enum42.const_2);
													return;
												}
												goto IL_73A;
											}
										}
										goto IL_5AE;
									}
									if (@enum == AirFacility.Enum110.const_12)
									{
										for (int k = this.method_30().vmethod_99().Length - 1; k >= 0; k += -1)
										{
											AirFacility airFacility2 = this.method_30().vmethod_99()[k];
											if (airFacility2.method_28() == AirFacility.Enum110.const_11 && airFacility2.method_38(this.method_20()) && airFacility2.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed && (double)airFacility2.method_37() / (double)airFacility2.method_29() > 4.0)
											{
												this.method_66(airFacility2, false, false);
												this.method_37(Aircraft_AirOps._AirOpsCondition.Parked);
												return;
											}
										}
										for (int l = this.method_30().vmethod_99().Length - 1; l >= 0; l += -1)
										{
											AirFacility airFacility2 = this.method_30().vmethod_99()[l];
											if (airFacility2.method_28() == AirFacility.Enum110.const_10 && airFacility2.method_38(this.method_20()))
											{
												this.method_66(airFacility2, false, false);
												this.method_37(Aircraft_AirOps._AirOpsCondition.Parked);
												return;
											}
										}
									}
									IL_73A:
									if (this.method_36() != Aircraft_AirOps._AirOpsCondition.Parked)
									{
										this.method_37(Aircraft_AirOps._AirOpsCondition.Parked);
										if (!Information.IsNothing(this.method_30()))
										{
											string str3 = "";
											if (Operators.CompareString(this.method_20().Name, this.method_20().string_2, false) != 0)
											{
												str3 = " (" + this.method_20().string_2 + ")";
											}
											this.method_20().method_124(this.method_20().Name + str3 + " is ready at " + this.method_30().Name, this.method_20().Name + " ready", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_30().vmethod_28(null), this.method_30().vmethod_30(null)));
										}
									}
									return;
								}
							}
							if (this.method_36() != Aircraft_AirOps._AirOpsCondition.Parked)
							{
								this.method_37(Aircraft_AirOps._AirOpsCondition.Parked);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100419", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00008BA5 File Offset: 0x00006DA5
		private void method_55()
		{
			this.method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
			this.method_39(1f);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x000F5AC4 File Offset: 0x000F3CC4
		private void method_56()
		{
			try
			{
				ActiveUnit activeUnit = this.method_21();
				if (Information.IsNothing(activeUnit))
				{
					this.method_55();
				}
				else if (Enumerable.Count<Aircraft>(activeUnit.vmethod_92().method_4()) == 0 || activeUnit.vmethod_92().method_4()[0] == this.activeUnit_0)
				{
					IEnumerable<AirFacility> enumerable = Enumerable.ThenBy<AirFacility, GlobalVariables.AircraftSizeClass>(Enumerable.OrderBy<AirFacility, GlobalVariables.AircraftSizeClass>(Aircraft_AirOps.smethod_9(this.method_20(), false, true, this.method_21(), this.method_20().method_154()), (Aircraft_AirOps._Closure$__.$I103-0 == null) ? (Aircraft_AirOps._Closure$__.$I103-0 = new Func<AirFacility, GlobalVariables.AircraftSizeClass>(Aircraft_AirOps._Closure$__.$I.method_7)) : Aircraft_AirOps._Closure$__.$I103-0), (Aircraft_AirOps._Closure$__.$I103-1 == null) ? (Aircraft_AirOps._Closure$__.$I103-1 = new Func<AirFacility, GlobalVariables.AircraftSizeClass>(Aircraft_AirOps._Closure$__.$I.method_8)) : Aircraft_AirOps._Closure$__.$I103-1);
					IEnumerable<AirFacility> enumerable2;
					if (!Information.IsNothing(enumerable) && Enumerable.Count<AirFacility>(enumerable) > 0)
					{
						enumerable2 = base.method_2(false, false, this.method_20(), this.method_21(), this.method_20().method_154(), enumerable);
					}
					if (!Information.IsNothing(enumerable2) && Enumerable.Count<AirFacility>(enumerable2) != 0)
					{
						try
						{
							IEnumerator<AirFacility> enumerator = enumerable.GetEnumerator();
							if (enumerator.MoveNext())
							{
								AirFacility airFacility_ = enumerator.Current;
								this.method_57(airFacility_);
								return;
							}
						}
						finally
						{
							IEnumerator<AirFacility> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						this.method_39(10f);
					}
					else
					{
						this.method_39(5f);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100420", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00008BB9 File Offset: 0x00006DB9
		private void method_57(AirFacility airFacility_1)
		{
			this.method_21().vmethod_92().method_8(this.method_20());
			this.method_37(Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown);
			this.method_39(120f);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x000F5C80 File Offset: 0x000F3E80
		public void method_58(float float_5)
		{
			try
			{
				this.method_20().method_157().vmethod_10();
				ActiveUnit activeUnit = this.method_21();
				IEnumerable<AirFacility> enumerable = this.method_59(activeUnit);
				bool flag = activeUnit.vmethod_92().vmethod_8(this.method_20());
				if (Information.IsNothing(enumerable))
				{
					Class211 @class = this.method_20().method_157();
					ActiveUnit activeUnit2 = activeUnit;
					float num = (float)this.activeUnit_0.vmethod_87().vmethod_40(this.method_20().vmethod_14(false), ActiveUnit.Throttle.Cruise, false);
					Class211 class2 = this.method_20().method_157();
					bool flag2 = false;
					float num2 = class2.method_73(ref flag2);
					Aircraft aircraft;
					ActiveUnit activeUnit3;
					bool bool_ = (aircraft = this.method_20()).vmethod_76(activeUnit3 = this.method_20());
					@class.method_78(float_5, activeUnit2, num, num2, ref bool_);
					aircraft.vmethod_77(activeUnit3, bool_);
				}
				else if (!flag)
				{
					this.method_20().method_158().vmethod_29(float_5);
				}
				else
				{
					this.method_60(Enumerable.ElementAtOrDefault<AirFacility>(enumerable, 0), true);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100421", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x000F5DA0 File Offset: 0x000F3FA0
		private IEnumerable<AirFacility> method_59(ActiveUnit activeUnit_3)
		{
			IEnumerable<AirFacility> result;
			if (activeUnit_3.vmethod_99().Length == 0)
			{
				result = null;
			}
			else
			{
				try
				{
					IEnumerable<AirFacility> enumerable = Enumerable.ThenBy<AirFacility, GlobalVariables.AircraftSizeClass>(Enumerable.OrderBy<AirFacility, GlobalVariables.AircraftSizeClass>(Aircraft_AirOps.smethod_9(this.method_20(), false, false, activeUnit_3, this.method_20().method_154()), (Aircraft_AirOps._Closure$__.$I106-0 == null) ? (Aircraft_AirOps._Closure$__.$I106-0 = new Func<AirFacility, GlobalVariables.AircraftSizeClass>(Aircraft_AirOps._Closure$__.$I.method_9)) : Aircraft_AirOps._Closure$__.$I106-0), (Aircraft_AirOps._Closure$__.$I106-1 == null) ? (Aircraft_AirOps._Closure$__.$I106-1 = new Func<AirFacility, GlobalVariables.AircraftSizeClass>(Aircraft_AirOps._Closure$__.$I.method_10)) : Aircraft_AirOps._Closure$__.$I106-1);
					IEnumerable<AirFacility> enumerable2;
					if (!Information.IsNothing(enumerable) && Enumerable.Count<AirFacility>(enumerable) > 0)
					{
						enumerable2 = base.method_2(false, true, this.method_20(), activeUnit_3, this.method_20().method_154(), enumerable);
					}
					if (!Information.IsNothing(enumerable2) && Enumerable.Count<AirFacility>(enumerable2) > 0)
					{
						result = enumerable2;
					}
					else
					{
						result = null;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100422", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
			return result;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x000F5EB8 File Offset: 0x000F40B8
		public void method_60(AirFacility theRunway, bool NormalLandingSequence = true)
		{
			try
			{
				if (this.method_20().method_157() != null && this.method_20().method_157().method_7() != null && this.method_20().method_157().method_7().mission_0 == null)
				{
					this.method_20().method_157().vmethod_10();
				}
				Mission mission_ = this.activeUnit_0.vmethod_101();
				this.method_20().method_157().vmethod_10();
				Aircraft aircraft = this.method_20();
				this.method_50(ref aircraft);
				this.method_20().method_157().referencePoint_0 = null;
				this.activeUnit_0.vmethod_113(ActiveUnit._ActiveUnitWeaponState.None);
				this.activeUnit_0.vmethod_111(ActiveUnit._ActiveUnitFuelState.None);
				this.activeUnit_0.vmethod_86().bool_3 = false;
				this.int_0 = 0;
				if (NormalLandingSequence)
				{
					this.method_35(theRunway);
					this.method_37(Aircraft_AirOps._AirOpsCondition.Landing_PostTouchdown);
					switch (this.method_20().vmethod_121())
					{
					case GlobalVariables.TargetVisualSizeClass.Stealthy:
						this.method_39(20f);
						break;
					case GlobalVariables.TargetVisualSizeClass.VSmall:
						this.method_39(30f);
						break;
					case GlobalVariables.TargetVisualSizeClass.Small:
						this.method_39(30f);
						break;
					case GlobalVariables.TargetVisualSizeClass.Medium:
						this.method_39(30f);
						break;
					case GlobalVariables.TargetVisualSizeClass.Large:
						this.method_39(30f);
						break;
					case GlobalVariables.TargetVisualSizeClass.VLarge:
						this.method_39(30f);
						break;
					}
					this.method_63(mission_);
				}
				else
				{
					this.method_37(Aircraft_AirOps._AirOpsCondition.Landing_PostTouchdown);
					if (!Information.IsNothing(theRunway) && Information.IsNothing(this.method_34()))
					{
						this.method_35(theRunway);
					}
					this.method_63(mission_);
					this.method_48(false, true, false);
				}
				if (!Information.IsNothing(this.activeUnit_0.vmethod_101()))
				{
					if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Ferry)
					{
						FerryMission.FerryMissionBehavior ferryMissionBehavior = ((FerryMission)this.activeUnit_0.vmethod_101()).method_65();
						if (ferryMissionBehavior != FerryMission.FerryMissionBehavior.OneWay)
						{
							if (ferryMissionBehavior == FerryMission.FerryMissionBehavior.Random)
							{
								this.method_29(this.method_32(false));
							}
						}
						else
						{
							ActiveUnit activeUnit_ = this.activeUnit_0;
							Mission value = null;
							bool setMissionOnly = false;
							Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
							activeUnit_.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
							this.method_33(false, this.method_30());
						}
					}
					if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support && ((Class344)this.activeUnit_0.vmethod_101()).bool_23)
					{
						ActiveUnit activeUnit_2 = this.activeUnit_0;
						Mission value2 = null;
						bool setMissionOnly2 = false;
						Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
						activeUnit_2.vmethod_102(value2, setMissionOnly2, ref missionAssignmentAttemptResult);
					}
				}
				if (this.activeUnit_0.method_120() && this.activeUnit_0.vmethod_65(false).method_143() == Group.GroupType.AirGroup)
				{
					this.activeUnit_0.method_129(false, true, false);
				}
				this.activeUnit_0.vmethod_85().vmethod_9();
				this.activeUnit_0.method_126();
				if (this.activeUnit_0.vmethod_85().method_48())
				{
					Mission.Flight flight = this.activeUnit_0.vmethod_85().method_7();
					Mission mission = this.activeUnit_0.vmethod_101();
					if (!Information.IsNothing(flight))
					{
						if (!Information.IsNothing(mission))
						{
							flight.method_11(this.activeUnit_0.scenario_0, Mission.Enum102.const_6);
							this.activeUnit_0.vmethod_85().vmethod_10();
							bool flag = false;
							try
							{
								foreach (ActiveUnit activeUnit in this.activeUnit_0.scenario_0.method_42())
								{
									if (!Information.IsNothing(activeUnit) && activeUnit.vmethod_85().method_48() && activeUnit.vmethod_85().method_7() == flight)
									{
										flag = true;
										break;
									}
								}
							}
							finally
							{
								List<ActiveUnit>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							if (!flag)
							{
								if (!Information.IsNothing(mission.list_2) && mission.list_2.Count > 0)
								{
									try
									{
										foreach (Mission.EmptyAircraftSlot emptyAircraftSlot in mission.list_2)
										{
											if (emptyAircraftSlot.method_5(this.activeUnit_0.scenario_0) == flight)
											{
												emptyAircraftSlot.method_6(this.activeUnit_0.scenario_0, null);
											}
										}
									}
									finally
									{
										List<Mission.EmptyAircraftSlot>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
								}
								mission.method_59(flight);
							}
							if (mission.enum88_0 == Mission.Enum88.const_1)
							{
								ActiveUnit activeUnit_3 = this.activeUnit_0;
								Mission value3 = null;
								bool setMissionOnly3 = false;
								Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
								activeUnit_3.vmethod_102(value3, setMissionOnly3, ref missionAssignmentAttemptResult);
								if (!mission.method_54())
								{
									this.activeUnit_0.vmethod_7(false).method_39(mission);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100423", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x000F6370 File Offset: 0x000F4570
		private void method_61(float float_5)
		{
			if (this.method_30() != null)
			{
				try
				{
					string name = this.method_30().Name;
					Aircraft aircraft = (Aircraft)this.activeUnit_0;
					this.method_49(ref aircraft);
					this.activeUnit_0.vmethod_29(null, this.method_30().vmethod_28(null));
					this.activeUnit_0.vmethod_31(null, this.method_30().vmethod_30(null));
					this.activeUnit_0.vmethod_15(false, this.method_30().vmethod_14(false) + 30f);
					this.activeUnit_0.vmethod_41((float)(0.6666666666666666 * (double)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), ActiveUnit.Throttle.Loiter, false)));
					this.activeUnit_0.vmethod_10(this.method_30().vmethod_9());
					this.activeUnit_0.vmethod_87().vmethod_13(false);
					this.activeUnit_0.vmethod_87().vmethod_11(null);
					if (this.method_32(false) == null)
					{
						this.method_33(false, this.method_30());
					}
					this.method_30();
					if (this.method_20().method_167() != null && this.activeUnit_0.vmethod_101() != null)
					{
						ActiveUnit activeUnit_ = this.activeUnit_0;
						ActiveUnit_AI activeUnit_AI = this.activeUnit_0.vmethod_86();
						Aircraft aircraft2 = aircraft = this.method_20();
						bool? hintIsOperating = null;
						double value = aircraft2.vmethod_30(hintIsOperating);
						Aircraft aircraft4;
						Aircraft aircraft3 = aircraft4 = this.method_20();
						bool? hintIsOperating2 = null;
						double value2 = aircraft3.vmethod_28(hintIsOperating2);
						float float_6 = activeUnit_AI.method_86(ref value, ref value2);
						aircraft4.vmethod_29(hintIsOperating2, value2);
						aircraft.vmethod_31(hintIsOperating, value);
						activeUnit_.vmethod_73(float_6);
					}
					else
					{
						ActiveUnit activeUnit_2 = this.activeUnit_0;
						Aircraft aircraft4 = this.method_20();
						ActiveUnit.Throttle throttle_ = ActiveUnit.Throttle.Loiter;
						ActiveUnit activeUnit_3;
						ActiveUnit activeUnit_4;
						bool bool_ = (activeUnit_3 = this.activeUnit_0).vmethod_76(activeUnit_4 = this.activeUnit_0);
						float float_7 = Aircraft_AI.smethod_2(ref aircraft4, throttle_, ref bool_);
						activeUnit_3.vmethod_77(activeUnit_4, bool_);
						activeUnit_2.vmethod_73(float_7);
					}
					if (this.activeUnit_0.vmethod_101() != null)
					{
						if (this.activeUnit_0.vmethod_85().method_49())
						{
							ActiveUnit activeUnit = this.method_21();
							if (activeUnit != null)
							{
								if (Operators.CompareString(this.activeUnit_0.vmethod_85().method_7().string_7, activeUnit.string_0, false) != 0)
								{
									if (this.activeUnit_0.scenario_0.vmethod_0().ContainsKey(this.activeUnit_0.vmethod_85().method_7().string_7))
									{
										this.method_33(false, this.activeUnit_0.scenario_0.vmethod_0()[this.activeUnit_0.vmethod_85().method_7().string_7]);
									}
									else
									{
										string text = "";
										if (Operators.CompareString(this.method_20().Name, this.method_20().string_2, false) != 0)
										{
											text = " (" + this.method_20().string_2 + ")";
										}
										this.method_20().method_124(string.Concat(new string[]
										{
											"The flightpan for aircraft ",
											this.method_20().Name,
											text,
											" is set to land at a unit that no longer exists. Reverting to using ",
											name,
											" as return base."
										}), "Reseting flightplan", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_20().vmethod_28(null), this.method_20().vmethod_30(null)));
									}
								}
							}
							else if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
						else if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Ferry && ((FerryMission)this.activeUnit_0.vmethod_101()).method_65() == FerryMission.FerryMissionBehavior.Cycle)
						{
							if (this.method_21() != null)
							{
								if (this.activeUnit_0.vmethod_86().method_43() && Operators.CompareString(this.method_21().string_0, this.method_30().string_0, false) == 0)
								{
									this.activeUnit_0.vmethod_86().method_41();
								}
								else if (!this.activeUnit_0.vmethod_86().method_43() && Operators.CompareString(this.method_32(false).string_0, this.method_30().string_0, false) == 0)
								{
									this.activeUnit_0.vmethod_86().method_40();
								}
							}
							else
							{
								((Aircraft_AirOps)this.activeUnit_0.vmethod_92()).method_48(true, false, true);
								if (this.activeUnit_0.method_120())
								{
									this.activeUnit_0.vmethod_66(false, null);
								}
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
							}
						}
					}
					this.method_35(null);
					this.method_37(Aircraft_AirOps._AirOpsCondition.Airborne);
					Aircraft_AirOps.Delegate23 @delegate = Aircraft_AirOps.delegate23_0;
					if (@delegate != null)
					{
						@delegate(this.method_20());
					}
					if (this.activeUnit_0.vmethod_49()[0].vmethod_5() == PlatformComponent._ComponentStatus.Destroyed || this.activeUnit_0.vmethod_49()[0].vmethod_5() == PlatformComponent._ComponentStatus.Damaged)
					{
						this.activeUnit_0.vmethod_49()[0].vmethod_7();
					}
					if (this.activeUnit_0.vmethod_65(false) != null && !this.activeUnit_0.method_122())
					{
						if (this.method_20().enum106_0 == Mission.Flight.Enum106.const_1)
						{
							this.activeUnit_0.vmethod_65(false).method_150(this.activeUnit_0);
							try
							{
								foreach (ActiveUnit activeUnit2 in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
								{
									if (activeUnit2 != this.activeUnit_0 && activeUnit2.vmethod_85().method_47())
									{
										activeUnit2.vmethod_85().vmethod_9();
									}
								}
								goto IL_613;
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
						bool flag = true;
						try
						{
							foreach (ActiveUnit activeUnit3 in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
							{
								if (activeUnit3 != this.activeUnit_0 && activeUnit3.vmethod_127())
								{
									flag = false;
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
						if (flag)
						{
							this.activeUnit_0.vmethod_65(false).method_150(this.activeUnit_0);
						}
					}
					IL_613:
					this.method_20().vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
					this.activeUnit_0.vmethod_86().bool_3 = false;
					this.activeUnit_0.vmethod_86().vmethod_10(float_5, true, true);
					this.activeUnit_0.vmethod_86().vmethod_17((float)((short)Math.Round((double)float_5)), true, false);
					this.activeUnit_0.vmethod_86().vmethod_25();
					this.activeUnit_0.vmethod_86().vmethod_11(float_5, false, false);
					this.method_62(true);
					if (this.activeUnit_0.vmethod_65(false) != null && this.activeUnit_0.vmethod_65(false).method_143() != Group.GroupType.AirGroup && this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.OnPatrol)
					{
						this.activeUnit_0.method_129(false, true, false);
					}
					string text2 = "";
					if (Operators.CompareString(this.method_20().Name, this.method_20().string_2, false) != 0)
					{
						text2 = " (" + this.method_20().string_2 + ")";
					}
					if (this.method_20().vmethod_108() == ActiveUnit._ActiveUnitStatus.Unassigned)
					{
						this.method_20().method_124(string.Concat(new string[]
						{
							this.method_20().Name,
							text2,
							" departed ",
							name,
							" and is waiting for orders."
						}), this.method_20().Name + " airborne", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_20().vmethod_28(null), this.method_20().vmethod_30(null)));
					}
					else if (this.method_20().method_122() && Information.IsNothing(this.method_20().vmethod_101()))
					{
						this.method_20().method_124(string.Concat(new string[]
						{
							this.method_20().Name,
							text2,
							" departed ",
							name,
							" and is waiting for orders."
						}), this.method_20().Name + " airborne", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_20().vmethod_28(null), this.method_20().vmethod_30(null)));
					}
					else
					{
						this.method_20().method_124(string.Concat(new string[]
						{
							this.method_20().Name,
							text2,
							" departed ",
							name,
							"."
						}), this.method_20().Name + " airborne", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.method_20().vmethod_28(null), this.method_20().vmethod_30(null)));
					}
					this.method_20().method_160().vmethod_4(true);
					this.method_20().method_160().vmethod_5(this.method_20().method_78());
					this.method_20().method_157().nullable_2 = new DateTime?(this.method_20().scenario_0.method_31());
					if (this.method_20().method_157().method_47() && this.method_20().method_157().method_4()[0].waypointType_0 == Waypoint.WaypointType.TakeOff)
					{
						Class211 @class = this.method_20().method_157();
						bool bool_ = true;
						bool flag2 = false;
						@class.vmethod_19(float_5, ref bool_, ref flag2);
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100424", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x000F6D68 File Offset: 0x000F4F68
		public void method_62(bool bool_1)
		{
			if ((!this.activeUnit_0.vmethod_85().method_47() || !bool_1) && !Information.IsNothing(this.activeUnit_0.vmethod_101()))
			{
				if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
				{
					if (this.activeUnit_0.vmethod_86().bool_2)
					{
						this.method_64(Doctrine.Enum64.const_1, bool_1);
						return;
					}
					switch (((Strike)this.activeUnit_0.vmethod_101()).strikeType_0)
					{
					case Strike.StrikeType.Air_Intercept:
					case Strike.StrikeType.Sub_Strike:
						this.method_65();
						return;
					case Strike.StrikeType.Land_Strike:
					case Strike.StrikeType.Maritime_Strike:
						this.method_64(Doctrine.Enum64.const_0, bool_1);
						return;
					default:
						if (Debugger.IsAttached)
						{
							Debugger.Break();
							return;
						}
						break;
					}
				}
				else
				{
					if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
					{
						this.method_64(Doctrine.Enum64.const_1, bool_1);
						return;
					}
					if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support)
					{
						this.method_64(Doctrine.Enum64.const_0, bool_1);
						return;
					}
					this.method_65();
				}
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x000F6E58 File Offset: 0x000F5058
		private void method_63(Mission mission_0)
		{
			try
			{
				foreach (IEventExporter eventExporter in this.activeUnit_0.scenario_0.method_6())
				{
					if (eventExporter.imethod_8() && eventExporter.imethod_25() && !Information.IsNothing(this.activeUnit_0.vmethod_7(false)))
					{
						Dictionary<string, IEventExporter.EventNotificationParameter> dictionary = new Dictionary<string, IEventExporter.EventNotificationParameter>();
						if (this.activeUnit_0.scenario_0.MonteCarloIteration > 0)
						{
							dictionary.Add("Scenario", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.method_0(), typeof(string), 0));
							dictionary.Add("MC_Run", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.MonteCarloIteration, typeof(int), 0));
						}
						dictionary.Add("TimelineID", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.TimelineID, typeof(string), 0));
						if (eventExporter.imethod_10())
						{
							dictionary.Add("Time", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.method_31().Subtract(this.activeUnit_0.scenario_0.ZeroHour).ToString("c"), typeof(TimeSpan), 0));
						}
						else
						{
							dictionary.Add("Time", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.method_31().ToString("MM/dd/yyyy HH:mm:ss") + "." + this.activeUnit_0.scenario_0.method_31().Millisecond.ToString("D3"), typeof(DateTime), 0));
						}
						dictionary.Add("UnitID", new IEventExporter.EventNotificationParameter(this.activeUnit_0.string_0, typeof(string), 0));
						dictionary.Add("UnitName", new IEventExporter.EventNotificationParameter(this.activeUnit_0.Name, typeof(string), 0));
						dictionary.Add("UnitClass", new IEventExporter.EventNotificationParameter(this.activeUnit_0.string_2, typeof(string), 0));
						dictionary.Add("UnitSide", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_7(false).method_51(), typeof(string), 0));
						dictionary.Add("UnitLongitude", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_28(null), typeof(double), 0));
						dictionary.Add("UnitLatitude", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_30(null), typeof(double), 0));
						dictionary.Add("Action", new IEventExporter.EventNotificationParameter("Landing", typeof(string), 0));
						dictionary.Add("DepartureHostID", new IEventExporter.EventNotificationParameter(string.Empty, typeof(string), 0));
						dictionary.Add("DepartureHostName", new IEventExporter.EventNotificationParameter(string.Empty, typeof(string), 0));
						if (this.method_30() != null)
						{
							dictionary.Add("ArrivalHostID", new IEventExporter.EventNotificationParameter(this.method_30().string_0, typeof(string), 0));
							dictionary.Add("ArrivalHostName", new IEventExporter.EventNotificationParameter(this.method_30().Name, typeof(string), 0));
						}
						else if (this.method_21() != null)
						{
							dictionary.Add("ArrivalHostID", new IEventExporter.EventNotificationParameter(this.method_21().string_0, typeof(string), 0));
							dictionary.Add("ArrivalHostName", new IEventExporter.EventNotificationParameter(this.method_21().Name, typeof(string), 0));
						}
						else
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							dictionary.Add("ArrivalHostID", new IEventExporter.EventNotificationParameter(string.Empty, typeof(string), 0));
							dictionary.Add("ArrivalHostName", new IEventExporter.EventNotificationParameter(string.Empty, typeof(string), 0));
						}
						dictionary.Add("MissionID", new IEventExporter.EventNotificationParameter((mission_0 == null) ? string.Empty : mission_0.string_0, typeof(string), 0));
						dictionary.Add("MissionName", new IEventExporter.EventNotificationParameter((mission_0 == null) ? string.Empty : mission_0.Name, typeof(string), 0));
						dictionary.Add("TotalFuel", new IEventExporter.EventNotificationParameter(Conversions.ToString(this.method_20().vmethod_116()), typeof(int), 0));
						dictionary.Add("LoadoutID", new IEventExporter.EventNotificationParameter((this.method_20().method_167() == null) ? string.Empty : this.method_20().method_167().DBID.ToString(), typeof(string), 0));
						dictionary.Add("LoadoutName", new IEventExporter.EventNotificationParameter((this.method_20().method_167() == null) ? string.Empty : this.method_20().method_167().Name, typeof(string), 0));
						if (Information.IsNothing(this.method_20().method_167()))
						{
							dictionary.Add("LoadoutStores", new IEventExporter.EventNotificationParameter(this.method_30().Name, typeof(string), 0));
						}
						else
						{
							List<string> list = new List<string>();
							foreach (WeaponRec weaponRec in this.method_20().method_167().weaponRec_0)
							{
								list.Add(Conversions.ToString(weaponRec.method_9()) + "x " + Conversions.ToString(weaponRec.int_5));
							}
							dictionary.Add("LoadoutStores", new IEventExporter.EventNotificationParameter(string.Join("|", list), typeof(string), 0));
						}
						eventExporter.imethod_6(IEventExporter.ExportedEventType.AirOps, dictionary, this.activeUnit_0.scenario_0);
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

		// Token: 0x06000C79 RID: 3193 RVA: 0x000F7494 File Offset: 0x000F5694
		private void method_64(Doctrine.Enum64 enum64_0, bool bool_1)
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0.vmethod_65(false)))
				{
					Aircraft aircraft = (Aircraft)this.activeUnit_0.vmethod_65(false).method_147();
					aircraft.doctrine_0.method_84(aircraft.scenario_0, false, new bool?(false), false, false, new Doctrine.Enum64?(enum64_0));
					try
					{
						foreach (ActiveUnit activeUnit in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
						{
							if (!activeUnit.method_122())
							{
								activeUnit.doctrine_0.method_84(aircraft.scenario_0, false, new bool?(false), false, false, new Doctrine.Enum64?(enum64_0));
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
					if (bool_1)
					{
						if (aircraft.method_157().method_49())
						{
							if (this.activeUnit_0.method_122())
							{
								foreach (Waypoint waypoint_ in aircraft.method_157().method_7().method_15())
								{
									Class211 @class = aircraft.method_157();
									Waypoint[] array2 = @class.method_4();
									Class429.smethod_36(ref array2, waypoint_);
									@class.method_5(array2);
								}
							}
						}
						else if ((this.activeUnit_0.vmethod_65(false).method_143() != Group.GroupType.AirGroup || !this.activeUnit_0.vmethod_65(false).method_151()) && Enumerable.Count<Waypoint>(aircraft.method_157().method_6()) > 0)
						{
							aircraft.method_157().method_5(aircraft.method_157().method_6());
						}
					}
					if (aircraft.method_157().method_48())
					{
						aircraft.method_157().method_7().method_11(this.activeUnit_0.scenario_0, Mission.Enum102.const_5);
					}
				}
				else
				{
					this.method_20().doctrine_0.method_84(this.method_20().scenario_0, false, new bool?(false), false, false, new Doctrine.Enum64?(enum64_0));
					if (this.method_20().method_157().method_49())
					{
						if (bool_1)
						{
							foreach (Waypoint waypoint_2 in this.method_20().method_157().method_7().method_15())
							{
								Class211 class2 = this.method_20().method_157();
								Waypoint[] waypoint_3 = class2.method_4();
								Class429.smethod_36(ref waypoint_3, waypoint_2);
								class2.method_5(waypoint_3);
							}
						}
						else if (Enumerable.Count<Waypoint>(this.method_20().method_157().method_6()) > 0)
						{
							this.method_20().method_157().method_5(this.method_20().method_157().method_6());
						}
					}
					if (this.method_20().method_157().method_48())
					{
						this.method_20().method_157().method_7().method_11(this.activeUnit_0.scenario_0, Mission.Enum102.const_5);
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

		// Token: 0x06000C7A RID: 3194 RVA: 0x000F77B0 File Offset: 0x000F59B0
		private void method_65()
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0.vmethod_65(false)))
				{
					Aircraft aircraft = (Aircraft)this.activeUnit_0.vmethod_65(false).method_147();
					if (aircraft.method_157().method_48())
					{
						aircraft.method_157().method_7().method_11(this.activeUnit_0.scenario_0, Mission.Enum102.const_5);
					}
				}
				else if (this.method_20().method_157().method_48())
				{
					this.method_20().method_157().method_7().method_11(this.activeUnit_0.scenario_0, Mission.Enum102.const_5);
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

		// Token: 0x06000C7B RID: 3195 RVA: 0x000F7890 File Offset: 0x000F5A90
		private void method_66(AirFacility airFacility_1, bool bool_1, bool bool_2)
		{
			try
			{
				this.method_35(airFacility_1);
				if (bool_1)
				{
					Aircraft aircraft;
					if (!Information.IsNothing(this.method_20().method_167()))
					{
						ActiveUnit_AirOps activeUnit_AirOps = this.method_30().vmethod_92();
						aircraft = this.method_20();
						activeUnit_AirOps.method_16(ref aircraft, this.method_20().method_167().DBID, this.method_20().method_167().DBID, false, this.method_20().method_167().bool_11, !this.activeUnit_0.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2), false, true);
					}
					else
					{
						this.method_37(Aircraft_AirOps._AirOpsCondition.Readying);
						this.method_39(1800f);
					}
					ActiveUnit_AirOps activeUnit_AirOps2 = this.method_30().vmethod_92();
					aircraft = this.method_20();
					activeUnit_AirOps2.method_14(ref aircraft);
					ActiveUnit_AirOps activeUnit_AirOps3 = this.method_30().vmethod_92();
					aircraft = this.method_20();
					activeUnit_AirOps3.method_13(ref aircraft);
				}
				else if (bool_2)
				{
					this.method_37(Aircraft_AirOps._AirOpsCondition.Parked);
					this.method_39(0f);
					if (!Information.IsNothing(this.activeUnit_0.vmethod_65(false)))
					{
						this.activeUnit_0.vmethod_66(false, null);
					}
				}
				if (Enumerable.Count<Cargo>(this.activeUnit_0.cargo_0) > 0)
				{
					ActiveUnit activeUnit = null;
					List<ActiveUnit> list = new List<ActiveUnit>();
					if (this.method_30() is Group)
					{
						try
						{
							foreach (ActiveUnit activeUnit2 in ((Group)this.method_30()).vmethod_141().Values)
							{
								if (Enumerable.Count<Cargo>(activeUnit2.cargo_0) > 0)
								{
									list.Add(activeUnit2);
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
						if (list.Count == 1)
						{
							activeUnit = list[0];
						}
						else if (list.Count > 1)
						{
							Random random = new Random();
							activeUnit = list[random.Next(list.Count)];
						}
						else
						{
							try
							{
								foreach (ActiveUnit activeUnit3 in ((Group)this.method_30()).vmethod_141().Values)
								{
									Facility._FacilityCategory facilityCategory_ = ((Facility)activeUnit3)._FacilityCategory_0;
									if ((facilityCategory_ == Facility._FacilityCategory.Building_Surface || facilityCategory_ == Facility._FacilityCategory.Building_Underground) && ((Facility)activeUnit3).double_4 > 400.0)
									{
										list.Add(activeUnit3);
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
							if (list.Count == 1)
							{
								activeUnit = list[0];
							}
							else if (list.Count > 1)
							{
								Random random2 = new Random();
								activeUnit = list[random2.Next(list.Count)];
							}
						}
					}
					else
					{
						activeUnit = this.method_30();
					}
					if (!Information.IsNothing(activeUnit))
					{
						ActiveUnit_DockingOps.smethod_13(this.activeUnit_0, activeUnit, Enumerable.ToList<Cargo>(this.activeUnit_0.cargo_0));
					}
					this.method_41();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100425", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x000F7BCC File Offset: 0x000F5DCC
		public void method_67()
		{
			try
			{
				foreach (WeaponRec weaponRec in this.method_20().method_167().weaponRec_0)
				{
					if (!Weapon.smethod_17(weaponRec.int_5, ref this.activeUnit_0.scenario_0) && weaponRec.method_9() > 0)
					{
						int num = weaponRec.method_9();
						for (int j = 1; j <= num; j++)
						{
							this.method_30().vmethod_89().vmethod_11(weaponRec.int_5, true, true);
						}
					}
				}
				this.method_20().method_167().weaponRec_0 = new WeaponRec[0];
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100426", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x000F7CAC File Offset: 0x000F5EAC
		public bool method_68()
		{
			return !Information.IsNothing(this.method_34()) && this.method_34().method_34();
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x000F7CD8 File Offset: 0x000F5ED8
		public override bool vmethod_7(bool bool_1, ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_0, bool bool_2, ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_1, bool bool_3, bool bool_4)
		{
			bool result;
			try
			{
				if (this.method_36() == Aircraft_AirOps._AirOpsCondition.RTB && this.activeUnit_0.method_85() && !bool_1 && !Information.IsNothing(this.method_21()))
				{
					result = true;
				}
				else if (this.activeUnit_0.bool_3 && this.activeUnit_0.vmethod_85().method_32())
				{
					this.activeUnit_0.vmethod_85().vmethod_12(1f, true);
					this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
					result = true;
				}
				else if (!Information.IsNothing(this.method_21()))
				{
					if (bool_3)
					{
						this.activeUnit_0.method_129(false, bool_4, false);
					}
					if (!this.activeUnit_0.method_85())
					{
						this.activeUnit_0.vmethod_109(_ActiveUnitStatus_0);
					}
					this.method_37(Aircraft_AirOps._AirOpsCondition.RTB);
					this.activeUnit_0.vmethod_87().vmethod_11(null);
					this.activeUnit_0.vmethod_87().vmethod_13(false);
					if (bool_2 && !Information.IsNothing(this.activeUnit_0.vmethod_65(false)))
					{
						try
						{
							foreach (ActiveUnit activeUnit in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
							{
								if (activeUnit != this.activeUnit_0)
								{
									if (bool_3)
									{
										this.activeUnit_0.method_129(false, bool_4, false);
									}
									if (!activeUnit.method_85())
									{
										activeUnit.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB);
									}
									this.method_37(Aircraft_AirOps._AirOpsCondition.RTB);
									activeUnit.vmethod_87().vmethod_11(null);
									activeUnit.vmethod_87().vmethod_13(false);
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
					this.activeUnit_0.vmethod_81(Waypoint.Enum81.const_2);
					result = true;
				}
				else
				{
					this.method_28();
					if (!Information.IsNothing(this.method_32(false)))
					{
						if (bool_3)
						{
							this.activeUnit_0.method_129(false, bool_4, false);
						}
						if (!this.activeUnit_0.method_85())
						{
							this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB);
						}
						this.method_37(Aircraft_AirOps._AirOpsCondition.RTB);
						this.activeUnit_0.vmethod_87().vmethod_11(null);
						this.activeUnit_0.vmethod_87().vmethod_13(false);
						if (bool_2 && !Information.IsNothing(this.activeUnit_0.vmethod_65(false)))
						{
							try
							{
								foreach (ActiveUnit activeUnit2 in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
								{
									if (activeUnit2 != this.activeUnit_0)
									{
										if (bool_3)
										{
											this.activeUnit_0.method_129(false, bool_4, false);
										}
										if (!activeUnit2.method_85())
										{
											activeUnit2.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB);
										}
										this.method_37(Aircraft_AirOps._AirOpsCondition.RTB);
										activeUnit2.vmethod_87().vmethod_11(null);
										activeUnit2.vmethod_87().vmethod_13(false);
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
						this.activeUnit_0.vmethod_81(Waypoint.Enum81.const_2);
						result = true;
					}
					else
					{
						string str = "";
						if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
						{
							str = " (" + this.activeUnit_0.string_2 + ")";
						}
						if (bool_1)
						{
							this.activeUnit_0.scenario_0.method_59(this.activeUnit_0.Name + str + " has no suitable place to land!", "Landing issue", LoggedMessage.MessageType.AirOps, 15, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						}
						this.activeUnit_0.vmethod_81(Waypoint.Enum81.const_2);
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100427", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				this.activeUnit_0.vmethod_81(Waypoint.Enum81.const_2);
				result = false;
			}
			return result;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x000F811C File Offset: 0x000F631C
		public bool method_69()
		{
			ActiveUnit activeUnit = this.method_30();
			bool result;
			if (Information.IsNothing(activeUnit))
			{
				result = false;
			}
			else
			{
				try
				{
					if (Information.IsNothing(this.method_20().vmethod_101()))
					{
						result = false;
					}
					else if (this.method_20().vmethod_101()._MissionClass_0 != Mission._MissionClass.Strike)
					{
						result = false;
					}
					else if (this.method_20().method_158().bool_2)
					{
						result = false;
					}
					else if (!Information.IsNothing(this.method_34()) && (this.method_34().method_28() == AirFacility.Enum110.const_4 || this.method_34().method_28() == AirFacility.Enum110.const_5 || this.method_34().method_28() == AirFacility.Enum110.const_6))
					{
						result = false;
					}
					else
					{
						List<Aircraft> list = new List<Aircraft>();
						try
						{
							foreach (Aircraft aircraft in activeUnit.vmethod_92().vmethod_4())
							{
								if (aircraft != this.activeUnit_0 && aircraft.method_158().bool_2 && !Information.IsNothing(aircraft.vmethod_101()) && aircraft.vmethod_101() == this.activeUnit_0.vmethod_101())
								{
									Aircraft aircraft2 = aircraft;
									string text = null;
									if (aircraft2.method_147(ref text) == Aircraft_AirOps.Enum44.const_0 && !aircraft.vmethod_123() && !aircraft.vmethod_124() && aircraft.method_164().method_36() != Aircraft_AirOps._AirOpsCondition.Readying)
									{
										list.Add(aircraft);
									}
								}
							}
						}
						finally
						{
							List<Aircraft>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (list.Count == 0)
						{
							result = false;
						}
						else
						{
							this.method_39(30f);
							result = true;
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200445", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
			return result;
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x000F8310 File Offset: 0x000F6510
		public void method_70()
		{
			if (!Information.IsNothing(this.method_20()) && this.method_38() <= 0f && !Information.IsNothing(this.method_34()))
			{
				if (Information.IsNothing(this.method_34().method_18()) && !Information.IsNothing(this.method_30()))
				{
					this.method_30().method_103(this.method_34());
					this.method_34().method_19(this.method_30());
				}
				try
				{
					AirFacility.Enum110 @enum = this.method_34().method_28();
					switch (@enum)
					{
					case AirFacility.Enum110.const_1:
					case AirFacility.Enum110.const_2:
					case AirFacility.Enum110.const_6:
						goto IL_623;
					case AirFacility.Enum110.const_3:
						goto IL_BE3;
					case AirFacility.Enum110.const_4:
						break;
					case AirFacility.Enum110.const_5:
						this.method_74(this.method_34());
						return;
					case AirFacility.Enum110.const_7:
						goto IL_645;
					default:
						if (@enum - AirFacility.Enum110.const_8 <= 1)
						{
							goto IL_623;
						}
						switch (@enum)
						{
						case AirFacility.Enum110.const_10:
						{
							if (this.method_34().method_18().bool_6)
							{
								Ship.Enum118 enum118_ = ((Ship)this.method_34().method_18()).enum118_0;
								if (enum118_ != Ship.Enum118.const_2 && enum118_ != Ship.Enum118.const_7 && enum118_ != Ship.Enum118.const_8)
								{
									for (int i = this.method_30().vmethod_99().Length - 1; i >= 0; i += -1)
									{
										AirFacility airFacility = this.method_30().vmethod_99()[i];
										if (airFacility.method_31() && this.method_71(airFacility) && airFacility.method_38(this.method_20()))
										{
											this.method_74(airFacility);
											return;
										}
									}
								}
							}
							if (!Information.IsNothing(this.method_30().vmethod_92().method_4()) && !Information.IsNothing(this.method_30().vmethod_92().vmethod_5()))
							{
								List<AirFacility> list = Enumerable.ToList<AirFacility>(Enumerable.Where<AirFacility>(this.method_30().vmethod_99(), (Aircraft_AirOps._Closure$__.$I118-11 == null) ? (Aircraft_AirOps._Closure$__.$I118-11 = new Func<AirFacility, bool>(Aircraft_AirOps._Closure$__.$I.method_22)) : Aircraft_AirOps._Closure$__.$I118-11));
								List<AirFacility> list2 = Enumerable.ToList<AirFacility>(Enumerable.Where<AirFacility>(list, (Aircraft_AirOps._Closure$__.$I118-12 == null) ? (Aircraft_AirOps._Closure$__.$I118-12 = new Func<AirFacility, bool>(Aircraft_AirOps._Closure$__.$I.method_23)) : Aircraft_AirOps._Closure$__.$I118-12));
								if (Enumerable.Count<Aircraft>(this.method_30().vmethod_92().method_4()) <= 0 && Enumerable.Count<Aircraft>(this.method_30().vmethod_92().vmethod_5()) <= 0)
								{
									if (!Information.IsNothing(this.method_30().vmethod_92().method_10()) && list.Count - list2.Count <= 2)
									{
										this.method_37(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit);
										this.method_39(35f);
										return;
									}
								}
								else if (list.Count - list2.Count <= 2)
								{
									this.method_37(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit);
									this.method_39(35f);
									return;
								}
							}
							IEnumerable<AirFacility> enumerable = Enumerable.OrderBy<AirFacility, GlobalVariables.AircraftSizeClass>(base.method_1(this.method_30()), (Aircraft_AirOps._Closure$__.$I118-13 == null) ? (Aircraft_AirOps._Closure$__.$I118-13 = new Func<AirFacility, GlobalVariables.AircraftSizeClass>(Aircraft_AirOps._Closure$__.$I.method_24)) : Aircraft_AirOps._Closure$__.$I118-13);
							if (!Information.IsNothing(enumerable) && Enumerable.Count<AirFacility>(enumerable) > 0)
							{
								IEnumerable<AirFacility> enumerable2 = base.method_0(new bool?(true), this.method_20(), this.method_30(), enumerable);
								if (!Information.IsNothing(enumerable2) && Enumerable.Count<AirFacility>(enumerable2) > 0)
								{
									this.method_75(Enumerable.ElementAtOrDefault<AirFacility>(enumerable2, 0), Aircraft_AirOps.Enum42.const_0);
									return;
								}
							}
							this.method_37(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit);
							this.method_39(35f);
							goto IL_BE3;
						}
						case AirFacility.Enum110.const_11:
							goto IL_645;
						case AirFacility.Enum110.const_12:
							break;
						default:
							goto IL_BE3;
						}
						break;
					}
					if (!Information.IsNothing(this.method_30().vmethod_92().method_4()) && !Information.IsNothing(this.method_30().vmethod_92().vmethod_5()))
					{
						List<AirFacility> list3 = Enumerable.ToList<AirFacility>(Enumerable.Where<AirFacility>(this.method_30().vmethod_99(), (Aircraft_AirOps._Closure$__.$I118-0 == null) ? (Aircraft_AirOps._Closure$__.$I118-0 = new Func<AirFacility, bool>(Aircraft_AirOps._Closure$__.$I.method_11)) : Aircraft_AirOps._Closure$__.$I118-0));
						List<AirFacility> list4 = Enumerable.ToList<AirFacility>(Enumerable.Where<AirFacility>(list3, (Aircraft_AirOps._Closure$__.$I118-1 == null) ? (Aircraft_AirOps._Closure$__.$I118-1 = new Func<AirFacility, bool>(Aircraft_AirOps._Closure$__.$I.method_12)) : Aircraft_AirOps._Closure$__.$I118-1));
						if ((Enumerable.Count<Aircraft>(this.method_30().vmethod_92().method_4()) > 0 || Enumerable.Count<Aircraft>(this.method_30().vmethod_92().vmethod_5()) > 0) && list3.Count - list4.Count <= 2)
						{
							for (int j = this.method_30().vmethod_99().Length - 1; j >= 0; j += -1)
							{
								AirFacility airFacility2 = this.method_30().vmethod_99()[j];
								if (airFacility2.method_28() == AirFacility.Enum110.const_11 && airFacility2.method_38(this.method_20()))
								{
									this.method_66(airFacility2, false, false);
									this.method_37(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway);
									this.method_39(35f);
									return;
								}
							}
						}
						if (!Information.IsNothing(this.method_30().vmethod_92().method_10()) && list3.Count - list4.Count <= 2)
						{
							for (int k = this.method_30().vmethod_99().Length - 1; k >= 0; k += -1)
							{
								AirFacility airFacility3 = this.method_30().vmethod_99()[k];
								if (airFacility3.method_28() == AirFacility.Enum110.const_11 && airFacility3.method_38(this.method_20()))
								{
									this.method_66(airFacility3, false, false);
									this.method_37(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway);
									this.method_39(35f);
									return;
								}
							}
						}
					}
					IEnumerable<AirFacility> enumerable3 = Enumerable.ThenBy<AirFacility, GlobalVariables.AircraftSizeClass>(Enumerable.OrderBy<AirFacility, GlobalVariables.AircraftSizeClass>(Aircraft_AirOps.smethod_9(this.method_20(), true, false, this.method_30(), this.method_20().method_154()), (Aircraft_AirOps._Closure$__.$I118-2 == null) ? (Aircraft_AirOps._Closure$__.$I118-2 = new Func<AirFacility, GlobalVariables.AircraftSizeClass>(Aircraft_AirOps._Closure$__.$I.method_13)) : Aircraft_AirOps._Closure$__.$I118-2), (Aircraft_AirOps._Closure$__.$I118-3 == null) ? (Aircraft_AirOps._Closure$__.$I118-3 = new Func<AirFacility, GlobalVariables.AircraftSizeClass>(Aircraft_AirOps._Closure$__.$I.method_14)) : Aircraft_AirOps._Closure$__.$I118-3);
					if (Information.IsNothing(enumerable3) || Enumerable.Count<AirFacility>(enumerable3) <= 0)
					{
						goto IL_BE3;
					}
					IEnumerable<AirFacility> enumerable4 = base.method_2(true, false, this.method_20(), this.method_30(), this.method_20().method_154(), enumerable3);
					if (!Information.IsNothing(enumerable4) && Enumerable.Count<AirFacility>(enumerable4) > 0)
					{
						this.method_74(Enumerable.ElementAtOrDefault<AirFacility>(enumerable4, 0));
						return;
					}
					goto IL_BE3;
					IL_623:
					if (this.method_71(this.method_34()))
					{
						this.method_74(this.method_34());
						return;
					}
					goto IL_BE3;
					IL_645:
					if (this.method_34().method_18().bool_6)
					{
						Ship.Enum118 enum118_2 = ((Ship)this.method_34().method_18()).enum118_0;
						if (enum118_2 != Ship.Enum118.const_2 && enum118_2 != Ship.Enum118.const_7 && enum118_2 != Ship.Enum118.const_8)
						{
							for (int l = this.method_30().vmethod_99().Length - 1; l >= 0; l += -1)
							{
								AirFacility airFacility4 = this.method_30().vmethod_99()[l];
								if (this.method_71(airFacility4) && airFacility4.method_38(this.method_20()))
								{
									this.method_74(airFacility4);
									return;
								}
							}
						}
						else
						{
							if (!Information.IsNothing(this.method_30().vmethod_92().method_4()) && !Information.IsNothing(this.method_30().vmethod_92().vmethod_5()))
							{
								if (enum118_2 != Ship.Enum118.const_8)
								{
									List<AirFacility> list5 = Enumerable.ToList<AirFacility>(Enumerable.Where<AirFacility>(this.method_30().vmethod_99(), (Aircraft_AirOps._Closure$__.$I118-4 == null) ? (Aircraft_AirOps._Closure$__.$I118-4 = new Func<AirFacility, bool>(Aircraft_AirOps._Closure$__.$I.method_15)) : Aircraft_AirOps._Closure$__.$I118-4));
									List<AirFacility> list6 = Enumerable.ToList<AirFacility>(Enumerable.Where<AirFacility>(list5, (Aircraft_AirOps._Closure$__.$I118-5 == null) ? (Aircraft_AirOps._Closure$__.$I118-5 = new Func<AirFacility, bool>(Aircraft_AirOps._Closure$__.$I.method_16)) : Aircraft_AirOps._Closure$__.$I118-5));
									if (list5.Count > 0)
									{
										int count = list5.Count;
										int num;
										if (count <= 0)
										{
											num = 0;
										}
										else if (count == 1)
										{
											num = 1;
										}
										else if (count == 2)
										{
											num = 1;
										}
										else if (count == 3)
										{
											num = 2;
										}
										else if (count >= 4)
										{
											num = 2;
										}
										if (list5.Count - list6.Count <= num)
										{
											if (Enumerable.Count<Aircraft>(this.method_30().vmethod_92().method_4()) > 0 || Enumerable.Count<Aircraft>(this.method_30().vmethod_92().vmethod_5()) > 0)
											{
												this.method_37(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway);
												this.method_39(35f);
												return;
											}
											if (!Information.IsNothing(this.method_30().vmethod_92().method_10()))
											{
												this.method_37(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway);
												this.method_39(35f);
												return;
											}
										}
									}
								}
								else
								{
									List<AirFacility> list7 = Enumerable.ToList<AirFacility>(Enumerable.Where<AirFacility>(this.method_30().vmethod_99(), (Aircraft_AirOps._Closure$__.$I118-6 == null) ? (Aircraft_AirOps._Closure$__.$I118-6 = new Func<AirFacility, bool>(Aircraft_AirOps._Closure$__.$I.method_17)) : Aircraft_AirOps._Closure$__.$I118-6));
									List<AirFacility> list8 = Enumerable.ToList<AirFacility>(Enumerable.Where<AirFacility>(list7, (Aircraft_AirOps._Closure$__.$I118-7 == null) ? (Aircraft_AirOps._Closure$__.$I118-7 = new Func<AirFacility, bool>(Aircraft_AirOps._Closure$__.$I.method_18)) : Aircraft_AirOps._Closure$__.$I118-7));
									if (list7.Count > 0)
									{
										int count2 = list7.Count;
										int num2;
										if (count2 <= 0)
										{
											num2 = 0;
										}
										else if (count2 == 1)
										{
											num2 = 1;
										}
										else if (count2 == 2)
										{
											num2 = 1;
										}
										else if (count2 == 3)
										{
											num2 = 2;
										}
										else if (count2 >= 4)
										{
											num2 = 2;
										}
										if (list7.Count - list8.Count <= num2)
										{
											if (Enumerable.Count<Aircraft>(this.method_30().vmethod_92().method_4()) > 0 || Enumerable.Count<Aircraft>(this.method_30().vmethod_92().vmethod_5()) > 0)
											{
												this.method_37(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway);
												this.method_39(35f);
												return;
											}
											if (!Information.IsNothing(this.method_30().vmethod_92().method_10()))
											{
												this.method_37(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway);
												this.method_39(35f);
												return;
											}
										}
									}
								}
							}
							for (int m = this.method_30().vmethod_99().Length - 1; m >= 0; m += -1)
							{
								AirFacility airFacility5 = this.method_30().vmethod_99()[m];
								if (this.method_71(airFacility5) && airFacility5.method_38(this.method_20()))
								{
									this.method_74(airFacility5);
									return;
								}
							}
						}
						this.method_37(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway);
						this.method_39(5f);
					}
					else
					{
						if (!Information.IsNothing(this.method_30().vmethod_92().method_4()) && !Information.IsNothing(this.method_30().vmethod_92().vmethod_5()))
						{
							if (Enumerable.Count<Aircraft>(this.method_30().vmethod_92().method_4()) > 0 || Enumerable.Count<Aircraft>(this.method_30().vmethod_92().vmethod_5()) > 0)
							{
								this.method_37(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit);
								this.method_39(35f);
								return;
							}
							if (!Information.IsNothing(this.method_30().vmethod_92().method_10()))
							{
								List<AirFacility> list9 = Enumerable.ToList<AirFacility>(Enumerable.Where<AirFacility>(this.method_30().vmethod_99(), (Aircraft_AirOps._Closure$__.$I118-8 == null) ? (Aircraft_AirOps._Closure$__.$I118-8 = new Func<AirFacility, bool>(Aircraft_AirOps._Closure$__.$I.method_19)) : Aircraft_AirOps._Closure$__.$I118-8));
								List<AirFacility> list10 = Enumerable.ToList<AirFacility>(Enumerable.Where<AirFacility>(list9, (Aircraft_AirOps._Closure$__.$I118-9 == null) ? (Aircraft_AirOps._Closure$__.$I118-9 = new Func<AirFacility, bool>(Aircraft_AirOps._Closure$__.$I.method_20)) : Aircraft_AirOps._Closure$__.$I118-9));
								if (list9.Count - list10.Count <= 2)
								{
									this.method_37(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit);
									this.method_39(35f);
									return;
								}
							}
						}
						IEnumerable<AirFacility> enumerable5 = Enumerable.OrderBy<AirFacility, GlobalVariables.AircraftSizeClass>(base.method_1(this.method_20().method_164().method_30()), (Aircraft_AirOps._Closure$__.$I118-10 == null) ? (Aircraft_AirOps._Closure$__.$I118-10 = new Func<AirFacility, GlobalVariables.AircraftSizeClass>(Aircraft_AirOps._Closure$__.$I.method_21)) : Aircraft_AirOps._Closure$__.$I118-10);
						if (!Information.IsNothing(enumerable5) && Enumerable.Count<AirFacility>(enumerable5) > 0)
						{
							IEnumerable<AirFacility> enumerable6 = base.method_0(new bool?(true), this.method_20(), this.method_30(), enumerable5);
							if (!Information.IsNothing(enumerable6) && Enumerable.Count<AirFacility>(enumerable6) > 0)
							{
								this.method_75(Enumerable.ElementAtOrDefault<AirFacility>(enumerable6, 0), Aircraft_AirOps.Enum42.const_0);
								return;
							}
						}
						this.method_37(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit);
						this.method_39(35f);
					}
					IL_BE3:;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100428", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x000F8F58 File Offset: 0x000F7158
		public static List<AirFacility> smethod_9(Aircraft aircraft_3, bool bool_1, bool bool_2, ActiveUnit activeUnit_3, bool bool_3)
		{
			List<AirFacility> result;
			try
			{
				List<AirFacility> list = new List<AirFacility>();
				List<AirFacility> list2 = new List<AirFacility>();
				AirFacility[] array = activeUnit_3.vmethod_99();
				for (int i = array.Length - 1; i >= 0; i += -1)
				{
					AirFacility airFacility = array[i];
					AirFacility.Enum110 @enum = airFacility.method_28();
					switch (@enum)
					{
					case AirFacility.Enum110.const_1:
					case AirFacility.Enum110.const_2:
					case AirFacility.Enum110.const_5:
					case AirFacility.Enum110.const_6:
					case AirFacility.Enum110.const_7:
						if (bool_1 && !bool_3 && aircraft_3.method_164().method_71(airFacility))
						{
							list.Add(airFacility);
						}
						else if (!bool_1 && !bool_3 && aircraft_3.method_164().method_72(airFacility, bool_2))
						{
							list.Add(airFacility);
						}
						else if (bool_1 && bool_3 && aircraft_3.method_164().method_71(airFacility))
						{
							list2.Add(airFacility);
						}
						else if (!bool_1 && bool_3 && aircraft_3.method_164().method_72(airFacility, bool_2))
						{
							list2.Add(airFacility);
						}
						break;
					case AirFacility.Enum110.const_3:
						if (bool_1 && aircraft_3.method_164().method_71(airFacility))
						{
							list2.Add(airFacility);
						}
						else if (!bool_1 && aircraft_3.method_164().method_72(airFacility, bool_2))
						{
							list2.Add(airFacility);
						}
						break;
					case AirFacility.Enum110.const_4:
						break;
					default:
						if (@enum - AirFacility.Enum110.const_8 <= 1)
						{
							if (bool_1 && bool_3 && aircraft_3.method_164().method_71(airFacility))
							{
								list.Add(airFacility);
							}
							else if (!bool_1 && bool_3 && aircraft_3.method_164().method_72(airFacility, bool_2))
							{
								list.Add(airFacility);
							}
						}
						break;
					}
				}
				if (list2.Count > 0 && list.Count == 0)
				{
					result = list2;
				}
				else
				{
					result = list;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200355", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<AirFacility>();
			}
			return result;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x000F9164 File Offset: 0x000F7364
		public bool method_71(AirFacility airFacility_1)
		{
			bool result;
			try
			{
				AirFacility.Enum110 @enum = airFacility_1.method_28();
				bool flag;
				bool flag2;
				switch (@enum)
				{
				case AirFacility.Enum110.const_1:
				case AirFacility.Enum110.const_3:
					break;
				case AirFacility.Enum110.const_2:
				case AirFacility.Enum110.const_4:
					goto IL_E2;
				case AirFacility.Enum110.const_5:
				case AirFacility.Enum110.const_6:
					if (this.activeUnit_0.scenario_0.FeatureCompatibility.get_CarrierCapableFlag(this.activeUnit_0.scenario_0.method_39()) && this.method_20().enum40_0 != Aircraft.Enum40.const_2 && this.method_20().enum40_0 != Aircraft.Enum40.const_3 && this.method_20().enum40_0 != Aircraft.Enum40.const_4)
					{
						return false;
					}
					flag = true;
					flag2 = (this.method_20().aircraftSizeClass_0 <= airFacility_1.method_27());
					goto IL_E2;
				default:
					if (@enum - AirFacility.Enum110.const_8 > 1)
					{
						goto IL_E2;
					}
					break;
				}
				flag = (this.method_20().enum146_0 <= airFacility_1.enum146_0);
				flag2 = (this.method_20().aircraftSizeClass_0 <= airFacility_1.method_27());
				IL_E2:
				result = (flag && flag2);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100429", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x000F92A8 File Offset: 0x000F74A8
		public bool method_72(AirFacility airFacility_1, bool bool_1)
		{
			bool result;
			try
			{
				AirFacility.Enum110 @enum = airFacility_1.method_28();
				switch (@enum)
				{
				case AirFacility.Enum110.const_2:
					if (this.method_20().aircraftSizeClass_0 > airFacility_1.method_27())
					{
						return false;
					}
					goto IL_108;
				case AirFacility.Enum110.const_3:
				case AirFacility.Enum110.const_4:
					break;
				case AirFacility.Enum110.const_5:
				case AirFacility.Enum110.const_6:
					goto IL_89;
				case AirFacility.Enum110.const_7:
					if (this.activeUnit_0.scenario_0.FeatureCompatibility.get_CarrierCapableFlag(this.activeUnit_0.scenario_0.method_39()) && this.method_20().enum40_0 != Aircraft.Enum40.const_2 && this.method_20().enum40_0 != Aircraft.Enum40.const_3 && this.method_20().enum40_0 != Aircraft.Enum40.const_4)
					{
						return false;
					}
					if (this.method_20().aircraftSizeClass_0 > airFacility_1.method_27())
					{
						return false;
					}
					goto IL_108;
				default:
					if (@enum == AirFacility.Enum110.const_10)
					{
						goto IL_89;
					}
					break;
				}
				if (this.method_20().enum146_0 > airFacility_1.enum146_0)
				{
					return false;
				}
				if (this.method_20().aircraftSizeClass_0 > airFacility_1.method_27())
				{
					return false;
				}
				goto IL_108;
				IL_89:
				return false;
				IL_108:
				if (bool_1)
				{
					result = true;
				}
				else
				{
					result = airFacility_1.method_38(this.method_20());
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100430", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x000F9428 File Offset: 0x000F7628
		private bool method_73(ActiveUnit activeUnit_3, bool bool_1)
		{
			bool result;
			try
			{
				if (Information.IsNothing(activeUnit_3.vmethod_99()))
				{
					result = false;
				}
				else
				{
					foreach (AirFacility airFacility_ in activeUnit_3.vmethod_99())
					{
						if (this.method_72(airFacility_, bool_1))
						{
							return true;
						}
					}
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100431", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x000F94BC File Offset: 0x000F76BC
		private void method_74(AirFacility airFacility_1)
		{
			this.method_35(airFacility_1);
			this.method_37(Aircraft_AirOps._AirOpsCondition.TakingOff);
			if (this.method_34().method_28() == AirFacility.Enum110.const_5)
			{
				if (!this.method_20().method_157().method_49() || Information.IsNothing(this.method_20().method_157().method_7().method_15()[0].nullable_7))
				{
					this.method_39(80f);
					return;
				}
				double totalSeconds = (this.method_20().method_157().method_7().method_15()[0].nullable_7.Value - this.method_20().scenario_0.method_31()).TotalSeconds;
				if (totalSeconds > 0.0 && totalSeconds <= 180.0)
				{
					this.method_39((float)totalSeconds);
					return;
				}
				this.method_39(80f);
				return;
			}
			else
			{
				switch (this.method_20().vmethod_121())
				{
				case GlobalVariables.TargetVisualSizeClass.Stealthy:
					this.method_39(30f);
					return;
				case GlobalVariables.TargetVisualSizeClass.VSmall:
					this.method_39(30f);
					return;
				case GlobalVariables.TargetVisualSizeClass.Small:
					this.method_39(30f);
					return;
				case GlobalVariables.TargetVisualSizeClass.Medium:
					this.method_39(30f);
					return;
				case GlobalVariables.TargetVisualSizeClass.Large:
					this.method_39(30f);
					return;
				case GlobalVariables.TargetVisualSizeClass.VLarge:
					this.method_39(30f);
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x000F9614 File Offset: 0x000F7814
		private void method_75(AirFacility airFacility_1, Aircraft_AirOps.Enum42 enum42_0)
		{
			this.method_35(airFacility_1);
			switch (enum42_0)
			{
			case Aircraft_AirOps.Enum42.const_0:
				this.method_37(Aircraft_AirOps._AirOpsCondition.TaxyingToTakeOff);
				break;
			case Aircraft_AirOps.Enum42.const_1:
				this.method_37(Aircraft_AirOps._AirOpsCondition.TaxyingToPark);
				break;
			case Aircraft_AirOps.Enum42.const_2:
				this.method_37(Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck);
				break;
			}
			if (this.method_20().method_157().method_49() && !Information.IsNothing(this.method_20().method_157().method_7().method_15()[0].nullable_7))
			{
				double num = (this.method_20().method_157().method_7().method_15()[0].nullable_7.Value - this.method_20().scenario_0.method_31()).TotalSeconds - 30.0;
				if (num > 0.0 && num <= 180.0)
				{
					this.method_39((float)num);
					return;
				}
			}
			switch (this.method_20().vmethod_121())
			{
			case GlobalVariables.TargetVisualSizeClass.Stealthy:
				this.method_39(120f);
				return;
			case GlobalVariables.TargetVisualSizeClass.VSmall:
				this.method_39(120f);
				return;
			case GlobalVariables.TargetVisualSizeClass.Small:
				this.method_39(120f);
				return;
			case GlobalVariables.TargetVisualSizeClass.Medium:
				this.method_39(120f);
				return;
			case GlobalVariables.TargetVisualSizeClass.Large:
				this.method_39(120f);
				return;
			case GlobalVariables.TargetVisualSizeClass.VLarge:
				this.method_39(120f);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x000F9774 File Offset: 0x000F7974
		public bool method_76()
		{
			bool result;
			try
			{
				this.activeUnit_0.vmethod_87().vmethod_11(null);
				this.activeUnit_0.vmethod_71(0f);
				this.activeUnit_0.vmethod_73((float)Math.Max(0, (int)Terrain.smethod_7(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), false)));
				this.method_37(Aircraft_AirOps._AirOpsCondition.TransferringCargo);
				this.method_39(240f);
				if (this.activeUnit_0.vmethod_14(false) > this.activeUnit_0.vmethod_72())
				{
					this.method_39(240f);
				}
				result = true;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 10342058231234129034582930467587", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000F9870 File Offset: 0x000F7A70
		public bool method_77()
		{
			bool result;
			try
			{
				if (this.method_20().method_15())
				{
					result = false;
				}
				else
				{
					this.activeUnit_0.vmethod_87().vmethod_11(null);
					this.activeUnit_0.vmethod_71(0f);
					this.activeUnit_0.vmethod_73(45.72f);
					this.method_37(Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar);
					this.method_39(240f);
					if (this.activeUnit_0.vmethod_14(false) > 45.72f)
					{
						this.method_39(240f);
					}
					result = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100432", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000F9948 File Offset: 0x000F7B48
		public override void vmethod_1(ref Scenario scenario_0, Dictionary<string, Class310> dictionary_0, bool bool_1)
		{
			checked
			{
				try
				{
					if (Information.IsNothing(this.method_34()) && !string.IsNullOrEmpty(this.string_1))
					{
						if (dictionary_0.ContainsKey(this.string_1))
						{
							this.method_35((AirFacility)dictionary_0[this.string_1]);
						}
						else
						{
							bool flag = false;
							try
							{
								List<ActiveUnit>.Enumerator enumerator = scenario_0.method_42().GetEnumerator();
								IL_AA:
								while (enumerator.MoveNext())
								{
									ActiveUnit activeUnit = enumerator.Current;
									if (!Information.IsNothing(activeUnit))
									{
										AirFacility[] array = activeUnit.vmethod_99();
										int i = 0;
										while (i < array.Length)
										{
											AirFacility airFacility = array[i];
											if (string.CompareOrdinal(airFacility.string_0, this.string_1) != 0)
											{
												i++;
											}
											else
											{
												this.method_35(airFacility);
												flag = true;
												IL_A7:
												if (!flag)
												{
													goto IL_AA;
												}
												goto IL_B3;
											}
										}
										goto IL_A7;
									}
								}
								IL_B3:;
							}
							finally
							{
								List<ActiveUnit>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
					}
					if (!Information.IsNothing(this.method_30()) && !Information.IsNothing(this.method_34()) && !Enumerable.Contains<AirFacility>(this.method_30().vmethod_99(), this.method_34()))
					{
						this.method_30().vmethod_92().method_18((Aircraft)this.activeUnit_0, bool_1);
					}
					if (Information.IsNothing(this.method_30()) && !string.IsNullOrEmpty(this.string_2))
					{
						try
						{
							foreach (ActiveUnit activeUnit2 in scenario_0.method_42())
							{
								if (!Information.IsNothing(activeUnit2) && Operators.CompareString(activeUnit2.string_0, this.string_2, false) == 0)
								{
									activeUnit2.vmethod_92().method_18((Aircraft)this.activeUnit_0, bool_1);
								}
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
					if (!this.method_20().vmethod_127() && Information.IsNothing(this.method_34()))
					{
						try
						{
							foreach (ActiveUnit activeUnit3 in scenario_0.vmethod_0().Values)
							{
								if (activeUnit3.list_2.Contains(this.string_1))
								{
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
					}
					if (Information.IsNothing(this.activeUnit_2) && !string.IsNullOrEmpty(this.string_3))
					{
						try
						{
							ActiveUnit activeUnit4 = scenario_0.vmethod_0()[this.string_3];
							if (!Information.IsNothing(activeUnit4))
							{
								this.method_33(false, activeUnit4);
								if (!this.method_20().vmethod_127() && (Information.IsNothing(this.method_34()) || Information.IsNothing(this.method_30())))
								{
									this.method_32(false).vmethod_92().method_18(this.method_20(), bool_1);
								}
							}
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 200022", ex.Message);
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
					}
					if (!string.IsNullOrEmpty(this.string_4))
					{
						this.aircraft_1 = (Aircraft)scenario_0.vmethod_0()[this.string_4];
					}
					base.vmethod_1(ref scenario_0, dictionary_0, bool_1);
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 100433", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x000F9CF8 File Offset: 0x000F7EF8
		public List<Aircraft> method_78(ref bool bool_1, ref ActiveUnit activeUnit_3, bool bool_2, List<Mission> list_0, ref string string_5)
		{
			List<Aircraft> list = new List<Aircraft>();
			List<Aircraft> result;
			try
			{
				Doctrine.Enum56? @enum = this.activeUnit_0.doctrine_0.method_152(this.activeUnit_0.scenario_0, false, false, false, false);
				byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
				int num;
				int num2;
				int num4;
				bool flag3;
				List<ActiveUnit> list2;
				checked
				{
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						bool flag = false;
						Waypoint[] array;
						if (this.activeUnit_0.vmethod_85().method_32())
						{
							array = this.activeUnit_0.vmethod_85().method_4();
						}
						else if (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_32())
						{
							array = this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_4();
						}
						if (!Information.IsNothing(array))
						{
							Waypoint[] array2 = array;
							for (int i = 0; i < array2.Length; i++)
							{
								Doctrine.Enum56? enum2 = array2[i].method_18().method_152(this.activeUnit_0.scenario_0, false, false, false, false);
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								bool? flag2 = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
								if (((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
								{
									flag = true;
									break;
								}
							}
						}
						if (!flag)
						{
							string_5 = "Aircraft " + this.activeUnit_0.Name + " has a doctrine setting that disallows air-to-air refuelling. As such, the aircraft will not refuel. Change the doctrine setting and try again.";
							return list;
						}
					}
					else
					{
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault() && this.method_20().method_146())
						{
							string_5 = "Aircraft " + this.activeUnit_0.Name + " is a tanker and the Air-to-Air Refuelling doctrine says that tankers are not allowed to refuel tankers. As such, the aircraft will not refuel. Change the doctrine setting and try again.";
							return list;
						}
					}
					num = 0;
					num2 = int.MaxValue;
					if (Information.IsNothing(list_0) && !Information.IsNothing(this.activeUnit_0.vmethod_101()))
					{
						Waypoint.WaypointType? nullable_ = this.activeUnit_0.vmethod_85().nullable_5;
						int? num3 = (nullable_ != null) ? new int?((int)nullable_.GetValueOrDefault()) : null;
						if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 14) : null).GetValueOrDefault() && this.activeUnit_0.vmethod_101().tankerMethod_0 == Mission.TankerMethod.Mission)
						{
							if (this.activeUnit_0.vmethod_101().list_4.Count <= 0)
							{
								return list;
							}
							list_0 = this.activeUnit_0.vmethod_101().list_4;
						}
					}
					if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && !bool_1)
					{
						num = this.activeUnit_0.vmethod_101().int_4;
						num2 = this.activeUnit_0.vmethod_101().int_6;
					}
					num4 = 0;
					flag3 = this.method_20().vmethod_127();
					string_5 = "No tankers are available.";
					if (bool_1 && !Information.IsNothing(activeUnit_3))
					{
						list2 = new List<ActiveUnit>();
						if (activeUnit_3.bool_1)
						{
							list2 = Enumerable.ToList<ActiveUnit>(((Group)activeUnit_3).vmethod_141().Values);
						}
						else
						{
							list2.Add(activeUnit_3);
						}
					}
					else
					{
						list2 = this.method_20().scenario_0.method_42();
					}
				}
				for (int j = list2.Count - 1; j >= 0; j += -1)
				{
					ActiveUnit activeUnit = list2[j];
					if (!Information.IsNothing(activeUnit) && activeUnit != this.method_20() && activeUnit.bool_3 && (activeUnit.vmethod_7(false) == this.method_20().vmethod_7(false) || activeUnit.vmethod_7(false).method_67(this.method_20().vmethod_7(false))))
					{
						Aircraft aircraft = (Aircraft)activeUnit;
						if (aircraft.method_146() && activeUnit.vmethod_127())
						{
							if (activeUnit.method_85())
							{
								if (num4 < 1)
								{
									num4 = 1;
									string_5 = "Tanker is RTB.";
								}
							}
							else if (Information.IsNothing(this.method_84(aircraft, this.method_20())))
							{
								if (num4 < 2)
								{
									num4 = 2;
									string_5 = "Aircraft lacks compatible air-to-air refuelling (AAR) gear.";
								}
							}
							else
							{
								Doctrine.Enum56? enum2 = activeUnit.doctrine_0.method_152(activeUnit.scenario_0, false, false, false, false);
								b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									if (num4 < 3)
									{
										num4 = 3;
										string_5 = "Aircraft " + activeUnit.Name + " has a doctrine setting that DISALLOWS air-to-air refuelling. As such, refuelling will not be performed. Change the doctrine setting and try again.";
									}
								}
								else
								{
									if (this.method_20().method_146())
									{
										enum2 = activeUnit.doctrine_0.method_152(activeUnit.scenario_0, false, false, false, false);
										b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
										if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											if (num4 < 4)
											{
												num4 = 4;
												string_5 = string.Concat(new string[]
												{
													"Receiving aircraft ",
													this.method_20().Name,
													" is a tanker and the Air-to-Air Refuelling doctrine for ",
													activeUnit.Name,
													" says that tankers are NOT allowed to refuel tankers. As such, the aircraft will not refuel. Change the doctrine setting and try again."
												});
												goto IL_BCC;
											}
											goto IL_BCC;
										}
									}
									if (activeUnit.vmethod_7(false) != this.method_20().vmethod_7(false))
									{
										Doctrine._RefuelAlliedUnits? refuelAlliedUnits = activeUnit.doctrine_0.method_240(activeUnit.scenario_0, false, false, false);
										b = ((refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
										if (!((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											b = ((refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
											if (!((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
											{
												goto IL_72C;
											}
										}
										if (num4 < 5)
										{
											num4 = 5;
											string_5 = "Aircraft " + activeUnit.Name + " is an ALLIED tanker and is not allowed to refuel allied units.";
											goto IL_BCC;
										}
										goto IL_BCC;
									}
									IL_72C:
									if (!activeUnit.vmethod_105(this.method_20()))
									{
										if (num4 < 6)
										{
											num4 = 6;
											string_5 = "Aircraft " + activeUnit.Name + " is a tanker but has the wrong refuelling gear (boom Vs. probe).";
										}
									}
									else if (activeUnit.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IsBingo)
									{
										if (num4 < 7)
										{
											num4 = 7;
											string_5 = "Aircraft " + activeUnit.Name + " has reached Bingo fuel state and will not offload fuel to clients.";
										}
									}
									else
									{
										if (!Information.IsNothing(list_0))
										{
											if (!Information.IsNothing(activeUnit.vmethod_101()))
											{
												bool flag4 = true;
												int k = list_0.Count - 1;
												while (k >= 0)
												{
													Mission mission = list_0[k];
													if (activeUnit.vmethod_101() == mission)
													{
														flag4 = false;
														IL_7EC:
														if (!flag4)
														{
															goto IL_835;
														}
														if (num4 >= 8)
														{
															goto IL_BCC;
														}
														num4 = 8;
														if (list_0.Count == 1)
														{
															string_5 = "Mission " + activeUnit.vmethod_101().Name + " has no available tankers.";
															goto IL_BCC;
														}
														string_5 = "There are no available tankers on selected missions.";
														goto IL_BCC;
													}
													else
													{
														k += -1;
													}
												}
												goto IL_7EC;
											}
											goto IL_BCC;
										}
										IL_835:
										bool flag5 = false;
										Aircraft_AirOps aircraft_AirOps = ((Aircraft)activeUnit).method_164();
										if (aircraft_AirOps.concurrentDictionary_0.ContainsKey(this.method_20().string_0))
										{
											flag5 = true;
										}
										if (!bool_1 && flag3 && !flag5)
										{
											if (num > 0 && aircraft_AirOps.concurrentDictionary_0.Count >= num)
											{
												if (num4 >= 9)
												{
													goto IL_BCC;
												}
												num4 = 9;
												if (!Information.IsNothing(list_0) && list_0.Count == 1)
												{
													string_5 = "Tankers on mission " + list_0[0].Name + " have full queues and cannot serve more receivers.";
													goto IL_BCC;
												}
												string_5 = "Tankers have full queues and cannot serve more receivers.";
												goto IL_BCC;
											}
											else if (!Information.IsNothing(activeUnit.vmethod_101()) && activeUnit.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support)
											{
												Class344 @class = (Class344)activeUnit.vmethod_101();
												if (@class.int_8 > 0 && aircraft_AirOps.int_0 + aircraft_AirOps.concurrentDictionary_0.Count + aircraft_AirOps.concurrentDictionary_1.Count >= @class.int_8)
												{
													if (num4 >= 10)
													{
														goto IL_BCC;
													}
													num4 = 10;
													if (!Information.IsNothing(list_0) && list_0.Count == 1)
													{
														string_5 = string.Concat(new string[]
														{
															"Tankers on mission ",
															list_0[0].Name,
															" are only allowed to serve ",
															Conversions.ToString(@class.int_8),
															" receivers per tanker. None of the tankers can serve more receivers."
														});
														goto IL_BCC;
													}
													string_5 = "Tankers are only allowed to serve " + Conversions.ToString(@class.int_8) + " receivers per tanker. None of the available tankers can serve more receivers.";
													goto IL_BCC;
												}
											}
										}
										if (!activeUnit.vmethod_107(this.method_20(), aircraft_AirOps, 0.1f, flag5))
										{
											if (num4 < 11)
											{
												num4 = 11;
												if (!Information.IsNothing(list_0) && list_0.Count == 1)
												{
													string_5 = "Tankers on mission " + list_0[0].Name + " do not have enough fuel left aboard to serve more receivers.";
												}
												else
												{
													string_5 = "Tankers do not have enough fuel left aboard to serve more receivers.";
												}
											}
										}
										else
										{
											float? num5 = null;
											if (!bool_1 && flag3 && !flag5 && num2 != 2147483647)
											{
												num5 = new float?(this.method_20().method_36(activeUnit));
												float num6 = (float)num2;
												if (((num5 != null) ? new bool?(num6 < num5.GetValueOrDefault()) : null).GetValueOrDefault())
												{
													if (num4 < 12)
													{
														num4 = 12;
														string_5 = string.Concat(new string[]
														{
															"Aircraft",
															this.method_20().Name,
															" must be within ",
															Conversions.ToString(num2),
															" nm of a tanker to refuel, however the nearest tanker is ",
															Conversions.ToString((int)Math.Round((double)num5.Value)),
															" nm away"
														});
														goto IL_BCC;
													}
													goto IL_BCC;
												}
											}
											if (bool_2)
											{
												if (Information.IsNothing(num5))
												{
													num5 = new float?(this.method_20().method_36(activeUnit));
												}
												ActiveUnit_AI activeUnit_AI = this.method_20().method_158();
												Unit unit_ = activeUnit;
												float? nullable_2 = num5;
												Class211 class2 = this.method_20().method_157();
												bool flag6 = false;
												float num7 = class2.method_73(ref flag6);
												float? nullable_3 = null;
												float num8 = this.activeUnit_0.vmethod_9();
												ActiveUnit.Throttle throttle_ = ActiveUnit.Throttle.Cruise;
												float? nullable_4 = new float?(2f);
												bool bool_3 = true;
												bool bool_4 = true;
												bool flag7 = false;
												if (!activeUnit_AI.method_61(unit_, nullable_2, num7, nullable_3, num8, throttle_, nullable_4, bool_3, bool_4, ref flag7))
												{
													if (num4 < 13)
													{
														num4 = 13;
														string_5 = "Aircraft" + this.method_20().Name + " does not have enough fuel to reach a tanker. Alternatively, there are too many receivers in queue on tankers within range, and that there might not be enough fuel for more receivers.";
														goto IL_BCC;
													}
													goto IL_BCC;
												}
											}
											list.Add((Aircraft)activeUnit);
										}
									}
								}
							}
						}
					}
					IL_BCC:;
				}
				result = list;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200293", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Aircraft>();
			}
			return result;
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x000FA940 File Offset: 0x000F8B40
		public bool method_79(Aircraft aircraft_3, ref bool bool_1, bool bool_2, bool bool_3)
		{
			bool result;
			try
			{
				if (this.method_20().vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling)
				{
					result = true;
				}
				else if (Information.IsNothing(aircraft_3))
				{
					result = false;
				}
				else if (aircraft_3 == this.method_20())
				{
					result = false;
				}
				else
				{
					if (!bool_2 && !bool_3 && this.activeUnit_0.vmethod_85().method_32() && !this.activeUnit_0.vmethod_85().method_4()[0].method_39())
					{
						double num = this.method_20().method_31(aircraft_3);
						double num2 = Math2.smethod_14(this.method_20().method_157().method_4()[0].imethod_2(), this.method_20().method_157().method_4()[0].imethod_0(), this.method_20().vmethod_30(null), this.method_20().vmethod_28(null));
						if (Math2.smethod_14(this.method_20().method_157().method_4()[0].imethod_2(), this.method_20().method_157().method_4()[0].imethod_0(), aircraft_3.vmethod_30(null), aircraft_3.vmethod_28(null)) < num && num > num2)
						{
							bool_1 = true;
							return false;
						}
					}
					ActiveUnit_AI activeUnit_AI = this.method_20().method_158();
					float? nullable_ = null;
					Class211 @class = this.method_20().method_157();
					bool flag = false;
					float num3 = @class.method_73(ref flag);
					float? nullable_2 = null;
					float num4 = this.activeUnit_0.vmethod_9();
					ActiveUnit.Throttle throttle_ = ActiveUnit.Throttle.Cruise;
					float? nullable_3 = new float?(0.25f);
					bool bool_4 = true;
					bool bool_5 = true;
					bool flag2 = false;
					if (activeUnit_AI.method_61(aircraft_3, nullable_, num3, nullable_2, num4, throttle_, nullable_3, bool_4, bool_5, ref flag2))
					{
						this.method_20().vmethod_109(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
						this.method_37(Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel);
						this.method_25(aircraft_3);
						if (this.method_20().method_120() && this.method_20().vmethod_65(false).method_143() == Group.GroupType.AirGroup)
						{
							ActiveUnit activeUnit = this.method_20().vmethod_65(false).method_147();
							((Aircraft)this.method_20().vmethod_65(false).method_147()).method_164();
							if (!Information.IsNothing(aircraft_3))
							{
								try
								{
									foreach (ActiveUnit activeUnit2 in this.method_20().vmethod_65(false).vmethod_141().Values)
									{
										if (activeUnit2 != activeUnit && activeUnit2.vmethod_108() != ActiveUnit._ActiveUnitStatus.Refuelling && activeUnit2.vmethod_127() && activeUnit2 != aircraft_3)
										{
											Aircraft_AirOps aircraft_AirOps = ((Aircraft)activeUnit2).method_164();
											activeUnit2.vmethod_109(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
											aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel);
											aircraft_AirOps.method_25(aircraft_3);
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
				ex.Data.Add("Error at 100435", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x000FAC5C File Offset: 0x000F8E5C
		public bool method_80(GeoPoint geoPoint_0, Doctrine.Enum57 enum57_0, ref bool bool_1, bool bool_2, ref ActiveUnit activeUnit_3, ref List<Mission> list_0, ref string string_5, ref bool bool_3, ref bool bool_4)
		{
			Aircraft_AirOps.Class255 @class = new Aircraft_AirOps.Class255(@class);
			@class.aircraft_AirOps_0 = this;
			@class.geoPoint_0 = geoPoint_0;
			bool result;
			try
			{
				if (!this.method_20().bool_28 && !this.method_20().bool_27)
				{
					string_5 = "Aircraft lacks air-to-air refuelling (AAR) capability.";
					result = false;
				}
				else
				{
					if (!Information.IsNothing(activeUnit_3))
					{
						if (activeUnit_3 == this.method_20())
						{
							string_5 = "Aircraft cannot refuel from itself.";
							return false;
						}
						if (Information.IsNothing(this.method_84((Aircraft)activeUnit_3, this.method_20())))
						{
							string_5 = "Aircraft has lacks compatible air-to-air refuelling (AAR) gear.";
							return false;
						}
					}
					if (bool_1 && !Information.IsNothing(activeUnit_3))
					{
						if (activeUnit_3.bool_1)
						{
							if (Information.IsNothing(((Group)activeUnit_3).method_147()))
							{
								return false;
							}
							activeUnit_3 = ((Group)activeUnit_3).method_147();
						}
						if (this.method_78(ref bool_1, ref activeUnit_3, true, list_0, ref string_5).Count == 0)
						{
							result = false;
						}
						else if (this.method_79((Aircraft)activeUnit_3, ref bool_4, bool_1, bool_2))
						{
							result = true;
						}
						else
						{
							string_5 = "Could not rendezvous with selected tanker.";
							result = false;
						}
					}
					else if (this.method_20().method_121() && this.method_20().vmethod_65(false).method_143() == Group.GroupType.AirGroup)
					{
						if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && (this.activeUnit_0.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || this.activeUnit_0.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling))
						{
							result = true;
						}
						else
						{
							Aircraft aircraft = (Aircraft)this.method_20().vmethod_65(false).method_147();
							if (aircraft.method_164().method_80(@class.geoPoint_0, enum57_0, ref bool_1, bool_2, ref activeUnit_3, ref list_0, ref string_5, ref bool_3, ref bool_4))
							{
								Aircraft aircraft2 = aircraft.method_164().method_24();
								if (!Information.IsNothing(aircraft2))
								{
									try
									{
										foreach (ActiveUnit activeUnit in this.method_20().vmethod_65(false).vmethod_141().Values)
										{
											if (activeUnit != aircraft && activeUnit.vmethod_127())
											{
												Aircraft_AirOps aircraft_AirOps = ((Aircraft)activeUnit).method_164();
												if (activeUnit != aircraft2)
												{
													activeUnit.vmethod_109(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
													aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel);
													aircraft_AirOps.method_25(aircraft2);
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
								}
								result = true;
							}
							else
							{
								result = false;
							}
						}
					}
					else
					{
						ActiveUnit activeUnit2 = null;
						List<Aircraft> list = this.method_78(ref bool_1, ref activeUnit2, true, list_0, ref string_5);
						if (list.Count == 0)
						{
							result = false;
						}
						else
						{
							if (!this.method_20().method_153() && (enum57_0 == Doctrine.Enum57.const_1 || enum57_0 == Doctrine.Enum57.const_2) && Information.IsNothing(@class.geoPoint_0))
							{
								enum57_0 = Doctrine.Enum57.const_0;
							}
							Doctrine.Enum57 @enum = enum57_0;
							if (@enum != Doctrine.Enum57.const_0)
							{
								if (@enum - Doctrine.Enum57.const_1 <= 1)
								{
									if (!bool_3)
									{
										Aircraft_AirOps.Class254 class2 = new Aircraft_AirOps.Class254(class2);
										class2.class255_0 = @class;
										class2.double_0 = this.method_20().method_28(class2.class255_0.geoPoint_0);
										IEnumerable<Aircraft> enumerable = Enumerable.Where<Aircraft>(list, new Func<Aircraft, bool>(class2.method_0));
										if (Enumerable.Count<Aircraft>(enumerable) > 0)
										{
											IEnumerable<Aircraft> enumerable2 = Enumerable.OrderBy<Aircraft, int>(enumerable, new Func<Aircraft, int>(this.method_95));
											try
											{
												foreach (Aircraft aircraft_ in enumerable2)
												{
													if (this.method_79(aircraft_, ref bool_4, bool_1, bool_2))
													{
														return true;
													}
												}
												goto IL_412;
											}
											finally
											{
												IEnumerator<Aircraft> enumerator2;
												if (enumerator2 != null)
												{
													enumerator2.Dispose();
												}
											}
										}
										if (enum57_0 == Doctrine.Enum57.const_2)
										{
											IEnumerable<Aircraft> enumerable2 = Enumerable.OrderBy<Aircraft, int>(list, new Func<Aircraft, int>(this.method_96));
											try
											{
												foreach (Aircraft aircraft3 in enumerable2)
												{
													double num = this.method_20().method_31(aircraft3);
													double num2 = aircraft3.method_28(class2.class255_0.geoPoint_0);
													if (num < class2.double_0 && num2 < class2.double_0 && this.method_79(aircraft3, ref bool_4, bool_1, bool_2))
													{
														return true;
													}
												}
											}
											finally
											{
												IEnumerator<Aircraft> enumerator3;
												if (enumerator3 != null)
												{
													enumerator3.Dispose();
												}
											}
										}
										IL_412:
										if (!bool_2 && !this.activeUnit_0.vmethod_85().method_28() && (!this.activeUnit_0.method_121() || Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) || !this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_28()) && (this.activeUnit_0.vmethod_85().method_32() || (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_32())))
										{
											return false;
										}
									}
									else
									{
										Aircraft_AirOps.Class257 class3 = new Aircraft_AirOps.Class257(class3);
										class3.class255_0 = @class;
										class3.activeUnit_0 = this.method_21();
										if (Information.IsNothing(class3.activeUnit_0))
										{
											IEnumerable<Aircraft> enumerable2 = Enumerable.OrderBy<Aircraft, int>(list, new Func<Aircraft, int>(this.method_97));
											try
											{
												foreach (Aircraft aircraft_2 in enumerable2)
												{
													if (this.method_79(aircraft_2, ref bool_4, bool_1, bool_2))
													{
														return true;
													}
												}
												goto IL_74A;
											}
											finally
											{
												IEnumerator<Aircraft> enumerator4;
												if (enumerator4 != null)
												{
													enumerator4.Dispose();
												}
											}
										}
										Aircraft_AirOps.Class256 class4 = new Aircraft_AirOps.Class256(class4);
										class4.class257_0 = class3;
										class4.double_0 = this.method_20().method_31(class4.class257_0.activeUnit_0);
										IEnumerable<Aircraft> enumerable3 = Enumerable.OrderBy<Aircraft, double>(Enumerable.Where<Aircraft>(list, new Func<Aircraft, bool>(class4.method_0)), new Func<Aircraft, double>(this.method_98));
										if (Enumerable.Count<Aircraft>(enumerable3) > 0)
										{
											IEnumerable<Aircraft> enumerable2 = Enumerable.OrderBy<Aircraft, int>(enumerable3, new Func<Aircraft, int>(this.method_99));
											try
											{
												foreach (Aircraft aircraft_3 in enumerable2)
												{
													if (this.method_79(aircraft_3, ref bool_4, bool_1, bool_2))
													{
														return true;
													}
												}
												goto IL_74A;
											}
											finally
											{
												IEnumerator<Aircraft> enumerator5;
												if (enumerator5 != null)
												{
													enumerator5.Dispose();
												}
											}
										}
										if (enum57_0 == Doctrine.Enum57.const_2)
										{
											if (this.method_20().vmethod_62(class4.class257_0.activeUnit_0, null, this.method_20().doctrine_0.method_206(this.method_20().scenario_0, false, true, false, false)) == ActiveUnit._ActiveUnitFuelState.IsBingo)
											{
												IEnumerable<Aircraft> enumerable2 = Enumerable.OrderBy<Aircraft, int>(list, new Func<Aircraft, int>(this.method_100));
												try
												{
													foreach (Aircraft aircraft4 in enumerable2)
													{
														double num3 = this.method_20().method_31(aircraft4);
														double num4 = aircraft4.method_31(class4.class257_0.activeUnit_0);
														if (num3 < class4.double_0 && num4 < class4.double_0 && this.method_79(aircraft4, ref bool_4, bool_1, bool_2))
														{
															return true;
														}
													}
												}
												finally
												{
													IEnumerator<Aircraft> enumerator6;
													if (enumerator6 != null)
													{
														enumerator6.Dispose();
													}
												}
												return false;
											}
											return false;
										}
									}
								}
							}
							else
							{
								IEnumerable<Aircraft> enumerable2 = Enumerable.OrderBy<Aircraft, int>(list, new Func<Aircraft, int>(this.method_94));
								try
								{
									foreach (Aircraft aircraft_4 in enumerable2)
									{
										if (this.method_79(aircraft_4, ref bool_4, bool_1, bool_2))
										{
											return true;
										}
									}
								}
								finally
								{
									IEnumerator<Aircraft> enumerator7;
									if (enumerator7 != null)
									{
										enumerator7.Dispose();
									}
								}
							}
							IL_74A:
							if (enum57_0 != Doctrine.Enum57.const_1)
							{
								IEnumerable<Aircraft> enumerable4 = Enumerable.OrderBy<Aircraft, double>(list, new Func<Aircraft, double>(this.method_101));
								try
								{
									foreach (Aircraft aircraft_5 in enumerable4)
									{
										if (this.method_79(aircraft_5, ref bool_4, bool_1, bool_2))
										{
											return true;
										}
									}
								}
								finally
								{
									IEnumerator<Aircraft> enumerator8;
									if (enumerator8 != null)
									{
										enumerator8.Dispose();
									}
								}
							}
							string_5 = "Could not find suitable tanker.";
							result = false;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100436", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x000FB52C File Offset: 0x000F972C
		private int method_81(Aircraft aircraft_3)
		{
			float val = this.method_20().method_53(this.method_20().vmethod_40(), this.method_20().method_25(aircraft_3.vmethod_30(null), aircraft_3.vmethod_28(null)));
			Aircraft_AirOps aircraft_AirOps = aircraft_3.method_164();
			List<string> list = Enumerable.ToList<string>(aircraft_AirOps.concurrentDictionary_0.Keys);
			try
			{
				foreach (string text in list)
				{
					Aircraft aircraft = (Aircraft)this.method_20().scenario_0.vmethod_0()[text];
					if (Information.IsNothing(aircraft) || aircraft.vmethod_108() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
					{
						ConcurrentDictionary<string, byte> concurrentDictionary = aircraft_AirOps.concurrentDictionary_0;
						string text2 = text;
						byte b = 0;
						concurrentDictionary.TryRemove(text2, ref b);
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			float num3;
			try
			{
				foreach (string key in list)
				{
					Aircraft aircraft2 = (Aircraft)this.method_20().scenario_0.vmethod_0()[key];
					if (!aircraft2.method_82())
					{
						Aircraft_AirOps.Enum43? nullable_ = this.method_84(aircraft_3, aircraft2);
						float num = this.method_43(aircraft2, nullable_);
						float num2 = (float)aircraft2.vmethod_115() / num;
						num3 += num2;
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			return (int)Math.Round((double)Math.Max(val, num3));
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x000FB6AC File Offset: 0x000F98AC
		public bool method_82(bool bool_1)
		{
			bool result;
			try
			{
				if (Information.IsNothing(this.method_24()))
				{
					result = false;
				}
				else if (!bool_1 && this.method_20().method_36(this.method_24()) > this.float_3)
				{
					result = false;
				}
				else if (this.method_24().method_164().method_87(this.method_20(), bool_1))
				{
					this.method_83(bool_1);
					result = true;
				}
				else if (this.method_20().method_120())
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.method_20().vmethod_65(false).vmethod_141().Values)
						{
							if (activeUnit.vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling && ((Aircraft)activeUnit).method_164().method_24() == this.method_24())
							{
								this.method_83(bool_1);
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
					result = false;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100437", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x000FB7EC File Offset: 0x000F99EC
		private void method_83(bool bool_1)
		{
			try
			{
				Aircraft_AirOps aircraft_AirOps = this.method_24().method_164();
				if (Information.IsNothing(this.method_20()))
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				else if (string.IsNullOrEmpty(this.method_20().string_0) && Debugger.IsAttached)
				{
					Debugger.Break();
				}
				if (this.method_20().bool_28)
				{
					if (!aircraft_AirOps.concurrentDictionary_1.ContainsKey(this.method_20().string_0))
					{
						aircraft_AirOps.concurrentDictionary_1.TryAdd(this.method_20().string_0, Aircraft_AirOps.Enum43.const_1);
					}
					else
					{
						aircraft_AirOps.concurrentDictionary_1[this.method_20().string_0] = Aircraft_AirOps.Enum43.const_1;
					}
					this.method_20().vmethod_109(ActiveUnit._ActiveUnitStatus.Refuelling);
					aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.OffloadingFuel);
					ConcurrentDictionary<string, byte> concurrentDictionary = aircraft_AirOps.concurrentDictionary_0;
					string string_ = this.method_20().string_0;
					byte b = 0;
					concurrentDictionary.TryRemove(string_, ref b);
				}
				else if (this.method_20().bool_27)
				{
					if (!aircraft_AirOps.concurrentDictionary_1.ContainsKey(this.method_20().string_0))
					{
						if (this.method_24().method_143())
						{
							aircraft_AirOps.concurrentDictionary_1.TryAdd(this.method_20().string_0, Aircraft_AirOps.Enum43.const_2);
						}
						else
						{
							aircraft_AirOps.concurrentDictionary_1.TryAdd(this.method_20().string_0, Aircraft_AirOps.Enum43.const_0);
						}
					}
					else if (this.method_24().method_143())
					{
						aircraft_AirOps.concurrentDictionary_1[this.method_20().string_0] = Aircraft_AirOps.Enum43.const_2;
					}
					else
					{
						aircraft_AirOps.concurrentDictionary_1[this.method_20().string_0] = Aircraft_AirOps.Enum43.const_0;
					}
					this.method_20().vmethod_109(ActiveUnit._ActiveUnitStatus.Refuelling);
					aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.OffloadingFuel);
					ConcurrentDictionary<string, byte> concurrentDictionary2 = aircraft_AirOps.concurrentDictionary_0;
					string string_2 = this.method_20().string_0;
					byte b = 0;
					concurrentDictionary2.TryRemove(string_2, ref b);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100438", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x000FB9F4 File Offset: 0x000F9BF4
		private Aircraft_AirOps.Enum43? method_84(Aircraft aircraft_3, Aircraft aircraft_4)
		{
			Aircraft_AirOps.Enum43? result;
			if (aircraft_4.bool_28 && aircraft_3.bool_31)
			{
				result = new Aircraft_AirOps.Enum43?(Aircraft_AirOps.Enum43.const_1);
			}
			else if (aircraft_4.bool_27 && (aircraft_3.bool_29 || aircraft_3.bool_30))
			{
				result = new Aircraft_AirOps.Enum43?(Aircraft_AirOps.Enum43.const_0);
			}
			else if (aircraft_3.method_143() && aircraft_4.bool_27)
			{
				result = new Aircraft_AirOps.Enum43?(Aircraft_AirOps.Enum43.const_2);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x000FBA60 File Offset: 0x000F9C60
		private bool method_85(Aircraft aircraft_3, bool bool_1)
		{
			bool result;
			try
			{
				if (aircraft_3.bool_28)
				{
					if (bool_1 && aircraft_3.method_121())
					{
						result = true;
					}
					else if (this.method_20().bool_31)
					{
						try
						{
							foreach (KeyValuePair<string, Aircraft_AirOps.Enum43> keyValuePair in this.concurrentDictionary_1)
							{
								if (keyValuePair.Value == Aircraft_AirOps.Enum43.const_1)
								{
									return false;
								}
							}
						}
						finally
						{
							IEnumerator<KeyValuePair<string, Aircraft_AirOps.Enum43>> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
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
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100439", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x000FBB2C File Offset: 0x000F9D2C
		private bool method_86(Aircraft aircraft_3, bool bool_1)
		{
			bool result;
			try
			{
				if (aircraft_3.bool_27)
				{
					if (bool_1 && aircraft_3.method_121())
					{
						result = true;
					}
					else
					{
						int num = 0;
						if (this.method_20().method_143())
						{
							num++;
						}
						if (this.method_20().bool_29)
						{
							num++;
						}
						if (this.method_20().bool_30)
						{
							num += 2;
						}
						if (num > 0)
						{
							int num2 = 0;
							try
							{
								foreach (KeyValuePair<string, Aircraft_AirOps.Enum43> keyValuePair in this.concurrentDictionary_1)
								{
									if (keyValuePair.Value == Aircraft_AirOps.Enum43.const_0)
									{
										num2++;
									}
								}
							}
							finally
							{
								IEnumerator<KeyValuePair<string, Aircraft_AirOps.Enum43>> enumerator;
								if (enumerator != null)
								{
									enumerator.Dispose();
								}
							}
							result = (num > num2);
						}
					}
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100440", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x000FBC28 File Offset: 0x000F9E28
		public bool method_87(Aircraft aircraft_3, bool bool_1)
		{
			bool result;
			try
			{
				if (!this.method_20().method_146())
				{
					result = false;
				}
				else if (!this.method_20().vmethod_105(aircraft_3))
				{
					result = false;
				}
				else
				{
					if (!bool_1)
					{
						List<string> list = new List<string>();
						bool flag = true;
						try
						{
							foreach (KeyValuePair<string, Aircraft_AirOps.Enum43> keyValuePair in this.concurrentDictionary_1)
							{
								if (!Information.IsNothing(keyValuePair.Key))
								{
									Aircraft aircraft = (Aircraft)this.method_20().scenario_0.vmethod_0()[keyValuePair.Key];
									if (Information.IsNothing(aircraft))
									{
										list.Add(keyValuePair.Key);
									}
									else if (aircraft.aircraftSizeClass_0 >= GlobalVariables.AircraftSizeClass.Large)
									{
										flag = false;
										break;
									}
								}
							}
						}
						finally
						{
							IEnumerator<KeyValuePair<string, Aircraft_AirOps.Enum43>> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						try
						{
							foreach (string text in list)
							{
								ConcurrentDictionary<string, Aircraft_AirOps.Enum43> concurrentDictionary = this.concurrentDictionary_1;
								string text2 = text;
								Aircraft_AirOps.Enum43 @enum = Aircraft_AirOps.Enum43.const_0;
								concurrentDictionary.TryRemove(text2, ref @enum);
							}
						}
						finally
						{
							List<string>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						if (!flag)
						{
							return false;
						}
					}
					if (this.method_85(aircraft_3, bool_1))
					{
						result = true;
					}
					else if (this.method_86(aircraft_3, bool_1))
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
				ex.Data.Add("Error at 100441", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x000FBDDC File Offset: 0x000F9FDC
		public void method_88()
		{
			if (Enumerable.Any<Cargo>(this.activeUnit_0.cargo_0, (Aircraft_AirOps._Closure$__.$I146-0 == null) ? (Aircraft_AirOps._Closure$__.$I146-0 = new Func<Cargo, bool>(Aircraft_AirOps._Closure$__.$I.method_25)) : Aircraft_AirOps._Closure$__.$I146-0))
			{
				List<Facility> list = Facility.smethod_10(Enumerable.ToList<Mount>(Enumerable.Select<Cargo, Mount>(Enumerable.Where<Cargo>(this.activeUnit_0.cargo_0, (Aircraft_AirOps._Closure$__.$I146-1 == null) ? (Aircraft_AirOps._Closure$__.$I146-1 = new Func<Cargo, bool>(Aircraft_AirOps._Closure$__.$I.method_26)) : Aircraft_AirOps._Closure$__.$I146-1), (Aircraft_AirOps._Closure$__.$I146-2 == null) ? (Aircraft_AirOps._Closure$__.$I146-2 = new Func<Cargo, Mount>(Aircraft_AirOps._Closure$__.$I.method_27)) : Aircraft_AirOps._Closure$__.$I146-2)), this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_7(false));
				try
				{
					foreach (Facility facility in list)
					{
						facility.vmethod_29(null, this.activeUnit_0.vmethod_28(null));
						facility.vmethod_31(null, this.activeUnit_0.vmethod_30(null));
					}
				}
				finally
				{
					List<Facility>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				Class429.smethod_8(ref this.activeUnit_0.cargo_0);
			}
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x000FBF30 File Offset: 0x000FA130
		public void method_89()
		{
			List<Facility> list = Facility.smethod_10(Enumerable.ToList<Mount>(Enumerable.Select<Cargo, Mount>(this.activeUnit_0.cargo_0, (Aircraft_AirOps._Closure$__.$I147-0 == null) ? (Aircraft_AirOps._Closure$__.$I147-0 = new Func<Cargo, Mount>(Aircraft_AirOps._Closure$__.$I.method_28)) : Aircraft_AirOps._Closure$__.$I147-0)), this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_7(false));
			try
			{
				foreach (Facility facility in list)
				{
					facility.vmethod_29(null, this.activeUnit_0.vmethod_28(null));
					facility.vmethod_31(null, this.activeUnit_0.vmethod_30(null));
				}
			}
			finally
			{
				List<Facility>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			Class429.smethod_8(ref this.activeUnit_0.cargo_0);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x000FC024 File Offset: 0x000FA224
		public void method_90(ActiveUnit activeUnit_3)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			Cargo[] cargo_ = activeUnit_3.cargo_0;
			checked
			{
				for (int i = 0; i < cargo_.Length; i++)
				{
					Mount mount = (Mount)cargo_[i].method_25();
					if (dictionary.ContainsKey(mount.DBID))
					{
						Dictionary<int, int> dictionary2;
						int dbid;
						(dictionary2 = dictionary)[dbid = mount.DBID] = unchecked(dictionary2[dbid] + 1);
					}
					else
					{
						dictionary.Add(mount.DBID, 1);
					}
				}
			}
			try
			{
				foreach (Mount mount2 in activeUnit_3.vmethod_51())
				{
					if (mount2.cargoType_0 != CargoType.NoCargo)
					{
						if (dictionary.ContainsKey(mount2.DBID))
						{
							Dictionary<int, int> dictionary2;
							int dbid;
							(dictionary2 = dictionary)[dbid = mount2.DBID] = dictionary2[dbid] + 1;
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
			if (dictionary.Count != 0)
			{
				List<Cargo> list = ActiveUnit_DockingOps.smethod_11((Interface3)activeUnit_3, (Interface3)this.activeUnit_0, dictionary);
				if (list.Count != 0)
				{
					ActiveUnit_DockingOps.smethod_13(activeUnit_3, this.activeUnit_0, list);
					this.activeUnit_0.vmethod_86().method_17(activeUnit_3.string_0);
				}
			}
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x000FC16C File Offset: 0x000FA36C
		public int method_91()
		{
			int num;
			switch (this.method_20().method_163().vmethod_3())
			{
			case ActiveUnit_Damage.FireIntensityLevel.Minor:
				num = 900;
				break;
			case ActiveUnit_Damage.FireIntensityLevel.Major:
				num = 1800;
				break;
			case ActiveUnit_Damage.FireIntensityLevel.Severe:
				num = 2700;
				break;
			case ActiveUnit_Damage.FireIntensityLevel.Conflagration:
				num = 3600;
				break;
			}
			int num2 = (int)Math.Round((double)(this.method_20().method_163().method_0() / 100f * 86400f));
			switch (this.method_20().aircraftSizeClass_0)
			{
			case GlobalVariables.AircraftSizeClass.Medium:
				num2 = (int)Math.Round((double)num2 * 1.5);
				break;
			case GlobalVariables.AircraftSizeClass.Large:
				num2 *= 2;
				break;
			case GlobalVariables.AircraftSizeClass.VLarge:
				num2 *= 3;
				break;
			}
			int num3;
			try
			{
				foreach (PlatformComponent platformComponent in this.method_20().vmethod_120())
				{
					if (platformComponent.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
					{
						if (platformComponent.method_14())
						{
							if (platformComponent.vmethod_5() == PlatformComponent._ComponentStatus.Destroyed)
							{
								num3 += 3600;
							}
							else
							{
								switch (platformComponent.method_16())
								{
								case PlatformComponent._DamageSeverityFactor.Light:
									num3 += 900;
									break;
								case PlatformComponent._DamageSeverityFactor.Medium:
									num3 += 1800;
									break;
								case PlatformComponent._DamageSeverityFactor.Heavy:
									num3 += 2700;
									break;
								}
							}
						}
						else if (platformComponent.method_15())
						{
							if (platformComponent.vmethod_5() == PlatformComponent._ComponentStatus.Destroyed)
							{
								num3 += 10800;
							}
							else
							{
								switch (platformComponent.method_16())
								{
								case PlatformComponent._DamageSeverityFactor.Light:
									num3 += 2700;
									break;
								case PlatformComponent._DamageSeverityFactor.Medium:
									num3 += 5400;
									break;
								case PlatformComponent._DamageSeverityFactor.Heavy:
									num3 += 8100;
									break;
								}
							}
						}
						else if (!platformComponent.method_12() && !platformComponent.method_10() && !platformComponent.method_8())
						{
							if (platformComponent.method_13())
							{
								if (platformComponent.vmethod_5() == PlatformComponent._ComponentStatus.Destroyed)
								{
									num3 += 14400;
								}
								else
								{
									switch (platformComponent.method_16())
									{
									case PlatformComponent._DamageSeverityFactor.Light:
										num3 += 3600;
										break;
									case PlatformComponent._DamageSeverityFactor.Medium:
										num3 += 7200;
										break;
									case PlatformComponent._DamageSeverityFactor.Heavy:
										num3 += 10800;
										break;
									}
								}
							}
						}
						else if (platformComponent.vmethod_5() == PlatformComponent._ComponentStatus.Destroyed)
						{
							num3 += 14400;
						}
						else
						{
							switch (platformComponent.method_16())
							{
							case PlatformComponent._DamageSeverityFactor.Light:
								num3 += 3600;
								break;
							case PlatformComponent._DamageSeverityFactor.Medium:
								num3 += 7200;
								break;
							case PlatformComponent._DamageSeverityFactor.Heavy:
								num3 += 10800;
								break;
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator<PlatformComponent> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return num + num2 + num3;
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00008BE3 File Offset: 0x00006DE3
		[CompilerGenerated]
		private double method_92(ActiveUnit activeUnit_3)
		{
			return activeUnit_3.method_31(this.activeUnit_0);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00008BF1 File Offset: 0x00006DF1
		[CompilerGenerated]
		private double method_93(ActiveUnit activeUnit_3)
		{
			return activeUnit_3.method_31(this.airFacility_0.method_18());
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00008C04 File Offset: 0x00006E04
		[CompilerGenerated]
		private int method_94(Aircraft aircraft_3)
		{
			return this.method_81(aircraft_3);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00008C04 File Offset: 0x00006E04
		[CompilerGenerated]
		private int method_95(Aircraft aircraft_3)
		{
			return this.method_81(aircraft_3);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00008C04 File Offset: 0x00006E04
		[CompilerGenerated]
		private int method_96(Aircraft aircraft_3)
		{
			return this.method_81(aircraft_3);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00008C04 File Offset: 0x00006E04
		[CompilerGenerated]
		private int method_97(Aircraft aircraft_3)
		{
			return this.method_81(aircraft_3);
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00008C0D File Offset: 0x00006E0D
		[CompilerGenerated]
		private double method_98(Aircraft aircraft_3)
		{
			return aircraft_3.method_31(this.method_20());
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00008C04 File Offset: 0x00006E04
		[CompilerGenerated]
		private int method_99(Aircraft aircraft_3)
		{
			return this.method_81(aircraft_3);
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00008C04 File Offset: 0x00006E04
		[CompilerGenerated]
		private int method_100(Aircraft aircraft_3)
		{
			return this.method_81(aircraft_3);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00008C0D File Offset: 0x00006E0D
		[CompilerGenerated]
		private double method_101(Aircraft aircraft_3)
		{
			return aircraft_3.method_31(this.method_20());
		}

		// Token: 0x04000832 RID: 2098
		private Aircraft_AirOps._AirOpsCondition _AirOpsCondition_0;

		// Token: 0x04000833 RID: 2099
		private Aircraft_AirOps._AirOpsCondition _AirOpsCondition_1;

		// Token: 0x04000834 RID: 2100
		private float float_0;

		// Token: 0x04000835 RID: 2101
		private AirFacility airFacility_0;

		// Token: 0x04000836 RID: 2102
		private string string_1;

		// Token: 0x04000837 RID: 2103
		private ActiveUnit activeUnit_1;

		// Token: 0x04000838 RID: 2104
		private string string_2;

		// Token: 0x04000839 RID: 2105
		private ActiveUnit activeUnit_2;

		// Token: 0x0400083A RID: 2106
		private string string_3;

		// Token: 0x0400083B RID: 2107
		private Aircraft aircraft_1;

		// Token: 0x0400083C RID: 2108
		private string string_4;

		// Token: 0x0400083D RID: 2109
		public ConcurrentDictionary<string, byte> concurrentDictionary_0;

		// Token: 0x0400083E RID: 2110
		public ConcurrentDictionary<string, Aircraft_AirOps.Enum43> concurrentDictionary_1;

		// Token: 0x0400083F RID: 2111
		public int int_0;

		// Token: 0x04000840 RID: 2112
		public bool bool_0;

		// Token: 0x04000841 RID: 2113
		public int int_1;

		// Token: 0x04000842 RID: 2114
		public int int_2;

		// Token: 0x04000843 RID: 2115
		public int int_3;

		// Token: 0x04000844 RID: 2116
		public float float_1;

		// Token: 0x04000845 RID: 2117
		public float float_2;

		// Token: 0x04000846 RID: 2118
		public float float_3;

		// Token: 0x04000847 RID: 2119
		public float float_4;

		// Token: 0x04000848 RID: 2120
		[CompilerGenerated]
		private static Aircraft_AirOps.Delegate23 delegate23_0;

		// Token: 0x04000849 RID: 2121
		[CompilerGenerated]
		private static Aircraft_AirOps.Delegate24 delegate24_0;

		// Token: 0x0400084A RID: 2122
		private Aircraft aircraft_2;

		// Token: 0x0400084B RID: 2123
		[CompilerGenerated]
		private static Aircraft_AirOps.Delegate25 delegate25_0;

		// Token: 0x0400084C RID: 2124
		[CompilerGenerated]
		private static Aircraft_AirOps.Delegate26 delegate26_0;

		// Token: 0x02000196 RID: 406
		// (Invoke) Token: 0x06000CA5 RID: 3237
		internal delegate void Delegate23(Aircraft theAircraft);

		// Token: 0x02000197 RID: 407
		// (Invoke) Token: 0x06000CA9 RID: 3241
		internal delegate void Delegate24(Aircraft theAircraft);

		// Token: 0x02000198 RID: 408
		// (Invoke) Token: 0x06000CAD RID: 3245
		internal delegate void Delegate25(string UnitObjectID);

		// Token: 0x02000199 RID: 409
		// (Invoke) Token: 0x06000CB1 RID: 3249
		internal delegate void Delegate26(ActiveUnit theUnit, object oldStatus);

		// Token: 0x0200019A RID: 410
		private enum Enum42 : byte
		{
			// Token: 0x0400084E RID: 2126
			const_0,
			// Token: 0x0400084F RID: 2127
			const_1,
			// Token: 0x04000850 RID: 2128
			const_2
		}

		// Token: 0x0200019B RID: 411
		public enum _AirOpsCondition : byte
		{
			// Token: 0x04000852 RID: 2130
			Airborne,
			// Token: 0x04000853 RID: 2131
			Parked,
			// Token: 0x04000854 RID: 2132
			TaxyingToTakeOff,
			// Token: 0x04000855 RID: 2133
			TaxyingToPark,
			// Token: 0x04000856 RID: 2134
			TakingOff,
			// Token: 0x04000857 RID: 2135
			Landing_PreTouchdown,
			// Token: 0x04000858 RID: 2136
			Landing_PostTouchdown,
			// Token: 0x04000859 RID: 2137
			Readying,
			// Token: 0x0400085A RID: 2138
			HoldingForAvailableTransit,
			// Token: 0x0400085B RID: 2139
			HoldingForAvailableRunway,
			// Token: 0x0400085C RID: 2140
			HoldingOnLandingQueue,
			// Token: 0x0400085D RID: 2141
			RTB,
			// Token: 0x0400085E RID: 2142
			PreparingToLaunch,
			// Token: 0x0400085F RID: 2143
			ManoeuveringToRefuel,
			// Token: 0x04000860 RID: 2144
			Refuelling,
			// Token: 0x04000861 RID: 2145
			OffloadingFuel,
			// Token: 0x04000862 RID: 2146
			DeployingDippingSonar,
			// Token: 0x04000863 RID: 2147
			EmergencyLanding,
			// Token: 0x04000864 RID: 2148
			TaxyingToFlightDeck,
			// Token: 0x04000865 RID: 2149
			BVRAttack,
			// Token: 0x04000866 RID: 2150
			BVRCrank,
			// Token: 0x04000867 RID: 2151
			Dogfight,
			// Token: 0x04000868 RID: 2152
			TransferringCargo,
			// Token: 0x04000869 RID: 2153
			BVRDrag
		}

		// Token: 0x0200019C RID: 412
		internal enum Enum43 : byte
		{
			// Token: 0x0400086B RID: 2155
			const_0,
			// Token: 0x0400086C RID: 2156
			const_1,
			// Token: 0x0400086D RID: 2157
			const_2
		}

		// Token: 0x0200019D RID: 413
		internal enum Enum44 : byte
		{
			// Token: 0x0400086F RID: 2159
			const_0,
			// Token: 0x04000870 RID: 2160
			const_1,
			// Token: 0x04000871 RID: 2161
			const_2,
			// Token: 0x04000872 RID: 2162
			const_3,
			// Token: 0x04000873 RID: 2163
			const_4
		}

		// Token: 0x0200019E RID: 414
		[CompilerGenerated]
		internal sealed class Class252
		{
			// Token: 0x06000CB2 RID: 3250 RVA: 0x00008C1B File Offset: 0x00006E1B
			public Class252(Aircraft_AirOps.Class252 class252_0)
			{
				if (class252_0 != null)
				{
					this.activeUnit_0 = class252_0.activeUnit_0;
				}
			}

			// Token: 0x06000CB3 RID: 3251 RVA: 0x00008C32 File Offset: 0x00006E32
			internal double method_0(ActiveUnit activeUnit_1)
			{
				return activeUnit_1.method_31(this.activeUnit_0);
			}

			// Token: 0x04000874 RID: 2164
			public ActiveUnit activeUnit_0;
		}

		// Token: 0x020001A0 RID: 416
		[CompilerGenerated]
		internal sealed class Class253
		{
			// Token: 0x06000CD3 RID: 3283 RVA: 0x00008CF0 File Offset: 0x00006EF0
			public Class253(Aircraft_AirOps.Class253 class253_0)
			{
				if (class253_0 != null)
				{
					this.aircraft_0 = class253_0.aircraft_0;
				}
			}

			// Token: 0x06000CD4 RID: 3284 RVA: 0x00008D07 File Offset: 0x00006F07
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.method_36(this.aircraft_0) < 2f & activeUnit_0 != this.aircraft_AirOps_0.method_20();
			}

			// Token: 0x04000893 RID: 2195
			public Aircraft aircraft_0;

			// Token: 0x04000894 RID: 2196
			public Aircraft_AirOps aircraft_AirOps_0;

			// Token: 0x04000895 RID: 2197
			public Func<ActiveUnit, bool> func_0;
		}

		// Token: 0x020001A1 RID: 417
		[CompilerGenerated]
		internal sealed class Class254
		{
			// Token: 0x06000CD5 RID: 3285 RVA: 0x00008D2E File Offset: 0x00006F2E
			public Class254(Aircraft_AirOps.Class254 class254_0)
			{
				if (class254_0 != null)
				{
					this.double_0 = class254_0.double_0;
				}
			}

			// Token: 0x06000CD6 RID: 3286 RVA: 0x00008D45 File Offset: 0x00006F45
			internal bool method_0(Aircraft aircraft_0)
			{
				return this.class255_0.aircraft_AirOps_0.method_20().method_31(aircraft_0) < this.double_0 && aircraft_0.method_28(this.class255_0.geoPoint_0) < this.double_0;
			}

			// Token: 0x04000896 RID: 2198
			public double double_0;

			// Token: 0x04000897 RID: 2199
			public Aircraft_AirOps.Class255 class255_0;
		}

		// Token: 0x020001A2 RID: 418
		[CompilerGenerated]
		internal sealed class Class255
		{
			// Token: 0x06000CD7 RID: 3287 RVA: 0x00008D80 File Offset: 0x00006F80
			public Class255(Aircraft_AirOps.Class255 class255_0)
			{
				if (class255_0 != null)
				{
					this.geoPoint_0 = class255_0.geoPoint_0;
				}
			}

			// Token: 0x04000898 RID: 2200
			public GeoPoint geoPoint_0;

			// Token: 0x04000899 RID: 2201
			public Aircraft_AirOps aircraft_AirOps_0;
		}

		// Token: 0x020001A3 RID: 419
		[CompilerGenerated]
		internal sealed class Class256
		{
			// Token: 0x06000CD8 RID: 3288 RVA: 0x00008D97 File Offset: 0x00006F97
			public Class256(Aircraft_AirOps.Class256 class256_0)
			{
				if (class256_0 != null)
				{
					this.double_0 = class256_0.double_0;
				}
			}

			// Token: 0x06000CD9 RID: 3289 RVA: 0x00008DAE File Offset: 0x00006FAE
			internal bool method_0(Aircraft aircraft_0)
			{
				return this.class257_0.class255_0.aircraft_AirOps_0.method_20().method_31(aircraft_0) < this.double_0 && aircraft_0.method_31(this.class257_0.activeUnit_0) < this.double_0;
			}

			// Token: 0x0400089A RID: 2202
			public double double_0;

			// Token: 0x0400089B RID: 2203
			public Aircraft_AirOps.Class257 class257_0;
		}

		// Token: 0x020001A4 RID: 420
		[CompilerGenerated]
		internal sealed class Class257
		{
			// Token: 0x06000CDA RID: 3290 RVA: 0x00008DEE File Offset: 0x00006FEE
			public Class257(Aircraft_AirOps.Class257 class257_0)
			{
				if (class257_0 != null)
				{
					this.activeUnit_0 = class257_0.activeUnit_0;
				}
			}

			// Token: 0x0400089C RID: 2204
			public ActiveUnit activeUnit_0;

			// Token: 0x0400089D RID: 2205
			public Aircraft_AirOps.Class255 class255_0;
		}
	}
}
