using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns13;
using ns14;

namespace Command_Core.Lua
{
	// Token: 0x02000436 RID: 1078
	[Attribute1]
	[Attribute2]
	[Attribute3]
	public sealed class LuaWrapper_Geopoint
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x0023AE5C File Offset: 0x0023905C
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

		// Token: 0x060020A9 RID: 8361 RVA: 0x00010469 File Offset: 0x0000E669
		public LuaWrapper_Geopoint(GeoPoint theGeopoint, Scenario theScen)
		{
			this.myGP = theGeopoint;
			this.ScenarioContext = theScen;
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x0001047F File Offset: 0x0000E67F
		[Attribute2]
		public string objectid
		{
			get
			{
				return this.myGP.string_0;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x0001048C File Offset: 0x0000E68C
		// (set) Token: 0x060020AC RID: 8364 RVA: 0x00010499 File Offset: 0x0000E699
		[Attribute2]
		public string name
		{
			get
			{
				return this.myGP.Name;
			}
			set
			{
				this.myGP.Name = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x000104A7 File Offset: 0x0000E6A7
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x0024BFD0 File Offset: 0x0024A1D0
		[Attribute2]
		public double latitude
		{
			get
			{
				return this.myGP.imethod_2();
			}
			set
			{
				double? num = LuaUtility.smethod_12(value);
				if (num == null)
				{
					throw new Exception3("Can't pass nil in as latitude.");
				}
				this.myGP.imethod_3(num.Value);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x000104B4 File Offset: 0x0000E6B4
		// (set) Token: 0x060020B0 RID: 8368 RVA: 0x0024C010 File Offset: 0x0024A210
		[Attribute2]
		public double longitude
		{
			get
			{
				return this.myGP.imethod_0();
			}
			set
			{
				double? num = LuaUtility.smethod_14(value);
				if (num == null)
				{
					throw new Exception3("Can't pass nil in as longitude.");
				}
				this.myGP.imethod_1(num.Value);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x000104C1 File Offset: 0x0000E6C1
		// (set) Token: 0x060020B2 RID: 8370 RVA: 0x000104CE File Offset: 0x0000E6CE
		[Attribute2]
		public float altitude
		{
			get
			{
				return this.myGP.imethod_4();
			}
			set
			{
				this.myGP.imethod_5(value);
			}
		}

		// Token: 0x04001D03 RID: 7427
		private GeoPoint myGP;

		// Token: 0x04001D04 RID: 7428
		private Scenario ScenarioContext;
	}
}
