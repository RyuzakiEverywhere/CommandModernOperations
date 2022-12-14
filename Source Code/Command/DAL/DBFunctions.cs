using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns12;
using ns13;
using ns14;
using ns9;

namespace Command_Core.DAL
{
	// Token: 0x0200039E RID: 926
	[StandardModule]
	public sealed class DBFunctions
	{
		// Token: 0x06001BFA RID: 7162 RVA: 0x001FDDF0 File Offset: 0x001FBFF0
		public static void smethod_0(ref DataTable dataTable_0, ref DataTable dataTable_1, ref DataTable dataTable_2, ref DataTable dataTable_3, ref DataTable dataTable_4, ref DataTable dataTable_5, ref SQLiteConnection sqliteConnection_0)
		{
			dataTable_0 = DBFunctions.smethod_1(sqliteConnection_0);
			dataTable_1 = DBFunctions.smethod_2(sqliteConnection_0);
			dataTable_2 = DBFunctions.smethod_3(sqliteConnection_0);
			dataTable_3 = DBFunctions.smethod_4(sqliteConnection_0);
			dataTable_5 = DBFunctions.smethod_6(sqliteConnection_0);
			try
			{
				dataTable_4 = DBFunctions.smethod_5(sqliteConnection_0);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200066", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x001FDE84 File Offset: 0x001FC084
		public static DataTable smethod_1(SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string text = "Select DataAircraft.ID, Name, Name || ' -- ' || EOC.Description || ' (' || EOS.Description || ')' ||  CASE WHEN YearCommissioned = '0' AND YearDecommissioned = '0' THEN '' ELSE ', ' END ||  CASE WHEN YearCommissioned = '0' THEN '' ELSE YearCommissioned END ||  CASE WHEN YearDecommissioned = '0' THEN '' ELSE '-' || YearDecommissioned END ||  CASE WHEN Comments = '-' THEN '' ELSE ', ' || Comments END as LongName, OperatorCountry, EOC.Description as CountryString, YearCommissioned, YearDecommissioned, Hypothetical, Type from DataAircraft, EnumOperatorCountry as EOC, EnumOperatorService as EOS where EOC.ID = DataAircraft.OperatorCountry and EOS.ID = DataAircraft.OperatorService and Type > 1001 ORDER BY Name, EOC.Description, EOS.Description, YearCommissioned";
			if (!DBFunctions.smethod_105(0, sqliteConnection_0))
			{
				text = text.Replace(", Hypothetical", "");
			}
			DataTable dataTable = Class401.smethod_1(class403_, text);
			if (!dataTable.Columns.Contains("Hypothetical"))
			{
				DataColumn dataColumn = new DataColumn("Hypothetical", typeof(short));
				dataColumn.DefaultValue = "0";
				dataTable.Columns.Add(dataColumn);
			}
			return dataTable;
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x001FDF00 File Offset: 0x001FC100
		public static DataTable smethod_2(SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string text = "SELECT DataShip.ID, Name, Name || ' -- ' || EOC.Description || ' (' || EOS.Description || ')' ||  CASE WHEN YearCommissioned = '0' AND YearDecommissioned = '0' THEN '' ELSE ', ' END ||  CASE WHEN YearCommissioned = '0' THEN '' ELSE YearCommissioned END ||  CASE WHEN YearDecommissioned = '0' THEN '' ELSE '-' || YearDecommissioned END ||  CASE WHEN Comments = '-' THEN '' ELSE ', ' || Comments END as LongName, OperatorCountry, EOC.Description as CountryString, YearCommissioned, YearDecommissioned, Hypothetical, Length, PhysicalSizeCode, Type from DataShip, EnumOperatorCountry as EOC, EnumOperatorService as EOS where EOC.ID = DataShip.OperatorCountry and EOS.ID = DataShip.OperatorService and Type > 1001 ORDER BY Name, EOC.Description, EOS.Description, YearCommissioned";
			if (!DBFunctions.smethod_105(0, sqliteConnection_0))
			{
				text = text.Replace(", Hypothetical", "");
			}
			DataTable dataTable = Class401.smethod_1(class403_, text);
			if (!dataTable.Columns.Contains("Hypothetical"))
			{
				DataColumn dataColumn = new DataColumn("Hypothetical", typeof(short));
				dataColumn.DefaultValue = "0";
				dataTable.Columns.Add(dataColumn);
			}
			return dataTable;
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x001FDF7C File Offset: 0x001FC17C
		public static DataTable smethod_3(SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string text = "SELECT DataSubmarine.ID, Name, Name || ' -- ' || EOC.Description || ' (' || EOS.Description || ')' ||  CASE WHEN YearCommissioned = '0' AND YearDecommissioned = '0' THEN '' ELSE ', ' END ||  CASE WHEN YearCommissioned = '0' THEN '' ELSE YearCommissioned END ||  CASE WHEN YearDecommissioned = '0' THEN '' ELSE '-' || YearDecommissioned END ||  CASE WHEN Comments = '-' THEN '' ELSE ', ' || Comments END as LongName, OperatorCountry, EOC.Description as CountryString, YearCommissioned, YearDecommissioned, Hypothetical, Length, PhysicalSizeCode, Type from DataSubmarine, EnumOperatorCountry as EOC, EnumOperatorService as EOS where EOC.ID = DataSubmarine.OperatorCountry and EOS.ID = DataSubmarine.OperatorService and Type > 1001 ORDER BY Name, EOC.Description, EOS.Description, YearCommissioned";
			if (!DBFunctions.smethod_105(0, sqliteConnection_0))
			{
				text = text.Replace(", Hypothetical", "");
			}
			DataTable dataTable = Class401.smethod_1(class403_, text);
			if (!dataTable.Columns.Contains("Hypothetical"))
			{
				DataColumn dataColumn = new DataColumn("Hypothetical", typeof(short));
				dataColumn.DefaultValue = "0";
				dataTable.Columns.Add(dataColumn);
			}
			return dataTable;
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x001FDFF8 File Offset: 0x001FC1F8
		public static DataTable smethod_4(SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string text = "SELECT DataFacility.ID, Name, Name || ' -- ' || EOC.Description || ' (' || EOS.Description || ')' ||  CASE WHEN YearCommissioned = '0' AND YearDecommissioned = '0' THEN '' ELSE ', ' END ||  CASE WHEN YearCommissioned = '0' THEN '' ELSE YearCommissioned END ||  CASE WHEN YearDecommissioned = '0' THEN '' ELSE '-' || YearDecommissioned END ||  CASE WHEN Comments = '-' THEN '' ELSE ', ' || Comments END as LongName , OperatorCountry, EOC.Description as CountryString, YearCommissioned, YearDecommissioned, Hypothetical, Category from DataFacility, EnumOperatorCountry as EOC, EnumOperatorService as EOS where EOC.ID = DataFacility.OperatorCountry and EOS.ID = DataFacility.OperatorService ORDER BY Name, EOC.Description, EOS.Description, YearCommissioned";
			if (!DBFunctions.smethod_105(0, sqliteConnection_0))
			{
				text = text.Replace(", Hypothetical", "");
			}
			DataTable dataTable = Class401.smethod_1(class403_, text);
			if (!dataTable.Columns.Contains("Hypothetical"))
			{
				DataColumn dataColumn = new DataColumn("Hypothetical", typeof(short));
				dataColumn.DefaultValue = "0";
				dataTable.Columns.Add(dataColumn);
			}
			return dataTable;
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x001FE074 File Offset: 0x001FC274
		public static DataTable smethod_5(SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string text = "SELECT DataSatellite.ID, Name, Name || ' -- ' || EOC.Description || ' (' || EOS.Description || ')' ||  CASE WHEN YearCommissioned = '0' AND YearDecommissioned = '0' THEN '' ELSE ', ' END ||  CASE WHEN YearCommissioned = '0' THEN '' ELSE YearCommissioned END ||  CASE WHEN YearDecommissioned = '0' THEN '' ELSE '-' || YearDecommissioned END ||  CASE WHEN Comments = '-' THEN '' ELSE ', ' || Comments END as LongName, EnumSatelliteType.Description as TypeString, OperatorCountry, EOC.Description as CountryString, YearCommissioned, YearDecommissioned, Hypothetical, Type from DataSatellite, EnumSatelliteType, EnumOperatorCountry as EOC, EnumOperatorService as EOS where EnumSatelliteType.ID = DataSatellite.Type and EOC.ID = DataSatellite.OperatorCountry and EOS.ID = DataSatellite.OperatorService ORDER BY Name, EOC.Description, EOS.Description, YearCommissioned";
			if (!DBFunctions.smethod_105(0, sqliteConnection_0))
			{
				text = text.Replace(", Hypothetical", "");
			}
			DataTable dataTable = Class401.smethod_1(class403_, text);
			if (!dataTable.Columns.Contains("Hypothetical"))
			{
				DataColumn dataColumn = new DataColumn("Hypothetical", typeof(short));
				dataColumn.DefaultValue = "0";
				dataTable.Columns.Add(dataColumn);
			}
			return dataTable;
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x001FE0F0 File Offset: 0x001FC2F0
		public static DataTable smethod_6(SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string text = "SELECT ID, Name, Name ||  CASE WHEN Comments = '-' THEN '' ELSE ' -- ' || Comments END as LongName, Type, Hypothetical from DataWeapon where Type > 1001";
			if (!DBFunctions.smethod_105(0, sqliteConnection_0))
			{
				text = text.Replace(", Hypothetical", "");
			}
			DataTable dataTable = Class401.smethod_1(class403_, text);
			if (!dataTable.Columns.Contains("Hypothetical"))
			{
				DataColumn dataColumn = new DataColumn("Hypothetical", typeof(short));
				dataColumn.DefaultValue = "0";
				dataTable.Columns.Add(dataColumn);
			}
			return dataTable;
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x001FE16C File Offset: 0x001FC36C
		public static DataTable smethod_7(int int_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "Select * from DataSatelliteOrbits where ID=" + Conversions.ToString(int_0) + " AND Operational <>0";
			return Class401.smethod_1(class403_, string_);
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x001FE19C File Offset: 0x001FC39C
		public static DataTable smethod_8(ref SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "SELECT ID, Description from EnumOperatorCountry ORDER BY CASE WHEN ID >= 2000 THEN Description END ASC, CASE WHEN ID < 2000 THEN ID END ASC ";
			return Class401.smethod_1(class403_, string_);
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x001FE1BC File Offset: 0x001FC3BC
		public static int smethod_9(List<int> list_0, GlobalVariables.ActiveUnitType activeUnitType_0, SQLiteConnection sqliteConnection_0)
		{
			string text = "";
			switch (activeUnitType_0)
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				text = "DataAircraft";
				goto IL_5E;
			case GlobalVariables.ActiveUnitType.Ship:
				text = "DataShip";
				goto IL_5E;
			case GlobalVariables.ActiveUnitType.Submarine:
				text = "DataSubmarine";
				goto IL_5E;
			case GlobalVariables.ActiveUnitType.Facility:
				text = "DataFacility";
				goto IL_5E;
			case GlobalVariables.ActiveUnitType.Weapon:
				text = "DataWeapon";
				goto IL_5E;
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			IL_5E:
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = string.Concat(new string[]
			{
				"SELECT COUNT(DISTINCT Name) FROM ",
				text,
				" where ID in (",
				string.Join<int>(",", list_0.ToArray()),
				")"
			});
			return Conversions.ToInteger(Class401.smethod_2(class403_, string_));
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x001FE278 File Offset: 0x001FC478
		public static List<int> smethod_10(List<int> list_0, GlobalVariables.ActiveUnitType activeUnitType_0, Scenario scenario_0, SQLiteConnection sqliteConnection_0)
		{
			List<int> result;
			try
			{
				List<int> list = new List<int>();
				if (list_0.Count == 0)
				{
					result = list;
				}
				else
				{
					list_0 = Enumerable.ToList<int>(Enumerable.OrderBy<int, int>(list_0, (DBFunctions._Closure$__.$I14-0 == null) ? (DBFunctions._Closure$__.$I14-0 = new Func<int, int>(DBFunctions._Closure$__.$I.method_0)) : DBFunctions._Closure$__.$I14-0));
					Class403 class403_ = new Class403(sqliteConnection_0);
					string string_ = "EmitterIDs_" + activeUnitType_0.ToString() + "_" + string.Join<int>("_", list_0);
					object objectValue = RuntimeHelpers.GetObjectValue(Class401.smethod_3(class403_, string_));
					if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue)))
					{
						HashSet<int> hashSet = new HashSet<int>();
						try
						{
							foreach (ActiveUnit activeUnit in scenario_0.method_42())
							{
								if (!Information.IsNothing(activeUnit) && activeUnit.vmethod_43() && activeUnit.vmethod_56() == activeUnitType_0)
								{
									hashSet.Add(activeUnit.DBID);
								}
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (hashSet.Count == 0)
						{
							result = list;
						}
						else
						{
							new List<int>();
							DataTable dataTable = null;
							int count = list_0.Count;
							switch (activeUnitType_0)
							{
							case GlobalVariables.ActiveUnitType.Aircraft:
								dataTable = DBFunctions.smethod_1(sqliteConnection_0);
								break;
							case GlobalVariables.ActiveUnitType.Ship:
								dataTable = DBFunctions.smethod_2(sqliteConnection_0);
								break;
							case GlobalVariables.ActiveUnitType.Submarine:
								dataTable = DBFunctions.smethod_3(sqliteConnection_0);
								break;
							case GlobalVariables.ActiveUnitType.Facility:
								dataTable = DBFunctions.smethod_4(sqliteConnection_0);
								break;
							case GlobalVariables.ActiveUnitType.Weapon:
								dataTable = DBFunctions.smethod_6(sqliteConnection_0);
								break;
							case GlobalVariables.ActiveUnitType.Satellite:
								dataTable = DBFunctions.smethod_5(sqliteConnection_0);
								break;
							}
							try
							{
								foreach (object obj in dataTable.Rows)
								{
									int num = Conversions.ToInteger(((DataRow)obj)["ID"]);
									if (hashSet.Contains(num))
									{
										List<int> list2 = DBFunctions.smethod_11(activeUnitType_0, num, sqliteConnection_0);
										if (Enumerable.Count<int>(Enumerable.Intersect<int>(list_0, list2)) == count)
										{
											list.Add(num);
										}
									}
								}
							}
							finally
							{
								IEnumerator enumerator2;
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
							Class401.smethod_4(class403_, string_, list);
							result = list;
						}
					}
					else
					{
						result = (List<int>)objectValue;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101082", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<int>();
			}
			return result;
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x001FE520 File Offset: 0x001FC720
		public static List<int> smethod_11(GlobalVariables.ActiveUnitType activeUnitType_0, int int_0, SQLiteConnection sqliteConnection_0)
		{
			string text = "";
			string text2 = "";
			Class403 class403_ = new Class403(sqliteConnection_0);
			switch (activeUnitType_0)
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				text = "DataAircraftSensors";
				text2 = "DataAircraftMounts";
				break;
			case GlobalVariables.ActiveUnitType.Ship:
				text = "DataShipSensors";
				text2 = "DataShipMounts";
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				text = "DataSubmarineSensors";
				text2 = "DataSubmarineMounts";
				break;
			case GlobalVariables.ActiveUnitType.Facility:
				text = "DataFacilitySensors";
				text2 = "DataFacilityMounts";
				break;
			case GlobalVariables.ActiveUnitType.Weapon:
				text = "DataWeaponSensors";
				break;
			case GlobalVariables.ActiveUnitType.Satellite:
				text = "DataSatelliteSensors";
				text2 = "DataSatelliteMounts";
				break;
			}
			string string_ = "Select DataSensor.ID as SensorID, DataSensor.Type as SensorType, DataSensor.MasqueradeAs from DataSensor, " + text + " as theTable where DataSensor.ID = theTable.ComponentID and theTable.ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			DataTable dataTable2;
			if (!string.IsNullOrEmpty(text2))
			{
				string_ = string.Concat(new string[]
				{
					"SELECT DataSensor.ID as SensorID, DataSensor.Type as SensorType, DataSensor.MasqueradeAs from DataSensor, DataMountSensors, ",
					text2,
					" where DataSensor.ID = DataMountSensors.ComponentID and DataMountSensors.ID = ",
					text2,
					".ComponentID and ",
					text2,
					".ID = ",
					Conversions.ToString(int_0)
				});
				dataTable2 = Class401.smethod_1(class403_, string_);
				if (dataTable2.Rows.Count > 0)
				{
					dataTable.Merge(dataTable2);
				}
			}
			string_ = string.Concat(new string[]
			{
				"SELECT DataSensor.ID as SensorID, DataSensor.Type as SensorType, DataSensor.MasqueradeAs from DataSensor, DataSensorSensorGroups, ",
				text,
				" where ",
				text,
				".ID = ",
				Conversions.ToString(int_0),
				" And DataSensorSensorGroups.ID = ",
				text,
				".ComponentID And DataSensor.ID = DataSensorSensorGroups.ComponentID"
			});
			dataTable2 = Class401.smethod_1(class403_, string_);
			if (dataTable2.Rows.Count > 0)
			{
				dataTable.Merge(dataTable2);
			}
			HashSet<int> hashSet = new HashSet<int>();
			List<int> result;
			if (dataTable.Rows.Count == 0)
			{
				result = Enumerable.ToList<int>(hashSet);
			}
			else
			{
				try
				{
					try
					{
						foreach (object obj in dataTable.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							if (Misc.smethod_17((Sensor.Sensor_Type)Conversions.ToShort(dataRow["SensorType"])))
							{
								if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["MasqueradeAs"])))
								{
									if (Conversions.ToInteger(dataRow["MasqueradeAs"]) != 1001)
									{
										hashSet.Add(Conversions.ToInteger(dataRow["MasqueradeAs"]));
										continue;
									}
								}
								hashSet.Add(Conversions.ToInteger(dataRow["SensorID"]));
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200067", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					return Enumerable.ToList<int>(hashSet);
				}
				result = Enumerable.ToList<int>(hashSet);
			}
			return result;
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x001FE800 File Offset: 0x001FCA00
		public static int smethod_12(string string_0, GlobalVariables.ActiveUnitType activeUnitType_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "";
			switch (activeUnitType_0)
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				string_ = "SELECT ID FROM DataAircraft where Name = '" + string_0 + "'";
				break;
			case GlobalVariables.ActiveUnitType.Ship:
				string_ = "SELECT ID FROM DataShip where Name = '" + string_0 + "'";
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				string_ = "SELECT ID FROM DataSubmarine where Name = '" + string_0 + "'";
				break;
			case GlobalVariables.ActiveUnitType.Facility:
				string_ = "SELECT ID FROM DataFacility where Name = '" + string_0 + "'";
				break;
			case GlobalVariables.ActiveUnitType.Weapon:
				string_ = "SELECT ID FROM DataWeapon where Name = '" + string_0 + "'";
				break;
			}
			return Conversions.ToInteger(Class401.smethod_2(class403_, string_));
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x001FE8A8 File Offset: 0x001FCAA8
		public static List<float> smethod_13(int int_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			List<float> list = new List<float>();
			try
			{
				string string_ = "Select NumberOfEngines, ThrustPerEngineMilitary, ThrustPerEngineAfterburner, SFCMilitary, SFCAfterburner from DataPropulsion where ID=" + Conversions.ToString(int_0);
				DataTable dataTable = Class401.smethod_1(class403_, string_);
				if (dataTable.Rows.Count == 0)
				{
					return list;
				}
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						list.Add(Conversions.ToSingle(dataRow["NumberOfEngines"]));
						list.Add(Conversions.ToSingle(dataRow["ThrustPerEngineMilitary"]));
						list.Add(Conversions.ToSingle(dataRow["ThrustPerEngineAfterburner"]));
						list.Add(Conversions.ToSingle(dataRow["SFCMilitary"]));
						list.Add(Conversions.ToSingle(dataRow["SFCAfterburner"]));
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200068", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return list;
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x001FEA0C File Offset: 0x001FCC0C
		public static List<float> smethod_14(int int_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			List<float> list = new List<float>();
			try
			{
				string string_ = "Select TorpedoSpeedCruise, TorpedoRangeCruise, TorpedoSpeedFull, TorpedoRangeFull from DataWeapon where ID=" + Conversions.ToString(int_0);
				DataTable dataTable = Class401.smethod_1(class403_, string_);
				if (dataTable.Rows.Count == 0)
				{
					return list;
				}
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						list.Add(Conversions.ToSingle(dataRow["TorpedoSpeedCruise"]));
						list.Add(Conversions.ToSingle(dataRow["TorpedoRangeCruise"]));
						list.Add(Conversions.ToSingle(dataRow["TorpedoSpeedFull"]));
						list.Add(Conversions.ToSingle(dataRow["TorpedoRangeFull"]));
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200069", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return list;
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x001FEB50 File Offset: 0x001FCD50
		public static void smethod_15(GlobalVariables.ActiveUnitType activeUnitType_0, int int_0, SQLiteConnection sqliteConnection_0, ref int int_1, ref int int_2, ref int int_3)
		{
			if (activeUnitType_0 != GlobalVariables.ActiveUnitType.Weapon)
			{
				string str = "";
				Class403 class403_ = new Class403(sqliteConnection_0);
				switch (activeUnitType_0)
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					str = "DataAircraft";
					break;
				case GlobalVariables.ActiveUnitType.Ship:
					str = "DataShip";
					break;
				case GlobalVariables.ActiveUnitType.Submarine:
					str = "DataSubmarine";
					break;
				case GlobalVariables.ActiveUnitType.Facility:
					str = "DataFacility";
					break;
				case GlobalVariables.ActiveUnitType.Satellite:
					str = "DataSatellite";
					break;
				}
				try
				{
					string string_ = "SELECT OODADetectionCycle, OODATargetingCycle, OODAEvasiveCycle FROM " + str + " where ID = " + Conversions.ToString(int_0);
					DataTable dataTable = Class401.smethod_1(class403_, string_);
					try
					{
						foreach (object obj in dataTable.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							int_1 = Conversions.ToInteger(dataRow["OODADetectionCycle"]);
							int_2 = Conversions.ToInteger(dataRow["OODATargetingCycle"]);
							int_3 = Conversions.ToInteger(dataRow["OODAEvasiveCycle"]);
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex)
				{
					string string_ = "SELECT  OODATargetingCycle, OODAEvasiveCycle FROM " + str + " where ID = " + Conversions.ToString(int_0);
					DataTable dataTable = Class401.smethod_1(class403_, string_);
					try
					{
						foreach (object obj2 in dataTable.Rows)
						{
							DataRow dataRow2 = (DataRow)obj2;
							int_1 = 15;
							int_2 = Conversions.ToInteger(dataRow2["OODATargetingCycle"]);
							int_3 = Conversions.ToInteger(dataRow2["OODAEvasiveCycle"]);
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x001FED1C File Offset: 0x001FCF1C
		public static List<string> smethod_16(GlobalVariables.ActiveUnitType activeUnitType_0, int int_0, SQLiteConnection sqliteConnection_0)
		{
			string text = "";
			string text2 = "";
			Class403 class403_ = new Class403(sqliteConnection_0);
			List<string> list = new List<string>();
			switch (activeUnitType_0)
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				text = "DataAircraftCodes";
				text2 = "EnumAircraftCode";
				break;
			case GlobalVariables.ActiveUnitType.Ship:
				text = "DataShipCodes";
				text2 = "EnumShipCode";
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				text = "DataSubmarineCodes";
				text2 = "EnumSubmarineCode";
				break;
			case GlobalVariables.ActiveUnitType.Weapon:
				text = "DataWeaponCodes";
				text2 = "EnumWeaponCode";
				break;
			case GlobalVariables.ActiveUnitType.Satellite:
				text = "DataSatelliteCodes";
				text2 = "EnumSatelliteCode";
				break;
			}
			string string_ = string.Concat(new string[]
			{
				"SELECT EC.* from ",
				text2,
				" as EC, ",
				text,
				" as DC where EC.ID = DC.CodeID and DC.ID = ",
				Conversions.ToString(int_0)
			});
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			List<string> result;
			if (dataTable.Rows.Count == 0)
			{
				result = list;
			}
			else
			{
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						list.Add(Conversions.ToString(dataRow["Description"]));
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x001FEE70 File Offset: 0x001FD070
		public static string smethod_17(CommDevice.CommLinkType commLinkType_0, Scenario scenario_0)
		{
			Class403 class403_ = new Class403(scenario_0.method_39());
			string string_ = "Select Description from EnumCommType where ID=" + Conversions.ToString((int)commLinkType_0);
			return Class401.smethod_2(class403_, string_);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x001FEEA0 File Offset: 0x001FD0A0
		public static string smethod_18(XSection.Enum132 enum132_0, Scenario scenario_0)
		{
			Class403 class403_ = new Class403(scenario_0.method_39());
			string string_ = "Select Description from EnumSignatureType where ID=" + Conversions.ToString((int)enum132_0);
			return Class401.smethod_2(class403_, string_);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x001FEED0 File Offset: 0x001FD0D0
		public static void smethod_19(ref Scenario theScen, ref Aircraft theAircraft, int AircraftDBID, bool LoadComponents = true)
		{
			Class403 class403_ = new Class403(theScen.method_39());
			string string_ = "Select * from DataAircraft where ID = " + Conversions.ToString(AircraftDBID);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception("No aircraft with ID: " + Conversions.ToString(AircraftDBID) + " was found in the current database!");
			}
			DataRow dataRow = dataTable.Rows[0];
			if (!dataTable.Columns.Contains("OODADetectionCycle"))
			{
				dataTable.Columns.Add("OODADetectionCycle", typeof(string));
				dataRow["OODADetectionCycle"] = 0;
			}
			if (!dataTable.Columns.Contains("OODATargetingCycle"))
			{
				dataTable.Columns.Add("OODATargetingCycle", typeof(string));
				dataRow["OODATargetingCycle"] = 0;
			}
			if (!dataTable.Columns.Contains("OODAEvasiveCycle"))
			{
				dataTable.Columns.Add("OODAEvasiveCycle", typeof(string));
				dataRow["OODAEvasiveCycle"] = 0;
			}
			theAircraft.enum40_0 = (Aircraft.Enum40)Conversions.ToShort(dataRow["Category"]);
			theAircraft._AircraftType_0 = (Aircraft._AircraftType)Conversions.ToInteger(dataRow["Type"]);
			theAircraft.DBID = AircraftDBID;
			theAircraft.string_2 = Strings.Trim(Conversions.ToString(dataRow["Name"]));
			theAircraft.method_159().vmethod_15(true, Conversions.ToSingle(dataRow["ClimbRate"].ToString()));
			theAircraft.float_25 = Conversions.ToSingle(dataRow["Agility"].ToString());
			theAircraft.float_13 = Conversions.ToSingle(dataRow["Length"].ToString());
			theAircraft.int_0 = Conversions.ToInteger(dataRow["WeightEmpty"].ToString());
			theAircraft.int_1 = Conversions.ToInteger(dataRow["WeightMax"].ToString());
			theAircraft.int_2 = Conversions.ToInteger(dataRow["WeightPayload"].ToString());
			theAircraft.float_27 = Conversions.ToSingle(dataRow["Span"].ToString());
			theAircraft.float_28 = Conversions.ToSingle(dataRow["Height"].ToString());
			theAircraft.int_6 = Conversions.ToInteger(dataRow["Crew"].ToString());
			theAircraft.int_7 = Conversions.ToInteger(dataRow["TotalEndurance"].ToString());
			theAircraft.enum40_0 = (Aircraft.Enum40)Conversions.ToShort(dataRow["Category"]);
			theAircraft.enum146_0 = (GlobalVariables.Enum146)Conversions.ToInteger(dataRow["RunwayLengthCode"]);
			int num = Conversions.ToInteger(dataRow["PhysicalSizeCode"]);
			if (num != 1001)
			{
				switch (num)
				{
				case 2001:
					theAircraft.aircraftSizeClass_0 = GlobalVariables.AircraftSizeClass.Small;
					break;
				case 2002:
					theAircraft.aircraftSizeClass_0 = GlobalVariables.AircraftSizeClass.Medium;
					break;
				case 2003:
					theAircraft.aircraftSizeClass_0 = GlobalVariables.AircraftSizeClass.Large;
					break;
				case 2004:
					theAircraft.aircraftSizeClass_0 = GlobalVariables.AircraftSizeClass.VLarge;
					break;
				default:
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					break;
				}
			}
			else
			{
				theAircraft.aircraftSizeClass_0 = GlobalVariables.AircraftSizeClass.None;
			}
			if (dataTable.Columns.Contains("DamagePoints") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DamagePoints"])) && Conversions.ToInteger(dataRow["DamagePoints"]) != 0)
			{
				theAircraft.method_61(Conversions.ToInteger(dataRow["DamagePoints"]));
				theAircraft.vmethod_64(true, null, (float)theAircraft.method_60());
			}
			else if (theAircraft.method_144())
			{
				theAircraft.method_61(Aircraft.smethod_12((int)Math.Round((double)theAircraft.float_13)));
				theAircraft.vmethod_64(true, null, (float)theAircraft.method_60());
			}
			else
			{
				switch (theAircraft.aircraftSizeClass_0)
				{
				case GlobalVariables.AircraftSizeClass.Small:
					theAircraft.method_61(3);
					break;
				case GlobalVariables.AircraftSizeClass.Medium:
					theAircraft.method_61(5);
					break;
				case GlobalVariables.AircraftSizeClass.Large:
					theAircraft.method_61(10);
					break;
				case GlobalVariables.AircraftSizeClass.VLarge:
					theAircraft.method_61(20);
					break;
				default:
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					break;
				}
				theAircraft.vmethod_64(true, null, (float)theAircraft.method_60());
			}
			if (dataTable.Columns.Contains("Visibility"))
			{
				theScen.FeatureCompatibility.CockpitVisibility = true;
				try
				{
					string[] array;
					if (dataRow["Visibility"].ToString().Contains(","))
					{
						array = dataRow["Visibility"].ToString().Split(Conversions.ToCharArrayRankOne(","));
					}
					else
					{
						array = dataRow["Visibility"].ToString().Split(Conversions.ToCharArrayRankOne("."));
					}
					string left = array[0];
					if (Operators.CompareString(left, "A", false) != 0)
					{
						if (Operators.CompareString(left, "B", false) != 0)
						{
							if (Operators.CompareString(left, "C", false) == 0)
							{
								theAircraft.enum38_0 = Aircraft.Enum38.const_3;
							}
						}
						else
						{
							theAircraft.enum38_0 = Aircraft.Enum38.const_2;
						}
					}
					else
					{
						theAircraft.enum38_0 = Aircraft.Enum38.const_1;
					}
					string left2 = array[1];
					if (Operators.CompareString(left2, "A", false) != 0)
					{
						if (Operators.CompareString(left2, "B", false) != 0)
						{
							if (Operators.CompareString(left2, "C", false) == 0)
							{
								theAircraft.enum38_1 = Aircraft.Enum38.const_3;
							}
						}
						else
						{
							theAircraft.enum38_1 = Aircraft.Enum38.const_2;
						}
					}
					else
					{
						theAircraft.enum38_1 = Aircraft.Enum38.const_1;
					}
					string left3 = array[2];
					if (Operators.CompareString(left3, "A", false) != 0)
					{
						if (Operators.CompareString(left3, "B", false) != 0)
						{
							if (Operators.CompareString(left3, "C", false) == 0)
							{
								theAircraft.enum38_2 = Aircraft.Enum38.const_3;
							}
						}
						else
						{
							theAircraft.enum38_2 = Aircraft.Enum38.const_2;
						}
					}
					else
					{
						theAircraft.enum38_2 = Aircraft.Enum38.const_1;
					}
				}
				catch (Exception ex)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
			if (dataTable.Columns.Contains("FuelOffloadRate") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["FuelOffloadRate"])))
			{
				theAircraft.float_29 = Conversions.ToSingle(dataRow["FuelOffloadRate"]);
			}
			if (dataTable.Columns.Contains("AircraftEngineArmor") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AircraftEngineArmor"])))
			{
				theAircraft.armorRating_2 = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["AircraftEngineArmor"]);
			}
			else
			{
				theAircraft.armorRating_2 = GlobalVariables.ArmorRating.None;
			}
			if (dataTable.Columns.Contains("AircraftCockpitArmor") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AircraftCockpitArmor"])))
			{
				theAircraft.armorRating_0 = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["AircraftCockpitArmor"]);
			}
			else
			{
				theAircraft.armorRating_0 = GlobalVariables.ArmorRating.None;
			}
			if (dataTable.Columns.Contains("AircraftFuselageArmor") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["AircraftFuselageArmor"])))
			{
				theAircraft.armorRating_1 = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["AircraftFuselageArmor"]);
			}
			else
			{
				theAircraft.armorRating_1 = GlobalVariables.ArmorRating.None;
			}
			theAircraft.short_0 = Conversions.ToShort(dataRow["OODADetectionCycle"].ToString());
			theAircraft.short_1 = Conversions.ToShort(dataRow["OODATargetingCycle"].ToString());
			theAircraft.short_2 = Conversions.ToShort(dataRow["OODAEvasiveCycle"].ToString());
			theAircraft.int_3 = Conversions.ToInteger(dataRow["OperatorCountry"].ToString());
			try
			{
				theAircraft.bool_23 = Conversions.ToBoolean(dataRow["Hypothetical"]);
			}
			catch (Exception ex2)
			{
			}
			Aircraft aircraft = theAircraft;
			DBFunctions.smethod_36(ref aircraft, AircraftDBID);
			if (LoadComponents)
			{
				DBFunctions.smethod_99(theAircraft, AircraftDBID);
				DBFunctions.smethod_87(theAircraft, AircraftDBID);
				ActiveUnit activeUnit = theAircraft;
				DBFunctions.smethod_112(ref theScen, ref activeUnit, AircraftDBID);
				DBFunctions.smethod_86(theAircraft, AircraftDBID);
				DBFunctions.smethod_107(theAircraft, AircraftDBID);
			}
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x001FF6C4 File Offset: 0x001FD8C4
		public static int smethod_20(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Type from DataAircraft where ID = " + Conversions.ToString(int_0);
			return Conversions.ToInteger(Class401.smethod_2(new Class403(scenario_0.method_39()), string_));
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x001FF6FC File Offset: 0x001FD8FC
		public static string smethod_21(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumAircraftType where ID = (Select Type from DataAircraft Where ID = " + Conversions.ToString(int_0) + ")";
			return Class401.smethod_2(new Class403(scenario_0.method_39()), string_);
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x001FF734 File Offset: 0x001FD934
		public static int smethod_22(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Type from DataShip where ID = " + Conversions.ToString(int_0);
			return Conversions.ToInteger(Class401.smethod_2(new Class403(scenario_0.method_39()), string_));
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x001FF76C File Offset: 0x001FD96C
		public static string smethod_23(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumShipType where ID = (Select Type from DataShip Where ID = " + Conversions.ToString(int_0) + ")";
			return Class401.smethod_2(new Class403(scenario_0.method_39()), string_);
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x001FF7A4 File Offset: 0x001FD9A4
		public static int smethod_24(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Type from DataSubmarine where ID = " + Conversions.ToString(int_0);
			return Conversions.ToInteger(Class401.smethod_2(new Class403(scenario_0.method_39()), string_));
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x001FF7DC File Offset: 0x001FD9DC
		public static string smethod_25(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumSubmarineType where ID = (Select Type from DataSubmarine Where ID = " + Conversions.ToString(int_0) + ")";
			return Class401.smethod_2(new Class403(scenario_0.method_39()), string_);
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x001FF814 File Offset: 0x001FDA14
		public static int smethod_26(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Category from DataFacility where ID = " + Conversions.ToString(int_0);
			return Conversions.ToInteger(Class401.smethod_2(new Class403(scenario_0.method_39()), string_));
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x001FF84C File Offset: 0x001FDA4C
		public static int smethod_27(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Type from DataSatellite where ID = " + Conversions.ToString(int_0);
			return Conversions.ToInteger(Class401.smethod_2(new Class403(scenario_0.method_39()), string_));
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x001FF884 File Offset: 0x001FDA84
		public static string smethod_28(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumSatelliteType where ID = (Select Type from DataSatellite Where ID = " + Conversions.ToString(int_0) + ")";
			return Class401.smethod_2(new Class403(scenario_0.method_39()), string_);
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x001FF8BC File Offset: 0x001FDABC
		public static int smethod_29(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Type from DataWeapon where ID = " + Conversions.ToString(int_0);
			return Conversions.ToInteger(Class401.smethod_2(new Class403(scenario_0.method_39()), string_));
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x001FF8F4 File Offset: 0x001FDAF4
		public static string smethod_30(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumWeaponType where ID = (Select Type from DataWeapon Where ID = " + Conversions.ToString(int_0) + ")";
			return Class401.smethod_2(new Class403(scenario_0.method_39()), string_);
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x001FF92C File Offset: 0x001FDB2C
		public static string smethod_31(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumWeaponWRAWeaponQty where ID = " + Conversions.ToString(int_0);
			return Class401.smethod_2(new Class403(scenario_0.method_39()), string_);
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x001FF95C File Offset: 0x001FDB5C
		public static string smethod_32(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumWeaponWRAShooterQty where ID = " + Conversions.ToString(int_0);
			return Class401.smethod_2(new Class403(scenario_0.method_39()), string_);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x001FF98C File Offset: 0x001FDB8C
		public static string smethod_33(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumWeaponWRASelfDefenceRange where ID = " + Conversions.ToString(int_0);
			return Class401.smethod_2(new Class403(scenario_0.method_39()), string_);
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x001FF9BC File Offset: 0x001FDBBC
		public static string smethod_34(ref Scenario scenario_0, int int_0)
		{
			string string_ = "Select Description from EnumSensorGeneration where ID = " + Conversions.ToString(int_0);
			return Class401.smethod_2(new Class403(scenario_0.method_39()), string_);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x001FF9EC File Offset: 0x001FDBEC
		public static string smethod_35(ref Scenario scenario_0, int int_0, int int_1)
		{
			Class403 class403_ = new Class403(scenario_0.method_39());
			string text = Class401.smethod_5(class403_, "FacilityType_" + Conversions.ToString(int_0));
			string result;
			if (!string.IsNullOrEmpty(text))
			{
				result = text;
			}
			else
			{
				string string_ = "Select Name, Category from Datafacility where ID = " + Conversions.ToString(int_0);
				DataRow dataRow = Class401.smethod_1(class403_, string_).Rows[0];
				Facility._FacilityCategory facilityCategory = (Facility._FacilityCategory)Conversions.ToShort(dataRow["Category"]);
				string text2;
				if (facilityCategory - Facility._FacilityCategory.Mobile_Vehicle <= 1)
				{
					text2 = Conversions.ToString((int)Facility.smethod_13(dataRow["Name"].ToString(), int_1));
				}
				else
				{
					text2 = facilityCategory.ToString();
				}
				Class401.smethod_6(class403_, "FacilityType_" + Conversions.ToString(int_0), text2);
				result = text2;
			}
			return result;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x001FFABC File Offset: 0x001FDCBC
		public static void smethod_36(ref Aircraft aircraft_0, int int_0)
		{
			Class403 class403_ = new Class403(aircraft_0.scenario_0.method_39());
			string string_ = "Select * from DataAircraftCodes where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				DataRow dataRow = dataTable.Rows[i];
				int num2 = Conversions.ToInteger(dataRow["CodeID"]);
				if (num2 <= 8001)
				{
					if (num2 <= 6011)
					{
						if (num2 <= 5002)
						{
							if (num2 != 4001)
							{
								if (num2 != 5002)
								{
									goto IL_274;
								}
								aircraft_0.bool_35 = true;
							}
							else
							{
								aircraft_0.bool_39 = true;
							}
						}
						else
						{
							switch (num2)
							{
							case 6001:
								aircraft_0.method_173(true);
								break;
							case 6002:
								aircraft_0.method_171(true);
								break;
							case 6003:
								aircraft_0.bool_36 = true;
								break;
							case 6004:
								aircraft_0.bool_37 = true;
								break;
							default:
								if (num2 != 6011)
								{
									goto IL_274;
								}
								aircraft_0.bool_40 = true;
								break;
							}
						}
					}
					else if (num2 <= 7004)
					{
						if (num2 != 6012)
						{
							switch (num2)
							{
							case 7001:
								aircraft_0.enum39_0 = Aircraft.Enum39.const_0;
								break;
							case 7002:
								aircraft_0.enum39_0 = Aircraft.Enum39.const_1;
								break;
							case 7003:
								aircraft_0.enum39_0 = Aircraft.Enum39.const_2;
								break;
							case 7004:
								aircraft_0.enum39_0 = Aircraft.Enum39.const_3;
								break;
							default:
								goto IL_274;
							}
						}
						else
						{
							aircraft_0.bool_41 = true;
						}
					}
					else if (num2 != 7010)
					{
						if (num2 != 8001)
						{
							goto IL_274;
						}
						aircraft_0.bool_27 = true;
					}
					else
					{
						aircraft_0.bool_38 = true;
					}
				}
				else
				{
					if (num2 <= 9114)
					{
						if (num2 <= 9003)
						{
							if (num2 == 8002)
							{
								aircraft_0.bool_28 = true;
								goto IL_299;
							}
							switch (num2)
							{
							case 9001:
								aircraft_0.bool_29 = true;
								goto IL_299;
							case 9002:
								aircraft_0.bool_30 = true;
								goto IL_299;
							case 9003:
								aircraft_0.bool_31 = true;
								goto IL_299;
							default:
								goto IL_274;
							}
						}
						else if (num2 - 9101 > 3 && num2 - 9111 > 3)
						{
							goto IL_274;
						}
					}
					else if (num2 <= 9186)
					{
						if (num2 - 9121 > 3 && num2 - 9185 > 1)
						{
							goto IL_274;
						}
					}
					else if (num2 - 9191 > 1 && num2 != 9199)
					{
						goto IL_274;
					}
					aircraft_0.enum41_0 = (Aircraft.Enum41)Conversions.ToInteger(dataRow["CodeID"]);
				}
				IL_299:
				i++;
				continue;
				IL_274:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					goto IL_299;
				}
				goto IL_299;
			}
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x001FFD70 File Offset: 0x001FDF70
		public static string smethod_37(int int_0, int int_1, ref SQLiteConnection sqliteConnection_0, Scenario scenario_0, bool bool_0, Loadout.LoadoutRole loadoutRole_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string result;
			if (bool_0)
			{
				string string_ = "Select EnumLoadoutWinchesterShotgun.Description from EnumLoadoutWinchesterShotgun where EnumLoadoutWinchesterShotgun.ID = " + Conversions.ToString(int_1);
				DataTable dataTable = Class401.smethod_1(class403_, string_);
				if (dataTable.Rows.Count > 0)
				{
					result = dataTable.Rows[0]["Description"].ToString();
				}
				else
				{
					result = "Winchester: Mission-specific weapons have been expended. Disengage immediately.";
				}
			}
			else
			{
				result = Aircraft.smethod_13(int_0, int_1, loadoutRole_0, scenario_0);
			}
			return result;
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x001FFDE4 File Offset: 0x001FDFE4
		public static Class237 smethod_38(int int_0, ref SQLiteConnection sqliteConnection_0, Scenario scenario_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "SELECT DefaultMissionProfile from DataLoadout where ID=" + Conversions.ToString(int_0);
			return DBFunctions.smethod_39(Conversions.ToInteger(Class401.smethod_2(class403_, string_)), ref sqliteConnection_0, scenario_0);
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x001FFE1C File Offset: 0x001FE01C
		public static Class237 smethod_39(int int_0, ref SQLiteConnection sqliteConnection_0, Scenario scenario_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			DataTable dataTable;
			try
			{
				string string_;
				if (scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(scenario_0.method_39()))
				{
					string_ = "Select Description, FormUpTime, FormUpAltitude, CruiseAltitudeIngress, CruiseAltitudeIngressTerrainFollowing, CruiseAltitudeEgress, CruiseAltitudeEgressTerrainFollowing, CruiseThrottleSettingIngress, CruiseThrottleSettingEgress, CruiseOneWayOnly, CruiseAtOptimumAltitude, AttackAltitudeIngress, AttackAltitudeIngressTerrainFollowing, AttackAltitudeEgress, AttackAltitudeEgressTerrainFollowing, AttackThrottleSetting, AttackDistanceIngress, AttackDistanceEgress, DropBombsAtMaxRange, StationAltitude, StationAltitudeTerrainFollowing, StationThrottleSetting, ReservePercentage, ReserveLoiterTime, ReserveLoiterAltitude from EnumLoadoutMissionProfile where ID = " + Conversions.ToString(int_0);
				}
				else
				{
					string_ = "Select Description, FormUpTime, FormUpAltitude, CruiseAltitudeIngress, CruiseAltitudeEgress, CruiseThrottleSettingIngress, CruiseThrottleSettingEgress, CruiseOneWayOnly, CruiseAtOptimumAltitude, AttackAltitudeIngress, AttackAltitudeEgress, AttackThrottleSetting, AttackDistanceIngress, AttackDistanceEgress, DropBombsAtMaxRange, StationAltitude, StationThrottleSetting, ReservePercentage, ReserveLoiterTime, ReserveLoiterAltitude from EnumLoadoutMissionProfile where ID = " + Conversions.ToString(int_0);
				}
				dataTable = Class401.smethod_1(class403_, string_);
			}
			catch (Exception ex)
			{
				string string_ = "Select Description, FormUpTime, FormUpAltitude, CruiseAltitudeIngress, CruiseAltitudeEgress, CruiseThrottleSettingIngress, CruiseThrottleSettingEgress, CruiseOneWayOnly, CruiseAtOptimumAltitude, AttackAltitudeIngress, AttackAltitudeEgress, AttackThrottleSetting, AttackDistanceIngress, AttackDistanceEgress, DropBombsAtMaxRange, StationAltitude, StationThrottleSetting, ReservePercentage from EnumLoadoutMissionProfile where ID = " + Conversions.ToString(int_0);
				dataTable = Class401.smethod_1(class403_, string_);
			}
			Class237 @class = new Class237();
			Class237 result;
			if (dataTable.Rows.Count == 0)
			{
				result = null;
			}
			else
			{
				DataRow dataRow = dataTable.Rows[0];
				@class.DBID = (short)int_0;
				@class.string_0 = Conversions.ToString(dataRow["Description"]);
				@class.int_0 = Conversions.ToInteger(dataRow["FormUpTime"]);
				@class.float_0 = (float)Conversions.ToInteger(dataRow["FormUpAltitude"]) / 3.28084f;
				@class.float_1 = (float)Conversions.ToInteger(dataRow["CruiseAltitudeIngress"]) / 3.28084f;
				@class.float_2 = (float)Conversions.ToInteger(dataRow["CruiseAltitudeEgress"]) / 3.28084f;
				@class.throttle_0 = (ActiveUnit.Throttle)Conversions.ToByte(dataRow["CruiseThrottleSettingIngress"]);
				@class.throttle_1 = (ActiveUnit.Throttle)Conversions.ToByte(dataRow["CruiseThrottleSettingEgress"]);
				@class.bool_2 = Conversions.ToBoolean(dataRow["CruiseOneWayOnly"]);
				@class.bool_3 = Conversions.ToBoolean(dataRow["CruiseAtOptimumAltitude"]);
				@class.float_3 = (float)Conversions.ToInteger(dataRow["AttackAltitudeIngress"]) / 3.28084f;
				@class.float_4 = (float)Conversions.ToInteger(dataRow["AttackAltitudeEgress"]) / 3.28084f;
				@class.throttle_2 = (ActiveUnit.Throttle)Conversions.ToByte(dataRow["AttackThrottleSetting"]);
				@class.int_1 = Conversions.ToInteger(dataRow["AttackDistanceIngress"]);
				@class.int_2 = Conversions.ToInteger(dataRow["AttackDistanceEgress"]);
				@class.bool_6 = Conversions.ToBoolean(dataRow["DropBombsAtMaxRange"]);
				@class.float_5 = (float)Conversions.ToInteger(dataRow["StationAltitude"]) / 3.28084f;
				@class.throttle_3 = (ActiveUnit.Throttle)Conversions.ToByte(dataRow["StationThrottleSetting"]);
				@class.int_3 = Conversions.ToInteger(dataRow["ReservePercentage"]);
				if (scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(scenario_0.method_39()))
				{
					@class.bool_0 = Conversions.ToBoolean(dataRow["CruiseAltitudeIngressTerrainFollowing"]);
					@class.bool_1 = Conversions.ToBoolean(dataRow["CruiseAltitudeEgressTerrainFollowing"]);
					@class.bool_4 = Conversions.ToBoolean(dataRow["AttackAltitudeIngressTerrainFollowing"]);
					@class.bool_5 = Conversions.ToBoolean(dataRow["AttackAltitudeEgressTerrainFollowing"]);
					@class.bool_7 = Conversions.ToBoolean(dataRow["StationAltitudeTerrainFollowing"]);
				}
				else
				{
					@class.bool_0 = false;
					@class.bool_1 = false;
					@class.bool_4 = false;
					@class.bool_5 = false;
					@class.bool_7 = false;
				}
				if (dataTable.Columns.Contains("ReserveLoiterTime"))
				{
					@class.int_4 = Conversions.ToInteger(dataRow["ReserveLoiterTime"]);
				}
				if (dataTable.Columns.Contains("ReserveLoiterAltitude"))
				{
					@class.float_6 = (float)Conversions.ToInteger(dataRow["ReserveLoiterAltitude"]) / 3.28084f;
				}
				result = @class;
			}
			return result;
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x002001B4 File Offset: 0x001FE3B4
		public static Dictionary<int, int> smethod_40(List<Aircraft> SelectedAircraft, ref SQLiteConnection theDBConn, ref bool UnlimitedAirWeapons = false)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			if (!UnlimitedAirWeapons && !Information.IsNothing(SelectedAircraft))
			{
				try
				{
					foreach (Aircraft aircraft in SelectedAircraft)
					{
						if (!Information.IsNothing(aircraft.method_167()))
						{
							DataTable dataTable = new DataTable();
							dataTable = DBFunctions.smethod_44(aircraft.method_167().DBID, ref theDBConn, ref aircraft.method_167().bool_11);
							int num = dataTable.Rows.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								DataRow dataRow = dataTable.Rows[i];
								int num2 = Conversions.ToInteger(dataRow["ComponentID"]);
								if (!Weapon.smethod_17(num2, ref aircraft.scenario_0))
								{
									if (dictionary.ContainsKey(num2))
									{
										dictionary[num2] += Conversions.ToInteger(dataRow["Quantity"]);
									}
									else
									{
										dictionary.Add(num2, Conversions.ToInteger(dataRow["Quantity"]));
									}
								}
							}
						}
					}
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			return dictionary;
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x002002E8 File Offset: 0x001FE4E8
		public static List<Loadout> smethod_41(int int_0, Scenario scenario_0)
		{
			Class403 @class = new Class403(scenario_0.method_39());
			List<Loadout> list = new List<Loadout>();
			string string_ = "Select ComponentID from DataAircraftLoadouts where ID=" + Conversions.ToString(int_0);
			DataTable dataTable = @class.method_2(string_);
			try
			{
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					Loadout item = DBFunctions.smethod_47(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), false, false);
					list.Add(item);
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return list;
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00200390 File Offset: 0x001FE590
		public static DataTable smethod_42(int AircraftID, Dictionary<int, int> SelectedAircraftTotalWeaponQty, ref SQLiteConnection theDBConn, Scenario theScen, ref bool UnlimitedAirWeapons = false, ref Scenario CurrentScenario = null, ref Aircraft SelectedAircraft = null, ref int AircraftLoadoutDBID = 0, ref bool ExcludeOptionalWeapons = false)
		{
			DataTable result;
			if (!Information.IsNothing(SelectedAircraft) && Information.IsNothing(SelectedAircraft.method_164().method_30()))
			{
				result = null;
			}
			else
			{
				Class403 @class = new Class403(theDBConn);
				DataTable dataTable;
				if (AircraftLoadoutDBID > 0)
				{
					if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theScen.method_39()))
					{
						string string_ = "SELECT ID, Name, RequiresBuddyIllumination, LoadoutRole, DefaultCombatRadius, DefaultTimeOnStation, DefaultMissionProfile, QuickTurnaround, QuickTurnaround_AirborneTime, QuickTurnaround_ReadyTime, QuickTurnaround_MaxSorties, QuickTurnaround_AdditionalTimePenalty, QuickTurnaround_TimeofDay, WinchesterShotgun from DataLoadout where DataLoadout.ID = " + Conversions.ToString(AircraftLoadoutDBID);
						dataTable = @class.method_2(string_);
						goto IL_1C7;
					}
					try
					{
						string string_ = "SELECT ID, Name, RequiresBuddyIllumination, LoadoutRole, DefaultCombatRadius, DefaultTimeOnStation, DefaultMissionProfile, QuickTurnaround, QuickTurnaround_AirborneTime, QuickTurnaround_ReadyTime, QuickTurnaround_MaxSorties, QuickTurnaround_AdditionalTimePenalty, QuickTurnaround_TimeofDay from DataLoadout where DataLoadout.ID = " + Conversions.ToString(AircraftLoadoutDBID);
						dataTable = @class.method_2(string_);
						goto IL_1C7;
					}
					catch (Exception ex)
					{
						string string_ = "SELECT ID, Name, RequiresBuddyIllumination, LoadoutRole, DefaultCombatRadius, DefaultTimeOnStation, DefaultMissionProfile from DataLoadout where DataLoadout.ID = " + Conversions.ToString(AircraftLoadoutDBID);
						dataTable = @class.method_2(string_);
						goto IL_1C7;
					}
				}
				if (CurrentScenario != null)
				{
					if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theScen.method_39()))
					{
						string string_ = "SELECT DataLoadout.ID, DataLoadout.Name, RequiresBuddyIllumination, LoadoutRole, DefaultCombatRadius, DefaultTimeOnStation, DefaultMissionProfile, QuickTurnaround, QuickTurnaround_AirborneTime, QuickTurnaround_ReadyTime, QuickTurnaround_MaxSorties, QuickTurnaround_AdditionalTimePenalty, QuickTurnaround_TimeofDay, WinchesterShotgun from DataLoadout, DataAircraftLoadouts where DataLoadout.ID = DataAircraftLoadouts.ComponentID and DataAircraftLoadouts.ID = " + Conversions.ToString(AircraftID) + " ORDER BY DataLoadout.Name ASC";
						dataTable = @class.method_2(string_);
						goto IL_1C7;
					}
					try
					{
						string string_ = "SELECT DataLoadout.ID, DataLoadout.Name, RequiresBuddyIllumination, LoadoutRole, DefaultCombatRadius, DefaultTimeOnStation, DefaultMissionProfile, QuickTurnaround, QuickTurnaround_AirborneTime, QuickTurnaround_ReadyTime, QuickTurnaround_MaxSorties, QuickTurnaround_AdditionalTimePenalty, QuickTurnaround_TimeofDay from DataLoadout, DataAircraftLoadouts where DataLoadout.ID = DataAircraftLoadouts.ComponentID and DataAircraftLoadouts.ID = " + Conversions.ToString(AircraftID) + " ORDER BY DataLoadout.Name ASC";
						dataTable = @class.method_2(string_);
						goto IL_1C7;
					}
					catch (Exception ex2)
					{
						string string_ = "SELECT DataLoadout.ID, DataLoadout.Name, RequiresBuddyIllumination, LoadoutRole, DefaultCombatRadius, DefaultTimeOnStation, DefaultMissionProfile from DataLoadout, DataAircraftLoadouts where DataLoadout.ID = DataAircraftLoadouts.ComponentID and DataAircraftLoadouts.ID = " + Conversions.ToString(AircraftID) + " ORDER BY DataLoadout.Name ASC";
						dataTable = @class.method_2(string_);
						goto IL_1C7;
					}
				}
				if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theScen.method_39()))
				{
					string string_ = "SELECT DataLoadout.ID, DataLoadout.Name, ReadyTime, ReadyTime_Sustained, LoadoutRole, QuickTurnaround, QuickTurnaround_AirborneTime, QuickTurnaround_ReadyTime, QuickTurnaround_MaxSorties, QuickTurnaround_AdditionalTimePenalty, QuickTurnaround_TimeofDay, WinchesterShotgun from DataLoadout, DataAircraftLoadouts where DataLoadout.ID = DataAircraftLoadouts.ComponentID and DataAircraftLoadouts.ID = " + Conversions.ToString(AircraftID) + " ORDER BY DataLoadout.Name ASC";
					dataTable = @class.method_2(string_);
				}
				else
				{
					try
					{
						string string_ = "SELECT DataLoadout.ID, DataLoadout.Name, ReadyTime, ReadyTime_Sustained, LoadoutRole, QuickTurnaround, QuickTurnaround_AirborneTime, QuickTurnaround_ReadyTime, QuickTurnaround_MaxSorties, QuickTurnaround_AdditionalTimePenalty, QuickTurnaround_TimeofDay from DataLoadout, DataAircraftLoadouts where DataLoadout.ID = DataAircraftLoadouts.ComponentID and DataAircraftLoadouts.ID = " + Conversions.ToString(AircraftID) + " ORDER BY DataLoadout.Name ASC";
						dataTable = @class.method_2(string_);
					}
					catch (Exception ex3)
					{
						string string_ = "SELECT DataLoadout.ID, DataLoadout.Name, ReadyTime AS ReadyTime, LoadoutRole from DataLoadout, DataAircraftLoadouts where DataLoadout.ID = DataAircraftLoadouts.ComponentID and DataAircraftLoadouts.ID = " + Conversions.ToString(AircraftID) + " ORDER BY DataLoadout.Name ASC";
						dataTable = @class.method_2(string_);
					}
				}
				IL_1C7:
				if (!dataTable.Columns.Contains("QuickTurnaround"))
				{
					dataTable.Columns.Add("QuickTurnaround", typeof(string));
					try
					{
						foreach (object obj in dataTable.Rows)
						{
							((DataRow)obj)["QuickTurnaround"] = 0;
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_ReadyTime"))
				{
					dataTable.Columns.Add("QuickTurnaround_ReadyTime", typeof(string));
					try
					{
						foreach (object obj2 in dataTable.Rows)
						{
							((DataRow)obj2)["QuickTurnaround_ReadyTime"] = 0;
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_MaxSorties"))
				{
					dataTable.Columns.Add("QuickTurnaround_MaxSorties", typeof(string));
					try
					{
						foreach (object obj3 in dataTable.Rows)
						{
							((DataRow)obj3)["QuickTurnaround_MaxSorties"] = 0;
						}
					}
					finally
					{
						IEnumerator enumerator3;
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_AdditionalTimePenalty"))
				{
					dataTable.Columns.Add("QuickTurnaround_AdditionalTimePenalty", typeof(string));
					try
					{
						foreach (object obj4 in dataTable.Rows)
						{
							((DataRow)obj4)["QuickTurnaround_AdditionalTimePenalty"] = 0;
						}
					}
					finally
					{
						IEnumerator enumerator4;
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
					}
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_AirborneTime"))
				{
					dataTable.Columns.Add("QuickTurnaround_AirborneTime", typeof(string));
					try
					{
						foreach (object obj5 in dataTable.Rows)
						{
							((DataRow)obj5)["QuickTurnaround_AirborneTime"] = 0;
						}
					}
					finally
					{
						IEnumerator enumerator5;
						if (enumerator5 is IDisposable)
						{
							(enumerator5 as IDisposable).Dispose();
						}
					}
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_TimeofDay"))
				{
					dataTable.Columns.Add("QuickTurnaround_TimeofDay", typeof(string));
					try
					{
						foreach (object obj6 in dataTable.Rows)
						{
							((DataRow)obj6)["QuickTurnaround_TimeofDay"] = 0;
						}
					}
					finally
					{
						IEnumerator enumerator6;
						if (enumerator6 is IDisposable)
						{
							(enumerator6 as IDisposable).Dispose();
						}
					}
				}
				if (!dataTable.Columns.Contains("WinchesterShotgun"))
				{
					dataTable.Columns.Add("WinchesterShotgun", typeof(string));
					try
					{
						foreach (object obj7 in dataTable.Rows)
						{
							((DataRow)obj7)["WinchesterShotgun"] = 0;
						}
					}
					finally
					{
						IEnumerator enumerator7;
						if (enumerator7 is IDisposable)
						{
							(enumerator7 as IDisposable).Dispose();
						}
					}
				}
				if (CurrentScenario != null)
				{
					if (!dataTable.Columns.Contains("NumberOfLoadouts"))
					{
						dataTable.Columns.Add("NumberOfLoadouts", typeof(string));
					}
					if (!dataTable.Columns.Contains("NumberOfLoadoutsIncludingMountedWeapons"))
					{
						dataTable.Columns.Add("NumberOfLoadoutsIncludingMountedWeapons", typeof(string));
					}
					if (!dataTable.Columns.Contains("NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly"))
					{
						dataTable.Columns.Add("NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly", typeof(string));
					}
					if (!dataTable.Columns.Contains("QuickTurnaroundDescription"))
					{
						dataTable.Columns.Add("QuickTurnaroundDescription", typeof(string));
					}
					if (!dataTable.Columns.Contains("WinchesterShotgunDescription"))
					{
						dataTable.Columns.Add("WinchesterShotgunDescription", typeof(string));
					}
					DataTable dataTable2 = new DataTable();
					try
					{
						foreach (object obj8 in dataTable.Rows)
						{
							DataRow dataRow = (DataRow)obj8;
							int num = int.MaxValue;
							int num2 = int.MaxValue;
							int num3 = int.MaxValue;
							dataTable2 = DBFunctions.smethod_44(Conversions.ToInteger(dataRow["ID"]), ref theDBConn, ref ExcludeOptionalWeapons);
							int num4;
							if (!UnlimitedAirWeapons)
							{
								try
								{
									foreach (object obj9 in dataTable2.Rows)
									{
										DataRow dataRow2 = (DataRow)obj9;
										num4 = Conversions.ToInteger(dataRow2["ComponentID"]);
										int num5 = Conversions.ToInteger(dataRow2["Quantity"]);
										bool flag = Conversions.ToBoolean(dataRow2["Optional"]);
										if (!Weapon.smethod_17(num4, ref CurrentScenario))
										{
											int num6 = SelectedAircraft.method_164().method_30().vmethod_89().vmethod_8(num4);
											int num7 = 0;
											if (!Information.IsNothing(SelectedAircraftTotalWeaponQty) && SelectedAircraftTotalWeaponQty.ContainsKey(num4))
											{
												num7 = SelectedAircraftTotalWeaponQty[num4];
											}
											if (num5 > 0)
											{
												int num8 = num6 / num5;
												if (num8 < num)
												{
													num = num8;
												}
												num8 = (num6 + num7) / num5;
												if (num8 < num2)
												{
													num2 = num8;
												}
												if (!flag)
												{
													num8 = (num6 + num7) / num5;
													if (num8 < num3)
													{
														num3 = num8;
													}
												}
											}
										}
									}
								}
								finally
								{
									IEnumerator enumerator9;
									if (enumerator9 is IDisposable)
									{
										(enumerator9 as IDisposable).Dispose();
									}
								}
							}
							if (num != 2147483647 && !UnlimitedAirWeapons)
							{
								dataRow["NumberOfLoadouts"] = num;
							}
							else
							{
								dataRow["NumberOfLoadouts"] = "Unlimited";
							}
							if (num2 != 2147483647 && !UnlimitedAirWeapons)
							{
								dataRow["NumberOfLoadoutsIncludingMountedWeapons"] = num2;
							}
							else
							{
								dataRow["NumberOfLoadoutsIncludingMountedWeapons"] = "Unlimited";
							}
							if (num3 != 2147483647 && !UnlimitedAirWeapons)
							{
								dataRow["NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly"] = num3;
							}
							else
							{
								dataRow["NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly"] = "Unlimited";
							}
							if (!Conversions.ToBoolean(dataRow["QuickTurnaround"]))
							{
								dataRow["QuickTurnaroundDescription"] = "-";
							}
							else
							{
								int num9 = Conversions.ToInteger(dataRow["QuickTurnaround_ReadyTime"]);
								int value = Conversions.ToInteger(dataRow["QuickTurnaround_MaxSorties"]);
								int num10 = Conversions.ToInteger(dataRow["QuickTurnaround_AirborneTime"]);
								string string_ = "Select EnumLoadoutTimeOfDay.Description from EnumLoadoutTimeOfDay, DataLoadout where EnumLoadoutTimeOfDay.ID = DataLoadout.QuickTurnaround_TimeofDay and DataLoadout.ID = " + dataRow["ID"].ToString();
								DataTable dataTable3 = Class401.smethod_1(@class, string_);
								string text;
								if (dataTable3.Rows.Count > 0)
								{
									text = dataTable3.Rows[0]["Description"].ToString();
								}
								else
								{
									text = "No time-of-day description";
								}
								dataRow["QuickTurnaroundDescription"] = string.Concat(new string[]
								{
									text,
									", ",
									Conversions.ToString(value),
									" sorties @ ",
									Misc.smethod_11((long)(num9 * 60), Aircraft_AirOps.Enum44.const_0, false, false),
									", ",
									Misc.smethod_11((long)(num10 * 60), Aircraft_AirOps.Enum44.const_0, false, false),
									" flying time"
								});
							}
							if (Conversions.ToBoolean(dataRow["WinchesterShotgun"]) && Conversions.ToInteger(dataRow["WinchesterShotgun"]) != 0)
							{
								dataRow["WinchesterShotgunDescription"] = DBFunctions.smethod_37(num4, Conversions.ToInteger(dataRow["WinchesterShotgun"]), ref theDBConn, CurrentScenario, false, (Loadout.LoadoutRole)Conversions.ToInteger(dataRow["LoadoutRole"]));
							}
							else
							{
								dataRow["WinchesterShotgunDescription"] = "Winchester: Mission-specific weapons have been expended. Disengage immediately.";
							}
						}
					}
					finally
					{
						IEnumerator enumerator8;
						if (enumerator8 is IDisposable)
						{
							(enumerator8 as IDisposable).Dispose();
						}
					}
				}
				if (CurrentScenario != null)
				{
					try
					{
						foreach (object obj10 in dataTable.Rows)
						{
							DataRow dataRow3 = (DataRow)obj10;
							if (!dataTable.Columns.Contains("RangeProfileDescription"))
							{
								dataTable.Columns.Add("RangeProfileDescription", typeof(string));
							}
							if (!dataTable.Columns.Contains("LoadoutRoleDescription"))
							{
								dataTable.Columns.Add("LoadoutRoleDescription", typeof(string));
							}
							if (!dataTable.Columns.Contains("Weather"))
							{
								dataTable.Columns.Add("Weather", typeof(string));
							}
							if (!dataTable.Columns.Contains("TimeofDay"))
							{
								dataTable.Columns.Add("TimeofDay", typeof(string));
							}
							if (!dataTable.Columns.Contains("ReadyTime"))
							{
								dataTable.Columns.Add("ReadyTime", typeof(string));
							}
							if (!dataTable.Columns.Contains("ReadyTime_Sustained"))
							{
								dataTable.Columns.Add("ReadyTime_Sustained", typeof(string));
							}
							string string_2 = DBFunctions.smethod_38(Conversions.ToInteger(dataRow3["ID"]), ref theDBConn, theScen).string_0;
							int value2 = Conversions.ToInteger(dataRow3["DefaultCombatRadius"]);
							int num11 = Conversions.ToInteger(dataRow3["DefaultTimeOnStation"]);
							string str;
							if (Conversions.ToInteger(dataRow3["DefaultMissionProfile"]) == 1001)
							{
								str = "";
							}
							else if (num11 > 0)
							{
								str = Conversions.ToString(num11) + " minutes at " + Conversions.ToString(value2) + " nm ";
							}
							else
							{
								str = Conversions.ToString(value2) + " nm ";
							}
							dataRow3["RangeProfileDescription"] = str + string_2;
							string string_ = "Select EnumLoadoutRole.Description from EnumLoadoutRole, DataLoadout where EnumLoadoutRole.ID =  DataLoadout.LoadoutRole and DataLoadout.ID = " + Conversions.ToString(Conversions.ToInteger(dataRow3["ID"]));
							DataTable dataTable4 = Class401.smethod_1(@class, string_);
							if (dataTable4.Rows.Count > 0)
							{
								string str2 = Conversions.ToString(dataTable4.Rows[0]["Description"]);
								dataRow3["LoadoutRoleDescription"] = "Loadout Role: " + str2;
							}
							else
							{
								dataRow3["LoadoutRoleDescription"] = "Loadout Role: None";
							}
							string_ = "Select EnumLoadoutWeather.Description from EnumLoadoutWeather, DataLoadout where EnumLoadoutWeather.ID = DataLoadout.Weather and DataLoadout.ID = " + Conversions.ToString(Conversions.ToInteger(dataRow3["ID"]));
							DataTable dataTable5 = Class401.smethod_1(@class, string_);
							if (dataTable5.Rows.Count > 0)
							{
								string value3 = Conversions.ToString(dataTable5.Rows[0]["Description"]);
								dataRow3["Weather"] = value3;
							}
							else
							{
								dataRow3["Weather"] = "";
							}
							string_ = "Select EnumLoadoutTimeOfDay.Description from EnumLoadoutTimeOfDay, DataLoadout where EnumLoadoutTimeOfDay.ID = DataLoadout.TimeofDay and DataLoadout.ID = " + dataRow3["ID"].ToString();
							DataTable dataTable6 = Class401.smethod_1(@class, string_);
							if (dataTable6.Rows.Count > 0)
							{
								string value4 = dataTable6.Rows[0]["Description"].ToString();
								dataRow3["TimeofDay"] = value4;
							}
							else
							{
								dataRow3["TimeofDay"] = "";
							}
							try
							{
								string_ = "SELECT ReadyTime, ReadyTime_Sustained from DataLoadout where DataLoadout.ID = " + dataRow3["ID"].ToString();
								DataTable dataTable7 = Class401.smethod_1(@class, string_);
								if (dataTable7.Rows.Count > 0)
								{
									DataRow dataRow4 = dataTable7.Rows[0];
									long num12 = Conversions.ToLong(dataRow4["ReadyTime"]);
									long num13 = Conversions.ToLong(dataRow4["ReadyTime_Sustained"]);
									if (num12 > 0L)
									{
										string value5 = Misc.smethod_11(num12 * 60L, Aircraft_AirOps.Enum44.const_0, false, false);
										dataRow3["ReadyTime"] = value5;
									}
									else
									{
										dataRow3["ReadyTime"] = "n/a";
									}
									if (num13 > 0L)
									{
										string value6 = Misc.smethod_11(num13 * 60L, Aircraft_AirOps.Enum44.const_0, false, false);
										dataRow3["ReadyTime_Sustained"] = value6;
									}
									else
									{
										dataRow3["ReadyTime_Sustained"] = "n/a";
									}
								}
								else
								{
									dataRow3["ReadyTime"] = "";
									dataRow3["ReadyTime_Sustained"] = "";
								}
							}
							catch (Exception ex4)
							{
								string_ = "SELECT ReadyTime as ReadyTime from DataLoadout where DataLoadout.ID = " + dataRow3["ID"].ToString();
								DataTable dataTable7 = Class401.smethod_1(@class, string_);
								if (dataTable7.Rows.Count > 0)
								{
									long num14 = Conversions.ToLong(dataTable7.Rows[0]["ReadyTime"]);
									if (num14 > 0L)
									{
										string value7 = Misc.smethod_11(num14 * 60L, Aircraft_AirOps.Enum44.const_0, false, false);
										dataRow3["ReadyTime"] = value7;
									}
									else
									{
										dataRow3["ReadyTime"] = "n/a";
									}
								}
								else
								{
									dataRow3["ReadyTime"] = "";
								}
								dataRow3["ReadyTime_Sustained"] = "-";
							}
						}
					}
					finally
					{
						IEnumerator enumerator10;
						if (enumerator10 is IDisposable)
						{
							(enumerator10 as IDisposable).Dispose();
						}
					}
				}
				try
				{
					foreach (object obj11 in dataTable.Rows)
					{
						DataRow dataRow5 = (DataRow)obj11;
						if (!dataTable.Columns.Contains("AttackAltitude"))
						{
							dataTable.Columns.Add("AttackAltitude", typeof(string));
							try
							{
								foreach (object obj12 in dataTable.Rows)
								{
									DataRow dataRow6 = (DataRow)obj12;
									if (!Information.IsNothing(DBFunctions.smethod_38(Conversions.ToInteger(dataRow6["ID"]), ref theDBConn, theScen)))
									{
										float num15 = DBFunctions.smethod_38(Conversions.ToInteger(dataRow6["ID"]), ref theDBConn, theScen).float_3;
										string text2 = "";
										if (num15 == 0f)
										{
											Loadout.LoadoutRole loadoutRole = (Loadout.LoadoutRole)Conversions.ToInteger(dataRow6["LoadoutRole"]);
											if (loadoutRole <= Loadout.LoadoutRole.NavalOnly_DEAD)
											{
												if (loadoutRole - Loadout.LoadoutRole.LandNaval_Strike <= 4 || loadoutRole - Loadout.LoadoutRole.LandOnly_Strike <= 4 || loadoutRole - Loadout.LoadoutRole.NavalOnly_Strike <= 4)
												{
													goto IL_1047;
												}
											}
											else
											{
												if (loadoutRole == Loadout.LoadoutRole.BAI_CAS || loadoutRole == Loadout.LoadoutRole.NavalMineLaying)
												{
													goto IL_1047;
												}
												if (loadoutRole == Loadout.LoadoutRole.ASW_Attack)
												{
													goto IL_1047;
												}
											}
											dataRow6["AttackAltitude"] = "-";
											continue;
											IL_1047:
											num15 = DBFunctions.smethod_38(Conversions.ToInteger(dataRow6["ID"]), ref theDBConn, theScen).float_1;
											if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theScen.method_39()))
											{
												if (DBFunctions.smethod_38(Conversions.ToInteger(dataRow6["ID"]), ref theDBConn, theScen).bool_0)
												{
													text2 = " AGL (Terrain Following / Avoidance)";
												}
												else
												{
													text2 = " ASL";
												}
											}
											if (num15 == 0f)
											{
												dataRow6["AttackAltitude"] = "-";
											}
											else if (Class570.class280_0.method_12())
											{
												dataRow6["AttackAltitude"] = Conversions.ToString(Math.Round((double)(num15 * 3.28084f), 0)) + " ft" + text2;
											}
											else
											{
												dataRow6["AttackAltitude"] = "Attack Altitude: " + Conversions.ToString(num15) + " m" + text2;
											}
										}
										else
										{
											if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theScen.method_39()))
											{
												if (DBFunctions.smethod_38(Conversions.ToInteger(dataRow6["ID"]), ref theDBConn, theScen).bool_4)
												{
													text2 = " AGL (Terrain Following / Avoidance)";
												}
												else
												{
													text2 = " ASL";
												}
											}
											if (Class570.class280_0.method_12())
											{
												dataRow6["AttackAltitude"] = Conversions.ToString(Math.Round((double)(num15 * 3.28084f), 0)) + " ft" + text2;
											}
											else
											{
												dataRow6["AttackAltitude"] = "Attack Altitude: " + Conversions.ToString(num15) + " m" + text2;
											}
										}
									}
								}
							}
							finally
							{
								IEnumerator enumerator12;
								if (enumerator12 is IDisposable)
								{
									(enumerator12 as IDisposable).Dispose();
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator11;
					if (enumerator11 is IDisposable)
					{
						(enumerator11 as IDisposable).Dispose();
					}
				}
				result = dataTable;
			}
			return result;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0020173C File Offset: 0x001FF93C
		public static List<int> smethod_43(int int_0, ref SQLiteConnection sqliteConnection_0)
		{
			List<int> list = new List<int>();
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "SELECT DISTINCT DataWeapon.ID from DataWeapon, DataLoadout, DataLoadoutWeapons, DataAircraftLoadouts, DataWeaponRecord where DataWeapon.ID = DataWeaponRecord.ComponentID and DataWeaponRecord.ID = DataLoadoutWeapons.ComponentID and DataLoadoutWeapons.ID = DataLoadout.ID and DataLoadout.ID = DataAircraftLoadouts.ComponentID and DataAircraftLoadouts.ID = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Name ASC";
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				list.Add(Conversions.ToInteger(dataRow["ID"]));
			}
			return list;
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x002017B8 File Offset: 0x001FF9B8
		public static DataTable smethod_44(int int_0, ref SQLiteConnection sqliteConnection_0, ref bool bool_0)
		{
			DataTable dataTable = new DataTable();
			Class403 @class = new Class403(sqliteConnection_0);
			string string_ = "SELECT DataLoadoutWeapons.ComponentID, DataLoadoutWeapons.Optional, DataLoadoutWeapons.Internal FROM DataLoadoutWeapons, DataWeaponRecord, DataWeapon WHERE DataLoadoutWeapons.ComponentID = DataWeaponRecord.ID AND DataWeapon.ID = DataWeaponRecord.ComponentID AND DataLoadoutWeapons.ID = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Type, DataWeapon.Name, DataWeaponRecord.DefaultLoad ASC";
			DataTable dataTable2;
			try
			{
				dataTable2 = Class401.smethod_1(@class, string_);
			}
			catch (Exception ex)
			{
				string_ = "SELECT DataLoadoutWeapons.ComponentID FROM DataLoadoutWeapons, DataWeaponRecord, DataWeapon WHERE DataLoadoutWeapons.ComponentID = DataWeaponRecord.ID AND DataWeapon.ID = DataWeaponRecord.ComponentID AND DataLoadoutWeapons.ID = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Type, DataWeapon.Name ASC";
				dataTable2 = Class401.smethod_1(@class, string_);
			}
			dataTable.Columns.Add("ComponentID", typeof(int));
			dataTable.Columns.Add("Quantity", typeof(int));
			dataTable.Columns.Add("Item", typeof(string));
			dataTable.Columns.Add("Optional", typeof(bool));
			dataTable.Columns.Add("Internal", typeof(bool));
			int num = dataTable2.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable2.Rows[i];
				if (!dataTable2.Columns.Contains("Optional") || !Conversions.ToBoolean(dataRow["Optional"]) || !bool_0)
				{
					string_ = "Select DataWeapon.ID as ID, DataWeapon.NAME, DataWeaponRecord.DefaultLoad from DataWeapon, DataWeaponRecord where DataWeapon.ID = DataWeaponRecord.ComponentID and DataWeaponRecord.ID =" + dataRow["ComponentID"].ToString();
					SQLiteDataReader sqliteDataReader = @class.method_1(string_);
					sqliteDataReader.Read();
					DataRow dataRow2 = dataTable.NewRow();
					dataRow2["ComponentID"] = RuntimeHelpers.GetObjectValue(sqliteDataReader["ID"]);
					dataRow2["Quantity"] = RuntimeHelpers.GetObjectValue(sqliteDataReader["DefaultLoad"]);
					if (dataTable2.Columns.Contains("Optional"))
					{
						dataRow2["Optional"] = RuntimeHelpers.GetObjectValue(dataRow["Optional"]);
					}
					else
					{
						dataRow2["Optional"] = false;
					}
					if (dataTable2.Columns.Contains("Internal"))
					{
						dataRow2["Internal"] = RuntimeHelpers.GetObjectValue(dataRow["Internal"]);
					}
					else
					{
						dataRow2["Internal"] = false;
					}
					if (Conversions.ToBoolean(dataRow2["Optional"]) && Conversions.ToBoolean(dataRow2["Internal"]))
					{
						dataRow2["Item"] = sqliteDataReader["DefaultLoad"].ToString() + "x " + Strings.Trim(Conversions.ToString(sqliteDataReader["Name"])) + "   (Internal, Optional)";
					}
					else if (Conversions.ToBoolean(dataRow2["Optional"]) && !Conversions.ToBoolean(dataRow2["Internal"]))
					{
						dataRow2["Item"] = sqliteDataReader["DefaultLoad"].ToString() + "x " + Strings.Trim(Conversions.ToString(sqliteDataReader["Name"])) + "   (Optional)";
					}
					else if (!Conversions.ToBoolean(dataRow2["Optional"]) && Conversions.ToBoolean(dataRow2["Internal"]))
					{
						dataRow2["Item"] = sqliteDataReader["DefaultLoad"].ToString() + "x " + Strings.Trim(Conversions.ToString(sqliteDataReader["Name"])) + "   (Internal)";
					}
					else
					{
						dataRow2["Item"] = sqliteDataReader["DefaultLoad"].ToString() + "x " + Strings.Trim(Conversions.ToString(sqliteDataReader["Name"]));
					}
					dataTable.Rows.Add(dataRow2);
					sqliteDataReader.Close();
				}
			}
			return dataTable;
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00201B98 File Offset: 0x001FFD98
		public static Loadout smethod_45(ref Scenario scenario_0, int int_0)
		{
			Loadout result;
			try
			{
				Class403 class403_ = new Class403(scenario_0.method_39());
				string string_ = "Select ComponentID from DataAircraftLoadouts where ID = " + Conversions.ToString(int_0);
				DataTable dataTable = Class401.smethod_1(class403_, string_);
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						Loadout loadout = DBFunctions.smethod_47(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), false, false);
						if (loadout.loadoutRole_0 == Loadout.LoadoutRole.Reserve)
						{
							return loadout;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = null;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101259", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00201C90 File Offset: 0x001FFE90
		public static Loadout smethod_46(ref Scenario scenario_0, int int_0)
		{
			Loadout result;
			try
			{
				Class403 class403_ = new Class403(scenario_0.method_39());
				string string_ = "Select ComponentID from DataAircraftLoadouts where ID = " + Conversions.ToString(int_0);
				DataTable dataTable = Class401.smethod_1(class403_, string_);
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						Loadout loadout = DBFunctions.smethod_47(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), false, false);
						if (loadout.loadoutRole_0 == Loadout.LoadoutRole.Unavailable)
						{
							return loadout;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = null;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101260", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x00201D88 File Offset: 0x001FFF88
		public static Loadout smethod_47(ref Scenario scenario_0, int int_0, bool bool_0, bool bool_1)
		{
			Class403 class403_ = new Class403(scenario_0.method_39());
			string string_ = "Select * from DataLoadout where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			if (dataTable.Rows.Count > 0)
			{
				DataRow dataRow = dataTable.Rows[0];
				if (!dataTable.Columns.Contains("QuickTurnaround"))
				{
					dataTable.Columns.Add("QuickTurnaround", typeof(string));
					dataRow["QuickTurnaround"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_ReadyTime"))
				{
					dataTable.Columns.Add("QuickTurnaround_ReadyTime", typeof(string));
					dataRow["QuickTurnaround_ReadyTime"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_MaxSorties"))
				{
					dataTable.Columns.Add("QuickTurnaround_MaxSorties", typeof(string));
					dataRow["QuickTurnaround_MaxSorties"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_AdditionalTimePenalty"))
				{
					dataTable.Columns.Add("QuickTurnaround_AdditionalTimePenalty", typeof(string));
					dataRow["QuickTurnaround_AdditionalTimePenalty"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_AirborneTime"))
				{
					dataTable.Columns.Add("QuickTurnaround_AirborneTime", typeof(string));
					dataRow["QuickTurnaround_AirborneTime"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_TimeofDay"))
				{
					dataTable.Columns.Add("QuickTurnaround_TimeofDay", typeof(string));
					dataRow["QuickTurnaround_TimeofDay"] = 0;
				}
				if (!dataTable.Columns.Contains("ReadyTime_Sustained"))
				{
					dataTable.Columns.Add("ReadyTime_Sustained", typeof(string));
					dataRow["ReadyTime_Sustained"] = 0;
				}
				if (!dataTable.Columns.Contains("WinchesterShotgun"))
				{
					dataTable.Columns.Add("WinchesterShotgun", typeof(string));
					dataRow["WinchesterShotgun"] = 0;
				}
				Loadout loadout = new Loadout(int_0, dataRow["Name"].ToString(), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Capacity"]), Conversions.ToInteger(dataRow["ReadyTime"]), Conversions.ToInteger(dataRow["ReadyTime_Sustained"]), (Loadout.LoadoutRole)Conversions.ToInteger(dataRow["LoadoutRole"]), (Loadout._LoadoutDayNight)Conversions.ToShort(dataRow["TimeofDay"]), (Loadout._LoadoutWeather)Conversions.ToShort(dataRow["Weather"]), Conversions.ToSingle(dataRow["PayloadWeightDragModifier"]), Conversions.ToInteger(dataRow["DefaultCombatRadius"]), Conversions.ToShort(dataRow["DefaultTimeOnStation"]), Conversions.ToBoolean(dataRow["RequiresBuddyIllumination"]), bool_0, Conversions.ToBoolean(dataRow["QuickTurnaround"]), Conversions.ToInteger(dataRow["QuickTurnaround_ReadyTime"]), Conversions.ToInteger(dataRow["QuickTurnaround_MaxSorties"]), Conversions.ToInteger(dataRow["QuickTurnaround_AdditionalTimePenalty"]), Conversions.ToInteger(dataRow["QuickTurnaround_AirborneTime"]), (Loadout._LoadoutDayNight)Conversions.ToShort(dataRow["QuickTurnaround_TimeofDay"]), (Doctrine._WeaponState)Conversions.ToInteger(dataRow["WinchesterShotgun"]));
				try
				{
					loadout.bool_14 = Conversions.ToBoolean(dataRow["Hypothetical"]);
				}
				catch (Exception ex)
				{
				}
				if (dataTable.Columns.Contains("Cargo_Crew"))
				{
					try
					{
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Crew"])))
						{
							loadout.float_1 = (float)Conversions.ToShort(dataRow["Cargo_Crew"]);
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Area"])))
						{
							loadout.float_2 = (float)Conversions.ToShort(dataRow["Cargo_Area"]);
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Type"])))
						{
							loadout.cargoType_0 = (CargoType)Conversions.ToInteger(dataRow["Cargo_Type"].ToString());
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Mass"])))
						{
							loadout.float_3 = (float)Conversions.ToShort(dataRow["Cargo_Mass"]);
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_ParadropCapable"])))
						{
							loadout.bool_15 = Conversions.ToBoolean(dataRow["Cargo_ParadropCapable"]);
						}
					}
					catch (Exception ex2)
					{
					}
				}
				DBFunctions.smethod_49(ref scenario_0, ref loadout, int_0, bool_0);
				if (bool_1)
				{
					DBFunctions.smethod_50(ref scenario_0, ref loadout);
				}
				return loadout;
			}
			throw new Exception1("This loadout ID does not exist in the database.");
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x00202278 File Offset: 0x00200478
		public static void smethod_48(ref Aircraft aircraft_0, int int_0, bool bool_0)
		{
			Class403 class403_ = new Class403(aircraft_0.scenario_0.method_39());
			string string_ = "Select * from DataLoadout where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			if (dataTable.Rows.Count > 0)
			{
				DataRow dataRow = dataTable.Rows[0];
				string text = dataRow["Name"].ToString();
				if (bool_0)
				{
					text += " - Mandatory Weapons Only";
				}
				if (!dataTable.Columns.Contains("QuickTurnaround"))
				{
					dataTable.Columns.Add("QuickTurnaround", typeof(string));
					dataRow["QuickTurnaround"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_ReadyTime"))
				{
					dataTable.Columns.Add("QuickTurnaround_ReadyTime", typeof(string));
					dataRow["QuickTurnaround_ReadyTime"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_MaxSorties"))
				{
					dataTable.Columns.Add("QuickTurnaround_MaxSorties", typeof(string));
					dataRow["QuickTurnaround_MaxSorties"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_AdditionalTimePenalty"))
				{
					dataTable.Columns.Add("QuickTurnaround_AdditionalTimePenalty", typeof(string));
					dataRow["QuickTurnaround_AdditionalTimePenalty"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_AirborneTime"))
				{
					dataTable.Columns.Add("QuickTurnaround_AirborneTime", typeof(string));
					dataRow["QuickTurnaround_AirborneTime"] = 0;
				}
				if (!dataTable.Columns.Contains("QuickTurnaround_TimeofDay"))
				{
					dataTable.Columns.Add("QuickTurnaround_TimeofDay", typeof(string));
					dataRow["QuickTurnaround_TimeofDay"] = 0;
				}
				if (!dataTable.Columns.Contains("ReadyTime_Sustained"))
				{
					dataTable.Columns.Add("ReadyTime_Sustained", typeof(string));
					dataRow["ReadyTime_Sustained"] = 0;
				}
				if (!dataTable.Columns.Contains("WinchesterShotgun"))
				{
					dataTable.Columns.Add("WinchesterShotgun", typeof(string));
					dataRow["WinchesterShotgun"] = 2001;
				}
				Loadout loadout = new Loadout(int_0, text, Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Capacity"]), Conversions.ToInteger(dataRow["ReadyTime"]), Conversions.ToInteger(dataRow["ReadyTime_Sustained"]), (Loadout.LoadoutRole)Conversions.ToInteger(dataRow["LoadoutRole"]), (Loadout._LoadoutDayNight)Conversions.ToShort(dataRow["TimeofDay"]), (Loadout._LoadoutWeather)Conversions.ToShort(dataRow["Weather"]), Conversions.ToSingle(dataRow["PayloadWeightDragModifier"]), Conversions.ToInteger(dataRow["DefaultCombatRadius"]), Conversions.ToShort(dataRow["DefaultTimeOnStation"]), Conversions.ToBoolean(dataRow["RequiresBuddyIllumination"]), bool_0, Conversions.ToBoolean(dataRow["QuickTurnaround"]), Conversions.ToInteger(dataRow["QuickTurnaround_ReadyTime"]), Conversions.ToInteger(dataRow["QuickTurnaround_MaxSorties"]), Conversions.ToInteger(dataRow["QuickTurnaround_AdditionalTimePenalty"]), Conversions.ToInteger(dataRow["QuickTurnaround_AirborneTime"]), (Loadout._LoadoutDayNight)Conversions.ToShort(dataRow["QuickTurnaround_TimeofDay"]), (Doctrine._WeaponState)Conversions.ToInteger(dataRow["WinchesterShotgun"]));
				try
				{
					loadout.bool_14 = Conversions.ToBoolean(dataRow["Hypothetical"]);
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200473", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				if (dataTable.Columns.Contains("Cargo_Crew"))
				{
					try
					{
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Crew"])))
						{
							loadout.float_1 = (float)Conversions.ToShort(dataRow["Cargo_Crew"]);
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Area"])))
						{
							loadout.float_2 = (float)Conversions.ToShort(dataRow["Cargo_Area"]);
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Type"])))
						{
							loadout.cargoType_0 = (CargoType)Conversions.ToInteger(dataRow["Cargo_Type"].ToString());
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Mass"])))
						{
							loadout.float_3 = (float)Conversions.ToShort(dataRow["Cargo_Mass"]);
						}
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_ParadropCapable"])))
						{
							loadout.bool_15 = Conversions.ToBoolean(dataRow["Cargo_ParadropCapable"]);
						}
						goto IL_525;
					}
					catch (Exception ex2)
					{
						goto IL_525;
					}
					goto IL_4E9;
				}
				IL_525:
				DBFunctions.smethod_49(ref aircraft_0.scenario_0, ref loadout, int_0, bool_0);
				DBFunctions.smethod_50(ref aircraft_0.scenario_0, ref loadout);
				aircraft_0.method_168(loadout);
				return;
			}
			IL_4E9:
			throw new Exception1(string.Concat(new string[]
			{
				"Unable to equip aircraft: ",
				aircraft_0.Name,
				" with loadout #ID: ",
				Conversions.ToString(int_0),
				". This loadout ID does not exist in the database."
			}));
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x002027F0 File Offset: 0x002009F0
		public static void smethod_49(ref Scenario scenario_0, ref Loadout loadout_0, int int_0, bool bool_0)
		{
			Class403 class403_ = new Class403(scenario_0.method_39());
			string string_ = "SELECT DataWeaponRecord.*, DataLoadoutWeapons.ComponentNumber, DataLoadoutWeapons.Optional, DataLoadoutWeapons.Internal from DataLoadoutWeapons, DataWeaponRecord, DataWeapon where DataWeaponRecord.ID =DataLoadoutWeapons.ComponentID And DataWeapon.ID=DataWeaponRecord.ComponentID And DataLoadoutWeapons.ID = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Type, DataWeapon.Name";
			DataTable dataTable;
			try
			{
				dataTable = Class401.smethod_1(class403_, string_);
			}
			catch (Exception ex)
			{
				string_ = "SELECT DataWeaponRecord.*, DataLoadoutWeapons.ComponentNumber from DataLoadoutWeapons, DataWeaponRecord, DataWeapon where DataWeaponRecord.ID =DataLoadoutWeapons.ComponentID And DataWeapon.ID=DataWeaponRecord.ComponentID And DataLoadoutWeapons.ID = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Type, DataWeapon.Name";
				dataTable = Class401.smethod_1(class403_, string_);
			}
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				bool flag = dataTable.Columns.Contains("Optional") && Conversions.ToBoolean(dataRow["Optional"]);
				bool bool_ = dataTable.Columns.Contains("Internal") && Conversions.ToBoolean(dataRow["Internal"]);
				if (!flag || !bool_0)
				{
					WeaponRec weaponRec_ = new WeaponRec(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), Conversions.ToInteger(dataRow["DefaultLoad"]), Conversions.ToInteger(dataRow["MaxLoad"]), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Multiple"]), flag, bool_);
					loadout_0.method_16(weaponRec_);
				}
			}
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x00202958 File Offset: 0x00200B58
		public static void smethod_50(ref Scenario scenario_0, ref Loadout loadout_0)
		{
			try
			{
				int num;
				int num2;
				foreach (WeaponRec weaponRec in loadout_0.weaponRec_0)
				{
					num += weaponRec.method_12(scenario_0).int_0 * weaponRec.method_9();
					if (loadout_0.method_15(scenario_0).bool_6)
					{
						Weapon weapon = weaponRec.method_12(scenario_0);
						if (weapon.method_195() || weapon.method_196() || weapon.method_198())
						{
							num2 += weapon.int_0 * weaponRec.method_9();
						}
					}
				}
				loadout_0.int_5 = num;
				loadout_0.int_6 = num2;
				loadout_0.int_7 = num;
				loadout_0.int_8 = num2;
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x00202A2C File Offset: 0x00200C2C
		public static void smethod_51(ref Scenario scenario_0, ref Loadout loadout_0)
		{
			try
			{
				int num;
				int num2;
				foreach (WeaponRec weaponRec in loadout_0.weaponRec_0)
				{
					num += weaponRec.method_12(scenario_0).int_0 * weaponRec.method_9();
					if (loadout_0.method_15(scenario_0).bool_6)
					{
						Weapon weapon = weaponRec.method_12(scenario_0);
						if (weapon.method_195() || weapon.method_196() || weapon.method_198())
						{
							num2 += weapon.int_0 * weaponRec.method_9();
						}
					}
				}
				loadout_0.int_5 = num;
				loadout_0.int_6 = num2;
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00202AF0 File Offset: 0x00200CF0
		public static void smethod_52(ref Scenario scenario_0, ref Loadout loadout_0)
		{
			try
			{
				int num;
				int num2;
				foreach (WeaponRec weaponRec in loadout_0.weaponRec_0)
				{
					num += weaponRec.method_12(scenario_0).int_0 * weaponRec.method_9();
					if (loadout_0.method_15(scenario_0).bool_6)
					{
						Weapon weapon = weaponRec.method_12(scenario_0);
						if (weapon.method_195() || weapon.method_196() || weapon.method_198())
						{
							num2 += weapon.int_0 * weaponRec.method_9();
						}
					}
				}
				loadout_0.int_7 = num;
				loadout_0.int_8 = num2;
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00202BB4 File Offset: 0x00200DB4
		public static void smethod_53(ref Scenario theScen, ref Ship theShip, int ShipDBID, bool LoadComponents = true)
		{
			Class403 class403_ = new Class403(theScen.method_39());
			string string_ = "Select * from DataShip where ID = " + Conversions.ToString(ShipDBID);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int count = dataTable.Rows.Count;
			if (count == 0)
			{
				throw new Exception("No ship with ID: " + Conversions.ToString(ShipDBID) + " was found in the current database!");
			}
			int num = count - 1;
			int i = 0;
			while (i <= num)
			{
				DataRow dataRow = dataTable.Rows[i];
				if (!dataTable.Columns.Contains("OODADetectionCycle"))
				{
					dataTable.Columns.Add("OODADetectionCycle", typeof(string));
					dataRow["OODADetectionCycle"] = 0;
				}
				if (!dataTable.Columns.Contains("OODATargetingCycle"))
				{
					dataTable.Columns.Add("OODATargetingCycle", typeof(string));
					dataRow["OODATargetingCycle"] = 0;
				}
				if (!dataTable.Columns.Contains("OODAEvasiveCycle"))
				{
					dataTable.Columns.Add("OODAEvasiveCycle", typeof(string));
					dataRow["OODAEvasiveCycle"] = 0;
				}
				theShip.enum118_0 = (Ship.Enum118)Conversions.ToInteger(dataRow["Category"].ToString());
				theShip._ShipType_0 = (Ship._ShipType)Conversions.ToInteger(dataRow["Type"].ToString());
				theShip.DBID = ShipDBID;
				theShip.string_2 = Strings.Trim(dataRow["Name"].ToString());
				theShip.float_13 = Conversions.ToSingle(dataRow["Length"].ToString());
				try
				{
					theShip.enum50_0 = (DockFacility.Enum50)Conversions.ToShort(dataRow["PhysicalSizeCode"].ToString());
					goto IL_41B;
				}
				catch (Exception ex)
				{
					float float_ = theShip.float_13;
					if (float_ <= 11f)
					{
						theShip.enum50_0 = DockFacility.Enum50.const_1;
					}
					else if (float_ <= 17f)
					{
						theShip.enum50_0 = DockFacility.Enum50.const_2;
					}
					else if (float_ <= 25f)
					{
						theShip.enum50_0 = DockFacility.Enum50.const_3;
					}
					else if (float_ <= 45f)
					{
						theShip.enum50_0 = DockFacility.Enum50.const_4;
					}
					else if (float_ <= 200f)
					{
						theShip.enum50_0 = DockFacility.Enum50.const_5;
					}
					else
					{
						theShip.enum50_0 = DockFacility.Enum50.const_6;
					}
					ex.Data.Add("Error at 200072", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					goto IL_41B;
				}
				goto Block_7;
				IL_353:
				theShip.short_0 = Conversions.ToShort(dataRow["OODADetectionCycle"].ToString());
				theShip.short_1 = Conversions.ToShort(dataRow["OODATargetingCycle"].ToString());
				theShip.short_2 = Conversions.ToShort(dataRow["OODAEvasiveCycle"].ToString());
				theShip.int_3 = Conversions.ToInteger(dataRow["OperatorCountry"].ToString());
				try
				{
					theShip.bool_23 = Conversions.ToBoolean(dataRow["Hypothetical"]);
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 200475", ex2.Message);
					GameGeneral.smethod_25(ref ex2);
					bool isAttached = Debugger.IsAttached;
				}
				i++;
				continue;
				Block_7:
				try
				{
					IL_285:
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Crew"])))
					{
						theShip.float_28 = (float)Conversions.ToShort(dataRow["Cargo_Crew"]);
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Area"])))
					{
						theShip.float_29 = (float)Conversions.ToShort(dataRow["Cargo_Area"]);
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Type"])))
					{
						theShip.cargoType_0 = (CargoType)Conversions.ToInteger(dataRow["Cargo_Type"].ToString());
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Mass"])))
					{
						theShip.float_30 = (float)Conversions.ToShort(dataRow["Cargo_Mass"]);
					}
				}
				catch (Exception ex3)
				{
				}
				goto IL_353;
				IL_41B:
				theShip.int_6 = Conversions.ToInteger(dataRow["Crew"]);
				theShip.armorRating_2 = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorBelt"]);
				theShip.armorRating_0 = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorBridge"]);
				theShip.armorRating_3 = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorBulkheads"]);
				theShip.armorRating_5 = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorCIC"]);
				theShip.armorRating_4 = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorDeck"]);
				theShip.armorRating_1 = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorEngineering"]);
				theShip.armorRating_6 = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorRudder"]);
				theShip.byte_0 = Conversions.ToByte(dataRow["MaxSeaState"]);
				theShip.short_3 = (short)Conversions.ToInteger(dataRow["RepairCapacity"]);
				theShip.short_4 = (short)Conversions.ToInteger(dataRow["TroopCapacity"]);
				theShip.int_7 = Conversions.ToInteger(dataRow["CargoCapacity"]);
				theShip.short_5 = Conversions.ToShort(dataRow["MissileDefense"]);
				theShip.method_61(Conversions.ToInteger(dataRow["DamagePoints"]));
				theShip.vmethod_64(false, null, Conversions.ToSingle(dataRow["DamagePoints"]));
				theShip.imethod_5(Conversions.ToSingle(dataRow["DisplacementEmpty"]));
				theShip.imethod_7(Conversions.ToSingle(dataRow["DisplacementStandard"]));
				theShip.imethod_9(Conversions.ToSingle(dataRow["DisplacementFull"]));
				theShip.int_0 = (int)Math.Round((double)theShip.imethod_6());
				theShip.float_25 = Conversions.ToSingle(dataRow["Beam"]);
				theShip.float_26 = Conversions.ToSingle(dataRow["Draft"]);
				theShip.float_27 = Conversions.ToSingle(dataRow["Height"]);
				if (dataTable.Columns.Contains("Cargo_Crew"))
				{
					goto IL_285;
				}
				goto IL_353;
			}
			DBFunctions.smethod_54(ref theShip, ShipDBID);
			if (LoadComponents)
			{
				DBFunctions.smethod_99(theShip, ShipDBID);
				DBFunctions.smethod_87(theShip, ShipDBID);
				ActiveUnit activeUnit = theShip;
				DBFunctions.smethod_112(ref theScen, ref activeUnit, ShipDBID);
				DBFunctions.smethod_86(theShip, ShipDBID);
				DBFunctions.smethod_107(theShip, ShipDBID);
				Class350 @class = theShip;
				DBFunctions.smethod_80(ref @class, ShipDBID);
				@class = theShip;
				DBFunctions.smethod_75(ref @class, ShipDBID);
				@class = theShip;
				DBFunctions.smethod_76(ref @class, ShipDBID);
			}
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00203278 File Offset: 0x00201478
		public static void smethod_54(ref Ship ship_0, int int_0)
		{
			Class403 class403_ = new Class403(ship_0.scenario_0.method_39());
			string string_ = "Select * from DataShipCodes where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				int num2 = Conversions.ToInteger(dataTable.Rows[i]["CodeID"]);
				if (num2 <= 4012)
				{
					if (num2 <= 1011)
					{
						if (num2 != 1001)
						{
							if (num2 != 1002)
							{
								if (num2 != 1011)
								{
									goto IL_54F;
								}
								ship_0.struct34_0.bool_7 = true;
							}
							else
							{
								ship_0.struct34_0.bool_2 = true;
							}
						}
						else
						{
							ship_0.struct34_0.bool_5 = true;
						}
					}
					else if (num2 <= 2001)
					{
						if (num2 != 1012)
						{
							if (num2 != 2001)
							{
								goto IL_54F;
							}
							ship_0.struct34_0.bool_3 = true;
						}
						else
						{
							ship_0.struct34_0.bool_8 = true;
						}
					}
					else
					{
						switch (num2)
						{
						case 3001:
							ship_0.struct34_0.bool_0 = true;
							break;
						case 3002:
							ship_0.struct34_0.bool_1 = true;
							break;
						case 3003:
							ship_0.struct34_0.bool_6 = true;
							break;
						case 3004:
							ship_0.struct34_0.bool_4 = true;
							break;
						default:
							switch (num2)
							{
							case 4001:
								ship_0.struct34_0.bool_13 = true;
								break;
							case 4002:
								ship_0.struct34_0.bool_14 = true;
								break;
							case 4003:
								ship_0.struct34_0.bool_15 = true;
								break;
							case 4004:
							case 4005:
							case 4008:
							case 4009:
							case 4010:
								goto IL_54F;
							case 4006:
								ship_0.struct34_0.bool_16 = true;
								break;
							case 4007:
								ship_0.struct34_0.bool_17 = true;
								break;
							case 4011:
								ship_0.struct34_0.bool_18 = true;
								break;
							case 4012:
								ship_0.struct34_0.bool_19 = true;
								break;
							default:
								goto IL_54F;
							}
							break;
						}
					}
				}
				else if (num2 <= 6004)
				{
					if (num2 != 4020)
					{
						if (num2 != 4022)
						{
							switch (num2)
							{
							case 6001:
								ship_0.struct34_0.bool_9 = true;
								break;
							case 6002:
								ship_0.struct34_0.bool_10 = true;
								break;
							case 6003:
								ship_0.struct34_0.bool_11 = true;
								break;
							case 6004:
								ship_0.struct34_0.bool_12 = true;
								break;
							default:
								goto IL_54F;
							}
						}
						else
						{
							ship_0.struct34_0.bool_21 = true;
						}
					}
					else
					{
						ship_0.struct34_0.bool_20 = true;
					}
				}
				else if (num2 <= 8112)
				{
					switch (num2)
					{
					case 8001:
						ship_0.struct26_0.byte_5 = 1;
						break;
					case 8002:
						ship_0.struct26_0.byte_5 = 2;
						break;
					case 8003:
						ship_0.struct26_0.byte_5 = 3;
						break;
					case 8004:
						ship_0.struct26_0.byte_5 = 4;
						break;
					case 8005:
						ship_0.struct26_0.byte_7 = 1;
						break;
					case 8006:
						ship_0.struct26_0.byte_7 = 2;
						break;
					case 8007:
						ship_0.struct26_0.byte_7 = 3;
						break;
					case 8008:
						ship_0.struct26_0.byte_7 = 4;
						break;
					case 8009:
					case 8010:
						goto IL_54F;
					case 8011:
						ship_0.struct26_0.byte_3 = 1;
						break;
					case 8012:
						ship_0.struct26_0.byte_3 = 2;
						break;
					default:
						switch (num2)
						{
						case 8101:
							ship_0.struct26_0.byte_4 = 1;
							break;
						case 8102:
							ship_0.struct26_0.byte_4 = 2;
							break;
						case 8103:
							ship_0.struct26_0.byte_4 = 3;
							break;
						case 8104:
							ship_0.struct26_0.byte_4 = 4;
							break;
						case 8105:
							ship_0.struct26_0.byte_4 = 5;
							break;
						case 8106:
							ship_0.struct26_0.byte_6 = 1;
							break;
						case 8107:
							ship_0.struct26_0.byte_6 = 2;
							break;
						case 8108:
							ship_0.struct26_0.byte_6 = 3;
							break;
						case 8109:
							ship_0.struct26_0.byte_6 = 4;
							break;
						case 8110:
							ship_0.struct26_0.byte_6 = 5;
							break;
						case 8111:
							ship_0.struct26_0.byte_2 = 1;
							break;
						case 8112:
							ship_0.struct26_0.byte_2 = 2;
							break;
						default:
							goto IL_54F;
						}
						break;
					}
				}
				else
				{
					switch (num2)
					{
					case 9001:
						ship_0.struct26_0.byte_9 = 1;
						break;
					case 9002:
						ship_0.struct26_0.byte_9 = 2;
						break;
					case 9003:
						ship_0.struct26_0.byte_9 = 3;
						break;
					case 9004:
						ship_0.struct26_0.byte_9 = 4;
						break;
					case 9005:
						ship_0.struct26_0.byte_11 = 1;
						break;
					case 9006:
						ship_0.struct26_0.byte_11 = 2;
						break;
					case 9007:
						ship_0.struct26_0.byte_11 = 3;
						break;
					case 9008:
						ship_0.struct26_0.byte_11 = 4;
						break;
					default:
						switch (num2)
						{
						case 9101:
							ship_0.struct26_0.byte_8 = 1;
							goto IL_666;
						case 9102:
							ship_0.struct26_0.byte_8 = 2;
							goto IL_666;
						case 9103:
							ship_0.struct26_0.byte_8 = 3;
							goto IL_666;
						case 9104:
							ship_0.struct26_0.byte_8 = 4;
							goto IL_666;
						case 9105:
							ship_0.struct26_0.byte_10 = 1;
							goto IL_666;
						case 9106:
							ship_0.struct26_0.byte_10 = 2;
							goto IL_666;
						case 9107:
							ship_0.struct26_0.byte_10 = 3;
							goto IL_666;
						case 9108:
							ship_0.struct26_0.byte_10 = 4;
							goto IL_666;
						}
						goto IL_54F;
					}
				}
				IL_666:
				i++;
				continue;
				IL_54F:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					goto IL_666;
				}
				goto IL_666;
			}
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x002038F8 File Offset: 0x00201AF8
		public static void smethod_55(ref Scenario theScen, ref Submarine theSub, int SubDBID, bool LoadComponents = true)
		{
			Class403 class403_ = new Class403(theScen.method_39());
			string string_ = "Select * from DataSubmarine where ID = " + Conversions.ToString(SubDBID);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception("No submarine with ID: " + Conversions.ToString(SubDBID) + " was found in the current database!");
			}
			DataRow dataRow = dataTable.Rows[0];
			if (!dataTable.Columns.Contains("OODADetectionCycle"))
			{
				dataTable.Columns.Add("OODADetectionCycle", typeof(string));
				dataRow["OODADetectionCycle"] = 0;
			}
			if (!dataTable.Columns.Contains("OODATargetingCycle"))
			{
				dataTable.Columns.Add("OODATargetingCycle", typeof(string));
				dataRow["OODATargetingCycle"] = 0;
			}
			if (!dataTable.Columns.Contains("OODAEvasiveCycle"))
			{
				dataTable.Columns.Add("OODAEvasiveCycle", typeof(string));
				dataRow["OODAEvasiveCycle"] = 0;
			}
			theSub.enum120_0 = (Submarine.Enum120)Conversions.ToInteger(dataRow["Category"]);
			theSub._SubmarineType_0 = (Submarine._SubmarineType)Conversions.ToInteger(dataRow["Type"]);
			theSub.DBID = SubDBID;
			theSub.string_2 = Strings.Trim(dataRow["Name"].ToString());
			theSub.float_13 = Conversions.ToSingle(dataRow["Length"]);
			try
			{
				theSub.enum50_0 = (DockFacility.Enum50)Conversions.ToShort(dataRow["PhysicalSizeCode"]);
			}
			catch (Exception ex)
			{
				float float_ = theSub.float_13;
				if (float_ <= 11f)
				{
					theSub.enum50_0 = DockFacility.Enum50.const_1;
				}
				else if (float_ <= 17f)
				{
					theSub.enum50_0 = DockFacility.Enum50.const_2;
				}
				else if (float_ <= 25f)
				{
					theSub.enum50_0 = DockFacility.Enum50.const_3;
				}
				else if (float_ <= 45f)
				{
					theSub.enum50_0 = DockFacility.Enum50.const_4;
				}
				else if (float_ <= 200f)
				{
					theSub.enum50_0 = DockFacility.Enum50.const_5;
				}
				else
				{
					theSub.enum50_0 = DockFacility.Enum50.const_6;
				}
				ex.Data.Add("Error at 200074", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			theSub.int_0 = (int)Math.Round(Conversions.ToDouble(dataRow["DisplacementStandard"].ToString()));
			theSub.int_6 = Conversions.ToInteger(dataRow["Crew"]);
			theSub.int_7 = Conversions.ToInteger(dataRow["MaxDepth"]);
			theSub.method_61(Conversions.ToInteger(dataRow["DamagePoints"]));
			theSub.vmethod_64(false, null, Conversions.ToSingle(dataRow["DamagePoints"]));
			theSub.method_154().vmethod_15(true, 1f);
			theSub.float_25 = Conversions.ToSingle(dataRow["Beam"]);
			theSub.float_26 = Conversions.ToSingle(dataRow["Draft"]);
			theSub.float_27 = Conversions.ToSingle(dataRow["Height"]);
			if (dataTable.Columns.Contains("DisplacementEmpty"))
			{
				theSub.imethod_5(Conversions.ToSingle(dataRow["DisplacementEmpty"]));
			}
			if (dataTable.Columns.Contains("DisplacementStandard"))
			{
				theSub.imethod_7(Conversions.ToSingle(dataRow["DisplacementStandard"]));
			}
			if (dataTable.Columns.Contains("DisplacementFull"))
			{
				theSub.imethod_9(Conversions.ToSingle(dataRow["DisplacementFull"]));
			}
			theSub.short_1 = Conversions.ToShort(dataRow["OODADetectionCycle"].ToString());
			theSub.short_1 = Conversions.ToShort(dataRow["OODATargetingCycle"].ToString());
			theSub.short_2 = Conversions.ToShort(dataRow["OODAEvasiveCycle"].ToString());
			theSub.int_3 = Conversions.ToInteger(dataRow["OperatorCountry"].ToString());
			if (dataTable.Columns.Contains("ROVRadius"))
			{
				theSub.short_3 = Conversions.ToShort(dataRow["ROVRadius"].ToString());
			}
			try
			{
				theSub.bool_23 = Conversions.ToBoolean(dataRow["Hypothetical"]);
			}
			catch (Exception ex2)
			{
			}
			DBFunctions.smethod_56(theSub, SubDBID);
			if (LoadComponents)
			{
				DBFunctions.smethod_99(theSub, SubDBID);
				DBFunctions.smethod_87(theSub, SubDBID);
				ActiveUnit activeUnit = theSub;
				DBFunctions.smethod_112(ref theScen, ref activeUnit, SubDBID);
				DBFunctions.smethod_86(theSub, SubDBID);
				DBFunctions.smethod_107(theSub, SubDBID);
				Class350 @class = theSub;
				DBFunctions.smethod_80(ref @class, SubDBID);
				@class = theSub;
				DBFunctions.smethod_76(ref @class, SubDBID);
			}
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00203DE0 File Offset: 0x00201FE0
		public static void smethod_56(Submarine submarine_0, int int_0)
		{
			Class403 class403_ = new Class403(submarine_0.scenario_0.method_39());
			string string_ = "Select * from DataSubmarineCodes where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				int num2 = Conversions.ToInteger(dataTable.Rows[i]["CodeID"]);
				if (num2 <= 2002)
				{
					switch (num2)
					{
					case 1001:
						submarine_0.struct35_0.bool_0 = true;
						break;
					case 1002:
						submarine_0.struct35_0.bool_1 = true;
						break;
					case 1003:
						submarine_0.struct35_0.bool_2 = true;
						break;
					case 1004:
						submarine_0.struct35_0.bool_3 = true;
						break;
					case 1005:
						submarine_0.struct35_0.bool_4 = true;
						break;
					default:
						if (num2 == 2001)
						{
							goto IL_12F;
						}
						if (num2 != 2002)
						{
							goto IL_113;
						}
						submarine_0.struct35_0.bool_6 = true;
						break;
					}
				}
				else if (num2 != 4001)
				{
					if (num2 == 4004)
					{
						goto IL_12F;
					}
					if (num2 != 9001)
					{
						goto IL_113;
					}
					submarine_0.struct35_0.bool_7 = true;
				}
				else
				{
					submarine_0.struct35_0.bool_8 = true;
				}
				IL_149:
				i++;
				continue;
				IL_113:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					goto IL_149;
				}
				goto IL_149;
				IL_12F:
				submarine_0.struct35_0.bool_5 = true;
				goto IL_149;
			}
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00203F44 File Offset: 0x00202144
		public static void smethod_57(ref Scenario theScen, ref Facility theFac, int FacilityDBID, bool LoadComponents = true)
		{
			Class403 class403_ = new Class403(theScen.method_39());
			string string_ = "Select * from DataFacility where ID = " + Conversions.ToString(FacilityDBID);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int count = dataTable.Rows.Count;
			if (count == 0)
			{
				throw new Exception("No facility with ID: " + Conversions.ToString(FacilityDBID) + " was found in the current database!");
			}
			int num = count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				if (!dataTable.Columns.Contains("OODADetectionCycle"))
				{
					dataTable.Columns.Add("OODADetectionCycle", typeof(string));
					dataRow["OODADetectionCycle"] = 0;
				}
				if (!dataTable.Columns.Contains("OODATargetingCycle"))
				{
					dataTable.Columns.Add("OODATargetingCycle", typeof(string));
					dataRow["OODATargetingCycle"] = 0;
				}
				if (!dataTable.Columns.Contains("OODAEvasiveCycle"))
				{
					dataTable.Columns.Add("OODAEvasiveCycle", typeof(string));
					dataRow["OODAEvasiveCycle"] = 0;
				}
				theFac.DBID = FacilityDBID;
				theFac.string_2 = dataRow["Name"].ToString();
				theFac.armorRating_0 = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorGeneral"]);
				theFac.int_7 = Conversions.ToInteger(dataRow["MastHeight"]);
				theFac.int_8 = Conversions.ToInteger(dataRow["MissileDefense"]);
				theFac.method_61(Conversions.ToInteger(dataRow["DamagePoints"]));
				theFac.vmethod_64(false, null, Conversions.ToSingle(dataRow["DamagePoints"]));
				theFac._FacilityCategory_0 = (Facility._FacilityCategory)Conversions.ToShort(dataRow["Category"]);
				theFac.float_13 = Conversions.ToSingle(dataRow["Length"]);
				theFac.float_25 = Conversions.ToSingle(dataRow["Width"]);
				theFac.double_4 = Conversions.ToDouble(dataRow["Area"]);
				theFac.bool_27 = Conversions.ToBoolean(dataRow["MountsAreAimpoints"]);
				theFac.int_9 = Conversions.ToInteger(dataRow["Radius"]);
				theFac.short_0 = Conversions.ToShort(dataRow["OODADetectionCycle"].ToString());
				theFac.short_1 = Conversions.ToShort(dataRow["OODATargetingCycle"].ToString());
				theFac.short_2 = Conversions.ToShort(dataRow["OODAEvasiveCycle"].ToString());
				theFac.int_3 = Conversions.ToInteger(dataRow["OperatorCountry"].ToString());
				try
				{
					theFac.bool_23 = Conversions.ToBoolean(dataRow["Hypothetical"]);
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200476", ex.Message);
					GameGeneral.smethod_25(ref ex);
					bool isAttached = Debugger.IsAttached;
				}
			}
			if (LoadComponents)
			{
				DBFunctions.smethod_99(theFac, FacilityDBID);
				DBFunctions.smethod_87(theFac, FacilityDBID);
				ActiveUnit activeUnit = theFac;
				DBFunctions.smethod_112(ref theScen, ref activeUnit, FacilityDBID);
				DBFunctions.smethod_107(theFac, FacilityDBID);
				Class350 @class = theFac;
				DBFunctions.smethod_80(ref @class, FacilityDBID);
				@class = theFac;
				DBFunctions.smethod_75(ref @class, FacilityDBID);
				@class = theFac;
				DBFunctions.smethod_76(ref @class, FacilityDBID);
			}
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x002042BC File Offset: 0x002024BC
		public static Weapon._WeaponType smethod_58(int int_0, Scenario scenario_0)
		{
			Class403 class403_ = new Class403(scenario_0.method_39());
			string string_ = "SELECT Type from DataWeapon where ID = " + Conversions.ToString(int_0);
			Weapon._WeaponType weaponType = (Weapon._WeaponType)Conversions.ToInteger(Class401.smethod_2(class403_, string_));
			if (weaponType == Weapon._WeaponType.GuidedWeapon)
			{
				string_ = "SELECT COUNT(*) from DataWeaponCodes where ID = " + Conversions.ToString(int_0) + " AND CodeID = 4010";
				if (Conversions.ToInteger(Class401.smethod_2(class403_, string_)) > 0)
				{
					weaponType = Weapon._WeaponType.BallisticMissile;
				}
			}
			return weaponType;
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00204328 File Offset: 0x00202528
		public static WeaponRec smethod_59(int int_0, Scenario scenario_0)
		{
			Class403 class403_ = new Class403(scenario_0.method_39());
			string string_ = "SELECT * from DataWeaponRecord where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception1();
			}
			DataRow dataRow = dataTable.Rows[0];
			bool bool_ = dataTable.Columns.Contains("Optional") && Conversions.ToBoolean(dataRow["Optional"]);
			bool bool_2 = dataTable.Columns.Contains("Internal") && Conversions.ToBoolean(dataRow["Internal"]);
			return new WeaponRec(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), Conversions.ToInteger(dataRow["DefaultLoad"]), Conversions.ToInteger(dataRow["MaxLoad"]), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Multiple"]), bool_, bool_2);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x0020442C File Offset: 0x0020262C
		public static void smethod_60(SQLiteConnection theConn, Weapon theWeapon, int WeaponDBID, Scenario theScen, bool LoadComponents = true)
		{
			try
			{
				Class403 class403_ = new Class403(theConn);
				string string_ = "SELECT * from DataWeapon where ID = " + Conversions.ToString(WeaponDBID);
				DataTable dataTable = Class401.smethod_1(class403_, string_);
				DataRow dataRow = dataTable.Rows[0];
				if (!dataTable.Columns.Contains("TorpedoRangeCruise"))
				{
					dataTable.Columns.Add("TorpedoRangeCruise", typeof(string));
					dataRow["TorpedoRangeCruise"] = 0;
				}
				if (!dataTable.Columns.Contains("TorpedoRangeFull"))
				{
					dataTable.Columns.Add("TorpedoRangeFull", typeof(string));
					dataRow["TorpedoRangeFull"] = 0;
				}
				if (!dataTable.Columns.Contains("LandRangeMax"))
				{
					dataTable.Columns.Add("LandRangeMax", typeof(string));
					dataRow["LandRangeMax"] = 0;
				}
				if (!dataTable.Columns.Contains("LandRangeMin"))
				{
					dataTable.Columns.Add("LandRangeMin", typeof(string));
					dataRow["LandRangeMin"] = 0;
				}
				if (!dataTable.Columns.Contains("LandPOK"))
				{
					try
					{
						dataTable.Columns.Add("LandPOK", typeof(string));
					}
					catch (Exception ex)
					{
					}
					dataRow["LandPOK"] = 0;
				}
				if (!dataTable.Columns.Contains("CEPSurface"))
				{
					try
					{
						dataTable.Columns.Add("CEPSurface", typeof(string));
					}
					catch (Exception ex2)
					{
					}
					dataRow["CEPSurface"] = 0;
				}
				if (dataTable.Columns.Contains("SnapUpDownAltitude"))
				{
					theWeapon.float_47 = Conversions.ToSingle(dataRow["SnapUpDownAltitude"]);
				}
				string text = Strings.Trim(Misc.smethod_9(Conversions.ToString(dataRow["Name"])));
				theWeapon.DBID = WeaponDBID;
				theWeapon.string_2 = text;
				theWeapon.Name = text;
				if (theWeapon.GetType() == typeof(Weapon))
				{
					theWeapon.method_168((Weapon._WeaponType)Conversions.ToShort(dataRow["Type"]));
				}
				theWeapon.method_144((GlobalVariables.TechGenerationClass)Conversions.ToInteger(dataRow["Generation"]));
				theWeapon.float_13 = Conversions.ToSingle(dataRow["Length"]);
				theWeapon.float_25 = Conversions.ToSingle(dataRow["Span"]);
				theWeapon.float_26 = Conversions.ToSingle(dataRow["Diameter"]);
				theWeapon.int_0 = Conversions.ToInteger(dataRow["Weight"]);
				theWeapon.int_1 = Conversions.ToInteger(dataRow["Weight"]);
				theWeapon.int_6 = Conversions.ToInteger(dataRow["BurnoutWeight"]);
				try
				{
					theWeapon.int_7 = Conversions.ToInteger(dataRow["CEPSurface"]);
					if (theWeapon.int_7 == 0)
					{
						theWeapon.int_7 = Conversions.ToInteger(dataRow["CEP"]);
					}
				}
				catch (Exception ex3)
				{
					theWeapon.int_7 = Conversions.ToInteger(dataRow["CEP"]);
				}
				theWeapon.method_173(theWeapon.int_7);
				theWeapon.int_9 = Conversions.ToInteger(dataRow["CEP"]);
				theWeapon.method_175(theWeapon.int_9);
				theWeapon.float_50 = Conversions.ToSingle(dataRow["DetonationDelay"]);
				theWeapon.bool_27 = Conversions.ToBoolean(dataRow["CanActAsSensor"]);
				if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theConn))
				{
					theWeapon.method_146(Conversions.ToSingle(dataRow["CruiseAltitude_ASL"]));
				}
				else
				{
					theWeapon.method_146(Conversions.ToSingle(dataRow["CruiseAltitude"]));
				}
				theWeapon.float_27 = Conversions.ToSingle(dataRow["CruiseAltitude"]);
				theWeapon.int_11 = Conversions.ToInteger(dataRow["WaypointNumber"]);
				theWeapon.int_12 = Conversions.ToInteger(dataRow["IlluminationTime"]);
				theWeapon.int_14 = Conversions.ToInteger(dataRow["SurfacePOK"]);
				try
				{
					theWeapon.int_15 = Conversions.ToInteger(dataRow["LandPOK"]);
				}
				catch (Exception ex4)
				{
					theWeapon.int_15 = 0;
				}
				theWeapon.int_16 = Conversions.ToInteger(dataRow["SubsurfacePOK"]);
				theWeapon.int_13 = Conversions.ToInteger(dataRow["AirPOK"]);
				theWeapon.vmethod_143().vmethod_15(true, Conversions.ToSingle(dataRow["ClimbRate"]));
				theWeapon.int_17 = Conversions.ToInteger(dataRow["LaunchSpeedMax"]);
				theWeapon.int_18 = Conversions.ToInteger(dataRow["LaunchSpeedMin"]);
				theWeapon.float_29 = Conversions.ToSingle(dataRow["AirRangeMax"]);
				theWeapon.float_30 = Conversions.ToSingle(dataRow["AirRangeMin"]);
				theWeapon.float_31 = Conversions.ToSingle(dataRow["SurfaceRangeMax"]);
				theWeapon.float_32 = Conversions.ToSingle(dataRow["SurfaceRangeMin"]);
				theWeapon.float_33 = Conversions.ToSingle(dataRow["LandRangeMax"]);
				theWeapon.float_34 = Conversions.ToSingle(dataRow["LandRangeMin"]);
				theWeapon.float_35 = Conversions.ToSingle(dataRow["SubsurfaceRangeMax"]);
				theWeapon.float_36 = Conversions.ToSingle(dataRow["SubsurfaceRangeMin"]);
				theWeapon.float_38 = Conversions.ToSingle(dataRow["TorpedoRangeFull"]);
				theWeapon.float_37 = Conversions.ToSingle(dataRow["TorpedoRangeCruise"]);
				if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theConn))
				{
					theWeapon.float_44 = (float)Math.Round((double)Conversions.ToSingle(dataRow["LaunchAltitudeMax_ASL"]), 1);
					theWeapon.float_43 = (float)Math.Round((double)Conversions.ToSingle(dataRow["LaunchAltitudeMin_ASL"]), 1);
					theWeapon.float_46 = (float)Math.Round((double)Conversions.ToSingle(dataRow["TargetAltitudeMax_ASL"]), 1);
					theWeapon.float_45 = (float)Math.Round((double)Conversions.ToSingle(dataRow["TargetAltitudeMin_ASL"]), 1);
				}
				theWeapon.float_40 = (float)Math.Round((double)Conversions.ToSingle(dataRow["LaunchAltitudeMax"]), 1);
				theWeapon.float_39 = (float)Math.Round((double)Conversions.ToSingle(dataRow["LaunchAltitudeMin"]), 1);
				theWeapon.float_42 = (float)Math.Round((double)Conversions.ToSingle(dataRow["TargetAltitudeMax"]), 1);
				theWeapon.float_41 = (float)Math.Round((double)Conversions.ToSingle(dataRow["TargetAltitudeMin"]), 1);
				theWeapon.int_20 = Conversions.ToInteger(dataRow["TargetSpeedMax"]);
				theWeapon.int_19 = Conversions.ToInteger(dataRow["TargetSpeedMin"]);
				theWeapon.method_61(1);
				theWeapon.vmethod_64(false, null, 1f);
				try
				{
					theWeapon.bool_23 = Conversions.ToBoolean(dataRow["Hypothetical"]);
				}
				catch (Exception ex5)
				{
					ex5.Data.Add("Error at 200477", ex5.Message);
					GameGeneral.smethod_25(ref ex5);
					bool isAttached = Debugger.IsAttached;
				}
				if (theScen.FeatureCompatibility.get_WeaponAGL_ASL(theScen.method_39()))
				{
					theWeapon.method_146(Conversions.ToSingle(dataRow["CruiseAltitude_ASL"]));
					theWeapon.float_44 = (float)Math.Round((double)Conversions.ToSingle(dataRow["LaunchAltitudeMax_ASL"]), 1);
					theWeapon.float_43 = (float)Math.Round((double)Conversions.ToSingle(dataRow["LaunchAltitudeMin_ASL"]), 1);
					theWeapon.float_46 = (float)Math.Round((double)Conversions.ToSingle(dataRow["TargetAltitudeMax_ASL"]), 1);
					theWeapon.float_45 = (float)Math.Round((double)Conversions.ToSingle(dataRow["TargetAltitudeMin_ASL"]), 1);
				}
				if (theWeapon.bool_7 && theWeapon.float_31 == 6f && theWeapon.float_35 == 6f)
				{
					theWeapon.float_31 = 8f;
					theWeapon.float_35 = 8f;
				}
				theWeapon.class394_0 = new Class394(WeaponDBID, ref theConn);
				DBFunctions.smethod_62(ref theWeapon, WeaponDBID);
				DBFunctions.smethod_63(ref theScen, ref theWeapon, WeaponDBID);
				DBFunctions.smethod_65(ref theWeapon, ref theWeapon.struct36_0);
				Doctrine doctrine_;
				Dictionary<int, Doctrine.WRA_Weapon> dictionary = (doctrine_ = theWeapon.doctrine_0).method_27();
				DBFunctions.smethod_66(ref theWeapon, ref dictionary);
				doctrine_.method_28(dictionary);
				if (LoadComponents)
				{
					DBFunctions.smethod_61(ref theWeapon);
				}
				if (theWeapon.float_31 > 0f && theWeapon.float_33 == 0f && (theWeapon.class394_0.bool_15 || theWeapon.class394_0.bool_16 || theWeapon.class394_0.bool_8 || theWeapon.class394_0.bool_7 || theWeapon.class394_0.bool_6 || theWeapon.class394_0.bool_5 || theWeapon.class394_0.bool_13 || theWeapon.class394_0.bool_12 || theWeapon.class394_0.bool_14))
				{
					theWeapon.float_33 = theWeapon.float_31;
					theWeapon.float_34 = theWeapon.float_32;
					theWeapon.int_15 = theWeapon.int_14;
				}
				if (theWeapon.method_196() && !theWeapon.bool_7 && !theWeapon.method_208() && !theWeapon.method_155() && theWeapon.method_167() != Weapon._WeaponType.Laser && theWeapon.int_7 == 0 && Debugger.IsAttached)
				{
					Debugger.Break();
				}
				if (theWeapon.vmethod_3() || theWeapon.method_204())
				{
					theWeapon.struct36_0.bool_14 = true;
				}
				if (theWeapon.bool_7 && Enumerable.Count<Sensor>(theWeapon.method_78()) > 0)
				{
					theWeapon.struct36_0.bool_57 = true;
				}
			}
			catch (Exception ex6)
			{
				ex6.Data.Add("Error at 200274", ex6.Message);
				GameGeneral.smethod_25(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00204E98 File Offset: 0x00203098
		private static void smethod_61(ref Weapon weapon_0)
		{
			int dbid = weapon_0.DBID;
			DBFunctions.smethod_86(weapon_0, dbid);
			DBFunctions.smethod_99(weapon_0, dbid);
			DBFunctions.smethod_107(weapon_0, dbid);
			DBFunctions.smethod_87(weapon_0, dbid);
			DBFunctions.smethod_88(ref weapon_0.warhead_0, ref weapon_0);
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00204EDC File Offset: 0x002030DC
		private static void smethod_62(ref Weapon weapon_0, int int_0)
		{
			Class403 class403_ = new Class403(weapon_0.scenario_0.method_39());
			string string_ = "Select DataSensor.ID from DataSensor, DataWeaponDirectors as theTable where DataSensor.ID = theTable.ComponentID and theTable.ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				weapon_0.hashSet_0.Add(Conversions.ToInteger(dataRow["ID"]));
			}
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00204F5C File Offset: 0x0020315C
		public static void smethod_63(ref Scenario scenario_0, ref Weapon weapon_0, int int_0)
		{
			if (weapon_0.scenario_0.FeatureCompatibility.get_LPI_Radars(weapon_0.scenario_0.method_39()))
			{
				Class403 class403_ = new Class403(weapon_0.scenario_0.method_39());
				string string_ = "SELECT DataWeaponRecord.* FROM DataWeaponWeapons, DataWeaponRecord, DataWeapon WHERE DataWeaponWeapons.ComponentID = DataWeaponRecord.ID And DataWeapon.ID = DataWeaponRecord.ComponentID And DataWeaponWeapons.ID = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Type, DataWeapon.Name ASC";
				DataTable dataTable = Class401.smethod_1(class403_, string_);
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					DataRow dataRow = dataTable.Rows[i];
					WeaponRec weaponRec = new WeaponRec(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), Conversions.ToInteger(dataRow["DefaultLoad"]), Conversions.ToInteger(dataRow["MaxLoad"]), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Multiple"]), false, false);
					weaponRec.nullable_0 = new int?(Conversions.ToInteger(dataRow["ID"]));
					weapon_0.vmethod_139().method_4(weaponRec);
				}
			}
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00205070 File Offset: 0x00203270
		private static void smethod_64(Scenario scenario_0, ref Mount mount_0)
		{
			Class403 class403_ = new Class403(scenario_0.method_39());
			string string_ = "Select DataSensor.ID from DataSensor, DataMountDirectors as theTable where DataSensor.ID = theTable.ComponentID and theTable.ID = " + Conversions.ToString(mount_0.DBID);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int count = dataTable.Rows.Count;
			mount_0.hashSet_1.Clear();
			int num = count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				mount_0.hashSet_1.Add(Conversions.ToInteger(dataRow["ID"]));
			}
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x002050FC File Offset: 0x002032FC
		public static void smethod_65(ref Weapon weapon_0, ref Weapon.Struct36 struct36_0)
		{
			Class403 class403_ = new Class403(weapon_0.scenario_0.method_39());
			string string_ = "SELECT * from DataWeaponCodes where ID = " + Conversions.ToString(weapon_0.DBID);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				int num2 = Conversions.ToInteger(dataTable.Rows[i]["CodeID"]);
				if (num2 <= 6201)
				{
					if (num2 <= 6001)
					{
						if (num2 <= 3001)
						{
							if (num2 <= 1101)
							{
								switch (num2)
								{
								case 1001:
									struct36_0.bool_0 = true;
									break;
								case 1002:
									struct36_0.bool_1 = true;
									break;
								case 1003:
									struct36_0.bool_2 = true;
									break;
								default:
									if (num2 != 1101)
									{
										goto IL_5D0;
									}
									struct36_0.bool_3 = true;
									break;
								}
							}
							else
							{
								switch (num2)
								{
								case 2001:
									struct36_0.bool_4 = true;
									break;
								case 2002:
									struct36_0.bool_5 = true;
									break;
								case 2003:
									struct36_0.bool_6 = true;
									break;
								case 2004:
									struct36_0.bool_7 = true;
									break;
								case 2005:
									struct36_0.bool_8 = true;
									break;
								case 2006:
									struct36_0.bool_9 = true;
									break;
								case 2007:
								case 2008:
									goto IL_5D0;
								case 2009:
									struct36_0.bool_17 = true;
									break;
								case 2010:
									struct36_0.bool_19 = true;
									break;
								case 2011:
									struct36_0.bool_16 = true;
									break;
								case 2012:
									struct36_0.bool_18 = true;
									break;
								default:
									if (num2 != 3001)
									{
										goto IL_5D0;
									}
									struct36_0.bool_10 = true;
									break;
								}
							}
						}
						else if (num2 <= 4003)
						{
							if (num2 != 3003)
							{
								switch (num2)
								{
								case 4001:
									struct36_0.bool_12 = true;
									break;
								case 4002:
									struct36_0.bool_13 = true;
									break;
								case 4003:
									struct36_0.bool_14 = true;
									break;
								default:
									goto IL_5D0;
								}
							}
							else
							{
								struct36_0.bool_11 = true;
							}
						}
						else if (num2 != 4010)
						{
							if (num2 != 6001)
							{
								goto IL_5D0;
							}
							struct36_0.bool_20 = true;
						}
						else
						{
							struct36_0.bool_15 = true;
						}
					}
					else if (num2 <= 6022)
					{
						if (num2 <= 6012)
						{
							if (num2 != 6002)
							{
								switch (num2)
								{
								case 6009:
									struct36_0.bool_22 = true;
									break;
								case 6010:
									struct36_0.bool_23 = true;
									break;
								case 6011:
									struct36_0.bool_24 = true;
									break;
								case 6012:
									struct36_0.bool_25 = true;
									break;
								default:
									goto IL_5D0;
								}
							}
							else
							{
								struct36_0.bool_21 = true;
							}
						}
						else if (num2 != 6021)
						{
							if (num2 != 6022)
							{
								goto IL_5D0;
							}
							struct36_0.bool_27 = true;
						}
						else
						{
							struct36_0.bool_26 = true;
						}
					}
					else if (num2 <= 6111)
					{
						switch (num2)
						{
						case 6101:
							struct36_0.bool_28 = true;
							break;
						case 6102:
							struct36_0.bool_29 = true;
							break;
						case 6103:
							struct36_0.bool_30 = true;
							break;
						default:
							if (num2 != 6111)
							{
								goto IL_5D0;
							}
							struct36_0.bool_31 = true;
							break;
						}
					}
					else
					{
						switch (num2)
						{
						case 6121:
							struct36_0.bool_54 = true;
							break;
						case 6122:
							struct36_0.bool_55 = true;
							break;
						case 6123:
							struct36_0.bool_56 = true;
							break;
						case 6124:
						case 6125:
						case 6126:
						case 6127:
						case 6128:
						case 6130:
							goto IL_5D0;
						case 6129:
							struct36_0.bool_57 = true;
							break;
						case 6131:
							struct36_0.enum129_0 = Weapon.Struct36.Enum129.const_1;
							break;
						case 6132:
							struct36_0.enum129_0 = Weapon.Struct36.Enum129.const_2;
							break;
						case 6133:
							struct36_0.enum129_0 = Weapon.Struct36.Enum129.const_3;
							break;
						default:
							if (num2 != 6201)
							{
								goto IL_5D0;
							}
							struct36_0.bool_32 = true;
							break;
						}
					}
				}
				else if (num2 <= 6401)
				{
					if (num2 <= 6321)
					{
						if (num2 <= 6311)
						{
							if (num2 != 6301)
							{
								if (num2 != 6311)
								{
									goto IL_5D0;
								}
								struct36_0.bool_34 = true;
							}
							else
							{
								struct36_0.bool_33 = true;
							}
						}
						else if (num2 != 6312)
						{
							if (num2 != 6321)
							{
								goto IL_5D0;
							}
							struct36_0.bool_36 = true;
						}
						else
						{
							struct36_0.bool_35 = true;
						}
					}
					else if (num2 <= 6331)
					{
						if (num2 != 6322)
						{
							if (num2 != 6331)
							{
								goto IL_5D0;
							}
							struct36_0.bool_38 = true;
						}
						else
						{
							struct36_0.bool_37 = true;
						}
					}
					else if (num2 != 6341)
					{
						if (num2 != 6401)
						{
							goto IL_5D0;
						}
						struct36_0.bool_40 = true;
					}
					else
					{
						struct36_0.bool_39 = true;
					}
				}
				else if (num2 <= 7003)
				{
					if (num2 <= 6501)
					{
						if (num2 != 6402)
						{
							if (num2 != 6501)
							{
								goto IL_5D0;
							}
							struct36_0.bool_42 = true;
						}
						else
						{
							struct36_0.bool_41 = true;
						}
					}
					else if (num2 != 6511)
					{
						switch (num2)
						{
						case 7001:
							struct36_0.bool_44 = true;
							break;
						case 7002:
							struct36_0.bool_45 = true;
							break;
						case 7003:
							struct36_0.bool_46 = true;
							break;
						default:
							goto IL_5D0;
						}
					}
					else
					{
						struct36_0.bool_43 = true;
					}
				}
				else if (num2 <= 8002)
				{
					if (num2 != 8001)
					{
						if (num2 != 8002)
						{
							goto IL_5D0;
						}
						struct36_0.bool_48 = true;
					}
					else
					{
						struct36_0.bool_47 = true;
					}
				}
				else
				{
					switch (num2)
					{
					case 9001:
						struct36_0.bool_49 = true;
						break;
					case 9002:
						struct36_0.bool_50 = true;
						break;
					case 9003:
						struct36_0.bool_51 = true;
						break;
					case 9004:
						struct36_0.bool_52 = true;
						break;
					default:
						if (num2 != 9999)
						{
							goto IL_5D0;
						}
						struct36_0.bool_53 = true;
						break;
					}
				}
				IL_609:
				i++;
				continue;
				IL_5D0:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					goto IL_609;
				}
				goto IL_609;
			}
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00205720 File Offset: 0x00203920
		public static void smethod_66(ref Weapon weapon_0, ref Dictionary<int, Doctrine.WRA_Weapon> dictionary_2)
		{
			if (weapon_0.doctrine_0.method_239(ref weapon_0))
			{
				Class403 class403_ = new Class403(weapon_0.scenario_0.method_39());
				if (Information.IsNothing(dictionary_2))
				{
					dictionary_2 = new Dictionary<int, Doctrine.WRA_Weapon>();
				}
				if (!dictionary_2.ContainsKey(weapon_0.DBID))
				{
					dictionary_2.Add(weapon_0.DBID, new Doctrine.WRA_Weapon());
				}
				if (!weapon_0.scenario_0.FeatureCompatibility.get_WRA(weapon_0.scenario_0.method_39()))
				{
					dictionary_2[weapon_0.DBID].method_0(ref weapon_0);
					return;
				}
				string string_ = "SELECT * from DataWeaponWRA where ID = " + Conversions.ToString(weapon_0.DBID);
				DataTable dataTable = Class401.smethod_1(class403_, string_);
				int count = dataTable.Rows.Count;
				if (count > 0)
				{
					int num = count - 1;
					for (int i = 0; i <= num; i++)
					{
						DataRow dataRow = dataTable.Rows[i];
						Doctrine.Class276 @class = new Doctrine.Class276((Doctrine._WRA_WeaponTargetType)Conversions.ToInteger(dataRow["CodeID"]));
						@class.nullable_0 = new int?(Conversions.ToInteger(dataRow["WeaponQty"]));
						@class.nullable_1 = new int?(Conversions.ToInteger(dataRow["ShooterQty"]));
						@class.nullable_3 = new int?(Conversions.ToInteger(dataRow["SelfDefenceRange"]));
						Class429.smethod_46(ref dictionary_2[weapon_0.DBID].class276_0, @class);
					}
				}
			}
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x002058A0 File Offset: 0x00203AA0
		public static DataTable smethod_67(ref SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "SELECT ID, Name || ' (' || Comments || ')' as Name from DataMount";
			return Class401.smethod_1(class403_, string_);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x002058C0 File Offset: 0x00203AC0
		public static DataTable smethod_68(ref SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "SELECT ID, Name || ' (' || Comments || ')' as Name, Cargo_Type, Cargo_Mass, Cargo_Area, Cargo_Crew, Cargo_ParadropCapable from DataMount where Cargo_Type <> 0 order by Name";
			return Class401.smethod_1(class403_, string_);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x002058E0 File Offset: 0x00203AE0
		public static DataTable smethod_69(ref SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "SELECT ID, Name || ' (' || Comments || ')' as Name from DataMagazine";
			return Class401.smethod_1(class403_, string_);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00205900 File Offset: 0x00203B00
		public static DataTable smethod_70(ref SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "SELECT ID, Name || ' (' || Comments || ')' as Name from DataSensor";
			return Class401.smethod_1(class403_, string_);
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x00205920 File Offset: 0x00203B20
		public static DataTable smethod_71(ref SQLiteConnection sqliteConnection_0)
		{
			Class403 @class = new Class403(sqliteConnection_0);
			DataTable dataTable = new DataTable();
			string text = "SELECT DataWeaponRecord.ID, DataWeaponRecord.ComponentID, DataWeaponRecord.DefaultLoad, DataWeaponRecord.MaxLoad, DataWeaponRecord.ROF, DataWeaponRecord.Multiple, DataWeapon.Name from DataWeaponRecord INNER JOIN DataWeapon on DataWeapon.ID = DataWeaponRecord.ComponentID";
			object objectValue = RuntimeHelpers.GetObjectValue(Class401.smethod_3(@class, text));
			DataTable result;
			if (objectValue != null)
			{
				result = (DataTable)objectValue;
			}
			else
			{
				@class.method_4();
				SQLiteDataReader sqliteDataReader;
				using (DbCommand dbCommand = @class.sqliteConnection_0.CreateCommand())
				{
					dbCommand.CommandText = text;
					sqliteDataReader = (SQLiteDataReader)dbCommand.ExecuteReader();
				}
				int fieldCount = sqliteDataReader.FieldCount;
				int num = fieldCount - 1;
				for (int i = 0; i <= num; i++)
				{
					dataTable.Columns.Add(sqliteDataReader.GetName(i), sqliteDataReader.GetFieldType(i));
				}
				dataTable.Columns.Add("Description", typeof(string));
				StringBuilder stringBuilder = new StringBuilder();
				while (sqliteDataReader.Read())
				{
					DataRow dataRow = dataTable.NewRow();
					int num2 = fieldCount - 1;
					for (int j = 0; j <= num2; j++)
					{
						dataRow[j] = RuntimeHelpers.GetObjectValue(sqliteDataReader[j]);
					}
					stringBuilder.Clear();
					stringBuilder.Append(RuntimeHelpers.GetObjectValue(dataRow[6])).Append(" (").Append(RuntimeHelpers.GetObjectValue(dataRow[2])).Append("/").Append(RuntimeHelpers.GetObjectValue(dataRow[3])).Append(") - ROF:").Append(RuntimeHelpers.GetObjectValue(dataRow[4]));
					dataRow[fieldCount] = stringBuilder.ToString();
					dataTable.Rows.Add(dataRow);
				}
				sqliteDataReader.Close();
				sqliteDataReader = null;
				@class.method_5();
				Class401.smethod_4(@class, text, dataTable);
				result = dataTable;
			}
			return result;
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00205AF8 File Offset: 0x00203CF8
		public static DataTable smethod_72(bool bool_0, ref Scenario scenario_0, ref SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_;
			if (bool_0)
			{
				if (!Information.IsNothing(scenario_0) && !scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(scenario_0.method_39()))
				{
					string_ = "SELECT DataWeapon.ID, DataWeapon.Name, DataWeapon.Type, DataWeapon.TargetAltitudeMax, DataWeapon.TargetAltitudeMin from DataWeapon";
				}
				else
				{
					string_ = "SELECT DataWeapon.ID, DataWeapon.Name, DataWeapon.Type, DataWeapon.TargetAltitudeMax, DataWeapon.TargetAltitudeMin, DataWeapon.TargetAltitudeMax_ASL, DataWeapon.TargetAltitudeMin_ASL from DataWeapon";
				}
			}
			else if (!Information.IsNothing(scenario_0) && !scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(scenario_0.method_39()))
			{
				string_ = "SELECT DataWeapon.ID, DataWeapon.Name, DataWeapon.Type, DataWeapon.TargetAltitudeMax, DataWeapon.TargetAltitudeMin from DataWeapon where DataWeapon.Type not in (2005, 2006, 2007, 2008, 3001, 3002, 3003, 3004, 4003, 9001, 9002, 9003)";
			}
			else
			{
				string_ = "SELECT DataWeapon.ID, DataWeapon.Name, DataWeapon.Type, DataWeapon.TargetAltitudeMax, DataWeapon.TargetAltitudeMin , DataWeapon.TargetAltitudeMax_ASL, DataWeapon.TargetAltitudeMin_ASL from DataWeapon where DataWeapon.Type not in (2005, 2006, 2007, 2008, 3001, 3002, 3003, 3004, 4003, 9001, 9002, 9003)";
			}
			return Class401.smethod_1(class403_, string_);
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00205B70 File Offset: 0x00203D70
		public static Weapon._WeaponType smethod_73(int int_0, ref SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "SELECT type from DataWeapon where ID=" + Conversions.ToString(int_0);
			return (Weapon._WeaponType)Conversions.ToShort(Class401.smethod_2(class403_, string_));
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00205BA0 File Offset: 0x00203DA0
		public static void smethod_74(ref Scenario theScen, ref Satellite theSatellite, int SatDBID, int SpacecraftNumber = 0, bool LoadComponents = true)
		{
			Class403 class403_ = new Class403(theScen.method_39());
			string string_ = "Select * from DataSatellite where ID = " + Conversions.ToString(SatDBID);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception("No satellite with ID: " + Conversions.ToString(SatDBID) + " was found in the current database!");
			}
			DataRow dataRow = dataTable.Rows[0];
			theSatellite.DBID = SatDBID;
			theSatellite.string_2 = dataRow["Name"].ToString();
			if (!dataTable.Columns.Contains("OODADetectionCycle"))
			{
				dataTable.Columns.Add("OODADetectionCycle", typeof(string));
				dataRow["OODADetectionCycle"] = 0;
			}
			if (!dataTable.Columns.Contains("OODATargetingCycle"))
			{
				dataTable.Columns.Add("OODATargetingCycle", typeof(string));
				dataRow["OODATargetingCycle"] = 0;
			}
			if (!dataTable.Columns.Contains("OODAEvasiveCycle"))
			{
				dataTable.Columns.Add("OODAEvasiveCycle", typeof(string));
				dataRow["OODAEvasiveCycle"] = 0;
			}
			theSatellite.short_0 = Conversions.ToShort(dataRow["OODADetectionCycle"].ToString());
			theSatellite.short_1 = Conversions.ToShort(dataRow["OODATargetingCycle"].ToString());
			theSatellite.short_2 = Conversions.ToShort(dataRow["OODAEvasiveCycle"].ToString());
			if (dataTable.Columns.Contains("Category"))
			{
				theSatellite._SatelliteCategory_0 = (Satellite._SatelliteCategory)Conversions.ToInteger(dataRow["Category"]);
			}
			if (dataTable.Columns.Contains("Type"))
			{
				theSatellite._SatelliteType_0 = (Satellite._SatelliteType)Conversions.ToInteger(dataRow["Type"]);
			}
			if (dataTable.Columns.Contains("Length"))
			{
				theSatellite.float_13 = Conversions.ToSingle(dataRow["Length"]);
			}
			if (dataTable.Columns.Contains("Span"))
			{
				theSatellite.float_25 = Conversions.ToSingle(dataRow["Span"]);
			}
			if (dataTable.Columns.Contains("Height"))
			{
				theSatellite.float_26 = Conversions.ToSingle(dataRow["Height"]);
			}
			if (dataTable.Columns.Contains("WeightEmpty"))
			{
				theSatellite.double_4 = Conversions.ToDouble(dataRow["WeightEmpty"]);
			}
			if (dataTable.Columns.Contains("WeightMax"))
			{
				theSatellite.double_5 = Conversions.ToDouble(dataRow["WeightMax"]);
			}
			if (dataTable.Columns.Contains("WeightPayload"))
			{
				theSatellite.double_6 = Conversions.ToDouble(dataRow["WeightPayload"]);
			}
			if (dataTable.Columns.Contains("Armor"))
			{
				theSatellite.armorRating_0 = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["Armor"]);
			}
			if (dataTable.Columns.Contains("DamagePoints"))
			{
				theSatellite.float_27 = Conversions.ToSingle(dataRow["DamagePoints"]);
			}
			try
			{
				theSatellite.bool_23 = Conversions.ToBoolean(dataRow["Hypothetical"]);
			}
			catch (Exception ex)
			{
			}
			if (SpacecraftNumber != 0)
			{
				string_ = "Select * from DataSatelliteOrbits where ID = " + Conversions.ToString(SatDBID) + " and ComponentNumber = " + Conversions.ToString(SpacecraftNumber);
				dataTable = Class401.smethod_1(class403_, string_);
				dataRow = dataTable.Rows[0];
				theSatellite.Name = dataRow["MissonName"].ToString();
				if (dataTable.Columns.Contains("TLE") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["TLE"])) && Operators.CompareString(dataRow["TLE"].ToString(), "-", false) != 0)
				{
					string[] string_2 = Enumerable.ToArray<string>(Enumerable.Where<string>(Conversions.ToString(dataRow["TLE"]).Split(Conversions.ToCharArrayRankOne(Environment.NewLine)), (DBFunctions._Closure$__.$I78-0 == null) ? (DBFunctions._Closure$__.$I78-0 = new Func<string, bool>(DBFunctions._Closure$__.$I.method_1)) : DBFunctions._Closure$__.$I78-0));
					theSatellite.method_142().method_20(string_2);
				}
				else
				{
					theSatellite.method_142().method_19(Conversions.ToSingle(dataRow["Inclination"]), Conversions.ToLong(dataRow["Apogee"]) * 1000L, Conversions.ToLong(dataRow["Perigee"]) * 1000L);
				}
				theSatellite.dateTime_0 = Conversions.ToDate(dataRow["LaunchDate"]);
				theSatellite.dateTime_1 = Conversions.ToDate(dataRow["DeOrbitingDate"]);
			}
			if (LoadComponents)
			{
				DBFunctions.smethod_99(theSatellite, SatDBID);
				DBFunctions.smethod_87(theSatellite, SatDBID);
				ActiveUnit activeUnit = theSatellite;
				DBFunctions.smethod_112(ref theScen, ref activeUnit, SatDBID);
			}
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0020609C File Offset: 0x0020429C
		public static void smethod_75(ref Class350 class350_0, int int_0)
		{
			string str = "";
			Class403 class403_ = new Class403(class350_0.scenario_0.method_39());
			string left = class350_0.GetType().ToString();
			if (Operators.CompareString(left, "Command_Core.Ship", false) != 0)
			{
				if (Operators.CompareString(left, "Command_Core.Facility", false) != 0)
				{
					if (Operators.CompareString(left, "Command_Core.Submarine", false) == 0)
					{
						str = "DataSubmarineAircraftFacilities";
					}
				}
				else
				{
					str = "DataFacilityAircraftFacilities";
				}
			}
			else
			{
				str = "DataShipAircraftFacilities";
			}
			string string_ = "select * from " + str + " where id = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int facilityDBID = Conversions.ToInteger(dataTable.Rows[i]["ComponentID"]);
				SQLiteConnection sqliteConnection = class350_0.scenario_0.method_39();
				AirFacility airFacility_ = DBFunctions.smethod_77(facilityDBID, ref sqliteConnection, class350_0);
				class350_0.method_103(airFacility_);
			}
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00206190 File Offset: 0x00204390
		public static void smethod_76(ref Class350 class350_0, int int_0)
		{
			string str = "";
			Class403 class403_ = new Class403(class350_0.scenario_0.method_39());
			string left = class350_0.GetType().ToString();
			if (Operators.CompareString(left, "Command_Core.Ship", false) != 0)
			{
				if (Operators.CompareString(left, "Command_Core.Submarine", false) != 0)
				{
					if (Operators.CompareString(left, "Command_Core.Facility", false) == 0)
					{
						str = "DataFacilityDockingFacilities";
					}
				}
				else
				{
					str = "DataSubmarineDockingFacilities";
				}
			}
			else
			{
				str = "DataShipDockingFacilities";
			}
			string string_ = "select * from " + str + " where id = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int facilityDBID = Conversions.ToInteger(dataTable.Rows[i]["ComponentID"]);
				SQLiteConnection sqliteConnection = class350_0.scenario_0.method_39();
				DockFacility dockFacility_ = DBFunctions.smethod_78(facilityDBID, ref sqliteConnection, class350_0);
				class350_0.method_104(dockFacility_);
			}
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00206284 File Offset: 0x00204484
		public static AirFacility smethod_77(int FacilityDBID, ref SQLiteConnection theDBConn, ActiveUnit theParent = null)
		{
			Class403 class403_ = new Class403(theDBConn);
			string string_ = "Select * from DataAircraftFacility where ID = " + Conversions.ToString(FacilityDBID);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception1();
			}
			int count = dataTable.Rows.Count;
			DataRow dataRow = dataTable.Rows[0];
			string text = Class401.smethod_2(class403_, "Select Description from EnumAircraftFacilityType where ID = " + dataRow["Type"].ToString());
			string text2 = Class401.smethod_2(class403_, "Select Description from EnumAircraftFacilityPhysicalSize where ID = " + dataRow["PhysicalSize"].ToString());
			int num = Conversions.ToInteger(dataRow["PhysicalSize"]);
			GlobalVariables.AircraftSizeClass int_;
			if (num != 1001)
			{
				switch (num)
				{
				case 2001:
					int_ = GlobalVariables.AircraftSizeClass.Small;
					break;
				case 2002:
					int_ = GlobalVariables.AircraftSizeClass.Medium;
					break;
				case 2003:
					int_ = GlobalVariables.AircraftSizeClass.Large;
					break;
				case 2004:
					int_ = GlobalVariables.AircraftSizeClass.VLarge;
					break;
				default:
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					break;
				}
			}
			else
			{
				int_ = GlobalVariables.AircraftSizeClass.None;
			}
			return new AirFacility(theParent, string.Concat(new string[]
			{
				text,
				" (",
				dataRow["capacity"].ToString(),
				"x ",
				text2,
				")"
			}), (AirFacility.Enum110)Conversions.ToShort(dataRow["Type"]), (int)int_, Conversions.ToInteger(dataRow["Capacity"]), (GlobalVariables.Enum146)Conversions.ToInteger(dataRow["RunwayLength"]))
			{
				DBID = FacilityDBID
			};
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00206408 File Offset: 0x00204608
		public static DockFacility smethod_78(int FacilityDBID, ref SQLiteConnection theDBConn, ActiveUnit theParent = null)
		{
			Class403 class403_ = new Class403(theDBConn);
			string string_ = "Select * from DataDockingFacility where ID = " + Conversions.ToString(FacilityDBID);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception1();
			}
			int count = dataTable.Rows.Count;
			DataRow dataRow = dataTable.Rows[0];
			string text = Class401.smethod_2(class403_, "Select Description from EnumDockingFacilityType where ID = " + dataRow["Type"].ToString());
			string text2 = Class401.smethod_2(class403_, "Select Description from EnumDockingFacilityPhysicalSize where ID = " + dataRow["PhysicalSize"].ToString());
			DockFacility.Enum50 enum50_ = (DockFacility.Enum50)Conversions.ToShort(dataRow["PhysicalSize"]);
			return new DockFacility(theParent, string.Concat(new string[]
			{
				text,
				" (",
				dataRow["capacity"].ToString(),
				"x ",
				text2,
				")"
			}), (DockFacility.Enum49)Conversions.ToShort(dataRow["Type"]), enum50_, Conversions.ToByte(dataRow["Capacity"]))
			{
				DBID = FacilityDBID
			};
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00206530 File Offset: 0x00204730
		public static int smethod_79(string string_0, ref SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "Select ID from DataComm where Name = '" + string_0 + "'";
			return Conversions.ToInteger(Class401.smethod_2(class403_, string_));
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x00206560 File Offset: 0x00204760
		public static void smethod_80(ref Class350 class350_0, int int_0)
		{
			Class403 class403_ = new Class403(class350_0.scenario_0.method_39());
			string left = class350_0.GetType().ToString();
			string text;
			if (Operators.CompareString(left, "Command_Core.Ship", false) != 0)
			{
				if (Operators.CompareString(left, "Command_Core.Facility", false) != 0)
				{
					if (Operators.CompareString(left, "Command_Core.Submarine", false) == 0)
					{
						text = "DataSubmarineMagazines";
					}
				}
				else
				{
					text = "DataFacilityMagazines";
				}
			}
			else
			{
				text = "DataShipMagazines";
			}
			string string_ = string.Concat(new string[]
			{
				"SELECT theTable.* FROM ",
				text,
				" as theTable, DataMagazine WHERE theTable.ComponentID = DataMagazine.ID And theTable.ID = ",
				Conversions.ToString(int_0),
				" ORDER BY DataMagazine.Name ASC"
			});
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Magazine magazine = DBFunctions.smethod_82(Conversions.ToInteger(dataTable.Rows[i]["ComponentID"]), ref class350_0.scenario_0, true);
				class350_0.method_140(magazine);
				magazine.method_19(class350_0);
			}
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00206668 File Offset: 0x00204868
		public static int smethod_81(string string_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "SELECT ID from DataMagazine where Name='" + Misc.smethod_9(string_0) + "'";
			return Conversions.ToInteger(Class401.smethod_2(class403_, string_));
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0020669C File Offset: 0x0020489C
		public static Magazine smethod_82(int MagazineDBID, ref Scenario theScen, bool LoadComponents = true)
		{
			Class403 class403_ = new Class403(theScen.method_39());
			string string_ = "Select * From DataMagazine where ID = " + Conversions.ToString(MagazineDBID);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception1();
			}
			DataRow dataRow = dataTable.Rows[0];
			Magazine magazine = new Magazine(null, Conversions.ToInteger(dataRow["ID"]), Conversions.ToString(dataRow["Name"]), (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorGeneral"]), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Capacity"]), Conversions.ToBoolean(dataRow["AviationMagazine"]));
			try
			{
				magazine.bool_12 = Conversions.ToBoolean(dataRow["Hypothetical"]);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200478", ex.Message);
				GameGeneral.smethod_25(ref ex);
				bool isAttached = Debugger.IsAttached;
			}
			if (LoadComponents)
			{
				DBFunctions.smethod_83(ref magazine, ref theScen);
			}
			return magazine;
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x002067C4 File Offset: 0x002049C4
		private static void smethod_83(ref Magazine magazine_0, ref Scenario scenario_0)
		{
			Class403 class403_ = new Class403(scenario_0.method_39());
			string string_ = "SELECT DataWeaponRecord.* FROM DataMagazineWeapons, DataWeaponRecord, DataWeapon WHERE DataMagazineWeapons.ComponentID = DataWeaponRecord.ID And DataWeapon.ID = DataWeaponRecord.ComponentID And DataMagazineWeapons.ID = " + Conversions.ToString(magazine_0.DBID) + " ORDER BY DataWeapon.Name ASC";
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				WeaponRec weaponRec = new WeaponRec(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), Conversions.ToInteger(dataRow["DefaultLoad"]), Conversions.ToInteger(dataRow["MaxLoad"]), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Multiple"]), false, false);
				weaponRec.method_15();
				magazine_0.vmethod_10().method_4(weaponRec);
			}
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x002068A4 File Offset: 0x00204AA4
		public static Tuple<string, string, string> smethod_84(GlobalVariables.ActiveUnitType activeUnitType_0, int int_0, Scenario scenario_0)
		{
			Class403 @class = new Class403(scenario_0.method_39());
			string text = null;
			switch (activeUnitType_0)
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				text = "DataAircraft";
				goto IL_74;
			case GlobalVariables.ActiveUnitType.Ship:
				text = "DataShip";
				goto IL_74;
			case GlobalVariables.ActiveUnitType.Submarine:
				text = "DataSubmarine";
				goto IL_74;
			case GlobalVariables.ActiveUnitType.Facility:
				text = "DataFacility";
				goto IL_74;
			case GlobalVariables.ActiveUnitType.Weapon:
				text = "DataWeapon";
				goto IL_74;
			case GlobalVariables.ActiveUnitType.Satellite:
				text = "DataSatellite";
				goto IL_74;
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			IL_74:
			string string_ = string.Concat(new string[]
			{
				"Select EnumOperatorCountry.Description As Country, YearCommissioned, YearDecommissioned FROM ",
				text,
				" Left Join EnumOperatorCountry On EnumOperatorCountry.ID = ",
				text,
				".OperatorCountry where ",
				text,
				".ID=",
				Conversions.ToString(int_0)
			});
			DataRow dataRow = @class.method_2(string_).Rows[0];
			string item = Conversions.ToString(dataRow["Country"]);
			string item2 = Conversions.ToString(dataRow["YearCommissioned"]);
			string item3 = Conversions.ToString(dataRow["YearDecommissioned"]);
			return new Tuple<string, string, string>(item, item2, item3);
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x002069B8 File Offset: 0x00204BB8
		public static string[] smethod_85(int int_0, Scenario scenario_0)
		{
			Class403 class403_ = new Class403(scenario_0.method_39());
			HashSet<string> hashSet = new HashSet<string>();
			string string_ = "Select DISTINCT DataAircraft.ID As ID, DataAircraft.Name, EnumOperatorCountry.Description As Country, YearCommissioned FROM DataAircraft \r\n    Left JOIN EnumOperatorCountry ON EnumOperatorCountry.ID = DataAircraft.OperatorCountry\r\n\tLEFT JOIN DataAircraftLoadouts ON DataAircraftLoadouts.ID = DataAircraft.ID \r\n\tLEFT JOIN DataLoadoutWeapons ON DataLoadoutWeapons.ID = DataAircraftLoadouts.ComponentID \r\n\tLEFT JOIN DataWeaponRecord ON DataWeaponRecord.ID = DataLoadoutWeapons.ComponentID \r\n\tWHERE DataWeaponRecord.ComponentID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			try
			{
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					string text;
					if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Country"])))
					{
						text = "N/A";
					}
					else
					{
						text = Conversions.ToString(dataRow["Country"]);
					}
					hashSet.Add(string.Concat(new string[]
					{
						"Aircraft_",
						Conversions.ToString(dataRow["ID"]),
						"_",
						Conversions.ToString(dataRow["Name"]),
						"_",
						text,
						"_",
						Conversions.ToString(dataRow["YearCommissioned"])
					}));
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			string_ = "SELECT DISTINCT DataAircraft.ID, DataAircraft.Name, EnumOperatorCountry.Description as Country, YearCommissioned FROM DataAircraft\r\n    LEFT JOIN EnumOperatorCountry ON EnumOperatorCountry.ID = DataAircraft.OperatorCountry  \r\n\tLeft Join DataAircraftMounts ON DataAircraftMounts.ID = DataAircraft.ID \r\n    Left Join DataMountWeapons ON DataMountWeapons.ID = DataAircraftMounts.ComponentID \r\n    Left Join DataWeaponRecord ON DataWeaponRecord.ID = DataMountWeapons.ComponentID \r\n    WHERE DataWeaponRecord.ComponentID = " + Conversions.ToString(int_0);
			dataTable = Class401.smethod_1(class403_, string_);
			try
			{
				foreach (object obj2 in dataTable.Rows)
				{
					DataRow dataRow2 = (DataRow)obj2;
					string text;
					if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["Country"])))
					{
						text = "N/A";
					}
					else
					{
						text = Conversions.ToString(dataRow2["Country"]);
					}
					hashSet.Add(string.Concat(new string[]
					{
						"Aircraft_",
						Conversions.ToString(dataRow2["ID"]),
						"_",
						Conversions.ToString(dataRow2["Name"]),
						"_",
						text,
						"_",
						Conversions.ToString(dataRow2["YearCommissioned"])
					}));
				}
			}
			finally
			{
				IEnumerator enumerator2;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			string_ = "SELECT DISTINCT DataShip.ID, DataShip.Name, EnumOperatorCountry.Description as Country, YearCommissioned FROM DataShip\r\n    LEFT JOIN EnumOperatorCountry ON EnumOperatorCountry.ID = DataShip.OperatorCountry\r\n\tLEFT JOIN DataShipMounts ON DataShipMounts.ID = DataShip.ID \r\n\tLEFT JOIN DataMountWeapons ON DataMountWeapons.ID = DataShipMounts.ComponentID \r\n\tLEFT JOIN DataWeaponRecord ON DataWeaponRecord.ID = DataMountWeapons.ComponentID \r\n\tWHERE DataWeaponRecord.ComponentID = " + Conversions.ToString(int_0);
			dataTable = Class401.smethod_1(class403_, string_);
			try
			{
				foreach (object obj3 in dataTable.Rows)
				{
					DataRow dataRow3 = (DataRow)obj3;
					string text;
					if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["Country"])))
					{
						text = "N/A";
					}
					else
					{
						text = Conversions.ToString(dataRow3["Country"]);
					}
					hashSet.Add(string.Concat(new string[]
					{
						"Ship_",
						Conversions.ToString(dataRow3["ID"]),
						"_",
						Conversions.ToString(dataRow3["Name"]),
						"_",
						text,
						"_",
						Conversions.ToString(dataRow3["YearCommissioned"])
					}));
				}
			}
			finally
			{
				IEnumerator enumerator3;
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			string_ = "SELECT DISTINCT DataSubmarine.ID, DataSubmarine.Name, EnumOperatorCountry.Description as Country, YearCommissioned FROM DataSubmarine\r\n    LEFT JOIN EnumOperatorCountry ON EnumOperatorCountry.ID = DataSubmarine.OperatorCountry\r\n\tLEFT JOIN DataSubmarineMounts ON DataSubmarineMounts.ID = DataSubmarine.ID \r\n\tLEFT JOIN DataMountWeapons ON DataMountWeapons.ID = DataSubmarineMounts.ComponentID \r\n\tLEFT JOIN DataWeaponRecord ON DataWeaponRecord.ID = DataMountWeapons.ComponentID \r\n\tWHERE DataWeaponRecord.ComponentID = " + Conversions.ToString(int_0);
			dataTable = Class401.smethod_1(class403_, string_);
			try
			{
				foreach (object obj4 in dataTable.Rows)
				{
					DataRow dataRow4 = (DataRow)obj4;
					string text;
					if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow4["Country"])))
					{
						text = "N/A";
					}
					else
					{
						text = Conversions.ToString(dataRow4["Country"]);
					}
					hashSet.Add(string.Concat(new string[]
					{
						"Submarine_",
						Conversions.ToString(dataRow4["ID"]),
						"_",
						Conversions.ToString(dataRow4["Name"]),
						"_",
						text,
						"_",
						Conversions.ToString(dataRow4["YearCommissioned"])
					}));
				}
			}
			finally
			{
				IEnumerator enumerator4;
				if (enumerator4 is IDisposable)
				{
					(enumerator4 as IDisposable).Dispose();
				}
			}
			string_ = "SELECT DISTINCT DataFacility.ID, DataFacility.Name, EnumOperatorCountry.Description as Country, YearCommissioned FROM DataFacility\r\n    LEFT JOIN EnumOperatorCountry ON EnumOperatorCountry.ID = DataFacility.OperatorCountry \r\n\tLEFT JOIN DataFacilityMounts ON DataFacilityMounts.ID = DataFacility.ID \r\n\tLEFT JOIN DataMountWeapons ON DataMountWeapons.ID = DataFacilityMounts.ComponentID \r\n\tLEFT JOIN DataWeaponRecord ON DataWeaponRecord.ID = DataMountWeapons.ComponentID \r\n\tWHERE DataWeaponRecord.ComponentID = " + Conversions.ToString(int_0);
			dataTable = Class401.smethod_1(class403_, string_);
			try
			{
				foreach (object obj5 in dataTable.Rows)
				{
					DataRow dataRow5 = (DataRow)obj5;
					string text;
					if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow5["Country"])))
					{
						text = "N/A";
					}
					else
					{
						text = Conversions.ToString(dataRow5["Country"]);
					}
					hashSet.Add(string.Concat(new string[]
					{
						"Facility_",
						Conversions.ToString(dataRow5["ID"]),
						"_",
						Conversions.ToString(dataRow5["Name"]),
						"_",
						text,
						"_",
						Conversions.ToString(dataRow5["YearCommissioned"])
					}));
				}
			}
			finally
			{
				IEnumerator enumerator5;
				if (enumerator5 is IDisposable)
				{
					(enumerator5 as IDisposable).Dispose();
				}
			}
			string_ = "SELECT DISTINCT DataSatellite.ID, DataSatellite.Name, EnumOperatorCountry.Description as Country, YearCommissioned FROM DataSatellite\r\n    LEFT JOIN EnumOperatorCountry ON EnumOperatorCountry.ID = DataSatellite.OperatorCountry\r\n\tLEFT JOIN DataSatelliteMounts ON DataSatelliteMounts.ID = DataSatellite.ID \r\n\tLEFT JOIN DataMountWeapons ON DataMountWeapons.ID = DataSatelliteMounts.ComponentID \r\n\tLEFT JOIN DataWeaponRecord ON DataWeaponRecord.ID = DataMountWeapons.ComponentID \r\n\tWHERE DataWeaponRecord.ComponentID = " + Conversions.ToString(int_0);
			dataTable = Class401.smethod_1(class403_, string_);
			try
			{
				foreach (object obj6 in dataTable.Rows)
				{
					DataRow dataRow6 = (DataRow)obj6;
					string text;
					if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow6["Country"])))
					{
						text = "N/A";
					}
					else
					{
						text = Conversions.ToString(dataRow6["Country"]);
					}
					hashSet.Add(string.Concat(new string[]
					{
						"Satellite_",
						Conversions.ToString(dataRow6["ID"]),
						"_",
						Conversions.ToString(dataRow6["Name"]),
						"_",
						text,
						"_",
						Conversions.ToString(dataRow6["YearCommissioned"])
					}));
				}
			}
			finally
			{
				IEnumerator enumerator6;
				if (enumerator6 is IDisposable)
				{
					(enumerator6 as IDisposable).Dispose();
				}
			}
			return Enumerable.ToArray<string>(hashSet);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00207044 File Offset: 0x00205244
		public static void smethod_86(ActiveUnit activeUnit_0, int int_0)
		{
			Class403 class403_ = new Class403(activeUnit_0.scenario_0.method_39());
			string str = "";
			switch (activeUnit_0.vmethod_56())
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				str = "DataAircraftPropulsion";
				break;
			case GlobalVariables.ActiveUnitType.Ship:
				str = "DataShipPropulsion";
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				str = "DataSubmarinePropulsion";
				break;
			case GlobalVariables.ActiveUnitType.Facility:
				str = "DataFacilityPropulsion";
				break;
			case GlobalVariables.ActiveUnitType.Weapon:
				str = "DataWeaponPropulsion";
				break;
			}
			string string_ = "Select DataPropulsion.* from DataPropulsion, " + str + " As theTable where DataPropulsion.ID = theTable.ComponentID And theTable.ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int count = dataTable.Rows.Count;
			if (activeUnit_0.bool_3)
			{
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						int int_ = Conversions.ToInteger(dataRow["ID"].ToString());
						string text = dataRow["Name"].ToString();
						if (Enumerable.ToArray<string>(text.Split(Conversions.ToCharArrayRankOne(" "))).Length > 1 && Enumerable.ToList<string>(text.Split(Conversions.ToCharArrayRankOne(" ")))[0].EndsWith("x"))
						{
							string text2 = Enumerable.ToList<string>(text.Split(Conversions.ToCharArrayRankOne(" ")))[0];
							text = text.Substring(text2.Length + 1);
						}
						if (dataTable.Columns.Contains("NumberOfEngines"))
						{
							int num = Conversions.ToInteger(dataRow["NumberOfEngines"]);
							for (int i = 1; i <= num; i++)
							{
								Engine engine = DBFunctions.smethod_94(Conversions.ToInteger(dataRow["ID"].ToString()), ref activeUnit_0);
								engine.Name = text + " #" + Conversions.ToString(i);
								activeUnit_0.vmethod_49().method_4(engine);
							}
						}
						else if (Enumerable.ToArray<string>(text.Split(Conversions.ToCharArrayRankOne(" "))).Length > 1 && Enumerable.ToList<string>(text.Split(Conversions.ToCharArrayRankOne(" ")))[0].EndsWith("x"))
						{
							string text3 = Enumerable.ToList<string>(text.Split(Conversions.ToCharArrayRankOne(" ")))[0];
							int num2 = Conversions.ToInteger(text3.Substring(0, text3.Length - 1));
							for (int j = 1; j <= num2; j++)
							{
								Engine engine = DBFunctions.smethod_94(int_, ref activeUnit_0);
								engine.Name = text + " #" + Conversions.ToString(j);
								activeUnit_0.vmethod_49().method_4(engine);
							}
						}
						else
						{
							int num3 = count - 1;
							for (int k = 0; k <= num3; k++)
							{
								dataRow = dataTable.Rows[k];
								Engine engine = DBFunctions.smethod_94(int_, ref activeUnit_0);
								activeUnit_0.vmethod_49().method_4(engine);
							}
						}
					}
					return;
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			int num4 = count - 1;
			for (int l = 0; l <= num4; l++)
			{
				DataRow dataRow = dataTable.Rows[l];
				Engine engine = DBFunctions.smethod_94(Conversions.ToInteger(dataRow["ID"].ToString()), ref activeUnit_0);
				activeUnit_0.vmethod_49().method_4(engine);
			}
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x002073C0 File Offset: 0x002055C0
		public static void smethod_87(ActiveUnit activeUnit_0, int int_0)
		{
			string str = "";
			Class403 class403_ = new Class403(activeUnit_0.scenario_0.method_39());
			if (activeUnit_0.bool_3)
			{
				str = "DataAircraftComms";
			}
			else if (activeUnit_0.bool_2)
			{
				str = "DataWeaponComms";
			}
			else if (activeUnit_0.bool_6)
			{
				str = "DataShipComms";
			}
			else if (activeUnit_0.bool_5)
			{
				str = "DataSubmarineComms";
			}
			else if (activeUnit_0.bool_8)
			{
				str = "DataFacilityComms";
			}
			else if (activeUnit_0.method_1())
			{
				str = "DataSatelliteComms";
			}
			string string_ = "Select DataComm.ID As CommID, theTable.* From DataComm, " + str + " As theTable Where DataComm.ID = theTable.ComponentID And theTable.ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				CommDevice commDevice = DBFunctions.smethod_95(Conversions.ToInteger(dataRow["CommID"]), ref activeUnit_0);
				if (dataTable.Columns.Contains("ParentSpecific"))
				{
					commDevice.bool_12 = Conversions.ToBoolean(dataRow["ParentSpecific"]);
				}
				if (activeUnit_0.bool_2 && ((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.Sonobuoy)
				{
					commDevice.bool_12 = false;
				}
				activeUnit_0.method_101(commDevice);
			}
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00207500 File Offset: 0x00205700
		public static void smethod_88(ref Warhead[] warhead_0, ref Weapon weapon_0)
		{
			Class403 class403_ = new Class403(weapon_0.scenario_0.method_39());
			string string_ = "Select ComponentID, ComponentNumber From DataWeaponWarheads Where ID =" + Conversions.ToString(weapon_0.DBID);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				Warhead warhead_ = DBFunctions.smethod_89(weapon_0.scenario_0, Conversions.ToInteger(dataRow["ComponentID"]));
				Class429.smethod_34(ref warhead_0, warhead_);
			}
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x00207590 File Offset: 0x00205790
		public static Warhead smethod_89(Scenario scenario_0, int int_0)
		{
			Class403 class403_ = new Class403(scenario_0.method_39());
			string string_ = "Select DataWarhead.* From DataWarhead Where ID =" + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			Warhead warhead;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				short short_ = 0;
				short short_2 = 0;
				if (dataTable.Columns.Contains("ClusterBombDispersionAreaLength"))
				{
					short_ = Conversions.ToShort(dataRow["ClusterBombDispersionAreaLength"]);
				}
				if (dataTable.Columns.Contains("ClusterBombDispersionAreaWidth"))
				{
					short_2 = Conversions.ToShort(dataRow["ClusterBombDispersionAreaWidth"]);
				}
				warhead = new Warhead(Conversions.ToString(dataRow["Name"]), (float)Conversions.ToDouble(dataRow["DamagePoints"]), (Warhead.WarheadType)Conversions.ToInteger(dataRow["Type"]), (Warhead.Enum126)Conversions.ToShort(dataRow["ExplosivesType"]), (Warhead.WarheadCaliber)Conversions.ToShort(dataRow["ProjectileCaliber"]), dataRow["NumberOfWarheads"].ToString());
				warhead.DBID = int_0;
				warhead.short_1 = short_;
				warhead.short_2 = short_2;
				try
				{
					warhead.bool_11 = Conversions.ToBoolean(dataRow["Hypothetical"]);
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200479", ex.Message);
					GameGeneral.smethod_25(ref ex);
					bool isAttached = Debugger.IsAttached;
				}
			}
			return warhead;
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x00207720 File Offset: 0x00205920
		public static void smethod_90(ref Sensor sensor_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "Select * From DataSensor Where ID = " + Conversions.ToString(sensor_0.DBID);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				sensor_0.float_26 = Conversions.ToSingle(dataRow["ESMSensitivity"]);
				sensor_0.float_27 = Conversions.ToSingle(dataRow["ESMSystemLoss"]);
				sensor_0.short_4 = Conversions.ToShort(dataRow["ESMNumberOfChannels"]);
				sensor_0.bool_13 = Conversions.ToBoolean(dataRow["ESMPreciseEmitterID"]);
			}
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x002077DC File Offset: 0x002059DC
		public static void smethod_91(ref CommDevice commDevice_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "Select CodeID From DataCommCapabilities Where ID = " + Conversions.ToString(commDevice_0.DBID);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				int num2 = Conversions.ToInteger(dataTable.Rows[i]["CodeID"]);
				if (num2 <= 1300)
				{
					if (num2 != 1200)
					{
						if (num2 != 1201)
						{
							if (num2 != 1300)
							{
								goto IL_106;
							}
							commDevice_0.struct31_0.bool_4 = true;
						}
						else
						{
							commDevice_0.struct31_0.bool_2 = true;
						}
					}
					else
					{
						commDevice_0.struct31_0.bool_3 = true;
					}
				}
				else if (num2 != 1401)
				{
					if (num2 != 1402)
					{
						switch (num2)
						{
						case 3001:
							commDevice_0.struct31_0.bool_5 = true;
							goto IL_1E7;
						case 3002:
							commDevice_0.struct31_0.bool_6 = true;
							goto IL_1E7;
						case 3003:
							commDevice_0.struct31_0.bool_8 = true;
							goto IL_1E7;
						case 3004:
							commDevice_0.struct31_0.bool_7 = true;
							goto IL_1E7;
						case 3005:
							commDevice_0.struct31_0.bool_9 = true;
							goto IL_1E7;
						case 3006:
							commDevice_0.struct31_0.bool_10 = true;
							goto IL_1E7;
						case 3007:
							commDevice_0.struct31_0.bool_11 = true;
							goto IL_1E7;
						case 3008:
							commDevice_0.struct31_0.bool_12 = true;
							goto IL_1E7;
						case 3009:
							commDevice_0.struct31_0.bool_13 = true;
							goto IL_1E7;
						case 3010:
							commDevice_0.struct31_0.bool_14 = true;
							goto IL_1E7;
						case 3011:
							commDevice_0.struct31_0.bool_15 = true;
							goto IL_1E7;
						}
						goto IL_106;
					}
					commDevice_0.struct31_0.bool_0 = true;
				}
				else
				{
					commDevice_0.struct31_0.bool_1 = true;
				}
				IL_1E7:
				i++;
				continue;
				IL_106:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					goto IL_1E7;
				}
				goto IL_1E7;
			}
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x002079DC File Offset: 0x00205BDC
		public static void smethod_92(ref Sensor sensor_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "Select * From DataSensor Where ID = " + Conversions.ToString(sensor_0.DBID);
			DataRow dataRow = Class401.smethod_1(class403_, string_).Rows[0];
			sensor_0.float_10 = Conversions.ToSingle(dataRow["RadarHorizontalBeamwidth"]);
			sensor_0.float_11 = Conversions.ToSingle(dataRow["RadarVerticalBeamwidth"]);
			sensor_0.float_12 = Conversions.ToSingle(dataRow["RadarSystemNoiseLevel"]);
			sensor_0.float_13 = Conversions.ToSingle(dataRow["RadarProcessingGainLoss"]);
			sensor_0.float_14 = Conversions.ToSingle(dataRow["RadarPeakPower"]);
			sensor_0.float_15 = Conversions.ToSingle(dataRow["RadarPulseWidth"]);
			sensor_0.float_16 = Conversions.ToSingle(dataRow["RadarBlindTime"]);
			sensor_0.float_17 = Conversions.ToSingle(dataRow["RadarPRF"]);
			sensor_0.float_18 = Conversions.ToSingle(dataRow["RadarHorizontalBeamwidthIlluminate"]);
			sensor_0.float_19 = Conversions.ToSingle(dataRow["RadarVerticalBeamwidthIlluminate"]);
			sensor_0.float_20 = Conversions.ToSingle(dataRow["RadarSystemNoiseLevelIlluminate"]);
			sensor_0.float_21 = Conversions.ToSingle(dataRow["RadarProcessingGainLossIlluminate"]);
			sensor_0.float_22 = Conversions.ToSingle(dataRow["RadarPeakPowerIlluminate"]);
			sensor_0.float_23 = Conversions.ToSingle(dataRow["RadarPulseWidthIlluminate"]);
			sensor_0.float_24 = Conversions.ToSingle(dataRow["RadarBlindTimeIlluminate"]);
			sensor_0.float_25 = Conversions.ToSingle(dataRow["RadarPRFIlluminate"]);
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00207B88 File Offset: 0x00205D88
		private static AltBand[] smethod_93(int int_0, ref ActiveUnit activeUnit_0)
		{
			AltBand[] array;
			AltBand[] result;
			if (activeUnit_0.scenario_0.Cache_PowerplantAltBands.TryGetValue(int_0, ref array))
			{
				result = array;
			}
			else
			{
				Class403 class403_ = new Class403(activeUnit_0.scenario_0.method_39());
				string string_ = "Select * From DataPropulsionPerformance As tPAS Where tPAS.ID = " + Conversions.ToString(int_0);
				DataTable dataTable = Class401.smethod_1(class403_, string_);
				bool flag = !dataTable.Columns.Contains("AltitudeBand");
				int count = dataTable.Rows.Count;
				Dictionary<int, AltBand> dictionary = new Dictionary<int, AltBand>(count);
				int num = count - 1;
				for (int i = 0; i <= num; i++)
				{
					DataRow dataRow = dataTable.Rows[i];
					int key;
					if (flag)
					{
						key = Conversions.ToInteger(dataRow["Band"]);
					}
					else
					{
						key = Conversions.ToInteger(dataRow["AltitudeBand"]);
					}
					AltBand altBand;
					if (dictionary.ContainsKey(key))
					{
						altBand = dictionary[key];
					}
					else
					{
						altBand = new AltBand(Conversions.ToSingle(dataRow["AltitudeMax"]), Conversions.ToSingle(dataRow["AltitudeMin"]));
						dictionary.Add(key, altBand);
					}
					switch (Conversions.ToByte(dataRow["Throttle"]))
					{
					case 1:
						altBand.float_2 = Conversions.ToSingle(dataRow["Consumption"]);
						altBand.int_0 = Conversions.ToInteger(dataRow["Speed"]);
						break;
					case 2:
						altBand.float_3 = Conversions.ToSingle(dataRow["Consumption"]);
						altBand.int_1 = Conversions.ToInteger(dataRow["Speed"]);
						break;
					case 3:
						altBand.nullable_2 = new float?(Conversions.ToSingle(Conversions.ToString(dataRow["Consumption"])));
						altBand.nullable_0 = (long?)dataRow["Speed"];
						break;
					case 4:
						altBand.nullable_3 = new float?(Conversions.ToSingle(Conversions.ToString(dataRow["Consumption"])));
						altBand.nullable_1 = (long?)dataRow["Speed"];
						break;
					}
				}
				array = Enumerable.ToArray<AltBand>(dictionary.Values);
				activeUnit_0.scenario_0.Cache_PowerplantAltBands.TryAdd(int_0, array);
				result = array;
			}
			return result;
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x00207DE4 File Offset: 0x00205FE4
		public static Engine smethod_94(int int_0, ref ActiveUnit activeUnit_0)
		{
			Class403 class403_ = new Class403(activeUnit_0.scenario_0.method_39());
			string string_ = "Select DataPropulsion.* From DataPropulsion Where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception1();
			}
			int count = dataTable.Rows.Count;
			DataRow dataRow = dataTable.Rows[0];
			Engine engine = new Engine(activeUnit_0, Conversions.ToInteger(dataRow["ID"]), Conversions.ToString(dataRow["Name"]), (Engine.Enum112)Conversions.ToShort(dataRow["Type"]));
			engine.method_19(activeUnit_0);
			if (dataTable.Columns.Contains("Hypothetical"))
			{
				engine.bool_11 = Conversions.ToBoolean(dataRow["Hypothetical"]);
			}
			engine.altBand_0 = DBFunctions.smethod_93(int_0, ref activeUnit_0);
			return engine;
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00207EC8 File Offset: 0x002060C8
		public static CommDevice smethod_95(int int_0, ref ActiveUnit activeUnit_0)
		{
			Class403 class403_ = new Class403(activeUnit_0.scenario_0.method_39());
			string string_ = "Select * From DataComm Where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception1();
			}
			CommDevice commDevice = null;
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				commDevice = new CommDevice(activeUnit_0, activeUnit_0.scenario_0, Conversions.ToInteger(dataRow["ID"]), Conversions.ToString(dataRow["Name"]), (CommDevice.CommLinkType)Conversions.ToInteger(dataRow["Type"]), Conversions.ToDouble(dataRow["Range"]), Conversions.ToInteger(dataRow["Channels"]), Conversions.ToBoolean(dataRow["IsOptional"]));
				commDevice.DBID = int_0;
				try
				{
					commDevice.bool_13 = Conversions.ToBoolean(dataRow["Hypothetical"]);
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200481", ex.Message);
					GameGeneral.smethod_25(ref ex);
					bool isAttached = Debugger.IsAttached;
				}
			}
			DBFunctions.smethod_102(ref commDevice, activeUnit_0.scenario_0.method_39());
			return commDevice;
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x00208038 File Offset: 0x00206238
		public static string smethod_96(int int_0, ref SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "SELECT Name from DataSensor where ID='" + Conversions.ToString(int_0) + "'";
			return Class401.smethod_2(class403_, string_);
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x00208068 File Offset: 0x00206268
		public static Sensor smethod_97(int int_0, ref SQLiteConnection sqliteConnection_0)
		{
			Sensor result;
			if (int_0 == 0)
			{
				result = Sensor.smethod_5(sqliteConnection_0);
			}
			else
			{
				Class403 class403_ = new Class403(sqliteConnection_0);
				string string_ = "Select DataSensor.*, EnumSensorRole.Description from DataSensor, EnumSensorRole where EnumSensorRole.ID = DataSensor.Role and DataSensor.ID = " + Conversions.ToString(int_0);
				DataTable dataTable = Class401.smethod_1(class403_, string_);
				if (dataTable.Rows.Count == 0)
				{
					throw new Exception1("No valid sensor with ID #" + Conversions.ToString(int_0) + " ! Please pester the DB author to fix this!");
				}
				Sensor sensor = null;
				DataRow dataRow = dataTable.Rows[0];
				int sensorDBID = Conversions.ToInteger(dataRow["ID"]);
				string theName = Conversions.ToString(dataRow["Name"]);
				float theVisualDetectZoom = Conversions.ToSingle(dataRow["VisualDetectionZoomLevel"]);
				float theVisualClassZoom = Conversions.ToSingle(dataRow["VisualClassificationZoomLevel"]);
				float theIRDetectZoom = Conversions.ToSingle(dataRow["IRDetectionZoomLevel"]);
				float theIRClassZoom = Conversions.ToSingle(dataRow["IRClassificationZoomLevel"]);
				Sensor.Sensor_Type theSensorType = (Sensor.Sensor_Type)Conversions.ToShort(dataRow["Type"]);
				Sensor.Sensor_Role theSensorRole = (Sensor.Sensor_Role)Conversions.ToLong(dataRow["Role"]);
				GlobalVariables.TechGenerationClass theGeneration = (GlobalVariables.TechGenerationClass)Conversions.ToInteger(dataRow["Generation"]);
				float theMaxRange = Conversions.ToSingle(dataRow["RangeMax"]);
				float theMinRange = Conversions.ToSingle(dataRow["RangeMin"]);
				short theMineSweepWidth;
				if (dataTable.Columns.Contains("MineSweepWidth"))
				{
					theMineSweepWidth = Conversions.ToShort(dataRow["MineSweepWidth"]);
				}
				short theMineMaxSpeed;
				if (dataTable.Columns.Contains("MineSweepMaximumSpeed"))
				{
					theMineMaxSpeed = Conversions.ToShort(dataRow["MineSweepMaximumSpeed"]);
				}
				int theMaxIntercept = Conversions.ToInteger(dataRow["MaxContactsIlluminate"]);
				float theMaxAltitude = (float)Conversions.ToInteger(dataRow["AltitudeMax"]);
				float theMinAltitude = (float)Conversions.ToInteger(dataRow["AltitudeMin"]);
				float theMaxAltitude_ASL = 0f;
				if (dataTable.Columns.Contains("AltitudeMax_ASL"))
				{
					theMaxAltitude_ASL = (float)Conversions.ToInteger(dataRow["AltitudeMax_ASL"]);
				}
				float theMinAltitude_ASL = 0f;
				if (dataTable.Columns.Contains("AltitudeMin_ASL"))
				{
					theMinAltitude_ASL = (float)Conversions.ToInteger(dataRow["AltitudeMin_ASL"]);
				}
				int theScanInterval = Conversions.ToInteger(dataRow["ScanInterval"]);
				float theRangeResolution = Conversions.ToSingle(dataRow["ResolutionRange"]);
				float theHeightResolution = Conversions.ToSingle(dataRow["ResolutionHeight"]);
				float theAngleResolution = Conversions.ToSingle(dataRow["ResolutionAngle"]);
				short theMasqueradeAs = Conversions.ToShort(dataRow["MasqueradeAs"]);
				short theMaxContactsAir = Conversions.ToShort(dataRow["MaxContactsAir"]);
				short theMaxContactsSurface = Conversions.ToShort(dataRow["MaxContactsSurface"]);
				short theMaxContactsSub = Conversions.ToShort(dataRow["MaxContactsSubmarine"]);
				float theAvailability = Conversions.ToSingle(dataRow["Availability"]);
				long theUpperFreq = Conversions.ToLong(dataRow["FrequencyUpper"]);
				long theLowerFreq = Conversions.ToLong(dataRow["FrequencyLower"]);
				long theUpperFreqIlluminate = Conversions.ToLong(dataRow["FrequencyUpperIlluminate"]);
				long theLowerFreqIlluminate = Conversions.ToLong(dataRow["FrequencyLowerIlluminate"]);
				float theECMGain = Conversions.ToSingle(dataRow["ECMGain"]);
				float theECMPeakPower = Conversions.ToSingle(dataRow["ECMPeakPower"]);
				float theECMPokReduction = Conversions.ToSingle(dataRow["ECMPokReduction"]);
				float theECMBandwidth = Conversions.ToSingle(dataRow["ECMBandwidth"]);
				float theECMNumberofTargets = Conversions.ToSingle(dataRow["ECMNumberOfTargets"]);
				float dfaccuracy = Conversions.ToSingle(dataRow["DirectionFindingAccuracy"]);
				bool isHypothetical;
				if (dataTable.Columns.Contains("Hypothetical"))
				{
					isHypothetical = Conversions.ToBoolean(dataRow["Hypothetical"]);
				}
				int thePassiveInput;
				sensor = new Sensor(ref sqliteConnection_0, sensorDBID, theName, theSensorType, theSensorRole, theGeneration, theMaxRange, theMinRange, 0, 0, thePassiveInput, theMaxIntercept, theMaxAltitude, theMinAltitude, theMaxAltitude_ASL, theMinAltitude_ASL, theScanInterval, theRangeResolution, theAngleResolution, theHeightResolution, false, theMasqueradeAs, theMaxContactsAir, theMaxContactsSurface, theMaxContactsSub, theAvailability, theUpperFreq, theLowerFreq, theUpperFreqIlluminate, theLowerFreqIlluminate, theECMGain, theECMPeakPower, theECMBandwidth, theECMNumberofTargets, theECMPokReduction, dfaccuracy, theMineSweepWidth, theMineMaxSpeed, theVisualDetectZoom, theVisualClassZoom, theIRDetectZoom, theIRClassZoom, isHypothetical);
				sensor.string_2 = Conversions.ToString(dataRow["Description"]);
				DBFunctions.smethod_98(ref sensor, sqliteConnection_0);
				if (sensor.method_75())
				{
					sensor.float_0 = 150f;
				}
				result = sensor;
			}
			return result;
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x002084A8 File Offset: 0x002066A8
		public static void smethod_98(ref Sensor sensor_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 @class = new Class403(sqliteConnection_0);
			try
			{
				if (@class.method_6("MiscSensorDefault"))
				{
					string string_ = "Select * from MiscSensorDefault WHERE ID = " + Conversions.ToString(sensor_0.DBID);
					DBFunctions.Struct37 @struct;
					@struct.class295_0 = new PlatformComponent.Class295();
					@struct.class295_1 = new PlatformComponent.Class295();
					object objectValue = RuntimeHelpers.GetObjectValue(Class401.smethod_3(@class, string_));
					if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue)))
					{
						if (objectValue.GetType() == typeof(DBFunctions.Struct37))
						{
							object obj = objectValue;
							@struct = ((obj != null) ? ((DBFunctions.Struct37)obj) : default(DBFunctions.Struct37));
							goto IL_460;
						}
					}
					@struct.class295_0 = new PlatformComponent.Class295();
					@struct.class295_1 = new PlatformComponent.Class295();
					DataTable dataTable = Class401.smethod_1(@class, string_);
					if (dataTable.Rows.Count == 0)
					{
						return;
					}
					DataRow dataRow = dataTable.Rows[0];
					@struct.class295_0.bool_3 = Conversions.ToBoolean(dataRow["PB1"]);
					@struct.class295_0.bool_11 = Conversions.ToBoolean(dataRow["PB2"]);
					@struct.class295_0.bool_2 = Conversions.ToBoolean(dataRow["PMF1"]);
					@struct.class295_0.bool_10 = Conversions.ToBoolean(dataRow["PMF2"]);
					@struct.class295_0.bool_1 = Conversions.ToBoolean(dataRow["PMA1"]);
					@struct.class295_0.bool_9 = Conversions.ToBoolean(dataRow["PMA2"]);
					@struct.class295_0.bool_0 = Conversions.ToBoolean(dataRow["PS1"]);
					@struct.class295_0.bool_8 = Conversions.ToBoolean(dataRow["PS2"]);
					@struct.class295_0.bool_7 = Conversions.ToBoolean(dataRow["SB1"]);
					@struct.class295_0.bool_15 = Conversions.ToBoolean(dataRow["SB2"]);
					@struct.class295_0.bool_6 = Conversions.ToBoolean(dataRow["SMF1"]);
					@struct.class295_0.bool_14 = Conversions.ToBoolean(dataRow["SMF2"]);
					@struct.class295_0.bool_5 = Conversions.ToBoolean(dataRow["SMA1"]);
					@struct.class295_0.bool_13 = Conversions.ToBoolean(dataRow["SMA2"]);
					@struct.class295_0.bool_4 = Conversions.ToBoolean(dataRow["SS1"]);
					@struct.class295_0.bool_12 = Conversions.ToBoolean(dataRow["SS2"]);
					@struct.class295_1.bool_3 = Conversions.ToBoolean(dataRow["PB1Max"]);
					@struct.class295_1.bool_11 = Conversions.ToBoolean(dataRow["PB2Max"]);
					@struct.class295_1.bool_2 = Conversions.ToBoolean(dataRow["PMF1Max"]);
					@struct.class295_1.bool_10 = Conversions.ToBoolean(dataRow["PMF2Max"]);
					@struct.class295_1.bool_1 = Conversions.ToBoolean(dataRow["PMA1Max"]);
					@struct.class295_1.bool_9 = Conversions.ToBoolean(dataRow["PMA2Max"]);
					@struct.class295_1.bool_0 = Conversions.ToBoolean(dataRow["PS1Max"]);
					@struct.class295_1.bool_8 = Conversions.ToBoolean(dataRow["PS2Max"]);
					@struct.class295_1.bool_7 = Conversions.ToBoolean(dataRow["SB1Max"]);
					@struct.class295_1.bool_15 = Conversions.ToBoolean(dataRow["SB2Max"]);
					@struct.class295_1.bool_6 = Conversions.ToBoolean(dataRow["SMF1Max"]);
					@struct.class295_1.bool_14 = Conversions.ToBoolean(dataRow["SMF2Max"]);
					@struct.class295_1.bool_5 = Conversions.ToBoolean(dataRow["SMA1Max"]);
					@struct.class295_1.bool_13 = Conversions.ToBoolean(dataRow["SMA2Max"]);
					@struct.class295_1.bool_4 = Conversions.ToBoolean(dataRow["SS1Max"]);
					@struct.class295_1.bool_12 = Conversions.ToBoolean(dataRow["SS2Max"]);
					Class401.smethod_4(@class, string_, @struct);
					IL_460:
					Sensor sensor = sensor_0;
					sensor.class295_0.bool_3 = @struct.class295_0.bool_3;
					sensor.class295_0.bool_11 = @struct.class295_0.bool_11;
					sensor.class295_0.bool_2 = @struct.class295_0.bool_2;
					sensor.class295_0.bool_10 = @struct.class295_0.bool_10;
					sensor.class295_0.bool_1 = @struct.class295_0.bool_1;
					sensor.class295_0.bool_9 = @struct.class295_0.bool_9;
					sensor.class295_0.bool_0 = @struct.class295_0.bool_0;
					sensor.class295_0.bool_8 = @struct.class295_0.bool_8;
					sensor.class295_0.bool_7 = @struct.class295_0.bool_7;
					sensor.class295_0.bool_15 = @struct.class295_0.bool_15;
					sensor.class295_0.bool_6 = @struct.class295_0.bool_6;
					sensor.class295_0.bool_14 = @struct.class295_0.bool_14;
					sensor.class295_0.bool_5 = @struct.class295_0.bool_5;
					sensor.class295_0.bool_13 = @struct.class295_0.bool_13;
					sensor.class295_0.bool_4 = @struct.class295_0.bool_4;
					sensor.class295_0.bool_12 = @struct.class295_0.bool_12;
					sensor.class295_1.bool_3 = @struct.class295_1.bool_3;
					sensor.class295_1.bool_11 = @struct.class295_1.bool_11;
					sensor.class295_1.bool_2 = @struct.class295_1.bool_2;
					sensor.class295_1.bool_10 = @struct.class295_1.bool_10;
					sensor.class295_1.bool_1 = @struct.class295_1.bool_1;
					sensor.class295_1.bool_9 = @struct.class295_1.bool_9;
					sensor.class295_1.bool_0 = @struct.class295_1.bool_0;
					sensor.class295_1.bool_8 = @struct.class295_1.bool_8;
					sensor.class295_1.bool_7 = @struct.class295_1.bool_7;
					sensor.class295_1.bool_15 = @struct.class295_1.bool_15;
					sensor.class295_1.bool_6 = @struct.class295_1.bool_6;
					sensor.class295_1.bool_14 = @struct.class295_1.bool_14;
					sensor.class295_1.bool_5 = @struct.class295_1.bool_5;
					sensor.class295_1.bool_13 = @struct.class295_1.bool_13;
					sensor.class295_1.bool_4 = @struct.class295_1.bool_4;
					sensor.class295_1.bool_12 = @struct.class295_1.bool_12;
				}
				else
				{
					Sensor sensor2 = sensor_0;
					sensor2.class295_0.bool_3 = true;
					sensor2.class295_0.bool_11 = true;
					sensor2.class295_0.bool_2 = true;
					sensor2.class295_0.bool_10 = true;
					sensor2.class295_0.bool_1 = true;
					sensor2.class295_0.bool_9 = true;
					sensor2.class295_0.bool_0 = true;
					sensor2.class295_0.bool_8 = true;
					sensor2.class295_0.bool_7 = true;
					sensor2.class295_0.bool_15 = true;
					sensor2.class295_0.bool_6 = true;
					sensor2.class295_0.bool_14 = true;
					sensor2.class295_0.bool_5 = true;
					sensor2.class295_0.bool_13 = true;
					sensor2.class295_0.bool_4 = true;
					sensor2.class295_0.bool_12 = true;
					sensor2.class295_1.bool_3 = true;
					sensor2.class295_1.bool_11 = true;
					sensor2.class295_1.bool_2 = true;
					sensor2.class295_1.bool_10 = true;
					sensor2.class295_1.bool_1 = true;
					sensor2.class295_1.bool_9 = true;
					sensor2.class295_1.bool_0 = true;
					sensor2.class295_1.bool_8 = true;
					sensor2.class295_1.bool_7 = true;
					sensor2.class295_1.bool_15 = true;
					sensor2.class295_1.bool_6 = true;
					sensor2.class295_1.bool_14 = true;
					sensor2.class295_1.bool_5 = true;
					sensor2.class295_1.bool_13 = true;
					sensor2.class295_1.bool_4 = true;
					sensor2.class295_1.bool_12 = true;
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x00208D94 File Offset: 0x00206F94
		public static void smethod_99(ActiveUnit activeUnit_0, int int_0)
		{
			string text = "";
			Class403 class403_ = new Class403(activeUnit_0.scenario_0.method_39());
			if (activeUnit_0.bool_3)
			{
				text = "DataAircraftSensors";
			}
			else if (activeUnit_0.bool_2)
			{
				text = "DataWeaponSensors";
			}
			else if (activeUnit_0.bool_6)
			{
				text = "DataShipSensors";
			}
			else if (activeUnit_0.bool_5)
			{
				text = "DataSubmarineSensors";
			}
			else if (activeUnit_0.bool_8)
			{
				text = "DataFacilitySensors";
			}
			else if (activeUnit_0.method_1())
			{
				text = "DataSatelliteSensors";
			}
			string string_ = string.Concat(new string[]
			{
				"Select DataSensor.ID As SensorID, DataSensor.Type As SensorType, theTable.* FROM DataSensor, ",
				text,
				" As theTable WHERE DataSensor.ID = theTable.ComponentID And theTable.ID = ",
				Conversions.ToString(int_0),
				" ORDER BY DataSensor.Type, DataSensor.Name ASC"
			});
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			Operators.CompareString(text, "DataWeaponSensors", false);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				DataRow dataRow = dataTable.Rows[i];
				int int_ = Conversions.ToInteger(dataRow["SensorID"]);
				SQLiteConnection sqliteConnection = activeUnit_0.scenario_0.method_39();
				Sensor sensor = DBFunctions.smethod_97(int_, ref sqliteConnection);
				if (sensor.sensor_Type_0 == Sensor.Sensor_Type.SensorGroup)
				{
					string_ = "Select ComponentID from DataSensorSensorGroups where ID = " + Conversions.ToString(sensor.DBID);
					DataTable dataTable2 = Class401.smethod_1(class403_, string_);
					try
					{
						foreach (object obj in dataTable2.Rows)
						{
							int int_2 = Conversions.ToInteger(((DataRow)obj)["ComponentID"]);
							sqliteConnection = activeUnit_0.scenario_0.method_39();
							Sensor sensor2 = DBFunctions.smethod_97(int_2, ref sqliteConnection);
							sensor2.class295_0.bool_3 = Conversions.ToBoolean(dataRow["PB1"]);
							sensor2.class295_0.bool_1 = Conversions.ToBoolean(dataRow["PMA1"]);
							sensor2.class295_0.bool_2 = Conversions.ToBoolean(dataRow["PMF1"]);
							sensor2.class295_0.bool_0 = Conversions.ToBoolean(dataRow["PS1"]);
							sensor2.class295_0.bool_7 = Conversions.ToBoolean(dataRow["SB1"]);
							sensor2.class295_0.bool_5 = Conversions.ToBoolean(dataRow["SMA1"]);
							sensor2.class295_0.bool_6 = Conversions.ToBoolean(dataRow["SMF1"]);
							sensor2.class295_0.bool_4 = Conversions.ToBoolean(dataRow["SS1"]);
							sensor2.class295_0.bool_11 = Conversions.ToBoolean(dataRow["PB2"]);
							sensor2.class295_0.bool_9 = Conversions.ToBoolean(dataRow["PMA2"]);
							sensor2.class295_0.bool_10 = Conversions.ToBoolean(dataRow["PMF2"]);
							sensor2.class295_0.bool_8 = Conversions.ToBoolean(dataRow["PS2"]);
							sensor2.class295_0.bool_15 = Conversions.ToBoolean(dataRow["SB2"]);
							sensor2.class295_0.bool_13 = Conversions.ToBoolean(dataRow["SMA2"]);
							sensor2.class295_0.bool_14 = Conversions.ToBoolean(dataRow["SMF2"]);
							sensor2.class295_0.bool_12 = Conversions.ToBoolean(dataRow["SS2"]);
							sensor2.class295_1.bool_3 = Conversions.ToBoolean(dataRow["PB1MAX"]);
							sensor2.class295_1.bool_1 = Conversions.ToBoolean(dataRow["PMA1MAX"]);
							sensor2.class295_1.bool_2 = Conversions.ToBoolean(dataRow["PMF1MAX"]);
							sensor2.class295_1.bool_0 = Conversions.ToBoolean(dataRow["PS1MAX"]);
							sensor2.class295_1.bool_7 = Conversions.ToBoolean(dataRow["SB1MAX"]);
							sensor2.class295_1.bool_5 = Conversions.ToBoolean(dataRow["SMA1MAX"]);
							sensor2.class295_1.bool_6 = Conversions.ToBoolean(dataRow["SMF1MAX"]);
							sensor2.class295_1.bool_4 = Conversions.ToBoolean(dataRow["SS1MAX"]);
							sensor2.class295_1.bool_11 = Conversions.ToBoolean(dataRow["PB2MAX"]);
							sensor2.class295_1.bool_9 = Conversions.ToBoolean(dataRow["PMA2MAX"]);
							sensor2.class295_1.bool_10 = Conversions.ToBoolean(dataRow["PMF2MAX"]);
							sensor2.class295_1.bool_8 = Conversions.ToBoolean(dataRow["PS2MAX"]);
							sensor2.class295_1.bool_15 = Conversions.ToBoolean(dataRow["SB2MAX"]);
							sensor2.class295_1.bool_13 = Conversions.ToBoolean(dataRow["SMA2MAX"]);
							sensor2.class295_1.bool_14 = Conversions.ToBoolean(dataRow["SMF2MAX"]);
							sensor2.class295_1.bool_12 = Conversions.ToBoolean(dataRow["SS2MAX"]);
							sensor2.method_19(activeUnit_0);
							activeUnit_0.method_102(sensor2);
						}
						goto IL_904;
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					goto IL_554;
				}
				goto IL_554;
				IL_904:
				i++;
				continue;
				IL_554:
				sensor.class295_0.bool_3 = Conversions.ToBoolean(dataRow["PB1"]);
				sensor.class295_0.bool_1 = Conversions.ToBoolean(dataRow["PMA1"]);
				sensor.class295_0.bool_2 = Conversions.ToBoolean(dataRow["PMF1"]);
				sensor.class295_0.bool_0 = Conversions.ToBoolean(dataRow["PS1"]);
				sensor.class295_0.bool_7 = Conversions.ToBoolean(dataRow["SB1"]);
				sensor.class295_0.bool_5 = Conversions.ToBoolean(dataRow["SMA1"]);
				sensor.class295_0.bool_6 = Conversions.ToBoolean(dataRow["SMF1"]);
				sensor.class295_0.bool_4 = Conversions.ToBoolean(dataRow["SS1"]);
				sensor.class295_0.bool_11 = Conversions.ToBoolean(dataRow["PB2"]);
				sensor.class295_0.bool_9 = Conversions.ToBoolean(dataRow["PMA2"]);
				sensor.class295_0.bool_10 = Conversions.ToBoolean(dataRow["PMF2"]);
				sensor.class295_0.bool_8 = Conversions.ToBoolean(dataRow["PS2"]);
				sensor.class295_0.bool_15 = Conversions.ToBoolean(dataRow["SB2"]);
				sensor.class295_0.bool_13 = Conversions.ToBoolean(dataRow["SMA2"]);
				sensor.class295_0.bool_14 = Conversions.ToBoolean(dataRow["SMF2"]);
				sensor.class295_0.bool_12 = Conversions.ToBoolean(dataRow["SS2"]);
				sensor.class295_1.bool_3 = Conversions.ToBoolean(dataRow["PB1MAX"]);
				sensor.class295_1.bool_1 = Conversions.ToBoolean(dataRow["PMA1MAX"]);
				sensor.class295_1.bool_2 = Conversions.ToBoolean(dataRow["PMF1MAX"]);
				sensor.class295_1.bool_0 = Conversions.ToBoolean(dataRow["PS1MAX"]);
				sensor.class295_1.bool_7 = Conversions.ToBoolean(dataRow["SB1MAX"]);
				sensor.class295_1.bool_5 = Conversions.ToBoolean(dataRow["SMA1MAX"]);
				sensor.class295_1.bool_6 = Conversions.ToBoolean(dataRow["SMF1MAX"]);
				sensor.class295_1.bool_4 = Conversions.ToBoolean(dataRow["SS1MAX"]);
				sensor.class295_1.bool_11 = Conversions.ToBoolean(dataRow["PB2MAX"]);
				sensor.class295_1.bool_9 = Conversions.ToBoolean(dataRow["PMA2MAX"]);
				sensor.class295_1.bool_10 = Conversions.ToBoolean(dataRow["PMF2MAX"]);
				sensor.class295_1.bool_8 = Conversions.ToBoolean(dataRow["PS2MAX"]);
				sensor.class295_1.bool_15 = Conversions.ToBoolean(dataRow["SB2MAX"]);
				sensor.class295_1.bool_13 = Conversions.ToBoolean(dataRow["SMA2MAX"]);
				sensor.class295_1.bool_14 = Conversions.ToBoolean(dataRow["SMF2MAX"]);
				sensor.class295_1.bool_12 = Conversions.ToBoolean(dataRow["SS2MAX"]);
				sensor.method_19(activeUnit_0);
				activeUnit_0.method_102(sensor);
				goto IL_904;
			}
			if (activeUnit_0.vmethod_43() && (((Class350)activeUnit_0).int_6 > 0 || (!activeUnit_0.method_5() && !activeUnit_0.method_1() && (!activeUnit_0.bool_3 || (((Aircraft)activeUnit_0)._AircraftType_0 != Aircraft._AircraftType.UAV && ((Aircraft)activeUnit_0)._AircraftType_0 != Aircraft._AircraftType.UCAV)) && (!activeUnit_0.bool_5 || (((Submarine)activeUnit_0)._SubmarineType_0 != Submarine._SubmarineType.UUV && ((Submarine)activeUnit_0)._SubmarineType_0 != Submarine._SubmarineType.ROV)))))
			{
				Sensor sensor3 = Sensor.smethod_5(activeUnit_0.scenario_0.method_39());
				sensor3.class295_0.bool_3 = true;
				sensor3.class295_0.bool_1 = true;
				sensor3.class295_0.bool_2 = true;
				sensor3.class295_0.bool_0 = true;
				sensor3.class295_0.bool_7 = true;
				sensor3.class295_0.bool_5 = true;
				sensor3.class295_0.bool_6 = true;
				sensor3.class295_0.bool_4 = true;
				sensor3.class295_0.bool_11 = true;
				sensor3.class295_0.bool_9 = true;
				sensor3.class295_0.bool_10 = true;
				sensor3.class295_0.bool_8 = true;
				sensor3.class295_0.bool_15 = true;
				sensor3.class295_0.bool_13 = true;
				sensor3.class295_0.bool_14 = true;
				sensor3.class295_0.bool_12 = true;
				sensor3.method_19(activeUnit_0);
				activeUnit_0.method_102(sensor3);
			}
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x00209858 File Offset: 0x00207A58
		public static void smethod_100(ref Sensor sensor_0, int int_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "Select * from DataSensorCodes where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				int num2 = Conversions.ToInteger(dataTable.Rows[i]["CodeID"]);
				if (num2 <= 2002)
				{
					if (num2 <= 1012)
					{
						switch (num2)
						{
						case 1001:
							sensor_0.struct33_0.bool_0 = true;
							break;
						case 1002:
							sensor_0.struct33_0.bool_1 = true;
							break;
						case 1003:
							sensor_0.struct33_0.bool_2 = true;
							break;
						case 1004:
							sensor_0.struct33_0.bool_3 = true;
							break;
						default:
							if (num2 != 1011)
							{
								if (num2 != 1012)
								{
									goto IL_329;
								}
								sensor_0.struct33_0.bool_5 = true;
							}
							else
							{
								sensor_0.struct33_0.bool_4 = true;
							}
							break;
						}
					}
					else if (num2 <= 1033)
					{
						if (num2 != 1021)
						{
							switch (num2)
							{
							case 1031:
								sensor_0.struct33_0.bool_22 = true;
								break;
							case 1032:
								sensor_0.struct33_0.bool_23 = true;
								break;
							case 1033:
								sensor_0.struct33_0.bool_24 = true;
								break;
							default:
								goto IL_329;
							}
						}
						else
						{
							sensor_0.struct33_0.bool_6 = true;
						}
					}
					else if (num2 != 2001)
					{
						if (num2 != 2002)
						{
							goto IL_329;
						}
						sensor_0.struct33_0.bool_8 = true;
					}
					else
					{
						sensor_0.struct33_0.bool_7 = true;
					}
				}
				else if (num2 <= 3013)
				{
					if (num2 <= 2701)
					{
						if (num2 != 2011)
						{
							if (num2 != 2701)
							{
								goto IL_329;
							}
							sensor_0.struct33_0.bool_10 = true;
						}
						else
						{
							sensor_0.struct33_0.bool_9 = true;
						}
					}
					else
					{
						switch (num2)
						{
						case 3001:
							sensor_0.struct33_0.bool_11 = true;
							break;
						case 3002:
							sensor_0.struct33_0.bool_13 = true;
							break;
						case 3003:
							sensor_0.struct33_0.bool_12 = true;
							break;
						default:
							switch (num2)
							{
							case 3011:
								sensor_0.struct33_0.bool_19 = true;
								break;
							case 3012:
								sensor_0.struct33_0.bool_20 = true;
								break;
							case 3013:
								sensor_0.struct33_0.bool_21 = true;
								break;
							default:
								goto IL_329;
							}
							break;
						}
					}
				}
				else if (num2 <= 5001)
				{
					switch (num2)
					{
					case 4001:
						sensor_0.struct33_0.bool_14 = true;
						break;
					case 4002:
						sensor_0.struct33_0.bool_15 = true;
						break;
					case 4003:
						sensor_0.struct33_0.bool_16 = true;
						break;
					default:
						if (num2 != 5001)
						{
							goto IL_329;
						}
						sensor_0.struct33_0.bool_25 = true;
						break;
					}
				}
				else if (num2 != 9101)
				{
					if (num2 != 9102)
					{
						goto IL_329;
					}
					sensor_0.struct33_0.bool_18 = true;
				}
				else
				{
					sensor_0.struct33_0.bool_17 = true;
				}
				IL_353:
				i++;
				continue;
				IL_329:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					goto IL_353;
				}
				goto IL_353;
			}
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x00209BC4 File Offset: 0x00207DC4
		public static void smethod_101(ref Sensor sensor_0, int int_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "Select * from DataSensorCapabilities where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				int num2 = Conversions.ToInteger(dataTable.Rows[i]["CodeID"]);
				if (num2 <= 2004)
				{
					switch (num2)
					{
					case 1001:
						sensor_0.struct32_0.bool_0 = true;
						break;
					case 1002:
						sensor_0.struct32_0.bool_1 = true;
						break;
					case 1003:
						sensor_0.struct32_0.bool_2 = true;
						break;
					case 1004:
						sensor_0.struct32_0.bool_4 = true;
						break;
					case 1005:
						sensor_0.struct32_0.bool_3 = true;
						break;
					case 1006:
						sensor_0.struct32_0.bool_5 = true;
						break;
					case 1007:
						break;
					case 1008:
					case 1009:
					case 1010:
						goto IL_1FF;
					case 1011:
						sensor_0.struct32_0.bool_6 = true;
						break;
					default:
						switch (num2)
						{
						case 1021:
							sensor_0.struct32_0.bool_7 = true;
							break;
						case 1022:
							sensor_0.struct32_0.bool_19 = true;
							break;
						case 1023:
							sensor_0.struct32_0.bool_20 = true;
							break;
						default:
							switch (num2)
							{
							case 2001:
								sensor_0.struct32_0.bool_8 = true;
								break;
							case 2002:
								sensor_0.struct32_0.bool_10 = true;
								break;
							case 2003:
								sensor_0.struct32_0.bool_11 = true;
								break;
							case 2004:
								sensor_0.struct32_0.bool_9 = true;
								break;
							default:
								goto IL_1FF;
							}
							break;
						}
						break;
					}
				}
				else
				{
					switch (num2)
					{
					case 4001:
						sensor_0.struct32_0.bool_12 = true;
						break;
					case 4002:
						sensor_0.struct32_0.bool_13 = true;
						break;
					case 4003:
						sensor_0.struct32_0.bool_14 = true;
						break;
					case 4004:
						sensor_0.struct32_0.bool_15 = true;
						break;
					case 4005:
						sensor_0.struct32_0.bool_16 = true;
						break;
					default:
						if (num2 != 9001)
						{
							if (num2 != 9002)
							{
								goto IL_1FF;
							}
							sensor_0.struct32_0.bool_18 = true;
						}
						else
						{
							sensor_0.struct32_0.bool_17 = true;
						}
						break;
					}
				}
				IL_274:
				i++;
				continue;
				IL_1FF:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					goto IL_274;
				}
				goto IL_274;
			}
			if (sensor_0.sensor_Type_0 == Sensor.Sensor_Type.ESM)
			{
				sensor_0.struct32_0.bool_0 = true;
				sensor_0.struct32_0.bool_1 = true;
			}
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x00209E78 File Offset: 0x00208078
		public static void smethod_102(ref CommDevice commDevice_0, SQLiteConnection sqliteConnection_0)
		{
			try
			{
				Class403 class403_ = new Class403(sqliteConnection_0);
				string string_ = "Select * from DataCommCapabilities where ID = " + Conversions.ToString(commDevice_0.DBID);
				DataTable dataTable = Class401.smethod_1(class403_, string_);
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					DataRow dataRow = dataTable.Rows[i];
					int num2 = Conversions.ToInteger(dataRow["CodeID"]);
					if (num2 - 1200 > 1 && num2 != 1300 && num2 - 1401 > 1)
					{
						Sensor.FrequencyBand frequencyBand = (Sensor.FrequencyBand)Conversions.ToLong(dataRow["CodeID"]);
						commDevice_0.hashSet_0.Add(frequencyBand);
					}
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x00209F54 File Offset: 0x00208154
		public static void smethod_103(ref Sensor sensor_0, int int_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "Select * from DataSensorFrequencySearchAndTrack where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int count = dataTable.Rows.Count;
			sensor_0.radioElectronicFrequency_0 = new Sensor.RadioElectronicFrequency[count - 1 + 1];
			int num = count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				Sensor.RadioElectronicFrequency radioElectronicFrequency = new Sensor.RadioElectronicFrequency((Sensor.FrequencyBand)Conversions.ToLong(dataRow["Frequency"]));
				sensor_0.radioElectronicFrequency_0[i] = radioElectronicFrequency;
			}
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x00209FE4 File Offset: 0x002081E4
		public static void smethod_104(ref Sensor sensor_0, int int_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "Select * from DataSensorFrequencyIlluminate where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int count = dataTable.Rows.Count;
			sensor_0.radioElectronicFrequency_1 = new Sensor.RadioElectronicFrequency[count - 1 + 1];
			int num = count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				Sensor.RadioElectronicFrequency radioElectronicFrequency = new Sensor.RadioElectronicFrequency((Sensor.FrequencyBand)Conversions.ToLong(dataRow["Frequency"]));
				sensor_0.radioElectronicFrequency_1[i] = radioElectronicFrequency;
			}
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0020A074 File Offset: 0x00208274
		public static bool smethod_105(int int_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "Select count(*) FROM sqlite_master WHERE type='table' AND name='Capabilities'";
			bool result;
			if (Conversions.ToInteger(Class401.smethod_2(class403_, string_)) == 0)
			{
				result = false;
			}
			else if (int_0 == 0)
			{
				result = true;
			}
			else
			{
				string_ = "SELECT Count(*) from Capabilities where ID='" + Conversions.ToString(int_0) + "'";
				result = (Conversions.ToInteger(Class401.smethod_2(class403_, string_)) > 0);
			}
			return result;
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x0020A0D0 File Offset: 0x002082D0
		public static XSection[] smethod_106(ActiveUnit activeUnit_0)
		{
			string str = "";
			Class403 class403_ = new Class403(activeUnit_0.scenario_0.method_39());
			switch (activeUnit_0.vmethod_56())
			{
			case GlobalVariables.ActiveUnitType.Aircraft:
				str = "DataAircraftSignatures";
				break;
			case GlobalVariables.ActiveUnitType.Ship:
				str = "DataShipSignatures";
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				str = "DataSubmarineSignatures";
				break;
			case GlobalVariables.ActiveUnitType.Facility:
				str = "DataFacilitySignatures";
				break;
			case GlobalVariables.ActiveUnitType.Weapon:
				str = "DataWeaponSignatures";
				break;
			case GlobalVariables.ActiveUnitType.Satellite:
				str = "DataSatelliteSignatures";
				break;
			}
			string string_ = "Select * From " + str + " as theTable where theTable.ID = " + Conversions.ToString(activeUnit_0.DBID);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int count = dataTable.Rows.Count;
			XSection[] array = new XSection[count - 1 + 1];
			int num = count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				XSection xsection = new XSection((XSection.Enum132)Conversions.ToShort(dataRow["Type"]), Conversions.ToSingle(dataRow["Front"]), Conversions.ToSingle(dataRow["Side"]), Conversions.ToSingle(dataRow["Rear"]), 0f);
				array[i] = xsection;
			}
			return array;
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0020A20C File Offset: 0x0020840C
		public static void smethod_107(ActiveUnit activeUnit_0, int int_0)
		{
			string str = "";
			try
			{
				Class403 class403_ = new Class403(activeUnit_0.scenario_0.method_39());
				switch (activeUnit_0.vmethod_56())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					str = "DataAircraftFuel";
					break;
				case GlobalVariables.ActiveUnitType.Ship:
					str = "DataShipFuel";
					break;
				case GlobalVariables.ActiveUnitType.Submarine:
					str = "DataSubmarineFuel";
					break;
				case GlobalVariables.ActiveUnitType.Facility:
					str = "DataFacilityFuel";
					break;
				case GlobalVariables.ActiveUnitType.Weapon:
					str = "DataWeaponFuel";
					break;
				}
				string string_ = "Select * From " + str + " as theTable where theTable.ID = " + Conversions.ToString(int_0);
				DataTable dataTable = Class401.smethod_1(class403_, string_);
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					DataRow dataRow = dataTable.Rows[i];
					string_ = "Select * From DataFuel where ID = " + dataRow["ComponentID"].ToString();
					DataRow dataRow2 = Class401.smethod_1(class403_, string_).Rows[0];
					activeUnit_0.method_105(new FuelRec(Conversions.ToInteger(dataRow2["Capacity"]), Conversions.ToShort(dataRow2["Type"]))
					{
						DBID = new int?(Conversions.ToInteger(dataRow2["ID"]))
					});
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101291", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x0020A3AC File Offset: 0x002085AC
		public static int smethod_108(string string_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "SELECT ID from DataMount where Name='" + string_0 + "'";
			return Conversions.ToInteger(Class401.smethod_2(class403_, string_));
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x0020A3DC File Offset: 0x002085DC
		public static string smethod_109(int int_0, ref SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "SELECT Name from DataMount where ID='" + Conversions.ToString(int_0) + "'";
			return Class401.smethod_2(class403_, string_);
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0020A40C File Offset: 0x0020860C
		public static Mount smethod_110(int MountDBID, ref Scenario theScen, bool LoadComponents = true)
		{
			Class403 class403_ = new Class403(theScen.method_39());
			string string_ = "Select DataMount.* from DataMount WHERE DataMount.ID = " + Conversions.ToString(MountDBID);
			object objectValue = RuntimeHelpers.GetObjectValue(Class401.smethod_3(class403_, string_));
			DBFunctions.Struct38 @struct;
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue)))
			{
				if (objectValue.GetType() == typeof(DBFunctions.Struct38))
				{
					object obj = objectValue;
					@struct = ((obj != null) ? ((DBFunctions.Struct38)obj) : default(DBFunctions.Struct38));
					goto IL_39A;
				}
			}
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			if (dataTable.Rows.Count == 0)
			{
				throw new Exception1();
			}
			DataRow dataRow = dataTable.Rows[0];
			@struct = default(DBFunctions.Struct38);
			@struct.int_0 = MountDBID;
			@struct.string_0 = Conversions.ToString(dataRow["Name"]);
			@struct.armorRating_0 = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorGeneral"]);
			@struct.int_1 = Conversions.ToInteger(dataRow["ROF"]);
			@struct.int_3 = Conversions.ToInteger(dataRow["MagazineROF"]);
			@struct.int_2 = Conversions.ToInteger(dataRow["Capacity"]);
			@struct.int_4 = Conversions.ToInteger(dataRow["MagazineCapacity"]);
			@struct.bool_4 = Conversions.ToBoolean(dataRow["Autonomous"]);
			@struct.bool_0 = Conversions.ToBoolean(dataRow["Logistic"]);
			@struct.bool_2 = Conversions.ToBoolean(dataRow["CanHotReload"]);
			@struct.bool_5 = Conversions.ToBoolean(dataRow["LocalControl"]);
			@struct.bool_3 = Conversions.ToBoolean(dataRow["Trainable"]);
			@struct.float_0 = Conversions.ToSingle(dataRow["DamagePoints"]);
			@struct.bool_1 = Conversions.ToBoolean(dataRow["ReserveTarget"]);
			if (dataTable.Columns.Contains("Hypothetical"))
			{
				@struct.bool_6 = Conversions.ToBoolean(dataRow["Hypothetical"]);
			}
			if (dataTable.Columns.Contains("Cargo_Crew"))
			{
				try
				{
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Crew"])))
					{
						@struct.short_2 = Conversions.ToShort(dataRow["Cargo_Crew"]);
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Area"])))
					{
						@struct.short_1 = Conversions.ToShort(dataRow["Cargo_Area"]);
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Type"])))
					{
						@struct.cargoType_0 = (CargoType)Conversions.ToInteger(dataRow["Cargo_Type"].ToString());
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_Mass"])))
					{
						@struct.short_0 = Conversions.ToShort(dataRow["Cargo_Mass"]);
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["Cargo_ParadropCapable"])))
					{
						@struct.bool_7 = Conversions.ToBoolean(dataRow["Cargo_ParadropCapable"]);
					}
				}
				catch (Exception ex)
				{
				}
			}
			try
			{
				if (dataTable.Columns.Contains("MobileUnitCategory") && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["MobileUnitCategory"])))
				{
					@struct._MobileUnitCategory_0 = (Facility._MobileUnitCategory)Math.Round((double)Conversions.ToInteger(dataRow["MobileUnitCategory"]) / 1000.0);
				}
			}
			catch (Exception ex2)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			Class401.smethod_4(class403_, string_, @struct);
			IL_39A:
			Mount mount = null;
			mount = new Mount();
			Mount mount2 = mount;
			mount2.DBID = MountDBID;
			mount2.Name = @struct.string_0;
			mount2.armorRating_0 = @struct.armorRating_0;
			mount2.int_0 = @struct.int_1;
			mount2.method_32().int_0 = @struct.int_3;
			mount2.int_1 = @struct.int_2;
			mount2.method_32().int_1 = @struct.int_4;
			mount2.bool_11 = @struct.bool_4;
			mount2.bool_12 = @struct.bool_0;
			mount2.bool_16 = @struct.bool_2;
			mount2.bool_13 = @struct.bool_5;
			mount2.bool_14 = @struct.bool_3;
			mount2.float_2 = @struct.float_0;
			mount2.bool_15 = @struct.bool_1;
			mount2.bool_17 = @struct.bool_6;
			mount2.short_0 = @struct.short_2;
			mount2.short_1 = @struct.short_1;
			mount2.cargoType_0 = @struct.cargoType_0;
			mount2.short_2 = @struct.short_0;
			mount2.bool_18 = @struct.bool_7;
			mount2._MobileUnitCategory_0 = @struct._MobileUnitCategory_0;
			DBFunctions.smethod_64(theScen, ref mount);
			DBFunctions.smethod_111(ref mount, theScen.method_39());
			if (LoadComponents)
			{
				DBFunctions.smethod_114(ref mount, MountDBID, theScen.method_39());
				DBFunctions.smethod_113(ref mount, MountDBID, theScen);
				DBFunctions.smethod_115(ref theScen, ref mount, MountDBID);
				DBFunctions.smethod_116(ref theScen, ref mount, MountDBID);
			}
			return mount;
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0020A93C File Offset: 0x00208B3C
		public static void smethod_111(ref Mount mount_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 @class = new Class403(sqliteConnection_0);
			if (@class.method_6("MiscMountDefault"))
			{
				string string_ = "Select * from MiscMountDefault WHERE ID = " + Conversions.ToString(mount_0.DBID);
				DataTable dataTable = Class401.smethod_1(@class, string_);
				if (dataTable.Rows.Count > 0)
				{
					DataRow dataRow = dataTable.Rows[0];
					Mount mount = mount_0;
					mount.class295_0.bool_3 = Conversions.ToBoolean(dataRow["PB1"]);
					mount.class295_0.bool_11 = Conversions.ToBoolean(dataRow["PB2"]);
					mount.class295_0.bool_2 = Conversions.ToBoolean(dataRow["PMF1"]);
					mount.class295_0.bool_10 = Conversions.ToBoolean(dataRow["PMF2"]);
					mount.class295_0.bool_1 = Conversions.ToBoolean(dataRow["PMA1"]);
					mount.class295_0.bool_9 = Conversions.ToBoolean(dataRow["PMA2"]);
					mount.class295_0.bool_0 = Conversions.ToBoolean(dataRow["PS1"]);
					mount.class295_0.bool_8 = Conversions.ToBoolean(dataRow["PS2"]);
					mount.class295_0.bool_7 = Conversions.ToBoolean(dataRow["SB1"]);
					mount.class295_0.bool_15 = Conversions.ToBoolean(dataRow["SB2"]);
					mount.class295_0.bool_6 = Conversions.ToBoolean(dataRow["SMF1"]);
					mount.class295_0.bool_14 = Conversions.ToBoolean(dataRow["SMF2"]);
					mount.class295_0.bool_5 = Conversions.ToBoolean(dataRow["SMA1"]);
					mount.class295_0.bool_13 = Conversions.ToBoolean(dataRow["SMA2"]);
					mount.class295_0.bool_4 = Conversions.ToBoolean(dataRow["SS1"]);
					mount.class295_0.bool_12 = Conversions.ToBoolean(dataRow["SS2"]);
					return;
				}
			}
			else
			{
				Mount mount2 = mount_0;
				mount2.class295_0.bool_3 = true;
				mount2.class295_0.bool_11 = true;
				mount2.class295_0.bool_2 = true;
				mount2.class295_0.bool_10 = true;
				mount2.class295_0.bool_1 = true;
				mount2.class295_0.bool_9 = true;
				mount2.class295_0.bool_0 = true;
				mount2.class295_0.bool_8 = true;
				mount2.class295_0.bool_7 = true;
				mount2.class295_0.bool_15 = true;
				mount2.class295_0.bool_6 = true;
				mount2.class295_0.bool_14 = true;
				mount2.class295_0.bool_5 = true;
				mount2.class295_0.bool_13 = true;
				mount2.class295_0.bool_4 = true;
				mount2.class295_0.bool_12 = true;
			}
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0020AC10 File Offset: 0x00208E10
		public static void smethod_112(ref Scenario scenario_0, ref ActiveUnit activeUnit_0, int int_0)
		{
			string text = "";
			Class403 class403_ = new Class403(scenario_0.method_39());
			if (activeUnit_0.bool_3)
			{
				text = "DataAircraftMounts";
			}
			else if (activeUnit_0.bool_2)
			{
				text = "DataWeaponMounts";
			}
			else if (activeUnit_0.bool_6)
			{
				text = "DataShipMounts";
			}
			else if (activeUnit_0.bool_5)
			{
				text = "DataSubmarineMounts";
			}
			else if (activeUnit_0.bool_8)
			{
				text = "DataFacilityMounts";
			}
			else if (activeUnit_0.method_1())
			{
				text = "DataSatelliteMounts";
			}
			string string_ = string.Concat(new string[]
			{
				"SELECT DataMount.*, theTable.PB1, theTable.PB2, theTable.PMF1, theTable.PMF2, theTable.PMA1, theTable.PMA2, theTable.PS1, theTable.PS2, theTable.SB1, theTable.SB2, theTable.SMF1, theTable.SMF2, theTable.SMA1, theTable.SMA2, theTable.SS1, theTable.SS2 FROM DataMount, ",
				text,
				" AS theTable WHERE DataMount.ID = theTable.ComponentID And theTable.ID = ",
				Conversions.ToString(int_0),
				" ORDER BY DataMount.Name ASC"
			});
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				Mount mount = new Mount();
				Mount mount2 = mount;
				mount2.method_19(activeUnit_0);
				mount2.DBID = Conversions.ToInteger(dataRow["ID"]);
				mount2.Name = Conversions.ToString(dataRow["Name"]);
				mount2.armorRating_0 = (GlobalVariables.ArmorRating)Conversions.ToShort(dataRow["ArmorGeneral"]);
				mount2.int_0 = Conversions.ToInteger(dataRow["ROF"]);
				mount2.method_32().int_0 = Conversions.ToInteger(dataRow["MagazineROF"]);
				mount2.int_1 = Conversions.ToInteger(dataRow["Capacity"]);
				mount2.method_32().int_1 = Conversions.ToInteger(dataRow["MagazineCapacity"]);
				mount2.bool_11 = Conversions.ToBoolean(dataRow["Autonomous"]);
				mount2.bool_12 = Conversions.ToBoolean(dataRow["Logistic"]);
				mount2.bool_16 = Conversions.ToBoolean(dataRow["CanHotReload"]);
				mount2.bool_13 = Conversions.ToBoolean(dataRow["LocalControl"]);
				mount2.bool_14 = Conversions.ToBoolean(dataRow["Trainable"]);
				mount2.float_2 = Conversions.ToSingle(dataRow["DamagePoints"]);
				mount2.bool_15 = Conversions.ToBoolean(dataRow["ReserveTarget"]);
				mount2.class295_0.bool_3 = Conversions.ToBoolean(dataRow["PB1"]);
				mount2.class295_0.bool_11 = Conversions.ToBoolean(dataRow["PB2"]);
				mount2.class295_0.bool_2 = Conversions.ToBoolean(dataRow["PMF1"]);
				mount2.class295_0.bool_10 = Conversions.ToBoolean(dataRow["PMF2"]);
				mount2.class295_0.bool_1 = Conversions.ToBoolean(dataRow["PMA1"]);
				mount2.class295_0.bool_9 = Conversions.ToBoolean(dataRow["PMA2"]);
				mount2.class295_0.bool_0 = Conversions.ToBoolean(dataRow["PS1"]);
				mount2.class295_0.bool_8 = Conversions.ToBoolean(dataRow["PS2"]);
				mount2.class295_0.bool_7 = Conversions.ToBoolean(dataRow["SB1"]);
				mount2.class295_0.bool_15 = Conversions.ToBoolean(dataRow["SB2"]);
				mount2.class295_0.bool_6 = Conversions.ToBoolean(dataRow["SMF1"]);
				mount2.class295_0.bool_14 = Conversions.ToBoolean(dataRow["SMF2"]);
				mount2.class295_0.bool_5 = Conversions.ToBoolean(dataRow["SMA1"]);
				mount2.class295_0.bool_13 = Conversions.ToBoolean(dataRow["SMA2"]);
				mount2.class295_0.bool_4 = Conversions.ToBoolean(dataRow["SS1"]);
				mount2.class295_0.bool_12 = Conversions.ToBoolean(dataRow["SS2"]);
				DBFunctions.smethod_114(ref mount, Conversions.ToInteger(dataRow["ID"]), scenario_0.method_39());
				DBFunctions.smethod_113(ref mount, Conversions.ToInteger(dataRow["ID"]), scenario_0);
				DBFunctions.smethod_115(ref scenario_0, ref mount, Conversions.ToInteger(dataRow["ID"]));
				DBFunctions.smethod_116(ref scenario_0, ref mount, Conversions.ToInteger(dataRow["ID"]));
				DBFunctions.smethod_64(scenario_0, ref mount);
				activeUnit_0.vmethod_51().method_4(mount);
			}
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0020B0A0 File Offset: 0x002092A0
		public static void smethod_113(ref Mount mount_0, int int_0, Scenario scenario_0)
		{
			Class403 class403_ = new Class403(scenario_0.method_39());
			string string_ = "Select DataComm.ID as CommID, DataComm.Name, DataComm.Type, DataComm.Range, DataComm.Channels, DataComm.IsOptional, theTable.* from DataComm, DataMountComms as theTable where DataComm.ID = theTable.ComponentID and theTable.ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				CommDevice commDevice_ = new CommDevice(mount_0.method_18(), scenario_0, Conversions.ToInteger(dataRow["CommID"]), Conversions.ToString(dataRow["Name"]), (CommDevice.CommLinkType)Conversions.ToInteger(dataRow["Type"]), Conversions.ToDouble(dataRow["Range"]), Conversions.ToInteger(dataRow["Channels"]), Conversions.ToBoolean(dataRow["IsOptional"]));
				Class429.smethod_9(ref mount_0.commDevice_0, commDevice_);
			}
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x0020B180 File Offset: 0x00209380
		public static void smethod_114(ref Mount mount_0, int int_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "SELECT S.ID from DataMountSensors as MS, DataSensor as S where S.ID = MS.ComponentID and MS.ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			if (!Information.IsNothing(mount_0.method_18()))
			{
				mount_0.method_18();
			}
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Sensor sensor = DBFunctions.smethod_97(Conversions.ToInteger(dataTable.Rows[i]["ID"]), ref sqliteConnection_0);
				sensor.method_19(mount_0.method_18());
				sensor.class295_0.bool_3 = mount_0.class295_0.bool_3;
				sensor.class295_0.bool_1 = mount_0.class295_0.bool_1;
				sensor.class295_0.bool_2 = mount_0.class295_0.bool_2;
				sensor.class295_0.bool_0 = mount_0.class295_0.bool_0;
				sensor.class295_0.bool_7 = mount_0.class295_0.bool_7;
				sensor.class295_0.bool_5 = mount_0.class295_0.bool_5;
				sensor.class295_0.bool_6 = mount_0.class295_0.bool_6;
				sensor.class295_0.bool_4 = mount_0.class295_0.bool_4;
				sensor.class295_0.bool_11 = mount_0.class295_0.bool_11;
				sensor.class295_0.bool_9 = mount_0.class295_0.bool_9;
				sensor.class295_0.bool_10 = mount_0.class295_0.bool_10;
				sensor.class295_0.bool_8 = mount_0.class295_0.bool_8;
				sensor.class295_0.bool_15 = mount_0.class295_0.bool_15;
				sensor.class295_0.bool_13 = mount_0.class295_0.bool_13;
				sensor.class295_0.bool_14 = mount_0.class295_0.bool_14;
				sensor.class295_0.bool_12 = mount_0.class295_0.bool_12;
				sensor.class295_1.bool_3 = mount_0.class295_0.bool_3;
				sensor.class295_1.bool_1 = mount_0.class295_0.bool_1;
				sensor.class295_1.bool_2 = mount_0.class295_0.bool_2;
				sensor.class295_1.bool_0 = mount_0.class295_0.bool_0;
				sensor.class295_1.bool_7 = mount_0.class295_0.bool_7;
				sensor.class295_1.bool_5 = mount_0.class295_0.bool_5;
				sensor.class295_1.bool_6 = mount_0.class295_0.bool_6;
				sensor.class295_1.bool_4 = mount_0.class295_0.bool_4;
				sensor.class295_1.bool_11 = mount_0.class295_0.bool_11;
				sensor.class295_1.bool_9 = mount_0.class295_0.bool_9;
				sensor.class295_1.bool_10 = mount_0.class295_0.bool_10;
				sensor.class295_1.bool_8 = mount_0.class295_0.bool_8;
				sensor.class295_1.bool_15 = mount_0.class295_0.bool_15;
				sensor.class295_1.bool_13 = mount_0.class295_0.bool_13;
				sensor.class295_1.bool_14 = mount_0.class295_0.bool_14;
				sensor.class295_1.bool_12 = mount_0.class295_0.bool_12;
				mount_0.method_39(sensor);
			}
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x0020B51C File Offset: 0x0020971C
		public static void smethod_115(ref Scenario scenario_0, ref Mount mount_0, int int_0)
		{
			Class403 class403_ = new Class403(scenario_0.method_39());
			string string_ = "SELECT DataWeaponRecord.* FROM DataMountWeapons, DataWeaponRecord, DataWeapon WHERE DataMountWeapons.ComponentID = DataWeaponRecord.ID And DataWeapon.ID = DataWeaponRecord.ComponentID And DataMountWeapons.ID = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Type, DataWeapon.Name ASC";
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				WeaponRec gparam_ = new WeaponRec(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), Conversions.ToInteger(dataRow["DefaultLoad"]), Conversions.ToInteger(dataRow["MaxLoad"]), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Multiple"]), false, false);
				mount_0.vmethod_10().method_4(gparam_);
			}
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0020B5EC File Offset: 0x002097EC
		public static void smethod_116(ref Scenario scenario_0, ref Mount mount_0, int int_0)
		{
			Class403 class403_ = new Class403(scenario_0.method_39());
			string string_ = "SELECT DataWeaponRecord.*, DataMountMagazineWeapons.ComponentNumber FROM DataMountMagazineWeapons, DataWeaponRecord, DataWeapon WHERE DataMountMagazineWeapons.ComponentID = DataWeaponRecord.ID And DataWeapon.ID = DataWeaponRecord.ComponentID And DataMountMagazineWeapons.ID  = " + Conversions.ToString(int_0) + " ORDER BY DataWeapon.Type, DataWeapon.Name ASC";
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				WeaponRec gparam_ = new WeaponRec(ref scenario_0, Conversions.ToInteger(dataRow["ComponentID"]), Conversions.ToInteger(dataRow["DefaultLoad"]), Conversions.ToInteger(dataRow["MaxLoad"]), Conversions.ToInteger(dataRow["ROF"]), Conversions.ToInteger(dataRow["Multiple"]), false, false);
				mount_0.method_32().vmethod_10().method_4(gparam_);
			}
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0020B6C4 File Offset: 0x002098C4
		public static void smethod_117(ref Class394 class394_0, int int_0, ref SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string string_ = "SELECT CodeID from DataWeaponTargets where ID = " + Conversions.ToString(int_0);
			DataTable dataTable = Class401.smethod_1(class403_, string_);
			int num = dataTable.Rows.Count - 1;
			int i = 0;
			while (i <= num)
			{
				int num2 = Conversions.ToInteger(dataTable.Rows[i]["CodeID"]);
				if (num2 <= 4001)
				{
					if (num2 <= 2004)
					{
						switch (num2)
						{
						case 1001:
							class394_0.bool_2 = true;
							break;
						case 1002:
							class394_0.bool_11 = true;
							break;
						case 1003:
							class394_0.bool_3 = true;
							break;
						case 1004:
							class394_0.bool_4 = true;
							break;
						case 1005:
							class394_0.bool_17 = true;
							break;
						default:
							switch (num2)
							{
							case 2001:
								class394_0.bool_0 = true;
								break;
							case 2002:
								class394_0.bool_1 = true;
								break;
							case 2003:
								class394_0.bool_10 = true;
								break;
							case 2004:
								class394_0.bool_9 = true;
								break;
							default:
								goto IL_1C4;
							}
							break;
						}
					}
					else
					{
						switch (num2)
						{
						case 3001:
							class394_0.bool_7 = true;
							break;
						case 3002:
							class394_0.bool_8 = true;
							break;
						case 3003:
							class394_0.bool_6 = true;
							break;
						case 3004:
							class394_0.bool_5 = true;
							break;
						default:
							if (num2 != 4001)
							{
								goto IL_1C4;
							}
							class394_0.bool_12 = true;
							break;
						}
					}
				}
				else if (num2 <= 5001)
				{
					if (num2 != 4002)
					{
						if (num2 != 5001)
						{
							goto IL_1C4;
						}
						class394_0.bool_14 = true;
					}
					else
					{
						class394_0.bool_13 = true;
					}
				}
				else if (num2 != 6001)
				{
					if (num2 != 9001)
					{
						goto IL_1C4;
					}
					class394_0.bool_16 = true;
				}
				else
				{
					class394_0.bool_15 = true;
				}
				IL_1E4:
				i++;
				continue;
				IL_1C4:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					goto IL_1E4;
				}
				goto IL_1E4;
			}
		}

		// Token: 0x040018F6 RID: 6390
		private static Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

		// Token: 0x040018F7 RID: 6391
		private static Dictionary<string, bool> dictionary_1 = new Dictionary<string, bool>();

		// Token: 0x0200039F RID: 927
		private struct Struct37
		{
			// Token: 0x040018F8 RID: 6392
			public PlatformComponent.Class295 class295_0;

			// Token: 0x040018F9 RID: 6393
			public PlatformComponent.Class295 class295_1;
		}

		// Token: 0x020003A0 RID: 928
		private struct Struct38
		{
			// Token: 0x040018FA RID: 6394
			public int int_0;

			// Token: 0x040018FB RID: 6395
			public string string_0;

			// Token: 0x040018FC RID: 6396
			public GlobalVariables.ArmorRating armorRating_0;

			// Token: 0x040018FD RID: 6397
			public int int_1;

			// Token: 0x040018FE RID: 6398
			public int int_2;

			// Token: 0x040018FF RID: 6399
			public int int_3;

			// Token: 0x04001900 RID: 6400
			public int int_4;

			// Token: 0x04001901 RID: 6401
			public float float_0;

			// Token: 0x04001902 RID: 6402
			public bool bool_0;

			// Token: 0x04001903 RID: 6403
			public bool bool_1;

			// Token: 0x04001904 RID: 6404
			public bool bool_2;

			// Token: 0x04001905 RID: 6405
			public float float_1;

			// Token: 0x04001906 RID: 6406
			public bool bool_3;

			// Token: 0x04001907 RID: 6407
			public bool bool_4;

			// Token: 0x04001908 RID: 6408
			public bool bool_5;

			// Token: 0x04001909 RID: 6409
			public bool bool_6;

			// Token: 0x0400190A RID: 6410
			public CargoType cargoType_0;

			// Token: 0x0400190B RID: 6411
			public short short_0;

			// Token: 0x0400190C RID: 6412
			public short short_1;

			// Token: 0x0400190D RID: 6413
			public short short_2;

			// Token: 0x0400190E RID: 6414
			public bool bool_7;

			// Token: 0x0400190F RID: 6415
			public Facility._MobileUnitCategory _MobileUnitCategory_0;
		}
	}
}
