using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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
	// Token: 0x02000437 RID: 1079
	[Attribute1]
	[Attribute2]
	[Attribute3]
	public sealed class LuaWrapper_Contact
	{
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x0023AE5C File Offset: 0x0023905C
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

		// Token: 0x060020B4 RID: 8372 RVA: 0x000104DC File Offset: 0x0000E6DC
		public LuaWrapper_Contact(Contact theContact, Scenario theScen, Side fromSide)
		{
			this.myContact = theContact;
			this.ScenarioContext = theScen;
			this.fromSidePerspective = fromSide;
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x000104F9 File Offset: 0x0000E6F9
		[Attribute2]
		public object __obj
		{
			get
			{
				return this.myContact;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x00010501 File Offset: 0x0000E701
		[Attribute2]
		public string objectid
		{
			get
			{
				return this.guid;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x00010509 File Offset: 0x0000E709
		[Attribute2]
		public string guid
		{
			get
			{
				return this.myContact.string_0;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x00010516 File Offset: 0x0000E716
		// (set) Token: 0x060020B9 RID: 8377 RVA: 0x00010523 File Offset: 0x0000E723
		[Attribute2]
		public string name
		{
			get
			{
				return this.myContact.Name;
			}
			set
			{
				this.myContact.Name = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x0024C050 File Offset: 0x0024A250
		[Attribute2]
		public string actualunitid
		{
			get
			{
				string result;
				if (Information.IsNothing(this.myContact.activeUnit_0))
				{
					result = "";
				}
				else
				{
					result = this.myContact.activeUnit_0.string_0;
				}
				return result;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x0024C08C File Offset: 0x0024A28C
		[Attribute2]
		public double latitude
		{
			get
			{
				return this.myContact.vmethod_30(null);
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x0024C0B0 File Offset: 0x0024A2B0
		[Attribute2]
		public double longitude
		{
			get
			{
				return this.myContact.vmethod_28(null);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x0024C0D4 File Offset: 0x0024A2D4
		[Attribute2]
		public object speed
		{
			get
			{
				object result;
				if (this.myContact.bool_17)
				{
					result = this.myContact.vmethod_40();
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060020BE RID: 8382 RVA: 0x0024C104 File Offset: 0x0024A304
		[Attribute2]
		public object heading
		{
			get
			{
				object result;
				if (this.myContact.bool_18)
				{
					result = this.myContact.vmethod_9();
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x0024C134 File Offset: 0x0024A334
		[Attribute2]
		public object altitude
		{
			get
			{
				object result;
				if (this.myContact.bool_19)
				{
					result = this.myContact.vmethod_14(false);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060020C0 RID: 8384 RVA: 0x0024C168 File Offset: 0x0024A368
		// (set) Token: 0x060020C1 RID: 8385 RVA: 0x0024C1D8 File Offset: 0x0024A3D8
		[Attribute2]
		public string posture
		{
			get
			{
				string result;
				switch (this.myContact.method_130(this.myContact.side_1))
				{
				case Misc.PostureStance.Neutral:
					result = "N";
					break;
				case Misc.PostureStance.Friendly:
					result = "F";
					break;
				case Misc.PostureStance.Unfriendly:
					result = "U";
					break;
				case Misc.PostureStance.Hostile:
					result = "H";
					break;
				case Misc.PostureStance.Unknown:
					result = "X";
					break;
				default:
					result = "X";
					break;
				}
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "F", false) == 0)
				{
					this.myContact.method_131(this.myContact.side_1, false, Misc.PostureStance.Friendly);
					return;
				}
				if (Operators.CompareString(value, "H", false) == 0)
				{
					this.myContact.method_131(this.myContact.side_1, false, Misc.PostureStance.Hostile);
					return;
				}
				if (Operators.CompareString(value, "N", false) == 0)
				{
					this.myContact.method_131(this.myContact.side_1, false, Misc.PostureStance.Neutral);
					return;
				}
				if (Operators.CompareString(value, "U", false) == 0)
				{
					this.myContact.method_131(this.myContact.side_1, false, Misc.PostureStance.Unfriendly);
					return;
				}
				if (Operators.CompareString(value, "X", false) != 0)
				{
					throw new Exception3("Invalid posture code: " + value);
				}
				this.myContact.method_131(this.myContact.side_1, false, Misc.PostureStance.Unknown);
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x0024C2C0 File Offset: 0x0024A4C0
		[Attribute2]
		public LuaTable areaofuncertainty
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				if (!Information.IsNothing(this.myContact.method_112()))
				{
					try
					{
						foreach (GeoPoint geoPoint in this.myContact.method_112())
						{
							LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
							luaTable2["longitude"] = geoPoint.imethod_0();
							luaTable2["latitude"] = geoPoint.imethod_2();
							luaTable[num] = luaTable2;
							num++;
						}
					}
					finally
					{
						List<GeoPoint>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				return luaTable;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x00010531 File Offset: 0x0000E731
		[Attribute2]
		public string type
		{
			get
			{
				return this.myContact.method_56();
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x0001053E File Offset: 0x0000E73E
		[Attribute2]
		public int typed
		{
			get
			{
				return (int)this.myContact.contactType_0;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x0001054B File Offset: 0x0000E74B
		[Attribute2]
		public string type_description
		{
			get
			{
				return this.myContact.method_71();
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x0024C380 File Offset: 0x0024A580
		[Attribute2]
		public int actualunitdbid
		{
			get
			{
				int result;
				if (this.myContact.method_125() >= Contact_Base.IdentificationStatus.KnownClass && !Information.IsNothing(this.myContact.activeUnit_0))
				{
					result = this.myContact.activeUnit_0.DBID;
				}
				else
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x00010558 File Offset: 0x0000E758
		[Attribute2]
		public int classificationlevel
		{
			get
			{
				return (int)this.myContact.method_125();
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x0024C3C4 File Offset: 0x0024A5C4
		[Attribute2]
		public LuaTable potentialmatches
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				DataRow[] array = null;
				try
				{
					foreach (int num in this.myContact.method_70())
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["DBID"] = num;
						switch (this.myContact.contactType_0)
						{
						case Contact_Base.ContactType.Air:
							array = this.ScenarioContext.Cache_Aircraft_DT.Select("ID=" + Conversions.ToString(num));
							if (array != null && Enumerable.Count<DataRow>(array) > 0)
							{
								Aircraft aircraft = new Aircraft(ref this.ScenarioContext, null);
								DBFunctions.smethod_19(ref this.ScenarioContext, ref aircraft, num, false);
								luaTable2["TYPE"] = aircraft._AircraftType_0;
								luaTable2["SUBTYPE"] = aircraft.vmethod_57();
								luaTable2["CATEGORY"] = aircraft.enum40_0;
							}
							break;
						case Contact_Base.ContactType.Missile:
						case Contact_Base.ContactType.Torpedo:
							array = this.ScenarioContext.Cache_Weapons_DT.Select("ID=" + Conversions.ToString(num));
							if (array != null && Enumerable.Count<DataRow>(array) > 0)
							{
								Weapon weapon = Weapon.smethod_16(ref this.ScenarioContext, 0, null);
								DBFunctions.smethod_60(this.ScenarioContext.method_39(), weapon, num, this.ScenarioContext, true);
								luaTable2["TYPE"] = weapon.method_167();
								luaTable2["SUBTYPE"] = weapon.vmethod_57();
							}
							break;
						case Contact_Base.ContactType.Surface:
							array = this.ScenarioContext.Cache_Ships_DT.Select("ID=" + Conversions.ToString(num));
							if (array != null && Enumerable.Count<DataRow>(array) > 0)
							{
								Ship ship = new Ship(ref this.ScenarioContext, null);
								DBFunctions.smethod_53(ref this.ScenarioContext, ref ship, num, false);
								luaTable2["TYPE"] = ship._ShipType_0;
								luaTable2["SUBTYPE"] = ship.vmethod_57();
								luaTable2["CATEGORY"] = ship.enum118_0;
								luaTable2["MISSILE_DEFENCE"] = ship.short_5;
							}
							break;
						case Contact_Base.ContactType.Submarine:
							array = this.ScenarioContext.Cache_Subs_DT.Select("ID=" + Conversions.ToString(num));
							if (array != null && Enumerable.Count<DataRow>(array) > 0)
							{
								Submarine submarine = new Submarine(ref this.ScenarioContext, null);
								DBFunctions.smethod_55(ref this.ScenarioContext, ref submarine, num, false);
								luaTable2["TYPE"] = submarine._SubmarineType_0;
								luaTable2["SUBTYPE"] = submarine.vmethod_57();
								luaTable2["CATEGORY"] = submarine.enum120_0;
							}
							break;
						case Contact_Base.ContactType.Orbital:
							array = this.ScenarioContext.Cache_Satellites_DT.Select("ID=" + Conversions.ToString(num));
							if (array != null && Enumerable.Count<DataRow>(array) > 0)
							{
								Satellite satellite = new Satellite(ref this.ScenarioContext, null);
								DBFunctions.smethod_74(ref this.ScenarioContext, ref satellite, num, 0, true);
								luaTable2["TYPE"] = satellite._SatelliteType_0;
								luaTable2["SUBTYPE"] = satellite.vmethod_57();
								luaTable2["CATEGORY"] = satellite._SatelliteCategory_0;
							}
							break;
						case Contact_Base.ContactType.Facility_Fixed:
						case Contact_Base.ContactType.Facility_Mobile:
							array = this.ScenarioContext.Cache_Facilities_DT.Select("ID=" + Conversions.ToString(num));
							if (array != null && Enumerable.Count<DataRow>(array) > 0)
							{
								Facility facility = new Facility(ref this.ScenarioContext, null);
								DBFunctions.smethod_57(ref this.ScenarioContext, ref facility, num, false);
								luaTable2["SUBTYPE"] = facility.vmethod_57();
								luaTable2["CATEGORY"] = facility._FacilityCategory_0;
								luaTable2["MISSILE_DEFENCE"] = facility.int_8;
							}
							break;
						}
						if (array != null && Enumerable.Count<DataRow>(array) > 0)
						{
							luaTable2["NAME"] = Misc.smethod_9(array[0]["Name"].ToString());
						}
						luaTable[luaTable.Keys.Count + 1] = luaTable2;
					}
				}
				finally
				{
					List<int>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return luaTable;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x0024C890 File Offset: 0x0024AA90
		[Attribute2]
		public object side
		{
			get
			{
				object result;
				if (this.myContact.bool_12)
				{
					result = new LuaWrapper_Side(this.myContact.vmethod_7(false), this.ScenarioContext);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x00010565 File Offset: 0x0000E765
		[Attribute2]
		public object fromside
		{
			get
			{
				return new LuaWrapper_Side(this.fromSidePerspective, this.ScenarioContext);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x00010578 File Offset: 0x0000E778
		[Attribute2]
		public object detectedBySide
		{
			get
			{
				return new LuaWrapper_Side(this.myContact.side_1, this.ScenarioContext);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x0024C8C8 File Offset: 0x0024AAC8
		[Attribute2]
		public int missile_defence
		{
			get
			{
				int result;
				if (this.myContact.method_125() >= Contact_Base.IdentificationStatus.KnownClass && !Information.IsNothing(this.myContact.activeUnit_0))
				{
					Contact_Base.ContactType contactType_ = this.myContact.contactType_0;
					if (contactType_ != Contact_Base.ContactType.Surface)
					{
						if (contactType_ - Contact_Base.ContactType.Facility_Fixed > 1)
						{
							result = -1;
						}
						else
						{
							result = ((Facility)this.myContact.activeUnit_0).int_8;
						}
					}
					else
					{
						result = (int)((Ship)this.myContact.activeUnit_0).short_5;
					}
				}
				else
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x00010590 File Offset: 0x0000E790
		[Attribute2]
		public float age
		{
			get
			{
				return this.myContact.float_9;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x0024C944 File Offset: 0x0024AB44
		[Attribute2]
		public object BDA
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				if (!Information.IsNothing(this.myContact.method_78(this.fromSidePerspective)))
				{
					luaTable["FLOOD"] = Misc.smethod_53(this.myContact.method_78(this.fromSidePerspective));
				}
				if (!Information.IsNothing(this.myContact.method_76(this.fromSidePerspective)))
				{
					luaTable["FIRES"] = Misc.smethod_52(this.myContact.method_76(this.fromSidePerspective));
				}
				if (!Information.IsNothing(this.myContact.method_74(this.fromSidePerspective)))
				{
					luaTable["STRUCTURAL"] = Misc.smethod_54(this.myContact.method_74(this.fromSidePerspective));
				}
				object result;
				if (luaTable.Keys.Count == 0)
				{
					result = null;
				}
				else
				{
					result = luaTable;
				}
				return result;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x0024CA2C File Offset: 0x0024AC2C
		[Attribute2]
		public object emissions
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				object result;
				if (this.myContact.method_67())
				{
					List<int> list = Enumerable.ToList<int>(this.myContact.method_68().Keys);
					if (this.myContact.method_68().Count > 0)
					{
						try
						{
							foreach (int num in list)
							{
								LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
								EmissionContainer emissionContainer = this.myContact.method_68()[num];
								string value = emissionContainer.method_1(num, this.ScenarioContext);
								float float_ = emissionContainer.float_0;
								bool bool_ = emissionContainer.bool_1;
								luaTable2["Name"] = value;
								luaTable2["Age"] = float_;
								luaTable2["Solid"] = bool_;
								luaTable2["name"] = value;
								luaTable2["age"] = float_;
								luaTable2["solid"] = bool_;
								int int_ = num;
								SQLiteConnection sqliteConnection = this.ScenarioContext.method_39();
								Sensor sensor = DBFunctions.smethod_97(int_, ref sqliteConnection);
								luaTable2["sensor_dbid"] = sensor.DBID;
								luaTable2["sensor_name"] = sensor.Name;
								luaTable2["sensor_type"] = (short)sensor.sensor_Type_0;
								luaTable2["sensor_role"] = (long)sensor.sensor_Role_0;
								luaTable2["sensor_maxrange"] = sensor.float_0;
								luaTable[luaTable.Keys.Count + 1] = luaTable2;
							}
						}
						finally
						{
							List<int>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
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

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x0024CC20 File Offset: 0x0024AE20
		[Attribute2]
		public object detectionBy
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				if (!Information.IsNothing(this.myContact.nullable_14))
				{
					luaTable["Radar"] = this.myContact.nullable_14;
				}
				if (!Information.IsNothing(this.myContact.nullable_15))
				{
					luaTable["ESM"] = this.myContact.nullable_15;
				}
				if (!Information.IsNothing(this.myContact.nullable_16))
				{
					luaTable["Visual"] = this.myContact.nullable_16;
				}
				if (!Information.IsNothing(this.myContact.nullable_17))
				{
					luaTable["Infrared"] = this.myContact.nullable_17;
				}
				if (!Information.IsNothing(this.myContact.nullable_18))
				{
					luaTable["SonarActive"] = this.myContact.nullable_18;
				}
				if (!Information.IsNothing(this.myContact.nullable_19))
				{
					luaTable["SonarPassive"] = this.myContact.nullable_19;
				}
				object result;
				if (luaTable.Keys.Count == 0)
				{
					result = null;
				}
				else
				{
					result = luaTable;
				}
				return result;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x0024CD78 File Offset: 0x0024AF78
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
								if (array[i].activeUnit_0 == this.myContact.activeUnit_0 && !dictionary.ContainsValue(activeUnit.string_0))
								{
									dictionary.Add(dictionary.Count.ToString(), activeUnit.string_0);
								}
							}
							if (!Information.IsNothing(activeUnit.vmethod_86().vmethod_3()) && activeUnit.vmethod_86().vmethod_3().activeUnit_0 == this.myContact.activeUnit_0 && !dictionary.ContainsValue(activeUnit.string_0))
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

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x0024CEB8 File Offset: 0x0024B0B8
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
							if (!Information.IsNothing(contact) && this.myContact.activeUnit_0 == activeUnit2 && !dictionary.ContainsValue(contact.string_0))
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060020D3 RID: 8403 RVA: 0x0024CFA0 File Offset: 0x0024B1A0
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
							if (!Information.IsNothing(contact) && this.myContact == contact.activeUnit_0 && !dictionary.ContainsValue(activeUnit2.string_0))
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

		// Token: 0x060020D4 RID: 8404 RVA: 0x0001059D File Offset: 0x0000E79D
		[Attribute2]
		public object DropContact()
		{
			this.fromSidePerspective.method_15(this.myContact, ref this.ScenarioContext, true);
			return "ok";
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x000105BC File Offset: 0x0000E7BC
		// (set) Token: 0x060020D6 RID: 8406 RVA: 0x0024D088 File Offset: 0x0024B288
		[Attribute2]
		public object FilterOut
		{
			get
			{
				return this.myContact.bool_16;
			}
			set
			{
				bool? flag = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(value));
				if (flag != null)
				{
					this.myContact.bool_16 = flag.Value;
				}
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x0024D0BC File Offset: 0x0024B2BC
		[Attribute2]
		public LuaTable weather
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				LuaTable result;
				if (Information.IsNothing(this.longitude) & Information.IsNothing(this.longitude))
				{
					result = null;
				}
				else
				{
					float num = 0f;
					if (this.myContact.bool_19)
					{
						num = this.myContact.vmethod_14(false);
					}
					Weather.WeatherProfile weatherProfile = Weather.smethod_0(this.ScenarioContext, this.latitude, this.longitude, (int)Math.Round((double)num));
					luaTable["temp"] = weatherProfile.method_1(Weather.TTimeOfDayType.const_0);
					luaTable["rainfall"] = weatherProfile.float_0;
					luaTable["undercloud"] = weatherProfile.method_3();
					luaTable["seastate"] = weatherProfile.int_0;
					result = luaTable;
				}
				return result;
			}
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x0024D19C File Offset: 0x0024B39C
		[Attribute2]
		public bool inArea(LuaTable zone)
		{
			List<ReferencePoint> list = new List<ReferencePoint>();
			this.myContact.vmethod_7(false);
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
						LuaWrapper_Contact._Closure$__72-0 CS$<>8__locals1 = new LuaWrapper_Contact._Closure$__72-0(CS$<>8__locals1);
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
				return this.myContact.vmethod_46(list, this.ScenarioContext, false);
			}
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x0024D2EC File Offset: 0x0024B4EC
		[Attribute2]
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"contact {\r\n guid = '",
				this.guid,
				"', \r\n name = '",
				this.name,
				"', \r\n type = '",
				this.type.ToString(),
				"', \r\n"
			}) + "}";
		}

		// Token: 0x04001D05 RID: 7429
		private Contact myContact;

		// Token: 0x04001D06 RID: 7430
		private Scenario ScenarioContext;

		// Token: 0x04001D07 RID: 7431
		private Side fromSidePerspective;
	}
}
