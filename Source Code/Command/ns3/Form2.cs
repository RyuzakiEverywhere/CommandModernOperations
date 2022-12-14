using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns3
{
	// Token: 0x020000AF RID: 175
	internal sealed partial class Form2 : Form
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000382 RID: 898 RVA: 0x000041ED File Offset: 0x000023ED
		protected override bool ShowWithoutActivation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000050EF File Offset: 0x000032EF
		public Form2(Color backColor, double opacity = 0.6)
		{
			base.StartPosition = FormStartPosition.Manual;
			base.FormBorderStyle = FormBorderStyle.None;
			base.Size = new Size(1, 1);
			base.ShowInTaskbar = false;
			base.AllowTransparency = true;
			base.Opacity = opacity;
			this.BackColor = backColor;
		}
	}
}
