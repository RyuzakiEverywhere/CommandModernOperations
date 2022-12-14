using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns14;

namespace Command_Core.Lua
{
	// Token: 0x02000433 RID: 1075
	[Attribute1]
	[Attribute2]
	[Attribute3]
	public sealed class LuaWrapper_Group
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x0023AE5C File Offset: 0x0023905C
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

		// Token: 0x06002061 RID: 8289 RVA: 0x00010280 File Offset: 0x0000E480
		public LuaWrapper_Group(Group a, Scenario s)
		{
			this.au = a;
			this.ScenarioContext = s;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x00010296 File Offset: 0x0000E496
		[Attribute2]
		public object __obj
		{
			get
			{
				return this.au;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x00248A70 File Offset: 0x00246C70
		[Attribute2]
		public string type
		{
			get
			{
				return this.au.method_143().ToString();
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x0001029E File Offset: 0x0000E49E
		[Attribute2]
		public string guid
		{
			get
			{
				return this.au.string_0;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x000102AB File Offset: 0x0000E4AB
		// (set) Token: 0x06002066 RID: 8294 RVA: 0x000102B8 File Offset: 0x0000E4B8
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

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x000102C6 File Offset: 0x0000E4C6
		[Attribute2]
		public string side
		{
			get
			{
				return this.au.vmethod_7(false).method_51();
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x000102D9 File Offset: 0x0000E4D9
		// (set) Token: 0x06002069 RID: 8297 RVA: 0x00248A98 File Offset: 0x00246C98
		[Attribute2]
		public string lead
		{
			get
			{
				return this.au.method_147().string_0;
			}
			set
			{
				Scenario scenarioContext = this.ScenarioContext;
				Group group;
				Side value2 = (group = this.au).vmethod_7(false);
				ActiveUnit activeUnit = LuaUtility.smethod_30(value, scenarioContext, ref value2);
				group.vmethod_8(false, value2);
				ActiveUnit activeUnit2 = activeUnit;
				if (!Information.IsNothing(activeUnit2))
				{
					try
					{
						IEnumerator<ActiveUnit> enumerator = this.au.vmethod_141().Values.GetEnumerator();
						while (enumerator.MoveNext())
						{
							if (enumerator.Current == activeUnit2)
							{
								this.au.method_153(activeUnit2);
								break;
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
				}
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600206A RID: 8298 RVA: 0x00248B28 File Offset: 0x00246D28
		[Attribute2]
		public LuaTable unitlist
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				List<Unit> list = new List<Unit>();
				list = this.au.method_152();
				int num = 1;
				try
				{
					foreach (Unit unit in list)
					{
						luaTable[num] = unit.string_0;
						num++;
					}
				}
				finally
				{
					List<Unit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return luaTable;
			}
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00248BA8 File Offset: 0x00246DA8
		[Attribute2]
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"group {\r\n guid = '",
				this.guid,
				"', \r\n name = '",
				this.name,
				"', \r\n side = '",
				this.side,
				"', \r\n type = '",
				this.type.ToString(),
				"', \r\n unitlist = '",
				this.unitlist.ToString(),
				"',\r\n"
			}) + "}";
		}

		// Token: 0x04001CFB RID: 7419
		protected Group au;

		// Token: 0x04001CFC RID: 7420
		protected Scenario ScenarioContext;
	}
}
