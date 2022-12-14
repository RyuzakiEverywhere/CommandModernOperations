using System;
using Microsoft.VisualBasic.CompilerServices;
using Steamworks;

namespace ns4
{
	// Token: 0x02000E59 RID: 3673
	[StandardModule]
	internal sealed class Class2474
	{
		// Token: 0x06006F74 RID: 28532 RVA: 0x0004647D File Offset: 0x0004467D
		public static void smethod_0()
		{
			if (Class2474.bool_0)
			{
				SteamAPI.Shutdown();
			}
		}

		// Token: 0x06006F75 RID: 28533 RVA: 0x0004648B File Offset: 0x0004468B
		public static void smethod_1()
		{
			if (!Class2474.bool_1)
			{
				Class2474.bool_0 = SteamAPI.Init();
				Class2474.bool_1 = true;
			}
		}

		// Token: 0x06006F76 RID: 28534 RVA: 0x003C33E4 File Offset: 0x003C15E4
		public static bool smethod_2(AppId_t appId_t_0)
		{
			if (!Class2474.bool_0 && !Class2474.bool_1)
			{
				Class2474.smethod_1();
			}
			if (Class2474.bool_0)
			{
				if (SteamApps.BIsSubscribedApp(appId_t_0))
				{
					return true;
				}
			}
			else
			{
				byte[] array = new byte[1025];
				uint num;
				if (SteamUser.GetAuthSessionTicket(array, 1024, out num) != HAuthTicket.Invalid & (ulong)num > 0UL)
				{
					SteamUser.BeginAuthSession(array, (int)num, SteamUser.GetSteamID());
					if (SteamUser.UserHasLicenseForApp(SteamUser.GetSteamID(), appId_t_0) == EUserHasLicenseForAppResult.k_EUserHasLicenseResultHasLicense)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x04003F30 RID: 16176
		public static bool bool_0;

		// Token: 0x04003F31 RID: 16177
		private static bool bool_1 = false;
	}
}
