using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace Command_Core
{
	// Token: 0x020003CA RID: 970
	[StandardModule]
	public sealed class Weather
	{
		// Token: 0x06001D25 RID: 7461 RVA: 0x0021E990 File Offset: 0x0021CB90
		public static Weather.WeatherProfile smethod_0(Scenario scenario_0, double double_0, double double_1, int int_0)
		{
			Scenario.WeatherModellingLevel weatherLevel = scenario_0.WeatherLevel;
			if (weatherLevel != Scenario.WeatherModellingLevel.Level0)
			{
				throw new NotImplementedException();
			}
			return scenario_0.method_23();
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0021E9B8 File Offset: 0x0021CBB8
		public static double smethod_1(double double_0)
		{
			double num = 157.0 / (157.0 - double_0);
			return 6371.0 * num;
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x0021E9E8 File Offset: 0x0021CBE8
		public static void smethod_2(Weather.Enum140 AtmosphereType, int Altitude, ref Weather.Struct46 Atmosphere, float? TemperatureAtSL_Celcius = null)
		{
			double num = (double)Altitude / 1000.0;
			if (Information.IsNothing(TemperatureAtSL_Celcius))
			{
				TemperatureAtSL_Celcius = new float?(15f);
			}
			float num2 = (float)(((TemperatureAtSL_Celcius != null) ? new double?((double)TemperatureAtSL_Celcius.GetValueOrDefault()) : null) + 273.15).Value;
			switch (AtmosphereType)
			{
			case Weather.Enum140.const_0:
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_0 = 1012.8186 - 111.5569 * num + 3.8646 * num * num;
				}
				else if (num > 10.0 & num <= 72.0)
				{
					Atmosphere.double_0 = 283.709 * Math.Exp(-0.147 * (num - 10.0));
				}
				else if (num > 72.0 & num <= 100.0)
				{
					Atmosphere.double_0 = 0.0312402229 * Math.Exp(-0.165 * (num - 72.0));
				}
				else
				{
					Atmosphere.double_0 = 0.0;
				}
				if (num >= 0.0 & num <= 13.0)
				{
					Atmosphere.double_1 = 294.9838 - 5.2159 * num - 0.07109 * num * num;
				}
				else if (num > 13.0 & num <= 17.0)
				{
					Atmosphere.double_1 = 215.15;
				}
				else if (num > 17.0 & num <= 47.0)
				{
					Atmosphere.double_1 = 215.15 * Math.Exp(0.008128 * (num - 17.0));
				}
				else if (num > 47.0 & num <= 53.0)
				{
					Atmosphere.double_1 = 275.0;
				}
				else if (num > 53.0 & num <= 80.0)
				{
					Atmosphere.double_1 = 275.0 + 20.0 * (1.0 - Math.Exp(0.06 * (num - 53.0)));
				}
				else if (num > 80.0 & num <= 100.0)
				{
					Atmosphere.double_1 = 175.0;
				}
				else
				{
					Atmosphere.double_1 = 0.0;
				}
				if (num >= 0.0 & num <= 15.0)
				{
					Atmosphere.double_2 = 14.2542 * Math.Exp(-0.4174 * num - 0.0229 * num * num + 0.001007 * num * num * num);
					return;
				}
				Atmosphere.double_2 = 0.0;
				return;
			case Weather.Enum140.const_1:
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_0 = 1018.8627 - 124.2954 * num + 4.8307 * num * num;
				}
				else if (num > 10.0 & num <= 72.0)
				{
					Atmosphere.double_0 = 258.9787 * Math.Exp(-0.147 * (num - 10.0));
				}
				else if (num > 72.0 & num <= 100.0)
				{
					Atmosphere.double_0 = 0.0285170199 * Math.Exp(-0.155 * (num - 72.0));
				}
				else
				{
					Atmosphere.double_0 = 0.0;
				}
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_1 = 272.7241 - 3.6217 * num - 0.1759 * num * num;
				}
				else if (num > 10.0 & num <= 33.0)
				{
					Atmosphere.double_1 = 218.0;
				}
				else if (num > 33.0 & num <= 47.0)
				{
					Atmosphere.double_1 = 218.0 + 3.3571 * (num - 33.0);
				}
				else if (num > 47.0 & num <= 53.0)
				{
					Atmosphere.double_1 = 265.0;
				}
				else if (num > 53.0 & num <= 80.0)
				{
					Atmosphere.double_1 = 265.0 - 2.037 * (num - 53.0);
				}
				else if (num > 80.0 & num <= 100.0)
				{
					Atmosphere.double_1 = 210.0;
				}
				else
				{
					Atmosphere.double_1 = 0.0;
				}
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_2 = 3.4742 * Math.Exp(-0.2697 * num - 0.03604 * num * num + 0.0004489 * num * num * num);
					return;
				}
				Atmosphere.double_2 = 0.0;
				return;
			case Weather.Enum140.const_2:
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_0 = 1008.0278 - 113.2494 * num + 3.9408 * num * num;
				}
				else if (num > 10.0 & num <= 72.0)
				{
					Atmosphere.double_0 = 269.6138 * Math.Exp(-0.14 * (num - 10.0));
				}
				else if (num > 72.0 & num <= 100.0)
				{
					Atmosphere.double_0 = 0.0458211532 * Math.Exp(-0.165 * (num - 72.0));
				}
				else
				{
					Atmosphere.double_0 = 0.0;
				}
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_1 = 286.8374 - 4.7805 * num - 0.1402 * num * num;
				}
				else if (num > 10.0 & num <= 23.0)
				{
					Atmosphere.double_1 = 225.0;
				}
				else if (num > 23.0 & num <= 48.0)
				{
					Atmosphere.double_1 = 225.0 * Math.Exp(0.008317 * (num - 23.0));
				}
				else if (num > 48.0 & num <= 53.0)
				{
					Atmosphere.double_1 = 277.0;
				}
				else if (num > 53.0 & num <= 79.0)
				{
					Atmosphere.double_1 = 277.0 - 4.0769 * (num - 53.0);
				}
				else if (num > 79.0 & num <= 100.0)
				{
					Atmosphere.double_1 = 171.0;
				}
				else
				{
					Atmosphere.double_1 = 0.0;
				}
				if (num >= 0.0 & num <= 15.0)
				{
					Atmosphere.double_2 = 8.988 * Math.Exp(-0.3614 * num - 0.005402 * num * num - 0.001955 * num * num * num);
					return;
				}
				Atmosphere.double_2 = 0.0;
				return;
			case Weather.Enum140.const_3:
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_0 = 1010.8828 - 122.2411 * num + 4.554 * num * num;
				}
				else if (num > 10.0 & num <= 72.0)
				{
					Atmosphere.double_0 = 243.8718 * Math.Exp(-0.147 * (num - 10.0));
				}
				else if (num > 72.0 & num <= 100.0)
				{
					Atmosphere.double_0 = 0.0268535481 * Math.Exp(-0.15 * (num - 72.0));
				}
				else
				{
					Atmosphere.double_0 = 0.0;
				}
				if (num >= 0.0 & num <= 8.5)
				{
					Atmosphere.double_1 = 257.4345 + 2.3474 * num - 1.5479 * num * num + 0.08473 * num * num * num;
				}
				else if (num > 8.5 & num <= 30.0)
				{
					Atmosphere.double_1 = 217.5;
				}
				else if (num > 30.0 & num <= 50.0)
				{
					Atmosphere.double_1 = 217.5 + 2.125 * (num - 30.0);
				}
				else if (num > 50.0 & num <= 54.0)
				{
					Atmosphere.double_1 = 260.0;
				}
				else if (num > 54.0 & num <= 100.0)
				{
					Atmosphere.double_1 = 260.0 - 1.667 * (num - 54.0);
				}
				else
				{
					Atmosphere.double_1 = 0.0;
				}
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_2 = 1.2319 * Math.Exp(0.07481 * num - 0.0981 * num * num + 0.00281 * num * num * num);
					return;
				}
				Atmosphere.double_2 = 0.0;
				return;
			case Weather.Enum140.const_4:
				if (num >= 0.0 & num <= 10.0)
				{
					Atmosphere.double_0 = 1012.0306 - 109.0338 * num + 3.6316 * num * num;
				}
				else if (num > 10.0 & num <= 72.0)
				{
					Atmosphere.double_0 = 284.8526 * Math.Exp(-0.147 * (num - 10.0));
				}
				else if (num > 72.0 & num <= 100.0)
				{
					Atmosphere.double_0 = 0.0313660825 * Math.Exp(-0.165 * (num - 72.0));
				}
				else
				{
					Atmosphere.double_0 = 0.0;
				}
				if (num >= 0.0 & num <= 17.0)
				{
					Atmosphere.double_1 = 300.4222 - 6.3533 * num + 0.005886 * num * num;
				}
				else if (num > 17.0 & num <= 47.0)
				{
					Atmosphere.double_1 = 194.0 + 2.533 * (num - 17.0);
				}
				else if (num > 47.0 & num <= 52.0)
				{
					Atmosphere.double_1 = 270.0;
				}
				else if (num > 52.0 & num <= 80.0)
				{
					Atmosphere.double_1 = 270.0 - 3.0714 * (num - 52.0);
				}
				else if (num > 80.0 & num <= 100.0)
				{
					Atmosphere.double_1 = 184.0;
				}
				else
				{
					Atmosphere.double_1 = 0.0;
				}
				if (num >= 0.0 & num <= 15.0)
				{
					Atmosphere.double_2 = 19.6542 * Math.Exp(-0.2313 * num - 0.1122 * num * num + 0.01351 * num * num * num - 0.0005923 * num * num * num * num);
					return;
				}
				Atmosphere.double_2 = 0.0;
				return;
			case Weather.Enum140.const_5:
				if (num >= 0.0 & num <= 11.0)
				{
					Atmosphere.double_0 = 1013.25 * Math.Pow(288.15 / (288.15 + -6.5 * num), -5.255846153846154);
				}
				else if (num > 11.0 & num <= 20.0)
				{
					Atmosphere.double_0 = 226.3226 * Math.Exp(-34.163 * (num - 11.0) / 216.65);
				}
				else if (num > 20.0 & num <= 32.0)
				{
					Atmosphere.double_0 = 54.7498 * Math.Pow(216.65 / (216.65 + 1.0 * (num - 20.0)), 34.163);
				}
				else if (num > 32.0 & num <= 47.0)
				{
					Atmosphere.double_0 = 8.6804 * Math.Pow(228.65 / (228.65 + 2.8 * (num - 32.0)), 12.201071428571428);
				}
				else if (num > 47.0 & num <= 51.0)
				{
					Atmosphere.double_0 = 1.1091 * Math.Exp(-34.163 * (num - 47.0) / 270.65);
				}
				else if (num > 51.0 & num <= 71.0)
				{
					Atmosphere.double_0 = 0.6694 * Math.Pow(270.65 / (270.65 + -2.8 * (num - 51.0)), -12.201071428571428);
				}
				else if (num > 71.0 & num <= 100.0)
				{
					Atmosphere.double_0 = 0.0396 * Math.Pow(214.65 / (214.65 + -2.0 * (num - 71.0)), -17.0815);
				}
				else
				{
					Atmosphere.double_0 = 0.0;
				}
				if (num >= 0.0 & num <= 20.0)
				{
					Atmosphere.double_1 = (double)num2 + -6.5 * num;
				}
				else if (num > 20.0 & num <= 32.0)
				{
					Atmosphere.double_1 = (double)num2 - 71.5 + (num - 20.0);
				}
				else if (num > 32.0 & num <= 47.0)
				{
					Atmosphere.double_1 = (double)num2 - 59.5 + 2.8 * (num - 32.0);
				}
				else if (num > 47.0 & num <= 51.0)
				{
					Atmosphere.double_1 = (double)num2 - 17.5;
				}
				else if (num > 51.0 & num <= 71.0)
				{
					Atmosphere.double_1 = (double)num2 - 17.85 - 2.8 * (num - 51.0);
				}
				else if (num > 71.0 & num <= 100.0)
				{
					Atmosphere.double_1 = (double)num2 - 73.65 - 2.0 * (num - 71.0);
				}
				else
				{
					Atmosphere.double_1 = 0.0;
				}
				if (num <= 100.0)
				{
					Atmosphere.double_2 = 7.5 * Math.Exp(-0.5 * num);
					if (Atmosphere.double_2 * Atmosphere.double_1 / 216.7 / Atmosphere.double_0 < 2E-06)
					{
						double num3 = 2E-06 * Atmosphere.double_0;
						Atmosphere.double_2 = num3 * 216.7 / Atmosphere.double_1;
					}
				}
				return;
			default:
				return;
			}
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x0021FDB4 File Offset: 0x0021DFB4
		public static double smethod_3(double double_0, double double_1, double double_2)
		{
			double num = double_0 + 273.15;
			double d = 25.22 * (double_0 / num) - 5.31 * Math.Log(num / 273.15);
			double num2 = double_2 * 6.105 * Math.Exp(d) / 100.0;
			return 77.6 * double_1 / num + num2 * 373000.0 / (num * num);
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x0021FE34 File Offset: 0x0021E034
		public static double smethod_4(int int_0)
		{
			double result = 0.0;
			switch (int_0)
			{
			case 0:
				result = 0.0;
				break;
			case 1:
				result = 3.131;
				break;
			case 2:
				result = 7.67;
				break;
			case 3:
				result = 13.099;
				break;
			case 4:
				result = 19.175;
				break;
			case 5:
				result = 25.246;
				break;
			case 6:
				result = 31.313;
				break;
			case 7:
				result = 38.351;
				break;
			case 8:
				result = 47.489;
				break;
			case 9:
				result = 54.237;
				break;
			}
			return result;
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x0000E4AF File Offset: 0x0000C6AF
		public static Weather.WeatherProfile smethod_5()
		{
			return new Weather.WeatherProfile();
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x0021FEF4 File Offset: 0x0021E0F4
		public static bool smethod_6(Unit unit_0, Unit unit_1, ref Scenario scenario_0)
		{
			float num = Weather.smethod_0(scenario_0, unit_1.vmethod_30(null), unit_1.vmethod_28(null), (int)Math.Round((double)unit_1.vmethod_14(false))).method_3();
			bool result;
			if (num > 0.9f)
			{
				result = (!unit_0.bool_6 && !unit_0.bool_5 && !unit_0.bool_8 && (!unit_1.bool_6 && !unit_1.bool_5 && !unit_1.bool_8) && ((unit_0.vmethod_14(false) >= 10972.8f && unit_1.vmethod_14(false) >= 10972.8f) || (unit_0.vmethod_13() >= 609.6f && unit_0.vmethod_14(false) <= 2133.6f && unit_1.vmethod_13() >= 609.6f && unit_1.vmethod_14(false) <= 2133.6f)));
			}
			else if (num > 0.8f)
			{
				result = ((unit_0.vmethod_14(false) >= 10972.8f && unit_1.vmethod_14(false) >= 10972.8f) || (unit_0.vmethod_13() >= 609.6f && unit_0.vmethod_14(false) <= 2133.6f && unit_1.vmethod_13() >= 609.6f && unit_1.vmethod_14(false) <= 2133.6f) || ((unit_0.vmethod_13() < 2000f || unit_1.vmethod_13() < 2000f) && Math.Abs(unit_0.vmethod_14(false) - unit_1.vmethod_14(false)) < 304.8f));
			}
			else if (num > 0.7f)
			{
				result = ((unit_0.vmethod_14(false) >= 10972.8f && unit_1.vmethod_14(false) >= 10972.8f) || (unit_0.vmethod_14(false) >= 4876.8f && unit_0.vmethod_14(false) <= 9144f && unit_1.vmethod_14(false) >= 4876.8f && unit_1.vmethod_14(false) <= 9144f) || (unit_0.vmethod_14(false) <= 2133.6f && unit_1.vmethod_14(false) <= 2133.6f) || (unit_0.vmethod_14(false) >= 4876.8f && unit_1.vmethod_14(false) >= 4876.8f && Math.Abs(unit_0.vmethod_14(false) - unit_1.vmethod_14(false)) < 762f));
			}
			else if (num > 0.6f)
			{
				if (unit_0.vmethod_14(false) >= 9144f && unit_1.vmethod_14(false) >= 9144f)
				{
					result = true;
				}
				else if (unit_0.vmethod_14(false) >= 4876.8f && unit_0.vmethod_14(false) <= 8229.6f && unit_1.vmethod_14(false) >= 4876.8f && unit_1.vmethod_14(false) <= 8229.6f)
				{
					result = true;
				}
				else if (unit_0.vmethod_14(false) <= 2133.6f && unit_1.vmethod_14(false) <= 2133.6f)
				{
					result = true;
				}
				else
				{
					if (unit_0.vmethod_14(false) >= 4876.8f && unit_1.vmethod_14(false) >= 4876.8f)
					{
						if (Math.Abs(unit_0.vmethod_14(false) - unit_1.vmethod_14(false)) < 1524f)
						{
							return true;
						}
					}
					else if (Math.Abs(unit_0.vmethod_14(false) - unit_1.vmethod_14(false)) < 762f)
					{
						return true;
					}
					result = false;
				}
			}
			else if (num > 0.5f)
			{
				result = ((unit_0.vmethod_14(false) >= 8534.4f && unit_1.vmethod_14(false) >= 8534.4f) || (unit_0.vmethod_14(false) <= 7620f && unit_1.vmethod_14(false) <= 7620f) || Math.Abs(unit_0.vmethod_14(false) - unit_1.vmethod_14(false)) < 762f);
			}
			else if (num > 0.4f)
			{
				result = ((unit_0.vmethod_14(false) >= 4876.8f && unit_1.vmethod_14(false) >= 4876.8f) || (unit_0.vmethod_14(false) <= 2133.6f && unit_1.vmethod_14(false) <= 2133.6f) || Math.Abs(unit_0.vmethod_14(false) - unit_1.vmethod_14(false)) < 762f);
			}
			else if (num > 0.3f)
			{
				result = ((unit_0.vmethod_14(false) >= 2133.6f && unit_1.vmethod_14(false) >= 2133.6f) || (unit_0.vmethod_14(false) <= 609.6f && unit_1.vmethod_14(false) <= 609.6f) || Math.Abs(unit_0.vmethod_14(false) - unit_1.vmethod_14(false)) < 762f);
			}
			else if (num > 0.2f)
			{
				result = ((unit_0.vmethod_14(false) >= 7010.4f && unit_1.vmethod_14(false) >= 7010.4f) || (unit_0.vmethod_14(false) <= 6096f && unit_1.vmethod_14(false) <= 6096f) || Math.Abs(unit_0.vmethod_14(false) - unit_1.vmethod_14(false)) < 1524f);
			}
			else if (num > 0.1f)
			{
				result = ((unit_0.vmethod_14(false) >= 4876.8f && unit_1.vmethod_14(false) >= 4876.8f) || (unit_0.vmethod_14(false) <= 3048f && unit_1.vmethod_14(false) <= 3048f) || Math.Abs(unit_0.vmethod_14(false) - unit_1.vmethod_14(false)) < 1524f);
			}
			else
			{
				result = (num <= 0f || (unit_0.vmethod_14(false) >= 2133.6f && unit_1.vmethod_14(false) >= 2133.6f) || (unit_0.vmethod_14(false) <= 1524f && unit_1.vmethod_14(false) <= 1524f) || Math.Abs(unit_0.vmethod_14(false) - unit_1.vmethod_14(false)) < 1524f);
			}
			return result;
		}

		// Token: 0x020003CB RID: 971
		public enum TTimeOfDayType : byte
		{
			// Token: 0x04001BB2 RID: 7090
			const_0,
			// Token: 0x04001BB3 RID: 7091
			const_1,
			// Token: 0x04001BB4 RID: 7092
			const_2
		}

		// Token: 0x020003CC RID: 972
		internal enum Enum137 : byte
		{
			// Token: 0x04001BB6 RID: 7094
			const_0,
			// Token: 0x04001BB7 RID: 7095
			const_1 = 8,
			// Token: 0x04001BB8 RID: 7096
			const_2,
			// Token: 0x04001BB9 RID: 7097
			const_3
		}

		// Token: 0x020003CD RID: 973
		internal enum Enum138 : byte
		{
			// Token: 0x04001BBB RID: 7099
			const_0,
			// Token: 0x04001BBC RID: 7100
			const_1 = 5,
			// Token: 0x04001BBD RID: 7101
			const_2,
			// Token: 0x04001BBE RID: 7102
			const_3
		}

		// Token: 0x020003CE RID: 974
		internal enum Enum139 : byte
		{
			// Token: 0x04001BC0 RID: 7104
			const_0,
			// Token: 0x04001BC1 RID: 7105
			const_1,
			// Token: 0x04001BC2 RID: 7106
			const_2,
			// Token: 0x04001BC3 RID: 7107
			const_3,
			// Token: 0x04001BC4 RID: 7108
			const_4
		}

		// Token: 0x020003CF RID: 975
		internal struct Struct45
		{
			// Token: 0x04001BC5 RID: 7109
			public Weather.Enum139 enum139_0;

			// Token: 0x04001BC6 RID: 7110
			public int int_0;

			// Token: 0x04001BC7 RID: 7111
			public int int_1;

			// Token: 0x04001BC8 RID: 7112
			public int int_2;

			// Token: 0x04001BC9 RID: 7113
			public Weather.Enum138 enum138_0;

			// Token: 0x04001BCA RID: 7114
			public int int_3;

			// Token: 0x04001BCB RID: 7115
			public int int_4;

			// Token: 0x04001BCC RID: 7116
			public int int_5;

			// Token: 0x04001BCD RID: 7117
			public Weather.Enum137 enum137_0;

			// Token: 0x04001BCE RID: 7118
			public int int_6;

			// Token: 0x04001BCF RID: 7119
			public int int_7;

			// Token: 0x04001BD0 RID: 7120
			public int int_8;
		}

		// Token: 0x020003D0 RID: 976
		public sealed class WeatherProfile
		{
			// Token: 0x06001D2C RID: 7468 RVA: 0x00220528 File Offset: 0x0021E728
			public WeatherProfile()
			{
				this.lazy_0 = new Lazy<ConcurrentDictionary<double, double>>();
				this.method_7(15.0);
				this.method_9(1013.25);
				this.method_11(86.17);
				this.double_3 = 0.0;
				this.method_13(39.0);
				this.double_6 = 0.0;
				this.double_7 = 0.0;
				this.float_0 = 0f;
				this.method_4(0f);
				this.int_0 = 0;
			}

			// Token: 0x06001D2D RID: 7469 RVA: 0x002205CC File Offset: 0x0021E7CC
			public void method_0(ref XmlWriter xmlWriter_0)
			{
				xmlWriter_0.WriteStartElement("WeatherProfile");
				xmlWriter_0.WriteElementString("Temp", XmlConvert.ToString(this.method_6()));
				xmlWriter_0.WriteElementString("Pressure", XmlConvert.ToString(this.method_8()));
				xmlWriter_0.WriteElementString("RL", XmlConvert.ToString(this.method_10()));
				xmlWriter_0.WriteElementString("GRC", XmlConvert.ToString(this.double_3));
				xmlWriter_0.WriteElementString("DN", XmlConvert.ToString(this.method_12()));
				xmlWriter_0.WriteElementString("SDH", XmlConvert.ToString(this.double_6));
				xmlWriter_0.WriteElementString("EDH", XmlConvert.ToString(this.double_7));
				xmlWriter_0.WriteElementString("RFR", XmlConvert.ToString(this.float_0));
				xmlWriter_0.WriteElementString("FUR", XmlConvert.ToString(this.method_3()));
				xmlWriter_0.WriteElementString("SS", XmlConvert.ToString(this.int_0));
				xmlWriter_0.WriteEndElement();
			}

			// Token: 0x06001D2E RID: 7470 RVA: 0x002206D4 File Offset: 0x0021E8D4
			public static Weather.WeatherProfile smethod_0(ref XmlNode xmlNode_0)
			{
				Weather.WeatherProfile weatherProfile = new Weather.WeatherProfile();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes[0].ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 2164589563U)
						{
							if (num <= 1078463463U)
							{
								if (num != 520028718U)
								{
									if (num == 1078463463U)
									{
										if (Operators.CompareString(name, "Temp", false) == 0)
										{
											weatherProfile.method_7(XmlConvert.ToDouble(xmlNode.InnerText));
										}
									}
								}
								else if (Operators.CompareString(name, "SDH", false) == 0)
								{
									weatherProfile.double_6 = XmlConvert.ToDouble(xmlNode.InnerText);
								}
							}
							else if (num != 1120831591U)
							{
								if (num != 1711446755U)
								{
									if (num == 2164589563U)
									{
										if (Operators.CompareString(name, "RL", false) == 0)
										{
											weatherProfile.method_11(XmlConvert.ToDouble(xmlNode.InnerText));
										}
									}
								}
								else if (Operators.CompareString(name, "SS", false) == 0)
								{
									weatherProfile.int_0 = (int)XmlConvert.ToInt16(xmlNode.InnerText);
								}
							}
							else if (Operators.CompareString(name, "DN", false) == 0)
							{
								weatherProfile.method_13(XmlConvert.ToDouble(xmlNode.InnerText));
							}
						}
						else if (num <= 2804646028U)
						{
							if (num != 2211899073U)
							{
								if (num == 2804646028U)
								{
									if (Operators.CompareString(name, "EDH", false) == 0)
									{
										weatherProfile.double_7 = XmlConvert.ToDouble(xmlNode.InnerText);
									}
								}
							}
							else if (Operators.CompareString(name, "RFR", false) == 0)
							{
								weatherProfile.float_0 = (float)XmlConvert.ToInt32(xmlNode.InnerText);
							}
						}
						else if (num != 2886844557U)
						{
							if (num != 3324005570U)
							{
								if (num == 4155875938U)
								{
									if (Operators.CompareString(name, "FUR", false) == 0)
									{
										weatherProfile.method_4((float)XmlConvert.ToDouble(xmlNode.InnerText));
									}
								}
							}
							else if (Operators.CompareString(name, "Pressure", false) == 0)
							{
								weatherProfile.method_9(XmlConvert.ToDouble(xmlNode.InnerText));
							}
						}
						else if (Operators.CompareString(name, "GRC", false) == 0)
						{
							weatherProfile.double_3 = XmlConvert.ToDouble(xmlNode.InnerText);
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
				return weatherProfile;
			}

			// Token: 0x06001D2F RID: 7471 RVA: 0x00220958 File Offset: 0x0021EB58
			public short method_1(Weather.TTimeOfDayType ttimeOfDayType_0)
			{
				short result;
				switch (ttimeOfDayType_0)
				{
				case Weather.TTimeOfDayType.const_0:
					result = (short)Math.Round(this.method_6() + 10.0);
					break;
				case Weather.TTimeOfDayType.const_1:
					result = (short)Math.Round(this.method_6());
					break;
				case Weather.TTimeOfDayType.const_2:
					result = (short)Math.Round(this.method_6() - 10.0);
					break;
				default:
					throw new NotImplementedException();
				}
				return result;
			}

			// Token: 0x06001D30 RID: 7472 RVA: 0x002209C0 File Offset: 0x0021EBC0
			public string method_2()
			{
				float num = this.float_0;
				string result;
				if (num == 0f)
				{
					result = "No rain";
				}
				else if (num < 5f)
				{
					result = "Very light rain";
				}
				else if (num < 10f)
				{
					result = "Light rain";
				}
				else if (num < 20f)
				{
					result = "Moderate rain";
				}
				else if (num < 30f)
				{
					result = "Heavy rain";
				}
				else if (num < 40f)
				{
					result = "Very heavy rain";
				}
				else
				{
					result = "Extreme rain";
				}
				return result;
			}

			// Token: 0x06001D31 RID: 7473 RVA: 0x0000E4B6 File Offset: 0x0000C6B6
			public float method_3()
			{
				return this.float_1;
			}

			// Token: 0x06001D32 RID: 7474 RVA: 0x00220A3C File Offset: 0x0021EC3C
			public void method_4(float float_2)
			{
				this.float_1 = float_2;
				float num = (float)((double)this.float_1 - 0.001);
				if (this.float_1 == 0f)
				{
					num = 0f;
				}
				if ((double)num > 0.9)
				{
					this.struct45_0.int_7 = 10973;
					this.struct45_0.int_6 = 2134;
					this.struct45_0.int_8 = 8;
					this.struct45_0.int_4 = 0;
					this.struct45_0.int_3 = 0;
					this.struct45_0.int_5 = 0;
					this.struct45_0.int_1 = 610;
					this.struct45_0.int_0 = 0;
					this.struct45_0.int_2 = 8;
					return;
				}
				if ((double)num > 0.8)
				{
					this.struct45_0.int_7 = 10973;
					this.struct45_0.int_6 = 2134;
					this.struct45_0.int_8 = 8;
					this.struct45_0.int_4 = 0;
					this.struct45_0.int_3 = 0;
					this.struct45_0.int_5 = 0;
					this.struct45_0.int_1 = 610;
					this.struct45_0.int_0 = 0;
					this.struct45_0.int_2 = 2;
					return;
				}
				if ((double)num > 0.7)
				{
					this.struct45_0.int_7 = 10973;
					this.struct45_0.int_6 = 9144;
					this.struct45_0.int_8 = 4;
					this.struct45_0.int_4 = 4877;
					this.struct45_0.int_3 = 2134;
					this.struct45_0.int_5 = 8;
					this.struct45_0.int_1 = 0;
					this.struct45_0.int_0 = 0;
					this.struct45_0.int_2 = 0;
					return;
				}
				if ((double)num > 0.6)
				{
					this.struct45_0.int_7 = 9144;
					this.struct45_0.int_6 = 8230;
					this.struct45_0.int_8 = 2;
					this.struct45_0.int_4 = 4877;
					this.struct45_0.int_3 = 2134;
					this.struct45_0.int_5 = 4;
					this.struct45_0.int_1 = 0;
					this.struct45_0.int_0 = 0;
					this.struct45_0.int_2 = 0;
					return;
				}
				if ((double)num > 0.5)
				{
					this.struct45_0.int_7 = 0;
					this.struct45_0.int_6 = 0;
					this.struct45_0.int_8 = 0;
					this.struct45_0.int_4 = 8534;
					this.struct45_0.int_3 = 7620;
					this.struct45_0.int_5 = 4;
					this.struct45_0.int_1 = 0;
					this.struct45_0.int_0 = 0;
					this.struct45_0.int_2 = 0;
					return;
				}
				if ((double)num > 0.4)
				{
					this.struct45_0.int_7 = 0;
					this.struct45_0.int_6 = 0;
					this.struct45_0.int_8 = 0;
					this.struct45_0.int_4 = 4877;
					this.struct45_0.int_3 = 2134;
					this.struct45_0.int_5 = 4;
					this.struct45_0.int_1 = 0;
					this.struct45_0.int_0 = 0;
					this.struct45_0.int_2 = 0;
					return;
				}
				if ((double)num > 0.3)
				{
					this.struct45_0.int_7 = 0;
					this.struct45_0.int_6 = 0;
					this.struct45_0.int_8 = 0;
					this.struct45_0.int_4 = 0;
					this.struct45_0.int_3 = 0;
					this.struct45_0.int_5 = 0;
					this.struct45_0.int_1 = 2134;
					this.struct45_0.int_0 = 610;
					this.struct45_0.int_2 = 4;
					return;
				}
				if ((double)num > 0.2)
				{
					this.struct45_0.int_7 = 0;
					this.struct45_0.int_6 = 0;
					this.struct45_0.int_8 = 0;
					this.struct45_0.int_4 = 7010;
					this.struct45_0.int_3 = 6096;
					this.struct45_0.int_5 = 2;
					this.struct45_0.int_1 = 0;
					this.struct45_0.int_0 = 0;
					this.struct45_0.int_2 = 0;
					return;
				}
				if ((double)num > 0.1)
				{
					this.struct45_0.int_7 = 0;
					this.struct45_0.int_6 = 0;
					this.struct45_0.int_8 = 0;
					this.struct45_0.int_4 = 4877;
					this.struct45_0.int_3 = 3048;
					this.struct45_0.int_5 = 2;
					this.struct45_0.int_1 = 0;
					this.struct45_0.int_0 = 0;
					this.struct45_0.int_2 = 0;
					return;
				}
				if ((double)num > 0.0)
				{
					this.struct45_0.int_7 = 0;
					this.struct45_0.int_6 = 0;
					this.struct45_0.int_8 = 0;
					this.struct45_0.int_4 = 0;
					this.struct45_0.int_3 = 0;
					this.struct45_0.int_5 = 0;
					this.struct45_0.int_1 = 2134;
					this.struct45_0.int_0 = 1524;
					this.struct45_0.int_2 = 2;
					return;
				}
				this.struct45_0.int_7 = 0;
				this.struct45_0.int_6 = 0;
				this.struct45_0.int_8 = 0;
				this.struct45_0.int_4 = 0;
				this.struct45_0.int_3 = 0;
				this.struct45_0.int_5 = 0;
				this.struct45_0.int_1 = 0;
				this.struct45_0.int_0 = 0;
				this.struct45_0.int_2 = 0;
			}

			// Token: 0x06001D33 RID: 7475 RVA: 0x00221010 File Offset: 0x0021F210
			public string method_5()
			{
				float num = this.method_3();
				string result;
				if (num > 0.9f)
				{
					if (Class570.class280_0.method_12())
					{
						result = "Thick fog 0 - 2k ft, solid cloud cover 7 - 36k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Thick fog 0 - ",
							Conversions.ToString(1),
							"km, solid cloud cover ",
							Conversions.ToString(2),
							" - ",
							Conversions.ToString(11),
							" km"
						});
					}
				}
				else if (num > 0.8f)
				{
					if (Class570.class280_0.method_12())
					{
						result = "Thin fog 0 - 2k ft, solid cloud cover 7 - 36k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Thin fog 0 - ",
							Conversions.ToString(1),
							"km, solid cloud cover ",
							Conversions.ToString(2),
							" - ",
							Conversions.ToString(11),
							" km"
						});
					}
				}
				else if (num > 0.7f)
				{
					if (Class570.class280_0.method_12())
					{
						result = "Solid middle clouds 7 - 16k ft, moderate high clouds 30 - 36k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Solid middle clouds ",
							Conversions.ToString(2),
							" - ",
							Conversions.ToString(5),
							" km, moderate high clouds ",
							Conversions.ToString(9),
							" - ",
							Conversions.ToString(11),
							" km"
						});
					}
				}
				else if (num > 0.6f)
				{
					if (Class570.class280_0.method_12())
					{
						result = "Moderate middle clouds 7 - 16k ft, light high clouds 27 - 30k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Moderate middle clouds ",
							Conversions.ToString(2),
							" - ",
							Conversions.ToString(5),
							" km, light high clouds ",
							Conversions.ToString(8),
							" - ",
							Conversions.ToString(9),
							" km"
						});
					}
				}
				else if (num > 0.5f)
				{
					if (Class570.class280_0.method_12())
					{
						result = "Moderate high clouds 25 - 28k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Moderate high clouds ",
							Conversions.ToString(8),
							" - ",
							Conversions.ToString(9),
							" km"
						});
					}
				}
				else if (num > 0.4f)
				{
					if (Class570.class280_0.method_12())
					{
						result = "Moderate middle clouds 7 - 16k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Moderate middle clouds ",
							Conversions.ToString(2),
							" - ",
							Conversions.ToString(5),
							" km"
						});
					}
				}
				else if (num > 0.3f)
				{
					if (Class570.class280_0.method_12())
					{
						result = "Moderate low clouds 2 - 7k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Moderate low clouds ",
							Conversions.ToString(1),
							" - ",
							Conversions.ToString(2),
							" km"
						});
					}
				}
				else if (num > 0.2f)
				{
					if (Class570.class280_0.method_12())
					{
						result = "Light high clouds 20 - 23k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Light high clouds ",
							Conversions.ToString(6),
							" - ",
							Conversions.ToString(7),
							" km"
						});
					}
				}
				else if (num > 0.1f)
				{
					if (Class570.class280_0.method_12())
					{
						result = "Light middle clouds 10 - 16k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Light middle clouds ",
							Conversions.ToString(3),
							" - ",
							Conversions.ToString(5),
							" km"
						});
					}
				}
				else if (num > 0f)
				{
					if (Class570.class280_0.method_12())
					{
						result = "Light low clouds 5 - 7k ft";
					}
					else
					{
						result = string.Concat(new string[]
						{
							"Light low clouds ",
							Conversions.ToString(2),
							" - ",
							Conversions.ToString(2),
							" km"
						});
					}
				}
				else
				{
					result = "Clear sky";
				}
				return result;
			}

			// Token: 0x06001D34 RID: 7476 RVA: 0x0000E4BE File Offset: 0x0000C6BE
			public double method_6()
			{
				return this.double_0;
			}

			// Token: 0x06001D35 RID: 7477 RVA: 0x0000E4C6 File Offset: 0x0000C6C6
			public void method_7(double double_10)
			{
				if (this.double_0 != double_10)
				{
					this.double_0 = double_10;
					this.double_5 = Weather.smethod_3(this.double_0, this.double_1, this.double_2);
					this.lazy_0.Value.Clear();
				}
			}

			// Token: 0x06001D36 RID: 7478 RVA: 0x0000E505 File Offset: 0x0000C705
			public double method_8()
			{
				return this.double_1;
			}

			// Token: 0x06001D37 RID: 7479 RVA: 0x0000E50D File Offset: 0x0000C70D
			public void method_9(double double_10)
			{
				if (this.double_1 != double_10)
				{
					this.double_1 = double_10;
					this.double_5 = Weather.smethod_3(this.double_0, this.double_1, this.double_2);
					this.lazy_0.Value.Clear();
				}
			}

			// Token: 0x06001D38 RID: 7480 RVA: 0x0000E54C File Offset: 0x0000C74C
			public double method_10()
			{
				return this.double_2;
			}

			// Token: 0x06001D39 RID: 7481 RVA: 0x0000E554 File Offset: 0x0000C754
			public void method_11(double double_10)
			{
				if (this.double_2 != double_10)
				{
					this.double_2 = double_10;
					this.double_5 = Weather.smethod_3(this.double_0, this.double_1, this.double_2);
					this.lazy_0.Value.Clear();
				}
			}

			// Token: 0x06001D3A RID: 7482 RVA: 0x0000E593 File Offset: 0x0000C793
			public double method_12()
			{
				return this.double_4;
			}

			// Token: 0x06001D3B RID: 7483 RVA: 0x0000E59B File Offset: 0x0000C79B
			public void method_13(double double_10)
			{
				if (this.double_4 != double_10)
				{
					this.double_4 = double_10;
					this.double_8 = Weather.smethod_1(double_10);
					this.double_9 = 157.0 / (157.0 - this.method_12());
				}
			}

			// Token: 0x04001BD1 RID: 7121
			public Lazy<ConcurrentDictionary<double, double>> lazy_0;

			// Token: 0x04001BD2 RID: 7122
			protected double double_0;

			// Token: 0x04001BD3 RID: 7123
			protected double double_1;

			// Token: 0x04001BD4 RID: 7124
			protected double double_2;

			// Token: 0x04001BD5 RID: 7125
			public int int_0;

			// Token: 0x04001BD6 RID: 7126
			public float float_0;

			// Token: 0x04001BD7 RID: 7127
			private float float_1;

			// Token: 0x04001BD8 RID: 7128
			public Weather.Struct45 struct45_0;

			// Token: 0x04001BD9 RID: 7129
			public double double_3;

			// Token: 0x04001BDA RID: 7130
			protected double double_4;

			// Token: 0x04001BDB RID: 7131
			public double double_5;

			// Token: 0x04001BDC RID: 7132
			public double double_6;

			// Token: 0x04001BDD RID: 7133
			public double double_7;

			// Token: 0x04001BDE RID: 7134
			public double double_8;

			// Token: 0x04001BDF RID: 7135
			public double double_9;
		}

		// Token: 0x020003D1 RID: 977
		internal enum Enum140
		{
			// Token: 0x04001BE1 RID: 7137
			const_0,
			// Token: 0x04001BE2 RID: 7138
			const_1,
			// Token: 0x04001BE3 RID: 7139
			const_2,
			// Token: 0x04001BE4 RID: 7140
			const_3,
			// Token: 0x04001BE5 RID: 7141
			const_4,
			// Token: 0x04001BE6 RID: 7142
			const_5
		}

		// Token: 0x020003D2 RID: 978
		internal struct Struct46
		{
			// Token: 0x04001BE7 RID: 7143
			public double double_0;

			// Token: 0x04001BE8 RID: 7144
			public double double_1;

			// Token: 0x04001BE9 RID: 7145
			public double double_2;
		}
	}
}
