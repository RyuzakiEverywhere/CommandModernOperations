using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns14;

namespace Command_Core.Lua
{
	// Token: 0x02000419 RID: 1049
	[Attribute1]
	[Attribute2]
	[Attribute3]
	public sealed class LuaWrapper_Facility
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x0023AE5C File Offset: 0x0023905C
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

		// Token: 0x06001FB1 RID: 8113 RVA: 0x0023DB60 File Offset: 0x0023BD60
		public LuaWrapper_Facility(object a, Scenario s)
		{
			this.dock = null;
			this.air = null;
			if (a.GetType() == typeof(AirFacility))
			{
				this.air = (AirFacility)a;
			}
			else if (a.GetType() == typeof(DockFacility))
			{
				this.dock = (DockFacility)a;
			}
			this.ScenarioContext = s;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x0023DBC8 File Offset: 0x0023BDC8
		[Attribute2]
		public object __au
		{
			get
			{
				object result;
				if (this.air != null)
				{
					result = this.air;
				}
				else if (this.dock != null)
				{
					result = this.dock;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x0023DBFC File Offset: 0x0023BDFC
		[Attribute2]
		public string guid
		{
			get
			{
				string result;
				if (this.air != null)
				{
					result = this.air.string_0;
				}
				else if (this.dock != null)
				{
					result = this.dock.string_0;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x0023DC38 File Offset: 0x0023BE38
		[Attribute2]
		public int dbid
		{
			get
			{
				int result;
				if (this.air != null)
				{
					result = this.air.DBID;
				}
				else if (this.dock != null)
				{
					result = this.dock.DBID;
				}
				else
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x0023DC74 File Offset: 0x0023BE74
		[Attribute2]
		public string name
		{
			get
			{
				string result;
				if (this.air != null)
				{
					result = this.air.Name;
				}
				else if (this.dock != null)
				{
					result = this.dock.Name;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x0023DCB0 File Offset: 0x0023BEB0
		[Attribute2]
		public int type
		{
			get
			{
				int result;
				if (this.air != null)
				{
					result = (int)this.air.method_28();
				}
				else if (this.dock != null)
				{
					result = (int)this.dock.enum49_0;
				}
				else
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x0023DCEC File Offset: 0x0023BEEC
		[Attribute2]
		public int capacity
		{
			get
			{
				int result;
				if (this.air != null)
				{
					result = this.air.int_0;
				}
				else if (this.dock != null)
				{
					result = (int)this.dock.byte_0;
				}
				else
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x0023DD28 File Offset: 0x0023BF28
		[Attribute2]
		public string status
		{
			get
			{
				string result;
				if (this.air != null)
				{
					result = this.air.vmethod_5().ToString();
				}
				else if (this.dock != null)
				{
					result = this.dock.vmethod_5().ToString();
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x04001CCB RID: 7371
		protected DockFacility dock;

		// Token: 0x04001CCC RID: 7372
		protected AirFacility air;

		// Token: 0x04001CCD RID: 7373
		protected Scenario ScenarioContext;
	}
}
