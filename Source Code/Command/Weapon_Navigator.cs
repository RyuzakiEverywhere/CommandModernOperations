using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns12;
using ns13;
using ns14;

namespace Command_Core
{
	// Token: 0x02000392 RID: 914
	public sealed class Weapon_Navigator : ActiveUnit_Navigator
	{
		// Token: 0x06001BD5 RID: 7125 RVA: 0x001FA840 File Offset: 0x001F8A40
		public override void vmethod_0(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Weapon_Navigator");
				xmlWriter_0.WriteStartElement("PC");
				List<Waypoint> list = new List<Waypoint>();
				list.AddRange(base.method_4());
				try
				{
					foreach (Waypoint waypoint in list)
					{
						if (!Information.IsNothing(waypoint))
						{
							waypoint.method_19(ref xmlWriter_0, ref hashSet_0);
						}
					}
				}
				finally
				{
					List<Waypoint>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				xmlWriter_0.WriteEndElement();
				if (this.bool_0)
				{
					xmlWriter_0.WriteElementString("MPO", "True");
				}
				if (this.activeUnit_0.method_120())
				{
					xmlWriter_0.WriteElementString("FS_B", XmlConvert.ToString(base.method_2().float_0));
					xmlWriter_0.WriteElementString("FS_D", XmlConvert.ToString(base.method_2().float_1));
					xmlWriter_0.WriteElementString("FS_BT", XmlConvert.ToString((byte)base.method_2().orientationType_0));
				}
				if (!Information.IsNothing(this.referencePoint_0))
				{
					xmlWriter_0.WriteStartElement("SM_NRP");
					xmlWriter_0.WriteRaw(this.referencePoint_0.method_17(ref hashSet_0));
					xmlWriter_0.WriteEndElement();
				}
				if (this.nullable_2 != null)
				{
					xmlWriter_0.WriteElementString("PreviousWaypointTime", this.nullable_2.Value.ToBinary().ToString());
				}
				if (this.nullable_5 != null)
				{
					xmlWriter_0.WriteElementString("PreviousWaypointType", this.nullable_5.Value.ToString());
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100983", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x001FAA40 File Offset: 0x001F8C40
		public static Weapon_Navigator smethod_8(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Weapon_Navigator result;
			try
			{
				Weapon_Navigator weapon_Navigator = new Weapon_Navigator(ref activeUnit_1);
				weapon_Navigator.activeUnit_0 = activeUnit_1;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 1825816807U)
						{
							if (num <= 758041653U)
							{
								if (num != 426765699U)
								{
									if (num != 527431413U)
									{
										if (num != 758041653U)
										{
											continue;
										}
										if (Operators.CompareString(name, "MPO", false) != 0)
										{
											continue;
										}
										goto IL_1F8;
									}
									else
									{
										if (Operators.CompareString(name, "FS_D", false) != 0)
										{
											continue;
										}
										goto IL_307;
									}
								}
								else if (Operators.CompareString(name, "FS_B", false) != 0)
								{
									continue;
								}
							}
							else if (num != 771752996U)
							{
								if (num != 1042409646U)
								{
									if (num != 1825816807U)
									{
										continue;
									}
									if (Operators.CompareString(name, "PreviousWaypointType", false) != 0)
									{
										continue;
									}
									if (Versioned.IsNumeric(xmlNode.InnerText))
									{
										weapon_Navigator.nullable_5 = new Waypoint.WaypointType?((Waypoint.WaypointType)Conversions.ToInteger(xmlNode.InnerText));
										continue;
									}
									weapon_Navigator.nullable_5 = new Waypoint.WaypointType?((Waypoint.WaypointType)Enum.Parse(typeof(Waypoint.WaypointType), xmlNode.InnerText, true));
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "PreviousWaypointTime", false) == 0)
									{
										DateTime value = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
										weapon_Navigator.nullable_2 = new DateTime?(value);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "PC", false) != 0)
								{
									continue;
								}
								goto IL_287;
							}
						}
						else if (num <= 3189192397U)
						{
							if (num != 1857393043U)
							{
								if (num != 2922860948U)
								{
									if (num != 3189192397U)
									{
										continue;
									}
									if (Operators.CompareString(name, "FormationStation_Bearing", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "ManualPlotOverride", false) == 0)
									{
										goto IL_1F8;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "SupportMission_NextRefPoint", false) != 0)
								{
									continue;
								}
								goto IL_32E;
							}
						}
						else
						{
							if (num > 3795020149U)
							{
								goto IL_2E4;
							}
							if (num != 3750830438U)
							{
								if (num != 3795020149U)
								{
									continue;
								}
								if (Operators.CompareString(name, "FS_BT", false) == 0)
								{
									weapon_Navigator.method_2().orientationType_0 = (ReferencePoint.OrientationType)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "PlottedCourse", false) == 0)
								{
									goto IL_287;
								}
								continue;
							}
						}
						weapon_Navigator.method_2().float_0 = XmlConvert.ToSingle(xmlNode.InnerText);
						continue;
						IL_1F8:
						weapon_Navigator.bool_0 = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_287:
						try
						{
							foreach (object obj2 in xmlNode.ChildNodes)
							{
								XmlNode xmlNode2 = (XmlNode)obj2;
								Waypoint waypoint_ = Waypoint.smethod_13(ref xmlNode2, ref dictionary_0, activeUnit_1.scenario_0);
								Class429.smethod_36(ref weapon_Navigator.waypoint_0, waypoint_);
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
						IL_2E4:
						if (num != 3808473706U)
						{
							if (num != 4241447450U)
							{
								continue;
							}
							if (Operators.CompareString(name, "FormationStation_Distance", false) != 0)
							{
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "SM_NRP", false) == 0)
							{
								goto IL_32E;
							}
							continue;
						}
						IL_307:
						weapon_Navigator.method_2().float_1 = XmlConvert.ToSingle(xmlNode.InnerText);
						continue;
						IL_32E:
						ActiveUnit_Navigator activeUnit_Navigator = weapon_Navigator;
						XmlNode xmlNode3 = xmlNode.ChildNodes[0];
						activeUnit_Navigator.referencePoint_0 = ReferencePoint.smethod_13(ref xmlNode3, ref dictionary_0);
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
				result = weapon_Navigator;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100984", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Weapon_Navigator(ref activeUnit_1);
			}
			return result;
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0000AE7D File Offset: 0x0000907D
		public Weapon_Navigator(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x001FAE48 File Offset: 0x001F9048
		public override void vmethod_16(float float_2)
		{
			try
			{
				bool flag = false;
				bool flag2 = false;
				this.vmethod_19(float_2, ref flag, ref flag2);
				this.vmethod_17(float_2);
				if (this.activeUnit_0.bool_14 && this.activeUnit_0.vmethod_84() < ActiveUnit.Throttle.Cruise)
				{
					this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100985", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0000DE42 File Offset: 0x0000C042
		public override bool vmethod_18(double double_11, double double_12, float float_2)
		{
			return base.vmethod_18(double_11, double_12, float_2);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x001FAEE4 File Offset: 0x001F90E4
		internal Geopoint_Struct method_62(float float_2, Unit unit_0, float? nullable_8)
		{
			Geopoint_Struct result;
			try
			{
				if (unit_0.vmethod_40() == 0f && unit_0.method_21(this.activeUnit_0.scenario_0) == 0f)
				{
					result = new Geopoint_Struct(unit_0.vmethod_28(null), unit_0.vmethod_30(null));
				}
				else
				{
					if (nullable_8 == null)
					{
						nullable_8 = new float?(this.activeUnit_0.method_39(unit_0, float_2, this.activeUnit_0.vmethod_9()));
					}
					float? num = nullable_8;
					if (!((num != null) ? new bool?(num.GetValueOrDefault() <= 0f) : null).GetValueOrDefault() && !double.IsNaN((double)nullable_8.Value))
					{
						float num2 = (float)((long)Math.Round((double)(this.activeUnit_0.method_36(unit_0) / nullable_8 * 3600f).Value));
						float num3 = num2 / 3600f * unit_0.vmethod_40();
						double double_;
						double double_2;
						Class411.smethod_1(unit_0.vmethod_28(null), unit_0.vmethod_30(null), ref double_, ref double_2, (double)num3, (double)unit_0.vmethod_9());
						float float_3 = unit_0.vmethod_14(false) + unit_0.method_21(this.activeUnit_0.scenario_0) * num2;
						result = new Geopoint_Struct(double_, double_2, float_3);
					}
					else
					{
						result = default(Geopoint_Struct);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100986", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = default(Geopoint_Struct);
			}
			return result;
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x001FB0F8 File Offset: 0x001F92F8
		public bool method_63(ActiveUnit activeUnit_1)
		{
			bool result;
			if (Information.IsNothing(this.activeUnit_0.vmethod_86().vmethod_3()))
			{
				result = false;
			}
			else
			{
				float num = activeUnit_1.method_36(this.activeUnit_0.vmethod_86().vmethod_3());
				float num2 = activeUnit_1.method_32(this.activeUnit_0.vmethod_86().vmethod_3());
				float num3 = ((Weapon)this.activeUnit_0).method_181(this.activeUnit_0, this.activeUnit_0.vmethod_86().vmethod_3(), false, activeUnit_1.doctrine_0, false);
				List<Waypoint> list = new List<Waypoint>();
				Random random = GameGeneral.smethod_5();
				int num4 = 1;
				do
				{
					int num5;
					if (activeUnit_1.bool_3)
					{
						num5 = random.Next(-45, 46);
					}
					else
					{
						num5 = random.Next(-80, 81);
					}
					int num6 = random.Next(1, (int)Math.Round((double)(num / 2f)));
					double num7;
					double num8;
					Class411.smethod_1(activeUnit_1.vmethod_28(null), activeUnit_1.vmethod_30(null), ref num7, ref num8, (double)num6, (double)Math2.smethod_7(num2 + (float)num5));
					float num9 = activeUnit_1.method_25(num8, num7);
					float num10 = this.activeUnit_0.vmethod_86().vmethod_3().method_25(num8, num7);
					if (num9 + num10 < num3)
					{
						list.Add(new Waypoint(num7, num8, 0f, Waypoint.WaypointType.TurningPoint, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0));
					}
					num4++;
				}
				while (num4 <= 10000);
				if (!Enumerable.Any<Waypoint>(list))
				{
					result = false;
				}
				else
				{
					if (list.Count == 1)
					{
						base.method_50(list[0]);
					}
					else
					{
						Waypoint waypoint_ = list[random.Next(0, list.Count)];
						base.method_50(waypoint_);
					}
					base.method_50(new Waypoint(this.activeUnit_0.vmethod_86().vmethod_3().vmethod_28(null), this.activeUnit_0.vmethod_86().vmethod_3().vmethod_30(null), 0f, Waypoint.WaypointType.TerminalPoint, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0));
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x001FB304 File Offset: 0x001F9504
		public bool method_64(float float_2, bool bool_17)
		{
			bool result;
			try
			{
				if (this.activeUnit_0.vmethod_86().vmethod_3() == null)
				{
					result = false;
				}
				else
				{
					Waypoint waypoint = new Waypoint();
					Weapon weapon = (Weapon)this.activeUnit_0;
					waypoint.waypointType_0 = Waypoint.WaypointType.TerminalPoint;
					Waypoint waypoint2;
					if (base.method_47())
					{
						if (Enumerable.Last<Waypoint>(base.method_4()).waypointType_0 == Waypoint.WaypointType.TerminalPoint)
						{
							if (Enumerable.Count<Waypoint>(base.method_4()) > 1)
							{
								waypoint2 = base.method_4()[Enumerable.Count<Waypoint>(base.method_4()) - 2];
							}
							else
							{
								waypoint2 = new Waypoint(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), 0f, Waypoint.WaypointType.TurningPoint, Waypoint.Enum80.const_0, Waypoint.Enum79.const_0);
							}
						}
						else
						{
							waypoint2 = base.method_4()[Enumerable.Count<Waypoint>(base.method_4()) - 1];
						}
					}
					else
					{
						waypoint2 = new Waypoint(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), 0f, Waypoint.WaypointType.TurningPoint, Waypoint.Enum80.const_0, Waypoint.Enum79.const_0);
					}
					double num = 0.0;
					Weapon.WeaponGuidanceType weaponGuidanceType = weapon.method_169();
					if (weaponGuidanceType == Weapon.WeaponGuidanceType.Inertial)
					{
						try
						{
							if (this.activeUnit_0.vmethod_86().vmethod_3().vmethod_40() > 0f)
							{
								double? num2 = ActiveUnit_Navigator.smethod_5(waypoint2.imethod_2(), waypoint2.imethod_0(), (double)this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_86().vmethod_3(), float_2);
								if (num2 == null)
								{
									ValueTuple<Geopoint_Struct, TimeSpan> valueTuple = ActiveUnit_Navigator.smethod_4(this.activeUnit_0, float_2, this.activeUnit_0.vmethod_86().vmethod_3());
									if (!Information.IsNothing(valueTuple.Item1))
									{
										num2 = new double?((double)this.activeUnit_0.method_34(valueTuple.Item1.double_1, valueTuple.Item1.double_0));
									}
								}
								if (num2 == null)
								{
									return false;
								}
								Geopoint_Struct geopoint_Struct = default(Geopoint_Struct);
								float num3 = Class437.smethod_11(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_86().method_68(this.activeUnit_0.vmethod_86().vmethod_3()));
								if ((num3 > 10f && num3 < 350f) || (num3 > 170f && num3 < 190f))
								{
									geopoint_Struct = Class437.smethod_12(new Geopoint_Struct(waypoint2.imethod_0(), waypoint2.imethod_2()), num2.Value, new Geopoint_Struct(this.activeUnit_0.vmethod_86().vmethod_3().vmethod_28(null), this.activeUnit_0.vmethod_86().vmethod_3().vmethod_30(null)), (double)this.activeUnit_0.vmethod_86().vmethod_3().vmethod_9());
								}
								if (!Information.IsNothing(geopoint_Struct) && !geopoint_Struct.method_0())
								{
									waypoint.imethod_3(geopoint_Struct.double_1);
									waypoint.imethod_1(geopoint_Struct.double_0);
								}
								else
								{
									Geopoint_Struct? geopoint_Struct2 = new Geopoint_Struct?(this.method_62(float_2, this.activeUnit_0.vmethod_86().vmethod_3(), null));
									if (geopoint_Struct2 == null)
									{
										waypoint.imethod_3(this.activeUnit_0.vmethod_86().vmethod_3().vmethod_30(null));
										waypoint.imethod_1(this.activeUnit_0.vmethod_86().vmethod_3().vmethod_28(null));
									}
									else
									{
										waypoint.imethod_3(geopoint_Struct2.Value.double_1);
										waypoint.imethod_1(geopoint_Struct2.Value.double_0);
									}
								}
							}
							else
							{
								waypoint.imethod_3(this.activeUnit_0.vmethod_86().vmethod_3().vmethod_30(null));
								waypoint.imethod_1(this.activeUnit_0.vmethod_86().vmethod_3().vmethod_28(null));
							}
							goto IL_EA1;
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 101230", "");
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							goto IL_EA1;
						}
					}
					try
					{
						double[] array = new double[this.activeUnit_0.vmethod_96().Length + 1];
						if (this.activeUnit_0.vmethod_96().Length == 0)
						{
							foreach (Warhead warhead in weapon.warhead_0)
							{
								if (warhead.warheadType_0 == Warhead.WarheadType.Weapon)
								{
									Weapon weapon2 = warhead.method_17(weapon.scenario_0);
									int num4 = weapon2.vmethod_96().Length - 1;
									for (int j = 0; j <= num4; j++)
									{
										if (weapon2.vmethod_96()[j].sensor_Type_0 != Sensor.Sensor_Type.ESM || weapon.class394_0.bool_5)
										{
											array[j] = (double)weapon2.vmethod_96()[j].float_0;
										}
									}
								}
							}
							num = Enumerable.Max(array);
						}
						else
						{
							int num5 = this.activeUnit_0.vmethod_96().Length - 1;
							for (int k = 0; k <= num5; k++)
							{
								if (this.activeUnit_0.vmethod_96()[k].sensor_Type_0 != Sensor.Sensor_Type.ESM || weapon.class394_0.bool_5)
								{
									array[k] = (double)this.activeUnit_0.vmethod_96()[k].float_0;
								}
							}
							num = Enumerable.Max(array);
						}
						if (((Weapon)this.activeUnit_0).method_2() && this.activeUnit_0.vmethod_86().vmethod_3().contactType_0 == Contact_Base.ContactType.Submarine)
						{
							num = 0.0;
						}
						if (bool_17 && this.activeUnit_0.vmethod_86().vmethod_3().contactType_0 == Contact_Base.ContactType.Submarine && ((Weapon)this.activeUnit_0).struct36_0.bool_12)
						{
							num = 0.0;
						}
						if (this.activeUnit_0.vmethod_86().vmethod_3().contactType_0 != Contact_Base.ContactType.Aimpoint)
						{
							if (this.activeUnit_0.vmethod_86().vmethod_3().contactType_0 != Contact_Base.ContactType.ActivationPoint)
							{
								float num6 = waypoint2.method_12(this.activeUnit_0.vmethod_86().vmethod_3().vmethod_28(null), this.activeUnit_0.vmethod_86().vmethod_3().vmethod_30(null));
								float num7 = this.activeUnit_0.vmethod_40() / 3600f * 2f;
								if (this.activeUnit_0.vmethod_86().vmethod_3().vmethod_40() <= 0f)
								{
									double num8;
									if ((double)num6 > num)
									{
										num8 = (double)num6 - num * 0.8;
										if (num8 < (double)num7)
										{
											num8 = 0.0001;
										}
									}
									else
									{
										num8 = (double)num6 * 0.5;
										if (num8 < (double)num7)
										{
											num8 = 0.0001;
										}
									}
									double double_ = waypoint2.imethod_0();
									double double_2 = waypoint2.imethod_2();
									Waypoint waypoint3;
									double double_3 = (waypoint3 = waypoint).imethod_0();
									Waypoint waypoint4;
									double double_4 = (waypoint4 = waypoint).imethod_2();
									Class411.smethod_1(double_, double_2, ref double_3, ref double_4, (double)((float)num8), (double)Math2.smethod_17(waypoint2.imethod_2(), waypoint2.imethod_0(), this.activeUnit_0.vmethod_86().vmethod_3().vmethod_30(null), this.activeUnit_0.vmethod_86().vmethod_3().vmethod_28(null)));
									waypoint4.imethod_3(double_4);
									waypoint3.imethod_1(double_3);
									goto IL_E67;
								}
								double? num9 = ActiveUnit_Navigator.smethod_5(waypoint2.imethod_2(), waypoint2.imethod_0(), (double)this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_86().vmethod_3(), float_2);
								if (num9 == null)
								{
									ValueTuple<Geopoint_Struct, TimeSpan> valueTuple2 = ActiveUnit_Navigator.smethod_4(this.activeUnit_0, float_2, this.activeUnit_0.vmethod_86().vmethod_3());
									if (!Information.IsNothing(valueTuple2))
									{
										num9 = new double?((double)this.activeUnit_0.method_34(valueTuple2.Item1.double_1, valueTuple2.Item1.double_0));
									}
								}
								if (num9 == null)
								{
									return false;
								}
								if (this.activeUnit_0.vmethod_86().vmethod_3().method_103())
								{
									double num10 = (double)this.activeUnit_0.method_39(this.activeUnit_0.vmethod_86().vmethod_3(), this.activeUnit_0.vmethod_40(), this.activeUnit_0.vmethod_9());
									float num11 = Class437.smethod_11(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_86().method_68(this.activeUnit_0.vmethod_86().vmethod_3()));
									Geopoint_Struct geopoint_Struct3;
									if (this.activeUnit_0.vmethod_86().vmethod_3().method_91())
									{
										geopoint_Struct3 = this.method_62(float_2, this.activeUnit_0.vmethod_86().vmethod_3(), null);
									}
									else
									{
										if (((num11 > 5f && num11 < 355f) || (num11 > 175f && num11 < 185f)) && num10 < (double)this.activeUnit_0.vmethod_40() * 1.25)
										{
											geopoint_Struct3 = Class437.smethod_12(new Geopoint_Struct(waypoint2.imethod_0(), waypoint2.imethod_2()), num9.Value, new Geopoint_Struct(this.activeUnit_0.vmethod_86().vmethod_3().vmethod_28(null), this.activeUnit_0.vmethod_86().vmethod_3().vmethod_30(null)), (double)this.activeUnit_0.vmethod_86().vmethod_3().vmethod_9());
										}
										if (geopoint_Struct3.method_0() && ((num11 > 10f && num11 < 350f) || (num11 > 170f && num11 < 190f)))
										{
											geopoint_Struct3 = Class437.smethod_12(new Geopoint_Struct(waypoint2.imethod_0(), waypoint2.imethod_2()), num9.Value, new Geopoint_Struct(this.activeUnit_0.vmethod_86().vmethod_3().vmethod_28(null), this.activeUnit_0.vmethod_86().vmethod_3().vmethod_30(null)), (double)this.activeUnit_0.vmethod_86().vmethod_3().vmethod_9());
										}
									}
									double num8;
									Waypoint waypoint3;
									double double_3;
									Waypoint waypoint4;
									double double_4;
									if (geopoint_Struct3.method_0())
									{
										if ((double)num6 > num * 0.8)
										{
											num8 = (double)(num6 / 2f);
											if (num8 < (double)num7)
											{
												num8 = 0.0001;
											}
										}
										else
										{
											num8 = 0.0001;
										}
										double double_5 = waypoint2.imethod_0();
										double double_6 = waypoint2.imethod_2();
										double_3 = (waypoint3 = waypoint).imethod_0();
										double_4 = (waypoint4 = waypoint).imethod_2();
										Class411.smethod_1(double_5, double_6, ref double_3, ref double_4, (double)((float)num8), (double)((float)num9.Value));
										waypoint4.imethod_3(double_4);
										waypoint3.imethod_1(double_3);
										goto IL_E67;
									}
									float num12 = Math2.smethod_15(waypoint2.imethod_2(), waypoint2.imethod_0(), geopoint_Struct3.double_1, geopoint_Struct3.double_0);
									if ((double)num6 < num * 0.8)
									{
										num8 = 0.0001;
									}
									else if ((double)num12 > (double)num6 - num * 0.8)
									{
										num8 = (double)(num12 - (float)((double)num12 - ((double)num6 - num * 0.8)));
										if (num8 <= 0.0)
										{
											num8 = 0.0001;
										}
										if (num8 < (double)num7)
										{
											num8 = 0.0001;
										}
									}
									else
									{
										num8 = (double)num12;
										if (num8 < (double)num7)
										{
											num8 = 0.0001;
										}
									}
									double double_7 = waypoint2.imethod_0();
									double double_8 = waypoint2.imethod_2();
									double_4 = (waypoint4 = waypoint).imethod_0();
									double_3 = (waypoint3 = waypoint).imethod_2();
									Class411.smethod_1(double_7, double_8, ref double_4, ref double_3, (double)((float)num8), (double)Math2.smethod_17(waypoint2.imethod_2(), waypoint2.imethod_0(), geopoint_Struct3.double_1, geopoint_Struct3.double_0));
									waypoint3.imethod_3(double_3);
									waypoint4.imethod_1(double_4);
									goto IL_E67;
								}
								else
								{
									Geopoint_Struct geopoint_Struct3 = Class437.smethod_12(new Geopoint_Struct(waypoint2.imethod_0(), waypoint2.imethod_2()), num9.Value, new Geopoint_Struct(this.activeUnit_0.vmethod_86().vmethod_3().vmethod_28(null), this.activeUnit_0.vmethod_86().vmethod_3().vmethod_30(null)), (double)this.activeUnit_0.vmethod_86().vmethod_3().vmethod_9());
									double num8;
									Waypoint waypoint3;
									double double_3;
									Waypoint waypoint4;
									double double_4;
									if (!Information.IsNothing(geopoint_Struct3) && !geopoint_Struct3.method_0())
									{
										float num13 = Math2.smethod_15(waypoint2.imethod_2(), waypoint2.imethod_0(), geopoint_Struct3.double_1, geopoint_Struct3.double_0);
										if ((double)num13 < num * 0.8)
										{
											num8 = 0.0001;
										}
										else if ((double)num13 > (double)num6 - num * 0.8)
										{
											num8 = (double)(num13 - (float)((double)num13 - ((double)num6 - num * 0.8)));
											if (num8 <= 0.0)
											{
												num8 = 0.0001;
											}
											if (num8 < (double)num7)
											{
												num8 = 0.0001;
											}
										}
										else
										{
											num8 = (double)num13 - num * 0.8;
											if (num8 < (double)num7)
											{
												num8 = 0.0001;
											}
										}
										double double_9 = waypoint2.imethod_0();
										double double_10 = waypoint2.imethod_2();
										double_4 = (waypoint4 = waypoint).imethod_0();
										double_3 = (waypoint3 = waypoint).imethod_2();
										Class411.smethod_1(double_9, double_10, ref double_4, ref double_3, (double)((float)num8), (double)Math2.smethod_17(waypoint2.imethod_2(), waypoint2.imethod_0(), geopoint_Struct3.double_1, geopoint_Struct3.double_0));
										waypoint3.imethod_3(double_3);
										waypoint4.imethod_1(double_4);
										goto IL_E67;
									}
									if ((double)num6 > num * 0.8)
									{
										num8 = (double)(num6 / 2f);
										if (num8 < (double)num7)
										{
											num8 = 0.0001;
										}
									}
									else
									{
										num8 = 0.0001;
									}
									double double_11 = waypoint2.imethod_0();
									double double_12 = waypoint2.imethod_2();
									double_3 = (waypoint3 = waypoint).imethod_0();
									double_4 = (waypoint4 = waypoint).imethod_2();
									Class411.smethod_1(double_11, double_12, ref double_3, ref double_4, (double)((float)num8), (double)((float)num9.Value));
									waypoint4.imethod_3(double_4);
									waypoint3.imethod_1(double_3);
									goto IL_E67;
								}
							}
						}
						waypoint.imethod_3(this.activeUnit_0.vmethod_86().vmethod_3().vmethod_30(null));
						waypoint.imethod_1(this.activeUnit_0.vmethod_86().vmethod_3().vmethod_28(null));
						IL_E67:;
					}
					catch (Exception ex2)
					{
						ex2.Data.Add("Error at 101231", "");
						GameGeneral.smethod_25(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
					IL_EA1:
					waypoint.imethod_5(this.activeUnit_0.vmethod_86().vmethod_3().vmethod_14(false));
					if (((Weapon)this.activeUnit_0).warhead_0.Length > 0)
					{
						if (((Weapon)this.activeUnit_0).warhead_0[0].method_16((Weapon)this.activeUnit_0, this.activeUnit_0.vmethod_86().vmethod_3().activeUnit_0))
						{
							waypoint.imethod_5(this.activeUnit_0.vmethod_86().vmethod_3().vmethod_14(false) + (float)((Weapon)this.activeUnit_0).method_206(this.activeUnit_0.vmethod_86().vmethod_3().activeUnit_0));
						}
						else
						{
							waypoint.imethod_5(this.activeUnit_0.vmethod_86().vmethod_3().vmethod_14(false));
							if (weapon.method_277())
							{
								if (weapon.vmethod_3() || weapon.method_204())
								{
									if (weapon.vmethod_96().Length > 0)
									{
										float num14 = Enumerable.Max(Enumerable.Select<Sensor, float>(weapon.vmethod_96(), (Weapon_Navigator._Closure$__.$I7-0 == null) ? (Weapon_Navigator._Closure$__.$I7-0 = new Func<Sensor, float>(Weapon_Navigator._Closure$__.$I.method_0)) : Weapon_Navigator._Closure$__.$I7-0));
										waypoint.imethod_5((float)((double)num14 * 1852.0 / 2.0));
									}
									else if (weapon.warhead_0.Length > 0 && weapon.warhead_0[0].method_17(this.activeUnit_0.scenario_0).vmethod_96().Length > 0)
									{
										float num14 = Enumerable.Max(Enumerable.Select<Sensor, float>(weapon.warhead_0[0].method_17(this.activeUnit_0.scenario_0).vmethod_96(), (Weapon_Navigator._Closure$__.$I7-1 == null) ? (Weapon_Navigator._Closure$__.$I7-1 = new Func<Sensor, float>(Weapon_Navigator._Closure$__.$I.method_1)) : Weapon_Navigator._Closure$__.$I7-1));
										waypoint.imethod_5((float)((double)num14 * 1852.0 / 2.0));
									}
								}
								if (weapon.class394_0.bool_5 && (this.activeUnit_0.vmethod_86().vmethod_3().contactType_0 == Contact_Base.ContactType.Aimpoint || this.activeUnit_0.vmethod_86().vmethod_3().contactType_0 == Contact_Base.ContactType.ActivationPoint))
								{
									int num15 = (int)Math.Round(num * 1852.0 * Math2.smethod_2(45.0) * 0.9);
									waypoint.imethod_5(Math.Min((float)num15, (((Weapon)this.activeUnit_0).float_27 > 0f) ? ((Weapon)this.activeUnit_0).float_27 : ((Weapon)this.activeUnit_0).method_145()));
								}
							}
						}
					}
					if (((Weapon)this.activeUnit_0).method_167() == Weapon._WeaponType.Decoy_Expendable)
					{
						waypoint.imethod_5(this.activeUnit_0.vmethod_14(false));
					}
					else if (((Weapon)this.activeUnit_0).method_199() && !((Weapon)this.activeUnit_0).method_195() && !((Weapon)this.activeUnit_0).method_196())
					{
						waypoint.imethod_5(this.activeUnit_0.vmethod_14(false));
					}
					if (base.method_46() && Enumerable.Last<Waypoint>(base.method_4()).waypointType_0 == Waypoint.WaypointType.TerminalPoint)
					{
						base.method_4()[Enumerable.Count<Waypoint>(base.method_4()) - 1].imethod_3(waypoint.imethod_2());
						base.method_4()[Enumerable.Count<Waypoint>(base.method_4()) - 1].imethod_1(waypoint.imethod_0());
						base.method_4()[Enumerable.Count<Waypoint>(base.method_4()) - 1].imethod_5(waypoint.imethod_4());
					}
					else
					{
						this.vmethod_24(waypoint.imethod_2(), waypoint.imethod_0(), waypoint.imethod_4(), Waypoint.WaypointType.TerminalPoint, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0);
					}
					result = true;
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 100987", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x001FC5E8 File Offset: 0x001FA7E8
		public override void vmethod_19(float float_2, ref bool bool_17, ref bool bool_18)
		{
			Weapon weapon = (Weapon)this.activeUnit_0;
			if ((weapon.method_169() != Weapon.WeaponGuidanceType.Inertial || weapon.bool_7 || weapon.method_167() == Weapon._WeaponType.Decoy_Vehicle || Enumerable.Count<Waypoint>(base.method_4()) != 1) && (Information.IsNothing(weapon.vmethod_142().vmethod_3()) || !weapon.method_231() || (weapon.vmethod_142().vmethod_3().contactType_0 != Contact_Base.ContactType.Submarine && weapon.vmethod_142().vmethod_3().contactType_0 != Contact_Base.ContactType.ActivationPoint && weapon.vmethod_142().vmethod_3().contactType_0 != Contact_Base.ContactType.Aimpoint) || Enumerable.Count<Waypoint>(base.method_4()) != 1))
			{
				bool flag = false;
				bool flag2 = false;
				base.vmethod_19(float_2, ref flag, ref flag2);
				if (Enumerable.Count<Waypoint>(base.method_4()) == 0 && weapon.method_167() == Weapon._WeaponType.Decoy_Vehicle)
				{
					this.activeUnit_0.vmethod_86().vmethod_4(null);
				}
			}
		}
	}
}
