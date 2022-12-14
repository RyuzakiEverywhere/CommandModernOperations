using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns13;
using ns14;

namespace Command_Core.Lua
{
	// Token: 0x02000435 RID: 1077
	[Attribute1]
	[Attribute2]
	[Attribute3]
	public sealed class LuaWrapper_ReferencePoint
	{
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x0023AE5C File Offset: 0x0023905C
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

		// Token: 0x06002095 RID: 8341 RVA: 0x0001038D File Offset: 0x0000E58D
		public LuaWrapper_ReferencePoint(ReferencePoint r, Side d, Scenario s)
		{
			this.rp = r;
			this.ScenarioContext = s;
			this.mySide = d;
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x000103AA File Offset: 0x0000E5AA
		[Attribute2]
		public object __obj
		{
			get
			{
				return this.rp;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x000103B2 File Offset: 0x0000E5B2
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x000103BF File Offset: 0x0000E5BF
		[Attribute2]
		public string name
		{
			get
			{
				return this.rp.Name;
			}
			set
			{
				this.rp.Name = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x000103CD File Offset: 0x0000E5CD
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x0024BDEC File Offset: 0x00249FEC
		[Attribute2]
		public object latitude
		{
			get
			{
				return this.rp.imethod_2();
			}
			set
			{
				double? num = LuaUtility.smethod_12(RuntimeHelpers.GetObjectValue(value));
				if (num == null)
				{
					throw new Exception3("Can't pass nil in as latitude.");
				}
				this.rp.imethod_3(num.Value);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x000103DF File Offset: 0x0000E5DF
		// (set) Token: 0x0600209C RID: 8348 RVA: 0x0024BE2C File Offset: 0x0024A02C
		[Attribute2]
		public object longitude
		{
			get
			{
				return this.rp.imethod_0();
			}
			set
			{
				double? num = LuaUtility.smethod_14(RuntimeHelpers.GetObjectValue(value));
				if (num == null)
				{
					throw new Exception3("Can't pass nil in as longitude.");
				}
				this.rp.imethod_1(num.Value);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x000103F1 File Offset: 0x0000E5F1
		[Attribute2]
		public string guid
		{
			get
			{
				return this.rp.string_0;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x000103FE File Offset: 0x0000E5FE
		[Attribute2]
		public string side
		{
			get
			{
				return this.mySide.method_51();
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x0001040B File Offset: 0x0000E60B
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x00010418 File Offset: 0x0000E618
		[Attribute2]
		public bool highlighted
		{
			get
			{
				return this.rp.method_19();
			}
			set
			{
				this.rp.method_20(value);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x00010426 File Offset: 0x0000E626
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x00010433 File Offset: 0x0000E633
		[Attribute2]
		public bool locked
		{
			get
			{
				return this.rp.bool_12;
			}
			set
			{
				this.rp.bool_12 = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x00010441 File Offset: 0x0000E641
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x0024BE6C File Offset: 0x0024A06C
		[Attribute2]
		public ReferencePoint.OrientationType bearingtype
		{
			get
			{
				return this.rp.orientationType_0;
			}
			set
			{
				ReferencePoint.OrientationType orientationType = ReferencePoint.OrientationType.Fixed;
				if (Enum.TryParse<ReferencePoint.OrientationType>(Conversions.ToString((byte)value), true, out orientationType) && Enum.IsDefined(typeof(ReferencePoint.OrientationType), orientationType))
				{
					this.rp.orientationType_0 = value;
				}
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x0001044E File Offset: 0x0000E64E
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x0001045B File Offset: 0x0000E65B
		[Attribute2]
		public Unit relativeto
		{
			get
			{
				return this.rp.unit_0;
			}
			set
			{
				this.rp.unit_0 = value;
			}
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x0024BEB0 File Offset: 0x0024A0B0
		[Attribute2]
		public override string ToString()
		{
			string text = string.Concat(new string[]
			{
				"{\r\n name = '",
				this.name,
				"', \r\n latitude = '",
				this.latitude.ToString(),
				"', \r\n longitude = '",
				this.longitude.ToString(),
				"', \r\n guid = '",
				this.guid.ToString(),
				"', \r\n side = '",
				this.side,
				"', \r\n highlighted = '",
				this.highlighted.ToString(),
				"', \r\n locked = '",
				this.locked.ToString(),
				"', \r\n"
			});
			if (this.relativeto != null)
			{
				text = string.Concat(new string[]
				{
					text,
					" bearingtype = '",
					this.bearingtype.ToString(),
					"', \r\n relativeto = '",
					this.relativeto.Name,
					"', \r\n"
				});
			}
			return text + "}";
		}

		// Token: 0x04001D00 RID: 7424
		private ReferencePoint rp;

		// Token: 0x04001D01 RID: 7425
		private Scenario ScenarioContext;

		// Token: 0x04001D02 RID: 7426
		private Side mySide;
	}
}
