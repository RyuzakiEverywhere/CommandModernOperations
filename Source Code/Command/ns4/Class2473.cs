using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;

namespace ns4
{
	// Token: 0x02000E58 RID: 3672
	[StandardModule]
	internal sealed class Class2473
	{
		// Token: 0x06006F70 RID: 28528 RVA: 0x003C322C File Offset: 0x003C142C
		public static void smethod_0()
		{
			try
			{
				Class2473.guid_0 = Class56.smethod_2();
				Dictionary<Guid, Class55> dictionary = Class56.smethod_1();
				try
				{
					foreach (KeyValuePair<Guid, Class55> keyValuePair in dictionary)
					{
						if (Operators.CompareString(keyValuePair.Value.string_0.ToUpper(), "HIGH PERFORMANCE", false) == 0 && !(keyValuePair.Key == Class2473.guid_0))
						{
							Class56.smethod_0(keyValuePair.Key);
						}
					}
				}
				finally
				{
					Dictionary<Guid, Class55>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (KeyValuePair<Guid, Class55> keyValuePair2 in dictionary)
					{
						if (Operators.CompareString(keyValuePair2.Value.string_0.ToUpper(), "ULTIMATE PERFORMANCE", false) == 0 && !(keyValuePair2.Key == Class2473.guid_0))
						{
							Class56.smethod_0(keyValuePair2.Key);
						}
					}
				}
				finally
				{
					Dictionary<Guid, Class55>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06006F71 RID: 28529 RVA: 0x003C3354 File Offset: 0x003C1554
		public static void smethod_1()
		{
			try
			{
				if (!Information.IsNothing(Class2473.guid_0) && !(Class56.smethod_2() == Class2473.guid_0))
				{
					Class56.smethod_0(Class2473.guid_0);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06006F72 RID: 28530 RVA: 0x003C33AC File Offset: 0x003C15AC
		public static bool smethod_2()
		{
			return Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6;
		}

		// Token: 0x04003F2F RID: 16175
		private static Guid guid_0;
	}
}
