using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns12;
using ns14;

namespace Command_Core
{
	// Token: 0x02000372 RID: 882
	public sealed class WeaponImpact : Unit
	{
		// Token: 0x06001A7C RID: 6780 RVA: 0x001DF5E8 File Offset: 0x001DD7E8
		public WeaponImpact(ref Scenario scenario_0, double double_2, double double_3, float float_10, WeaponImpact.Enum124 enum124_1, int int_1)
		{
			this.vmethod_29(null, double_2);
			this.vmethod_31(null, double_3);
			this.vmethod_15(false, float_10);
			this.enum124_0 = enum124_1;
			this.int_0 = int_1;
			if (!Information.IsNothing(scenario_0))
			{
				scenario_0.vmethod_14().method_4(this);
			}
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x001DF64C File Offset: 0x001DD84C
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("WeaponImpact");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				if (hashSet_0.Contains(this.string_0))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(this.string_0);
					xmlWriter_0.WriteElementString("Name", this.Name);
					xmlWriter_0.WriteElementString("CurrentAltitude", XmlConvert.ToString(this.vmethod_14(false)));
					xmlWriter_0.WriteElementString("Longitude", XmlConvert.ToString(this.vmethod_28(null)));
					xmlWriter_0.WriteElementString("Latitude", XmlConvert.ToString(this.vmethod_30(null)));
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Type";
					short num = (short)this.enum124_0;
					xmlWriter.WriteElementString(localName, num.ToString());
					xmlWriter_0.WriteElementString("Age", XmlConvert.ToString(this.float_9));
					xmlWriter_0.WriteStartElement("RangeSymbols");
					try
					{
						foreach (RangeSymbol rangeSymbol in base.method_17())
						{
							xmlWriter_0.WriteRaw(rangeSymbol.method_8());
						}
					}
					finally
					{
						List<RangeSymbol>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteElementString("Message", this.string_3);
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101328", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00009823 File Offset: 0x00007A23
		private WeaponImpact()
		{
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0000D750 File Offset: 0x0000B950
		public void method_56(ref Scenario scenario_0, float float_10)
		{
			this.float_9 += float_10;
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x001DF814 File Offset: 0x001DDA14
		public static WeaponImpact smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0)
		{
			WeaponImpact result;
			try
			{
				WeaponImpact weaponImpact = new WeaponImpact();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 1836990821U)
						{
							if (num <= 441941816U)
							{
								if (num != 266367750U)
								{
									if (num == 441941816U)
									{
										if (Operators.CompareString(name, "CurrentAltitude", false) == 0)
										{
											weaponImpact.vmethod_15(false, XmlConvert.ToSingle(xmlNode.InnerText));
										}
									}
								}
								else if (Operators.CompareString(name, "Name", false) == 0)
								{
									weaponImpact.Name = xmlNode.InnerText;
								}
							}
							else if (num != 1458105184U)
							{
								if (num != 1729717486U)
								{
									if (num == 1836990821U)
									{
										if (Operators.CompareString(name, "Latitude", false) == 0)
										{
											weaponImpact.vmethod_31(null, XmlConvert.ToDouble(xmlNode.InnerText));
										}
									}
								}
								else if (Operators.CompareString(name, "Longitude", false) == 0)
								{
									weaponImpact.vmethod_29(null, XmlConvert.ToDouble(xmlNode.InnerText));
								}
							}
							else if (Operators.CompareString(name, "ID", false) == 0)
							{
								if (dictionary_0.ContainsKey(xmlNode.InnerText))
								{
									return (WeaponImpact)dictionary_0[xmlNode.InnerText];
								}
								weaponImpact.vmethod_0(xmlNode.InnerText);
								dictionary_0.Add(weaponImpact.string_0, weaponImpact);
							}
						}
						else if (num <= 2920208772U)
						{
							if (num != 2395726140U)
							{
								if (num != 2496321123U)
								{
									if (num != 2920208772U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Message", false) == 0)
									{
										weaponImpact.string_3 = xmlNode.InnerText;
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "RangeSymbols", false) != 0)
									{
										continue;
									}
									try
									{
										foreach (object obj2 in xmlNode.ChildNodes)
										{
											RangeSymbol item = RangeSymbol.smethod_0((XmlNode)obj2, dictionary_0);
											weaponImpact.method_17().Add(item);
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
							if (Operators.CompareString(name, "Age", false) == 0)
							{
								weaponImpact.float_9 = XmlConvert.ToSingle(xmlNode.InnerText);
							}
						}
						else if (num != 3283119613U)
						{
							if (num != 3512062061U)
							{
								if (num == 4152621540U)
								{
									if (Operators.CompareString(name, "CurrentHeading", false) == 0)
									{
										weaponImpact.vmethod_10((float)XmlConvert.ToDouble(xmlNode.InnerText));
									}
								}
							}
							else if (Operators.CompareString(name, "Type", false) == 0)
							{
								if (xmlNode.InnerText.Contains("Kinetic"))
								{
									weaponImpact.enum124_0 = WeaponImpact.Enum124.const_0;
								}
								else
								{
									weaponImpact.enum124_0 = (WeaponImpact.Enum124)Conversions.ToShort(xmlNode.InnerText);
								}
							}
						}
						else if (Operators.CompareString(name, "CurrentSpeed", false) == 0)
						{
							weaponImpact.vmethod_41((float)XmlConvert.ToDouble(xmlNode.InnerText));
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
				result = weaponImpact;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100880", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new WeaponImpact();
			}
			return result;
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x001DFBE0 File Offset: 0x001DDDE0
		public static void smethod_1(WeaponImpact weaponImpact_0, Scenario scenario_0)
		{
			foreach (IEventExporter eventExporter in scenario_0.method_6())
			{
				if (eventExporter.imethod_8() && eventExporter.imethod_24())
				{
					Dictionary<string, IEventExporter.EventNotificationParameter> dictionary = new Dictionary<string, IEventExporter.EventNotificationParameter>();
					if (scenario_0.MonteCarloIteration > 0)
					{
						dictionary.Add("Scenario", new IEventExporter.EventNotificationParameter(scenario_0.method_0(), typeof(string), 500));
						dictionary.Add("MC_Run", new IEventExporter.EventNotificationParameter(scenario_0.MonteCarloIteration, typeof(int), 0));
					}
					dictionary.Add("TimelineID", new IEventExporter.EventNotificationParameter(scenario_0.TimelineID, typeof(string), 40));
					if (eventExporter.imethod_10())
					{
						dictionary.Add("Time", new IEventExporter.EventNotificationParameter(scenario_0.method_31().Subtract(scenario_0.ZeroHour).ToString("c"), typeof(TimeSpan), 0));
					}
					else
					{
						dictionary.Add("Time", new IEventExporter.EventNotificationParameter(scenario_0.method_31().ToString("MM/dd/yyyy HH:mm:ss") + "." + scenario_0.method_31().Millisecond.ToString("D3"), typeof(DateTime), 0));
					}
					dictionary.Add("UnitID", new IEventExporter.EventNotificationParameter(weaponImpact_0.string_0, typeof(string), 40));
					dictionary.Add("UnitLongitude", new IEventExporter.EventNotificationParameter(weaponImpact_0.vmethod_28(null), typeof(double), 0));
					dictionary.Add("UnitLatitude", new IEventExporter.EventNotificationParameter(weaponImpact_0.vmethod_30(null), typeof(double), 0));
					dictionary.Add("UnitCourse", new IEventExporter.EventNotificationParameter(weaponImpact_0.vmethod_9(), typeof(float), 0));
					dictionary.Add("UnitSpeed_kts", new IEventExporter.EventNotificationParameter(weaponImpact_0.vmethod_40(), typeof(float), 0));
					dictionary.Add("UnitAltitude_m", new IEventExporter.EventNotificationParameter(weaponImpact_0.vmethod_14(false), typeof(float), 0));
					eventExporter.imethod_6(IEventExporter.ExportedEventType.WeaponImpact, dictionary, scenario_0);
				}
			}
			foreach (Interface8 @interface in Class409.interface8_0)
			{
				if (@interface.imethod_2())
				{
					@interface.imethod_1(Interface8.Enum135.const_4, new Dictionary<string, Tuple<Type, string>>
					{
						{
							"TimelineID",
							new Tuple<Type, string>(typeof(string), scenario_0.TimelineID)
						},
						{
							"Time",
							new Tuple<Type, string>(typeof(DateTime), scenario_0.method_31().ToString("MM/dd/yyyy HH:mm:ss") + "." + scenario_0.method_31().Millisecond.ToString("D3"))
						},
						{
							"UnitID",
							new Tuple<Type, string>(typeof(string), weaponImpact_0.string_0)
						},
						{
							"Longitude",
							new Tuple<Type, string>(typeof(double), weaponImpact_0.vmethod_28(null).ToString())
						},
						{
							"Latitude",
							new Tuple<Type, string>(typeof(double), weaponImpact_0.vmethod_30(null).ToString())
						},
						{
							"Altitude",
							new Tuple<Type, string>(typeof(float), weaponImpact_0.vmethod_14(false).ToString())
						},
						{
							"EventType",
							new Tuple<Type, string>(typeof(string), "Explosion")
						},
						{
							"WeaponDBID",
							new Tuple<Type, string>(typeof(string), Conversions.ToString(weaponImpact_0.int_0))
						}
					}, scenario_0);
				}
			}
		}

		// Token: 0x04001736 RID: 5942
		public WeaponImpact.Enum124 enum124_0;

		// Token: 0x04001737 RID: 5943
		public float float_9;

		// Token: 0x04001738 RID: 5944
		public int int_0;

		// Token: 0x02000373 RID: 883
		internal enum Enum124 : short
		{
			// Token: 0x0400173A RID: 5946
			const_0,
			// Token: 0x0400173B RID: 5947
			const_1
		}
	}
}
