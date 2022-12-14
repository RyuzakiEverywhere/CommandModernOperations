using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns2;

namespace ns3
{
	// Token: 0x020000AA RID: 170
	internal partial class DarkDialog : Form0
	{
		// Token: 0x06000368 RID: 872 RVA: 0x00004FB4 File Offset: 0x000031B4
		public void method_1(Enum11 enum11_1)
		{
			if (this.enum11_0 == enum11_1)
			{
				return;
			}
			this.enum11_0 = enum11_1;
			this.method_6();
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00004FCD File Offset: 0x000031CD
		[CompilerGenerated]
		public int method_2()
		{
			return this.int_0;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00004FD5 File Offset: 0x000031D5
		[CompilerGenerated]
		private void method_3(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00004FDE File Offset: 0x000031DE
		private void method_4(IButtonControl ibuttonControl_0)
		{
			base.AcceptButton = ibuttonControl_0;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00004FE7 File Offset: 0x000031E7
		private void method_5(IButtonControl ibuttonControl_0)
		{
			base.CancelButton = ibuttonControl_0;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00062318 File Offset: 0x00060518
		public DarkDialog()
		{
			this.InitializeComponent();
			this.list_0 = new List<Class111>
			{
				this.btnAbort,
				this.btnRetry,
				this.btnIgnore,
				this.btnOk,
				this.btnCancel,
				this.btnClose,
				this.btnYes,
				this.btnNo
			};
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00004FF0 File Offset: 0x000031F0
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.method_6();
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0006239C File Offset: 0x0006059C
		private void method_6()
		{
			foreach (Class111 @class in this.list_0)
			{
				@class.Visible = false;
			}
			switch (this.enum11_0)
			{
			case Enum11.const_0:
				this.method_7(this.btnOk, true);
				this.method_4(this.btnOk);
				break;
			case Enum11.const_1:
				this.method_7(this.btnClose, true);
				this.method_4(this.btnClose);
				this.method_5(this.btnClose);
				break;
			case Enum11.const_2:
				this.method_7(this.btnOk, false);
				this.method_7(this.btnCancel, true);
				this.method_4(this.btnOk);
				this.method_5(this.btnCancel);
				break;
			case Enum11.const_3:
				this.method_7(this.btnYes, false);
				this.method_7(this.btnNo, true);
				this.method_4(this.btnYes);
				this.method_5(this.btnNo);
				break;
			case Enum11.const_4:
				this.method_7(this.btnYes, false);
				this.method_7(this.btnNo, false);
				this.method_7(this.btnCancel, true);
				this.method_4(this.btnYes);
				this.method_5(this.btnCancel);
				break;
			case Enum11.const_5:
				this.method_7(this.btnAbort, false);
				this.method_7(this.btnRetry, false);
				this.method_7(this.btnIgnore, true);
				this.method_4(this.btnAbort);
				this.method_5(this.btnIgnore);
				break;
			case Enum11.const_6:
				this.method_7(this.btnRetry, false);
				this.method_7(this.btnCancel, true);
				this.method_4(this.btnRetry);
				this.method_5(this.btnCancel);
				break;
			}
			this.method_8();
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00004FFF File Offset: 0x000031FF
		private void method_7(Class111 button, bool isLast = false)
		{
			button.SendToBack();
			if (!isLast)
			{
				button.Margin = new Padding(0, 0, 10, 0);
			}
			button.Visible = true;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0006258C File Offset: 0x0006078C
		private void method_8()
		{
			int num = this.flowInner.Padding.Horizontal;
			foreach (Class111 @class in this.list_0)
			{
				if (@class.Visible)
				{
					num += @class.Width + @class.Margin.Right;
				}
			}
			this.flowInner.Width = num;
			this.method_3(num);
		}

		// Token: 0x040002C1 RID: 705
		private Enum11 enum11_0;

		// Token: 0x040002C2 RID: 706
		private List<Class111> list_0;

		// Token: 0x040002CB RID: 715
		[CompilerGenerated]
		private int int_0;
	}
}
