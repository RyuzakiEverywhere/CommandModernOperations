using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using DarkUI.Collections;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;

namespace Command_Core
{
	// Token: 0x020002BF RID: 703
	public sealed class NoNavZone : Zone
	{
		// Token: 0x060014F8 RID: 5368 RVA: 0x0018DC78 File Offset: 0x0018BE78
		public NoNavZone(string theDescription, List<ReferencePoint> theArea, Scenario theScen, Side CurrentSide, List<GlobalVariables.ActiveUnitType> theAffectedUnitTypes = null)
		{
			this.string_2 = theDescription;
			this.list_0 = theArea;
			if (Information.IsNothing(theAffectedUnitTypes))
			{
				ObservableList<GlobalVariables.ActiveUnitType> observableList = new ObservableList<GlobalVariables.ActiveUnitType>();
				observableList.method_4(GlobalVariables.ActiveUnitType.Aircraft);
				observableList.method_4(GlobalVariables.ActiveUnitType.Ship);
				observableList.method_4(GlobalVariables.ActiveUnitType.Submarine);
				observableList.method_4(GlobalVariables.ActiveUnitType.Facility);
				this.vmethod_5(observableList);
			}
			else
			{
				this.vmethod_5(new ObservableList<GlobalVariables.ActiveUnitType>());
				try
				{
					foreach (GlobalVariables.ActiveUnitType gparam_ in theAffectedUnitTypes)
					{
						this.vmethod_4().method_4(gparam_);
					}
				}
				finally
				{
					List<GlobalVariables.ActiveUnitType>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			try
			{
				foreach (ActiveUnit activeUnit in theScen.method_42())
				{
					if (activeUnit.vmethod_7(false) == CurrentSide)
					{
						activeUnit.vmethod_85().double_8 = 0.0;
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			string string_;
			if (!ActiveUnit_Navigator.smethod_7(ref theArea, ref string_, CurrentSide, theScen, "Exclusion Zone '" + this.string_2 + "'"))
			{
				GameGeneral.smethod_1(string_);
			}
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0000A62A File Offset: 0x0000882A
		private NoNavZone()
		{
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0018DDA4 File Offset: 0x0018BFA4
		public void method_15(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("NoNavZone");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				xmlWriter_0.WriteElementString("Description", this.string_2);
				xmlWriter_0.WriteStartElement("Area");
				int num = this.list_0.Count - 1;
				int i = 0;
				while (i <= num)
				{
					ReferencePoint referencePoint;
					try
					{
						referencePoint = this.list_0[i];
					}
					catch (Exception ex)
					{
						goto IL_7A;
					}
					goto IL_6C;
					IL_7A:
					i++;
					continue;
					IL_6C:
					xmlWriter_0.WriteRaw(referencePoint.method_17(ref hashSet_0));
					goto IL_7A;
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteElementString("AffectedUnitTypes", string.Join("_", Enumerable.Select<GlobalVariables.ActiveUnitType, string>(this.vmethod_4(), (NoNavZone._Closure$__.$I3-0 == null) ? (NoNavZone._Closure$__.$I3-0 = new Func<GlobalVariables.ActiveUnitType, string>(NoNavZone._Closure$__.$I.method_0)) : NoNavZone._Closure$__.$I3-0)));
				xmlWriter_0.WriteElementString("IsLocked", this.bool_12.ToString());
				xmlWriter_0.WriteElementString("IsActive", this.bool_11.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100993", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0018DF20 File Offset: 0x0018C120
		public static NoNavZone smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_0)
		{
			NoNavZone result;
			try
			{
				NoNavZone noNavZone = new NoNavZone();
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
								if (Operators.CompareString(name, "Area", false) != 0)
								{
									if (Operators.CompareString(name, "AffectedUnitTypes", false) == 0)
									{
										noNavZone.vmethod_5(new ObservableList<GlobalVariables.ActiveUnitType>());
										foreach (string text in xmlNode.InnerText.Split(new char[]
										{
											'_'
										}))
										{
											if (Versioned.IsNumeric(text))
											{
												int num = Conversions.ToInteger(text);
												noNavZone.vmethod_4().method_4((GlobalVariables.ActiveUnitType)num);
											}
										}
										continue;
									}
									if (Operators.CompareString(name, "IsLocked", false) == 0)
									{
										noNavZone.bool_12 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									if (Operators.CompareString(name, "IsActive", false) == 0)
									{
										noNavZone.bool_11 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									try
									{
										foreach (object obj2 in xmlNode.ChildNodes)
										{
											XmlNode xmlNode2 = (XmlNode)obj2;
											noNavZone.list_0.Add(ReferencePoint.smethod_13(ref xmlNode2, ref dictionary_0));
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
							noNavZone.string_2 = xmlNode.InnerText;
						}
						else
						{
							if (dictionary_0.ContainsKey(xmlNode.InnerText))
							{
								return (NoNavZone)dictionary_0[xmlNode.InnerText];
							}
							noNavZone.vmethod_0(xmlNode.InnerText);
							dictionary_0.Add(noNavZone.string_0, noNavZone);
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
				if (Information.IsNothing(noNavZone.vmethod_4()))
				{
					Zone zone = noNavZone;
					ObservableList<GlobalVariables.ActiveUnitType> observableList = new ObservableList<GlobalVariables.ActiveUnitType>();
					observableList.method_4(GlobalVariables.ActiveUnitType.Aircraft);
					observableList.method_4(GlobalVariables.ActiveUnitType.Ship);
					observableList.method_4(GlobalVariables.ActiveUnitType.Submarine);
					observableList.method_4(GlobalVariables.ActiveUnitType.Facility);
					zone.vmethod_5(observableList);
				}
				result = noNavZone;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100994", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new NoNavZone();
			}
			return result;
		}

		// Token: 0x0400110D RID: 4365
		public bool bool_12;
	}
}
