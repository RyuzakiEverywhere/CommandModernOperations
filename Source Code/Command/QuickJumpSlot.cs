using System;
using System.Collections;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace Command_Core
{
	// Token: 0x020001F1 RID: 497
	public sealed class QuickJumpSlot
	{
		// Token: 0x06000F46 RID: 3910 RVA: 0x00122550 File Offset: 0x00120750
		public void method_0(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("QJS");
				xmlWriter_0.WriteElementString("I", this.byte_0.ToString());
				xmlWriter_0.WriteElementString("LS", this.string_0);
				xmlWriter_0.WriteElementString("CA", this.int_0.ToString());
				if (this.bool_0)
				{
					xmlWriter_0.WriteElementString("TR", "True");
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101018", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00122614 File Offset: 0x00120814
		public static QuickJumpSlot smethod_0(XmlNode xmlNode_0)
		{
			QuickJumpSlot result;
			try
			{
				QuickJumpSlot quickJumpSlot = new QuickJumpSlot();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "I", false) != 0)
						{
							if (Operators.CompareString(name, "LS", false) != 0)
							{
								if (Operators.CompareString(name, "CA", false) != 0)
								{
									if (Operators.CompareString(name, "TR", false) == 0)
									{
										quickJumpSlot.bool_0 = true;
									}
								}
								else
								{
									quickJumpSlot.int_0 = Conversions.ToInteger(xmlNode.InnerText);
								}
							}
							else
							{
								quickJumpSlot.string_0 = xmlNode.InnerText;
							}
						}
						else
						{
							quickJumpSlot.byte_0 = Conversions.ToByte(xmlNode.InnerText);
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
				result = quickJumpSlot;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101019", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x04000A31 RID: 2609
		public byte byte_0;

		// Token: 0x04000A32 RID: 2610
		public string string_0;

		// Token: 0x04000A33 RID: 2611
		public int int_0;

		// Token: 0x04000A34 RID: 2612
		public bool bool_0;
	}
}
