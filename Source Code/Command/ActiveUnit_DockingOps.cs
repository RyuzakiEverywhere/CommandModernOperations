using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
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
	// Token: 0x02000147 RID: 327
	public sealed class ActiveUnit_DockingOps
	{
		// Token: 0x060008F9 RID: 2297 RVA: 0x000079C5 File Offset: 0x00005BC5
		[CompilerGenerated]
		public List<string> vmethod_0()
		{
			return this.list_0;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x000079CD File Offset: 0x00005BCD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_1(List<string> list_1)
		{
			this.list_0 = list_1;
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00097AC0 File Offset: 0x00095CC0
		[CompilerGenerated]
		public static void smethod_0(ActiveUnit_DockingOps.Delegate17 delegate17_1)
		{
			ActiveUnit_DockingOps.Delegate17 @delegate = ActiveUnit_DockingOps.delegate17_0;
			ActiveUnit_DockingOps.Delegate17 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_DockingOps.Delegate17 value = (ActiveUnit_DockingOps.Delegate17)Delegate.Combine(delegate2, delegate17_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_DockingOps.Delegate17>(ref ActiveUnit_DockingOps.delegate17_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00097AF4 File Offset: 0x00095CF4
		[CompilerGenerated]
		public static void smethod_1(ActiveUnit_DockingOps.Delegate17 delegate17_1)
		{
			ActiveUnit_DockingOps.Delegate17 @delegate = ActiveUnit_DockingOps.delegate17_0;
			ActiveUnit_DockingOps.Delegate17 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_DockingOps.Delegate17 value = (ActiveUnit_DockingOps.Delegate17)Delegate.Remove(delegate2, delegate17_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_DockingOps.Delegate17>(ref ActiveUnit_DockingOps.delegate17_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00097B28 File Offset: 0x00095D28
		[CompilerGenerated]
		public static void smethod_2(ActiveUnit_DockingOps.Delegate18 delegate18_1)
		{
			ActiveUnit_DockingOps.Delegate18 @delegate = ActiveUnit_DockingOps.delegate18_0;
			ActiveUnit_DockingOps.Delegate18 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_DockingOps.Delegate18 value = (ActiveUnit_DockingOps.Delegate18)Delegate.Combine(delegate2, delegate18_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_DockingOps.Delegate18>(ref ActiveUnit_DockingOps.delegate18_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00097B5C File Offset: 0x00095D5C
		[CompilerGenerated]
		public static void smethod_3(ActiveUnit_DockingOps.Delegate18 delegate18_1)
		{
			ActiveUnit_DockingOps.Delegate18 @delegate = ActiveUnit_DockingOps.delegate18_0;
			ActiveUnit_DockingOps.Delegate18 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_DockingOps.Delegate18 value = (ActiveUnit_DockingOps.Delegate18)Delegate.Remove(delegate2, delegate18_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_DockingOps.Delegate18>(ref ActiveUnit_DockingOps.delegate18_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00097B90 File Offset: 0x00095D90
		[CompilerGenerated]
		public static void smethod_4(ActiveUnit_DockingOps.Delegate19 delegate19_1)
		{
			ActiveUnit_DockingOps.Delegate19 @delegate = ActiveUnit_DockingOps.delegate19_0;
			ActiveUnit_DockingOps.Delegate19 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_DockingOps.Delegate19 value = (ActiveUnit_DockingOps.Delegate19)Delegate.Combine(delegate2, delegate19_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_DockingOps.Delegate19>(ref ActiveUnit_DockingOps.delegate19_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00097BC4 File Offset: 0x00095DC4
		[CompilerGenerated]
		public static void smethod_5(ActiveUnit_DockingOps.Delegate19 delegate19_1)
		{
			ActiveUnit_DockingOps.Delegate19 @delegate = ActiveUnit_DockingOps.delegate19_0;
			ActiveUnit_DockingOps.Delegate19 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_DockingOps.Delegate19 value = (ActiveUnit_DockingOps.Delegate19)Delegate.Remove(delegate2, delegate19_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_DockingOps.Delegate19>(ref ActiveUnit_DockingOps.delegate19_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00097BF8 File Offset: 0x00095DF8
		public static void smethod_6(ActiveUnit_DockingOps activeUnit_DockingOps_0, ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("ActiveUnit_DockingOps");
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "Con";
				int num = (int)activeUnit_DockingOps_0._DockingOpsCondition_0;
				xmlWriter.WriteElementString(localName, num.ToString());
				xmlWriter_0.WriteElementString("CT", XmlConvert.ToString(activeUnit_DockingOps_0.method_0()));
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "CBRB";
				num = (int)activeUnit_DockingOps_0._DockingOpsCondition_2;
				xmlWriter2.WriteElementString(localName2, num.ToString());
				xmlWriter_0.WriteElementString("CBRB_Depth", XmlConvert.ToString(activeUnit_DockingOps_0.float_1));
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = "CBRB_ThrottleSetting";
				byte b = (byte)activeUnit_DockingOps_0.throttle_0;
				xmlWriter3.WriteElementString(localName3, b.ToString());
				if (activeUnit_DockingOps_0.dockFacility_0 != null)
				{
					xmlWriter_0.WriteElementString("HDF", activeUnit_DockingOps_0.method_15().string_0);
				}
				if (activeUnit_DockingOps_0.method_17() != null)
				{
					xmlWriter_0.WriteElementString("CHU", activeUnit_DockingOps_0.method_17().string_0);
				}
				if (activeUnit_DockingOps_0.activeUnit_1 != null)
				{
					xmlWriter_0.WriteElementString("AHU", activeUnit_DockingOps_0.activeUnit_1.string_0);
				}
				if (activeUnit_DockingOps_0.method_6() != null)
				{
					xmlWriter_0.WriteElementString("UNREP_D", activeUnit_DockingOps_0.method_6().string_0);
				}
				if (!string.IsNullOrEmpty(activeUnit_DockingOps_0.string_4))
				{
					xmlWriter_0.WriteElementString("UNREP_P", activeUnit_DockingOps_0.string_4);
				}
				if (!string.IsNullOrEmpty(activeUnit_DockingOps_0.string_5))
				{
					xmlWriter_0.WriteElementString("UNREP_S", activeUnit_DockingOps_0.string_5);
				}
				if (!string.IsNullOrEmpty(activeUnit_DockingOps_0.string_6))
				{
					xmlWriter_0.WriteElementString("UNREP_A", activeUnit_DockingOps_0.string_6);
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100129", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00097DC4 File Offset: 0x00095FC4
		public static ActiveUnit_DockingOps smethod_7(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref ActiveUnit activeUnit_3)
		{
			ActiveUnit_DockingOps result;
			try
			{
				ActiveUnit_DockingOps activeUnit_DockingOps = new ActiveUnit_DockingOps(ref activeUnit_3);
				activeUnit_DockingOps.activeUnit_0 = activeUnit_3;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 1281343745U)
						{
							if (num <= 474553294U)
							{
								if (num != 256444247U)
								{
									if (num != 273221866U)
									{
										if (num == 474553294U)
										{
											if (Operators.CompareString(name, "UNREP_D", false) == 0)
											{
												activeUnit_DockingOps.string_3 = xmlNode.InnerText;
											}
										}
									}
									else if (Operators.CompareString(name, "UNREP_P", false) == 0 && !string.IsNullOrEmpty(xmlNode.InnerText) && Operators.CompareString(activeUnit_DockingOps.string_5, xmlNode.InnerText, false) != 0 && Operators.CompareString(activeUnit_DockingOps.string_6, xmlNode.InnerText, false) != 0)
									{
										activeUnit_DockingOps.string_4 = xmlNode.InnerText;
									}
								}
								else if (Operators.CompareString(name, "UNREP_S", false) == 0 && !string.IsNullOrEmpty(xmlNode.InnerText) && Operators.CompareString(activeUnit_DockingOps.string_4, xmlNode.InnerText, false) != 0 && Operators.CompareString(activeUnit_DockingOps.string_6, xmlNode.InnerText, false) != 0)
								{
									activeUnit_DockingOps.string_5 = xmlNode.InnerText;
								}
							}
							else if (num != 558441389U)
							{
								if (num != 898687005U)
								{
									if (num == 1281343745U)
									{
										if (Operators.CompareString(name, "CHU", false) == 0)
										{
											activeUnit_DockingOps.string_2 = xmlNode.InnerText;
										}
									}
								}
								else if (Operators.CompareString(name, "HDF", false) == 0)
								{
									activeUnit_DockingOps.string_0 = xmlNode.InnerText;
								}
							}
							else if (Operators.CompareString(name, "UNREP_A", false) == 0 && !string.IsNullOrEmpty(xmlNode.InnerText) && Operators.CompareString(activeUnit_DockingOps.string_4, xmlNode.InnerText, false) != 0 && Operators.CompareString(activeUnit_DockingOps.string_5, xmlNode.InnerText, false) != 0)
							{
								activeUnit_DockingOps.string_6 = xmlNode.InnerText;
							}
						}
						else
						{
							if (num <= 1792671826U)
							{
								if (num != 1394108651U)
								{
									if (num != 1593765902U)
									{
										if (num != 1792671826U)
										{
											continue;
										}
										if (Operators.CompareString(name, "CT", false) == 0)
										{
											activeUnit_DockingOps.method_1(XmlConvert.ToSingle(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "CBRB_Depth", false) == 0)
										{
											activeUnit_DockingOps.float_1 = XmlConvert.ToSingle(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (Operators.CompareString(name, "Con", false) != 0)
								{
									continue;
								}
							}
							else if (num <= 2112830247U)
							{
								if (num != 1852486619U)
								{
									if (num != 2112830247U)
									{
										continue;
									}
									if (Operators.CompareString(name, "CBRB_ThrottleSetting", false) != 0)
									{
										continue;
									}
									string innerText = xmlNode.InnerText;
									if (Operators.CompareString(innerText, "FullStop", false) == 0)
									{
										activeUnit_DockingOps.throttle_0 = ActiveUnit.Throttle.FullStop;
										continue;
									}
									if (Operators.CompareString(innerText, "Loiter", false) == 0)
									{
										activeUnit_DockingOps.throttle_0 = ActiveUnit.Throttle.Loiter;
										continue;
									}
									if (Operators.CompareString(innerText, "Cruise", false) == 0)
									{
										activeUnit_DockingOps.throttle_0 = ActiveUnit.Throttle.Cruise;
										continue;
									}
									if (Operators.CompareString(innerText, "Full", false) == 0)
									{
										activeUnit_DockingOps.throttle_0 = ActiveUnit.Throttle.Full;
										continue;
									}
									if (Operators.CompareString(innerText, "Flank", false) != 0)
									{
										activeUnit_DockingOps.throttle_0 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									activeUnit_DockingOps.throttle_0 = ActiveUnit.Throttle.Flank;
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "AHU", false) == 0)
									{
										activeUnit_DockingOps.string_1 = xmlNode.InnerText;
										continue;
									}
									continue;
								}
							}
							else if (num != 2209593132U)
							{
								if (num != 3433242718U || Operators.CompareString(name, "Condition", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "CBRB", false) == 0)
								{
									activeUnit_DockingOps._DockingOpsCondition_2 = (ActiveUnit_DockingOps._DockingOpsCondition)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							if (Versioned.IsNumeric(xmlNode.InnerText))
							{
								activeUnit_DockingOps.method_9((ActiveUnit_DockingOps._DockingOpsCondition)Conversions.ToByte(xmlNode.InnerText));
							}
							else
							{
								activeUnit_DockingOps.method_9((ActiveUnit_DockingOps._DockingOpsCondition)Enum.Parse(typeof(ActiveUnit_DockingOps._DockingOpsCondition), xmlNode.InnerText, true));
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
				result = activeUnit_DockingOps;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100130", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ActiveUnit_DockingOps(ref activeUnit_3);
			}
			return result;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x000982AC File Offset: 0x000964AC
		public static void smethod_8(ActiveUnit_DockingOps activeUnit_DockingOps_0, ref Scenario scenario_0, Dictionary<string, Class310> dictionary_0, bool bool_0)
		{
			checked
			{
				try
				{
					if (activeUnit_DockingOps_0.method_15() == null && !string.IsNullOrEmpty(activeUnit_DockingOps_0.string_0))
					{
						if (dictionary_0.ContainsKey(activeUnit_DockingOps_0.string_0))
						{
							activeUnit_DockingOps_0.method_16((DockFacility)dictionary_0[activeUnit_DockingOps_0.string_0]);
						}
						else
						{
							bool flag = false;
							try
							{
								List<ActiveUnit>.Enumerator enumerator = scenario_0.method_42().GetEnumerator();
								IL_A0:
								while (enumerator.MoveNext())
								{
									ActiveUnit activeUnit = enumerator.Current;
									if (activeUnit != null)
									{
										DockFacility[] array = activeUnit.vmethod_100();
										int i = 0;
										while (i < array.Length)
										{
											DockFacility dockFacility = array[i];
											if (string.CompareOrdinal(dockFacility.string_0, activeUnit_DockingOps_0.string_0) != 0)
											{
												i++;
											}
											else
											{
												activeUnit_DockingOps_0.method_16(dockFacility);
												flag = true;
												IL_9D:
												if (!flag)
												{
													goto IL_A0;
												}
												goto IL_A9;
											}
										}
										goto IL_9D;
									}
								}
								IL_A9:;
							}
							finally
							{
								List<ActiveUnit>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
					}
					if (activeUnit_DockingOps_0.method_17() != null && activeUnit_DockingOps_0.method_15() != null && !Enumerable.Contains<DockFacility>(activeUnit_DockingOps_0.method_17().vmethod_100(), activeUnit_DockingOps_0.method_15()))
					{
						activeUnit_DockingOps_0.method_17().vmethod_93().method_42(activeUnit_DockingOps_0.activeUnit_0);
					}
					if (activeUnit_DockingOps_0.activeUnit_1 == null && activeUnit_DockingOps_0.string_1 != null)
					{
						try
						{
							ActiveUnit activeUnit2 = scenario_0.vmethod_0()[activeUnit_DockingOps_0.string_1];
							if (activeUnit2 != null)
							{
								if (!activeUnit_DockingOps_0.activeUnit_0.vmethod_127())
								{
									if (activeUnit_DockingOps_0.method_17() != null && Operators.CompareString(activeUnit_DockingOps_0.method_17().string_0, activeUnit2.string_0, false) != 0)
									{
										if (activeUnit_DockingOps_0.activeUnit_0.bool_5 && ((Submarine)activeUnit_DockingOps_0.activeUnit_0).method_159())
										{
											activeUnit_DockingOps_0.method_17().vmethod_93().method_42(activeUnit_DockingOps_0.activeUnit_0);
										}
										else
										{
											activeUnit_DockingOps_0.activeUnit_0.vmethod_93().method_12(false, activeUnit2);
										}
									}
									else
									{
										activeUnit2.vmethod_93().method_42(activeUnit_DockingOps_0.activeUnit_0);
									}
								}
								else
								{
									activeUnit_DockingOps_0.activeUnit_0.vmethod_93().method_12(false, activeUnit2);
								}
							}
							else if (!activeUnit_DockingOps_0.activeUnit_0.vmethod_127())
							{
								activeUnit_DockingOps_0.activeUnit_0.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
							}
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 200007", ex.Message);
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
					}
					if (activeUnit_DockingOps_0.method_17() == null && !activeUnit_DockingOps_0.activeUnit_0.vmethod_127() && activeUnit_DockingOps_0.method_11(false) != null)
					{
						activeUnit_DockingOps_0.method_11(false).vmethod_93().method_42(activeUnit_DockingOps_0.activeUnit_0);
					}
					if (!string.IsNullOrEmpty(activeUnit_DockingOps_0.string_3))
					{
						activeUnit_DockingOps_0.activeUnit_2 = scenario_0.vmethod_0()[activeUnit_DockingOps_0.string_3];
					}
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 100131", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000985C4 File Offset: 0x000967C4
		public static IEnumerable<ActiveUnit> smethod_9(ActiveUnit_DockingOps activeUnit_DockingOps_0)
		{
			IEnumerable<ActiveUnit> result;
			try
			{
				result = Enumerable.Where<ActiveUnit>(activeUnit_DockingOps_0.method_14(), (ActiveUnit_DockingOps._Closure$__.$I45-0 == null) ? (ActiveUnit_DockingOps._Closure$__.$I45-0 = new Func<ActiveUnit, bool>(ActiveUnit_DockingOps._Closure$__.$I.method_0)) : ActiveUnit_DockingOps._Closure$__.$I45-0);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100132", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<ActiveUnit>();
			}
			return result;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000079D6 File Offset: 0x00005BD6
		public float method_0()
		{
			return this.float_0;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x000079DE File Offset: 0x00005BDE
		public void method_1(float float_3)
		{
			this.float_0 = float_3;
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00098650 File Offset: 0x00096850
		public ActiveUnit method_2()
		{
			ActiveUnit result;
			try
			{
				Mission mission = this.activeUnit_0.vmethod_101();
				ActiveUnit activeUnit;
				if (Information.IsNothing(mission))
				{
					activeUnit = this.method_11(false);
				}
				else if (mission._MissionClass_0 != Mission._MissionClass.Ferry)
				{
					activeUnit = this.method_11(false);
				}
				else
				{
					if (Information.IsNothing(((FerryMission)mission).method_67(this.activeUnit_0.scenario_0)))
					{
						this.activeUnit_0.method_124(string.Concat(new string[]
						{
							this.activeUnit_0.Name,
							" (",
							this.activeUnit_0.string_2,
							") is no longer able to execute ferry mission: ",
							mission.Name,
							" (the ferry destination appears to be missing). The unit will be removed from the mission."
						}), this.activeUnit_0.Name + " unable to ferry; removed from mission", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						ActiveUnit activeUnit2 = this.activeUnit_0;
						Mission value = null;
						bool setMissionOnly = false;
						Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
						activeUnit2.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
						activeUnit = this.method_11(false);
					}
					switch (((FerryMission)mission).method_65())
					{
					case FerryMission.FerryMissionBehavior.OneWay:
						activeUnit = ((FerryMission)mission).method_67(this.activeUnit_0.scenario_0);
						break;
					case FerryMission.FerryMissionBehavior.Cycle:
						if (this.activeUnit_0.vmethod_86().method_43())
						{
							activeUnit = ((FerryMission)mission).method_67(this.activeUnit_0.scenario_0);
						}
						else
						{
							activeUnit = this.method_11(false);
						}
						break;
					case FerryMission.FerryMissionBehavior.Random:
						activeUnit = this.method_11(false);
						break;
					default:
						activeUnit = this.method_11(false);
						break;
					}
				}
				if (!Information.IsNothing(activeUnit) && activeUnit.method_120() && activeUnit.vmethod_65(false).method_140())
				{
					activeUnit = activeUnit.vmethod_65(false);
				}
				result = activeUnit;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100133", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000079E7 File Offset: 0x00005BE7
		public void method_3()
		{
			this.geopoint_Struct_0 = null;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0009886C File Offset: 0x00096A6C
		public Geopoint_Struct[] method_4()
		{
			Geopoint_Struct[] result;
			try
			{
				if (!ActiveUnit_DockingOps.smethod_10(this.activeUnit_0))
				{
					result = null;
				}
				else
				{
					if (Information.IsNothing(this.geopoint_Struct_0))
					{
						Geopoint_Struct[] array = new Geopoint_Struct[10];
						float num = Math2.smethod_7(this.activeUnit_0.vmethod_9() - 60f);
						float num2 = Math2.smethod_7(this.activeUnit_0.vmethod_9() + 60f);
						float num3 = this.activeUnit_0.vmethod_9();
						Geopoint_Struct geopoint_Struct = default(Geopoint_Struct);
						Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref geopoint_Struct.double_0, ref geopoint_Struct.double_1, 2.0, (double)Math2.smethod_7(num3 + 180f));
						array[0] = geopoint_Struct;
						geopoint_Struct = default(Geopoint_Struct);
						Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref geopoint_Struct.double_0, ref geopoint_Struct.double_1, 7.0, (double)num);
						array[1] = geopoint_Struct;
						geopoint_Struct = default(Geopoint_Struct);
						Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref geopoint_Struct.double_0, ref geopoint_Struct.double_1, 7.0, (double)Math2.smethod_7(num + 15f));
						array[2] = geopoint_Struct;
						geopoint_Struct = default(Geopoint_Struct);
						Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref geopoint_Struct.double_0, ref geopoint_Struct.double_1, 7.0, (double)Math2.smethod_7(num + 30f));
						array[3] = geopoint_Struct;
						geopoint_Struct = default(Geopoint_Struct);
						Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref geopoint_Struct.double_0, ref geopoint_Struct.double_1, 7.0, (double)Math2.smethod_7(num + 45f));
						array[4] = geopoint_Struct;
						geopoint_Struct = default(Geopoint_Struct);
						Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref geopoint_Struct.double_0, ref geopoint_Struct.double_1, 7.0, (double)num3);
						array[5] = geopoint_Struct;
						geopoint_Struct = default(Geopoint_Struct);
						Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref geopoint_Struct.double_0, ref geopoint_Struct.double_1, 7.0, (double)Math2.smethod_7(num3 + 15f));
						array[6] = geopoint_Struct;
						geopoint_Struct = default(Geopoint_Struct);
						Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref geopoint_Struct.double_0, ref geopoint_Struct.double_1, 7.0, (double)Math2.smethod_7(num3 + 30f));
						array[7] = geopoint_Struct;
						geopoint_Struct = default(Geopoint_Struct);
						Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref geopoint_Struct.double_0, ref geopoint_Struct.double_1, 7.0, (double)Math2.smethod_7(num3 + 45f));
						array[8] = geopoint_Struct;
						geopoint_Struct = default(Geopoint_Struct);
						Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref geopoint_Struct.double_0, ref geopoint_Struct.double_1, 7.0, (double)num2);
						array[9] = geopoint_Struct;
						this.geopoint_Struct_0 = array;
					}
					result = this.geopoint_Struct_0;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101363", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00098D1C File Offset: 0x00096F1C
		public static bool smethod_10(ActiveUnit activeUnit_3)
		{
			DockFacility[] array = activeUnit_3.vmethod_100();
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].enum49_0 == DockFacility.Enum49.const_5)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00098D58 File Offset: 0x00096F58
		public bool method_5(bool bool_0, ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_0, bool bool_1, ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_1, bool bool_2, bool bool_3)
		{
			bool result;
			try
			{
				if (!Information.IsNothing(this.method_2()))
				{
					if (!Information.IsNothing(_ActiveUnitStatus_0))
					{
						this.activeUnit_0.vmethod_109(_ActiveUnitStatus_0);
					}
					this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.RTB);
					this.activeUnit_0.vmethod_85().vmethod_9();
					this.activeUnit_0.vmethod_87().vmethod_11(null);
					this.activeUnit_0.vmethod_87().vmethod_13(false);
					if (bool_1 && this.activeUnit_0.vmethod_65(false) != null)
					{
						try
						{
							foreach (ActiveUnit activeUnit in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
							{
								if (activeUnit != this.activeUnit_0)
								{
									activeUnit.vmethod_109(_ActiveUnitStatus_1);
									activeUnit.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.RTB);
									activeUnit.vmethod_85().vmethod_9();
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
					result = true;
				}
				else
				{
					this.method_44();
					if (!Information.IsNothing(this.method_11(false)))
					{
						if (!Information.IsNothing(_ActiveUnitStatus_0))
						{
							this.activeUnit_0.vmethod_109(_ActiveUnitStatus_0);
						}
						this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.RTB);
						this.activeUnit_0.vmethod_85().vmethod_9();
						this.activeUnit_0.vmethod_87().vmethod_11(null);
						this.activeUnit_0.vmethod_87().vmethod_13(false);
						if (bool_1 && this.activeUnit_0.vmethod_65(false) != null)
						{
							try
							{
								foreach (ActiveUnit activeUnit2 in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
								{
									if (activeUnit2 != this.activeUnit_0)
									{
										activeUnit2.vmethod_109(_ActiveUnitStatus_1);
										activeUnit2.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.RTB);
										activeUnit2.vmethod_85().vmethod_9();
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
						result = true;
					}
					else
					{
						if (bool_0)
						{
							this.activeUnit_0.scenario_0.method_59(this.activeUnit_0.Name + " has no suitable place to dock!", this.activeUnit_0.Name + " cannot dock", LoggedMessage.MessageType.DockingOps, 15, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						}
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100134", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x000079F0 File Offset: 0x00005BF0
		public ActiveUnit method_6()
		{
			return this.activeUnit_2;
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x000990A0 File Offset: 0x000972A0
		public void method_7(ActiveUnit activeUnit_3)
		{
			try
			{
				if (activeUnit_3 != this.activeUnit_2 && !Information.IsNothing(this.activeUnit_2) && !Information.IsNothing(this.activeUnit_2.vmethod_93()))
				{
					this.activeUnit_2.vmethod_93().vmethod_0().Remove(this.activeUnit_0.string_0);
				}
				this.activeUnit_2 = activeUnit_3;
				if (activeUnit_3 != null)
				{
					List<string> list = this.activeUnit_2.vmethod_93().vmethod_0();
					if (!list.Contains(this.activeUnit_0.string_0))
					{
						list.Add(this.activeUnit_0.string_0);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100135", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x000079F8 File Offset: 0x00005BF8
		public ActiveUnit_DockingOps._DockingOpsCondition method_8()
		{
			return this._DockingOpsCondition_0;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00099184 File Offset: 0x00097384
		public void method_9(ActiveUnit_DockingOps._DockingOpsCondition _DockingOpsCondition_3)
		{
			try
			{
				bool flag = this._DockingOpsCondition_0 != _DockingOpsCondition_3;
				this._DockingOpsCondition_1 = this._DockingOpsCondition_0;
				this._DockingOpsCondition_0 = _DockingOpsCondition_3;
				if (flag)
				{
					if (_DockingOpsCondition_3 == ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway)
					{
						this.method_1(this.method_0() + (float)((double)this.method_19() * 0.6666666666666666));
					}
					else if (_DockingOpsCondition_3 == ActiveUnit_DockingOps._DockingOpsCondition.Docking)
					{
						this.method_1((float)this.method_19());
						ActiveUnit_DockingOps.Delegate18 @delegate = ActiveUnit_DockingOps.delegate18_0;
						if (@delegate != null)
						{
							@delegate(this.activeUnit_0);
						}
					}
					else if (_DockingOpsCondition_3 == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
					{
						this.float_1 = this.activeUnit_0.vmethod_72();
						this.throttle_0 = this.activeUnit_0.vmethod_84();
					}
					else if (this._DockingOpsCondition_1 == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
					{
						if (this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.EngagedDefensive && this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.EngagedOffensive && this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.Refuelling)
						{
							this.activeUnit_0.vmethod_73(this.float_1);
							this.activeUnit_0.vmethod_134(this.throttle_0, null);
							if (this.activeUnit_0.vmethod_85().vmethod_3())
							{
								this.activeUnit_0.vmethod_85().method_0(false);
							}
						}
					}
					else if (_DockingOpsCondition_3 == ActiveUnit_DockingOps._DockingOpsCondition.Underway)
					{
						ActiveUnit_DockingOps.Delegate17 delegate2 = ActiveUnit_DockingOps.delegate17_0;
						if (delegate2 != null)
						{
							delegate2(this.activeUnit_0);
						}
					}
					ActiveUnit_DockingOps.Delegate20 delegate3 = ActiveUnit_DockingOps.delegate20_0;
					if (delegate3 != null)
					{
						delegate3(this.activeUnit_0, this._DockingOpsCondition_1);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100136", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00099364 File Offset: 0x00097564
		public string method_10()
		{
			string result;
			switch (this.method_8())
			{
			case ActiveUnit_DockingOps._DockingOpsCondition.Underway:
				result = "Underway";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.Docked:
				result = "Docked";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway:
				result = "Deployment Underway";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.Docking:
				result = "Docking";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.RTB:
				result = "Returning to base";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.Readying:
				result = "Readying";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.ManoeuveringToRefuel:
				result = "Manoeuvering To Refuel";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.Replenishing:
				result = "Replenishing";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.ProvidingUNREP:
				result = "Providing UNREP";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries:
				result = "Recharging Batteries";
				break;
			default:
				result = this.method_8().ToString();
				break;
			}
			return result;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0009940C File Offset: 0x0009760C
		public ActiveUnit method_11(bool PickNewAssignedHost = false)
		{
			ActiveUnit result;
			try
			{
				if (PickNewAssignedHost && (Information.IsNothing(this.activeUnit_1) || this.activeUnit_1.method_82()))
				{
					this.method_44();
				}
				result = this.activeUnit_1;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100137", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00099490 File Offset: 0x00097690
		public void method_12(bool PickNewAssignedHost = false, ActiveUnit value)
		{
			try
			{
				bool flag = value != this.activeUnit_1;
				this.activeUnit_1 = value;
				if (flag && this.activeUnit_0.bool_5 && ((Submarine)this.activeUnit_0).method_159() && value != null)
				{
					ActiveUnit activeUnit = this.activeUnit_0;
					Mission value2 = value.vmethod_101();
					bool setMissionOnly = false;
					Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
					activeUnit.vmethod_102(value2, setMissionOnly, ref missionAssignmentAttemptResult);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100138", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00099534 File Offset: 0x00097734
		public ReadOnlyCollection<ActiveUnit> method_13()
		{
			ReadOnlyCollection<ActiveUnit> result;
			try
			{
				List<ActiveUnit> list = new List<ActiveUnit>();
				try
				{
					foreach (ActiveUnit activeUnit in this.activeUnit_0.scenario_0.method_42())
					{
						if (!Information.IsNothing(activeUnit))
						{
							if (activeUnit.bool_6)
							{
								if (((Ship)activeUnit).vmethod_93().method_11(false) == this.activeUnit_0)
								{
									list.Add(activeUnit);
								}
							}
							else if (activeUnit.bool_5 && ((Submarine)activeUnit).vmethod_93().method_11(false) == this.activeUnit_0)
							{
								list.Add(activeUnit);
							}
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = list.AsReadOnly();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100139b", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<ActiveUnit>().AsReadOnly();
			}
			return result;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00099644 File Offset: 0x00097844
		public ReadOnlyCollection<ActiveUnit> method_14()
		{
			ReadOnlyCollection<ActiveUnit> result;
			try
			{
				List<ActiveUnit> list = new List<ActiveUnit>();
				foreach (DockFacility dockFacility in this.activeUnit_0.vmethod_100())
				{
					try
					{
						foreach (ActiveUnit item in dockFacility.lazy_0.Value.Values)
						{
							list.Add(item);
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
				result = list.AsReadOnly();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100139", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<ActiveUnit>().AsReadOnly();
			}
			return result;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00007A00 File Offset: 0x00005C00
		public DockFacility method_15()
		{
			return this.dockFacility_0;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00099724 File Offset: 0x00097924
		public void method_16(DockFacility dockFacility_1)
		{
			try
			{
				bool flag = dockFacility_1 != this.dockFacility_0;
				if (!Information.IsNothing(this.dockFacility_0))
				{
					this.dockFacility_0.lazy_0.Value.TryRemove(this.activeUnit_0.string_0, ref this.activeUnit_0);
				}
				if (!Information.IsNothing(dockFacility_1) && !dockFacility_1.lazy_0.Value.ContainsKey(this.activeUnit_0.string_0))
				{
					dockFacility_1.lazy_0.Value.TryAdd(this.activeUnit_0.string_0, this.activeUnit_0);
				}
				this.dockFacility_0 = dockFacility_1;
				if (flag)
				{
					ActiveUnit_DockingOps.Delegate19 @delegate = ActiveUnit_DockingOps.delegate19_0;
					if (@delegate != null)
					{
						@delegate(this.activeUnit_0.string_0);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100140", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00099824 File Offset: 0x00097A24
		public ActiveUnit method_17()
		{
			ActiveUnit result;
			try
			{
				DockFacility dockFacility = this.method_15();
				if (dockFacility == null)
				{
					result = null;
				}
				else if (dockFacility.method_18() == null)
				{
					result = null;
				}
				else
				{
					ActiveUnit activeUnit = dockFacility.method_18();
					if (activeUnit.method_120() && activeUnit.vmethod_65(false).method_143() == Group.GroupType.Installation)
					{
						result = activeUnit.vmethod_65(false);
					}
					else
					{
						result = activeUnit;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100141", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x000998C0 File Offset: 0x00097AC0
		public bool method_18()
		{
			if (this.activeUnit_0.bool_8)
			{
				List<ActiveUnit> list = this.activeUnit_0.scenario_0.method_42();
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						ActiveUnit activeUnit = list[i];
						if (activeUnit.vmethod_93().method_6() == this.activeUnit_0 && activeUnit.vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling)
						{
							return true;
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
			}
			else
			{
				if (!string.IsNullOrEmpty(this.string_4))
				{
					return true;
				}
				if (!string.IsNullOrEmpty(this.string_5))
				{
					return true;
				}
				if (!string.IsNullOrEmpty(this.string_6))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00007A08 File Offset: 0x00005C08
		public ActiveUnit_DockingOps(ref ActiveUnit activeUnit_3)
		{
			this.vmethod_1(new List<string>());
			this.float_2 = 0.3f;
			this.activeUnit_0 = activeUnit_3;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00099998 File Offset: 0x00097B98
		public short method_19()
		{
			short result;
			try
			{
				DockFacility.Enum50 enum50_;
				if (this.activeUnit_0.bool_6)
				{
					enum50_ = ((Ship)this.activeUnit_0).enum50_0;
				}
				if (this.activeUnit_0.bool_5)
				{
					enum50_ = ((Submarine)this.activeUnit_0).enum50_0;
				}
				if (enum50_ <= DockFacility.Enum50.const_6)
				{
					if (enum50_ == DockFacility.Enum50.const_0)
					{
						return 360;
					}
					switch (enum50_)
					{
					case DockFacility.Enum50.const_1:
						goto IL_D1;
					case DockFacility.Enum50.const_2:
						goto IL_D6;
					case DockFacility.Enum50.const_3:
						goto IL_DE;
					case DockFacility.Enum50.const_4:
						goto IL_E6;
					case DockFacility.Enum50.const_5:
						return 900;
					case DockFacility.Enum50.const_6:
						return 1200;
					}
				}
				else
				{
					switch (enum50_)
					{
					case DockFacility.Enum50.const_7:
						goto IL_D1;
					case DockFacility.Enum50.const_8:
						goto IL_D6;
					case DockFacility.Enum50.const_9:
						goto IL_DE;
					case DockFacility.Enum50.const_10:
						goto IL_E6;
					default:
						if (enum50_ == DockFacility.Enum50.const_11)
						{
							goto IL_D6;
						}
						if (enum50_ == DockFacility.Enum50.const_12)
						{
							goto IL_D1;
						}
						break;
					}
				}
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw new NotImplementedException();
				IL_D1:
				return 60;
				IL_D6:
				return 180;
				IL_DE:
				return 360;
				IL_E6:
				result = 600;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100142", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 360;
			}
			return result;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00099AE0 File Offset: 0x00097CE0
		public void method_20()
		{
			try
			{
				if (Enumerable.Count<Cargo>(this.activeUnit_0.cargo_0) != 0)
				{
					if (!(this.activeUnit_0 is Group))
					{
						List<GeoPoint> list = new List<GeoPoint>();
						int num = 1;
						do
						{
							float num2 = 0f;
							do
							{
								GeoPoint geoPoint = new GeoPoint();
								double double_ = this.activeUnit_0.vmethod_28(null);
								double double_2 = this.activeUnit_0.vmethod_30(null);
								GeoPoint geoPoint2;
								double double_3 = (geoPoint2 = geoPoint).imethod_0();
								GeoPoint geoPoint3;
								double double_4 = (geoPoint3 = geoPoint).imethod_2();
								Class411.smethod_1(double_, double_2, ref double_3, ref double_4, (double)num2, (double)num);
								geoPoint3.imethod_3(double_4);
								geoPoint2.imethod_1(double_3);
								short num3 = Terrain.smethod_7(geoPoint.imethod_2(), geoPoint.imethod_0(), false);
								if (num3 > 0 & num3 < 50)
								{
									list.Add(geoPoint);
								}
								num2 += 0.1f;
							}
							while (num2 <= 2f);
							num++;
						}
						while (num <= 360);
						if (Enumerable.Any<GeoPoint>(list))
						{
							GeoPoint geoPoint4 = Enumerable.ElementAtOrDefault<GeoPoint>(Enumerable.OrderBy<GeoPoint, double>(list, new Func<GeoPoint, double>(this.method_57)), 0);
							List<Facility> list2 = Facility.smethod_10(Enumerable.ToList<Mount>(Enumerable.Select<Cargo, Mount>(this.activeUnit_0.cargo_0, (ActiveUnit_DockingOps._Closure$__.$I90-1 == null) ? (ActiveUnit_DockingOps._Closure$__.$I90-1 = new Func<Cargo, Mount>(ActiveUnit_DockingOps._Closure$__.$I.method_1)) : ActiveUnit_DockingOps._Closure$__.$I90-1)), this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_7(false));
							try
							{
								foreach (Facility facility in list2)
								{
									facility.vmethod_29(null, geoPoint4.imethod_0());
									facility.vmethod_31(null, geoPoint4.imethod_2());
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
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101364", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00099D3C File Offset: 0x00097F3C
		private void method_21()
		{
			try
			{
				if (this.activeUnit_0.vmethod_101() != null)
				{
					if (this.activeUnit_0.vmethod_101().method_12())
					{
						if (this.activeUnit_0.vmethod_101() is Class338)
						{
							Class338 @class = (Class338)this.activeUnit_0.vmethod_101();
							if (((Interface3)this.activeUnit_0).imethod_2() != CargoType.NoCargo)
							{
								if (Enumerable.Count<Cargo>(this.activeUnit_0.cargo_0) > 0)
								{
									float num = this.activeUnit_0.vmethod_87().vmethod_26() / 2f;
									float num2 = Enumerable.Average(Enumerable.Select<ReferencePoint, float>(@class.list_5, new Func<ReferencePoint, float>(this.method_58)));
									if ((double)num2 < (double)num * 0.75)
									{
										this.activeUnit_0.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
									}
									else
									{
										string.Concat(new string[]
										{
											"Boat ",
											this.activeUnit_0.Name,
											" too far from destination area to launch by ",
											Conversions.ToString(Math.Round(Math.Abs((double)num * 0.75 - (double)num2), 2)),
											"NM"
										});
									}
								}
								else
								{
									List<ActiveUnit> list = new List<ActiveUnit>();
									if (this.method_17() is Ship)
									{
										list.Add(this.method_17());
									}
									else if (this.method_17() is Facility)
									{
										list.Add(this.method_17());
									}
									else if (this.method_17() is Group)
									{
										try
										{
											foreach (KeyValuePair<string, ActiveUnit> keyValuePair in ((Group)this.method_17()).vmethod_141())
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
									object obj = ActiveUnit_DockingOps.object_0;
									ObjectFlowControl.CheckForSyncLockOnValueType(obj);
									lock (obj)
									{
										try
										{
											foreach (ActiveUnit activeUnit in list)
											{
												List<Cargo> list2 = ActiveUnit_DockingOps.smethod_11((Interface3)activeUnit, (Interface3)this.activeUnit_0, @class.dictionary_0);
												if (list2.Count > 0)
												{
													ActiveUnit_DockingOps.smethod_13(activeUnit, this.activeUnit_0, list2);
													this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Readying);
													this.method_1(Math.Max(this.method_0(), 1800f));
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
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101365", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0009A0E8 File Offset: 0x000982E8
		public static List<Cargo> smethod_11(Interface3 interface3_0, Interface3 interface3_1, Dictionary<int, int> dictionary_0)
		{
			List<Cargo> list = new List<Cargo>();
			double num = (double)interface3_1.imethod_3();
			double num2 = (double)interface3_1.imethod_1();
			double num3 = (double)interface3_1.imethod_0();
			Cargo[] cargo_ = ((ActiveUnit)interface3_1).cargo_0;
			for (int i = 0; i < cargo_.Length; i = checked(i + 1))
			{
				Mount mount = (Mount)cargo_[i].method_25();
				num -= (double)mount.short_2;
				num2 -= (double)mount.short_1;
				num3 -= (double)mount.short_0;
			}
			try
			{
				foreach (Cargo cargo in Enumerable.OrderBy<Cargo, int>(((ActiveUnit)interface3_0).cargo_0, (ActiveUnit_DockingOps._Closure$__.$I94-0 == null) ? (ActiveUnit_DockingOps._Closure$__.$I94-0 = new Func<Cargo, int>(ActiveUnit_DockingOps._Closure$__.$I.method_2)) : ActiveUnit_DockingOps._Closure$__.$I94-0))
				{
					if (cargo.method_23() == Cargo.Enum111.const_1)
					{
						Mount mount2 = (Mount)cargo.method_25();
						if (mount2.cargoType_0 <= interface3_1.imethod_2() && dictionary_0.ContainsKey(mount2.DBID) && dictionary_0[mount2.DBID] >= 1 && num >= (double)mount2.short_2 && num2 >= (double)mount2.short_1 && num3 >= (double)mount2.short_0)
						{
							list.Add(cargo);
							num -= (double)mount2.short_2;
							num2 -= (double)mount2.short_1;
							num3 -= (double)mount2.short_0;
						}
					}
				}
			}
			finally
			{
				IEnumerator<Cargo> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				foreach (Mount mount3 in ((ActiveUnit)interface3_0).vmethod_51())
				{
					if (mount3.cargoType_0 != CargoType.NoCargo && mount3.cargoType_0 <= interface3_1.imethod_2() && dictionary_0.ContainsKey(mount3.DBID) && dictionary_0[mount3.DBID] >= 1 && num >= (double)mount3.short_2 && num2 >= (double)mount3.short_1 && num3 >= (double)mount3.short_0)
					{
						list.Add(new Cargo((ActiveUnit)interface3_0, mount3));
						num -= (double)mount3.short_2;
						num2 -= (double)mount3.short_1;
						num3 -= (double)mount3.short_0;
					}
				}
			}
			finally
			{
				List<Mount>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			return list;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0009A348 File Offset: 0x00098548
		public void method_22(float float_3)
		{
			try
			{
				this.method_27(float_3);
				this.method_33(float_3);
				this.method_29();
				this.method_1(this.method_0() - float_3);
				if (this.method_0() < 0f)
				{
					this.method_1(0f);
				}
				if (this.method_0() == 0f)
				{
					switch (this.method_8())
					{
					case ActiveUnit_DockingOps._DockingOpsCondition.Docked:
						this.method_21();
						break;
					case ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway:
						this.method_47(float_3);
						break;
					case ActiveUnit_DockingOps._DockingOpsCondition.Docking:
						this.method_49();
						break;
					case ActiveUnit_DockingOps._DockingOpsCondition.Readying:
						this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Docked);
						break;
					case ActiveUnit_DockingOps._DockingOpsCondition.ManoeuveringToRefuel:
						this.method_38();
						break;
					case ActiveUnit_DockingOps._DockingOpsCondition.ProvidingUNREP:
						this.method_28(float_3);
						this.method_35(float_3);
						this.method_24();
						if (!this.method_18())
						{
							this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
							this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100143", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0009A478 File Offset: 0x00098678
		private void method_23()
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			try
			{
				foreach (ActiveUnit activeUnit in this.activeUnit_0.scenario_0.method_42())
				{
					if (activeUnit.vmethod_93().method_6() == this.activeUnit_0 && activeUnit.vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling)
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
			try
			{
				foreach (ActiveUnit activeUnit2 in list)
				{
					if (this.activeUnit_0.method_36(activeUnit2) > this.float_2 * 2f)
					{
						activeUnit2.vmethod_93().method_26();
					}
					else if (this.method_36(activeUnit2) <= 0 && this.method_37(activeUnit2) <= 0)
					{
						activeUnit2.vmethod_93().method_26();
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0009A57C File Offset: 0x0009877C
		private void method_24()
		{
			if (this.activeUnit_0.bool_8)
			{
				this.method_23();
				return;
			}
			try
			{
				if (!string.IsNullOrEmpty(this.string_4))
				{
					ActiveUnit activeUnit = this.activeUnit_0.scenario_0.vmethod_0()[this.string_4];
					if (this.activeUnit_0.method_36(activeUnit) > this.float_2 * 2f)
					{
						activeUnit.vmethod_93().method_26();
					}
					else if (this.method_36(activeUnit) <= 0 && this.method_37(activeUnit) <= 0)
					{
						activeUnit.vmethod_93().method_26();
					}
				}
				if (!string.IsNullOrEmpty(this.string_5))
				{
					ActiveUnit activeUnit = this.activeUnit_0.scenario_0.vmethod_0()[this.string_5];
					if (this.activeUnit_0.method_36(activeUnit) > this.float_2 * 2f)
					{
						activeUnit.vmethod_93().method_26();
					}
					else if (this.method_36(activeUnit) <= 0 && this.method_37(activeUnit) <= 0)
					{
						activeUnit.vmethod_93().method_26();
					}
				}
				if (!string.IsNullOrEmpty(this.string_6))
				{
					ActiveUnit activeUnit = this.activeUnit_0.scenario_0.vmethod_0()[this.string_6];
					if (this.activeUnit_0.method_36(activeUnit) > this.float_2 * 2f)
					{
						activeUnit.vmethod_93().method_26();
					}
					else if (this.method_36(activeUnit) <= 0 && this.method_37(activeUnit) <= 0)
					{
						activeUnit.vmethod_93().method_26();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100144", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0009A740 File Offset: 0x00098940
		public void method_25()
		{
			if (this.method_6() != null && this.method_6().vmethod_93().vmethod_0().Contains(this.activeUnit_0.string_0))
			{
				this.method_6().vmethod_93().vmethod_0().Remove(this.activeUnit_0.string_0);
			}
			this.method_7(null);
			this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
			this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0009A7B4 File Offset: 0x000989B4
		public void method_26()
		{
			if (this.activeUnit_0.bool_8)
			{
				this.method_25();
				return;
			}
			try
			{
				if (this.method_6() != null)
				{
					ActiveUnit activeUnit = this.method_6();
					if (Operators.CompareString(this.method_6().vmethod_93().string_4, this.activeUnit_0.string_0, false) == 0)
					{
						this.method_6().vmethod_93().string_4 = null;
						this.method_7(null);
						this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
						this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
					}
					else if (Operators.CompareString(this.method_6().vmethod_93().string_5, this.activeUnit_0.string_0, false) == 0)
					{
						this.method_6().vmethod_93().string_5 = null;
						this.method_7(null);
						this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
						this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
					}
					else if (Operators.CompareString(this.method_6().vmethod_93().string_6, this.activeUnit_0.string_0, false) == 0)
					{
						this.method_6().vmethod_93().string_6 = null;
						this.method_7(null);
						this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
						this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
					}
					else if (activeUnit != null && activeUnit.vmethod_93().vmethod_0().Contains(this.activeUnit_0.string_0))
					{
						activeUnit.vmethod_93().vmethod_0().Remove(this.activeUnit_0.string_0);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100145", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0009A970 File Offset: 0x00098B70
		private void method_27(float float_3)
		{
			try
			{
				float num = 63.33f;
				try
				{
					foreach (ActiveUnit activeUnit in this.method_14())
					{
						ActiveUnit_DockingOps._DockingOpsCondition dockingOpsCondition = activeUnit.vmethod_93().method_8();
						if (dockingOpsCondition == ActiveUnit_DockingOps._DockingOpsCondition.Docked || dockingOpsCondition == ActiveUnit_DockingOps._DockingOpsCondition.Readying)
						{
							int num2;
							switch (activeUnit.vmethod_121())
							{
							case GlobalVariables.TargetVisualSizeClass.Stealthy:
							case GlobalVariables.TargetVisualSizeClass.VSmall:
								num2 = 1;
								break;
							case GlobalVariables.TargetVisualSizeClass.Small:
								num2 = 2;
								break;
							case GlobalVariables.TargetVisualSizeClass.Medium:
								num2 = 3;
								break;
							case GlobalVariables.TargetVisualSizeClass.Large:
								num2 = 4;
								break;
							case GlobalVariables.TargetVisualSizeClass.VLarge:
								num2 = 5;
								break;
							}
							float val = num * (float)num2 * float_3;
							try
							{
								IEnumerator<FuelRec> enumerator2 = Enumerable.Where<FuelRec>(activeUnit.vmethod_67(), (ActiveUnit_DockingOps._Closure$__.$I101-0 == null) ? (ActiveUnit_DockingOps._Closure$__.$I101-0 = new Func<FuelRec, bool>(ActiveUnit_DockingOps._Closure$__.$I.method_3)) : ActiveUnit_DockingOps._Closure$__.$I101-0).GetEnumerator();
								while (enumerator2.MoveNext())
								{
									ActiveUnit_DockingOps.Class191 @class = new ActiveUnit_DockingOps.Class191(@class);
									@class.fuelRec_0 = enumerator2.Current;
									if (@class.fuelRec_0._FuelType_0 == FuelRec._FuelType.Battery)
									{
										@class.fuelRec_0.float_0 = (float)@class.fuelRec_0.int_0;
									}
									else
									{
										FuelRec fuelRec;
										if (this.activeUnit_0.method_5())
										{
											fuelRec = new FuelRec(int.MaxValue, (short)@class.fuelRec_0._FuelType_0);
										}
										else
										{
											fuelRec = Enumerable.FirstOrDefault<FuelRec>(Enumerable.DefaultIfEmpty<FuelRec>(Enumerable.Where<FuelRec>(this.activeUnit_0.vmethod_67(), new Func<FuelRec, bool>(@class.method_0)), null));
										}
										if (!Information.IsNothing(fuelRec))
										{
											float num3 = (float)@class.fuelRec_0.int_0 - @class.fuelRec_0.float_0;
											float num4 = Math.Min(val, fuelRec.float_0);
											if (num3 >= num4)
											{
												activeUnit.vmethod_135(num4, fuelRec._FuelType_0);
												FuelRec fuelRec2 = fuelRec;
												ref float ptr = ref fuelRec2.float_0;
												fuelRec2.float_0 = ptr - num4;
											}
											else
											{
												activeUnit.vmethod_135(num3, fuelRec._FuelType_0);
												FuelRec fuelRec3 = fuelRec;
												ref float ptr = ref fuelRec3.float_0;
												fuelRec3.float_0 = ptr - num3;
											}
										}
									}
								}
							}
							finally
							{
								IEnumerator<FuelRec> enumerator2;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
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
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101366", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0009AC00 File Offset: 0x00098E00
		private void method_28(float float_3)
		{
			float num = 63.33f;
			try
			{
				if (!string.IsNullOrEmpty(this.string_4))
				{
					ActiveUnit activeUnit = this.activeUnit_0.scenario_0.vmethod_0()[this.string_4];
					byte byte_ = this.activeUnit_0.struct26_0.byte_5;
					float val = num * (float)byte_ * float_3;
					try
					{
						IEnumerator<FuelRec> enumerator = Enumerable.Where<FuelRec>(activeUnit.vmethod_67(), (ActiveUnit_DockingOps._Closure$__.$I102-0 == null) ? (ActiveUnit_DockingOps._Closure$__.$I102-0 = new Func<FuelRec, bool>(ActiveUnit_DockingOps._Closure$__.$I.method_4)) : ActiveUnit_DockingOps._Closure$__.$I102-0).GetEnumerator();
						while (enumerator.MoveNext())
						{
							ActiveUnit_DockingOps.Class192 @class = new ActiveUnit_DockingOps.Class192(@class);
							@class.fuelRec_0 = enumerator.Current;
							FuelRec fuelRec = Enumerable.FirstOrDefault<FuelRec>(Enumerable.DefaultIfEmpty<FuelRec>(Enumerable.Where<FuelRec>(this.activeUnit_0.vmethod_67(), new Func<FuelRec, bool>(@class.method_0)), null));
							if (!Information.IsNothing(fuelRec))
							{
								float num2 = (float)@class.fuelRec_0.int_0 - @class.fuelRec_0.float_0;
								float num3 = Math.Min(val, fuelRec.float_0);
								if (num2 >= num3)
								{
									activeUnit.vmethod_135(num3, fuelRec._FuelType_0);
									FuelRec fuelRec2 = fuelRec;
									ref float ptr = ref fuelRec2.float_0;
									fuelRec2.float_0 = ptr - num3;
								}
								else
								{
									activeUnit.vmethod_135(num2, fuelRec._FuelType_0);
									FuelRec fuelRec3 = fuelRec;
									ref float ptr = ref fuelRec3.float_0;
									fuelRec3.float_0 = ptr - num2;
								}
							}
						}
					}
					finally
					{
						IEnumerator<FuelRec> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				if (!string.IsNullOrEmpty(this.string_5))
				{
					ActiveUnit activeUnit = this.activeUnit_0.scenario_0.vmethod_0()[this.string_5];
					byte byte_2 = this.activeUnit_0.struct26_0.byte_7;
					float val2 = num * (float)byte_2 * float_3;
					try
					{
						IEnumerator<FuelRec> enumerator2 = Enumerable.Where<FuelRec>(activeUnit.vmethod_67(), (ActiveUnit_DockingOps._Closure$__.$I102-2 == null) ? (ActiveUnit_DockingOps._Closure$__.$I102-2 = new Func<FuelRec, bool>(ActiveUnit_DockingOps._Closure$__.$I.method_5)) : ActiveUnit_DockingOps._Closure$__.$I102-2).GetEnumerator();
						while (enumerator2.MoveNext())
						{
							ActiveUnit_DockingOps.Class193 class2 = new ActiveUnit_DockingOps.Class193(class2);
							class2.fuelRec_0 = enumerator2.Current;
							FuelRec fuelRec4 = Enumerable.FirstOrDefault<FuelRec>(Enumerable.DefaultIfEmpty<FuelRec>(Enumerable.Where<FuelRec>(this.activeUnit_0.vmethod_67(), new Func<FuelRec, bool>(class2.method_0)), null));
							if (!Information.IsNothing(fuelRec4))
							{
								float num4 = (float)class2.fuelRec_0.int_0 - class2.fuelRec_0.float_0;
								float num5 = Math.Min(val2, fuelRec4.float_0);
								if (num4 >= num5)
								{
									activeUnit.vmethod_135(num5, fuelRec4._FuelType_0);
									FuelRec fuelRec5 = fuelRec4;
									ref float ptr = ref fuelRec5.float_0;
									fuelRec5.float_0 = ptr - num5;
								}
								else
								{
									activeUnit.vmethod_135(num4, fuelRec4._FuelType_0);
									FuelRec fuelRec6 = fuelRec4;
									ref float ptr = ref fuelRec6.float_0;
									fuelRec6.float_0 = ptr - num4;
								}
							}
						}
					}
					finally
					{
						IEnumerator<FuelRec> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
				}
				if (!string.IsNullOrEmpty(this.string_6))
				{
					ActiveUnit activeUnit = this.activeUnit_0.scenario_0.vmethod_0()[this.string_6];
					byte byte_3 = this.activeUnit_0.struct26_0.byte_3;
					float val3 = num * (float)byte_3 * float_3;
					try
					{
						IEnumerator<FuelRec> enumerator3 = Enumerable.Where<FuelRec>(activeUnit.vmethod_67(), (ActiveUnit_DockingOps._Closure$__.$I102-4 == null) ? (ActiveUnit_DockingOps._Closure$__.$I102-4 = new Func<FuelRec, bool>(ActiveUnit_DockingOps._Closure$__.$I.method_6)) : ActiveUnit_DockingOps._Closure$__.$I102-4).GetEnumerator();
						while (enumerator3.MoveNext())
						{
							ActiveUnit_DockingOps.Class194 class3 = new ActiveUnit_DockingOps.Class194(class3);
							class3.fuelRec_0 = enumerator3.Current;
							FuelRec fuelRec7 = Enumerable.FirstOrDefault<FuelRec>(Enumerable.DefaultIfEmpty<FuelRec>(Enumerable.Where<FuelRec>(this.activeUnit_0.vmethod_67(), new Func<FuelRec, bool>(class3.method_0)), null));
							if (!Information.IsNothing(fuelRec7))
							{
								float num6 = (float)class3.fuelRec_0.int_0 - class3.fuelRec_0.float_0;
								float num7 = Math.Min(val3, fuelRec7.float_0);
								if (num6 >= num7)
								{
									activeUnit.vmethod_135(num7, fuelRec7._FuelType_0);
									FuelRec fuelRec8 = fuelRec7;
									ref float ptr = ref fuelRec8.float_0;
									fuelRec8.float_0 = ptr - num7;
								}
								else
								{
									activeUnit.vmethod_135(num6, fuelRec7._FuelType_0);
									FuelRec fuelRec9 = fuelRec7;
									ref float ptr = ref fuelRec9.float_0;
									fuelRec9.float_0 = ptr - num6;
								}
							}
						}
					}
					finally
					{
						IEnumerator<FuelRec> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100146", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0009B0BC File Offset: 0x000992BC
		private void method_29()
		{
			if (this.activeUnit_0.scenario_0.FifteenthMinuteIsChangingOnThisPulse)
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.method_14())
					{
						activeUnit.vmethod_91().method_13(this.activeUnit_0.vmethod_53().Value);
						activeUnit.vmethod_91().method_12(this.activeUnit_0.vmethod_53().Value);
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

		// Token: 0x06000926 RID: 2342 RVA: 0x0009B150 File Offset: 0x00099350
		private bool method_30(Weapon weapon_0)
		{
			bool result;
			try
			{
				if (weapon_0.int_1 > 0)
				{
					int int_ = weapon_0.int_1;
					if (int_ <= 10)
					{
						if (this.activeUnit_0.scenario_0.SecondIsChangingOnThisPulse)
						{
							return true;
						}
					}
					else if (int_ <= 50)
					{
						if (this.activeUnit_0.scenario_0.FifthSecondIsChangingOnThisPulse)
						{
							return true;
						}
					}
					else if (int_ <= 100)
					{
						if (this.activeUnit_0.scenario_0.FifteenthSecondIsChangingOnThisPulse)
						{
							return true;
						}
					}
					else if (int_ <= 150)
					{
						if (this.activeUnit_0.scenario_0.ThirtiethSecondIsChangingOnThisPulse)
						{
							return true;
						}
					}
					else if (int_ <= 250)
					{
						if (this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse)
						{
							return true;
						}
					}
					else if (int_ <= 500)
					{
						if (this.activeUnit_0.scenario_0.FifthMinuteIsChangingOnThisPulse)
						{
							return true;
						}
					}
					else if (int_ <= 1000)
					{
						if (this.activeUnit_0.scenario_0.FifteenthMinuteIsChangingOnThisPulse)
						{
							return true;
						}
					}
					else if (int_ <= 2500)
					{
						if (this.activeUnit_0.scenario_0.ThirtiethMinuteIsChangingOnThisPulse)
						{
							return true;
						}
					}
					else if (this.activeUnit_0.scenario_0.HourIsChangingOnThisPulse)
					{
						return true;
					}
				}
				else
				{
					Weapon._WeaponType weaponType = weapon_0.method_167();
					if (weaponType <= Weapon._WeaponType.DropTank)
					{
						switch (weaponType)
						{
						case Weapon._WeaponType.Rocket:
						case Weapon._WeaponType.Gun:
						{
							Warhead.WarheadCaliber warheadCaliber_ = weapon_0.warhead_0[0].warheadCaliber_0;
							switch (warheadCaliber_)
							{
							case Warhead.WarheadCaliber.Gun_6_15mm:
								break;
							case Warhead.WarheadCaliber.Gun_16_24mm:
								goto IL_24B;
							case Warhead.WarheadCaliber.Gun_25_60mm:
								goto IL_267;
							case Warhead.WarheadCaliber.Gun_61_80mm:
								goto IL_283;
							case Warhead.WarheadCaliber.Gun_81_150mm:
								goto IL_29F;
							case Warhead.WarheadCaliber.Gun_151_200mm:
								goto IL_2BB;
							case Warhead.WarheadCaliber.Gun_201_350mm:
								goto IL_2D7;
							case Warhead.WarheadCaliber.Gun_351_450mm:
								goto IL_2F3;
							default:
								switch (warheadCaliber_)
								{
								case Warhead.WarheadCaliber.Rocket_6_15mm:
									break;
								case Warhead.WarheadCaliber.Rocket_16_24mm:
									goto IL_24B;
								case Warhead.WarheadCaliber.Rocket_25_60mm:
									goto IL_267;
								case Warhead.WarheadCaliber.Rocket_61_80mm:
									goto IL_283;
								case Warhead.WarheadCaliber.Rocket_81_150mm:
									goto IL_29F;
								case Warhead.WarheadCaliber.Rocket_151_200mm:
									goto IL_2BB;
								case Warhead.WarheadCaliber.Rocket_201_350mm:
									goto IL_2D7;
								case Warhead.WarheadCaliber.Rocket_351_450mm:
									goto IL_2F3;
								default:
									if (this.activeUnit_0.scenario_0.HourIsChangingOnThisPulse)
									{
										return true;
									}
									goto IL_3E0;
								}
								break;
							}
							if (this.activeUnit_0.scenario_0.SecondIsChangingOnThisPulse)
							{
								return true;
							}
							goto IL_3E0;
							IL_24B:
							if (this.activeUnit_0.scenario_0.FifthSecondIsChangingOnThisPulse)
							{
								return true;
							}
							goto IL_3E0;
							IL_267:
							if (this.activeUnit_0.scenario_0.FifteenthSecondIsChangingOnThisPulse)
							{
								return true;
							}
							goto IL_3E0;
							IL_283:
							if (this.activeUnit_0.scenario_0.ThirtiethSecondIsChangingOnThisPulse)
							{
								return true;
							}
							goto IL_3E0;
							IL_29F:
							if (this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse)
							{
								return true;
							}
							goto IL_3E0;
							IL_2BB:
							if (this.activeUnit_0.scenario_0.FifthMinuteIsChangingOnThisPulse)
							{
								return true;
							}
							goto IL_3E0;
							IL_2D7:
							if (this.activeUnit_0.scenario_0.FifteenthMinuteIsChangingOnThisPulse)
							{
								return true;
							}
							goto IL_3E0;
							IL_2F3:
							if (this.activeUnit_0.scenario_0.ThirtiethMinuteIsChangingOnThisPulse)
							{
								return true;
							}
							goto IL_3E0;
						}
						case Weapon._WeaponType.IronBomb:
						case Weapon._WeaponType.Decoy_Towed:
						case Weapon._WeaponType.TrainingRound:
							break;
						case Weapon._WeaponType.Decoy_Expendable:
						case Weapon._WeaponType.Decoy_Vehicle:
							if (this.activeUnit_0.scenario_0.FifthMinuteIsChangingOnThisPulse)
							{
								return true;
							}
							goto IL_3E0;
						case Weapon._WeaponType.Dispenser:
							if (this.activeUnit_0.scenario_0.FifthMinuteIsChangingOnThisPulse)
							{
								return true;
							}
							goto IL_3E0;
						default:
							if (weaponType == Weapon._WeaponType.DropTank)
							{
								if (this.activeUnit_0.scenario_0.FifthMinuteIsChangingOnThisPulse)
								{
									return true;
								}
								goto IL_3E0;
							}
							break;
						}
					}
					else
					{
						switch (weaponType)
						{
						case Weapon._WeaponType.DepthCharge:
							if (this.activeUnit_0.scenario_0.FifthMinuteIsChangingOnThisPulse)
							{
								return true;
							}
							goto IL_3E0;
						case Weapon._WeaponType.Sonobuoy:
						case (Weapon._WeaponType)4010:
							break;
						case Weapon._WeaponType.BottomMine:
						case Weapon._WeaponType.MooredMine:
						case Weapon._WeaponType.FloatingMine:
						case Weapon._WeaponType.MovingMine:
						case Weapon._WeaponType.RisingMine:
						case Weapon._WeaponType.DriftingMine:
						case Weapon._WeaponType.DummyMine:
							if (this.activeUnit_0.scenario_0.FifthMinuteIsChangingOnThisPulse)
							{
								return true;
							}
							goto IL_3E0;
						default:
							if (weaponType == Weapon._WeaponType.Laser)
							{
								if (this.activeUnit_0.scenario_0.FifthMinuteIsChangingOnThisPulse)
								{
									return true;
								}
								goto IL_3E0;
							}
							break;
						}
					}
					if (this.activeUnit_0.scenario_0.FifthMinuteIsChangingOnThisPulse)
					{
						return true;
					}
				}
				IL_3E0:
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101367", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0009B598 File Offset: 0x00099798
		private void method_31(ActiveUnit activeUnit_3)
		{
			if (this.method_37(activeUnit_3) > 0)
			{
				Dictionary<int, Weapon> dictionary = activeUnit_3.vmethod_89().method_2(true);
				int num = 1;
				try
				{
					foreach (int num2 in dictionary.Keys)
					{
						if (num == 0)
						{
							break;
						}
						Weapon weapon_ = this.activeUnit_0.scenario_0.method_87(num2);
						if (activeUnit_3.vmethod_89().method_4(num2) - activeUnit_3.vmethod_89().method_5(num2, false) != 0 && this.method_30(weapon_))
						{
							if (this.activeUnit_0.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2))
							{
								if (Operators.CompareString(activeUnit_3.vmethod_89().vmethod_10(num2, false, false), "OK", false) == 0)
								{
									num--;
								}
							}
							else
							{
								Magazine[] array;
								if (this.activeUnit_0.method_120() && this.activeUnit_0.vmethod_65(false).method_140())
								{
									array = this.activeUnit_0.vmethod_65(false).vmethod_117();
								}
								else
								{
									array = this.activeUnit_0.vmethod_117();
								}
								foreach (Magazine magazine in array)
								{
									try
									{
										foreach (WeaponRec weaponRec in magazine.vmethod_10())
										{
											if (weaponRec.method_9() > 0 && weaponRec.int_5 == num2 && Operators.CompareString(activeUnit_3.vmethod_89().vmethod_10(num2, false, false), "OK", false) == 0)
											{
												weaponRec.method_10(weaponRec.method_9() - 1);
												weaponRec.method_15();
												num--;
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
					}
				}
				finally
				{
					Dictionary<int, Weapon>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0009B798 File Offset: 0x00099998
		private void method_32(ActiveUnit activeUnit_3)
		{
			try
			{
				if (this.activeUnit_0.bool_8)
				{
					this.method_31(activeUnit_3);
				}
				else if (this.method_37(activeUnit_3) > 0)
				{
					Dictionary<int, Weapon> dictionary = activeUnit_3.vmethod_89().method_2(true);
					int num = 1;
					if (this.activeUnit_0.struct26_0.byte_4 == 4 | this.activeUnit_0.struct26_0.byte_6 == 4)
					{
						num *= 4;
					}
					else if (this.activeUnit_0.struct26_0.byte_4 == 3 | this.activeUnit_0.struct26_0.byte_6 == 3)
					{
						num *= 3;
					}
					else if (this.activeUnit_0.struct26_0.byte_4 == 2 | this.activeUnit_0.struct26_0.byte_6 == 2)
					{
						num *= 2;
					}
					if (this.activeUnit_0.bool_8)
					{
						num *= 2;
					}
					if (activeUnit_3.bool_5)
					{
						num = Math.Max(1, (int)Math.Round((double)num / 2.0));
					}
					try
					{
						foreach (int num2 in dictionary.Keys)
						{
							if (num == 0)
							{
								break;
							}
							Weapon weapon_ = this.activeUnit_0.scenario_0.method_87(num2);
							if (activeUnit_3.vmethod_89().method_4(num2) - activeUnit_3.vmethod_89().method_5(num2, false) != 0 && this.method_30(weapon_))
							{
								if (this.activeUnit_0.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2))
								{
									if (Operators.CompareString(activeUnit_3.vmethod_89().vmethod_10(num2, false, false), "OK", false) == 0)
									{
										num--;
									}
								}
								else
								{
									Magazine[] array;
									if (this.activeUnit_0.method_120() && this.activeUnit_0.vmethod_65(false).method_140())
									{
										array = this.activeUnit_0.vmethod_65(false).vmethod_117();
									}
									else
									{
										array = this.activeUnit_0.vmethod_117();
									}
									foreach (Magazine magazine in array)
									{
										try
										{
											foreach (WeaponRec weaponRec in magazine.vmethod_10())
											{
												if (weaponRec.method_9() > 0 && weaponRec.int_5 == num2 && Operators.CompareString(activeUnit_3.vmethod_89().vmethod_10(num2, false, false), "OK", false) == 0)
												{
													weaponRec.method_10(weaponRec.method_9() - 1);
													weaponRec.method_15();
													num--;
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
						}
					}
					finally
					{
						Dictionary<int, Weapon>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101368", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0009BAC0 File Offset: 0x00099CC0
		private void method_33(float float_3)
		{
			try
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.method_14())
					{
						ActiveUnit_DockingOps._DockingOpsCondition dockingOpsCondition = activeUnit.vmethod_93().method_8();
						if (dockingOpsCondition == ActiveUnit_DockingOps._DockingOpsCondition.Docked || dockingOpsCondition == ActiveUnit_DockingOps._DockingOpsCondition.Readying)
						{
							this.method_32(activeUnit);
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
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101369", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0009BB68 File Offset: 0x00099D68
		private void method_34(float float_3)
		{
			try
			{
				foreach (ActiveUnit activeUnit in this.activeUnit_0.scenario_0.method_42())
				{
					if (activeUnit.vmethod_93().method_6() == this.activeUnit_0 && activeUnit.vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling)
					{
						this.method_32(activeUnit);
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0009BBE4 File Offset: 0x00099DE4
		private void method_35(float float_3)
		{
			if (this.activeUnit_0.bool_8)
			{
				this.method_34(float_3);
				return;
			}
			List<ActiveUnit> list = new List<ActiveUnit>();
			try
			{
				if (!string.IsNullOrEmpty(this.string_4))
				{
					list.Add(this.activeUnit_0.scenario_0.vmethod_0()[this.string_4]);
				}
				if (!string.IsNullOrEmpty(this.string_5))
				{
					list.Add(this.activeUnit_0.scenario_0.vmethod_0()[this.string_5]);
				}
				if (!string.IsNullOrEmpty(this.string_6))
				{
					list.Add(this.activeUnit_0.scenario_0.vmethod_0()[this.string_6]);
				}
				try
				{
					foreach (ActiveUnit activeUnit in list)
					{
						string left = activeUnit.string_0;
						if (Operators.CompareString(left, this.string_4, false) == 0)
						{
							this.method_32(activeUnit);
						}
						else if (Operators.CompareString(left, this.string_5, false) == 0)
						{
							this.method_32(activeUnit);
						}
						else if (Operators.CompareString(left, this.string_6, false) == 0)
						{
							this.method_32(activeUnit);
						}
						else if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100147", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0009BD8C File Offset: 0x00099F8C
		public int method_36(ActiveUnit activeUnit_3)
		{
			int result;
			try
			{
				int num3;
				foreach (FuelRec fuelRec in activeUnit_3.vmethod_67())
				{
					if (fuelRec.float_0 < (float)fuelRec.int_0)
					{
						int num = (int)Math.Round((double)((float)fuelRec.int_0 - fuelRec.float_0));
						int num2 = 0;
						foreach (FuelRec fuelRec2 in this.activeUnit_0.vmethod_67())
						{
							if (fuelRec2._FuelType_0 == fuelRec._FuelType_0)
							{
								num2 = (int)Math.Round((double)((float)num2 + fuelRec2.float_0));
							}
						}
						if (num >= num2)
						{
							num3 += num2;
						}
						else
						{
							num3 += num;
						}
					}
				}
				result = num3;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100148", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0009BE94 File Offset: 0x0009A094
		public int method_37(ActiveUnit activeUnit_3)
		{
			int result;
			try
			{
				Dictionary<int, Weapon> dictionary = activeUnit_3.vmethod_89().method_2(true);
				int num5;
				try
				{
					foreach (int int_ in dictionary.Keys)
					{
						int num = activeUnit_3.vmethod_89().method_4(int_);
						int num2 = activeUnit_3.vmethod_89().method_5(int_, false);
						int num3 = num - num2;
						if (num3 > 0)
						{
							int num4;
							if (this.activeUnit_0.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2))
							{
								num4 = int.MaxValue;
							}
							else
							{
								num4 = this.activeUnit_0.vmethod_89().vmethod_8(int_);
							}
							if (num4 != 0)
							{
								if (num3 >= num4)
								{
									num5 += num4;
								}
								else
								{
									num5 += num3;
								}
							}
						}
					}
				}
				finally
				{
					Dictionary<int, Weapon>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = num5;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100149", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0009BFB0 File Offset: 0x0009A1B0
		public bool method_38()
		{
			bool result;
			try
			{
				if (this.method_6().vmethod_93().method_8() != ActiveUnit_DockingOps._DockingOpsCondition.ManoeuveringToRefuel)
				{
					if (this.method_6().vmethod_93().method_8() != ActiveUnit_DockingOps._DockingOpsCondition.Replenishing)
					{
						if (this.activeUnit_0.method_36(this.method_6()) > this.float_2)
						{
							return false;
						}
						if (this.method_6().vmethod_40() > 0f && this.activeUnit_0.vmethod_40() > 0f && Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_9(), this.method_6().vmethod_9())) > 20f)
						{
							return false;
						}
						if (this.method_6().vmethod_105(this.activeUnit_0) && (string.IsNullOrEmpty(this.method_6().vmethod_93().string_4) || string.IsNullOrEmpty(this.method_6().vmethod_93().string_5) || string.IsNullOrEmpty(this.method_6().vmethod_93().string_6)))
						{
							this.method_39();
							return true;
						}
						return false;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100150", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0009C11C File Offset: 0x0009A31C
		private void method_39()
		{
			try
			{
				if (this.activeUnit_0.bool_8)
				{
					this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Refuelling);
					this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Replenishing);
					this.method_6().vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.ProvidingUNREP);
					this.method_6().vmethod_93().vmethod_0().Remove(this.activeUnit_0.string_0);
				}
				else if (Operators.CompareString(this.method_6().vmethod_93().string_4, this.activeUnit_0.string_0, false) != 0 && Operators.CompareString(this.method_6().vmethod_93().string_5, this.activeUnit_0.string_0, false) != 0 && Operators.CompareString(this.method_6().vmethod_93().string_6, this.activeUnit_0.string_0, false) != 0)
				{
					if (string.IsNullOrEmpty(this.method_6().vmethod_93().string_4) && this.method_6().struct26_0.byte_5 > 0)
					{
						this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Refuelling);
						this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Replenishing);
						this.method_6().vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.ProvidingUNREP);
						this.method_6().vmethod_93().vmethod_0().Remove(this.activeUnit_0.string_0);
						this.method_6().vmethod_93().string_4 = this.activeUnit_0.string_0;
					}
					else if (string.IsNullOrEmpty(this.method_6().vmethod_93().string_5) && this.method_6().struct26_0.byte_7 > 0)
					{
						this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Refuelling);
						this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Replenishing);
						this.method_6().vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.ProvidingUNREP);
						this.method_6().vmethod_93().vmethod_0().Remove(this.activeUnit_0.string_0);
						this.method_6().vmethod_93().string_5 = this.activeUnit_0.string_0;
					}
					else if (string.IsNullOrEmpty(this.method_6().vmethod_93().string_6) && this.method_6().struct26_0.byte_3 > 0)
					{
						this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Refuelling);
						this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Replenishing);
						this.method_6().vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.ProvidingUNREP);
						this.method_6().vmethod_93().vmethod_0().Remove(this.activeUnit_0.string_0);
						this.method_6().vmethod_93().string_6 = this.activeUnit_0.string_0;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100151", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0009C3F4 File Offset: 0x0009A5F4
		public static bool smethod_12(DockFacility.Enum50 enum50_0)
		{
			if (enum50_0 - DockFacility.Enum50.const_7 > 3 && enum50_0 != DockFacility.Enum50.const_11)
			{
				if (enum50_0 != DockFacility.Enum50.const_12)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0009C428 File Offset: 0x0009A628
		public bool method_40(ActiveUnit theBoat, ref DockFacility bestFacility = null)
		{
			List<DockFacility> list = new List<DockFacility>();
			bool result;
			try
			{
				int num;
				DockFacility.Enum50 enum50_;
				if (theBoat.bool_6)
				{
					num = (int)Math.Round((double)((Ship)theBoat).float_13);
					enum50_ = ((Ship)theBoat).enum50_0;
				}
				else
				{
					if (!theBoat.bool_5)
					{
						throw new NotImplementedException();
					}
					num = (int)Math.Round((double)((Submarine)theBoat).float_13);
					enum50_ = ((Submarine)theBoat).enum50_0;
				}
				foreach (DockFacility dockFacility in this.activeUnit_0.vmethod_100())
				{
					if (dockFacility.method_26((short)num, enum50_) && dockFacility.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
					{
						if (Enumerable.Count<DockFacility>(this.activeUnit_0.vmethod_100()) == 1)
						{
							bestFacility = dockFacility;
							return true;
						}
						list.Add(dockFacility);
					}
				}
				DockFacility dockFacility2 = null;
				if (list.Count > 0)
				{
					try
					{
						foreach (DockFacility dockFacility3 in list)
						{
							if (dockFacility3.enum50_0 == enum50_ && (Information.IsNothing(dockFacility2) || dockFacility3.method_29() < dockFacility2.method_29()))
							{
								dockFacility2 = dockFacility3;
							}
						}
					}
					finally
					{
						List<DockFacility>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (Information.IsNothing(dockFacility2))
					{
						IEnumerable<DockFacility> enumerable = Enumerable.OrderBy<DockFacility, int>(list, (ActiveUnit_DockingOps._Closure$__.$I117-0 == null) ? (ActiveUnit_DockingOps._Closure$__.$I117-0 = new Func<DockFacility, int>(ActiveUnit_DockingOps._Closure$__.$I.method_7)) : ActiveUnit_DockingOps._Closure$__.$I117-0);
						bestFacility = Enumerable.ElementAtOrDefault<DockFacility>(enumerable, 0);
						result = true;
					}
					else
					{
						bestFacility = dockFacility2;
						result = true;
					}
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100152", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0009C618 File Offset: 0x0009A818
		public bool method_41(short short_0, DockFacility.Enum50 enum50_0)
		{
			bool result;
			try
			{
				foreach (DockFacility dockFacility in this.activeUnit_0.vmethod_100())
				{
					if (dockFacility.method_26(short_0, enum50_0) && dockFacility.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
					{
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100153", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0009C6A8 File Offset: 0x0009A8A8
		public void method_42(ActiveUnit activeUnit_3)
		{
			try
			{
				if (!Information.IsNothing(activeUnit_3.vmethod_93().method_15()))
				{
					activeUnit_3.vmethod_93().method_16(null);
				}
				DockFacility dockFacility_ = this.method_46(activeUnit_3);
				activeUnit_3.vmethod_93().method_16(dockFacility_);
				switch (activeUnit_3.vmethod_93().method_8())
				{
				case ActiveUnit_DockingOps._DockingOpsCondition.Underway:
				case ActiveUnit_DockingOps._DockingOpsCondition.RTB:
				case ActiveUnit_DockingOps._DockingOpsCondition.ManoeuveringToRefuel:
				case ActiveUnit_DockingOps._DockingOpsCondition.Replenishing:
				case ActiveUnit_DockingOps._DockingOpsCondition.ProvidingUNREP:
				case ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries:
				case ActiveUnit_DockingOps._DockingOpsCondition.SettlingForCargoTransfer:
					if (activeUnit_3.vmethod_93().method_0() == 0f)
					{
						activeUnit_3.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.Docked);
					}
					else
					{
						activeUnit_3.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.Docking);
					}
					break;
				case ActiveUnit_DockingOps._DockingOpsCondition.Docked:
					if (activeUnit_3.vmethod_93().method_0() > 0f)
					{
						activeUnit_3.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.Readying);
					}
					break;
				}
				activeUnit_3.vmethod_93().method_12(false, this.activeUnit_0);
				activeUnit_3.vmethod_15(false, 0f);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100154", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0009C7DC File Offset: 0x0009A9DC
		public void method_43(ActiveUnit excludeUnit = null)
		{
			try
			{
				ActiveUnit_DockingOps.Class195 @class = new ActiveUnit_DockingOps.Class195();
				@class.activeUnit_DockingOps_0 = this;
				if (this.activeUnit_0.bool_6 || this.activeUnit_0.bool_5)
				{
					@class.concurrentBag_0 = new ConcurrentBag<ActiveUnit>();
					@class.float_0 = this.activeUnit_0.vmethod_87().vmethod_24(true, null, null);
					Parallel.ForEach<ActiveUnit>(Enumerable.ToList<ActiveUnit>(this.activeUnit_0.vmethod_7(false).activeUnit_0), new Action<ActiveUnit>(@class.method_0));
					List<ActiveUnit> list = Enumerable.ToList<ActiveUnit>(@class.concurrentBag_0);
					if (!Information.IsNothing(excludeUnit) && list.Contains(excludeUnit))
					{
						list.Remove(excludeUnit);
					}
					if (list.Count > 0)
					{
						int index = GameGeneral.smethod_5().Next(0, list.Count);
						this.method_12(false, list[index]);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100155", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0009C90C File Offset: 0x0009AB0C
		public void method_44()
		{
			try
			{
				List<ActiveUnit> list = new List<ActiveUnit>();
				if (!Information.IsNothing(this.method_17()))
				{
					this.method_12(false, this.method_17());
				}
				else
				{
					List<ActiveUnit> list2 = Enumerable.ToList<ActiveUnit>(this.activeUnit_0.vmethod_7(false).activeUnit_0);
					try
					{
						foreach (ActiveUnit activeUnit in list2)
						{
							if (Operators.CompareString(this.method_45(activeUnit), "OK", false) == 0)
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
						double num = 99999999999.0;
						ActiveUnit value;
						try
						{
							foreach (ActiveUnit activeUnit2 in list)
							{
								double num2 = (double)Math2.smethod_15(activeUnit2.vmethod_30(null), activeUnit2.vmethod_28(null), this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null));
								if (num2 < num)
								{
									num = num2;
									value = activeUnit2;
								}
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						this.method_12(false, value);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100156", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0009CAD0 File Offset: 0x0009ACD0
		public string method_45(ActiveUnit activeUnit_3)
		{
			string result;
			try
			{
				int num;
				DockFacility.Enum50 enum50_;
				if (this.activeUnit_0.bool_6)
				{
					num = (int)Math.Round((double)((Ship)this.activeUnit_0).float_13);
					enum50_ = ((Ship)this.activeUnit_0).enum50_0;
				}
				else
				{
					if (!this.activeUnit_0.bool_5)
					{
						return "Not possible";
					}
					num = (int)Math.Round((double)((Submarine)this.activeUnit_0).float_13);
					enum50_ = ((Submarine)this.activeUnit_0).enum50_0;
				}
				if (activeUnit_3.vmethod_93().method_41((short)num, enum50_))
				{
					result = "OK";
				}
				else
				{
					result = "The boat cannot be hosted on any docking facility here";
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100157", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = "Not possible (Error!)";
			}
			return result;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0009CBC0 File Offset: 0x0009ADC0
		private DockFacility method_46(ActiveUnit activeUnit_3)
		{
			List<DockFacility> list = new List<DockFacility>();
			DockFacility result;
			try
			{
				DockFacility dockFacility = null;
				int num;
				DockFacility.Enum50 enum50_;
				if (activeUnit_3.bool_6)
				{
					num = (int)Math.Round((double)((Ship)activeUnit_3).float_13);
					enum50_ = ((Ship)activeUnit_3).enum50_0;
				}
				else
				{
					if (!activeUnit_3.bool_5)
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw new NotImplementedException();
					}
					num = (int)Math.Round((double)((Submarine)activeUnit_3).float_13);
					enum50_ = ((Submarine)activeUnit_3).enum50_0;
				}
				if (this.method_40(activeUnit_3, ref dockFacility) && !Information.IsNothing(dockFacility))
				{
					result = dockFacility;
				}
				else
				{
					foreach (DockFacility dockFacility2 in this.activeUnit_0.vmethod_100())
					{
						if (dockFacility2.method_26((short)num, enum50_) && dockFacility2.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
						{
							list.Add(dockFacility2);
						}
					}
					if (list.Count > 0)
					{
						result = Enumerable.ElementAtOrDefault<DockFacility>(Enumerable.OrderBy<DockFacility, int>(list, (ActiveUnit_DockingOps._Closure$__.$I123-0 == null) ? (ActiveUnit_DockingOps._Closure$__.$I123-0 = new Func<DockFacility, int>(ActiveUnit_DockingOps._Closure$__.$I.method_8)) : ActiveUnit_DockingOps._Closure$__.$I123-0), 0);
					}
					else
					{
						result = null;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100158", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0009CD34 File Offset: 0x0009AF34
		private void method_47(float float_3)
		{
			try
			{
				if (!Information.IsNothing(this.method_17()))
				{
					string name = this.method_17().Name;
					ActiveUnit activeUnit = this.method_17();
					this.method_17();
					this.activeUnit_0.vmethod_29(null, this.method_17().vmethod_28(null));
					this.activeUnit_0.vmethod_31(null, this.method_17().vmethod_30(null));
					this.activeUnit_0.vmethod_15(false, 0f);
					this.activeUnit_0.vmethod_41((float)(0.6666666666666666 * (double)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), ActiveUnit.Throttle.Loiter, false)));
					this.activeUnit_0.vmethod_71(this.activeUnit_0.vmethod_40());
					this.activeUnit_0.vmethod_10(this.method_17().vmethod_9());
					this.method_16(null);
					this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
					this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
					this.activeUnit_0.vmethod_86().vmethod_10(float_3, true, true);
					this.activeUnit_0.vmethod_86().vmethod_25();
					this.activeUnit_0.vmethod_86().vmethod_11(float_3, false, false);
					if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.Unassigned)
					{
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " departed " + name + " and is waiting for orders.", "Docking operations", LoggedMessage.MessageType.DockingOps, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
					}
					else if (this.activeUnit_0.method_122() && Information.IsNothing(this.activeUnit_0.vmethod_101()))
					{
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " departed " + name + " and is waiting for orders.", "Docking operations", LoggedMessage.MessageType.DockingOps, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
					}
					else
					{
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " departed " + name + ".", "Docking operations", LoggedMessage.MessageType.DockingOps, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
					}
					if (!Information.IsNothing(activeUnit) && ActiveUnit_DockingOps.smethod_10(activeUnit))
					{
						double double_;
						double double_2;
						Class411.smethod_1(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null), ref double_, ref double_2, 6.6499999999999995, (double)activeUnit.vmethod_9());
						this.activeUnit_0.vmethod_85().method_51(0, new Waypoint(double_, double_2, 0f, Waypoint.WaypointType.ManualPlottedCourseWaypoint, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0));
						this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
					}
					this.activeUnit_0.vmethod_88().vmethod_4(true);
					this.activeUnit_0.vmethod_88().vmethod_5(this.activeUnit_0.method_78());
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100159", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0009D0C8 File Offset: 0x0009B2C8
		public void method_48(ActiveUnit theHost, bool CancelDeployment = false)
		{
			DockFacility dockFacility;
			if (CancelDeployment && !Information.IsNothing(this.method_17()))
			{
				dockFacility = this.method_15();
			}
			else
			{
				dockFacility = theHost.vmethod_93().method_46(this.activeUnit_0);
				if (Information.IsNothing(dockFacility))
				{
					return;
				}
			}
			try
			{
				this.method_16(dockFacility);
				if (CancelDeployment)
				{
					this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Docked);
					this.method_1(0f);
				}
				else
				{
					this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Docking);
				}
				if (!Information.IsNothing(this.activeUnit_0.vmethod_101()))
				{
					if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Ferry)
					{
						switch (((FerryMission)this.activeUnit_0.vmethod_101()).method_65())
						{
						case FerryMission.FerryMissionBehavior.OneWay:
						{
							ActiveUnit activeUnit = this.activeUnit_0;
							Mission value = null;
							bool setMissionOnly = false;
							Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
							activeUnit.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
							this.method_12(false, this.method_17());
							break;
						}
						case FerryMission.FerryMissionBehavior.Cycle:
							this.activeUnit_0.vmethod_86().method_41();
							break;
						case FerryMission.FerryMissionBehavior.Random:
							this.method_43(this.method_11(false));
							break;
						}
					}
					if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support && ((Class344)this.activeUnit_0.vmethod_101()).bool_23)
					{
						ActiveUnit activeUnit2 = this.activeUnit_0;
						Mission value2 = null;
						bool setMissionOnly2 = false;
						Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
						activeUnit2.vmethod_102(value2, setMissionOnly2, ref missionAssignmentAttemptResult);
					}
				}
				if (this.activeUnit_0.method_120() && this.activeUnit_0.vmethod_65(false) != this.method_17().vmethod_65(false))
				{
					this.activeUnit_0.method_129(false, true, false);
				}
				this.activeUnit_0.method_126();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100160", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0009D294 File Offset: 0x0009B494
		private void method_49()
		{
			this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Docked);
			this.method_56(this.activeUnit_0.vmethod_101());
			ActiveUnit_DockingOps.smethod_13(this.activeUnit_0, this.method_17(), Enumerable.ToList<Cargo>(this.activeUnit_0.cargo_0));
			this.method_50();
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00007A2E File Offset: 0x00005C2E
		public void method_50()
		{
			this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.Readying);
			this.method_1(1800f);
			this.method_52();
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0009D2E0 File Offset: 0x0009B4E0
		public bool method_51()
		{
			ActiveUnit_DockingOps._DockingOpsCondition dockingOpsCondition = this.method_8();
			return dockingOpsCondition == ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0009D300 File Offset: 0x0009B500
		public void method_52()
		{
			try
			{
				try
				{
					foreach (Sensor sensor in this.activeUnit_0.vmethod_95())
					{
						if (sensor.method_66())
						{
							sensor.method_22(true);
						}
					}
				}
				finally
				{
					List<Sensor>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100161", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0009D3A4 File Offset: 0x0009B5A4
		public List<ActiveUnit> method_53(bool bool_0, List<Mission> list_1, ref string string_7)
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			List<ActiveUnit> result;
			try
			{
				Doctrine.Enum56? @enum = this.activeUnit_0.doctrine_0.method_152(this.activeUnit_0.scenario_0, false, false, false, false);
				byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					string_7 = "Unit " + this.activeUnit_0.Name + " has a doctrine setting that disallows UNREP. As such, the unit will not refuel. Change the doctrine setting and try again.";
					result = list;
				}
				else
				{
					int num = 0;
					string_7 = "No UNREP units are available.";
					try
					{
						foreach (ActiveUnit activeUnit in this.activeUnit_0.scenario_0.method_42())
						{
							if (activeUnit != null && activeUnit != this.activeUnit_0 && (activeUnit.vmethod_7(false) == this.activeUnit_0.vmethod_7(false) || activeUnit.vmethod_7(false).method_67(this.activeUnit_0.vmethod_7(false))) && activeUnit.vmethod_127())
							{
								if (activeUnit.method_85())
								{
									if (num < 1)
									{
										num = 1;
										string_7 = "Tanker is RTB.";
									}
								}
								else if (!activeUnit.vmethod_105(this.activeUnit_0))
								{
									if (num < 2)
									{
										num = 2;
										string_7 = string.Concat(new string[]
										{
											"Unit ",
											activeUnit.Name,
											" is an UNREP unit but cannot UNREP ",
											this.activeUnit_0.Name,
											"."
										});
									}
								}
								else
								{
									if (list_1 != null)
									{
										if (activeUnit.vmethod_101() == null)
										{
											if (num < 3)
											{
												num = 3;
												string_7 = "Mission " + list_1[0].Name + " has no available tankers.";
												continue;
											}
											continue;
										}
										else
										{
											bool flag = true;
											try
											{
												foreach (Mission mission in list_1)
												{
													if (activeUnit.vmethod_101() == mission)
													{
														flag = false;
														break;
													}
												}
											}
											finally
											{
												List<Mission>.Enumerator enumerator2;
												((IDisposable)enumerator2).Dispose();
											}
											if (flag)
											{
												if (num < 4)
												{
													num = 4;
													string_7 = "Mission " + activeUnit.vmethod_101().Name + " has no available tankers.";
													continue;
												}
												continue;
											}
										}
									}
									if (this.activeUnit_0.bool_4 && bool_0)
									{
										ActiveUnit_AI activeUnit_AI = this.activeUnit_0.vmethod_86();
										Unit unit_ = activeUnit;
										float? nullable_ = null;
										float float_ = 0f;
										float? nullable_2 = null;
										float float_2 = this.activeUnit_0.vmethod_9();
										ActiveUnit.Throttle throttle = ActiveUnit.Throttle.Full;
										float? nullable_3 = new float?(0.15f);
										bool bool_ = true;
										bool bool_2 = false;
										bool flag2 = false;
										if (!activeUnit_AI.method_61(unit_, nullable_, float_, nullable_2, float_2, throttle, nullable_3, bool_, bool_2, ref flag2))
										{
											if (num < 5)
											{
												num = 5;
												string_7 = "Unit" + this.activeUnit_0.Name + " cannot reach a replenishment provider. A possible reason could be that there are too many receivers in queue.";
												continue;
											}
											continue;
										}
									}
									list.Add(activeUnit);
								}
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					result = list;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100163", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<ActiveUnit>();
			}
			return result;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0009D724 File Offset: 0x0009B924
		public ValueTuple<ActiveUnit_DockingOps.Enum32, string> method_54(GeoPoint IntermediateTargetPoint, ActiveUnit theSelectedTanker, List<Mission> theSelectedMissions, bool IsManualOrder, int? DistanceLimit = null)
		{
			ActiveUnit_DockingOps.Class196 @class = new ActiveUnit_DockingOps.Class196(@class);
			@class.activeUnit_DockingOps_0 = this;
			@class.geoPoint_0 = IntermediateTargetPoint;
			@class.nullable_0 = DistanceLimit;
			ValueTuple<ActiveUnit_DockingOps.Enum32, string> result;
			try
			{
				if (theSelectedTanker != null)
				{
					if (theSelectedTanker.bool_1)
					{
						if (((Group)theSelectedTanker).method_147() == null)
						{
							return new ValueTuple<ActiveUnit_DockingOps.Enum32, string>(ActiveUnit_DockingOps.Enum32.const_2, "The selected group has Not group lead");
						}
						theSelectedTanker = ((Group)theSelectedTanker).method_147();
					}
					ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker resultOfAttemptToRendezvousWithTanker = this.method_55(theSelectedTanker);
					if (resultOfAttemptToRendezvousWithTanker == ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Success)
					{
						result = new ValueTuple<ActiveUnit_DockingOps.Enum32, string>(ActiveUnit_DockingOps.Enum32.const_1, string.Empty);
					}
					else
					{
						result = new ValueTuple<ActiveUnit_DockingOps.Enum32, string>(ActiveUnit_DockingOps.Enum32.const_2, Misc.smethod_67(resultOfAttemptToRendezvousWithTanker));
					}
				}
				else
				{
					bool bool_ = true;
					string empty = string.Empty;
					List<ActiveUnit> list = this.method_53(bool_, theSelectedMissions, ref empty);
					if (@class.nullable_0 != null)
					{
						list = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list, new Func<ActiveUnit, bool>(@class.method_0)));
						if (list.Count == 0)
						{
							string text = this.activeUnit_0.Name + " has no suitable UNREP destination within " + ((@class.nullable_0 != null) ? Conversions.ToString(@class.nullable_0.GetValueOrDefault()) : null) + " nm - aborting UNREP attempt.";
							if (IsManualOrder)
							{
								this.activeUnit_0.method_124(text, "No suitable UNREP provider found", LoggedMessage.MessageType.DockingOps, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							}
							return new ValueTuple<ActiveUnit_DockingOps.Enum32, string>(ActiveUnit_DockingOps.Enum32.const_3, text);
						}
					}
					if (list.Contains(this.activeUnit_0.vmethod_93().method_11(false)) && this.method_55(this.activeUnit_0.vmethod_93().method_11(false)) == ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Success)
					{
						result = new ValueTuple<ActiveUnit_DockingOps.Enum32, string>(ActiveUnit_DockingOps.Enum32.const_1, string.Empty);
					}
					else
					{
						if (@class.geoPoint_0 == null)
						{
							ActiveUnit_DockingOps.Class198 class2 = new ActiveUnit_DockingOps.Class198(class2);
							class2.class196_0 = @class;
							class2.activeUnit_0 = this.method_2();
							if (class2.activeUnit_0 == null)
							{
								IEnumerable<ActiveUnit> enumerable = Enumerable.OrderBy<ActiveUnit, double>(list, new Func<ActiveUnit, double>(this.method_59));
								try
								{
									foreach (ActiveUnit activeUnit_ in enumerable)
									{
										if (this.method_55(activeUnit_) == ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Success)
										{
											return new ValueTuple<ActiveUnit_DockingOps.Enum32, string>(ActiveUnit_DockingOps.Enum32.const_1, string.Empty);
										}
									}
									goto IL_477;
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
							ActiveUnit_DockingOps.Class197 class3 = new ActiveUnit_DockingOps.Class197(class3);
							class3.class198_0 = class2;
							class3.double_0 = this.activeUnit_0.method_31(class3.class198_0.activeUnit_0);
							IEnumerable<ActiveUnit> enumerable2 = Enumerable.OrderBy<ActiveUnit, double>(Enumerable.Where<ActiveUnit>(list, new Func<ActiveUnit, bool>(class3.method_0)), new Func<ActiveUnit, double>(this.method_60));
							if (Enumerable.Count<ActiveUnit>(enumerable2) > 0)
							{
								try
								{
									foreach (ActiveUnit activeUnit_2 in enumerable2)
									{
										if (this.method_55(activeUnit_2) == ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Success)
										{
											return new ValueTuple<ActiveUnit_DockingOps.Enum32, string>(ActiveUnit_DockingOps.Enum32.const_1, string.Empty);
										}
									}
									goto IL_477;
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
							ActiveUnit._ActiveUnitFuelState activeUnitFuelState = this.activeUnit_0.vmethod_62(class3.class198_0.activeUnit_0, null, null);
							if (activeUnitFuelState != ActiveUnit._ActiveUnitFuelState.IsBingo && activeUnitFuelState != ActiveUnit._ActiveUnitFuelState.IsJoker)
							{
								goto IL_477;
							}
							IEnumerable<ActiveUnit> enumerable3 = Enumerable.OrderBy<ActiveUnit, double>(list, new Func<ActiveUnit, double>(this.method_61));
							try
							{
								foreach (ActiveUnit activeUnit_3 in enumerable3)
								{
									if (this.method_55(activeUnit_3) == ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Success)
									{
										return new ValueTuple<ActiveUnit_DockingOps.Enum32, string>(ActiveUnit_DockingOps.Enum32.const_1, string.Empty);
									}
								}
								goto IL_477;
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
						ActiveUnit_DockingOps.Class199 class4 = new ActiveUnit_DockingOps.Class199(class4);
						class4.class196_0 = @class;
						class4.double_0 = this.activeUnit_0.method_28(class4.class196_0.geoPoint_0);
						IEnumerable<ActiveUnit> enumerable4 = Enumerable.OrderBy<ActiveUnit, double>(Enumerable.Where<ActiveUnit>(list, new Func<ActiveUnit, bool>(class4.method_0)), new Func<ActiveUnit, double>(this.method_62));
						if (Enumerable.Count<ActiveUnit>(enumerable4) > 0)
						{
							try
							{
								foreach (ActiveUnit activeUnit_4 in enumerable4)
								{
									if (this.method_55(activeUnit_4) == ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Success)
									{
										return new ValueTuple<ActiveUnit_DockingOps.Enum32, string>(ActiveUnit_DockingOps.Enum32.const_1, string.Empty);
									}
								}
								goto IL_477;
							}
							finally
							{
								IEnumerator<ActiveUnit> enumerator4;
								if (enumerator4 != null)
								{
									enumerator4.Dispose();
								}
							}
						}
						IEnumerable<ActiveUnit> enumerable5 = Enumerable.OrderBy<ActiveUnit, double>(list, new Func<ActiveUnit, double>(class4.class196_0.method_1));
						try
						{
							foreach (ActiveUnit activeUnit_5 in enumerable5)
							{
								if (this.method_55(activeUnit_5) == ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Success)
								{
									return new ValueTuple<ActiveUnit_DockingOps.Enum32, string>(ActiveUnit_DockingOps.Enum32.const_1, string.Empty);
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
						IL_477:
						result = new ValueTuple<ActiveUnit_DockingOps.Enum32, string>(ActiveUnit_DockingOps.Enum32.const_2, "Failed to schedule a replenishment rendezvous");
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100164", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ValueTuple<ActiveUnit_DockingOps.Enum32, string>(ActiveUnit_DockingOps.Enum32.const_2, "Failed - Unknown error");
			}
			return result;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0009DC90 File Offset: 0x0009BE90
		public ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker method_55(ActiveUnit activeUnit_3)
		{
			ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker result;
			try
			{
				if (this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling)
				{
					result = ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Success;
				}
				else if (activeUnit_3.bool_4 && this.activeUnit_0.bool_4 && !((Interface5)activeUnit_3).imethod_10() && ((Interface5)activeUnit_3).imethod_6() < ((Interface5)this.activeUnit_0).imethod_6())
				{
					result = ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Fail_ProviderSmallerThanReceiver;
				}
				else if (activeUnit_3.vmethod_93().method_36(this.activeUnit_0) <= 0 && activeUnit_3.vmethod_93().method_37(this.activeUnit_0) <= 0)
				{
					result = ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Fail_NoSuitableFuelOrStoresToTransfer;
				}
				else if (this.activeUnit_0.bool_8)
				{
					this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
					this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.ManoeuveringToRefuel);
					this.method_7(activeUnit_3);
					result = ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Success;
				}
				else
				{
					ActiveUnit_AI activeUnit_AI = this.activeUnit_0.vmethod_86();
					float? nullable_ = null;
					float float_ = 0f;
					float? nullable_2 = null;
					float float_2 = this.activeUnit_0.vmethod_9();
					ActiveUnit.Throttle throttle = ActiveUnit.Throttle.Cruise;
					float? nullable_3 = new float?(0.25f);
					bool bool_ = true;
					bool bool_2 = false;
					bool flag = false;
					if (activeUnit_AI.method_61(activeUnit_3, nullable_, float_, nullable_2, float_2, throttle, nullable_3, bool_, bool_2, ref flag))
					{
						this.activeUnit_0.vmethod_109(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
						this.method_9(ActiveUnit_DockingOps._DockingOpsCondition.ManoeuveringToRefuel);
						this.method_7(activeUnit_3);
						result = ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Success;
					}
					else
					{
						result = ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Fail_CannotIntercept;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100165", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Fail_Unknown;
			}
			return result;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0009DE18 File Offset: 0x0009C018
		public static void smethod_13(ActiveUnit activeUnit_3, ActiveUnit activeUnit_4, List<Cargo> list_1)
		{
			try
			{
				if (list_1.Count != 0)
				{
					try
					{
						foreach (Cargo cargo in list_1)
						{
							if (Enumerable.Contains<Cargo>(activeUnit_3.cargo_0, cargo))
							{
								Class429.smethod_7(ref activeUnit_3.cargo_0, cargo);
								Class429.smethod_6(ref activeUnit_4.cargo_0, cargo);
								Scenario.CargoMovement.Add(new Tuple<string, CargoTracker>(activeUnit_3.string_0, new CargoTracker(cargo, 0, 1)));
								Scenario.CargoMovement.Add(new Tuple<string, CargoTracker>(activeUnit_4.string_0, new CargoTracker(cargo, 1, 0)));
							}
							else
							{
								try
								{
									foreach (Mount mount in activeUnit_3.vmethod_51())
									{
										if (((Mount)cargo.method_25()).DBID == mount.DBID)
										{
											activeUnit_3.vmethod_51().method_6(mount);
											Class429.smethod_6(ref activeUnit_4.cargo_0, cargo);
											Scenario.CargoMovement.Add(new Tuple<string, CargoTracker>(activeUnit_3.string_0, new CargoTracker(cargo, 0, 1)));
											Scenario.CargoMovement.Add(new Tuple<string, CargoTracker>(activeUnit_4.string_0, new CargoTracker(cargo, 1, 0)));
											break;
										}
									}
								}
								finally
								{
									List<Mount>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
							}
						}
					}
					finally
					{
						List<Cargo>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (activeUnit_3.method_6() && activeUnit_3.vmethod_51().Count == 0)
					{
						activeUnit_3.scenario_0.method_66(activeUnit_3.string_0, true);
						try
						{
							foreach (ActiveUnit activeUnit in activeUnit_4.scenario_0.method_42())
							{
								if (activeUnit != null && activeUnit.vmethod_86().method_8() == activeUnit_3)
								{
									activeUnit.vmethod_86().method_9(null);
								}
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101370", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0009E084 File Offset: 0x0009C284
		private void method_56(Mission mission_0)
		{
			try
			{
				foreach (IEventExporter eventExporter in this.activeUnit_0.scenario_0.method_6())
				{
					if (eventExporter.imethod_8() && eventExporter.imethod_27() && !Information.IsNothing(this.activeUnit_0.vmethod_7(false)))
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
						dictionary.Add("Action", new IEventExporter.EventNotificationParameter("Docking", typeof(string), 0));
						dictionary.Add("DepartureHostID", new IEventExporter.EventNotificationParameter(string.Empty, typeof(string), 0));
						dictionary.Add("DepartureHostName", new IEventExporter.EventNotificationParameter(string.Empty, typeof(string), 0));
						if (!Information.IsNothing(this.method_17()))
						{
							dictionary.Add("ArrivalHostID", new IEventExporter.EventNotificationParameter(this.method_17().string_0, typeof(string), 0));
							dictionary.Add("ArrivalHostName", new IEventExporter.EventNotificationParameter(this.method_17().Name, typeof(string), 0));
						}
						dictionary.Add("MissionID", new IEventExporter.EventNotificationParameter((mission_0 == null) ? string.Empty : mission_0.string_0, typeof(string), 0));
						dictionary.Add("MissionName", new IEventExporter.EventNotificationParameter((mission_0 == null) ? string.Empty : mission_0.Name, typeof(string), 0));
						dictionary.Add("TotalFuel", new IEventExporter.EventNotificationParameter(Conversions.ToString(this.activeUnit_0.vmethod_116()), typeof(int), 0));
						eventExporter.imethod_6(IEventExporter.ExportedEventType.DockingOps, dictionary, this.activeUnit_0.scenario_0);
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

		// Token: 0x06000943 RID: 2371 RVA: 0x0009E4DC File Offset: 0x0009C6DC
		[CompilerGenerated]
		private double method_57(GeoPoint geoPoint_0)
		{
			return Math2.smethod_14(geoPoint_0.imethod_2(), geoPoint_0.imethod_0(), this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null));
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0009E524 File Offset: 0x0009C724
		[CompilerGenerated]
		private float method_58(ReferencePoint referencePoint_0)
		{
			return referencePoint_0.method_12(this.method_11(false).vmethod_28(null), this.method_11(false).vmethod_30(null));
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00007A48 File Offset: 0x00005C48
		[CompilerGenerated]
		private double method_59(ActiveUnit activeUnit_3)
		{
			return activeUnit_3.method_31(this.activeUnit_0);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00007A48 File Offset: 0x00005C48
		[CompilerGenerated]
		private double method_60(ActiveUnit activeUnit_3)
		{
			return activeUnit_3.method_31(this.activeUnit_0);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00007A48 File Offset: 0x00005C48
		[CompilerGenerated]
		private double method_61(ActiveUnit activeUnit_3)
		{
			return activeUnit_3.method_31(this.activeUnit_0);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00007A48 File Offset: 0x00005C48
		[CompilerGenerated]
		private double method_62(ActiveUnit activeUnit_3)
		{
			return activeUnit_3.method_31(this.activeUnit_0);
		}

		// Token: 0x04000629 RID: 1577
		protected ActiveUnit activeUnit_0;

		// Token: 0x0400062A RID: 1578
		private DockFacility dockFacility_0;

		// Token: 0x0400062B RID: 1579
		private string string_0;

		// Token: 0x0400062C RID: 1580
		private ActiveUnit activeUnit_1;

		// Token: 0x0400062D RID: 1581
		private string string_1;

		// Token: 0x0400062E RID: 1582
		private string string_2;

		// Token: 0x0400062F RID: 1583
		private ActiveUnit activeUnit_2;

		// Token: 0x04000630 RID: 1584
		private string string_3;

		// Token: 0x04000631 RID: 1585
		public string string_4;

		// Token: 0x04000632 RID: 1586
		public string string_5;

		// Token: 0x04000633 RID: 1587
		public string string_6;

		// Token: 0x04000634 RID: 1588
		[CompilerGenerated]
		[AccessedThroughProperty("UNREP_Queue")]
		private List<string> list_0;

		// Token: 0x04000635 RID: 1589
		private ActiveUnit_DockingOps._DockingOpsCondition _DockingOpsCondition_0;

		// Token: 0x04000636 RID: 1590
		private float float_0;

		// Token: 0x04000637 RID: 1591
		private ActiveUnit_DockingOps._DockingOpsCondition _DockingOpsCondition_1;

		// Token: 0x04000638 RID: 1592
		internal ActiveUnit_DockingOps._DockingOpsCondition _DockingOpsCondition_2;

		// Token: 0x04000639 RID: 1593
		internal float float_1;

		// Token: 0x0400063A RID: 1594
		internal ActiveUnit.Throttle throttle_0;

		// Token: 0x0400063B RID: 1595
		[CompilerGenerated]
		private static ActiveUnit_DockingOps.Delegate17 delegate17_0;

		// Token: 0x0400063C RID: 1596
		[CompilerGenerated]
		private static ActiveUnit_DockingOps.Delegate18 delegate18_0;

		// Token: 0x0400063D RID: 1597
		public float float_2;

		// Token: 0x0400063E RID: 1598
		[CompilerGenerated]
		private static ActiveUnit_DockingOps.Delegate19 delegate19_0;

		// Token: 0x0400063F RID: 1599
		private Geopoint_Struct[] geopoint_Struct_0;

		// Token: 0x04000640 RID: 1600
		[CompilerGenerated]
		private static ActiveUnit_DockingOps.Delegate20 delegate20_0;

		// Token: 0x04000641 RID: 1601
		public static object object_0 = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000642 RID: 1602
		public static Lazy<Random> lazy_0 = new Lazy<Random>();

		// Token: 0x02000148 RID: 328
		// (Invoke) Token: 0x0600094C RID: 2380
		internal delegate void Delegate17(ActiveUnit theBoat);

		// Token: 0x02000149 RID: 329
		// (Invoke) Token: 0x06000950 RID: 2384
		internal delegate void Delegate18(ActiveUnit theBoat);

		// Token: 0x0200014A RID: 330
		// (Invoke) Token: 0x06000954 RID: 2388
		internal delegate void Delegate19(string UnitObjectID);

		// Token: 0x0200014B RID: 331
		// (Invoke) Token: 0x06000958 RID: 2392
		internal delegate void Delegate20(ActiveUnit theUnit, object oldStatus);

		// Token: 0x0200014C RID: 332
		public enum _DockingOpsCondition : byte
		{
			// Token: 0x04000644 RID: 1604
			Underway,
			// Token: 0x04000645 RID: 1605
			Docked,
			// Token: 0x04000646 RID: 1606
			DeployingUnderway,
			// Token: 0x04000647 RID: 1607
			Docking,
			// Token: 0x04000648 RID: 1608
			RTB,
			// Token: 0x04000649 RID: 1609
			Readying,
			// Token: 0x0400064A RID: 1610
			ManoeuveringToRefuel,
			// Token: 0x0400064B RID: 1611
			Replenishing,
			// Token: 0x0400064C RID: 1612
			ProvidingUNREP,
			// Token: 0x0400064D RID: 1613
			RechargingBatteries,
			// Token: 0x0400064E RID: 1614
			SettlingForCargoTransfer
		}

		// Token: 0x0200014D RID: 333
		internal enum Enum32
		{
			// Token: 0x04000650 RID: 1616
			const_0,
			// Token: 0x04000651 RID: 1617
			const_1,
			// Token: 0x04000652 RID: 1618
			const_2,
			// Token: 0x04000653 RID: 1619
			const_3
		}

		// Token: 0x0200014E RID: 334
		public enum ResultOfAttemptToRendezvousWithTanker
		{
			// Token: 0x04000655 RID: 1621
			None,
			// Token: 0x04000656 RID: 1622
			Success,
			// Token: 0x04000657 RID: 1623
			Fail_Unknown,
			// Token: 0x04000658 RID: 1624
			Fail_NoSuitableFuelOrStoresToTransfer,
			// Token: 0x04000659 RID: 1625
			Fail_CannotIntercept,
			// Token: 0x0400065A RID: 1626
			Fail_ProviderSmallerThanReceiver
		}

		// Token: 0x02000150 RID: 336
		[CompilerGenerated]
		internal sealed class Class191
		{
			// Token: 0x06000964 RID: 2404 RVA: 0x00007ABD File Offset: 0x00005CBD
			public Class191(ActiveUnit_DockingOps.Class191 class191_0)
			{
				if (class191_0 != null)
				{
					this.fuelRec_0 = class191_0.fuelRec_0;
				}
			}

			// Token: 0x06000965 RID: 2405 RVA: 0x00007AD4 File Offset: 0x00005CD4
			internal bool method_0(FuelRec fuelRec_1)
			{
				return fuelRec_1._FuelType_0 == this.fuelRec_0._FuelType_0 & fuelRec_1.float_0 > 0f;
			}

			// Token: 0x04000665 RID: 1637
			public FuelRec fuelRec_0;
		}

		// Token: 0x02000151 RID: 337
		[CompilerGenerated]
		internal sealed class Class192
		{
			// Token: 0x06000966 RID: 2406 RVA: 0x00007AF7 File Offset: 0x00005CF7
			public Class192(ActiveUnit_DockingOps.Class192 class192_0)
			{
				if (class192_0 != null)
				{
					this.fuelRec_0 = class192_0.fuelRec_0;
				}
			}

			// Token: 0x06000967 RID: 2407 RVA: 0x00007B0E File Offset: 0x00005D0E
			internal bool method_0(FuelRec fuelRec_1)
			{
				return fuelRec_1._FuelType_0 == this.fuelRec_0._FuelType_0 && fuelRec_1.float_0 > 0f;
			}

			// Token: 0x04000666 RID: 1638
			public FuelRec fuelRec_0;
		}

		// Token: 0x02000152 RID: 338
		[CompilerGenerated]
		internal sealed class Class193
		{
			// Token: 0x06000968 RID: 2408 RVA: 0x00007B32 File Offset: 0x00005D32
			public Class193(ActiveUnit_DockingOps.Class193 class193_0)
			{
				if (class193_0 != null)
				{
					this.fuelRec_0 = class193_0.fuelRec_0;
				}
			}

			// Token: 0x06000969 RID: 2409 RVA: 0x00007B49 File Offset: 0x00005D49
			internal bool method_0(FuelRec fuelRec_1)
			{
				return fuelRec_1._FuelType_0 == this.fuelRec_0._FuelType_0 && fuelRec_1.float_0 > 0f;
			}

			// Token: 0x04000667 RID: 1639
			public FuelRec fuelRec_0;
		}

		// Token: 0x02000153 RID: 339
		[CompilerGenerated]
		internal sealed class Class194
		{
			// Token: 0x0600096A RID: 2410 RVA: 0x00007B6D File Offset: 0x00005D6D
			public Class194(ActiveUnit_DockingOps.Class194 class194_0)
			{
				if (class194_0 != null)
				{
					this.fuelRec_0 = class194_0.fuelRec_0;
				}
			}

			// Token: 0x0600096B RID: 2411 RVA: 0x00007B84 File Offset: 0x00005D84
			internal bool method_0(FuelRec fuelRec_1)
			{
				return fuelRec_1._FuelType_0 == this.fuelRec_0._FuelType_0 && fuelRec_1.float_0 > 0f;
			}

			// Token: 0x04000668 RID: 1640
			public FuelRec fuelRec_0;
		}

		// Token: 0x02000154 RID: 340
		[CompilerGenerated]
		internal sealed class Class195
		{
			// Token: 0x0600096D RID: 2413 RVA: 0x0009E564 File Offset: 0x0009C764
			internal void method_0(ActiveUnit activeUnit_0)
			{
				if (activeUnit_0 != this.activeUnit_DockingOps_0.activeUnit_0 && this.activeUnit_DockingOps_0.activeUnit_0.method_36(activeUnit_0) <= this.float_0 && Operators.CompareString(this.activeUnit_DockingOps_0.method_45(activeUnit_0), "OK", false) == 0)
				{
					this.concurrentBag_0.Add(activeUnit_0);
				}
			}

			// Token: 0x04000669 RID: 1641
			public float float_0;

			// Token: 0x0400066A RID: 1642
			public ConcurrentBag<ActiveUnit> concurrentBag_0;

			// Token: 0x0400066B RID: 1643
			public ActiveUnit_DockingOps activeUnit_DockingOps_0;
		}

		// Token: 0x02000155 RID: 341
		[CompilerGenerated]
		internal sealed class Class196
		{
			// Token: 0x0600096E RID: 2414 RVA: 0x00007BA8 File Offset: 0x00005DA8
			public Class196(ActiveUnit_DockingOps.Class196 class196_0)
			{
				if (class196_0 != null)
				{
					this.nullable_0 = class196_0.nullable_0;
					this.geoPoint_0 = class196_0.geoPoint_0;
				}
			}

			// Token: 0x0600096F RID: 2415 RVA: 0x00007BCB File Offset: 0x00005DCB
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return this.activeUnit_DockingOps_0.activeUnit_0.method_36(activeUnit_0) <= (float)this.nullable_0.Value;
			}

			// Token: 0x06000970 RID: 2416 RVA: 0x00007BEF File Offset: 0x00005DEF
			internal double method_1(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.method_28(this.geoPoint_0);
			}

			// Token: 0x0400066C RID: 1644
			public int? nullable_0;

			// Token: 0x0400066D RID: 1645
			public GeoPoint geoPoint_0;

			// Token: 0x0400066E RID: 1646
			public ActiveUnit_DockingOps activeUnit_DockingOps_0;
		}

		// Token: 0x02000156 RID: 342
		[CompilerGenerated]
		internal sealed class Class197
		{
			// Token: 0x06000971 RID: 2417 RVA: 0x00007BFD File Offset: 0x00005DFD
			public Class197(ActiveUnit_DockingOps.Class197 class197_0)
			{
				if (class197_0 != null)
				{
					this.double_0 = class197_0.double_0;
				}
			}

			// Token: 0x06000972 RID: 2418 RVA: 0x00007C14 File Offset: 0x00005E14
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return this.class198_0.class196_0.activeUnit_DockingOps_0.activeUnit_0.method_31(activeUnit_0) < this.double_0 && activeUnit_0.method_31(this.class198_0.activeUnit_0) < this.double_0;
			}

			// Token: 0x0400066F RID: 1647
			public double double_0;

			// Token: 0x04000670 RID: 1648
			public ActiveUnit_DockingOps.Class198 class198_0;
		}

		// Token: 0x02000157 RID: 343
		[CompilerGenerated]
		internal sealed class Class198
		{
			// Token: 0x06000973 RID: 2419 RVA: 0x00007C54 File Offset: 0x00005E54
			public Class198(ActiveUnit_DockingOps.Class198 class198_0)
			{
				if (class198_0 != null)
				{
					this.activeUnit_0 = class198_0.activeUnit_0;
				}
			}

			// Token: 0x04000671 RID: 1649
			public ActiveUnit activeUnit_0;

			// Token: 0x04000672 RID: 1650
			public ActiveUnit_DockingOps.Class196 class196_0;
		}

		// Token: 0x02000158 RID: 344
		[CompilerGenerated]
		internal sealed class Class199
		{
			// Token: 0x06000974 RID: 2420 RVA: 0x00007C6B File Offset: 0x00005E6B
			public Class199(ActiveUnit_DockingOps.Class199 class199_0)
			{
				if (class199_0 != null)
				{
					this.double_0 = class199_0.double_0;
				}
			}

			// Token: 0x06000975 RID: 2421 RVA: 0x00007C82 File Offset: 0x00005E82
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return this.class196_0.activeUnit_DockingOps_0.activeUnit_0.method_31(activeUnit_0) < this.double_0 && activeUnit_0.method_28(this.class196_0.geoPoint_0) < this.double_0;
			}

			// Token: 0x04000673 RID: 1651
			public double double_0;

			// Token: 0x04000674 RID: 1652
			public ActiveUnit_DockingOps.Class196 class196_0;
		}
	}
}
