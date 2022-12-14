using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using ns12;
using ns14;
using ns19;
using ns20;
using ns9;

namespace Command_Core
{
	// Token: 0x020004C1 RID: 1217
	[StandardModule]
	public sealed class Terrain
	{
		// Token: 0x06002439 RID: 9273 RVA: 0x002B61B8 File Offset: 0x002B43B8
		public static void smethod_0()
		{
			try
			{
				Terrain.string_0 = Path.Combine(GameGeneral.string_8, "Terrain\\SRTM30Plus\\");
				foreach (string directory in Directory.GetDirectories(Terrain.string_0))
				{
					Class160.smethod_0().FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
				}
				Terrain.dictionary_0.Clear();
				Terrain.int_1 = Enumerable.Count<string>(Directory.GetFiles(Terrain.string_0));
				int num = 0;
				foreach (string text in Directory.GetFiles(Terrain.string_0))
				{
					if (text.EndsWith(".bgd"))
					{
						num++;
						Terrain.class572_0 = new Class571.Class572();
						Terrain.class572_0.method_7(Path.Combine(Terrain.string_0, text));
						Terrain.class572_0.method_1(Path.GetFileName(text));
						List<Class571.Class572> list = new List<Class571.Class572>();
						list.Add(Terrain.class572_0);
						if (!Terrain.dictionary_0.ContainsKey(Path.GetFileName(text)))
						{
							Terrain.dictionary_0.Add(Path.GetFileName(text), list);
						}
						Terrain.int_0 = num;
					}
				}
				Terrain.bool_0 = true;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101105", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x002B6334 File Offset: 0x002B4534
		public static void smethod_1()
		{
			try
			{
				try
				{
					foreach (List<Class571.Class572> list in Terrain.dictionary_0.Values)
					{
						try
						{
							foreach (Class571.Class572 @class in list)
							{
								if (!Information.IsNothing(@class))
								{
									@class.method_4();
								}
							}
						}
						finally
						{
							List<Class571.Class572>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
				finally
				{
					Dictionary<string, List<Class571.Class572>>.ValueCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200271", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x0001186D File Offset: 0x0000FA6D
		public static void smethod_2(ref short short_0)
		{
			if (short_0 < 0 && short_0 > -20)
			{
				short_0 = -20;
			}
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x002B6410 File Offset: 0x002B4610
		public static string smethod_3(ref double double_0, ref double double_1)
		{
			double_0 = Math2.smethod_10(ref double_0);
			double_1 = Math2.smethod_11(ref double_1);
			double num = double_0;
			string result;
			if (num > 40.0)
			{
				double num2 = double_1;
				if (num2 > 140.0)
				{
					result = "e140n90.bgd";
				}
				else if (num2 > 100.0)
				{
					result = "e100n90.bgd";
				}
				else if (num2 > 60.0)
				{
					result = "e60n90.bgd";
				}
				else if (num2 > 20.0)
				{
					result = "e20n90.bgd";
				}
				else if (num2 > -20.0)
				{
					result = "w20n90.bgd";
				}
				else if (num2 > -60.0)
				{
					result = "w60n90.bgd";
				}
				else if (num2 > -100.0)
				{
					result = "w100n90.bgd";
				}
				else if (num2 > -140.0)
				{
					result = "w140n90.bgd";
				}
				else
				{
					result = "w180n90.bgd";
				}
			}
			else if (num > -10.0)
			{
				double num3 = double_1;
				if (num3 > 140.0)
				{
					result = "e140n40.bgd";
				}
				else if (num3 > 100.0)
				{
					result = "e100n40.bgd";
				}
				else if (num3 > 60.0)
				{
					result = "e60n40.bgd";
				}
				else if (num3 > 20.0)
				{
					result = "e20n40.bgd";
				}
				else if (num3 > -20.0)
				{
					result = "w20n40.bgd";
				}
				else if (num3 > -60.0)
				{
					result = "w60n40.bgd";
				}
				else if (num3 > -100.0)
				{
					result = "w100n40.bgd";
				}
				else if (num3 > -140.0)
				{
					result = "w140n40.bgd";
				}
				else
				{
					result = "w180n40.bgd";
				}
			}
			else if (num > -60.0)
			{
				double num4 = double_1;
				if (num4 > 140.0)
				{
					result = "e140s10.bgd";
				}
				else if (num4 > 100.0)
				{
					result = "e100s10.bgd";
				}
				else if (num4 > 60.0)
				{
					result = "e60s10.bgd";
				}
				else if (num4 > 20.0)
				{
					result = "e20s10.bgd";
				}
				else if (num4 > -20.0)
				{
					result = "w20s10.bgd";
				}
				else if (num4 > -60.0)
				{
					result = "w60s10.bgd";
				}
				else if (num4 > -100.0)
				{
					result = "w100s10.bgd";
				}
				else if (num4 > -140.0)
				{
					result = "w140s10.bgd";
				}
				else
				{
					result = "w180s10.bgd";
				}
			}
			else
			{
				double num5 = double_1;
				if (num5 > 120.0)
				{
					result = "e120s60.bgd";
				}
				else if (num5 > 60.0)
				{
					result = "e60s60.bgd";
				}
				else if (num5 > 0.0)
				{
					result = "w0s60.bgd";
				}
				else if (num5 > -60.0)
				{
					result = "w60s60.bgd";
				}
				else if (num5 > -120.0)
				{
					result = "w120s60.bgd";
				}
				else
				{
					result = "w180s60.bgd";
				}
			}
			return result;
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x002B6728 File Offset: 0x002B4928
		public static ConcurrentBag<Terrain.Struct55> smethod_4(double double_0, double double_1, float float_2, float float_3, float float_4)
		{
			Terrain.Class580 @class = new Terrain.Class580();
			@class.double_0 = double_0;
			@class.double_1 = double_1;
			@class.float_1 = float_2;
			@class.float_0 = float_3;
			IEnumerable<Terrain.Struct55> enumerable = Terrain.smethod_5(@class.double_0, @class.double_1, float_4);
			@class.concurrentBag_0 = new ConcurrentBag<Terrain.Struct55>();
			Parallel.ForEach<Terrain.Struct55>(enumerable, new Action<Terrain.Struct55>(@class.method_0));
			return @class.concurrentBag_0;
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x002B6790 File Offset: 0x002B4990
		private static List<Terrain.Struct55> smethod_5(double double_0, double double_1, float float_2)
		{
			double num = 0.0;
			double num2;
			Class411.smethod_1(double_1, double_0, ref num2, ref num, (double)float_2, 270.0);
			num = 0.0;
			double num3;
			Class411.smethod_1(double_1, double_0, ref num3, ref num, (double)float_2, 90.0);
			num = 0.0;
			double num4;
			Class411.smethod_1(double_1, double_0, ref num, ref num4, (double)float_2, 0.0);
			num = 0.0;
			double num5;
			Class411.smethod_1(double_1, double_0, ref num, ref num5, (double)float_2, 180.0);
			double num6 = Math2.smethod_13((double)float_2);
			List<Terrain.Struct55> list = new List<Terrain.Struct55>((int)Math.Round(Math.Pow((double)((int)Math.Round(num6 * 2.0 / 0.008333333333333333)), 2.0)));
			double num7 = num2;
			num = num3;
			for (double num8 = num7; num8 <= num; num8 += 0.008333333333333333)
			{
				double num9 = num4;
				double num10 = num5;
				for (double num11 = num9; num11 >= num10; num11 += -0.008333333333333333)
				{
					Class571.Class572 @class = Terrain.smethod_6(num11, num8);
					int int_;
					int int_2;
					@class.method_2(ref num8, ref num11, ref int_, ref int_2);
					Terrain.Struct55 @struct;
					@class.method_3(int_, int_2, ref @struct.double_1, ref @struct.double_0);
					if (Math2.smethod_15(@struct.double_0, @struct.double_1, double_0, double_1) <= float_2)
					{
						@struct.double_3 = @class.double_1;
						@struct.double_2 = @class.double_0;
						list.Add(@struct);
					}
				}
			}
			return list;
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x002B690C File Offset: 0x002B4B0C
		private static Class571.Class572 smethod_6(double double_0, double double_1)
		{
			string text = Terrain.smethod_3(ref double_0, ref double_1);
			List<Class571.Class572> list = Terrain.dictionary_0[text];
			Class571.Class572 @class = null;
			int count = list.Count;
			while (Information.IsNothing(@class))
			{
				int num = count - 1;
				for (int i = 0; i <= num; i++)
				{
					Class571.Class572 class2 = list[i];
					if (!Information.IsNothing(class2) && !class2.bool_0)
					{
						return class2;
					}
				}
				if (list.Count < Terrain.int_2)
				{
					Terrain.class572_0 = new Class571.Class572();
					Terrain.class572_0.method_7(Terrain.string_0 + "\\" + text);
					Terrain.class572_0.method_1(Path.GetFileName(text));
					Terrain.class572_0.class573_0 = list[0].class573_0;
					if (list.Count < Terrain.int_2)
					{
						list.Add(Terrain.class572_0);
					}
					@class = Terrain.class572_0;
					continue;
				}
			}
			return @class;
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x002B69FC File Offset: 0x002B4BFC
		public static short smethod_7(double double_0, double double_1, bool bool_1)
		{
			short result;
			try
			{
				double_0 = Math2.smethod_10(ref double_0);
				double_1 = Math2.smethod_11(ref double_1);
				result = Terrain.smethod_6(double_0, double_1).method_5(double_1, double_0, bool_1);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200092", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x002B6A78 File Offset: 0x002B4C78
		public static float smethod_8(double double_0, double double_1, bool bool_1)
		{
			float result;
			try
			{
				double_0 = Math2.smethod_10(ref double_0);
				double_1 = Math2.smethod_11(ref double_1);
				Geopoint_Struct geopoint_Struct = GeoPoint.smethod_12(double_0, double_1, 315f, 0.12142472f);
				Geopoint_Struct geopoint_Struct2 = GeoPoint.smethod_12(double_0, double_1, 0f, 0.12142472f);
				Geopoint_Struct geopoint_Struct3 = GeoPoint.smethod_12(double_0, double_1, 45f, 0.12142472f);
				Geopoint_Struct geopoint_Struct4 = GeoPoint.smethod_12(double_0, double_1, 90f, 0.12142472f);
				Geopoint_Struct geopoint_Struct5 = GeoPoint.smethod_12(double_0, double_1, 135f, 0.12142472f);
				Geopoint_Struct geopoint_Struct6 = GeoPoint.smethod_12(double_0, double_1, 180f, 0.12142472f);
				Geopoint_Struct geopoint_Struct7 = GeoPoint.smethod_12(double_0, double_1, 225f, 0.12142472f);
				Geopoint_Struct geopoint_Struct8 = GeoPoint.smethod_12(double_0, double_1, 270f, 0.12142472f);
				float value = (float)((double)(Terrain.smethod_7(geopoint_Struct2.double_1, geopoint_Struct2.double_0, bool_1) - Terrain.smethod_7(geopoint_Struct6.double_1, geopoint_Struct6.double_0, bool_1)) / (double)450f);
				float value2 = (float)((double)(Terrain.smethod_7(geopoint_Struct4.double_1, geopoint_Struct4.double_0, bool_1) - Terrain.smethod_7(geopoint_Struct8.double_1, geopoint_Struct8.double_0, bool_1)) / (double)450f);
				float value3 = (float)((double)(Terrain.smethod_7(geopoint_Struct3.double_1, geopoint_Struct3.double_0, bool_1) - Terrain.smethod_7(geopoint_Struct7.double_1, geopoint_Struct7.double_0, bool_1)) / (double)450f);
				float value4 = (float)((double)(Terrain.smethod_7(geopoint_Struct.double_1, geopoint_Struct.double_0, bool_1) - Terrain.smethod_7(geopoint_Struct5.double_1, geopoint_Struct5.double_0, bool_1)) / (double)450f);
				result = Enumerable.Max(new List<float>
				{
					Math.Abs(value2),
					Math.Abs(value),
					Math.Abs(value3),
					Math.Abs(value4)
				});
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200094", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x002B6C94 File Offset: 0x002B4E94
		public static float smethod_9(double double_0, double double_1, float float_2)
		{
			Dictionary<string, short> dictionary = new Dictionary<string, short>();
			double_0 = Math2.smethod_10(ref double_0);
			double_1 = Math2.smethod_11(ref double_1);
			double num;
			double num2;
			Class411.smethod_1(double_1, double_0, ref num, ref num2, (double)((float)((double)float_2 * 1.414)), 225.0);
			double double_2;
			double double_3;
			Class411.smethod_1(double_1, double_0, ref double_2, ref double_3, (double)((float)((double)float_2 * 1.414)), 315.0);
			double double_4;
			double double_5;
			Class411.smethod_1(double_1, double_0, ref double_4, ref double_5, (double)((float)((double)float_2 * 1.414)), 45.0);
			double double_6;
			double double_7;
			Class411.smethod_1(double_1, double_0, ref double_6, ref double_7, (double)((float)((double)float_2 * 1.414)), 135.0);
			Struct65 @struct = default(Struct65);
			@struct.method_1(num);
			Struct65 struct2 = default(Struct65);
			struct2.method_1(num2);
			Struct65 struct3 = default(Struct65);
			struct3.method_1(double_2);
			Struct65 struct4 = default(Struct65);
			struct4.method_1(double_3);
			Struct65 lat = default(Struct65);
			lat.method_1(double_5);
			Struct65 lon = default(Struct65);
			lon.method_1(double_4);
			Struct65 lon2 = default(Struct65);
			lon2.method_1(double_6);
			Struct65 lat2 = default(Struct65);
			lat2.method_1(double_7);
			Struct65 d = Class1874.smethod_1(struct2, @struct, struct4, struct3);
			float num3 = 0f;
			float num4 = 0f;
			StringBuilder stringBuilder = new StringBuilder();
			while ((double)num3 < d.method_0())
			{
				Struct65 struct65_ = default(Struct65);
				Struct65 struct65_2 = default(Struct65);
				Struct65 struct65_3 = default(Struct65);
				Struct65 struct65_4 = default(Struct65);
				Class1874.smethod_2((float)((double)num3 / d.method_0()), struct2, @struct, struct4, struct3, d, out struct65_, out struct65_2);
				Class1874.smethod_2((float)((double)num3 / d.method_0()), lat2, lon2, lat, lon, d, out struct65_3, out struct65_4);
				Struct65 struct5 = Class1874.smethod_1(struct65_, struct65_2, struct65_3, struct65_4);
				while ((double)num4 < struct5.method_0())
				{
					double num5 = num2 + (double)num3;
					double double_8 = Math2.smethod_10(ref num5);
					num5 = num + (double)num4;
					double double_9 = Math2.smethod_11(ref num5);
					string text = Terrain.smethod_3(ref double_8, ref double_9);
					Class571.Class572 @class = Terrain.dictionary_0[text][0];
					try
					{
						int value;
						int value2;
						@class.method_2(ref double_9, ref double_8, ref value, ref value2);
						stringBuilder.Clear();
						stringBuilder.Append(text);
						stringBuilder.Append("_");
						stringBuilder.Append(value2);
						stringBuilder.Append("_");
						stringBuilder.Append(value);
						string key = stringBuilder.ToString();
						if (!dictionary.ContainsKey(key))
						{
							dictionary.Add(key, @class.method_5(double_9, double_8, false));
						}
						goto IL_2D2;
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 101107", "");
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						goto IL_2D2;
					}
					break;
					IL_2D2:
					num4 += Terrain.float_1;
				}
				num3 += Terrain.float_1;
			}
			return (float)((double)Enumerable.Count<short>(Enumerable.Where<short>(dictionary.Values, (Terrain._Closure$__.$I21-0 == null) ? (Terrain._Closure$__.$I21-0 = new Func<short, bool>(Terrain._Closure$__.$I.method_0)) : Terrain._Closure$__.$I21-0)) / (double)dictionary.Values.Count);
		}

		// Token: 0x04001F22 RID: 7970
		public static bool bool_0 = false;

		// Token: 0x04001F23 RID: 7971
		private static int int_0;

		// Token: 0x04001F24 RID: 7972
		private static int int_1;

		// Token: 0x04001F25 RID: 7973
		internal static string string_0;

		// Token: 0x04001F26 RID: 7974
		private static Class571.Class572 class572_0;

		// Token: 0x04001F27 RID: 7975
		public static Dictionary<string, List<Class571.Class572>> dictionary_0 = new Dictionary<string, List<Class571.Class572>>();

		// Token: 0x04001F28 RID: 7976
		private static Dictionary<Class571.Class572, int> dictionary_1 = new Dictionary<Class571.Class572, int>();

		// Token: 0x04001F29 RID: 7977
		private static float float_0 = 0.5f;

		// Token: 0x04001F2A RID: 7978
		private static float float_1 = 0.008333334f;

		// Token: 0x04001F2B RID: 7979
		private static int int_2 = 30;

		// Token: 0x020004C2 RID: 1218
		internal struct Struct55
		{
			// Token: 0x06002443 RID: 9283 RVA: 0x0001187E File Offset: 0x0000FA7E
			public Geopoint_Struct method_0()
			{
				return new Geopoint_Struct(this.double_1 - this.double_2 * 0.5, this.double_0 + this.double_3 * 0.5);
			}

			// Token: 0x06002444 RID: 9284 RVA: 0x000118B3 File Offset: 0x0000FAB3
			public Geopoint_Struct method_1()
			{
				return new Geopoint_Struct(this.double_1 + this.double_2 * 0.5, this.double_0 + this.double_3 * 0.5);
			}

			// Token: 0x06002445 RID: 9285 RVA: 0x000118E8 File Offset: 0x0000FAE8
			public Geopoint_Struct method_2()
			{
				return new Geopoint_Struct(this.double_1 - this.double_2 * 0.5, this.double_0 - this.double_3 * 0.5);
			}

			// Token: 0x06002446 RID: 9286 RVA: 0x0001191D File Offset: 0x0000FB1D
			public Geopoint_Struct method_3()
			{
				return new Geopoint_Struct(this.double_1 + this.double_2 * 0.5, this.double_0 - this.double_3 * 0.5);
			}

			// Token: 0x04001F2C RID: 7980
			public double double_0;

			// Token: 0x04001F2D RID: 7981
			public double double_1;

			// Token: 0x04001F2E RID: 7982
			public double double_2;

			// Token: 0x04001F2F RID: 7983
			public double double_3;
		}

		// Token: 0x020004C3 RID: 1219
		[CompilerGenerated]
		internal sealed class Class580
		{
			// Token: 0x06002448 RID: 9288 RVA: 0x002B6FD8 File Offset: 0x002B51D8
			internal void method_0(Terrain.Struct55 struct55_0)
			{
				short val = Terrain.smethod_7(struct55_0.double_0, struct55_0.double_1, false);
				float num = (float)Math.Max(0, (int)val) + this.float_0;
				if (Scenario.smethod_16(ref this.double_0, ref this.double_1, ref this.float_1, ref struct55_0.double_0, ref struct55_0.double_1, ref num, false, 0, false))
				{
					this.concurrentBag_0.Add(struct55_0);
				}
			}

			// Token: 0x04001F30 RID: 7984
			public float float_0;

			// Token: 0x04001F31 RID: 7985
			public double double_0;

			// Token: 0x04001F32 RID: 7986
			public double double_1;

			// Token: 0x04001F33 RID: 7987
			public float float_1;

			// Token: 0x04001F34 RID: 7988
			public ConcurrentBag<Terrain.Struct55> concurrentBag_0;
		}
	}
}
