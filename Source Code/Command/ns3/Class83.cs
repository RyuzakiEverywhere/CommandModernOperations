using System;
using System.Runtime.InteropServices;

namespace ns3
{
	// Token: 0x02000088 RID: 136
	internal static class Class83
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x00060668 File Offset: 0x0005E868
		public static void smethod_0(Struct15 struct15_0)
		{
			Class85.Struct16 @struct = Class83.smethod_2();
			@struct.uint_4 = (uint)struct15_0.method_1();
			@struct.uint_5 = (uint)struct15_0.method_3();
			@struct.uint_1 = (uint)struct15_0.method_5();
			@struct.uint_3 = (uint)struct15_0.method_7();
			@struct.uint_7 = (uint)struct15_0.method_9();
			Enum8 @enum = (Enum8)Class85.ChangeDisplaySettings(ref @struct, 0U);
			string text = null;
			switch (@enum)
			{
			case Enum8.const_0:
				text = "The settings change was unsuccessful because system is DualView capable.";
				break;
			case Enum8.const_1:
				text = "An invalid parameter was passed in. This can include an invalid flag or combination of flags.";
				break;
			case Enum8.const_2:
				text = "An invalid set of flags was passed in.";
				break;
			case Enum8.const_3:
				text = "Unable to write settings to the registry.";
				break;
			case Enum8.const_4:
				text = "The graphics mode is not supported.";
				break;
			case Enum8.const_5:
				text = "The display driver failed the specified graphics mode.";
				break;
			case Enum8.const_7:
				text = "The computer must be restarted in order for the graphics mode to work.";
				break;
			}
			if (text != null)
			{
				throw new InvalidOperationException(text);
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00060738 File Offset: 0x0005E938
		private static Struct15 smethod_1(int int_0, Class85.Struct16 struct16_0)
		{
			Struct15 result = default(Struct15);
			result.method_0(int_0);
			result.method_2((int)struct16_0.uint_4);
			result.method_4((int)struct16_0.uint_5);
			result.method_6((Enum7)struct16_0.uint_1);
			result.method_8((int)struct16_0.uint_3);
			result.method_10((int)struct16_0.uint_7);
			return result;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00060798 File Offset: 0x0005E998
		private static Class85.Struct16 smethod_2()
		{
			Class85.Struct16 result = default(Class85.Struct16);
			result.method_0();
			if (!Class85.EnumDisplaySettings(null, -1, ref result))
			{
				throw new InvalidOperationException(Class83.smethod_3());
			}
			return result;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000607CC File Offset: 0x0005E9CC
		private static string smethod_3()
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			string result;
			if (Class85.FormatMessage(4864U, 2048U, (uint)lastWin32Error, 0U, out result, 0U, 0U) == 0U)
			{
				return "Fatal error.";
			}
			return result;
		}
	}
}
