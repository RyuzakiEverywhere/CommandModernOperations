using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Text;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;

namespace Command_Core
{
	// Token: 0x02000207 RID: 519
	public sealed class DockFacility : PlatformComponent
	{
		// Token: 0x06000FD0 RID: 4048 RVA: 0x00128A38 File Offset: 0x00126C38
		public string method_23(HashSet<string> hashSet_0)
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
				this.stringBuilder_0.Append("<DockFacility>");
				this.stringBuilder_0.Append("<ID>").Append(this.string_0).Append("</ID>");
				if (!Information.IsNothing(hashSet_0))
				{
					if (hashSet_0.Contains(this.string_0))
					{
						this.stringBuilder_0.Append("</DockFacility>");
						return this.stringBuilder_0.ToString();
					}
					hashSet_0.Add(this.string_0);
				}
				this.stringBuilder_0.Append("<DBID>").Append(this.DBID.ToString()).Append("</DBID>");
				if (this._ComponentStatus_0 != PlatformComponent._ComponentStatus.Operational)
				{
					StringBuilder stringBuilder = this.stringBuilder_0.Append("<Status>");
					byte componentStatus_ = (byte)this._ComponentStatus_0;
					stringBuilder.Append(componentStatus_.ToString()).Append("</Status>");
				}
				if (base.method_16() != PlatformComponent._DamageSeverityFactor.Light)
				{
					this.stringBuilder_0.Append("<DamageSeverity>").Append(((byte)base.method_16()).ToString()).Append("</DamageSeverity>");
				}
				this.stringBuilder_0.Append("</DockFacility>");
				result = this.stringBuilder_0.ToString();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100664", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00128BEC File Offset: 0x00126DEC
		public static DockFacility smethod_2(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_0)
		{
			DockFacility result;
			try
			{
				XmlNode xmlNode = Misc.smethod_44(xmlNode_0.ChildNodes, "DBID");
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					result = (DockFacility)dictionary_0[innerText];
				}
				else
				{
					int facilityDBID = Conversions.ToInteger(xmlNode.InnerText);
					SQLiteConnection sqliteConnection = scenario_0.method_39();
					DockFacility dockFacility = DBFunctions.smethod_78(facilityDBID, ref sqliteConnection, null);
					if (dictionary_0.ContainsKey(innerText))
					{
						result = (DockFacility)dictionary_0[innerText];
					}
					else
					{
						dockFacility.vmethod_0(innerText);
						dictionary_0.Add(dockFacility.string_0, dockFacility);
						try
						{
							foreach (object obj in xmlNode_0.ChildNodes)
							{
								XmlNode xmlNode2 = (XmlNode)obj;
								string name = xmlNode2.Name;
								if (Operators.CompareString(name, "Status", false) != 0)
								{
									if (Operators.CompareString(name, "DamageSeverity", false) == 0)
									{
										dockFacility.method_17((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode2.InnerText));
									}
								}
								else
								{
									string innerText2 = xmlNode2.InnerText;
									if (Operators.CompareString(innerText2, "Operational", false) != 0)
									{
										if (Operators.CompareString(innerText2, "Damaged", false) != 0)
										{
											if (Operators.CompareString(innerText2, "Destroyed", false) != 0)
											{
												dockFacility._ComponentStatus_0 = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode2.InnerText);
											}
											else
											{
												dockFacility._ComponentStatus_0 = PlatformComponent._ComponentStatus.Destroyed;
											}
										}
										else
										{
											dockFacility._ComponentStatus_0 = PlatformComponent._ComponentStatus.Damaged;
										}
									}
									else
									{
										dockFacility._ComponentStatus_0 = PlatformComponent._ComponentStatus.Operational;
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
						result = dockFacility;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100665", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x00009FC8 File Offset: 0x000081C8
		public DockFacility(ActiveUnit activeUnit_1, string string_2, DockFacility.Enum49 enum49_1, DockFacility.Enum50 enum50_1, byte byte_1) : base(activeUnit_1)
		{
			this.lazy_0 = new Lazy<ConcurrentDictionary<string, ActiveUnit>>();
			this.Name = string_2;
			this.enum49_0 = enum49_1;
			this.enum50_0 = enum50_1;
			this.byte_0 = byte_1;
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00128DE4 File Offset: 0x00126FE4
		public bool method_24()
		{
			DockFacility.Enum49 @enum = this.enum49_0;
			if (@enum != DockFacility.Enum49.const_1)
			{
				if (@enum != DockFacility.Enum49.const_3)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00128E14 File Offset: 0x00127014
		public bool method_25()
		{
			DockFacility.Enum50 @enum = this.enum50_0;
			return @enum - DockFacility.Enum50.const_1 <= 5;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00128E3C File Offset: 0x0012703C
		public bool method_26(short short_0, DockFacility.Enum50 enum50_1)
		{
			bool result;
			if (this.method_25())
			{
				result = this.method_27((float)short_0);
			}
			else
			{
				result = (ActiveUnit_DockingOps.smethod_12(enum50_1) && this.method_27((float)short_0));
			}
			return result;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00128E74 File Offset: 0x00127074
		public override void vmethod_6(Side side_0, bool bool_11, bool bool_12)
		{
			try
			{
				if (!this.lazy_0.Value.IsEmpty)
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.lazy_0.Value.Values)
						{
							activeUnit.scenario_0.method_65(activeUnit);
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
				}
				base.vmethod_6(side_0, bool_11, bool_12);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100666", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00128F30 File Offset: 0x00127130
		public override void vmethod_8(PlatformComponent._DamageSeverityFactor _DamageSeverityFactor_1)
		{
			try
			{
				int num;
				if (!this.lazy_0.Value.IsEmpty)
				{
					switch (_DamageSeverityFactor_1)
					{
					case PlatformComponent._DamageSeverityFactor.Light:
						num = (int)Math.Round((double)this.lazy_0.Value.Count / 3.0);
						break;
					case PlatformComponent._DamageSeverityFactor.Medium:
						num = (int)Math.Round((double)this.lazy_0.Value.Count / 2.0);
						break;
					case PlatformComponent._DamageSeverityFactor.Heavy:
						num = (int)Math.Round((double)(2 * this.lazy_0.Value.Count) / 3.0);
						break;
					}
				}
				int num2 = 0;
				try
				{
					foreach (ActiveUnit activeUnit in this.lazy_0.Value.Values)
					{
						string text = "";
						if (Operators.CompareString(activeUnit.Name, activeUnit.string_2, false) != 0)
						{
							text = " (" + activeUnit.string_2 + ")";
						}
						base.method_18().method_124(string.Concat(new string[]
						{
							activeUnit.Name,
							text,
							" was hosted in ",
							this.Name,
							" and has been destroyed by the damage!"
						}), activeUnit.Name + " destroyed!", LoggedMessage.MessageType.UnitLost, 2, false, new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
						activeUnit.scenario_0.method_65(activeUnit);
						num2++;
						if (num2 == num)
						{
							break;
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
				base.vmethod_8(_DamageSeverityFactor_1);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100667", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00129154 File Offset: 0x00127354
		private bool method_27(float float_0)
		{
			int num = this.method_28();
			return float_0 <= (float)num && (float)this.method_29() >= float_0;
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00129180 File Offset: 0x00127380
		public int method_28()
		{
			DockFacility.Enum50 @enum = this.enum50_0;
			if (@enum <= DockFacility.Enum50.const_6)
			{
				if (@enum == DockFacility.Enum50.const_0)
				{
					return 0;
				}
				switch (@enum)
				{
				case DockFacility.Enum50.const_1:
					goto IL_8B;
				case DockFacility.Enum50.const_3:
					goto IL_95;
				case DockFacility.Enum50.const_4:
					goto IL_9A;
				case DockFacility.Enum50.const_5:
					return 200;
				case DockFacility.Enum50.const_6:
					return 500;
				}
			}
			else
			{
				switch (@enum)
				{
				case DockFacility.Enum50.const_7:
					goto IL_8B;
				case DockFacility.Enum50.const_8:
					return 17;
				case DockFacility.Enum50.const_9:
					goto IL_95;
				case DockFacility.Enum50.const_10:
					goto IL_9A;
				default:
					if (@enum == DockFacility.Enum50.const_11)
					{
						return 20;
					}
					if (@enum == DockFacility.Enum50.const_12)
					{
						return 10;
					}
					break;
				}
			}
			return 0;
			IL_8B:
			return 11;
			IL_95:
			return 25;
			IL_9A:
			return 45;
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0012922C File Offset: 0x0012742C
		public int method_29()
		{
			int result;
			try
			{
				int num = this.method_28() * (int)this.byte_0;
				int num2;
				try
				{
					foreach (ActiveUnit activeUnit in this.lazy_0.Value.Values)
					{
						if (activeUnit.bool_6)
						{
							num2 = (int)Math.Round((double)((float)num2 + ((Ship)activeUnit).float_13));
						}
						else
						{
							if (!activeUnit.bool_5)
							{
								throw new NotImplementedException();
							}
							num2 = (int)Math.Round((double)((float)num2 + ((Submarine)activeUnit).float_13));
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
				result = num - num2;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100668", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x04000A78 RID: 2680
		public DockFacility.Enum50 enum50_0;

		// Token: 0x04000A79 RID: 2681
		public DockFacility.Enum49 enum49_0;

		// Token: 0x04000A7A RID: 2682
		public byte byte_0;

		// Token: 0x04000A7B RID: 2683
		public Lazy<ConcurrentDictionary<string, ActiveUnit>> lazy_0;

		// Token: 0x04000A7C RID: 2684
		private StringBuilder stringBuilder_0;

		// Token: 0x02000208 RID: 520
		internal enum Enum49 : short
		{
			// Token: 0x04000A7E RID: 2686
			const_0 = 1001,
			// Token: 0x04000A7F RID: 2687
			const_1 = 2001,
			// Token: 0x04000A80 RID: 2688
			const_2 = 3001,
			// Token: 0x04000A81 RID: 2689
			const_3 = 4001,
			// Token: 0x04000A82 RID: 2690
			const_4 = 5001,
			// Token: 0x04000A83 RID: 2691
			const_5 = 9001
		}

		// Token: 0x02000209 RID: 521
		internal enum Enum50 : short
		{
			// Token: 0x04000A85 RID: 2693
			const_0 = 1001,
			// Token: 0x04000A86 RID: 2694
			const_1 = 2001,
			// Token: 0x04000A87 RID: 2695
			const_2,
			// Token: 0x04000A88 RID: 2696
			const_3,
			// Token: 0x04000A89 RID: 2697
			const_4,
			// Token: 0x04000A8A RID: 2698
			const_5,
			// Token: 0x04000A8B RID: 2699
			const_6,
			// Token: 0x04000A8C RID: 2700
			const_7 = 3001,
			// Token: 0x04000A8D RID: 2701
			const_8,
			// Token: 0x04000A8E RID: 2702
			const_9,
			// Token: 0x04000A8F RID: 2703
			const_10,
			// Token: 0x04000A90 RID: 2704
			const_11 = 4001,
			// Token: 0x04000A91 RID: 2705
			const_12 = 5001
		}
	}
}
