using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ns3
{
	// Token: 0x020000A7 RID: 167
	internal sealed class Class103
	{
		// Token: 0x06000352 RID: 850
		[DllImport("user32.dll")]
		internal static extern IntPtr WindowFromPoint(Point point_0);

		// Token: 0x06000353 RID: 851
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		internal static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);
	}
}
