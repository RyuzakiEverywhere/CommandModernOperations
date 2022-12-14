using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using ns12;

namespace Command_Core
{
	// Token: 0x020003AC RID: 940
	[StandardModule]
	public sealed class LandCover
	{
		// Token: 0x06001CA9 RID: 7337 RVA: 0x0020E6E8 File Offset: 0x0020C8E8
		public static void smethod_0()
		{
			try
			{
				LandCover.string_0 = Path.Combine(GameGeneral.string_8, "LandCover");
				string[] files = Directory.GetFiles(LandCover.string_0);
				LandCover.class405_0 = new Class405[files.Length - 1 + 1];
				int num = files.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					Class405 @class = new Class405(files[i]);
					@class.method_5();
					LandCover.class405_0[i] = @class;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 10121342130593240909120902", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x0020E798 File Offset: 0x0020C998
		public static LandCover.LandCoverType smethod_1(double double_0, double double_1)
		{
			Class405 @class = LandCover.smethod_2(double_0, double_1);
			LandCover.LandCoverType result;
			if (@class == null)
			{
				result = LandCover.LandCoverType.Water;
			}
			else
			{
				result = (LandCover.LandCoverType)@class.method_6(double_1, double_0);
			}
			return result;
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x0020E7C0 File Offset: 0x0020C9C0
		private static Class405 smethod_2(double double_0, double double_1)
		{
			foreach (Class405 @class in LandCover.class405_0)
			{
				if (@class.double_3 >= double_0 && @class.double_2 <= double_1 && Math.Ceiling(double_1) <= Math.Ceiling(@class.method_4()) && Math.Ceiling(double_0) >= Math.Ceiling(@class.method_3()))
				{
					return @class;
				}
			}
			return null;
		}

		// Token: 0x04001944 RID: 6468
		public static string string_0;

		// Token: 0x04001945 RID: 6469
		private static Class405[] class405_0;

		// Token: 0x020003AD RID: 941
		public enum LandCoverType : byte
		{
			// Token: 0x04001947 RID: 6471
			Water,
			// Token: 0x04001948 RID: 6472
			Evergreen_Needleleaf_forest,
			// Token: 0x04001949 RID: 6473
			Evergreen_Broadleaf_forest,
			// Token: 0x0400194A RID: 6474
			Deciduous_Needleleaf_forest,
			// Token: 0x0400194B RID: 6475
			Deciduous_Broadleaf_forest,
			// Token: 0x0400194C RID: 6476
			Mixed_forest,
			// Token: 0x0400194D RID: 6477
			Closed_shrublands,
			// Token: 0x0400194E RID: 6478
			Open_shrublands,
			// Token: 0x0400194F RID: 6479
			Woody_savannas,
			// Token: 0x04001950 RID: 6480
			Savannas,
			// Token: 0x04001951 RID: 6481
			Grasslands,
			// Token: 0x04001952 RID: 6482
			Permanent_wetlands,
			// Token: 0x04001953 RID: 6483
			Croplands,
			// Token: 0x04001954 RID: 6484
			UrbanAndBuiltUp,
			// Token: 0x04001955 RID: 6485
			CroplandNaturalVegetationMosaic,
			// Token: 0x04001956 RID: 6486
			SnowAndIce,
			// Token: 0x04001957 RID: 6487
			BarrenOrSparselyVegetated,
			// Token: 0x04001958 RID: 6488
			Unclassified = 254,
			// Token: 0x04001959 RID: 6489
			Fill_Value
		}
	}
}
