using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns12;
using ns13;
using ns14;
using Sharp3D.Math.Core;

namespace Command_Core
{
	// Token: 0x020002E8 RID: 744
	public sealed class Sensor : PlatformComponent
	{
		// Token: 0x060015F2 RID: 5618 RVA: 0x00196B40 File Offset: 0x00194D40
		public string method_23(HashSet<string> hashSet_1)
		{
			string result;
			try
			{
				if (this.stringBuilder_0 == null)
				{
					this.stringBuilder_0 = new StringBuilder(1000);
				}
				else
				{
					this.stringBuilder_0.Clear();
				}
				this.stringBuilder_0.Append("<Sensor>");
				this.stringBuilder_0.Append("<ID>").Append(this.string_0).Append("</ID>");
				if (!Information.IsNothing(hashSet_1))
				{
					if (hashSet_1.Contains(this.string_0))
					{
						this.stringBuilder_0.Append("</Sensor>");
						return this.stringBuilder_0.ToString();
					}
					hashSet_1.Add(this.string_0);
				}
				this.stringBuilder_0.Append("<DBID>").Append(this.DBID.ToString()).Append("</DBID>");
				if (this._ComponentStatus_0 != PlatformComponent._ComponentStatus.Operational)
				{
					StringBuilder stringBuilder = this.stringBuilder_0.Append("<St>");
					byte componentStatus_ = (byte)this._ComponentStatus_0;
					stringBuilder.Append(componentStatus_.ToString()).Append("</St>");
				}
				if (base.method_16() != PlatformComponent._DamageSeverityFactor.Light)
				{
					this.stringBuilder_0.Append("<DamageSeverity>").Append(((byte)base.method_16()).ToString()).Append("</DamageSeverity>");
				}
				this.stringBuilder_0.Append("<Name>").Append(SecurityElement.Escape(this.Name)).Append("</Name>");
				if (this.class295_0.method_2())
				{
					this.stringBuilder_0.Append(this.class295_0.method_0(false));
				}
				if (this.class295_1.method_2())
				{
					this.stringBuilder_0.Append(this.class295_1.method_0(true));
				}
				if (this.list_0.Count > 0)
				{
					this.stringBuilder_0.Append("<TTFFC>");
					try
					{
						foreach (Contact contact in this.list_0)
						{
							if (!Information.IsNothing(contact))
							{
								this.stringBuilder_0.Append("<ID>").Append(contact.string_0).Append("</ID>");
							}
						}
					}
					finally
					{
						List<Contact>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.stringBuilder_0.Append("</TTFFC>");
				}
				if (this.list_1.Count > 0)
				{
					this.stringBuilder_0.Append("<SAWG>");
					List<Weapon> list = Enumerable.ToList<Weapon>(this.list_1);
					try
					{
						foreach (Weapon weapon in list)
						{
							if (!Information.IsNothing(weapon))
							{
								this.stringBuilder_0.Append("<ID>").Append(weapon.string_0).Append("</ID>");
							}
						}
					}
					finally
					{
						List<Weapon>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					this.stringBuilder_0.Append("</SAWG>");
				}
				if (this.method_43())
				{
					this.stringBuilder_0.Append("<IsA>True</IsA>");
				}
				this.stringBuilder_0.Append("</Sensor>");
				result = this.stringBuilder_0.ToString();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100693", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00196EE0 File Offset: 0x001950E0
		private Sensor() : base(null)
		{
			this.struct32_0 = default(Sensor.Struct32);
			this.struct33_0 = default(Sensor.Struct33);
			this.radioElectronicFrequency_0 = new Sensor.RadioElectronicFrequency[0];
			this.radioElectronicFrequency_1 = new Sensor.RadioElectronicFrequency[0];
			this.list_0 = new List<Contact>();
			this.list_1 = new List<Weapon>();
			this.list_2 = new List<string>();
			this.class295_1 = new PlatformComponent.Class295();
			this.class565_0 = new Class563.Class565();
			this.struct54_0 = default(Class563.Struct54);
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00196F68 File Offset: 0x00195168
		public static Sensor smethod_2(XmlNode xmlNode_0, Dictionary<string, Class310> dictionary_0, ActiveUnit activeUnit_1)
		{
			Sensor result;
			try
			{
				Sensor sensor = new Sensor();
				sensor.method_19(activeUnit_1);
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 1376249658U)
						{
							if (num <= 330354518U)
							{
								if (num <= 266367750U)
								{
									if (num != 6222351U)
									{
										if (num != 266367750U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Name", false) == 0)
										{
											sensor.Name = xmlNode.InnerText;
											continue;
										}
										continue;
									}
									else if (Operators.CompareString(name, "Status", false) != 0)
									{
										continue;
									}
								}
								else if (num != 280566373U)
								{
									if (num != 330354518U)
									{
										continue;
									}
									if (Operators.CompareString(name, "SemiActiveWeaponsGuided", false) != 0)
									{
										continue;
									}
									goto IL_4C8;
								}
								else
								{
									if (Operators.CompareString(name, "TargetsIlluminated", false) != 0)
									{
										continue;
									}
									goto IL_1ED;
								}
							}
							else if (num <= 1258451042U)
							{
								if (num != 429170076U)
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
									if (Operators.CompareString(name, "IsA", false) != 0)
									{
										continue;
									}
									goto IL_441;
								}
							}
							else if (num != 1351886453U)
							{
								if (num != 1376249658U)
								{
									continue;
								}
								if (Operators.CompareString(name, "TTFFC", false) != 0)
								{
									continue;
								}
								goto IL_1ED;
							}
							else
							{
								if (Operators.CompareString(name, "TargetsTrackedForFireControl", false) == 0)
								{
									goto IL_1ED;
								}
								continue;
							}
							string innerText = xmlNode.InnerText;
							if (Operators.CompareString(innerText, "Operational", false) == 0)
							{
								sensor._ComponentStatus_0 = PlatformComponent._ComponentStatus.Operational;
								continue;
							}
							if (Operators.CompareString(innerText, "Damaged", false) == 0)
							{
								sensor._ComponentStatus_0 = PlatformComponent._ComponentStatus.Damaged;
								continue;
							}
							if (Operators.CompareString(innerText, "Destroyed", false) != 0)
							{
								sensor._ComponentStatus_0 = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode.InnerText);
								continue;
							}
							sensor._ComponentStatus_0 = PlatformComponent._ComponentStatus.Destroyed;
							continue;
							IL_1ED:
							try
							{
								foreach (object obj2 in xmlNode.ChildNodes)
								{
									Contact item = Contact.smethod_0(((XmlNode)obj2).InnerText, ref dictionary_0);
									sensor.list_0.Add(item);
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
						if (num <= 1548823463U)
						{
							if (num <= 1458105184U)
							{
								if (num != 1413108551U)
								{
									if (num != 1458105184U)
									{
										continue;
									}
									if (Operators.CompareString(name, "ID", false) != 0 || Information.IsNothing(dictionary_0))
									{
										continue;
									}
									if (!dictionary_0.ContainsKey(xmlNode.InnerText))
									{
										sensor.vmethod_0(xmlNode.InnerText);
										dictionary_0.Add(sensor.string_0, sensor);
										continue;
									}
									return (Sensor)dictionary_0[xmlNode.InnerText];
								}
								else
								{
									if (Operators.CompareString(name, "Cov_Ill", false) != 0)
									{
										continue;
									}
									goto IL_4AA;
								}
							}
							else if (num != 1528329603U)
							{
								if (num != 1548823463U)
								{
									continue;
								}
								if (Operators.CompareString(name, "DamageSeverity", false) == 0)
								{
									sensor.method_17((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode.InnerText));
									continue;
								}
								continue;
							}
							else if (Operators.CompareString(name, "Cov", false) != 0)
							{
								continue;
							}
						}
						else if (num <= 2187602126U)
						{
							if (num != 2130724671U)
							{
								if (num != 2187602126U)
								{
									continue;
								}
								if (Operators.CompareString(name, "DBID", false) == 0)
								{
									int num2 = Conversions.ToInteger(xmlNode.InnerText);
									SQLiteConnection sqliteConnection = activeUnit_1.scenario_0.method_39();
									Sensor sensor2 = DBFunctions.smethod_97(num2, ref sqliteConnection);
									sensor2.vmethod_0(sensor.string_0);
									sensor2._ComponentStatus_0 = sensor.vmethod_5();
									sensor2.Name = sensor.Name;
									sensor2.DBID = Conversions.ToInteger(xmlNode.InnerText);
									sensor2.class295_0 = sensor.class295_0;
									try
									{
										foreach (Contact item2 in sensor.method_41())
										{
											sensor2.list_0.Add(item2);
										}
									}
									finally
									{
										List<Contact>.Enumerator enumerator3;
										((IDisposable)enumerator3).Dispose();
									}
									sensor2.list_1 = sensor.list_1;
									if (sensor.method_43())
									{
										sensor2.method_77();
									}
									sensor = sensor2;
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "IsActive", false) == 0)
								{
									goto IL_441;
								}
								continue;
							}
						}
						else if (num != 2890953655U)
						{
							if (num != 2967663950U)
							{
								if (num != 3309953595U)
								{
									continue;
								}
								if (Operators.CompareString(name, "Coverage", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Coverage_Illuminate", false) == 0)
								{
									goto IL_4AA;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "SAWG", false) == 0)
							{
								goto IL_4C8;
							}
							continue;
						}
						sensor.class295_0 = PlatformComponent.Class295.smethod_0(ref xmlNode);
						continue;
						IL_4AA:
						sensor.class295_1 = PlatformComponent.Class295.smethod_0(ref xmlNode);
						continue;
						IL_441:
						sensor.bool_11 = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_4C8:
						try
						{
							foreach (object obj3 in xmlNode.ChildNodes)
							{
								XmlNode xmlNode2 = (XmlNode)obj3;
								sensor.list_2.Add(xmlNode2.ChildNodes[0].InnerText);
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
				if (string.IsNullOrEmpty(sensor.Name))
				{
					if (sensor.DBID == 0)
					{
						sensor.Name = "Mk1 Eyeball";
					}
					else
					{
						Class310 @class = sensor;
						int dbid = sensor.DBID;
						SQLiteConnection sqliteConnection = activeUnit_1.scenario_0.method_39();
						@class.Name = DBFunctions.smethod_96(dbid, ref sqliteConnection);
					}
				}
				result = sensor;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100694", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Sensor();
			}
			return result;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x0000B9A8 File Offset: 0x00009BA8
		public override PlatformComponent._ComponentStatus vmethod_5()
		{
			return base.vmethod_5();
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x001975D4 File Offset: 0x001957D4
		public bool method_24()
		{
			return this.int_2 <= 0 || this.method_41().Count > 0;
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00197604 File Offset: 0x00195804
		public bool method_25()
		{
			return this.int_3 <= 0;
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00197624 File Offset: 0x00195824
		public bool method_26(bool bool_15, bool bool_16)
		{
			Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
			if (sensor_Type != Sensor.Sensor_Type.Radar)
			{
				if (sensor_Type - Sensor.Sensor_Type.Visual <= 1)
				{
					return true;
				}
			}
			else if (bool_15 && this.struct33_0.bool_1)
			{
				return true;
			}
			return bool_16 && this.method_74() && !this.method_43();
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x0019767C File Offset: 0x0019587C
		public bool method_27()
		{
			Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
			if (sensor_Type != Sensor.Sensor_Type.ESM)
			{
				if (sensor_Type != Sensor.Sensor_Type.PingIntercept)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x001976AC File Offset: 0x001958AC
		public bool method_28(Sensor.FrequencyBand frequencyBand_0)
		{
			Sensor.RadioElectronicFrequency[] array = this.radioElectronicFrequency_0;
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].frequencyBand_0 == frequencyBand_0)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x001976E4 File Offset: 0x001958E4
		public bool method_29(Sensor.FrequencyBand frequencyBand_0)
		{
			Sensor.RadioElectronicFrequency[] array = this.radioElectronicFrequency_1;
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].frequencyBand_0 == frequencyBand_0)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x0000BD2F File Offset: 0x00009F2F
		public float method_30()
		{
			return this.method_31() + this.method_32();
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x0019771C File Offset: 0x0019591C
		public float method_31()
		{
			float result;
			try
			{
				float num;
				if (this.class295_0.bool_11 || this.class295_0.bool_0)
				{
					num = (float)((double)this.float_0 * Math2.smethod_1(22.5));
				}
				if (this.class295_0.bool_3 || this.class295_0.bool_8)
				{
					num = (float)((double)this.float_0 * Math2.smethod_1(45.0));
				}
				if (this.class295_0.bool_10 || this.class295_0.bool_1)
				{
					num = (float)((double)this.float_0 * Math2.smethod_1(67.5));
				}
				if (this.class295_0.bool_2 || this.class295_0.bool_9)
				{
					num = this.float_0;
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100695", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00197834 File Offset: 0x00195A34
		public float method_32()
		{
			float result;
			try
			{
				float num;
				if (this.class295_0.bool_15 || this.class295_0.bool_4)
				{
					num = (float)((double)this.float_0 * Math2.smethod_1(22.5));
				}
				if (this.class295_0.bool_7 || this.class295_0.bool_12)
				{
					num = (float)((double)this.float_0 * Math2.smethod_1(45.0));
				}
				if (this.class295_0.bool_14 || this.class295_0.bool_5)
				{
					num = (float)((double)this.float_0 * Math2.smethod_1(67.5));
				}
				if (this.class295_0.bool_6 || this.class295_0.bool_13)
				{
					num = this.float_0;
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100696", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x0019794C File Offset: 0x00195B4C
		public bool method_33(Sensor sensor_0)
		{
			bool result;
			if (!this.method_64())
			{
				result = false;
			}
			else if (!this.method_127(sensor_0))
			{
				result = false;
			}
			else
			{
				Sensor.Sensor_Type sensor_Type = sensor_0.sensor_Type_0;
				if (sensor_Type <= Sensor.Sensor_Type.HullSonar_ActiveOnly)
				{
					if (sensor_Type - Sensor.Sensor_Type.Radar <= 1)
					{
						return this.method_69() || this.method_72();
					}
					if (sensor_Type == Sensor.Sensor_Type.Infrared)
					{
						return this.sensor_Role_0 == Sensor.Sensor_Role.IRCM;
					}
					if (sensor_Type - Sensor.Sensor_Type.HullSonar_ActivePassive <= 1)
					{
						goto IL_92;
					}
				}
				else if (sensor_Type == Sensor.Sensor_Type.TowedArray_ActiveOnly || sensor_Type == Sensor.Sensor_Type.VDS_ActiveOnly || sensor_Type - Sensor.Sensor_Type.DippingSonar_ActivePassive <= 1)
				{
					goto IL_92;
				}
				return false;
				IL_92:
				result = (this.sensor_Role_0 == Sensor.Sensor_Role.ECM_AcousticJammer);
			}
			return result;
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00197A00 File Offset: 0x00195C00
		public bool method_34(CommDevice commDevice_0)
		{
			return this.method_64() && this.method_126(commDevice_0) && commDevice_0.commLinkType_0 != CommDevice.CommLinkType.Land_Line;
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00197A3C File Offset: 0x00195C3C
		public bool method_35(Sensor sensor_0)
		{
			bool result;
			if (Information.IsNothing(base.method_18()))
			{
				result = false;
			}
			else if (this.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
			{
				result = false;
			}
			else if (!this.method_127(sensor_0))
			{
				result = false;
			}
			else
			{
				Sensor.Sensor_Type sensor_Type = sensor_0.sensor_Type_0;
				if (sensor_Type <= Sensor.Sensor_Type.HullSonar_ActiveOnly)
				{
					if (sensor_Type - Sensor.Sensor_Type.Radar <= 1)
					{
						return this.method_69() || this.method_72();
					}
					if (sensor_Type == Sensor.Sensor_Type.Infrared)
					{
						return this.sensor_Role_0 == Sensor.Sensor_Role.IRCM;
					}
					if (sensor_Type - Sensor.Sensor_Type.HullSonar_ActivePassive <= 1)
					{
						goto IL_A6;
					}
				}
				else if (sensor_Type == Sensor.Sensor_Type.TowedArray_ActiveOnly || sensor_Type == Sensor.Sensor_Type.VDS_ActiveOnly || sensor_Type - Sensor.Sensor_Type.DippingSonar_ActivePassive <= 1)
				{
					goto IL_A6;
				}
				return false;
				IL_A6:
				result = (this.sensor_Role_0 == Sensor.Sensor_Role.ECM_AcousticJammer);
			}
			return result;
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00197B04 File Offset: 0x00195D04
		public long method_36()
		{
			long result;
			if (this.long_0 > 0L)
			{
				result = this.long_0;
			}
			else if (this.radioElectronicFrequency_0.Length == 0)
			{
				result = 0L;
			}
			else
			{
				long num = 0L;
				foreach (Sensor.RadioElectronicFrequency radioElectronicFrequency in this.radioElectronicFrequency_0)
				{
					if (radioElectronicFrequency.method_1() > num)
					{
						num = radioElectronicFrequency.method_1();
					}
				}
				result = num;
			}
			return result;
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00197B7C File Offset: 0x00195D7C
		public long method_37()
		{
			long result;
			if (this.long_1 > 0L)
			{
				result = this.long_1;
			}
			else if (this.radioElectronicFrequency_0.Length == 0)
			{
				result = 0L;
			}
			else
			{
				long num = long.MaxValue;
				foreach (Sensor.RadioElectronicFrequency radioElectronicFrequency in this.radioElectronicFrequency_0)
				{
					if (radioElectronicFrequency.method_2() < num)
					{
						num = radioElectronicFrequency.method_2();
					}
				}
				result = num;
			}
			return result;
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00197BF4 File Offset: 0x00195DF4
		public long method_38()
		{
			long result;
			try
			{
				if (this.long_2 > 0L)
				{
					result = this.long_2;
				}
				else if (this.radioElectronicFrequency_1.Length == 0)
				{
					result = 0L;
				}
				else
				{
					long num = 0L;
					foreach (Sensor.RadioElectronicFrequency radioElectronicFrequency in this.radioElectronicFrequency_1)
					{
						if (radioElectronicFrequency.method_1() > num)
						{
							num = radioElectronicFrequency.method_1();
						}
					}
					result = num;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100698", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0L;
			}
			return result;
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00197CC4 File Offset: 0x00195EC4
		public long method_39()
		{
			long result;
			try
			{
				if (this.long_3 > 0L)
				{
					result = this.long_3;
				}
				else if (this.radioElectronicFrequency_1.Length == 0)
				{
					result = 0L;
				}
				else
				{
					long num = long.MaxValue;
					foreach (Sensor.RadioElectronicFrequency radioElectronicFrequency in this.radioElectronicFrequency_1)
					{
						if (radioElectronicFrequency.method_2() < num)
						{
							num = radioElectronicFrequency.method_2();
						}
					}
					result = num;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100699", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0L;
			}
			return result;
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00197D94 File Offset: 0x00195F94
		public void method_40(ref Scenario scenario_0)
		{
			try
			{
				if (this.list_2.Count > 0)
				{
					try
					{
						foreach (string key in this.list_2)
						{
							Weapon weapon = (Weapon)scenario_0.vmethod_0()[key];
							if (!Information.IsNothing(weapon))
							{
								this.list_1.Add(weapon);
								weapon.method_171(this);
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100700", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x0000BD3E File Offset: 0x00009F3E
		public List<Contact> method_41()
		{
			return this.list_0;
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00197E60 File Offset: 0x00196060
		public bool method_42(float float_37)
		{
			bool result;
			try
			{
				if (this.method_74())
				{
					if (!this.method_43())
					{
						result = false;
					}
					else
					{
						result = true;
					}
				}
				else
				{
					Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
					if (sensor_Type <= Sensor.Sensor_Type.ESM)
					{
						switch (sensor_Type)
						{
						case Sensor.Sensor_Type.Radar:
						{
							if (this.method_67())
							{
								return false;
							}
							if (this.method_57())
							{
								return true;
							}
							if (this.struct32_0.bool_6 && (this.sensor_Role_0 == Sensor.Sensor_Role.Radar_BallisticMissileBattleManagement | this.sensor_Role_0 == Sensor.Sensor_Role.Radar_BallisticMissileEngagement | this.sensor_Role_0 == Sensor.Sensor_Role.Radar_BallisticMissileTracker))
							{
								return true;
							}
							Sensor.RadioElectronicFrequency[] array = this.radioElectronicFrequency_0;
							checked
							{
								for (int i = 0; i < array.Length; i++)
								{
									Sensor.FrequencyBand frequencyBand_ = array[i].frequencyBand_0;
									if (unchecked(frequencyBand_ - Sensor.FrequencyBand.const_2) <= 10L)
									{
										return true;
									}
								}
								return false;
							}
						}
						case Sensor.Sensor_Type.SemiActive:
							break;
						case Sensor.Sensor_Type.Visual:
							if (float_37 < 2f * this.float_34)
							{
								return true;
							}
							return false;
						case Sensor.Sensor_Type.Infrared:
							if (this.struct33_0.bool_1)
							{
								return float_37 < 2f * this.float_36;
							}
							return float_37 < 1f * this.float_36;
						default:
							if (sensor_Type == Sensor.Sensor_Type.ESM)
							{
								return false;
							}
							break;
						}
					}
					else
					{
						if (sensor_Type == Sensor.Sensor_Type.MAD)
						{
							return false;
						}
						if (sensor_Type == Sensor.Sensor_Type.PingIntercept)
						{
							return false;
						}
					}
					result = (this.float_6 == 0f || this.float_8 == 0f);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100701", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x0019805C File Offset: 0x0019625C
		public bool method_43()
		{
			return this.method_58() && this.vmethod_5() == PlatformComponent._ComponentStatus.Operational && this.bool_11;
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x0000BD46 File Offset: 0x00009F46
		public void method_44(bool? nullable_1)
		{
			this.nullable_0 = nullable_1;
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x0000BD4F File Offset: 0x00009F4F
		public bool? method_45()
		{
			return this.nullable_0;
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x0019808C File Offset: 0x0019628C
		public bool method_46()
		{
			Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
			if (sensor_Type <= Sensor.Sensor_Type.LaserRangefinder)
			{
				if (sensor_Type <= Sensor.Sensor_Type.ECM)
				{
					if (sensor_Type == Sensor.Sensor_Type.Radar || sensor_Type == Sensor.Sensor_Type.ECM)
					{
						goto IL_6B;
					}
				}
				else if (sensor_Type == Sensor.Sensor_Type.LaserDesignator || sensor_Type == Sensor.Sensor_Type.LaserRangefinder)
				{
					goto IL_6B;
				}
			}
			else if (sensor_Type <= Sensor.Sensor_Type.TowedArray_ActiveOnly)
			{
				if (sensor_Type == Sensor.Sensor_Type.HullSonar_ActiveOnly || sensor_Type == Sensor.Sensor_Type.TowedArray_ActiveOnly)
				{
					goto IL_6B;
				}
			}
			else
			{
				if (sensor_Type == Sensor.Sensor_Type.VDS_ActiveOnly)
				{
					goto IL_6B;
				}
				if (sensor_Type == Sensor.Sensor_Type.DippingSonar_ActiveOnly)
				{
					goto IL_6B;
				}
			}
			return false;
			IL_6B:
			return true;
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x0000BD57 File Offset: 0x00009F57
		public int method_47()
		{
			if (this.int_1 < 1)
			{
				this.int_1 = 1;
			}
			return this.int_1;
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x0000BD6F File Offset: 0x00009F6F
		public void method_48(int int_4)
		{
			this.int_1 = Math.Max(int_4, 1);
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00198108 File Offset: 0x00196308
		public bool method_49()
		{
			return !this.method_65() && this.sensor_Type_0 != Sensor.Sensor_Type.MAD && Enumerable.Count<Sensor.RadioElectronicFrequency>(this.radioElectronicFrequency_0) == 0;
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00198144 File Offset: 0x00196344
		public bool method_50()
		{
			return this.struct33_0.bool_4 || this.struct33_0.bool_5 || this.struct33_0.bool_6;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00198180 File Offset: 0x00196380
		public bool method_51()
		{
			bool result;
			if (this.sensor_Type_0 != Sensor.Sensor_Type.Radar)
			{
				result = false;
			}
			else
			{
				Sensor.Sensor_Role sensor_Role = this.sensor_Role_0;
				if (sensor_Role <= Sensor.Sensor_Role.FCR_SurfToAir_SurfToSurf_SR)
				{
					long num = sensor_Role - Sensor.Sensor_Role.FCR_AirToAir_LR;
					if (num <= 22L)
					{
						switch ((uint)num)
						{
						case 0U:
						case 1U:
						case 2U:
							return true;
						case 3U:
						case 4U:
						case 5U:
						case 6U:
						case 7U:
						case 8U:
						case 9U:
						case 16U:
						case 17U:
						case 18U:
						case 19U:
							goto IL_104;
						case 10U:
						case 11U:
						case 12U:
							return true;
						case 13U:
						case 14U:
						case 15U:
							return true;
						case 20U:
						case 21U:
						case 22U:
							return true;
						}
					}
					if (sensor_Role - Sensor.Sensor_Role.FCR_SurfToAir_SurfToSurf_LR <= 2L)
					{
						return true;
					}
				}
				else if (sensor_Role - Sensor.Sensor_Role.FCR_SurfToSurf > 1L && sensor_Role != Sensor.Sensor_Role.FCR_SurfToSurf_Torpedo)
				{
					if (sensor_Role == Sensor.Sensor_Role.FCR_GunOnly)
					{
						return true;
					}
				}
				IL_104:
				result = false;
			}
			return result;
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00198294 File Offset: 0x00196494
		public bool method_52()
		{
			Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
			bool result;
			if (sensor_Type == Sensor.Sensor_Type.Radar)
			{
				if (this.method_49())
				{
					result = false;
				}
				else
				{
					Sensor.Sensor_Role sensor_Role = this.sensor_Role_0;
					if (sensor_Role - Sensor.Sensor_Role.TargetIndicator_SurfToAir_2D > 3L)
					{
						long num = sensor_Role - Sensor.Sensor_Role.FCR_AirToAir_AirToSurf_LR;
						if (num <= 22L)
						{
							switch ((uint)num)
							{
							case 0U:
							case 1U:
							case 2U:
							case 3U:
							case 4U:
							case 5U:
							case 10U:
							case 11U:
							case 12U:
							case 20U:
							case 21U:
							case 22U:
								goto IL_CF;
							case 6U:
							case 7U:
							case 8U:
							case 9U:
							case 13U:
							case 14U:
							case 15U:
							case 16U:
							case 17U:
							case 18U:
							case 19U:
								goto IL_CB;
							}
						}
						if (sensor_Role == Sensor.Sensor_Role.FCR_GunOnly)
						{
							goto IL_CF;
						}
						IL_CB:
						return false;
					}
					IL_CF:
					result = true;
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00198378 File Offset: 0x00196578
		public bool method_53()
		{
			Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
			bool result;
			if (sensor_Type == Sensor.Sensor_Type.Radar)
			{
				if (this.method_49())
				{
					result = false;
				}
				else
				{
					Sensor.Sensor_Role sensor_Role = this.sensor_Role_0;
					result = (sensor_Role - Sensor.Sensor_Role.AirSearch_2D_LR <= 5L || sensor_Role - Sensor.Sensor_Role.AirSurfaceSearch_2D_LR <= 8L);
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x001983E0 File Offset: 0x001965E0
		public bool method_54()
		{
			Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
			bool result;
			if (sensor_Type == Sensor.Sensor_Type.ECM)
			{
				Sensor.Sensor_Role sensor_Role = this.sensor_Role_0;
				if (sensor_Role != Sensor.Sensor_Role.ECM_OECM)
				{
					if (sensor_Role != Sensor.Sensor_Role.ECM_OECM_DECM)
					{
						return false;
					}
				}
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00198428 File Offset: 0x00196628
		public bool method_55()
		{
			Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
			if (sensor_Type <= Sensor.Sensor_Type.TVM)
			{
				if (sensor_Type == Sensor.Sensor_Type.None || sensor_Type == Sensor.Sensor_Type.SemiActive || sensor_Type == Sensor.Sensor_Type.TVM)
				{
					goto IL_CF;
				}
			}
			else
			{
				if (sensor_Type == Sensor.Sensor_Type.ECM || sensor_Type - Sensor.Sensor_Type.LaserDesignator <= 2)
				{
					goto IL_CF;
				}
				if (sensor_Type == Sensor.Sensor_Type.SensorGroup)
				{
					goto IL_CF;
				}
			}
			if (this.method_49())
			{
				return false;
			}
			Sensor.Sensor_Role sensor_Role = this.sensor_Role_0;
			if (sensor_Role <= Sensor.Sensor_Role.FCR_GunOnly)
			{
				if (sensor_Role - Sensor.Sensor_Role.NavigationOnly <= 4L || sensor_Role == Sensor.Sensor_Role.FCR_GunOnly)
				{
					goto IL_CB;
				}
			}
			else
			{
				if (sensor_Role - Sensor.Sensor_Role.Illuminator_SAM_LR <= 2L || sensor_Role == Sensor.Sensor_Role.RangeOnly)
				{
					goto IL_CB;
				}
				if (sensor_Role == Sensor.Sensor_Role.HullSonarPassiveOnlyRangingFlankArraySearchTrack)
				{
					goto IL_CB;
				}
			}
			return true;
			IL_CB:
			return false;
			IL_CF:
			return false;
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00198508 File Offset: 0x00196708
		public bool method_56()
		{
			Sensor.Sensor_Role sensor_Role = this.sensor_Role_0;
			return sensor_Role - Sensor.Sensor_Role.HeightFinder_LR <= 2L;
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x0019853C File Offset: 0x0019673C
		public bool method_57()
		{
			return this.int_0 != 0 && (Enumerable.Count<Sensor.RadioElectronicFrequency>(this.radioElectronicFrequency_1) != 0 || this.long_2 != 0L || this.long_3 != 0L);
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x0019857C File Offset: 0x0019677C
		public bool method_58()
		{
			return this.method_65() || (this.sensor_Role_0 != Sensor.Sensor_Role.ECM_DECM && this.sensor_Role_0 != Sensor.Sensor_Role.IRCM && Misc.smethod_17(this.sensor_Type_0));
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x001985CC File Offset: 0x001967CC
		public bool method_59(UnguidedWeapon unguidedWeapon_0)
		{
			bool result;
			if (!this.method_65())
			{
				result = false;
			}
			else
			{
				Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
				if (sensor_Type <= Sensor.Sensor_Type.MineSweep_TwoShipMagneticInfluence)
				{
					switch (sensor_Type)
					{
					case Sensor.Sensor_Type.MineSweep_MechanicalCableCutter:
						return unguidedWeapon_0.method_63() == Weapon._WeaponType.MooredMine;
					case Sensor.Sensor_Type.MineSweep_MagneticInfluence:
						return true;
					case Sensor.Sensor_Type.MineSweep_AcousticInfluence:
						return true;
					case Sensor.Sensor_Type.MineSweep_MultiInfluence:
						return true;
					default:
						if (sensor_Type == Sensor.Sensor_Type.MineSweep_TwoShipMagneticInfluence)
						{
							return true;
						}
						break;
					}
				}
				else
				{
					if (sensor_Type == Sensor.Sensor_Type.MineNeutralization_MooredMineCableCutter)
					{
						return unguidedWeapon_0.method_63() == Weapon._WeaponType.MooredMine;
					}
					if (sensor_Type == Sensor.Sensor_Type.MineNeutralization_ExplosiveChargeMineDisposal)
					{
						return true;
					}
					if (sensor_Type == Sensor.Sensor_Type.MineNeutralization_DiverExplosiveCharge)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00198670 File Offset: 0x00196870
		public Geopoint_Struct[] method_60()
		{
			Geopoint_Struct[] result;
			try
			{
				if (!this.method_65())
				{
					result = null;
				}
				else if (!this.method_43())
				{
					result = null;
				}
				else
				{
					double num = (double)this.short_5 / 1852.0;
					float num2 = Math2.smethod_7(base.method_18().vmethod_9() + 180f);
					Geopoint_Struct geopoint_Struct = default(Geopoint_Struct);
					Geopoint_Struct geopoint_Struct2 = default(Geopoint_Struct);
					Geopoint_Struct geopoint_Struct3 = default(Geopoint_Struct);
					Geopoint_Struct[] array2;
					if (!base.method_18().bool_6 && !base.method_18().bool_5)
					{
						Geopoint_Struct[] array = new Geopoint_Struct[4];
						Class411.smethod_1(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null), ref geopoint_Struct2.double_0, ref geopoint_Struct2.double_1, (double)((float)(num * 3.0)), (double)num2);
						Class411.smethod_1(geopoint_Struct2.double_0, geopoint_Struct2.double_1, ref geopoint_Struct3.double_0, ref geopoint_Struct3.double_1, (double)((float)(num / 2.0)), (double)Math2.smethod_7(num2 - 90f));
						Class411.smethod_1(geopoint_Struct2.double_0, geopoint_Struct2.double_1, ref geopoint_Struct.double_0, ref geopoint_Struct.double_1, (double)((float)(num / 2.0)), (double)Math2.smethod_7(num2 + 90f));
						array[0] = new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null));
						array[1] = geopoint_Struct3;
						array[2] = geopoint_Struct2;
						array[3] = geopoint_Struct;
						array2 = array;
					}
					else
					{
						Geopoint_Struct[] array3 = new Geopoint_Struct[3];
						Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
						if (sensor_Type == Sensor.Sensor_Type.MineSweep_MechanicalCableCutter)
						{
							Class411.smethod_1(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null), ref geopoint_Struct2.double_0, ref geopoint_Struct2.double_1, (double)((float)(num * 3.0)), (double)num2);
							Class411.smethod_1(geopoint_Struct2.double_0, geopoint_Struct2.double_1, ref geopoint_Struct3.double_0, ref geopoint_Struct3.double_1, (double)((float)num), (double)Math2.smethod_7(num2 + 90f));
						}
						else
						{
							Class411.smethod_1(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null), ref geopoint_Struct2.double_0, ref geopoint_Struct2.double_1, (double)((float)(num * 3.0)), (double)num2);
							Class411.smethod_1(geopoint_Struct2.double_0, geopoint_Struct2.double_1, ref geopoint_Struct3.double_0, ref geopoint_Struct3.double_1, (double)((float)num), (double)Math2.smethod_7(num2 + 90f));
						}
						array3[0] = new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null));
						array3[1] = geopoint_Struct2;
						array3[2] = geopoint_Struct3;
						array2 = array3;
					}
					result = array2;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100702", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x001989DC File Offset: 0x00196BDC
		public bool method_61(GlobalVariables.ActiveUnitType activeUnitType_0)
		{
			bool result;
			if (this.sensor_Type_0 == Sensor.Sensor_Type.ESM)
			{
				result = true;
			}
			else if (this.sensor_Type_0 == Sensor.Sensor_Type.PingIntercept)
			{
				result = true;
			}
			else
			{
				switch (activeUnitType_0)
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
				case GlobalVariables.ActiveUnitType.Weapon:
					return this.struct32_0.bool_0;
				case GlobalVariables.ActiveUnitType.Ship:
					return this.struct32_0.bool_1;
				case GlobalVariables.ActiveUnitType.Submarine:
					if (this.sensor_Role_0 != Sensor.Sensor_Role.TASSActiveOnlyTowedArraySonarSystem)
					{
						if (this.sensor_Role_0 != Sensor.Sensor_Role.TASSPassiveTorpedoWarningTowedArraySonarSystem)
						{
							return this.struct32_0.bool_2;
						}
					}
					return true;
				case GlobalVariables.ActiveUnitType.Facility:
					return this.struct32_0.bool_4 || this.struct32_0.bool_3;
				case GlobalVariables.ActiveUnitType.Satellite:
					return this.struct32_0.bool_6;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00198ABC File Offset: 0x00196CBC
		public bool method_62(GlobalVariables.ActiveUnitType activeUnitType_0, Weapon weapon_0)
		{
			bool result;
			try
			{
				if (this.sensor_Type_0 == Sensor.Sensor_Type.ESM)
				{
					if (weapon_0.class394_0.bool_5)
					{
						if (weapon_0.float_29 > 0f)
						{
							return true;
						}
						if (weapon_0.float_31 > 0f)
						{
							return true;
						}
					}
					if (weapon_0.method_208())
					{
						return true;
					}
				}
				if (this.sensor_Type_0 == Sensor.Sensor_Type.PingIntercept)
				{
					result = true;
				}
				else
				{
					switch (activeUnitType_0)
					{
					case GlobalVariables.ActiveUnitType.Aircraft:
					case GlobalVariables.ActiveUnitType.Weapon:
						if (weapon_0.class394_0.bool_2 || weapon_0.class394_0.bool_11 || weapon_0.class394_0.bool_3)
						{
							return this.struct32_0.bool_0;
						}
						break;
					case GlobalVariables.ActiveUnitType.Ship:
						if (this.method_74() || this.method_75())
						{
							return true;
						}
						if (weapon_0.class394_0.bool_0)
						{
							return this.struct32_0.bool_1;
						}
						break;
					case GlobalVariables.ActiveUnitType.Submarine:
						if (weapon_0.class394_0.bool_1)
						{
							return this.struct32_0.bool_2;
						}
						break;
					case GlobalVariables.ActiveUnitType.Facility:
						if (weapon_0.class394_0.bool_8 || weapon_0.class394_0.bool_7 || weapon_0.class394_0.bool_13 || weapon_0.class394_0.bool_12)
						{
							return this.struct32_0.bool_4 || this.struct32_0.bool_3;
						}
						break;
					case GlobalVariables.ActiveUnitType.Satellite:
						if (weapon_0.class394_0.bool_4)
						{
							return this.struct32_0.bool_6;
						}
						break;
					}
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100703", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00198CB0 File Offset: 0x00196EB0
		public bool method_63(ActiveUnit activeUnit_1)
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
					if (this.sensor_Type_0 == Sensor.Sensor_Type.ESM)
					{
						if (!activeUnit_1.bool_5 && !activeUnit_1.bool_8)
						{
							if (activeUnit_1.method_81() && !activeUnit_1.vmethod_26() && !activeUnit_1.vmethod_27())
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
					else if (this.sensor_Role_0 == Sensor.Sensor_Role.IR_MAWS && activeUnit_1.bool_2)
					{
						result = true;
					}
					else
					{
						if (this.sensor_Type_0 == Sensor.Sensor_Type.PingIntercept)
						{
							if (activeUnit_1.bool_5 || activeUnit_1.bool_6)
							{
								return true;
							}
							if (activeUnit_1.bool_2)
							{
								if (activeUnit_1.bool_7)
								{
									return true;
								}
								if (((Weapon)activeUnit_1).method_167() == Weapon._WeaponType.Sonobuoy)
								{
									return true;
								}
							}
							if (activeUnit_1.bool_3 && ((Aircraft)activeUnit_1).method_164().method_36() == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
							{
								return true;
							}
						}
						if (activeUnit_1.bool_3)
						{
							if (((Aircraft)activeUnit_1).method_144())
							{
								result = (this.method_61(GlobalVariables.ActiveUnitType.Aircraft) || this.method_61(GlobalVariables.ActiveUnitType.Ship) || this.method_61(GlobalVariables.ActiveUnitType.Facility));
							}
							else
							{
								result = this.method_61(GlobalVariables.ActiveUnitType.Aircraft);
							}
						}
						else if (activeUnit_1.bool_6)
						{
							result = this.method_61(GlobalVariables.ActiveUnitType.Ship);
						}
						else if (activeUnit_1.bool_5)
						{
							if ((((Submarine)activeUnit_1).method_161() || (this.struct32_0.bool_5 && ((Submarine)activeUnit_1).method_162())) && this.method_61(GlobalVariables.ActiveUnitType.Ship))
							{
								result = true;
							}
							else
							{
								result = this.method_61(GlobalVariables.ActiveUnitType.Submarine);
							}
						}
						else if (activeUnit_1.bool_8)
						{
							if (!this.method_61(GlobalVariables.ActiveUnitType.Facility))
							{
								result = false;
							}
							else if (((Facility)activeUnit_1).method_154())
							{
								result = this.struct32_0.bool_3;
							}
							else
							{
								result = this.struct32_0.bool_4;
							}
						}
						else
						{
							if (activeUnit_1.bool_2)
							{
								Weapon._WeaponType weaponType = ((Weapon)activeUnit_1).method_167();
								if (weaponType <= Weapon._WeaponType.Torpedo)
								{
									if (weaponType == Weapon._WeaponType.GuidedWeapon)
									{
										return this.method_61(GlobalVariables.ActiveUnitType.Aircraft);
									}
									if (weaponType != Weapon._WeaponType.Decoy_Vehicle)
									{
										if (weaponType != Weapon._WeaponType.Torpedo)
										{
											goto IL_2F1;
										}
									}
									else
									{
										if (((Weapon)activeUnit_1).method_88())
										{
											return this.struct32_0.bool_0;
										}
										if (((Weapon)activeUnit_1).method_89())
										{
											return this.struct32_0.bool_1;
										}
										if (((Weapon)activeUnit_1).method_90())
										{
											return this.struct32_0.bool_2;
										}
										goto IL_2F1;
									}
								}
								else if (weaponType <= Weapon._WeaponType.BallisticMissile)
								{
									if (weaponType - Weapon._WeaponType.BottomMine > 4)
									{
										if (weaponType != Weapon._WeaponType.BallisticMissile)
										{
											goto IL_2F1;
										}
										return this.struct32_0.bool_6 || this.method_61(GlobalVariables.ActiveUnitType.Aircraft);
									}
								}
								else
								{
									if (weaponType != Weapon._WeaponType.RV && weaponType != Weapon._WeaponType.HGV)
									{
										goto IL_2F1;
									}
									return this.method_61(GlobalVariables.ActiveUnitType.Satellite) || this.method_61(GlobalVariables.ActiveUnitType.Weapon);
								}
								return this.method_61(GlobalVariables.ActiveUnitType.Submarine);
							}
							IL_2F1:
							result = false;
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100704", "");
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

		// Token: 0x0600161E RID: 5662 RVA: 0x00199008 File Offset: 0x00197208
		public bool method_64()
		{
			bool result;
			try
			{
				if (base.method_18() == null)
				{
					result = false;
				}
				else if (this.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
				{
					result = false;
				}
				else if (Operators.CompareString(this.vmethod_4(), "None", false) == 0)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100705", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00199094 File Offset: 0x00197294
		public override string vmethod_4()
		{
			string result;
			if (Information.IsNothing(base.method_18()))
			{
				result = "None";
			}
			else
			{
				if (base.method_18().bool_5)
				{
					if (this.sensor_Type_0 == Sensor.Sensor_Type.ESM)
					{
						if (!((Submarine)base.method_18()).method_162() && !((Submarine)base.method_18()).method_161())
						{
							return "Submarine must be at periscope depth or shallower";
						}
						if (base.method_18().vmethod_40() > 10f && !((Submarine)base.method_18()).method_161())
						{
							return "ESM mast can be used only at 10 knots or slower.";
						}
					}
					if (this.sensor_Type_0 == Sensor.Sensor_Type.Infrared && ((Submarine)base.method_18())._SubmarineType_0 != Submarine._SubmarineType.ROV && ((Submarine)base.method_18())._SubmarineType_0 != Submarine._SubmarineType.UUV)
					{
						if (!((Submarine)base.method_18()).method_162() && !((Submarine)base.method_18()).method_161())
						{
							return "Submarine must be at periscope depth or shallower";
						}
						if (base.method_18().vmethod_40() > 10f && !((Submarine)base.method_18()).method_161())
						{
							return "Periscope can be used only at 10 knots or slower.";
						}
					}
					if (this.sensor_Type_0 == Sensor.Sensor_Type.Visual && ((Submarine)base.method_18())._SubmarineType_0 != Submarine._SubmarineType.ROV && ((Submarine)base.method_18())._SubmarineType_0 != Submarine._SubmarineType.UUV)
					{
						if (!((Submarine)base.method_18()).method_162() && !((Submarine)base.method_18()).method_161())
						{
							return "Submarine must be at periscope depth or shallower";
						}
						if (base.method_18().vmethod_40() > 10f && !((Submarine)base.method_18()).method_161())
						{
							return "Periscope can be used only at 10 knots or slower.";
						}
					}
					if (this.sensor_Type_0 == Sensor.Sensor_Type.Radar)
					{
						if (!((Submarine)base.method_18()).method_162() && !((Submarine)base.method_18()).method_161())
						{
							return "Submarine must be at periscope depth or shallower";
						}
						if (base.method_18().vmethod_40() > 10f && !((Submarine)base.method_18()).method_161())
						{
							return "Radar mast can be used only at 10 knots or slower.";
						}
					}
				}
				if (this.method_73())
				{
					int num = base.method_18().method_9(false, false, false);
					if (this.sensor_Role_0 != Sensor.Sensor_Role.TASSActiveOnlyTowedArraySonarSystem)
					{
						if (this.sensor_Role_0 != Sensor.Sensor_Role.TASSPassiveTorpedoWarningTowedArraySonarSystem)
						{
							if (num > -150)
							{
								return "Towed arrays cannot function at shallow depth (<150m)";
							}
							goto IL_294;
						}
					}
					if (num > -20)
					{
						return "Torpedo-warning towed arrays cannot function at very shallow depth (<20m)";
					}
				}
				IL_294:
				if (this.method_68() && base.method_18().bool_3 && (((Aircraft)base.method_18()).method_164().method_36() != Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar || base.method_18().vmethod_14(false) > 50f || base.method_18().vmethod_40() != 0f))
				{
					result = "Platform is not hovering & deploying sensor";
				}
				else
				{
					this.method_69();
					if (this.method_46() && !this.method_43())
					{
						result = "Sensor has only active mode and is not active";
					}
					else
					{
						result = "None";
					}
				}
			}
			return result;
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x0000BD7E File Offset: 0x00009F7E
		public bool method_65()
		{
			return this.sensor_Type_0 > (Sensor.Sensor_Type)6000 && this.sensor_Type_0 < (Sensor.Sensor_Type)7000;
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0000BD9C File Offset: 0x00009F9C
		public bool method_66()
		{
			return this.sensor_Type_0 == Sensor.Sensor_Type.MineNeutralization_ExplosiveChargeMineDisposal || this.sensor_Type_0 == Sensor.Sensor_Type.MineNeutralization_DiverExplosiveCharge;
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0000BDBA File Offset: 0x00009FBA
		public bool method_67()
		{
			return this.struct32_0.bool_17 || this.struct32_0.bool_18;
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0000BDD6 File Offset: 0x00009FD6
		public bool method_68()
		{
			return this.sensor_Type_0 == Sensor.Sensor_Type.DippingSonar_ActiveOnly || this.sensor_Type_0 == Sensor.Sensor_Type.DippingSonar_ActivePassive || this.sensor_Type_0 == Sensor.Sensor_Type.DippingSonar_PassiveOnly;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x001993B8 File Offset: 0x001975B8
		public bool method_69()
		{
			Sensor.Sensor_Role sensor_Role = this.sensor_Role_0;
			return sensor_Role == Sensor.Sensor_Role.ECM_DECM || sensor_Role == Sensor.Sensor_Role.ECM_OECM_DECM || sensor_Role == Sensor.Sensor_Role.IRCM;
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x001993FC File Offset: 0x001975FC
		public bool method_70()
		{
			Sensor.Sensor_Role sensor_Role = this.sensor_Role_0;
			if (sensor_Role <= Sensor.Sensor_Role.HullSonarActiveOnlyMineHuntingASWMortarFireControl)
			{
				if (sensor_Role == Sensor.Sensor_Role.LLTV_MineRecon)
				{
					return true;
				}
				if (sensor_Role - Sensor.Sensor_Role.HullSonarActiveOnlyMineReconnaissance <= 2L)
				{
					goto IL_63;
				}
			}
			else
			{
				if (sensor_Role - Sensor.Sensor_Role.VDSActiveOnlyMineReconnaissanceVariableDepthSonar <= 3L)
				{
					goto IL_63;
				}
				if (sensor_Role == Sensor.Sensor_Role.HelicopterTowedActiveOnlyMineReconnaissanceSonar)
				{
					goto IL_63;
				}
			}
			return false;
			IL_63:
			return true;
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00199470 File Offset: 0x00197670
		public bool method_71()
		{
			Sensor.Sensor_Role sensor_Role = this.sensor_Role_0;
			return sensor_Role == Sensor.Sensor_Role.ECM_COMINT_Jammer;
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00199498 File Offset: 0x00197698
		public bool method_72()
		{
			Sensor.Sensor_Role sensor_Role = this.sensor_Role_0;
			if (sensor_Role != Sensor.Sensor_Role.ECM_OECM && sensor_Role != Sensor.Sensor_Role.ECM_OECM_DECM)
			{
				if (sensor_Role != Sensor.Sensor_Role.ECM_COMINT_Jammer)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x001994DC File Offset: 0x001976DC
		public bool method_73()
		{
			Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
			return sensor_Type - Sensor.Sensor_Type.TowedArray_PassiveOnly <= 2;
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00199504 File Offset: 0x00197704
		public bool method_74()
		{
			Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
			if (sensor_Type <= Sensor.Sensor_Type.TowedArray_ActiveOnly)
			{
				if (sensor_Type - Sensor.Sensor_Type.HullSonar_PassiveOnly <= 2 || sensor_Type - Sensor.Sensor_Type.TowedArray_PassiveOnly <= 2)
				{
					goto IL_47;
				}
			}
			else
			{
				if (sensor_Type - Sensor.Sensor_Type.VDS_PassiveOnly <= 2 || sensor_Type - Sensor.Sensor_Type.DippingSonar_PassiveOnly <= 2)
				{
					goto IL_47;
				}
				if (sensor_Type == Sensor.Sensor_Type.BottomFixedSonar_PassiveOnly)
				{
					goto IL_47;
				}
			}
			return false;
			IL_47:
			return true;
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0019955C File Offset: 0x0019775C
		public bool method_75()
		{
			Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
			return sensor_Type == Sensor.Sensor_Type.PingIntercept;
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00199580 File Offset: 0x00197780
		public Sensor(ref SQLiteConnection theConn, int SensorDBID, string theName, Sensor.Sensor_Type theSensorType, Sensor.Sensor_Role theSensorRole, GlobalVariables.TechGenerationClass theGeneration, float theMaxRange, float theMinRange, byte theArcLeft, byte theArcRight, int thePassiveInput, int theMaxIntercept, float theMaxAltitude, float theMinAltitude, float theMaxAltitude_ASL, float theMinAltitude_ASL, int theScanInterval, float theRangeResolution, float theAngleResolution, float theHeightResolution, bool IsEyeball, short theMasqueradeAs = 0, short theMaxContactsAir = 0, short theMaxContactsSurface = 0, short theMaxContactsSub = 0, float theAvailability = 0f, long theUpperFreq = 0L, long theLowerFreq = 0L, long theUpperFreqIlluminate = 0L, long theLowerFreqIlluminate = 0L, float theECMGain = 0f, float theECMPeakPower = 0f, float theECMBandwidth = 0f, float theECMNumberofTargets = 0f, float theECMPokReduction = 0f, float DFAccuracy = 0f, short theMineSweepWidth = 0, short theMineMaxSpeed = 0, float theVisualDetectZoom = 0f, float theVisualClassZoom = 0f, float theIRDetectZoom = 0f, float theIRClassZoom = 0f, bool IsHypothetical = false)
		{
			this.struct32_0 = default(Sensor.Struct32);
			this.struct33_0 = default(Sensor.Struct33);
			this.radioElectronicFrequency_0 = new Sensor.RadioElectronicFrequency[0];
			this.radioElectronicFrequency_1 = new Sensor.RadioElectronicFrequency[0];
			this.list_0 = new List<Contact>();
			this.list_1 = new List<Weapon>();
			this.list_2 = new List<string>();
			this.class295_1 = new PlatformComponent.Class295();
			this.class565_0 = new Class563.Class565();
			this.struct54_0 = default(Class563.Struct54);
			try
			{
				this.DBID = SensorDBID;
				this.float_0 = theMaxRange;
				this.float_1 = theMinRange;
				this.Name = theName;
				this.int_0 = theMaxIntercept;
				this.float_2 = theMaxAltitude;
				this.float_3 = theMinAltitude;
				this.float_4 = theMaxAltitude_ASL;
				this.float_5 = theMinAltitude_ASL;
				this.sensor_Type_0 = theSensorType;
				this.sensor_Role_0 = theSensorRole;
				this.techGenerationClass_0 = theGeneration;
				this.method_48(theScanInterval);
				this.float_7 = theHeightResolution;
				this.short_0 = theMasqueradeAs;
				this.short_1 = theMaxContactsAir;
				this.short_2 = theMaxContactsSurface;
				this.short_3 = theMaxContactsSub;
				this.float_9 = theAvailability;
				this.long_0 = theUpperFreq;
				this.long_1 = theLowerFreq;
				this.long_2 = theUpperFreqIlluminate;
				this.long_3 = theLowerFreqIlluminate;
				this.short_5 = theMineSweepWidth;
				this.short_6 = theMineMaxSpeed;
				this.float_33 = Math.Max(1f, theVisualDetectZoom);
				this.float_34 = Math.Max(1f, theVisualClassZoom);
				this.float_35 = Math.Max(1f, theIRDetectZoom);
				this.float_36 = Math.Max(1f, theIRClassZoom);
				if (this.sensor_Type_0 == Sensor.Sensor_Type.ESM)
				{
					Sensor sensor = this;
					DBFunctions.smethod_90(ref sensor, theConn);
				}
				if (this.sensor_Type_0 == Sensor.Sensor_Type.Radar)
				{
					Sensor sensor = this;
					DBFunctions.smethod_92(ref sensor, theConn);
				}
				this.float_28 = theECMGain;
				this.float_29 = theECMPeakPower;
				this.float_30 = theECMBandwidth;
				this.float_31 = theECMNumberofTargets;
				this.float_32 = theECMPokReduction;
				if (this.method_74() || this.method_75())
				{
					this.float_6 = (float)(0.2 * (double)this.float_0);
					switch (this.techGenerationClass_0)
					{
					case GlobalVariables.TechGenerationClass.Early1950s:
					case GlobalVariables.TechGenerationClass.Late1950s:
						this.float_8 = 30f;
						break;
					case GlobalVariables.TechGenerationClass.Early1960s:
					case GlobalVariables.TechGenerationClass.Late1960s:
						this.float_8 = 25f;
						break;
					case GlobalVariables.TechGenerationClass.Early1970s:
					case GlobalVariables.TechGenerationClass.Late1970s:
						this.float_8 = 20f;
						break;
					case GlobalVariables.TechGenerationClass.Early1980s:
					case GlobalVariables.TechGenerationClass.Late1980s:
						this.float_8 = 15f;
						break;
					case GlobalVariables.TechGenerationClass.Early1990s:
					case GlobalVariables.TechGenerationClass.Late1990s:
						this.float_8 = 10f;
						break;
					case GlobalVariables.TechGenerationClass.Early2000s:
					case GlobalVariables.TechGenerationClass.Late2000s:
						this.float_8 = 5f;
						break;
					default:
						this.float_8 = 2f;
						break;
					}
				}
				this.float_8 = theAngleResolution;
				if (this.float_8 == 0f)
				{
					this.float_8 = DFAccuracy;
				}
				if (this.float_8 == 0f)
				{
					this.float_8 = 5f;
				}
				if (!IsEyeball)
				{
					Sensor sensor = this;
					DBFunctions.smethod_101(ref sensor, SensorDBID, theConn);
					sensor = this;
					DBFunctions.smethod_100(ref sensor, SensorDBID, theConn);
					sensor = this;
					DBFunctions.smethod_103(ref sensor, SensorDBID, theConn);
					sensor = this;
					DBFunctions.smethod_104(ref sensor, SensorDBID, theConn);
				}
				if (this.method_49())
				{
					this.struct33_0.bool_5 = true;
				}
				if ((this.method_74() || this.method_75()) && !this.method_46())
				{
					this.struct33_0.bool_4 = true;
				}
				if (this.sensor_Type_0 == Sensor.Sensor_Type.MAD && this.float_8 == 0f)
				{
					this.float_8 = 2f;
				}
				Random random = GameGeneral.smethod_5();
				if (Information.IsNothing(random))
				{
					random = new Random((int)Math.Round((double)this.float_0));
				}
				this.int_2 = random.Next(0, this.method_47());
				this.int_3 = 0;
				this.bool_12 = IsHypothetical;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100706", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00199990 File Offset: 0x00197B90
		public bool method_76(ref Sensor sensor_0, ref ActiveUnit activeUnit_1, List<string> list_3)
		{
			bool result;
			try
			{
				float num = this.float_32;
				StringBuilder stringBuilder = new StringBuilder();
				float num2;
				if (this.techGenerationClass_0 == GlobalVariables.TechGenerationClass.NotApplicable)
				{
					num2 = num;
				}
				else if (this.sensor_Role_0 == Sensor.Sensor_Role.IRCM)
				{
					num2 = num;
				}
				else
				{
					int num3 = this.techGenerationClass_0 - sensor_0.techGenerationClass_0;
					if (num3 < -3)
					{
						num2 = num - 15f;
					}
					else if (num3 == -3)
					{
						num2 = num - 10f;
					}
					else if (num3 == -2)
					{
						num2 = num - 5f;
					}
					else if (num3 == -1)
					{
						num2 = num;
					}
					else if (num3 == 0)
					{
						num2 = num;
					}
					else if (num3 == 1)
					{
						num2 = num;
					}
					else if (num3 == 2)
					{
						num2 = num + 5f;
					}
					else if (num3 == 3)
					{
						num2 = num + 10f;
					}
					else if (num3 > 3)
					{
						num2 = num + 15f;
					}
				}
				if (sensor_0.sensor_Type_0 == Sensor.Sensor_Type.Radar && sensor_0.struct33_0.bool_20)
				{
					num2 -= 30f;
				}
				num2 = Math.Max(num2, 5f);
				stringBuilder.Append(string.Concat(new string[]
				{
					"Defensive jammer (",
					Misc.smethod_9(this.Name),
					"; Tech: ",
					Misc.smethod_50(this.techGenerationClass_0),
					") on ",
					activeUnit_1.Name,
					" is attempting to spoof sensor: ",
					Misc.smethod_9(sensor_0.Name),
					" (Tech: ",
					Misc.smethod_50(sensor_0.techGenerationClass_0),
					")(Of: ",
					sensor_0.method_18().Name,
					"). Final probability: ",
					Conversions.ToString(Math.Round((double)num2, 2)),
					"%. "
				}));
				int num4 = GameGeneral.smethod_5().Next(1, 101);
				bool flag = false;
				string messageSummary;
				if ((float)num4 <= num2)
				{
					stringBuilder.Append("Result: " + Conversions.ToString(num4) + " - SUCCESS");
					messageSummary = Misc.smethod_9(this.Name) + " jammed " + Misc.smethod_9(sensor_0.Name) + " successfully";
					flag = true;
				}
				else
				{
					stringBuilder.Append("Result: " + Conversions.ToString(num4) + " - FAILURE");
					messageSummary = Misc.smethod_9(this.Name) + " tried to jam " + Misc.smethod_9(sensor_0.Name) + " but failed";
				}
				base.method_18().scenario_0.method_59(stringBuilder.ToString(), messageSummary, LoggedMessage.MessageType.WeaponEndgame, 10, this.string_0, null, new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
				if (list_3 != null)
				{
					list_3.Add(stringBuilder.ToString());
				}
				result = flag;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100707", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x0000BE01 File Offset: 0x0000A001
		public void method_77()
		{
			if (!this.bool_11 && this.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
			{
				this.bool_11 = true;
				base.method_21();
				this.int_2 = GameGeneral.smethod_5().Next(0, this.method_47());
				this.int_3 = 0;
			}
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x0000BE3E File Offset: 0x0000A03E
		public void method_78()
		{
			if (this.bool_11)
			{
				this.bool_11 = false;
				if (this.list_0.Count > 0)
				{
					this.list_0.Clear();
				}
				base.method_21();
			}
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00199CAC File Offset: 0x00197EAC
		public override void vmethod_8(PlatformComponent._DamageSeverityFactor _DamageSeverityFactor_1)
		{
			try
			{
				List<Contact> list = new List<Contact>();
				try
				{
					foreach (Contact item in this.list_0)
					{
						list.Add(item);
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (Contact theTarget in list)
					{
						this.method_84(theTarget, false);
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				if (this.method_58() && this.method_43())
				{
					this.method_78();
				}
				base.vmethod_8(_DamageSeverityFactor_1);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100708", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00199DAC File Offset: 0x00197FAC
		public override void vmethod_6(Side side_0, bool bool_15, bool bool_16)
		{
			try
			{
				if (!bool_16)
				{
					base.vmethod_6(side_0, bool_15, bool_16);
				}
				List<Contact> list = new List<Contact>();
				try
				{
					foreach (Contact item in this.list_0)
					{
						list.Add(item);
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (Contact theTarget in list)
					{
						this.method_84(theTarget, false);
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				this.method_78();
				this._ComponentStatus_0 = PlatformComponent._ComponentStatus.Destroyed;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100709", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x0000BE6E File Offset: 0x0000A06E
		public bool method_79(ref Weapon weapon_0)
		{
			return weapon_0.hashSet_0.Contains(this.DBID);
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00199EA8 File Offset: 0x001980A8
		public void method_80(ref Contact contact_0)
		{
			try
			{
				if (!this.list_0.Contains(contact_0))
				{
					this.list_0.Add(contact_0);
				}
				if (this.method_58())
				{
					if (!this.method_43())
					{
						this.method_77();
					}
					this.method_81(contact_0);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100711", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00199F38 File Offset: 0x00198138
		private void method_81(Contact contact_0)
		{
			try
			{
				List<ActiveUnit> list = base.method_18().scenario_0.method_42();
				try
				{
					foreach (ActiveUnit activeUnit in list)
					{
						if (!Information.IsNothing(activeUnit) && activeUnit.bool_2 && !Information.IsNothing(activeUnit.vmethod_86().vmethod_3()) && activeUnit.vmethod_86().vmethod_3() == contact_0)
						{
							((Weapon)activeUnit).method_184(0f);
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
				ex.Data.Add("Error at 100712", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x0000BE82 File Offset: 0x0000A082
		public bool method_82(ref Contact contact_0)
		{
			return this.method_43() && this.list_0.Contains(contact_0);
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x0019A014 File Offset: 0x00198214
		public bool method_83(ref ActiveUnit activeUnit_1)
		{
			bool result;
			try
			{
				if (!this.method_43())
				{
					result = false;
				}
				else if (this.list_0.Count < 1)
				{
					result = false;
				}
				else
				{
					List<Contact> list = new List<Contact>();
					list.AddRange(Enumerable.ToList<Contact>(this.list_0));
					int num = list.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						Contact contact = list[i];
						if (!Information.IsNothing(contact) && contact.activeUnit_0 == activeUnit_1)
						{
							return true;
						}
					}
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200034", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x0019A0E8 File Offset: 0x001982E8
		public void method_84(Contact theTarget, bool WillRetryToPaint = false)
		{
			try
			{
				if (this.list_0.Contains(theTarget))
				{
					try
					{
						this.list_0.Remove(theTarget);
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 200035", ex.Message);
						GameGeneral.smethod_25(ref ex);
					}
					if (!WillRetryToPaint)
					{
						try
						{
							foreach (ActiveUnit activeUnit in base.method_18().scenario_0.vmethod_0().Values)
							{
								if (!Information.IsNothing(activeUnit) && activeUnit.bool_2 && activeUnit.vmethod_7(false) == base.method_18().vmethod_7(false) && this.list_1.Contains((Weapon)activeUnit) && activeUnit.vmethod_86().vmethod_3() == theTarget)
								{
									try
									{
										this.list_1.Remove((Weapon)activeUnit);
									}
									catch (Exception ex2)
									{
										ex2.Data.Add("Error at 200036", ex2.Message);
										GameGeneral.smethod_25(ref ex2);
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
					if (this.list_0.Count == 0 && this.method_49())
					{
						this.method_78();
					}
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 100713", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0000BE9B File Offset: 0x0000A09B
		public bool method_85()
		{
			return this.list_0.Count < this.int_0;
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x0019A2C8 File Offset: 0x001984C8
		public bool method_86(ActiveUnit activeUnit_1, Unit unit_0, float float_37)
		{
			bool result;
			try
			{
				if (this.float_0 < float_37)
				{
					result = false;
				}
				else if (!base.method_20(unit_0, null))
				{
					result = false;
				}
				else if (unit_0.GetType() == typeof(UnguidedWeapon) && ((UnguidedWeapon)unit_0).method_65())
				{
					if (this.sensor_Type_0 == Sensor.Sensor_Type.Visual)
					{
						if (((UnguidedWeapon)unit_0).method_63() != Weapon._WeaponType.FloatingMine)
						{
							result = false;
						}
						else
						{
							float num = 0.16198704f;
							this.method_97(activeUnit_1, unit_0, ref num);
							if (num > float_37)
							{
								result = true;
							}
							else
							{
								result = false;
							}
						}
					}
					else if ((this.method_74() || this.method_75()) && this.method_43() && (this.method_28(Sensor.FrequencyBand.const_30) || this.struct32_0.bool_7))
					{
						float num2;
						switch (((UnguidedWeapon)unit_0).method_63())
						{
						case Weapon._WeaponType.BottomMine:
						case Weapon._WeaponType.MovingMine:
							num2 = 0.5f;
							break;
						case Weapon._WeaponType.MooredMine:
						case Weapon._WeaponType.RisingMine:
							num2 = 1f;
							break;
						case Weapon._WeaponType.FloatingMine:
							num2 = 0.7f;
							break;
						default:
							throw new NotImplementedException();
						}
						if (this.float_0 * num2 < float_37)
						{
							result = false;
						}
						else
						{
							result = true;
						}
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
				ex.Data.Add("Error at 100714", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0019A468 File Offset: 0x00198668
		public bool method_87(Sensor.Enum114 enum114_0, ActiveUnit activeUnit_1, ActiveUnit activeUnit_2, ref List<GeoPoint> list_3, float float_37, ref Lazy<ObservableDictionary<int, EmissionContainer>> lazy_0, List<ActiveUnit> list_4, ref bool? nullable_1, ref bool? nullable_2, ref Unit.Enum123? nullable_3, ref bool? nullable_4)
		{
			bool result;
			if (activeUnit_1.bool_2 && ((Weapon)activeUnit_1).bool_31)
			{
				result = true;
			}
			else if (this.float_0 < float_37)
			{
				result = false;
			}
			else if (!this.method_63(activeUnit_2))
			{
				result = false;
			}
			else if (!base.method_20(activeUnit_2, null))
			{
				result = false;
			}
			else if (Information.IsNothing(activeUnit_2))
			{
				result = false;
			}
			else
			{
				if (activeUnit_2.method_65())
				{
					if (this.float_2 > 0f && activeUnit_2.vmethod_14(false) > this.float_2 + activeUnit_1.vmethod_14(false))
					{
						return false;
					}
					if (this.float_3 > 0f && activeUnit_2.vmethod_14(false) < this.float_3 + activeUnit_1.vmethod_14(false))
					{
						return false;
					}
					if (this.float_4 > 0f && activeUnit_2.vmethod_14(false) > this.float_4)
					{
						return false;
					}
					if (this.float_5 > 0f && activeUnit_2.vmethod_14(false) < this.float_5)
					{
						return false;
					}
				}
				try
				{
					Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
					bool? flag;
					if (sensor_Type <= Sensor.Sensor_Type.TowedArray_ActiveOnly)
					{
						if (sensor_Type <= Sensor.Sensor_Type.ESM)
						{
							switch (sensor_Type)
							{
							case Sensor.Sensor_Type.Radar:
								flag = new bool?(this.method_88(activeUnit_1, activeUnit_2, float_37, list_4, ref nullable_1, ref nullable_2));
								goto IL_52D;
							case Sensor.Sensor_Type.SemiActive:
								break;
							case Sensor.Sensor_Type.Visual:
								flag = new bool?(this.method_99(activeUnit_1, activeUnit_2, float_37, ref nullable_3));
								goto IL_52D;
							case Sensor.Sensor_Type.Infrared:
								flag = new bool?(this.method_117(activeUnit_1, activeUnit_2, float_37, ref nullable_3));
								goto IL_52D;
							default:
								if (sensor_Type == Sensor.Sensor_Type.ESM)
								{
									if (activeUnit_1.bool_2 && !((Weapon)activeUnit_1).method_208())
									{
										if (activeUnit_2.method_1())
										{
											return false;
										}
										if (((Weapon)activeUnit_1).float_29 == 0f)
										{
											if (activeUnit_2.bool_3 | activeUnit_2.bool_2)
											{
												return false;
											}
										}
										else if (((Weapon)activeUnit_1).float_31 == 0f && (activeUnit_2.bool_6 || activeUnit_2.bool_8))
										{
											return false;
										}
									}
									flag = new bool?(this.method_100(activeUnit_1, activeUnit_2, float_37, ref lazy_0, ref nullable_1, ref nullable_2));
									goto IL_52D;
								}
								break;
							}
						}
						else
						{
							if (sensor_Type - Sensor.Sensor_Type.HullSonar_PassiveOnly <= 2)
							{
								goto IL_4B5;
							}
							if (sensor_Type - Sensor.Sensor_Type.TowedArray_PassiveOnly <= 2)
							{
								int num = activeUnit_1.method_9(false, false, false);
								Class568.Class569 @class = Class568.smethod_2(activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), num);
								float value;
								if (activeUnit_1.bool_6)
								{
									value = (float)(@class.int_1 - 20);
								}
								else if (activeUnit_1.bool_5)
								{
									if (activeUnit_1.vmethod_14(false) > (float)@class.int_1 && (float)(@class.int_0 + 30) > activeUnit_1.vmethod_14(false))
									{
										value = (float)(@class.int_1 - 20);
									}
									else
									{
										value = (float)((int)Math.Round((double)activeUnit_1.vmethod_14(false)));
									}
								}
								if (this.method_46())
								{
									flag = new bool?(this.method_105(activeUnit_1, activeUnit_2, float_37, nullable_4, new float?(value)));
									goto IL_52D;
								}
								if (this.method_43())
								{
									flag = new bool?(this.method_105(activeUnit_1, activeUnit_2, float_37, nullable_4, new float?(value)));
									goto IL_52D;
								}
								flag = new bool?(this.method_110(activeUnit_1, activeUnit_2, float_37, lazy_0, false, nullable_4, new float?(value)));
								goto IL_52D;
							}
						}
					}
					else if (sensor_Type <= Sensor.Sensor_Type.DippingSonar_ActiveOnly)
					{
						if (sensor_Type - Sensor.Sensor_Type.VDS_PassiveOnly <= 2 || sensor_Type - Sensor.Sensor_Type.DippingSonar_PassiveOnly <= 2)
						{
							Class568.Class569 class2 = Class568.smethod_2(activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), activeUnit_1.method_9(false, false, false));
							float value2;
							if (GameGeneral.smethod_5().Next(0, 101) > 50)
							{
								value2 = (float)((int)Math.Round((double)class2.int_0 / 2.0));
							}
							else
							{
								value2 = (float)(class2.int_1 - 30);
							}
							if (this.method_46())
							{
								flag = new bool?(this.method_105(activeUnit_1, activeUnit_2, float_37, nullable_4, new float?(value2)));
								goto IL_52D;
							}
							if (this.method_43())
							{
								flag = new bool?(this.method_105(activeUnit_1, activeUnit_2, float_37, nullable_4, new float?(value2)));
								goto IL_52D;
							}
							flag = new bool?(this.method_110(activeUnit_1, activeUnit_2, float_37, lazy_0, false, nullable_4, new float?(value2)));
							goto IL_52D;
						}
					}
					else
					{
						if (sensor_Type == Sensor.Sensor_Type.BottomFixedSonar_PassiveOnly)
						{
							goto IL_4B5;
						}
						if (sensor_Type == Sensor.Sensor_Type.MAD)
						{
							flag = new bool?(this.method_101(activeUnit_1, activeUnit_2, float_37));
							goto IL_52D;
						}
						if (sensor_Type == Sensor.Sensor_Type.PingIntercept)
						{
							flag = new bool?(this.method_106(activeUnit_1, activeUnit_2, float_37, lazy_0, nullable_4));
							goto IL_52D;
						}
					}
					return false;
					IL_4B5:
					if (this.method_46())
					{
						flag = new bool?(this.method_105(activeUnit_1, activeUnit_2, float_37, nullable_4, null));
					}
					else if (this.method_43())
					{
						flag = new bool?(this.method_105(activeUnit_1, activeUnit_2, float_37, nullable_4, null));
					}
					else
					{
						flag = new bool?(this.method_110(activeUnit_1, activeUnit_2, float_37, lazy_0, false, nullable_4, null));
					}
					IL_52D:
					bool? flag2 = flag;
					if (((flag2 != null) ? new bool?(flag2.GetValueOrDefault()) : null).GetValueOrDefault() && !ActiveUnit_Sensory.smethod_8(this, activeUnit_1.method_36(activeUnit_2)) && !activeUnit_2.method_5())
					{
						List<GeoPoint> list;
						if (lazy_0 != null && lazy_0.IsValueCreated)
						{
							list = activeUnit_1.vmethod_88().method_49(this, activeUnit_2, activeUnit_1.method_36(activeUnit_2), lazy_0.Value);
						}
						else
						{
							list = activeUnit_1.vmethod_88().method_49(this, activeUnit_2, activeUnit_1.method_36(activeUnit_2), null);
						}
						list_3 = list;
					}
					flag2 = flag;
					((flag2 != null) ? new bool?(flag2.GetValueOrDefault()) : null).GetValueOrDefault();
					result = flag.Value;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100715", "");
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

		// Token: 0x0600163A RID: 5690 RVA: 0x0019AAC4 File Offset: 0x00198CC4
		private bool method_88(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2, float float_37, List<ActiveUnit> list_3, ref bool? nullable_1, ref bool? nullable_2)
		{
			bool result;
			try
			{
				if (this.struct32_0.bool_18)
				{
					bool? flag;
					bool? flag2;
					if (nullable_2 == null)
					{
						flag = new bool?(false);
					}
					else
					{
						flag2 = nullable_2;
						flag = ((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2);
					}
					flag2 = flag;
					if (flag2.GetValueOrDefault())
					{
						return false;
					}
				}
				else
				{
					bool? flag2;
					bool? flag3;
					if (nullable_1 == null)
					{
						flag3 = new bool?(false);
					}
					else
					{
						flag2 = nullable_1;
						flag3 = ((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2);
					}
					flag2 = flag3;
					if (flag2.GetValueOrDefault())
					{
						return false;
					}
				}
				if (this.method_49())
				{
					result = (this.method_119(activeUnit_1, activeUnit_2, float_37, list_3, true, false, ref nullable_1, ref nullable_2) == Sensor.Enum115.const_1);
				}
				else
				{
					if (activeUnit_2.bool_5 && Math.Round((double)activeUnit_2.vmethod_14(false)) >= -20.0)
					{
						Submarine._SubmarineType submarineType_ = ((Submarine)activeUnit_2)._SubmarineType_0;
						if (submarineType_ <= Submarine._SubmarineType.SDV)
						{
							if (submarineType_ != Submarine._SubmarineType.None)
							{
								if (submarineType_ != Submarine._SubmarineType.SDV)
								{
									goto IL_13B;
								}
								goto IL_126;
							}
						}
						else
						{
							if (submarineType_ - Submarine._SubmarineType.ROV <= 1)
							{
								goto IL_126;
							}
							if (submarineType_ - Submarine._SubmarineType.Biologics > 1)
							{
								goto IL_13B;
							}
						}
						return false;
						IL_126:
						if (activeUnit_2.vmethod_14(false) < 0f)
						{
							return false;
						}
					}
					IL_13B:
					if (activeUnit_2.bool_5 && Math.Round((double)activeUnit_2.vmethod_14(false)) >= -20.0 && activeUnit_2.vmethod_14(false) < -5f && !this.struct32_0.bool_5)
					{
						result = false;
					}
					else
					{
						if ((activeUnit_2.bool_3 || activeUnit_2.method_2()) && activeUnit_1.vmethod_14(false) > activeUnit_2.vmethod_14(false) && !this.struct33_0.bool_13)
						{
							float value = (float)Class432.smethod_10((double)activeUnit_1.method_36(activeUnit_2), (double)activeUnit_1.vmethod_14(false), (double)activeUnit_2.vmethod_14(false));
							if (this.struct33_0.bool_12 && Math.Abs(value) > 15f)
							{
								return false;
							}
							if (!this.struct33_0.bool_12 && Math.Abs(value) > 5f)
							{
								return false;
							}
						}
						float num = Math2.smethod_7(base.method_18().method_46(activeUnit_2, false));
						XSection.Enum132 enum132_;
						if (!this.method_28(Sensor.FrequencyBand.const_0) && !this.method_28(Sensor.FrequencyBand.const_1) && !this.method_28(Sensor.FrequencyBand.const_2) && !this.method_28(Sensor.FrequencyBand.const_3))
						{
							enum132_ = XSection.Enum132.const_10;
						}
						else
						{
							enum132_ = XSection.Enum132.const_9;
						}
						XSection xsection = Sensor.smethod_3(activeUnit_2, enum132_);
						if (xsection == null)
						{
							xsection = Sensor.smethod_3(activeUnit_2, enum132_);
						}
						if (xsection == null)
						{
							result = false;
						}
						else
						{
							float num2;
							if (num < 315f && num > 45f)
							{
								if ((num >= 45f && num <= 135f) || (num >= 225f && num <= 315f))
								{
									num2 = xsection.method_10(activeUnit_2);
								}
								else if (num >= 135f && num <= 225f)
								{
									num2 = xsection.method_11(activeUnit_2);
								}
							}
							else
							{
								num2 = xsection.method_9(activeUnit_2);
							}
							if (activeUnit_2.bool_8 && ((Facility)activeUnit_2).method_154())
							{
								Class563.Class567 @class = new Class563.Class567();
								@class.double_0 = (double)num2;
								double num3 = @class.method_0();
								if (activeUnit_2.method_6())
								{
									int num4;
									try
									{
										List<Mount>.Enumerator enumerator = activeUnit_2.vmethod_51().GetEnumerator();
										while (enumerator.MoveNext())
										{
											if (enumerator.Current.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed)
											{
												num4++;
											}
										}
									}
									finally
									{
										List<Mount>.Enumerator enumerator;
										((IDisposable)enumerator).Dispose();
									}
									if (num4 == 0)
									{
										return false;
									}
									num3 *= Math.Sqrt((double)num4);
								}
								float num5 = activeUnit_2.vmethod_40() / (float)activeUnit_2.vmethod_87().vmethod_40(activeUnit_2.vmethod_14(false), ActiveUnit.Throttle.Flank, false);
								float num6;
								if (num5 == 0f)
								{
									num6 = 1f;
								}
								else if (num5 < 0.2f)
								{
									num6 = 30f;
								}
								else if (num5 < 0.4f)
								{
									num6 = 60f;
								}
								else if (num5 < 0.6f)
								{
									num6 = 120f;
								}
								else if (num5 < 0.8f)
								{
									num6 = 250f;
								}
								else
								{
									num6 = 500f;
								}
								float num7;
								foreach (Sensor.RadioElectronicFrequency radioElectronicFrequency in this.radioElectronicFrequency_0)
								{
									if (radioElectronicFrequency.frequencyBand_0 == Sensor.FrequencyBand.const_9)
									{
										num7 = 0.1f;
									}
									if (radioElectronicFrequency.frequencyBand_0 == Sensor.FrequencyBand.const_10)
									{
										num7 = 0.2f;
									}
									if (radioElectronicFrequency.frequencyBand_0 == Sensor.FrequencyBand.const_11)
									{
										num7 = 0.3f;
									}
									if (radioElectronicFrequency.frequencyBand_0 == Sensor.FrequencyBand.const_12)
									{
										num7 = 0.4f;
									}
								}
								num6 = Math.Max(1f, num6 * (1f + num7));
								if (this.struct33_0.bool_21 && activeUnit_2.vmethod_40() == 0f)
								{
									num6 = Math.Max(num6, 500f);
								}
								num3 *= (double)num6;
								@class.method_1(num3);
								num2 = (float)@class.double_0;
							}
							if (!this.method_129(activeUnit_1, activeUnit_2, num2, float_37, Sensor.Enum116.const_0, list_3, activeUnit_1.method_74()))
							{
								result = false;
							}
							else if (this.struct32_0.bool_17)
							{
								result = true;
							}
							else
							{
								if (this.struct32_0.bool_6 && activeUnit_2.bool_2)
								{
									Weapon._WeaponType weaponType = ((Weapon)activeUnit_2).method_167();
									if (weaponType - Weapon._WeaponType.BallisticMissile <= 1 || weaponType == Weapon._WeaponType.HGV)
									{
										return Class562.smethod_1(activeUnit_1, activeUnit_2) > Math2.smethod_15(activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), activeUnit_2.vmethod_30(null), activeUnit_2.vmethod_28(null));
									}
								}
								if (this.struct32_0.bool_18)
								{
									if (nullable_2 == null)
									{
										nullable_2 = new bool?(activeUnit_1.method_42(activeUnit_2, ref activeUnit_1.scenario_0, true));
									}
									result = nullable_2.Value;
								}
								else
								{
									if (nullable_1 == null)
									{
										nullable_1 = new bool?(activeUnit_1.method_42(activeUnit_2, ref activeUnit_1.scenario_0, false));
									}
									result = nullable_1.Value;
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100716", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x0019B140 File Offset: 0x00199340
		public static XSection smethod_3(ActiveUnit activeUnit_1, XSection.Enum132 enum132_0)
		{
			XSection result;
			try
			{
				int num = activeUnit_1.method_64().Length - 1;
				for (int i = 0; i <= num; i++)
				{
					XSection xsection = activeUnit_1.method_64()[i];
					if (!Information.IsNothing(xsection) && xsection.enum132_0 == enum132_0)
					{
						return xsection;
					}
				}
				result = null;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200034", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x0019B1D8 File Offset: 0x001993D8
		internal float method_89(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2)
		{
			float result;
			try
			{
				float num = Math2.smethod_7(base.method_18().method_46(activeUnit_2, false));
				XSection.Enum132 enum132_ = XSection.Enum132.const_5;
				XSection xsection = Sensor.smethod_3(activeUnit_2, XSection.Enum132.const_5);
				if (xsection == null)
				{
					xsection = Sensor.smethod_3(activeUnit_2, enum132_);
				}
				if (xsection == null)
				{
					result = 0f;
				}
				else
				{
					float num2;
					if (num < 315f && num > 45f)
					{
						if ((num >= 45f && num <= 135f) || (num >= 225f && num <= 315f))
						{
							num2 = xsection.method_10(activeUnit_2);
						}
						else if (num >= 135f && num <= 225f)
						{
							num2 = xsection.method_11(activeUnit_2);
						}
					}
					else
					{
						num2 = xsection.method_9(activeUnit_2);
					}
					bool flag;
					if (activeUnit_1 != null && activeUnit_1.vmethod_7(false) != null && activeUnit_1.vmethod_7(false).method_11() != null && activeUnit_2 != null)
					{
						flag = activeUnit_1.vmethod_7(false).method_11().ContainsKey(activeUnit_2.string_0);
					}
					float num3;
					if (flag && this.float_34 > this.float_33)
					{
						num3 = num2 * this.float_34;
					}
					else
					{
						num3 = num2 * this.float_33;
					}
					if (activeUnit_2.bool_8 && activeUnit_1.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_10) && Terrain.smethod_7(activeUnit_2.vmethod_30(null), activeUnit_2.vmethod_28(null), false) > 0)
					{
						switch (LandCover.smethod_1(activeUnit_2.vmethod_30(null), activeUnit_2.vmethod_28(null)))
						{
						case LandCover.LandCoverType.Water:
						case LandCover.LandCoverType.Grasslands:
						case LandCover.LandCoverType.Permanent_wetlands:
						case LandCover.LandCoverType.SnowAndIce:
						case LandCover.LandCoverType.BarrenOrSparselyVegetated:
							break;
						case LandCover.LandCoverType.Evergreen_Needleleaf_forest:
						case LandCover.LandCoverType.Evergreen_Broadleaf_forest:
						case LandCover.LandCoverType.Deciduous_Needleleaf_forest:
						case LandCover.LandCoverType.Deciduous_Broadleaf_forest:
						case LandCover.LandCoverType.Mixed_forest:
							num3 = (float)((double)num3 * 0.5);
							break;
						case LandCover.LandCoverType.Closed_shrublands:
						case LandCover.LandCoverType.Open_shrublands:
							num3 = (float)((double)num3 * 0.75);
							break;
						case LandCover.LandCoverType.Woody_savannas:
						case LandCover.LandCoverType.Savannas:
							num3 = (float)((double)num3 * 0.9);
							break;
						case LandCover.LandCoverType.Croplands:
						case LandCover.LandCoverType.CroplandNaturalVegetationMosaic:
							num3 = (float)((double)num3 * 0.85);
							break;
						case LandCover.LandCoverType.UrbanAndBuiltUp:
							num3 = (float)((double)num3 * 0.25);
							break;
						default:
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							break;
						}
					}
					this.method_97(activeUnit_1, activeUnit_2, ref num3);
					result = Math.Min(this.float_0, num3);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100719", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0019B474 File Offset: 0x00199674
		internal float method_90(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2)
		{
			float result;
			try
			{
				float num = Math2.smethod_7(base.method_18().method_46(activeUnit_2, false));
				XSection xsection = Sensor.smethod_3(activeUnit_2, XSection.Enum132.const_7);
				if (xsection == null)
				{
					result = 0f;
				}
				else
				{
					float num2;
					if (num < 315f && num > 45f)
					{
						if ((num >= 45f && num <= 135f) || (num >= 225f && num <= 315f))
						{
							num2 = xsection.method_10(activeUnit_2);
						}
						else if (num >= 135f && num <= 225f)
						{
							num2 = xsection.method_11(activeUnit_2);
						}
					}
					else
					{
						num2 = xsection.method_9(activeUnit_2);
					}
					float num3;
					if (activeUnit_1.vmethod_7(false) != null)
					{
						if (activeUnit_1.vmethod_7(false).method_11().ContainsKey(activeUnit_2.string_0) && this.float_36 > this.float_35)
						{
							num3 = num2 * this.float_36;
						}
						else
						{
							num3 = num2 * this.float_35;
						}
					}
					else
					{
						num3 = num2 * this.float_35;
					}
					switch (this.techGenerationClass_0)
					{
					case GlobalVariables.TechGenerationClass.IR_DualSpectral:
						num3 = (float)((double)num3 * 1.8);
						break;
					case GlobalVariables.TechGenerationClass.IR_Imaging_FPA:
						num3 = (float)((double)num3 * 2.5);
						break;
					}
					if (activeUnit_2.bool_8 && activeUnit_1.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_10) && Terrain.smethod_7(activeUnit_2.vmethod_30(null), activeUnit_2.vmethod_28(null), false) > 0)
					{
						switch (LandCover.smethod_1(activeUnit_2.vmethod_30(null), activeUnit_2.vmethod_28(null)))
						{
						case LandCover.LandCoverType.Water:
						case LandCover.LandCoverType.Grasslands:
						case LandCover.LandCoverType.Permanent_wetlands:
						case LandCover.LandCoverType.SnowAndIce:
						case LandCover.LandCoverType.BarrenOrSparselyVegetated:
							break;
						case LandCover.LandCoverType.Evergreen_Needleleaf_forest:
						case LandCover.LandCoverType.Evergreen_Broadleaf_forest:
						case LandCover.LandCoverType.Deciduous_Needleleaf_forest:
						case LandCover.LandCoverType.Deciduous_Broadleaf_forest:
						case LandCover.LandCoverType.Mixed_forest:
							num3 = (float)((double)num3 * 0.5);
							break;
						case LandCover.LandCoverType.Closed_shrublands:
						case LandCover.LandCoverType.Open_shrublands:
							num3 = (float)((double)num3 * 0.75);
							break;
						case LandCover.LandCoverType.Woody_savannas:
						case LandCover.LandCoverType.Savannas:
							num3 = (float)((double)num3 * 0.9);
							break;
						case LandCover.LandCoverType.Croplands:
						case LandCover.LandCoverType.CroplandNaturalVegetationMosaic:
							num3 = (float)((double)num3 * 0.85);
							break;
						case LandCover.LandCoverType.UrbanAndBuiltUp:
							num3 = (float)((double)num3 * 0.25);
							break;
						default:
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							break;
						}
					}
					this.method_96(activeUnit_1, activeUnit_2, ref num3);
					result = Math.Min(this.float_0, num3);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100720", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x0019B73C File Offset: 0x0019993C
		public float method_91(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2)
		{
			switch (this.sensor_Type_0)
			{
			case Sensor.Sensor_Type.Radar:
				return this.method_93(activeUnit_2);
			case Sensor.Sensor_Type.Visual:
				return this.method_92(activeUnit_1, activeUnit_2);
			case Sensor.Sensor_Type.Infrared:
				return this.method_94(activeUnit_1, activeUnit_2);
			}
			return 0f;
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0019B798 File Offset: 0x00199998
		private float method_92(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2)
		{
			float result;
			if (activeUnit_2.bool_5 && Math.Round((double)activeUnit_2.vmethod_14(false)) < -20.0)
			{
				result = 0f;
			}
			else
			{
				try
				{
					float num = Math2.smethod_7(base.method_18().method_46(activeUnit_2, false));
					XSection.Enum132 enum132_ = XSection.Enum132.const_6;
					XSection xsection = Sensor.smethod_3(activeUnit_2, XSection.Enum132.const_6);
					if (Information.IsNothing(xsection))
					{
						xsection = Sensor.smethod_3(activeUnit_2, enum132_);
					}
					if (Information.IsNothing(xsection))
					{
						result = 0f;
					}
					else
					{
						float num2;
						if (num < 315f && num > 45f)
						{
							if ((num >= 45f && num <= 135f) || (num >= 225f && num <= 315f))
							{
								num2 = xsection.method_10(activeUnit_2);
							}
							else if (num >= 135f && num <= 225f)
							{
								num2 = xsection.method_11(activeUnit_2);
							}
						}
						else
						{
							num2 = xsection.method_9(activeUnit_2);
						}
						float num3 = num2 * this.float_34;
						this.method_97(activeUnit_1, activeUnit_2, ref num3);
						result = num3;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100721", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = 0f;
				}
			}
			return result;
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x0019B8E4 File Offset: 0x00199AE4
		private float method_93(ActiveUnit activeUnit_1)
		{
			float result;
			if (!this.struct33_0.bool_1)
			{
				result = 0f;
			}
			else
			{
				result = this.float_0 / 4f;
			}
			return result;
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0019B914 File Offset: 0x00199B14
		private float method_94(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2)
		{
			float result;
			if (activeUnit_2.bool_5 && !((Submarine)activeUnit_2).method_161())
			{
				result = 0f;
			}
			else
			{
				try
				{
					float num = Math2.smethod_7(base.method_18().method_46(activeUnit_2, false));
					XSection xsection = Sensor.smethod_3(activeUnit_2, XSection.Enum132.const_8);
					if (Information.IsNothing(xsection))
					{
						result = 0f;
					}
					else
					{
						float num2;
						if (num < 315f && num > 45f)
						{
							if ((num >= 45f && num <= 135f) || (num >= 225f && num <= 315f))
							{
								num2 = xsection.method_10(activeUnit_2);
							}
							else if (num >= 135f && num <= 225f)
							{
								num2 = xsection.method_11(activeUnit_2);
							}
						}
						else
						{
							num2 = xsection.method_9(activeUnit_2);
						}
						float num3 = num2 * this.float_36;
						this.method_96(activeUnit_1, activeUnit_2, ref num3);
						result = num3;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100722", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = 0f;
				}
			}
			return result;
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0019BA38 File Offset: 0x00199C38
		private void method_95(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2, ref float float_37)
		{
			if (float_37 != 0f)
			{
				Weather.WeatherProfile weatherProfile = Weather.smethod_0(activeUnit_2.scenario_0, activeUnit_2.vmethod_30(null), activeUnit_2.vmethod_28(null), 0);
				float num = weatherProfile.float_0;
				if (num > 40f)
				{
					float_37 = (float)((double)float_37 * 0.05);
				}
				else if (num > 30f)
				{
					float_37 = (float)((double)float_37 * 0.1);
				}
				else if (num > 20f)
				{
					float_37 = (float)((double)float_37 * 0.25);
				}
				else if (num > 10f)
				{
					float_37 = (float)((double)float_37 * 0.5);
				}
				else if (num > 0f)
				{
					float_37 = (float)((double)float_37 * 0.75);
				}
				Sensor.smethod_4(weatherProfile, activeUnit_1, activeUnit_2, ref float_37);
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0019BA38 File Offset: 0x00199C38
		private void method_96(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2, ref float float_37)
		{
			if (float_37 != 0f)
			{
				Weather.WeatherProfile weatherProfile = Weather.smethod_0(activeUnit_2.scenario_0, activeUnit_2.vmethod_30(null), activeUnit_2.vmethod_28(null), 0);
				float num = weatherProfile.float_0;
				if (num > 40f)
				{
					float_37 = (float)((double)float_37 * 0.05);
				}
				else if (num > 30f)
				{
					float_37 = (float)((double)float_37 * 0.1);
				}
				else if (num > 20f)
				{
					float_37 = (float)((double)float_37 * 0.25);
				}
				else if (num > 10f)
				{
					float_37 = (float)((double)float_37 * 0.5);
				}
				else if (num > 0f)
				{
					float_37 = (float)((double)float_37 * 0.75);
				}
				Sensor.smethod_4(weatherProfile, activeUnit_1, activeUnit_2, ref float_37);
			}
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0019BB0C File Offset: 0x00199D0C
		private void method_97(ActiveUnit activeUnit_1, Unit unit_0, ref float float_37)
		{
			if (float_37 != 0f)
			{
				try
				{
					if (!this.struct33_0.bool_10)
					{
						DateTime dateTime = base.method_18().scenario_0.method_31();
						float num;
						float num2;
						switch (Class418.smethod_1(base.method_18().scenario_0, dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, true, unit_0.vmethod_30(null), unit_0.vmethod_28(null), 0.0))
						{
						case Weather.TTimeOfDayType.const_0:
							num = 1f;
							num2 = 1f;
							break;
						case Weather.TTimeOfDayType.const_1:
							num = 0.75f;
							num2 = 0.8f;
							break;
						case Weather.TTimeOfDayType.const_2:
							num = 0.35f;
							num2 = 0.45f;
							break;
						}
						if (!unit_0.bool_3 && !unit_0.method_2())
						{
							float_37 *= num2;
						}
						else
						{
							float_37 *= num;
						}
					}
					Weather.WeatherProfile weatherProfile = Weather.smethod_0(base.method_18().scenario_0, unit_0.vmethod_30(null), unit_0.vmethod_28(null), 0);
					float num3 = weatherProfile.float_0;
					if (num3 > 40f)
					{
						float_37 = (float)((double)float_37 * 0.2);
					}
					else if (num3 > 30f)
					{
						float_37 = (float)((double)float_37 * 0.3);
					}
					else if (num3 > 20f)
					{
						float_37 = (float)((double)float_37 * 0.5);
					}
					else if (num3 > 10f)
					{
						float_37 = (float)((double)float_37 * 0.7);
					}
					else if (num3 > 0f)
					{
						float_37 = (float)((double)float_37 * 0.9);
					}
					Sensor.smethod_4(weatherProfile, activeUnit_1, unit_0, ref float_37);
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100723", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0019BD28 File Offset: 0x00199F28
		private static void smethod_4(Weather.WeatherProfile weatherProfile_0, ActiveUnit activeUnit_1, Unit unit_0, ref float float_37)
		{
			float num = activeUnit_1.vmethod_13();
			float num2 = unit_0.vmethod_13();
			float num3 = weatherProfile_0.method_3();
			if (num3 > 0.9f)
			{
				if ((10972.8f > num && num > 2133.6f) || (10972.8f > num2 && num2 > 2133.6f))
				{
					float_37 = (float)((double)float_37 * 0.1);
					return;
				}
				if (609.60004f > num || 609.60004f > num2)
				{
					float_37 = (float)((double)float_37 * 0.1);
					return;
				}
			}
			else if (num3 > 0.8f)
			{
				if ((10972.8f > num && num > 2133.6f) || (10972.8f > num2 && num2 > 2133.6f))
				{
					float_37 = (float)((double)float_37 * 0.1);
					return;
				}
				if (609.60004f > num || 609.60004f > num2)
				{
					float_37 = (float)((double)float_37 * 0.2);
					return;
				}
			}
			else if (num3 > 0.7f)
			{
				if ((4876.8003f > num && num > 2133.6f) || (4876.8003f > num2 && num2 > 2133.6f))
				{
					float_37 = (float)((double)float_37 * 0.1);
					return;
				}
				if ((10972.8f > num && num > 9144f) || (10972.8f > num2 && num2 > 9144f))
				{
					float_37 = (float)((double)float_37 * 0.3);
					return;
				}
			}
			else if (num3 > 0.6f)
			{
				if ((4876.8003f > num && num > 2133.6f) || (4876.8003f > num2 && num2 > 2133.6f))
				{
					float_37 = (float)((double)float_37 * 0.3);
					return;
				}
				if ((9144f > num && num > 8229.601f) || (9144f > num2 && num2 > 8229.601f))
				{
					float_37 = (float)((double)float_37 * 0.7);
					return;
				}
			}
			else if (num3 > 0.5f)
			{
				if ((8534.4f > num && num > 7620f) || (8534.4f > num2 && num2 > 7620f))
				{
					float_37 = (float)((double)float_37 * 0.3);
					return;
				}
			}
			else if (num3 > 0.4f)
			{
				if ((4876.8003f > num && num > 2133.6f) || (4876.8003f > num2 && num2 > 2133.6f))
				{
					float_37 = (float)((double)float_37 * 0.3);
					return;
				}
			}
			else if (num3 > 0.3f)
			{
				if ((2133.6f > num && num > 609.60004f) || (2133.6f > num2 && num2 > 609.60004f))
				{
					float_37 = (float)((double)float_37 * 0.3);
					return;
				}
			}
			else if (num3 > 0.2f)
			{
				if ((7010.4f > num && num > 6096f) || (7010.4f > num2 && num2 > 6096f))
				{
					float_37 = (float)((double)float_37 * 0.7);
					return;
				}
			}
			else if (num3 > 0.1f)
			{
				if ((4876.8003f > num && num > 3048f) || (4876.8003f > num2 && num2 > 3048f))
				{
					float_37 = (float)((double)float_37 * 0.7);
					return;
				}
			}
			else if (num3 > 0f && ((2133.6f > num && num > 1524f) || (2133.6f > num2 && num2 > 1524f)))
			{
				float_37 = (float)((double)float_37 * 0.7);
			}
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		public bool method_98()
		{
			return this.bool_14;
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x0019C054 File Offset: 0x0019A254
		private bool method_99(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2, float float_37, ref Unit.Enum123? nullable_1)
		{
			bool result;
			try
			{
				if (activeUnit_1.bool_3 && this.method_98())
				{
					double num = (double)(activeUnit_1.method_36(activeUnit_2) * 1852f);
					double num2 = Math.Atan2((double)(activeUnit_2.vmethod_14(false) - activeUnit_1.vmethod_14(false)), num);
					double num3 = (double)activeUnit_1.method_33(activeUnit_2) * 0.0174532925199433;
					Vector3D vector3D_ = new Vector3D(num * Math.Sin(num2) * Math.Cos(num3), num * Math.Sin(num2) * Math.Sin(num3), num * Math.Cos(num2));
					Matrix3D identity = Matrix3D.Identity;
					double num4 = (double)(-(double)activeUnit_1.vmethod_20()) * 0.0174532925199433;
					double num5 = Math.Sin(num4);
					double double_ = Math.Cos(num4);
					identity.method_7(double_);
					identity.method_9(num5);
					identity.method_13(-num5);
					identity.method_15(double_);
					Matrix3D identity2 = Matrix3D.Identity;
					double num6 = (double)(-(double)activeUnit_1.vmethod_18()) * 0.0174532925199433;
					double num7 = Math.Sin(num6);
					double double_2 = Math.Cos(num6);
					identity2.method_1(double_2);
					identity2.method_4(-num7);
					identity2.method_11(num7);
					identity2.method_15(double_2);
					Matrix3D.smethod_3(Matrix3D.smethod_2(identity2, identity), vector3D_);
					double num8 = Math.Atan2(vector3D_.method_1(), vector3D_.method_3()) * 57.2957795130823;
					double num9 = (double)activeUnit_1.method_33(activeUnit_2);
					if (num8 < -45.0)
					{
						return false;
					}
					Aircraft.Enum38 @enum;
					if (num9 < 315.0 && num9 > 45.0)
					{
						if (num9 > 45.0 && num9 < 135.0)
						{
							@enum = ((Aircraft)activeUnit_1).enum38_1;
						}
						else if (num9 >= 135.0 && num9 <= 225.0)
						{
							@enum = ((Aircraft)activeUnit_1).enum38_2;
						}
						else
						{
							@enum = ((Aircraft)activeUnit_1).enum38_1;
						}
					}
					else
					{
						@enum = ((Aircraft)activeUnit_1).enum38_0;
					}
					switch (@enum)
					{
					case Aircraft.Enum38.const_1:
						if (GameGeneral.smethod_5().Next(1, 101) > 95)
						{
							return false;
						}
						break;
					case Aircraft.Enum38.const_2:
						if (num8 < -25.0)
						{
							return false;
						}
						if (GameGeneral.smethod_5().Next(1, 101) > 50)
						{
							return false;
						}
						break;
					case Aircraft.Enum38.const_3:
						if (GameGeneral.smethod_5().Next(1, 101) > 2)
						{
							return false;
						}
						break;
					}
				}
				bool? flag;
				if (nullable_1 == null)
				{
					flag = new bool?(false);
				}
				else
				{
					Unit.Enum123? enum2 = nullable_1;
					int? num10 = (enum2 != null) ? new int?((int)enum2.GetValueOrDefault()) : null;
					flag = ((num10 != null) ? new bool?(num10.GetValueOrDefault() != 1) : null);
				}
				bool? flag2 = flag;
				if (flag2.GetValueOrDefault())
				{
					result = false;
				}
				else
				{
					bool flag3;
					if ((activeUnit_2.bool_6 || activeUnit_2.bool_5) && (activeUnit_1.bool_3 || activeUnit_1.method_2() || activeUnit_1.method_1()))
					{
						float num11 = 0f;
						Ship.Enum119 enum3;
						if (activeUnit_2.bool_6)
						{
							enum3 = ((Ship)activeUnit_2).method_143();
						}
						if (activeUnit_2.bool_5)
						{
							enum3 = ((Submarine)activeUnit_2).method_151();
						}
						switch (enum3)
						{
						case Ship.Enum119.const_0:
							num11 = 0f;
							break;
						case Ship.Enum119.const_1:
							num11 = 3f;
							break;
						case Ship.Enum119.const_2:
							num11 = 10f;
							break;
						case Ship.Enum119.const_3:
							num11 = 19f;
							break;
						case Ship.Enum119.const_4:
							num11 = 25f;
							break;
						case Ship.Enum119.const_5:
							num11 = 32f;
							break;
						}
						this.method_97(activeUnit_1, activeUnit_2, ref num11);
						flag3 = (num11 > float_37);
					}
					bool flag4;
					if (activeUnit_2.bool_3 || activeUnit_2.method_2())
					{
						float num12 = 0f;
						switch (activeUnit_2.method_75())
						{
						case ActiveUnit.Enum29.const_0:
							num12 = 0f;
							break;
						case ActiveUnit.Enum29.const_1:
							num12 = 2f;
							break;
						case ActiveUnit.Enum29.const_2:
							num12 = 10f;
							break;
						case ActiveUnit.Enum29.const_3:
							num12 = 20f;
							break;
						case ActiveUnit.Enum29.const_4:
							num12 = 30f;
							break;
						case ActiveUnit.Enum29.const_5:
							num12 = 50f;
							break;
						}
						this.method_97(activeUnit_1, activeUnit_2, ref num12);
						flag4 = (num12 > float_37);
					}
					if (activeUnit_2.bool_8 && activeUnit_2.vmethod_40() > 0f)
					{
						flag3 = ((float)((int)Math.Round((double)(this.method_89(activeUnit_1, activeUnit_2) * (1f + activeUnit_2.vmethod_40() / 10f)))) > float_37);
					}
					bool flag5;
					if (!(flag5 = (float_37 <= this.float_0)) && !flag3 && !flag4)
					{
						result = false;
					}
					else if (flag5 && !flag3 && !flag4 && this.method_89(activeUnit_1, activeUnit_2) < float_37)
					{
						result = false;
					}
					else
					{
						if (this.struct32_0.bool_6 && activeUnit_2.bool_2)
						{
							Weapon._WeaponType weaponType = ((Weapon)activeUnit_2).method_167();
							if (weaponType - Weapon._WeaponType.BallisticMissile <= 1 || weaponType == Weapon._WeaponType.HGV)
							{
								float num13 = (float)((int)Math.Round((double)activeUnit_2.vmethod_14(false)));
								return Class562.smethod_3(activeUnit_1, ref num13) > Math2.smethod_15(activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), activeUnit_2.vmethod_30(null), activeUnit_2.vmethod_28(null)) && flag5;
							}
						}
						if (nullable_1 == null)
						{
							nullable_1 = new Unit.Enum123?(activeUnit_1.method_43(activeUnit_2, ref activeUnit_1.scenario_0, true));
						}
						result = (nullable_1.Value == Unit.Enum123.const_1);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100724", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0019C630 File Offset: 0x0019A830
		private bool method_100(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2, float float_37, ref Lazy<ObservableDictionary<int, EmissionContainer>> lazy_0, ref bool? nullable_1, ref bool? nullable_2)
		{
			checked
			{
				bool result;
				if (this.float_0 < float_37)
				{
					result = false;
				}
				else
				{
					try
					{
						Sensor[] array = activeUnit_2.method_78();
						int i = 0;
						bool flag5;
						while (i < array.Length)
						{
							Sensor sensor = array[i];
							if (sensor.struct32_0.bool_18)
							{
								bool? flag;
								bool? flag2;
								if (nullable_2 == null)
								{
									flag = new bool?(false);
								}
								else
								{
									flag2 = nullable_2;
									flag = ((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2);
								}
								flag2 = flag;
								if (!flag2.GetValueOrDefault())
								{
									goto IL_BC;
								}
							}
							else
							{
								bool? flag2;
								bool? flag3;
								if (nullable_1 == null)
								{
									flag3 = new bool?(false);
								}
								else
								{
									flag2 = nullable_1;
									flag3 = ((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2);
								}
								flag2 = flag3;
								if (!flag2.GetValueOrDefault())
								{
									goto IL_BC;
								}
							}
							IL_46D:
							i++;
							continue;
							IL_BC:
							if ((sensor.sensor_Type_0 != Sensor.Sensor_Type.Radar && !sensor.method_72()) || !sensor.method_43() || !sensor.method_64() || (sensor.method_72() && this.sensor_Role_0 == Sensor.Sensor_Role.ESM_RWR) || !sensor.method_20(activeUnit_1, null) || !this.method_127(sensor))
							{
								goto IL_46D;
							}
							bool flag4;
							Sensor.Enum116 enum116_;
							if (flag4 = (sensor.list_1.Count > 0 || sensor.method_49()))
							{
								enum116_ = Sensor.Enum116.const_1;
							}
							else
							{
								enum116_ = Sensor.Enum116.const_0;
							}
							if (!this.method_128(sensor, float_37, enum116_, activeUnit_1.method_74()))
							{
								goto IL_46D;
							}
							if (!this.struct32_0.bool_17)
							{
								if (sensor.struct32_0.bool_18)
								{
									if (sensor.float_0 < float_37)
									{
										return false;
									}
									if (nullable_2 == null)
									{
										nullable_2 = new bool?(activeUnit_1.method_42(activeUnit_2, ref activeUnit_1.scenario_0, true));
									}
									if (!nullable_2.Value)
									{
										goto IL_46D;
									}
								}
								else
								{
									if (nullable_1 == null)
									{
										nullable_1 = new bool?(activeUnit_1.method_42(activeUnit_2, ref activeUnit_1.scenario_0, false));
									}
									if (!nullable_1.Value)
									{
										goto IL_46D;
									}
								}
							}
							flag5 = true;
							int dbid;
							if (sensor.short_0 != 1001)
							{
								dbid = (int)sensor.short_0;
							}
							else
							{
								dbid = sensor.DBID;
							}
							if (!lazy_0.Value.ContainsKey(dbid))
							{
								lazy_0.Value.Add(dbid, new EmissionContainer(0.0, flag4, this.bool_13));
							}
							if (!lazy_0.Value[dbid].bool_0 && flag4)
							{
								lazy_0.Value[dbid].bool_0 = true;
							}
							if (!lazy_0.Value[dbid].bool_1 && this.bool_13)
							{
								lazy_0.Value[dbid].bool_1 = true;
							}
							if (activeUnit_1.bool_5)
							{
								if (sensor.struct32_0.bool_5)
								{
									activeUnit_1.float_24 = 0f;
								}
								else if (sensor.struct32_0.bool_1 && activeUnit_1.vmethod_14(false) >= -5f)
								{
									activeUnit_1.float_24 = 0f;
								}
							}
							if ((!activeUnit_1.bool_3 && !activeUnit_1.bool_6 && !activeUnit_1.bool_5 && !activeUnit_1.bool_8) || activeUnit_1.weapon_0.Length <= 0)
							{
								goto IL_46D;
							}
							Contact contact = activeUnit_1.vmethod_7(false).method_11()[activeUnit_2.string_0];
							if (Information.IsNothing(contact) || contact.method_130(activeUnit_1.vmethod_7(false)) == Misc.PostureStance.Hostile)
							{
								goto IL_46D;
							}
							Contact contact2 = activeUnit_2.vmethod_7(false).method_11()[activeUnit_1.string_0];
							if (!Information.IsNothing(contact2) && sensor.method_41().Contains(contact2))
							{
								contact.method_131(activeUnit_1.vmethod_7(false), false, Misc.PostureStance.Hostile);
								string text = "";
								if (activeUnit_1.bool_3 && Operators.CompareString(activeUnit_1.Name, activeUnit_1.string_2, false) != 0)
								{
									text = " (" + activeUnit_1.string_2 + ")";
								}
								activeUnit_1.scenario_0.method_59(string.Concat(new string[]
								{
									"Contact: ",
									contact.Name,
									" is illuminating ",
									activeUnit_1.Name,
									text,
									" and is now considered as hostile!"
								}), contact.Name + " is now HOSTILE!", LoggedMessage.MessageType.ContactChange, 0, null, activeUnit_1.vmethod_7(false), new Geopoint_Struct(contact.vmethod_28(null), contact.vmethod_30(null)));
								goto IL_46D;
							}
							goto IL_46D;
						}
						result = flag5;
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 100725", "");
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
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x0019CB18 File Offset: 0x0019AD18
		private bool method_101(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2, float float_37)
		{
			bool result;
			try
			{
				if (activeUnit_2.bool_5)
				{
					Submarine._SubmarineType submarineType_ = ((Submarine)activeUnit_2)._SubmarineType_0;
					if (submarineType_ == Submarine._SubmarineType.None || submarineType_ == Submarine._SubmarineType.Biologics)
					{
						return false;
					}
				}
				if (activeUnit_2.bool_7)
				{
					result = false;
				}
				else
				{
					double num = (double)((int)Math.Round((double)((Interface5)activeUnit_2).imethod_6())) / (double)24500f;
					double num2 = (double)this.float_0 * num;
					if (activeUnit_2.bool_5 && ((Submarine)activeUnit_2).struct35_0.bool_1)
					{
						num2 /= 2.0;
					}
					int num3 = (int)Math.Round((double)((float)Math.Abs(Terrain.smethod_7(activeUnit_2.vmethod_30(null), activeUnit_2.vmethod_28(null), false)) - Math.Abs(activeUnit_2.vmethod_14(false))));
					if (num3 < 50)
					{
						num2 /= 2.0;
					}
					else if (num3 < 100)
					{
						num2 *= 0.75;
					}
					result = (num2 >= (double)float_37);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100726", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0019CC68 File Offset: 0x0019AE68
		private float method_102(ActiveUnit activeUnit_1)
		{
			float num = 1f;
			float result;
			try
			{
				float num2 = activeUnit_1.vmethod_13();
				if (num2 < 10f)
				{
					num = 0.2f;
				}
				else if (num2 < 20f)
				{
					num = 0.4f;
				}
				else if (num2 < 30f)
				{
					num = 0.7f;
				}
				if (num != 1f)
				{
					switch (this.techGenerationClass_0)
					{
					case GlobalVariables.TechGenerationClass.Early1950s:
					case GlobalVariables.TechGenerationClass.Late1950s:
						num = num;
						break;
					case GlobalVariables.TechGenerationClass.Early1960s:
					case GlobalVariables.TechGenerationClass.Late1960s:
						num = (float)((double)num + 0.1);
						break;
					case GlobalVariables.TechGenerationClass.Early1970s:
					case GlobalVariables.TechGenerationClass.Late1970s:
						num = (float)((double)num + 0.2);
						break;
					case GlobalVariables.TechGenerationClass.Early1980s:
					case GlobalVariables.TechGenerationClass.Late1980s:
						num = (float)((double)num + 0.3);
						break;
					case GlobalVariables.TechGenerationClass.Early1990s:
					case GlobalVariables.TechGenerationClass.Late1990s:
						num = (float)((double)num + 0.4);
						break;
					case GlobalVariables.TechGenerationClass.Early2000s:
					case GlobalVariables.TechGenerationClass.Late2000s:
						num = (float)((double)num + 0.5);
						break;
					case GlobalVariables.TechGenerationClass.Early2010s:
					case GlobalVariables.TechGenerationClass.Late2010s:
						num = (float)((double)num + 0.6);
						break;
					case GlobalVariables.TechGenerationClass.Early2020s:
					case GlobalVariables.TechGenerationClass.Late2020s:
						num = (float)((double)num + 0.7);
						break;
					default:
						throw new NotImplementedException();
					}
					Sensor.FrequencyBand frequencyBand_ = this.radioElectronicFrequency_0[0].frequencyBand_0;
					long num3 = frequencyBand_ - Sensor.FrequencyBand.const_28;
					if (num3 <= 3L)
					{
						switch ((uint)num3)
						{
						case 0U:
							num = (float)((double)num - 0.3);
							goto IL_18D;
						case 1U:
							num = (float)((double)num - 0.1);
							goto IL_18D;
						case 2U:
							num = num;
							goto IL_18D;
						case 3U:
							num = (float)((double)num - 0.5);
							goto IL_18D;
						}
						goto IL_155;
						IL_18D:
						return (float)Math.Min(0.9, (double)num);
					}
					IL_155:
					throw new NotImplementedException();
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101327", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 1f;
			}
			return result;
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0019CE74 File Offset: 0x0019B074
		private float method_103(double double_0, double double_1, int int_4)
		{
			float result;
			try
			{
				float num;
				if (int_4 <= -300)
				{
					num = 1f;
				}
				else if (int_4 >= -50)
				{
					num = 0.5f;
				}
				else
				{
					num = (float)(0.5 + 0.5 * ((double)(Math.Abs(int_4) - 50) / 250.0));
				}
				bool flag = Class442.smethod_1(double_1, double_0);
				if (num < 1f || flag)
				{
					float num2;
					if (flag)
					{
						num2 = 0.5f;
					}
					else
					{
						num2 = num;
					}
					switch (this.techGenerationClass_0)
					{
					case GlobalVariables.TechGenerationClass.Early1950s:
					case GlobalVariables.TechGenerationClass.Late1950s:
						num2 = num2;
						break;
					case GlobalVariables.TechGenerationClass.Early1960s:
					case GlobalVariables.TechGenerationClass.Late1960s:
						num2 = (float)((double)num2 + 0.1);
						break;
					case GlobalVariables.TechGenerationClass.Early1970s:
					case GlobalVariables.TechGenerationClass.Late1970s:
						num2 = (float)((double)num2 + 0.2);
						break;
					case GlobalVariables.TechGenerationClass.Early1980s:
					case GlobalVariables.TechGenerationClass.Late1980s:
						num2 = (float)((double)num2 + 0.3);
						break;
					case GlobalVariables.TechGenerationClass.Early1990s:
					case GlobalVariables.TechGenerationClass.Late1990s:
						num2 = (float)((double)num2 + 0.4);
						break;
					case GlobalVariables.TechGenerationClass.Early2000s:
					case GlobalVariables.TechGenerationClass.Late2000s:
						num2 = (float)((double)num2 + 0.5);
						break;
					case GlobalVariables.TechGenerationClass.Early2010s:
					case GlobalVariables.TechGenerationClass.Late2010s:
						num2 = (float)((double)num2 + 0.6);
						break;
					case GlobalVariables.TechGenerationClass.Early2020s:
					case GlobalVariables.TechGenerationClass.Late2020s:
						num2 = (float)((double)num2 + 0.7);
						break;
					default:
						throw new NotImplementedException();
					}
					Sensor.FrequencyBand frequencyBand_ = this.radioElectronicFrequency_0[0].frequencyBand_0;
					long num3 = frequencyBand_ - Sensor.FrequencyBand.const_28;
					if (num3 <= 3L)
					{
						switch ((uint)num3)
						{
						case 0U:
							num2 = (float)((double)num2 - 0.3);
							goto IL_1B7;
						case 1U:
							num2 = (float)((double)num2 - 0.1);
							goto IL_1B7;
						case 2U:
							num2 = num2;
							goto IL_1B7;
						case 3U:
							num2 = (float)((double)num2 - 0.5);
							goto IL_1B7;
						}
						goto IL_17F;
						IL_1B7:
						return (float)Math.Min(0.9, (double)num2);
					}
					IL_17F:
					throw new NotImplementedException();
				}
				result = 1f;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100727", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 1f;
			}
			return result;
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0019D0AC File Offset: 0x0019B2AC
		private float method_104(ActiveUnit activeUnit_1, float float_37, float? nullable_1)
		{
			float result;
			try
			{
				float_37 /= 2f;
				Class568.Class569 @class = Class568.smethod_2(activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), activeUnit_1.method_9(false, false, false));
				float num;
				if (nullable_1 != null)
				{
					num = nullable_1.Value;
				}
				else
				{
					num = (float)((int)Math.Round((double)activeUnit_1.vmethod_14(false)));
				}
				Class568.Enum154 @enum = Class568.smethod_3(num, @class);
				Class568.Enum154 enum2 = Class568.smethod_3((float)((int)Math.Round((double)activeUnit_1.vmethod_14(false))), @class);
				float num2 = @class.float_0;
				if (@enum != Class568.Enum154.const_0 || enum2 != Class568.Enum154.const_0)
				{
					if (@enum == Class568.Enum154.const_1 && enum2 == Class568.Enum154.const_1)
					{
						float_37 = (float)((double)float_37 * Math.Max(0.1, (double)(1f - num2 * 2f)));
					}
					else
					{
						if (@enum != Class568.Enum154.const_1)
						{
							if (enum2 != Class568.Enum154.const_1)
							{
								if (@enum != enum2)
								{
									float_37 *= 1f - num2;
									goto IL_152;
								}
								if (@enum != Class568.Enum154.const_2 || enum2 != Class568.Enum154.const_2)
								{
									goto IL_152;
								}
								if (@class.method_0(num) && @class.method_0((float)((int)Math.Round((double)activeUnit_1.vmethod_14(false)))))
								{
									float_37 *= 2f;
									goto IL_152;
								}
								if (@class.method_0(num) || @class.method_0((float)((int)Math.Round((double)activeUnit_1.vmethod_14(false)))))
								{
									float_37 = (float)((double)float_37 * 1.5);
									goto IL_152;
								}
								goto IL_152;
							}
						}
						float_37 *= 1f - num2 / 2f;
					}
				}
				IL_152:
				result = float_37;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100728", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = float_37 / 2f;
			}
			return result;
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0019D26C File Offset: 0x0019B46C
		private bool method_105(ActiveUnit myParent, ActiveUnit theUnit, float TargetRange, bool? LOS_Exists_Sonar, float? ExplicitSensorDepth = null)
		{
			bool result;
			try
			{
				if (!theUnit.vmethod_127())
				{
					result = false;
				}
				else if (((LOS_Exists_Sonar != null) ? ((LOS_Exists_Sonar != null) ? new bool?(!LOS_Exists_Sonar.GetValueOrDefault()) : LOS_Exists_Sonar) : new bool?(false)).GetValueOrDefault())
				{
					result = false;
				}
				else
				{
					short num;
					if (this.method_73())
					{
						num = 25;
					}
					else if (myParent.bool_7)
					{
						num = 200;
					}
					else
					{
						num = 30;
					}
					if (myParent.vmethod_40() >= (float)num && !myParent.bool_2)
					{
						result = false;
					}
					else
					{
						if (myParent.bool_7)
						{
							TargetRange = myParent.method_36(theUnit);
						}
						float num2 = this.float_0;
						float num3;
						if (myParent.bool_7)
						{
							num3 = 1f;
						}
						else
						{
							float num4 = (float)myParent.vmethod_87().vmethod_40(myParent.vmethod_87().vmethod_31(), ActiveUnit.Throttle.Flank, false);
							float num5;
							float num6;
							if (myParent.vmethod_40() <= 5f)
							{
								num5 = 0f;
								num6 = 0f;
							}
							else
							{
								num5 = (float)((double)(myParent.vmethod_70() - 5f) / ((double)num4 + 1E-06 - 5.0));
								num6 = (float)((double)(myParent.vmethod_40() - 5f) / ((double)num4 + 1E-06 - 5.0));
							}
							num3 = (float)(1.0 - (0.75 * (double)num5 + 0.25 * (double)num6));
							Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
							if (sensor_Type - Sensor.Sensor_Type.TowedArray_ActivePassive <= 1 || sensor_Type - Sensor.Sensor_Type.VDS_ActivePassive <= 1)
							{
								num3 = this.method_104(myParent, num3, ExplicitSensorDepth);
							}
						}
						float num7 = Math2.smethod_7(base.method_18().method_46(theUnit, false));
						XSection xsection = Sensor.smethod_3(theUnit, XSection.Enum132.const_4);
						if (Information.IsNothing(xsection))
						{
							result = false;
						}
						else
						{
							float num8;
							float num9;
							if (num7 < 315f && num7 > 45f)
							{
								if ((num7 >= 45f && num7 <= 135f) || (num7 >= 225f && num7 <= 315f))
								{
									num8 = xsection.method_10(theUnit);
									if (myParent.bool_7)
									{
										num9 = 100f;
									}
									else
									{
										num9 = 250f;
									}
								}
								else if (num7 >= 135f && num7 <= 225f)
								{
									num8 = xsection.method_11(theUnit);
									if (myParent.bool_7)
									{
										num9 = 15f;
									}
									else
									{
										num9 = 60f;
									}
								}
							}
							else
							{
								num8 = xsection.method_9(theUnit);
								if (myParent.bool_7)
								{
									num9 = 15f;
								}
								else
								{
									num9 = 60f;
								}
							}
							float num10 = num8 / num9;
							float num11 = this.method_111(myParent, theUnit, ExplicitSensorDepth);
							float num12 = this.method_103(theUnit.vmethod_30(null), theUnit.vmethod_28(null), theUnit.method_9(false, false, false));
							float num13 = this.method_102(theUnit);
							float num14 = (float)(9.87473 * (double)num11 * (double)num12 * (double)num13);
							float num15 = num2 * num3 * num11 * num12 * num13 * num10;
							if (LOS_Exists_Sonar == null)
							{
								bool flag = false;
								LOS_Exists_Sonar = new bool?(myParent.method_44(theUnit, ref myParent.scenario_0, ref flag, ExplicitSensorDepth));
							}
							if (!LOS_Exists_Sonar.Value)
							{
								result = false;
							}
							else if (TargetRange > num15)
							{
								result = false;
							}
							else if (TargetRange < num14)
							{
								result = true;
							}
							else if ((double)TargetRange < (double)num14 * 1.2 && this.method_113(myParent, theUnit, num15, TargetRange, num15, ExplicitSensorDepth))
							{
								result = true;
							}
							else if (this.method_114(myParent, theUnit, num15, ref TargetRange, ExplicitSensorDepth))
							{
								result = true;
							}
							else
							{
								result = false;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100729", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0019D640 File Offset: 0x0019B840
		private bool method_106(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2, float float_37, Lazy<ObservableDictionary<int, EmissionContainer>> lazy_0, bool? nullable_1)
		{
			bool result;
			try
			{
				if (((nullable_1 != null) ? ((nullable_1 != null) ? new bool?(!nullable_1.GetValueOrDefault()) : nullable_1) : new bool?(false)).GetValueOrDefault())
				{
					result = false;
				}
				else if (this.float_0 < float_37)
				{
					result = false;
				}
				else
				{
					if (nullable_1 == null)
					{
						bool flag = true;
						if (base.method_18().bool_6 && activeUnit_2.bool_6)
						{
							flag = false;
						}
						if (this.sensor_Type_0 == Sensor.Sensor_Type.PingIntercept && activeUnit_2.bool_3 && ((Aircraft)activeUnit_2).method_164().method_36() == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
						{
							flag = false;
						}
						if (flag)
						{
							bool flag2 = false;
							nullable_1 = new bool?(activeUnit_1.method_44(activeUnit_2, ref activeUnit_1.scenario_0, ref flag2, null));
							if (((nullable_1 != null) ? new bool?(!nullable_1.GetValueOrDefault()) : nullable_1).GetValueOrDefault())
							{
								return nullable_1.Value;
							}
						}
					}
					float num = (float)activeUnit_1.vmethod_87().vmethod_40(activeUnit_1.vmethod_87().vmethod_31(), ActiveUnit.Throttle.Flank, false);
					float num2 = (float)((double)base.method_18().vmethod_70() / ((double)num + 1E-06));
					float num3 = (float)((double)activeUnit_1.vmethod_40() / ((double)num + 1E-06));
					float num4 = (float)(1.0 - (0.75 * (double)num2 + 0.25 * (double)num3));
					float num5 = this.float_0 * num4;
					float num6 = this.method_111(activeUnit_1, activeUnit_2, null);
					float num7 = (float)(9.87473 * (double)num6);
					float num8 = num5 * num6;
					bool flag3 = float_37 < num7;
					bool flag4 = this.method_114(activeUnit_1, activeUnit_2, num8, ref float_37, null);
					bool flag5 = false;
					if ((double)float_37 < (double)num7 * 1.2 && this.method_113(activeUnit_1, activeUnit_2, num8, float_37, num8, null))
					{
						flag5 = true;
					}
					bool flag6;
					foreach (Sensor sensor in activeUnit_2.method_78())
					{
						if ((sensor.method_74() || sensor.method_75()) && sensor.method_43() && sensor.method_64() && sensor.method_20(activeUnit_1, null) && this.method_127(sensor))
						{
							flag6 = (flag3 || flag5 || flag4);
							if (flag6)
							{
								int dbid;
								if (sensor.short_0 != 1001)
								{
									dbid = (int)sensor.short_0;
								}
								else
								{
									dbid = sensor.DBID;
								}
								if (!lazy_0.Value.ContainsKey(dbid))
								{
									lazy_0.Value.Add(dbid, new EmissionContainer(0.0, false, this.bool_13));
								}
								if (!lazy_0.Value[dbid].bool_1 && this.bool_13)
								{
									lazy_0.Value[dbid].bool_1 = true;
								}
							}
						}
					}
					result = flag6;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100730", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0019D9B4 File Offset: 0x0019BBB4
		private float method_107(ActiveUnit activeUnit_1)
		{
			float num = (float)activeUnit_1.vmethod_87().vmethod_40(activeUnit_1.vmethod_87().vmethod_31(), ActiveUnit.Throttle.Flank, false);
			return (float)((double)activeUnit_1.vmethod_40() / ((double)num + 1E-06));
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x0019D9F0 File Offset: 0x0019BBF0
		private float method_108(ActiveUnit activeUnit_1)
		{
			float num = (float)activeUnit_1.vmethod_87().vmethod_40(activeUnit_1.vmethod_87().vmethod_31(), ActiveUnit.Throttle.Flank, false);
			double num2;
			if ((activeUnit_1.bool_6 && ((Ship)activeUnit_1).method_151()) || (activeUnit_1.bool_5 && ((Submarine)activeUnit_1).method_160()))
			{
				num2 = Math.Min(1.0, (double)(activeUnit_1.vmethod_70() + 5f) / ((double)num + 1E-06));
			}
			else
			{
				num2 = (double)activeUnit_1.vmethod_70() / ((double)num + 1E-06);
			}
			return (float)num2;
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0019DA84 File Offset: 0x0019BC84
		private float method_109(ActiveUnit myParent, ActiveUnit theUnit, float? ExplicitSensorDepth = null)
		{
			float num;
			if (this.method_68())
			{
				num = 1f;
			}
			else
			{
				float num2;
				float num3;
				if (myParent.vmethod_40() <= 5f)
				{
					num2 = 0f;
					num3 = 0f;
				}
				else
				{
					num2 = this.method_108(myParent);
					num3 = this.method_107(myParent);
				}
				num = (float)(1.0 - (0.75 * (double)num2 + 0.25 * (double)num3));
				Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
				if (sensor_Type - Sensor.Sensor_Type.TowedArray_ActivePassive <= 1 || sensor_Type - Sensor.Sensor_Type.VDS_ActivePassive <= 1)
				{
					num = this.method_104(myParent, num, ExplicitSensorDepth);
				}
			}
			if (myParent.bool_7)
			{
				num = (float)Math.Max(0.9, (double)num);
			}
			double num4 = (double)this.method_108(theUnit);
			float num5 = this.method_107(theUnit);
			float num6 = (float)(0.75 * num4 + 0.25 * (double)num5);
			XSection xsection = null;
			Sensor.FrequencyBand frequencyBand_ = this.radioElectronicFrequency_0[0].frequencyBand_0;
			long num7 = frequencyBand_ - Sensor.FrequencyBand.const_28;
			int num8;
			if (num7 <= 3L)
			{
				switch ((uint)num7)
				{
				case 0U:
					xsection = Sensor.smethod_3(theUnit, XSection.Enum132.const_1);
					if (xsection == null)
					{
						xsection = Sensor.smethod_3(theUnit, XSection.Enum132.const_1);
					}
					num8 = 112;
					break;
				case 1U:
					xsection = Sensor.smethod_3(theUnit, XSection.Enum132.const_2);
					if (xsection == null)
					{
						xsection = Sensor.smethod_3(theUnit, XSection.Enum132.const_2);
					}
					num8 = 104;
					break;
				case 2U:
					xsection = Sensor.smethod_3(theUnit, XSection.Enum132.const_3);
					if (xsection == null)
					{
						xsection = Sensor.smethod_3(theUnit, XSection.Enum132.const_3);
					}
					num8 = 96;
					break;
				case 3U:
					xsection = Sensor.smethod_3(theUnit, XSection.Enum132.const_0);
					if (xsection == null)
					{
						xsection = Sensor.smethod_3(theUnit, XSection.Enum132.const_0);
					}
					num8 = 142;
					break;
				}
			}
			float result;
			if (xsection == null)
			{
				result = 0f;
			}
			else
			{
				float num9 = myParent.method_46(theUnit, false);
				float num10;
				if (num9 < 315f && num9 > 45f)
				{
					if ((num9 >= 45f && num9 <= 135f) || (num9 >= 225f && num9 <= 315f))
					{
						num10 = xsection.method_10(theUnit);
					}
					else if (num9 >= 135f && num9 <= 225f)
					{
						num10 = xsection.method_11(theUnit);
					}
				}
				else
				{
					num10 = xsection.method_9(theUnit);
				}
				if ((theUnit.bool_6 && ((Ship)theUnit).method_142()) || (theUnit.bool_5 && ((Submarine)theUnit).method_150()))
				{
					num10 += 15f;
				}
				if (theUnit.bool_5 && ((Submarine)theUnit).method_153().method_116(((Submarine)theUnit).method_146()) == FuelRec._FuelType.DieselFuel)
				{
					float num11 = (float)(15.0 * Math.Pow(((double)theUnit.vmethod_70() + 0.0001) / (double)theUnit.vmethod_87().vmethod_39(theUnit.vmethod_14(false)), 2.0));
					if (float.IsNaN(num11) || num11 > 15f)
					{
						num11 = 15f;
					}
					num10 += num11;
				}
				float num12 = num10 / (float)num8;
				float num13 = this.float_0 * num * num6 * num12;
				float num14 = this.method_111(myParent, theUnit, ExplicitSensorDepth);
				float num15 = this.method_103(theUnit.vmethod_30(null), theUnit.vmethod_28(null), theUnit.method_9(false, false, false));
				result = num13 * num14 * num15;
			}
			return result;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0019DDE0 File Offset: 0x0019BFE0
		private bool method_110(ActiveUnit myParent, ActiveUnit theUnit, float TargetRange, Lazy<ObservableDictionary<int, EmissionContainer>> DetectedEmissions, bool IsMaskCheck, bool? LOS_Exists_Sonar, float? ExplicitSensorDepth = null)
		{
			bool result;
			try
			{
				if (!theUnit.vmethod_127())
				{
					result = false;
				}
				else if (!Information.IsNothing(DetectedEmissions) && DetectedEmissions.IsValueCreated)
				{
					result = this.method_106(myParent, theUnit, TargetRange, DetectedEmissions, LOS_Exists_Sonar);
				}
				else if (((LOS_Exists_Sonar != null) ? ((LOS_Exists_Sonar != null) ? new bool?(!LOS_Exists_Sonar.GetValueOrDefault()) : LOS_Exists_Sonar) : new bool?(false)).GetValueOrDefault())
				{
					result = false;
				}
				else
				{
					if (this.sensor_Type_0 == Sensor.Sensor_Type.BottomFixedSonar_PassiveOnly)
					{
						ExplicitSensorDepth = new float?((float)(myParent.method_9(false, false, false) + 1));
					}
					if (myParent.bool_7)
					{
						TargetRange = myParent.method_36(theUnit);
					}
					short num;
					if (this.method_73())
					{
						num = 25;
					}
					else if (myParent.bool_7)
					{
						num = 200;
					}
					else
					{
						num = 30;
					}
					if (myParent.vmethod_40() >= (float)num)
					{
						result = false;
					}
					else if (TargetRange > this.float_0)
					{
						result = false;
					}
					else
					{
						bool flag = true;
						bool flag2 = false;
						if (base.method_18().bool_6 && theUnit.bool_6)
						{
							flag = false;
						}
						if (this.sensor_Type_0 == Sensor.Sensor_Type.BottomFixedSonar_PassiveOnly)
						{
							flag = false;
							flag2 = true;
						}
						if (this.method_68())
						{
							flag = false;
						}
						float num2 = this.method_109(myParent, theUnit, ExplicitSensorDepth);
						float num3 = this.method_111(myParent, theUnit, ExplicitSensorDepth);
						float num4 = this.method_103(theUnit.vmethod_30(null), theUnit.vmethod_28(null), (int)Terrain.smethod_7(theUnit.vmethod_30(null), theUnit.vmethod_28(null), false));
						float num5 = (float)(9.87473 * (double)num3 * (double)num4);
						if (!IsMaskCheck)
						{
							float num6 = myParent.method_32(theUnit);
							float num7;
							switch (this.techGenerationClass_0)
							{
							case GlobalVariables.TechGenerationClass.Early1950s:
								num7 = 20f;
								break;
							case GlobalVariables.TechGenerationClass.Late1950s:
								num7 = 17.5f;
								break;
							case GlobalVariables.TechGenerationClass.Early1960s:
								num7 = 15f;
								break;
							case GlobalVariables.TechGenerationClass.Late1960s:
								num7 = 14f;
								break;
							case GlobalVariables.TechGenerationClass.Early1970s:
								num7 = 13f;
								break;
							case GlobalVariables.TechGenerationClass.Late1970s:
								num7 = 12f;
								break;
							case GlobalVariables.TechGenerationClass.Early1980s:
								num7 = 11f;
								break;
							case GlobalVariables.TechGenerationClass.Late1980s:
								num7 = 10f;
								break;
							case GlobalVariables.TechGenerationClass.Early1990s:
								num7 = 9f;
								break;
							case GlobalVariables.TechGenerationClass.Late1990s:
								num7 = 8f;
								break;
							case GlobalVariables.TechGenerationClass.Early2000s:
								num7 = 7f;
								break;
							case GlobalVariables.TechGenerationClass.Late2000s:
								num7 = 6f;
								break;
							case GlobalVariables.TechGenerationClass.Early2010s:
								num7 = 5f;
								break;
							case GlobalVariables.TechGenerationClass.Late2010s:
								num7 = 4f;
								break;
							case GlobalVariables.TechGenerationClass.Early2020s:
								num7 = 3f;
								break;
							case GlobalVariables.TechGenerationClass.Late2020s:
								num7 = 2f;
								break;
							default:
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								num7 = 10f;
								break;
							}
							try
							{
								foreach (ActiveUnit activeUnit in myParent.scenario_0.method_42())
								{
									if (!Information.IsNothing(activeUnit) && (activeUnit.bool_6 || activeUnit.bool_5 || activeUnit.bool_7) && activeUnit != theUnit && activeUnit.vmethod_127())
									{
										float num8 = myParent.method_32(activeUnit);
										if (Math.Abs(Class437.smethod_3(num6, num8)) < num7 && base.method_20(activeUnit, null) && this.method_110(myParent, activeUnit, myParent.method_36(activeUnit), new Lazy<ObservableDictionary<int, EmissionContainer>>(), true, null, ExplicitSensorDepth) && this.method_109(myParent, activeUnit, ExplicitSensorDepth) > num2)
										{
											return false;
										}
									}
								}
							}
							finally
							{
								List<ActiveUnit>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						if (TargetRange > num2)
						{
							result = false;
						}
						else
						{
							if (flag || flag2)
							{
								if (LOS_Exists_Sonar == null)
								{
									LOS_Exists_Sonar = new bool?(myParent.method_44(theUnit, ref myParent.scenario_0, ref flag2, null));
								}
								if (((LOS_Exists_Sonar != null) ? new bool?(!LOS_Exists_Sonar.GetValueOrDefault()) : LOS_Exists_Sonar).GetValueOrDefault())
								{
									return false;
								}
							}
							if (this.sensor_Type_0 != Sensor.Sensor_Type.BottomFixedSonar_PassiveOnly)
							{
								if (this.method_114(myParent, theUnit, num2, ref TargetRange, ExplicitSensorDepth) && TargetRange < num2)
								{
									return true;
								}
								if (TargetRange > num5)
								{
									return false;
								}
							}
							result = true;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100731", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x0019E27C File Offset: 0x0019C47C
		public float method_111(ActiveUnit SensorParent, ActiveUnit Target, float? ExplicitSensorDepth = null)
		{
			float result = 1f;
			this.method_112(SensorParent, Target, ref result, ExplicitSensorDepth);
			this.method_116(SensorParent, Target, ref result, ExplicitSensorDepth);
			this.method_115(SensorParent, Target, ref result, ExplicitSensorDepth);
			return result;
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0019E2B4 File Offset: 0x0019C4B4
		private void method_112(ActiveUnit myParent, ActiveUnit theUnit, ref float DetectionRange, float? ExplicitSensorDepth = null)
		{
			try
			{
				int num = -50;
				float num2;
				if (ExplicitSensorDepth != null)
				{
					num2 = ExplicitSensorDepth.Value;
				}
				else
				{
					num2 = (float)((int)Math.Round((double)myParent.vmethod_14(false)));
				}
				if (num2 > (float)num && theUnit.vmethod_14(false) > (float)num)
				{
					DetectionRange = (float)(1.5 * (double)DetectionRange);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100732", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x0019E350 File Offset: 0x0019C550
		private bool method_113(ActiveUnit myParent, ActiveUnit theUnit, float MaxSensorRange, float TargetRange, float ActualDetectionRange, float? ExplicitSensorDepth = null)
		{
			float num;
			if (ExplicitSensorDepth != null)
			{
				num = ExplicitSensorDepth.Value;
			}
			else
			{
				num = (float)((int)Math.Round((double)myParent.vmethod_14(false)));
			}
			float num2 = ActualDetectionRange;
			bool result;
			try
			{
				GeoPoint geoPoint = new GeoPoint();
				float num3 = num - (float)Terrain.smethod_7(myParent.vmethod_30(null), myParent.vmethod_28(null), false);
				float num4 = theUnit.vmethod_14(false) - (float)Terrain.smethod_7(theUnit.vmethod_30(null), theUnit.vmethod_28(null), false);
				float num5 = num3 * TargetRange / (num3 + num4);
				double double_ = myParent.vmethod_28(null);
				double double_2 = myParent.vmethod_30(null);
				GeoPoint geoPoint2;
				double double_3 = (geoPoint2 = geoPoint).imethod_0();
				GeoPoint geoPoint3;
				double double_4 = (geoPoint3 = geoPoint).imethod_2();
				Class411.smethod_1(double_, double_2, ref double_3, ref double_4, (double)num5, (double)Math2.smethod_17(myParent.vmethod_30(null), myParent.vmethod_28(null), theUnit.vmethod_30(null), theUnit.vmethod_28(null)));
				geoPoint3.imethod_3(double_4);
				geoPoint2.imethod_1(double_3);
				float num6 = 1f;
				this.method_116(myParent, theUnit, ref num6, ExplicitSensorDepth);
				if (num6 < 1f)
				{
					num2 = ActualDetectionRange * (1f + num6 / 2f);
				}
				GeoPoint geoPoint4 = new GeoPoint(myParent.vmethod_28(null), myParent.vmethod_30(null), num);
				GeoPoint geoPoint_ = new GeoPoint(theUnit.vmethod_28(null), theUnit.vmethod_30(null), theUnit.vmethod_14(false));
				if (geoPoint4.method_14(geoPoint) + geoPoint.method_14(geoPoint_) < num2)
				{
					float num7 = Terrain.smethod_8(geoPoint.imethod_2(), geoPoint.imethod_0(), false);
					float num8 = 1f - num7;
					switch (this.techGenerationClass_0)
					{
					case GlobalVariables.TechGenerationClass.Early1950s:
					case GlobalVariables.TechGenerationClass.Late1950s:
						break;
					case GlobalVariables.TechGenerationClass.Early1960s:
					case GlobalVariables.TechGenerationClass.Late1960s:
						num8 = (float)((double)num8 + 0.1);
						break;
					case GlobalVariables.TechGenerationClass.Early1970s:
					case GlobalVariables.TechGenerationClass.Late1970s:
						num8 = (float)((double)num8 + 0.2);
						break;
					case GlobalVariables.TechGenerationClass.Early1980s:
					case GlobalVariables.TechGenerationClass.Late1980s:
						num8 = (float)((double)num8 + 0.3);
						break;
					case GlobalVariables.TechGenerationClass.Early1990s:
					case GlobalVariables.TechGenerationClass.Late1990s:
						num8 = (float)((double)num8 + 0.4);
						break;
					case GlobalVariables.TechGenerationClass.Early2000s:
					case GlobalVariables.TechGenerationClass.Late2000s:
						num8 = (float)((double)num8 + 0.5);
						break;
					case GlobalVariables.TechGenerationClass.Early2010s:
					case GlobalVariables.TechGenerationClass.Late2010s:
						num8 = (float)((double)num8 + 0.6);
						break;
					case GlobalVariables.TechGenerationClass.Early2020s:
					case GlobalVariables.TechGenerationClass.Late2020s:
						num8 = (float)((double)num8 + 0.7);
						break;
					default:
						throw new NotImplementedException();
					}
					Sensor.FrequencyBand frequencyBand_ = this.radioElectronicFrequency_0[0].frequencyBand_0;
					long num9 = frequencyBand_ - Sensor.FrequencyBand.const_28;
					if (num9 <= 3L)
					{
						switch ((uint)num9)
						{
						case 0U:
							num8 = (float)((double)num8 - 0.3);
							goto IL_33F;
						case 1U:
							num8 = (float)((double)num8 - 0.1);
							goto IL_33F;
						case 2U:
							num8 = num8;
							goto IL_33F;
						case 3U:
							num8 = (float)((double)num8 - 0.5);
							goto IL_33F;
						}
						goto IL_2FF;
						IL_33F:
						num2 *= num8;
						if (num2 <= ActualDetectionRange)
						{
							return true;
						}
						return false;
					}
					IL_2FF:
					throw new NotImplementedException();
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100733", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0019E708 File Offset: 0x0019C908
		private bool method_114(ActiveUnit myParent, ActiveUnit theUnit, float MaxSensorRange, ref float TargetRange, float? ExplicitSensorDepth = null)
		{
			bool result;
			try
			{
				float num = Class568.smethod_0(myParent.vmethod_30(null));
				float num2 = 5f;
				float num3 = num + num2;
				int num4 = 1;
				for (;;)
				{
					float num5 = (float)((double)((float)num4 * num) - (double)num2 * 0.5);
					float num6 = (float)((double)((float)num4 * num) + (double)num2 * 0.5);
					if (num5 > MaxSensorRange)
					{
						break;
					}
					if (TargetRange > num5 && num6 > TargetRange)
					{
						goto IL_71;
					}
					num4++;
				}
				return false;
				IL_71:
				GeoPoint geoPoint = new GeoPoint();
				float num7 = Math2.smethod_17(myParent.vmethod_30(null), myParent.vmethod_28(null), theUnit.vmethod_30(null), theUnit.vmethod_28(null));
				int num8 = 0;
				for (;;)
				{
					float num9 = num3 * (float)num8 + num / 2f;
					if (num9 > TargetRange)
					{
						goto IL_158;
					}
					double double_ = myParent.vmethod_28(null);
					double double_2 = myParent.vmethod_30(null);
					GeoPoint geoPoint2;
					double double_3 = (geoPoint2 = geoPoint).imethod_0();
					GeoPoint geoPoint3;
					double double_4 = (geoPoint3 = geoPoint).imethod_2();
					Class411.smethod_1(double_, double_2, ref double_3, ref double_4, (double)num9, (double)num7);
					geoPoint3.imethod_3(double_4);
					geoPoint2.imethod_1(double_3);
					if (Terrain.smethod_7(geoPoint.imethod_2(), geoPoint.imethod_0(), false) > -200)
					{
						break;
					}
					num8++;
				}
				return false;
				IL_158:
				result = true;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100733", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x0019E8CC File Offset: 0x0019CACC
		private void method_115(ActiveUnit myParent, ActiveUnit theUnit, ref float DetectionRange, float? ExplicitSensorDepth = null)
		{
			try
			{
				Class568.Class569 @class = Class568.smethod_2(myParent.vmethod_30(null), myParent.vmethod_28(null), myParent.method_9(false, false, false));
				Class568.Class569 class2 = Class568.smethod_2(theUnit.vmethod_30(null), theUnit.vmethod_28(null), theUnit.method_9(false, false, false));
				float num;
				if (ExplicitSensorDepth != null)
				{
					num = ExplicitSensorDepth.Value;
				}
				else
				{
					num = (float)((int)Math.Round((double)myParent.vmethod_14(false)));
				}
				int num2 = (int)Class568.smethod_3(num, @class);
				Class568.Enum154 @enum = Class568.smethod_3((float)((int)Math.Round((double)theUnit.vmethod_14(false))), class2);
				if (num2 == 2 && @enum == Class568.Enum154.const_2)
				{
					if (@class.method_0(num) && class2.method_0((float)((int)Math.Round((double)theUnit.vmethod_14(false)))))
					{
						DetectionRange *= 2f;
					}
					else if (@class.method_0(num) || class2.method_0((float)((int)Math.Round((double)theUnit.vmethod_14(false)))))
					{
						DetectionRange = (float)((double)DetectionRange * 1.5);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 102134656566777", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x0019EA30 File Offset: 0x0019CC30
		private void method_116(ActiveUnit myParent, ActiveUnit theUnit, ref float DetectionRange, float? ExplicitSensorDepth = null)
		{
			try
			{
				Class568.Class569 @class = Class568.smethod_2(myParent.vmethod_30(null), myParent.vmethod_28(null), myParent.method_9(false, false, false));
				Class568.Class569 class2 = Class568.smethod_2(theUnit.vmethod_30(null), theUnit.vmethod_28(null), theUnit.method_9(false, false, false));
				float num;
				if (ExplicitSensorDepth != null)
				{
					num = ExplicitSensorDepth.Value;
				}
				else
				{
					num = (float)((int)Math.Round((double)myParent.vmethod_14(false)));
				}
				Class568.Enum154 @enum = Class568.smethod_3(num, @class);
				Class568.Enum154 enum2 = Class568.smethod_3((float)((int)Math.Round((double)theUnit.vmethod_14(false))), class2);
				float num2 = (@class.float_0 + class2.float_0) / 2f;
				if (@enum != Class568.Enum154.const_0 || enum2 != Class568.Enum154.const_0)
				{
					if (@enum == Class568.Enum154.const_1 && enum2 == Class568.Enum154.const_1)
					{
						DetectionRange = (float)((double)DetectionRange * Math.Max(0.1, (double)(1f - num2 * 2f)));
					}
					else
					{
						if (@enum != Class568.Enum154.const_1)
						{
							if (enum2 != Class568.Enum154.const_1)
							{
								if (@enum != enum2)
								{
									DetectionRange *= 1f - num2;
									goto IL_123;
								}
								if (@enum == Class568.Enum154.const_2)
								{
									goto IL_123;
								}
								goto IL_123;
							}
						}
						DetectionRange *= 1f - num2 / 2f;
					}
				}
				IL_123:;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100734", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x0019EBB8 File Offset: 0x0019CDB8
		private bool method_117(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2, float float_37, ref Unit.Enum123? nullable_1)
		{
			bool result;
			try
			{
				bool? flag;
				if (nullable_1 == null)
				{
					flag = new bool?(false);
				}
				else
				{
					Unit.Enum123? @enum = nullable_1;
					int? num = (@enum != null) ? new int?((int)@enum.GetValueOrDefault()) : null;
					flag = ((num != null) ? new bool?(num.GetValueOrDefault() != 1) : null);
				}
				bool? flag2 = flag;
				if (flag2.GetValueOrDefault())
				{
					result = false;
				}
				else if (float_37 > this.float_0)
				{
					result = false;
				}
				else if (activeUnit_2.bool_5 && Math.Round((double)activeUnit_2.vmethod_14(false)) >= -20.0 && activeUnit_2.vmethod_14(false) < -5f && !this.struct32_0.bool_5)
				{
					result = false;
				}
				else if (this.method_90(activeUnit_1, activeUnit_2) < float_37)
				{
					result = false;
				}
				else
				{
					if (this.struct32_0.bool_6 && activeUnit_2.bool_2)
					{
						Weapon._WeaponType weaponType = ((Weapon)activeUnit_2).method_167();
						if (weaponType - Weapon._WeaponType.BallisticMissile <= 1 || weaponType == Weapon._WeaponType.HGV)
						{
							float num2 = (float)((int)Math.Round((double)activeUnit_2.vmethod_14(false)));
							return Class562.smethod_3(activeUnit_1, ref num2) > Math2.smethod_15(activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), activeUnit_2.vmethod_30(null), activeUnit_2.vmethod_28(null));
						}
					}
					if (nullable_1 == null)
					{
						nullable_1 = new Unit.Enum123?(activeUnit_1.method_43(activeUnit_2, ref activeUnit_1.scenario_0, true));
					}
					result = (nullable_1.Value == Unit.Enum123.const_1);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100735", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x0019EDC8 File Offset: 0x0019CFC8
		public Sensor.Enum115 method_118(ActiveUnit activeUnit_1, ref Contact contact_0, ref Scenario scenario_0, float float_37, List<ActiveUnit> list_3, bool bool_15, bool bool_16, ref bool? nullable_1, ref bool? nullable_2, ref Unit.Enum123? nullable_3, ref bool? nullable_4)
		{
			ActiveUnit activeUnit_2 = contact_0.activeUnit_0;
			return this.method_123(activeUnit_1, activeUnit_2, float_37, list_3, bool_15, bool_16, ref nullable_1, ref nullable_2, ref nullable_3, ref nullable_4);
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0019EDF8 File Offset: 0x0019CFF8
		private Sensor.Enum115 method_119(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2, float float_37, List<ActiveUnit> list_3, bool bool_15, bool bool_16, ref bool? nullable_1, ref bool? nullable_2)
		{
			Sensor.Enum115 result;
			try
			{
				if (this.struct32_0.bool_18)
				{
					bool? flag;
					bool? flag2;
					if (nullable_2 == null)
					{
						flag = new bool?(false);
					}
					else
					{
						flag2 = nullable_2;
						flag = ((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2);
					}
					flag2 = flag;
					if (flag2.GetValueOrDefault())
					{
						return Sensor.Enum115.const_3;
					}
				}
				else
				{
					bool? flag2;
					bool? flag3;
					if (nullable_1 == null)
					{
						flag3 = new bool?(false);
					}
					else
					{
						flag2 = nullable_1;
						flag3 = ((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2);
					}
					flag2 = flag3;
					if (flag2.GetValueOrDefault())
					{
						return Sensor.Enum115.const_3;
					}
				}
				if ((!bool_15 || float_37 <= 5f) && !bool_16 && !this.method_124(activeUnit_2, null))
				{
					result = Sensor.Enum115.const_7;
				}
				else
				{
					float num = base.method_18().method_46(activeUnit_2, false);
					XSection.Enum132 @enum;
					if (!this.method_29(Sensor.FrequencyBand.const_0) && !this.method_29(Sensor.FrequencyBand.const_1) && !this.method_29(Sensor.FrequencyBand.const_2) && !this.method_29(Sensor.FrequencyBand.const_3))
					{
						@enum = XSection.Enum132.const_10;
					}
					else
					{
						@enum = XSection.Enum132.const_9;
					}
					if (!Information.IsNothing(@enum))
					{
						XSection xsection = Sensor.smethod_3(activeUnit_2, @enum);
						if (Information.IsNothing(xsection))
						{
							result = Sensor.Enum115.const_11;
						}
						else
						{
							float float_38;
							if (num < 315f && num > 45f)
							{
								if ((num >= 45f && num <= 135f) || (num >= 225f && num <= 315f))
								{
									float_38 = xsection.method_10(activeUnit_2);
								}
								else if (num >= 135f && num <= 225f)
								{
									float_38 = xsection.method_11(activeUnit_2);
								}
							}
							else
							{
								float_38 = xsection.method_9(activeUnit_2);
							}
							if (!this.method_129(activeUnit_1, activeUnit_2, float_38, float_37, Sensor.Enum116.const_1, list_3, activeUnit_1.method_74()))
							{
								result = Sensor.Enum115.const_10;
							}
							else
							{
								if (this.struct32_0.bool_6 && activeUnit_2.bool_2)
								{
									Weapon._WeaponType weaponType = ((Weapon)activeUnit_2).method_167();
									if (weaponType - Weapon._WeaponType.BallisticMissile <= 1 || weaponType == Weapon._WeaponType.HGV)
									{
										if (Class562.smethod_1(activeUnit_1, activeUnit_2) > Math2.smethod_15(activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), activeUnit_2.vmethod_30(null), activeUnit_2.vmethod_28(null)))
										{
											return Sensor.Enum115.const_1;
										}
										return Sensor.Enum115.const_6;
									}
								}
								if (this.struct32_0.bool_18)
								{
									if (nullable_2 == null)
									{
										nullable_2 = new bool?(activeUnit_1.method_42(activeUnit_2, ref activeUnit_1.scenario_0, true));
									}
									if (nullable_2.Value)
									{
										result = Sensor.Enum115.const_1;
									}
									else
									{
										result = Sensor.Enum115.const_3;
									}
								}
								else
								{
									if (nullable_1 == null)
									{
										nullable_1 = new bool?(activeUnit_1.method_42(activeUnit_2, ref activeUnit_1.scenario_0, false));
									}
									if (nullable_1.Value)
									{
										result = Sensor.Enum115.const_1;
									}
									else
									{
										result = Sensor.Enum115.const_3;
									}
								}
							}
						}
					}
					else
					{
						result = Sensor.Enum115.const_11;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100736", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Sensor.Enum115.const_0;
			}
			return result;
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0019F140 File Offset: 0x0019D340
		private Sensor.Enum115 method_120(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2, float float_37, bool bool_15, bool bool_16, ref Unit.Enum123? nullable_1)
		{
			Sensor.Enum115 result;
			try
			{
				if (nullable_1 != null && nullable_1.Value != Unit.Enum123.const_1)
				{
					Unit.Enum123 value = nullable_1.Value;
					switch (value)
					{
					case Unit.Enum123.const_2:
						result = Sensor.Enum115.const_6;
						break;
					case Unit.Enum123.const_3:
						result = Sensor.Enum115.const_3;
						break;
					case Unit.Enum123.const_4:
						result = Sensor.Enum115.const_4;
						break;
					default:
						if (value != Unit.Enum123.const_5)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							result = Sensor.Enum115.const_11;
						}
						else
						{
							result = Sensor.Enum115.const_11;
						}
						break;
					}
				}
				else if ((!bool_15 || float_37 <= 5f) && !bool_16 && !this.method_124(activeUnit_2, null))
				{
					result = Sensor.Enum115.const_7;
				}
				else
				{
					float num;
					switch (activeUnit_2.vmethod_121())
					{
					case GlobalVariables.TargetVisualSizeClass.Stealthy:
						num = (float)((double)this.float_0 * 0.1);
						break;
					case GlobalVariables.TargetVisualSizeClass.VSmall:
						num = (float)((double)this.float_0 * 0.18);
						break;
					case GlobalVariables.TargetVisualSizeClass.Small:
						num = (float)((double)this.float_0 * 0.4);
						break;
					case GlobalVariables.TargetVisualSizeClass.Medium:
						num = (float)((double)this.float_0 * 0.62);
						break;
					case GlobalVariables.TargetVisualSizeClass.Large:
						num = (float)((double)this.float_0 * 0.8);
						break;
					case GlobalVariables.TargetVisualSizeClass.VLarge:
						num = this.float_0;
						break;
					}
					if (float_37 > num)
					{
						result = Sensor.Enum115.const_2;
					}
					else if (this.struct32_0.bool_6 && activeUnit_2.bool_2 && ((Weapon)activeUnit_2).method_204())
					{
						float num2 = (float)((int)Math.Round((double)activeUnit_2.vmethod_14(false)));
						if (Class562.smethod_3(activeUnit_1, ref num2) > Math2.smethod_15(activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), activeUnit_2.vmethod_30(null), activeUnit_2.vmethod_28(null)))
						{
							result = Sensor.Enum115.const_1;
						}
						else
						{
							result = Sensor.Enum115.const_6;
						}
					}
					else
					{
						if (nullable_1 == null)
						{
							nullable_1 = new Unit.Enum123?(activeUnit_1.method_43(activeUnit_2, ref activeUnit_1.scenario_0, true));
						}
						if (nullable_1.Value == Unit.Enum123.const_1)
						{
							result = Sensor.Enum115.const_1;
						}
						else
						{
							Unit.Enum123 value2 = nullable_1.Value;
							switch (value2)
							{
							case Unit.Enum123.const_2:
								result = Sensor.Enum115.const_6;
								break;
							case Unit.Enum123.const_3:
								result = Sensor.Enum115.const_3;
								break;
							case Unit.Enum123.const_4:
								result = Sensor.Enum115.const_4;
								break;
							default:
								if (value2 != Unit.Enum123.const_5)
								{
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									result = Sensor.Enum115.const_11;
								}
								else
								{
									result = Sensor.Enum115.const_11;
								}
								break;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100737", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Sensor.Enum115.const_0;
			}
			return result;
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0019F3FC File Offset: 0x0019D5FC
		private Sensor.Enum115 method_121(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2, float float_37, ref Unit.Enum123? nullable_1)
		{
			Sensor.Enum115 result;
			try
			{
				bool? flag;
				if (nullable_1 == null)
				{
					flag = new bool?(false);
				}
				else
				{
					Unit.Enum123? @enum = nullable_1;
					int? num = (@enum != null) ? new int?((int)@enum.GetValueOrDefault()) : null;
					flag = ((num != null) ? new bool?(num.GetValueOrDefault() != 1) : null);
				}
				bool? flag2 = flag;
				if (flag2.GetValueOrDefault())
				{
					Unit.Enum123 value = nullable_1.Value;
					if (value != Unit.Enum123.const_3)
					{
						if (value == Unit.Enum123.const_4)
						{
							result = Sensor.Enum115.const_4;
						}
						else
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							result = Sensor.Enum115.const_11;
						}
					}
					else
					{
						result = Sensor.Enum115.const_3;
					}
				}
				else
				{
					float num2 = this.float_0;
					this.method_95(activeUnit_1, activeUnit_2, ref num2);
					if (float_37 > num2)
					{
						result = Sensor.Enum115.const_2;
					}
					else
					{
						if (nullable_1 == null)
						{
							nullable_1 = new Unit.Enum123?(activeUnit_1.method_43(activeUnit_2, ref activeUnit_1.scenario_0, true));
						}
						if (nullable_1.Value == Unit.Enum123.const_1)
						{
							result = Sensor.Enum115.const_1;
						}
						else
						{
							Unit.Enum123 value2 = nullable_1.Value;
							switch (value2)
							{
							case Unit.Enum123.const_2:
								result = Sensor.Enum115.const_6;
								break;
							case Unit.Enum123.const_3:
								result = Sensor.Enum115.const_3;
								break;
							case Unit.Enum123.const_4:
								result = Sensor.Enum115.const_4;
								break;
							default:
								if (value2 != Unit.Enum123.const_5)
								{
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									result = Sensor.Enum115.const_11;
								}
								else
								{
									result = Sensor.Enum115.const_11;
								}
								break;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100738", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Sensor.Enum115.const_11;
			}
			return result;
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0019F5B0 File Offset: 0x0019D7B0
		private Sensor.Enum115 method_122(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2, float float_37, ref Unit.Enum123? nullable_1)
		{
			Sensor.Enum115 result;
			try
			{
				if (nullable_1 != null && nullable_1.Value != Unit.Enum123.const_1)
				{
					Unit.Enum123 value = nullable_1.Value;
					switch (value)
					{
					case Unit.Enum123.const_2:
						result = Sensor.Enum115.const_6;
						break;
					case Unit.Enum123.const_3:
						result = Sensor.Enum115.const_3;
						break;
					case Unit.Enum123.const_4:
						result = Sensor.Enum115.const_4;
						break;
					default:
						if (value != Unit.Enum123.const_5)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							result = Sensor.Enum115.const_11;
						}
						else
						{
							result = Sensor.Enum115.const_11;
						}
						break;
					}
				}
				else if (float_37 > this.float_0)
				{
					result = Sensor.Enum115.const_2;
				}
				else
				{
					if (nullable_1 == null)
					{
						nullable_1 = new Unit.Enum123?(activeUnit_1.method_43(activeUnit_2, ref activeUnit_1.scenario_0, true));
					}
					if (nullable_1.Value == Unit.Enum123.const_1)
					{
						result = Sensor.Enum115.const_1;
					}
					else
					{
						Unit.Enum123 value2 = nullable_1.Value;
						switch (value2)
						{
						case Unit.Enum123.const_2:
							result = Sensor.Enum115.const_6;
							break;
						case Unit.Enum123.const_3:
							result = Sensor.Enum115.const_3;
							break;
						case Unit.Enum123.const_4:
							result = Sensor.Enum115.const_4;
							break;
						default:
							if (value2 != Unit.Enum123.const_5)
							{
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								result = Sensor.Enum115.const_11;
							}
							else
							{
								result = Sensor.Enum115.const_11;
							}
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100739", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Sensor.Enum115.const_0;
			}
			return result;
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0019F718 File Offset: 0x0019D918
		public Sensor.Enum115 method_123(ActiveUnit activeUnit_1, ActiveUnit activeUnit_2, float float_37, List<ActiveUnit> list_3, bool bool_15, bool bool_16, ref bool? nullable_1, ref bool? nullable_2, ref Unit.Enum123? nullable_3, ref bool? nullable_4)
		{
			Sensor.Enum115 result;
			if (activeUnit_1.bool_2 && ((Weapon)activeUnit_1).bool_31)
			{
				result = Sensor.Enum115.const_1;
			}
			else if (activeUnit_2.method_82())
			{
				result = Sensor.Enum115.const_11;
			}
			else
			{
				try
				{
					if ((!bool_15 || float_37 <= 5f) && !bool_16 && !this.method_124(activeUnit_2, null))
					{
						result = Sensor.Enum115.const_7;
					}
					else if (this.float_0 < float_37)
					{
						result = Sensor.Enum115.const_2;
					}
					else if (!this.method_63(activeUnit_2))
					{
						result = Sensor.Enum115.const_8;
					}
					else
					{
						Sensor.Sensor_Type sensor_Type = this.sensor_Type_0;
						Sensor.Enum115 @enum;
						switch (sensor_Type)
						{
						case Sensor.Sensor_Type.Radar:
							@enum = this.method_119(activeUnit_1, activeUnit_2, float_37, list_3, bool_15, bool_16, ref nullable_1, ref nullable_2);
							goto IL_EC;
						case Sensor.Sensor_Type.SemiActive:
							break;
						case Sensor.Sensor_Type.Visual:
							@enum = this.method_120(activeUnit_1, activeUnit_2, float_37, bool_15, bool_16, ref nullable_3);
							goto IL_EC;
						case Sensor.Sensor_Type.Infrared:
							@enum = this.method_122(activeUnit_1, activeUnit_2, float_37, ref nullable_3);
							goto IL_EC;
						default:
							if (sensor_Type == Sensor.Sensor_Type.LaserDesignator)
							{
								@enum = this.method_121(activeUnit_1, activeUnit_2, float_37, ref nullable_3);
								goto IL_EC;
							}
							break;
						}
						return Sensor.Enum115.const_0;
						IL_EC:
						result = @enum;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100740", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = Sensor.Enum115.const_0;
				}
			}
			return result;
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x0019F860 File Offset: 0x0019DA60
		public bool method_124(Unit theTarget, float? CustomParentHeading = null)
		{
			bool result;
			try
			{
				if (Information.IsNothing(theTarget))
				{
					result = false;
				}
				else
				{
					ActiveUnit activeUnit = base.method_18();
					float num = Math2.smethod_17(activeUnit.vmethod_30(null), activeUnit.vmethod_28(null), theTarget.vmethod_30(null), theTarget.vmethod_28(null));
					float num2;
					if (Information.IsNothing(CustomParentHeading))
					{
						num2 = activeUnit.vmethod_9();
					}
					else
					{
						num2 = CustomParentHeading.Value;
					}
					float num3 = Math2.smethod_7(num - num2);
					if (num3 <= 22.5f)
					{
						result = this.class295_1.bool_7;
					}
					else if (num3 <= 45f)
					{
						result = this.class295_1.bool_15;
					}
					else if (num3 <= 67.5f)
					{
						result = this.class295_1.bool_6;
					}
					else if (num3 <= 90f)
					{
						result = this.class295_1.bool_14;
					}
					else if (num3 <= 112.5f)
					{
						result = this.class295_1.bool_5;
					}
					else if (num3 <= 135f)
					{
						result = this.class295_1.bool_13;
					}
					else if (num3 <= 157.5f)
					{
						result = this.class295_1.bool_4;
					}
					else if (num3 <= 180f)
					{
						result = this.class295_1.bool_12;
					}
					else if (num3 <= 202.5f)
					{
						result = this.class295_1.bool_0;
					}
					else if (num3 <= 225f)
					{
						result = this.class295_1.bool_8;
					}
					else if (num3 <= 247.5f)
					{
						result = this.class295_1.bool_1;
					}
					else if (num3 <= 270f)
					{
						result = this.class295_1.bool_9;
					}
					else if (num3 <= 292.5f)
					{
						result = this.class295_1.bool_2;
					}
					else if (num3 <= 315f)
					{
						result = this.class295_1.bool_10;
					}
					else if (num3 <= 337.5f)
					{
						result = this.class295_1.bool_3;
					}
					else
					{
						result = this.class295_1.bool_11;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100741", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x0019FAD4 File Offset: 0x0019DCD4
		public HashSet<Sensor.FrequencyBand> method_125()
		{
			HashSet<Sensor.FrequencyBand> hashSet;
			try
			{
				if (Information.IsNothing(this.hashSet_0))
				{
					List<Sensor.FrequencyBand> list = new List<Sensor.FrequencyBand>();
					list.AddRange(Enumerable.Select<Sensor.RadioElectronicFrequency, Sensor.FrequencyBand>(this.radioElectronicFrequency_0, (Sensor._Closure$__.$I251-0 == null) ? (Sensor._Closure$__.$I251-0 = new Func<Sensor.RadioElectronicFrequency, Sensor.FrequencyBand>(Sensor._Closure$__.$I.method_0)) : Sensor._Closure$__.$I251-0));
					list.AddRange(Enumerable.Select<Sensor.RadioElectronicFrequency, Sensor.FrequencyBand>(this.radioElectronicFrequency_1, (Sensor._Closure$__.$I251-1 == null) ? (Sensor._Closure$__.$I251-1 = new Func<Sensor.RadioElectronicFrequency, Sensor.FrequencyBand>(Sensor._Closure$__.$I.method_1)) : Sensor._Closure$__.$I251-1));
					this.hashSet_0 = new HashSet<Sensor.FrequencyBand>(list);
				}
				hashSet = this.hashSet_0;
			}
			catch (Exception ex)
			{
				hashSet = hashSet;
			}
			return hashSet;
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x0000BEB8 File Offset: 0x0000A0B8
		private bool method_126(CommDevice commDevice_0)
		{
			return Enumerable.Any<Sensor.FrequencyBand>(Enumerable.Intersect<Sensor.FrequencyBand>(this.method_125(), commDevice_0.hashSet_0));
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x0019FB94 File Offset: 0x0019DD94
		private bool method_127(Sensor sensor_0)
		{
			int dbid;
			int dbid2;
			if (this.DBID > sensor_0.DBID)
			{
				dbid = this.DBID;
				dbid2 = sensor_0.DBID;
			}
			else
			{
				dbid2 = this.DBID;
				dbid = sensor_0.DBID;
			}
			ConcurrentDictionary<int, bool> concurrentDictionary;
			if (base.method_18().scenario_0.Cache_SensorCompatibleFrequencies.ContainsKey(dbid))
			{
				concurrentDictionary = base.method_18().scenario_0.Cache_SensorCompatibleFrequencies[dbid];
			}
			else
			{
				concurrentDictionary = new ConcurrentDictionary<int, bool>();
				base.method_18().scenario_0.Cache_SensorCompatibleFrequencies.TryAdd(dbid, concurrentDictionary);
			}
			bool result;
			if (!concurrentDictionary.ContainsKey(dbid2))
			{
				bool flag = Enumerable.Any<Sensor.FrequencyBand>(Enumerable.Intersect<Sensor.FrequencyBand>(this.method_125(), sensor_0.method_125()));
				concurrentDictionary.TryAdd(dbid2, flag);
				result = flag;
			}
			else
			{
				result = concurrentDictionary[dbid2];
			}
			return result;
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x0019FC58 File Offset: 0x0019DE58
		private bool method_128(Sensor sensor_0, float float_37, Sensor.Enum116 enum116_0, Weather.WeatherProfile weatherProfile_0)
		{
			bool result;
			try
			{
				Class563.Class565 @class = new Class563.Class565();
				Class563.Struct54 @struct = default(Class563.Struct54);
				@class.float_0 = (float)((int)Math.Round((double)sensor_0.method_18().vmethod_14(false)));
				@class.double_16 = -Class563.smethod_7((double)float_37, (double)sensor_0.method_18().vmethod_14(false), (double)base.method_18().vmethod_14(false), ref weatherProfile_0);
				if (enum116_0 != Sensor.Enum116.const_0)
				{
					if (enum116_0 == Sensor.Enum116.const_1)
					{
						@class.method_16((double)sensor_0.float_18, (double)sensor_0.float_19);
						@class.double_10 = (double)sensor_0.float_22;
						@class.method_3((double)sensor_0.float_23);
						@class.method_10((double)sensor_0.float_21);
						@class.method_14((double)sensor_0.float_20);
						@class.double_9 = (double)(sensor_0.method_38() + sensor_0.method_39()) / 2.0;
						@class.method_1((double)sensor_0.float_25);
					}
				}
				else
				{
					@class.method_16((double)sensor_0.float_10, (double)sensor_0.float_11);
					@class.double_10 = (double)sensor_0.float_14;
					@class.method_3((double)sensor_0.float_15);
					@class.method_10((double)sensor_0.float_13);
					@class.method_14((double)sensor_0.float_12);
					@class.double_9 = (double)(sensor_0.method_36() + sensor_0.method_37()) / 2.0;
					@class.method_1((double)sensor_0.float_17);
				}
				if (sensor_0.struct33_0.bool_20)
				{
					@class.double_10 *= 0.025;
				}
				@struct.float_0 = (float)((int)Math.Round((double)base.method_18().vmethod_14(false)));
				@struct.double_0 = (double)this.float_26;
				@struct.double_1 = (double)this.float_27;
				Class563.Interface11 emitter = @class;
				Class563.Struct54 receiver = @struct;
				double distanceToEmitter = (double)float_37;
				double azimouthOffEmitterBoresight = 0.0;
				Weather.WeatherProfile env = weatherProfile_0;
				Class563.Interface10 @interface = null;
				result = Class563.smethod_4(emitter, receiver, distanceToEmitter, azimouthOffEmitterBoresight, env, ref @interface);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100742", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x0019FE7C File Offset: 0x0019E07C
		private bool method_129(ActiveUnit activeUnit_1, Unit unit_0, float float_37, float float_38, Sensor.Enum116 enum116_0, List<ActiveUnit> list_3, Weather.WeatherProfile weatherProfile_0)
		{
			bool result;
			try
			{
				Class563.Class567 @class = new Class563.Class567();
				double num = Class563.smethod_7((double)float_38, (double)(base.method_18().vmethod_14(false) + (float)base.method_18().vmethod_11()), (double)unit_0.vmethod_14(false), ref weatherProfile_0);
				this.class565_0.float_0 = activeUnit_1.method_41(activeUnit_1);
				this.class565_0.double_16 = -num;
				if (enum116_0 != Sensor.Enum116.const_0)
				{
					if (enum116_0 == Sensor.Enum116.const_1)
					{
						this.class565_0.method_16((double)this.float_18, (double)this.float_19);
						this.class565_0.double_10 = (double)this.float_22;
						this.class565_0.method_3((double)this.float_23);
						this.class565_0.method_10((double)this.float_21);
						this.class565_0.method_14((double)this.float_20);
						this.class565_0.double_9 = (double)(this.method_38() + this.method_39()) * 0.5;
						this.class565_0.method_1((double)this.float_25);
					}
				}
				else
				{
					this.class565_0.method_16((double)this.float_10, (double)this.float_11);
					this.class565_0.double_10 = (double)this.float_14;
					this.class565_0.method_3((double)this.float_15);
					this.class565_0.method_10((double)this.float_13);
					this.class565_0.method_14((double)this.float_12);
					this.class565_0.double_9 = (double)(this.method_36() + this.method_37()) * 0.5;
					this.class565_0.method_1((double)this.float_17);
				}
				if (!unit_0.bool_6 && !unit_0.bool_8 && !unit_0.bool_5)
				{
					@class.float_0 = unit_0.method_40(unit_0);
				}
				else
				{
					@class.double_1 = (double)unit_0.method_40(unit_0);
					@class.enum152_0 = Class563.Enum152.const_3;
					if (this.struct33_0.bool_22)
					{
						this.class565_0.method_7(Class563.Enum153.const_1);
					}
					else if (this.struct33_0.bool_23)
					{
						this.class565_0.method_7(Class563.Enum153.const_2);
					}
					else if (this.struct33_0.bool_24)
					{
						this.class565_0.method_7(Class563.Enum153.const_3);
					}
				}
				@class.double_0 = (double)float_37;
				if ((unit_0.bool_3 || unit_0.method_2()) && (this.struct33_0.bool_13 || this.struct33_0.bool_12) && !this.struct33_0.bool_20 && !this.struct33_0.bool_19 && !this.struct33_0.bool_25)
				{
					float num2;
					if (base.method_18().bool_3)
					{
						num2 = base.method_18().vmethod_9();
					}
					else
					{
						num2 = base.method_18().method_32(unit_0);
					}
					if (Math.Abs(Math2.smethod_36((double)num2, (double)unit_0.vmethod_9(), (double)unit_0.method_20())) < 60.0)
					{
						if (unit_0.method_2())
						{
							@class.method_1(@class.method_0() * 0.06);
						}
						else if (unit_0.bool_3)
						{
							GlobalVariables.ProficiencyLevel? proficiencyLevel = ((Aircraft)unit_0).vmethod_53();
							int? num3 = (proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								@class.method_1(@class.method_0() * 0.66);
							}
							else
							{
								num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									@class.method_1(@class.method_0() * 0.32);
								}
								else
								{
									num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
									if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										@class.method_1(@class.method_0() * 0.06);
									}
									else
									{
										num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
										if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											@class.method_1(@class.method_0() * 0.004);
										}
										else
										{
											num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
											if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
											{
												@class.method_1(@class.method_0() * 0.001);
											}
										}
									}
								}
							}
						}
					}
				}
				if (unit_0.bool_8 && activeUnit_1.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_10) && Terrain.smethod_7(unit_0.vmethod_30(null), unit_0.vmethod_28(null), false) > 0)
				{
					switch (LandCover.smethod_1(unit_0.vmethod_30(null), unit_0.vmethod_28(null)))
					{
					case LandCover.LandCoverType.Water:
					case LandCover.LandCoverType.Grasslands:
					case LandCover.LandCoverType.Permanent_wetlands:
					case LandCover.LandCoverType.SnowAndIce:
					case LandCover.LandCoverType.BarrenOrSparselyVegetated:
						break;
					case LandCover.LandCoverType.Evergreen_Needleleaf_forest:
					case LandCover.LandCoverType.Evergreen_Broadleaf_forest:
					case LandCover.LandCoverType.Deciduous_Needleleaf_forest:
					case LandCover.LandCoverType.Deciduous_Broadleaf_forest:
					case LandCover.LandCoverType.Mixed_forest:
						@class.method_1(@class.method_0() * 0.06);
						break;
					case LandCover.LandCoverType.Closed_shrublands:
					case LandCover.LandCoverType.Open_shrublands:
						@class.method_1(@class.method_0() * 0.32);
						break;
					case LandCover.LandCoverType.Woody_savannas:
					case LandCover.LandCoverType.Savannas:
						@class.method_1(@class.method_0() * 0.66);
						break;
					case LandCover.LandCoverType.Croplands:
					case LandCover.LandCoverType.CroplandNaturalVegetationMosaic:
						@class.method_1(@class.method_0() * 0.5);
						break;
					case LandCover.LandCoverType.UrbanAndBuiltUp:
						@class.method_1(@class.method_0() * 0.004);
						break;
					default:
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						break;
					}
				}
				if (list_3 == null)
				{
					list_3 = base.method_18().vmethod_88().method_10(false);
				}
				List<Sensor> list = new List<Sensor>();
				try
				{
					foreach (ActiveUnit activeUnit in list_3)
					{
						foreach (Sensor sensor in activeUnit.method_78())
						{
							if (sensor.method_72() && sensor.method_33(this))
							{
								list.Add(sensor);
							}
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				float num4 = Math2.smethod_17(base.method_18().vmethod_30(null), base.method_18().vmethod_28(null), unit_0.vmethod_30(null), unit_0.vmethod_28(null));
				int count = list.Count;
				Class563.Class566[] array2 = new Class563.Class566[count - 1 + 1];
				double[] array3 = new double[count - 1 + 1];
				double[] array4 = new double[count - 1 + 1];
				int num5 = count - 1;
				for (int j = 0; j <= num5; j++)
				{
					Sensor sensor2 = list[j];
					Class563.Class566 class2 = new Class563.Class566();
					class2.method_1((double)sensor2.float_30);
					class2.imethod_5((double)sensor2.method_18().vmethod_14(false));
					class2.imethod_1(this.class565_0.double_9);
					class2.ns14.Class563.Interface11.imethod_9((double)sensor2.float_28);
					class2.ns14.Class563.Interface11.imethod_3((double)sensor2.float_29);
					if (this.struct33_0.bool_20)
					{
						class2.ns14.Class563.Interface11.imethod_3(class2.ns14.Class563.Interface11.imethod_2() * 0.1);
					}
					else if (this.struct33_0.bool_19)
					{
						class2.ns14.Class563.Interface11.imethod_3(class2.ns14.Class563.Interface11.imethod_2() * 0.5);
					}
					else if (this.struct33_0.bool_25)
					{
						class2.ns14.Class563.Interface11.imethod_3(class2.ns14.Class563.Interface11.imethod_2() * 0.75);
					}
					int num6 = this.techGenerationClass_0 - sensor2.techGenerationClass_0;
					if (num6 < -3)
					{
						class2.ns14.Class563.Interface11.imethod_3(class2.ns14.Class563.Interface11.imethod_2() * 20.0);
					}
					else if (num6 == -3)
					{
						class2.ns14.Class563.Interface11.imethod_3(class2.ns14.Class563.Interface11.imethod_2() * 10.0);
					}
					else if (num6 == -2)
					{
						class2.ns14.Class563.Interface11.imethod_3(class2.ns14.Class563.Interface11.imethod_2() * 5.0);
					}
					else if (num6 == -1)
					{
						class2.ns14.Class563.Interface11.imethod_3(class2.ns14.Class563.Interface11.imethod_2() * 2.0);
					}
					else if (num6 != 0)
					{
						if (num6 == 1)
						{
							class2.ns14.Class563.Interface11.imethod_3(class2.ns14.Class563.Interface11.imethod_2() * 0.5);
						}
						else if (num6 == 2)
						{
							class2.ns14.Class563.Interface11.imethod_3(class2.ns14.Class563.Interface11.imethod_2() * 0.2);
						}
						else if (num6 == 3)
						{
							class2.ns14.Class563.Interface11.imethod_3(class2.ns14.Class563.Interface11.imethod_2() * 0.1);
						}
						else if (num6 > 3)
						{
							class2.ns14.Class563.Interface11.imethod_3(class2.ns14.Class563.Interface11.imethod_2() * 0.05);
						}
					}
					array2[j] = class2;
					float num7 = base.method_18().method_37(sensor2.method_18(), 0f);
					array3[j] = (double)num7;
					float num8 = Class437.smethod_3(num4, Math2.smethod_17(base.method_18().vmethod_30(null), base.method_18().vmethod_28(null), sensor2.method_18().vmethod_30(null), sensor2.method_18().vmethod_28(null)));
					array4[j] = (double)num8;
				}
				if (!this.struct33_0.bool_20)
				{
					bool flag = false;
					double num9 = 1.0;
					try
					{
						foreach (ChaffCorridorCloud chaffCorridorCloud in base.method_18().scenario_0.ChaffClouds)
						{
							if (!this.struct32_0.bool_10 || (unit_0.vmethod_14(false) <= (float)chaffCorridorCloud.method_59() && unit_0.vmethod_14(false) >= (float)chaffCorridorCloud.method_60()))
							{
								Geopoint_Struct[] geopoint_Struct_ = Math2.smethod_24(chaffCorridorCloud.vmethod_30(null), chaffCorridorCloud.vmethod_28(null), (float)chaffCorridorCloud.method_57(), (float)chaffCorridorCloud.method_58(), chaffCorridorCloud.vmethod_9());
								if (unit_0.method_45(geopoint_Struct_, base.method_18().scenario_0, false))
								{
									flag = true;
									break;
								}
							}
						}
					}
					finally
					{
						List<ChaffCorridorCloud>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					if (flag)
					{
						Sensor.RadioElectronicFrequency[] array5 = null;
						if (enum116_0 != Sensor.Enum116.const_0)
						{
							if (enum116_0 == Sensor.Enum116.const_1)
							{
								array5 = this.radioElectronicFrequency_1;
							}
						}
						else
						{
							array5 = this.radioElectronicFrequency_0;
						}
						Sensor.RadioElectronicFrequency[] array6 = array5;
						int k = 0;
						while (k < array6.Length)
						{
							Sensor.FrequencyBand frequencyBand_ = array6[k].frequencyBand_0;
							long num10 = frequencyBand_ - Sensor.FrequencyBand.const_0;
							if (num10 > 11L)
							{
								goto IL_B96;
							}
							switch ((uint)num10)
							{
							case 0U:
							case 1U:
							case 2U:
								num9 = Math.Min(0.05, num9);
								goto IL_BF8;
							case 3U:
							case 4U:
							case 5U:
								num9 = Math.Min(0.1, num9);
								goto IL_BF8;
							case 6U:
							case 7U:
							case 8U:
								num9 = Math.Min(0.15, num9);
								goto IL_BF8;
							case 9U:
							case 10U:
							case 11U:
								num9 = Math.Min(0.2, num9);
								goto IL_BF8;
							}
							goto IL_B96;
							IL_BF8:
							checked
							{
								k++;
								continue;
								IL_B96:
								num9 = Math.Min(0.25, num9);
								goto IL_BF8;
							}
						}
						GlobalVariables.TechGenerationClass techGenerationClass = this.techGenerationClass_0;
						if (techGenerationClass < GlobalVariables.TechGenerationClass.Late1950s)
						{
							num9 *= 0.1;
						}
						else if (techGenerationClass == GlobalVariables.TechGenerationClass.Early1960s)
						{
							num9 *= 0.15;
						}
						else if (techGenerationClass < GlobalVariables.TechGenerationClass.Late1960s)
						{
							num9 *= 0.2;
						}
						else if (techGenerationClass < GlobalVariables.TechGenerationClass.Early1970s)
						{
							num9 *= 0.3;
						}
						else if (techGenerationClass < GlobalVariables.TechGenerationClass.Late1970s)
						{
							num9 *= 0.4;
						}
						else if (techGenerationClass == GlobalVariables.TechGenerationClass.Early1980s)
						{
							num9 *= 0.5;
						}
						else if (techGenerationClass == GlobalVariables.TechGenerationClass.Late1980s)
						{
							num9 *= 0.6;
						}
						else if (techGenerationClass == GlobalVariables.TechGenerationClass.Early1990s)
						{
							num9 *= 0.7;
						}
						else if (techGenerationClass == GlobalVariables.TechGenerationClass.Early1990s)
						{
							num9 *= 0.8;
						}
						else if (techGenerationClass == GlobalVariables.TechGenerationClass.Late1990s)
						{
							num9 *= 0.9;
						}
						num9 = Math.Min(1.0, num9);
						@class.method_1(@class.method_0() * num9);
					}
				}
				float num11;
				if (!unit_0.bool_6 && !unit_0.bool_5 && (!unit_0.bool_3 || unit_0.method_15()))
				{
					num11 = 0f;
				}
				else
				{
					num11 = 1f - Terrain.smethod_9(unit_0.vmethod_30(null), unit_0.vmethod_28(null), 2f);
				}
				float num12 = Terrain.smethod_8(unit_0.vmethod_30(null), unit_0.vmethod_28(null), false);
				Class563.Enum147 terrainType;
				if (Terrain.smethod_7(unit_0.vmethod_30(null), unit_0.vmethod_28(null), false) <= 0)
				{
					terrainType = Class563.Enum147.const_8;
				}
				else
				{
					float num13 = num12;
					if (num13 < 0.1f)
					{
						terrainType = Class563.Enum147.const_8;
					}
					else if (num13 < 0.2f)
					{
						terrainType = Class563.Enum147.const_4;
					}
					else if (num13 < 0.3f)
					{
						terrainType = Class563.Enum147.const_3;
					}
					else if (num13 < 0.4f)
					{
						terrainType = Class563.Enum147.const_2;
					}
					else
					{
						terrainType = Class563.Enum147.const_1;
					}
				}
				Class563.Class565 radar = this.class565_0;
				Class563.Class567 target = @class;
				int numJammers = count;
				Class563.Class566[] jammers = array2;
				double distanceToTarget = (double)float_38;
				double[] distancesToJammers = array3;
				double[] azimouthsToJammers = array4;
				Weather.WeatherProfile env = weatherProfile_0;
				float fractionOverWater = num11;
				GlobalVariables.TechGenerationClass sensorTechGeneration = this.techGenerationClass_0;
				double chaffDensity = 0.0;
				double chaffCloudThickness = 0.0;
				Class563.Class565 class3 = null;
				result = Class563.smethod_0(radar, target, numJammers, jammers, distanceToTarget, distancesToJammers, azimouthsToJammers, env, fractionOverWater, sensorTechGeneration, chaffDensity, chaffCloudThickness, ref class3, 0.0, terrainType, (double)num12);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100743", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x001A0D94 File Offset: 0x0019EF94
		public static Sensor smethod_5(SQLiteConnection sqliteConnection_0)
		{
			Sensor result;
			try
			{
				Sensor sensor = new Sensor(ref sqliteConnection_0, 0, "Mk1 Eyeball", Sensor.Sensor_Type.Visual, Sensor.Sensor_Role.AirSurfaceSearch_3D_SR, GlobalVariables.TechGenerationClass.NotApplicable, 50f, 0f, 180, 180, 10, 0, 0f, 0f, 0f, 0f, 0, 0f, 0f, 0f, true, 0, 0, 0, 0, 0f, 0L, 0L, 0L, 0L, 0f, 0f, 0f, 0f, 0f, 0f, 0, 0, 0f, 0f, 0f, 0f, false);
				sensor.bool_14 = true;
				sensor.struct32_0.bool_0 = true;
				sensor.struct32_0.bool_1 = true;
				sensor.struct32_0.bool_3 = true;
				sensor.struct32_0.bool_4 = true;
				sensor.struct32_0.bool_5 = true;
				sensor.struct32_0.bool_10 = true;
				sensor.struct32_0.bool_9 = true;
				sensor.struct32_0.bool_8 = true;
				sensor.struct33_0.bool_6 = true;
				sensor.struct33_0.bool_0 = true;
				sensor.struct33_0.bool_1 = true;
				sensor.radioElectronicFrequency_0 = new Sensor.RadioElectronicFrequency[1];
				sensor.radioElectronicFrequency_0[0] = new Sensor.RadioElectronicFrequency(Sensor.FrequencyBand.const_13);
				sensor.method_48(1);
				sensor.float_8 = 0f;
				sensor.float_6 = 0f;
				sensor.float_33 = 1f;
				sensor.float_34 = 1f;
				result = sensor;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100745", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Sensor();
			}
			return result;
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x001A0F9C File Offset: 0x0019F19C
		public override void vmethod_9(float float_37)
		{
			if (this.sensor_Type_0 != Sensor.Sensor_Type.Visual && this.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed)
			{
				float num;
				if (float_37 < 0.1f)
				{
					num = 0.05f;
				}
				else if (float_37 < 0.25f)
				{
					num = 0.15f;
				}
				else if (float_37 < 0.5f)
				{
					num = 0.3f;
				}
				else if (float_37 < 0.75f)
				{
					num = 0.5f;
				}
				else
				{
					num = 0.75f;
				}
				GlobalVariables.TechGenerationClass techGenerationClass = this.techGenerationClass_0;
				if (techGenerationClass < GlobalVariables.TechGenerationClass.Early1960s)
				{
					num = (float)((double)num - 0.3);
				}
				else if (techGenerationClass < GlobalVariables.TechGenerationClass.Late1970s)
				{
					num = (float)((double)num + 0.1);
				}
				else if (techGenerationClass < GlobalVariables.TechGenerationClass.Late1980s)
				{
					num = (float)((double)num + 0.3);
				}
				else if (techGenerationClass < GlobalVariables.TechGenerationClass.Late1980s)
				{
					num = (float)((double)num + 0.4);
				}
				else
				{
					num = (float)((double)num + 0.5);
				}
				if (!this.method_64())
				{
					num /= 3f;
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
						base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(this.Name) + " has been destroyed!", base.method_18().Name + " lost a sensor", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
						return;
					}
				}
				else
				{
					if (num6 < (double)num4)
					{
						if (!base.method_18().bool_2)
						{
							base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(this.Name) + " has suffered heavy damage.", base.method_18().Name + " had a sensor damaged", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
						}
						this.vmethod_8(PlatformComponent._DamageSeverityFactor.Heavy);
						return;
					}
					if (num6 < (double)num3)
					{
						if (!base.method_18().bool_2)
						{
							base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(this.Name) + " has suffered moderate damage.", base.method_18().Name + " had a sensor damaged", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
						}
						this.vmethod_8(PlatformComponent._DamageSeverityFactor.Medium);
						return;
					}
					if (num6 < (double)num2)
					{
						if (!base.method_18().bool_2)
						{
							base.method_18().scenario_0.method_59(Misc.smethod_9(base.method_18().Name) + " damage report: " + Misc.smethod_9(this.Name) + " has suffered light damage.", base.method_18().Name + " had a sensor damaged", LoggedMessage.MessageType.UnitDamage, 5, base.method_18().string_0, base.method_18().vmethod_7(false), new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
						}
						this.vmethod_8(PlatformComponent._DamageSeverityFactor.Light);
					}
				}
			}
		}

		// Token: 0x0400124D RID: 4685
		public float float_0;

		// Token: 0x0400124E RID: 4686
		public float float_1;

		// Token: 0x0400124F RID: 4687
		public Sensor.Sensor_Type sensor_Type_0;

		// Token: 0x04001250 RID: 4688
		public Sensor.Sensor_Role sensor_Role_0;

		// Token: 0x04001251 RID: 4689
		public string string_2;

		// Token: 0x04001252 RID: 4690
		public int int_0;

		// Token: 0x04001253 RID: 4691
		public float float_2;

		// Token: 0x04001254 RID: 4692
		public float float_3;

		// Token: 0x04001255 RID: 4693
		public float float_4;

		// Token: 0x04001256 RID: 4694
		public float float_5;

		// Token: 0x04001257 RID: 4695
		public float float_6;

		// Token: 0x04001258 RID: 4696
		public float float_7;

		// Token: 0x04001259 RID: 4697
		public float float_8;

		// Token: 0x0400125A RID: 4698
		private int int_1;

		// Token: 0x0400125B RID: 4699
		public int int_2;

		// Token: 0x0400125C RID: 4700
		public int int_3;

		// Token: 0x0400125D RID: 4701
		public Sensor.Struct32 struct32_0;

		// Token: 0x0400125E RID: 4702
		public Sensor.Struct33 struct33_0;

		// Token: 0x0400125F RID: 4703
		public Sensor.RadioElectronicFrequency[] radioElectronicFrequency_0;

		// Token: 0x04001260 RID: 4704
		public Sensor.RadioElectronicFrequency[] radioElectronicFrequency_1;

		// Token: 0x04001261 RID: 4705
		private List<Contact> list_0;

		// Token: 0x04001262 RID: 4706
		public List<Weapon> list_1;

		// Token: 0x04001263 RID: 4707
		private List<string> list_2;

		// Token: 0x04001264 RID: 4708
		private bool bool_11;

		// Token: 0x04001265 RID: 4709
		private bool? nullable_0;

		// Token: 0x04001266 RID: 4710
		public PlatformComponent.Class295 class295_1;

		// Token: 0x04001267 RID: 4711
		public GlobalVariables.TechGenerationClass techGenerationClass_0;

		// Token: 0x04001268 RID: 4712
		private Class563.Class565 class565_0;

		// Token: 0x04001269 RID: 4713
		private Class563.Struct54 struct54_0;

		// Token: 0x0400126A RID: 4714
		public bool bool_12;

		// Token: 0x0400126B RID: 4715
		internal short short_0;

		// Token: 0x0400126C RID: 4716
		private short short_1;

		// Token: 0x0400126D RID: 4717
		private short short_2;

		// Token: 0x0400126E RID: 4718
		private short short_3;

		// Token: 0x0400126F RID: 4719
		private float float_9;

		// Token: 0x04001270 RID: 4720
		private long long_0;

		// Token: 0x04001271 RID: 4721
		private long long_1;

		// Token: 0x04001272 RID: 4722
		private long long_2;

		// Token: 0x04001273 RID: 4723
		private long long_3;

		// Token: 0x04001274 RID: 4724
		internal float float_10;

		// Token: 0x04001275 RID: 4725
		internal float float_11;

		// Token: 0x04001276 RID: 4726
		internal float float_12;

		// Token: 0x04001277 RID: 4727
		internal float float_13;

		// Token: 0x04001278 RID: 4728
		internal float float_14;

		// Token: 0x04001279 RID: 4729
		internal float float_15;

		// Token: 0x0400127A RID: 4730
		internal float float_16;

		// Token: 0x0400127B RID: 4731
		internal float float_17;

		// Token: 0x0400127C RID: 4732
		internal float float_18;

		// Token: 0x0400127D RID: 4733
		internal float float_19;

		// Token: 0x0400127E RID: 4734
		internal float float_20;

		// Token: 0x0400127F RID: 4735
		internal float float_21;

		// Token: 0x04001280 RID: 4736
		internal float float_22;

		// Token: 0x04001281 RID: 4737
		internal float float_23;

		// Token: 0x04001282 RID: 4738
		internal float float_24;

		// Token: 0x04001283 RID: 4739
		internal float float_25;

		// Token: 0x04001284 RID: 4740
		internal float float_26;

		// Token: 0x04001285 RID: 4741
		internal float float_27;

		// Token: 0x04001286 RID: 4742
		internal short short_4;

		// Token: 0x04001287 RID: 4743
		internal float float_28;

		// Token: 0x04001288 RID: 4744
		internal float float_29;

		// Token: 0x04001289 RID: 4745
		internal float float_30;

		// Token: 0x0400128A RID: 4746
		internal float float_31;

		// Token: 0x0400128B RID: 4747
		internal float float_32;

		// Token: 0x0400128C RID: 4748
		public bool bool_13;

		// Token: 0x0400128D RID: 4749
		public short short_5;

		// Token: 0x0400128E RID: 4750
		internal short short_6;

		// Token: 0x0400128F RID: 4751
		internal float float_33;

		// Token: 0x04001290 RID: 4752
		internal float float_34;

		// Token: 0x04001291 RID: 4753
		internal float float_35;

		// Token: 0x04001292 RID: 4754
		internal float float_36;

		// Token: 0x04001293 RID: 4755
		private StringBuilder stringBuilder_0;

		// Token: 0x04001294 RID: 4756
		private bool bool_14;

		// Token: 0x04001295 RID: 4757
		private HashSet<Sensor.FrequencyBand> hashSet_0;

		// Token: 0x020002E9 RID: 745
		internal struct Struct32
		{
			// Token: 0x04001296 RID: 4758
			public bool bool_0;

			// Token: 0x04001297 RID: 4759
			public bool bool_1;

			// Token: 0x04001298 RID: 4760
			public bool bool_2;

			// Token: 0x04001299 RID: 4761
			public bool bool_3;

			// Token: 0x0400129A RID: 4762
			public bool bool_4;

			// Token: 0x0400129B RID: 4763
			public bool bool_5;

			// Token: 0x0400129C RID: 4764
			public bool bool_6;

			// Token: 0x0400129D RID: 4765
			public bool bool_7;

			// Token: 0x0400129E RID: 4766
			public bool bool_8;

			// Token: 0x0400129F RID: 4767
			public bool bool_9;

			// Token: 0x040012A0 RID: 4768
			public bool bool_10;

			// Token: 0x040012A1 RID: 4769
			public bool bool_11;

			// Token: 0x040012A2 RID: 4770
			public bool bool_12;

			// Token: 0x040012A3 RID: 4771
			public bool bool_13;

			// Token: 0x040012A4 RID: 4772
			public bool bool_14;

			// Token: 0x040012A5 RID: 4773
			public bool bool_15;

			// Token: 0x040012A6 RID: 4774
			public bool bool_16;

			// Token: 0x040012A7 RID: 4775
			public bool bool_17;

			// Token: 0x040012A8 RID: 4776
			public bool bool_18;

			// Token: 0x040012A9 RID: 4777
			public bool bool_19;

			// Token: 0x040012AA RID: 4778
			public bool bool_20;
		}

		// Token: 0x020002EA RID: 746
		internal struct Struct33
		{
			// Token: 0x040012AB RID: 4779
			public bool bool_0;

			// Token: 0x040012AC RID: 4780
			public bool bool_1;

			// Token: 0x040012AD RID: 4781
			public bool bool_2;

			// Token: 0x040012AE RID: 4782
			public bool bool_3;

			// Token: 0x040012AF RID: 4783
			public bool bool_4;

			// Token: 0x040012B0 RID: 4784
			public bool bool_5;

			// Token: 0x040012B1 RID: 4785
			public bool bool_6;

			// Token: 0x040012B2 RID: 4786
			public bool bool_7;

			// Token: 0x040012B3 RID: 4787
			public bool bool_8;

			// Token: 0x040012B4 RID: 4788
			public bool bool_9;

			// Token: 0x040012B5 RID: 4789
			public bool bool_10;

			// Token: 0x040012B6 RID: 4790
			public bool bool_11;

			// Token: 0x040012B7 RID: 4791
			public bool bool_12;

			// Token: 0x040012B8 RID: 4792
			public bool bool_13;

			// Token: 0x040012B9 RID: 4793
			public bool bool_14;

			// Token: 0x040012BA RID: 4794
			public bool bool_15;

			// Token: 0x040012BB RID: 4795
			public bool bool_16;

			// Token: 0x040012BC RID: 4796
			public bool bool_17;

			// Token: 0x040012BD RID: 4797
			public bool bool_18;

			// Token: 0x040012BE RID: 4798
			public bool bool_19;

			// Token: 0x040012BF RID: 4799
			public bool bool_20;

			// Token: 0x040012C0 RID: 4800
			public bool bool_21;

			// Token: 0x040012C1 RID: 4801
			public bool bool_22;

			// Token: 0x040012C2 RID: 4802
			public bool bool_23;

			// Token: 0x040012C3 RID: 4803
			public bool bool_24;

			// Token: 0x040012C4 RID: 4804
			public bool bool_25;
		}

		// Token: 0x020002EB RID: 747
		public enum FrequencyBand : long
		{
			// Token: 0x040012C6 RID: 4806
			const_0 = 1001L,
			// Token: 0x040012C7 RID: 4807
			const_1,
			// Token: 0x040012C8 RID: 4808
			const_2,
			// Token: 0x040012C9 RID: 4809
			const_3,
			// Token: 0x040012CA RID: 4810
			const_4,
			// Token: 0x040012CB RID: 4811
			const_5,
			// Token: 0x040012CC RID: 4812
			const_6,
			// Token: 0x040012CD RID: 4813
			const_7,
			// Token: 0x040012CE RID: 4814
			const_8,
			// Token: 0x040012CF RID: 4815
			const_9,
			// Token: 0x040012D0 RID: 4816
			const_10,
			// Token: 0x040012D1 RID: 4817
			const_11,
			// Token: 0x040012D2 RID: 4818
			const_12,
			// Token: 0x040012D3 RID: 4819
			const_13 = 2001L,
			// Token: 0x040012D4 RID: 4820
			const_14,
			// Token: 0x040012D5 RID: 4821
			const_15,
			// Token: 0x040012D6 RID: 4822
			const_16,
			// Token: 0x040012D7 RID: 4823
			const_17 = 3001L,
			// Token: 0x040012D8 RID: 4824
			const_18,
			// Token: 0x040012D9 RID: 4825
			const_19,
			// Token: 0x040012DA RID: 4826
			const_20,
			// Token: 0x040012DB RID: 4827
			const_21,
			// Token: 0x040012DC RID: 4828
			const_22,
			// Token: 0x040012DD RID: 4829
			const_23,
			// Token: 0x040012DE RID: 4830
			const_24,
			// Token: 0x040012DF RID: 4831
			const_25,
			// Token: 0x040012E0 RID: 4832
			const_26,
			// Token: 0x040012E1 RID: 4833
			const_27,
			// Token: 0x040012E2 RID: 4834
			const_28 = 4001L,
			// Token: 0x040012E3 RID: 4835
			const_29,
			// Token: 0x040012E4 RID: 4836
			const_30,
			// Token: 0x040012E5 RID: 4837
			const_31
		}

		// Token: 0x020002EC RID: 748
		public enum Sensor_Type : short
		{
			// Token: 0x040012E7 RID: 4839
			None = 1001,
			// Token: 0x040012E8 RID: 4840
			Radar = 2001,
			// Token: 0x040012E9 RID: 4841
			SemiActive,
			// Token: 0x040012EA RID: 4842
			Visual,
			// Token: 0x040012EB RID: 4843
			Infrared,
			// Token: 0x040012EC RID: 4844
			TVM,
			// Token: 0x040012ED RID: 4845
			ESM = 3001,
			// Token: 0x040012EE RID: 4846
			ECM,
			// Token: 0x040012EF RID: 4847
			LaserDesignator = 4001,
			// Token: 0x040012F0 RID: 4848
			LaserSpotTracker,
			// Token: 0x040012F1 RID: 4849
			LaserRangefinder,
			// Token: 0x040012F2 RID: 4850
			HullSonar_PassiveOnly = 5001,
			// Token: 0x040012F3 RID: 4851
			HullSonar_ActivePassive,
			// Token: 0x040012F4 RID: 4852
			HullSonar_ActiveOnly,
			// Token: 0x040012F5 RID: 4853
			TowedArray_PassiveOnly = 5011,
			// Token: 0x040012F6 RID: 4854
			TowedArray_ActivePassive,
			// Token: 0x040012F7 RID: 4855
			TowedArray_ActiveOnly,
			// Token: 0x040012F8 RID: 4856
			VDS_PassiveOnly = 5021,
			// Token: 0x040012F9 RID: 4857
			VDS_ActivePassive,
			// Token: 0x040012FA RID: 4858
			VDS_ActiveOnly,
			// Token: 0x040012FB RID: 4859
			DippingSonar_PassiveOnly = 5031,
			// Token: 0x040012FC RID: 4860
			DippingSonar_ActivePassive,
			// Token: 0x040012FD RID: 4861
			DippingSonar_ActiveOnly,
			// Token: 0x040012FE RID: 4862
			BottomFixedSonar_PassiveOnly = 5041,
			// Token: 0x040012FF RID: 4863
			MAD = 5101,
			// Token: 0x04001300 RID: 4864
			PingIntercept = 5901,
			// Token: 0x04001301 RID: 4865
			MineSweep_MechanicalCableCutter = 6001,
			// Token: 0x04001302 RID: 4866
			MineSweep_MagneticInfluence,
			// Token: 0x04001303 RID: 4867
			MineSweep_AcousticInfluence,
			// Token: 0x04001304 RID: 4868
			MineSweep_MultiInfluence,
			// Token: 0x04001305 RID: 4869
			MineSweep_TwoShipMagneticInfluence = 6011,
			// Token: 0x04001306 RID: 4870
			MineNeutralization_MooredMineCableCutter = 6021,
			// Token: 0x04001307 RID: 4871
			MineNeutralization_ExplosiveChargeMineDisposal,
			// Token: 0x04001308 RID: 4872
			MineNeutralization_DiverExplosiveCharge = 6031,
			// Token: 0x04001309 RID: 4873
			SensorGroup = 9001
		}

		// Token: 0x020002ED RID: 749
		public enum Sensor_Role : long
		{
			// Token: 0x0400130B RID: 4875
			None = 1001L,
			// Token: 0x0400130C RID: 4876
			AirSearch_2D_LR = 2001L,
			// Token: 0x0400130D RID: 4877
			AirSeach_3D_LR,
			// Token: 0x0400130E RID: 4878
			AirSeach_2D_MR,
			// Token: 0x0400130F RID: 4879
			AirSeach_3D_MR,
			// Token: 0x04001310 RID: 4880
			AirSeach_2D_SR,
			// Token: 0x04001311 RID: 4881
			AirSeach_3D_SR,
			// Token: 0x04001312 RID: 4882
			AirSurfaceSearch_2D_LR = 2011L,
			// Token: 0x04001313 RID: 4883
			AirSurfaceSearch_3D_LR,
			// Token: 0x04001314 RID: 4884
			AirSurfaceSearch_2D_MR,
			// Token: 0x04001315 RID: 4885
			AirSurfaceSearch_3D_MR,
			// Token: 0x04001316 RID: 4886
			AirSurfaceSearch_2D_SR,
			// Token: 0x04001317 RID: 4887
			AirSurfaceSearch_3D_SR,
			// Token: 0x04001318 RID: 4888
			HeightFinder_LR,
			// Token: 0x04001319 RID: 4889
			HeightFinder_MR,
			// Token: 0x0400131A RID: 4890
			HeightFinder_SR,
			// Token: 0x0400131B RID: 4891
			SurfaceSearch_LR = 2021L,
			// Token: 0x0400131C RID: 4892
			SurfaceSearch_MR,
			// Token: 0x0400131D RID: 4893
			SurfaceSearch_SR,
			// Token: 0x0400131E RID: 4894
			SurfaceSearch_OTH = 2027L,
			// Token: 0x0400131F RID: 4895
			SurfaceSearch_Navigation,
			// Token: 0x04001320 RID: 4896
			NavigationOnly = 2031L,
			// Token: 0x04001321 RID: 4897
			GroundMappingOnly,
			// Token: 0x04001322 RID: 4898
			TerrainAvoidanceFollowingOnly,
			// Token: 0x04001323 RID: 4899
			WeatherOnly,
			// Token: 0x04001324 RID: 4900
			WeatherNavigationOnly,
			// Token: 0x04001325 RID: 4901
			TargetIndicator_SurfToAir_2D = 2101L,
			// Token: 0x04001326 RID: 4902
			TargetIndicator_SurfToAir_3D,
			// Token: 0x04001327 RID: 4903
			TargetIndicator_SurfToAirSurfToSurf_2D,
			// Token: 0x04001328 RID: 4904
			TargetIndicator_SurfToAirSurfToSurf_3D,
			// Token: 0x04001329 RID: 4905
			TargetIndicator_SurfToSurf,
			// Token: 0x0400132A RID: 4906
			CounterBattery = 2109L,
			// Token: 0x0400132B RID: 4907
			FCR_AirToAir_LR = 2111L,
			// Token: 0x0400132C RID: 4908
			FCR_AirToAir_MR,
			// Token: 0x0400132D RID: 4909
			FCR_AirToAir_SR,
			// Token: 0x0400132E RID: 4910
			FCR_AirToAir_AirToSurf_LR = 2121L,
			// Token: 0x0400132F RID: 4911
			FCR_AirToAir_AirToSurf_MR,
			// Token: 0x04001330 RID: 4912
			FCR_AirToAir_AirToSurf_SR,
			// Token: 0x04001331 RID: 4913
			FCR_AirToSurf_LR,
			// Token: 0x04001332 RID: 4914
			FCR_AirToSurf_MR,
			// Token: 0x04001333 RID: 4915
			FCR_AirToSurf_SR,
			// Token: 0x04001334 RID: 4916
			FCR_SurfToAir_LR = 2131L,
			// Token: 0x04001335 RID: 4917
			FCR_SurfToAir_MR,
			// Token: 0x04001336 RID: 4918
			FCR_SurfToAir_SR,
			// Token: 0x04001337 RID: 4919
			FCR_SurfToAir_SurfToSurf_LR = 2141L,
			// Token: 0x04001338 RID: 4920
			FCR_SurfToAir_SurfToSurf_MR,
			// Token: 0x04001339 RID: 4921
			FCR_SurfToAir_SurfToSurf_SR,
			// Token: 0x0400133A RID: 4922
			FCR_SurfToSurf = 2151L,
			// Token: 0x0400133B RID: 4923
			FCR_SurfToSurf_OTH,
			// Token: 0x0400133C RID: 4924
			FCR_SurfToSurf_Torpedo = 2161L,
			// Token: 0x0400133D RID: 4925
			FCR_GunOnly = 2191L,
			// Token: 0x0400133E RID: 4926
			Illuminator_SAM_LR = 2201L,
			// Token: 0x0400133F RID: 4927
			Illuminator_SAM_MR,
			// Token: 0x04001340 RID: 4928
			Illuminator_SAM_SR,
			// Token: 0x04001341 RID: 4929
			ActiveMissileSeeker = 2211L,
			// Token: 0x04001342 RID: 4930
			RangeOnly = 2301L,
			// Token: 0x04001343 RID: 4931
			Land_ATC = 2311L,
			// Token: 0x04001344 RID: 4932
			Shipboard_ATC,
			// Token: 0x04001345 RID: 4933
			BMEWS = 2401L,
			// Token: 0x04001346 RID: 4934
			Radar_BallisticMissileBattleManagement,
			// Token: 0x04001347 RID: 4935
			Radar_BallisticMissileTracker,
			// Token: 0x04001348 RID: 4936
			Radar_BallisticMissileEngagement,
			// Token: 0x04001349 RID: 4937
			LLTV_MineRecon = 2791L,
			// Token: 0x0400134A RID: 4938
			IR_MAWS = 2891L,
			// Token: 0x0400134B RID: 4939
			ESM_RWR = 3001L,
			// Token: 0x0400134C RID: 4940
			ESM_LWR,
			// Token: 0x0400134D RID: 4941
			ESM_ELINT = 3011L,
			// Token: 0x0400134E RID: 4942
			ESM_ELINT_OTHT,
			// Token: 0x0400134F RID: 4943
			ESM_COMINT = 3021L,
			// Token: 0x04001350 RID: 4944
			ESM_SIGINT = 3031L,
			// Token: 0x04001351 RID: 4945
			ESM_SIGINT_OTHT,
			// Token: 0x04001352 RID: 4946
			ESM_MASINT = 3041L,
			// Token: 0x04001353 RID: 4947
			ESM_HFDF = 3101L,
			// Token: 0x04001354 RID: 4948
			ESM_HFDF_OTHT,
			// Token: 0x04001355 RID: 4949
			ESM_ELS = 3201L,
			// Token: 0x04001356 RID: 4950
			ESM_PassiveMissileSeeker = 3211L,
			// Token: 0x04001357 RID: 4951
			ECM_OECM = 4001L,
			// Token: 0x04001358 RID: 4952
			ECM_DECM = 4011L,
			// Token: 0x04001359 RID: 4953
			ECM_OECM_DECM = 4021L,
			// Token: 0x0400135A RID: 4954
			ECM_Repeater = 4031L,
			// Token: 0x0400135B RID: 4955
			IRCM = 4041L,
			// Token: 0x0400135C RID: 4956
			ECM_COMINT_Jammer = 4091L,
			// Token: 0x0400135D RID: 4957
			ECM_AcousticJammer = 4901L,
			// Token: 0x0400135E RID: 4958
			ECM_AcousticRepeater,
			// Token: 0x0400135F RID: 4959
			HullSonarPassiveOnlySearch = 5001L,
			// Token: 0x04001360 RID: 4960
			HullSonarPassiveOnlySearchTrack,
			// Token: 0x04001361 RID: 4961
			HullSonarPassiveOnlyRangingFlankArraySearchTrack = 5011L,
			// Token: 0x04001362 RID: 4962
			HullSonarPassiveOnlyTorpedoWarning = 5021L,
			// Token: 0x04001363 RID: 4963
			HullSonarActivePassiveSearch = 5031L,
			// Token: 0x04001364 RID: 4964
			HullSonarActivePassiveSearchTrack,
			// Token: 0x04001365 RID: 4965
			HullSonarActivePassiveSearchAttack,
			// Token: 0x04001366 RID: 4966
			HullSonarActivePassiveSearchMortarFireControl,
			// Token: 0x04001367 RID: 4967
			HullSonarActivePassiveAttack = 5041L,
			// Token: 0x04001368 RID: 4968
			HullSonarActiveOnlySearch = 5061L,
			// Token: 0x04001369 RID: 4969
			HullSonarActiveOnlySearchTrack,
			// Token: 0x0400136A RID: 4970
			HullSonarActiveOnlySearchAttack,
			// Token: 0x0400136B RID: 4971
			HullSonarActiveOnlySearchMortarFireControl,
			// Token: 0x0400136C RID: 4972
			HullSonarActiveOnlyAttack = 5071L,
			// Token: 0x0400136D RID: 4973
			HullSonarActiveOnlyMortarFireControl,
			// Token: 0x0400136E RID: 4974
			HullSonarActiveOnlyBottomProfiler = 5081L,
			// Token: 0x0400136F RID: 4975
			HullSonarActiveOnlyShortRangeSidescanMapping,
			// Token: 0x04001370 RID: 4976
			HullSonarActiveOnlyShortRangeSidescanMappingHighDefinitionLPI,
			// Token: 0x04001371 RID: 4977
			HullSonarActiveOnlyMineAvoidance = 5091L,
			// Token: 0x04001372 RID: 4978
			HullSonarActiveOnlyMineObstacleAvoidance,
			// Token: 0x04001373 RID: 4979
			HullSonarActiveOnlyShallowWaterMineObstacleAvoidance,
			// Token: 0x04001374 RID: 4980
			HullSonarActiveOnlyShallowWaterHighDefinitionMineObstacleAvoidance,
			// Token: 0x04001375 RID: 4981
			HullSonarActiveOnlyUnderIceNavigationandMineObstacleAvoidance,
			// Token: 0x04001376 RID: 4982
			HullSonarActiveOnlyAntiCollisionNavigation,
			// Token: 0x04001377 RID: 4983
			HullSonarActiveOnlyMineReconnaissance,
			// Token: 0x04001378 RID: 4984
			HullSonarActiveOnlyMineHunting,
			// Token: 0x04001379 RID: 4985
			HullSonarActiveOnlyMineHuntingASWMortarFireControl,
			// Token: 0x0400137A RID: 4986
			TASSPassiveOnlyTowedArraySonarSystem = 5101L,
			// Token: 0x0400137B RID: 4987
			TASSPassiveOnlyFatLineTowedArraySonarSystem,
			// Token: 0x0400137C RID: 4988
			TASSPassiveOnlyThinLineTowedArraySonarSystem,
			// Token: 0x0400137D RID: 4989
			TASSPassiveOnlyAreaSurveillanceTowedArraySonarSystem,
			// Token: 0x0400137E RID: 4990
			TASSPassiveTorpedoWarningTowedArraySonarSystem = 5111L,
			// Token: 0x0400137F RID: 4991
			TASSActivePassiveTowedArraySonarSystem = 5131L,
			// Token: 0x04001380 RID: 4992
			TASSActivePassiveAreaSurveillanceTowedArraySonarSystem,
			// Token: 0x04001381 RID: 4993
			TASSActiveOnlyTowedArraySonarSystem = 5161L,
			// Token: 0x04001382 RID: 4994
			SURTASSPassiveOnlySurveillanceTowedArraySonarSystem = 5191L,
			// Token: 0x04001383 RID: 4995
			SURTASSActivePassiveSurveillanceTowedArraySonarSystem,
			// Token: 0x04001384 RID: 4996
			SURTASSActiveOnlySurveillanceTowedArraySonarSystem,
			// Token: 0x04001385 RID: 4997
			VDSPassiveOnlyVariableDepthSonar = 5201L,
			// Token: 0x04001386 RID: 4998
			VDSActivePassiveVariableDepthSonar = 5231L,
			// Token: 0x04001387 RID: 4999
			VDSActiveOnlyVariableDepthSonar = 5261L,
			// Token: 0x04001388 RID: 5000
			VDSActiveOnlyMineReconnaissanceVariableDepthSonar = 5271L,
			// Token: 0x04001389 RID: 5001
			VDSActiveOnlyMineHuntingVariableDepthSonar,
			// Token: 0x0400138A RID: 5002
			VDSActiveOnlySidescanMineHuntingVariableDepthSonar,
			// Token: 0x0400138B RID: 5003
			VDSPropelledActiveOnlyMineHuntingVariableDepthSonar,
			// Token: 0x0400138C RID: 5004
			DippingSonarPassiveOnlySearchTrack = 5301L,
			// Token: 0x0400138D RID: 5005
			DippingSonarActivePassiveSearchTrack = 5331L,
			// Token: 0x0400138E RID: 5006
			DippingSonarActivePassiveShallowWaterSearchTrack,
			// Token: 0x0400138F RID: 5007
			DippingSonarActiveOnlySearchTrack = 5361L,
			// Token: 0x04001390 RID: 5008
			HelicopterTowedActiveOnlyMineReconnaissanceSonar = 5391L,
			// Token: 0x04001391 RID: 5009
			SOSUSPassiveSoundSurveillanceSystems = 5401L,
			// Token: 0x04001392 RID: 5010
			MooredSonobuoyPassiveSearch,
			// Token: 0x04001393 RID: 5011
			SonobuoyPassiveOnlyNonDirectional = 5501L,
			// Token: 0x04001394 RID: 5012
			SonobuoyPassiveOnlyDirectional,
			// Token: 0x04001395 RID: 5013
			SonobuoyPassiveOnlyDirectionalFrequencyAnalysisandRecording_DIFAR = 5507L,
			// Token: 0x04001396 RID: 5014
			SonobuoyPassiveOnlyDirectionalLowFrequencyAnalysisandRanging_LOFAR,
			// Token: 0x04001397 RID: 5015
			SonobuoyPassiveOnlyDirectionalVerticalLineArrayDIFAR_VLAD,
			// Token: 0x04001398 RID: 5016
			SonobuoyActivePassiveRangeOnlyOmniDirectional = 5511L,
			// Token: 0x04001399 RID: 5017
			SonobuoyActivePassiveRangeDirectional,
			// Token: 0x0400139A RID: 5018
			SonobuoyActiveOnlyRangeOnlyNonDirectional = 5521L,
			// Token: 0x0400139B RID: 5019
			SonobuoyActiveOnlyRangeOnlyNonDirectionalContinousPing,
			// Token: 0x0400139C RID: 5020
			SonobuoyActiveOnlyRangeOnlyNonDirectionalCommandActivatedSonobuoySystem_CASS,
			// Token: 0x0400139D RID: 5021
			SonobuoyActiveOnlyRangeDirectional = 5527L,
			// Token: 0x0400139E RID: 5022
			SonobuoyActiveOnlyRangeDirectionalCommandActivatedSonobuoySystem_DICASS,
			// Token: 0x0400139F RID: 5023
			SonobuoyActiveOnlyRangeDirectionalExtendedEchoRanging_EER,
			// Token: 0x040013A0 RID: 5024
			TorpedoSeekerPassiveOnly = 5701L,
			// Token: 0x040013A1 RID: 5025
			TorpedoSeekerPassiveOnlyShallowWater,
			// Token: 0x040013A2 RID: 5026
			TorpedoSeekerActivePassive = 5711L,
			// Token: 0x040013A3 RID: 5027
			TorpedoSeekerActivePassiveShallowWater,
			// Token: 0x040013A4 RID: 5028
			TorpedoSeekerActivePassiveWakeHomer_WH,
			// Token: 0x040013A5 RID: 5029
			TorpedoSeekerActivePassiveShallowWaterWakeHomer_WH,
			// Token: 0x040013A6 RID: 5030
			TorpedoSeekerActiveOnly = 5721L,
			// Token: 0x040013A7 RID: 5031
			TorpedoSeekerActiveOnlyShallowWater,
			// Token: 0x040013A8 RID: 5032
			TorpedoSeekerWakeHomer = 5791L,
			// Token: 0x040013A9 RID: 5033
			MAD = 5801L,
			// Token: 0x040013AA RID: 5034
			AcousticIntercept = 5901L,
			// Token: 0x040013AB RID: 5035
			AcousticInterceptPassiveRanging,
			// Token: 0x040013AC RID: 5036
			AcousticInterceptSurveillance,
			// Token: 0x040013AD RID: 5037
			AcousticInterceptTorpedoWarning = 5911L
		}

		// Token: 0x020002EE RID: 750
		internal enum Enum114
		{
			// Token: 0x040013AF RID: 5039
			const_0,
			// Token: 0x040013B0 RID: 5040
			const_1,
			// Token: 0x040013B1 RID: 5041
			const_2,
			// Token: 0x040013B2 RID: 5042
			const_3
		}

		// Token: 0x020002EF RID: 751
		internal enum Enum115
		{
			// Token: 0x040013B4 RID: 5044
			const_0,
			// Token: 0x040013B5 RID: 5045
			const_1,
			// Token: 0x040013B6 RID: 5046
			const_2,
			// Token: 0x040013B7 RID: 5047
			const_3,
			// Token: 0x040013B8 RID: 5048
			const_4,
			// Token: 0x040013B9 RID: 5049
			const_5,
			// Token: 0x040013BA RID: 5050
			const_6,
			// Token: 0x040013BB RID: 5051
			const_7,
			// Token: 0x040013BC RID: 5052
			const_8,
			// Token: 0x040013BD RID: 5053
			const_9,
			// Token: 0x040013BE RID: 5054
			const_10,
			// Token: 0x040013BF RID: 5055
			const_11 = 9999
		}

		// Token: 0x020002F0 RID: 752
		internal enum Enum116 : byte
		{
			// Token: 0x040013C1 RID: 5057
			const_0,
			// Token: 0x040013C2 RID: 5058
			const_1
		}

		// Token: 0x020002F1 RID: 753
		public sealed class RadioElectronicFrequency
		{
			// Token: 0x06001668 RID: 5736 RVA: 0x0000BED0 File Offset: 0x0000A0D0
			public RadioElectronicFrequency(Sensor.FrequencyBand frequencyBand_1)
			{
				this.frequencyBand_0 = frequencyBand_1;
			}

			// Token: 0x06001669 RID: 5737 RVA: 0x001A140C File Offset: 0x0019F60C
			public string method_0()
			{
				Sensor.FrequencyBand frequencyBand = this.frequencyBand_0;
				if (frequencyBand <= Sensor.FrequencyBand.const_14)
				{
					long num = frequencyBand - Sensor.FrequencyBand.const_0;
					if (num <= 12L)
					{
						switch ((uint)num)
						{
						case 0U:
							return "A";
						case 1U:
							return "B";
						case 2U:
							return "C";
						case 3U:
							return "D";
						case 4U:
							return "E";
						case 5U:
							return "F";
						case 6U:
							return "G";
						case 7U:
							return "H";
						case 8U:
							return "I";
						case 9U:
							return "J";
						case 10U:
							return "K";
						case 11U:
							return "L";
						case 12U:
							return "M";
						}
					}
					if (frequencyBand == Sensor.FrequencyBand.const_14)
					{
						return "Near IR";
					}
				}
				else
				{
					if (frequencyBand != Sensor.FrequencyBand.const_15)
					{
						long num2 = frequencyBand - Sensor.FrequencyBand.const_17;
						if (num2 <= 10L)
						{
							switch ((uint)num2)
							{
							case 0U:
								return "ELF";
							case 1U:
								return "SLF";
							case 2U:
								return "ULF";
							case 3U:
								goto IL_1CC;
							case 4U:
								goto IL_1D4;
							case 5U:
								goto IL_1DC;
							case 6U:
								goto IL_1E4;
							case 7U:
								return "VHF";
							case 8U:
								return "UHF";
							case 9U:
								return "SHF";
							case 10U:
								return "EHF";
							}
						}
						long num3 = frequencyBand - Sensor.FrequencyBand.const_28;
						if (num3 > 3L)
						{
							goto IL_1A0;
						}
						switch ((uint)num3)
						{
						case 0U:
							goto IL_1D4;
						case 1U:
							goto IL_1DC;
						case 2U:
							goto IL_1E4;
						case 3U:
							goto IL_1CC;
						}
						goto IL_1A0;
						IL_1CC:
						return "VLF";
						IL_1D4:
						return "LF";
						IL_1DC:
						return "MF";
						IL_1E4:
						return "HF";
					}
					return "Far IR";
				}
				IL_1A0:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				return string.Empty;
			}

			// Token: 0x0600166A RID: 5738 RVA: 0x001A162C File Offset: 0x0019F82C
			public long method_1()
			{
				Sensor.FrequencyBand frequencyBand = this.frequencyBand_0;
				long num = frequencyBand - Sensor.FrequencyBand.const_0;
				if (num <= 12L)
				{
					switch ((uint)num)
					{
					case 0U:
						return 250000000L;
					case 1U:
						return 500000000L;
					case 2U:
						return 1000000000L;
					case 3U:
						return 2000000000L;
					case 4U:
						return 3000000000L;
					case 5U:
						return 4000000000L;
					case 6U:
						return 6000000000L;
					case 7U:
						return 8000000000L;
					case 8U:
						return 10000000000L;
					case 9U:
						return 20000000000L;
					case 10U:
						return 40000000000L;
					case 11U:
						return 60000000000L;
					case 12U:
						return 100000000000L;
					}
				}
				return 0L;
			}

			// Token: 0x0600166B RID: 5739 RVA: 0x001A1744 File Offset: 0x0019F944
			public long method_2()
			{
				Sensor.FrequencyBand frequencyBand = this.frequencyBand_0;
				long num = frequencyBand - Sensor.FrequencyBand.const_0;
				if (num <= 12L)
				{
					switch ((uint)num)
					{
					case 0U:
						return 1000000L;
					case 1U:
						return 250000000L;
					case 2U:
						return 500000000L;
					case 3U:
						return 1000000000L;
					case 4U:
						return 2000000000L;
					case 5U:
						return 3000000000L;
					case 6U:
						return 4000000000L;
					case 7U:
						return 6000000000L;
					case 8U:
						return 8000000000L;
					case 9U:
						return 10000000000L;
					case 10U:
						return 20000000000L;
					case 11U:
						return 40000000000L;
					case 12U:
						return 60000000000L;
					}
				}
				return 0L;
			}

			// Token: 0x040013C3 RID: 5059
			public Sensor.FrequencyBand frequencyBand_0;
		}
	}
}
