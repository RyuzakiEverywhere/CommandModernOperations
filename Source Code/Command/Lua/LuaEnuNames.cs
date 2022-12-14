using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns14;

namespace Command_Core.Lua
{
	// Token: 0x0200042B RID: 1067
	[Attribute1]
	[Attribute2]
	[Attribute3]
	public sealed class LuaEnuNames
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x0023AE5C File Offset: 0x0023905C
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x00245988 File Offset: 0x00243B88
		[Attribute2]
		public LuaTable Condition_Air
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (byte b in (byte[])Enum.GetValues(typeof(Aircraft_AirOps._AirOpsCondition)))
				{
					LuaTable luaTable2 = luaTable;
					string field = b.ToString();
					Aircraft_AirOps._AirOpsCondition airOpsCondition = (Aircraft_AirOps._AirOpsCondition)b;
					luaTable2[field] = airOpsCondition.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06001FFA RID: 8186 RVA: 0x002459E8 File Offset: 0x00243BE8
		[Attribute2]
		public LuaTable Condition_Dock
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (byte b in (byte[])Enum.GetValues(typeof(ActiveUnit_DockingOps._DockingOpsCondition)))
				{
					LuaTable luaTable2 = luaTable;
					string field = b.ToString();
					ActiveUnit_DockingOps._DockingOpsCondition dockingOpsCondition = (ActiveUnit_DockingOps._DockingOpsCondition)b;
					luaTable2[field] = dockingOpsCondition.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x00245A48 File Offset: 0x00243C48
		[Attribute2]
		public LuaTable Throttle
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (byte b in (byte[])Enum.GetValues(typeof(ActiveUnit.Throttle)))
				{
					LuaTable luaTable2 = luaTable;
					string field = b.ToString();
					ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)b;
					luaTable2[field] = throttle.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06001FFC RID: 8188 RVA: 0x00245AA8 File Offset: 0x00243CA8
		[Attribute2]
		public LuaTable Depth
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (byte b in (byte[])Enum.GetValues(typeof(ActiveUnit_AI.SubmarineDepthPreset)))
				{
					LuaTable luaTable2 = luaTable;
					string field = b.ToString();
					ActiveUnit_AI.SubmarineDepthPreset submarineDepthPreset = (ActiveUnit_AI.SubmarineDepthPreset)b;
					luaTable2[field] = submarineDepthPreset.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x00245B08 File Offset: 0x00243D08
		[Attribute2]
		public LuaTable Altitude
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (byte b in (byte[])Enum.GetValues(typeof(ActiveUnit_AI.AircraftAltitudePreset)))
				{
					LuaTable luaTable2 = luaTable;
					string field = b.ToString();
					ActiveUnit_AI.AircraftAltitudePreset aircraftAltitudePreset = (ActiveUnit_AI.AircraftAltitudePreset)b;
					luaTable2[field] = aircraftAltitudePreset.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x00245B68 File Offset: 0x00243D68
		[Attribute2]
		public LuaTable ContactType
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (byte b in (byte[])Enum.GetValues(typeof(Contact_Base.ContactType)))
				{
					LuaTable luaTable2 = luaTable;
					string field = b.ToString();
					Contact_Base.ContactType contactType = (Contact_Base.ContactType)b;
					luaTable2[field] = contactType.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x00245BC8 File Offset: 0x00243DC8
		[Attribute2]
		public LuaTable Proficiency
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (int num in (int[])Enum.GetValues(typeof(GlobalVariables.ProficiencyLevel)))
				{
					LuaTable luaTable2 = luaTable;
					string field = num.ToString();
					GlobalVariables.ProficiencyLevel proficiencyLevel = (GlobalVariables.ProficiencyLevel)num;
					luaTable2[field] = proficiencyLevel.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x00245C28 File Offset: 0x00243E28
		[Attribute2]
		public LuaTable PatrolType
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (byte b in (byte[])Enum.GetValues(typeof(GlobalVariables.PatrolType)))
				{
					LuaTable luaTable2 = luaTable;
					string field = b.ToString();
					GlobalVariables.PatrolType patrolType = (GlobalVariables.PatrolType)b;
					luaTable2[field] = patrolType.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x00245C88 File Offset: 0x00243E88
		[Attribute2]
		public LuaTable StrikeType
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (int num in (int[])Enum.GetValues(typeof(Strike.StrikeType)))
				{
					LuaTable luaTable2 = luaTable;
					string field = num.ToString();
					Strike.StrikeType strikeType = (Strike.StrikeType)num;
					luaTable2[field] = strikeType.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x00245CE8 File Offset: 0x00243EE8
		[Attribute2]
		public LuaTable UnitType
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (byte b in (byte[])Enum.GetValues(typeof(GlobalVariables.ActiveUnitType)))
				{
					LuaTable luaTable2 = luaTable;
					string field = b.ToString();
					GlobalVariables.ActiveUnitType activeUnitType = (GlobalVariables.ActiveUnitType)b;
					luaTable2[field] = activeUnitType.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x00245D48 File Offset: 0x00243F48
		[Attribute2]
		public LuaTable FuelType
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (short num in (short[])Enum.GetValues(typeof(FuelRec._FuelType)))
				{
					LuaTable luaTable2 = luaTable;
					string field = num.ToString();
					FuelRec._FuelType fuelType = (FuelRec._FuelType)num;
					luaTable2[field] = fuelType.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x00245D48 File Offset: 0x00243F48
		[Attribute2]
		public LuaTable FuelState
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (short num in (short[])Enum.GetValues(typeof(FuelRec._FuelType)))
				{
					LuaTable luaTable2 = luaTable;
					string field = num.ToString();
					FuelRec._FuelType fuelType = (FuelRec._FuelType)num;
					luaTable2[field] = fuelType.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x00245DA8 File Offset: 0x00243FA8
		[Attribute2]
		public LuaTable guidanceType
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (byte b in (byte[])Enum.GetValues(typeof(Weapon.WeaponGuidanceType)))
				{
					LuaTable luaTable2 = luaTable;
					string field = b.ToString();
					Weapon.WeaponGuidanceType weaponGuidanceType = (Weapon.WeaponGuidanceType)b;
					luaTable2[field] = weaponGuidanceType.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x00245E08 File Offset: 0x00244008
		[Attribute2]
		public LuaTable sensorType
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (short num in (short[])Enum.GetValues(typeof(Sensor.Sensor_Type)))
				{
					LuaTable luaTable2 = luaTable;
					string field = num.ToString();
					Sensor.Sensor_Type sensor_Type = (Sensor.Sensor_Type)num;
					luaTable2[field] = sensor_Type.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06002007 RID: 8199 RVA: 0x00245E68 File Offset: 0x00244068
		[Attribute2]
		public LuaTable sensorRole
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (long num in (long[])Enum.GetValues(typeof(Sensor.Sensor_Role)))
				{
					LuaTable luaTable2 = luaTable;
					string field = num.ToString();
					Sensor.Sensor_Role sensor_Role = (Sensor.Sensor_Role)num;
					luaTable2[field] = sensor_Role.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x00245EC8 File Offset: 0x002440C8
		[Attribute2]
		public LuaTable warheadType
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (int num in (int[])Enum.GetValues(typeof(Warhead.WarheadType)))
				{
					LuaTable luaTable2 = luaTable;
					string field = num.ToString();
					Warhead.WarheadType warheadType = (Warhead.WarheadType)num;
					luaTable2[field] = warheadType.ToString();
				}
				return luaTable;
			}
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x00245F28 File Offset: 0x00244128
		[Attribute2]
		public LuaTable Doctrine(string type)
		{
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			string left = type.ToLower();
			if (Operators.CompareString(left, "fuelstate", false) != 0)
			{
				if (Operators.CompareString(left, "weaponstate", false) != 0)
				{
					if (Operators.CompareString(left, "rechargebattery", false) != 0)
					{
						if (Operators.CompareString(left, "wratargettype", false) == 0)
						{
							foreach (int num in (int[])Enum.GetValues(typeof(Doctrine._WRA_WeaponTargetType)))
							{
								LuaTable luaTable2 = luaTable;
								string field = num.ToString();
								Doctrine._WRA_WeaponTargetType wra_WeaponTargetType = (Doctrine._WRA_WeaponTargetType)num;
								luaTable2[field] = wra_WeaponTargetType.ToString();
							}
						}
					}
					else
					{
						foreach (int num2 in (int[])Enum.GetValues(typeof(Doctrine._RechargeBatteryPercentage)))
						{
							LuaTable luaTable3 = luaTable;
							string field2 = num2.ToString();
							Doctrine._RechargeBatteryPercentage rechargeBatteryPercentage = (Doctrine._RechargeBatteryPercentage)num2;
							luaTable3[field2] = rechargeBatteryPercentage.ToString();
						}
					}
				}
				else
				{
					foreach (int num3 in (int[])Enum.GetValues(typeof(Doctrine._WeaponState)))
					{
						LuaTable luaTable4 = luaTable;
						string field3 = num3.ToString();
						Doctrine._WeaponState weaponState = (Doctrine._WeaponState)num3;
						luaTable4[field3] = weaponState.ToString();
					}
				}
			}
			else
			{
				foreach (byte b in (byte[])Enum.GetValues(typeof(Doctrine._FuelState)))
				{
					LuaTable luaTable5 = luaTable;
					string field4 = b.ToString();
					Doctrine._FuelState fuelState = (Doctrine._FuelState)b;
					luaTable5[field4] = fuelState.ToString();
				}
			}
			return luaTable;
		}
	}
}
