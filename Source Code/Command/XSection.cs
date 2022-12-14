using System;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using ns10;
using ns13;
using ns14;

namespace Command_Core
{
	// Token: 0x02000395 RID: 917
	public sealed class XSection : Class310
	{
		// Token: 0x06001BE9 RID: 7145 RVA: 0x001FD178 File Offset: 0x001FB378
		public void method_8(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("XSection");
				xmlWriter_0.WriteElementString("Front", XmlConvert.ToString(this.float_0));
				xmlWriter_0.WriteElementString("Side", XmlConvert.ToString(this.float_1));
				xmlWriter_0.WriteElementString("Rear", XmlConvert.ToString(this.float_2));
				xmlWriter_0.WriteElementString("Top", XmlConvert.ToString(this.float_3));
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "Type";
				int num = (int)this.enum132_0;
				xmlWriter.WriteElementString(localName, num.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101079", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x001FD258 File Offset: 0x001FB458
		public float method_9(ActiveUnit activeUnit_0)
		{
			float result;
			try
			{
				if (activeUnit_0.bool_5)
				{
					Submarine submarine = (Submarine)activeUnit_0;
					if (submarine.method_161())
					{
						result = this.float_0;
					}
					else if (submarine.method_162())
					{
						if (activeUnit_0.vmethod_93().method_8() == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
						{
							XSection.Enum132 @enum = this.enum132_0;
							if (@enum - XSection.Enum132.const_5 > 1)
							{
								if (@enum - XSection.Enum132.const_7 > 1)
								{
									if (@enum - XSection.Enum132.const_9 <= 1)
									{
										result = -20f;
									}
									else
									{
										result = this.float_0;
									}
								}
								else
								{
									result = 2f;
								}
							}
							else
							{
								result = 2f;
							}
						}
						else
						{
							XSection.Enum132 enum2 = this.enum132_0;
							if (enum2 - XSection.Enum132.const_5 > 1)
							{
								if (enum2 - XSection.Enum132.const_7 > 1)
								{
									if (enum2 - XSection.Enum132.const_9 <= 1)
									{
										result = -30f;
									}
									else
									{
										result = this.float_0;
									}
								}
								else
								{
									result = 2f;
								}
							}
							else
							{
								result = 2f;
							}
						}
					}
					else
					{
						result = this.float_0;
					}
				}
				else if (activeUnit_0.bool_3)
				{
					XSection.Enum132 enum3 = this.enum132_0;
					if (enum3 != XSection.Enum132.const_7)
					{
						if (enum3 - XSection.Enum132.const_9 <= 1)
						{
							result = this.method_12((Aircraft)activeUnit_0, this.float_0, this.enum132_0, XSection.Enum133.const_0);
						}
						else
						{
							result = this.float_0;
						}
					}
					else
					{
						double num = (double)Class437.smethod_0((double)activeUnit_0.vmethod_14(false), (double)activeUnit_0.vmethod_40());
						float num2;
						if (num > 1.0)
						{
							num2 = (float)((double)this.float_0 * num);
						}
						else
						{
							num2 = this.float_0;
						}
						result = num2;
					}
				}
				else if (activeUnit_0.method_2())
				{
					XSection.Enum132 enum4 = this.enum132_0;
					if (enum4 != XSection.Enum132.const_5)
					{
						if (enum4 != XSection.Enum132.const_7)
						{
							return this.float_0;
						}
					}
					Engine.Enum112 enum112_ = activeUnit_0.vmethod_49()[0].enum112_0;
					float num2;
					if (enum112_ == Engine.Enum112.const_12)
					{
						Weapon weapon = (Weapon)activeUnit_0;
						if (!Information.IsNothing(weapon.geoPoint_0) && weapon.method_23(weapon.geoPoint_0) <= weapon.method_159())
						{
							num2 = 5f * this.float_0;
						}
						else
						{
							num2 = this.float_0;
						}
					}
					else
					{
						num2 = this.float_0;
					}
					double num3 = (double)Class437.smethod_0((double)activeUnit_0.vmethod_14(false), (double)activeUnit_0.vmethod_40());
					if (num3 > 1.0)
					{
						num2 = (float)((double)num2 * num3);
					}
					result = num2;
				}
				else
				{
					result = this.float_0;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101288", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = this.float_0;
			}
			return result;
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x001FD51C File Offset: 0x001FB71C
		public float method_10(ActiveUnit activeUnit_0)
		{
			float result;
			try
			{
				if (activeUnit_0.bool_5)
				{
					if (((Submarine)activeUnit_0).method_161())
					{
						result = this.float_1;
					}
					else if (((Submarine)activeUnit_0).method_162())
					{
						XSection.Enum132 @enum = this.enum132_0;
						if (@enum - XSection.Enum132.const_5 > 1)
						{
							if (@enum - XSection.Enum132.const_7 > 1)
							{
								if (@enum - XSection.Enum132.const_9 <= 1)
								{
									result = -30f;
								}
								else
								{
									result = this.float_1;
								}
							}
							else
							{
								result = 2f;
							}
						}
						else
						{
							result = 2f;
						}
					}
					else
					{
						result = this.float_1;
					}
				}
				else if (activeUnit_0.bool_3)
				{
					XSection.Enum132 enum2 = this.enum132_0;
					if (enum2 != XSection.Enum132.const_7)
					{
						if (enum2 - XSection.Enum132.const_9 > 1)
						{
							result = this.float_1;
						}
						else
						{
							result = this.method_12((Aircraft)activeUnit_0, this.float_1, this.enum132_0, XSection.Enum133.const_1);
						}
					}
					else
					{
						float num = this.float_1;
						double num2 = (double)Class437.smethod_0((double)activeUnit_0.vmethod_14(false), (double)activeUnit_0.vmethod_40());
						if (num2 < 1.0)
						{
							num2 = 1.0;
						}
						switch (activeUnit_0.vmethod_84())
						{
						case ActiveUnit.Throttle.FullStop:
							result = (float)((double)num * num2 * 1.5);
							break;
						case ActiveUnit.Throttle.Loiter:
							result = (float)((double)num * num2 * 0.85);
							break;
						case ActiveUnit.Throttle.Cruise:
							result = (float)((double)num * num2);
							break;
						case ActiveUnit.Throttle.Full:
							result = (float)((double)num * num2 * 1.2);
							break;
						case ActiveUnit.Throttle.Flank:
							result = (float)((double)num * num2 * 1.5);
							break;
						default:
							result = this.float_1;
							break;
						}
					}
				}
				else if (activeUnit_0.method_2())
				{
					XSection.Enum132 enum3 = this.enum132_0;
					if (enum3 != XSection.Enum132.const_5)
					{
						if (enum3 != XSection.Enum132.const_7)
						{
							return this.float_1;
						}
					}
					Engine.Enum112 enum112_ = activeUnit_0.vmethod_49()[0].enum112_0;
					float num3;
					if (enum112_ == Engine.Enum112.const_12)
					{
						Weapon weapon = (Weapon)activeUnit_0;
						if (!Information.IsNothing(weapon.geoPoint_0) && weapon.method_23(weapon.geoPoint_0) <= weapon.method_159())
						{
							num3 = 5f * this.float_1;
						}
						else
						{
							num3 = this.float_1;
						}
					}
					else
					{
						num3 = this.float_1;
					}
					double num4 = (double)Class437.smethod_0((double)activeUnit_0.vmethod_14(false), (double)activeUnit_0.vmethod_40());
					if (num4 > 1.0)
					{
						num3 = (float)((double)num3 * num4);
					}
					result = num3;
				}
				else
				{
					result = this.float_1;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101289", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = this.float_1;
			}
			return result;
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x001FD808 File Offset: 0x001FBA08
		public float method_11(ActiveUnit activeUnit_0)
		{
			float result;
			try
			{
				if (activeUnit_0.bool_5)
				{
					if (((Submarine)activeUnit_0).method_161())
					{
						result = this.float_2;
					}
					else if (((Submarine)activeUnit_0).method_162())
					{
						XSection.Enum132 @enum = this.enum132_0;
						if (@enum - XSection.Enum132.const_5 > 1)
						{
							if (@enum - XSection.Enum132.const_7 > 1)
							{
								if (@enum - XSection.Enum132.const_9 <= 1)
								{
									result = -30f;
								}
								else
								{
									result = this.float_2;
								}
							}
							else
							{
								result = 2f;
							}
						}
						else
						{
							result = 2f;
						}
					}
					else
					{
						result = this.float_2;
					}
				}
				else if (activeUnit_0.bool_3)
				{
					XSection.Enum132 enum2 = this.enum132_0;
					if (enum2 != XSection.Enum132.const_7)
					{
						if (enum2 - XSection.Enum132.const_9 > 1)
						{
							result = this.float_2;
						}
						else
						{
							result = this.method_12((Aircraft)activeUnit_0, this.float_2, this.enum132_0, XSection.Enum133.const_2);
						}
					}
					else
					{
						float num = this.float_2;
						switch (activeUnit_0.vmethod_84())
						{
						case ActiveUnit.Throttle.FullStop:
							result = (float)((double)num * 1.5);
							break;
						case ActiveUnit.Throttle.Loiter:
							result = (float)((double)num * 0.85);
							break;
						case ActiveUnit.Throttle.Cruise:
							result = num;
							break;
						case ActiveUnit.Throttle.Full:
							result = (float)((double)num * 1.2);
							break;
						case ActiveUnit.Throttle.Flank:
							result = (float)((double)num * 1.5);
							break;
						default:
							result = this.float_2;
							break;
						}
					}
				}
				else if (activeUnit_0.method_2())
				{
					XSection.Enum132 enum3 = this.enum132_0;
					if (enum3 != XSection.Enum132.const_5)
					{
						if (enum3 != XSection.Enum132.const_7)
						{
							return this.float_2;
						}
					}
					Engine.Enum112 enum112_ = activeUnit_0.vmethod_49()[0].enum112_0;
					float num2;
					if (enum112_ == Engine.Enum112.const_12)
					{
						Weapon weapon = (Weapon)activeUnit_0;
						if (!Information.IsNothing(weapon.geoPoint_0) && weapon.method_23(weapon.geoPoint_0) <= weapon.method_159())
						{
							num2 = 5f * this.float_2;
						}
						else
						{
							num2 = this.float_2;
						}
					}
					else
					{
						num2 = this.float_2;
					}
					double num3 = (double)Class437.smethod_0((double)activeUnit_0.vmethod_14(false), (double)activeUnit_0.vmethod_40());
					if (num3 > 1.0)
					{
						num2 = (float)((double)num2 * num3);
					}
					result = num2;
				}
				else
				{
					result = this.float_2;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101290", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = this.float_2;
			}
			return result;
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x0000944E File Offset: 0x0000764E
		private XSection()
		{
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x0000DECB File Offset: 0x0000C0CB
		public XSection(XSection.Enum132 enum132_1, float float_4, float float_5, float float_6, float float_7)
		{
			this.enum132_0 = enum132_1;
			this.float_0 = float_4;
			this.float_1 = float_5;
			this.float_2 = float_6;
			this.float_3 = float_7;
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x001FDAB4 File Offset: 0x001FBCB4
		private float method_12(Aircraft aircraft_0, float float_4, XSection.Enum132 enum132_1, XSection.Enum133 enum133_0)
		{
			Class563.Class567 @class = new Class563.Class567();
			float result;
			try
			{
				if (Information.IsNothing(aircraft_0.method_167()))
				{
					result = float_4;
				}
				else
				{
					@class.double_0 = (double)float_4;
					float num = (float)@class.method_0();
					foreach (WeaponRec weaponRec in aircraft_0.method_167().weaponRec_0)
					{
						if (!weaponRec.bool_12)
						{
							Weapon weapon = weaponRec.method_12(aircraft_0.scenario_0);
							if (weapon.method_214())
							{
								if (Information.IsNothing(this.weapon_0))
								{
									this.weapon_0 = aircraft_0.scenario_0.method_87(554);
								}
								weapon = this.weapon_0;
							}
							else if (weapon.method_167() == Weapon._WeaponType.SensorPod)
							{
								if (Information.IsNothing(this.weapon_1))
								{
									this.weapon_1 = aircraft_0.scenario_0.method_87(641);
								}
								weapon = this.weapon_1;
							}
							XSection expression = Sensor.smethod_3(weapon, enum132_1);
							if (Information.IsNothing(expression))
							{
								expression = Sensor.smethod_3(weapon, enum132_1);
							}
							if (!Information.IsNothing(expression))
							{
								float num2;
								short num3;
								switch (enum133_0)
								{
								case XSection.Enum133.const_0:
								{
									num2 = Sensor.smethod_3(weapon, enum132_1).method_9(weapon);
									num3 = (short)weaponRec.method_9();
									short num4 = num3;
									if (num4 > 6)
									{
										if (num4 <= 12)
										{
											num3 = 6;
										}
										else
										{
											num3 = (short)Math.Floor((double)num3 / 3.0);
										}
									}
									break;
								}
								case XSection.Enum133.const_1:
									num2 = Sensor.smethod_3(weapon, enum132_1).method_10(weapon);
									num3 = (short)Math.Round((double)weaponRec.method_9() / 2.0);
									break;
								case XSection.Enum133.const_2:
								{
									num2 = Sensor.smethod_3(weapon, enum132_1).method_11(weapon);
									num3 = (short)weaponRec.method_9();
									short num5 = num3;
									if (num5 > 6)
									{
										if (num5 <= 12)
										{
											num3 = 6;
										}
										else
										{
											num3 = (short)Math.Floor((double)num3 / 6.0);
										}
									}
									break;
								}
								}
								if (num2 != 0f)
								{
									@class.double_0 = (double)num2;
									float num6 = (float)@class.method_0();
									num = (float)((double)num + (double)(num6 * (float)num3) * 1.2);
								}
							}
						}
					}
					@class.method_1((double)num);
					result = (float)@class.double_0;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101081", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x040018D9 RID: 6361
		private float float_0;

		// Token: 0x040018DA RID: 6362
		private float float_1;

		// Token: 0x040018DB RID: 6363
		private float float_2;

		// Token: 0x040018DC RID: 6364
		private float float_3;

		// Token: 0x040018DD RID: 6365
		public XSection.Enum132 enum132_0;

		// Token: 0x040018DE RID: 6366
		private Weapon weapon_0;

		// Token: 0x040018DF RID: 6367
		private Weapon weapon_1;

		// Token: 0x02000396 RID: 918
		internal enum Enum132 : short
		{
			// Token: 0x040018E1 RID: 6369
			const_0 = 1001,
			// Token: 0x040018E2 RID: 6370
			const_1,
			// Token: 0x040018E3 RID: 6371
			const_2,
			// Token: 0x040018E4 RID: 6372
			const_3,
			// Token: 0x040018E5 RID: 6373
			const_4 = 2001,
			// Token: 0x040018E6 RID: 6374
			const_5 = 3001,
			// Token: 0x040018E7 RID: 6375
			const_6,
			// Token: 0x040018E8 RID: 6376
			const_7 = 4001,
			// Token: 0x040018E9 RID: 6377
			const_8,
			// Token: 0x040018EA RID: 6378
			const_9 = 5001,
			// Token: 0x040018EB RID: 6379
			const_10
		}

		// Token: 0x02000397 RID: 919
		internal enum Enum133 : short
		{
			// Token: 0x040018ED RID: 6381
			const_0,
			// Token: 0x040018EE RID: 6382
			const_1,
			// Token: 0x040018EF RID: 6383
			const_2
		}
	}
}
