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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns13;
using ns14;
using ns2;
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000E14 RID: 3604
	[DesignerGenerated]
	public sealed partial class AirTaskingOrder : DarkSecondaryFormBase
	{
		// Token: 0x0600691A RID: 26906 RVA: 0x0038E528 File Offset: 0x0038C728
		public AirTaskingOrder()
		{
			base.FormClosing += this.AirTaskingOrder_FormClosing;
			base.FormClosed += this.AirTaskingOrder_FormClosed;
			base.Load += this.AirTaskingOrder_Load;
			base.VisibleChanged += this.AirTaskingOrder_VisibleChanged;
			base.KeyDown += this.AirTaskingOrder_KeyDown;
			this.list_0 = new List<Mission.Flight>();
			this.bool_3 = true;
			this.string_0 = "";
			this.int_0 = 0;
			this.dataTable_0 = new DataTable();
			this.enum200_0 = AirTaskingOrder.Enum200.const_0;
			this.string_1 = "";
			this.bitmap_0 = (Bitmap)Image.FromFile(Application.StartupPath + "\\symbols\\menu\\Locked_16.png");
			this.bitmap_1 = (Bitmap)Image.FromFile(Application.StartupPath + "\\symbols\\menu\\Unlocked_16.png");
			this.bitmap_2 = (Bitmap)Image.FromFile(Application.StartupPath + "\\symbols\\menu\\NotConfigured_16.png");
			this.bitmap_3 = (Bitmap)Image.FromFile(Application.StartupPath + "\\symbols\\menu\\NotLockable_16.png");
			this.bitmap_4 = (Bitmap)Image.FromFile(Application.StartupPath + "\\symbols\\menu\\Relative_16.png");
			this.InitializeComponent_1();
		}

		// Token: 0x0600691C RID: 26908 RVA: 0x0038E6B8 File Offset: 0x0038C8B8
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.vmethod_13(new Control9());
			this.vmethod_11(new Control9());
			this.vmethod_9(new Control9());
			this.vmethod_7(new Control9());
			this.vmethod_17(new Class2451());
			this.vmethod_5(new Class2451());
			this.vmethod_15(new Class116());
			this.vmethod_3(new Class116());
			this.vmethod_1(new Class114());
			this.vmethod_35(new DataGridViewTextBoxColumn());
			this.vmethod_37(new DataGridViewTextBoxColumn());
			this.vmethod_39(new DataGridViewTextBoxColumn());
			this.vmethod_41(new DataGridViewComboBoxColumn());
			this.vmethod_43(new DataGridViewTextBoxColumn());
			this.vmethod_45(new DataGridViewComboBoxColumn());
			this.vmethod_47(new DataGridViewTextBoxColumn());
			this.vmethod_49(new DataGridViewTextBoxColumn());
			this.vmethod_51(new DataGridViewTextBoxColumn());
			this.vmethod_53(new DataGridViewTextBoxColumn());
			this.vmethod_55(new DataGridViewTextBoxColumn());
			this.vmethod_57(new DataGridViewImageColumn());
			this.vmethod_59(new DataGridViewTextBoxColumn());
			this.vmethod_61(new DataGridViewTextBoxColumn());
			this.vmethod_63(new DataGridViewTextBoxColumn());
			this.vmethod_65(new DataGridViewImageColumn());
			this.vmethod_67(new DataGridViewTextBoxColumn());
			this.vmethod_69(new DataGridViewTextBoxColumn());
			this.vmethod_71(new DataGridViewTextBoxColumn());
			this.vmethod_73(new DataGridViewComboBoxColumn());
			this.vmethod_75(new DataGridViewComboBoxColumn());
			this.vmethod_77(new DataGridViewTextBoxColumn());
			this.vmethod_79(new DataGridViewTextBoxColumn());
			this.vmethod_81(new DataGridViewComboBoxColumn());
			this.vmethod_83(new DataGridViewTextBoxColumn());
			this.vmethod_85(new DataGridViewTextBoxColumn());
			this.vmethod_19(new Control9());
			this.vmethod_21(new Control9());
			this.vmethod_23(new Control9());
			this.vmethod_25(new Control9());
			this.vmethod_27(new Class2451());
			this.vmethod_29(new Class2451());
			this.vmethod_31(new Class116());
			this.vmethod_33(new Class116());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_12().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().ForeColor = SystemColors.Control;
			this.vmethod_12().Location = new Point(297, 631);
			this.vmethod_12().Name = "Button_DeleteFlight";
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new Size(146, 28);
			this.vmethod_12().TabIndex = 15;
			this.vmethod_12().Text = "Delete Flight";
			this.vmethod_10().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().DialogResult = DialogResult.None;
			this.vmethod_10().ForeColor = SystemColors.Control;
			this.vmethod_10().Location = new Point(3, 660);
			this.vmethod_10().Name = "Button_ChangeAircraftType";
			this.vmethod_10().method_1(0);
			this.vmethod_10().Size = new Size(172, 28);
			this.vmethod_10().TabIndex = 14;
			this.vmethod_10().Text = "Change a/c type and loadout";
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().DialogResult = DialogResult.None;
			this.vmethod_8().ForeColor = SystemColors.Control;
			this.vmethod_8().Location = new Point(444, 631);
			this.vmethod_8().Name = "Button_FlightPlanEditor";
			this.vmethod_8().method_1(0);
			this.vmethod_8().Size = new Size(146, 28);
			this.vmethod_8().TabIndex = 13;
			this.vmethod_8().Text = "Edit Flightplan";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.None;
			this.vmethod_6().ForeColor = SystemColors.Control;
			this.vmethod_6().Location = new Point(3, 631);
			this.vmethod_6().Name = "Button_CreateFlight";
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(146, 28);
			this.vmethod_6().TabIndex = 12;
			this.vmethod_6().Text = "Create Flight";
			this.vmethod_16().BackColor = Color.Transparent;
			this.vmethod_16().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_16().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_16().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_16().FormattingEnabled = true;
			this.vmethod_16().Items.AddRange(new object[]
			{
				"All",
				"Selected unit",
				"Do not show"
			});
			this.vmethod_16().Location = new Point(787, 3);
			this.vmethod_16().Name = "ComboBox_AirborneFlightPlanVisibility";
			this.vmethod_16().Size = new Size(214, 21);
			this.vmethod_16().TabIndex = 11;
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_4().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_4().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_4().FormattingEnabled = true;
			this.vmethod_4().Items.AddRange(new object[]
			{
				"All",
				"Selected Task Pool (or Mission) ",
				"Selected Package (or Mission)",
				"Selected Flight",
				"Do not show"
			});
			this.vmethod_4().Location = new Point(787, 26);
			this.vmethod_4().Name = "ComboBox_PlannedFlightPlanVisibility";
			this.vmethod_4().Size = new Size(214, 21);
			this.vmethod_4().TabIndex = 11;
			this.vmethod_14().method_2(true);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Location = new Point(554, 7);
			this.vmethod_14().Name = "Label2";
			this.vmethod_14().Size = new Size(230, 15);
			this.vmethod_14().TabIndex = 10;
			this.vmethod_14().Text = "Show airborne flightplans on tactical map:";
			this.vmethod_2().method_2(true);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(554, 30);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new Size(229, 15);
			this.vmethod_2().TabIndex = 10;
			this.vmethod_2().Text = "Show planned flightplans on tactical map:";
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().AllowUserToResizeRows = false;
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_0().BorderStyle = BorderStyle.None;
			this.vmethod_0().CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.vmethod_0().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_0().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().ColumnHeadersHeight = 18;
			this.vmethod_0().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_34(),
				this.vmethod_36(),
				this.vmethod_38(),
				this.vmethod_40(),
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
				this.vmethod_84()
			});
			this.vmethod_0().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_0().EnableHeadersVisualStyles = false;
			this.vmethod_0().Location = new Point(0, 53);
			this.vmethod_0().Name = "DGV_AirTaskingOrder";
			this.vmethod_0().RowHeadersVisible = false;
			this.vmethod_0().RowHeadersWidth = 10;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
			this.vmethod_0().RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new Size(1008, 576);
			this.vmethod_0().TabIndex = 9;
			this.vmethod_34().DataPropertyName = "ID";
			this.vmethod_34().Frozen = true;
			this.vmethod_34().HeaderText = "ID";
			this.vmethod_34().Name = "ID";
			this.vmethod_34().Visible = false;
			this.vmethod_36().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_36().DataPropertyName = "MissionOrPackage";
			this.vmethod_36().Frozen = true;
			this.vmethod_36().HeaderText = "Mission/Package";
			this.vmethod_36().Name = "MissionOrPackage";
			this.vmethod_36().Width = 120;
			this.vmethod_38().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_38().DataPropertyName = "Callsign";
			this.vmethod_38().Frozen = true;
			this.vmethod_38().HeaderText = "Flight Callsign";
			this.vmethod_38().Name = "Callsign";
			this.vmethod_38().Width = 105;
			this.vmethod_40().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_40().DataPropertyName = "Type";
			this.vmethod_40().FlatStyle = FlatStyle.Flat;
			this.vmethod_40().HeaderText = "Type";
			this.vmethod_40().Name = "Type";
			this.vmethod_40().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_40().Width = 55;
			this.vmethod_42().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_42().DataPropertyName = "Status";
			this.vmethod_42().HeaderText = "Status";
			this.vmethod_42().Name = "Status";
			this.vmethod_42().Width = 62;
			this.vmethod_44().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_44().DataPropertyName = "Task";
			this.vmethod_44().FlatStyle = FlatStyle.Flat;
			this.vmethod_44().HeaderText = "Task";
			this.vmethod_44().Name = "Task";
			this.vmethod_44().Resizable = DataGridViewTriState.True;
			this.vmethod_44().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_44().Width = 53;
			this.vmethod_46().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_46().DataPropertyName = "AircraftType";
			this.vmethod_46().HeaderText = "Aircraft Type";
			this.vmethod_46().Name = "AircraftType";
			this.vmethod_46().ReadOnly = true;
			this.vmethod_46().Width = 97;
			this.vmethod_48().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_48().DataPropertyName = "LoadoutType";
			this.vmethod_48().HeaderText = "Loadout Type";
			this.vmethod_48().Name = "LoadoutType";
			this.vmethod_48().Width = 102;
			this.vmethod_50().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_50().DataPropertyName = "TakeOffTimeZulu";
			this.vmethod_50().HeaderText = "Zulu Take-Off Time";
			this.vmethod_50().Name = "TakeOffTimeZulu";
			this.vmethod_50().Width = 133;
			this.vmethod_52().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_52().DataPropertyName = "TakeOffTimeLocal";
			this.vmethod_52().HeaderText = "Local Take-Off Time";
			this.vmethod_52().Name = "TakeOffTimeLocal";
			this.vmethod_52().Width = 137;
			this.vmethod_54().DataPropertyName = "TakeOffTimeFixed";
			this.vmethod_54().HeaderText = "TakeOffTimeFixed";
			this.vmethod_54().Name = "TakeOffTimeFixed";
			this.vmethod_54().Visible = false;
			this.vmethod_56().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.vmethod_56().DataPropertyName = "TakeOffTimeImg";
			this.vmethod_56().HeaderText = "";
			this.vmethod_56().Name = "TakeOffTimeImg";
			this.vmethod_56().Resizable = DataGridViewTriState.True;
			this.vmethod_56().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_56().Width = 5;
			this.vmethod_58().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_58().DataPropertyName = "ObjectiveTimeZulu";
			this.vmethod_58().HeaderText = "Zulu Objective Time";
			this.vmethod_58().Name = "ObjectiveTimeZulu";
			this.vmethod_58().Width = 137;
			this.vmethod_60().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_60().DataPropertyName = "ObjectiveTimeLocal";
			this.vmethod_60().HeaderText = "Local Objective Time";
			this.vmethod_60().Name = "ObjectiveTimeLocal";
			this.vmethod_60().Width = 141;
			this.vmethod_62().DataPropertyName = "ObjectiveTimeFixed";
			this.vmethod_62().HeaderText = "ObjectiveTimeFixed";
			this.vmethod_62().Name = "ObjectiveTimeFixed";
			this.vmethod_62().Visible = false;
			this.vmethod_64().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.vmethod_64().DataPropertyName = "ObjectiveTimeImg";
			this.vmethod_64().HeaderText = "";
			this.vmethod_64().Name = "ObjectiveTimeImg";
			this.vmethod_64().Resizable = DataGridViewTriState.True;
			this.vmethod_64().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_64().Width = 5;
			this.vmethod_66().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_66().DataPropertyName = "TakeOffLocation";
			this.vmethod_66().HeaderText = "Take Off Location";
			this.vmethod_66().Name = "TakeOffLocation";
			this.vmethod_66().Width = 123;
			this.vmethod_68().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_68().DataPropertyName = "LandingLocation";
			this.vmethod_68().HeaderText = "Landing Location";
			this.vmethod_68().Name = "LandingLocation";
			this.vmethod_68().Width = 122;
			this.vmethod_70().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_70().DataPropertyName = "AlternativeLandingLocation";
			this.vmethod_70().HeaderText = "Diversion Location";
			this.vmethod_70().Name = "AlternativeLandingLocation";
			this.vmethod_70().Width = 128;
			this.vmethod_72().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_72().DataPropertyName = "DesiredAircraftQty";
			this.vmethod_72().FlatStyle = FlatStyle.Flat;
			this.vmethod_72().HeaderText = "Desired Flight Size";
			this.vmethod_72().Name = "DesiredAircraftQty";
			this.vmethod_72().Resizable = DataGridViewTriState.True;
			this.vmethod_72().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_72().Width = 125;
			this.vmethod_74().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_74().DataPropertyName = "MinimumAircraftQty";
			this.vmethod_74().FlatStyle = FlatStyle.Flat;
			this.vmethod_74().HeaderText = "Minimum Flight Size";
			this.vmethod_74().Name = "MinimumAircraftQty";
			this.vmethod_74().Resizable = DataGridViewTriState.True;
			this.vmethod_74().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_74().Width = 139;
			this.vmethod_76().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_76().DataPropertyName = "AssignedAircraftQty";
			this.vmethod_76().HeaderText = "Assigned a/c";
			this.vmethod_76().Name = "AssignedAircraftQty";
			this.vmethod_76().ReadOnly = true;
			this.vmethod_76().Resizable = DataGridViewTriState.True;
			this.vmethod_76().Width = 98;
			this.vmethod_78().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_78().DataPropertyName = "ReadyAircraftQty";
			this.vmethod_78().HeaderText = "Ready a/c";
			this.vmethod_78().Name = "ReadyAircraftQty";
			this.vmethod_78().ReadOnly = true;
			this.vmethod_78().Resizable = DataGridViewTriState.True;
			this.vmethod_78().Width = 82;
			this.vmethod_80().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_80().DataPropertyName = "Priority";
			this.vmethod_80().FlatStyle = FlatStyle.Flat;
			this.vmethod_80().HeaderText = "Priority";
			this.vmethod_80().Name = "Priority";
			this.vmethod_80().Resizable = DataGridViewTriState.True;
			this.vmethod_80().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_80().Width = 68;
			this.vmethod_82().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_82().DataPropertyName = "CreatedBy";
			this.vmethod_82().HeaderText = "Created By";
			this.vmethod_82().Name = "CreatedBy";
			this.vmethod_82().Width = 87;
			this.vmethod_84().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_84().DataPropertyName = "EditedBy";
			this.vmethod_84().HeaderText = "Edited By";
			this.vmethod_84().Name = "EditedBy";
			this.vmethod_84().Width = 79;
			this.vmethod_18().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_18().BackColor = Color.Transparent;
			this.vmethod_18().DialogResult = DialogResult.None;
			this.vmethod_18().ForeColor = SystemColors.Control;
			this.vmethod_18().Location = new Point(150, 631);
			this.vmethod_18().Name = "Button_CopyFlight";
			this.vmethod_18().method_1(0);
			this.vmethod_18().Size = new Size(146, 28);
			this.vmethod_18().TabIndex = 16;
			this.vmethod_18().Text = "Copy Flight";
			this.vmethod_20().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_20().BackColor = Color.Transparent;
			this.vmethod_20().DialogResult = DialogResult.None;
			this.vmethod_20().Enabled = false;
			this.vmethod_20().ForeColor = SystemColors.Control;
			this.vmethod_20().Location = new Point(176, 660);
			this.vmethod_20().Name = "Button_ChangeTakeOffTime";
			this.vmethod_20().method_1(0);
			this.vmethod_20().Size = new Size(162, 28);
			this.vmethod_20().TabIndex = 17;
			this.vmethod_20().Text = "Change take-off time";
			this.vmethod_22().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_22().BackColor = Color.Transparent;
			this.vmethod_22().DialogResult = DialogResult.None;
			this.vmethod_22().Enabled = false;
			this.vmethod_22().ForeColor = SystemColors.Control;
			this.vmethod_22().Location = new Point(339, 660);
			this.vmethod_22().Name = "Button_ChangeObjectiveTime";
			this.vmethod_22().method_1(0);
			this.vmethod_22().Size = new Size(162, 28);
			this.vmethod_22().TabIndex = 18;
			this.vmethod_22().Text = "Change objective time";
			this.vmethod_24().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_24().BackColor = Color.Transparent;
			this.vmethod_24().DialogResult = DialogResult.None;
			this.vmethod_24().Enabled = false;
			this.vmethod_24().ForeColor = SystemColors.Control;
			this.vmethod_24().Location = new Point(502, 660);
			this.vmethod_24().Name = "Button_ClearTime";
			this.vmethod_24().method_1(0);
			this.vmethod_24().Size = new Size(88, 28);
			this.vmethod_24().TabIndex = 18;
			this.vmethod_24().Text = "Clear Time";
			this.vmethod_26().BackColor = Color.Transparent;
			this.vmethod_26().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_26().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_26().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_26().FormattingEnabled = true;
			this.vmethod_26().Items.AddRange(new object[]
			{
				"All",
				"Selected unit",
				"Do not show"
			});
			this.vmethod_26().Location = new Point(93, 26);
			this.vmethod_26().Name = "ComboBox_AirTaskingOrderSorting";
			this.vmethod_26().Size = new Size(451, 21);
			this.vmethod_26().TabIndex = 21;
			this.vmethod_28().BackColor = Color.Transparent;
			this.vmethod_28().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_28().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_28().Font = new Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_28().FormattingEnabled = true;
			this.vmethod_28().Items.AddRange(new object[]
			{
				"All",
				"Selected Task Pool (or Mission) ",
				"Selected Package (or Mission)",
				"Selected Flight",
				"Do not show"
			});
			this.vmethod_28().Location = new Point(93, 3);
			this.vmethod_28().Name = "ComboBox_AirTaskingOrderFilter";
			this.vmethod_28().Size = new Size(451, 21);
			this.vmethod_28().TabIndex = 22;
			this.vmethod_30().method_2(true);
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Location = new Point(1, 30);
			this.vmethod_30().Name = "Label3";
			this.vmethod_30().Size = new Size(89, 15);
			this.vmethod_30().TabIndex = 19;
			this.vmethod_30().Text = "Sort flights by...";
			this.vmethod_32().method_2(true);
			this.vmethod_32().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_32().Location = new Point(1, 7);
			this.vmethod_32().Name = "Label4";
			this.vmethod_32().Size = new Size(99, 15);
			this.vmethod_32().TabIndex = 20;
			this.vmethod_32().Text = "Show flights for...";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1008, 691);
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_32());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AirTaskingOrder";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Air Tasking Order (ATO)";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600691D RID: 26909 RVA: 0x00042D05 File Offset: 0x00040F05
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x0600691E RID: 26910 RVA: 0x0039002C File Offset: 0x0038E22C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class114 class114_1)
		{
			DataGridViewCellPaintingEventHandler value = new DataGridViewCellPaintingEventHandler(this.method_12);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_14);
			DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.method_16);
			EventHandler value4 = new EventHandler(this.method_17);
			EventHandler value5 = new EventHandler(this.method_20);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.CellPainting -= value;
				@class.CellClick -= value2;
				@class.CellValueChanged -= value3;
				@class.CurrentCellDirtyStateChanged -= value4;
				@class.SelectionChanged -= value5;
			}
			this.class114_0 = class114_1;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.CellPainting += value;
				@class.CellClick += value2;
				@class.CellValueChanged += value3;
				@class.CurrentCellDirtyStateChanged += value4;
				@class.SelectionChanged += value5;
			}
		}

		// Token: 0x0600691F RID: 26911 RVA: 0x00042D0D File Offset: 0x00040F0D
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_0;
		}

		// Token: 0x06006920 RID: 26912 RVA: 0x00042D15 File Offset: 0x00040F15
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_4)
		{
			this.class116_0 = class116_4;
		}

		// Token: 0x06006921 RID: 26913 RVA: 0x00042D1E File Offset: 0x00040F1E
		[CompilerGenerated]
		internal Class2451 vmethod_4()
		{
			return this.class2451_0;
		}

		// Token: 0x06006922 RID: 26914 RVA: 0x003900EC File Offset: 0x0038E2EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class2451 class2451_4)
		{
			EventHandler value = new EventHandler(this.method_24);
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

		// Token: 0x06006923 RID: 26915 RVA: 0x00042D26 File Offset: 0x00040F26
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_0;
		}

		// Token: 0x06006924 RID: 26916 RVA: 0x00390130 File Offset: 0x0038E330
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_21);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_8;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006925 RID: 26917 RVA: 0x00042D2E File Offset: 0x00040F2E
		[CompilerGenerated]
		internal Control9 vmethod_8()
		{
			return this.control9_1;
		}

		// Token: 0x06006926 RID: 26918 RVA: 0x00390174 File Offset: 0x0038E374
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_19);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_8;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x00042D36 File Offset: 0x00040F36
		[CompilerGenerated]
		internal Control9 vmethod_10()
		{
			return this.control9_2;
		}

		// Token: 0x06006928 RID: 26920 RVA: 0x003901B8 File Offset: 0x0038E3B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_26);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_8;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006929 RID: 26921 RVA: 0x00042D3E File Offset: 0x00040F3E
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_3;
		}

		// Token: 0x0600692A RID: 26922 RVA: 0x003901FC File Offset: 0x0038E3FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_23);
			Control9 control = this.control9_3;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_3 = control9_8;
			control = this.control9_3;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600692B RID: 26923 RVA: 0x00042D46 File Offset: 0x00040F46
		[CompilerGenerated]
		internal Class116 vmethod_14()
		{
			return this.class116_1;
		}

		// Token: 0x0600692C RID: 26924 RVA: 0x00042D4E File Offset: 0x00040F4E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class116 class116_4)
		{
			this.class116_1 = class116_4;
		}

		// Token: 0x0600692D RID: 26925 RVA: 0x00042D57 File Offset: 0x00040F57
		[CompilerGenerated]
		internal Class2451 vmethod_16()
		{
			return this.class2451_1;
		}

		// Token: 0x0600692E RID: 26926 RVA: 0x00390240 File Offset: 0x0038E440
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class2451 class2451_4)
		{
			EventHandler value = new EventHandler(this.method_25);
			Class2451 @class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_1 = class2451_4;
			@class = this.class2451_1;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600692F RID: 26927 RVA: 0x00042D5F File Offset: 0x00040F5F
		[CompilerGenerated]
		internal Control9 vmethod_18()
		{
			return this.control9_4;
		}

		// Token: 0x06006930 RID: 26928 RVA: 0x00390284 File Offset: 0x0038E484
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_22);
			Control9 control = this.control9_4;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_4 = control9_8;
			control = this.control9_4;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006931 RID: 26929 RVA: 0x00042D67 File Offset: 0x00040F67
		[CompilerGenerated]
		internal Control9 vmethod_20()
		{
			return this.control9_5;
		}

		// Token: 0x06006932 RID: 26930 RVA: 0x003902C8 File Offset: 0x0038E4C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_27);
			Control9 control = this.control9_5;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_5 = control9_8;
			control = this.control9_5;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006933 RID: 26931 RVA: 0x00042D6F File Offset: 0x00040F6F
		[CompilerGenerated]
		internal Control9 vmethod_22()
		{
			return this.control9_6;
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x0039030C File Offset: 0x0038E50C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_28);
			Control9 control = this.control9_6;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_6 = control9_8;
			control = this.control9_6;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x00042D77 File Offset: 0x00040F77
		[CompilerGenerated]
		internal Control9 vmethod_24()
		{
			return this.control9_7;
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x00390350 File Offset: 0x0038E550
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Control9 control9_8)
		{
			EventHandler value = new EventHandler(this.method_29);
			Control9 control = this.control9_7;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_7 = control9_8;
			control = this.control9_7;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06006937 RID: 26935 RVA: 0x00042D7F File Offset: 0x00040F7F
		[CompilerGenerated]
		internal Class2451 vmethod_26()
		{
			return this.class2451_2;
		}

		// Token: 0x06006938 RID: 26936 RVA: 0x00390394 File Offset: 0x0038E594
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class2451 class2451_4)
		{
			EventHandler value = new EventHandler(this.method_33);
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

		// Token: 0x06006939 RID: 26937 RVA: 0x00042D87 File Offset: 0x00040F87
		[CompilerGenerated]
		internal Class2451 vmethod_28()
		{
			return this.class2451_3;
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x003903D8 File Offset: 0x0038E5D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Class2451 class2451_4)
		{
			EventHandler value = new EventHandler(this.method_32);
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

		// Token: 0x0600693B RID: 26939 RVA: 0x00042D8F File Offset: 0x00040F8F
		[CompilerGenerated]
		internal Class116 vmethod_30()
		{
			return this.class116_2;
		}

		// Token: 0x0600693C RID: 26940 RVA: 0x00042D97 File Offset: 0x00040F97
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class116 class116_4)
		{
			this.class116_2 = class116_4;
		}

		// Token: 0x0600693D RID: 26941 RVA: 0x00042DA0 File Offset: 0x00040FA0
		[CompilerGenerated]
		internal Class116 vmethod_32()
		{
			return this.class116_3;
		}

		// Token: 0x0600693E RID: 26942 RVA: 0x00042DA8 File Offset: 0x00040FA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Class116 class116_4)
		{
			this.class116_3 = class116_4;
		}

		// Token: 0x0600693F RID: 26943 RVA: 0x00042DB1 File Offset: 0x00040FB1
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_34()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x00042DB9 File Offset: 0x00040FB9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x00042DC2 File Offset: 0x00040FC2
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_36()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x00042DCA File Offset: 0x00040FCA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x00042DD3 File Offset: 0x00040FD3
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_38()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x00042DDB File Offset: 0x00040FDB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06006945 RID: 26949 RVA: 0x00042DE4 File Offset: 0x00040FE4
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_40()
		{
			return this.dataGridViewComboBoxColumn_0;
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x00042DEC File Offset: 0x00040FEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_5)
		{
			this.dataGridViewComboBoxColumn_0 = dataGridViewComboBoxColumn_5;
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x00042DF5 File Offset: 0x00040FF5
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_42()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x00042DFD File Offset: 0x00040FFD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x00042E06 File Offset: 0x00041006
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_44()
		{
			return this.dataGridViewComboBoxColumn_1;
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x00042E0E File Offset: 0x0004100E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_5)
		{
			this.dataGridViewComboBoxColumn_1 = dataGridViewComboBoxColumn_5;
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x00042E17 File Offset: 0x00041017
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_46()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x00042E1F File Offset: 0x0004101F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x00042E28 File Offset: 0x00041028
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_48()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x00042E30 File Offset: 0x00041030
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x00042E39 File Offset: 0x00041039
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_50()
		{
			return this.dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x00042E41 File Offset: 0x00041041
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x00042E4A File Offset: 0x0004104A
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_52()
		{
			return this.dataGridViewTextBoxColumn_7;
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x00042E52 File Offset: 0x00041052
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_7 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x00042E5B File Offset: 0x0004105B
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_54()
		{
			return this.dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x00042E63 File Offset: 0x00041063
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_8 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06006955 RID: 26965 RVA: 0x00042E6C File Offset: 0x0004106C
		[CompilerGenerated]
		internal DataGridViewImageColumn vmethod_56()
		{
			return this.dataGridViewImageColumn_0;
		}

		// Token: 0x06006956 RID: 26966 RVA: 0x00042E74 File Offset: 0x00041074
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(DataGridViewImageColumn dataGridViewImageColumn_2)
		{
			this.dataGridViewImageColumn_0 = dataGridViewImageColumn_2;
		}

		// Token: 0x06006957 RID: 26967 RVA: 0x00042E7D File Offset: 0x0004107D
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_58()
		{
			return this.dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06006958 RID: 26968 RVA: 0x00042E85 File Offset: 0x00041085
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_9 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06006959 RID: 26969 RVA: 0x00042E8E File Offset: 0x0004108E
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_60()
		{
			return this.dataGridViewTextBoxColumn_10;
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x00042E96 File Offset: 0x00041096
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_10 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x0600695B RID: 26971 RVA: 0x00042E9F File Offset: 0x0004109F
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_62()
		{
			return this.dataGridViewTextBoxColumn_11;
		}

		// Token: 0x0600695C RID: 26972 RVA: 0x00042EA7 File Offset: 0x000410A7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_11 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x0600695D RID: 26973 RVA: 0x00042EB0 File Offset: 0x000410B0
		[CompilerGenerated]
		internal DataGridViewImageColumn vmethod_64()
		{
			return this.dataGridViewImageColumn_1;
		}

		// Token: 0x0600695E RID: 26974 RVA: 0x00042EB8 File Offset: 0x000410B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(DataGridViewImageColumn dataGridViewImageColumn_2)
		{
			this.dataGridViewImageColumn_1 = dataGridViewImageColumn_2;
		}

		// Token: 0x0600695F RID: 26975 RVA: 0x00042EC1 File Offset: 0x000410C1
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_66()
		{
			return this.dataGridViewTextBoxColumn_12;
		}

		// Token: 0x06006960 RID: 26976 RVA: 0x00042EC9 File Offset: 0x000410C9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_12 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06006961 RID: 26977 RVA: 0x00042ED2 File Offset: 0x000410D2
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_68()
		{
			return this.dataGridViewTextBoxColumn_13;
		}

		// Token: 0x06006962 RID: 26978 RVA: 0x00042EDA File Offset: 0x000410DA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_13 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06006963 RID: 26979 RVA: 0x00042EE3 File Offset: 0x000410E3
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_70()
		{
			return this.dataGridViewTextBoxColumn_14;
		}

		// Token: 0x06006964 RID: 26980 RVA: 0x00042EEB File Offset: 0x000410EB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_14 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x00042EF4 File Offset: 0x000410F4
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_72()
		{
			return this.dataGridViewComboBoxColumn_2;
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x00042EFC File Offset: 0x000410FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_5)
		{
			this.dataGridViewComboBoxColumn_2 = dataGridViewComboBoxColumn_5;
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x00042F05 File Offset: 0x00041105
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_74()
		{
			return this.dataGridViewComboBoxColumn_3;
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x00042F0D File Offset: 0x0004110D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_5)
		{
			this.dataGridViewComboBoxColumn_3 = dataGridViewComboBoxColumn_5;
		}

		// Token: 0x06006969 RID: 26985 RVA: 0x00042F16 File Offset: 0x00041116
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_76()
		{
			return this.dataGridViewTextBoxColumn_15;
		}

		// Token: 0x0600696A RID: 26986 RVA: 0x00042F1E File Offset: 0x0004111E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_15 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x0600696B RID: 26987 RVA: 0x00042F27 File Offset: 0x00041127
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_78()
		{
			return this.dataGridViewTextBoxColumn_16;
		}

		// Token: 0x0600696C RID: 26988 RVA: 0x00042F2F File Offset: 0x0004112F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_16 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x0600696D RID: 26989 RVA: 0x00042F38 File Offset: 0x00041138
		[CompilerGenerated]
		internal DataGridViewComboBoxColumn vmethod_80()
		{
			return this.dataGridViewComboBoxColumn_4;
		}

		// Token: 0x0600696E RID: 26990 RVA: 0x00042F40 File Offset: 0x00041140
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_5)
		{
			this.dataGridViewComboBoxColumn_4 = dataGridViewComboBoxColumn_5;
		}

		// Token: 0x0600696F RID: 26991 RVA: 0x00042F49 File Offset: 0x00041149
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_82()
		{
			return this.dataGridViewTextBoxColumn_17;
		}

		// Token: 0x06006970 RID: 26992 RVA: 0x00042F51 File Offset: 0x00041151
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_17 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06006971 RID: 26993 RVA: 0x00042F5A File Offset: 0x0004115A
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_84()
		{
			return this.dataGridViewTextBoxColumn_18;
		}

		// Token: 0x06006972 RID: 26994 RVA: 0x00042F62 File Offset: 0x00041162
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19)
		{
			this.dataGridViewTextBoxColumn_18 = dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06006973 RID: 26995 RVA: 0x0039041C File Offset: 0x0038E61C
		private void method_3(Class310 class310_0)
		{
			try
			{
				if (!Information.IsNothing(class310_0))
				{
					this.method_5();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200631", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006974 RID: 26996 RVA: 0x00042F6B File Offset: 0x0004116B
		private void AirTaskingOrder_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06006975 RID: 26997 RVA: 0x00042F89 File Offset: 0x00041189
		private void AirTaskingOrder_FormClosed(object sender, FormClosedEventArgs e)
		{
			MissionEditor.smethod_1(new MissionEditor.Delegate95(this.method_3));
		}

		// Token: 0x06006976 RID: 26998 RVA: 0x00042F9C File Offset: 0x0004119C
		private void AirTaskingOrder_Load(object sender, EventArgs e)
		{
			MissionEditor.smethod_0(new MissionEditor.Delegate95(this.method_3));
		}

		// Token: 0x06006977 RID: 26999 RVA: 0x00042FAF File Offset: 0x000411AF
		private void AirTaskingOrder_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				this.method_4();
			}
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06006978 RID: 27000 RVA: 0x00042FD4 File Offset: 0x000411D4
		public void method_4()
		{
			this.method_8();
			this.method_7();
		}

		// Token: 0x06006979 RID: 27001 RVA: 0x00042FE2 File Offset: 0x000411E2
		public void method_5()
		{
			this.method_9();
		}

		// Token: 0x0600697A RID: 27002 RVA: 0x00042FEA File Offset: 0x000411EA
		public void method_6()
		{
			this.method_4();
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x0600697B RID: 27003 RVA: 0x00390484 File Offset: 0x0038E684
		public void method_7()
		{
			this.vmethod_16().SelectedIndex = (int)Class570.class280_0.method_34();
			this.vmethod_4().SelectedIndex = (int)Class570.class280_0.method_36();
			this.vmethod_28().Items.Clear();
			this.vmethod_28().Items.Insert(0, "Missions and packages included in the ATO");
			this.vmethod_28().Items.Insert(1, "All missions and packages, including those not in the ATO");
			int num = 2;
			bool flag = false;
			try
			{
				foreach (Mission mission in Client.smethod_50().method_35())
				{
					this.vmethod_28().Items.Insert(num, mission.Name);
					if (Operators.CompareString(mission.string_0, this.string_1, false) == 0)
					{
						this.vmethod_28().SelectedIndex = num;
						flag = true;
					}
					num++;
				}
			}
			finally
			{
				IEnumerator<Mission> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			if (!flag)
			{
				this.vmethod_28().SelectedIndex = 0;
			}
			this.vmethod_26().Items.Clear();
			this.vmethod_26().Items.Insert(0, "Mission/Package/Task Pool - Take-Off Time - Task Type - Aircraft - Loadout");
			this.vmethod_26().Items.Insert(1, "Take-Off Time - Task Type - Aircraft - Loadout");
			this.vmethod_26().Items.Insert(2, "Objective Time - Task Type - Aircraft - Loadout");
			this.vmethod_26().SelectedIndex = (int)this.enum200_0;
		}

		// Token: 0x0600697C RID: 27004 RVA: 0x003905E8 File Offset: 0x0038E7E8
		private void method_8()
		{
			try
			{
				int num;
				if (!Information.IsNothing(this.vmethod_0()))
				{
					num = this.vmethod_0().SelectedRows.Count;
					if (num > 0)
					{
						this.int_0 = this.vmethod_0().SelectedRows[0].Index;
						this.flight_0 = (Mission.Flight)this.vmethod_0().SelectedRows[0].Tag;
						if (!Information.IsNothing(this.flight_0))
						{
							this.string_0 = this.flight_0.string_0;
							this.mission_0 = Enumerable.ElementAtOrDefault<Mission>(Enumerable.Where<Mission>(Client.smethod_50().method_35(), new Func<Mission, bool>(this.method_34)), 0);
						}
					}
				}
				else
				{
					num = 0;
					this.int_0 = 0;
					this.string_0 = "";
					this.flight_0 = null;
					this.mission_0 = null;
				}
				this.bool_3 = false;
				this.dataTable_0.Clear();
				this.list_0.Clear();
				this.bool_3 = true;
				if (!this.dataTable_0.Columns.Contains("ID"))
				{
					this.dataTable_0.Columns.Add("ID", typeof(string));
					this.int_1 = 0;
				}
				if (!this.dataTable_0.Columns.Contains("MissionOrPackage"))
				{
					this.dataTable_0.Columns.Add("MissionOrPackage", typeof(string));
					this.int_2 = 1;
				}
				if (!this.dataTable_0.Columns.Contains("Callsign"))
				{
					this.dataTable_0.Columns.Add("Callsign", typeof(string));
					this.int_3 = 2;
				}
				if (!this.dataTable_0.Columns.Contains("Type"))
				{
					this.dataTable_0.Columns.Add("Type", typeof(int));
					this.int_4 = 3;
				}
				if (!this.dataTable_0.Columns.Contains("Status"))
				{
					this.dataTable_0.Columns.Add("Status", typeof(string));
					this.int_6 = 4;
				}
				if (!this.dataTable_0.Columns.Contains("Task"))
				{
					this.dataTable_0.Columns.Add("Task", typeof(int));
					this.int_5 = 5;
				}
				if (!this.dataTable_0.Columns.Contains("AircraftType"))
				{
					this.dataTable_0.Columns.Add("AircraftType", typeof(string));
					this.int_7 = 6;
				}
				if (!this.dataTable_0.Columns.Contains("LoadoutType"))
				{
					this.dataTable_0.Columns.Add("LoadoutType", typeof(string));
					this.int_8 = 7;
				}
				if (!this.dataTable_0.Columns.Contains("TakeOffTimeZulu"))
				{
					this.dataTable_0.Columns.Add("TakeOffTimeZulu", typeof(string));
					this.int_9 = 8;
				}
				if (!this.dataTable_0.Columns.Contains("TakeOffTimeLocal"))
				{
					this.dataTable_0.Columns.Add("TakeOffTimeLocal", typeof(string));
					this.int_10 = 9;
				}
				if (!this.dataTable_0.Columns.Contains("TakeOffTimeFixed"))
				{
					this.dataTable_0.Columns.Add("TakeOffTimeFixed", typeof(int));
					this.int_25 = 10;
				}
				if (!this.dataTable_0.Columns.Contains("TakeOffTimeImg"))
				{
					this.dataTable_0.Columns.Add("TakeOffTimeImg", typeof(Image));
					this.int_11 = 11;
				}
				if (!this.dataTable_0.Columns.Contains("ObjectiveTimeZulu"))
				{
					this.dataTable_0.Columns.Add("ObjectiveTimeZulu", typeof(string));
					this.int_12 = 12;
				}
				if (!this.dataTable_0.Columns.Contains("ObjectiveTimeLocal"))
				{
					this.dataTable_0.Columns.Add("ObjectiveTimeLocal", typeof(string));
					this.int_13 = 13;
				}
				if (!this.dataTable_0.Columns.Contains("ObjectiveTimeFixed"))
				{
					this.dataTable_0.Columns.Add("ObjectiveTimeFixed", typeof(int));
					this.int_26 = 14;
				}
				if (!this.dataTable_0.Columns.Contains("ObjectiveTimeImg"))
				{
					this.dataTable_0.Columns.Add("ObjectiveTimeImg", typeof(Image));
					this.int_14 = 15;
				}
				if (!this.dataTable_0.Columns.Contains("TakeOffLocation"))
				{
					this.dataTable_0.Columns.Add("TakeOffLocation", typeof(string));
					this.int_15 = 16;
				}
				if (!this.dataTable_0.Columns.Contains("LandingLocation"))
				{
					this.dataTable_0.Columns.Add("LandingLocation", typeof(string));
					this.int_16 = 17;
				}
				if (!this.dataTable_0.Columns.Contains("AlternativeLandingLocation"))
				{
					this.dataTable_0.Columns.Add("AlternativeLandingLocation", typeof(string));
					this.int_17 = 18;
				}
				if (!this.dataTable_0.Columns.Contains("DesiredAircraftQty"))
				{
					this.dataTable_0.Columns.Add("DesiredAircraftQty", typeof(int));
					this.int_18 = 19;
				}
				if (!this.dataTable_0.Columns.Contains("MinimumAircraftQty"))
				{
					this.dataTable_0.Columns.Add("MinimumAircraftQty", typeof(int));
					this.int_19 = 20;
				}
				if (!this.dataTable_0.Columns.Contains("AssignedAircraftQty"))
				{
					this.dataTable_0.Columns.Add("AssignedAircraftQty", typeof(int));
					this.int_20 = 21;
				}
				if (!this.dataTable_0.Columns.Contains("ReadyAircraftQty"))
				{
					this.dataTable_0.Columns.Add("ReadyAircraftQty", typeof(int));
					this.int_21 = 22;
				}
				if (!this.dataTable_0.Columns.Contains("Priority"))
				{
					this.dataTable_0.Columns.Add("Priority", typeof(int));
					this.int_22 = 23;
				}
				if (!this.dataTable_0.Columns.Contains("CreatedBy"))
				{
					this.dataTable_0.Columns.Add("CreatedBy", typeof(string));
					this.int_23 = 24;
				}
				if (!this.dataTable_0.Columns.Contains("EditedBy"))
				{
					this.dataTable_0.Columns.Add("EditedBy", typeof(string));
					this.int_24 = 25;
				}
				DataTable dataSource = new DataTable();
				DataTable dataSource2 = new DataTable();
				DataTable dataSource3 = new DataTable();
				DataTable dataSource4 = new DataTable();
				DataTable dataSource5 = new DataTable();
				DataGridViewComboBoxColumn dataGridViewComboBoxColumn = (DataGridViewComboBoxColumn)this.vmethod_0().Columns[this.vmethod_0().Columns["Task"].Index];
				DataGridViewComboBoxColumn dataGridViewComboBoxColumn2 = (DataGridViewComboBoxColumn)this.vmethod_0().Columns[this.vmethod_0().Columns["Priority"].Index];
				DataGridViewComboBoxColumn dataGridViewComboBoxColumn3 = (DataGridViewComboBoxColumn)this.vmethod_0().Columns[this.vmethod_0().Columns["DesiredAircraftQty"].Index];
				DataGridViewComboBoxColumn dataGridViewComboBoxColumn4 = (DataGridViewComboBoxColumn)this.vmethod_0().Columns[this.vmethod_0().Columns["MinimumAircraftQty"].Index];
				DataGridViewComboBoxColumn dataGridViewComboBoxColumn5 = (DataGridViewComboBoxColumn)this.vmethod_0().Columns[this.vmethod_0().Columns["Type"].Index];
				Mission.Flight.smethod_14(ref dataSource);
				Mission.Flight.smethod_4(ref dataSource2);
				Mission.Flight.smethod_7(ref dataSource3);
				Mission.Flight.smethod_11(ref dataSource4);
				Mission.Flight.smethod_11(ref dataSource5);
				DataGridViewComboBoxColumn dataGridViewComboBoxColumn6 = dataGridViewComboBoxColumn;
				dataGridViewComboBoxColumn6.DataSource = dataSource2;
				dataGridViewComboBoxColumn6.DisplayMember = "Description";
				dataGridViewComboBoxColumn6.ValueMember = "ID";
				DataGridViewComboBoxColumn dataGridViewComboBoxColumn7 = dataGridViewComboBoxColumn2;
				dataGridViewComboBoxColumn7.DataSource = dataSource3;
				dataGridViewComboBoxColumn7.DisplayMember = "Description";
				dataGridViewComboBoxColumn7.ValueMember = "ID";
				DataGridViewComboBoxColumn dataGridViewComboBoxColumn8 = dataGridViewComboBoxColumn3;
				dataGridViewComboBoxColumn8.DataSource = dataSource4;
				dataGridViewComboBoxColumn8.DisplayMember = "Description";
				dataGridViewComboBoxColumn8.ValueMember = "ID";
				DataGridViewComboBoxColumn dataGridViewComboBoxColumn9 = dataGridViewComboBoxColumn4;
				dataGridViewComboBoxColumn9.DataSource = dataSource5;
				dataGridViewComboBoxColumn9.DisplayMember = "Description";
				dataGridViewComboBoxColumn9.ValueMember = "ID";
				dataGridViewComboBoxColumn5.DataSource = dataSource;
				dataGridViewComboBoxColumn5.DisplayMember = "Description";
				dataGridViewComboBoxColumn5.ValueMember = "ID";
				this.bool_3 = false;
				if (!string.IsNullOrEmpty(this.string_1) && Operators.CompareString(this.string_1, "Filter_ATO_Only", false) != 0 && Operators.CompareString(this.string_1, "Filter_All", false) != 0)
				{
					try
					{
						foreach (Mission mission in Client.smethod_50().method_35())
						{
							if ((Operators.CompareString(mission.string_0, this.string_1, false) == 0 || Operators.CompareString(mission.method_13(Client.smethod_50()), this.string_1, false) == 0) && mission.enum88_0 != Mission.Enum88.const_2)
							{
								try
								{
									foreach (Mission.Flight item in mission.list_1)
									{
										this.list_0.Add(item);
									}
								}
								finally
								{
									List<Mission.Flight>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
								IL_A00:
								goto IL_AA1;
							}
						}
						goto IL_A00;
					}
					finally
					{
						IEnumerator<Mission> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				try
				{
					foreach (Mission mission2 in Client.smethod_50().method_35())
					{
						if (Operators.CompareString(this.string_1, "Filter_ATO_Only", false) != 0 || mission2.bool_16)
						{
							try
							{
								foreach (Mission.Flight item2 in mission2.list_1)
								{
									this.list_0.Add(item2);
								}
							}
							finally
							{
								List<Mission.Flight>.Enumerator enumerator4;
								((IDisposable)enumerator4).Dispose();
							}
						}
					}
				}
				finally
				{
					IEnumerator<Mission> enumerator3;
					if (enumerator3 != null)
					{
						enumerator3.Dispose();
					}
				}
				IL_AA1:
				if (this.list_0.Count != 0)
				{
					try
					{
						foreach (Mission.Flight flight in this.list_0)
						{
							Scenario scenario = Client.smethod_46();
							flight.method_9(ref scenario);
						}
					}
					finally
					{
						List<Mission.Flight>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
					switch (this.enum200_0)
					{
					case AirTaskingOrder.Enum200.const_0:
						this.list_0 = Enumerable.ToList<Mission.Flight>(Enumerable.ThenBy<Mission.Flight, string>(Enumerable.ThenBy<Mission.Flight, string>(Enumerable.ThenBy<Mission.Flight, Mission._FlightTask>(Enumerable.ThenBy<Mission.Flight, string>(Enumerable.OrderBy<Mission.Flight, string>(this.list_0, (AirTaskingOrder._Closure$__.$I226-1 == null) ? (AirTaskingOrder._Closure$__.$I226-1 = new Func<Mission.Flight, string>(AirTaskingOrder._Closure$__.$I.method_0)) : AirTaskingOrder._Closure$__.$I226-1), (AirTaskingOrder._Closure$__.$I226-2 == null) ? (AirTaskingOrder._Closure$__.$I226-2 = new Func<Mission.Flight, string>(AirTaskingOrder._Closure$__.$I.method_1)) : AirTaskingOrder._Closure$__.$I226-2), (AirTaskingOrder._Closure$__.$I226-3 == null) ? (AirTaskingOrder._Closure$__.$I226-3 = new Func<Mission.Flight, Mission._FlightTask>(AirTaskingOrder._Closure$__.$I.method_2)) : AirTaskingOrder._Closure$__.$I226-3), (AirTaskingOrder._Closure$__.$I226-4 == null) ? (AirTaskingOrder._Closure$__.$I226-4 = new Func<Mission.Flight, string>(AirTaskingOrder._Closure$__.$I.method_3)) : AirTaskingOrder._Closure$__.$I226-4), (AirTaskingOrder._Closure$__.$I226-5 == null) ? (AirTaskingOrder._Closure$__.$I226-5 = new Func<Mission.Flight, string>(AirTaskingOrder._Closure$__.$I.method_4)) : AirTaskingOrder._Closure$__.$I226-5));
						break;
					case AirTaskingOrder.Enum200.const_1:
						this.list_0 = Enumerable.ToList<Mission.Flight>(Enumerable.ThenBy<Mission.Flight, string>(Enumerable.ThenBy<Mission.Flight, string>(Enumerable.ThenBy<Mission.Flight, Mission._FlightTask>(Enumerable.OrderBy<Mission.Flight, string>(this.list_0, (AirTaskingOrder._Closure$__.$I226-6 == null) ? (AirTaskingOrder._Closure$__.$I226-6 = new Func<Mission.Flight, string>(AirTaskingOrder._Closure$__.$I.method_5)) : AirTaskingOrder._Closure$__.$I226-6), (AirTaskingOrder._Closure$__.$I226-7 == null) ? (AirTaskingOrder._Closure$__.$I226-7 = new Func<Mission.Flight, Mission._FlightTask>(AirTaskingOrder._Closure$__.$I.method_6)) : AirTaskingOrder._Closure$__.$I226-7), (AirTaskingOrder._Closure$__.$I226-8 == null) ? (AirTaskingOrder._Closure$__.$I226-8 = new Func<Mission.Flight, string>(AirTaskingOrder._Closure$__.$I.method_7)) : AirTaskingOrder._Closure$__.$I226-8), (AirTaskingOrder._Closure$__.$I226-9 == null) ? (AirTaskingOrder._Closure$__.$I226-9 = new Func<Mission.Flight, string>(AirTaskingOrder._Closure$__.$I.method_8)) : AirTaskingOrder._Closure$__.$I226-9));
						break;
					case AirTaskingOrder.Enum200.const_2:
						this.list_0 = Enumerable.ToList<Mission.Flight>(Enumerable.ThenBy<Mission.Flight, string>(Enumerable.ThenBy<Mission.Flight, string>(Enumerable.ThenBy<Mission.Flight, Mission._FlightTask>(Enumerable.OrderBy<Mission.Flight, string>(this.list_0, (AirTaskingOrder._Closure$__.$I226-10 == null) ? (AirTaskingOrder._Closure$__.$I226-10 = new Func<Mission.Flight, string>(AirTaskingOrder._Closure$__.$I.method_9)) : AirTaskingOrder._Closure$__.$I226-10), (AirTaskingOrder._Closure$__.$I226-11 == null) ? (AirTaskingOrder._Closure$__.$I226-11 = new Func<Mission.Flight, Mission._FlightTask>(AirTaskingOrder._Closure$__.$I.method_10)) : AirTaskingOrder._Closure$__.$I226-11), (AirTaskingOrder._Closure$__.$I226-12 == null) ? (AirTaskingOrder._Closure$__.$I226-12 = new Func<Mission.Flight, string>(AirTaskingOrder._Closure$__.$I.method_11)) : AirTaskingOrder._Closure$__.$I226-12), (AirTaskingOrder._Closure$__.$I226-13 == null) ? (AirTaskingOrder._Closure$__.$I226-13 = new Func<Mission.Flight, string>(AirTaskingOrder._Closure$__.$I.method_12)) : AirTaskingOrder._Closure$__.$I226-13));
						break;
					default:
						this.list_0 = Enumerable.ToList<Mission.Flight>(Enumerable.ThenBy<Mission.Flight, string>(Enumerable.ThenBy<Mission.Flight, string>(Enumerable.ThenBy<Mission.Flight, Mission._FlightTask>(Enumerable.ThenBy<Mission.Flight, string>(Enumerable.OrderBy<Mission.Flight, string>(this.list_0, (AirTaskingOrder._Closure$__.$I226-14 == null) ? (AirTaskingOrder._Closure$__.$I226-14 = new Func<Mission.Flight, string>(AirTaskingOrder._Closure$__.$I.method_13)) : AirTaskingOrder._Closure$__.$I226-14), (AirTaskingOrder._Closure$__.$I226-15 == null) ? (AirTaskingOrder._Closure$__.$I226-15 = new Func<Mission.Flight, string>(AirTaskingOrder._Closure$__.$I.method_14)) : AirTaskingOrder._Closure$__.$I226-15), (AirTaskingOrder._Closure$__.$I226-16 == null) ? (AirTaskingOrder._Closure$__.$I226-16 = new Func<Mission.Flight, Mission._FlightTask>(AirTaskingOrder._Closure$__.$I.method_15)) : AirTaskingOrder._Closure$__.$I226-16), (AirTaskingOrder._Closure$__.$I226-17 == null) ? (AirTaskingOrder._Closure$__.$I226-17 = new Func<Mission.Flight, string>(AirTaskingOrder._Closure$__.$I.method_16)) : AirTaskingOrder._Closure$__.$I226-17), (AirTaskingOrder._Closure$__.$I226-18 == null) ? (AirTaskingOrder._Closure$__.$I226-18 = new Func<Mission.Flight, string>(AirTaskingOrder._Closure$__.$I.method_17)) : AirTaskingOrder._Closure$__.$I226-18));
						break;
					}
					try
					{
						foreach (Mission.Flight flight2 in this.list_0)
						{
							DataRow row = this.dataTable_0.NewRow();
							this.dataTable_0.Rows.Add(row);
						}
					}
					finally
					{
						List<Mission.Flight>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
					if (num == 0 && this.vmethod_0().Rows.Count > 0)
					{
						this.vmethod_0().Rows[0].Selected = false;
					}
					this.bool_3 = true;
					this.method_9();
					this.bool_3 = false;
					this.vmethod_0().DataSource = new DataView(this.dataTable_0);
					this.bool_3 = true;
					try
					{
						foreach (object obj in ((IEnumerable)this.vmethod_0().Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								foreach (Mission.Flight flight3 in this.list_0)
								{
									if (Operators.CompareString(flight3.string_0, Conversions.ToString(dataGridViewRow.Cells["ID"].Value), false) == 0)
									{
										dataGridViewRow.Tag = flight3;
										break;
									}
								}
							}
							finally
							{
								List<Mission.Flight>.Enumerator enumerator8;
								((IDisposable)enumerator8).Dispose();
							}
						}
					}
					finally
					{
						IEnumerator enumerator7;
						if (enumerator7 is IDisposable)
						{
							(enumerator7 as IDisposable).Dispose();
						}
					}
					this.bool_3 = false;
					if (this.vmethod_0().RowCount > 0)
					{
						if (this.int_0 > this.vmethod_0().RowCount - 1)
						{
							this.vmethod_0().Rows[0].Selected = false;
							this.vmethod_0().Rows[this.vmethod_0().RowCount - 1].Selected = true;
							this.flight_0 = (Mission.Flight)this.vmethod_0().SelectedRows[0].Tag;
							if (!Information.IsNothing(this.flight_0))
							{
								this.string_0 = this.flight_0.string_0;
								this.mission_0 = Enumerable.ElementAtOrDefault<Mission>(Enumerable.Where<Mission>(Client.smethod_50().method_35(), new Func<Mission, bool>(this.method_35)), 0);
							}
						}
						else
						{
							this.vmethod_0().Rows[0].Selected = false;
							this.vmethod_0().Rows[this.int_0].Selected = true;
							this.flight_0 = (Mission.Flight)this.vmethod_0().SelectedRows[0].Tag;
							if (!Information.IsNothing(this.flight_0))
							{
								this.string_0 = this.flight_0.string_0;
								this.mission_0 = Enumerable.ElementAtOrDefault<Mission>(Enumerable.Where<Mission>(Client.smethod_50().method_35(), new Func<Mission, bool>(this.method_36)), 0);
							}
						}
					}
					else
					{
						this.flight_0 = null;
						this.mission_0 = null;
					}
					this.bool_3 = true;
					if (Information.IsNothing(this.flight_0) && this.vmethod_0().SelectedRows.Count > 0)
					{
						this.flight_0 = (Mission.Flight)this.vmethod_0().SelectedRows[0].Tag;
						if (!Information.IsNothing(this.flight_0))
						{
							this.string_0 = this.flight_0.string_0;
							this.mission_0 = Enumerable.ElementAtOrDefault<Mission>(Enumerable.Where<Mission>(Client.smethod_50().method_35(), new Func<Mission, bool>(this.method_37)), 0);
						}
					}
					this.method_13();
					this.method_30();
					this.method_31();
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

		// Token: 0x0600697D RID: 27005 RVA: 0x003918C8 File Offset: 0x0038FAC8
		private void method_9()
		{
			try
			{
				AirTaskingOrder.Class2464 @class = new AirTaskingOrder.Class2464(@class);
				if (!Information.IsNothing(this.list_0) && this.list_0.Count != 0)
				{
					this.vmethod_0().SuspendLayout();
					int count = this.dataTable_0.Rows.Count;
					try
					{
						int num = count - 1;
						for (int i = 0; i <= num; i++)
						{
							DataRow dataRow = this.dataTable_0.Rows[i];
							@class.flight_0 = this.list_0[i];
							string text = @class.flight_0.string_0;
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_1]), text))
							{
								dataRow[this.int_1] = text;
							}
							if (string.IsNullOrEmpty(@class.flight_0.string_3))
							{
								try
								{
									foreach (Mission mission in Client.smethod_50().method_35())
									{
										if (mission.list_1.Contains(@class.flight_0))
										{
											@class.flight_0.string_2 = mission.string_0;
											@class.flight_0.string_3 = mission.Name;
											break;
										}
									}
								}
								finally
								{
									IEnumerator<Mission> enumerator;
									if (enumerator != null)
									{
										enumerator.Dispose();
									}
								}
							}
							string string_ = @class.flight_0.string_3;
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_2]), string_))
							{
								dataRow[this.int_2] = string_;
							}
							string string_2 = @class.flight_0.string_4;
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_3]), string_2))
							{
								dataRow[this.int_3] = string_2;
							}
							int num2 = Mission.Flight.smethod_16((int)@class.flight_0.enum93_0);
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_4]), num2))
							{
								dataRow[this.int_4] = num2;
							}
							int num3 = Mission.Flight.smethod_6((int)@class.flight_0._FlightTask_0);
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_5]), num3))
							{
								dataRow[this.int_5] = num3;
							}
							Mission.Flight flight = @class.flight_0;
							Scenario scenario = Client.smethod_46();
							flight.method_9(ref scenario);
							string string_3 = @class.flight_0.string_16;
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_9]), string_3))
							{
								dataRow[this.int_9] = string_3;
							}
							string string_4 = @class.flight_0.string_17;
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_10]), string_4))
							{
								dataRow[this.int_10] = string_4;
							}
							string string_5 = @class.flight_0.string_18;
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_12]), string_5))
							{
								dataRow[this.int_12] = string_5;
							}
							string string_6 = @class.flight_0.string_19;
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_13]), string_6))
							{
								dataRow[this.int_13] = string_6;
							}
							int enum82_ = (int)@class.flight_0.enum82_0;
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_25]), enum82_))
							{
								dataRow[this.int_25] = enum82_;
							}
							int enum82_2 = (int)@class.flight_0.enum82_1;
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_26]), enum82_2))
							{
								dataRow[this.int_26] = enum82_2;
							}
							string text2 = @class.flight_0.string_12;
							if (string.IsNullOrEmpty(text2))
							{
								text2 = "Not set";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_7]), text2))
							{
								dataRow[this.int_7] = text2;
							}
							string text3 = @class.flight_0.method_13(Client.smethod_46());
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_8]), text3))
							{
								dataRow[this.int_8] = text3;
							}
							string text4 = @class.flight_0.string_6;
							if (string.IsNullOrEmpty(text4))
							{
								text4 = "Not set";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_15]), text4))
							{
								dataRow[this.int_15] = text4;
							}
							string text5 = @class.flight_0.string_8;
							if (string.IsNullOrEmpty(text5))
							{
								text5 = "Not set";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_16]), text5))
							{
								dataRow[this.int_16] = text5;
							}
							string value = @class.flight_0.string_10;
							if (string.IsNullOrEmpty(value))
							{
								value = "-";
							}
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_17]), text3))
							{
								dataRow[this.int_17] = value;
							}
							string text6 = Mission.smethod_5(@class.flight_0.method_10(Client.smethod_46()));
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_6]), text6))
							{
								dataRow[this.int_6] = text6;
							}
							int num4 = Mission.Flight.smethod_9((int)@class.flight_0.enum101_0);
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_22]), num4))
							{
								dataRow[this.int_22] = num4;
							}
							int enum103_ = (int)@class.flight_0.enum103_0;
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_23]), enum103_))
							{
								dataRow[this.int_23] = @class.flight_0.enum103_0;
							}
							int enum103_2 = (int)@class.flight_0.enum103_1;
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_24]), enum103_2))
							{
								dataRow[this.int_24] = @class.flight_0.enum103_1;
							}
							int num5 = Mission.Flight.smethod_13((int)@class.flight_0._FlightSize_0);
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_18]), num5))
							{
								dataRow[this.int_18] = num5;
							}
							int num6 = Mission.Flight.smethod_13((int)@class.flight_0._FlightSize_1);
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_19]), num6))
							{
								dataRow[this.int_19] = num6;
							}
							Enumerable.ElementAtOrDefault<Mission>(Enumerable.Where<Mission>(Client.smethod_50().method_35(), (@class.func_0 == null) ? (@class.func_0 = new Func<Mission, bool>(@class.method_0)) : @class.func_0), 0).method_17(Client.smethod_46(), @class.flight_0);
							int num7 = @class.flight_0.int_0;
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_20]), num7))
							{
								dataRow[this.int_20] = num7;
							}
							int num8 = @class.flight_0.int_1;
							if (!object.Equals(RuntimeHelpers.GetObjectValue(dataRow[this.int_21]), num8))
							{
								dataRow[this.int_21] = num8;
							}
						}
					}
					finally
					{
						this.vmethod_0().ResumeLayout();
					}
					if (this.vmethod_0().Rows.Count > 0)
					{
						this.bool_3 = false;
						this.method_10();
						if (this.vmethod_0().SelectedRows.Count > 0 && this.vmethod_0().SelectedRows[0].Index > 0 && this.int_0 != this.vmethod_0().SelectedRows[0].Index)
						{
							if (this.int_0 <= this.vmethod_0().Rows.Count - 1)
							{
								this.vmethod_0().Rows[this.int_0].Selected = false;
							}
							this.int_0 = this.vmethod_0().SelectedRows[0].Index;
						}
						this.vmethod_0().Rows[0].Selected = false;
						if (this.vmethod_0().RowCount > 0)
						{
							if (this.int_0 > this.vmethod_0().RowCount - 1)
							{
								this.vmethod_0().Rows[this.vmethod_0().RowCount - 1].Selected = false;
								this.vmethod_0().Rows[this.vmethod_0().RowCount - 1].Selected = true;
							}
							else
							{
								this.vmethod_0().Rows[this.int_0].Selected = false;
								this.vmethod_0().Rows[this.int_0].Selected = true;
							}
						}
						this.flight_0 = (Mission.Flight)this.vmethod_0().SelectedRows[0].Tag;
						if (!Information.IsNothing(this.flight_0))
						{
							this.string_0 = this.flight_0.string_0;
							this.mission_0 = Enumerable.ElementAtOrDefault<Mission>(Enumerable.Where<Mission>(Client.smethod_50().method_35(), new Func<Mission, bool>(this.method_38)), 0);
						}
						this.bool_3 = true;
					}
					else
					{
						this.flight_0 = null;
						this.mission_0 = null;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200583", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600697E RID: 27006 RVA: 0x003922AC File Offset: 0x003904AC
		private void method_10()
		{
			try
			{
				int count = this.dataTable_0.Rows.Count;
				if (!string.IsNullOrEmpty(this.string_0))
				{
					int num = count - 1;
					for (int i = 0; i <= num; i++)
					{
						Mission.Flight flight = this.list_0[i];
						if (!Information.IsNothing(flight) && Operators.CompareString(flight.string_0, this.string_0, false) == 0)
						{
							int count2 = this.vmethod_0().SelectedRows.Count;
							for (int j = count2 - 1; j >= 0; j += -1)
							{
								DataGridViewRow dataGridViewRow = this.vmethod_0().SelectedRows[j];
								this.vmethod_0().Rows[dataGridViewRow.Index].Selected = false;
							}
							if (this.int_0 <= count2 - 1)
							{
								this.vmethod_0().Rows[this.int_0].Selected = false;
							}
							this.vmethod_0().Rows[i].Selected = true;
							this.int_0 = i;
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at ¨999999", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x00392400 File Offset: 0x00390600
		private void method_11()
		{
			try
			{
				int num = this.vmethod_0().Rows.Count - 1;
				if (!string.IsNullOrEmpty(this.string_0))
				{
					int num2 = num;
					for (int i = 0; i <= num2; i++)
					{
						Mission.Flight flight = this.list_0[i];
						if (!Information.IsNothing(flight) && Operators.CompareString(flight.string_0, this.string_0, false) == 0)
						{
							int count = this.vmethod_0().SelectedRows.Count;
							for (int j = count - 1; j >= 0; j += -1)
							{
								DataGridViewRow dataGridViewRow = this.vmethod_0().SelectedRows[j];
								this.vmethod_0().Rows[dataGridViewRow.Index].Selected = false;
							}
							if (this.int_0 <= count - 1)
							{
								this.vmethod_0().Rows[this.int_0].Selected = false;
							}
							this.vmethod_0().Rows[i].Selected = true;
							this.int_0 = i;
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at ¨999999", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x00392554 File Offset: 0x00390754
		private void method_12(object sender, DataGridViewCellPaintingEventArgs e)
		{
			try
			{
				if (e.RowIndex == 0 && e.ColumnIndex == this.int_10)
				{
					Rectangle cellBounds = e.CellBounds;
					cellBounds.Y += (int)Math.Round((double)e.CellBounds.Height / 2.0);
					cellBounds.Height = (int)Math.Round((double)e.CellBounds.Height / 2.0);
					e.PaintBackground(cellBounds, true);
					e.PaintContent(cellBounds);
				}
				else if (e.RowIndex == 0 && e.ColumnIndex == this.int_13)
				{
					Rectangle cellBounds2 = e.CellBounds;
					cellBounds2.Y += (int)Math.Round((double)e.CellBounds.Height / 2.0);
					cellBounds2.Height = (int)Math.Round((double)e.CellBounds.Height / 2.0);
					e.PaintBackground(cellBounds2, true);
					e.PaintContent(cellBounds2);
				}
				else if (e.RowIndex == 0)
				{
					bool flag = e.ColumnIndex == 2 | e.ColumnIndex == 3;
				}
				if (this.int_10 == e.ColumnIndex && e.RowIndex >= 0)
				{
					e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
					if (this.vmethod_0().SelectedRows.Count > 0 && this.vmethod_0().SelectedRows[0].Index == e.RowIndex)
					{
						ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.SelectionBackColor, 1, ButtonBorderStyle.Solid, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None);
					}
					else
					{
						ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None);
					}
					Rectangle cellBounds3 = e.CellBounds;
					int width = this.vmethod_0().GetCellDisplayRectangle(this.int_11, e.RowIndex, true).Width;
					cellBounds3.Width += width;
					ControlPaint.DrawBorder(e.Graphics, cellBounds3, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, Color.Red, 0, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
					e.Handled = true;
				}
				else if (this.int_13 == e.ColumnIndex && e.RowIndex >= 0)
				{
					e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
					if (this.vmethod_0().SelectedRows.Count > 0 && this.vmethod_0().SelectedRows[0].Index == e.RowIndex)
					{
						ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.SelectionBackColor, 1, ButtonBorderStyle.Solid, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None);
					}
					else
					{
						ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None);
					}
					Rectangle cellBounds4 = e.CellBounds;
					int width2 = this.vmethod_0().GetCellDisplayRectangle(this.int_14, e.RowIndex, true).Width;
					cellBounds4.Width += width2;
					ControlPaint.DrawBorder(e.Graphics, cellBounds4, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, Color.Red, 0, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
					e.Handled = true;
				}
				else if (this.int_10 == e.ColumnIndex && e.RowIndex == -1)
				{
					e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
					ControlPaint.DrawBorder(e.Graphics, e.CellBounds, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, e.CellStyle.BackColor, 1, ButtonBorderStyle.None);
					Rectangle cellBounds5 = e.CellBounds;
					cellBounds5.Width++;
					ControlPaint.DrawBorder(e.Graphics, cellBounds5, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
					cellBounds5.Y++;
					cellBounds5.Height -= 2;
					ControlPaint.DrawBorder(e.Graphics, cellBounds5, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 2, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.Solid);
					e.Handled = true;
				}
				else if (this.int_13 == e.ColumnIndex && e.RowIndex == -1)
				{
					e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
					ControlPaint.DrawBorder(e.Graphics, e.CellBounds, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, e.CellStyle.BackColor, 1, ButtonBorderStyle.None);
					Rectangle cellBounds6 = e.CellBounds;
					cellBounds6.Width++;
					ControlPaint.DrawBorder(e.Graphics, cellBounds6, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
					cellBounds6.Y++;
					cellBounds6.Height -= 2;
					ControlPaint.DrawBorder(e.Graphics, cellBounds6, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 2, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.Solid);
					e.Handled = true;
				}
				else if (this.int_11 == e.ColumnIndex && e.RowIndex == -1)
				{
					e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
					ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.None);
					Rectangle cellBounds7 = e.CellBounds;
					cellBounds7.Width++;
					ControlPaint.DrawBorder(e.Graphics, cellBounds7, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
					cellBounds7.Height -= 2;
					cellBounds7.Y++;
					ControlPaint.DrawBorder(e.Graphics, cellBounds7, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 2, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.Solid);
					e.Handled = true;
				}
				else if (this.int_14 == e.ColumnIndex && e.RowIndex == -1)
				{
					e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
					ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.None);
					Rectangle cellBounds8 = e.CellBounds;
					cellBounds8.Width++;
					ControlPaint.DrawBorder(e.Graphics, cellBounds8, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
					cellBounds8.Y++;
					cellBounds8.Height -= 2;
					ControlPaint.DrawBorder(e.Graphics, cellBounds8, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 2, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.Solid);
					e.Handled = true;
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

		// Token: 0x06006981 RID: 27009 RVA: 0x00392E78 File Offset: 0x00391078
		public void method_13()
		{
			try
			{
				this.bitmap_0.MakeTransparent(Color.White);
				this.bitmap_1.MakeTransparent(Color.White);
				this.bitmap_2.MakeTransparent(Color.White);
				this.bitmap_3.MakeTransparent(Color.White);
				this.bitmap_4.MakeTransparent(Color.White);
				bool flag = this.bool_3;
				this.bool_3 = false;
				try
				{
					foreach (object obj in ((IEnumerable)this.vmethod_0().Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[this.int_25].Value), 1))
						{
							if (dataGridViewRow.Cells[this.int_11].Value != this.bitmap_0)
							{
								dataGridViewRow.Cells[this.int_11].Value = this.bitmap_0;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[this.int_25].Value), 0))
						{
							if (dataGridViewRow.Cells[this.int_11].Value != this.bitmap_1)
							{
								dataGridViewRow.Cells[this.int_11].Value = this.bitmap_1;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[this.int_25].Value), 2))
						{
							if (dataGridViewRow.Cells[this.int_11].Value != this.bitmap_3)
							{
								dataGridViewRow.Cells[this.int_11].Value = this.bitmap_3;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[this.int_25].Value), 3))
						{
							if (dataGridViewRow.Cells[this.int_11].Value != this.bitmap_4)
							{
								dataGridViewRow.Cells[this.int_11].Value = this.bitmap_4;
							}
						}
						else if (dataGridViewRow.Cells[this.int_11].Value != this.bitmap_2)
						{
							dataGridViewRow.Cells[this.int_11].Value = this.bitmap_2;
						}
						if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[this.int_26].Value), 1))
						{
							if (dataGridViewRow.Cells[this.int_14].Value != this.bitmap_0)
							{
								dataGridViewRow.Cells[this.int_14].Value = this.bitmap_0;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[this.int_26].Value), 0))
						{
							if (dataGridViewRow.Cells[this.int_14].Value != this.bitmap_1)
							{
								dataGridViewRow.Cells[this.int_14].Value = this.bitmap_1;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[this.int_26].Value), 2))
						{
							if (dataGridViewRow.Cells[this.int_14].Value != this.bitmap_3)
							{
								dataGridViewRow.Cells[this.int_14].Value = this.bitmap_3;
							}
						}
						else if (object.Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[this.int_26].Value), 3))
						{
							if (dataGridViewRow.Cells[this.int_14].Value != this.bitmap_4)
							{
								dataGridViewRow.Cells[this.int_14].Value = this.bitmap_4;
							}
						}
						else if (dataGridViewRow.Cells[this.int_14].Value != this.bitmap_2)
						{
							dataGridViewRow.Cells[this.int_14].Value = this.bitmap_2;
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
				this.bool_3 = flag;
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

		// Token: 0x06006982 RID: 27010 RVA: 0x00393354 File Offset: 0x00391554
		private void method_14(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				bool flag5 = false;
				int num = this.vmethod_0().Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					DataGridViewRow dataGridViewRow = this.vmethod_0().Rows[i];
					if (dataGridViewRow.Selected)
					{
						this.int_0 = i;
						DataGridViewRow dataGridViewRow2 = dataGridViewRow;
						this.flight_0 = (Mission.Flight)dataGridViewRow2.Tag;
						if (!Information.IsNothing(this.flight_0))
						{
							this.string_0 = this.flight_0.string_0;
							this.mission_0 = Enumerable.ElementAtOrDefault<Mission>(Enumerable.Where<Mission>(Client.smethod_50().method_35(), new Func<Mission, bool>(this.method_39)), 0);
						}
						DataGridViewColumn dataGridViewColumn = this.vmethod_0().Columns[e.ColumnIndex];
						if (Operators.CompareString(dataGridViewColumn.Name, "Type", false) != 0)
						{
							if (Operators.CompareString(dataGridViewColumn.Name, "Task", false) != 0)
							{
								if (Operators.CompareString(dataGridViewColumn.Name, "Priority", false) != 0)
								{
									if (Operators.CompareString(dataGridViewColumn.Name, "DesiredAircraftQty", false) != 0)
									{
										if (Operators.CompareString(dataGridViewColumn.Name, "MinimumAircraftQty", false) != 0)
										{
											if (dataGridViewColumn.Index == this.int_11)
											{
												if (Enumerable.Count<Waypoint>(this.flight_0.method_15()) > 0)
												{
													int num2 = Enumerable.Count<Waypoint>(this.flight_0.method_15()) - 1;
													int j = 0;
													while (j <= num2)
													{
														Waypoint waypoint = this.flight_0.method_15()[j];
														if (!Information.IsNothing(waypoint.nullable_7))
														{
															if (waypoint.waypointType_0 != Waypoint.WaypointType.TakeOff)
															{
																j++;
																continue;
															}
															if (waypoint.enum82_0 == Waypoint.Enum82.const_0)
															{
																waypoint.enum82_0 = Waypoint.Enum82.const_1;
																this.flight_0.enum82_0 = waypoint.enum82_0;
																Mission.Flight flight_ = this.flight_0;
																Mission.Flight flight;
																Waypoint[] waypoint_ = (flight = this.flight_0).method_15();
																AirTaskingOrder.smethod_0(flight_, ref waypoint, ref this.mission_0, ref waypoint_, Mission.Flight.Enum106.const_1);
																flight.method_16(waypoint_);
															}
															else if (waypoint.enum82_0 == Waypoint.Enum82.const_1)
															{
																waypoint.enum82_0 = Waypoint.Enum82.const_0;
																this.flight_0.enum82_0 = waypoint.enum82_0;
															}
															else if (waypoint.enum82_0 == Waypoint.Enum82.const_3)
															{
																waypoint.enum82_0 = Waypoint.Enum82.const_0;
																this.flight_0.enum82_0 = waypoint.enum82_0;
															}
														}
														IL_6F3:
														flag = true;
														flag2 = true;
														flag5 = true;
														flag3 = true;
														goto IL_832;
													}
													goto IL_6F3;
												}
											}
											else
											{
												if (dataGridViewColumn.Index != this.int_14)
												{
													goto IL_15A;
												}
												if (Enumerable.Count<Waypoint>(this.flight_0.method_15()) > 0)
												{
													int num3 = Enumerable.Count<Waypoint>(this.flight_0.method_15()) - 1;
													int k = 0;
													while (k <= num3)
													{
														Waypoint waypoint2 = this.flight_0.method_15()[k];
														if (!Information.IsNothing(waypoint2.nullable_7))
														{
															if (!(waypoint2.waypointType_0 == Waypoint.WaypointType.Target | waypoint2.waypointType_0 == Waypoint.WaypointType.WeaponTarget) && !waypoint2.method_40())
															{
																k++;
																continue;
															}
															if (waypoint2.enum82_0 == Waypoint.Enum82.const_0)
															{
																waypoint2.enum82_0 = Waypoint.Enum82.const_1;
																this.flight_0.enum82_1 = waypoint2.enum82_0;
																Mission.Flight flight_2 = this.flight_0;
																Mission.Flight flight;
																Waypoint[] waypoint_ = (flight = this.flight_0).method_15();
																AirTaskingOrder.smethod_0(flight_2, ref waypoint2, ref this.mission_0, ref waypoint_, Mission.Flight.Enum106.const_1);
																flight.method_16(waypoint_);
															}
															else if (waypoint2.enum82_0 == Waypoint.Enum82.const_1)
															{
																waypoint2.enum82_0 = Waypoint.Enum82.const_0;
																this.flight_0.enum82_1 = waypoint2.enum82_0;
															}
															else if (waypoint2.enum82_0 == Waypoint.Enum82.const_3)
															{
																waypoint2.enum82_0 = Waypoint.Enum82.const_0;
																this.flight_0.enum82_1 = waypoint2.enum82_0;
															}
														}
														IL_828:
														flag = true;
														flag2 = true;
														flag5 = true;
														flag3 = true;
														goto IL_832;
													}
													goto IL_828;
												}
											}
										}
										else
										{
											if (!this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index].IsInEditMode)
											{
												DataTable dataSource = new DataTable();
												DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index];
												Mission.Flight.smethod_11(ref dataSource);
												dataGridViewComboBoxCell.DataSource = dataSource;
												dataGridViewComboBoxCell.DropDownWidth = 500;
												dataGridViewComboBoxCell.DisplayMember = "Description";
												dataGridViewComboBoxCell.ValueMember = "ID";
											}
											this.vmethod_0().BeginEdit(true);
											if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_44().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
											{
												((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
											}
										}
									}
									else
									{
										if (!this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index].IsInEditMode)
										{
											DataTable dataSource2 = new DataTable();
											DataGridViewComboBoxCell dataGridViewComboBoxCell2 = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index];
											Mission.Flight.smethod_11(ref dataSource2);
											dataGridViewComboBoxCell2.DataSource = dataSource2;
											dataGridViewComboBoxCell2.DropDownWidth = 500;
											dataGridViewComboBoxCell2.DisplayMember = "Description";
											dataGridViewComboBoxCell2.ValueMember = "ID";
										}
										this.vmethod_0().BeginEdit(true);
										if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_44().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
										{
											((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
										}
									}
								}
								else
								{
									if (!this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index].IsInEditMode)
									{
										DataTable dataSource3 = new DataTable();
										DataGridViewComboBoxCell dataGridViewComboBoxCell3 = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index];
										Mission.Flight.smethod_7(ref dataSource3);
										dataGridViewComboBoxCell3.DataSource = dataSource3;
										dataGridViewComboBoxCell3.DisplayMember = "Description";
										dataGridViewComboBoxCell3.ValueMember = "ID";
										dataGridViewComboBoxCell3.DropDownWidth = 500;
									}
									this.vmethod_0().BeginEdit(true);
									if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_44().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
									{
										((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
									}
								}
							}
							else
							{
								if (!this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index].IsInEditMode)
								{
									DataTable dataSource4 = new DataTable();
									DataGridViewComboBoxCell dataGridViewComboBoxCell4 = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index];
									Mission.Flight.smethod_4(ref dataSource4);
									dataGridViewComboBoxCell4.DataSource = dataSource4;
									dataGridViewComboBoxCell4.DisplayMember = "Description";
									dataGridViewComboBoxCell4.ValueMember = "ID";
									dataGridViewComboBoxCell4.DropDownWidth = 500;
								}
								this.vmethod_0().BeginEdit(true);
								if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_44().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
								{
									((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
								}
							}
						}
						else
						{
							if (!this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index].IsInEditMode)
							{
								DataTable dataSource5 = new DataTable();
								DataGridViewComboBoxCell dataGridViewComboBoxCell5 = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow.Index];
								Mission.Flight.smethod_14(ref dataSource5);
								dataGridViewComboBoxCell5.DataSource = dataSource5;
								dataGridViewComboBoxCell5.DisplayMember = "Description";
								dataGridViewComboBoxCell5.ValueMember = "ID";
								dataGridViewComboBoxCell5.DropDownWidth = 200;
							}
							this.vmethod_0().BeginEdit(true);
							if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_44().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
							{
								((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
							}
						}
						IL_832:
						if (flag)
						{
							this.method_15(true, flag2, flag4, flag5);
						}
						else if (flag4)
						{
							if (Client.smethod_32().Visible && this.mission_0.list_1.Contains(Client.smethod_32().flight_0))
							{
								Client.smethod_32().method_12();
							}
						}
						else if (flag2 && Client.smethod_32().Visible && this.mission_0.list_1.Contains(Client.smethod_32().flight_0))
						{
							Client.smethod_32().method_13();
							if (flag5)
							{
								Client.smethod_32().flightPlanWaypoints_6.method_14();
							}
						}
						if (flag3)
						{
							this.method_9();
							this.method_13();
						}
						this.method_30();
						Client.bool_1 = true;
						Class2413.smethod_2().method_41().method_84();
						return;
					}
					IL_15A:;
				}
				goto IL_832;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200583", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x00393CAC File Offset: 0x00391EAC
		public void method_15(bool bool_4, bool bool_5, bool bool_6, bool bool_7)
		{
			try
			{
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
				if (Client.smethod_32().Visible && bool_5)
				{
					if (bool_6)
					{
						Client.smethod_32().method_12();
					}
					else
					{
						Client.smethod_32().method_13();
						if (bool_7)
						{
							Client.smethod_32().flightPlanWaypoints_6.method_14();
						}
					}
				}
				if (bool_4)
				{
					Class2413.smethod_2().method_41().method_235();
					Client.bool_1 = true;
					Class2413.smethod_2().method_41().method_84();
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

		// Token: 0x06006984 RID: 27012 RVA: 0x00043007 File Offset: 0x00041207
		private void method_16(object sender, DataGridViewCellEventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0 && this.bool_3)
			{
				this.method_18(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06006985 RID: 27013 RVA: 0x00043030 File Offset: 0x00041230
		private void method_17(object sender, EventArgs e)
		{
			this.bool_3 = true;
			if (this.vmethod_0().IsCurrentCellDirty)
			{
				this.vmethod_0().CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x00393DF8 File Offset: 0x00391FF8
		private void method_18(object sender, DataGridViewCellEventArgs e)
		{
			Mission.Flight flight = (Mission.Flight)this.vmethod_0().Rows[e.RowIndex].Tag;
			if (!Information.IsNothing(flight))
			{
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				bool flag5 = false;
				bool flag6 = false;
				bool flag7 = false;
				bool flag8 = false;
				if (e.RowIndex != -1 && e.ColumnIndex == this.int_4)
				{
					Mission.Enum93 enum93_ = Mission.Flight.smethod_15(Conversions.ToInteger(this.vmethod_0()[e.ColumnIndex, e.RowIndex].Value));
					Mission.Flight flight_ = flight;
					Scenario scenario = Client.smethod_46();
					Side side_ = Client.smethod_50();
					AirTaskingOrder.smethod_1(flight_, ref scenario, ref side_, ref this.mission_0, enum93_);
					Client.smethod_51(side_);
					flag = true;
					flag3 = true;
					flag4 = true;
					flag5 = true;
					flag6 = true;
					flag7 = true;
				}
				if (e.RowIndex != -1 && e.ColumnIndex == this.int_5)
				{
					Mission._FlightTask flightTask = Mission.Flight.smethod_5(Conversions.ToInteger(this.vmethod_0()[e.ColumnIndex, e.RowIndex].Value));
					if (flightTask == Mission._FlightTask.const_48)
					{
						if (this.mission_0._MissionClass_0 != Mission._MissionClass.Patrol && this.mission_0._MissionClass_0 != Mission._MissionClass.Support)
						{
							Interaction.MsgBox("Only patrol and support missions may use flights of type QRA.", MsgBoxStyle.OkOnly, null);
							this.method_5();
							return;
						}
						if (this.mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
						{
							Class343 @class = (Class343)this.mission_0;
							if (!@class.bool_30)
							{
								Interaction.MsgBox("The mission does not have Continous Coverage enabled, so QRA flights will not launch!", MsgBoxStyle.OkOnly, null);
							}
							else if (!@class.bool_31)
							{
								Interaction.MsgBox("The mission does not have QRA enabled, so QRA flights will not launch!", MsgBoxStyle.OkOnly, null);
							}
						}
						if (this.mission_0._MissionClass_0 == Mission._MissionClass.Support)
						{
							Class344 class2 = (Class344)this.mission_0;
							if (!class2.bool_28)
							{
								Interaction.MsgBox("The mission does not have Continous Coverage enabled, so QRA flights will not launch!", MsgBoxStyle.OkOnly, null);
							}
							else if (!class2.bool_29)
							{
								Interaction.MsgBox("The mission does not have QRA enabled, so QRA flights will not launch!", MsgBoxStyle.OkOnly, null);
							}
						}
						bool bool_;
						if (bool_ = (!Information.IsNothing(this.mission_0) && this.mission_0.enum88_0 == Mission.Enum88.const_1))
						{
							Interaction.MsgBox("Packages cannot use flights of type QRA.", MsgBoxStyle.OkOnly, null);
							this.method_5();
							return;
						}
						if (Enumerable.Count<Waypoint>(this.flight_0.method_15()) > 0 && !Information.IsNothing(this.flight_0.method_15()[0].nullable_7))
						{
							if (Interaction.MsgBox("Changing the flight task type to QRA will clear all waypoints times. Continue?", MsgBoxStyle.YesNo, null) != MsgBoxResult.Yes)
							{
								this.method_5();
								return;
							}
							AirTaskingOrder.smethod_3(this.flight_0, bool_);
						}
					}
					flight._FlightTask_0 = flightTask;
					if (flight.method_8())
					{
						flight.bool_12 = true;
					}
					else
					{
						flight.bool_12 = false;
					}
					try
					{
						foreach (ActiveUnit activeUnit in this.mission_0.method_15(Client.smethod_46()))
						{
							if (activeUnit.vmethod_85().method_48() && activeUnit.vmethod_85().method_7() == flight)
							{
								activeUnit.vmethod_86().bool_2 = flight.bool_12;
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (!Information.IsNothing(this.mission_0.list_2))
					{
						try
						{
							foreach (Mission.EmptyAircraftSlot emptyAircraftSlot in this.mission_0.list_2)
							{
								if (Operators.CompareString(emptyAircraftSlot.string_2, flight.string_0, false) == 0)
								{
									emptyAircraftSlot.bool_2 = flight.bool_12;
								}
							}
						}
						finally
						{
							List<Mission.EmptyAircraftSlot>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
					flag8 = true;
					flag2 = true;
					flag = true;
					flag3 = true;
				}
				if (e.RowIndex != -1 && e.ColumnIndex == this.int_22)
				{
					flight.enum101_0 = Mission.Flight.smethod_8(Conversions.ToInteger(this.vmethod_0()[e.ColumnIndex, e.RowIndex].Value));
				}
				if (e.RowIndex != -1 && e.ColumnIndex == this.int_18)
				{
					Mission._FlightSize flightSize_ = Mission.Flight.smethod_12(Conversions.ToInteger(this.vmethod_0()[e.ColumnIndex, e.RowIndex].Value));
					if (!Information.IsNothing(this.flight_0))
					{
						Mission.Flight flight2 = this.flight_0;
						Scenario scenario = Client.smethod_46();
						flight2.method_26(ref scenario, ref this.mission_0, flightSize_);
						flag = true;
						flag4 = true;
						flag3 = true;
					}
					Class2413.smethod_2().method_41().method_235();
					Client.bool_1 = true;
					Class2413.smethod_2().method_41().method_84();
				}
				if (e.RowIndex != -1 && e.ColumnIndex == this.int_19)
				{
					Mission._FlightSize flightSize_2 = Mission.Flight.smethod_12(Conversions.ToInteger(this.vmethod_0()[e.ColumnIndex, e.RowIndex].Value));
					if (!Information.IsNothing(this.flight_0))
					{
						Mission.Flight flight3 = this.flight_0;
						Scenario scenario = Client.smethod_46();
						flight3.method_27(ref scenario, ref this.mission_0, flightSize_2);
						flag = true;
						flag4 = true;
					}
				}
				if (flag8 && !Information.IsNothing(this.flight_0))
				{
					Scenario scenario_ = Client.smethod_46();
					Mission mission = this.mission_0;
					ActiveUnit activeUnit_ = this.flight_0.method_32(Client.smethod_46());
					Mission.Flight flight4 = this.flight_0;
					Mission.Flight flight5;
					Waypoint[] waypoint_ = (flight5 = this.flight_0).method_15();
					float num = 0f;
					float num2 = 0f;
					Class514.smethod_28(scenario_, mission, activeUnit_, flight4, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
					flight5.method_16(waypoint_);
					Class2413.smethod_2().method_41().method_235();
					Client.bool_1 = true;
					Class2413.smethod_2().method_41().method_84();
				}
				if (flag3)
				{
					if (Client.smethod_32().Visible)
					{
						Client.smethod_32().method_9(false);
						Client.smethod_32().method_12();
					}
				}
				else if (flag2 && Client.smethod_32().Visible)
				{
					Client.smethod_32().method_9(false);
					Client.smethod_32().method_13();
					Client.smethod_32().method_11();
				}
				if (flag && Client.smethod_31().Visible)
				{
					Client.smethod_31().method_5();
					Client.smethod_31().method_30();
					if (flag6)
					{
						this.method_13();
					}
				}
				if (flag4 && Client.flightPlanAircraftLoadout_0.Visible)
				{
					Client.flightPlanAircraftLoadout_0.method_5();
				}
				if (flag5)
				{
					this.method_31();
				}
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
				if (flag7)
				{
					Class2413.smethod_2().method_41().method_235();
				}
				this.bool_3 = false;
			}
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x0039445C File Offset: 0x0039265C
		private void method_19(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0))
			{
				Client.smethod_32().mission_0 = this.mission_0;
				Client.smethod_32().flight_0 = this.flight_0;
				if (Client.smethod_32().Visible)
				{
					Client.smethod_32().method_6();
					Client.smethod_32().BringToFront();
					return;
				}
				Client.smethod_32().Show();
			}
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x003944D0 File Offset: 0x003926D0
		private void method_20(object sender, EventArgs e)
		{
			if (this.bool_3 && this.vmethod_0().SelectedRows.Count != 0)
			{
				this.flight_0 = (Mission.Flight)this.vmethod_0().SelectedRows[0].Tag;
				if (!Information.IsNothing(this.flight_0))
				{
					this.string_0 = this.flight_0.string_0;
					this.mission_0 = Enumerable.ElementAtOrDefault<Mission>(Enumerable.Where<Mission>(Client.smethod_50().method_35(), new Func<Mission, bool>(this.method_40)), 0);
				}
				this.method_30();
			}
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x00394564 File Offset: 0x00392764
		private void method_21(object sender, EventArgs e)
		{
			if (Client.smethod_50().method_35().Count != 0)
			{
				if (Information.IsNothing(this.mission_0))
				{
					if (Operators.CompareString(this.string_1, "Filter_ATO_Only", false) != 0 && Operators.CompareString(this.string_1, "Filter_All", false) != 0 && Operators.CompareString(this.string_1, "", false) != 0)
					{
						try
						{
							foreach (Mission mission in Client.smethod_50().method_35())
							{
								if (Operators.CompareString(this.string_1, mission.string_0, false) == 0)
								{
									this.mission_0 = mission;
								}
							}
							goto IL_B4;
						}
						finally
						{
							IEnumerator<Mission> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
					}
					Interaction.MsgBox("Could not determine which mission to create flight for. Select an existing flight to make a new flight for that same mission, or filter the ATO on a specific mission.", MsgBoxStyle.OkOnly, null);
					return;
				}
				IL_B4:
				if (Information.IsNothing(this.mission_0))
				{
					Interaction.MsgBox("Could not generate a new flight. Does the side have any missions, and is the ATO filter setting correct?", MsgBoxStyle.OkOnly, null);
					return;
				}
				Scenario scenario = Client.smethod_46();
				Mission.Flight flight = null;
				Mission.Flight flight2 = new Mission.Flight(ref scenario, ref this.mission_0, ref flight, "New Flight", "", "", 0, null, null, this.mission_0._FlightSize_0, false);
				flight2.string_12 = "Any type";
				flight2.method_14(Client.smethod_46(), "Any loadout");
				if (Information.IsNothing(this.mission_0.list_2))
				{
					this.mission_0.list_2 = new List<Mission.EmptyAircraftSlot>();
				}
				ActiveUnit activeUnit;
				if (Client.smethod_46().vmethod_0().ContainsKey(flight2.string_5))
				{
					activeUnit = Client.smethod_46().vmethod_0()[flight2.string_5];
				}
				int flightSize_ = (int)flight2._FlightSize_0;
				for (int i = 1; i <= flightSize_; i++)
				{
					Mission.EmptyAircraftSlot emptyAircraftSlot = new Mission.EmptyAircraftSlot(null, flight2.int_2, flight2.string_12, flight2.int_3, flight2.method_13(Client.smethod_46()), ref activeUnit, flight2.string_5, flight2.string_6, flight2.bool_12);
					this.mission_0.list_2.Add(emptyAircraftSlot);
					emptyAircraftSlot.method_7(Client.smethod_46(), flight2, i);
				}
				this.mission_0.method_60(ref flight2);
				this.method_8();
				if (Client.smethod_32().Visible && this.mission_0.list_1.Contains(Client.smethod_32().flight_0))
				{
					Client.smethod_32().method_9(false);
				}
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
				if (this.vmethod_0().SelectedRows.Count > 0)
				{
					this.int_0 = this.vmethod_0().SelectedRows[0].Index;
					this.flight_0 = (Mission.Flight)this.vmethod_0().SelectedRows[0].Tag;
					if (!Information.IsNothing(this.flight_0))
					{
						this.string_0 = this.flight_0.string_0;
						this.mission_0 = Enumerable.ElementAtOrDefault<Mission>(Enumerable.Where<Mission>(Client.smethod_50().method_35(), new Func<Mission, bool>(this.method_41)), 0);
					}
					if (this.int_0 > 0)
					{
						this.vmethod_0().Rows[0].Selected = false;
						this.vmethod_0().Rows[this.int_0].Selected = false;
					}
				}
			}
		}

		// Token: 0x0600698A RID: 27018 RVA: 0x003948A0 File Offset: 0x00392AA0
		private void method_22(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.flight_0))
			{
				Mission.Flight flight = this.flight_0;
				Scenario scenario = Client.smethod_46();
				Mission.Flight flight2 = new Mission.Flight();
				bool bool_ = false;
				int enum103_ = (int)this.flight_0.enum103_0;
				int enum103_2 = (int)this.flight_0.enum103_1;
				flight.method_31(ref scenario, ref this.flight_0, ref flight2, bool_, ref this.mission_0, ref enum103_, ref enum103_2, true, true);
			}
			this.method_8();
			if (Client.smethod_30().Visible)
			{
				Client.smethod_30().method_11();
				Client.smethod_30().method_13();
			}
			if (Client.smethod_32().Visible && this.mission_0.list_1.Contains(Client.smethod_32().flight_0))
			{
				Client.smethod_32().method_9(false);
			}
			Class2413.smethod_2().method_41().method_235();
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().method_84();
			if (this.vmethod_0().SelectedRows.Count > 0)
			{
				this.method_11();
				this.int_0 = this.vmethod_0().SelectedRows[0].Index;
				this.flight_0 = (Mission.Flight)this.vmethod_0().SelectedRows[0].Tag;
				if (!Information.IsNothing(this.flight_0))
				{
					this.string_0 = this.flight_0.string_0;
					this.mission_0 = Enumerable.ElementAtOrDefault<Mission>(Enumerable.Where<Mission>(Client.smethod_50().method_35(), new Func<Mission, bool>(this.method_42)), 0);
				}
				if (this.int_0 > 0)
				{
					this.vmethod_0().Rows[0].Selected = false;
					this.vmethod_0().Rows[this.int_0].Selected = true;
				}
			}
		}

		// Token: 0x0600698B RID: 27019 RVA: 0x00394A58 File Offset: 0x00392C58
		private void method_23(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				if (this.vmethod_0().SelectedRows.Count == 1)
				{
					if (Information.IsNothing(this.flight_0))
					{
						return;
					}
					if (Information.IsNothing(this.flight_0))
					{
						this.method_8();
						return;
					}
					Mission mission = this.mission_0;
					Scenario scenario = Client.smethod_46();
					Side side_ = Client.smethod_50();
					mission.method_57(ref scenario, ref side_, ref this.flight_0, this.flight_0.string_0);
					Client.smethod_51(side_);
				}
				else
				{
					for (int i = this.vmethod_0().Rows.Count - 1; i >= 0; i += -1)
					{
						DataGridViewRow dataGridViewRow = this.vmethod_0().Rows[i];
						if (dataGridViewRow.Selected)
						{
							Mission.Flight flight = (Mission.Flight)dataGridViewRow.Tag;
							if (!Information.IsNothing(flight))
							{
								try
								{
									foreach (Mission mission2 in Client.smethod_50().method_35())
									{
										if (mission2.list_1.Contains(flight))
										{
											Mission mission3 = mission2;
											Scenario scenario = Client.smethod_46();
											Side side_ = Client.smethod_50();
											mission3.method_57(ref scenario, ref side_, ref flight, flight.string_0);
											Client.smethod_51(side_);
											break;
										}
									}
								}
								finally
								{
									IEnumerator<Mission> enumerator;
									if (enumerator != null)
									{
										enumerator.Dispose();
									}
								}
							}
						}
					}
				}
				this.method_4();
				if (Client.smethod_32().Visible && !this.mission_0.list_1.Contains(Client.smethod_32().flight_0))
				{
					Client.smethod_32().flight_0 = null;
					Client.smethod_32().method_12();
				}
				if (Client.flightPlanAircraftLoadout_0.Visible && !this.mission_0.list_1.Contains(Client.flightPlanAircraftLoadout_0.flight_0))
				{
					Client.flightPlanAircraftLoadout_0.flight_0 = null;
					Client.flightPlanAircraftLoadout_0.method_5();
				}
				if (Client.smethod_30().Visible)
				{
					Client.smethod_30().method_11();
					Client.smethod_30().method_13();
				}
				Class2413.smethod_2().method_41().method_235();
				Client.bool_1 = true;
				Class2413.smethod_2().method_41().method_84();
				if (this.vmethod_0().SelectedRows.Count > 0)
				{
					this.int_0 = this.vmethod_0().SelectedRows[0].Index;
					this.flight_0 = (Mission.Flight)this.vmethod_0().SelectedRows[0].Tag;
					if (!Information.IsNothing(this.flight_0))
					{
						this.string_0 = this.flight_0.string_0;
						this.mission_0 = Enumerable.ElementAtOrDefault<Mission>(Enumerable.Where<Mission>(Client.smethod_50().method_35(), new Func<Mission, bool>(this.method_43)), 0);
					}
					if (this.int_0 > 0)
					{
						this.vmethod_0().Rows[0].Selected = false;
						this.vmethod_0().Rows[this.int_0].Selected = true;
					}
				}
			}
		}

		// Token: 0x0600698C RID: 27020 RVA: 0x00043057 File Offset: 0x00041257
		private void method_24(object sender, EventArgs e)
		{
			Class570.class280_0.method_37((Class279.Class280.Enum77)this.vmethod_4().SelectedIndex);
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x0600698D RID: 27021 RVA: 0x00394D50 File Offset: 0x00392F50
		private void AirTaskingOrder_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F11 && e.Control && e.Shift && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x0600698E RID: 27022 RVA: 0x00043084 File Offset: 0x00041284
		private void method_25(object sender, EventArgs e)
		{
			Class570.class280_0.method_35((Class279.Class280.Enum76)this.vmethod_16().SelectedIndex);
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x0600698F RID: 27023 RVA: 0x00394E30 File Offset: 0x00393030
		private void method_26(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				Client.flightPlanAircraftLoadout_0.mission_0 = this.mission_0;
				Client.flightPlanAircraftLoadout_0.flight_0 = this.flight_0;
				if (Client.flightPlanAircraftLoadout_0.Visible)
				{
					Client.flightPlanAircraftLoadout_0.method_3();
					Client.flightPlanAircraftLoadout_0.BringToFront();
					return;
				}
				Client.flightPlanAircraftLoadout_0.Show();
			}
		}

		// Token: 0x06006990 RID: 27024 RVA: 0x00394EB4 File Offset: 0x003930B4
		private void method_27(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				bool flag = false;
				int num = Enumerable.Count<Waypoint>(this.flight_0.method_15()) - 1;
				int i = 0;
				while (i <= num)
				{
					Waypoint waypoint = this.flight_0.method_15()[i];
					if (waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
					{
						flag = true;
						IL_74:
						if (flag && !Information.IsNothing(waypoint))
						{
							Client.flightPlanTime_0.bool_3 = false;
							Client.flightPlanTime_0.method_4(ref this.mission_0, ref this.flight_0, ref waypoint, Mission.Flight.Enum106.const_1, true);
							Client.flightPlanTime_0.Show();
							Client.flightPlanTime_0.BringToFront();
							return;
						}
						return;
					}
					else
					{
						i++;
					}
				}
				goto IL_74;
			}
		}

		// Token: 0x06006991 RID: 27025 RVA: 0x00394F7C File Offset: 0x0039317C
		private void method_28(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.flight_0) && this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
			{
				bool flag = false;
				int num = Enumerable.Count<Waypoint>(this.flight_0.method_15()) - 1;
				int i = 0;
				while (i <= num)
				{
					Waypoint waypoint = this.flight_0.method_15()[i];
					if (waypoint.waypointType_0 != Waypoint.WaypointType.Target && waypoint.waypointType_0 != Waypoint.WaypointType.WeaponTarget && !waypoint.method_40())
					{
						i++;
					}
					else
					{
						flag = true;
						IL_84:
						if (flag)
						{
							Client.flightPlanTime_0.bool_3 = false;
							Client.flightPlanTime_0.method_4(ref this.mission_0, ref this.flight_0, ref waypoint, Mission.Flight.Enum106.const_1, true);
							Client.flightPlanTime_0.Show();
							Client.flightPlanTime_0.BringToFront();
							return;
						}
						return;
					}
				}
				goto IL_84;
			}
		}

		// Token: 0x06006992 RID: 27026 RVA: 0x0039504C File Offset: 0x0039324C
		private void method_29(object sender, EventArgs e)
		{
			bool bool_ = !Information.IsNothing(this.mission_0) && this.mission_0.enum88_0 == Mission.Enum88.const_1;
			AirTaskingOrder.smethod_3(this.flight_0, bool_);
			this.method_15(false, true, false, true);
			FlightPlanTime flightPlanTime_ = Client.flightPlanTime_0;
			Mission mission = null;
			Mission.Flight flight = null;
			Waypoint waypoint = null;
			flightPlanTime_.method_4(ref mission, ref flight, ref waypoint, Mission.Flight.Enum106.const_0, false);
			this.method_8();
			Class2413.smethod_2().method_41().method_235();
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06006993 RID: 27027 RVA: 0x003950D0 File Offset: 0x003932D0
		public void method_30()
		{
			try
			{
				if (this.vmethod_0().SelectedRows.Count == 1)
				{
					this.vmethod_20().Enabled = false;
					this.vmethod_22().Enabled = false;
					this.vmethod_24().Enabled = false;
					if (Information.IsNothing(this.flight_0))
					{
						this.vmethod_18().Enabled = false;
						this.vmethod_12().Enabled = false;
						this.vmethod_8().Enabled = false;
						this.vmethod_10().Enabled = false;
					}
					else
					{
						this.vmethod_18().Enabled = true;
						this.vmethod_12().Enabled = true;
						this.vmethod_8().Enabled = true;
						if (this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
						{
							this.vmethod_10().Enabled = true;
						}
						else
						{
							this.vmethod_10().Enabled = false;
						}
						if (this.flight_0.enum93_0 == Mission.Enum93.const_0 && this.flight_0._FlightTask_0 != Mission._FlightTask.const_48)
						{
							int num = this.vmethod_0().Rows.Count - 1;
							int i = 0;
							while (i <= num)
							{
								if (!this.vmethod_0().Rows[i].Selected || Information.IsNothing(this.flight_0))
								{
									i++;
								}
								else
								{
									if (Enumerable.Count<Waypoint>(this.flight_0.method_15()) > 0)
									{
										int num2 = Enumerable.Count<Waypoint>(this.flight_0.method_15()) - 1;
										bool flag = false;
										int num3 = num2;
										for (int j = 0; j <= num3; j++)
										{
											Waypoint waypoint = this.flight_0.method_15()[j];
											if (!flag && !Information.IsNothing(waypoint.nullable_7))
											{
												flag = true;
											}
											if (waypoint.waypointType_0 == Waypoint.WaypointType.TakeOff)
											{
												if (this.flight_0.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
												{
													this.vmethod_20().Enabled = true;
												}
												else
												{
													this.vmethod_20().Enabled = false;
												}
											}
											else if (waypoint.waypointType_0 == Waypoint.WaypointType.Target || waypoint.waypointType_0 == Waypoint.WaypointType.WeaponTarget || waypoint.method_40())
											{
												this.vmethod_22().Enabled = true;
												IL_202:
												if (flag)
												{
													this.vmethod_24().Enabled = true;
													goto IL_2D6;
												}
												goto IL_2D6;
											}
										}
										goto IL_202;
									}
									break;
								}
							}
						}
					}
				}
				else if (this.vmethod_0().SelectedRows.Count > 1)
				{
					this.vmethod_20().Enabled = false;
					this.vmethod_22().Enabled = false;
					this.vmethod_24().Enabled = false;
					this.vmethod_18().Enabled = false;
					this.vmethod_12().Enabled = true;
					this.vmethod_8().Enabled = false;
					this.vmethod_10().Enabled = false;
				}
				else
				{
					this.vmethod_20().Enabled = false;
					this.vmethod_22().Enabled = false;
					this.vmethod_24().Enabled = false;
					this.vmethod_18().Enabled = false;
					this.vmethod_12().Enabled = false;
					this.vmethod_8().Enabled = false;
					this.vmethod_10().Enabled = false;
				}
				IL_2D6:;
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

		// Token: 0x06006994 RID: 27028 RVA: 0x0039540C File Offset: 0x0039360C
		public void method_31()
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.vmethod_0().Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						Mission.Flight flight = (Mission.Flight)dataGridViewRow.Tag;
						if (!Information.IsNothing(flight))
						{
							if (flight.method_10(Client.smethod_46()) == Mission.Enum102.const_0)
							{
								if (dataGridViewRow.Cells["Type"].ReadOnly)
								{
									dataGridViewRow.Cells["Type"].ReadOnly = false;
									dataGridViewRow.Cells["Type"].Style.BackColor = default(Color);
									dataGridViewRow.Cells["Type"].Style.SelectionBackColor = default(Color);
								}
								if (dataGridViewRow.Cells["Priority"].ReadOnly)
								{
									dataGridViewRow.Cells["Priority"].ReadOnly = false;
									dataGridViewRow.Cells["Priority"].Style.BackColor = default(Color);
									dataGridViewRow.Cells["Priority"].Style.SelectionBackColor = default(Color);
								}
								if (dataGridViewRow.Cells["DesiredAircraftQty"].ReadOnly)
								{
									dataGridViewRow.Cells["DesiredAircraftQty"].ReadOnly = false;
									dataGridViewRow.Cells["DesiredAircraftQty"].Style.BackColor = default(Color);
									dataGridViewRow.Cells["DesiredAircraftQty"].Style.SelectionBackColor = default(Color);
								}
								if (dataGridViewRow.Cells["MinimumAircraftQty"].ReadOnly)
								{
									dataGridViewRow.Cells["MinimumAircraftQty"].ReadOnly = false;
									dataGridViewRow.Cells["MinimumAircraftQty"].Style.BackColor = default(Color);
									dataGridViewRow.Cells["MinimumAircraftQty"].Style.SelectionBackColor = default(Color);
								}
							}
							else
							{
								dataGridViewRow.Cells["Type"].ReadOnly = true;
								dataGridViewRow.Cells["Type"].Style.BackColor = Color.LightGray;
								dataGridViewRow.Cells["Type"].Style.SelectionBackColor = Color.LightGray;
								dataGridViewRow.Cells["Type"].Style.SelectionForeColor = Color.Black;
								dataGridViewRow.Cells["Priority"].ReadOnly = true;
								dataGridViewRow.Cells["Priority"].Style.BackColor = Color.LightGray;
								dataGridViewRow.Cells["Priority"].Style.SelectionBackColor = Color.LightGray;
								dataGridViewRow.Cells["Priority"].Style.SelectionForeColor = Color.Black;
								dataGridViewRow.Cells["DesiredAircraftQty"].ReadOnly = true;
								dataGridViewRow.Cells["DesiredAircraftQty"].Style.BackColor = Color.LightGray;
								dataGridViewRow.Cells["DesiredAircraftQty"].Style.SelectionBackColor = Color.LightGray;
								dataGridViewRow.Cells["DesiredAircraftQty"].Style.SelectionForeColor = Color.Black;
								dataGridViewRow.Cells["MinimumAircraftQty"].ReadOnly = true;
								dataGridViewRow.Cells["MinimumAircraftQty"].Style.BackColor = Color.LightGray;
								dataGridViewRow.Cells["MinimumAircraftQty"].Style.SelectionBackColor = Color.LightGray;
								dataGridViewRow.Cells["MinimumAircraftQty"].Style.SelectionForeColor = Color.Black;
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

		// Token: 0x06006995 RID: 27029 RVA: 0x00395894 File Offset: 0x00393A94
		private void method_32(object sender, EventArgs e)
		{
			if (this.vmethod_28().SelectedIndex == 0)
			{
				this.string_1 = "Filter_ATO_Only";
				this.method_8();
				return;
			}
			if (this.vmethod_28().SelectedIndex == 1)
			{
				this.string_1 = "Filter_All";
				this.method_8();
				return;
			}
			string right = Conversions.ToString(this.vmethod_28().SelectedItem);
			bool flag = false;
			try
			{
				foreach (Mission mission in Client.smethod_50().method_35())
				{
					if (Operators.CompareString(mission.Name, right, false) == 0)
					{
						this.mission_0 = mission;
						this.string_1 = mission.string_0;
						flag = true;
						break;
					}
				}
			}
			finally
			{
				IEnumerator<Mission> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			if (!flag)
			{
				this.string_1 = "";
			}
			if (flag && Operators.CompareString(this.mission_0.Name, right, false) == 0)
			{
				this.int_0 = 0;
				this.flight_0 = null;
				this.string_0 = "";
			}
			try
			{
				foreach (object obj in ((IEnumerable)this.vmethod_0().Rows))
				{
					((DataGridViewRow)obj).Selected = false;
				}
			}
			finally
			{
				IEnumerator enumerator2;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			this.method_8();
		}

		// Token: 0x06006996 RID: 27030 RVA: 0x000430B1 File Offset: 0x000412B1
		private void method_33(object sender, EventArgs e)
		{
			this.enum200_0 = (AirTaskingOrder.Enum200)this.vmethod_26().SelectedIndex;
			this.method_8();
		}

		// Token: 0x06006997 RID: 27031 RVA: 0x003959F4 File Offset: 0x00393BF4
		public static void smethod_0(Mission.Flight flight_1, ref Waypoint waypoint_0, ref Mission mission_1, ref Waypoint[] waypoint_1, Mission.Flight.Enum106 enum106_0)
		{
			try
			{
				AirTaskingOrder.smethod_2(flight_1, ref mission_1, ref waypoint_0, true);
				if (enum106_0 != Mission.Flight.Enum106.const_1)
				{
					bool? flag = null;
					bool bool_ = true;
					Waypoint[] array = waypoint_1;
					int i = 0;
					while (i < array.Length)
					{
						Waypoint waypoint = array[i];
						bool flag2 = mission_1._MissionClass_0 == Mission._MissionClass.Strike && (waypoint.waypointType_0 == Waypoint.WaypointType.Target || waypoint.waypointType_0 == Waypoint.WaypointType.WeaponTarget);
						if (!Information.IsNothing(waypoint.waypoint_0) && waypoint.waypoint_0 == waypoint_0)
						{
							if (Information.IsNothing(flag))
							{
								if (Information.IsNothing(waypoint.nullable_7))
								{
									flag = new bool?(true);
								}
								else if (flag2 && Interaction.MsgBox("You have chosen to set the time for a Target waypoint. Would you also like to update Target waypoint times for wingmen waypoints?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
								{
									flag = new bool?(true);
									bool_ = false;
								}
								else
								{
									flag = new bool?(false);
								}
							}
							if (flag.GetValueOrDefault())
							{
								if (flag2)
								{
									if (waypoint_0.float_6 > 0f)
									{
										waypoint.nullable_8 = new DateTime?(waypoint_0.nullable_8.Value.AddSeconds((double)(-(double)waypoint.float_27)));
										waypoint.nullable_7 = new DateTime?(waypoint.nullable_8.Value.AddSeconds((double)(-(double)waypoint.float_6)));
									}
									else
									{
										waypoint.nullable_7 = new DateTime?(waypoint_0.nullable_7.Value.AddSeconds((double)(-(double)waypoint.float_27)));
										waypoint.nullable_8 = null;
									}
								}
								else
								{
									waypoint.nullable_7 = waypoint_0.nullable_7;
									waypoint.nullable_8 = null;
								}
								waypoint.enum82_0 = waypoint_0.enum82_0;
								AirTaskingOrder.smethod_2(flight_1, ref mission_1, ref waypoint, bool_);
								break;
							}
							break;
						}
						else if (!Information.IsNothing(waypoint.waypoint_1) && waypoint.waypoint_1 == waypoint_0)
						{
							if (Information.IsNothing(flag))
							{
								if (Information.IsNothing(waypoint.nullable_7))
								{
									flag = new bool?(true);
								}
								else if (flag2 && Interaction.MsgBox("You have chosen to set the time for a Target waypoint. Would you also like to update Target waypoint times for wingmen waypoints?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
								{
									flag = new bool?(true);
									bool_ = false;
								}
								else
								{
									flag = new bool?(false);
								}
							}
							if (flag.GetValueOrDefault())
							{
								if (flag2)
								{
									if (waypoint_0.float_6 > 0f)
									{
										waypoint.nullable_8 = new DateTime?(waypoint_0.nullable_8.Value.AddSeconds((double)(-(double)waypoint.float_27 * 2f)));
										waypoint.nullable_7 = new DateTime?(waypoint.nullable_8.Value.AddSeconds((double)(-(double)waypoint.float_6)));
									}
									else
									{
										waypoint.nullable_7 = new DateTime?(waypoint_0.nullable_7.Value.AddSeconds((double)(-(double)waypoint.float_27 * 2f)));
										waypoint.nullable_8 = null;
									}
								}
								else
								{
									waypoint.nullable_7 = waypoint_0.nullable_7;
									waypoint.nullable_8 = null;
								}
								waypoint.enum82_0 = waypoint_0.enum82_0;
								AirTaskingOrder.smethod_2(flight_1, ref mission_1, ref waypoint, bool_);
								break;
							}
							break;
						}
						else if (!Information.IsNothing(waypoint.waypoint_2) && waypoint.waypoint_2 == waypoint_0)
						{
							if (Information.IsNothing(flag))
							{
								if (Information.IsNothing(waypoint.nullable_7))
								{
									flag = new bool?(true);
								}
								else if (flag2 && Interaction.MsgBox("You have chosen to set the time for a Target waypoint. Would you also like to update Target waypoint times for wingmen waypoints?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
								{
									flag = new bool?(true);
									bool_ = false;
								}
								else
								{
									flag = new bool?(false);
								}
							}
							if (flag.GetValueOrDefault())
							{
								if (flag2)
								{
									if (waypoint_0.float_6 > 0f)
									{
										waypoint.nullable_8 = new DateTime?(waypoint_0.nullable_8.Value.AddSeconds((double)(-(double)waypoint.float_27 * 3f)));
										waypoint.nullable_7 = new DateTime?(waypoint.nullable_8.Value.AddSeconds((double)(-(double)waypoint.float_6)));
									}
									else
									{
										waypoint.nullable_7 = new DateTime?(waypoint_0.nullable_7.Value.AddSeconds((double)(-(double)waypoint.float_27 * 3f)));
										waypoint.nullable_8 = null;
									}
								}
								else
								{
									waypoint.nullable_7 = waypoint_0.nullable_7;
									waypoint.nullable_8 = null;
								}
								waypoint.enum82_0 = waypoint_0.enum82_0;
								AirTaskingOrder.smethod_2(flight_1, ref mission_1, ref waypoint, bool_);
								break;
							}
							break;
						}
						else if (!Information.IsNothing(waypoint.waypoint_3) && waypoint.waypoint_3 == waypoint_0)
						{
							if (Information.IsNothing(flag))
							{
								if (Information.IsNothing(waypoint.nullable_7))
								{
									flag = new bool?(true);
								}
								else if (flag2 && Interaction.MsgBox("You have chosen to set the time for a Target waypoint. Would you also like to update Target waypoint times for wingmen waypoints?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
								{
									flag = new bool?(true);
									bool_ = false;
								}
								else
								{
									flag = new bool?(false);
								}
							}
							if (flag.GetValueOrDefault())
							{
								if (flag2)
								{
									if (waypoint_0.float_6 > 0f)
									{
										waypoint.nullable_8 = new DateTime?(waypoint_0.nullable_8.Value.AddSeconds((double)(-(double)waypoint.float_27 * 4f)));
										waypoint.nullable_7 = new DateTime?(waypoint.nullable_8.Value.AddSeconds((double)(-(double)waypoint.float_6)));
									}
									else
									{
										waypoint.nullable_7 = new DateTime?(waypoint_0.nullable_7.Value.AddSeconds((double)(-(double)waypoint.float_27 * 4f)));
										waypoint.nullable_8 = null;
									}
								}
								else
								{
									waypoint.nullable_7 = waypoint_0.nullable_7;
									waypoint.nullable_8 = null;
								}
								waypoint.enum82_0 = waypoint_0.enum82_0;
								AirTaskingOrder.smethod_2(flight_1, ref mission_1, ref waypoint, bool_);
								break;
							}
							break;
						}
						else if (!Information.IsNothing(waypoint.waypoint_4) && waypoint.waypoint_4 == waypoint_0)
						{
							if (Information.IsNothing(flag))
							{
								if (Information.IsNothing(waypoint.nullable_7))
								{
									flag = new bool?(true);
								}
								else if (flag2 && Interaction.MsgBox("You have chosen to set the time for a Target waypoint. Would you also like to update Target waypoint times for wingmen waypoints?", MsgBoxStyle.OkOnly, null) == MsgBoxResult.Yes)
								{
									flag = new bool?(true);
									bool_ = false;
								}
								else
								{
									flag = new bool?(false);
								}
							}
							if (flag.GetValueOrDefault())
							{
								if (flag2)
								{
									if (waypoint_0.float_6 > 0f)
									{
										waypoint.nullable_8 = new DateTime?(waypoint_0.nullable_8.Value.AddSeconds((double)(-(double)waypoint.float_27 * 5f)));
										waypoint.nullable_7 = new DateTime?(waypoint.nullable_8.Value.AddSeconds((double)(-(double)waypoint.float_6)));
									}
									else
									{
										waypoint.nullable_7 = new DateTime?(waypoint_0.nullable_7.Value.AddSeconds((double)(-(double)waypoint.float_27 * 5f)));
										waypoint.nullable_8 = null;
									}
								}
								else
								{
									waypoint.nullable_7 = waypoint_0.nullable_7;
									waypoint.nullable_8 = null;
								}
								waypoint.enum82_0 = waypoint_0.enum82_0;
								AirTaskingOrder.smethod_2(flight_1, ref mission_1, ref waypoint, bool_);
								break;
							}
							break;
						}
						else
						{
							checked
							{
								i++;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101343", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06006998 RID: 27032 RVA: 0x0039618C File Offset: 0x0039438C
		public static void smethod_1(Mission.Flight flight_1, ref Scenario scenario_0, ref Side side_0, ref Mission mission_1, Mission.Enum93 enum93_0)
		{
			try
			{
				if (enum93_0 != Mission.Enum93.const_0)
				{
					if (enum93_0 == Mission.Enum93.const_1)
					{
						if (Interaction.MsgBox("You have selected to change the flightplan to Template. This will remove all aircraft (if any) from the flight and remove flightplan waypoint times (if set). Do you wish to proceed?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
						{
							AirTaskingOrder.smethod_3(flight_1, false);
							mission_1.method_20(ref scenario_0, ref side_0, ref flight_1);
							flight_1.enum93_0 = enum93_0;
							Scenario scenario_ = scenario_0;
							Mission mission = mission_1;
							ActiveUnit activeUnit_ = flight_1.method_32(scenario_0);
							Mission.Flight flight = flight_1;
							Mission.Flight flight2;
							Waypoint[] waypoint_ = (flight2 = flight_1).method_15();
							float num = 0f;
							float num2 = 0f;
							Class514.smethod_28(scenario_, mission, activeUnit_, flight, ref waypoint_, ref num, ref num2, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, false);
							flight2.method_16(waypoint_);
						}
					}
				}
				else
				{
					flight_1.enum93_0 = enum93_0;
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

		// Token: 0x06006999 RID: 27033 RVA: 0x00396294 File Offset: 0x00394494
		public static void smethod_2(Mission.Flight flight_1, ref Mission mission_1, ref Waypoint waypoint_0, bool bool_4)
		{
			try
			{
				if ((waypoint_0.waypointType_0 == Waypoint.WaypointType.Target || waypoint_0.waypointType_0 == Waypoint.WaypointType.WeaponTarget) && waypoint_0.method_21())
				{
					bool flag = true;
					if (!Information.IsNothing(waypoint_0.waypoint_0) && waypoint_0.waypoint_0.enum82_0 != Waypoint.Enum82.const_3)
					{
						flag = false;
					}
					if (!Information.IsNothing(waypoint_0.waypoint_1) && waypoint_0.waypoint_1.enum82_0 != Waypoint.Enum82.const_3)
					{
						flag = false;
					}
					if (!Information.IsNothing(waypoint_0.waypoint_2) && waypoint_0.waypoint_2.enum82_0 != Waypoint.Enum82.const_3)
					{
						flag = false;
					}
					if (!Information.IsNothing(waypoint_0.waypoint_3) && waypoint_0.waypoint_3.enum82_0 != Waypoint.Enum82.const_3)
					{
						flag = false;
					}
					if (!Information.IsNothing(waypoint_0.waypoint_4) && waypoint_0.waypoint_4.enum82_0 != Waypoint.Enum82.const_3)
					{
						flag = false;
					}
					if (flag)
					{
						bool_4 = false;
					}
					if ((!bool_4 || Interaction.MsgBox("You have chosen to set and lock the time for a Target waypoint. Would you also like to set relative times for wingman waypoints? The mission's default time separation interval between aircraft will be used: " + Conversions.ToString(waypoint_0.float_27) + " seconds.", MsgBoxStyle.OkOnly, null) == MsgBoxResult.Yes) && !Information.IsNothing(mission_1))
					{
						if (!Information.IsNothing(waypoint_0.waypoint_0))
						{
							waypoint_0.waypoint_0.enum82_0 = Waypoint.Enum82.const_3;
							waypoint_0.waypoint_0.nullable_7 = new DateTime?(waypoint_0.nullable_7.Value.AddSeconds((double)waypoint_0.float_27));
							if (!Information.IsNothing(waypoint_0.nullable_8))
							{
								waypoint_0.waypoint_0.nullable_8 = new DateTime?(waypoint_0.nullable_8.Value.AddSeconds((double)waypoint_0.float_27));
							}
							else
							{
								waypoint_0.waypoint_0.nullable_8 = null;
							}
						}
						if (!Information.IsNothing(waypoint_0.waypoint_1))
						{
							waypoint_0.waypoint_1.enum82_0 = Waypoint.Enum82.const_3;
							waypoint_0.waypoint_1.nullable_7 = new DateTime?(waypoint_0.nullable_7.Value.AddSeconds((double)(waypoint_0.float_27 * 2f)));
							if (!Information.IsNothing(waypoint_0.nullable_8))
							{
								waypoint_0.waypoint_1.nullable_8 = new DateTime?(waypoint_0.nullable_8.Value.AddSeconds((double)(waypoint_0.float_27 * 2f)));
							}
							else
							{
								waypoint_0.waypoint_1.nullable_8 = null;
							}
						}
						if (!Information.IsNothing(waypoint_0.waypoint_2))
						{
							waypoint_0.waypoint_2.enum82_0 = Waypoint.Enum82.const_3;
							waypoint_0.waypoint_2.nullable_7 = new DateTime?(waypoint_0.nullable_7.Value.AddSeconds((double)(waypoint_0.float_27 * 3f)));
							if (!Information.IsNothing(waypoint_0.nullable_8))
							{
								waypoint_0.waypoint_2.nullable_8 = new DateTime?(waypoint_0.nullable_8.Value.AddSeconds((double)(waypoint_0.float_27 * 3f)));
							}
							else
							{
								waypoint_0.waypoint_2.nullable_8 = null;
							}
						}
						if (!Information.IsNothing(waypoint_0.waypoint_3))
						{
							waypoint_0.waypoint_3.enum82_0 = Waypoint.Enum82.const_3;
							waypoint_0.waypoint_3.nullable_7 = new DateTime?(waypoint_0.nullable_7.Value.AddSeconds((double)(waypoint_0.float_27 * 4f)));
							if (!Information.IsNothing(waypoint_0.nullable_8))
							{
								waypoint_0.waypoint_3.nullable_8 = new DateTime?(waypoint_0.nullable_8.Value.AddSeconds((double)(waypoint_0.float_27 * 4f)));
							}
							else
							{
								waypoint_0.waypoint_3.nullable_8 = null;
							}
						}
						if (!Information.IsNothing(waypoint_0.waypoint_4))
						{
							waypoint_0.waypoint_4.enum82_0 = Waypoint.Enum82.const_3;
							waypoint_0.waypoint_4.nullable_7 = new DateTime?(waypoint_0.nullable_7.Value.AddSeconds((double)(waypoint_0.float_27 * 5f)));
							if (!Information.IsNothing(waypoint_0.nullable_8))
							{
								waypoint_0.waypoint_4.nullable_8 = new DateTime?(waypoint_0.nullable_8.Value.AddSeconds((double)(waypoint_0.float_27 * 5f)));
							}
							else
							{
								waypoint_0.waypoint_4.nullable_8 = null;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101342", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600699A RID: 27034 RVA: 0x00396740 File Offset: 0x00394940
		public static void smethod_3(Mission.Flight flight_1, bool bool_4)
		{
			try
			{
				if (!bool_4 || Interaction.MsgBox("Flightplans in packages should always have waypoint times set! Are you sure you want to clear the waypoint times?", MsgBoxStyle.OkCancel, null) != MsgBoxResult.Cancel)
				{
					int num = Enumerable.Count<Waypoint>(flight_1.method_15()) - 1;
					for (int i = 0; i <= num; i++)
					{
						Waypoint waypoint = flight_1.method_15()[i];
						waypoint.nullable_7 = null;
						waypoint.nullable_8 = null;
						waypoint.float_25 = 0f;
						waypoint.enum82_0 = Waypoint.Enum82.const_0;
						if (!Information.IsNothing(waypoint.waypoint_0))
						{
							waypoint.waypoint_0.nullable_7 = null;
							waypoint.waypoint_0.nullable_8 = null;
							waypoint.waypoint_0.enum82_0 = Waypoint.Enum82.const_0;
						}
						if (!Information.IsNothing(waypoint.waypoint_1))
						{
							waypoint.waypoint_1.nullable_7 = null;
							waypoint.waypoint_1.nullable_8 = null;
							waypoint.waypoint_1.enum82_0 = Waypoint.Enum82.const_0;
						}
						if (!Information.IsNothing(waypoint.waypoint_2))
						{
							waypoint.waypoint_2.nullable_7 = null;
							waypoint.waypoint_2.nullable_8 = null;
							waypoint.waypoint_2.enum82_0 = Waypoint.Enum82.const_0;
						}
						if (!Information.IsNothing(waypoint.waypoint_3))
						{
							waypoint.waypoint_3.nullable_7 = null;
							waypoint.waypoint_3.nullable_8 = null;
							waypoint.waypoint_3.enum82_0 = Waypoint.Enum82.const_0;
						}
						if (!Information.IsNothing(waypoint.waypoint_4))
						{
							waypoint.waypoint_4.nullable_7 = null;
							waypoint.waypoint_4.nullable_8 = null;
							waypoint.waypoint_4.enum82_0 = Waypoint.Enum82.const_0;
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

		// Token: 0x0600699B RID: 27035 RVA: 0x000430CB File Offset: 0x000412CB
		[CompilerGenerated]
		private bool method_34(Mission mission_1)
		{
			return Operators.CompareString(mission_1.string_0, this.flight_0.string_2, false) == 0;
		}

		// Token: 0x0600699C RID: 27036 RVA: 0x000430CB File Offset: 0x000412CB
		[CompilerGenerated]
		private bool method_35(Mission mission_1)
		{
			return Operators.CompareString(mission_1.string_0, this.flight_0.string_2, false) == 0;
		}

		// Token: 0x0600699D RID: 27037 RVA: 0x000430CB File Offset: 0x000412CB
		[CompilerGenerated]
		private bool method_36(Mission mission_1)
		{
			return Operators.CompareString(mission_1.string_0, this.flight_0.string_2, false) == 0;
		}

		// Token: 0x0600699E RID: 27038 RVA: 0x000430CB File Offset: 0x000412CB
		[CompilerGenerated]
		private bool method_37(Mission mission_1)
		{
			return Operators.CompareString(mission_1.string_0, this.flight_0.string_2, false) == 0;
		}

		// Token: 0x0600699F RID: 27039 RVA: 0x000430CB File Offset: 0x000412CB
		[CompilerGenerated]
		private bool method_38(Mission mission_1)
		{
			return Operators.CompareString(mission_1.string_0, this.flight_0.string_2, false) == 0;
		}

		// Token: 0x060069A0 RID: 27040 RVA: 0x000430CB File Offset: 0x000412CB
		[CompilerGenerated]
		private bool method_39(Mission mission_1)
		{
			return Operators.CompareString(mission_1.string_0, this.flight_0.string_2, false) == 0;
		}

		// Token: 0x060069A1 RID: 27041 RVA: 0x000430CB File Offset: 0x000412CB
		[CompilerGenerated]
		private bool method_40(Mission mission_1)
		{
			return Operators.CompareString(mission_1.string_0, this.flight_0.string_2, false) == 0;
		}

		// Token: 0x060069A2 RID: 27042 RVA: 0x000430CB File Offset: 0x000412CB
		[CompilerGenerated]
		private bool method_41(Mission mission_1)
		{
			return Operators.CompareString(mission_1.string_0, this.flight_0.string_2, false) == 0;
		}

		// Token: 0x060069A3 RID: 27043 RVA: 0x000430CB File Offset: 0x000412CB
		[CompilerGenerated]
		private bool method_42(Mission mission_1)
		{
			return Operators.CompareString(mission_1.string_0, this.flight_0.string_2, false) == 0;
		}

		// Token: 0x060069A4 RID: 27044 RVA: 0x000430CB File Offset: 0x000412CB
		[CompilerGenerated]
		private bool method_43(Mission mission_1)
		{
			return Operators.CompareString(mission_1.string_0, this.flight_0.string_2, false) == 0;
		}

		// Token: 0x04003C06 RID: 15366
		[AccessedThroughProperty("DGV_AirTaskingOrder")]
		[CompilerGenerated]
		private Class114 class114_0;

		// Token: 0x04003C07 RID: 15367
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x04003C08 RID: 15368
		[AccessedThroughProperty("ComboBox_PlannedFlightPlanVisibility")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x04003C09 RID: 15369
		[CompilerGenerated]
		[AccessedThroughProperty("Button_CreateFlight")]
		private Control9 control9_0;

		// Token: 0x04003C0A RID: 15370
		[CompilerGenerated]
		[AccessedThroughProperty("Button_FlightPlanEditor")]
		private Control9 control9_1;

		// Token: 0x04003C0B RID: 15371
		[AccessedThroughProperty("Button_ChangeAircraftType")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x04003C0C RID: 15372
		[CompilerGenerated]
		[AccessedThroughProperty("Button_DeleteFlight")]
		private Control9 control9_3;

		// Token: 0x04003C0D RID: 15373
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_1;

		// Token: 0x04003C0E RID: 15374
		[CompilerGenerated]
		[AccessedThroughProperty("ComboBox_AirborneFlightPlanVisibility")]
		private Class2451 class2451_1;

		// Token: 0x04003C0F RID: 15375
		[CompilerGenerated]
		[AccessedThroughProperty("Button_CopyFlight")]
		private Control9 control9_4;

		// Token: 0x04003C10 RID: 15376
		[AccessedThroughProperty("Button_ChangeTakeOffTime")]
		[CompilerGenerated]
		private Control9 control9_5;

		// Token: 0x04003C11 RID: 15377
		[AccessedThroughProperty("Button_ChangeObjectiveTime")]
		[CompilerGenerated]
		private Control9 control9_6;

		// Token: 0x04003C12 RID: 15378
		[AccessedThroughProperty("Button_ClearTime")]
		[CompilerGenerated]
		private Control9 control9_7;

		// Token: 0x04003C13 RID: 15379
		[AccessedThroughProperty("ComboBox_AirTaskingOrderSorting")]
		[CompilerGenerated]
		private Class2451 class2451_2;

		// Token: 0x04003C14 RID: 15380
		[AccessedThroughProperty("ComboBox_AirTaskingOrderFilter")]
		[CompilerGenerated]
		private Class2451 class2451_3;

		// Token: 0x04003C15 RID: 15381
		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		private Class116 class116_2;

		// Token: 0x04003C16 RID: 15382
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x04003C17 RID: 15383
		[AccessedThroughProperty("ID")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04003C18 RID: 15384
		[AccessedThroughProperty("MissionOrPackage")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04003C19 RID: 15385
		[AccessedThroughProperty("Callsign")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04003C1A RID: 15386
		[AccessedThroughProperty("Type")]
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;

		// Token: 0x04003C1B RID: 15387
		[AccessedThroughProperty("Status")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04003C1C RID: 15388
		[CompilerGenerated]
		[AccessedThroughProperty("Task")]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;

		// Token: 0x04003C1D RID: 15389
		[AccessedThroughProperty("AircraftType")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04003C1E RID: 15390
		[CompilerGenerated]
		[AccessedThroughProperty("LoadoutType")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x04003C1F RID: 15391
		[AccessedThroughProperty("TakeOffTimeZulu")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x04003C20 RID: 15392
		[CompilerGenerated]
		[AccessedThroughProperty("TakeOffTimeLocal")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		// Token: 0x04003C21 RID: 15393
		[AccessedThroughProperty("TakeOffTimeFixed")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		// Token: 0x04003C22 RID: 15394
		[CompilerGenerated]
		[AccessedThroughProperty("TakeOffTimeImg")]
		private DataGridViewImageColumn dataGridViewImageColumn_0;

		// Token: 0x04003C23 RID: 15395
		[AccessedThroughProperty("ObjectiveTimeZulu")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		// Token: 0x04003C24 RID: 15396
		[CompilerGenerated]
		[AccessedThroughProperty("ObjectiveTimeLocal")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		// Token: 0x04003C25 RID: 15397
		[CompilerGenerated]
		[AccessedThroughProperty("ObjectiveTimeFixed")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		// Token: 0x04003C26 RID: 15398
		[AccessedThroughProperty("ObjectiveTimeImg")]
		[CompilerGenerated]
		private DataGridViewImageColumn dataGridViewImageColumn_1;

		// Token: 0x04003C27 RID: 15399
		[CompilerGenerated]
		[AccessedThroughProperty("TakeOffLocation")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		// Token: 0x04003C28 RID: 15400
		[CompilerGenerated]
		[AccessedThroughProperty("LandingLocation")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		// Token: 0x04003C29 RID: 15401
		[CompilerGenerated]
		[AccessedThroughProperty("AlternativeLandingLocation")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		// Token: 0x04003C2A RID: 15402
		[CompilerGenerated]
		[AccessedThroughProperty("DesiredAircraftQty")]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_2;

		// Token: 0x04003C2B RID: 15403
		[CompilerGenerated]
		[AccessedThroughProperty("MinimumAircraftQty")]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_3;

		// Token: 0x04003C2C RID: 15404
		[CompilerGenerated]
		[AccessedThroughProperty("AssignedAircraftQty")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		// Token: 0x04003C2D RID: 15405
		[AccessedThroughProperty("ReadyAircraftQty")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		// Token: 0x04003C2E RID: 15406
		[AccessedThroughProperty("Priority")]
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4;

		// Token: 0x04003C2F RID: 15407
		[CompilerGenerated]
		[AccessedThroughProperty("CreatedBy")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		// Token: 0x04003C30 RID: 15408
		[CompilerGenerated]
		[AccessedThroughProperty("EditedBy")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		// Token: 0x04003C31 RID: 15409
		public Mission mission_0;

		// Token: 0x04003C32 RID: 15410
		public Mission.Flight flight_0;

		// Token: 0x04003C33 RID: 15411
		public List<Mission.Flight> list_0;

		// Token: 0x04003C34 RID: 15412
		private bool bool_3;

		// Token: 0x04003C35 RID: 15413
		private string string_0;

		// Token: 0x04003C36 RID: 15414
		private int int_0;

		// Token: 0x04003C37 RID: 15415
		private DataTable dataTable_0;

		// Token: 0x04003C38 RID: 15416
		private AirTaskingOrder.Enum200 enum200_0;

		// Token: 0x04003C39 RID: 15417
		public string string_1;

		// Token: 0x04003C3A RID: 15418
		private int int_1;

		// Token: 0x04003C3B RID: 15419
		private int int_2;

		// Token: 0x04003C3C RID: 15420
		private int int_3;

		// Token: 0x04003C3D RID: 15421
		private int int_4;

		// Token: 0x04003C3E RID: 15422
		private int int_5;

		// Token: 0x04003C3F RID: 15423
		private int int_6;

		// Token: 0x04003C40 RID: 15424
		private int int_7;

		// Token: 0x04003C41 RID: 15425
		private int int_8;

		// Token: 0x04003C42 RID: 15426
		private int int_9;

		// Token: 0x04003C43 RID: 15427
		private int int_10;

		// Token: 0x04003C44 RID: 15428
		private int int_11;

		// Token: 0x04003C45 RID: 15429
		private int int_12;

		// Token: 0x04003C46 RID: 15430
		private int int_13;

		// Token: 0x04003C47 RID: 15431
		private int int_14;

		// Token: 0x04003C48 RID: 15432
		private int int_15;

		// Token: 0x04003C49 RID: 15433
		private int int_16;

		// Token: 0x04003C4A RID: 15434
		private int int_17;

		// Token: 0x04003C4B RID: 15435
		private int int_18;

		// Token: 0x04003C4C RID: 15436
		private int int_19;

		// Token: 0x04003C4D RID: 15437
		private int int_20;

		// Token: 0x04003C4E RID: 15438
		private int int_21;

		// Token: 0x04003C4F RID: 15439
		private int int_22;

		// Token: 0x04003C50 RID: 15440
		private int int_23;

		// Token: 0x04003C51 RID: 15441
		private int int_24;

		// Token: 0x04003C52 RID: 15442
		private int int_25;

		// Token: 0x04003C53 RID: 15443
		private int int_26;

		// Token: 0x04003C54 RID: 15444
		private Bitmap bitmap_0;

		// Token: 0x04003C55 RID: 15445
		private Bitmap bitmap_1;

		// Token: 0x04003C56 RID: 15446
		private Bitmap bitmap_2;

		// Token: 0x04003C57 RID: 15447
		private Bitmap bitmap_3;

		// Token: 0x04003C58 RID: 15448
		private Bitmap bitmap_4;

		// Token: 0x02000E15 RID: 3605
		internal enum Enum200 : byte
		{
			// Token: 0x04003C5A RID: 15450
			const_0,
			// Token: 0x04003C5B RID: 15451
			const_1,
			// Token: 0x04003C5C RID: 15452
			const_2
		}

		// Token: 0x02000E17 RID: 3607
		[CompilerGenerated]
		internal sealed class Class2464
		{
			// Token: 0x060069B9 RID: 27065 RVA: 0x00043128 File Offset: 0x00041328
			public Class2464(AirTaskingOrder.Class2464 class2464_0)
			{
				if (class2464_0 != null)
				{
					this.flight_0 = class2464_0.flight_0;
				}
			}

			// Token: 0x060069BA RID: 27066 RVA: 0x0004313F File Offset: 0x0004133F
			internal bool method_0(Mission mission_0)
			{
				return Operators.CompareString(mission_0.string_0, this.flight_0.string_2, false) == 0;
			}

			// Token: 0x04003C70 RID: 15472
			public Mission.Flight flight_0;

			// Token: 0x04003C71 RID: 15473
			public Func<Mission, bool> func_0;
		}
	}
}
