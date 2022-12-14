using System;
using System.Drawing;
using System.Windows.Forms;
using ns3;

namespace ns2
{
	// Token: 0x020000D5 RID: 213
	internal sealed class Class125 : ToolStrip
	{
		// Token: 0x060004C8 RID: 1224 RVA: 0x00005CC1 File Offset: 0x00003EC1
		public Class125()
		{
			base.Renderer = new Class105();
			base.Padding = new Padding(5, 0, 1, 0);
			this.AutoSize = false;
			base.Size = new Size(1, 28);
		}
	}
}
