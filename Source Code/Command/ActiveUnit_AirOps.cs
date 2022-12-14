using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns12;
using ns13;

namespace Command_Core
{
	// Token: 0x0200013B RID: 315
	public class ActiveUnit_AirOps
	{
		// Token: 0x06000888 RID: 2184 RVA: 0x0008FCC4 File Offset: 0x0008DEC4
		public virtual void vmethod_0(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("ActiveUnit_AirOps");
				if (Enumerable.Count<Aircraft>(this.aircraft_0) > 0)
				{
					xmlWriter_0.WriteStartElement("LandingQueue");
					foreach (Aircraft aircraft in this.aircraft_0)
					{
						if (!Information.IsNothing(aircraft))
						{
							xmlWriter_0.WriteElementString("ID", aircraft.string_0);
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100071", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0008FD80 File Offset: 0x0008DF80
		public static ActiveUnit_AirOps smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			ActiveUnit_AirOps result;
			try
			{
				ActiveUnit_AirOps activeUnit_AirOps = new ActiveUnit_AirOps();
				activeUnit_AirOps.activeUnit_0 = activeUnit_1;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "LandingQueue", false) == 0)
						{
							try
							{
								foreach (object obj2 in xmlNode.ChildNodes)
								{
									XmlNode xmlNode2 = (XmlNode)obj2;
									Class429.smethod_32(ref activeUnit_AirOps.string_0, xmlNode2.InnerText);
								}
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
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = activeUnit_AirOps;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100072", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ActiveUnit_AirOps();
			}
			return result;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0008FEA8 File Offset: 0x0008E0A8
		public virtual void vmethod_1(ref Scenario scenario_0, Dictionary<string, Class310> dictionary_0, bool bool_0)
		{
			foreach (string text in this.string_0)
			{
				try
				{
					if (!Information.IsNothing(text))
					{
						Aircraft aircraft_ = (Aircraft)scenario_0.vmethod_0()[text];
						Class429.smethod_2(ref this.aircraft_0, aircraft_);
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100073", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x000077B8 File Offset: 0x000059B8
		private ActiveUnit_AirOps()
		{
			this.aircraft_0 = new Aircraft[0];
			this.string_0 = new string[0];
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0008FF44 File Offset: 0x0008E144
		public virtual GlobalVariables.Enum146 vmethod_2()
		{
			GlobalVariables.Enum146 result;
			try
			{
				GlobalVariables.Enum146 @enum = GlobalVariables.Enum146.const_0;
				foreach (AirFacility airFacility in this.activeUnit_0.vmethod_99())
				{
					if (airFacility.enum146_0 > @enum)
					{
						@enum = airFacility.enum146_0;
					}
				}
				result = @enum;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100074", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = GlobalVariables.Enum146.const_0;
			}
			return result;
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0008FFDC File Offset: 0x0008E1DC
		public virtual GlobalVariables.AircraftSizeClass vmethod_3()
		{
			GlobalVariables.AircraftSizeClass result;
			try
			{
				GlobalVariables.AircraftSizeClass aircraftSizeClass = GlobalVariables.AircraftSizeClass.None;
				foreach (AirFacility airFacility in this.activeUnit_0.vmethod_99())
				{
					if ((airFacility.method_31() || airFacility.method_32()) && airFacility.method_29() > aircraftSizeClass)
					{
						aircraftSizeClass = airFacility.method_29();
					}
				}
				result = aircraftSizeClass;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100075", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = GlobalVariables.AircraftSizeClass.None;
			}
			return result;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00090080 File Offset: 0x0008E280
		public virtual List<Aircraft> vmethod_4()
		{
			List<Aircraft> result;
			try
			{
				List<Aircraft> list = new List<Aircraft>();
				foreach (AirFacility airFacility in this.activeUnit_0.vmethod_99())
				{
					try
					{
						foreach (Aircraft item in airFacility.method_24().Values)
						{
							list.Add(item);
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
				result = list;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100076", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Aircraft>();
			}
			return result;
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00090150 File Offset: 0x0008E350
		public virtual Aircraft[] vmethod_5()
		{
			Aircraft[] array = new Aircraft[0];
			Aircraft[] result;
			try
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.activeUnit_0.scenario_0.method_42())
					{
						if (!Information.IsNothing(activeUnit) && activeUnit.bool_3 && activeUnit.vmethod_127())
						{
							Aircraft_AirOps aircraft_AirOps = ((Aircraft)activeUnit).method_164();
							if (aircraft_AirOps.method_36() == Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown)
							{
								if (aircraft_AirOps.method_21() != null && aircraft_AirOps.method_21() == this.activeUnit_0)
								{
									Class429.smethod_2(ref array, (Aircraft)activeUnit);
								}
								else if ((aircraft_AirOps.method_21() == null || aircraft_AirOps.method_21() == this.activeUnit_0) && aircraft_AirOps.method_32(true) == this.activeUnit_0)
								{
									Class429.smethod_2(ref array, (Aircraft)activeUnit);
								}
							}
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = array;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100077", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0009028C File Offset: 0x0008E48C
		public ReadOnlyCollection<AirFacility> method_0(bool? nullable_0, Aircraft aircraft_1, ActiveUnit activeUnit_1, IEnumerable<AirFacility> ienumerable_0)
		{
			ReadOnlyCollection<AirFacility> result;
			try
			{
				if (Enumerable.Count<AirFacility>(ienumerable_0) == 0)
				{
					result = null;
				}
				else
				{
					DateTime dateTime = activeUnit_1.scenario_0.method_31();
					List<AirFacility> list = new List<AirFacility>();
					try
					{
						foreach (AirFacility airFacility in ienumerable_0)
						{
							if (aircraft_1.aircraftSizeClass_0 <= airFacility.method_29())
							{
								int num = 0;
								if (airFacility.method_28() == AirFacility.Enum110.const_12)
								{
									num = airFacility.int_0;
								}
								else if (aircraft_1.aircraftSizeClass_0 == airFacility.method_29())
								{
									num = 1;
								}
								else if (aircraft_1._AircraftType_0 != Aircraft._AircraftType.Fighter && aircraft_1._AircraftType_0 != Aircraft._AircraftType.Attack && aircraft_1._AircraftType_0 != Aircraft._AircraftType.Multirole && aircraft_1._AircraftType_0 != Aircraft._AircraftType.OECM && aircraft_1._AircraftType_0 != Aircraft._AircraftType.WildWeasel && aircraft_1._AircraftType_0 != Aircraft._AircraftType.Trainer && aircraft_1._AircraftType_0 != Aircraft._AircraftType.Recon)
								{
									num = 1;
								}
								else if (Class418.smethod_1(activeUnit_1.scenario_0, dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, true, activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), 0.0) != Weather.TTimeOfDayType.const_0)
								{
									num = 1;
								}
								else
								{
									num = 2;
								}
								if (Information.IsNothing(nullable_0))
								{
									try
									{
										foreach (Aircraft aircraft in airFacility.method_24().Values)
										{
											if (aircraft.method_164().method_36() != Aircraft_AirOps._AirOpsCondition.TaxyingToTakeOff)
											{
												if (aircraft.method_164().method_36() != Aircraft_AirOps._AirOpsCondition.TaxyingToPark)
												{
													num--;
													if (num != 0)
													{
														continue;
													}
													break;
												}
											}
											num = 0;
											IL_1A7:
											goto IL_2F6;
										}
										goto IL_1A7;
									}
									finally
									{
										IEnumerator<Aircraft> enumerator2;
										if (enumerator2 != null)
										{
											enumerator2.Dispose();
										}
									}
									goto IL_1B8;
								}
								goto IL_1B8;
								IL_2E9:
								list.Add(airFacility);
								continue;
								IL_1B8:
								if (((nullable_0 != null) ? new bool?(!nullable_0.GetValueOrDefault()) : nullable_0).GetValueOrDefault())
								{
									try
									{
										foreach (Aircraft aircraft2 in airFacility.method_24().Values)
										{
											if (aircraft2.method_164().method_36() != Aircraft_AirOps._AirOpsCondition.TaxyingToTakeOff)
											{
												if (aircraft2.method_164().method_36() != Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck)
												{
													if (aircraft_1.DBID != aircraft2.DBID && airFacility.method_28() != AirFacility.Enum110.const_12)
													{
														num = 0;
														break;
													}
													num--;
													if (num != 0)
													{
														continue;
													}
													break;
												}
											}
											num = 0;
											IL_255:
											goto IL_2F6;
										}
										goto IL_255;
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
								try
								{
									foreach (Aircraft aircraft3 in airFacility.method_24().Values)
									{
										if (aircraft3.method_164().method_36() != Aircraft_AirOps._AirOpsCondition.TaxyingToPark)
										{
											if (aircraft3.method_164().method_36() != Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck)
											{
												if (aircraft_1.DBID != aircraft3.DBID && airFacility.method_28() != AirFacility.Enum110.const_12)
												{
													num = 0;
													break;
												}
												num--;
												if (num != 0)
												{
													continue;
												}
												break;
											}
										}
										num = 0;
										IL_2DB:
										goto IL_2F6;
									}
									goto IL_2DB;
								}
								finally
								{
									IEnumerator<Aircraft> enumerator4;
									if (enumerator4 != null)
									{
										enumerator4.Dispose();
									}
								}
								goto IL_2E9;
								IL_2F6:
								if (num > 0)
								{
									goto IL_2E9;
								}
							}
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
					result = list.AsReadOnly();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100078", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<AirFacility>().AsReadOnly();
			}
			return result;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00090670 File Offset: 0x0008E870
		public IEnumerable<AirFacility> method_1(ActiveUnit activeUnit_1)
		{
			IEnumerable<AirFacility> result;
			try
			{
				List<AirFacility> list = new List<AirFacility>();
				foreach (AirFacility airFacility in activeUnit_1.vmethod_99())
				{
					if (airFacility.method_35() && airFacility.vmethod_5() == PlatformComponent._ComponentStatus.Operational && airFacility.method_35())
					{
						list.Add(airFacility);
					}
				}
				result = list.AsReadOnly();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100079", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<AirFacility>().AsReadOnly();
			}
			return result;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00090720 File Offset: 0x0008E920
		public ReadOnlyCollection<AirFacility> method_2(bool bool_0, bool bool_1, Aircraft aircraft_1, ActiveUnit activeUnit_1, bool bool_2, IEnumerable<AirFacility> ienumerable_0)
		{
			ReadOnlyCollection<AirFacility> result;
			if (Enumerable.Count<AirFacility>(ienumerable_0) == 0)
			{
				result = null;
			}
			else
			{
				DateTime dateTime = activeUnit_1.scenario_0.method_31();
				try
				{
					List<AirFacility> list = new List<AirFacility>();
					List<Aircraft> list2 = new List<Aircraft>();
					if (!bool_1)
					{
						foreach (Aircraft item in activeUnit_1.vmethod_92().vmethod_5())
						{
							list2.Add(item);
						}
					}
					try
					{
						foreach (AirFacility airFacility in ienumerable_0)
						{
							if (aircraft_1.aircraftSizeClass_0 <= airFacility.method_29())
							{
								int num = 0;
								if (airFacility.method_28() != AirFacility.Enum110.const_1)
								{
									num = 1;
								}
								else if (aircraft_1.aircraftSizeClass_0 == airFacility.method_27())
								{
									num = 1;
								}
								else if (aircraft_1._AircraftType_0 != Aircraft._AircraftType.Fighter && aircraft_1._AircraftType_0 != Aircraft._AircraftType.Attack && aircraft_1._AircraftType_0 != Aircraft._AircraftType.Multirole && aircraft_1._AircraftType_0 != Aircraft._AircraftType.OECM && aircraft_1._AircraftType_0 != Aircraft._AircraftType.WildWeasel && aircraft_1._AircraftType_0 != Aircraft._AircraftType.Trainer && aircraft_1._AircraftType_0 != Aircraft._AircraftType.Recon)
								{
									num = 1;
								}
								else if (Class418.smethod_1(activeUnit_1.scenario_0, dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, true, activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), 0.0) != Weather.TTimeOfDayType.const_0)
								{
									num = 1;
								}
								else
								{
									num = 2;
								}
								if (bool_1)
								{
									try
									{
										foreach (Aircraft aircraft in airFacility.method_24().Values)
										{
											if (aircraft.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.TakingOff)
											{
												num = 0;
											}
											else if (aircraft_1.DBID == aircraft.DBID)
											{
												num--;
												if (num != 0)
												{
													continue;
												}
											}
											else
											{
												if (!((Aircraft)this.activeUnit_0).method_164().method_72(airFacility, true))
												{
													continue;
												}
												num = 0;
											}
											IL_1FA:
											goto IL_3C8;
										}
										goto IL_1FA;
									}
									finally
									{
										IEnumerator<Aircraft> enumerator2;
										if (enumerator2 != null)
										{
											enumerator2.Dispose();
										}
									}
									goto IL_20B;
								}
								goto IL_20B;
								IL_3C8:
								if (num > 0)
								{
									list.Add(airFacility);
									continue;
								}
								continue;
								IL_20B:
								if (bool_0)
								{
									try
									{
										foreach (Aircraft aircraft2 in airFacility.method_24().Values)
										{
											if (aircraft2.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Landing_PostTouchdown)
											{
												num = 0;
											}
											else if (aircraft_1.DBID == aircraft2.DBID)
											{
												num--;
												if (num != 0)
												{
													continue;
												}
											}
											else
											{
												if (!((Aircraft)this.activeUnit_0).method_164().method_71(airFacility))
												{
													continue;
												}
												num = 0;
											}
											IL_282:
											goto IL_3C8;
										}
										goto IL_282;
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
								if (!bool_1 && !bool_0)
								{
									try
									{
										IEnumerator<Aircraft> enumerator4 = airFacility.method_24().Values.GetEnumerator();
										while (enumerator4.MoveNext())
										{
											if (enumerator4.Current.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.TakingOff)
											{
												num = 0;
												break;
											}
										}
									}
									finally
									{
										IEnumerator<Aircraft> enumerator4;
										if (enumerator4 != null)
										{
											enumerator4.Dispose();
										}
									}
									if (list2.Count <= 0 || num <= 0)
									{
										goto IL_3C8;
									}
									List<Aircraft> list3 = new List<Aircraft>();
									try
									{
										foreach (Aircraft aircraft3 in list2)
										{
											if (aircraft_1.DBID == aircraft3.DBID)
											{
												list3.Add(aircraft3);
												num--;
												if (num != 0)
												{
													continue;
												}
											}
											else
											{
												if (!((Aircraft)this.activeUnit_0).method_164().method_72(airFacility, true))
												{
													continue;
												}
												list3.Add(aircraft3);
												num = 0;
											}
											break;
										}
									}
									finally
									{
										List<Aircraft>.Enumerator enumerator5;
										((IDisposable)enumerator5).Dispose();
									}
									try
									{
										foreach (Aircraft item2 in list3)
										{
											list2.Remove(item2);
										}
										goto IL_3C8;
									}
									finally
									{
										List<Aircraft>.Enumerator enumerator6;
										((IDisposable)enumerator6).Dispose();
									}
								}
								if (Debugger.IsAttached)
								{
									Debugger.Break();
									goto IL_3C8;
								}
								goto IL_3C8;
							}
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
					result = list.AsReadOnly();
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100080", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<AirFacility>().AsReadOnly();
				}
			}
			return result;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00090C08 File Offset: 0x0008EE08
		public virtual ReadOnlyCollection<Aircraft> vmethod_6()
		{
			ReadOnlyCollection<Aircraft> result;
			try
			{
				List<Aircraft> list = new List<Aircraft>();
				try
				{
					foreach (ActiveUnit activeUnit in this.activeUnit_0.scenario_0.method_42())
					{
						if (!Information.IsNothing(activeUnit) && activeUnit.bool_3 && ((Aircraft)activeUnit).method_164().method_32(true) == this.activeUnit_0)
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
				result = list.AsReadOnly();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100082", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Aircraft>().AsReadOnly();
			}
			return result;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00090CF4 File Offset: 0x0008EEF4
		public IEnumerable<Aircraft> method_3()
		{
			IEnumerable<Aircraft> result;
			try
			{
				result = Enumerable.AsEnumerable<Aircraft>(Enumerable.Where<Aircraft>(this.vmethod_4(), (ActiveUnit_AirOps._Closure$__.$I23-0 == null) ? (ActiveUnit_AirOps._Closure$__.$I23-0 = new Func<Aircraft, bool>(ActiveUnit_AirOps._Closure$__.$I.method_0)) : ActiveUnit_AirOps._Closure$__.$I23-0));
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100083", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Enumerable.AsEnumerable<Aircraft>(new List<Aircraft>());
			}
			return result;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000077D8 File Offset: 0x000059D8
		public Aircraft[] method_4()
		{
			return this.aircraft_0;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00090D8C File Offset: 0x0008EF8C
		public Geopoint_Struct method_5()
		{
			Geopoint_Struct result;
			try
			{
				float num = Math2.smethod_7(this.activeUnit_0.vmethod_9() + 180f);
				Geopoint_Struct geopoint_Struct;
				Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref geopoint_Struct.double_0, ref geopoint_Struct.double_1, (double)this.method_6(), (double)num);
				result = geopoint_Struct;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100084", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), 0f);
			}
			return result;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x000077E0 File Offset: 0x000059E0
		public float method_6()
		{
			return 10f;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x000077E7 File Offset: 0x000059E7
		public ActiveUnit_AirOps(ref ActiveUnit activeUnit_1)
		{
			this.aircraft_0 = new Aircraft[0];
			this.string_0 = new string[0];
			this.activeUnit_0 = activeUnit_1;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00090E78 File Offset: 0x0008F078
		public void method_7(Aircraft aircraft_1)
		{
			try
			{
				if (!Enumerable.Contains<Aircraft>(this.aircraft_0, aircraft_1))
				{
					Class429.smethod_2(ref this.aircraft_0, aircraft_1);
					aircraft_1.method_164().method_37(Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue);
					aircraft_1.method_164().method_39(5f);
					this.method_12();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100085", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0000780F File Offset: 0x00005A0F
		public void method_8(Aircraft aircraft_1)
		{
			Class429.smethod_3(ref this.aircraft_0, aircraft_1);
			this.method_12();
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00090F0C File Offset: 0x0008F10C
		public void method_9()
		{
			try
			{
				if (Enumerable.Count<Aircraft>(this.aircraft_0) != 0)
				{
					List<Aircraft> list = new List<Aircraft>();
					list.AddRange(this.aircraft_0);
					try
					{
						foreach (Aircraft aircraft in list)
						{
							if (Information.IsNothing(aircraft))
							{
								this.method_8(aircraft);
							}
							else if (aircraft.method_82())
							{
								this.method_8(aircraft);
							}
							if (aircraft.method_164().method_36() != Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue)
							{
								this.method_8(aircraft);
							}
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100086", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00090FF4 File Offset: 0x0008F1F4
		public Aircraft method_10()
		{
			Aircraft result;
			try
			{
				foreach (AirFacility airFacility in this.activeUnit_0.vmethod_99())
				{
					try
					{
						foreach (Aircraft aircraft in airFacility.method_24().Values)
						{
							if (aircraft.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.Landing_PostTouchdown)
							{
								return aircraft;
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
				result = null;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100087", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x000910C4 File Offset: 0x0008F2C4
		public void method_11()
		{
			try
			{
				if (!this.activeUnit_0.bool_1 || this.activeUnit_0.method_111())
				{
					for (int i = this.activeUnit_0.vmethod_99().Length - 1; i >= 0; i += -1)
					{
						AirFacility airFacility = this.activeUnit_0.vmethod_99()[i];
						if (airFacility.method_35())
						{
							try
							{
								IEnumerator<Aircraft> enumerator = airFacility.method_24().Values.GetEnumerator();
								while (enumerator.MoveNext())
								{
									if (enumerator.Current.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.TaxyingToPark)
									{
										return;
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
					int num = 0;
					for (int j = this.activeUnit_0.vmethod_99().Length - 1; j >= 0; j += -1)
					{
						AirFacility airFacility = this.activeUnit_0.vmethod_99()[j];
						if (airFacility.method_35())
						{
							try
							{
								foreach (Aircraft aircraft in airFacility.method_24().Values)
								{
									if (aircraft.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.TaxyingToTakeOff || aircraft.method_164().method_36() == Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck)
									{
										aircraft.method_164().method_37(Aircraft_AirOps._AirOpsCondition.TaxyingToPark);
										num++;
										if (num >= airFacility.method_24().Values.Count)
										{
											return;
										}
									}
								}
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
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100088", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x000912A0 File Offset: 0x0008F4A0
		public void method_12()
		{
			if (Enumerable.Count<Aircraft>(this.aircraft_0) != 0)
			{
				try
				{
					Aircraft[] array = Enumerable.ToArray<Aircraft>(Enumerable.OrderBy<Aircraft, long>(Enumerable.Where<Aircraft>(this.aircraft_0, (ActiveUnit_AirOps._Closure$__.$I36-0 == null) ? (ActiveUnit_AirOps._Closure$__.$I36-0 = new Func<Aircraft, bool>(ActiveUnit_AirOps._Closure$__.$I.method_1)) : ActiveUnit_AirOps._Closure$__.$I36-0), (ActiveUnit_AirOps._Closure$__.$I36-1 == null) ? (ActiveUnit_AirOps._Closure$__.$I36-1 = new Func<Aircraft, long>(ActiveUnit_AirOps._Closure$__.$I.method_2)) : ActiveUnit_AirOps._Closure$__.$I36-1));
					this.aircraft_0 = array;
					foreach (Aircraft aircraft in this.aircraft_0)
					{
						if ((float)aircraft.method_159().vmethod_35(true) >= 20f / aircraft.vmethod_40() * 3600f + 180f)
						{
							break;
						}
						aircraft.method_164().method_37(Aircraft_AirOps._AirOpsCondition.EmergencyLanding);
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200113", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00003024 File Offset: 0x00001224
		public virtual bool vmethod_7(bool bool_0, ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_0, bool bool_1, ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_1, bool bool_2, bool bool_3)
		{
			return false;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x000913BC File Offset: 0x0008F5BC
		public void method_13(ref Aircraft aircraft_1)
		{
			int num = aircraft_1.method_164().method_91();
			if (num > 0)
			{
				aircraft_1.method_124(string.Concat(new string[]
				{
					aircraft_1.Name,
					" (",
					aircraft_1.string_2,
					") has damage that requires an estimated ",
					Misc.smethod_11((long)num, Aircraft_AirOps.Enum44.const_0, false, false),
					" to restore. The repair time will be added to the aircraft's ready-time."
				}), "Air operations", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(aircraft_1.vmethod_28(null), aircraft_1.vmethod_30(null)));
			}
			aircraft_1.method_163().vmethod_4(ActiveUnit_Damage.FireIntensityLevel.NoFire);
			aircraft_1.vmethod_64(false, null, (float)aircraft_1.method_60());
			try
			{
				foreach (PlatformComponent platformComponent in aircraft_1.vmethod_120())
				{
					platformComponent.vmethod_7();
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
			Aircraft_AirOps aircraft_AirOps;
			(aircraft_AirOps = aircraft_1.method_164()).method_39(aircraft_AirOps.method_38() + (float)num);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x000914C8 File Offset: 0x0008F6C8
		public void method_14(ref Aircraft aircraft_1)
		{
			try
			{
				foreach (FuelRec fuelRec in aircraft_1.vmethod_67())
				{
					fuelRec.float_0 = (float)fuelRec.int_0;
				}
				aircraft_1.method_159().vmethod_7();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100090", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00091550 File Offset: 0x0008F750
		public bool method_15(ref Aircraft aircraft_1, Loadout loadout_0, int int_0, bool bool_0)
		{
			bool flag = true;
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			bool result;
			try
			{
				foreach (WeaponRec weaponRec in loadout_0.weaponRec_0)
				{
					int int_ = weaponRec.int_5;
					if (!Weapon.smethod_17(weaponRec.int_5, ref this.activeUnit_0.scenario_0))
					{
						int int_2 = weaponRec.int_2;
						if (dictionary.ContainsKey(int_))
						{
							dictionary[int_] += int_2;
						}
						else
						{
							dictionary.Add(int_, int_2);
						}
					}
				}
				try
				{
					foreach (KeyValuePair<int, int> keyValuePair in dictionary)
					{
						int num = aircraft_1.method_164().method_30().vmethod_89().vmethod_8(keyValuePair.Key);
						if (keyValuePair.Value > num)
						{
							flag = false;
						}
					}
				}
				finally
				{
					Dictionary<int, int>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = flag;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100092", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0009168C File Offset: 0x0008F88C
		public string method_16(ref Aircraft aircraft_1, int int_0, int int_1, bool bool_0, bool bool_1, bool bool_2, bool bool_3, bool bool_4)
		{
			string result;
			try
			{
				Aircraft_AirOps aircraft_AirOps = aircraft_1.method_164();
				if (!Information.IsNothing(aircraft_1.method_167()) && !Information.IsNothing(aircraft_1.method_167().weaponRec_0))
				{
					aircraft_AirOps.method_67();
				}
				bool flag = true;
				if (int_0 == 0)
				{
					if (bool_0)
					{
						aircraft_AirOps.method_39(0f);
					}
					else
					{
						aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.Readying);
						if (aircraft_AirOps.method_38() < 1800f)
						{
							aircraft_AirOps.method_39(1800f);
						}
					}
				}
				else
				{
					aircraft_1.method_168(null);
					aircraft_1.method_161().vmethod_3();
					if (bool_2)
					{
						Loadout loadout = new Loadout(int_0, "tempLoadout", 1, 1, 1, 1, Loadout.LoadoutRole.None, Loadout._LoadoutDayNight.DayOnly, Loadout._LoadoutWeather.None, 0f, 0, 0, false, bool_1, false, 0, 0, 0, 0, Loadout._LoadoutDayNight.DayNight, Doctrine._WeaponState.LoadoutSetting);
						DBFunctions.smethod_49(ref aircraft_1.scenario_0, ref loadout, int_0, bool_1);
						if (!this.method_15(ref aircraft_1, loadout, int_0, bool_1))
						{
							flag = false;
						}
						if (!bool_1 && !flag)
						{
							bool_1 = true;
							loadout = null;
							loadout = new Loadout(int_0, "tempLoadout", 1, 1, 1, 1, Loadout.LoadoutRole.None, Loadout._LoadoutDayNight.DayOnly, Loadout._LoadoutWeather.None, 0f, 0, 0, false, true, false, 0, 0, 0, 0, Loadout._LoadoutDayNight.DayNight, Doctrine._WeaponState.LoadoutSetting);
							DBFunctions.smethod_49(ref aircraft_1.scenario_0, ref loadout, int_0, true);
							if (!this.method_15(ref aircraft_1, loadout, int_0, true))
							{
								flag = false;
							}
							else
							{
								flag = true;
								string str = "";
								if (Operators.CompareString(aircraft_1.Name, aircraft_1.string_2, false) != 0)
								{
									str = " (" + aircraft_1.string_2 + ")";
								}
								if (bool_3)
								{
									GameGeneral.smethod_1("Aircraft: " + aircraft_1.Name + str + " was re-equipped without optional weapons because not enough weapons were available.");
								}
								aircraft_1.method_124("Aircraft: " + aircraft_1.Name + str + " was re-equipped without optional weapons because not enough weapons were available.", "Air operations", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(aircraft_AirOps.method_30().vmethod_28(null), aircraft_AirOps.method_30().vmethod_30(null)));
							}
						}
						if (flag)
						{
							foreach (WeaponRec weaponRec in loadout.weaponRec_0)
							{
								int num = weaponRec.method_9();
								for (int j = 1; j <= num; j++)
								{
									if (!Weapon.smethod_17(weaponRec.int_5, ref this.activeUnit_0.scenario_0))
									{
										ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
										int int_2 = weaponRec.int_5;
										bool bool_5 = true;
										float num2 = 0f;
										activeUnit_Weaponry.vmethod_12(int_2, bool_5, ref num2);
									}
								}
							}
						}
					}
				}
				try
				{
					foreach (Mount mount in aircraft_1.vmethod_51())
					{
						try
						{
							foreach (WeaponRec weaponRec2 in mount.vmethod_10())
							{
								weaponRec2.method_10(weaponRec2.int_2);
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
				finally
				{
					List<Mount>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (flag)
				{
					DBFunctions.smethod_48(ref aircraft_1, int_0, bool_1);
				}
				else
				{
					aircraft_1.method_168(DBFunctions.smethod_45(ref aircraft_1.scenario_0, aircraft_1.DBID));
					if (Information.IsNothing(aircraft_1.method_167()))
					{
						aircraft_1.method_168(DBFunctions.smethod_46(ref aircraft_1.scenario_0, aircraft_1.DBID));
					}
					aircraft_AirOps.method_53(ref aircraft_AirOps);
				}
				if (bool_0)
				{
					aircraft_AirOps.method_39(0f);
				}
				else
				{
					Doctrine.Enum54? @enum = aircraft_1.doctrine_0.method_201(aircraft_1.scenario_0, false, false, false, false);
					byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault() && aircraft_AirOps.method_38() < (float)(aircraft_1.method_167().int_2 * 60) && !aircraft_AirOps.bool_0)
					{
						if (int_0 != int_1 || !bool_3)
						{
							aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.Readying);
							aircraft_AirOps.method_39((float)(aircraft_1.method_167().int_2 * 60));
						}
					}
					else
					{
						@enum = aircraft_1.doctrine_0.method_201(aircraft_1.scenario_0, false, false, false, false);
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && aircraft_AirOps.method_38() < (float)(aircraft_1.method_167().int_3 * 60) && !aircraft_AirOps.bool_0)
						{
							if (int_0 != int_1 || !bool_3)
							{
								aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.Readying);
								aircraft_AirOps.method_39((float)(aircraft_1.method_167().int_3 * 60));
							}
						}
						else if (aircraft_AirOps.method_38() < (float)(aircraft_1.method_167().int_9 * 60) && aircraft_AirOps.bool_0 && (int_0 != int_1 || !bool_3))
						{
							Doctrine.Enum53? enum2 = aircraft_1.doctrine_0.method_196(aircraft_1.scenario_0, false, false, false, false);
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								aircraft_AirOps.method_51(ref aircraft_AirOps, ref aircraft_1);
								string text = "";
								if (Operators.CompareString(aircraft_1.Name, aircraft_1.string_2, false) != 0)
								{
									text = " (" + aircraft_1.string_2 + ")";
								}
								aircraft_1.method_124(string.Concat(new string[]
								{
									aircraft_1.Name,
									text,
									" has flown ",
									Conversions.ToString(aircraft_AirOps.int_1),
									" of ",
									Conversions.ToString(aircraft_1.method_167().int_10),
									" sorties. Total airborne time is ",
									Misc.smethod_11((long)Math.Round((double)aircraft_AirOps.float_1), Aircraft_AirOps.Enum44.const_0, false, false),
									" of allowed ",
									Misc.smethod_11((long)(aircraft_1.method_167().int_12 * 60), Aircraft_AirOps.Enum44.const_0, false, false),
									". The aircraft loadout is set up for Quick Turnaround however the Doctrine settings say No Quick Turnaround, and the aircraft stands down!"
								}), "Air operations", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(aircraft_AirOps.method_30().vmethod_28(null), aircraft_AirOps.method_30().vmethod_30(null)));
								@enum = aircraft_1.doctrine_0.method_201(aircraft_1.scenario_0, false, false, false, false);
								b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.Readying);
									aircraft_AirOps.method_39((float)(aircraft_1.method_167().int_2 * 60));
								}
								else
								{
									aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.Readying);
									aircraft_AirOps.method_39((float)(aircraft_1.method_167().int_3 * 60));
								}
							}
							else
							{
								aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.Readying);
								aircraft_AirOps.method_39((float)(aircraft_1.method_167().int_9 * 60));
							}
						}
					}
					if (!bool_3 && aircraft_AirOps.bool_0)
					{
						Doctrine.Enum53? enum2 = aircraft_1.doctrine_0.method_196(aircraft_1.scenario_0, false, false, false, false);
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							this.method_17(ref aircraft_AirOps, ref aircraft_1);
						}
						else
						{
							enum2 = aircraft_1.doctrine_0.method_196(aircraft_1.scenario_0, false, false, false, false);
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								Loadout loadout2 = aircraft_1.method_167();
								if (loadout2.method_10() || loadout2.method_12() || loadout2.method_11())
								{
									this.method_17(ref aircraft_AirOps, ref aircraft_1);
								}
							}
						}
					}
				}
				aircraft_1.float_26 = 0f;
				if (flag)
				{
					result = "OK";
				}
				else
				{
					string str2 = "";
					if (Operators.CompareString(aircraft_1.Name, aircraft_1.string_2, false) != 0)
					{
						str2 = " (" + aircraft_1.string_2 + ")";
					}
					if (bool_4)
					{
						if (bool_3)
						{
							GameGeneral.smethod_1("Aircraft: " + aircraft_1.Name + str2 + " was not equipped with intended loadout as one or more of the primary stores for that loadout is not available. Reverting to reserve (clean) loadout.");
						}
						aircraft_1.method_124("Aircraft: " + aircraft_1.Name + str2 + " was not equipped with intended loadout as one or more of the primary stores for that loadout is not available. Reverting to reserve (clean) loadout.", "Air operations", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(aircraft_AirOps.method_30().vmethod_28(null), aircraft_AirOps.method_30().vmethod_30(null)));
					}
					result = "Incomplete";
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100093", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = "Error";
			}
			return result;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00092050 File Offset: 0x00090250
		public void method_17(ref Aircraft_AirOps aircraft_AirOps_0, ref Aircraft aircraft_1)
		{
			if (aircraft_AirOps_0.int_1 == 1)
			{
				Doctrine.Enum54? @enum = aircraft_1.doctrine_0.method_201(aircraft_1.scenario_0, false, false, false, false);
				byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					Aircraft_AirOps aircraft_AirOps = aircraft_AirOps_0;
					ref int ptr = ref aircraft_AirOps.int_3;
					aircraft_AirOps.int_3 = ptr + aircraft_1.method_167().int_3;
				}
				else
				{
					Aircraft_AirOps aircraft_AirOps2 = aircraft_AirOps_0;
					ref int ptr = ref aircraft_AirOps2.int_3;
					aircraft_AirOps2.int_3 = ptr + aircraft_1.method_167().int_2;
				}
			}
			else
			{
				Aircraft_AirOps aircraft_AirOps3 = aircraft_AirOps_0;
				ref int ptr = ref aircraft_AirOps3.int_3;
				aircraft_AirOps3.int_3 = ptr + aircraft_1.method_167().int_11;
			}
			DateTime dateTime_ = aircraft_1.scenario_0.method_31();
			bool bool_ = aircraft_1.scenario_0.method_33();
			string text = aircraft_1.scenario_0.method_35();
			string string_ = aircraft_1.scenario_0.method_37();
			Weather.TTimeOfDayType ttimeOfDayType = Class418.smethod_1(aircraft_1.scenario_0, dateTime_.Year, dateTime_.Month, dateTime_.Day, dateTime_.Hour, dateTime_.Minute, dateTime_.Second, true, aircraft_AirOps_0.method_30().vmethod_30(null), aircraft_AirOps_0.method_30().vmethod_28(null), (double)aircraft_AirOps_0.method_30().vmethod_14(false));
			if (aircraft_AirOps_0.int_1 >= aircraft_AirOps_0.int_2)
			{
				aircraft_AirOps_0.method_51(ref aircraft_AirOps_0, ref aircraft_1);
				return;
			}
			if ((double)(aircraft_1.method_167().int_12 * 60) / (double)aircraft_AirOps_0.int_2 <= (double)(aircraft_AirOps_0.float_1 / (float)aircraft_AirOps_0.int_1))
			{
				if (aircraft_AirOps_0.int_1 <= aircraft_AirOps_0.int_2 && aircraft_AirOps_0.int_1 > 0)
				{
					float num = aircraft_AirOps_0.float_1 / (float)aircraft_AirOps_0.int_1;
					if (num + aircraft_AirOps_0.float_1 > (float)(aircraft_1.method_167().int_12 * 60) && !Information.IsNothing(aircraft_1.method_167()))
					{
						string text2 = "";
						if (Operators.CompareString(aircraft_1.Name, aircraft_1.string_2, false) != 0)
						{
							text2 = " (" + aircraft_1.string_2 + ")";
						}
						aircraft_1.method_124(string.Concat(new string[]
						{
							aircraft_1.Name,
							text2,
							" has flown ",
							Conversions.ToString(aircraft_AirOps_0.int_1),
							" of ",
							Conversions.ToString(aircraft_1.method_167().int_10),
							" sorties. Total airborne time is ",
							Misc.smethod_11((long)Math.Round((double)aircraft_AirOps_0.float_1), Aircraft_AirOps.Enum44.const_0, false, false),
							" of allowed ",
							Misc.smethod_11((long)(aircraft_1.method_167().int_12 * 60), Aircraft_AirOps.Enum44.const_0, false, false),
							". Average airborne time for the completed sorties is ",
							Misc.smethod_11((long)Math.Round((double)num), Aircraft_AirOps.Enum44.const_0, false, false),
							" which is greater than the remaining allowed airborne time. Because of this the aircraft needs to stand down."
						}), "Air operations", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(aircraft_AirOps_0.method_30().vmethod_28(null), aircraft_AirOps_0.method_30().vmethod_30(null)));
						aircraft_AirOps_0.method_51(ref aircraft_AirOps_0, ref aircraft_1);
						return;
					}
				}
			}
			else
			{
				if (aircraft_1.method_167()._LoadoutDayNight_1 == Loadout._LoadoutDayNight.DayOnly && ttimeOfDayType == Weather.TTimeOfDayType.const_2)
				{
					string text3 = "";
					if (Operators.CompareString(aircraft_1.Name, aircraft_1.string_2, false) != 0)
					{
						text3 = " (" + aircraft_1.string_2 + ")";
					}
					aircraft_1.method_124(string.Concat(new string[]
					{
						aircraft_1.Name,
						text3,
						" has flown ",
						Conversions.ToString(aircraft_AirOps_0.int_1),
						" of ",
						Conversions.ToString(aircraft_1.method_167().int_10),
						" sorties. Total airborne time is ",
						Misc.smethod_11((long)Math.Round((double)aircraft_AirOps_0.float_1), Aircraft_AirOps.Enum44.const_0, false, false),
						" of allowed ",
						Misc.smethod_11((long)(aircraft_1.method_167().int_12 * 60), Aircraft_AirOps.Enum44.const_0, false, false),
						". The loadout is day-only quick turnaround capable and it is currently night. Because of this the aircraft needs to stand down."
					}), "Air operations", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(aircraft_AirOps_0.method_30().vmethod_28(null), aircraft_AirOps_0.method_30().vmethod_30(null)));
					aircraft_AirOps_0.method_51(ref aircraft_AirOps_0, ref aircraft_1);
					return;
				}
				if (aircraft_1.method_167()._LoadoutDayNight_1 == Loadout._LoadoutDayNight.NightOnly && ttimeOfDayType == Weather.TTimeOfDayType.const_0)
				{
					string text4 = "";
					if (Operators.CompareString(aircraft_1.Name, aircraft_1.string_2, false) != 0)
					{
						text4 = " (" + aircraft_1.string_2 + ")";
					}
					aircraft_1.method_124(string.Concat(new string[]
					{
						aircraft_1.Name,
						text4,
						" has flown ",
						Conversions.ToString(aircraft_AirOps_0.int_1),
						" of ",
						Conversions.ToString(aircraft_1.method_167().int_10),
						" sorties. Total airborne time is ",
						Misc.smethod_11((long)Math.Round((double)aircraft_AirOps_0.float_1), Aircraft_AirOps.Enum44.const_0, false, false),
						" of allowed ",
						Misc.smethod_11((long)(aircraft_1.method_167().int_12 * 60), Aircraft_AirOps.Enum44.const_0, false, false),
						". The loadout is night-only quick turnaround capable and it is currently day. Because of this the aircraft needs to stand down."
					}), "Air operations", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(aircraft_AirOps_0.method_30().vmethod_28(null), aircraft_AirOps_0.method_30().vmethod_30(null)));
					aircraft_AirOps_0.method_51(ref aircraft_AirOps_0, ref aircraft_1);
					return;
				}
				if ((aircraft_1.method_167()._LoadoutDayNight_1 == Loadout._LoadoutDayNight.DayOnly || aircraft_1.method_167()._LoadoutDayNight_1 == Loadout._LoadoutDayNight.NightOnly) && ttimeOfDayType == Weather.TTimeOfDayType.const_1)
				{
					if (aircraft_1.method_167()._LoadoutDayNight_1 == Loadout._LoadoutDayNight.NightOnly && Misc.smethod_10(dateTime_, aircraft_AirOps_0.method_30().vmethod_28(null), bool_, text, string_).Hour < 12)
					{
						string text5 = "";
						if (Operators.CompareString(aircraft_1.Name, aircraft_1.string_2, false) != 0)
						{
							text5 = " (" + aircraft_1.string_2 + ")";
						}
						aircraft_1.method_124(string.Concat(new string[]
						{
							aircraft_1.Name,
							text5,
							" has flown ",
							Conversions.ToString(aircraft_AirOps_0.int_1),
							" of ",
							Conversions.ToString(aircraft_1.method_167().int_10),
							" sorties. Total airborne time is ",
							Misc.smethod_11((long)Math.Round((double)aircraft_AirOps_0.float_1), Aircraft_AirOps.Enum44.const_0, false, false),
							" of allowed ",
							Misc.smethod_11((long)(aircraft_1.method_167().int_12 * 60), Aircraft_AirOps.Enum44.const_0, false, false),
							". The loadout is night-only quick turnaround capable and it is currently dawn. Because of this the aircraft needs to stand down."
						}), "Air operations", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(aircraft_AirOps_0.method_30().vmethod_28(null), aircraft_AirOps_0.method_30().vmethod_30(null)));
						aircraft_AirOps_0.method_51(ref aircraft_AirOps_0, ref aircraft_1);
						return;
					}
					if (aircraft_1.method_167()._LoadoutDayNight_1 == Loadout._LoadoutDayNight.DayOnly && Misc.smethod_10(dateTime_, aircraft_AirOps_0.method_30().vmethod_28(null), bool_, text, string_).Hour > 12)
					{
						string text6 = "";
						if (Operators.CompareString(aircraft_1.Name, aircraft_1.string_2, false) != 0)
						{
							text6 = " (" + aircraft_1.string_2 + ")";
						}
						aircraft_1.method_124(string.Concat(new string[]
						{
							aircraft_1.Name,
							text6,
							" has flown ",
							Conversions.ToString(aircraft_AirOps_0.int_1),
							" of ",
							Conversions.ToString(aircraft_1.method_167().int_10),
							" sorties. Total airborne time is ",
							Misc.smethod_11((long)Math.Round((double)aircraft_AirOps_0.float_1), Aircraft_AirOps.Enum44.const_0, false, false),
							" of allowed ",
							Misc.smethod_11((long)(aircraft_1.method_167().int_12 * 60), Aircraft_AirOps.Enum44.const_0, false, false),
							". The loadout is day-only quick turnaround capable and it is currently dusk. Because of this the aircraft needs to stand down."
						}), "Air operations", LoggedMessage.MessageType.AirOps, 0, false, new Geopoint_Struct(aircraft_AirOps_0.method_30().vmethod_28(null), aircraft_AirOps_0.method_30().vmethod_30(null)));
						aircraft_AirOps_0.method_51(ref aircraft_AirOps_0, ref aircraft_1);
						return;
					}
					aircraft_AirOps_0.method_52(ref aircraft_AirOps_0, ref aircraft_1);
					return;
				}
				else
				{
					aircraft_AirOps_0.method_52(ref aircraft_AirOps_0, ref aircraft_1);
				}
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0009292C File Offset: 0x00090B2C
		public virtual bool vmethod_8(Aircraft aircraft_1)
		{
			bool result;
			try
			{
				if (this.activeUnit_0.bool_6)
				{
					Ship.Enum118 enum118_ = ((Ship)this.activeUnit_0).enum118_0;
					if (enum118_ == Ship.Enum118.const_8)
					{
						return true;
					}
					if (aircraft_1.enum40_0 == Aircraft.Enum40.const_2 && enum118_ != Ship.Enum118.const_2 && aircraft_1.aircraftSizeClass_0 > GlobalVariables.AircraftSizeClass.Small)
					{
						return false;
					}
					if (aircraft_1.enum146_0 == GlobalVariables.Enum146.const_1 && !aircraft_1.method_169() && aircraft_1.aircraftSizeClass_0 != GlobalVariables.AircraftSizeClass.Small && enum118_ != Ship.Enum118.const_2)
					{
						return false;
					}
					if (aircraft_1.enum40_0 == Aircraft.Enum40.const_1 && aircraft_1.enum146_0 != GlobalVariables.Enum146.const_1)
					{
						return false;
					}
				}
				for (int i = this.activeUnit_0.vmethod_99().Length - 1; i >= 0; i += -1)
				{
					AirFacility airFacility = this.activeUnit_0.vmethod_99()[i];
					if (airFacility.vmethod_5() == PlatformComponent._ComponentStatus.Operational && airFacility.method_34() && !airFacility.method_31() && airFacility.method_38(aircraft_1))
					{
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100095", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00092A78 File Offset: 0x00090C78
		public void method_18(Aircraft aircraft_1, bool bool_0)
		{
			try
			{
				if (!this.activeUnit_0.vmethod_92().vmethod_4().Contains(aircraft_1))
				{
					AirFacility airFacility = this.method_19(aircraft_1);
					if (Information.IsNothing(airFacility))
					{
						if (!bool_0)
						{
							GameGeneral.smethod_1("Aircraft parking facilities on " + this.activeUnit_0.Name + " are overfilled. Please contact the scenario author and ask to have the number of aircraft reduced to match the actual parking capacity.");
						}
						foreach (AirFacility airFacility2 in this.activeUnit_0.vmethod_99())
						{
							if (airFacility2.method_34())
							{
								airFacility = airFacility2;
								break;
							}
						}
					}
					aircraft_1.method_164().method_35(airFacility);
					aircraft_1.method_164().method_37(Aircraft_AirOps._AirOpsCondition.Parked);
					aircraft_1.method_164().method_33(false, this.activeUnit_0);
					aircraft_1.method_164().method_31(this.activeUnit_0);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100097", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00092B84 File Offset: 0x00090D84
		public AirFacility method_19(Aircraft aircraft_1)
		{
			AirFacility result;
			try
			{
				List<AirFacility> list = new List<AirFacility>();
				foreach (AirFacility airFacility in this.activeUnit_0.vmethod_99())
				{
					if (airFacility.method_34() && airFacility.method_38(aircraft_1) && airFacility.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
					{
						list.Add(airFacility);
					}
				}
				if (list.Count > 0)
				{
					IEnumerable<AirFacility> enumerable;
					if (this.activeUnit_0.bool_6)
					{
						Ship.Enum118 enum118_ = ((Ship)this.activeUnit_0).enum118_0;
						if ((enum118_ == Ship.Enum118.const_2 || enum118_ == Ship.Enum118.const_7 || enum118_ == Ship.Enum118.const_8) && aircraft_1.method_164().method_38() < 60f && !Information.IsNothing(aircraft_1.method_167()) && aircraft_1.method_167().loadoutRole_0 != Loadout.LoadoutRole.Reserve && aircraft_1.method_167().loadoutRole_0 != Loadout.LoadoutRole.Unavailable)
						{
							enumerable = Enumerable.ThenBy<AirFacility, int>(Enumerable.OrderByDescending<AirFacility, string>(list, (ActiveUnit_AirOps._Closure$__.$I50-0 == null) ? (ActiveUnit_AirOps._Closure$__.$I50-0 = new Func<AirFacility, string>(ActiveUnit_AirOps._Closure$__.$I.method_3)) : ActiveUnit_AirOps._Closure$__.$I50-0), (ActiveUnit_AirOps._Closure$__.$I50-1 == null) ? (ActiveUnit_AirOps._Closure$__.$I50-1 = new Func<AirFacility, int>(ActiveUnit_AirOps._Closure$__.$I.method_4)) : ActiveUnit_AirOps._Closure$__.$I50-1);
							if ((double)Enumerable.ElementAtOrDefault<AirFacility>(enumerable, 0).method_37() / (double)Enumerable.ElementAtOrDefault<AirFacility>(enumerable, 0).method_29() > 4.0)
							{
								return Enumerable.ElementAtOrDefault<AirFacility>(enumerable, 0);
							}
						}
					}
					enumerable = Enumerable.ThenBy<AirFacility, int>(Enumerable.OrderBy<AirFacility, string>(list, (ActiveUnit_AirOps._Closure$__.$I50-2 == null) ? (ActiveUnit_AirOps._Closure$__.$I50-2 = new Func<AirFacility, string>(ActiveUnit_AirOps._Closure$__.$I.method_5)) : ActiveUnit_AirOps._Closure$__.$I50-2), (ActiveUnit_AirOps._Closure$__.$I50-3 == null) ? (ActiveUnit_AirOps._Closure$__.$I50-3 = new Func<AirFacility, int>(ActiveUnit_AirOps._Closure$__.$I.method_6)) : ActiveUnit_AirOps._Closure$__.$I50-3);
					result = Enumerable.ElementAtOrDefault<AirFacility>(enumerable, 0);
				}
				else
				{
					result = null;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100099", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x040005F8 RID: 1528
		protected ActiveUnit activeUnit_0;

		// Token: 0x040005F9 RID: 1529
		protected Aircraft[] aircraft_0;

		// Token: 0x040005FA RID: 1530
		protected string[] string_0;
	}
}
