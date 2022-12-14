using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns13;
using ns14;
using ns9;

namespace Command_Core
{
	// Token: 0x02000282 RID: 642
	public sealed class Loadout : Class310
	{
		// Token: 0x06001397 RID: 5015 RVA: 0x00176914 File Offset: 0x00174B14
		[CompilerGenerated]
		public static void smethod_0(Loadout.Delegate34 delegate34_1)
		{
			Loadout.Delegate34 @delegate = Loadout.delegate34_0;
			Loadout.Delegate34 delegate2;
			do
			{
				delegate2 = @delegate;
				Loadout.Delegate34 value = (Loadout.Delegate34)Delegate.Combine(delegate2, delegate34_1);
				@delegate = Interlocked.CompareExchange<Loadout.Delegate34>(ref Loadout.delegate34_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00176948 File Offset: 0x00174B48
		[CompilerGenerated]
		public static void smethod_1(Loadout.Delegate34 delegate34_1)
		{
			Loadout.Delegate34 @delegate = Loadout.delegate34_0;
			Loadout.Delegate34 delegate2;
			do
			{
				delegate2 = @delegate;
				Loadout.Delegate34 value = (Loadout.Delegate34)Delegate.Remove(delegate2, delegate34_1);
				@delegate = Interlocked.CompareExchange<Loadout.Delegate34>(ref Loadout.delegate34_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0017697C File Offset: 0x00174B7C
		[CompilerGenerated]
		public static void smethod_2(Loadout.Delegate35 delegate35_1)
		{
			Loadout.Delegate35 @delegate = Loadout.delegate35_0;
			Loadout.Delegate35 delegate2;
			do
			{
				delegate2 = @delegate;
				Loadout.Delegate35 value = (Loadout.Delegate35)Delegate.Combine(delegate2, delegate35_1);
				@delegate = Interlocked.CompareExchange<Loadout.Delegate35>(ref Loadout.delegate35_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x001769B0 File Offset: 0x00174BB0
		[CompilerGenerated]
		public static void smethod_3(Loadout.Delegate35 delegate35_1)
		{
			Loadout.Delegate35 @delegate = Loadout.delegate35_0;
			Loadout.Delegate35 delegate2;
			do
			{
				delegate2 = @delegate;
				Loadout.Delegate35 value = (Loadout.Delegate35)Delegate.Remove(delegate2, delegate35_1);
				@delegate = Interlocked.CompareExchange<Loadout.Delegate35>(ref Loadout.delegate35_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x001769E4 File Offset: 0x00174BE4
		public string method_8(ref HashSet<string> hashSet_0, Scenario scenario_0)
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
				this.stringBuilder_0.Append("<Loadout>");
				this.stringBuilder_0.Append("<ID>").Append(this.string_0).Append("</ID>");
				if (!Information.IsNothing(hashSet_0))
				{
					if (hashSet_0.Contains(this.string_0))
					{
						this.stringBuilder_0.Append("</Loadout>");
						return this.stringBuilder_0.ToString();
					}
					hashSet_0.Add(this.string_0);
				}
				this.stringBuilder_0.Append("<DBID>").Append(this.DBID.ToString()).Append("</DBID>");
				if (!string.IsNullOrEmpty(this.Name))
				{
					this.stringBuilder_0.Append("<Name>").Append(SecurityElement.Escape(this.Name)).Append("</Name>");
				}
				this.stringBuilder_0.Append("<ROF>").Append(this.int_0).Append("</ROF>");
				this.stringBuilder_0.Append("<MC>").Append(this.int_1).Append("</MC>");
				this.stringBuilder_0.Append("<RT>").Append(this.int_2).Append("</RT>");
				if (this.bool_11)
				{
					this.stringBuilder_0.Append("<NOW>True</NOW>");
				}
				this.stringBuilder_0.Append("<Weaps>");
				foreach (WeaponRec weaponRec in this.weaponRec_0)
				{
					this.stringBuilder_0.Append(weaponRec.method_8(hashSet_0, scenario_0));
				}
				this.stringBuilder_0.Append("</Weaps>");
				this.stringBuilder_0.Append("<Role>").Append((int)this.loadoutRole_0).Append("</Role>");
				this.stringBuilder_0.Append("<PayloadWeight>").Append(this.int_5).Append("</PayloadWeight>");
				this.stringBuilder_0.Append("<PayloadWeightDroppable>").Append(this.int_6).Append("</PayloadWeightDroppable>");
				this.stringBuilder_0.Append("<PayloadWeight_TakeOff>").Append(this.int_7).Append("</PayloadWeight_TakeOff>");
				this.stringBuilder_0.Append("<PayloadWeightDroppable_TakeOff>").Append(this.int_8).Append("</PayloadWeightDroppable_TakeOff>");
				this.stringBuilder_0.Append("<WeightDragModifier>").Append(XmlConvert.ToString(this.float_0)).Append("</WeightDragModifier>");
				this.stringBuilder_0.Append("<CombatRadius>").Append(this.int_4).Append("</CombatRadius>");
				this.stringBuilder_0.Append("<TimeOnStation_Minutes>").Append(this.short_0).Append("</TimeOnStation_Minutes>");
				if (this.bool_13)
				{
					this.stringBuilder_0.Append("<QT>True</QT>");
				}
				this.stringBuilder_0.Append("<QT_ReadyTime>").Append(this.int_9).Append("</QT_ReadyTime>");
				this.stringBuilder_0.Append("<QT_AirborneTime>").Append(this.int_12).Append("</QT_AirborneTime>");
				this.stringBuilder_0.Append("<QT_MaxSorties>").Append(this.int_10).Append("</QT_MaxSorties>");
				this.stringBuilder_0.Append("<QT_AdditionalTimePenalty>").Append(this.int_11).Append("</QT_AdditionalTimePenalty>");
				this.stringBuilder_0.Append("<QT_TimeofDay>").Append((int)this._LoadoutDayNight_1).Append("</QT_TimeofDay>");
				this.stringBuilder_0.Append("<WinchesterShotgun>").Append((int)this._WeaponState_0).Append("</WinchesterShotgun>");
				this.stringBuilder_0.Append("</Loadout>");
				result = this.stringBuilder_0.ToString();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101007", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0000AF37 File Offset: 0x00009137
		private Loadout()
		{
			this.weaponRec_0 = new WeaponRec[0];
			this.bool_11 = false;
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00176E78 File Offset: 0x00175078
		public static Loadout smethod_4(XmlNode xmlNode_0, Dictionary<string, Class310> dictionary_0, ref Aircraft aircraft_0, ref Scenario scenario_0)
		{
			Loadout result;
			try
			{
				Loadout loadout = new Loadout();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 1978145240U)
						{
							if (num <= 1456985430U)
							{
								if (num <= 583075911U)
								{
									if (num <= 166976667U)
									{
										if (num != 135860981U)
										{
											if (num != 166976667U)
											{
												continue;
											}
											if (Operators.CompareString(name, "QuickTurnaround_ReadyTime", false) != 0)
											{
												continue;
											}
										}
										else if (Operators.CompareString(name, "QT_ReadyTime", false) != 0)
										{
											continue;
										}
										loadout.int_9 = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									if (num != 266367750U)
									{
										if (num != 583075911U)
										{
											continue;
										}
										if (Operators.CompareString(name, "QuickTurnaround_TimeofDay", false) != 0)
										{
											continue;
										}
										goto IL_6FC;
									}
									else
									{
										if (Operators.CompareString(name, "Name", false) == 0)
										{
											loadout.Name = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else if (num <= 1071332996U)
								{
									if (num != 715769686U)
									{
										if (num != 1071332996U)
										{
											continue;
										}
										if (Operators.CompareString(name, "QuickTurnaround_AdditionalTimePenalty", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "QuickTurnaround_MaxSorties", false) != 0)
										{
											continue;
										}
										goto IL_49C;
									}
								}
								else if (num != 1172297281U)
								{
									if (num != 1456985430U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Weapons", false) != 0)
									{
										continue;
									}
									goto IL_647;
								}
								else
								{
									if (Operators.CompareString(name, "MC", false) != 0)
									{
										continue;
									}
									goto IL_80E;
								}
							}
							else if (num <= 1703851952U)
							{
								if (num <= 1467171417U)
								{
									if (num != 1458105184U)
									{
										if (num != 1467171417U)
										{
											continue;
										}
										if (Operators.CompareString(name, "PayloadWeight", false) == 0)
										{
											loadout.int_5 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "ID", false) != 0)
										{
											continue;
										}
										if (!dictionary_0.ContainsKey(xmlNode.InnerText))
										{
											loadout.vmethod_0(xmlNode.InnerText);
											dictionary_0.Add(loadout.string_0, loadout);
											continue;
										}
										return (Loadout)dictionary_0[xmlNode.InnerText];
									}
								}
								else if (num != 1571885256U)
								{
									if (num != 1703851952U)
									{
										continue;
									}
									if (Operators.CompareString(name, "QuickTurnaround_AirborneTime", false) != 0)
									{
										continue;
									}
									goto IL_453;
								}
								else
								{
									if (Operators.CompareString(name, "PayloadWeightDroppable", false) == 0)
									{
										loadout.int_6 = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 1822902851U)
							{
								if (num != 1761926707U)
								{
									if (num != 1822902851U)
									{
										continue;
									}
									if (Operators.CompareString(name, "PayloadWeightDroppable_TakeOff", false) == 0)
									{
										loadout.int_8 = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "RT", false) != 0)
									{
										continue;
									}
									goto IL_4C5;
								}
							}
							else if (num != 1858496319U)
							{
								if (num != 1903707726U)
								{
									if (num != 1978145240U)
									{
										continue;
									}
									if (Operators.CompareString(name, "ROF", false) == 0)
									{
										loadout.int_0 = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name, "QT_AdditionalTimePenalty", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "CombatRadius", false) == 0)
								{
									loadout.int_4 = Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							loadout.int_11 = Conversions.ToInteger(xmlNode.InnerText);
							continue;
						}
						if (num <= 2424405304U)
						{
							if (num <= 2187602126U)
							{
								if (num <= 1996268920U)
								{
									if (num != 1986789086U)
									{
										if (num != 1996268920U)
										{
											continue;
										}
										if (Operators.CompareString(name, "QT", false) != 0)
										{
											continue;
										}
										goto IL_6D3;
									}
									else
									{
										if (Operators.CompareString(name, "PayloadWeight_TakeOff", false) == 0)
										{
											loadout.int_7 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 2133995686U)
								{
									if (num != 2187602126U)
									{
										continue;
									}
									if (Operators.CompareString(name, "DBID", false) == 0)
									{
										loadout.DBID = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name, "QT_AirborneTime", false) != 0)
								{
									continue;
								}
							}
							else if (num <= 2316227376U)
							{
								if (num != 2232591701U)
								{
									if (num != 2316227376U)
									{
										continue;
									}
									if (Operators.CompareString(name, "QT_MaxSorties", false) == 0)
									{
										goto IL_49C;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "ReadyTime", false) == 0)
									{
										goto IL_4C5;
									}
									continue;
								}
							}
							else if (num != 2418769465U)
							{
								if (num != 2424405304U)
								{
									continue;
								}
								if (Operators.CompareString(name, "Sensors", false) != 0)
								{
									continue;
								}
								goto IL_7A3;
							}
							else
							{
								if (Operators.CompareString(name, "Role", false) != 0)
								{
									continue;
								}
								if (Versioned.IsNumeric(xmlNode.InnerText))
								{
									loadout.loadoutRole_0 = (Loadout.LoadoutRole)Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								loadout.loadoutRole_0 = (Loadout.LoadoutRole)Enum.Parse(typeof(Loadout.LoadoutRole), xmlNode.InnerText, true);
								continue;
							}
						}
						else
						{
							if (num > 2867742231U)
							{
								goto IL_69E;
							}
							if (num <= 2655529854U)
							{
								if (num != 2505807413U)
								{
									if (num != 2655529854U)
									{
										continue;
									}
									if (Operators.CompareString(name, "WeightDragModifier", false) == 0)
									{
										loadout.float_0 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "WinchesterShotgun", false) == 0)
									{
										loadout._WeaponState_0 = (Doctrine._WeaponState)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 2665397489U)
							{
								if (num != 2867742231U)
								{
									continue;
								}
								if (Operators.CompareString(name, "NOW", false) == 0)
								{
									loadout.bool_11 = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Weaps", false) == 0)
								{
									goto IL_647;
								}
								continue;
							}
						}
						IL_453:
						loadout.int_12 = Conversions.ToInteger(xmlNode.InnerText);
						continue;
						IL_49C:
						loadout.int_10 = Conversions.ToInteger(xmlNode.InnerText);
						continue;
						IL_4C5:
						loadout.int_2 = Conversions.ToInteger(xmlNode.InnerText);
						continue;
						IL_647:
						try
						{
							foreach (object obj2 in xmlNode.ChildNodes)
							{
								XmlNode xmlNode2 = (XmlNode)obj2;
								WeaponRec weaponRec_ = WeaponRec.smethod_2(ref xmlNode2, ref dictionary_0, ref scenario_0);
								loadout.method_16(weaponRec_);
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
						IL_69E:
						if (num <= 3452475902U)
						{
							if (num != 3100949293U)
							{
								if (num != 3452475902U)
								{
									continue;
								}
								if (Operators.CompareString(name, "QuickTurnaround", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "QT_TimeofDay", false) == 0)
								{
									goto IL_6FC;
								}
								continue;
							}
						}
						else if (num != 3675003861U)
						{
							if (num != 3750622950U)
							{
								if (num != 4034711405U)
								{
									continue;
								}
								if (Operators.CompareString(name, "TimeOnStation_Minutes", false) == 0)
								{
									loadout.short_0 = Conversions.ToShort(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Sens", false) == 0)
								{
									goto IL_7A3;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "MaxCapacity", false) == 0)
							{
								goto IL_80E;
							}
							continue;
						}
						IL_6D3:
						loadout.bool_13 = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_6FC:
						if (Versioned.IsNumeric(xmlNode.InnerText))
						{
							loadout._LoadoutDayNight_1 = (Loadout._LoadoutDayNight)Conversions.ToShort(xmlNode.InnerText);
							continue;
						}
						loadout._LoadoutDayNight_1 = (Loadout._LoadoutDayNight)Enum.Parse(typeof(Loadout._LoadoutDayNight), xmlNode.InnerText, true);
						continue;
						IL_7A3:
						if (xmlNode.HasChildNodes)
						{
							foreach (WeaponRec weaponRec in DBFunctions.smethod_47(ref scenario_0, loadout.DBID, loadout.bool_11, false).weaponRec_0)
							{
								if (weaponRec.method_12(scenario_0).method_167() == Weapon._WeaponType.SensorPod)
								{
									loadout.method_16(weaponRec);
								}
							}
							continue;
						}
						continue;
						IL_80E:
						loadout.int_1 = Conversions.ToInteger(xmlNode.InnerText);
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
				if (loadout.int_5 == 0)
				{
					DBFunctions.smethod_50(ref scenario_0, ref loadout);
				}
				if (loadout.int_5 > 0 && loadout.int_7 == 0)
				{
					DBFunctions.smethod_52(ref scenario_0, ref loadout);
				}
				if (loadout._WeaponState_0 == Doctrine._WeaponState.LoadoutSetting)
				{
					loadout._WeaponState_0 = Doctrine._WeaponState.Winchester;
				}
				Loadout loadout2 = DBFunctions.smethod_47(ref scenario_0, loadout.DBID, false, false);
				loadout.cargoType_0 = loadout2.cargoType_0;
				loadout.float_2 = loadout2.float_2;
				loadout.float_1 = loadout2.float_1;
				loadout.float_3 = loadout2.float_3;
				loadout.bool_15 = loadout2.bool_15;
				result = loadout;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101008", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x001777F0 File Offset: 0x001759F0
		public Sensor[] method_9(Scenario scenario_0)
		{
			Sensor[] result;
			try
			{
				int num = this.weaponRec_0.Length;
				if (num > 0)
				{
					int num2 = num - 1;
					int num3;
					for (int i = 0; i <= num2; i++)
					{
						WeaponRec weaponRec = this.weaponRec_0[i];
						if (weaponRec.method_12(scenario_0).method_167() == Weapon._WeaponType.SensorPod)
						{
							Sensor[] array = weaponRec.method_12(scenario_0).vmethod_96();
							for (int j = 0; j < array.Length; j = checked(j + 1))
							{
								num3++;
							}
						}
					}
					Sensor[] array2 = new Sensor[num3 - 1 + 1];
					int num4 = 0;
					int num5 = num - 1;
					for (int k = 0; k <= num5; k++)
					{
						WeaponRec weaponRec = this.weaponRec_0[k];
						if (weaponRec.method_12(scenario_0).method_167() == Weapon._WeaponType.SensorPod)
						{
							foreach (Sensor sensor in weaponRec.method_12(scenario_0).vmethod_96())
							{
								array2[num4] = sensor;
								num4++;
							}
						}
					}
					result = array2;
				}
				else
				{
					result = new Sensor[0];
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101009", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Sensor[0];
			}
			return result;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0017793C File Offset: 0x00175B3C
		public bool method_10()
		{
			Loadout.LoadoutRole loadoutRole = this.loadoutRole_0;
			if (loadoutRole - Loadout.LoadoutRole.Intercept_BVR > 5)
			{
				if (loadoutRole != Loadout.LoadoutRole.AntiSatellite_Intercept)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0017796C File Offset: 0x00175B6C
		public bool method_11()
		{
			Loadout.LoadoutRole loadoutRole = this.loadoutRole_0;
			return loadoutRole - Loadout.LoadoutRole.ASW_Patrol <= 1;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00177994 File Offset: 0x00175B94
		public bool method_12()
		{
			Loadout.LoadoutRole loadoutRole = this.loadoutRole_0;
			if (loadoutRole <= Loadout.LoadoutRole.NavalMineLaying)
			{
				if (loadoutRole - Loadout.LoadoutRole.OECM <= 2 || loadoutRole == Loadout.LoadoutRole.SearchAndRescue || loadoutRole == Loadout.LoadoutRole.NavalMineLaying)
				{
					goto IL_4B;
				}
			}
			else
			{
				if (loadoutRole - Loadout.LoadoutRole.Forward_Observer <= 1 || loadoutRole == Loadout.LoadoutRole.Unarmed_Recon)
				{
					goto IL_4B;
				}
				if (loadoutRole == Loadout.LoadoutRole.AirRefueling)
				{
					goto IL_4B;
				}
			}
			return false;
			IL_4B:
			return true;
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x001779F0 File Offset: 0x00175BF0
		public bool method_13()
		{
			Loadout.LoadoutRole loadoutRole = this.loadoutRole_0;
			if (loadoutRole <= Loadout.LoadoutRole.NavalOnly_DEAD)
			{
				if (loadoutRole - Loadout.LoadoutRole.LandNaval_Strike <= 4 || loadoutRole - Loadout.LoadoutRole.LandOnly_Strike <= 4 || loadoutRole - Loadout.LoadoutRole.NavalOnly_Strike <= 4)
				{
					goto IL_4D;
				}
			}
			else
			{
				if (loadoutRole == Loadout.LoadoutRole.BAI_CAS || loadoutRole == Loadout.LoadoutRole.NavalMineLaying)
				{
					goto IL_4D;
				}
				if (loadoutRole == Loadout.LoadoutRole.ASW_Attack)
				{
					goto IL_4D;
				}
			}
			return false;
			IL_4D:
			return true;
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00177A50 File Offset: 0x00175C50
		public int method_14()
		{
			int result;
			try
			{
				int num;
				foreach (WeaponRec weaponRec in this.weaponRec_0)
				{
					num += (int)Math.Round(Math.Round((double)weaponRec.method_9() / (double)weaponRec.int_4, 0));
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101010", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00177AE8 File Offset: 0x00175CE8
		public Class237 method_15(Scenario scenario_0)
		{
			if (Information.IsNothing(this.class237_0))
			{
				int dbid = this.DBID;
				SQLiteConnection sqliteConnection = scenario_0.method_39();
				this.class237_0 = DBFunctions.smethod_38(dbid, ref sqliteConnection, scenario_0);
			}
			return this.class237_0;
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00177B24 File Offset: 0x00175D24
		public Loadout(int int_13, string string_2, int int_14, int int_15, int int_16, int int_17, Loadout.LoadoutRole loadoutRole_1, Loadout._LoadoutDayNight _LoadoutDayNight_2, Loadout._LoadoutWeather _LoadoutWeather_1, float float_4, int int_18, short short_1, bool bool_16, bool bool_17, bool bool_18, int int_19, int int_20, int int_21, int int_22, Loadout._LoadoutDayNight _LoadoutDayNight_3, Doctrine._WeaponState _WeaponState_1)
		{
			this.weaponRec_0 = new WeaponRec[0];
			this.bool_11 = false;
			this.DBID = int_13;
			this.Name = string_2;
			this.int_0 = int_14;
			this.int_1 = int_15;
			this.int_2 = int_16;
			this.int_3 = int_17;
			this.weaponRec_0 = new WeaponRec[0];
			this.loadoutRole_0 = loadoutRole_1;
			this._LoadoutDayNight_0 = _LoadoutDayNight_2;
			this._LoadoutWeather_0 = _LoadoutWeather_1;
			this.float_0 = float_4;
			this.int_4 = int_18;
			this.short_0 = short_1;
			this.bool_12 = bool_16;
			this.bool_11 = bool_17;
			this.bool_13 = bool_18;
			this.int_9 = int_19;
			this.int_10 = int_20;
			this.int_11 = int_21;
			this.int_12 = int_22;
			this._LoadoutDayNight_1 = _LoadoutDayNight_3;
			this._WeaponState_0 = _WeaponState_1;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00177BFC File Offset: 0x00175DFC
		public void method_16(WeaponRec weaponRec_1)
		{
			Class429.smethod_44(ref this.weaponRec_0, weaponRec_1);
			Loadout.Delegate34 @delegate = Loadout.delegate34_0;
			if (@delegate != null)
			{
				@delegate(this.string_0, weaponRec_1.string_0);
			}
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00177C30 File Offset: 0x00175E30
		public void method_17(WeaponRec weaponRec_1)
		{
			Class429.smethod_45(ref this.weaponRec_0, weaponRec_1);
			Loadout.Delegate35 @delegate = Loadout.delegate35_0;
			if (@delegate != null)
			{
				@delegate(this.string_0, weaponRec_1.string_0);
			}
		}

		// Token: 0x04000E0F RID: 3599
		public int DBID;

		// Token: 0x04000E10 RID: 3600
		public int int_0;

		// Token: 0x04000E11 RID: 3601
		public int int_1;

		// Token: 0x04000E12 RID: 3602
		public int int_2;

		// Token: 0x04000E13 RID: 3603
		public int int_3;

		// Token: 0x04000E14 RID: 3604
		public WeaponRec[] weaponRec_0;

		// Token: 0x04000E15 RID: 3605
		public Loadout.LoadoutRole loadoutRole_0;

		// Token: 0x04000E16 RID: 3606
		public Loadout._LoadoutDayNight _LoadoutDayNight_0;

		// Token: 0x04000E17 RID: 3607
		public Loadout._LoadoutWeather _LoadoutWeather_0;

		// Token: 0x04000E18 RID: 3608
		public float float_0;

		// Token: 0x04000E19 RID: 3609
		public int int_4;

		// Token: 0x04000E1A RID: 3610
		public short short_0;

		// Token: 0x04000E1B RID: 3611
		public int int_5;

		// Token: 0x04000E1C RID: 3612
		public int int_6;

		// Token: 0x04000E1D RID: 3613
		public int int_7;

		// Token: 0x04000E1E RID: 3614
		public int int_8;

		// Token: 0x04000E1F RID: 3615
		public bool bool_11;

		// Token: 0x04000E20 RID: 3616
		private Class237 class237_0;

		// Token: 0x04000E21 RID: 3617
		public bool bool_12;

		// Token: 0x04000E22 RID: 3618
		public bool bool_13;

		// Token: 0x04000E23 RID: 3619
		public int int_9;

		// Token: 0x04000E24 RID: 3620
		public int int_10;

		// Token: 0x04000E25 RID: 3621
		public int int_11;

		// Token: 0x04000E26 RID: 3622
		public int int_12;

		// Token: 0x04000E27 RID: 3623
		public Loadout._LoadoutDayNight _LoadoutDayNight_1;

		// Token: 0x04000E28 RID: 3624
		public Doctrine._WeaponState _WeaponState_0;

		// Token: 0x04000E29 RID: 3625
		public bool bool_14;

		// Token: 0x04000E2A RID: 3626
		public float float_1;

		// Token: 0x04000E2B RID: 3627
		public float float_2;

		// Token: 0x04000E2C RID: 3628
		public CargoType cargoType_0;

		// Token: 0x04000E2D RID: 3629
		public float float_3;

		// Token: 0x04000E2E RID: 3630
		public bool bool_15;

		// Token: 0x04000E2F RID: 3631
		[CompilerGenerated]
		private static Loadout.Delegate34 delegate34_0;

		// Token: 0x04000E30 RID: 3632
		[CompilerGenerated]
		private static Loadout.Delegate35 delegate35_0;

		// Token: 0x04000E31 RID: 3633
		private StringBuilder stringBuilder_0;

		// Token: 0x02000283 RID: 643
		// (Invoke) Token: 0x060013AB RID: 5035
		internal delegate void Delegate34(string LoadoutObjectID, string WeaponRecObjectID);

		// Token: 0x02000284 RID: 644
		// (Invoke) Token: 0x060013AF RID: 5039
		internal delegate void Delegate35(string LoadoutObjectID, string WeaponRecObjectID);

		// Token: 0x02000285 RID: 645
		public enum LoadoutRole
		{
			// Token: 0x04000E33 RID: 3635
			None = 1001,
			// Token: 0x04000E34 RID: 3636
			Intercept_BVR = 2001,
			// Token: 0x04000E35 RID: 3637
			Intercept_WVR,
			// Token: 0x04000E36 RID: 3638
			AirSuperiority_BVR,
			// Token: 0x04000E37 RID: 3639
			AirSuperiority_WVR,
			// Token: 0x04000E38 RID: 3640
			PointDefence_BVR,
			// Token: 0x04000E39 RID: 3641
			PointDefence_WVR,
			// Token: 0x04000E3A RID: 3642
			GunsOnly,
			// Token: 0x04000E3B RID: 3643
			AntiSatellite_Intercept = 2101,
			// Token: 0x04000E3C RID: 3644
			AirborneLaser,
			// Token: 0x04000E3D RID: 3645
			LandNaval_Strike = 3001,
			// Token: 0x04000E3E RID: 3646
			LandNaval_Standoff,
			// Token: 0x04000E3F RID: 3647
			LandNaval_SEAD_ARM,
			// Token: 0x04000E40 RID: 3648
			LandNaval_SEAD_TALD,
			// Token: 0x04000E41 RID: 3649
			LandNaval_DEAD,
			// Token: 0x04000E42 RID: 3650
			LandOnly_Strike = 3101,
			// Token: 0x04000E43 RID: 3651
			LandOnly_Standoff,
			// Token: 0x04000E44 RID: 3652
			LandOnly_SEAD_ARM,
			// Token: 0x04000E45 RID: 3653
			LandOnly_SEAD_TALD,
			// Token: 0x04000E46 RID: 3654
			LandOnly_DEAD,
			// Token: 0x04000E47 RID: 3655
			NavalOnly_Strike = 3201,
			// Token: 0x04000E48 RID: 3656
			NavalOnly_Standoff,
			// Token: 0x04000E49 RID: 3657
			NavalOnly_SEAD_ARM,
			// Token: 0x04000E4A RID: 3658
			NavalOnly_SEAD_TALD,
			// Token: 0x04000E4B RID: 3659
			NavalOnly_DEAD,
			// Token: 0x04000E4C RID: 3660
			BAI_CAS = 3401,
			// Token: 0x04000E4D RID: 3661
			Buddy_Illumination = 3501,
			// Token: 0x04000E4E RID: 3662
			OECM = 4001,
			// Token: 0x04000E4F RID: 3663
			AEW,
			// Token: 0x04000E50 RID: 3664
			CommandPost,
			// Token: 0x04000E51 RID: 3665
			ChaffLaying,
			// Token: 0x04000E52 RID: 3666
			SearchAndRescue = 4101,
			// Token: 0x04000E53 RID: 3667
			CombatSearchAndRescue,
			// Token: 0x04000E54 RID: 3668
			MineSweeping = 4201,
			// Token: 0x04000E55 RID: 3669
			MineRecon,
			// Token: 0x04000E56 RID: 3670
			NavalMineLaying = 4301,
			// Token: 0x04000E57 RID: 3671
			ASW_Patrol = 6001,
			// Token: 0x04000E58 RID: 3672
			ASW_Attack,
			// Token: 0x04000E59 RID: 3673
			Forward_Observer = 7001,
			// Token: 0x04000E5A RID: 3674
			Area_Surveillance,
			// Token: 0x04000E5B RID: 3675
			Armed_Recon,
			// Token: 0x04000E5C RID: 3676
			Unarmed_Recon,
			// Token: 0x04000E5D RID: 3677
			Maritime_Surveillance,
			// Token: 0x04000E5E RID: 3678
			Paratroopers = 7101,
			// Token: 0x04000E5F RID: 3679
			Troop_Transport,
			// Token: 0x04000E60 RID: 3680
			Cargo = 7201,
			// Token: 0x04000E61 RID: 3681
			AirRefueling = 8001,
			// Token: 0x04000E62 RID: 3682
			Training = 8101,
			// Token: 0x04000E63 RID: 3683
			TargetTow,
			// Token: 0x04000E64 RID: 3684
			TargetDrone,
			// Token: 0x04000E65 RID: 3685
			Ferry = 9001,
			// Token: 0x04000E66 RID: 3686
			Unavailable,
			// Token: 0x04000E67 RID: 3687
			Reserve,
			// Token: 0x04000E68 RID: 3688
			ArmedFerry
		}

		// Token: 0x02000286 RID: 646
		public enum _LoadoutWeather : short
		{
			// Token: 0x04000E6A RID: 3690
			None = 1001,
			// Token: 0x04000E6B RID: 3691
			AllWeather = 2001,
			// Token: 0x04000E6C RID: 3692
			LimitedAllWeather,
			// Token: 0x04000E6D RID: 3693
			ClearWeather
		}

		// Token: 0x02000287 RID: 647
		public enum _LoadoutDayNight : short
		{
			// Token: 0x04000E6F RID: 3695
			None = 1001,
			// Token: 0x04000E70 RID: 3696
			DayNight = 2001,
			// Token: 0x04000E71 RID: 3697
			NightOnly,
			// Token: 0x04000E72 RID: 3698
			DayOnly
		}
	}
}
