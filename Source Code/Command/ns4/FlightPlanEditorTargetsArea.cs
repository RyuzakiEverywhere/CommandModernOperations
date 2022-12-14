using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns6;

namespace ns4
{
	// Token: 0x02000E21 RID: 3617
	[DesignerGenerated]
	internal sealed partial class FlightPlanEditorTargetsArea : Form4
	{
		// Token: 0x06006BA3 RID: 27555 RVA: 0x00043EA7 File Offset: 0x000420A7
		public FlightPlanEditorTargetsArea()
		{
			this.InitializeComponent();
		}

		// Token: 0x06006BA6 RID: 27558 RVA: 0x00043EB5 File Offset: 0x000420B5
		[CompilerGenerated]
		internal AreaEditor vmethod_0()
		{
			return this.areaEditor_0;
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x00043EBD File Offset: 0x000420BD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(AreaEditor areaEditor_1)
		{
			this.areaEditor_0 = areaEditor_1;
		}

		// Token: 0x04003D7A RID: 15738
		[CompilerGenerated]
		[AccessedThroughProperty("AreaEditor_PatrolArea")]
		private AreaEditor areaEditor_0;
	}
}
