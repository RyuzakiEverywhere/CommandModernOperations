using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns9;

namespace Command_Core
{
	// Token: 0x02000236 RID: 566
	public class EventCondition : Class310
	{
		// Token: 0x06001191 RID: 4497 RVA: 0x00002F8D File Offset: 0x0000118D
		public virtual bool vmethod_4(Scenario scenario_0, SimEvent simEvent_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00002F8D File Offset: 0x0000118D
		public virtual void vmethod_5(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0015D2FC File Offset: 0x0015B4FC
		public static EventCondition smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_0)
		{
			string name = xmlNode_0.Name;
			EventCondition result;
			if (Operators.CompareString(name, "EventCondition_SidePosture", false) != 0)
			{
				if (Operators.CompareString(name, "EventCondition_ScenHasStarted", false) != 0)
				{
					if (Operators.CompareString(name, "EventCondition_LuaScript", false) != 0)
					{
						throw new NotImplementedException();
					}
					result = Class322.smethod_1(xmlNode_0, dictionary_0, scenario_0);
				}
				else
				{
					result = Class323.smethod_1(xmlNode_0, dictionary_0, scenario_0);
				}
			}
			else
			{
				result = Class324.smethod_1(xmlNode_0, dictionary_0, scenario_0);
			}
			return result;
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00002F8D File Offset: 0x0000118D
		public virtual EventCondition vmethod_6()
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000C44 RID: 3140
		public string string_2;

		// Token: 0x04000C45 RID: 3141
		public EventCondition.EventConditionType eventConditionType_0;

		// Token: 0x02000237 RID: 567
		public enum EventConditionType : byte
		{
			// Token: 0x04000C47 RID: 3143
			SidePosture,
			// Token: 0x04000C48 RID: 3144
			ScenHasStarted,
			// Token: 0x04000C49 RID: 3145
			LuaScript
		}
	}
}
