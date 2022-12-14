using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Xml;
using Command_Core.DAL;
using DarkUI.Collections;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns12;
using ns13;
using ns14;
using ns8;

namespace Command_Core
{
	// Token: 0x020002DA RID: 730
	public sealed class Mount : PlatformComponent
	{
		// Token: 0x06001590 RID: 5520 RVA: 0x0000BB0F File Offset: 0x00009D0F
		[CompilerGenerated]
		public ObservableList<WeaponRec> vmethod_10()
		{
			return this.observableList_0;
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00192378 File Offset: 0x00190578
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_11(ObservableList<WeaponRec> observableList_1)
		{
			EventHandler<EventArgs5<WeaponRec>> eventHandler_ = new EventHandler<EventArgs5<WeaponRec>>(this.method_49);
			EventHandler<EventArgs5<WeaponRec>> eventHandler_2 = new EventHandler<EventArgs5<WeaponRec>>(this.method_50);
			ObservableList<WeaponRec> observableList = this.observableList_0;
			if (observableList != null)
			{
				observableList.method_1(eventHandler_);
				observableList.method_3(eventHandler_2);
			}
			this.observableList_0 = observableList_1;
			observableList = this.observableList_0;
			if (observableList != null)
			{
				observableList.method_0(eventHandler_);
				observableList.method_2(eventHandler_2);
			}
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x001923D8 File Offset: 0x001905D8
		[CompilerGenerated]
		public static void smethod_2(Mount.Delegate44 delegate44_1)
		{
			Mount.Delegate44 @delegate = Mount.delegate44_0;
			Mount.Delegate44 delegate2;
			do
			{
				delegate2 = @delegate;
				Mount.Delegate44 value = (Mount.Delegate44)Delegate.Combine(delegate2, delegate44_1);
				@delegate = Interlocked.CompareExchange<Mount.Delegate44>(ref Mount.delegate44_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x0019240C File Offset: 0x0019060C
		[CompilerGenerated]
		public static void smethod_3(Mount.Delegate44 delegate44_1)
		{
			Mount.Delegate44 @delegate = Mount.delegate44_0;
			Mount.Delegate44 delegate2;
			do
			{
				delegate2 = @delegate;
				Mount.Delegate44 value = (Mount.Delegate44)Delegate.Remove(delegate2, delegate44_1);
				@delegate = Interlocked.CompareExchange<Mount.Delegate44>(ref Mount.delegate44_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00192440 File Offset: 0x00190640
		[CompilerGenerated]
		public static void smethod_4(Mount.Delegate45 delegate45_1)
		{
			Mount.Delegate45 @delegate = Mount.delegate45_0;
			Mount.Delegate45 delegate2;
			do
			{
				delegate2 = @delegate;
				Mount.Delegate45 value = (Mount.Delegate45)Delegate.Combine(delegate2, delegate45_1);
				@delegate = Interlocked.CompareExchange<Mount.Delegate45>(ref Mount.delegate45_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00192474 File Offset: 0x00190674
		[CompilerGenerated]
		public static void smethod_5(Mount.Delegate45 delegate45_1)
		{
			Mount.Delegate45 @delegate = Mount.delegate45_0;
			Mount.Delegate45 delegate2;
			do
			{
				delegate2 = @delegate;
				Mount.Delegate45 value = (Mount.Delegate45)Delegate.Remove(delegate2, delegate45_1);
				@delegate = Interlocked.CompareExchange<Mount.Delegate45>(ref Mount.delegate45_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x001924A8 File Offset: 0x001906A8
		public override void vmethod_1()
		{
			checked
			{
				try
				{
					base.vmethod_1();
					try
					{
						foreach (WeaponRec weaponRec in this.vmethod_10())
						{
							weaponRec.vmethod_1();
						}
					}
					finally
					{
						List<WeaponRec>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (!Information.IsNothing(this.magazine_0))
					{
						this.magazine_0.vmethod_1();
					}
					Sensor[] array = this.sensor_0;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].vmethod_1();
					}
					CommDevice[] array2 = this.commDevice_0;
					for (int j = 0; j < array2.Length; j++)
					{
						array2[j].vmethod_1();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100675", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x0019259C File Offset: 0x0019079C
		public string method_23(ref HashSet<string> hashSet_2, Scenario scenario_0)
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
				this.stringBuilder_0.Append("<Mount>");
				try
				{
					this.stringBuilder_0.Append("<ID>").Append(this.string_0).Append("</ID>");
					if (!Information.IsNothing(hashSet_2))
					{
						if (hashSet_2.Contains(this.string_0))
						{
							this.stringBuilder_0.Append("</Mount>");
							return this.stringBuilder_0.ToString();
						}
						hashSet_2.Add(this.string_0);
					}
					if (!string.IsNullOrEmpty(this.Name))
					{
						this.stringBuilder_0.Append("<Name>").Append(SecurityElement.Escape(this.Name)).Append("</Name>");
					}
					if (this._ComponentStatus_0 != PlatformComponent._ComponentStatus.Operational)
					{
						StringBuilder stringBuilder = this.stringBuilder_0.Append("<Status>");
						byte componentStatus_ = (byte)this._ComponentStatus_0;
						stringBuilder.Append(componentStatus_.ToString()).Append("</Status>");
					}
					if (base.method_16() != PlatformComponent._DamageSeverityFactor.Light)
					{
						this.stringBuilder_0.Append("<DamageSeverity>").Append(((byte)base.method_16()).ToString()).Append("</DamageSeverity>");
					}
					if (this.activeUnit_0 != null)
					{
						this.stringBuilder_0.Append("<PP>").Append(this.activeUnit_0.string_0).Append("</PP>");
					}
					this.stringBuilder_0.Append("<DBID>").Append(this.DBID.ToString()).Append("</DBID>");
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100676-A", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				try
				{
					if (this.vmethod_10().Count > 0)
					{
						this.stringBuilder_0.Append("<MW>");
						try
						{
							foreach (WeaponRec weaponRec in this.vmethod_10())
							{
								this.stringBuilder_0.Append(weaponRec.method_8(hashSet_2, scenario_0));
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						this.stringBuilder_0.Append("</MW>");
					}
					if (this.method_32().vmethod_10().Count > 0)
					{
						this.stringBuilder_0.Append("<MMW>");
						try
						{
							foreach (WeaponRec weaponRec2 in this.method_32().vmethod_10())
							{
								this.stringBuilder_0.Append(weaponRec2.method_8(hashSet_2, scenario_0));
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						this.stringBuilder_0.Append("</MMW>");
					}
					if (this.sensor_0.Length > 0)
					{
						this.stringBuilder_0.Append("<Sensors>");
						foreach (Sensor sensor in this.sensor_0)
						{
							this.stringBuilder_0.Append(sensor.method_23(hashSet_2));
						}
						this.stringBuilder_0.Append("</Sensors>");
					}
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 100676-B", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				try
				{
					if (this.commDevice_0.Length > 0)
					{
						this.stringBuilder_0.Append("<CommDevices>");
						foreach (CommDevice commDevice in this.commDevice_0)
						{
							this.stringBuilder_0.Append(commDevice.method_23(ref hashSet_2));
						}
						this.stringBuilder_0.Append("</CommDevices>");
					}
					if (this.class295_0.method_2())
					{
						this.stringBuilder_0.Append(this.class295_0.method_0(false));
					}
					if (this.float_0 != 0f)
					{
						this.stringBuilder_0.Append("<TTF>").Append(XmlConvert.ToString(this.float_0)).Append("</TTF>");
					}
					if (this.method_32().method_24() != 0f)
					{
						this.stringBuilder_0.Append("<TTF_MountMagazine>").Append(XmlConvert.ToString(this.method_32().method_24())).Append("</TTF_MountMagazine>");
					}
					this.stringBuilder_0.Append("<DP>").Append(XmlConvert.ToString(this.float_2)).Append("</DP>");
					if (this.bool_15)
					{
						this.stringBuilder_0.Append("<ReserveTarget>True</ReserveTarget>");
					}
					if (this.enum113_0 != Mount.Enum113.const_0)
					{
						this.stringBuilder_0.Append("<ReloadStatus>").Append((byte)this.enum113_0).Append("</ReloadStatus>");
					}
					if (this.hashSet_0.Count > 0)
					{
						this.stringBuilder_0.Append("<RPriority>").Append(string.Join<int>(",", this.hashSet_0)).Append("</RPriority>");
					}
					if (this.method_26() != 0)
					{
						this.stringBuilder_0.Append("<AO_B>").Append(XmlConvert.ToString(this.method_26())).Append("</AO_B>");
					}
					if (this.method_27() != 0f)
					{
						this.stringBuilder_0.Append("<AO_D>").Append(XmlConvert.ToString(this.method_27())).Append("</AO_D>");
					}
					this.stringBuilder_0.Append("</Mount>");
					result = this.stringBuilder_0.ToString();
				}
				catch (Exception ex3)
				{
					ex3.Data.Add("Error at 100676-C", "");
					GameGeneral.smethod_25(ref ex3);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
			catch (Exception ex4)
			{
				ex4.Data.Add("Error at 100676", "");
				GameGeneral.smethod_25(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00192C64 File Offset: 0x00190E64
		public static Mount smethod_6(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ActiveUnit activeUnit_1)
		{
			Mount result;
			try
			{
				int num = Conversions.ToInteger(Misc.smethod_44(xmlNode_0.ChildNodes, "DBID").InnerText);
				if (num == 0)
				{
					if (Information.IsNothing(Misc.smethod_44(xmlNode_0.ChildNodes, "Name")))
					{
						return null;
					}
					num = DBFunctions.smethod_108(Misc.smethod_9(Misc.smethod_44(xmlNode_0.ChildNodes, "Name").InnerText), activeUnit_1.scenario_0.method_39());
				}
				Mount mount = DBFunctions.smethod_110(num, ref activeUnit_1.scenario_0, false);
				mount.method_19(activeUnit_1);
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				if (!Information.IsNothing(dictionary_0))
				{
					if (dictionary_0.ContainsKey(innerText))
					{
						return (Mount)dictionary_0[innerText];
					}
					mount.vmethod_0(innerText);
					dictionary_0.Add(mount.string_0, mount);
				}
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						try
						{
							string name = xmlNode.Name;
							uint num2 = Class582.smethod_0(name);
							if (num2 > 1626034646U)
							{
								if (num2 > 3161544654U)
								{
									if (num2 <= 3450734260U)
									{
										if (num2 != 3218297559U)
										{
											if (num2 != 3309953595U)
											{
												if (num2 != 3450734260U)
												{
													continue;
												}
												if (Operators.CompareString(name, "ReloadPriority", false) == 0)
												{
													goto IL_5E0;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "Coverage", false) == 0)
												{
													goto IL_64C;
												}
												continue;
											}
										}
										else if (Operators.CompareString(name, "AimpointOffset_Distance", false) != 0)
										{
											continue;
										}
									}
									else if (num2 != 3590359932U)
									{
										if (num2 != 3976247152U)
										{
											if (num2 != 4076912866U)
											{
												continue;
											}
											if (Operators.CompareString(name, "AO_D", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "AO_B", false) == 0)
											{
												goto IL_6D2;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "CommDevices", false) == 0)
										{
											try
											{
												foreach (object obj2 in xmlNode.ChildNodes)
												{
													XmlNode xmlNode2 = (XmlNode)obj2;
													CommDevice commDevice = CommDevice.smethod_2(ref xmlNode2, ref dictionary_0, activeUnit_1);
													commDevice.method_19(activeUnit_1);
													Class429.smethod_9(ref mount.commDevice_0, commDevice);
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
											continue;
										}
										continue;
									}
									mount.nullable_1 = new float?(XmlConvert.ToSingle(xmlNode.InnerText));
									continue;
								}
								if (num2 <= 2822034830U)
								{
									if (num2 != 2424405304U)
									{
										if (num2 != 2822034830U)
										{
											continue;
										}
										if (Operators.CompareString(name, "AimpointOffset_Bearing", false) != 0)
										{
											continue;
										}
										goto IL_6D2;
									}
									else
									{
										if (Operators.CompareString(name, "Sensors", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj3 in xmlNode.ChildNodes)
											{
												Sensor sensor = Sensor.smethod_2((XmlNode)obj3, dictionary_0, mount.method_18());
												sensor.method_19(activeUnit_1);
												Class429.smethod_24(ref mount.sensor_0, sensor);
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
								}
								if (num2 == 2835904185U)
								{
									goto IL_58B;
								}
								if (num2 != 3112826795U)
								{
									if (num2 != 3161544654U)
									{
										continue;
									}
									if (Operators.CompareString(name, "ReserveTarget", false) == 0)
									{
										mount.bool_15 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "MountWeapons", false) == 0)
									{
										goto IL_52B;
									}
									continue;
								}
								IL_6D2:
								mount.nullable_0 = new int?(XmlConvert.ToInt32(xmlNode.InnerText));
								continue;
							}
							if (num2 <= 808157257U)
							{
								if (num2 <= 580728861U)
								{
									if (num2 != 6222351U)
									{
										if (num2 != 580728861U)
										{
											continue;
										}
										if (Operators.CompareString(name, "TTF_MountMagazine", false) == 0)
										{
											mount.method_32().method_25(XmlConvert.ToSingle(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Status", false) != 0)
										{
											continue;
										}
										string innerText2 = xmlNode.InnerText;
										if (Operators.CompareString(innerText2, "Operational", false) == 0)
										{
											mount._ComponentStatus_0 = PlatformComponent._ComponentStatus.Operational;
											continue;
										}
										if (Operators.CompareString(innerText2, "Damaged", false) == 0)
										{
											mount._ComponentStatus_0 = PlatformComponent._ComponentStatus.Damaged;
											continue;
										}
										if (Operators.CompareString(innerText2, "Destroyed", false) != 0)
										{
											mount._ComponentStatus_0 = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										mount._ComponentStatus_0 = PlatformComponent._ComponentStatus.Destroyed;
										continue;
									}
								}
								else
								{
									if (num2 != 625939272U)
									{
										if (num2 != 684613497U)
										{
											if (num2 != 808157257U)
											{
												continue;
											}
											if (Operators.CompareString(name, "MountMagazineWeapons", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "DP", false) == 0)
											{
												mount.float_2 = XmlConvert.ToSingle(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (Operators.CompareString(name, "MMW", false) != 0)
									{
										continue;
									}
									try
									{
										foreach (object obj4 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode3 = (XmlNode)obj4;
											WeaponRec gparam_ = WeaponRec.smethod_2(ref xmlNode3, ref dictionary_0, ref activeUnit_1.scenario_0);
											mount.method_32().vmethod_10().method_4(gparam_);
										}
										continue;
									}
									finally
									{
										IEnumerator enumerator4;
										if (enumerator4 is IDisposable)
										{
											(enumerator4 as IDisposable).Dispose();
										}
									}
								}
							}
							if (num2 <= 970965853U)
							{
								if (num2 != 963109897U)
								{
									if (num2 != 970965853U)
									{
										continue;
									}
									if (Operators.CompareString(name, "MW", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "TTF", false) == 0)
									{
										mount.float_0 = XmlConvert.ToSingle(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num2 != 1528329603U)
							{
								if (num2 != 1548823463U)
								{
									if (num2 != 1626034646U)
									{
										continue;
									}
									if (Operators.CompareString(name, "ReloadStatus", false) != 0)
									{
										continue;
									}
									string innerText3 = xmlNode.InnerText;
									if (Operators.CompareString(innerText3, "Ready", false) == 0)
									{
										mount.enum113_0 = Mount.Enum113.const_0;
										continue;
									}
									if (Operators.CompareString(innerText3, "Reloading", false) == 0)
									{
										mount.enum113_0 = Mount.Enum113.const_1;
										continue;
									}
									if (Operators.CompareString(innerText3, "Unloading", false) != 0)
									{
										mount.enum113_0 = (Mount.Enum113)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									mount.enum113_0 = Mount.Enum113.const_2;
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "DamageSeverity", false) == 0)
									{
										mount.method_17((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Cov", false) != 0)
								{
									continue;
								}
								goto IL_64C;
							}
							IL_52B:
							try
							{
								foreach (object obj5 in xmlNode.ChildNodes)
								{
									XmlNode xmlNode4 = (XmlNode)obj5;
									WeaponRec gparam_2 = WeaponRec.smethod_2(ref xmlNode4, ref dictionary_0, ref activeUnit_1.scenario_0);
									mount.vmethod_10().method_4(gparam_2);
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
							IL_58B:
							if (Operators.CompareString(name, "RPriority", false) != 0)
							{
								continue;
							}
							IL_5E0:
							foreach (string text in xmlNode.InnerText.Split(new char[]
							{
								','
							}))
							{
								if (Operators.CompareString(text, "", false) != 0)
								{
									mount.hashSet_0.Add(Conversions.ToInteger(text));
								}
							}
							continue;
							IL_64C:
							mount.class295_0 = PlatformComponent.Class295.smethod_0(ref xmlNode);
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
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = mount;
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100677", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x001934F8 File Offset: 0x001916F8
		public Mount() : base(null)
		{
			this.vmethod_11(new ObservableList<WeaponRec>());
			this.sensor_0 = new Sensor[0];
			this.commDevice_0 = new CommDevice[0];
			this.hashSet_0 = new HashSet<int>();
			this.hashSet_1 = new HashSet<int>();
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0000BB17 File Offset: 0x00009D17
		public bool method_24()
		{
			if (this.nullable_2 == null)
			{
				this.nullable_2 = new bool?(this.Name.Contains(" VLS"));
			}
			return this.nullable_2.Value;
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x0000BB4C File Offset: 0x00009D4C
		public bool method_25()
		{
			if (this.nullable_3 == null)
			{
				this.nullable_3 = new bool?(this.Name.Contains(" Rail"));
			}
			return this.nullable_3.Value;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00193548 File Offset: 0x00191748
		public int method_26()
		{
			int result;
			if (base.method_18() == null)
			{
				result = 0;
			}
			else if (!base.method_18().method_6())
			{
				result = 0;
			}
			else
			{
				if (this.nullable_0 == null)
				{
					this.nullable_0 = new int?(GameGeneral.smethod_5().Next(0, 360));
				}
				result = this.nullable_0.Value;
			}
			return result;
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x001935A8 File Offset: 0x001917A8
		public float method_27()
		{
			float result;
			if (base.method_18() == null)
			{
				result = 0f;
			}
			else if (!base.method_18().method_6())
			{
				result = 0f;
			}
			else
			{
				if (this.nullable_1 == null)
				{
					if (this.vmethod_10().Count > 0)
					{
						this.nullable_1 = new float?((float)((double)GameGeneral.smethod_5().Next(75, 101) / 100.0 * (double)((Facility)base.method_18()).int_9));
					}
					else
					{
						this.nullable_1 = new float?((float)((double)GameGeneral.smethod_5().Next(0, 51) / 100.0 * (double)((Facility)base.method_18()).int_9));
					}
				}
				result = this.nullable_1.Value;
			}
			return result;
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x0000BB81 File Offset: 0x00009D81
		public float method_28()
		{
			return this.float_0;
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0000BB89 File Offset: 0x00009D89
		public void method_29(float float_3)
		{
			this.float_0 = float_3;
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x0000BB92 File Offset: 0x00009D92
		public float method_30()
		{
			return this.float_1;
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x0000BB9A File Offset: 0x00009D9A
		public void method_31(float float_3)
		{
			this.float_1 = float_3;
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00193678 File Offset: 0x00191878
		public Magazine method_32()
		{
			if (this.magazine_0 == null)
			{
				this.magazine_0 = new Magazine(base.method_18(), 0, "Magazine for mount: " + Misc.smethod_9(this.Name), this.armorRating_0, this.int_2, this.int_3, false);
			}
			if (this.magazine_0.method_18() == null)
			{
				this.magazine_0.method_19(base.method_18());
			}
			return this.magazine_0;
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x001936EC File Offset: 0x001918EC
		public bool method_33()
		{
			Weapon._WeaponType weaponType = this.vmethod_10()[0].method_12(base.method_18().scenario_0).method_167();
			return weaponType - Weapon._WeaponType.Decoy_Expendable <= 1;
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0019372C File Offset: 0x0019192C
		public bool method_34()
		{
			Sensor[] array = this.method_36();
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].method_43())
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00193760 File Offset: 0x00191960
		public int method_35(ref int int_4, ref int int_5)
		{
			int_4 = 0;
			int_5 = 0;
			try
			{
				foreach (WeaponRec weaponRec in this.vmethod_10())
				{
					if (weaponRec.method_9() != 0)
					{
						if (weaponRec.int_4 > 1)
						{
							float num = (float)weaponRec.method_9() / (float)weaponRec.int_4;
							if (num != (float)((int)Math.Round((double)num)))
							{
								int_5++;
								int_4 += (int)Math.Floor((double)weaponRec.method_9() / (double)weaponRec.int_4);
							}
							else
							{
								int_4 += (int)Math.Round((double)num);
							}
						}
						else
						{
							int_4 += weaponRec.method_9();
						}
					}
				}
			}
			finally
			{
				List<WeaponRec>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return int_4 + int_5;
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x0000BBA3 File Offset: 0x00009DA3
		public Sensor[] method_36()
		{
			return this.sensor_0;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00193820 File Offset: 0x00191A20
		public bool method_37()
		{
			return Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.vmethod_10(), (Mount._Closure$__.$I74-0 == null) ? (Mount._Closure$__.$I74-0 = new Func<WeaponRec, bool>(Mount._Closure$__.$I.method_0)) : Mount._Closure$__.$I74-0)) == this.vmethod_10().Count;
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00193870 File Offset: 0x00191A70
		public bool method_38()
		{
			try
			{
				List<WeaponRec>.Enumerator enumerator = this.vmethod_10().GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.method_12(base.method_18().scenario_0).method_167() == Weapon._WeaponType.Gun)
					{
						return true;
					}
				}
			}
			finally
			{
				List<WeaponRec>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return false;
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x0000BBAB File Offset: 0x00009DAB
		public void method_39(Sensor sensor_1)
		{
			Class429.smethod_24(ref this.sensor_0, sensor_1);
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x0000BBB9 File Offset: 0x00009DB9
		public void method_40(Sensor sensor_1)
		{
			Class429.smethod_25(ref this.sensor_0, sensor_1);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x001938E0 File Offset: 0x00191AE0
		public override void vmethod_6(Side side_0, bool bool_19, bool bool_20)
		{
			checked
			{
				try
				{
					base.vmethod_6(side_0, bool_19, bool_20);
					Sensor[] array = this.sensor_0;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].vmethod_6(side_0, bool_19, bool_20);
					}
					CommDevice[] array2 = this.commDevice_0;
					for (int j = 0; j < array2.Length; j++)
					{
						array2[j].vmethod_6(side_0, bool_19, bool_20);
					}
					if (bool_20 && bool_20 && !bool_19)
					{
						side_0.class366_0.method_1(this, bool_20);
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100678", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00193998 File Offset: 0x00191B98
		private void method_41(Weapon weapon_0, double double_0, double double_1, double double_2)
		{
			if (weapon_0.warhead_0.Length > 0 && weapon_0.warhead_0[0].method_16(weapon_0, base.method_18()))
			{
				string text = " airbursted off ";
				if (base.method_18().vmethod_27() || base.method_18().vmethod_26() || weapon_0.vmethod_13() == 0f)
				{
					text = " missed ";
				}
				if (Class570.class280_0.method_12())
				{
					base.method_18().scenario_0.method_59(string.Concat(new string[]
					{
						"Weapon: ",
						weapon_0.string_2,
						text,
						Misc.smethod_9(this.Name),
						" (of ",
						base.method_18().Name,
						") by ",
						Conversions.ToString(Math.Max(1, (int)Math.Round(double_0 * 3.2808399200439453))),
						"ft"
					}), weapon_0.string_2 + " missed", LoggedMessage.MessageType.WeaponDamage, 10, this.string_0, null, new Geopoint_Struct(double_1, double_2));
					return;
				}
				base.method_18().scenario_0.method_59(string.Concat(new string[]
				{
					"Weapon: ",
					weapon_0.string_2,
					text,
					Misc.smethod_9(this.Name),
					" (of ",
					base.method_18().Name,
					") by ",
					Conversions.ToString(Math.Max(1, (int)Math.Round(double_0))),
					"m"
				}), weapon_0.string_2 + " missed", LoggedMessage.MessageType.WeaponDamage, 10, this.string_0, null, new Geopoint_Struct(double_1, double_2));
				return;
			}
			else
			{
				if (Class570.class280_0.method_12())
				{
					base.method_18().scenario_0.method_59(string.Concat(new string[]
					{
						"Weapon: ",
						weapon_0.string_2,
						" missed ",
						Misc.smethod_9(this.Name),
						" (of ",
						base.method_18().Name,
						") by ",
						Conversions.ToString(Math.Max(1, (int)Math.Round(double_0 * 3.2808399200439453))),
						"ft"
					}), weapon_0.string_2 + " missed", LoggedMessage.MessageType.WeaponDamage, 10, this.string_0, null, new Geopoint_Struct(double_1, double_2));
					return;
				}
				base.method_18().scenario_0.method_59(string.Concat(new string[]
				{
					"Weapon: ",
					weapon_0.string_2,
					" missed ",
					Misc.smethod_9(this.Name),
					" (of ",
					base.method_18().Name,
					") by ",
					Conversions.ToString(Math.Max(1, (int)Math.Round(double_0))),
					"m"
				}), weapon_0.string_2 + " missed", LoggedMessage.MessageType.WeaponDamage, 10, this.string_0, null, new Geopoint_Struct(double_1, double_2));
				return;
			}
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00193CAC File Offset: 0x00191EAC
		public void method_42(Weapon weapon_0, float float_3, float float_4, ActiveUnit activeUnit_1, double? nullable_4, double? nullable_5, float? nullable_6)
		{
			try
			{
				Warhead warhead = weapon_0.warhead_0[0];
				double num;
				double num2;
				if (base.method_18().method_6())
				{
					double double_;
					double double_2;
					Class411.smethod_1(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null), ref double_, ref double_2, (double)(this.method_27() / 1852f), (double)this.method_26());
					Class411.smethod_1(double_, double_2, ref num, ref num2, (double)(float_3 / 1852f), (double)float_4);
				}
				else
				{
					Class411.smethod_1(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null), ref num, ref num2, (double)(float_3 / 1852f), (double)float_4);
				}
				float num3;
				if ((weapon_0.method_204() || weapon_0.vmethod_3()) && weapon_0.method_187().method_47())
				{
					num3 = Math.Max(Enumerable.First<Waypoint>(weapon_0.method_187().method_4()).imethod_4(), (float)((int)Terrain.smethod_7(Enumerable.First<Waypoint>(weapon_0.method_187().method_4()).imethod_2(), Enumerable.First<Waypoint>(weapon_0.method_187().method_4()).imethod_0(), false) + weapon_0.method_206(base.method_18())));
				}
				else
				{
					num3 = (float)((int)Terrain.smethod_7(num2, num, false) + weapon_0.method_206(base.method_18()));
				}
				if (nullable_4 == null || nullable_5 == null)
				{
					double value;
					double value2;
					Class411.smethod_1(num, num2, ref value, ref value2, (double)(float_3 / 1852f), (double)float_4);
					nullable_4 = new double?(value2);
					nullable_5 = new double?(value);
					bool isAttached = Debugger.IsAttached;
				}
				if (warhead.method_9())
				{
					new Explosion(ref base.method_18().scenario_0, num, num2, nullable_5.Value, nullable_4.Value, weapon_0.vmethod_9(), num3, weapon_0.method_167(), warhead.float_0, warhead.float_0, warhead.warheadType_0, warhead.enum126_0, null, null, null, this, null, 0, 0, 0, 0f, 0);
					double double_3;
					if (warhead.method_10())
					{
						double_3 = (double)float_3;
					}
					else
					{
						double_3 = Math.Sqrt(Math.Pow((double)Math.Abs(num3 - base.method_18().vmethod_14(false)), 2.0) + Math.Pow((double)float_3, 2.0));
					}
					this.method_41(weapon_0, double_3, num, num2);
				}
				else
				{
					if (float_3 == 0f)
					{
						this.method_43(weapon_0, activeUnit_1, nullable_4, nullable_5, nullable_6);
					}
					else
					{
						double num4 = Math.Sqrt(Math.Pow((double)Math.Abs(num3 - base.method_18().vmethod_14(false)), 2.0) + Math.Pow((double)float_3, 2.0));
						this.method_41(weapon_0, num4, num, num2);
						if (warhead.method_11() || warhead.method_12())
						{
							bool flag = base.method_18().scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_10);
							Warhead.WarheadType warheadType_ = warhead.warheadType_0;
							if (warheadType_ != Warhead.WarheadType.Fragmentation && warheadType_ != Warhead.WarheadType.ContinuousRod)
							{
								if (warheadType_ != Warhead.WarheadType.Fragmentation_ABM)
								{
									double num5 = (double)Warhead.smethod_4(base.method_18().vmethod_30(null), base.method_18().vmethod_28(null), num4 / 1852.0, (double)this.float_2, warhead.warheadType_0, (double)warhead.float_0, Weapon.Enum128.const_0, flag);
									if (num5 > 0.0)
									{
										this.method_48(num5, warhead.warheadType_0);
										goto IL_3E1;
									}
									goto IL_3E1;
								}
							}
							float theCutOffRange_Frag = Explosion.smethod_2((double)weapon_0.warhead_0[0].float_0, Weapon.Enum128.const_0);
							double damageYield = (double)Warhead.smethod_3(base.method_18().vmethod_30(null), base.method_18().vmethod_28(null), num4 / 1852.0, warhead.warheadType_0, (double)warhead.float_0, Weapon.Enum128.const_0, flag);
							this.method_45(damageYield, theCutOffRange_Frag, 0);
							IL_3E1:
							new Explosion(ref base.method_18().scenario_0, num, num2, nullable_5.Value, nullable_4.Value, weapon_0.vmethod_9(), num3, weapon_0.method_167(), warhead.float_0, warhead.float_0, warhead.warheadType_0, warhead.enum126_0, null, null, null, this, null, 0, 0, 0, 0f, 0);
						}
					}
					if (this.float_2 <= 0f)
					{
						this.float_2 = 0f;
						if (!base.method_18().bool_2)
						{
							base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(this.Name) + " has been destroyed!", base.method_18().Name + " lost a mount/weapon", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(num, num2));
						}
						this.vmethod_6(base.method_18().vmethod_7(false), false, base.method_18().method_6());
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100679", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x00194208 File Offset: 0x00192408
		private void method_43(Weapon weapon_0, ActiveUnit activeUnit_1, double? nullable_4, double? nullable_5, float? nullable_6)
		{
			try
			{
				double num;
				double num2;
				float theAltitude;
				if (base.method_18().method_6())
				{
					Class411.smethod_1(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null), ref num, ref num2, (double)(this.method_27() / 1852f), (double)this.method_26());
					theAltitude = (float)((int)Terrain.smethod_7(num2, num, false) + weapon_0.method_206(base.method_18()));
				}
				else
				{
					num2 = base.method_18().vmethod_30(null);
					num = base.method_18().vmethod_28(null);
					theAltitude = base.method_18().vmethod_14(false);
				}
				base.method_18().scenario_0.method_59(string.Concat(new string[]
				{
					"Weapon: ",
					weapon_0.string_2,
					" has impacted ",
					Misc.smethod_9(this.Name),
					" (of ",
					base.method_18().Name,
					")"
				}), weapon_0.string_2 + " hit", LoggedMessage.MessageType.WeaponDamage, 10, this.string_0, null, new Geopoint_Struct(num, num2));
				Warhead warhead = weapon_0.warhead_0[0];
				double num3;
				double val;
				if (!warhead.method_14(weapon_0.scenario_0) && !warhead.method_16(weapon_0, base.method_18()))
				{
					num3 = (double)(weapon_0.method_148(this.armorRating_0, base.method_18().vmethod_121()) / 100f);
					val = (double)weapon_0.method_278();
				}
				else
				{
					num3 = 0.0;
				}
				if (Information.IsNothing(nullable_4) || Information.IsNothing(nullable_5))
				{
					nullable_4 = new double?(num2);
					nullable_5 = new double?(num);
				}
				double val2;
				if (num3 > 0.0)
				{
					base.method_18().scenario_0.method_59(Conversions.ToString(num3 * 100.0) + "% penetration achieved", base.method_18().Name + " - armor penetrated", LoggedMessage.MessageType.WeaponDamage, 20, weapon_0.string_0, null, new Geopoint_Struct(num, num2));
					if (warhead.method_11())
					{
						val2 = Math.Round(num3 * 2.0 * (double)warhead.float_0, 2);
					}
					else
					{
						val2 = Math.Round(num3 * (double)warhead.float_0, 2);
					}
					if (num3 < 1.0 && warhead.method_11())
					{
						new Explosion(ref base.method_18().scenario_0, num, num2, nullable_5.Value, nullable_4.Value, weapon_0.vmethod_9(), theAltitude, weapon_0.method_167(), (float)((double)warhead.float_0 * (1.0 - num3)), warhead.float_0, warhead.warheadType_0, warhead.enum126_0, null, null, null, this, null, 0, 0, 0, 0f, 0);
					}
					else if (((Facility)base.method_18()).armorRating_0 == GlobalVariables.ArmorRating.None && warhead.method_11())
					{
						new Explosion(ref base.method_18().scenario_0, num, num2, nullable_5.Value, nullable_4.Value, weapon_0.vmethod_9(), theAltitude, weapon_0.method_167(), (float)((double)warhead.float_0 * num3 * 0.25), warhead.float_0, warhead.warheadType_0, warhead.enum126_0, null, null, null, this, null, 0, 0, 0, 0f, 0);
					}
				}
				else if (warhead.method_11() || warhead.method_12())
				{
					new Explosion(ref base.method_18().scenario_0, num, num2, nullable_5.Value, nullable_4.Value, weapon_0.vmethod_9(), theAltitude, weapon_0.method_167(), warhead.float_0, warhead.float_0, warhead.warheadType_0, warhead.enum126_0, null, this, null, null, null, 0, 0, 0, 0f, 0);
				}
				if (num3 > 0.0)
				{
					base.method_18().method_124(Misc.smethod_9(this.Name) + " has been destroyed!", base.method_18().Name + " lost a mount/weapon", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(num, num2));
					this.vmethod_6(base.method_18().vmethod_7(false), false, base.method_18().method_6());
				}
				float num4 = (float)Math.Max(val, val2);
				this.method_44((double)num4);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100680", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x001946B8 File Offset: 0x001928B8
		public void method_44(double double_0)
		{
			try
			{
				foreach (Sensor sensor in Enumerable.Where<Sensor>(this.method_36(), (Mount._Closure$__.$I85-0 == null) ? (Mount._Closure$__.$I85-0 = new Func<Sensor, bool>(Mount._Closure$__.$I.method_1)) : Mount._Closure$__.$I85-0))
				{
					if (double_0 < 1.0)
					{
						if (sensor.method_16() < PlatformComponent._DamageSeverityFactor.Light)
						{
							if (!base.method_18().bool_2)
							{
								base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(sensor.Name) + " has been lightly damaged. ", base.method_18().Name + " - damage to sensor", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
							}
							sensor.vmethod_8(PlatformComponent._DamageSeverityFactor.Light);
						}
					}
					else if (double_0 < 2.0)
					{
						if (sensor.method_16() < PlatformComponent._DamageSeverityFactor.Medium)
						{
							if (!base.method_18().bool_2)
							{
								base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(sensor.Name) + " has been moderately damaged. ", base.method_18().Name + " - damage to sensor", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
							}
							sensor.vmethod_8(PlatformComponent._DamageSeverityFactor.Medium);
						}
					}
					else if (double_0 < 5.0)
					{
						if (sensor.method_16() < PlatformComponent._DamageSeverityFactor.Heavy)
						{
							if (!base.method_18().bool_2)
							{
								base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(sensor.Name) + " has been heavily damaged. ", base.method_18().Name + " - damage to sensor", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
							}
							sensor.vmethod_8(PlatformComponent._DamageSeverityFactor.Heavy);
						}
					}
					else
					{
						if (!base.method_18().bool_2)
						{
							base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(sensor.Name) + " has been destroyed. ", base.method_18().Name + " lost a sensor", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
						}
						sensor.vmethod_6(base.method_18().vmethod_7(false), false, false);
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

		// Token: 0x060015B0 RID: 5552 RVA: 0x00194A58 File Offset: 0x00192C58
		public void method_45(double DamageYield, float theCutOffRange_Frag, int ARM_TargetedRadar = 0)
		{
			try
			{
				if (DamageYield != 0.0)
				{
					this.method_44(DamageYield);
					if (this.armorRating_0 <= GlobalVariables.ArmorRating.RHA_20mm)
					{
						this.float_2 = (float)Math.Round((double)this.float_2 - DamageYield, 1);
						if (Math.Round(DamageYield, 2) > 0.0)
						{
							new WeaponImpact(ref base.method_18().scenario_0, base.method_18().vmethod_28(null), base.method_18().vmethod_30(null), base.method_18().vmethod_14(false), WeaponImpact.Enum124.const_0, 0);
							if (this.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
							{
								base.method_18().method_124(Misc.smethod_9(this.Name) + " has suffered fragmentation damage: " + Conversions.ToString(Math.Ceiling(DamageYield)) + " DPs", Misc.smethod_9(this.Name) + " damaged", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
							}
							else
							{
								base.method_18().method_124(Misc.smethod_9(this.Name) + " has suffered additional fragmentation damage: " + Conversions.ToString(Math.Ceiling(DamageYield)) + " DPs", Misc.smethod_9(this.Name) + " damaged", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
							}
							if (this.float_2 <= 0f)
							{
								this.float_2 = 0f;
								if (!base.method_18().bool_2)
								{
									base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(this.Name) + " has been destroyed!", base.method_18().Name + " lost a mount/weapon", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
								}
								this.vmethod_6(base.method_18().vmethod_7(false), false, base.method_18().method_6());
							}
							else
							{
								int num = GameGeneral.smethod_5().Next(0, 3);
								if (num != 0)
								{
									if (num != 1)
									{
										if (base.method_16() < PlatformComponent._DamageSeverityFactor.Heavy)
										{
											this.vmethod_8(PlatformComponent._DamageSeverityFactor.Heavy);
										}
									}
									else if (base.method_16() < PlatformComponent._DamageSeverityFactor.Medium)
									{
										this.vmethod_8(PlatformComponent._DamageSeverityFactor.Medium);
									}
								}
								else if (base.method_16() < PlatformComponent._DamageSeverityFactor.Light)
								{
									this.vmethod_8(PlatformComponent._DamageSeverityFactor.Light);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100681", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x00194D74 File Offset: 0x00192F74
		public void method_46(double double_0, Warhead.WarheadType warheadType_0, float float_3)
		{
			try
			{
				if (double_0 != 0.0)
				{
					this.method_47(ref double_0, warheadType_0);
					this.float_2 = (float)Math.Round((double)this.float_2 - double_0, 1);
					this.method_44(double_0);
					if (Math.Round(double_0, 2) > 0.0)
					{
						new WeaponImpact(ref base.method_18().scenario_0, base.method_18().vmethod_28(null), base.method_18().vmethod_30(null), base.method_18().vmethod_14(false), WeaponImpact.Enum124.const_0, 0);
						base.method_18().method_124(Misc.smethod_9(this.Name) + " has suffered bomblet damage: " + Conversions.ToString(Math.Round(double_0, 1)) + " DPs", Misc.smethod_9(this.Name) + " damaged", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
						if (this.float_2 > 0f && (!base.method_18().method_6() || !((Facility)base.method_18()).method_154()))
						{
							int num = GameGeneral.smethod_5().Next(0, 3);
							if (num != 0)
							{
								if (num != 1)
								{
									if (base.method_16() < PlatformComponent._DamageSeverityFactor.Heavy)
									{
										this.vmethod_8(PlatformComponent._DamageSeverityFactor.Heavy);
									}
								}
								else if (base.method_16() < PlatformComponent._DamageSeverityFactor.Medium)
								{
									this.vmethod_8(PlatformComponent._DamageSeverityFactor.Medium);
								}
							}
							else if (base.method_16() < PlatformComponent._DamageSeverityFactor.Light)
							{
								this.vmethod_8(PlatformComponent._DamageSeverityFactor.Light);
							}
						}
						else
						{
							this.float_2 = 0f;
							if (!base.method_18().bool_2)
							{
								base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(this.Name) + " has been destroyed!", base.method_18().Name + " lost a mount/weapon", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
							}
							this.vmethod_6(base.method_18().vmethod_7(false), false, base.method_18().method_6());
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100682", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00195034 File Offset: 0x00193234
		private void method_47(ref double double_0, Warhead.WarheadType warheadType_0)
		{
			if (warheadType_0 != Warhead.WarheadType.SuperFrag)
			{
				switch (warheadType_0)
				{
				case Warhead.WarheadType.Cluster_AP:
				{
					GlobalVariables.ArmorRating armorRating = this.armorRating_0;
					if (armorRating == GlobalVariables.ArmorRating.None)
					{
						return;
					}
					if (armorRating == GlobalVariables.ArmorRating.Light)
					{
						double_0 = 0.5 * double_0;
						return;
					}
					double_0 = 0.0;
					return;
				}
				case Warhead.WarheadType.Cluster_AT:
					break;
				case Warhead.WarheadType.Cluster_Penetrator:
				{
					if (base.method_7())
					{
						return;
					}
					GlobalVariables.ArmorRating armorRating2 = this.armorRating_0;
					if (armorRating2 == GlobalVariables.ArmorRating.None)
					{
						return;
					}
					switch (armorRating2)
					{
					case GlobalVariables.ArmorRating.Light:
						double_0 = 0.9 * double_0;
						return;
					case GlobalVariables.ArmorRating.Medium:
						double_0 = 0.7 * double_0;
						return;
					case GlobalVariables.ArmorRating.Heavy:
						double_0 = 0.5 * double_0;
						return;
					case GlobalVariables.ArmorRating.Special:
						double_0 = 0.2 * double_0;
						return;
					default:
						return;
					}
					break;
				}
				default:
					if (warheadType_0 != Warhead.WarheadType.Cluster_SmartSubs)
					{
						return;
					}
					break;
				}
				if (!base.method_7())
				{
					GlobalVariables.ArmorRating armorRating3 = this.armorRating_0;
					if (armorRating3 != GlobalVariables.ArmorRating.None)
					{
						if (armorRating3 == GlobalVariables.ArmorRating.Light)
						{
							double_0 = 0.7 * double_0;
							return;
						}
						if (armorRating3 != GlobalVariables.ArmorRating.Medium)
						{
							double_0 = 0.0;
							return;
						}
						double_0 = 0.5 * double_0;
						return;
					}
				}
			}
			else
			{
				GlobalVariables.ArmorRating armorRating4 = this.armorRating_0;
				if (armorRating4 != GlobalVariables.ArmorRating.None && armorRating4 != GlobalVariables.ArmorRating.Light)
				{
					double_0 = 0.0;
					return;
				}
			}
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00195198 File Offset: 0x00193398
		public void method_48(double double_0, Warhead.WarheadType warheadType_0)
		{
			try
			{
				GlobalVariables.ArmorRating armorRating = this.armorRating_0;
				int num;
				if (armorRating != GlobalVariables.ArmorRating.None)
				{
					switch (armorRating)
					{
					case GlobalVariables.ArmorRating.Light:
						num = 10;
						break;
					case GlobalVariables.ArmorRating.Medium:
						num = 30;
						break;
					case GlobalVariables.ArmorRating.Heavy:
						num = 75;
						break;
					case GlobalVariables.ArmorRating.Special:
						num = 100;
						break;
					}
				}
				else
				{
					num = 1;
				}
				if (!base.method_18().bool_2)
				{
					base.method_18().method_124(Misc.smethod_9(this.Name) + " has suffered blast damage: " + Conversions.ToString(Math.Round(double_0, 1)) + " DPs", Misc.smethod_9(this.Name) + " damaged", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
				}
				this.method_44(double_0);
				if (double_0 > (double)num)
				{
					new WeaponImpact(ref base.method_18().scenario_0, base.method_18().vmethod_28(null), base.method_18().vmethod_30(null), base.method_18().vmethod_14(false), WeaponImpact.Enum124.const_0, 0);
					if (!base.method_18().bool_2)
					{
						base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(this.Name) + " has been destroyed!", base.method_18().Name + " lost a mount/weapon", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
					}
					this.vmethod_6(base.method_18().vmethod_7(false), false, base.method_18().method_6());
				}
				else if (double_0 > (double)num / 2.0)
				{
					new WeaponImpact(ref base.method_18().scenario_0, base.method_18().vmethod_28(null), base.method_18().vmethod_30(null), base.method_18().vmethod_14(false), WeaponImpact.Enum124.const_0, 0);
					if (!base.method_18().bool_2)
					{
						base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(this.Name) + " has been damaged.", base.method_18().Name + " - damage to mount/weapon", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
					}
					this.vmethod_8(PlatformComponent._DamageSeverityFactor.Medium);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100683", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x001954E8 File Offset: 0x001936E8
		public override void vmethod_9(float float_3)
		{
			Sensor[] array = this.method_36();
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i].vmethod_9(float_3);
				}
				CommDevice[] array2 = this.commDevice_0;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].vmethod_9(float_3);
				}
			}
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00195534 File Offset: 0x00193734
		private void method_49(object sender, EventArgs5<WeaponRec> e)
		{
			try
			{
				foreach (WeaponRec weaponRec in e.method_0())
				{
					Mount.Delegate44 @delegate = Mount.delegate44_0;
					if (@delegate != null)
					{
						@delegate(this.string_0, weaponRec.string_0);
					}
				}
			}
			finally
			{
				IEnumerator<WeaponRec> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00195598 File Offset: 0x00193798
		private void method_50(object sender, EventArgs5<WeaponRec> e)
		{
			try
			{
				foreach (WeaponRec weaponRec in e.method_0())
				{
					Mount.Delegate45 @delegate = Mount.delegate45_0;
					if (@delegate != null)
					{
						@delegate(this.string_0, weaponRec.string_0);
					}
				}
			}
			finally
			{
				IEnumerator<WeaponRec> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x04001202 RID: 4610
		public GlobalVariables.ArmorRating armorRating_0;

		// Token: 0x04001203 RID: 4611
		public int int_0;

		// Token: 0x04001204 RID: 4612
		public int int_1;

		// Token: 0x04001205 RID: 4613
		public bool bool_11;

		// Token: 0x04001206 RID: 4614
		public bool bool_12;

		// Token: 0x04001207 RID: 4615
		public bool bool_13;

		// Token: 0x04001208 RID: 4616
		public bool bool_14;

		// Token: 0x04001209 RID: 4617
		public Mount.Enum113 enum113_0;

		// Token: 0x0400120A RID: 4618
		public bool bool_15;

		// Token: 0x0400120B RID: 4619
		[CompilerGenerated]
		[AccessedThroughProperty("MountWeapons")]
		private ObservableList<WeaponRec> observableList_0;

		// Token: 0x0400120C RID: 4620
		private Magazine magazine_0;

		// Token: 0x0400120D RID: 4621
		private int int_2;

		// Token: 0x0400120E RID: 4622
		private int int_3;

		// Token: 0x0400120F RID: 4623
		private Sensor[] sensor_0;

		// Token: 0x04001210 RID: 4624
		public CommDevice[] commDevice_0;

		// Token: 0x04001211 RID: 4625
		private float float_0;

		// Token: 0x04001212 RID: 4626
		private float float_1;

		// Token: 0x04001213 RID: 4627
		public float float_2;

		// Token: 0x04001214 RID: 4628
		public bool bool_16;

		// Token: 0x04001215 RID: 4629
		public HashSet<int> hashSet_0;

		// Token: 0x04001216 RID: 4630
		private int? nullable_0;

		// Token: 0x04001217 RID: 4631
		private float? nullable_1;

		// Token: 0x04001218 RID: 4632
		public HashSet<int> hashSet_1;

		// Token: 0x04001219 RID: 4633
		public bool bool_17;

		// Token: 0x0400121A RID: 4634
		public short short_0;

		// Token: 0x0400121B RID: 4635
		public short short_1;

		// Token: 0x0400121C RID: 4636
		public CargoType cargoType_0;

		// Token: 0x0400121D RID: 4637
		public short short_2;

		// Token: 0x0400121E RID: 4638
		public bool bool_18;

		// Token: 0x0400121F RID: 4639
		public Facility._MobileUnitCategory _MobileUnitCategory_0;

		// Token: 0x04001220 RID: 4640
		[CompilerGenerated]
		private static Mount.Delegate44 delegate44_0;

		// Token: 0x04001221 RID: 4641
		[CompilerGenerated]
		private static Mount.Delegate45 delegate45_0;

		// Token: 0x04001222 RID: 4642
		private StringBuilder stringBuilder_0;

		// Token: 0x04001223 RID: 4643
		private bool? nullable_2;

		// Token: 0x04001224 RID: 4644
		private bool? nullable_3;

		// Token: 0x020002DB RID: 731
		// (Invoke) Token: 0x060015BA RID: 5562
		internal delegate void Delegate44(string MountObjectID, string WeaponRecObjectID);

		// Token: 0x020002DC RID: 732
		// (Invoke) Token: 0x060015BE RID: 5566
		internal delegate void Delegate45(string MountObjectID, string WeaponRecObjectID);

		// Token: 0x020002DD RID: 733
		internal enum Enum113 : byte
		{
			// Token: 0x04001226 RID: 4646
			const_0,
			// Token: 0x04001227 RID: 4647
			const_1,
			// Token: 0x04001228 RID: 4648
			const_2
		}
	}
}
