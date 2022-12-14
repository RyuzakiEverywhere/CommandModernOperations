using System;
using System.Drawing;
using System.Windows.Forms;
using ns8;

namespace ns2
{
	// Token: 0x020000CA RID: 202
	internal sealed class Class118 : MaskedTextBox
	{
		// Token: 0x0600047A RID: 1146 RVA: 0x00005953 File Offset: 0x00003B53
		public Class118()
		{
			this.BackColor = Color.FromArgb(31, 31, 31);
			this.ForeColor = Class129.smethod_11();
			base.Padding = new Padding(2, 2, 2, 2);
			base.BorderStyle = BorderStyle.FixedSingle;
		}
	}
}
