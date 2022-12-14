using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns12;

namespace Command_Core
{
	// Token: 0x02000242 RID: 578
	public sealed class Facility_Damage : ActiveUnit_Damage
	{
		// Token: 0x060011DF RID: 4575 RVA: 0x001639E8 File Offset: 0x00161BE8
		public override void vmethod_0(ref XmlWriter xmlWriter_0)
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

		// Token: 0x060011E0 RID: 4576 RVA: 0x00163A44 File Offset: 0x00161C44
		public static Facility_Damage smethod_1(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Facility_Damage result;
			try
			{
				Facility_Damage facility_Damage = new Facility_Damage(ref activeUnit_1);
				facility_Damage.activeUnit_0 = activeUnit_1;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "InitialDP", false) != 0)
						{
							if (Operators.CompareString(name, "Fire", false) != 0)
							{
								if (Operators.CompareString(name, "TTNSDC", false) == 0)
								{
									facility_Damage.float_0 = Math.Abs(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
								}
							}
							else
							{
								facility_Damage.fireIntensityLevel_0 = (ActiveUnit_Damage.FireIntensityLevel)Conversions.ToByte(xmlNode.InnerText);
							}
						}
						else
						{
							facility_Damage.activeUnit_0.method_61(Conversions.ToInteger(xmlNode.InnerText));
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
				result = facility_Damage;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100553", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Facility_Damage(ref activeUnit_1);
			}
			return result;
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00008E34 File Offset: 0x00007034
		public Facility_Damage(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00163B84 File Offset: 0x00161D84
		public override void vmethod_11(float float_1, Warhead.WarheadType warheadType_0, float float_2)
		{
			try
			{
				if (float_1 > 0f)
				{
					double num = (double)(float_1 / this.activeUnit_0.vmethod_63(false, null));
					if (float_2 > 0f)
					{
						if (warheadType_0 <= Warhead.WarheadType.Chemical)
						{
							if (warheadType_0 == Warhead.WarheadType.Incendiary)
							{
								num = 8.0 * num;
								goto IL_81;
							}
							if (warheadType_0 != Warhead.WarheadType.Chemical)
							{
								goto IL_81;
							}
						}
						else if (warheadType_0 != Warhead.WarheadType.Biological)
						{
							if (warheadType_0 != Warhead.WarheadType.AntiElectrical)
							{
								goto IL_81;
							}
							num = 2.0 * num;
							goto IL_81;
						}
						num = 0.0;
						IL_81:
						num *= (double)float_2;
					}
					if (num >= 0.9)
					{
						num = 0.9;
					}
					double num2 = num;
					float num3 = (float)(num * 0.3);
					float num4 = (float)(num * 0.1);
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

		// Token: 0x060011E3 RID: 4579 RVA: 0x00163CCC File Offset: 0x00161ECC
		public override void vmethod_7(ref float float_1, Warhead.WarheadType warheadType_0)
		{
			if (warheadType_0 != Warhead.WarheadType.SuperFrag)
			{
				switch (warheadType_0)
				{
				case Warhead.WarheadType.Cluster_AP:
				{
					GlobalVariables.ArmorRating armorRating_ = ((Facility)this.activeUnit_0).armorRating_0;
					if (armorRating_ == GlobalVariables.ArmorRating.None)
					{
						return;
					}
					if (armorRating_ == GlobalVariables.ArmorRating.Light)
					{
						float_1 = (float)(0.5 * (double)float_1);
						return;
					}
					float_1 = 0f;
					return;
				}
				case Warhead.WarheadType.Cluster_AT:
					break;
				case Warhead.WarheadType.Cluster_Penetrator:
				{
					GlobalVariables.ArmorRating armorRating_2 = ((Facility)this.activeUnit_0).armorRating_0;
					if (armorRating_2 == GlobalVariables.ArmorRating.None)
					{
						float_1 = 3f * float_1;
						return;
					}
					switch (armorRating_2)
					{
					case GlobalVariables.ArmorRating.Light:
						float_1 = 2f * float_1;
						return;
					case GlobalVariables.ArmorRating.Medium:
						float_1 = float_1;
						return;
					case GlobalVariables.ArmorRating.Heavy:
						float_1 = (float)(0.75 * (double)float_1);
						return;
					case GlobalVariables.ArmorRating.Special:
						float_1 = (float)(0.5 * (double)float_1);
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
				GlobalVariables.ArmorRating armorRating_3 = ((Facility)this.activeUnit_0).armorRating_0;
				if (armorRating_3 != GlobalVariables.ArmorRating.None)
				{
					if (armorRating_3 == GlobalVariables.ArmorRating.Light)
					{
						float_1 = (float)(0.7 * (double)float_1);
						return;
					}
					if (armorRating_3 != GlobalVariables.ArmorRating.Medium)
					{
						float_1 = 0f;
						return;
					}
					float_1 = (float)(0.5 * (double)float_1);
					return;
				}
			}
			else
			{
				GlobalVariables.ArmorRating armorRating_4 = ((Facility)this.activeUnit_0).armorRating_0;
				if (armorRating_4 != GlobalVariables.ArmorRating.None && armorRating_4 != GlobalVariables.ArmorRating.Light)
				{
					float_1 = 0f;
					return;
				}
			}
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00163E3C File Offset: 0x0016203C
		public override void vmethod_8(ref float float_1)
		{
			GlobalVariables.ArmorRating armorRating_ = ((Facility)this.activeUnit_0).armorRating_0;
			if (armorRating_ != GlobalVariables.ArmorRating.None)
			{
				switch (armorRating_)
				{
				case GlobalVariables.ArmorRating.Light:
					float_1 = (float)(0.9 * (double)float_1);
					return;
				case GlobalVariables.ArmorRating.Medium:
					float_1 = (float)(0.6 * (double)float_1);
					return;
				case GlobalVariables.ArmorRating.Heavy:
					float_1 = (float)(0.3 * (double)float_1);
					return;
				case GlobalVariables.ArmorRating.Special:
					float_1 = (float)(0.1 * (double)float_1);
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00163EC4 File Offset: 0x001620C4
		protected override void vmethod_9(Weapon weapon_0, GeoPoint geoPoint_0, float float_1, float float_2, ref ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2)
		{
			try
			{
				double num = (double)this.activeUnit_0.vmethod_63(false, null);
				Warhead warhead = weapon_0.warhead_0[0];
				double num2;
				double num3;
				if (!warhead.method_14(weapon_0.scenario_0) && !warhead.method_16(weapon_0, this.activeUnit_0) && !warhead.method_12())
				{
					num2 = (double)(weapon_0.method_148(((Facility)this.activeUnit_0).armorRating_0, this.activeUnit_0.vmethod_121()) / 100f);
					num3 = (double)weapon_0.method_278();
				}
				else
				{
					num2 = 0.0;
				}
				double num4;
				if (weapon_0.method_207())
				{
					num4 = 0.0;
					num3 = base.method_1(weapon_0, geoPoint_0);
				}
				float theAltitude;
				if (this.activeUnit_0.vmethod_13() >= 0f)
				{
					if (weapon_0.warhead_0.Length > 0)
					{
						theAltitude = weapon_0.vmethod_16();
					}
					else
					{
						theAltitude = this.activeUnit_0.vmethod_14(false);
					}
				}
				else
				{
					theAltitude = this.activeUnit_0.vmethod_14(false);
				}
				if (((Facility)this.activeUnit_0)._FacilityCategory_0 == Facility._FacilityCategory.Building_Underground && weapon_0.warhead_0[0].warheadType_0 == Warhead.WarheadType.HardTargetPenetrator)
				{
					theAltitude = (float)(this.activeUnit_0.method_9(false, false, false) - 20);
				}
				bool flag;
				if (Enumerable.Count<AirFacility>(Enumerable.Where<AirFacility>(this.activeUnit_0.vmethod_99(), (Facility_Damage._Closure$__.$I6-0 == null) ? (Facility_Damage._Closure$__.$I6-0 = new Func<AirFacility, bool>(Facility_Damage._Closure$__.$I.method_0)) : Facility_Damage._Closure$__.$I6-0)) > 0)
				{
					flag = (this.activeUnit_0.vmethod_99().Length > 0 && this.activeUnit_0.vmethod_99().Length == Enumerable.Count<AirFacility>(Enumerable.Where<AirFacility>(this.activeUnit_0.vmethod_99(), (Facility_Damage._Closure$__.$I6-1 == null) ? (Facility_Damage._Closure$__.$I6-1 = new Func<AirFacility, bool>(Facility_Damage._Closure$__.$I.method_1)) : Facility_Damage._Closure$__.$I6-1)));
				}
				if (Information.IsNothing(nullable_0) || Information.IsNothing(nullable_1))
				{
					double value;
					double value2;
					Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref value, ref value2, (double)(float_1 / 1852f), (double)float_2);
					nullable_0 = new double?(value2);
					nullable_1 = new double?(value);
				}
				if (num2 > 0.0)
				{
					this.activeUnit_0.scenario_0.method_59(Conversions.ToString(num2 * 100.0) + "% penetration achieved", this.activeUnit_0.Name + " - Armor penetrated", LoggedMessage.MessageType.WeaponDamage, 20, weapon_0.string_0, null, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
					if (flag)
					{
						if (num2 < 0.6 && warhead.float_0 < 100f)
						{
							num4 = Math.Round(num2 * (double)warhead.float_0 / 8.0, 2);
						}
						else if (num2 < 0.4 && warhead.float_0 < 250f)
						{
							num4 = Math.Round(num2 * (double)warhead.float_0 / 2.0, 2);
						}
						else if (num2 < 0.2 && warhead.float_0 < 500f)
						{
							num4 = Math.Round(num2 * (double)warhead.float_0, 2);
						}
						else
						{
							num4 = Math.Round(num2 * 2.0 * (double)warhead.float_0, 2);
						}
					}
					else if (warhead.method_11())
					{
						num4 = Math.Round(num2 * 2.0 * (double)warhead.float_0, 2);
					}
					else
					{
						num4 = Math.Round(num2 * (double)warhead.float_0, 2);
					}
					if (num2 < 1.0 && warhead.method_11())
					{
						new Explosion(ref this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), nullable_1.Value, nullable_0.Value, weapon_0.vmethod_9(), theAltitude, weapon_0.method_167(), (float)((double)warhead.float_0 * (1.0 - num2)), warhead.float_0, warhead.warheadType_0, warhead.enum126_0, null, null, this.activeUnit_0, null, null, 0, 0, 0, 0f, weapon_0.keyValuePair_0.Key);
					}
					else if (((Facility)this.activeUnit_0).armorRating_0 == GlobalVariables.ArmorRating.None && warhead.method_11())
					{
						new Explosion(ref this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), nullable_1.Value, nullable_0.Value, weapon_0.vmethod_9(), theAltitude, weapon_0.method_167(), (float)((double)warhead.float_0 * num2 * 0.25), warhead.float_0, warhead.warheadType_0, warhead.enum126_0, null, null, this.activeUnit_0, null, null, 0, 0, 0, 0f, weapon_0.keyValuePair_0.Key);
					}
					else
					{
						new Explosion(ref this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), nullable_1.Value, nullable_0.Value, weapon_0.vmethod_9(), theAltitude, (Weapon._WeaponType)0, (float)weapon_0.method_167(), warhead.float_0, warhead.warheadType_0, warhead.enum126_0, null, null, this.activeUnit_0, null, null, 0, 0, 0, 0f, weapon_0.keyValuePair_0.Key);
					}
				}
				else if (warhead.method_11())
				{
					if (warhead.method_16(weapon_0, this.activeUnit_0))
					{
						new Explosion(ref this.activeUnit_0.scenario_0, nullable_1.Value, nullable_0.Value, nullable_1.Value, nullable_0.Value, weapon_0.vmethod_9(), (float)this.activeUnit_0.method_9(false, false, false), weapon_0.method_167(), warhead.float_0, warhead.float_0, warhead.warheadType_0, warhead.enum126_0, null, null, null, null, null, 0, 0, 0, 0f, weapon_0.keyValuePair_0.Key);
					}
					else
					{
						new Explosion(ref this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), nullable_1.Value, nullable_0.Value, weapon_0.vmethod_9(), theAltitude, weapon_0.method_167(), warhead.float_0, warhead.float_0, warhead.warheadType_0, warhead.enum126_0, this.activeUnit_0, null, null, null, null, 0, 0, 0, 0f, weapon_0.keyValuePair_0.Key);
					}
				}
				else
				{
					this.activeUnit_0.scenario_0.method_59("No armor penetration!", this.activeUnit_0.Name + " - No armor penetration", LoggedMessage.MessageType.WeaponDamage, 20, weapon_0.string_0, null, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
					new Explosion(ref this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), nullable_1.Value, nullable_0.Value, weapon_0.vmethod_9(), theAltitude, weapon_0.method_167(), warhead.float_0, warhead.float_0, warhead.warheadType_0, warhead.enum126_0, this.activeUnit_0, null, null, null, null, 0, 0, 0, 0f, weapon_0.keyValuePair_0.Key);
				}
				if (Math.Round(num4 + num3, 1) > 0.0)
				{
					this.activeUnit_0.method_124(Misc.smethod_9(this.activeUnit_0.Name) + " has suffered weapon damage: " + Conversions.ToString(Math.Round(num4 + num3, 1)) + " DPs", this.activeUnit_0.Name + " damaged", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
				}
				this.activeUnit_0.vmethod_64(false, weapon_0, (float)((double)this.activeUnit_0.vmethod_63(false, null) - (num4 + num3)));
				base.method_5(warhead.warheadType_0, warhead.enum126_0, (double)((float)(num4 + num3)), (float)num, (float)num2, false, (float)num2, weapon_0.keyValuePair_0.Key);
				base.method_6(false);
				base.method_7();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100555", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00164810 File Offset: 0x00162A10
		private void method_15(Weapon weapon_0, float float_1, float float_2, ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2, ref string string_0)
		{
			if (Debugger.IsAttached)
			{
				bool flag = nullable_0 != null;
				bool flag2 = nullable_1 != null;
			}
			try
			{
				bool flag3 = false;
				if (string.IsNullOrEmpty(string_0))
				{
					IEnumerable<Mount> enumerable = Enumerable.Where<Mount>(((Facility)this.activeUnit_0).vmethod_51(), (Facility_Damage._Closure$__.$I7-0 == null) ? (Facility_Damage._Closure$__.$I7-0 = new Func<Mount, bool>(Facility_Damage._Closure$__.$I.method_2)) : Facility_Damage._Closure$__.$I7-0);
					if (weapon_0.warhead_0.Length > 1)
					{
						int num = weapon_0.warhead_0.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							if (Enumerable.Count<Mount>(enumerable) > 0)
							{
								int num2 = GameGeneral.smethod_5().Next(1, Enumerable.Count<Mount>(enumerable));
								Enumerable.ElementAtOrDefault<Mount>(enumerable, num2 - 1).method_42(weapon_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2);
								if (!Information.IsNothing(enumerable) && Enumerable.Count<Mount>(enumerable) > 0 && Enumerable.Count<Mount>(enumerable) >= num2)
								{
									string_0 = Enumerable.ElementAtOrDefault<Mount>(enumerable, num2 - 1).string_0;
								}
								flag3 = true;
							}
							enumerable = Enumerable.Where<Mount>(((Facility)this.activeUnit_0).vmethod_51(), (Facility_Damage._Closure$__.$I7-1 == null) ? (Facility_Damage._Closure$__.$I7-1 = new Func<Mount, bool>(Facility_Damage._Closure$__.$I.method_3)) : Facility_Damage._Closure$__.$I7-1);
						}
					}
					else if (Enumerable.Count<Mount>(enumerable) > 0)
					{
						int num3 = GameGeneral.smethod_5().Next(1, Enumerable.Count<Mount>(enumerable));
						Enumerable.ElementAtOrDefault<Mount>(enumerable, num3 - 1).method_42(weapon_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2);
						if (!Information.IsNothing(enumerable) && Enumerable.Count<Mount>(enumerable) > 0 && Enumerable.Count<Mount>(enumerable) >= num3)
						{
							string_0 = Enumerable.ElementAtOrDefault<Mount>(enumerable, num3 - 1).string_0;
						}
						flag3 = true;
					}
				}
				else
				{
					Facility_Damage.Class277 @class = new Facility_Damage.Class277(@class);
					@class.string_0 = string_0;
					IEnumerable<Mount> enumerable = Enumerable.Where<Mount>(((Facility)this.activeUnit_0).vmethod_51(), new Func<Mount, bool>(@class.method_0));
					if (Enumerable.Count<Mount>(enumerable) > 0)
					{
						Enumerable.ElementAtOrDefault<Mount>(enumerable, 0).method_42(weapon_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2);
						flag3 = true;
					}
				}
				if (!flag3)
				{
					if (Information.IsNothing(nullable_0))
					{
						nullable_0 = new double?(this.activeUnit_0.vmethod_30(null));
					}
					if (Information.IsNothing(nullable_1))
					{
						nullable_1 = new double?(this.activeUnit_0.vmethod_28(null));
					}
					if (Information.IsNothing(nullable_2))
					{
						nullable_2 = new float?((float)this.activeUnit_0.method_9(true, false, false));
					}
					base.method_3(weapon_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100556", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x00164AF4 File Offset: 0x00162CF4
		public override void vmethod_10(Weapon weapon_0, GeoPoint geoPoint_0, float float_1, float float_2, ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2, ref string string_0)
		{
			Facility_Damage.Class278 @class = new Facility_Damage.Class278();
			@class.facility_Damage_0 = this;
			@class.weapon_0 = weapon_0;
			if (!this.activeUnit_0.method_8())
			{
				try
				{
					bool bool_;
					if (bool_ = ((Facility)this.activeUnit_0).bool_27)
					{
						if (bool_)
						{
							float num = (float)(100.0 * (1.0 - (double)Enumerable.Count<Mount>(Enumerable.Where<Mount>(this.activeUnit_0.vmethod_51(), (Facility_Damage._Closure$__.$I8-0 == null) ? (Facility_Damage._Closure$__.$I8-0 = new Func<Mount, bool>(Facility_Damage._Closure$__.$I.method_4)) : Facility_Damage._Closure$__.$I8-0)) / (double)this.activeUnit_0.vmethod_51().Count));
							if (@class.weapon_0.class394_0.bool_5)
							{
								IEnumerable<Mount> enumerable = Enumerable.Where<Mount>(this.activeUnit_0.vmethod_51(), new Func<Mount, bool>(@class.method_0));
								if (Enumerable.Count<Mount>(enumerable) > 0)
								{
									IEnumerable<Mount> enumerable2 = Enumerable.Where<Mount>(enumerable, (Facility_Damage._Closure$__.$I8-2 == null) ? (Facility_Damage._Closure$__.$I8-2 = new Func<Mount, bool>(Facility_Damage._Closure$__.$I.method_5)) : Facility_Damage._Closure$__.$I8-2);
									if (Enumerable.Count<Mount>(enumerable2) > 0)
									{
										if (Enumerable.Count<Mount>(enumerable2) == 1)
										{
											Enumerable.ElementAtOrDefault<Mount>(enumerable2, 0).method_42(@class.weapon_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2);
										}
										else
										{
											int num2 = GameGeneral.smethod_5().Next(1, Enumerable.Count<Mount>(enumerable2));
											Enumerable.ElementAtOrDefault<Mount>(enumerable2, num2 - 1).method_42(@class.weapon_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2);
										}
									}
									else
									{
										int num3 = GameGeneral.smethod_5().Next(1, Enumerable.Count<Mount>(enumerable));
										Enumerable.ElementAtOrDefault<Mount>(enumerable, num3 - 1).method_42(@class.weapon_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2);
									}
								}
								else
								{
									this.method_15(@class.weapon_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2, ref string_0);
								}
							}
							else
							{
								this.method_15(@class.weapon_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2, ref string_0);
							}
							if (Enumerable.Count<Mount>(Enumerable.Where<Mount>(((Facility)this.activeUnit_0).vmethod_51(), (Facility_Damage._Closure$__.$I8-3 == null) ? (Facility_Damage._Closure$__.$I8-3 = new Func<Mount, bool>(Facility_Damage._Closure$__.$I.method_6)) : Facility_Damage._Closure$__.$I8-3)) == 0 && !this.activeUnit_0.method_82())
							{
								this.activeUnit_0.scenario_0.method_65(this.activeUnit_0);
							}
						}
					}
					else
					{
						base.vmethod_10(@class.weapon_0, geoPoint_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2, ref string_0);
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100557", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00164DB8 File Offset: 0x00162FB8
		public override void vmethod_5(float DamageYield, float theCutOffRange_Frag, int ARM_TargetedRadar = 0)
		{
			if (this.activeUnit_0.enum122_0 == Unit.Enum122.const_0)
			{
				try
				{
					if (((Facility)this.activeUnit_0).armorRating_0 <= GlobalVariables.ArmorRating.None)
					{
						double num = (double)this.activeUnit_0.vmethod_63(false, null);
						if (DamageYield > 0f)
						{
							new WeaponImpact(ref this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_14(false), WeaponImpact.Enum124.const_0, 0);
							this.activeUnit_0.method_124(this.activeUnit_0.Name + " has suffered fragmentation damage: " + Conversions.ToString(Math.Round((double)DamageYield, 1)) + " DPs", this.activeUnit_0.Name + " damaged", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							this.activeUnit_0.vmethod_64(false, null, this.activeUnit_0.vmethod_63(false, null) - DamageYield);
							base.method_5(Warhead.WarheadType.Fragmentation, Warhead.Enum126.const_31, (double)DamageYield, (float)num, 0f, true, 0f, 0);
							base.method_6(true);
							base.method_7();
							if (this.activeUnit_0.vmethod_63(false, null) <= 0f)
							{
								this.activeUnit_0.vmethod_64(false, null, 0f);
								this.activeUnit_0.scenario_0.method_65(this.activeUnit_0);
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100558", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x02000244 RID: 580
		[CompilerGenerated]
		internal sealed class Class277
		{
			// Token: 0x060011F2 RID: 4594 RVA: 0x0000A595 File Offset: 0x00008795
			public Class277(Facility_Damage.Class277 class277_0)
			{
				if (class277_0 != null)
				{
					this.string_0 = class277_0.string_0;
				}
			}

			// Token: 0x060011F3 RID: 4595 RVA: 0x0000A5AC File Offset: 0x000087AC
			internal bool method_0(Mount mount_0)
			{
				return Operators.CompareString(mount_0.string_0, this.string_0, false) == 0;
			}

			// Token: 0x04000CA6 RID: 3238
			public string string_0;
		}

		// Token: 0x02000245 RID: 581
		[CompilerGenerated]
		internal sealed class Class278
		{
			// Token: 0x060011F5 RID: 4597 RVA: 0x0000A5C3 File Offset: 0x000087C3
			internal bool method_0(Mount mount_0)
			{
				return this.facility_Damage_0.method_4(mount_0, this.weapon_0.keyValuePair_0);
			}

			// Token: 0x04000CA7 RID: 3239
			public Weapon weapon_0;

			// Token: 0x04000CA8 RID: 3240
			public Facility_Damage facility_Damage_0;
		}
	}
}
