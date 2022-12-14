using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;

namespace Command_Core
{
	// Token: 0x020001F6 RID: 502
	public sealed class GroundImpact : Unit
	{
		// Token: 0x06000F57 RID: 3927 RVA: 0x00122EB4 File Offset: 0x001210B4
		public GroundImpact(ref Scenario scenario_0, double double_2, double double_3, float float_11, bool bool_13)
		{
			this.vmethod_29(null, double_2);
			this.vmethod_31(null, double_3);
			this.float_9 = float_11;
			this.bool_12 = bool_13;
			scenario_0.vmethod_18().Add(this);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00122F04 File Offset: 0x00121104
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("GroundImpact");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				if (hashSet_0.Contains(this.string_0))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(this.string_0);
					xmlWriter_0.WriteElementString("Lon", XmlConvert.ToString(this.vmethod_28(null)));
					xmlWriter_0.WriteElementString("Lat", XmlConvert.ToString(this.vmethod_30(null)));
					xmlWriter_0.WriteElementString("MR", this.float_9.ToString());
					xmlWriter_0.WriteElementString("CR", this.float_10.ToString());
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101337", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00009823 File Offset: 0x00007A23
		private GroundImpact()
		{
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00123018 File Offset: 0x00121218
		public void method_56(Scenario scenario_0, float float_11)
		{
			ref float ptr = ref this.float_10;
			this.float_10 = ptr + float_11 * Math.Max(this.float_9 / 50f, (this.float_9 - this.float_10) / 5f);
			if (this.float_10 > this.float_9)
			{
				scenario_0.vmethod_18().Remove(this);
			}
		}

		// Token: 0x04000A3F RID: 2623
		public float float_9;

		// Token: 0x04000A40 RID: 2624
		public float float_10;

		// Token: 0x04000A41 RID: 2625
		public bool bool_12;
	}
}
