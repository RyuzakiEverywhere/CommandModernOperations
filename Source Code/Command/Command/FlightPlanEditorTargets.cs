using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AdvancedDataGridView;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns12;
using ns13;
using ns4;
using ns5;
using ns6;

namespace Command
{
	// Token: 0x02000E1C RID: 3612
	[DesignerGenerated]
	public sealed partial class FlightPlanEditorTargets : Form4
	{
		// Token: 0x06006B1C RID: 27420 RVA: 0x003A66E8 File Offset: 0x003A48E8
		public FlightPlanEditorTargets()
		{
			base.FormClosing += this.FlightPlanEditorTargets_FormClosing;
			base.VisibleChanged += this.FlightPlanEditorTargets_VisibleChanged;
			base.KeyDown += this.FlightPlanEditorTargets_KeyDown;
			this.int_0 = 0;
			this.list_1 = new List<string>();
			this.list_2 = new List<string>();
			this.list_3 = new List<string>();
			this.InitializeComponent();
		}

		// Token: 0x06006B1F RID: 27423 RVA: 0x00043B5F File Offset: 0x00041D5F
		[CompilerGenerated]
		internal GroupBox vmethod_0()
		{
			return this.groupBox_0;
		}

		// Token: 0x06006B20 RID: 27424 RVA: 0x00043B67 File Offset: 0x00041D67
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(GroupBox groupBox_2)
		{
			this.groupBox_0 = groupBox_2;
		}

		// Token: 0x06006B21 RID: 27425 RVA: 0x00043B70 File Offset: 0x00041D70
		[CompilerGenerated]
		internal GroupBox vmethod_2()
		{
			return this.groupBox_1;
		}

		// Token: 0x06006B22 RID: 27426 RVA: 0x00043B78 File Offset: 0x00041D78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(GroupBox groupBox_2)
		{
			this.groupBox_1 = groupBox_2;
		}

		// Token: 0x06006B23 RID: 27427 RVA: 0x00043B81 File Offset: 0x00041D81
		[CompilerGenerated]
		private TreeGridView vmethod_4()
		{
			return this.treeGridView_0;
		}

		// Token: 0x06006B24 RID: 27428 RVA: 0x003A7B74 File Offset: 0x003A5D74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_5(TreeGridView treeGridView_2)
		{
			Delegate1 delegate1_ = new Delegate1(this.method_14);
			Delegate3 delegate3_ = new Delegate3(this.method_16);
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_25);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_27);
			EventHandler value3 = new EventHandler(this.method_30);
			TreeGridView treeGridView = this.treeGridView_0;
			if (treeGridView != null)
			{
				treeGridView.method_12(delegate1_);
				treeGridView.method_16(delegate3_);
				treeGridView.CellClick -= value;
				treeGridView.CellValueChanged -= value2;
				treeGridView.CurrentCellDirtyStateChanged -= value3;
			}
			this.treeGridView_0 = treeGridView_2;
			treeGridView = this.treeGridView_0;
			if (treeGridView != null)
			{
				treeGridView.method_11(delegate1_);
				treeGridView.method_15(delegate3_);
				treeGridView.CellClick += value;
				treeGridView.CellValueChanged += value2;
				treeGridView.CurrentCellDirtyStateChanged += value3;
			}
		}

		// Token: 0x06006B25 RID: 27429 RVA: 0x00043B89 File Offset: 0x00041D89
		[CompilerGenerated]
		internal Button vmethod_6()
		{
			return this.button_0;
		}

		// Token: 0x06006B26 RID: 27430 RVA: 0x00043B91 File Offset: 0x00041D91
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_14)
		{
			this.button_0 = button_14;
		}

		// Token: 0x06006B27 RID: 27431 RVA: 0x00043B9A File Offset: 0x00041D9A
		[CompilerGenerated]
		internal ComboBox vmethod_8()
		{
			return this.comboBox_0;
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x003A7C34 File Offset: 0x003A5E34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ComboBox comboBox_1)
		{
			EventHandler value = new EventHandler(this.method_6);
			ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_1;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06006B29 RID: 27433 RVA: 0x00043BA2 File Offset: 0x00041DA2
		[CompilerGenerated]
		internal Label vmethod_10()
		{
			return this.label_0;
		}

		// Token: 0x06006B2A RID: 27434 RVA: 0x00043BAA File Offset: 0x00041DAA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06006B2B RID: 27435 RVA: 0x00043BB3 File Offset: 0x00041DB3
		[CompilerGenerated]
		private TreeGridView vmethod_12()
		{
			return this.treeGridView_1;
		}

		// Token: 0x06006B2C RID: 27436 RVA: 0x003A7C78 File Offset: 0x003A5E78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_13(TreeGridView treeGridView_2)
		{
			Delegate1 delegate1_ = new Delegate1(this.method_13);
			Delegate3 delegate3_ = new Delegate3(this.method_15);
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_24);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_26);
			EventHandler value3 = new EventHandler(this.method_29);
			TreeGridView treeGridView = this.treeGridView_1;
			if (treeGridView != null)
			{
				treeGridView.method_12(delegate1_);
				treeGridView.method_16(delegate3_);
				treeGridView.CellClick -= value;
				treeGridView.CellValueChanged -= value2;
				treeGridView.CurrentCellDirtyStateChanged -= value3;
			}
			this.treeGridView_1 = treeGridView_2;
			treeGridView = this.treeGridView_1;
			if (treeGridView != null)
			{
				treeGridView.method_11(delegate1_);
				treeGridView.method_15(delegate3_);
				treeGridView.CellClick += value;
				treeGridView.CellValueChanged += value2;
				treeGridView.CurrentCellDirtyStateChanged += value3;
			}
		}

		// Token: 0x06006B2D RID: 27437 RVA: 0x00043BBB File Offset: 0x00041DBB
		[CompilerGenerated]
		internal Button vmethod_14()
		{
			return this.button_1;
		}

		// Token: 0x06006B2E RID: 27438 RVA: 0x003A7D38 File Offset: 0x003A5F38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Button button_14)
		{
			EventHandler value = new EventHandler(this.method_33);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_14;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006B2F RID: 27439 RVA: 0x00043BC3 File Offset: 0x00041DC3
		[CompilerGenerated]
		internal Button vmethod_16()
		{
			return this.button_2;
		}

		// Token: 0x06006B30 RID: 27440 RVA: 0x00043BCB File Offset: 0x00041DCB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Button button_14)
		{
			this.button_2 = button_14;
		}

		// Token: 0x06006B31 RID: 27441 RVA: 0x00043BD4 File Offset: 0x00041DD4
		[CompilerGenerated]
		internal Button vmethod_18()
		{
			return this.button_3;
		}

		// Token: 0x06006B32 RID: 27442 RVA: 0x00043BDC File Offset: 0x00041DDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Button button_14)
		{
			this.button_3 = button_14;
		}

		// Token: 0x06006B33 RID: 27443 RVA: 0x00043BE5 File Offset: 0x00041DE5
		[CompilerGenerated]
		internal Button vmethod_20()
		{
			return this.button_4;
		}

		// Token: 0x06006B34 RID: 27444 RVA: 0x003A7D7C File Offset: 0x003A5F7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Button button_14)
		{
			EventHandler value = new EventHandler(this.method_32);
			Button button = this.button_4;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_4 = button_14;
			button = this.button_4;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006B35 RID: 27445 RVA: 0x00043BED File Offset: 0x00041DED
		[CompilerGenerated]
		internal Button vmethod_22()
		{
			return this.button_5;
		}

		// Token: 0x06006B36 RID: 27446 RVA: 0x00043BF5 File Offset: 0x00041DF5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Button button_14)
		{
			this.button_5 = button_14;
		}

		// Token: 0x06006B37 RID: 27447 RVA: 0x00043BFE File Offset: 0x00041DFE
		[CompilerGenerated]
		internal Button vmethod_24()
		{
			return this.button_6;
		}

		// Token: 0x06006B38 RID: 27448 RVA: 0x003A7DC0 File Offset: 0x003A5FC0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Button button_14)
		{
			EventHandler value = new EventHandler(this.method_34);
			Button button = this.button_6;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_6 = button_14;
			button = this.button_6;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006B39 RID: 27449 RVA: 0x00043C06 File Offset: 0x00041E06
		[CompilerGenerated]
		internal Button vmethod_26()
		{
			return this.button_7;
		}

		// Token: 0x06006B3A RID: 27450 RVA: 0x00043C0E File Offset: 0x00041E0E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Button button_14)
		{
			this.button_7 = button_14;
		}

		// Token: 0x06006B3B RID: 27451 RVA: 0x00043C17 File Offset: 0x00041E17
		[CompilerGenerated]
		internal Button vmethod_28()
		{
			return this.button_8;
		}

		// Token: 0x06006B3C RID: 27452 RVA: 0x00043C1F File Offset: 0x00041E1F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Button button_14)
		{
			this.button_8 = button_14;
		}

		// Token: 0x06006B3D RID: 27453 RVA: 0x00043C28 File Offset: 0x00041E28
		[CompilerGenerated]
		internal Button vmethod_30()
		{
			return this.button_9;
		}

		// Token: 0x06006B3E RID: 27454 RVA: 0x00043C30 File Offset: 0x00041E30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Button button_14)
		{
			this.button_9 = button_14;
		}

		// Token: 0x06006B3F RID: 27455 RVA: 0x00043C39 File Offset: 0x00041E39
		[CompilerGenerated]
		internal Button vmethod_32()
		{
			return this.button_10;
		}

		// Token: 0x06006B40 RID: 27456 RVA: 0x00043C41 File Offset: 0x00041E41
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Button button_14)
		{
			this.button_10 = button_14;
		}

		// Token: 0x06006B41 RID: 27457 RVA: 0x00043C4A File Offset: 0x00041E4A
		[CompilerGenerated]
		internal CheckBox vmethod_34()
		{
			return this.checkBox_0;
		}

		// Token: 0x06006B42 RID: 27458 RVA: 0x00043C52 File Offset: 0x00041E52
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(CheckBox checkBox_1)
		{
			this.checkBox_0 = checkBox_1;
		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x00043C5B File Offset: 0x00041E5B
		[CompilerGenerated]
		internal Button vmethod_36()
		{
			return this.button_11;
		}

		// Token: 0x06006B44 RID: 27460 RVA: 0x003A7E04 File Offset: 0x003A6004
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Button button_14)
		{
			EventHandler value = new EventHandler(this.method_31);
			Button button = this.button_11;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_11 = button_14;
			button = this.button_11;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006B45 RID: 27461 RVA: 0x00043C63 File Offset: 0x00041E63
		[CompilerGenerated]
		internal SplitContainer vmethod_38()
		{
			return this.splitContainer_0;
		}

		// Token: 0x06006B46 RID: 27462 RVA: 0x00043C6B File Offset: 0x00041E6B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(SplitContainer splitContainer_1)
		{
			this.splitContainer_0 = splitContainer_1;
		}

		// Token: 0x06006B47 RID: 27463 RVA: 0x00043C74 File Offset: 0x00041E74
		[CompilerGenerated]
		internal Button vmethod_40()
		{
			return this.button_12;
		}

		// Token: 0x06006B48 RID: 27464 RVA: 0x003A7E48 File Offset: 0x003A6048
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Button button_14)
		{
			EventHandler value = new EventHandler(this.method_40);
			Button button = this.button_12;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_12 = button_14;
			button = this.button_12;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006B49 RID: 27465 RVA: 0x00043C7C File Offset: 0x00041E7C
		[CompilerGenerated]
		internal Class44 vmethod_42()
		{
			return this.class44_0;
		}

		// Token: 0x06006B4A RID: 27466 RVA: 0x00043C84 File Offset: 0x00041E84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(Class44 class44_2)
		{
			this.class44_0 = class44_2;
		}

		// Token: 0x06006B4B RID: 27467 RVA: 0x00043C8D File Offset: 0x00041E8D
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_44()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06006B4C RID: 27468 RVA: 0x00043C95 File Offset: 0x00041E95
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06006B4D RID: 27469 RVA: 0x00043C9E File Offset: 0x00041E9E
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_46()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06006B4E RID: 27470 RVA: 0x00043CA6 File Offset: 0x00041EA6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06006B4F RID: 27471 RVA: 0x00043CAF File Offset: 0x00041EAF
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_48()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06006B50 RID: 27472 RVA: 0x00043CB7 File Offset: 0x00041EB7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06006B51 RID: 27473 RVA: 0x00043CC0 File Offset: 0x00041EC0
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_50()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06006B52 RID: 27474 RVA: 0x00043CC8 File Offset: 0x00041EC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06006B53 RID: 27475 RVA: 0x00043CD1 File Offset: 0x00041ED1
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_52()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06006B54 RID: 27476 RVA: 0x00043CD9 File Offset: 0x00041ED9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06006B55 RID: 27477 RVA: 0x00043CE2 File Offset: 0x00041EE2
		[CompilerGenerated]
		internal Class44 vmethod_54()
		{
			return this.class44_1;
		}

		// Token: 0x06006B56 RID: 27478 RVA: 0x00043CEA File Offset: 0x00041EEA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(Class44 class44_2)
		{
			this.class44_1 = class44_2;
		}

		// Token: 0x06006B57 RID: 27479 RVA: 0x00043CF3 File Offset: 0x00041EF3
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_56()
		{
			return this.dataGridViewComboBoxColumn_0;
		}

		// Token: 0x06006B58 RID: 27480 RVA: 0x00043CFB File Offset: 0x00041EFB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.dataGridViewComboBoxColumn_0 = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x00043D04 File Offset: 0x00041F04
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_58()
		{
			return this.dataGridViewComboBoxColumn_1;
		}

		// Token: 0x06006B5A RID: 27482 RVA: 0x00043D0C File Offset: 0x00041F0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.dataGridViewComboBoxColumn_1 = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x06006B5B RID: 27483 RVA: 0x00043D15 File Offset: 0x00041F15
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_60()
		{
			return this.dataGridViewComboBoxColumn_2;
		}

		// Token: 0x06006B5C RID: 27484 RVA: 0x00043D1D File Offset: 0x00041F1D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.dataGridViewComboBoxColumn_2 = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x00043D26 File Offset: 0x00041F26
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_62()
		{
			return this.dataGridViewComboBoxColumn_3;
		}

		// Token: 0x06006B5E RID: 27486 RVA: 0x00043D2E File Offset: 0x00041F2E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.dataGridViewComboBoxColumn_3 = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x06006B5F RID: 27487 RVA: 0x00043D37 File Offset: 0x00041F37
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_64()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x06006B60 RID: 27488 RVA: 0x00043D3F File Offset: 0x00041F3F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06006B61 RID: 27489 RVA: 0x00043D48 File Offset: 0x00041F48
		[CompilerGenerated]
		internal Button vmethod_66()
		{
			return this.button_13;
		}

		// Token: 0x06006B62 RID: 27490 RVA: 0x003A7E8C File Offset: 0x003A608C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(Button button_14)
		{
			EventHandler value = new EventHandler(this.method_41);
			Button button = this.button_13;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_13 = button_14;
			button = this.button_13;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006B63 RID: 27491 RVA: 0x00042F6B File Offset: 0x0004116B
		private void FlightPlanEditorTargets_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06006B64 RID: 27492 RVA: 0x00043D50 File Offset: 0x00041F50
		private void FlightPlanEditorTargets_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				this.method_1();
				this.method_39();
			}
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06006B65 RID: 27493 RVA: 0x00043D7B File Offset: 0x00041F7B
		public void method_1()
		{
			this.string_0 = null;
			this.vmethod_12().ClearSelection();
			this.vmethod_4().ClearSelection();
			this.method_2();
		}

		// Token: 0x06006B66 RID: 27494 RVA: 0x003A7ED0 File Offset: 0x003A60D0
		internal void method_2()
		{
			try
			{
				if (Information.IsNothing(this.flight_0))
				{
					this.vmethod_8().DataSource = null;
					this.vmethod_8().Items.Clear();
					this.vmethod_8().SelectedIndex = -1;
				}
				else
				{
					DataTable dataSource = new DataTable();
					FlightPlanEditorTargets.smethod_8(ref dataSource, this.mission_0.enum88_0);
					ComboBox comboBox = this.vmethod_8();
					comboBox.DataSource = dataSource;
					comboBox.DisplayMember = "Description";
					comboBox.ValueMember = "ID";
					comboBox.DropDownWidth = 500;
					this.vmethod_8().SelectedIndex = FlightPlanEditorTargets.smethod_10((int)this.waypoint_0.enum105_0);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006B67 RID: 27495 RVA: 0x003A7FC0 File Offset: 0x003A61C0
		public void method_3(ref ActiveUnit activeUnit_0, ref Mission mission_1, bool bool_4, Waypoint waypoint_2)
		{
			FlightPlanEditorTargets.Class2466 @class = new FlightPlanEditorTargets.Class2466(@class);
			@class.waypoint_0 = waypoint_2;
			try
			{
				if (Control.ModifierKeys != Keys.Alt)
				{
					List<Contact> list = new List<Contact>();
					try
					{
						foreach (Contact contact in Client.smethod_50().method_44())
						{
							Doctrine.Enum59? @enum = mission_1.doctrine_0.method_162(Client.smethod_46(), false, false, false);
							Misc.PostureStance value;
							if (!Client.smethod_50().dictionary_4.TryGetValue(contact.string_0, out value))
							{
								value = contact.method_130(Client.smethod_50());
							}
							switch (value)
							{
							case Misc.PostureStance.Unfriendly:
							case Misc.PostureStance.Hostile:
							{
								ActiveUnit_AI activeUnit_AI = activeUnit_0.vmethod_86();
								Contact contact_ = contact;
								Mission mission = mission_1;
								Doctrine.Enum59? nullable_ = @enum;
								bool bool_5 = false;
								bool bool_6 = true;
								Misc.PostureStance? nullable_2 = new Misc.PostureStance?(value);
								string text = "";
								int num = 0;
								if (activeUnit_AI.method_39(contact_, mission, nullable_, bool_4, bool_5, bool_6, nullable_2, ref text, ref num))
								{
									if (contact.contactType_0 == Contact_Base.ContactType.Submarine)
									{
										if (!contact.method_72() && !Class442.smethod_1(contact.vmethod_28(null), contact.vmethod_30(null)))
										{
											list.Add(contact);
										}
									}
									else
									{
										Lazy<Weapon[]> lazy = new Lazy<Weapon[]>(new Func<Weapon[]>(activeUnit_0.vmethod_89().vmethod_4().ToArray));
										ActiveUnit_Weaponry activeUnit_Weaponry = activeUnit_0.vmethod_89();
										Contact theTarget = contact;
										bool checkWRA = true;
										Doctrine doctrine_ = activeUnit_0.doctrine_0;
										text = "";
										num = 0;
										if (activeUnit_Weaponry.method_6(theTarget, checkWRA, doctrine_, ref text, ref num, lazy.Value))
										{
											list.Add(contact);
										}
									}
								}
								break;
							}
							case Misc.PostureStance.Unknown:
							{
								ActiveUnit_AI activeUnit_AI2 = activeUnit_0.vmethod_86();
								Contact contact_2 = contact;
								Mission mission2 = mission_1;
								Doctrine.Enum59? nullable_3 = @enum;
								bool bool_7 = false;
								bool bool_8 = true;
								Misc.PostureStance? nullable_4 = new Misc.PostureStance?(value);
								string text = "";
								int num = 0;
								if (activeUnit_AI2.method_39(contact_2, mission2, nullable_3, bool_4, bool_7, bool_8, nullable_4, ref text, ref num) && (contact.contactType_0 != Contact_Base.ContactType.Submarine || !Class442.smethod_1(contact.vmethod_28(null), contact.vmethod_30(null))))
								{
									list.Add(contact);
								}
								break;
							}
							}
						}
					}
					finally
					{
						List<Contact>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (list.Count > 0)
					{
						IEnumerable<Contact> enumerable = Enumerable.OrderBy<Contact, double>(list, new Func<Contact, double>(@class.method_0));
						@class.waypoint_0.imethod_3(Enumerable.ElementAtOrDefault<Contact>(enumerable, 0).vmethod_30(null));
						@class.waypoint_0.imethod_1(Enumerable.ElementAtOrDefault<Contact>(enumerable, 0).vmethod_28(null));
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006B68 RID: 27496 RVA: 0x003A8284 File Offset: 0x003A6484
		public List<Contact> method_4()
		{
			List<Contact> result;
			try
			{
				Strike strike = (Strike)this.mission_0;
				new List<Unit>();
				List<Contact> list = new List<Contact>();
				if (!strike.bool_27)
				{
					Interaction.MsgBox("This mission requires pre-planned targets only!", MsgBoxStyle.OkOnly, null);
					result = null;
				}
				else if (strike.bool_27 && strike.hashSet_0.Count == 0)
				{
					result = null;
				}
				else
				{
					try
					{
						foreach (Unit unit in strike.hashSet_0)
						{
							if (unit.vmethod_7(false) != Client.smethod_50() && !Client.smethod_50().method_67(unit.vmethod_7(false)) && !unit.bool_1 && !unit.bool_0)
							{
								Contact contact = (Contact)unit;
								if ((Information.IsNothing(contact.activeUnit_0) || !Client.smethod_50().method_12().ContainsKey(contact.activeUnit_0.string_0)) && !Client.smethod_50().method_12().ContainsKey(contact.activeUnit_0.string_0) && !list.Contains(contact))
								{
									list.Add(contact);
								}
							}
						}
					}
					finally
					{
						HashSet<Unit>.Enumerator enumerator;
						enumerator.Dispose();
					}
					if (list.Count > 0)
					{
						result = list;
					}
					else
					{
						result = null;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06006B69 RID: 27497 RVA: 0x003A8438 File Offset: 0x003A6638
		public Contact method_5(Waypoint waypoint_2)
		{
			FlightPlanEditorTargets.Class2467 @class = new FlightPlanEditorTargets.Class2467(@class);
			@class.waypoint_0 = waypoint_2;
			Contact result;
			try
			{
				Strike strike = (Strike)this.mission_0;
				new List<Unit>();
				List<Contact> list = new List<Contact>();
				if (!strike.bool_27)
				{
					Interaction.MsgBox("This mission requires pre-planned targets only!", MsgBoxStyle.OkOnly, null);
					result = null;
				}
				else if (strike.bool_27 && strike.hashSet_0.Count == 0)
				{
					result = null;
				}
				else
				{
					try
					{
						foreach (Unit unit in strike.hashSet_0)
						{
							if (unit.vmethod_7(false) != Client.smethod_50() && !Client.smethod_50().method_67(unit.vmethod_7(false)) && !unit.bool_1 && !unit.bool_0)
							{
								Contact contact = (Contact)unit;
								if ((Information.IsNothing(contact.activeUnit_0) || !Client.smethod_50().method_12().ContainsKey(contact.activeUnit_0.string_0)) && !Client.smethod_50().method_12().ContainsKey(contact.activeUnit_0.string_0) && !list.Contains(contact))
								{
									list.Add(contact);
								}
							}
						}
					}
					finally
					{
						HashSet<Unit>.Enumerator enumerator;
						enumerator.Dispose();
					}
					if (list.Count > 0)
					{
						result = Enumerable.ElementAtOrDefault<Contact>(Enumerable.OrderBy<Contact, double>(list, new Func<Contact, double>(@class.method_0)), 0);
					}
					else
					{
						result = null;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06006B6A RID: 27498 RVA: 0x003A8610 File Offset: 0x003A6810
		private void method_6(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				Mission.Enum105 enum105_ = FlightPlanEditorTargets.smethod_9(this.vmethod_8().SelectedIndex);
				Scenario scenario = Client.smethod_46();
				Side side_ = Client.smethod_50();
				this.method_7(ref scenario, ref side_, ref this.mission_0, enum105_);
				Client.smethod_51(side_);
				this.method_17();
				this.method_10(true, true);
				this.method_39();
				Client.bool_1 = true;
			}
		}

		// Token: 0x06006B6B RID: 27499 RVA: 0x003A8698 File Offset: 0x003A6898
		public void method_7(ref Scenario scenario_0, ref Side side_0, ref Mission mission_1, Mission.Enum105 enum105_0)
		{
			try
			{
				if (Interaction.MsgBox("You have selected to change the target selection method. This will wipe the existing configuration. Proceed?", MsgBoxStyle.YesNo, null) != MsgBoxResult.No)
				{
					switch (enum105_0)
					{
					case Mission.Enum105.const_0:
						if (this.waypoint_0.enum105_0 == Mission.Enum105.const_0)
						{
							return;
						}
						this.waypoint_0.enum105_0 = Mission.Enum105.const_0;
						this.list_3.Clear();
						this.list_1.Clear();
						this.list_2.Clear();
						this.waypoint_0.list_3 = null;
						this.waypoint_0.list_9 = null;
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.SingleAircraft)
						{
							this.waypoint_0.list_4 = null;
							this.waypoint_0.list_10 = null;
						}
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.TwoAircraft)
						{
							this.waypoint_0.list_5 = null;
							this.waypoint_0.list_11 = null;
						}
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.ThreeAircraft)
						{
							this.waypoint_0.list_6 = null;
							this.waypoint_0.list_12 = null;
						}
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.FourAircraft)
						{
							this.waypoint_0.list_7 = null;
							this.waypoint_0.list_13 = null;
						}
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.FourAircraft)
						{
							this.waypoint_0.list_8 = null;
							this.waypoint_0.list_14 = null;
							goto IL_11F4;
						}
						goto IL_11F4;
					case Mission.Enum105.const_1:
					{
						if (this.waypoint_0.enum105_0 == Mission.Enum105.const_1)
						{
							return;
						}
						this.waypoint_0.enum105_0 = Mission.Enum105.const_1;
						this.list_3.Clear();
						this.list_1.Clear();
						this.list_2.Clear();
						this.waypoint_0.list_3 = new List<Mission.Class288>();
						this.waypoint_0.list_9 = null;
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.SingleAircraft)
						{
							this.waypoint_0.list_4 = null;
							this.waypoint_0.list_10 = null;
						}
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.TwoAircraft)
						{
							this.waypoint_0.list_5 = null;
							this.waypoint_0.list_11 = null;
						}
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.ThreeAircraft)
						{
							this.waypoint_0.list_6 = null;
							this.waypoint_0.list_12 = null;
						}
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.FourAircraft)
						{
							this.waypoint_0.list_7 = null;
							this.waypoint_0.list_13 = null;
						}
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.FourAircraft)
						{
							this.waypoint_0.list_8 = null;
							this.waypoint_0.list_14 = null;
						}
						List<Contact> list = this.method_4();
						if (Information.IsNothing(list) || list.Count <= 0)
						{
							goto IL_11F4;
						}
						try
						{
							foreach (Contact contact in list)
							{
								if (!Information.IsNothing(contact))
								{
									Mission.Class288 item = new Mission.Class288(Guid.NewGuid().ToString(), 0, contact.Name, contact.string_0, contact.activeUnit_0.string_0, contact.activeUnit_0.DBID, contact.vmethod_30(null), contact.vmethod_28(null), null, null, null);
									if (!this.waypoint_0.list_3.Contains(item))
									{
										this.waypoint_0.list_3.Add(item);
									}
								}
							}
							goto IL_11F4;
						}
						finally
						{
							List<Contact>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						break;
					}
					case Mission.Enum105.const_2:
						break;
					default:
						goto IL_11F4;
					}
					if (this.waypoint_0.enum105_0 != Mission.Enum105.const_2)
					{
						this.waypoint_0.enum105_0 = Mission.Enum105.const_2;
						this.list_3.Clear();
						this.list_1.Clear();
						this.list_2.Clear();
						this.waypoint_0.list_3 = new List<Mission.Class288>();
						this.waypoint_0.list_9 = new List<Mission.Class289>();
						Contact contact2 = this.method_5(this.waypoint_0);
						Scenario scenario_;
						ActiveUnit activeUnit_;
						Mission.Flight flight;
						if (!Information.IsNothing(contact2))
						{
							Mission.Class288 item2 = new Mission.Class288(Guid.NewGuid().ToString(), 0, contact2.Name, contact2.string_0, contact2.activeUnit_0.string_0, contact2.activeUnit_0.DBID, contact2.vmethod_30(null), contact2.vmethod_28(null), null, null, null);
							if (Information.IsNothing(this.waypoint_0.list_3))
							{
								this.waypoint_0.list_3 = new List<Mission.Class288>();
							}
							if (!this.waypoint_0.list_3.Contains(item2))
							{
								this.waypoint_0.list_3.Add(item2);
							}
							float float_ = 0f;
							scenario_ = Client.smethod_46();
							Side side_ = Client.smethod_50();
							Waypoint[] array = this.flight_0.method_15();
							int num = 0;
							activeUnit_ = null;
							ActiveUnit activeUnit = null;
							bool bool_ = false;
							Scenario scenario_2;
							ActiveUnit activeUnit_2 = (flight = this.flight_0).method_32(scenario_2 = Client.smethod_46());
							Class514.smethod_68(float_, ref scenario_, ref side_, ref this.mission_0, ref array[num], ref activeUnit_, ref contact2, ref activeUnit, bool_, ref activeUnit_2, ref this.flight_0, ref this.waypoint_1, ref this.waypoint_0, true);
							flight.method_33(scenario_2, activeUnit_2);
							Client.smethod_51(side_);
						}
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.SingleAircraft)
						{
							this.waypoint_0.list_4 = new List<Mission.Class288>();
							this.waypoint_0.list_10 = new List<Mission.Class289>();
							if (!Information.IsNothing(this.waypoint_0.waypoint_0))
							{
								contact2 = this.method_5(this.waypoint_0.waypoint_0);
							}
							if (!Information.IsNothing(contact2))
							{
								Mission.Class288 item3 = new Mission.Class288(Guid.NewGuid().ToString(), 0, contact2.Name, contact2.string_0, contact2.activeUnit_0.string_0, contact2.activeUnit_0.DBID, contact2.vmethod_30(null), contact2.vmethod_28(null), null, null, null);
								if (Information.IsNothing(this.waypoint_0.list_4))
								{
									this.waypoint_0.list_4 = new List<Mission.Class288>();
								}
								if (!this.waypoint_0.list_4.Contains(item3))
								{
									this.waypoint_0.list_4.Add(item3);
								}
								if (!Information.IsNothing(this.waypoint_0.waypoint_0))
								{
									float float_2 = 0f;
									Scenario scenario_2 = Client.smethod_46();
									Side side_ = Client.smethod_50();
									Waypoint[] array2 = this.flight_0.method_15();
									int num2 = 0;
									ActiveUnit activeUnit_2 = null;
									ActiveUnit activeUnit = null;
									bool bool_2 = false;
									activeUnit_ = (flight = this.flight_0).method_32(scenario_ = Client.smethod_46());
									Class514.smethod_69(float_2, ref scenario_2, ref side_, ref this.mission_0, ref array2[num2], ref activeUnit_2, ref contact2, ref activeUnit, bool_2, ref activeUnit_, ref this.flight_0, ref this.waypoint_1.waypoint_0, ref this.waypoint_0.waypoint_0, Mission.Flight.Enum106.const_2, true);
									flight.method_33(scenario_, activeUnit_);
									Client.smethod_51(side_);
								}
							}
						}
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.TwoAircraft)
						{
							this.waypoint_0.list_5 = new List<Mission.Class288>();
							this.waypoint_0.list_11 = new List<Mission.Class289>();
							if (!Information.IsNothing(this.waypoint_0.waypoint_1))
							{
								contact2 = this.method_5(this.waypoint_0.waypoint_1);
							}
							if (!Information.IsNothing(contact2))
							{
								Mission.Class288 item4 = new Mission.Class288(Guid.NewGuid().ToString(), 0, contact2.Name, contact2.string_0, contact2.activeUnit_0.string_0, contact2.activeUnit_0.DBID, contact2.vmethod_30(null), contact2.vmethod_28(null), null, null, null);
								if (Information.IsNothing(this.waypoint_0.list_5))
								{
									this.waypoint_0.list_5 = new List<Mission.Class288>();
								}
								if (!this.waypoint_0.list_5.Contains(item4))
								{
									this.waypoint_0.list_5.Add(item4);
								}
								if (!Information.IsNothing(this.waypoint_0.waypoint_1))
								{
									float float_3 = 0f;
									scenario_ = Client.smethod_46();
									Side side_ = Client.smethod_50();
									Waypoint[] array3 = this.flight_0.method_15();
									int num3 = 0;
									activeUnit_ = null;
									ActiveUnit activeUnit = null;
									bool bool_3 = false;
									Scenario scenario_2;
									ActiveUnit activeUnit_2 = (flight = this.flight_0).method_32(scenario_2 = Client.smethod_46());
									Class514.smethod_69(float_3, ref scenario_, ref side_, ref this.mission_0, ref array3[num3], ref activeUnit_, ref contact2, ref activeUnit, bool_3, ref activeUnit_2, ref this.flight_0, ref this.waypoint_1.waypoint_1, ref this.waypoint_0.waypoint_1, Mission.Flight.Enum106.const_3, true);
									flight.method_33(scenario_2, activeUnit_2);
									Client.smethod_51(side_);
								}
							}
						}
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.ThreeAircraft)
						{
							this.waypoint_0.list_6 = new List<Mission.Class288>();
							this.waypoint_0.list_12 = new List<Mission.Class289>();
							if (!Information.IsNothing(this.waypoint_0.waypoint_2))
							{
								contact2 = this.method_5(this.waypoint_0.waypoint_2);
							}
							if (!Information.IsNothing(contact2))
							{
								Mission.Class288 item5 = new Mission.Class288(Guid.NewGuid().ToString(), 0, contact2.Name, contact2.string_0, contact2.activeUnit_0.string_0, contact2.activeUnit_0.DBID, contact2.vmethod_30(null), contact2.vmethod_28(null), null, null, null);
								if (Information.IsNothing(this.waypoint_0.list_6))
								{
									this.waypoint_0.list_6 = new List<Mission.Class288>();
								}
								if (!this.waypoint_0.list_6.Contains(item5))
								{
									this.waypoint_0.list_6.Add(item5);
								}
								if (!Information.IsNothing(this.waypoint_0.waypoint_2))
								{
									float float_4 = 0f;
									Scenario scenario_2 = Client.smethod_46();
									Side side_ = Client.smethod_50();
									Waypoint[] array4 = this.flight_0.method_15();
									int num4 = 0;
									ActiveUnit activeUnit_2 = null;
									ActiveUnit activeUnit = null;
									bool bool_4 = false;
									activeUnit_ = (flight = this.flight_0).method_32(scenario_ = Client.smethod_46());
									Class514.smethod_69(float_4, ref scenario_2, ref side_, ref this.mission_0, ref array4[num4], ref activeUnit_2, ref contact2, ref activeUnit, bool_4, ref activeUnit_, ref this.flight_0, ref this.waypoint_1.waypoint_2, ref this.waypoint_0.waypoint_2, Mission.Flight.Enum106.const_4, true);
									flight.method_33(scenario_, activeUnit_);
									Client.smethod_51(side_);
								}
							}
						}
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.FourAircraft)
						{
							this.waypoint_0.list_7 = new List<Mission.Class288>();
							this.waypoint_0.list_13 = new List<Mission.Class289>();
							if (!Information.IsNothing(this.waypoint_0.waypoint_3))
							{
								contact2 = this.method_5(this.waypoint_0.waypoint_3);
							}
							if (!Information.IsNothing(contact2))
							{
								Mission.Class288 item6 = new Mission.Class288(Guid.NewGuid().ToString(), 0, contact2.Name, contact2.string_0, contact2.activeUnit_0.string_0, contact2.activeUnit_0.DBID, contact2.vmethod_30(null), contact2.vmethod_28(null), null, null, null);
								if (Information.IsNothing(this.waypoint_0.list_7))
								{
									this.waypoint_0.list_7 = new List<Mission.Class288>();
								}
								if (!this.waypoint_0.list_7.Contains(item6))
								{
									this.waypoint_0.list_7.Add(item6);
								}
								if (!Information.IsNothing(this.waypoint_0.waypoint_3))
								{
									float float_5 = 0f;
									scenario_ = Client.smethod_46();
									Side side_ = Client.smethod_50();
									Waypoint[] array5 = this.flight_0.method_15();
									int num5 = 0;
									activeUnit_ = null;
									ActiveUnit activeUnit = null;
									bool bool_5 = false;
									Scenario scenario_2;
									ActiveUnit activeUnit_2 = (flight = this.flight_0).method_32(scenario_2 = Client.smethod_46());
									Class514.smethod_69(float_5, ref scenario_, ref side_, ref this.mission_0, ref array5[num5], ref activeUnit_, ref contact2, ref activeUnit, bool_5, ref activeUnit_2, ref this.flight_0, ref this.waypoint_1.waypoint_3, ref this.waypoint_0.waypoint_3, Mission.Flight.Enum106.const_5, true);
									flight.method_33(scenario_2, activeUnit_2);
									Client.smethod_51(side_);
								}
							}
							this.waypoint_0.list_8 = new List<Mission.Class288>();
							this.waypoint_0.list_14 = new List<Mission.Class289>();
							if (!Information.IsNothing(this.waypoint_0.waypoint_4))
							{
								contact2 = this.method_5(this.waypoint_0.waypoint_4);
							}
							if (!Information.IsNothing(contact2))
							{
								Mission.Class288 item7 = new Mission.Class288(Guid.NewGuid().ToString(), 0, contact2.Name, contact2.string_0, contact2.activeUnit_0.string_0, contact2.activeUnit_0.DBID, contact2.vmethod_30(null), contact2.vmethod_28(null), null, null, null);
								if (Information.IsNothing(this.waypoint_0.list_8))
								{
									this.waypoint_0.list_8 = new List<Mission.Class288>();
								}
								if (!this.waypoint_0.list_8.Contains(item7))
								{
									this.waypoint_0.list_8.Add(item7);
								}
								if (!Information.IsNothing(this.waypoint_0.waypoint_4))
								{
									float float_6 = 0f;
									Scenario scenario_2 = Client.smethod_46();
									Side side_ = Client.smethod_50();
									Waypoint[] array6 = this.flight_0.method_15();
									int num6 = 0;
									ActiveUnit activeUnit_2 = null;
									ActiveUnit activeUnit = null;
									bool bool_6 = false;
									activeUnit_ = (flight = this.flight_0).method_32(scenario_ = Client.smethod_46());
									Class514.smethod_69(float_6, ref scenario_2, ref side_, ref this.mission_0, ref array6[num6], ref activeUnit_2, ref contact2, ref activeUnit, bool_6, ref activeUnit_, ref this.flight_0, ref this.waypoint_1.waypoint_4, ref this.waypoint_0.waypoint_4, Mission.Flight.Enum106.const_6, true);
									flight.method_33(scenario_, activeUnit_);
									Client.smethod_51(side_);
								}
							}
						}
						this.method_8();
						activeUnit_ = (flight = this.flight_0).method_32(scenario_ = Client.smethod_46());
						Waypoint waypoint = this.waypoint_0;
						List<Mission.Class288> list_ = this.waypoint_0.list_3;
						bool flag = false;
						this.method_9(ref scenario_0, ref side_0, ref activeUnit_, ref this.waypoint_0, ref waypoint.list_9, list_, ref flag, false, ref this.flight_0, "a/c #1");
						flight.method_33(scenario_, activeUnit_);
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.SingleAircraft)
						{
							if (!Information.IsNothing(this.waypoint_0.waypoint_0))
							{
								activeUnit_ = (flight = this.flight_0).method_32(scenario_ = Client.smethod_46());
								Waypoint waypoint2 = this.waypoint_0;
								Waypoint waypoint3 = this.waypoint_0;
								List<Mission.Class288> list_2 = this.waypoint_0.list_4;
								flag = false;
								this.method_9(ref scenario_0, ref side_0, ref activeUnit_, ref waypoint2.waypoint_0, ref waypoint3.list_10, list_2, ref flag, false, ref this.flight_0, "a/c #2");
								flight.method_33(scenario_, activeUnit_);
							}
							else
							{
								activeUnit_ = (flight = this.flight_0).method_32(scenario_ = Client.smethod_46());
								Waypoint waypoint4 = this.waypoint_0;
								List<Mission.Class288> list_3 = this.waypoint_0.list_4;
								flag = false;
								this.method_9(ref scenario_0, ref side_0, ref activeUnit_, ref this.waypoint_0, ref waypoint4.list_10, list_3, ref flag, false, ref this.flight_0, "a/c #2");
								flight.method_33(scenario_, activeUnit_);
							}
						}
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.TwoAircraft)
						{
							if (!Information.IsNothing(this.waypoint_0.waypoint_1))
							{
								activeUnit_ = (flight = this.flight_0).method_32(scenario_ = Client.smethod_46());
								Waypoint waypoint5 = this.waypoint_0;
								Waypoint waypoint6 = this.waypoint_0;
								List<Mission.Class288> list_4 = this.waypoint_0.list_5;
								flag = false;
								this.method_9(ref scenario_0, ref side_0, ref activeUnit_, ref waypoint5.waypoint_1, ref waypoint6.list_11, list_4, ref flag, false, ref this.flight_0, "a/c #3");
								flight.method_33(scenario_, activeUnit_);
							}
							else
							{
								activeUnit_ = (flight = this.flight_0).method_32(scenario_ = Client.smethod_46());
								Waypoint waypoint7 = this.waypoint_0;
								List<Mission.Class288> list_5 = this.waypoint_0.list_5;
								flag = false;
								this.method_9(ref scenario_0, ref side_0, ref activeUnit_, ref this.waypoint_0, ref waypoint7.list_11, list_5, ref flag, false, ref this.flight_0, "a/c #3");
								flight.method_33(scenario_, activeUnit_);
							}
						}
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.ThreeAircraft)
						{
							if (!Information.IsNothing(this.waypoint_0.waypoint_2))
							{
								activeUnit_ = (flight = this.flight_0).method_32(scenario_ = Client.smethod_46());
								Waypoint waypoint8 = this.waypoint_0;
								Waypoint waypoint9 = this.waypoint_0;
								List<Mission.Class288> list_6 = this.waypoint_0.list_6;
								flag = false;
								this.method_9(ref scenario_0, ref side_0, ref activeUnit_, ref waypoint8.waypoint_2, ref waypoint9.list_12, list_6, ref flag, false, ref this.flight_0, "a/c #4");
								flight.method_33(scenario_, activeUnit_);
							}
							else
							{
								activeUnit_ = (flight = this.flight_0).method_32(scenario_ = Client.smethod_46());
								Waypoint waypoint10 = this.waypoint_0;
								List<Mission.Class288> list_7 = this.waypoint_0.list_6;
								flag = false;
								this.method_9(ref scenario_0, ref side_0, ref activeUnit_, ref this.waypoint_0, ref waypoint10.list_12, list_7, ref flag, false, ref this.flight_0, "a/c #4");
								flight.method_33(scenario_, activeUnit_);
							}
						}
						if (this.flight_0._FlightSize_0 > Mission._FlightSize.FourAircraft)
						{
							if (!Information.IsNothing(this.waypoint_0.waypoint_3))
							{
								activeUnit_ = (flight = this.flight_0).method_32(scenario_ = Client.smethod_46());
								Waypoint waypoint11 = this.waypoint_0;
								Waypoint waypoint12 = this.waypoint_0;
								List<Mission.Class288> list_8 = this.waypoint_0.list_7;
								flag = false;
								this.method_9(ref scenario_0, ref side_0, ref activeUnit_, ref waypoint11.waypoint_3, ref waypoint12.list_13, list_8, ref flag, false, ref this.flight_0, "a/c #5");
								flight.method_33(scenario_, activeUnit_);
							}
							else
							{
								activeUnit_ = (flight = this.flight_0).method_32(scenario_ = Client.smethod_46());
								Waypoint waypoint13 = this.waypoint_0;
								List<Mission.Class288> list_9 = this.waypoint_0.list_7;
								flag = false;
								this.method_9(ref scenario_0, ref side_0, ref activeUnit_, ref this.waypoint_0, ref waypoint13.list_13, list_9, ref flag, false, ref this.flight_0, "a/c #5");
								flight.method_33(scenario_, activeUnit_);
							}
							if (!Information.IsNothing(this.waypoint_0.waypoint_4))
							{
								activeUnit_ = (flight = this.flight_0).method_32(scenario_ = Client.smethod_46());
								Waypoint waypoint14 = this.waypoint_0;
								Waypoint waypoint15 = this.waypoint_0;
								List<Mission.Class288> list_10 = this.waypoint_0.list_8;
								flag = false;
								this.method_9(ref scenario_0, ref side_0, ref activeUnit_, ref waypoint14.waypoint_4, ref waypoint15.list_14, list_10, ref flag, false, ref this.flight_0, "a/c #6");
								flight.method_33(scenario_, activeUnit_);
							}
							else
							{
								activeUnit_ = (flight = this.flight_0).method_32(scenario_ = Client.smethod_46());
								Waypoint waypoint16 = this.waypoint_0;
								List<Mission.Class288> list_11 = this.waypoint_0.list_8;
								flag = false;
								this.method_9(ref scenario_0, ref side_0, ref activeUnit_, ref this.waypoint_0, ref waypoint16.list_14, list_11, ref flag, false, ref this.flight_0, "a/c #6");
								flight.method_33(scenario_, activeUnit_);
							}
						}
					}
					IL_11F4:;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006B6C RID: 27500 RVA: 0x003A9908 File Offset: 0x003A7B08
		private void method_8()
		{
			try
			{
				if (!Information.IsNothing(this.flight_0.method_32(Client.smethod_46())) && this.flight_0.method_32(Client.smethod_46()).bool_3)
				{
					Aircraft activeUnit_ = (Aircraft)this.flight_0.method_32(Client.smethod_46());
					if (Information.IsNothing(this.list_0))
					{
						this.list_0 = new List<WeaponRec>();
					}
					else
					{
						this.list_0.Clear();
					}
					this.method_18(activeUnit_);
					this.method_19(activeUnit_);
					this.method_20(activeUnit_);
					if (this.list_0.Count > 0)
					{
						try
						{
							foreach (WeaponRec weaponRec in this.list_0)
							{
								int num = weaponRec.int_0;
								if (num > 0)
								{
									Weapon weapon = weaponRec.method_12(Client.smethod_46());
									string text;
									if (!Information.IsNothing(this.waypoint_0.list_3) && this.waypoint_0.list_3.Count != 0)
									{
										text = this.waypoint_0.list_3[0].string_0;
									}
									else
									{
										text = null;
									}
									if (!Information.IsNothing(text))
									{
										if (weapon.method_167() != Weapon._WeaponType.GuidedWeapon)
										{
											if (weapon.method_167() != Weapon._WeaponType.GuidedProjectile)
											{
												int int_ = weaponRec.int_5;
												Weapon._WeaponType weaponType_ = weapon.method_167();
												string name = weapon.Name;
												float float_ = weapon.method_159();
												float float_2 = weapon.method_160();
												bool bool_ = weapon.struct36_0.bool_14;
												string string_ = text;
												int int_2 = 0;
												int int_3 = -98;
												int int_4 = weaponRec.int_0;
												int int_5 = 0;
												Waypoint[] array = null;
												Mission.Class289 item = new Mission.Class289(int_, weaponType_, name, float_, float_2, bool_, string_, int_2, int_3, int_4, int_5, ref array);
												this.waypoint_0.list_9.Add(item);
												goto IL_1F4;
											}
										}
										int num2 = num;
										for (int i = 1; i <= num2; i++)
										{
											int int_6 = weaponRec.int_5;
											Weapon._WeaponType weaponType_2 = weapon.method_167();
											string name2 = weapon.Name;
											float float_3 = weapon.method_159();
											float float_4 = weapon.method_160();
											bool bool_2 = weapon.struct36_0.bool_14;
											string string_2 = text;
											int int_7 = 0;
											int int_8 = 0;
											int int_9 = 0;
											int int_10 = 0;
											Waypoint[] array = null;
											Mission.Class289 item = new Mission.Class289(int_6, weaponType_2, name2, float_3, float_4, bool_2, string_2, int_7, int_8, int_9, int_10, ref array);
											this.waypoint_0.list_9.Add(item);
										}
									}
									IL_1F4:
									if (this.flight_0._FlightSize_0 > Mission._FlightSize.SingleAircraft)
									{
										if (!Information.IsNothing(this.waypoint_0.list_4) && this.waypoint_0.list_4.Count != 0)
										{
											text = this.waypoint_0.list_4[0].string_0;
										}
										else
										{
											text = null;
										}
										if (!Information.IsNothing(text))
										{
											if (weapon.method_167() != Weapon._WeaponType.GuidedWeapon)
											{
												if (weapon.method_167() != Weapon._WeaponType.GuidedProjectile)
												{
													int int_11 = weaponRec.int_5;
													Weapon._WeaponType weaponType_3 = weapon.method_167();
													string name3 = weapon.Name;
													float float_5 = weapon.method_159();
													float float_6 = weapon.method_160();
													bool bool_3 = weapon.struct36_0.bool_14;
													string string_3 = text;
													int int_12 = 0;
													int int_13 = -98;
													int int_14 = weaponRec.int_0;
													int int_15 = 0;
													Waypoint[] array = null;
													Mission.Class289 item = new Mission.Class289(int_11, weaponType_3, name3, float_5, float_6, bool_3, string_3, int_12, int_13, int_14, int_15, ref array);
													this.waypoint_0.list_10.Add(item);
													goto IL_330;
												}
											}
											int num3 = num;
											for (int j = 1; j <= num3; j++)
											{
												int int_16 = weaponRec.int_5;
												Weapon._WeaponType weaponType_4 = weapon.method_167();
												string name4 = weapon.Name;
												float float_7 = weapon.method_159();
												float float_8 = weapon.method_160();
												bool bool_4 = weapon.struct36_0.bool_14;
												string string_4 = text;
												int int_17 = 0;
												int int_18 = 0;
												int int_19 = 0;
												int int_20 = 0;
												Waypoint[] array = null;
												Mission.Class289 item = new Mission.Class289(int_16, weaponType_4, name4, float_7, float_8, bool_4, string_4, int_17, int_18, int_19, int_20, ref array);
												this.waypoint_0.list_10.Add(item);
											}
										}
									}
									IL_330:
									if (this.flight_0._FlightSize_0 > Mission._FlightSize.TwoAircraft)
									{
										if (!Information.IsNothing(this.waypoint_0.list_5) && this.waypoint_0.list_5.Count != 0)
										{
											text = this.waypoint_0.list_5[0].string_0;
										}
										else
										{
											text = null;
										}
										if (!Information.IsNothing(text))
										{
											if (weapon.method_167() != Weapon._WeaponType.GuidedWeapon)
											{
												if (weapon.method_167() != Weapon._WeaponType.GuidedProjectile)
												{
													int int_21 = weaponRec.int_5;
													Weapon._WeaponType weaponType_5 = weapon.method_167();
													string name5 = weapon.Name;
													float float_9 = weapon.method_159();
													float float_10 = weapon.method_160();
													bool bool_5 = weapon.struct36_0.bool_14;
													string string_5 = text;
													int int_22 = 0;
													int int_23 = -98;
													int int_24 = weaponRec.int_0;
													int int_25 = 0;
													Waypoint[] array = null;
													Mission.Class289 item = new Mission.Class289(int_21, weaponType_5, name5, float_9, float_10, bool_5, string_5, int_22, int_23, int_24, int_25, ref array);
													this.waypoint_0.list_11.Add(item);
													goto IL_46C;
												}
											}
											int num4 = num;
											for (int k = 1; k <= num4; k++)
											{
												int int_26 = weaponRec.int_5;
												Weapon._WeaponType weaponType_6 = weapon.method_167();
												string name6 = weapon.Name;
												float float_11 = weapon.method_159();
												float float_12 = weapon.method_160();
												bool bool_6 = weapon.struct36_0.bool_14;
												string string_6 = text;
												int int_27 = 0;
												int int_28 = 0;
												int int_29 = 0;
												int int_30 = 0;
												Waypoint[] array = null;
												Mission.Class289 item = new Mission.Class289(int_26, weaponType_6, name6, float_11, float_12, bool_6, string_6, int_27, int_28, int_29, int_30, ref array);
												this.waypoint_0.list_11.Add(item);
											}
										}
									}
									IL_46C:
									if (this.flight_0._FlightSize_0 > Mission._FlightSize.ThreeAircraft)
									{
										if (!Information.IsNothing(this.waypoint_0.list_6) && this.waypoint_0.list_6.Count != 0)
										{
											text = this.waypoint_0.list_6[0].string_0;
										}
										else
										{
											text = null;
										}
										if (!Information.IsNothing(text))
										{
											if (weapon.method_167() != Weapon._WeaponType.GuidedWeapon)
											{
												if (weapon.method_167() != Weapon._WeaponType.GuidedProjectile)
												{
													int int_31 = weaponRec.int_5;
													Weapon._WeaponType weaponType_7 = weapon.method_167();
													string name7 = weapon.Name;
													float float_13 = weapon.method_159();
													float float_14 = weapon.method_160();
													bool bool_7 = weapon.struct36_0.bool_14;
													string string_7 = text;
													int int_32 = 0;
													int int_33 = -98;
													int int_34 = weaponRec.int_0;
													int int_35 = 0;
													Waypoint[] array = null;
													Mission.Class289 item = new Mission.Class289(int_31, weaponType_7, name7, float_13, float_14, bool_7, string_7, int_32, int_33, int_34, int_35, ref array);
													this.waypoint_0.list_12.Add(item);
													goto IL_5A8;
												}
											}
											int num5 = num;
											for (int l = 1; l <= num5; l++)
											{
												int int_36 = weaponRec.int_5;
												Weapon._WeaponType weaponType_8 = weapon.method_167();
												string name8 = weapon.Name;
												float float_15 = weapon.method_159();
												float float_16 = weapon.method_160();
												bool bool_8 = weapon.struct36_0.bool_14;
												string string_8 = text;
												int int_37 = 0;
												int int_38 = 0;
												int int_39 = 0;
												int int_40 = 0;
												Waypoint[] array = null;
												Mission.Class289 item = new Mission.Class289(int_36, weaponType_8, name8, float_15, float_16, bool_8, string_8, int_37, int_38, int_39, int_40, ref array);
												this.waypoint_0.list_12.Add(item);
											}
										}
									}
									IL_5A8:
									if (this.flight_0._FlightSize_0 > Mission._FlightSize.FourAircraft)
									{
										if (!Information.IsNothing(this.waypoint_0.list_7) && this.waypoint_0.list_7.Count != 0)
										{
											text = this.waypoint_0.list_7[0].string_0;
										}
										else
										{
											text = null;
										}
										if (!Information.IsNothing(text))
										{
											if (weapon.method_167() != Weapon._WeaponType.GuidedWeapon)
											{
												if (weapon.method_167() != Weapon._WeaponType.GuidedProjectile)
												{
													int int_41 = weaponRec.int_5;
													Weapon._WeaponType weaponType_9 = weapon.method_167();
													string name9 = weapon.Name;
													float float_17 = weapon.method_159();
													float float_18 = weapon.method_160();
													bool bool_9 = weapon.struct36_0.bool_14;
													string string_9 = text;
													int int_42 = 0;
													int int_43 = -98;
													int int_44 = weaponRec.int_0;
													int int_45 = 0;
													Waypoint[] array = null;
													Mission.Class289 item = new Mission.Class289(int_41, weaponType_9, name9, float_17, float_18, bool_9, string_9, int_42, int_43, int_44, int_45, ref array);
													this.waypoint_0.list_13.Add(item);
													goto IL_6E4;
												}
											}
											int num6 = num;
											for (int m = 1; m <= num6; m++)
											{
												int int_46 = weaponRec.int_5;
												Weapon._WeaponType weaponType_10 = weapon.method_167();
												string name10 = weapon.Name;
												float float_19 = weapon.method_159();
												float float_20 = weapon.method_160();
												bool bool_10 = weapon.struct36_0.bool_14;
												string string_10 = text;
												int int_47 = 0;
												int int_48 = 0;
												int int_49 = 0;
												int int_50 = 0;
												Waypoint[] array = null;
												Mission.Class289 item = new Mission.Class289(int_46, weaponType_10, name10, float_19, float_20, bool_10, string_10, int_47, int_48, int_49, int_50, ref array);
												this.waypoint_0.list_13.Add(item);
											}
										}
									}
									IL_6E4:
									if (this.flight_0._FlightSize_0 > Mission._FlightSize.FourAircraft)
									{
										if (!Information.IsNothing(this.waypoint_0.list_8) && this.waypoint_0.list_8.Count != 0)
										{
											text = this.waypoint_0.list_8[0].string_0;
										}
										else
										{
											text = null;
										}
										if (!Information.IsNothing(text))
										{
											if (weapon.method_167() != Weapon._WeaponType.GuidedWeapon)
											{
												if (weapon.method_167() != Weapon._WeaponType.GuidedProjectile)
												{
													int int_51 = weaponRec.int_5;
													Weapon._WeaponType weaponType_11 = weapon.method_167();
													string name11 = weapon.Name;
													float float_21 = weapon.method_159();
													float float_22 = weapon.method_160();
													bool bool_11 = weapon.struct36_0.bool_14;
													string string_11 = text;
													int int_52 = 0;
													int int_53 = -98;
													int int_54 = weaponRec.int_0;
													int int_55 = 0;
													Waypoint[] array = null;
													Mission.Class289 item = new Mission.Class289(int_51, weaponType_11, name11, float_21, float_22, bool_11, string_11, int_52, int_53, int_54, int_55, ref array);
													this.waypoint_0.list_14.Add(item);
													continue;
												}
											}
											int num7 = num;
											for (int n = 1; n <= num7; n++)
											{
												int int_56 = weaponRec.int_5;
												Weapon._WeaponType weaponType_12 = weapon.method_167();
												string name12 = weapon.Name;
												float float_23 = weapon.method_159();
												float float_24 = weapon.method_160();
												bool bool_12 = weapon.struct36_0.bool_14;
												string string_12 = text;
												int int_57 = 0;
												int int_58 = 0;
												int int_59 = 0;
												int int_60 = 0;
												Waypoint[] array = null;
												Mission.Class289 item = new Mission.Class289(int_56, weaponType_12, name12, float_23, float_24, bool_12, string_12, int_57, int_58, int_59, int_60, ref array);
												this.waypoint_0.list_14.Add(item);
											}
										}
									}
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006B6D RID: 27501 RVA: 0x003AA1C0 File Offset: 0x003A83C0
		private void method_9(ref Scenario scenario_0, ref Side side_0, ref ActiveUnit activeUnit_0, ref Waypoint waypoint_2, ref List<Mission.Class289> list_4, List<Mission.Class288> list_5, ref bool bool_4, bool bool_5, ref Mission.Flight flight_1, string string_1)
		{
			try
			{
				if (this.waypoint_0.enum105_0 == Mission.Enum105.const_2)
				{
					bool flag = false;
					if (!Information.IsNothing(waypoint_2) && waypoint_2.list_2.Count > 0)
					{
						int count = waypoint_2.list_2.Count;
						double double_;
						double double_2;
						if (waypoint_2.waypointType_0 == Waypoint.WaypointType.Target)
						{
							double_ = waypoint_2.list_2[count - 1].double_0;
							double_2 = waypoint_2.list_2[count - 1].double_1;
						}
						else
						{
							if (waypoint_2.waypointType_0 != Waypoint.WaypointType.WeaponTarget)
							{
								goto IL_215;
							}
							double_ = waypoint_2.list_2[count - 1].double_2;
							double_2 = waypoint_2.list_2[count - 1].double_3;
						}
						try
						{
							foreach (Mission.Class289 @class in list_4)
							{
								if (!flag)
								{
									@class.bool_1 = true;
									flag = true;
								}
								else
								{
									@class.bool_1 = false;
								}
								Mission.Class288 class3;
								try
								{
									foreach (Mission.Class288 class2 in list_5)
									{
										if (Operators.CompareString(@class.string_1, class2.string_0, false) == 0)
										{
											class3 = class2;
											break;
										}
									}
								}
								finally
								{
									List<Mission.Class288>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
								Weapon weapon = Weapon.smethod_16(ref scenario_0, @class.int_0, null);
								Contact contact = null;
								if (side_0.method_11().ContainsKey(class3.string_3))
								{
									side_0.method_11().TryGetValue(class3.string_3, ref contact);
								}
								double num = contact.vmethod_30(null);
								double num2 = contact.vmethod_28(null);
								float float_;
								if (contact.bool_19)
								{
									float_ = contact.vmethod_14(false);
								}
								else
								{
									float_ = (float)Terrain.smethod_7(num, num2, false);
								}
								float float_2 = 10000f;
								Class514.smethod_85(ref scenario_0, ref activeUnit_0, ref class3, ref @class, ref waypoint_2, ref this.waypoint_1, ref @class.waypoint_0, ref weapon, ref class3.int_0, ref contact, double_, double_2, float_2, num, num2, float_, ref bool_4, bool_5, ref flight_1, string_1);
							}
						}
						finally
						{
							List<Mission.Class289>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					IL_215:;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006B6E RID: 27502 RVA: 0x003AA468 File Offset: 0x003A8668
		internal void method_10(bool bool_4, bool bool_5)
		{
			try
			{
				if (!Information.IsNothing(Client.smethod_50()))
				{
					if (Client.smethod_50().activeUnit_0.Length != 0)
					{
						this.method_22();
						int num = 0;
						int index = 0;
						int firstDisplayedScrollingRowIndex = this.vmethod_12().FirstDisplayedScrollingRowIndex;
						if (this.vmethod_12().SelectedCells.Count > 0)
						{
							num = this.vmethod_12().SelectedCells[0].RowIndex;
							index = this.vmethod_12().SelectedCells[0].ColumnIndex;
						}
						this.vmethod_12().method_2().Clear();
						int num2 = 0;
						int index2 = 0;
						int firstDisplayedScrollingRowIndex2 = this.vmethod_4().FirstDisplayedScrollingRowIndex;
						if (this.vmethod_4().SelectedCells.Count > 0)
						{
							num2 = this.vmethod_4().SelectedCells[0].RowIndex;
							index2 = this.vmethod_4().SelectedCells[0].ColumnIndex;
						}
						this.vmethod_4().method_2().Clear();
						string string_ = "Name not found!";
						switch (this.waypoint_0.enum105_0)
						{
						case Mission.Enum105.const_0:
							string_ = "Mission";
							break;
						case Mission.Enum105.const_1:
							string_ = "Flight";
							break;
						case Mission.Enum105.const_2:
							string_ = "Aircraft #1";
							break;
						}
						this.method_11(string_, ref this.waypoint_0.list_3, ref this.waypoint_0);
						this.method_12(string_, ref this.waypoint_0.list_3, ref this.waypoint_0.list_9, ref this.waypoint_0);
						if (this.list_3.Contains("Aircraft #2"))
						{
							Waypoint waypoint;
							if (Information.IsNothing(this.waypoint_0.waypoint_0))
							{
								waypoint = this.waypoint_0;
							}
							else
							{
								waypoint = this.waypoint_0.waypoint_0;
							}
							string_ = "Aircraft #2";
							this.method_11(string_, ref this.waypoint_0.list_4, ref waypoint);
							this.method_12(string_, ref this.waypoint_0.list_4, ref this.waypoint_0.list_10, ref waypoint);
						}
						if (this.list_3.Contains("Aircraft #3"))
						{
							Waypoint waypoint;
							if (Information.IsNothing(this.waypoint_0.waypoint_1))
							{
								waypoint = this.waypoint_0;
							}
							else
							{
								waypoint = this.waypoint_0.waypoint_1;
							}
							string_ = "Aircraft #3";
							this.method_11(string_, ref this.waypoint_0.list_5, ref waypoint);
							this.method_12(string_, ref this.waypoint_0.list_5, ref this.waypoint_0.list_11, ref waypoint);
						}
						if (this.list_3.Contains("Aircraft #4"))
						{
							Waypoint waypoint;
							if (Information.IsNothing(this.waypoint_0.waypoint_2))
							{
								waypoint = this.waypoint_0;
							}
							else
							{
								waypoint = this.waypoint_0.waypoint_2;
							}
							string_ = "Aircraft #4";
							this.method_11(string_, ref this.waypoint_0.list_6, ref waypoint);
							this.method_12(string_, ref this.waypoint_0.list_6, ref this.waypoint_0.list_12, ref waypoint);
						}
						if (this.list_3.Contains("Aircraft #5"))
						{
							Waypoint waypoint;
							if (Information.IsNothing(this.waypoint_0.waypoint_3))
							{
								waypoint = this.waypoint_0;
							}
							else
							{
								waypoint = this.waypoint_0.waypoint_3;
							}
							string_ = "Aircraft #5";
							this.method_11(string_, ref this.waypoint_0.list_7, ref waypoint);
							this.method_12(string_, ref this.waypoint_0.list_7, ref this.waypoint_0.list_13, ref waypoint);
						}
						if (this.list_3.Contains("Aircraft #6"))
						{
							Waypoint waypoint;
							if (Information.IsNothing(this.waypoint_0.waypoint_4))
							{
								waypoint = this.waypoint_0;
							}
							else
							{
								waypoint = this.waypoint_0.waypoint_4;
							}
							string_ = "Aircraft #6";
							this.method_11(string_, ref this.waypoint_0.list_8, ref waypoint);
							this.method_12(string_, ref this.waypoint_0.list_8, ref this.waypoint_0.list_14, ref waypoint);
						}
						if (bool_4)
						{
							if (this.waypoint_0.enum105_0 == Mission.Enum105.const_2)
							{
								if (!this.list_1.Contains("Aircraft #1"))
								{
									this.list_1.Add("Aircraft #1");
								}
								if (!this.list_1.Contains("Aircraft #2"))
								{
									this.list_1.Add("Aircraft #2");
								}
								if (!this.list_1.Contains("Aircraft #3"))
								{
									this.list_1.Add("Aircraft #3");
								}
								if (!this.list_1.Contains("Aircraft #4"))
								{
									this.list_1.Add("Aircraft #4");
								}
								if (!this.list_1.Contains("Aircraft #5"))
								{
									this.list_1.Add("Aircraft #5");
								}
								if (!this.list_1.Contains("Aircraft #6"))
								{
									this.list_1.Add("Aircraft #6");
								}
							}
							else if (this.waypoint_0.enum105_0 == Mission.Enum105.const_1)
							{
								if (!this.list_1.Contains("Flight"))
								{
									this.list_1.Add("Flight");
								}
							}
							else if (!this.list_1.Contains("Mission"))
							{
								this.list_1.Add("Mission");
							}
						}
						if (bool_5)
						{
							if (this.waypoint_0.enum105_0 == Mission.Enum105.const_2)
							{
								if (!this.list_2.Contains("Aircraft #1"))
								{
									this.list_2.Add("Aircraft #1");
								}
								if (!this.list_2.Contains("Aircraft #2"))
								{
									this.list_2.Add("Aircraft #2");
								}
								if (!this.list_2.Contains("Aircraft #3"))
								{
									this.list_2.Add("Aircraft #3");
								}
								if (!this.list_2.Contains("Aircraft #4"))
								{
									this.list_2.Add("Aircraft #4");
								}
								if (!this.list_2.Contains("Aircraft #5"))
								{
									this.list_2.Add("Aircraft #5");
								}
								if (!this.list_2.Contains("Aircraft #6"))
								{
									this.list_2.Add("Aircraft #6");
								}
							}
							else if (this.waypoint_0.enum105_0 == Mission.Enum105.const_1)
							{
								if (!this.list_2.Contains("Flight"))
								{
									this.list_2.Add("Flight");
								}
							}
							else if (!this.list_2.Contains("Mission"))
							{
								this.list_2.Add("Mission");
							}
						}
						try
						{
							foreach (string text in this.list_1)
							{
								try
								{
									foreach (Class48 @class in this.vmethod_12().method_2())
									{
										try
										{
											if ((string)@class.Tag == text)
											{
												@class.vmethod_4();
												break;
											}
										}
										catch (Exception ex)
										{
											ex.Data.Add("Error at 999999", ex.Message);
											GameGeneral.smethod_25(ref ex);
											if (Debugger.IsAttached)
											{
												Debugger.Break();
											}
										}
									}
								}
								finally
								{
									IEnumerator<Class48> enumerator2;
									if (enumerator2 != null)
									{
										enumerator2.Dispose();
									}
								}
							}
						}
						finally
						{
							List<string>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						try
						{
							foreach (string text2 in this.list_2)
							{
								try
								{
									foreach (Class48 class2 in this.vmethod_4().method_2())
									{
										try
										{
											if ((string)class2.Tag == text2)
											{
												class2.vmethod_4();
												break;
											}
										}
										catch (Exception ex2)
										{
											ex2.Data.Add("Error at 999999", ex2.Message);
											GameGeneral.smethod_25(ref ex2);
											if (Debugger.IsAttached)
											{
												Debugger.Break();
											}
										}
									}
								}
								finally
								{
									IEnumerator<Class48> enumerator4;
									if (enumerator4 != null)
									{
										enumerator4.Dispose();
									}
								}
							}
						}
						finally
						{
							List<string>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
						try
						{
							foreach (Class48 class3 in this.vmethod_4().method_2())
							{
								try
								{
									try
									{
										foreach (Class48 class4 in class3.method_7())
										{
											Mission.Class289 class5 = (Mission.Class289)class4.Tag;
											if (class5._WeaponType_0 == Weapon._WeaponType.GuidedWeapon | class5._WeaponType_0 == Weapon._WeaponType.GuidedProjectile)
											{
												DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
												dataGridViewTextBoxCell.Value = "";
												this.vmethod_4()[this.vmethod_60().Index, class4.method_1()] = dataGridViewTextBoxCell;
												dataGridViewTextBoxCell.ReadOnly = true;
											}
											if (Conversions.ToInteger(this.vmethod_4()[this.vmethod_56().Index, class4.method_1()].Value) == 0)
											{
												DataGridViewTextBoxCell dataGridViewTextBoxCell2 = new DataGridViewTextBoxCell();
												DataGridViewTextBoxCell dataGridViewTextBoxCell3 = new DataGridViewTextBoxCell();
												DataGridViewTextBoxCell dataGridViewTextBoxCell4 = new DataGridViewTextBoxCell();
												dataGridViewTextBoxCell2.Value = "";
												dataGridViewTextBoxCell3.Value = "";
												dataGridViewTextBoxCell4.Value = "";
												this.vmethod_4()[this.vmethod_60().Index, class4.method_1()] = dataGridViewTextBoxCell2;
												this.vmethod_4()[this.vmethod_62().Index, class4.method_1()] = dataGridViewTextBoxCell4;
												this.vmethod_4()[this.vmethod_58().Index, class4.method_1()] = dataGridViewTextBoxCell3;
												dataGridViewTextBoxCell2.ReadOnly = true;
												dataGridViewTextBoxCell3.ReadOnly = true;
												dataGridViewTextBoxCell4.ReadOnly = true;
											}
										}
									}
									finally
									{
										IEnumerator<Class48> enumerator6;
										if (enumerator6 != null)
										{
											enumerator6.Dispose();
										}
									}
								}
								catch (Exception ex3)
								{
									ex3.Data.Add("Error at 999999", ex3.Message);
									GameGeneral.smethod_25(ref ex3);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
								}
							}
						}
						finally
						{
							IEnumerator<Class48> enumerator5;
							if (enumerator5 != null)
							{
								enumerator5.Dispose();
							}
						}
						if (this.vmethod_12().method_0().Count != 0 & num != 0)
						{
							this.vmethod_12().method_0()[num].Cells[index].Selected = true;
							if (firstDisplayedScrollingRowIndex != -1)
							{
								this.vmethod_12().FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
							}
						}
						if (this.vmethod_4().method_0().Count != 0 & num2 != 0)
						{
							this.vmethod_4().method_0()[num2].Cells[index2].Selected = true;
							if (firstDisplayedScrollingRowIndex2 != -1)
							{
								this.vmethod_4().FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex2;
							}
						}
						this.method_39();
						this.method_23(true);
					}
				}
			}
			catch (Exception ex4)
			{
				ex4.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006B6F RID: 27503 RVA: 0x003AAFF0 File Offset: 0x003A91F0
		private void method_11(string string_1, ref List<Mission.Class288> list_4, ref Waypoint waypoint_2)
		{
			try
			{
				int num = 0;
				Class49 @class = this.vmethod_12().method_2();
				object[] array = new object[3];
				array[0] = string_1;
				Class48 class2 = @class.method_1(array);
				class2.Tag = string_1;
				if (this.waypoint_0.enum105_0 == Mission.Enum105.const_0)
				{
					List<Contact> list = this.method_4();
					if (Information.IsNothing(list) || list.Count <= 0)
					{
						goto IL_C5B;
					}
					try
					{
						foreach (Contact contact in list)
						{
							if (!Information.IsNothing(contact))
							{
								DateTime? dateTime;
								string text;
								if (!Information.IsNothing(waypoint_2.nullable_7))
								{
									if (Information.IsNothing(waypoint_2.nullable_8))
									{
										dateTime = waypoint_2.nullable_7;
									}
									else
									{
										dateTime = waypoint_2.nullable_8;
									}
									if (dateTime.Value.Hour < 10)
									{
										text = "0" + dateTime.Value.Hour.ToString() + ":";
									}
									else
									{
										text = dateTime.Value.Hour.ToString() + ":";
									}
									if (dateTime.Value.Minute < 10)
									{
										text = text + "0" + dateTime.Value.Minute.ToString() + ":";
									}
									else
									{
										text = text + dateTime.Value.Minute.ToString() + ":";
									}
									if (dateTime.Value.Second < 10)
									{
										text = text + "0" + dateTime.Value.Second.ToString();
									}
									else
									{
										text += dateTime.Value.Second.ToString();
									}
									if (waypoint_2.waypointType_0 == Waypoint.WaypointType.Target || waypoint_2.waypointType_0 == Waypoint.WaypointType.WeaponTarget)
									{
										string str = dateTime.Value.Year.ToString() + "-";
										if (dateTime.Value.Month < 10)
										{
											str = str + "0" + dateTime.Value.Month.ToString() + "-";
										}
										else
										{
											str = str + dateTime.Value.Month.ToString() + "-";
										}
										if (dateTime.Value.Day < 10)
										{
											str = str + "0" + dateTime.Value.Day.ToString();
										}
										else
										{
											str += dateTime.Value.Day.ToString();
										}
									}
								}
								else
								{
									text = "-";
								}
								string text3;
								if (!Information.IsNothing(dateTime) && !Information.IsNothing(waypoint_2.nullable_9))
								{
									DateTime dateTime_ = Client.smethod_46().method_31();
									bool bool_ = Client.smethod_46().method_33();
									string text2 = Client.smethod_46().method_35();
									string string_2 = Client.smethod_46().method_37();
									DateTime? dateTime2;
									if (Information.IsNothing(waypoint_2.nullable_8))
									{
										dateTime2 = waypoint_2.nullable_9;
									}
									else
									{
										dateTime2 = waypoint_2.nullable_10;
									}
									if (dateTime2.Value.Hour < 10)
									{
										text3 = "0" + dateTime2.Value.Hour.ToString() + ":";
									}
									else
									{
										text3 = dateTime2.Value.Hour.ToString() + ":";
									}
									if (dateTime2.Value.Minute < 10)
									{
										text3 = text3 + "0" + dateTime2.Value.Minute.ToString() + ":";
									}
									else
									{
										text3 = text3 + dateTime2.Value.Minute.ToString() + ":";
									}
									if (dateTime2.Value.Second < 10)
									{
										text3 = text3 + "0" + dateTime2.Value.Second.ToString();
									}
									else
									{
										text3 += dateTime2.Value.Second.ToString();
									}
									waypoint_2.ttimeOfDayType_0 = Class418.smethod_1(null, dateTime.Value.Year, dateTime.Value.Month, dateTime.Value.Day, dateTime.Value.Hour, dateTime.Value.Minute, dateTime.Value.Second, false, waypoint_2.imethod_2(), waypoint_2.imethod_0(), 0.0);
									if (Information.IsNothing(waypoint_2.nullable_8))
									{
										waypoint_2.nullable_9 = new DateTime?(Misc.smethod_10(waypoint_2.nullable_7.Value, waypoint_2.imethod_0(), bool_, text2, string_2));
									}
									else
									{
										waypoint_2.nullable_9 = new DateTime?(Misc.smethod_10(waypoint_2.nullable_8.Value, waypoint_2.imethod_0(), bool_, text2, string_2));
									}
									text3 = text3 + " (" + Class418.smethod_0(waypoint_2.ttimeOfDayType_0, dateTime_, waypoint_2.imethod_0(), bool_, text2, string_2) + ")";
								}
								else
								{
									text3 = "-";
								}
								string text4 = Misc.smethod_8(waypoint_2.imethod_2(), waypoint_2.imethod_0());
								string text5 = "Using WRA";
								num++;
								class2.method_7().method_1(new object[]
								{
									num,
									contact.Name,
									text5,
									text,
									text3,
									text4
								});
							}
						}
						goto IL_C5B;
					}
					finally
					{
						List<Contact>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (!Information.IsNothing(list_4))
				{
					try
					{
						foreach (Mission.Class288 class3 in list_4)
						{
							DateTime? dateTime3;
							string text6;
							if (!Information.IsNothing(waypoint_2.nullable_7))
							{
								if (Information.IsNothing(waypoint_2.nullable_8))
								{
									dateTime3 = waypoint_2.nullable_7;
								}
								else
								{
									dateTime3 = waypoint_2.nullable_8;
								}
								if (dateTime3.Value.Hour < 10)
								{
									text6 = "0" + dateTime3.Value.Hour.ToString() + ":";
								}
								else
								{
									text6 = dateTime3.Value.Hour.ToString() + ":";
								}
								if (dateTime3.Value.Minute < 10)
								{
									text6 = text6 + "0" + dateTime3.Value.Minute.ToString() + ":";
								}
								else
								{
									text6 = text6 + dateTime3.Value.Minute.ToString() + ":";
								}
								if (dateTime3.Value.Second < 10)
								{
									text6 = text6 + "0" + dateTime3.Value.Second.ToString();
								}
								else
								{
									text6 += dateTime3.Value.Second.ToString();
								}
								if (waypoint_2.waypointType_0 == Waypoint.WaypointType.Target || waypoint_2.waypointType_0 == Waypoint.WaypointType.WeaponTarget)
								{
									string str2 = dateTime3.Value.Year.ToString() + "-";
									if (dateTime3.Value.Month < 10)
									{
										str2 = str2 + "0" + dateTime3.Value.Month.ToString() + "-";
									}
									else
									{
										str2 = str2 + dateTime3.Value.Month.ToString() + "-";
									}
									if (dateTime3.Value.Day < 10)
									{
										str2 = str2 + "0" + dateTime3.Value.Day.ToString();
									}
									else
									{
										str2 += dateTime3.Value.Day.ToString();
									}
								}
							}
							else
							{
								text6 = "-";
							}
							string text8;
							if (!Information.IsNothing(dateTime3) && !Information.IsNothing(waypoint_2.nullable_9))
							{
								DateTime dateTime_2 = Client.smethod_46().method_31();
								bool bool_2 = Client.smethod_46().method_33();
								string text7 = Client.smethod_46().method_35();
								string string_3 = Client.smethod_46().method_37();
								DateTime? dateTime4;
								if (Information.IsNothing(waypoint_2.nullable_8))
								{
									dateTime4 = waypoint_2.nullable_9;
								}
								else
								{
									dateTime4 = waypoint_2.nullable_10;
								}
								if (dateTime4.Value.Hour < 10)
								{
									text8 = "0" + dateTime4.Value.Hour.ToString() + ":";
								}
								else
								{
									text8 = dateTime4.Value.Hour.ToString() + ":";
								}
								if (dateTime4.Value.Minute < 10)
								{
									text8 = text8 + "0" + dateTime4.Value.Minute.ToString() + ":";
								}
								else
								{
									text8 = text8 + dateTime4.Value.Minute.ToString() + ":";
								}
								if (dateTime4.Value.Second < 10)
								{
									text8 = text8 + "0" + dateTime4.Value.Second.ToString();
								}
								else
								{
									text8 += dateTime4.Value.Second.ToString();
								}
								waypoint_2.ttimeOfDayType_0 = Class418.smethod_1(null, dateTime3.Value.Year, dateTime3.Value.Month, dateTime3.Value.Day, dateTime3.Value.Hour, dateTime3.Value.Minute, dateTime3.Value.Second, false, waypoint_2.imethod_2(), waypoint_2.imethod_0(), 0.0);
								if (Information.IsNothing(waypoint_2.nullable_8))
								{
									waypoint_2.nullable_9 = new DateTime?(Misc.smethod_10(waypoint_2.nullable_7.Value, waypoint_2.imethod_0(), bool_2, text7, string_3));
								}
								else
								{
									waypoint_2.nullable_9 = new DateTime?(Misc.smethod_10(waypoint_2.nullable_8.Value, waypoint_2.imethod_0(), bool_2, text7, string_3));
								}
								text8 = text8 + " (" + Class418.smethod_0(waypoint_2.ttimeOfDayType_0, dateTime_2, waypoint_2.imethod_0(), bool_2, text7, string_3) + ")";
							}
							else
							{
								text8 = "-";
							}
							string text9 = Misc.smethod_8(waypoint_2.imethod_2(), waypoint_2.imethod_0());
							string text10 = "Not configured";
							switch (this.waypoint_0.enum105_0)
							{
							case Mission.Enum105.const_0:
								text10 = "Using WRA";
								break;
							case Mission.Enum105.const_1:
								text10 = "Using WRA";
								break;
							case Mission.Enum105.const_2:
								text10 = "No weapons assigned";
								break;
							}
							num++;
							class2.method_7().method_1(new object[]
							{
								num,
								class3.string_1,
								text10,
								text6,
								text8,
								text9
							}).Tag = class3;
						}
					}
					finally
					{
						List<Mission.Class288>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				IL_C5B:
				DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell dataGridViewTextBoxCell2 = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell dataGridViewTextBoxCell3 = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell dataGridViewTextBoxCell4 = new DataGridViewTextBoxCell();
				DataGridViewTextBoxCell dataGridViewTextBoxCell5 = new DataGridViewTextBoxCell();
				dataGridViewTextBoxCell.Value = "";
				dataGridViewTextBoxCell2.Value = "";
				dataGridViewTextBoxCell3.Value = "";
				dataGridViewTextBoxCell4.Value = "";
				dataGridViewTextBoxCell5.Value = "";
				this.vmethod_12()[this.vmethod_44().Index, class2.method_1()] = dataGridViewTextBoxCell;
				this.vmethod_12()[this.vmethod_46().Index, class2.method_1()] = dataGridViewTextBoxCell2;
				this.vmethod_12()[this.vmethod_48().Index, class2.method_1()] = dataGridViewTextBoxCell3;
				this.vmethod_12()[this.vmethod_50().Index, class2.method_1()] = dataGridViewTextBoxCell4;
				this.vmethod_12()[this.vmethod_52().Index, class2.method_1()] = dataGridViewTextBoxCell5;
				dataGridViewTextBoxCell.ReadOnly = true;
				dataGridViewTextBoxCell2.ReadOnly = true;
				dataGridViewTextBoxCell3.ReadOnly = true;
				dataGridViewTextBoxCell4.ReadOnly = true;
				dataGridViewTextBoxCell5.ReadOnly = true;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006B70 RID: 27504 RVA: 0x003ABDF4 File Offset: 0x003A9FF4
		private void method_12(string string_1, ref List<Mission.Class288> list_4, ref List<Mission.Class289> list_5, ref Waypoint waypoint_2)
		{
			try
			{
				if (this.waypoint_0.enum105_0 != Mission.Enum105.const_0 && this.waypoint_0.enum105_0 != Mission.Enum105.const_1)
				{
					Class49 @class = this.vmethod_4().method_2();
					object[] array = new object[6];
					array[0] = string_1;
					Class48 class2 = @class.method_1(array);
					class2.Tag = string_1;
					if (!Information.IsNothing(list_5))
					{
						try
						{
							foreach (Mission.Class289 class3 in list_5)
							{
								int num = FlightPlanEditorTargets.smethod_4(class3.string_1, ref list_4);
								string text = "-";
								if (!Information.IsNothing(class3.waypoint_0) && Enumerable.Count<Waypoint>(class3.waypoint_0) > 0)
								{
									string str = "";
									if (!Information.IsNothing(class3.waypoint_0[Enumerable.Count<Waypoint>(class3.waypoint_0) - 1].nullable_7))
									{
										str = "ToT: " + class3.waypoint_0[Enumerable.Count<Waypoint>(class3.waypoint_0) - 1].nullable_7.ToString() + ", ";
									}
									string str2 = "Flight time: " + Conversions.ToString(class3.waypoint_0[Enumerable.Count<Waypoint>(class3.waypoint_0) - 1].float_7) + ", ";
									string str3 = " Waypoints: " + Conversions.ToString(Enumerable.Count<Waypoint>(class3.waypoint_0));
									text = str + str2 + str3;
								}
								string text2 = class3.string_0;
								if (class3.bool_1)
								{
									text2 = "Time ref: " + text2;
								}
								class2.method_7().method_1(new object[]
								{
									text2,
									num,
									class3.int_1,
									FlightPlanEditorTargets.smethod_1(class3.int_2),
									class3.int_4,
									text
								}).Tag = class3;
							}
						}
						finally
						{
							List<Mission.Class289>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
					DataGridViewTextBoxCell dataGridViewTextBoxCell2 = new DataGridViewTextBoxCell();
					DataGridViewTextBoxCell dataGridViewTextBoxCell3 = new DataGridViewTextBoxCell();
					DataGridViewTextBoxCell dataGridViewTextBoxCell4 = new DataGridViewTextBoxCell();
					DataGridViewTextBoxCell dataGridViewTextBoxCell5 = new DataGridViewTextBoxCell();
					dataGridViewTextBoxCell.Value = "";
					dataGridViewTextBoxCell2.Value = "";
					dataGridViewTextBoxCell3.Value = "";
					dataGridViewTextBoxCell4.Value = "";
					dataGridViewTextBoxCell5.Value = "";
					this.vmethod_4()[this.vmethod_56().Index, class2.method_1()] = dataGridViewTextBoxCell;
					this.vmethod_4()[this.vmethod_58().Index, class2.method_1()] = dataGridViewTextBoxCell2;
					this.vmethod_4()[this.vmethod_60().Index, class2.method_1()] = dataGridViewTextBoxCell3;
					this.vmethod_4()[this.vmethod_62().Index, class2.method_1()] = dataGridViewTextBoxCell4;
					this.vmethod_4()[this.vmethod_64().Index, class2.method_1()] = dataGridViewTextBoxCell5;
					dataGridViewTextBoxCell.ReadOnly = true;
					dataGridViewTextBoxCell2.ReadOnly = true;
					dataGridViewTextBoxCell3.ReadOnly = true;
					dataGridViewTextBoxCell4.ReadOnly = true;
					dataGridViewTextBoxCell5.ReadOnly = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x003AC17C File Offset: 0x003AA37C
		private void method_13(object sender, EventArgs1 e)
		{
			if (e.method_0().method_8() == 1)
			{
				string item = (string)e.method_0().Tag;
				if (!this.list_1.Contains(item))
				{
					this.list_1.Add(item);
				}
			}
		}

		// Token: 0x06006B72 RID: 27506 RVA: 0x003AC1C4 File Offset: 0x003AA3C4
		private void method_14(object sender, EventArgs1 e)
		{
			try
			{
				if (e.method_0().method_8() == 1)
				{
					string text = (string)e.method_0().Tag;
					if (!this.list_2.Contains(text))
					{
						this.list_2.Add(text);
					}
					try
					{
						foreach (Class48 @class in e.method_0().method_7())
						{
							DataTable dataSource = new DataTable();
							DataTable dataSource2 = new DataTable();
							DataTable dataSource3 = new DataTable();
							DataTable dataSource4 = new DataTable();
							DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)@class.Cells[this.vmethod_60().Index];
							DataGridViewComboBoxCell dataGridViewComboBoxCell2 = (DataGridViewComboBoxCell)@class.Cells[this.vmethod_56().Index];
							DataGridViewComboBoxCell dataGridViewComboBoxCell3 = (DataGridViewComboBoxCell)@class.Cells[this.vmethod_58().Index];
							DataGridViewComboBoxCell dataGridViewComboBoxCell4 = (DataGridViewComboBoxCell)@class.Cells[this.vmethod_62().Index];
							Mission.Class289 class2 = (Mission.Class289)@class.Tag;
							ActiveUnit activeUnit_ = null;
							Weapon weapon = null;
							this.method_35(ref dataSource, activeUnit_, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell.Value), class2.int_3);
							List<Mission.Class288> list;
							if (Operators.CompareString(text, "Aircraft #1", false) == 0)
							{
								list = this.waypoint_0.list_3;
							}
							else if (Operators.CompareString(text, "Aircraft #2", false) == 0)
							{
								list = this.waypoint_0.list_4;
							}
							else if (Operators.CompareString(text, "Aircraft #3", false) == 0)
							{
								list = this.waypoint_0.list_5;
							}
							else if (Operators.CompareString(text, "Aircraft #4", false) == 0)
							{
								list = this.waypoint_0.list_6;
							}
							else if (Operators.CompareString(text, "Aircraft #5", false) == 0)
							{
								list = this.waypoint_0.list_7;
							}
							else if (Operators.CompareString(text, "Aircraft #6", false) == 0)
							{
								list = this.waypoint_0.list_8;
							}
							else
							{
								list = this.waypoint_0.list_3;
							}
							this.method_37(ref dataSource2, Conversions.ToInteger(dataGridViewComboBoxCell2.Value), ref list);
							this.method_36(ref dataSource3, Conversions.ToInteger(dataGridViewComboBoxCell3.Value), class2.bool_0);
							this.method_38(ref dataSource4, class2.float_0, class2.float_1, Conversions.ToInteger(dataGridViewComboBoxCell4.Value));
							DataGridViewComboBoxCell dataGridViewComboBoxCell5 = dataGridViewComboBoxCell;
							dataGridViewComboBoxCell5.DataSource = dataSource;
							dataGridViewComboBoxCell5.DisplayMember = "Description";
							dataGridViewComboBoxCell5.ValueMember = "ID";
							DataGridViewComboBoxCell dataGridViewComboBoxCell6 = dataGridViewComboBoxCell4;
							dataGridViewComboBoxCell6.DataSource = dataSource4;
							dataGridViewComboBoxCell6.DisplayMember = "Description";
							dataGridViewComboBoxCell6.ValueMember = "ID";
							DataGridViewComboBoxCell dataGridViewComboBoxCell7 = dataGridViewComboBoxCell3;
							dataGridViewComboBoxCell7.DataSource = dataSource3;
							dataGridViewComboBoxCell7.DisplayMember = "Description";
							dataGridViewComboBoxCell7.ValueMember = "ID";
							DataGridViewComboBoxCell dataGridViewComboBoxCell8 = dataGridViewComboBoxCell2;
							dataGridViewComboBoxCell8.DataSource = dataSource2;
							dataGridViewComboBoxCell8.DisplayMember = "Description";
							dataGridViewComboBoxCell8.ValueMember = "ID";
						}
					}
					finally
					{
						IEnumerator<Class48> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x003AC4F8 File Offset: 0x003AA6F8
		private void method_15(object sender, EventArgs0 e)
		{
			string item = (string)e.method_0().Tag;
			if (e.method_0().method_8() == 1)
			{
				this.list_1.Remove(item);
			}
		}

		// Token: 0x06006B74 RID: 27508 RVA: 0x003AC534 File Offset: 0x003AA734
		private void method_16(object sender, EventArgs0 e)
		{
			string item = (string)e.method_0().Tag;
			if (e.method_0().method_8() == 1)
			{
				this.list_2.Remove(item);
			}
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x003AC570 File Offset: 0x003AA770
		public void method_17()
		{
			try
			{
				this.list_3.Clear();
				if (this.waypoint_0.enum105_0 == Mission.Enum105.const_1)
				{
					if (!this.list_3.Contains("Flight"))
					{
						this.list_3.Add("Flight");
					}
				}
				else if (this.waypoint_0.enum105_0 == Mission.Enum105.const_2)
				{
					if (!this.list_3.Contains("Aircraft #1"))
					{
						this.list_3.Add("Aircraft #1");
					}
					if (this.flight_0._FlightSize_0 > Mission._FlightSize.SingleAircraft && !this.list_3.Contains("Aircraft #2"))
					{
						this.list_3.Add("Aircraft #2");
					}
					if (this.flight_0._FlightSize_0 > Mission._FlightSize.TwoAircraft && !this.list_3.Contains("Aircraft #3"))
					{
						this.list_3.Add("Aircraft #3");
					}
					if (this.flight_0._FlightSize_0 > Mission._FlightSize.ThreeAircraft && !this.list_3.Contains("Aircraft #4"))
					{
						this.list_3.Add("Aircraft #4");
					}
					if (this.flight_0._FlightSize_0 > Mission._FlightSize.FourAircraft && !this.list_3.Contains("Aircraft #5"))
					{
						this.list_3.Add("Aircraft #5");
					}
					if (this.flight_0._FlightSize_0 > Mission._FlightSize.FourAircraft && !this.list_3.Contains("Aircraft #6"))
					{
						this.list_3.Add("Aircraft #6");
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006B76 RID: 27510 RVA: 0x003AC738 File Offset: 0x003AA938
		public void method_18(ActiveUnit activeUnit_0)
		{
			if (!Information.IsNothing(((Aircraft)activeUnit_0).method_167()))
			{
				foreach (WeaponRec weaponRec in ((Aircraft)activeUnit_0).method_167().weaponRec_0)
				{
					Weapon weapon = weaponRec.method_12(Client.smethod_46());
					if (this.method_21(Client.smethod_46(), ref weapon))
					{
						this.list_0.Add(weaponRec);
					}
				}
			}
		}

		// Token: 0x06006B77 RID: 27511 RVA: 0x003AC7A4 File Offset: 0x003AA9A4
		public void method_19(ActiveUnit activeUnit_0)
		{
			IEnumerable<Magazine> enumerable = Enumerable.OrderBy<Magazine, string>(activeUnit_0.vmethod_117(), (FlightPlanEditorTargets._Closure$__.$I180-0 == null) ? (FlightPlanEditorTargets._Closure$__.$I180-0 = new Func<Magazine, string>(FlightPlanEditorTargets._Closure$__.$I.method_0)) : FlightPlanEditorTargets._Closure$__.$I180-0);
			try
			{
				foreach (Magazine magazine in enumerable)
				{
					if (magazine.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
					{
						try
						{
							foreach (WeaponRec weaponRec in magazine.vmethod_10())
							{
								Weapon weapon = weaponRec.method_12(Client.smethod_46());
								if (this.method_21(Client.smethod_46(), ref weapon))
								{
									this.list_0.Add(weaponRec);
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator<Magazine> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06006B78 RID: 27512 RVA: 0x003AC884 File Offset: 0x003AAA84
		public void method_20(ActiveUnit activeUnit_0)
		{
			IEnumerable<Mount> enumerable = Enumerable.OrderBy<Mount, string>(activeUnit_0.vmethod_51(), (FlightPlanEditorTargets._Closure$__.$I181-0 == null) ? (FlightPlanEditorTargets._Closure$__.$I181-0 = new Func<Mount, string>(FlightPlanEditorTargets._Closure$__.$I.method_1)) : FlightPlanEditorTargets._Closure$__.$I181-0);
			try
			{
				foreach (Mount mount in enumerable)
				{
					if (mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
					{
						try
						{
							foreach (WeaponRec weaponRec in mount.vmethod_10())
							{
								Weapon weapon = weaponRec.method_12(Client.smethod_46());
								if (this.method_21(Client.smethod_46(), ref weapon))
								{
									this.list_0.Add(weaponRec);
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator<Mount> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06006B79 RID: 27513 RVA: 0x003AC964 File Offset: 0x003AAB64
		public bool method_21(Scenario scenario_0, ref Weapon weapon_0)
		{
			bool result;
			try
			{
				Strike.StrikeType strikeType_ = ((Strike)this.mission_0).strikeType_0;
				if (strikeType_ != Strike.StrikeType.Land_Strike)
				{
					if (strikeType_ != Strike.StrikeType.Maritime_Strike)
					{
						result = false;
					}
					else if (weapon_0.class394_0.bool_0)
					{
						result = true;
					}
					else
					{
						result = false;
					}
				}
				else if (!weapon_0.class394_0.bool_8 && !weapon_0.class394_0.bool_7 && !weapon_0.class394_0.bool_13 && !weapon_0.class394_0.bool_7 && !weapon_0.class394_0.bool_5 && !weapon_0.class394_0.bool_6)
				{
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06006B7A RID: 27514
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SendMessage(IntPtr intptr_0, int int_1, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x06006B7B RID: 27515 RVA: 0x00043DA0 File Offset: 0x00041FA0
		private void method_22()
		{
			FlightPlanEditorTargets.SendMessage(base.Handle, 11, new IntPtr(0), IntPtr.Zero);
			Class2413.smethod_2().method_41().rightColumnWPF_0.method_0();
		}

		// Token: 0x06006B7C RID: 27516 RVA: 0x00043DCF File Offset: 0x00041FCF
		private void method_23(bool Refresh = true)
		{
			FlightPlanEditorTargets.SendMessage(base.Handle, 11, new IntPtr(-1), IntPtr.Zero);
			if (Refresh)
			{
				this.Refresh();
			}
			Class2413.smethod_2().method_41().rightColumnWPF_0.method_1();
		}

		// Token: 0x06006B7D RID: 27517 RVA: 0x003ACA54 File Offset: 0x003AAC54
		private void method_24(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex != -1)
				{
					if (e.ColumnIndex != -1)
					{
						try
						{
							foreach (Class48 @class in this.vmethod_12().method_2())
							{
								if (@class.Selected)
								{
									break;
								}
								try
								{
									foreach (Class48 class2 in @class.method_7())
									{
										bool selected = class2.Selected;
									}
								}
								finally
								{
									IEnumerator<Class48> enumerator2;
									if (enumerator2 != null)
									{
										enumerator2.Dispose();
									}
								}
							}
						}
						finally
						{
							IEnumerator<Class48> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006B7E RID: 27518 RVA: 0x003ACB4C File Offset: 0x003AAD4C
		private void method_25(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex != -1)
				{
					if (e.ColumnIndex != -1)
					{
						try
						{
							foreach (Class48 @class in this.vmethod_4().method_2())
							{
								if (@class.Selected)
								{
									break;
								}
								string left = (string)@class.Tag;
								try
								{
									foreach (Class48 class2 in @class.method_7())
									{
										if (class2.Selected)
										{
											DataTable dataSource = new DataTable();
											DataTable dataSource2 = new DataTable();
											DataTable dataSource3 = new DataTable();
											DataTable dataSource4 = new DataTable();
											DataGridViewColumn dataGridViewColumn = this.vmethod_4().Columns[e.ColumnIndex];
											if (Operators.CompareString(dataGridViewColumn.Name, "Target", false) != 0)
											{
												if (Operators.CompareString(dataGridViewColumn.Name, "LostTarget", false) != 0)
												{
													if (Operators.CompareString(dataGridViewColumn.Name, "WeaponQty", false) != 0)
													{
														if (Operators.CompareString(dataGridViewColumn.Name, "FiringRange", false) != 0)
														{
															continue;
														}
														if (this.vmethod_4()[this.vmethod_62().Index, class2.method_1()].GetType().ToString().Contains("ComboBoxCell"))
														{
															Mission.Class289 class3 = (Mission.Class289)class2.Tag;
															DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)class2.Cells[this.vmethod_62().Index];
															this.method_38(ref dataSource4, class3.float_0, class3.float_1, Conversions.ToInteger(dataGridViewComboBoxCell.Value));
															DataGridViewComboBoxCell dataGridViewComboBoxCell2 = dataGridViewComboBoxCell;
															dataGridViewComboBoxCell2.DataSource = dataSource4;
															dataGridViewComboBoxCell2.DropDownWidth = 500;
															dataGridViewComboBoxCell2.DisplayMember = "Description";
															dataGridViewComboBoxCell2.ValueMember = "ID";
															this.vmethod_4().BeginEdit(true);
															((DataGridViewComboBoxEditingControl)this.vmethod_4().EditingControl).DroppedDown = true;
														}
													}
													else if (this.vmethod_4()[this.vmethod_60().Index, class2.method_1()].GetType().ToString().Contains("ComboBoxCell"))
													{
														Mission.Class289 class4 = (Mission.Class289)class2.Tag;
														DataGridViewComboBoxCell dataGridViewComboBoxCell3 = (DataGridViewComboBoxCell)class2.Cells[this.vmethod_60().Index];
														ActiveUnit activeUnit_ = null;
														Weapon weapon = null;
														this.method_35(ref dataSource2, activeUnit_, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell3.Value), class4.int_3);
														DataGridViewComboBoxCell dataGridViewComboBoxCell4 = dataGridViewComboBoxCell3;
														dataGridViewComboBoxCell4.DataSource = dataSource2;
														dataGridViewComboBoxCell4.DropDownWidth = 500;
														dataGridViewComboBoxCell4.DisplayMember = "Description";
														dataGridViewComboBoxCell4.ValueMember = "ID";
														this.vmethod_4().BeginEdit(true);
														((DataGridViewComboBoxEditingControl)this.vmethod_4().EditingControl).DroppedDown = true;
													}
												}
												else if (this.vmethod_4()[this.vmethod_58().Index, class2.method_1()].GetType().ToString().Contains("ComboBoxCell"))
												{
													Mission.Class289 class5 = (Mission.Class289)class2.Tag;
													DataGridViewComboBoxCell dataGridViewComboBoxCell5 = (DataGridViewComboBoxCell)class2.Cells[this.vmethod_58().Index];
													this.method_36(ref dataSource3, Conversions.ToInteger(dataGridViewComboBoxCell5.Value), class5.bool_0);
													DataGridViewComboBoxCell dataGridViewComboBoxCell6 = dataGridViewComboBoxCell5;
													dataGridViewComboBoxCell6.DataSource = dataSource3;
													dataGridViewComboBoxCell6.DisplayMember = "Description";
													dataGridViewComboBoxCell6.ValueMember = "ID";
													dataGridViewComboBoxCell6.DropDownWidth = 500;
													this.vmethod_4().BeginEdit(true);
													((DataGridViewComboBoxEditingControl)this.vmethod_4().EditingControl).DroppedDown = true;
												}
											}
											else
											{
												List<Mission.Class288> list;
												if (Operators.CompareString(left, "Aircraft #1", false) == 0)
												{
													list = this.waypoint_0.list_3;
												}
												else if (Operators.CompareString(left, "Aircraft #2", false) == 0)
												{
													list = this.waypoint_0.list_4;
												}
												else if (Operators.CompareString(left, "Aircraft #3", false) == 0)
												{
													list = this.waypoint_0.list_5;
												}
												else if (Operators.CompareString(left, "Aircraft #4", false) == 0)
												{
													list = this.waypoint_0.list_6;
												}
												else if (Operators.CompareString(left, "Aircraft #5", false) == 0)
												{
													list = this.waypoint_0.list_7;
												}
												else if (Operators.CompareString(left, "Aircraft #6", false) == 0)
												{
													list = this.waypoint_0.list_8;
												}
												else
												{
													list = this.waypoint_0.list_3;
												}
												DataGridViewComboBoxCell dataGridViewComboBoxCell7 = (DataGridViewComboBoxCell)class2.Cells[this.vmethod_56().Index];
												this.method_37(ref dataSource, Conversions.ToInteger(dataGridViewComboBoxCell7.Value), ref list);
												DataGridViewComboBoxCell dataGridViewComboBoxCell8 = dataGridViewComboBoxCell7;
												dataGridViewComboBoxCell8.DataSource = dataSource;
												dataGridViewComboBoxCell8.DisplayMember = "Description";
												dataGridViewComboBoxCell8.ValueMember = "ID";
												dataGridViewComboBoxCell8.DropDownWidth = 500;
												this.vmethod_4().BeginEdit(true);
												((DataGridViewComboBoxEditingControl)this.vmethod_4().EditingControl).DroppedDown = true;
											}
											break;
										}
									}
								}
								finally
								{
									IEnumerator<Class48> enumerator2;
									if (enumerator2 != null)
									{
										enumerator2.Dispose();
									}
								}
							}
						}
						finally
						{
							IEnumerator<Class48> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						this.method_39();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006B7F RID: 27519 RVA: 0x003AD0DC File Offset: 0x003AB2DC
		private void method_26(object sender, DataGridViewCellEventArgs e)
		{
			if (this.bool_3 && this.vmethod_12().SelectedRows.Count != 0)
			{
				Class48 class3;
				try
				{
					foreach (Class48 @class in this.vmethod_12().method_2())
					{
						bool flag;
						try
						{
							foreach (Class48 class2 in @class.method_7())
							{
								if (class2.Selected)
								{
									class3 = class2;
									flag = true;
									break;
								}
							}
						}
						finally
						{
							IEnumerator<Class48> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						if (flag)
						{
							break;
						}
					}
				}
				finally
				{
					IEnumerator<Class48> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (!Information.IsNothing(class3) && !Information.IsNothing(class3.method_9()))
				{
					class3.method_9();
				}
			}
		}

		// Token: 0x06006B80 RID: 27520 RVA: 0x003AD1B4 File Offset: 0x003AB3B4
		private void method_27(object sender, DataGridViewCellEventArgs e)
		{
			if (this.bool_3 && this.vmethod_4().SelectedRows.Count != 0)
			{
				Class48 class3;
				try
				{
					foreach (Class48 @class in this.vmethod_4().method_2())
					{
						bool flag;
						try
						{
							foreach (Class48 class2 in @class.method_7())
							{
								if (class2.Selected)
								{
									class3 = class2;
									flag = true;
									break;
								}
							}
						}
						finally
						{
							IEnumerator<Class48> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						if (flag)
						{
							break;
						}
					}
				}
				finally
				{
					IEnumerator<Class48> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (!Information.IsNothing(class3) && !Information.IsNothing(class3.method_9()))
				{
					Class48 class48_ = class3.method_9();
					this.method_28(e, class3, class48_);
				}
			}
		}

		// Token: 0x06006B81 RID: 27521 RVA: 0x003AD298 File Offset: 0x003AB498
		private void method_28(DataGridViewCellEventArgs dataGridViewCellEventArgs_0, Class48 class48_0, Class48 class48_1)
		{
			RuntimeHelpers.GetObjectValue(this.vmethod_4()[dataGridViewCellEventArgs_0.ColumnIndex, dataGridViewCellEventArgs_0.RowIndex].Value);
			object objectValue = RuntimeHelpers.GetObjectValue(this.vmethod_4()[this.vmethod_56().Index, dataGridViewCellEventArgs_0.RowIndex].Value);
			object objectValue2 = RuntimeHelpers.GetObjectValue(this.vmethod_4()[this.vmethod_60().Index, dataGridViewCellEventArgs_0.RowIndex].Value);
			object objectValue3 = RuntimeHelpers.GetObjectValue(this.vmethod_4()[this.vmethod_58().Index, dataGridViewCellEventArgs_0.RowIndex].Value);
			object objectValue4 = RuntimeHelpers.GetObjectValue(this.vmethod_4()[this.vmethod_62().Index, dataGridViewCellEventArgs_0.RowIndex].Value);
			Mission.Class289 @class = (Mission.Class289)class48_0.Tag;
			bool flag;
			Mission.Class288 class2;
			if (dataGridViewCellEventArgs_0.RowIndex != -1 && dataGridViewCellEventArgs_0.ColumnIndex == this.vmethod_56().Index)
			{
				string right = (string)class48_1.Tag;
				try
				{
					foreach (string left in this.list_3)
					{
						if (Operators.CompareString(left, right, false) == 0)
						{
							flag = true;
							List<Mission.Class288> list;
							if (Operators.CompareString(left, "Aircraft #1", false) == 0)
							{
								list = this.waypoint_0.list_3;
							}
							else if (Operators.CompareString(left, "Aircraft #2", false) == 0)
							{
								list = this.waypoint_0.list_4;
							}
							else if (Operators.CompareString(left, "Aircraft #3", false) == 0)
							{
								list = this.waypoint_0.list_5;
							}
							else if (Operators.CompareString(left, "Aircraft #4", false) == 0)
							{
								list = this.waypoint_0.list_6;
							}
							else if (Operators.CompareString(left, "Aircraft #5", false) == 0)
							{
								list = this.waypoint_0.list_7;
							}
							else if (Operators.CompareString(left, "Aircraft #6", false) == 0)
							{
								list = this.waypoint_0.list_8;
							}
							else
							{
								list = this.waypoint_0.list_3;
							}
							class2 = FlightPlanEditorTargets.smethod_3(RuntimeHelpers.GetObjectValue(objectValue), ref list);
							if (Information.IsNothing(class2))
							{
								DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
								DataGridViewTextBoxCell dataGridViewTextBoxCell2 = new DataGridViewTextBoxCell();
								DataGridViewTextBoxCell dataGridViewTextBoxCell3 = new DataGridViewTextBoxCell();
								dataGridViewTextBoxCell.Value = "";
								dataGridViewTextBoxCell2.Value = "";
								dataGridViewTextBoxCell3.Value = "";
								this.vmethod_4()[this.vmethod_60().Index, class48_0.method_1()] = dataGridViewTextBoxCell;
								this.vmethod_4()[this.vmethod_62().Index, class48_0.method_1()] = dataGridViewTextBoxCell3;
								this.vmethod_4()[this.vmethod_58().Index, class48_0.method_1()] = dataGridViewTextBoxCell2;
								dataGridViewTextBoxCell.ReadOnly = true;
								dataGridViewTextBoxCell2.ReadOnly = true;
								dataGridViewTextBoxCell3.ReadOnly = true;
								break;
							}
							Mission.Class289 class3 = (Mission.Class289)class48_0.Tag;
							if (class3._WeaponType_0 == Weapon._WeaponType.GuidedWeapon | class3._WeaponType_0 == Weapon._WeaponType.GuidedProjectile)
							{
								DataGridViewTextBoxCell dataGridViewTextBoxCell4 = new DataGridViewTextBoxCell();
								dataGridViewTextBoxCell4.Value = "";
								this.vmethod_4()[this.vmethod_60().Index, class48_0.method_1()] = dataGridViewTextBoxCell4;
								dataGridViewTextBoxCell4.ReadOnly = true;
							}
							else
							{
								if (this.vmethod_4()[this.vmethod_60().Index, class48_0.method_1()].GetType().ToString().Contains("TextBoxCell"))
								{
									DataGridViewComboBoxCell dataGridViewComboBoxCell = new DataGridViewComboBoxCell();
									this.vmethod_4()[this.vmethod_60().Index, class48_0.method_1()] = dataGridViewComboBoxCell;
									dataGridViewComboBoxCell.ReadOnly = false;
								}
								DataTable dataSource = new DataTable();
								DataGridViewComboBoxCell dataGridViewComboBoxCell2 = (DataGridViewComboBoxCell)class48_0.Cells[this.vmethod_60().Index];
								ActiveUnit activeUnit_ = null;
								Weapon weapon = null;
								this.method_35(ref dataSource, activeUnit_, ref weapon, Conversions.ToInteger(dataGridViewComboBoxCell2.Value), @class.int_3);
								DataGridViewComboBoxCell dataGridViewComboBoxCell3 = dataGridViewComboBoxCell2;
								dataGridViewComboBoxCell3.DataSource = dataSource;
								dataGridViewComboBoxCell3.DisplayMember = "Description";
								dataGridViewComboBoxCell3.ValueMember = "ID";
								class48_0.Cells[this.vmethod_60().Index].Value = FlightPlanEditorTargets.smethod_1(@class.int_2);
							}
							if (this.vmethod_4()[this.vmethod_58().Index, class48_0.method_1()].GetType().ToString().Contains("TextBoxCell"))
							{
								DataGridViewComboBoxCell dataGridViewComboBoxCell4 = new DataGridViewComboBoxCell();
								this.vmethod_4()[this.vmethod_58().Index, class48_0.method_1()] = dataGridViewComboBoxCell4;
								dataGridViewComboBoxCell4.ReadOnly = false;
							}
							if (this.vmethod_4()[this.vmethod_62().Index, class48_0.method_1()].GetType().ToString().Contains("TextBoxCell"))
							{
								DataGridViewComboBoxCell dataGridViewComboBoxCell5 = new DataGridViewComboBoxCell();
								this.vmethod_4()[this.vmethod_62().Index, class48_0.method_1()] = dataGridViewComboBoxCell5;
								dataGridViewComboBoxCell5.ReadOnly = false;
							}
							DataTable dataSource2 = new DataTable();
							DataTable dataSource3 = new DataTable();
							DataGridViewComboBoxCell dataGridViewComboBoxCell6 = (DataGridViewComboBoxCell)class48_0.Cells[this.vmethod_58().Index];
							DataGridViewComboBoxCell dataGridViewComboBoxCell7 = (DataGridViewComboBoxCell)class48_0.Cells[this.vmethod_62().Index];
							this.method_36(ref dataSource2, Conversions.ToInteger(dataGridViewComboBoxCell6.Value), @class.bool_0);
							this.method_38(ref dataSource3, @class.float_0, @class.float_1, Conversions.ToInteger(dataGridViewComboBoxCell7.Value));
							DataGridViewComboBoxCell dataGridViewComboBoxCell8 = dataGridViewComboBoxCell7;
							dataGridViewComboBoxCell8.DataSource = dataSource3;
							dataGridViewComboBoxCell8.DisplayMember = "Description";
							dataGridViewComboBoxCell8.ValueMember = "ID";
							DataGridViewComboBoxCell dataGridViewComboBoxCell9 = dataGridViewComboBoxCell6;
							dataGridViewComboBoxCell9.DataSource = dataSource2;
							dataGridViewComboBoxCell9.DisplayMember = "Description";
							dataGridViewComboBoxCell9.ValueMember = "ID";
							class48_0.Cells[this.vmethod_58().Index].Value = @class.int_1;
							class48_0.Cells[this.vmethod_62().Index].Value = FlightPlanEditorTargets.smethod_6(@class.int_4);
							break;
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			bool flag2;
			int int_;
			if (dataGridViewCellEventArgs_0.RowIndex != -1 && dataGridViewCellEventArgs_0.ColumnIndex == this.vmethod_60().Index)
			{
				flag2 = true;
				int_ = FlightPlanEditorTargets.smethod_0(RuntimeHelpers.GetObjectValue(objectValue2));
			}
			bool flag3;
			int int_2;
			if (dataGridViewCellEventArgs_0.RowIndex != -1 && dataGridViewCellEventArgs_0.ColumnIndex == this.vmethod_62().Index)
			{
				flag3 = true;
				int_2 = FlightPlanEditorTargets.smethod_5(RuntimeHelpers.GetObjectValue(objectValue4));
			}
			bool flag4;
			int int_3;
			if (dataGridViewCellEventArgs_0.RowIndex != -1 && dataGridViewCellEventArgs_0.ColumnIndex == this.vmethod_58().Index)
			{
				flag4 = true;
				int_3 = (int)FlightPlanEditorTargets.smethod_2(RuntimeHelpers.GetObjectValue(objectValue3));
			}
			if (!Information.IsNothing(@class))
			{
				if (flag)
				{
					if (!Information.IsNothing(class2))
					{
						@class.string_1 = class2.string_0;
						return;
					}
					@class.string_1 = "";
					return;
				}
				else
				{
					if (flag2)
					{
						@class.int_2 = int_;
						return;
					}
					if (flag4)
					{
						@class.int_1 = int_3;
						return;
					}
					if (flag3)
					{
						@class.int_4 = int_2;
					}
				}
			}
		}

		// Token: 0x06006B82 RID: 27522 RVA: 0x00043E07 File Offset: 0x00042007
		private void method_29(object sender, EventArgs e)
		{
			this.bool_3 = true;
			if (this.vmethod_12().IsCurrentCellDirty)
			{
				this.vmethod_12().CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		// Token: 0x06006B83 RID: 27523 RVA: 0x00043E2E File Offset: 0x0004202E
		private void method_30(object sender, EventArgs e)
		{
			this.bool_3 = true;
			if (this.vmethod_4().IsCurrentCellDirty)
			{
				this.vmethod_4().CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		// Token: 0x06006B84 RID: 27524 RVA: 0x003AD9A0 File Offset: 0x003ABBA0
		private void method_31(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && this.mission_0._MissionClass_0 == Mission._MissionClass.Strike)
			{
				if (Information.IsNothing(this.string_0))
				{
					this.string_0 = "Aircraft #1";
				}
				if (!this.list_1.Contains(this.string_0))
				{
					this.list_1.Add(this.string_0);
				}
				Waypoint waypoint;
				if (Operators.CompareString(this.string_0, "Aircraft #1", false) == 0)
				{
					waypoint = this.waypoint_0;
				}
				else if (Operators.CompareString(this.string_0, "Aircraft #2", false) == 0)
				{
					waypoint = this.waypoint_0.waypoint_0;
				}
				else if (Operators.CompareString(this.string_0, "Aircraft #3", false) == 0)
				{
					waypoint = this.waypoint_0.waypoint_1;
				}
				else if (Operators.CompareString(this.string_0, "Aircraft #4", false) == 0)
				{
					waypoint = this.waypoint_0.waypoint_2;
				}
				else if (Operators.CompareString(this.string_0, "Aircraft #5", false) == 0)
				{
					waypoint = this.waypoint_0.waypoint_3;
				}
				else if (Operators.CompareString(this.string_0, "Aircraft #6", false) == 0)
				{
					waypoint = this.waypoint_0.waypoint_4;
				}
				else
				{
					waypoint = this.waypoint_0;
				}
				try
				{
					foreach (Unit unit in Client.smethod_50().method_56())
					{
						if (unit.vmethod_7(false) != Client.smethod_50() && !Client.smethod_50().method_67(unit.vmethod_7(false)))
						{
							if (unit.bool_1)
							{
								try
								{
									foreach (ActiveUnit activeUnit in ((Group)unit).vmethod_141().Values)
									{
										bool flag = false;
										try
										{
											List<Mission.Class288>.Enumerator enumerator3 = waypoint.list_3.GetEnumerator();
											while (enumerator3.MoveNext())
											{
												if (Operators.CompareString(enumerator3.Current.string_3, activeUnit.string_0, false) == 0)
												{
													flag = true;
													break;
												}
											}
											goto IL_25E;
										}
										finally
										{
											List<Mission.Class288>.Enumerator enumerator3;
											((IDisposable)enumerator3).Dispose();
										}
										IL_1F1:
										Mission.Class288 item = new Mission.Class288(Guid.NewGuid().ToString(), 0, activeUnit.Name, "", activeUnit.string_0, activeUnit.DBID, activeUnit.vmethod_30(null), activeUnit.vmethod_28(null), null, null, null);
										waypoint.list_3.Add(item);
										continue;
										IL_25E:
										if (!flag)
										{
											goto IL_1F1;
										}
									}
								}
								finally
								{
									IEnumerator<ActiveUnit> enumerator2;
									if (enumerator2 != null)
									{
										enumerator2.Dispose();
									}
								}
								if (this.mission_0.method_12() && Client.smethod_50().method_68(unit.vmethod_7(false)) != Misc.PostureStance.Hostile)
								{
									Client.smethod_50().method_69(unit.vmethod_7(false), Misc.PostureStance.Hostile);
								}
							}
							else if (unit.bool_0)
							{
								bool flag2 = false;
								try
								{
									List<Mission.Class288>.Enumerator enumerator4 = waypoint.list_3.GetEnumerator();
									while (enumerator4.MoveNext())
									{
										if (Operators.CompareString(enumerator4.Current.string_3, unit.string_0, false) == 0)
										{
											flag2 = true;
											break;
										}
									}
								}
								finally
								{
									List<Mission.Class288>.Enumerator enumerator4;
									((IDisposable)enumerator4).Dispose();
								}
								if (!flag2)
								{
									Mission.Class288 item2 = new Mission.Class288(Guid.NewGuid().ToString(), 0, unit.Name, "", ((ActiveUnit)unit).string_0, ((ActiveUnit)unit).DBID, unit.vmethod_30(null), unit.vmethod_28(null), null, null, null);
									waypoint.list_3.Add(item2);
								}
								if (this.mission_0.method_12() && Client.smethod_50().method_68(unit.vmethod_7(false)) != Misc.PostureStance.Hostile)
								{
									Client.smethod_50().method_69(unit.vmethod_7(false), Misc.PostureStance.Hostile);
								}
							}
							else
							{
								Contact contact = (Contact)unit;
								if (!Information.IsNothing(contact.activeUnit_0) && Client.smethod_50().method_12().ContainsKey(contact.activeUnit_0.string_0))
								{
									try
									{
										foreach (ActiveUnit activeUnit2 in ((Group)contact.activeUnit_0).vmethod_141().Values)
										{
											bool flag3 = false;
											try
											{
												foreach (Mission.Class288 @class in waypoint.list_3)
												{
													if (Operators.CompareString(@class.string_2, contact.string_0, false) == 0 || Operators.CompareString(@class.string_3, contact.activeUnit_0.string_0, false) == 0)
													{
														flag3 = true;
														break;
													}
												}
												goto IL_4FC;
											}
											finally
											{
												List<Mission.Class288>.Enumerator enumerator6;
												((IDisposable)enumerator6).Dispose();
											}
											IL_48D:
											Mission.Class288 item3 = new Mission.Class288(Guid.NewGuid().ToString(), 0, contact.Name, contact.string_0, activeUnit2.string_0, activeUnit2.DBID, contact.vmethod_30(null), contact.vmethod_28(null), null, null, null);
											waypoint.list_3.Add(item3);
											continue;
											IL_4FC:
											if (!flag3)
											{
												goto IL_48D;
											}
										}
										goto IL_618;
									}
									finally
									{
										IEnumerator<ActiveUnit> enumerator5;
										if (enumerator5 != null)
										{
											enumerator5.Dispose();
										}
									}
								}
								if (Client.smethod_50().method_12().ContainsKey(contact.activeUnit_0.string_0))
								{
									continue;
								}
								bool flag4 = false;
								try
								{
									foreach (Mission.Class288 class2 in waypoint.list_3)
									{
										if (Operators.CompareString(class2.string_2, contact.string_0, false) == 0 || Operators.CompareString(class2.string_3, contact.activeUnit_0.string_0, false) == 0)
										{
											flag4 = true;
											break;
										}
									}
								}
								finally
								{
									List<Mission.Class288>.Enumerator enumerator7;
									((IDisposable)enumerator7).Dispose();
								}
								if (!flag4)
								{
									Mission.Class288 item4 = new Mission.Class288(Guid.NewGuid().ToString(), 0, contact.Name, contact.string_0, contact.activeUnit_0.string_0, contact.activeUnit_0.DBID, contact.vmethod_30(null), contact.vmethod_28(null), null, null, null);
									waypoint.list_3.Add(item4);
								}
								IL_618:
								if (this.mission_0.method_12() && contact.method_130(Client.smethod_50()) != Misc.PostureStance.Hostile)
								{
									contact.method_131(Client.smethod_50(), false, Misc.PostureStance.Hostile);
								}
							}
							try
							{
								foreach (Class48 class3 in this.vmethod_12().method_2())
								{
									try
									{
										if (Operators.CompareString((string)class3.Tag, this.string_0, false) == 0)
										{
											class3.vmethod_4();
										}
									}
									catch (Exception ex)
									{
										ex.Data.Add("Error at 999999", ex.Message);
										GameGeneral.smethod_25(ref ex);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
									}
								}
							}
							finally
							{
								IEnumerator<Class48> enumerator8;
								if (enumerator8 != null)
								{
									enumerator8.Dispose();
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator<Unit> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				this.method_10(false, false);
				this.mission_0.int_0 = 0;
				Client.bool_1 = true;
			}
		}

		// Token: 0x06006B85 RID: 27525 RVA: 0x00043E55 File Offset: 0x00042055
		private void method_32(object sender, EventArgs e)
		{
			Client.smethod_24().Show();
		}

		// Token: 0x06006B86 RID: 27526 RVA: 0x00043E61 File Offset: 0x00042061
		private void method_33(object sender, EventArgs e)
		{
			Client.smethod_23().Show();
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x00043E61 File Offset: 0x00042061
		private void method_34(object sender, EventArgs e)
		{
			Client.smethod_23().Show();
		}

		// Token: 0x06006B88 RID: 27528 RVA: 0x003AE190 File Offset: 0x003AC390
		public void method_35(ref DataTable dataTable_0, ActiveUnit activeUnit_0, ref Weapon weapon_0, int int_1, int int_2)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			dataTable_0.Rows.Add(new object[]
			{
				0,
				"Use WRA"
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				"All weapons"
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				"Do not use weapons"
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				"1 rnd"
			});
			if (int_2 >= 2)
			{
				dataTable_0.Rows.Add(new object[]
				{
					4,
					"2 rnds"
				});
				if (int_2 >= 3)
				{
					dataTable_0.Rows.Add(new object[]
					{
						5,
						"3 rnds"
					});
					if (int_2 >= 4)
					{
						dataTable_0.Rows.Add(new object[]
						{
							6,
							"4 rnds"
						});
						if (int_2 >= 5)
						{
							dataTable_0.Rows.Add(new object[]
							{
								7,
								"5 rnds"
							});
							if (int_2 >= 6)
							{
								dataTable_0.Rows.Add(new object[]
								{
									8,
									"6 rnds"
								});
								if (int_2 >= 7)
								{
									dataTable_0.Rows.Add(new object[]
									{
										9,
										"7 rnds"
									});
									if (int_2 >= 8)
									{
										dataTable_0.Rows.Add(new object[]
										{
											10,
											"8 rnds"
										});
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06006B89 RID: 27529 RVA: 0x003AE3B8 File Offset: 0x003AC5B8
		public static int smethod_0(object object_0)
		{
			int result;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 0:
					result = -99;
					break;
				case 1:
					result = -98;
					break;
				case 2:
					result = -97;
					break;
				case 3:
					result = 1;
					break;
				case 4:
					result = 2;
					break;
				case 5:
					result = 3;
					break;
				case 6:
					result = 4;
					break;
				case 7:
					result = 5;
					break;
				case 8:
					result = 6;
					break;
				case 9:
					result = 7;
					break;
				default:
					result = -99;
					break;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06006B8A RID: 27530 RVA: 0x003AE474 File Offset: 0x003AC674
		public static int smethod_1(int int_1)
		{
			int result;
			try
			{
				switch (int_1)
				{
				case -99:
					result = 0;
					break;
				case -98:
					result = 1;
					break;
				case -97:
					result = 2;
					break;
				default:
					switch (int_1)
					{
					case 1:
						result = 3;
						break;
					case 2:
						result = 4;
						break;
					case 3:
						result = 5;
						break;
					case 4:
						result = 6;
						break;
					case 5:
						result = 7;
						break;
					case 6:
						result = 8;
						break;
					case 7:
						result = 9;
						break;
					case 8:
						result = 10;
						break;
					default:
						result = 0;
						break;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06006B8B RID: 27531 RVA: 0x003AE53C File Offset: 0x003AC73C
		public void method_36(ref DataTable dataTable_0, int int_1, bool bool_4)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			if (((Strike)this.mission_0).strikeType_0 == Strike.StrikeType.Maritime_Strike && bool_4)
			{
				dataTable_0.Rows.Add(new object[]
				{
					0,
					"BOL on last known coordinate"
				});
			}
			else
			{
				dataTable_0.Rows.Add(new object[]
				{
					0,
					"Expend ordnance on last known coordinate"
				});
			}
			switch (this.waypoint_0.enum105_0)
			{
			case Mission.Enum105.const_0:
				if (((Strike)this.mission_0).strikeType_0 == Strike.StrikeType.Maritime_Strike && bool_4)
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Find new target in mission's target list if possible, otherwise BOL on last known coordinate"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Find new target in mission's target list if possible, otherwise expend ordnance on last known coordinate"
					});
				}
				break;
			case Mission.Enum105.const_1:
				if (((Strike)this.mission_0).strikeType_0 == Strike.StrikeType.Maritime_Strike && bool_4)
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Find new target in flight's target list if possible, otherwise BOL on last known coordinate"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Find new target in flight's target list if possible, otherwise expend ordnance on last known coordinate"
					});
				}
				break;
			case Mission.Enum105.const_2:
				if (((Strike)this.mission_0).strikeType_0 == Strike.StrikeType.Maritime_Strike && bool_4)
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Find new target in aircraft's target list if possible, otherwise BOL on last known coordinate"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"Find new target in aircraft's target list if possible, otherwise expend ordnance on last known coordinate"
					});
				}
				break;
			}
			dataTable_0.Rows.Add(new object[]
			{
				2,
				"Bring back og jettison ordnance depending on mission setting"
			});
			switch (this.waypoint_0.enum105_0)
			{
			case Mission.Enum105.const_0:
				dataTable_0.Rows.Add(new object[]
				{
					1,
					"Find new target in mission's target list if possible, otherwise bring back og jettison ordnance depending on mission setting"
				});
				return;
			case Mission.Enum105.const_1:
				dataTable_0.Rows.Add(new object[]
				{
					1,
					"Find new target in flight's target list if possible, otherwise bring back og jettison ordnance depending on mission setting"
				});
				return;
			case Mission.Enum105.const_2:
				dataTable_0.Rows.Add(new object[]
				{
					1,
					"Find new target in aircraft's target list if possible, otherwise bring back og jettison ordnance depending on mission setting"
				});
				return;
			default:
				return;
			}
		}

		// Token: 0x06006B8C RID: 27532 RVA: 0x003AE808 File Offset: 0x003ACA08
		public static FlightPlanEditorTargets.Enum201 smethod_2(object object_0)
		{
			FlightPlanEditorTargets.Enum201 result;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 0:
					result = FlightPlanEditorTargets.Enum201.const_0;
					break;
				case 1:
					result = FlightPlanEditorTargets.Enum201.const_1;
					break;
				case 2:
					result = FlightPlanEditorTargets.Enum201.const_2;
					break;
				case 3:
					result = FlightPlanEditorTargets.Enum201.const_3;
					break;
				default:
					result = FlightPlanEditorTargets.Enum201.const_0;
					break;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = FlightPlanEditorTargets.Enum201.const_0;
			}
			return result;
		}

		// Token: 0x06006B8D RID: 27533 RVA: 0x003AE890 File Offset: 0x003ACA90
		public void method_37(ref DataTable dataTable_0, int int_1, ref List<Mission.Class288> list_4)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			dataTable_0.Rows.Add(new object[]
			{
				0,
				"No target selected (weapon will not be used)"
			});
			if (!Information.IsNothing(list_4) && list_4.Count != 0)
			{
				int num = list_4.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					Mission.Class288 @class = list_4[i];
					dataTable_0.Rows.Add(new object[]
					{
						i + 1,
						@class.string_1
					});
				}
			}
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x003AE978 File Offset: 0x003ACB78
		public static Mission.Class288 smethod_3(object object_0, ref List<Mission.Class288> list_4)
		{
			Mission.Class288 result;
			try
			{
				int num = (int)object_0;
				if (num == 0)
				{
					result = null;
				}
				else if (list_4.Count >= num)
				{
					result = list_4[num - 1];
				}
				else
				{
					result = null;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x003AE9F8 File Offset: 0x003ACBF8
		public static int smethod_4(string string_1, ref List<Mission.Class288> list_4)
		{
			int result;
			try
			{
				if (!Information.IsNothing(list_4) && list_4.Count != 0)
				{
					int num = list_4.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(list_4[i].string_0, string_1, false) == 0)
						{
							return i + 1;
						}
					}
					result = 0;
				}
				else
				{
					result = 0;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06006B90 RID: 27536 RVA: 0x003AEA9C File Offset: 0x003ACC9C
		public void method_38(ref DataTable dataTable_0, float float_0, float float_1, int int_1)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			dataTable_0.Rows.Add(new object[]
			{
				0,
				"Max Range"
			});
			if (float_0 > 2f && float_1 < 2f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					1,
					" 2 nm"
				});
			}
			if (float_0 > 5f && float_1 < 5f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					2,
					" 5 nm"
				});
			}
			if (float_0 > 10f && float_1 < 10f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					3,
					"10 nm"
				});
			}
			if (float_0 > 15f && float_1 < 15f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					4,
					"15 nm"
				});
			}
			if (float_0 > 20f && float_1 < 20f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					5,
					"20 nm"
				});
			}
			if (float_0 > 25f && float_1 < 25f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					6,
					"25 nm"
				});
			}
			if (float_0 > 30f && float_1 < 30f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					7,
					"30 nm"
				});
			}
			if (float_0 > 35f && float_1 < 35f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					8,
					"35 nm"
				});
			}
			if (float_0 > 40f && float_1 < 40f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					9,
					"40 nm"
				});
			}
			if (float_0 > 45f && float_1 < 45f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					10,
					"45 nm"
				});
			}
			if (float_0 > 50f && float_1 < 50f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					11,
					"50 nm"
				});
			}
			if (float_0 > 60f && float_1 < 60f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					12,
					"60 nm"
				});
			}
			if (float_0 > 70f && float_1 < 70f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					13,
					"70 nm"
				});
			}
			if (float_0 > 80f && float_1 < 80f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					14,
					"80 nm"
				});
			}
			if (float_0 > 90f && float_1 < 90f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					15,
					"90 nm"
				});
			}
			if (float_0 > 100f && float_1 < 100f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					16,
					"100 nm"
				});
			}
			if (float_0 > 125f && float_1 < 125f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					17,
					"125 nm"
				});
			}
			if (float_0 > 150f && float_1 < 150f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					18,
					"150 nm"
				});
			}
			if (float_0 > 175f && float_1 < 175f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					19,
					"175 nm"
				});
			}
			if (float_0 > 200f && float_1 < 200f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					20,
					"200 nm"
				});
			}
			if (float_0 > 250f && float_1 < 250f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					21,
					"250 nm"
				});
			}
			if (float_0 > 300f && float_1 < 300f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					22,
					"300 nm"
				});
			}
			if (float_0 > 500f && float_1 < 500f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					23,
					"500 nm"
				});
			}
			if (float_0 > 750f && float_1 < 750f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					24,
					"750 nm"
				});
			}
			if (float_0 > 1000f && float_1 < 1000f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					25,
					"1000 nm"
				});
			}
			if (float_0 > 1500f && float_1 < 1500f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					26,
					"1500 nm"
				});
			}
			if (float_0 > 2000f && float_1 < 2000f)
			{
				dataTable_0.Rows.Add(new object[]
				{
					27,
					"2000 nm"
				});
			}
		}

		// Token: 0x06006B91 RID: 27537 RVA: 0x003AF0BC File Offset: 0x003AD2BC
		public static int smethod_5(object object_0)
		{
			int result;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 0:
					result = 0;
					break;
				case 1:
					result = 1;
					break;
				case 2:
					result = 2;
					break;
				case 3:
					result = 3;
					break;
				case 4:
					result = 4;
					break;
				case 5:
					result = 5;
					break;
				case 6:
					result = 6;
					break;
				case 7:
					result = 7;
					break;
				case 8:
					result = 8;
					break;
				case 9:
					result = 9;
					break;
				case 10:
					result = 10;
					break;
				case 11:
					result = 11;
					break;
				case 12:
					result = 12;
					break;
				case 13:
					result = 13;
					break;
				case 14:
					result = 14;
					break;
				case 15:
					result = 15;
					break;
				case 16:
					result = 16;
					break;
				case 17:
					result = 17;
					break;
				case 18:
					result = 18;
					break;
				case 19:
					result = 19;
					break;
				case 20:
					result = 20;
					break;
				case 21:
					result = 21;
					break;
				case 22:
					result = 22;
					break;
				case 23:
					result = 23;
					break;
				case 24:
					result = 24;
					break;
				case 25:
					result = 25;
					break;
				case 26:
					result = 26;
					break;
				case 27:
					result = 27;
					break;
				default:
					result = 0;
					break;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06006B92 RID: 27538 RVA: 0x003AF24C File Offset: 0x003AD44C
		public static int smethod_6(int int_1)
		{
			int result;
			try
			{
				switch (int_1)
				{
				case 0:
					result = 0;
					break;
				case 1:
					result = 1;
					break;
				case 2:
					result = 2;
					break;
				case 3:
					result = 3;
					break;
				case 4:
					result = 4;
					break;
				case 5:
					result = 5;
					break;
				case 6:
					result = 6;
					break;
				case 7:
					result = 7;
					break;
				case 8:
					result = 8;
					break;
				case 9:
					result = 9;
					break;
				case 10:
					result = 10;
					break;
				case 11:
					result = 11;
					break;
				case 12:
					result = 12;
					break;
				case 13:
					result = 13;
					break;
				case 14:
					result = 14;
					break;
				case 15:
					result = 15;
					break;
				case 16:
					result = 16;
					break;
				case 17:
					result = 17;
					break;
				case 18:
					result = 18;
					break;
				case 19:
					result = 19;
					break;
				case 20:
					result = 20;
					break;
				case 21:
					result = 21;
					break;
				case 22:
					result = 22;
					break;
				case 23:
					result = 23;
					break;
				case 24:
					result = 24;
					break;
				case 25:
					result = 25;
					break;
				case 26:
					result = 26;
					break;
				case 27:
					result = 27;
					break;
				default:
					result = 0;
					break;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x003AF3D8 File Offset: 0x003AD5D8
		public static string smethod_7(Mission.Enum105 enum105_0, Mission.Enum88 enum88_0)
		{
			string result;
			switch (enum105_0)
			{
			case Mission.Enum105.const_0:
				if (enum88_0 == Mission.Enum88.const_1)
				{
					result = "Use package targets";
				}
				else
				{
					result = "Use mission targets";
				}
				break;
			case Mission.Enum105.const_1:
				result = "Use flight targets";
				break;
			case Mission.Enum105.const_2:
				result = "Use individual targets (per-aircraft basis)";
				break;
			default:
				result = "None";
				break;
			}
			return result;
		}

		// Token: 0x06006B94 RID: 27540 RVA: 0x003AF424 File Offset: 0x003AD624
		public static void smethod_8(ref DataTable dataTable_0, Mission.Enum88 enum88_0)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			dataTable_0.Rows.Add(new object[]
			{
				0,
				FlightPlanEditorTargets.smethod_7(Mission.Enum105.const_0, enum88_0)
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				FlightPlanEditorTargets.smethod_7(Mission.Enum105.const_1, enum88_0)
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				FlightPlanEditorTargets.smethod_7(Mission.Enum105.const_2, enum88_0)
			});
		}

		// Token: 0x06006B95 RID: 27541 RVA: 0x003AF504 File Offset: 0x003AD704
		public static Mission.Enum105 smethod_9(int int_1)
		{
			Mission.Enum105 result;
			try
			{
				switch (int_1)
				{
				case 0:
					result = Mission.Enum105.const_0;
					break;
				case 1:
					result = Mission.Enum105.const_1;
					break;
				case 2:
					result = Mission.Enum105.const_2;
					break;
				default:
					result = Mission.Enum105.const_0;
					break;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Mission.Enum105.const_0;
			}
			return result;
		}

		// Token: 0x06006B96 RID: 27542 RVA: 0x003AF580 File Offset: 0x003AD780
		public static int smethod_10(int int_1)
		{
			int result;
			try
			{
				switch (int_1)
				{
				case 0:
					result = 0;
					break;
				case 1:
					result = 1;
					break;
				case 2:
					result = 2;
					break;
				default:
					result = 0;
					break;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06006B97 RID: 27543 RVA: 0x0039ADF4 File Offset: 0x00398FF4
		private void FlightPlanEditorTargets_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Hide();
				return;
			}
			if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06006B98 RID: 27544 RVA: 0x003AF5FC File Offset: 0x003AD7FC
		private void method_39()
		{
			try
			{
				if (!Information.IsNothing(this.flight_0) && !Information.IsNothing(this.mission_0) && !Information.IsNothing(this.waypoint_1) && !Information.IsNothing(this.waypoint_0))
				{
					switch (this.waypoint_0.enum105_0)
					{
					case Mission.Enum105.const_0:
						this.vmethod_8().Enabled = true;
						this.vmethod_36().Enabled = false;
						this.vmethod_32().Enabled = false;
						this.vmethod_22().Enabled = false;
						this.vmethod_20().Enabled = false;
						this.vmethod_26().Enabled = false;
						this.vmethod_24().Enabled = false;
						this.vmethod_16().Enabled = false;
						this.vmethod_14().Enabled = false;
						this.vmethod_18().Enabled = false;
						this.vmethod_30().Enabled = false;
						this.vmethod_28().Enabled = false;
						this.vmethod_34().Enabled = false;
						this.vmethod_6().Enabled = false;
						this.vmethod_40().Enabled = false;
						this.vmethod_66().Enabled = false;
						break;
					case Mission.Enum105.const_1:
						this.vmethod_8().Enabled = true;
						this.vmethod_36().Enabled = true;
						this.vmethod_32().Enabled = true;
						this.vmethod_22().Enabled = false;
						this.vmethod_20().Enabled = false;
						this.vmethod_26().Enabled = false;
						this.vmethod_24().Enabled = false;
						this.vmethod_16().Enabled = false;
						this.vmethod_14().Enabled = false;
						this.vmethod_18().Enabled = false;
						this.vmethod_30().Enabled = false;
						this.vmethod_28().Enabled = false;
						this.vmethod_34().Enabled = false;
						this.vmethod_6().Enabled = false;
						this.vmethod_40().Enabled = false;
						this.vmethod_66().Enabled = false;
						break;
					case Mission.Enum105.const_2:
						this.vmethod_8().Enabled = true;
						this.vmethod_36().Enabled = true;
						this.vmethod_32().Enabled = true;
						this.vmethod_22().Enabled = true;
						this.vmethod_20().Enabled = true;
						this.vmethod_26().Enabled = true;
						this.vmethod_24().Enabled = true;
						this.vmethod_16().Enabled = true;
						this.vmethod_14().Enabled = true;
						this.vmethod_18().Enabled = true;
						this.vmethod_30().Enabled = true;
						this.vmethod_28().Enabled = true;
						this.vmethod_34().Enabled = true;
						this.vmethod_6().Enabled = true;
						if (this.vmethod_4().SelectedRows.Count > 0)
						{
							string left = "";
							Class48 class3;
							try
							{
								foreach (Class48 @class in this.vmethod_4().method_2())
								{
									bool flag;
									try
									{
										foreach (Class48 class2 in @class.method_7())
										{
											if (class2.Selected)
											{
												left = (string)@class.Tag;
												class3 = class2;
												flag = true;
												break;
											}
										}
									}
									finally
									{
										IEnumerator<Class48> enumerator2;
										if (enumerator2 != null)
										{
											enumerator2.Dispose();
										}
									}
									if (flag)
									{
										break;
									}
								}
							}
							finally
							{
								IEnumerator<Class48> enumerator;
								if (enumerator != null)
								{
									enumerator.Dispose();
								}
							}
							if (!Information.IsNothing(class3) && !Information.IsNothing(class3.method_9()))
							{
								Mission.Class289 class4 = (Mission.Class289)class3.Tag;
								if (!Information.IsNothing(class4))
								{
									if (Information.IsNothing(class4.waypoint_0))
									{
										this.vmethod_40().Enabled = false;
									}
									else
									{
										this.vmethod_40().Enabled = true;
									}
									if (this.waypoint_0.enum83_0 == Waypoint.Enum83.const_2)
									{
										this.vmethod_66().Enabled = true;
									}
									else
									{
										Mission.Flight.Enum106 @enum;
										if (Operators.CompareString(left, "Aircraft #1", false) == 0)
										{
											@enum = Mission.Flight.Enum106.const_1;
										}
										else if (Operators.CompareString(left, "Aircraft #2", false) == 0)
										{
											@enum = Mission.Flight.Enum106.const_2;
										}
										else if (Operators.CompareString(left, "Aircraft #3", false) == 0)
										{
											@enum = Mission.Flight.Enum106.const_3;
										}
										else if (Operators.CompareString(left, "Aircraft #4", false) == 0)
										{
											@enum = Mission.Flight.Enum106.const_4;
										}
										else if (Operators.CompareString(left, "Aircraft #5", false) == 0)
										{
											@enum = Mission.Flight.Enum106.const_5;
										}
										else if (Operators.CompareString(left, "Aircraft #6", false) == 0)
										{
											@enum = Mission.Flight.Enum106.const_6;
										}
										else
										{
											@enum = Mission.Flight.Enum106.const_1;
										}
										if (@enum == Mission.Flight.Enum106.const_1)
										{
											this.vmethod_66().Enabled = true;
										}
										else
										{
											this.vmethod_66().Enabled = false;
										}
									}
								}
								else
								{
									this.vmethod_40().Enabled = false;
									this.vmethod_66().Enabled = false;
								}
							}
							else
							{
								this.vmethod_40().Enabled = false;
								this.vmethod_66().Enabled = false;
							}
						}
						break;
					}
				}
				else
				{
					this.vmethod_8().Enabled = false;
					this.vmethod_36().Enabled = false;
					this.vmethod_32().Enabled = false;
					this.vmethod_22().Enabled = false;
					this.vmethod_20().Enabled = false;
					this.vmethod_26().Enabled = false;
					this.vmethod_24().Enabled = false;
					this.vmethod_16().Enabled = false;
					this.vmethod_14().Enabled = false;
					this.vmethod_18().Enabled = false;
					this.vmethod_30().Enabled = false;
					this.vmethod_28().Enabled = false;
					this.vmethod_34().Enabled = false;
					this.vmethod_6().Enabled = false;
					this.vmethod_40().Enabled = false;
					this.vmethod_66().Enabled = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006B99 RID: 27545 RVA: 0x003AFBD8 File Offset: 0x003ADDD8
		private void method_40(object sender, EventArgs e)
		{
			Class48 class3;
			try
			{
				foreach (Class48 @class in this.vmethod_4().method_2())
				{
					if (@class.Selected)
					{
						return;
					}
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected)
							{
								class3 = class2;
							}
						}
					}
					finally
					{
						IEnumerator<Class48> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator<Class48> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			if (!Information.IsNothing(class3))
			{
				Mission.Class289 class4 = (Mission.Class289)class3.Tag;
				if (!Information.IsNothing(class4))
				{
					if (Information.IsNothing(class4.waypoint_0))
					{
						Interaction.MsgBox("Weapon route does not exist!", MsgBoxStyle.OkOnly, null);
					}
					Client.smethod_25().waypoint_0 = class4.waypoint_0;
					FlightPlanEditorWeaponRoute flightPlanEditorWeaponRoute = Client.smethod_25();
					Scenario scenario = Client.smethod_46();
					flightPlanEditorWeaponRoute.weapon_0 = Weapon.smethod_16(ref scenario, class4.int_0, null);
					if (Client.smethod_25().Visible)
					{
						Client.smethod_25().method_2();
						Client.smethod_25().BringToFront();
						return;
					}
					Client.smethod_25().Show();
				}
			}
		}

		// Token: 0x06006B9A RID: 27546 RVA: 0x003AFD0C File Offset: 0x003ADF0C
		private void method_41(object sender, EventArgs e)
		{
			if (this.vmethod_4().SelectedRows.Count > 0)
			{
				string left = "";
				Class48 class3;
				try
				{
					foreach (Class48 @class in this.vmethod_4().method_2())
					{
						bool flag;
						try
						{
							foreach (Class48 class2 in @class.method_7())
							{
								if (class2.Selected)
								{
									left = (string)@class.Tag;
									class3 = class2;
									flag = true;
									break;
								}
							}
						}
						finally
						{
							IEnumerator<Class48> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						if (flag)
						{
							break;
						}
					}
				}
				finally
				{
					IEnumerator<Class48> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (!Information.IsNothing(class3) && !Information.IsNothing(class3.method_9()))
				{
					Mission.Class289 class4 = (Mission.Class289)class3.Tag;
					if (!Information.IsNothing(class4))
					{
						if (Operators.CompareString(left, "Aircraft #1", false) == 0 && !Information.IsNothing(this.waypoint_0.list_9))
						{
							try
							{
								foreach (Mission.Class289 class5 in this.waypoint_0.list_9)
								{
									if (class5 == class4)
									{
										class5.bool_1 = true;
									}
									else
									{
										class5.bool_1 = false;
									}
								}
								goto IL_3AF;
							}
							finally
							{
								List<Mission.Class289>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
						}
						if (Operators.CompareString(left, "Aircraft #2", false) == 0 && !Information.IsNothing(this.waypoint_0.list_10))
						{
							try
							{
								foreach (Mission.Class289 class6 in this.waypoint_0.list_10)
								{
									if (class6 == class4)
									{
										class6.bool_1 = true;
									}
									else
									{
										class6.bool_1 = false;
									}
								}
								goto IL_3AF;
							}
							finally
							{
								List<Mission.Class289>.Enumerator enumerator4;
								((IDisposable)enumerator4).Dispose();
							}
						}
						if (Operators.CompareString(left, "Aircraft #3", false) == 0 && !Information.IsNothing(this.waypoint_0.list_11))
						{
							try
							{
								foreach (Mission.Class289 class7 in this.waypoint_0.list_11)
								{
									if (class7 == class4)
									{
										class7.bool_1 = true;
									}
									else
									{
										class7.bool_1 = false;
									}
								}
								goto IL_3AF;
							}
							finally
							{
								List<Mission.Class289>.Enumerator enumerator5;
								((IDisposable)enumerator5).Dispose();
							}
						}
						if (Operators.CompareString(left, "Aircraft #4", false) == 0 && !Information.IsNothing(this.waypoint_0.list_12))
						{
							try
							{
								foreach (Mission.Class289 class8 in this.waypoint_0.list_12)
								{
									if (class8 == class4)
									{
										class8.bool_1 = true;
									}
									else
									{
										class8.bool_1 = false;
									}
								}
								goto IL_3AF;
							}
							finally
							{
								List<Mission.Class289>.Enumerator enumerator6;
								((IDisposable)enumerator6).Dispose();
							}
						}
						if (Operators.CompareString(left, "Aircraft #5", false) == 0 && !Information.IsNothing(this.waypoint_0.list_13))
						{
							try
							{
								foreach (Mission.Class289 class9 in this.waypoint_0.list_13)
								{
									if (class9 == class4)
									{
										class9.bool_1 = true;
									}
									else
									{
										class9.bool_1 = false;
									}
								}
								goto IL_3AF;
							}
							finally
							{
								List<Mission.Class289>.Enumerator enumerator7;
								((IDisposable)enumerator7).Dispose();
							}
						}
						if (Operators.CompareString(left, "Aircraft #6", false) == 0 && !Information.IsNothing(this.waypoint_0.list_14))
						{
							try
							{
								foreach (Mission.Class289 class10 in this.waypoint_0.list_14)
								{
									if (class10 == class4)
									{
										class10.bool_1 = true;
									}
									else
									{
										class10.bool_1 = false;
									}
								}
								goto IL_3AF;
							}
							finally
							{
								List<Mission.Class289>.Enumerator enumerator8;
								((IDisposable)enumerator8).Dispose();
							}
						}
						try
						{
							foreach (Mission.Class289 class11 in this.waypoint_0.list_9)
							{
								class11.bool_1 = false;
							}
						}
						finally
						{
							List<Mission.Class289>.Enumerator enumerator9;
							((IDisposable)enumerator9).Dispose();
						}
						IL_3AF:
						if (!Information.IsNothing(this.flight_0))
						{
							Scenario scenario_ = Client.smethod_46();
							Mission mission = this.mission_0;
							ActiveUnit activeUnit_ = this.flight_0.method_32(Client.smethod_46());
							Mission.Flight flight = this.flight_0;
							Mission.Flight flight2;
							Waypoint[] waypoint_ = (flight2 = this.flight_0).method_15();
							float num = 0f;
							float num2 = 0f;
							Class514.smethod_28(scenario_, mission, activeUnit_, flight, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
							flight2.method_16(waypoint_);
						}
						this.method_10(false, false);
					}
				}
			}
		}

		// Token: 0x04003D42 RID: 15682
		[AccessedThroughProperty("GroupBox_Targeteering")]
		[CompilerGenerated]
		private GroupBox groupBox_0;

		// Token: 0x04003D43 RID: 15683
		[AccessedThroughProperty("GroupBox_Weaponeering")]
		[CompilerGenerated]
		private GroupBox groupBox_1;

		// Token: 0x04003D44 RID: 15684
		[AccessedThroughProperty("TGV_Weaponeering")]
		[CompilerGenerated]
		private TreeGridView treeGridView_0;

		// Token: 0x04003D45 RID: 15685
		[AccessedThroughProperty("Button_EditWRA")]
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04003D46 RID: 15686
		[CompilerGenerated]
		[AccessedThroughProperty("ComboBox_TargteeringMethod")]
		private ComboBox comboBox_0;

		// Token: 0x04003D47 RID: 15687
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Label label_0;

		// Token: 0x04003D48 RID: 15688
		[CompilerGenerated]
		[AccessedThroughProperty("TGV_Targeteering")]
		private TreeGridView treeGridView_1;

		// Token: 0x04003D49 RID: 15689
		[CompilerGenerated]
		[AccessedThroughProperty("Button_EditArea")]
		private Button button_1;

		// Token: 0x04003D4A RID: 15690
		[CompilerGenerated]
		[AccessedThroughProperty("Button_AddArea")]
		private Button button_2;

		// Token: 0x04003D4B RID: 15691
		[AccessedThroughProperty("Button_EditToT")]
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x04003D4C RID: 15692
		[CompilerGenerated]
		[AccessedThroughProperty("Button_EditPreliminaryTargetLocation")]
		private Button button_4;

		// Token: 0x04003D4D RID: 15693
		[AccessedThroughProperty("Button_AddPreliminaryTargetLocation")]
		[CompilerGenerated]
		private Button button_5;

		// Token: 0x04003D4E RID: 15694
		[CompilerGenerated]
		[AccessedThroughProperty("Button_EditCoordinate")]
		private Button button_6;

		// Token: 0x04003D4F RID: 15695
		[CompilerGenerated]
		[AccessedThroughProperty("Button_AddCoordinate")]
		private Button button_7;

		// Token: 0x04003D50 RID: 15696
		[CompilerGenerated]
		[AccessedThroughProperty("Button_DecreasePriority")]
		private Button button_8;

		// Token: 0x04003D51 RID: 15697
		[CompilerGenerated]
		[AccessedThroughProperty("Button_IncreasePriority")]
		private Button button_9;

		// Token: 0x04003D52 RID: 15698
		[CompilerGenerated]
		[AccessedThroughProperty("Button_RemoveSelected")]
		private Button button_10;

		// Token: 0x04003D53 RID: 15699
		[CompilerGenerated]
		[AccessedThroughProperty("CB_PreplannedOnly")]
		private CheckBox checkBox_0;

		// Token: 0x04003D54 RID: 15700
		[CompilerGenerated]
		[AccessedThroughProperty("Button_AddHighlighted")]
		private Button button_11;

		// Token: 0x04003D55 RID: 15701
		[CompilerGenerated]
		[AccessedThroughProperty("SplitContainer1")]
		private SplitContainer splitContainer_0;

		// Token: 0x04003D56 RID: 15702
		[CompilerGenerated]
		[AccessedThroughProperty("Button_EditRoute")]
		private Button button_12;

		// Token: 0x04003D57 RID: 15703
		[CompilerGenerated]
		[AccessedThroughProperty("ID")]
		private Class44 class44_0;

		// Token: 0x04003D58 RID: 15704
		[AccessedThroughProperty("TargetName")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04003D59 RID: 15705
		[AccessedThroughProperty("AssignedWeapons")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04003D5A RID: 15706
		[CompilerGenerated]
		[AccessedThroughProperty("Time_Zulu")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04003D5B RID: 15707
		[CompilerGenerated]
		[AccessedThroughProperty("Time_Local")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04003D5C RID: 15708
		[CompilerGenerated]
		[AccessedThroughProperty("Coordinates")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04003D5D RID: 15709
		[AccessedThroughProperty("WeaponType")]
		[CompilerGenerated]
		private Class44 class44_1;

		// Token: 0x04003D5E RID: 15710
		[AccessedThroughProperty("Target")]
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;

		// Token: 0x04003D5F RID: 15711
		[CompilerGenerated]
		[AccessedThroughProperty("LostTarget")]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;

		// Token: 0x04003D60 RID: 15712
		[AccessedThroughProperty("WeaponQty")]
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_2;

		// Token: 0x04003D61 RID: 15713
		[AccessedThroughProperty("FiringRange")]
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_3;

		// Token: 0x04003D62 RID: 15714
		[AccessedThroughProperty("Route")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x04003D63 RID: 15715
		[CompilerGenerated]
		[AccessedThroughProperty("Button_SetTimeReferenceWeapon")]
		private Button button_13;

		// Token: 0x04003D64 RID: 15716
		public int int_0;

		// Token: 0x04003D65 RID: 15717
		private List<WeaponRec> list_0;

		// Token: 0x04003D66 RID: 15718
		public Waypoint waypoint_0;

		// Token: 0x04003D67 RID: 15719
		public Waypoint waypoint_1;

		// Token: 0x04003D68 RID: 15720
		private bool bool_3;

		// Token: 0x04003D69 RID: 15721
		private List<string> list_1;

		// Token: 0x04003D6A RID: 15722
		private List<string> list_2;

		// Token: 0x04003D6B RID: 15723
		public Mission mission_0;

		// Token: 0x04003D6C RID: 15724
		public Mission.Flight flight_0;

		// Token: 0x04003D6D RID: 15725
		public List<string> list_3;

		// Token: 0x04003D6E RID: 15726
		public string string_0;

		// Token: 0x02000E1D RID: 3613
		internal enum Enum201 : byte
		{
			// Token: 0x04003D70 RID: 15728
			const_0,
			// Token: 0x04003D71 RID: 15729
			const_1,
			// Token: 0x04003D72 RID: 15730
			const_2,
			// Token: 0x04003D73 RID: 15731
			const_3
		}

		// Token: 0x02000E1E RID: 3614
		[CompilerGenerated]
		internal sealed class Class2466
		{
			// Token: 0x06006B9B RID: 27547 RVA: 0x00043E6D File Offset: 0x0004206D
			public Class2466(FlightPlanEditorTargets.Class2466 class2466_0)
			{
				if (class2466_0 != null)
				{
					this.waypoint_0 = class2466_0.waypoint_0;
				}
			}

			// Token: 0x06006B9C RID: 27548 RVA: 0x003B01D8 File Offset: 0x003AE3D8
			internal double method_0(Contact contact_0)
			{
				return Math2.smethod_14(this.waypoint_0.imethod_2(), this.waypoint_0.imethod_0(), contact_0.vmethod_30(null), contact_0.vmethod_28(null));
			}

			// Token: 0x04003D74 RID: 15732
			public Waypoint waypoint_0;
		}

		// Token: 0x02000E1F RID: 3615
		[CompilerGenerated]
		internal sealed class Class2467
		{
			// Token: 0x06006B9D RID: 27549 RVA: 0x00043E84 File Offset: 0x00042084
			public Class2467(FlightPlanEditorTargets.Class2467 class2467_0)
			{
				if (class2467_0 != null)
				{
					this.waypoint_0 = class2467_0.waypoint_0;
				}
			}

			// Token: 0x06006B9E RID: 27550 RVA: 0x003B0220 File Offset: 0x003AE420
			internal double method_0(Contact contact_0)
			{
				return Math2.smethod_14(this.waypoint_0.imethod_2(), this.waypoint_0.imethod_0(), contact_0.vmethod_30(null), contact_0.vmethod_28(null));
			}

			// Token: 0x04003D75 RID: 15733
			public Waypoint waypoint_0;
		}
	}
}
