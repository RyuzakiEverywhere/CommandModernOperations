using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CSMaterial.ClipperLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns12;
using ns13;
using ns19;
using ns20;
using ns8;

namespace Command_Core
{
	// Token: 0x020003E7 RID: 999
	[StandardModule]
	public sealed class Math2
	{
		// Token: 0x06001DED RID: 7661 RVA: 0x00225B5C File Offset: 0x00223D5C
		public static double smethod_0(double double_0)
		{
			return Math.Tan(0.0174532925199433 * double_0);
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x0000EC0C File Offset: 0x0000CE0C
		public static double smethod_1(double double_0)
		{
			return Math.Sin(0.0174532925199433 * double_0);
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x0000EC1E File Offset: 0x0000CE1E
		public static double smethod_2(double double_0)
		{
			return Math.Cos(0.0174532925199433 * double_0);
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x00225B7C File Offset: 0x00223D7C
		public static double smethod_3(double double_0)
		{
			double result;
			if (double_0 == 1.0)
			{
				result = 0.0;
			}
			else if (double_0 == -1.0)
			{
				result = 180.0;
			}
			else
			{
				result = 57.2957795130823 * Math.Atan2(-double_0, Math.Sqrt(1.0 - double_0 * double_0)) + 90.0;
			}
			return result;
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x00225BE8 File Offset: 0x00223DE8
		public static double smethod_4(double double_0)
		{
			double result;
			if (double_0 == 1.0)
			{
				result = 90.0;
			}
			else if (double_0 == -1.0)
			{
				result = 270.0;
			}
			else
			{
				result = 57.2957795130823 * Math.Atan2(double_0, Math.Sqrt(-double_0 * double_0 + 1.0));
			}
			return result;
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x00225C4C File Offset: 0x00223E4C
		public static double smethod_5(double double_0)
		{
			double result;
			if (double_0 == 1.0)
			{
				result = 45.0;
			}
			else if (double_0 == -1.0)
			{
				result = -45.0;
			}
			else
			{
				result = 57.2957795130823 * Math.Atan(double_0);
			}
			return result;
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00225C9C File Offset: 0x00223E9C
		public static double smethod_6(double double_0)
		{
			double result = double_0;
			if (double_0 < 0.0)
			{
				result = double_0 + 360.0;
			}
			if (double_0 > 360.0)
			{
				result = double_0 - 360.0;
			}
			if (double_0 == 360.0)
			{
				result = 0.0;
			}
			return result;
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x00225CF4 File Offset: 0x00223EF4
		public static float smethod_7(float float_0)
		{
			float result = float_0;
			if (float_0 < 0f)
			{
				result = float_0 + 360f;
			}
			if (float_0 > 360f)
			{
				result = float_0 - 360f;
			}
			if (float_0 == 360f)
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x00225D34 File Offset: 0x00223F34
		public static int smethod_8(int int_0)
		{
			int result = int_0;
			if (int_0 < 0)
			{
				result = int_0 + 360;
			}
			if (int_0 > 360)
			{
				result = int_0 - 360;
			}
			if (int_0 == 360)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00225D6C File Offset: 0x00223F6C
		public static float smethod_9(float float_0)
		{
			float result;
			if (float_0 > 90f)
			{
				result = 90f - float_0;
			}
			else if (float_0 < -90f)
			{
				result = -90f - float_0;
			}
			else
			{
				result = float_0;
			}
			return result;
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00225DA0 File Offset: 0x00223FA0
		public static double smethod_10(ref double double_0)
		{
			double result;
			if (double_0 > 90.0)
			{
				result = 180.0 - double_0;
			}
			else if (double_0 < -90.0)
			{
				result = -180.0 - double_0;
			}
			else
			{
				result = double_0;
			}
			return result;
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00225DEC File Offset: 0x00223FEC
		public static double smethod_11(ref double double_0)
		{
			double result;
			if (double_0 == -180.0)
			{
				result = 0.0;
			}
			else if (double_0 > 180.0)
			{
				result = double_0 - 360.0;
			}
			else if (double_0 < -180.0)
			{
				result = double_0 + 360.0;
			}
			else
			{
				result = double_0;
			}
			return result;
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x00225E50 File Offset: 0x00224050
		public static float smethod_12(ref float float_0)
		{
			float result;
			if (float_0 == -180f)
			{
				result = 0f;
			}
			else if (float_0 > 180f)
			{
				result = float_0 - 360f;
			}
			else if (float_0 < -180f)
			{
				result = float_0 + 360f;
			}
			else
			{
				result = float_0;
			}
			return result;
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00225E9C File Offset: 0x0022409C
		public static double smethod_13(double double_0)
		{
			return Struct65.smethod_0(double_0 / 3441.6865234375).method_0();
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00225EC4 File Offset: 0x002240C4
		public static double smethod_14(double double_0, double double_1, double double_2, double double_3)
		{
			Struct65 struct65_ = default(Struct65);
			Struct65 struct65_2 = default(Struct65);
			Struct65 struct65_3 = default(Struct65);
			Struct65 struct65_4 = default(Struct65);
			struct65_.method_1(double_0);
			struct65_2.method_1(double_1);
			struct65_3.method_1(double_2);
			struct65_4.method_1(double_3);
			return Class1874.smethod_1(struct65_, struct65_2, struct65_3, struct65_4).method_0();
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00225F24 File Offset: 0x00224124
		public static float smethod_15(double double_0, double double_1, double double_2, double double_3)
		{
			float num = (float)Math.Abs(Math2.smethod_3(Math2.smethod_1(double_0) * Math2.smethod_1(double_2) + Math2.smethod_2(double_0) * Math2.smethod_2(double_2) * Math2.smethod_2(double_3 - double_1)) * 60.0);
			if (float.IsNaN(num))
			{
				num = 0f;
			}
			if (num == 0f && double_0 != double_2 && double_1 != double_3)
			{
				num = (float)Class432.smethod_9(new Class432.Struct47(double_0, double_1), new Class432.Struct47(double_2, double_3), 0.0, 0.0);
			}
			return num;
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00225FB4 File Offset: 0x002241B4
		public static double smethod_16(double double_0, double double_1, double double_2, double double_3, double double_4, double double_5)
		{
			double num;
			double num2;
			double num3;
			Class432.smethod_3(double_0, double_1, double_2, ref num, ref num2, ref num3);
			double num4;
			double num5;
			double num6;
			Class432.smethod_3(double_3, double_4, double_5, ref num4, ref num5, ref num6);
			double num7 = num4 - num;
			double num8 = num5 - num2;
			double num9 = num6 - num3;
			return Math.Sqrt(num7 * num7 + num8 * num8 + num9 * num9) / 1852.0;
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x0000EC30 File Offset: 0x0000CE30
		public static float smethod_17(double double_0, double double_1, double double_2, double double_3)
		{
			return (float)Math2.smethod_6(57.2957795130823 * Math.Atan2(Math2.smethod_1(double_3 - double_1), Math2.smethod_0(double_2) * Math2.smethod_2(double_0) - Math2.smethod_1(double_0) * Math2.smethod_2(double_3 - double_1)));
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x0000EC6C File Offset: 0x0000CE6C
		public static bool smethod_18(double double_0)
		{
			return double_0 >= -180.0 && double_0 <= 180.0;
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x0000EC8B File Offset: 0x0000CE8B
		public static bool smethod_19(double double_0)
		{
			return double_0 >= -90.0 && double_0 <= 90.0;
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x0022600C File Offset: 0x0022420C
		public static GeoPoint smethod_20(IEnumerable<GeoPoint> ienumerable_0, double double_0, double double_1, bool bool_0)
		{
			Math2.Class435 @class = new Math2.Class435();
			@class.double_1 = double_0;
			@class.double_0 = double_1;
			int num = Enumerable.Count<GeoPoint>(ienumerable_0);
			GeoPoint result;
			if (!bool_0)
			{
				result = Enumerable.ElementAtOrDefault<GeoPoint>(ienumerable_0, GameGeneral.smethod_5().Next(0, num));
			}
			else
			{
				IEnumerable<GeoPoint> enumerable = Enumerable.OrderBy<GeoPoint, float>(Enumerable.Select<GeoPoint, GeoPoint>(ienumerable_0, (Math2._Closure$__.$I25-0 == null) ? (Math2._Closure$__.$I25-0 = new Func<GeoPoint, GeoPoint>(Math2._Closure$__.$I.method_0)) : Math2._Closure$__.$I25-0), new Func<GeoPoint, float>(@class.method_0));
				if (GameGeneral.smethod_5().Next(0, 1001) > 250)
				{
					int num2 = (int)Math.Ceiling((double)Enumerable.Count<GeoPoint>(ienumerable_0) / 2.0);
					result = Enumerable.ElementAtOrDefault<GeoPoint>(Enumerable.Skip<GeoPoint>(enumerable, num - num2), GameGeneral.smethod_5().Next(0, num2));
				}
				else
				{
					int num3 = (int)Math.Ceiling((double)Enumerable.Count<GeoPoint>(ienumerable_0) / 2.0);
					result = Enumerable.ElementAtOrDefault<GeoPoint>(Enumerable.Take<GeoPoint>(enumerable, num3), GameGeneral.smethod_5().Next(0, num3));
				}
			}
			return result;
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00226110 File Offset: 0x00224310
		public static List<GeoPoint> smethod_21(List<GeoPoint> list_0)
		{
			Geopoint_Struct geopoint_Struct = Misc.smethod_46(list_0);
			Class432.Class433 @class = new Class432.Class433(geopoint_Struct.double_1, geopoint_Struct.double_0);
			int count = list_0.Count;
			Class51[] array = new Class51[count + 1];
			int num = count - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					double x;
					double y;
					if (@class.method_1(list_0[i].imethod_2(), list_0[i].imethod_0(), ref x, ref y, false))
					{
						array[i] = new Class51(x, y, 0.0);
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200088", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
			List<GeoPoint> result;
			if (array.Length == 0)
			{
				result = new List<GeoPoint>();
			}
			else
			{
				array[Enumerable.Count<Class51>(array) - 1] = array[0];
				List<Class51> list = Math2.smethod_22(array);
				count = list.Count;
				List<GeoPoint> list2 = new List<GeoPoint>(count);
				int num2 = count - 1;
				for (int j = 0; j <= num2; j++)
				{
					double double_;
					double double_2;
					if (@class.method_6(list[j].double_0, list[j].double_1, ref double_, ref double_2))
					{
						list2.Add(new GeoPoint(double_2, double_));
					}
				}
				result = list2;
			}
			return result;
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0000ECAA File Offset: 0x0000CEAA
		public static List<Class51> smethod_22(Class51[] class51_0)
		{
			return Class52.smethod_0(class51_0, 50.0, false);
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x00226280 File Offset: 0x00224480
		public static Geopoint_Struct smethod_23(IEnumerable<GeoPoint> ienumerable_0)
		{
			Geopoint_Struct result;
			if (Enumerable.Count<GeoPoint>(ienumerable_0) < 3)
			{
				result = default(Geopoint_Struct);
			}
			else
			{
				Random random = GameGeneral.smethod_5();
				if (random == null)
				{
					random = new Random();
				}
				List<GeoPoint> list = Enumerable.ToList<GeoPoint>(Enumerable.OrderBy<GeoPoint, double>(ienumerable_0, (Math2._Closure$__.$I29-0 == null) ? (Math2._Closure$__.$I29-0 = new Func<GeoPoint, double>(Math2._Closure$__.$I.method_1)) : Math2._Closure$__.$I29-0));
				double num = Enumerable.Last<GeoPoint>(list).imethod_2();
				double num2 = Enumerable.First<GeoPoint>(list).imethod_2();
				double num8;
				double num9;
				if (!Math2.smethod_27(Enumerable.ToList<GeoPoint>(ienumerable_0)))
				{
					List<GeoPoint> list2 = Enumerable.ToList<GeoPoint>(Enumerable.OrderBy<GeoPoint, double>(ienumerable_0, (Math2._Closure$__.$I29-1 == null) ? (Math2._Closure$__.$I29-1 = new Func<GeoPoint, double>(Math2._Closure$__.$I.method_2)) : Math2._Closure$__.$I29-1));
					double num3 = Enumerable.Last<GeoPoint>(list2).imethod_0();
					double num4 = Enumerable.First<GeoPoint>(list2).imethod_0();
					short num5 = 0;
					bool flag;
					while (!flag)
					{
						if (num5 == 32767)
						{
							return default(Geopoint_Struct);
						}
						num5 += 1;
						double num6 = random.NextDouble();
						double num7 = random.NextDouble();
						if (num6 != 0.0)
						{
							if (num7 != 0.0)
							{
								num8 = num4 + num6 * (num3 - num4);
								num9 = num2 + num7 * (num - num2);
								flag = GeoPoint.smethod_3(num9, num8, Enumerable.ToList<GeoPoint>(ienumerable_0), true);
								continue;
							}
						}
						return default(Geopoint_Struct);
					}
				}
				else
				{
					List<GeoPoint> list3 = Enumerable.ToList<GeoPoint>(Enumerable.OrderBy<GeoPoint, double>(ienumerable_0, (Math2._Closure$__.$I29-2 == null) ? (Math2._Closure$__.$I29-2 = new Func<GeoPoint, double>(Math2._Closure$__.$I.method_3)) : Math2._Closure$__.$I29-2));
					GeoPoint geoPoint = Enumerable.First<GeoPoint>(list3);
					GeoPoint geoPoint2 = Enumerable.Last<GeoPoint>(list3);
					double num10 = 180.0 - Math.Abs(geoPoint2.imethod_0()) + (180.0 - Math.Abs(geoPoint.imethod_0()));
					short num11 = 0;
					bool flag;
					while (!flag)
					{
						if (num11 == 32767)
						{
							return default(Geopoint_Struct);
						}
						num11 += 1;
						double num6 = GameGeneral.smethod_5().NextDouble();
						double num7 = GameGeneral.smethod_5().NextDouble();
						if (num6 != 0.0)
						{
							if (num7 != 0.0)
							{
								double num12 = geoPoint2.imethod_0() + num6 * num10;
								num8 = Math2.smethod_11(ref num12);
								num9 = num2 + num7 * (num - num2);
								flag = GeoPoint.smethod_3(num9, num8, Enumerable.ToList<GeoPoint>(ienumerable_0), true);
								continue;
							}
						}
						return default(Geopoint_Struct);
					}
				}
				result = new Geopoint_Struct(num8, num9);
			}
			return result;
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x002264F0 File Offset: 0x002246F0
		public static Geopoint_Struct[] smethod_24(double double_0, double double_1, float float_0, float float_1, float float_2)
		{
			Geopoint_Struct geopoint_Struct = default(Geopoint_Struct);
			Geopoint_Struct geopoint_Struct2 = default(Geopoint_Struct);
			Geopoint_Struct geopoint_Struct3 = default(Geopoint_Struct);
			Geopoint_Struct geopoint_Struct4 = default(Geopoint_Struct);
			Geopoint_Struct geopoint_Struct5 = default(Geopoint_Struct);
			Geopoint_Struct geopoint_Struct6 = default(Geopoint_Struct);
			Class411.smethod_1(double_1, double_0, ref geopoint_Struct6.double_0, ref geopoint_Struct6.double_1, (double)((float)((double)(float_0 / 2f) * 0.000539957)), (double)Math2.smethod_7(float_2 + 180f));
			Class411.smethod_1(geopoint_Struct6.double_0, geopoint_Struct6.double_1, ref geopoint_Struct3.double_0, ref geopoint_Struct3.double_1, (double)float_0 * 0.000539957, (double)float_2);
			Class411.smethod_1(geopoint_Struct3.double_0, geopoint_Struct3.double_1, ref geopoint_Struct.double_0, ref geopoint_Struct.double_1, (double)(float_1 / 2f) * 0.000539957, (double)Math2.smethod_7(float_2 - 90f));
			Class411.smethod_1(geopoint_Struct3.double_0, geopoint_Struct3.double_1, ref geopoint_Struct2.double_0, ref geopoint_Struct2.double_1, (double)(float_1 / 2f) * 0.000539957, (double)Math2.smethod_7(float_2 + 90f));
			Class411.smethod_1(geopoint_Struct6.double_0, geopoint_Struct6.double_1, ref geopoint_Struct4.double_0, ref geopoint_Struct4.double_1, (double)(float_1 / 2f) * 0.000539957, (double)Math2.smethod_7(float_2 - 90f));
			Class411.smethod_1(geopoint_Struct6.double_0, geopoint_Struct6.double_1, ref geopoint_Struct5.double_0, ref geopoint_Struct5.double_1, (double)(float_1 / 2f) * 0.000539957, (double)Math2.smethod_7(float_2 + 90f));
			return new Geopoint_Struct[]
			{
				geopoint_Struct,
				geopoint_Struct2,
				geopoint_Struct5,
				geopoint_Struct4
			};
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x002266BC File Offset: 0x002248BC
		public static bool smethod_25(double double_0, double double_1, double double_2, double double_3)
		{
			bool result;
			if (double_1 >= 0.0 && double_3 >= 0.0)
			{
				result = false;
			}
			else if (double_1 < 0.0 && double_3 < 0.0)
			{
				result = false;
			}
			else
			{
				double value = Math.Min(double_1, double_3);
				result = (Math.Abs(Math.Max(double_1, double_3)) + Math.Abs(value) > 180.0);
			}
			return result;
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00226730 File Offset: 0x00224930
		public static bool smethod_26(IEnumerable<Geopoint_Struct> ienumerable_0)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			double num;
			double num2;
			try
			{
				foreach (Geopoint_Struct geopoint_Struct in ienumerable_0)
				{
					double double_ = geopoint_Struct.double_0;
					if (double_ < num)
					{
						num = double_;
					}
					if (double_ > num2)
					{
						num2 = double_;
					}
					if (double_ > 0.0)
					{
						flag2 = true;
						if (flag3)
						{
							flag = true;
						}
					}
					if (double_ < 0.0)
					{
						flag3 = true;
						if (flag2)
						{
							flag = true;
						}
					}
				}
			}
			finally
			{
				IEnumerator<Geopoint_Struct> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return flag && Math.Abs(num2) + Math.Abs(num) > 180.0;
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x002267E8 File Offset: 0x002249E8
		public static bool smethod_27(List<GeoPoint> list_0)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			int num = list_0.Count - 1;
			double num3;
			double num4;
			for (int i = 0; i <= num; i++)
			{
				double num2 = list_0[i].imethod_0();
				if (num2 < num3)
				{
					num3 = num2;
				}
				if (num2 > num4)
				{
					num4 = num2;
				}
				if (num2 > 0.0)
				{
					flag2 = true;
					if (flag3)
					{
						flag = true;
					}
				}
				if (num2 < 0.0)
				{
					flag3 = true;
					if (flag2)
					{
						flag = true;
					}
				}
			}
			return flag && Math.Abs(num4) + Math.Abs(num3) > 180.0;
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x0022688C File Offset: 0x00224A8C
		public static bool smethod_28(ref List<ReferencePoint> list_0)
		{
			bool result;
			try
			{
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				int i = list_0.Count - 1;
				double num2;
				double num3;
				while (i >= 0)
				{
					ReferencePoint referencePoint;
					try
					{
						if (Information.IsNothing(list_0[i]))
						{
							list_0.Remove(list_0[i]);
							goto IL_CC;
						}
						referencePoint = list_0[i];
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 200485", ex.Message);
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						goto IL_CC;
					}
					goto IL_87;
					IL_CC:
					i += -1;
					continue;
					IL_87:
					double num = referencePoint.imethod_0();
					if (num < num2)
					{
						num2 = num;
					}
					if (num > num3)
					{
						num3 = num;
					}
					if (num > 0.0)
					{
						flag2 = true;
						if (flag3)
						{
							flag = true;
						}
					}
					if (num >= 0.0)
					{
						goto IL_CC;
					}
					flag3 = true;
					if (flag2)
					{
						flag = true;
						goto IL_CC;
					}
					goto IL_CC;
				}
				if (!flag)
				{
					result = false;
				}
				else if (Math.Abs(num3) + Math.Abs(num2) <= 180.0)
				{
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 200486", ex2.Message);
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x00226A04 File Offset: 0x00224C04
		public static double smethod_29(double double_0)
		{
			double x = 100.0;
			return Math.Atan2(100.0 * double_0, x) * 57.2957795130823;
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x00226A38 File Offset: 0x00224C38
		public static List<GeoPoint> smethod_30(List<GeoPoint> list_0, List<GeoPoint> list_1)
		{
			List<GeoPoint> result;
			try
			{
				List<GeoPoint> list = new List<GeoPoint>();
				List<GeoPoint> list2 = new List<GeoPoint>();
				try
				{
					foreach (GeoPoint geoPoint in list_0)
					{
						GeoPoint item = new GeoPoint(geoPoint.imethod_0() * 100000000000000.0, geoPoint.imethod_2() * 100000000000000.0);
						list.Add(item);
					}
				}
				finally
				{
					List<GeoPoint>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (GeoPoint geoPoint in list_1)
					{
						GeoPoint item = new GeoPoint(geoPoint.imethod_0() * 100000000000000.0, geoPoint.imethod_2() * 100000000000000.0);
						list2.Add(item);
					}
				}
				finally
				{
					List<GeoPoint>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				List<IntPoint> list3 = new List<IntPoint>();
				try
				{
					foreach (GeoPoint geoPoint in list)
					{
						if (!double.IsNaN(geoPoint.imethod_2()) && !double.IsNaN(geoPoint.imethod_0()) && geoPoint.imethod_0() <= 9.223372036854776E+18 && geoPoint.imethod_2() <= 9.223372036854776E+18)
						{
							list3.Add(new IntPoint((long)Math.Round(geoPoint.imethod_0()), (long)Math.Round(geoPoint.imethod_2())));
						}
					}
				}
				finally
				{
					List<GeoPoint>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				List<IntPoint> list4 = new List<IntPoint>();
				try
				{
					foreach (GeoPoint geoPoint in list2)
					{
						if (!double.IsNaN(geoPoint.imethod_2()) && !double.IsNaN(geoPoint.imethod_0()) && geoPoint.imethod_0() <= 9.223372036854776E+18 && geoPoint.imethod_2() <= 9.223372036854776E+18)
						{
							list4.Add(new IntPoint((long)Math.Round(geoPoint.imethod_0()), (long)Math.Round(geoPoint.imethod_2())));
						}
					}
				}
				finally
				{
					List<GeoPoint>.Enumerator enumerator4;
					((IDisposable)enumerator4).Dispose();
				}
				Class145 @class = new Class145(0);
				@class.method_7(list3, Enum20.const_0, true);
				@class.method_7(list4, Enum20.const_1, true);
				List<List<IntPoint>> list5 = new List<List<IntPoint>>();
				if (@class.method_20(Enum19.const_0, list5, Enum21.const_1, Enum21.const_1))
				{
					List<GeoPoint> list6 = new List<GeoPoint>();
					if (list5.Count > 0)
					{
						try
						{
							foreach (IntPoint intPoint in list5[0])
							{
								GeoPoint geoPoint = new GeoPoint();
								geoPoint.imethod_3((double)intPoint.long_1 / 100000000000000.0);
								geoPoint.imethod_1((double)intPoint.long_0 / 100000000000000.0);
								list6.Add(geoPoint);
							}
						}
						finally
						{
							List<IntPoint>.Enumerator enumerator5;
							((IDisposable)enumerator5).Dispose();
						}
						result = list6;
					}
					else
					{
						result = new List<GeoPoint>();
					}
				}
				else
				{
					result = new List<GeoPoint>();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200016", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = list_1;
			}
			return result;
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00226DC4 File Offset: 0x00224FC4
		private static List<Geopoint_Struct[]> smethod_31(List<Geopoint_Struct[]> list_0)
		{
			List<Geopoint_Struct[]> result;
			try
			{
				Class145 @class = new Class145(0);
				try
				{
					foreach (Geopoint_Struct[] array in list_0)
					{
						List<IntPoint> list = new List<IntPoint>();
						foreach (Geopoint_Struct geopoint_Struct in array)
						{
							Geopoint_Struct geopoint_Struct2 = new Geopoint_Struct(geopoint_Struct.double_0 * 100000000000000.0, geopoint_Struct.double_1 * 100000000000000.0);
							if (!double.IsNaN(geopoint_Struct2.double_1) && !double.IsNaN(geopoint_Struct2.double_0) && geopoint_Struct2.double_0 <= 9.223372036854776E+18 && geopoint_Struct2.double_1 <= 9.223372036854776E+18)
							{
								list.Add(new IntPoint((long)Math.Round(geopoint_Struct2.double_0), (long)Math.Round(geopoint_Struct2.double_1)));
							}
						}
						@class.method_7(list, Enum20.const_0, true);
					}
				}
				finally
				{
					List<Geopoint_Struct[]>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				List<List<IntPoint>> list2 = new List<List<IntPoint>>();
				if (@class.method_20(Enum19.const_1, list2, Enum21.const_1, Enum21.const_1))
				{
					List<Geopoint_Struct[]> list3 = new List<Geopoint_Struct[]>();
					if (list2.Count > 0)
					{
						try
						{
							foreach (List<IntPoint> list4 in list2)
							{
								Geopoint_Struct[] array3 = new Geopoint_Struct[list4.Count - 1 + 1];
								int num = list4.Count - 1;
								for (int j = 0; j <= num; j++)
								{
									array3[j] = new Geopoint_Struct
									{
										double_1 = (double)list4[j].long_1 / 100000000000000.0,
										double_0 = (double)list4[j].long_0 / 100000000000000.0
									};
								}
								list3.Add(array3);
							}
						}
						finally
						{
							List<List<IntPoint>>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						result = list3;
					}
					else
					{
						result = new List<Geopoint_Struct[]>();
					}
				}
				else
				{
					result = new List<Geopoint_Struct[]>();
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Geopoint_Struct[]>();
			}
			return result;
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00227038 File Offset: 0x00225238
		public static List<Geopoint_Struct[]> smethod_32(List<Geopoint_Struct[]> list_0)
		{
			Math2.Class436 @class = new Math2.Class436(@class);
			List<Geopoint_Struct[]> result;
			if (list_0.Count == 0)
			{
				result = new List<Geopoint_Struct[]>();
			}
			else
			{
				List<Geopoint_Struct[]>[] array = Misc.smethod_66<Geopoint_Struct[]>(list_0, GameGeneral.int_2);
				@class.concurrentBag_0 = new ConcurrentBag<List<Geopoint_Struct[]>>();
				try
				{
					Parallel.ForEach<List<Geopoint_Struct[]>>(array, new Action<List<Geopoint_Struct[]>>(@class.method_0));
					List<List<Geopoint_Struct[]>> list = Enumerable.ToList<List<Geopoint_Struct[]>>(@class.concurrentBag_0);
					List<Geopoint_Struct[]> list2 = new List<Geopoint_Struct[]>();
					try
					{
						foreach (List<Geopoint_Struct[]> collection in list)
						{
							list2.AddRange(collection);
						}
					}
					finally
					{
						List<List<Geopoint_Struct[]>>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					result = Math2.smethod_31(list2);
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 20023452465666621347826346", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<Geopoint_Struct[]>();
				}
			}
			return result;
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00227138 File Offset: 0x00225338
		public static double smethod_33(string string_0)
		{
			string numberGroupSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
			double num;
			if (string_0.LastIndexOf(numberGroupSeparator) + 4 == Enumerable.Count<char>(string_0))
			{
				num = (double.TryParse(string_0, NumberStyles.Any, CultureInfo.CurrentCulture, out num) ? num : 0.0);
			}
			else
			{
				string text = string_0.Trim().Replace(" ", string.Empty).Replace(",", ".");
				string[] array = text.Split(new char[]
				{
					'.'
				});
				if (Enumerable.Count<string>(array) > 1)
				{
					text = string.Join(string.Empty, Enumerable.ToArray<string>(Enumerable.Take<string>(array, Enumerable.Count<string>(array) - 1)));
					text = string.Format("{0}.{1}", text, Enumerable.Last<string>(array));
				}
				num = double.Parse(text, CultureInfo.InvariantCulture);
			}
			return num;
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x00227208 File Offset: 0x00225408
		public static double smethod_34(Tuple<double, double> tuple_0, Tuple<double, double> tuple_1)
		{
			double item = tuple_0.Item1;
			double item2 = tuple_1.Item1;
			double num = tuple_1.Item2 - tuple_0.Item2;
			double y = Math.Sin(num) * Math.Cos(item2);
			double x = Math.Cos(item) * Math.Sin(item2) - Math.Sin(item) * Math.Cos(item2) * Math.Cos(num);
			return Math.Atan2(y, x);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00227268 File Offset: 0x00225468
		public static Tuple<double, double> smethod_35(Tuple<double, double> tuple_0, Tuple<double, double> tuple_1, Tuple<double, double> tuple_2, Tuple<double, double> tuple_3)
		{
			double item = tuple_0.Item1;
			double item2 = tuple_0.Item2;
			double item3 = tuple_2.Item1;
			double item4 = tuple_2.Item2;
			double num = Math2.smethod_34(tuple_0, tuple_1);
			double num2 = Math2.smethod_34(tuple_2, tuple_3);
			double num3 = item3 - item;
			double num4 = item4 - item2;
			double num5 = 2.0 * Math.Asin(Math.Sqrt(Math.Sin(num3 / 2.0) * Math.Sin(num3 / 2.0) + Math.Cos(item) * Math.Cos(item3) * Math.Sin(num4 / 2.0) * Math.Sin(num4 / 2.0)));
			Tuple<double, double> result;
			if (num5 == 0.0)
			{
				result = null;
			}
			else
			{
				double num6 = Math.Acos((Math.Sin(item3) - Math.Sin(item) * Math.Cos(num5)) / (Math.Sin(num5) * Math.Cos(item)));
				if (double.IsNaN(num6))
				{
					num6 = 0.0;
				}
				double num7 = Math.Acos((Math.Sin(item) - Math.Sin(item3) * Math.Cos(num5)) / (Math.Sin(num5) * Math.Cos(item3)));
				double num8;
				double num9;
				if (Math.Sin(item4 - item2) > 0.0)
				{
					num8 = num6;
					num9 = 6.283185307179586 - num7;
				}
				else
				{
					num8 = 6.283185307179586 - num6;
					num9 = num7;
				}
				double num10 = (num - num8 + 3.141592653589793) % 6.283185307179586 - 3.141592653589793;
				double num11 = (num9 - num2 + 3.141592653589793) % 6.283185307179586 - 3.141592653589793;
				if (Math.Sin(num10) == 0.0 && Math.Sin(num11) == 0.0)
				{
					result = null;
				}
				else if (Math.Sin(num10) * Math.Sin(num11) < 0.0)
				{
					result = null;
				}
				else
				{
					double d = Math.Acos(-Math.Cos(num10) * Math.Cos(num11) + Math.Sin(num10) * Math.Sin(num11) * Math.Cos(num5));
					double num12 = Math.Atan2(Math.Sin(num5) * Math.Sin(num10) * Math.Sin(num11), Math.Cos(num11) + Math.Cos(num10) * Math.Cos(d));
					double num13 = Math.Asin(Math.Sin(item) * Math.Cos(num12) + Math.Cos(item) * Math.Sin(num12) * Math.Cos(num));
					double num14 = Math.Atan2(Math.Sin(num) * Math.Sin(num12) * Math.Cos(item), Math.Cos(num12) - Math.Sin(item) * Math.Sin(num13));
					double num15 = item2 + num14;
					num15 = (num15 + 9.42477796076938) % 6.283185307179586 - 3.141592653589793;
					result = new Tuple<double, double>(num13, num15);
				}
			}
			return result;
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00227560 File Offset: 0x00225760
		public static double smethod_36(double double_0, double double_1, double double_2)
		{
			double num = double_0 * 0.0174532925199433;
			double num2 = double_1 * 0.0174532925199433;
			double num3 = Math.Cos(num);
			double num4 = Math.Sin(num);
			double num5 = Math.Cos(num2) * double_2;
			double num6 = Math.Sin(num2) * double_2;
			return num3 * num5 + num4 * num6;
		}

		// Token: 0x020003E8 RID: 1000
		[CompilerGenerated]
		internal sealed class Class435
		{
			// Token: 0x06001E13 RID: 7699 RVA: 0x0000ECBC File Offset: 0x0000CEBC
			internal float method_0(GeoPoint geoPoint_0)
			{
				return geoPoint_0.method_12(this.double_0, this.double_1);
			}

			// Token: 0x04001C52 RID: 7250
			public double double_0;

			// Token: 0x04001C53 RID: 7251
			public double double_1;
		}

		// Token: 0x020003EA RID: 1002
		[CompilerGenerated]
		internal sealed class Class436
		{
			// Token: 0x06001E1A RID: 7706 RVA: 0x0000ECEC File Offset: 0x0000CEEC
			public Class436(Math2.Class436 class436_0)
			{
				if (class436_0 != null)
				{
					this.concurrentBag_0 = class436_0.concurrentBag_0;
				}
			}

			// Token: 0x06001E1B RID: 7707 RVA: 0x0000ED03 File Offset: 0x0000CF03
			internal void method_0(List<Geopoint_Struct[]> list_0)
			{
				this.concurrentBag_0.Add(Math2.smethod_31(list_0));
			}

			// Token: 0x04001C59 RID: 7257
			public ConcurrentBag<List<Geopoint_Struct[]>> concurrentBag_0;
		}
	}
}
