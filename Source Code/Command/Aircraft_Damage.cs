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

namespace Command_Core
{
	// Token: 0x020001A6 RID: 422
	public sealed class Aircraft_Damage : ActiveUnit_Damage
	{
		// Token: 0x06000CDD RID: 3293 RVA: 0x00008E0E File Offset: 0x0000700E
		private Aircraft method_15()
		{
			if (Information.IsNothing(this.aircraft_0))
			{
				this.aircraft_0 = (Aircraft)this.activeUnit_0;
			}
			return this.aircraft_0;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x000FC5F4 File Offset: 0x000FA7F4
		public override void vmethod_0(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Damage");
				if (this.fireIntensityLevel_0 > ActiveUnit_Damage.FireIntensityLevel.NoFire)
				{
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Fire";
					byte fireIntensityLevel_ = (byte)this.fireIntensityLevel_0;
					xmlWriter.WriteElementString(localName, fireIntensityLevel_.ToString());
				}
				xmlWriter_0.WriteElementString("TTNSDC", XmlConvert.ToString(this.float_0));
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100445", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x000FC698 File Offset: 0x000FA898
		public static Aircraft_Damage smethod_1(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Aircraft_Damage result;
			try
			{
				Aircraft_Damage aircraft_Damage = new Aircraft_Damage(ref activeUnit_1);
				aircraft_Damage.activeUnit_0 = activeUnit_1;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "Fire", false) != 0)
						{
							if (Operators.CompareString(name, "TTNSDC", false) == 0)
							{
								aircraft_Damage.float_0 = Math.Abs(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
							}
						}
						else
						{
							aircraft_Damage.fireIntensityLevel_0 = (ActiveUnit_Damage.FireIntensityLevel)Conversions.ToByte(xmlNode.InnerText);
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
				result = aircraft_Damage;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100446", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Aircraft_Damage(ref activeUnit_1);
			}
			return result;
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00008E34 File Offset: 0x00007034
		public Aircraft_Damage(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x000FC7AC File Offset: 0x000FA9AC
		public override void vmethod_10(Weapon weapon_0, GeoPoint geoPoint_0, float float_1, float float_2, ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2, ref string string_0)
		{
			if (!this.activeUnit_0.method_8())
			{
				if (this.method_15().method_144() || this.method_15().scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_3))
				{
					string text = "";
					base.vmethod_10(weapon_0, geoPoint_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2, ref text);
					return;
				}
				this.activeUnit_0.scenario_0.method_65(this.activeUnit_0);
			}
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x000FC820 File Offset: 0x000FAA20
		protected override void vmethod_9(Weapon weapon_0, GeoPoint geoPoint_0, float float_1, float float_2, ref ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2)
		{
			try
			{
				float targetDP_BeforeDamage = this.activeUnit_0.vmethod_63(false, null);
				double num;
				if (weapon_0.method_0())
				{
					num = (double)Class437.smethod_11(this.activeUnit_0.vmethod_9(), this.activeUnit_0.method_32(weapon_0));
				}
				else
				{
					num = (double)Class437.smethod_11(this.activeUnit_0.vmethod_9(), this.activeUnit_0.method_34(geoPoint_0.imethod_2(), geoPoint_0.imethod_0()));
				}
				Warhead warhead = weapon_0.warhead_0[0];
				Random random = GameGeneral.smethod_5();
				double num2 = 0.0;
				double num3 = (double)warhead.float_0;
				switch (weapon_0.method_143())
				{
				case GlobalVariables.TechGenerationClass.Late1970s:
					num3 = (double)warhead.float_0 * 1.05;
					break;
				case GlobalVariables.TechGenerationClass.Early1980s:
					num3 = (double)warhead.float_0 * 1.1;
					break;
				case GlobalVariables.TechGenerationClass.Late1980s:
					num3 = (double)warhead.float_0 * 1.15;
					break;
				case GlobalVariables.TechGenerationClass.Early1990s:
					num3 = (double)warhead.float_0 * 1.2;
					break;
				case GlobalVariables.TechGenerationClass.Late1990s:
					num3 = (double)warhead.float_0 * 1.25;
					break;
				case GlobalVariables.TechGenerationClass.Early2000s:
					num3 = (double)warhead.float_0 * 1.3;
					break;
				case GlobalVariables.TechGenerationClass.Late2000s:
					num3 = (double)warhead.float_0 * 1.35;
					break;
				case GlobalVariables.TechGenerationClass.Early2010s:
					num3 = (double)warhead.float_0 * 1.4;
					break;
				case GlobalVariables.TechGenerationClass.Late2010s:
					num3 = (double)warhead.float_0 * 1.45;
					break;
				case GlobalVariables.TechGenerationClass.Early2020s:
					num3 = (double)warhead.float_0 * 1.5;
					break;
				case GlobalVariables.TechGenerationClass.Late2020s:
					num3 = (double)warhead.float_0 * 1.55;
					break;
				}
				double num4;
				if (weapon_0.method_156() && (UnguidedWeapon.smethod_1(weapon_0.Name) || UnguidedWeapon.smethod_0(weapon_0.Name)))
				{
					num4 = (double)((float)((double)random.Next(1, 11) * 0.1 * num3));
				}
				else
				{
					num4 = num3;
				}
				if (weapon_0.method_207())
				{
					num4 = 0.0;
					num2 = base.method_1(weapon_0, geoPoint_0);
				}
				if (warhead.warheadType_0 == Warhead.WarheadType.Kinetic || warhead.warheadType_0 == Warhead.WarheadType.ArmorPiercing)
				{
					num2 = (double)weapon_0.method_278();
				}
				string text = "";
				if (Operators.CompareString(this.method_15().Name, this.method_15().string_2, false) != 0)
				{
					text = " (" + this.method_15().string_2 + ")";
				}
				if (this.method_15().method_144())
				{
					if (warhead.method_16(weapon_0, this.method_15()))
					{
					}
				}
				else
				{
					float num5 = weapon_0.method_148(this.method_15().armorRating_1, this.activeUnit_0.vmethod_121()) / 100f;
					if (num5 > 0f)
					{
						if (this.method_16())
						{
							this.activeUnit_0.method_124(Misc.smethod_9(this.activeUnit_0.Name) + text + " suffered penetration on pressurized cabin - Disintegrating in mid-air!", this.activeUnit_0.Name + " destroyed!", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							this.method_15().scenario_0.method_65(this.method_15());
							this.activeUnit_0.vmethod_64(false, null, 0f);
						}
						else
						{
							double num6 = (double)num5 * (num4 + num2);
							this.activeUnit_0.method_124(string.Concat(new string[]
							{
								Misc.smethod_9(this.activeUnit_0.Name),
								text,
								" has suffered weapon damage: ",
								Conversions.ToString(Math.Round(num6, 2)),
								" DPs"
							}), this.activeUnit_0.Name + " damaged", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							this.activeUnit_0.vmethod_64(false, null, (float)((double)this.activeUnit_0.vmethod_63(false, null) - num6));
							if (this.activeUnit_0.vmethod_63(false, null) > 0f)
							{
								double num7 = num6 / 40.0;
								if (random.NextDouble() < num7)
								{
									this.activeUnit_0.method_124(Misc.smethod_9(this.activeUnit_0.Name) + text + " has its flight controls knocked out - going down!", this.activeUnit_0.Name + " destroyed!", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
									this.method_15().scenario_0.method_65(this.method_15());
									this.activeUnit_0.vmethod_64(false, null, 0f);
								}
							}
						}
					}
					if (this.activeUnit_0.vmethod_63(false, null) > 0f)
					{
						double num8;
						switch (this.method_15().aircraftSizeClass_0)
						{
						case GlobalVariables.AircraftSizeClass.Small:
							num8 = 0.4;
							break;
						case GlobalVariables.AircraftSizeClass.Medium:
							num8 = 0.3;
							break;
						case GlobalVariables.AircraftSizeClass.Large:
							num8 = 0.2;
							break;
						case GlobalVariables.AircraftSizeClass.VLarge:
							num8 = 0.1;
							break;
						}
						if (weapon_0.method_156())
						{
							num8 = (double)((float)(num8 * 0.2));
						}
						double num9 = num;
						if (num9 < 45.0)
						{
							num8 *= 1.5;
						}
						else if (num9 >= 135.0)
						{
							if (num9 < 225.0)
							{
								num8 *= 0.5;
							}
							else if (num9 >= 315.0)
							{
								num8 *= 1.5;
							}
						}
						if (random.NextDouble() < num8)
						{
							num5 = weapon_0.method_148(this.method_15().armorRating_0, this.activeUnit_0.vmethod_121()) / 100f;
							this.activeUnit_0.method_124("Cockpit hit - penetration " + Conversions.ToString(num5 * 100f) + "%", "Cockpit hit", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.method_15().vmethod_28(null), this.method_15().vmethod_30(null)));
							if ((double)num5 > 0.5)
							{
								this.activeUnit_0.method_124("Cockpit & crew incapacitated - aircraft is out of control!", this.activeUnit_0.Name + " destroyed!", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.method_15().vmethod_28(null), this.method_15().vmethod_30(null)));
								this.method_15().scenario_0.method_65(this.method_15());
								return;
							}
						}
						float num10;
						switch (this.method_15().aircraftSizeClass_0)
						{
						case GlobalVariables.AircraftSizeClass.Small:
							num10 = 0.5f;
							break;
						case GlobalVariables.AircraftSizeClass.Medium:
							num10 = 0.3f;
							break;
						case GlobalVariables.AircraftSizeClass.Large:
							num10 = 0.2f;
							break;
						case GlobalVariables.AircraftSizeClass.VLarge:
							num10 = 0.1f;
							break;
						}
						if (weapon_0.method_156())
						{
							num10 = (float)((double)num10 * 0.2);
						}
						if (random.NextDouble() < (double)num10)
						{
							num5 = weapon_0.method_148(this.method_15().armorRating_2, this.activeUnit_0.vmethod_121()) / 100f;
							this.activeUnit_0.method_124("Engine hit - penetration " + Conversions.ToString(num5 * 100f) + "%", "Engine hit", LoggedMessage.MessageType.UnitLost, 0, false, new Geopoint_Struct(this.method_15().vmethod_28(null), this.method_15().vmethod_30(null)));
							if ((double)num5 > 0.5)
							{
								IEnumerable<Engine> enumerable = Enumerable.Where<Engine>(this.method_15().vmethod_49(), (Aircraft_Damage._Closure$__.$I7-0 == null) ? (Aircraft_Damage._Closure$__.$I7-0 = new Func<Engine, bool>(Aircraft_Damage._Closure$__.$I.method_0)) : Aircraft_Damage._Closure$__.$I7-0);
								if (Enumerable.Count<Engine>(enumerable) > 0)
								{
									Engine engine = Enumerable.ElementAtOrDefault<Engine>(enumerable, random.Next(0, Enumerable.Count<Engine>(enumerable)));
									engine.vmethod_6(this.method_15().vmethod_7(false), false, false);
									this.activeUnit_0.method_124("Engine " + engine.Name + " has been destroyed!", this.activeUnit_0.Name + " destroyed!", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.method_15().vmethod_28(null), this.method_15().vmethod_30(null)));
								}
							}
						}
						base.method_5(warhead.warheadType_0, warhead.enum126_0, num4 + num2, targetDP_BeforeDamage, num5, false, num5, weapon_0.keyValuePair_0.Key);
					}
				}
				base.method_6(true);
				base.method_7();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100447", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x000FD198 File Offset: 0x000FB398
		public override void vmethod_11(float float_1, Warhead.WarheadType warheadType_0, float float_2)
		{
			try
			{
				if (float_1 > 0f)
				{
					double num = (double)(float_1 / this.activeUnit_0.vmethod_63(false, null));
					num = 0.3;
					if (warheadType_0 != Warhead.WarheadType.Fragmentation && warheadType_0 != Warhead.WarheadType.ContinuousRod)
					{
						if (warheadType_0 == Warhead.WarheadType.Fragmentation_ABM)
						{
							num += 0.4;
						}
					}
					else
					{
						num += 0.2;
					}
					if (num >= 0.9)
					{
						num = 0.9;
					}
					double num2 = num;
					float num3 = (float)(num - 0.1);
					float num4 = (float)(num - 0.2);
					double num5 = GameGeneral.smethod_5().NextDouble();
					if (num5 < (double)num4)
					{
						base.method_10(ActiveUnit_Damage.FireIntensityLevel.Severe);
					}
					else if (num5 < (double)num3)
					{
						base.method_10(ActiveUnit_Damage.FireIntensityLevel.Major);
					}
					else if (num5 < num2)
					{
						base.method_10(ActiveUnit_Damage.FireIntensityLevel.Minor);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100554", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000FD2BC File Offset: 0x000FB4BC
		private bool method_16()
		{
			bool result;
			if (this.method_15().vmethod_14(false) < 3657.6f)
			{
				result = false;
			}
			else
			{
				Aircraft._AircraftType aircraftType_ = this.method_15()._AircraftType_0;
				if (aircraftType_ <= Aircraft._AircraftType.SIGINT)
				{
					if (aircraftType_ <= Aircraft._AircraftType.AirborneCP)
					{
						if (aircraftType_ == Aircraft._AircraftType.AirborneLaserPlatform || aircraftType_ - Aircraft._AircraftType.OECM <= 2)
						{
							goto IL_A2;
						}
					}
					else if (aircraftType_ == Aircraft._AircraftType.SAR || aircraftType_ - Aircraft._AircraftType.ASW <= 1 || aircraftType_ - Aircraft._AircraftType.ForwardObserver <= 4)
					{
						goto IL_A2;
					}
				}
				else if (aircraftType_ <= Aircraft._AircraftType.Cargo)
				{
					if (aircraftType_ == Aircraft._AircraftType.Transport || aircraftType_ == Aircraft._AircraftType.Cargo)
					{
						goto IL_A2;
					}
				}
				else if (aircraftType_ - Aircraft._AircraftType.Commercial <= 1 || aircraftType_ == Aircraft._AircraftType.Tanker || aircraftType_ - Aircraft._AircraftType.AirShip <= 1)
				{
					goto IL_A2;
				}
				return false;
				IL_A2:
				result = true;
			}
			return result;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x000FD370 File Offset: 0x000FB570
		public override void vmethod_5(float DamageYield, float theCutOffRange_Frag, int ARM_TargetedRadar = 0)
		{
			if (this.activeUnit_0.enum122_0 == Unit.Enum122.const_0)
			{
				try
				{
					if (this.method_15().method_144())
					{
						base.vmethod_5(DamageYield, theCutOffRange_Frag, 0);
						if (this.activeUnit_0.vmethod_63(false, null) <= 0f)
						{
							this.activeUnit_0.vmethod_64(false, null, 0f);
							this.activeUnit_0.scenario_0.method_65(this.activeUnit_0);
						}
					}
					else
					{
						this.activeUnit_0.scenario_0.method_65(this.activeUnit_0);
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100448", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x000FD440 File Offset: 0x000FB640
		public override void vmethod_6(float float_1, Warhead.WarheadType warheadType_0, Warhead.Enum126 enum126_0, Weapon.Enum128 enum128_0)
		{
			if (this.activeUnit_0.enum122_0 == Unit.Enum122.const_0)
			{
				try
				{
					if (float_1 >= 2f)
					{
						if (this.method_15().method_144())
						{
							base.vmethod_6(float_1, warheadType_0, enum126_0, enum128_0);
						}
						else
						{
							this.activeUnit_0.scenario_0.method_65(this.activeUnit_0);
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100449", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0000378C File Offset: 0x0000198C
		public override void vmethod_14(float float_1)
		{
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x000FD4DC File Offset: 0x000FB6DC
		public override void vmethod_12(float float_1)
		{
			if (this.method_15().scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_3))
			{
				try
				{
					float num;
					switch (this.vmethod_3())
					{
					case ActiveUnit_Damage.FireIntensityLevel.Minor:
						num = (float)((double)this.activeUnit_0.method_60() * 0.2 * (double)(float_1 / 3600f));
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Major:
						num = (float)((double)this.activeUnit_0.method_60() * 0.4 * (double)(float_1 / 3600f));
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Severe:
						num = (float)((double)this.activeUnit_0.method_60() * 0.8 * (double)(float_1 / 3600f));
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Conflagration:
						num = (float)this.activeUnit_0.method_60() * (float_1 / 3600f);
						if (GameGeneral.smethod_5().Next(1, 101) <= 5)
						{
							this.activeUnit_0.method_124(this.activeUnit_0.Name + " has a fuel explosion and is disintegrating!!!", this.activeUnit_0.Name + " destroyed!", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							this.activeUnit_0.scenario_0.method_65(this.activeUnit_0);
							return;
						}
						break;
					}
					if (num > 0f)
					{
						this.activeUnit_0.vmethod_64(false, null, this.activeUnit_0.vmethod_63(false, null) - num);
					}
					if (this.activeUnit_0.vmethod_91().method_0() > 80f)
					{
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " has exceeded 80% structural/fuselage damage and is disintegrating!!!", this.activeUnit_0.Name + " destroyed!", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						this.activeUnit_0.scenario_0.method_65(this.activeUnit_0);
					}
					else
					{
						if (this.method_15().scenario_0.FifthSecondIsChangingOnThisPulse && this.vmethod_3() > ActiveUnit_Damage.FireIntensityLevel.NoFire)
						{
							byte b = (byte)GameGeneral.smethod_5().Next(1, 11);
							GlobalVariables.ProficiencyLevel? proficiencyLevel = this.activeUnit_0.vmethod_53();
							int? num2 = (proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
							if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								b += 3;
							}
							else
							{
								num2 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									b += 2;
								}
								else
								{
									num2 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
									if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										b += 1;
									}
									else
									{
										num2 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
										if (!((num2 != null) ? new bool?(num2.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											num2 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
											if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 4) : null).GetValueOrDefault())
											{
												b = (byte)Math.Max(0, (int)(b - 2));
											}
										}
									}
								}
							}
							b = (byte)Math.Max(0, (int)b);
							if (b <= 10)
							{
								switch (b)
								{
								case 1:
								case 2:
								case 3:
								case 4:
									this.vmethod_4((ActiveUnit_Damage.FireIntensityLevel)Math.Max(0, (int)(this.vmethod_3() - ActiveUnit_Damage.FireIntensityLevel.Minor)));
									goto IL_485;
								case 5:
								case 6:
								case 7:
								case 8:
									goto IL_485;
								case 9:
								case 10:
									break;
								default:
									goto IL_485;
								}
							}
							if (this.vmethod_3() != ActiveUnit_Damage.FireIntensityLevel.Conflagration)
							{
								this.vmethod_4(this.vmethod_3() + 1);
							}
						}
						IL_485:;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200283", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x0400089E RID: 2206
		private Aircraft aircraft_0;
	}
}
