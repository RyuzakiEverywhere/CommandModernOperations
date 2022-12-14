using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns9;

namespace Command_Core
{
	// Token: 0x020001A8 RID: 424
	public sealed class Aircraft_Kinematics : ActiveUnit_Kinematics
	{
		// Token: 0x06000CEC RID: 3308 RVA: 0x00008E49 File Offset: 0x00007049
		private Aircraft method_17()
		{
			if (Information.IsNothing(this.aircraft_0))
			{
				this.aircraft_0 = (Aircraft)this.activeUnit_0;
			}
			return this.aircraft_0;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00008E6F File Offset: 0x0000706F
		public Aircraft_Kinematics(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x000FD9C8 File Offset: 0x000FBBC8
		public int method_18()
		{
			float float_ = this.method_17().float_25;
			int result;
			if (float_ <= 1f)
			{
				result = 20;
			}
			else if (float_ <= 2f)
			{
				result = 30;
			}
			else if (float_ <= 3f)
			{
				result = 45;
			}
			else if (float_ <= 4f)
			{
				result = 60;
			}
			else if (float_ < 5f)
			{
				result = 70;
			}
			else
			{
				result = 80;
			}
			return result;
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x000FDA28 File Offset: 0x000FBC28
		public override void vmethod_7()
		{
			try
			{
				float num;
				foreach (FuelRec fuelRec in this.activeUnit_0.vmethod_67())
				{
					num += (float)fuelRec.int_0;
				}
				int int_;
				int int_2;
				float num2;
				if (this.method_17().method_167() != null && this.method_17().method_167().method_15(this.method_17().scenario_0) != null)
				{
					int_ = this.method_17().method_167().method_15(this.activeUnit_0.scenario_0).int_3;
					int_2 = this.method_17().method_167().method_15(this.activeUnit_0.scenario_0).int_4;
					num2 = this.method_17().method_167().method_15(this.activeUnit_0.scenario_0).float_6;
				}
				float num3;
				if (int_ > 0)
				{
					num3 = (float)((double)num * ((double)int_ / 100.0));
				}
				if (int_2 > 0 && num2 > 0f)
				{
					num3 += this.activeUnit_0.vmethod_98(ActiveUnit.Throttle.Loiter, null, new float?((float)this.vmethod_40(num2, ActiveUnit.Throttle.Loiter, false)), new float?(num2), false, true, false, false, false) * 60f * (float)int_2;
				}
				this.activeUnit_0.vmethod_87().vmethod_3(num3);
				if (this.activeUnit_0.vmethod_7(false) != null)
				{
					float num4 = num - num3;
					Doctrine._FuelState? fuelState = this.activeUnit_0.doctrine_0.method_206(this.activeUnit_0.scenario_0, false, true, false, false);
					byte? b = (fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null;
					float num5;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						num5 = 0f;
					}
					else
					{
						b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							num5 = (float)((double)num4 * 0.1);
						}
						else
						{
							b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								num5 = (float)((double)num4 * 0.2);
							}
							else
							{
								b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									num5 = (float)((double)num4 * 0.25);
								}
								else
								{
									b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
									if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										num5 = (float)((double)num4 * 0.3);
									}
									else
									{
										b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
										if (((b != null) ? new bool?(b.GetValueOrDefault() == 5) : null).GetValueOrDefault())
										{
											num5 = (float)((double)num4 * 0.4);
										}
										else
										{
											b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
											if (((b != null) ? new bool?(b.GetValueOrDefault() == 6) : null).GetValueOrDefault())
											{
												num5 = (float)((double)num4 * 0.5);
											}
											else
											{
												b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
												if (((b != null) ? new bool?(b.GetValueOrDefault() == 7) : null).GetValueOrDefault())
												{
													num5 = (float)((double)num4 * 0.6);
												}
												else
												{
													b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
													if (((b != null) ? new bool?(b.GetValueOrDefault() == 8) : null).GetValueOrDefault())
													{
														num5 = (float)((double)num4 * 0.7);
													}
													else
													{
														b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
														if (((b != null) ? new bool?(b.GetValueOrDefault() == 9) : null).GetValueOrDefault())
														{
															num5 = (float)((double)num4 * 0.75);
														}
														else
														{
															b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
															if (((b != null) ? new bool?(b.GetValueOrDefault() == 10) : null).GetValueOrDefault())
															{
																num5 = (float)((double)num4 * 0.8);
															}
															else
															{
																b = ((fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null);
																if (((b != null) ? new bool?(b.GetValueOrDefault() == 11) : null).GetValueOrDefault())
																{
																	num5 = (float)((double)num4 * 0.9);
																}
																else
																{
																	num5 = 0f;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					this.activeUnit_0.vmethod_87().vmethod_5(num5);
				}
				else
				{
					this.activeUnit_0.vmethod_87().vmethod_5(0f);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200446", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				if (this.method_17().method_167() != null)
				{
					GameGeneral.smethod_1(string.Concat(new string[]
					{
						"Loadout ",
						this.method_17().method_167().Name,
						" for aircraft ",
						this.method_17().Name,
						" (",
						this.method_17().string_2,
						") does not exist in the selected database. Please select a new loadout for this aircraft."
					}));
				}
				else
				{
					GameGeneral.smethod_1(string.Concat(new string[]
					{
						"The loadout for aircraft ",
						this.method_17().Name,
						" (",
						this.method_17().string_2,
						") is nothing."
					}));
				}
			}
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x000FE194 File Offset: 0x000FC394
		public override float vmethod_26()
		{
			float float_;
			if (this.float_2 > 0f)
			{
				float_ = this.float_2;
			}
			else
			{
				this.float_2 = this.vmethod_25();
				float_ = this.float_2;
			}
			return float_;
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x000FE1CC File Offset: 0x000FC3CC
		public override float vmethod_24(bool bool_3, float? nullable_4, float? nullable_5)
		{
			float result;
			try
			{
				ActiveUnit.Throttle throttle_;
				if (Information.IsNothing(nullable_4))
				{
					if (!Information.IsNothing(this.activeUnit_0.vmethod_101()))
					{
						if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
						{
							if (((Strike)this.activeUnit_0.vmethod_101()).strikeType_0 == Strike.StrikeType.Air_Intercept)
							{
								throttle_ = ActiveUnit.Throttle.Full;
							}
							else
							{
								throttle_ = ActiveUnit.Throttle.Cruise;
							}
						}
						else
						{
							throttle_ = ActiveUnit.Throttle.Cruise;
						}
					}
					else
					{
						throttle_ = ActiveUnit.Throttle.Cruise;
					}
				}
				if (Information.IsNothing(nullable_5))
				{
					nullable_5 = new float?(this.activeUnit_0.vmethod_49()[0].method_24(throttle_).float_0);
				}
				if (Information.IsNothing(nullable_4))
				{
					nullable_4 = new float?((float)this.vmethod_40(nullable_5.Value, throttle_, false));
				}
				result = (float)(this.method_19(throttle_, nullable_4, nullable_5, bool_3, 0f) * ((nullable_4 != null) ? new double?((double)nullable_4.GetValueOrDefault()) : null) / 3600.0).Value;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100451", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x000FE370 File Offset: 0x000FC570
		public override float vmethod_25()
		{
			float result;
			try
			{
				ActiveUnit.Throttle throttle;
				ActiveUnit.Throttle throttle2;
				if (!Information.IsNothing(this.activeUnit_0.vmethod_101()))
				{
					if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike)
					{
						if (((Strike)this.activeUnit_0.vmethod_101()).strikeType_0 == Strike.StrikeType.Air_Intercept)
						{
							throttle = ActiveUnit.Throttle.Full;
							throttle2 = ActiveUnit.Throttle.Cruise;
						}
						else
						{
							throttle = ActiveUnit.Throttle.Cruise;
							throttle2 = ActiveUnit.Throttle.Cruise;
						}
					}
					else
					{
						throttle = ActiveUnit.Throttle.Cruise;
						throttle2 = ActiveUnit.Throttle.Cruise;
					}
				}
				else
				{
					throttle = ActiveUnit.Throttle.Cruise;
					throttle2 = ActiveUnit.Throttle.Cruise;
				}
				ActiveUnit activeUnit_ = this.activeUnit_0;
				Aircraft aircraft = this.method_17();
				float float_ = Class514.smethod_26(ref activeUnit_.scenario_0, ref aircraft);
				double num = this.method_19(throttle, null, null, false, float_);
				double num2 = this.method_19(throttle2, null, null, true, float_);
				double num3 = (num + num2) / 2.0;
				if (throttle == throttle2)
				{
					result = (float)(num3 / 2.0 * (double)this.vmethod_40(this.activeUnit_0.vmethod_49()[0].method_24(throttle).float_0, throttle, false) / 3600.0);
				}
				else
				{
					result = (float)(num3 / 2.0 * ((double)this.vmethod_40(this.activeUnit_0.vmethod_49()[0].method_24(throttle).float_0, throttle, false) / 3600.0 + (double)this.vmethod_40(this.activeUnit_0.vmethod_49()[0].method_24(throttle2).float_0, throttle2, false) / 3600.0)) / 2f;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100451", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x000FE550 File Offset: 0x000FC750
		public double method_19(ActiveUnit.Throttle throttle_0, float? nullable_4, float? nullable_5, bool bool_3, float float_8)
		{
			double result;
			try
			{
				float num;
				foreach (FuelRec fuelRec in this.activeUnit_0.vmethod_67())
				{
					num += fuelRec.float_0;
				}
				num -= this.activeUnit_0.vmethod_87().vmethod_4();
				num -= float_8;
				if (num < 0f)
				{
					result = 0.0;
				}
				else
				{
					AltBand altBand_ = null;
					if (Information.IsNothing(nullable_5))
					{
						altBand_ = this.activeUnit_0.vmethod_49()[0].method_24(throttle_0);
					}
					result = (double)(num / this.activeUnit_0.vmethod_98(throttle_0, altBand_, nullable_4, nullable_5, bool_3, false, false, false, false));
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100452", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0.0;
			}
			return result;
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x000FE650 File Offset: 0x000FC850
		public override float vmethod_29(Doctrine._FuelState? nullable_4)
		{
			float result;
			try
			{
				float num;
				foreach (FuelRec fuelRec in this.activeUnit_0.vmethod_67())
				{
					num += fuelRec.float_0;
				}
				num -= this.activeUnit_0.vmethod_87().vmethod_4();
				float num2 = num - this.activeUnit_0.vmethod_87().vmethod_6();
				byte? b;
				if (num < 0f)
				{
					b = ((nullable_4 != null) ? new byte?((byte)nullable_4.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						this.method_17().float_33 = 0f;
						this.method_17().float_34 = 0f;
						return 0f;
					}
				}
				Class211 @class = this.method_17().method_157();
				ActiveUnit.Throttle throttle = @class.method_72();
				ActiveUnit.Throttle throttle2 = this.activeUnit_0.vmethod_82();
				if (throttle > throttle2)
				{
					throttle = throttle2;
				}
				bool flag = false;
				float num3 = @class.method_73(ref flag);
				float num4 = this.activeUnit_0.vmethod_87().vmethod_30();
				if (num3 > num4)
				{
					num3 = num4;
				}
				int num5 = this.vmethod_40(num3, throttle, false);
				float num6 = this.activeUnit_0.vmethod_98(throttle, null, new float?((float)num5), new float?(num3), true, false, false, false, false);
				float num7 = num / num6;
				float num8 = num2 / num6;
				float num9 = num7 * (float)num5 / 3600f;
				float num10 = num8 * (float)num5 / 3600f;
				double num11 = (double)(num9 - this.method_17().float_32);
				double num12 = (double)(num10 - this.method_17().float_32);
				this.method_17().float_33 = Math.Max((float)(num11 / (double)num9) * num, 0f);
				this.method_17().float_34 = Math.Max((float)(num12 / (double)num10) * num2, 0f);
				b = ((nullable_4 != null) ? new byte?((byte)nullable_4.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					result = num9;
				}
				else
				{
					result = num10;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100453", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x000FE8F4 File Offset: 0x000FCAF4
		public override void vmethod_27(float elapsedTime, bool UseFormUpAltitude = false, bool UseLandingQueueAltitude = false)
		{
			try
			{
				this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, Math2.smethod_7(this.activeUnit_0.vmethod_9() + 3f * elapsedTime));
				this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100454", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x000FE984 File Offset: 0x000FCB84
		public void method_20()
		{
			Aircraft aircraft = this.method_17().method_164().method_24();
			if (!Information.IsNothing(aircraft))
			{
				this.method_17().vmethod_31(null, aircraft.vmethod_30(null));
				this.method_17().vmethod_29(null, aircraft.vmethod_28(null));
				this.method_17().vmethod_15(false, aircraft.vmethod_14(false) - 4.572f);
				this.method_17().vmethod_10(aircraft.vmethod_9());
				this.method_17().vmethod_41(aircraft.vmethod_40());
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x000FEA30 File Offset: 0x000FCC30
		public void method_21(float float_8)
		{
			if (!this.method_17().method_169() && this.method_17().method_164().method_36() != Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown)
			{
				double num = (double)this.vmethod_40(this.method_17().vmethod_14(false), ActiveUnit.Throttle.Loiter, false) * Math.Cos((double)this.method_17().vmethod_20() * 0.0174532925199433);
				if ((double)this.method_17().vmethod_40() < num)
				{
					Aircraft aircraft;
					(aircraft = this.method_17()).vmethod_15(false, aircraft.vmethod_14(false) - (float)(9.81 * (double)float_8 * (1.0 - (double)this.method_17().vmethod_40() / num)));
				}
			}
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x000FEAE0 File Offset: 0x000FCCE0
		public override void vmethod_46(float float_8, bool bool_3, bool bool_4, DateTime dateTime_0)
		{
			if (this.activeUnit_0.vmethod_127())
			{
				try
				{
					base.method_15(float_8);
					if (float.IsNaN(this.activeUnit_0.vmethod_9()))
					{
						this.activeUnit_0.vmethod_10(0f);
					}
					if (float.IsNaN(this.activeUnit_0.vmethod_68()))
					{
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.vmethod_9());
					}
					if (this.method_17().vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling)
					{
						this.method_20();
					}
					else if (this.method_17().vmethod_108() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || !this.activeUnit_0.method_121() || this.method_17().method_164().method_24() == null || this.activeUnit_0.vmethod_30(null) != this.method_17().method_164().method_24().vmethod_30(null) || this.activeUnit_0.vmethod_28(null) != this.method_17().method_164().method_24().vmethod_28(null))
					{
						if (this.method_17().vmethod_59())
						{
							bool flag = false;
							if (!this.method_17().method_85() || this.method_17().vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
							{
								foreach (Sensor sensor in this.activeUnit_0.vmethod_96())
								{
									if ((sensor.method_65() || sensor.method_70()) && sensor.method_43())
									{
										flag = true;
										break;
									}
								}
							}
							if (flag && this.activeUnit_0.vmethod_72() > 76.200005f)
							{
								this.activeUnit_0.vmethod_73(76.200005f);
								this.activeUnit_0.vmethod_71(30f);
							}
						}
						if (this.activeUnit_0.vmethod_70() < 0f)
						{
							this.activeUnit_0.vmethod_71(-this.activeUnit_0.vmethod_70());
						}
						float num = (float)Math.Max(this.activeUnit_0.method_10(true, float_8), this.activeUnit_0.method_9(true, false, false));
						this.activeUnit_0.method_19(this.activeUnit_0.vmethod_14(false));
						if ((!this.activeUnit_0.vmethod_76(this.activeUnit_0) && (num > 0f || (num == 0f && this.activeUnit_0.vmethod_72() != this.activeUnit_0.vmethod_14(false)))) || (this.activeUnit_0.vmethod_76(this.activeUnit_0) && (num > 0f || (num == 0f && this.activeUnit_0.vmethod_74() != this.activeUnit_0.vmethod_14(false)))) || (this.activeUnit_0.method_121() && this.activeUnit_0.vmethod_65(false).method_147() != null && this.activeUnit_0.vmethod_65(false).method_147().vmethod_76(this.activeUnit_0) && (num > 0f || (num == 0f && this.activeUnit_0.vmethod_74() != this.activeUnit_0.vmethod_14(false)))))
						{
							bool flag2;
							float num2;
							if (this.activeUnit_0.method_121() && this.activeUnit_0.vmethod_65(false).method_147() != null && !this.activeUnit_0.vmethod_87().vmethod_12())
							{
								flag2 = this.activeUnit_0.vmethod_65(false).method_147().vmethod_76(this.activeUnit_0.vmethod_65(false).method_147());
								num2 = this.activeUnit_0.vmethod_74();
							}
							else
							{
								flag2 = this.activeUnit_0.vmethod_76(this.activeUnit_0);
								num2 = this.activeUnit_0.vmethod_74();
							}
							float float_9;
							if (flag2)
							{
								float_9 = num2 + num;
							}
							else
							{
								float_9 = this.activeUnit_0.vmethod_72();
							}
							float? nullable_;
							if (this.method_17().vmethod_14(false) < 8850f)
							{
								nullable_ = this.method_17().imethod_4();
							}
							if (this.method_17().vmethod_6())
							{
								base.method_14(float_8);
							}
							this.vmethod_45(float_8, float_9, nullable_, true);
						}
						base.vmethod_46(float_8, true, false, dateTime_0);
					}
					checked
					{
						if (this.method_17().method_167() != null)
						{
							WeaponRec[] weaponRec_ = this.method_17().method_167().weaponRec_0;
							for (int j = 0; j < weaponRec_.Length; j++)
							{
								Weapon weapon = weaponRec_[j].method_12(this.method_17().scenario_0);
								weapon.vmethod_29(null, this.method_17().vmethod_28(null));
								weapon.vmethod_31(null, this.method_17().vmethod_30(null));
								weapon.vmethod_15(false, this.method_17().vmethod_14(false));
								weapon.vmethod_10(this.method_17().vmethod_9());
								weapon.vmethod_41(this.method_17().vmethod_40());
							}
						}
						if (this.activeUnit_0.vmethod_90().vmethod_1())
						{
							this.activeUnit_0.method_59(new double?(this.activeUnit_0.vmethod_28(null)));
							this.activeUnit_0.method_57(new double?(this.activeUnit_0.vmethod_30(null)));
						}
						else
						{
							if (this.activeUnit_0.method_58() == null)
							{
								this.activeUnit_0.method_59(new double?(this.activeUnit_0.vmethod_28(null)));
							}
							if (this.activeUnit_0.method_56() == null)
							{
								this.activeUnit_0.method_57(new double?(this.activeUnit_0.vmethod_30(null)));
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100455", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x000FF0E4 File Offset: 0x000FD2E4
		public override float vmethod_47(float float_8)
		{
			float result;
			if (this.activeUnit_0.vmethod_78() == ActiveUnit.Enum28.const_1)
			{
				result = this.activeUnit_0.vmethod_40() / 3600f * float_8;
			}
			else
			{
				result = this.activeUnit_0.method_20() / 3600f * float_8;
			}
			return result;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x000FF12C File Offset: 0x000FD32C
		public override void vmethod_45(float float_8, float float_9, float? nullable_4, bool bool_3)
		{
			try
			{
				this.activeUnit_0.method_19(this.activeUnit_0.vmethod_14(false));
				float num = this.activeUnit_0.vmethod_14(false);
				double num2 = (double)((this.activeUnit_0.vmethod_14(false) - this.activeUnit_0.method_18()) / float_8);
				((Aircraft)this.activeUnit_0).method_159().method_21(float_8);
				float num3 = this.vmethod_16() * float_8;
				float num4 = this.vmethod_23() * float_8;
				if (num2 < 0.0)
				{
					num3 = (float)((double)num3 - num2);
				}
				if (num2 > 0.0)
				{
					num4 = (float)((double)num4 - Math.Abs(num2));
				}
				if (num3 > 0f)
				{
					if (nullable_4 != null && ((nullable_4 != null) ? new bool?(float_9 < nullable_4.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						float_9 = nullable_4.Value;
					}
					if (this.activeUnit_0.vmethod_6())
					{
						if (float_9 - this.activeUnit_0.vmethod_14(false) <= num3 && this.activeUnit_0.vmethod_14(false) - float_9 <= num4 && this.activeUnit_0.vmethod_18() < 3f && this.activeUnit_0.vmethod_18() > 0f)
						{
							num = float_9;
							this.activeUnit_0.vmethod_19(0f);
						}
						else
						{
							num = this.activeUnit_0.vmethod_14(false) + num3;
						}
					}
					else if (float_9 - this.activeUnit_0.vmethod_14(false) <= num3)
					{
						num = float_9;
					}
					else
					{
						num = this.activeUnit_0.vmethod_14(false) + num3;
					}
					this.activeUnit_0.vmethod_15(bool_3, num);
				}
				else if (num4 > 0f)
				{
					if (nullable_4 != null && ((nullable_4 != null) ? new bool?(float_9 < nullable_4.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						float_9 = nullable_4.Value;
					}
					if (this.activeUnit_0.vmethod_6())
					{
						if (this.activeUnit_0.vmethod_14(false) - float_9 <= num4 && float_9 - this.activeUnit_0.vmethod_14(false) <= num3 && this.activeUnit_0.vmethod_18() > -3f && this.activeUnit_0.vmethod_18() < 0f)
						{
							num = float_9;
							this.activeUnit_0.vmethod_19(0f);
						}
						else
						{
							num = this.activeUnit_0.vmethod_14(false) - num4;
						}
					}
					else if (this.activeUnit_0.vmethod_14(false) - float_9 <= num4)
					{
						num = float_9;
					}
					else
					{
						num = this.activeUnit_0.vmethod_14(false) - num4;
					}
					if (nullable_4 != null && ((nullable_4 != null) ? new bool?(num <= nullable_4.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						this.activeUnit_0.vmethod_19(0f);
					}
					this.activeUnit_0.vmethod_15(bool_3, num);
				}
				else if (this.activeUnit_0.vmethod_6())
				{
					if (this.activeUnit_0.vmethod_14(false) - this.activeUnit_0.vmethod_72() == 0f)
					{
						this.activeUnit_0.vmethod_23(0f);
					}
					if (nullable_4 != null)
					{
						float num5 = this.activeUnit_0.vmethod_14(false);
						if (((nullable_4 != null) ? new bool?(num5 <= nullable_4.GetValueOrDefault()) : null).GetValueOrDefault())
						{
							this.activeUnit_0.vmethod_19(0f);
							this.activeUnit_0.vmethod_15(bool_3, nullable_4.Value);
							goto IL_3E1;
						}
					}
					if (this.activeUnit_0.vmethod_18() > 0f)
					{
						num = this.activeUnit_0.vmethod_14(false) + num3;
						this.activeUnit_0.vmethod_15(bool_3, num);
					}
					else if (this.activeUnit_0.vmethod_18() < 0f)
					{
						num = this.activeUnit_0.vmethod_14(false) - num4;
						this.activeUnit_0.vmethod_15(bool_3, num);
					}
				}
				IL_3E1:
				float num6 = this.vmethod_30();
				if (this.activeUnit_0.vmethod_14(false) > num6)
				{
					this.activeUnit_0.vmethod_23(-45f);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100196", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x000FF598 File Offset: 0x000FD798
		public float method_22(StringBuilder theSB = null)
		{
			if (theSB != null)
			{
				theSB.Append(this.method_17().Name).Append(" has nominal agility: ").Append(this.method_17().float_25).Append(", ");
			}
			float num = (float)Math.Round((double)this.method_17().method_159().method_26(this.method_17().float_25), 1);
			if (theSB != null)
			{
				theSB.Append("adjusted for altitude: ").Append(num).Append(". ");
			}
			GlobalVariables.ProficiencyLevel? proficiencyLevel = this.method_17().vmethod_53();
			int? num2 = (proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
			if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				num = (float)((double)num * 0.3);
			}
			else
			{
				num2 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
				if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					num = (float)((double)num * 0.5);
				}
				else
				{
					num2 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						num = (float)((double)num * 0.8);
					}
					else
					{
						num2 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
						if (!((num2 != null) ? new bool?(num2.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							num2 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
							if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								num = (float)((double)num * 1.2);
							}
						}
					}
				}
			}
			if (theSB != null)
			{
				theSB.Append(string.Concat(new string[]
				{
					"Agility adjusted for proficiency (",
					Misc.smethod_20(this.method_17().vmethod_53().Value),
					"): ",
					Conversions.ToString(num),
					". "
				}));
			}
			float num3 = this.method_17().method_178();
			num = (float)(0.4 * (double)num + 0.6 * (double)num * (double)(1f - num3));
			if (theSB != null)
			{
				theSB.Append(string.Concat(new string[]
				{
					"Aircraft has a weight fraction of ",
					Conversions.ToString(Math.Round((double)num3, 2)),
					" - Agility adjusted to ",
					Conversions.ToString(Math.Round((double)num, 2)),
					". "
				}));
			}
			if (this.method_17().method_163().method_0() > 0f)
			{
				num = num * (100f - this.method_17().method_163().method_0()) / 100f;
				if (theSB != null)
				{
					theSB.Append(string.Concat(new string[]
					{
						"Aircraft has ",
						Conversions.ToString(this.method_17().method_163().method_0()),
						"% fuselage/structural damage - Agility adjusted to ",
						Conversions.ToString(Math.Round((double)num, 2)),
						". "
					}));
				}
			}
			return num;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x000FF964 File Offset: 0x000FDB64
		public override float vmethod_9(ActiveUnit.Throttle throttle_0, float float_8)
		{
			float num = (float)((double)this.method_17().float_25 * 0.05 * (double)this.vmethod_40(float_8, throttle_0, false));
			switch (this.activeUnit_0.vmethod_49()[0].enum112_0)
			{
			case Engine.Enum112.const_1:
			case Engine.Enum112.const_2:
				num = (float)(1.2 * (double)num);
				break;
			case Engine.Enum112.const_3:
			case Engine.Enum112.const_5:
				num = (float)(0.8 * (double)num);
				break;
			}
			return num;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00008E78 File Offset: 0x00007078
		public override float vmethod_20()
		{
			return this.method_22(null) * 2f;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00008E87 File Offset: 0x00007087
		public override float vmethod_19()
		{
			return this.method_22(null) * 4f;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x000FF9EC File Offset: 0x000FDBEC
		public override int vmethod_40(float float_8, ActiveUnit.Throttle throttle_0, bool bool_3)
		{
			int result;
			if (float.IsNaN(float_8))
			{
				result = 0;
			}
			else
			{
				AltBand altBand = null;
				AltBand altBand2 = null;
				Engine engine = null;
				try
				{
					if (throttle_0 == ActiveUnit.Throttle.FullStop)
					{
						result = 0;
					}
					else if (this.activeUnit_0.vmethod_49().Count == 0)
					{
						result = 0;
					}
					else
					{
						altBand = ActiveUnit_Kinematics.smethod_1(this.activeUnit_0, float_8, null, false);
						if (altBand == null)
						{
							result = 0;
						}
						else
						{
							try
							{
								foreach (Engine engine2 in this.activeUnit_0.vmethod_49())
								{
									if (engine2.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
									{
										engine = engine2;
										break;
									}
								}
							}
							finally
							{
								List<Engine>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							if (Information.IsNothing(engine))
							{
								result = 0;
							}
							else
							{
								AltBand[] altBand_ = engine.altBand_0;
								if (altBand_.Length == 0)
								{
									result = 0;
								}
								else
								{
									float num;
									switch (throttle_0)
									{
									case ActiveUnit.Throttle.FullStop:
										num = 0f;
										break;
									case ActiveUnit.Throttle.Loiter:
										num = (float)altBand.int_0;
										break;
									case ActiveUnit.Throttle.Cruise:
										if (altBand.int_1 > 0)
										{
											num = (float)altBand.int_1;
										}
										else
										{
											num = (float)altBand.int_0;
										}
										break;
									case ActiveUnit.Throttle.Full:
										if (altBand.nullable_0 == null)
										{
											num = (float)altBand.int_1;
										}
										else
										{
											num = (float)altBand.nullable_0.Value;
										}
										break;
									case ActiveUnit.Throttle.Flank:
										if (altBand.nullable_1 == null)
										{
											if (altBand.nullable_0 == null)
											{
												num = (float)altBand.int_1;
											}
											else
											{
												num = (float)altBand.nullable_0.Value;
											}
										}
										else
										{
											num = (float)altBand.nullable_1.Value;
										}
										break;
									}
									int num2 = (int)Math.Round((double)num);
									if (altBand != base.method_11(engine))
									{
										List<AltBand> list = new List<AltBand>();
										foreach (AltBand altBand3 in altBand_)
										{
											if (altBand3.float_1 >= altBand.float_0)
											{
												list.Add(altBand3);
											}
										}
										if (list.Count > 1)
										{
											list.Sort(new ActiveUnit_Kinematics.GClass0());
										}
										if (list.Count > 0)
										{
											altBand2 = list[0];
										}
										if (altBand2 != null)
										{
											float num3;
											switch (throttle_0)
											{
											case ActiveUnit.Throttle.FullStop:
												num3 = 0f;
												break;
											case ActiveUnit.Throttle.Loiter:
												num3 = (float)altBand2.int_0;
												break;
											case ActiveUnit.Throttle.Cruise:
												num3 = (float)altBand2.int_1;
												break;
											case ActiveUnit.Throttle.Full:
												if (altBand2.nullable_0 == null)
												{
													num3 = (float)altBand2.int_1;
												}
												else
												{
													num3 = (float)altBand2.nullable_0.Value;
												}
												break;
											case ActiveUnit.Throttle.Flank:
												if (altBand2.nullable_1 == null)
												{
													if (altBand2.nullable_0 == null)
													{
														num3 = (float)altBand2.int_1;
													}
													else
													{
														num3 = (float)altBand2.nullable_0.Value;
													}
												}
												else
												{
													num3 = (float)altBand2.nullable_1.Value;
												}
												break;
											}
											num2 = (int)Math.Round((double)(num3 + (float_8 - altBand2.float_1) * (num - num3) / (altBand.float_1 - altBand2.float_1)));
										}
									}
									int num4 = 0;
									try
									{
										List<Engine>.Enumerator enumerator2 = this.method_17().vmethod_49().GetEnumerator();
										while (enumerator2.MoveNext())
										{
											if (enumerator2.Current.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
											{
												num4++;
											}
										}
									}
									finally
									{
										List<Engine>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
									double num5 = (double)num4 / (double)this.method_17().vmethod_49().Count;
									if (num5 < 1.0)
									{
										num2 = (int)Math.Round((double)num2 * Math.Sqrt(num5));
									}
									num2 = (int)Math.Round((double)ActiveUnit_Kinematics.smethod_2((float)num2));
									result = num2;
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101340", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x000FFDFC File Offset: 0x000FDFFC
		public override float vmethod_18()
		{
			float num = this.method_22(null);
			float result;
			if (num > 4f)
			{
				result = 270f;
			}
			else if (num > 3f)
			{
				result = 180f;
			}
			else if (num > 2f)
			{
				result = 90f;
			}
			else if (num > 1f)
			{
				result = 45f;
			}
			else
			{
				result = 20f;
			}
			return result;
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x000FFE58 File Offset: 0x000FE058
		public override float vmethod_8(ActiveUnit.Throttle throttle_0, float float_8, float float_9)
		{
			float result;
			try
			{
				float num = this.vmethod_9(throttle_0, float_8);
				float num2 = Math.Min(1f, float_9 / (float)this.vmethod_40(float_8, throttle_0, false));
				float num3 = num * (1f - num2);
				float num4 = float_8 / this.activeUnit_0.vmethod_87().vmethod_30();
				Engine.Enum112 enum112_ = this.activeUnit_0.vmethod_49()[0].enum112_0;
				if (enum112_ != Engine.Enum112.const_1)
				{
					if (enum112_ == Engine.Enum112.const_2)
					{
						num3 = (float)((double)num3 * (1.5 - (double)(num4 / 2f)));
					}
				}
				else
				{
					num3 *= 1f + num4 / 2f;
				}
				double num5 = (double)Enumerable.Count<Engine>(Enumerable.Where<Engine>(this.method_17().vmethod_49(), (Aircraft_Kinematics._Closure$__.$I38-0 == null) ? (Aircraft_Kinematics._Closure$__.$I38-0 = new Func<Engine, bool>(Aircraft_Kinematics._Closure$__.$I.method_0)) : Aircraft_Kinematics._Closure$__.$I38-0)) / (double)this.method_17().vmethod_49().Count;
				num3 = (float)((double)num3 * num5 * num5);
				num3 = (float)(0.75 * (double)num3 + 0.25 * (double)num3 * (double)(1f - this.method_17().method_178()));
				result = num3;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100456", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = this.vmethod_9(throttle_0, float_8);
			}
			return result;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x000FFFE0 File Offset: 0x000FE1E0
		public override void vmethod_44(double double_0, float float_8)
		{
			try
			{
				if (this.activeUnit_0.vmethod_78() != ActiveUnit.Enum28.const_1)
				{
					if ((long)Math.Round((double)Math.Abs(this.activeUnit_0.vmethod_9() - this.activeUnit_0.vmethod_68())) > 5L)
					{
						float num = (float)(0.6 * double_0 * Math.Pow((double)Class437.smethod_0((double)this.activeUnit_0.vmethod_14(false), (double)this.activeUnit_0.vmethod_40()), 3.0));
						this.activeUnit_0.vmethod_41(this.activeUnit_0.vmethod_40() - num);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100457", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x001000CC File Offset: 0x000FE2CC
		private float method_23()
		{
			float result;
			if (this.method_17().vmethod_20() > 0f && Class437.smethod_3(this.method_17().vmethod_9(), this.method_17().vmethod_68()) < 0f)
			{
				result = 0f;
			}
			else if (this.method_17().vmethod_20() < 0f && Class437.smethod_3(this.method_17().vmethod_9(), this.method_17().vmethod_68()) > 0f)
			{
				result = 0f;
			}
			else
			{
				float num = this.method_17().vmethod_20();
				if (num >= 83.6f)
				{
					result = 9f * (this.method_17().float_25 / 5f);
				}
				else if (num >= 82.8f)
				{
					result = 8f * (this.method_17().float_25 / 5f);
				}
				else if (num >= 81.8f)
				{
					result = 7f * (this.method_17().float_25 / 5f);
				}
				else if (num >= 80.4f)
				{
					result = 6f * (this.method_17().float_25 / 5f);
				}
				else if (num >= 78.5f)
				{
					result = 5f * (this.method_17().float_25 / 5f);
				}
				else if (num >= 75.5f)
				{
					result = 4f * (this.method_17().float_25 / 5f);
				}
				else if (num >= 70.6f)
				{
					result = 3f * (this.method_17().float_25 / 5f);
				}
				else if (num >= 60f)
				{
					result = 2f * (this.method_17().float_25 / 5f);
				}
				else
				{
					result = this.method_17().float_25 / 5f;
				}
			}
			return result;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00100294 File Offset: 0x000FE494
		public bool method_24()
		{
			return this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.Unassigned && (this.activeUnit_0.vmethod_78() != ActiveUnit.Enum28.const_1 || this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedDefensive || this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x001002E4 File Offset: 0x000FE4E4
		public override void vmethod_28(float float_8)
		{
			try
			{
				double num;
				if (!this.method_24())
				{
					if (!Information.IsNothing(this.activeUnit_0.vmethod_85().method_7()))
					{
						num = (double)(ActiveUnit_Kinematics.smethod_3(this.activeUnit_0.vmethod_80(), this.activeUnit_0.vmethod_40()) * float_8);
					}
					else
					{
						num = (double)(this.vmethod_49() * float_8);
					}
					this.method_17().float_30 = Math.Max(0f, this.method_17().float_30 - 3f * float_8);
				}
				else
				{
					this.method_17().float_30 = Math.Max(0f, this.method_17().float_30 - 3f * float_8);
					Aircraft_Kinematics.Enum45 @enum = this.enum45_0;
					if (@enum != Aircraft_Kinematics.Enum45.const_0)
					{
						if (@enum == Aircraft_Kinematics.Enum45.const_1 && (double)this.method_17().float_30 < (double)this.method_17().float_31 * 0.25)
						{
							this.enum45_0 = Aircraft_Kinematics.Enum45.const_0;
						}
					}
					else
					{
						float num2 = this.method_23();
						Aircraft aircraft = this.method_17();
						ref float ptr = ref aircraft.float_30;
						aircraft.float_30 = ptr + num2 * float_8;
						if (this.method_17().float_30 >= this.method_17().float_31)
						{
							this.enum45_0 = Aircraft_Kinematics.Enum45.const_1;
						}
					}
					if (this.method_17().vmethod_20() > 0f && Class437.smethod_3(this.method_17().vmethod_9(), this.method_17().vmethod_68()) < 0f)
					{
						return;
					}
					if (this.method_17().vmethod_20() < 0f && Class437.smethod_3(this.method_17().vmethod_9(), this.method_17().vmethod_68()) > 0f)
					{
						return;
					}
					num = (double)(Math.Abs(this.method_17().vmethod_20()) / 89f * this.vmethod_49() * float_8);
				}
				ActiveUnit activeUnit;
				if (this.activeUnit_0.vmethod_85().method_47())
				{
					activeUnit = this.activeUnit_0;
				}
				else if (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_47())
				{
					activeUnit = this.activeUnit_0.vmethod_65(false).method_147();
				}
				else
				{
					activeUnit = this.activeUnit_0;
				}
				if (activeUnit.vmethod_85().method_47() && activeUnit.vmethod_108() == ActiveUnit._ActiveUnitStatus.OnPlottedCourse)
				{
					Waypoint.WaypointType? nullable_;
					int? num3;
					if (activeUnit.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.StationEnd)
					{
						nullable_ = activeUnit.vmethod_85().nullable_5;
						num3 = ((nullable_ != null) ? new int?((int)nullable_.GetValueOrDefault()) : null);
						if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 21) : null).GetValueOrDefault())
						{
							this.activeUnit_0.vmethod_10((float)Math2.smethod_6((double)this.activeUnit_0.vmethod_9() + num));
							if (Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_68())) < 90f && base.method_3(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_68()))
							{
								this.activeUnit_0.vmethod_10(this.activeUnit_0.vmethod_68());
							}
							return;
						}
					}
					nullable_ = activeUnit.vmethod_85().nullable_5;
					num3 = ((nullable_ != null) ? new int?((int)nullable_.GetValueOrDefault()) : null);
					if ((((num3 != null) ? new bool?(num3.GetValueOrDefault() == 24) : null) & activeUnit.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.StationStart_FigureEight).GetValueOrDefault())
					{
						this.activeUnit_0.vmethod_10((float)Math2.smethod_6((double)this.activeUnit_0.vmethod_9() - num));
						if (Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_68())) < 90f && base.method_2(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_68()))
						{
							this.activeUnit_0.vmethod_10(this.activeUnit_0.vmethod_68());
						}
						return;
					}
					bool? flag;
					bool? flag4;
					if (activeUnit.vmethod_85().method_4()[0].waypointType_0 != Waypoint.WaypointType.StationEnd)
					{
						flag = new bool?(false);
					}
					else
					{
						nullable_ = activeUnit.vmethod_85().nullable_5;
						num3 = ((nullable_ != null) ? new int?((int)nullable_.GetValueOrDefault()) : null);
						bool? flag3;
						bool? flag2 = flag3 = ((num3 != null) ? new bool?(num3.GetValueOrDefault() == 20) : null);
						if (flag3 != null && flag2.GetValueOrDefault())
						{
							flag = new bool?(true);
						}
						else
						{
							nullable_ = activeUnit.vmethod_85().nullable_5;
							num3 = ((nullable_ != null) ? new int?((int)nullable_.GetValueOrDefault()) : null);
							flag4 = (flag3 = ((num3 != null) ? new bool?(num3.GetValueOrDefault() == 23) : null));
							flag = ((flag3 != null) ? (flag2 | flag4.GetValueOrDefault()) : null);
						}
					}
					bool? flag5 = flag4 = flag;
					bool? flag6;
					bool? flag8;
					if (flag4 != null && flag5.GetValueOrDefault())
					{
						flag6 = new bool?(true);
					}
					else
					{
						bool? flag7;
						if (activeUnit.vmethod_85().method_4()[0].waypointType_0 != Waypoint.WaypointType.StationStart_Racetrack && activeUnit.vmethod_85().method_4()[0].waypointType_0 != Waypoint.WaypointType.StationStart_Racetrack)
						{
							flag7 = new bool?(false);
						}
						else
						{
							nullable_ = activeUnit.vmethod_85().nullable_5;
							num3 = ((nullable_ != null) ? new int?((int)nullable_.GetValueOrDefault()) : null);
							flag7 = ((num3 != null) ? new bool?(num3.GetValueOrDefault() == 24) : null);
						}
						flag8 = (flag4 = flag7);
						flag6 = ((flag4 != null) ? (flag5 | flag8.GetValueOrDefault()) : null);
					}
					flag8 = flag6;
					if (flag8.GetValueOrDefault())
					{
						if (Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_68())) > 90f)
						{
							this.activeUnit_0.vmethod_10((float)Math2.smethod_6((double)this.activeUnit_0.vmethod_9() + num));
							return;
						}
					}
					else if (activeUnit.vmethod_85().method_4()[0].waypointType_0 == Waypoint.WaypointType.HoldEnd && Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_68())) > 90f)
					{
						this.activeUnit_0.vmethod_10((float)Math2.smethod_6((double)this.activeUnit_0.vmethod_9() + num));
						return;
					}
				}
				Misc.Enum143 enum2 = Misc.smethod_63(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_68());
				if (enum2 != Misc.Enum143.const_0)
				{
					if (enum2 == Misc.Enum143.const_1)
					{
						this.activeUnit_0.vmethod_10((float)Math2.smethod_6((double)this.activeUnit_0.vmethod_9() + num));
						if (base.method_3(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_68()))
						{
							this.activeUnit_0.vmethod_10(this.activeUnit_0.vmethod_68());
						}
					}
				}
				else
				{
					this.activeUnit_0.vmethod_10((float)Math2.smethod_6((double)this.activeUnit_0.vmethod_9() - num));
					if (base.method_2(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_68()))
					{
						this.activeUnit_0.vmethod_10(this.activeUnit_0.vmethod_68());
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100456464561", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00008E96 File Offset: 0x00007096
		public int method_25()
		{
			return (int)Math.Round(1.5 * (double)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), ActiveUnit.Throttle.Loiter, false));
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00100B00 File Offset: 0x000FED00
		private float method_26(float float_8)
		{
			float result;
			if (this.method_17().vmethod_14(false) <= 3000f)
			{
				result = float_8;
			}
			else
			{
				float num = 0.5f;
				if (this.method_17().bool_39)
				{
					num = 0.25f;
				}
				float num2 = this.vmethod_30() - this.method_17().vmethod_14(false);
				float num3 = this.method_17().vmethod_14(false) - 3000f;
				float num4 = float_8 * num * (num3 / num2);
				result = (float)((double)Math.Max(float_8 * (1f - num), float_8 - num4));
			}
			return result;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00100B84 File Offset: 0x000FED84
		public override float vmethod_49()
		{
			float result;
			try
			{
				Aircraft.Enum40 enum40_ = this.method_17().enum40_0;
				if (enum40_ - Aircraft.Enum40.const_3 > 1)
				{
					if (enum40_ != Aircraft.Enum40.const_6)
					{
						if (Math.Abs(this.float_7 - this.activeUnit_0.vmethod_40()) > 30f)
						{
							float num = this.method_17().float_25 * 4f;
							float num2 = (float)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), this.activeUnit_0.vmethod_82(), false);
							float num3;
							if (this.activeUnit_0.vmethod_40() <= (float)this.method_25())
							{
								num3 = num * (this.activeUnit_0.vmethod_40() / (float)this.method_25());
							}
							else if ((double)Class437.smethod_0((double)this.activeUnit_0.vmethod_14(false), (double)this.activeUnit_0.vmethod_40()) <= 1.0)
							{
								num3 = Math.Max(num * (1f - (this.activeUnit_0.vmethod_40() - (float)this.method_25()) / (num2 - (float)this.method_25())), 3f);
							}
							else if (this.method_17().bool_39)
							{
								num3 = (float)((double)num - 0.25 * (double)num * (double)(this.activeUnit_0.vmethod_40() - (float)this.method_25()) / (double)(num2 - (float)this.method_25()));
							}
							else
							{
								num3 = (float)((double)num - 0.5 * (double)num * (double)(this.activeUnit_0.vmethod_40() - (float)this.method_25()) / (double)(num2 - (float)this.method_25()));
							}
							GlobalVariables.ProficiencyLevel? proficiencyLevel = this.activeUnit_0.vmethod_53();
							int? num4 = (proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
							if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								num3 = (float)((double)num3 * 0.4);
							}
							else
							{
								num4 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									num3 = (float)((double)num3 * 0.6);
								}
								else
								{
									num4 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
									if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										num3 = (float)((double)num3 * 0.8);
									}
									else
									{
										num4 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
										if (!((num4 != null) ? new bool?(num4.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											num4 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
											if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 4) : null).GetValueOrDefault())
											{
												num3 = (float)((double)num3 * 1.2);
											}
										}
									}
								}
							}
							num3 = Math.Max(num3, 3f);
							this.float_7 = this.activeUnit_0.vmethod_40();
							this.float_6 = num3;
						}
						else if (this.float_6 < 3f)
						{
							this.float_6 = 3f;
						}
					}
					else
					{
						this.float_6 = 1f;
					}
				}
				else
				{
					this.float_6 = 45f;
				}
				result = this.float_6;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100458", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 3f;
			}
			return result;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00100FBC File Offset: 0x000FF1BC
		public override float vmethod_16()
		{
			float result;
			if (this.activeUnit_0.vmethod_6())
			{
				if (this.activeUnit_0.vmethod_18() <= 0f)
				{
					result = 0f;
				}
				else
				{
					result = (float)Math.Min((double)this.vmethod_14(true), (double)this.activeUnit_0.vmethod_40() * 0.514444 * (double)(this.method_17().vmethod_18() / (float)this.method_18()));
				}
			}
			else
			{
				result = this.vmethod_14(true);
			}
			return result;
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00101038 File Offset: 0x000FF238
		public override float vmethod_14(bool LimitByTrueAirspeed = true)
		{
			this.float_5 = (float)(0.4 * (double)this.float_0 + 0.6 * (double)this.float_0 * (double)(1f - this.method_17().method_178()));
			double num = (double)Enumerable.Count<Engine>(Enumerable.Where<Engine>(this.method_17().vmethod_49(), (Aircraft_Kinematics._Closure$__.$I57-0 == null) ? (Aircraft_Kinematics._Closure$__.$I57-0 = new Func<Engine, bool>(Aircraft_Kinematics._Closure$__.$I.method_1)) : Aircraft_Kinematics._Closure$__.$I57-0)) / (double)this.method_17().vmethod_49().Count;
			this.float_5 = (float)((double)this.float_5 * num);
			if (LimitByTrueAirspeed && !this.method_17().method_150(true) && (double)this.float_5 > (double)this.method_17().vmethod_40() * 0.514444)
			{
				this.float_5 = (float)((double)this.method_17().vmethod_40() * 0.514444);
			}
			return this.float_5;
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00008EC7 File Offset: 0x000070C7
		public override void vmethod_15(bool LimitByTrueAirspeed = true, float value)
		{
			base.vmethod_15(true, value);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00101134 File Offset: 0x000FF334
		public override float vmethod_21()
		{
			float num = (float)(0.4 * (double)base.vmethod_21() + 0.6 * (double)base.vmethod_21() * (double)(1f + this.method_17().method_178()));
			if (!this.method_17().method_150(true) && (double)num > (double)this.method_17().vmethod_40() * 0.514444)
			{
				num = (float)((double)this.method_17().vmethod_40() * 0.514444);
			}
			return num;
		}

		// Token: 0x040008A1 RID: 2209
		private Aircraft aircraft_0;

		// Token: 0x040008A2 RID: 2210
		private float float_5;

		// Token: 0x040008A3 RID: 2211
		internal Aircraft_Kinematics.Enum45 enum45_0;

		// Token: 0x040008A4 RID: 2212
		private float float_6;

		// Token: 0x040008A5 RID: 2213
		private float float_7;

		// Token: 0x020001A9 RID: 425
		internal enum Enum45 : byte
		{
			// Token: 0x040008A7 RID: 2215
			const_0,
			// Token: 0x040008A8 RID: 2216
			const_1
		}
	}
}
