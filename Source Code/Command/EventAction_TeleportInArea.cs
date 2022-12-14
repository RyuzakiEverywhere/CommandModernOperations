using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;

namespace Command_Core
{
	// Token: 0x020001D0 RID: 464
	public sealed class EventAction_TeleportInArea : EventAction
	{
		// Token: 0x06000E82 RID: 3714 RVA: 0x0000987A File Offset: 0x00007A7A
		public EventAction_TeleportInArea()
		{
			this.hashSet_0 = new HashSet<string>();
			this.list_0 = new List<ReferencePoint>();
			this.eventActionType_0 = EventAction.EventActionType.TeleportInArea;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00119328 File Offset: 0x00117528
		public override void vmethod_4(XmlWriter xmlWriter_0, HashSet<string> hashSet_1, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("EventAction_TeleportInArea");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				xmlWriter_0.WriteElementString("Description", this.string_2);
				xmlWriter_0.WriteStartElement("UnitIDs");
				try
				{
					foreach (string value in this.hashSet_0)
					{
						xmlWriter_0.WriteElementString("ID", value);
					}
				}
				finally
				{
					HashSet<string>.Enumerator enumerator;
					enumerator.Dispose();
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteStartElement("Area");
				try
				{
					foreach (ReferencePoint referencePoint in this.list_0)
					{
						xmlWriter_0.WriteRaw(referencePoint.method_17(ref hashSet_1));
					}
				}
				finally
				{
					List<ReferencePoint>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100513", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00119464 File Offset: 0x00117664
		public static EventAction_TeleportInArea smethod_1(XmlNode xmlNode_0, Dictionary<string, Class310> dictionary_0, Scenario scenario_0)
		{
			EventAction_TeleportInArea result;
			try
			{
				EventAction_TeleportInArea eventAction_TeleportInArea = new EventAction_TeleportInArea();
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
								if (Operators.CompareString(name, "UnitIDs", false) != 0)
								{
									if (Operators.CompareString(name, "Area", false) != 0)
									{
										continue;
									}
									try
									{
										foreach (object obj2 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode2 = (XmlNode)obj2;
											eventAction_TeleportInArea.list_0.Add(ReferencePoint.smethod_13(ref xmlNode2, ref dictionary_0));
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
								try
								{
									foreach (object obj3 in xmlNode.ChildNodes)
									{
										XmlNode xmlNode3 = (XmlNode)obj3;
										eventAction_TeleportInArea.hashSet_0.Add(xmlNode3.InnerText);
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
							eventAction_TeleportInArea.string_2 = xmlNode.InnerText;
						}
						else
						{
							eventAction_TeleportInArea.vmethod_0(xmlNode.InnerText);
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
				result = eventAction_TeleportInArea;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100514", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new EventAction_TeleportInArea();
			}
			return result;
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0011966C File Offset: 0x0011786C
		public override void vmethod_5(Scenario scenario_0, SimEvent simEvent_0)
		{
			Geopoint_Struct geopoint_Struct = default(Geopoint_Struct);
			try
			{
				try
				{
					foreach (string key in this.hashSet_0)
					{
						ActiveUnit activeUnit;
						try
						{
							activeUnit = scenario_0.vmethod_0()[key];
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 200459", ex.Message);
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							continue;
						}
						if (!Information.IsNothing(activeUnit))
						{
							int i = 0;
							while (i < 1000)
							{
								geopoint_Struct = Math2.smethod_23(this.list_0);
								if (Information.IsNothing(geopoint_Struct) || geopoint_Struct.method_0())
								{
									string str = "";
									if (activeUnit.bool_3 && Operators.CompareString(activeUnit.Name, activeUnit.string_2, false) != 0)
									{
										str = " (" + activeUnit.string_2 + ")";
									}
									activeUnit.method_124(activeUnit.Name + str + " is unable to pick a suitable point inside area defined by Ref. Points: " + string.Join(" - ", Enumerable.Select<ReferencePoint, string>(this.list_0, (EventAction_TeleportInArea._Closure$__.$I5-0 == null) ? (EventAction_TeleportInArea._Closure$__.$I5-0 = new Func<ReferencePoint, string>(EventAction_TeleportInArea._Closure$__.$I.method_0)) : EventAction_TeleportInArea._Closure$__.$I5-0)), activeUnit.Name + " cannot pick suitable point", LoggedMessage.MessageType.UnitAI, 1, false, new Geopoint_Struct(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
									return;
								}
								try
								{
									i++;
									Unit unit = activeUnit;
									double double_ = geopoint_Struct.double_1;
									double double_2 = geopoint_Struct.double_0;
									int num = 0;
									bool bool_ = true;
									bool bool_2 = true;
									bool bool_3 = false;
									bool flag = true;
									bool bool_4 = true;
									bool flag2 = true;
									float? nullable_ = null;
									short? nullable_2 = null;
									float float_ = 0f;
									bool bool_5 = false;
									bool bool_6 = false;
									string text = "";
									bool flag3 = false;
									List<ActiveUnit> list;
									if (unit.vmethod_47(double_, double_2, ref num, bool_, bool_2, bool_3, ref flag, bool_4, ref flag2, nullable_, nullable_2, ref list, float_, bool_5, bool_6, ref text, ref flag3))
									{
										activeUnit.vmethod_42(ref scenario_0, geopoint_Struct.double_0, geopoint_Struct.double_1);
										break;
									}
								}
								catch (Exception ex2)
								{
									ex2.Data.Add("Error at 200460", ex2.Message);
									GameGeneral.smethod_25(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
								}
							}
						}
					}
				}
				finally
				{
					HashSet<string>.Enumerator enumerator;
					enumerator.Dispose();
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 100515", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00119964 File Offset: 0x00117B64
		public override EventAction vmethod_6()
		{
			EventAction_TeleportInArea eventAction_TeleportInArea = (EventAction_TeleportInArea)base.MemberwiseClone();
			eventAction_TeleportInArea.vmethod_0(Guid.NewGuid().ToString());
			eventAction_TeleportInArea.string_2 = "[CLONE] " + this.string_2;
			eventAction_TeleportInArea.Name = "[CLONE] " + this.Name;
			return eventAction_TeleportInArea;
		}

		// Token: 0x0400097B RID: 2427
		public HashSet<string> hashSet_0;

		// Token: 0x0400097C RID: 2428
		public List<ReferencePoint> list_0;
	}
}
