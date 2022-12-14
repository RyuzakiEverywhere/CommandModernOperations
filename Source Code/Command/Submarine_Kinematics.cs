using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using ns13;

namespace Command_Core
{
	// Token: 0x02000357 RID: 855
	public sealed class Submarine_Kinematics : ActiveUnit_Kinematics
	{
		// Token: 0x06001977 RID: 6519 RVA: 0x00008E6F File Offset: 0x0000706F
		public Submarine_Kinematics(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00009EAC File Offset: 0x000080AC
		public override float vmethod_20()
		{
			return 1f;
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00009EAC File Offset: 0x000080AC
		public override float vmethod_19()
		{
			return 1f;
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x001CE29C File Offset: 0x001CC49C
		public override float vmethod_29(Doctrine._FuelState? nullable_4)
		{
			float float_ = Math.Max(-20f, this.vmethod_31());
			return (float)((double)((float)this.vmethod_37(ActiveUnit.Throttle.Cruise, float_, true)) * ((double)this.vmethod_40(float_, ActiveUnit.Throttle.Cruise, false) / 3600.0));
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x001CE2DC File Offset: 0x001CC4DC
		public override long vmethod_37(ActiveUnit.Throttle throttle_0, float float_5, bool bool_3)
		{
			long result;
			try
			{
				if (!((Submarine)this.activeUnit_0).method_160() && (!((Submarine)this.activeUnit_0).method_159() || Enumerable.Count<FuelRec>(this.activeUnit_0.vmethod_67()) != 0))
				{
					FuelRec fuelRec;
					if (Enumerable.Count<FuelRec>(this.activeUnit_0.vmethod_67()) == 1)
					{
						fuelRec = this.activeUnit_0.vmethod_67()[0];
					}
					else if (Math.Round((double)float_5) >= -20.0)
					{
						fuelRec = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Where<FuelRec>(Enumerable.Select<FuelRec, FuelRec>(this.activeUnit_0.vmethod_67(), (Submarine_Kinematics._Closure$__.$I7-0 == null) ? (Submarine_Kinematics._Closure$__.$I7-0 = new Func<FuelRec, FuelRec>(Submarine_Kinematics._Closure$__.$I.method_0)) : Submarine_Kinematics._Closure$__.$I7-0), new Func<FuelRec, bool>(this.method_19)), 0);
					}
					else
					{
						fuelRec = Enumerable.ElementAtOrDefault<FuelRec>(Enumerable.Where<FuelRec>(Enumerable.Select<FuelRec, FuelRec>(this.activeUnit_0.vmethod_67(), (Submarine_Kinematics._Closure$__.$I7-2 == null) ? (Submarine_Kinematics._Closure$__.$I7-2 = new Func<FuelRec, FuelRec>(Submarine_Kinematics._Closure$__.$I.method_1)) : Submarine_Kinematics._Closure$__.$I7-2), new Func<FuelRec, bool>(this.method_20)), 0);
					}
					if (Information.IsNothing(fuelRec))
					{
						result = 0L;
					}
					else
					{
						result = (long)Math.Round((double)fuelRec.float_0 / (double)this.activeUnit_0.vmethod_98(throttle_0, null, null, null, false, false, false, false, false));
					}
				}
				else
				{
					result = long.MaxValue;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100833", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x001CE4A0 File Offset: 0x001CC6A0
		public override long vmethod_36(float float_5, float float_6, bool bool_3, bool bool_4)
		{
			long result;
			if (((Submarine)this.activeUnit_0).method_142())
			{
				result = long.MaxValue;
			}
			else
			{
				try
				{
					if (!((Submarine)this.activeUnit_0).method_160() && (!((Submarine)this.activeUnit_0).method_159() || Enumerable.Count<FuelRec>(this.activeUnit_0.vmethod_67()) != 0))
					{
						if (float_5 == 0f)
						{
							result = long.MaxValue;
						}
						else
						{
							float num;
							foreach (FuelRec fuelRec in this.activeUnit_0.vmethod_67())
							{
								num += fuelRec.float_0;
							}
							if (!bool_3)
							{
								num -= this.activeUnit_0.vmethod_87().vmethod_4();
							}
							float num2 = this.activeUnit_0.vmethod_98(this.vmethod_41(float_6, (float)((int)Math.Round((double)float_5))), null, new float?((float)((int)Math.Round((double)float_5))), new float?(float_6), false, false, false, false, false);
							if (num2 == 0f)
							{
								result = long.MaxValue;
							}
							else
							{
								result = (long)Math.Round((double)(num / num2));
							}
						}
					}
					else
					{
						result = long.MaxValue;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100185", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
			return result;
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x001CE614 File Offset: 0x001CC814
		public override void vmethod_44(double double_0, float float_5)
		{
			if (this.activeUnit_0.vmethod_78() != ActiveUnit.Enum28.const_1 && (int)Math.Round((double)Math.Abs(this.activeUnit_0.vmethod_9() - this.activeUnit_0.vmethod_68())) > 5)
			{
				float num;
				if (double_0 > 25.0)
				{
					num = (float)(0.25 * (double)float_5);
				}
				if (double_0 > 45.0)
				{
					num = 1f * float_5;
				}
				this.activeUnit_0.vmethod_41(this.activeUnit_0.vmethod_40() - num);
			}
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x001CE69C File Offset: 0x001CC89C
		public override int vmethod_40(float float_5, ActiveUnit.Throttle throttle_0, bool bool_3)
		{
			int result;
			if (((Submarine)this.activeUnit_0).method_168(throttle_0, null, null, null, ((Submarine)this.activeUnit_0).method_146(), ((Submarine)this.activeUnit_0).method_148()) == 0L)
			{
				result = 0;
			}
			else
			{
				result = base.vmethod_40(float_5, throttle_0, bool_3);
			}
			return result;
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x001CE700 File Offset: 0x001CC900
		public int method_17(float float_5, ActiveUnit.Throttle throttle_0, Engine engine_0, int int_0, bool bool_3)
		{
			int result;
			if (((Submarine)this.activeUnit_0).method_168(throttle_0, null, null, null, engine_0, int_0) == 0L)
			{
				result = 0;
			}
			else
			{
				result = base.vmethod_40(float_5, throttle_0, bool_3);
			}
			return result;
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00007D1C File Offset: 0x00005F1C
		public override float vmethod_24(bool bool_3, float? nullable_4, float? nullable_5)
		{
			return float.MaxValue;
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x001CE748 File Offset: 0x001CC948
		public override void vmethod_45(float float_5, float float_6, float? nullable_4, bool bool_3)
		{
			try
			{
				this.activeUnit_0.method_19(this.activeUnit_0.vmethod_14(false));
				float num = this.activeUnit_0.vmethod_14(false);
				double num2 = (double)((this.activeUnit_0.vmethod_14(false) - this.activeUnit_0.method_18()) / float_5);
				float num3 = this.vmethod_16() * float_5;
				float num4 = this.vmethod_23() * float_5;
				if (Math.Abs(float_6 - this.activeUnit_0.vmethod_14(false)) < 1f)
				{
					this.activeUnit_0.vmethod_15(bool_3, float_6);
					this.activeUnit_0.vmethod_23(0f);
				}
				else if (this.activeUnit_0.vmethod_14(false) < float_6)
				{
					if (num2 < 0.0)
					{
						num3 = (float)((double)num3 - num2);
					}
					if (this.activeUnit_0.vmethod_6())
					{
						num = this.activeUnit_0.vmethod_14(false) + num3;
					}
					else if (float_6 - this.activeUnit_0.vmethod_14(false) <= num3)
					{
						num = float_6;
					}
					else
					{
						num = this.activeUnit_0.vmethod_14(false) + num3;
					}
					this.activeUnit_0.vmethod_15(bool_3, num);
				}
				else if (this.activeUnit_0.vmethod_14(false) > float_6)
				{
					if (num2 > 0.0)
					{
						num4 = (float)((double)num4 - Math.Abs(num2));
					}
					if (this.activeUnit_0.vmethod_6())
					{
						num = this.activeUnit_0.vmethod_14(false) - num4;
					}
					else if (this.activeUnit_0.vmethod_14(false) - float_6 <= num4)
					{
						num = float_6;
					}
					else
					{
						num = this.activeUnit_0.vmethod_14(false) - num4;
					}
					this.activeUnit_0.vmethod_15(bool_3, num);
				}
				else
				{
					this.activeUnit_0.vmethod_23(0f);
				}
				float num5 = this.vmethod_30();
				float num6 = this.vmethod_31();
				if (this.activeUnit_0.vmethod_14(false) > num5)
				{
					this.activeUnit_0.vmethod_15(bool_3, num5 - 10f);
					this.activeUnit_0.vmethod_19(0f);
				}
				else if (this.activeUnit_0.vmethod_14(false) < num6)
				{
					this.activeUnit_0.vmethod_15(bool_3, num6);
					this.activeUnit_0.vmethod_19(0f);
				}
				else if (nullable_4 != null && ((nullable_4 != null) ? new bool?(num <= nullable_4.GetValueOrDefault()) : null).GetValueOrDefault())
				{
					this.activeUnit_0.vmethod_15(bool_3, nullable_4.Value);
					this.activeUnit_0.vmethod_19(0f);
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

		// Token: 0x06001982 RID: 6530 RVA: 0x001CEA18 File Offset: 0x001CCC18
		public override float vmethod_16()
		{
			float result;
			if (this.activeUnit_0.vmethod_6())
			{
				result = (float)((double)this.vmethod_14(true) + (double)this.activeUnit_0.vmethod_40() * 0.514444 * Math2.smethod_1((double)this.activeUnit_0.vmethod_18()));
			}
			else
			{
				result = this.vmethod_14(true);
			}
			return result;
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x0000CF34 File Offset: 0x0000B134
		public override float vmethod_21()
		{
			return (float)((double)this.vmethod_14(true) * 1.5);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x001CEA70 File Offset: 0x001CCC70
		public override float vmethod_23()
		{
			float result;
			if (this.activeUnit_0.vmethod_6())
			{
				if (this.activeUnit_0.vmethod_18() >= 0f)
				{
					result = (float)((double)this.vmethod_21() + (double)this.activeUnit_0.vmethod_40() * 0.514444 * Math2.smethod_1((double)this.activeUnit_0.vmethod_18()));
				}
				else
				{
					result = (float)((double)this.vmethod_21() - (double)this.activeUnit_0.vmethod_40() * 0.514444 * Math2.smethod_1((double)this.activeUnit_0.vmethod_18()));
				}
			}
			else
			{
				result = this.vmethod_21();
			}
			return result;
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x001CEB0C File Offset: 0x001CCD0C
		public override float vmethod_49()
		{
			int int_ = this.activeUnit_0.int_0;
			float num;
			if (int_ < 350)
			{
				num = 15f;
			}
			else if (int_ < 2500)
			{
				num = 5f;
			}
			else if (int_ < 5000)
			{
				num = 3f;
			}
			else if (int_ < 50000)
			{
				num = 1f;
			}
			else
			{
				num = 0.8f;
			}
			ActiveUnit.Enum28 @enum = this.activeUnit_0.vmethod_78();
			float result;
			if (@enum != ActiveUnit.Enum28.const_0)
			{
				if (@enum != ActiveUnit.Enum28.const_1)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = 0f;
				}
				else
				{
					result = num;
				}
			}
			else
			{
				result = (float)((double)num * 1.25);
			}
			return result;
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x001CEBA8 File Offset: 0x001CCDA8
		public int? method_18(float float_5, ActiveUnit.Throttle throttle_0)
		{
			Submarine_Kinematics.Class380 @class = new Submarine_Kinematics.Class380(@class);
			@class.float_0 = float_5;
			int? result;
			try
			{
				List<AltBand> list = new List<AltBand>();
				try
				{
					foreach (Engine engine in this.activeUnit_0.vmethod_49())
					{
						foreach (AltBand item in engine.altBand_0)
						{
							list.Add(item);
						}
					}
				}
				finally
				{
					List<Engine>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				IEnumerable<AltBand> enumerable = null;
				switch (throttle_0)
				{
				case ActiveUnit.Throttle.Loiter:
					enumerable = Enumerable.OrderByDescending<AltBand, float>(Enumerable.Where<AltBand>(list, new Func<AltBand, bool>(@class.method_0)), (Submarine_Kinematics._Closure$__.$I24-1 == null) ? (Submarine_Kinematics._Closure$__.$I24-1 = new Func<AltBand, float>(Submarine_Kinematics._Closure$__.$I.method_2)) : Submarine_Kinematics._Closure$__.$I24-1);
					break;
				case ActiveUnit.Throttle.Cruise:
					enumerable = Enumerable.OrderByDescending<AltBand, float>(Enumerable.Where<AltBand>(list, new Func<AltBand, bool>(@class.method_1)), (Submarine_Kinematics._Closure$__.$I24-3 == null) ? (Submarine_Kinematics._Closure$__.$I24-3 = new Func<AltBand, float>(Submarine_Kinematics._Closure$__.$I.method_3)) : Submarine_Kinematics._Closure$__.$I24-3);
					break;
				case ActiveUnit.Throttle.Full:
					enumerable = Enumerable.OrderByDescending<AltBand, float>(Enumerable.Where<AltBand>(list, new Func<AltBand, bool>(@class.method_2)), (Submarine_Kinematics._Closure$__.$I24-5 == null) ? (Submarine_Kinematics._Closure$__.$I24-5 = new Func<AltBand, float>(Submarine_Kinematics._Closure$__.$I.method_4)) : Submarine_Kinematics._Closure$__.$I24-5);
					break;
				case ActiveUnit.Throttle.Flank:
					enumerable = Enumerable.OrderByDescending<AltBand, float>(Enumerable.Where<AltBand>(list, new Func<AltBand, bool>(@class.method_3)), (Submarine_Kinematics._Closure$__.$I24-7 == null) ? (Submarine_Kinematics._Closure$__.$I24-7 = new Func<AltBand, float>(Submarine_Kinematics._Closure$__.$I.method_5)) : Submarine_Kinematics._Closure$__.$I24-7);
					break;
				}
				if (Enumerable.Count<AltBand>(enumerable) == 0)
				{
					result = null;
				}
				else
				{
					result = new int?((int)Math.Round((double)Enumerable.ElementAtOrDefault<AltBand>(enumerable, 0).float_0));
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100834", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x001CEDDC File Offset: 0x001CCFDC
		public override AltBand vmethod_42(float float_5, bool bool_3)
		{
			AltBand result;
			try
			{
				AltBand altBand = null;
				AltBand[] altBand_;
				try
				{
					foreach (Engine engine in this.activeUnit_0.vmethod_49())
					{
						altBand_ = engine.altBand_0;
						int num = altBand_.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							AltBand altBand2 = altBand_[i];
							if (altBand2.float_0 >= float_5 && float_5 + 1f >= altBand2.float_1)
							{
								altBand = altBand2;
								break;
							}
						}
					}
				}
				finally
				{
					List<Engine>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (Information.IsNothing(altBand))
				{
					if (this.activeUnit_0.bool_3)
					{
						altBand = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderByDescending<AltBand, float>(altBand_, (Submarine_Kinematics._Closure$__.$I25-0 == null) ? (Submarine_Kinematics._Closure$__.$I25-0 = new Func<AltBand, float>(Submarine_Kinematics._Closure$__.$I.method_6)) : Submarine_Kinematics._Closure$__.$I25-0), 0);
						if (bool_3)
						{
							this.activeUnit_0.vmethod_15(false, altBand.float_0);
						}
					}
					else
					{
						altBand = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderBy<AltBand, float>(altBand_, (Submarine_Kinematics._Closure$__.$I25-1 == null) ? (Submarine_Kinematics._Closure$__.$I25-1 = new Func<AltBand, float>(Submarine_Kinematics._Closure$__.$I.method_7)) : Submarine_Kinematics._Closure$__.$I25-1), 0);
						if (bool_3)
						{
							this.activeUnit_0.vmethod_15(true, altBand.float_1);
						}
					}
				}
				result = altBand;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100835", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x001CEF78 File Offset: 0x001CD178
		public override float vmethod_9(ActiveUnit.Throttle throttle_0, float float_5)
		{
			float num = this.activeUnit_0.vmethod_40();
			float result;
			if (num < 7f)
			{
				int int_ = this.activeUnit_0.int_0;
				if (int_ < 350)
				{
					result = 0.45f;
				}
				else if (int_ < 3500)
				{
					result = 0.43f;
				}
				else if (int_ < 8100)
				{
					result = 0.41f;
				}
				else if (int_ < 15000)
				{
					result = 0.27f;
				}
				else
				{
					result = 0.2f;
				}
			}
			else if (num > 20f)
			{
				int int_2 = this.activeUnit_0.int_0;
				if (int_2 < 350)
				{
					result = 0.25f;
				}
				else if (int_2 < 3500)
				{
					result = 0.25f;
				}
				else if (int_2 < 8100)
				{
					result = 0.55f;
				}
				else if (int_2 < 15000)
				{
					result = 0.4f;
				}
				else
				{
					result = 0.2f;
				}
			}
			else
			{
				int int_3 = this.activeUnit_0.int_0;
				if (int_3 < 350)
				{
					result = 0.3f;
				}
				else if (int_3 < 3500)
				{
					result = 0.3f;
				}
				else if (int_3 < 8100)
				{
					result = 0.65f;
				}
				else if (int_3 < 15000)
				{
					result = 0.45f;
				}
				else
				{
					result = 0.25f;
				}
			}
			return result;
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x0000CF49 File Offset: 0x0000B149
		public override float vmethod_8(ActiveUnit.Throttle throttle_0, float float_5, float float_6)
		{
			return this.vmethod_9(throttle_0, float_5);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x001CF0B4 File Offset: 0x001CD2B4
		public override void vmethod_46(float float_5, bool bool_3, bool bool_4, DateTime dateTime_0)
		{
			try
			{
				if (!double.IsNaN(this.activeUnit_0.vmethod_28(null)) && !double.IsNaN(this.activeUnit_0.vmethod_30(null)))
				{
					if (this.activeUnit_0.vmethod_127())
					{
						if (this.activeUnit_0.vmethod_72() > 0f)
						{
							this.activeUnit_0.vmethod_73(0f);
						}
						float num = (float)this.activeUnit_0.method_9(false, false, false);
						if (Class442.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)) && this.activeUnit_0.vmethod_72() > -25f)
						{
							this.activeUnit_0.vmethod_73(-25f);
						}
						if (((Submarine)this.activeUnit_0).method_159())
						{
							ActiveUnit activeUnit = this.activeUnit_0.vmethod_93().method_11(false);
							if (activeUnit != null && this.activeUnit_0.method_36(activeUnit) * 1852f > (float)((Submarine)this.activeUnit_0).short_3 && (Math.Abs(activeUnit.method_46(this.activeUnit_0, true)) > 90f || activeUnit.vmethod_40() > this.activeUnit_0.vmethod_40()) && activeUnit.vmethod_40() > 0f)
							{
								float float_6 = this.activeUnit_0.method_32(activeUnit);
								this.activeUnit_0.vmethod_10(float_6);
								this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, float_6);
								this.activeUnit_0.vmethod_41(activeUnit.vmethod_40());
							}
						}
						if (this.activeUnit_0.vmethod_86().bool_4)
						{
							this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.FullStop, new float?(0f));
						}
						else if (this.activeUnit_0.vmethod_87().vmethod_10() != null)
						{
							if (this.activeUnit_0.vmethod_87().vmethod_1() != ActiveUnit_Kinematics.UnitThrottlePreset.None)
							{
								if (this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.Unassigned && this.activeUnit_0.vmethod_108() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
								{
									if (this.activeUnit_0.bool_3)
									{
										Aircraft_AirOps aircraft_AirOps = (Aircraft_AirOps)this.activeUnit_0.vmethod_92();
										if (aircraft_AirOps.concurrentDictionary_0.Count + aircraft_AirOps.concurrentDictionary_1.Count == 0)
										{
											this.activeUnit_0.vmethod_134((ActiveUnit.Throttle)this.activeUnit_0.vmethod_87().vmethod_1(), new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_87().vmethod_10().Value))));
										}
									}
									else if (this.activeUnit_0.bool_6)
									{
										ActiveUnit_DockingOps activeUnit_DockingOps = this.activeUnit_0.vmethod_93();
										if (activeUnit_DockingOps.vmethod_0().Count == 0 && string.IsNullOrEmpty(activeUnit_DockingOps.string_5) && string.IsNullOrEmpty(activeUnit_DockingOps.string_4) && string.IsNullOrEmpty(activeUnit_DockingOps.string_6))
										{
											this.activeUnit_0.vmethod_134((ActiveUnit.Throttle)this.activeUnit_0.vmethod_87().vmethod_1(), new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_87().vmethod_10().Value))));
										}
									}
									else if (this.activeUnit_0.bool_5)
									{
										ActiveUnit_DockingOps activeUnit_DockingOps2 = this.activeUnit_0.vmethod_93();
										if (activeUnit_DockingOps2.vmethod_0().Count == 0 && string.IsNullOrEmpty(activeUnit_DockingOps2.string_5) && string.IsNullOrEmpty(activeUnit_DockingOps2.string_4) && string.IsNullOrEmpty(activeUnit_DockingOps2.string_6))
										{
											this.activeUnit_0.vmethod_134((ActiveUnit.Throttle)this.activeUnit_0.vmethod_87().vmethod_1(), new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_87().vmethod_10().Value))));
										}
									}
									else
									{
										this.activeUnit_0.vmethod_134((ActiveUnit.Throttle)this.activeUnit_0.vmethod_87().vmethod_1(), new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_87().vmethod_10().Value))));
									}
								}
							}
							else
							{
								this.activeUnit_0.vmethod_134(this.vmethod_41(this.activeUnit_0.vmethod_14(false), (float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_87().vmethod_10().Value))));
							}
						}
						float num2 = (float)this.vmethod_40(this.activeUnit_0.vmethod_14(false), this.activeUnit_0.vmethod_84(), true);
						if (GeoPoint.smethod_11(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null)))
						{
							num2 = 8f;
						}
						if (this.activeUnit_0.vmethod_70() > num2)
						{
							this.activeUnit_0.vmethod_71(num2);
						}
						double num3 = (double)this.activeUnit_0.vmethod_9();
						if (this.activeUnit_0.vmethod_9() != this.activeUnit_0.vmethod_68())
						{
							this.vmethod_28(float_5);
						}
						else
						{
							this.float_1 = this.activeUnit_0.vmethod_9();
						}
						if (this.activeUnit_0.vmethod_40() != 0f)
						{
							this.activeUnit_0.vmethod_48(float_5, bool_4);
						}
						double num4 = (double)Math.Abs(Class437.smethod_3((float)num3, this.activeUnit_0.vmethod_9())) * (double)(1f / float_5);
						this.vmethod_44(num4, float_5);
						bool flag = false;
						if (this.activeUnit_0.vmethod_78() == ActiveUnit.Enum28.const_1 && this.activeUnit_0.vmethod_85().method_49() && (!(this.activeUnit_0.method_121() & this.activeUnit_0.vmethod_65(false) != null) || this.activeUnit_0.vmethod_65(false).method_147() == null || (int)Math.Round((double)this.activeUnit_0.vmethod_40()) == (int)Math.Round((double)this.activeUnit_0.vmethod_65(false).method_147().vmethod_40())) && (int)Math.Round(num3) != (int)Math.Round((double)this.activeUnit_0.vmethod_9()))
						{
							bool? flag2;
							bool? flag3;
							if (this.activeUnit_0.vmethod_85().nullable_5 != null)
							{
								Waypoint.WaypointType? nullable_ = this.activeUnit_0.vmethod_85().nullable_5;
								int? num5 = (nullable_ != null) ? new int?((int)nullable_.GetValueOrDefault()) : null;
								flag2 = ((num5 != null) ? new bool?(num5.GetValueOrDefault() == 15) : null);
								flag3 = ((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2);
							}
							else
							{
								flag3 = new bool?(true);
							}
							flag2 = flag3;
							if (flag2.GetValueOrDefault())
							{
								flag = true;
							}
						}
						if (!flag && this.activeUnit_0.vmethod_40() != this.activeUnit_0.vmethod_70())
						{
							this.vmethod_43(float_5, (float)num4);
						}
						if (this.activeUnit_0.vmethod_6())
						{
							base.method_14(float_5);
						}
						this.vmethod_45(float_5, this.activeUnit_0.vmethod_72(), new float?(num + 1f), true);
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
						if (!bool_4)
						{
							this.activeUnit_0.vmethod_87().method_16(false);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100836", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x0000CF53 File Offset: 0x0000B153
		[CompilerGenerated]
		private bool method_19(FuelRec fuelRec_0)
		{
			return this.activeUnit_0.vmethod_49()[0].method_25(FuelRec._FuelType.DieselFuel);
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x0000CF70 File Offset: 0x0000B170
		[CompilerGenerated]
		private bool method_20(FuelRec fuelRec_0)
		{
			return this.activeUnit_0.vmethod_49()[0].method_25(FuelRec._FuelType.Battery);
		}

		// Token: 0x02000359 RID: 857
		[CompilerGenerated]
		internal sealed class Class380
		{
			// Token: 0x06001997 RID: 6551 RVA: 0x0000CF99 File Offset: 0x0000B199
			public Class380(Submarine_Kinematics.Class380 class380_0)
			{
				if (class380_0 != null)
				{
					this.float_0 = class380_0.float_0;
				}
			}

			// Token: 0x06001998 RID: 6552 RVA: 0x0000CFB0 File Offset: 0x0000B1B0
			internal bool method_0(AltBand altBand_0)
			{
				return (float)altBand_0.int_0 >= this.float_0;
			}

			// Token: 0x06001999 RID: 6553 RVA: 0x0000CFC4 File Offset: 0x0000B1C4
			internal bool method_1(AltBand altBand_0)
			{
				return (float)altBand_0.int_1 >= this.float_0;
			}

			// Token: 0x0600199A RID: 6554 RVA: 0x001CF934 File Offset: 0x001CDB34
			internal bool method_2(AltBand altBand_0)
			{
				long? nullable_ = altBand_0.nullable_0;
				float? num = (nullable_ != null) ? new float?((float)nullable_.GetValueOrDefault()) : null;
				return ((num != null) ? new bool?(num.GetValueOrDefault() >= this.float_0) : null).GetValueOrDefault();
			}

			// Token: 0x0600199B RID: 6555 RVA: 0x001CF9A0 File Offset: 0x001CDBA0
			internal bool method_3(AltBand altBand_0)
			{
				long? nullable_ = altBand_0.nullable_1;
				float? num = (nullable_ != null) ? new float?((float)nullable_.GetValueOrDefault()) : null;
				return ((num != null) ? new bool?(num.GetValueOrDefault() >= this.float_0) : null).GetValueOrDefault();
			}

			// Token: 0x04001697 RID: 5783
			public float float_0;
		}
	}
}
