using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic.CompilerServices;
using ns6;

namespace ns4
{
	// Token: 0x02000E22 RID: 3618
	[DesignerGenerated]
	internal sealed partial class FlightPlanEditorTargetsPreliminary : Form4
	{
		// Token: 0x06006BA8 RID: 27560 RVA: 0x00043EC6 File Offset: 0x000420C6
		public FlightPlanEditorTargetsPreliminary()
		{
			this.InitializeComponent();
		}

		// Token: 0x06006BAB RID: 27563 RVA: 0x00043ED4 File Offset: 0x000420D4
		[CompilerGenerated]
		internal Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06006BAC RID: 27564 RVA: 0x00043EDC File Offset: 0x000420DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_3)
		{
			this.label_0 = label_3;
		}

		// Token: 0x06006BAD RID: 27565 RVA: 0x00043EE5 File Offset: 0x000420E5
		[CompilerGenerated]
		internal ComboBox vmethod_2()
		{
			return this.comboBox_0;
		}

		// Token: 0x06006BAE RID: 27566 RVA: 0x00043EED File Offset: 0x000420ED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ComboBox comboBox_2)
		{
			this.comboBox_0 = comboBox_2;
		}

		// Token: 0x06006BAF RID: 27567 RVA: 0x00043EF6 File Offset: 0x000420F6
		[CompilerGenerated]
		internal ComboBox vmethod_4()
		{
			return this.comboBox_1;
		}

		// Token: 0x06006BB0 RID: 27568 RVA: 0x00043EFE File Offset: 0x000420FE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ComboBox comboBox_2)
		{
			this.comboBox_1 = comboBox_2;
		}

		// Token: 0x06006BB1 RID: 27569 RVA: 0x00043F07 File Offset: 0x00042107
		[CompilerGenerated]
		internal Label vmethod_6()
		{
			return this.label_1;
		}

		// Token: 0x06006BB2 RID: 27570 RVA: 0x00043F0F File Offset: 0x0004210F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Label label_3)
		{
			this.label_1 = label_3;
		}

		// Token: 0x06006BB3 RID: 27571 RVA: 0x00043F18 File Offset: 0x00042118
		[CompilerGenerated]
		internal Label vmethod_8()
		{
			return this.label_2;
		}

		// Token: 0x06006BB4 RID: 27572 RVA: 0x00043F20 File Offset: 0x00042120
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Label label_3)
		{
			this.label_2 = label_3;
		}

		// Token: 0x06006BB5 RID: 27573 RVA: 0x00043F29 File Offset: 0x00042129
		[CompilerGenerated]
		internal TextBox vmethod_10()
		{
			return this.textBox_0;
		}

		// Token: 0x06006BB6 RID: 27574 RVA: 0x00043F31 File Offset: 0x00042131
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(TextBox textBox_1)
		{
			this.textBox_0 = textBox_1;
		}

		// Token: 0x06006BB7 RID: 27575 RVA: 0x00043F3A File Offset: 0x0004213A
		[CompilerGenerated]
		internal Button vmethod_12()
		{
			return this.button_0;
		}

		// Token: 0x06006BB8 RID: 27576 RVA: 0x00043F42 File Offset: 0x00042142
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Button button_1)
		{
			this.button_0 = button_1;
		}

		// Token: 0x06006BB9 RID: 27577 RVA: 0x00043F4B File Offset: 0x0004214B
		[CompilerGenerated]
		internal UnitFilter vmethod_14()
		{
			return this.unitFilter_0;
		}

		// Token: 0x06006BBA RID: 27578 RVA: 0x00043F53 File Offset: 0x00042153
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(UnitFilter unitFilter_1)
		{
			this.unitFilter_0 = unitFilter_1;
		}

		// Token: 0x04003D7C RID: 15740
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Label label_0;

		// Token: 0x04003D7D RID: 15741
		[CompilerGenerated]
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox comboBox_0;

		// Token: 0x04003D7E RID: 15742
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_Strike_MinimumContactStanceToTrigger")]
		private ComboBox comboBox_1;

		// Token: 0x04003D7F RID: 15743
		[CompilerGenerated]
		[AccessedThroughProperty("Label7")]
		private Label label_1;

		// Token: 0x04003D80 RID: 15744
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04003D81 RID: 15745
		[AccessedThroughProperty("TextBox1")]
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04003D82 RID: 15746
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04003D83 RID: 15747
		[AccessedThroughProperty("UnitFilter_UnitDestroyed")]
		[CompilerGenerated]
		private UnitFilter unitFilter_0;
	}
}
