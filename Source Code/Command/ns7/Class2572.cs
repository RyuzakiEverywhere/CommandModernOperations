using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using Command_Core;
using Microsoft.DirectX;
using Microsoft.VisualBasic.CompilerServices;
using ns19;
using ns20;
using WorldWind;
using WorldWind.Camera;

namespace ns7
{
	// Token: 0x02000F58 RID: 3928
	[StandardModule]
	internal sealed class Class2572
	{
		// Token: 0x06008C5C RID: 35932 RVA: 0x004B8A40 File Offset: 0x004B6C40
		public static Point smethod_0(WorldWindow worldWindow_0, double double_0, double double_1)
		{
			Point result = default(Point);
			int x = result.X;
			int y = result.Y;
			Class2572.smethod_4(worldWindow_0, double_0, double_1, ref x, ref y);
			result.Y = y;
			result.X = x;
			return result;
		}

		// Token: 0x06008C5D RID: 35933 RVA: 0x004B8A84 File Offset: 0x004B6C84
		public static GeoPoint smethod_1(WorldWindow worldWindow_0, int int_0, int int_1)
		{
			GeoPoint geoPoint = new GeoPoint();
			Struct65 @struct = default(Struct65);
			Struct65 struct2 = default(Struct65);
			worldWindow_0.method_7().method_1().vmethod_28(int_0, int_1, out @struct, out struct2);
			geoPoint.imethod_1(struct2.method_0());
			geoPoint.imethod_3(@struct.method_0());
			return geoPoint;
		}

		// Token: 0x06008C5E RID: 35934 RVA: 0x004B8AD8 File Offset: 0x004B6CD8
		public static Geopoint_Struct smethod_2(WorldWindow worldWindow_0, int int_0, int int_1)
		{
			Geopoint_Struct result = default(Geopoint_Struct);
			Struct65 @struct = default(Struct65);
			Struct65 struct2 = default(Struct65);
			worldWindow_0.method_7().method_1().vmethod_28(int_0, int_1, out @struct, out struct2);
			result.double_0 = struct2.method_0();
			result.double_1 = @struct.method_0();
			return result;
		}

		// Token: 0x06008C5F RID: 35935 RVA: 0x004B8B30 File Offset: 0x004B6D30
		public static void smethod_3(WorldWindow worldWindow_0, ref int int_0, ref int int_1, ref double double_0, ref double double_1)
		{
			Struct65 @struct = default(Struct65);
			Struct65 struct2 = default(Struct65);
			worldWindow_0.method_7().method_1().vmethod_28(int_0, int_1, out @struct, out struct2);
			double_0 = struct2.method_0();
			double_1 = @struct.method_0();
		}

		// Token: 0x06008C60 RID: 35936 RVA: 0x004B8B78 File Offset: 0x004B6D78
		public static void smethod_4(WorldWindow worldWindow_0, double double_0, double double_1, ref int int_0, ref int int_1)
		{
			try
			{
				if (!double.IsNaN(double_0) && !double.IsInfinity(double_0) && !double.IsNaN(double_1) && !double.IsInfinity(double_1))
				{
					Vector3 vector = Class1829.smethod_0(double_0, double_1, worldWindow_0.method_4().method_4() + 0.0);
					Vector3 vector3_ = new Vector3((float)((double)vector.X - worldWindow_0.method_7().method_1().class1831_1.double_0), (float)((double)vector.Y - worldWindow_0.method_7().method_1().class1831_1.double_1), (float)((double)vector.Z - worldWindow_0.method_7().method_1().class1831_1.double_2));
					if (!Class2572.bool_0)
					{
						Class2572.cameraBase_0 = worldWindow_0.method_7().method_1();
						Class2572.bool_0 = true;
					}
					Vector3 vector2 = Class2572.cameraBase_0.method_8(vector3_);
					if (!float.IsNaN(vector2.X) && !float.IsNaN(vector2.Y))
					{
						int_0 = (int)Math.Round((double)vector2.X);
						int_1 = (int)Math.Round((double)vector2.Y);
					}
				}
				else
				{
					int_0 = -1;
					int_1 = -1;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200424", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06008C61 RID: 35937 RVA: 0x004B8CF0 File Offset: 0x004B6EF0
		public static bool smethod_5(WorldWindow worldWindow_0, double double_0, double double_1)
		{
			bool result;
			if (double.IsNaN(double_0) | double.IsNaN(double_1))
			{
				result = false;
			}
			else
			{
				Vector3 vector3_ = Class1829.smethod_0(double_0, double_1, worldWindow_0.method_4().method_4() + 0.0);
				result = worldWindow_0.method_7().method_1().vmethod_24().method_1(vector3_);
			}
			return result;
		}

		// Token: 0x06008C62 RID: 35938 RVA: 0x004B8D48 File Offset: 0x004B6F48
		public static bool smethod_6(WorldWindow worldWindow_0, Unit unit_0)
		{
			bool result;
			if (unit_0.bool_0 && !((ActiveUnit)unit_0).vmethod_127())
			{
				result = false;
			}
			else
			{
				if (unit_0.method_14())
				{
					List<GeoPoint> list = ((Contact)unit_0).method_112();
					if (list != null)
					{
						int count = list.Count;
						if (Class2572.smethod_5(worldWindow_0, unit_0.vmethod_30(null), unit_0.vmethod_28(null)))
						{
							return true;
						}
						int num = count - 1;
						for (int i = 0; i <= num; i++)
						{
							GeoPoint geoPoint = list[i];
							if (Class2572.smethod_5(worldWindow_0, geoPoint.imethod_2(), geoPoint.imethod_0()))
							{
								return true;
							}
						}
						return false;
					}
				}
				double num2 = unit_0.vmethod_30(null);
				double num3 = unit_0.vmethod_28(null);
				if (double.IsNaN(num2))
				{
					result = false;
				}
				else if (double.IsNaN(num3))
				{
					result = false;
				}
				else
				{
					Vector3 vector3_ = Class1829.smethod_0(num2, num3, worldWindow_0.method_4().method_4() + 0.0);
					result = worldWindow_0.method_7().method_1().vmethod_24().method_1(vector3_);
				}
			}
			return result;
		}

		// Token: 0x04004C0E RID: 19470
		public static CameraBase cameraBase_0;

		// Token: 0x04004C0F RID: 19471
		private static bool bool_0 = false;
	}
}
