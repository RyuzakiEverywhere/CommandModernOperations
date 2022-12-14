using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns14;

namespace Command_Core
{
	// Token: 0x02000238 RID: 568
	public abstract class EventTrigger : Class310
	{
		// Token: 0x06001196 RID: 4502 RVA: 0x00002F8D File Offset: 0x0000118D
		public virtual void vmethod_4(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0015D36C File Offset: 0x0015B56C
		public static EventTrigger smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_0)
		{
			EventTrigger result;
			try
			{
				string name = xmlNode_0.Name;
				uint num = Class582.smethod_0(name);
				if (num > 2127696415U)
				{
					if (num <= 3034757310U)
					{
						if (num <= 2658299510U)
						{
							if (num != 2627610827U)
							{
								if (num != 2658299510U)
								{
									goto IL_2AC;
								}
								if (Operators.CompareString(name, "EventTrigger_UnitEntersArea", false) == 0)
								{
									return Class332.smethod_1(xmlNode_0, dictionary_0, scenario_0);
								}
								goto IL_2AC;
							}
							else
							{
								if (Operators.CompareString(name, "EventTrigger_UnitBaseStatus", false) == 0)
								{
									return Class328.smethod_1(xmlNode_0, dictionary_0, scenario_0);
								}
								goto IL_2AC;
							}
						}
						else if (num != 2876160409U)
						{
							if (num != 3034757310U)
							{
								goto IL_2AC;
							}
							if (Operators.CompareString(name, "EventTrigger_UnitInArea", false) != 0)
							{
								goto IL_2AC;
							}
						}
						else
						{
							if (Operators.CompareString(name, "EventTrigger_ScenEnded", false) == 0)
							{
								return Class325.smethod_1(xmlNode_0, dictionary_0, scenario_0);
							}
							goto IL_2AC;
						}
					}
					else if (num <= 3763229247U)
					{
						if (num != 3358481364U)
						{
							if (num != 3763229247U)
							{
								goto IL_2AC;
							}
							if (Operators.CompareString(name, "EventTrigger_UnitRemainsInArea", false) != 0)
							{
								goto IL_2AC;
							}
						}
						else
						{
							if (Operators.CompareString(name, "EventTrigger_RandomTime", false) == 0)
							{
								return Class327.smethod_1(xmlNode_0, dictionary_0, scenario_0);
							}
							goto IL_2AC;
						}
					}
					else if (num != 3820019067U)
					{
						if (num != 3992631867U)
						{
							goto IL_2AC;
						}
						if (Operators.CompareString(name, "EventTrigger_Time", false) == 0)
						{
							return Class335.smethod_1(xmlNode_0, dictionary_0, scenario_0);
						}
						goto IL_2AC;
					}
					else
					{
						if (Operators.CompareString(name, "EventTrigger_UnitCargoMoved", false) != 0)
						{
							goto IL_2AC;
						}
						return Class330.smethod_1(xmlNode_0, dictionary_0, scenario_0);
					}
					return Class333.smethod_1(xmlNode_0, dictionary_0, scenario_0);
				}
				if (num <= 340731739U)
				{
					if (num != 265061192U)
					{
						if (num != 284250354U)
						{
							if (num == 340731739U)
							{
								if (Operators.CompareString(name, "EventTrigger_UnitDamaged", false) == 0)
								{
									return Class336.smethod_1(xmlNode_0, dictionary_0, scenario_0);
								}
							}
						}
						else if (Operators.CompareString(name, "EventTrigger_UnitDetected", false) == 0)
						{
							return Class329.smethod_1(xmlNode_0, dictionary_0, scenario_0);
						}
					}
					else if (Operators.CompareString(name, "EventTrigger_UnitEmissions", false) == 0)
					{
						return Class331.smethod_1(xmlNode_0, dictionary_0, scenario_0);
					}
				}
				else if (num <= 1510924423U)
				{
					if (num != 884716714U)
					{
						if (num == 1510924423U)
						{
							if (Operators.CompareString(name, "EventTrigger_RegularTime", false) == 0)
							{
								return EventTrigger_RegularTime.smethod_1(xmlNode_0, dictionary_0, scenario_0);
							}
						}
					}
					else if (Operators.CompareString(name, "EventTrigger_ScenLoaded", false) == 0)
					{
						return Class326.smethod_1(xmlNode_0, dictionary_0, scenario_0);
					}
				}
				else if (num != 1544518477U)
				{
					if (num == 2127696415U)
					{
						if (Operators.CompareString(name, "EventTrigger_UnitDestroyed", false) == 0)
						{
							return Class337.smethod_1(xmlNode_0, dictionary_0, scenario_0);
						}
					}
				}
				else if (Operators.CompareString(name, "EventTrigger_Points", false) == 0)
				{
					return Class334.smethod_1(xmlNode_0, dictionary_0, scenario_0);
				}
				IL_2AC:
				throw new NotImplementedException();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100519", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00002F8D File Offset: 0x0000118D
		public virtual EventTrigger vmethod_5()
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000C4A RID: 3146
		public string string_2;

		// Token: 0x04000C4B RID: 3147
		public EventTrigger.EventTriggerType eventTriggerType_0;

		// Token: 0x02000239 RID: 569
		public enum EventTriggerType : byte
		{
			// Token: 0x04000C4D RID: 3149
			UnitDestroyed,
			// Token: 0x04000C4E RID: 3150
			Points,
			// Token: 0x04000C4F RID: 3151
			Time,
			// Token: 0x04000C50 RID: 3152
			UnitDamaged,
			// Token: 0x04000C51 RID: 3153
			UnitRemainsInArea,
			// Token: 0x04000C52 RID: 3154
			UnitEntersArea,
			// Token: 0x04000C53 RID: 3155
			RandomTime,
			// Token: 0x04000C54 RID: 3156
			UnitDetected,
			// Token: 0x04000C55 RID: 3157
			ScenLoaded,
			// Token: 0x04000C56 RID: 3158
			RegularTime,
			// Token: 0x04000C57 RID: 3159
			ScenEnded,
			// Token: 0x04000C58 RID: 3160
			UnitBaseStatus,
			// Token: 0x04000C59 RID: 3161
			unitEmissions,
			// Token: 0x04000C5A RID: 3162
			unitCargoMoved
		}
	}
}
