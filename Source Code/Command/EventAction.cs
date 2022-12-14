using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns9;

namespace Command_Core
{
	// Token: 0x02000233 RID: 563
	public class EventAction : Class310
	{
		// Token: 0x06001187 RID: 4487 RVA: 0x00002F8D File Offset: 0x0000118D
		public virtual void vmethod_4(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0015CED4 File Offset: 0x0015B0D4
		public static EventAction smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_0)
		{
			EventAction result;
			try
			{
				string name = xmlNode_0.Name;
				if (Operators.CompareString(name, "EventAction_Points", false) != 0)
				{
					if (Operators.CompareString(name, "EventAction_EndScenario", false) != 0)
					{
						if (Operators.CompareString(name, "EventAction_TeleportInArea", false) != 0)
						{
							if (Operators.CompareString(name, "EventAction_Message", false) != 0)
							{
								if (Operators.CompareString(name, "EventAction_ChangeMissionStatus", false) != 0)
								{
									if (Operators.CompareString(name, "EventAction_LuaScript", false) != 0)
									{
										throw new NotImplementedException();
									}
									result = Class317.smethod_1(xmlNode_0, dictionary_0, scenario_0);
								}
								else
								{
									result = Class318.smethod_1(xmlNode_0, dictionary_0, scenario_0);
								}
							}
							else
							{
								result = Class319.smethod_1(xmlNode_0, dictionary_0, scenario_0);
							}
						}
						else
						{
							result = EventAction_TeleportInArea.smethod_1(xmlNode_0, dictionary_0, scenario_0);
						}
					}
					else
					{
						result = Class320.smethod_1(xmlNode_0, dictionary_0, scenario_0);
					}
				}
				else
				{
					result = Class321.smethod_1(xmlNode_0, dictionary_0, scenario_0);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100501", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00002F8D File Offset: 0x0000118D
		public virtual void vmethod_5(Scenario scenario_0, SimEvent simEvent_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00002F8D File Offset: 0x0000118D
		public virtual EventAction vmethod_6()
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000C39 RID: 3129
		public string string_2;

		// Token: 0x04000C3A RID: 3130
		public EventAction.EventActionType eventActionType_0;

		// Token: 0x02000234 RID: 564
		public enum EventActionType : byte
		{
			// Token: 0x04000C3C RID: 3132
			Points,
			// Token: 0x04000C3D RID: 3133
			EndScenario,
			// Token: 0x04000C3E RID: 3134
			TeleportInArea,
			// Token: 0x04000C3F RID: 3135
			Message,
			// Token: 0x04000C40 RID: 3136
			ChangeMissionStatus,
			// Token: 0x04000C41 RID: 3137
			LuaScript
		}
	}
}
