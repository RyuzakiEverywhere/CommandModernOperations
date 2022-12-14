using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace ns4
{
	// Token: 0x02000E31 RID: 3633
	[DesignerGenerated]
	internal sealed partial class RealismDialog : Form
	{
		// Token: 0x06006CF2 RID: 27890 RVA: 0x0004484C File Offset: 0x00042A4C
		public RealismDialog()
		{
			this.InitializeComponent();
		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x0004485A File Offset: 0x00042A5A
		[CompilerGenerated]
		internal ElementHost vmethod_0()
		{
			return this.elementHost_0;
		}

		// Token: 0x06006CF6 RID: 27894 RVA: 0x00044862 File Offset: 0x00042A62
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ElementHost elementHost_1)
		{
			this.elementHost_0 = elementHost_1;
		}

		// Token: 0x06006CF7 RID: 27895 RVA: 0x0004486B File Offset: 0x00042A6B
		public void method_0(Scenario scenario_0)
		{
			((RealismDialogControl)this.vmethod_0().Child).DataContext = new RealismDialogViewModel(this, scenario_0);
		}

		// Token: 0x04003E21 RID: 15905
		[AccessedThroughProperty("ElementHost1")]
		[CompilerGenerated]
		private ElementHost elementHost_0;
	}
}
