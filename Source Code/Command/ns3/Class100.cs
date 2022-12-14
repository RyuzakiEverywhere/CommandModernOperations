using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns3
{
	// Token: 0x020000A4 RID: 164
	internal sealed class Class100 : IMessageFilter
	{
		// Token: 0x06000344 RID: 836 RVA: 0x00061240 File Offset: 0x0005F440
		public bool PreFilterMessage(ref Message m)
		{
			int msg = m.Msg;
			if (msg != 522)
			{
				if (msg != 526)
				{
					return false;
				}
			}
			IntPtr intPtr = Class103.WindowFromPoint(new Point((int)m.LParam));
			if (intPtr == m.HWnd)
			{
				return false;
			}
			Class103.SendMessage(intPtr, (uint)m.Msg, m.WParam, m.LParam);
			return true;
		}
	}
}
