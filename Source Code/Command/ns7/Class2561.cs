using System;
using System.Diagnostics;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns3;

namespace ns7
{
	// Token: 0x02000F43 RID: 3907
	[StandardModule]
	internal sealed class Class2561
	{
		// Token: 0x06008BFB RID: 35835 RVA: 0x004B609C File Offset: 0x004B429C
		public static void smethod_0()
		{
			try
			{
				Class2561.class2559_0 = new Class2559();
				Class2561.soundHandler_Effects_0 = new SoundHandler_Effects();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200419", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				Class2561.smethod_2(ex);
			}
		}

		// Token: 0x06008BFC RID: 35836 RVA: 0x004B610C File Offset: 0x004B430C
		public static void smethod_1()
		{
			try
			{
				Class2561.class2559_0.method_0();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200420", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				Class2561.smethod_2(ex);
			}
		}

		// Token: 0x06008BFD RID: 35837 RVA: 0x004B6174 File Offset: 0x004B4374
		public static void smethod_2(Exception exception_0)
		{
			DarkMessageBox.smethod_2("There has been a serious error with sound. The error description is: " + exception_0.Message + " . Sound effects and music will now be disabled. Please contact the Command development team with this information to help them troubleshoot this issue.", "Critical sound problem", Enum11.const_0);
			Class570.class280_0.method_9(false);
			Class570.class280_0.method_11(false);
			Class570.smethod_2(Class2566.dictionary_0, Client.list_1);
		}

		// Token: 0x04004BDC RID: 19420
		public static Class2559 class2559_0;

		// Token: 0x04004BDD RID: 19421
		public static SoundHandler_Effects soundHandler_Effects_0;
	}
}
