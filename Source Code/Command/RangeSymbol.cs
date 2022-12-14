using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns14;

namespace Command_Core
{
	// Token: 0x020002F4 RID: 756
	public sealed class RangeSymbol : Class310
	{
		// Token: 0x06001672 RID: 5746 RVA: 0x001A1A08 File Offset: 0x0019FC08
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
				this.stringBuilder_0.Append("<RangeSymbol>");
				this.stringBuilder_0.Append("<ID>").Append(this.string_0).Append("</ID>");
				this.stringBuilder_0.Append("<Description>").Append(this.string_2).Append("</Description>");
				this.stringBuilder_0.Append("<RangeNM>").Append(XmlConvert.ToString(this.double_0)).Append("</RangeNM>");
				this.stringBuilder_0.Append("<LeftArc>").Append(XmlConvert.ToString(this.float_0)).Append("</LeftArc>");
				this.stringBuilder_0.Append("<RightArc>").Append(XmlConvert.ToString(this.float_1)).Append("</RightArc>");
				StringBuilder stringBuilder = this.stringBuilder_0.Append("<Type>");
				int num = (int)this.symbolType_0;
				stringBuilder.Append(num.ToString()).Append("</Type>");
				this.stringBuilder_0.Append("<Color>").Append(this.color_0.ToArgb().ToString()).Append("</Color>");
				this.stringBuilder_0.Append("</RangeSymbol>");
				result = this.stringBuilder_0.ToString();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101020", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x001A1BEC File Offset: 0x0019FDEC
		public static RangeSymbol smethod_0(XmlNode xmlNode_0, Dictionary<string, Class310> dictionary_0)
		{
			RangeSymbol result;
			try
			{
				RangeSymbol rangeSymbol = new RangeSymbol();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 2959157563U)
						{
							if (num != 1458105184U)
							{
								if (num != 1725856265U)
								{
									if (num == 2959157563U)
									{
										if (Operators.CompareString(name, "RightArc", false) == 0)
										{
											rangeSymbol.float_1 = XmlConvert.ToSingle(xmlNode.InnerText);
										}
									}
								}
								else if (Operators.CompareString(name, "Description", false) == 0)
								{
									rangeSymbol.string_2 = xmlNode.InnerText;
								}
							}
							else if (Operators.CompareString(name, "ID", false) == 0)
							{
								if (dictionary_0.ContainsKey(xmlNode.InnerText))
								{
									return (RangeSymbol)dictionary_0[xmlNode.InnerText];
								}
								rangeSymbol.vmethod_0(xmlNode.InnerText);
								dictionary_0.Add(rangeSymbol.string_0, rangeSymbol);
							}
						}
						else if (num <= 3783116160U)
						{
							if (num != 3512062061U)
							{
								if (num == 3783116160U)
								{
									if (Operators.CompareString(name, "LeftArc", false) == 0)
									{
										rangeSymbol.float_0 = XmlConvert.ToSingle(xmlNode.InnerText);
									}
								}
							}
							else if (Operators.CompareString(name, "Type", false) == 0)
							{
								if (Versioned.IsNumeric(xmlNode.InnerText))
								{
									rangeSymbol.symbolType_0 = (RangeSymbol.SymbolType)Conversions.ToByte(xmlNode.InnerText);
								}
								else
								{
									rangeSymbol.symbolType_0 = (RangeSymbol.SymbolType)Enum.Parse(typeof(RangeSymbol.SymbolType), xmlNode.InnerText, true);
								}
							}
						}
						else if (num != 3853794552U)
						{
							if (num == 3858895547U)
							{
								if (Operators.CompareString(name, "RangeNM", false) == 0)
								{
									rangeSymbol.double_0 = XmlConvert.ToDouble(xmlNode.InnerText);
								}
							}
						}
						else if (Operators.CompareString(name, "Color", false) == 0)
						{
							rangeSymbol.color_0 = Color.FromArgb(Conversions.ToInteger(xmlNode.InnerText));
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
				result = rangeSymbol;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101021", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new RangeSymbol();
			}
			return result;
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x0000944E File Offset: 0x0000764E
		public RangeSymbol()
		{
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x0000BEF3 File Offset: 0x0000A0F3
		public RangeSymbol(RangeSymbol.SymbolType symbolType_1, string string_3, double double_1, float float_2, float float_3, Color color_1)
		{
			this.symbolType_0 = symbolType_1;
			this.string_2 = string_3;
			this.double_0 = double_1;
			this.float_0 = float_2;
			this.float_1 = float_3;
			this.color_0 = color_1;
		}

		// Token: 0x040013CA RID: 5066
		public string string_2;

		// Token: 0x040013CB RID: 5067
		public double double_0;

		// Token: 0x040013CC RID: 5068
		public float float_0;

		// Token: 0x040013CD RID: 5069
		public float float_1;

		// Token: 0x040013CE RID: 5070
		public RangeSymbol.SymbolType symbolType_0;

		// Token: 0x040013CF RID: 5071
		public Color color_0;

		// Token: 0x040013D0 RID: 5072
		private StringBuilder stringBuilder_0;

		// Token: 0x020002F5 RID: 757
		public enum SymbolType : byte
		{
			// Token: 0x040013D2 RID: 5074
			Circle = 1,
			// Token: 0x040013D3 RID: 5075
			Wedge
		}
	}
}
