using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Security;
using System.Text;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;

namespace Command_Core
{
	// Token: 0x020002CC RID: 716
	public sealed class AirFacility : PlatformComponent
	{
		// Token: 0x06001533 RID: 5427 RVA: 0x0018EAB4 File Offset: 0x0018CCB4
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
				this.stringBuilder_0.Append("<AirFacility>");
				this.stringBuilder_0.Append("<ID>").Append(this.string_0).Append("</ID>");
				this.stringBuilder_0.Append("<DBID>").Append(this.DBID.ToString()).Append("</DBID>");
				if (this.DBID == 0)
				{
					this.stringBuilder_0.Append("<Name>").Append(SecurityElement.Escape(this.Name)).Append("</Name>");
					this.stringBuilder_0.Append("<Type>").Append((int)this.enum110_0).Append("</Type>");
					this.stringBuilder_0.Append("<Size>").Append((int)this.aircraftSizeClass_0).Append("</Size>");
					this.stringBuilder_0.Append("<Capacity>").Append(this.int_0).Append("</Capacity>");
				}
				if (!Information.IsNothing(hashSet_0))
				{
					if (hashSet_0.Contains(this.string_0))
					{
						this.stringBuilder_0.Append("</AirFacility>");
						return this.stringBuilder_0.ToString();
					}
					hashSet_0.Add(this.string_0);
				}
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
				this.stringBuilder_0.Append("</AirFacility>");
				result = this.stringBuilder_0.ToString();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100652", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0018ED10 File Offset: 0x0018CF10
		private static AirFacility smethod_2(XmlNode xmlNode_0)
		{
			AirFacility result;
			try
			{
				int num = Conversions.ToInteger(Misc.smethod_44(xmlNode_0.ChildNodes, "Type").InnerText);
				int int_ = Conversions.ToInteger(Misc.smethod_44(xmlNode_0.ChildNodes, "Capacity").InnerText);
				GlobalVariables.Enum146 enum146_;
				GlobalVariables.AircraftSizeClass int_2;
				switch (Conversions.ToInteger(Misc.smethod_44(xmlNode_0.ChildNodes, "Size").InnerText))
				{
				case 1:
					enum146_ = GlobalVariables.Enum146.const_1;
					int_2 = GlobalVariables.AircraftSizeClass.Small;
					break;
				case 2:
					enum146_ = GlobalVariables.Enum146.const_1;
					int_2 = GlobalVariables.AircraftSizeClass.Medium;
					break;
				case 3:
					enum146_ = GlobalVariables.Enum146.const_1;
					int_2 = GlobalVariables.AircraftSizeClass.Large;
					break;
				case 4:
					enum146_ = GlobalVariables.Enum146.const_1;
					int_2 = GlobalVariables.AircraftSizeClass.VLarge;
					break;
				case 5:
					enum146_ = GlobalVariables.Enum146.const_2;
					int_2 = GlobalVariables.AircraftSizeClass.Small;
					break;
				case 6:
					enum146_ = GlobalVariables.Enum146.const_3;
					int_2 = GlobalVariables.AircraftSizeClass.Small;
					break;
				case 7:
					enum146_ = GlobalVariables.Enum146.const_4;
					int_2 = GlobalVariables.AircraftSizeClass.Medium;
					break;
				case 8:
					enum146_ = GlobalVariables.Enum146.const_6;
					int_2 = GlobalVariables.AircraftSizeClass.Large;
					break;
				case 9:
					enum146_ = GlobalVariables.Enum146.const_7;
					int_2 = GlobalVariables.AircraftSizeClass.VLarge;
					break;
				}
				result = new AirFacility(null, Misc.smethod_44(xmlNode_0.ChildNodes, "Name").InnerText, (AirFacility.Enum110)num, (int)int_2, int_, enum146_);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200033", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0018EE7C File Offset: 0x0018D07C
		public static AirFacility smethod_3(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_0)
		{
			AirFacility result;
			try
			{
				XmlNode xmlNode = Misc.smethod_44(xmlNode_0.ChildNodes, "DBID");
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					result = (AirFacility)dictionary_0[innerText];
				}
				else
				{
					AirFacility airFacility;
					if (Information.IsNothing(xmlNode))
					{
						airFacility = AirFacility.smethod_2(xmlNode_0);
					}
					else if (Operators.CompareString(xmlNode.InnerText, "0", false) == 0)
					{
						airFacility = AirFacility.smethod_2(xmlNode_0);
						if (Information.IsNothing(airFacility))
						{
							return null;
						}
					}
					else
					{
						int facilityDBID = Conversions.ToInteger(xmlNode.InnerText);
						SQLiteConnection sqliteConnection = scenario_0.method_39();
						airFacility = DBFunctions.smethod_77(facilityDBID, ref sqliteConnection, null);
					}
					if (dictionary_0.ContainsKey(innerText))
					{
						result = (AirFacility)dictionary_0[innerText];
					}
					else
					{
						airFacility.vmethod_0(innerText);
						dictionary_0.Add(airFacility.string_0, airFacility);
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
										airFacility.method_17((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode2.InnerText));
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
												airFacility._ComponentStatus_0 = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode2.InnerText);
											}
											else
											{
												airFacility._ComponentStatus_0 = PlatformComponent._ComponentStatus.Destroyed;
											}
										}
										else
										{
											airFacility._ComponentStatus_0 = PlatformComponent._ComponentStatus.Damaged;
										}
									}
									else
									{
										airFacility._ComponentStatus_0 = PlatformComponent._ComponentStatus.Operational;
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
						result = airFacility;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100653", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0000B952 File Offset: 0x00009B52
		public AirFacility(ActiveUnit activeUnit_1, string string_2, AirFacility.Enum110 enum110_1, int int_1, int int_2, GlobalVariables.Enum146 enum146_1) : base(activeUnit_1)
		{
			this.Name = string_2;
			this.enum110_0 = enum110_1;
			this.aircraftSizeClass_0 = (GlobalVariables.AircraftSizeClass)int_1;
			this.enum146_0 = enum146_1;
			this.lazy_0 = new Lazy<ConcurrentDictionary<string, Aircraft>>();
			this.int_0 = int_2;
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0000B98D File Offset: 0x00009B8D
		public ConcurrentDictionary<string, Aircraft> method_24()
		{
			return this.lazy_0.Value;
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0000B99A File Offset: 0x00009B9A
		public string method_25()
		{
			return this.method_30(this.Name);
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0000B9A8 File Offset: 0x00009BA8
		public override PlatformComponent._ComponentStatus vmethod_5()
		{
			return base.vmethod_5();
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0018F0B0 File Offset: 0x0018D2B0
		public override void vmethod_6(Side side_0, bool bool_11, bool bool_12)
		{
			try
			{
				if (!this.method_24().IsEmpty)
				{
					try
					{
						foreach (Aircraft activeUnit_ in this.method_24().Values)
						{
							base.method_18().scenario_0.method_65(activeUnit_);
						}
					}
					finally
					{
						IEnumerator<Aircraft> enumerator;
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
				ex.Data.Add("Error at 100654", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0018F168 File Offset: 0x0018D368
		public void method_26(PlatformComponent._DamageSeverityFactor _DamageSeverityFactor_1, float float_0)
		{
			if (!this.method_24().IsEmpty && (this.method_33() || float_0 != 0f))
			{
				try
				{
					foreach (Aircraft aircraft in this.method_24().Values)
					{
						if (this.method_33() || float_0 >= 1f || GameGeneral.smethod_5().NextDouble() <= (double)float_0)
						{
							string text = "";
							if (Operators.CompareString(aircraft.Name, aircraft.string_2, false) != 0)
							{
								text = " (" + aircraft.string_2 + ")";
							}
							if (!Information.IsNothing(base.method_18()))
							{
								base.method_18().method_124(string.Concat(new string[]
								{
									aircraft.Name,
									text,
									" was hosted in ",
									this.Name,
									" and has been destroyed by the damage!"
								}), aircraft.Name + " destroyed!", LoggedMessage.MessageType.UnitLost, 2, false, new Geopoint_Struct(base.method_18().vmethod_28(null), base.method_18().vmethod_30(null)));
								base.method_18().scenario_0.method_65(aircraft);
							}
						}
					}
				}
				finally
				{
					IEnumerator<Aircraft> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0018F2D8 File Offset: 0x0018D4D8
		public GlobalVariables.AircraftSizeClass method_27()
		{
			GlobalVariables.AircraftSizeClass result;
			if (Information.IsNothing(base.method_18()))
			{
				result = GlobalVariables.AircraftSizeClass.None;
			}
			else
			{
				double num = (double)(100f - base.method_18().vmethod_91().method_0());
				if (num > 75.0)
				{
					result = this.aircraftSizeClass_0;
				}
				else if (num > 50.0)
				{
					result = (GlobalVariables.AircraftSizeClass)Math.Max((int)(this.aircraftSizeClass_0 - GlobalVariables.AircraftSizeClass.Small), 0);
				}
				else if (num > 25.0)
				{
					result = (GlobalVariables.AircraftSizeClass)Math.Max((int)(this.aircraftSizeClass_0 - GlobalVariables.AircraftSizeClass.Medium), 0);
				}
				else if (num > 10.0)
				{
					result = (GlobalVariables.AircraftSizeClass)Math.Max((int)(this.aircraftSizeClass_0 - GlobalVariables.AircraftSizeClass.Large), 0);
				}
				else
				{
					result = GlobalVariables.AircraftSizeClass.None;
				}
			}
			return result;
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0000B9B0 File Offset: 0x00009BB0
		public AirFacility.Enum110 method_28()
		{
			return this.enum110_0;
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		public GlobalVariables.AircraftSizeClass method_29()
		{
			return this.aircraftSizeClass_0;
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0018F384 File Offset: 0x0018D584
		private string method_30(string string_2)
		{
			int num = Strings.InStr(string_2, "(", CompareMethod.Binary);
			string result;
			if (num == 0)
			{
				result = string_2;
			}
			else
			{
				result = Strings.Trim(Strings.Left(string_2, num - 1));
			}
			return result;
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0018F3B8 File Offset: 0x0018D5B8
		public bool method_31()
		{
			AirFacility.Enum110 @enum = this.method_28();
			return @enum - AirFacility.Enum110.const_1 <= 2 || @enum - AirFacility.Enum110.const_5 <= 2 || @enum - AirFacility.Enum110.const_8 <= 1;
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x0000B9C0 File Offset: 0x00009BC0
		public bool method_32()
		{
			return this.method_28() == AirFacility.Enum110.const_5;
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0018F3F4 File Offset: 0x0018D5F4
		public bool method_33()
		{
			AirFacility.Enum110 @enum = this.method_28();
			if (@enum <= AirFacility.Enum110.const_6)
			{
				if (@enum - AirFacility.Enum110.const_1 <= 3 || @enum == AirFacility.Enum110.const_6)
				{
					goto IL_3B;
				}
			}
			else
			{
				if (@enum - AirFacility.Enum110.const_8 <= 1)
				{
					goto IL_3B;
				}
				if (@enum == AirFacility.Enum110.const_11)
				{
					goto IL_3B;
				}
			}
			return false;
			IL_3B:
			return true;
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0018F440 File Offset: 0x0018D640
		public bool method_34()
		{
			AirFacility.Enum110 @enum = this.method_28();
			return @enum - AirFacility.Enum110.const_10 <= 1;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0018F468 File Offset: 0x0018D668
		public bool method_35()
		{
			AirFacility.Enum110 @enum = this.method_28();
			return @enum == AirFacility.Enum110.const_4 || @enum == AirFacility.Enum110.const_12;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0018F498 File Offset: 0x0018D698
		public int method_36()
		{
			int result;
			switch (this.aircraftSizeClass_0)
			{
			case GlobalVariables.AircraftSizeClass.Small:
				result = this.int_0;
				break;
			case GlobalVariables.AircraftSizeClass.Medium:
				result = 2 * this.int_0;
				break;
			case GlobalVariables.AircraftSizeClass.Large:
				result = 3 * this.int_0;
				break;
			case GlobalVariables.AircraftSizeClass.VLarge:
				result = 4 * this.int_0;
				break;
			}
			return result;
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0018F4F0 File Offset: 0x0018D6F0
		public int method_37()
		{
			int result;
			try
			{
				int num = this.method_36();
				try
				{
					foreach (Aircraft aircraft in this.method_24().Values)
					{
						num -= (int)aircraft.aircraftSizeClass_0;
					}
				}
				finally
				{
					IEnumerator<Aircraft> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100656", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0018F594 File Offset: 0x0018D794
		public bool method_38(Aircraft aircraft_0)
		{
			bool result;
			try
			{
				if (Information.IsNothing(base.method_18()))
				{
					result = false;
				}
				else
				{
					GlobalVariables.ActiveUnitType activeUnitType = base.method_18().vmethod_56();
					if (activeUnitType - GlobalVariables.ActiveUnitType.Ship <= 1 && aircraft_0.aircraftSizeClass_0 > this.aircraftSizeClass_0)
					{
						result = false;
					}
					else
					{
						int num = this.method_37();
						if (this.method_24().ContainsKey(aircraft_0.string_0))
						{
							num = (int)((byte)num + aircraft_0.aircraftSizeClass_0);
						}
						result = (num >= (int)aircraft_0.aircraftSizeClass_0);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100657", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0000B9CF File Offset: 0x00009BCF
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x04001140 RID: 4416
		private AirFacility.Enum110 enum110_0;

		// Token: 0x04001141 RID: 4417
		private GlobalVariables.AircraftSizeClass aircraftSizeClass_0;

		// Token: 0x04001142 RID: 4418
		public int int_0;

		// Token: 0x04001143 RID: 4419
		private Lazy<ConcurrentDictionary<string, Aircraft>> lazy_0;

		// Token: 0x04001144 RID: 4420
		public GlobalVariables.Enum146 enum146_0;

		// Token: 0x04001145 RID: 4421
		private StringBuilder stringBuilder_0;

		// Token: 0x020002CD RID: 717
		internal enum Enum110 : short
		{
			// Token: 0x04001147 RID: 4423
			const_0 = 1001,
			// Token: 0x04001148 RID: 4424
			const_1 = 2001,
			// Token: 0x04001149 RID: 4425
			const_2,
			// Token: 0x0400114A RID: 4426
			const_3,
			// Token: 0x0400114B RID: 4427
			const_4,
			// Token: 0x0400114C RID: 4428
			const_5,
			// Token: 0x0400114D RID: 4429
			const_6,
			// Token: 0x0400114E RID: 4430
			const_7,
			// Token: 0x0400114F RID: 4431
			const_8 = 3001,
			// Token: 0x04001150 RID: 4432
			const_9,
			// Token: 0x04001151 RID: 4433
			const_10 = 4001,
			// Token: 0x04001152 RID: 4434
			const_11,
			// Token: 0x04001153 RID: 4435
			const_12
		}
	}
}
