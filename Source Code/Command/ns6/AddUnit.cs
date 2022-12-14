using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000F01 RID: 3841
	[DesignerGenerated]
	internal sealed partial class AddUnit : DarkSecondaryFormBase
	{
		// Token: 0x060087DF RID: 34783 RVA: 0x0048CB24 File Offset: 0x0048AD24
		public AddUnit()
		{
			base.FormClosing += this.AddUnit_FormClosing;
			base.Shown += this.AddUnit_Shown;
			base.KeyDown += this.AddUnit_KeyDown;
			base.FormClosed += this.AddUnit_FormClosed;
			base.Load += this.AddUnit_Load;
			this.dataTable_0 = new DataTable();
			this.dateTime_0 = default(DateTime);
			this.string_0 = null;
			this.InitializeComponent_1();
		}

		// Token: 0x060087E1 RID: 34785 RVA: 0x0048CBB8 File Offset: 0x0048ADB8
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_1(new Class116());
			this.vmethod_3(new Class2451());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Control9());
			this.vmethod_9(new Control9());
			this.vmethod_11(new Class114());
			this.vmethod_39(new DataGridViewTextBoxColumn());
			this.vmethod_41(new DataGridViewLinkColumn());
			this.vmethod_43(new DataGridViewTextBoxColumn());
			this.vmethod_45(new DataGridViewTextBoxColumn());
			this.vmethod_47(new DataGridViewTextBoxColumn());
			this.vmethod_49(new DataGridViewTextBoxColumn());
			this.vmethod_51(new DataGridViewCheckBoxColumn());
			this.vmethod_53(new DataGridViewTextBoxColumn());
			this.vmethod_13(new Class116());
			this.vmethod_15(new Class2451());
			this.vmethod_17(new Control9());
			this.vmethod_19(new Control8());
			this.vmethod_21(new Class115());
			this.vmethod_31(new Class2451());
			this.vmethod_33(new Class116());
			this.vmethod_27(new Class2451());
			this.vmethod_23(new Class116());
			this.vmethod_25(new Class116());
			this.vmethod_29(new Control8());
			this.vmethod_37(new Class116());
			this.vmethod_35(new Control8());
			((ISupportInitialize)this.vmethod_10()).BeginInit();
			this.vmethod_20().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().method_2(true);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(9, 15);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new Size(35, 15);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Type:";
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_2().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_2().Font = new Font("Segoe UI", 7f);
			this.vmethod_2().FormattingEnabled = true;
			this.vmethod_2().Items.AddRange(new object[]
			{
				"Aircraft",
				"Surface Ship",
				"Submarine",
				"Facility"
			});
			this.vmethod_2().Location = new Point(54, 13);
			this.vmethod_2().Name = "CB_Type";
			this.vmethod_2().Size = new Size(326, 21);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().method_2(true);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(9, 67);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new Size(42, 15);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "Name:";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.None;
			this.vmethod_6().Font = new Font("Segoe UI", 10f);
			this.vmethod_6().ForeColor = SystemColors.Control;
			this.vmethod_6().Location = new Point(12, 585);
			this.vmethod_6().Name = "Button1";
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(75, 23);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_6().Text = "OK";
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().DialogResult = DialogResult.None;
			this.vmethod_8().Font = new Font("Segoe UI", 10f);
			this.vmethod_8().ForeColor = SystemColors.Control;
			this.vmethod_8().Location = new Point(394, 585);
			this.vmethod_8().Name = "Button2";
			this.vmethod_8().method_1(0);
			this.vmethod_8().Size = new Size(75, 23);
			this.vmethod_8().TabIndex = 5;
			this.vmethod_8().Text = "Cancel";
			this.vmethod_10().AllowUserToAddRows = false;
			this.vmethod_10().AllowUserToDeleteRows = false;
			this.vmethod_10().AllowUserToResizeColumns = false;
			this.vmethod_10().AllowUserToResizeRows = false;
			this.vmethod_10().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_10().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_10().CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.vmethod_10().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_10().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_10().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_10().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_38(),
				this.vmethod_40(),
				this.vmethod_42(),
				this.vmethod_44(),
				this.vmethod_46(),
				this.vmethod_48(),
				this.vmethod_50(),
				this.vmethod_52()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_10().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_10().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_10().EnableHeadersVisualStyles = false;
			this.vmethod_10().Location = new Point(12, 190);
			this.vmethod_10().MultiSelect = false;
			this.vmethod_10().Name = "DataGridView1";
			this.vmethod_10().ReadOnly = true;
			this.vmethod_10().RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_10().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_10().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_10().Size = new Size(457, 389);
			this.vmethod_10().TabIndex = 6;
			this.vmethod_38().DataPropertyName = "ID";
			this.vmethod_38().HeaderText = "ID";
			this.vmethod_38().Name = "ID";
			this.vmethod_38().ReadOnly = true;
			this.vmethod_38().Visible = false;
			this.vmethod_40().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_40().DataPropertyName = "LongName";
			this.vmethod_40().HeaderText = "Platform";
			this.vmethod_40().LinkColor = Color.LightBlue;
			this.vmethod_40().Name = "FullName";
			this.vmethod_40().ReadOnly = true;
			this.vmethod_40().Resizable = DataGridViewTriState.True;
			this.vmethod_40().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_40().Width = 230;
			this.vmethod_42().DataPropertyName = "Name";
			this.vmethod_42().HeaderText = "ShortName";
			this.vmethod_42().Name = "ShortName";
			this.vmethod_42().ReadOnly = true;
			this.vmethod_42().Visible = false;
			this.vmethod_44().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_44().DataPropertyName = "CountryString";
			this.vmethod_44().HeaderText = "Country";
			this.vmethod_44().Name = "Country";
			this.vmethod_44().ReadOnly = true;
			this.vmethod_44().Width = 73;
			this.vmethod_46().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_46().DataPropertyName = "YearCommissioned";
			this.vmethod_46().HeaderText = "From";
			this.vmethod_46().Name = "IOC";
			this.vmethod_46().ReadOnly = true;
			this.vmethod_46().Width = 58;
			this.vmethod_48().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_48().DataPropertyName = "YearDecommissioned";
			this.vmethod_48().HeaderText = "Until";
			this.vmethod_48().Name = "Retired";
			this.vmethod_48().ReadOnly = true;
			this.vmethod_48().Width = 55;
			this.vmethod_50().AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.vmethod_50().DataPropertyName = "Hypothetical";
			this.vmethod_50().FalseValue = "False";
			this.vmethod_50().HeaderText = "Hypo";
			this.vmethod_50().Name = "Hypothetical";
			this.vmethod_50().ReadOnly = true;
			this.vmethod_50().Resizable = DataGridViewTriState.True;
			this.vmethod_50().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_50().TrueValue = "True";
			this.vmethod_50().Width = 59;
			this.vmethod_52().DataPropertyName = "OperatorCountry";
			this.vmethod_52().HeaderText = "Operator";
			this.vmethod_52().Name = "CountryNumber";
			this.vmethod_52().ReadOnly = true;
			this.vmethod_52().Visible = false;
			this.vmethod_12().method_2(true);
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Location = new Point(9, 43);
			this.vmethod_12().Name = "Label3";
			this.vmethod_12().Size = new Size(32, 15);
			this.vmethod_12().TabIndex = 7;
			this.vmethod_12().Text = "Side:";
			this.vmethod_14().BackColor = Color.Transparent;
			this.vmethod_14().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_14().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_14().Font = new Font("Segoe UI", 7f);
			this.vmethod_14().FormattingEnabled = true;
			this.vmethod_14().Items.AddRange(new object[]
			{
				"Aircraft"
			});
			this.vmethod_14().Location = new Point(54, 38);
			this.vmethod_14().Name = "CB_Sides";
			this.vmethod_14().Size = new Size(326, 21);
			this.vmethod_14().TabIndex = 8;
			this.vmethod_16().BackColor = Color.Transparent;
			this.vmethod_16().DialogResult = DialogResult.None;
			this.vmethod_16().Font = new Font("Segoe UI", 10f);
			this.vmethod_16().ForeColor = SystemColors.Control;
			this.vmethod_16().Location = new Point(386, 38);
			this.vmethod_16().Name = "Button3";
			this.vmethod_16().method_1(0);
			this.vmethod_16().Size = new Size(83, 21);
			this.vmethod_16().TabIndex = 9;
			this.vmethod_16().Text = "Edit sides...";
			this.vmethod_18().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_18().method_14(null);
			this.vmethod_18().method_15(AutoCompleteMode.None);
			this.vmethod_18().method_13(AutoCompleteSource.None);
			this.vmethod_18().BackColor = Color.Transparent;
			this.vmethod_18().method_17(new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161));
			this.vmethod_18().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_18().method_12(null);
			this.vmethod_18().method_18(null);
			this.vmethod_18().Location = new Point(88, 15);
			this.vmethod_18().method_2(32767);
			this.vmethod_18().method_7(false);
			this.vmethod_18().Name = "TB_Class";
			this.vmethod_18().method_3(false);
			this.vmethod_18().method_9(0);
			this.vmethod_18().Size = new Size(132, 22);
			this.vmethod_18().TabIndex = 10;
			this.vmethod_18().method_1(HorizontalAlignment.Left);
			this.vmethod_18().method_5(false);
			this.vmethod_18().method_10("");
			this.vmethod_20().Controls.Add(this.vmethod_30());
			this.vmethod_20().Controls.Add(this.vmethod_32());
			this.vmethod_20().Controls.Add(this.vmethod_26());
			this.vmethod_20().Controls.Add(this.vmethod_22());
			this.vmethod_20().Controls.Add(this.vmethod_24());
			this.vmethod_20().Controls.Add(this.vmethod_18());
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Location = new Point(12, 89);
			this.vmethod_20().Name = "GroupBox1";
			this.vmethod_20().Size = new Size(457, 71);
			this.vmethod_20().TabIndex = 12;
			this.vmethod_20().TabStop = false;
			this.vmethod_20().Text = "Filter by...";
			this.vmethod_30().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_30().BackColor = Color.Transparent;
			this.vmethod_30().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_30().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_30().Font = new Font("Segoe UI", 7f);
			this.vmethod_30().FormattingEnabled = true;
			this.vmethod_30().Items.AddRange(new object[]
			{
				"Aircraft"
			});
			this.vmethod_30().Location = new Point(88, 41);
			this.vmethod_30().Name = "CB_Hypothetical";
			this.vmethod_30().Size = new Size(363, 21);
			this.vmethod_30().TabIndex = 18;
			this.vmethod_32().method_2(true);
			this.vmethod_32().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_32().Location = new Point(6, 45);
			this.vmethod_32().Name = "Label7";
			this.vmethod_32().Size = new Size(78, 15);
			this.vmethod_32().TabIndex = 17;
			this.vmethod_32().Text = "Hypothetical:";
			this.vmethod_26().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_26().BackColor = Color.Transparent;
			this.vmethod_26().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_26().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_26().Font = new Font("Segoe UI", 7f);
			this.vmethod_26().FormattingEnabled = true;
			this.vmethod_26().Items.AddRange(new object[]
			{
				"Aircraft"
			});
			this.vmethod_26().Location = new Point(278, 15);
			this.vmethod_26().Name = "CB_Country";
			this.vmethod_26().Size = new Size(173, 21);
			this.vmethod_26().TabIndex = 13;
			this.vmethod_22().method_2(true);
			this.vmethod_22().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_22().Location = new Point(226, 20);
			this.vmethod_22().Name = "Label5";
			this.vmethod_22().Size = new Size(53, 15);
			this.vmethod_22().TabIndex = 12;
			this.vmethod_22().Text = "Country:";
			this.vmethod_24().method_2(true);
			this.vmethod_24().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_24().Location = new Point(7, 20);
			this.vmethod_24().Name = "Label4";
			this.vmethod_24().Size = new Size(37, 15);
			this.vmethod_24().TabIndex = 11;
			this.vmethod_24().Text = "Class:";
			this.vmethod_28().method_14(null);
			this.vmethod_28().method_15(AutoCompleteMode.None);
			this.vmethod_28().method_13(AutoCompleteSource.None);
			this.vmethod_28().BackColor = Color.Transparent;
			this.vmethod_28().method_17(new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161));
			this.vmethod_28().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_28().method_12(null);
			this.vmethod_28().method_18(null);
			this.vmethod_28().Location = new Point(54, 64);
			this.vmethod_28().method_2(32767);
			this.vmethod_28().method_7(false);
			this.vmethod_28().Name = "TextBox1";
			this.vmethod_28().method_3(false);
			this.vmethod_28().method_9(0);
			this.vmethod_28().Size = new Size(415, 24);
			this.vmethod_28().TabIndex = 3;
			this.vmethod_28().method_1(HorizontalAlignment.Left);
			this.vmethod_28().method_5(false);
			this.vmethod_28().method_10("");
			this.vmethod_36().method_2(true);
			this.vmethod_36().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_36().Location = new Point(12, 171);
			this.vmethod_36().Name = "Label6";
			this.vmethod_36().Size = new Size(82, 15);
			this.vmethod_36().TabIndex = 13;
			this.vmethod_36().Text = "Custom GUID:";
			this.vmethod_34().method_14(null);
			this.vmethod_34().method_15(AutoCompleteMode.None);
			this.vmethod_34().method_13(AutoCompleteSource.None);
			this.vmethod_34().BackColor = Color.Transparent;
			this.vmethod_34().method_17(new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161));
			this.vmethod_34().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_34().method_12(null);
			this.vmethod_34().method_18(null);
			this.vmethod_34().Location = new Point(100, 166);
			this.vmethod_34().method_2(32767);
			this.vmethod_34().method_7(false);
			this.vmethod_34().Name = "TB_CustomGUID";
			this.vmethod_34().method_3(false);
			this.vmethod_34().method_9(0);
			this.vmethod_34().Size = new Size(369, 22);
			this.vmethod_34().TabIndex = 14;
			this.vmethod_34().method_1(HorizontalAlignment.Left);
			this.vmethod_34().method_5(false);
			this.vmethod_34().method_10("");
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(481, 620);
			base.Controls.Add(this.vmethod_34());
			base.Controls.Add(this.vmethod_36());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AddUnit";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Add new unit";
			((ISupportInitialize)this.vmethod_10()).EndInit();
			this.vmethod_20().ResumeLayout(false);
			this.vmethod_20().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060087E2 RID: 34786 RVA: 0x00051BDF File Offset: 0x0004FDDF
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x060087E3 RID: 34787 RVA: 0x00051BE7 File Offset: 0x0004FDE7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_7)
		{
			this.class116_0 = class116_7;
		}

		// Token: 0x060087E4 RID: 34788 RVA: 0x00051BF0 File Offset: 0x0004FDF0
		[CompilerGenerated]
		internal Class2451 vmethod_2()
		{
			return this.class2451_0;
		}

		// Token: 0x060087E5 RID: 34789 RVA: 0x0048E168 File Offset: 0x0048C368
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class2451 class2451_4)
		{
			EventHandler value = new EventHandler(this.method_12);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_4;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060087E6 RID: 34790 RVA: 0x00051BF8 File Offset: 0x0004FDF8
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_1;
		}

		// Token: 0x060087E7 RID: 34791 RVA: 0x00051C00 File Offset: 0x0004FE00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_7)
		{
			this.class116_1 = class116_7;
		}

		// Token: 0x060087E8 RID: 34792 RVA: 0x00051C09 File Offset: 0x0004FE09
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_0;
		}

		// Token: 0x060087E9 RID: 34793 RVA: 0x0048E1AC File Offset: 0x0048C3AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_3;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060087EA RID: 34794 RVA: 0x00051C11 File Offset: 0x0004FE11
		[CompilerGenerated]
		internal Control9 vmethod_8()
		{
			return this.control9_1;
		}

		// Token: 0x060087EB RID: 34795 RVA: 0x0048E1F0 File Offset: 0x0048C3F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_5);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_3;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060087EC RID: 34796 RVA: 0x00051C19 File Offset: 0x0004FE19
		[CompilerGenerated]
		internal Class114 vmethod_10()
		{
			return this.class114_0;
		}

		// Token: 0x060087ED RID: 34797 RVA: 0x0048E234 File Offset: 0x0048C434
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class114 class114_1)
		{
			KeyPressEventHandler value = new KeyPressEventHandler(this.method_8);
			EventHandler value2 = new EventHandler(this.method_11);
			DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.method_14);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.KeyPress -= value;
				@class.SelectionChanged -= value2;
				@class.CellContentClick -= value3;
			}
			this.class114_0 = class114_1;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.KeyPress += value;
				@class.SelectionChanged += value2;
				@class.CellContentClick += value3;
			}
		}

		// Token: 0x060087EE RID: 34798 RVA: 0x00051C21 File Offset: 0x0004FE21
		[CompilerGenerated]
		internal Class116 vmethod_12()
		{
			return this.class116_2;
		}

		// Token: 0x060087EF RID: 34799 RVA: 0x00051C29 File Offset: 0x0004FE29
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class116 class116_7)
		{
			this.class116_2 = class116_7;
		}

		// Token: 0x060087F0 RID: 34800 RVA: 0x00051C32 File Offset: 0x0004FE32
		[CompilerGenerated]
		internal Class2451 vmethod_14()
		{
			return this.class2451_1;
		}

		// Token: 0x060087F1 RID: 34801 RVA: 0x00051C3A File Offset: 0x0004FE3A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class2451 class2451_4)
		{
			this.class2451_1 = class2451_4;
		}

		// Token: 0x060087F2 RID: 34802 RVA: 0x00051C43 File Offset: 0x0004FE43
		[CompilerGenerated]
		internal Control9 vmethod_16()
		{
			return this.control9_2;
		}

		// Token: 0x060087F3 RID: 34803 RVA: 0x0048E2B0 File Offset: 0x0048C4B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_6);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_3;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060087F4 RID: 34804 RVA: 0x00051C4B File Offset: 0x0004FE4B
		[CompilerGenerated]
		internal Control8 vmethod_18()
		{
			return this.control8_0;
		}

		// Token: 0x060087F5 RID: 34805 RVA: 0x00051C53 File Offset: 0x0004FE53
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Control8 control8_3)
		{
			this.control8_0 = control8_3;
		}

		// Token: 0x060087F6 RID: 34806 RVA: 0x00051C5C File Offset: 0x0004FE5C
		[CompilerGenerated]
		internal Class115 vmethod_20()
		{
			return this.class115_0;
		}

		// Token: 0x060087F7 RID: 34807 RVA: 0x00051C64 File Offset: 0x0004FE64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class115 class115_1)
		{
			this.class115_0 = class115_1;
		}

		// Token: 0x060087F8 RID: 34808 RVA: 0x00051C6D File Offset: 0x0004FE6D
		[CompilerGenerated]
		internal Class116 vmethod_22()
		{
			return this.class116_3;
		}

		// Token: 0x060087F9 RID: 34809 RVA: 0x00051C75 File Offset: 0x0004FE75
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class116 class116_7)
		{
			this.class116_3 = class116_7;
		}

		// Token: 0x060087FA RID: 34810 RVA: 0x00051C7E File Offset: 0x0004FE7E
		[CompilerGenerated]
		internal Class116 vmethod_24()
		{
			return this.class116_4;
		}

		// Token: 0x060087FB RID: 34811 RVA: 0x00051C86 File Offset: 0x0004FE86
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class116 class116_7)
		{
			this.class116_4 = class116_7;
		}

		// Token: 0x060087FC RID: 34812 RVA: 0x00051C8F File Offset: 0x0004FE8F
		[CompilerGenerated]
		internal Class2451 vmethod_26()
		{
			return this.class2451_2;
		}

		// Token: 0x060087FD RID: 34813 RVA: 0x0048E2F4 File Offset: 0x0048C4F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class2451 class2451_4)
		{
			EventHandler value = new EventHandler(this.method_13);
			Class2451 @class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_2 = class2451_4;
			@class = this.class2451_2;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060087FE RID: 34814 RVA: 0x00051C97 File Offset: 0x0004FE97
		[CompilerGenerated]
		internal Control8 vmethod_28()
		{
			return this.control8_1;
		}

		// Token: 0x060087FF RID: 34815 RVA: 0x0048E338 File Offset: 0x0048C538
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Control8 control8_3)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_4);
			Control8 control = this.control8_1;
			if (control != null)
			{
				control.method_22(delegate85_);
			}
			this.control8_1 = control8_3;
			control = this.control8_1;
			if (control != null)
			{
				control.method_21(delegate85_);
			}
		}

		// Token: 0x06008800 RID: 34816 RVA: 0x00051C9F File Offset: 0x0004FE9F
		[CompilerGenerated]
		internal Class2451 vmethod_30()
		{
			return this.class2451_3;
		}

		// Token: 0x06008801 RID: 34817 RVA: 0x0048E37C File Offset: 0x0048C57C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class2451 class2451_4)
		{
			EventHandler value = new EventHandler(this.method_15);
			Class2451 @class = this.class2451_3;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_3 = class2451_4;
			@class = this.class2451_3;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06008802 RID: 34818 RVA: 0x00051CA7 File Offset: 0x0004FEA7
		[CompilerGenerated]
		internal Class116 vmethod_32()
		{
			return this.class116_5;
		}

		// Token: 0x06008803 RID: 34819 RVA: 0x00051CAF File Offset: 0x0004FEAF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Class116 class116_7)
		{
			this.class116_5 = class116_7;
		}

		// Token: 0x06008804 RID: 34820 RVA: 0x00051CB8 File Offset: 0x0004FEB8
		[CompilerGenerated]
		internal Control8 vmethod_34()
		{
			return this.control8_2;
		}

		// Token: 0x06008805 RID: 34821 RVA: 0x00051CC0 File Offset: 0x0004FEC0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Control8 control8_3)
		{
			this.control8_2 = control8_3;
		}

		// Token: 0x06008806 RID: 34822 RVA: 0x00051CC9 File Offset: 0x0004FEC9
		[CompilerGenerated]
		internal Class116 vmethod_36()
		{
			return this.class116_6;
		}

		// Token: 0x06008807 RID: 34823 RVA: 0x00051CD1 File Offset: 0x0004FED1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Class116 class116_7)
		{
			this.class116_6 = class116_7;
		}

		// Token: 0x06008808 RID: 34824 RVA: 0x00051CDA File Offset: 0x0004FEDA
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_38()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06008809 RID: 34825 RVA: 0x00051CE2 File Offset: 0x0004FEE2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x0600880A RID: 34826 RVA: 0x00051CEB File Offset: 0x0004FEEB
		[CompilerGenerated]
		internal DataGridViewLinkColumn vmethod_40()
		{
			return this.dataGridViewLinkColumn_0;
		}

		// Token: 0x0600880B RID: 34827 RVA: 0x00051CF3 File Offset: 0x0004FEF3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(DataGridViewLinkColumn dataGridViewLinkColumn_1)
		{
			this.dataGridViewLinkColumn_0 = dataGridViewLinkColumn_1;
		}

		// Token: 0x0600880C RID: 34828 RVA: 0x00051CFC File Offset: 0x0004FEFC
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_42()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x0600880D RID: 34829 RVA: 0x00051D04 File Offset: 0x0004FF04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x0600880E RID: 34830 RVA: 0x00051D0D File Offset: 0x0004FF0D
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_44()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600880F RID: 34831 RVA: 0x00051D15 File Offset: 0x0004FF15
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06008810 RID: 34832 RVA: 0x00051D1E File Offset: 0x0004FF1E
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_46()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06008811 RID: 34833 RVA: 0x00051D26 File Offset: 0x0004FF26
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06008812 RID: 34834 RVA: 0x00051D2F File Offset: 0x0004FF2F
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_48()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06008813 RID: 34835 RVA: 0x00051D37 File Offset: 0x0004FF37
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06008814 RID: 34836 RVA: 0x00051D40 File Offset: 0x0004FF40
		[CompilerGenerated]
		internal DataGridViewCheckBoxColumn vmethod_50()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x06008815 RID: 34837 RVA: 0x00051D48 File Offset: 0x0004FF48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x06008816 RID: 34838 RVA: 0x00051D51 File Offset: 0x0004FF51
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_52()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x06008817 RID: 34839 RVA: 0x00051D59 File Offset: 0x0004FF59
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06008818 RID: 34840 RVA: 0x0048E3C0 File Offset: 0x0048C5C0
		private void method_3(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.vmethod_28().Text, "", false) == 0)
			{
				DarkMessageBox.smethod_1("You need to provide a name for the new unit.", "No name?", Enum11.const_0);
				return;
			}
			if (this.vmethod_10().SelectedRows.Count != 0)
			{
				if (!string.IsNullOrEmpty(this.vmethod_34().Text))
				{
					this.string_0 = this.vmethod_34().Text;
				}
				Geopoint_Struct geopoint_Struct_ = Class2413.smethod_2().method_41().geopoint_Struct_0;
				switch (this.vmethod_2().SelectedIndex)
				{
				case 0:
				{
					new DataTable();
					int aircraftID = Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells["ID"].Value.ToString());
					Dictionary<int, int> selectedAircraftTotalWeaponQty = null;
					SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
					Scenario theScen = Client.smethod_46();
					bool flag = false;
					Scenario scenario = null;
					Aircraft aircraft = null;
					int num = 0;
					bool flag2 = false;
					if (DBFunctions.smethod_42(aircraftID, selectedAircraftTotalWeaponQty, ref sqliteConnection, theScen, ref flag, ref scenario, ref aircraft, ref num, ref flag2).Rows.Count == 0)
					{
						Client.smethod_46().method_71(Client.smethod_46().method_44()[this.vmethod_14().SelectedIndex], this.vmethod_28().Text, geopoint_Struct_.double_0, geopoint_Struct_.double_1, Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells["ID"].Value.ToString()), 0, 1000f, (Unit.Enum122)Conversions.ToShort(this.string_0), null);
						base.Close();
						return;
					}
					Class2413.smethod_2().method_62().string_0 = this.vmethod_28().Text;
					Class2413.smethod_2().method_62().int_0 = Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells["ID"].Value.ToString());
					Class2413.smethod_2().method_62().side_0 = Client.smethod_46().method_44()[this.vmethod_14().SelectedIndex];
					Class2413.smethod_2().method_62().Show();
					return;
				}
				case 1:
					try
					{
						Client.smethod_46().method_73(Client.smethod_46().method_44()[this.vmethod_14().SelectedIndex], Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells["ID"].Value.ToString()), this.vmethod_28().Text, geopoint_Struct_.double_0, geopoint_Struct_.double_1, false, Unit.Enum122.const_0, this.string_0);
						goto IL_408;
					}
					catch (Exception ex)
					{
						DarkMessageBox.smethod_2("Error: " + ex.Message, "Error", Enum11.const_0);
						return;
					}
					break;
				case 2:
					break;
				case 3:
					goto IL_36A;
				case 4:
				case 5:
					goto IL_408;
				default:
					goto IL_408;
				}
				try
				{
					Client.smethod_46().method_75(Client.smethod_46().method_44()[this.vmethod_14().SelectedIndex], Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells["ID"].Value.ToString()), this.vmethod_28().Text, geopoint_Struct_.double_0, geopoint_Struct_.double_1, false, Unit.Enum122.const_0, this.string_0);
					goto IL_408;
				}
				catch (Exception ex2)
				{
					DarkMessageBox.smethod_2("Error: " + ex2.Message, "Error", Enum11.const_0);
					return;
				}
				IL_36A:
				try
				{
					Client.smethod_46().method_76(Client.smethod_46().method_44()[this.vmethod_14().SelectedIndex], Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells["ID"].Value.ToString()), this.vmethod_28().Text, geopoint_Struct_.double_0, geopoint_Struct_.double_1, false, Unit.Enum122.const_0, this.string_0);
				}
				catch (Exception ex3)
				{
					DarkMessageBox.smethod_2("Error: " + ex3.Message, "Error", Enum11.const_0);
					return;
				}
				IL_408:
				if (Client.smethod_46().method_44().Length == 1)
				{
					Client.smethod_51(Client.smethod_46().method_44()[0]);
				}
				base.Close();
			}
		}

		// Token: 0x06008819 RID: 34841 RVA: 0x00051D62 File Offset: 0x0004FF62
		private void AddUnit_FormClosing(object sender, FormClosingEventArgs e)
		{
			Client.smethod_62(Client.Enum197.const_0);
			Class2413.smethod_2().method_41().Enabled = true;
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x0600881A RID: 34842 RVA: 0x00051D89 File Offset: 0x0004FF89
		private void method_4(object object_0)
		{
			this.vmethod_6().Enabled = (Operators.CompareString(this.vmethod_28().Text, "", false) != 0);
		}

		// Token: 0x0600881B RID: 34843 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_5(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600881C RID: 34844 RVA: 0x0003F169 File Offset: 0x0003D369
		private void method_6(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_64().Show();
		}

		// Token: 0x0600881D RID: 34845 RVA: 0x0048E824 File Offset: 0x0048CA24
		public void method_7()
		{
			this.vmethod_14().Items.Clear();
			foreach (Side side in Client.smethod_46().method_44())
			{
				this.vmethod_14().Items.Add(side.method_51());
			}
			if (this.vmethod_14().Items.Count > 0)
			{
				this.vmethod_14().SelectedIndex = Array.IndexOf<Side>(Client.smethod_46().method_44(), Client.smethod_50());
			}
			this.vmethod_6().Enabled = (this.vmethod_14().Items.Count > 0 & !Information.IsNothing(this.vmethod_14().SelectedIndex));
		}

		// Token: 0x0600881E RID: 34846 RVA: 0x0048E8E0 File Offset: 0x0048CAE0
		private void method_8(object sender, KeyPressEventArgs e)
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "LongName ASC";
			dataView.RowFilter = "LongName LIKE '" + Conversions.ToString(e.KeyChar) + "%'";
			if (dataView.Count > 0)
			{
				int num = Conversions.ToInteger(dataView[0][0].ToString());
				int index;
				try
				{
					foreach (object obj in ((IEnumerable)this.vmethod_10().Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (Conversions.ToInteger(dataGridViewRow.Cells[0].Value) == num)
						{
							index = dataGridViewRow.Index;
							break;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.vmethod_10().FirstDisplayedScrollingRowIndex = index;
			}
		}

		// Token: 0x0600881F RID: 34847 RVA: 0x00051DAF File Offset: 0x0004FFAF
		private void method_9(object object_0)
		{
			this.method_10();
		}

		// Token: 0x06008820 RID: 34848 RVA: 0x0048E9C8 File Offset: 0x0048CBC8
		private void method_10()
		{
			Client.nullable_1 = new byte?((byte)this.vmethod_2().SelectedIndex);
			Client.nullable_2 = new int?(Conversions.ToInteger(this.vmethod_26().SelectedValue));
			Client.string_5 = this.vmethod_18().Text.Replace("'", "''");
			switch (this.vmethod_2().SelectedIndex)
			{
			case 0:
				this.dataTable_0 = Client.smethod_46().Cache_Aircraft_DT;
				break;
			case 1:
				this.dataTable_0 = Client.smethod_46().Cache_Ships_DT;
				break;
			case 2:
				this.dataTable_0 = Client.smethod_46().Cache_Subs_DT;
				break;
			case 3:
				this.dataTable_0 = Client.smethod_46().Cache_Facilities_DT;
				break;
			default:
				return;
			}
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "LongName ASC";
			if (Operators.CompareString(this.vmethod_18().Text, "", false) != 0 || this.vmethod_26().SelectedIndex != 0 || this.vmethod_30().SelectedIndex != 0)
			{
				string text = "1=1 ";
				if (Operators.CompareString(this.vmethod_18().Text, "", false) != 0)
				{
					string str = this.vmethod_18().Text.Replace("'", "''");
					text = text + " AND LongName LIKE '%" + str + "%' ";
				}
				if (this.vmethod_26().SelectedIndex > 0)
				{
					text = text + " AND OperatorCountry=" + Conversions.ToString(Conversions.ToInteger(this.vmethod_26().SelectedValue));
				}
				if (this.vmethod_30().SelectedIndex == 1)
				{
					text += " AND Hypothetical=FALSE";
				}
				else if (this.vmethod_30().SelectedIndex == 2)
				{
					text += " AND Hypothetical=TRUE";
				}
				text = text.Replace("[", "[[");
				text = text.Replace("]", "]]");
				text = text.Replace("[[", "[[]");
				text = text.Replace("]]", "[]]");
				dataView.RowFilter = text;
			}
			this.vmethod_10().SuspendLayout();
			this.vmethod_10().Enabled = false;
			this.vmethod_10().DataSource = dataView;
			this.vmethod_10().Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_10().Refresh();
			this.vmethod_10().Enabled = true;
			this.vmethod_10().ResumeLayout();
		}

		// Token: 0x06008821 RID: 34849 RVA: 0x0048EC34 File Offset: 0x0048CE34
		private void method_11(object sender, EventArgs e)
		{
			if (this.vmethod_10().SelectedRows.Count > 0)
			{
				this.vmethod_28().Text = Misc.smethod_9(Conversions.ToString(this.vmethod_10().SelectedRows[0].Cells[2].Value));
			}
		}

		// Token: 0x06008822 RID: 34850 RVA: 0x0048EC8C File Offset: 0x0048CE8C
		private void AddUnit_Shown(object sender, EventArgs e)
		{
			this.dateTime_0 = DateTime.UtcNow;
			this.vmethod_18().method_21(new Control8.Delegate85(this.method_9));
			this.vmethod_10().AutoGenerateColumns = false;
			DataTable cache_OperatorCountries_DT = Client.smethod_46().Cache_OperatorCountries_DT;
			this.vmethod_26().DataSource = cache_OperatorCountries_DT;
			this.vmethod_26().DisplayMember = "Description";
			this.vmethod_26().ValueMember = "ID";
			this.vmethod_26().SelectedIndex = 0;
			this.vmethod_30().Items.Clear();
			this.vmethod_30().Items.Add("Show all platforms, both real-life and hypothetical");
			this.vmethod_30().Items.Add("Show real-life platforms only");
			this.vmethod_30().Items.Add("Show hypothetical platforms only");
			this.vmethod_30().SelectedIndex = 0;
			this.vmethod_6().Enabled = (Operators.CompareString(this.vmethod_28().Text, "", false) != 0);
			this.vmethod_2().SelectedIndex = 0;
			this.vmethod_6().Enabled = false;
			this.method_7();
			if (Client.nullable_2 != null | !string.IsNullOrEmpty(Client.string_5) | Client.nullable_1 != null)
			{
				if (Client.nullable_2 != null)
				{
					this.vmethod_26().SelectedValue = Client.nullable_2;
				}
				if (Client.nullable_1 != null)
				{
					this.vmethod_2().SelectedIndex = (int)Client.nullable_1.Value;
				}
				if (!string.IsNullOrEmpty(Client.string_5))
				{
					this.vmethod_18().Text = Client.string_5;
				}
			}
			this.method_10();
		}

		// Token: 0x06008823 RID: 34851 RVA: 0x00051DB7 File Offset: 0x0004FFB7
		private void method_12(object sender, EventArgs e)
		{
			this.vmethod_18().method_20();
			this.method_10();
		}

		// Token: 0x06008824 RID: 34852 RVA: 0x00051DAF File Offset: 0x0004FFAF
		private void method_13(object sender, EventArgs e)
		{
			this.method_10();
		}

		// Token: 0x06008825 RID: 34853 RVA: 0x0004B8B4 File Offset: 0x00049AB4
		private void AddUnit_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x06008826 RID: 34854 RVA: 0x0048EE34 File Offset: 0x0048D034
		private void method_14(object sender, DataGridViewCellEventArgs e)
		{
			if (!(DateTime.UtcNow - this.dateTime_0 < TimeSpan.FromMilliseconds(500.0)) && e.RowIndex != -1 && this.vmethod_10().Columns[e.ColumnIndex].CellType == typeof(DataGridViewLinkCell))
			{
				int selectedObjectID = Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells["ID"].Value.ToString());
				string selectedObjectType;
				switch (this.vmethod_2().SelectedIndex)
				{
				case 0:
					selectedObjectType = "Aircraft";
					break;
				case 1:
					selectedObjectType = "Ship";
					break;
				case 2:
					selectedObjectType = "Submarine";
					break;
				case 3:
					selectedObjectType = "Facility";
					break;
				}
				Client.smethod_63(selectedObjectType, selectedObjectID, null);
			}
		}

		// Token: 0x06008827 RID: 34855 RVA: 0x00051DCA File Offset: 0x0004FFCA
		private void AddUnit_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.vmethod_18().method_22(new Control8.Delegate85(this.method_9));
		}

		// Token: 0x06008828 RID: 34856 RVA: 0x00051DAF File Offset: 0x0004FFAF
		private void method_15(object sender, EventArgs e)
		{
			this.method_10();
		}

		// Token: 0x06008829 RID: 34857 RVA: 0x00044489 File Offset: 0x00042689
		private void AddUnit_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x040049F0 RID: 18928
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x040049F1 RID: 18929
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Type")]
		private Class2451 class2451_0;

		// Token: 0x040049F2 RID: 18930
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_1;

		// Token: 0x040049F3 RID: 18931
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_0;

		// Token: 0x040049F4 RID: 18932
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_1;

		// Token: 0x040049F5 RID: 18933
		[AccessedThroughProperty("DataGridView1")]
		[CompilerGenerated]
		private Class114 class114_0;

		// Token: 0x040049F6 RID: 18934
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_2;

		// Token: 0x040049F7 RID: 18935
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Sides")]
		private Class2451 class2451_1;

		// Token: 0x040049F8 RID: 18936
		[CompilerGenerated]
		[AccessedThroughProperty("Button3")]
		private Control9 control9_2;

		// Token: 0x040049F9 RID: 18937
		[AccessedThroughProperty("TB_Class")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x040049FA RID: 18938
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox1")]
		private Class115 class115_0;

		// Token: 0x040049FB RID: 18939
		[CompilerGenerated]
		[AccessedThroughProperty("Label5")]
		private Class116 class116_3;

		// Token: 0x040049FC RID: 18940
		[CompilerGenerated]
		[AccessedThroughProperty("Label4")]
		private Class116 class116_4;

		// Token: 0x040049FD RID: 18941
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Country")]
		private Class2451 class2451_2;

		// Token: 0x040049FE RID: 18942
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private Control8 control8_1;

		// Token: 0x040049FF RID: 18943
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Hypothetical")]
		private Class2451 class2451_3;

		// Token: 0x04004A00 RID: 18944
		[CompilerGenerated]
		[AccessedThroughProperty("Label7")]
		private Class116 class116_5;

		// Token: 0x04004A01 RID: 18945
		[CompilerGenerated]
		[AccessedThroughProperty("TB_CustomGUID")]
		private Control8 control8_2;

		// Token: 0x04004A02 RID: 18946
		[CompilerGenerated]
		[AccessedThroughProperty("Label6")]
		private Class116 class116_6;

		// Token: 0x04004A03 RID: 18947
		[AccessedThroughProperty("ID")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04004A04 RID: 18948
		[CompilerGenerated]
		[AccessedThroughProperty("FullName")]
		private DataGridViewLinkColumn dataGridViewLinkColumn_0;

		// Token: 0x04004A05 RID: 18949
		[CompilerGenerated]
		[AccessedThroughProperty("ShortName")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04004A06 RID: 18950
		[AccessedThroughProperty("Country")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04004A07 RID: 18951
		[CompilerGenerated]
		[AccessedThroughProperty("IOC")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04004A08 RID: 18952
		[CompilerGenerated]
		[AccessedThroughProperty("Retired")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04004A09 RID: 18953
		[CompilerGenerated]
		[AccessedThroughProperty("Hypothetical")]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x04004A0A RID: 18954
		[AccessedThroughProperty("CountryNumber")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x04004A0B RID: 18955
		private DataTable dataTable_0;

		// Token: 0x04004A0C RID: 18956
		private DateTime dateTime_0;

		// Token: 0x04004A0D RID: 18957
		public string string_0;
	}
}
