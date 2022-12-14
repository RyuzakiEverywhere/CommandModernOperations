using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns14;

namespace Command_Core
{
	// Token: 0x02000277 RID: 631
	public sealed class Group_Kinematics : ActiveUnit_Kinematics
	{
		// Token: 0x0600135F RID: 4959 RVA: 0x00174E6C File Offset: 0x0017306C
		public override void vmethod_0(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteElementString("AMV", XmlConvert.ToString(this.float_1));
				if (this.vmethod_10() != null)
				{
					xmlWriter_0.WriteElementString("DSO", XmlConvert.ToString(this.vmethod_10().Value));
				}
				if (this.vmethod_12())
				{
					xmlWriter_0.WriteElementString("DAO", this.vmethod_12().ToString());
				}
				if (this.bool_3)
				{
					xmlWriter_0.WriteElementString("LATSD", this.bool_3.ToString());
				}
				xmlWriter_0.WriteElementString("SP", ((byte)this.vmethod_1()).ToString());
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100612", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00174F64 File Offset: 0x00173164
		public static Group_Kinematics smethod_5(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Group_Kinematics result;
			try
			{
				Group_Kinematics group_Kinematics = new Group_Kinematics(ref activeUnit_1);
				group_Kinematics.activeUnit_0 = activeUnit_1;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 1633936287U)
						{
							if (num != 154738112U)
							{
								if (num != 316182301U)
								{
									if (num != 1633936287U)
									{
										continue;
									}
									if (Operators.CompareString(name, "AMV", false) != 0)
									{
										continue;
									}
									goto IL_165;
								}
								else if (Operators.CompareString(name, "DSO", false) != 0)
								{
									continue;
								}
							}
							else if (Operators.CompareString(name, "DesiredSpeedOverride", false) != 0)
							{
								continue;
							}
							if (Operators.CompareString(xmlNode.InnerText, true.ToString(), false) != 0 && Operators.CompareString(xmlNode.InnerText, false.ToString(), false) != 0)
							{
								group_Kinematics.vmethod_11(new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."))));
								continue;
							}
							if (Operators.CompareString(xmlNode.InnerText, true.ToString(), false) == 0)
							{
								group_Kinematics.vmethod_11(new float?(activeUnit_1.vmethod_70()));
								continue;
							}
							continue;
						}
						else if (num <= 2788980997U)
						{
							if (num != 1728224374U)
							{
								if (num != 2788980997U)
								{
									continue;
								}
								if (Operators.CompareString(name, "ActualMovementVector", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "SP", false) == 0)
								{
									group_Kinematics.vmethod_2((ActiveUnit_Kinematics.UnitThrottlePreset)Conversions.ToByte(xmlNode.InnerText));
									continue;
								}
								continue;
							}
						}
						else if (num != 3498149545U)
						{
							if (num == 3806043832U && Operators.CompareString(name, "ClimbRate", false) == 0)
							{
								group_Kinematics.vmethod_15(true, XmlConvert.ToSingle(xmlNode.InnerText));
								continue;
							}
							continue;
						}
						else
						{
							if (Operators.CompareString(name, "LATSD", false) == 0)
							{
								group_Kinematics.bool_3 = Conversions.ToBoolean(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						IL_165:
						group_Kinematics.float_1 = XmlConvert.ToSingle(xmlNode.InnerText);
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
				result = group_Kinematics;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100613", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Group_Kinematics(ref activeUnit_1);
			}
			return result;
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x0000AE21 File Offset: 0x00009021
		public Group_Kinematics(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
			this.bool_3 = true;
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x0000AE31 File Offset: 0x00009031
		public bool method_17()
		{
			return this.bool_3;
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x001751FC File Offset: 0x001733FC
		public void method_18(bool bool_4)
		{
			this.bool_3 = bool_4;
			if (bool_4 && !Information.IsNothing(((Group)this.activeUnit_0).method_147()))
			{
				((Group)this.activeUnit_0).method_147().vmethod_87().vmethod_11(null);
			}
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00175250 File Offset: 0x00173450
		public void method_19()
		{
			if (!Information.IsNothing(((Group)this.activeUnit_0).method_147()))
			{
				this.activeUnit_0.vmethod_29(null, ((Group)this.activeUnit_0).method_147().vmethod_28(null));
				this.activeUnit_0.vmethod_31(null, ((Group)this.activeUnit_0).method_147().vmethod_30(null));
				this.activeUnit_0.vmethod_15(false, ((Group)this.activeUnit_0).method_147().vmethod_14(false));
				this.activeUnit_0.vmethod_10(((Group)this.activeUnit_0).method_147().vmethod_9());
				this.activeUnit_0.vmethod_41(((Group)this.activeUnit_0).method_147().vmethod_40());
			}
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x0000378C File Offset: 0x0000198C
		public override void vmethod_46(float float_5, bool bool_4, bool bool_5, DateTime dateTime_0)
		{
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00175340 File Offset: 0x00173540
		public override float? vmethod_10()
		{
			float? result;
			if (!Information.IsNothing(((Group)this.activeUnit_0).method_147()))
			{
				result = ((Group)this.activeUnit_0).method_147().vmethod_87().vmethod_10();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0017538C File Offset: 0x0017358C
		public override void vmethod_11(float? nullable_4)
		{
			try
			{
				if (!Information.IsNothing(((Group)this.activeUnit_0).method_147()))
				{
					((Group)this.activeUnit_0).method_147().vmethod_87().vmethod_11(nullable_4);
				}
				try
				{
					foreach (ActiveUnit activeUnit in ((Group)this.activeUnit_0).vmethod_141().Values)
					{
						if (!activeUnit.method_122())
						{
							activeUnit.vmethod_87().vmethod_11(null);
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
				if (Information.IsNothing(nullable_4))
				{
					this.activeUnit_0.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.None);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100614", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00175494 File Offset: 0x00173694
		public override ActiveUnit_Kinematics.UnitThrottlePreset vmethod_1()
		{
			ActiveUnit_Kinematics.UnitThrottlePreset result;
			if (!Information.IsNothing(((Group)this.activeUnit_0).method_147()))
			{
				result = ((Group)this.activeUnit_0).method_147().vmethod_87().vmethod_1();
			}
			else
			{
				result = ActiveUnit_Kinematics.UnitThrottlePreset.FullStop;
			}
			return result;
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x001754D8 File Offset: 0x001736D8
		public override void vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset unitThrottlePreset_1)
		{
			try
			{
				if (!Information.IsNothing(((Group)this.activeUnit_0).method_147()))
				{
					((Group)this.activeUnit_0).method_147().vmethod_87().vmethod_2(unitThrottlePreset_1);
				}
				try
				{
					foreach (ActiveUnit activeUnit in ((Group)this.activeUnit_0).vmethod_141().Values)
					{
						if (!activeUnit.method_122())
						{
							activeUnit.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.None);
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
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100615", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x001755B8 File Offset: 0x001737B8
		public override bool vmethod_12()
		{
			return !Information.IsNothing(((Group)this.activeUnit_0).method_147()) && ((Group)this.activeUnit_0).method_147().vmethod_87().vmethod_12();
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x001755FC File Offset: 0x001737FC
		public override void vmethod_13(bool bool_4)
		{
			try
			{
				if (!Information.IsNothing(((Group)this.activeUnit_0).method_147()))
				{
					((Group)this.activeUnit_0).method_147().vmethod_87().vmethod_13(bool_4);
				}
				try
				{
					foreach (ActiveUnit activeUnit in ((Group)this.activeUnit_0).vmethod_141().Values)
					{
						if (!activeUnit.method_122())
						{
							activeUnit.vmethod_87().vmethod_13(false);
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
				if (!bool_4)
				{
					if (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.SubGroup)
					{
						((Class167)this.activeUnit_0.vmethod_86()).method_112(ActiveUnit_AI.SubmarineDepthPreset.None);
					}
					if (this.activeUnit_0.bool_1 && ((Group)this.activeUnit_0).method_143() == Group.GroupType.AirGroup)
					{
						((Class167)this.activeUnit_0.vmethod_86()).method_113(ActiveUnit_AI.AircraftAltitudePreset.None);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100616", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x0017574C File Offset: 0x0017394C
		public override float vmethod_30()
		{
			Group.GroupType groupType = ((Group)this.activeUnit_0).method_143();
			float result;
			if (groupType != Group.GroupType.SurfaceGroup && groupType - Group.GroupType.Installation > 2)
			{
				IEnumerable<ActiveUnit> enumerable = Enumerable.OrderByDescending<ActiveUnit, float>(((Group)this.activeUnit_0).vmethod_141().Values, (Group_Kinematics._Closure$__.$I18-0 == null) ? (Group_Kinematics._Closure$__.$I18-0 = new Func<ActiveUnit, float>(Group_Kinematics._Closure$__.$I.method_0)) : Group_Kinematics._Closure$__.$I18-0);
				if (Enumerable.Count<ActiveUnit>(enumerable) == 0)
				{
					result = 0f;
				}
				else
				{
					result = Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable, 0).vmethod_87().vmethod_30();
				}
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x001757E0 File Offset: 0x001739E0
		public override float vmethod_31()
		{
			Group.GroupType groupType = ((Group)this.activeUnit_0).method_143();
			float result;
			if (groupType != Group.GroupType.SurfaceGroup && groupType - Group.GroupType.Installation > 2)
			{
				IEnumerable<ActiveUnit> enumerable = Enumerable.OrderBy<ActiveUnit, float>(((Group)this.activeUnit_0).vmethod_141().Values, (Group_Kinematics._Closure$__.$I19-0 == null) ? (Group_Kinematics._Closure$__.$I19-0 = new Func<ActiveUnit, float>(Group_Kinematics._Closure$__.$I.method_1)) : Group_Kinematics._Closure$__.$I19-0);
				if (Enumerable.Count<ActiveUnit>(enumerable) == 0)
				{
					result = 0f;
				}
				else
				{
					result = Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable, 0).vmethod_87().vmethod_31();
				}
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x0000AE39 File Offset: 0x00009039
		public override float vmethod_32(float float_5, bool bool_4)
		{
			return ((Group)this.activeUnit_0).method_147().vmethod_87().vmethod_32(float_5, bool_4);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00175874 File Offset: 0x00173A74
		public override int vmethod_40(float float_5, ActiveUnit.Throttle throttle_0, bool bool_4)
		{
			int result;
			if (Information.IsNothing(((Group)this.activeUnit_0).method_147()))
			{
				result = 0;
			}
			else
			{
				result = ((Group)this.activeUnit_0).method_147().vmethod_87().vmethod_40(float_5, throttle_0, bool_4);
			}
			return result;
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x001758BC File Offset: 0x00173ABC
		public override int vmethod_39(float float_5)
		{
			int result;
			if (Information.IsNothing(((Group)this.activeUnit_0).method_147()))
			{
				result = 0;
			}
			else
			{
				result = ((Group)this.activeUnit_0).method_147().vmethod_87().vmethod_39(float_5);
			}
			return result;
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00175904 File Offset: 0x00173B04
		public int method_20(ActiveUnit.Throttle throttle_0)
		{
			int num = 200000000;
			int result;
			try
			{
				try
				{
					foreach (ActiveUnit activeUnit in ((Group)this.activeUnit_0).vmethod_141().Values)
					{
						int num2 = activeUnit.vmethod_87().vmethod_40(activeUnit.vmethod_14(false), throttle_0, false);
						if (num2 < num)
						{
							num = num2;
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
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100617", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x04000DE2 RID: 3554
		private bool bool_3;
	}
}
