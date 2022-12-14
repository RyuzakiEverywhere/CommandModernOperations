using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns4;
using ns5;
using Steamworks;

namespace ns7
{
	// Token: 0x02000F38 RID: 3896
	[StandardModule]
	internal sealed class Class2556
	{
		// Token: 0x06008BB9 RID: 35769 RVA: 0x004B3E98 File Offset: 0x004B2098
		public static void smethod_0(bool bool_0)
		{
			try
			{
				Class2556.smethod_3();
				try
				{
					foreach (KeyValuePair<Class2556.Enum209, Class2556.Struct78> keyValuePair in Class2556.smethod_1())
					{
						Class2556.smethod_8(keyValuePair.Key);
					}
				}
				finally
				{
					Dictionary<Class2556.Enum209, Class2556.Struct78>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200416", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
		}

		// Token: 0x06008BBA RID: 35770 RVA: 0x00053766 File Offset: 0x00051966
		internal static Dictionary<Class2556.Enum209, Class2556.Struct78> smethod_1()
		{
			return Class2556.dictionary_0;
		}

		// Token: 0x06008BBB RID: 35771 RVA: 0x004B3F34 File Offset: 0x004B2134
		internal static List<Class2556.Struct78> smethod_2(List<Class2556.Enum209> list_0)
		{
			List<Class2556.Struct78> list = new List<Class2556.Struct78>();
			try
			{
				foreach (Class2556.Enum209 key in list_0)
				{
					list.Add(Class2556.dictionary_0[key]);
				}
			}
			finally
			{
				List<Class2556.Enum209>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return list;
		}

		// Token: 0x06008BBC RID: 35772 RVA: 0x004B3F94 File Offset: 0x004B2194
		private static void smethod_3()
		{
			Class2556.Struct78 value = default(Class2556.Struct78);
			value.string_0 = "Command - Modern Operations";
			value.appId_t_0 = Class2556.appId_t_0;
			value.string_1 = "Command Modern Operations";
			value.string_2 = "Command Modern Operations";
			value.string_3 = "https://www.matrixgames.com/game/command-modern-operations";
			value.string_4 = "NoLicense_CMO.jpg";
			value.color_0 = Color.LightSkyBlue;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_0, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command - Professional Edition";
			value.appId_t_0 = new AppId_t(0U);
			value.string_1 = "Command Professional Edition";
			value.string_3 = "http://www.warfaresims.com/?page_id=3822";
			value.string_4 = "NoLicense_CPE.jpg";
			value.color_0 = Color.LightSkyBlue;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_8, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command - Northern Inferno";
			value.appId_t_0 = new AppId_t(397180U);
			value.appId_t_1 = new AppId_t(1182291U);
			value.string_1 = "Command Northern Inferno";
			value.string_2 = "CMO Northern Inferno";
			value.string_3 = "http://www.matrixgames.com/products/589/details/Command:.Northern.Inferno.";
			value.string_4 = "NoLicense_NI.jpg";
			value.color_0 = Color.DarkRed;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_1, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command - Chains Of War";
			value.appId_t_0 = new AppId_t(614130U);
			value.appId_t_1 = new AppId_t(1182292U);
			value.string_1 = "Command Chains Of War";
			value.string_2 = "CMO Chains Of War";
			value.string_3 = "http://www.matrixgames.com/products/693/details/Command.Chains.of.War";
			value.string_4 = "NoLicense_COW.jpg";
			value.color_0 = Color.DarkRed;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_7, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command - Shifting Sands";
			value.appId_t_0 = new AppId_t(718710U);
			value.appId_t_1 = new AppId_t(1182290U);
			value.string_1 = "Command Shifting Sands";
			value.string_2 = "CMO Shifting Sands";
			value.string_3 = "http://www.matrixgames.com/products/707/details/Command.Shifting.Sands";
			value.string_4 = "NoLicense_SS.jpg";
			value.color_0 = Color.DarkRed;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_10, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command - The Silent Service";
			value.appId_t_0 = new AppId_t(785930U);
			value.appId_t_1 = new AppId_t(1182293U);
			value.string_1 = "Command The Silent Service";
			value.string_2 = "CMO The Silent Service";
			value.string_3 = "http://www.matrixgames.com/products/product.asp?gid=725";
			value.string_4 = "NoLicense_TSS.jpg";
			value.color_0 = Color.DarkRed;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_12, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command - Desert Storm";
			value.appId_t_0 = new AppId_t(1036420U);
			value.appId_t_1 = new AppId_t(1182294U);
			value.string_1 = "Command Desert Storm";
			value.string_2 = "CMO Desert Storm";
			value.string_3 = "http://www.matrixgames.com/products/product.asp?gid=797";
			value.string_4 = "NoLicense_DS.jpg";
			value.color_0 = Color.DarkRed;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_16, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command LIVE #1 - Old Grudges Never Die";
			value.appId_t_0 = new AppId_t(388020U);
			value.appId_t_1 = new AppId_t(1182305U);
			value.string_1 = "Command LIVE\\Old Grudges";
			value.string_2 = "CMO LIVE\\Old Grudges";
			value.string_3 = "http://www.matrixgames.com/products/636/details/Command.Live:.Old.Grudges.Never.Die";
			value.string_4 = "NoLicense_LIVE1.jpg";
			value.color_0 = Color.LightSkyBlue;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_2, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command LIVE #2 - You Brexit, You Fix It!";
			value.appId_t_0 = new AppId_t(497611U);
			value.appId_t_1 = new AppId_t(1182309U);
			value.string_1 = "Command LIVE\\Brexit";
			value.string_2 = "CMO LIVE\\Brexit";
			value.string_3 = "http://www.matrixgames.com/products/640/details/CommandLive:YouBrexit,YouFixit!";
			value.string_4 = "NoLicense_LIVE2.jpg";
			value.color_0 = Color.LightSkyBlue;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_3, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command LIVE #3 - Spratly Spat";
			value.appId_t_0 = new AppId_t(527370U);
			value.appId_t_1 = new AppId_t(1182307U);
			value.string_1 = "Command LIVE\\Spratly";
			value.string_2 = "CMO LIVE\\Spratly";
			value.string_3 = "http://www.matrixgames.com/products/643/details/Command.LIVE:.Spratly.Spat";
			value.string_4 = "NoLicense_LIVE3.jpg";
			value.color_0 = Color.DarkRed;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_4, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command LIVE #4 - Don of a New Era";
			value.appId_t_0 = new AppId_t(497610U);
			value.appId_t_1 = new AppId_t(1182302U);
			value.string_1 = "Command LIVE\\Don Era";
			value.string_2 = "CMO LIVE\\Don Era";
			value.string_3 = "http://www.matrixgames.com/products/648/details/CommandLive:DonofanewEra";
			value.string_4 = "NoLicense_LIVE4.jpg";
			value.color_0 = Color.LightSkyBlue;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_5, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command LIVE #5 - Korean Missile Crisis";
			value.appId_t_0 = new AppId_t(584260U);
			value.appId_t_1 = new AppId_t(1182303U);
			value.string_1 = "Command LIVE\\Korea";
			value.string_2 = "CMO LIVE\\Korea";
			value.string_3 = "http://www.matrixgames.com/products/681/details/Command.Live:.Korean.Missile.Crisis";
			value.string_4 = "NoLicense_LIVE5.jpg";
			value.color_0 = Color.DarkRed;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_6, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command LIVE #6 - Pole Positions";
			value.appId_t_0 = new AppId_t(670700U);
			value.appId_t_1 = new AppId_t(1182306U);
			value.string_1 = "Command LIVE\\Pole Positions";
			value.string_2 = "CMO LIVE\\Pole Positions";
			value.string_3 = "http://www.matrixgames.com/products/702/details/Command.Live.Pole.Positions";
			value.string_4 = "NoLicense_LIVE6.jpg";
			value.color_0 = Color.LightSkyBlue;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_9, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command LIVE #7 - Black Gold Blitz";
			value.appId_t_0 = new AppId_t(729630U);
			value.appId_t_1 = new AppId_t(1182300U);
			value.string_1 = "Command LIVE\\Black Gold Blitz";
			value.string_2 = "CMO LIVE\\Black Gold Blitz";
			value.string_3 = "http://www.matrixgames.com/products/product.asp?gid=713";
			value.string_4 = "NoLicense_LIVE7.jpg";
			value.color_0 = Color.LightSkyBlue;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_11, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command LIVE #8 - Commonwealth Collision";
			value.appId_t_0 = new AppId_t(842960U);
			value.appId_t_1 = new AppId_t(1182301U);
			value.string_1 = "Command LIVE\\Commonwealth Collision";
			value.string_2 = "CMO LIVE\\Commonwealth Collision";
			value.string_3 = "http://www.matrixgames.com/products/product.asp?gid=731";
			value.string_4 = "NoLicense_LIVE8.jpg";
			value.color_0 = Color.LightSkyBlue;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_13, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command LIVE #9 - Kuril Sunrise";
			value.appId_t_0 = new AppId_t(899280U);
			value.appId_t_1 = new AppId_t(1182304U);
			value.string_1 = "Command LIVE\\Kuril Sunrise";
			value.string_2 = "CMO LIVE\\Kuril Sunrise";
			value.string_3 = "http://www.matrixgames.com/products/739/details/Command.Live.Kuril.Sunrise";
			value.string_4 = "NoLicense_LIVE9.jpg";
			value.color_0 = Color.LightSkyBlue;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_14, value);
			value = default(Class2556.Struct78);
			value.string_0 = "Command LIVE #10 - The King Of The Border";
			value.appId_t_0 = new AppId_t(1011400U);
			value.appId_t_1 = new AppId_t(1182308U);
			value.string_1 = "Command LIVE\\King Border";
			value.string_2 = "CMO LIVE\\King Border";
			value.string_3 = "http://www.matrixgames.com/products/product.asp?gid=794";
			value.string_4 = "NoLicense_LIVE10.jpg";
			value.color_0 = Color.LightSkyBlue;
			Class2556.dictionary_0.Add(Class2556.Enum209.const_15, value);
		}

		// Token: 0x06008BBD RID: 35773 RVA: 0x0005376D File Offset: 0x0005196D
		public static void smethod_4(Class2556.Enum209 enum209_0)
		{
			Class2556.hashSet_0.Add(enum209_0);
		}

		// Token: 0x06008BBE RID: 35774 RVA: 0x0005377B File Offset: 0x0005197B
		public static void smethod_5(Class2556.Enum209 enum209_0)
		{
			Class2556.hashSet_0.Remove(enum209_0);
		}

		// Token: 0x06008BBF RID: 35775 RVA: 0x00053789 File Offset: 0x00051989
		public static bool smethod_6(Class2556.Enum209 enum209_0)
		{
			return Class2556.hashSet_0.Contains(enum209_0);
		}

		// Token: 0x06008BC0 RID: 35776 RVA: 0x004B47D0 File Offset: 0x004B29D0
		public static string smethod_7(string string_0)
		{
			string result;
			if (Operators.CompareString(string_0, "6686549e-66a7-45dc-8f7a-1b0099cdae0a", false) != 0)
			{
				if (Operators.CompareString(string_0, "f8691e80-1caf-4a49-a1b7-9305255a9200", false) != 0)
				{
					if (Operators.CompareString(string_0, "f703124e-f438-42ab-a738-4dcbe7d90c86", false) != 0)
					{
						if (Operators.CompareString(string_0, "1fd76cc8-ab96-4a23-afc1-5beb48200026", false) != 0)
						{
							if (Operators.CompareString(string_0, "437950b8-3f16-4932-b8e6-a2c397e1f758", false) != 0)
							{
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								result = null;
							}
							else
							{
								result = "DESERTSTORM";
							}
						}
						else
						{
							result = "SILENTSERVICE";
						}
					}
					else
					{
						result = "SSANDS";
					}
				}
				else
				{
					result = "CHAINSOFWAR";
				}
			}
			else
			{
				result = "NINFERNO";
			}
			return result;
		}

		// Token: 0x06008BC1 RID: 35777 RVA: 0x004B485C File Offset: 0x004B2A5C
		private static void smethod_8(Class2556.Enum209 enum209_0)
		{
			if (Client.smethod_38())
			{
				if (enum209_0 == Class2556.Enum209.const_8)
				{
					return;
				}
				Class2474.smethod_1();
				if (Class2474.bool_0)
				{
					if (Class2474.smethod_2(Class2556.dictionary_0[enum209_0].appId_t_0))
					{
						Class2556.smethod_4(enum209_0);
					}
					else if (Class2474.smethod_2(Class2556.dictionary_0[enum209_0].appId_t_1))
					{
						Class2556.smethod_4(enum209_0);
					}
				}
			}
			if (!Class2556.smethod_6(enum209_0))
			{
				if (Class2556.smethod_9(Class2556.dictionary_0[enum209_0].string_1))
				{
					Class2556.smethod_4(enum209_0);
					return;
				}
				if (Class2556.smethod_9(Class2556.dictionary_0[enum209_0].string_2))
				{
					Class2556.smethod_4(enum209_0);
				}
			}
		}

		// Token: 0x06008BC2 RID: 35778 RVA: 0x004B4904 File Offset: 0x004B2B04
		private static bool smethod_9(string string_0)
		{
			RegistryKey registryKey;
			if (Environment.Is64BitOperatingSystem)
			{
				registryKey = Class2413.smethod_0().Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Matrix Games\\" + string_0);
			}
			else
			{
				registryKey = Class2413.smethod_0().Registry.LocalMachine.OpenSubKey("SOFTWARE\\Matrix Games\\" + string_0);
			}
			string value = string.Empty;
			if (registryKey != null)
			{
				value = "auth";
			}
			return string.IsNullOrEmpty(value);
		}

		// Token: 0x06008BC3 RID: 35779 RVA: 0x000041ED File Offset: 0x000023ED
		public static bool smethod_10(string string_0)
		{
			return true;
		}

		// Token: 0x06008BC4 RID: 35780 RVA: 0x004B4970 File Offset: 0x004B2B70
		public static bool smethod_11(Scenario.ScenarioFeatureOption scenarioFeatureOption_0)
		{
			GameGeneral.Enum144 @enum = GameGeneral.smethod_3();
			bool result;
			if (@enum - GameGeneral.Enum144.const_3 <= 2)
			{
				result = true;
			}
			else
			{
				switch (scenarioFeatureOption_0)
				{
				case Scenario.ScenarioFeatureOption.const_1:
					return true;
				case Scenario.ScenarioFeatureOption.const_2:
					return true;
				case Scenario.ScenarioFeatureOption.const_3:
					return true;
				case (Scenario.ScenarioFeatureOption)4:
				case Scenario.ScenarioFeatureOption.const_4:
					break;
				case Scenario.ScenarioFeatureOption.const_5:
					return true;
				default:
					if (scenarioFeatureOption_0 == Scenario.ScenarioFeatureOption.const_9)
					{
						return true;
					}
					if (scenarioFeatureOption_0 == Scenario.ScenarioFeatureOption.const_10)
					{
						return true;
					}
					break;
				}
				List<Class2556.Enum209> list = Class2556.smethod_13(scenarioFeatureOption_0);
				try
				{
					foreach (Class2556.Enum209 enum2 in list)
					{
						if (Class2556.hashSet_0.Contains(enum2))
						{
							return true;
						}
					}
				}
				finally
				{
					List<Class2556.Enum209>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06008BC5 RID: 35781 RVA: 0x004B4A30 File Offset: 0x004B2C30
		public static Class2556.Enum209 smethod_12(string string_0)
		{
			uint num = Class2574.smethod_0(string_0);
			if (num <= 2617503377U)
			{
				if (num <= 1400166703U)
				{
					if (num <= 840819822U)
					{
						if (num != 536345541U)
						{
							if (num == 840819822U)
							{
								if (Operators.CompareString(string_0, "DON", false) == 0)
								{
									if (Class2556.smethod_10(""))
									{
										return Class2556.Enum209.const_5;
									}
									return Class2556.Enum209.const_0;
								}
							}
						}
						else if (Operators.CompareString(string_0, "SSANDS", false) == 0)
						{
							return Class2556.Enum209.const_10;
						}
					}
					else if (num != 994979786U)
					{
						if (num == 1400166703U)
						{
							if (Operators.CompareString(string_0, "TUTORIAL", false) == 0)
							{
								return Class2556.Enum209.const_0;
							}
						}
					}
					else if (Operators.CompareString(string_0, "BLACKGOLD", false) == 0)
					{
						if (Class2556.smethod_10(""))
						{
							return Class2556.Enum209.const_11;
						}
						return Class2556.Enum209.const_0;
					}
				}
				else if (num <= 2432949568U)
				{
					if (num != 1947498037U)
					{
						if (num == 2432949568U)
						{
							if (Operators.CompareString(string_0, "CLIVE8", false) == 0)
							{
								if (Class2556.smethod_10(""))
								{
									return Class2556.Enum209.const_13;
								}
								return Class2556.Enum209.const_0;
							}
						}
					}
					else if (Operators.CompareString(string_0, "BREXIT", false) == 0)
					{
						if (Class2556.smethod_10(""))
						{
							return Class2556.Enum209.const_3;
						}
						return Class2556.Enum209.const_0;
					}
				}
				else if (num != 2449727187U)
				{
					if (num == 2617503377U)
					{
						if (Operators.CompareString(string_0, "CLIVE3", false) == 0)
						{
							if (Class2556.smethod_10(""))
							{
								return Class2556.Enum209.const_4;
							}
							return Class2556.Enum209.const_0;
						}
					}
				}
				else if (Operators.CompareString(string_0, "CLIVE9", false) == 0)
				{
					if (Class2556.smethod_10(""))
					{
						return Class2556.Enum209.const_14;
					}
					return Class2556.Enum209.const_0;
				}
			}
			else if (num <= 3163398647U)
			{
				if (num <= 2667836234U)
				{
					if (num != 2651058615U)
					{
						if (num == 2667836234U)
						{
							if (Operators.CompareString(string_0, "CLIVE6", false) == 0)
							{
								if (Class2556.smethod_10(""))
								{
									return Class2556.Enum209.const_9;
								}
								return Class2556.Enum209.const_0;
							}
						}
					}
					else if (Operators.CompareString(string_0, "CLIVE5", false) == 0)
					{
						if (Class2556.smethod_10(""))
						{
							return Class2556.Enum209.const_6;
						}
						return Class2556.Enum209.const_0;
					}
				}
				else if (num != 2785588663U)
				{
					if (num == 3163398647U)
					{
						if (Operators.CompareString(string_0, "SILENTSERVICE", false) == 0)
						{
							return Class2556.Enum209.const_12;
						}
					}
				}
				else if (Operators.CompareString(string_0, "OLDGRUDGES", false) == 0)
				{
					if (Class2556.smethod_10(""))
					{
						return Class2556.Enum209.const_2;
					}
					return Class2556.Enum209.const_0;
				}
			}
			else if (num <= 3475734593U)
			{
				if (num != 3459788944U)
				{
					if (num == 3475734593U)
					{
						if (Operators.CompareString(string_0, "CLIVE10", false) == 0)
						{
							if (Class2556.smethod_10(""))
							{
								return Class2556.Enum209.const_15;
							}
							return Class2556.Enum209.const_0;
						}
					}
				}
				else if (Operators.CompareString(string_0, "NINFERNO", false) == 0)
				{
					return Class2556.Enum209.const_1;
				}
			}
			else if (num != 4228905576U)
			{
				if (num == 4279042581U)
				{
					if (Operators.CompareString(string_0, "DESERTSTORM", false) == 0)
					{
						return Class2556.Enum209.const_16;
					}
				}
			}
			else if (Operators.CompareString(string_0, "CHAINSOFWAR", false) == 0)
			{
				return Class2556.Enum209.const_7;
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			return Class2556.Enum209.const_0;
		}

		// Token: 0x06008BC6 RID: 35782 RVA: 0x004B4D64 File Offset: 0x004B2F64
		public static List<Class2556.Enum209> smethod_13(Scenario.ScenarioFeatureOption scenarioFeatureOption_0)
		{
			List<Class2556.Enum209> list = new List<Class2556.Enum209>();
			List<Class2556.Enum209> result;
			if (scenarioFeatureOption_0 == Scenario.ScenarioFeatureOption.const_4)
			{
				list.Add(Class2556.Enum209.const_8);
				result = list;
			}
			else
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x04004BB4 RID: 19380
		public static AppId_t appId_t_0 = new AppId_t(1076160U);

		// Token: 0x04004BB5 RID: 19381
		private static Dictionary<Class2556.Enum209, Class2556.Struct78> dictionary_0 = new Dictionary<Class2556.Enum209, Class2556.Struct78>();

		// Token: 0x04004BB6 RID: 19382
		private static HashSet<Class2556.Enum209> hashSet_0 = new HashSet<Class2556.Enum209>();

		// Token: 0x02000F39 RID: 3897
		internal struct Struct78
		{
			// Token: 0x04004BB7 RID: 19383
			public string string_0;

			// Token: 0x04004BB8 RID: 19384
			public AppId_t appId_t_0;

			// Token: 0x04004BB9 RID: 19385
			public AppId_t appId_t_1;

			// Token: 0x04004BBA RID: 19386
			public string string_1;

			// Token: 0x04004BBB RID: 19387
			public string string_2;

			// Token: 0x04004BBC RID: 19388
			public string string_3;

			// Token: 0x04004BBD RID: 19389
			public string string_4;

			// Token: 0x04004BBE RID: 19390
			public Color color_0;
		}

		// Token: 0x02000F3A RID: 3898
		internal enum Enum209
		{
			// Token: 0x04004BC0 RID: 19392
			const_0,
			// Token: 0x04004BC1 RID: 19393
			const_1,
			// Token: 0x04004BC2 RID: 19394
			const_2,
			// Token: 0x04004BC3 RID: 19395
			const_3,
			// Token: 0x04004BC4 RID: 19396
			const_4,
			// Token: 0x04004BC5 RID: 19397
			const_5,
			// Token: 0x04004BC6 RID: 19398
			const_6,
			// Token: 0x04004BC7 RID: 19399
			const_7,
			// Token: 0x04004BC8 RID: 19400
			const_8,
			// Token: 0x04004BC9 RID: 19401
			const_9,
			// Token: 0x04004BCA RID: 19402
			const_10,
			// Token: 0x04004BCB RID: 19403
			const_11,
			// Token: 0x04004BCC RID: 19404
			const_12,
			// Token: 0x04004BCD RID: 19405
			const_13,
			// Token: 0x04004BCE RID: 19406
			const_14,
			// Token: 0x04004BCF RID: 19407
			const_15,
			// Token: 0x04004BD0 RID: 19408
			const_16
		}
	}
}
