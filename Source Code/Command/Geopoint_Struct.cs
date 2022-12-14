using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns10;

namespace Command_Core
{
	// Token: 0x020001E7 RID: 487
	public struct Geopoint_Struct
	{
		// Token: 0x06000EEC RID: 3820 RVA: 0x00009B3F File Offset: 0x00007D3F
		public bool method_0()
		{
			return this.double_0 == 0.0 && this.double_1 == 0.0;
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00009B65 File Offset: 0x00007D65
		public Geopoint_Struct(double double_2, double double_3)
		{
			this = default(Geopoint_Struct);
			this.double_0 = double_2;
			this.double_1 = double_3;
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00009B7C File Offset: 0x00007D7C
		public Geopoint_Struct(double double_2, double double_3, float float_1)
		{
			this = default(Geopoint_Struct);
			this.double_0 = double_2;
			this.double_1 = double_3;
			this.float_0 = float_1;
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00009B9A File Offset: 0x00007D9A
		public GeoPoint method_1()
		{
			return new GeoPoint(this.double_0, this.double_1);
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0011DF28 File Offset: 0x0011C128
		public float method_2(Unit unit_0)
		{
			float result;
			try
			{
				float num = unit_0.vmethod_9();
				float num2 = Math2.smethod_17(unit_0.vmethod_30(null), unit_0.vmethod_28(null), this.double_1, this.double_0);
				num2 = Math2.smethod_7(num2 - num);
				if (num2 > 180f)
				{
					result = -(360f - num2);
				}
				else
				{
					result = num2;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100575", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0011DFDC File Offset: 0x0011C1DC
		internal static Geopoint_Struct smethod_0(XmlNode xmlNode_0, Dictionary<string, Class310> dictionary_0)
		{
			Geopoint_Struct geopoint_Struct = default(Geopoint_Struct);
			Geopoint_Struct result;
			try
			{
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "Longitude", false) != 0 && Operators.CompareString(name, "Lon", false) != 0)
						{
							if (Operators.CompareString(name, "Latitude", false) != 0 && Operators.CompareString(name, "Lat", false) != 0)
							{
								if (Operators.CompareString(name, "Altitude", false) == 0 || Operators.CompareString(name, "Alt", false) == 0)
								{
									geopoint_Struct.float_0 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
								}
							}
							else
							{
								geopoint_Struct.double_1 = XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", "."));
							}
						}
						else
						{
							geopoint_Struct.double_0 = XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", "."));
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
				result = geopoint_Struct;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 1032453245345634563456092839482347235847", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = default(Geopoint_Struct);
			}
			return result;
		}

		// Token: 0x040009DA RID: 2522
		public double double_0;

		// Token: 0x040009DB RID: 2523
		public double double_1;

		// Token: 0x040009DC RID: 2524
		public float float_0;
	}
}
