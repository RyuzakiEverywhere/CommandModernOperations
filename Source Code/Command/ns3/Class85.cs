using System;
using System.Runtime.InteropServices;

namespace ns3
{
	// Token: 0x0200008D RID: 141
	internal static class Class85
	{
		// Token: 0x060002E6 RID: 742
		[DllImport("User32.dll", BestFitMapping = false, SetLastError = true, ThrowOnUnmappableChar = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumDisplaySettings([MarshalAs(UnmanagedType.LPTStr)] string lpszDeviceName, [MarshalAs(UnmanagedType.U4)] int iModeNum, [In] [Out] ref Class85.Struct16 lpDevMode);

		// Token: 0x060002E7 RID: 743
		[DllImport("User32.dll", BestFitMapping = false, SetLastError = true, ThrowOnUnmappableChar = true)]
		[return: MarshalAs(UnmanagedType.I4)]
		public static extern int ChangeDisplaySettings([In] [Out] ref Class85.Struct16 lpDevMode, [MarshalAs(UnmanagedType.U4)] uint dwflags);

		// Token: 0x060002E8 RID: 744
		[DllImport("kernel32.dll", BestFitMapping = false, SetLastError = true, ThrowOnUnmappableChar = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern uint FormatMessage([MarshalAs(UnmanagedType.U4)] uint dwFlags, [MarshalAs(UnmanagedType.U4)] uint lpSource, [MarshalAs(UnmanagedType.U4)] uint dwMessageId, [MarshalAs(UnmanagedType.U4)] uint dwLanguageId, [MarshalAs(UnmanagedType.LPTStr)] out string lpBuffer, [MarshalAs(UnmanagedType.U4)] uint nSize, [MarshalAs(UnmanagedType.U4)] uint Arguments);

		// Token: 0x0200008E RID: 142
		internal struct Struct16
		{
			// Token: 0x060002E9 RID: 745 RVA: 0x00004983 File Offset: 0x00002B83
			public void method_0()
			{
				this.string_0 = new string(new char[32]);
				this.string_1 = new string(new char[32]);
				this.ushort_2 = (ushort)Marshal.SizeOf(this);
			}

			// Token: 0x04000245 RID: 581
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string string_0;

			// Token: 0x04000246 RID: 582
			[MarshalAs(UnmanagedType.U2)]
			public ushort ushort_0;

			// Token: 0x04000247 RID: 583
			[MarshalAs(UnmanagedType.U2)]
			public ushort ushort_1;

			// Token: 0x04000248 RID: 584
			[MarshalAs(UnmanagedType.U2)]
			public ushort ushort_2;

			// Token: 0x04000249 RID: 585
			[MarshalAs(UnmanagedType.U2)]
			public ushort ushort_3;

			// Token: 0x0400024A RID: 586
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_0;

			// Token: 0x0400024B RID: 587
			public Class85.Struct17 struct17_0;

			// Token: 0x0400024C RID: 588
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_1;

			// Token: 0x0400024D RID: 589
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_2;

			// Token: 0x0400024E RID: 590
			[MarshalAs(UnmanagedType.I2)]
			public short short_0;

			// Token: 0x0400024F RID: 591
			[MarshalAs(UnmanagedType.I2)]
			public short short_1;

			// Token: 0x04000250 RID: 592
			[MarshalAs(UnmanagedType.I2)]
			public short short_2;

			// Token: 0x04000251 RID: 593
			[MarshalAs(UnmanagedType.I2)]
			public short short_3;

			// Token: 0x04000252 RID: 594
			[MarshalAs(UnmanagedType.I2)]
			public short short_4;

			// Token: 0x04000253 RID: 595
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string string_1;

			// Token: 0x04000254 RID: 596
			[MarshalAs(UnmanagedType.U2)]
			public ushort ushort_4;

			// Token: 0x04000255 RID: 597
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_3;

			// Token: 0x04000256 RID: 598
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_4;

			// Token: 0x04000257 RID: 599
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_5;

			// Token: 0x04000258 RID: 600
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_6;

			// Token: 0x04000259 RID: 601
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_7;

			// Token: 0x0400025A RID: 602
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_8;

			// Token: 0x0400025B RID: 603
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_9;

			// Token: 0x0400025C RID: 604
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_10;

			// Token: 0x0400025D RID: 605
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_11;

			// Token: 0x0400025E RID: 606
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_12;

			// Token: 0x0400025F RID: 607
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_13;

			// Token: 0x04000260 RID: 608
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_14;

			// Token: 0x04000261 RID: 609
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_15;
		}

		// Token: 0x0200008F RID: 143
		internal struct Struct17
		{
			// Token: 0x04000262 RID: 610
			public int int_0;

			// Token: 0x04000263 RID: 611
			public int int_1;
		}
	}
}
