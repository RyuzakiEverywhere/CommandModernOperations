using System;
using System.Data.SQLite;
using System.Linq;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Command_Core
{
	// Token: 0x02000232 RID: 562
	public sealed class EmissionContainer
	{
		// Token: 0x06001181 RID: 4481 RVA: 0x0015CCB0 File Offset: 0x0015AEB0
		public Sensor method_0(int int_0, Scenario scenario_0)
		{
			if (this.sensor_0 == null && !scenario_0.Cache_AssociatedSensors.TryGetValue(int_0, out this.sensor_0))
			{
				SQLiteConnection sqliteConnection = scenario_0.method_39();
				this.sensor_0 = DBFunctions.smethod_97(int_0, ref sqliteConnection);
				try
				{
					scenario_0.Cache_AssociatedSensors.Add(int_0, this.sensor_0);
				}
				catch (Exception ex)
				{
				}
			}
			return this.sensor_0;
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x0015CD28 File Offset: 0x0015AF28
		public string method_1(int int_0, Scenario scenario_0)
		{
			if (Information.IsNothing(this.sensor_0))
			{
				SQLiteConnection sqliteConnection = scenario_0.method_39();
				this.sensor_0 = DBFunctions.smethod_97(int_0, ref sqliteConnection);
			}
			string result;
			if (this.sensor_0.method_72())
			{
				result = "JAMMER";
			}
			else
			{
				string text = "";
				if (this.bool_1)
				{
					text = this.sensor_0.Name + " (" + this.sensor_0.string_2 + ")";
				}
				else if (this.sensor_0.method_74())
				{
					if (Enumerable.Count<Sensor.RadioElectronicFrequency>(this.sensor_0.radioElectronicFrequency_0) > 0)
					{
						Sensor.FrequencyBand frequencyBand_ = this.sensor_0.radioElectronicFrequency_0[0].frequencyBand_0;
						long num = frequencyBand_ - Sensor.FrequencyBand.const_28;
						if (num <= 3L)
						{
							switch ((uint)num)
							{
							case 0U:
								text = "LF sonar";
								break;
							case 1U:
								text = "MF sonar";
								break;
							case 2U:
								text = "HF sonar";
								break;
							case 3U:
								text = "VLF sonar";
								break;
							}
						}
					}
				}
				else
				{
					text = this.sensor_0.string_2;
				}
				result = text;
			}
			return result;
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0000A400 File Offset: 0x00008600
		public EmissionContainer(double double_0, bool bool_2, bool bool_3)
		{
			this.float_0 = (float)double_0;
			this.bool_0 = bool_2;
			this.bool_1 = bool_3;
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0015CE3C File Offset: 0x0015B03C
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				XmlConvert.ToString(this.float_0),
				"-",
				this.bool_0.ToString(),
				"-",
				this.bool_1.ToString()
			});
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0015CE90 File Offset: 0x0015B090
		public static EmissionContainer smethod_0(ref string string_0)
		{
			string[] array = string_0.Split(new char[]
			{
				'-'
			});
			double double_ = (double)XmlConvert.ToSingle(array[0]);
			bool bool_ = Conversions.ToBoolean(array[1]);
			bool bool_2 = Conversions.ToBoolean(array[2]);
			return new EmissionContainer(double_, bool_, bool_2);
		}

		// Token: 0x04000C35 RID: 3125
		public float float_0;

		// Token: 0x04000C36 RID: 3126
		public bool bool_0;

		// Token: 0x04000C37 RID: 3127
		public bool bool_1;

		// Token: 0x04000C38 RID: 3128
		private Sensor sensor_0;
	}
}
