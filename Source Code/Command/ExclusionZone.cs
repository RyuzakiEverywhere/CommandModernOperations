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
	// Token: 0x0200024A RID: 586
	public sealed class ExclusionZone : Zone
	{
		// Token: 0x06001212 RID: 4626 RVA: 0x00166FA8 File Offset: 0x001651A8
		public ExclusionZone(string theDescription, Side theSide, List<ReferencePoint> theArea, Misc.PostureStance theMarkViolatorAs, List<GlobalVariables.ActiveUnitType> theAffectedUnitTypes = null)
		{
			this.string_2 = theDescription;
			this.list_0 = theArea;
			this.postureStance_0 = theMarkViolatorAs;
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
			string string_;
			if (!ActiveUnit_Navigator.smethod_7(ref theArea, ref string_, theSide, null, "Exclusion Zone '" + this.string_2 + "'"))
			{
				GameGeneral.smethod_1(string_);
			}
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0000A62A File Offset: 0x0000882A
		private ExclusionZone()
		{
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00167080 File Offset: 0x00165280
		public void method_15(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("ExclusionZone");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				xmlWriter_0.WriteElementString("Description", this.string_2);
				xmlWriter_0.WriteStartElement("Area");
				try
				{
					foreach (ReferencePoint referencePoint in this.list_0)
					{
						xmlWriter_0.WriteRaw(referencePoint.method_17(ref hashSet_0));
					}
				}
				finally
				{
					List<ReferencePoint>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteElementString("AffectedUnitTypes", string.Join("_", Enumerable.Select<GlobalVariables.ActiveUnitType, string>(this.vmethod_4(), (ExclusionZone._Closure$__.$I3-0 == null) ? (ExclusionZone._Closure$__.$I3-0 = new Func<GlobalVariables.ActiveUnitType, string>(ExclusionZone._Closure$__.$I.method_0)) : ExclusionZone._Closure$__.$I3-0)));
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "MarkViolatorAs";
				byte b = (byte)this.postureStance_0;
				xmlWriter.WriteElementString(localName, b.ToString());
				xmlWriter_0.WriteElementString("IsActive", this.bool_11.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100991", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x001671E0 File Offset: 0x001653E0
		public static ExclusionZone smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_0)
		{
			ExclusionZone result;
			try
			{
				ExclusionZone exclusionZone = new ExclusionZone();
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
									if (Operators.CompareString(name, "MarkViolatorAs", false) == 0)
									{
										exclusionZone.postureStance_0 = (Misc.PostureStance)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									if (Operators.CompareString(name, "AffectedUnitTypes", false) == 0)
									{
										exclusionZone.vmethod_5(new ObservableList<GlobalVariables.ActiveUnitType>());
										foreach (string text in xmlNode.InnerText.Split(new char[]
										{
											'_'
										}))
										{
											if (Versioned.IsNumeric(text))
											{
												int num = Conversions.ToInteger(text);
												exclusionZone.vmethod_4().method_4((GlobalVariables.ActiveUnitType)num);
											}
										}
										continue;
									}
									if (Operators.CompareString(name, "IsActive", false) == 0)
									{
										exclusionZone.bool_11 = Conversions.ToBoolean(xmlNode.InnerText);
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
											exclusionZone.list_0.Add(ReferencePoint.smethod_13(ref xmlNode2, ref dictionary_0));
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
							exclusionZone.string_2 = xmlNode.InnerText;
						}
						else
						{
							if (dictionary_0.ContainsKey(xmlNode.InnerText))
							{
								return (ExclusionZone)dictionary_0[xmlNode.InnerText];
							}
							exclusionZone.vmethod_0(xmlNode.InnerText);
							dictionary_0.Add(exclusionZone.string_0, exclusionZone);
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
				if (Information.IsNothing(exclusionZone.vmethod_4()))
				{
					Zone zone = exclusionZone;
					ObservableList<GlobalVariables.ActiveUnitType> observableList = new ObservableList<GlobalVariables.ActiveUnitType>();
					observableList.method_4(GlobalVariables.ActiveUnitType.Aircraft);
					observableList.method_4(GlobalVariables.ActiveUnitType.Ship);
					observableList.method_4(GlobalVariables.ActiveUnitType.Submarine);
					observableList.method_4(GlobalVariables.ActiveUnitType.Facility);
					zone.vmethod_5(observableList);
				}
				result = exclusionZone;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100992", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ExclusionZone();
			}
			return result;
		}

		// Token: 0x04000CAB RID: 3243
		public Misc.PostureStance postureStance_0;
	}
}
