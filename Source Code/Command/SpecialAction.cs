using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;

namespace Command_Core
{
	// Token: 0x020001D5 RID: 469
	public sealed class SpecialAction : Class310
	{
		// Token: 0x06000E99 RID: 3737 RVA: 0x0011A280 File Offset: 0x00118480
		public void method_8(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("SpecialAction");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				xmlWriter_0.WriteElementString("Name", this.Name);
				xmlWriter_0.WriteElementString("Description", this.string_2);
				xmlWriter_0.WriteElementString("IsRepeatable", this.bool_12.ToString());
				xmlWriter_0.WriteElementString("IsActive", this.bool_11.ToString());
				xmlWriter_0.WriteElementString("ScriptText", this.string_3);
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200654", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0011A358 File Offset: 0x00118558
		public static SpecialAction smethod_0(XmlNode xmlNode_0, Dictionary<string, Class310> dictionary_0, Scenario scenario_0)
		{
			SpecialAction result;
			try
			{
				SpecialAction specialAction = new SpecialAction();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "Name", false) != 0)
							{
								if (Operators.CompareString(name, "Description", false) != 0)
								{
									if (Operators.CompareString(name, "IsRepeatable", false) != 0)
									{
										if (Operators.CompareString(name, "IsActive", false) != 0)
										{
											if (Operators.CompareString(name, "ScriptText", false) == 0)
											{
												specialAction.string_3 = xmlNode.InnerText;
											}
										}
										else
										{
											specialAction.bool_11 = Conversions.ToBoolean(xmlNode.InnerText);
										}
									}
									else
									{
										specialAction.bool_12 = Conversions.ToBoolean(xmlNode.InnerText);
									}
								}
								else
								{
									specialAction.string_2 = xmlNode.InnerText;
								}
							}
							else
							{
								specialAction.Name = xmlNode.InnerText;
							}
						}
						else
						{
							specialAction.vmethod_0(xmlNode.InnerText);
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
				result = specialAction;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101324", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x000098D8 File Offset: 0x00007AD8
		public SpecialAction()
		{
			this.bool_11 = true;
			this.bool_12 = false;
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0011A4DC File Offset: 0x001186DC
		public string method_9(Scenario scenario_0)
		{
			string result;
			try
			{
				if (!this.bool_12)
				{
					this.bool_11 = false;
				}
				object[] array = scenario_0.method_10().RunScript(this.string_3, false, this.Name);
				if (Information.IsNothing(array))
				{
					result = "Special Action '" + this.Name + "' has been executed.";
				}
				else
				{
					result = array[0].ToString();
				}
			}
			catch (Exception ex)
			{
				GameGeneral.smethod_1("Error in Execute: " + ex.Message + "\r\nStack:" + ex.StackTrace);
				ex.Data.Add("Error at 101325", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0011A5A4 File Offset: 0x001187A4
		public SpecialAction method_10()
		{
			SpecialAction specialAction = (SpecialAction)base.MemberwiseClone();
			specialAction.vmethod_0(Guid.NewGuid().ToString());
			specialAction.string_2 = "[CLONE] " + this.string_2;
			specialAction.Name = "[CLONE] " + this.Name;
			return specialAction;
		}

		// Token: 0x04000985 RID: 2437
		public string string_2;

		// Token: 0x04000986 RID: 2438
		public bool bool_11;

		// Token: 0x04000987 RID: 2439
		public bool bool_12;

		// Token: 0x04000988 RID: 2440
		public string string_3;
	}
}
