using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml;
using DotSpatial.Topology;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns12;
using ns13;
using ns19;
using ns20;

namespace Command_Core
{
	// Token: 0x02000161 RID: 353
	public class ActiveUnit_Navigator
	{
		// Token: 0x060009D2 RID: 2514 RVA: 0x000A3958 File Offset: 0x000A1B58
		public virtual void vmethod_0(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("ActiveUnit_Navigator");
				if (!this.activeUnit_0.method_122() && Enumerable.Count<Waypoint>(this.method_4()) > 0)
				{
					xmlWriter_0.WriteStartElement("PC");
					List<Waypoint> list = new List<Waypoint>();
					list.AddRange(this.method_4());
					try
					{
						foreach (Waypoint waypoint in list)
						{
							if (!Information.IsNothing(waypoint))
							{
								waypoint.method_19(ref xmlWriter_0, ref hashSet_0);
							}
						}
					}
					finally
					{
						List<Waypoint>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					xmlWriter_0.WriteEndElement();
				}
				if (Enumerable.Count<Waypoint>(this.method_6()) > 0)
				{
					xmlWriter_0.WriteStartElement("PC_PP");
					List<Waypoint> list2 = new List<Waypoint>();
					list2.AddRange(this.method_6());
					try
					{
						foreach (Waypoint waypoint2 in list2)
						{
							if (!Information.IsNothing(waypoint2))
							{
								waypoint2.method_19(ref xmlWriter_0, ref hashSet_0);
							}
						}
					}
					finally
					{
						List<Waypoint>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					xmlWriter_0.WriteEndElement();
				}
				if (!Information.IsNothing(this.flight_0))
				{
					xmlWriter_0.WriteElementString("Flight", this.flight_0.string_0);
				}
				xmlWriter_0.WriteElementString("MPO", this.bool_0.ToString());
				if (!Information.IsNothing(this.nullable_0))
				{
					xmlWriter_0.WriteElementString("TankerFollowsMe", this.nullable_0.Value.ToString());
				}
				if (this.int_0 != 0)
				{
					xmlWriter_0.WriteElementString("TankerFollowsMe_NumberOfWaypoints", this.int_0.ToString());
				}
				if (this.activeUnit_0.method_120())
				{
					if (this.method_2().float_0 != 0f)
					{
						xmlWriter_0.WriteElementString("FS_B", XmlConvert.ToString(this.method_2().float_0));
					}
					if (this.method_2().float_1 != 0f)
					{
						xmlWriter_0.WriteElementString("FS_D", XmlConvert.ToString(this.method_2().float_1));
					}
					xmlWriter_0.WriteElementString("FS_BT", XmlConvert.ToString((byte)this.method_2().orientationType_0));
				}
				if (!Information.IsNothing(this.referencePoint_0))
				{
					xmlWriter_0.WriteStartElement("SM_NRP");
					xmlWriter_0.WriteRaw(this.referencePoint_0.method_17(ref hashSet_0));
					xmlWriter_0.WriteEndElement();
				}
				if (this.nullable_2 != null)
				{
					xmlWriter_0.WriteElementString("PreviousWaypointTime", this.nullable_2.Value.ToBinary().ToString());
				}
				if (this.nullable_5 != null)
				{
					xmlWriter_0.WriteElementString("PreviousWaypointType", this.nullable_5.Value.ToString());
				}
				xmlWriter_0.WriteElementString("TTNPC", this.bool_0.ToString());
				if (this.vmethod_3())
				{
					xmlWriter_0.WriteElementString("SD", "True");
					xmlWriter_0.WriteElementString("SD_Avg", XmlConvert.ToString(this.vmethod_5().Value));
					xmlWriter_0.WriteElementString("SD_M", XmlConvert.ToString(this.vmethod_7().imethod_0()) + "_" + XmlConvert.ToString(this.vmethod_7().imethod_2()));
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100199", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000A3D1C File Offset: 0x000A1F1C
		public virtual void vmethod_1(ref Scenario scenario_0, Dictionary<string, Class310> dictionary_0, bool bool_17)
		{
			if (this.activeUnit_0.bool_3)
			{
				bool flag = false;
				try
				{
					foreach (Mission mission in this.activeUnit_0.vmethod_7(false).method_35())
					{
						if (this.activeUnit_0.vmethod_101() == mission && mission.method_54())
						{
							try
							{
								foreach (Mission.Flight flight in mission.list_1)
								{
									if (!Information.IsNothing(flight.string_0) && Operators.CompareString(flight.string_0, this.string_0, false) == 0)
									{
										this.method_8(flight);
										flag = true;
										break;
									}
								}
							}
							finally
							{
								List<Mission.Flight>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							if (flag)
							{
								break;
							}
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
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00007E19 File Offset: 0x00006019
		public virtual void vmethod_2()
		{
			if (this.float_0 > 2f)
			{
				this.float_0 = 2f;
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00007E33 File Offset: 0x00006033
		public virtual bool vmethod_3()
		{
			return this.bool_14;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000A3E0C File Offset: 0x000A200C
		public virtual void vmethod_4(bool bool_17)
		{
			bool flag = bool_17 != this.bool_14;
			this.bool_14 = bool_17;
			if (flag)
			{
				if (this.bool_14)
				{
					this.method_0(true);
					return;
				}
				this.vmethod_6(null);
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00007E3B File Offset: 0x0000603B
		public virtual float? vmethod_5()
		{
			return this.nullable_6;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000A3E50 File Offset: 0x000A2050
		public virtual void vmethod_6(float? nullable_8)
		{
			bool flag;
			if (Information.IsNothing(nullable_8) && !Information.IsNothing(this.nullable_6))
			{
				flag = true;
			}
			if (!flag && !Information.IsNothing(nullable_8) && Information.IsNothing(this.nullable_6))
			{
				flag = true;
			}
			if (!flag)
			{
				float? num = nullable_8;
				float? num2 = this.nullable_6;
				if (((num != null & num2 != null) ? new bool?(num.GetValueOrDefault() != num2.GetValueOrDefault()) : null).GetValueOrDefault())
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()))
				{
					if (this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().vmethod_3())
					{
						nullable_8 = this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().vmethod_5();
					}
					else
					{
						nullable_8 = new float?(this.activeUnit_0.vmethod_65(false).method_147().vmethod_70());
					}
				}
				this.nullable_6 = nullable_8;
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00007E43 File Offset: 0x00006043
		public virtual GeoPoint vmethod_7()
		{
			return this.geoPoint_0;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00007E4B File Offset: 0x0000604B
		public virtual void vmethod_8(GeoPoint geoPoint_1)
		{
			this.geoPoint_0 = geoPoint_1;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x000A3F7C File Offset: 0x000A217C
		public void method_0(bool bool_17)
		{
			this.vmethod_8(new GeoPoint(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
			if (bool_17)
			{
				this.vmethod_6(new float?(this.activeUnit_0.vmethod_70()));
			}
			this.activeUnit_0.vmethod_87().vmethod_11(null);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000A3FF0 File Offset: 0x000A21F0
		public void method_1(float float_2)
		{
			try
			{
				if (Information.IsNothing(this.vmethod_7()))
				{
					this.vmethod_8(new GeoPoint(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
				}
				if (Information.IsNothing(this.vmethod_5()))
				{
					this.vmethod_6(new float?(this.activeUnit_0.vmethod_70()));
				}
				float? num = this.vmethod_5();
				if (((num != null) ? new bool?(num.GetValueOrDefault() <= 0f) : null).GetValueOrDefault() && !this.activeUnit_0.method_121())
				{
					this.activeUnit_0.vmethod_71((float)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), ActiveUnit.Throttle.Loiter, false));
					this.vmethod_6(new float?(this.activeUnit_0.vmethod_70()));
				}
				float num6;
				if (this.activeUnit_0.method_121())
				{
					ActiveUnit activeUnit = this.activeUnit_0.vmethod_65(false).method_147();
					if (Information.IsNothing(activeUnit))
					{
						return;
					}
					double num2 = activeUnit.vmethod_28(null);
					double num3 = activeUnit.vmethod_30(null);
					GeoPoint geoPoint;
					double num4 = (geoPoint = this.vmethod_7()).imethod_0();
					GeoPoint geoPoint2;
					double num5 = (geoPoint2 = this.vmethod_7()).imethod_2();
					Class411.smethod_1(num2, num3, ref num4, ref num5, (double)this.method_2().float_1, (double)this.method_2().method_1(this.activeUnit_0));
					geoPoint2.imethod_3(num5);
					geoPoint.imethod_1(num4);
					num6 = activeUnit.vmethod_9();
					if (activeUnit.vmethod_85().vmethod_3())
					{
						this.vmethod_6(activeUnit.vmethod_85().vmethod_5());
					}
					else
					{
						this.vmethod_6(new float?(activeUnit.vmethod_70()));
					}
				}
				else
				{
					if (this.vmethod_5() == null)
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						return;
					}
					if (this.method_4().Length == 0)
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						this.method_0(false);
						return;
					}
					if (Math.Abs(Class437.smethod_3(this.activeUnit_0.method_34(Enumerable.First<Waypoint>(this.method_4()).imethod_2(), Enumerable.First<Waypoint>(this.method_4()).imethod_0()), this.activeUnit_0.vmethod_9())) > 2f)
					{
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, this.activeUnit_0.method_34(this.method_4()[0].imethod_2(), this.method_4()[0].imethod_0()));
						this.method_0(false);
						return;
					}
					double num7 = (double)(this.vmethod_5().Value * (float_2 / 3600f));
					GeoPoint geoPoint3 = Enumerable.First<Waypoint>(this.method_4());
					num6 = Math2.smethod_17(this.vmethod_7().imethod_2(), this.vmethod_7().imethod_0(), geoPoint3.imethod_2(), geoPoint3.imethod_0());
					double num8 = this.vmethod_7().imethod_0();
					double num9 = this.vmethod_7().imethod_2();
					GeoPoint geoPoint2;
					double num5 = (geoPoint2 = this.vmethod_7()).imethod_0();
					GeoPoint geoPoint;
					double num4 = (geoPoint = this.vmethod_7()).imethod_2();
					Class411.smethod_1(num8, num9, ref num5, ref num4, num7, (double)num6);
					geoPoint.imethod_3(num4);
					geoPoint2.imethod_1(num5);
				}
				ActiveUnit_Kinematics.Enum33 enum33_ = this.activeUnit_0.vmethod_87().enum33_0;
				if (enum33_ != ActiveUnit_Kinematics.Enum33.const_0)
				{
					if (enum33_ == ActiveUnit_Kinematics.Enum33.const_1)
					{
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, num6);
						this.activeUnit_0.vmethod_71(Math.Max(2f, Math.Min((float)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), ActiveUnit.Throttle.Loiter, false), this.vmethod_5().Value - 1f)));
						this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_87().vmethod_41(this.activeUnit_0.vmethod_14(false), (float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))));
						if (this.activeUnit_0.method_25(this.vmethod_7().imethod_2(), this.vmethod_7().imethod_0()) > 6f)
						{
							this.activeUnit_0.vmethod_87().enum33_0 = ActiveUnit_Kinematics.Enum33.const_0;
						}
					}
				}
				else
				{
					this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.vmethod_7().imethod_2(), this.vmethod_7().imethod_0()));
					if (this.activeUnit_0.vmethod_93().method_8() != ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
					{
						this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
					}
					else if (this.activeUnit_0.vmethod_93().method_8() == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries && Operators.CompareString(this.activeUnit_0.scenario_0.method_54().string_0, this.activeUnit_0.vmethod_7(false).string_0, false) != 0)
					{
						this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
						this.method_0(false);
					}
					if (this.vmethod_18(this.vmethod_7().imethod_2(), this.vmethod_7().imethod_0(), float_2))
					{
						this.activeUnit_0.vmethod_87().enum33_0 = ActiveUnit_Kinematics.Enum33.const_1;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101419", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000A45B0 File Offset: 0x000A27B0
		public ActiveUnit_Navigator.Class216 method_2()
		{
			if (this.class216_0 == null)
			{
				this.class216_0 = new ActiveUnit_Navigator.Class216();
				if (this.activeUnit_0.vmethod_65(false) != null && this.activeUnit_0.vmethod_65(false).method_147() != null)
				{
					this.class216_0.orientationType_0 = ReferencePoint.OrientationType.Rotating;
					this.vmethod_25();
				}
			}
			return this.class216_0;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00007E54 File Offset: 0x00006054
		public void method_3(ActiveUnit_Navigator.Class216 class216_1)
		{
			this.class216_0 = class216_1;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000A460C File Offset: 0x000A280C
		public Waypoint[] method_4()
		{
			Waypoint[] result;
			if (this.activeUnit_0.method_122())
			{
				result = this.activeUnit_0.vmethod_65(false).vmethod_85().method_4();
			}
			else
			{
				result = this.waypoint_0;
			}
			return result;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00007E5D File Offset: 0x0000605D
		public void method_5(Waypoint[] waypoint_2)
		{
			this.waypoint_0 = waypoint_2;
			if (this.activeUnit_0.method_122())
			{
				this.activeUnit_0.vmethod_65(false).vmethod_85().method_5(waypoint_2);
			}
			this.double_8 = 0.0;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x000A4648 File Offset: 0x000A2848
		public Waypoint[] method_6()
		{
			Waypoint[] result;
			if (this.activeUnit_0.method_122())
			{
				result = this.activeUnit_0.vmethod_65(false).vmethod_85().method_6();
			}
			else
			{
				result = this.waypoint_1;
			}
			return result;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000A4684 File Offset: 0x000A2884
		public Mission.Flight method_7()
		{
			Mission.Flight result;
			if (this.activeUnit_0.method_122())
			{
				result = this.activeUnit_0.vmethod_65(false).vmethod_85().method_7();
			}
			else
			{
				result = this.flight_0;
			}
			return result;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00007E99 File Offset: 0x00006099
		public void method_8(Mission.Flight flight_1)
		{
			this.flight_0 = flight_1;
			if (this.activeUnit_0.method_122())
			{
				this.activeUnit_0.vmethod_65(false).vmethod_85().method_8(flight_1);
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000A46C0 File Offset: 0x000A28C0
		public ActiveUnit_Navigator(ref ActiveUnit activeUnit_1)
		{
			this.waypoint_0 = new Waypoint[0];
			this.waypoint_1 = new Waypoint[0];
			this.bool_3 = false;
			this.nullable_0 = null;
			this.int_0 = 0;
			this.double_9 = 0.0;
			this.bool_13 = true;
			this.bool_16 = false;
			this.activeUnit_0 = activeUnit_1;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x000A472C File Offset: 0x000A292C
		public virtual void vmethod_9()
		{
			if (this.activeUnit_0.method_122())
			{
				this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_9();
				return;
			}
			Class429.smethod_38(ref this.waypoint_0);
			Class429.smethod_38(ref this.waypoint_1);
			if (!this.activeUnit_0.bool_1)
			{
				Class522.smethod_7(this.activeUnit_0, null);
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x000A478C File Offset: 0x000A298C
		public virtual void vmethod_10()
		{
			if (this.activeUnit_0.method_122())
			{
				this.activeUnit_0.vmethod_65(false).vmethod_85().vmethod_10();
				return;
			}
			this.method_8(null);
			if (this.activeUnit_0.vmethod_85().method_47())
			{
				foreach (Waypoint waypoint in this.activeUnit_0.vmethod_85().method_4())
				{
					if (waypoint.enum79_0 == Waypoint.Enum79.const_1)
					{
						waypoint.enum79_0 = Waypoint.Enum79.const_0;
					}
					waypoint.waypointType_0 = Waypoint.WaypointType.ManualPlottedCourseWaypoint;
				}
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x000A4810 File Offset: 0x000A2A10
		public Waypoint method_9(double double_11, double double_12, ref List<ActiveUnit> list_1)
		{
			Waypoint waypoint = null;
			int num = 1;
			for (;;)
			{
				int num2 = 0;
				double num3;
				double num4;
				do
				{
					Class411.smethod_1(double_12, double_11, ref num3, ref num4, (double)num, (double)num2);
					Unit unit = this.activeUnit_0;
					double num5 = num4;
					double num6 = num3;
					int num7 = 0;
					bool flag = true;
					bool flag2 = true;
					bool flag3 = false;
					bool flag4 = true;
					bool flag5 = true;
					bool flag6 = true;
					float? nullable_ = null;
					short? nullable_2 = null;
					float float_ = 0f;
					bool bool_ = false;
					bool bool_2 = false;
					string text = "";
					bool flag7 = false;
					if (unit.vmethod_47(num5, num6, ref num7, flag, flag2, flag3, ref flag4, flag5, ref flag6, nullable_, nullable_2, ref list_1, float_, bool_, bool_2, ref text, ref flag7))
					{
						goto Block_1;
					}
					num2++;
				}
				while (num2 <= 359);
				IL_84:
				if (!Information.IsNothing(waypoint))
				{
					break;
				}
				num++;
				if (num <= 10000)
				{
					continue;
				}
				break;
				Block_1:
				waypoint = new Waypoint(num3, num4, 0f, Waypoint.WaypointType.ManualPlottedCourseWaypoint, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0);
				goto IL_84;
			}
			return waypoint;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x000A48C0 File Offset: 0x000A2AC0
		public bool method_10(double double_11, double double_12, ref double double_13, ref double double_14, bool bool_17, bool bool_18, bool bool_19, float float_2, ref List<ActiveUnit> list_1, bool bool_20)
		{
			int num = 1;
			for (;;)
			{
				int num2 = 0;
				do
				{
					Class411.smethod_1(double_12, double_11, ref double_14, ref double_13, (double)num, (double)num2);
					Unit unit = this.activeUnit_0;
					double num3 = double_13;
					double num4 = double_14;
					int num5 = 0;
					bool flag = true;
					bool flag2 = false;
					bool flag3 = true;
					float? nullable_ = null;
					short? nullable_2 = null;
					bool bool_21 = false;
					string text = "";
					bool flag4 = false;
					if (unit.vmethod_47(num3, num4, ref num5, bool_17, bool_18, bool_19, ref flag, flag2, ref flag3, nullable_, nullable_2, ref list_1, float_2, bool_20, bool_21, ref text, ref flag4))
					{
						goto Block_1;
					}
					num2++;
				}
				while (num2 <= 359);
				num++;
				if (num > 10000)
				{
					goto IL_84;
				}
			}
			Block_1:
			return true;
			IL_84:
			return false;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x000A4954 File Offset: 0x000A2B54
		public void method_11(float float_2)
		{
			try
			{
				if (this.activeUnit_0.method_5())
				{
					this.bool_1 = false;
				}
				else
				{
					ref float ptr = ref this.float_0;
					this.float_0 = ptr - float_2;
					if (this.float_0 <= 0f && this.activeUnit_0.scenario_0.SecondIsChangingOnThisPulse)
					{
						ActiveUnit activeUnit = this.activeUnit_0;
						Mission.Flight flight = null;
						Exception ex = null;
						if (!Class522.smethod_8(activeUnit, flight, ref ex))
						{
							this.bool_1 = true;
						}
						if (this.activeUnit_0.bool_3)
						{
							this.float_0 = (float)GameGeneral.smethod_5().Next(30, 61);
						}
						else if (this.activeUnit_0.method_5())
						{
							this.float_0 = float.MaxValue;
						}
						else if (this.activeUnit_0.bool_8)
						{
							this.float_0 = (float)GameGeneral.smethod_5().Next(180, 361);
						}
						else
						{
							this.float_0 = (float)GameGeneral.smethod_5().Next(360, 721);
						}
						if (this.activeUnit_0.vmethod_59() && (this.activeUnit_0.bool_6 || this.activeUnit_0.bool_5) && !Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.MineClearing)
						{
							Class341 @class = (Class341)this.activeUnit_0.vmethod_101();
							if (!Information.IsNothing(@class) && this.activeUnit_0.vmethod_85().method_40(ref @class.list_5, ref @class.list_12, ref @class.list_8, 5, false, false))
							{
								this.float_0 = (float)GameGeneral.smethod_5().Next(10, 16);
							}
						}
					}
					else
					{
						this.bool_1 = false;
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100201", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000A4B4C File Offset: 0x000A2D4C
		public bool method_12(double double_11, double double_12, float float_2, float float_3, float float_4)
		{
			bool result;
			try
			{
				if (this.activeUnit_0.vmethod_40() == 0f)
				{
					result = false;
				}
				else
				{
					float num = Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), double_11, double_12);
					if (Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_9(), num)) < 1f)
					{
						result = false;
					}
					else
					{
						float num2 = this.activeUnit_0.method_25(double_11, double_12);
						float num3;
						if (this.activeUnit_0.bool_2)
						{
							float_2 = 0f;
							num3 = 0f;
						}
						else
						{
							num3 = Math.Min(this.activeUnit_0.vmethod_40() / (3600f / float_2), float_3 * 2f);
						}
						if (float_3 > 0f && num2 < float_3 + num3)
						{
							result = true;
						}
						else
						{
							float num4 = Misc.smethod_59(this.activeUnit_0.vmethod_40(), float_4);
							if (num2 > num4 * 2f)
							{
								result = false;
							}
							else
							{
								float num5;
								float num6;
								if (this.activeUnit_0.bool_2)
								{
									num5 = Math2.smethod_7(this.activeUnit_0.vmethod_9() - 135f);
									num6 = Math2.smethod_7(this.activeUnit_0.vmethod_9() + 135f);
								}
								else
								{
									num5 = Math2.smethod_7(this.activeUnit_0.vmethod_9() - 90f);
									num6 = Math2.smethod_7(this.activeUnit_0.vmethod_9() + 90f);
								}
								double num7;
								double num8;
								Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref num7, ref num8, (double)(num4 + num3 + float_3), (double)num5);
								if (Math2.smethod_15(num8, num7, double_11, double_12) < num4 + num3 + float_3)
								{
									result = true;
								}
								else
								{
									double num9;
									double num10;
									Class411.smethod_1(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), ref num9, ref num10, (double)(num4 + float_3 + float_3), (double)num6);
									if (Math2.smethod_15(num10, num9, double_11, double_12) < num4 + float_3 + float_3)
									{
										result = true;
									}
									else
									{
										result = false;
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101258", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x000A4DCC File Offset: 0x000A2FCC
		public virtual void vmethod_11(float float_2, ref Waypoint waypoint_2, double double_11, double double_12, float float_3, float float_4, float float_5)
		{
			try
			{
				bool flag;
				if (this.double_10 > 0.0)
				{
					flag = true;
				}
				else if (flag = this.method_12(double_11, double_12, float_3, float_4, float_5))
				{
					this.double_10 = 5.0;
				}
				if (flag)
				{
					if (this.activeUnit_0.bool_3 && this.method_32() && !Information.IsNothing(waypoint_2) && !waypoint_2.method_39() && !waypoint_2.method_45() && ((waypoint_2.waypointType_0 != Waypoint.WaypointType.Target && waypoint_2.waypointType_0 != Waypoint.WaypointType.WeaponTarget) || this.activeUnit_0.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.None))
					{
						float float_6 = 1f;
						bool flag2 = true;
						bool flag3 = false;
						this.vmethod_19(float_6, ref flag2, ref flag3);
						this.double_10 = 0.0;
					}
					else if (!Information.IsNothing(waypoint_2) && waypoint_2.waypointType_0 == Waypoint.WaypointType.PathfindingPoint)
					{
						float float_7 = 1f;
						bool flag3 = true;
						bool flag2 = false;
						this.vmethod_19(float_7, ref flag3, ref flag2);
						this.double_10 = 0.0;
					}
					else
					{
						float float_8 = Math2.smethod_17(double_11, double_12, this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null));
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, float_8);
						ref double ptr = ref this.double_10;
						this.double_10 = ptr - (double)float_2;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100202", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x000A4F70 File Offset: 0x000A3170
		public bool method_13(float float_2)
		{
			bool result;
			try
			{
				Class344 @class = (Class344)this.activeUnit_0.vmethod_101();
				if (@class.enum108_0 == Class344.Enum108.const_0)
				{
					result = false;
				}
				else if (Information.IsNothing(this.referencePoint_0))
				{
					result = false;
				}
				else if (!this.vmethod_18(this.referencePoint_0.imethod_2(), this.referencePoint_0.imethod_0(), float_2))
				{
					result = false;
				}
				else if (@class.list_5.IndexOf(this.referencePoint_0) == @class.list_5.Count - 1)
				{
					this.referencePoint_0 = null;
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100203", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x000A504C File Offset: 0x000A324C
		public virtual void vmethod_12(float float_2, bool bool_17)
		{
			try
			{
				if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Strike && !this.activeUnit_0.vmethod_86().bool_2)
				{
					Doctrine.Enum64? @enum = this.activeUnit_0.doctrine_0.method_83(this.activeUnit_0.scenario_0, false, null, false, false);
					byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
					bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 0) : null;
					if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
					{
						this.activeUnit_0.doctrine_0.method_84(this.activeUnit_0.scenario_0, false, null, false, false, new Doctrine.Enum64?(Doctrine.Enum64.const_0));
					}
				}
				List<Waypoint> list = Enumerable.ToList<Waypoint>(this.method_4());
				List<Waypoint> list2 = new List<Waypoint>();
				try
				{
					foreach (Waypoint waypoint in list)
					{
						if (waypoint.waypointType_0 == Waypoint.WaypointType.PathfindingPoint)
						{
							list2.Add(waypoint);
						}
						else if (waypoint.waypointType_0 == Waypoint.WaypointType.InitialPoint || waypoint.waypointType_0 == Waypoint.WaypointType.WeaponLaunch || waypoint.waypointType_0 == Waypoint.WaypointType.Target || waypoint.waypointType_0 == Waypoint.WaypointType.WeaponTarget || waypoint.waypointType_0 == Waypoint.WaypointType.StrikeIngress)
						{
							this.method_34(waypoint);
							this.method_35(waypoint);
							list2.Add(waypoint);
							this.method_14(ref waypoint);
						}
					}
				}
				finally
				{
					List<Waypoint>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (Waypoint waypoint_ in list2)
					{
						this.method_53(waypoint_, false);
					}
				}
				finally
				{
					List<Waypoint>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				if (this.activeUnit_0.vmethod_85().method_48())
				{
					this.activeUnit_0.vmethod_85().method_7().method_11(this.activeUnit_0.scenario_0, Mission.Enum102.const_8);
				}
				this.vmethod_17(float_2);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101371", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x000A52E8 File Offset: 0x000A34E8
		public void method_14(ref Waypoint waypoint_2)
		{
			if (Information.IsNothing(this.nullable_0))
			{
				this.int_0 = 0;
				return;
			}
			if (this.int_0 == -98)
			{
				if (waypoint_2.method_39())
				{
					this.nullable_0 = null;
					this.int_0 = 0;
				}
			}
			else if (this.int_0 == -97)
			{
				if (waypoint_2.method_43())
				{
					this.nullable_0 = null;
					this.int_0 = 0;
				}
			}
			else if (this.int_0 == -99)
			{
				if (waypoint_2.waypointType_0 == Waypoint.WaypointType.LandingMarshal || waypoint_2.waypointType_0 == Waypoint.WaypointType.Land)
				{
					this.nullable_0 = null;
					this.int_0 = 0;
				}
			}
			else if (Enumerable.Count<Waypoint>(this.method_4()) > 0)
			{
				ref int ptr = ref this.int_0;
				this.int_0 = ptr - 1;
			}
			else
			{
				this.int_0 = 0;
			}
			if (this.activeUnit_0.method_122())
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
					{
						if (activeUnit != this.activeUnit_0 && !activeUnit.vmethod_85().method_47())
						{
							activeUnit.vmethod_85().nullable_0 = this.nullable_0;
							activeUnit.vmethod_85().int_0 = this.int_0;
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
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000A544C File Offset: 0x000A364C
		public virtual bool vmethod_13(float float_2)
		{
			bool result;
			try
			{
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101372", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x000A54A8 File Offset: 0x000A36A8
		public bool method_15()
		{
			bool result;
			if (this.activeUnit_0.vmethod_101() == null)
			{
				result = false;
			}
			else if (this.activeUnit_0.vmethod_101()._MissionClass_0 != Mission._MissionClass.Support)
			{
				result = false;
			}
			else
			{
				Class344 @class = (Class344)this.activeUnit_0.vmethod_101();
				if (Information.IsNothing(@class.list_5))
				{
					result = false;
				}
				else if (@class.list_5.Count == 0)
				{
					result = false;
				}
				else
				{
					bool flag;
					if (this.activeUnit_0.bool_3)
					{
						flag = !this.method_40(ref @class.list_5, ref @class.list_10, ref @class.list_9, 10, false, false);
					}
					else
					{
						flag = !this.method_40(ref @class.list_5, ref @class.list_8, ref @class.list_7, 2, false, false);
					}
					if (this.activeUnit_0.method_85())
					{
						flag = true;
					}
					result = flag;
				}
			}
			return result;
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x000A5580 File Offset: 0x000A3780
		public virtual void vmethod_14(float float_2, bool bool_17)
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0.vmethod_101()))
				{
					if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support)
					{
						Class344 @class = (Class344)this.activeUnit_0.vmethod_101();
						if (!Information.IsNothing(@class))
						{
							if (!Information.IsNothing(@class.list_5))
							{
								if (@class.list_5.Count != 0)
								{
									if (Information.IsNothing(this.referencePoint_0))
									{
										this.referencePoint_0 = @class.list_5[0];
									}
									else if (!@class.list_5.Contains(this.referencePoint_0))
									{
										this.referencePoint_0 = @class.list_5[0];
									}
									if (this.vmethod_18(this.referencePoint_0.imethod_2(), this.referencePoint_0.imethod_0(), float_2))
									{
										if (@class.list_5.IndexOf(this.referencePoint_0) == @class.list_5.Count - 1)
										{
											if (@class.enum108_0 == Class344.Enum108.const_0)
											{
												this.referencePoint_0 = @class.list_5[0];
											}
											else if (@class.enum108_0 == Class344.Enum108.const_1)
											{
												this.referencePoint_0 = null;
												if (this.activeUnit_0.bool_3)
												{
													this.activeUnit_0.vmethod_92().vmethod_7(false, ActiveUnit._ActiveUnitStatus.RTB_MissionOver, true, ActiveUnit._ActiveUnitStatus.RTB_Group, false, true);
												}
												else
												{
													this.activeUnit_0.vmethod_93().method_5(false, ActiveUnit._ActiveUnitStatus.RTB_MissionOver, true, ActiveUnit._ActiveUnitStatus.RTB_Group, false, true);
												}
											}
										}
										else
										{
											this.referencePoint_0 = @class.list_5[@class.list_5.IndexOf(this.referencePoint_0) + 1];
										}
									}
									if (this.method_47())
									{
										this.vmethod_16(float_2);
									}
									else if (!Information.IsNothing(this.referencePoint_0))
									{
										this.method_19(this.referencePoint_0);
										Waypoint waypoint = null;
										this.vmethod_11(float_2, ref waypoint, this.referencePoint_0.imethod_2(), this.referencePoint_0.imethod_0(), 0f, 0f, this.activeUnit_0.vmethod_87().vmethod_49());
									}
									if (!this.activeUnit_0.bool_3 && this.activeUnit_0.vmethod_87().vmethod_10() == null)
									{
										if (bool_17)
										{
											if (this.activeUnit_0.bool_5)
											{
												if (!Information.IsNothing(@class.throttle_0))
												{
													this.activeUnit_0.vmethod_134(@class.throttle_0, null);
												}
												else
												{
													this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
												}
											}
											else if (this.activeUnit_0.bool_6)
											{
												if (!Information.IsNothing(@class.throttle_2))
												{
													this.activeUnit_0.vmethod_134(@class.throttle_2, null);
												}
												else
												{
													this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
												}
											}
											else
											{
												this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
											}
										}
										else if (this.activeUnit_0.bool_5)
										{
											if (!Information.IsNothing(@class.throttle_1))
											{
												this.activeUnit_0.vmethod_134(@class.throttle_1, null);
											}
											else
											{
												this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
											}
										}
										else if (this.activeUnit_0.bool_6)
										{
											if (!Information.IsNothing(@class.throttle_3))
											{
												this.activeUnit_0.vmethod_134(@class.throttle_3, null);
											}
											else
											{
												this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
											}
										}
										else
										{
											this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
										}
									}
									if (this.activeUnit_0.bool_5)
									{
										int value = (int)this.activeUnit_0.doctrine_0.method_258(this.activeUnit_0.scenario_0, false, false, false).Value;
										Submarine_AI submarine_AI = ((Submarine)this.activeUnit_0).method_153();
										if (!submarine_AI.method_124((float)value, false, false) && !this.activeUnit_0.vmethod_87().vmethod_12())
										{
											if (bool_17)
											{
												if (@class.nullable_8 != null)
												{
													float value2 = @class.nullable_8.Value;
													if (Math.Round((double)value2) >= -20.0 && !submarine_AI.method_122(false, null))
													{
														this.activeUnit_0.vmethod_73(-40f);
													}
													else
													{
														this.activeUnit_0.vmethod_73(value2);
													}
												}
											}
											else if (@class.nullable_9 != null)
											{
												float value3 = @class.nullable_9.Value;
												if (Math.Round((double)value3) >= -20.0 && !submarine_AI.method_122(false, null))
												{
													this.activeUnit_0.vmethod_73(-40f);
												}
												else
												{
													this.activeUnit_0.vmethod_73(value3);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100204", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x000A5AC4 File Offset: 0x000A3CC4
		public virtual void vmethod_15(float float_2, bool bool_17)
		{
			try
			{
				if (this.activeUnit_0.vmethod_101() != null)
				{
					if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
					{
						Class343 @class = (Class343)this.activeUnit_0.vmethod_101();
						if (@class.list_5 != null)
						{
							if (@class.list_5.Count != 0)
							{
								if (this.referencePoint_0 == null)
								{
									this.referencePoint_0 = @class.list_5[0];
								}
								else if (!@class.list_5.Contains(this.referencePoint_0))
								{
									this.referencePoint_0 = @class.list_5[0];
								}
								if (this.vmethod_18(this.referencePoint_0.imethod_2(), this.referencePoint_0.imethod_0(), float_2))
								{
									if (@class.list_5.IndexOf(this.referencePoint_0) == @class.list_5.Count - 1)
									{
										this.referencePoint_0 = @class.list_5[0];
									}
									else
									{
										this.referencePoint_0 = @class.list_5[@class.list_5.IndexOf(this.referencePoint_0) + 1];
									}
								}
								if (this.method_47())
								{
									this.vmethod_16(float_2);
								}
								else if (this.referencePoint_0 != null)
								{
									this.method_19(this.referencePoint_0);
									Waypoint waypoint = null;
									this.vmethod_11(float_2, ref waypoint, this.referencePoint_0.imethod_2(), this.referencePoint_0.imethod_0(), 0f, 0f, this.activeUnit_0.vmethod_87().vmethod_49());
								}
								if (!this.activeUnit_0.bool_3 && this.activeUnit_0.vmethod_87().vmethod_10() == null)
								{
									if (bool_17)
									{
										if (this.activeUnit_0.bool_5)
										{
											this.activeUnit_0.vmethod_134(@class.imethod_20(), null);
										}
										else if (this.activeUnit_0.bool_6)
										{
											this.activeUnit_0.vmethod_134(@class.imethod_34(), null);
										}
										else
										{
											this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
										}
									}
									else if (this.activeUnit_0.bool_5)
									{
										this.activeUnit_0.vmethod_134(@class.imethod_22(), null);
									}
									else if (this.activeUnit_0.bool_6)
									{
										this.activeUnit_0.vmethod_134(@class.imethod_36(), null);
									}
									else
									{
										this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Loiter, null);
									}
								}
								if (this.activeUnit_0.bool_5)
								{
									int value = (int)this.activeUnit_0.doctrine_0.method_258(this.activeUnit_0.scenario_0, false, false, false).Value;
									Submarine_AI submarine_AI = ((Submarine)this.activeUnit_0).method_153();
									if (!submarine_AI.method_124((float)value, false, false) && !this.activeUnit_0.vmethod_87().vmethod_12())
									{
										if (bool_17)
										{
											if (@class.imethod_26() != null)
											{
												float value2 = @class.imethod_26().Value;
												if (Math.Round((double)value2) >= -20.0 && !submarine_AI.method_122(false, null))
												{
													this.activeUnit_0.vmethod_73(-40f);
												}
												else
												{
													this.activeUnit_0.vmethod_73(value2);
												}
											}
										}
										else if (@class.imethod_28() != null)
										{
											float value3 = @class.imethod_28().Value;
											if (Math.Round((double)value3) >= -20.0 && !submarine_AI.method_122(false, null))
											{
												this.activeUnit_0.vmethod_73(-40f);
											}
											else
											{
												this.activeUnit_0.vmethod_73(value3);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 10324509326043132845904329", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x000A5EE0 File Offset: 0x000A40E0
		public void method_16(Waypoint waypoint_2, ActiveUnit activeUnit_1, Mission.Flight flight_1, bool bool_17, float float_2, double double_11, double double_12, Scenario scenario_0, bool bool_18)
		{
			ActiveUnit_Navigator.Class217 @class = new ActiveUnit_Navigator.Class217();
			@class.waypoint_0 = waypoint_2;
			@class.activeUnit_0 = activeUnit_1;
			@class.flight_0 = flight_1;
			@class.bool_0 = bool_17;
			@class.float_0 = float_2;
			@class.double_0 = double_11;
			@class.double_1 = double_12;
			@class.scenario_0 = scenario_0;
			@class.bool_1 = bool_18;
			bool isAttached = Debugger.IsAttached;
			try
			{
				if (Class522.smethod_9() && !Class522.bool_0)
				{
					Task.Factory.StartNew(new Action(@class.method_0));
				}
				if (Information.IsNothing(@class.activeUnit_0) || @class.activeUnit_0.vmethod_84() != ActiveUnit.Throttle.FullStop || @class.activeUnit_0.vmethod_40() != 0f)
				{
					if (this.bool_1 || !Information.IsNothing(@class.flight_0))
					{
						Exception expression = null;
						if (!Class522.smethod_8(@class.activeUnit_0, @class.flight_0, ref expression) && Information.IsNothing(expression))
						{
							Task.Factory.StartNew(new Action(@class.method_1));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100205", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x000A6028 File Offset: 0x000A4228
		public void method_17(Waypoint waypoint_2, ActiveUnit activeUnit_1, Mission.Flight flight_1, bool bool_17, float float_2, double double_11, double double_12, Scenario scenario_0, bool bool_18)
		{
			this.bool_2 = true;
			try
			{
				this.vmethod_28(waypoint_2, activeUnit_1, flight_1, bool_17, float_2, double_11, double_12, bool_18);
				if (!Information.IsNothing(this.list_0) && !this.vmethod_26())
				{
					bool flag = false;
					bool bool_19 = !Information.IsNothing(flight_1);
					while (!flag)
					{
						if (scenario_0.ThreadedOpsMustStop)
						{
							this.bool_2 = false;
							return;
						}
						this.method_56(this.list_0, bool_19, float_2, ref flag, ref flight_1, ref bool_17);
					}
				}
				if (!Information.IsNothing(this.list_0))
				{
					int count = this.list_0.Count;
					if (Information.IsNothing(waypoint_2))
					{
						if (Information.IsNothing(flight_1))
						{
							int num = count - 1;
							for (int i = 0; i <= num; i++)
							{
								this.method_51(i, this.list_0[i]);
							}
						}
						else if (bool_17)
						{
							int num2 = count - 1;
							for (int j = 0; j <= num2; j++)
							{
								Mission.Flight flight = flight_1;
								Waypoint[] waypoint_3 = flight.method_18();
								ActiveUnit_Navigator.smethod_1(ref waypoint_3, j, this.list_0[j]);
								flight.method_19(waypoint_3);
							}
							flight_1.bool_14 = false;
						}
						else
						{
							int num3 = count - 1;
							for (int k = 0; k <= num3; k++)
							{
								Mission.Flight flight2 = flight_1;
								Waypoint[] waypoint_3 = flight2.method_22();
								ActiveUnit_Navigator.smethod_1(ref waypoint_3, k, this.list_0[k]);
								flight2.method_23(waypoint_3);
							}
							flight_1.bool_15 = false;
						}
					}
					else if (Information.IsNothing(flight_1))
					{
						int num4 = Array.IndexOf<Waypoint>(this.method_4(), waypoint_2);
						int num5 = count - 1;
						for (int l = 0; l <= num5; l++)
						{
							this.method_51(num4 + 1 + l, this.list_0[l]);
						}
					}
					else if (!bool_17)
					{
						int num6 = count - 1;
						for (int m = 0; m <= num6; m++)
						{
							Mission.Flight flight3 = flight_1;
							Waypoint[] waypoint_3 = flight3.method_22();
							ActiveUnit_Navigator.smethod_1(ref waypoint_3, m, this.list_0[m]);
							flight3.method_23(waypoint_3);
						}
						flight_1.bool_15 = false;
					}
				}
				if (Information.IsNothing(this.list_0) && Information.IsNothing(flight_1) && bool_18)
				{
					string text = "";
					if (this.activeUnit_0.bool_3 && Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
					{
						text = " (" + this.activeUnit_0.string_2 + ")";
					}
					string text2 = "";
					if (!Information.IsNothing(this.activeUnit_0.vmethod_86().vmethod_3()))
					{
						text2 = " (" + this.activeUnit_0.vmethod_86().vmethod_3().Name + ")";
					}
					this.activeUnit_0.method_124(string.Concat(new string[]
					{
						this.activeUnit_0.Name,
						text,
						" is dropping all targets from its target list (Reason: The navigator failed to plot a course to the primary target",
						text2,
						" , which means it is inaccessible. The unit will now re-build its target list based on current target availability and accessability)."
					}), this.activeUnit_0.Name + " dropping all targets", LoggedMessage.MessageType.UnitAI, 5, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
					this.activeUnit_0.vmethod_86().method_33(ref this.activeUnit_0);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200330", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			this.bool_2 = false;
			if (this.float_0 < 300f)
			{
				this.float_0 = 300f;
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x000A63EC File Offset: 0x000A45EC
		public virtual void vmethod_16(float float_2)
		{
			if (!this.activeUnit_0.vmethod_86().bool_4)
			{
				try
				{
					if (Enumerable.Count<Waypoint>(this.method_4()) != 0)
					{
						if (this.bool_1 && !this.bool_2)
						{
							if (!this.method_44())
							{
								if (this.vmethod_29(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.method_4()[0].imethod_2(), this.method_4()[0].imethod_0(), true, 0f, true, null, true, false, false, new float?(Class522.interface9_1.imethod_1())))
								{
									this.method_16(null, this.activeUnit_0, null, false, 0.15f, this.method_4()[0].imethod_2(), this.method_4()[0].imethod_0(), this.activeUnit_0.scenario_0, false);
								}
							}
							else if (Enumerable.Count<Waypoint>(this.method_4()) > 1 && this.method_4()[0].waypointType_0 == Waypoint.WaypointType.PathfindingPoint)
							{
								if (this.vmethod_29(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.method_4()[0].imethod_2(), this.method_4()[0].imethod_0(), true, 0f, true, null, true, false, false, new float?(Class522.interface9_1.imethod_1())))
								{
									this.method_16(null, this.activeUnit_0, null, false, 0.15f, this.method_4()[0].imethod_2(), this.method_4()[0].imethod_0(), this.activeUnit_0.scenario_0, false);
								}
								if (!this.vmethod_29(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.method_4()[1].imethod_2(), this.method_4()[1].imethod_0(), true, 0f, false, null, true, false, true, new float?(Class522.interface9_1.imethod_1())))
								{
									if (this.activeUnit_0.bool_3)
									{
										this.method_53(this.method_4()[0], false);
									}
									else if (Math2.smethod_14(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.method_4()[0].imethod_2(), this.method_4()[0].imethod_0()) < 0.05)
									{
										this.method_53(this.method_4()[0], false);
									}
								}
							}
						}
						this.vmethod_17(float_2);
						bool flag = false;
						bool flag2 = false;
						this.vmethod_19(float_2, ref flag, ref flag2);
						if (this.activeUnit_0.vmethod_87().vmethod_10() == null)
						{
							if (this.activeUnit_0.bool_3 && this.activeUnit_0.vmethod_84() <= ActiveUnit.Throttle.Cruise)
							{
								this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
							}
							else if (this.activeUnit_0.bool_3 && this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()))
							{
								this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_65(false).method_147().vmethod_84(), null);
							}
							else if (this.activeUnit_0.bool_5 && this.activeUnit_0.vmethod_84() <= ActiveUnit.Throttle.Cruise && ((Submarine)this.activeUnit_0).vmethod_93().method_8() != ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
							{
								this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
							}
							else if (this.activeUnit_0.bool_6 && this.activeUnit_0.vmethod_84() <= ActiveUnit.Throttle.Cruise)
							{
								this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Cruise, null);
							}
							else if (this.activeUnit_0.method_121() && !Information.IsNothing(this.activeUnit_0.vmethod_65(false).method_147()))
							{
								this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_65(false).method_147().vmethod_84(), null);
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200321", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x000A689C File Offset: 0x000A4A9C
		public void method_18()
		{
			try
			{
				List<Waypoint> list = new List<Waypoint>();
				foreach (Waypoint waypoint in this.method_4())
				{
					if (waypoint.waypointType_0 == Waypoint.WaypointType.PathfindingPoint)
					{
						list.Add(waypoint);
					}
				}
				try
				{
					foreach (Waypoint waypoint_ in list)
					{
						this.method_53(waypoint_, false);
					}
				}
				finally
				{
					List<Waypoint>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100208", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x000A6964 File Offset: 0x000A4B64
		public void method_19(GeoPoint geoPoint_1)
		{
			try
			{
				if (!this.method_44() && !this.bool_2 && !this.bool_2)
				{
					if (this.activeUnit_0.vmethod_85().bool_1 && this.vmethod_29(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), geoPoint_1.imethod_2(), geoPoint_1.imethod_0(), true, 0f, true, null, true, false, true, new float?(Class522.interface9_1.imethod_1())))
					{
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), geoPoint_1.imethod_2(), geoPoint_1.imethod_0()));
						this.method_16(null, this.activeUnit_0, null, false, 0.15f, geoPoint_1.imethod_2(), geoPoint_1.imethod_0(), this.activeUnit_0.scenario_0, false);
					}
					else if (this.method_44())
					{
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.method_4()[0].imethod_2(), this.method_4()[0].imethod_0()));
					}
					else
					{
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), geoPoint_1.imethod_2(), geoPoint_1.imethod_0()));
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100209", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x000A6B74 File Offset: 0x000A4D74
		protected virtual void vmethod_17(float float_2)
		{
			try
			{
				if (!this.activeUnit_0.vmethod_85().vmethod_3())
				{
					Waypoint[] array = this.method_4();
					if (array.Length > 0)
					{
						Waypoint waypoint = array[0];
						this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_0, this.activeUnit_0.method_34(waypoint.imethod_2(), waypoint.imethod_0()));
						this.vmethod_11(float_2, ref waypoint, waypoint.imethod_2(), waypoint.imethod_0(), 0f, 0f, this.activeUnit_0.vmethod_87().vmethod_49());
					}
					else
					{
						this.bool_0 = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100210", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x000A6C4C File Offset: 0x000A4E4C
		public bool method_20()
		{
			bool result;
			try
			{
				if (this.activeUnit_0.vmethod_101() == null)
				{
					result = false;
				}
				else if (this.activeUnit_0.vmethod_101()._MissionClass_0 != Mission._MissionClass.Patrol)
				{
					result = false;
				}
				else
				{
					Class343 @class = (Class343)this.activeUnit_0.vmethod_101();
					if (this.activeUnit_0.bool_3)
					{
						result = this.method_40(ref @class.list_5, ref @class.list_13, ref @class.list_9, 10, false, false);
					}
					else
					{
						result = this.method_40(ref @class.list_5, ref @class.list_11, ref @class.list_7, 2, false, false);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100211", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x000A6D2C File Offset: 0x000A4F2C
		public bool method_21()
		{
			bool result;
			if (!this.method_47())
			{
				result = false;
			}
			else if (this.activeUnit_0.vmethod_86().bool_2)
			{
				result = false;
			}
			else
			{
				Waypoint.WaypointType waypointType_ = this.method_4()[0].waypointType_0;
				switch (waypointType_)
				{
				case Waypoint.WaypointType.PathfindingPoint:
				case Waypoint.WaypointType.TurningPoint:
				case Waypoint.WaypointType.Refuel:
					foreach (Waypoint waypoint in this.method_4())
					{
						if (waypoint.waypointType_0 != Waypoint.WaypointType.TurningPoint && waypoint.waypointType_0 != Waypoint.WaypointType.Refuel && waypoint.waypointType_0 != Waypoint.WaypointType.PathfindingPoint)
						{
							Waypoint.WaypointType waypointType_2 = waypoint.waypointType_0;
							if (waypointType_2 <= Waypoint.WaypointType.WeaponLaunch)
							{
								switch (waypointType_2)
								{
								case Waypoint.WaypointType.Assemble:
								case Waypoint.WaypointType.InitialPoint:
								case Waypoint.WaypointType.Split:
								case Waypoint.WaypointType.Target:
								case Waypoint.WaypointType.StrikeIngress:
									goto IL_11E;
								case Waypoint.WaypointType.TurningPoint:
								case Waypoint.WaypointType.Formate:
								case Waypoint.WaypointType.LandingMarshal:
									break;
								default:
									if (waypointType_2 == Waypoint.WaypointType.WeaponLaunch)
									{
										goto IL_11E;
									}
									break;
								}
							}
							else if (waypointType_2 == Waypoint.WaypointType.WeaponTarget || waypointType_2 - Waypoint.WaypointType.HoldStart <= 1)
							{
								goto IL_11E;
							}
							return false;
							IL_11E:
							return true;
						}
					}
					return false;
				case Waypoint.WaypointType.Assemble:
				case Waypoint.WaypointType.InitialPoint:
				case Waypoint.WaypointType.Split:
				case Waypoint.WaypointType.Target:
				case Waypoint.WaypointType.StrikeIngress:
				case Waypoint.WaypointType.WeaponLaunch:
				case Waypoint.WaypointType.WeaponTarget:
					goto IL_126;
				case Waypoint.WaypointType.Formate:
				case Waypoint.WaypointType.LandingMarshal:
				case Waypoint.WaypointType.StrikeEgress:
				case Waypoint.WaypointType.TakeOff:
				case Waypoint.WaypointType.Marshal:
				case Waypoint.WaypointType.Land:
					break;
				default:
					if (waypointType_ - Waypoint.WaypointType.HoldStart <= 1)
					{
						goto IL_126;
					}
					break;
				}
				return false;
				IL_126:
				result = true;
			}
			return result;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x000A6E64 File Offset: 0x000A5064
		public bool method_22()
		{
			bool result;
			if (!this.method_47())
			{
				result = false;
			}
			else if (this.activeUnit_0.vmethod_86().bool_2)
			{
				result = false;
			}
			else
			{
				Waypoint.WaypointType waypointType_ = this.method_4()[0].waypointType_0;
				if (waypointType_ > Waypoint.WaypointType.TurningPoint)
				{
					if (waypointType_ != Waypoint.WaypointType.Target)
					{
						if (waypointType_ == Waypoint.WaypointType.Refuel)
						{
							goto IL_59;
						}
						if (waypointType_ != Waypoint.WaypointType.WeaponTarget)
						{
							goto IL_55;
						}
					}
					return true;
				}
				if (waypointType_ == Waypoint.WaypointType.PathfindingPoint || waypointType_ == Waypoint.WaypointType.TurningPoint)
				{
					goto IL_59;
				}
				IL_55:
				return false;
				IL_59:
				foreach (Waypoint waypoint in this.method_4())
				{
					if (waypoint.waypointType_0 != Waypoint.WaypointType.TurningPoint && waypoint.waypointType_0 != Waypoint.WaypointType.Refuel && waypoint.waypointType_0 != Waypoint.WaypointType.PathfindingPoint)
					{
						Waypoint.WaypointType waypointType_2 = waypoint.waypointType_0;
						if (waypointType_2 != Waypoint.WaypointType.Target)
						{
							if (waypointType_2 != Waypoint.WaypointType.WeaponTarget)
							{
								return false;
							}
						}
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000A6F2C File Offset: 0x000A512C
		public bool method_23()
		{
			checked
			{
				bool result;
				if (!this.method_47())
				{
					result = false;
				}
				else if (this.activeUnit_0.vmethod_86().bool_2)
				{
					result = false;
				}
				else
				{
					switch (this.method_4()[0].waypointType_0)
					{
					case Waypoint.WaypointType.PathfindingPoint:
					case Waypoint.WaypointType.TurningPoint:
					case Waypoint.WaypointType.Refuel:
					{
						Waypoint[] array = this.method_4();
						int i = 0;
						while (i < array.Length)
						{
							Waypoint waypoint = array[i];
							if (waypoint.waypointType_0 != Waypoint.WaypointType.TurningPoint && waypoint.waypointType_0 != Waypoint.WaypointType.Refuel && waypoint.waypointType_0 != Waypoint.WaypointType.PathfindingPoint)
							{
								switch (waypoint.waypointType_0)
								{
								case Waypoint.WaypointType.Formate:
								case Waypoint.WaypointType.LandingMarshal:
								case Waypoint.WaypointType.StrikeEgress:
									return true;
								default:
									return false;
								}
							}
							else
							{
								i++;
							}
						}
						result = false;
						break;
					}
					default:
						result = false;
						break;
					case Waypoint.WaypointType.Formate:
					case Waypoint.WaypointType.LandingMarshal:
					case Waypoint.WaypointType.StrikeEgress:
						result = true;
						break;
					}
				}
				return result;
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x000A7018 File Offset: 0x000A5218
		public bool method_24()
		{
			bool result;
			if (!this.method_47())
			{
				result = false;
			}
			else if (this.activeUnit_0.vmethod_86().bool_2)
			{
				result = false;
			}
			else
			{
				Waypoint.WaypointType waypointType_ = this.method_4()[0].waypointType_0;
				if (waypointType_ <= Waypoint.WaypointType.TurningPoint)
				{
					if (waypointType_ == Waypoint.WaypointType.PathfindingPoint || waypointType_ == Waypoint.WaypointType.TurningPoint)
					{
						goto IL_52;
					}
				}
				else
				{
					if (waypointType_ == Waypoint.WaypointType.LandingMarshal)
					{
						return true;
					}
					if (waypointType_ == Waypoint.WaypointType.Refuel)
					{
						goto IL_52;
					}
				}
				return false;
				IL_52:
				foreach (Waypoint waypoint in this.method_4())
				{
					if (waypoint.waypointType_0 != Waypoint.WaypointType.TurningPoint && waypoint.waypointType_0 != Waypoint.WaypointType.Refuel && waypoint.waypointType_0 != Waypoint.WaypointType.PathfindingPoint)
					{
						Waypoint.WaypointType waypointType_2 = waypoint.waypointType_0;
						return waypointType_2 == Waypoint.WaypointType.LandingMarshal;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000A70D0 File Offset: 0x000A52D0
		public bool method_25()
		{
			bool result;
			if (!this.method_47())
			{
				result = false;
			}
			else
			{
				Waypoint.WaypointType waypointType_ = this.method_4()[0].waypointType_0;
				if (waypointType_ <= Waypoint.WaypointType.TurningPoint)
				{
					if (waypointType_ == Waypoint.WaypointType.PathfindingPoint || waypointType_ == Waypoint.WaypointType.TurningPoint)
					{
						goto IL_44;
					}
				}
				else
				{
					if (waypointType_ == Waypoint.WaypointType.LandingMarshal)
					{
						return false;
					}
					if (waypointType_ == Waypoint.WaypointType.Refuel)
					{
						goto IL_44;
					}
					if (waypointType_ - Waypoint.WaypointType.StationStart_Racetrack <= 4)
					{
						return true;
					}
				}
				return false;
				IL_44:
				foreach (Waypoint waypoint in this.method_4())
				{
					if (waypoint.waypointType_0 != Waypoint.WaypointType.TurningPoint && waypoint.waypointType_0 != Waypoint.WaypointType.Refuel && waypoint.waypointType_0 != Waypoint.WaypointType.PathfindingPoint)
					{
						Waypoint.WaypointType waypointType_2 = waypoint.waypointType_0;
						return waypointType_2 != Waypoint.WaypointType.LandingMarshal && waypointType_2 - Waypoint.WaypointType.StationStart_Racetrack <= 4;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x000A7188 File Offset: 0x000A5388
		public bool method_26()
		{
			bool result;
			if (!this.method_47())
			{
				result = false;
			}
			else
			{
				Waypoint.WaypointType waypointType_ = this.method_4()[0].waypointType_0;
				result = (waypointType_ == Waypoint.WaypointType.Assemble || waypointType_ - Waypoint.WaypointType.HoldStart <= 1);
			}
			return result;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x000A71C4 File Offset: 0x000A53C4
		public bool method_27()
		{
			bool result;
			if (!this.method_47())
			{
				result = false;
			}
			else
			{
				Waypoint.WaypointType waypointType_ = this.method_4()[0].waypointType_0;
				if (waypointType_ <= Waypoint.WaypointType.TurningPoint)
				{
					if (waypointType_ != Waypoint.WaypointType.PathfindingPoint && waypointType_ != Waypoint.WaypointType.TurningPoint)
					{
						return false;
					}
				}
				else
				{
					if (waypointType_ == Waypoint.WaypointType.LandingMarshal)
					{
						return true;
					}
					if (waypointType_ != Waypoint.WaypointType.Refuel)
					{
						return false;
					}
				}
				foreach (Waypoint waypoint in this.method_4())
				{
					if (waypoint.waypointType_0 != Waypoint.WaypointType.TurningPoint && waypoint.waypointType_0 != Waypoint.WaypointType.Refuel && waypoint.waypointType_0 != Waypoint.WaypointType.PathfindingPoint)
					{
						Waypoint.WaypointType waypointType_2 = waypoint.waypointType_0;
						return waypointType_2 == Waypoint.WaypointType.LandingMarshal;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x000A7268 File Offset: 0x000A5468
		public bool method_28()
		{
			bool result;
			if (!this.method_47())
			{
				result = false;
			}
			else
			{
				Waypoint.WaypointType waypointType_ = this.method_4()[0].waypointType_0;
				result = (waypointType_ - Waypoint.WaypointType.StationStart_Racetrack <= 4);
			}
			return result;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000A72A0 File Offset: 0x000A54A0
		public bool method_29()
		{
			checked
			{
				bool result;
				if (!this.method_47())
				{
					result = false;
				}
				else
				{
					if (!this.activeUnit_0.vmethod_86().bool_2)
					{
						switch (this.method_4()[0].waypointType_0)
						{
						case Waypoint.WaypointType.Split:
							return true;
						case Waypoint.WaypointType.Formate:
						case Waypoint.WaypointType.Target:
						case Waypoint.WaypointType.LandingMarshal:
						case Waypoint.WaypointType.StrikeIngress:
						case Waypoint.WaypointType.StrikeEgress:
						case Waypoint.WaypointType.WeaponTarget:
							return false;
						}
						bool flag = false;
						Waypoint[] array = this.method_4();
						int i = 0;
						while (i < array.Length)
						{
							Waypoint waypoint = array[i];
							if (waypoint.waypointType_0 != Waypoint.WaypointType.Formate && waypoint.waypointType_0 != Waypoint.WaypointType.StrikeIngress)
							{
								if (waypoint.waypointType_0 != Waypoint.WaypointType.StrikeEgress)
								{
									i++;
									continue;
								}
							}
							flag = true;
							IL_BF:
							if (this.method_4()[0].waypointType_0 != Waypoint.WaypointType.InitialPoint)
							{
								if (this.method_4()[0].waypointType_0 != Waypoint.WaypointType.WeaponLaunch)
								{
									foreach (Waypoint waypoint2 in this.method_4())
									{
										if (waypoint2.waypointType_0 != Waypoint.WaypointType.TurningPoint && waypoint2.waypointType_0 != Waypoint.WaypointType.Refuel && waypoint2.waypointType_0 != Waypoint.WaypointType.PathfindingPoint)
										{
											switch (waypoint2.waypointType_0)
											{
											case Waypoint.WaypointType.InitialPoint:
											case Waypoint.WaypointType.WeaponLaunch:
												return !flag;
											case Waypoint.WaypointType.Split:
												return true;
											case Waypoint.WaypointType.Formate:
											case Waypoint.WaypointType.Target:
											case Waypoint.WaypointType.LandingMarshal:
											case Waypoint.WaypointType.StrikeIngress:
											case Waypoint.WaypointType.StrikeEgress:
											case Waypoint.WaypointType.WeaponTarget:
												return false;
											}
											IL_184:
											return false;
										}
									}
									goto IL_184;
								}
							}
							return !flag;
						}
						goto IL_BF;
					}
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x000A7448 File Offset: 0x000A5648
		public bool method_30()
		{
			bool result;
			if (!this.method_47())
			{
				result = false;
			}
			else if (Information.IsNothing(this.nullable_5))
			{
				result = false;
			}
			else if (this.activeUnit_0.vmethod_86().bool_2)
			{
				result = false;
			}
			else
			{
				Waypoint.WaypointType? waypointType = this.nullable_5;
				int? num = (waypointType != null) ? new int?((int)waypointType.GetValueOrDefault()) : null;
				bool? flag2;
				bool? flag = flag2 = ((num != null) ? new bool?(num.GetValueOrDefault() == 13) : null);
				bool? flag3;
				bool? flag4;
				if (flag2 != null && flag.GetValueOrDefault())
				{
					flag3 = new bool?(true);
				}
				else
				{
					num = ((waypointType != null) ? new int?((int)waypointType.GetValueOrDefault()) : null);
					flag4 = (flag2 = ((num != null) ? new bool?(num.GetValueOrDefault() == 9) : null));
					flag3 = ((flag2 != null) ? (flag | flag4.GetValueOrDefault()) : null);
				}
				flag4 = flag3;
				if (flag4.GetValueOrDefault())
				{
					result = true;
				}
				else
				{
					num = ((waypointType != null) ? new int?((int)waypointType.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 11) : null).GetValueOrDefault())
					{
						result = true;
					}
					else
					{
						num = ((waypointType != null) ? new int?((int)waypointType.GetValueOrDefault()) : null);
						bool? flag5;
						flag2 = (flag5 = ((num != null) ? new bool?(num.GetValueOrDefault() == 6) : null));
						bool? flag6;
						bool? flag7;
						if (flag5 != null && flag2.GetValueOrDefault())
						{
							flag6 = new bool?(true);
						}
						else
						{
							num = ((waypointType != null) ? new int?((int)waypointType.GetValueOrDefault()) : null);
							flag7 = (flag5 = ((num != null) ? new bool?(num.GetValueOrDefault() == 14) : null));
							flag6 = ((flag5 != null) ? (flag2 | flag7.GetValueOrDefault()) : null);
						}
						flag4 = (flag7 = flag6);
						bool? flag8;
						if (flag7 != null && flag4.GetValueOrDefault())
						{
							flag8 = new bool?(true);
						}
						else
						{
							num = ((waypointType != null) ? new int?((int)waypointType.GetValueOrDefault()) : null);
							flag = (flag7 = ((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null));
							flag8 = ((flag7 != null) ? (flag4 | flag.GetValueOrDefault()) : null);
						}
						flag = flag8;
						if (flag.GetValueOrDefault())
						{
							foreach (Waypoint waypoint in this.method_4())
							{
								if (waypoint.waypointType_0 != Waypoint.WaypointType.TurningPoint && waypoint.waypointType_0 != Waypoint.WaypointType.Refuel && waypoint.waypointType_0 != Waypoint.WaypointType.PathfindingPoint)
								{
									switch (waypoint.waypointType_0)
									{
									case Waypoint.WaypointType.Formate:
									case Waypoint.WaypointType.StrikeEgress:
										return true;
									case Waypoint.WaypointType.LandingMarshal:
										return true;
									}
									return false;
								}
							}
							result = false;
						}
						else
						{
							result = false;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x000A77D4 File Offset: 0x000A59D4
		public bool method_31()
		{
			checked
			{
				bool result;
				if (!this.method_47())
				{
					result = false;
				}
				else
				{
					Waypoint[] array = this.method_4();
					int i = 0;
					while (i < array.Length)
					{
						Waypoint.WaypointType waypointType_ = array[i].waypointType_0;
						if (waypointType_ != Waypoint.WaypointType.InitialPoint)
						{
							switch (waypointType_)
							{
							case Waypoint.WaypointType.Target:
							case Waypoint.WaypointType.WeaponLaunch:
							case Waypoint.WaypointType.WeaponTarget:
								break;
							default:
								i++;
								continue;
							case Waypoint.WaypointType.StationStart_Racetrack:
							case Waypoint.WaypointType.StationStart_FigureEight:
							case Waypoint.WaypointType.StationStart_Area:
							case Waypoint.WaypointType.StationStart_RaceTrackRandom:
							case Waypoint.WaypointType.StationEnd:
								return true;
							}
						}
						return true;
					}
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x000A7860 File Offset: 0x000A5A60
		public bool method_32()
		{
			checked
			{
				bool result;
				if (!this.method_47())
				{
					result = false;
				}
				else
				{
					Waypoint[] array = this.method_4();
					for (int i = 0; i < array.Length; i++)
					{
						switch (array[i].waypointType_0)
						{
						case Waypoint.WaypointType.PathfindingPoint:
						case Waypoint.WaypointType.TurningPoint:
						case Waypoint.WaypointType.Refuel:
							foreach (Waypoint waypoint in this.method_4())
							{
								if (waypoint.waypointType_0 != Waypoint.WaypointType.TurningPoint && waypoint.waypointType_0 != Waypoint.WaypointType.Refuel && waypoint.waypointType_0 != Waypoint.WaypointType.PathfindingPoint)
								{
									switch (waypoint.waypointType_0)
									{
									case Waypoint.WaypointType.Assemble:
									case Waypoint.WaypointType.InitialPoint:
									case Waypoint.WaypointType.Split:
									case Waypoint.WaypointType.Formate:
									case Waypoint.WaypointType.Target:
									case Waypoint.WaypointType.LandingMarshal:
									case Waypoint.WaypointType.StrikeIngress:
									case Waypoint.WaypointType.StrikeEgress:
									case Waypoint.WaypointType.WeaponLaunch:
									case Waypoint.WaypointType.WeaponTarget:
									case Waypoint.WaypointType.HoldStart:
									case Waypoint.WaypointType.HoldEnd:
										return true;
									case Waypoint.WaypointType.StationStart_Racetrack:
									case Waypoint.WaypointType.StationStart_FigureEight:
									case Waypoint.WaypointType.StationStart_Area:
									case Waypoint.WaypointType.StationStart_RaceTrackRandom:
									case Waypoint.WaypointType.StationEnd:
										return true;
									}
									return false;
								}
							}
							break;
						case Waypoint.WaypointType.Assemble:
						case Waypoint.WaypointType.InitialPoint:
						case Waypoint.WaypointType.Split:
						case Waypoint.WaypointType.Formate:
						case Waypoint.WaypointType.Target:
						case Waypoint.WaypointType.LandingMarshal:
						case Waypoint.WaypointType.StrikeIngress:
						case Waypoint.WaypointType.StrikeEgress:
						case Waypoint.WaypointType.WeaponLaunch:
						case Waypoint.WaypointType.WeaponTarget:
						case Waypoint.WaypointType.HoldStart:
						case Waypoint.WaypointType.HoldEnd:
							return true;
						case Waypoint.WaypointType.StationStart_Racetrack:
						case Waypoint.WaypointType.StationStart_FigureEight:
						case Waypoint.WaypointType.StationStart_Area:
						case Waypoint.WaypointType.StationStart_RaceTrackRandom:
						case Waypoint.WaypointType.StationEnd:
							return true;
						}
					}
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00007EC6 File Offset: 0x000060C6
		public bool method_33(GeoPoint geoPoint_1, float float_2)
		{
			return this.vmethod_18(geoPoint_1.imethod_2(), geoPoint_1.imethod_0(), float_2);
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x000A79D8 File Offset: 0x000A5BD8
		public virtual bool vmethod_18(double double_11, double double_12, float float_2)
		{
			bool result;
			try
			{
				if (this.activeUnit_0.method_30(ref double_11, ref double_12) > Misc.double_0)
				{
					result = false;
				}
				else
				{
					float num = Math2.smethod_15(double_11, double_12, this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null));
					if (this.activeUnit_0.vmethod_40() == 0f && this.activeUnit_0.vmethod_70() == 0f && (double)num < 0.01)
					{
						result = true;
					}
					else
					{
						float num2 = this.activeUnit_0.vmethod_40() / 3600f;
						if (num < num2 * 2f)
						{
							result = true;
						}
						else
						{
							result = false;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100212", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x000A7AD8 File Offset: 0x000A5CD8
		public virtual void vmethod_19(float float_2, ref bool bool_17, ref bool bool_18)
		{
			try
			{
				if (Enumerable.Count<Waypoint>(this.method_4()) != 0)
				{
					Waypoint geoPoint_ = this.method_4()[0];
					if (this.method_33(geoPoint_, float_2))
					{
						this.method_34(this.method_4()[0]);
						this.method_35(this.method_4()[0]);
						this.method_53(this.method_4()[0], false);
						if (Enumerable.Count<Waypoint>(this.method_4()) > 0)
						{
							this.vmethod_17(float_2);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100213", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x000A7B94 File Offset: 0x000A5D94
		public void method_34(Waypoint waypoint_2)
		{
			if (!Information.IsNothing(this.activeUnit_0))
			{
				try
				{
					this.activeUnit_0.vmethod_86().nullable_0 = null;
					this.activeUnit_0.vmethod_86().bool_7 = false;
					if (this.activeUnit_0.bool_3 && this.activeUnit_0.method_121() && Enumerable.Count<Waypoint>(this.activeUnit_0.vmethod_85().method_4()) == 1)
					{
						this.activeUnit_0.vmethod_87().vmethod_11(null);
						this.activeUnit_0.vmethod_87().vmethod_13(false);
						this.activeUnit_0.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.None);
					}
					else
					{
						if (waypoint_2.method_27() != null && waypoint_2.nullable_0 != null)
						{
							this.activeUnit_0.vmethod_71(waypoint_2.nullable_0.Value);
							this.activeUnit_0.vmethod_87().vmethod_11(new float?(this.activeUnit_0.vmethod_70()));
							this.activeUnit_0.vmethod_87().vmethod_2(ActiveUnit_Kinematics.UnitThrottlePreset.None);
						}
						else if (waypoint_2.method_35() != ActiveUnit_Kinematics.UnitThrottlePreset.None)
						{
							this.activeUnit_0.vmethod_87().vmethod_2(waypoint_2.method_35());
							this.activeUnit_0.vmethod_71((float)this.activeUnit_0.vmethod_87().vmethod_40(this.activeUnit_0.vmethod_14(false), (ActiveUnit.Throttle)this.activeUnit_0.vmethod_87().vmethod_1(), false));
							this.activeUnit_0.vmethod_87().vmethod_11(new float?(this.activeUnit_0.vmethod_70()));
						}
						if (waypoint_2.method_29())
						{
							if (this.activeUnit_0.bool_5)
							{
								((Submarine)this.activeUnit_0).method_153().method_115(waypoint_2.method_33());
							}
							if (this.activeUnit_0.bool_3)
							{
								((Aircraft)this.activeUnit_0).method_158().method_115(waypoint_2.method_31());
							}
							this.activeUnit_0.vmethod_87().vmethod_13(waypoint_2.method_29());
							if (waypoint_2.method_31() != ActiveUnit_AI.AircraftAltitudePreset.None && this.activeUnit_0.bool_3)
							{
								((Aircraft)this.activeUnit_0).method_158().vmethod_27();
							}
							else if (waypoint_2.method_33() != ActiveUnit_AI.SubmarineDepthPreset.None && this.activeUnit_0.bool_5)
							{
								((Submarine)this.activeUnit_0).method_153().vmethod_28(true);
							}
							else if ((this.activeUnit_0.bool_3 || this.activeUnit_0.bool_5) && waypoint_2.nullable_1 != null)
							{
								this.activeUnit_0.vmethod_73(waypoint_2.nullable_1.Value);
								float num = this.activeUnit_0.vmethod_87().vmethod_30();
								float num2 = this.activeUnit_0.vmethod_87().vmethod_31();
								if (this.activeUnit_0.vmethod_72() > num)
								{
									this.activeUnit_0.vmethod_73(num);
								}
								else if (this.activeUnit_0.vmethod_72() < num2)
								{
									this.activeUnit_0.vmethod_73(num2);
								}
							}
							if ((this.activeUnit_0.bool_3 || this.activeUnit_0.bool_5) && waypoint_2.nullable_2 != null && waypoint_2.method_37())
							{
								this.activeUnit_0.vmethod_75(waypoint_2.nullable_2.Value);
							}
							if (this.activeUnit_0.bool_3)
							{
								if (waypoint_2.nullable_2 != null)
								{
									this.activeUnit_0.vmethod_77(this.activeUnit_0, waypoint_2.method_37());
								}
								else
								{
									this.activeUnit_0.vmethod_77(this.activeUnit_0, false);
								}
							}
						}
					}
					this.activeUnit_0.vmethod_79(ActiveUnit.Enum28.const_1);
					if (!Information.IsNothing(this.activeUnit_0.vmethod_85().method_7()) && Enumerable.Count<Waypoint>(this.activeUnit_0.vmethod_85().method_4()) > 1)
					{
						this.activeUnit_0.vmethod_81(waypoint_2.enum81_0);
						if (!this.activeUnit_0.method_122())
						{
							goto IL_499;
						}
						try
						{
							foreach (ActiveUnit activeUnit in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
							{
								if (!activeUnit.vmethod_85().method_47())
								{
									activeUnit.vmethod_81(waypoint_2.enum81_0);
								}
							}
							goto IL_499;
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
					this.activeUnit_0.vmethod_81(Waypoint.Enum81.const_2);
					if (this.activeUnit_0.method_122())
					{
						try
						{
							foreach (ActiveUnit activeUnit2 in this.activeUnit_0.vmethod_65(false).vmethod_141().Values)
							{
								if (!activeUnit2.vmethod_85().method_47())
								{
									activeUnit2.vmethod_81(Waypoint.Enum81.const_2);
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
					}
					IL_499:
					if (!Information.IsNothing(waypoint_2.nullable_4))
					{
						this.activeUnit_0.vmethod_85().vmethod_4(waypoint_2.nullable_4.Value);
						bool? flag = waypoint_2.nullable_4;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							this.activeUnit_0.vmethod_85().vmethod_6(null);
						}
						else
						{
							bool? flag2;
							flag = (flag2 = waypoint_2.nullable_4);
							if (((flag2 == null || flag.GetValueOrDefault()) ? (flag & !Information.IsNothing(waypoint_2.nullable_5)) : new bool?(false)).GetValueOrDefault())
							{
								this.activeUnit_0.vmethod_85().vmethod_6(waypoint_2.nullable_5);
							}
						}
					}
					if (!Information.IsNothing(waypoint_2.nullable_6))
					{
						this.activeUnit_0.vmethod_85().bool_15 = waypoint_2.nullable_6.Value;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100216", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x000A81CC File Offset: 0x000A63CC
		public void method_35(Waypoint waypoint_2)
		{
			if (!Information.IsNothing(this.activeUnit_0))
			{
				try
				{
					ActiveUnit activeUnit;
					if (this.activeUnit_0.method_122())
					{
						try
						{
							IEnumerator<ActiveUnit> enumerator = this.activeUnit_0.vmethod_65(false).vmethod_141().Values.GetEnumerator();
							while (enumerator.MoveNext())
							{
								activeUnit = enumerator.Current;
								if (activeUnit == this.activeUnit_0)
								{
									this.method_36(activeUnit, waypoint_2);
								}
								else if (!activeUnit.vmethod_85().method_47())
								{
									this.method_36(activeUnit, waypoint_2);
								}
							}
							goto IL_8E;
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
					activeUnit = this.activeUnit_0;
					this.method_36(activeUnit, waypoint_2);
					IL_8E:;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101305", "");
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x000A82B4 File Offset: 0x000A64B4
		private void method_36(ActiveUnit activeUnit_1, Waypoint waypoint_2)
		{
			if (waypoint_2.method_17())
			{
				try
				{
					Doctrine doctrine = waypoint_2.method_18();
					if (doctrine.method_33())
					{
						activeUnit_1.doctrine_0.method_32(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine.Enum65? @enum = doctrine.method_31(activeUnit_1.scenario_0, false, false, false);
						byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 3) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_32(activeUnit_1.scenario_0, false, false, false, doctrine.method_31(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_65())
					{
						activeUnit_1.doctrine_0.method_64(activeUnit_1.scenario_0, false, new bool?(false), false, false, null);
					}
					else
					{
						Doctrine.Enum52? enum2 = doctrine.method_63(activeUnit_1.scenario_0, false, new bool?(false), false, false);
						byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 4) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_64(activeUnit_1.scenario_0, false, new bool?(false), false, false, doctrine.method_63(activeUnit_1.scenario_0, false, new bool?(false), false, false));
						}
					}
					if (doctrine.method_80())
					{
						activeUnit_1.doctrine_0.method_79(activeUnit_1.scenario_0, false, new bool?(false), false, false, null);
					}
					else
					{
						Doctrine.Enum52? enum2 = doctrine.method_78(activeUnit_1.scenario_0, false, new bool?(false), false, false);
						byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 4) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_79(activeUnit_1.scenario_0, false, new bool?(false), false, false, doctrine.method_78(activeUnit_1.scenario_0, false, new bool?(false), false, false));
						}
					}
					if (doctrine.method_70())
					{
						activeUnit_1.doctrine_0.method_69(activeUnit_1.scenario_0, false, new bool?(false), false, false, null);
					}
					else
					{
						Doctrine.Enum52? enum2 = doctrine.method_68(activeUnit_1.scenario_0, false, new bool?(false), false, false);
						byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 4) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_69(activeUnit_1.scenario_0, false, new bool?(false), false, false, doctrine.method_68(activeUnit_1.scenario_0, false, new bool?(false), false, false));
						}
					}
					if (doctrine.method_75())
					{
						activeUnit_1.doctrine_0.method_74(activeUnit_1.scenario_0, false, new bool?(false), false, false, null);
					}
					else
					{
						Doctrine.Enum52? enum2 = doctrine.method_73(activeUnit_1.scenario_0, false, new bool?(false), false, false);
						byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 4) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_74(activeUnit_1.scenario_0, false, new bool?(false), false, false, doctrine.method_73(activeUnit_1.scenario_0, false, new bool?(false), false, false));
						}
					}
					if (doctrine.method_149())
					{
						activeUnit_1.doctrine_0.method_148(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = doctrine.method_147(activeUnit_1.scenario_0, false, false, false);
						byte? b = (gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 3) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_148(activeUnit_1.scenario_0, false, false, false, doctrine.method_147(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_85())
					{
						activeUnit_1.doctrine_0.method_84(activeUnit_1.scenario_0, false, new bool?(false), false, false, null);
					}
					else
					{
						Doctrine.Enum64? enum3 = doctrine.method_83(activeUnit_1.scenario_0, false, new bool?(false), false, false);
						byte? b = (enum3 != null) ? new byte?((byte)enum3.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 3) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_84(activeUnit_1.scenario_0, false, new bool?(false), false, false, doctrine.method_83(activeUnit_1.scenario_0, false, new bool?(false), false, false));
						}
					}
					if (doctrine.method_90())
					{
						activeUnit_1.doctrine_0.method_89(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine.Enum51? enum4 = doctrine.method_88(activeUnit_1.scenario_0, false, false, false);
						byte? b = (enum4 != null) ? new byte?((byte)enum4.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 4) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_89(activeUnit_1.scenario_0, false, false, false, doctrine.method_88(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_139())
					{
						activeUnit_1.doctrine_0.method_138(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine.Enum61? enum5 = doctrine.method_137(activeUnit_1.scenario_0, false, false, false);
						byte? b = (enum5 != null) ? new byte?((byte)enum5.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 3) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_138(activeUnit_1.scenario_0, false, false, false, doctrine.method_137(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_144())
					{
						activeUnit_1.doctrine_0.method_143(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine.Enum62? enum6 = doctrine.method_142(activeUnit_1.scenario_0, false, false, false);
						byte? b = (enum6 != null) ? new byte?((byte)enum6.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 3) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_143(activeUnit_1.scenario_0, false, false, false, doctrine.method_142(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_154())
					{
						activeUnit_1.doctrine_0.method_153(activeUnit_1.scenario_0, false, false, false, false, null);
					}
					else
					{
						Doctrine.Enum56? enum7 = doctrine.method_152(activeUnit_1.scenario_0, false, false, false, false);
						byte? b = (enum7 != null) ? new byte?((byte)enum7.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 4) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_153(activeUnit_1.scenario_0, false, false, false, false, doctrine.method_152(activeUnit_1.scenario_0, false, false, false, false));
						}
					}
					if (doctrine.method_159())
					{
						activeUnit_1.doctrine_0.method_158(activeUnit_1.scenario_0, false, false, false, false, null);
					}
					else
					{
						Doctrine.Enum57? enum8 = doctrine.method_157(activeUnit_1.scenario_0, false, false, false, false);
						byte? b = (enum8 != null) ? new byte?((byte)enum8.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 4) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_158(activeUnit_1.scenario_0, false, false, false, false, doctrine.method_157(activeUnit_1.scenario_0, false, false, false, false));
						}
					}
					if (doctrine.method_164())
					{
						activeUnit_1.doctrine_0.method_163(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine.Enum59? enum9 = doctrine.method_162(activeUnit_1.scenario_0, false, false, false);
						byte? b = (enum9 != null) ? new byte?((byte)enum9.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 3) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_163(activeUnit_1.scenario_0, false, false, false, doctrine.method_162(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_169())
					{
						activeUnit_1.doctrine_0.method_168(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine.Enum58? enum10 = doctrine.method_167(activeUnit_1.scenario_0, false, false, false);
						byte? b = (enum10 != null) ? new byte?((byte)enum10.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 3) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_168(activeUnit_1.scenario_0, false, false, false, doctrine.method_167(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_174())
					{
						activeUnit_1.doctrine_0.method_173(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine.Enum60? enum11 = doctrine.method_172(activeUnit_1.scenario_0, false, false, false);
						byte? b = (enum11 != null) ? new byte?((byte)enum11.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 3) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_173(activeUnit_1.scenario_0, false, false, false, doctrine.method_172(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_198())
					{
						activeUnit_1.doctrine_0.method_197(activeUnit_1.scenario_0, false, false, false, false, null);
					}
					else
					{
						Doctrine.Enum53? enum12 = doctrine.method_196(activeUnit_1.scenario_0, false, false, false, false);
						byte? b = (enum12 != null) ? new byte?((byte)enum12.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 4) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_197(activeUnit_1.scenario_0, false, false, false, false, doctrine.method_196(activeUnit_1.scenario_0, false, false, false, false));
						}
					}
					if (doctrine.method_203())
					{
						activeUnit_1.doctrine_0.method_202(activeUnit_1.scenario_0, false, false, false, false, null);
					}
					else
					{
						Doctrine.Enum54? enum13 = doctrine.method_201(activeUnit_1.scenario_0, false, false, false, false);
						byte? b = (enum13 != null) ? new byte?((byte)enum13.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 3) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_202(activeUnit_1.scenario_0, false, false, false, false, doctrine.method_201(activeUnit_1.scenario_0, false, false, false, false));
						}
					}
					if (doctrine.method_213())
					{
						activeUnit_1.doctrine_0.method_212(activeUnit_1.scenario_0, false, false, false, false, null);
					}
					else
					{
						Doctrine._WeaponState? weaponState = doctrine.method_211(activeUnit_1.scenario_0, false, false, false, false);
						int? num = (weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null;
						bool? flag = (num != null) ? new bool?(num.GetValueOrDefault() == 2) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_212(activeUnit_1.scenario_0, false, false, false, false, doctrine.method_211(activeUnit_1.scenario_0, false, false, false, false));
						}
					}
					if (doctrine.method_119())
					{
						activeUnit_1.doctrine_0.method_118(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._WeaponStateRTB? weaponStateRTB = doctrine.method_117(activeUnit_1.scenario_0, false, false, false);
						byte? b = (weaponStateRTB != null) ? new byte?((byte)weaponStateRTB.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 5) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_118(activeUnit_1.scenario_0, false, false, false, doctrine.method_117(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_208())
					{
						activeUnit_1.doctrine_0.method_207(activeUnit_1.scenario_0, false, false, false, false, null);
					}
					else
					{
						Doctrine._FuelState? fuelState = doctrine.method_206(activeUnit_1.scenario_0, false, false, false, false);
						byte? b = (fuelState != null) ? new byte?((byte)fuelState.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 14) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_207(activeUnit_1.scenario_0, false, false, false, false, doctrine.method_206(activeUnit_1.scenario_0, false, false, false, false));
						}
					}
					if (doctrine.method_124())
					{
						activeUnit_1.doctrine_0.method_123(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._FuelStateRTB? fuelStateRTB = doctrine.method_122(activeUnit_1.scenario_0, false, false, false);
						byte? b = (fuelStateRTB != null) ? new byte?((byte)fuelStateRTB.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 5) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_123(activeUnit_1.scenario_0, false, false, false, doctrine.method_122(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_129())
					{
						activeUnit_1.doctrine_0.method_128(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._JettisonOrdnance? jettisonOrdnance = doctrine.method_127(activeUnit_1.scenario_0, false, false, false);
						byte? b = (jettisonOrdnance != null) ? new byte?((byte)jettisonOrdnance.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 3) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_128(activeUnit_1.scenario_0, false, false, false, doctrine.method_127(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_134())
					{
						activeUnit_1.doctrine_0.method_133(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._BVRLogicEnum? bvrlogicEnum = doctrine.method_132(activeUnit_1.scenario_0, false, false, false);
						byte? b = (bvrlogicEnum != null) ? new byte?((byte)bvrlogicEnum.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 4) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_133(activeUnit_1.scenario_0, false, false, false, doctrine.method_132(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_218())
					{
						activeUnit_1.doctrine_0.method_217(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine.Enum55? enum14 = doctrine.method_216(activeUnit_1.scenario_0, false, false, false);
						byte? b = (enum14 != null) ? new byte?((byte)enum14.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 4) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_217(activeUnit_1.scenario_0, false, false, false, doctrine.method_216(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_242())
					{
						activeUnit_1.doctrine_0.method_241(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._RefuelAlliedUnits? refuelAlliedUnits = doctrine.method_240(activeUnit_1.scenario_0, false, false, false);
						byte? b = (refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 5) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_241(activeUnit_1.scenario_0, false, false, false, doctrine.method_240(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_248())
					{
						activeUnit_1.doctrine_0.method_247(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._AvoidContactWhenPossible? avoidContactWhenPossible = doctrine.method_246(activeUnit_1.scenario_0, false, false, false);
						byte? b = (avoidContactWhenPossible != null) ? new byte?((byte)avoidContactWhenPossible.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 4) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_247(activeUnit_1.scenario_0, false, false, false, doctrine.method_246(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_254())
					{
						activeUnit_1.doctrine_0.method_253(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._DiveOnContact? diveOnContact = doctrine.method_252(activeUnit_1.scenario_0, false, false, false);
						byte? b = (diveOnContact != null) ? new byte?((byte)diveOnContact.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 5) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_253(activeUnit_1.scenario_0, false, false, false, doctrine.method_252(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_260())
					{
						activeUnit_1.doctrine_0.method_259(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage = doctrine.method_258(activeUnit_1.scenario_0, false, false, false);
						int? num = (rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null;
						bool? flag = (num != null) ? new bool?(num.GetValueOrDefault() == -101) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_259(activeUnit_1.scenario_0, false, false, false, doctrine.method_258(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_266())
					{
						activeUnit_1.doctrine_0.method_265(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._RechargeBatteryPercentage? rechargeBatteryPercentage = doctrine.method_264(activeUnit_1.scenario_0, false, false, false);
						int? num = (rechargeBatteryPercentage != null) ? new int?((int)rechargeBatteryPercentage.GetValueOrDefault()) : null;
						bool? flag = (num != null) ? new bool?(num.GetValueOrDefault() == -101) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_265(activeUnit_1.scenario_0, false, false, false, doctrine.method_264(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_272())
					{
						activeUnit_1.doctrine_0.method_271(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._UseAIP? useAIP = doctrine.method_270(activeUnit_1.scenario_0, false, false, false);
						byte? b = (useAIP != null) ? new byte?((byte)useAIP.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 4) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_271(activeUnit_1.scenario_0, false, false, false, doctrine.method_270(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_278())
					{
						activeUnit_1.doctrine_0.method_277(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._UseDippingSonar? useDippingSonar = doctrine.method_276(activeUnit_1.scenario_0, false, false, false);
						byte? b = (useDippingSonar != null) ? new byte?((byte)useDippingSonar.GetValueOrDefault()) : null;
						bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 3) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_277(activeUnit_1.scenario_0, false, false, false, doctrine.method_276(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_95())
					{
						activeUnit_1.doctrine_0.method_94(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._DamageThreshold? damageThreshold = doctrine.method_93(activeUnit_1.scenario_0, false, false, false);
						short? num2 = (damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null;
						bool? flag = (num2 != null) ? new bool?(num2.GetValueOrDefault() == 6) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_94(activeUnit_1.scenario_0, false, false, false, doctrine.method_93(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_98())
					{
						activeUnit_1.doctrine_0.method_97(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._FuelQuantityThreshold? fuelQuantityThreshold = doctrine.method_96(activeUnit_1.scenario_0, false, false, false);
						short? num2 = (fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null;
						bool? flag = (num2 != null) ? new bool?(num2.GetValueOrDefault() == 7) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_97(activeUnit_1.scenario_0, false, false, false, doctrine.method_96(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_101())
					{
						activeUnit_1.doctrine_0.method_100(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = doctrine.method_99(activeUnit_1.scenario_0, false, false, false);
						short? num2 = (weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null;
						bool? flag = (num2 != null) ? new bool?(num2.GetValueOrDefault() == 8) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_100(activeUnit_1.scenario_0, false, false, false, doctrine.method_99(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_104())
					{
						activeUnit_1.doctrine_0.method_103(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = doctrine.method_102(activeUnit_1.scenario_0, false, false, false);
						short? num2 = (weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null;
						bool? flag = (num2 != null) ? new bool?(num2.GetValueOrDefault() == 8) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_103(activeUnit_1.scenario_0, false, false, false, doctrine.method_102(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_80())
					{
						activeUnit_1.doctrine_0.method_79(activeUnit_1.scenario_0, false, new bool?(false), false, false, null);
					}
					else
					{
						Doctrine._DamageThreshold? damageThreshold = doctrine.method_105(activeUnit_1.scenario_0, false, false, false);
						short? num2 = (damageThreshold != null) ? new short?((short)damageThreshold.GetValueOrDefault()) : null;
						bool? flag = (num2 != null) ? new bool?(num2.GetValueOrDefault() == 6) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_106(activeUnit_1.scenario_0, false, false, false, doctrine.method_105(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_110())
					{
						activeUnit_1.doctrine_0.method_109(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._FuelQuantityThreshold? fuelQuantityThreshold = doctrine.method_108(activeUnit_1.scenario_0, false, false, false);
						short? num2 = (fuelQuantityThreshold != null) ? new short?((short)fuelQuantityThreshold.GetValueOrDefault()) : null;
						bool? flag = (num2 != null) ? new bool?(num2.GetValueOrDefault() == 7) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_109(activeUnit_1.scenario_0, false, false, false, doctrine.method_108(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_113())
					{
						activeUnit_1.doctrine_0.method_112(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = doctrine.method_111(activeUnit_1.scenario_0, false, false, false);
						short? num2 = (weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null;
						bool? flag = (num2 != null) ? new bool?(num2.GetValueOrDefault() == 8) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_112(activeUnit_1.scenario_0, false, false, false, doctrine.method_111(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (doctrine.method_116())
					{
						activeUnit_1.doctrine_0.method_115(activeUnit_1.scenario_0, false, false, false, null);
					}
					else
					{
						Doctrine._WeaponQuantityThreshold? weaponQuantityThreshold = doctrine.method_114(activeUnit_1.scenario_0, false, false, false);
						short? num2 = (weaponQuantityThreshold != null) ? new short?((short)weaponQuantityThreshold.GetValueOrDefault()) : null;
						bool? flag = (num2 != null) ? new bool?(num2.GetValueOrDefault() == 8) : null;
						if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							activeUnit_1.doctrine_0.method_115(activeUnit_1.scenario_0, false, false, false, doctrine.method_114(activeUnit_1.scenario_0, false, false, false));
						}
					}
					if (!doctrine.method_7())
					{
						if (doctrine.method_6(activeUnit_1.scenario_0).method_1() == Doctrine.Class275.Enum66.const_3 && doctrine.method_6(activeUnit_1.scenario_0).method_2() == Doctrine.Class275.Enum66.const_3 && doctrine.method_6(activeUnit_1.scenario_0).method_3() == Doctrine.Class275.Enum66.const_3)
						{
							activeUnit_1.doctrine_0.method_8(true);
						}
						else
						{
							if (doctrine.method_6(activeUnit_1.scenario_0).method_1() != Doctrine.Class275.Enum66.const_3)
							{
								activeUnit_1.doctrine_0.method_8(false);
								activeUnit_1.doctrine_0.method_192(doctrine.method_6(activeUnit_1.scenario_0).method_1(), activeUnit_1.scenario_0);
							}
							if (doctrine.method_6(activeUnit_1.scenario_0).method_2() != Doctrine.Class275.Enum66.const_3)
							{
								activeUnit_1.doctrine_0.method_8(false);
								activeUnit_1.doctrine_0.method_193(doctrine.method_6(activeUnit_1.scenario_0).method_2(), activeUnit_1.scenario_0);
							}
							if (doctrine.method_6(activeUnit_1.scenario_0).method_3() != Doctrine.Class275.Enum66.const_3)
							{
								activeUnit_1.doctrine_0.method_8(false);
								activeUnit_1.doctrine_0.method_194(doctrine.method_6(activeUnit_1.scenario_0).method_3(), activeUnit_1.scenario_0);
							}
						}
						activeUnit_1.vmethod_88().vmethod_5(activeUnit_1.method_78());
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101304", "");
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x000AA3E4 File Offset: 0x000A85E4
		public virtual bool vmethod_20()
		{
			bool result;
			if (this.activeUnit_0.vmethod_65(false) == null)
			{
				result = false;
			}
			else if (this.activeUnit_0.vmethod_65(false).method_147() == null)
			{
				result = false;
			}
			else
			{
				Tuple<double, double> tuple = this.method_2().method_0(this.activeUnit_0, this.activeUnit_0.vmethod_65(false).method_147());
				double item = tuple.Item1;
				double item2 = tuple.Item2;
				result = ((double)Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), item, item2) < 0.25 || ((double)Math.Abs(new Geopoint_Struct(item2, item).method_2(this.activeUnit_0)) > 90.0 && Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_65(false).method_147().vmethod_9())) < 20f));
			}
			return result;
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x000AA4F0 File Offset: 0x000A86F0
		public virtual void vmethod_21(float float_2)
		{
			try
			{
				if (this.activeUnit_0.vmethod_65(false).method_147() == null)
				{
					this.activeUnit_0.vmethod_65(false).method_149();
					if (this.activeUnit_0.vmethod_65(false).method_147() == null)
					{
						return;
					}
				}
				if (this.activeUnit_0 is Aircraft)
				{
					Aircraft aircraft = (Aircraft)this.activeUnit_0;
					ActiveUnit activeUnit = this.activeUnit_0.vmethod_65(false).method_147();
					if (activeUnit != this.activeUnit_0 && this.activeUnit_0.method_36(activeUnit) < 4f)
					{
						aircraft.method_158().bool_3 = true;
					}
				}
				if (this.activeUnit_0.method_120() && !this.activeUnit_0.vmethod_87().vmethod_12())
				{
					this.activeUnit_0.vmethod_73(this.activeUnit_0.vmethod_65(false).method_147().vmethod_72());
					this.activeUnit_0.vmethod_75(this.activeUnit_0.vmethod_65(false).method_147().vmethod_74());
				}
				if (this.activeUnit_0.method_120() && this.activeUnit_0.vmethod_65(false).method_147() != null && (this.activeUnit_0.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || this.activeUnit_0.vmethod_65(false).method_147().vmethod_108() == ActiveUnit._ActiveUnitStatus.Refuelling) && this.activeUnit_0.vmethod_65(false).method_147().vmethod_93().method_6() == this.activeUnit_0)
				{
					if (this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_47())
					{
						Waypoint waypoint = this.activeUnit_0.vmethod_65(false).method_147().vmethod_85().method_4()[0];
						this.activeUnit_0.vmethod_69(this.activeUnit_0.vmethod_65(false).method_147().vmethod_78(), Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), waypoint.imethod_2(), waypoint.imethod_0()));
						Waypoint waypoint2 = null;
						this.vmethod_11(float_2, ref waypoint2, waypoint.imethod_2(), waypoint.imethod_0(), 0f, 0f, this.activeUnit_0.vmethod_87().vmethod_49());
					}
				}
				else if (!this.activeUnit_0.method_122())
				{
					if (this.method_44())
					{
						this.vmethod_16(float_2);
					}
					else
					{
						ActiveUnit activeUnit2 = this.activeUnit_0.vmethod_65(false).method_147();
						if (activeUnit2 != null)
						{
							double num;
							double num2;
							Class411.smethod_1(activeUnit2.vmethod_28(null), activeUnit2.vmethod_30(null), ref num, ref num2, (double)this.method_2().float_1, (double)this.method_2().method_1(this.activeUnit_0));
							if (this.vmethod_3())
							{
								this.method_1(float_2);
							}
							else
							{
								if (this.vmethod_18(num2, num, float_2))
								{
									float num3 = Class437.smethod_11(this.activeUnit_0.vmethod_9(), Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), num2, num));
									if (num3 > 90f && num3 < 270f)
									{
										this.activeUnit_0.vmethod_69(activeUnit2.vmethod_78(), this.activeUnit_0.vmethod_65(false).vmethod_68());
										this.activeUnit_0.vmethod_71(this.activeUnit_0.vmethod_65(false).method_147().vmethod_40() - 1f);
									}
									else
									{
										this.activeUnit_0.vmethod_69(activeUnit2.vmethod_78(), Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), num2, num));
										this.activeUnit_0.vmethod_71(this.activeUnit_0.vmethod_65(false).vmethod_70());
									}
									this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_87().vmethod_41(this.activeUnit_0.vmethod_14(false), (float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))));
									return;
								}
								this.activeUnit_0.vmethod_69(activeUnit2.vmethod_78(), Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), num2, num));
								if (this.activeUnit_0.vmethod_87().vmethod_10() != null)
								{
									if (this.activeUnit_0.vmethod_87().vmethod_1() != ActiveUnit_Kinematics.UnitThrottlePreset.None)
									{
										this.activeUnit_0.vmethod_134((ActiveUnit.Throttle)this.activeUnit_0.vmethod_87().vmethod_1(), new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))));
									}
									else
									{
										this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_87().vmethod_41(this.activeUnit_0.vmethod_14(false), (float)((int)Math.Round((double)this.activeUnit_0.vmethod_87().vmethod_10().Value))), this.activeUnit_0.vmethod_87().vmethod_10());
									}
								}
								else if (this.activeUnit_0.method_120())
								{
									if (this.activeUnit_0.vmethod_65(false).method_147().vmethod_84() > ActiveUnit.Throttle.Full)
									{
										this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Flank, null);
									}
									else
									{
										this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Full, null);
									}
								}
								else
								{
									this.activeUnit_0.vmethod_134(ActiveUnit.Throttle.Full, null);
								}
							}
							if (activeUnit2.vmethod_40() > 0f)
							{
								double num4;
								double num5;
								Class411.smethod_1(num, num2, ref num4, ref num5, (double)this.method_2().float_1, (double)activeUnit2.vmethod_9());
								Unit unit = this.activeUnit_0;
								double num6 = num5;
								double num7 = num4;
								int num8 = 0;
								bool flag = false;
								bool flag2 = false;
								bool flag3 = true;
								bool flag4 = true;
								bool flag5 = true;
								bool flag6 = true;
								float? nullable_ = null;
								short? nullable_2 = null;
								List<ActiveUnit> list = null;
								float float_3 = 0f;
								bool bool_ = false;
								bool bool_2 = false;
								string text = "";
								bool flag7 = false;
								if (!unit.vmethod_47(num6, num7, ref num8, flag, flag2, flag3, ref flag4, flag5, ref flag6, nullable_, nullable_2, ref list, float_3, bool_, bool_2, ref text, ref flag7))
								{
									num2 = activeUnit2.vmethod_30(null);
									num = activeUnit2.vmethod_28(null);
								}
							}
							this.activeUnit_0.vmethod_86().geopoint_Struct_0 = new Geopoint_Struct(num, num2);
							if (!this.method_44() && !this.bool_2)
							{
								if (this.activeUnit_0.vmethod_85().bool_1 && this.vmethod_29(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), num2, num, true, 0f, true, null, true, false, true, new float?(Class522.interface9_1.imethod_1())))
								{
									this.method_16(null, this.activeUnit_0, null, false, 0.15f, num2, num, this.activeUnit_0.scenario_0, false);
								}
								else if (this.vmethod_3())
								{
									float num9 = Class437.smethod_11(this.activeUnit_0.vmethod_9(), Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), num2, num));
									if (num9 > 90f && num9 < 270f && Math.Abs(Class437.smethod_3(this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_65(false).vmethod_9())) <= 30f)
									{
										this.activeUnit_0.vmethod_69(activeUnit2.vmethod_78(), this.activeUnit_0.vmethod_65(false).vmethod_9());
										this.activeUnit_0.vmethod_71((float)((double)this.activeUnit_0.vmethod_65(false).vmethod_40() * 0.2));
										this.activeUnit_0.vmethod_134(this.activeUnit_0.vmethod_87().vmethod_41(this.activeUnit_0.vmethod_14(false), (float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))), new float?((float)((int)Math.Round((double)this.activeUnit_0.vmethod_70()))));
									}
									else
									{
										this.activeUnit_0.vmethod_69(activeUnit2.vmethod_78(), Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), num2, num));
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100217", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x000AADF0 File Offset: 0x000A8FF0
		public bool method_37(ref List<ReferencePoint> list_1, ref List<ReferencePoint> list_2, ref List<ReferencePoint> list_3, float float_2, bool bool_17)
		{
			bool result;
			if (Enumerable.Count<Waypoint>(this.method_4()) == 0)
			{
				result = false;
			}
			else if (list_1.Count == 0)
			{
				result = false;
			}
			else
			{
				try
				{
					bool flag = this.method_38(list_1, list_3);
					if (!bool_17 && !flag)
					{
						if (this.double_8 > 0.0)
						{
							return this.bool_12;
						}
						this.double_8 = 60.0;
					}
					if (list_2.Count == 0 || flag)
					{
						this.method_42(float_2, ref list_1, ref list_2, ref list_3);
					}
					int num = list_1.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						try
						{
							ReferencePoint referencePoint = list_1[i];
							if (referencePoint.imethod_2() == this.method_4()[0].imethod_2() && referencePoint.imethod_0() == this.method_4()[0].imethod_0())
							{
								this.bool_12 = true;
								return this.bool_12;
							}
							if (float_2 > 0f && Math2.smethod_15(this.method_4()[0].imethod_2(), this.method_4()[0].imethod_0(), referencePoint.imethod_2(), referencePoint.imethod_0()) <= float_2 * 2f)
							{
								this.bool_12 = true;
								return this.bool_12;
							}
						}
						catch (Exception ex)
						{
						}
					}
					if (list_1.Count == 1)
					{
						this.bool_12 = (Math2.smethod_15(this.method_4()[Enumerable.Count<Waypoint>(this.method_4()) - 1].imethod_2(), this.method_4()[Enumerable.Count<Waypoint>(this.method_4()) - 1].imethod_0(), list_1[0].imethod_2(), list_1[0].imethod_0()) <= float_2);
					}
					else if (list_1.Count > 1)
					{
						Waypoint waypoint = this.method_4()[Enumerable.Count<Waypoint>(this.method_4()) - 1];
						if (!Information.IsNothing(list_2) && !Information.IsNothing(list_3))
						{
							if (float_2 != 0f)
							{
								this.bool_12 = GeoPoint.smethod_4(waypoint.imethod_2(), waypoint.imethod_0(), Enumerable.ToList<ReferencePoint>(list_2), true);
								goto IL_231;
							}
						}
						this.bool_12 = GeoPoint.smethod_4(waypoint.imethod_2(), waypoint.imethod_0(), Enumerable.ToList<ReferencePoint>(list_1), true);
					}
					IL_231:
					result = this.bool_12;
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 200341", ex2.Message);
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x000AB0A8 File Offset: 0x000A92A8
		public bool method_38(List<ReferencePoint> list_1, List<ReferencePoint> list_2)
		{
			bool result;
			try
			{
				if (Information.IsNothing(list_2))
				{
					result = true;
				}
				else if (list_1.Count != list_2.Count)
				{
					result = true;
				}
				else
				{
					int num = list_1.Count - 1;
					int i = 0;
					while (i <= num)
					{
						double num2;
						double num3;
						double num4;
						double num5;
						try
						{
							ReferencePoint referencePoint = list_1[i];
							num2 = referencePoint.imethod_2();
							num3 = referencePoint.imethod_0();
							ReferencePoint referencePoint2 = list_2[i];
							num4 = referencePoint2.imethod_2();
							num5 = referencePoint2.imethod_0();
						}
						catch (Exception ex)
						{
							goto IL_A1;
						}
						goto IL_6D;
						IL_A1:
						i++;
						continue;
						IL_6D:
						if (num2 != num4 && Math.Abs(num2 - num4) > 0.1)
						{
							return true;
						}
						if (num3 == num5 || Math.Abs(num3 - num5) <= 0.1)
						{
							goto IL_A1;
						}
						return true;
					}
					result = false;
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 200322", ex2.Message);
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x000AB1C4 File Offset: 0x000A93C4
		public bool method_39(List<GeoPoint> list_1, List<GeoPoint> list_2)
		{
			bool result;
			try
			{
				if (Information.IsNothing(list_2))
				{
					result = true;
				}
				else if (list_1.Count != list_2.Count)
				{
					result = true;
				}
				else
				{
					int num = list_1.Count - 1;
					int i = 0;
					while (i <= num)
					{
						if (list_1[i].imethod_2() == list_2[i].imethod_2())
						{
							if (list_1[i].imethod_0() == list_2[i].imethod_0())
							{
								i++;
								continue;
							}
						}
						return true;
					}
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200566", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x000AB294 File Offset: 0x000A9494
		public bool method_40(ref List<ReferencePoint> list_1, ref List<ReferencePoint> list_2, ref List<ReferencePoint> list_3, int int_3, bool bool_17, bool bool_18)
		{
			bool result;
			try
			{
				if (list_1.Count == 0)
				{
					result = false;
				}
				else
				{
					bool flag = this.method_38(list_1, list_3);
					if (!bool_17 && !flag)
					{
						if (!Information.IsNothing(list_2) && !Information.IsNothing(list_3) && int_3 != 0)
						{
							if (int_3 == 1)
							{
								if (this.double_1 > 0.0)
								{
									return this.bool_5;
								}
								this.double_1 = 60.0;
							}
							else if (int_3 == 2)
							{
								if (this.double_2 > 0.0)
								{
									return this.bool_6;
								}
								this.double_2 = 60.0;
							}
							else if (int_3 == 5)
							{
								if (bool_18)
								{
									if (this.double_7 > 0.0)
									{
										return this.bool_11;
									}
									this.double_7 = 60.0;
								}
								else
								{
									if (this.double_3 > 0.0)
									{
										return this.bool_7;
									}
									this.double_3 = 60.0;
								}
							}
							else if (int_3 == 10)
							{
								if (this.double_4 > 0.0)
								{
									return this.bool_8;
								}
								this.double_4 = 60.0;
							}
							else
							{
								if (this.double_5 > 0.0)
								{
									return this.bool_9;
								}
								this.double_5 = 60.0;
							}
						}
						else if (bool_18)
						{
							if (this.double_6 > 0.0)
							{
								return this.bool_10;
							}
							this.double_6 = 60.0;
						}
						else
						{
							if (this.double_0 > 0.0)
							{
								return this.bool_4;
							}
							this.double_0 = 60.0;
						}
					}
					if ((list_1.Count > 1 && !Information.IsNothing(list_2) && list_2.Count == 0) || flag)
					{
						this.method_42((float)int_3, ref list_1, ref list_2, ref list_3);
					}
					if (list_1.Count == 1)
					{
						if (int_3 == 0)
						{
							this.bool_4 = false;
							this.bool_10 = false;
							result = false;
						}
						else if (int_3 == 1)
						{
							this.bool_5 = (Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), list_1[0].imethod_2(), list_1[0].imethod_0()) <= (float)int_3);
							result = this.bool_5;
						}
						else if (int_3 == 2)
						{
							this.bool_6 = (Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), list_1[0].imethod_2(), list_1[0].imethod_0()) <= (float)int_3);
							result = this.bool_6;
						}
						else if (int_3 == 5)
						{
							if (bool_18)
							{
								this.bool_11 = (Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), list_1[0].imethod_2(), list_1[0].imethod_0()) <= (float)int_3);
								result = this.bool_11;
							}
							else
							{
								this.bool_7 = (Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), list_1[0].imethod_2(), list_1[0].imethod_0()) <= (float)int_3);
								result = this.bool_7;
							}
						}
						else if (int_3 == 10)
						{
							this.bool_8 = (Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), list_1[0].imethod_2(), list_1[0].imethod_0()) <= (float)int_3);
							result = this.bool_8;
						}
						else
						{
							this.bool_9 = (Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), list_1[0].imethod_2(), list_1[0].imethod_0()) <= (float)int_3);
							result = this.bool_9;
						}
					}
					else if (list_1.Count > 1)
					{
						if (!Information.IsNothing(list_2) && !Information.IsNothing(list_3) && int_3 != 0)
						{
							if (int_3 == 1)
							{
								this.bool_5 = this.activeUnit_0.vmethod_46(Enumerable.ToList<ReferencePoint>(list_2), this.activeUnit_0.scenario_0, false);
								result = this.bool_5;
							}
							else if (int_3 == 2)
							{
								this.bool_6 = this.activeUnit_0.vmethod_46(Enumerable.ToList<ReferencePoint>(list_2), this.activeUnit_0.scenario_0, false);
								result = this.bool_6;
							}
							else if (int_3 == 5)
							{
								if (bool_18)
								{
									this.bool_11 = this.activeUnit_0.vmethod_46(Enumerable.ToList<ReferencePoint>(list_2), this.activeUnit_0.scenario_0, false);
									result = this.bool_11;
								}
								else
								{
									this.bool_7 = this.activeUnit_0.vmethod_46(Enumerable.ToList<ReferencePoint>(list_2), this.activeUnit_0.scenario_0, false);
									result = this.bool_7;
								}
							}
							else if (int_3 == 10)
							{
								this.bool_8 = this.activeUnit_0.vmethod_46(Enumerable.ToList<ReferencePoint>(list_2), this.activeUnit_0.scenario_0, false);
								result = this.bool_8;
							}
							else
							{
								this.bool_9 = this.activeUnit_0.vmethod_46(Enumerable.ToList<ReferencePoint>(list_2), this.activeUnit_0.scenario_0, false);
								result = this.bool_9;
							}
						}
						else if (bool_18)
						{
							this.bool_10 = this.activeUnit_0.vmethod_46(Enumerable.ToList<ReferencePoint>(list_1), this.activeUnit_0.scenario_0, false);
							result = this.bool_10;
						}
						else
						{
							this.bool_4 = this.activeUnit_0.vmethod_46(Enumerable.ToList<ReferencePoint>(list_1), this.activeUnit_0.scenario_0, false);
							result = this.bool_4;
						}
					}
					else
					{
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200319", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x000AB954 File Offset: 0x000A9B54
		public bool method_41(ref List<GeoPoint> list_1, ref List<GeoPoint> list_2, ref List<GeoPoint> list_3, float float_2)
		{
			bool result;
			if (list_1.Count == 0)
			{
				result = false;
			}
			else
			{
				try
				{
					if (!Information.IsNothing(list_2) && !Information.IsNothing(list_3))
					{
						if (float_2 != 0f)
						{
							if (list_2.Count == 0 || this.method_39(list_1, list_3))
							{
								ActiveUnit_Navigator.smethod_0(float_2, ref list_1, ref list_2, ref list_3);
							}
							return this.activeUnit_0.vmethod_45(Enumerable.ToList<GeoPoint>(list_2), this.activeUnit_0.scenario_0, true);
						}
					}
					result = this.activeUnit_0.vmethod_45(Enumerable.ToList<GeoPoint>(list_1), this.activeUnit_0.scenario_0, true);
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101261", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x000ABA3C File Offset: 0x000A9C3C
		public void method_42(float float_2, ref List<ReferencePoint> list_1, ref List<ReferencePoint> list_2, ref List<ReferencePoint> list_3)
		{
			try
			{
				list_3.Clear();
				List<ReferencePoint> list = new List<ReferencePoint>();
				int count = list_1.Count;
				int num;
				if (count > 2)
				{
					num = count;
				}
				else
				{
					num = count - 1;
				}
				int num2 = count - 1;
				for (int i = 0; i <= num2; i++)
				{
					List<ReferencePoint> list2 = list;
					ReferencePoint referencePoint = list_1[i];
					List<ReferencePoint> list3;
					int num3;
					ReferencePoint value = (list3 = list_1)[num3 = i];
					ReferencePoint item = referencePoint.method_22(ref value);
					list3[num3] = value;
					list2.Add(item);
				}
				list_3 = list;
				if (float_2 != 0f)
				{
					float num4 = (float)((double)float_2 * 1852.0);
					Class432.Class433 @class = new Class432.Class433(0.0, 0.0);
					if (count != 0)
					{
						Coordinate[] array = new Coordinate[num + 1];
						bool flag = false;
						int num3 = count - 1;
						for (int j = 0; j <= num3; j++)
						{
							double num5;
							double num6;
							if (!@class.method_1(list_1[j].imethod_2(), list_1[j].imethod_0(), ref num5, ref num6, false))
							{
								flag = true;
								IL_109:
								if (flag)
								{
									int num7 = count - 1;
									for (int k = 0; k <= num7; k++)
									{
										num5 = Class412.smethod_0(list_1[k].imethod_0());
										num6 = Class412.smethod_1(list_1[k].imethod_2());
										array[k] = new Coordinate(num5, num6);
									}
								}
								list_2.Clear();
								List<ReferencePoint> list4 = new List<ReferencePoint>();
								IGeometry geometry;
								if (count > 2)
								{
									array[count] = array[0];
									Polygon polygon;
									try
									{
										polygon = new Polygon(new LinearRing(array));
									}
									catch (Exception ex)
									{
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
									}
									try
									{
										geometry = polygon.vmethod_1((double)num4, 2);
										goto IL_2F5;
									}
									catch (Exception ex2)
									{
										ex2.Data.Add("Error at 200304", ex2.Message);
										GameGeneral.smethod_25(ref ex2);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
										try
										{
											foreach (ReferencePoint referencePoint2 in list_1)
											{
												list4.Add(new ReferencePoint(referencePoint2.imethod_0(), referencePoint2.imethod_2()));
											}
										}
										finally
										{
											List<ReferencePoint>.Enumerator enumerator;
											((IDisposable)enumerator).Dispose();
										}
										list_2 = list4;
										return;
									}
								}
								if (count == 2)
								{
									LineString lineString = new LineString(array);
									try
									{
										geometry = lineString.vmethod_1((double)num4, 3);
										goto IL_2F5;
									}
									catch (Exception ex3)
									{
										ex3.Data.Add("Error at 200309", ex3.Message);
										GameGeneral.smethod_25(ref ex3);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
										return;
									}
								}
								if (count == 1)
								{
									Point point = new Point(array[0]);
									try
									{
										geometry = point.vmethod_1((double)num4, 3);
									}
									catch (Exception ex4)
									{
										ex4.Data.Add("Error at 200310", ex4.Message);
										GameGeneral.smethod_25(ref ex4);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
										return;
									}
								}
								IL_2F5:
								if (Debugger.IsAttached && (Information.IsNothing(geometry) || geometry.imethod_0().Count == 0))
								{
									Debugger.Break();
								}
								if (!Information.IsNothing(geometry))
								{
									int num8 = geometry.imethod_0().Count - 2;
									for (int l = 0; l <= num8; l++)
									{
										double num9;
										double num10;
										if (flag)
										{
											num9 = Class412.smethod_2(geometry.imethod_0()[l].X);
											num10 = Class412.smethod_3(geometry.imethod_0()[l].Y);
										}
										else
										{
											@class.method_6(geometry.imethod_0()[l].X, geometry.imethod_0()[l].Y, ref num10, ref num9);
										}
										if (num9 > 180.0)
										{
											num9 = 180.0;
										}
										else if (num9 < -180.0)
										{
											num9 = -180.0;
										}
										if (num10 > 90.0)
										{
											num10 = 90.0;
										}
										else if (num10 < -90.0)
										{
											num10 = -90.0;
										}
										list4.Add(new ReferencePoint(num9, num10));
									}
									list_2 = list4;
								}
								return;
							}
							array[j] = new Coordinate(num5, num6);
						}
						goto IL_109;
					}
				}
			}
			catch (Exception ex5)
			{
				ex5.Data.Add("Error at 200303", ex5.Message);
				GameGeneral.smethod_25(ref ex5);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x000ABF48 File Offset: 0x000AA148
		public static void smethod_0(float float_2, ref List<GeoPoint> list_1, ref List<GeoPoint> list_2, ref List<GeoPoint> list_3)
		{
			try
			{
				list_3.Clear();
				List<GeoPoint> list = new List<GeoPoint>();
				int count = list_1.Count;
				int num;
				if (count > 2)
				{
					num = count;
				}
				else
				{
					num = count - 1;
				}
				int num2 = count - 1;
				for (int i = 0; i <= num2; i++)
				{
					list.Add(list_1[i]);
				}
				list_3 = list;
				if (float_2 != 0f)
				{
					float num3 = float_2 * 1852f;
					Class432.Class433 @class = new Class432.Class433(list_1[0].imethod_2(), list_1[0].imethod_0());
					if (count != 0)
					{
						Coordinate[] array = new Coordinate[num + 1];
						int num4 = count - 1;
						for (int j = 0; j <= num4; j++)
						{
							double num5;
							double num6;
							if (@class.method_1(list_1[j].imethod_2(), list_1[j].imethod_0(), ref num5, ref num6, false))
							{
								array[j] = new Coordinate(num5, num6);
							}
						}
						if (count > 2)
						{
							array[count] = array[0];
						}
						list_2.Clear();
						List<GeoPoint> list2 = new List<GeoPoint>();
						IGeometry geometry;
						if (count > 2)
						{
							Polygon polygon = new Polygon(new LinearRing(array));
							try
							{
								geometry = polygon.vmethod_1((double)num3, 2);
								goto IL_256;
							}
							catch (Exception ex)
							{
								ex.Data.Add("Error at 200305", ex.Message);
								GameGeneral.smethod_25(ref ex);
								bool isAttached = Debugger.IsAttached;
								try
								{
									foreach (GeoPoint geoPoint in list_1)
									{
										list2.Add(new GeoPoint(geoPoint.imethod_0(), geoPoint.imethod_2()));
									}
								}
								finally
								{
									List<GeoPoint>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
								list_2 = list2;
								return;
							}
						}
						if (count == 2)
						{
							LineString lineString = new LineString(array);
							try
							{
								geometry = lineString.vmethod_1((double)num3, 3);
								goto IL_256;
							}
							catch (Exception ex2)
							{
								ex2.Data.Add("Error at 200317", ex2.Message);
								GameGeneral.smethod_25(ref ex2);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								return;
							}
						}
						if (count == 1)
						{
							Point point = new Point(array[0]);
							try
							{
								geometry = point.vmethod_1((double)num3, 3);
							}
							catch (Exception ex3)
							{
								ex3.Data.Add("Error at 200318", ex3.Message);
								GameGeneral.smethod_25(ref ex3);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								return;
							}
						}
						IL_256:
						if (!Information.IsNothing(geometry))
						{
							int num7 = geometry.imethod_0().Count - 2;
							for (int k = 0; k <= num7; k++)
							{
								double num8;
								double num9;
								@class.method_6(geometry.imethod_0()[k].X, geometry.imethod_0()[k].Y, ref num8, ref num9);
								if (num9 > 180.0)
								{
									num9 = 180.0;
								}
								else if (num9 < -180.0)
								{
									num9 = -180.0;
								}
								if (num8 > 90.0)
								{
									num8 = 90.0;
								}
								else if (num8 < -90.0)
								{
									num8 = -90.0;
								}
								list2.Add(new GeoPoint(num9, num8));
							}
							list_2 = list2;
						}
					}
				}
			}
			catch (Exception ex4)
			{
				ex4.Data.Add("Error at 200306", ex4.Message);
				GameGeneral.smethod_25(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x000AC340 File Offset: 0x000AA540
		public virtual void vmethod_22(List<ReferencePoint> list_1)
		{
			try
			{
				double double_;
				double double_2;
				switch (list_1.Count)
				{
				case 0:
				{
					ActiveUnit activeUnit = this.activeUnit_0;
					Mission value = null;
					bool setMissionOnly = false;
					Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
					activeUnit.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
					break;
				}
				case 1:
					double_ = list_1[0].imethod_2();
					double_2 = list_1[0].imethod_0();
					break;
				case 2:
				{
					List<ReferencePoint> list = Enumerable.ToList<ReferencePoint>(Enumerable.OrderByDescending<ReferencePoint, float>(list_1, new Func<ReferencePoint, float>(this.method_60)));
					double_2 = list[0].imethod_0();
					double_ = list[0].imethod_2();
					break;
				}
				default:
				{
					bool flag = false;
					int num = 0;
					while (!flag)
					{
						Geopoint_Struct geopoint_Struct = Math2.smethod_23(list_1);
						if (Information.IsNothing(geopoint_Struct) || geopoint_Struct.method_0())
						{
							this.activeUnit_0.method_124(this.activeUnit_0.Name + " is unable to pick a suitable point inside area defined by Ref. Points: " + string.Join(" - ", Enumerable.Select<ReferencePoint, string>(list_1, (ActiveUnit_Navigator._Closure$__.$I147-1 == null) ? (ActiveUnit_Navigator._Closure$__.$I147-1 = new Func<ReferencePoint, string>(ActiveUnit_Navigator._Closure$__.$I.method_0)) : ActiveUnit_Navigator._Closure$__.$I147-1)), "Unable to pick a point", LoggedMessage.MessageType.UnitAI, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							return;
						}
						Unit unit = this.activeUnit_0;
						double num2 = geopoint_Struct.double_1;
						double num3 = geopoint_Struct.double_0;
						int num4 = 0;
						bool flag2 = false;
						bool flag3 = false;
						bool flag4 = true;
						bool flag5 = true;
						bool flag6 = true;
						bool flag7 = true;
						float? nullable_ = null;
						short? nullable_2 = null;
						List<ActiveUnit> list2 = null;
						float float_ = 0f;
						bool bool_ = false;
						bool bool_2 = false;
						string text = "";
						bool flag8 = false;
						if (unit.vmethod_47(num2, num3, ref num4, flag2, flag3, flag4, ref flag5, flag6, ref flag7, nullable_, nullable_2, ref list2, float_, bool_, bool_2, ref text, ref flag8))
						{
							flag = true;
							double_ = geopoint_Struct.double_1;
							double_2 = geopoint_Struct.double_0;
						}
						num++;
						if (num >= 32767)
						{
							return;
						}
					}
					break;
				}
				}
				this.vmethod_9();
				this.vmethod_24(double_, double_2, 0f, Waypoint.WaypointType.PatrolStation, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0);
				this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), double_, double_2));
				this.vmethod_2();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at KJHKJHLHJBSSGY", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x000AC5C4 File Offset: 0x000AA7C4
		public void method_43()
		{
			if (!Information.IsNothing(this.activeUnit_0.vmethod_86().method_8()))
			{
				this.vmethod_9();
				this.vmethod_24(this.activeUnit_0.vmethod_86().method_8().vmethod_30(null), this.activeUnit_0.vmethod_86().method_8().vmethod_28(null), 0f, Waypoint.WaypointType.PickupPoint, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0);
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000AC63C File Offset: 0x000AA83C
		public virtual void vmethod_23(float float_2, bool bool_17)
		{
			try
			{
				if (!this.activeUnit_0.scenario_0.UserIsPlottingCourse)
				{
					if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol && ((Class343)this.activeUnit_0.vmethod_101()).enum107_0 == Class343.Enum107.const_1)
					{
						this.vmethod_15(float_2, !this.method_20());
					}
					else if (this.activeUnit_0.vmethod_101() != null)
					{
						List<ReferencePoint> list_;
						if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
						{
							Class343 @class = (Class343)this.activeUnit_0.vmethod_101();
							if (@class == null)
							{
								return;
							}
							if (@class.list_5 == null)
							{
								return;
							}
							list_ = @class.list_5;
						}
						else
						{
							if (this.activeUnit_0.vmethod_101()._MissionClass_0 != Mission._MissionClass.Support)
							{
								return;
							}
							Class344 class2 = (Class344)this.activeUnit_0.vmethod_101();
							if (class2 == null)
							{
								return;
							}
							if (class2.list_5 == null)
							{
								return;
							}
							list_ = class2.list_5;
						}
						double? num;
						double? num2;
						switch (list_.Count)
						{
						case 0:
							if (this.method_49())
							{
								return;
							}
							if (Information.IsNothing(this.method_4()) || Enumerable.Count<Waypoint>(this.method_4()) == 0)
							{
								this.activeUnit_0.method_124(this.activeUnit_0.Name + " has been removed from mission: " + this.activeUnit_0.vmethod_101().Name + " (station area not defined!)", this.activeUnit_0.Name + " taken off mission", LoggedMessage.MessageType.UnitAI, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
								ActiveUnit activeUnit = this.activeUnit_0;
								Mission value = null;
								bool setMissionOnly = false;
								Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
								activeUnit.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
							}
							break;
						case 1:
							if (Information.IsNothing(this.method_4()) || Enumerable.Count<Waypoint>(this.method_4()) == 0 || bool_17)
							{
								num = new double?(list_[0].imethod_2());
								num2 = new double?(list_[0].imethod_0());
							}
							break;
						case 2:
							if (Information.IsNothing(this.method_4()) || Enumerable.Count<Waypoint>(this.method_4()) == 0 || bool_17)
							{
								ReferencePoint referencePoint = Enumerable.ElementAtOrDefault<ReferencePoint>(Enumerable.OrderByDescending<ReferencePoint, double>(list_, new Func<ReferencePoint, double>(this.method_61)), 0);
								num2 = new double?(referencePoint.imethod_0());
								num = new double?(referencePoint.imethod_2());
							}
							break;
						default:
							if (Information.IsNothing(this.method_4()) || Enumerable.Count<Waypoint>(this.method_4()) == 0 || bool_17)
							{
								bool flag = false;
								int num3 = 0;
								while (!flag)
								{
									num3++;
									Geopoint_Struct geopoint_Struct = Math2.smethod_23(list_);
									if (Information.IsNothing(geopoint_Struct) || geopoint_Struct.method_0())
									{
										this.activeUnit_0.method_124(this.activeUnit_0.Name + " is unable to pick a suitable point inside station area defined by Ref. Points: " + string.Join(" - ", Enumerable.Select<ReferencePoint, string>(list_, (ActiveUnit_Navigator._Closure$__.$I149-1 == null) ? (ActiveUnit_Navigator._Closure$__.$I149-1 = new Func<ReferencePoint, string>(ActiveUnit_Navigator._Closure$__.$I.method_1)) : ActiveUnit_Navigator._Closure$__.$I149-1)), "Unable to pick a point", LoggedMessage.MessageType.UnitAI, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
										return;
									}
									Unit unit = this.activeUnit_0;
									double num4 = geopoint_Struct.double_1;
									double num5 = geopoint_Struct.double_0;
									int num6 = 0;
									bool flag2 = false;
									bool flag3 = false;
									bool flag4 = true;
									bool flag5 = true;
									bool flag6 = true;
									bool flag7 = true;
									float? nullable_ = null;
									short? nullable_2 = null;
									List<ActiveUnit> list = null;
									float float_3 = 0f;
									bool bool_18 = false;
									bool bool_19 = false;
									string text = "";
									bool flag8 = false;
									if (unit.vmethod_47(num4, num5, ref num6, flag2, flag3, flag4, ref flag5, flag6, ref flag7, nullable_, nullable_2, ref list, float_3, bool_18, bool_19, ref text, ref flag8))
									{
										num = new double?(geopoint_Struct.double_1);
										num2 = new double?(geopoint_Struct.double_0);
										break;
									}
									if (num3 > 1000)
									{
										this.activeUnit_0.method_124(this.activeUnit_0.Name + " is unable to pick a suitable point inside station area defined by Ref. Points: " + string.Join(" - ", Enumerable.Select<ReferencePoint, string>(list_, (ActiveUnit_Navigator._Closure$__.$I149-2 == null) ? (ActiveUnit_Navigator._Closure$__.$I149-2 = new Func<ReferencePoint, string>(ActiveUnit_Navigator._Closure$__.$I.method_2)) : ActiveUnit_Navigator._Closure$__.$I149-2)), "Unable to pick a point", LoggedMessage.MessageType.UnitAI, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
										return;
									}
								}
							}
							break;
						}
						if (num != null && num2 != null)
						{
							if (bool_17 && Enumerable.Count<Waypoint>(this.activeUnit_0.vmethod_85().method_4()) > 0)
							{
								this.activeUnit_0.vmethod_85().method_18();
								Waypoint waypoint_ = new Waypoint(num2.Value, num.Value, 0f, Waypoint.WaypointType.PatrolStation, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0);
								ActiveUnit_Navigator activeUnit_Navigator = this.activeUnit_0.vmethod_85();
								Waypoint[] waypoint_2 = activeUnit_Navigator.method_4();
								ActiveUnit_Navigator.smethod_1(ref waypoint_2, 0, waypoint_);
								activeUnit_Navigator.method_5(waypoint_2);
							}
							else
							{
								this.vmethod_9();
								this.vmethod_24(num.Value, num2.Value, 0f, Waypoint.WaypointType.PatrolStation, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0);
							}
							this.activeUnit_0.vmethod_69(ActiveUnit.Enum28.const_1, Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), num.Value, num2.Value));
						}
						this.vmethod_2();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100221", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000ACC08 File Offset: 0x000AAE08
		public bool method_44()
		{
			bool result;
			try
			{
				if (Information.IsNothing(this.method_4()))
				{
					result = false;
				}
				else if (Enumerable.Count<Waypoint>(this.method_4()) == 0)
				{
					result = false;
				}
				else if (Information.IsNothing(this.method_4()[0]))
				{
					result = false;
				}
				else
				{
					result = (this.method_4()[0].waypointType_0 == Waypoint.WaypointType.PathfindingPoint);
				}
			}
			catch (NullReferenceException ex)
			{
				result = false;
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 200031", ex2.Message);
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x000ACCC8 File Offset: 0x000AAEC8
		public bool method_45()
		{
			return this.method_47() && this.method_4()[0].waypointType_0 == Waypoint.WaypointType.ManualPlottedCourseWaypoint;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x000ACCF4 File Offset: 0x000AAEF4
		public bool method_46()
		{
			int num = Enumerable.Count<Waypoint>(this.method_4());
			bool result;
			if (num == 0)
			{
				result = false;
			}
			else
			{
				try
				{
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						if (this.method_4()[i].waypointType_0 != Waypoint.WaypointType.PathfindingPoint)
						{
							return true;
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200008", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00007EDB File Offset: 0x000060DB
		public bool method_47()
		{
			return Enumerable.Count<Waypoint>(this.method_4()) > 0;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00007EEB File Offset: 0x000060EB
		public bool method_48()
		{
			return !Information.IsNothing(this.method_7());
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000ACD8C File Offset: 0x000AAF8C
		public bool method_49()
		{
			return this.method_7() != null && this.method_7().method_15() != null && this.method_7().method_15().Length > 0;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x000ACDC8 File Offset: 0x000AAFC8
		public virtual void vmethod_24(double double_11, double double_12, float float_2, Waypoint.WaypointType waypointType_0, Waypoint.Enum80 enum80_0, Waypoint.Enum79 enum79_0)
		{
			try
			{
				if (this.activeUnit_0.method_122())
				{
					this.activeUnit_0.vmethod_65(false).vmethod_85().method_50(new Waypoint(double_12, double_11, float_2, waypointType_0, enum80_0, enum79_0));
				}
				else
				{
					Class429.smethod_36(ref this.waypoint_0, new Waypoint(double_12, double_11, float_2, waypointType_0, enum80_0, enum79_0));
				}
				this.bool_0 = (waypointType_0 == Waypoint.WaypointType.ManualPlottedCourseWaypoint);
				this.double_8 = 0.0;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100222", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00007EFB File Offset: 0x000060FB
		public void method_50(Waypoint waypoint_2)
		{
			bool isAttached = Debugger.IsAttached;
			if (this.activeUnit_0.method_122())
			{
				this.activeUnit_0.vmethod_65(false).vmethod_85().method_50(waypoint_2);
				return;
			}
			Class429.smethod_36(ref this.waypoint_0, waypoint_2);
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x000ACE84 File Offset: 0x000AB084
		public void method_51(int int_3, Waypoint waypoint_2)
		{
			bool isAttached = Debugger.IsAttached;
			if (this.activeUnit_0.method_122())
			{
				this.activeUnit_0.vmethod_65(false).vmethod_85().method_51(int_3, waypoint_2);
				return;
			}
			List<Waypoint> list = Enumerable.ToList<Waypoint>(this.waypoint_0);
			list.Insert(int_3, waypoint_2);
			this.waypoint_0 = list.ToArray();
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00007F34 File Offset: 0x00006134
		public static void smethod_1(ref Waypoint[] waypoint_2, int int_3, Waypoint waypoint_3)
		{
			bool isAttached = Debugger.IsAttached;
			Class429.smethod_39(ref waypoint_2, int_3, waypoint_3);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x000ACEE0 File Offset: 0x000AB0E0
		public void method_52()
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0.vmethod_86().vmethod_3()))
				{
					bool flag = false;
					bool flag2 = false;
					bool flag3 = false;
					bool flag4 = false;
					if (!this.activeUnit_0.vmethod_85().method_46())
					{
						flag = true;
					}
					else if (!GeoPoint.smethod_3(this.activeUnit_0.vmethod_85().method_4()[0].imethod_2(), this.activeUnit_0.vmethod_85().method_4()[0].imethod_0(), this.activeUnit_0.vmethod_86().vmethod_3().method_112(), true))
					{
						this.vmethod_9();
						flag = true;
					}
					if (flag)
					{
						GeoPoint geoPoint = new GeoPoint(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null));
						int num = 0;
						List<ActiveUnit> list;
						string text2;
						for (;;)
						{
							geoPoint = Math2.smethod_20(this.activeUnit_0.vmethod_86().vmethod_3().method_112(), this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), true);
							Unit unit = this.activeUnit_0;
							double num2 = geoPoint.imethod_2();
							double num3 = geoPoint.imethod_0();
							int num4 = 0;
							bool flag5 = false;
							bool flag6 = false;
							bool flag7 = true;
							bool flag8 = true;
							bool flag9 = true;
							bool flag10 = true;
							float? nullable_ = null;
							short? nullable_2 = null;
							list = null;
							float float_ = 0f;
							bool bool_ = true;
							bool bool_2 = false;
							string text = "";
							bool flag11 = false;
							if (unit.vmethod_47(num2, num3, ref num4, flag5, flag6, flag7, ref flag8, flag9, ref flag10, nullable_, nullable_2, ref list, float_, bool_, bool_2, ref text, ref flag11))
							{
								if (Information.IsNothing(this.activeUnit_0.vmethod_86().vmethod_3()))
								{
									goto IL_674;
								}
								if (!this.activeUnit_0.vmethod_86().vmethod_3().method_136() && !this.activeUnit_0.vmethod_86().vmethod_3().method_134())
								{
									if (!this.activeUnit_0.vmethod_86().vmethod_3().method_107() || !geoPoint.method_11())
									{
										goto IL_674;
									}
									flag3 = true;
								}
								else if (geoPoint.method_10())
								{
									flag2 = true;
								}
								else
								{
									if (!this.activeUnit_0.bool_3 || !this.activeUnit_0.vmethod_86().vmethod_3().method_136() || !Class442.smethod_1(geoPoint.imethod_0(), geoPoint.imethod_2()))
									{
										goto IL_674;
									}
									flag4 = true;
								}
							}
							else
							{
								text2 = "";
								if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
								{
									text2 = " (" + this.activeUnit_0.string_2 + ")";
								}
								if (flag2)
								{
									goto IL_2B7;
								}
								if (flag3)
								{
									goto IL_365;
								}
								if (flag4)
								{
									goto IL_413;
								}
								if (num == 10)
								{
									break;
								}
							}
							num++;
							if (num > 10)
							{
								goto Block_11;
							}
						}
						ActiveUnit_Navigator activeUnit_Navigator = this.activeUnit_0.vmethod_85();
						double double_ = geoPoint.imethod_2();
						double double_2 = geoPoint.imethod_0();
						bool bool_3 = false;
						bool bool_4 = false;
						bool bool_5 = true;
						float float_2 = 0f;
						list = null;
						double num5;
						double num6;
						if (!activeUnit_Navigator.method_10(double_, double_2, ref num5, ref num6, bool_3, bool_4, bool_5, float_2, ref list, true))
						{
							this.activeUnit_0.scenario_0.method_59(string.Concat(new string[]
							{
								"Aircraft ",
								this.activeUnit_0.Name,
								text2,
								" is trying to plot a localization course to pinpoint contact ",
								this.activeUnit_0.vmethod_86().vmethod_3().Name,
								", however the uncertainty area is in a No-Navigation Zone or some other location where the aircraft is not allowed to go! The built-in navigator could not find a suitable spot to start searching."
							}), this.activeUnit_0.Name + " unable to plot exact localization", LoggedMessage.MessageType.AirOps, 0, null, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							return;
						}
						geoPoint.imethod_3(num5);
						geoPoint.imethod_1(num6);
						this.activeUnit_0.scenario_0.method_59(string.Concat(new string[]
						{
							"Aircraft ",
							this.activeUnit_0.Name,
							text2,
							" is trying to plot a localization course to pinpoint contact ",
							this.activeUnit_0.vmethod_86().vmethod_3().Name,
							", however the uncertainty area is in a No-Navigation Zone or some other location where the aircraft is not allowed to go! A new course has been plotted as close as the built-in navigator can take the aircraft."
						}), this.activeUnit_0.Name + " unable to plot exact localization", LoggedMessage.MessageType.AirOps, 0, null, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						Block_11:
						goto IL_674;
						IL_2B7:
						this.activeUnit_0.scenario_0.method_59(string.Concat(new string[]
						{
							this.activeUnit_0.Name,
							text2,
							" is trying to plot a localization course to pinpoint contact ",
							this.activeUnit_0.vmethod_86().vmethod_3().Name,
							", however the target is a naval type and the search area is overland! The built-in navigator could not find a suitable spot to start searching."
						}), this.activeUnit_0.Name + " unable to plot localization", LoggedMessage.MessageType.AirOps, 0, null, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						return;
						IL_365:
						this.activeUnit_0.scenario_0.method_59(string.Concat(new string[]
						{
							this.activeUnit_0.Name,
							text2,
							" is trying to plot a localization course to pinpoint contact ",
							this.activeUnit_0.vmethod_86().vmethod_3().Name,
							", however the target is a ground (facility) type and the search area is at sea! The built-in navigator could not find a suitable spot to start searching."
						}), this.activeUnit_0.Name + " unable to plot localization", LoggedMessage.MessageType.AirOps, 0, null, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						return;
						IL_413:
						this.activeUnit_0.scenario_0.method_59(string.Concat(new string[]
						{
							this.activeUnit_0.Name,
							text2,
							" is trying to plot a localization course to pinpoint contact ",
							this.activeUnit_0.vmethod_86().vmethod_3().Name,
							", however the target is a sub-surface (submarine) type and the search area is under the ice! The built-in navigator could not find a suitable spot to start searching."
						}), this.activeUnit_0.Name + " unable to plot localization", LoggedMessage.MessageType.AirOps, 0, null, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						return;
						IL_674:
						Waypoint waypoint_ = new Waypoint(geoPoint.imethod_0(), geoPoint.imethod_2(), this.activeUnit_0.vmethod_14(false), Waypoint.WaypointType.LocalizationRun, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0);
						this.activeUnit_0.vmethod_85().method_50(waypoint_);
						Doctrine.Enum64? @enum = this.activeUnit_0.doctrine_0.method_83(this.activeUnit_0.scenario_0, false, null, false, false);
						byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							this.activeUnit_0.doctrine_0.method_84(this.activeUnit_0.scenario_0, false, null, false, false, new Doctrine.Enum64?(Doctrine.Enum64.const_0));
							string str = "";
							if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
							{
								str = " (" + this.activeUnit_0.string_2 + ")";
							}
							this.activeUnit_0.method_124(this.activeUnit_0.Name + str + " changed its 'Ignore Plotted Course' doctrine setting from 'Yes' to 'No' (Reason: Need to follow localization course when trying to locate target).", this.activeUnit_0.Name + " - plotted course setting changed", LoggedMessage.MessageType.UnitAI, 5, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100394", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00007F44 File Offset: 0x00006144
		public void method_53(Waypoint waypoint_2, bool bool_17)
		{
			if (this.activeUnit_0.method_122())
			{
				this.activeUnit_0.vmethod_65(false).vmethod_85().method_53(waypoint_2, bool_17);
				return;
			}
			if (bool_17)
			{
				ActiveUnit_Navigator.smethod_3(ref waypoint_2);
			}
			Class429.smethod_37(ref this.waypoint_0, waypoint_2);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x000AD748 File Offset: 0x000AB948
		public static void smethod_2(Scenario scenario_0, Mission mission_0, Mission.Flight flight_1, Waypoint waypoint_2)
		{
			ActiveUnit_Navigator.smethod_3(ref waypoint_2);
			Waypoint[] waypoint_3 = flight_1.method_15();
			Class429.smethod_37(ref waypoint_3, waypoint_2);
			flight_1.method_16(waypoint_3);
			ActiveUnit activeUnit = flight_1.method_32(scenario_0);
			waypoint_3 = flight_1.method_15();
			float num = 0f;
			float num2 = 0f;
			Class514.smethod_28(scenario_0, mission_0, activeUnit, flight_1, ref waypoint_3, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
			flight_1.method_16(waypoint_3);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x000AD7D8 File Offset: 0x000AB9D8
		private static void smethod_3(ref Waypoint waypoint_2)
		{
			if (!Information.IsNothing(waypoint_2.waypoint_0))
			{
				waypoint_2.waypoint_0 = null;
			}
			if (!Information.IsNothing(waypoint_2.waypoint_1))
			{
				waypoint_2.waypoint_1 = null;
			}
			if (!Information.IsNothing(waypoint_2.waypoint_2))
			{
				waypoint_2.waypoint_2 = null;
			}
			if (!Information.IsNothing(waypoint_2.waypoint_3))
			{
				waypoint_2.waypoint_3 = null;
			}
			if (!Information.IsNothing(waypoint_2.waypoint_4))
			{
				waypoint_2.waypoint_4 = null;
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000AD854 File Offset: 0x000ABA54
		public virtual void vmethod_25()
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0.vmethod_65(false)))
				{
					if (!this.activeUnit_0.method_122())
					{
						ActiveUnit activeUnit = this.activeUnit_0.vmethod_65(false).method_147();
						float num = Math2.smethod_17(activeUnit.vmethod_30(null), activeUnit.vmethod_28(null), this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null));
						if (this.method_2().orientationType_0 == ReferencePoint.OrientationType.Rotating)
						{
							this.method_2().float_0 = Class437.smethod_3(activeUnit.vmethod_9(), num);
						}
						else
						{
							this.method_2().float_0 = num;
						}
						this.method_2().float_1 = this.activeUnit_0.method_36(activeUnit);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100223", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x000AD97C File Offset: 0x000ABB7C
		public void method_54(double double_11, double double_12, bool bool_17)
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0.vmethod_65(false)))
				{
					if (!this.activeUnit_0.method_122())
					{
						ActiveUnit activeUnit = this.activeUnit_0.vmethod_65(false).method_147();
						if (!Information.IsNothing(activeUnit))
						{
							if (bool_17 || (this.method_2().float_0 == 0f && this.method_2().float_1 == 0f))
							{
								float num = Math2.smethod_17(activeUnit.vmethod_30(null), activeUnit.vmethod_28(null), double_12, double_11);
								if (this.method_2().orientationType_0 == ReferencePoint.OrientationType.Rotating)
								{
									this.method_2().float_0 = Class437.smethod_3(activeUnit.vmethod_9(), num);
								}
								else
								{
									this.method_2().float_0 = num;
								}
								this.method_2().float_1 = Math2.smethod_15(activeUnit.vmethod_30(null), activeUnit.vmethod_28(null), double_12, double_11);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100224", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x000ADADC File Offset: 0x000ABCDC
		public static ValueTuple<Geopoint_Struct, TimeSpan> smethod_4(Unit unit_0, float float_2, Unit unit_1)
		{
			ValueTuple<Geopoint_Struct, TimeSpan> result;
			try
			{
				float num = unit_0.method_39(unit_1, float_2, unit_0.vmethod_9());
				if (num > 0f && !double.IsNaN((double)num))
				{
					float num2 = (float)((long)Math.Round((double)(unit_0.method_36(unit_1) / num * 3600f)));
					if (unit_1.vmethod_40() == 0f)
					{
						result = new ValueTuple<Geopoint_Struct, TimeSpan>(new Geopoint_Struct(unit_1.vmethod_28(null), unit_1.vmethod_30(null)), TimeSpan.FromSeconds((double)num2));
					}
					else
					{
						float num3 = num2 / 3600f * unit_1.vmethod_40();
						double num4;
						double num5;
						Class411.smethod_1(unit_1.vmethod_28(null), unit_1.vmethod_30(null), ref num4, ref num5, (double)num3, (double)unit_1.vmethod_9());
						result = new ValueTuple<Geopoint_Struct, TimeSpan>(new Geopoint_Struct(num4, num5), TimeSpan.FromSeconds((double)num2));
					}
				}
				else
				{
					result = new ValueTuple<Geopoint_Struct, TimeSpan>(default(Geopoint_Struct), default(TimeSpan));
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100986", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = default(ValueTuple<Geopoint_Struct, TimeSpan>);
			}
			return result;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x000ADC34 File Offset: 0x000ABE34
		public static double? smethod_5(double double_11, double double_12, double double_13, Unit unit_0, float float_2)
		{
			double? result;
			try
			{
				if (Information.IsNothing(unit_0))
				{
					result = null;
				}
				else if (!double.IsInfinity(unit_0.vmethod_30(null)) && !double.IsInfinity(unit_0.vmethod_28(null)))
				{
					if (unit_0.vmethod_40() == 0f)
					{
						result = new double?((double)Math2.smethod_17(double_11, double_12, unit_0.vmethod_30(null), unit_0.vmethod_28(null)));
					}
					else
					{
						double targetX;
						double targetY;
						try
						{
							new Class432.Class433(double_11, double_12).method_1(unit_0.vmethod_30(null), unit_0.vmethod_28(null), ref targetX, ref targetY, false);
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 200009", ex.Message);
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							return null;
						}
						double? num = ActiveUnit_Navigator.smethod_6(0.0, 0.0, double_13, targetX, targetY, (double)unit_0.vmethod_9(), (double)unit_0.vmethod_40(), (double)float_2, true);
						if (num != null)
						{
							result = new double?(Math2.smethod_6(num.Value));
						}
						else
						{
							result = num;
						}
					}
				}
				else
				{
					result = null;
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100225", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000ADE14 File Offset: 0x000AC014
		private static double? smethod_6(double StartX, double StartY, double StartHeading, double TargetX, double TargetY, double TargetHeading, double TargetVelocity, double InterceptVelocity, bool InDegrees = true)
		{
			double? result;
			try
			{
				int num = 1;
				if (InDegrees)
				{
					StartHeading = StartHeading * 3.14159265358979 / 180.0;
					TargetHeading = TargetHeading * 3.14159265358979 / 180.0;
				}
				double num2 = Math.Atan2(TargetX - StartX, TargetY - StartY);
				double num3 = StartHeading - num2;
				double num4 = TargetHeading - num2;
				double num5 = (double)num * Math.Sin(num3);
				double num6 = (double)num * Math.Cos(num3);
				double num7 = TargetVelocity * Math.Sin(num4);
				double num8 = TargetVelocity * Math.Cos(num4);
				double num9 = Math.Asin((num7 - num5) / InterceptVelocity);
				double num10 = Math.Cos(num9) * InterceptVelocity;
				if (!double.IsNaN(num9) && num8 - num6 < num10)
				{
					double? num11 = new double?(InDegrees ? ((num9 + num2) * 180.0 / 3.14159265358979) : (num9 + num2));
					num11 = new double?(Math2.smethod_6(num11.Value));
					result = num11;
				}
				else
				{
					double? num11;
					result = num11;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100226", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x000ADF58 File Offset: 0x000AC158
		private bool method_55(double double_11, double double_12, double double_13, double double_14)
		{
			bool result;
			try
			{
				string text = Terrain.smethod_3(ref double_11, ref double_12);
				string text2 = Terrain.smethod_3(ref double_13, ref double_14);
				if (Operators.CompareString(text, text2, false) != 0)
				{
					result = false;
				}
				else
				{
					int num;
					int num2;
					Terrain.dictionary_0[text][0].method_2(ref double_12, ref double_11, ref num, ref num2);
					int num3;
					int num4;
					Terrain.dictionary_0[text2][0].method_2(ref double_14, ref double_13, ref num3, ref num4);
					if (num2 == num4 && num == num3)
					{
						result = true;
					}
					else if (Math.Abs(num2 - num4) < 2 && Math.Abs(num - num3) < 2)
					{
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100227", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x000AE040 File Offset: 0x000AC240
		private void method_56(List<Waypoint> list_1, bool bool_17, float float_2, ref bool bool_18, ref Mission.Flight flight_1, ref bool bool_19)
		{
			if (!Information.IsNothing(list_1))
			{
				int count = list_1.Count;
				if (list_1.Count <= 2)
				{
					bool_18 = true;
					return;
				}
				float float_3;
				if (float_2 > 0f)
				{
					float_3 = 0.15f;
				}
				else
				{
					float_3 = 0f;
				}
				double double_;
				double double_2;
				if (!Information.IsNothing(flight_1) && !bool_19 && !Information.IsNothing(flight_1.contact_0))
				{
					double_ = flight_1.contact_0.vmethod_30(null);
					double_2 = flight_1.contact_0.vmethod_28(null);
				}
				else
				{
					double_ = this.activeUnit_0.vmethod_30(null);
					double_2 = this.activeUnit_0.vmethod_28(null);
				}
				try
				{
					IL_258:
					while (!bool_18)
					{
						bool_18 = true;
						Waypoint waypoint = null;
						count = list_1.Count;
						int value = this.activeUnit_0.vmethod_85().int_2;
						int num = count - 1;
						int i = 0;
						while (i <= num)
						{
							Waypoint waypoint2;
							try
							{
								waypoint2 = list_1[i];
							}
							catch (Exception ex)
							{
								ex.Data.Add("Error at 200427", ex.Message);
								GameGeneral.smethod_25(ref ex);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								goto IL_21B;
							}
							goto IL_130;
							IL_21B:
							i++;
							continue;
							IL_130:
							if (waypoint2.waypointType_0 != Waypoint.WaypointType.PathfindingPoint)
							{
								goto IL_21B;
							}
							int num2 = list_1.IndexOf(waypoint2);
							if (num2 >= count - 1)
							{
								goto IL_21B;
							}
							Waypoint waypoint3 = list_1[num2 + 1];
							if (num2 == 0)
							{
								if (!this.method_55(double_, double_2, waypoint3.imethod_2(), waypoint3.imethod_0()))
								{
									if (this.vmethod_29(double_, double_2, waypoint3.imethod_2(), waypoint3.imethod_0(), true, float_3, false, new int?(value), true, true, false, null))
									{
										goto IL_21B;
									}
									waypoint = waypoint2;
								}
								else
								{
									waypoint = waypoint2;
								}
							}
							else
							{
								Waypoint waypoint4 = list_1[num2 - 1];
								if (!this.method_55(waypoint4.imethod_2(), waypoint4.imethod_0(), waypoint3.imethod_2(), waypoint3.imethod_0()))
								{
									if (this.vmethod_29(waypoint4.imethod_2(), waypoint4.imethod_0(), waypoint3.imethod_2(), waypoint3.imethod_0(), true, float_3, false, new int?(value), true, true, false, null))
									{
										goto IL_21B;
									}
									waypoint = waypoint2;
								}
								else
								{
									waypoint = waypoint2;
								}
							}
							IL_242:
							if (!Information.IsNothing(waypoint))
							{
								list_1.Remove(waypoint);
								bool_18 = false;
								goto IL_258;
							}
							goto IL_258;
						}
						goto IL_242;
					}
					if (bool_17)
					{
						bool_18 = false;
						IL_3CA:
						while (!bool_18)
						{
							bool_18 = true;
							Waypoint waypoint5 = null;
							count = list_1.Count;
							int value2 = this.activeUnit_0.vmethod_85().int_2;
							for (int j = count - 1; j >= 0; j += -1)
							{
								Waypoint waypoint2 = list_1[j];
								if (waypoint2.waypointType_0 == Waypoint.WaypointType.PathfindingPoint)
								{
									int num3 = list_1.IndexOf(waypoint2);
									if (num3 < count - 1)
									{
										Waypoint waypoint6 = list_1[num3 + 1];
										if (num3 == 0)
										{
											if (!this.method_55(double_, double_2, waypoint6.imethod_2(), waypoint6.imethod_0()))
											{
												if (this.vmethod_29(double_, double_2, waypoint6.imethod_2(), waypoint6.imethod_0(), true, float_3, false, new int?(value2), true, true, false, null))
												{
													goto IL_38E;
												}
												waypoint5 = waypoint2;
											}
											else
											{
												waypoint5 = waypoint2;
											}
										}
										else
										{
											Waypoint waypoint7 = list_1[num3 - 1];
											if (!this.method_55(waypoint6.imethod_2(), waypoint6.imethod_0(), waypoint7.imethod_2(), waypoint7.imethod_0()))
											{
												if (this.vmethod_29(waypoint6.imethod_2(), waypoint6.imethod_0(), waypoint7.imethod_2(), waypoint7.imethod_0(), true, float_3, false, new int?(value2), true, true, false, null))
												{
													goto IL_38E;
												}
												waypoint5 = waypoint2;
											}
											else
											{
												waypoint5 = waypoint2;
											}
										}
										IL_3B4:
										if (!Information.IsNothing(waypoint5))
										{
											list_1.Remove(waypoint5);
											bool_18 = false;
											goto IL_3CA;
										}
										goto IL_3CA;
									}
								}
								IL_38E:;
							}
							goto IL_3B4;
						}
					}
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 100228", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x000AE490 File Offset: 0x000AC690
		public virtual bool vmethod_26()
		{
			if (Information.IsNothing(this.nullable_7))
			{
				if (this.activeUnit_0.bool_3)
				{
					this.nullable_7 = new bool?(false);
				}
				else
				{
					this.nullable_7 = new bool?(true);
				}
			}
			return this.nullable_7.Value;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000AE4E4 File Offset: 0x000AC6E4
		protected virtual List<Waypoint> vmethod_27(double double_11, double double_12, double double_13, double double_14, float float_2, bool bool_17, float float_3, ref List<ActiveUnit> list_1, bool bool_18)
		{
			List<Waypoint> list = new List<Waypoint>();
			List<Waypoint> result;
			try
			{
				if (!this.vmethod_26() && bool_17)
				{
					float float_4;
					if (float_3 > 0f)
					{
						float_4 = 15f;
					}
					else
					{
						float_4 = 5f;
					}
					GeoPoint geoPoint = this.method_58(double_11, double_12, double_13, double_14, float_4, null, float_3, ref list_1);
					GeoPoint geoPoint2 = this.method_58(double_13, double_14, double_11, double_12, float_4, null, float_3, ref list_1);
					if (!Information.IsNothing(geoPoint) && !Information.IsNothing(geoPoint2))
					{
						list = this.vmethod_27(geoPoint.imethod_2(), geoPoint.imethod_0(), geoPoint2.imethod_2(), geoPoint2.imethod_0(), float_2, false, float_3, ref list_1, bool_18);
						if (!Information.IsNothing(list))
						{
							list.Insert(0, new Waypoint(double_12, double_11, 0f, Waypoint.WaypointType.PathfindingPoint, Waypoint.Enum80.const_0, Waypoint.Enum79.const_0));
							if (this.activeUnit_0.bool_3)
							{
								list.Add(new Waypoint(double_14, double_13, 0f, Waypoint.WaypointType.PathfindingPoint, Waypoint.Enum80.const_0, Waypoint.Enum79.const_0));
							}
							else
							{
								Unit unit = this.activeUnit_0;
								int num = 0;
								bool flag = true;
								bool flag2 = true;
								bool flag3 = false;
								bool flag4 = true;
								bool flag5 = true;
								bool flag6 = true;
								float? nullable_ = null;
								short? nullable_2 = null;
								bool bool_19 = false;
								bool bool_20 = false;
								string text = "";
								bool flag7 = false;
								if (unit.vmethod_47(double_13, double_14, ref num, flag, flag2, flag3, ref flag4, flag5, ref flag6, nullable_, nullable_2, ref list_1, float_3, bool_19, bool_20, ref text, ref flag7) && !this.activeUnit_0.vmethod_85().vmethod_29(double_13, double_14, list[list.Count - 1].imethod_2(), list[list.Count - 1].imethod_0(), false, 0f, true, null, true, true, false, new float?(Class522.interface9_1.imethod_1())))
								{
									list.Add(new Waypoint(double_14, double_13, 0f, Waypoint.WaypointType.PathfindingPoint, Waypoint.Enum80.const_0, Waypoint.Enum79.const_0));
								}
							}
						}
						result = list;
					}
					else
					{
						result = list;
					}
				}
				else
				{
					if (this.activeUnit_0.bool_3 || Math2.smethod_15(double_11, double_12, double_13, double_14) >= this.activeUnit_0.scenario_0.Navigation_FinegrainedMaxDistance)
					{
						float num2 = 2f;
						float num3 = 1f;
						while (!this.activeUnit_0.scenario_0.ThreadedOpsMustStop)
						{
							if (this.vmethod_26())
							{
								list = Class522.interface9_1.imethod_3(this.activeUnit_0, double_11, double_12, double_13, double_14, float_2, num2, float_3, ref list_1, ref this.float_1, bool_18, true);
							}
							else
							{
								list = Class522.interface9_0.imethod_3(this.activeUnit_0, double_11, double_12, double_13, double_14, float_2, num2, float_3, ref list_1, ref this.float_1, bool_18, false);
							}
							if (!Information.IsNothing(list))
							{
								goto IL_359;
							}
							if (num2 == 2f)
							{
								num2 = 5f;
							}
							else if (num2 == 5f)
							{
								num2 = 20f;
							}
							else if (num2 == 20f)
							{
								goto IL_359;
							}
							num3 += 1f;
							if (num3 > 3f)
							{
								goto IL_359;
							}
						}
						this.bool_2 = false;
						return null;
					}
					if (this.activeUnit_0.scenario_0.ThreadedOpsMustStop)
					{
						this.bool_2 = false;
						return null;
					}
					if (this.vmethod_26())
					{
						list = Class522.interface9_1.imethod_2(this.activeUnit_0, double_11, double_12, double_13, double_14, float_2, this.activeUnit_0.scenario_0.Navigation_FinegrainedThresholdDistance, float_3, ref list_1, ref this.float_1, bool_18);
					}
					else
					{
						list = Class522.interface9_0.imethod_2(this.activeUnit_0, double_11, double_12, double_13, double_14, float_2, this.activeUnit_0.scenario_0.Navigation_FinegrainedThresholdDistance, float_3, ref list_1, ref this.float_1, bool_18);
					}
					IL_359:
					result = list;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100229", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x000AE8A4 File Offset: 0x000ACAA4
		private List<Geopoint_Struct> method_57(double double_11, double double_12, double double_13, double double_14, double double_15, float float_2, float float_3, ref List<ActiveUnit> list_1)
		{
			List<Geopoint_Struct> result;
			try
			{
				List<Geopoint_Struct> list = new List<Geopoint_Struct>();
				float num;
				float val = num = (float)(double_15 / 100.0);
				float num2 = (float)double_15;
				float num3 = Math.Max(val, 1f);
				bool flag = num3 >= 0f;
				float num4 = num;
				IL_16B:
				while (flag ? (num4 <= num2) : (num4 >= num2))
				{
					short num5 = 180;
					while (!this.activeUnit_0.scenario_0.ThreadedOpsMustStop)
					{
						double num6;
						double num7;
						Class411.smethod_1(double_13, double_14, ref num6, ref num7, (double)num4, (double)(float_2 + (float)num5));
						Unit unit = this.activeUnit_0;
						double num8 = num6;
						double num9 = num7;
						int num10 = 0;
						bool flag2 = true;
						bool flag3 = true;
						bool flag4 = false;
						bool flag5 = true;
						bool flag6 = true;
						bool flag7 = true;
						float? nullable_ = null;
						short? nullable_2 = null;
						bool bool_ = true;
						bool bool_2 = false;
						string text = "";
						bool flag8 = false;
						if (unit.vmethod_47(num8, num9, ref num10, flag2, flag3, flag4, ref flag5, flag6, ref flag7, nullable_, nullable_2, ref list_1, float_3, bool_, bool_2, ref text, ref flag8))
						{
							list.Add(new Geopoint_Struct(num7, num6));
						}
						Class411.smethod_1(double_13, double_14, ref num6, ref num7, (double)num4, (double)(float_2 - (float)num5));
						Unit unit2 = this.activeUnit_0;
						double num11 = num6;
						double num12 = num7;
						num10 = 0;
						bool flag9 = true;
						bool flag10 = true;
						bool flag11 = false;
						flag8 = true;
						bool flag12 = true;
						flag7 = true;
						float? nullable_3 = null;
						short? nullable_4 = null;
						bool bool_3 = true;
						bool bool_4 = false;
						text = "";
						flag5 = false;
						if (unit2.vmethod_47(num11, num12, ref num10, flag9, flag10, flag11, ref flag8, flag12, ref flag7, nullable_3, nullable_4, ref list_1, float_3, bool_3, bool_4, ref text, ref flag5))
						{
							list.Add(new Geopoint_Struct(num7, num6));
						}
						num5 += -1;
						if (num5 < 0)
						{
							num4 += num3;
							goto IL_16B;
						}
					}
					return result;
				}
				result = list;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100230", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x000AEA80 File Offset: 0x000ACC80
		protected virtual void vmethod_28(Waypoint waypoint_2, ActiveUnit activeUnit_1, Mission.Flight flight_1, bool bool_17, float float_2, double double_11, double double_12, bool bool_18)
		{
			try
			{
				bool bool_19 = false;
				double num;
				double num2;
				float float_3;
				if (Information.IsNothing(waypoint_2))
				{
					if (!Information.IsNothing(activeUnit_1))
					{
						num = activeUnit_1.vmethod_30(null);
						num2 = activeUnit_1.vmethod_28(null);
						float_3 = activeUnit_1.vmethod_9();
					}
					else if (!Information.IsNothing(flight_1))
					{
						bool_19 = true;
						if (bool_17)
						{
							num = flight_1.method_32(null).vmethod_30(null);
							num2 = flight_1.method_32(null).vmethod_28(null);
							float_3 = flight_1.method_32(null).vmethod_9();
						}
						else if (!Information.IsNothing(flight_1.contact_0))
						{
							num = flight_1.contact_0.vmethod_30(null);
							num2 = flight_1.contact_0.vmethod_28(null);
							float_3 = Math2.smethod_17(num, num2, double_11, double_12);
						}
						else
						{
							num = flight_1.method_32(null).vmethod_30(null);
							num2 = flight_1.method_32(null).vmethod_28(null);
							float_3 = flight_1.method_32(null).vmethod_9();
						}
					}
				}
				else
				{
					num = waypoint_2.imethod_2();
					num2 = waypoint_2.imethod_0();
					float_3 = Math2.smethod_17(num, num2, double_11, double_12);
				}
				List<ActiveUnit> list;
				if (!Information.IsNothing(activeUnit_1) && float_2 == 0.15f)
				{
					Unit unit = this.activeUnit_0;
					double num3 = num;
					double num4 = num2;
					int num5 = 0;
					bool flag = true;
					bool flag2 = true;
					bool flag3 = false;
					bool flag4 = true;
					bool flag5 = true;
					bool flag6 = true;
					float? nullable_ = new float?(0f);
					short? nullable_2 = null;
					bool bool_20 = false;
					string text = "";
					bool flag7 = false;
					if (!unit.vmethod_47(num3, num4, ref num5, flag, flag2, flag3, ref flag4, flag5, ref flag6, nullable_, nullable_2, ref list, float_2, bool_18, bool_20, ref text, ref flag7) && !this.method_10(num, num2, ref num, ref num2, true, true, false, float_2, ref list, bool_18))
					{
						return;
					}
					Unit unit2 = this.activeUnit_0;
					double num6 = double_11;
					double num7 = double_12;
					num5 = 0;
					bool flag8 = true;
					bool flag9 = true;
					bool flag10 = false;
					flag7 = true;
					bool flag11 = true;
					flag6 = true;
					float? nullable_3 = new float?(0f);
					short? nullable_4 = null;
					bool bool_21 = false;
					text = "";
					flag4 = false;
					if (!unit2.vmethod_47(num6, num7, ref num5, flag8, flag9, flag10, ref flag7, flag11, ref flag6, nullable_3, nullable_4, ref list, float_2, bool_18, bool_21, ref text, ref flag4) && !this.method_10(double_11, double_12, ref double_11, ref double_12, true, true, false, float_2, ref list, bool_18))
					{
						return;
					}
				}
				if (!Information.IsNothing(activeUnit_1))
				{
					double num8 = double_11;
					double num9 = double_12;
					int num5 = 0;
					bool flag12 = true;
					bool flag13 = true;
					bool flag14 = false;
					bool flag4 = true;
					bool flag15 = true;
					bool flag6 = true;
					float? nullable_5 = null;
					short? nullable_6 = null;
					bool bool_22 = false;
					bool bool_23 = false;
					string text = "";
					bool flag7 = false;
					if (activeUnit_1.vmethod_47(num8, num9, ref num5, flag12, flag13, flag14, ref flag4, flag15, ref flag6, nullable_5, nullable_6, ref list, float_2, bool_22, bool_23, ref text, ref flag7))
					{
						activeUnit_1.vmethod_86().geopoint_Struct_0 = new Geopoint_Struct(double_12, double_11);
						List<Waypoint> list2 = this.vmethod_27(num, num2, double_11, double_12, float_3, true, float_2, ref list, bool_19);
						if (!Information.IsNothing(list2) && list2.Count == 0)
						{
							return;
						}
						this.list_0 = list2;
						goto IL_48C;
					}
				}
				if (!Information.IsNothing(flight_1) && !Information.IsNothing(flight_1.method_32(null)))
				{
					Unit unit3 = flight_1.method_32(null);
					double num10 = double_11;
					double num11 = double_12;
					int num5 = 0;
					bool flag16 = true;
					bool flag17 = true;
					bool flag18 = false;
					bool flag7 = true;
					bool flag19 = true;
					bool flag6 = true;
					float? nullable_7 = null;
					short? nullable_8 = null;
					bool bool_24 = false;
					bool bool_25 = false;
					string text = "";
					bool flag4 = false;
					if (unit3.vmethod_47(num10, num11, ref num5, flag16, flag17, flag18, ref flag7, flag19, ref flag6, nullable_7, nullable_8, ref list, float_2, bool_24, bool_25, ref text, ref flag4))
					{
						List<Waypoint> list2 = flight_1.method_32(null).vmethod_85().vmethod_27(num, num2, double_11, double_12, float_3, true, float_2, ref list, bool_19);
						if (!Information.IsNothing(list2) && list2.Count == 0)
						{
							return;
						}
						this.list_0 = list2;
						goto IL_48C;
					}
				}
				try
				{
					double num12 = (double)Math2.smethod_15(num, num2, double_11, double_12);
					double num13 = Math2.smethod_14(num, num2, double_11, double_12);
					if (num12 > 0.0)
					{
						List<Geopoint_Struct> list3 = this.method_57(num, num2, double_11, double_12, num12, float_3, float_2, ref list);
						try
						{
							foreach (Geopoint_Struct geopoint_Struct in list3)
							{
								if (GeoPoint.smethod_1(geopoint_Struct.double_0, geopoint_Struct.double_1, double_12, double_11) <= num13)
								{
									if (!Information.IsNothing(activeUnit_1))
									{
										activeUnit_1.vmethod_86().geopoint_Struct_0 = geopoint_Struct;
									}
									List<Waypoint> list2 = this.vmethod_27(num, num2, geopoint_Struct.double_1, geopoint_Struct.double_0, float_3, true, float_2, ref list, bool_19);
									if (!Information.IsNothing(list2))
									{
										this.list_0 = list2;
										break;
									}
								}
							}
						}
						finally
						{
							List<Geopoint_Struct>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200010", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				IL_48C:;
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100231", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x000AEFA0 File Offset: 0x000AD1A0
		public GeoPoint method_58(double double_11, double double_12, double double_13, double double_14, float float_2, int? nullable_8, float float_3, ref List<ActiveUnit> list_1)
		{
			GeoPoint result;
			try
			{
				double num = double_11;
				double num2 = double_12;
				float num3 = Math2.smethod_15(double_11, double_12, double_13, double_14);
				if (!float.IsNaN(num3))
				{
					if (num3 != 0f)
					{
						float num4;
						if (!this.activeUnit_0.bool_3)
						{
							if (num3 < this.activeUnit_0.scenario_0.Navigation_FinegrainedMaxDistance)
							{
								if (this.vmethod_26())
								{
									num4 = Class522.interface9_1.imethod_1();
								}
								else
								{
									num4 = Class522.interface9_0.imethod_1();
								}
							}
							else if (this.vmethod_26())
							{
								num4 = Class522.interface9_1.imethod_0();
							}
							else
							{
								num4 = Class522.interface9_0.imethod_0();
							}
						}
						else if (this.vmethod_26())
						{
							num4 = Class522.interface9_1.imethod_0();
						}
						else
						{
							num4 = Class522.interface9_0.imethod_0();
						}
						Struct65 @struct = default(Struct65);
						@struct.method_1(double_12);
						Struct65 struct2 = default(Struct65);
						struct2.method_1(double_11);
						Struct65 struct3 = default(Struct65);
						struct3.method_1(double_14);
						Struct65 struct4 = default(Struct65);
						struct4.method_1(double_13);
						Struct65 struct5 = default(Struct65);
						Struct65 struct6 = default(Struct65);
						Struct65 d = Class1874.smethod_1(struct2, @struct, struct4, struct3);
						float num5 = (float)d.method_0();
						if (num5 < num4 * 2f)
						{
							return null;
						}
						int num6 = (int)Math.Round((double)(num5 / num4));
						for (int i = 1; i <= num6; i++)
						{
							Class1874.smethod_2(num4 * (float)i / num5, struct2, @struct, struct4, struct3, d, out struct6, out struct5);
							double num7 = struct6.method_0();
							double num8 = struct5.method_0();
							bool isAttached = Debugger.IsAttached;
							Unit unit = this.activeUnit_0;
							double num9 = num7;
							double num10 = num8;
							int num11 = 0;
							bool flag = true;
							bool flag2 = true;
							bool flag3 = false;
							bool flag4 = true;
							bool flag5 = true;
							bool flag6 = true;
							float? nullable_9 = (nullable_8 != null) ? new float?((float)nullable_8.GetValueOrDefault()) : null;
							short? nullable_10 = null;
							bool bool_ = false;
							bool bool_2 = false;
							string text = "";
							bool flag7 = false;
							if (!unit.vmethod_47(num9, num10, ref num11, flag, flag2, flag3, ref flag4, flag5, ref flag6, nullable_9, nullable_10, ref list_1, float_3, bool_, bool_2, ref text, ref flag7))
							{
								break;
							}
							num = num7;
							num2 = num8;
						}
						float num12 = Math2.smethod_15(double_11, double_12, num, num2);
						float num13;
						if (num12 > float_2)
						{
							num13 = num12 - float_2;
						}
						else
						{
							num13 = (float)((double)num12 * 0.2);
						}
						float num14 = Math2.smethod_17(double_11, double_12, double_13, double_14);
						double num15;
						double num16;
						Class411.smethod_1(double_12, double_11, ref num15, ref num16, (double)num13, (double)num14);
						return new GeoPoint(num15, num16);
					}
				}
				result = null;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100232", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x000AF24C File Offset: 0x000AD44C
		public bool method_59(double double_11, double double_12, double double_13, double double_14, float float_2)
		{
			Tuple<double, double> tuple_ = new Tuple<double, double>(Class437.smethod_6(double_11), Class437.smethod_6(double_12));
			Tuple<double, double> tuple_2 = new Tuple<double, double>(Class437.smethod_6(double_13), Class437.smethod_6(double_14));
			double num = Math.Min(Class437.smethod_6(double_11), Class437.smethod_6(double_13));
			double num2 = Math.Max(Class437.smethod_6(double_11), Class437.smethod_6(double_13));
			double num3 = Math.Min(Class437.smethod_6(double_12), Class437.smethod_6(double_14));
			double num4 = Math.Max(Class437.smethod_6(double_12), Class437.smethod_6(double_14));
			try
			{
				foreach (NoNavZone noNavZone in this.activeUnit_0.vmethod_7(false).list_7)
				{
					if (noNavZone.list_0.Count != 0 && noNavZone.method_8(this.activeUnit_0))
					{
						List<Tuple<Tuple<double, double>, Tuple<double, double>>> list;
						if (float_2 == 0.2f)
						{
							if (noNavZone.list_3.Count == 0 || noNavZone.method_12(noNavZone.list_1))
							{
								noNavZone.method_9(float_2, ref noNavZone.list_3, ref noNavZone.list_1);
							}
							list = Enumerable.ToList<Tuple<Tuple<double, double>, Tuple<double, double>>>(Enumerable.Zip<GeoPoint, GeoPoint, Tuple<Tuple<double, double>, Tuple<double, double>>>(Enumerable.Take<GeoPoint>(noNavZone.list_3, noNavZone.list_3.Count - 1), Enumerable.Skip<GeoPoint>(noNavZone.list_3, 1), (ActiveUnit_Navigator._Closure$__.$I186-0 == null) ? (ActiveUnit_Navigator._Closure$__.$I186-0 = new Func<GeoPoint, GeoPoint, Tuple<Tuple<double, double>, Tuple<double, double>>>(ActiveUnit_Navigator._Closure$__.$I.method_3)) : ActiveUnit_Navigator._Closure$__.$I186-0));
							if (list.Count > 0)
							{
								list.Add(new Tuple<Tuple<double, double>, Tuple<double, double>>(Enumerable.Last<Tuple<Tuple<double, double>, Tuple<double, double>>>(list).Item2, Enumerable.First<Tuple<Tuple<double, double>, Tuple<double, double>>>(list).Item1));
							}
						}
						else if (float_2 == 0.15f)
						{
							if (noNavZone.list_4.Count == 0 || noNavZone.method_12(noNavZone.list_2))
							{
								noNavZone.method_9(float_2, ref noNavZone.list_4, ref noNavZone.list_2);
							}
							list = Enumerable.ToList<Tuple<Tuple<double, double>, Tuple<double, double>>>(Enumerable.Zip<GeoPoint, GeoPoint, Tuple<Tuple<double, double>, Tuple<double, double>>>(Enumerable.Take<GeoPoint>(noNavZone.list_4, noNavZone.list_4.Count - 1), Enumerable.Skip<GeoPoint>(noNavZone.list_4, 1), (ActiveUnit_Navigator._Closure$__.$I186-1 == null) ? (ActiveUnit_Navigator._Closure$__.$I186-1 = new Func<GeoPoint, GeoPoint, Tuple<Tuple<double, double>, Tuple<double, double>>>(ActiveUnit_Navigator._Closure$__.$I.method_4)) : ActiveUnit_Navigator._Closure$__.$I186-1));
							if (list.Count > 0)
							{
								list.Add(new Tuple<Tuple<double, double>, Tuple<double, double>>(Enumerable.Last<Tuple<Tuple<double, double>, Tuple<double, double>>>(list).Item2, Enumerable.First<Tuple<Tuple<double, double>, Tuple<double, double>>>(list).Item1));
							}
						}
						else
						{
							list = new List<Tuple<Tuple<double, double>, Tuple<double, double>>>();
							int num5 = noNavZone.list_0.Count - 2;
							for (int i = 0; i <= num5; i++)
							{
								ReferencePoint referencePoint = noNavZone.list_0[i];
								ReferencePoint referencePoint2 = noNavZone.list_0[i + 1];
								list.Add(new Tuple<Tuple<double, double>, Tuple<double, double>>(new Tuple<double, double>(Class437.smethod_6(referencePoint.imethod_2()), Class437.smethod_6(referencePoint.imethod_0())), new Tuple<double, double>(Class437.smethod_6(referencePoint2.imethod_2()), Class437.smethod_6(referencePoint2.imethod_0()))));
							}
							list.Add(new Tuple<Tuple<double, double>, Tuple<double, double>>(Enumerable.Last<Tuple<Tuple<double, double>, Tuple<double, double>>>(list).Item2, Enumerable.First<Tuple<Tuple<double, double>, Tuple<double, double>>>(list).Item1));
						}
						try
						{
							foreach (Tuple<Tuple<double, double>, Tuple<double, double>> tuple in list)
							{
								Tuple<double, double> tuple2 = Math2.smethod_35(tuple_, tuple_2, tuple.Item1, tuple.Item2);
								if (!Information.IsNothing(tuple2))
								{
									double num6 = Math.Min(tuple.Item1.Item1, tuple.Item2.Item1);
									double num7 = Math.Max(tuple.Item1.Item1, tuple.Item2.Item1);
									double num8 = Math.Min(tuple.Item1.Item2, tuple.Item2.Item2);
									double num9 = Math.Max(tuple.Item1.Item2, tuple.Item2.Item2);
									if (tuple2.Item1 < num2 && tuple2.Item1 > num && tuple2.Item2 < num4 && tuple2.Item2 > num3 && tuple2.Item1 < num7 && tuple2.Item1 > num6 && tuple2.Item2 < num9 && tuple2.Item2 > num8)
									{
										return true;
									}
								}
							}
						}
						finally
						{
							List<Tuple<Tuple<double, double>, Tuple<double, double>>>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
			}
			finally
			{
				List<NoNavZone>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return false;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x000AF6E8 File Offset: 0x000AD8E8
		public virtual bool vmethod_29(double double_11, double double_12, double double_13, double double_14, bool bool_17, float float_2, bool bool_18, int? nullable_8, bool bool_19, bool bool_20, bool bool_21, float? nullable_9)
		{
			bool result;
			try
			{
				if (bool_18)
				{
					bool flag = false;
					Unit unit = this.activeUnit_0;
					double num = this.activeUnit_0.vmethod_30(null);
					double num2 = this.activeUnit_0.vmethod_28(null);
					int num3 = 0;
					bool flag2 = false;
					bool flag3 = false;
					bool flag4 = true;
					float? nullable_10 = new float?(0f);
					short? nullable_11 = null;
					List<ActiveUnit> list = null;
					float float_3 = 0f;
					bool bool_22 = false;
					bool bool_23 = false;
					string text = "";
					bool flag5 = false;
					if (!unit.vmethod_47(num, num2, ref num3, bool_19, bool_20, flag2, ref flag3, flag4, ref flag, nullable_10, nullable_11, ref list, float_3, bool_22, bool_23, ref text, ref flag5) && !flag)
					{
						return false;
					}
					if (flag)
					{
						return true;
					}
				}
				if (this.method_59(double_11, double_12, double_13, double_14, float_2))
				{
					result = true;
				}
				else
				{
					float num4 = Math2.smethod_15(double_11, double_12, double_13, double_14);
					if (!float.IsNaN(num4))
					{
						if (num4 != 0f)
						{
							if (Information.IsNothing(nullable_9))
							{
								if (!this.activeUnit_0.bool_3)
								{
									if (num4 < this.activeUnit_0.scenario_0.Navigation_FinegrainedMaxDistance)
									{
										if (this.vmethod_26())
										{
											nullable_9 = new float?(Class522.interface9_1.imethod_1());
										}
										else
										{
											nullable_9 = new float?(Class522.interface9_0.imethod_1());
										}
									}
									else if (this.vmethod_26())
									{
										nullable_9 = new float?(Class522.interface9_1.imethod_0());
									}
									else
									{
										nullable_9 = new float?(Class522.interface9_0.imethod_0());
									}
								}
								else if (this.vmethod_26())
								{
									nullable_9 = new float?(Class522.interface9_1.imethod_0());
								}
								else
								{
									nullable_9 = new float?(Class522.interface9_0.imethod_0());
								}
							}
							if (Information.IsNothing(nullable_9))
							{
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								return true;
							}
							bool result2 = false;
							Struct65 @struct = default(Struct65);
							@struct.method_1(double_12);
							Struct65 struct2 = default(Struct65);
							struct2.method_1(double_11);
							Struct65 struct3 = default(Struct65);
							struct3.method_1(double_14);
							Struct65 struct4 = default(Struct65);
							struct4.method_1(double_13);
							Struct65 d = Class1874.smethod_1(struct2, @struct, struct4, struct3);
							float num5 = (float)d.method_0();
							float num6 = num5;
							float? num7 = nullable_9 * 2f;
							if (((num7 != null) ? new bool?(num6 < num7.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								return false;
							}
							int num8 = (int)Math.Round((double)(num5 / nullable_9).Value);
							Struct65 struct5 = default(Struct65);
							Struct65 struct6 = default(Struct65);
							int num3 = num8;
							for (int i = 1; i <= num3; i++)
							{
								Class1874.smethod_2(nullable_9.Value * (float)i / num5, struct2, @struct, struct4, struct3, d, out struct6, out struct5);
								double num9 = struct6.method_0();
								double num10 = struct5.method_0();
								Unit unit2 = this.activeUnit_0;
								double num11 = num9;
								double num12 = num10;
								int num13 = 0;
								bool flag5 = false;
								bool flag6 = false;
								bool flag3 = true;
								float? nullable_12 = (nullable_8 != null) ? new float?((float)nullable_8.GetValueOrDefault()) : null;
								short? nullable_13 = null;
								bool bool_24 = false;
								bool bool_25 = false;
								string text = "";
								bool flag7 = false;
								List<ActiveUnit> list2;
								if (!unit2.vmethod_47(num11, num12, ref num13, bool_19, bool_20, bool_21, ref flag5, flag6, ref flag3, nullable_12, nullable_13, ref list2, float_2, bool_24, bool_25, ref text, ref flag7))
								{
									result2 = true;
									IL_367:
									return result2;
								}
							}
							goto IL_367;
						}
					}
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100233", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x000AFABC File Offset: 0x000ADCBC
		public static bool smethod_7(ref List<ReferencePoint> list_1, ref string string_1, Side side_0, Scenario scenario_0, string string_2)
		{
			bool result;
			try
			{
				if (list_1.Count >= 3)
				{
					int count = list_1.Count;
					string text;
					if (!Information.IsNothing(side_0))
					{
						text = side_0.method_51();
					}
					else
					{
						text = "";
					}
					Class432.Class433 @class = new Class432.Class433(list_1[0].imethod_2(), list_1[0].imethod_0());
					Coordinate[] array = new Coordinate[count + 1];
					bool flag = false;
					int num = count - 1;
					for (int i = 0; i <= num; i++)
					{
						double num2;
						double num3;
						if (!@class.method_1(list_1[i].imethod_2(), list_1[i].imethod_0(), ref num2, ref num3, true))
						{
							flag = true;
							IL_AC:
							if (flag)
							{
								if (Math2.smethod_28(ref list_1))
								{
									int num4 = count - 1;
									for (int j = 0; j <= num4; j++)
									{
										Coordinate[] array2 = array;
										int num5 = j;
										double num6 = list_1[j].imethod_0() + 180.0;
										array2[num5] = new Coordinate(Math2.smethod_11(ref num6), list_1[j].imethod_2());
									}
								}
								else
								{
									int num7 = count - 1;
									for (int k = 0; k <= num7; k++)
									{
										num2 = Class412.smethod_0(list_1[k].imethod_0());
										num3 = Class412.smethod_1(list_1[k].imethod_2());
										array[k] = new Coordinate(num2, num3);
									}
								}
							}
							array[count] = array[0];
							Polygon polygon = new Polygon(new LinearRing(array));
							try
							{
								if (polygon.vmethod_0())
								{
									string_1 = "";
									return true;
								}
								if (string.IsNullOrEmpty(string_2) && string.IsNullOrEmpty(text))
								{
									string_1 = "WARNING! Area validation has FAILED! The polygon that makes up the area crosses itself which means it is INVALID! This will cause problems for the AI navigator. Please check the shape of the area, and make sure that it doesn't cross itself at any point!";
								}
								else if (string.IsNullOrEmpty(text))
								{
									string_1 = "WARNING! Area validation for " + string_2 + " has FAILED! The polygon that makes up the area crosses itself which means it is INVALID! This will cause problems for the AI navigator. Please check the shape of the area, and make sure that it doesn't cross itself at any point!";
								}
								else
								{
									string_1 = string.Concat(new string[]
									{
										"WARNING! Area validation for ",
										string_2,
										" belonging to side ",
										text,
										" has FAILED! The polygon that makes up the area crosses itself which means it is INVALID! This will cause problems for the AI navigator. Please check the shape of the area, and make sure that it doesn't cross itself at any point!"
									});
								}
								return false;
							}
							catch (Exception ex)
							{
								ex.Data.Add("Error at 200324", ex.Message);
								GameGeneral.smethod_25(ref ex);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								if (string.IsNullOrEmpty(string_2) && string.IsNullOrEmpty(side_0.method_51()))
								{
									string_1 = "WARNING! Area validation has FAILED! This will cause problems for the AI navigator. Please check the shape of the area and make sure it makes sense.";
								}
								else if (string.IsNullOrEmpty(side_0.method_51()))
								{
									string_1 = "WARNING! Area validation for " + string_2 + " has FAILED! This will cause problems for the AI navigator. Please check the shape of the area and make sure it makes sense.";
								}
								else
								{
									string_1 = string.Concat(new string[]
									{
										"WARNING! Area validation for ",
										string_2,
										" belonging to side ",
										text,
										" has FAILED! This will cause problems for the AI navigator. Please check the shape of the area and make sure it makes sense."
									});
								}
								return false;
							}
							goto IL_29C;
						}
						array[i] = new Coordinate(num2, num3);
					}
					goto IL_AC;
				}
				IL_29C:
				result = true;
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 101270", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00007F82 File Offset: 0x00006182
		[CompilerGenerated]
		private float method_60(ReferencePoint referencePoint_1)
		{
			return this.activeUnit_0.method_25(referencePoint_1.imethod_2(), referencePoint_1.imethod_0());
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x000AFDD8 File Offset: 0x000ADFD8
		[CompilerGenerated]
		private double method_61(ReferencePoint referencePoint_1)
		{
			Unit unit = this.activeUnit_0;
			double num = referencePoint_1.imethod_2();
			double num2 = referencePoint_1.imethod_0();
			double result = unit.method_30(ref num, ref num2);
			referencePoint_1.imethod_1(num2);
			referencePoint_1.imethod_3(num);
			return result;
		}

		// Token: 0x0400069E RID: 1694
		protected ActiveUnit activeUnit_0;

		// Token: 0x0400069F RID: 1695
		protected Waypoint[] waypoint_0;

		// Token: 0x040006A0 RID: 1696
		protected Waypoint[] waypoint_1;

		// Token: 0x040006A1 RID: 1697
		protected Mission.Flight flight_0;

		// Token: 0x040006A2 RID: 1698
		protected string string_0;

		// Token: 0x040006A3 RID: 1699
		public bool bool_0;

		// Token: 0x040006A4 RID: 1700
		private ActiveUnit_Navigator.Class216 class216_0;

		// Token: 0x040006A5 RID: 1701
		public ReferencePoint referencePoint_0;

		// Token: 0x040006A6 RID: 1702
		public bool bool_1;

		// Token: 0x040006A7 RID: 1703
		public float float_0;

		// Token: 0x040006A8 RID: 1704
		public bool bool_2;

		// Token: 0x040006A9 RID: 1705
		public float float_1;

		// Token: 0x040006AA RID: 1706
		public bool bool_3;

		// Token: 0x040006AB RID: 1707
		public bool? nullable_0;

		// Token: 0x040006AC RID: 1708
		public int int_0;

		// Token: 0x040006AD RID: 1709
		internal int int_1;

		// Token: 0x040006AE RID: 1710
		internal int int_2;

		// Token: 0x040006AF RID: 1711
		protected List<Waypoint> list_0;

		// Token: 0x040006B0 RID: 1712
		public double double_0;

		// Token: 0x040006B1 RID: 1713
		public double double_1;

		// Token: 0x040006B2 RID: 1714
		public double double_2;

		// Token: 0x040006B3 RID: 1715
		public double double_3;

		// Token: 0x040006B4 RID: 1716
		public double double_4;

		// Token: 0x040006B5 RID: 1717
		public double double_5;

		// Token: 0x040006B6 RID: 1718
		public double double_6;

		// Token: 0x040006B7 RID: 1719
		public double double_7;

		// Token: 0x040006B8 RID: 1720
		public bool bool_4;

		// Token: 0x040006B9 RID: 1721
		public bool bool_5;

		// Token: 0x040006BA RID: 1722
		public bool bool_6;

		// Token: 0x040006BB RID: 1723
		public bool bool_7;

		// Token: 0x040006BC RID: 1724
		public bool bool_8;

		// Token: 0x040006BD RID: 1725
		public bool bool_9;

		// Token: 0x040006BE RID: 1726
		public bool bool_10;

		// Token: 0x040006BF RID: 1727
		public bool bool_11;

		// Token: 0x040006C0 RID: 1728
		public double double_8;

		// Token: 0x040006C1 RID: 1729
		public bool bool_12;

		// Token: 0x040006C2 RID: 1730
		public double double_9;

		// Token: 0x040006C3 RID: 1731
		public bool bool_13;

		// Token: 0x040006C4 RID: 1732
		public float? nullable_1;

		// Token: 0x040006C5 RID: 1733
		public DateTime? nullable_2;

		// Token: 0x040006C6 RID: 1734
		public double? nullable_3;

		// Token: 0x040006C7 RID: 1735
		public double? nullable_4;

		// Token: 0x040006C8 RID: 1736
		public Waypoint.WaypointType? nullable_5;

		// Token: 0x040006C9 RID: 1737
		public double double_10;

		// Token: 0x040006CA RID: 1738
		private bool bool_14;

		// Token: 0x040006CB RID: 1739
		private float? nullable_6;

		// Token: 0x040006CC RID: 1740
		private GeoPoint geoPoint_0;

		// Token: 0x040006CD RID: 1741
		public bool bool_15;

		// Token: 0x040006CE RID: 1742
		private bool? nullable_7;

		// Token: 0x040006CF RID: 1743
		private bool bool_16;

		// Token: 0x02000162 RID: 354
		internal sealed class Class216
		{
			// Token: 0x06000A38 RID: 2616 RVA: 0x000AFE14 File Offset: 0x000AE014
			public Tuple<double, double> method_0(ActiveUnit activeUnit_0, ActiveUnit activeUnit_1)
			{
				double item;
				double item2;
				Class411.smethod_1(activeUnit_1.vmethod_28(null), activeUnit_1.vmethod_30(null), ref item, ref item2, (double)this.float_1, (double)this.method_1(activeUnit_0));
				return new Tuple<double, double>(item2, item);
			}

			// Token: 0x06000A39 RID: 2617 RVA: 0x000AFE60 File Offset: 0x000AE060
			public float method_1(ActiveUnit activeUnit_0)
			{
				ReferencePoint.OrientationType orientationType = this.orientationType_0;
				float result;
				if (orientationType != ReferencePoint.OrientationType.Fixed)
				{
					if (orientationType != ReferencePoint.OrientationType.Rotating)
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						result = 0f;
					}
					else
					{
						result = Math2.smethod_7(activeUnit_0.vmethod_65(false).method_147().vmethod_9() + this.float_0);
					}
				}
				else
				{
					result = this.float_0;
				}
				return result;
			}

			// Token: 0x040006D0 RID: 1744
			public float float_0;

			// Token: 0x040006D1 RID: 1745
			public float float_1;

			// Token: 0x040006D2 RID: 1746
			public ReferencePoint.OrientationType orientationType_0;
		}

		// Token: 0x02000163 RID: 355
		[CompilerGenerated]
		internal sealed class Class217
		{
			// Token: 0x06000A3B RID: 2619 RVA: 0x00007F9B File Offset: 0x0000619B
			internal void method_0()
			{
				Class522.smethod_10(ref this.scenario_0);
			}

			// Token: 0x06000A3C RID: 2620 RVA: 0x000AFEB8 File Offset: 0x000AE0B8
			internal void method_1()
			{
				Class522.smethod_4(new Class554
				{
					activeUnit_0 = this.activeUnit_0,
					flight_0 = this.flight_0,
					bool_0 = this.bool_0,
					waypoint_0 = this.waypoint_0,
					float_0 = this.float_0,
					double_0 = this.double_0,
					double_1 = this.double_1,
					bool_1 = this.bool_1
				}, this.scenario_0);
			}

			// Token: 0x040006D3 RID: 1747
			public Scenario scenario_0;

			// Token: 0x040006D4 RID: 1748
			public ActiveUnit activeUnit_0;

			// Token: 0x040006D5 RID: 1749
			public Mission.Flight flight_0;

			// Token: 0x040006D6 RID: 1750
			public bool bool_0;

			// Token: 0x040006D7 RID: 1751
			public Waypoint waypoint_0;

			// Token: 0x040006D8 RID: 1752
			public float float_0;

			// Token: 0x040006D9 RID: 1753
			public double double_0;

			// Token: 0x040006DA RID: 1754
			public double double_1;

			// Token: 0x040006DB RID: 1755
			public bool bool_1;
		}
	}
}
