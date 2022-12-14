using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns13;
using ns14;

namespace Command_Core.Lua
{
	// Token: 0x0200043B RID: 1083
	[Attribute1]
	[Attribute2]
	[Attribute3]
	public sealed class LuaWrapper_Side
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x0023AE5C File Offset: 0x0023905C
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

		// Token: 0x060020F6 RID: 8438 RVA: 0x00010690 File Offset: 0x0000E890
		public LuaWrapper_Side(Side theSide, Scenario theScen)
		{
			this.mySide = theSide;
			this.ScenarioContext = theScen;
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x000106A6 File Offset: 0x0000E8A6
		[Attribute2]
		public object __obj
		{
			get
			{
				return this.mySide;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x000106AE File Offset: 0x0000E8AE
		[Attribute2]
		public string guid
		{
			get
			{
				return this.mySide.string_0;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x000106BB File Offset: 0x0000E8BB
		[Attribute2]
		public string ObjectID
		{
			get
			{
				return this.guid;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060020FA RID: 8442 RVA: 0x000106C3 File Offset: 0x0000E8C3
		// (set) Token: 0x060020FB RID: 8443 RVA: 0x000106D0 File Offset: 0x0000E8D0
		[Attribute2]
		public string name
		{
			get
			{
				return this.mySide.method_51();
			}
			set
			{
				this.mySide.method_52(value);
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x0024DE68 File Offset: 0x0024C068
		[Attribute2]
		public LuaTable units
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				foreach (ActiveUnit activeUnit in this.mySide.activeUnit_0)
				{
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					luaTable2["guid"] = activeUnit.string_0;
					luaTable2["name"] = activeUnit.Name;
					luaTable[num] = luaTable2;
					num++;
				}
				return luaTable;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x0024DEE8 File Offset: 0x0024C0E8
		[Attribute2]
		public LuaTable contacts
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				try
				{
					foreach (Contact contact in this.mySide.method_44())
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["guid"] = contact.string_0;
						luaTable2["name"] = contact.Name;
						luaTable[num] = luaTable2;
						num++;
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (string text in this.mySide.lazy_0.Value.Keys)
					{
						if (!this.mySide.method_44().Contains(this.mySide.lazy_0.Value[text]))
						{
							LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
							luaTable3["guid"] = this.mySide.lazy_0.Value[text].string_0;
							luaTable3["name"] = this.mySide.lazy_0.Value[text].Name;
							luaTable[num] = luaTable3;
							num++;
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
				return luaTable;
			}
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x0024E074 File Offset: 0x0024C274
		[Attribute2]
		public LuaTable unitsBy(string theUnitType)
		{
			GlobalVariables.ActiveUnitType activeUnitType = GlobalVariables.ActiveUnitType.None;
			LuaTable luaTable;
			int num;
			checked
			{
				if (!Information.IsNothing(theUnitType))
				{
					byte[] array = (byte[])Enum.GetValues(typeof(GlobalVariables.ActiveUnitType));
					int i = 0;
					while (i < array.Length)
					{
						byte b = array[i];
						if (Operators.CompareString(theUnitType.ToLower(), b.ToString().ToLower(), false) != 0)
						{
							string left = theUnitType.ToLower();
							GlobalVariables.ActiveUnitType activeUnitType2 = (GlobalVariables.ActiveUnitType)b;
							if (Operators.CompareString(left, activeUnitType2.ToString().ToLower(), false) != 0)
							{
								i++;
								continue;
							}
						}
						activeUnitType = (GlobalVariables.ActiveUnitType)b;
						break;
					}
				}
				luaTable = LuaSandBox.Singleton().CreateTable();
				num = 1;
			}
			foreach (ActiveUnit activeUnit in this.mySide.activeUnit_0)
			{
				if (activeUnitType == GlobalVariables.ActiveUnitType.None || activeUnitType == activeUnit.vmethod_56())
				{
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					luaTable2["guid"] = activeUnit.string_0;
					luaTable2["name"] = activeUnit.Name;
					luaTable[num] = luaTable2;
					num++;
				}
			}
			LuaTable result;
			if (luaTable.Keys.Count > 0)
			{
				result = luaTable;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x0024E198 File Offset: 0x0024C398
		[Attribute2]
		public LuaTable contactsBy(string theUnitType)
		{
			GlobalVariables.ActiveUnitType activeUnitType = GlobalVariables.ActiveUnitType.None;
			LuaTable luaTable;
			int num;
			checked
			{
				if (!Information.IsNothing(theUnitType))
				{
					byte[] array = (byte[])Enum.GetValues(typeof(GlobalVariables.ActiveUnitType));
					int i = 0;
					while (i < array.Length)
					{
						byte b = array[i];
						if (Operators.CompareString(theUnitType.ToLower(), b.ToString().ToLower(), false) != 0)
						{
							string left = theUnitType.ToLower();
							GlobalVariables.ActiveUnitType activeUnitType2 = (GlobalVariables.ActiveUnitType)b;
							if (Operators.CompareString(left, activeUnitType2.ToString().ToLower(), false) != 0)
							{
								i++;
								continue;
							}
						}
						activeUnitType = (GlobalVariables.ActiveUnitType)b;
						break;
					}
				}
				luaTable = LuaSandBox.Singleton().CreateTable();
				num = 1;
			}
			try
			{
				foreach (Contact contact in this.mySide.method_44())
				{
					if (activeUnitType == GlobalVariables.ActiveUnitType.None || activeUnitType == contact.activeUnit_0.vmethod_56())
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["guid"] = contact.string_0;
						luaTable2["name"] = contact.Name;
						luaTable[num] = luaTable2;
						num++;
					}
					try
					{
						foreach (string text in this.mySide.lazy_0.Value.Keys)
						{
							if (!this.mySide.method_44().Contains(this.mySide.lazy_0.Value[text]))
							{
								LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
								luaTable3["guid"] = this.mySide.lazy_0.Value[text].string_0;
								luaTable3["name"] = this.mySide.lazy_0.Value[text].Name;
								luaTable[num] = luaTable3;
								num++;
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
			}
			finally
			{
				List<Contact>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			LuaTable result;
			if (luaTable.Keys.Count > 0)
			{
				result = luaTable;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06002100 RID: 8448 RVA: 0x0024E3E8 File Offset: 0x0024C5E8
		[Attribute2]
		public LuaTable exclusionzones
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				try
				{
					foreach (ExclusionZone exclusionZone in this.mySide.list_6)
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["guid"] = exclusionZone.string_0;
						luaTable2["name"] = exclusionZone.Name;
						luaTable2["description"] = exclusionZone.string_2;
						luaTable[num] = luaTable2;
						num++;
					}
				}
				finally
				{
					List<ExclusionZone>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return luaTable;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x0024E49C File Offset: 0x0024C69C
		[Attribute2]
		public LuaTable nonavzones
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				try
				{
					foreach (NoNavZone noNavZone in this.mySide.list_7)
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["guid"] = noNavZone.string_0;
						luaTable2["name"] = noNavZone.Name;
						luaTable2["description"] = noNavZone.string_2;
						luaTable[num] = luaTable2;
						num++;
					}
				}
				finally
				{
					List<NoNavZone>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return luaTable;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06002102 RID: 8450 RVA: 0x0024E550 File Offset: 0x0024C750
		[Attribute2]
		public LuaTable rps
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				try
				{
					foreach (ReferencePoint referencePoint in this.mySide.vmethod_12())
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["guid"] = referencePoint.string_0;
						luaTable2["name"] = referencePoint.Name;
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
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x0024E5F4 File Offset: 0x0024C7F4
		[Attribute2]
		public LuaWrapper_Zone getexclusionzone(string ZoneIDorNameOrDescription)
		{
			Zone zone = null;
			try
			{
				foreach (ExclusionZone exclusionZone in this.mySide.list_6)
				{
					if (Operators.CompareString(exclusionZone.string_0, ZoneIDorNameOrDescription, false) == 0 || Operators.CompareString(exclusionZone.Name, ZoneIDorNameOrDescription, false) == 0 || Operators.CompareString(exclusionZone.string_2, ZoneIDorNameOrDescription, false) == 0)
					{
						zone = exclusionZone;
						break;
					}
				}
			}
			finally
			{
				List<ExclusionZone>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (Information.IsNothing(zone))
			{
				throw new Exception3("No exclusion zone exists with this name or ID.");
			}
			return new LuaWrapper_Zone(zone, this.ScenarioContext, this.mySide);
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x0024E6A0 File Offset: 0x0024C8A0
		[Attribute2]
		public LuaWrapper_Zone getnonavzone(string ZoneIDorNameOrDescription)
		{
			Zone zone = null;
			try
			{
				foreach (NoNavZone noNavZone in this.mySide.list_7)
				{
					if (Operators.CompareString(noNavZone.string_0, ZoneIDorNameOrDescription, false) == 0 || Operators.CompareString(noNavZone.Name, ZoneIDorNameOrDescription, false) == 0 || Operators.CompareString(noNavZone.string_2, ZoneIDorNameOrDescription, false) == 0)
					{
						zone = noNavZone;
						break;
					}
				}
			}
			finally
			{
				List<NoNavZone>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (Information.IsNothing(zone))
			{
				throw new Exception3("No no-navigation zone exists with this name or ID.");
			}
			return new LuaWrapper_Zone(zone, this.ScenarioContext, this.mySide);
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x000106DE File Offset: 0x0000E8DE
		[Attribute2]
		public Side.AwarenessLevel_Enum awareness
		{
			get
			{
				return this.mySide.method_28();
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x000106EB File Offset: 0x0000E8EB
		[Attribute2]
		public GlobalVariables.ProficiencyLevel proficiency
		{
			get
			{
				return this.mySide.method_24();
			}
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x0024E74C File Offset: 0x0024C94C
		[Attribute2]
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"side {\r\n guid = '",
				this.guid,
				"', \r\n name = '",
				this.name,
				"', \r\n units = '",
				this.units.ToString(),
				"', \r\n contacts = '",
				this.contacts.ToString(),
				"', \r\n"
			}) + "}";
		}

		// Token: 0x04001D0F RID: 7439
		private Side mySide;

		// Token: 0x04001D10 RID: 7440
		private Scenario ScenarioContext;
	}
}
