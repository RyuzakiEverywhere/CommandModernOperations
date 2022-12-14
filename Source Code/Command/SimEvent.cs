using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns14;

namespace Command_Core
{
	// Token: 0x0200023B RID: 571
	public sealed class SimEvent : Class310
	{
		// Token: 0x0600119E RID: 4510 RVA: 0x0015D90C File Offset: 0x0015BB0C
		public void method_8(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("SimEvent");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				xmlWriter_0.WriteElementString("Description", this.string_2);
				xmlWriter_0.WriteElementString("IsRepeatable", this.bool_11.ToString());
				xmlWriter_0.WriteElementString("IsActive", this.bool_12.ToString());
				xmlWriter_0.WriteElementString("IsShown", this.bool_13.ToString());
				xmlWriter_0.WriteElementString("Probability", this.short_0.ToString());
				xmlWriter_0.WriteStartElement("Triggers");
				try
				{
					foreach (EventTrigger eventTrigger in this.list_0)
					{
						if (!Information.IsNothing(eventTrigger))
						{
							xmlWriter_0.WriteElementString("Trigger", eventTrigger.string_0);
						}
					}
				}
				finally
				{
					List<EventTrigger>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteStartElement("Conditions");
				try
				{
					foreach (EventCondition eventCondition in this.list_1)
					{
						if (!Information.IsNothing(eventCondition))
						{
							xmlWriter_0.WriteElementString("Condition", eventCondition.string_0);
						}
					}
				}
				finally
				{
					List<EventCondition>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteStartElement("Actions");
				try
				{
					foreach (EventAction eventAction in this.list_2)
					{
						if (!Information.IsNothing(eventAction))
						{
							xmlWriter_0.WriteElementString("Action", eventAction.string_0);
						}
					}
				}
				finally
				{
					List<EventAction>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100538", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0015DB54 File Offset: 0x0015BD54
		public static SimEvent smethod_0(XmlNode xmlNode_0, Dictionary<string, Class310> dictionary_0, Scenario scenario_0)
		{
			SimEvent result;
			try
			{
				SimEvent simEvent = new SimEvent();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 1458105184U)
						{
							if (num <= 1170788892U)
							{
								if (num != 306337606U)
								{
									if (num != 1170788892U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Probability", false) == 0)
									{
										simEvent.short_0 = Conversions.ToShort(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "IsShown", false) == 0)
									{
										simEvent.bool_13 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 1372301015U)
							{
								if (num != 1458105184U)
								{
									continue;
								}
								if (Operators.CompareString(name, "ID", false) == 0)
								{
									simEvent.vmethod_0(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Conditions", false) != 0)
								{
									continue;
								}
								try
								{
									foreach (object obj2 in xmlNode.ChildNodes)
									{
										XmlNode xmlNode2 = (XmlNode)obj2;
										EventCondition item = scenario_0.vmethod_6()[xmlNode2.InnerText];
										simEvent.list_1.Add(item);
									}
									continue;
								}
								finally
								{
									IEnumerator enumerator2;
									if (enumerator2 is IDisposable)
									{
										(enumerator2 as IDisposable).Dispose();
									}
								}
							}
						}
						if (num <= 2106073694U)
						{
							if (num != 1725856265U)
							{
								if (num == 2106073694U)
								{
									if (Operators.CompareString(name, "IsRepeatable", false) == 0)
									{
										simEvent.bool_11 = Conversions.ToBoolean(xmlNode.InnerText);
									}
								}
							}
							else if (Operators.CompareString(name, "Description", false) == 0)
							{
								simEvent.string_2 = xmlNode.InnerText;
							}
						}
						else
						{
							if (num != 2130724671U)
							{
								if (num != 3865031940U)
								{
									if (num != 4285775472U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Triggers", false) != 0)
									{
										continue;
									}
									try
									{
										foreach (object obj3 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode3 = (XmlNode)obj3;
											EventTrigger item2 = scenario_0.vmethod_4()[xmlNode3.InnerText];
											simEvent.list_0.Add(item2);
										}
										continue;
									}
									finally
									{
										IEnumerator enumerator3;
										if (enumerator3 is IDisposable)
										{
											(enumerator3 as IDisposable).Dispose();
										}
									}
								}
								if (Operators.CompareString(name, "Actions", false) != 0)
								{
									continue;
								}
								try
								{
									foreach (object obj4 in xmlNode.ChildNodes)
									{
										XmlNode xmlNode4 = (XmlNode)obj4;
										EventAction item3 = scenario_0.vmethod_8()[xmlNode4.InnerText];
										simEvent.list_2.Add(item3);
									}
									continue;
								}
								finally
								{
									IEnumerator enumerator4;
									if (enumerator4 is IDisposable)
									{
										(enumerator4 as IDisposable).Dispose();
									}
								}
							}
							if (Operators.CompareString(name, "IsActive", false) == 0)
							{
								simEvent.bool_12 = Conversions.ToBoolean(xmlNode.InnerText);
							}
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
				result = simEvent;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100539", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0015DF34 File Offset: 0x0015C134
		public SimEvent()
		{
			this.list_0 = new List<EventTrigger>();
			this.list_1 = new List<EventCondition>();
			this.list_2 = new List<EventAction>();
			this.bool_12 = true;
			this.bool_11 = false;
			this.bool_13 = true;
			this.short_0 = 100;
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0015DF88 File Offset: 0x0015C188
		public bool method_9(Scenario scenario_0)
		{
			bool result;
			if (this.list_1.Count == 0)
			{
				result = true;
			}
			else
			{
				try
				{
					List<EventCondition>.Enumerator enumerator = this.list_1.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.vmethod_4(scenario_0, this))
						{
							return false;
						}
					}
				}
				finally
				{
					List<EventCondition>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0015DFF8 File Offset: 0x0015C1F8
		public SimEvent method_10()
		{
			SimEvent simEvent = (SimEvent)base.MemberwiseClone();
			simEvent.vmethod_0(Guid.NewGuid().ToString());
			simEvent.string_2 = "[CLONE] " + this.string_2;
			simEvent.Name = "[CLONE] " + this.Name;
			simEvent.list_0 = new List<EventTrigger>();
			simEvent.list_0.AddRange(this.list_0);
			simEvent.list_1 = new List<EventCondition>();
			simEvent.list_1.AddRange(this.list_1);
			simEvent.list_2 = new List<EventAction>();
			simEvent.list_2.AddRange(this.list_2);
			return simEvent;
		}

		// Token: 0x04000C5E RID: 3166
		public string string_2;

		// Token: 0x04000C5F RID: 3167
		public bool bool_11;

		// Token: 0x04000C60 RID: 3168
		public bool bool_12;

		// Token: 0x04000C61 RID: 3169
		public bool bool_13;

		// Token: 0x04000C62 RID: 3170
		public short short_0;

		// Token: 0x04000C63 RID: 3171
		public List<EventTrigger> list_0;

		// Token: 0x04000C64 RID: 3172
		public List<EventCondition> list_1;

		// Token: 0x04000C65 RID: 3173
		public List<EventAction> list_2;
	}
}
