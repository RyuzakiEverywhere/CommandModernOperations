using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000047 RID: 71
	internal sealed class Class44 : DataGridViewTextBoxColumn
	{
		// Token: 0x060000EF RID: 239 RVA: 0x000032E0 File Offset: 0x000014E0
		public Class44()
		{
			this.CellTemplate = new Class43();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000032F3 File Offset: 0x000014F3
		public override object Clone()
		{
			Class44 @class = (Class44)base.Clone();
			@class.image_0 = this.image_0;
			return @class;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000330C File Offset: 0x0000150C
		public void method_0(Image image_1)
		{
			this.image_0 = image_1;
		}

		// Token: 0x040000A9 RID: 169
		internal Image image_0;
	}
}
