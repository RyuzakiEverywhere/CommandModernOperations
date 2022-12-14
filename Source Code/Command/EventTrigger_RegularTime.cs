using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns10;

namespace Command_Core
{
	// Token: 0x020001D9 RID: 473
	public sealed class EventTrigger_RegularTime : EventTrigger
	{
		// Token: 0x06000EAE RID: 3758 RVA: 0x0011AD5C File Offset: 0x00118F5C
		public bool method_8(Scenario scenario_0)
		{
			bool result;
			switch (this.regularTimeInterval_0)
			{
			case EventTrigger_RegularTime.RegularTimeInterval.OneSecond:
				result = scenario_0.SecondIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime.RegularTimeInterval.FiveSeconds:
				result = scenario_0.FifthSecondIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime.RegularTimeInterval.FifteenSeconds:
				result = scenario_0.FifteenthSecondIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime.RegularTimeInterval.ThirtySeconds:
				result = scenario_0.ThirtiethSecondIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime.RegularTimeInterval.OneMinute:
				result = scenario_0.MinuteIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime.RegularTimeInterval.FiveMinutes:
				result = scenario_0.FifthMinuteIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime.RegularTimeInterval.FifteenMinutes:
				result = scenario_0.FifteenthMinuteIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime.RegularTimeInterval.ThirtyMinutes:
				result = scenario_0.ThirtiethMinuteIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime.RegularTimeInterval.OneHour:
				result = scenario_0.HourIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime.RegularTimeInterval.SixHours:
				result = scenario_0.SixHourIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime.RegularTimeInterval.TwelveHours:
				result = scenario_0.TwelveHourIsChangingOnThisPulse;
				break;
			case EventTrigger_RegularTime.RegularTimeInterval.TwentyFourHours:
				result = scenario_0.TwentyFourHourIsChangingOnThisPulse;
				break;
			default:
				result = false;
				break;
			}
			return result;
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00009951 File Offset: 0x00007B51
		public EventTrigger_RegularTime()
		{
			this.eventTriggerType_0 = EventTrigger.EventTriggerType.RegularTime;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x0011AE18 File Offset: 0x00119018
		public override void vmethod_4(XmlWriter xmlWriter_0, HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventTrigger_RegularTime");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				xmlWriter_0.WriteElementString("Description", this.string_2);
				string localName = "Interval";
				int num = (int)this.regularTimeInterval_0;
				xmlWriter_0.WriteElementString(localName, num.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100320968409868", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0011AEBC File Offset: 0x001190BC
		public static EventTrigger_RegularTime smethod_1(XmlNode xmlNode_0, Dictionary<string, Class310> dictionary_0, Scenario scenario_0)
		{
			EventTrigger_RegularTime result;
			try
			{
				EventTrigger_RegularTime eventTrigger_RegularTime = new EventTrigger_RegularTime();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "Description", false) != 0)
							{
								if (Operators.CompareString(name, "Interval", false) == 0)
								{
									eventTrigger_RegularTime.regularTimeInterval_0 = (EventTrigger_RegularTime.RegularTimeInterval)Conversions.ToInteger(xmlNode.InnerText);
								}
							}
							else
							{
								eventTrigger_RegularTime.string_2 = xmlNode.InnerText;
							}
						}
						else
						{
							eventTrigger_RegularTime.vmethod_0(xmlNode.InnerText);
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
				result = eventTrigger_RegularTime;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 10004356945678578882", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0011AFC4 File Offset: 0x001191C4
		public override EventTrigger vmethod_5()
		{
			EventTrigger_RegularTime eventTrigger_RegularTime = (EventTrigger_RegularTime)base.MemberwiseClone();
			eventTrigger_RegularTime.vmethod_0(Guid.NewGuid().ToString());
			eventTrigger_RegularTime.string_2 = "[CLONE] " + this.string_2;
			eventTrigger_RegularTime.Name = "[CLONE] " + this.Name;
			return eventTrigger_RegularTime;
		}

		// Token: 0x0400098D RID: 2445
		public EventTrigger_RegularTime.RegularTimeInterval regularTimeInterval_0;

		// Token: 0x020001DA RID: 474
		public enum RegularTimeInterval
		{
			// Token: 0x0400098F RID: 2447
			OneSecond,
			// Token: 0x04000990 RID: 2448
			FiveSeconds,
			// Token: 0x04000991 RID: 2449
			FifteenSeconds,
			// Token: 0x04000992 RID: 2450
			ThirtySeconds,
			// Token: 0x04000993 RID: 2451
			OneMinute,
			// Token: 0x04000994 RID: 2452
			FiveMinutes,
			// Token: 0x04000995 RID: 2453
			FifteenMinutes,
			// Token: 0x04000996 RID: 2454
			ThirtyMinutes,
			// Token: 0x04000997 RID: 2455
			OneHour,
			// Token: 0x04000998 RID: 2456
			SixHours,
			// Token: 0x04000999 RID: 2457
			TwelveHours,
			// Token: 0x0400099A RID: 2458
			TwentyFourHours
		}
	}
}
