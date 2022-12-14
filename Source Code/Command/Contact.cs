using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Xml;
using Command_Core.DAL;
using CSMaterial.ClipperLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns12;
using ns13;
using ns14;
using ns8;

namespace Command_Core
{
	// Token: 0x020001C2 RID: 450
	public class Contact : Contact_Base
	{
		// Token: 0x06000DE8 RID: 3560 RVA: 0x00009488 File Offset: 0x00007688
		[CompilerGenerated]
		private virtual ObservableDictionary<int, EmissionContainer> vmethod_49()
		{
			return this.observableDictionary_0;
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0011191C File Offset: 0x0010FB1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void vmethod_50(ObservableDictionary<int, EmissionContainer> observableDictionary_2)
		{
			INotifyDictionaryChanged<int, EmissionContainer>.DictionaryChangedEventHandler obj = new INotifyDictionaryChanged<int, EmissionContainer>.DictionaryChangedEventHandler(this.method_140);
			ObservableDictionary<int, EmissionContainer> observableDictionary = this.observableDictionary_0;
			if (observableDictionary != null)
			{
				observableDictionary.DictionaryChanged -= obj;
			}
			this.observableDictionary_0 = observableDictionary_2;
			observableDictionary = this.observableDictionary_0;
			if (observableDictionary != null)
			{
				observableDictionary.DictionaryChanged += obj;
			}
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00009490 File Offset: 0x00007690
		public float method_57()
		{
			return this.float_15;
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00009498 File Offset: 0x00007698
		public void method_58(float float_19)
		{
			this.float_15 = float_19;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000094A1 File Offset: 0x000076A1
		public float method_59()
		{
			return this.float_10;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x000094A9 File Offset: 0x000076A9
		public void method_60(float float_19)
		{
			this.float_10 = float_19;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00111960 File Offset: 0x0010FB60
		public string method_61(HashSet<string> hashSet_0)
		{
			string result;
			try
			{
				if (this.stringBuilder_0 == null)
				{
					this.stringBuilder_0 = new StringBuilder(1000);
				}
				else
				{
					this.stringBuilder_0.Clear();
				}
				this.stringBuilder_0.Append("<Contact>");
				this.stringBuilder_0.Append("<ID>").Append(this.string_0).Append("</ID>");
				if (!Information.IsNothing(hashSet_0))
				{
					if (hashSet_0.Contains(this.string_0))
					{
						this.stringBuilder_0.Append("</Contact>");
						return this.stringBuilder_0.ToString();
					}
					hashSet_0.Add(this.string_0);
				}
				this.stringBuilder_0.Append("<Name>").Append(SecurityElement.Escape(this.Name)).Append("</Name>");
				if (this.vmethod_9() != 0f)
				{
					this.stringBuilder_0.Append("<CH>").Append(XmlConvert.ToString(this.vmethod_9())).Append("</CH>");
				}
				if (this.vmethod_40() != 0f)
				{
					this.stringBuilder_0.Append("<CS>").Append(XmlConvert.ToString(this.vmethod_40())).Append("</CS>");
				}
				if (this.vmethod_14(false) != 0f)
				{
					this.stringBuilder_0.Append("<CA>").Append(XmlConvert.ToString(this.vmethod_14(false))).Append("</CA>");
				}
				this.stringBuilder_0.Append("<Lon>").Append(XmlConvert.ToString(this.vmethod_28(null))).Append("</Lon>");
				this.stringBuilder_0.Append("<Lat>").Append(XmlConvert.ToString(this.vmethod_30(null))).Append("</Lat>");
				if (!string.IsNullOrEmpty(this.string_2))
				{
					this.stringBuilder_0.Append("<UnitClass>").Append(this.string_2).Append("</UnitClass>");
				}
				if (this.side_0 != null)
				{
					this.stringBuilder_0.Append("<Side>").Append(SecurityElement.Escape(this.side_0.method_51())).Append("</Side>");
				}
				if (!string.IsNullOrEmpty(this.string_3))
				{
					this.stringBuilder_0.Append("<Message>").Append(SecurityElement.Escape(this.string_3)).Append("</Message>");
				}
				if (this.activeUnit_0 != null)
				{
					this.stringBuilder_0.Append("<ActualUnitID>").Append(this.activeUnit_0.string_0).Append("</ActualUnitID>");
				}
				if (this.method_121())
				{
					this.stringBuilder_0.Append("<IPLOTP>").Append("True").Append("</IPLOTP>");
				}
				if (this.method_96() != 0f)
				{
					this.stringBuilder_0.Append("<RCTT>").Append(XmlConvert.ToString(this.method_96())).Append("</RCTT>");
				}
				if (this.method_98() != 0f)
				{
					this.stringBuilder_0.Append("<RCTTP>").Append(XmlConvert.ToString(this.method_98())).Append("</RCTTP>");
				}
				StringBuilder stringBuilder = this.stringBuilder_0.Append("<IDStatus>");
				int num = (int)this.identificationStatus_0;
				stringBuilder.Append(num.ToString()).Append("</IDStatus>");
				if (this.float_9 != 0f)
				{
					this.stringBuilder_0.Append("<TSD>").Append(((int)Math.Round((double)this.float_9)).ToString()).Append("</TSD>");
				}
				if (this.method_59() != 0f)
				{
					this.stringBuilder_0.Append("<TS_BDA>").Append(((int)Math.Round((double)this.method_59())).ToString()).Append("</TS_BDA>");
				}
				if (this.float_11 != 0f)
				{
					this.stringBuilder_0.Append("<TS_Recon>").Append(((int)Math.Round((double)this.float_11)).ToString()).Append("</TS_Recon>");
				}
				if (this.bool_12)
				{
					this.stringBuilder_0.Append("<SIK>").Append(this.bool_12.ToString()).Append("</SIK>");
				}
				if (this.bool_20)
				{
					this.stringBuilder_0.Append("<ISS>").Append("True").Append("</ISS>");
				}
				if (this.dictionary_0.Count > 0)
				{
					this.stringBuilder_0.Append("<Stance>");
					try
					{
						foreach (KeyValuePair<Side, Misc.PostureStance> keyValuePair in this.dictionary_0)
						{
							this.stringBuilder_0.Append("<Stance_").Append(keyValuePair.Key.string_0).Append(">").Append(((int)keyValuePair.Value).ToString()).Append("</Stance_").Append(keyValuePair.Key.string_0).Append(">");
						}
					}
					finally
					{
						Dictionary<Side, Misc.PostureStance>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.stringBuilder_0.Append("</Stance>");
				}
				if (!Information.IsNothing(this.contactType_0))
				{
					StringBuilder stringBuilder2 = this.stringBuilder_0.Append("<Type>");
					num = (int)this.contactType_0;
					stringBuilder2.Append(num.ToString()).Append("</Type>");
				}
				if (this.bool_16)
				{
					this.stringBuilder_0.Append("<IFO>").Append("True").Append("</IFO>");
				}
				if (this.nullable_11 != null)
				{
					this.stringBuilder_0.Append("<BDA_Struct>").Append(((byte)this.nullable_11.Value).ToString()).Append("</BDA_Struct>");
				}
				if (this.nullable_12 != null)
				{
					this.stringBuilder_0.Append("<BDA_Fire>").Append(((byte)this.nullable_12.Value).ToString()).Append("</BDA_Fire>");
				}
				if (this.nullable_13 != null)
				{
					this.stringBuilder_0.Append("<BDA_Flood>").Append(((byte)this.nullable_13.Value).ToString()).Append("</BDA_Flood>");
				}
				if (this.bool_18)
				{
					this.stringBuilder_0.Append("<H_Known>").Append("True").Append("</H_Known>");
				}
				if (this.bool_17)
				{
					this.stringBuilder_0.Append("<S_Known>").Append("True").Append("</S_Known>");
				}
				if (this.bool_19)
				{
					this.stringBuilder_0.Append("<A_Known>").Append("True").Append("</A_Known>");
				}
				if (!Information.IsNothing(this.list_3) && !Information.IsNothing(this.list_3))
				{
					this.stringBuilder_0.Append("<UA>");
					try
					{
						foreach (GeoPoint geoPoint in this.list_3)
						{
							this.stringBuilder_0.Append(geoPoint.method_8(hashSet_0));
						}
					}
					finally
					{
						List<GeoPoint>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					this.stringBuilder_0.Append("</UA>");
				}
				if (this.method_57() != 0f)
				{
					this.stringBuilder_0.Append("<Age>").Append(XmlConvert.ToString(this.method_57())).Append("</Age>");
				}
				if (this.float_16 != 0f)
				{
					this.stringBuilder_0.Append("<HeldFor>").Append(XmlConvert.ToString(this.float_16)).Append("</HeldFor>");
				}
				this.stringBuilder_0.Append("<AInc>").Append(this.int_0.ToString()).Append("</AInc>");
				if (!Information.IsNothing(this.side_1))
				{
					this.stringBuilder_0.Append("<ODS>").Append(SecurityElement.Escape(this.side_1.method_51())).Append("</ODS>");
				}
				if (!Information.IsNothing(this.method_68()) && this.method_67())
				{
					this.stringBuilder_0.Append("<DEm>");
					try
					{
						foreach (KeyValuePair<int, EmissionContainer> keyValuePair2 in this.method_68())
						{
							this.stringBuilder_0.Append("<Emission").Append(Conversions.ToString(keyValuePair2.Key)).Append(">").Append(keyValuePair2.Value.ToString()).Append("</Emission").Append(Conversions.ToString(keyValuePair2.Key)).Append(">");
						}
					}
					finally
					{
						IEnumerator<KeyValuePair<int, EmissionContainer>> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
					this.stringBuilder_0.Append("</DEm>");
				}
				if (this.list_2.Count > 0)
				{
					this.stringBuilder_0.Append("<RHU>");
					try
					{
						foreach (Contact.Class269 @class in this.list_2)
						{
							this.stringBuilder_0.Append(@class.method_0());
						}
					}
					finally
					{
						List<Contact.Class269>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
					this.stringBuilder_0.Append("</RHU>");
				}
				if (!Information.IsNothing(this.nullable_14))
				{
					this.stringBuilder_0.Append("<TimeSinceDetection_Radar>").Append(this.nullable_14.ToString()).Append("</TimeSinceDetection_Radar>");
				}
				if (!Information.IsNothing(this.nullable_15))
				{
					this.stringBuilder_0.Append("<TimeSinceDetection_ESM>").Append(this.nullable_15.ToString()).Append("</TimeSinceDetection_ESM>");
				}
				if (!Information.IsNothing(this.nullable_16))
				{
					this.stringBuilder_0.Append("<TimeSinceDetection_Visual>").Append(this.nullable_16.ToString()).Append("</TimeSinceDetection_Visual>");
				}
				if (!Information.IsNothing(this.nullable_17))
				{
					this.stringBuilder_0.Append("<TimeSinceDetection_Infrared>").Append(this.nullable_17.ToString()).Append("</TimeSinceDetection_Infrared>");
				}
				if (!Information.IsNothing(this.nullable_18))
				{
					this.stringBuilder_0.Append("<TimeSinceDetection_SonarActive>").Append(this.nullable_18.ToString()).Append("</TimeSinceDetection_SonarActive>");
				}
				if (!Information.IsNothing(this.nullable_19))
				{
					this.stringBuilder_0.Append("<TimeSinceDetection_SonarPassive>").Append(this.nullable_19.ToString()).Append("</TimeSinceDetection_SonarPassive>");
				}
				if (this.queue_0.Count > 0)
				{
					this.stringBuilder_0.Append("<LastDetections>");
					try
					{
						foreach (ValueTuple<string, string, float, ActiveUnit_Sensory.Enum35, DateTime> valueTuple in this.queue_0)
						{
							this.stringBuilder_0.Append("<DET>").Append(valueTuple.Item1).Append("_").Append(valueTuple.Item2).Append("_").Append(XmlConvert.ToString(valueTuple.Item3)).Append("_").Append((int)valueTuple.Item4).Append("_").Append(valueTuple.Item5.ToBinary().ToString()).Append("</DET>");
						}
					}
					finally
					{
						Queue<ValueTuple<string, string, float, ActiveUnit_Sensory.Enum35, DateTime>>.Enumerator enumerator5;
						enumerator5.Dispose();
					}
					this.stringBuilder_0.Append("</LastDetections>");
				}
				if (this.bool_21)
				{
					this.stringBuilder_0.Append("<SZC>True</SZC>");
				}
				this.stringBuilder_0.Append("</Contact>");
				result = this.stringBuilder_0.ToString();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 1002134210938549324589328", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x001126BC File Offset: 0x001108BC
		public static Contact smethod_0(string string_7, ref Dictionary<string, Class310> dictionary_2)
		{
			Contact result;
			try
			{
				if (dictionary_2.ContainsKey(string_7))
				{
					result = (Contact)dictionary_2[string_7];
				}
				else
				{
					result = null;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100478", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00112730 File Offset: 0x00110930
		public static Contact smethod_1(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_2)
		{
			Contact contact = new Contact();
			Contact result;
			try
			{
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num > 1938016866U)
						{
							if (num <= 2815008834U)
							{
								if (num <= 2395726140U)
								{
									if (num <= 2028919382U)
									{
										if (num != 1945347683U)
										{
											if (num != 2010780873U)
											{
												if (num != 2028919382U)
												{
													continue;
												}
												if (Operators.CompareString(name, "RHU", false) != 0)
												{
													continue;
												}
												try
												{
													foreach (object obj2 in xmlNode.ChildNodes)
													{
														Contact.Class269 item = Contact.Class269.smethod_0((XmlNode)obj2);
														contact.list_2.Add(item);
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
											if (Operators.CompareString(name, "CA", false) == 0)
											{
												goto IL_941;
											}
											continue;
										}
										else if (Operators.CompareString(name, "UA", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (num > 2128224206U)
										{
											goto IL_A29;
										}
										if (num != 2106523062U)
										{
											if (num != 2128224206U)
											{
												continue;
											}
											if (Operators.CompareString(name, "CH", false) != 0)
											{
												continue;
											}
											goto IL_FAB;
										}
										else if (Operators.CompareString(name, "UncertaintyArea", false) != 0)
										{
											continue;
										}
									}
									if (xmlNode.ChildNodes.Count <= 0)
									{
										continue;
									}
									contact.method_113(new List<GeoPoint>());
									try
									{
										foreach (object obj3 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode2 = (XmlNode)obj3;
											GeoPoint item2 = GeoPoint.smethod_0(ref xmlNode2, ref dictionary_2);
											contact.method_112().Add(item2);
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
									IL_A29:
									if (num != 2183398782U)
									{
										if (num != 2395726140U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Age", false) == 0)
										{
											contact.method_58(XmlConvert.ToSingle(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TimeSinceDetection_SonarPassive", false) == 0)
										{
											contact.nullable_19 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
											continue;
										}
										continue;
									}
								}
								else if (num <= 2564648390U)
								{
									if (num != 2461521368U)
									{
										if (num != 2496321123U)
										{
											if (num != 2564648390U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Lon", false) == 0)
											{
												goto IL_AE2;
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
												foreach (object obj4 in xmlNode.ChildNodes)
												{
													RangeSymbol item3 = RangeSymbol.smethod_0((XmlNode)obj4, dictionary_2);
													contact.method_17().Add(item3);
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
									}
									if (Operators.CompareString(name, "A_Known", false) == 0)
									{
										contact.bool_19 = true;
										continue;
									}
									continue;
								}
								else if (num <= 2690417586U)
								{
									if (num != 2590053246U)
									{
										if (num != 2690417586U)
										{
											continue;
										}
										if (Operators.CompareString(name, "BDA_Struct", false) == 0)
										{
											contact.nullable_11 = new Contact.Enum47?((Contact.Enum47)Conversions.ToByte(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Side", false) == 0)
										{
											contact.string_5 = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else if (num != 2704016193U)
								{
									if (num != 2815008834U)
									{
										continue;
									}
									if (Operators.CompareString(name, "RCTT", false) == 0)
									{
										contact.method_97(XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "BDA_Flood", false) == 0)
									{
										contact.nullable_13 = new ActiveUnit_Damage.FloodingIntensityLevel?((ActiveUnit_Damage.FloodingIntensityLevel)Conversions.ToByte(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else if (num <= 3215976043U)
							{
								if (num <= 2905192438U)
								{
									if (num != 2847628961U)
									{
										if (num != 2885753020U)
										{
											if (num != 2905192438U)
											{
												continue;
											}
											if (Operators.CompareString(name, "S_Known", false) == 0)
											{
												contact.bool_17 = true;
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "TS_Recon", false) == 0)
											{
												contact.float_11 = (float)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "SideIsKnown", false) == 0)
										{
											goto IL_CFB;
										}
										continue;
									}
								}
								else if (num <= 3001749054U)
								{
									if (num != 2920208772U)
									{
										if (num != 3001749054U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Lat", false) == 0)
										{
											goto IL_D42;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Message", false) == 0)
										{
											contact.string_3 = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else if (num != 3093760719U)
								{
									if (num != 3215976043U)
									{
										continue;
									}
									if (Operators.CompareString(name, "IFO", false) == 0)
									{
										contact.bool_16 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TimeSinceDetection_SonarActive", false) == 0)
									{
										contact.nullable_18 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
									continue;
								}
							}
							else if (num <= 3429113205U)
							{
								if (num <= 3337381568U)
								{
									if (num != 3283119613U)
									{
										if (num != 3337381568U)
										{
											continue;
										}
										if (Operators.CompareString(name, "AInc", false) == 0)
										{
											goto IL_E49;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "CurrentSpeed", false) == 0)
										{
											goto IL_E70;
										}
										continue;
									}
								}
								else if (num != 3420705970U)
								{
									if (num != 3429113205U)
									{
										continue;
									}
									if (Operators.CompareString(name, "IsPreciselyLocatedOnThisPulse", false) == 0)
									{
										goto IL_EAE;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "ISS", false) == 0)
									{
										goto IL_ED5;
									}
									continue;
								}
							}
							else if (num <= 3527340789U)
							{
								if (num != 3512062061U)
								{
									if (num != 3527340789U)
									{
										continue;
									}
									if (Operators.CompareString(name, "HeldFor", false) == 0)
									{
										contact.float_16 = XmlConvert.ToSingle(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Type", false) != 0)
									{
										continue;
									}
									if (Versioned.IsNumeric(xmlNode.InnerText))
									{
										contact.contactType_0 = (Contact_Base.ContactType)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									contact.contactType_0 = (Contact_Base.ContactType)Enum.Parse(typeof(Contact_Base.ContactType), xmlNode.InnerText, true);
									continue;
								}
							}
							else if (num != 3586924095U)
							{
								if (num != 4152621540U)
								{
									continue;
								}
								if (Operators.CompareString(name, "CurrentHeading", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "OriginalDetectorSide", false) == 0)
								{
									goto IL_FCC;
								}
								continue;
							}
							IL_FAB:
							contact.vmethod_10(XmlConvert.ToSingle(xmlNode.InnerText));
							continue;
						}
						if (num <= 969277257U)
						{
							if (num <= 687476049U)
							{
								if (num <= 441941816U)
								{
									if (num != 52089447U)
									{
										if (num != 266367750U)
										{
											if (num != 441941816U)
											{
												continue;
											}
											if (Operators.CompareString(name, "CurrentAltitude", false) != 0)
											{
												continue;
											}
											goto IL_941;
										}
										else
										{
											if (Operators.CompareString(name, "Name", false) == 0)
											{
												contact.Name = xmlNode.InnerText;
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "ODS", false) != 0)
										{
											continue;
										}
										goto IL_FCC;
									}
								}
								else if (num <= 605605343U)
								{
									if (num != 585602087U)
									{
										if (num != 605605343U)
										{
											continue;
										}
										if (Operators.CompareString(name, "H_Known", false) == 0)
										{
											contact.bool_18 = true;
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "BDA_Fire", false) == 0)
										{
											contact.nullable_12 = new ActiveUnit_Damage.FireIntensityLevel?((ActiveUnit_Damage.FireIntensityLevel)Conversions.ToByte(xmlNode.InnerText));
											continue;
										}
										continue;
									}
								}
								else if (num != 612623857U)
								{
									if (num != 687476049U)
									{
										continue;
									}
									if (Operators.CompareString(name, "TimeSinceDetection", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "IPLOTP", false) != 0)
									{
										continue;
									}
									goto IL_EAE;
								}
							}
							else if (num <= 777780549U)
							{
								if (num != 755333778U)
								{
									if (num != 770528374U)
									{
										if (num != 777780549U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Stance", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj5 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode3 = (XmlNode)obj5;
												if (Operators.CompareString(xmlNode3.Name, "#text", false) == 0)
												{
													if (Versioned.IsNumeric(xmlNode.InnerText))
													{
														contact.nullable_10 = new Misc.PostureStance?((Misc.PostureStance)Conversions.ToByte(xmlNode.InnerText));
													}
													else
													{
														contact.nullable_10 = new Misc.PostureStance?((Misc.PostureStance)Enum.Parse(typeof(Misc.PostureStance), xmlNode.InnerText, true));
													}
												}
												else
												{
													string key = xmlNode3.Name.Split(new char[]
													{
														'_'
													})[1];
													Misc.PostureStance value = (Misc.PostureStance)Conversions.ToByte(xmlNode3.InnerText);
													if (Information.IsNothing(contact.dictionary_1))
													{
														contact.dictionary_1 = new Dictionary<string, Misc.PostureStance>();
													}
													contact.dictionary_1.Add(key, value);
												}
											}
											continue;
										}
										finally
										{
											IEnumerator enumerator5;
											if (enumerator5 is IDisposable)
											{
												(enumerator5 as IDisposable).Dispose();
											}
										}
									}
									if (Operators.CompareString(name, "TimeSinceDetection_Visual", false) == 0)
									{
										contact.nullable_16 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TimeSinceDetection_Radar", false) == 0)
									{
										contact.nullable_14 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
									continue;
								}
							}
							else if (num <= 890166941U)
							{
								if (num != 879164502U)
								{
									if (num != 890166941U)
									{
										continue;
									}
									if (Operators.CompareString(name, "DEm", false) != 0)
									{
										continue;
									}
									goto IL_5EC;
								}
								else
								{
									if (Operators.CompareString(name, "RCTTP", false) == 0)
									{
										contact.method_99(XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (num != 894866588U)
								{
									if (num != 969277257U)
									{
										continue;
									}
									if (Operators.CompareString(name, "LastDetections", false) != 0)
									{
										continue;
									}
									try
									{
										foreach (object obj6 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode4 = (XmlNode)obj6;
											try
											{
												string[] array = xmlNode4.InnerText.Split(Conversions.ToCharArrayRankOne("_"));
												ValueTuple<string, string, float, ActiveUnit_Sensory.Enum35, DateTime> valueTuple;
												valueTuple.Item1 = array[0];
												valueTuple.Item2 = array[1];
												valueTuple.Item3 = XmlConvert.ToSingle(array[2]);
												valueTuple.Item4 = (ActiveUnit_Sensory.Enum35)Conversions.ToInteger(array[3]);
												valueTuple.Item5 = DateTime.FromBinary(Conversions.ToLong(array[4]));
												contact.queue_0.Enqueue(valueTuple);
											}
											catch (Exception ex)
											{
											}
										}
										continue;
									}
									finally
									{
										IEnumerator enumerator6;
										if (enumerator6 is IDisposable)
										{
											(enumerator6 as IDisposable).Dispose();
										}
									}
								}
								if (Operators.CompareString(name, "TSD", false) != 0)
								{
									continue;
								}
							}
							contact.float_9 = (float)Conversions.ToInteger(xmlNode.InnerText);
							continue;
						}
						if (num <= 1577754190U)
						{
							if (num <= 1177209905U)
							{
								if (num != 998171479U)
								{
									if (num != 1130593022U)
									{
										if (num != 1177209905U)
										{
											continue;
										}
										if (Operators.CompareString(name, "SZC", false) == 0)
										{
											contact.bool_21 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TS_BDA", false) == 0)
										{
											contact.method_60((float)Conversions.ToInteger(xmlNode.InnerText));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "TimeSinceDetection_Infrared", false) == 0)
									{
										contact.nullable_17 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (num > 1453604037U)
								{
									goto IL_67B;
								}
								if (num != 1397923717U)
								{
									if (num != 1453604037U)
									{
										continue;
									}
									if (Operators.CompareString(name, "TimeSinceDetection_ESM", false) == 0)
									{
										contact.nullable_15 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name, "DetectedEmissions", false) != 0)
								{
									continue;
								}
							}
						}
						else if (num <= 1708783731U)
						{
							if (num <= 1641540478U)
							{
								if (num != 1585573543U)
								{
									if (num != 1641540478U)
									{
										continue;
									}
									if (Operators.CompareString(name, "InheritsSideStance", false) != 0)
									{
										continue;
									}
									goto IL_ED5;
								}
								else
								{
									if (Operators.CompareString(name, "AutoIncrement", false) != 0)
									{
										continue;
									}
									goto IL_E49;
								}
							}
							else if (num != 1694424656U)
							{
								if (num != 1708783731U)
								{
									continue;
								}
								if (Operators.CompareString(name, "CS", false) != 0)
								{
									continue;
								}
								goto IL_E70;
							}
							else
							{
								if (Operators.CompareString(name, "ActualUnitID", false) == 0)
								{
									contact.string_6 = xmlNode.InnerText;
									continue;
								}
								continue;
							}
						}
						else if (num <= 1836990821U)
						{
							if (num != 1729717486U)
							{
								if (num != 1836990821U)
								{
									continue;
								}
								if (Operators.CompareString(name, "Latitude", false) != 0)
								{
									continue;
								}
								goto IL_D42;
							}
							else
							{
								if (Operators.CompareString(name, "Longitude", false) != 0)
								{
									continue;
								}
								goto IL_AE2;
							}
						}
						else if (num != 1848783177U)
						{
							if (num != 1938016866U)
							{
								continue;
							}
							if (Operators.CompareString(name, "IDStatus", false) != 0)
							{
								continue;
							}
							if (Versioned.IsNumeric(xmlNode.InnerText))
							{
								contact.identificationStatus_0 = (Contact_Base.IdentificationStatus)Conversions.ToShort(xmlNode.InnerText);
								continue;
							}
							contact.identificationStatus_0 = (Contact_Base.IdentificationStatus)Enum.Parse(typeof(Contact_Base.IdentificationStatus), xmlNode.InnerText, true);
							continue;
						}
						else
						{
							if (Operators.CompareString(name, "UnitClass", false) == 0)
							{
								contact.string_2 = xmlNode.InnerText;
								continue;
							}
							continue;
						}
						IL_5EC:
						try
						{
							foreach (object obj7 in xmlNode.ChildNodes)
							{
								XmlNode xmlNode5 = (XmlNode)obj7;
								int num2 = Conversions.ToInteger(xmlNode5.Name.Remove(0, 8));
								if (!contact.method_68().ContainsKey(num2))
								{
									ObservableDictionary<int, EmissionContainer> observableDictionary = contact.method_68();
									int key2 = num2;
									XmlNode xmlNode6;
									string innerText2 = (xmlNode6 = xmlNode5).InnerText;
									EmissionContainer value2 = EmissionContainer.smethod_0(ref innerText2);
									xmlNode6.InnerText = innerText2;
									observableDictionary.Add(key2, value2);
								}
							}
							continue;
						}
						finally
						{
							IEnumerator enumerator7;
							if (enumerator7 is IDisposable)
							{
								(enumerator7 as IDisposable).Dispose();
							}
						}
						IL_67B:
						if (num != 1458105184U)
						{
							if (num != 1577754190U)
							{
								continue;
							}
							if (Operators.CompareString(name, "SIK", false) != 0)
							{
								continue;
							}
							goto IL_CFB;
						}
						else
						{
							if (Operators.CompareString(name, "ID", false) != 0)
							{
								continue;
							}
							if (dictionary_2.ContainsKey(xmlNode.InnerText))
							{
								return (Contact)dictionary_2[xmlNode.InnerText];
							}
							if (xmlNode_0.ChildNodes.Count == 1)
							{
								return null;
							}
							contact.vmethod_0(xmlNode.InnerText);
							dictionary_2.Add(contact.string_0, contact);
							continue;
						}
						IL_941:
						contact.vmethod_15(false, XmlConvert.ToSingle(xmlNode.InnerText));
						continue;
						IL_AE2:
						contact.vmethod_29(null, XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", ".")));
						continue;
						IL_CFB:
						contact.bool_12 = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_D42:
						contact.vmethod_31(null, XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", ".")));
						continue;
						IL_E49:
						contact.int_0 = Conversions.ToInteger(xmlNode.InnerText);
						continue;
						IL_E70:
						contact.vmethod_41(XmlConvert.ToSingle(xmlNode.InnerText));
						continue;
						IL_EAE:
						contact.method_122(Conversions.ToBoolean(xmlNode.InnerText));
						continue;
						IL_ED5:
						contact.bool_20 = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_FCC:
						contact.string_4 = xmlNode.InnerText;
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
				result = contact;
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100479", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Contact();
			}
			return result;
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x000094B2 File Offset: 0x000076B2
		public override void vmethod_44(float float_19, Scenario scenario_0)
		{
			base.vmethod_44(float_19, scenario_0);
			if (scenario_0.SecondIsChangingOnThisPulse)
			{
				this.weapon_0 = null;
			}
			if (scenario_0.FifthMinuteIsChangingOnThisPulse)
			{
				this.bool_15 = false;
			}
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00113874 File Offset: 0x00111A74
		public void method_62(float float_19, Side side_2, Scenario scenario_0)
		{
			try
			{
				if (!Information.IsNothing(this.method_112()))
				{
					List<GeoPoint> list = Enumerable.ToList<GeoPoint>(this.method_112());
					try
					{
						foreach (GeoPoint geoPoint in list)
						{
							if (double.IsNaN(geoPoint.imethod_2()) || double.IsNaN(geoPoint.imethod_0()))
							{
								this.method_112().Remove(geoPoint);
							}
						}
					}
					finally
					{
						List<GeoPoint>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (!Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.method_5() && this.method_125() < Contact_Base.IdentificationStatus.PreciseID)
				{
					this.method_126(scenario_0, side_2, null, null, false, false, false, false, Contact_Base.IdentificationStatus.PreciseID);
				}
				if (scenario_0.SecondIsChangingOnThisPulse)
				{
					this.method_63(float_19, side_2, scenario_0);
				}
				if (this.method_96() > 0f && !Information.IsNothing(this.activeUnit_0))
				{
					this.method_58(0f);
					Contact contact = this;
					ActiveUnit_Sensory.smethod_3(ref contact, this.activeUnit_0, false, null);
				}
				if (this.method_57() == 0f)
				{
					ref float ptr = ref this.float_16;
					this.float_16 = ptr + float_19;
				}
				this.weapon_0 = null;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200641", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00113A00 File Offset: 0x00111C00
		public void method_63(float float_19, Side side_2, Scenario scenario_0)
		{
			if (!Information.IsNothing(this.activeUnit_0))
			{
				if (!Information.IsNothing(this.method_112()) && this.activeUnit_0.method_92(side_2))
				{
					this.method_113(null);
					return;
				}
				if (!Information.IsNothing(this.method_112()))
				{
					this.float_14 -= float_19;
					if (this.float_14 <= 0f)
					{
						this.method_139((double)this.float_13, ref scenario_0);
					}
					if (this.method_112().Count == 0)
					{
						this.method_113(null);
						return;
					}
				}
				else if (!this.method_121() & this.method_96() <= 0f)
				{
					this.method_139(1.0, ref scenario_0);
				}
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00113ABC File Offset: 0x00111CBC
		public bool method_64(ref Scenario scenario_0, ref Dictionary<string, Class310> dictionary_2, ref Side side_2)
		{
			bool result;
			try
			{
				if (!dictionary_2.ContainsKey(this.string_6))
				{
					result = false;
				}
				else
				{
					this.activeUnit_0 = (ActiveUnit)dictionary_2[this.string_6];
					foreach (Side side in scenario_0.method_44())
					{
						if (Operators.CompareString(side.method_51(), this.string_5, false) == 0)
						{
							this.side_0 = side;
						}
						if (Operators.CompareString(side.method_51(), this.string_4, false) == 0)
						{
							this.side_1 = side;
						}
					}
					if (Information.IsNothing(this.nullable_10))
					{
						Misc.PostureStance value;
						if (Information.IsNothing(this.dictionary_1) || !this.dictionary_1.TryGetValue(side_2.string_0, out value))
						{
							goto IL_F9;
						}
						Side key = Side.smethod_11(side_2.string_0, ref dictionary_2);
						try
						{
							this.dictionary_0.Add(key, value);
							goto IL_F9;
						}
						catch (Exception ex)
						{
							goto IL_F9;
						}
					}
					this.dictionary_0.Add(side_2, this.nullable_10.Value);
					IL_F9:
					this.dictionary_1 = null;
					result = true;
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 200023", ex2.Message);
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00113C40 File Offset: 0x00111E40
		private Contact()
		{
			this.dictionary_0 = new Dictionary<Side, Misc.PostureStance>();
			this.nullable_10 = null;
			this.float_9 = 0f;
			this.float_10 = 0f;
			this.float_11 = 0f;
			this.float_12 = 0f;
			this.list_2 = new List<Contact.Class269>();
			this.list_4 = new List<GeoPoint>();
			this.list_5 = new List<GeoPoint>();
			this.list_6 = new List<GeoPoint>();
			this.bool_20 = true;
			this.queue_0 = new Queue<ValueTuple<string, string, float, ActiveUnit_Sensory.Enum35, DateTime>>();
			this.object_0 = RuntimeHelpers.GetObjectValue(new object());
			this.object_1 = RuntimeHelpers.GetObjectValue(new object());
			this.object_2 = RuntimeHelpers.GetObjectValue(new object());
			if (!Information.IsNothing(this.activeUnit_0))
			{
				foreach (Side side in this.activeUnit_0.scenario_0.method_44())
				{
					if (!Information.IsNothing(side) && side.method_44().Contains(this))
					{
						this.dictionary_0.Add(side, Misc.PostureStance.Unknown);
					}
				}
			}
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00113D58 File Offset: 0x00111F58
		public void method_65(Side side_2, float float_19, Scenario scenario_0)
		{
			if (!Information.IsNothing(this.side_1) && Operators.CompareString(this.side_1.string_0, side_2.string_0, false) == 0)
			{
				this.method_97(this.method_96() - float_19);
				this.method_99(this.method_98() - float_19);
				ref float ptr = ref this.float_9;
				this.float_9 = ptr + float_19;
				ptr = ref this.float_11;
				this.float_11 = ptr + float_19;
				if (!Information.IsNothing(this.activeUnit_0))
				{
					if (!this.activeUnit_0.method_92(side_2) && this.method_96() <= 0f)
					{
						this.method_58(this.method_57() + float_19);
					}
					if (this.activeUnit_0.method_92(side_2))
					{
						this.method_60(this.method_59() + float_19);
					}
					if (this.method_68().Count > 0)
					{
						this.float_12 += float_19;
					}
				}
				if (!Information.IsNothing(this.nullable_14))
				{
					this.nullable_14 += float_19;
				}
				if (!Information.IsNothing(this.nullable_15))
				{
					this.nullable_15 += float_19;
				}
				if (!Information.IsNothing(this.nullable_16))
				{
					this.nullable_16 += float_19;
				}
				if (!Information.IsNothing(this.nullable_17))
				{
					this.nullable_17 += float_19;
				}
				if (!Information.IsNothing(this.nullable_18))
				{
					this.nullable_18 += float_19;
				}
				if (!Information.IsNothing(this.nullable_19))
				{
					this.nullable_19 += float_19;
				}
				try
				{
					foreach (Contact.Class269 @class in this.method_73(this.side_1))
					{
						@class.float_0 += float_19;
					}
				}
				finally
				{
					List<Contact.Class269>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00114038 File Offset: 0x00112238
		public void method_66(ref Scenario scenario_0)
		{
			if (this.method_57() < 60f)
			{
				this.float_14 = (float)GameGeneral.smethod_5().Next(5, 16);
			}
			else if (this.method_57() < 300f)
			{
				this.float_14 = 60f;
			}
			else if (this.method_57() < 7200f)
			{
				this.float_14 = 300f;
			}
			else
			{
				this.float_14 = 3600f;
			}
			if (scenario_0.method_47() > 0 && this.float_14 < (float)scenario_0.method_47())
			{
				this.float_14 = (float)scenario_0.method_47();
				if (scenario_0.method_47() < 3)
				{
					this.float_14 *= (float)GameGeneral.smethod_5().Next(2, 6);
				}
			}
			this.float_13 = this.float_14;
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00114100 File Offset: 0x00112300
		public bool method_67()
		{
			return !Information.IsNothing(this.vmethod_49()) && this.vmethod_49().Count > 0;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x000094DA File Offset: 0x000076DA
		public ObservableDictionary<int, EmissionContainer> method_68()
		{
			if (Information.IsNothing(this.vmethod_49()))
			{
				this.vmethod_50(new ObservableDictionary<int, EmissionContainer>());
			}
			return this.vmethod_49();
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x000094FA File Offset: 0x000076FA
		public void method_69(ObservableDictionary<int, EmissionContainer> observableDictionary_2)
		{
			if (!Information.IsNothing(this.vmethod_49()))
			{
				this.observableDictionary_1 = this.vmethod_49();
			}
			this.vmethod_50(observableDictionary_2);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00114130 File Offset: 0x00112330
		public List<int> method_70()
		{
			List<int> result;
			if (Information.IsNothing(this.activeUnit_0))
			{
				result = new List<int>();
			}
			else
			{
				GlobalVariables.ActiveUnitType activeUnitType_;
				switch (this.contactType_0)
				{
				case Contact_Base.ContactType.Air:
					activeUnitType_ = GlobalVariables.ActiveUnitType.Aircraft;
					goto IL_70;
				case Contact_Base.ContactType.Missile:
				case Contact_Base.ContactType.Torpedo:
					activeUnitType_ = GlobalVariables.ActiveUnitType.Weapon;
					goto IL_70;
				case Contact_Base.ContactType.Surface:
					activeUnitType_ = GlobalVariables.ActiveUnitType.Ship;
					goto IL_70;
				case Contact_Base.ContactType.Submarine:
					activeUnitType_ = GlobalVariables.ActiveUnitType.Submarine;
					goto IL_70;
				case Contact_Base.ContactType.Orbital:
					activeUnitType_ = GlobalVariables.ActiveUnitType.Satellite;
					goto IL_70;
				case Contact_Base.ContactType.Facility_Fixed:
				case Contact_Base.ContactType.Facility_Mobile:
					activeUnitType_ = GlobalVariables.ActiveUnitType.Facility;
					goto IL_70;
				}
				return new List<int>();
				IL_70:
				List<int> list = new List<int>();
				try
				{
					foreach (int num in this.method_68().Keys)
					{
						if (this.method_68()[num].bool_1)
						{
							list.Add(num);
						}
					}
				}
				finally
				{
					IEnumerator<int> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				result = DBFunctions.smethod_10(list, activeUnitType_, this.activeUnit_0.scenario_0, this.activeUnit_0.scenario_0.method_39());
			}
			return result;
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00114238 File Offset: 0x00112438
		public string method_71()
		{
			string result;
			if (this.activeUnit_0 != null)
			{
				switch (this.method_125())
				{
				case Contact_Base.IdentificationStatus.Unknown:
					result = "Type: Unknown";
					break;
				case Contact_Base.IdentificationStatus.KnownDomain:
					switch (this.contactType_0)
					{
					case Contact_Base.ContactType.Air:
					case Contact_Base.ContactType.Missile:
						return "Type: Unknown air contact";
					case Contact_Base.ContactType.Surface:
						return "Type: Unknown surface contact";
					case Contact_Base.ContactType.Submarine:
					case Contact_Base.ContactType.Torpedo:
						return "Type: Unknown underwater contact";
					case Contact_Base.ContactType.Facility_Fixed:
						return "Type: Unknown fixed facility";
					case Contact_Base.ContactType.Facility_Mobile:
						return "Type: Unknown mobile land unit";
					case Contact_Base.ContactType.Undetermined:
						return "Type: Undetermined";
					}
					result = this.contactType_0.ToString();
					break;
				case Contact_Base.IdentificationStatus.KnownType:
					result = "Type: " + this.activeUnit_0.vmethod_58();
					break;
				case Contact_Base.IdentificationStatus.KnownClass:
					result = "Class: " + this.activeUnit_0.string_2;
					break;
				case Contact_Base.IdentificationStatus.PreciseID:
					result = "Identified: " + this.activeUnit_0.Name;
					break;
				default:
					result = "";
					break;
				}
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00114364 File Offset: 0x00112564
		public bool method_72()
		{
			bool result;
			if (this.method_125() < Contact_Base.IdentificationStatus.KnownType)
			{
				result = false;
			}
			else if (Information.IsNothing(this.activeUnit_0))
			{
				result = false;
			}
			else
			{
				Contact_Base.ContactType contactType_ = this.contactType_0;
				if (contactType_ == Contact_Base.ContactType.Submarine)
				{
					Submarine._SubmarineType submarineType_ = ((Submarine)this.activeUnit_0)._SubmarineType_0;
					if (submarineType_ - Submarine._SubmarineType.Biologics <= 1)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x001143BC File Offset: 0x001125BC
		public List<Contact.Class269> method_73(Side side_2)
		{
			List<Contact.Class269> value;
			if (this.activeUnit_0 != null && side_2 != null && side_2.method_44() != null && this.activeUnit_0.bool_1)
			{
				Lazy<List<Contact.Class269>> lazy = new Lazy<List<Contact.Class269>>();
				try
				{
					foreach (Contact contact in side_2.method_44())
					{
						if (!Information.IsNothing(contact.activeUnit_0) && contact.activeUnit_0.method_120() && contact.activeUnit_0.vmethod_65(false) == this.activeUnit_0 && contact.method_73(side_2).Count > 0)
						{
							lazy.Value.AddRange(contact.method_73(side_2));
						}
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				value = lazy.Value;
			}
			else
			{
				value = this.list_2;
			}
			return value;
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0000951C File Offset: 0x0000771C
		public Contact.Enum47? method_74(Side side_2)
		{
			return this.nullable_11;
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00009524 File Offset: 0x00007724
		public void method_75(Side side_2, Contact.Enum47? nullable_28)
		{
			this.nullable_11 = nullable_28;
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0000952D File Offset: 0x0000772D
		public ActiveUnit_Damage.FireIntensityLevel? method_76(Side side_2)
		{
			return this.nullable_12;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00009535 File Offset: 0x00007735
		public void method_77(Side side_2, ActiveUnit_Damage.FireIntensityLevel? nullable_28)
		{
			this.nullable_12 = nullable_28;
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0000953E File Offset: 0x0000773E
		public ActiveUnit_Damage.FloodingIntensityLevel? method_78(Side side_2)
		{
			return this.nullable_13;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00009546 File Offset: 0x00007746
		public void method_79(Side side_2, ActiveUnit_Damage.FloodingIntensityLevel? nullable_28)
		{
			this.nullable_13 = nullable_28;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0011449C File Offset: 0x0011269C
		public short method_80()
		{
			short result;
			if (!this.method_91() && !this.method_109())
			{
				this.method_105();
				result = 2;
			}
			else
			{
				result = 10;
			}
			return result;
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x001144C8 File Offset: 0x001126C8
		public float? method_81()
		{
			float? result;
			try
			{
				if (this.method_125() < Contact_Base.IdentificationStatus.KnownClass)
				{
					result = null;
				}
				else if (Information.IsNothing(this.activeUnit_0))
				{
					result = null;
				}
				else
				{
					if (this.nullable_20 == null)
					{
						List<Weapon> list = new List<Weapon>();
						GlobalVariables.ActiveUnitType activeUnitType = this.activeUnit_0.vmethod_56();
						if (activeUnitType == GlobalVariables.ActiveUnitType.Aircraft)
						{
							try
							{
								int dbid = this.activeUnit_0.DBID;
								SQLiteConnection sqliteConnection = this.activeUnit_0.scenario_0.method_39();
								foreach (int int_ in DBFunctions.smethod_43(dbid, ref sqliteConnection))
								{
									Weapon weapon = this.activeUnit_0.scenario_0.method_87(int_);
									if (weapon.method_199())
									{
										list.Add(weapon);
									}
								}
								goto IL_114;
							}
							finally
							{
								List<int>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						list = Enumerable.ToList<Weapon>(Enumerable.Where<Weapon>(Enumerable.ToList<Weapon>(this.activeUnit_0.vmethod_89().method_2(false).Values), (Contact._Closure$__.$I99-0 == null) ? (Contact._Closure$__.$I99-0 = new Func<Weapon, bool>(Contact._Closure$__.$I.method_0)) : Contact._Closure$__.$I99-0));
						IL_114:
						if (list.Count == 0)
						{
							this.nullable_20 = new float?(0f);
						}
						else
						{
							this.nullable_20 = new float?(Enumerable.ElementAtOrDefault<Weapon>(Enumerable.OrderByDescending<Weapon, float>(list, (Contact._Closure$__.$I99-1 == null) ? (Contact._Closure$__.$I99-1 = new Func<Weapon, float>(Contact._Closure$__.$I.method_1)) : Contact._Closure$__.$I99-1), 0).float_29);
						}
					}
					result = this.nullable_20;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100480", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x001146BC File Offset: 0x001128BC
		public float? method_82()
		{
			float? result;
			try
			{
				if (this.method_125() < Contact_Base.IdentificationStatus.KnownClass)
				{
					result = null;
				}
				else if (Information.IsNothing(this.activeUnit_0))
				{
					result = null;
				}
				else
				{
					if (this.nullable_21 == null)
					{
						List<Weapon> list = new List<Weapon>();
						GlobalVariables.ActiveUnitType activeUnitType = this.activeUnit_0.vmethod_56();
						if (activeUnitType == GlobalVariables.ActiveUnitType.Aircraft)
						{
							try
							{
								int dbid = this.activeUnit_0.DBID;
								SQLiteConnection sqliteConnection = this.activeUnit_0.scenario_0.method_39();
								foreach (int int_ in DBFunctions.smethod_43(dbid, ref sqliteConnection))
								{
									Weapon weapon = this.activeUnit_0.scenario_0.method_87(int_);
									if (weapon.method_196())
									{
										list.Add(weapon);
									}
								}
								goto IL_114;
							}
							finally
							{
								List<int>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						list = Enumerable.ToList<Weapon>(Enumerable.Where<Weapon>(Enumerable.ToList<Weapon>(this.activeUnit_0.vmethod_89().method_2(false).Values), (Contact._Closure$__.$I102-0 == null) ? (Contact._Closure$__.$I102-0 = new Func<Weapon, bool>(Contact._Closure$__.$I.method_2)) : Contact._Closure$__.$I102-0));
						IL_114:
						if (list.Count == 0)
						{
							this.nullable_21 = new float?(0f);
						}
						else
						{
							this.nullable_21 = new float?(Enumerable.ElementAtOrDefault<Weapon>(Enumerable.OrderByDescending<Weapon, float>(list, (Contact._Closure$__.$I102-1 == null) ? (Contact._Closure$__.$I102-1 = new Func<Weapon, float>(Contact._Closure$__.$I.method_3)) : Contact._Closure$__.$I102-1), 0).float_31);
						}
					}
					result = this.nullable_21;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100481", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x001148B0 File Offset: 0x00112AB0
		public float? method_83()
		{
			float? result;
			try
			{
				if (this.method_125() < Contact_Base.IdentificationStatus.KnownClass)
				{
					result = null;
				}
				else if (Information.IsNothing(this.activeUnit_0))
				{
					result = null;
				}
				else
				{
					if (this.nullable_22 == null)
					{
						List<Weapon> list = new List<Weapon>();
						GlobalVariables.ActiveUnitType activeUnitType = this.activeUnit_0.vmethod_56();
						if (activeUnitType == GlobalVariables.ActiveUnitType.Aircraft)
						{
							try
							{
								int dbid = this.activeUnit_0.DBID;
								SQLiteConnection sqliteConnection = this.activeUnit_0.scenario_0.method_39();
								foreach (int int_ in DBFunctions.smethod_43(dbid, ref sqliteConnection))
								{
									Weapon weapon = this.activeUnit_0.scenario_0.method_87(int_);
									if (weapon.method_195())
									{
										list.Add(weapon);
									}
								}
								goto IL_114;
							}
							finally
							{
								List<int>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						list = Enumerable.ToList<Weapon>(Enumerable.Where<Weapon>(Enumerable.ToList<Weapon>(this.activeUnit_0.vmethod_89().method_2(false).Values), (Contact._Closure$__.$I105-0 == null) ? (Contact._Closure$__.$I105-0 = new Func<Weapon, bool>(Contact._Closure$__.$I.method_4)) : Contact._Closure$__.$I105-0));
						IL_114:
						if (list.Count == 0)
						{
							this.nullable_22 = new float?(0f);
						}
						else
						{
							this.nullable_22 = new float?(Enumerable.ElementAtOrDefault<Weapon>(Enumerable.OrderByDescending<Weapon, float>(list, (Contact._Closure$__.$I105-1 == null) ? (Contact._Closure$__.$I105-1 = new Func<Weapon, float>(Contact._Closure$__.$I.method_5)) : Contact._Closure$__.$I105-1), 0).float_33);
						}
					}
					result = this.nullable_22;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101215", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00114AA4 File Offset: 0x00112CA4
		public float? method_84()
		{
			float? result;
			try
			{
				if (this.method_125() < Contact_Base.IdentificationStatus.KnownClass)
				{
					result = null;
				}
				else if (Information.IsNothing(this.activeUnit_0))
				{
					result = null;
				}
				else
				{
					if (this.nullable_23 == null)
					{
						List<Weapon> list = new List<Weapon>();
						GlobalVariables.ActiveUnitType activeUnitType = this.activeUnit_0.vmethod_56();
						if (activeUnitType == GlobalVariables.ActiveUnitType.Aircraft)
						{
							try
							{
								int dbid = this.activeUnit_0.DBID;
								SQLiteConnection sqliteConnection = this.activeUnit_0.scenario_0.method_39();
								foreach (int int_ in DBFunctions.smethod_43(dbid, ref sqliteConnection))
								{
									Weapon weapon = this.activeUnit_0.scenario_0.method_87(int_);
									if (weapon.method_197())
									{
										list.Add(weapon);
									}
								}
								goto IL_114;
							}
							finally
							{
								List<int>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						list = Enumerable.ToList<Weapon>(Enumerable.Where<Weapon>(Enumerable.ToList<Weapon>(this.activeUnit_0.vmethod_89().method_2(false).Values), (Contact._Closure$__.$I108-0 == null) ? (Contact._Closure$__.$I108-0 = new Func<Weapon, bool>(Contact._Closure$__.$I.method_6)) : Contact._Closure$__.$I108-0));
						IL_114:
						if (list.Count == 0)
						{
							this.nullable_23 = new float?(0f);
						}
						else
						{
							this.nullable_23 = new float?(Enumerable.ElementAtOrDefault<Weapon>(Enumerable.OrderByDescending<Weapon, float>(list, (Contact._Closure$__.$I108-1 == null) ? (Contact._Closure$__.$I108-1 = new Func<Weapon, float>(Contact._Closure$__.$I.method_7)) : Contact._Closure$__.$I108-1), 0).float_35);
						}
					}
					result = this.nullable_23;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100482", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00114C98 File Offset: 0x00112E98
		public float? method_85()
		{
			float? result;
			if (Information.IsNothing(this.activeUnit_0))
			{
				result = null;
			}
			else
			{
				try
				{
					if (this.nullable_24 == null || this.identificationStatus_1 != this.method_125())
					{
						this.identificationStatus_1 = this.method_125();
						if (this.method_125() < Contact_Base.IdentificationStatus.KnownClass)
						{
							if (!this.method_67())
							{
								this.nullable_24 = new float?(0f);
							}
							else
							{
								IEnumerable<Sensor> enumerable = Enumerable.OrderByDescending<Sensor, float>(Enumerable.Where<Sensor>(Enumerable.Select<KeyValuePair<int, EmissionContainer>, Sensor>(Enumerable.Where<KeyValuePair<int, EmissionContainer>>(this.method_68(), (Contact._Closure$__.$I112-0 == null) ? (Contact._Closure$__.$I112-0 = new Func<KeyValuePair<int, EmissionContainer>, bool>(Contact._Closure$__.$I.method_8)) : Contact._Closure$__.$I112-0), new Func<KeyValuePair<int, EmissionContainer>, Sensor>(this.method_143)), (Contact._Closure$__.$I112-2 == null) ? (Contact._Closure$__.$I112-2 = new Func<Sensor, bool>(Contact._Closure$__.$I.method_9)) : Contact._Closure$__.$I112-2), (Contact._Closure$__.$I112-3 == null) ? (Contact._Closure$__.$I112-3 = new Func<Sensor, float>(Contact._Closure$__.$I.method_10)) : Contact._Closure$__.$I112-3);
								if (Enumerable.Count<Sensor>(enumerable) == 0)
								{
									this.nullable_24 = new float?(0f);
								}
								else
								{
									this.nullable_24 = new float?(Enumerable.ElementAtOrDefault<Sensor>(enumerable, 0).float_0);
								}
							}
						}
						else
						{
							ActiveUnit_Sensory activeUnit_Sensory = this.activeUnit_0.vmethod_88();
							bool bool_ = true;
							bool bool_2 = false;
							bool bool_3 = false;
							bool bool_4 = false;
							Sensor[] array = null;
							List<Sensor> list = activeUnit_Sensory.method_51(bool_, bool_2, bool_3, bool_4, ref array);
							if (list.Count == 0)
							{
								this.nullable_24 = new float?(0f);
							}
							else
							{
								this.nullable_24 = new float?(list[0].float_0);
							}
						}
					}
					result = this.nullable_24;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200547", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new float?(0f);
				}
			}
			return result;
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00114E90 File Offset: 0x00113090
		public float? method_86()
		{
			float? result;
			if (Information.IsNothing(this.activeUnit_0))
			{
				result = null;
			}
			else
			{
				try
				{
					if (this.nullable_25 == null || this.identificationStatus_2 != this.method_125())
					{
						this.identificationStatus_2 = this.method_125();
						if (this.method_125() < Contact_Base.IdentificationStatus.KnownClass)
						{
							if (!this.method_67())
							{
								this.nullable_25 = new float?(0f);
							}
							else
							{
								List<Sensor> list = Enumerable.ToList<Sensor>(Enumerable.OrderByDescending<Sensor, float>(Enumerable.Where<Sensor>(Enumerable.Select<KeyValuePair<int, EmissionContainer>, Sensor>(Enumerable.Where<KeyValuePair<int, EmissionContainer>>(this.method_68(), (Contact._Closure$__.$I116-0 == null) ? (Contact._Closure$__.$I116-0 = new Func<KeyValuePair<int, EmissionContainer>, bool>(Contact._Closure$__.$I.method_11)) : Contact._Closure$__.$I116-0), new Func<KeyValuePair<int, EmissionContainer>, Sensor>(this.method_144)), (Contact._Closure$__.$I116-2 == null) ? (Contact._Closure$__.$I116-2 = new Func<Sensor, bool>(Contact._Closure$__.$I.method_12)) : Contact._Closure$__.$I116-2), (Contact._Closure$__.$I116-3 == null) ? (Contact._Closure$__.$I116-3 = new Func<Sensor, float>(Contact._Closure$__.$I.method_13)) : Contact._Closure$__.$I116-3));
								if (list.Count == 0)
								{
									this.nullable_25 = new float?(0f);
								}
								else
								{
									this.nullable_25 = new float?(list[0].float_0);
								}
							}
						}
						else
						{
							ActiveUnit_Sensory activeUnit_Sensory = this.activeUnit_0.vmethod_88();
							bool bool_ = true;
							bool bool_2 = false;
							bool bool_3 = false;
							bool bool_4 = false;
							Sensor[] array = null;
							List<Sensor> list2 = activeUnit_Sensory.method_52(bool_, bool_2, bool_3, bool_4, ref array);
							if (list2.Count == 0)
							{
								this.nullable_25 = new float?(0f);
							}
							else
							{
								this.nullable_25 = new float?(list2[0].float_0);
							}
						}
					}
					result = this.nullable_25;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200548", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new float?(0f);
				}
			}
			return result;
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0011508C File Offset: 0x0011328C
		public float? method_87()
		{
			float? result;
			if (Information.IsNothing(this.activeUnit_0))
			{
				result = null;
			}
			else
			{
				try
				{
					if (this.nullable_26 == null || this.identificationStatus_3 != this.method_125())
					{
						this.identificationStatus_3 = this.method_125();
						if (this.method_125() < Contact_Base.IdentificationStatus.KnownClass)
						{
							if (!this.method_67())
							{
								this.nullable_26 = new float?(0f);
							}
							else
							{
								IEnumerable<Sensor> enumerable = Enumerable.OrderByDescending<Sensor, float>(Enumerable.Where<Sensor>(Enumerable.Select<KeyValuePair<int, EmissionContainer>, Sensor>(Enumerable.Where<KeyValuePair<int, EmissionContainer>>(this.method_68(), (Contact._Closure$__.$I120-0 == null) ? (Contact._Closure$__.$I120-0 = new Func<KeyValuePair<int, EmissionContainer>, bool>(Contact._Closure$__.$I.method_14)) : Contact._Closure$__.$I120-0), new Func<KeyValuePair<int, EmissionContainer>, Sensor>(this.method_145)), (Contact._Closure$__.$I120-2 == null) ? (Contact._Closure$__.$I120-2 = new Func<Sensor, bool>(Contact._Closure$__.$I.method_15)) : Contact._Closure$__.$I120-2), (Contact._Closure$__.$I120-3 == null) ? (Contact._Closure$__.$I120-3 = new Func<Sensor, float>(Contact._Closure$__.$I.method_16)) : Contact._Closure$__.$I120-3);
								if (Enumerable.Count<Sensor>(enumerable) == 0)
								{
									this.nullable_26 = new float?(0f);
								}
								else
								{
									this.nullable_26 = new float?(Enumerable.ElementAtOrDefault<Sensor>(enumerable, 0).float_0);
								}
							}
						}
						else
						{
							ActiveUnit_Sensory activeUnit_Sensory = this.activeUnit_0.vmethod_88();
							bool activeCapableSensorsOnly = true;
							bool emmittingSensorsOnly = false;
							bool onlyOperatingSensors = false;
							bool onlySensorsScanningThisPulse = false;
							Sensor[] array = null;
							List<Sensor> list = activeUnit_Sensory.method_55(activeCapableSensorsOnly, emmittingSensorsOnly, onlyOperatingSensors, onlySensorsScanningThisPulse, ref array, false);
							if (list.Count == 0)
							{
								this.nullable_26 = new float?(0f);
							}
							else
							{
								this.nullable_26 = new float?(list[0].float_0);
							}
						}
					}
					result = this.nullable_26;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100485", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
			return result;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00115278 File Offset: 0x00113478
		public string method_88()
		{
			string result;
			if (this.bool_18)
			{
				result = Conversions.ToString((int)Math.Round((double)this.vmethod_9())) + " deg";
			}
			else
			{
				result = "XXX";
			}
			return result;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x001152B4 File Offset: 0x001134B4
		public string method_89()
		{
			string result;
			if (this.bool_17)
			{
				result = Conversions.ToString((int)Math.Round((double)this.vmethod_40())) + " kts";
			}
			else
			{
				result = "XXX";
			}
			return result;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x001152F0 File Offset: 0x001134F0
		public string method_90(bool bool_24)
		{
			string result;
			if (this.bool_19)
			{
				if (bool_24)
				{
					if (this.vmethod_14(false) > 45720f)
					{
						result = string.Format("{0:0.0}", this.vmethod_14(false) / 1000f, 1) + " km";
					}
					else if (this.vmethod_14(false) > 3048f)
					{
						result = Conversions.ToString((int)Math.Round((double)(this.vmethod_14(false) * 3.28084f))) + " ft";
					}
					else if (this.method_103() && base.method_15())
					{
						result = Conversions.ToString((int)Math.Round((double)(this.vmethod_14(false) * 3.28084f))) + " ft (" + Conversions.ToString((int)Math.Round((double)(this.vmethod_13() * 3.28084f))) + " ft AGL)";
					}
					else
					{
						result = Conversions.ToString((int)Math.Round((double)(this.vmethod_14(false) * 3.28084f))) + " ft";
					}
				}
				else if (this.vmethod_14(false) > 45720f)
				{
					result = string.Format("{0:0.0}", this.vmethod_14(false) / 1000f, 1) + " km";
				}
				else if (this.vmethod_14(false) > 3048f)
				{
					result = Conversions.ToString((int)Math.Round((double)this.vmethod_14(false))) + " m";
				}
				else if (this.method_103() && base.method_15())
				{
					result = Conversions.ToString((int)Math.Round((double)this.vmethod_14(false))) + " m (" + Conversions.ToString((int)Math.Round((double)this.vmethod_13())) + " m AGL)";
				}
				else
				{
					result = Conversions.ToString((int)Math.Round((double)this.vmethod_14(false))) + " m";
				}
			}
			else
			{
				result = "XXX";
			}
			return result;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x001154E0 File Offset: 0x001136E0
		public bool method_91()
		{
			bool result;
			try
			{
				if (Information.IsNothing(this.activeUnit_0))
				{
					result = false;
				}
				else if (!this.activeUnit_0.bool_2)
				{
					result = false;
				}
				else if (!((Weapon)this.activeUnit_0).struct36_0.bool_46 && !((Weapon)this.activeUnit_0).struct36_0.bool_45 && !((Weapon)this.activeUnit_0).struct36_0.bool_44 && !this.activeUnit_0.vmethod_3())
				{
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100486", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x001155B8 File Offset: 0x001137B8
		public bool method_92(Strike strike_0)
		{
			return !Information.IsNothing(this.activeUnit_0) && strike_0.hashSet_0.Count != 0 && (strike_0.hashSet_0.Contains(this) || strike_0.hashSet_0.Contains(this.activeUnit_0));
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00115614 File Offset: 0x00113814
		public float method_93(double double_2, double double_3)
		{
			Contact.Class271 @class = new Contact.Class271();
			@class.double_0 = double_2;
			@class.double_1 = double_3;
			float result;
			try
			{
				Contact.Class270 class2 = new Contact.Class270();
				class2.class271_0 = @class;
				if (Information.IsNothing(this.method_112()))
				{
					result = 0f;
				}
				else if (this.method_112().Count == 0)
				{
					result = 0f;
				}
				else
				{
					class2.float_0 = Math2.smethod_17(class2.class271_0.double_0, class2.class271_0.double_1, this.vmethod_30(null), this.vmethod_28(null));
					IOrderedEnumerable<GeoPoint> orderedEnumerable = Enumerable.OrderBy<GeoPoint, float>(Enumerable.Select<GeoPoint, GeoPoint>(this.method_112(), (Contact._Closure$__.$I134-0 == null) ? (Contact._Closure$__.$I134-0 = new Func<GeoPoint, GeoPoint>(Contact._Closure$__.$I.method_17)) : Contact._Closure$__.$I134-0), new Func<GeoPoint, float>(class2.method_0));
					GeoPoint geoPoint = Enumerable.ElementAtOrDefault<GeoPoint>(orderedEnumerable, 0);
					GeoPoint geoPoint2 = Enumerable.ElementAtOrDefault<GeoPoint>(orderedEnumerable, Enumerable.Count<GeoPoint>(orderedEnumerable) - 1);
					float num = Class437.smethod_13(new Geopoint_Struct(class2.class271_0.double_1, class2.class271_0.double_0), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)), new Geopoint_Struct(geoPoint.imethod_0(), geoPoint.imethod_2()));
					float num2 = Class437.smethod_13(new Geopoint_Struct(class2.class271_0.double_1, class2.class271_0.double_0), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)), new Geopoint_Struct(geoPoint2.imethod_0(), geoPoint2.imethod_2()));
					result = num + num2;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100487", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = float.MaxValue;
			}
			return result;
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0011581C File Offset: 0x00113A1C
		public float method_94(Unit unit_0)
		{
			Contact.Class272 @class = new Contact.Class272();
			@class.unit_0 = unit_0;
			float result;
			try
			{
				if (Information.IsNothing(this.method_112()))
				{
					result = 0f;
				}
				else if (this.method_112().Count == 0)
				{
					result = 0f;
				}
				else
				{
					List<GeoPoint> list = Enumerable.ToList<GeoPoint>(Enumerable.OrderBy<GeoPoint, double>(this.method_112(), new Func<GeoPoint, double>(@class.method_0)));
					GeoPoint geoPoint = list[0];
					GeoPoint geoPoint2 = list[list.Count - 1];
					result = @class.unit_0.method_25(geoPoint2.imethod_2(), geoPoint2.imethod_0()) - @class.unit_0.method_25(geoPoint.imethod_2(), geoPoint.imethod_0());
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100488", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00115914 File Offset: 0x00113B14
		public override bool vmethod_45(List<GeoPoint> list_8, Scenario scenario_0, bool bool_24)
		{
			bool result;
			try
			{
				if (Information.IsNothing(this.method_112()))
				{
					result = base.vmethod_45(list_8, scenario_0, bool_24);
				}
				else
				{
					try
					{
						foreach (GeoPoint geoPoint in this.method_112())
						{
							if (!GeoPoint.smethod_3(geoPoint.imethod_2(), geoPoint.imethod_0(), Enumerable.ToList<GeoPoint>(list_8), bool_24))
							{
								return false;
							}
						}
					}
					finally
					{
						List<GeoPoint>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					result = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100489", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x001159E4 File Offset: 0x00113BE4
		public bool method_95(ActiveUnit activeUnit_1)
		{
			bool result;
			try
			{
				float num = activeUnit_1.method_37(this, 0f);
				List<Weapon> list = new List<Weapon>();
				try
				{
					foreach (Mount mount in activeUnit_1.vmethod_51())
					{
						try
						{
							foreach (WeaponRec weaponRec in mount.vmethod_10())
							{
								Weapon._WeaponType weaponType = weaponRec.method_12(activeUnit_1.scenario_0).method_167();
								if (weaponType - Weapon._WeaponType.Rocket <= 2)
								{
									list.Add(weaponRec.method_12(activeUnit_1.scenario_0));
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
				finally
				{
					List<Mount>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					List<Weapon>.Enumerator enumerator3 = list.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						if (enumerator3.Current.method_181(activeUnit_1, this, true, activeUnit_1.doctrine_0, false) > num)
						{
							return false;
						}
					}
				}
				finally
				{
					List<Weapon>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				result = true;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100490", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0000954F File Offset: 0x0000774F
		public float method_96()
		{
			return this.float_17;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00009557 File Offset: 0x00007757
		public void method_97(float float_19)
		{
			this.float_17 = Math.Max(0f, float_19);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0000956A File Offset: 0x0000776A
		public float method_98()
		{
			return this.float_18;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00009572 File Offset: 0x00007772
		public void method_99(float float_19)
		{
			this.float_18 = Math.Max(0f, float_19);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00115B4C File Offset: 0x00113D4C
		public Weapon[] method_100()
		{
			Weapon[] result;
			try
			{
				Weapon[] array = new Weapon[0];
				if (this.activeUnit_0 == null)
				{
					result = array;
				}
				else
				{
					if (this.weapon_0 == null)
					{
						this.weapon_0 = this.method_101();
					}
					result = this.weapon_0;
				}
			}
			catch (Exception ex)
			{
				result = new Weapon[0];
			}
			return result;
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00009585 File Offset: 0x00007785
		private Weapon[] method_101()
		{
			return Contact.smethod_2(this, this.activeUnit_0.scenario_0);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00115BB0 File Offset: 0x00113DB0
		public static Weapon[] smethod_2(Contact contact_0, Scenario scenario_0)
		{
			Weapon[] array = new Weapon[0];
			Side side_ = contact_0.side_1;
			Weapon[] result;
			try
			{
				if (scenario_0.method_17() == null)
				{
					result = array;
				}
				else if (scenario_0.method_17().Count == 0)
				{
					result = array;
				}
				else
				{
					List<Weapon> list = scenario_0.method_17();
					if (list == null)
					{
						result = array;
					}
					else if (contact_0.activeUnit_0 == null)
					{
						result = array;
					}
					else
					{
						if (list.Count > 0)
						{
							string string_ = contact_0.string_0;
							for (int i = list.Count - 1; i >= 0; i += -1)
							{
								Weapon weapon = list[i];
								if (weapon != null)
								{
									Weapon_AI weapon_AI = weapon.vmethod_142();
									if (side_.method_68(weapon.vmethod_7(false)) == Misc.PostureStance.Friendly && (weapon.method_177() == null || weapon.method_177().vmethod_90().vmethod_1()))
									{
										if (weapon_AI != null && weapon_AI.vmethod_3() != null)
										{
											if (weapon_AI.vmethod_3() == contact_0 || Operators.CompareString(weapon_AI.vmethod_3().string_0, string_, false) == 0)
											{
												Class429.smethod_40(ref array, weapon);
												goto IL_1A1;
											}
											if (weapon_AI.vmethod_3().activeUnit_0 != null && contact_0.activeUnit_0 != null && weapon_AI.vmethod_3().activeUnit_0 == contact_0.activeUnit_0)
											{
												Class429.smethod_40(ref array, weapon);
												goto IL_1A1;
											}
										}
										if (weapon.method_219() && weapon_AI.method_11(contact_0))
										{
											Class429.smethod_40(ref array, weapon);
										}
										else if (weapon.method_169() == Weapon.WeaponGuidanceType.Inertial && weapon.vmethod_142().vmethod_3() != null && weapon.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Aimpoint && weapon.vmethod_142().vmethod_3().method_36(contact_0) * 1852f < 20f)
										{
											Class429.smethod_40(ref array, weapon);
										}
									}
								}
								IL_1A1:;
							}
						}
						for (int j = scenario_0.method_45().Count - 1; j >= 0; j += -1)
						{
							ActiveUnit activeUnit = scenario_0.method_45()[j];
							if (!Information.IsNothing(activeUnit) && activeUnit.bool_2 && side_.method_68(activeUnit.vmethod_7(false)) == Misc.PostureStance.Friendly && activeUnit.vmethod_86().vmethod_3() != null)
							{
								if (activeUnit.vmethod_86().vmethod_3() == contact_0)
								{
									Class429.smethod_40(ref array, (Weapon)activeUnit);
								}
								else if (activeUnit.vmethod_86().vmethod_3().activeUnit_0 != null && contact_0.activeUnit_0 != null && activeUnit.vmethod_86().vmethod_3().activeUnit_0 == contact_0.activeUnit_0)
								{
									Class429.smethod_40(ref array, (Weapon)activeUnit);
								}
							}
						}
						result = array;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200024", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00009598 File Offset: 0x00007798
		public override Side vmethod_7(bool SetSideOnly = false)
		{
			if (this.bool_12 && !Information.IsNothing(this.activeUnit_0))
			{
				this.side_0 = this.activeUnit_0.vmethod_7(false);
			}
			return this.side_0;
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x000095C7 File Offset: 0x000077C7
		public override void vmethod_8(bool SetSideOnly = false, Side value)
		{
			this.side_0 = value;
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00115E94 File Offset: 0x00114094
		public GlobalVariables.TargetVisualSizeClass method_102(Scenario scenario_0)
		{
			ActiveUnit activeUnit = this.activeUnit_0;
			Contact_Base.IdentificationStatus identificationStatus = this.method_125();
			GlobalVariables.TargetVisualSizeClass result;
			if (identificationStatus > Contact_Base.IdentificationStatus.KnownType)
			{
				if (identificationStatus - Contact_Base.IdentificationStatus.KnownClass <= 1)
				{
					result = activeUnit.vmethod_121();
				}
			}
			else
			{
				result = activeUnit.vmethod_121();
			}
			return result;
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x000095D0 File Offset: 0x000077D0
		public bool method_103()
		{
			return this.contactType_0 == Contact_Base.ContactType.Air || this.contactType_0 == Contact_Base.ContactType.Missile || this.contactType_0 == Contact_Base.ContactType.Orbital;
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x000095EE File Offset: 0x000077EE
		public bool method_104()
		{
			return this.contactType_0 == Contact_Base.ContactType.Air;
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00115ECC File Offset: 0x001140CC
		public bool method_105()
		{
			return this.contactType_0 == Contact_Base.ContactType.Air || (this.contactType_0 == Contact_Base.ContactType.Missile && !this.method_91());
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x000095F9 File Offset: 0x000077F9
		public bool method_106()
		{
			return this.contactType_0 == Contact_Base.ContactType.Air || this.contactType_0 == Contact_Base.ContactType.Missile || this.contactType_0 == Contact_Base.ContactType.Submarine;
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00009617 File Offset: 0x00007817
		public bool method_107()
		{
			return this.contactType_0 == Contact_Base.ContactType.Facility_Fixed || this.contactType_0 == Contact_Base.ContactType.Facility_Mobile;
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0000962D File Offset: 0x0000782D
		public bool method_108()
		{
			return this.contactType_0 == Contact_Base.ContactType.Surface;
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00009638 File Offset: 0x00007838
		public bool method_109()
		{
			return this.contactType_0 == Contact_Base.ContactType.Orbital;
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00115F00 File Offset: 0x00114100
		public bool method_110()
		{
			Contact_Base.ContactType contactType_ = this.contactType_0;
			return contactType_ == Contact_Base.ContactType.Missile || contactType_ - Contact_Base.ContactType.Torpedo <= 1;
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00115F28 File Offset: 0x00114128
		public bool method_111()
		{
			Contact_Base.ContactType contactType_ = this.contactType_0;
			return contactType_ == Contact_Base.ContactType.Missile;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00009643 File Offset: 0x00007843
		public List<GeoPoint> method_112()
		{
			return this.list_3;
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0000964B File Offset: 0x0000784B
		public void method_113(List<GeoPoint> list_8)
		{
			this.list_3 = list_8;
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00009654 File Offset: 0x00007854
		public List<GeoPoint> method_114()
		{
			return this.list_5;
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0000965C File Offset: 0x0000785C
		public void method_115(List<GeoPoint> list_8)
		{
			this.list_5 = list_8;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00009665 File Offset: 0x00007865
		public List<GeoPoint> method_116()
		{
			return this.list_6;
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0000966D File Offset: 0x0000786D
		public void method_117(List<GeoPoint> list_8)
		{
			this.list_6 = list_8;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00009676 File Offset: 0x00007876
		public List<GeoPoint> method_118()
		{
			return this.list_4;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0000967E File Offset: 0x0000787E
		public void method_119(List<GeoPoint> list_8)
		{
			this.list_4 = list_8;
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00115F48 File Offset: 0x00114148
		public ConcurrentDictionary<string, ActiveUnit> method_120(Scenario theScen, Side theSide, bool GroupsOnly, ActiveUnit ExcludeThisUnit = null)
		{
			ConcurrentDictionary<string, ActiveUnit> result;
			try
			{
				if (this.concurrentDictionary_0 == null)
				{
					ConcurrentDictionary<string, ActiveUnit> concurrentDictionary = new ConcurrentDictionary<string, ActiveUnit>();
					if (theSide == null)
					{
						return concurrentDictionary;
					}
					if (theSide.activeUnit_0.Length == 0)
					{
						return concurrentDictionary;
					}
					List<ActiveUnit> list = new List<ActiveUnit>();
					list.AddRange(theSide.activeUnit_0);
					int num = list.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						ActiveUnit activeUnit = list[i];
						if (activeUnit.vmethod_43() && activeUnit.vmethod_127() && activeUnit.vmethod_86().vmethod_3() != null && activeUnit.vmethod_86().vmethod_3() == this)
						{
							concurrentDictionary.TryAdd(activeUnit.string_0, activeUnit);
						}
					}
					this.concurrentDictionary_0 = concurrentDictionary;
				}
				if (Information.IsNothing(ExcludeThisUnit))
				{
					if (GroupsOnly)
					{
						ConcurrentDictionary<string, ActiveUnit> concurrentDictionary = new ConcurrentDictionary<string, ActiveUnit>(this.concurrentDictionary_0);
						for (int j = concurrentDictionary.Count - 1; j >= 0; j += -1)
						{
							ActiveUnit activeUnit2 = Enumerable.ElementAtOrDefault<ActiveUnit>(concurrentDictionary.Values, j);
							if (activeUnit2.method_121())
							{
								concurrentDictionary.TryRemove(activeUnit2.string_0, ref activeUnit2);
							}
						}
						result = concurrentDictionary;
					}
					else
					{
						result = this.concurrentDictionary_0;
					}
				}
				else
				{
					ConcurrentDictionary<string, ActiveUnit> concurrentDictionary = new ConcurrentDictionary<string, ActiveUnit>(this.concurrentDictionary_0);
					concurrentDictionary.TryRemove(ExcludeThisUnit.string_0, ref ExcludeThisUnit);
					if (GroupsOnly)
					{
						for (int k = concurrentDictionary.Count - 1; k >= 0; k += -1)
						{
							ActiveUnit activeUnit2 = Enumerable.ElementAtOrDefault<ActiveUnit>(concurrentDictionary.Values, k);
							if (activeUnit2.method_121())
							{
								concurrentDictionary.TryRemove(activeUnit2.string_0, ref activeUnit2);
							}
						}
						result = concurrentDictionary;
					}
					else
					{
						result = concurrentDictionary;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100491", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00009687 File Offset: 0x00007887
		public bool method_121()
		{
			return this.bool_13;
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0000968F File Offset: 0x0000788F
		public void method_122(bool bool_24)
		{
			if (bool_24)
			{
				this.method_113(null);
			}
			this.bool_13 = bool_24;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x000096A2 File Offset: 0x000078A2
		public void method_123(bool bool_24)
		{
			this.bool_14 = bool_24;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0011611C File Offset: 0x0011431C
		public bool method_124(Scenario scenario_0)
		{
			bool result;
			if (this.bool_22)
			{
				if (!this.bool_23 && this.activeUnit_0 != null && this.activeUnit_0.method_82())
				{
					this.bool_23 = true;
					result = this.bool_23;
				}
				else
				{
					result = this.bool_23;
				}
			}
			else
			{
				if (this.contactType_0 != Contact_Base.ContactType.Aimpoint)
				{
					if (this.contactType_0 != Contact_Base.ContactType.ActivationPoint)
					{
						if (this.activeUnit_0 == null)
						{
							this.bool_23 = true;
							this.bool_22 = true;
							return this.bool_23;
						}
						if (this.activeUnit_0.bool_24)
						{
							this.bool_23 = true;
							this.bool_22 = true;
							return this.bool_23;
						}
						try
						{
							if (!scenario_0.vmethod_0().ContainsKey(this.activeUnit_0.string_0) && !scenario_0.method_45().Contains(this.activeUnit_0))
							{
								this.bool_23 = true;
							}
							else
							{
								this.bool_23 = false;
							}
							this.bool_22 = true;
							return this.bool_23;
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 200025", ex.Message);
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							return true;
						}
					}
				}
				this.bool_23 = false;
				this.bool_22 = true;
				result = this.bool_23;
			}
			return result;
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0011627C File Offset: 0x0011447C
		private static string smethod_3(Contact contact_0)
		{
			string result;
			try
			{
				if (contact_0.activeUnit_0 == null)
				{
					result = "";
				}
				else
				{
					switch (contact_0.contactType_0)
					{
					case Contact_Base.ContactType.Air:
						if (contact_0.activeUnit_0.bool_3)
						{
							return ((Aircraft)contact_0.activeUnit_0)._AircraftType_0.ToString();
						}
						if (!contact_0.activeUnit_0.bool_2)
						{
							return "Unknown";
						}
						if (((Weapon)contact_0.activeUnit_0).method_208())
						{
							return "Decoy";
						}
						return "Unknown";
					case Contact_Base.ContactType.Missile:
					case Contact_Base.ContactType.Torpedo:
						return ((Weapon)contact_0.activeUnit_0).method_167().ToString();
					case Contact_Base.ContactType.Surface:
						return ((Ship)contact_0.activeUnit_0)._ShipType_0.ToString();
					case Contact_Base.ContactType.Submarine:
						return ((Submarine)contact_0.activeUnit_0)._SubmarineType_0.ToString();
					case Contact_Base.ContactType.Facility_Fixed:
						return ((Facility)contact_0.activeUnit_0)._FacilityCategory_0.ToString();
					case Contact_Base.ContactType.Facility_Mobile:
						return ((Facility)contact_0.activeUnit_0).method_144();
					case Contact_Base.ContactType.Decoy_Air:
					case Contact_Base.ContactType.Decoy_Surface:
					case Contact_Base.ContactType.Decoy_Land:
					case Contact_Base.ContactType.Decoy_Sub:
						return "Decoy";
					}
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = contact_0.activeUnit_0.string_2;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100492", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0011646C File Offset: 0x0011466C
		public static string smethod_4(Contact contact_0)
		{
			string result;
			switch (contact_0.method_125())
			{
			case Contact_Base.IdentificationStatus.Unknown:
				result = "Unknown";
				break;
			case Contact_Base.IdentificationStatus.KnownDomain:
				result = contact_0.method_56();
				break;
			case Contact_Base.IdentificationStatus.KnownType:
				result = Contact.smethod_3(contact_0);
				break;
			case Contact_Base.IdentificationStatus.KnownClass:
			case Contact_Base.IdentificationStatus.PreciseID:
				result = contact_0.activeUnit_0.string_2;
				break;
			}
			return result;
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x000096AB File Offset: 0x000078AB
		public Contact_Base.IdentificationStatus method_125()
		{
			return this.identificationStatus_0;
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x001164C4 File Offset: 0x001146C4
		public void method_126(Scenario scenario_0, Side side_2, Sensor sensor_0, float? nullable_28, bool bool_24, bool bool_25, bool bool_26, bool bool_27, Contact_Base.IdentificationStatus identificationStatus_4)
		{
			try
			{
				if (identificationStatus_4 > this.identificationStatus_0)
				{
					this.identificationStatus_0 = identificationStatus_4;
					this.nullable_20 = null;
					this.nullable_21 = null;
					this.nullable_23 = null;
					string str = "";
					if (nullable_28 != null)
					{
						if (this.method_112() == null)
						{
							str = Math.Round((double)nullable_28.Value, 1).ToString();
						}
						else
						{
							str = "Estimated " + Math.Round((double)nullable_28.Value, 0).ToString();
						}
					}
					LoggedMessage.MessageType messageType;
					if (bool_25)
					{
						messageType = LoggedMessage.MessageType.ContactChange;
					}
					else
					{
						messageType = LoggedMessage.MessageType.CommsIsolatedMessage;
					}
					switch (this.identificationStatus_0)
					{
					case Contact_Base.IdentificationStatus.KnownDomain:
					{
						Contact_Base.ContactType contactType_ = this.contactType_0;
						switch (contactType_)
						{
						case Contact_Base.ContactType.Air:
							this.Name = "BOGEY #" + Conversions.ToString(this.int_0);
							goto IL_C7F;
						case Contact_Base.ContactType.Missile:
						{
							if (this.activeUnit_0 == null)
							{
								this.Name = "MISSILE #" + Conversions.ToString(this.int_0);
								goto IL_C7F;
							}
							if (this.activeUnit_0.vmethod_86().vmethod_3() == null)
							{
								this.Name = "MISSILE #" + Conversions.ToString(this.int_0);
								goto IL_C7F;
							}
							Contact contact = this.activeUnit_0.vmethod_86().vmethod_3();
							if (contact.method_103())
							{
								Weapon weapon = (Weapon)this.activeUnit_0;
								if (weapon.method_177() == null)
								{
									this.Name = "MISSILE #" + Conversions.ToString(this.int_0);
									goto IL_C7F;
								}
								if (weapon.method_177().bool_3)
								{
									this.Name = "MISSILE #" + Conversions.ToString(this.int_0);
									goto IL_C7F;
								}
								this.Name = "SAM #" + Conversions.ToString(this.int_0);
								goto IL_C7F;
							}
							else
							{
								if ((contact.method_134() || contact.method_136()) && !this.activeUnit_0.method_88())
								{
									this.Name = "VAMPIRE #" + Conversions.ToString(this.int_0);
									goto IL_C7F;
								}
								this.Name = "MISSILE #" + Conversions.ToString(this.int_0);
								goto IL_C7F;
							}
							break;
						}
						case Contact_Base.ContactType.Surface:
							this.Name = "SKUNK #" + Conversions.ToString(this.int_0);
							goto IL_C7F;
						case Contact_Base.ContactType.Submarine:
							this.Name = "GOBLIN #" + Conversions.ToString(this.int_0);
							goto IL_C7F;
						case Contact_Base.ContactType.UndeterminedNaval:
						case Contact_Base.ContactType.Aimpoint:
						case Contact_Base.ContactType.Orbital:
							break;
						case Contact_Base.ContactType.Facility_Fixed:
							if (this.activeUnit_0.method_92(null))
							{
								this.Name = this.activeUnit_0.Name;
								this.bool_12 = true;
								goto IL_C7F;
							}
							this.Name = "FIXED #" + Conversions.ToString(this.int_0);
							goto IL_C7F;
						case Contact_Base.ContactType.Facility_Mobile:
							this.Name = "MOBILE #" + Conversions.ToString(this.int_0);
							goto IL_C7F;
						case Contact_Base.ContactType.Torpedo:
							this.Name = "TORPEDO #" + Conversions.ToString(this.int_0);
							goto IL_C7F;
						case Contact_Base.ContactType.Mine:
							this.Name = "MINE #" + Conversions.ToString(this.int_0);
							goto IL_C7F;
						default:
							if (contactType_ == Contact_Base.ContactType.Sonobuoy)
							{
								this.Name = "SONOBUOY #" + Conversions.ToString(this.int_0);
								goto IL_C7F;
							}
							break;
						}
						this.Name = "CONTACT #" + Conversions.ToString(this.int_0);
						break;
					}
					case Contact_Base.IdentificationStatus.KnownType:
						if (sensor_0 != null && (sensor_0.sensor_Type_0 == Sensor.Sensor_Type.Visual || sensor_0.sensor_Type_0 == Sensor.Sensor_Type.Infrared) && this.contactType_0 == Contact_Base.ContactType.Air && this.activeUnit_0 != null && this.activeUnit_0.method_88())
						{
							this.contactType_0 = Contact_Base.ContactType.Decoy_Air;
							if (bool_27)
							{
								string text = "Contact: " + this.Name + " has been type-classified as DECOY!";
								string text2 = "";
								if (sensor_0 != null)
								{
									if (sensor_0.method_18() != null)
									{
										ActiveUnit activeUnit = sensor_0.method_18();
										string text3 = "";
										if (activeUnit.bool_3 && Operators.CompareString(activeUnit.Name, activeUnit.string_2, false) != 0)
										{
											text3 = " (" + activeUnit.string_2 + ")";
										}
										text2 = string.Concat(new string[]
										{
											" (Classification by: ",
											sensor_0.method_18().Name,
											text3,
											" [Sensor: ",
											Misc.smethod_9(sensor_0.Name),
											"]"
										});
									}
									else
									{
										text2 = " (Classification by Sensor: " + Misc.smethod_9(sensor_0.Name);
									}
									text2 += ")";
								}
								text += text2;
								scenario_0.method_59(text, this.Name + " is a DECOY", LoggedMessage.MessageType.ContactChange, 1, null, side_2, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							}
						}
						else
						{
							string name = this.Name;
							string text4 = "Contact: " + this.Name;
							this.Name = Contact.smethod_3(this) + " #" + Conversions.ToString(this.int_0);
							if (bool_27)
							{
								text4 = text4 + " has been type-classified as: " + Contact.smethod_3(this);
								string text5 = "";
								if (sensor_0 != null)
								{
									if (sensor_0.method_18() != null)
									{
										ActiveUnit activeUnit2 = sensor_0.method_18();
										string text6 = "";
										if (activeUnit2.bool_3 && Operators.CompareString(activeUnit2.Name, activeUnit2.string_2, false) == 0)
										{
											text6 = " (" + activeUnit2.string_2 + ")";
										}
										text5 = string.Concat(new string[]
										{
											" (Classification by: ",
											sensor_0.method_18().Name,
											text6,
											" [Sensor: ",
											Misc.smethod_9(sensor_0.Name),
											"]"
										});
									}
									else
									{
										text5 = " (Classification by Sensor: " + Misc.smethod_9(sensor_0.Name);
									}
									if (bool_24)
									{
										text5 += " [NCTR mode]";
									}
									if (nullable_28 != null)
									{
										text5 = text5 + " at " + str + " nm)";
									}
									else
									{
										text5 += ")";
									}
								}
								text4 += text5;
								scenario_0.method_59(text4, name + " now type-classified: " + Contact.smethod_3(this), messageType, 1, null, side_2, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							}
							Contact_Base.ContactType contactType_2 = this.contactType_0;
							if (contactType_2 == Contact_Base.ContactType.Submarine)
							{
								Submarine._SubmarineType submarineType_ = ((Submarine)this.activeUnit_0)._SubmarineType_0;
								if (submarineType_ - Submarine._SubmarineType.Biologics <= 1)
								{
									this.bool_12 = true;
									if (this.activeUnit_0 != null && this.activeUnit_0.vmethod_7(false) != null)
									{
										this.method_131(side_2, false, side_2.method_68(this.activeUnit_0.vmethod_7(false)));
										Contact contact2 = this;
										this.method_127(ref scenario_0, ref side_2, ref contact2);
										this.bool_15 = false;
									}
								}
							}
						}
						break;
					case Contact_Base.IdentificationStatus.KnownClass:
					{
						this.bool_12 = true;
						if (!Information.IsNothing(this.activeUnit_0) && !Information.IsNothing(this.activeUnit_0.vmethod_7(false)))
						{
							this.method_131(side_2, false, side_2.method_68(this.activeUnit_0.vmethod_7(false)));
						}
						string name2 = this.Name;
						string text7 = "Contact: " + name2;
						this.Name = Misc.smethod_9(this.activeUnit_0.string_2) + " #" + Conversions.ToString(this.int_0);
						if (bool_27)
						{
							text7 = text7 + " has been classified as: " + Misc.smethod_9(this.activeUnit_0.string_2);
							text7 = text7 + " - Determined as: " + this.method_130(side_2).ToString();
							string text8 = "";
							if (!Information.IsNothing(sensor_0))
							{
								if (!Information.IsNothing(sensor_0.method_18()))
								{
									ActiveUnit activeUnit3 = sensor_0.method_18();
									string text9 = "";
									if (activeUnit3.bool_3 && Operators.CompareString(activeUnit3.Name, activeUnit3.string_2, false) != 0)
									{
										text9 = " (" + activeUnit3.string_2 + ")";
									}
									text8 = string.Concat(new string[]
									{
										" (Classification by: ",
										sensor_0.method_18().Name,
										text9,
										" [Sensor: ",
										Misc.smethod_9(sensor_0.Name),
										"]"
									});
								}
								else
								{
									text8 = " (Classification by Sensor: " + Misc.smethod_9(sensor_0.Name);
								}
								if (bool_24)
								{
									text8 += " [NCTR mode]";
								}
								if (!Information.IsNothing(nullable_28))
								{
									text8 = text8 + " at " + str + " nm)";
								}
								else
								{
									text8 += ")";
								}
							}
							text7 += text8;
							scenario_0.method_59(text7, name2 + " now platform-classified: " + Misc.smethod_9(this.activeUnit_0.string_2), messageType, 1, null, side_2, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
						}
						if (Information.IsNothing(sensor_0) || sensor_0.sensor_Type_0 != Sensor.Sensor_Type.Visual || sensor_0.sensor_Type_0 != Sensor.Sensor_Type.Infrared)
						{
							if (this.activeUnit_0.method_88())
							{
								this.contactType_0 = Contact_Base.ContactType.Air;
							}
							else if (this.activeUnit_0.method_89())
							{
								this.contactType_0 = Contact_Base.ContactType.Surface;
							}
							else if (this.activeUnit_0.method_90())
							{
								this.contactType_0 = Contact_Base.ContactType.Submarine;
							}
						}
						Contact contact2 = this;
						this.method_127(ref scenario_0, ref side_2, ref contact2);
						this.bool_15 = false;
						break;
					}
					case Contact_Base.IdentificationStatus.PreciseID:
						this.bool_12 = true;
						if (!Information.IsNothing(this.activeUnit_0) && !Information.IsNothing(this.activeUnit_0.vmethod_7(false)))
						{
							this.method_131(side_2, false, side_2.method_68(this.activeUnit_0.vmethod_7(false)));
						}
						if (string.IsNullOrEmpty(this.Name))
						{
							this.Name = this.activeUnit_0.Name;
						}
						if (!this.activeUnit_0.method_67(side_2))
						{
							string name3 = this.Name;
							string text10 = "Contact: " + this.Name;
							this.Name = this.activeUnit_0.Name;
							if (bool_27)
							{
								text10 = text10 + " has been positively identified as: " + Misc.smethod_9(this.Name);
								text10 = text10 + " - Determined as: " + this.method_130(side_2).ToString();
								string text11 = "";
								if (!Information.IsNothing(sensor_0))
								{
									if (!Information.IsNothing(sensor_0.method_18()))
									{
										ActiveUnit activeUnit4 = sensor_0.method_18();
										string text12 = "";
										if (activeUnit4.bool_3 && Operators.CompareString(activeUnit4.Name, activeUnit4.string_2, false) != 0)
										{
											text12 = " (" + activeUnit4.string_2 + ")";
										}
										text11 = string.Concat(new string[]
										{
											" (ID by: ",
											sensor_0.method_18().Name,
											text12,
											" [Sensor: ",
											Misc.smethod_9(sensor_0.Name),
											"]"
										});
									}
									else
									{
										text11 = " (ID by Sensor: " + Misc.smethod_9(sensor_0.Name);
									}
									if (!Information.IsNothing(nullable_28))
									{
										text11 = text11 + " at " + str + " nm)";
									}
									else
									{
										text11 += ")";
									}
								}
								text10 += text11;
								if (this.contactType_0 != Contact_Base.ContactType.Facility_Fixed && this.contactType_0 != Contact_Base.ContactType.Installation && this.contactType_0 != Contact_Base.ContactType.AirBase && this.contactType_0 != Contact_Base.ContactType.NavalBase && this.contactType_0 != Contact_Base.ContactType.MobileGroup)
								{
									scenario_0.method_59(text10, name3 + " now positive ID: " + Misc.smethod_9(this.Name), messageType, 1, null, side_2, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
								}
							}
							Contact contact2 = this;
							this.method_127(ref scenario_0, ref side_2, ref contact2);
							this.bool_15 = false;
						}
						break;
					}
					IL_C7F:;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100493", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x001171A8 File Offset: 0x001153A8
		private void method_127(ref Scenario scenario_0, ref Side side_2, ref Contact contact_0)
		{
			HashSet<string> hashSet = GameGeneral.dictionary_0[side_2.string_0];
			foreach (Side side in scenario_0.method_44())
			{
				if (side != side_2 && hashSet.Contains(side.string_0) && !Information.IsNothing(contact_0.activeUnit_0))
				{
					Contact contact_ = null;
					if (side.method_11().TryGetValue(contact_0.activeUnit_0.string_0, ref contact_))
					{
						Contact.smethod_5(contact_0, contact_);
					}
				}
			}
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0011722C File Offset: 0x0011542C
		public static void smethod_5(Contact contact_0, Contact contact_1)
		{
			if (Operators.CompareString(contact_1.string_0, contact_0.string_0, false) != 0 && contact_0.method_125() > contact_1.method_125())
			{
				contact_1.identificationStatus_0 = contact_0.identificationStatus_0;
				contact_1.Name = contact_0.Name;
				contact_1.bool_15 = false;
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x000096B3 File Offset: 0x000078B3
		public bool method_128(Side side_2)
		{
			if (this.nullable_27 == null)
			{
				this.nullable_27 = new bool?(!side_2.method_11().ContainsKey(this.activeUnit_0.string_0));
			}
			return this.nullable_27.Value;
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x000096F1 File Offset: 0x000078F1
		public void method_129(Side side_2, bool bool_24)
		{
			this.nullable_27 = new bool?(bool_24);
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0011727C File Offset: 0x0011547C
		public Misc.PostureStance method_130(Side side_2)
		{
			Misc.PostureStance result;
			try
			{
				if (Information.IsNothing(this.activeUnit_0))
				{
					result = Misc.PostureStance.Unknown;
				}
				else
				{
					if (!this.method_128(side_2) && !this.bool_15)
					{
						object obj = this.object_1;
						ObjectFlowControl.CheckForSyncLockOnValueType(obj);
						lock (obj)
						{
							if (!this.bool_15)
							{
								if (Information.IsNothing(this.activeUnit_0) || this.activeUnit_0.method_82())
								{
									return Misc.PostureStance.Unknown;
								}
								Information.IsNothing(side_2);
								Information.IsNothing(this.activeUnit_0.vmethod_7(false));
								if (!(this.contactType_0 == Contact_Base.ContactType.Missile | this.contactType_0 == Contact_Base.ContactType.Torpedo))
								{
									if (this.bool_12 && this.bool_20)
									{
										Dictionary<Side, Misc.PostureStance> dictionary = new Dictionary<Side, Misc.PostureStance>(this.activeUnit_0.scenario_0.method_44().Length);
										foreach (Side side in this.activeUnit_0.scenario_0.method_44())
										{
											if (!Information.IsNothing(side))
											{
												Contact_Base.ContactType contactType_ = this.contactType_0;
												if (contactType_ - Contact_Base.ContactType.Installation <= 3)
												{
													if (!Information.IsNothing(this.activeUnit_0) && (side.method_12().ContainsKey(this.activeUnit_0.string_0) || this.activeUnit_0.method_67(side)))
													{
														dictionary.Add(side, side.method_68(this.activeUnit_0.vmethod_7(false)));
													}
												}
												else if (!Information.IsNothing(this.activeUnit_0) && (side.method_11().ContainsKey(this.activeUnit_0.string_0) || this.activeUnit_0.method_67(side)))
												{
													dictionary.Add(side, side.method_68(this.activeUnit_0.vmethod_7(false)));
												}
											}
										}
										this.dictionary_0 = dictionary;
									}
								}
								else
								{
									Dictionary<Side, Misc.PostureStance> dictionary2 = new Dictionary<Side, Misc.PostureStance>(this.activeUnit_0.scenario_0.method_44().Length);
									foreach (Side side2 in this.activeUnit_0.scenario_0.method_44())
									{
										if (!Information.IsNothing(side2) && !Information.IsNothing(this.activeUnit_0) && side2.method_11().ContainsKey(this.activeUnit_0.string_0))
										{
											Misc.PostureStance postureStance = side2.method_68(this.activeUnit_0.vmethod_7(false));
											if (postureStance == Misc.PostureStance.Friendly)
											{
												dictionary2.Add(side2, postureStance);
											}
											else
											{
												dictionary2.Add(side2, Misc.PostureStance.Hostile);
											}
										}
									}
									this.dictionary_0 = dictionary2;
								}
								this.bool_15 = true;
							}
						}
					}
					Misc.PostureStance postureStance2;
					if (this.dictionary_0.TryGetValue(side_2, out postureStance2))
					{
						result = postureStance2;
					}
					else
					{
						result = Misc.PostureStance.Unknown;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200572", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Misc.PostureStance.Unknown;
			}
			return result;
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x001175A8 File Offset: 0x001157A8
		public void method_131(Side side_2, bool bool_24, Misc.PostureStance postureStance_0)
		{
			try
			{
				if (!this.bool_12 || !side_2.method_67(this.activeUnit_0.vmethod_7(false)))
				{
					if (bool_24)
					{
						this.bool_20 = false;
					}
					else
					{
						this.bool_20 = true;
					}
					Misc.PostureStance postureStance;
					if (!this.dictionary_0.TryGetValue(side_2, out postureStance))
					{
						this.dictionary_0.Add(side_2, postureStance);
					}
					bool? flag = new bool?(postureStance != postureStance_0);
					if (this.dictionary_0.ContainsKey(side_2))
					{
						this.dictionary_0[side_2] = postureStance_0;
					}
					if (flag.GetValueOrDefault())
					{
						if (side_2.dictionary_4.ContainsKey(this.string_0))
						{
							side_2.dictionary_4[this.string_0] = postureStance_0;
						}
						else
						{
							object obj = this.object_0;
							ObjectFlowControl.CheckForSyncLockOnValueType(obj);
							lock (obj)
							{
								side_2.dictionary_4.Add(this.string_0, postureStance_0);
							}
						}
						if (this.bool_12 && this.vmethod_7(false).bool_13 && (postureStance_0 == Misc.PostureStance.Unfriendly || postureStance_0 == Misc.PostureStance.Hostile) && !Information.IsNothing(this.activeUnit_0))
						{
							side_2.method_69(this.activeUnit_0.vmethod_7(false), postureStance_0);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100494", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00117744 File Offset: 0x00115944
		public bool method_132()
		{
			switch (this.contactType_0)
			{
			case Contact_Base.ContactType.Air:
			case Contact_Base.ContactType.Missile:
			case Contact_Base.ContactType.Orbital:
				return this.method_57() > 300f;
			case Contact_Base.ContactType.Surface:
			case Contact_Base.ContactType.Facility_Mobile:
				return this.method_57() > 7200f;
			case Contact_Base.ContactType.Submarine:
				return this.method_57() > 21600f;
			case Contact_Base.ContactType.Torpedo:
				return this.method_57() > 600f;
			}
			return false;
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x001177CC File Offset: 0x001159CC
		public bool method_133()
		{
			return Information.IsNothing(this.method_112()) && this.method_57() <= 1f;
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00117800 File Offset: 0x00115A00
		public bool method_134()
		{
			Contact_Base.ContactType contactType_ = this.contactType_0;
			if (contactType_ != Contact_Base.ContactType.Surface && contactType_ - Contact_Base.ContactType.Facility_Fixed > 1)
			{
				if (contactType_ != Contact_Base.ContactType.ActivationPoint)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0011782C File Offset: 0x00115A2C
		public bool method_135()
		{
			Contact_Base.ContactType contactType_ = this.contactType_0;
			return contactType_ == Contact_Base.ContactType.Aimpoint || contactType_ - Contact_Base.ContactType.Facility_Fixed <= 1;
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00117854 File Offset: 0x00115A54
		public bool method_136()
		{
			Contact_Base.ContactType contactType_ = this.contactType_0;
			return contactType_ == Contact_Base.ContactType.Submarine || contactType_ - Contact_Base.ContactType.Torpedo <= 1;
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0011787C File Offset: 0x00115A7C
		public void method_137(ActiveUnit activeUnit_1)
		{
			if (this.method_112() != null && this.method_112().Count != 0)
			{
				List<GeoPoint> list = new List<GeoPoint>();
				try
				{
					foreach (GeoPoint geoPoint in this.method_112())
					{
						if (double.IsNaN(geoPoint.imethod_0()) || double.IsNaN(geoPoint.imethod_2()))
						{
							list.Add(geoPoint);
						}
					}
				}
				finally
				{
					List<GeoPoint>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (GeoPoint item in list)
					{
						this.method_112().Remove(item);
					}
				}
				finally
				{
					List<GeoPoint>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				Geopoint_Struct geopoint_Struct = Misc.smethod_46(this.method_112());
				this.vmethod_29(null, geopoint_Struct.double_0);
				this.vmethod_31(null, geopoint_Struct.double_1);
				return;
			}
			this.vmethod_29(null, activeUnit_1.vmethod_28(null));
			this.vmethod_31(null, activeUnit_1.vmethod_30(null));
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x001179C8 File Offset: 0x00115BC8
		public Contact(ActiveUnit DetectedUnit, int AutoIncrement = 0)
		{
			this.dictionary_0 = new Dictionary<Side, Misc.PostureStance>();
			this.nullable_10 = null;
			this.float_9 = 0f;
			this.float_10 = 0f;
			this.float_11 = 0f;
			this.float_12 = 0f;
			this.list_2 = new List<Contact.Class269>();
			this.list_4 = new List<GeoPoint>();
			this.list_5 = new List<GeoPoint>();
			this.list_6 = new List<GeoPoint>();
			this.bool_20 = true;
			this.queue_0 = new Queue<ValueTuple<string, string, float, ActiveUnit_Sensory.Enum35, DateTime>>();
			this.object_0 = RuntimeHelpers.GetObjectValue(new object());
			this.object_1 = RuntimeHelpers.GetObjectValue(new object());
			this.object_2 = RuntimeHelpers.GetObjectValue(new object());
			this.bool_12 = false;
			if (!Information.IsNothing(AutoIncrement))
			{
				this.int_0 = AutoIncrement;
			}
			else
			{
				this.int_0 = 0;
			}
			if (DetectedUnit != null)
			{
				try
				{
					this.activeUnit_0 = DetectedUnit;
					if (DetectedUnit.bool_3)
					{
						this.contactType_0 = Contact_Base.ContactType.Air;
					}
					else if (DetectedUnit.bool_2)
					{
						Weapon._WeaponType weaponType = ((Weapon)DetectedUnit).method_167();
						if (weaponType <= Weapon._WeaponType.Torpedo)
						{
							if (weaponType == Weapon._WeaponType.GuidedWeapon)
							{
								goto IL_1B2;
							}
							if (weaponType != Weapon._WeaponType.Decoy_Vehicle)
							{
								if (weaponType == Weapon._WeaponType.Torpedo)
								{
									this.contactType_0 = Contact_Base.ContactType.Torpedo;
									goto IL_298;
								}
							}
							else
							{
								if (DetectedUnit.method_88())
								{
									this.contactType_0 = Contact_Base.ContactType.Air;
									goto IL_298;
								}
								if (DetectedUnit.method_89())
								{
									this.contactType_0 = Contact_Base.ContactType.Surface;
									goto IL_298;
								}
								if (DetectedUnit.method_90())
								{
									this.contactType_0 = Contact_Base.ContactType.Submarine;
									goto IL_298;
								}
								goto IL_298;
							}
						}
						else
						{
							if (weaponType == Weapon._WeaponType.Sonobuoy)
							{
								this.contactType_0 = Contact_Base.ContactType.Sonobuoy;
								goto IL_298;
							}
							if (weaponType - Weapon._WeaponType.BallisticMissile <= 1)
							{
								goto IL_1B2;
							}
							if (weaponType == Weapon._WeaponType.HGV)
							{
								goto IL_1B2;
							}
						}
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw new NotImplementedException();
						IL_1B2:
						this.contactType_0 = Contact_Base.ContactType.Missile;
					}
					else if (DetectedUnit.bool_8)
					{
						if (((Facility)DetectedUnit).method_154())
						{
							this.contactType_0 = Contact_Base.ContactType.Facility_Mobile;
						}
						else
						{
							this.contactType_0 = Contact_Base.ContactType.Facility_Fixed;
						}
					}
					else if (DetectedUnit.bool_6)
					{
						this.contactType_0 = Contact_Base.ContactType.Surface;
					}
					else if (DetectedUnit.bool_5)
					{
						this.contactType_0 = Contact_Base.ContactType.Submarine;
					}
					else if (DetectedUnit.method_1())
					{
						this.contactType_0 = Contact_Base.ContactType.Orbital;
					}
					else
					{
						if (!DetectedUnit.bool_1)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							throw new NotImplementedException();
						}
						if (((Group)this.activeUnit_0).method_143() == Group.GroupType.AirBase)
						{
							this.contactType_0 = Contact_Base.ContactType.AirBase;
						}
						else if (((Group)this.activeUnit_0).method_143() == Group.GroupType.MobileGroup)
						{
							this.contactType_0 = Contact_Base.ContactType.MobileGroup;
						}
						else if (((Group)this.activeUnit_0).method_143() == Group.GroupType.NavalBase)
						{
							this.contactType_0 = Contact_Base.ContactType.NavalBase;
						}
						else
						{
							this.contactType_0 = Contact_Base.ContactType.Installation;
						}
					}
					IL_298:
					if (this.activeUnit_0 != null)
					{
						foreach (Side side in this.activeUnit_0.scenario_0.method_44())
						{
							if (side != null && side.method_11().ContainsKey(this.activeUnit_0.string_0))
							{
								this.dictionary_0.Add(side, Misc.PostureStance.Unknown);
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100495", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00117D2C File Offset: 0x00115F2C
		public float method_138(Unit unit_0)
		{
			float result;
			try
			{
				float num = this.vmethod_40() / 3600f;
				double double_;
				double double_2;
				Class411.smethod_1(this.vmethod_28(null), this.vmethod_30(null), ref double_, ref double_2, (double)num, (double)this.vmethod_9());
				float num2 = Math2.smethod_17(unit_0.vmethod_30(null), unit_0.vmethod_28(null), this.vmethod_30(null), this.vmethod_28(null));
				float num3 = Math2.smethod_17(unit_0.vmethod_30(null), unit_0.vmethod_28(null), double_2, double_);
				num3 = Math2.smethod_7(num3 - num2);
				if (num3 > 180f)
				{
					result = 360f - num3;
				}
				else
				{
					result = num3;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100496", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00117E58 File Offset: 0x00116058
		public void method_139(double double_2, ref Scenario scenario_0)
		{
			if (!Information.IsNothing(this.method_112()) || this.method_57() != 0f)
			{
				try
				{
					if (Information.IsNothing(this.method_112()) || !Misc.smethod_49(this.method_112()))
					{
						double num;
						if (this.bool_17)
						{
							num = (double)this.vmethod_40();
						}
						else
						{
							switch (this.contactType_0)
							{
							case Contact_Base.ContactType.Air:
								num = 660.0;
								break;
							case Contact_Base.ContactType.Missile:
								num = 1000.0;
								break;
							case Contact_Base.ContactType.Surface:
							case Contact_Base.ContactType.Submarine:
								num = 20.0;
								break;
							case Contact_Base.ContactType.Orbital:
								num = 6000.0;
								break;
							case Contact_Base.ContactType.Facility_Mobile:
								num = 20.0;
								break;
							case Contact_Base.ContactType.Torpedo:
								num = 45.0;
								break;
							}
						}
						if (num != 0.0)
						{
							double num2 = num / 3600.0 * double_2;
							double num3 = num2 * 1852.0;
							if (Information.IsNothing(this.method_112()))
							{
								Class432.Struct48[] array = new Class432.Struct48[46];
								Class411.smethod_0(this.vmethod_30(null), this.vmethod_28(null), num2, 45, ref array);
								List<GeoPoint> list = new List<GeoPoint>();
								foreach (Class432.Struct48 @struct in array)
								{
									list.Add(new GeoPoint(@struct.double_0, @struct.double_1));
								}
								this.method_113(list);
							}
							else
							{
								if (num3 > 0.0)
								{
									try
									{
										Class432.Class433 @class = new Class432.Class433(this.vmethod_30(null), this.vmethod_28(null));
										List<IntPoint> list2 = new List<IntPoint>();
										try
										{
											foreach (GeoPoint geoPoint in this.method_112())
											{
												double num4 = geoPoint.imethod_2();
												double num5 = geoPoint.imethod_0();
												while (num5 > 180.0 || num5 < -180.0)
												{
													num5 = Math2.smethod_11(ref num5);
												}
												if (num4 > 90.0)
												{
													num4 = 90.0;
												}
												if (num4 < -90.0)
												{
													num4 = -90.0;
												}
												try
												{
													double a;
													double a2;
													if (@class.method_1(num4, num5, ref a, ref a2, false))
													{
														list2.Add(new IntPoint((long)Math.Round(a), (long)Math.Round(a2)));
													}
												}
												catch (Exception ex)
												{
													ex.Data.Add("Error at 200026", ex.Message);
													GameGeneral.smethod_25(ref ex);
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
												}
											}
										}
										finally
										{
											List<GeoPoint>.Enumerator enumerator;
											((IDisposable)enumerator).Dispose();
										}
										List<List<IntPoint>> list3 = new List<List<IntPoint>>();
										list3.Add(list2);
										Class146 class2 = new Class146(2.0, 0.25);
										class2.method_5(list3, Enum22.const_0, Enum23.const_0);
										List<List<IntPoint>> list4 = new List<List<IntPoint>>();
										class2.method_8(ref list4, num3);
										List<List<IntPoint>> list5 = list4;
										List<GeoPoint> list6 = new List<GeoPoint>();
										if (list5.Count == 0)
										{
											return;
										}
										try
										{
											foreach (IntPoint intPoint in list5[0])
											{
												try
												{
													double double_3;
													double double_4;
													if (@class.method_6((double)intPoint.long_0, (double)intPoint.long_1, ref double_3, ref double_4))
													{
														list6.Add(new GeoPoint(double_4, double_3));
													}
												}
												catch (Exception ex2)
												{
													ex2.Data.Add("Error at 200002", "");
													GameGeneral.smethod_25(ref ex2);
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
												}
											}
										}
										finally
										{
											List<IntPoint>.Enumerator enumerator2;
											((IDisposable)enumerator2).Dispose();
										}
										if (list6.Count > 100)
										{
											list6 = Math2.smethod_21(list6);
										}
										this.method_113(list6);
									}
									catch (Exception ex3)
									{
										ex3.Data.Add("Error at 200287", ex3.Message);
										GameGeneral.smethod_25(ref ex3);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
									}
								}
								this.method_66(ref scenario_0);
							}
						}
					}
				}
				catch (Exception ex4)
				{
					ex4.Data.Add("Error at 100498", "");
					GameGeneral.smethod_25(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x000096FF File Offset: 0x000078FF
		public override void vmethod_42(ref Scenario scenario_0, double double_2, double double_3)
		{
			base.vmethod_42(ref scenario_0, double_2, double_3);
			this.activeUnit_0.vmethod_42(ref scenario_0, double_2, double_3);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00009718 File Offset: 0x00007918
		private void method_140(object sender, NotifyDictionaryChangedEventArgs<int, EmissionContainer> e)
		{
			this.list_7 = null;
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00118358 File Offset: 0x00116558
		public Contact method_141()
		{
			Contact contact = (Contact)base.MemberwiseClone();
			Contact result;
			try
			{
				contact.vmethod_0(Guid.NewGuid().ToString());
				contact.vmethod_50(new ObservableDictionary<int, EmissionContainer>());
				if (!Information.IsNothing(this.vmethod_49()))
				{
					contact.vmethod_49().AddRange(this.vmethod_49());
				}
				contact.weapon_0 = null;
				contact.concurrentDictionary_0 = new ConcurrentDictionary<string, ActiveUnit>();
				contact.list_2 = new List<Contact.Class269>();
				if (!Information.IsNothing(this.list_2))
				{
					contact.list_2.AddRange(this.list_2);
				}
				contact.list_3 = new List<GeoPoint>();
				if (!Information.IsNothing(this.list_3))
				{
					contact.list_3.AddRange(this.list_3);
				}
				contact.list_7 = new List<int>();
				if (!Information.IsNothing(this.list_7))
				{
					contact.list_7.AddRange(this.list_7);
				}
				contact.dictionary_0 = new Dictionary<Side, Misc.PostureStance>(this.dictionary_0.Count);
				if (!Information.IsNothing(this.dictionary_0))
				{
					try
					{
						foreach (KeyValuePair<Side, Misc.PostureStance> keyValuePair in this.dictionary_0)
						{
							contact.dictionary_0.Add(keyValuePair.Key, keyValuePair.Value);
						}
					}
					finally
					{
						Dictionary<Side, Misc.PostureStance>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				result = contact;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101418", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00009721 File Offset: 0x00007921
		public void method_142(ValueTuple<string, string, float, ActiveUnit_Sensory.Enum35, DateTime> valueTuple_0)
		{
			this.queue_0.Enqueue(valueTuple_0);
			while (this.queue_0.Count > 15)
			{
				this.queue_0.Dequeue();
			}
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x0000974C File Offset: 0x0000794C
		[CompilerGenerated]
		private Sensor method_143(KeyValuePair<int, EmissionContainer> keyValuePair_0)
		{
			return keyValuePair_0.Value.method_0(keyValuePair_0.Key, this.activeUnit_0.scenario_0);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x0000974C File Offset: 0x0000794C
		[CompilerGenerated]
		private Sensor method_144(KeyValuePair<int, EmissionContainer> keyValuePair_0)
		{
			return keyValuePair_0.Value.method_0(keyValuePair_0.Key, this.activeUnit_0.scenario_0);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x0000974C File Offset: 0x0000794C
		[CompilerGenerated]
		private Sensor method_145(KeyValuePair<int, EmissionContainer> keyValuePair_0)
		{
			return keyValuePair_0.Value.method_0(keyValuePair_0.Key, this.activeUnit_0.scenario_0);
		}

		// Token: 0x040008F2 RID: 2290
		private string string_5;

		// Token: 0x040008F3 RID: 2291
		public ActiveUnit activeUnit_0;

		// Token: 0x040008F4 RID: 2292
		public string string_6;

		// Token: 0x040008F5 RID: 2293
		private bool bool_13;

		// Token: 0x040008F6 RID: 2294
		private bool bool_14;

		// Token: 0x040008F7 RID: 2295
		private Dictionary<Side, Misc.PostureStance> dictionary_0;

		// Token: 0x040008F8 RID: 2296
		private Dictionary<string, Misc.PostureStance> dictionary_1;

		// Token: 0x040008F9 RID: 2297
		private Misc.PostureStance? nullable_10;

		// Token: 0x040008FA RID: 2298
		public bool bool_15;

		// Token: 0x040008FB RID: 2299
		public float float_9;

		// Token: 0x040008FC RID: 2300
		private float float_10;

		// Token: 0x040008FD RID: 2301
		public float float_11;

		// Token: 0x040008FE RID: 2302
		public float float_12;

		// Token: 0x040008FF RID: 2303
		public bool bool_16;

		// Token: 0x04000900 RID: 2304
		private Weapon[] weapon_0;

		// Token: 0x04000901 RID: 2305
		private Contact.Enum47? nullable_11;

		// Token: 0x04000902 RID: 2306
		private ActiveUnit_Damage.FireIntensityLevel? nullable_12;

		// Token: 0x04000903 RID: 2307
		private ActiveUnit_Damage.FloodingIntensityLevel? nullable_13;

		// Token: 0x04000904 RID: 2308
		private List<Contact.Class269> list_2;

		// Token: 0x04000905 RID: 2309
		public bool bool_17;

		// Token: 0x04000906 RID: 2310
		public bool bool_18;

		// Token: 0x04000907 RID: 2311
		public bool bool_19;

		// Token: 0x04000908 RID: 2312
		private List<GeoPoint> list_3;

		// Token: 0x04000909 RID: 2313
		private List<GeoPoint> list_4;

		// Token: 0x0400090A RID: 2314
		private List<GeoPoint> list_5;

		// Token: 0x0400090B RID: 2315
		private List<GeoPoint> list_6;

		// Token: 0x0400090C RID: 2316
		internal float float_13;

		// Token: 0x0400090D RID: 2317
		internal float float_14;

		// Token: 0x0400090E RID: 2318
		private float float_15;

		// Token: 0x0400090F RID: 2319
		public float float_16;

		// Token: 0x04000910 RID: 2320
		private bool bool_20;

		// Token: 0x04000911 RID: 2321
		private float float_17;

		// Token: 0x04000912 RID: 2322
		private float float_18;

		// Token: 0x04000913 RID: 2323
		public Queue<ValueTuple<string, string, float, ActiveUnit_Sensory.Enum35, DateTime>> queue_0;

		// Token: 0x04000914 RID: 2324
		[CompilerGenerated]
		[AccessedThroughProperty("_DetectedEmissions")]
		private ObservableDictionary<int, EmissionContainer> observableDictionary_0;

		// Token: 0x04000915 RID: 2325
		public ObservableDictionary<int, EmissionContainer> observableDictionary_1;

		// Token: 0x04000916 RID: 2326
		public List<int> list_7;

		// Token: 0x04000917 RID: 2327
		private object object_0;

		// Token: 0x04000918 RID: 2328
		internal float? nullable_14;

		// Token: 0x04000919 RID: 2329
		internal float? nullable_15;

		// Token: 0x0400091A RID: 2330
		internal float? nullable_16;

		// Token: 0x0400091B RID: 2331
		internal float? nullable_17;

		// Token: 0x0400091C RID: 2332
		internal float? nullable_18;

		// Token: 0x0400091D RID: 2333
		internal float? nullable_19;

		// Token: 0x0400091E RID: 2334
		internal bool bool_21;

		// Token: 0x0400091F RID: 2335
		public bool bool_22;

		// Token: 0x04000920 RID: 2336
		private bool bool_23;

		// Token: 0x04000921 RID: 2337
		private StringBuilder stringBuilder_0;

		// Token: 0x04000922 RID: 2338
		private float? nullable_20;

		// Token: 0x04000923 RID: 2339
		private float? nullable_21;

		// Token: 0x04000924 RID: 2340
		private float? nullable_22;

		// Token: 0x04000925 RID: 2341
		private float? nullable_23;

		// Token: 0x04000926 RID: 2342
		private float? nullable_24;

		// Token: 0x04000927 RID: 2343
		private Contact_Base.IdentificationStatus identificationStatus_1;

		// Token: 0x04000928 RID: 2344
		private float? nullable_25;

		// Token: 0x04000929 RID: 2345
		private Contact_Base.IdentificationStatus identificationStatus_2;

		// Token: 0x0400092A RID: 2346
		private float? nullable_26;

		// Token: 0x0400092B RID: 2347
		private Contact_Base.IdentificationStatus identificationStatus_3;

		// Token: 0x0400092C RID: 2348
		private object object_1;

		// Token: 0x0400092D RID: 2349
		private bool? nullable_27;

		// Token: 0x0400092E RID: 2350
		private object object_2;

		// Token: 0x020001C3 RID: 451
		internal enum Enum47 : byte
		{
			// Token: 0x04000930 RID: 2352
			const_0,
			// Token: 0x04000931 RID: 2353
			const_1,
			// Token: 0x04000932 RID: 2354
			const_2,
			// Token: 0x04000933 RID: 2355
			const_3,
			// Token: 0x04000934 RID: 2356
			const_4
		}

		// Token: 0x020001C4 RID: 452
		internal sealed class Class269
		{
			// Token: 0x06000E51 RID: 3665 RVA: 0x00118520 File Offset: 0x00116720
			public string method_0()
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
					this.stringBuilder_0.Append("<HURR>");
					this.stringBuilder_0.Append("<UID>").Append(this.string_0).Append("</UID>");
					this.stringBuilder_0.Append("<IDS>").Append(Conversions.ToString((int)this.identificationStatus_0)).Append("</IDS>");
					this.stringBuilder_0.Append("<RA>").Append(XmlConvert.ToString(this.float_0)).Append("</RA>");
					this.stringBuilder_0.Append("</HURR>");
					result = this.stringBuilder_0.ToString();
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101312340958903458932993", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				return result;
			}

			// Token: 0x06000E52 RID: 3666 RVA: 0x00118648 File Offset: 0x00116848
			public static Contact.Class269 smethod_0(XmlNode xmlNode_0)
			{
				Contact.Class269 result;
				try
				{
					Contact.Class269 @class = new Contact.Class269();
					try
					{
						foreach (object obj in xmlNode_0.ChildNodes)
						{
							XmlNode xmlNode = (XmlNode)obj;
							string name = xmlNode.Name;
							if (Operators.CompareString(name, "UID", false) != 0)
							{
								if (Operators.CompareString(name, "IDS", false) != 0)
								{
									if (Operators.CompareString(name, "RA", false) == 0)
									{
										@class.float_0 = XmlConvert.ToSingle(xmlNode.InnerText);
									}
								}
								else
								{
									@class.identificationStatus_0 = (Contact_Base.IdentificationStatus)Conversions.ToShort(xmlNode.InnerText);
								}
							}
							else
							{
								@class.string_0 = xmlNode.InnerText;
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
					result = @class;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101314", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new Contact.Class269();
				}
				return result;
			}

			// Token: 0x04000935 RID: 2357
			public string string_0;

			// Token: 0x04000936 RID: 2358
			public Contact_Base.IdentificationStatus identificationStatus_0;

			// Token: 0x04000937 RID: 2359
			public float float_0;

			// Token: 0x04000938 RID: 2360
			private StringBuilder stringBuilder_0;
		}

		// Token: 0x020001C6 RID: 454
		[CompilerGenerated]
		internal sealed class Class270
		{
			// Token: 0x06000E68 RID: 3688 RVA: 0x000097EF File Offset: 0x000079EF
			internal float method_0(GeoPoint geoPoint_0)
			{
				return Class437.smethod_3(this.float_0, Math2.smethod_17(this.class271_0.double_0, this.class271_0.double_1, geoPoint_0.imethod_2(), geoPoint_0.imethod_0()));
			}

			// Token: 0x0400094C RID: 2380
			public float float_0;

			// Token: 0x0400094D RID: 2381
			public Contact.Class271 class271_0;
		}

		// Token: 0x020001C7 RID: 455
		[CompilerGenerated]
		internal sealed class Class271
		{
			// Token: 0x0400094E RID: 2382
			public double double_0;

			// Token: 0x0400094F RID: 2383
			public double double_1;
		}

		// Token: 0x020001C8 RID: 456
		[CompilerGenerated]
		internal sealed class Class272
		{
			// Token: 0x06000E6B RID: 3691 RVA: 0x0011875C File Offset: 0x0011695C
			internal double method_0(GeoPoint geoPoint_0)
			{
				Unit unit = this.unit_0;
				double double_ = geoPoint_0.imethod_2();
				double double_2 = geoPoint_0.imethod_0();
				double result = unit.method_30(ref double_, ref double_2);
				geoPoint_0.imethod_1(double_2);
				geoPoint_0.imethod_3(double_);
				return result;
			}

			// Token: 0x04000950 RID: 2384
			public Unit unit_0;
		}
	}
}
