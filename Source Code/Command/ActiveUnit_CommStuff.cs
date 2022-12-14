using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns13;
using ns14;
using ns9;

namespace Command_Core
{
	// Token: 0x0200013D RID: 317
	public class ActiveUnit_CommStuff
	{
		// Token: 0x060008B1 RID: 2225 RVA: 0x00092DFC File Offset: 0x00090FFC
		public virtual void vmethod_0(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				try
				{
					if (Enumerable.Count<Class312>(this.class312_0) > 0)
					{
						xmlWriter_0.WriteStartElement("CLE");
						Class312[] array = Enumerable.ToArray<Class312>(this.class312_0);
						for (int i = 0; i < array.Length; i++)
						{
							array[i].method_8(ref xmlWriter_0, ref hashSet_0, this.activeUnit_0.scenario_0);
						}
						xmlWriter_0.WriteEndElement();
					}
					bool? flag = this.nullable_0;
					if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						xmlWriter_0.WriteElementString("OOC", "True");
					}
					if (!this.bool_0)
					{
						xmlWriter_0.WriteElementString("ICS", "False");
					}
					if (this.bool_1)
					{
						xmlWriter_0.WriteElementString("HBS", "True");
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100100", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00092F10 File Offset: 0x00091110
		public static ActiveUnit_CommStuff smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			ActiveUnit_CommStuff result;
			try
			{
				ActiveUnit_CommStuff activeUnit_CommStuff = new ActiveUnit_CommStuff();
				activeUnit_CommStuff.activeUnit_0 = activeUnit_1;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "CommLinksEstablished", false) != 0 && Operators.CompareString(name, "CLE", false) != 0)
						{
							if (Operators.CompareString(name, "OOC", false) != 0)
							{
								if (Operators.CompareString(name, "ICS", false) != 0)
								{
									if (Operators.CompareString(name, "HBS", false) == 0)
									{
										activeUnit_CommStuff.bool_1 = Conversions.ToBoolean(xmlNode.InnerText);
									}
								}
								else
								{
									activeUnit_CommStuff.bool_0 = Conversions.ToBoolean(xmlNode.InnerText);
								}
							}
							else
							{
								activeUnit_CommStuff.nullable_0 = new bool?(!Conversions.ToBoolean(xmlNode.InnerText));
							}
						}
						else
						{
							activeUnit_CommStuff.class312_0 = new Class312[xmlNode.ChildNodes.Count - 1 + 1];
							int num = xmlNode.ChildNodes.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								XmlNode xmlNode2 = xmlNode.ChildNodes[i];
								Class312 @class = Class312.smethod_0(ref xmlNode2, ref dictionary_0, ref activeUnit_1);
								activeUnit_CommStuff.class312_0[i] = @class;
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
				result = activeUnit_CommStuff;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100101", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ActiveUnit_CommStuff();
			}
			return result;
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00007858 File Offset: 0x00005A58
		private ActiveUnit_CommStuff()
		{
			this.class312_0 = new Class312[0];
			this.bool_0 = true;
			this.bool_1 = false;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0000787A File Offset: 0x00005A7A
		public ActiveUnit_CommStuff(ref ActiveUnit activeUnit_1)
		{
			this.class312_0 = new Class312[0];
			this.bool_0 = true;
			this.bool_1 = false;
			this.activeUnit_0 = activeUnit_1;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x000930E0 File Offset: 0x000912E0
		public ActiveUnit_CommStuff.Enum31 method_0()
		{
			ActiveUnit_CommStuff.Enum31 result;
			if (this.bool_0)
			{
				result = ActiveUnit_CommStuff.Enum31.const_2;
			}
			else
			{
				result = ActiveUnit_CommStuff.Enum31.const_1;
			}
			return result;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x000078A4 File Offset: 0x00005AA4
		public virtual bool vmethod_1()
		{
			if (this.nullable_0 == null)
			{
				this.nullable_0 = new bool?(true);
			}
			return this.nullable_0.Value;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x000930FC File Offset: 0x000912FC
		public void method_1(ActiveUnit_CommStuff.Enum31 enum31_0, bool bool_2)
		{
			bool? flag = this.nullable_0;
			bool flag2 = flag != null && flag.Value != bool_2;
			this.nullable_0 = new bool?(bool_2);
			if (flag2)
			{
				if (!bool_2)
				{
					if (enum31_0 == ActiveUnit_CommStuff.Enum31.const_1)
					{
						this.bool_0 = false;
					}
					this.activeUnit_0.vmethod_88().method_3();
					this.activeUnit_0.vmethod_88().method_4();
					switch (enum31_0)
					{
					case ActiveUnit_CommStuff.Enum31.const_1:
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " has dropped off the communications network! (Network attack or act of God)", this.activeUnit_0.Name + " now off-grid", LoggedMessage.MessageType.UnitAI, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						return;
					case ActiveUnit_CommStuff.Enum31.const_2:
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " has dropped off the communications network! (All comm devices incapacitated)", this.activeUnit_0.Name + " now off-grid", LoggedMessage.MessageType.UnitAI, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						return;
					case ActiveUnit_CommStuff.Enum31.const_3:
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " has dropped off the communications network (diving deep)", this.activeUnit_0.Name + " now off-grid", LoggedMessage.MessageType.UnitAI, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						return;
					default:
						return;
					}
				}
				else
				{
					this.bool_0 = true;
					this.activeUnit_0.vmethod_88().method_5();
				}
			}
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000078CA File Offset: 0x00005ACA
		public Class312[] method_2()
		{
			return this.class312_0;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x000078D2 File Offset: 0x00005AD2
		public bool method_3()
		{
			return this.bool_1;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x000078DA File Offset: 0x00005ADA
		public void method_4(bool bool_2)
		{
			this.bool_1 = bool_2;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x000078E3 File Offset: 0x00005AE3
		public void method_5(Class312 class312_1)
		{
			Class429.smethod_12(ref this.class312_0, class312_1);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x000932D0 File Offset: 0x000914D0
		public void method_6()
		{
			checked
			{
				if (!this.activeUnit_0.bool_5 || this.activeUnit_0.vmethod_14(false) >= -40f || !this.activeUnit_0.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_9))
				{
					CommDevice[] array = this.activeUnit_0.vmethod_94();
					if (Enumerable.Count<CommDevice>(array) != 0 && Enumerable.Count<CommDevice>(Enumerable.Where<CommDevice>(array, (ActiveUnit_CommStuff._Closure$__.$I23-0 == null) ? (ActiveUnit_CommStuff._Closure$__.$I23-0 = new Func<CommDevice, bool>(ActiveUnit_CommStuff._Closure$__.$I.method_0)) : ActiveUnit_CommStuff._Closure$__.$I23-0)) != 0)
					{
						bool flag = false;
						CommDevice[] array2 = array;
						int i = 0;
						while (i < array2.Length)
						{
							CommDevice commDevice = array2[i];
							if (commDevice.method_27() || commDevice.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
							{
								i++;
							}
							else
							{
								flag = true;
								IL_B1:
								if (!flag)
								{
									if (this.bool_0)
									{
										this.method_1(ActiveUnit_CommStuff.Enum31.const_2, false);
										return;
									}
									return;
								}
								else
								{
									if (this.bool_0)
									{
										this.method_1(ActiveUnit_CommStuff.Enum31.const_0, true);
										return;
									}
									return;
								}
							}
						}
						goto IL_B1;
					}
				}
			}
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x000933B4 File Offset: 0x000915B4
		public void method_7()
		{
			CommDevice[] array = this.activeUnit_0.vmethod_94();
			checked
			{
				if (Enumerable.Count<CommDevice>(array) != 0 && Enumerable.Count<CommDevice>(Enumerable.Where<CommDevice>(array, (ActiveUnit_CommStuff._Closure$__.$I24-0 == null) ? (ActiveUnit_CommStuff._Closure$__.$I24-0 = new Func<CommDevice, bool>(ActiveUnit_CommStuff._Closure$__.$I.method_1)) : ActiveUnit_CommStuff._Closure$__.$I24-0)) != 0)
				{
					ActiveUnit[] array2 = this.method_9();
					if (array2.Length > 0)
					{
						HashSet<CommDevice> hashSet = new HashSet<CommDevice>();
						foreach (ActiveUnit activeUnit in array2)
						{
							bool? flag = null;
							float? num = null;
							foreach (Sensor sensor in activeUnit.vmethod_96())
							{
								if (sensor.method_43() && sensor.method_71())
								{
									foreach (CommDevice commDevice in array)
									{
										if (commDevice.vmethod_5() == PlatformComponent._ComponentStatus.Operational && commDevice.commLinkType_0 != CommDevice.CommLinkType.Land_Line)
										{
											if (num == null)
											{
												num = new float?(this.activeUnit_0.method_37(activeUnit, 0f));
											}
											if (!Class563.smethod_3(commDevice, sensor, num.Value))
											{
												if (!sensor.method_67() && flag == null)
												{
													flag = new bool?(this.activeUnit_0.method_42(activeUnit, ref this.activeUnit_0.scenario_0, false));
												}
												if ((flag | sensor.method_67()).GetValueOrDefault())
												{
													hashSet.Add(commDevice);
												}
											}
										}
									}
								}
							}
						}
						foreach (CommDevice commDevice2 in array)
						{
							if (commDevice2.vmethod_5() == PlatformComponent._ComponentStatus.Operational && commDevice2.commLinkType_0 != CommDevice.CommLinkType.Land_Line)
							{
								if (hashSet.Contains(commDevice2))
								{
									commDevice2.bool_14 = true;
								}
								else
								{
									commDevice2.bool_14 = false;
								}
							}
						}
					}
					else
					{
						foreach (CommDevice commDevice3 in array)
						{
							if (commDevice3.vmethod_5() == PlatformComponent._ComponentStatus.Operational && commDevice3.commLinkType_0 != CommDevice.CommLinkType.Land_Line)
							{
								commDevice3.bool_14 = false;
							}
						}
					}
					bool flag2 = false;
					CommDevice[] array8 = array;
					int n = 0;
					while (n < array8.Length)
					{
						CommDevice commDevice4 = array8[n];
						if (commDevice4.method_27() || commDevice4.vmethod_5() != PlatformComponent._ComponentStatus.Operational || commDevice4.bool_14)
						{
							n++;
						}
						else
						{
							flag2 = true;
							IL_26E:
							if (!flag2)
							{
								if (this.bool_0)
								{
									this.method_1(ActiveUnit_CommStuff.Enum31.const_2, false);
									return;
								}
								return;
							}
							else
							{
								if (this.bool_0)
								{
									this.method_1(ActiveUnit_CommStuff.Enum31.const_0, true);
									return;
								}
								return;
							}
						}
					}
					goto IL_26E;
				}
			}
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00093654 File Offset: 0x00091854
		public bool method_8()
		{
			bool result;
			try
			{
				if ((GameGeneral.smethod_7() | GameGeneral.smethod_6()) && this.activeUnit_0.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_4))
				{
					if (this.activeUnit_0.bool_2 && ((Weapon)this.activeUnit_0).struct36_0.bool_3)
					{
						result = false;
					}
					else
					{
						foreach (Side side in this.activeUnit_0.scenario_0.method_44())
						{
							if (!Information.IsNothing(side) && !Information.IsNothing(this.activeUnit_0.vmethod_7(false)) && side != this.activeUnit_0.vmethod_7(false) && !this.activeUnit_0.vmethod_7(false).method_67(side))
							{
								for (int j = side.method_41(false).Count - 1; j >= 0; j += -1)
								{
									ActiveUnit activeUnit_ = side.method_41(false)[j];
									if (this.method_10(activeUnit_))
									{
										return true;
									}
								}
							}
						}
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
				ex.Data.Add("Error at 100240", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x000937AC File Offset: 0x000919AC
		private ActiveUnit[] method_9()
		{
			ActiveUnit[] array = new ActiveUnit[0];
			ActiveUnit[] result;
			try
			{
				if (!this.activeUnit_0.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_4))
				{
					result = array;
				}
				else if (this.activeUnit_0.bool_2 && ((Weapon)this.activeUnit_0).struct36_0.bool_3)
				{
					result = array;
				}
				else
				{
					foreach (Side side in this.activeUnit_0.scenario_0.method_44())
					{
						if (!Information.IsNothing(side) && !Information.IsNothing(this.activeUnit_0.vmethod_7(false)) && side != this.activeUnit_0.vmethod_7(false) && !this.activeUnit_0.vmethod_7(false).method_67(side))
						{
							for (int j = side.method_41(false).Count - 1; j >= 0; j += -1)
							{
								ActiveUnit activeUnit_ = side.method_41(false)[j];
								if (this.method_10(activeUnit_))
								{
									Class429.smethod_0(ref array, activeUnit_);
								}
							}
						}
					}
					result = array;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100240", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = array;
			}
			return result;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00093908 File Offset: 0x00091B08
		private bool method_10(ActiveUnit activeUnit_1)
		{
			bool result;
			if (Information.IsNothing(activeUnit_1))
			{
				result = false;
			}
			else
			{
				try
				{
					bool flag = false;
					Sensor[] array = activeUnit_1.method_78();
					bool flag2 = false;
					for (int i = array.Length - 1; i >= 0; i += -1)
					{
						Sensor sensor = array[i];
						if (sensor.method_71())
						{
							if (sensor.method_67())
							{
								flag2 = true;
							}
							if (sensor.method_43() && sensor.method_20(this.activeUnit_0, null))
							{
								int j = Enumerable.Count<CommDevice>(this.activeUnit_0.vmethod_94()) - 1;
								while (j >= 0)
								{
									CommDevice commDevice_ = this.activeUnit_0.vmethod_94()[j];
									if (!sensor.method_34(commDevice_))
									{
										j += -1;
									}
									else
									{
										flag = true;
										IL_A3:
										if (!flag)
										{
											goto IL_A6;
										}
										goto IL_B4;
									}
								}
								goto IL_A3;
							}
						}
						IL_A6:;
					}
					IL_B4:
					if (!flag)
					{
						result = false;
					}
					else if (!flag2 && !this.activeUnit_0.method_42(activeUnit_1, ref this.activeUnit_0.scenario_0, false))
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
					ex.Data.Add("Error at 200352", ex.Message);
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

		// Token: 0x060008C1 RID: 2241 RVA: 0x00093A44 File Offset: 0x00091C44
		public virtual void vmethod_2()
		{
			checked
			{
				try
				{
					this.class312_0 = new Class312[0];
					CommDevice[] array = this.activeUnit_0.vmethod_94();
					for (int i = 0; i < array.Length; i++)
					{
						array[i].method_25(0);
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100103", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00093AC8 File Offset: 0x00091CC8
		public virtual bool vmethod_3(CommDevice commDevice_0, ActiveUnit activeUnit_1, bool bool_2)
		{
			if (Information.IsNothing(commDevice_0))
			{
				commDevice_0 = this.method_11(null, activeUnit_1);
			}
			bool result;
			if (Information.IsNothing(commDevice_0))
			{
				result = false;
			}
			else
			{
				try
				{
					Class429.smethod_11(ref this.class312_0, new Class312(ref activeUnit_1, ref commDevice_0));
					Class429.smethod_11(ref activeUnit_1.vmethod_90().class312_0, new Class312(ref this.activeUnit_0, ref commDevice_0));
					commDevice_0.method_25(commDevice_0.method_24() + 1);
					foreach (CommDevice commDevice in activeUnit_1.vmethod_94())
					{
						if ((!bool_2 || !commDevice.bool_12) && commDevice.commLinkType_0 == commDevice_0.commLinkType_0 && commDevice.int_0 > commDevice.method_24())
						{
							commDevice.method_25(commDevice.method_24() + 1);
							return true;
						}
					}
					result = false;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100106", "");
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

		// Token: 0x060008C3 RID: 2243 RVA: 0x00093BD8 File Offset: 0x00091DD8
		public CommDevice method_11(CommDevice[] commDevice_0, ActiveUnit activeUnit_1)
		{
			List<CommDevice> list = new List<CommDevice>();
			CommDevice result;
			try
			{
				if (!activeUnit_1.vmethod_127())
				{
					result = null;
				}
				else if (activeUnit_1.bool_24)
				{
					result = null;
				}
				else
				{
					if (Information.IsNothing(commDevice_0))
					{
						commDevice_0 = this.activeUnit_0.vmethod_94();
					}
					double num = this.activeUnit_0.method_31(activeUnit_1);
					if (double.IsNaN(num))
					{
						num = 0.0;
					}
					if (this.activeUnit_0.bool_2 && activeUnit_1.bool_2)
					{
						result = null;
					}
					else
					{
						foreach (CommDevice commDevice in commDevice_0)
						{
							if (commDevice.vmethod_5() == PlatformComponent._ComponentStatus.Operational && !commDevice.bool_14 && (activeUnit_1.bool_2 || this.activeUnit_0.bool_2 || !commDevice.method_27()) && (activeUnit_1.method_1() || this.activeUnit_0.method_1() || !commDevice.method_28()) && commDevice.method_24() < commDevice.int_0)
							{
								foreach (CommDevice commDevice2 in activeUnit_1.vmethod_94())
								{
									if (commDevice2.commLinkType_0 == commDevice.commLinkType_0 && !commDevice2.bool_14 && commDevice2.int_0 > commDevice2.method_24())
									{
										double num2 = Math2.smethod_13((double)((float)commDevice.double_0));
										if (num <= num2)
										{
											if (commDevice.struct31_0.bool_4)
											{
												bool value;
												if (this.activeUnit_0.bool_7)
												{
													bool? flag;
													if (flag == null)
													{
														Unit unit = this.activeUnit_0;
														ActiveUnit activeUnit = this.activeUnit_0;
														bool flag2 = false;
														flag = new bool?(unit.method_44(activeUnit_1, ref activeUnit.scenario_0, ref flag2, null));
													}
													value = flag.Value;
												}
												else
												{
													bool? flag3;
													if (flag3 == null)
													{
														flag3 = new bool?(this.activeUnit_0.method_42(activeUnit_1, ref this.activeUnit_0.scenario_0, false));
													}
													value = flag3.Value;
												}
												if (!value)
												{
													goto IL_1EF;
												}
											}
											list.Add(commDevice);
										}
									}
									IL_1EF:;
								}
							}
						}
						int count = list.Count;
						if (count != 0)
						{
							if (count != 1)
							{
								double num3 = 20000.0;
								CommDevice commDevice3 = null;
								try
								{
									foreach (CommDevice commDevice4 in list)
									{
										if (commDevice4.double_0 < num3)
										{
											num3 = commDevice4.double_0;
											commDevice3 = commDevice4;
										}
									}
								}
								finally
								{
									List<CommDevice>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
								result = commDevice3;
							}
							else
							{
								result = list[0];
							}
						}
						else
						{
							result = null;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100107", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00093EDC File Offset: 0x000920DC
		protected bool method_12()
		{
			bool result;
			try
			{
				foreach (CommDevice commDevice in this.activeUnit_0.vmethod_94())
				{
					if (commDevice.method_24() < commDevice.int_0)
					{
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100108", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x04000603 RID: 1539
		protected ActiveUnit activeUnit_0;

		// Token: 0x04000604 RID: 1540
		protected Class312[] class312_0;

		// Token: 0x04000605 RID: 1541
		public float float_0;

		// Token: 0x04000606 RID: 1542
		protected bool? nullable_0;

		// Token: 0x04000607 RID: 1543
		protected bool bool_0;

		// Token: 0x04000608 RID: 1544
		protected bool bool_1;

		// Token: 0x0200013E RID: 318
		internal enum Enum31
		{
			// Token: 0x0400060A RID: 1546
			const_0,
			// Token: 0x0400060B RID: 1547
			const_1,
			// Token: 0x0400060C RID: 1548
			const_2,
			// Token: 0x0400060D RID: 1549
			const_3
		}
	}
}
