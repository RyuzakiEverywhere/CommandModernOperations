using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns13;
using ns14;

namespace Command_Core.Lua
{
	// Token: 0x02000431 RID: 1073
	[Attribute1]
	[Attribute2]
	[Attribute3]
	public sealed class LuaWrapper_Event
	{
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x0023AE5C File Offset: 0x0023905C
		public object fields
		{
			get
			{
				Type type = base.GetType();
				int num = 0;
				PropertyInfo[] properties = type.GetProperties();
				MethodInfo[] methods = type.GetMethods();
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (PropertyInfo propertyInfo in properties)
				{
					if (!propertyInfo.Name.StartsWith("__") && !propertyInfo.Name.StartsWith("fields"))
					{
						string text = "";
						bool flag = false;
						if (propertyInfo.MemberType == MemberTypes.Method)
						{
							text = ":";
						}
						else if (propertyInfo.MemberType == MemberTypes.Property)
						{
							text = ".";
						}
						foreach (MethodInfo memberInfo in methods)
						{
							string right = "set_" + propertyInfo.Name;
							if (Operators.CompareString(memberInfo.Name, right, false) == 0)
							{
								flag = true;
							}
						}
						num++;
						dictionary.Add("property_" + num.ToString(), string.Concat(new string[]
						{
							text,
							propertyInfo.Name,
							" , ",
							propertyInfo.PropertyType.Name,
							" , ",
							flag.ToString()
						}));
					}
				}
				num = 0;
				foreach (MethodInfo methodInfo in methods)
				{
					if (!methodInfo.Name.StartsWith("get_") && !methodInfo.Name.StartsWith("set_") && !methodInfo.Name.StartsWith("ToString") && !methodInfo.IsHideBySig)
					{
						string str = "";
						if (methodInfo.MemberType == MemberTypes.Method)
						{
							str = ":";
						}
						else if (methodInfo.MemberType == MemberTypes.Property)
						{
							str = ".";
						}
						num++;
						dictionary.Add("method_" + num.ToString(), str + methodInfo.Name + " , " + methodInfo.ReturnType.ToString());
					}
				}
				object result;
				if (dictionary.Count == 0)
				{
					result = null;
				}
				else
				{
					LuaUtility.smethod_3(dictionary, luaTable);
					result = luaTable;
				}
				return result;
			}
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x000101B9 File Offset: 0x0000E3B9
		public LuaWrapper_Event(SimEvent a, int l, bool xml, Scenario s)
		{
			this.ev = a;
			this.ScenarioContext = s;
			this.level = l;
			this.includeXML = xml;
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x000101DE File Offset: 0x0000E3DE
		[Attribute2]
		public object __obj
		{
			get
			{
				return this.ev;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x002480F4 File Offset: 0x002462F4
		[Attribute2]
		public LuaTable details
		{
			get
			{
				LuaTable result;
				try
				{
					HashSet<string> hashSet_ = new HashSet<string>();
					LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					if (this.level == 0 || this.level == 1)
					{
						try
						{
							foreach (EventTrigger eventTrigger in this.ev.list_0)
							{
								LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
								XmlDocument xmlDocument = new XmlDocument();
								StringBuilder sb = new StringBuilder();
								StringWriter stringWriter = new StringWriter(sb);
								Class448.smethod_19(ref eventTrigger, hashSet_);
								using (XmlWriter xmlWriter = new XmlTextWriter(stringWriter))
								{
									eventTrigger.vmethod_4(xmlWriter, hashSet_, this.ScenarioContext);
									xmlWriter.Flush();
								}
								xmlDocument.LoadXml(stringWriter.ToString());
								if (this.includeXML)
								{
									luaTable3["xml"] = xmlDocument.InnerXml;
								}
								luaTable3[eventTrigger.eventTriggerType_0.ToString()] = Class448.smethod_15(ref xmlDocument);
								luaTable2[luaTable2.Keys.Count + 1] = luaTable3;
							}
						}
						finally
						{
							List<EventTrigger>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						luaTable["triggers"] = luaTable2;
					}
					luaTable2 = LuaSandBox.Singleton().CreateTable();
					if (this.level == 0 || this.level == 2)
					{
						try
						{
							foreach (EventCondition eventCondition in this.ev.list_1)
							{
								LuaTable luaTable4 = LuaSandBox.Singleton().CreateTable();
								XmlDocument xmlDocument2 = new XmlDocument();
								StringBuilder sb2 = new StringBuilder();
								StringWriter stringWriter2 = new StringWriter(sb2);
								using (XmlWriter xmlWriter2 = new XmlTextWriter(stringWriter2))
								{
									eventCondition.vmethod_5(xmlWriter2, hashSet_, this.ScenarioContext);
									xmlWriter2.Flush();
								}
								xmlDocument2.LoadXml(stringWriter2.ToString());
								if (this.includeXML)
								{
									luaTable4["xml"] = xmlDocument2.InnerXml;
								}
								luaTable4[eventCondition.eventConditionType_0.ToString()] = Class448.smethod_15(ref xmlDocument2);
								luaTable2[luaTable2.Keys.Count + 1] = luaTable4;
							}
						}
						finally
						{
							List<EventCondition>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						luaTable["conditions"] = luaTable2;
					}
					luaTable2 = LuaSandBox.Singleton().CreateTable();
					if (this.level == 0 || this.level == 3)
					{
						try
						{
							foreach (EventAction eventAction in this.ev.list_2)
							{
								LuaTable luaTable5 = LuaSandBox.Singleton().CreateTable();
								luaTable5["type"] = eventAction.eventActionType_0.ToString();
								XmlDocument xmlDocument3 = new XmlDocument();
								StringBuilder sb3 = new StringBuilder();
								StringWriter stringWriter3 = new StringWriter(sb3);
								using (XmlWriter xmlWriter3 = new XmlTextWriter(stringWriter3))
								{
									eventAction.vmethod_4(xmlWriter3, hashSet_, this.ScenarioContext);
									xmlWriter3.Flush();
								}
								xmlDocument3.LoadXml(stringWriter3.ToString());
								if (this.includeXML)
								{
									luaTable5["xml"] = xmlDocument3.InnerXml;
								}
								luaTable5[eventAction.eventActionType_0.ToString()] = Class448.smethod_15(ref xmlDocument3);
								luaTable2[luaTable2.Keys.Count + 1] = luaTable5;
							}
						}
						finally
						{
							List<EventAction>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
						luaTable["actions"] = luaTable2;
					}
					if (this.level == 0 || this.level == 4)
					{
						luaTable["name"] = this.ev.Name;
						luaTable["guid"] = this.ev.string_0;
						luaTable["description"] = this.ev.string_2;
						luaTable["isActive"] = this.ev.bool_12;
						luaTable["isShown"] = this.ev.bool_13;
						luaTable["isRepeatable"] = this.ev.bool_11;
						luaTable["probability"] = this.ev.short_0;
					}
					result = luaTable;
				}
				catch (Exception ex)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
				return result;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x000101E6 File Offset: 0x0000E3E6
		[Attribute2]
		public string guid
		{
			get
			{
				return this.ev.string_0;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600204E RID: 8270 RVA: 0x000101F3 File Offset: 0x0000E3F3
		// (set) Token: 0x0600204F RID: 8271 RVA: 0x00010200 File Offset: 0x0000E400
		[Attribute2]
		public string description
		{
			get
			{
				return this.ev.Name;
			}
			set
			{
				this.ev.Name = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x000101F3 File Offset: 0x0000E3F3
		[Attribute2]
		public string name
		{
			get
			{
				return this.ev.Name;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x0001020E File Offset: 0x0000E40E
		// (set) Token: 0x06002052 RID: 8274 RVA: 0x00248618 File Offset: 0x00246818
		[Attribute2]
		public object isActive
		{
			get
			{
				return this.ev.bool_12;
			}
			set
			{
				this.ev.bool_12 = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(value)).Value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x00010220 File Offset: 0x0000E420
		// (set) Token: 0x06002054 RID: 8276 RVA: 0x00248644 File Offset: 0x00246844
		[Attribute2]
		public object isShown
		{
			get
			{
				return this.ev.bool_13.ToString();
			}
			set
			{
				this.ev.bool_13 = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(value)).Value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x00010232 File Offset: 0x0000E432
		// (set) Token: 0x06002056 RID: 8278 RVA: 0x00248670 File Offset: 0x00246870
		[Attribute2]
		public object isRepeatable
		{
			get
			{
				return this.ev.bool_11.ToString();
			}
			set
			{
				this.ev.bool_11 = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(value)).Value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x00010244 File Offset: 0x0000E444
		// (set) Token: 0x06002058 RID: 8280 RVA: 0x0024869C File Offset: 0x0024689C
		[Attribute2]
		public string probability
		{
			get
			{
				return this.ev.short_0.ToString();
			}
			set
			{
				short num = 0;
				short.TryParse(value, out num);
				if (num >= 0 & num <= 100)
				{
					this.ev.short_0 = num;
				}
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x002486D4 File Offset: 0x002468D4
		[Attribute2]
		public LuaTable triggers
		{
			get
			{
				HashSet<string> hashSet_ = new HashSet<string>();
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				try
				{
					foreach (EventTrigger eventTrigger in this.ev.list_0)
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						XmlDocument xmlDocument = new XmlDocument();
						StringBuilder sb = new StringBuilder();
						StringWriter stringWriter = new StringWriter(sb);
						Class448.smethod_19(ref eventTrigger, hashSet_);
						using (XmlWriter xmlWriter = new XmlTextWriter(stringWriter))
						{
							eventTrigger.vmethod_4(xmlWriter, hashSet_, this.ScenarioContext);
							xmlWriter.Flush();
						}
						xmlDocument.LoadXml(stringWriter.ToString());
						if (this.includeXML)
						{
							luaTable2["xml"] = xmlDocument.InnerXml;
						}
						luaTable2[eventTrigger.eventTriggerType_0.ToString()] = Class448.smethod_15(ref xmlDocument);
						luaTable[luaTable.Keys.Count + 1] = luaTable2;
					}
				}
				finally
				{
					List<EventTrigger>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return luaTable;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x00248804 File Offset: 0x00246A04
		[Attribute2]
		public LuaTable conditions
		{
			get
			{
				HashSet<string> hashSet_ = new HashSet<string>();
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				try
				{
					foreach (EventCondition eventCondition in this.ev.list_1)
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						XmlDocument xmlDocument = new XmlDocument();
						StringBuilder sb = new StringBuilder();
						StringWriter stringWriter = new StringWriter(sb);
						using (XmlWriter xmlWriter = new XmlTextWriter(stringWriter))
						{
							eventCondition.vmethod_5(xmlWriter, hashSet_, this.ScenarioContext);
							xmlWriter.Flush();
						}
						xmlDocument.LoadXml(stringWriter.ToString());
						if (this.includeXML)
						{
							luaTable2["xml"] = xmlDocument.InnerXml;
						}
						luaTable2[eventCondition.eventConditionType_0.ToString()] = Class448.smethod_15(ref xmlDocument);
						luaTable[luaTable.Keys.Count + 1] = luaTable2;
					}
				}
				finally
				{
					List<EventCondition>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return luaTable;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x0024892C File Offset: 0x00246B2C
		[Attribute2]
		public LuaTable actions
		{
			get
			{
				HashSet<string> hashSet_ = new HashSet<string>();
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				try
				{
					foreach (EventAction eventAction in this.ev.list_2)
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["type"] = eventAction.eventActionType_0.ToString();
						XmlDocument xmlDocument = new XmlDocument();
						StringBuilder sb = new StringBuilder();
						StringWriter stringWriter = new StringWriter(sb);
						using (XmlWriter xmlWriter = new XmlTextWriter(stringWriter))
						{
							eventAction.vmethod_4(xmlWriter, hashSet_, this.ScenarioContext);
							xmlWriter.Flush();
						}
						xmlDocument.LoadXml(stringWriter.ToString());
						if (this.includeXML)
						{
							luaTable2["xml"] = xmlDocument.InnerXml;
						}
						luaTable2[eventAction.eventActionType_0.ToString()] = Class448.smethod_15(ref xmlDocument);
						luaTable[luaTable.Keys.Count + 1] = luaTable2;
					}
				}
				finally
				{
					List<EventAction>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return luaTable;
			}
		}

		// Token: 0x04001CF5 RID: 7413
		protected SimEvent ev;

		// Token: 0x04001CF6 RID: 7414
		protected Scenario ScenarioContext;

		// Token: 0x04001CF7 RID: 7415
		protected int level;

		// Token: 0x04001CF8 RID: 7416
		protected bool includeXML;
	}
}
