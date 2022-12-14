using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns12;
using ns13;

namespace Command_Core
{
	// Token: 0x020003ED RID: 1005
	[StandardModule]
	public sealed class Misc
	{
		// Token: 0x06001E36 RID: 7734 RVA: 0x00228034 File Offset: 0x00226234
		public static string smethod_0(string string_0)
		{
			string text = Path.GetExtension(string_0);
			if (text.Length == 4)
			{
				text = Conversions.ToString(text[0]) + Conversions.ToString(text[1]) + Conversions.ToString(text[text.Length - 1]) + "w";
			}
			else
			{
				text += "w";
			}
			string text2 = Path.ChangeExtension(string_0, text);
			string result;
			if (!File.Exists(text2))
			{
				result = null;
			}
			else
			{
				string text3 = File.ReadAllText(text2);
				text3 = text3.Replace(",", ".");
				File.WriteAllText(text2, text3);
				result = text2;
			}
			return result;
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x002280CC File Offset: 0x002262CC
		public static void smethod_1(string string_0, string string_1, bool bool_0)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			if (!directoryInfo.Exists)
			{
				throw new DirectoryNotFoundException(Convert.ToString("Source directory does not exist or could not be found: ") + string_0);
			}
			if (!Directory.Exists(string_1))
			{
				Directory.CreateDirectory(string_1);
			}
			foreach (FileInfo fileInfo in directoryInfo.GetFiles())
			{
				string destFileName = Path.Combine(string_1, fileInfo.Name);
				fileInfo.CopyTo(destFileName, true);
			}
			if (bool_0)
			{
				foreach (DirectoryInfo directoryInfo2 in directories)
				{
					string string_2 = Path.Combine(string_1, directoryInfo2.Name);
					Misc.smethod_1(directoryInfo2.FullName, string_2, bool_0);
				}
			}
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00228184 File Offset: 0x00226384
		public static void smethod_2(string string_0)
		{
			if (!Directory.Exists(string_0))
			{
				Directory.CreateDirectory(string_0);
				return;
			}
			try
			{
				foreach (string path in Directory.EnumerateDirectories(string_0))
				{
					Directory.Delete(path, true);
				}
			}
			finally
			{
				IEnumerator<string> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			foreach (string text in Directory.GetFiles(string_0))
			{
				if (!text.EndsWith("\\instance"))
				{
					try
					{
						File.Delete(text);
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 200574: Could not delete file " + text, ex.Message);
						bool isAttached = Debugger.IsAttached;
					}
				}
			}
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00228250 File Offset: 0x00226450
		public static string smethod_3(string string_0)
		{
			string @string = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());
			if (string_0.StartsWith(@string))
			{
				string_0 = string_0.Remove(0, @string.Length);
			}
			if (!string_0.StartsWith("<"))
			{
				string_0 = "<" + string_0;
			}
			if (string_0.StartsWith("<?xml"))
			{
				string_0 = Strings.Right(string_0, Strings.Len(string_0) - Strings.InStr(string_0, ">", CompareMethod.Binary));
			}
			return string_0;
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x002282D0 File Offset: 0x002264D0
		public static byte[] smethod_4(byte[] byte_0)
		{
			int num = byte_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(Conversions.ToString(Convert.ToChar(byte_0[i])), ">", false) == 0)
				{
					int num2 = i;
					IL_36:
					byte[] array = new byte[byte_0.Length - (num2 + 2) + 1];
					byte[] result;
					try
					{
						Array.Copy(byte_0, num2 + 1, array, 0, array.Length);
						byte_0 = array;
						result = byte_0;
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 101335", "");
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						result = null;
					}
					return result;
				}
			}
			goto IL_36;
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00228384 File Offset: 0x00226584
		public static string smethod_5(string string_0)
		{
			StringBuilder stringBuilder = new StringBuilder(string_0.Length);
			foreach (char c in string_0)
			{
				if (Misc.smethod_7((int)c))
				{
					stringBuilder.Append(c);
				}
			}
			string_0 = stringBuilder.ToString();
			return string_0;
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x002283D4 File Offset: 0x002265D4
		public static byte[] smethod_6(byte[] byte_0)
		{
			Misc.Class438 @class = new Misc.Class438();
			@class.byte_0 = byte_0;
			int num = @class.byte_0.Length;
			Parallel.For(0, num - 1, new Action<int>(@class.method_0));
			return @class.byte_0;
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00228414 File Offset: 0x00226614
		private static bool smethod_7(int int_0)
		{
			return int_0 == 9 || int_0 == 10 || int_0 == 13 || (int_0 >= 32 && int_0 <= 55295) || (int_0 >= 57344 && int_0 <= 65533) || (int_0 >= 65536 && int_0 <= 1114111);
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00228464 File Offset: 0x00226664
		public static string smethod_8(double double_1, double double_2)
		{
			string text;
			if (double_1 > 0.0)
			{
				text = "N";
			}
			else
			{
				text = "S";
				double_1 = -double_1;
			}
			string text2;
			if (double_2 > 0.0)
			{
				text2 = "E";
			}
			else
			{
				text2 = "W";
				double_2 = -double_2;
			}
			return string.Concat(new string[]
			{
				text,
				Class437.smethod_9(Class437.smethod_8(Math.Round(double_1, 4))),
				", ",
				text2,
				Class437.smethod_9(Class437.smethod_8(Math.Round(double_2, 4)))
			});
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x002284F0 File Offset: 0x002266F0
		public static string smethod_9(string string_0)
		{
			int num = Strings.InStr(string_0, "|", CompareMethod.Binary);
			string result;
			if (num == 0)
			{
				result = string_0;
			}
			else
			{
				result = Strings.Left(string_0, num - 1);
			}
			return result;
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x0022851C File Offset: 0x0022671C
		public static DateTime smethod_10(DateTime dateTime_0, double double_1, bool bool_0, string string_0, string string_1)
		{
			DateTime result;
			try
			{
				DateTime dateTime = dateTime_0.AddHours(Math.Floor((double_1 + 7.5) / 15.0));
				if (bool_0)
				{
					List<string> list = Enumerable.ToList<string>(string_0.Split(new char[]
					{
						'.'
					}));
					List<string> list2 = Enumerable.ToList<string>(string_1.Split(new char[]
					{
						'.'
					}));
					if ((Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1]) & Versioned.IsNumeric(list2[0]) & Versioned.IsNumeric(list2[1])) && ((double)dateTime_0.Day >= Conversions.ToDouble(list[0]) & (double)dateTime_0.Month >= Conversions.ToDouble(list[1])) && ((double)dateTime_0.Day <= Conversions.ToDouble(list2[0]) & (double)dateTime_0.Month <= Conversions.ToDouble(list2[1])))
					{
						dateTime = dateTime.AddHours(1.0);
					}
				}
				result = dateTime;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101099", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = default(DateTime);
			}
			return result;
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00228694 File Offset: 0x00226894
		public static string smethod_11(long seconds, Aircraft_AirOps.Enum44 Maintenance = Aircraft_AirOps.Enum44.const_0, bool ReturnNo = false, bool ReturnZero = false)
		{
			string result;
			if (seconds > 2147483647L)
			{
				result = "Very long";
			}
			else
			{
				TimeSpan timeSpan;
				try
				{
					timeSpan = TimeSpan.FromSeconds((double)seconds);
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200091", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					return "N/A";
				}
				int num = (int)Math.Floor((double)timeSpan.Days / 7.0);
				int num2 = (int)Math.Floor((double)timeSpan.Days / 30.0);
				int num3 = (int)Math.Floor((double)timeSpan.Days / 365.0);
				if (Maintenance == Aircraft_AirOps.Enum44.const_2)
				{
					result = "Unavailable";
				}
				else if (num3 > 0)
				{
					result = Conversions.ToString(num3) + " y" + ((num2 - num3 * 12 == 0) ? "" : (" " + Conversions.ToString(num2 - num3 * 12) + " mon")).ToString();
				}
				else if (num2 > 0)
				{
					result = Conversions.ToString(num2) + " mon" + ((num - num2 * 4 == 0) ? "" : (" " + Conversions.ToString(num - num2 * 4) + " w")).ToString();
				}
				else if (num > 0)
				{
					result = Conversions.ToString(num) + " w" + ((timeSpan.Days - num * 7 == 0) ? "" : (" " + Conversions.ToString(timeSpan.Days - num * 7) + " d")).ToString();
				}
				else if (timeSpan.Days > 0)
				{
					result = Conversions.ToString(timeSpan.Days) + " d" + ((timeSpan.Hours == 0) ? "" : (" " + Conversions.ToString(timeSpan.Hours) + " hr")).ToString();
				}
				else if (timeSpan.Hours > 0)
				{
					result = Conversions.ToString(timeSpan.Hours) + " hr" + ((timeSpan.Minutes == 0) ? "" : (" " + Conversions.ToString(timeSpan.Minutes) + " min")).ToString();
				}
				else if (timeSpan.Minutes > 0)
				{
					result = Conversions.ToString(timeSpan.Minutes) + " min" + ((timeSpan.Seconds == 0) ? "" : (" " + Conversions.ToString(timeSpan.Seconds) + " sec")).ToString();
				}
				else if (timeSpan.Seconds > 0)
				{
					result = Conversions.ToString(timeSpan.Seconds) + " sec";
				}
				else if (timeSpan.Seconds == 0)
				{
					if (ReturnNo)
					{
						result = "No";
					}
					else if (ReturnZero)
					{
						result = "0";
					}
					else
					{
						result = "Ready";
					}
				}
				else
				{
					result = "Error!";
				}
			}
			return result;
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x002289A8 File Offset: 0x00226BA8
		public static string smethod_12(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
			int num = byte_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				stringBuilder.Append(byte_0[i].ToString("X2"));
			}
			return stringBuilder.ToString().ToLower();
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x002289F8 File Offset: 0x00226BF8
		public static bool smethod_13(ConcurrentDictionary<int, bool> concurrentDictionary_0)
		{
			return !concurrentDictionary_0.GetEnumerator().MoveNext();
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00228A1C File Offset: 0x00226C1C
		public static bool smethod_14(ConcurrentDictionary<Tuple<int, string>, string> concurrentDictionary_0)
		{
			return !concurrentDictionary_0.GetEnumerator().MoveNext();
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00228A40 File Offset: 0x00226C40
		public static bool smethod_15(ConcurrentDictionary<string, Contact> concurrentDictionary_0)
		{
			return !concurrentDictionary_0.GetEnumerator().MoveNext();
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x00228A64 File Offset: 0x00226C64
		public static bool smethod_16(ConcurrentDictionary<long, LoggedMessage> concurrentDictionary_0)
		{
			return !concurrentDictionary_0.GetEnumerator().MoveNext();
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00228A88 File Offset: 0x00226C88
		public static bool smethod_17(Sensor.Sensor_Type sensor_Type_0)
		{
			if (sensor_Type_0 <= Sensor.Sensor_Type.LaserRangefinder)
			{
				if (sensor_Type_0 <= Sensor.Sensor_Type.ECM)
				{
					if (sensor_Type_0 == Sensor.Sensor_Type.Radar || sensor_Type_0 == Sensor.Sensor_Type.ECM)
					{
						goto IL_6C;
					}
				}
				else if (sensor_Type_0 == Sensor.Sensor_Type.LaserDesignator || sensor_Type_0 == Sensor.Sensor_Type.LaserRangefinder)
				{
					goto IL_6C;
				}
			}
			else if (sensor_Type_0 <= Sensor.Sensor_Type.TowedArray_ActiveOnly)
			{
				if (sensor_Type_0 - Sensor.Sensor_Type.HullSonar_ActivePassive <= 1 || sensor_Type_0 - Sensor.Sensor_Type.TowedArray_ActivePassive <= 1)
				{
					goto IL_6C;
				}
			}
			else if (sensor_Type_0 - Sensor.Sensor_Type.VDS_ActivePassive <= 1 || sensor_Type_0 - Sensor.Sensor_Type.DippingSonar_ActivePassive <= 1)
			{
				goto IL_6C;
			}
			return false;
			IL_6C:
			return true;
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00228B04 File Offset: 0x00226D04
		public static void smethod_18<T>(IList<T> ilist_0)
		{
			RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
			int i = ilist_0.Count;
			while (i > 1)
			{
				byte[] array = new byte[1];
				do
				{
					rngcryptoServiceProvider.GetBytes(array);
				}
				while ((double)array[0] >= (double)i * (255.0 / (double)i));
				int index = (int)array[0] % i;
				i--;
				T value = ilist_0[index];
				ilist_0[index] = ilist_0[i];
				ilist_0[i] = value;
			}
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00228B74 File Offset: 0x00226D74
		public static string smethod_19(Aircraft.Enum38 enum38_0)
		{
			string result;
			switch (enum38_0)
			{
			case Aircraft.Enum38.const_1:
				result = "Excellent";
				break;
			case Aircraft.Enum38.const_2:
				result = "Average";
				break;
			case Aircraft.Enum38.const_3:
				result = "Poor";
				break;
			default:
				result = "Error!";
				break;
			}
			return result;
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00228BB8 File Offset: 0x00226DB8
		public static string smethod_20(GlobalVariables.ProficiencyLevel proficiencyLevel_0)
		{
			string result;
			switch (proficiencyLevel_0)
			{
			case GlobalVariables.ProficiencyLevel.Novice:
				result = "Novice";
				break;
			case GlobalVariables.ProficiencyLevel.Cadet:
				result = "Cadet";
				break;
			case GlobalVariables.ProficiencyLevel.Regular:
				result = "Regular";
				break;
			case GlobalVariables.ProficiencyLevel.Veteran:
				result = "Veteran";
				break;
			case GlobalVariables.ProficiencyLevel.Ace:
				result = "Ace";
				break;
			default:
				result = "Error!";
				break;
			}
			return result;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00228C10 File Offset: 0x00226E10
		public static bool smethod_21(IEnumerable<Weapon> ienumerable_0)
		{
			bool result;
			try
			{
				try
				{
					IEnumerator<Weapon> enumerator = ienumerable_0.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.method_191())
						{
							return true;
						}
					}
				}
				finally
				{
					IEnumerator<Weapon> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101097", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00228CA4 File Offset: 0x00226EA4
		public static string smethod_22(LoggedMessage.MessageType messageType_0)
		{
			switch (messageType_0)
			{
			case LoggedMessage.MessageType.NewContact:
				return "New Contact";
			case LoggedMessage.MessageType.ContactChange:
				return "Contact change";
			case LoggedMessage.MessageType.WeaponEndgame:
				return "Weapon Endgame Calculations";
			case LoggedMessage.MessageType.WeaponDamage:
				return "Weapon Damage";
			case LoggedMessage.MessageType.AirOps:
				return "Air Operations";
			case LoggedMessage.MessageType.UnitLost:
				return "Unit Lost";
			case LoggedMessage.MessageType.UnitDamage:
				return "Unit Damage";
			case LoggedMessage.MessageType.PointDefence:
				return "Point Defence";
			case LoggedMessage.MessageType.UI:
				return "User Interface";
			case LoggedMessage.MessageType.WeaponLogic:
				return "Weapon Logic";
			case LoggedMessage.MessageType.UnitAI:
				return "Unit AI";
			case LoggedMessage.MessageType.EventEngine:
				return "Scenario Events";
			case LoggedMessage.MessageType.NewWeaponContact:
				return "New Weapon Contact";
			case LoggedMessage.MessageType.DockingOps:
				return "Docking Operations";
			case LoggedMessage.MessageType.SpecialMessage:
				return "Special Messages";
			case LoggedMessage.MessageType.NewMineContact:
				return "New Mine Contact";
			case LoggedMessage.MessageType.CommsIsolatedMessage:
				return "Comms-isolated Message";
			case LoggedMessage.MessageType.NewAirContact:
				return "New Air Contact";
			case LoggedMessage.MessageType.NewSurfaceContact:
				return "New Surface Contact";
			case LoggedMessage.MessageType.NewUnderwaterContact:
				return "New Underwater Contact";
			case LoggedMessage.MessageType.NewGroundContact:
				return "New Ground Contact";
			case LoggedMessage.MessageType.UnguidedWeaponModifiers:
				return "Unguided Weapon Accuracy Modifiers";
			}
			return messageType_0.ToString();
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x0000EDEA File Offset: 0x0000CFEA
		public static string smethod_23(Satellite._SatelliteType _SatelliteType_0, SQLiteConnection sqliteConnection_0)
		{
			return Class401.smethod_2(new Class403(sqliteConnection_0), "SELECT ST.Description from EnumSatelliteType as ST where ST.ID = " + Conversions.ToString((int)_SatelliteType_0));
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x0000EE07 File Offset: 0x0000D007
		public static string smethod_24(Satellite._SatelliteCategory _SatelliteCategory_0, SQLiteConnection sqliteConnection_0)
		{
			return Class401.smethod_2(new Class403(sqliteConnection_0), "SELECT SC.Description from EnumSatelliteCategory as SC where SC.ID = " + Conversions.ToString((int)_SatelliteCategory_0));
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x0000EE24 File Offset: 0x0000D024
		public static string smethod_25(Engine.Enum112 enum112_0, SQLiteConnection sqliteConnection_0)
		{
			return Class401.smethod_2(new Class403(sqliteConnection_0), "SELECT PT.Description from EnumPropulsionType as PT where PT.ID = " + Conversions.ToString((int)enum112_0));
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x0000EE41 File Offset: 0x0000D041
		public static string smethod_26(FuelRec._FuelType _FuelType_0, SQLiteConnection sqliteConnection_0)
		{
			return Class401.smethod_2(new Class403(sqliteConnection_0), "SELECT FT.Description from EnumFuelType as FT where FT.ID = " + Conversions.ToString((int)_FuelType_0));
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x0000EE5E File Offset: 0x0000D05E
		public static string smethod_27(Facility._FacilityCategory _FacilityCategory_0, SQLiteConnection sqliteConnection_0)
		{
			return Class401.smethod_2(new Class403(sqliteConnection_0), "SELECT FC.Description from EnumFacilityCategory as FC where FC.ID = " + Conversions.ToString((int)_FacilityCategory_0));
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00228DF0 File Offset: 0x00226FF0
		public static string smethod_28(Loadout._LoadoutDayNight _LoadoutDayNight_0)
		{
			string result;
			if (_LoadoutDayNight_0 != Loadout._LoadoutDayNight.None)
			{
				switch (_LoadoutDayNight_0)
				{
				case Loadout._LoadoutDayNight.DayNight:
					result = "Day/Night";
					break;
				case Loadout._LoadoutDayNight.NightOnly:
					result = "Night only";
					break;
				case Loadout._LoadoutDayNight.DayOnly:
					result = "Day only";
					break;
				default:
					result = "Error!";
					break;
				}
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00228E48 File Offset: 0x00227048
		public static string smethod_29(Loadout._LoadoutWeather _LoadoutWeather_0)
		{
			string result;
			if (_LoadoutWeather_0 != Loadout._LoadoutWeather.None)
			{
				switch (_LoadoutWeather_0)
				{
				case Loadout._LoadoutWeather.AllWeather:
					result = "All-Weather";
					break;
				case Loadout._LoadoutWeather.LimitedAllWeather:
					result = "Limited All-Weather";
					break;
				case Loadout._LoadoutWeather.ClearWeather:
					result = "Clear-Weather";
					break;
				default:
					result = "Error!";
					break;
				}
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x0000EE7B File Offset: 0x0000D07B
		public static string smethod_30(Loadout.LoadoutRole loadoutRole_0, SQLiteConnection sqliteConnection_0)
		{
			return Class401.smethod_2(new Class403(sqliteConnection_0), "SELECT LR.Description from EnumLoadoutRole as LR where LR.ID = " + Conversions.ToString((int)loadoutRole_0));
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x0000EE98 File Offset: 0x0000D098
		public static string smethod_31(Aircraft._AircraftType _AircraftType_0, SQLiteConnection sqliteConnection_0)
		{
			return Class401.smethod_2(new Class403(sqliteConnection_0), "SELECT AT.Description from EnumAircraftType as AT where AT.ID = " + Conversions.ToString((int)_AircraftType_0));
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x0000EEB5 File Offset: 0x0000D0B5
		public static string smethod_32(Aircraft.Enum40 enum40_0, SQLiteConnection sqliteConnection_0)
		{
			return Class401.smethod_2(new Class403(sqliteConnection_0), "SELECT AC.Description from EnumAircraftCategory as AC where AC.ID = " + Conversions.ToString((int)enum40_0));
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00228EA0 File Offset: 0x002270A0
		public static string smethod_33(GlobalVariables.AircraftSizeClass aircraftSizeClass_0, SQLiteConnection sqliteConnection_0)
		{
			string result;
			switch (aircraftSizeClass_0)
			{
			case GlobalVariables.AircraftSizeClass.None:
				result = "None";
				break;
			case GlobalVariables.AircraftSizeClass.Small:
				result = "Small Aircraft (0-12m Long)";
				break;
			case GlobalVariables.AircraftSizeClass.Medium:
				result = "Medium Aircraft (12.1-18m Long)";
				break;
			case GlobalVariables.AircraftSizeClass.Large:
				result = "Large Aircraft (18.1-26m Long)";
				break;
			case GlobalVariables.AircraftSizeClass.VLarge:
				result = "Very Large Aircraft (26.1-75m Long)";
				break;
			default:
				result = aircraftSizeClass_0.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x0000EED2 File Offset: 0x0000D0D2
		public static string smethod_34(Ship._ShipType _ShipType_0, SQLiteConnection sqliteConnection_0)
		{
			return Class401.smethod_2(new Class403(sqliteConnection_0), "SELECT ST.Description from EnumShipType as ST where ST.ID = " + Conversions.ToString((int)_ShipType_0));
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x0000EEEF File Offset: 0x0000D0EF
		public static string smethod_35(Ship.Enum118 enum118_0, SQLiteConnection sqliteConnection_0)
		{
			return Class401.smethod_2(new Class403(sqliteConnection_0), "SELECT ST.Description from EnumShipCategory as ST where ST.ID = " + Conversions.ToString((int)enum118_0));
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x0000EF0C File Offset: 0x0000D10C
		public static string smethod_36(Submarine._SubmarineType _SubmarineType_0, SQLiteConnection sqliteConnection_0)
		{
			return Class401.smethod_2(new Class403(sqliteConnection_0), "SELECT ST.Description from EnumSubmarineType as ST where ST.ID = " + Conversions.ToString((int)_SubmarineType_0));
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x0000EF29 File Offset: 0x0000D129
		public static string smethod_37(Submarine.Enum120 enum120_0, SQLiteConnection sqliteConnection_0)
		{
			return Class401.smethod_2(new Class403(sqliteConnection_0), "SELECT ST.Description from EnumSubmarineCategory as ST where ST.ID = " + Conversions.ToString((int)enum120_0));
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x00228F00 File Offset: 0x00227100
		public static string smethod_38(GlobalVariables.ArmorRating armorRating_0, SQLiteConnection sqliteConnection_0)
		{
			Class403 class403_ = new Class403(sqliteConnection_0);
			string result;
			if (armorRating_0 == GlobalVariables.ArmorRating.None)
			{
				result = "None";
			}
			else
			{
				result = Class401.smethod_2(class403_, "SELECT AT.Description from EnumArmorType as AT where AT.ID = " + Conversions.ToString((int)armorRating_0));
			}
			return result;
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x0000EF46 File Offset: 0x0000D146
		public static string smethod_39(DockFacility.Enum50 enum50_0, SQLiteConnection sqliteConnection_0)
		{
			return Class401.smethod_2(new Class403(sqliteConnection_0), "SELECT Description from EnumDockingFacilityPhysicalSize where ID = " + Conversions.ToString((int)enum50_0));
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x0000EF63 File Offset: 0x0000D163
		public static string smethod_40(GlobalVariables.Enum146 enum146_0, SQLiteConnection sqliteConnection_0)
		{
			return Class401.smethod_2(new Class403(sqliteConnection_0), "SELECT ARL.Description from EnumAircraftRunwayLength as ARL where ARL.ID = " + Conversions.ToString((int)enum146_0));
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00228F3C File Offset: 0x0022713C
		public static string smethod_41(string string_0)
		{
			string result;
			try
			{
				int num = string_0.IndexOf(" ");
				if (num == -1)
				{
					result = string_0;
				}
				else
				{
					result = string_0.Substring(0, num);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101088", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = "Error!";
			}
			return result;
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00228FB8 File Offset: 0x002271B8
		public static string smethod_42(ActiveUnit.Throttle throttle_0, ActiveUnit activeUnit_0)
		{
			string result;
			switch (throttle_0)
			{
			case ActiveUnit.Throttle.FullStop:
				if (activeUnit_0.bool_3 && ((Aircraft)activeUnit_0).method_150(false))
				{
					result = "Hover";
				}
				else if (activeUnit_0.vmethod_86().bool_4)
				{
					result = "HOLD";
				}
				else
				{
					result = "Full Stop";
				}
				break;
			case ActiveUnit.Throttle.Loiter:
				if (activeUnit_0.bool_3 | activeUnit_0.method_2())
				{
					result = "Loiter";
				}
				else
				{
					string text = "Creep";
					if (activeUnit_0.vmethod_87().bool_1)
					{
						text += " - No-Cav";
					}
					result = text;
				}
				break;
			case ActiveUnit.Throttle.Cruise:
			{
				string text = "Cruise";
				if (activeUnit_0.vmethod_87().bool_1)
				{
					text += " - No-Cav";
				}
				result = text;
				break;
			}
			case ActiveUnit.Throttle.Full:
			{
				string text = "Full";
				if (activeUnit_0.vmethod_87().bool_1)
				{
					text += " - No-Cav";
				}
				result = text;
				break;
			}
			case ActiveUnit.Throttle.Flank:
				if (activeUnit_0.bool_3 | activeUnit_0.method_2())
				{
					result = "Afterburner";
				}
				else
				{
					string text = "Flank";
					if (activeUnit_0.vmethod_87().bool_1)
					{
						text += " - No-Cav";
					}
					result = text;
				}
				break;
			default:
				result = "UNDEFINED!";
				break;
			}
			return result;
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x002290EC File Offset: 0x002272EC
		public static string smethod_43(GlobalVariables.ActiveUnitType activeUnitType_0)
		{
			string result;
			switch (activeUnitType_0)
			{
			case GlobalVariables.ActiveUnitType.None:
				result = "None";
				break;
			case GlobalVariables.ActiveUnitType.Aircraft:
				result = "Aircraft";
				break;
			case GlobalVariables.ActiveUnitType.Ship:
				result = "Ship";
				break;
			case GlobalVariables.ActiveUnitType.Submarine:
				result = "Submarine";
				break;
			case GlobalVariables.ActiveUnitType.Facility:
				result = "Facility";
				break;
			case GlobalVariables.ActiveUnitType.Aimpoint:
				result = "Aimpoint";
				break;
			case GlobalVariables.ActiveUnitType.Weapon:
				result = "Weapon";
				break;
			case GlobalVariables.ActiveUnitType.Satellite:
				result = "Satellite";
				break;
			default:
				throw new NotImplementedException();
			}
			return result;
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00229168 File Offset: 0x00227368
		public static XmlNode smethod_44(XmlNodeList xmlNodeList_0, string string_0)
		{
			XmlNode result;
			try
			{
				int num = xmlNodeList_0.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					XmlNode xmlNode = xmlNodeList_0[i];
					if (string.CompareOrdinal(xmlNode.Name, string_0) == 0)
					{
						return xmlNode;
					}
				}
				result = null;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101093", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x002291F4 File Offset: 0x002273F4
		public static string smethod_45(Stream stream_0)
		{
			long position = stream_0.Position;
			stream_0.Position = 0L;
			string result = new StreamReader(stream_0).ReadToEnd();
			stream_0.Position = position;
			return result;
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x0022922C File Offset: 0x0022742C
		public static Geopoint_Struct smethod_46(List<GeoPoint> list_0)
		{
			Geopoint_Struct result;
			try
			{
				double num = 0.0;
				double num2 = 0.0;
				double num3 = 0.0;
				int count = list_0.Count;
				int num4 = list_0.Count - 1;
				for (int i = 0; i <= num4; i++)
				{
					GeoPoint geoPoint = list_0[i];
					double num5 = 0.0174532925199433 * geoPoint.imethod_2();
					double num6 = 0.0174532925199433 * geoPoint.imethod_0();
					double num7 = Math.Cos(num5);
					double num8 = num7 * Math.Cos(num6);
					double num9 = num7 * Math.Sin(num6);
					double num10 = Math.Sin(num5);
					num += num8;
					num2 += num9;
					num3 += num10;
				}
				double num11 = Math.Sqrt(Math.Pow(num, 2.0) + Math.Pow(num2, 2.0) + Math.Pow(num3, 2.0));
				num /= num11;
				num2 /= num11;
				num3 /= num11;
				double num12 = Math.Atan2(num2, num);
				double x = Math.Sqrt(num * num + num2 * num2);
				double num13 = Math.Atan2(num3, x);
				result = new Geopoint_Struct(57.2957795130823 * num12, 57.2957795130823 * num13);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101332", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Geopoint_Struct(0.0, 0.0);
			}
			return result;
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x002293CC File Offset: 0x002275CC
		public static Geopoint_Struct smethod_47(Geopoint_Struct[] geopoint_Struct_0)
		{
			Geopoint_Struct result;
			try
			{
				double num = 0.0;
				double num2 = 0.0;
				double num3 = 0.0;
				int num4 = geopoint_Struct_0.Length - 1;
				for (int i = 0; i <= num4; i++)
				{
					Geopoint_Struct geopoint_Struct = geopoint_Struct_0[i];
					double num5 = 0.0174532925199433 * geopoint_Struct.double_1;
					double num6 = 0.0174532925199433 * geopoint_Struct.double_0;
					double num7 = Math.Cos(num5);
					double num8 = num7 * Math.Cos(num6);
					double num9 = num7 * Math.Sin(num6);
					double num10 = Math.Sin(num5);
					num += num8;
					num2 += num9;
					num3 += num10;
				}
				double num11 = Math.Sqrt(Math.Pow(num, 2.0) + Math.Pow(num2, 2.0) + Math.Pow(num3, 2.0));
				num /= num11;
				num2 /= num11;
				num3 /= num11;
				double num12 = Math.Atan2(num2, num);
				double x = Math.Sqrt(num * num + num2 * num2);
				double num13 = Math.Atan2(num3, x);
				result = new Geopoint_Struct(57.2957795130823 * num12, 57.2957795130823 * num13);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101332", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Geopoint_Struct(0.0, 0.0);
			}
			return result;
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00229564 File Offset: 0x00227764
		public static Geopoint_Struct smethod_48(List<ReferencePoint> list_0)
		{
			Geopoint_Struct result;
			try
			{
				result = Misc.smethod_46(Enumerable.ToList<GeoPoint>(Enumerable.Cast<GeoPoint>(list_0)));
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101331", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Geopoint_Struct(0.0, 0.0);
			}
			return result;
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x002295E4 File Offset: 0x002277E4
		public static bool smethod_49(List<GeoPoint> list_0)
		{
			bool result;
			try
			{
				if (Math2.smethod_27(list_0))
				{
					List<Geopoint_Struct> list = new List<Geopoint_Struct>();
					try
					{
						foreach (GeoPoint geoPoint in list_0)
						{
							List<Geopoint_Struct> list2 = list;
							double num = geoPoint.imethod_0() + 180.0;
							list2.Add(new Geopoint_Struct(Math2.smethod_11(ref num), geoPoint.imethod_2()));
						}
					}
					finally
					{
						List<GeoPoint>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					result = Math2.smethod_26(list);
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101091", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x002296B8 File Offset: 0x002278B8
		public static string smethod_50(GlobalVariables.TechGenerationClass techGenerationClass_0)
		{
			GlobalVariables.TechGenerationClass techGenerationClass = techGenerationClass_0;
			string result;
			if (techGenerationClass != GlobalVariables.TechGenerationClass.NotApplicable)
			{
				switch (techGenerationClass)
				{
				case GlobalVariables.TechGenerationClass.Early1950s:
					return "Early 1950s";
				case GlobalVariables.TechGenerationClass.Late1950s:
					return "Late 1950s";
				case GlobalVariables.TechGenerationClass.Early1960s:
					return "Early 1960s";
				case GlobalVariables.TechGenerationClass.Late1960s:
					return "Late 1960s";
				case GlobalVariables.TechGenerationClass.Early1970s:
					return "Early 1970s";
				case GlobalVariables.TechGenerationClass.Late1970s:
					return "Late 1970s";
				case GlobalVariables.TechGenerationClass.Early1980s:
					return "Early 1980s";
				case GlobalVariables.TechGenerationClass.Late1980s:
					return "Late 1980s";
				case GlobalVariables.TechGenerationClass.Early1990s:
					return "Early 1990s";
				case GlobalVariables.TechGenerationClass.Late1990s:
					return "Late 1990s";
				case GlobalVariables.TechGenerationClass.Early2000s:
					return "Early 2000s";
				case GlobalVariables.TechGenerationClass.Late2000s:
					return "Late 2000s";
				case GlobalVariables.TechGenerationClass.Early2010s:
					return "Early 2010s";
				case GlobalVariables.TechGenerationClass.Late2010s:
					return "Late 2010s";
				case GlobalVariables.TechGenerationClass.Early2020s:
					break;
				case GlobalVariables.TechGenerationClass.Late2020s:
					return "Late 2020s";
				default:
					switch (techGenerationClass)
					{
					case GlobalVariables.TechGenerationClass.IR_SingleSpectral:
						return "Single-spectral IR";
					case GlobalVariables.TechGenerationClass.IR_DualSpectral:
						return "Dual-spectral IR";
					case GlobalVariables.TechGenerationClass.IR_Imaging_FPA:
						return "Imaging IR";
					}
					break;
				}
				result = techGenerationClass_0.ToString();
			}
			else
			{
				result = "N/A";
			}
			return result;
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x002297F0 File Offset: 0x002279F0
		public static string smethod_51(Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult_0)
		{
			string result;
			switch (missionAssignmentAttemptResult_0)
			{
			case Mission.MissionAssignmentAttemptResult.Success:
				result = "Success";
				break;
			case Mission.MissionAssignmentAttemptResult.Fail_OutOfComms:
				result = "Failure - Unit is out-of-comms";
				break;
			case Mission.MissionAssignmentAttemptResult.Fail_Other:
				result = "Failure - undefined reason";
				break;
			default:
				result = missionAssignmentAttemptResult_0.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0022983C File Offset: 0x00227A3C
		public static string smethod_52(ActiveUnit_Damage.FireIntensityLevel? nullable_0)
		{
			ActiveUnit_Damage.FireIntensityLevel? fireIntensityLevel = nullable_0;
			byte? b = (fireIntensityLevel != null) ? new byte?((byte)fireIntensityLevel.GetValueOrDefault()) : null;
			string result;
			if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				result = "No Fire";
			}
			else
			{
				b = ((fireIntensityLevel != null) ? new byte?((byte)fireIntensityLevel.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					result = "Minor Fire";
				}
				else
				{
					b = ((fireIntensityLevel != null) ? new byte?((byte)fireIntensityLevel.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						result = "Major Fire";
					}
					else
					{
						b = ((fireIntensityLevel != null) ? new byte?((byte)fireIntensityLevel.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							result = "Severe Fire";
						}
						else
						{
							b = ((fireIntensityLevel != null) ? new byte?((byte)fireIntensityLevel.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								result = "Conflagration";
							}
							else
							{
								result = nullable_0.ToString();
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00229A1C File Offset: 0x00227C1C
		public static string smethod_53(ActiveUnit_Damage.FloodingIntensityLevel? nullable_0)
		{
			ActiveUnit_Damage.FloodingIntensityLevel? floodingIntensityLevel = nullable_0;
			byte? b = (floodingIntensityLevel != null) ? new byte?((byte)floodingIntensityLevel.GetValueOrDefault()) : null;
			string result;
			if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				result = "No Flooding";
			}
			else
			{
				b = ((floodingIntensityLevel != null) ? new byte?((byte)floodingIntensityLevel.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					result = "Minor Flooding";
				}
				else
				{
					b = ((floodingIntensityLevel != null) ? new byte?((byte)floodingIntensityLevel.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						result = "Major Flooding";
					}
					else
					{
						b = ((floodingIntensityLevel != null) ? new byte?((byte)floodingIntensityLevel.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							result = "Severe Flooding";
						}
						else
						{
							b = ((floodingIntensityLevel != null) ? new byte?((byte)floodingIntensityLevel.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								result = "Capsizing imminent";
							}
							else
							{
								result = nullable_0.ToString();
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00229BFC File Offset: 0x00227DFC
		public static string smethod_54(Contact.Enum47? nullable_0)
		{
			Contact.Enum47? @enum = nullable_0;
			byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
			string result;
			if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				result = "No damage";
			}
			else
			{
				b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					result = "Light damage";
				}
				else
				{
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						result = "Medium damage";
					}
					else
					{
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							result = "Heavy damage";
						}
						else
						{
							b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								result = "Destroyed";
							}
							else
							{
								result = nullable_0.ToString();
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00229DDC File Offset: 0x00227FDC
		public static string smethod_55(Weapon._WeaponType _WeaponType_0)
		{
			Weapon._WeaponType weaponType = _WeaponType_0;
			if (weaponType <= Weapon._WeaponType.RisingMine)
			{
				if (weaponType <= Weapon._WeaponType.TrainingRound)
				{
					if (weaponType == Weapon._WeaponType.None)
					{
						return "None";
					}
					switch (weaponType)
					{
					case Weapon._WeaponType.GuidedWeapon:
						return "Guided Weapon";
					case Weapon._WeaponType.Rocket:
						return "Rocket";
					case Weapon._WeaponType.IronBomb:
						return "Unguided Bomb";
					case Weapon._WeaponType.Gun:
						return "Gun";
					case Weapon._WeaponType.Decoy_Expendable:
						return "Decoy (Expendable)";
					case Weapon._WeaponType.Decoy_Towed:
						return "Decoy (Towed)";
					case Weapon._WeaponType.Decoy_Vehicle:
						return "Decoy (Vehicle)";
					case Weapon._WeaponType.TrainingRound:
						return "Training Round";
					}
				}
				else
				{
					switch (weaponType)
					{
					case Weapon._WeaponType.SensorPod:
						return "Sensor/EW Pod";
					case Weapon._WeaponType.DropTank:
						return "Drop Tank";
					case Weapon._WeaponType.BuddyStore:
						return "Buddy Store";
					case Weapon._WeaponType.FerryTank:
						return "Ferry Tank";
					default:
						switch (weaponType)
						{
						case Weapon._WeaponType.Torpedo:
							return "Torpedo";
						case Weapon._WeaponType.DepthCharge:
							return "Depth Charge";
						case Weapon._WeaponType.Sonobuoy:
							return "Sonobuoy";
						case Weapon._WeaponType.BottomMine:
							return "Bottom Mine";
						case Weapon._WeaponType.MooredMine:
							return "Moored Mine";
						case Weapon._WeaponType.FloatingMine:
							return "Floating Mine";
						case Weapon._WeaponType.MovingMine:
							return "Moving Mine";
						case Weapon._WeaponType.RisingMine:
							return "Rising Mine";
						}
						break;
					}
				}
			}
			else if (weaponType <= Weapon._WeaponType.RV)
			{
				if (weaponType == Weapon._WeaponType.BallisticMissile)
				{
					return "Ballistic Missile";
				}
				if (weaponType == Weapon._WeaponType.RV)
				{
					return "RV";
				}
			}
			else
			{
				if (weaponType == Weapon._WeaponType.Laser)
				{
					return "Laser";
				}
				if (weaponType == Weapon._WeaponType.HGV)
				{
					return "HGV";
				}
				switch (weaponType)
				{
				case Weapon._WeaponType.Cargo:
					return "Cargo";
				case Weapon._WeaponType.Troops:
					return "Troops";
				case Weapon._WeaponType.Paratroops:
					return "Paratroops";
				}
			}
			return _WeaponType_0.ToString();
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00229FFC File Offset: 0x002281FC
		public static string smethod_56(GlobalVariables.TargetVisualSizeClass targetVisualSizeClass_0)
		{
			string result;
			switch (targetVisualSizeClass_0)
			{
			case GlobalVariables.TargetVisualSizeClass.Stealthy:
				result = "Extra small";
				break;
			case GlobalVariables.TargetVisualSizeClass.VSmall:
				result = "Very small";
				break;
			case GlobalVariables.TargetVisualSizeClass.Small:
				result = "Small";
				break;
			case GlobalVariables.TargetVisualSizeClass.Medium:
				result = "Medium";
				break;
			case GlobalVariables.TargetVisualSizeClass.Large:
				result = "Large";
				break;
			case GlobalVariables.TargetVisualSizeClass.VLarge:
				result = "Very large";
				break;
			case GlobalVariables.TargetVisualSizeClass.Unknown:
				result = "Unknown";
				break;
			default:
				result = targetVisualSizeClass_0.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x0022A074 File Offset: 0x00228274
		public static string smethod_57(ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_0, ActiveUnit activeUnit_0)
		{
			ActiveUnit._ActiveUnitFuelState activeUnitFuelState = activeUnit_0.vmethod_110();
			ActiveUnit._ActiveUnitWeaponState activeUnitWeaponState = activeUnit_0.vmethod_112();
			string text = "";
			if (activeUnitFuelState == ActiveUnit._ActiveUnitFuelState.IsBingo)
			{
				text = "Bingo";
			}
			else if (activeUnitFuelState == ActiveUnit._ActiveUnitFuelState.IsJoker)
			{
				text = "Joker";
			}
			else if (activeUnitFuelState == ActiveUnit._ActiveUnitFuelState.IgnoreBingoAndJoker)
			{
				text = "RTB order cancelled after reaching fuel/weapon state";
			}
			if (activeUnitWeaponState == ActiveUnit._ActiveUnitWeaponState.IsWinchester)
			{
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += " and ";
				}
				text += "Winchester";
			}
			else if (activeUnitWeaponState == ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO)
			{
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += " and ";
				}
				text += "Winchester, engaging opportunity target";
			}
			else if (activeUnitWeaponState == ActiveUnit._ActiveUnitWeaponState.IsShotgun)
			{
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += " and ";
				}
				text += "Shotgun";
			}
			else if (activeUnitWeaponState == ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO)
			{
				if (Operators.CompareString(text, "", false) != 0)
				{
					text += " and ";
				}
				text += "Shotgun, engaging opportunity target";
			}
			else if (activeUnitFuelState != ActiveUnit._ActiveUnitFuelState.IgnoreBingoAndJoker && activeUnitWeaponState == ActiveUnit._ActiveUnitWeaponState.IgnoreWinchesterAndShotgun)
			{
				text = "RTB order cancelled after reaching fuel/weapon state";
			}
			if (Operators.CompareString(text, "", false) != 0)
			{
				text = " (" + text + ")";
			}
			switch (_ActiveUnitStatus_0)
			{
			case ActiveUnit._ActiveUnitStatus.Unassigned:
				return "Unassigned" + text;
			case ActiveUnit._ActiveUnitStatus.OnPlottedCourse:
				return "On Plotted Course" + text;
			case ActiveUnit._ActiveUnitStatus.EngagedOffensive:
				return "Engaged Offensive" + text;
			case ActiveUnit._ActiveUnitStatus.EngagedDefensive:
				return "Engaged Defensive" + text;
			case ActiveUnit._ActiveUnitStatus.OnAttackRun:
				return "On Attack Run" + text;
			case ActiveUnit._ActiveUnitStatus.OnPatrol:
				return "On Patrol" + text;
			case ActiveUnit._ActiveUnitStatus.RTB:
				return "RTB" + text;
			case ActiveUnit._ActiveUnitStatus.Tasked:
				if (activeUnit_0.vmethod_86().bool_2)
				{
					return "Mission escort " + text;
				}
				return "Tasked on mission" + text;
			case ActiveUnit._ActiveUnitStatus.FormingUp:
				return "Forming Up" + text;
			case ActiveUnit._ActiveUnitStatus.RTB_Manual:
				return "RTB (As ordered)" + text;
			case ActiveUnit._ActiveUnitStatus.OnSupportMission:
				return "On Support Mission" + text;
			case ActiveUnit._ActiveUnitStatus.OnFerryMission:
				return "On Ferry Mission" + text;
			case ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint:
				return "Heading to refuel point" + text;
			case ActiveUnit._ActiveUnitStatus.Refuelling:
				return "Refuelling" + text;
			case ActiveUnit._ActiveUnitStatus.RTB_MissionOver:
				return "RTB (Mission over)" + text;
			case ActiveUnit._ActiveUnitStatus.GroupLead_SlowingToAllowFormUp:
				return "Slowing down (to allow group to form up)" + text;
			case ActiveUnit._ActiveUnitStatus.RTB_Group:
				return "RTB (Group Order)" + text;
			case ActiveUnit._ActiveUnitStatus.RTB_CalledOff:
				return "RTB (Called Off)" + text;
			case ActiveUnit._ActiveUnitStatus.WaitForPathfinder:
				return "Waiting for pathfinder-generated course";
			case ActiveUnit._ActiveUnitStatus.AttemptingToReestablishComms:
				return "Attempting to re-establish comms";
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			return _ActiveUnitStatus_0.ToString();
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x0022A368 File Offset: 0x00228568
		public static void smethod_58(List<ActiveUnit> UnitsCollection, Scenario theScen, Side theSide, Mission theMission = null)
		{
			try
			{
				try
				{
					foreach (ActiveUnit activeUnit in UnitsCollection)
					{
						if (!Information.IsNothing(activeUnit.vmethod_65(false)))
						{
							activeUnit.vmethod_66(false, null);
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (Enumerable.Count<ActiveUnit>(Enumerable.Where<ActiveUnit>(Enumerable.Select<ActiveUnit, ActiveUnit>(UnitsCollection, (Misc._Closure$__.$I89-0 == null) ? (Misc._Closure$__.$I89-0 = new Func<ActiveUnit, ActiveUnit>(Misc._Closure$__.$I.method_0)) : Misc._Closure$__.$I89-0), (Misc._Closure$__.$I89-1 == null) ? (Misc._Closure$__.$I89-1 = new Func<ActiveUnit, bool>(Misc._Closure$__.$I.method_1)) : Misc._Closure$__.$I89-1)) == UnitsCollection.Count)
				{
					IEnumerable<int> enumerable = Enumerable.Distinct<int>(Enumerable.Select<ActiveUnit, int>(UnitsCollection, (Misc._Closure$__.$I89-2 == null) ? (Misc._Closure$__.$I89-2 = new Func<ActiveUnit, int>(Misc._Closure$__.$I.method_2)) : Misc._Closure$__.$I89-2));
					try
					{
						foreach (int int_ in enumerable)
						{
							Misc.Class439 @class = new Misc.Class439(@class);
							@class.int_0 = int_;
							List<ActiveUnit> list = new List<ActiveUnit>();
							IEnumerable<ActiveUnit> enumerable2 = Enumerable.Where<ActiveUnit>(UnitsCollection, new Func<ActiveUnit, bool>(@class.method_0));
							try
							{
								foreach (ActiveUnit item in enumerable2)
								{
									list.Add(item);
								}
							}
							finally
							{
								IEnumerator<ActiveUnit> enumerator3;
								if (enumerator3 != null)
								{
									enumerator3.Dispose();
								}
							}
							if (list.Count > 1)
							{
								Group group = new Group(ref theScen, ref theSide, list, false, null, null);
								if (!Information.IsNothing(theMission))
								{
									group.doctrine_0 = theMission.doctrine_0;
								}
							}
						}
						goto IL_1C5;
					}
					finally
					{
						IEnumerator<int> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
				}
				List<ActiveUnit> list2 = new List<ActiveUnit>();
				list2.AddRange(UnitsCollection);
				Group group2 = new Group(ref theScen, ref theSide, list2, false, null, null);
				if (!Information.IsNothing(theMission))
				{
					group2.doctrine_0 = theMission.doctrine_0;
				}
				IL_1C5:;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101092", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x0000EF80 File Offset: 0x0000D180
		public static float smethod_59(float float_0, float float_1)
		{
			return (float)((double)((float)((double)((float)((double)float_0 * 1.68780986) * (360f / float_1)) / 3.14159265358979 / 2.0)) / 6076.11549);
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x0022A5D8 File Offset: 0x002287D8
		public static List<List<Point[]>> smethod_60(List<Point[]> SourceList, int ListSize = 30)
		{
			List<List<Point[]>> list = new List<List<Point[]>>();
			for (int i = 0; i < SourceList.Count; i += ListSize)
			{
				list.Add(SourceList.GetRange(i, Math.Min(ListSize, SourceList.Count - i)));
			}
			return list;
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x0022A618 File Offset: 0x00228818
		public static bool smethod_61(GeoPoint geoPoint_0, GeoPoint geoPoint_1, GeoPoint geoPoint_2, ref GeoPoint geoPoint_3, ref GeoPoint geoPoint_4)
		{
			Class432.Class433 @class = new Class432.Class433(geoPoint_0.imethod_2(), geoPoint_0.imethod_0());
			double num;
			double num2;
			@class.method_1(geoPoint_2.imethod_2(), geoPoint_2.imethod_0(), ref num, ref num2, true);
			double num3;
			double num4;
			@class.method_1(geoPoint_1.imethod_2(), geoPoint_1.imethod_0(), ref num3, ref num4, true);
			double num5 = num3;
			double num6 = num4;
			float num7 = (float)Math.Sqrt(num5 * num5 + num6 * num6);
			double num8 = num;
			double num9 = num2;
			double num10 = num8 * num8 + num9 * num9;
			bool result;
			if (num10 < (double)(num7 * num7))
			{
				geoPoint_3 = null;
				geoPoint_4 = null;
				result = false;
			}
			else
			{
				double num11 = Math.Sqrt(num10 - (double)(num7 * num7));
				Misc.smethod_62(0.0, 0.0, num7, num, num2, (float)num11, ref geoPoint_3, ref geoPoint_4);
				Class432.Class433 class2 = @class;
				double double_ = geoPoint_3.imethod_0();
				double double_2 = geoPoint_3.imethod_2();
				GeoPoint geoPoint;
				double double_3 = (geoPoint = geoPoint_3).imethod_2();
				GeoPoint geoPoint2;
				double double_4 = (geoPoint2 = geoPoint_3).imethod_0();
				class2.method_6(double_, double_2, ref double_3, ref double_4);
				geoPoint2.imethod_1(double_4);
				geoPoint.imethod_3(double_3);
				Class432.Class433 class3 = @class;
				double double_5 = geoPoint_4.imethod_0();
				double double_6 = geoPoint_4.imethod_2();
				double_4 = (geoPoint2 = geoPoint_4).imethod_2();
				double_3 = (geoPoint = geoPoint_4).imethod_0();
				class3.method_6(double_5, double_6, ref double_4, ref double_3);
				geoPoint.imethod_1(double_3);
				geoPoint2.imethod_3(double_4);
				result = true;
			}
			return result;
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x0022A768 File Offset: 0x00228968
		private static int smethod_62(double double_1, double double_2, float float_0, double double_3, double double_4, float float_1, ref GeoPoint geoPoint_0, ref GeoPoint geoPoint_1)
		{
			double num = double_1 - double_3;
			double num2 = double_2 - double_4;
			double num3 = Math.Sqrt(num * num + num2 * num2);
			int result;
			if (num3 > (double)(float_0 + float_1))
			{
				geoPoint_0 = new GeoPoint(double.NaN, double.NaN);
				geoPoint_1 = new GeoPoint(double.NaN, double.NaN);
				result = 0;
			}
			else if (num3 < (double)Math.Abs(float_0 - float_1))
			{
				geoPoint_0 = new GeoPoint(double.NaN, double.NaN);
				geoPoint_1 = new GeoPoint(double.NaN, double.NaN);
				result = 0;
			}
			else if (num3 == 0.0 && float_0 == float_1)
			{
				geoPoint_0 = new GeoPoint(double.NaN, double.NaN);
				geoPoint_1 = new GeoPoint(double.NaN, double.NaN);
				result = 0;
			}
			else
			{
				double num4 = ((double)(float_0 * float_0 - float_1 * float_1) + num3 * num3) / (2.0 * num3);
				double num5 = Math.Sqrt((double)(float_0 * float_0) - num4 * num4);
				double num6 = double_1 + num4 * (double_3 - double_1) / num3;
				double num7 = double_2 + num4 * (double_4 - double_2) / num3;
				geoPoint_0 = new GeoPoint((double)((float)(num6 + num5 * (double_4 - double_2) / num3)), (double)((float)(num7 - num5 * (double_3 - double_1) / num3)));
				geoPoint_1 = new GeoPoint((double)((float)(num6 - num5 * (double_4 - double_2) / num3)), (double)((float)(num7 + num5 * (double_3 - double_1) / num3)));
				if (num3 == (double)(float_0 + float_1))
				{
					result = 1;
				}
				else
				{
					result = 2;
				}
			}
			return result;
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0022A8F8 File Offset: 0x00228AF8
		public static Misc.Enum143 smethod_63(float float_0, float float_1)
		{
			float_1 = Math2.smethod_7(float_1 - float_0);
			float_0 = 0f;
			Misc.Enum143 result;
			if (float_1 > 180f)
			{
				result = Misc.Enum143.const_0;
			}
			else
			{
				result = Misc.Enum143.const_1;
			}
			return result;
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x0000EFB9 File Offset: 0x0000D1B9
		public static bool smethod_64(string string_0, string string_1, StringComparison stringComparison_0)
		{
			return string_0.IndexOf(string_1, stringComparison_0) >= 0;
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x0022A928 File Offset: 0x00228B28
		public static Point[] smethod_65(ref Point[] point_0, ref Point[] point_1)
		{
			Point[] array = new Point[point_0.Length + point_1.Length - 1 + 1];
			point_0.CopyTo(array, 0);
			point_1.CopyTo(array, point_0.Length);
			return array;
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x0022A960 File Offset: 0x00228B60
		public static List<T>[] smethod_66<T>(List<T> list_0, int int_0)
		{
			if (list_0 == null)
			{
				throw new ArgumentNullException("list");
			}
			if (int_0 < 1)
			{
				throw new ArgumentOutOfRangeException("totalPartitions");
			}
			int count = list_0.Count;
			List<T>[] array = new List<T>[int_0 - 1 + 1];
			int num = (int)Math.Ceiling((double)count / (double)int_0);
			int num2 = 0;
			int num3 = array.Length - 1;
			for (int i = 0; i <= num3; i++)
			{
				array[i] = new List<T>();
				int num4 = num2;
				int num5 = num2 + num - 1;
				int num6 = num4;
				while (num6 <= num5 && num6 < count)
				{
					array[i].Add(list_0[num6]);
					num6++;
				}
				num2 += num;
			}
			return array;
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x0022AA00 File Offset: 0x00228C00
		public static string smethod_67(ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker resultOfAttemptToRendezvousWithTanker_0)
		{
			string result;
			switch (resultOfAttemptToRendezvousWithTanker_0)
			{
			case ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.None:
				result = "None";
				break;
			case ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Success:
				result = "Success";
				break;
			case ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Fail_Unknown:
				result = "Failed - Unknown reason";
				break;
			case ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Fail_NoSuitableFuelOrStoresToTransfer:
				result = "Failed - No suitable fuel or stores to transfer";
				break;
			case ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Fail_CannotIntercept:
				result = "Failed - Cannot intercept the provider";
				break;
			case ActiveUnit_DockingOps.ResultOfAttemptToRendezvousWithTanker.Fail_ProviderSmallerThanReceiver:
				result = "Failed - The provider is smaller than the receiver and is not a dedicated tanker/UNREP platform";
				break;
			default:
				result = resultOfAttemptToRendezvousWithTanker_0.ToString();
				break;
			}
			return result;
		}

		// Token: 0x04001C5D RID: 7261
		public static double double_0;

		// Token: 0x020003EE RID: 1006
		public enum PostureStance : byte
		{
			// Token: 0x04001C5F RID: 7263
			Neutral,
			// Token: 0x04001C60 RID: 7264
			Friendly,
			// Token: 0x04001C61 RID: 7265
			Unfriendly,
			// Token: 0x04001C62 RID: 7266
			Hostile,
			// Token: 0x04001C63 RID: 7267
			Unknown
		}

		// Token: 0x020003EF RID: 1007
		internal enum Enum143
		{
			// Token: 0x04001C65 RID: 7269
			const_0 = 1,
			// Token: 0x04001C66 RID: 7270
			const_1
		}

		// Token: 0x020003F0 RID: 1008
		[CompilerGenerated]
		internal sealed class Class438
		{
			// Token: 0x06001E7B RID: 7803 RVA: 0x0000EFC9 File Offset: 0x0000D1C9
			internal void method_0(int int_0)
			{
				this.char_0 = Convert.ToChar(this.byte_0[int_0]);
				if (!Misc.smethod_7((int)this.char_0))
				{
					this.byte_0[int_0] = 0;
				}
			}

			// Token: 0x04001C67 RID: 7271
			public char char_0;

			// Token: 0x04001C68 RID: 7272
			public byte[] byte_0;
		}

		// Token: 0x020003F2 RID: 1010
		[CompilerGenerated]
		internal sealed class Class439
		{
			// Token: 0x06001E81 RID: 7809 RVA: 0x0000F00D File Offset: 0x0000D20D
			public Class439(Misc.Class439 class439_0)
			{
				if (class439_0 != null)
				{
					this.int_0 = class439_0.int_0;
				}
			}

			// Token: 0x06001E82 RID: 7810 RVA: 0x0000F024 File Offset: 0x0000D224
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return ((Aircraft)activeUnit_0).method_166() == this.int_0;
			}

			// Token: 0x04001C75 RID: 7285
			public int int_0;
		}
	}
}
