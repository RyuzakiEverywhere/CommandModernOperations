using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000EB3 RID: 3763
	[DesignerGenerated]
	public sealed partial class EditEvent : DarkSecondaryFormBase
	{
		// Token: 0x060078E3 RID: 30947 RVA: 0x0041C3B8 File Offset: 0x0041A5B8
		public EditEvent()
		{
			base.FormClosing += this.EditEvent_FormClosing;
			base.Load += this.EditEvent_Load;
			base.KeyDown += this.EditEvent_KeyDown;
			base.FormClosed += this.EditEvent_FormClosed;
			this.InitializeComponent_1();
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x0041C45C File Offset: 0x0041A65C
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			this.vmethod_1(new Control8());
			this.vmethod_3(new Class116());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Class114());
			this.vmethod_9(new DataGridViewTextBoxColumn());
			this.vmethod_11(new DataGridViewTextBoxColumn());
			this.vmethod_13(new Class114());
			this.vmethod_15(new DataGridViewTextBoxColumn());
			this.vmethod_17(new DataGridViewTextBoxColumn());
			this.vmethod_19(new Class116());
			this.vmethod_21(new Class114());
			this.vmethod_23(new DataGridViewTextBoxColumn());
			this.vmethod_25(new DataGridViewTextBoxColumn());
			this.vmethod_27(new Class116());
			this.vmethod_29(new Control9());
			this.vmethod_31(new Class2451());
			this.vmethod_33(new Control9());
			this.vmethod_35(new Control9());
			this.vmethod_37(new Class2451());
			this.vmethod_39(new Control9());
			this.vmethod_41(new Control9());
			this.vmethod_43(new Class2451());
			this.vmethod_45(new Control9());
			this.vmethod_47(new Control9());
			this.vmethod_49(new Control9());
			this.vmethod_51(new Class112());
			this.vmethod_53(new Class112());
			this.vmethod_55(new Class116());
			this.vmethod_57(new Control10());
			this.vmethod_59(new Control9());
			this.vmethod_61(new Control9());
			this.vmethod_63(new Control9());
			this.vmethod_65(new Class112());
			((ISupportInitialize)this.vmethod_6()).BeginInit();
			((ISupportInitialize)this.vmethod_12()).BeginInit();
			((ISupportInitialize)this.vmethod_20()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().method_14(null);
			this.vmethod_0().method_15(AutoCompleteMode.None);
			this.vmethod_0().method_13(AutoCompleteSource.None);
			this.vmethod_0().BackColor = Color.Transparent;
			this.vmethod_0().method_17(new Font("Segoe UI", 10f));
			this.vmethod_0().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_0().method_12(null);
			this.vmethod_0().method_18(null);
			this.vmethod_0().Location = new Point(91, 3);
			this.vmethod_0().method_2(32767);
			this.vmethod_0().method_7(false);
			this.vmethod_0().Name = "TextBox1";
			this.vmethod_0().method_3(false);
			this.vmethod_0().method_9(0);
			this.vmethod_0().Size = new Size(691, 20);
			this.vmethod_0().TabIndex = 8;
			this.vmethod_0().method_1(HorizontalAlignment.Left);
			this.vmethod_0().method_5(false);
			this.vmethod_0().method_10("");
			this.vmethod_2().method_2(true);
			this.vmethod_2().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(5, 7);
			this.vmethod_2().Name = "Label2";
			this.vmethod_2().Size = new Size(69, 13);
			this.vmethod_2().TabIndex = 7;
			this.vmethod_2().Text = "Description:";
			this.vmethod_4().method_2(true);
			this.vmethod_4().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(5, 67);
			this.vmethod_4().Name = "Label1";
			this.vmethod_4().Size = new Size(51, 13);
			this.vmethod_4().TabIndex = 9;
			this.vmethod_4().Text = "Triggers:";
			this.vmethod_6().AllowUserToAddRows = false;
			this.vmethod_6().AllowUserToDeleteRows = false;
			this.vmethod_6().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_6().CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.vmethod_6().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_6().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_6().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_6().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_8(),
				this.vmethod_10()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_6().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_6().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_6().EnableHeadersVisualStyles = false;
			this.vmethod_6().Location = new Point(8, 83);
			this.vmethod_6().MultiSelect = false;
			this.vmethod_6().Name = "DGV_Triggers";
			this.vmethod_6().ReadOnly = true;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_6().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_6().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_6().ShowCellToolTips = false;
			this.vmethod_6().ShowEditingIcon = false;
			this.vmethod_6().ShowRowErrors = false;
			this.vmethod_6().Size = new Size(774, 100);
			this.vmethod_6().TabIndex = 10;
			this.vmethod_8().DataPropertyName = "ID";
			this.vmethod_8().HeaderText = "ID";
			this.vmethod_8().Name = "ID";
			this.vmethod_8().ReadOnly = true;
			this.vmethod_8().Visible = false;
			this.vmethod_10().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_10().DataPropertyName = "Description";
			this.vmethod_10().HeaderText = "Description";
			this.vmethod_10().Name = "Description";
			this.vmethod_10().ReadOnly = true;
			this.vmethod_12().AllowUserToAddRows = false;
			this.vmethod_12().AllowUserToDeleteRows = false;
			this.vmethod_12().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_12().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_12().CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.vmethod_12().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle4.ForeColor = Color.LightGray;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			this.vmethod_12().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_12().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_12().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_14(),
				this.vmethod_16()
			});
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle5.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle5.ForeColor = Color.LightGray;
			dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
			this.vmethod_12().DefaultCellStyle = dataGridViewCellStyle5;
			this.vmethod_12().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_12().EnableHeadersVisualStyles = false;
			this.vmethod_12().Location = new Point(8, 241);
			this.vmethod_12().MultiSelect = false;
			this.vmethod_12().Name = "DGV_Conditions";
			this.vmethod_12().ReadOnly = true;
			dataGridViewCellStyle6.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle6.ForeColor = Color.LightGray;
			dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle6.SelectionForeColor = Color.LightGray;
			this.vmethod_12().RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.vmethod_12().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_12().ShowCellToolTips = false;
			this.vmethod_12().ShowEditingIcon = false;
			this.vmethod_12().ShowRowErrors = false;
			this.vmethod_12().Size = new Size(774, 100);
			this.vmethod_12().TabIndex = 12;
			this.vmethod_14().DataPropertyName = "ID";
			this.vmethod_14().HeaderText = "ID";
			this.vmethod_14().Name = "DataGridViewTextBoxColumn1";
			this.vmethod_14().ReadOnly = true;
			this.vmethod_14().Visible = false;
			this.vmethod_16().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_16().DataPropertyName = "Description";
			this.vmethod_16().HeaderText = "Description";
			this.vmethod_16().Name = "DataGridViewTextBoxColumn2";
			this.vmethod_16().ReadOnly = true;
			this.vmethod_18().method_2(true);
			this.vmethod_18().Enabled = false;
			this.vmethod_18().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(5, 225);
			this.vmethod_18().Name = "Label3";
			this.vmethod_18().Size = new Size(67, 13);
			this.vmethod_18().TabIndex = 11;
			this.vmethod_18().Text = "Conditions:";
			this.vmethod_20().AllowUserToAddRows = false;
			this.vmethod_20().AllowUserToDeleteRows = false;
			this.vmethod_20().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_20().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_20().CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.vmethod_20().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle7.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle7.ForeColor = Color.LightGray;
			dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			this.vmethod_20().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.vmethod_20().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_20().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_22(),
				this.vmethod_24()
			});
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle8.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle8.ForeColor = Color.LightGray;
			dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
			this.vmethod_20().DefaultCellStyle = dataGridViewCellStyle8;
			this.vmethod_20().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_20().EnableHeadersVisualStyles = false;
			this.vmethod_20().Location = new Point(8, 399);
			this.vmethod_20().MultiSelect = false;
			this.vmethod_20().Name = "DGV_Actions";
			this.vmethod_20().ReadOnly = true;
			dataGridViewCellStyle9.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle9.ForeColor = Color.LightGray;
			dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle9.SelectionForeColor = Color.LightGray;
			this.vmethod_20().RowsDefaultCellStyle = dataGridViewCellStyle9;
			this.vmethod_20().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_20().ShowCellToolTips = false;
			this.vmethod_20().ShowEditingIcon = false;
			this.vmethod_20().ShowRowErrors = false;
			this.vmethod_20().Size = new Size(774, 100);
			this.vmethod_20().TabIndex = 14;
			this.vmethod_22().DataPropertyName = "ID";
			this.vmethod_22().HeaderText = "ID";
			this.vmethod_22().Name = "DataGridViewTextBoxColumn3";
			this.vmethod_22().ReadOnly = true;
			this.vmethod_22().Visible = false;
			this.vmethod_24().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_24().DataPropertyName = "Description";
			this.vmethod_24().HeaderText = "Description";
			this.vmethod_24().Name = "DataGridViewTextBoxColumn4";
			this.vmethod_24().ReadOnly = true;
			this.vmethod_26().method_2(true);
			this.vmethod_26().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().Location = new Point(5, 383);
			this.vmethod_26().Name = "Label4";
			this.vmethod_26().Size = new Size(49, 13);
			this.vmethod_26().TabIndex = 13;
			this.vmethod_26().Text = "Actions:";
			this.vmethod_28().BackColor = Color.Transparent;
			this.vmethod_28().DialogResult = DialogResult.None;
			this.vmethod_28().Font = new Font("Segoe UI", 9f);
			this.vmethod_28().ForeColor = SystemColors.Control;
			this.vmethod_28().Location = new Point(8, 190);
			this.vmethod_28().Name = "Button1";
			this.vmethod_28().method_1(0);
			this.vmethod_28().Size = new Size(93, 21);
			this.vmethod_28().TabIndex = 15;
			this.vmethod_28().Text = "Add trigger:";
			this.vmethod_30().BackColor = Color.Transparent;
			this.vmethod_30().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_30().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_30().Font = new Font("Segoe UI", 7f);
			this.vmethod_30().FormattingEnabled = true;
			this.vmethod_30().Location = new Point(107, 189);
			this.vmethod_30().Name = "CB_Triggers";
			this.vmethod_30().Size = new Size(424, 21);
			this.vmethod_30().TabIndex = 16;
			this.vmethod_32().BackColor = Color.Transparent;
			this.vmethod_32().DialogResult = DialogResult.None;
			this.vmethod_32().Font = new Font("Segoe UI", 9f);
			this.vmethod_32().ForeColor = SystemColors.Control;
			this.vmethod_32().Location = new Point(638, 190);
			this.vmethod_32().Name = "Button2";
			this.vmethod_32().method_1(0);
			this.vmethod_32().Size = new Size(144, 21);
			this.vmethod_32().TabIndex = 17;
			this.vmethod_32().Text = "Remove selected";
			this.vmethod_34().BackColor = Color.Transparent;
			this.vmethod_34().DialogResult = DialogResult.None;
			this.vmethod_34().Font = new Font("Segoe UI", 9f);
			this.vmethod_34().ForeColor = SystemColors.Control;
			this.vmethod_34().Location = new Point(638, 348);
			this.vmethod_34().Name = "Button3";
			this.vmethod_34().method_1(0);
			this.vmethod_34().Size = new Size(144, 21);
			this.vmethod_34().TabIndex = 20;
			this.vmethod_34().Text = "Remove selected";
			this.vmethod_36().BackColor = Color.Transparent;
			this.vmethod_36().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_36().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_36().Font = new Font("Segoe UI", 7f);
			this.vmethod_36().FormattingEnabled = true;
			this.vmethod_36().Location = new Point(107, 348);
			this.vmethod_36().Name = "CB_Conditions";
			this.vmethod_36().Size = new Size(424, 21);
			this.vmethod_36().TabIndex = 19;
			this.vmethod_38().BackColor = Color.Transparent;
			this.vmethod_38().DialogResult = DialogResult.None;
			this.vmethod_38().Font = new Font("Segoe UI", 9f);
			this.vmethod_38().ForeColor = SystemColors.Control;
			this.vmethod_38().Location = new Point(8, 348);
			this.vmethod_38().Name = "Button4";
			this.vmethod_38().method_1(0);
			this.vmethod_38().Size = new Size(93, 21);
			this.vmethod_38().TabIndex = 18;
			this.vmethod_38().Text = "Add condition:";
			this.vmethod_40().BackColor = Color.Transparent;
			this.vmethod_40().DialogResult = DialogResult.None;
			this.vmethod_40().Font = new Font("Segoe UI", 9f);
			this.vmethod_40().ForeColor = SystemColors.Control;
			this.vmethod_40().Location = new Point(638, 506);
			this.vmethod_40().Name = "Button5";
			this.vmethod_40().method_1(0);
			this.vmethod_40().Size = new Size(144, 21);
			this.vmethod_40().TabIndex = 23;
			this.vmethod_40().Text = "Remove selected";
			this.vmethod_42().BackColor = Color.Transparent;
			this.vmethod_42().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_42().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_42().Font = new Font("Segoe UI", 7f);
			this.vmethod_42().FormattingEnabled = true;
			this.vmethod_42().Location = new Point(107, 506);
			this.vmethod_42().Name = "CB_Actions";
			this.vmethod_42().Size = new Size(424, 21);
			this.vmethod_42().TabIndex = 22;
			this.vmethod_44().BackColor = Color.Transparent;
			this.vmethod_44().DialogResult = DialogResult.None;
			this.vmethod_44().Font = new Font("Segoe UI", 9f);
			this.vmethod_44().ForeColor = SystemColors.Control;
			this.vmethod_44().Location = new Point(8, 506);
			this.vmethod_44().Name = "Button6";
			this.vmethod_44().method_1(0);
			this.vmethod_44().Size = new Size(93, 21);
			this.vmethod_44().TabIndex = 21;
			this.vmethod_44().Text = "Add action:";
			this.vmethod_46().BackColor = Color.Transparent;
			this.vmethod_46().DialogResult = DialogResult.None;
			this.vmethod_46().Font = new Font("Segoe UI", 10f);
			this.vmethod_46().ForeColor = SystemColors.Control;
			this.vmethod_46().Location = new Point(707, 556);
			this.vmethod_46().Name = "Button7";
			this.vmethod_46().method_1(0);
			this.vmethod_46().Size = new Size(75, 23);
			this.vmethod_46().TabIndex = 25;
			this.vmethod_46().Text = "Cancel";
			this.vmethod_48().BackColor = Color.Transparent;
			this.vmethod_48().DialogResult = DialogResult.None;
			this.vmethod_48().Font = new Font("Segoe UI", 10f);
			this.vmethod_48().ForeColor = SystemColors.Control;
			this.vmethod_48().Location = new Point(8, 556);
			this.vmethod_48().Name = "Button8";
			this.vmethod_48().method_1(0);
			this.vmethod_48().Size = new Size(75, 23);
			this.vmethod_48().TabIndex = 24;
			this.vmethod_48().Text = "OK";
			this.vmethod_50().AutoSize = true;
			this.vmethod_50().Location = new Point(8, 39);
			this.vmethod_50().Name = "CheckBox_IsRepeatable";
			this.vmethod_50().Size = new Size(124, 19);
			this.vmethod_50().TabIndex = 26;
			this.vmethod_50().Text = "Event is repeatable";
			this.vmethod_52().AutoSize = true;
			this.vmethod_52().Location = new Point(131, 39);
			this.vmethod_52().Name = "CheckBox_IsActive";
			this.vmethod_52().Size = new Size(100, 19);
			this.vmethod_52().TabIndex = 27;
			this.vmethod_52().Text = "Event is active";
			this.vmethod_54().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_54().Location = new Point(456, 43);
			this.vmethod_54().Name = "Label5";
			this.vmethod_54().Size = new Size(75, 13);
			this.vmethod_54().TabIndex = 28;
			this.vmethod_54().Text = "Probability (%):";
			this.vmethod_56().BackColor = Color.Transparent;
			this.vmethod_56().Font = new Font("Segoe UI", 10f);
			this.vmethod_56().Location = new Point(532, 37);
			this.vmethod_56().method_1(100);
			this.vmethod_56().method_3(0);
			this.vmethod_56().Name = "NUD_Probability";
			this.vmethod_56().Size = new Size(53, 26);
			this.vmethod_56().TabIndex = 29;
			this.vmethod_56().Value = 0;
			this.vmethod_58().BackColor = Color.Transparent;
			this.vmethod_58().DialogResult = DialogResult.None;
			this.vmethod_58().Font = new Font("Segoe UI", 9f);
			this.vmethod_58().ForeColor = SystemColors.Control;
			this.vmethod_58().Location = new Point(537, 190);
			this.vmethod_58().Name = "Button_EditTriggers";
			this.vmethod_58().method_1(0);
			this.vmethod_58().Size = new Size(93, 21);
			this.vmethod_58().TabIndex = 30;
			this.vmethod_58().Text = "Edit triggers";
			this.vmethod_60().BackColor = Color.Transparent;
			this.vmethod_60().DialogResult = DialogResult.None;
			this.vmethod_60().Font = new Font("Segoe UI", 9f);
			this.vmethod_60().ForeColor = SystemColors.Control;
			this.vmethod_60().Location = new Point(537, 506);
			this.vmethod_60().Name = "Button_EditActions";
			this.vmethod_60().method_1(0);
			this.vmethod_60().Size = new Size(95, 21);
			this.vmethod_60().TabIndex = 31;
			this.vmethod_60().Text = "Edit actions";
			this.vmethod_62().BackColor = Color.Transparent;
			this.vmethod_62().DialogResult = DialogResult.None;
			this.vmethod_62().Font = new Font("Segoe UI", 9f);
			this.vmethod_62().ForeColor = SystemColors.Control;
			this.vmethod_62().Location = new Point(537, 348);
			this.vmethod_62().Name = "Button_EditConditions";
			this.vmethod_62().method_1(0);
			this.vmethod_62().Size = new Size(95, 21);
			this.vmethod_62().TabIndex = 32;
			this.vmethod_62().Text = "Edit conditions";
			this.vmethod_64().AutoSize = true;
			this.vmethod_64().Location = new Point(233, 39);
			this.vmethod_64().Name = "CheckBox_IsShown";
			this.vmethod_64().Size = new Size(140, 19);
			this.vmethod_64().TabIndex = 33;
			this.vmethod_64().Text = "Event is shown in Log";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(786, 580);
			base.Controls.Add(this.vmethod_64());
			base.Controls.Add(this.vmethod_62());
			base.Controls.Add(this.vmethod_60());
			base.Controls.Add(this.vmethod_58());
			base.Controls.Add(this.vmethod_56());
			base.Controls.Add(this.vmethod_54());
			base.Controls.Add(this.vmethod_52());
			base.Controls.Add(this.vmethod_50());
			base.Controls.Add(this.vmethod_46());
			base.Controls.Add(this.vmethod_48());
			base.Controls.Add(this.vmethod_40());
			base.Controls.Add(this.vmethod_42());
			base.Controls.Add(this.vmethod_44());
			base.Controls.Add(this.vmethod_34());
			base.Controls.Add(this.vmethod_36());
			base.Controls.Add(this.vmethod_38());
			base.Controls.Add(this.vmethod_32());
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditEvent";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Edit Event";
			((ISupportInitialize)this.vmethod_6()).EndInit();
			((ISupportInitialize)this.vmethod_12()).EndInit();
			((ISupportInitialize)this.vmethod_20()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x0004ACCC File Offset: 0x00048ECC
		[CompilerGenerated]
		internal Control8 vmethod_0()
		{
			return this.control8_0;
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x0041E0BC File Offset: 0x0041C2BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control8 control8_1)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_17);
			Control8 control = this.control8_0;
			if (control != null)
			{
				control.method_22(delegate85_);
			}
			this.control8_0 = control8_1;
			control = this.control8_0;
			if (control != null)
			{
				control.method_21(delegate85_);
			}
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x0004ACD4 File Offset: 0x00048ED4
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_0;
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x0004ACDC File Offset: 0x00048EDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_5)
		{
			this.class116_0 = class116_5;
		}

		// Token: 0x060078EA RID: 30954 RVA: 0x0004ACE5 File Offset: 0x00048EE5
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_1;
		}

		// Token: 0x060078EB RID: 30955 RVA: 0x0004ACED File Offset: 0x00048EED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_5)
		{
			this.class116_1 = class116_5;
		}

		// Token: 0x060078EC RID: 30956 RVA: 0x0004ACF6 File Offset: 0x00048EF6
		[CompilerGenerated]
		internal Class114 vmethod_6()
		{
			return this.class114_0;
		}

		// Token: 0x060078ED RID: 30957 RVA: 0x0004ACFE File Offset: 0x00048EFE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class114 class114_3)
		{
			this.class114_0 = class114_3;
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x0004AD07 File Offset: 0x00048F07
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_8()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x060078EF RID: 30959 RVA: 0x0004AD0F File Offset: 0x00048F0F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x060078F0 RID: 30960 RVA: 0x0004AD18 File Offset: 0x00048F18
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_10()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x060078F1 RID: 30961 RVA: 0x0004AD20 File Offset: 0x00048F20
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x060078F2 RID: 30962 RVA: 0x0004AD29 File Offset: 0x00048F29
		[CompilerGenerated]
		internal Class114 vmethod_12()
		{
			return this.class114_1;
		}

		// Token: 0x060078F3 RID: 30963 RVA: 0x0004AD31 File Offset: 0x00048F31
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class114 class114_3)
		{
			this.class114_1 = class114_3;
		}

		// Token: 0x060078F4 RID: 30964 RVA: 0x0004AD3A File Offset: 0x00048F3A
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_14()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060078F5 RID: 30965 RVA: 0x0004AD42 File Offset: 0x00048F42
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x060078F6 RID: 30966 RVA: 0x0004AD4B File Offset: 0x00048F4B
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_16()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x060078F7 RID: 30967 RVA: 0x0004AD53 File Offset: 0x00048F53
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x060078F8 RID: 30968 RVA: 0x0004AD5C File Offset: 0x00048F5C
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_2;
		}

		// Token: 0x060078F9 RID: 30969 RVA: 0x0004AD64 File Offset: 0x00048F64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_5)
		{
			this.class116_2 = class116_5;
		}

		// Token: 0x060078FA RID: 30970 RVA: 0x0004AD6D File Offset: 0x00048F6D
		[CompilerGenerated]
		internal Class114 vmethod_20()
		{
			return this.class114_2;
		}

		// Token: 0x060078FB RID: 30971 RVA: 0x0004AD75 File Offset: 0x00048F75
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class114 class114_3)
		{
			this.class114_2 = class114_3;
		}

		// Token: 0x060078FC RID: 30972 RVA: 0x0004AD7E File Offset: 0x00048F7E
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_22()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x060078FD RID: 30973 RVA: 0x0004AD86 File Offset: 0x00048F86
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x060078FE RID: 30974 RVA: 0x0004AD8F File Offset: 0x00048F8F
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_24()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x0004AD97 File Offset: 0x00048F97
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x0004ADA0 File Offset: 0x00048FA0
		[CompilerGenerated]
		internal Class116 vmethod_26()
		{
			return this.class116_3;
		}

		// Token: 0x06007901 RID: 30977 RVA: 0x0004ADA8 File Offset: 0x00048FA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class116 class116_5)
		{
			this.class116_3 = class116_5;
		}

		// Token: 0x06007902 RID: 30978 RVA: 0x0004ADB1 File Offset: 0x00048FB1
		[CompilerGenerated]
		internal Control9 vmethod_28()
		{
			return this.control9_0;
		}

		// Token: 0x06007903 RID: 30979 RVA: 0x0041E100 File Offset: 0x0041C300
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Control9 control9_11)
		{
			EventHandler value = new EventHandler(this.method_11);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_11;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007904 RID: 30980 RVA: 0x0004ADB9 File Offset: 0x00048FB9
		[CompilerGenerated]
		internal Class2451 vmethod_30()
		{
			return this.class2451_0;
		}

		// Token: 0x06007905 RID: 30981 RVA: 0x0004ADC1 File Offset: 0x00048FC1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class2451 class2451_3)
		{
			this.class2451_0 = class2451_3;
		}

		// Token: 0x06007906 RID: 30982 RVA: 0x0004ADCA File Offset: 0x00048FCA
		[CompilerGenerated]
		internal Control9 vmethod_32()
		{
			return this.control9_1;
		}

		// Token: 0x06007907 RID: 30983 RVA: 0x0041E144 File Offset: 0x0041C344
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Control9 control9_11)
		{
			EventHandler value = new EventHandler(this.method_13);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_11;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007908 RID: 30984 RVA: 0x0004ADD2 File Offset: 0x00048FD2
		[CompilerGenerated]
		internal Control9 vmethod_34()
		{
			return this.control9_2;
		}

		// Token: 0x06007909 RID: 30985 RVA: 0x0041E188 File Offset: 0x0041C388
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Control9 control9_11)
		{
			EventHandler value = new EventHandler(this.method_18);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_11;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600790A RID: 30986 RVA: 0x0004ADDA File Offset: 0x00048FDA
		[CompilerGenerated]
		internal Class2451 vmethod_36()
		{
			return this.class2451_1;
		}

		// Token: 0x0600790B RID: 30987 RVA: 0x0004ADE2 File Offset: 0x00048FE2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Class2451 class2451_3)
		{
			this.class2451_1 = class2451_3;
		}

		// Token: 0x0600790C RID: 30988 RVA: 0x0004ADEB File Offset: 0x00048FEB
		[CompilerGenerated]
		internal Control9 vmethod_38()
		{
			return this.control9_3;
		}

		// Token: 0x0600790D RID: 30989 RVA: 0x0041E1CC File Offset: 0x0041C3CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Control9 control9_11)
		{
			EventHandler value = new EventHandler(this.method_22);
			Control9 control = this.control9_3;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_3 = control9_11;
			control = this.control9_3;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600790E RID: 30990 RVA: 0x0004ADF3 File Offset: 0x00048FF3
		[CompilerGenerated]
		internal Control9 vmethod_40()
		{
			return this.control9_4;
		}

		// Token: 0x0600790F RID: 30991 RVA: 0x0041E210 File Offset: 0x0041C410
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Control9 control9_11)
		{
			EventHandler value = new EventHandler(this.method_14);
			Control9 control = this.control9_4;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_4 = control9_11;
			control = this.control9_4;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007910 RID: 30992 RVA: 0x0004ADFB File Offset: 0x00048FFB
		[CompilerGenerated]
		internal Class2451 vmethod_42()
		{
			return this.class2451_2;
		}

		// Token: 0x06007911 RID: 30993 RVA: 0x0004AE03 File Offset: 0x00049003
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(Class2451 class2451_3)
		{
			this.class2451_2 = class2451_3;
		}

		// Token: 0x06007912 RID: 30994 RVA: 0x0004AE0C File Offset: 0x0004900C
		[CompilerGenerated]
		internal Control9 vmethod_44()
		{
			return this.control9_5;
		}

		// Token: 0x06007913 RID: 30995 RVA: 0x0041E254 File Offset: 0x0041C454
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Control9 control9_11)
		{
			EventHandler value = new EventHandler(this.method_12);
			Control9 control = this.control9_5;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_5 = control9_11;
			control = this.control9_5;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007914 RID: 30996 RVA: 0x0004AE14 File Offset: 0x00049014
		[CompilerGenerated]
		internal Control9 vmethod_46()
		{
			return this.control9_6;
		}

		// Token: 0x06007915 RID: 30997 RVA: 0x0041E298 File Offset: 0x0041C498
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(Control9 control9_11)
		{
			EventHandler value = new EventHandler(this.method_16);
			Control9 control = this.control9_6;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_6 = control9_11;
			control = this.control9_6;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x0004AE1C File Offset: 0x0004901C
		[CompilerGenerated]
		internal Control9 vmethod_48()
		{
			return this.control9_7;
		}

		// Token: 0x06007917 RID: 30999 RVA: 0x0041E2DC File Offset: 0x0041C4DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(Control9 control9_11)
		{
			EventHandler value = new EventHandler(this.method_15);
			Control9 control = this.control9_7;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_7 = control9_11;
			control = this.control9_7;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007918 RID: 31000 RVA: 0x0004AE24 File Offset: 0x00049024
		[CompilerGenerated]
		internal Class112 vmethod_50()
		{
			return this.class112_0;
		}

		// Token: 0x06007919 RID: 31001 RVA: 0x0041E320 File Offset: 0x0041C520
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(Class112 class112_3)
		{
			EventHandler value = new EventHandler(this.method_8);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_0 = class112_3;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x0600791A RID: 31002 RVA: 0x0004AE2C File Offset: 0x0004902C
		[CompilerGenerated]
		internal Class112 vmethod_52()
		{
			return this.class112_1;
		}

		// Token: 0x0600791B RID: 31003 RVA: 0x0041E364 File Offset: 0x0041C564
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(Class112 class112_3)
		{
			EventHandler value = new EventHandler(this.method_9);
			Class112 @class = this.class112_1;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_1 = class112_3;
			@class = this.class112_1;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x0600791C RID: 31004 RVA: 0x0004AE34 File Offset: 0x00049034
		[CompilerGenerated]
		internal Class116 vmethod_54()
		{
			return this.class116_4;
		}

		// Token: 0x0600791D RID: 31005 RVA: 0x0004AE3C File Offset: 0x0004903C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(Class116 class116_5)
		{
			this.class116_4 = class116_5;
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x0004AE45 File Offset: 0x00049045
		[CompilerGenerated]
		internal Control10 vmethod_56()
		{
			return this.control10_0;
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x0041E3A8 File Offset: 0x0041C5A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(Control10 control10_1)
		{
			EventHandler value = new EventHandler(this.method_19);
			Control10 control = this.control10_0;
			if (control != null)
			{
				control.TextChanged -= value;
			}
			this.control10_0 = control10_1;
			control = this.control10_0;
			if (control != null)
			{
				control.TextChanged += value;
			}
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x0004AE4D File Offset: 0x0004904D
		[CompilerGenerated]
		internal Control9 vmethod_58()
		{
			return this.control9_8;
		}

		// Token: 0x06007921 RID: 31009 RVA: 0x0041E3EC File Offset: 0x0041C5EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(Control9 control9_11)
		{
			EventHandler value = new EventHandler(this.method_20);
			Control9 control = this.control9_8;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_8 = control9_11;
			control = this.control9_8;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007922 RID: 31010 RVA: 0x0004AE55 File Offset: 0x00049055
		[CompilerGenerated]
		internal Control9 vmethod_60()
		{
			return this.control9_9;
		}

		// Token: 0x06007923 RID: 31011 RVA: 0x0041E430 File Offset: 0x0041C630
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(Control9 control9_11)
		{
			EventHandler value = new EventHandler(this.method_21);
			Control9 control = this.control9_9;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_9 = control9_11;
			control = this.control9_9;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007924 RID: 31012 RVA: 0x0004AE5D File Offset: 0x0004905D
		[CompilerGenerated]
		internal Control9 vmethod_62()
		{
			return this.control9_10;
		}

		// Token: 0x06007925 RID: 31013 RVA: 0x0041E474 File Offset: 0x0041C674
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(Control9 control9_11)
		{
			EventHandler value = new EventHandler(this.method_23);
			Control9 control = this.control9_10;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_10 = control9_11;
			control = this.control9_10;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007926 RID: 31014 RVA: 0x0004AE65 File Offset: 0x00049065
		[CompilerGenerated]
		internal Class112 vmethod_64()
		{
			return this.class112_2;
		}

		// Token: 0x06007927 RID: 31015 RVA: 0x0041E4B8 File Offset: 0x0041C6B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(Class112 class112_3)
		{
			EventHandler value = new EventHandler(this.method_10);
			Class112 @class = this.class112_2;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_2 = class112_3;
			@class = this.class112_2;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06007928 RID: 31016 RVA: 0x0004AE6D File Offset: 0x0004906D
		public SimEvent method_3()
		{
			return this.simEvent_0;
		}

		// Token: 0x06007929 RID: 31017 RVA: 0x0041E4FC File Offset: 0x0041C6FC
		public void method_4(SimEvent simEvent_1)
		{
			this.simEvent_0 = simEvent_1;
			this.vmethod_0().Text = this.method_3().string_2;
			this.method_6();
			this.method_7();
			this.vmethod_50().Checked = this.simEvent_0.bool_11;
			this.vmethod_52().Checked = this.simEvent_0.bool_12;
			this.vmethod_64().Checked = this.simEvent_0.bool_13;
			this.vmethod_56().Value = (int)this.simEvent_0.short_0;
		}

		// Token: 0x0600792A RID: 31018 RVA: 0x0041E58C File Offset: 0x0041C78C
		private void EditEvent_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.enum206_0 == EditEvent.Enum206.const_1)
			{
				if (this.method_3().list_0.Count == 0)
				{
					DarkMessageBox.smethod_2("The event should have at least one trigger assigned.", "No trigger assigned!", Enum11.const_0);
					e.Cancel = true;
					return;
				}
				if (this.method_3().list_2.Count == 0)
				{
					DarkMessageBox.smethod_2("The event should have at least one actions assigned.", "No actions assigned!", Enum11.const_0);
					e.Cancel = true;
					return;
				}
			}
			Class2413.smethod_2().method_34().method_3();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x0600792B RID: 31019 RVA: 0x0041E618 File Offset: 0x0041C818
		private void EditEvent_Load(object sender, EventArgs e)
		{
			Scenario.smethod_9(new Scenario.EventTriggersChangedEventHandler(this.method_5));
			Scenario.smethod_11(new Scenario.EventConditionsChangedEventHandler(this.method_5));
			Scenario.smethod_13(new Scenario.EventActionsChangedEventHandler(this.method_5));
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (Information.IsNothing(this.method_3()))
			{
				base.Close();
			}
		}

		// Token: 0x0600792C RID: 31020 RVA: 0x0004AE75 File Offset: 0x00049075
		private void method_5(Scenario scenario_0)
		{
			if (scenario_0 == Client.smethod_46())
			{
				this.method_7();
			}
		}

		// Token: 0x0600792D RID: 31021 RVA: 0x0041E680 File Offset: 0x0041C880
		private void method_6()
		{
			this.vmethod_6().SuspendLayout();
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("ID", typeof(string));
			dataTable.Columns.Add("Description", typeof(string));
			try
			{
				foreach (EventTrigger eventTrigger in this.method_3().list_0)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["ID"] = eventTrigger.string_0;
					dataRow["Description"] = eventTrigger.string_2;
					dataTable.Rows.Add(dataRow);
				}
			}
			finally
			{
				List<EventTrigger>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.vmethod_6().DataSource = dataTable;
			this.vmethod_6().ResumeLayout();
			this.vmethod_12().SuspendLayout();
			dataTable = new DataTable();
			dataTable.Columns.Add("ID", typeof(string));
			dataTable.Columns.Add("Description", typeof(string));
			try
			{
				foreach (EventCondition eventCondition in this.method_3().list_1)
				{
					DataRow dataRow2 = dataTable.NewRow();
					dataRow2["ID"] = eventCondition.string_0;
					dataRow2["Description"] = eventCondition.string_2;
					dataTable.Rows.Add(dataRow2);
				}
			}
			finally
			{
				List<EventCondition>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			this.vmethod_12().DataSource = dataTable;
			this.vmethod_12().ResumeLayout();
			this.vmethod_20().SuspendLayout();
			dataTable = new DataTable();
			dataTable.Columns.Add("ID", typeof(string));
			dataTable.Columns.Add("Description", typeof(string));
			try
			{
				foreach (EventAction eventAction in this.method_3().list_2)
				{
					DataRow dataRow3 = dataTable.NewRow();
					dataRow3["ID"] = eventAction.string_0;
					dataRow3["Description"] = eventAction.string_2;
					dataTable.Rows.Add(dataRow3);
				}
			}
			finally
			{
				List<EventAction>.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
			this.vmethod_20().DataSource = dataTable;
			this.vmethod_20().ResumeLayout();
		}

		// Token: 0x0600792E RID: 31022 RVA: 0x0041E91C File Offset: 0x0041CB1C
		public void method_7()
		{
			this.vmethod_30().Items.Clear();
			this.vmethod_30().DisplayMember = "Content";
			try
			{
				foreach (EventTrigger eventTrigger in Enumerable.OrderBy<EventTrigger, string>(Client.smethod_46().vmethod_4().Values, (EditEvent._Closure$__.$I146-0 == null) ? (EditEvent._Closure$__.$I146-0 = new Func<EventTrigger, string>(EditEvent._Closure$__.$I.method_0)) : EditEvent._Closure$__.$I146-0))
				{
					ComboBoxItem comboBoxItem = new ComboBoxItem();
					comboBoxItem.Content = eventTrigger.string_2;
					comboBoxItem.Tag = eventTrigger;
					this.vmethod_30().Items.Add(comboBoxItem);
				}
			}
			finally
			{
				IEnumerator<EventTrigger> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.vmethod_36().Items.Clear();
			this.vmethod_36().DisplayMember = "Content";
			try
			{
				foreach (EventCondition eventCondition in Enumerable.OrderBy<EventCondition, string>(Client.smethod_46().vmethod_6().Values, (EditEvent._Closure$__.$I146-1 == null) ? (EditEvent._Closure$__.$I146-1 = new Func<EventCondition, string>(EditEvent._Closure$__.$I.method_1)) : EditEvent._Closure$__.$I146-1))
				{
					ComboBoxItem comboBoxItem2 = new ComboBoxItem();
					comboBoxItem2.Content = eventCondition.string_2;
					comboBoxItem2.Tag = eventCondition;
					this.vmethod_36().Items.Add(comboBoxItem2);
				}
			}
			finally
			{
				IEnumerator<EventCondition> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			this.vmethod_42().Items.Clear();
			this.vmethod_42().DisplayMember = "Content";
			try
			{
				foreach (EventAction eventAction in Enumerable.OrderBy<EventAction, string>(Client.smethod_46().vmethod_8().Values, (EditEvent._Closure$__.$I146-2 == null) ? (EditEvent._Closure$__.$I146-2 = new Func<EventAction, string>(EditEvent._Closure$__.$I.method_2)) : EditEvent._Closure$__.$I146-2))
				{
					ComboBoxItem comboBoxItem3 = new ComboBoxItem();
					comboBoxItem3.Content = eventAction.string_2;
					comboBoxItem3.Tag = eventAction;
					this.vmethod_42().Items.Add(comboBoxItem3);
				}
			}
			finally
			{
				IEnumerator<EventAction> enumerator3;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
			}
		}

		// Token: 0x0600792F RID: 31023 RVA: 0x0004AE85 File Offset: 0x00049085
		private void method_8(object sender, EventArgs e)
		{
			this.method_3().bool_11 = this.vmethod_50().Checked;
		}

		// Token: 0x06007930 RID: 31024 RVA: 0x0004AE9D File Offset: 0x0004909D
		private void method_9(object sender, EventArgs e)
		{
			this.method_3().bool_12 = this.vmethod_52().Checked;
		}

		// Token: 0x06007931 RID: 31025 RVA: 0x0004AEB5 File Offset: 0x000490B5
		private void method_10(object sender, EventArgs e)
		{
			this.method_3().bool_13 = this.vmethod_64().Checked;
		}

		// Token: 0x06007932 RID: 31026 RVA: 0x0041EB58 File Offset: 0x0041CD58
		private void method_11(object sender, EventArgs e)
		{
			if (this.vmethod_30().SelectedIndex >= 0)
			{
				EventTrigger item = (EventTrigger)((ComboBoxItem)this.vmethod_30().SelectedItem).Tag;
				if (!this.method_3().list_0.Contains(item))
				{
					this.method_3().list_0.Add(item);
					this.method_6();
				}
			}
		}

		// Token: 0x06007933 RID: 31027 RVA: 0x0041EBB8 File Offset: 0x0041CDB8
		private void method_12(object sender, EventArgs e)
		{
			if (this.vmethod_42().SelectedIndex >= 0)
			{
				EventAction item = (EventAction)((ComboBoxItem)this.vmethod_42().SelectedItem).Tag;
				if (!this.method_3().list_2.Contains(item))
				{
					this.method_3().list_2.Add(item);
					this.method_6();
				}
			}
		}

		// Token: 0x06007934 RID: 31028 RVA: 0x0041EC18 File Offset: 0x0041CE18
		private void method_13(object sender, EventArgs e)
		{
			if (this.vmethod_6().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_6().SelectedRows[0].Cells[0].Value);
				EventTrigger item = Client.smethod_46().vmethod_4()[key];
				this.method_3().list_0.Remove(item);
				this.method_6();
			}
		}

		// Token: 0x06007935 RID: 31029 RVA: 0x0041EC88 File Offset: 0x0041CE88
		private void method_14(object sender, EventArgs e)
		{
			if (this.vmethod_20().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_20().SelectedRows[0].Cells[0].Value);
				EventAction item = Client.smethod_46().vmethod_8()[key];
				this.method_3().list_2.Remove(item);
				this.method_6();
			}
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x0041ECF8 File Offset: 0x0041CEF8
		private void method_15(object sender, EventArgs e)
		{
			if (this.method_3().list_0.Count == 0)
			{
				DarkMessageBox.smethod_2("The event should have at least one trigger assigned.", "No trigger assigned!", Enum11.const_0);
				return;
			}
			if (this.method_3().list_2.Count == 0)
			{
				DarkMessageBox.smethod_2("The event should have at least one actions assigned.", "No actions assigned!", Enum11.const_0);
				return;
			}
			EditEvent.Enum206 @enum = this.enum206_0;
			if (@enum != EditEvent.Enum206.const_0)
			{
				if (@enum != EditEvent.Enum206.const_1)
				{
				}
			}
			else
			{
				Client.smethod_46().vmethod_10().Add(this.method_3().string_0, this.method_3());
			}
			base.Close();
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_16(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06007938 RID: 31032 RVA: 0x0004AECD File Offset: 0x000490CD
		private void method_17(object object_0)
		{
			this.method_3().string_2 = this.vmethod_0().Text;
		}

		// Token: 0x06007939 RID: 31033 RVA: 0x0041ED84 File Offset: 0x0041CF84
		private void method_18(object sender, EventArgs e)
		{
			if (this.vmethod_12().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_12().SelectedRows[0].Cells[0].Value);
				EventCondition item = Client.smethod_46().vmethod_6()[key];
				this.method_3().list_1.Remove(item);
				this.method_6();
			}
		}

		// Token: 0x0600793A RID: 31034 RVA: 0x0004AEE5 File Offset: 0x000490E5
		private void method_19(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_56().Value))
			{
				this.method_3().short_0 = (short)this.vmethod_56().Value;
			}
		}

		// Token: 0x0600793B RID: 31035 RVA: 0x0003F5F4 File Offset: 0x0003D7F4
		private void method_20(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_36().Show();
		}

		// Token: 0x0600793C RID: 31036 RVA: 0x0003F605 File Offset: 0x0003D805
		private void method_21(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_32().Show();
		}

		// Token: 0x0600793D RID: 31037 RVA: 0x0041EDF4 File Offset: 0x0041CFF4
		private void method_22(object sender, EventArgs e)
		{
			if (this.vmethod_36().SelectedIndex >= 0)
			{
				EventCondition item = (EventCondition)((ComboBoxItem)this.vmethod_36().SelectedItem).Tag;
				if (!this.method_3().list_1.Contains(item))
				{
					this.method_3().list_1.Add(item);
					this.method_6();
				}
			}
		}

		// Token: 0x0600793E RID: 31038 RVA: 0x0003F8C6 File Offset: 0x0003DAC6
		private void method_23(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_33().Show();
		}

		// Token: 0x0600793F RID: 31039 RVA: 0x003B6260 File Offset: 0x003B4460
		private void EditEvent_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06007940 RID: 31040 RVA: 0x0004AF15 File Offset: 0x00049115
		private void EditEvent_FormClosed(object sender, FormClosedEventArgs e)
		{
			Scenario.smethod_10(new Scenario.EventTriggersChangedEventHandler(this.method_5));
			Scenario.smethod_12(new Scenario.EventConditionsChangedEventHandler(this.method_5));
			Scenario.smethod_14(new Scenario.EventActionsChangedEventHandler(this.method_5));
		}

		// Token: 0x040043A4 RID: 17316
		[AccessedThroughProperty("TextBox1")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x040043A5 RID: 17317
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_0;

		// Token: 0x040043A6 RID: 17318
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_1;

		// Token: 0x040043A7 RID: 17319
		[AccessedThroughProperty("DGV_Triggers")]
		[CompilerGenerated]
		private Class114 class114_0;

		// Token: 0x040043A8 RID: 17320
		[CompilerGenerated]
		[AccessedThroughProperty("ID")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x040043A9 RID: 17321
		[AccessedThroughProperty("Description")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x040043AA RID: 17322
		[CompilerGenerated]
		[AccessedThroughProperty("DGV_Conditions")]
		private Class114 class114_1;

		// Token: 0x040043AB RID: 17323
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x040043AC RID: 17324
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x040043AD RID: 17325
		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		private Class116 class116_2;

		// Token: 0x040043AE RID: 17326
		[AccessedThroughProperty("DGV_Actions")]
		[CompilerGenerated]
		private Class114 class114_2;

		// Token: 0x040043AF RID: 17327
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x040043B0 RID: 17328
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn4")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x040043B1 RID: 17329
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x040043B2 RID: 17330
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_0;

		// Token: 0x040043B3 RID: 17331
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Triggers")]
		private Class2451 class2451_0;

		// Token: 0x040043B4 RID: 17332
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_1;

		// Token: 0x040043B5 RID: 17333
		[AccessedThroughProperty("Button3")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x040043B6 RID: 17334
		[AccessedThroughProperty("CB_Conditions")]
		[CompilerGenerated]
		private Class2451 class2451_1;

		// Token: 0x040043B7 RID: 17335
		[AccessedThroughProperty("Button4")]
		[CompilerGenerated]
		private Control9 control9_3;

		// Token: 0x040043B8 RID: 17336
		[CompilerGenerated]
		[AccessedThroughProperty("Button5")]
		private Control9 control9_4;

		// Token: 0x040043B9 RID: 17337
		[AccessedThroughProperty("CB_Actions")]
		[CompilerGenerated]
		private Class2451 class2451_2;

		// Token: 0x040043BA RID: 17338
		[AccessedThroughProperty("Button6")]
		[CompilerGenerated]
		private Control9 control9_5;

		// Token: 0x040043BB RID: 17339
		[CompilerGenerated]
		[AccessedThroughProperty("Button7")]
		private Control9 control9_6;

		// Token: 0x040043BC RID: 17340
		[CompilerGenerated]
		[AccessedThroughProperty("Button8")]
		private Control9 control9_7;

		// Token: 0x040043BD RID: 17341
		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_IsRepeatable")]
		private Class112 class112_0;

		// Token: 0x040043BE RID: 17342
		[AccessedThroughProperty("CheckBox_IsActive")]
		[CompilerGenerated]
		private Class112 class112_1;

		// Token: 0x040043BF RID: 17343
		[AccessedThroughProperty("Label5")]
		[CompilerGenerated]
		private Class116 class116_4;

		// Token: 0x040043C0 RID: 17344
		[CompilerGenerated]
		[AccessedThroughProperty("NUD_Probability")]
		private Control10 control10_0;

		// Token: 0x040043C1 RID: 17345
		[AccessedThroughProperty("Button_EditTriggers")]
		[CompilerGenerated]
		private Control9 control9_8;

		// Token: 0x040043C2 RID: 17346
		[AccessedThroughProperty("Button_EditActions")]
		[CompilerGenerated]
		private Control9 control9_9;

		// Token: 0x040043C3 RID: 17347
		[AccessedThroughProperty("Button_EditConditions")]
		[CompilerGenerated]
		private Control9 control9_10;

		// Token: 0x040043C4 RID: 17348
		[AccessedThroughProperty("CheckBox_IsShown")]
		[CompilerGenerated]
		private Class112 class112_2;

		// Token: 0x040043C5 RID: 17349
		private SimEvent simEvent_0;

		// Token: 0x040043C6 RID: 17350
		public EditEvent.Enum206 enum206_0;

		// Token: 0x02000EB4 RID: 3764
		internal enum Enum206 : byte
		{
			// Token: 0x040043C8 RID: 17352
			const_0,
			// Token: 0x040043C9 RID: 17353
			const_1
		}
	}
}
