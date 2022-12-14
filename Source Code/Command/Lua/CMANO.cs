using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns10;
using ns11;
using ns13;

namespace Command_Core.Lua
{
	// Token: 0x020003FE RID: 1022
	public sealed class CMANO
	{
		// Token: 0x06001EA4 RID: 7844 RVA: 0x0000F1C3 File Offset: 0x0000D3C3
		public static void smethod_0()
		{
			CMANO.list_0.Clear();
			CMANO.Class447.smethod_0("OnStatusChange");
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x0000F1D9 File Offset: 0x0000D3D9
		internal CMANO(Scenario scenario_1)
		{
			CMANO.scenario_0 = scenario_1;
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x0022B9C4 File Offset: 0x00229BC4
		private static Class349 smethod_1(ref Dictionary<string, object> dictionary_0, Scenario scenario_1)
		{
			ActiveUnit activeUnit = null;
			Class349 @class = new Class349();
			Dictionary<string, object> dictionary = LuaUtility.smethod_1(((LuaTable)dictionary_0["TARGETFILTER"]).GetEnumerator());
			checked
			{
				try
				{
					Dictionary<string, object>.KeyCollection.Enumerator enumerator = dictionary.Keys.GetEnumerator();
					IL_18A:
					while (enumerator.MoveNext())
					{
						string text = enumerator.Current;
						string text2 = dictionary[text].ToString();
						string left = text.ToUpper();
						if (Operators.CompareString(left, "TARGETSIDE", false) != 0)
						{
							if (Operators.CompareString(left, "TARGETTYPE", false) == 0)
							{
								byte[] array = (byte[])Enum.GetValues(typeof(GlobalVariables.ActiveUnitType));
								int i = 0;
								while (i < array.Length)
								{
									byte b = array[i];
									if (Operators.CompareString(text2.ToLower(), b.ToString().ToLower(), false) != 0)
									{
										string left2 = text2.ToLower();
										GlobalVariables.ActiveUnitType activeUnitType = (GlobalVariables.ActiveUnitType)b;
										if (Operators.CompareString(left2, activeUnitType.ToString().ToLower(), false) != 0)
										{
											i++;
											continue;
										}
									}
									@class.activeUnitType_0 = (GlobalVariables.ActiveUnitType)b;
									IL_168:
									if (@class.activeUnitType_0 == GlobalVariables.ActiveUnitType.None)
									{
										throw new Exception3("Error in TargetFilter.Type!");
									}
									goto IL_18A;
								}
								goto IL_168;
							}
							if (Operators.CompareString(left, "TARGETSUBTYPE", false) != 0)
							{
								if (Operators.CompareString(left, "SPECIFICUNITCLASS", false) != 0)
								{
									if (Operators.CompareString(left, "SPECIFICUNIT", false) == 0)
									{
										activeUnit = PrivateMethods.smethod_67(text2, scenario_1);
										if (activeUnit == null)
										{
											throw new Exception3("Error in TargetFilter.Unit!");
										}
										@class.string_3 = activeUnit.string_0;
									}
								}
								else
								{
									@class.int_1 = Conversions.ToInteger(text2);
								}
							}
							else
							{
								@class.int_0 = Conversions.ToInteger(text2);
							}
						}
						else
						{
							Side side = PrivateMethods.smethod_66(text2, scenario_1);
							if (side == null)
							{
								throw new Exception3("Error in TargetFilter.Side!");
							}
							@class.string_2 = side.string_0;
						}
					}
				}
				finally
				{
					Dictionary<string, object>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (!string.IsNullOrEmpty(@class.string_3))
				{
					@class.int_1 = activeUnit.DBID;
					@class.int_0 = activeUnit.vmethod_57();
					@class.activeUnitType_0 = activeUnit.vmethod_56();
					@class.string_2 = activeUnit.vmethod_7(false).string_0;
				}
				else
				{
					if (@class.string_2 == null)
					{
						throw new Exception3("Error in TargetFilter.TargetSide!");
					}
					if (@class.int_1 != 0)
					{
						switch (@class.activeUnitType_0)
						{
						case GlobalVariables.ActiveUnitType.Aircraft:
							@class.int_0 = DBFunctions.smethod_20(ref scenario_1, @class.int_1);
							break;
						case GlobalVariables.ActiveUnitType.Ship:
							@class.int_0 = DBFunctions.smethod_22(ref scenario_1, @class.int_1);
							break;
						case GlobalVariables.ActiveUnitType.Submarine:
							@class.int_0 = DBFunctions.smethod_24(ref scenario_1, @class.int_1);
							break;
						case GlobalVariables.ActiveUnitType.Facility:
							@class.int_0 = DBFunctions.smethod_26(ref scenario_1, @class.int_1);
							break;
						case GlobalVariables.ActiveUnitType.Weapon:
							@class.int_0 = DBFunctions.smethod_29(ref scenario_1, @class.int_1);
							break;
						case GlobalVariables.ActiveUnitType.Satellite:
							@class.int_0 = DBFunctions.smethod_27(ref scenario_1, @class.int_1);
							break;
						}
						if (@class.int_0 == 0 || @class.activeUnitType_0 == GlobalVariables.ActiveUnitType.None)
						{
							throw new Exception3("Error in TargetFilter.Class!");
						}
					}
					else if (@class.int_0 != 0)
					{
						if (@class.activeUnitType_0 == GlobalVariables.ActiveUnitType.None)
						{
							throw new Exception3("Error in TargetFilter.SubType!");
						}
					}
					else if (@class.activeUnitType_0 == GlobalVariables.ActiveUnitType.None)
					{
						throw new Exception3("Error in TargetFilter.TargetType!");
					}
				}
				return @class;
			}
		}

		// Token: 0x04001C8D RID: 7309
		private static Scenario scenario_0;

		// Token: 0x04001C8E RID: 7310
		internal static List<CMANO.Class446> list_0 = new List<CMANO.Class446>();

		// Token: 0x04001C8F RID: 7311
		private static List<Tuple<ActiveUnit, object>> list_1 = new List<Tuple<ActiveUnit, object>>();

		// Token: 0x04001C90 RID: 7312
		public static CMANO.Class447 class447_0 = new CMANO.Class447();

		// Token: 0x020003FF RID: 1023
		internal sealed class Class446
		{
			// Token: 0x04001C91 RID: 7313
			internal LuaFunction luaFunction_0;

			// Token: 0x04001C92 RID: 7314
			internal List<object> list_0;
		}

		// Token: 0x02000400 RID: 1024
		internal sealed class Class447
		{
			// Token: 0x06001EA7 RID: 7847 RVA: 0x0000F1E7 File Offset: 0x0000D3E7
			internal Class447()
			{
				Aircraft_AirOps.smethod_8(new Aircraft_AirOps.Delegate26(this.method_1));
			}

			// Token: 0x06001EA8 RID: 7848 RVA: 0x0022BD14 File Offset: 0x00229F14
			public static void smethod_0(string string_0)
			{
				LuaFunction luaFunction = null;
				LuaTable luaTable = null;
				object objectValue = RuntimeHelpers.GetObjectValue(LuaSandBox.Singleton().SB_Lua()["OnStatusChange"]);
				if (objectValue is LuaFunction)
				{
					try
					{
						luaFunction = LuaSandBox.Singleton().SB_Lua().GetFunction("OnStatusChange");
					}
					catch (Exception ex)
					{
					}
					LuaSandBox.Singleton().SB_Lua().DoString(string_0 + "=nil", "chunk");
				}
				else if (objectValue is LuaTable)
				{
					try
					{
						luaTable = LuaSandBox.Singleton().SB_Lua().GetTable("OnStatusChange");
					}
					catch (Exception ex2)
					{
					}
				}
				if (luaFunction != null)
				{
					LuaSandBox.Singleton().SB_Lua().DoString(string_0 + "=nil", "chunk");
				}
				if (luaTable != null)
				{
					LuaSandBox.Singleton().SB_Lua().DoString(string_0 + "={}", "chunk");
				}
			}

			// Token: 0x06001EA9 RID: 7849 RVA: 0x0022BE1C File Offset: 0x0022A01C
			public bool method_0(ActiveUnit theUnit, object oldStatus = null)
			{
				if (CMANO.scenario_0 == null)
				{
					CMANO.scenario_0 = theUnit.scenario_0;
				}
				List<EventTrigger> list = new List<EventTrigger>();
				try
				{
					foreach (EventTrigger eventTrigger in CMANO.scenario_0.vmethod_4().Values)
					{
						if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.UnitBaseStatus && ((Class328)eventTrigger).method_8(theUnit, RuntimeHelpers.GetObjectValue(oldStatus)))
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
				if (list.Count > 0)
				{
					CMANO.scenario_0.method_24(list);
				}
				try
				{
					bool result = false;
					LuaFunction luaFunction = null;
					LuaTable luaTable = null;
					if (!LuaSandBox.Singleton().Equals(CMANO.scenario_0.method_10()))
					{
						Exception ex = new Exception();
						ex.Data.Add("LuaCMANO.1", "Scenario sandbox was not same as actual Sandbox");
						if (Information.IsNothing(CMANO.scenario_0))
						{
							ex.Data.Add("LuaCMANO.2", "Scenario not defined");
						}
						else if (!CMANO.scenario_0.method_10().Equals(LuaSandBox.Singleton()))
						{
							ex.Data.Add("LuaCMANO.3", "Scenario sandbox is still not same as actual Sandbox");
						}
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
					object objectValue = RuntimeHelpers.GetObjectValue(LuaSandBox.Singleton().SB_Lua()["OnStatusChange"]);
					if (objectValue is LuaFunction)
					{
						try
						{
							luaFunction = LuaSandBox.Singleton().SB_Lua().GetFunction("OnStatusChange");
							goto IL_19B;
						}
						catch (Exception ex2)
						{
							goto IL_19B;
						}
					}
					if (objectValue is LuaTable)
					{
						try
						{
							luaTable = LuaSandBox.Singleton().SB_Lua().GetTable("OnStatusChange");
						}
						catch (Exception ex3)
						{
						}
					}
					IL_19B:
					if (luaFunction != null)
					{
						List<object> list2 = new List<object>();
						list2.Add(new LuaWrapper_ActiveUnit_SE(theUnit, CMANO.scenario_0));
						list2.Add(oldStatus.ToString());
						try
						{
							luaFunction.Call(list2.ToArray());
						}
						catch (Exception ex4)
						{
						}
						return true;
					}
					if (luaTable != null)
					{
						List<object> list3 = LuaUtility.smethod_0(luaTable.GetEnumerator());
						try
						{
							foreach (object obj in list3)
							{
								objectValue = RuntimeHelpers.GetObjectValue(obj);
								if (objectValue is LuaTable)
								{
									Dictionary<string, object> dictionary = LuaUtility.smethod_1(((LuaTable)objectValue).GetEnumerator());
									LuaFunction luaFunction2 = null;
									Class349 @class = null;
									try
									{
										foreach (string text in dictionary.Keys)
										{
											string left = text.ToLower();
											if (Operators.CompareString(left, "targetfilter", false) != 0)
											{
												if (Operators.CompareString(left, "func", false) == 0)
												{
													luaFunction2 = (LuaFunction)dictionary[text];
												}
											}
											else
											{
												@class = CMANO.smethod_1(ref dictionary, CMANO.scenario_0);
											}
										}
									}
									finally
									{
										Dictionary<string, object>.KeyCollection.Enumerator enumerator3;
										((IDisposable)enumerator3).Dispose();
									}
									if (@class != null && @class.method_9(theUnit))
									{
										List<object> list4 = new List<object>();
										list4.Add(new LuaWrapper_ActiveUnit_SE(theUnit, CMANO.scenario_0));
										list4.Add(oldStatus.ToString());
										try
										{
											luaFunction2.Call(list4.ToArray());
											result = true;
										}
										catch (Exception ex5)
										{
										}
									}
								}
							}
						}
						finally
						{
							List<object>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						return result;
					}
				}
				catch (Exception ex6)
				{
					ex6.Data.Add("LuaCMANO.11", ex6.Message);
					if (Information.IsNothing(CMANO.scenario_0))
					{
						ex6.Data.Add("LuaCMANO.12", "Scenario not defined");
					}
					else if (!CMANO.scenario_0.method_10().Equals(LuaSandBox.Singleton()))
					{
						ex6.Data.Add("LuaCMANO.13", "Scenario sandbox is not same as actual Sandbox");
					}
					GameGeneral.smethod_25(ref ex6);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				return false;
			}

			// Token: 0x06001EAA RID: 7850 RVA: 0x0000F200 File Offset: 0x0000D400
			[CompilerGenerated]
			private void method_1(ActiveUnit activeUnit_0, object object_0)
			{
				this.method_0(activeUnit_0, RuntimeHelpers.GetObjectValue(object_0));
			}
		}
	}
}
