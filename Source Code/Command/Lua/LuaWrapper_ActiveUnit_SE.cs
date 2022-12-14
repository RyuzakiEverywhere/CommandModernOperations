using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns13;
using ns14;

namespace Command_Core.Lua
{
	// Token: 0x0200042C RID: 1068
	[Attribute1]
	[Attribute2]
	[Attribute3]
	public sealed class LuaWrapper_ActiveUnit_SE : LuaWrapper_ActiveUnit
	{
		// Token: 0x0600200A RID: 8202 RVA: 0x0001009C File Offset: 0x0000E29C
		public LuaWrapper_ActiveUnit_SE(ActiveUnit a, Scenario s) : base(a, s)
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x0023B128 File Offset: 0x00239328
		// (set) Token: 0x0600200C RID: 8204 RVA: 0x002460C8 File Offset: 0x002442C8
		[Attribute2]
		public override double latitude
		{
			get
			{
				return this.au.vmethod_30(null);
			}
			set
			{
				double? num = LuaUtility.smethod_12(value);
				if (num == null)
				{
					throw new Exception3("Can't pass nil in as latitude.");
				}
				this.au.vmethod_42(ref this.au.scenario_0, this.au.vmethod_28(null), num.Value);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x0023B14C File Offset: 0x0023934C
		// (set) Token: 0x0600200E RID: 8206 RVA: 0x00246128 File Offset: 0x00244328
		[Attribute2]
		public override double longitude
		{
			get
			{
				return this.au.vmethod_28(null);
			}
			set
			{
				double? num = LuaUtility.smethod_14(value);
				if (num == null)
				{
					throw new Exception3("Can't pass nil in as longitude.");
				}
				this.au.vmethod_42(ref this.au.scenario_0, num.Value, this.au.vmethod_30(null));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x0000FACB File Offset: 0x0000DCCB
		// (set) Token: 0x06002010 RID: 8208 RVA: 0x00246188 File Offset: 0x00244388
		[Attribute2]
		public override bool autodetectable
		{
			get
			{
				return this.au.method_92(null);
			}
			set
			{
				this.au.method_93(null, value);
				if (value)
				{
					Contact contact = null;
					foreach (Side side in this.ScenarioContext.method_44())
					{
						if (side != this.au.vmethod_7(false))
						{
							ActiveUnit_Sensory.smethod_5(ref contact, ref this.ScenarioContext, side, this.au, ActiveUnit_Sensory.Enum35.const_4, null, Contact_Base.IdentificationStatus.KnownDomain, null);
						}
					}
				}
			}
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x002461EC File Offset: 0x002443EC
		[Attribute2]
		public void updateorbit(LuaTable theTable)
		{
			if (!this.au.method_1())
			{
				throw new Exception3("Unit: " + this.au.Name + " is not a satellite!");
			}
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(theTable.GetEnumerator());
			LuaUtility.smethod_5(ref dictionary);
			if (dictionary.ContainsKey("TLE"))
			{
				string text = Conversions.ToString(dictionary["TLE"]);
				try
				{
					string[] string_ = text.Split(new char[]
					{
						'\n'
					});
					((Satellite)this.au).method_142().method_20(string_);
				}
				catch (Exception ex)
				{
					throw new Exception3(ex.Message);
				}
			}
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x000100A6 File Offset: 0x0000E2A6
		[Attribute2]
		public void delete()
		{
			this.ScenarioContext.method_66(this.au.string_0, true);
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x0000FB5F File Offset: 0x0000DD5F
		// (set) Token: 0x06002014 RID: 8212 RVA: 0x002462A8 File Offset: 0x002444A8
		[Attribute2]
		public override object altitude
		{
			get
			{
				return this.au.vmethod_14(true);
			}
			set
			{
				this.au.vmethod_15(true, LuaUtility.smethod_19(RuntimeHelpers.GetObjectValue(value)).Value);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x0000FB72 File Offset: 0x0000DD72
		// (set) Token: 0x06002016 RID: 8214 RVA: 0x002462D4 File Offset: 0x002444D4
		[Attribute2]
		public override object speed
		{
			get
			{
				return this.au.vmethod_40();
			}
			set
			{
				float num = Conversions.ToSingle(value);
				if (num > (float)this.au.vmethod_87().vmethod_40(this.au.vmethod_14(false), this.au.vmethod_84(), false))
				{
					num = (float)this.au.vmethod_87().vmethod_40(this.au.vmethod_14(false), this.au.vmethod_84(), false);
				}
				this.au.vmethod_41(num);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x0024634C File Offset: 0x0024454C
		// (set) Token: 0x06002018 RID: 8216 RVA: 0x00246384 File Offset: 0x00244584
		[Attribute2]
		public override object manualAltitude
		{
			get
			{
				object result;
				if (this.au.vmethod_87().vmethod_12())
				{
					result = this.au.vmethod_72();
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				string left = Conversions.ToString(value).ToUpper();
				if (Operators.CompareString(left, "CURRENT", false) == 0)
				{
					this.au.vmethod_14(false);
					this.au.vmethod_87().vmethod_13(true);
					return;
				}
				if (Operators.CompareString(left, "DESIRED", false) == 0)
				{
					this.au.vmethod_72();
					this.au.vmethod_87().vmethod_13(true);
					return;
				}
				if (Operators.CompareString(left, "OFF", false) == 0)
				{
					this.au.vmethod_87().vmethod_13(false);
					return;
				}
				if (this.au.bool_5)
				{
					ActiveUnit_AI.SubmarineDepthPreset? submarineDepthPreset = LuaUtility.smethod_21(Conversions.ToString(value));
					if (submarineDepthPreset != null)
					{
						((Submarine)this.au).method_153().method_115(submarineDepthPreset.Value);
						((Submarine)this.au).method_153().vmethod_27();
						this.au.vmethod_87().vmethod_13(true);
						return;
					}
					LuaUtility.smethod_22(Conversions.ToString(value));
					this.au.vmethod_73((float)submarineDepthPreset.Value);
					((Submarine)this.au).method_153().method_115(ActiveUnit_AI.SubmarineDepthPreset.None);
					this.au.vmethod_87().vmethod_13(true);
					return;
				}
				else
				{
					if (!this.au.bool_3)
					{
						float float_;
						if (float.TryParse(Conversions.ToString(value), out float_))
						{
							this.au.vmethod_73(float_);
							this.au.vmethod_87().vmethod_13(true);
						}
						return;
					}
					ActiveUnit_AI.AircraftAltitudePreset? aircraftAltitudePreset = LuaUtility.smethod_18(Conversions.ToString(value));
					if (aircraftAltitudePreset != null)
					{
						((Aircraft)this.au).method_158().method_115(aircraftAltitudePreset.Value);
						((Aircraft)this.au).method_158().vmethod_27();
						this.au.vmethod_87().vmethod_13(true);
						return;
					}
					float? num = LuaUtility.smethod_19(Conversions.ToString(value));
					this.au.vmethod_73(num.Value);
					((Aircraft)this.au).method_158().method_115(ActiveUnit_AI.AircraftAltitudePreset.None);
					this.au.vmethod_87().vmethod_13(true);
					return;
				}
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x002465A0 File Offset: 0x002447A0
		// (set) Token: 0x0600201A RID: 8218 RVA: 0x002465EC File Offset: 0x002447EC
		[Attribute2]
		public override object manualSpeed
		{
			get
			{
				object result;
				if (this.au.vmethod_87().vmethod_1() == ActiveUnit_Kinematics.UnitThrottlePreset.None)
				{
					result = this.au.vmethod_87().vmethod_10();
				}
				else
				{
					result = this.au.vmethod_70();
				}
				return result;
			}
			set
			{
				string left = Conversions.ToString(value).ToUpper();
				if (Operators.CompareString(left, "CURRENT", false) == 0)
				{
					float value2 = this.au.vmethod_40();
					this.au.vmethod_87().vmethod_11(new float?(value2));
				}
				else if (Operators.CompareString(left, "DESIRED", false) == 0)
				{
					float value2 = this.au.vmethod_70();
					this.au.vmethod_87().vmethod_11(new float?(value2));
				}
				else if (Operators.CompareString(left, "OFF", false) == 0)
				{
					this.au.vmethod_87().vmethod_11(null);
				}
				else
				{
					float? num = null;
					try
					{
						num = new float?(float.Parse(Conversions.ToString(value)));
					}
					catch (Exception ex)
					{
					}
					if (num != null)
					{
						this.au.vmethod_87().vmethod_11(new float?(num.Value));
						this.au.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.None);
					}
				}
				float? num2 = this.au.vmethod_87().vmethod_10();
				if (num2 != null)
				{
					this.au.vmethod_134(this.au.vmethod_87().vmethod_41(this.au.vmethod_14(false), num2.Value), null);
					float? num3 = num2;
					float num4 = (float)this.au.vmethod_87().vmethod_40(this.au.vmethod_14(false), this.au.vmethod_84(), false);
					if (((num3 != null) ? new bool?(num3.GetValueOrDefault() > num4) : null).GetValueOrDefault())
					{
						this.au.vmethod_87().vmethod_11(new float?((float)this.au.vmethod_87().vmethod_40(this.au.vmethod_14(false), this.au.vmethod_84(), false)));
					}
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600201B RID: 8219 RVA: 0x002467FC File Offset: 0x002449FC
		// (set) Token: 0x0600201C RID: 8220 RVA: 0x0024684C File Offset: 0x00244A4C
		[Attribute2]
		public object manualThrottle
		{
			get
			{
				object result;
				if (this.au.vmethod_87().vmethod_1() == ActiveUnit_Kinematics.UnitThrottlePreset.None)
				{
					result = this.au.vmethod_87().vmethod_10();
				}
				else
				{
					result = this.au.vmethod_87().vmethod_1();
				}
				return result;
			}
			set
			{
				string left = Conversions.ToString(value).ToUpper();
				if (Operators.CompareString(left, "CURRENT", false) == 0)
				{
					float value2 = this.au.vmethod_40();
					this.au.vmethod_87().vmethod_11(new float?(value2));
					return;
				}
				if (Operators.CompareString(left, "DESIRED", false) == 0)
				{
					float value2 = this.au.vmethod_70();
					this.au.vmethod_87().vmethod_11(new float?(value2));
					return;
				}
				if (Operators.CompareString(left, "OFF", false) == 0)
				{
					this.au.vmethod_87().vmethod_11(null);
					return;
				}
				ActiveUnit_Kinematics.UnitThrottlePreset unitThrottlePreset;
				if (Enum.TryParse<ActiveUnit_Kinematics.UnitThrottlePreset>(Conversions.ToString(value), true, out unitThrottlePreset) && Enum.IsDefined(typeof(ActiveUnit_Kinematics.UnitThrottlePreset), unitThrottlePreset))
				{
					this.au.vmethod_87().vmethod_2(unitThrottlePreset);
					this.au.vmethod_87().vmethod_11(new float?((float)this.au.vmethod_87().vmethod_40(this.au.vmethod_14(false), (ActiveUnit.Throttle)this.au.vmethod_87().vmethod_1(), false)));
				}
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600201D RID: 8221 RVA: 0x0000FB84 File Offset: 0x0000DD84
		// (set) Token: 0x0600201E RID: 8222 RVA: 0x00246970 File Offset: 0x00244B70
		[Attribute2]
		public override object throttle
		{
			get
			{
				return this.au.vmethod_84();
			}
			set
			{
				this.au.vmethod_134(LuaUtility.smethod_25(Conversions.ToString(value)), null);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600201F RID: 8223 RVA: 0x0024699C File Offset: 0x00244B9C
		// (set) Token: 0x06002020 RID: 8224 RVA: 0x00246B8C File Offset: 0x00244D8C
		[Attribute2]
		public override LuaTable course
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				foreach (Waypoint waypoint in this.au.vmethod_85().method_4())
				{
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					luaTable2["latitude"] = waypoint.imethod_2();
					luaTable2["longitude"] = waypoint.imethod_0();
					if (waypoint.method_31() != ActiveUnit_AI.AircraftAltitudePreset.None)
					{
						luaTable2["PresetAltitude"] = waypoint.method_31().ToString();
					}
					if (waypoint.method_33() != ActiveUnit_AI.SubmarineDepthPreset.None)
					{
						luaTable2["PresetDepth"] = waypoint.method_33().ToString();
					}
					if (waypoint.method_35() != ActiveUnit_Kinematics.UnitThrottlePreset.None)
					{
						luaTable2["PresetThrottle"] = waypoint.method_35().ToString();
					}
					if (waypoint.nullable_1 != null)
					{
						luaTable2["DesiredAltitude"] = waypoint.nullable_1.ToString();
					}
					if (waypoint.nullable_2 != null)
					{
						luaTable2["DesiredAltitudeTF"] = waypoint.nullable_2.ToString();
					}
					if (waypoint.nullable_0 != null)
					{
						luaTable2["DesiredSpeed"] = waypoint.nullable_0.ToString();
					}
					if (waypoint.method_37())
					{
						luaTable2["TF"] = waypoint.method_37().ToString();
					}
					luaTable2["Description"] = waypoint.string_2;
					luaTable2["TypeOf"] = waypoint.waypointType_0.ToString();
					luaTable[num] = luaTable2;
					num++;
				}
				return luaTable;
			}
			set
			{
				if (value == null)
				{
					this.au.vmethod_85().vmethod_9();
					return;
				}
				this.au.vmethod_85().vmethod_9();
				List<object> list = LuaUtility.smethod_0(value.GetEnumerator());
				try
				{
					foreach (object obj in list)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						if (!(objectValue is LuaTable))
						{
							throw new Exception3("Error at " + LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(objectValue)));
						}
						Dictionary<string, object> dictionary = LuaUtility.smethod_1(((LuaTable)objectValue).GetEnumerator());
						double? num = LuaUtility.smethod_13(dictionary);
						double? num2 = LuaUtility.smethod_11(dictionary);
						if (num == null | num == null)
						{
							throw new Exception3("Course object " + LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(objectValue)) + " needs latitude or longitude.");
						}
						double? num3 = num;
						bool? flag = (num3 != null) ? new bool?(num3.GetValueOrDefault() == 0.0) : null;
						num3 = num;
						bool? flag2 = (num3 != null) ? new bool?(num3.GetValueOrDefault() == 0.0) : null;
						if (((flag == null || !flag.GetValueOrDefault()) ? ((flag2 != null) ? (flag | flag2.GetValueOrDefault()) : null) : new bool?(true)).GetValueOrDefault())
						{
							throw new Exception3("Course object " + LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(objectValue)) + " Latitude or Longitude cannot be 0.");
						}
						this.au.vmethod_85().vmethod_24(num2.Value, num.Value, 0f, Waypoint.WaypointType.ManualPlottedCourseWaypoint, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0);
						if (this.au.vmethod_85().method_4() != null)
						{
							Waypoint waypoint = Enumerable.Last<Waypoint>(this.au.vmethod_85().method_4());
							if (dictionary.ContainsKey("PRESETALTITUDE"))
							{
								float? num4 = LuaUtility.smethod_19(Conversions.ToString(dictionary["PRESETALTITUDE"]));
								if (!Information.IsNothing(num4))
								{
									waypoint.method_32((ActiveUnit_AI.AircraftAltitudePreset)Math.Round((double)num4.Value));
								}
							}
							if (dictionary.ContainsKey("PRESETDEPTH"))
							{
								float? num5 = LuaUtility.smethod_22(Conversions.ToString(dictionary["PRESETDEPTH"]));
								if (!Information.IsNothing(num5))
								{
									waypoint.method_34((ActiveUnit_AI.SubmarineDepthPreset)Math.Round((double)num5.Value));
								}
							}
							if (dictionary.ContainsKey("PRESETTHROTTLE"))
							{
								string text = Conversions.ToString(dictionary["PRESETTHROTTLE"]);
								if (Operators.CompareString(text, "5", false) != 0 && Operators.CompareString(text.ToLower(), "none", false) != 0)
								{
									ActiveUnit.Throttle throttle = LuaUtility.smethod_25(text);
									if (!Information.IsNothing(throttle))
									{
										waypoint.method_36((ActiveUnit_Kinematics.UnitThrottlePreset)throttle);
									}
								}
								else
								{
									waypoint.method_36(ActiveUnit_Kinematics.UnitThrottlePreset.None);
								}
							}
							if (dictionary.ContainsKey("TF"))
							{
								bool? flag3 = LuaUtility.smethod_10(Conversions.ToString(dictionary["TF"]));
								if (!Information.IsNothing(flag3))
								{
									waypoint.method_38(flag3.Value);
								}
							}
							if (dictionary.ContainsKey("DESIREDALTITUDE"))
							{
								float? num6 = LuaUtility.smethod_19(Conversions.ToString(dictionary["DESIREDALTITUDE"]));
								if (num6.GetType() == typeof(float))
								{
									waypoint.nullable_1 = new float?(num6.Value);
									waypoint.method_30(true);
								}
							}
							if (dictionary.ContainsKey("DESIREDALTITUDETF"))
							{
								float? num7 = LuaUtility.smethod_19(Conversions.ToString(dictionary["DESIREDALTITUDETF"]));
								if (num7.GetType() == typeof(float))
								{
									waypoint.nullable_2 = new float?(num7.Value);
								}
							}
							if (dictionary.ContainsKey("DESIREDSPEED"))
							{
								float num8 = Conversions.ToSingle(Conversions.ToString(dictionary["DESIREDSPEED"]));
								if (num8 > (float)this.au.vmethod_87().vmethod_40(this.au.vmethod_14(false), this.au.vmethod_84(), false))
								{
									num8 = (float)this.au.vmethod_87().vmethod_40(this.au.vmethod_14(false), this.au.vmethod_84(), false);
								}
								waypoint.nullable_0 = new float?(num8);
								waypoint.method_28(new float?(num8));
							}
							if (dictionary.ContainsKey("DESCRIPTION"))
							{
								string string_ = Conversions.ToString(dictionary["DESCRIPTION"]);
								waypoint.string_2 = string_;
							}
						}
					}
				}
				finally
				{
					List<object>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06002021 RID: 8225 RVA: 0x0023BA7C File Offset: 0x00239C7C
		// (set) Token: 0x06002022 RID: 8226 RVA: 0x00247068 File Offset: 0x00245268
		[Attribute2]
		public override LuaTable fuel
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (FuelRec fuelRec in this.au.vmethod_67())
				{
					if (luaTable[Convert.ToInt32((short)fuelRec._FuelType_0)] == null)
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["current"] = fuelRec.float_0;
						luaTable2["max"] = fuelRec.int_0;
						luaTable2["name"] = fuelRec._FuelType_0.ToString();
						luaTable2["type"] = Convert.ToInt32((short)fuelRec._FuelType_0);
						luaTable[Convert.ToInt32((short)fuelRec._FuelType_0)] = luaTable2;
					}
					else
					{
						LuaTable luaTable3 = (LuaTable)luaTable[Convert.ToInt32((short)fuelRec._FuelType_0)];
						luaTable3["current"] = Conversions.ToSingle(luaTable3["current"]) + fuelRec.float_0;
						luaTable3["max"] = Conversions.ToSingle(luaTable3["max"]) + (float)fuelRec.int_0;
					}
				}
				return luaTable;
			}
			set
			{
				try
				{
					try
					{
						foreach (object value2 in value.Keys)
						{
							double num = Conversions.ToDouble(value2);
							float num2 = Conversions.ToSingle(((LuaTable)value[num])["current"]);
							foreach (FuelRec fuelRec in this.au.vmethod_67())
							{
								if ((double)fuelRec._FuelType_0 == num)
								{
									float num3 = Math.Min((float)fuelRec.int_0, num2);
									num3 = Math.Max(0f, num3);
									fuelRec.float_0 = num3;
									num2 -= num3;
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
				}
				catch (Exception ex)
				{
					throw new Exception3("Error setting fuel.");
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06002023 RID: 8227 RVA: 0x0023B2F8 File Offset: 0x002394F8
		// (set) Token: 0x06002024 RID: 8228 RVA: 0x00247160 File Offset: 0x00245360
		[Attribute2]
		public override object group
		{
			get
			{
				object result;
				if (this.au.vmethod_65(false) != null | this.au.bool_1)
				{
					if (this.au.vmethod_65(false) != null)
					{
						result = new LuaWrapper_Group(this.au.vmethod_65(false), this.ScenarioContext);
					}
					else
					{
						result = new LuaWrapper_Group((Group)this.au, this.ScenarioContext);
					}
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				try
				{
					if (this.au.vmethod_56() == GlobalVariables.ActiveUnitType.None)
					{
						throw new Exception3("Can't change group on a group.");
					}
					if (Operators.CompareString(Conversions.ToString(value).ToLower(), "none", false) == 0)
					{
						this.au.vmethod_66(false, null);
					}
					else
					{
						Group group = LuaUtility.smethod_26(RuntimeHelpers.GetObjectValue(value), this.au.vmethod_7(false), this.ScenarioContext);
						if (group == null)
						{
							List<ActiveUnit> list = new List<ActiveUnit>();
							list.Add(this.au);
							ActiveUnit au;
							Side value2 = (au = this.au).vmethod_7(false);
							Group group2 = new Group(ref this.ScenarioContext, ref value2, list, false, null, null);
							au.vmethod_8(false, value2);
							Group group3 = group2;
							group3.Name = Conversions.ToString(value);
							this.au.vmethod_66(false, group3);
						}
						else
						{
							this.au.vmethod_66(false, group);
						}
					}
				}
				catch (Exception3 exception)
				{
					throw;
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06002025 RID: 8229 RVA: 0x0023BCA0 File Offset: 0x00239EA0
		// (set) Token: 0x06002026 RID: 8230 RVA: 0x00247258 File Offset: 0x00245458
		[Attribute2]
		public override LuaTable formation
		{
			get
			{
				LuaTable result;
				if (Information.IsNothing(this.au.vmethod_65(false)))
				{
					result = null;
				}
				else
				{
					ActiveUnit activeUnit_ = this.au.vmethod_65(false).method_147();
					LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
					ActiveUnit_Navigator.Class216 @class = this.au.vmethod_85().method_2();
					luaTable["guid"] = this.au.string_0;
					luaTable["bearing"] = @class.float_0;
					luaTable["type"] = @class.orientationType_0.ToString();
					luaTable["distance"] = @class.float_1;
					luaTable["sprint"] = this.au.vmethod_85().vmethod_3().ToString();
					Tuple<double, double> tuple = @class.method_0(this.au, activeUnit_);
					luaTable["latitude"] = tuple.Item1;
					luaTable["longitude"] = tuple.Item2;
					result = luaTable;
				}
				return result;
			}
			set
			{
				try
				{
					ActiveUnit activeUnit = this.au.vmethod_65(false).method_147();
					ActiveUnit_Navigator.Class216 @class = this.au.vmethod_85().method_2();
					try
					{
						foreach (object obj in value.Keys)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(obj);
							string left = objectValue.ToString().ToLower();
							if (Operators.CompareString(left, "bearing", false) != 0)
							{
								if (Operators.CompareString(left, "type", false) != 0)
								{
									if (Operators.CompareString(left, "distance", false) != 0)
									{
										if (Operators.CompareString(left, "sprint", false) == 0)
										{
											bool? flag = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(value[RuntimeHelpers.GetObjectValue(objectValue)]));
											if (!Information.IsNothing(flag))
											{
												this.au.vmethod_85().vmethod_4(flag.Value);
											}
										}
									}
									else
									{
										float num = Conversions.ToSingle(value[RuntimeHelpers.GetObjectValue(objectValue)]);
										if (num > 0f)
										{
											@class.float_1 = num;
										}
									}
								}
								else
								{
									ReferencePoint.OrientationType orientationType = ReferencePoint.OrientationType.Fixed;
									if (Enum.TryParse<ReferencePoint.OrientationType>(Conversions.ToString(value[RuntimeHelpers.GetObjectValue(objectValue)]), true, out orientationType) && Enum.IsDefined(typeof(ReferencePoint.OrientationType), orientationType))
									{
										@class.orientationType_0 = orientationType;
									}
								}
							}
							else
							{
								float num2 = Conversions.ToSingle(value[RuntimeHelpers.GetObjectValue(objectValue)]);
								if (num2 >= 0f && num2 < 360f)
								{
									@class.float_0 = num2;
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
					if (!Information.IsNothing(@class))
					{
						Class432.Struct47 @struct = new Class432.Struct47(activeUnit.vmethod_30(null), activeUnit.vmethod_28(null));
						Class432.Struct47 struct2 = default(Class432.Struct47);
						Class432.smethod_13(ref @struct, ref struct2, (double)@class.float_0, (double)@class.float_1);
						double double_ = struct2.double_0;
						double double_2 = struct2.double_1;
						this.au.vmethod_85().vmethod_9();
						this.au.vmethod_85().method_54(double_2, double_, true);
					}
				}
				catch (Exception ex)
				{
					throw new Exception3("Error setting formation.");
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06002027 RID: 8231 RVA: 0x0000FBA8 File Offset: 0x0000DDA8
		// (set) Token: 0x06002028 RID: 8232 RVA: 0x002474C0 File Offset: 0x002456C0
		[Attribute2]
		public override object heading
		{
			get
			{
				return this.au.vmethod_9();
			}
			set
			{
				float float_ = 0f;
				try
				{
					if (float.TryParse(Conversions.ToString(value), out float_))
					{
						this.au.vmethod_10(float_);
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06002029 RID: 8233 RVA: 0x0023CC88 File Offset: 0x0023AE88
		// (set) Token: 0x0600202A RID: 8234 RVA: 0x0024750C File Offset: 0x0024570C
		[Attribute2]
		public override LuaTable OODA
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				luaTable["detection"] = this.au.short_0;
				luaTable["targeting"] = this.au.short_1;
				luaTable["evasion"] = this.au.short_2;
				return luaTable;
			}
			set
			{
				try
				{
					try
					{
						foreach (object value2 in value.Keys)
						{
							string text = Conversions.ToString(value2);
							short num = Conversions.ToShort(value[text]);
							if (Operators.CompareString(text, "detection", false) != 0)
							{
								if (Operators.CompareString(text, "targeting", false) != 0)
								{
									if (Operators.CompareString(text, "evasion", false) == 0)
									{
										this.au.short_2 = num;
									}
								}
								else
								{
									this.au.short_1 = num;
								}
							}
							else
							{
								this.au.short_0 = num;
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
				}
				catch (Exception ex)
				{
					throw new Exception3("Error setting OODA.");
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x0023CDEC File Offset: 0x0023AFEC
		// (set) Token: 0x0600202C RID: 8236 RVA: 0x002475E0 File Offset: 0x002457E0
		[Attribute2]
		public override LuaWrapper_ActiveUnit @base
		{
			get
			{
				LuaWrapper_ActiveUnit result = null;
				string type = base.type;
				if (Operators.CompareString(type, "Ship", false) != 0 && Operators.CompareString(type, "Submarine", false) != 0)
				{
					if (Operators.CompareString(type, "Aircraft", false) == 0 && this.au.vmethod_92() != null)
					{
						Aircraft_AirOps aircraft_AirOps = (Aircraft_AirOps)this.au.vmethod_92();
						if (aircraft_AirOps.method_30() != null)
						{
							result = new LuaWrapper_ActiveUnit(aircraft_AirOps.method_30(), this.ScenarioContext);
						}
						else if (aircraft_AirOps.method_21() != null)
						{
							result = new LuaWrapper_ActiveUnit(aircraft_AirOps.method_21(), this.ScenarioContext);
						}
					}
				}
				else if (this.au.vmethod_93() != null)
				{
					ActiveUnit_DockingOps activeUnit_DockingOps = this.au.vmethod_93();
					if (activeUnit_DockingOps.method_17() != null)
					{
						result = new LuaWrapper_ActiveUnit(activeUnit_DockingOps.method_17(), this.ScenarioContext);
					}
					else if (activeUnit_DockingOps.method_2() != null)
					{
						result = new LuaWrapper_ActiveUnit(activeUnit_DockingOps.method_2(), this.ScenarioContext);
					}
				}
				return result;
			}
			set
			{
				string type = base.type;
				if (Operators.CompareString(type, "Ship", false) != 0 && Operators.CompareString(type, "Submarine", false) != 0)
				{
					if (Operators.CompareString(type, "Aircraft", false) != 0)
					{
						return;
					}
					if (this.au.vmethod_92() != null)
					{
						Aircraft_AirOps aircraft_AirOps = (Aircraft_AirOps)this.au.vmethod_92();
						if (value == null)
						{
							aircraft_AirOps.method_28();
							return;
						}
						ActiveUnit activeUnit = PrivateMethods.smethod_67(value.guid, this.ScenarioContext);
						if (Operators.CompareString(aircraft_AirOps.method_26(activeUnit), "OK", false) == 0)
						{
							aircraft_AirOps.method_33(false, activeUnit);
						}
					}
				}
				else if (this.au.vmethod_93() != null)
				{
					ActiveUnit_DockingOps activeUnit_DockingOps = this.au.vmethod_93();
					if (value == null)
					{
						activeUnit_DockingOps.method_44();
						return;
					}
					ActiveUnit activeUnit2 = PrivateMethods.smethod_67(value.guid, this.ScenarioContext);
					if (Operators.CompareString(activeUnit_DockingOps.method_45(activeUnit2), "OK", false) == 0)
					{
						activeUnit_DockingOps.method_12(false, activeUnit2);
						return;
					}
				}
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x0023D788 File Offset: 0x0023B988
		// (set) Token: 0x0600202E RID: 8238 RVA: 0x000100BF File Offset: 0x0000E2BF
		[Attribute2]
		public override bool sprintDrift
		{
			get
			{
				return !Information.IsNothing(this.au.vmethod_85()) && this.au.vmethod_85().vmethod_3();
			}
			set
			{
				if (!Information.IsNothing(this.au.vmethod_85()))
				{
					this.au.vmethod_85().vmethod_4(value);
				}
			}
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x002476D0 File Offset: 0x002458D0
		[Attribute2]
		public bool RTB(bool value)
		{
			bool result = false;
			if (value)
			{
				string type = base.type;
				if (Operators.CompareString(type, "Ship", false) != 0 && Operators.CompareString(type, "Submarine", false) != 0)
				{
					if (Operators.CompareString(type, "Aircraft", false) == 0 && this.au.vmethod_92() != null)
					{
						result = ((Aircraft)this.au).method_164().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
					}
				}
				else if (this.au.vmethod_93() != null)
				{
					result = this.au.vmethod_93().method_5(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
				}
			}
			else
			{
				string type2 = base.type;
				if (Operators.CompareString(type2, "Ship", false) != 0 && Operators.CompareString(type2, "Submarine", false) != 0)
				{
					if (Operators.CompareString(type2, "Aircraft", false) == 0)
					{
						this.au.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
					}
				}
				else
				{
					this.au.vmethod_109(ActiveUnit._ActiveUnitStatus.Unassigned);
				}
			}
			return result;
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x002477BC File Offset: 0x002459BC
		[Attribute2]
		public bool Launch(bool value)
		{
			bool result = false;
			if (value)
			{
				string type = base.type;
				if (Operators.CompareString(type, "Ship", false) != 0 && Operators.CompareString(type, "Submarine", false) != 0)
				{
					if (Operators.CompareString(type, "Aircraft", false) == 0)
					{
						Aircraft aircraft = (Aircraft)this.au;
						if (this.au.vmethod_92() != null && aircraft.method_175())
						{
							aircraft.method_164().method_37(Aircraft_AirOps._AirOpsCondition.PreparingToLaunch);
							aircraft.method_164().method_70();
							result = true;
						}
					}
				}
				else if (this.au.vmethod_93() != null && this.au.vmethod_123())
				{
					this.au.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
					result = true;
				}
			}
			else
			{
				string type2 = base.type;
				if (Operators.CompareString(type2, "Ship", false) != 0 && Operators.CompareString(type2, "Submarine", false) != 0)
				{
					if (Operators.CompareString(type2, "Aircraft", false) == 0 && this.au.vmethod_92() != null)
					{
						Aircraft aircraft2 = (Aircraft)this.au;
						if (aircraft2.method_164().method_22())
						{
							aircraft2.method_164().method_48(true, false, true);
							if (aircraft2.method_157().method_48())
							{
								aircraft2.method_157().method_7().method_11(this.ScenarioContext, Mission.Enum102.const_0);
							}
							result = true;
						}
					}
				}
				else if (this.au.vmethod_93() != null && this.au.vmethod_93().method_51())
				{
					this.au.vmethod_93().method_48(this.au.vmethod_93().method_17(), true);
					result = true;
				}
				if (this.au.method_120())
				{
					this.au.vmethod_66(false, null);
				}
			}
			return result;
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x0024797C File Offset: 0x00245B7C
		[Attribute2]
		public override string ToString()
		{
			string text = string.Concat(new string[]
			{
				"unit {\r\n type = '",
				base.type,
				"', \r\n subtype = '",
				base.subtype,
				"', \r\n name = '",
				base.name,
				"', \r\n side = '",
				base.side,
				"', \r\n guid = '",
				base.guid.ToString(),
				"', \r\n class = '",
				base.classname.ToString(),
				"', \r\n proficiency = '",
				this.proficiency,
				"', \r\n latitude = '",
				this.latitude.ToString(),
				"', \r\n longitude = '",
				this.longitude.ToString(),
				"', \r\n altitude = '",
				this.altitude.ToString(),
				"', \r\n heading = '",
				this.heading.ToString(),
				"', \r\n speed = '",
				this.speed.ToString(),
				"', \r\n throttle = '",
				((ActiveUnit.Throttle)Conversions.ToByte(this.throttle)).ToString(),
				"', \r\n autodetectable = '",
				this.autodetectable.ToString(),
				"', \r\n"
			});
			if (this.@base != null)
			{
				text = text + " base = '" + this.@base.name + "', \r\n";
			}
			if (this.group != null & !this.au.bool_1)
			{
				LuaWrapper_Group luaWrapper_Group = (LuaWrapper_Group)this.group;
				text = text + " group = '" + luaWrapper_Group.name + "', \r\n";
			}
			if (base.mission != null)
			{
				LuaWrapper_Mission luaWrapper_Mission = (LuaWrapper_Mission)base.mission;
				text = text + " mission = '" + luaWrapper_Mission.name + "', \r\n";
			}
			if (Operators.CompareString(base.type, "None", false) != 0)
			{
				try
				{
					if (this.au.vmethod_51() != null)
					{
						text = text + " mounts = '" + this.au.vmethod_51().Count.ToString() + "', \r\n";
					}
				}
				catch (Exception ex)
				{
				}
				try
				{
					if (this.au.method_91() != null)
					{
						text = text + " magazines = '" + Enumerable.Count<Magazine>(this.au.method_91()).ToString() + "', \r\n";
					}
				}
				catch (Exception ex2)
				{
				}
			}
			text = text + " unitstate = '" + this.au.vmethod_108().ToString() + "', \r\n";
			text = text + " fuelstate = '" + this.au.vmethod_110().ToString() + "', \r\n";
			text = text + " weaponstate = '" + this.au.vmethod_112().ToString() + "', \r\n";
			text += "}";
			return text;
		}
	}
}
