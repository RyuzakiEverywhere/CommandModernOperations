using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns14;

namespace Command_Core
{
	// Token: 0x0200024C RID: 588
	public sealed class FuelRec : Class310
	{
		// Token: 0x06001219 RID: 4633 RVA: 0x001674B0 File Offset: 0x001656B0
		public string method_8()
		{
			string result;
			try
			{
				if (this.stringBuilder_0 == null)
				{
					this.stringBuilder_0 = new StringBuilder(500);
				}
				else
				{
					this.stringBuilder_0.Clear();
				}
				this.stringBuilder_0.Append("<FuelRec>");
				this.stringBuilder_0.Append("<ID>").Append(this.string_0).Append("</ID>");
				if (this.DBID != null)
				{
					this.stringBuilder_0.Append("<DBID>").Append(this.DBID).Append("</DBID>");
				}
				this.stringBuilder_0.Append("<MQ>").Append(this.int_0.ToString()).Append("</MQ>");
				this.stringBuilder_0.Append("<CQ>").Append(XmlConvert.ToString(this.float_0)).Append("</CQ>");
				this.stringBuilder_0.Append("<FT>").Append((int)this._FuelType_0).Append("</FT>");
				this.stringBuilder_0.Append("</FuelRec>");
				result = this.stringBuilder_0.ToString();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101005", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0016763C File Offset: 0x0016583C
		public static FuelRec smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0)
		{
			FuelRec result;
			try
			{
				FuelRec fuelRec = new FuelRec();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num > 1458105184U)
						{
							if (num <= 2027117207U)
							{
								if (num != 1742338969U)
								{
									if (num != 2027117207U)
									{
										continue;
									}
									if (Operators.CompareString(name, "FT", false) == 0)
									{
										goto IL_120;
									}
									continue;
								}
								else if (Operators.CompareString(name, "CQ", false) != 0)
								{
									continue;
								}
							}
							else if (num != 2187602126U)
							{
								if (num != 2735483603U)
								{
									continue;
								}
								if (Operators.CompareString(name, "CurrentQuantity", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "DBID", false) == 0)
								{
									fuelRec.DBID = new int?(Conversions.ToInteger(xmlNode.InnerText));
									continue;
								}
								continue;
							}
							fuelRec.float_0 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
							continue;
						}
						if (num <= 870300139U)
						{
							if (num != 596983820U)
							{
								if (num != 870300139U)
								{
									continue;
								}
								if (Operators.CompareString(name, "MQ", false) != 0)
								{
									continue;
								}
							}
							else if (Operators.CompareString(name, "MaxQuantity", false) != 0)
							{
								continue;
							}
							fuelRec.int_0 = Conversions.ToInteger(xmlNode.InnerText);
							continue;
						}
						if (num != 1398189189U)
						{
							if (num != 1458105184U)
							{
								continue;
							}
							if (Operators.CompareString(name, "ID", false) == 0)
							{
								fuelRec.vmethod_0(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						else if (Operators.CompareString(name, "FuelType", false) != 0)
						{
							continue;
						}
						IL_120:
						if (Versioned.IsNumeric(xmlNode.InnerText))
						{
							fuelRec._FuelType_0 = (FuelRec._FuelType)Conversions.ToShort(xmlNode.InnerText);
						}
						else
						{
							fuelRec._FuelType_0 = (FuelRec._FuelType)Enum.Parse(typeof(FuelRec._FuelType), xmlNode.InnerText, true);
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
				result = fuelRec;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101006", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0000A63E File Offset: 0x0000883E
		public float method_9()
		{
			return this.float_0 / (float)this.int_0;
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x0000944E File Offset: 0x0000764E
		private FuelRec()
		{
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0000A64E File Offset: 0x0000884E
		public FuelRec(int int_1, short short_0)
		{
			this.int_0 = int_1;
			this.float_0 = (float)int_1;
			this._FuelType_0 = (FuelRec._FuelType)short_0;
		}

		// Token: 0x04000CAE RID: 3246
		public int? DBID;

		// Token: 0x04000CAF RID: 3247
		public int int_0;

		// Token: 0x04000CB0 RID: 3248
		public float float_0;

		// Token: 0x04000CB1 RID: 3249
		public FuelRec._FuelType _FuelType_0;

		// Token: 0x04000CB2 RID: 3250
		private StringBuilder stringBuilder_0;

		// Token: 0x0200024D RID: 589
		public enum _FuelType : short
		{
			// Token: 0x04000CB4 RID: 3252
			NoFuel = 1001,
			// Token: 0x04000CB5 RID: 3253
			AviationFuel = 2001,
			// Token: 0x04000CB6 RID: 3254
			DieselFuel = 3001,
			// Token: 0x04000CB7 RID: 3255
			OilFuel,
			// Token: 0x04000CB8 RID: 3256
			GasFuel,
			// Token: 0x04000CB9 RID: 3257
			Battery = 4001,
			// Token: 0x04000CBA RID: 3258
			AirIndepedent,
			// Token: 0x04000CBB RID: 3259
			RocketFuel = 5001,
			// Token: 0x04000CBC RID: 3260
			TorpedoFuel = 5001,
			// Token: 0x04000CBD RID: 3261
			WeaponCoast = 5003
		}
	}
}
