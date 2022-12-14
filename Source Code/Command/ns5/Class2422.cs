using System;
using System.Windows.Forms;

namespace ns5
{
	// Token: 0x02000D78 RID: 3448
	internal sealed class Class2422 : DataGridView
	{
		// Token: 0x06005AB9 RID: 23225 RVA: 0x0003A83D File Offset: 0x00038A3D
		public Class2422()
		{
			this.DoubleBuffered = true;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}
	}
}
