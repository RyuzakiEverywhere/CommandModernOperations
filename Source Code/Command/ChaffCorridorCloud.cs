using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns10;

namespace Command_Core
{
	// Token: 0x020001F5 RID: 501
	public sealed class ChaffCorridorCloud : Unit
	{
		// Token: 0x06000F4E RID: 3918 RVA: 0x00122AD4 File Offset: 0x00120CD4
		public ChaffCorridorCloud(double double_3, double double_4, float float_9, float float_10)
		{
			this.vmethod_31(null, double_3);
			this.vmethod_29(null, double_4);
			this.vmethod_15(false, float_9);
			this.vmethod_10(float_10);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00009C3B File Offset: 0x00007E3B
		public void method_56(float float_9)
		{
			this.double_2 += (double)float_9;
			this.vmethod_15(false, (float)((double)this.vmethod_14(false) - 0.6 * (double)float_9));
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00009C69 File Offset: 0x00007E69
		public int method_57()
		{
			return Math.Min(100 + (int)Math.Round(this.double_2 * 100.0), 6000);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00009C8E File Offset: 0x00007E8E
		public int method_58()
		{
			return Math.Min(40 + (int)Math.Round(this.double_2 * 50.0), 1500);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00122B18 File Offset: 0x00120D18
		public int method_59()
		{
			float num = (float)(this.double_2 * 0.6);
			return Math.Max(0, (int)Math.Round((double)this.vmethod_14(false) + (double)num * 0.5));
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00122B58 File Offset: 0x00120D58
		public int method_60()
		{
			float num = (float)(this.double_2 * 0.6);
			return Math.Max(0, (int)Math.Round((double)this.vmethod_14(false) - (double)num * 1.5));
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00122B98 File Offset: 0x00120D98
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("ChaffCloud");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				if (hashSet_0.Contains(this.string_0))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(this.string_0);
					xmlWriter_0.WriteElementString("CH", XmlConvert.ToString(this.vmethod_9()));
					xmlWriter_0.WriteElementString("Age", XmlConvert.ToString(this.double_2));
					xmlWriter_0.WriteElementString("Lon", XmlConvert.ToString(this.vmethod_28(null)));
					xmlWriter_0.WriteElementString("Lat", XmlConvert.ToString(this.vmethod_30(null)));
					xmlWriter_0.WriteElementString("Alt", XmlConvert.ToString(this.vmethod_14(false)));
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 112340-231495090911", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00009823 File Offset: 0x00007A23
		private ChaffCorridorCloud()
		{
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00122CC4 File Offset: 0x00120EC4
		public static ChaffCorridorCloud smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0)
		{
			ChaffCorridorCloud result;
			try
			{
				ChaffCorridorCloud chaffCorridorCloud = new ChaffCorridorCloud();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "CH", false) != 0)
							{
								if (Operators.CompareString(name, "Age", false) != 0)
								{
									if (Operators.CompareString(name, "Lon", false) != 0)
									{
										if (Operators.CompareString(name, "Lat", false) != 0)
										{
											if (Operators.CompareString(name, "Alt", false) == 0)
											{
												chaffCorridorCloud.vmethod_15(false, XmlConvert.ToSingle(xmlNode.InnerText));
											}
										}
										else
										{
											chaffCorridorCloud.vmethod_31(null, XmlConvert.ToDouble(xmlNode.InnerText));
										}
									}
									else
									{
										chaffCorridorCloud.vmethod_29(null, XmlConvert.ToDouble(xmlNode.InnerText));
									}
								}
								else
								{
									chaffCorridorCloud.double_2 = (double)XmlConvert.ToSingle(xmlNode.InnerText);
								}
							}
							else
							{
								chaffCorridorCloud.vmethod_10(XmlConvert.ToSingle(xmlNode.InnerText));
							}
						}
						else
						{
							if (dictionary_0.ContainsKey(xmlNode.InnerText))
							{
								return (ChaffCorridorCloud)dictionary_0[xmlNode.InnerText];
							}
							chaffCorridorCloud.vmethod_0(xmlNode.InnerText);
							dictionary_0.Add(chaffCorridorCloud.string_0, chaffCorridorCloud);
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
				result = chaffCorridorCloud;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 10213412354093409922", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ChaffCorridorCloud();
			}
			return result;
		}

		// Token: 0x04000A3E RID: 2622
		private double double_2;
	}
}
