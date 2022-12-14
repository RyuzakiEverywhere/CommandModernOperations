using System;
using System.Collections.Generic;
using System.Reflection;
using Command_Core.DAL;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns14;

namespace Command_Core.Lua
{
	// Token: 0x0200042D RID: 1069
	[Attribute1]
	[Attribute2]
	[Attribute3]
	public sealed class LuaWrapper_Device_Loadout
	{
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06002032 RID: 8242 RVA: 0x0023AE5C File Offset: 0x0023905C
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

		// Token: 0x06002033 RID: 8243 RVA: 0x000100E4 File Offset: 0x0000E2E4
		public LuaWrapper_Device_Loadout(Loadout a, Scenario s)
		{
			this.LoadOut = a;
			this.ScenarioContext = s;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x000100FA File Offset: 0x0000E2FA
		[Attribute2]
		public object __obj
		{
			get
			{
				return this.LoadOut;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x00010102 File Offset: 0x0000E302
		[Attribute2]
		public int dbid
		{
			get
			{
				return this.LoadOut.DBID;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x0001010F File Offset: 0x0000E30F
		[Attribute2]
		public string name
		{
			get
			{
				return this.LoadOut.Name;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x00247CC0 File Offset: 0x00245EC0
		[Attribute2]
		public LuaTable roles
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				luaTable["role"] = (int)this.LoadOut.loadoutRole_0;
				luaTable["TOD"] = (short)this.LoadOut._LoadoutDayNight_0;
				luaTable["weather"] = (short)this.LoadOut._LoadoutWeather_0;
				return luaTable;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x00247D28 File Offset: 0x00245F28
		[Attribute2]
		public LuaTable weapons
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (WeaponRec weaponRec in this.LoadOut.weaponRec_0)
				{
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					luaTable2["wpn_guid"] = weaponRec.string_0;
					luaTable2["wpn_current"] = weaponRec.method_9();
					luaTable2["wpn_maxcap"] = weaponRec.int_2;
					luaTable2["wpn_default"] = weaponRec.int_0;
					luaTable2["wpn_dbid"] = weaponRec.int_5;
					luaTable2["wpn_name"] = weaponRec.method_12(this.ScenarioContext).Name;
					luaTable2["wpn_type"] = (int)DBFunctions.smethod_58(weaponRec.int_5, this.ScenarioContext);
					luaTable[luaTable.Keys.Count + 1] = luaTable2;
				}
				return luaTable;
			}
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00247E38 File Offset: 0x00246038
		[Attribute2]
		public override string ToString()
		{
			return (string.Concat(new string[]
			{
				"loadout {\r\n name = '",
				this.name,
				"', \r\n dbid = '",
				this.dbid.ToString(),
				"', \r\n roles = '{",
				this.LoadOut.loadoutRole_0.ToString(),
				",",
				this.LoadOut._LoadoutDayNight_0.ToString(),
				",",
				this.LoadOut._LoadoutWeather_0.ToString(),
				"}\r\n weapons = '",
				this.weapons.ToString(),
				"', \r\n"
			}) ?? "") + "}";
		}

		// Token: 0x04001CED RID: 7405
		protected Scenario ScenarioContext;

		// Token: 0x04001CEE RID: 7406
		protected Loadout LoadOut;
	}
}
