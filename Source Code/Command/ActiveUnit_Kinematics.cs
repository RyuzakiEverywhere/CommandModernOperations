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
using ns13;
using ns14;

namespace Command_Core
{
	// Token: 0x02000159 RID: 345
	public class ActiveUnit_Kinematics
	{
		// Token: 0x06000976 RID: 2422 RVA: 0x0009E5C0 File Offset: 0x0009C7C0
		public virtual void vmethod_0(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteElementString("AMV", XmlConvert.ToString(this.float_1));
				if (this.nullable_0 != null)
				{
					xmlWriter_0.WriteElementString("DSO", this.nullable_0.ToString());
				}
				xmlWriter_0.WriteElementString("DAO", this.bool_0.ToString());
				xmlWriter_0.WriteElementString("ReserveFuel", this.float_3.ToString());
				xmlWriter_0.WriteElementString("SP", ((byte)this.vmethod_1()).ToString());
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "SADC";
				short num = (short)this.enum33_0;
				xmlWriter.WriteElementString(localName, num.ToString());
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100166", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0009E6B8 File Offset: 0x0009C8B8
		public static void smethod_0(XmlNode xmlNode_0, Dictionary<string, Class310> dictionary_0, ActiveUnit activeUnit_1)
		{
			try
			{
				foreach (object obj in xmlNode_0.ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					try
					{
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 1633936287U)
						{
							if (num <= 316182301U)
							{
								if (num != 154738112U)
								{
									if (num != 316182301U)
									{
										continue;
									}
									if (Operators.CompareString(name, "DSO", false) != 0)
									{
										continue;
									}
								}
								else if (Operators.CompareString(name, "DesiredSpeedOverride", false) != 0)
								{
									continue;
								}
								if (Operators.CompareString(xmlNode.InnerText, true.ToString(), false) == 0)
								{
									activeUnit_1.vmethod_87().nullable_0 = new float?(activeUnit_1.vmethod_70());
									continue;
								}
								if (Operators.CompareString(xmlNode.InnerText, false.ToString(), false) == 0)
								{
									activeUnit_1.vmethod_87().nullable_0 = null;
									continue;
								}
								activeUnit_1.vmethod_87().nullable_0 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
								continue;
							}
							else if (num != 856023323U)
							{
								if (num != 1633936287U)
								{
									continue;
								}
								if (Operators.CompareString(name, "AMV", false) != 0)
								{
									continue;
								}
								goto IL_243;
							}
							else if (Operators.CompareString(name, "DAO", false) != 0)
							{
								continue;
							}
						}
						else if (num <= 2609190255U)
						{
							if (num != 1728224374U)
							{
								if (num != 2609190255U)
								{
									continue;
								}
								if (Operators.CompareString(name, "ReserveFuel", false) == 0)
								{
									activeUnit_1.vmethod_87().float_3 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "SP", false) == 0)
								{
									activeUnit_1.vmethod_87().vmethod_2((ActiveUnit_Kinematics.UnitThrottlePreset)Conversions.ToByte(xmlNode.InnerText));
									continue;
								}
								continue;
							}
						}
						else if (num != 2788980997U)
						{
							if (num != 3126726711U)
							{
								if (num != 3765802604U)
								{
									continue;
								}
								if (Operators.CompareString(name, "SADC", false) == 0)
								{
									activeUnit_1.vmethod_87().enum33_0 = (ActiveUnit_Kinematics.Enum33)Conversions.ToShort(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else if (Operators.CompareString(name, "DesiredAltitudeOverride", false) != 0)
							{
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "ActualMovementVector", false) == 0)
							{
								goto IL_243;
							}
							continue;
						}
						activeUnit_1.vmethod_87().bool_0 = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_243:
						activeUnit_1.vmethod_87().float_1 = XmlConvert.ToSingle(xmlNode.InnerText);
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 100167", "");
						GameGeneral.smethod_25(ref ex);
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
			try
			{
				if (activeUnit_1.vmethod_87().vmethod_4() == 0f && activeUnit_1.bool_3)
				{
					activeUnit_1.vmethod_87().vmethod_7();
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100168", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00007CBD File Offset: 0x00005EBD
		public virtual ActiveUnit_Kinematics.UnitThrottlePreset vmethod_1()
		{
			return this.unitThrottlePreset_0;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0009EA28 File Offset: 0x0009CC28
		public virtual void vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset unitThrottlePreset_1)
		{
			this.unitThrottlePreset_0 = unitThrottlePreset_1;
			if (unitThrottlePreset_1 != ActiveUnit_Kinematics.UnitThrottlePreset.FullStop && unitThrottlePreset_1 != ActiveUnit_Kinematics.UnitThrottlePreset.None)
			{
				this.activeUnit_0.vmethod_86().bool_4 = false;
			}
			try
			{
				if (this.activeUnit_0.bool_3 && this.activeUnit_0.vmethod_87().vmethod_1() == ActiveUnit_Kinematics.UnitThrottlePreset.FullStop && !((Aircraft)this.activeUnit_0).method_150(false))
				{
					this.activeUnit_0.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.None);
				}
				if (unitThrottlePreset_1 != ActiveUnit_Kinematics.UnitThrottlePreset.None)
				{
					this.activeUnit_0.vmethod_87().vmethod_11(new float?(this.activeUnit_0.vmethod_70()));
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100169", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0009EB04 File Offset: 0x0009CD04
		public void method_0()
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.vmethod_87().vmethod_10() != null)
			{
				switch (this.vmethod_1())
				{
				case ActiveUnit_Kinematics.UnitThrottlePreset.FullStop:
					this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.FullStop, null);
					break;
				case ActiveUnit_Kinematics.UnitThrottlePreset.Loiter:
					this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
					break;
				case ActiveUnit_Kinematics.UnitThrottlePreset.Cruise:
					this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
					break;
				case ActiveUnit_Kinematics.UnitThrottlePreset.Full:
					this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Full, null);
					break;
				case ActiveUnit_Kinematics.UnitThrottlePreset.Flank:
					this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
					break;
				}
				this.activeUnit_0.vmethod_87().vmethod_11(new float?((float)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), (ActiveUnit.Throttle)this.vmethod_1(), false)));
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00007CC5 File Offset: 0x00005EC5
		public virtual void vmethod_3(float float_5)
		{
			this.float_3 = float_5;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00007CCE File Offset: 0x00005ECE
		public virtual float vmethod_4()
		{
			return this.float_3;
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00007CD6 File Offset: 0x00005ED6
		public virtual void vmethod_5(float float_5)
		{
			this.float_4 = float_5;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00007CDF File Offset: 0x00005EDF
		public virtual float vmethod_6()
		{
			return this.float_4;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00007CE7 File Offset: 0x00005EE7
		public virtual void vmethod_7()
		{
			this.vmethod_3(0f);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0000710A File Offset: 0x0000530A
		public virtual float vmethod_8(ActiveUnit.Throttle throttle_0, float float_5, float float_6)
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0000710A File Offset: 0x0000530A
		public virtual float vmethod_9(ActiveUnit.Throttle throttle_0, float float_5)
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00007CF4 File Offset: 0x00005EF4
		public virtual float? vmethod_10()
		{
			return this.nullable_0;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0009EC10 File Offset: 0x0009CE10
		public virtual void vmethod_11(float? nullable_4)
		{
			try
			{
				this.nullable_0 = nullable_4;
				if (Information.IsNothing(nullable_4))
				{
					this.activeUnit_0.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.None);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100170", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00007CFC File Offset: 0x00005EFC
		public virtual bool vmethod_12()
		{
			return this.bool_0;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0009EC8C File Offset: 0x0009CE8C
		public virtual void vmethod_13(bool bool_3)
		{
			try
			{
				this.bool_0 = bool_3;
				if (!bool_3)
				{
					if (this.activeUnit_0.bool_5)
					{
						((Submarine)this.activeUnit_0).method_153().method_115(ActiveUnit_AI.SubmarineDepthPreset.None);
					}
					if (this.activeUnit_0.bool_3)
					{
						((Aircraft)this.activeUnit_0).method_158().method_115(ActiveUnit_AI.AircraftAltitudePreset.None);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100171", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00007D04 File Offset: 0x00005F04
		public virtual float vmethod_14(bool LimitByTrueAirspeed = true)
		{
			return this.float_0;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00007D0C File Offset: 0x00005F0C
		public virtual void vmethod_15(bool LimitByTrueAirspeed = true, float value)
		{
			this.float_0 = value;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0009ED34 File Offset: 0x0009CF34
		public virtual float vmethod_16()
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
					result = (float)Math.Min((double)this.vmethod_14(true), (double)this.activeUnit_0.vmethod_40() * 0.514444 * Math2.smethod_1((double)this.activeUnit_0.vmethod_18()));
				}
			}
			else
			{
				result = this.vmethod_14(true);
			}
			return result;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00007D04 File Offset: 0x00005F04
		public virtual float vmethod_17()
		{
			return this.float_0;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00007D15 File Offset: 0x00005F15
		public virtual float vmethod_18()
		{
			return 0f;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00007D15 File Offset: 0x00005F15
		public virtual float vmethod_19()
		{
			return 0f;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00007D15 File Offset: 0x00005F15
		public virtual float vmethod_20()
		{
			return 0f;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0009EDAC File Offset: 0x0009CFAC
		public virtual float vmethod_21()
		{
			float result;
			if (this.activeUnit_0.bool_3 && ((Aircraft)this.activeUnit_0).method_169())
			{
				result = this.float_0 * 5f;
			}
			else
			{
				result = this.float_0 * 3f;
			}
			return result;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0009EDF8 File Offset: 0x0009CFF8
		public virtual float vmethod_22()
		{
			float result;
			if (this.activeUnit_0.bool_3 && ((Aircraft)this.activeUnit_0).method_169())
			{
				result = this.float_0 * 10f;
			}
			else
			{
				result = this.float_0 * 3f;
			}
			return result;
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0009EE44 File Offset: 0x0009D044
		public virtual float vmethod_23()
		{
			float result;
			if (this.activeUnit_0.vmethod_6())
			{
				if (this.activeUnit_0.vmethod_18() >= 0f)
				{
					result = 0f;
				}
				else
				{
					result = (float)Math.Min((double)this.vmethod_21(), (double)this.activeUnit_0.vmethod_40() * 0.514444 * Math2.smethod_1((double)Math.Abs(this.activeUnit_0.vmethod_18())));
				}
			}
			else
			{
				result = this.vmethod_21();
			}
			return result;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00007D1C File Offset: 0x00005F1C
		public virtual float vmethod_24(bool bool_3, float? nullable_4, float? nullable_5)
		{
			return float.MaxValue;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00007D1C File Offset: 0x00005F1C
		public virtual float vmethod_25()
		{
			return float.MaxValue;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00007D1C File Offset: 0x00005F1C
		public virtual float vmethod_26()
		{
			return float.MaxValue;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00007D23 File Offset: 0x00005F23
		public ActiveUnit_Kinematics(ref ActiveUnit activeUnit_1)
		{
			this.float_3 = 0f;
			this.float_4 = 0f;
			this.unitThrottlePreset_0 = ActiveUnit_Kinematics.UnitThrottlePreset.None;
			this.activeUnit_0 = activeUnit_1;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00007D50 File Offset: 0x00005F50
		public void method_1()
		{
			this.nullable_1 = null;
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0009EEC0 File Offset: 0x0009D0C0
		public virtual void vmethod_27(float elapsedTime, bool UseFormUpAltitude = false, bool UseLandingQueueAltitude = false)
		{
			this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_7(this.activeUnit_0.vmethod_9() + 3f * elapsedTime));
			this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0009EF08 File Offset: 0x0009D108
		public virtual void vmethod_28(float float_5)
		{
			try
			{
				float num = this.activeUnit_0.vmethod_87().vmethod_49() * float_5;
				Misc.Enum143 @enum = Misc.smethod_63(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_68());
				if (@enum != Misc.Enum143.const_0)
				{
					if (@enum == Misc.Enum143.const_1)
					{
						this.activeUnit_0.vmethod_10(Math2.smethod_7(this.activeUnit_0.vmethod_9() + num));
						if (this.method_3(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_68()))
						{
							this.activeUnit_0.vmethod_10(this.activeUnit_0.vmethod_68());
						}
					}
				}
				else
				{
					this.activeUnit_0.vmethod_10(Math2.smethod_7(this.activeUnit_0.vmethod_9() - num));
					if (this.method_2(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_68()))
					{
						this.activeUnit_0.vmethod_10(this.activeUnit_0.vmethod_68());
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100172", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0009F040 File Offset: 0x0009D240
		protected bool method_2(float float_5, float float_6)
		{
			return Math2.smethod_7(float_5 - float_6) > 180f;
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0009F06C File Offset: 0x0009D26C
		protected bool method_3(float float_5, float float_6)
		{
			return Math2.smethod_7(float_5 - float_6) <= 180f;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0009F098 File Offset: 0x0009D298
		public virtual float vmethod_29(Doctrine._FuelState? nullable_4)
		{
			float result;
			try
			{
				float num;
				foreach (FuelRec fuelRec in this.activeUnit_0.vmethod_67())
				{
					num += fuelRec.float_0;
				}
				AltBand altBand = this.activeUnit_0.vmethod_49()[0].method_24(ActiveUnit.Throttle.Cruise);
				result = (float)((double)(num / this.activeUnit_0.vmethod_98(ActiveUnit.Throttle.Cruise, altBand, null, null, false, false, false, false, false)) * ((double)this.vmethod_40(altBand.float_0, ActiveUnit.Throttle.Cruise, false) / 3600.0));
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100175", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0009F17C File Offset: 0x0009D37C
		public float method_4(float float_5, ActiveUnit.Throttle throttle_0, float float_6, float? nullable_4, bool bool_3, bool bool_4, bool bool_5)
		{
			float result;
			try
			{
				if (float_5 == 0f)
				{
					result = 0f;
				}
				else
				{
					float? num = nullable_4;
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0f) : null).GetValueOrDefault())
					{
						result = 0f;
					}
					else if (this.activeUnit_0.vmethod_49().Count == 0)
					{
						result = 0f;
					}
					else
					{
						float num2 = this.activeUnit_0.vmethod_98(throttle_0, null, nullable_4, new float?(float_6), false, false, bool_3, bool_4, bool_5);
						result = (float)((long)Math.Round((double)(float_5 / nullable_4 * 3600f).Value)) * num2;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100176", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0009F2C8 File Offset: 0x0009D4C8
		public float method_5(float float_5, float float_6, float float_7, float float_8, ActiveUnit_Kinematics.UnitThrottlePreset unitThrottlePreset_1, float? nullable_4, bool bool_3, bool bool_4, bool bool_5, ref float float_9, ref float float_10)
		{
			float result;
			try
			{
				if (this.activeUnit_0.vmethod_49().Count == 0)
				{
					result = 0f;
				}
				else
				{
					AltBand altBand;
					AltBand altBand2;
					float num;
					float num2;
					float num3;
					if (float_6 > float_5)
					{
						altBand = ActiveUnit_Kinematics.smethod_1(this.activeUnit_0, float_5, null, false);
						altBand2 = ActiveUnit_Kinematics.smethod_1(this.activeUnit_0, float_6, null, false);
						num = float_7;
						num2 = float_5;
						num3 = float_6;
					}
					else
					{
						altBand = ActiveUnit_Kinematics.smethod_1(this.activeUnit_0, float_6, null, false);
						altBand2 = ActiveUnit_Kinematics.smethod_1(this.activeUnit_0, float_5, null, false);
						num = float_8;
						num2 = float_6;
						num3 = float_5;
					}
					float num6;
					if (altBand == altBand2)
					{
						float num4 = num3 - num2;
						ActiveUnit.Throttle throttle;
						ActiveUnit.Throttle throttle2;
						if (unitThrottlePreset_1 == ActiveUnit_Kinematics.UnitThrottlePreset.None && !Information.IsNothing(nullable_4))
						{
							throttle = this.vmethod_41(num2, nullable_4.Value);
							throttle2 = this.vmethod_41(num3, nullable_4.Value);
						}
						else
						{
							throttle = (ActiveUnit.Throttle)unitThrottlePreset_1;
							throttle2 = throttle;
						}
						if (altBand == this.activeUnit_0.vmethod_87().method_11(this.activeUnit_0.vmethod_49()[0]))
						{
							float num5 = this.activeUnit_0.vmethod_98(throttle, null, nullable_4, new float?(num2), false, false, bool_3, bool_4, bool_5);
							float_10 = num4 / num;
							num6 = float_10 * num5;
							float num7;
							if (!Information.IsNothing(throttle))
							{
								num7 = (float)this.activeUnit_0.vmethod_87().vmethod_40(num2, throttle, false);
							}
							else
							{
								num7 = nullable_4.Value;
							}
							float_9 = float_10 * num7 * 3600f;
						}
						else
						{
							float num8 = this.activeUnit_0.vmethod_98(throttle, null, nullable_4, new float?(num2), false, false, bool_3, bool_4, bool_5);
							float num9 = this.activeUnit_0.vmethod_98(throttle2, null, nullable_4, new float?(num3), false, false, bool_3, bool_4, bool_5);
							float num5 = (num8 + num9) / 2f;
							float_10 = num4 / num;
							num6 = float_10 * num5;
							float num10 = (float)this.activeUnit_0.vmethod_87().vmethod_40(num2, throttle, false);
							float num11 = (float)this.activeUnit_0.vmethod_87().vmethod_40(num3, throttle2, false);
							float num12 = (num10 + num11) / 2f;
							float_9 = float_10 * num12 / 3600f;
						}
					}
					else
					{
						bool flag = false;
						ActiveUnit.Throttle throttle3;
						ActiveUnit.Throttle throttle4;
						if (unitThrottlePreset_1 != ActiveUnit_Kinematics.UnitThrottlePreset.None || Information.IsNothing(nullable_4))
						{
							throttle3 = (ActiveUnit.Throttle)unitThrottlePreset_1;
							throttle4 = throttle3;
						}
						foreach (AltBand altBand3 in this.activeUnit_0.vmethod_49()[0].altBand_0)
						{
							if (altBand3 == altBand)
							{
								flag = true;
								float num13 = altBand3.float_0 - num2;
								if (num13 != 0f)
								{
									if (unitThrottlePreset_1 == ActiveUnit_Kinematics.UnitThrottlePreset.None && !Information.IsNothing(nullable_4))
									{
										throttle3 = this.vmethod_41(num2, nullable_4.Value);
										throttle4 = this.vmethod_41(altBand3.float_0, nullable_4.Value);
									}
									float num14 = this.activeUnit_0.vmethod_98(throttle3, null, nullable_4, new float?(num2), false, false, bool_3, bool_4, bool_5);
									float num15 = this.activeUnit_0.vmethod_98(throttle4, null, nullable_4, new float?(altBand3.float_0), false, false, bool_3, bool_4, bool_5);
									float num5 = (num14 + num15) / 2f;
									float_10 = num13 / num;
									num6 = float_10 * num5;
									float num16 = (float)this.activeUnit_0.vmethod_87().vmethod_40(num2, throttle3, false);
									float num17 = (float)this.activeUnit_0.vmethod_87().vmethod_40(altBand3.float_0, throttle4, false);
									float num18 = (num16 + num17) / 2f;
									float_9 = float_10 * num18 / 3600f;
								}
							}
							else if (altBand3 == altBand2)
							{
								float num19 = num3 - altBand3.float_1;
								if (num19 != 0f)
								{
									if (unitThrottlePreset_1 == ActiveUnit_Kinematics.UnitThrottlePreset.None && !Information.IsNothing(nullable_4))
									{
										throttle3 = throttle4;
										throttle4 = this.vmethod_41(num3, nullable_4.Value);
									}
									float num15;
									float num20 = num15;
									num15 = this.activeUnit_0.vmethod_98(throttle3, null, nullable_4, new float?(num3), false, false, bool_3, bool_4, bool_5);
									float num5 = (num20 + num15) / 2f;
									float num21 = num19 / num;
									float_10 += num21;
									num6 += num21 * num5;
									float num17;
									float num22 = num17;
									num17 = (float)this.activeUnit_0.vmethod_87().vmethod_40(num3, throttle3, false);
									float num23 = (num22 + num17) / 2f;
									float_9 += num21 * num23 / 3600f;
									break;
								}
							}
							else if (flag)
							{
								float num24 = altBand3.float_0 - altBand3.float_1;
								if (num24 != 0f)
								{
									if (unitThrottlePreset_1 == ActiveUnit_Kinematics.UnitThrottlePreset.None && !Information.IsNothing(nullable_4))
									{
										throttle3 = throttle4;
										throttle4 = this.vmethod_41(altBand3.float_0, nullable_4.Value);
									}
									float num15;
									float num25 = num15;
									num15 = this.activeUnit_0.vmethod_98(throttle3, null, nullable_4, new float?(altBand3.float_0), false, false, bool_3, bool_4, bool_5);
									float num5 = (num25 + num15) / 2f;
									float num21 = num24 / num;
									float_10 += num21;
									num6 += num21 * num5;
									float num17;
									float num26 = num17;
									num17 = (float)this.activeUnit_0.vmethod_87().vmethod_40(altBand3.float_0, throttle3, false);
									float num27 = (num26 + num17) / 2f;
									float_9 += num21 * num27 / 3600f;
								}
							}
						}
					}
					result = num6;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100176", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				float_9 = 0f;
				float_10 = 0f;
				result = 0f;
			}
			return result;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0009F874 File Offset: 0x0009DA74
		public float method_6(int int_0, ActiveUnit.Throttle throttle_0, float float_5, float? nullable_4, bool bool_3)
		{
			float result;
			try
			{
				if (int_0 == 0)
				{
					result = 0f;
				}
				else if (this.activeUnit_0.vmethod_49().Count == 0)
				{
					result = 0f;
				}
				else
				{
					float num = this.activeUnit_0.vmethod_98(throttle_0, null, nullable_4, new float?(float_5), false, false, bool_3, false, false);
					result = (float)int_0 * num;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101248", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0009F914 File Offset: 0x0009DB14
		public int method_7(float float_5)
		{
			int result;
			if (float_5 < -500f)
			{
				result = int.MaxValue;
			}
			else
			{
				switch (this.activeUnit_0.method_98())
				{
				case GlobalVariables.Enum145.const_0:
					if (float_5 > -200f)
					{
						result = 8;
					}
					else if (float_5 > -300f)
					{
						result = 13;
					}
					else if (float_5 > -400f)
					{
						result = 25;
					}
					else
					{
						result = int.MaxValue;
					}
					break;
				case GlobalVariables.Enum145.const_1:
					if (float_5 > -100f)
					{
						result = 8;
					}
					else if (float_5 > -200f)
					{
						result = 13;
					}
					else if (float_5 > -300f)
					{
						result = 25;
					}
					else
					{
						result = int.MaxValue;
					}
					break;
				case GlobalVariables.Enum145.const_2:
					if (float_5 > -50f)
					{
						result = 8;
					}
					else if (float_5 > -100f)
					{
						result = 13;
					}
					else if (float_5 > -200f)
					{
						result = 25;
					}
					else
					{
						result = int.MaxValue;
					}
					break;
				case GlobalVariables.Enum145.const_3:
					if (float_5 > -50f)
					{
						result = 13;
					}
					else if (float_5 > -100f)
					{
						result = 25;
					}
					else
					{
						result = int.MaxValue;
					}
					break;
				case GlobalVariables.Enum145.const_4:
					if (float_5 > -50f)
					{
						result = 25;
					}
					else
					{
						result = int.MaxValue;
					}
					break;
				default:
					result = int.MaxValue;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00007D5E File Offset: 0x00005F5E
		public void method_8()
		{
			this.nullable_2 = null;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0009FA44 File Offset: 0x0009DC44
		public virtual float vmethod_30()
		{
			float result;
			try
			{
				if (this.nullable_2 != null)
				{
					result = this.nullable_2.Value;
				}
				else
				{
					float num = 0f;
					try
					{
						foreach (Engine engine in this.activeUnit_0.vmethod_49())
						{
							AltBand[] array = engine.altBand_0;
							int num2 = array.Length - 1;
							for (int i = 0; i <= num2; i++)
							{
								AltBand altBand = array[i];
								if (altBand.float_0 > num)
								{
									num = altBand.float_0;
								}
							}
						}
					}
					finally
					{
						List<Engine>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.nullable_2 = new float?(num);
					result = num;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100177", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0009FB4C File Offset: 0x0009DD4C
		public virtual float vmethod_31()
		{
			float result;
			try
			{
				if (this.nullable_3 != null)
				{
					result = this.nullable_3.Value;
				}
				else
				{
					float num = 9999999f;
					try
					{
						foreach (Engine engine in this.activeUnit_0.vmethod_49())
						{
							if (engine.altBand_0.Length == 0)
							{
								return 0f;
							}
							AltBand[] array = engine.altBand_0;
							int num2 = array.Length - 1;
							for (int i = 0; i <= num2; i++)
							{
								AltBand altBand = array[i];
								if (altBand.float_1 <= num)
								{
									num = altBand.float_1;
								}
							}
						}
					}
					finally
					{
						List<Engine>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.nullable_3 = new float?(num);
					result = num;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100178", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0009FC68 File Offset: 0x0009DE68
		public virtual float vmethod_32(float float_5, bool bool_3)
		{
			float result;
			try
			{
				if (!this.activeUnit_0.bool_8 && !this.activeUnit_0.bool_6 && !this.activeUnit_0.bool_5)
				{
					if (this.activeUnit_0.bool_3 && ((Aircraft)this.activeUnit_0).method_169())
					{
						result = 0f;
					}
					else if (this.activeUnit_0.vmethod_49().Count == 0)
					{
						result = 0f;
					}
					else if (this.activeUnit_0.vmethod_49()[0].vmethod_5() == PlatformComponent._ComponentStatus.Destroyed)
					{
						result = 0f;
					}
					else if (this.activeUnit_0.vmethod_49()[0].altBand_0.Length == 0)
					{
						result = 0f;
					}
					else
					{
						AltBand altBand = this.vmethod_42(float_5, bool_3);
						if (Information.IsNothing(altBand))
						{
							if (this.activeUnit_0.bool_3)
							{
								altBand = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderByDescending<AltBand, float>(this.activeUnit_0.vmethod_49()[0].altBand_0, (ActiveUnit_Kinematics._Closure$__.$I91-0 == null) ? (ActiveUnit_Kinematics._Closure$__.$I91-0 = new Func<AltBand, float>(ActiveUnit_Kinematics._Closure$__.$I.method_0)) : ActiveUnit_Kinematics._Closure$__.$I91-0), 0);
								if (bool_3)
								{
									this.activeUnit_0.vmethod_15(false, altBand.float_0);
								}
							}
							else
							{
								altBand = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderBy<AltBand, float>(this.activeUnit_0.vmethod_49()[0].altBand_0, (ActiveUnit_Kinematics._Closure$__.$I91-1 == null) ? (ActiveUnit_Kinematics._Closure$__.$I91-1 = new Func<AltBand, float>(ActiveUnit_Kinematics._Closure$__.$I.method_1)) : ActiveUnit_Kinematics._Closure$__.$I91-1), 0);
								if (bool_3)
								{
									this.activeUnit_0.vmethod_15(true, altBand.float_1);
								}
							}
						}
						result = (float)altBand.int_0;
					}
				}
				else
				{
					result = 0f;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100179", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0009FE74 File Offset: 0x0009E074
		public virtual int vmethod_33(float float_5, ActiveUnit.Throttle throttle_0, bool bool_3)
		{
			int result;
			try
			{
				ActiveUnit_Kinematics.Class208 @class = new ActiveUnit_Kinematics.Class208();
				@class.altBand_0 = null;
				if (!this.activeUnit_0.bool_8 && !this.activeUnit_0.bool_6 && !this.activeUnit_0.bool_5)
				{
					if (this.activeUnit_0.bool_3 && ((Aircraft)this.activeUnit_0).method_169())
					{
						result = 0;
					}
					else if (throttle_0 == ActiveUnit.Throttle.FullStop)
					{
						result = 0;
					}
					else
					{
						ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)(throttle_0 - ActiveUnit.Throttle.Loiter);
						if (this.activeUnit_0.bool_3 && throttle == ActiveUnit.Throttle.FullStop)
						{
							throttle = ActiveUnit.Throttle.Loiter;
						}
						if (this.activeUnit_0.vmethod_49().Count == 0)
						{
							result = 0;
						}
						else if (this.activeUnit_0.vmethod_49()[0].vmethod_5() == PlatformComponent._ComponentStatus.Destroyed)
						{
							result = 0;
						}
						else if (this.activeUnit_0.vmethod_49()[0].altBand_0.Length == 0)
						{
							result = 0;
						}
						else
						{
							AltBand[] array = this.activeUnit_0.vmethod_49()[0].altBand_0;
							if (array.Length == 0)
							{
								result = 0;
							}
							else
							{
								@class.altBand_0 = this.vmethod_42(float_5, bool_3);
								if (Information.IsNothing(@class.altBand_0))
								{
									result = 0;
								}
								else
								{
									float num;
									switch (throttle)
									{
									case ActiveUnit.Throttle.FullStop:
										num = 0f;
										break;
									case ActiveUnit.Throttle.Loiter:
										num = (float)@class.altBand_0.int_0;
										break;
									case ActiveUnit.Throttle.Cruise:
										if (@class.altBand_0.int_1 > 0)
										{
											num = (float)@class.altBand_0.int_1;
										}
										else
										{
											num = (float)@class.altBand_0.int_0;
										}
										break;
									case ActiveUnit.Throttle.Full:
										if (@class.altBand_0.nullable_0 == null)
										{
											num = (float)@class.altBand_0.int_1;
										}
										else
										{
											num = (float)@class.altBand_0.nullable_0.Value;
										}
										break;
									case ActiveUnit.Throttle.Flank:
										if (@class.altBand_0.nullable_1 == null)
										{
											if (@class.altBand_0.nullable_0 == null)
											{
												num = (float)@class.altBand_0.int_1;
											}
											else
											{
												num = (float)@class.altBand_0.nullable_0.Value;
											}
										}
										else
										{
											num = (float)@class.altBand_0.nullable_1.Value;
										}
										break;
									}
									int num2 = (int)Math.Round((double)num);
									if (!this.activeUnit_0.bool_6 && !this.activeUnit_0.bool_5 && !this.activeUnit_0.bool_8 && @class.altBand_0 != this.method_11(this.activeUnit_0.vmethod_49()[0]))
									{
										AltBand altBand = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderBy<AltBand, float>(Enumerable.Where<AltBand>(array, new Func<AltBand, bool>(@class.method_0)), (ActiveUnit_Kinematics._Closure$__.$I92-1 == null) ? (ActiveUnit_Kinematics._Closure$__.$I92-1 = new Func<AltBand, float>(ActiveUnit_Kinematics._Closure$__.$I.method_2)) : ActiveUnit_Kinematics._Closure$__.$I92-1), 0);
										float num3;
										switch (throttle)
										{
										case ActiveUnit.Throttle.FullStop:
											num3 = 0f;
											break;
										case ActiveUnit.Throttle.Loiter:
											num3 = (float)altBand.int_0;
											break;
										case ActiveUnit.Throttle.Cruise:
											num3 = (float)altBand.int_1;
											break;
										case ActiveUnit.Throttle.Full:
											if (altBand.nullable_0 == null)
											{
												num3 = (float)altBand.int_1;
											}
											else
											{
												num3 = (float)altBand.nullable_0.Value;
											}
											break;
										case ActiveUnit.Throttle.Flank:
											if (altBand.nullable_1 == null)
											{
												if (altBand.nullable_0 == null)
												{
													num3 = (float)altBand.int_1;
												}
												else
												{
													num3 = (float)altBand.nullable_0.Value;
												}
											}
											else
											{
												num3 = (float)altBand.nullable_1.Value;
											}
											break;
										}
										num2 = (int)Math.Round((double)(num3 + (float_5 - altBand.float_1) * (num - num3) / (@class.altBand_0.float_1 - altBand.float_1)));
									}
									if (this.activeUnit_0.bool_3)
									{
										num2 = (int)Math.Round((double)ActiveUnit_Kinematics.smethod_2((float)num2));
										result = num2;
									}
									else
									{
										result = num2 + 1;
									}
								}
							}
						}
					}
				}
				else
				{
					result = 0;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100180", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x000A02B0 File Offset: 0x0009E4B0
		public bool method_9()
		{
			AltBand altBand = this.vmethod_42(this.activeUnit_0.vmethod_14(false), true);
			return !Information.IsNothing(altBand) && (altBand.float_2 < 0f && altBand.int_0 < 0);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000A02FC File Offset: 0x0009E4FC
		public bool method_10()
		{
			bool result;
			try
			{
				AltBand altBand = this.vmethod_42(this.activeUnit_0.vmethod_14(false), false);
				if (Information.IsNothing(altBand))
				{
					result = false;
				}
				else if (altBand.nullable_2 != null && altBand.nullable_0 != null)
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
				ex.Data.Add("Error at 100181", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x000A0394 File Offset: 0x0009E594
		public virtual bool vmethod_34()
		{
			bool result;
			try
			{
				AltBand altBand = this.vmethod_42(this.activeUnit_0.vmethod_14(false), false);
				if (Information.IsNothing(altBand))
				{
					result = false;
				}
				else if (altBand.nullable_3 != null && altBand.nullable_1 != null)
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
				ex.Data.Add("Error at 100182", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x000A042C File Offset: 0x0009E62C
		public virtual long vmethod_35(bool TotalRemainingEndurance = false)
		{
			long result;
			try
			{
				float num;
				foreach (FuelRec fuelRec in this.activeUnit_0.vmethod_67())
				{
					num += fuelRec.float_0;
				}
				if (!TotalRemainingEndurance)
				{
					num -= this.activeUnit_0.vmethod_87().vmethod_4();
				}
				float num2 = this.activeUnit_0.vmethod_98(this.activeUnit_0.vmethod_84(), null, null, null, false, false, false, false, false);
				if (num2 == 0f)
				{
					result = long.MaxValue;
				}
				else
				{
					result = (long)Math.Round((double)(num / num2));
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100184", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x000A0518 File Offset: 0x0009E718
		public virtual long vmethod_36(float float_5, float float_6, bool bool_3, bool bool_4)
		{
			long result;
			try
			{
				if (float_5 == 0f)
				{
					result = long.MaxValue;
				}
				else
				{
					float num;
					if (bool_4 && this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_164().method_32(false)))
					{
						num = ((Aircraft)this.activeUnit_0).float_33;
					}
					else
					{
						foreach (FuelRec fuelRec in this.activeUnit_0.vmethod_67())
						{
							num += fuelRec.float_0;
						}
						if (!bool_3)
						{
							num -= this.activeUnit_0.vmethod_87().vmethod_4();
						}
					}
					if (float.IsNaN(num))
					{
						result = 0L;
					}
					else
					{
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
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100185", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0L;
			}
			return result;
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x000A0690 File Offset: 0x0009E890
		public virtual long vmethod_37(ActiveUnit.Throttle throttle_0, float float_5, bool bool_3)
		{
			long result;
			try
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
				result = (long)Math.Round((double)(num / this.activeUnit_0.vmethod_98(throttle_0, null, null, null, false, false, false, false, false)));
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

		// Token: 0x060009A9 RID: 2473 RVA: 0x000A0758 File Offset: 0x0009E958
		public virtual int vmethod_38()
		{
			int result;
			try
			{
				if (this.nullable_1 == null)
				{
					if (this.activeUnit_0.vmethod_49().Count == 0)
					{
						return 0;
					}
					HashSet<int> hashSet = new HashSet<int>();
					try
					{
						foreach (Engine engine in this.activeUnit_0.vmethod_49())
						{
							foreach (AltBand altBand in engine.altBand_0)
							{
								hashSet.Add(altBand.method_0());
							}
						}
					}
					finally
					{
						List<Engine>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (hashSet.Count == 0)
					{
						this.nullable_1 = new int?(0);
					}
					else
					{
						this.nullable_1 = new int?(Enumerable.Max(hashSet));
					}
				}
				result = this.nullable_1.Value;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100186", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x000A0880 File Offset: 0x0009EA80
		public virtual int vmethod_39(float float_5)
		{
			ActiveUnit_Kinematics.Class209 @class = new ActiveUnit_Kinematics.Class209();
			int result;
			try
			{
				if (this.activeUnit_0.vmethod_49().Count == 0)
				{
					result = 0;
				}
				else
				{
					AltBand[] array = this.activeUnit_0.vmethod_49()[0].altBand_0;
					if (this.activeUnit_0.vmethod_49()[0].vmethod_5() == PlatformComponent._ComponentStatus.Destroyed)
					{
						result = 0;
					}
					else if (array.Length == 0)
					{
						result = 0;
					}
					else
					{
						@class.altBand_0 = ActiveUnit_Kinematics.smethod_1(this.activeUnit_0, float_5, null, false);
						if (@class.altBand_0 == null)
						{
							result = 0;
						}
						else
						{
							int num = @class.altBand_0.method_0();
							int num2 = num;
							if (!this.activeUnit_0.bool_6 && !this.activeUnit_0.bool_5 && !this.activeUnit_0.bool_8 && @class.altBand_0 != this.method_11(this.activeUnit_0.vmethod_49()[0]))
							{
								AltBand altBand = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderBy<AltBand, float>(Enumerable.Where<AltBand>(array, new Func<AltBand, bool>(@class.method_0)), (ActiveUnit_Kinematics._Closure$__.$I105-1 == null) ? (ActiveUnit_Kinematics._Closure$__.$I105-1 = new Func<AltBand, float>(ActiveUnit_Kinematics._Closure$__.$I.method_3)) : ActiveUnit_Kinematics._Closure$__.$I105-1), 0);
								float num3 = (float)altBand.method_0();
								num2 = (int)Math.Round((double)(num3 + (float_5 - altBand.float_1) * ((float)num - num3) / (@class.altBand_0.float_1 - altBand.float_1)));
							}
							if (this.activeUnit_0.bool_3)
							{
								num2 = (int)Math.Round((double)ActiveUnit_Kinematics.smethod_2((float)num2));
							}
							result = num2;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100187", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x000A0A70 File Offset: 0x0009EC70
		public static AltBand smethod_1(ActiveUnit activeUnit_1, float float_5, int? nullable_4, bool bool_3)
		{
			AltBand altBand = null;
			AltBand result;
			try
			{
				if (activeUnit_1.bool_7)
				{
					result = activeUnit_1.vmethod_49()[0].altBand_0[0];
				}
				else if (activeUnit_1.bool_6)
				{
					if (activeUnit_1.vmethod_49()[0].altBand_0.Length == 0)
					{
						result = null;
					}
					else
					{
						result = activeUnit_1.vmethod_49()[0].altBand_0[0];
					}
				}
				else
				{
					if (nullable_4 == null && activeUnit_1.bool_5 && activeUnit_1.vmethod_49().Count > 1 && float_5 == activeUnit_1.vmethod_14(false))
					{
						Submarine submarine = (Submarine)activeUnit_1;
						if (submarine.method_146() == null)
						{
							submarine.method_153().method_117();
						}
						if (submarine.method_146() != null)
						{
							nullable_4 = new int?(submarine.method_148());
						}
					}
					AltBand[] array;
					if (nullable_4 == null)
					{
						nullable_4 = new int?(0);
						int num = activeUnit_1.vmethod_49().Count - 1;
						int i = 0;
						IL_1B0:
						while (i <= num)
						{
							nullable_4 = new int?(i);
							array = activeUnit_1.vmethod_49()[nullable_4.Value].altBand_0;
							int num2 = array.Length;
							int j = num2 - 1;
							while (j >= 0)
							{
								AltBand altBand2 = array[j];
								if (num2 >= 2 && ((j >= 1 && array[j].float_1 - array[j - 1].float_0 != 0f) || (j == 0 && array[j].float_0 - array[j + 1].float_1 != 0f)))
								{
									if (altBand2.float_0 >= float_5 && float_5 + 1f >= altBand2.float_1)
									{
										altBand = altBand2;
										break;
									}
								}
								else if (altBand2.float_0 >= float_5 && float_5 >= altBand2.float_1)
								{
									altBand = altBand2;
									break;
								}
								j += -1;
								continue;
								IL_1A4:
								if (altBand == null)
								{
									i++;
									goto IL_1B0;
								}
								goto IL_273;
							}
							goto IL_1A4;
						}
					}
					else
					{
						array = activeUnit_1.vmethod_49()[nullable_4.Value].altBand_0;
						int num3 = Enumerable.Count<AltBand>(array);
						for (int k = num3 - 1; k >= 0; k += -1)
						{
							AltBand altBand2 = array[k];
							if (num3 >= 2 && ((k >= 1 && array[k].float_1 - array[k - 1].float_0 != 0f) || (k == 0 && array[k].float_0 - array[k + 1].float_1 != 0f)))
							{
								if (altBand2.float_0 >= float_5 && float_5 + 1f >= altBand2.float_1)
								{
									altBand = altBand2;
									break;
								}
							}
							else if (altBand2.float_0 >= float_5 && float_5 >= altBand2.float_1)
							{
								altBand = altBand2;
								break;
							}
						}
					}
					IL_273:
					if (altBand == null)
					{
						if (activeUnit_1.bool_3)
						{
							altBand = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderByDescending<AltBand, float>(array, (ActiveUnit_Kinematics._Closure$__.$I106-0 == null) ? (ActiveUnit_Kinematics._Closure$__.$I106-0 = new Func<AltBand, float>(ActiveUnit_Kinematics._Closure$__.$I.method_4)) : ActiveUnit_Kinematics._Closure$__.$I106-0), 0);
							if (bool_3)
							{
								activeUnit_1.vmethod_15(false, altBand.float_0);
							}
						}
						else
						{
							altBand = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderBy<AltBand, float>(array, (ActiveUnit_Kinematics._Closure$__.$I106-1 == null) ? (ActiveUnit_Kinematics._Closure$__.$I106-1 = new Func<AltBand, float>(ActiveUnit_Kinematics._Closure$__.$I.method_5)) : ActiveUnit_Kinematics._Closure$__.$I106-1), 0);
							if (bool_3)
							{
								activeUnit_1.vmethod_15(true, altBand.float_1);
							}
						}
					}
					result = altBand;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100188", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x000A0DE0 File Offset: 0x0009EFE0
		public virtual int vmethod_40(float float_5, ActiveUnit.Throttle throttle_0, bool bool_3)
		{
			int result;
			if (float.IsNaN(float_5))
			{
				result = 0;
			}
			else
			{
				try
				{
					if (throttle_0 == ActiveUnit.Throttle.FullStop)
					{
						result = 0;
					}
					else if (this.activeUnit_0.vmethod_49().Count == 0)
					{
						if (this.activeUnit_0.method_5())
						{
							result = 0;
						}
						else
						{
							result = 30;
						}
					}
					else
					{
						AltBand altBand = ActiveUnit_Kinematics.smethod_1(this.activeUnit_0, float_5, null, bool_3);
						if (altBand == null)
						{
							result = 0;
						}
						else
						{
							Engine engine;
							if (this.activeUnit_0.bool_5)
							{
								engine = this.method_12(altBand);
							}
							else
							{
								engine = this.activeUnit_0.vmethod_49()[0];
							}
							AltBand[] array = engine.altBand_0;
							if (engine.vmethod_5() == PlatformComponent._ComponentStatus.Destroyed)
							{
								result = 0;
							}
							else if (array.Length == 0)
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
								float val = Math.Max((float)num2 * (100f - this.activeUnit_0.vmethod_91().method_0()) / 100f, 0f);
								float val2;
								switch (engine.vmethod_5())
								{
								case PlatformComponent._ComponentStatus.Operational:
									val2 = (float)num2;
									break;
								case PlatformComponent._ComponentStatus.Damaged:
									val2 = (float)((double)num2 / 2.0);
									break;
								case PlatformComponent._ComponentStatus.Destroyed:
									val2 = 0f;
									break;
								}
								num2 = (int)Math.Round((double)Math.Min(val, val2));
								if (this.activeUnit_0.bool_6 && this.activeUnit_0.method_15())
								{
									float num3 = Terrain.smethod_8(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), false);
									if ((double)num3 > 0.5)
									{
										num2 = (int)Math.Round(Math.Max(1.0, (double)num2 / 10.0));
									}
									else
									{
										num2 = (int)Math.Round(Math.Max((double)num2 / 10.0, (double)((float)num2 * (1f - num3))));
									}
								}
								result = num2;
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100189", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
			return result;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x000A10F0 File Offset: 0x0009F2F0
		public static float smethod_2(float float_5)
		{
			float result;
			if (float_5 > 415f)
			{
				result = (float)(Math.Round((double)(float_5 / 10f)) * 10.0);
			}
			else
			{
				result = (float)(Math.Round((double)(float_5 / 5f)) * 5.0);
			}
			return result;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x000A113C File Offset: 0x0009F33C
		public AltBand method_11(Engine engine_0)
		{
			AltBand result;
			try
			{
				if (Information.IsNothing(engine_0))
				{
					result = null;
				}
				else if (engine_0.altBand_0.Length == 0)
				{
					result = null;
				}
				else if (this.activeUnit_0.bool_2 && engine_0 != this.activeUnit_0.vmethod_49()[0])
				{
					AltBand altBand = null;
					float minValue = float.MinValue;
					foreach (AltBand altBand2 in engine_0.altBand_0)
					{
						if (altBand2.float_1 > minValue)
						{
							altBand = altBand2;
							minValue = altBand2.float_1;
						}
					}
					result = altBand;
				}
				else
				{
					if (Information.IsNothing(this.altBand_0) || Operators.CompareString(this.string_0, engine_0.string_0, false) != 0)
					{
						AltBand altBand3 = null;
						float minValue2 = float.MinValue;
						foreach (AltBand altBand4 in engine_0.altBand_0)
						{
							if (altBand4.float_1 > minValue2)
							{
								altBand3 = altBand4;
								minValue2 = altBand4.float_1;
							}
						}
						this.altBand_0 = altBand3;
						this.string_0 = engine_0.string_0;
					}
					result = this.altBand_0;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100190", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x000A12A4 File Offset: 0x0009F4A4
		private Engine method_12(AltBand altBand_1)
		{
			Engine result;
			try
			{
				try
				{
					foreach (Engine engine in this.activeUnit_0.vmethod_49())
					{
						if (Enumerable.Contains<AltBand>(engine.altBand_0, altBand_1))
						{
							return engine;
						}
					}
				}
				finally
				{
					List<Engine>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = null;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100191", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x000A1350 File Offset: 0x0009F550
		public void method_13()
		{
			try
			{
				int num = this.activeUnit_0.vmethod_87().method_7(this.activeUnit_0.vmethod_14(false));
				if (this.activeUnit_0.vmethod_70() >= (float)num)
				{
					if (num == 1)
					{
						this.activeUnit_0.vmethod_71(1f);
					}
					else
					{
						this.activeUnit_0.vmethod_71((float)(num - 1));
					}
					this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_87().vmethod_41(this.activeUnit_0.vmethod_14(false), (float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))));
					this.activeUnit_0.vmethod_87().bool_1 = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100192", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x000A145C File Offset: 0x0009F65C
		public virtual ActiveUnit.Throttle vmethod_41(float float_5, float float_6)
		{
			ActiveUnit.Throttle result;
			try
			{
				ActiveUnit_Kinematics.Class210 @class = new ActiveUnit_Kinematics.Class210();
				if (this.activeUnit_0.vmethod_49().Count == 0)
				{
					result = ActiveUnit.Throttle.FullStop;
				}
				else
				{
					@class.altBand_0 = this.vmethod_42(float_5, false);
					if (@class.altBand_0 == null)
					{
						result = ActiveUnit.Throttle.FullStop;
					}
					else
					{
						AltBand[] array = this.activeUnit_0.vmethod_49()[0].altBand_0;
						int num = @class.altBand_0.int_0;
						int num2 = @class.altBand_0.int_1;
						int num3;
						if (@class.altBand_0.nullable_2 != null)
						{
							num3 = (int)@class.altBand_0.nullable_0.Value;
						}
						if (@class.altBand_0.nullable_3 != null)
						{
							int num4 = (int)@class.altBand_0.nullable_1.Value;
						}
						if (!this.activeUnit_0.bool_6 && !this.activeUnit_0.bool_5 && !this.activeUnit_0.bool_8 && @class.altBand_0 != this.method_11(this.activeUnit_0.vmethod_49()[0]))
						{
							AltBand altBand = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderBy<AltBand, float>(Enumerable.Where<AltBand>(array, new Func<AltBand, bool>(@class.method_0)), (ActiveUnit_Kinematics._Closure$__.$I113-1 == null) ? (ActiveUnit_Kinematics._Closure$__.$I113-1 = new Func<AltBand, float>(ActiveUnit_Kinematics._Closure$__.$I.method_6)) : ActiveUnit_Kinematics._Closure$__.$I113-1), 0);
							if (@class.altBand_0.int_0 != altBand.int_0)
							{
								num = (int)Math.Round((double)((float)altBand.int_0 + (float_5 - altBand.float_1) * (float)(@class.altBand_0.int_0 - altBand.int_0) / (@class.altBand_0.float_1 - altBand.float_1)));
								if (this.activeUnit_0.bool_3)
								{
									num = (int)Math.Round((double)ActiveUnit_Kinematics.smethod_2((float)num));
								}
							}
							if (@class.altBand_0.int_1 != altBand.int_1)
							{
								num2 = (int)Math.Round((double)((float)altBand.int_1 + (float_5 - altBand.float_1) * (float)(@class.altBand_0.int_1 - altBand.int_1) / (@class.altBand_0.float_1 - altBand.float_1)));
								if (this.activeUnit_0.bool_3)
								{
									num2 = (int)Math.Round((double)ActiveUnit_Kinematics.smethod_2((float)num2));
								}
							}
							if (@class.altBand_0.nullable_2 != null)
							{
								long? num5 = @class.altBand_0.nullable_0;
								long? num6 = altBand.nullable_0;
								if (((num5 != null & num6 != null) ? new bool?(num5.GetValueOrDefault() != num6.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									num6 = altBand.nullable_0;
									float? num7 = (num6 != null) ? new float?((float)num6.GetValueOrDefault()) : null;
									float num8 = float_5 - altBand.float_1;
									num6 = @class.altBand_0.nullable_0 - altBand.nullable_0;
									num3 = (int)Math.Round((double)(num7 + num8 * ((num6 != null) ? new float?((float)num6.GetValueOrDefault()) : null) / (@class.altBand_0.float_1 - altBand.float_1)).Value);
									if (this.activeUnit_0.bool_3)
									{
										num3 = (int)Math.Round((double)ActiveUnit_Kinematics.smethod_2((float)num3));
									}
								}
							}
							if (@class.altBand_0.nullable_2 != null)
							{
								long? num6 = @class.altBand_0.nullable_1;
								long? num9 = altBand.nullable_1;
								if (((num6 != null & num9 != null) ? new bool?(num6.GetValueOrDefault() != num9.GetValueOrDefault()) : null).GetValueOrDefault())
								{
									num9 = altBand.nullable_1;
									float? num10 = (num9 != null) ? new float?((float)num9.GetValueOrDefault()) : null;
									float num8 = float_5 - altBand.float_1;
									num9 = @class.altBand_0.nullable_1 - altBand.nullable_1;
									int num4 = (int)Math.Round((double)(num10 + num8 * ((num9 != null) ? new float?((float)num9.GetValueOrDefault()) : null) / (@class.altBand_0.float_1 - altBand.float_1)).Value);
									if (this.activeUnit_0.bool_3)
									{
										num4 = (int)Math.Round((double)ActiveUnit_Kinematics.smethod_2((float)num4));
									}
								}
							}
						}
						if (float_6 == 0f)
						{
							result = ActiveUnit.Throttle.FullStop;
						}
						else if (float_6 <= (float)num)
						{
							result = ActiveUnit.Throttle.Loiter;
						}
						else if (float_6 <= (float)num2)
						{
							result = ActiveUnit.Throttle.Cruise;
						}
						else if (float_6 <= (float)num3)
						{
							if (@class.altBand_0.nullable_2 != null)
							{
								result = ActiveUnit.Throttle.Full;
							}
							else
							{
								result = ActiveUnit.Throttle.Cruise;
							}
						}
						else if (@class.altBand_0.nullable_3 != null)
						{
							result = ActiveUnit.Throttle.Flank;
						}
						else
						{
							result = ActiveUnit.Throttle.Full;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100193", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = ActiveUnit.Throttle.Cruise;
			}
			return result;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x000A1AEC File Offset: 0x0009FCEC
		public virtual AltBand vmethod_42(float float_5, bool bool_3)
		{
			AltBand result;
			try
			{
				AltBand altBand = null;
				if (this.activeUnit_0.bool_7)
				{
					result = this.activeUnit_0.vmethod_49()[0].altBand_0[0];
				}
				else if (this.activeUnit_0.bool_6)
				{
					if (this.activeUnit_0.vmethod_49()[0].altBand_0.Length == 0)
					{
						result = null;
					}
					else
					{
						result = this.activeUnit_0.vmethod_49()[0].altBand_0[0];
					}
				}
				else
				{
					AltBand[] array = this.activeUnit_0.vmethod_49()[0].altBand_0;
					int num = array.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						AltBand altBand2 = array[i];
						if (altBand2.float_0 >= float_5 && (float_5 + 1f > altBand2.float_1 || float_5 + 1f == altBand2.float_1))
						{
							altBand = altBand2;
						}
					}
					if (Information.IsNothing(altBand))
					{
						if (this.activeUnit_0.bool_3)
						{
							altBand = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderByDescending<AltBand, float>(array, (ActiveUnit_Kinematics._Closure$__.$I114-0 == null) ? (ActiveUnit_Kinematics._Closure$__.$I114-0 = new Func<AltBand, float>(ActiveUnit_Kinematics._Closure$__.$I.method_7)) : ActiveUnit_Kinematics._Closure$__.$I114-0), 0);
							if (bool_3)
							{
								this.activeUnit_0.vmethod_15(false, altBand.float_0);
							}
						}
						else
						{
							altBand = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderBy<AltBand, float>(array, (ActiveUnit_Kinematics._Closure$__.$I114-1 == null) ? (ActiveUnit_Kinematics._Closure$__.$I114-1 = new Func<AltBand, float>(ActiveUnit_Kinematics._Closure$__.$I.method_8)) : ActiveUnit_Kinematics._Closure$__.$I114-1), 0);
							if (bool_3)
							{
								this.activeUnit_0.vmethod_15(true, altBand.float_1);
							}
						}
					}
					result = altBand;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100194", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x000A1CD0 File Offset: 0x0009FED0
		public void method_14(float float_5)
		{
			if (this.activeUnit_0.vmethod_22() != this.activeUnit_0.vmethod_18())
			{
				if (this.activeUnit_0.vmethod_22() > this.activeUnit_0.vmethod_18())
				{
					if (Math.Abs(this.activeUnit_0.vmethod_22() - this.activeUnit_0.vmethod_18()) > this.vmethod_19() * float_5)
					{
						ActiveUnit activeUnit;
						(activeUnit = this.activeUnit_0).vmethod_19(activeUnit.vmethod_18() + this.vmethod_19() * float_5);
					}
					else
					{
						this.activeUnit_0.vmethod_19(this.activeUnit_0.vmethod_22());
					}
				}
				else if (Math.Abs(this.activeUnit_0.vmethod_18() - this.activeUnit_0.vmethod_22()) > this.vmethod_20() * float_5)
				{
					ActiveUnit activeUnit;
					(activeUnit = this.activeUnit_0).vmethod_19(activeUnit.vmethod_18() - this.vmethod_20() * float_5);
				}
				else
				{
					this.activeUnit_0.vmethod_19(this.activeUnit_0.vmethod_22());
				}
			}
			if (this.activeUnit_0.vmethod_18() > 90f)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				this.activeUnit_0.vmethod_19(this.activeUnit_0.vmethod_18() % 90f);
				this.activeUnit_0.vmethod_10(Math2.smethod_7(this.activeUnit_0.vmethod_9() + 180f));
				this.activeUnit_0.vmethod_21(Math2.smethod_9(this.activeUnit_0.vmethod_20() + 180f));
			}
			if (this.activeUnit_0.vmethod_18() < -90f)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				this.activeUnit_0.vmethod_19(this.activeUnit_0.vmethod_18() % 90f);
				this.activeUnit_0.vmethod_10(Math2.smethod_7(this.activeUnit_0.vmethod_9() + 180f));
				this.activeUnit_0.vmethod_21(Math2.smethod_9(this.activeUnit_0.vmethod_20() + 180f));
			}
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x000A1EC0 File Offset: 0x000A00C0
		public void method_15(float float_5)
		{
			if (this.activeUnit_0.vmethod_24() != this.activeUnit_0.vmethod_20())
			{
				if (this.activeUnit_0.vmethod_24() > this.activeUnit_0.vmethod_20())
				{
					if (this.activeUnit_0.vmethod_24() - this.activeUnit_0.vmethod_20() > this.vmethod_18() * float_5)
					{
						ActiveUnit activeUnit;
						(activeUnit = this.activeUnit_0).vmethod_21(activeUnit.vmethod_20() + this.vmethod_18() * float_5);
						return;
					}
					this.activeUnit_0.vmethod_21(this.activeUnit_0.vmethod_24());
					return;
				}
				else
				{
					if (this.activeUnit_0.vmethod_20() - this.activeUnit_0.vmethod_24() > this.vmethod_18() * float_5)
					{
						ActiveUnit activeUnit;
						(activeUnit = this.activeUnit_0).vmethod_21(activeUnit.vmethod_20() - this.vmethod_18() * float_5);
						return;
					}
					this.activeUnit_0.vmethod_21(this.activeUnit_0.vmethod_24());
				}
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x000A1FAC File Offset: 0x000A01AC
		public virtual void vmethod_43(float float_5, float float_6)
		{
			try
			{
				if (this.activeUnit_0.vmethod_40() < 1f && this.activeUnit_0.vmethod_70() == 0f)
				{
					this.activeUnit_0.vmethod_41(0f);
				}
				if ((double)Math.Abs(this.activeUnit_0.vmethod_70() - this.activeUnit_0.vmethod_40()) < 0.5)
				{
					this.activeUnit_0.vmethod_41(this.activeUnit_0.vmethod_70());
				}
				else if (this.activeUnit_0.vmethod_70() == 0f && this.activeUnit_0.vmethod_40() > 0f && this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_40() == 0f && this.activeUnit_0.vmethod_65(false).method_147().vmethod_70() == 0f)
				{
					this.activeUnit_0.vmethod_41(0f);
				}
				else
				{
					float num = (float)((double)(this.vmethod_8(this.activeUnit_0.vmethod_84(), this.activeUnit_0.vmethod_14(false), this.activeUnit_0.vmethod_40()) * float_5) * (1.0 - 0.8 * (double)(float_6 / this.vmethod_49())));
					if (num > 0f && this.activeUnit_0.vmethod_40() < this.activeUnit_0.vmethod_70())
					{
						this.activeUnit_0.vmethod_41(this.activeUnit_0.vmethod_40() + num);
						if ((int)Math.Round((double)this.activeUnit_0.vmethod_40()) > (int)Math.Round((double)this.activeUnit_0.vmethod_70()))
						{
							this.activeUnit_0.vmethod_41(this.activeUnit_0.vmethod_70());
						}
					}
					if (this.activeUnit_0.vmethod_40() > this.activeUnit_0.vmethod_70())
					{
						double num2 = 1.5 * (double)this.vmethod_9(ActiveUnit.Throttle.Full, this.activeUnit_0.vmethod_14(false)) * (double)(this.activeUnit_0.vmethod_40() / (float)this.activeUnit_0.vmethod_87().vmethod_38()) * (double)float_5;
						if (this.activeUnit_0.bool_3 && ((Aircraft)this.activeUnit_0).method_150(true))
						{
							num2 = Math.Max(num2, (double)(10f * float_5));
						}
						this.activeUnit_0.vmethod_41((float)((double)this.activeUnit_0.vmethod_40() - num2));
						if ((int)Math.Round((double)this.activeUnit_0.vmethod_40()) < (int)Math.Round((double)this.activeUnit_0.vmethod_70()))
						{
							this.activeUnit_0.vmethod_41(this.activeUnit_0.vmethod_70());
						}
					}
					if (this.activeUnit_0.vmethod_40() < 0f)
					{
						this.activeUnit_0.vmethod_41(0f);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100195", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0000378C File Offset: 0x0000198C
		public virtual void vmethod_44(double double_0, float float_5)
		{
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000A22E4 File Offset: 0x000A04E4
		public virtual void vmethod_45(float float_5, float float_6, float? nullable_4, bool bool_3)
		{
			try
			{
				if (this.activeUnit_0.method_8())
				{
					this.activeUnit_0.vmethod_15(false, this.activeUnit_0.vmethod_14(false) + this.activeUnit_0.float_8 * float_5);
				}
				else
				{
					this.activeUnit_0.method_19(this.activeUnit_0.vmethod_14(false));
					float num = this.activeUnit_0.vmethod_14(false);
					if (this.activeUnit_0.bool_2 && ((Weapon)this.activeUnit_0).method_204() && this.activeUnit_0.vmethod_72() > this.activeUnit_0.vmethod_14(false))
					{
						this.activeUnit_0.vmethod_73(Math.Min(this.activeUnit_0.vmethod_14(false) - 1f, this.activeUnit_0.vmethod_72()));
					}
					double num2 = (double)((this.activeUnit_0.vmethod_14(false) - this.activeUnit_0.method_18()) / float_5);
					float num3 = this.vmethod_16() * float_5;
					float num4 = this.vmethod_23() * float_5;
					if (num2 < 0.0)
					{
						num3 = (float)((double)num3 - num2);
					}
					if (num2 > 0.0)
					{
						num4 = (float)((double)num4 - Math.Abs(num2));
					}
					if (nullable_4 != null && ((nullable_4 != null) ? new bool?(float_6 < nullable_4.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						float_6 = nullable_4.Value;
					}
					if (this.activeUnit_0.vmethod_14(false) < float_6)
					{
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
						if (nullable_4 != null && ((nullable_4 != null) ? new bool?(num <= nullable_4.GetValueOrDefault()) : null).GetValueOrDefault())
						{
							this.activeUnit_0.vmethod_19(0f);
						}
						this.activeUnit_0.vmethod_15(bool_3, num);
					}
					else
					{
						if (this.activeUnit_0.vmethod_14(false) - float_6 == 0f)
						{
							this.activeUnit_0.vmethod_23(0f);
						}
						if (this.activeUnit_0.vmethod_18() < 0f && nullable_4 != null)
						{
							float num5 = this.activeUnit_0.vmethod_14(false);
							if (((nullable_4 != null) ? new bool?(num5 <= nullable_4.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								this.activeUnit_0.vmethod_19(0f);
							}
						}
					}
					float num6 = this.vmethod_30();
					float num7 = this.vmethod_31();
					if (this.activeUnit_0.vmethod_14(false) > num6)
					{
						this.activeUnit_0.vmethod_15(bool_3, num6);
						if (this.activeUnit_0.vmethod_18() > 0f)
						{
							this.activeUnit_0.vmethod_19(0f);
						}
					}
					else if (this.activeUnit_0.vmethod_14(false) < num7)
					{
						this.activeUnit_0.vmethod_15(bool_3, num7);
						if (this.activeUnit_0.vmethod_18() < 0f)
						{
							this.activeUnit_0.vmethod_19(0f);
						}
					}
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

		// Token: 0x060009B8 RID: 2488 RVA: 0x000A26DC File Offset: 0x000A08DC
		public void method_16(bool bool_3)
		{
			if (this.bool_2 && Debugger.IsAttached)
			{
				Debugger.Break();
			}
			try
			{
				foreach (IEventExporter eventExporter in this.activeUnit_0.scenario_0.method_6())
				{
					if (eventExporter.imethod_8() && eventExporter.imethod_18() && (bool_3 || this.activeUnit_0.vmethod_40() != 0f || eventExporter.imethod_4()))
					{
						this.bool_2 = true;
						if (this.activeUnit_0.vmethod_7(false) != null)
						{
							Dictionary<string, IEventExporter.EventNotificationParameter> dictionary;
							if (this.activeUnit_0.scenario_0.MonteCarloIteration > 0)
							{
								dictionary = new Dictionary<string, IEventExporter.EventNotificationParameter>(17);
								dictionary.Add("Scenario", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.method_0(), typeof(string), 500));
								dictionary.Add("MC_Run", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.MonteCarloIteration, typeof(int), 0));
							}
							else
							{
								dictionary = new Dictionary<string, IEventExporter.EventNotificationParameter>(15);
							}
							if (this.activeUnit_0.scenario_0.MonteCarloIteration > 0)
							{
								dictionary = new Dictionary<string, IEventExporter.EventNotificationParameter>(15);
								dictionary.Add("Scenario", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.method_0(), typeof(string), 500));
								dictionary.Add("MC_Run", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.MonteCarloIteration, typeof(int), 0));
							}
							else
							{
								dictionary = new Dictionary<string, IEventExporter.EventNotificationParameter>(13);
							}
							dictionary.Add("TimelineID", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.TimelineID, typeof(string), 40));
							if (eventExporter.imethod_10())
							{
								dictionary.Add("Time", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.method_31().Subtract(this.activeUnit_0.scenario_0.ZeroHour).ToString("c"), typeof(TimeSpan), 0));
							}
							else
							{
								dictionary.Add("Time", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.method_31().ToString("MM/dd/yyyy HH:mm:ss") + "." + this.activeUnit_0.scenario_0.method_31().Millisecond.ToString("D3"), typeof(DateTime), 0));
							}
							dictionary.Add("UnitID", new IEventExporter.EventNotificationParameter(this.activeUnit_0.string_0, typeof(string), 40));
							dictionary.Add("UnitDBID", new IEventExporter.EventNotificationParameter(this.activeUnit_0.DBID, typeof(string), 10));
							dictionary.Add("UnitName", new IEventExporter.EventNotificationParameter(this.activeUnit_0.Name, typeof(string), 500));
							dictionary.Add("UnitType", new IEventExporter.EventNotificationParameter(this.activeUnit_0.method_63(), typeof(string), 20));
							dictionary.Add("UnitClass", new IEventExporter.EventNotificationParameter(this.activeUnit_0.string_2, typeof(string), 500));
							dictionary.Add("UnitSide", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_7(false).method_51(), typeof(string), 500));
							dictionary.Add("UnitLongitude", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_28(null), typeof(double), 0));
							dictionary.Add("UnitLatitude", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_30(null), typeof(double), 0));
							dictionary.Add("UnitCourse", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_9(), typeof(float), 0));
							dictionary.Add("UnitSpeed_kts", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_40(), typeof(float), 0));
							dictionary.Add("UnitAltitude_m", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_14(false), typeof(float), 0));
							if (this.activeUnit_0.bool_3)
							{
								dictionary.Add("UnitAttitude_Pitch", new IEventExporter.EventNotificationParameter(((Aircraft)this.activeUnit_0).method_151(), typeof(float), 0));
							}
							else
							{
								dictionary.Add("UnitAttitude_Pitch", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_18(), typeof(float), 0));
							}
							dictionary.Add("UnitAttitude_Roll", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_20(), typeof(float), 0));
							eventExporter.imethod_6(IEventExporter.ExportedEventType.UnitPositions, dictionary, this.activeUnit_0.scenario_0);
						}
					}
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			finally
			{
				this.bool_2 = false;
			}
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x000A2C5C File Offset: 0x000A0E5C
		public virtual void vmethod_46(float float_5, bool bool_3, bool bool_4, DateTime dateTime_0)
		{
			try
			{
				if (this.activeUnit_0.vmethod_86().bool_4)
				{
					if (this.activeUnit_0.bool_3)
					{
						this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
					}
					else
					{
						this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.FullStop, new float?(0f));
					}
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
				float num = (float)this.vmethod_40(this.activeUnit_0.vmethod_14(false), this.activeUnit_0.vmethod_84(), true);
				if ((this.activeUnit_0.bool_6 || this.activeUnit_0.bool_5) && GeoPoint.smethod_11(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null)))
				{
					num = 8f;
				}
				if (this.activeUnit_0.vmethod_97())
				{
					if (this.activeUnit_0.bool_2 && this.activeUnit_0.vmethod_6())
					{
						if (this.activeUnit_0.vmethod_18() > ((Weapon)this.activeUnit_0).method_140())
						{
							num = 0f;
						}
					}
					else
					{
						num = 0f;
					}
				}
				if (this.activeUnit_0.vmethod_70() > num)
				{
					this.activeUnit_0.vmethod_71(num);
				}
				double num2 = (double)this.activeUnit_0.vmethod_9();
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
				double num3 = (double)Math.Abs(Class437.smethod_3((float)num2, this.activeUnit_0.vmethod_9())) * (double)(1f / float_5);
				this.vmethod_44(num3, float_5);
				bool flag = false;
				if (this.activeUnit_0.vmethod_78() == ActiveUnit.Enum28.const_1 && this.activeUnit_0.vmethod_85().method_49() && (!(this.activeUnit_0.method_121() & !Information.IsNothing(this.activeUnit_0.vmethod_65(false))) || Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()) || (int)Math.Round((double)this.activeUnit_0.vmethod_40()) == (int)Math.Round((double)this.activeUnit_0.vmethod_65(false).method_147().vmethod_40())) && (int)Math.Round(num2) != (int)Math.Round((double)this.activeUnit_0.vmethod_9()))
				{
					bool? flag2;
					bool? flag3;
					if (!Information.IsNothing(this.activeUnit_0.vmethod_85().nullable_5))
					{
						Waypoint.WaypointType? nullable_ = this.activeUnit_0.vmethod_85().nullable_5;
						int? num4 = (nullable_ != null) ? new int?((int)nullable_.GetValueOrDefault()) : null;
						flag2 = ((num4 != null) ? new bool?(num4.GetValueOrDefault() == 15) : null);
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
					this.vmethod_43(float_5, (float)num3);
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
				if (!bool_4)
				{
					this.activeUnit_0.vmethod_87().method_16(false);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100197", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00007D6C File Offset: 0x00005F6C
		public virtual float vmethod_47(float float_5)
		{
			return this.activeUnit_0.method_20() / 3600f * float_5;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x000A33A4 File Offset: 0x000A15A4
		public virtual float vmethod_48(ActiveUnit myUnit, float DesiredAltitude, float ClosureSpeed = 0f)
		{
			float result;
			try
			{
				if (!myUnit.bool_3 && !myUnit.method_1() && !myUnit.bool_2)
				{
					result = 0f;
				}
				else if (myUnit.vmethod_49().Count == 0)
				{
					result = 0f;
				}
				else if (myUnit.vmethod_84() == ActiveUnit.Throttle.FullStop)
				{
					result = 0f;
				}
				else if (myUnit.vmethod_14(false) == DesiredAltitude)
				{
					result = 0f;
				}
				else
				{
					Engine engine = myUnit.vmethod_49()[0];
					float num = myUnit.vmethod_14(false);
					List<AltBand> list = new List<AltBand>();
					AltBand[] array = engine.altBand_0;
					if (array.Length == 0)
					{
						result = 0f;
					}
					else if (engine.vmethod_5() == PlatformComponent._ComponentStatus.Destroyed)
					{
						result = 0f;
					}
					else
					{
						float num2;
						float num3;
						float num4;
						if (myUnit.vmethod_14(false) > DesiredAltitude)
						{
							foreach (AltBand altBand in array)
							{
								if (altBand.float_1 <= num && altBand.float_0 >= DesiredAltitude)
								{
									list.Add(altBand);
								}
							}
							if (list.Count > 1)
							{
								list.Sort(new ActiveUnit_Kinematics.GClass0());
							}
							num2 = myUnit.vmethod_14(false);
							num3 = DesiredAltitude;
							num4 = myUnit.vmethod_87().vmethod_21();
						}
						else
						{
							if (myUnit.vmethod_14(false) >= DesiredAltitude)
							{
								return 0f;
							}
							foreach (AltBand altBand2 in array)
							{
								if (altBand2.float_0 >= num && altBand2.float_1 <= DesiredAltitude)
								{
									list.Add(altBand2);
								}
							}
							if (list.Count > 1)
							{
								list.Sort(new ActiveUnit_Kinematics.GClass0());
							}
							num2 = DesiredAltitude;
							num3 = myUnit.vmethod_14(false);
							num4 = myUnit.vmethod_87().vmethod_14(true);
						}
						if (list.Count == 0)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							result = 0f;
						}
						else
						{
							float num13;
							try
							{
								foreach (AltBand altBand3 in list)
								{
									try
									{
										float num5;
										switch (myUnit.vmethod_84())
										{
										case ActiveUnit.Throttle.FullStop:
											return 0f;
										case ActiveUnit.Throttle.Loiter:
											num5 = (float)altBand3.int_0;
											break;
										case ActiveUnit.Throttle.Cruise:
											if (altBand3.int_1 > 0)
											{
												num5 = (float)altBand3.int_1;
											}
											else
											{
												num5 = (float)altBand3.int_0;
											}
											break;
										case ActiveUnit.Throttle.Full:
											if (altBand3.nullable_0 == null)
											{
												num5 = (float)altBand3.int_1;
											}
											else
											{
												num5 = (float)altBand3.nullable_0.Value;
											}
											break;
										case ActiveUnit.Throttle.Flank:
											if (altBand3.nullable_1 == null)
											{
												if (altBand3.nullable_0 == null)
												{
													num5 = (float)altBand3.int_1;
												}
												else
												{
													num5 = (float)altBand3.nullable_0.Value;
												}
											}
											else
											{
												num5 = (float)altBand3.nullable_1.Value;
											}
											break;
										}
										float num6;
										float num7;
										int num8;
										if (altBand3 == this.method_11(engine))
										{
											num6 = altBand3.float_1;
											num7 = myUnit.vmethod_14(false);
											num8 = (int)Math.Round((double)num5);
										}
										else
										{
											AltBand altBand4 = array[Array.IndexOf<AltBand>(array, altBand3) + 1];
											float num9;
											switch (myUnit.vmethod_84())
											{
											case ActiveUnit.Throttle.FullStop:
												num9 = 0f;
												break;
											case ActiveUnit.Throttle.Loiter:
												num9 = (float)altBand4.int_0;
												break;
											case ActiveUnit.Throttle.Cruise:
												num9 = (float)altBand4.int_1;
												break;
											case ActiveUnit.Throttle.Full:
												if (altBand4.nullable_0 == null)
												{
													num9 = (float)altBand4.int_1;
												}
												else
												{
													num9 = (float)altBand4.nullable_0.Value;
												}
												break;
											case ActiveUnit.Throttle.Flank:
												if (altBand4.nullable_1 == null)
												{
													if (altBand4.nullable_0 == null)
													{
														num9 = (float)altBand4.int_1;
													}
													else
													{
														num9 = (float)altBand4.nullable_0.Value;
													}
												}
												else
												{
													num9 = (float)altBand4.nullable_1.Value;
												}
												break;
											}
											int num10;
											if (num3 > altBand3.float_1)
											{
												num6 = num3;
												num10 = this.vmethod_40(num3, myUnit.vmethod_84(), false);
											}
											else
											{
												num6 = altBand3.float_1;
												num10 = (int)Math.Round((double)num5);
											}
											int num11;
											if (num2 < altBand3.float_0)
											{
												num7 = num2;
												num11 = this.vmethod_40(num2, myUnit.vmethod_84(), false);
											}
											else
											{
												num7 = altBand4.float_1;
												num11 = (int)Math.Round((double)num9);
											}
											num8 = (int)Math.Round((double)(num11 + num10) / 2.0 + (double)ClosureSpeed);
										}
										float num12 = (num7 - num6) / num4;
										num13 += num12 / 3600f * (float)num8;
									}
									catch (Exception ex)
									{
										ex.Data.Add("Error at 101165", "");
										GameGeneral.smethod_25(ref ex);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
									}
								}
							}
							finally
							{
								List<AltBand>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							result = num13;
						}
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100198", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0000710A File Offset: 0x0000530A
		public virtual float vmethod_49()
		{
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000A38D4 File Offset: 0x000A1AD4
		public static float smethod_3(Waypoint.Enum81 enum81_0, float float_5)
		{
			float result;
			switch (enum81_0)
			{
			case Waypoint.Enum81.const_0:
				result = 3f;
				break;
			case Waypoint.Enum81.const_1:
				result = 1.5f;
				break;
			case Waypoint.Enum81.const_2:
				result = 6f;
				break;
			case Waypoint.Enum81.const_3:
				result = 0.6f;
				break;
			case Waypoint.Enum81.const_4:
				result = ActiveUnit_Kinematics.smethod_4(float_5, 60f);
				break;
			case Waypoint.Enum81.const_5:
				result = ActiveUnit_Kinematics.smethod_4(float_5, 70f);
				break;
			case Waypoint.Enum81.const_6:
				result = ActiveUnit_Kinematics.smethod_4(float_5, 75f);
				break;
			default:
				result = 3f;
				break;
			}
			return result;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00007D81 File Offset: 0x00005F81
		public static float smethod_4(float float_5, float float_6)
		{
			return (float)(1091.0 * Math.Tan((double)float_6 * 0.0174532925199433) / (double)float_5);
		}

		// Token: 0x04000675 RID: 1653
		protected ActiveUnit activeUnit_0;

		// Token: 0x04000676 RID: 1654
		protected float float_0;

		// Token: 0x04000677 RID: 1655
		protected float float_1;

		// Token: 0x04000678 RID: 1656
		private float? nullable_0;

		// Token: 0x04000679 RID: 1657
		private bool bool_0;

		// Token: 0x0400067A RID: 1658
		protected float float_2;

		// Token: 0x0400067B RID: 1659
		protected int? nullable_1;

		// Token: 0x0400067C RID: 1660
		private AltBand altBand_0;

		// Token: 0x0400067D RID: 1661
		private string string_0;

		// Token: 0x0400067E RID: 1662
		protected float float_3;

		// Token: 0x0400067F RID: 1663
		protected float float_4;

		// Token: 0x04000680 RID: 1664
		public ActiveUnit_Kinematics.Enum33 enum33_0;

		// Token: 0x04000681 RID: 1665
		public bool bool_1;

		// Token: 0x04000682 RID: 1666
		protected ActiveUnit_Kinematics.UnitThrottlePreset unitThrottlePreset_0;

		// Token: 0x04000683 RID: 1667
		private float? nullable_2;

		// Token: 0x04000684 RID: 1668
		private float? nullable_3;

		// Token: 0x04000685 RID: 1669
		private bool bool_2;

		// Token: 0x0200015A RID: 346
		public enum UnitThrottlePreset : byte
		{
			// Token: 0x04000687 RID: 1671
			FullStop,
			// Token: 0x04000688 RID: 1672
			Loiter,
			// Token: 0x04000689 RID: 1673
			Cruise,
			// Token: 0x0400068A RID: 1674
			Full,
			// Token: 0x0400068B RID: 1675
			Flank,
			// Token: 0x0400068C RID: 1676
			None
		}

		// Token: 0x0200015B RID: 347
		protected sealed class GClass0 : IComparer<AltBand>
		{
			// Token: 0x060009C0 RID: 2496 RVA: 0x00007DA2 File Offset: 0x00005FA2
			public int Compare(AltBand x, AltBand y)
			{
				return x.float_0.CompareTo(y.float_0);
			}
		}

		// Token: 0x0200015C RID: 348
		internal enum Enum33 : short
		{
			// Token: 0x0400068E RID: 1678
			const_0,
			// Token: 0x0400068F RID: 1679
			const_1
		}

		// Token: 0x0200015E RID: 350
		[CompilerGenerated]
		internal sealed class Class208
		{
			// Token: 0x060009CD RID: 2509 RVA: 0x00007DD1 File Offset: 0x00005FD1
			internal bool method_0(AltBand altBand_1)
			{
				return altBand_1.float_1 >= this.altBand_0.float_0;
			}

			// Token: 0x0400069B RID: 1691
			public AltBand altBand_0;
		}

		// Token: 0x0200015F RID: 351
		[CompilerGenerated]
		internal sealed class Class209
		{
			// Token: 0x060009CF RID: 2511 RVA: 0x00007DE9 File Offset: 0x00005FE9
			internal bool method_0(AltBand altBand_1)
			{
				return altBand_1.float_1 >= this.altBand_0.float_0;
			}

			// Token: 0x0400069C RID: 1692
			public AltBand altBand_0;
		}

		// Token: 0x02000160 RID: 352
		[CompilerGenerated]
		internal sealed class Class210
		{
			// Token: 0x060009D1 RID: 2513 RVA: 0x00007E01 File Offset: 0x00006001
			internal bool method_0(AltBand altBand_1)
			{
				return altBand_1.float_1 >= this.altBand_0.float_0;
			}

			// Token: 0x0400069D RID: 1693
			public AltBand altBand_0;
		}
	}
}
