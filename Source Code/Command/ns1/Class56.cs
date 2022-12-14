using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ns1
{
	// Token: 0x0200005A RID: 90
	internal sealed class Class56
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00003870 File Offset: 0x00001A70
		public static bool smethod_0(Guid guid_0)
		{
			if (Class56.Class57.smethod_3() == guid_0)
			{
				return true;
			}
			Class56.Class57.smethod_2(guid_0);
			return Class56.Class57.smethod_3() == guid_0;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00057D94 File Offset: 0x00055F94
		public static Dictionary<Guid, Class55> smethod_1()
		{
			uint num = 0U;
			Dictionary<Guid, Class55> dictionary = new Dictionary<Guid, Class55>(3);
			for (;;)
			{
				try
				{
					Guid guid = Class56.Class57.smethod_0(num);
					if (!(guid != Guid.Empty))
					{
						break;
					}
					string string_ = Class56.Class57.smethod_1(guid);
					dictionary.Add(guid, new Class55
					{
						guid_0 = guid,
						string_0 = string_
					});
				}
				finally
				{
					num += 1U;
				}
			}
			return dictionary;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00003893 File Offset: 0x00001A93
		public static Guid smethod_2()
		{
			return Class56.Class57.smethod_3();
		}

		// Token: 0x0200005B RID: 91
		private sealed class Class57
		{
			// Token: 0x06000187 RID: 391
			[DllImport("PowrProf.dll", CharSet = CharSet.Auto, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.U4)]
			private static extern uint PowerEnumerate(IntPtr RootPowerKey, IntPtr SchemeGuid, IntPtr SubGroupOfPowerSettingsGuid, Class56.Class57.Enum1 AccessFlags, uint Index, IntPtr Buffer, ref uint BufferSize);

			// Token: 0x06000188 RID: 392
			[DllImport("PowrProf.dll", CharSet = CharSet.Auto, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.U4)]
			private static extern uint PowerReadFriendlyName(IntPtr RootPowerKey, ref Guid SchemeGuid, IntPtr SubGroupOfPowerSettingsGuid, IntPtr PowerSettingGuid, IntPtr Buffer, ref uint BufferSize);

			// Token: 0x06000189 RID: 393
			[DllImport("PowrProf.dll", CharSet = CharSet.Auto, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.U4)]
			private static extern uint PowerSetActiveScheme(IntPtr UserRootPowerKey, ref Guid SchemeGuid);

			// Token: 0x0600018A RID: 394
			[DllImport("PowrProf.dll", CharSet = CharSet.Auto, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.U4)]
			private static extern uint PowerGetActiveScheme(IntPtr UserRootPowerKey, ref IntPtr ActivePolicyGuid);

			// Token: 0x0600018B RID: 395 RVA: 0x00057E00 File Offset: 0x00056000
			public static Guid smethod_0(uint uint_0)
			{
				uint cb = 16U;
				Guid result = Guid.Empty;
				IntPtr intPtr = intPtr = Marshal.AllocHGlobal(16);
				try
				{
					uint num = Class56.Class57.PowerEnumerate(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, Class56.Class57.Enum1.flag_2, uint_0, intPtr, ref cb);
					if (num == 234U)
					{
						Marshal.FreeHGlobal(intPtr);
						intPtr = Marshal.AllocHGlobal((int)cb);
						num = Class56.Class57.PowerEnumerate(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, Class56.Class57.Enum1.flag_2, uint_0, intPtr, ref cb);
					}
					if (num == 0U)
					{
						result = (Guid)Marshal.PtrToStructure(intPtr, typeof(Guid));
					}
					else if (num != 259U)
					{
						throw new Win32Exception(Marshal.GetLastWin32Error());
					}
				}
				finally
				{
					Marshal.FreeHGlobal(intPtr);
				}
				return result;
			}

			// Token: 0x0600018C RID: 396 RVA: 0x00057EB8 File Offset: 0x000560B8
			public static string smethod_1(Guid guid_0)
			{
				uint cb = 255U;
				IntPtr intPtr = Marshal.AllocHGlobal(255);
				uint num = Class56.Class57.PowerReadFriendlyName(IntPtr.Zero, ref guid_0, IntPtr.Zero, IntPtr.Zero, intPtr, ref cb);
				if (num == 234U)
				{
					Marshal.FreeHGlobal(intPtr);
					intPtr = Marshal.AllocHGlobal((int)cb);
					num = Class56.Class57.PowerReadFriendlyName(IntPtr.Zero, ref guid_0, IntPtr.Zero, IntPtr.Zero, intPtr, ref cb);
				}
				string result;
				if (num == 0U)
				{
					result = Marshal.PtrToStringUni(intPtr);
				}
				else
				{
					if (num != 2U)
					{
						throw new Win32Exception(Marshal.GetLastWin32Error());
					}
					result = null;
				}
				Marshal.FreeHGlobal(intPtr);
				return result;
			}

			// Token: 0x0600018D RID: 397 RVA: 0x0000389A File Offset: 0x00001A9A
			public static bool smethod_2(Guid guid_0)
			{
				return Class56.Class57.PowerSetActiveScheme(IntPtr.Zero, ref guid_0) == 0U;
			}

			// Token: 0x0600018E RID: 398 RVA: 0x00057F4C File Offset: 0x0005614C
			public static Guid smethod_3()
			{
				IntPtr intPtr = Marshal.AllocHGlobal(16);
				Guid result = Guid.Empty;
				if (Class56.Class57.PowerGetActiveScheme(IntPtr.Zero, ref intPtr) == 0U)
				{
					result = (Guid)Marshal.PtrToStructure(intPtr, typeof(Guid));
				}
				Marshal.FreeHGlobal(intPtr);
				return result;
			}

			// Token: 0x0200005C RID: 92
			[Flags]
			private enum Enum1
			{
				// Token: 0x040000DC RID: 220
				flag_0 = 0,
				// Token: 0x040000DD RID: 221
				flag_1 = 1,
				// Token: 0x040000DE RID: 222
				flag_2 = 16,
				// Token: 0x040000DF RID: 223
				flag_3 = 19,
				// Token: 0x040000E0 RID: 224
				flag_4 = 20
			}
		}
	}
}
