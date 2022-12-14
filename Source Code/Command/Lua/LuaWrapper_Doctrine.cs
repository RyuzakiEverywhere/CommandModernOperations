using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns14;

namespace Command_Core.Lua
{
	// Token: 0x02000432 RID: 1074
	[Attribute1]
	[Attribute2]
	[Attribute3]
	public sealed class LuaWrapper_Doctrine
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x0023AE5C File Offset: 0x0023905C
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

		// Token: 0x0600205D RID: 8285 RVA: 0x00010256 File Offset: 0x0000E456
		public LuaWrapper_Doctrine(Doctrine a, Scenario s)
		{
			this.doc = a;
			this.ScenarioContext = s;
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x0001026C File Offset: 0x0000E46C
		[Attribute2]
		public object __obj
		{
			get
			{
				return this.doc;
			}
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00010274 File Offset: 0x0000E474
		[Attribute2]
		public LuaTable filterWRA(string type)
		{
			return LuaSandBox.Singleton().CreateTable();
		}

		// Token: 0x04001CF9 RID: 7417
		protected Doctrine doc;

		// Token: 0x04001CFA RID: 7418
		protected Scenario ScenarioContext;
	}
}
