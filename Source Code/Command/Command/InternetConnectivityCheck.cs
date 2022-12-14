using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using ns21;

namespace Command
{
	// Token: 0x02000E52 RID: 3666
	[StandardModule]
	internal sealed class InternetConnectivityCheck
	{
		// Token: 0x06006ED0 RID: 28368 RVA: 0x00045F0D File Offset: 0x0004410D
		public static void smethod_0(bool bool_1)
		{
			if (bool_1)
			{
				Task.Factory.StartNew((InternetConnectivityCheck._Closure$__.$I3-0 == null) ? (InternetConnectivityCheck._Closure$__.$I3-0 = new Action(InternetConnectivityCheck._Closure$__.$I.method_0)) : InternetConnectivityCheck._Closure$__.$I3-0);
				return;
			}
			InternetConnectivityCheck.smethod_1();
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x003C0388 File Offset: 0x003BE588
		private static void smethod_1()
		{
			try
			{
				InternetConnectivityCheck.webClient_0.OpenRead("http://clients3.google.com/generate_204");
				InternetConnectivityCheck.bool_0 = true;
				Class1884.smethod_0(true);
			}
			catch (Exception ex)
			{
				InternetConnectivityCheck.bool_0 = false;
				Class1884.smethod_0(false);
			}
		}

		// Token: 0x04003EED RID: 16109
		public static bool bool_0 = true;

		// Token: 0x04003EEE RID: 16110
		private static WebClient webClient_0 = new WebClient();
	}
}
