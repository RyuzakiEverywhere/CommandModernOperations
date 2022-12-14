using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns14;
using ns2;
using ns3;
using ns4;
using ns5;
using ns8;

namespace ns6
{
	// Token: 0x02000E9B RID: 3739
	[DesignerGenerated]
	internal sealed partial class ReadyAircraft : DarkSecondaryFormBase
	{
		// Token: 0x060074B3 RID: 29875 RVA: 0x003EF5E4 File Offset: 0x003ED7E4
		public ReadyAircraft()
		{
			base.FormClosing += this.ReadyAircraft_FormClosing;
			base.Load += this.ReadyAircraft_Load;
			base.KeyDown += this.ReadyAircraft_KeyDown;
			this.dataTable_0 = new DataTable();
			this.dataTable_1 = new DataTable();
			this.dictionary_0 = new Dictionary<int, int>();
			this.hashSet_0 = new HashSet<int>();
			this.InitializeComponent_1();
		}

		// Token: 0x060074B5 RID: 29877 RVA: 0x003EF6A0 File Offset: 0x003ED8A0
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			this.vmethod_27(new Class112());
			this.vmethod_25(new Control9());
			this.vmethod_23(new Control9());
			this.vmethod_21(new Class116());
			this.vmethod_19(new Class116());
			this.vmethod_17(new Class116());
			this.vmethod_15(new Class116());
			this.vmethod_13(new Class116());
			this.vmethod_11(new Control9());
			this.vmethod_5(new Control9());
			this.vmethod_3(new Control9());
			this.vmethod_1(new Class116());
			this.vmethod_39(new Class114());
			this.vmethod_91(new DataGridViewTextBoxColumn());
			this.vmethod_93(new DataGridViewLinkColumn());
			this.vmethod_95(new DataGridViewTextBoxColumn());
			this.vmethod_97(new DataGridViewTextBoxColumn());
			this.vmethod_41(new Class114());
			this.vmethod_43(new DataGridViewTextBoxColumn());
			this.vmethod_45(new DataGridViewTextBoxColumn());
			this.vmethod_47(new DataGridViewTextBoxColumn());
			this.vmethod_49(new DataGridViewTextBoxColumn());
			this.vmethod_51(new DataGridViewTextBoxColumn());
			this.vmethod_53(new DataGridViewTextBoxColumn());
			this.vmethod_55(new DataGridViewTextBoxColumn());
			this.vmethod_57(new DataGridViewTextBoxColumn());
			this.vmethod_59(new DataGridViewTextBoxColumn());
			this.vmethod_61(new DataGridViewTextBoxColumn());
			this.vmethod_63(new DataGridViewTextBoxColumn());
			this.vmethod_65(new DataGridViewTextBoxColumn());
			this.vmethod_67(new DataGridViewTextBoxColumn());
			this.vmethod_69(new DataGridViewTextBoxColumn());
			this.vmethod_71(new DataGridViewTextBoxColumn());
			this.vmethod_73(new DataGridViewTextBoxColumn());
			this.vmethod_75(new DataGridViewTextBoxColumn());
			this.vmethod_77(new DataGridViewTextBoxColumn());
			this.vmethod_79(new DataGridViewTextBoxColumn());
			this.vmethod_81(new DataGridViewTextBoxColumn());
			this.vmethod_83(new DataGridViewTextBoxColumn());
			this.vmethod_85(new DataGridViewTextBoxColumn());
			this.vmethod_87(new DataGridViewTextBoxColumn());
			this.vmethod_89(new DataGridViewTextBoxColumn());
			this.vmethod_7(new Class119());
			this.vmethod_9(new Class128());
			this.vmethod_29(new Class116());
			this.vmethod_31(new FlowLayoutPanel());
			this.vmethod_33(new Class112());
			this.vmethod_35(new Class2451());
			this.vmethod_37(new Class116());
			((ISupportInitialize)this.vmethod_38()).BeginInit();
			((ISupportInitialize)this.vmethod_40()).BeginInit();
			this.vmethod_6().SuspendLayout();
			this.vmethod_30().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_26().AutoSize = true;
			this.vmethod_26().Location = new Point(145, 5);
			this.vmethod_26().Name = "CB_ShowOnlyUsable";
			this.vmethod_26().Size = new Size(167, 19);
			this.vmethod_26().TabIndex = 30;
			this.vmethod_26().Text = "Show only usable loadouts";
			this.vmethod_24().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_24().BackColor = Color.Transparent;
			this.vmethod_24().DialogResult = DialogResult.None;
			this.vmethod_24().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_24().ForeColor = SystemColors.Control;
			this.vmethod_24().Location = new Point(85, 538);
			this.vmethod_24().Name = "Button5";
			this.vmethod_24().Padding = new Padding(5);
			this.vmethod_24().method_1(0);
			this.vmethod_24().Size = new Size(213, 23);
			this.vmethod_24().TabIndex = 26;
			this.vmethod_24().Text = "OK - Ready (Exclude Optional Weapons)";
			this.vmethod_22().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_22().BackColor = Color.Transparent;
			this.vmethod_22().DialogResult = DialogResult.None;
			this.vmethod_22().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_22().ForeColor = Color.Red;
			this.vmethod_22().Location = new Point(497, 538);
			this.vmethod_22().Name = "Button4";
			this.vmethod_22().Padding = new Padding(5);
			this.vmethod_22().method_1(0);
			this.vmethod_22().Size = new Size(296, 23);
			this.vmethod_22().TabIndex = 25;
			this.vmethod_22().Text = "Ready Immediately - Ignore Magazines (ScenEdit)";
			this.vmethod_20().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_20().method_2(true);
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Location = new Point(655, 444);
			this.vmethod_20().Name = "Label8";
			this.vmethod_20().Size = new Size(227, 15);
			this.vmethod_20().TabIndex = 24;
			this.vmethod_20().Text = "NumberOfLoadoutsTotal_MandatoryOnly";
			this.vmethod_18().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_18().method_2(true);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(655, 429);
			this.vmethod_18().Name = "Label7";
			this.vmethod_18().Size = new Size(139, 15);
			this.vmethod_18().TabIndex = 23;
			this.vmethod_18().Text = "NumberOfLoadoutsTotal";
			this.vmethod_16().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_16().method_2(true);
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Location = new Point(655, 414);
			this.vmethod_16().Name = "Label6";
			this.vmethod_16().Size = new Size(153, 15);
			this.vmethod_16().TabIndex = 22;
			this.vmethod_16().Text = "NumberOfLoadoutsOnBase";
			this.vmethod_14().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_14().method_2(true);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(655, 399);
			this.vmethod_14().Name = "Label5";
			this.vmethod_14().Size = new Size(83, 15);
			this.vmethod_14().TabIndex = 21;
			this.vmethod_14().Text = "AttackAltitude";
			this.vmethod_12().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_12().method_2(true);
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Location = new Point(655, 384);
			this.vmethod_12().Name = "Label2";
			this.vmethod_12().Size = new Size(134, 15);
			this.vmethod_12().TabIndex = 18;
			this.vmethod_12().Text = "LoadoutRoleDescription";
			this.vmethod_10().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().DialogResult = DialogResult.None;
			this.vmethod_10().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_10().ForeColor = Color.Red;
			this.vmethod_10().Location = new Point(304, 538);
			this.vmethod_10().Name = "Button3";
			this.vmethod_10().Padding = new Padding(5);
			this.vmethod_10().method_1(0);
			this.vmethod_10().Size = new Size(187, 23);
			this.vmethod_10().TabIndex = 16;
			this.vmethod_10().Text = "Ready Immediately (ScenEdit)";
			this.vmethod_4().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(1016, 538);
			this.vmethod_4().Name = "Button2";
			this.vmethod_4().Padding = new Padding(5);
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(75, 23);
			this.vmethod_4().TabIndex = 14;
			this.vmethod_4().Text = "Cancel";
			this.vmethod_2().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DialogResult = DialogResult.None;
			this.vmethod_2().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_2().ForeColor = SystemColors.Control;
			this.vmethod_2().Location = new Point(4, 538);
			this.vmethod_2().Name = "Button1";
			this.vmethod_2().Padding = new Padding(5);
			this.vmethod_2().method_1(0);
			this.vmethod_2().Size = new Size(75, 23);
			this.vmethod_2().TabIndex = 13;
			this.vmethod_2().Text = "OK - Ready";
			this.vmethod_0().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_0().method_2(true);
			this.vmethod_0().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_0().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_0().Location = new Point(3, 382);
			this.vmethod_0().Name = "Label_Loadout";
			this.vmethod_0().Size = new Size(92, 13);
			this.vmethod_0().TabIndex = 12;
			this.vmethod_0().Text = "Loadout Details:";
			this.vmethod_38().AllowUserToAddRows = false;
			this.vmethod_38().AllowUserToDeleteRows = false;
			this.vmethod_38().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_38().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			this.vmethod_38().AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.vmethod_38().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_38().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_38().CausesValidation = false;
			this.vmethod_38().CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.vmethod_38().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_38().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_38().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_38().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_90(),
				this.vmethod_92(),
				this.vmethod_94(),
				this.vmethod_96()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_38().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_38().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_38().EnableHeadersVisualStyles = false;
			this.vmethod_38().Location = new Point(3, 397);
			this.vmethod_38().MultiSelect = false;
			this.vmethod_38().Name = "DGV_LoadoutItems";
			this.vmethod_38().RowHeadersVisible = false;
			this.vmethod_38().RowHeadersWidth = 20;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_38().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_38().RowTemplate.Height = 15;
			this.vmethod_38().RowTemplate.Resizable = DataGridViewTriState.False;
			this.vmethod_38().ScrollBars = ScrollBars.Vertical;
			this.vmethod_38().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_38().Size = new Size(650, 135);
			this.vmethod_38().TabIndex = 11;
			this.vmethod_90().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_90().DataPropertyName = "ID";
			this.vmethod_90().HeaderText = "ID";
			this.vmethod_90().Name = "DataGridViewTextBoxColumn1";
			this.vmethod_90().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_90().Visible = false;
			this.vmethod_92().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_92().DataPropertyName = "Item";
			this.vmethod_92().HeaderText = "Stores (click for info)";
			this.vmethod_92().LinkBehavior = LinkBehavior.HoverUnderline;
			this.vmethod_92().LinkColor = Color.LightBlue;
			this.vmethod_92().MinimumWidth = 470;
			this.vmethod_92().Name = "Column_Description";
			this.vmethod_92().ReadOnly = true;
			this.vmethod_92().Resizable = DataGridViewTriState.True;
			this.vmethod_92().TrackVisitedState = false;
			this.vmethod_92().Width = 470;
			this.vmethod_94().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_94().DataPropertyName = "Available";
			this.vmethod_94().HeaderText = "# Available, Magazines";
			this.vmethod_94().MinimumWidth = 90;
			this.vmethod_94().Name = "Available";
			this.vmethod_94().ReadOnly = true;
			this.vmethod_94().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_94().ToolTipText = "The number of weapons available in the base's ammo dump";
			this.vmethod_96().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_96().DataPropertyName = "AvailableTotal";
			this.vmethod_96().HeaderText = "# Available, Mags + A/C";
			this.vmethod_96().MinimumWidth = 90;
			this.vmethod_96().Name = "AvailableTotal";
			this.vmethod_96().ReadOnly = true;
			this.vmethod_96().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_96().ToolTipText = "The total number of weapons available including those mounted on the currently selected aircraft";
			this.vmethod_40().AllowUserToAddRows = false;
			this.vmethod_40().AllowUserToDeleteRows = false;
			this.vmethod_40().AllowUserToResizeRows = false;
			this.vmethod_40().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_40().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_40().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_40().CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.vmethod_40().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle4.ForeColor = Color.LightGray;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			this.vmethod_40().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_40().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_40().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_42(),
				this.vmethod_44(),
				this.vmethod_46(),
				this.vmethod_48(),
				this.vmethod_50(),
				this.vmethod_52(),
				this.vmethod_54(),
				this.vmethod_56(),
				this.vmethod_58(),
				this.vmethod_60(),
				this.vmethod_62(),
				this.vmethod_64(),
				this.vmethod_66(),
				this.vmethod_68(),
				this.vmethod_70(),
				this.vmethod_72(),
				this.vmethod_74(),
				this.vmethod_76(),
				this.vmethod_78(),
				this.vmethod_80(),
				this.vmethod_82(),
				this.vmethod_84(),
				this.vmethod_86(),
				this.vmethod_88()
			});
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle5.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle5.ForeColor = Color.LightGray;
			dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
			this.vmethod_40().DefaultCellStyle = dataGridViewCellStyle5;
			this.vmethod_40().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_40().EnableHeadersVisualStyles = false;
			this.vmethod_40().GridColor = SystemColors.ControlText;
			this.vmethod_40().Location = new Point(3, 27);
			this.vmethod_40().MultiSelect = false;
			this.vmethod_40().Name = "DGV_Loadouts";
			this.vmethod_40().RowHeadersVisible = false;
			this.vmethod_40().RowHeadersWidth = 10;
			dataGridViewCellStyle6.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle6.ForeColor = Color.LightGray;
			dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle6.SelectionForeColor = Color.LightGray;
			this.vmethod_40().RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.vmethod_40().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_40().Size = new Size(1088, 315);
			this.vmethod_40().TabIndex = 8;
			this.vmethod_42().DataPropertyName = "ID";
			this.vmethod_42().HeaderText = "ID";
			this.vmethod_42().Name = "ID";
			this.vmethod_42().ReadOnly = true;
			this.vmethod_42().ToolTipText = "The total number of weapons available including those mounted on the currently selected aircraft";
			this.vmethod_42().Visible = false;
			this.vmethod_44().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_44().DataPropertyName = "Name";
			this.vmethod_44().HeaderText = "Loadout Name";
			this.vmethod_44().MinimumWidth = 300;
			this.vmethod_44().Name = "Loadout";
			this.vmethod_44().ReadOnly = true;
			this.vmethod_44().Width = 300;
			this.vmethod_46().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_46().DataPropertyName = "NumberOfLoadouts";
			this.vmethod_46().HeaderText = "# Available, Magazines";
			this.vmethod_46().MinimumWidth = 90;
			this.vmethod_46().Name = "NumberOfLoadouts";
			this.vmethod_46().ReadOnly = true;
			this.vmethod_46().ToolTipText = "The number of weapons available in the base's ammo dump";
			this.vmethod_46().Width = 90;
			this.vmethod_48().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_48().DataPropertyName = "NumberOfLoadoutsIncludingMountedWeapons";
			this.vmethod_48().HeaderText = "# Available, Mags + A/C";
			this.vmethod_48().MinimumWidth = 90;
			this.vmethod_48().Name = "NumberOfLoadoutsIncludingMountedWeapons";
			this.vmethod_48().ReadOnly = true;
			this.vmethod_48().ToolTipText = "The total number of weapons available including those mounted on the currently selected aircraft";
			this.vmethod_48().Width = 90;
			this.vmethod_50().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_50().DataPropertyName = "NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly";
			this.vmethod_50().HeaderText = "# Available, Mandatory";
			this.vmethod_50().MinimumWidth = 90;
			this.vmethod_50().Name = "NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly";
			this.vmethod_50().ReadOnly = true;
			this.vmethod_50().ToolTipText = "The total number of weapons available including those mounted on the currently selected aircraft, excluding any optional weapons";
			this.vmethod_50().Width = 90;
			this.vmethod_52().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_52().DataPropertyName = "ReadyTime";
			this.vmethod_52().HeaderText = "Ready Time, Surge Ops";
			this.vmethod_52().MinimumWidth = 100;
			this.vmethod_52().Name = "ReadyTime";
			this.vmethod_52().ReadOnly = true;
			this.vmethod_54().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_54().DataPropertyName = "ReadyTime_Sustained";
			this.vmethod_54().HeaderText = "Ready Time, Sustained Ops";
			this.vmethod_54().MinimumWidth = 100;
			this.vmethod_54().Name = "ReadyTime_Sustained";
			this.vmethod_54().ReadOnly = true;
			this.vmethod_56().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_56().DataPropertyName = "QuickTurnaroundDescription";
			this.vmethod_56().HeaderText = "Quick Turnaround";
			this.vmethod_56().MinimumWidth = 120;
			this.vmethod_56().Name = "QuickTurnaroundDescription";
			this.vmethod_56().ReadOnly = true;
			this.vmethod_56().Width = 120;
			this.vmethod_58().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_58().DataPropertyName = "TimeofDay";
			this.vmethod_58().HeaderText = "Time of Day";
			this.vmethod_58().MinimumWidth = 90;
			this.vmethod_58().Name = "TimeofDay";
			this.vmethod_58().ReadOnly = true;
			this.vmethod_58().Width = 90;
			this.vmethod_60().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_60().DataPropertyName = "Weather";
			this.vmethod_60().HeaderText = "Weather";
			this.vmethod_60().MinimumWidth = 90;
			this.vmethod_60().Name = "Weather";
			this.vmethod_60().ReadOnly = true;
			this.vmethod_60().Width = 90;
			this.vmethod_62().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_62().DataPropertyName = "RangeProfileDescription";
			this.vmethod_62().HeaderText = "Radius / Profile";
			this.vmethod_62().MinimumWidth = 517;
			this.vmethod_62().Name = "RangeProfileDescription";
			this.vmethod_62().ReadOnly = true;
			this.vmethod_62().Width = 517;
			this.vmethod_64().DataPropertyName = "LoadoutRoleDescription";
			this.vmethod_64().HeaderText = "LoadoutRoleDescription";
			this.vmethod_64().Name = "LoadoutRoleDescription";
			this.vmethod_64().Visible = false;
			this.vmethod_66().DataPropertyName = "LoadoutRole";
			this.vmethod_66().HeaderText = "LoadoutRole";
			this.vmethod_66().Name = "LoadoutRole";
			this.vmethod_66().Visible = false;
			this.vmethod_68().DataPropertyName = "RequiresBuddyIllumination";
			this.vmethod_68().HeaderText = "RequiresBuddyIllumination";
			this.vmethod_68().Name = "RequiresBuddyIllumination";
			this.vmethod_68().Visible = false;
			this.vmethod_70().DataPropertyName = "DefaultCombatRadius";
			this.vmethod_70().HeaderText = "DefaultCombatRadius";
			this.vmethod_70().Name = "DefaultCombatRadius";
			this.vmethod_70().Visible = false;
			this.vmethod_72().DataPropertyName = "DefaultTimeOnStation";
			this.vmethod_72().HeaderText = "DefaultTimeOnStation";
			this.vmethod_72().Name = "DefaultTimeOnStation";
			this.vmethod_72().Visible = false;
			this.vmethod_74().DataPropertyName = "DefaultMissionProfile";
			this.vmethod_74().HeaderText = "DefaultMissionProfile";
			this.vmethod_74().Name = "DefaultMissionProfile";
			this.vmethod_74().Visible = false;
			this.vmethod_76().DataPropertyName = "AttackAltitude";
			this.vmethod_76().HeaderText = "AttackAltitude";
			this.vmethod_76().Name = "AttackAltitude";
			this.vmethod_76().Visible = false;
			this.vmethod_78().DataPropertyName = "QuickTurnaround";
			this.vmethod_78().HeaderText = "QuickTurnaround";
			this.vmethod_78().Name = "QuickTurnaround";
			this.vmethod_78().Visible = false;
			this.vmethod_80().DataPropertyName = "QuickTurnaround_MaxSorties";
			this.vmethod_80().HeaderText = "QuickTurnaround_MaxSorties";
			this.vmethod_80().Name = "QuickTurnaround_MaxSorties";
			this.vmethod_80().Visible = false;
			this.vmethod_82().DataPropertyName = "QuickTurnaround_AirborneTime";
			this.vmethod_82().HeaderText = "QuickTurnaround_AirborneTime";
			this.vmethod_82().Name = "QuickTurnaround_AirborneTime";
			this.vmethod_82().Visible = false;
			this.vmethod_84().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_84().DataPropertyName = "QuickTurnaround_ReadyTime";
			this.vmethod_84().HeaderText = "QuickTurnaround_ReadyTime";
			this.vmethod_84().Name = "QuickTurnaround_ReadyTime";
			this.vmethod_84().Visible = false;
			this.vmethod_86().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_86().DataPropertyName = "QuickTurnaround_AdditionalTimePenalty";
			this.vmethod_86().HeaderText = "QuickTurnaround_StanddownTime";
			this.vmethod_86().Name = "QuickTurnaround_StanddownTime";
			this.vmethod_86().Visible = false;
			this.vmethod_88().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_88().DataPropertyName = "QuickTurnaround_TimeofDay";
			this.vmethod_88().HeaderText = "QuickTurnaround_TimeofDay";
			this.vmethod_88().Name = "QuickTurnaround_TimeofDay";
			this.vmethod_88().Visible = false;
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_8()
			});
			this.vmethod_6().Location = new Point(0, 0);
			this.vmethod_6().Name = "MenuStrip1";
			this.vmethod_6().Padding = new Padding(3, 2, 0, 2);
			this.vmethod_6().Size = new Size(1094, 24);
			this.vmethod_6().TabIndex = 15;
			this.vmethod_6().Text = "MenuStrip1";
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Name = "CheckHostsMagazinesToolStripMenuItem";
			this.vmethod_8().Size = new Size(138, 20);
			this.vmethod_8().Text = "Check Base Magazines";
			this.vmethod_28().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_28().method_2(true);
			this.vmethod_28().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_28().Location = new Point(655, 459);
			this.vmethod_28().MaximumSize = new Size(400, 40);
			this.vmethod_28().MinimumSize = new Size(400, 40);
			this.vmethod_28().Name = "Label1";
			this.vmethod_28().Size = new Size(400, 40);
			this.vmethod_28().TabIndex = 31;
			this.vmethod_28().Text = "Weapon State";
			this.vmethod_30().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_30().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_30().Controls.Add(this.vmethod_32());
			this.vmethod_30().Controls.Add(this.vmethod_34());
			this.vmethod_30().Controls.Add(this.vmethod_36());
			this.vmethod_30().Location = new Point(3, 348);
			this.vmethod_30().Name = "FlowLayoutPanel1";
			this.vmethod_30().Size = new Size(1088, 31);
			this.vmethod_30().TabIndex = 37;
			this.vmethod_32().Anchor = AnchorStyles.Left;
			this.vmethod_32().Location = new Point(3, 5);
			this.vmethod_32().Name = "CB_QuickTurnaround";
			this.vmethod_32().Size = new Size(148, 17);
			this.vmethod_32().TabIndex = 32;
			this.vmethod_32().Text = "Enable Quick Turnaround";
			this.vmethod_34().Anchor = AnchorStyles.Left;
			this.vmethod_34().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_34().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_34().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_34().Font = new Font("Segoe UI", 7f);
			this.vmethod_34().FormattingEnabled = true;
			this.vmethod_34().Location = new Point(157, 3);
			this.vmethod_34().Name = "Combo_NumberOfSorties";
			this.vmethod_34().Size = new Size(166, 21);
			this.vmethod_34().TabIndex = 33;
			this.vmethod_36().Anchor = AnchorStyles.Left;
			this.vmethod_36().method_2(true);
			this.vmethod_36().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_36().Location = new Point(329, 6);
			this.vmethod_36().Name = "Label_QuickTurnaroundInfo";
			this.vmethod_36().Size = new Size(41, 15);
			this.vmethod_36().TabIndex = 34;
			this.vmethod_36().Text = "Label1";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1094, 564);
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_38());
			base.Controls.Add(this.vmethod_40());
			base.Controls.Add(this.vmethod_6());
			base.KeyPreview = true;
			base.MainMenuStrip = this.vmethod_6();
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ReadyAircraft";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Ready Aircraft";
			((ISupportInitialize)this.vmethod_38()).EndInit();
			((ISupportInitialize)this.vmethod_40()).EndInit();
			this.vmethod_6().ResumeLayout(false);
			this.vmethod_6().PerformLayout();
			this.vmethod_30().ResumeLayout(false);
			this.vmethod_30().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060074B6 RID: 29878 RVA: 0x000489A3 File Offset: 0x00046BA3
		[CompilerGenerated]
		internal Class116 vmethod_0()
		{
			return this.class116_0;
		}

		// Token: 0x060074B7 RID: 29879 RVA: 0x000489AB File Offset: 0x00046BAB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class116 class116_8)
		{
			this.class116_0 = class116_8;
		}

		// Token: 0x060074B8 RID: 29880 RVA: 0x000489B4 File Offset: 0x00046BB4
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_0;
		}

		// Token: 0x060074B9 RID: 29881 RVA: 0x003F16B0 File Offset: 0x003EF8B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control9 control9_5)
		{
			EventHandler value = new EventHandler(this.method_5);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_5;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060074BA RID: 29882 RVA: 0x000489BC File Offset: 0x00046BBC
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_1;
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x003F16F4 File Offset: 0x003EF8F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_5)
		{
			EventHandler value = new EventHandler(this.method_7);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_5;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060074BC RID: 29884 RVA: 0x000489C4 File Offset: 0x00046BC4
		[CompilerGenerated]
		internal Class119 vmethod_6()
		{
			return this.class119_0;
		}

		// Token: 0x060074BD RID: 29885 RVA: 0x000489CC File Offset: 0x00046BCC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class119 class119_1)
		{
			this.class119_0 = class119_1;
		}

		// Token: 0x060074BE RID: 29886 RVA: 0x000489D5 File Offset: 0x00046BD5
		[CompilerGenerated]
		internal Class128 vmethod_8()
		{
			return this.class128_0;
		}

		// Token: 0x060074BF RID: 29887 RVA: 0x003F1738 File Offset: 0x003EF938
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class128 class128_1)
		{
			EventHandler value = new EventHandler(this.method_9);
			Class128 @class = this.class128_0;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_0 = class128_1;
			@class = this.class128_0;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060074C0 RID: 29888 RVA: 0x000489DD File Offset: 0x00046BDD
		[CompilerGenerated]
		internal Control9 vmethod_10()
		{
			return this.control9_2;
		}

		// Token: 0x060074C1 RID: 29889 RVA: 0x003F177C File Offset: 0x003EF97C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control9 control9_5)
		{
			EventHandler value = new EventHandler(this.method_11);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_5;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060074C2 RID: 29890 RVA: 0x000489E5 File Offset: 0x00046BE5
		[CompilerGenerated]
		internal Class116 vmethod_12()
		{
			return this.class116_1;
		}

		// Token: 0x060074C3 RID: 29891 RVA: 0x000489ED File Offset: 0x00046BED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class116 class116_8)
		{
			this.class116_1 = class116_8;
		}

		// Token: 0x060074C4 RID: 29892 RVA: 0x000489F6 File Offset: 0x00046BF6
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_2;
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x000489FE File Offset: 0x00046BFE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_8)
		{
			this.class116_2 = class116_8;
		}

		// Token: 0x060074C6 RID: 29894 RVA: 0x00048A07 File Offset: 0x00046C07
		[CompilerGenerated]
		internal Class116 vmethod_16()
		{
			return this.class116_3;
		}

		// Token: 0x060074C7 RID: 29895 RVA: 0x00048A0F File Offset: 0x00046C0F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class116 class116_8)
		{
			this.class116_3 = class116_8;
		}

		// Token: 0x060074C8 RID: 29896 RVA: 0x00048A18 File Offset: 0x00046C18
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_4;
		}

		// Token: 0x060074C9 RID: 29897 RVA: 0x00048A20 File Offset: 0x00046C20
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_8)
		{
			this.class116_4 = class116_8;
		}

		// Token: 0x060074CA RID: 29898 RVA: 0x00048A29 File Offset: 0x00046C29
		[CompilerGenerated]
		internal Class116 vmethod_20()
		{
			return this.class116_5;
		}

		// Token: 0x060074CB RID: 29899 RVA: 0x00048A31 File Offset: 0x00046C31
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class116 class116_8)
		{
			this.class116_5 = class116_8;
		}

		// Token: 0x060074CC RID: 29900 RVA: 0x00048A3A File Offset: 0x00046C3A
		[CompilerGenerated]
		internal Control9 vmethod_22()
		{
			return this.control9_3;
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x003F17C0 File Offset: 0x003EF9C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Control9 control9_5)
		{
			EventHandler value = new EventHandler(this.method_12);
			Control9 control = this.control9_3;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_3 = control9_5;
			control = this.control9_3;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060074CE RID: 29902 RVA: 0x00048A42 File Offset: 0x00046C42
		[CompilerGenerated]
		internal Control9 vmethod_24()
		{
			return this.control9_4;
		}

		// Token: 0x060074CF RID: 29903 RVA: 0x003F1804 File Offset: 0x003EFA04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Control9 control9_5)
		{
			EventHandler value = new EventHandler(this.method_6);
			Control9 control = this.control9_4;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_4 = control9_5;
			control = this.control9_4;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x060074D0 RID: 29904 RVA: 0x00048A4A File Offset: 0x00046C4A
		[CompilerGenerated]
		internal Class112 vmethod_26()
		{
			return this.class112_0;
		}

		// Token: 0x060074D1 RID: 29905 RVA: 0x003F1848 File Offset: 0x003EFA48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class112 class112_2)
		{
			EventHandler value = new EventHandler(this.method_23);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_0 = class112_2;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060074D2 RID: 29906 RVA: 0x00048A52 File Offset: 0x00046C52
		[CompilerGenerated]
		internal Class116 vmethod_28()
		{
			return this.class116_6;
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x00048A5A File Offset: 0x00046C5A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Class116 class116_8)
		{
			this.class116_6 = class116_8;
		}

		// Token: 0x060074D4 RID: 29908 RVA: 0x00048A63 File Offset: 0x00046C63
		[CompilerGenerated]
		internal FlowLayoutPanel vmethod_30()
		{
			return this.flowLayoutPanel_0;
		}

		// Token: 0x060074D5 RID: 29909 RVA: 0x00048A6B File Offset: 0x00046C6B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(FlowLayoutPanel flowLayoutPanel_1)
		{
			this.flowLayoutPanel_0 = flowLayoutPanel_1;
		}

		// Token: 0x060074D6 RID: 29910 RVA: 0x00048A74 File Offset: 0x00046C74
		[CompilerGenerated]
		internal Class112 vmethod_32()
		{
			return this.class112_1;
		}

		// Token: 0x060074D7 RID: 29911 RVA: 0x003F188C File Offset: 0x003EFA8C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Class112 class112_2)
		{
			EventHandler value = new EventHandler(this.method_21);
			Class112 @class = this.class112_1;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_1 = class112_2;
			@class = this.class112_1;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060074D8 RID: 29912 RVA: 0x00048A7C File Offset: 0x00046C7C
		[CompilerGenerated]
		internal Class2451 vmethod_34()
		{
			return this.class2451_0;
		}

		// Token: 0x060074D9 RID: 29913 RVA: 0x003F18D0 File Offset: 0x003EFAD0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Class2451 class2451_1)
		{
			EventHandler value = new EventHandler(this.method_18);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectedIndexChanged -= value;
			}
			this.class2451_0 = class2451_1;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectedIndexChanged += value;
			}
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x00048A84 File Offset: 0x00046C84
		[CompilerGenerated]
		internal Class116 vmethod_36()
		{
			return this.class116_7;
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x00048A8C File Offset: 0x00046C8C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Class116 class116_8)
		{
			this.class116_7 = class116_8;
		}

		// Token: 0x060074DC RID: 29916 RVA: 0x00048A95 File Offset: 0x00046C95
		[CompilerGenerated]
		internal Class114 vmethod_38()
		{
			return this.class114_0;
		}

		// Token: 0x060074DD RID: 29917 RVA: 0x003F1914 File Offset: 0x003EFB14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Class114 class114_2)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_16);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.CellContentClick -= value;
			}
			this.class114_0 = class114_2;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.CellContentClick += value;
			}
		}

		// Token: 0x060074DE RID: 29918 RVA: 0x00048A9D File Offset: 0x00046C9D
		[CompilerGenerated]
		internal Class114 vmethod_40()
		{
			return this.class114_1;
		}

		// Token: 0x060074DF RID: 29919 RVA: 0x003F1958 File Offset: 0x003EFB58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Class114 class114_2)
		{
			DataGridViewCellMouseEventHandler value = new DataGridViewCellMouseEventHandler(this.method_13);
			EventHandler value2 = new EventHandler(this.method_14);
			DataGridViewCellFormattingEventHandler value3 = new DataGridViewCellFormattingEventHandler(this.method_17);
			Class114 @class = this.class114_1;
			if (@class != null)
			{
				@class.CellMouseDoubleClick -= value;
				@class.SelectionChanged -= value2;
				@class.CellFormatting -= value3;
			}
			this.class114_1 = class114_2;
			@class = this.class114_1;
			if (@class != null)
			{
				@class.CellMouseDoubleClick += value;
				@class.SelectionChanged += value2;
				@class.CellFormatting += value3;
			}
		}

		// Token: 0x060074E0 RID: 29920 RVA: 0x00048AA5 File Offset: 0x00046CA5
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_42()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x060074E1 RID: 29921 RVA: 0x00048AAD File Offset: 0x00046CAD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060074E2 RID: 29922 RVA: 0x00048AB6 File Offset: 0x00046CB6
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_44()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x060074E3 RID: 29923 RVA: 0x00048ABE File Offset: 0x00046CBE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060074E4 RID: 29924 RVA: 0x00048AC7 File Offset: 0x00046CC7
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_46()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060074E5 RID: 29925 RVA: 0x00048ACF File Offset: 0x00046CCF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060074E6 RID: 29926 RVA: 0x00048AD8 File Offset: 0x00046CD8
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_48()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x060074E7 RID: 29927 RVA: 0x00048AE0 File Offset: 0x00046CE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060074E8 RID: 29928 RVA: 0x00048AE9 File Offset: 0x00046CE9
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_50()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x060074E9 RID: 29929 RVA: 0x00048AF1 File Offset: 0x00046CF1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060074EA RID: 29930 RVA: 0x00048AFA File Offset: 0x00046CFA
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_52()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x060074EB RID: 29931 RVA: 0x00048B02 File Offset: 0x00046D02
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060074EC RID: 29932 RVA: 0x00048B0B File Offset: 0x00046D0B
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_54()
		{
			return this.dataGridViewTextBoxColumn_6;
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x00048B13 File Offset: 0x00046D13
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060074EE RID: 29934 RVA: 0x00048B1C File Offset: 0x00046D1C
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_56()
		{
			return this.dataGridViewTextBoxColumn_7;
		}

		// Token: 0x060074EF RID: 29935 RVA: 0x00048B24 File Offset: 0x00046D24
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_7 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060074F0 RID: 29936 RVA: 0x00048B2D File Offset: 0x00046D2D
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_58()
		{
			return this.dataGridViewTextBoxColumn_8;
		}

		// Token: 0x060074F1 RID: 29937 RVA: 0x00048B35 File Offset: 0x00046D35
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_8 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060074F2 RID: 29938 RVA: 0x00048B3E File Offset: 0x00046D3E
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_60()
		{
			return this.dataGridViewTextBoxColumn_9;
		}

		// Token: 0x060074F3 RID: 29939 RVA: 0x00048B46 File Offset: 0x00046D46
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_9 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060074F4 RID: 29940 RVA: 0x00048B4F File Offset: 0x00046D4F
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_62()
		{
			return this.dataGridViewTextBoxColumn_10;
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x00048B57 File Offset: 0x00046D57
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_10 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060074F6 RID: 29942 RVA: 0x00048B60 File Offset: 0x00046D60
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_64()
		{
			return this.dataGridViewTextBoxColumn_11;
		}

		// Token: 0x060074F7 RID: 29943 RVA: 0x00048B68 File Offset: 0x00046D68
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_11 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060074F8 RID: 29944 RVA: 0x00048B71 File Offset: 0x00046D71
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_66()
		{
			return this.dataGridViewTextBoxColumn_12;
		}

		// Token: 0x060074F9 RID: 29945 RVA: 0x00048B79 File Offset: 0x00046D79
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_12 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060074FA RID: 29946 RVA: 0x00048B82 File Offset: 0x00046D82
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_68()
		{
			return this.dataGridViewTextBoxColumn_13;
		}

		// Token: 0x060074FB RID: 29947 RVA: 0x00048B8A File Offset: 0x00046D8A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_13 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060074FC RID: 29948 RVA: 0x00048B93 File Offset: 0x00046D93
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_70()
		{
			return this.dataGridViewTextBoxColumn_14;
		}

		// Token: 0x060074FD RID: 29949 RVA: 0x00048B9B File Offset: 0x00046D9B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_14 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x060074FE RID: 29950 RVA: 0x00048BA4 File Offset: 0x00046DA4
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_72()
		{
			return this.dataGridViewTextBoxColumn_15;
		}

		// Token: 0x060074FF RID: 29951 RVA: 0x00048BAC File Offset: 0x00046DAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_15 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06007500 RID: 29952 RVA: 0x00048BB5 File Offset: 0x00046DB5
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_74()
		{
			return this.dataGridViewTextBoxColumn_16;
		}

		// Token: 0x06007501 RID: 29953 RVA: 0x00048BBD File Offset: 0x00046DBD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_16 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06007502 RID: 29954 RVA: 0x00048BC6 File Offset: 0x00046DC6
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_76()
		{
			return this.dataGridViewTextBoxColumn_17;
		}

		// Token: 0x06007503 RID: 29955 RVA: 0x00048BCE File Offset: 0x00046DCE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_17 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06007504 RID: 29956 RVA: 0x00048BD7 File Offset: 0x00046DD7
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_78()
		{
			return this.dataGridViewTextBoxColumn_18;
		}

		// Token: 0x06007505 RID: 29957 RVA: 0x00048BDF File Offset: 0x00046DDF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_18 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06007506 RID: 29958 RVA: 0x00048BE8 File Offset: 0x00046DE8
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_80()
		{
			return this.dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06007507 RID: 29959 RVA: 0x00048BF0 File Offset: 0x00046DF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_19 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06007508 RID: 29960 RVA: 0x00048BF9 File Offset: 0x00046DF9
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_82()
		{
			return this.dataGridViewTextBoxColumn_20;
		}

		// Token: 0x06007509 RID: 29961 RVA: 0x00048C01 File Offset: 0x00046E01
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_20 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x0600750A RID: 29962 RVA: 0x00048C0A File Offset: 0x00046E0A
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_84()
		{
			return this.dataGridViewTextBoxColumn_21;
		}

		// Token: 0x0600750B RID: 29963 RVA: 0x00048C12 File Offset: 0x00046E12
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_21 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x0600750C RID: 29964 RVA: 0x00048C1B File Offset: 0x00046E1B
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_86()
		{
			return this.dataGridViewTextBoxColumn_22;
		}

		// Token: 0x0600750D RID: 29965 RVA: 0x00048C23 File Offset: 0x00046E23
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_22 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x0600750E RID: 29966 RVA: 0x00048C2C File Offset: 0x00046E2C
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_88()
		{
			return this.dataGridViewTextBoxColumn_23;
		}

		// Token: 0x0600750F RID: 29967 RVA: 0x00048C34 File Offset: 0x00046E34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_23 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06007510 RID: 29968 RVA: 0x00048C3D File Offset: 0x00046E3D
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_90()
		{
			return this.dataGridViewTextBoxColumn_24;
		}

		// Token: 0x06007511 RID: 29969 RVA: 0x00048C45 File Offset: 0x00046E45
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_24 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06007512 RID: 29970 RVA: 0x00048C4E File Offset: 0x00046E4E
		[CompilerGenerated]
		internal DataGridViewLinkColumn vmethod_92()
		{
			return this.dataGridViewLinkColumn_0;
		}

		// Token: 0x06007513 RID: 29971 RVA: 0x00048C56 File Offset: 0x00046E56
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(DataGridViewLinkColumn dataGridViewLinkColumn_1)
		{
			this.dataGridViewLinkColumn_0 = dataGridViewLinkColumn_1;
		}

		// Token: 0x06007514 RID: 29972 RVA: 0x00048C5F File Offset: 0x00046E5F
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_94()
		{
			return this.dataGridViewTextBoxColumn_25;
		}

		// Token: 0x06007515 RID: 29973 RVA: 0x00048C67 File Offset: 0x00046E67
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_25 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06007516 RID: 29974 RVA: 0x00048C70 File Offset: 0x00046E70
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_96()
		{
			return this.dataGridViewTextBoxColumn_26;
		}

		// Token: 0x06007517 RID: 29975 RVA: 0x00048C78 File Offset: 0x00046E78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_97(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27)
		{
			this.dataGridViewTextBoxColumn_26 = dataGridViewTextBoxColumn_27;
		}

		// Token: 0x06007518 RID: 29976 RVA: 0x00044820 File Offset: 0x00042A20
		private void ReadyAircraft_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06007519 RID: 29977 RVA: 0x003F19D4 File Offset: 0x003EFBD4
		private void ReadyAircraft_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_10().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			this.vmethod_22().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			if (Class570.class280_0.method_26())
			{
				this.vmethod_26().Checked = true;
			}
			else
			{
				this.vmethod_26().Checked = false;
			}
			this.method_3();
			string text;
			string text2;
			if (this.list_0.Count > 0)
			{
				text = Misc.smethod_9(this.list_0[0].string_2);
				text2 = this.list_0[0].method_164().method_30().Name;
			}
			else if (!Information.IsNothing(this.list_1) && this.list_1.Count > 0)
			{
				text = this.list_1[0].string_0;
				text2 = this.list_1[0].string_4;
			}
			else
			{
				text = "<No Unit Selected>";
				text2 = "<No Host Unit Selected>";
			}
			int num = this.list_0.Count;
			if (!Information.IsNothing(this.list_1))
			{
				num += this.list_1.Count;
			}
			this.Text = string.Concat(new string[]
			{
				"Ready Aircraft: ",
				Conversions.ToString(num),
				"x ",
				text,
				" at ",
				text2
			});
		}

		// Token: 0x0600751A RID: 29978 RVA: 0x003F1B44 File Offset: 0x003EFD44
		private void method_3()
		{
			List<Aircraft> selectedAircraft = this.list_0;
			SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
			bool flag = Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2);
			this.dictionary_0 = DBFunctions.smethod_40(selectedAircraft, ref sqliteConnection, ref flag);
			if (this.list_0.Count > 0)
			{
				int dbid = this.list_0[0].DBID;
				Dictionary<int, int> selectedAircraftTotalWeaponQty = this.dictionary_0;
				sqliteConnection = Client.smethod_46().method_39();
				Scenario theScen = Client.smethod_46();
				flag = Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2);
				Scenario scenario = Client.smethod_46();
				List<Aircraft> list;
				Aircraft value = (list = this.list_0)[0];
				int num = 0;
				bool flag2 = false;
				DataTable dataTable = DBFunctions.smethod_42(dbid, selectedAircraftTotalWeaponQty, ref sqliteConnection, theScen, ref flag, ref scenario, ref value, ref num, ref flag2);
				list[0] = value;
				this.dataTable_1 = dataTable;
			}
			else
			{
				if (Information.IsNothing(this.list_1) || this.list_1.Count <= 0)
				{
					return;
				}
				Scenario scenario = Client.smethod_46();
				Aircraft aircraft = new Aircraft(ref scenario, null);
				aircraft.method_164().method_31(this.list_1[0].method_3(Client.smethod_46()));
				int aircraftID = this.list_1[0].int_0;
				Dictionary<int, int> selectedAircraftTotalWeaponQty2 = this.dictionary_0;
				sqliteConnection = Client.smethod_46().method_39();
				Scenario theScen2 = Client.smethod_46();
				bool flag2 = Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2);
				scenario = Client.smethod_46();
				int num = 0;
				flag = false;
				this.dataTable_1 = DBFunctions.smethod_42(aircraftID, selectedAircraftTotalWeaponQty2, ref sqliteConnection, theScen2, ref flag2, ref scenario, ref aircraft, ref num, ref flag);
			}
			DataView dataView = new DataView(this.dataTable_1);
			if (this.vmethod_26().Checked)
			{
				dataView.RowFilter = "NOT NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly = '0'";
			}
			this.vmethod_40().DataSource = dataView;
			if (this.int_0 == 0)
			{
				this.int_0 = Conversions.ToInteger(this.vmethod_40().Rows[0].Cells["ID"].Value);
			}
			this.method_8(this.dictionary_0);
			try
			{
				foreach (Aircraft aircraft2 in this.list_0)
				{
					if (!Information.IsNothing(aircraft2.method_167()) && !this.hashSet_0.Contains(aircraft2.method_166()))
					{
						this.hashSet_0.Add(aircraft2.method_166());
					}
				}
			}
			finally
			{
				List<Aircraft>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (!Information.IsNothing(this.list_1))
			{
				try
				{
					foreach (Mission.EmptyAircraftSlot emptyAircraftSlot in this.list_1)
					{
						if (emptyAircraftSlot.int_1 != 0 && !this.hashSet_0.Contains(emptyAircraftSlot.int_1))
						{
							this.hashSet_0.Add(emptyAircraftSlot.int_1);
						}
					}
				}
				finally
				{
					List<Mission.EmptyAircraftSlot>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
			if (this.hashSet_0.Count != 1)
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.vmethod_40().Rows))
					{
						((DataGridViewRow)obj).Selected = false;
					}
					return;
				}
				finally
				{
					IEnumerator enumerator3;
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
			}
			int num2 = Enumerable.ElementAtOrDefault<int>(this.hashSet_0, 0);
			try
			{
				foreach (object obj2 in ((IEnumerable)this.vmethod_40().Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
					if (Conversions.ToInteger(dataGridViewRow.Cells["ID"].Value) == num2)
					{
						dataGridViewRow.Selected = true;
						break;
					}
					dataGridViewRow.Selected = false;
				}
			}
			finally
			{
				IEnumerator enumerator4;
				if (enumerator4 is IDisposable)
				{
					(enumerator4 as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x0600751B RID: 29979 RVA: 0x003F1F14 File Offset: 0x003F0114
		private int method_4(int int_5, Dictionary<int, int> dictionary_1, bool bool_5)
		{
			int result;
			try
			{
				if (Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2))
				{
					result = int.MaxValue;
				}
				else
				{
					int num = 9999999;
					DataTable dataTable = new DataTable();
					SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
					dataTable = DBFunctions.smethod_44(int_5, ref sqliteConnection, ref bool_5);
					ActiveUnit activeUnit;
					if (this.list_0.Count > 0)
					{
						if (Information.IsNothing(this.list_0[0]))
						{
							return 0;
						}
						activeUnit = this.list_0[0].method_164().method_30();
					}
					else if (!Information.IsNothing(this.list_1) && this.list_1.Count > 0)
					{
						activeUnit = this.list_1[0].method_3(Client.smethod_46());
					}
					if (Information.IsNothing(activeUnit))
					{
						result = 0;
					}
					else
					{
						try
						{
							foreach (object obj in dataTable.Rows)
							{
								DataRow dataRow = (DataRow)obj;
								if (!bool_5 || !Conversions.ToBoolean(dataRow["Optional"]))
								{
									int num2 = Conversions.ToInteger(dataRow["ComponentID"]);
									int num3 = Conversions.ToInteger(dataRow["Quantity"]);
									if (num3 == 0)
									{
										return 0;
									}
									int int_6 = num2;
									Scenario scenario = Client.smethod_46();
									if (!Weapon.smethod_17(int_6, ref scenario))
									{
										int num4 = activeUnit.vmethod_89().vmethod_8(num2);
										int num5 = 0;
										if (!Information.IsNothing(dictionary_1) && dictionary_1.ContainsKey(num2))
										{
											num5 = dictionary_1[num2];
										}
										int num6 = (num4 + num5) / num3;
										if (num6 < num)
										{
											num = num6;
										}
									}
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
						result = num;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101137", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x0600751C RID: 29980 RVA: 0x00048C81 File Offset: 0x00046E81
		private void method_5(object sender, EventArgs e)
		{
			this.method_10(false, true, false, !Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2));
		}

		// Token: 0x0600751D RID: 29981 RVA: 0x00048C9F File Offset: 0x00046E9F
		private void method_6(object sender, EventArgs e)
		{
			this.method_10(false, true, true, !Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2));
		}

		// Token: 0x0600751E RID: 29982 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_7(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600751F RID: 29983 RVA: 0x003F212C File Offset: 0x003F032C
		private void method_8(Dictionary<int, int> dictionary_1)
		{
			try
			{
				if (Conversions.ToInteger(Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_1.AsEnumerable(), 0)["ID"]) > 4)
				{
					DataRow[] array = this.dataTable_1.Select("ID = " + Conversions.ToString(this.int_0));
					if (Enumerable.Count<DataRow>(array) > 0)
					{
						this.vmethod_12().Text = Conversions.ToString(array[0]["LoadoutRoleDescription"]);
						this.vmethod_28().Text = "Loadout's default weapon state " + Conversions.ToString(array[0]["WinchesterShotgunDescription"]);
						this.vmethod_14().Text = "Default Attack Altitude: " + Conversions.ToString(array[0]["AttackAltitude"]);
						this.vmethod_16().Text = "Loadouts available in magazines: " + Conversions.ToString(array[0]["NumberOfLoadouts"]);
						this.vmethod_18().Text = "Loadouts available, including weapons mounted on currently selected aircraft: " + Conversions.ToString(array[0]["NumberOfLoadoutsIncludingMountedWeapons"]);
						this.vmethod_20().Text = "Loadouts available, same as above but with mandatory (i.e. excluding optional) weapons only: " + Conversions.ToString(array[0]["NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly"]);
					}
					int num = this.int_0;
					SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
					bool flag = false;
					this.dataTable_0 = DBFunctions.smethod_44(num, ref sqliteConnection, ref flag);
					this.dataTable_0.Columns.Add("Available");
					this.dataTable_0.Columns.Add("AvailableTotal");
					try
					{
						foreach (object obj in this.dataTable_0.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							int num2 = Conversions.ToInteger(dataRow["ComponentID"]);
							int int_ = num2;
							Scenario scenario = Client.smethod_46();
							if (Weapon.smethod_17(int_, ref scenario))
							{
								dataRow["Available"] = "-";
								dataRow["AvailableTotal"] = "-";
							}
							else if (!Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2))
							{
								ActiveUnit activeUnit;
								if (this.list_0.Count > 0)
								{
									if (!Information.IsNothing(this.list_0[0]))
									{
										activeUnit = this.list_0[0].method_164().method_30();
									}
								}
								else if (!Information.IsNothing(this.list_1) && this.list_1.Count > 0)
								{
									activeUnit = this.list_1[0].method_3(Client.smethod_46());
								}
								int num3;
								if (!Information.IsNothing(activeUnit))
								{
									num3 = activeUnit.vmethod_89().vmethod_8(Conversions.ToInteger(dataRow["ComponentID"]));
								}
								else
								{
									num3 = 0;
								}
								int num4 = 0;
								if (!Information.IsNothing(dictionary_1) && dictionary_1.ContainsKey(num2))
								{
									num4 = dictionary_1[num2];
								}
								dataRow["Available"] = num3;
								dataRow["AvailableTotal"] = num3 + num4;
							}
							else
							{
								dataRow["Available"] = "Unlimited";
								dataRow["AvailableTotal"] = "Unlimited";
							}
							dataRow["Item"] = Misc.smethod_9(Conversions.ToString(dataRow["Item"]));
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
					this.vmethod_38().AutoGenerateColumns = false;
					this.vmethod_38().DataSource = this.dataTable_0;
				}
				else
				{
					this.vmethod_12().Text = "";
					this.vmethod_14().Text = "";
					this.vmethod_28().Text = "";
					this.vmethod_16().Text = "";
					this.vmethod_18().Text = "";
					this.vmethod_20().Text = "";
					this.dataTable_0.Rows.Clear();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101138", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06007520 RID: 29984 RVA: 0x003F2588 File Offset: 0x003F0788
		private void method_9(object sender, EventArgs e)
		{
			if (this.list_0[0].method_164().method_30().vmethod_117().Length > 0)
			{
				Client.magazines_0 = new Magazines();
				Client.magazines_0.activeUnit_0 = this.list_0[0].method_164().method_30();
				Client.magazines_0.Show();
				return;
			}
			DarkMessageBox.smethod_2("The current host for these aircraft has no magazines available.", "No mags!", Enum11.const_0);
		}

		// Token: 0x06007521 RID: 29985 RVA: 0x003F25FC File Offset: 0x003F07FC
		private void method_10(bool bool_5, bool bool_6, bool bool_7, bool bool_8)
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				if (this.list_0.Count > 0)
				{
					try
					{
						foreach (Aircraft aircraft in this.list_0)
						{
							if (!Information.IsNothing(aircraft.method_167()) && bool_8)
							{
								aircraft.method_164().method_67();
							}
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				bool flag;
				try
				{
					foreach (Aircraft aircraft2 in this.list_0)
					{
						Aircraft_AirOps aircraft_AirOps = aircraft2.method_164();
						bool flag2;
						if (aircraft_AirOps.bool_0 && !this.vmethod_32().Checked && !flag)
						{
							if (aircraft_AirOps.int_1 > 0)
							{
								DialogResult dialogResult = DarkMessageBox.smethod_1("Aircraft " + aircraft2.Name + " had Quick Turnaround enabled previously, but disabled on the selected loadout. Do you want to keep the new configuration and stand down?", "Disable Quick Turnaround and Stand Down?", Enum11.const_4);
								if (dialogResult == DialogResult.Yes)
								{
									aircraft_AirOps.bool_0 = false;
									aircraft_AirOps.method_51(ref aircraft_AirOps, ref aircraft2);
								}
								else if (dialogResult == DialogResult.No)
								{
									flag2 = true;
								}
								else
								{
									flag = true;
								}
							}
							else
							{
								aircraft_AirOps.method_53(ref aircraft_AirOps);
							}
						}
						bool flag3;
						if (aircraft_AirOps.bool_0 && !flag)
						{
							Loadout loadout = DBFunctions.smethod_47(ref aircraft2.scenario_0, this.int_0, false, false);
							if (aircraft_AirOps.int_1 >= loadout.int_10 && loadout.bool_13)
							{
								DialogResult dialogResult2 = DarkMessageBox.smethod_1("Aircraft " + aircraft2.Name + " has flown more Quick Turnaround sorties than the selected loadout allows. Do you want to switch to the new loadout and stand down?", "Stand Down?", Enum11.const_4);
								if (dialogResult2 == DialogResult.Yes)
								{
									aircraft_AirOps.method_51(ref aircraft_AirOps, ref aircraft2);
									flag2 = false;
								}
								else if (dialogResult2 == DialogResult.No)
								{
									flag3 = true;
								}
								else
								{
									flag = true;
								}
							}
							else if (!loadout.bool_13)
							{
								aircraft_AirOps.method_53(ref aircraft_AirOps);
							}
							if (!flag && aircraft_AirOps.int_1 > 0)
							{
								float num = aircraft_AirOps.float_1 / (float)aircraft_AirOps.int_1;
								if ((double)num > (double)(aircraft2.method_167().int_12 * 60) / (double)(this.vmethod_34().SelectedIndex + 2) && !flag)
								{
									bool flag4;
									if (aircraft_AirOps.int_1 <= this.vmethod_34().SelectedIndex + 2 - 2)
									{
										if (num + aircraft_AirOps.float_1 >= (float)(aircraft2.method_167().int_12 * 60))
										{
											flag4 = true;
										}
									}
									else
									{
										flag4 = true;
									}
									if (flag4)
									{
										DialogResult dialogResult3 = DarkMessageBox.smethod_1(string.Concat(new string[]
										{
											"Aircraft ",
											aircraft2.Name,
											" has flown ",
											Conversions.ToString(aircraft_AirOps.int_1),
											" of ",
											Conversions.ToString(loadout.int_10),
											" quick turnaround sorties. Total airborne time is ",
											Misc.smethod_11((long)Math.Round((double)aircraft_AirOps.float_1), Aircraft_AirOps.Enum44.const_0, false, false),
											" of allowed ",
											Misc.smethod_11((long)(aircraft2.method_167().int_12 * 60), Aircraft_AirOps.Enum44.const_0, false, false),
											". Average airborne time for the completed sorties is ",
											Misc.smethod_11((long)Math.Round((double)num), Aircraft_AirOps.Enum44.const_0, false, false),
											" which is greater than the remaining allowed airborne time. Because of this the aircraft needs to stand down. Do you want to switch to the new loadout and stand down?"
										}), "Stand Down?", Enum11.const_4);
										if (dialogResult3 == DialogResult.Yes)
										{
											aircraft_AirOps.method_51(ref aircraft_AirOps, ref aircraft2);
											flag2 = false;
										}
										else if (dialogResult3 == DialogResult.No)
										{
											flag3 = true;
										}
										else
										{
											flag = true;
										}
									}
								}
							}
						}
						int num2;
						if (!Information.IsNothing(aircraft2.method_167()))
						{
							num2 = aircraft2.method_167().DBID;
						}
						else
						{
							num2 = 0;
						}
						aircraft2.method_168(null);
						aircraft2.method_161().vmethod_3();
						ActiveUnit activeUnit = aircraft_AirOps.method_30();
						if (!flag3 && !flag)
						{
							activeUnit.vmethod_92().method_16(ref aircraft2, this.int_0, num2, bool_5, bool_7, bool_8, bool_6, true);
						}
						else
						{
							activeUnit.vmethod_92().method_16(ref aircraft2, num2, num2, bool_5, bool_7, bool_8, bool_6, true);
						}
						activeUnit.vmethod_92().method_14(ref aircraft2);
						activeUnit.vmethod_92().method_13(ref aircraft2);
						if (bool_5)
						{
							AirFacility airFacility_ = activeUnit.vmethod_92().method_19(aircraft2);
							aircraft_AirOps.method_35(airFacility_);
							if (aircraft_AirOps.method_36() == Aircraft_AirOps._AirOpsCondition.Readying)
							{
								aircraft_AirOps.method_37(Aircraft_AirOps._AirOpsCondition.Parked);
							}
						}
						if (this.vmethod_32().CheckState != CheckState.Indeterminate)
						{
							if (!flag2 && !flag)
							{
								aircraft_AirOps.bool_0 = this.vmethod_32().Checked;
							}
							if (!Information.IsNothing(this.nullable_0))
							{
								if (this.vmethod_34().SelectedIndex >= 0 && this.vmethod_34().SelectedIndex + 2 <= aircraft2.method_167().int_10)
								{
									aircraft_AirOps.int_2 = this.vmethod_34().SelectedIndex + 2;
								}
								else
								{
									this.nullable_0 = null;
								}
							}
							else if (!flag2 && !flag && !this.vmethod_32().Checked)
							{
								aircraft_AirOps.int_2 = 0;
							}
						}
						if (!Information.IsNothing(aircraft2.vmethod_101()))
						{
							aircraft2.vmethod_101().int_0 = 0;
						}
					}
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				if (!Information.IsNothing(this.list_1))
				{
					try
					{
						foreach (Mission.EmptyAircraftSlot emptyAircraftSlot in this.list_1)
						{
							emptyAircraftSlot.int_1 = this.int_0;
							emptyAircraftSlot.bool_0 = bool_7;
							if (!flag)
							{
								emptyAircraftSlot.bool_1 = this.vmethod_32().Checked;
							}
							if (!Information.IsNothing(this.nullable_0))
							{
								if (this.vmethod_34().SelectedIndex >= 0 && this.vmethod_34().SelectedIndex + 2 <= emptyAircraftSlot.int_3)
								{
									emptyAircraftSlot.int_2 = this.vmethod_34().SelectedIndex + 2;
								}
								else
								{
									this.nullable_0 = null;
								}
							}
							else if (!flag && !this.vmethod_32().Checked)
							{
								emptyAircraftSlot.int_2 = 0;
							}
							Scenario scenario = Client.smethod_46();
							Loadout loadout2 = DBFunctions.smethod_47(ref scenario, this.int_0, false, false);
							emptyAircraftSlot.string_1 = loadout2.Name;
							emptyAircraftSlot.int_3 = loadout2.int_10;
						}
					}
					finally
					{
						List<Mission.EmptyAircraftSlot>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				if (Class2413.smethod_2().method_7().Visible)
				{
					Class2413.smethod_2().method_7().imethod_0();
				}
				if (!Information.IsNothing(Client.smethod_30()) && Client.smethod_30().Visible)
				{
					Client.smethod_30().method_3();
				}
				this.Cursor = Cursors.Default;
				if (!flag)
				{
					base.Close();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101139", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06007522 RID: 29986 RVA: 0x00048CBD File Offset: 0x00046EBD
		private void method_11(object sender, EventArgs e)
		{
			this.method_10(true, true, false, !Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2));
		}

		// Token: 0x06007523 RID: 29987 RVA: 0x00048CDB File Offset: 0x00046EDB
		private void method_12(object sender, EventArgs e)
		{
			this.method_10(true, true, false, false);
		}

		// Token: 0x06007524 RID: 29988 RVA: 0x003F2CCC File Offset: 0x003F0ECC
		private void method_13(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				this.int_0 = Conversions.ToInteger(this.vmethod_40().Rows[e.RowIndex].Cells["ID"].Value);
				if (this.method_4(this.int_0, this.dictionary_0, false) > 0)
				{
					this.method_10(false, true, false, !Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2));
				}
			}
		}

		// Token: 0x06007525 RID: 29989 RVA: 0x003F2D4C File Offset: 0x003F0F4C
		private void method_14(object sender, EventArgs e)
		{
			if (this.vmethod_40().SelectedRows.Count != 0)
			{
				this.int_0 = Conversions.ToInteger(this.vmethod_40().SelectedRows[0].Cells["ID"].Value);
				if (!Information.IsNothing(this.list_1) && this.list_1.Count > 0)
				{
					this.vmethod_2().Enabled = true;
					this.vmethod_24().Enabled = true;
					this.vmethod_10().Enabled = false;
					this.vmethod_22().Enabled = false;
				}
				else
				{
					this.vmethod_2().Enabled = (this.method_4(this.int_0, this.dictionary_0, false) > 0);
					this.vmethod_24().Enabled = (this.method_4(this.int_0, this.dictionary_0, true) > 0);
					this.vmethod_10().Enabled = this.vmethod_2().Enabled;
					this.vmethod_22().Enabled = true;
				}
				this.method_8(this.dictionary_0);
				this.method_15();
			}
		}

		// Token: 0x06007526 RID: 29990 RVA: 0x003F2E64 File Offset: 0x003F1064
		private void method_15()
		{
			bool flag = true;
			int num = 0;
			int num2 = 0;
			Aircraft aircraft;
			if (!Information.IsNothing(this.list_0) && this.list_0.Count > 0)
			{
				aircraft = this.list_0[0];
			}
			DataRow[] array;
			bool? flag2;
			if (!Information.IsNothing(aircraft) && !Information.IsNothing(aircraft.method_167()) && this.hashSet_0.Count == 1 && Enumerable.ElementAtOrDefault<int>(this.hashSet_0, 0) == this.int_0)
			{
				array = this.dataTable_1.Select("ID = " + Conversions.ToString(Enumerable.ElementAtOrDefault<int>(this.hashSet_0, 0)));
				if (Enumerable.Count<DataRow>(array) > 0)
				{
					Doctrine.Enum54? @enum = aircraft.doctrine_0.method_201(aircraft.scenario_0, false, false, false, false);
					byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						this.string_0 = Misc.smethod_11((long)(aircraft.method_167().int_3 * 60), Aircraft_AirOps.Enum44.const_0, false, false);
					}
					else
					{
						this.string_0 = Misc.smethod_11((long)(aircraft.method_167().int_2 * 60), Aircraft_AirOps.Enum44.const_0, false, false);
					}
					this.bool_3 = aircraft.method_167().bool_13;
					this.int_2 = aircraft.method_167().int_9;
					this.int_3 = aircraft.method_167().int_10;
					this.int_4 = aircraft.method_167().int_11;
					this.int_1 = aircraft.method_167().int_12;
				}
				try
				{
					foreach (Aircraft aircraft2 in this.list_0)
					{
						num++;
						Aircraft_AirOps aircraft_AirOps = aircraft2.method_164();
						if (num == 1)
						{
							flag2 = new bool?(aircraft_AirOps.bool_0);
							this.nullable_0 = new int?(aircraft_AirOps.int_2);
						}
						else
						{
							bool flag3 = aircraft_AirOps.bool_0;
							if (((flag2 != null) ? new bool?(flag3 != flag2.GetValueOrDefault()) : null).GetValueOrDefault() && !Information.IsNothing(flag2))
							{
								flag2 = null;
							}
							int num3 = aircraft_AirOps.int_2;
							int? num4 = this.nullable_0;
							if (((num4 != null) ? new bool?(num3 != num4.GetValueOrDefault()) : null).GetValueOrDefault() && !Information.IsNothing(this.nullable_0))
							{
								this.nullable_0 = null;
							}
						}
					}
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (Information.IsNothing(this.list_1))
				{
					goto IL_6E2;
				}
				try
				{
					foreach (Mission.EmptyAircraftSlot emptyAircraftSlot in this.list_1)
					{
						num2++;
						if (num > 0 && num2 == 1)
						{
							flag2 = new bool?(emptyAircraftSlot.bool_1);
							this.nullable_0 = new int?(emptyAircraftSlot.int_2);
						}
						else
						{
							bool flag3 = emptyAircraftSlot.bool_1;
							if (((flag2 != null) ? new bool?(flag3 != flag2.GetValueOrDefault()) : null).GetValueOrDefault() && !Information.IsNothing(flag2))
							{
								flag2 = null;
							}
							int num3 = emptyAircraftSlot.int_2;
							int? num4 = this.nullable_0;
							if (((num4 != null) ? new bool?(num3 != num4.GetValueOrDefault()) : null).GetValueOrDefault() && !Information.IsNothing(this.nullable_0))
							{
								this.nullable_0 = null;
							}
						}
					}
					goto IL_6E2;
				}
				finally
				{
					List<Mission.EmptyAircraftSlot>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
			if (!Information.IsNothing(this.list_1) && this.list_1.Count > 0 && this.hashSet_0.Count == 1 && Enumerable.ElementAtOrDefault<int>(this.hashSet_0, 0) == this.int_0)
			{
				array = this.dataTable_1.Select("ID = " + Conversions.ToString(this.int_0));
				if (Enumerable.Count<DataRow>(array) > 0)
				{
					this.string_0 = Conversions.ToString(array[0]["ReadyTime"]);
					this.bool_3 = Conversions.ToBoolean(array[0]["QuickTurnaround"]);
					this.int_2 = Conversions.ToInteger(array[0]["QuickTurnaround_ReadyTime"]);
					this.int_3 = Conversions.ToInteger(array[0]["QuickTurnaround_MaxSorties"]);
					this.int_4 = Conversions.ToInteger(array[0]["QuickTurnaround_AdditionalTimePenalty"]);
					this.int_1 = Conversions.ToInteger(array[0]["QuickTurnaround_AirborneTime"]);
				}
				try
				{
					foreach (Mission.EmptyAircraftSlot emptyAircraftSlot2 in this.list_1)
					{
						num2++;
						if (num2 == 1)
						{
							flag2 = new bool?(emptyAircraftSlot2.bool_1);
							this.nullable_0 = new int?(emptyAircraftSlot2.int_2);
						}
						else
						{
							bool flag3 = emptyAircraftSlot2.bool_1;
							if (((flag2 != null) ? new bool?(flag3 != flag2.GetValueOrDefault()) : null).GetValueOrDefault() && !Information.IsNothing(flag2))
							{
								flag2 = null;
							}
							int num3 = emptyAircraftSlot2.int_2;
							int? num4 = this.nullable_0;
							if (((num4 != null) ? new bool?(num3 != num4.GetValueOrDefault()) : null).GetValueOrDefault() && !Information.IsNothing(this.nullable_0))
							{
								this.nullable_0 = null;
							}
						}
					}
					goto IL_6E2;
				}
				finally
				{
					List<Mission.EmptyAircraftSlot>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
			}
			array = this.dataTable_1.Select("ID = " + Conversions.ToString(this.int_0));
			if (Enumerable.Count<DataRow>(array) > 0)
			{
				this.string_0 = Conversions.ToString(array[0]["ReadyTime"]);
				this.bool_3 = Conversions.ToBoolean(array[0]["QuickTurnaround"]);
				this.int_2 = Conversions.ToInteger(array[0]["QuickTurnaround_ReadyTime"]);
				this.int_3 = Conversions.ToInteger(array[0]["QuickTurnaround_MaxSorties"]);
				this.int_4 = Conversions.ToInteger(array[0]["QuickTurnaround_AdditionalTimePenalty"]);
				this.int_1 = Conversions.ToInteger(array[0]["QuickTurnaround_AirborneTime"]);
			}
			IL_6E2:
			if (this.bool_3)
			{
				if (!Information.IsNothing(aircraft))
				{
					Doctrine.Enum53? enum2 = aircraft.doctrine_0.method_196(aircraft.scenario_0, false, false, false, false);
					byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						flag = false;
					}
					else
					{
						enum2 = aircraft.doctrine_0.method_196(aircraft.scenario_0, false, false, false, false);
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							if (Enumerable.Count<DataRow>(array) > 0)
							{
								Loadout loadout = new Loadout(Conversions.ToInteger(array[0]["ID"]), Conversions.ToString(array[0]["Name"]), 0, 0, 0, 0, (Loadout.LoadoutRole)Conversions.ToInteger(array[0]["LoadoutRole"]), (Loadout._LoadoutDayNight)0, Loadout._LoadoutWeather.AllWeather, 0f, 0, 0, false, false, Conversions.ToBoolean(array[0]["QuickTurnaround"]), Conversions.ToInteger(array[0]["QuickTurnaround_ReadyTime"]), Conversions.ToInteger(array[0]["QuickTurnaround_MaxSorties"]), Conversions.ToInteger(array[0]["QuickTurnaround_AdditionalTimePenalty"]), Conversions.ToInteger(array[0]["QuickTurnaround_AirborneTime"]), (Loadout._LoadoutDayNight)1, Doctrine._WeaponState.LoadoutSetting);
								if (!loadout.method_10() && !loadout.method_12() && !loadout.method_11())
								{
									flag = false;
								}
							}
							else
							{
								flag = false;
							}
						}
					}
				}
				else if (!Information.IsNothing(this.list_1) && this.list_1.Count > 0)
				{
				}
			}
			else
			{
				flag = false;
			}
			this.bool_4 = false;
			if (this.hashSet_0.Count == 1 && Enumerable.ElementAtOrDefault<int>(this.hashSet_0, 0) == this.int_0)
			{
				if (flag)
				{
					this.vmethod_32().Enabled = true;
					if (Information.IsNothing(flag2))
					{
						this.vmethod_32().CheckState = CheckState.Indeterminate;
						this.method_22(this.nullable_0);
						this.vmethod_34().Enabled = false;
						this.vmethod_36().Enabled = true;
						this.vmethod_36().Text = "Selection includes aircraft with and without the Quick Turnaround option set.";
					}
					else if (flag2.GetValueOrDefault())
					{
						if (this.vmethod_32().CheckState == CheckState.Indeterminate)
						{
							this.vmethod_32().CheckState = CheckState.Checked;
						}
						else
						{
							this.vmethod_32().Checked = true;
						}
						this.method_22(this.nullable_0);
						this.vmethod_34().Enabled = true;
						this.vmethod_36().Enabled = true;
						if (!Information.IsNothing(this.nullable_0))
						{
							this.vmethod_36().Text = this.method_19();
						}
						else
						{
							this.vmethod_36().Text = "";
						}
					}
					else
					{
						if (this.vmethod_32().CheckState == CheckState.Indeterminate)
						{
							this.vmethod_32().CheckState = CheckState.Unchecked;
						}
						else
						{
							this.vmethod_32().Checked = false;
						}
						this.method_22(new int?(this.int_3));
					}
				}
				else
				{
					this.vmethod_32().Enabled = false;
					if (this.vmethod_32().CheckState == CheckState.Indeterminate)
					{
						this.vmethod_32().CheckState = CheckState.Unchecked;
					}
					else
					{
						this.vmethod_32().Checked = false;
					}
					this.method_22(new int?(0));
				}
			}
			else
			{
				if (flag)
				{
					if (this.bool_3)
					{
						this.vmethod_32().Enabled = true;
						if (this.vmethod_32().CheckState == CheckState.Indeterminate)
						{
							this.vmethod_32().CheckState = CheckState.Unchecked;
						}
						else
						{
							this.vmethod_32().Checked = false;
						}
					}
					else
					{
						this.vmethod_32().Enabled = false;
						if (this.vmethod_32().CheckState == CheckState.Indeterminate)
						{
							this.vmethod_32().CheckState = CheckState.Unchecked;
						}
						else
						{
							this.vmethod_32().Checked = false;
						}
					}
				}
				else
				{
					this.vmethod_32().Enabled = false;
					if (this.vmethod_32().CheckState == CheckState.Indeterminate)
					{
						this.vmethod_32().CheckState = CheckState.Unchecked;
					}
					else
					{
						this.vmethod_32().Checked = false;
					}
				}
				this.method_22(new int?(this.int_3));
			}
			this.bool_4 = true;
		}

		// Token: 0x06007527 RID: 29991 RVA: 0x003F3A08 File Offset: 0x003F1C08
		private void method_16(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && this.vmethod_38().Columns[e.ColumnIndex].CellType == typeof(DataGridViewLinkCell))
			{
				int selectedObjectID = Conversions.ToInteger(this.dataTable_0.Rows[e.RowIndex]["ComponentID"]);
				Client.smethod_63("Weapon", selectedObjectID, null);
			}
		}

		// Token: 0x06007528 RID: 29992 RVA: 0x003F3A78 File Offset: 0x003F1C78
		private void method_17(object sender, DataGridViewCellFormattingEventArgs e)
		{
			try
			{
				if (!Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2))
				{
					DataGridViewRow dataGridViewRow = this.vmethod_40().Rows[e.RowIndex];
					if (Operators.CompareString(this.vmethod_40().Columns[e.ColumnIndex].Name, "NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly", false) == 0 && (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.Value)) || Conversions.ToInteger(e.Value) <= 0) && Operators.CompareString(Conversions.ToString(e.Value), "Unlimited", false) != 0)
					{
						dataGridViewRow.DefaultCellStyle.ForeColor = Color.DarkGray;
						dataGridViewRow.DefaultCellStyle.Font = new Font(this.Font, FontStyle.Italic);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200110", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06007529 RID: 29993 RVA: 0x003F3B84 File Offset: 0x003F1D84
		private void ReadyAircraft_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.Return && base.Visible)
			{
				if (this.method_4(this.int_0, this.dictionary_0, false) > 0)
				{
					this.method_10(false, true, false, !Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2));
					return;
				}
			}
			else if (!base.Visible || (e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Add && e.KeyCode != Keys.Subtract))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x0600752A RID: 29994 RVA: 0x003F3C60 File Offset: 0x003F1E60
		private void method_18(object sender, EventArgs e)
		{
			this.vmethod_36().Text = this.method_19();
			if (this.bool_4)
			{
				if (this.vmethod_34().SelectedIndex + 2 <= this.int_3 && this.vmethod_34().SelectedIndex >= 0)
				{
					this.nullable_0 = new int?(this.vmethod_34().SelectedIndex + 2);
					return;
				}
				this.nullable_0 = null;
			}
		}

		// Token: 0x0600752B RID: 29995 RVA: 0x003F3CD0 File Offset: 0x003F1ED0
		private string method_19()
		{
			string result;
			if (this.vmethod_34().SelectedIndex + 2 <= this.int_3)
			{
				result = string.Concat(new string[]
				{
					Conversions.ToString(this.vmethod_34().SelectedIndex + 2),
					" sorties @ ",
					Misc.smethod_11((long)(this.int_1 * 60), Aircraft_AirOps.Enum44.const_0, false, false),
					" maximum airborne time and ",
					Misc.smethod_11((long)(this.int_2 * 60), Aircraft_AirOps.Enum44.const_0, false, false),
					" turnaround, with ",
					this.string_0,
					" standdown ready time"
				});
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600752C RID: 29996 RVA: 0x003F3D70 File Offset: 0x003F1F70
		private void method_20(int? nullable_1)
		{
			this.vmethod_34().Items.Clear();
			if (this.vmethod_32().CheckState != CheckState.Indeterminate && this.vmethod_32().Checked)
			{
				int num = this.int_3;
				for (int i = 2; i <= num; i++)
				{
					if (i == this.int_3)
					{
						this.vmethod_34().Items.Add(Conversions.ToString(i) + " Sorties (Maximum)");
					}
					else
					{
						this.vmethod_34().Items.Add(Conversions.ToString(i) + " Sorties");
					}
				}
				if (!Information.IsNothing(nullable_1) && this.vmethod_34().Items.Count > 0)
				{
					this.vmethod_34().SelectedIndex = this.vmethod_34().Items.Count - 1;
					return;
				}
				this.vmethod_34().Items.Add("Various");
				this.vmethod_34().SelectedIndex = this.vmethod_34().Items.Count - 1;
			}
		}

		// Token: 0x0600752D RID: 29997 RVA: 0x00048CE7 File Offset: 0x00046EE7
		private void method_21(object sender, EventArgs e)
		{
			this.method_22(new int?(this.int_3));
		}

		// Token: 0x0600752E RID: 29998 RVA: 0x003F3E80 File Offset: 0x003F2080
		private void method_22(int? nullable_1)
		{
			if (this.vmethod_32().Checked)
			{
				this.vmethod_34().Enabled = true;
				this.method_20(nullable_1);
				this.vmethod_36().Enabled = true;
				this.vmethod_36().Text = this.method_19();
				return;
			}
			this.vmethod_34().Enabled = false;
			this.method_20(nullable_1);
			this.vmethod_36().Enabled = false;
			this.vmethod_36().Text = "";
		}

		// Token: 0x0600752F RID: 29999 RVA: 0x00048CFA File Offset: 0x00046EFA
		private void method_23(object sender, EventArgs e)
		{
			this.method_3();
			if (this.vmethod_26().Checked)
			{
				Class570.class280_0.method_27(true);
				return;
			}
			Class570.class280_0.method_27(false);
		}

		// Token: 0x04004192 RID: 16786
		[CompilerGenerated]
		[AccessedThroughProperty("Label_Loadout")]
		private Class116 class116_0;

		// Token: 0x04004193 RID: 16787
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x04004194 RID: 16788
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_1;

		// Token: 0x04004195 RID: 16789
		[AccessedThroughProperty("MenuStrip1")]
		[CompilerGenerated]
		private Class119 class119_0;

		// Token: 0x04004196 RID: 16790
		[AccessedThroughProperty("CheckHostsMagazinesToolStripMenuItem")]
		[CompilerGenerated]
		private Class128 class128_0;

		// Token: 0x04004197 RID: 16791
		[AccessedThroughProperty("Button3")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x04004198 RID: 16792
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x04004199 RID: 16793
		[AccessedThroughProperty("Label5")]
		[CompilerGenerated]
		private Class116 class116_2;

		// Token: 0x0400419A RID: 16794
		[AccessedThroughProperty("Label6")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x0400419B RID: 16795
		[AccessedThroughProperty("Label7")]
		[CompilerGenerated]
		private Class116 class116_4;

		// Token: 0x0400419C RID: 16796
		[CompilerGenerated]
		[AccessedThroughProperty("Label8")]
		private Class116 class116_5;

		// Token: 0x0400419D RID: 16797
		[AccessedThroughProperty("Button4")]
		[CompilerGenerated]
		private Control9 control9_3;

		// Token: 0x0400419E RID: 16798
		[AccessedThroughProperty("Button5")]
		[CompilerGenerated]
		private Control9 control9_4;

		// Token: 0x0400419F RID: 16799
		[CompilerGenerated]
		[AccessedThroughProperty("CB_ShowOnlyUsable")]
		private Class112 class112_0;

		// Token: 0x040041A0 RID: 16800
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_6;

		// Token: 0x040041A1 RID: 16801
		[CompilerGenerated]
		[AccessedThroughProperty("FlowLayoutPanel1")]
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x040041A2 RID: 16802
		[CompilerGenerated]
		[AccessedThroughProperty("CB_QuickTurnaround")]
		private Class112 class112_1;

		// Token: 0x040041A3 RID: 16803
		[CompilerGenerated]
		[AccessedThroughProperty("Combo_NumberOfSorties")]
		private Class2451 class2451_0;

		// Token: 0x040041A4 RID: 16804
		[AccessedThroughProperty("Label_QuickTurnaroundInfo")]
		[CompilerGenerated]
		private Class116 class116_7;

		// Token: 0x040041A5 RID: 16805
		[AccessedThroughProperty("DGV_LoadoutItems")]
		[CompilerGenerated]
		private Class114 class114_0;

		// Token: 0x040041A6 RID: 16806
		[AccessedThroughProperty("DGV_Loadouts")]
		[CompilerGenerated]
		private Class114 class114_1;

		// Token: 0x040041A7 RID: 16807
		[AccessedThroughProperty("ID")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x040041A8 RID: 16808
		[CompilerGenerated]
		[AccessedThroughProperty("Loadout")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x040041A9 RID: 16809
		[CompilerGenerated]
		[AccessedThroughProperty("NumberOfLoadouts")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x040041AA RID: 16810
		[AccessedThroughProperty("NumberOfLoadoutsIncludingMountedWeapons")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x040041AB RID: 16811
		[AccessedThroughProperty("NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x040041AC RID: 16812
		[CompilerGenerated]
		[AccessedThroughProperty("ReadyTime")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x040041AD RID: 16813
		[CompilerGenerated]
		[AccessedThroughProperty("ReadyTime_Sustained")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x040041AE RID: 16814
		[CompilerGenerated]
		[AccessedThroughProperty("QuickTurnaroundDescription")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		// Token: 0x040041AF RID: 16815
		[AccessedThroughProperty("TimeofDay")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		// Token: 0x040041B0 RID: 16816
		[CompilerGenerated]
		[AccessedThroughProperty("Weather")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		// Token: 0x040041B1 RID: 16817
		[AccessedThroughProperty("RangeProfileDescription")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		// Token: 0x040041B2 RID: 16818
		[CompilerGenerated]
		[AccessedThroughProperty("LoadoutRoleDescription")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		// Token: 0x040041B3 RID: 16819
		[CompilerGenerated]
		[AccessedThroughProperty("LoadoutRole")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		// Token: 0x040041B4 RID: 16820
		[CompilerGenerated]
		[AccessedThroughProperty("RequiresBuddyIllumination")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		// Token: 0x040041B5 RID: 16821
		[CompilerGenerated]
		[AccessedThroughProperty("DefaultCombatRadius")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		// Token: 0x040041B6 RID: 16822
		[AccessedThroughProperty("DefaultTimeOnStation")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		// Token: 0x040041B7 RID: 16823
		[CompilerGenerated]
		[AccessedThroughProperty("DefaultMissionProfile")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		// Token: 0x040041B8 RID: 16824
		[CompilerGenerated]
		[AccessedThroughProperty("AttackAltitude")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		// Token: 0x040041B9 RID: 16825
		[AccessedThroughProperty("QuickTurnaround")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		// Token: 0x040041BA RID: 16826
		[CompilerGenerated]
		[AccessedThroughProperty("QuickTurnaround_MaxSorties")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		// Token: 0x040041BB RID: 16827
		[AccessedThroughProperty("QuickTurnaround_AirborneTime")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

		// Token: 0x040041BC RID: 16828
		[CompilerGenerated]
		[AccessedThroughProperty("QuickTurnaround_ReadyTime")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

		// Token: 0x040041BD RID: 16829
		[CompilerGenerated]
		[AccessedThroughProperty("QuickTurnaround_StanddownTime")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

		// Token: 0x040041BE RID: 16830
		[AccessedThroughProperty("QuickTurnaround_TimeofDay")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

		// Token: 0x040041BF RID: 16831
		[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

		// Token: 0x040041C0 RID: 16832
		[AccessedThroughProperty("Column_Description")]
		[CompilerGenerated]
		private DataGridViewLinkColumn dataGridViewLinkColumn_0;

		// Token: 0x040041C1 RID: 16833
		[CompilerGenerated]
		[AccessedThroughProperty("Available")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

		// Token: 0x040041C2 RID: 16834
		[CompilerGenerated]
		[AccessedThroughProperty("AvailableTotal")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

		// Token: 0x040041C3 RID: 16835
		public List<Aircraft> list_0;

		// Token: 0x040041C4 RID: 16836
		public List<Mission.EmptyAircraftSlot> list_1;

		// Token: 0x040041C5 RID: 16837
		public int int_0;

		// Token: 0x040041C6 RID: 16838
		private DataTable dataTable_0;

		// Token: 0x040041C7 RID: 16839
		private DataTable dataTable_1;

		// Token: 0x040041C8 RID: 16840
		private Dictionary<int, int> dictionary_0;

		// Token: 0x040041C9 RID: 16841
		private HashSet<int> hashSet_0;

		// Token: 0x040041CA RID: 16842
		private string string_0;

		// Token: 0x040041CB RID: 16843
		private bool bool_3;

		// Token: 0x040041CC RID: 16844
		private int int_1;

		// Token: 0x040041CD RID: 16845
		private int int_2;

		// Token: 0x040041CE RID: 16846
		private int int_3;

		// Token: 0x040041CF RID: 16847
		private int int_4;

		// Token: 0x040041D0 RID: 16848
		private int? nullable_0;

		// Token: 0x040041D1 RID: 16849
		private bool bool_4;
	}
}
