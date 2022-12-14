using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using DarkUI.Collections;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns13;
using ns14;
using ns8;

namespace Command_Core
{
	// Token: 0x02000336 RID: 822
	public sealed class Side : Class310
	{
		// Token: 0x06001835 RID: 6197 RVA: 0x0000C8A4 File Offset: 0x0000AAA4
		[CompilerGenerated]
		internal List<ActiveUnit> vmethod_4()
		{
			return this.list_0;
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0000C8AC File Offset: 0x0000AAAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(List<ActiveUnit> list_11)
		{
			this.list_0 = list_11;
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x0000C8B5 File Offset: 0x0000AAB5
		[CompilerGenerated]
		internal List<ActiveUnit> vmethod_6()
		{
			return this.list_1;
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x0000C8BD File Offset: 0x0000AABD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(List<ActiveUnit> list_11)
		{
			this.list_1 = list_11;
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x0000C8C6 File Offset: 0x0000AAC6
		[CompilerGenerated]
		private ObservableDictionary<string, Contact> vmethod_8()
		{
			return this.observableDictionary_0;
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x001BA780 File Offset: 0x001B8980
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_9(ObservableDictionary<string, Contact> observableDictionary_2)
		{
			INotifyDictionaryChanged<string, Contact>.DictionaryChangedEventHandler obj = new INotifyDictionaryChanged<string, Contact>.DictionaryChangedEventHandler(this.method_71);
			ObservableDictionary<string, Contact> observableDictionary = this.observableDictionary_0;
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

		// Token: 0x0600183B RID: 6203 RVA: 0x0000C8CE File Offset: 0x0000AACE
		[CompilerGenerated]
		private ObservableDictionary<string, Contact> vmethod_10()
		{
			return this.observableDictionary_1;
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x001BA7C4 File Offset: 0x001B89C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_11(ObservableDictionary<string, Contact> observableDictionary_2)
		{
			INotifyDictionaryChanged<string, Contact>.DictionaryChangedEventHandler obj = new INotifyDictionaryChanged<string, Contact>.DictionaryChangedEventHandler(this.method_72);
			ObservableDictionary<string, Contact> observableDictionary = this.observableDictionary_1;
			if (observableDictionary != null)
			{
				observableDictionary.DictionaryChanged -= obj;
			}
			this.observableDictionary_1 = observableDictionary_2;
			observableDictionary = this.observableDictionary_1;
			if (observableDictionary != null)
			{
				observableDictionary.DictionaryChanged += obj;
			}
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0000C8D6 File Offset: 0x0000AAD6
		[CompilerGenerated]
		public ObservableList<ReferencePoint> vmethod_12()
		{
			return this.observableList_0;
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x001BA808 File Offset: 0x001B8A08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_13(ObservableList<ReferencePoint> observableList_1)
		{
			EventHandler<EventArgs5<ReferencePoint>> eventHandler_ = new EventHandler<EventArgs5<ReferencePoint>>(this.method_91);
			ObservableList<ReferencePoint> observableList = this.observableList_0;
			if (observableList != null)
			{
				observableList.method_3(eventHandler_);
			}
			this.observableList_0 = observableList_1;
			observableList = this.observableList_0;
			if (observableList != null)
			{
				observableList.method_2(eventHandler_);
			}
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x001BA84C File Offset: 0x001B8A4C
		[CompilerGenerated]
		public static void smethod_0(Side.Delegate48 delegate48_1)
		{
			Side.Delegate48 @delegate = Side.delegate48_0;
			Side.Delegate48 delegate2;
			do
			{
				delegate2 = @delegate;
				Side.Delegate48 value = (Side.Delegate48)Delegate.Combine(delegate2, delegate48_1);
				@delegate = Interlocked.CompareExchange<Side.Delegate48>(ref Side.delegate48_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x001BA880 File Offset: 0x001B8A80
		[CompilerGenerated]
		public static void smethod_1(Side.Delegate49 delegate49_1)
		{
			Side.Delegate49 @delegate = Side.delegate49_0;
			Side.Delegate49 delegate2;
			do
			{
				delegate2 = @delegate;
				Side.Delegate49 value = (Side.Delegate49)Delegate.Combine(delegate2, delegate49_1);
				@delegate = Interlocked.CompareExchange<Side.Delegate49>(ref Side.delegate49_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x001BA8B4 File Offset: 0x001B8AB4
		[CompilerGenerated]
		public static void smethod_2(Side.Delegate50 delegate50_1)
		{
			Side.Delegate50 @delegate = Side.delegate50_0;
			Side.Delegate50 delegate2;
			do
			{
				delegate2 = @delegate;
				Side.Delegate50 value = (Side.Delegate50)Delegate.Combine(delegate2, delegate50_1);
				@delegate = Interlocked.CompareExchange<Side.Delegate50>(ref Side.delegate50_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x001BA8E8 File Offset: 0x001B8AE8
		[CompilerGenerated]
		public static void smethod_3(Side.Delegate50 delegate50_1)
		{
			Side.Delegate50 @delegate = Side.delegate50_0;
			Side.Delegate50 delegate2;
			do
			{
				delegate2 = @delegate;
				Side.Delegate50 value = (Side.Delegate50)Delegate.Remove(delegate2, delegate50_1);
				@delegate = Interlocked.CompareExchange<Side.Delegate50>(ref Side.delegate50_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x001BA91C File Offset: 0x001B8B1C
		[CompilerGenerated]
		public static void smethod_4(Side.Delegate51 delegate51_1)
		{
			Side.Delegate51 @delegate = Side.delegate51_0;
			Side.Delegate51 delegate2;
			do
			{
				delegate2 = @delegate;
				Side.Delegate51 value = (Side.Delegate51)Delegate.Combine(delegate2, delegate51_1);
				@delegate = Interlocked.CompareExchange<Side.Delegate51>(ref Side.delegate51_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x001BA950 File Offset: 0x001B8B50
		[CompilerGenerated]
		public static void smethod_5(Side.Delegate51 delegate51_1)
		{
			Side.Delegate51 @delegate = Side.delegate51_0;
			Side.Delegate51 delegate2;
			do
			{
				delegate2 = @delegate;
				Side.Delegate51 value = (Side.Delegate51)Delegate.Remove(delegate2, delegate51_1);
				@delegate = Interlocked.CompareExchange<Side.Delegate51>(ref Side.delegate51_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x001BA984 File Offset: 0x001B8B84
		[CompilerGenerated]
		public static void smethod_6(Side.Delegate52 delegate52_1)
		{
			Side.Delegate52 @delegate = Side.delegate52_0;
			Side.Delegate52 delegate2;
			do
			{
				delegate2 = @delegate;
				Side.Delegate52 value = (Side.Delegate52)Delegate.Combine(delegate2, delegate52_1);
				@delegate = Interlocked.CompareExchange<Side.Delegate52>(ref Side.delegate52_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x001BA9B8 File Offset: 0x001B8BB8
		[CompilerGenerated]
		public static void smethod_7(Side.Delegate52 delegate52_1)
		{
			Side.Delegate52 @delegate = Side.delegate52_0;
			Side.Delegate52 delegate2;
			do
			{
				delegate2 = @delegate;
				Side.Delegate52 value = (Side.Delegate52)Delegate.Remove(delegate2, delegate52_1);
				@delegate = Interlocked.CompareExchange<Side.Delegate52>(ref Side.delegate52_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x001BA9EC File Offset: 0x001B8BEC
		[CompilerGenerated]
		public static void smethod_8(Side.Delegate53 delegate53_1)
		{
			Side.Delegate53 @delegate = Side.delegate53_0;
			Side.Delegate53 delegate2;
			do
			{
				delegate2 = @delegate;
				Side.Delegate53 value = (Side.Delegate53)Delegate.Combine(delegate2, delegate53_1);
				@delegate = Interlocked.CompareExchange<Side.Delegate53>(ref Side.delegate53_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x001BAA20 File Offset: 0x001B8C20
		[CompilerGenerated]
		public static void smethod_9(Side.Delegate53 delegate53_1)
		{
			Side.Delegate53 @delegate = Side.delegate53_0;
			Side.Delegate53 delegate2;
			do
			{
				delegate2 = @delegate;
				Side.Delegate53 value = (Side.Delegate53)Delegate.Remove(delegate2, delegate53_1);
				@delegate = Interlocked.CompareExchange<Side.Delegate53>(ref Side.delegate53_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x001BAA54 File Offset: 0x001B8C54
		public void method_8(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_3, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Side");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				if (hashSet_3.Contains(this.string_0))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_3.Add(this.string_0);
					xmlWriter_0.WriteElementString("Name", this.method_51());
					if (this.dictionary_0.Count > 0)
					{
						xmlWriter_0.WriteStartElement("Postures");
						try
						{
							foreach (KeyValuePair<Side, Misc.PostureStance> keyValuePair in this.dictionary_0)
							{
								xmlWriter_0.WriteElementString("Posture_" + keyValuePair.Key.string_0, ((int)keyValuePair.Value).ToString());
							}
						}
						finally
						{
							Dictionary<Side, Misc.PostureStance>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						xmlWriter_0.WriteEndElement();
					}
					if (this.vmethod_12().Count > 0)
					{
						xmlWriter_0.WriteStartElement("ReferencePoints");
						List<ReferencePoint> list = Enumerable.ToList<ReferencePoint>(this.vmethod_12());
						try
						{
							foreach (ReferencePoint referencePoint in list)
							{
								if (!Information.IsNothing(referencePoint))
								{
									xmlWriter_0.WriteRaw(referencePoint.method_17(ref hashSet_3));
								}
							}
						}
						finally
						{
							List<ReferencePoint>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						xmlWriter_0.WriteEndElement();
					}
					if (!Information.IsNothing(this.doctrine_0))
					{
						this.doctrine_0.method_282(ref xmlWriter_0, ref scenario_0, "Doctrine");
					}
					if (this.list_6.Count > 0)
					{
						xmlWriter_0.WriteStartElement("ExclusionZones");
						List<ExclusionZone> list2 = Enumerable.ToList<ExclusionZone>(this.list_6);
						try
						{
							foreach (ExclusionZone exclusionZone in list2)
							{
								exclusionZone.method_15(ref xmlWriter_0, ref hashSet_3, ref scenario_0);
							}
						}
						finally
						{
							List<ExclusionZone>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
						xmlWriter_0.WriteEndElement();
					}
					if (this.list_7.Count > 0)
					{
						xmlWriter_0.WriteStartElement("NoNavZones");
						List<NoNavZone> list3 = Enumerable.ToList<NoNavZone>(this.list_7);
						try
						{
							foreach (NoNavZone noNavZone in list3)
							{
								noNavZone.method_15(ref xmlWriter_0, ref hashSet_3, ref scenario_0);
							}
						}
						finally
						{
							List<NoNavZone>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteElementString("CollectiveResponsibility", this.bool_13.ToString());
					if (this.bool_14)
					{
						xmlWriter_0.WriteElementString("CATC", this.bool_14.ToString());
					}
					if (this.dictionary_3.Count > 0)
					{
						xmlWriter_0.WriteStartElement("QuickJumpSlots");
						try
						{
							foreach (QuickJumpSlot quickJumpSlot in this.dictionary_3.Values)
							{
								quickJumpSlot.method_0(ref xmlWriter_0);
							}
						}
						finally
						{
							Dictionary<byte, QuickJumpSlot>.ValueCollection.Enumerator enumerator5;
							((IDisposable)enumerator5).Dispose();
						}
						xmlWriter_0.WriteEndElement();
					}
					if (!string.IsNullOrEmpty(this.string_3))
					{
						xmlWriter_0.WriteElementString("Briefing", this.string_3);
					}
					if (!Information.IsNothing(this.geoPoint_0))
					{
						xmlWriter_0.WriteStartElement("MapCenter");
						xmlWriter_0.WriteRaw(this.geoPoint_0.method_8(hashSet_3));
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteElementString("CameraAlt", XmlConvert.ToString(this.double_0));
					xmlWriter_0.WriteElementString("TotalScore", XmlConvert.ToString(this.int_0));
					if (this.list_8.Count > 0)
					{
						xmlWriter_0.WriteStartElement("ScoringLog");
						try
						{
							foreach (string value in this.list_8)
							{
								xmlWriter_0.WriteElementString("msg", value);
							}
						}
						finally
						{
							List<string>.Enumerator enumerator6;
							((IDisposable)enumerator6).Dispose();
						}
						xmlWriter_0.WriteEndElement();
					}
					if (this.nullable_0 != null)
					{
						xmlWriter_0.WriteElementString("Scoring_Disaster", XmlConvert.ToString(this.nullable_0.Value));
					}
					if (this.nullable_1 != null)
					{
						xmlWriter_0.WriteElementString("Scoring_Triumph", XmlConvert.ToString(this.nullable_1.Value));
					}
					xmlWriter_0.WriteElementString("AwarenessLevel", Conversions.ToString((int)this.method_28()));
					if (this.method_11().Count > 0)
					{
						xmlWriter_0.WriteStartElement("Contacts");
						List<Contact> list4 = Enumerable.ToList<Contact>(this.method_44());
						try
						{
							foreach (Contact contact in list4)
							{
								if (!Information.IsNothing(contact.activeUnit_0))
								{
									xmlWriter_0.WriteRaw(contact.method_61(hashSet_3));
								}
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator7;
							((IDisposable)enumerator7).Dispose();
						}
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteElementString("ContactAutoIncrement", this.int_1.ToString());
					if (this.method_12().Count > 0)
					{
						xmlWriter_0.WriteStartElement("BaseContacts");
						List<Contact> list5 = Enumerable.ToList<Contact>(this.method_46());
						try
						{
							foreach (Contact contact2 in list5)
							{
								if (!Information.IsNothing(contact2.activeUnit_0))
								{
									xmlWriter_0.WriteRaw(contact2.method_61(hashSet_3));
								}
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator8;
							((IDisposable)enumerator8).Dispose();
						}
						xmlWriter_0.WriteEndElement();
					}
					if (this.hashSet_0.Count > 0)
					{
						xmlWriter_0.WriteStartElement("Contacts_NonAU");
						List<string> list6 = Enumerable.ToList<string>(this.hashSet_0);
						try
						{
							foreach (string value2 in list6)
							{
								xmlWriter_0.WriteElementString("ID", value2);
							}
						}
						finally
						{
							List<string>.Enumerator enumerator9;
							((IDisposable)enumerator9).Dispose();
						}
						xmlWriter_0.WriteEndElement();
					}
					if (this.list_3.Count > 0)
					{
						xmlWriter_0.WriteStartElement("Missions");
						try
						{
							foreach (Mission mission in this.list_3)
							{
								if (!Information.IsNothing(mission))
								{
									mission.vmethod_4(ref xmlWriter_0, ref hashSet_3, ref scenario_0);
								}
							}
						}
						finally
						{
							List<Mission>.Enumerator enumerator10;
							((IDisposable)enumerator10).Dispose();
						}
						xmlWriter_0.WriteEndElement();
					}
					if (Enumerable.Any<KeyValuePair<string, SpecialAction>>(this.dictionary_2))
					{
						xmlWriter_0.WriteStartElement("SpecialActions");
						try
						{
							foreach (SpecialAction specialAction in this.dictionary_2.Values)
							{
								specialAction.method_8(xmlWriter_0, hashSet_3, scenario_0);
							}
						}
						finally
						{
							Dictionary<string, SpecialAction>.ValueCollection.Enumerator enumerator11;
							((IDisposable)enumerator11).Dispose();
						}
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteElementString("Prof", Conversions.ToString((byte)this.method_24()));
					xmlWriter_0.WriteElementString("PackageID", Conversions.ToString(this.int_3));
					xmlWriter_0.WriteRaw(this.method_42().method_0());
					xmlWriter_0.WriteElementString("IsAIOnly", this.bool_12.ToString());
					this.class366_0.method_2(ref xmlWriter_0);
					checked
					{
						if (this.class316_0.Length > 0)
						{
							xmlWriter_0.WriteStartElement("WeaponSalvos");
							Class316[] array = this.class316_0;
							for (int i = 0; i < array.Length; i++)
							{
								array[i].method_10(ref xmlWriter_0, ref hashSet_3);
							}
							xmlWriter_0.WriteEndElement();
						}
						xmlWriter_0.WriteEndElement();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101048", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x001BB2A4 File Offset: 0x001B94A4
		private Side()
		{
			this.dictionary_0 = new Dictionary<Side, Misc.PostureStance>();
			this.dictionary_1 = new Dictionary<string, Misc.PostureStance>();
			this.list_2 = new List<Unit>();
			this.list_3 = new List<Mission>();
			this.list_4 = new List<Class314>();
			this.dictionary_2 = new Dictionary<string, SpecialAction>();
			this.float_0 = 0f;
			this.vmethod_9(new ObservableDictionary<string, Contact>());
			this.vmethod_11(new ObservableDictionary<string, Contact>());
			this.hashSet_0 = new HashSet<string>();
			this.lazy_0 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.lazy_1 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.lazy_2 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.lazy_3 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.activeUnit_0 = new ActiveUnit[0];
			this.vmethod_13(new ObservableList<ReferencePoint>());
			List<ActiveUnit> list = null;
			this.doctrine_0 = new Doctrine(this, ref list);
			this.class366_0 = new Side.Class366();
			this.list_6 = new List<ExclusionZone>();
			this.list_7 = new List<NoNavZone>();
			this.bool_13 = true;
			this.bool_14 = false;
			this.dictionary_3 = new Dictionary<byte, QuickJumpSlot>();
			this.class316_0 = new Class316[0];
			this.list_8 = new List<string>();
			this.dictionary_4 = new Dictionary<string, Misc.PostureStance>();
			this.dictionary_5 = new Dictionary<string, int>();
			this.dictionary_6 = new Dictionary<Contact, List<Class316>>();
			this.activeUnit_1 = new ActiveUnit[0];
			this.activeUnit_2 = new ActiveUnit[0];
			this.hashSet_1 = new HashSet<string>();
			this.hashSet_2 = new HashSet<string>();
			this.queue_0 = new Queue<Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime>>();
			this.object_0 = RuntimeHelpers.GetObjectValue(new object());
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x001BB434 File Offset: 0x001B9634
		public static Side smethod_10(string string_4, ref Dictionary<string, Class310> dictionary_7)
		{
			Side result;
			try
			{
				try
				{
					foreach (Class310 @class in dictionary_7.Values)
					{
						if (@class.GetType() == typeof(Side) && Operators.CompareString(((Side)@class).method_51(), string_4, false) == 0)
						{
							return (Side)@class;
						}
					}
				}
				finally
				{
					Dictionary<string, Class310>.ValueCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = null;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101049", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x001BB4FC File Offset: 0x001B96FC
		public static Side smethod_11(string string_4, ref Dictionary<string, Class310> dictionary_7)
		{
			Side result = null;
			if (dictionary_7.ContainsKey(string_4))
			{
				result = (Side)dictionary_7[string_4];
			}
			return result;
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x001BB524 File Offset: 0x001B9724
		public static Side smethod_12(ref XmlNode xmlNode_0, ref Scenario scenario_0, ref Dictionary<string, Class310> dictionary_7)
		{
			Side result;
			try
			{
				Side side = new Side();
				side.method_54(false);
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 1923902225U)
						{
							if (num <= 1295785029U)
							{
								if (num <= 918043797U)
								{
									if (num <= 266367750U)
									{
										if (num != 137391154U)
										{
											if (num != 266367750U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Name", false) == 0)
											{
												side.method_52(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Scoring_Triumph", false) == 0)
											{
												side.nullable_1 = new int?(XmlConvert.ToInt32(xmlNode.InnerText));
												continue;
											}
											continue;
										}
									}
									else if (num != 644518253U)
									{
										if (num != 918043797U)
										{
											continue;
										}
										if (Operators.CompareString(name, "CameraAlt", false) == 0)
										{
											side.double_0 = XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "ReferencePoints", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj2 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode2 = (XmlNode)obj2;
												side.vmethod_12().method_4(ReferencePoint.smethod_13(ref xmlNode2, ref dictionary_7));
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
								if (num <= 1005578654U)
								{
									if (num != 982696622U)
									{
										if (num != 1005578654U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Missions", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj3 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode3 = (XmlNode)obj3;
												side.list_3.Add(Mission.smethod_0(ref xmlNode3, ref dictionary_7, ref scenario_0));
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
									if (Operators.CompareString(name, "NoNavZones", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (num != 1181444488U)
									{
										if (num != 1295785029U)
										{
											continue;
										}
										if (Operators.CompareString(name, "QuickJumpSlots", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj4 in xmlNode.ChildNodes)
											{
												QuickJumpSlot quickJumpSlot = QuickJumpSlot.smethod_0((XmlNode)obj4);
												side.dictionary_3.Add(quickJumpSlot.byte_0, quickJumpSlot);
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
									if (Operators.CompareString(name, "Scoring_Disaster", false) == 0)
									{
										side.nullable_0 = new int?(XmlConvert.ToInt32(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else if (num <= 1509618259U)
							{
								if (num <= 1444793274U)
								{
									if (num != 1422437055U)
									{
										if (num != 1444793274U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Prof", false) == 0)
										{
											side.method_25((GlobalVariables.ProficiencyLevel)Conversions.ToInteger(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Doctrine", false) == 0)
										{
											side.doctrine_0 = Doctrine.smethod_9(ref xmlNode, side);
											continue;
										}
										continue;
									}
								}
								else if (num != 1458105184U)
								{
									if (num != 1509618259U)
									{
										continue;
									}
									if (Operators.CompareString(name, "CollectiveResponsibility", false) == 0)
									{
										side.bool_13 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "ID", false) != 0)
									{
										continue;
									}
									if (!dictionary_7.ContainsKey(xmlNode.InnerText))
									{
										side.vmethod_0(xmlNode.InnerText);
										dictionary_7.Add(side.string_0, side);
										continue;
									}
									return (Side)dictionary_7[xmlNode.InnerText];
								}
							}
							else
							{
								if (num <= 1889854453U)
								{
									if (num != 1531209416U)
									{
										if (num != 1889854453U)
										{
											continue;
										}
										if (Operators.CompareString(name, "BaseContacts", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj5 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode4 = (XmlNode)obj5;
												Contact contact = Contact.smethod_1(ref xmlNode4, ref dictionary_7);
												if (Information.IsNothing(contact))
												{
													side.hashSet_2.Add(xmlNode4.ChildNodes[0].InnerText);
												}
												else
												{
													side.vmethod_10().Add(contact.string_6, contact);
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
									if (Operators.CompareString(name, "Postures", false) != 0)
									{
										continue;
									}
									try
									{
										foreach (object obj6 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode5 = (XmlNode)obj6;
											if (Operators.CompareString(xmlNode5.Name, "Posture", false) == 0)
											{
												Class348.smethod_0(ref xmlNode5, ref dictionary_7);
												string innerText = Misc.smethod_44(xmlNode5.ChildNodes, "PostureTarget").InnerText;
												Misc.PostureStance value = (Misc.PostureStance)Conversions.ToByte(Misc.smethod_44(xmlNode5.ChildNodes, "PostureType").InnerText);
												try
												{
													if (!side.dictionary_1.ContainsKey(innerText))
													{
														side.dictionary_1.Add(innerText, value);
													}
													continue;
												}
												catch (Exception ex)
												{
													ex.Data.Add("Error at 200058", ex.Message);
													GameGeneral.smethod_25(ref ex);
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
													continue;
												}
											}
											string key = xmlNode5.Name.Split(new char[]
											{
												'_'
											})[1];
											Misc.PostureStance value2 = (Misc.PostureStance)Conversions.ToByte(xmlNode5.InnerText);
											try
											{
												if (!side.dictionary_1.ContainsKey(key))
												{
													side.dictionary_1.Add(key, value2);
												}
											}
											catch (Exception ex2)
											{
												ex2.Data.Add("Error at 200590", ex2.Message);
												GameGeneral.smethod_25(ref ex2);
												if (Debugger.IsAttached)
												{
													Debugger.Break();
												}
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
								if (num != 1894700857U)
								{
									if (num != 1923902225U)
									{
										continue;
									}
									if (Operators.CompareString(name, "IsAIOnly", false) == 0)
									{
										side.method_54(Conversions.ToBoolean(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Briefing", false) == 0)
									{
										side.string_3 = xmlNode.InnerText;
										side.string_3 = side.string_3.Replace("<HR>", "");
										continue;
									}
									continue;
								}
							}
						}
						else if (num <= 3230275693U)
						{
							if (num <= 2776682687U)
							{
								if (num <= 2658415675U)
								{
									if (num != 2313581294U)
									{
										if (num != 2658415675U)
										{
											continue;
										}
										if (Operators.CompareString(name, "SpecialActions", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj7 in xmlNode.ChildNodes)
											{
												SpecialAction specialAction = SpecialAction.smethod_0((XmlNode)obj7, dictionary_7, scenario_0);
												side.dictionary_2.Add(specialAction.string_0, specialAction);
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
									}
									if (Operators.CompareString(name, "Contacts_NonAU", false) != 0)
									{
										continue;
									}
									try
									{
										foreach (object obj8 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode6 = (XmlNode)obj8;
											side.hashSet_0.Add(xmlNode6.InnerText);
										}
										continue;
									}
									finally
									{
										IEnumerator enumerator8;
										if (enumerator8 is IDisposable)
										{
											(enumerator8 as IDisposable).Dispose();
										}
									}
								}
								if (num != 2725963789U)
								{
									if (num != 2776682687U)
									{
										continue;
									}
									if (Operators.CompareString(name, "AAR", false) == 0)
									{
										side.class366_0 = Side.Class366.smethod_0(ref xmlNode);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TotalScore", false) == 0)
									{
										side.int_0 = XmlConvert.ToInt32(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (num <= 2995555222U)
								{
									if (num != 2953011716U)
									{
										if (num != 2995555222U)
										{
											continue;
										}
										if (Operators.CompareString(name, "PackageID", false) == 0)
										{
											side.int_3 = (int)Conversions.ToShort(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "ScoringLog", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj9 in xmlNode.ChildNodes)
											{
												XmlNode xmlNode7 = (XmlNode)obj9;
												side.list_8.Add(xmlNode7.InnerText);
											}
											continue;
										}
										finally
										{
											IEnumerator enumerator9;
											if (enumerator9 is IDisposable)
											{
												(enumerator9 as IDisposable).Dispose();
											}
										}
									}
								}
								if (num == 3132951781U)
								{
									goto IL_949;
								}
								if (num != 3230275693U)
								{
									continue;
								}
								if (Operators.CompareString(name, "NavZones", false) != 0)
								{
									continue;
								}
							}
						}
						else if (num <= 3409555040U)
						{
							if (num <= 3397363308U)
							{
								if (num != 3366850832U)
								{
									if (num != 3397363308U)
									{
										continue;
									}
									if (Operators.CompareString(name, "CATC", false) == 0)
									{
										side.bool_14 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Contacts", false) != 0)
									{
										continue;
									}
									try
									{
										foreach (object obj10 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode8 = (XmlNode)obj10;
											Contact contact2 = Contact.smethod_1(ref xmlNode8, ref dictionary_7);
											if (Information.IsNothing(contact2))
											{
												if (!side.hashSet_1.Contains(xmlNode8.ChildNodes[0].InnerText))
												{
													side.hashSet_1.Add(xmlNode8.ChildNodes[0].InnerText);
												}
											}
											else if (!side.vmethod_8().ContainsKey(contact2.string_6))
											{
												side.vmethod_8().Add(contact2.string_6, contact2);
											}
										}
										continue;
									}
									finally
									{
										IEnumerator enumerator10;
										if (enumerator10 is IDisposable)
										{
											(enumerator10 as IDisposable).Dispose();
										}
									}
								}
							}
							if (num != 3407638882U)
							{
								if (num != 3409555040U)
								{
									continue;
								}
								if (Operators.CompareString(name, "MapCenter", false) == 0)
								{
									Side side2 = side;
									XmlNode xmlNode9 = xmlNode.ChildNodes[0];
									side2.geoPoint_0 = GeoPoint.smethod_0(ref xmlNode9, ref dictionary_7);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "MapProfile", false) == 0)
								{
									side.method_43(Class285.smethod_0(xmlNode));
									continue;
								}
								continue;
							}
						}
						else
						{
							if (num <= 3716338637U)
							{
								if (num != 3545511361U)
								{
									if (num != 3716338637U)
									{
										continue;
									}
									if (Operators.CompareString(name, "ForbiddenZones", false) != 0)
									{
										continue;
									}
									goto IL_C1B;
								}
								else
								{
									if (Operators.CompareString(name, "WeaponSalvos", false) != 0)
									{
										continue;
									}
									try
									{
										foreach (object obj11 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode10 = (XmlNode)obj11;
											Class316 @class = Class316.smethod_0(ref xmlNode10, dictionary_7, ref scenario_0);
											if (!Information.IsNothing(@class.contact_0))
											{
												Class429.smethod_42(ref side.class316_0, @class);
											}
										}
										continue;
									}
									finally
									{
										IEnumerator enumerator11;
										if (enumerator11 is IDisposable)
										{
											(enumerator11 as IDisposable).Dispose();
										}
									}
								}
							}
							if (num == 4229809279U)
							{
								goto IL_C6E;
							}
							if (num != 4253613222U)
							{
								if (num != 4270878956U)
								{
									continue;
								}
								if (Operators.CompareString(name, "AwarenessLevel", false) == 0)
								{
									side.method_29((Side.AwarenessLevel_Enum)Conversions.ToInteger(xmlNode.InnerText));
									continue;
								}
								continue;
							}
							else if (Operators.CompareString(name, "ExclusionZones", false) != 0)
							{
								continue;
							}
							IL_C1B:
							try
							{
								foreach (object obj12 in xmlNode.ChildNodes)
								{
									XmlNode xmlNode11 = (XmlNode)obj12;
									side.list_6.Add(ExclusionZone.smethod_0(ref xmlNode11, ref dictionary_7, ref scenario_0));
								}
								continue;
							}
							finally
							{
								IEnumerator enumerator12;
								if (enumerator12 is IDisposable)
								{
									(enumerator12 as IDisposable).Dispose();
								}
							}
							IL_C6E:
							if (Operators.CompareString(name, "Goals", false) == 0)
							{
								try
								{
									foreach (object obj13 in xmlNode.ChildNodes)
									{
										XmlNode xmlNode_ = (XmlNode)obj13;
										side.list_4.Add(Class314.smethod_0(xmlNode_, dictionary_7, scenario_0));
									}
								}
								finally
								{
									IEnumerator enumerator13;
									if (enumerator13 is IDisposable)
									{
										(enumerator13 as IDisposable).Dispose();
									}
								}
								continue;
							}
							continue;
						}
						try
						{
							foreach (object obj14 in xmlNode.ChildNodes)
							{
								XmlNode xmlNode12 = (XmlNode)obj14;
								side.list_7.Add(NoNavZone.smethod_0(ref xmlNode12, ref dictionary_7, ref scenario_0));
							}
							continue;
						}
						finally
						{
							IEnumerator enumerator14;
							if (enumerator14 is IDisposable)
							{
								(enumerator14 as IDisposable).Dispose();
							}
						}
						IL_949:
						if (Operators.CompareString(name, "ContactAutoIncrement", false) == 0)
						{
							side.int_1 = Conversions.ToInteger(xmlNode.InnerText);
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
				result = side;
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 101050", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Side();
			}
			return result;
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x001BC418 File Offset: 0x001BA618
		public ReadOnlyCollection<KeyValuePair<Side, Misc.PostureStance>> method_9()
		{
			List<KeyValuePair<Side, Misc.PostureStance>> list = new List<KeyValuePair<Side, Misc.PostureStance>>(this.dictionary_0.Count);
			try
			{
				foreach (KeyValuePair<Side, Misc.PostureStance> item in this.dictionary_0)
				{
					list.Add(item);
				}
			}
			finally
			{
				Dictionary<Side, Misc.PostureStance>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return list.AsReadOnly();
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x001BC484 File Offset: 0x001BA684
		public void method_10(ref Scenario scenario_0, Dictionary<string, Class310> dictionary_7, bool bool_15)
		{
			try
			{
				try
				{
					foreach (KeyValuePair<string, Misc.PostureStance> keyValuePair in this.dictionary_1)
					{
						Side side = Side.smethod_11(keyValuePair.Key, ref dictionary_7);
						if (!Information.IsNothing(side))
						{
							this.dictionary_0.Add(side, keyValuePair.Value);
						}
					}
				}
				finally
				{
					Dictionary<string, Misc.PostureStance>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (string key in this.hashSet_1)
					{
						try
						{
							Contact contact = (Contact)dictionary_7[key];
							this.method_11().Add(contact.string_6, contact);
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 200059", ex.Message);
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
					HashSet<string>.Enumerator enumerator2;
					enumerator2.Dispose();
				}
				try
				{
					foreach (string key2 in this.hashSet_2)
					{
						try
						{
							Contact contact2 = (Contact)dictionary_7[key2];
							this.method_12().Add(contact2.string_6, contact2);
						}
						catch (Exception ex2)
						{
							ex2.Data.Add("Error at 200060", ex2.Message);
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
					HashSet<string>.Enumerator enumerator3;
					enumerator3.Dispose();
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 101051", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x0000C8DE File Offset: 0x0000AADE
		public ObservableDictionary<string, Contact> method_11()
		{
			return this.vmethod_8();
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0000C8E6 File Offset: 0x0000AAE6
		public ObservableDictionary<string, Contact> method_12()
		{
			return this.vmethod_10();
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x001BC6DC File Offset: 0x001BA8DC
		public void method_13(Contact contact_0)
		{
			try
			{
				this.lazy_0.Value.TryAdd(contact_0.activeUnit_0.string_0, contact_0);
				contact_0.activeUnit_0.Name.Contains("Wierd");
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101052", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x001BC764 File Offset: 0x001BA964
		public void method_14(Contact contact_0)
		{
			try
			{
				this.lazy_1.Value.TryAdd(contact_0.activeUnit_0.string_0, contact_0);
				contact_0.activeUnit_0.Name.Contains("Wierd");
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101053", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x001BC7EC File Offset: 0x001BA9EC
		public void method_15(Contact contact_0, ref Scenario scenario_0, bool bool_15)
		{
			checked
			{
				try
				{
					if (!this.method_11().ContainsKey(contact_0.activeUnit_0.string_0))
					{
						return;
					}
					this.lazy_2.Value.TryAdd(contact_0.activeUnit_0.string_0, contact_0);
				}
				catch (Exception ex)
				{
					string key = "";
					try
					{
						foreach (KeyValuePair<string, Contact> keyValuePair in this.vmethod_8())
						{
							if (keyValuePair.Value == contact_0)
							{
								key = keyValuePair.Key;
								break;
							}
						}
					}
					finally
					{
						IEnumerator<KeyValuePair<string, Contact>> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					this.vmethod_8().Remove(key);
					ActiveUnit[] array = this.activeUnit_0;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].vmethod_88().method_67(ref key);
					}
					ex.Data.Add("Error at 200061", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				if (bool_15)
				{
					scenario_0.method_59("Contact " + contact_0.Name + " has been lost.", contact_0.Name + " vanished", LoggedMessage.MessageType.ContactChange, 5, null, this, new Geopoint_Struct(contact_0.vmethod_28(null), contact_0.vmethod_30(null)));
				}
				ActiveUnit[] array2 = this.activeUnit_0;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].vmethod_88().method_22(contact_0);
				}
			}
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x001BC98C File Offset: 0x001BAB8C
		public void method_16(Scenario scenario_0)
		{
			Side.Class367 @class = new Side.Class367(@class);
			@class.side_0 = this;
			@class.scenario_0 = scenario_0;
			this.method_45(null);
			List<Contact> list = this.method_44();
			if (this.dictionary_6.Count > 0)
			{
				this.dictionary_6.Clear();
			}
			if (Enumerable.Count<Class316>(this.class316_0) > 0)
			{
				foreach (Class316 class2 in this.class316_0)
				{
					if (this.dictionary_6.ContainsKey(class2.contact_0))
					{
						this.dictionary_6[class2.contact_0].Add(class2);
					}
					else
					{
						this.dictionary_6.Add(class2.contact_0, new List<Class316>(new Class316[]
						{
							class2
						}));
					}
				}
			}
			this.dictionary_4.Clear();
			this.dictionary_5.Clear();
			int count = list.Count;
			int num = count - 1;
			int num2 = 0;
			while (num2 <= num && num2 < count)
			{
				try
				{
					Contact contact = list[num2];
					this.dictionary_4.Add(contact.string_0, Misc.PostureStance.Neutral);
				}
				catch (Exception ex)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				num2++;
			}
			Parallel.ForEach<Contact>(list, new Action<Contact>(@class.method_0));
			List<Class316> list2 = new List<Class316>();
			Class316[] array2 = this.class316_0;
			int j = 0;
			IL_1C8:
			checked
			{
				while (j < array2.Length)
				{
					Class316 class3 = array2[j];
					bool flag = false;
					foreach (Class316.Class273 class4 in class3.class273_0)
					{
						ActiveUnit activeUnit;
						if (@class.scenario_0.vmethod_0().TryGetValue(class4.string_0, ref activeUnit) && activeUnit.vmethod_89().method_5(class3.int_0, false) > 0)
						{
							flag = true;
							IL_1B5:
							if (!flag)
							{
								list2.Add(class3);
							}
							j++;
							goto IL_1C8;
						}
					}
					goto IL_1B5;
				}
				try
				{
					foreach (Class316 class316_ in list2)
					{
						this.method_89(ref @class.scenario_0, class316_);
					}
				}
				finally
				{
					List<Class316>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x001BCBC4 File Offset: 0x001BADC4
		public void method_17(Contact theC, ref Scenario theScen, bool LogMessage = true)
		{
			try
			{
				if (!this.method_12().ContainsKey(theC.activeUnit_0.string_0))
				{
					return;
				}
				this.lazy_3.Value.TryAdd(theC.activeUnit_0.string_0, theC);
			}
			catch (Exception ex)
			{
				string key = "";
				try
				{
					foreach (KeyValuePair<string, Contact> keyValuePair in this.vmethod_10())
					{
						if (keyValuePair.Value == theC)
						{
							key = keyValuePair.Key;
						}
					}
				}
				finally
				{
					IEnumerator<KeyValuePair<string, Contact>> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				this.vmethod_10().Remove(key);
				ex.Data.Add("Error at 200062", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			if (LogMessage)
			{
				theScen.method_59("Base contact " + theC.Name + " has been lost.", theC.Name + " vanished", LoggedMessage.MessageType.ContactChange, 5, null, this, new Geopoint_Struct(theC.vmethod_28(null), theC.vmethod_30(null)));
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x001BCD0C File Offset: 0x001BAF0C
		public void method_18(Scenario scenario_0, float float_1)
		{
			try
			{
				if (this.float_0 <= 0f)
				{
					try
					{
						foreach (ActiveUnit activeUnit in scenario_0.method_42())
						{
							if (!Information.IsNothing(activeUnit) && activeUnit.method_67(this) && activeUnit.vmethod_127() && activeUnit.vmethod_7(false) != this && (!GameGeneral.dictionary_0[this.string_0].Contains(activeUnit.vmethod_7(false).string_0) || !GameGeneral.dictionary_0[activeUnit.vmethod_7(false).string_0].Contains(this.string_0)))
							{
								if (!this.vmethod_8().ContainsKey(activeUnit.string_0))
								{
									Contact contact = null;
									ActiveUnit_Sensory.smethod_5(ref contact, ref activeUnit.scenario_0, this, activeUnit, ActiveUnit_Sensory.Enum35.const_4, null, Contact_Base.IdentificationStatus.PreciseID, null);
								}
								else
								{
									this.vmethod_8()[activeUnit.string_0].method_122(true);
									this.vmethod_8()[activeUnit.string_0].method_126(scenario_0, this, null, null, false, true, false, true, Contact_Base.IdentificationStatus.PreciseID);
								}
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.float_0 = 60f;
				}
				else
				{
					ref float ptr = ref this.float_0;
					this.float_0 = ptr - float_1;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101054", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x001BCEC8 File Offset: 0x001BB0C8
		public void method_19(ref Scenario scenario_0)
		{
			try
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.vmethod_6())
					{
						Group group = (Group)activeUnit;
						if (group.method_143() == Group.GroupType.MobileGroup)
						{
							bool flag;
							try
							{
								foreach (Unit unit in group.vmethod_141().Values)
								{
									if (this.method_11().ContainsKey(unit.string_0))
									{
										flag = true;
										break;
									}
								}
							}
							finally
							{
								IEnumerator<ActiveUnit> enumerator2;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
								}
							}
							if (flag)
							{
								ActiveUnit_Sensory activeUnit_Sensory = activeUnit.vmethod_88();
								Side side = this;
								activeUnit_Sensory.vmethod_6(ref activeUnit, ref side);
							}
						}
						else
						{
							ActiveUnit_Sensory activeUnit_Sensory2 = activeUnit.vmethod_88();
							Side side = this;
							activeUnit_Sensory2.vmethod_6(ref activeUnit, ref side);
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101055", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x001BCFF4 File Offset: 0x001BB1F4
		public void method_20(Scenario scenario_0)
		{
			try
			{
				if (!this.lazy_0.Value.IsEmpty)
				{
					try
					{
						foreach (string text in this.lazy_0.Value.Keys)
						{
							if (!this.vmethod_8().ContainsKey(text))
							{
								this.vmethod_8().Add(text, this.lazy_0.Value[text]);
							}
							Contact contact;
							if (this.vmethod_8().TryGetValue(text, ref contact) && contact.side_1 != this)
							{
								contact.bool_15 = false;
							}
						}
					}
					finally
					{
						IEnumerator<string> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					this.lazy_0.Value.Clear();
				}
				if (!this.lazy_2.Value.IsEmpty)
				{
					try
					{
						foreach (string text2 in this.lazy_2.Value.Keys)
						{
							Contact contact2 = this.lazy_2.Value[text2];
							this.method_86(ref scenario_0, contact2);
							foreach (ActiveUnit activeUnit in this.activeUnit_0)
							{
								ActiveUnit_AI activeUnit_AI = activeUnit.vmethod_86();
								Side side = this;
								activeUnit_AI.method_32(ref contact2, ref side);
								activeUnit.vmethod_88().method_67(ref text2);
							}
							this.vmethod_8().Remove(text2);
							if (this.method_56().Contains(contact2))
							{
								this.method_61(contact2);
							}
						}
					}
					finally
					{
						IEnumerator<string> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
					this.lazy_2.Value.Clear();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101056", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x001BD20C File Offset: 0x001BB40C
		public void method_21(Scenario scenario_0)
		{
			try
			{
				if (!this.lazy_1.Value.IsEmpty)
				{
					try
					{
						foreach (string text in this.lazy_1.Value.Keys)
						{
							if (!this.vmethod_10().ContainsKey(text))
							{
								this.vmethod_10().Add(text, this.lazy_1.Value[text]);
							}
						}
					}
					finally
					{
						IEnumerator<string> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					this.lazy_1.Value.Clear();
				}
				if (!this.lazy_3.Value.IsEmpty)
				{
					try
					{
						foreach (string text2 in this.lazy_3.Value.Keys)
						{
							Contact contact = this.lazy_3.Value[text2];
							this.vmethod_10().Remove(text2);
							if (this.method_56().Contains(contact))
							{
								this.method_61(contact);
							}
						}
					}
					finally
					{
						IEnumerator<string> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
					this.lazy_3.Value.Clear();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101057", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0000C8EE File Offset: 0x0000AAEE
		public int method_22(Scenario theScen, string ReasonForChange = null)
		{
			return this.int_0;
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x001BD3AC File Offset: 0x001BB5AC
		public void method_23(Scenario theScen, string ReasonForChange = null, int value)
		{
			try
			{
				bool flag = value != this.int_0;
				int value2 = this.int_0;
				this.int_0 = value;
				if (flag)
				{
					this.list_8.Add(string.Concat(new string[]
					{
						theScen.method_31().ToString("MM/dd/yyyy HH:mm"),
						": Score changed from ",
						Conversions.ToString(value2),
						" to ",
						Conversions.ToString(value),
						". Reason: ",
						ReasonForChange
					}));
					List<EventTrigger> list = new List<EventTrigger>();
					try
					{
						foreach (EventTrigger eventTrigger in theScen.vmethod_4().Values)
						{
							if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.Points && ((Class334)eventTrigger).method_8(this, value2, value))
							{
								list.Add(eventTrigger);
							}
						}
					}
					finally
					{
						IEnumerator<EventTrigger> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					theScen.method_24(list);
					Side.Delegate48 @delegate = Side.delegate48_0;
					if (@delegate != null)
					{
						@delegate(this);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101058", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0000C8F6 File Offset: 0x0000AAF6
		public GlobalVariables.ProficiencyLevel method_24()
		{
			if (this.nullable_2 == null)
			{
				this.nullable_2 = new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Regular);
			}
			return this.nullable_2.Value;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0000C91C File Offset: 0x0000AB1C
		public void method_25(GlobalVariables.ProficiencyLevel proficiencyLevel_0)
		{
			this.nullable_2 = new GlobalVariables.ProficiencyLevel?(proficiencyLevel_0);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x001BD4FC File Offset: 0x001BB6FC
		public GeoPoint method_26()
		{
			if (Information.IsNothing(this.geoPoint_0))
			{
				if (Enumerable.Count<ActiveUnit>(this.activeUnit_0) > 0)
				{
					this.geoPoint_0 = new GeoPoint(this.activeUnit_0[0].vmethod_28(null), this.activeUnit_0[0].vmethod_30(null));
				}
				else
				{
					this.geoPoint_0 = new GeoPoint(0.0, 0.0);
				}
			}
			return this.geoPoint_0;
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0000C92A File Offset: 0x0000AB2A
		public void method_27(GeoPoint geoPoint_1)
		{
			this.geoPoint_0 = geoPoint_1;
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0000C933 File Offset: 0x0000AB33
		public Side.AwarenessLevel_Enum method_28()
		{
			return this.awarenessLevel_Enum_0;
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x0000C93B File Offset: 0x0000AB3B
		public void method_29(Side.AwarenessLevel_Enum awarenessLevel_Enum_1)
		{
			this.awarenessLevel_Enum_0 = awarenessLevel_Enum_1;
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x001BD580 File Offset: 0x001BB780
		public int method_30()
		{
			int result;
			if (this.nullable_0 != null && this.nullable_1 != null)
			{
				double num = (double)this.method_32();
				int? num2 = (this.nullable_1 - this.method_32()) * 2;
				result = (int)Math.Round((num - ((num2 != null) ? new double?((double)num2.GetValueOrDefault()) : null) / 3.0).Value);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x001BD698 File Offset: 0x001BB898
		public int method_31()
		{
			int result;
			if (this.nullable_0 != null && this.nullable_1 != null)
			{
				double num = (double)this.method_32();
				int? num2 = (this.nullable_1 - this.method_32()) * 1;
				result = (int)Math.Round((num - ((num2 != null) ? new double?((double)num2.GetValueOrDefault()) : null) / 3.0).Value);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x001BD7B0 File Offset: 0x001BB9B0
		public int method_32()
		{
			int result;
			if (this.nullable_0 != null && this.nullable_1 != null)
			{
				int? num = this.nullable_1;
				double? num2 = (num != null) ? new double?((double)num.GetValueOrDefault()) : null;
				num = this.nullable_1 - this.nullable_0;
				result = (int)Math.Round((num2 - ((num != null) ? new double?((double)num.GetValueOrDefault()) : null) / 2.0).Value);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x001BD8E0 File Offset: 0x001BBAE0
		public int method_33()
		{
			int result;
			if (this.nullable_0 != null && this.nullable_1 != null)
			{
				double num = (double)this.method_32();
				int? num2 = (this.nullable_1 - this.method_32()) * 1;
				result = (int)Math.Round((num + ((num2 != null) ? new double?((double)num2.GetValueOrDefault()) : null) / 3.0).Value);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x001BD9F8 File Offset: 0x001BBBF8
		public int method_34()
		{
			int result;
			if (this.nullable_0 != null && this.nullable_1 != null)
			{
				double num = (double)this.method_32();
				int? num2 = (this.nullable_1 - this.method_32()) * 2;
				result = (int)Math.Round((num + ((num2 != null) ? new double?((double)num2.GetValueOrDefault()) : null) / 3.0).Value);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0000C944 File Offset: 0x0000AB44
		public ReadOnlyCollection<Mission> method_35()
		{
			return this.list_3.AsReadOnly();
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x001BDB10 File Offset: 0x001BBD10
		public ReadOnlyCollection<Mission> method_36(Scenario scenario_0)
		{
			ReadOnlyCollection<Mission> result;
			try
			{
				if (Information.IsNothing(this.readOnlyCollection_0))
				{
					List<Mission> list = new List<Mission>();
					list.AddRange(this.list_3);
					try
					{
						try
						{
							foreach (Group group in scenario_0.Groups)
							{
								if (group.vmethod_7(false) == this)
								{
									list.AddRange(group.vmethod_139());
								}
							}
						}
						finally
						{
							IEnumerator<Group> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 200063", ex.Message);
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
					this.readOnlyCollection_0 = list.AsReadOnly();
				}
				result = this.readOnlyCollection_0;
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 101059", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0000C951 File Offset: 0x0000AB51
		public void method_37()
		{
			this.readOnlyCollection_0 = null;
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x001BDC34 File Offset: 0x001BBE34
		public void method_38(Mission mission_0)
		{
			if (!this.list_3.Contains(mission_0))
			{
				this.list_3.Add(mission_0);
				this.method_37();
				Side.Delegate49 @delegate = Side.delegate49_0;
				if (@delegate != null)
				{
					@delegate(this);
				}
			}
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x001BDC74 File Offset: 0x001BBE74
		public void method_39(Mission mission_0)
		{
			switch (mission_0.enum88_0)
			{
			case Mission.Enum88.const_0:
				goto IL_B8;
			case Mission.Enum88.const_1:
				try
				{
					foreach (Mission mission in this.list_3)
					{
						if (mission.enum88_0 == Mission.Enum88.const_2)
						{
							Class342 @class = (Class342)mission;
							if (@class.list_5.Contains(mission_0))
							{
								@class.list_5.Remove(mission_0);
								break;
							}
						}
					}
					goto IL_B8;
				}
				finally
				{
					List<Mission>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				break;
			case Mission.Enum88.const_2:
				break;
			default:
				goto IL_B8;
			}
			Class342 class2 = (Class342)mission_0;
			for (int i = class2.list_5.Count - 1; i >= 0; i += -1)
			{
				Mission mission_ = class2.list_5[i];
				this.method_39(mission_);
			}
			IL_B8:
			if (this.list_3.Remove(mission_0))
			{
				this.method_37();
				Side.Delegate49 @delegate = Side.delegate49_0;
				if (@delegate != null)
				{
					@delegate(this);
				}
			}
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x001BDD70 File Offset: 0x001BBF70
		public void method_40(Scenario scenario_0)
		{
			List<Mission> list = new List<Mission>();
			try
			{
				foreach (Mission mission in this.method_35())
				{
					if (mission.bool_11)
					{
						list.Add(mission);
					}
				}
			}
			finally
			{
				IEnumerator<Mission> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				foreach (Mission mission2 in list)
				{
					List<ActiveUnit> list2 = mission2.method_15(scenario_0);
					try
					{
						foreach (ActiveUnit activeUnit in list2)
						{
							Mission value = null;
							bool setMissionOnly = false;
							Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
							activeUnit.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					this.method_39(mission2);
				}
			}
			finally
			{
				List<Mission>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x001BDE58 File Offset: 0x001BC058
		public List<ActiveUnit> method_41(bool bool_15)
		{
			List<ActiveUnit> result;
			try
			{
				if (this.list_5 == null || bool_15)
				{
					List<ActiveUnit> list = new List<ActiveUnit>();
					foreach (ActiveUnit activeUnit in this.activeUnit_0)
					{
						if (!activeUnit.bool_1 && activeUnit.vmethod_127() && activeUnit.vmethod_88().method_12())
						{
							list.Add(activeUnit);
						}
					}
					this.list_5 = list;
				}
				result = this.list_5;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101060", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = this.list_5;
			}
			return result;
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0000C95A File Offset: 0x0000AB5A
		public Class285 method_42()
		{
			if (this.class285_0 == null)
			{
				this.class285_0 = Class285.smethod_2();
			}
			return this.class285_0;
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x0000C975 File Offset: 0x0000AB75
		public void method_43(Class285 class285_1)
		{
			this.class285_0 = class285_1;
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x001BDF18 File Offset: 0x001BC118
		public List<Contact> method_44()
		{
			if (this.list_9 == null)
			{
				object obj = this.object_0;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				lock (obj)
				{
					this.list_9 = new List<Contact>(this.method_11().Values);
				}
			}
			return this.list_9;
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0000C97E File Offset: 0x0000AB7E
		public void method_45(List<Contact> list_11)
		{
			this.list_9 = list_11;
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x001BDF7C File Offset: 0x001BC17C
		public List<Contact> method_46()
		{
			List<Contact> result;
			if (Information.IsNothing(this.list_10))
			{
				this.list_10 = new List<Contact>();
				this.list_10.AddRange(this.method_12().Values);
				result = this.list_10;
			}
			else
			{
				if (this.list_10.Count != this.method_12().Count)
				{
					this.list_10 = new List<Contact>();
					this.list_10.AddRange(this.method_12().Values);
				}
				result = this.list_10;
			}
			return result;
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x0000C987 File Offset: 0x0000AB87
		public void method_47(List<Contact> list_11)
		{
			this.list_10 = list_11;
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x0000C990 File Offset: 0x0000AB90
		public ActiveUnit[] method_48(Scenario scenario_0)
		{
			return Enumerable.ToArray<ActiveUnit>(Enumerable.Where<ActiveUnit>(this.method_49(scenario_0), (Side._Closure$__.$I170-0 == null) ? (Side._Closure$__.$I170-0 = new Func<ActiveUnit, bool>(Side._Closure$__.$I.method_0)) : Side._Closure$__.$I170-0));
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x001BE004 File Offset: 0x001BC204
		public ActiveUnit[] method_49(Scenario scenario_0)
		{
			ActiveUnit[] result;
			try
			{
				if (Information.IsNothing(this.activeUnit_1))
				{
					HashSet<ActiveUnit> hashSet = new HashSet<ActiveUnit>();
					try
					{
						foreach (ActiveUnit activeUnit in scenario_0.vmethod_0().Values)
						{
							if (!Information.IsNothing(activeUnit) && ((!activeUnit.bool_2 && activeUnit.vmethod_7(false) == this) || this.method_68(activeUnit.vmethod_7(false)) == Misc.PostureStance.Friendly))
							{
								hashSet.Add(activeUnit);
							}
						}
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					this.activeUnit_1 = Enumerable.ToArray<ActiveUnit>(hashSet);
				}
				result = this.activeUnit_1;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101061", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = this.activeUnit_1;
			}
			return result;
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x0000C9C7 File Offset: 0x0000ABC7
		public void method_50(Scenario scenario_0, ActiveUnit[] activeUnit_3)
		{
			this.activeUnit_1 = activeUnit_3;
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x0000C9D0 File Offset: 0x0000ABD0
		public string method_51()
		{
			return this.string_2;
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		public void method_52(string string_4)
		{
			this.string_2 = string_4;
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x0000C9E1 File Offset: 0x0000ABE1
		public bool method_53()
		{
			return this.bool_12;
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x0000C9E9 File Offset: 0x0000ABE9
		public void method_54(bool bool_15)
		{
			this.bool_12 = bool_15;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x001BE0F8 File Offset: 0x001BC2F8
		public List<LoggedMessage> method_55(Scenario scenario_0)
		{
			int count = scenario_0.MessageLog.Count;
			List<LoggedMessage> list = new List<LoggedMessage>(count);
			List<LoggedMessage> result;
			try
			{
				int num = count - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						LoggedMessage loggedMessage = scenario_0.MessageLog[i];
						if (loggedMessage != null && (loggedMessage.side_0 == null || loggedMessage.side_0 == this))
						{
							list.Add(loggedMessage);
						}
					}
					catch (Exception ex)
					{
					}
				}
				result = list;
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 200065", ex2.Message);
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x0000C9F2 File Offset: 0x0000ABF2
		public ReadOnlyCollection<Unit> method_56()
		{
			return this.list_2.AsReadOnly();
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x001BE1C8 File Offset: 0x001BC3C8
		public Side(string string_4, ref Scenario scenario_0)
		{
			this.dictionary_0 = new Dictionary<Side, Misc.PostureStance>();
			this.dictionary_1 = new Dictionary<string, Misc.PostureStance>();
			this.list_2 = new List<Unit>();
			this.list_3 = new List<Mission>();
			this.list_4 = new List<Class314>();
			this.dictionary_2 = new Dictionary<string, SpecialAction>();
			this.float_0 = 0f;
			this.vmethod_9(new ObservableDictionary<string, Contact>());
			this.vmethod_11(new ObservableDictionary<string, Contact>());
			this.hashSet_0 = new HashSet<string>();
			this.lazy_0 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.lazy_1 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.lazy_2 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.lazy_3 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.activeUnit_0 = new ActiveUnit[0];
			this.vmethod_13(new ObservableList<ReferencePoint>());
			List<ActiveUnit> list = null;
			this.doctrine_0 = new Doctrine(this, ref list);
			this.class366_0 = new Side.Class366();
			this.list_6 = new List<ExclusionZone>();
			this.list_7 = new List<NoNavZone>();
			this.bool_13 = true;
			this.bool_14 = false;
			this.dictionary_3 = new Dictionary<byte, QuickJumpSlot>();
			this.class316_0 = new Class316[0];
			this.list_8 = new List<string>();
			this.dictionary_4 = new Dictionary<string, Misc.PostureStance>();
			this.dictionary_5 = new Dictionary<string, int>();
			this.dictionary_6 = new Dictionary<Contact, List<Class316>>();
			this.activeUnit_1 = new ActiveUnit[0];
			this.activeUnit_2 = new ActiveUnit[0];
			this.hashSet_1 = new HashSet<string>();
			this.hashSet_2 = new HashSet<string>();
			this.queue_0 = new Queue<Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime>>();
			this.object_0 = RuntimeHelpers.GetObjectValue(new object());
			this.method_52(string_4);
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x001BE360 File Offset: 0x001BC560
		public void method_57(ActiveUnit activeUnit_3, Contact contact_0, WeaponRec weaponRec_0)
		{
			if (!Information.IsNothing(contact_0))
			{
				try
				{
					if (contact_0.contactType_0 != Contact_Base.ContactType.Aimpoint)
					{
						if (contact_0.contactType_0 != Contact_Base.ContactType.ActivationPoint)
						{
							if (!weaponRec_0.method_12(activeUnit_3.scenario_0).method_208())
							{
								if (contact_0.activeUnit_0.vmethod_7(false) == this || contact_0.activeUnit_0.vmethod_7(false).method_68(this) == Misc.PostureStance.Friendly)
								{
									try
									{
										foreach (Contact contact in this.method_11().Values)
										{
											if (!contact.method_124(activeUnit_3.scenario_0) && contact.activeUnit_0 == activeUnit_3)
											{
												if (contact.method_130(this) != Misc.PostureStance.Hostile && !contact.activeUnit_0.bool_2)
												{
													bool flag = false;
													string str = "";
													if (!Information.IsNothing(contact.nullable_16))
													{
														float? num = contact.nullable_16;
														if (((num != null) ? new bool?(num.GetValueOrDefault() < 30f) : null).GetValueOrDefault())
														{
															flag = true;
															str = " (Reason: Weapon launch was spotted visually)";
														}
													}
													if (!flag && !Information.IsNothing(contact.nullable_17))
													{
														float? num = contact.nullable_17;
														if (((num != null) ? new bool?(num.GetValueOrDefault() < 30f) : null).GetValueOrDefault())
														{
															flag = true;
															str = " (Reason: Weapon launch was spotted via infrared)";
														}
													}
													if (!flag && !Information.IsNothing(contact.nullable_19))
													{
														float? num = contact.nullable_19;
														if (((num != null) ? new bool?(num.GetValueOrDefault() < 30f) : null).GetValueOrDefault())
														{
															flag = true;
															str = " (Reason: Weapon launch was detected by passive sonar)";
														}
													}
													if (flag)
													{
														contact.method_131(this, false, Misc.PostureStance.Hostile);
														activeUnit_3.scenario_0.method_59("Contact: " + contact.Name + " was observed attacking a friendly unit and is now considered as hostile!" + str, contact.Name + " is HOSTILE!", LoggedMessage.MessageType.ContactChange, 0, null, this, new Geopoint_Struct(contact.vmethod_28(null), contact.vmethod_30(null)));
													}
												}
												break;
											}
										}
									}
									finally
									{
										IEnumerator<Contact> enumerator;
										if (enumerator != null)
										{
											enumerator.Dispose();
										}
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101062", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x001BE620 File Offset: 0x001BC820
		public void method_58(ActiveUnit activeUnit_3)
		{
			Side.Class368 @class = new Side.Class368(@class);
			@class.activeUnit_0 = activeUnit_3;
			try
			{
				IEnumerable<Contact> enumerable = Enumerable.Where<Contact>(this.method_11().Values, new Func<Contact, bool>(@class.method_0));
				new List<Contact>();
				try
				{
					foreach (Contact contact_ in enumerable)
					{
						this.method_15(contact_, ref @class.activeUnit_0.scenario_0, true);
					}
				}
				finally
				{
					IEnumerator<Contact> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101063", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x001BE6EC File Offset: 0x001BC8EC
		public void method_59(Contact contact_0, Contact contact_1, ActiveUnit activeUnit_3, Scenario scenario_0, bool bool_15)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			if (contact_0.method_57() > contact_1.method_57())
			{
				if (!contact_0.activeUnit_0.method_92(this))
				{
					if (contact_1.bool_17 && !contact_0.bool_17)
					{
						contact_0.bool_17 = true;
						flag = true;
					}
					if (contact_1.bool_18 && !contact_0.bool_18)
					{
						contact_0.bool_18 = true;
						flag = true;
					}
					if (contact_1.bool_19 && !contact_0.bool_19)
					{
						contact_0.bool_19 = true;
						flag = true;
					}
					if (contact_0.vmethod_28(null) != contact_1.vmethod_28(null))
					{
						contact_0.vmethod_29(null, contact_1.vmethod_28(null));
						flag = true;
					}
					if (contact_0.vmethod_30(null) != contact_1.vmethod_30(null))
					{
						contact_0.vmethod_31(null, contact_1.vmethod_30(null));
						flag = true;
					}
					if (contact_0.vmethod_14(false) != contact_1.vmethod_14(false))
					{
						contact_0.vmethod_15(false, contact_1.vmethod_14(false));
						flag = true;
					}
					if (bool_15 && (contact_0.method_112() != null || contact_1.method_112() != null))
					{
						if (contact_0.method_112() != null && contact_1.method_112() != null)
						{
							contact_0.method_113(ActiveUnit_Sensory.smethod_9(contact_0.method_112(), contact_1.method_112()));
							flag = true;
						}
						else if ((contact_0.method_112() != null || contact_1.method_112() == null) && contact_0.method_112() != null && contact_1.method_112() == null)
						{
							contact_0.method_113(null);
							flag = true;
						}
					}
					contact_0.method_58(contact_1.method_57());
					contact_0.float_16 = contact_1.float_16;
				}
				if ((!contact_0.bool_12 || !contact_1.bool_12) && (!contact_0.bool_12 || contact_1.bool_12) && !contact_0.bool_12 && contact_1.bool_12)
				{
					contact_0.bool_12 = true;
					flag2 = true;
				}
				ActiveUnit_Sensory.smethod_4(contact_0, contact_1.method_68());
				if (contact_0.list_7 != null && contact_1.list_7 != null)
				{
					contact_0.list_7 = Enumerable.ToList<int>(Enumerable.Union<int>(contact_0.list_7, contact_1.list_7));
					flag3 = true;
				}
				if (!contact_0.activeUnit_0.method_92(this))
				{
					if (contact_0.nullable_14 != null)
					{
						if (contact_1.nullable_14 != null)
						{
							contact_0.nullable_14 = new float?(Math.Min(contact_0.nullable_14.Value, contact_1.nullable_14.Value));
						}
					}
					else if (contact_1.nullable_14 != null)
					{
						contact_0.nullable_14 = new float?(contact_1.nullable_14.Value);
					}
					if (contact_0.nullable_15 != null)
					{
						if (contact_1.nullable_15 != null)
						{
							contact_0.nullable_15 = new float?(Math.Min(contact_0.nullable_15.Value, contact_1.nullable_15.Value));
						}
					}
					else if (contact_1.nullable_15 != null)
					{
						contact_0.nullable_15 = new float?(contact_1.nullable_15.Value);
					}
					if (contact_0.nullable_16 != null)
					{
						if (contact_1.nullable_16 != null)
						{
							contact_0.nullable_16 = new float?(Math.Min(contact_0.nullable_16.Value, contact_1.nullable_16.Value));
						}
					}
					else if (contact_1.nullable_16 != null)
					{
						contact_0.nullable_16 = new float?(contact_1.nullable_16.Value);
					}
					if (contact_0.nullable_17 != null)
					{
						if (contact_1.nullable_17 != null)
						{
							contact_0.nullable_17 = new float?(Math.Min(contact_0.nullable_17.Value, contact_1.nullable_17.Value));
						}
					}
					else if (contact_1.nullable_17 != null)
					{
						contact_0.nullable_17 = new float?(contact_1.nullable_17.Value);
					}
					if (contact_0.nullable_18 != null)
					{
						if (contact_1.nullable_18 != null)
						{
							contact_0.nullable_18 = new float?(Math.Min(contact_0.nullable_18.Value, contact_1.nullable_18.Value));
						}
					}
					else if (contact_1.nullable_18 != null)
					{
						contact_0.nullable_18 = new float?(contact_1.nullable_18.Value);
					}
					if (contact_0.nullable_19 != null)
					{
						if (contact_1.nullable_19 != null)
						{
							contact_0.nullable_19 = new float?(Math.Min(contact_0.nullable_19.Value, contact_1.nullable_19.Value));
						}
					}
					else if (contact_1.nullable_19 != null)
					{
						contact_0.nullable_19 = new float?(contact_1.nullable_19.Value);
					}
				}
			}
			if (contact_0.method_59() > contact_1.method_59())
			{
				if (contact_1.method_74(this) != null)
				{
					contact_0.method_75(this, contact_1.method_74(this));
				}
				if (contact_1.method_76(this) != null)
				{
					contact_0.method_77(this, contact_1.method_76(this));
				}
				if (contact_1.method_78(this) != null)
				{
					contact_0.method_79(this, contact_1.method_78(this));
				}
				flag4 = true;
			}
			if (contact_0.float_11 > contact_1.float_11)
			{
				try
				{
					foreach (Contact.Class269 @class in contact_1.method_73(this))
					{
						bool flag7 = false;
						try
						{
							foreach (Contact.Class269 class2 in contact_0.method_73(this))
							{
								if (Operators.CompareString(class2.string_0, @class.string_0, false) == 0)
								{
									flag7 = true;
									if (class2.identificationStatus_0 > @class.identificationStatus_0)
									{
										@class = class2;
									}
								}
							}
						}
						finally
						{
							List<Contact.Class269>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						if (!flag7)
						{
							Contact.Class269 class3 = new Contact.Class269();
							class3.string_0 = @class.string_0;
							class3.identificationStatus_0 = @class.identificationStatus_0;
							class3.float_0 = @class.float_0;
							contact_0.method_73(this).Add(class3);
						}
					}
				}
				finally
				{
					List<Contact.Class269>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				flag5 = true;
			}
			if (contact_1.method_125() > contact_0.method_125())
			{
				contact_0.method_126(scenario_0, this, null, null, false, true, false, true, contact_1.method_125());
				scenario_0.method_59("Contact: " + contact_0.Name + " is now known as: " + contact_1.Name, contact_0.Name + " renamed", LoggedMessage.MessageType.ContactChange, 0, null, this, new Geopoint_Struct(contact_0.vmethod_28(null), contact_0.vmethod_30(null)));
				contact_0.Name = contact_1.Name;
				flag6 = true;
			}
			if ((flag || flag2 || flag3 || flag4 || flag5 || flag6) && activeUnit_3 != null)
			{
				string text = string.Concat(new string[]
				{
					"Updating data for contact: ",
					contact_0.Name,
					", based on new information by: ",
					activeUnit_3.Name,
					". Updated info includes: "
				});
				List<string> list = new List<string>();
				if (flag)
				{
					list.Add("position data");
				}
				if (flag2)
				{
					list.Add("side info");
				}
				if (flag3)
				{
					list.Add("ESM data");
				}
				if (flag4)
				{
					list.Add("BDA data");
				}
				if (flag5)
				{
					list.Add("info on hosted units");
				}
				if (flag6)
				{
					list.Add("ID status");
				}
				text = text + string.Join(", ", list) + ".";
				activeUnit_3.method_124(text, "Contact updated", LoggedMessage.MessageType.ContactChange, 0, false, new Geopoint_Struct(activeUnit_3.vmethod_28(null), activeUnit_3.vmethod_30(null)));
			}
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x001BEE9C File Offset: 0x001BD09C
		public void method_60(Unit unit_0)
		{
			if (!this.list_2.Contains(unit_0))
			{
				this.list_2.Add(unit_0);
			}
			Side.Delegate47 @delegate = this.delegate47_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x001BEED4 File Offset: 0x001BD0D4
		public void method_61(Unit unit_0)
		{
			this.list_2.Remove(unit_0);
			Side.Delegate47 @delegate = this.delegate47_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x001BEF00 File Offset: 0x001BD100
		public void method_62()
		{
			this.list_2.Clear();
			Side.Delegate47 @delegate = this.delegate47_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x001BEF28 File Offset: 0x001BD128
		public void method_63(ActiveUnit activeUnit_3, bool bool_15)
		{
			if (activeUnit_3.vmethod_7(false) != this)
			{
				List<Contact> list = new List<Contact>();
				List<Contact> list2 = new List<Contact>();
				try
				{
					try
					{
						foreach (Contact contact in this.method_11().Values)
						{
							if (contact.activeUnit_0 == activeUnit_3)
							{
								list.Add(contact);
							}
						}
					}
					finally
					{
						IEnumerator<Contact> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					try
					{
						foreach (Contact contact2 in list)
						{
							this.method_15(contact2, ref activeUnit_3.scenario_0, !bool_15);
							if (this.method_56().Contains(contact2))
							{
								this.method_61(contact2);
							}
						}
					}
					finally
					{
						List<Contact>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					try
					{
						foreach (Contact contact3 in this.method_12().Values)
						{
							if (contact3.activeUnit_0 == activeUnit_3)
							{
								list2.Add(contact3);
							}
						}
					}
					finally
					{
						IEnumerator<Contact> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
					try
					{
						foreach (Contact contact4 in list2)
						{
							this.method_17(contact4, ref activeUnit_3.scenario_0, !bool_15);
							if (this.method_56().Contains(contact4))
							{
								this.method_61(contact4);
							}
						}
					}
					finally
					{
						List<Contact>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
					float num = 0f;
					ActiveUnit activeUnit = activeUnit_3;
					Side side = this;
					Class514.smethod_66(num, ref activeUnit.scenario_0, ref side, ref activeUnit_3);
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101064", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x001BF14C File Offset: 0x001BD34C
		public void method_64(Scenario scenario_0, Contact contact_0)
		{
			if (this.activeUnit_0.Length > 0)
			{
				HashSet<string> hashSet = GameGeneral.dictionary_0[this.string_0];
				foreach (Side side in scenario_0.method_44())
				{
					if (side != this && hashSet.Contains(side.string_0) && !Information.IsNothing(contact_0.activeUnit_0))
					{
						Contact contact = null;
						if (!side.method_11().TryGetValue(contact_0.activeUnit_0.string_0, ref contact))
						{
							if (!contact_0.activeUnit_0.vmethod_7(false).method_67(side) && contact_0.activeUnit_0.vmethod_7(false) != side && side.activeUnit_0.Length > 0)
							{
								side.method_13(contact_0);
							}
						}
						else
						{
							Contact.smethod_5(contact_0, contact);
							bool flag = side.method_68(this) == Misc.PostureStance.Friendly;
							if (contact_0 != contact)
							{
								side.method_59(contact, contact_0, null, scenario_0, false);
								if (flag)
								{
									this.method_59(contact_0, contact, null, scenario_0, true);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x001BF248 File Offset: 0x001BD448
		public void method_65(Scenario scenario_0)
		{
			try
			{
				List<Contact> list = new List<Contact>();
				try
				{
					foreach (Contact contact in this.method_11().Values)
					{
						if (contact.method_132())
						{
							list.Add(contact);
						}
					}
				}
				finally
				{
					IEnumerator<Contact> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				try
				{
					foreach (Contact contact_ in list)
					{
						this.method_15(contact_, ref scenario_0, this == scenario_0.method_54());
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 300011", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x001BF33C File Offset: 0x001BD53C
		public bool method_66(ActiveUnit activeUnit_3)
		{
			Side.Class369 @class = new Side.Class369();
			@class.activeUnit_0 = activeUnit_3;
			return Enumerable.Count<Contact>(Enumerable.Where<Contact>(this.method_11().Values, new Func<Contact, bool>(@class.method_0))) > 0;
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x001BF37C File Offset: 0x001BD57C
		public bool method_67(Side side_0)
		{
			bool? flag = new bool?(this.method_68(side_0) == Misc.PostureStance.Friendly && side_0.method_68(this) == Misc.PostureStance.Friendly);
			return !Information.IsNothing(flag) && flag.Value;
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x001BF3C4 File Offset: 0x001BD5C4
		public Misc.PostureStance method_68(Side side_0)
		{
			Misc.PostureStance result;
			Misc.PostureStance postureStance;
			if (Information.IsNothing(side_0))
			{
				result = Misc.PostureStance.Unknown;
			}
			else if (side_0 == this)
			{
				result = Misc.PostureStance.Friendly;
			}
			else if (this.dictionary_0.TryGetValue(side_0, out postureStance))
			{
				result = postureStance;
			}
			else
			{
				result = Misc.PostureStance.Neutral;
			}
			return result;
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x001BF3FC File Offset: 0x001BD5FC
		public void method_69(Side side_0, Misc.PostureStance postureStance_0)
		{
			try
			{
				if (!Information.IsNothing(side_0))
				{
					bool? flag;
					if (this.dictionary_0.ContainsKey(side_0))
					{
						flag = new bool?(this.dictionary_0[side_0] != postureStance_0);
						if (flag.GetValueOrDefault())
						{
							this.dictionary_0[side_0] = postureStance_0;
						}
					}
					else
					{
						flag = new bool?(true);
						this.dictionary_0.Add(side_0, postureStance_0);
					}
					if (flag.GetValueOrDefault())
					{
						try
						{
							foreach (Contact contact in this.method_11().Values)
							{
								if (contact.bool_12 && !Information.IsNothing(contact.activeUnit_0) && !Information.IsNothing(contact.activeUnit_0.vmethod_7(false)) && contact.activeUnit_0.vmethod_7(false) == side_0)
								{
									contact.method_131(this, false, postureStance_0);
									contact.bool_15 = false;
								}
							}
						}
						finally
						{
							IEnumerator<Contact> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						try
						{
							foreach (Contact contact2 in this.method_12().Values)
							{
								if (contact2.bool_12 && !Information.IsNothing(contact2.activeUnit_0) && !Information.IsNothing(contact2.activeUnit_0.vmethod_7(false)) && contact2.activeUnit_0.vmethod_7(false) == side_0)
								{
									contact2.method_131(this, false, postureStance_0);
									contact2.bool_15 = false;
								}
							}
						}
						finally
						{
							IEnumerator<Contact> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
					}
					if (flag.GetValueOrDefault())
					{
						if (this.method_11().Count > 0 && !Information.IsNothing(Enumerable.ElementAtOrDefault<Contact>(this.method_11().Values, 0).activeUnit_0))
						{
							Scenario scenario_ = Enumerable.ElementAtOrDefault<Contact>(this.method_11().Values, 0).activeUnit_0.scenario_0;
							Dictionary<string, HashSet<string>> dictionary = new Dictionary<string, HashSet<string>>();
							foreach (Side side in scenario_.method_44())
							{
								HashSet<string> hashSet = new HashSet<string>();
								side.method_70(scenario_, hashSet);
								hashSet.Remove(side.string_0);
								dictionary.Add(side.string_0, hashSet);
							}
							GameGeneral.smethod_24(scenario_, dictionary);
						}
						if (!Information.IsNothing(postureStance_0) && (postureStance_0 == Misc.PostureStance.Unfriendly || postureStance_0 == Misc.PostureStance.Hostile) && this.activeUnit_0.Length > 0)
						{
							if (postureStance_0 == Misc.PostureStance.Unfriendly)
							{
								this.activeUnit_0[0].scenario_0.method_59("Side '" + side_0.method_51() + "' is now considered UNFRIENDLY", side_0.method_51() + " is now UNFRIENDLY", LoggedMessage.MessageType.ContactChange, 0, null, null, default(Geopoint_Struct));
							}
							else if (postureStance_0 == Misc.PostureStance.Hostile)
							{
								this.activeUnit_0[0].scenario_0.method_59("Side '" + side_0.method_51() + "' is now considered HOSTILE", side_0.method_51() + " is now HOSTILE", LoggedMessage.MessageType.ContactChange, 0, null, null, default(Geopoint_Struct));
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101065", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x001BF768 File Offset: 0x001BD968
		public void method_70(Scenario scenario_0, HashSet<string> hashSet_3)
		{
			checked
			{
				try
				{
					foreach (Side side in scenario_0.method_44())
					{
						if (side != this && this.method_68(side) == Misc.PostureStance.Friendly)
						{
							hashSet_3.Add(side.string_0);
						}
					}
					string[] array2 = Enumerable.ToArray<string>(hashSet_3);
					for (int j = 0; j < array2.Length; j++)
					{
						Side.Class370 @class = new Side.Class370(@class);
						@class.string_0 = array2[j];
						Misc.PostureStance postureStance = Misc.PostureStance.Neutral;
						Side side2 = Enumerable.First<Side>(scenario_0.method_44(), new Func<Side, bool>(@class.method_0));
						if (this.dictionary_0.TryGetValue(side2, out postureStance) && !Information.IsNothing(postureStance) && postureStance != Misc.PostureStance.Friendly)
						{
							hashSet_3.Remove(side2.string_0);
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101066", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x001BF874 File Offset: 0x001BDA74
		private void method_71(object sender, NotifyDictionaryChangedEventArgs<string, Contact> e)
		{
			this.method_45(null);
			switch (e.Action)
			{
			case 0:
			{
				Side.Delegate50 @delegate = Side.delegate50_0;
				if (@delegate != null)
				{
					@delegate(this.string_0, e.NewItem.Value.activeUnit_0.string_0);
					return;
				}
				break;
			}
			case 1:
			{
				Side.Delegate51 delegate2 = Side.delegate51_0;
				if (delegate2 != null)
				{
					delegate2(this.string_0, e.OldItem.Value.activeUnit_0.string_0);
					return;
				}
				break;
			}
			case 2:
			case 3:
				break;
			case 4:
				try
				{
					foreach (KeyValuePair<string, Contact> keyValuePair in e.OldItems)
					{
						Side.Delegate51 delegate3 = Side.delegate51_0;
						if (delegate3 != null)
						{
							delegate3(this.string_0, keyValuePair.Value.activeUnit_0.string_0);
						}
					}
				}
				finally
				{
					IEnumerator<KeyValuePair<string, Contact>> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x001BF974 File Offset: 0x001BDB74
		private void method_72(object sender, NotifyDictionaryChangedEventArgs<string, Contact> e)
		{
			this.method_47(null);
			switch (e.Action)
			{
			case 0:
			{
				Side.Delegate52 @delegate = Side.delegate52_0;
				if (@delegate != null)
				{
					@delegate(this.string_0, e.NewItem.Value.activeUnit_0.string_0);
					return;
				}
				break;
			}
			case 1:
			{
				Side.Delegate53 delegate2 = Side.delegate53_0;
				if (delegate2 != null)
				{
					delegate2(this.string_0, e.OldItem.Value.activeUnit_0.string_0);
					return;
				}
				break;
			}
			case 2:
			case 3:
				break;
			case 4:
				try
				{
					foreach (KeyValuePair<string, Contact> keyValuePair in e.OldItems)
					{
						Side.Delegate53 delegate3 = Side.delegate53_0;
						if (delegate3 != null)
						{
							delegate3(this.string_0, keyValuePair.Value.activeUnit_0.string_0);
						}
					}
				}
				finally
				{
					IEnumerator<KeyValuePair<string, Contact>> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x001BFA74 File Offset: 0x001BDC74
		public List<Class316> method_73(Contact contact_0)
		{
			List<Class316> result;
			try
			{
				List<Class316> list;
				if (this.dictionary_6.TryGetValue(contact_0, out list))
				{
					result = list;
				}
				else
				{
					result = new List<Class316>();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200549", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Class316>();
			}
			return result;
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x001BFAEC File Offset: 0x001BDCEC
		public List<Weapon> method_74(ref ActiveUnit activeUnit_3, ref Contact contact_0)
		{
			List<Weapon> list = new List<Weapon>();
			List<Weapon> result;
			try
			{
				for (int i = activeUnit_3.vmethod_7(false).class316_0.Length - 1; i >= 0; i += -1)
				{
					Class316 @class = activeUnit_3.vmethod_7(false).class316_0[i];
					checked
					{
						if (contact_0 == @class.contact_0)
						{
							Class316.Class273[] class273_ = @class.class273_0;
							for (int j = 0; j < class273_.Length; j++)
							{
								if (Operators.CompareString(class273_[j].string_0, activeUnit_3.string_0, false) == 0)
								{
									list.Add(@class.method_11(activeUnit_3.scenario_0));
								}
							}
						}
					}
				}
				result = list;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200550", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Weapon>();
			}
			return result;
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x001BFBD4 File Offset: 0x001BDDD4
		public int method_75(ref ActiveUnit activeUnit_3, ref Contact contact_0)
		{
			int num = activeUnit_3.vmethod_7(false).class316_0.Length;
			int result;
			try
			{
				int i = num - 1;
				int num2;
				while (i >= 0)
				{
					Class316 @class;
					try
					{
						if (activeUnit_3.vmethod_7(false).class316_0.Length == 0)
						{
							goto IL_19E;
						}
						if (activeUnit_3.vmethod_7(false).class316_0.Length - 1 < i)
						{
							i = activeUnit_3.vmethod_7(false).class316_0.Length - 1;
						}
						@class = activeUnit_3.vmethod_7(false).class316_0[i];
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 200651", ex.Message);
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						goto IL_19E;
					}
					goto IL_AC;
					IL_19E:
					i += -1;
					continue;
					IL_AC:
					if (!Information.IsNothing(@class) && contact_0 == @class.contact_0)
					{
						int j = @class.class273_0.Length - 1;
						while (j >= 0)
						{
							Class316.Class273 class2;
							try
							{
								if (@class.class273_0.Length == 0)
								{
									goto IL_1A9;
								}
								if (@class.class273_0.Length - 1 < j)
								{
									j = @class.class273_0.Length - 1;
								}
								class2 = @class.class273_0[j];
							}
							catch (Exception ex2)
							{
								ex2.Data.Add("Error at 200467", ex2.Message);
								GameGeneral.smethod_25(ref ex2);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								goto IL_1A9;
							}
							goto IL_149;
							IL_1A9:
							j += -1;
							continue;
							IL_149:
							if (Information.IsNothing(class2) || Operators.CompareString(class2.string_0, activeUnit_3.string_0, false) != 0)
							{
								goto IL_1A9;
							}
							if (class2.int_0 == 2147483647)
							{
								return class2.int_0;
							}
							if (class2.int_0 - class2.int_1 > 0)
							{
								num2 += class2.int_0 - class2.int_1;
								goto IL_1A9;
							}
							goto IL_1A9;
						}
						goto IL_19E;
					}
					goto IL_19E;
				}
				result = num2;
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 200551", ex3.Message);
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x001BFE2C File Offset: 0x001BE02C
		public int method_76(ref ActiveUnit activeUnit_3, int int_4)
		{
			int result;
			try
			{
				int num;
				foreach (Class316 @class in activeUnit_3.vmethod_7(false).class316_0)
				{
					if (int_4 == @class.int_0)
					{
						foreach (Class316.Class273 class2 in @class.class273_0)
						{
							if (Operators.CompareString(class2.string_0, activeUnit_3.string_0, false) == 0)
							{
								if (class2.int_0 == 2147483647)
								{
									return class2.int_0;
								}
								if (class2.int_0 - class2.int_1 > 0)
								{
									num += class2.int_0 - class2.int_1;
								}
							}
						}
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200552", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x001BFF34 File Offset: 0x001BE134
		public int method_77(ref ActiveUnit activeUnit_3)
		{
			int result;
			try
			{
				Class316[] array = activeUnit_3.vmethod_7(false).class316_0;
				int num;
				for (int i = 0; i < array.Length; i = checked(i + 1))
				{
					foreach (Class316.Class273 @class in array[i].class273_0)
					{
						if (Operators.CompareString(@class.string_0, activeUnit_3.string_0, false) == 0)
						{
							if (@class.int_0 == 2147483647)
							{
								return @class.int_0;
							}
							if (@class.int_0 - @class.int_1 > 0)
							{
								num += @class.int_0 - @class.int_1;
							}
						}
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200553", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x001C0028 File Offset: 0x001BE228
		public List<Class316> method_78(ref ActiveUnit activeUnit_3, ref Contact contact_0)
		{
			List<Class316> list = new List<Class316>();
			checked
			{
				List<Class316> result;
				try
				{
					foreach (Class316 @class in activeUnit_3.vmethod_7(false).class316_0)
					{
						if (contact_0 == @class.contact_0)
						{
							Class316.Class273[] class273_ = @class.class273_0;
							for (int j = 0; j < class273_.Length; j++)
							{
								if (Operators.CompareString(class273_[j].string_0, activeUnit_3.string_0, false) == 0)
								{
									list.Add(@class);
								}
							}
						}
					}
					result = list;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200554", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<Class316>();
				}
				return result;
			}
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x001C00FC File Offset: 0x001BE2FC
		public List<Class316> method_79(ref ActiveUnit activeUnit_3)
		{
			List<Class316> list = new List<Class316>();
			checked
			{
				List<Class316> result;
				try
				{
					foreach (Class316 @class in activeUnit_3.vmethod_7(false).class316_0)
					{
						Class316.Class273[] class273_ = @class.class273_0;
						for (int j = 0; j < class273_.Length; j++)
						{
							if (Operators.CompareString(class273_[j].string_0, activeUnit_3.string_0, false) == 0)
							{
								list.Add(@class);
							}
						}
					}
					result = list;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200555", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<Class316>();
				}
				return result;
			}
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x001C01C4 File Offset: 0x001BE3C4
		public int? method_80(int? nullable_3, ref ActiveUnit activeUnit_3, ref Contact contact_0, ref Weapon weapon_0)
		{
			int? num = nullable_3;
			int? num2 = num;
			int? result;
			if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -2) : null).GetValueOrDefault())
			{
				nullable_3 = new int?(activeUnit_3.vmethod_89().method_12(ref contact_0));
			}
			else
			{
				num2 = num;
				if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -5) : null).GetValueOrDefault())
				{
					nullable_3 = new int?(activeUnit_3.vmethod_89().method_12(ref contact_0));
					num2 = nullable_3;
					if (!((num2 != null) ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						num2 = nullable_3;
						if (!((num2 != null) ? new bool?(num2.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							num2 = nullable_3;
							if (((num2 != null) ? new bool?(num2.GetValueOrDefault() > 2) : null).GetValueOrDefault())
							{
								nullable_3 = new int?((int)Math.Round(Math.Round((double)nullable_3.Value / 2.0, 0)));
								goto IL_385;
							}
							goto IL_385;
						}
					}
					result = new int?(1);
					return result;
				}
				num2 = num;
				if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -6) : null).GetValueOrDefault())
				{
					nullable_3 = new int?(activeUnit_3.vmethod_89().method_12(ref contact_0));
					num2 = nullable_3;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() >= 1) : null).GetValueOrDefault())
					{
						num2 = nullable_3;
						if (((num2 != null) ? new bool?(num2.GetValueOrDefault() <= 4) : null).GetValueOrDefault())
						{
							result = new int?(1);
							return result;
						}
					}
					num2 = nullable_3;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() > 4) : null).GetValueOrDefault())
					{
						nullable_3 = new int?((int)Math.Round(Math.Round((double)nullable_3.Value / 4.0, 0)));
					}
				}
				else
				{
					num2 = num;
					if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -3) : null).GetValueOrDefault())
					{
						nullable_3 = new int?(Convert.ToInt32(Math.Round(new decimal(activeUnit_3.vmethod_89().method_12(ref contact_0) * 2), 0)));
					}
					else
					{
						num2 = num;
						if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -4) : null).GetValueOrDefault())
						{
							nullable_3 = new int?(Convert.ToInt32(Math.Round(new decimal(activeUnit_3.vmethod_89().method_12(ref contact_0) * 4), 0)));
						}
						else
						{
							num2 = num;
							if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == -1) : null).GetValueOrDefault())
							{
								Doctrine doctrine = activeUnit_3.doctrine_0;
								Scenario scenario_ = activeUnit_3.scenario_0;
								Weapon theWeapon = weapon_0;
								Doctrine._WRA_WeaponTargetType selectedNodeTargetType = Doctrine.smethod_7(ref contact_0);
								bool findInheritedValuesOnly = false;
								num2 = null;
								int? num3 = null;
								nullable_3 = doctrine.method_9(scenario_, theWeapon, selectedNodeTargetType, findInheritedValuesOnly, ref num2, ref num3);
							}
						}
					}
				}
			}
			IL_385:
			result = nullable_3;
			return result;
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x001C055C File Offset: 0x001BE75C
		public Class316 method_81(Scenario scenario_0, ref Weapon weapon_0, ref Contact contact_0, int? nullable_3, int int_4, int? nullable_4, bool bool_15, ref string string_4, ref int? nullable_5, DateTime dateTime_0)
		{
			if (Information.IsNothing(nullable_5))
			{
				nullable_5 = new int?(1);
			}
			if (Information.IsNothing(nullable_3))
			{
				nullable_3 = new int?(int.MaxValue);
			}
			if (Information.IsNothing(nullable_4))
			{
				nullable_4 = new int?(int.MaxValue);
			}
			int? num = nullable_3;
			if (((num != null) ? new bool?(num.GetValueOrDefault() == 2147483647) : null).GetValueOrDefault())
			{
				nullable_4 = nullable_3;
			}
			bool theFireSimultaneouslyFromMultipleMounts = true;
			if (weapon_0.method_0() || weapon_0.bool_7 || weapon_0.method_204() || weapon_0.method_3())
			{
				theFireSimultaneouslyFromMultipleMounts = false;
			}
			Class316 @class = new Class316(ref weapon_0.DBID, nullable_3.Value, int_4, nullable_4.Value, ref contact_0, ref bool_15, string_4, nullable_5.Value, theFireSimultaneouslyFromMultipleMounts, dateTime_0, null);
			Class429.smethod_42(ref this.class316_0, @class);
			if (this.dictionary_6.ContainsKey(@class.contact_0))
			{
				this.dictionary_6[@class.contact_0].Add(@class);
			}
			else
			{
				this.dictionary_6.Add(@class.contact_0, new List<Class316>(new Class316[]
				{
					@class
				}));
			}
			return @class;
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x001C06A4 File Offset: 0x001BE8A4
		public void method_82(ref Class316 class316_1, int? nullable_3, int int_4, int? nullable_4, bool bool_15, ref string string_4)
		{
			try
			{
				if (Information.IsNothing(nullable_4))
				{
					nullable_4 = new int?(int.MaxValue);
				}
				if (Information.IsNothing(nullable_3))
				{
					nullable_3 = new int?(int.MaxValue);
				}
				int? num = nullable_3;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 2147483647) : null).GetValueOrDefault())
				{
					nullable_4 = nullable_3;
				}
				if (bool_15)
				{
					foreach (Class316.Class273 @class in class316_1.class273_0)
					{
						if (Operators.CompareString(@class.string_0, string_4, false) == 0)
						{
							@class.int_0 += nullable_3.Value;
							IL_B2:
							class316_1.int_2 += nullable_3.Value;
							class316_1.bool_12 = bool_15;
							goto IL_1AE;
						}
					}
					goto IL_B2;
				}
				int num2 = class316_1.method_8();
				int num3 = class316_1.int_2;
				if (num3 != -99)
				{
					num = nullable_4;
					int num4 = num3 - num2;
					bool? flag;
					bool? flag2;
					if (!((num != null) ? new bool?(num.GetValueOrDefault() > num4) : null).GetValueOrDefault())
					{
						flag = new bool?(false);
					}
					else
					{
						num = nullable_4;
						flag2 = ((num != null) ? new bool?(num.GetValueOrDefault() == int.MaxValue) : null);
						flag = ((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2);
					}
					flag2 = flag;
					if (flag2.GetValueOrDefault())
					{
						nullable_4 = new int?(num3 - num2);
					}
				}
				Class316.Class273 class273_2 = new Class316.Class273(string_4, nullable_4.Value, int_4);
				Class429.smethod_28(ref class316_1.class273_0, class273_2);
				IL_1AE:;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200557", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x001C08B8 File Offset: 0x001BEAB8
		public void method_83(ref Scenario scenario_0, ref ActiveUnit activeUnit_3, ref Contact contact_0, ref Class316 class316_1)
		{
			List<Class316> list = new List<Class316>();
			try
			{
				List<Class316> list2 = Enumerable.ToList<Class316>(activeUnit_3.vmethod_7(false).class316_0);
				for (int i = list2.Count - 1; i >= 0; i += -1)
				{
					Class316 @class = list2[i];
					if (!Information.IsNothing(@class) && (Information.IsNothing(contact_0) || @class.contact_0 == contact_0) && (Information.IsNothing(class316_1) || @class == class316_1))
					{
						List<Class316.Class273> list3 = new List<Class316.Class273>();
						List<Class316.Class273> list4 = Enumerable.ToList<Class316.Class273>(@class.class273_0);
						for (int j = list4.Count - 1; j >= 0; j += -1)
						{
							Class316.Class273 class2 = list4[j];
							if (!Information.IsNothing(activeUnit_3) && !Information.IsNothing(class2) && Operators.CompareString(activeUnit_3.string_0, class2.string_0, false) == 0)
							{
								if (class2.int_1 == 0)
								{
									this.method_85(ref scenario_0, null, class2.string_0, ref @class);
									list3.Add(class2);
								}
								else
								{
									class2.int_0 = class2.int_1;
								}
								IL_F7:
								try
								{
									foreach (Class316.Class273 class273_ in list3)
									{
										Class429.smethod_29(ref @class.class273_0, class273_);
										list.Add(@class);
									}
								}
								finally
								{
									List<Class316.Class273>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
								goto IL_139;
							}
						}
						goto IL_F7;
					}
					IL_139:;
				}
				for (int k = list.Count - 1; k >= 0; k += -1)
				{
					Class316 @class = list[k];
					this.method_89(ref scenario_0, @class);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200558", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x001C0AA4 File Offset: 0x001BECA4
		public void method_84(ref Scenario scenario_0, ref string string_4)
		{
			checked
			{
				try
				{
					List<Class316> list = new List<Class316>();
					Class316[] array = this.class316_0;
					int i = 0;
					IL_9A:
					while (i < array.Length)
					{
						Class316 @class = array[i];
						List<string> list2 = new List<string>();
						string[] array2 = @class.string_2;
						for (int j = 0; j < array2.Length; j++)
						{
							if (Operators.CompareString(array2[j], string_4, false) == 0)
							{
								list2.Add(string_4);
								IL_54:
								try
								{
									foreach (string string_5 in list2)
									{
										Class429.smethod_33(ref @class.string_2, string_5);
										list.Add(@class);
									}
								}
								finally
								{
									List<string>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
								i++;
								goto IL_9A;
							}
						}
						goto IL_54;
					}
					try
					{
						foreach (Class316 class316_ in list)
						{
							this.method_89(ref scenario_0, class316_);
						}
					}
					finally
					{
						List<Class316>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200559", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x001C0BF0 File Offset: 0x001BEDF0
		public void method_85(ref Scenario scenario_0, Contact contact_0, string string_4, ref Class316 class316_1)
		{
			if (contact_0 != null && contact_0.activeUnit_0 != null)
			{
				Side.Class371 @class = new Side.Class371(@class);
				for (int i = Enumerable.Count<string>(class316_1.string_2) - 1; i >= 0; i += -1)
				{
					@class.string_0 = class316_1.string_2[i];
					if (scenario_0.vmethod_20().ContainsKey(@class.string_0))
					{
						UnguidedWeapon unguidedWeapon = Enumerable.ElementAtOrDefault<UnguidedWeapon>(Enumerable.Where<UnguidedWeapon>(scenario_0.vmethod_20().Values, (@class.func_0 == null) ? (@class.func_0 = new Func<UnguidedWeapon, bool>(@class.method_0)) : @class.func_0), 0);
						if (!Information.IsNothing(unguidedWeapon) && (unguidedWeapon.method_63() == Weapon._WeaponType.IronBomb || unguidedWeapon.method_63() == Weapon._WeaponType.Rocket || unguidedWeapon.method_63() == Weapon._WeaponType.DepthCharge))
						{
							UnguidedWeapon unguidedWeapon2 = unguidedWeapon;
							ActiveUnit activeUnit = contact_0.activeUnit_0;
							Random random = GameGeneral.smethod_5();
							unguidedWeapon2.method_80(activeUnit, contact_0, ref scenario_0, ref random);
							unguidedWeapon.method_75(ref scenario_0);
						}
					}
				}
			}
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x001C0CE8 File Offset: 0x001BEEE8
		public void method_86(ref Scenario scenario_0, Contact contact_0)
		{
			try
			{
				List<Class316> list = new List<Class316>();
				for (int i = this.class316_0.Length - 1; i >= 0; i += -1)
				{
					Class316 @class = this.class316_0[i];
					if (@class.contact_0 == contact_0)
					{
						this.method_85(ref scenario_0, contact_0, null, ref @class);
						if (Enumerable.Contains<Class316>(this.class316_0, @class))
						{
							list.Add(@class);
						}
					}
				}
				for (int j = list.Count - 1; j >= 0; j += -1)
				{
					Class316 @class = list[j];
					Class429.smethod_43(ref this.class316_0, @class);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200564", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x001C0DB8 File Offset: 0x001BEFB8
		public void method_87(ref Scenario scenario_0, string string_4)
		{
			try
			{
				List<Class316> list = new List<Class316>();
				int i = this.class316_0.Length - 1;
				IL_C2:
				while (i >= 0)
				{
					Class316 @class = this.class316_0[i];
					List<Class316.Class273> list2 = new List<Class316.Class273>();
					for (int j = @class.class273_0.Length - 1; j >= 0; j += -1)
					{
						Class316.Class273 class2 = @class.class273_0[j];
						if (Operators.CompareString(class2.string_0, string_4, false) == 0)
						{
							this.method_85(ref scenario_0, null, string_4, ref @class);
							if (Enumerable.Contains<Class316.Class273>(@class.class273_0, class2))
							{
								list2.Add(class2);
							}
							IL_7D:
							try
							{
								foreach (Class316.Class273 class273_ in list2)
								{
									Class429.smethod_29(ref @class.class273_0, class273_);
									list.Add(@class);
								}
							}
							finally
							{
								List<Class316.Class273>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							i += -1;
							goto IL_C2;
						}
					}
					goto IL_7D;
				}
				for (int k = list.Count - 1; k >= 0; k += -1)
				{
					Class316 @class = list[k];
					this.method_89(ref scenario_0, @class);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200563", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x001C0F10 File Offset: 0x001BF110
		public void method_88(ref Scenario scenario_0, string string_4, ref Class316 class316_1)
		{
			try
			{
				List<Class316> list = new List<Class316>();
				for (int i = this.class316_0.Length - 1; i >= 0; i += -1)
				{
					Class316 @class = this.class316_0[i];
					if (@class == class316_1)
					{
						List<Class316.Class273> list2 = new List<Class316.Class273>();
						for (int j = @class.class273_0.Length - 1; j >= 0; j += -1)
						{
							Class316.Class273 class2 = @class.class273_0[j];
							if (Operators.CompareString(class2.string_0, string_4, false) == 0)
							{
								this.method_85(ref scenario_0, null, string_4, ref @class);
								if (Enumerable.Contains<Class316.Class273>(@class.class273_0, class2))
								{
									list2.Add(class2);
								}
								IL_85:
								try
								{
									foreach (Class316.Class273 class273_ in list2)
									{
										Class429.smethod_29(ref @class.class273_0, class273_);
										list.Add(@class);
									}
								}
								finally
								{
									List<Class316.Class273>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
								goto IL_C6;
							}
						}
						goto IL_85;
					}
					IL_C6:;
				}
				for (int k = list.Count - 1; k >= 0; k += -1)
				{
					Class316 @class = list[k];
					this.method_89(ref scenario_0, @class);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200562", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x001C1070 File Offset: 0x001BF270
		public void method_89(ref Scenario scenario_0, Class316 class316_1)
		{
			checked
			{
				if (Enumerable.Count<string>(class316_1.string_2) <= 0)
				{
					if (class316_1.method_9() >= class316_1.method_8())
					{
						Class429.smethod_43(ref this.class316_0, class316_1);
						return;
					}
					if (class316_1.class273_0.Length <= 0)
					{
						Class429.smethod_43(ref this.class316_0, class316_1);
						return;
					}
					if (Enumerable.Count<string>(class316_1.string_2) == 0 && class316_1.method_9() > 0 && (!class316_1.bool_12 || (class316_1.bool_12 && Class570.class280_0.method_44())))
					{
						if (!class316_1.bool_11)
						{
							Class316.Class273[] class273_ = class316_1.class273_0;
							for (int i = 0; i < class273_.Length; i++)
							{
								if (class273_[i].int_2 > 0)
								{
									return;
								}
							}
							if (!class316_1.bool_12 || class316_1.method_11(scenario_0).method_169() != Weapon.WeaponGuidanceType.CommandGuided_Datalinked)
							{
								Class429.smethod_43(ref this.class316_0, class316_1);
								return;
							}
						}
						else if (!class316_1.bool_12)
						{
							Class429.smethod_43(ref this.class316_0, class316_1);
						}
					}
				}
			}
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0000C9FF File Offset: 0x0000ABFF
		public int method_90()
		{
			this.int_3++;
			return this.int_3;
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x001C1158 File Offset: 0x001BF358
		private void method_91(object sender, EventArgs5<ReferencePoint> e)
		{
			try
			{
				try
				{
					foreach (ReferencePoint item in e.method_0())
					{
						try
						{
							foreach (Mission mission in this.list_3)
							{
								if (mission._MissionClass_0 == Mission._MissionClass.Patrol)
								{
									Class343 @class = (Class343)mission;
									if (@class.list_5.Contains(item))
									{
										@class.list_5.Remove(item);
									}
									if (@class.list_15.Contains(item))
									{
										@class.list_15.Remove(item);
									}
								}
							}
						}
						finally
						{
							List<Mission>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
				finally
				{
					IEnumerator<ReferencePoint> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101067", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x001C1270 File Offset: 0x001BF470
		public int method_92()
		{
			if (this.int_3 < 1000)
			{
				this.int_3 = GameGeneral.smethod_5().Next(1000, 8000);
			}
			else if (this.int_3 > 9999)
			{
				this.int_3 = 1000;
			}
			return this.int_3;
		}

		// Token: 0x040015CF RID: 5583
		private string string_2;

		// Token: 0x040015D0 RID: 5584
		private Dictionary<Side, Misc.PostureStance> dictionary_0;

		// Token: 0x040015D1 RID: 5585
		private Dictionary<string, Misc.PostureStance> dictionary_1;

		// Token: 0x040015D2 RID: 5586
		public bool bool_11;

		// Token: 0x040015D3 RID: 5587
		[CompilerGenerated]
		[AccessedThroughProperty("PotentialContacts")]
		private List<ActiveUnit> list_0;

		// Token: 0x040015D4 RID: 5588
		[CompilerGenerated]
		[AccessedThroughProperty("PotentialBaseContacts")]
		private List<ActiveUnit> list_1;

		// Token: 0x040015D5 RID: 5589
		public string string_3;

		// Token: 0x040015D6 RID: 5590
		private List<Unit> list_2;

		// Token: 0x040015D7 RID: 5591
		private GeoPoint geoPoint_0;

		// Token: 0x040015D8 RID: 5592
		public double double_0;

		// Token: 0x040015D9 RID: 5593
		private List<Mission> list_3;

		// Token: 0x040015DA RID: 5594
		private List<Class314> list_4;

		// Token: 0x040015DB RID: 5595
		private int int_0;

		// Token: 0x040015DC RID: 5596
		public int? nullable_0;

		// Token: 0x040015DD RID: 5597
		public int? nullable_1;

		// Token: 0x040015DE RID: 5598
		private Side.AwarenessLevel_Enum awarenessLevel_Enum_0;

		// Token: 0x040015DF RID: 5599
		private GlobalVariables.ProficiencyLevel? nullable_2;

		// Token: 0x040015E0 RID: 5600
		public Dictionary<string, SpecialAction> dictionary_2;

		// Token: 0x040015E1 RID: 5601
		private float float_0;

		// Token: 0x040015E2 RID: 5602
		[CompilerGenerated]
		[AccessedThroughProperty("_Contacts")]
		private ObservableDictionary<string, Contact> observableDictionary_0;

		// Token: 0x040015E3 RID: 5603
		[CompilerGenerated]
		[AccessedThroughProperty("_BaseContacts")]
		private ObservableDictionary<string, Contact> observableDictionary_1;

		// Token: 0x040015E4 RID: 5604
		public HashSet<string> hashSet_0;

		// Token: 0x040015E5 RID: 5605
		internal int int_1;

		// Token: 0x040015E6 RID: 5606
		internal int int_2;

		// Token: 0x040015E7 RID: 5607
		internal Lazy<ConcurrentDictionary<string, Contact>> lazy_0;

		// Token: 0x040015E8 RID: 5608
		internal Lazy<ConcurrentDictionary<string, Contact>> lazy_1;

		// Token: 0x040015E9 RID: 5609
		internal Lazy<ConcurrentDictionary<string, Contact>> lazy_2;

		// Token: 0x040015EA RID: 5610
		internal Lazy<ConcurrentDictionary<string, Contact>> lazy_3;

		// Token: 0x040015EB RID: 5611
		private bool bool_12;

		// Token: 0x040015EC RID: 5612
		public ActiveUnit[] activeUnit_0;

		// Token: 0x040015ED RID: 5613
		[CompilerGenerated]
		[AccessedThroughProperty("RefPoints")]
		private ObservableList<ReferencePoint> observableList_0;

		// Token: 0x040015EE RID: 5614
		private List<ActiveUnit> list_5;

		// Token: 0x040015EF RID: 5615
		public Doctrine doctrine_0;

		// Token: 0x040015F0 RID: 5616
		public Side.Class366 class366_0;

		// Token: 0x040015F1 RID: 5617
		public List<ExclusionZone> list_6;

		// Token: 0x040015F2 RID: 5618
		public List<NoNavZone> list_7;

		// Token: 0x040015F3 RID: 5619
		public bool bool_13;

		// Token: 0x040015F4 RID: 5620
		public bool bool_14;

		// Token: 0x040015F5 RID: 5621
		public Dictionary<byte, QuickJumpSlot> dictionary_3;

		// Token: 0x040015F6 RID: 5622
		internal Class316[] class316_0;

		// Token: 0x040015F7 RID: 5623
		public List<string> list_8;

		// Token: 0x040015F8 RID: 5624
		private int int_3;

		// Token: 0x040015F9 RID: 5625
		public Dictionary<string, Misc.PostureStance> dictionary_4;

		// Token: 0x040015FA RID: 5626
		internal Dictionary<string, int> dictionary_5;

		// Token: 0x040015FB RID: 5627
		private Dictionary<Contact, List<Class316>> dictionary_6;

		// Token: 0x040015FC RID: 5628
		private Class285 class285_0;

		// Token: 0x040015FD RID: 5629
		private List<Contact> list_9;

		// Token: 0x040015FE RID: 5630
		private List<Contact> list_10;

		// Token: 0x040015FF RID: 5631
		private ActiveUnit[] activeUnit_1;

		// Token: 0x04001600 RID: 5632
		private ActiveUnit[] activeUnit_2;

		// Token: 0x04001601 RID: 5633
		private HashSet<string> hashSet_1;

		// Token: 0x04001602 RID: 5634
		private HashSet<string> hashSet_2;

		// Token: 0x04001603 RID: 5635
		internal Queue<Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime>> queue_0;

		// Token: 0x04001604 RID: 5636
		[CompilerGenerated]
		private Side.Delegate47 delegate47_0;

		// Token: 0x04001605 RID: 5637
		[CompilerGenerated]
		private static Side.Delegate48 delegate48_0;

		// Token: 0x04001606 RID: 5638
		[CompilerGenerated]
		private static Side.Delegate49 delegate49_0;

		// Token: 0x04001607 RID: 5639
		[CompilerGenerated]
		private static Side.Delegate50 delegate50_0;

		// Token: 0x04001608 RID: 5640
		[CompilerGenerated]
		private static Side.Delegate51 delegate51_0;

		// Token: 0x04001609 RID: 5641
		[CompilerGenerated]
		private static Side.Delegate52 delegate52_0;

		// Token: 0x0400160A RID: 5642
		[CompilerGenerated]
		private static Side.Delegate53 delegate53_0;

		// Token: 0x0400160B RID: 5643
		private ReadOnlyCollection<Mission> readOnlyCollection_0;

		// Token: 0x0400160C RID: 5644
		private object object_0;

		// Token: 0x02000337 RID: 823
		// (Invoke) Token: 0x060018A6 RID: 6310
		internal delegate void Delegate47();

		// Token: 0x02000338 RID: 824
		// (Invoke) Token: 0x060018AA RID: 6314
		internal delegate void Delegate48(Side theSide);

		// Token: 0x02000339 RID: 825
		// (Invoke) Token: 0x060018AE RID: 6318
		internal delegate void Delegate49(Side theSide);

		// Token: 0x0200033A RID: 826
		// (Invoke) Token: 0x060018B2 RID: 6322
		internal delegate void Delegate50(string theSideID, string ContactActualUnitID);

		// Token: 0x0200033B RID: 827
		// (Invoke) Token: 0x060018B6 RID: 6326
		internal delegate void Delegate51(string theSideID, string ContactActualUnitID);

		// Token: 0x0200033C RID: 828
		// (Invoke) Token: 0x060018BA RID: 6330
		internal delegate void Delegate52(string theSideID, string ContactActualUnitID);

		// Token: 0x0200033D RID: 829
		// (Invoke) Token: 0x060018BE RID: 6334
		internal delegate void Delegate53(string theSideID, string ContactActualUnitID);

		// Token: 0x0200033E RID: 830
		internal sealed class Class366
		{
			// Token: 0x060018BF RID: 6335 RVA: 0x0000CA15 File Offset: 0x0000AC15
			public Class366()
			{
				this.dictionary_1 = new Dictionary<string, HashSet<string>>();
				this.dictionary_0 = new Dictionary<int, int>();
			}

			// Token: 0x060018C0 RID: 6336 RVA: 0x001C12C4 File Offset: 0x001BF4C4
			public void method_0(int int_0, int int_1)
			{
				if (Information.IsNothing(this.dictionary_0))
				{
					this.dictionary_0 = new Dictionary<int, int>();
				}
				if (this.dictionary_0.ContainsKey(int_0))
				{
					this.dictionary_0[int_0] = this.dictionary_0[int_0] + int_1;
					return;
				}
				this.dictionary_0.Add(int_0, int_1);
			}

			// Token: 0x060018C1 RID: 6337 RVA: 0x001C1320 File Offset: 0x001BF520
			public void method_1(Class310 class310_0, bool bool_0)
			{
				if (Information.IsNothing(this.dictionary_1))
				{
					this.dictionary_1 = new Dictionary<string, HashSet<string>>();
				}
				string key;
				if (class310_0.bool_3)
				{
					key = "Aircraft_" + Conversions.ToString(((Aircraft)class310_0).DBID);
				}
				else if (class310_0.bool_6)
				{
					key = "Ship_" + Conversions.ToString(((Ship)class310_0).DBID);
				}
				else if (class310_0.bool_5)
				{
					key = "Submarine_" + Conversions.ToString(((Submarine)class310_0).DBID);
				}
				else if (class310_0.bool_8)
				{
					key = "Facility_" + Conversions.ToString(((Facility)class310_0).DBID);
				}
				else if (bool_0)
				{
					key = "FacilityAimpoint_" + Conversions.ToString(((Mount)class310_0).DBID);
				}
				else if (class310_0.method_1())
				{
					key = "Satellite_" + Conversions.ToString(((Satellite)class310_0).DBID);
				}
				else if (class310_0 is Cargo)
				{
					Cargo cargo = (Cargo)class310_0;
					if (cargo.method_23() == Cargo.Enum111.const_1)
					{
						Mount mount = (Mount)cargo.method_25();
						key = "FacilityAimpoint_" + Conversions.ToString(mount.DBID);
					}
					else if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				else if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				if (this.dictionary_1.ContainsKey(key))
				{
					this.dictionary_1[key].Add(class310_0.string_0);
					return;
				}
				HashSet<string> hashSet = new HashSet<string>();
				hashSet.Add(class310_0.string_0);
				this.dictionary_1.Add(key, hashSet);
			}

			// Token: 0x060018C2 RID: 6338 RVA: 0x001C14C8 File Offset: 0x001BF6C8
			public void method_2(ref XmlWriter xmlWriter_0)
			{
				try
				{
					xmlWriter_0.WriteStartElement("AAR");
					if (Information.IsNothing(this.dictionary_1))
					{
						this.dictionary_1 = new Dictionary<string, HashSet<string>>();
					}
					xmlWriter_0.WriteStartElement("Losses");
					try
					{
						foreach (KeyValuePair<string, HashSet<string>> keyValuePair in this.dictionary_1)
						{
							xmlWriter_0.WriteElementString(keyValuePair.Key.ToString(), string.Join("_", keyValuePair.Value));
						}
					}
					finally
					{
						Dictionary<string, HashSet<string>>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					xmlWriter_0.WriteEndElement();
					if (Information.IsNothing(this.dictionary_0))
					{
						this.dictionary_0 = new Dictionary<int, int>();
					}
					xmlWriter_0.WriteStartElement("Expenditures");
					try
					{
						foreach (KeyValuePair<int, int> keyValuePair2 in this.dictionary_0)
						{
							xmlWriter_0.WriteElementString("Weapon_" + keyValuePair2.Key.ToString(), keyValuePair2.Value.ToString());
						}
					}
					finally
					{
						Dictionary<int, int>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteEndElement();
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101068", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}

			// Token: 0x060018C3 RID: 6339 RVA: 0x001C1678 File Offset: 0x001BF878
			public static Side.Class366 smethod_0(ref XmlNode xmlNode_0)
			{
				Side.Class366 @class = new Side.Class366();
				Side.Class366 result;
				try
				{
					try
					{
						foreach (object obj in xmlNode_0.ChildNodes)
						{
							XmlNode xmlNode = (XmlNode)obj;
							string name = xmlNode.Name;
							if (Operators.CompareString(name, "Losses", false) != 0)
							{
								if (Operators.CompareString(name, "Expenditures", false) != 0)
								{
									continue;
								}
								try
								{
									foreach (object obj2 in xmlNode.ChildNodes)
									{
										XmlNode xmlNode2 = (XmlNode)obj2;
										string[] array = xmlNode2.Name.Split(new char[]
										{
											'_'
										});
										@class.dictionary_0.Add(Conversions.ToInteger(array[1]), Conversions.ToInteger(xmlNode2.InnerText));
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
									if (Versioned.IsNumeric(xmlNode3.InnerText))
									{
										int num = Conversions.ToInteger(xmlNode3.InnerText);
										HashSet<string> hashSet = new HashSet<string>();
										int num2 = num;
										for (int i = 1; i <= num2; i++)
										{
											hashSet.Add(Guid.NewGuid().ToString());
										}
										@class.dictionary_1.Add(xmlNode3.Name, hashSet);
									}
									else
									{
										List<string> list = Enumerable.ToList<string>(xmlNode3.InnerText.Split(new char[]
										{
											'_'
										}));
										int count = list.Count;
										HashSet<string> hashSet2 = new HashSet<string>();
										int num3 = count - 1;
										for (int j = 0; j <= num3; j++)
										{
											hashSet2.Add(list[j]);
										}
										@class.dictionary_1.Add(xmlNode3.Name, hashSet2);
									}
								}
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
					ex.Data.Add("Error at 101069", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new Side.Class366();
				}
				return result;
			}

			// Token: 0x0400160D RID: 5645
			public Dictionary<int, int> dictionary_0;

			// Token: 0x0400160E RID: 5646
			public Dictionary<string, HashSet<string>> dictionary_1;
		}

		// Token: 0x0200033F RID: 831
		[Attribute0]
		public enum AwarenessLevel_Enum
		{
			// Token: 0x04001610 RID: 5648
			Blind = -1,
			// Token: 0x04001611 RID: 5649
			Normal,
			// Token: 0x04001612 RID: 5650
			AutoSideID,
			// Token: 0x04001613 RID: 5651
			AutoSideAndUnitID,
			// Token: 0x04001614 RID: 5652
			Omniscient
		}

		// Token: 0x02000340 RID: 832
		[CompilerGenerated]
		internal sealed class Class367
		{
			// Token: 0x060018C4 RID: 6340 RVA: 0x0000CA33 File Offset: 0x0000AC33
			public Class367(Side.Class367 class367_0)
			{
				if (class367_0 != null)
				{
					this.scenario_0 = class367_0.scenario_0;
				}
			}

			// Token: 0x060018C5 RID: 6341 RVA: 0x0000CA4A File Offset: 0x0000AC4A
			internal void method_0(Contact contact_0)
			{
				contact_0.bool_22 = false;
				contact_0.method_124(this.scenario_0);
				this.side_0.dictionary_4[contact_0.string_0] = contact_0.method_130(this.side_0);
			}

			// Token: 0x04001615 RID: 5653
			public Scenario scenario_0;

			// Token: 0x04001616 RID: 5654
			public Side side_0;
		}

		// Token: 0x02000342 RID: 834
		[CompilerGenerated]
		internal sealed class Class368
		{
			// Token: 0x060018C9 RID: 6345 RVA: 0x0000CA96 File Offset: 0x0000AC96
			public Class368(Side.Class368 class368_0)
			{
				if (class368_0 != null)
				{
					this.activeUnit_0 = class368_0.activeUnit_0;
				}
			}

			// Token: 0x060018CA RID: 6346 RVA: 0x0000CAAD File Offset: 0x0000ACAD
			internal bool method_0(Contact contact_0)
			{
				return contact_0.activeUnit_0 == this.activeUnit_0;
			}

			// Token: 0x04001619 RID: 5657
			public ActiveUnit activeUnit_0;
		}

		// Token: 0x02000343 RID: 835
		[CompilerGenerated]
		internal sealed class Class369
		{
			// Token: 0x060018CC RID: 6348 RVA: 0x0000CABD File Offset: 0x0000ACBD
			internal bool method_0(Contact contact_0)
			{
				return contact_0.activeUnit_0 == this.activeUnit_0;
			}

			// Token: 0x0400161A RID: 5658
			public ActiveUnit activeUnit_0;
		}

		// Token: 0x02000344 RID: 836
		[CompilerGenerated]
		internal sealed class Class370
		{
			// Token: 0x060018CD RID: 6349 RVA: 0x0000CACD File Offset: 0x0000ACCD
			public Class370(Side.Class370 class370_0)
			{
				if (class370_0 != null)
				{
					this.string_0 = class370_0.string_0;
				}
			}

			// Token: 0x060018CE RID: 6350 RVA: 0x0000CAE4 File Offset: 0x0000ACE4
			internal bool method_0(Side side_0)
			{
				return Operators.CompareString(side_0.string_0, this.string_0, false) == 0;
			}

			// Token: 0x0400161B RID: 5659
			public string string_0;
		}

		// Token: 0x02000345 RID: 837
		[CompilerGenerated]
		internal sealed class Class371
		{
			// Token: 0x060018CF RID: 6351 RVA: 0x0000CAFB File Offset: 0x0000ACFB
			public Class371(Side.Class371 class371_0)
			{
				if (class371_0 != null)
				{
					this.string_0 = class371_0.string_0;
				}
			}

			// Token: 0x060018D0 RID: 6352 RVA: 0x0000CB12 File Offset: 0x0000AD12
			internal bool method_0(UnguidedWeapon unguidedWeapon_0)
			{
				return Operators.CompareString(unguidedWeapon_0.string_0, this.string_0, false) == 0;
			}

			// Token: 0x0400161C RID: 5660
			public string string_0;

			// Token: 0x0400161D RID: 5661
			public Func<UnguidedWeapon, bool> func_0;
		}
	}
}
