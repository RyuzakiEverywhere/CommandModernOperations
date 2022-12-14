using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Text;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns14;

namespace Command_Core
{
	// Token: 0x020002D1 RID: 721
	public sealed class CommDevice : PlatformComponent
	{
		// Token: 0x06001558 RID: 5464 RVA: 0x0018FEA4 File Offset: 0x0018E0A4
		public string method_23(ref HashSet<string> hashSet_1)
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
				this.stringBuilder_0.Append("<CD>");
				this.stringBuilder_0.Append("<ID>").Append(this.string_0).Append("</ID>");
				if (!Information.IsNothing(hashSet_1))
				{
					if (hashSet_1.Contains(this.string_0))
					{
						this.stringBuilder_0.Append("</CD>");
						return this.stringBuilder_0.ToString();
					}
					hashSet_1.Add(this.string_0);
				}
				if (this.DBID == 0 && !string.IsNullOrEmpty(this.Name))
				{
					string name = this.Name;
					SQLiteConnection sqliteConnection = base.method_18().scenario_0.method_39();
					this.DBID = DBFunctions.smethod_79(name, ref sqliteConnection);
				}
				if (this._ComponentStatus_0 != PlatformComponent._ComponentStatus.Operational)
				{
					StringBuilder stringBuilder = this.stringBuilder_0.Append("<St>");
					byte componentStatus_ = (byte)this._ComponentStatus_0;
					stringBuilder.Append(componentStatus_.ToString()).Append("</St>");
				}
				this.stringBuilder_0.Append("<DBID>").Append(this.DBID.ToString()).Append("</DBID>");
				this.stringBuilder_0.Append("<OC>").Append(this.int_1.ToString()).Append("</OC>");
				this.stringBuilder_0.Append("<PS>").Append(this.bool_12.ToString()).Append("</PS>");
				if (this.bool_14)
				{
					this.stringBuilder_0.Append("<IJ>True</IJ>");
				}
				if (base.method_16() != PlatformComponent._DamageSeverityFactor.Light)
				{
					this.stringBuilder_0.Append("<DamageSeverity>").Append(((byte)base.method_16()).ToString()).Append("</DamageSeverity>");
				}
				this.stringBuilder_0.Append("</CD>");
				result = this.stringBuilder_0.ToString();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100662", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0000BA29 File Offset: 0x00009C29
		private CommDevice()
		{
			this.struct31_0 = default(CommDevice.Struct31);
			this.bool_12 = true;
			this.hashSet_0 = new HashSet<Sensor.FrequencyBand>();
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00190108 File Offset: 0x0018E308
		public static CommDevice smethod_2(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ActiveUnit activeUnit_1)
		{
			CommDevice result;
			try
			{
				CommDevice commDevice = new CommDevice();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						if (Operators.CompareString(xmlNode.Name, "DBID", false) == 0)
						{
							commDevice.DBID = Conversions.ToInteger(xmlNode.InnerText);
							if (commDevice.DBID > 0)
							{
								commDevice = DBFunctions.smethod_95(Conversions.ToInteger(xmlNode.InnerText), ref activeUnit_1);
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
				try
				{
					foreach (object obj2 in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode2 = (XmlNode)obj2;
						if (Operators.CompareString(xmlNode2.Name, "ID", false) == 0)
						{
							commDevice.vmethod_0(xmlNode2.InnerText);
						}
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
				if (commDevice.DBID > 0)
				{
					try
					{
						foreach (object obj3 in xmlNode_0.ChildNodes)
						{
							XmlNode xmlNode3 = (XmlNode)obj3;
							string name = xmlNode3.Name;
							uint num = Class582.smethod_0(name);
							if (num <= 1258451042U)
							{
								if (num != 6222351U)
								{
									if (num != 1040194900U)
									{
										if (num != 1258451042U)
										{
											continue;
										}
										if (Operators.CompareString(name, "St", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "PS", false) == 0)
										{
											commDevice.bool_12 = Conversions.ToBoolean(xmlNode3.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (Operators.CompareString(name, "Status", false) != 0)
								{
									continue;
								}
								string innerText = xmlNode3.InnerText;
								if (Operators.CompareString(innerText, "Operational", false) != 0)
								{
									if (Operators.CompareString(innerText, "Damaged", false) != 0)
									{
										if (Operators.CompareString(innerText, "Destroyed", false) != 0)
										{
											commDevice._ComponentStatus_0 = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode3.InnerText);
										}
										else
										{
											commDevice._ComponentStatus_0 = PlatformComponent._ComponentStatus.Destroyed;
										}
									}
									else
									{
										commDevice._ComponentStatus_0 = PlatformComponent._ComponentStatus.Damaged;
									}
								}
								else
								{
									commDevice._ComponentStatus_0 = PlatformComponent._ComponentStatus.Operational;
								}
							}
							else if (num <= 1692991850U)
							{
								if (num != 1548823463U)
								{
									if (num == 1692991850U)
									{
										if (Operators.CompareString(name, "IJ", false) == 0)
										{
											commDevice.bool_14 = Conversions.ToBoolean(xmlNode3.InnerText);
										}
									}
								}
								else if (Operators.CompareString(name, "DamageSeverity", false) == 0)
								{
									commDevice.method_17((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode3.InnerText));
								}
							}
							else
							{
								if (num != 2380580039U)
								{
									if (num != 2905213033U)
									{
										continue;
									}
									if (Operators.CompareString(name, "OccupiedChannels", false) != 0)
									{
										continue;
									}
								}
								else if (Operators.CompareString(name, "OC", false) != 0)
								{
									continue;
								}
								commDevice.int_1 = Conversions.ToInteger(xmlNode3.InnerText);
							}
						}
						goto IL_950;
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
				try
				{
					foreach (object obj4 in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode4 = (XmlNode)obj4;
						string name2 = xmlNode4.Name;
						uint num = Class582.smethod_0(name2);
						if (num <= 1548823463U)
						{
							if (num <= 1109584844U)
							{
								if (num != 6222351U)
								{
									if (num != 266367750U)
									{
										if (num != 1109584844U)
										{
											continue;
										}
										if (Operators.CompareString(name2, "Flags", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj5 in xmlNode4.ChildNodes)
											{
												string name3 = ((XmlNode)obj5).Name;
												num = Class582.smethod_0(name3);
												if (num <= 1757675636U)
												{
													if (num <= 969230539U)
													{
														if (num != 328253564U)
														{
															if (num != 553795081U)
															{
																if (num == 969230539U)
																{
																	if (Operators.CompareString(name3, "LF_Radio", false) == 0)
																	{
																		commDevice.struct31_0.bool_9 = true;
																	}
																}
															}
															else if (Operators.CompareString(name3, "Receive_Only", false) == 0)
															{
																commDevice.struct31_0.bool_2 = true;
															}
														}
														else if (Operators.CompareString(name3, "LOS_Limited", false) == 0)
														{
															commDevice.struct31_0.bool_4 = true;
														}
													}
													else if (num != 987648279U)
													{
														if (num != 1471782266U)
														{
															if (num == 1757675636U)
															{
																if (Operators.CompareString(name3, "Broadcast", false) == 0)
																{
																	commDevice.struct31_0.bool_0 = true;
																}
															}
														}
														else if (Operators.CompareString(name3, "UHF_Radio", false) == 0)
														{
															commDevice.struct31_0.bool_13 = true;
														}
													}
													else if (Operators.CompareString(name3, "VLF_Radio", false) == 0)
													{
														commDevice.struct31_0.bool_7 = true;
													}
												}
												else if (num <= 2421138180U)
												{
													if (num != 1986766942U)
													{
														if (num != 2125292527U)
														{
															if (num == 2421138180U)
															{
																if (Operators.CompareString(name3, "SHF_Radio", false) == 0)
																{
																	commDevice.struct31_0.bool_14 = true;
																}
															}
														}
														else if (Operators.CompareString(name3, "HF_Radio", false) == 0)
														{
															commDevice.struct31_0.bool_11 = true;
														}
													}
													else if (Operators.CompareString(name3, "ELF_Radio", false) == 0)
													{
														commDevice.struct31_0.bool_5 = true;
													}
												}
												else if (num <= 3041136386U)
												{
													if (num != 2717875696U)
													{
														if (num == 3041136386U)
														{
															if (Operators.CompareString(name3, "Send_Only", false) == 0)
															{
																commDevice.struct31_0.bool_3 = true;
															}
														}
													}
													else if (Operators.CompareString(name3, "Secure", false) == 0)
													{
														commDevice.struct31_0.bool_1 = true;
													}
												}
												else if (num != 3061779338U)
												{
													if (num == 3288487379U)
													{
														if (Operators.CompareString(name3, "VHF_Radio", false) == 0)
														{
															commDevice.struct31_0.bool_12 = true;
														}
													}
												}
												else if (Operators.CompareString(name3, "MF_Radio", false) == 0)
												{
													commDevice.struct31_0.bool_10 = true;
												}
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
									if (Operators.CompareString(name2, "Name", false) == 0)
									{
										commDevice.Name = xmlNode4.InnerText;
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name2, "Status", false) != 0)
								{
									continue;
								}
							}
							else if (num != 1258451042U)
							{
								if (num != 1458105184U)
								{
									if (num != 1548823463U)
									{
										continue;
									}
									if (Operators.CompareString(name2, "DamageSeverity", false) == 0)
									{
										commDevice.method_17((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode4.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name2, "ID", false) != 0)
									{
										continue;
									}
									if (dictionary_0 == null)
									{
										commDevice.vmethod_0(xmlNode4.InnerText);
										continue;
									}
									if (!dictionary_0.ContainsKey(xmlNode4.InnerText))
									{
										commDevice.vmethod_0(xmlNode4.InnerText);
										dictionary_0.Add(commDevice.string_0, commDevice);
										continue;
									}
									return (CommDevice)dictionary_0[xmlNode4.InnerText];
								}
							}
							else if (Operators.CompareString(name2, "St", false) != 0)
							{
								continue;
							}
							string innerText2 = xmlNode4.InnerText;
							if (Operators.CompareString(innerText2, "Operational", false) != 0)
							{
								if (Operators.CompareString(innerText2, "Damaged", false) != 0)
								{
									if (Operators.CompareString(innerText2, "Destroyed", false) != 0)
									{
										commDevice._ComponentStatus_0 = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode4.InnerText);
									}
									else
									{
										commDevice._ComponentStatus_0 = PlatformComponent._ComponentStatus.Destroyed;
									}
								}
								else
								{
									commDevice._ComponentStatus_0 = PlatformComponent._ComponentStatus.Damaged;
								}
							}
							else
							{
								commDevice._ComponentStatus_0 = PlatformComponent._ComponentStatus.Operational;
							}
						}
						else if (num <= 2018130377U)
						{
							if (num != 1676149913U)
							{
								if (num != 1692991850U)
								{
									if (num == 2018130377U)
									{
										if (Operators.CompareString(name2, "IsOptional", false) == 0)
										{
											commDevice.bool_11 = Conversions.ToBoolean(xmlNode4.InnerText);
										}
									}
								}
								else if (Operators.CompareString(name2, "IJ", false) == 0)
								{
									commDevice.bool_14 = Conversions.ToBoolean(xmlNode4.InnerText);
								}
							}
							else if (Operators.CompareString(name2, "MaxChannels", false) == 0)
							{
								commDevice.int_0 = Conversions.ToInteger(xmlNode4.InnerText);
							}
						}
						else
						{
							if (num <= 2735859570U)
							{
								if (num != 2380580039U)
								{
									if (num != 2735859570U)
									{
										continue;
									}
									if (Operators.CompareString(name2, "Range", false) == 0)
									{
										commDevice.double_0 = XmlConvert.ToDouble(xmlNode4.InnerText);
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name2, "OC", false) != 0)
								{
									continue;
								}
							}
							else if (num != 2905213033U)
							{
								if (num != 3512062061U)
								{
									continue;
								}
								if (Operators.CompareString(name2, "Type", false) != 0)
								{
									continue;
								}
								if (Versioned.IsNumeric(xmlNode4.InnerText))
								{
									commDevice.commLinkType_0 = (CommDevice.CommLinkType)Conversions.ToInteger(xmlNode4.InnerText);
									continue;
								}
								CommDevice.CommLinkType commLinkType = (CommDevice.CommLinkType)Enum.Parse(typeof(CommDevice.CommLinkType), xmlNode4.InnerText, true);
								commDevice.commLinkType_0 = commLinkType;
								continue;
							}
							else if (Operators.CompareString(name2, "OccupiedChannels", false) != 0)
							{
								continue;
							}
							commDevice.int_1 = Conversions.ToInteger(xmlNode4.InnerText);
						}
					}
				}
				finally
				{
					IEnumerator enumerator4;
					if (enumerator4 is IDisposable)
					{
						(enumerator4 as IDisposable).Dispose();
					}
				}
				IL_950:
				result = commDevice;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100663", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0000BA4F File Offset: 0x00009C4F
		public int method_24()
		{
			return this.int_1;
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0000BA57 File Offset: 0x00009C57
		public void method_25(int int_2)
		{
			this.int_1 = int_2;
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00190B34 File Offset: 0x0018ED34
		public bool method_26()
		{
			CommDevice.CommLinkType commLinkType = this.commLinkType_0;
			return commLinkType - CommDevice.CommLinkType.NATO_SonobuoyLink <= 4;
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00190B5C File Offset: 0x0018ED5C
		public CommDevice(ActiveUnit theParent, Scenario theScen, int DeviceDBID, string theName, CommDevice.CommLinkType theType, double theRange, int theMaxChannels, bool DeviceIsOptional = false) : base(theParent)
		{
			this.struct31_0 = default(CommDevice.Struct31);
			this.bool_12 = true;
			this.hashSet_0 = new HashSet<Sensor.FrequencyBand>();
			this.DBID = DeviceDBID;
			this.Name = theName;
			this.commLinkType_0 = theType;
			this.double_0 = theRange;
			this.int_0 = theMaxChannels;
			this.bool_11 = DeviceIsOptional;
			CommDevice commDevice = this;
			DBFunctions.smethod_91(ref commDevice, theScen.method_39());
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00190BCC File Offset: 0x0018EDCC
		public bool method_27()
		{
			int num = (int)this.commLinkType_0;
			if (num != 16 && num != 4011 && num != 5006 && num != 8002 && num != 9001)
			{
				if (num != 9002)
				{
					return num > 10000;
				}
			}
			return true;
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00190C24 File Offset: 0x0018EE24
		public bool method_28()
		{
			return this.commLinkType_0 == CommDevice.CommLinkType.Big_Ball_SATCOM || this.commLinkType_0 == CommDevice.CommLinkType.Commercial_SATCOM || this.commLinkType_0 == CommDevice.CommLinkType.DSCS_SATCOM || this.commLinkType_0 == CommDevice.CommLinkType.USN_FLTSATCOM || this.commLinkType_0 == CommDevice.CommLinkType.MILSTAR_SATCOM || this.commLinkType_0 == CommDevice.CommLinkType.Punch_Bowl_SATCOM || this.commLinkType_0 == CommDevice.CommLinkType.Skynet_SATCOM || this.commLinkType_0 == CommDevice.CommLinkType.SSIXS_SATCOM || this.commLinkType_0 == CommDevice.CommLinkType.Syracuse_SATCOM;
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00190CA8 File Offset: 0x0018EEA8
		public override void vmethod_9(float float_0)
		{
			if (this.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed)
			{
				float num;
				if (float_0 < 0.1f)
				{
					num = 0.05f;
				}
				else if (float_0 < 0.25f)
				{
					num = 0.15f;
				}
				else if (float_0 < 0.5f)
				{
					num = 0.3f;
				}
				else if (float_0 < 0.75f)
				{
					num = 0.5f;
				}
				else
				{
					num = 0.75f;
				}
				if (this.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
				{
					num /= 2f;
				}
				if ((double)num < 0.05)
				{
					num = 0.05f;
				}
				if ((double)num > 0.95)
				{
					num = 0.95f;
				}
				float num2 = num;
				float num3 = (float)((double)num - 0.1);
				float num4 = (float)((double)num - 0.2);
				float num5 = (float)((double)num - 0.3);
				double num6 = GameGeneral.smethod_5().NextDouble();
				if (num6 < (double)num5)
				{
					this.vmethod_6(base.method_18().vmethod_7(false), false, base.method_18().method_6());
					if (!base.method_18().bool_2)
					{
						base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(this.Name) + " has been destroyed!", base.method_18().Name + " lost a comm/datalink", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
						return;
					}
				}
				else
				{
					if (num6 < (double)num4)
					{
						if (!base.method_18().bool_2)
						{
							base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(this.Name) + " has suffered heavy damage.", base.method_18().Name + " had a comm/datalink damaged", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
						}
						this.vmethod_8(PlatformComponent._DamageSeverityFactor.Heavy);
						return;
					}
					if (num6 < (double)num3)
					{
						if (!base.method_18().bool_2)
						{
							base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(this.Name) + " has suffered moderate damage.", base.method_18().Name + " had a comm/datalink damaged", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
						}
						this.vmethod_8(PlatformComponent._DamageSeverityFactor.Medium);
						return;
					}
					if (num6 < (double)num2)
					{
						if (!base.method_18().bool_2)
						{
							base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(this.Name) + " has suffered light damage.", base.method_18().Name + " had a comm/datalink damaged", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
						}
						this.vmethod_8(PlatformComponent._DamageSeverityFactor.Light);
					}
				}
			}
		}

		// Token: 0x0400115B RID: 4443
		public CommDevice.CommLinkType commLinkType_0;

		// Token: 0x0400115C RID: 4444
		public double double_0;

		// Token: 0x0400115D RID: 4445
		public int int_0;

		// Token: 0x0400115E RID: 4446
		public CommDevice.Struct31 struct31_0;

		// Token: 0x0400115F RID: 4447
		private int int_1;

		// Token: 0x04001160 RID: 4448
		public bool bool_11;

		// Token: 0x04001161 RID: 4449
		public bool bool_12;

		// Token: 0x04001162 RID: 4450
		public bool bool_13;

		// Token: 0x04001163 RID: 4451
		public HashSet<Sensor.FrequencyBand> hashSet_0;

		// Token: 0x04001164 RID: 4452
		public bool bool_14;

		// Token: 0x04001165 RID: 4453
		private StringBuilder stringBuilder_0;

		// Token: 0x020002D2 RID: 722
		public enum CommLinkType
		{
			// Token: 0x04001167 RID: 4455
			NONE = 1001,
			// Token: 0x04001168 RID: 4456
			Commercial_SATCOM = 2001,
			// Token: 0x04001169 RID: 4457
			USN_FLTSATCOM,
			// Token: 0x0400116A RID: 4458
			MILSTAR_SATCOM,
			// Token: 0x0400116B RID: 4459
			DSCS_SATCOM,
			// Token: 0x0400116C RID: 4460
			Skynet_SATCOM,
			// Token: 0x0400116D RID: 4461
			Big_Ball_SATCOM,
			// Token: 0x0400116E RID: 4462
			SSIXS_SATCOM,
			// Token: 0x0400116F RID: 4463
			Syracuse_SATCOM,
			// Token: 0x04001170 RID: 4464
			Punch_Bowl_SATCOM,
			// Token: 0x04001171 RID: 4465
			Visual_Comm = 3001,
			// Token: 0x04001172 RID: 4466
			Laser_Comm,
			// Token: 0x04001173 RID: 4467
			Land_Line,
			// Token: 0x04001174 RID: 4468
			Link4 = 4001,
			// Token: 0x04001175 RID: 4469
			Link10,
			// Token: 0x04001176 RID: 4470
			Link11,
			// Token: 0x04001177 RID: 4471
			Link16,
			// Token: 0x04001178 RID: 4472
			Link14,
			// Token: 0x04001179 RID: 4473
			LinkW = 4008,
			// Token: 0x0400117A RID: 4474
			LinkY,
			// Token: 0x0400117B RID: 4475
			LinkZ,
			// Token: 0x0400117C RID: 4476
			AKT22_Datalink = 5001,
			// Token: 0x0400117D RID: 4477
			PEAB_TDMA_Datalink,
			// Token: 0x0400117E RID: 4478
			TERMA_Datalink,
			// Token: 0x0400117F RID: 4479
			LAMPS_Datalink,
			// Token: 0x04001180 RID: 4480
			APD15_Datalink,
			// Token: 0x04001181 RID: 4481
			A346Z_Datalink,
			// Token: 0x04001182 RID: 4482
			ELF_Link = 6001,
			// Token: 0x04001183 RID: 4483
			Radio = 7001,
			// Token: 0x04001184 RID: 4484
			HaveQuick_Radio,
			// Token: 0x04001185 RID: 4485
			OneWay_WireGuidance = 8001,
			// Token: 0x04001186 RID: 4486
			TwoWay_WireGuidance,
			// Token: 0x04001187 RID: 4487
			NATO_SonobuoyLink = 9001,
			// Token: 0x04001188 RID: 4488
			RGB_SonobuoyLink,
			// Token: 0x04001189 RID: 4489
			BM_SonobuoyLink,
			// Token: 0x0400118A RID: 4490
			Generic_SonobuoyLink,
			// Token: 0x0400118B RID: 4491
			Type75_SonobuoyLink,
			// Token: 0x0400118C RID: 4492
			AEGIS_WeaponLink = 10001,
			// Token: 0x0400118D RID: 4493
			AWG9_WeaponLink,
			// Token: 0x0400118E RID: 4494
			NTU_WeaponLink,
			// Token: 0x0400118F RID: 4495
			NASAMS_WeaponLink,
			// Token: 0x04001190 RID: 4496
			AGM142_WeaponLink,
			// Token: 0x04001191 RID: 4497
			Patriot_WeaponLink,
			// Token: 0x04001192 RID: 4498
			AGM154_WeaponLink,
			// Token: 0x04001193 RID: 4499
			Rapier_WeaponLink,
			// Token: 0x04001194 RID: 4500
			AIM120_WeaponLink,
			// Token: 0x04001195 RID: 4501
			Roland_WeaponLink,
			// Token: 0x04001196 RID: 4502
			AAW9_13_WeaponLink,
			// Token: 0x04001197 RID: 4503
			SA12_WeaponLink,
			// Token: 0x04001198 RID: 4504
			AJ168_WeaponLink,
			// Token: 0x04001199 RID: 4505
			SA5_WeaponLink,
			// Token: 0x0400119A RID: 4506
			AS12_WeaponWire,
			// Token: 0x0400119B RID: 4507
			SA10_WeaponLink,
			// Token: 0x0400119C RID: 4508
			AS15TT_WeaponLink,
			// Token: 0x0400119D RID: 4509
			HUMRAAM_WeaponLink,
			// Token: 0x0400119E RID: 4510
			AS30_WeaponLink,
			// Token: 0x0400119F RID: 4511
			HOT_WeaponLink,
			// Token: 0x040011A0 RID: 4512
			APK8_9_WeaponLink,
			// Token: 0x040011A1 RID: 4513
			IKARA_WeaponLink,
			// Token: 0x040011A2 RID: 4514
			AS7_WeaponLink,
			// Token: 0x040011A3 RID: 4515
			MICA_WeaponLink,
			// Token: 0x040011A4 RID: 4516
			Aster_WeaponLink,
			// Token: 0x040011A5 RID: 4517
			Otomat_WeaponLink,
			// Token: 0x040011A6 RID: 4518
			GBU15_WeaponLink,
			// Token: 0x040011A7 RID: 4519
			RBS15_WeaponLink,
			// Token: 0x040011A8 RID: 4520
			ABM_WeaponLink,
			// Token: 0x040011A9 RID: 4521
			ADATS_WeaponLink,
			// Token: 0x040011AA RID: 4522
			Arrow_WeaponLink,
			// Token: 0x040011AB RID: 4523
			AT2_3_6_12_16_WeaponLink,
			// Token: 0x040011AC RID: 4524
			Bamse_WeaponLink,
			// Token: 0x040011AD RID: 4525
			Barak_WeaponLink,
			// Token: 0x040011AE RID: 4526
			Blowpipe_WeaponLink,
			// Token: 0x040011AF RID: 4527
			Bullpup_WeaponLink,
			// Token: 0x040011B0 RID: 4528
			C701_WeaponLink,
			// Token: 0x040011B1 RID: 4529
			CADSN1_WeaponLink,
			// Token: 0x040011B2 RID: 4530
			ASM_SSM_WeaponLink,
			// Token: 0x040011B3 RID: 4531
			Crotale_WeaponLink,
			// Token: 0x040011B4 RID: 4532
			EFOGM_WeaponLink,
			// Token: 0x040011B5 RID: 4533
			Gabriel_WeaponLink,
			// Token: 0x040011B6 RID: 4534
			MarteMk2_WeaponLink,
			// Token: 0x040011B7 RID: 4535
			Javelin_WeaponLink,
			// Token: 0x040011B8 RID: 4536
			SAM1_WeaponLink,
			// Token: 0x040011B9 RID: 4537
			SAM4_WeaponLink,
			// Token: 0x040011BA RID: 4538
			SeaCat_WeaponLink,
			// Token: 0x040011BB RID: 4539
			SeaSkua_WeaponLink,
			// Token: 0x040011BC RID: 4540
			SeaWolf_WeaponLink,
			// Token: 0x040011BD RID: 4541
			SkyBow_WeaponLink,
			// Token: 0x040011BE RID: 4542
			Starstreak_WeaponLink,
			// Token: 0x040011BF RID: 4543
			THAAD_WeaponLink,
			// Token: 0x040011C0 RID: 4544
			TOW_WeaponLink,
			// Token: 0x040011C1 RID: 4545
			AA10_12_WeaponLink,
			// Token: 0x040011C2 RID: 4546
			AA9_13_WeaponLink,
			// Token: 0x040011C3 RID: 4547
			AA5_WeaponLink,
			// Token: 0x040011C4 RID: 4548
			AA7_WeaponLink,
			// Token: 0x040011C5 RID: 4549
			AAM4_WeaponLink,
			// Token: 0x040011C6 RID: 4550
			SkySwordII_WeaponLink,
			// Token: 0x040011C7 RID: 4551
			RBS70_90_WeaponLink,
			// Token: 0x040011C8 RID: 4552
			Derby_WeaponLink
		}

		// Token: 0x020002D3 RID: 723
		internal struct Struct31
		{
			// Token: 0x040011C9 RID: 4553
			public bool bool_0;

			// Token: 0x040011CA RID: 4554
			public bool bool_1;

			// Token: 0x040011CB RID: 4555
			public bool bool_2;

			// Token: 0x040011CC RID: 4556
			public bool bool_3;

			// Token: 0x040011CD RID: 4557
			public bool bool_4;

			// Token: 0x040011CE RID: 4558
			public bool bool_5;

			// Token: 0x040011CF RID: 4559
			public bool bool_6;

			// Token: 0x040011D0 RID: 4560
			public bool bool_7;

			// Token: 0x040011D1 RID: 4561
			public bool bool_8;

			// Token: 0x040011D2 RID: 4562
			public bool bool_9;

			// Token: 0x040011D3 RID: 4563
			public bool bool_10;

			// Token: 0x040011D4 RID: 4564
			public bool bool_11;

			// Token: 0x040011D5 RID: 4565
			public bool bool_12;

			// Token: 0x040011D6 RID: 4566
			public bool bool_13;

			// Token: 0x040011D7 RID: 4567
			public bool bool_14;

			// Token: 0x040011D8 RID: 4568
			public bool bool_15;
		}
	}
}
