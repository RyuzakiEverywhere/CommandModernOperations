using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns2;
using ns3;
using ns4;
using ns5;
using ns9;

namespace Command
{
	// Token: 0x02000E98 RID: 3736
	[DesignerGenerated]
	public sealed partial class EditAC : DarkSecondaryFormBase
	{
		// Token: 0x0600745D RID: 29789 RVA: 0x003ED2D4 File Offset: 0x003EB4D4
		public EditAC()
		{
			base.FormClosing += this.EditAC_FormClosing;
			base.Load += this.EditAC_Load;
			base.KeyDown += this.EditAC_KeyDown;
			base.Shown += this.EditAC_Shown;
			this.InitializeComponent_1();
		}

		// Token: 0x0600745F RID: 29791 RVA: 0x003ED378 File Offset: 0x003EB578
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_1(new Control4());
			this.vmethod_3(new Class116());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Class120());
			this.vmethod_9(new Control8());
			this.vmethod_11(new Class116());
			this.vmethod_13(new Control9());
			this.vmethod_15(new Class116());
			this.vmethod_17(new Control8());
			this.vmethod_19(new Control9());
			this.vmethod_21(new Class115());
			this.vmethod_23(new Control9());
			this.vmethod_25(new Class114());
			this.vmethod_43(new DataGridViewTextBoxColumn());
			this.vmethod_45(new DataGridViewTextBoxColumn());
			this.vmethod_47(new DataGridViewTextBoxColumn());
			this.vmethod_49(new DataGridViewTextBoxColumn());
			this.vmethod_51(new DataGridViewTextBoxColumn());
			this.vmethod_53(new DataGridViewCheckBoxColumn());
			this.vmethod_55(new DataGridViewTextBoxColumn());
			this.vmethod_57(new DataGridViewTextBoxColumn());
			this.vmethod_27(new Class115());
			this.vmethod_39(new Class2451());
			this.vmethod_41(new Class116());
			this.vmethod_37(new Class112());
			this.vmethod_29(new Class2451());
			this.vmethod_31(new Class116());
			this.vmethod_33(new Class116());
			this.vmethod_35(new Control8());
			((ISupportInitialize)this.vmethod_6()).BeginInit();
			this.vmethod_20().SuspendLayout();
			((ISupportInitialize)this.vmethod_24()).BeginInit();
			this.vmethod_26().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_0().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.vmethod_0().Location = new Point(12, 34);
			this.vmethod_0().Name = "ListView1";
			this.vmethod_0().Size = new Size(278, 583);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(12, 15);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new Size(87, 13);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "Current inventory";
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(294, 15);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new Size(76, 13);
			this.vmethod_4().TabIndex = 8;
			this.vmethod_4().Text = "Aircraft to add:";
			this.vmethod_6().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_6().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(6, 15);
			NumericUpDown numericUpDown = this.vmethod_6();
			int[] array = new int[4];
			array[0] = 99999999;
			numericUpDown.Maximum = new decimal(array);
			this.vmethod_6().Name = "NUD1";
			this.vmethod_6().Size = new Size(74, 23);
			this.vmethod_6().TabIndex = 10;
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_8().method_14(null);
			this.vmethod_8().method_15(AutoCompleteMode.None);
			this.vmethod_8().method_13(AutoCompleteSource.None);
			this.vmethod_8().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_8().method_17(new Font("Segoe UI", 8f));
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().method_12(null);
			this.vmethod_8().method_18(null);
			this.vmethod_8().Location = new Point(423, 638);
			this.vmethod_8().method_2(32767);
			this.vmethod_8().method_7(false);
			this.vmethod_8().Name = "TB_Callsign";
			this.vmethod_8().method_3(false);
			this.vmethod_8().method_9(0);
			this.vmethod_8().Size = new Size(135, 20);
			this.vmethod_8().TabIndex = 11;
			this.vmethod_8().method_1(HorizontalAlignment.Left);
			this.vmethod_8().method_5(false);
			this.vmethod_8().method_10("");
			this.vmethod_10().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_10().method_2(true);
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().Location = new Point(370, 641);
			this.vmethod_10().Name = "Label4";
			this.vmethod_10().Size = new Size(52, 15);
			this.vmethod_10().TabIndex = 12;
			this.vmethod_10().Text = "Callsign:";
			this.vmethod_12().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_12().ForeColor = SystemColors.Control;
			this.vmethod_12().Location = new Point(844, 638);
			this.vmethod_12().Name = "Button1";
			this.vmethod_12().Padding = new Padding(5);
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new Size(111, 22);
			this.vmethod_12().TabIndex = 13;
			this.vmethod_12().Text = "Add Selected";
			this.vmethod_14().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_14().method_2(true);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(564, 642);
			this.vmethod_14().Name = "Label5";
			this.vmethod_14().Size = new Size(68, 15);
			this.vmethod_14().TabIndex = 14;
			this.vmethod_14().Text = "How many:";
			this.vmethod_16().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_16().method_14(null);
			this.vmethod_16().method_15(AutoCompleteMode.None);
			this.vmethod_16().method_13(AutoCompleteSource.None);
			this.vmethod_16().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_16().method_17(new Font("Segoe UI", 8f));
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().method_12(null);
			this.vmethod_16().method_18(null);
			this.vmethod_16().Location = new Point(632, 638);
			this.vmethod_16().method_2(32767);
			this.vmethod_16().method_7(false);
			this.vmethod_16().Name = "TB_Quantity";
			this.vmethod_16().method_3(false);
			this.vmethod_16().method_9(0);
			this.vmethod_16().Size = new Size(114, 20);
			this.vmethod_16().TabIndex = 12;
			this.vmethod_18().BackColor = Color.Transparent;
			this.vmethod_18().DialogResult = DialogResult.None;
			this.vmethod_18().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_18().ForeColor = SystemColors.Control;
			this.vmethod_18().Location = new Point(85, 15);
			this.vmethod_18().Name = "Button2";
			this.vmethod_18().Padding = new Padding(5);
			this.vmethod_18().method_1(0);
			this.vmethod_18().Size = new Size(65, 22);
			this.vmethod_18().TabIndex = 16;
			this.vmethod_18().Text = "Apply";
			this.vmethod_20().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_20().Controls.Add(this.vmethod_6());
			this.vmethod_20().Controls.Add(this.vmethod_18());
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Location = new Point(12, 624);
			this.vmethod_20().Name = "Quantity";
			this.vmethod_20().Size = new Size(155, 41);
			this.vmethod_20().TabIndex = 17;
			this.vmethod_20().TabStop = false;
			this.vmethod_20().Text = "Quantity";
			this.vmethod_22().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_22().BackColor = Color.Red;
			this.vmethod_22().DialogResult = DialogResult.None;
			this.vmethod_22().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_22().ForeColor = Color.Red;
			this.vmethod_22().Location = new Point(190, 638);
			this.vmethod_22().Name = "Button_RemoveAC";
			this.vmethod_22().Padding = new Padding(5);
			this.vmethod_22().method_1(0);
			this.vmethod_22().Size = new Size(100, 22);
			this.vmethod_22().TabIndex = 18;
			this.vmethod_22().Text = "Remove selected";
			this.vmethod_24().AllowUserToAddRows = false;
			this.vmethod_24().AllowUserToDeleteRows = false;
			this.vmethod_24().AllowUserToResizeColumns = false;
			this.vmethod_24().AllowUserToResizeRows = false;
			this.vmethod_24().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_24().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_24().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_24().CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.vmethod_24().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_24().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_24().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_24().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_42(),
				this.vmethod_44(),
				this.vmethod_46(),
				this.vmethod_48(),
				this.vmethod_50(),
				this.vmethod_52(),
				this.vmethod_54(),
				this.vmethod_56()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_24().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_24().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_24().EnableHeadersVisualStyles = false;
			this.vmethod_24().Location = new Point(297, 131);
			this.vmethod_24().MultiSelect = false;
			this.vmethod_24().Name = "DataGridView1";
			this.vmethod_24().ReadOnly = true;
			this.vmethod_24().RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_24().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_24().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_24().Size = new Size(658, 486);
			this.vmethod_24().TabIndex = 21;
			this.vmethod_42().DataPropertyName = "ID";
			this.vmethod_42().HeaderText = "ID";
			this.vmethod_42().Name = "DataGridViewTextBoxColumn1";
			this.vmethod_42().ReadOnly = true;
			this.vmethod_42().Visible = false;
			this.vmethod_44().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_44().DataPropertyName = "LongName";
			this.vmethod_44().HeaderText = "Aircraft";
			this.vmethod_44().Name = "DataGridViewTextBoxColumn2";
			this.vmethod_44().ReadOnly = true;
			this.vmethod_46().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_46().DataPropertyName = "CountryString";
			this.vmethod_46().HeaderText = "Country";
			this.vmethod_46().Name = "Country";
			this.vmethod_46().ReadOnly = true;
			this.vmethod_46().Width = 73;
			this.vmethod_48().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_48().DataPropertyName = "YearCommissioned";
			this.vmethod_48().HeaderText = "From";
			this.vmethod_48().Name = "IOC";
			this.vmethod_48().ReadOnly = true;
			this.vmethod_48().Width = 58;
			this.vmethod_50().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_50().DataPropertyName = "YearDecommissioned";
			this.vmethod_50().HeaderText = "Until";
			this.vmethod_50().Name = "Retired";
			this.vmethod_50().ReadOnly = true;
			this.vmethod_50().Width = 55;
			this.vmethod_52().AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.vmethod_52().DataPropertyName = "Hypothetical";
			this.vmethod_52().FalseValue = "False";
			this.vmethod_52().HeaderText = "Hypo";
			this.vmethod_52().Name = "Hypothetical";
			this.vmethod_52().ReadOnly = true;
			this.vmethod_52().TrueValue = "True";
			this.vmethod_52().Width = 40;
			this.vmethod_54().DataPropertyName = "OperatorCountry";
			this.vmethod_54().HeaderText = "Column1";
			this.vmethod_54().Name = "CountryNumber";
			this.vmethod_54().ReadOnly = true;
			this.vmethod_54().Visible = false;
			this.vmethod_56().DataPropertyName = "Name";
			this.vmethod_56().HeaderText = "Column2";
			this.vmethod_56().Name = "Column2";
			this.vmethod_56().ReadOnly = true;
			this.vmethod_56().Visible = false;
			this.vmethod_26().Controls.Add(this.vmethod_38());
			this.vmethod_26().Controls.Add(this.vmethod_40());
			this.vmethod_26().Controls.Add(this.vmethod_36());
			this.vmethod_26().Controls.Add(this.vmethod_28());
			this.vmethod_26().Controls.Add(this.vmethod_30());
			this.vmethod_26().Controls.Add(this.vmethod_32());
			this.vmethod_26().Controls.Add(this.vmethod_34());
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().Location = new Point(296, 34);
			this.vmethod_26().Name = "GroupBox1";
			this.vmethod_26().Size = new Size(659, 91);
			this.vmethod_26().TabIndex = 22;
			this.vmethod_26().TabStop = false;
			this.vmethod_26().Text = "Filter by...";
			this.vmethod_38().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_38().BackColor = Color.Transparent;
			this.vmethod_38().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_38().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_38().Font = new Font("Segoe UI", 7f);
			this.vmethod_38().Location = new Point(83, 41);
			this.vmethod_38().Name = "CB_Hypothetical";
			this.vmethod_38().Size = new Size(252, 21);
			this.vmethod_38().TabIndex = 16;
			this.vmethod_40().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_40().Location = new Point(6, 45);
			this.vmethod_40().Name = "Label7";
			this.vmethod_40().Size = new Size(85, 20);
			this.vmethod_40().TabIndex = 15;
			this.vmethod_40().Text = "Hypothetical:";
			this.vmethod_36().Location = new Point(10, 68);
			this.vmethod_36().Name = "CB_FilterSizeAndTODLAD";
			this.vmethod_36().Size = new Size(252, 18);
			this.vmethod_36().TabIndex = 14;
			this.vmethod_36().Text = "Only show aircraft able to take off / land here";
			this.vmethod_36().Visible = false;
			this.vmethod_28().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_28().BackColor = Color.Transparent;
			this.vmethod_28().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_28().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_28().Font = new Font("Segoe UI", 7f);
			this.vmethod_28().Location = new Point(398, 16);
			this.vmethod_28().Name = "CB_Country";
			this.vmethod_28().Size = new Size(255, 21);
			this.vmethod_28().TabIndex = 13;
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Location = new Point(341, 20);
			this.vmethod_30().Name = "Label3";
			this.vmethod_30().Size = new Size(61, 17);
			this.vmethod_30().TabIndex = 12;
			this.vmethod_30().Text = "Country:";
			this.vmethod_32().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_32().Location = new Point(7, 20);
			this.vmethod_32().Name = "Label6";
			this.vmethod_32().Size = new Size(41, 17);
			this.vmethod_32().TabIndex = 11;
			this.vmethod_32().Text = "Class:";
			this.vmethod_34().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_34().method_14(null);
			this.vmethod_34().method_15(AutoCompleteMode.None);
			this.vmethod_34().method_13(AutoCompleteSource.None);
			this.vmethod_34().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_34().method_17(new Font("Segoe UI", 8f));
			this.vmethod_34().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_34().method_12(null);
			this.vmethod_34().method_18(null);
			this.vmethod_34().Location = new Point(83, 17);
			this.vmethod_34().method_2(32767);
			this.vmethod_34().method_7(false);
			this.vmethod_34().Name = "TB_Class";
			this.vmethod_34().method_3(false);
			this.vmethod_34().method_9(0);
			this.vmethod_34().Size = new Size(252, 20);
			this.vmethod_34().TabIndex = 10;
			this.vmethod_34().method_1(HorizontalAlignment.Left);
			this.vmethod_34().method_5(false);
			this.vmethod_34().method_10("");
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(967, 673);
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditAC";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Edit Aircraft for:";
			((ISupportInitialize)this.vmethod_6()).EndInit();
			this.vmethod_20().ResumeLayout(false);
			((ISupportInitialize)this.vmethod_24()).EndInit();
			this.vmethod_26().ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x000486AC File Offset: 0x000468AC
		[CompilerGenerated]
		internal Control4 vmethod_0()
		{
			return this.control4_0;
		}

		// Token: 0x06007461 RID: 29793 RVA: 0x003EE9A4 File Offset: 0x003ECBA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control4 control4_1)
		{
			EventHandler eventHandler_ = new EventHandler(this.method_4);
			EventHandler eventHandler_2 = new EventHandler(this.method_11);
			Control4 control = this.control4_0;
			if (control != null)
			{
				control.method_17(eventHandler_);
				control.method_17(eventHandler_2);
			}
			this.control4_0 = control4_1;
			control = this.control4_0;
			if (control != null)
			{
				control.method_16(eventHandler_);
				control.method_16(eventHandler_2);
			}
		}

		// Token: 0x06007462 RID: 29794 RVA: 0x000486B4 File Offset: 0x000468B4
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_0;
		}

		// Token: 0x06007463 RID: 29795 RVA: 0x000486BC File Offset: 0x000468BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_7)
		{
			this.class116_0 = class116_7;
		}

		// Token: 0x06007464 RID: 29796 RVA: 0x000486C5 File Offset: 0x000468C5
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_1;
		}

		// Token: 0x06007465 RID: 29797 RVA: 0x000486CD File Offset: 0x000468CD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_7)
		{
			this.class116_1 = class116_7;
		}

		// Token: 0x06007466 RID: 29798 RVA: 0x000486D6 File Offset: 0x000468D6
		[CompilerGenerated]
		internal Class120 vmethod_6()
		{
			return this.class120_0;
		}

		// Token: 0x06007467 RID: 29799 RVA: 0x000486DE File Offset: 0x000468DE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class120 class120_1)
		{
			this.class120_0 = class120_1;
		}

		// Token: 0x06007468 RID: 29800 RVA: 0x000486E7 File Offset: 0x000468E7
		[CompilerGenerated]
		internal Control8 vmethod_8()
		{
			return this.control8_0;
		}

		// Token: 0x06007469 RID: 29801 RVA: 0x000486EF File Offset: 0x000468EF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control8 control8_3)
		{
			this.control8_0 = control8_3;
		}

		// Token: 0x0600746A RID: 29802 RVA: 0x000486F8 File Offset: 0x000468F8
		[CompilerGenerated]
		internal Class116 vmethod_10()
		{
			return this.class116_2;
		}

		// Token: 0x0600746B RID: 29803 RVA: 0x00048700 File Offset: 0x00046900
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class116 class116_7)
		{
			this.class116_2 = class116_7;
		}

		// Token: 0x0600746C RID: 29804 RVA: 0x00048709 File Offset: 0x00046909
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_0;
		}

		// Token: 0x0600746D RID: 29805 RVA: 0x003EEA04 File Offset: 0x003ECC04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_5);
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

		// Token: 0x0600746E RID: 29806 RVA: 0x00048711 File Offset: 0x00046911
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_3;
		}

		// Token: 0x0600746F RID: 29807 RVA: 0x00048719 File Offset: 0x00046919
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_7)
		{
			this.class116_3 = class116_7;
		}

		// Token: 0x06007470 RID: 29808 RVA: 0x00048722 File Offset: 0x00046922
		[CompilerGenerated]
		internal Control8 vmethod_16()
		{
			return this.control8_1;
		}

		// Token: 0x06007471 RID: 29809 RVA: 0x0004872A File Offset: 0x0004692A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Control8 control8_3)
		{
			this.control8_1 = control8_3;
		}

		// Token: 0x06007472 RID: 29810 RVA: 0x00048733 File Offset: 0x00046933
		[CompilerGenerated]
		internal Control9 vmethod_18()
		{
			return this.control9_1;
		}

		// Token: 0x06007473 RID: 29811 RVA: 0x003EEA48 File Offset: 0x003ECC48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_6);
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

		// Token: 0x06007474 RID: 29812 RVA: 0x0004873B File Offset: 0x0004693B
		[CompilerGenerated]
		internal Class115 vmethod_20()
		{
			return this.class115_0;
		}

		// Token: 0x06007475 RID: 29813 RVA: 0x00048743 File Offset: 0x00046943
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class115 class115_2)
		{
			this.class115_0 = class115_2;
		}

		// Token: 0x06007476 RID: 29814 RVA: 0x0004874C File Offset: 0x0004694C
		[CompilerGenerated]
		internal Control9 vmethod_22()
		{
			return this.control9_2;
		}

		// Token: 0x06007477 RID: 29815 RVA: 0x003EEA8C File Offset: 0x003ECC8C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_7);
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

		// Token: 0x06007478 RID: 29816 RVA: 0x00048754 File Offset: 0x00046954
		[CompilerGenerated]
		internal Class114 vmethod_24()
		{
			return this.class114_0;
		}

		// Token: 0x06007479 RID: 29817 RVA: 0x003EEAD0 File Offset: 0x003ECCD0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class114 class114_1)
		{
			KeyPressEventHandler value = new KeyPressEventHandler(this.method_8);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.KeyPress -= value;
			}
			this.class114_0 = class114_1;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.KeyPress += value;
			}
		}

		// Token: 0x0600747A RID: 29818 RVA: 0x0004875C File Offset: 0x0004695C
		[CompilerGenerated]
		internal Class115 vmethod_26()
		{
			return this.class115_1;
		}

		// Token: 0x0600747B RID: 29819 RVA: 0x00048764 File Offset: 0x00046964
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class115 class115_2)
		{
			this.class115_1 = class115_2;
		}

		// Token: 0x0600747C RID: 29820 RVA: 0x0004876D File Offset: 0x0004696D
		[CompilerGenerated]
		internal Class2451 vmethod_28()
		{
			return this.class2451_0;
		}

		// Token: 0x0600747D RID: 29821 RVA: 0x003EEB14 File Offset: 0x003ECD14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Class2451 class2451_2)
		{
			EventHandler value = new EventHandler(this.method_12);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_2;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600747E RID: 29822 RVA: 0x00048775 File Offset: 0x00046975
		[CompilerGenerated]
		internal Class116 vmethod_30()
		{
			return this.class116_4;
		}

		// Token: 0x0600747F RID: 29823 RVA: 0x0004877D File Offset: 0x0004697D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class116 class116_7)
		{
			this.class116_4 = class116_7;
		}

		// Token: 0x06007480 RID: 29824 RVA: 0x00048786 File Offset: 0x00046986
		[CompilerGenerated]
		internal Class116 vmethod_32()
		{
			return this.class116_5;
		}

		// Token: 0x06007481 RID: 29825 RVA: 0x0004878E File Offset: 0x0004698E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Class116 class116_7)
		{
			this.class116_5 = class116_7;
		}

		// Token: 0x06007482 RID: 29826 RVA: 0x00048797 File Offset: 0x00046997
		[CompilerGenerated]
		internal Control8 vmethod_34()
		{
			return this.control8_2;
		}

		// Token: 0x06007483 RID: 29827 RVA: 0x003EEB58 File Offset: 0x003ECD58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Control8 control8_3)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_9);
			Control8 control = this.control8_2;
			if (control != null)
			{
				control.method_22(delegate85_);
			}
			this.control8_2 = control8_3;
			control = this.control8_2;
			if (control != null)
			{
				control.method_21(delegate85_);
			}
		}

		// Token: 0x06007484 RID: 29828 RVA: 0x0004879F File Offset: 0x0004699F
		[CompilerGenerated]
		internal Class112 vmethod_36()
		{
			return this.class112_0;
		}

		// Token: 0x06007485 RID: 29829 RVA: 0x000487A7 File Offset: 0x000469A7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Class112 class112_1)
		{
			this.class112_0 = class112_1;
		}

		// Token: 0x06007486 RID: 29830 RVA: 0x000487B0 File Offset: 0x000469B0
		[CompilerGenerated]
		internal Class2451 vmethod_38()
		{
			return this.class2451_1;
		}

		// Token: 0x06007487 RID: 29831 RVA: 0x003EEB9C File Offset: 0x003ECD9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Class2451 class2451_2)
		{
			EventHandler value = new EventHandler(this.method_13);
			Class2451 @class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_1 = class2451_2;
			@class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06007488 RID: 29832 RVA: 0x000487B8 File Offset: 0x000469B8
		[CompilerGenerated]
		internal Class116 vmethod_40()
		{
			return this.class116_6;
		}

		// Token: 0x06007489 RID: 29833 RVA: 0x000487C0 File Offset: 0x000469C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Class116 class116_7)
		{
			this.class116_6 = class116_7;
		}

		// Token: 0x0600748A RID: 29834 RVA: 0x000487C9 File Offset: 0x000469C9
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_42()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x0600748B RID: 29835 RVA: 0x000487D1 File Offset: 0x000469D1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x0600748C RID: 29836 RVA: 0x000487DA File Offset: 0x000469DA
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_44()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x0600748D RID: 29837 RVA: 0x000487E2 File Offset: 0x000469E2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x0600748E RID: 29838 RVA: 0x000487EB File Offset: 0x000469EB
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_46()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600748F RID: 29839 RVA: 0x000487F3 File Offset: 0x000469F3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x06007490 RID: 29840 RVA: 0x000487FC File Offset: 0x000469FC
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_48()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06007491 RID: 29841 RVA: 0x00048804 File Offset: 0x00046A04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x06007492 RID: 29842 RVA: 0x0004880D File Offset: 0x00046A0D
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_50()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06007493 RID: 29843 RVA: 0x00048815 File Offset: 0x00046A15
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x06007494 RID: 29844 RVA: 0x0004881E File Offset: 0x00046A1E
		[CompilerGenerated]
		internal DataGridViewCheckBoxColumn vmethod_52()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x06007495 RID: 29845 RVA: 0x00048826 File Offset: 0x00046A26
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x06007496 RID: 29846 RVA: 0x0004882F File Offset: 0x00046A2F
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_54()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x06007497 RID: 29847 RVA: 0x00048837 File Offset: 0x00046A37
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x06007498 RID: 29848 RVA: 0x00048840 File Offset: 0x00046A40
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_56()
		{
			return this.dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06007499 RID: 29849 RVA: 0x00048848 File Offset: 0x00046A48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x0600749A RID: 29850 RVA: 0x003EEBE0 File Offset: 0x003ECDE0
		private void EditAC_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Client.smethod_0().method_0() == Class279.Enum68.const_0)
			{
				Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), Client.smethod_54(), false);
			}
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x0600749B RID: 29851 RVA: 0x003EEC34 File Offset: 0x003ECE34
		private void EditAC_Load(object sender, EventArgs e)
		{
			this.dataTable_0 = Client.smethod_46().Cache_Aircraft_DT;
			DataTable cache_OperatorCountries_DT = Client.smethod_46().Cache_OperatorCountries_DT;
			this.vmethod_28().SuspendLayout();
			this.vmethod_28().DataSource = cache_OperatorCountries_DT;
			this.vmethod_28().DisplayMember = "Description";
			this.vmethod_28().ValueMember = "ID";
			this.vmethod_28().SelectedIndex = 0;
			this.vmethod_28().ResumeLayout();
			this.vmethod_38().Items.Clear();
			this.vmethod_38().Items.Add("Both real-life and hypothetical");
			this.vmethod_38().Items.Add("Real-life platforms only");
			this.vmethod_38().Items.Add("Hypothetical platforms only");
			this.vmethod_38().SelectedItem = RuntimeHelpers.GetObjectValue(this.vmethod_38().Items[0]);
		}

		// Token: 0x0600749C RID: 29852 RVA: 0x003EED20 File Offset: 0x003ECF20
		private void method_3()
		{
			Client.bool_1 = true;
			this.vmethod_0().method_18().Clear();
			IEnumerable<int> enumerable = Enumerable.Distinct<int>(Enumerable.Select<Aircraft, int>(this.activeUnit_0.vmethod_92().vmethod_4(), (EditAC._Closure$__.$I124-0 == null) ? (EditAC._Closure$__.$I124-0 = new Func<Aircraft, int>(EditAC._Closure$__.$I.method_0)) : EditAC._Closure$__.$I124-0));
			try
			{
				foreach (int int_ in enumerable)
				{
					EditAC.Class2499 @class = new EditAC.Class2499(@class);
					@class.int_0 = int_;
					IEnumerable<Aircraft> enumerable2 = Enumerable.Where<Aircraft>(this.activeUnit_0.vmethod_92().vmethod_4(), new Func<Aircraft, bool>(@class.method_0));
					Class117 class2 = new Class117();
					class2.Tag = @class.int_0;
					class2.method_3(Conversions.ToString(Enumerable.Count<Aircraft>(enumerable2)) + "x " + Enumerable.ElementAtOrDefault<Aircraft>(enumerable2, 0).string_2);
					this.vmethod_0().method_18().Add(class2);
				}
			}
			finally
			{
				IEnumerator<int> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.vmethod_22().Visible = (this.vmethod_0().method_20().Count > 0);
			this.vmethod_22().Enabled = this.vmethod_22().Visible;
		}

		// Token: 0x0600749D RID: 29853 RVA: 0x003EEE78 File Offset: 0x003ED078
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_0().method_21().Count > 0)
			{
				int value = Enumerable.Count<Aircraft>(Enumerable.Where<Aircraft>(this.activeUnit_0.vmethod_92().vmethod_4(), new Func<Aircraft, bool>(this.method_14)));
				this.vmethod_6().Value = new decimal(value);
			}
		}

		// Token: 0x0600749E RID: 29854 RVA: 0x003EEED0 File Offset: 0x003ED0D0
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_24().SelectedRows.Count != 0)
			{
				int num = Conversions.ToInteger(this.vmethod_24().SelectedRows[0].Cells[0].Value.ToString());
				if (!(num == 10000 | num == 10001 | num == 10002))
				{
					string str;
					if (string.IsNullOrEmpty(this.vmethod_8().Text))
					{
						str = Class163.smethod_3();
					}
					else
					{
						str = this.vmethod_8().Text;
					}
					if (Versioned.IsNumeric(this.vmethod_16().Text))
					{
						this.vmethod_12().Text = "Working...";
						this.vmethod_12().Enabled = false;
						int num2 = Conversions.ToInteger(this.vmethod_16().Text);
						for (int i = 1; i <= num2; i++)
						{
							Aircraft aircraft = Client.smethod_46().method_71(Client.smethod_50(), str + " #" + Conversions.ToString(i), 0.0, 0.0, num, 0, 0f, Unit.Enum122.const_0, null);
							if (!this.activeUnit_0.vmethod_92().vmethod_8(aircraft))
							{
								Client.smethod_46().method_66(aircraft.string_0, true);
								DarkMessageBox.smethod_1("Unable to add all aircraft to base - Exceeded maximum aircraft parking space.", "Out of space!", Enum11.const_0);
								IL_15D:
								this.vmethod_12().Text = "Add Selected";
								this.vmethod_12().Enabled = true;
								this.method_3();
								return;
							}
							this.activeUnit_0.vmethod_92().method_18(aircraft, false);
						}
						goto IL_15D;
					}
				}
			}
		}

		// Token: 0x0600749F RID: 29855 RVA: 0x003EF05C File Offset: 0x003ED25C
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_0().method_20().Count != 0)
			{
				this.vmethod_18().Text = "Working...";
				this.vmethod_18().Enabled = false;
				IEnumerable<Aircraft> enumerable = Enumerable.Where<Aircraft>(this.activeUnit_0.vmethod_92().vmethod_4(), new Func<Aircraft, bool>(this.method_15));
				if (decimal.Compare(this.vmethod_6().Value, new decimal(Enumerable.Count<Aircraft>(enumerable))) < 0)
				{
					int num = Enumerable.Count<Aircraft>(enumerable) - 1;
					int num2 = Convert.ToInt32(this.vmethod_6().Value);
					for (int i = num; i >= num2; i += -1)
					{
						Client.smethod_46().method_66(Enumerable.ElementAtOrDefault<Aircraft>(enumerable, i).string_0, true);
					}
				}
				if (decimal.Compare(this.vmethod_6().Value, new decimal(Enumerable.Count<Aircraft>(enumerable))) > 0)
				{
					int aircraftDBID = Enumerable.ElementAtOrDefault<int>(Enumerable.Select<Aircraft, int>(enumerable, (EditAC._Closure$__.$I127-1 == null) ? (EditAC._Closure$__.$I127-1 = new Func<Aircraft, int>(EditAC._Closure$__.$I.method_1)) : EditAC._Closure$__.$I127-1), 0);
					string str = Class163.smethod_3();
					int num3 = Enumerable.Count<Aircraft>(enumerable) + 1;
					int num4 = Convert.ToInt32(this.vmethod_6().Value);
					for (int j = num3; j <= num4; j++)
					{
						Aircraft aircraft = Client.smethod_46().method_71(Client.smethod_50(), str + " " + Conversions.ToString(j), 0.0, 0.0, aircraftDBID, 0, 0f, Unit.Enum122.const_0, null);
						if (!this.activeUnit_0.vmethod_92().vmethod_8(aircraft))
						{
							Client.smethod_46().method_66(aircraft.string_0, true);
							DarkMessageBox.smethod_1("Unable to add all aircraft to base - Exceeded maximum aircraft parking space.", "Out of space!", Enum11.const_0);
							break;
						}
						this.activeUnit_0.vmethod_92().method_18(aircraft, false);
					}
				}
				this.vmethod_18().Text = "Apply";
				this.vmethod_18().Enabled = true;
				this.method_3();
			}
		}

		// Token: 0x060074A0 RID: 29856 RVA: 0x003EF248 File Offset: 0x003ED448
		private void method_7(object sender, EventArgs e)
		{
			IEnumerable<Aircraft> enumerable = Enumerable.Where<Aircraft>(this.activeUnit_0.vmethod_92().vmethod_4(), new Func<Aircraft, bool>(this.method_16));
			for (int i = Enumerable.Count<Aircraft>(enumerable) - 1; i >= 0; i += -1)
			{
				Client.smethod_46().method_66(Enumerable.ElementAtOrDefault<Aircraft>(enumerable, i).string_0, true);
			}
			this.method_3();
		}

		// Token: 0x060074A1 RID: 29857 RVA: 0x003EF2A8 File Offset: 0x003ED4A8
		private void method_8(object sender, KeyPressEventArgs e)
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Name ASC";
			dataView.RowFilter = "Name LIKE '" + Conversions.ToString(e.KeyChar) + "%'";
			if (dataView.Count > 0)
			{
				int num = Conversions.ToInteger(dataView[0][0]);
				int index;
				try
				{
					foreach (object obj in ((IEnumerable)this.vmethod_24().Rows))
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
				this.vmethod_24().FirstDisplayedScrollingRowIndex = index;
			}
		}

		// Token: 0x060074A2 RID: 29858 RVA: 0x00048851 File Offset: 0x00046A51
		private void method_9(object object_0)
		{
			if (Operators.CompareString(this.vmethod_34().Text, "", false) != 0)
			{
				this.method_10();
			}
		}

		// Token: 0x060074A3 RID: 29859 RVA: 0x003EF38C File Offset: 0x003ED58C
		private void method_10()
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Name ASC";
			if (Operators.CompareString(this.vmethod_34().Text, "", false) != 0 || this.vmethod_28().SelectedIndex != 0 || this.vmethod_38().SelectedIndex != 0)
			{
				string text = "1=1 ";
				if (Operators.CompareString(this.vmethod_34().Text, "", false) != 0)
				{
					string str = this.vmethod_34().Text.Replace("'", "''");
					text = text + " AND Name LIKE '%" + str + "%' ";
				}
				if (this.vmethod_28().SelectedIndex > 0)
				{
					text = text + " AND OperatorCountry=" + Conversions.ToString(this.vmethod_28().SelectedValue);
				}
				if (this.vmethod_38().SelectedIndex == 1)
				{
					text += " AND Hypothetical=FALSE";
				}
				else if (this.vmethod_38().SelectedIndex == 2)
				{
					text += " AND Hypothetical=TRUE";
				}
				text = text.Replace("[", "[[");
				text = text.Replace("]", "]]");
				text = text.Replace("[[", "[[]");
				text = text.Replace("]]", "[]]");
				if (this.vmethod_36().Checked)
				{
					GlobalVariables.Enum146 value = this.activeUnit_0.vmethod_92().vmethod_2();
					GlobalVariables.AircraftSizeClass value2 = this.activeUnit_0.vmethod_92().vmethod_3();
					text = string.Concat(new string[]
					{
						text,
						" AND PhysicalSizeCode => ",
						Conversions.ToString((byte)value2),
						" AND RunwayLengthCode <= ",
						Conversions.ToString((int)value)
					});
				}
				dataView.RowFilter = text;
			}
			this.vmethod_24().DataSource = dataView;
			this.vmethod_24().Refresh();
		}

		// Token: 0x060074A4 RID: 29860 RVA: 0x003B6260 File Offset: 0x003B4460
		private void EditAC_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x060074A5 RID: 29861 RVA: 0x003EF558 File Offset: 0x003ED758
		private void method_11(object sender, EventArgs e)
		{
			if (this.vmethod_0().method_20().Count > 0)
			{
				int value = Enumerable.Count<Aircraft>(Enumerable.Where<Aircraft>(this.activeUnit_0.vmethod_92().vmethod_4(), new Func<Aircraft, bool>(this.method_17)));
				this.vmethod_6().Value = new decimal(value);
			}
			this.vmethod_22().Visible = (this.vmethod_0().method_20().Count > 0);
			this.vmethod_22().Enabled = this.vmethod_22().Visible;
		}

		// Token: 0x060074A6 RID: 29862 RVA: 0x00048871 File Offset: 0x00046A71
		private void EditAC_Shown(object sender, EventArgs e)
		{
			this.Text = "Edit Aircraft for " + this.activeUnit_0.Name;
			this.method_10();
			this.method_3();
		}

		// Token: 0x060074A7 RID: 29863 RVA: 0x0004889A File Offset: 0x00046A9A
		private void method_12(object sender, EventArgs e)
		{
			if (this.vmethod_38().Items.Count != 0 && this.vmethod_28().Items.Count != 0)
			{
				this.method_10();
			}
		}

		// Token: 0x060074A8 RID: 29864 RVA: 0x0004889A File Offset: 0x00046A9A
		private void method_13(object sender, EventArgs e)
		{
			if (this.vmethod_38().Items.Count != 0 && this.vmethod_28().Items.Count != 0)
			{
				this.method_10();
			}
		}

		// Token: 0x060074A9 RID: 29865 RVA: 0x000488C6 File Offset: 0x00046AC6
		[CompilerGenerated]
		private bool method_14(Aircraft aircraft_0)
		{
			return string.CompareOrdinal(Conversions.ToString(aircraft_0.DBID), this.vmethod_0().method_21()[0].Tag.ToString()) == 0;
		}

		// Token: 0x060074AA RID: 29866 RVA: 0x000488F6 File Offset: 0x00046AF6
		[CompilerGenerated]
		private bool method_15(Aircraft aircraft_0)
		{
			return aircraft_0.DBID == Conversions.ToInteger(this.vmethod_0().method_18()[this.vmethod_0().method_20()[0]].Tag.ToString());
		}

		// Token: 0x060074AB RID: 29867 RVA: 0x000488F6 File Offset: 0x00046AF6
		[CompilerGenerated]
		private bool method_16(Aircraft aircraft_0)
		{
			return aircraft_0.DBID == Conversions.ToInteger(this.vmethod_0().method_18()[this.vmethod_0().method_20()[0]].Tag.ToString());
		}

		// Token: 0x060074AC RID: 29868 RVA: 0x00048930 File Offset: 0x00046B30
		[CompilerGenerated]
		private bool method_17(Aircraft aircraft_0)
		{
			return string.CompareOrdinal(Conversions.ToString(aircraft_0.DBID), this.vmethod_0().method_18()[this.vmethod_0().method_20()[0]].Tag.ToString()) == 0;
		}

		// Token: 0x0400416E RID: 16750
		[CompilerGenerated]
		[AccessedThroughProperty("ListView1")]
		private Control4 control4_0;

		// Token: 0x0400416F RID: 16751
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04004170 RID: 16752
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_1;

		// Token: 0x04004171 RID: 16753
		[CompilerGenerated]
		[AccessedThroughProperty("NUD1")]
		private Class120 class120_0;

		// Token: 0x04004172 RID: 16754
		[CompilerGenerated]
		[AccessedThroughProperty("TB_Callsign")]
		private Control8 control8_0;

		// Token: 0x04004173 RID: 16755
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Class116 class116_2;

		// Token: 0x04004174 RID: 16756
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_0;

		// Token: 0x04004175 RID: 16757
		[CompilerGenerated]
		[AccessedThroughProperty("Label5")]
		private Class116 class116_3;

		// Token: 0x04004176 RID: 16758
		[AccessedThroughProperty("TB_Quantity")]
		[CompilerGenerated]
		private Control8 control8_1;

		// Token: 0x04004177 RID: 16759
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_1;

		// Token: 0x04004178 RID: 16760
		[CompilerGenerated]
		[AccessedThroughProperty("Quantity")]
		private Class115 class115_0;

		// Token: 0x04004179 RID: 16761
		[CompilerGenerated]
		[AccessedThroughProperty("Button_RemoveAC")]
		private Control9 control9_2;

		// Token: 0x0400417A RID: 16762
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridView1")]
		private Class114 class114_0;

		// Token: 0x0400417B RID: 16763
		[AccessedThroughProperty("GroupBox1")]
		[CompilerGenerated]
		private Class115 class115_1;

		// Token: 0x0400417C RID: 16764
		[AccessedThroughProperty("CB_Country")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x0400417D RID: 16765
		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		private Class116 class116_4;

		// Token: 0x0400417E RID: 16766
		[AccessedThroughProperty("Label6")]
		[CompilerGenerated]
		private Class116 class116_5;

		// Token: 0x0400417F RID: 16767
		[AccessedThroughProperty("TB_Class")]
		[CompilerGenerated]
		private Control8 control8_2;

		// Token: 0x04004180 RID: 16768
		[AccessedThroughProperty("CB_FilterSizeAndTODLAD")]
		[CompilerGenerated]
		private Class112 class112_0;

		// Token: 0x04004181 RID: 16769
		[AccessedThroughProperty("CB_Hypothetical")]
		[CompilerGenerated]
		private Class2451 class2451_1;

		// Token: 0x04004182 RID: 16770
		[CompilerGenerated]
		[AccessedThroughProperty("Label7")]
		private Class116 class116_6;

		// Token: 0x04004183 RID: 16771
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04004184 RID: 16772
		[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04004185 RID: 16773
		[AccessedThroughProperty("Country")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04004186 RID: 16774
		[CompilerGenerated]
		[AccessedThroughProperty("IOC")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04004187 RID: 16775
		[CompilerGenerated]
		[AccessedThroughProperty("Retired")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04004188 RID: 16776
		[CompilerGenerated]
		[AccessedThroughProperty("Hypothetical")]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x04004189 RID: 16777
		[AccessedThroughProperty("CountryNumber")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x0400418A RID: 16778
		[CompilerGenerated]
		[AccessedThroughProperty("Column2")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x0400418B RID: 16779
		public ActiveUnit activeUnit_0;

		// Token: 0x0400418C RID: 16780
		private DataTable dataTable_0;

		// Token: 0x02000E99 RID: 3737
		[CompilerGenerated]
		internal sealed class Class2499
		{
			// Token: 0x060074AD RID: 29869 RVA: 0x00048970 File Offset: 0x00046B70
			public Class2499(EditAC.Class2499 class2499_0)
			{
				if (class2499_0 != null)
				{
					this.int_0 = class2499_0.int_0;
				}
			}

			// Token: 0x060074AE RID: 29870 RVA: 0x00048987 File Offset: 0x00046B87
			internal bool method_0(Aircraft aircraft_0)
			{
				return aircraft_0.DBID == this.int_0;
			}

			// Token: 0x0400418D RID: 16781
			public int int_0;
		}
	}
}
