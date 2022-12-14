using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns13;
using ns14;

namespace Command_Core.Lua
{
	// Token: 0x02000416 RID: 1046
	[Attribute1]
	[Attribute2]
	[Attribute3]
	public class LuaWrapper_ActiveUnit
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06001F52 RID: 8018 RVA: 0x0023AE5C File Offset: 0x0023905C
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

		// Token: 0x06001F53 RID: 8019 RVA: 0x0000FA79 File Offset: 0x0000DC79
		public LuaWrapper_ActiveUnit(ActiveUnit a, Scenario s)
		{
			this.au = a;
			this.ScenarioContext = s;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06001F54 RID: 8020 RVA: 0x0000FA8F File Offset: 0x0000DC8F
		[Attribute2]
		public object __obj
		{
			get
			{
				return this.au;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x0023B09C File Offset: 0x0023929C
		[Attribute2]
		public string subtype
		{
			get
			{
				string result;
				if (this.au.vmethod_56() > GlobalVariables.ActiveUnitType.None)
				{
					result = this.au.vmethod_57().ToString();
				}
				else
				{
					result = "None";
				}
				return result;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x0023B0D4 File Offset: 0x002392D4
		[Attribute2]
		public string type
		{
			get
			{
				string result;
				if (this.au.vmethod_56() > GlobalVariables.ActiveUnitType.None)
				{
					result = this.au.vmethod_56().ToString();
				}
				else if (this.au.bool_1)
				{
					result = "Group";
				}
				else
				{
					result = "None";
				}
				return result;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x0000FA97 File Offset: 0x0000DC97
		[Attribute2]
		public int dbid
		{
			get
			{
				return this.au.DBID;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06001F58 RID: 8024 RVA: 0x0000FAA4 File Offset: 0x0000DCA4
		// (set) Token: 0x06001F59 RID: 8025 RVA: 0x0000FAB1 File Offset: 0x0000DCB1
		[Attribute2]
		public string name
		{
			get
			{
				return this.au.Name;
			}
			set
			{
				this.au.Name = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06001F5A RID: 8026 RVA: 0x0023B128 File Offset: 0x00239328
		// (set) Token: 0x06001F5B RID: 8027 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual double latitude
		{
			get
			{
				return this.au.vmethod_30(null);
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06001F5C RID: 8028 RVA: 0x0023B14C File Offset: 0x0023934C
		// (set) Token: 0x06001F5D RID: 8029 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual double longitude
		{
			get
			{
				return this.au.vmethod_28(null);
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06001F5E RID: 8030 RVA: 0x0000FACB File Offset: 0x0000DCCB
		// (set) Token: 0x06001F5F RID: 8031 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual bool autodetectable
		{
			get
			{
				return this.au.method_92(null);
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x0000FAD9 File Offset: 0x0000DCD9
		[Attribute2]
		public string guid
		{
			get
			{
				return this.au.string_0;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x0000FAE6 File Offset: 0x0000DCE6
		[Attribute2]
		public string side
		{
			get
			{
				return this.au.vmethod_7(false).method_51();
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x0023B170 File Offset: 0x00239370
		// (set) Token: 0x06001F63 RID: 8035 RVA: 0x0000FAF9 File Offset: 0x0000DCF9
		[Attribute2]
		public object mission
		{
			get
			{
				object result;
				if (this.au.vmethod_101() == null)
				{
					result = null;
				}
				else
				{
					Mission theMission = this.au.vmethod_101();
					result = new LuaWrapper_Mission(theMission, this.ScenarioContext);
				}
				return result;
			}
			set
			{
				if (!(value is string))
				{
					throw new Exception3("Please provide the mission's name.");
				}
				PrivateMethods.smethod_12(this.au.string_0, Conversions.ToString(value), this.ScenarioContext, null, false, false);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x0000FB2E File Offset: 0x0000DD2E
		// (set) Token: 0x06001F65 RID: 8037 RVA: 0x0000FB40 File Offset: 0x0000DD40
		[Attribute2]
		public bool holdposition
		{
			get
			{
				return this.au.vmethod_86().bool_4;
			}
			set
			{
				this.au.vmethod_86().bool_4 = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x0023B1A8 File Offset: 0x002393A8
		// (set) Token: 0x06001F67 RID: 8039 RVA: 0x0000FB53 File Offset: 0x0000DD53
		[Attribute2]
		public object holdfire
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				Doctrine doctrine_ = this.au.doctrine_0;
				if (!doctrine_.method_65())
				{
					luaTable["Air"] = ((byte)doctrine_.method_63(this.ScenarioContext, false, new bool?(false), false, false).Value).ToString();
				}
				else
				{
					luaTable["Air"] = "Inherit";
				}
				if (!doctrine_.method_70())
				{
					luaTable["Surface"] = ((byte)doctrine_.method_68(this.ScenarioContext, false, new bool?(false), false, false).Value).ToString();
				}
				else
				{
					luaTable["Surface"] = "Inherit";
				}
				if (!doctrine_.method_75())
				{
					luaTable["Subsurface"] = ((byte)doctrine_.method_73(this.ScenarioContext, false, new bool?(false), false, false).Value).ToString();
				}
				else
				{
					luaTable["SubSurface"] = "Inherit";
				}
				if (!doctrine_.method_80())
				{
					luaTable["Land"] = ((byte)doctrine_.method_78(this.ScenarioContext, false, new bool?(false), false, false).Value).ToString();
				}
				else
				{
					luaTable["Land"] = "Inherit";
				}
				return luaTable;
			}
			set
			{
				throw new Exception3("This is a Doctrine property for a normal active unit. Please use SetDoctrine instead.");
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x0023B2F8 File Offset: 0x002394F8
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual object group
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
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x0000FB5F File Offset: 0x0000DD5F
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual object altitude
		{
			get
			{
				return this.au.vmethod_14(true);
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x0023B368 File Offset: 0x00239568
		[Attribute2]
		public object airbornetime
		{
			get
			{
				object result;
				if (this.au.GetType() == typeof(Aircraft))
				{
					result = Misc.smethod_11((long)Math.Round((double)((Aircraft)this.au).float_26), Aircraft_AirOps.Enum44.const_0, false, true);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x0023B3B4 File Offset: 0x002395B4
		[Attribute2]
		public object readytime
		{
			get
			{
				object result;
				if (this.au.GetType() == typeof(Aircraft))
				{
					result = Misc.smethod_11((long)Math.Round((double)((Aircraft)this.au).method_164().method_38()), Aircraft_AirOps.Enum44.const_0, false, true);
				}
				else if (!Information.IsNothing(this.au.vmethod_93()))
				{
					result = Misc.smethod_11((long)Math.Round((double)this.au.vmethod_93().method_0()), Aircraft_AirOps.Enum44.const_0, false, true);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x0023B438 File Offset: 0x00239638
		[Attribute2]
		public object loadoutdbid
		{
			get
			{
				object result;
				if (this.au.GetType() == typeof(Aircraft))
				{
					if (Information.IsNothing(((Aircraft)this.au).method_167()))
					{
						result = 0;
					}
					else
					{
						result = ((Aircraft)this.au).method_167().DBID;
					}
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x0000FB72 File Offset: 0x0000DD72
		// (set) Token: 0x06001F70 RID: 8048 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual object speed
		{
			get
			{
				return this.au.vmethod_40();
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x0000FB84 File Offset: 0x0000DD84
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual object throttle
		{
			get
			{
				return this.au.vmethod_84();
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x0023B49C File Offset: 0x0023969C
		[Attribute2]
		public LuaTable damage
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				ActiveUnit_Damage activeUnit_Damage = this.au.vmethod_91();
				LuaUtility.smethod_3(new Dictionary<string, object>
				{
					{
						"DP",
						this.au.vmethod_63(false, null)
					},
					{
						"FLOOD",
						activeUnit_Damage.vmethod_1().ToString()
					},
					{
						"FIRES",
						activeUnit_Damage.vmethod_3().ToString()
					},
					{
						"STARTDP",
						this.au.method_60().ToString()
					}
				}, luaTable);
				return luaTable;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x0023B548 File Offset: 0x00239748
		[Attribute2]
		public LuaTable ascontact
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (Side side in this.au.scenario_0.method_44())
				{
					if (!Information.IsNothing(side) && side != this.side)
					{
						try
						{
							foreach (Contact contact in side.method_44())
							{
								if (Operators.CompareString(contact.activeUnit_0.string_0, this.au.string_0, false) == 0)
								{
									LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
									luaTable2["side"] = side.string_0;
									luaTable2["guid"] = contact.string_0;
									luaTable2["name"] = contact.Name;
									luaTable[luaTable.Keys.Count + 1] = luaTable2;
								}
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					try
					{
						foreach (string text in side.lazy_0.Value.Keys)
						{
							if (!side.method_44().Contains(side.lazy_0.Value[text]))
							{
								Contact contact2 = side.lazy_0.Value[text];
								LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
								luaTable3["side"] = side.string_0;
								luaTable3["guid"] = contact2.string_0;
								luaTable3["name"] = contact2.Name;
								luaTable[luaTable.Keys.Count + 1] = luaTable3;
							}
						}
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
				return luaTable;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x0000FB96 File Offset: 0x0000DD96
		// (set) Token: 0x06001F76 RID: 8054 RVA: 0x0023B744 File Offset: 0x00239944
		[Attribute2]
		public object desiredheading
		{
			get
			{
				return this.au.vmethod_68();
			}
			set
			{
				float float_ = 0f;
				try
				{
					if (float.TryParse(Conversions.ToString(value), out float_))
					{
						this.au.vmethod_69(ActiveUnit.Enum28.const_0, float_);
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x0000FBA8 File Offset: 0x0000DDA8
		// (set) Token: 0x06001F78 RID: 8056 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual object heading
		{
			get
			{
				return this.au.vmethod_9();
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x0023B794 File Offset: 0x00239994
		[Attribute2]
		public LuaTable weather
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				Weather.WeatherProfile weatherProfile = this.au.method_74();
				luaTable["temp"] = weatherProfile.method_1(Weather.TTimeOfDayType.const_0);
				luaTable["rainfall"] = weatherProfile.float_0;
				luaTable["undercloud"] = weatherProfile.method_3();
				luaTable["seastate"] = weatherProfile.int_0;
				return luaTable;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x0023B810 File Offset: 0x00239A10
		// (set) Token: 0x06001F7B RID: 8059 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual string proficiency
		{
			get
			{
				string result = null;
				GlobalVariables.ProficiencyLevel? proficiencyLevel = this.au.vmethod_53();
				int? num = (proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					result = "Novice";
				}
				else
				{
					num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						result = "Cadet";
					}
					else
					{
						num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							result = "Regular";
						}
						else
						{
							num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								result = "Veteran";
							}
							else
							{
								num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									result = "Ace";
								}
							}
						}
					}
				}
				return result;
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x0023B9EC File Offset: 0x00239BEC
		// (set) Token: 0x06001F7D RID: 8061 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual LuaTable course
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
					luaTable[num] = luaTable2;
					num++;
				}
				return luaTable;
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x0023BA7C File Offset: 0x00239C7C
		// (set) Token: 0x06001F7F RID: 8063 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual LuaTable fuel
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
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x0023BBD4 File Offset: 0x00239DD4
		[Attribute2]
		public LuaTable fuels
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (FuelRec fuelRec in this.au.vmethod_67())
				{
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					luaTable2["current"] = fuelRec.float_0;
					luaTable2["max"] = fuelRec.int_0;
					luaTable2["name"] = fuelRec._FuelType_0.ToString();
					luaTable2["type"] = Convert.ToInt32((short)fuelRec._FuelType_0);
					luaTable[luaTable.Keys.Count + 1] = luaTable2;
				}
				return luaTable;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x0023BCA0 File Offset: 0x00239EA0
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual LuaTable formation
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
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x0023BDB4 File Offset: 0x00239FB4
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual LuaTable magazines
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (Magazine magazine in this.au.method_91())
				{
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
					if (magazine.DBID != 0)
					{
						luaTable2["mag_capacity"] = magazine.int_1;
						luaTable2["mag_dbid"] = magazine.DBID;
						luaTable2["mag_guid"] = magazine.string_0;
						luaTable2["mag_name"] = magazine.Name;
						try
						{
							foreach (WeaponRec weaponRec in magazine.vmethod_10())
							{
								LuaTable luaTable4 = LuaSandBox.Singleton().CreateTable();
								luaTable4["wpn_guid"] = weaponRec.string_0;
								luaTable4["wpn_current"] = weaponRec.method_9();
								luaTable4["wpn_maxcap"] = weaponRec.int_2;
								luaTable4["wpn_default"] = weaponRec.int_0;
								luaTable4["wpn_dbid"] = weaponRec.int_5;
								luaTable4["wpn_name"] = weaponRec.method_12(this.ScenarioContext).Name;
								luaTable3[luaTable3.Keys.Count + 1] = luaTable4;
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						luaTable2["mag_weapons"] = luaTable3;
						luaTable[luaTable.Keys.Count + 1] = luaTable2;
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x0023BF90 File Offset: 0x0023A190
		// (set) Token: 0x06001F86 RID: 8070 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual LuaTable mounts
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				try
				{
					foreach (Mount mount in this.au.vmethod_51())
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
						if (mount.DBID != 0)
						{
							luaTable2["mount_dbid"] = mount.DBID;
							luaTable2["mount_guid"] = mount.string_0;
							luaTable2["mount_name"] = mount.Name;
							luaTable2["mount_status"] = mount.vmethod_5().ToString();
							if (mount.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
							{
								luaTable2["mount_statusR"] = mount.vmethod_4();
								luaTable2["mount_damage"] = mount.method_16().ToString();
							}
							try
							{
								foreach (WeaponRec weaponRec in mount.vmethod_10())
								{
									LuaTable luaTable4 = LuaSandBox.Singleton().CreateTable();
									luaTable4["wpn_guid"] = weaponRec.string_0;
									luaTable4["wpn_current"] = weaponRec.method_9();
									luaTable4["wpn_maxcap"] = weaponRec.int_2;
									luaTable4["wpn_default"] = weaponRec.int_0;
									luaTable4["wpn_dbid"] = weaponRec.int_5;
									luaTable4["wpn_name"] = weaponRec.method_12(this.ScenarioContext).Name;
									luaTable4["wpn_type"] = (int)DBFunctions.smethod_58(weaponRec.int_5, this.ScenarioContext);
									luaTable3[luaTable3.Keys.Count + 1] = luaTable4;
								}
							}
							finally
							{
								List<WeaponRec>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							luaTable2["mount_weapons"] = luaTable3;
							luaTable[luaTable.Keys.Count + 1] = luaTable2;
						}
					}
				}
				finally
				{
					List<Mount>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return luaTable;
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x0023C204 File Offset: 0x0023A404
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual LuaTable sensors
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (Sensor sensor in this.au.vmethod_96())
				{
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					luaTable2["sensor_dbid"] = sensor.DBID;
					luaTable2["sensor_guid"] = sensor.string_0;
					luaTable2["sensor_name"] = sensor.Name;
					luaTable2["sensor_type"] = (short)sensor.sensor_Type_0;
					luaTable2["sensor_role"] = (long)sensor.sensor_Role_0;
					luaTable2["sensor_maxrange"] = sensor.float_0;
					luaTable2["sensor_status"] = sensor.vmethod_5().ToString();
					luaTable2["sensor_isactive"] = sensor.method_43();
					if (sensor.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
					{
						luaTable2["sensor_statusR"] = sensor.vmethod_4();
						luaTable2["sensor_damage"] = sensor.method_16().ToString();
					}
					luaTable[luaTable.Keys.Count + 1] = luaTable2;
				}
				return luaTable;
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x0023C35C File Offset: 0x0023A55C
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x0000FBBA File Offset: 0x0000DDBA
		[Attribute2]
		public virtual LuaTable components
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				if (this.au.vmethod_120().Count > 0)
				{
					try
					{
						foreach (PlatformComponent platformComponent in this.au.vmethod_120())
						{
							LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
							luaTable2["comp_guid"] = platformComponent.string_0;
							luaTable2["comp_dbid"] = platformComponent.DBID;
							luaTable2["comp_name"] = platformComponent.Name;
							luaTable2["comp_type"] = platformComponent.GetType().Name;
							luaTable2["comp_status"] = platformComponent.vmethod_5().ToString();
							if (platformComponent.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
							{
								luaTable2["comp_damage"] = platformComponent.method_16().ToString();
								luaTable2["comp_statusR"] = platformComponent.vmethod_4();
							}
							if (platformComponent.GetType() == typeof(Cargo))
							{
								luaTable2["comp_name"] = ((Cargo)platformComponent).method_26();
								luaTable2["comp_dbid"] = ((Mount)((Cargo)platformComponent).method_25()).DBID;
							}
							luaTable[luaTable.Keys.Count + 1] = luaTable2;
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
				return luaTable;
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Not implemented.");
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x0023C4FC File Offset: 0x0023A6FC
		[Attribute2]
		public LuaTable cargo
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				List<ActiveUnit> list = new List<ActiveUnit>();
				if (this.au is Group)
				{
					try
					{
						foreach (ActiveUnit activeUnit in ((Group)this.au).vmethod_141().Values)
						{
							if (Enumerable.Count<Cargo>(activeUnit.cargo_0) > 0)
							{
								list.Add(activeUnit);
							}
						}
						goto IL_8A;
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				if (Enumerable.Count<Cargo>(this.au.cargo_0) > 0)
				{
					list.Add(this.au);
				}
				IL_8A:
				if (list.Count > 0)
				{
					try
					{
						foreach (ActiveUnit activeUnit2 in list)
						{
							LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
							luaTable2["name"] = activeUnit2.Name;
							luaTable2["guid"] = activeUnit2.string_0;
							if (Enumerable.Count<Cargo>(activeUnit2.cargo_0) > 0)
							{
								LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
								List<Tuple<int, Cargo>> list2 = new List<Tuple<int, Cargo>>();
								Cargo[] cargo_ = activeUnit2.cargo_0;
								checked
								{
									for (int i = 0; i < cargo_.Length; i++)
									{
										LuaWrapper_ActiveUnit._Closure$__95-0 CS$<>8__locals1 = new LuaWrapper_ActiveUnit._Closure$__95-0(CS$<>8__locals1);
										CS$<>8__locals1.$VB$Local_theM = cargo_[i];
										int num = list2.FindIndex((Tuple<int, Cargo> x) => ((Mount)x.Item2.method_25()).DBID == ((Mount)CS$<>8__locals1.$VB$Local_theM.method_25()).DBID);
										if (num == -1)
										{
											list2.Add(new Tuple<int, Cargo>(1, CS$<>8__locals1.$VB$Local_theM));
										}
										else
										{
											int item = unchecked(list2[num].Item1 + 1);
											list2[num] = new Tuple<int, Cargo>(item, CS$<>8__locals1.$VB$Local_theM);
										}
									}
								}
								try
								{
									foreach (Tuple<int, Cargo> tuple in list2)
									{
										LuaTable luaTable4 = LuaSandBox.Singleton().CreateTable();
										luaTable4["name"] = tuple.Item2.method_26();
										luaTable4["dbid"] = ((Mount)tuple.Item2.method_25()).DBID;
										luaTable4["guid"] = ((Mount)tuple.Item2.method_25()).string_0;
										luaTable4["status"] = ((Mount)tuple.Item2.method_25()).vmethod_5().ToString();
										luaTable4["area"] = ((Mount)tuple.Item2.method_25()).short_1;
										luaTable4["crew"] = ((Mount)tuple.Item2.method_25()).short_0;
										luaTable4["mass"] = ((Mount)tuple.Item2.method_25()).short_2;
										luaTable4["quantity"] = tuple.Item1;
										if (((Mount)tuple.Item2.method_25()).vmethod_5() != PlatformComponent._ComponentStatus.Operational)
										{
											luaTable4["damage"] = ((Mount)tuple.Item2.method_25()).method_16().ToString();
											luaTable4["statusR"] = ((Mount)tuple.Item2.method_25()).vmethod_4();
										}
										luaTable3[luaTable3.Keys.Count + 1] = luaTable4;
									}
								}
								finally
								{
									List<Tuple<int, Cargo>>.Enumerator enumerator3;
									((IDisposable)enumerator3).Dispose();
								}
								luaTable2["cargo"] = luaTable3;
							}
							luaTable[luaTable.Keys.Count + 1] = luaTable2;
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				return luaTable;
			}
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x0023C910 File Offset: 0x0023AB10
		[Attribute2]
		public LuaTable filterOnComponent(string type)
		{
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			if (this.au.vmethod_120().Count > 0)
			{
				try
				{
					foreach (PlatformComponent platformComponent in this.au.vmethod_120())
					{
						if (Operators.CompareString(platformComponent.GetType().Name.ToUpper(), type.ToUpper(), false) == 0 | Operators.CompareString(type, "", false) == 0)
						{
							LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
							luaTable2["comp_guid"] = platformComponent.string_0;
							luaTable2["comp_dbid"] = platformComponent.DBID;
							luaTable2["comp_name"] = platformComponent.Name;
							luaTable2["comp_type"] = platformComponent.GetType().Name;
							luaTable2["comp_status"] = platformComponent.vmethod_5().ToString();
							if (platformComponent.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
							{
								luaTable2["comp_damage"] = platformComponent.method_16().ToString();
								luaTable2["comp_statusR"] = platformComponent.vmethod_4();
							}
							if (platformComponent.GetType() == typeof(Cargo))
							{
								luaTable2["comp_name"] = ((Cargo)platformComponent).method_26();
								luaTable2["comp_dbid"] = ((Mount)((Cargo)platformComponent).method_25()).DBID;
							}
							luaTable[luaTable.Keys.Count + 1] = luaTable2;
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
			return luaTable;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x0023CAE4 File Offset: 0x0023ACE4
		[Attribute2]
		public string condition
		{
			get
			{
				string type = this.type;
				if (Operators.CompareString(type, "Ship", false) != 0 && Operators.CompareString(type, "Submarine", false) != 0)
				{
					if (Operators.CompareString(type, "Aircraft", false) == 0 && this.au.vmethod_92() != null)
					{
						return ((Aircraft_AirOps)this.au.vmethod_92()).method_40();
					}
				}
				else if (this.au.vmethod_93() != null)
				{
					return this.au.vmethod_93().method_10();
				}
				return null;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06001F8E RID: 8078 RVA: 0x0023CB6C File Offset: 0x0023AD6C
		[Attribute2]
		public string condition_v
		{
			get
			{
				string type = this.type;
				if (Operators.CompareString(type, "Ship", false) != 0 && Operators.CompareString(type, "Submarine", false) != 0)
				{
					if (Operators.CompareString(type, "Aircraft", false) == 0 && this.au.vmethod_92() != null)
					{
						return ((Aircraft_AirOps)this.au.vmethod_92()).method_36().ToString();
					}
				}
				else if (this.au.vmethod_93() != null)
				{
					return this.au.vmethod_93().method_8().ToString();
				}
				return null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x0023CC10 File Offset: 0x0023AE10
		[Attribute2]
		public string unitstate
		{
			get
			{
				return this.au.vmethod_108().ToString();
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06001F90 RID: 8080 RVA: 0x0023CC38 File Offset: 0x0023AE38
		[Attribute2]
		public string fuelstate
		{
			get
			{
				return this.au.vmethod_110().ToString();
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x0023CC60 File Offset: 0x0023AE60
		[Attribute2]
		public string weaponstate
		{
			get
			{
				return this.au.vmethod_112().ToString();
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06001F92 RID: 8082 RVA: 0x0000FBC6 File Offset: 0x0000DDC6
		// (set) Token: 0x06001F93 RID: 8083 RVA: 0x0000FBDD File Offset: 0x0000DDDD
		[Attribute2]
		public virtual object manualSpeed
		{
			get
			{
				return this.au.vmethod_87().vmethod_10();
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead.");
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06001F94 RID: 8084 RVA: 0x0023CC88 File Offset: 0x0023AE88
		// (set) Token: 0x06001F95 RID: 8085 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual LuaTable OODA
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
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06001F96 RID: 8086 RVA: 0x0000FBE9 File Offset: 0x0000DDE9
		// (set) Token: 0x06001F97 RID: 8087 RVA: 0x0000FBDD File Offset: 0x0000DDDD
		[Attribute2]
		public virtual object manualAltitude
		{
			get
			{
				return this.au.vmethod_87().vmethod_12();
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead.");
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06001F98 RID: 8088 RVA: 0x0023CCF0 File Offset: 0x0023AEF0
		[Attribute2]
		public object weapon
		{
			get
			{
				object result;
				if (this.au.bool_2)
				{
					LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
					Weapon weapon = (Weapon)this.au;
					ActiveUnit a = weapon.method_177();
					Contact contact = weapon.vmethod_142().vmethod_3();
					bool bool_ = weapon.bool_32;
					luaTable["shooter"] = new LuaWrapper_ActiveUnit(a, this.ScenarioContext);
					if (!Information.IsNothing(contact))
					{
						luaTable["contact"] = new LuaWrapper_Contact(contact, this.ScenarioContext, this.au.vmethod_7(false));
					}
					if (bool_)
					{
						luaTable["detonated"] = bool_.ToString();
					}
					result = luaTable;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x0023CD9C File Offset: 0x0023AF9C
		[Attribute2]
		public float rangetotarget(string contactId)
		{
			Contact contact = PrivateMethods.smethod_69(contactId, this.ScenarioContext);
			float result = 0f;
			if (contact != null)
			{
				this.au.method_31(contact);
				float num = this.au.method_36(contact);
				if (num == 3.4028235E+38f)
				{
					result = 0f;
				}
				else
				{
					result = num;
				}
			}
			return result;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06001F9A RID: 8090 RVA: 0x0023CDEC File Offset: 0x0023AFEC
		// (set) Token: 0x06001F9B RID: 8091 RVA: 0x0000FABF File Offset: 0x0000DCBF
		[Attribute2]
		public virtual LuaWrapper_ActiveUnit @base
		{
			get
			{
				LuaWrapper_ActiveUnit result = null;
				string type = this.type;
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
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06001F9C RID: 8092 RVA: 0x0023CED8 File Offset: 0x0023B0D8
		[Attribute2]
		public LuaWrapper_Facility hostFacility
		{
			get
			{
				LuaWrapper_Facility result = null;
				string type = this.type;
				if (Operators.CompareString(type, "Ship", false) != 0 && Operators.CompareString(type, "Submarine", false) != 0)
				{
					if (Operators.CompareString(type, "Aircraft", false) == 0 && this.au.vmethod_92() != null)
					{
						Aircraft_AirOps aircraft_AirOps = (Aircraft_AirOps)this.au.vmethod_92();
						if (aircraft_AirOps.method_34() != null)
						{
							result = new LuaWrapper_Facility(aircraft_AirOps.method_34(), this.ScenarioContext);
						}
					}
				}
				else if (this.au.vmethod_93() != null)
				{
					ActiveUnit_DockingOps activeUnit_DockingOps = this.au.vmethod_93();
					if (activeUnit_DockingOps.method_15() != null)
					{
						result = new LuaWrapper_Facility(activeUnit_DockingOps.method_15(), this.ScenarioContext);
					}
				}
				return result;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x0023CF88 File Offset: 0x0023B188
		[Attribute2]
		public LuaTable areaTriggersFired
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				List<string> list_ = this.au.list_0;
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				int num = 1;
				if (list_.Count > 0)
				{
					try
					{
						foreach (string value in list_)
						{
							dictionary.Add(num.ToString(), value);
							num++;
						}
					}
					finally
					{
						List<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				LuaUtility.smethod_3(dictionary, luaTable);
				return luaTable;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06001F9E RID: 8094 RVA: 0x0000FC00 File Offset: 0x0000DE00
		[Attribute2]
		public LuaTable hostedUnits
		{
			get
			{
				return this.embarkedUnits;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x0023D014 File Offset: 0x0023B214
		[Attribute2]
		public LuaTable embarkedUnits
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				if (this.au.vmethod_93() != null)
				{
					ActiveUnit_DockingOps activeUnit_DockingOps = this.au.vmethod_93();
					if (activeUnit_DockingOps.method_14().Count > 0)
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						try
						{
							foreach (ActiveUnit activeUnit in activeUnit_DockingOps.method_14())
							{
								luaTable2[num.ToString()] = activeUnit.string_0;
								luaTable2[num] = activeUnit.string_0;
								num++;
							}
						}
						finally
						{
							IEnumerator<ActiveUnit> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						luaTable["Boats"] = luaTable2;
					}
					else
					{
						luaTable["Boats"] = LuaSandBox.Singleton().CreateTable();
					}
				}
				if (this.au.vmethod_92() != null)
				{
					num = 1;
					ActiveUnit_AirOps activeUnit_AirOps = this.au.vmethod_92();
					if (activeUnit_AirOps.vmethod_4().Count > 0)
					{
						LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
						try
						{
							foreach (Aircraft aircraft in activeUnit_AirOps.vmethod_4())
							{
								luaTable3[num.ToString()] = aircraft.string_0;
								luaTable3[num] = aircraft.string_0;
								num++;
							}
						}
						finally
						{
							List<Aircraft>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						luaTable["Aircraft"] = luaTable3;
					}
					else
					{
						luaTable["Aircraft"] = LuaSandBox.Singleton().CreateTable();
					}
				}
				return luaTable;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06001FA0 RID: 8096 RVA: 0x0023D1BC File Offset: 0x0023B3BC
		[Attribute2]
		public LuaTable assignedUnits
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				if (this.au.vmethod_93() != null)
				{
					ActiveUnit_DockingOps activeUnit_DockingOps = this.au.vmethod_93();
					if (activeUnit_DockingOps.method_13().Count > 0)
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						try
						{
							foreach (ActiveUnit activeUnit in activeUnit_DockingOps.method_13())
							{
								luaTable2[num] = activeUnit.string_0;
								num++;
							}
						}
						finally
						{
							IEnumerator<ActiveUnit> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						luaTable["Boats"] = luaTable2;
					}
					else
					{
						luaTable["Boats"] = LuaSandBox.Singleton().CreateTable();
					}
				}
				if (this.au.vmethod_92() != null)
				{
					num = 1;
					ActiveUnit_AirOps activeUnit_AirOps = this.au.vmethod_92();
					if (activeUnit_AirOps.vmethod_6().Count > 0)
					{
						LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
						try
						{
							foreach (Aircraft aircraft in activeUnit_AirOps.vmethod_6())
							{
								luaTable3[num] = aircraft.string_0;
								num++;
							}
						}
						finally
						{
							IEnumerator<Aircraft> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						luaTable["Aircraft"] = luaTable3;
					}
					else
					{
						luaTable["Aircraft"] = LuaSandBox.Singleton().CreateTable();
					}
				}
				return luaTable;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x0023D338 File Offset: 0x0023B538
		[Attribute2]
		public object targetedBy
		{
			get
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				checked
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.ScenarioContext.vmethod_0().Values)
						{
							Contact[] array = activeUnit.vmethod_86().method_12();
							for (int i = 0; i < array.Length; i++)
							{
								if (array[i].activeUnit_0 == this.au && !dictionary.ContainsValue(activeUnit.string_0))
								{
									dictionary.Add(dictionary.Count.ToString(), activeUnit.string_0);
								}
							}
							if (!Information.IsNothing(activeUnit.vmethod_86().vmethod_3()) && activeUnit.vmethod_86().vmethod_3().activeUnit_0 == this.au && !dictionary.ContainsValue(activeUnit.string_0))
							{
								dictionary.Add(dictionary.Count.ToString(), activeUnit.string_0);
							}
						}
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
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
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x0023D46C File Offset: 0x0023B66C
		[Attribute2]
		public object firingAt
		{
			get
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				try
				{
					foreach (ActiveUnit activeUnit in this.ScenarioContext.vmethod_0().Values)
					{
						if (activeUnit.bool_2)
						{
							Weapon weapon = (Weapon)activeUnit;
							int dbid = weapon.DBID;
							ActiveUnit activeUnit2 = weapon.method_177();
							Contact contact = weapon.vmethod_142().vmethod_3();
							if (!Information.IsNothing(contact) && this.au == activeUnit2 && !dictionary.ContainsValue(contact.string_0))
							{
								dictionary.Add(dictionary.Count.ToString(), contact.string_0);
							}
						}
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x0023D550 File Offset: 0x0023B750
		[Attribute2]
		public object firedOn
		{
			get
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				try
				{
					foreach (ActiveUnit activeUnit in this.ScenarioContext.vmethod_0().Values)
					{
						if (activeUnit.bool_2)
						{
							Weapon weapon = (Weapon)activeUnit;
							int dbid = weapon.DBID;
							ActiveUnit activeUnit2 = weapon.method_177();
							Contact contact = weapon.vmethod_142().vmethod_3();
							if (!Information.IsNothing(contact) && this.au == contact.activeUnit_0 && !dictionary.ContainsValue(activeUnit2.string_0))
							{
								dictionary.Add(dictionary.Count.ToString(), activeUnit2.string_0);
							}
						}
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
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

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x0000FC08 File Offset: 0x0000DE08
		[Attribute2]
		public bool isOperating
		{
			get
			{
				return this.au.vmethod_127();
			}
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x0023D638 File Offset: 0x0023B838
		[Attribute2]
		public bool inArea(LuaTable zone)
		{
			List<ReferencePoint> list = new List<ReferencePoint>();
			this.au.vmethod_7(false);
			list.Clear();
			List<object> list2 = LuaUtility.smethod_0(zone.GetEnumerator());
			checked
			{
				try
				{
					List<object>.Enumerator enumerator = list2.GetEnumerator();
					IL_F6:
					while (enumerator.MoveNext())
					{
						LuaWrapper_ActiveUnit._Closure$__140-0 CS$<>8__locals1 = new LuaWrapper_ActiveUnit._Closure$__140-0(CS$<>8__locals1);
						CS$<>8__locals1.$VB$Local_o = RuntimeHelpers.GetObjectValue(enumerator.Current);
						ReferencePoint referencePoint = null;
						Side[] array = this.ScenarioContext.method_44();
						int i = 0;
						while (i < array.Length)
						{
							Side side = array[i];
							if (Information.IsNothing(Enumerable.FirstOrDefault<ReferencePoint>(side.vmethod_12(), (CS$<>8__locals1.$I0 == null) ? (CS$<>8__locals1.$I0 = ((ReferencePoint s) => Operators.CompareString(s.Name.ToLower(), CS$<>8__locals1.$VB$Local_o.ToString().ToLower(), false) == 0 || Operators.CompareString(s.string_0.ToLower(), CS$<>8__locals1.$VB$Local_o.ToString().ToLower(), false) == 0)) : CS$<>8__locals1.$I0)))
							{
								i++;
							}
							else
							{
								referencePoint = Enumerable.First<ReferencePoint>(side.vmethod_12(), (CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = ((ReferencePoint s) => Operators.CompareString(s.Name.ToLower(), CS$<>8__locals1.$VB$Local_o.ToString().ToLower(), false) == 0 || Operators.CompareString(s.string_0.ToLower(), CS$<>8__locals1.$VB$Local_o.ToString().ToLower(), false) == 0)) : CS$<>8__locals1.$I1);
								IL_E5:
								if (!Information.IsNothing(referencePoint))
								{
									list.Add(referencePoint);
									goto IL_F6;
								}
								goto IL_F6;
							}
						}
						goto IL_E5;
					}
				}
				finally
				{
					List<object>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (list == null)
				{
					throw new Exception3("Error in RP!");
				}
				return this.au.vmethod_46(list, this.ScenarioContext, false);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x0023D788 File Offset: 0x0023B988
		// (set) Token: 0x06001FA7 RID: 8103 RVA: 0x0000FC15 File Offset: 0x0000DE15
		[Attribute2]
		public virtual bool sprintDrift
		{
			get
			{
				return !Information.IsNothing(this.au.vmethod_85()) && this.au.vmethod_85().vmethod_3();
			}
			set
			{
				throw new Exception3("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_SetUnit).");
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x0000FC21 File Offset: 0x0000DE21
		[Attribute2]
		public string classname
		{
			get
			{
				return this.au.string_2;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0000FC2E File Offset: 0x0000DE2E
		[Attribute2]
		public bool outOfComms
		{
			get
			{
				return !this.au.vmethod_90().vmethod_1();
			}
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x0023D7C0 File Offset: 0x0023B9C0
		[Attribute2]
		public override string ToString()
		{
			string text = string.Concat(new string[]
			{
				"unit {\r\n type = '",
				this.type,
				"', \r\n subtype = '",
				this.subtype,
				"', \r\n name = '",
				this.name,
				"', \r\n side = '",
				this.side,
				"', \r\n guid = '",
				this.guid.ToString(),
				"', \r\n class = '",
				this.classname.ToString(),
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
			if ((this.group != null | this.au.bool_1) && this.group != null)
			{
				LuaWrapper_Group luaWrapper_Group = (LuaWrapper_Group)this.group;
				text = text + " group = '" + luaWrapper_Group.name + "', \r\n";
			}
			if (this.mission != null)
			{
				LuaWrapper_Mission luaWrapper_Mission = (LuaWrapper_Mission)this.mission;
				text = text + " mission = '" + luaWrapper_Mission.name + "', \r\n";
			}
			if (Operators.CompareString(this.type, "None", false) != 0)
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

		// Token: 0x04001CC5 RID: 7365
		protected ActiveUnit au;

		// Token: 0x04001CC6 RID: 7366
		protected Scenario ScenarioContext;
	}
}
