using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns13;
using ns14;
using ns9;

namespace Command_Core
{
	// Token: 0x02000459 RID: 1113
	[StandardModule]
	public sealed class LuaUtility
	{
		// Token: 0x0600222B RID: 8747 RVA: 0x00263FB4 File Offset: 0x002621B4
		public static List<object> smethod_0(IDictionaryEnumerator idictionaryEnumerator_0)
		{
			List<Tuple<int, object>> list = new List<Tuple<int, object>>();
			while (idictionaryEnumerator_0.MoveNext())
			{
				int item = Conversions.ToInteger(idictionaryEnumerator_0.Key);
				list.Add(new Tuple<int, object>(item, RuntimeHelpers.GetObjectValue(idictionaryEnumerator_0.Value)));
			}
			return Enumerable.ToList<object>(Enumerable.Select<Tuple<int, object>, object>(Enumerable.OrderBy<Tuple<int, object>, int>(list, (LuaUtility._Closure$__.$I0-0 == null) ? (LuaUtility._Closure$__.$I0-0 = new Func<Tuple<int, object>, int>(LuaUtility._Closure$__.$I.method_0)) : LuaUtility._Closure$__.$I0-0), (LuaUtility._Closure$__.$I0-1 == null) ? (LuaUtility._Closure$__.$I0-1 = new Func<Tuple<int, object>, object>(LuaUtility._Closure$__.$I.method_1)) : LuaUtility._Closure$__.$I0-1));
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x0026404C File Offset: 0x0026224C
		public static Dictionary<string, object> smethod_1(IDictionaryEnumerator idictionaryEnumerator_0)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			while (idictionaryEnumerator_0.MoveNext())
			{
				string text = Conversions.ToString(idictionaryEnumerator_0.Key).ToUpper();
				if (Operators.CompareString(text, "LAT", false) == 0)
				{
					text = "LATITUDE";
				}
				if (Operators.CompareString(text, "LON", false) == 0)
				{
					text = "LONGITUDE";
				}
				if (Operators.CompareString(text, "LONG", false) == 0)
				{
					text = "LONGITUDE";
				}
				if (Operators.CompareString(text, "ALT", false) == 0)
				{
					text = "ALTITUDE";
				}
				if (Operators.CompareString(text, "OBJECTID", false) == 0)
				{
					text = "GUID";
				}
				dictionary[text] = RuntimeHelpers.GetObjectValue(idictionaryEnumerator_0.Value);
			}
			return dictionary;
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x002640F8 File Offset: 0x002622F8
		public static Dictionary<string, object> smethod_2(IDictionaryEnumerator idictionaryEnumerator_0)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			while (idictionaryEnumerator_0.MoveNext())
			{
				string key = Conversions.ToString(idictionaryEnumerator_0.Key).ToLower();
				dictionary[key] = RuntimeHelpers.GetObjectValue(idictionaryEnumerator_0.Value);
			}
			return dictionary;
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x0026413C File Offset: 0x0026233C
		public static void smethod_3(Dictionary<string, object> dictionary_0, LuaTable luaTable_0)
		{
			IDictionaryEnumerator dictionaryEnumerator = (IDictionaryEnumerator)dictionary_0.GetEnumerator();
			while (dictionaryEnumerator.MoveNext())
			{
				luaTable_0[Conversions.ToString(dictionaryEnumerator.Key).ToLower()] = RuntimeHelpers.GetObjectValue(dictionaryEnumerator.Value);
			}
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x00264188 File Offset: 0x00262388
		public static void smethod_4(IEnumerable<object> ienumerable_0, LuaTable luaTable_0)
		{
			foreach (object obj in ienumerable_0)
			{
				luaTable_0[luaTable_0.Keys.Count + 1] = RuntimeHelpers.GetObjectValue(obj);
			}
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x002641CC File Offset: 0x002623CC
		public static bool smethod_5(ref Dictionary<string, object> dictionary_0)
		{
			IDictionaryEnumerator dictionaryEnumerator = (IDictionaryEnumerator)new Dictionary<string, object>(dictionary_0).GetEnumerator();
			while (dictionaryEnumerator.MoveNext())
			{
				string text = Conversions.ToString(dictionaryEnumerator.Key).ToUpper();
				RuntimeHelpers.GetObjectValue(dictionaryEnumerator.Value);
				if (Operators.CompareString(text, "UNIT", false) == 0)
				{
					text = "UNITNAME";
				}
				if (Operators.CompareString(text, "NAME", false) == 0)
				{
					text = "UNITNAME";
				}
				if (Operators.CompareString(text, "UNITNAMEORID", false) == 0)
				{
					text = "UNITNAME";
				}
				dictionary_0[text] = RuntimeHelpers.GetObjectValue(dictionaryEnumerator.Value);
			}
			return true;
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x00264268 File Offset: 0x00262468
		public static bool smethod_6(ref Dictionary<string, object> dictionary_0)
		{
			IDictionaryEnumerator dictionaryEnumerator = (IDictionaryEnumerator)new Dictionary<string, object>(dictionary_0).GetEnumerator();
			while (dictionaryEnumerator.MoveNext())
			{
				string text = Conversions.ToString(dictionaryEnumerator.Key).ToUpper();
				RuntimeHelpers.GetObjectValue(dictionaryEnumerator.Value);
				if (Operators.CompareString(text, "NAME", false) == 0)
				{
					text = "SIDE";
				}
				dictionary_0[text] = RuntimeHelpers.GetObjectValue(dictionaryEnumerator.Value);
			}
			return true;
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x00010B08 File Offset: 0x0000ED08
		public static double smethod_7(double double_0, double double_1, double double_2)
		{
			return double_0 + double_1 / 60.0 + double_2 / 3600.0;
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x002642DC File Offset: 0x002624DC
		public static double smethod_8(string string_0)
		{
			double result;
			try
			{
				string left = string_0.Substring(0, 1).ToUpper();
				if (Operators.CompareString(left, "S", false) == 0 || Operators.CompareString(left, "N", false) == 0)
				{
					string_0 = string_0.Substring(1, string_0.Length - 1);
				}
				List<string> list = Enumerable.ToList<string>(Enumerable.Select<string, string>(string_0.Split(new char[]
				{
					'.'
				}), (LuaUtility._Closure$__.$I8-0 == null) ? (LuaUtility._Closure$__.$I8-0 = new Func<string, string>(LuaUtility._Closure$__.$I.method_2)) : LuaUtility._Closure$__.$I8-0));
				double num;
				switch (list.Count)
				{
				case 1:
					num = (double)Conversions.ToInteger(string_0);
					break;
				case 2:
					num = XmlConvert.ToDouble(string_0);
					break;
				case 3:
				{
					double num2 = XmlConvert.ToDouble(list[0]);
					double num3 = XmlConvert.ToDouble(list[1]);
					double num4 = XmlConvert.ToDouble(list[2]);
					if (num2 < 0.0 | num3 < 0.0 | num4 < 0.0)
					{
						throw new Exception3("Latitude '" + string_0 + "' is hard to understand (negative numbers!). An example of a good latitude string is 'N 60.20.10'.");
					}
					if (num3 >= 60.0 | num4 >= 60.0)
					{
						throw new Exception3("Latitude '" + string_0 + "' is hard to understand (Minutes or Seconds greater or equal to 60).  An example of a good latitude string is 'N 60.20.10'.");
					}
					num = LuaUtility.smethod_7(num2, num3, num4);
					break;
				}
				default:
					throw new Exception3("Latitude '" + string_0 + "' is hard to understand (Too many numbers given). An example of a good latitude string is 'N 60.20.10'.");
				}
				if (Operators.CompareString(left, "S", false) == 0)
				{
					num = -num;
				}
				result = num;
			}
			catch (Exception ex)
			{
				throw new Exception3("Latitude '" + string_0 + "' is hard to understand. An example of a good latitude string is 'N 60.20.10'.");
			}
			return result;
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x002644AC File Offset: 0x002626AC
		public static double smethod_9(string string_0)
		{
			double result;
			try
			{
				string left = string_0.Substring(0, 1).ToUpper();
				if (Operators.CompareString(left, "E", false) == 0 || Operators.CompareString(left, "W", false) == 0)
				{
					string_0 = string_0.Substring(1, string_0.Length - 1);
				}
				List<string> list = Enumerable.ToList<string>(Enumerable.Select<string, string>(string_0.Split(new char[]
				{
					'.'
				}), (LuaUtility._Closure$__.$I9-0 == null) ? (LuaUtility._Closure$__.$I9-0 = new Func<string, string>(LuaUtility._Closure$__.$I.method_3)) : LuaUtility._Closure$__.$I9-0));
				double num;
				switch (list.Count)
				{
				case 1:
					num = (double)Conversions.ToInteger(string_0);
					break;
				case 2:
					num = XmlConvert.ToDouble(string_0);
					break;
				case 3:
				{
					double num2 = XmlConvert.ToDouble(list[0]);
					double num3 = XmlConvert.ToDouble(list[1]);
					double num4 = XmlConvert.ToDouble(list[2]);
					if (num2 < 0.0 | num3 < 0.0 | num4 < 0.0)
					{
						throw new Exception3("Longitude '" + string_0 + "' is hard to understand (negative numbers!). An example of a good longitude string is 'E 60.20.10'.");
					}
					if (num3 >= 60.0 | num4 >= 60.0)
					{
						throw new Exception3("Longitude '" + string_0 + "' is hard to understand (Minutes or Seconds greater or equal to 60). An example of a good longitude string is 'E 60.20.10'.");
					}
					num = LuaUtility.smethod_7(num2, num3, num4);
					break;
				}
				default:
					throw new Exception3("Longitude '" + string_0 + "' is hard to understand (Too many numbers given). An example of a good longitude string is 'E 60.20.10'.");
				}
				if (Operators.CompareString(left, "W", false) == 0)
				{
					num = -num;
				}
				result = num;
			}
			catch (Exception ex)
			{
				throw new Exception3("Longitude '" + string_0 + "' is hard to understand. An example of a good longitude string is 'E 60.20.10'.");
			}
			return result;
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x0026467C File Offset: 0x0026287C
		public static bool? smethod_10(object object_0)
		{
			bool? result;
			if (object_0 == null)
			{
				result = null;
			}
			else
			{
				try
				{
					if (object_0 is string)
					{
						if (Operators.CompareString(Conversions.ToString(object_0).ToLower(), "inherit", false) == 0)
						{
							result = null;
						}
						else
						{
							result = new bool?(bool.Parse(Conversions.ToString(object_0).ToLower().Replace("yes", "true").Replace("no", "false").Replace("true", "true").Replace("false", "false")));
						}
					}
					else if (object_0 is int)
					{
						result = new bool?(Conversions.ToInteger(object_0) != 0);
					}
					else if (object_0 is bool)
					{
						result = (bool?)object_0;
					}
					else
					{
						if (!(object_0 is double))
						{
							throw new Exception3("Lua can't understand '" + object_0.ToString() + "' as a true/false value. Please use 1 or 0.");
						}
						result = new bool?(Conversions.ToDouble(object_0) != 0.0);
					}
				}
				catch (Exception ex)
				{
					throw new Exception3("Lua can't understand '" + object_0.ToString() + "' as a true/false value. Please use 1 or 0.");
				}
			}
			return result;
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x002647BC File Offset: 0x002629BC
		public static double? smethod_11(Dictionary<string, object> dictionary_0)
		{
			object obj = null;
			if (dictionary_0.ContainsKey("LATITUDE"))
			{
				obj = RuntimeHelpers.GetObjectValue(dictionary_0["LATITUDE"]);
			}
			return LuaUtility.smethod_12(RuntimeHelpers.GetObjectValue(obj));
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x002647F4 File Offset: 0x002629F4
		public static double? smethod_12(object object_0)
		{
			double? result;
			if (object_0 == null)
			{
				result = null;
			}
			else
			{
				double value;
				if (object_0 is string)
				{
					value = LuaUtility.smethod_8(Conversions.ToString(object_0));
				}
				else if (object_0 is double)
				{
					value = Conversions.ToDouble(object_0);
				}
				else if (object_0 is int)
				{
					value = Conversions.ToDouble(object_0);
				}
				result = new double?(value);
			}
			return result;
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x00264850 File Offset: 0x00262A50
		public static double? smethod_13(Dictionary<string, object> dictionary_0)
		{
			object obj = null;
			if (dictionary_0.ContainsKey("LONGITUDE"))
			{
				obj = RuntimeHelpers.GetObjectValue(dictionary_0["LONGITUDE"]);
			}
			return LuaUtility.smethod_14(RuntimeHelpers.GetObjectValue(obj));
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x00264888 File Offset: 0x00262A88
		public static double? smethod_14(object object_0)
		{
			double? result;
			if (object_0 == null)
			{
				result = null;
			}
			else
			{
				double value;
				if (object_0 is string)
				{
					value = LuaUtility.smethod_9(Conversions.ToString(object_0));
				}
				else if (object_0 is double)
				{
					value = Conversions.ToDouble(object_0);
				}
				else if (object_0 is int)
				{
					value = Conversions.ToDouble(object_0);
				}
				result = new double?(value);
			}
			return result;
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x002648E4 File Offset: 0x00262AE4
		public static Side smethod_15(object object_0, Scenario scenario_0)
		{
			Side result;
			if (object_0 is string)
			{
				LuaUtility.Class509 @class = new LuaUtility.Class509();
				@class.string_0 = Conversions.ToString(object_0);
				if (Operators.CompareString(@class.string_0.ToUpper(), "PlayerSide".ToUpper(), false) == 0)
				{
					result = scenario_0.method_54();
				}
				else
				{
					result = Enumerable.First<Side>(scenario_0.method_44(), new Func<Side, bool>(@class.method_0));
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x00264950 File Offset: 0x00262B50
		public static Side smethod_16(Dictionary<string, object> dictionary_0, Scenario scenario_0)
		{
			Side result;
			if (dictionary_0.ContainsKey("SIDE"))
			{
				result = LuaUtility.smethod_15(RuntimeHelpers.GetObjectValue(dictionary_0["SIDE"]), scenario_0);
			}
			else
			{
				if (!dictionary_0.ContainsKey("SIDENAME"))
				{
					throw new Exception3("Missing 'Side' please choose one of PlayerSide, " + string.Join(", ", Enumerable.Select<Side, string>(scenario_0.method_44(), (LuaUtility._Closure$__.$I16-0 == null) ? (LuaUtility._Closure$__.$I16-0 = new Func<Side, string>(LuaUtility._Closure$__.$I.method_4)) : LuaUtility._Closure$__.$I16-0)));
				}
				result = LuaUtility.smethod_15(RuntimeHelpers.GetObjectValue(dictionary_0["SIDENAME"]), scenario_0);
			}
			return result;
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x002649F4 File Offset: 0x00262BF4
		public static Side smethod_17(Dictionary<string, object> dictionary_0, Scenario scenario_0)
		{
			Side side = LuaUtility.smethod_16(dictionary_0, scenario_0);
			if (side == null)
			{
				throw new Exception3("Side '" + Conversions.ToString(dictionary_0["SIDE"]) + "' doesn't exist please choose one of PlayerSide, " + string.Join(", ", Enumerable.Select<Side, string>(scenario_0.method_44(), (LuaUtility._Closure$__.$I17-0 == null) ? (LuaUtility._Closure$__.$I17-0 = new Func<Side, string>(LuaUtility._Closure$__.$I.method_5)) : LuaUtility._Closure$__.$I17-0)));
			}
			return side;
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x00264A6C File Offset: 0x00262C6C
		public static ActiveUnit_AI.AircraftAltitudePreset? smethod_18(object object_0)
		{
			ActiveUnit_AI.AircraftAltitudePreset? result;
			if (object_0 is string)
			{
				string text = Conversions.ToString(object_0).ToUpper();
				text.Replace("-", "");
				uint num = Class582.smethod_0(text);
				ActiveUnit_AI.AircraftAltitudePreset value;
				if (num <= 1519633240U)
				{
					if (num <= 475632249U)
					{
						if (num != 184116300U)
						{
							if (num != 239465655U)
							{
								if (num != 475632249U)
								{
									goto IL_22C;
								}
								if (Operators.CompareString(text, "MAX", false) != 0)
								{
									goto IL_22C;
								}
								goto IL_21A;
							}
							else
							{
								if (Operators.CompareString(text, "MIN", false) != 0)
								{
									goto IL_22C;
								}
								goto IL_17D;
							}
						}
						else if (Operators.CompareString(text, "HIGH36000", false) != 0)
						{
							goto IL_22C;
						}
					}
					else if (num <= 1214435865U)
					{
						if (num != 1058632727U)
						{
							if (num != 1214435865U)
							{
								goto IL_22C;
							}
							if (Operators.CompareString(text, "MED", false) != 0)
							{
								goto IL_22C;
							}
							goto IL_1F6;
						}
						else
						{
							if (Operators.CompareString(text, "MEDIUM12000", false) != 0)
							{
								goto IL_22C;
							}
							goto IL_1F6;
						}
					}
					else if (num != 1492057481U)
					{
						if (num != 1519633240U)
						{
							goto IL_22C;
						}
						if (Operators.CompareString(text, "HIGH25000", false) == 0)
						{
							value = ActiveUnit_AI.AircraftAltitudePreset.High25000;
							goto IL_238;
						}
						goto IL_22C;
					}
					else
					{
						if (Operators.CompareString(text, "MINALTITUDE", false) != 0)
						{
							goto IL_22C;
						}
						goto IL_17D;
					}
				}
				else
				{
					if (num > 2455723304U)
					{
						if (num <= 3180161568U)
						{
							if (num != 2968090778U)
							{
								if (num != 3180161568U)
								{
									goto IL_22C;
								}
								if (Operators.CompareString(text, "LOW1000", false) != 0)
								{
									goto IL_22C;
								}
							}
							else
							{
								if (Operators.CompareString(text, "MED12000", false) == 0)
								{
									goto IL_1F6;
								}
								goto IL_22C;
							}
						}
						else if (num != 3526092385U)
						{
							if (num != 3973006395U)
							{
								goto IL_22C;
							}
							if (Operators.CompareString(text, "MAXALTITUDE", false) == 0)
							{
								goto IL_21A;
							}
							goto IL_22C;
						}
						else if (Operators.CompareString(text, "LOW", false) != 0)
						{
							goto IL_22C;
						}
						value = ActiveUnit_AI.AircraftAltitudePreset.Low1000;
						goto IL_238;
					}
					if (num <= 2066738941U)
					{
						if (num != 1565158650U)
						{
							if (num != 2066738941U)
							{
								goto IL_22C;
							}
							if (Operators.CompareString(text, "HIGH", false) != 0)
							{
								goto IL_22C;
							}
						}
						else
						{
							if (Operators.CompareString(text, "MINALT", false) == 0)
							{
								goto IL_17D;
							}
							goto IL_22C;
						}
					}
					else if (num != 2325274323U)
					{
						if (num != 2455723304U)
						{
							goto IL_22C;
						}
						if (Operators.CompareString(text, "MAXALT", false) != 0)
						{
							goto IL_22C;
						}
						goto IL_21A;
					}
					else
					{
						if (Operators.CompareString(text, "LOW2000", false) == 0)
						{
							value = ActiveUnit_AI.AircraftAltitudePreset.Low2000;
							goto IL_238;
						}
						goto IL_22C;
					}
				}
				value = ActiveUnit_AI.AircraftAltitudePreset.High36000;
				goto IL_238;
				IL_17D:
				value = ActiveUnit_AI.AircraftAltitudePreset.MinAltitude;
				goto IL_238;
				IL_1F6:
				value = ActiveUnit_AI.AircraftAltitudePreset.Medium12000;
				goto IL_238;
				IL_21A:
				value = ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude;
				goto IL_238;
				IL_22C:
				return null;
				IL_238:
				result = new ActiveUnit_AI.AircraftAltitudePreset?(value);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x00264CC4 File Offset: 0x00262EC4
		public static float? smethod_19(object object_0)
		{
			float value;
			float? result;
			if (object_0 is string)
			{
				string text = Conversions.ToString(object_0).ToUpper();
				text.Replace("-", "");
				int num;
				if (!int.TryParse(text, out num))
				{
					ActiveUnit_AI.AircraftAltitudePreset aircraftAltitudePreset = ActiveUnit_AI.AircraftAltitudePreset.None;
					uint num2 = Class582.smethod_0(text);
					if (num2 <= 1519633240U)
					{
						if (num2 <= 475632249U)
						{
							if (num2 != 184116300U)
							{
								if (num2 != 239465655U)
								{
									if (num2 != 475632249U)
									{
										goto IL_26B;
									}
									if (Operators.CompareString(text, "MAX", false) != 0)
									{
										goto IL_26B;
									}
									goto IL_252;
								}
								else
								{
									if (Operators.CompareString(text, "MIN", false) != 0)
									{
										goto IL_26B;
									}
									goto IL_19C;
								}
							}
							else if (Operators.CompareString(text, "HIGH36000", false) != 0)
							{
								goto IL_26B;
							}
						}
						else if (num2 <= 1214435865U)
						{
							if (num2 != 1058632727U)
							{
								if (num2 != 1214435865U)
								{
									goto IL_26B;
								}
								if (Operators.CompareString(text, "MED", false) != 0)
								{
									goto IL_26B;
								}
								goto IL_228;
							}
							else
							{
								if (Operators.CompareString(text, "MEDIUM12000", false) != 0)
								{
									goto IL_26B;
								}
								goto IL_228;
							}
						}
						else if (num2 != 1492057481U)
						{
							if (num2 != 1519633240U)
							{
								goto IL_26B;
							}
							if (Operators.CompareString(text, "HIGH25000", false) == 0)
							{
								aircraftAltitudePreset = ActiveUnit_AI.AircraftAltitudePreset.High25000;
								goto IL_2FC;
							}
							goto IL_26B;
						}
						else
						{
							if (Operators.CompareString(text, "MINALTITUDE", false) != 0)
							{
								goto IL_26B;
							}
							goto IL_19C;
						}
					}
					else
					{
						if (num2 > 2455723304U)
						{
							if (num2 <= 3180161568U)
							{
								if (num2 != 2968090778U)
								{
									if (num2 != 3180161568U)
									{
										goto IL_26B;
									}
									if (Operators.CompareString(text, "LOW1000", false) != 0)
									{
										goto IL_26B;
									}
								}
								else
								{
									if (Operators.CompareString(text, "MED12000", false) == 0)
									{
										goto IL_228;
									}
									goto IL_26B;
								}
							}
							else if (num2 != 3526092385U)
							{
								if (num2 != 3973006395U)
								{
									goto IL_26B;
								}
								if (Operators.CompareString(text, "MAXALTITUDE", false) == 0)
								{
									goto IL_252;
								}
								goto IL_26B;
							}
							else if (Operators.CompareString(text, "LOW", false) != 0)
							{
								goto IL_26B;
							}
							aircraftAltitudePreset = ActiveUnit_AI.AircraftAltitudePreset.Low1000;
							goto IL_2FC;
						}
						if (num2 <= 2066738941U)
						{
							if (num2 != 1565158650U)
							{
								if (num2 != 2066738941U)
								{
									goto IL_26B;
								}
								if (Operators.CompareString(text, "HIGH", false) != 0)
								{
									goto IL_26B;
								}
							}
							else
							{
								if (Operators.CompareString(text, "MINALT", false) == 0)
								{
									goto IL_19C;
								}
								goto IL_26B;
							}
						}
						else if (num2 != 2325274323U)
						{
							if (num2 != 2455723304U)
							{
								goto IL_26B;
							}
							if (Operators.CompareString(text, "MAXALT", false) != 0)
							{
								goto IL_26B;
							}
							goto IL_252;
						}
						else
						{
							if (Operators.CompareString(text, "LOW2000", false) == 0)
							{
								aircraftAltitudePreset = ActiveUnit_AI.AircraftAltitudePreset.Low2000;
								goto IL_2FC;
							}
							goto IL_26B;
						}
					}
					aircraftAltitudePreset = ActiveUnit_AI.AircraftAltitudePreset.High36000;
					goto IL_2FC;
					IL_19C:
					aircraftAltitudePreset = ActiveUnit_AI.AircraftAltitudePreset.MinAltitude;
					goto IL_2FC;
					IL_228:
					aircraftAltitudePreset = ActiveUnit_AI.AircraftAltitudePreset.Medium12000;
					goto IL_2FC;
					IL_252:
					aircraftAltitudePreset = ActiveUnit_AI.AircraftAltitudePreset.MaxAltitude;
					goto IL_2FC;
					IL_26B:
					if (text.Contains("FT"))
					{
						value = float.Parse(text.Replace("FT", "").Replace("M", "").Trim()) * 0.3048f;
						result = new float?(value);
						return result;
					}
					if (text.Contains("M"))
					{
						value = float.Parse(text.Replace("FT", "").Replace("M", "").Trim());
						result = new float?(value);
						return result;
					}
					IL_2FC:
					value = (float)aircraftAltitudePreset;
				}
				else if (text.Contains("FT"))
				{
					value = float.Parse(text.Replace("FT", "").Replace("M", "").Trim()) * 0.3048f;
				}
				else
				{
					value = float.Parse(text.Replace("FT", "").Replace("M", "").Trim());
				}
			}
			else if (object_0 is double)
			{
				value = Conversions.ToSingle(object_0);
			}
			else if (object_0 is float)
			{
				value = Conversions.ToSingle(object_0);
			}
			else if (object_0 is int)
			{
				value = Conversions.ToSingle(object_0);
			}
			result = new float?(value);
			return result;
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x0026507C File Offset: 0x0026327C
		public static float? smethod_20(Dictionary<string, object> dictionary_0)
		{
			object obj = null;
			if (dictionary_0.ContainsKey("ALTITUDE"))
			{
				obj = RuntimeHelpers.GetObjectValue(dictionary_0["ALTITUDE"]);
			}
			float? result;
			if (obj == null)
			{
				result = null;
			}
			else
			{
				result = LuaUtility.smethod_19(RuntimeHelpers.GetObjectValue(obj));
			}
			return result;
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x002650C4 File Offset: 0x002632C4
		public static ActiveUnit_AI.SubmarineDepthPreset? smethod_21(object object_0)
		{
			ActiveUnit_AI.SubmarineDepthPreset? result;
			if (object_0 is string)
			{
				string text = Conversions.ToString(object_0).ToUpper();
				text.Replace("-", "");
				uint num = Class582.smethod_0(text);
				ActiveUnit_AI.SubmarineDepthPreset value;
				if (num > 803702287U)
				{
					if (num <= 1934953630U)
					{
						if (num != 830659629U)
						{
							if (num != 1934953630U)
							{
								goto IL_14C;
							}
							if (Operators.CompareString(text, "MAXDEPTH", false) == 0)
							{
								goto IL_EC;
							}
							goto IL_14C;
						}
						else if (Operators.CompareString(text, "UNDER", false) != 0)
						{
							goto IL_14C;
						}
					}
					else if (num != 2807108366U)
					{
						if (num != 3361670307U)
						{
							if (num != 3477228288U)
							{
								goto IL_14C;
							}
							if (Operators.CompareString(text, "OVERLAYER", false) == 0)
							{
								goto IL_128;
							}
							goto IL_14C;
						}
						else
						{
							if (Operators.CompareString(text, "SHALLOW", false) == 0)
							{
								value = ActiveUnit_AI.SubmarineDepthPreset.Shallow;
								goto IL_158;
							}
							goto IL_14C;
						}
					}
					else if (Operators.CompareString(text, "UNDERLAYER", false) != 0)
					{
						goto IL_14C;
					}
					value = ActiveUnit_AI.SubmarineDepthPreset.UnderLayer;
					goto IL_158;
				}
				if (num <= 339144757U)
				{
					if (num != 333138908U)
					{
						if (num != 339144757U)
						{
							goto IL_14C;
						}
						if (Operators.CompareString(text, "PERISCOPE", false) == 0)
						{
							value = ActiveUnit_AI.SubmarineDepthPreset.Periscope;
							goto IL_158;
						}
						goto IL_14C;
					}
					else
					{
						if (Operators.CompareString(text, "SURFACE", false) == 0)
						{
							value = ActiveUnit_AI.SubmarineDepthPreset.Surface;
							goto IL_158;
						}
						goto IL_14C;
					}
				}
				else if (num != 475632249U)
				{
					if (num != 803702287U)
					{
						goto IL_14C;
					}
					if (Operators.CompareString(text, "OVER", false) != 0)
					{
						goto IL_14C;
					}
					goto IL_128;
				}
				else if (Operators.CompareString(text, "MAX", false) != 0)
				{
					goto IL_14C;
				}
				IL_EC:
				value = ActiveUnit_AI.SubmarineDepthPreset.MaxDepth;
				goto IL_158;
				IL_128:
				value = ActiveUnit_AI.SubmarineDepthPreset.OverLayer;
				goto IL_158;
				IL_14C:
				return null;
				IL_158:
				result = new ActiveUnit_AI.SubmarineDepthPreset?(value);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x0026523C File Offset: 0x0026343C
		public static float? smethod_22(object object_0)
		{
			float value = 0f;
			float? result;
			if (object_0 is string)
			{
				string text = Conversions.ToString(object_0).ToUpper();
				text.Replace("-", "");
				int num;
				if (!int.TryParse(text, out num))
				{
					ActiveUnit_AI.SubmarineDepthPreset submarineDepthPreset = ActiveUnit_AI.SubmarineDepthPreset.None;
					uint num2 = Class582.smethod_0(text);
					if (num2 > 803702287U)
					{
						if (num2 <= 1934953630U)
						{
							if (num2 != 830659629U)
							{
								if (num2 != 1934953630U)
								{
									goto IL_187;
								}
								if (Operators.CompareString(text, "MAXDEPTH", false) == 0)
								{
									goto IL_112;
								}
								goto IL_187;
							}
							else if (Operators.CompareString(text, "UNDER", false) != 0)
							{
								goto IL_187;
							}
						}
						else if (num2 != 2807108366U)
						{
							if (num2 != 3361670307U)
							{
								if (num2 != 3477228288U)
								{
									goto IL_187;
								}
								if (Operators.CompareString(text, "OVERLAYER", false) == 0)
								{
									goto IL_158;
								}
								goto IL_187;
							}
							else
							{
								if (Operators.CompareString(text, "SHALLOW", false) == 0)
								{
									submarineDepthPreset = ActiveUnit_AI.SubmarineDepthPreset.Shallow;
									goto IL_22E;
								}
								goto IL_187;
							}
						}
						else if (Operators.CompareString(text, "UNDERLAYER", false) != 0)
						{
							goto IL_187;
						}
						submarineDepthPreset = ActiveUnit_AI.SubmarineDepthPreset.UnderLayer;
						goto IL_22E;
					}
					if (num2 <= 339144757U)
					{
						if (num2 != 333138908U)
						{
							if (num2 != 339144757U)
							{
								goto IL_187;
							}
							if (Operators.CompareString(text, "PERISCOPE", false) == 0)
							{
								submarineDepthPreset = ActiveUnit_AI.SubmarineDepthPreset.Periscope;
								goto IL_22E;
							}
							goto IL_187;
						}
						else
						{
							if (Operators.CompareString(text, "SURFACE", false) == 0)
							{
								submarineDepthPreset = ActiveUnit_AI.SubmarineDepthPreset.Surface;
								goto IL_22E;
							}
							goto IL_187;
						}
					}
					else if (num2 != 475632249U)
					{
						if (num2 != 803702287U)
						{
							goto IL_187;
						}
						if (Operators.CompareString(text, "OVER", false) != 0)
						{
							goto IL_187;
						}
						goto IL_158;
					}
					else if (Operators.CompareString(text, "MAX", false) != 0)
					{
						goto IL_187;
					}
					IL_112:
					submarineDepthPreset = ActiveUnit_AI.SubmarineDepthPreset.MaxDepth;
					goto IL_22E;
					IL_158:
					submarineDepthPreset = ActiveUnit_AI.SubmarineDepthPreset.OverLayer;
					goto IL_22E;
					IL_187:
					if (text.Contains("FT"))
					{
						value = float.Parse(text.Replace("FT", "").Replace("M", "").Trim()) * 0.3048f;
						result = new float?(Math.Abs(value) * -1f);
						return result;
					}
					if (text.Contains("M"))
					{
						value = float.Parse(text.Replace("FT", "").Replace("M", "").Trim());
						result = new float?(Math.Abs(value) * -1f);
						return result;
					}
					IL_22E:
					value = (float)submarineDepthPreset;
				}
				else
				{
					if (text.Contains("FT"))
					{
						value = float.Parse(text.Replace("FT", "").Replace("M", "").Trim()) * 0.3048f;
					}
					else
					{
						value = float.Parse(text.Replace("FT", "").Replace("M", "").Trim());
					}
					value = Math.Abs(value) * -1f;
				}
			}
			else if (object_0 is double)
			{
				value = Math.Abs(Conversions.ToSingle(object_0)) * -1f;
			}
			else if (object_0 is float)
			{
				value = Math.Abs(Conversions.ToSingle(object_0)) * -1f;
			}
			else if (object_0 is int)
			{
				value = Math.Abs(Conversions.ToSingle(object_0)) * -1f;
			}
			result = new float?(value);
			return result;
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00265554 File Offset: 0x00263754
		public static float? smethod_23(Dictionary<string, object> dictionary_0)
		{
			object obj = null;
			if (dictionary_0.ContainsKey("DEPTH"))
			{
				obj = RuntimeHelpers.GetObjectValue(dictionary_0["DEPTH"]);
			}
			float? result;
			if (obj == null)
			{
				result = null;
			}
			else
			{
				result = LuaUtility.smethod_22(RuntimeHelpers.GetObjectValue(obj));
			}
			return result;
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x0026559C File Offset: 0x0026379C
		public static ActiveUnit.Throttle smethod_24(Dictionary<string, object> dictionary_0)
		{
			ActiveUnit.Throttle result;
			if (dictionary_0.ContainsKey("THROTTLE"))
			{
				string string_ = Conversions.ToString(dictionary_0["THROTTLE"]);
				result = LuaUtility.smethod_25(string_);
			}
			else
			{
				result = ActiveUnit.Throttle.FullStop;
			}
			return result;
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x002655D8 File Offset: 0x002637D8
		public static ActiveUnit.Throttle smethod_25(string string_0)
		{
			string text = string_0.ToLower();
			uint num = Class582.smethod_0(text);
			if (num <= 1892592429U)
			{
				if (num <= 890022063U)
				{
					if (num != 822911587U)
					{
						if (num != 873244444U)
						{
							if (num != 890022063U)
							{
								goto IL_1B4;
							}
							if (Operators.CompareString(text, "0", false) != 0)
							{
								goto IL_1B4;
							}
							goto IL_17E;
						}
						else
						{
							if (Operators.CompareString(text, "1", false) != 0)
							{
								goto IL_1B4;
							}
							goto IL_1C5;
						}
					}
					else if (Operators.CompareString(text, "4", false) != 0)
					{
						goto IL_1B4;
					}
				}
				else if (num != 906799682U)
				{
					if (num != 923577301U)
					{
						if (num != 1892592429U)
						{
							goto IL_1B4;
						}
						if (Operators.CompareString(text, "hover", false) != 0)
						{
							goto IL_1B4;
						}
						goto IL_17E;
					}
					else
					{
						if (Operators.CompareString(text, "2", false) != 0)
						{
							goto IL_1B4;
						}
						goto IL_16C;
					}
				}
				else
				{
					if (Operators.CompareString(text, "3", false) != 0)
					{
						goto IL_1B4;
					}
					goto IL_1A2;
				}
			}
			else if (num <= 2984601802U)
			{
				if (num != 2345205396U)
				{
					if (num != 2488379205U)
					{
						if (num != 2984601802U)
						{
							goto IL_1B4;
						}
						if (Operators.CompareString(text, "loiter", false) != 0)
						{
							goto IL_1B4;
						}
						goto IL_1C5;
					}
					else if (Operators.CompareString(text, "flank", false) != 0)
					{
						goto IL_1B4;
					}
				}
				else
				{
					if (Operators.CompareString(text, "fullstop", false) != 0)
					{
						goto IL_1B4;
					}
					goto IL_17E;
				}
			}
			else if (num <= 3851873890U)
			{
				if (num != 3411225317U)
				{
					if (num != 3851873890U)
					{
						goto IL_1B4;
					}
					if (Operators.CompareString(text, "cruise", false) == 0)
					{
						goto IL_16C;
					}
					goto IL_1B4;
				}
				else
				{
					if (Operators.CompareString(text, "stop", false) == 0)
					{
						goto IL_17E;
					}
					goto IL_1B4;
				}
			}
			else if (num != 4039985178U)
			{
				if (num != 4286165820U)
				{
					goto IL_1B4;
				}
				if (Operators.CompareString(text, "full", false) == 0)
				{
					goto IL_1A2;
				}
				goto IL_1B4;
			}
			else
			{
				if (Operators.CompareString(text, "creep", false) != 0)
				{
					goto IL_1B4;
				}
				goto IL_1C5;
			}
			return ActiveUnit.Throttle.Flank;
			IL_16C:
			return ActiveUnit.Throttle.Cruise;
			IL_17E:
			return ActiveUnit.Throttle.FullStop;
			IL_1A2:
			return ActiveUnit.Throttle.Full;
			IL_1B4:
			throw new Exception3("Invalid throttle " + string_0);
			IL_1C5:
			return ActiveUnit.Throttle.Loiter;
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x002657B0 File Offset: 0x002639B0
		public static Group smethod_26(object object_0, Side side_0, Scenario scenario_0)
		{
			if (object_0 is string)
			{
				LuaUtility.Class510 @class = new LuaUtility.Class510();
				@class.string_0 = Conversions.ToString(object_0);
				Group result;
				if (scenario_0.vmethod_0().ContainsKey(@class.string_0))
				{
					ActiveUnit activeUnit = scenario_0.vmethod_0()[@class.string_0];
					if (!(activeUnit is Group))
					{
						throw new Exception3(string.Concat(new string[]
						{
							"Unable to understand '",
							object_0.ToString(),
							"' as a group. This is the guid for '",
							activeUnit.Name,
							"' which isn't a Group."
						}));
					}
					result = (Group)activeUnit;
				}
				else
				{
					result = (Group)Enumerable.FirstOrDefault<ActiveUnit>(side_0.activeUnit_0, new Func<ActiveUnit, bool>(@class.method_0));
				}
				return result;
			}
			throw new Exception3("Unable to understand '" + object_0.ToString() + "' as a group.");
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x00265888 File Offset: 0x00263A88
		public static Group smethod_27(Dictionary<string, object> dictionary_0, Side side_0, Scenario scenario_0)
		{
			object obj = null;
			if (dictionary_0.ContainsKey("GROUP"))
			{
				obj = RuntimeHelpers.GetObjectValue(dictionary_0["GROUP"]);
			}
			Group result;
			if (obj == null)
			{
				result = null;
			}
			else
			{
				result = LuaUtility.smethod_26(RuntimeHelpers.GetObjectValue(obj), side_0, scenario_0);
			}
			return result;
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x002658CC File Offset: 0x00263ACC
		public static string smethod_28(Dictionary<string, object> dictionary_0, Scenario scenario_0)
		{
			ActiveUnit activeUnit = null;
			Side side = null;
			LuaUtility.smethod_5(ref dictionary_0);
			if (dictionary_0.ContainsKey("GUID"))
			{
				string text;
				try
				{
					text = Conversions.ToString(dictionary_0["GUID"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("Guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.vmethod_0()[text];
				}
				catch (Exception ex2)
				{
					return "Can't find guid " + text;
				}
				if (activeUnit == null)
				{
					dictionary_0.Remove("GUID");
				}
			}
			else if (dictionary_0.ContainsKey("UNITNAME"))
			{
				LuaUtility.Class511 @class = new LuaUtility.Class511();
				try
				{
					@class.string_0 = Conversions.ToString(dictionary_0["UNITNAME"]);
				}
				catch (Exception ex3)
				{
					throw new Exception3("Name must be a string");
				}
				if (dictionary_0.ContainsKey("SIDE"))
				{
					string text2;
					try
					{
						text2 = Conversions.ToString(dictionary_0["SIDE"]);
					}
					catch (Exception ex4)
					{
						throw new Exception3("Side must be a string");
					}
					try
					{
						side = LuaUtility.smethod_16(dictionary_0, scenario_0);
					}
					catch (Exception ex5)
					{
						return "Can't find Side '" + text2 + "'";
					}
					try
					{
						activeUnit = Enumerable.First<ActiveUnit>(side.activeUnit_0, new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception ex6)
					{
						return string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text2,
							"'"
						});
					}
					dictionary_0["GUID"] = activeUnit.string_0;
				}
				else
				{
					try
					{
						activeUnit = Enumerable.First<ActiveUnit>(scenario_0.method_42(), new Func<ActiveUnit, bool>(@class.method_1));
					}
					catch (Exception ex7)
					{
						return "Can't find Unit '" + @class.string_0 + "'";
					}
					dictionary_0["GUID"] = activeUnit.string_0;
					dictionary_0["SIDE"] = activeUnit.vmethod_7(false).method_51();
				}
			}
			return "";
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x00265B3C File Offset: 0x00263D3C
		public static bool smethod_29(Dictionary<string, object> dictionary_0, Scenario scenario_0)
		{
			ActiveUnit activeUnit = null;
			Side side = null;
			if (dictionary_0.ContainsKey("BASE"))
			{
				LuaUtility.Class512 @class = new LuaUtility.Class512();
				side = LuaUtility.smethod_17(dictionary_0, scenario_0);
				@class.string_0 = "";
				try
				{
					@class.string_0 = Conversions.ToString(dictionary_0["BASE"]);
				}
				catch (Exception ex)
				{
					throw new Exception3("Base must be a string");
				}
				try
				{
					activeUnit = scenario_0.vmethod_0()[@class.string_0];
				}
				catch (Exception ex2)
				{
					return false;
				}
				if (side != null && activeUnit != null && Operators.CompareString(activeUnit.vmethod_7(false).string_0, side.string_0.ToLower(), false) != 0)
				{
					activeUnit = null;
				}
				if (Information.IsNothing(activeUnit))
				{
					try
					{
						activeUnit = Enumerable.FirstOrDefault<ActiveUnit>(scenario_0.method_42(), new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception ex3)
					{
						return false;
					}
				}
				if (activeUnit == null)
				{
					dictionary_0.Remove("BASE");
					return false;
				}
				dictionary_0["BASE"] = activeUnit.string_0;
			}
			return true;
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x00265C70 File Offset: 0x00263E70
		public static ActiveUnit smethod_30(string NameOrId, Scenario ScenarioContext, ref Side Side = null)
		{
			LuaUtility.Class513 @class = new LuaUtility.Class513();
			@class.string_0 = NameOrId;
			ActiveUnit result = null;
			try
			{
				if (Side != null)
				{
					result = Enumerable.FirstOrDefault<ActiveUnit>(Side.activeUnit_0, new Func<ActiveUnit, bool>(@class.method_0));
				}
				else
				{
					result = Enumerable.FirstOrDefault<ActiveUnit>(ScenarioContext.method_42(), new Func<ActiveUnit, bool>(@class.method_1));
				}
			}
			catch (Exception ex)
			{
			}
			return result;
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x00265CE4 File Offset: 0x00263EE4
		public static Contact smethod_31(string NameOrId, Scenario ScenarioContext, ref Side Side = null)
		{
			Contact contact = null;
			bool flag = false;
			try
			{
				if (Side != null)
				{
					try
					{
						foreach (Contact contact2 in Side.method_44())
						{
							if (Operators.CompareString(contact2.string_0, NameOrId.ToLower(), false) == 0 || Operators.CompareString(contact2.Name.ToUpper(), NameOrId.ToUpper(), false) == 0)
							{
								contact = contact2;
								flag = true;
								break;
							}
						}
					}
					finally
					{
						List<Contact>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (!Information.IsNothing(contact))
					{
						goto IL_232;
					}
					try
					{
						foreach (string text in Side.lazy_0.Value.Keys)
						{
							Contact contact3 = Side.lazy_0.Value[text];
							if (Operators.CompareString(contact3.string_0.ToLower(), NameOrId.ToLower(), false) == 0 || Operators.CompareString(contact3.Name.ToLower(), NameOrId.ToLower(), false) == 0)
							{
								contact = contact3;
								flag = true;
								IL_F5:
								goto IL_232;
							}
						}
						goto IL_F5;
					}
					finally
					{
						IEnumerator<string> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
				}
				foreach (Side side in ScenarioContext.method_44())
				{
					if (flag)
					{
						break;
					}
					try
					{
						foreach (Contact contact4 in side.method_44())
						{
							if (Operators.CompareString(contact4.string_0, NameOrId.ToLower(), false) == 0 || Operators.CompareString(contact4.Name.ToUpper(), NameOrId.ToUpper(), false) == 0)
							{
								contact = contact4;
								flag = true;
								break;
							}
						}
					}
					finally
					{
						List<Contact>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					if (Information.IsNothing(contact))
					{
						try
						{
							foreach (string text2 in side.lazy_0.Value.Keys)
							{
								Contact contact5 = side.lazy_0.Value[text2];
								if (Operators.CompareString(contact5.string_0.ToLower(), NameOrId.ToLower(), false) == 0 || Operators.CompareString(contact5.Name.ToLower(), NameOrId.ToLower(), false) == 0)
								{
									contact = contact5;
									flag = true;
									break;
								}
							}
						}
						finally
						{
							IEnumerator<string> enumerator4;
							if (enumerator4 != null)
							{
								enumerator4.Dispose();
							}
						}
					}
				}
				IL_232:;
			}
			catch (Exception ex)
			{
			}
			return contact;
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x00265FB0 File Offset: 0x002641B0
		public static long smethod_32(string string_0)
		{
			double a = 0.0;
			string[] array = Strings.Split(string_0, ":", -1, CompareMethod.Binary);
			if (Enumerable.Count<string>(array) == 4)
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (array[i] == "")
					{
						array[i] = "0";
					}
				}
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), Conversions.ToInteger(array[3]));
				a = timeSpan.TotalSeconds;
			}
			return (long)Math.Round(a);
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x00266040 File Offset: 0x00264240
		public static string smethod_33(object object_0)
		{
			checked
			{
				string result;
				if (object_0 is object[])
				{
					string text = "";
					bool flag = true;
					object[] array = (object[])object_0;
					for (int i = 0; i < array.Length; i++)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(array[i]);
						if (!flag)
						{
							text += ",";
						}
						else
						{
							flag = false;
						}
						text += LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(objectValue));
					}
					result = text;
				}
				else if (object_0 is string)
				{
					result = Conversions.ToString(object_0);
				}
				else if (object_0 is double)
				{
					result = Conversions.ToString(object_0);
				}
				else if (object_0 is bool)
				{
					if (Conversions.ToBoolean(object_0))
					{
						result = "'Yes'";
					}
					else
					{
						result = "'No'";
					}
				}
				else if (object_0 is LuaTable)
				{
					IDictionaryEnumerator enumerator = ((LuaTable)object_0).GetEnumerator();
					string text2 = "{";
					bool flag2 = true;
					while (enumerator.MoveNext())
					{
						if (!flag2)
						{
							text2 += ",";
						}
						else
						{
							flag2 = false;
						}
						if (enumerator.Key is string)
						{
							text2 = text2 + " " + enumerator.Key.ToString() + " = ";
						}
						else
						{
							text2 = text2 + " [" + enumerator.Key.ToString() + "] = ";
						}
						if (enumerator.Value is string)
						{
							text2 = text2 + "'" + LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(enumerator.Value)) + "'";
						}
						else if (enumerator.Value is LuaFunction)
						{
							text2 += enumerator.Value.ToString();
						}
						else if (enumerator.Value is LuaTable)
						{
							if (((LuaTable)enumerator.Value).Keys.Count > 50)
							{
								text2 += enumerator.Value.ToString();
							}
							else
							{
								text2 += LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(enumerator.Value));
							}
						}
						else
						{
							text2 += LuaUtility.smethod_33(RuntimeHelpers.GetObjectValue(enumerator.Value));
						}
					}
					text2 += " }";
					result = text2;
				}
				else if (object_0 != null)
				{
					result = object_0.ToString();
				}
				else
				{
					result = "nil";
				}
				return result;
			}
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x0026628C File Offset: 0x0026448C
		public static void smethod_34(ref string InfoText, ref object debugTextObject, bool includeHeader = false)
		{
			try
			{
				if (!(!LuaSandBox._lua_console & !LuaSandBox._lua_event))
				{
					string text;
					if (debugTextObject.GetType() == typeof(string))
					{
						text = Conversions.ToString(debugTextObject);
					}
					else
					{
						Exception ex = (Exception)debugTextObject;
						StringBuilder stringBuilder = new StringBuilder();
						stringBuilder.Append("Exception: ").Append(ex.Message).Append("\r\n").Append("Stack Trace: ").Append(ex.StackTrace).Append("\r\n");
						if (!Information.IsNothing(ex.InnerException))
						{
							stringBuilder.Append("Inner Exception: ").Append(ex.InnerException.Message).Append("\r\n").Append("Inner StackTrace: ").Append(ex.InnerException.StackTrace).Append("\r\n");
						}
						if (ex.Data.Count > 0)
						{
							stringBuilder.Append("Call Stack & Error details: ");
							foreach (object obj in ex.Data)
							{
								DictionaryEntry dictionaryEntry = (obj != null) ? ((DictionaryEntry)obj) : default(DictionaryEntry);
								stringBuilder.Append("\r\n").Append(Conversions.ToString(dictionaryEntry.Key)).Append(", ").Append(Conversions.ToString(dictionaryEntry.Value));
							}
						}
						text = stringBuilder.ToString();
					}
					StringBuilder stringBuilder2 = new StringBuilder();
					if (includeHeader)
					{
						stringBuilder2.Append(DateAndTime.Now).Append(" -- B").Append("1115.6").Append(" -- ").Append("\r\n");
					}
					if (InfoText.Length > 0)
					{
						stringBuilder2.Append(InfoText).Append("\r\n");
					}
					if (text.Length > 0)
					{
						stringBuilder2.Append(text).Append("\r\n");
					}
					try
					{
						string str = string.Concat(new string[]
						{
							DateAndTime.Now.Year.ToString(),
							"-",
							Strings.Right("00" + DateAndTime.Now.Month.ToString(), 2),
							"-",
							Strings.Right("00" + DateAndTime.Now.Day.ToString(), 2)
						});
						StreamWriter streamWriter = File.AppendText(Class160.smethod_1().Info.DirectoryPath + "\\Logs\\LuaHistory_" + str + ".txt");
						streamWriter.Write(stringBuilder2.ToString());
						streamWriter.Close();
					}
					catch (Exception ex2)
					{
					}
				}
			}
			catch (Exception ex3)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0200045B RID: 1115
		[CompilerGenerated]
		internal sealed class Class509
		{
			// Token: 0x06002257 RID: 8791 RVA: 0x002665A4 File Offset: 0x002647A4
			internal bool method_0(Side side_0)
			{
				return Operators.CompareString(side_0.method_51().ToUpper(), this.string_0.ToUpper(), false) == 0 || Operators.CompareString(side_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04001D55 RID: 7509
			public string string_0;
		}

		// Token: 0x0200045C RID: 1116
		[CompilerGenerated]
		internal sealed class Class510
		{
			// Token: 0x06002259 RID: 8793 RVA: 0x00010B4F File Offset: 0x0000ED4F
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.bool_1 & Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x04001D56 RID: 7510
			public string string_0;
		}

		// Token: 0x0200045D RID: 1117
		[CompilerGenerated]
		internal sealed class Class511
		{
			// Token: 0x0600225B RID: 8795 RVA: 0x002665F0 File Offset: 0x002647F0
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x0600225C RID: 8796 RVA: 0x002665F0 File Offset: 0x002647F0
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04001D57 RID: 7511
			public string string_0;
		}

		// Token: 0x0200045E RID: 1118
		[CompilerGenerated]
		internal sealed class Class512
		{
			// Token: 0x0600225E RID: 8798 RVA: 0x00010B77 File Offset: 0x0000ED77
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x04001D58 RID: 7512
			public string string_0;
		}

		// Token: 0x0200045F RID: 1119
		[CompilerGenerated]
		internal sealed class Class513
		{
			// Token: 0x06002260 RID: 8800 RVA: 0x0026663C File Offset: 0x0026483C
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x06002261 RID: 8801 RVA: 0x0026663C File Offset: 0x0026483C
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.string_0.ToLower(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x04001D59 RID: 7513
			public string string_0;
		}
	}
}
