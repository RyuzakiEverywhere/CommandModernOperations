using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DarkUI.Collections;
using DotSpatial.Topology;
using Microsoft.VisualBasic;
using ns10;
using ns30;
using ns8;

namespace Command_Core
{
	// Token: 0x02000206 RID: 518
	public class Zone : Class310
	{
		// Token: 0x06000FC6 RID: 4038 RVA: 0x00128060 File Offset: 0x00126260
		public Zone()
		{
			this.list_0 = new List<ReferencePoint>();
			this.list_1 = new List<ReferencePoint>();
			this.list_2 = new List<ReferencePoint>();
			this.list_3 = new List<GeoPoint>();
			this.list_4 = new List<GeoPoint>();
			this.bool_11 = true;
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00009FB8 File Offset: 0x000081B8
		[CompilerGenerated]
		public virtual ObservableList<GlobalVariables.ActiveUnitType> vmethod_4()
		{
			return this.observableList_0;
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x001280B4 File Offset: 0x001262B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void vmethod_5(ObservableList<GlobalVariables.ActiveUnitType> observableList_1)
		{
			EventHandler<EventArgs5<GlobalVariables.ActiveUnitType>> eventHandler_ = new EventHandler<EventArgs5<GlobalVariables.ActiveUnitType>>(this.method_13);
			EventHandler<EventArgs5<GlobalVariables.ActiveUnitType>> eventHandler_2 = new EventHandler<EventArgs5<GlobalVariables.ActiveUnitType>>(this.method_14);
			ObservableList<GlobalVariables.ActiveUnitType> observableList = this.observableList_0;
			if (observableList != null)
			{
				observableList.method_1(eventHandler_);
				observableList.method_3(eventHandler_2);
			}
			this.observableList_0 = observableList_1;
			observableList = this.observableList_0;
			if (observableList != null)
			{
				observableList.method_0(eventHandler_);
				observableList.method_2(eventHandler_2);
			}
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00128114 File Offset: 0x00126314
		public bool method_8(ActiveUnit activeUnit_0)
		{
			bool result;
			if (!this.bool_11)
			{
				result = false;
			}
			else
			{
				try
				{
					if (activeUnit_0.bool_1)
					{
						if (Information.IsNothing(((Group)activeUnit_0).method_147()))
						{
							result = false;
						}
						else
						{
							result = this.method_8(((Group)activeUnit_0).method_147());
						}
					}
					else
					{
						bool? flag;
						switch (activeUnit_0.vmethod_56())
						{
						case GlobalVariables.ActiveUnitType.Aircraft:
							if (this.nullable_0 == null)
							{
								this.method_11();
							}
							flag = this.nullable_0;
							goto IL_149;
						case GlobalVariables.ActiveUnitType.Ship:
							if (this.nullable_1 == null)
							{
								this.method_11();
							}
							flag = this.nullable_1;
							goto IL_149;
						case GlobalVariables.ActiveUnitType.Submarine:
							if (this.nullable_2 == null)
							{
								this.method_11();
							}
							flag = this.nullable_2;
							goto IL_149;
						case GlobalVariables.ActiveUnitType.Facility:
							if (this.nullable_3 == null)
							{
								this.method_11();
							}
							flag = this.nullable_3;
							goto IL_149;
						case GlobalVariables.ActiveUnitType.Weapon:
							if (((Weapon)activeUnit_0).method_167() == Weapon._WeaponType.Decoy_Vehicle)
							{
								return true;
							}
							if (this.nullable_4 == null)
							{
								this.method_11();
							}
							flag = this.nullable_4;
							goto IL_149;
						case GlobalVariables.ActiveUnitType.Satellite:
							if (this.nullable_5 == null)
							{
								this.method_11();
							}
							flag = this.nullable_5;
							goto IL_149;
						}
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw new NotImplementedException();
						IL_149:
						result = flag.Value;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100995", "");
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

		// Token: 0x06000FCA RID: 4042 RVA: 0x001282CC File Offset: 0x001264CC
		public void method_9(float float_0, ref List<GeoPoint> list_5, ref List<ReferencePoint> list_6)
		{
			new List<GeoPoint>();
			try
			{
				list_6.Clear();
				list_5.Clear();
				int count = this.list_0.Count;
				if (count != 0)
				{
					int num;
					if (count > 2)
					{
						num = count;
					}
					else
					{
						num = count - 1;
					}
					Coordinate[] array = new Coordinate[num + 1];
					int num2 = count - 1;
					for (int i = 0; i <= num2; i++)
					{
						array[i] = new Coordinate(this.list_0[i].imethod_0(), this.list_0[i].imethod_2());
						List<ReferencePoint> list = list_6;
						ReferencePoint referencePoint = this.list_0[i];
						List<ReferencePoint> list2;
						int num3;
						ReferencePoint value = (list2 = this.list_0)[num3 = i];
						ReferencePoint item = referencePoint.method_22(ref value);
						list2[num3] = value;
						list.Add(item);
					}
					if (count > 2)
					{
						array[count] = array[0];
					}
					IGeometry geometry;
					if (count > 2)
					{
						Polygon polygon = new Polygon(new LinearRing(array));
						try
						{
							geometry = polygon.vmethod_1((double)float_0, 2);
							goto IL_1D4;
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 200278", ex.Message);
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							goto IL_1D4;
						}
					}
					if (count == 2)
					{
						LineString lineString = new LineString(array);
						try
						{
							geometry = lineString.vmethod_1((double)float_0, 3);
							goto IL_1D4;
						}
						catch (Exception ex2)
						{
							ex2.Data.Add("Error at 200315", ex2.Message);
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
							geometry = point.vmethod_1((double)float_0, 3);
						}
						catch (Exception ex3)
						{
							ex3.Data.Add("Error at 200652", ex3.Message);
							GameGeneral.smethod_25(ref ex3);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							return;
						}
					}
					IL_1D4:
					if (Debugger.IsAttached && (Information.IsNothing(geometry) || geometry.imethod_0().Count == 0))
					{
						Debugger.Break();
					}
					if (!Information.IsNothing(geometry))
					{
						IPolygon polygon2 = (IPolygon)geometry;
						int num3 = polygon2.imethod_0().Count - 2;
						for (int j = 0; j <= num3; j++)
						{
							if (polygon2.imethod_0()[j].X > 180.0)
							{
								polygon2.imethod_0()[j].X = 180.0;
							}
							else if (polygon2.imethod_0()[j].X < -180.0)
							{
								polygon2.imethod_0()[j].X = -180.0;
							}
							if (polygon2.imethod_0()[j].Y > 90.0)
							{
								polygon2.imethod_0()[j].Y = 90.0;
							}
							else if (polygon2.imethod_0()[j].Y < -90.0)
							{
								polygon2.imethod_0()[j].Y = -90.0;
							}
							list_5.Add(new GeoPoint(polygon2.imethod_0()[j].X, polygon2.imethod_0()[j].Y));
						}
					}
				}
			}
			catch (Exception ex4)
			{
				ex4.Data.Add("Error at 200277", ex4.Message);
				GameGeneral.smethod_25(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x001286C8 File Offset: 0x001268C8
		public float method_10(double double_0, double double_1, Scenario scenario_0)
		{
			try
			{
				int count = this.list_0.Count;
				if (count == 0)
				{
					return float.MaxValue;
				}
				int num;
				if (count > 2)
				{
					num = count;
				}
				else
				{
					num = count - 1;
				}
				Coordinate[] array = new Coordinate[num + 1];
				int num2 = count - 1;
				for (int i = 0; i <= num2; i++)
				{
					array[i] = new Coordinate(this.list_0[i].imethod_0(), this.list_0[i].imethod_2());
				}
				if (count > 2)
				{
					array[count] = array[0];
				}
				if (count > 2)
				{
					Polygon igeometry_ = new Polygon(new LinearRing(array));
					try
					{
						Point igeometry_2 = new Point(double_1, double_0);
						Coordinate[] array2 = Class2188.smethod_0(igeometry_, igeometry_2);
						return Math2.smethod_15(array2[0].Y, array2[0].X, array2[1].Y, array2[1].X);
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 200339", ex.Message);
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						return float.MaxValue;
					}
				}
				if (count == 2)
				{
					LineString igeometry_3 = new LineString(array);
					try
					{
						Point igeometry_4 = new Point(double_1, double_0);
						Coordinate[] array3 = Class2188.smethod_0(igeometry_3, igeometry_4);
						return Math2.smethod_15(array3[0].Y, array3[0].X, array3[1].Y, array3[1].X);
					}
					catch (Exception ex2)
					{
						ex2.Data.Add("Error at 200338", ex2.Message);
						GameGeneral.smethod_25(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						return float.MaxValue;
					}
				}
				if (count == 1)
				{
					return float.MaxValue;
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 200336", ex3.Message);
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return float.MaxValue;
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00128918 File Offset: 0x00126B18
		private void method_11()
		{
			this.nullable_0 = new bool?(this.vmethod_4().Contains(GlobalVariables.ActiveUnitType.Aircraft));
			this.nullable_1 = new bool?(this.vmethod_4().Contains(GlobalVariables.ActiveUnitType.Ship));
			this.nullable_2 = new bool?(this.vmethod_4().Contains(GlobalVariables.ActiveUnitType.Submarine));
			this.nullable_3 = new bool?(this.vmethod_4().Contains(GlobalVariables.ActiveUnitType.Facility));
			this.nullable_4 = new bool?(this.vmethod_4().Contains(GlobalVariables.ActiveUnitType.Weapon));
			this.nullable_5 = new bool?(this.vmethod_4().Contains(GlobalVariables.ActiveUnitType.Satellite));
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x001289B0 File Offset: 0x00126BB0
		public bool method_12(List<ReferencePoint> list_5)
		{
			bool result;
			if (this.list_0.Count != list_5.Count)
			{
				result = true;
			}
			else
			{
				int num = this.list_0.Count - 1;
				int i = 0;
				while (i <= num)
				{
					if (this.list_0[i].imethod_2() == list_5[i].imethod_2())
					{
						if (this.list_0[i].imethod_0() == list_5[i].imethod_0())
						{
							i++;
							continue;
						}
					}
					return true;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00009FC0 File Offset: 0x000081C0
		private void method_13(object sender, EventArgs5<GlobalVariables.ActiveUnitType> e)
		{
			this.method_11();
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00009FC0 File Offset: 0x000081C0
		private void method_14(object sender, EventArgs5<GlobalVariables.ActiveUnitType> e)
		{
			this.method_11();
		}

		// Token: 0x04000A6A RID: 2666
		public string string_2;

		// Token: 0x04000A6B RID: 2667
		public List<ReferencePoint> list_0;

		// Token: 0x04000A6C RID: 2668
		public List<ReferencePoint> list_1;

		// Token: 0x04000A6D RID: 2669
		public List<ReferencePoint> list_2;

		// Token: 0x04000A6E RID: 2670
		public List<GeoPoint> list_3;

		// Token: 0x04000A6F RID: 2671
		public List<GeoPoint> list_4;

		// Token: 0x04000A70 RID: 2672
		[CompilerGenerated]
		[AccessedThroughProperty("AffectedUnitTypes")]
		private ObservableList<GlobalVariables.ActiveUnitType> observableList_0;

		// Token: 0x04000A71 RID: 2673
		public bool bool_11;

		// Token: 0x04000A72 RID: 2674
		private bool? nullable_0;

		// Token: 0x04000A73 RID: 2675
		private bool? nullable_1;

		// Token: 0x04000A74 RID: 2676
		private bool? nullable_2;

		// Token: 0x04000A75 RID: 2677
		private bool? nullable_3;

		// Token: 0x04000A76 RID: 2678
		private bool? nullable_4;

		// Token: 0x04000A77 RID: 2679
		private bool? nullable_5;
	}
}
