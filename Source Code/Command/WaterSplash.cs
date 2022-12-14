using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;

namespace Command_Core
{
	// Token: 0x0200020A RID: 522
	public sealed class WaterSplash : Unit
	{
		// Token: 0x06000FDB RID: 4059 RVA: 0x00129324 File Offset: 0x00127524
		public WaterSplash(ref Scenario scenario_0, double double_2, double double_3, float float_11)
		{
			this.vmethod_29(null, double_2);
			this.vmethod_31(null, double_3);
			this.float_9 = float_11;
			if (!Information.IsNothing(scenario_0))
			{
				scenario_0.vmethod_16().Add(this);
			}
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00129378 File Offset: 0x00127578
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("WaterSplash");
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
				ex.Data.Add("Error at 100877", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00009823 File Offset: 0x00007A23
		private WaterSplash()
		{
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x0012948C File Offset: 0x0012768C
		public void method_56(Scenario scenario_0, float float_11)
		{
			ref float ptr = ref this.float_10;
			this.float_10 = ptr + float_11 * Math.Max(this.float_9 / 50f, (this.float_9 - this.float_10) / 5f);
			if (this.float_10 > this.float_9)
			{
				scenario_0.vmethod_16().Remove(this);
			}
		}

		// Token: 0x04000A92 RID: 2706
		public float float_9;

		// Token: 0x04000A93 RID: 2707
		public float float_10;
	}
}
