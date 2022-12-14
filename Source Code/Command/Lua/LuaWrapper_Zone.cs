using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using DarkUI.Collections;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns13;
using ns14;

namespace Command_Core.Lua
{
	// Token: 0x02000439 RID: 1081
	[Attribute1]
	[Attribute2]
	[Attribute3]
	public sealed class LuaWrapper_Zone
	{
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x0023AE5C File Offset: 0x0023905C
		public object fields
		{
			get
			{
				Type type = base.GetType();
				int num = 0;
				PropertyInfo[] properties = type.GetProperties();
				MethodInfo[] methods = type.GetMethods();
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (PropertyInfo propertyInfo in properties)
				{
					if (!propertyInfo.Name.StartsWith("__") && !propertyInfo.Name.StartsWith("fields"))
					{
						string text = "";
						bool flag = false;
						if (propertyInfo.MemberType == MemberTypes.Method)
						{
							text = ":";
						}
						else if (propertyInfo.MemberType == MemberTypes.Property)
						{
							text = ".";
						}
						foreach (MethodInfo memberInfo in methods)
						{
							string right = "set_" + propertyInfo.Name;
							if (Operators.CompareString(memberInfo.Name, right, false) == 0)
							{
								flag = true;
							}
						}
						num++;
						dictionary.Add("property_" + num.ToString(), string.Concat(new string[]
						{
							text,
							propertyInfo.Name,
							" , ",
							propertyInfo.PropertyType.Name,
							" , ",
							flag.ToString()
						}));
					}
				}
				num = 0;
				foreach (MethodInfo methodInfo in methods)
				{
					if (!methodInfo.Name.StartsWith("get_") && !methodInfo.Name.StartsWith("set_") && !methodInfo.Name.StartsWith("ToString") && !methodInfo.IsHideBySig)
					{
						string str = "";
						if (methodInfo.MemberType == MemberTypes.Method)
						{
							str = ":";
						}
						else if (methodInfo.MemberType == MemberTypes.Property)
						{
							str = ".";
						}
						num++;
						dictionary.Add("method_" + num.ToString(), str + methodInfo.Name + " , " + methodInfo.ReturnType.ToString());
					}
				}
				object result;
				if (dictionary.Count == 0)
				{
					result = null;
				}
				else
				{
					LuaUtility.smethod_3(dictionary, luaTable);
					result = luaTable;
				}
				return result;
			}
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x000105E5 File Offset: 0x0000E7E5
		public LuaWrapper_Zone(Zone theZone, Scenario theScen, Side theSide)
		{
			this.myZone = theZone;
			this.ScenarioContext = theScen;
			this.mySide = theSide;
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060020DF RID: 8415 RVA: 0x00010602 File Offset: 0x0000E802
		[Attribute2]
		public object __obj
		{
			get
			{
				return this.myZone;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x0001060A File Offset: 0x0000E80A
		[Attribute2]
		public string type
		{
			get
			{
				return this.myZone.GetType().ToString();
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x0001061C File Offset: 0x0000E81C
		[Attribute2]
		public string guid
		{
			get
			{
				return this.myZone.string_0;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x00010629 File Offset: 0x0000E829
		[Attribute2]
		public string objectid
		{
			get
			{
				return this.guid;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x00010631 File Offset: 0x0000E831
		// (set) Token: 0x060020E4 RID: 8420 RVA: 0x0001063E File Offset: 0x0000E83E
		[Attribute2]
		public string name
		{
			get
			{
				return this.myZone.Name;
			}
			set
			{
				this.myZone.Name = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x0001064C File Offset: 0x0000E84C
		// (set) Token: 0x060020E6 RID: 8422 RVA: 0x00010659 File Offset: 0x0000E859
		[Attribute2]
		public string description
		{
			get
			{
				return this.myZone.string_2;
			}
			set
			{
				this.myZone.string_2 = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x00010667 File Offset: 0x0000E867
		// (set) Token: 0x060020E8 RID: 8424 RVA: 0x0024D3A8 File Offset: 0x0024B5A8
		[Attribute2]
		public object isactive
		{
			get
			{
				return this.myZone.bool_11;
			}
			set
			{
				try
				{
					this.myZone.bool_11 = Conversions.ToBoolean(value);
				}
				catch (Exception ex)
				{
					throw new Exception3(ex.Message);
				}
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x0024D3EC File Offset: 0x0024B5EC
		// (set) Token: 0x060020EA RID: 8426 RVA: 0x0024D430 File Offset: 0x0024B630
		[Attribute2]
		public object islocked
		{
			get
			{
				object result;
				if (this.myZone.GetType() == typeof(NoNavZone))
				{
					result = ((NoNavZone)this.myZone).bool_12;
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
					if (this.myZone.GetType() == typeof(NoNavZone))
					{
						((NoNavZone)this.myZone).bool_12 = Conversions.ToBoolean(value);
					}
				}
				catch (Exception ex)
				{
					throw new Exception3(ex.Message);
				}
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x0024D494 File Offset: 0x0024B694
		// (set) Token: 0x060020EC RID: 8428 RVA: 0x0024D4E0 File Offset: 0x0024B6E0
		[Attribute2]
		public object markas
		{
			get
			{
				object result;
				if (this.myZone.GetType() == typeof(ExclusionZone))
				{
					result = ((ExclusionZone)this.myZone).postureStance_0.ToString();
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				Misc.PostureStance postureStance_ = Misc.PostureStance.Neutral;
				string text = Conversions.ToString(value).ToLower();
				uint num = Class582.smethod_0(text);
				if (num <= 906799682U)
				{
					if (num <= 822911587U)
					{
						if (num != 9542285U)
						{
							if (num != 822911587U)
							{
								goto IL_14E;
							}
							if (Operators.CompareString(text, "4", false) != 0)
							{
								goto IL_14E;
							}
							goto IL_13A;
						}
						else if (Operators.CompareString(text, "hostile", false) != 0)
						{
							goto IL_14E;
						}
					}
					else if (num != 873244444U)
					{
						if (num != 890022063U)
						{
							if (num != 906799682U)
							{
								goto IL_14E;
							}
							if (Operators.CompareString(text, "3", false) != 0)
							{
								goto IL_14E;
							}
						}
						else
						{
							if (Operators.CompareString(text, "0", false) != 0)
							{
								goto IL_14E;
							}
							goto IL_14C;
						}
					}
					else
					{
						if (Operators.CompareString(text, "1", false) != 0)
						{
							goto IL_14E;
						}
						goto IL_128;
					}
					postureStance_ = Misc.PostureStance.Hostile;
					goto IL_14E;
				}
				if (num <= 2094259269U)
				{
					if (num != 923577301U)
					{
						if (num != 2094259269U)
						{
							goto IL_14E;
						}
						if (Operators.CompareString(text, "unfriendly", false) != 0)
						{
							goto IL_14E;
						}
					}
					else if (Operators.CompareString(text, "2", false) != 0)
					{
						goto IL_14E;
					}
					postureStance_ = Misc.PostureStance.Unfriendly;
					goto IL_14E;
				}
				if (num != 2353732312U)
				{
					if (num != 2608177081U)
					{
						if (num != 3453284734U)
						{
							goto IL_14E;
						}
						if (Operators.CompareString(text, "friendly", false) != 0)
						{
							goto IL_14E;
						}
					}
					else
					{
						if (Operators.CompareString(text, "unknown", false) == 0)
						{
							goto IL_13A;
						}
						goto IL_14E;
					}
				}
				else
				{
					if (Operators.CompareString(text, "neutral", false) == 0)
					{
						goto IL_14C;
					}
					goto IL_14E;
				}
				IL_128:
				postureStance_ = Misc.PostureStance.Friendly;
				goto IL_14E;
				IL_13A:
				postureStance_ = Misc.PostureStance.Unknown;
				goto IL_14E;
				IL_14C:
				postureStance_ = Misc.PostureStance.Neutral;
				IL_14E:
				try
				{
					if (this.myZone.GetType() == typeof(ExclusionZone))
					{
						((ExclusionZone)this.myZone).postureStance_0 = postureStance_;
					}
				}
				catch (Exception ex)
				{
					throw new Exception3(ex.Message);
				}
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x0024D690 File Offset: 0x0024B890
		// (set) Token: 0x060020EE RID: 8430 RVA: 0x0024D7DC File Offset: 0x0024B9DC
		[Attribute2]
		public LuaTable area
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				try
				{
					foreach (ReferencePoint referencePoint in this.myZone.list_0)
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["name"] = referencePoint.Name;
						luaTable2["guid"] = referencePoint.string_0;
						luaTable2["longitude"] = referencePoint.imethod_0();
						luaTable2["latitude"] = referencePoint.imethod_2();
						luaTable2["highlighted"] = referencePoint.method_19();
						luaTable2["locked"] = referencePoint.bool_12;
						if (!Information.IsNothing(referencePoint.unit_0))
						{
							luaTable2["bearingtype"] = referencePoint.orientationType_0;
							luaTable2["relativeto"] = referencePoint.unit_0.string_0;
						}
						luaTable[num] = luaTable2;
						num++;
					}
				}
				finally
				{
					List<ReferencePoint>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return luaTable;
			}
			set
			{
				List<ReferencePoint> list = new List<ReferencePoint>();
				Side side = null;
				Unit unit = null;
				bool flag = false;
				list.Clear();
				List<object> list2 = LuaUtility.smethod_0(value.GetEnumerator());
				side = this.mySide;
				if (side != null)
				{
					try
					{
						List<object>.Enumerator enumerator = list2.GetEnumerator();
						while (enumerator.MoveNext())
						{
							LuaWrapper_Zone._Closure$__31-0 CS$<>8__locals1 = new LuaWrapper_Zone._Closure$__31-0(CS$<>8__locals1);
							CS$<>8__locals1.$VB$Local_o = RuntimeHelpers.GetObjectValue(enumerator.Current);
							ReferencePoint referencePoint = null;
							if (CS$<>8__locals1.$VB$Local_o.GetType() == typeof(LuaTable))
							{
								Dictionary<string, object> dictionary = LuaUtility.smethod_1(((LuaTable)CS$<>8__locals1.$VB$Local_o).GetEnumerator());
								if (Information.IsNothing(unit) && dictionary.ContainsKey("RELATIVETO"))
								{
									string text = Conversions.ToString(dictionary["RELATIVETO"]);
									unit = PrivateMethods.smethod_68(text, this.mySide);
									if (unit == null)
									{
										throw new Exception3("Missing unit " + text + " from relative bearing");
									}
								}
								if (!flag && dictionary.ContainsKey("HIDDEN") && LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(dictionary["HIDDEN"])).GetValueOrDefault())
								{
									flag = true;
								}
								referencePoint = Class478.smethod_5(dictionary, null, this.ScenarioContext, unit);
								if (!Information.IsNothing(referencePoint))
								{
									list.Add(referencePoint);
								}
							}
							else
							{
								if (!Information.IsNothing(Enumerable.FirstOrDefault<ReferencePoint>(side.vmethod_12(), (ReferencePoint s) => Operators.CompareString(s.Name.ToLower(), CS$<>8__locals1.$VB$Local_o.ToString().ToLower(), false) == 0 || Operators.CompareString(s.string_0.ToLower(), CS$<>8__locals1.$VB$Local_o.ToString().ToLower(), false) == 0)))
								{
									referencePoint = Enumerable.First<ReferencePoint>(side.vmethod_12(), (ReferencePoint s) => Operators.CompareString(s.Name.ToLower(), CS$<>8__locals1.$VB$Local_o.ToString().ToLower(), false) == 0 || Operators.CompareString(s.string_0.ToLower(), CS$<>8__locals1.$VB$Local_o.ToString().ToLower(), false) == 0);
								}
								if (!Information.IsNothing(referencePoint))
								{
									list.Add(referencePoint);
								}
							}
						}
					}
					finally
					{
						List<object>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.myZone.list_0 = list;
					try
					{
						foreach (ReferencePoint referencePoint2 in list)
						{
							if (!flag)
							{
								if (!side.vmethod_12().Contains(referencePoint2))
								{
									side.vmethod_12().method_4(referencePoint2);
								}
							}
							else if (side.vmethod_12().Contains(referencePoint2))
							{
								side.vmethod_12().method_6(referencePoint2);
							}
						}
					}
					finally
					{
						List<ReferencePoint>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x0024DA38 File Offset: 0x0024BC38
		// (set) Token: 0x060020F0 RID: 8432 RVA: 0x0024DB18 File Offset: 0x0024BD18
		[Attribute2]
		public LuaTable affects
		{
			get
			{
				List<GlobalVariables.ActiveUnitType> list = new List<GlobalVariables.ActiveUnitType>();
				if (this.myZone.GetType() == typeof(NoNavZone))
				{
					list = Enumerable.ToList<GlobalVariables.ActiveUnitType>(((NoNavZone)this.myZone).vmethod_4());
				}
				else if (this.myZone.GetType() == typeof(ExclusionZone))
				{
					list = Enumerable.ToList<GlobalVariables.ActiveUnitType>(((ExclusionZone)this.myZone).vmethod_4());
				}
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				try
				{
					foreach (GlobalVariables.ActiveUnitType activeUnitType in list)
					{
						luaTable[num] = activeUnitType.ToString();
						num++;
					}
				}
				finally
				{
					List<GlobalVariables.ActiveUnitType>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return luaTable;
			}
			set
			{
				List<GlobalVariables.ActiveUnitType> list = new List<GlobalVariables.ActiveUnitType>();
				list.Clear();
				List<object> list2 = LuaUtility.smethod_0(value.GetEnumerator());
				checked
				{
					try
					{
						List<object>.Enumerator enumerator = list2.GetEnumerator();
						IL_B4:
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							string text = RuntimeHelpers.GetObjectValue(obj).ToString().ToLower();
							GlobalVariables.ActiveUnitType activeUnitType = GlobalVariables.ActiveUnitType.None;
							byte[] array = (byte[])Enum.GetValues(typeof(GlobalVariables.ActiveUnitType));
							int i = 0;
							while (i < array.Length)
							{
								byte b = array[i];
								if (Operators.CompareString(text, b.ToString().ToLower(), false) != 0)
								{
									string left = text;
									GlobalVariables.ActiveUnitType activeUnitType2 = (GlobalVariables.ActiveUnitType)b;
									if (Operators.CompareString(left, activeUnitType2.ToString().ToLower(), false) != 0)
									{
										i++;
										continue;
									}
								}
								activeUnitType = (GlobalVariables.ActiveUnitType)b;
								IL_A8:
								if (activeUnitType != GlobalVariables.ActiveUnitType.None)
								{
									list.Add(activeUnitType);
									goto IL_B4;
								}
								goto IL_B4;
							}
							goto IL_A8;
						}
					}
					finally
					{
						List<object>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (this.myZone.GetType() == typeof(NoNavZone))
					{
						ObservableList<GlobalVariables.ActiveUnitType> observableList = ((NoNavZone)this.myZone).vmethod_4();
						if (Information.IsNothing(list))
						{
							ObservableList<GlobalVariables.ActiveUnitType> observableList2 = new ObservableList<GlobalVariables.ActiveUnitType>();
							observableList2.method_4(GlobalVariables.ActiveUnitType.Aircraft);
							observableList2.method_4(GlobalVariables.ActiveUnitType.Ship);
							observableList2.method_4(GlobalVariables.ActiveUnitType.Submarine);
							observableList2.method_4(GlobalVariables.ActiveUnitType.Facility);
							observableList = observableList2;
						}
						else
						{
							observableList = new ObservableList<GlobalVariables.ActiveUnitType>();
							try
							{
								foreach (GlobalVariables.ActiveUnitType gparam_ in list)
								{
									observableList.method_4(gparam_);
								}
							}
							finally
							{
								List<GlobalVariables.ActiveUnitType>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
						}
						((NoNavZone)this.myZone).vmethod_5(observableList);
						return;
					}
					if (this.myZone.GetType() == typeof(ExclusionZone))
					{
						ObservableList<GlobalVariables.ActiveUnitType> observableList3 = ((ExclusionZone)this.myZone).vmethod_4();
						if (Information.IsNothing(list))
						{
							ObservableList<GlobalVariables.ActiveUnitType> observableList4 = new ObservableList<GlobalVariables.ActiveUnitType>();
							observableList4.method_4(GlobalVariables.ActiveUnitType.Aircraft);
							observableList4.method_4(GlobalVariables.ActiveUnitType.Ship);
							observableList4.method_4(GlobalVariables.ActiveUnitType.Submarine);
							observableList4.method_4(GlobalVariables.ActiveUnitType.Facility);
							observableList3 = observableList4;
						}
						else
						{
							observableList3 = new ObservableList<GlobalVariables.ActiveUnitType>();
							try
							{
								foreach (GlobalVariables.ActiveUnitType gparam_2 in list)
								{
									observableList3.method_4(gparam_2);
								}
							}
							finally
							{
								List<GlobalVariables.ActiveUnitType>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
						}
						((ExclusionZone)this.myZone).vmethod_5(observableList3);
					}
				}
			}
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x0024DD78 File Offset: 0x0024BF78
		[Attribute2]
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"zone {\r\n guid = '",
				this.guid,
				"', \r\n description = '",
				this.description,
				"', \r\n isactive = '",
				this.isactive.ToString(),
				"', \r\n area = '",
				this.area.ToString(),
				"', \r\n type = '",
				this.myZone.GetType().ToString(),
				"'\r\n"
			}) + "}";
		}

		// Token: 0x04001D0B RID: 7435
		private Zone myZone;

		// Token: 0x04001D0C RID: 7436
		private Scenario ScenarioContext;

		// Token: 0x04001D0D RID: 7437
		private Side mySide;
	}
}
