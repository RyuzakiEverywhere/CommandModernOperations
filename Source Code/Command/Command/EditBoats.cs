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

namespace Command
{
	// Token: 0x02000EA4 RID: 3748
	[DesignerGenerated]
	public sealed partial class EditBoats : DarkSecondaryFormBase
	{
		// Token: 0x06007604 RID: 30212 RVA: 0x003F9B50 File Offset: 0x003F7D50
		public EditBoats()
		{
			base.Load += this.EditBoats_Load;
			base.FormClosing += this.EditBoats_FormClosing;
			base.KeyDown += this.EditBoats_KeyDown;
			this.InitializeComponent_1();
		}

		// Token: 0x06007606 RID: 30214 RVA: 0x003F9BE0 File Offset: 0x003F7DE0
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_1(new Class115());
			this.vmethod_47(new Class2451());
			this.vmethod_49(new Class116());
			this.vmethod_3(new Class2451());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Class116());
			this.vmethod_9(new Control8());
			this.vmethod_11(new Class114());
			this.vmethod_33(new DataGridViewTextBoxColumn());
			this.vmethod_35(new DataGridViewTextBoxColumn());
			this.vmethod_37(new DataGridViewTextBoxColumn());
			this.vmethod_39(new DataGridViewTextBoxColumn());
			this.vmethod_41(new DataGridViewTextBoxColumn());
			this.vmethod_43(new DataGridViewTextBoxColumn());
			this.vmethod_45(new DataGridViewTextBoxColumn());
			this.vmethod_13(new Control9());
			this.vmethod_15(new Class115());
			this.vmethod_17(new Class120());
			this.vmethod_19(new Control9());
			this.vmethod_21(new Control8());
			this.vmethod_23(new Class116());
			this.vmethod_25(new Control9());
			this.vmethod_27(new Class116());
			this.vmethod_29(new Class116());
			this.vmethod_31(new Control4());
			this.vmethod_0().SuspendLayout();
			((ISupportInitialize)this.vmethod_10()).BeginInit();
			this.vmethod_14().SuspendLayout();
			((ISupportInitialize)this.vmethod_16()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Controls.Add(this.vmethod_46());
			this.vmethod_0().Controls.Add(this.vmethod_48());
			this.vmethod_0().Controls.Add(this.vmethod_2());
			this.vmethod_0().Controls.Add(this.vmethod_4());
			this.vmethod_0().Controls.Add(this.vmethod_6());
			this.vmethod_0().Controls.Add(this.vmethod_8());
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(296, 29);
			this.vmethod_0().Name = "GroupBox1";
			this.vmethod_0().Size = new Size(584, 66);
			this.vmethod_0().TabIndex = 34;
			this.vmethod_0().TabStop = false;
			this.vmethod_0().Text = "Filter by...";
			this.vmethod_46().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_46().BackColor = Color.Transparent;
			this.vmethod_46().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_46().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_46().Font = new Font("Segoe UI", 7f);
			this.vmethod_46().Items.AddRange(new object[]
			{
				"Ship",
				"Submarine"
			});
			this.vmethod_46().Location = new Point(51, 39);
			this.vmethod_46().Name = "ComboBox1";
			this.vmethod_46().Size = new Size(256, 21);
			this.vmethod_46().TabIndex = 15;
			this.vmethod_48().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_48().Location = new Point(6, 44);
			this.vmethod_48().Name = "Label4";
			this.vmethod_48().Size = new Size(39, 19);
			this.vmethod_48().TabIndex = 14;
			this.vmethod_48().Text = "Type:";
			this.vmethod_2().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_2().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_2().Font = new Font("Segoe UI", 7f);
			this.vmethod_2().Location = new Point(365, 14);
			this.vmethod_2().Name = "CB_Country";
			this.vmethod_2().Size = new Size(213, 21);
			this.vmethod_2().TabIndex = 13;
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(313, 20);
			this.vmethod_4().Name = "Label3";
			this.vmethod_4().Size = new Size(61, 17);
			this.vmethod_4().TabIndex = 12;
			this.vmethod_4().Text = "Country:";
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(7, 20);
			this.vmethod_6().Name = "Label6";
			this.vmethod_6().Size = new Size(38, 17);
			this.vmethod_6().TabIndex = 11;
			this.vmethod_6().Text = "Class:";
			this.vmethod_8().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_8().method_14(null);
			this.vmethod_8().method_15(AutoCompleteMode.None);
			this.vmethod_8().method_13(AutoCompleteSource.None);
			this.vmethod_8().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_8().method_17(new Font("Segoe UI", 8f));
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().method_12(null);
			this.vmethod_8().method_18(null);
			this.vmethod_8().Location = new Point(51, 13);
			this.vmethod_8().method_2(32767);
			this.vmethod_8().method_7(false);
			this.vmethod_8().Name = "TB_Class";
			this.vmethod_8().method_3(false);
			this.vmethod_8().method_9(0);
			this.vmethod_8().Size = new Size(256, 24);
			this.vmethod_8().TabIndex = 10;
			this.vmethod_8().method_1(HorizontalAlignment.Left);
			this.vmethod_8().method_5(false);
			this.vmethod_8().method_10("");
			this.vmethod_10().AllowUserToAddRows = false;
			this.vmethod_10().AllowUserToDeleteRows = false;
			this.vmethod_10().AllowUserToResizeColumns = false;
			this.vmethod_10().AllowUserToResizeRows = false;
			this.vmethod_10().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_10().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_10().CellBorderStyle = DataGridViewCellBorderStyle.None;
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
				this.vmethod_32(),
				this.vmethod_34(),
				this.vmethod_36(),
				this.vmethod_38(),
				this.vmethod_40(),
				this.vmethod_42(),
				this.vmethod_44()
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
			this.vmethod_10().Location = new Point(297, 101);
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
			this.vmethod_10().Size = new Size(583, 525);
			this.vmethod_10().TabIndex = 33;
			this.vmethod_32().DataPropertyName = "ID";
			this.vmethod_32().HeaderText = "ID";
			this.vmethod_32().Name = "DataGridViewTextBoxColumn1";
			this.vmethod_32().ReadOnly = true;
			this.vmethod_32().Visible = false;
			this.vmethod_34().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_34().DataPropertyName = "LongName";
			this.vmethod_34().HeaderText = "Class";
			this.vmethod_34().Name = "DataGridViewTextBoxColumn2";
			this.vmethod_34().ReadOnly = true;
			this.vmethod_36().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_36().DataPropertyName = "CountryString";
			this.vmethod_36().HeaderText = "Country";
			this.vmethod_36().Name = "Country";
			this.vmethod_36().ReadOnly = true;
			this.vmethod_36().Width = 73;
			this.vmethod_38().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_38().DataPropertyName = "YearCommissioned";
			this.vmethod_38().HeaderText = "From";
			this.vmethod_38().Name = "IOC";
			this.vmethod_38().ReadOnly = true;
			this.vmethod_38().Width = 58;
			this.vmethod_40().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_40().DataPropertyName = "YearDecommissioned";
			this.vmethod_40().HeaderText = "Until";
			this.vmethod_40().Name = "Retired";
			this.vmethod_40().ReadOnly = true;
			this.vmethod_40().Width = 55;
			this.vmethod_42().DataPropertyName = "OperatorCountry";
			this.vmethod_42().HeaderText = "Column1";
			this.vmethod_42().Name = "CountryNumber";
			this.vmethod_42().ReadOnly = true;
			this.vmethod_42().Visible = false;
			this.vmethod_44().DataPropertyName = "Name";
			this.vmethod_44().HeaderText = "Column2";
			this.vmethod_44().Name = "Column2";
			this.vmethod_44().ReadOnly = true;
			this.vmethod_44().Visible = false;
			this.vmethod_12().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_12().BackColor = Color.Red;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_12().ForeColor = SystemColors.ControlText;
			this.vmethod_12().Location = new Point(190, 647);
			this.vmethod_12().Name = "Button_RemoveBoat";
			this.vmethod_12().Padding = new Padding(5);
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new Size(100, 22);
			this.vmethod_12().TabIndex = 32;
			this.vmethod_12().Text = "Remove selected";
			this.vmethod_14().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_14().Controls.Add(this.vmethod_16());
			this.vmethod_14().Controls.Add(this.vmethod_18());
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(12, 632);
			this.vmethod_14().Name = "Quantity";
			this.vmethod_14().Size = new Size(155, 41);
			this.vmethod_14().TabIndex = 31;
			this.vmethod_14().TabStop = false;
			this.vmethod_14().Text = "Quantity";
			this.vmethod_16().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_16().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Location = new Point(6, 16);
			NumericUpDown numericUpDown = this.vmethod_16();
			int[] array = new int[4];
			array[0] = 99999999;
			numericUpDown.Maximum = new decimal(array);
			this.vmethod_16().Name = "NUD1";
			this.vmethod_16().Size = new Size(74, 23);
			this.vmethod_16().TabIndex = 10;
			this.vmethod_18().BackColor = Color.Transparent;
			this.vmethod_18().DialogResult = DialogResult.None;
			this.vmethod_18().Font = new Font("Segoe UI", 10f);
			this.vmethod_18().ForeColor = SystemColors.Control;
			this.vmethod_18().Location = new Point(85, 15);
			this.vmethod_18().Name = "Button2";
			this.vmethod_18().Padding = new Padding(5);
			this.vmethod_18().method_1(0);
			this.vmethod_18().Size = new Size(65, 22);
			this.vmethod_18().TabIndex = 16;
			this.vmethod_18().Text = "Apply";
			this.vmethod_20().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_20().method_14(null);
			this.vmethod_20().method_15(AutoCompleteMode.None);
			this.vmethod_20().method_13(AutoCompleteSource.None);
			this.vmethod_20().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_20().method_17(new Font("Segoe UI", 8f));
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().method_12(null);
			this.vmethod_20().method_18(null);
			this.vmethod_20().Location = new Point(630, 644);
			this.vmethod_20().method_2(32767);
			this.vmethod_20().method_7(false);
			this.vmethod_20().Name = "TB_Quantity";
			this.vmethod_20().method_3(false);
			this.vmethod_20().method_9(0);
			this.vmethod_20().Size = new Size(114, 20);
			this.vmethod_20().TabIndex = 30;
			this.vmethod_20().method_1(HorizontalAlignment.Left);
			this.vmethod_20().method_5(false);
			this.vmethod_20().method_10("");
			this.vmethod_22().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_22().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_22().Location = new Point(564, 648);
			this.vmethod_22().Name = "Label5";
			this.vmethod_22().Size = new Size(60, 13);
			this.vmethod_22().TabIndex = 29;
			this.vmethod_22().Text = "How many:";
			this.vmethod_24().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_24().BackColor = Color.Transparent;
			this.vmethod_24().DialogResult = DialogResult.None;
			this.vmethod_24().Font = new Font("Segoe UI", 10f);
			this.vmethod_24().ForeColor = SystemColors.Control;
			this.vmethod_24().Location = new Point(769, 644);
			this.vmethod_24().Name = "Button1";
			this.vmethod_24().Padding = new Padding(5);
			this.vmethod_24().method_1(0);
			this.vmethod_24().Size = new Size(111, 20);
			this.vmethod_24().TabIndex = 28;
			this.vmethod_24().Text = "Add Selected";
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().Location = new Point(294, 10);
			this.vmethod_26().Name = "Label2";
			this.vmethod_26().Size = new Size(70, 13);
			this.vmethod_26().TabIndex = 25;
			this.vmethod_26().Text = "Boats to add:";
			this.vmethod_28().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_28().Location = new Point(12, 10);
			this.vmethod_28().Name = "Label1";
			this.vmethod_28().Size = new Size(87, 13);
			this.vmethod_28().TabIndex = 24;
			this.vmethod_28().Text = "Current inventory";
			this.vmethod_30().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_30().Location = new Point(12, 29);
			this.vmethod_30().Name = "ListView1";
			this.vmethod_30().Size = new Size(278, 597);
			this.vmethod_30().TabIndex = 23;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(892, 679);
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_30());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditBoats";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Edit docked boats";
			this.vmethod_0().ResumeLayout(false);
			((ISupportInitialize)this.vmethod_10()).EndInit();
			this.vmethod_14().ResumeLayout(false);
			((ISupportInitialize)this.vmethod_16()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06007607 RID: 30215 RVA: 0x0004919F File Offset: 0x0004739F
		[CompilerGenerated]
		internal Class115 vmethod_0()
		{
			return this.class115_0;
		}

		// Token: 0x06007608 RID: 30216 RVA: 0x000491A7 File Offset: 0x000473A7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class115 class115_2)
		{
			this.class115_0 = class115_2;
		}

		// Token: 0x06007609 RID: 30217 RVA: 0x000491B0 File Offset: 0x000473B0
		[CompilerGenerated]
		internal Class2451 vmethod_2()
		{
			return this.class2451_0;
		}

		// Token: 0x0600760A RID: 30218 RVA: 0x003FAF00 File Offset: 0x003F9100
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class2451 class2451_2)
		{
			EventHandler value = new EventHandler(this.method_14);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectedIndexChanged -= value;
			}
			this.class2451_0 = class2451_2;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectedIndexChanged += value;
			}
		}

		// Token: 0x0600760B RID: 30219 RVA: 0x000491B8 File Offset: 0x000473B8
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_0;
		}

		// Token: 0x0600760C RID: 30220 RVA: 0x000491C0 File Offset: 0x000473C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_6)
		{
			this.class116_0 = class116_6;
		}

		// Token: 0x0600760D RID: 30221 RVA: 0x000491C9 File Offset: 0x000473C9
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_1;
		}

		// Token: 0x0600760E RID: 30222 RVA: 0x000491D1 File Offset: 0x000473D1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_6)
		{
			this.class116_1 = class116_6;
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x000491DA File Offset: 0x000473DA
		[CompilerGenerated]
		internal Control8 vmethod_8()
		{
			return this.control8_0;
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x003FAF44 File Offset: 0x003F9144
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control8 control8_2)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_11);
			Control8 control = this.control8_0;
			if (control != null)
			{
				control.method_22(delegate85_);
			}
			this.control8_0 = control8_2;
			control = this.control8_0;
			if (control != null)
			{
				control.method_21(delegate85_);
			}
		}

		// Token: 0x06007611 RID: 30225 RVA: 0x000491E2 File Offset: 0x000473E2
		[CompilerGenerated]
		internal Class114 vmethod_10()
		{
			return this.class114_0;
		}

		// Token: 0x06007612 RID: 30226 RVA: 0x003FAF88 File Offset: 0x003F9188
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class114 class114_1)
		{
			KeyPressEventHandler value = new KeyPressEventHandler(this.method_10);
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

		// Token: 0x06007613 RID: 30227 RVA: 0x000491EA File Offset: 0x000473EA
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_0;
		}

		// Token: 0x06007614 RID: 30228 RVA: 0x003FAFCC File Offset: 0x003F91CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_9);
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

		// Token: 0x06007615 RID: 30229 RVA: 0x000491F2 File Offset: 0x000473F2
		[CompilerGenerated]
		internal Class115 vmethod_14()
		{
			return this.class115_1;
		}

		// Token: 0x06007616 RID: 30230 RVA: 0x000491FA File Offset: 0x000473FA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class115 class115_2)
		{
			this.class115_1 = class115_2;
		}

		// Token: 0x06007617 RID: 30231 RVA: 0x00049203 File Offset: 0x00047403
		[CompilerGenerated]
		internal Class120 vmethod_16()
		{
			return this.class120_0;
		}

		// Token: 0x06007618 RID: 30232 RVA: 0x0004920B File Offset: 0x0004740B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class120 class120_1)
		{
			this.class120_0 = class120_1;
		}

		// Token: 0x06007619 RID: 30233 RVA: 0x00049214 File Offset: 0x00047414
		[CompilerGenerated]
		internal Control9 vmethod_18()
		{
			return this.control9_1;
		}

		// Token: 0x0600761A RID: 30234 RVA: 0x003FB010 File Offset: 0x003F9210
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Control9 control9_3)
		{
			EventHandler value = new EventHandler(this.method_8);
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

		// Token: 0x0600761B RID: 30235 RVA: 0x0004921C File Offset: 0x0004741C
		[CompilerGenerated]
		internal Control8 vmethod_20()
		{
			return this.control8_1;
		}

		// Token: 0x0600761C RID: 30236 RVA: 0x00049224 File Offset: 0x00047424
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Control8 control8_2)
		{
			this.control8_1 = control8_2;
		}

		// Token: 0x0600761D RID: 30237 RVA: 0x0004922D File Offset: 0x0004742D
		[CompilerGenerated]
		internal Class116 vmethod_22()
		{
			return this.class116_2;
		}

		// Token: 0x0600761E RID: 30238 RVA: 0x00049235 File Offset: 0x00047435
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class116 class116_6)
		{
			this.class116_2 = class116_6;
		}

		// Token: 0x0600761F RID: 30239 RVA: 0x0004923E File Offset: 0x0004743E
		[CompilerGenerated]
		internal Control9 vmethod_24()
		{
			return this.control9_2;
		}

		// Token: 0x06007620 RID: 30240 RVA: 0x003FB054 File Offset: 0x003F9254
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Control9 control9_3)
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

		// Token: 0x06007621 RID: 30241 RVA: 0x00049246 File Offset: 0x00047446
		[CompilerGenerated]
		internal Class116 vmethod_26()
		{
			return this.class116_3;
		}

		// Token: 0x06007622 RID: 30242 RVA: 0x0004924E File Offset: 0x0004744E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class116 class116_6)
		{
			this.class116_3 = class116_6;
		}

		// Token: 0x06007623 RID: 30243 RVA: 0x00049257 File Offset: 0x00047457
		[CompilerGenerated]
		internal Class116 vmethod_28()
		{
			return this.class116_4;
		}

		// Token: 0x06007624 RID: 30244 RVA: 0x0004925F File Offset: 0x0004745F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Class116 class116_6)
		{
			this.class116_4 = class116_6;
		}

		// Token: 0x06007625 RID: 30245 RVA: 0x00049268 File Offset: 0x00047468
		[CompilerGenerated]
		internal Control4 vmethod_30()
		{
			return this.control4_0;
		}

		// Token: 0x06007626 RID: 30246 RVA: 0x003FB098 File Offset: 0x003F9298
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Control4 control4_1)
		{
			EventHandler eventHandler_ = new EventHandler(this.method_5);
			Control4 control = this.control4_0;
			if (control != null)
			{
				control.method_17(eventHandler_);
			}
			this.control4_0 = control4_1;
			control = this.control4_0;
			if (control != null)
			{
				control.method_16(eventHandler_);
			}
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x00049270 File Offset: 0x00047470
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_32()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x00049278 File Offset: 0x00047478
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x06007629 RID: 30249 RVA: 0x00049281 File Offset: 0x00047481
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_34()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x00049289 File Offset: 0x00047489
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x0600762B RID: 30251 RVA: 0x00049292 File Offset: 0x00047492
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_36()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600762C RID: 30252 RVA: 0x0004929A File Offset: 0x0004749A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x0600762D RID: 30253 RVA: 0x000492A3 File Offset: 0x000474A3
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_38()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x000492AB File Offset: 0x000474AB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x0600762F RID: 30255 RVA: 0x000492B4 File Offset: 0x000474B4
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_40()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06007630 RID: 30256 RVA: 0x000492BC File Offset: 0x000474BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x06007631 RID: 30257 RVA: 0x000492C5 File Offset: 0x000474C5
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_42()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x000492CD File Offset: 0x000474CD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x000492D6 File Offset: 0x000474D6
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_44()
		{
			return this.dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06007634 RID: 30260 RVA: 0x000492DE File Offset: 0x000474DE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x06007635 RID: 30261 RVA: 0x000492E7 File Offset: 0x000474E7
		[CompilerGenerated]
		internal Class2451 vmethod_46()
		{
			return this.class2451_1;
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x003FB0DC File Offset: 0x003F92DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(Class2451 class2451_2)
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

		// Token: 0x06007637 RID: 30263 RVA: 0x000492EF File Offset: 0x000474EF
		[CompilerGenerated]
		internal Class116 vmethod_48()
		{
			return this.class116_5;
		}

		// Token: 0x06007638 RID: 30264 RVA: 0x000492F7 File Offset: 0x000474F7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(Class116 class116_6)
		{
			this.class116_5 = class116_6;
		}

		// Token: 0x06007639 RID: 30265 RVA: 0x003FB120 File Offset: 0x003F9320
		private void EditBoats_Load(object sender, EventArgs e)
		{
			this.vmethod_46().SelectedIndex = 0;
			this.method_3();
			DataTable cache_OperatorCountries_DT = Client.smethod_46().Cache_OperatorCountries_DT;
			this.vmethod_2().DataSource = cache_OperatorCountries_DT;
			this.vmethod_2().DisplayMember = "Description";
			this.vmethod_2().ValueMember = "ID";
			this.vmethod_2().SelectedIndex = 0;
			this.Text = "Edit docked boats for " + this.activeUnit_0.Name;
			this.method_12();
			this.method_4();
		}

		// Token: 0x0600763A RID: 30266 RVA: 0x003FB1AC File Offset: 0x003F93AC
		private void method_3()
		{
			int selectedIndex = this.vmethod_46().SelectedIndex;
			if (selectedIndex != 0)
			{
				if (selectedIndex == 1)
				{
					this.dataTable_0 = Client.smethod_46().Cache_Subs_DT.Copy();
				}
			}
			else
			{
				this.dataTable_0 = Client.smethod_46().Cache_Ships_DT.Copy();
			}
			List<DataRow> list = new List<DataRow>();
			try
			{
				foreach (object obj in this.dataTable_0.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					short short_ = Conversions.ToShort(dataRow["Length"]);
					DockFacility.Enum50 enum50_ = (DockFacility.Enum50)Conversions.ToShort(dataRow["PhysicalSizeCode"]);
					if (!this.activeUnit_0.vmethod_93().method_41(short_, enum50_))
					{
						list.Add(dataRow);
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
			try
			{
				foreach (DataRow row in list)
				{
					this.dataTable_0.Rows.Remove(row);
				}
			}
			finally
			{
				List<DataRow>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
		}

		// Token: 0x0600763B RID: 30267 RVA: 0x003FB2E0 File Offset: 0x003F94E0
		private void EditBoats_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Client.smethod_0().method_0() == Class279.Enum68.const_0)
			{
				Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), Client.smethod_54(), false);
			}
			Class2413.smethod_2().method_41().BringToFront();
			Class2413.smethod_2().method_41().vmethod_796().Focus();
		}

		// Token: 0x0600763C RID: 30268 RVA: 0x003FB344 File Offset: 0x003F9544
		private void method_4()
		{
			Client.bool_1 = true;
			this.vmethod_30().method_18().Clear();
			IEnumerable<int> enumerable = Enumerable.Distinct<int>(Enumerable.Select<ActiveUnit, int>(Enumerable.Where<ActiveUnit>(this.activeUnit_0.vmethod_93().method_14(), (EditBoats._Closure$__.$I109-0 == null) ? (EditBoats._Closure$__.$I109-0 = new Func<ActiveUnit, bool>(EditBoats._Closure$__.$I.method_0)) : EditBoats._Closure$__.$I109-0), (EditBoats._Closure$__.$I109-1 == null) ? (EditBoats._Closure$__.$I109-1 = new Func<ActiveUnit, int>(EditBoats._Closure$__.$I.method_1)) : EditBoats._Closure$__.$I109-1));
			IEnumerable<int> enumerable2 = Enumerable.Distinct<int>(Enumerable.Select<ActiveUnit, int>(Enumerable.Where<ActiveUnit>(this.activeUnit_0.vmethod_93().method_14(), (EditBoats._Closure$__.$I109-2 == null) ? (EditBoats._Closure$__.$I109-2 = new Func<ActiveUnit, bool>(EditBoats._Closure$__.$I.method_2)) : EditBoats._Closure$__.$I109-2), (EditBoats._Closure$__.$I109-3 == null) ? (EditBoats._Closure$__.$I109-3 = new Func<ActiveUnit, int>(EditBoats._Closure$__.$I.method_3)) : EditBoats._Closure$__.$I109-3));
			try
			{
				foreach (int int_ in enumerable)
				{
					EditBoats.Class2503 @class = new EditBoats.Class2503(@class);
					@class.int_0 = int_;
					IEnumerable<ActiveUnit> enumerable3 = Enumerable.Where<ActiveUnit>(this.activeUnit_0.vmethod_93().method_14(), new Func<ActiveUnit, bool>(@class.method_0));
					Class117 class2 = new Class117();
					class2.Tag = "Ship_" + Conversions.ToString(@class.int_0);
					class2.method_3(Conversions.ToString(Enumerable.Count<ActiveUnit>(enumerable3)) + "x " + Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable3, 0).string_2);
					this.vmethod_30().method_18().Add(class2);
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
			try
			{
				foreach (int int_2 in enumerable2)
				{
					EditBoats.Class2504 class3 = new EditBoats.Class2504(class3);
					class3.int_0 = int_2;
					IEnumerable<ActiveUnit> enumerable4 = Enumerable.Where<ActiveUnit>(this.activeUnit_0.vmethod_93().method_14(), new Func<ActiveUnit, bool>(class3.method_0));
					Class117 class4 = new Class117();
					class4.Tag = "Sub_" + Conversions.ToString(class3.int_0);
					class4.method_3(Conversions.ToString(Enumerable.Count<ActiveUnit>(enumerable4)) + "x " + Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable4, 0).string_2);
					this.vmethod_30().method_18().Add(class4);
				}
			}
			finally
			{
				IEnumerator<int> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			this.vmethod_12().Visible = (this.vmethod_30().method_20().Count > 0);
			this.vmethod_12().Enabled = this.vmethod_12().Visible;
		}

		// Token: 0x0600763D RID: 30269 RVA: 0x003FB610 File Offset: 0x003F9810
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_30().method_21().Count > 0)
			{
				EditBoats.Class2505 @class = new EditBoats.Class2505();
				string text = this.vmethod_30().method_21()[0].Tag.ToString();
				@class.int_0 = Conversions.ToInteger(text.Split(Conversions.ToCharArrayRankOne("_"))[1]);
				string left = text.Split(Conversions.ToCharArrayRankOne("_"))[0];
				int value;
				if (Operators.CompareString(left, "Ship", false) != 0)
				{
					if (Operators.CompareString(left, "Sub", false) != 0)
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
							return;
						}
						return;
					}
					else
					{
						value = Enumerable.Count<ActiveUnit>(Enumerable.Where<ActiveUnit>(this.activeUnit_0.vmethod_93().method_14(), new Func<ActiveUnit, bool>(@class.method_1)));
					}
				}
				else
				{
					value = Enumerable.Count<ActiveUnit>(Enumerable.Where<ActiveUnit>(this.activeUnit_0.vmethod_93().method_14(), new Func<ActiveUnit, bool>(@class.method_0)));
				}
				this.vmethod_16().Value = new decimal(value);
			}
			this.vmethod_12().Visible = (this.vmethod_30().method_21().Count > 0);
			this.vmethod_12().Enabled = this.vmethod_12().Visible;
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x003FB748 File Offset: 0x003F9948
		private void method_6(int int_0, ref bool bool_3)
		{
			int selectedIndex = this.vmethod_46().SelectedIndex;
			DockFacility dockFacility;
			if (selectedIndex == 0)
			{
				Ship ship = Client.smethod_46().method_73(Client.smethod_50(), int_0, "", 0.0, 0.0, false, Unit.Enum122.const_0, null);
				ship.Name = ship.string_2 + " #" + Conversions.ToString(Client.smethod_46().UnitsAutoIncrement);
				ActiveUnit_DockingOps activeUnit_DockingOps = this.activeUnit_0.vmethod_93();
				ActiveUnit theBoat = ship;
				dockFacility = null;
				if (activeUnit_DockingOps.method_40(theBoat, ref dockFacility))
				{
					this.activeUnit_0.vmethod_93().method_42(ship);
				}
				else
				{
					Client.smethod_46().method_66(ship.string_0, true);
					bool_3 = true;
				}
				bool isAttached = Debugger.IsAttached;
				return;
			}
			if (selectedIndex != 1)
			{
				return;
			}
			Submarine submarine = Client.smethod_46().method_75(Client.smethod_50(), int_0, "", 0.0, 0.0, false, Unit.Enum122.const_0, null);
			submarine.Name = submarine.string_2 + " #" + Conversions.ToString(Client.smethod_46().UnitsAutoIncrement);
			ActiveUnit_DockingOps activeUnit_DockingOps2 = this.activeUnit_0.vmethod_93();
			ActiveUnit theBoat2 = submarine;
			dockFacility = null;
			if (activeUnit_DockingOps2.method_40(theBoat2, ref dockFacility))
			{
				this.activeUnit_0.vmethod_93().method_42(submarine);
			}
			else
			{
				Client.smethod_46().method_66(submarine.string_0, true);
				bool_3 = true;
			}
			bool isAttached2 = Debugger.IsAttached;
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x003FB898 File Offset: 0x003F9A98
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_10().SelectedRows.Count != 0)
			{
				int num = Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells[0].Value.ToString());
				if (!(num == 10000 | num == 10001 | num == 10002) && Versioned.IsNumeric(this.vmethod_20().Text))
				{
					this.vmethod_24().Text = "Working...";
					this.vmethod_24().Enabled = false;
					bool flag = false;
					int num2 = Conversions.ToInteger(this.vmethod_20().Text);
					for (int i = 1; i <= num2; i++)
					{
						this.method_6(num, ref flag);
					}
					if (flag)
					{
						DarkMessageBox.smethod_1("Unable to add all boats to host - Exceeded maximum docking space.", "Out of space!", Enum11.const_0);
					}
					this.vmethod_24().Text = "Add Selected";
					this.vmethod_24().Enabled = true;
					this.method_4();
				}
			}
		}

		// Token: 0x06007640 RID: 30272 RVA: 0x003FB994 File Offset: 0x003F9B94
		private void method_8(object sender, EventArgs e)
		{
			EditBoats.Class2506 @class = new EditBoats.Class2506(@class);
			if (this.vmethod_30().method_21().Count != 0)
			{
				this.vmethod_18().Text = "Working...";
				this.vmethod_18().Enabled = false;
				string text = this.vmethod_30().method_21()[0].Tag.ToString();
				@class.int_0 = Conversions.ToInteger(text.Split(Conversions.ToCharArrayRankOne("_"))[1]);
				string left = text.Split(Conversions.ToCharArrayRankOne("_"))[0];
				IEnumerable<ActiveUnit> enumerable;
				if (Operators.CompareString(left, "Ship", false) != 0)
				{
					if (Operators.CompareString(left, "Sub", false) != 0)
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
							return;
						}
						return;
					}
					else
					{
						enumerable = Enumerable.Where<ActiveUnit>(this.activeUnit_0.vmethod_93().method_14(), new Func<ActiveUnit, bool>(@class.method_1));
					}
				}
				else
				{
					enumerable = Enumerable.Where<ActiveUnit>(this.activeUnit_0.vmethod_93().method_14(), new Func<ActiveUnit, bool>(@class.method_0));
				}
				if (decimal.Compare(this.vmethod_16().Value, new decimal(Enumerable.Count<ActiveUnit>(enumerable))) < 0)
				{
					int num = Enumerable.Count<ActiveUnit>(enumerable) - 1;
					int num2 = Convert.ToInt32(this.vmethod_16().Value);
					for (int i = num; i >= num2; i += -1)
					{
						Client.smethod_46().method_66(Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable, i).string_0, true);
					}
				}
				bool flag = false;
				if (decimal.Compare(this.vmethod_16().Value, new decimal(Enumerable.Count<ActiveUnit>(enumerable))) > 0)
				{
					Enumerable.ElementAtOrDefault<int>(Enumerable.Select<ActiveUnit, int>(enumerable, (EditBoats._Closure$__.$I113-2 == null) ? (EditBoats._Closure$__.$I113-2 = new Func<ActiveUnit, int>(EditBoats._Closure$__.$I.method_4)) : EditBoats._Closure$__.$I113-2), 0);
					int num3 = Enumerable.Count<ActiveUnit>(enumerable) + 1;
					int num4 = Convert.ToInt32(this.vmethod_16().Value);
					for (int j = num3; j <= num4; j++)
					{
						this.method_6(@class.int_0, ref flag);
					}
				}
				if (flag)
				{
					DarkMessageBox.smethod_1("Unable to add all boats to host - Exceeded maximum docking space.", "Out of space!", Enum11.const_0);
				}
				this.vmethod_18().Text = "Apply";
				this.vmethod_18().Enabled = true;
				this.method_4();
			}
		}

		// Token: 0x06007641 RID: 30273 RVA: 0x003FBBB8 File Offset: 0x003F9DB8
		private void method_9(object sender, EventArgs e)
		{
			EditBoats.Class2507 @class = new EditBoats.Class2507(@class);
			string text = this.vmethod_30().method_21()[0].Tag.ToString();
			@class.int_0 = Conversions.ToInteger(text.Split(new char[]
			{
				'_'
			})[1]);
			string left = text.Split(new char[]
			{
				'_'
			})[0];
			IEnumerable<ActiveUnit> enumerable;
			if (Operators.CompareString(left, "Ship", false) != 0)
			{
				if (Operators.CompareString(left, "Sub", false) != 0)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
						return;
					}
					return;
				}
				else
				{
					enumerable = Enumerable.Where<ActiveUnit>(this.activeUnit_0.vmethod_93().method_14(), new Func<ActiveUnit, bool>(@class.method_1));
				}
			}
			else
			{
				enumerable = Enumerable.Where<ActiveUnit>(this.activeUnit_0.vmethod_93().method_14(), new Func<ActiveUnit, bool>(@class.method_0));
			}
			for (int i = Enumerable.Count<ActiveUnit>(enumerable) - 1; i >= 0; i += -1)
			{
				Client.smethod_46().method_66(Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable, i).string_0, true);
			}
			this.method_4();
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x003FBCC4 File Offset: 0x003F9EC4
		private void method_10(object sender, KeyPressEventArgs e)
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

		// Token: 0x06007643 RID: 30275 RVA: 0x00049300 File Offset: 0x00047500
		private void method_11(object object_0)
		{
			if (Operators.CompareString(this.vmethod_8().Text, "", false) != 0)
			{
				this.method_12();
			}
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x003FBDA8 File Offset: 0x003F9FA8
		private void method_12()
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Name ASC";
			if (!(Operators.CompareString(this.vmethod_8().Text, "", false) == 0 & this.vmethod_2().SelectedIndex == 0))
			{
				string text = "1=1 ";
				if (Operators.CompareString(this.vmethod_8().Text, "", false) != 0)
				{
					string str = this.vmethod_8().Text.Replace("'", "''");
					text = text + " AND Name LIKE '%" + str + "%' ";
				}
				if (this.vmethod_2().SelectedIndex > 0)
				{
					text = text + " AND OperatorCountry=" + this.vmethod_2().SelectedValue.ToString();
				}
				text = text.Replace("[", "[[");
				text = text.Replace("]", "]]");
				text = text.Replace("[[", "[[]");
				text = text.Replace("]]", "[]]");
				dataView.RowFilter = text;
			}
			this.vmethod_10().AutoGenerateColumns = false;
			this.vmethod_10().DataSource = dataView;
			this.vmethod_10().Refresh();
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x00049320 File Offset: 0x00047520
		private void method_13(object sender, EventArgs e)
		{
			this.method_3();
			this.method_12();
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x003B6260 File Offset: 0x003B4460
		private void EditBoats_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06007647 RID: 30279 RVA: 0x0004932E File Offset: 0x0004752E
		private void method_14(object sender, EventArgs e)
		{
			this.method_12();
		}

		// Token: 0x0400422C RID: 16940
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox1")]
		private Class115 class115_0;

		// Token: 0x0400422D RID: 16941
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Country")]
		private Class2451 class2451_0;

		// Token: 0x0400422E RID: 16942
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_0;

		// Token: 0x0400422F RID: 16943
		[CompilerGenerated]
		[AccessedThroughProperty("Label6")]
		private Class116 class116_1;

		// Token: 0x04004230 RID: 16944
		[CompilerGenerated]
		[AccessedThroughProperty("TB_Class")]
		private Control8 control8_0;

		// Token: 0x04004231 RID: 16945
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridView1")]
		private Class114 class114_0;

		// Token: 0x04004232 RID: 16946
		[AccessedThroughProperty("Button_RemoveBoat")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x04004233 RID: 16947
		[AccessedThroughProperty("Quantity")]
		[CompilerGenerated]
		private Class115 class115_1;

		// Token: 0x04004234 RID: 16948
		[AccessedThroughProperty("NUD1")]
		[CompilerGenerated]
		private Class120 class120_0;

		// Token: 0x04004235 RID: 16949
		[AccessedThroughProperty("Button2")]
		[CompilerGenerated]
		private Control9 control9_1;

		// Token: 0x04004236 RID: 16950
		[AccessedThroughProperty("TB_Quantity")]
		[CompilerGenerated]
		private Control8 control8_1;

		// Token: 0x04004237 RID: 16951
		[AccessedThroughProperty("Label5")]
		[CompilerGenerated]
		private Class116 class116_2;

		// Token: 0x04004238 RID: 16952
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x04004239 RID: 16953
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_3;

		// Token: 0x0400423A RID: 16954
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_4;

		// Token: 0x0400423B RID: 16955
		[CompilerGenerated]
		[AccessedThroughProperty("ListView1")]
		private Control4 control4_0;

		// Token: 0x0400423C RID: 16956
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x0400423D RID: 16957
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x0400423E RID: 16958
		[CompilerGenerated]
		[AccessedThroughProperty("Country")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x0400423F RID: 16959
		[CompilerGenerated]
		[AccessedThroughProperty("IOC")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04004240 RID: 16960
		[CompilerGenerated]
		[AccessedThroughProperty("Retired")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04004241 RID: 16961
		[CompilerGenerated]
		[AccessedThroughProperty("CountryNumber")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x04004242 RID: 16962
		[CompilerGenerated]
		[AccessedThroughProperty("Column2")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x04004243 RID: 16963
		[CompilerGenerated]
		[AccessedThroughProperty("ComboBox1")]
		private Class2451 class2451_1;

		// Token: 0x04004244 RID: 16964
		[CompilerGenerated]
		[AccessedThroughProperty("Label4")]
		private Class116 class116_5;

		// Token: 0x04004245 RID: 16965
		public ActiveUnit activeUnit_0;

		// Token: 0x04004246 RID: 16966
		private DataTable dataTable_0;

		// Token: 0x02000EA5 RID: 3749
		[CompilerGenerated]
		internal sealed class Class2503
		{
			// Token: 0x06007648 RID: 30280 RVA: 0x00049336 File Offset: 0x00047536
			public Class2503(EditBoats.Class2503 class2503_0)
			{
				if (class2503_0 != null)
				{
					this.int_0 = class2503_0.int_0;
				}
			}

			// Token: 0x06007649 RID: 30281 RVA: 0x0004934D File Offset: 0x0004754D
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.bool_6 & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04004247 RID: 16967
			public int int_0;
		}

		// Token: 0x02000EA6 RID: 3750
		[CompilerGenerated]
		internal sealed class Class2504
		{
			// Token: 0x0600764A RID: 30282 RVA: 0x00049364 File Offset: 0x00047564
			public Class2504(EditBoats.Class2504 class2504_0)
			{
				if (class2504_0 != null)
				{
					this.int_0 = class2504_0.int_0;
				}
			}

			// Token: 0x0600764B RID: 30283 RVA: 0x0004937B File Offset: 0x0004757B
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.bool_5 & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04004248 RID: 16968
			public int int_0;
		}

		// Token: 0x02000EA8 RID: 3752
		[CompilerGenerated]
		internal sealed class Class2505
		{
			// Token: 0x06007654 RID: 30292 RVA: 0x0004939E File Offset: 0x0004759E
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.bool_6 & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x06007655 RID: 30293 RVA: 0x000493B5 File Offset: 0x000475B5
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.bool_5 & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x0400424F RID: 16975
			public int int_0;
		}

		// Token: 0x02000EA9 RID: 3753
		[CompilerGenerated]
		internal sealed class Class2506
		{
			// Token: 0x06007656 RID: 30294 RVA: 0x000493CC File Offset: 0x000475CC
			public Class2506(EditBoats.Class2506 class2506_0)
			{
				if (class2506_0 != null)
				{
					this.int_0 = class2506_0.int_0;
				}
			}

			// Token: 0x06007657 RID: 30295 RVA: 0x000493E3 File Offset: 0x000475E3
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.bool_6 & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x06007658 RID: 30296 RVA: 0x000493FA File Offset: 0x000475FA
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.bool_5 & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04004250 RID: 16976
			public int int_0;
		}

		// Token: 0x02000EAA RID: 3754
		[CompilerGenerated]
		internal sealed class Class2507
		{
			// Token: 0x06007659 RID: 30297 RVA: 0x00049411 File Offset: 0x00047611
			public Class2507(EditBoats.Class2507 class2507_0)
			{
				if (class2507_0 != null)
				{
					this.int_0 = class2507_0.int_0;
				}
			}

			// Token: 0x0600765A RID: 30298 RVA: 0x00049428 File Offset: 0x00047628
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.bool_6 & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x0600765B RID: 30299 RVA: 0x0004943F File Offset: 0x0004763F
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.bool_5 & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04004251 RID: 16977
			public int int_0;
		}
	}
}
