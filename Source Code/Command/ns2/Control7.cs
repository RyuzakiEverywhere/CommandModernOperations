using System;
using System.ComponentModel;
using System.Windows.Forms;
using ns8;

namespace ns2
{
	// Token: 0x020000DF RID: 223
	internal class Control7 : UserControl
	{
		// Token: 0x060005B8 RID: 1464 RVA: 0x000062C1 File Offset: 0x000044C1
		public Control7()
		{
			this.method_0();
			this.BackColor = Class129.smethod_0();
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000062DA File Offset: 0x000044DA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000062F9 File Offset: 0x000044F9
		private void method_0()
		{
			this.icontainer_0 = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x040003F2 RID: 1010
		private IContainer icontainer_0;
	}
}
