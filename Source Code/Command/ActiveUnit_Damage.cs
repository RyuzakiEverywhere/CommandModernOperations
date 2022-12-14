using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns11;
using ns12;

namespace Command_Core
{
	// Token: 0x02000140 RID: 320
	public class ActiveUnit_Damage
	{
		// Token: 0x060008C9 RID: 2249 RVA: 0x00093F68 File Offset: 0x00092168
		[CompilerGenerated]
		public static void smethod_0(ActiveUnit_Damage.Delegate16 delegate16_1)
		{
			ActiveUnit_Damage.Delegate16 @delegate = ActiveUnit_Damage.delegate16_0;
			ActiveUnit_Damage.Delegate16 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_Damage.Delegate16 value = (ActiveUnit_Damage.Delegate16)Delegate.Combine(delegate2, delegate16_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_Damage.Delegate16>(ref ActiveUnit_Damage.delegate16_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00093F9C File Offset: 0x0009219C
		public virtual void vmethod_0(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("ActiveUnit_Damage");
				if (this.vmethod_3() > ActiveUnit_Damage.FireIntensityLevel.NoFire)
				{
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Fire";
					byte b = (byte)this.fireIntensityLevel_0;
					xmlWriter.WriteElementString(localName, b.ToString());
				}
				if (this.vmethod_1() > ActiveUnit_Damage.FloodingIntensityLevel.NoFlooding)
				{
					XmlWriter xmlWriter2 = xmlWriter_0;
					string localName2 = "Flood";
					byte b = (byte)this.floodingIntensityLevel_0;
					xmlWriter2.WriteElementString(localName2, b.ToString());
				}
				xmlWriter_0.WriteElementString("TTNSDC", XmlConvert.ToString(this.float_0));
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100109", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00002977 File Offset: 0x00000B77
		private ActiveUnit_Damage()
		{
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00007908 File Offset: 0x00005B08
		public virtual ActiveUnit_Damage.FloodingIntensityLevel vmethod_1()
		{
			return this.floodingIntensityLevel_0;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00094064 File Offset: 0x00092264
		public virtual void vmethod_2(ActiveUnit_Damage.FloodingIntensityLevel floodingIntensityLevel_1)
		{
			try
			{
				if (floodingIntensityLevel_1 != this.floodingIntensityLevel_0)
				{
					this.floodingIntensityLevel_0 = floodingIntensityLevel_1;
					switch (this.floodingIntensityLevel_0)
					{
					case ActiveUnit_Damage.FloodingIntensityLevel.NoFlooding:
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " has sealed all leaks.", this.activeUnit_0.Name + " - All leaks sealed", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Minor:
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " has minor flooding.", this.activeUnit_0.Name + " - Minor flooding", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Major:
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " has major flooding.", this.activeUnit_0.Name + " - Major flooding", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Severe:
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " has severe flooding.", this.activeUnit_0.Name + " - Severe flooding", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Capsizing:
						this.activeUnit_0.method_124("WARNING: " + this.activeUnit_0.Name + " is in danger of capsizing!", this.activeUnit_0.Name + " may capsize!", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100111", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00007910 File Offset: 0x00005B10
		public virtual ActiveUnit_Damage.FireIntensityLevel vmethod_3()
		{
			return this.fireIntensityLevel_0;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00094314 File Offset: 0x00092514
		public virtual void vmethod_4(ActiveUnit_Damage.FireIntensityLevel fireIntensityLevel_1)
		{
			try
			{
				if (fireIntensityLevel_1 != this.fireIntensityLevel_0)
				{
					this.fireIntensityLevel_0 = fireIntensityLevel_1;
					switch (this.fireIntensityLevel_0)
					{
					case ActiveUnit_Damage.FireIntensityLevel.NoFire:
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " has extinguished all fires.", "Damage report", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Minor:
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " has a minor fire.", "Damage report", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Major:
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " has a major fire.", "Damage report", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Severe:
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " has a severe fire.", "Damage report", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Conflagration:
						this.activeUnit_0.method_124("WARNING: " + this.activeUnit_0.Name + " is risking uncontrollable fires!", "Damage report", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100112", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00094574 File Offset: 0x00092774
		public float method_0()
		{
			float result;
			try
			{
				float num = 0f;
				if (this.activeUnit_0.bool_8)
				{
					if (((Facility)this.activeUnit_0).bool_27)
					{
						int num2 = Enumerable.Count<Mount>(Enumerable.Where<Mount>(this.activeUnit_0.vmethod_51(), (ActiveUnit_Damage._Closure$__.$I19-0 == null) ? (ActiveUnit_Damage._Closure$__.$I19-0 = new Func<Mount, bool>(ActiveUnit_Damage._Closure$__.$I.method_0)) : ActiveUnit_Damage._Closure$__.$I19-0));
						if (num2 == 0)
						{
							return 100f;
						}
						num = Math.Max(0f, Math.Min(100f, (float)(100.0 - (double)num2 / (double)this.activeUnit_0.vmethod_51().Count * 100.0)));
					}
					else
					{
						if (this.activeUnit_0.vmethod_63(false, null) == (float)this.activeUnit_0.method_60())
						{
							return 0f;
						}
						num = Math.Max(0f, Math.Min(100f, (float)Math.Round((double)(100f - this.activeUnit_0.vmethod_63(false, null) / (float)this.activeUnit_0.method_60() * 100f), 1)));
					}
				}
				else
				{
					if (this.activeUnit_0.vmethod_63(false, null) == (float)this.activeUnit_0.method_60())
					{
						return 0f;
					}
					num = Math.Max(0f, Math.Min(100f, (float)Math.Round((double)(100f - this.activeUnit_0.vmethod_63(false, null) / (float)this.activeUnit_0.method_60() * 100f), 1)));
				}
				float float_ = this.activeUnit_0.float_15;
				if (float_ == num)
				{
					result = num;
				}
				else
				{
					if (num != float_)
					{
						List<EventTrigger> list = new List<EventTrigger>();
						try
						{
							foreach (EventTrigger eventTrigger in this.activeUnit_0.scenario_0.vmethod_4().Values)
							{
								if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.UnitDamaged && ((Class336)eventTrigger).method_8(this.activeUnit_0, float_, num, null))
								{
									list.Add(eventTrigger);
								}
							}
						}
						finally
						{
							IEnumerator<EventTrigger> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						this.activeUnit_0.scenario_0.method_24(list);
						this.activeUnit_0.float_15 = num;
					}
					result = num;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100113", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = this.activeUnit_0.vmethod_63(false, null);
			}
			return result;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00007918 File Offset: 0x00005B18
		public ActiveUnit_Damage(ref ActiveUnit activeUnit_1)
		{
			this.activeUnit_0 = activeUnit_1;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00094838 File Offset: 0x00092A38
		public virtual void vmethod_5(float DamageYield, float theCutOffRange_Frag, int ARM_TargetedRadar = 0)
		{
			if (this.activeUnit_0.enum122_0 == Unit.Enum122.const_0)
			{
				float targetDP_BeforeDamage = this.activeUnit_0.vmethod_63(false, null);
				try
				{
					if (DamageYield > 0f)
					{
						new WeaponImpact(ref this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_14(false), WeaponImpact.Enum124.const_0, 0);
						if ((int)Math.Round((double)DamageYield) == 0)
						{
							this.activeUnit_0.method_124(this.activeUnit_0.Name + " has suffered minor fragmentation damage", this.activeUnit_0.Name + " damaged", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						}
						else
						{
							this.activeUnit_0.method_124(this.activeUnit_0.Name + " has suffered fragmentation damage: " + Conversions.ToString(Math.Round((double)DamageYield, 1)) + " DPs", this.activeUnit_0.Name + " damaged", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						}
						this.activeUnit_0.vmethod_64(false, null, this.activeUnit_0.vmethod_63(false, null) - DamageYield);
						this.method_5(Warhead.WarheadType.Fragmentation, Warhead.Enum126.const_31, (double)DamageYield, targetDP_BeforeDamage, 0f, true, 0f, ARM_TargetedRadar);
						this.method_6(true);
						this.method_7();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100114", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00094A3C File Offset: 0x00092C3C
		public double method_1(Weapon weapon_0, GeoPoint geoPoint_0)
		{
			this.activeUnit_0.vmethod_63(false, null);
			double result;
			try
			{
				double num = (double)(geoPoint_0.method_13(new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null))) / weapon_0.method_159());
				double num2 = (double)weapon_0.warhead_0[0].float_0 * Math.Pow(1.0 - num, 2.0);
				if (geoPoint_0.imethod_4() <= 12000f || this.activeUnit_0.vmethod_14(false) <= 12000f)
				{
					double num3;
					if (geoPoint_0.imethod_4() < 12000f && this.activeUnit_0.vmethod_14(false) < 12000f)
					{
						num3 = 1.0;
					}
					else
					{
						float num4 = Math.Abs(geoPoint_0.imethod_4() - this.activeUnit_0.vmethod_14(false));
						if (geoPoint_0.imethod_4() > 12000f && this.activeUnit_0.vmethod_14(false) < 12000f)
						{
							num3 = (double)((12000f - this.activeUnit_0.vmethod_14(false)) / num4);
						}
						else
						{
							num3 = (double)((12000f - geoPoint_0.imethod_4()) / num4);
						}
					}
					Weather.WeatherProfile weatherProfile = Weather.smethod_0(this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), (int)Math.Round((double)this.activeUnit_0.vmethod_14(false)));
					double num5 = (double)(1f - weatherProfile.method_3());
					float num6 = weatherProfile.float_0;
					double num7;
					if (num6 > 40f)
					{
						num7 = 0.05;
					}
					else if (num6 > 30f)
					{
						num7 = 0.1;
					}
					else if (num6 > 20f)
					{
						num7 = 0.25;
					}
					else if (num6 > 10f)
					{
						num7 = 0.5;
					}
					else if (num6 > 0f)
					{
						num7 = 0.75;
					}
					else
					{
						num7 = 1.0;
					}
					double num8 = num5 * num7;
					if (num3 < 1.0 && num8 < 1.0)
					{
						num8 *= 1.0 - num3;
					}
					num2 *= num8;
				}
				result = num2;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 10011205314", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0.0;
			}
			return result;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00094CEC File Offset: 0x00092EEC
		public virtual void vmethod_6(float float_1, Warhead.WarheadType warheadType_0, Warhead.Enum126 enum126_0, Weapon.Enum128 enum128_0)
		{
			if (this.activeUnit_0.enum122_0 == Unit.Enum122.const_0)
			{
				float targetDP_BeforeDamage = this.activeUnit_0.vmethod_63(false, null);
				try
				{
					if (this.activeUnit_0.vmethod_59() && enum128_0 == Weapon.Enum128.const_2)
					{
						float_1 = (float)((double)float_1 * 0.1);
					}
					this.vmethod_8(ref float_1);
					if (Math.Round((double)float_1, 1) > 0.0)
					{
						new WeaponImpact(ref this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_14(false), WeaponImpact.Enum124.const_0, 0);
						bool flag = this.activeUnit_0.vmethod_99().Length > 0 && this.activeUnit_0.vmethod_99().Length == Enumerable.Count<AirFacility>(Enumerable.Where<AirFacility>(this.activeUnit_0.vmethod_99(), (ActiveUnit_Damage._Closure$__.$I23-0 == null) ? (ActiveUnit_Damage._Closure$__.$I23-0 = new Func<AirFacility, bool>(ActiveUnit_Damage._Closure$__.$I.method_1)) : ActiveUnit_Damage._Closure$__.$I23-0));
						if (!this.activeUnit_0.method_5() || !flag)
						{
							if (!this.activeUnit_0.bool_2)
							{
								this.activeUnit_0.method_124(Misc.smethod_9(this.activeUnit_0.Name) + " has suffered blast damage: " + Conversions.ToString(Math.Round((double)float_1, 1)) + " DPs", this.activeUnit_0.Name + " damaged", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							}
							this.activeUnit_0.vmethod_64(false, null, this.activeUnit_0.vmethod_63(false, null) - float_1);
							this.method_5(warheadType_0, enum126_0, (double)float_1, targetDP_BeforeDamage, 0f, true, 0f, 0);
						}
						this.method_6(true);
						this.method_7();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100115", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00094F2C File Offset: 0x0009312C
		public void method_2(float float_1, Warhead.WarheadType warheadType_0, Warhead.Enum126 enum126_0, float float_2)
		{
			if (float_1 != 0f && this.activeUnit_0.enum122_0 == Unit.Enum122.const_0)
			{
				try
				{
					float targetDP_BeforeDamage = this.activeUnit_0.vmethod_63(false, null);
					this.vmethod_7(ref float_1, warheadType_0);
					if (Math.Round((double)float_1, 1) > 0.0)
					{
						new WeaponImpact(ref this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_14(false), WeaponImpact.Enum124.const_0, 0);
						this.activeUnit_0.method_124(Misc.smethod_9(this.activeUnit_0.Name) + " has suffered bomblet damage: " + Conversions.ToString(Math.Round((double)float_1, 1)) + " DPs", this.activeUnit_0.Name + " damaged", LoggedMessage.MessageType.UnitDamage, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						this.activeUnit_0.vmethod_64(false, null, this.activeUnit_0.vmethod_63(false, null) - float_1);
						this.method_5(warheadType_0, enum126_0, (double)float_1, targetDP_BeforeDamage, 0f, true, 0f, 0);
						this.method_6(true);
						this.method_7();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100116", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0000710A File Offset: 0x0000530A
		public virtual void vmethod_7(ref float float_1, Warhead.WarheadType warheadType_0)
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0000378C File Offset: 0x0000198C
		public virtual void vmethod_8(ref float float_1)
		{
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0000710A File Offset: 0x0000530A
		protected virtual void vmethod_9(Weapon weapon_0, GeoPoint geoPoint_0, float float_1, float float_2, ref ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2)
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x000950DC File Offset: 0x000932DC
		public virtual void vmethod_10(Weapon weapon_0, GeoPoint geoPoint_0, float float_1, float float_2, ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2, ref string string_0)
		{
			ActiveUnit_Damage.Class189 @class = new ActiveUnit_Damage.Class189();
			@class.weapon_0 = weapon_0;
			if (!this.activeUnit_0.method_8())
			{
				try
				{
					if (@class.weapon_0.warhead_0.Length != 0)
					{
						if (float_1 == 0f)
						{
							if (this.activeUnit_0.enum122_0 == Unit.Enum122.const_0)
							{
								this.vmethod_9(@class.weapon_0, geoPoint_0, float_1, float_2, ref activeUnit_1, nullable_0, nullable_1, nullable_2);
							}
						}
						else
						{
							float float_3 = this.activeUnit_0.vmethod_63(false, null);
							if (@class.weapon_0.class394_0.bool_5 && !Information.IsNothing(@class.weapon_0.keyValuePair_0))
							{
								IEnumerable<Sensor> enumerable = Enumerable.Where<Sensor>(this.activeUnit_0.method_78(), new Func<Sensor, bool>(@class.method_0));
								if (Enumerable.Count<Sensor>(enumerable) > 0)
								{
									int num = GameGeneral.smethod_5().Next(0, Enumerable.Count<Sensor>(enumerable));
									this.method_8(@class.weapon_0.warhead_0[0].warheadType_0, @class.weapon_0.warhead_0[0].enum126_0, Enumerable.ElementAtOrDefault<Sensor>(enumerable, num), (double)@class.weapon_0.warhead_0[0].float_0, float_3, @class.weapon_0.keyValuePair_0.Key, 0f);
								}
							}
							this.method_3(@class.weapon_0, float_1, float_2, activeUnit_1, nullable_0, nullable_1, nullable_2);
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100117", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00095294 File Offset: 0x00093494
		public void method_3(Weapon weapon_0, float float_1, float float_2, ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2)
		{
			if (Debugger.IsAttached)
			{
				bool flag = nullable_0 != null;
				bool flag2 = nullable_1 != null;
			}
			Warhead warhead = weapon_0.warhead_0[0];
			if (warhead.method_11() || warhead.method_12())
			{
				if (Information.IsNothing(nullable_2))
				{
					if (weapon_0.method_187().method_47() && weapon_0.method_187().method_4()[0].imethod_4() > 4000f)
					{
						nullable_2 = new float?((float)((int)Math.Round((double)weapon_0.vmethod_14(false))));
					}
					else
					{
						nullable_2 = new float?((float)((int)Math.Round((double)weapon_0.vmethod_16())));
					}
				}
				if (Information.IsNothing(nullable_0) || Information.IsNothing(nullable_1))
				{
					double value;
					double value2;
					Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref value, ref value2, (double)(float_1 / 1852f), (double)float_2);
					nullable_0 = new double?(value2);
					nullable_1 = new double?(value);
				}
				new Explosion(ref this.activeUnit_0.scenario_0, nullable_1.Value, nullable_0.Value, nullable_1.Value, nullable_0.Value, weapon_0.vmethod_9(), nullable_2.Value, weapon_0.method_167(), warhead.float_0, warhead.float_0, warhead.warheadType_0, warhead.enum126_0, null, null, activeUnit_1, null, null, 0, 0, 0, 0f, 0);
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0000378C File Offset: 0x0000198C
		public virtual void vmethod_11(float float_1, Warhead.WarheadType warheadType_0, float float_2)
		{
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00095410 File Offset: 0x00093610
		public bool method_4(Mount mount_0, KeyValuePair<int, EmissionContainer> keyValuePair_0)
		{
			ActiveUnit_Damage.Class190 @class = new ActiveUnit_Damage.Class190();
			@class.keyValuePair_0 = keyValuePair_0;
			bool result;
			try
			{
				result = (Enumerable.Count<Sensor>(Enumerable.Where<Sensor>(Enumerable.Select<Sensor, Sensor>(mount_0.method_36(), (ActiveUnit_Damage._Closure$__.$I31-0 == null) ? (ActiveUnit_Damage._Closure$__.$I31-0 = new Func<Sensor, Sensor>(ActiveUnit_Damage._Closure$__.$I.method_2)) : ActiveUnit_Damage._Closure$__.$I31-0), new Func<Sensor, bool>(@class.method_0))) > 0);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100118", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x000954C0 File Offset: 0x000936C0
		protected void method_5(Warhead.WarheadType theWarheadType, Warhead.Enum126 theWarheadExplosivesType, double theDamage, float TargetDP_BeforeDamage, float thePenetration, bool IsAreaEffect, float PenetrationFactor, int ARM_TargetedRadar = 0)
		{
			try
			{
				int num = this.method_11(theDamage, theWarheadType, TargetDP_BeforeDamage, thePenetration, ARM_TargetedRadar);
				bool flag = ARM_TargetedRadar == 0;
				if (num > this.activeUnit_0.vmethod_120().Count)
				{
					num = this.activeUnit_0.vmethod_120().Count;
				}
				if (num > 0)
				{
					int num2 = num;
					for (int i = 1; i <= num2; i++)
					{
						PlatformComponent platformComponent = this.vmethod_13(ARM_TargetedRadar, flag);
						if (!Information.IsNothing(platformComponent) && !string.IsNullOrEmpty(platformComponent.Name) && platformComponent.method_10() && ((Sensor)platformComponent).method_98())
						{
							platformComponent = null;
						}
						if (!Information.IsNothing(platformComponent))
						{
							this.method_8(theWarheadType, theWarheadExplosivesType, platformComponent, theDamage, TargetDP_BeforeDamage, ARM_TargetedRadar, PenetrationFactor);
						}
						if (!flag)
						{
							flag = true;
						}
					}
				}
				this.vmethod_11((float)theDamage, theWarheadType, thePenetration);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100119", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x000955C8 File Offset: 0x000937C8
		protected void method_6(bool bool_0)
		{
			if (bool_0)
			{
				foreach (AirFacility airFacility in this.activeUnit_0.vmethod_99())
				{
					if (airFacility.method_33())
					{
						double num = GameGeneral.smethod_5().NextDouble();
						PlatformComponent._DamageSeverityFactor damageSeverityFactor;
						if (num > 0.7)
						{
							damageSeverityFactor = PlatformComponent._DamageSeverityFactor.Heavy;
						}
						else if (num > 0.3)
						{
							damageSeverityFactor = PlatformComponent._DamageSeverityFactor.Medium;
						}
						else
						{
							damageSeverityFactor = PlatformComponent._DamageSeverityFactor.Light;
						}
						if (this.activeUnit_0.bool_8 && (((Facility)this.activeUnit_0)._FacilityCategory_0 == Facility._FacilityCategory.Building_Reveted || ((Facility)this.activeUnit_0)._FacilityCategory_0 == Facility._FacilityCategory.Structure_Reveted) && damageSeverityFactor != PlatformComponent._DamageSeverityFactor.Light)
						{
							damageSeverityFactor = (PlatformComponent._DamageSeverityFactor)(damageSeverityFactor - PlatformComponent._DamageSeverityFactor.Medium);
						}
						airFacility.method_26(damageSeverityFactor, 0f);
					}
				}
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00095688 File Offset: 0x00093888
		protected void method_7()
		{
			ActiveUnit_Damage.Delegate16 @delegate = ActiveUnit_Damage.delegate16_0;
			if (@delegate != null)
			{
				@delegate(this.activeUnit_0);
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x000956AC File Offset: 0x000938AC
		public void method_8(Warhead.WarheadType warheadType_0, Warhead.Enum126 enum126_0, PlatformComponent platformComponent_0, double double_0, float float_1, int int_0, float float_2)
		{
			int num = GameGeneral.smethod_5().Next(1, 101);
			try
			{
				if (num < 10 && platformComponent_0.method_10() && int_0 == platformComponent_0.DBID)
				{
					num = 10;
				}
				GlobalVariables.ArmorRating armorRating = GlobalVariables.ArmorRating.None;
				if (platformComponent_0.method_8())
				{
					armorRating = ((Mount)platformComponent_0).armorRating_0;
				}
				if (platformComponent_0.method_9())
				{
					armorRating = ((Magazine)platformComponent_0).armorRating_0;
				}
				if (armorRating == GlobalVariables.ArmorRating.None && platformComponent_0.method_11())
				{
					switch (platformComponent_0.method_18().vmethod_56())
					{
					case GlobalVariables.ActiveUnitType.Aircraft:
						armorRating = ((Aircraft)platformComponent_0.method_18()).armorRating_1;
						break;
					case GlobalVariables.ActiveUnitType.Ship:
						armorRating = ((Ship)platformComponent_0.method_18()).armorRating_4;
						break;
					case GlobalVariables.ActiveUnitType.Submarine:
						armorRating = GlobalVariables.ArmorRating.Heavy;
						break;
					case GlobalVariables.ActiveUnitType.Facility:
						armorRating = ((Facility)platformComponent_0.method_18()).armorRating_0;
						break;
					}
				}
				if (armorRating != GlobalVariables.ArmorRating.None)
				{
					switch (armorRating)
					{
					case GlobalVariables.ArmorRating.Light:
						if (enum126_0 <= Warhead.Enum126.const_36)
						{
							if (enum126_0 == Warhead.Enum126.const_31 || enum126_0 == Warhead.Enum126.const_36)
							{
								goto IL_140;
							}
						}
						else
						{
							if (enum126_0 == Warhead.Enum126.const_51 || enum126_0 == Warhead.Enum126.const_53)
							{
								goto IL_140;
							}
							if (enum126_0 == Warhead.Enum126.const_54)
							{
								goto IL_140;
							}
						}
						num -= 10;
						break;
						IL_140:
						num -= 90;
						break;
					case GlobalVariables.ArmorRating.Medium:
						if (enum126_0 <= Warhead.Enum126.const_37)
						{
							if (enum126_0 <= Warhead.Enum126.const_27)
							{
								if (enum126_0 - Warhead.Enum126.const_24 > 1 && enum126_0 != Warhead.Enum126.const_27)
								{
									goto IL_1D6;
								}
							}
							else
							{
								if (enum126_0 == Warhead.Enum126.const_31 || enum126_0 == Warhead.Enum126.const_36)
								{
									goto IL_1E0;
								}
								if (enum126_0 != Warhead.Enum126.const_37)
								{
									goto IL_1D6;
								}
							}
						}
						else if (enum126_0 <= Warhead.Enum126.const_47)
						{
							if (enum126_0 != Warhead.Enum126.const_43 && enum126_0 != Warhead.Enum126.const_47)
							{
								goto IL_1D6;
							}
						}
						else
						{
							if (enum126_0 == Warhead.Enum126.const_51 || enum126_0 == Warhead.Enum126.const_53)
							{
								goto IL_1E0;
							}
							if (enum126_0 == Warhead.Enum126.const_54)
							{
								goto IL_1E0;
							}
							goto IL_1D6;
						}
						num -= 90;
						break;
						IL_1D6:
						num -= 30;
						break;
						IL_1E0:
						num = 0;
						break;
					case GlobalVariables.ArmorRating.Heavy:
						if (enum126_0 <= Warhead.Enum126.const_38)
						{
							if (enum126_0 <= Warhead.Enum126.const_27)
							{
								if (enum126_0 - Warhead.Enum126.const_24 > 1)
								{
									if (enum126_0 == Warhead.Enum126.const_26)
									{
										goto IL_29B;
									}
									if (enum126_0 != Warhead.Enum126.const_27)
									{
										goto IL_2B9;
									}
								}
							}
							else
							{
								if (enum126_0 == Warhead.Enum126.const_28)
								{
									goto IL_29B;
								}
								if (enum126_0 == Warhead.Enum126.const_31)
								{
									goto IL_2C3;
								}
								switch (enum126_0)
								{
								case Warhead.Enum126.const_36:
									goto IL_2C3;
								case Warhead.Enum126.const_37:
									break;
								case Warhead.Enum126.const_38:
									goto IL_29B;
								default:
									goto IL_2B9;
								}
							}
						}
						else if (enum126_0 <= Warhead.Enum126.const_47)
						{
							if (enum126_0 != Warhead.Enum126.const_43)
							{
								if (enum126_0 == Warhead.Enum126.const_44)
								{
									goto IL_29B;
								}
								if (enum126_0 != Warhead.Enum126.const_47)
								{
									goto IL_2B9;
								}
							}
						}
						else if (enum126_0 <= Warhead.Enum126.const_51)
						{
							if (enum126_0 == Warhead.Enum126.const_48)
							{
								goto IL_29B;
							}
							if (enum126_0 != Warhead.Enum126.const_51)
							{
								goto IL_2B9;
							}
							goto IL_2C3;
						}
						else
						{
							if (enum126_0 == Warhead.Enum126.const_53)
							{
								goto IL_2C3;
							}
							if (enum126_0 == Warhead.Enum126.const_54)
							{
								goto IL_2C3;
							}
							goto IL_2B9;
						}
						num = 0;
						break;
						IL_29B:
						num -= 90;
						break;
						IL_2B9:
						num -= 50;
						break;
						IL_2C3:
						num = 0;
						break;
					case GlobalVariables.ArmorRating.Special:
						if (enum126_0 <= Warhead.Enum126.const_39)
						{
							if (enum126_0 <= Warhead.Enum126.const_26)
							{
								if (enum126_0 - Warhead.Enum126.const_24 > 1)
								{
									if (enum126_0 != Warhead.Enum126.const_26)
									{
										goto IL_3AB;
									}
									goto IL_383;
								}
							}
							else
							{
								switch (enum126_0)
								{
								case Warhead.Enum126.const_27:
									break;
								case Warhead.Enum126.const_28:
									goto IL_383;
								case Warhead.Enum126.const_29:
									goto IL_387;
								default:
									if (enum126_0 == Warhead.Enum126.const_31)
									{
										goto IL_3B2;
									}
									switch (enum126_0)
									{
									case Warhead.Enum126.const_36:
										goto IL_3B2;
									case Warhead.Enum126.const_37:
										break;
									case Warhead.Enum126.const_38:
										goto IL_383;
									case Warhead.Enum126.const_39:
										goto IL_387;
									default:
										goto IL_3AB;
									}
									break;
								}
							}
						}
						else if (enum126_0 <= Warhead.Enum126.const_49)
						{
							switch (enum126_0)
							{
							case Warhead.Enum126.const_43:
								break;
							case Warhead.Enum126.const_44:
								goto IL_383;
							case Warhead.Enum126.const_45:
								goto IL_387;
							default:
								switch (enum126_0)
								{
								case Warhead.Enum126.const_47:
									break;
								case Warhead.Enum126.const_48:
									goto IL_383;
								case Warhead.Enum126.const_49:
									goto IL_387;
								default:
									goto IL_3AB;
								}
								break;
							}
						}
						else
						{
							if (enum126_0 == Warhead.Enum126.const_51 || enum126_0 == Warhead.Enum126.const_53)
							{
								goto IL_3B2;
							}
							if (enum126_0 == Warhead.Enum126.const_54)
							{
								goto IL_3B2;
							}
							goto IL_3AB;
						}
						num = 0;
						break;
						IL_383:
						num = 0;
						break;
						IL_387:
						num -= 90;
						break;
						IL_3AB:
						num -= 70;
						break;
						IL_3B2:
						num = 0;
						break;
					}
				}
				string string_;
				if (platformComponent_0.GetType() == typeof(Cargo))
				{
					if (((Cargo)platformComponent_0).method_23() == Cargo.Enum111.const_1)
					{
						string_ = "[Cargo] " + ((Mount)((Cargo)platformComponent_0).method_25()).Name;
					}
					else
					{
						string_ = platformComponent_0.Name;
					}
				}
				else
				{
					string_ = platformComponent_0.Name;
				}
				int num2 = num;
				PlatformComponent._DamageSeverityFactor damageSeverityFactor_;
				if (num2 >= 10)
				{
					if (num2 < 30)
					{
						if (platformComponent_0.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
						{
							if (!this.activeUnit_0.bool_2)
							{
								this.activeUnit_0.scenario_0.method_59(Misc.smethod_9(this.activeUnit_0.Name) + " damage report: " + Misc.smethod_9(string_) + " has been lightly damaged.", this.activeUnit_0.Name + " has component damage", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							}
						}
						else if (!this.activeUnit_0.bool_2)
						{
							this.activeUnit_0.scenario_0.method_59(Misc.smethod_9(this.activeUnit_0.Name) + " damage report: " + Misc.smethod_9(string_) + " has suffered additional light damage.", this.activeUnit_0.Name + " has component damage", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						}
						damageSeverityFactor_ = PlatformComponent._DamageSeverityFactor.Light;
						if (platformComponent_0.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
						{
							platformComponent_0.vmethod_8(PlatformComponent._DamageSeverityFactor.Light);
						}
					}
					else if (num2 < 40)
					{
						if (platformComponent_0.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
						{
							if (!this.activeUnit_0.bool_2)
							{
								this.activeUnit_0.scenario_0.method_59(Misc.smethod_9(this.activeUnit_0.Name) + " damage report: " + Misc.smethod_9(string_) + " has been moderately damaged.", this.activeUnit_0.Name + " has component damage", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							}
						}
						else if (!this.activeUnit_0.bool_2)
						{
							this.activeUnit_0.scenario_0.method_59(Misc.smethod_9(this.activeUnit_0.Name) + " damage report: " + Misc.smethod_9(string_) + " has suffered additional moderate damage.", this.activeUnit_0.Name + " has component damage", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						}
						damageSeverityFactor_ = PlatformComponent._DamageSeverityFactor.Medium;
						if (platformComponent_0.vmethod_5() == PlatformComponent._ComponentStatus.Operational || (platformComponent_0.vmethod_5() == PlatformComponent._ComponentStatus.Damaged && platformComponent_0.method_16() < PlatformComponent._DamageSeverityFactor.Medium))
						{
							platformComponent_0.vmethod_8(PlatformComponent._DamageSeverityFactor.Medium);
						}
					}
					else if (num2 < 70)
					{
						if (platformComponent_0.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
						{
							if (!this.activeUnit_0.bool_2)
							{
								this.activeUnit_0.scenario_0.method_59(Misc.smethod_9(this.activeUnit_0.Name) + " damage report: " + Misc.smethod_9(string_) + " has been heavily damaged.", this.activeUnit_0.Name + " has component damage", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							}
						}
						else if (!this.activeUnit_0.bool_2)
						{
							this.activeUnit_0.scenario_0.method_59(Misc.smethod_9(this.activeUnit_0.Name) + " damage report: " + Misc.smethod_9(string_) + " has suffered additional heavy damage.", this.activeUnit_0.Name + " has component damage", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						}
						damageSeverityFactor_ = PlatformComponent._DamageSeverityFactor.Heavy;
						if (platformComponent_0.vmethod_5() == PlatformComponent._ComponentStatus.Operational || (platformComponent_0.vmethod_5() == PlatformComponent._ComponentStatus.Damaged && platformComponent_0.method_16() < PlatformComponent._DamageSeverityFactor.Heavy))
						{
							platformComponent_0.vmethod_8(PlatformComponent._DamageSeverityFactor.Heavy);
						}
					}
					else if (platformComponent_0.method_11() && ((AirFacility)platformComponent_0).method_33())
					{
						if (platformComponent_0.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
						{
							if (!this.activeUnit_0.bool_2)
							{
								this.activeUnit_0.scenario_0.method_59(Misc.smethod_9(this.activeUnit_0.Name) + " damage report: " + Misc.smethod_9(string_) + " has been heavily damaged.", this.activeUnit_0.Name + " has component damage", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							}
						}
						else if (!this.activeUnit_0.bool_2)
						{
							this.activeUnit_0.scenario_0.method_59(Misc.smethod_9(this.activeUnit_0.Name) + " damage report: " + Misc.smethod_9(string_) + " has suffered additional heavy damage.", this.activeUnit_0.Name + " has component damage", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						}
						damageSeverityFactor_ = PlatformComponent._DamageSeverityFactor.Heavy;
						platformComponent_0.vmethod_8(PlatformComponent._DamageSeverityFactor.Heavy);
					}
					else
					{
						if (platformComponent_0.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
						{
							if (!this.activeUnit_0.bool_2)
							{
								this.activeUnit_0.scenario_0.method_59(Misc.smethod_9(this.activeUnit_0.Name) + " damage report: " + Misc.smethod_9(string_) + " has been destroyed!", this.activeUnit_0.Name + " lost a component", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							}
						}
						else if (!this.activeUnit_0.bool_2)
						{
							this.activeUnit_0.scenario_0.method_59(Misc.smethod_9(this.activeUnit_0.Name) + " damage report: " + Misc.smethod_9(string_) + " has suffered additional damage!", this.activeUnit_0.Name + " lost a component", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						}
						if (platformComponent_0.vmethod_5() < PlatformComponent._ComponentStatus.Destroyed)
						{
							platformComponent_0.vmethod_6(this.activeUnit_0.vmethod_7(false), false, false);
						}
					}
				}
				if (platformComponent_0.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed && platformComponent_0.method_11())
				{
					((AirFacility)platformComponent_0).method_26(damageSeverityFactor_, float_2);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100120", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x000962BC File Offset: 0x000944BC
		public virtual void vmethod_12(float float_1)
		{
			try
			{
				float num;
				switch (this.vmethod_3())
				{
				case ActiveUnit_Damage.FireIntensityLevel.Minor:
					num = (float)((double)this.activeUnit_0.method_60() * 0.04 * (double)(float_1 / 3600f));
					break;
				case ActiveUnit_Damage.FireIntensityLevel.Major:
					num = (float)((double)this.activeUnit_0.method_60() * 0.08 * (double)(float_1 / 3600f));
					break;
				case ActiveUnit_Damage.FireIntensityLevel.Severe:
					num = (float)((double)this.activeUnit_0.method_60() * 0.12 * (double)(float_1 / 3600f));
					break;
				case ActiveUnit_Damage.FireIntensityLevel.Conflagration:
				{
					num = (float)((double)this.activeUnit_0.method_60() * 0.24 * (double)(float_1 / 3600f));
					bool flag = Enumerable.Any<AirFacility>(Enumerable.Where<AirFacility>(this.activeUnit_0.vmethod_99(), (ActiveUnit_Damage._Closure$__.$I37-0 == null) ? (ActiveUnit_Damage._Closure$__.$I37-0 = new Func<AirFacility, bool>(ActiveUnit_Damage._Closure$__.$I.method_3)) : ActiveUnit_Damage._Closure$__.$I37-0));
					if ((!this.activeUnit_0.bool_8 || !flag) && GameGeneral.smethod_5().Next(1, 101) <= 5)
					{
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " has fires raging out of control and is disintegrating!!!", this.activeUnit_0.Name + " is burning up!!!", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						if (this.activeUnit_0.bool_6)
						{
							if (((Ship)this.activeUnit_0).method_152())
							{
								this.activeUnit_0.scenario_0.method_65(this.activeUnit_0);
							}
							else
							{
								this.activeUnit_0.vmethod_64(false, null, Math.Min(this.activeUnit_0.vmethod_63(false, null), -1f));
							}
						}
						else
						{
							this.activeUnit_0.scenario_0.method_65(this.activeUnit_0);
						}
						return;
					}
					break;
				}
				}
				float num2;
				switch (this.vmethod_1())
				{
				case ActiveUnit_Damage.FloodingIntensityLevel.Minor:
					num2 = (float)((double)this.activeUnit_0.method_60() * 0.04 * (double)(float_1 / 3600f));
					break;
				case ActiveUnit_Damage.FloodingIntensityLevel.Major:
					num2 = (float)((double)this.activeUnit_0.method_60() * 0.08 * (double)(float_1 / 3600f));
					break;
				case ActiveUnit_Damage.FloodingIntensityLevel.Severe:
					num2 = (float)((double)this.activeUnit_0.method_60() * 0.12 * (double)(float_1 / 3600f));
					break;
				case ActiveUnit_Damage.FloodingIntensityLevel.Capsizing:
					num2 = (float)((double)this.activeUnit_0.method_60() * 0.24 * (double)(float_1 / 3600f));
					if (this.activeUnit_0.bool_6 && GameGeneral.smethod_5().Next(1, 101) <= 5)
					{
						this.activeUnit_0.method_124(this.activeUnit_0.Name + " is capsizing - abandoning ship!!!", this.activeUnit_0.Name + " is capsizing!!!", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						if (((Ship)this.activeUnit_0).method_152())
						{
							this.activeUnit_0.scenario_0.method_65(this.activeUnit_0);
						}
						else
						{
							this.activeUnit_0.vmethod_64(false, null, Math.Min(this.activeUnit_0.vmethod_63(false, null), -1f));
						}
						return;
					}
					break;
				}
				if (num + num2 > 0f)
				{
					this.activeUnit_0.vmethod_64(false, null, this.activeUnit_0.vmethod_63(false, null) - (num + num2));
				}
				this.float_0 -= float_1;
				if (this.float_0 <= 0f)
				{
					if (num + num2 != 0f)
					{
						if (this.vmethod_3() > ActiveUnit_Damage.FireIntensityLevel.NoFire)
						{
							byte b = (byte)GameGeneral.smethod_5().Next(1, 11);
							GlobalVariables.ProficiencyLevel? proficiencyLevel = this.activeUnit_0.vmethod_53();
							int? num3 = (proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								b += 3;
							}
							else
							{
								num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									b += 2;
								}
								else
								{
									num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
									if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										b += 1;
									}
									else
									{
										num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
										if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
											if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
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
									goto IL_654;
								case 5:
								case 6:
								case 7:
								case 8:
									goto IL_654;
								case 9:
								case 10:
									break;
								default:
									goto IL_654;
								}
							}
							if (this.vmethod_3() != ActiveUnit_Damage.FireIntensityLevel.Conflagration)
							{
								this.vmethod_4(this.vmethod_3() + 1);
							}
						}
						IL_654:
						if (this.vmethod_1() > ActiveUnit_Damage.FloodingIntensityLevel.NoFlooding)
						{
							byte b2 = (byte)GameGeneral.smethod_5().Next(1, 11);
							GlobalVariables.ProficiencyLevel? proficiencyLevel2 = this.activeUnit_0.vmethod_53();
							int? num3 = (proficiencyLevel2 != null) ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								b2 += 3;
							}
							else
							{
								num3 = ((proficiencyLevel2 != null) ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
								if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									b2 += 2;
								}
								else
								{
									num3 = ((proficiencyLevel2 != null) ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
									if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										b2 += 1;
									}
									else
									{
										num3 = ((proficiencyLevel2 != null) ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
										if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											num3 = ((proficiencyLevel2 != null) ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
											if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
											{
												b2 = (byte)Math.Max(0, (int)(b2 - 2));
											}
										}
									}
								}
							}
							b2 = (byte)Math.Max(0, (int)b2);
							if (b2 <= 10)
							{
								switch (b2)
								{
								case 1:
								case 2:
								case 3:
								case 4:
									this.vmethod_2((ActiveUnit_Damage.FloodingIntensityLevel)Math.Max(0, (int)(this.vmethod_1() - ActiveUnit_Damage.FloodingIntensityLevel.Minor)));
									goto IL_8C1;
								case 5:
								case 6:
								case 7:
								case 8:
									goto IL_8C1;
								case 9:
								case 10:
									break;
								default:
									goto IL_8C1;
								}
							}
							if (this.vmethod_1() != ActiveUnit_Damage.FloodingIntensityLevel.Capsizing)
							{
								this.vmethod_2(this.vmethod_1() + 1);
							}
						}
						IL_8C1:
						this.float_0 = (float)GameGeneral.smethod_5().Next(900, 1801);
					}
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

		// Token: 0x060008E2 RID: 2274 RVA: 0x00096C00 File Offset: 0x00094E00
		protected void method_9(ActiveUnit_Damage.FloodingIntensityLevel floodingIntensityLevel_1)
		{
			try
			{
				if (floodingIntensityLevel_1 > this.vmethod_1())
				{
					this.vmethod_2(floodingIntensityLevel_1);
				}
				else if (floodingIntensityLevel_1 == this.vmethod_1() && this.vmethod_1() != ActiveUnit_Damage.FloodingIntensityLevel.Capsizing)
				{
					double num;
					switch (floodingIntensityLevel_1)
					{
					case ActiveUnit_Damage.FloodingIntensityLevel.Minor:
						num = 0.5;
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Major:
						num = 0.25;
						break;
					case ActiveUnit_Damage.FloodingIntensityLevel.Severe:
						num = 0.1;
						break;
					}
					if (GameGeneral.smethod_5().NextDouble() < num)
					{
						this.vmethod_2(this.vmethod_1() + 1);
					}
				}
				this.float_0 = (float)GameGeneral.smethod_5().Next(120, 181);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100122", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00096CE8 File Offset: 0x00094EE8
		public void method_10(ActiveUnit_Damage.FireIntensityLevel fireIntensityLevel_1)
		{
			try
			{
				if (fireIntensityLevel_1 > this.vmethod_3())
				{
					this.vmethod_4(fireIntensityLevel_1);
				}
				else if (fireIntensityLevel_1 == this.vmethod_3() && this.vmethod_3() != ActiveUnit_Damage.FireIntensityLevel.Conflagration)
				{
					double num;
					switch (fireIntensityLevel_1)
					{
					case ActiveUnit_Damage.FireIntensityLevel.Minor:
						num = 0.5;
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Major:
						num = 0.25;
						break;
					case ActiveUnit_Damage.FireIntensityLevel.Severe:
						num = 0.1;
						break;
					}
					if (GameGeneral.smethod_5().NextDouble() < num)
					{
						this.vmethod_4(this.vmethod_3() + 1);
					}
				}
				this.float_0 = (float)GameGeneral.smethod_5().Next(120, 181);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100123", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00096DD0 File Offset: 0x00094FD0
		protected virtual PlatformComponent vmethod_13(int ARM_SpecifiedEmission = 0, bool ARM_ResolvedHitOnTargetedRadar = false)
		{
			PlatformComponent result;
			try
			{
				if (!ARM_ResolvedHitOnTargetedRadar && ARM_SpecifiedEmission > 0)
				{
					List<PlatformComponent> list = new List<PlatformComponent>();
					try
					{
						foreach (PlatformComponent platformComponent in this.activeUnit_0.vmethod_120())
						{
							if (platformComponent.method_10() && (((Sensor)platformComponent).DBID == ARM_SpecifiedEmission || (int)((Sensor)platformComponent).short_0 == ARM_SpecifiedEmission))
							{
								list.Add(platformComponent);
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
					if (list.Count > 0)
					{
						int index = GameGeneral.smethod_5().Next(0, list.Count);
						return list[index];
					}
				}
				float num = (float)(1.0 / (double)this.activeUnit_0.vmethod_120().Count);
				if (num < 5f)
				{
					num = 5f;
				}
				int num2;
				PlatformComponent platformComponent2;
				float num3;
				do
				{
					num2 = GameGeneral.smethod_5().Next(0, this.activeUnit_0.vmethod_120().Count);
					platformComponent2 = this.activeUnit_0.vmethod_120()[num2];
					if (!platformComponent2.method_10() && !platformComponent2.method_8() && !platformComponent2.method_12())
					{
						if (platformComponent2.method_11())
						{
							if (((AirFacility)platformComponent2).method_33())
							{
								num3 = num * 3f;
							}
							else
							{
								num3 = num / 3f;
							}
						}
						else
						{
							num3 = num / 3f;
						}
					}
					else
					{
						num3 = 2f * num;
					}
					if ((double)num3 > 0.9)
					{
						num3 = 0.9f;
					}
					num2 = GameGeneral.smethod_5().Next(1, 101);
				}
				while ((double)num2 / 100.0 >= (double)num3);
				result = platformComponent2;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100124", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00096FF0 File Offset: 0x000951F0
		protected int method_11(double ShockDamage, Warhead.WarheadType WarheadType, float TargetDP, float PenetrationPercentage, int ARM_TargetedRadar = 0)
		{
			int result;
			try
			{
				float num = (float)Math.Round(ShockDamage / (double)TargetDP, 2);
				if (this.activeUnit_0.vmethod_120().Count == 0)
				{
					result = 0;
				}
				else
				{
					if (WarheadType != Warhead.WarheadType.Fragmentation && WarheadType != Warhead.WarheadType.Cluster_AP)
					{
						if (WarheadType != Warhead.WarheadType.Cluster_AT)
						{
							int num2 = GameGeneral.smethod_5().Next(1, 8);
							num2 = (int)Math.Round((double)((float)num2 * (PenetrationPercentage + 1f)));
							if (WarheadType == Warhead.WarheadType.Torpedo)
							{
								num2 += 5;
							}
							double num3 = Math.Round((double)num, 1);
							if (num3 < 0.1)
							{
								return num2 - 6;
							}
							if (num3 == 0.1)
							{
								return num2 - 4;
							}
							if (num3 == 0.2)
							{
								return num2 - 3;
							}
							if (num3 == 0.3)
							{
								return num2 - 2;
							}
							if (num3 == 0.4)
							{
								return num2 - 1;
							}
							if (num3 == 0.5)
							{
								return num2;
							}
							if (num3 == 0.6)
							{
								return num2 + 1;
							}
							if (num3 == 0.7)
							{
								return num2 + 2;
							}
							if (num3 == 0.8)
							{
								return num2 + 3;
							}
							if (num3 == 0.9)
							{
								return num2 + 4;
							}
							return num2 + 5;
						}
					}
					int num4 = 0;
					int num5;
					if (ShockDamage <= 10.0)
					{
						num5 = 1;
					}
					else if (ShockDamage <= 20.0)
					{
						num5 = 2;
					}
					else if (ShockDamage <= 50.0)
					{
						num5 = 3;
					}
					else if (ShockDamage <= 100.0)
					{
						num5 = 4;
					}
					else
					{
						num5 = 5;
					}
					int num6 = num5;
					for (int i = 1; i <= num6; i++)
					{
						int num2 = GameGeneral.smethod_5().Next(1, 8);
						num4 += num2;
					}
					result = num4;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100125", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00097228 File Offset: 0x00095428
		public virtual void vmethod_14(float float_1)
		{
			if (this.activeUnit_0.scenario_0.SecondIsChangingOnThisPulse && this.activeUnit_0.scenario_0.method_31().Minute == 0 && this.activeUnit_0.scenario_0.method_31().Second == 0)
			{
				this.method_13(this.activeUnit_0.vmethod_53().Value);
				if (this.activeUnit_0.bool_8)
				{
					this.method_12(this.activeUnit_0.vmethod_53().Value);
				}
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x000972BC File Offset: 0x000954BC
		public void method_12(GlobalVariables.ProficiencyLevel proficiencyLevel_0)
		{
			try
			{
				if (this.vmethod_3() <= ActiveUnit_Damage.FireIntensityLevel.Minor && this.vmethod_1() <= ActiveUnit_Damage.FloodingIntensityLevel.Minor)
				{
					if (this.activeUnit_0.vmethod_63(false, null) < (float)this.activeUnit_0.method_60())
					{
						float num = 100f - this.method_0();
						switch (proficiencyLevel_0)
						{
						case GlobalVariables.ProficiencyLevel.Novice:
							num = (float)((double)num * 0.3);
							break;
						case GlobalVariables.ProficiencyLevel.Cadet:
							num = (float)((double)num * 0.5);
							break;
						case GlobalVariables.ProficiencyLevel.Regular:
							num = (float)((double)num * 0.8);
							break;
						case GlobalVariables.ProficiencyLevel.Veteran:
							num = (float)((double)num * 1.0);
							break;
						case GlobalVariables.ProficiencyLevel.Ace:
							num = (float)((double)num * 1.5);
							break;
						}
						if ((float)GameGeneral.smethod_5().Next(1, 101) < num)
						{
							ActiveUnit activeUnit;
							(activeUnit = this.activeUnit_0).vmethod_64(false, null, activeUnit.vmethod_63(false, null) + (float)((int)Math.Round((double)(this.activeUnit_0.vmethod_63(false, null) / 100f))));
							if (this.activeUnit_0.vmethod_63(false, null) >= (float)this.activeUnit_0.method_60())
							{
								if (this.activeUnit_0.vmethod_63(false, null) > (float)this.activeUnit_0.method_60())
								{
									this.activeUnit_0.vmethod_64(false, null, (float)this.activeUnit_0.method_60());
								}
								this.activeUnit_0.scenario_0.method_59(Misc.smethod_9(this.activeUnit_0.Name) + ": structural integrity fully restored! ", this.activeUnit_0.Name + " back to 100%", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							}
							else
							{
								this.activeUnit_0.scenario_0.method_59(Misc.smethod_9(this.activeUnit_0.Name) + ": structural damage being repaired, now at " + Conversions.ToString(Math.Round((double)this.activeUnit_0.vmethod_91().method_0(), 1)) + "%. ", this.activeUnit_0.Name + " under repairs", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100128", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0009759C File Offset: 0x0009579C
		public void method_13(GlobalVariables.ProficiencyLevel proficiencyLevel_0)
		{
			try
			{
				float num = 100f - this.method_0();
				switch (proficiencyLevel_0)
				{
				case GlobalVariables.ProficiencyLevel.Novice:
					num = (float)((double)num * 0.3);
					break;
				case GlobalVariables.ProficiencyLevel.Cadet:
					num = (float)((double)num * 0.5);
					break;
				case GlobalVariables.ProficiencyLevel.Regular:
					num = (float)((double)num * 0.8);
					break;
				case GlobalVariables.ProficiencyLevel.Veteran:
					num = (float)((double)num * 1.0);
					break;
				case GlobalVariables.ProficiencyLevel.Ace:
					num = (float)((double)num * 1.5);
					break;
				}
				try
				{
					foreach (PlatformComponent platformComponent in this.activeUnit_0.vmethod_120())
					{
						if (platformComponent.vmethod_5() == PlatformComponent._ComponentStatus.Damaged)
						{
							switch (platformComponent.method_16())
							{
							case PlatformComponent._DamageSeverityFactor.Light:
								num -= 10f;
								if ((float)GameGeneral.smethod_5().Next(1, 101) < num)
								{
									platformComponent.method_22(false);
									this.activeUnit_0.scenario_0.method_59(Misc.smethod_9(this.activeUnit_0.Name) + " damage report: " + Misc.smethod_9(platformComponent.Name) + " has been fully repaired.", this.activeUnit_0.Name + " damaged component back online", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
								}
								break;
							case PlatformComponent._DamageSeverityFactor.Medium:
								if (this.activeUnit_0.vmethod_127() && !this.activeUnit_0.bool_8)
								{
									return;
								}
								num -= 20f;
								if ((float)GameGeneral.smethod_5().Next(1, 101) < num)
								{
									platformComponent.method_17(PlatformComponent._DamageSeverityFactor.Light);
									this.activeUnit_0.scenario_0.method_59(Misc.smethod_9(this.activeUnit_0.Name) + " damage report: " + Misc.smethod_9(platformComponent.Name) + " is being repaired (light damage).", this.activeUnit_0.Name + " damaged component being repaired", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
								}
								break;
							case PlatformComponent._DamageSeverityFactor.Heavy:
								if (this.activeUnit_0.vmethod_127() && !this.activeUnit_0.bool_8)
								{
									return;
								}
								num -= 30f;
								if ((float)GameGeneral.smethod_5().Next(1, 101) < num)
								{
									platformComponent.method_17(PlatformComponent._DamageSeverityFactor.Medium);
									this.activeUnit_0.scenario_0.method_59(Misc.smethod_9(this.activeUnit_0.Name) + " damage report: " + Misc.smethod_9(platformComponent.Name) + " is being repaired (medium damage).", this.activeUnit_0.Name + " damaged component being repaired", LoggedMessage.MessageType.UnitDamage, 5, this.activeUnit_0.string_0, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
								}
								break;
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
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100128", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00097968 File Offset: 0x00095B68
		public void method_14(float float_1)
		{
			if (this.activeUnit_0.enum122_0 == Unit.Enum122.const_0 && float_1 != 0f && !this.activeUnit_0.vmethod_26() && !this.activeUnit_0.vmethod_27())
			{
				if (this.activeUnit_0.vmethod_96().Length > 0 || this.activeUnit_0.vmethod_94().Length > 0)
				{
					this.activeUnit_0.method_124(this.activeUnit_0.Name + " is being hit by an EMP wave!", this.activeUnit_0.Name + " zapped!", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
				}
				new WeaponImpact(ref this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_14(false), WeaponImpact.Enum124.const_1, 0);
				try
				{
					foreach (PlatformComponent platformComponent in this.activeUnit_0.vmethod_120())
					{
						platformComponent.vmethod_9(float_1);
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
			}
		}

		// Token: 0x04000611 RID: 1553
		protected ActiveUnit activeUnit_0;

		// Token: 0x04000612 RID: 1554
		[CompilerGenerated]
		private static ActiveUnit_Damage.Delegate16 delegate16_0;

		// Token: 0x04000613 RID: 1555
		protected ActiveUnit_Damage.FireIntensityLevel fireIntensityLevel_0;

		// Token: 0x04000614 RID: 1556
		protected ActiveUnit_Damage.FloodingIntensityLevel floodingIntensityLevel_0;

		// Token: 0x04000615 RID: 1557
		protected float float_0;

		// Token: 0x02000141 RID: 321
		// (Invoke) Token: 0x060008ED RID: 2285
		internal delegate void Delegate16(ActiveUnit myUnit);

		// Token: 0x02000142 RID: 322
		public enum FireIntensityLevel : byte
		{
			// Token: 0x04000617 RID: 1559
			NoFire,
			// Token: 0x04000618 RID: 1560
			Minor,
			// Token: 0x04000619 RID: 1561
			Major,
			// Token: 0x0400061A RID: 1562
			Severe,
			// Token: 0x0400061B RID: 1563
			Conflagration
		}

		// Token: 0x02000143 RID: 323
		public enum FloodingIntensityLevel : byte
		{
			// Token: 0x0400061D RID: 1565
			NoFlooding,
			// Token: 0x0400061E RID: 1566
			Minor,
			// Token: 0x0400061F RID: 1567
			Major,
			// Token: 0x04000620 RID: 1568
			Severe,
			// Token: 0x04000621 RID: 1569
			Capsizing
		}

		// Token: 0x02000145 RID: 325
		[CompilerGenerated]
		internal sealed class Class189
		{
			// Token: 0x060008F5 RID: 2293 RVA: 0x00007942 File Offset: 0x00005B42
			internal bool method_0(Sensor sensor_0)
			{
				return sensor_0.method_43() && (sensor_0.DBID == this.weapon_0.keyValuePair_0.Key || (int)sensor_0.short_0 == this.weapon_0.keyValuePair_0.Key);
			}

			// Token: 0x04000627 RID: 1575
			public Weapon weapon_0;
		}

		// Token: 0x02000146 RID: 326
		[CompilerGenerated]
		internal sealed class Class190
		{
			// Token: 0x060008F7 RID: 2295 RVA: 0x00007980 File Offset: 0x00005B80
			internal bool method_0(Sensor sensor_0)
			{
				return sensor_0.DBID == this.keyValuePair_0.Key || (int)sensor_0.short_0 == this.keyValuePair_0.Key;
			}

			// Token: 0x04000628 RID: 1576
			public KeyValuePair<int, EmissionContainer> keyValuePair_0;
		}
	}
}
