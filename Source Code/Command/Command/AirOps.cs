using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns10;
using ns12;
using ns13;
using ns2;
using ns3;
using ns4;
using ns5;
using ns7;
using ns8;
using ns9;

namespace Command
{
	// Token: 0x02000E90 RID: 3728
	[DesignerGenerated]
	public sealed partial class AirOps : DarkSecondaryFormBase, Interface66
	{
		// Token: 0x06007388 RID: 29576 RVA: 0x003E56C0 File Offset: 0x003E38C0
		public AirOps()
		{
			base.FormClosing += this.AirOps_FormClosing;
			base.Shown += this.AirOps_Shown;
			base.KeyDown += this.AirOps_KeyDown;
			base.FormClosed += this.AirOps_FormClosed;
			base.Load += this.AirOps_Load;
			this.hashSet_0 = new HashSet<string>();
			this.hashSet_1 = new HashSet<string>();
			this.list_0 = new List<Aircraft>();
			this.list_1 = new List<Aircraft>();
			this.class2419_0 = new Class2419();
			this.list_2 = new List<int>();
			this.dataTable_0 = new DataTable();
			this.dataTable_1 = new DataTable();
			this.dictionary_0 = new Dictionary<int, int>();
			this.vmethod_116(new BackgroundWorker());
			this.InitializeComponent_1();
		}

		// Token: 0x0600738A RID: 29578 RVA: 0x003E57E4 File Offset: 0x003E39E4
		private void InitializeComponent_1()
		{
			this.icontainer_1 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AirOps));
			this.vmethod_58(new ContextMenuStrip(this.icontainer_1));
			this.vmethod_68(new Class128());
			this.vmethod_70(new Class128());
			this.vmethod_72(new Class128());
			this.vmethod_74(new Class128());
			this.vmethod_76(new ToolStripSeparator());
			this.vmethod_60(new Class128());
			this.vmethod_62(new Class128());
			this.vmethod_78(new ToolStripSeparator());
			this.vmethod_80(new Class128());
			this.vmethod_82(new Class128());
			this.vmethod_84(new Class128());
			this.vmethod_9(new Class44());
			this.vmethod_11(new Class44());
			this.vmethod_7(new Timer(this.icontainer_1));
			this.vmethod_20(new Timer(this.icontainer_1));
			this.vmethod_1(new Control12());
			this.vmethod_3(new TabPage());
			this.vmethod_106(new FlowLayoutPanel());
			this.vmethod_90(new Class112());
			this.vmethod_54(new Class2451());
			this.vmethod_52(new Class116());
			this.vmethod_92(new Class116());
			this.vmethod_48(new Class116());
			this.vmethod_50(new Class116());
			this.vmethod_40(new Class116());
			this.vmethod_38(new Class116());
			this.vmethod_28(new Class116());
			this.vmethod_30(new Class116());
			this.vmethod_32(new Class116());
			this.vmethod_34(new Class116());
			this.vmethod_36(new Class114());
			this.vmethod_108(new DataGridViewTextBoxColumn());
			this.vmethod_110(new DataGridViewLinkColumn());
			this.vmethod_112(new DataGridViewTextBoxColumn());
			this.vmethod_114(new DataGridViewTextBoxColumn());
			this.vmethod_22(new Class50());
			this.vmethod_94(new Class44());
			this.vmethod_96(new DataGridViewTextBoxColumn());
			this.vmethod_98(new DataGridViewTextBoxColumn());
			this.vmethod_100(new DataGridViewTextBoxColumn());
			this.vmethod_102(new DataGridViewTextBoxColumn());
			this.vmethod_104(new DataGridViewTextBoxColumn());
			this.vmethod_88(new Class125());
			this.vmethod_13(new ToolStripButton());
			this.vmethod_17(new ToolStripButton());
			this.vmethod_15(new ToolStripButton());
			this.vmethod_26(new ToolStripButton());
			this.vmethod_56(new ToolStripSeparator());
			this.vmethod_66(new ToolStripButton());
			this.vmethod_64(new ToolStripDropDownButton());
			this.vmethod_24(new ToolStripSeparator());
			this.vmethod_42(new ToolStripButton());
			this.vmethod_44(new ToolStripButton());
			this.vmethod_46(new ToolStripButton());
			this.vmethod_86(new ToolStripButton());
			this.vmethod_5(new TabPage());
			this.vmethod_19(new Control6());
			this.vmethod_57().SuspendLayout();
			this.vmethod_0().SuspendLayout();
			this.vmethod_2().SuspendLayout();
			this.vmethod_105().SuspendLayout();
			((ISupportInitialize)this.vmethod_35()).BeginInit();
			((ISupportInitialize)this.vmethod_21()).BeginInit();
			this.vmethod_87().SuspendLayout();
			this.vmethod_4().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_57().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_67(),
				this.vmethod_69(),
				this.vmethod_71(),
				this.vmethod_73(),
				this.vmethod_75(),
				this.vmethod_59(),
				this.vmethod_61(),
				this.vmethod_77(),
				this.vmethod_79(),
				this.vmethod_81(),
				this.vmethod_83()
			});
			this.vmethod_57().Name = "CMenu_Unit";
			this.vmethod_57().Size = new Size(178, 214);
			this.vmethod_67().Name = "LaunchIndividuallyToolStripMenuItem";
			this.vmethod_67().Size = new Size(177, 22);
			this.vmethod_67().Text = "Launch individually";
			this.vmethod_69().Name = "LaunchAsGroupsToolStripMenuItem";
			this.vmethod_69().Size = new Size(177, 22);
			this.vmethod_69().Text = "Launch as group(s)";
			this.vmethod_71().Name = "ReadyArmToolStripMenuItem";
			this.vmethod_71().Size = new Size(177, 22);
			this.vmethod_71().Text = "Ready / Arm";
			this.vmethod_73().Name = "AbortLaunchToolStripMenuItem";
			this.vmethod_73().Size = new Size(177, 22);
			this.vmethod_73().Text = "Abort Launch";
			this.vmethod_75().Name = "ToolStripSeparator3";
			this.vmethod_75().Size = new Size(174, 6);
			this.vmethod_59().Name = "TSMI_Doctrine";
			this.vmethod_59().Size = new Size(177, 22);
			this.vmethod_59().Text = "Doctrine";
			this.vmethod_61().Name = "TSMI_AssignToMission";
			this.vmethod_61().Size = new Size(177, 22);
			this.vmethod_61().Text = "Assign to mission";
			this.vmethod_77().Name = "ToolStripSeparator4";
			this.vmethod_77().Size = new Size(174, 6);
			this.vmethod_79().Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_79().ForeColor = Color.Red;
			this.vmethod_79().Name = "SetTimeToReadyToolStripMenuItem";
			this.vmethod_79().Size = new Size(177, 22);
			this.vmethod_79().Text = "Set time to ready";
			this.vmethod_81().Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_81().ForeColor = Color.Red;
			this.vmethod_81().Name = "RenameToolStripMenuItem";
			this.vmethod_81().Size = new Size(177, 22);
			this.vmethod_81().Text = "Rename";
			this.vmethod_83().Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_83().ForeColor = Color.Red;
			this.vmethod_83().Name = "RemoveToolStripMenuItem";
			this.vmethod_83().Size = new Size(177, 22);
			this.vmethod_83().Text = "Remove";
			this.vmethod_8().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_8().method_0(null);
			this.vmethod_8().HeaderText = "Facilities & Aircraft";
			this.vmethod_8().Name = "Facilities";
			this.vmethod_8().ReadOnly = true;
			this.vmethod_8().Resizable = DataGridViewTriState.True;
			this.vmethod_8().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_10().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_10().method_0(null);
			this.vmethod_10().HeaderText = "Status";
			this.vmethod_10().Name = "theStatus";
			this.vmethod_10().ReadOnly = true;
			this.vmethod_10().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_6().Interval = 1000;
			this.vmethod_0().Controls.Add(this.vmethod_2());
			this.vmethod_0().Controls.Add(this.vmethod_4());
			this.vmethod_0().Cursor = Cursors.Hand;
			this.vmethod_0().Dock = DockStyle.Fill;
			this.vmethod_0().ItemSize = new Size(80, 20);
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "TabControl1";
			this.vmethod_0().SelectedIndex = 0;
			this.vmethod_0().Size = new Size(1094, 571);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().Controls.Add(this.vmethod_105());
			this.vmethod_2().Controls.Add(this.vmethod_91());
			this.vmethod_2().Controls.Add(this.vmethod_47());
			this.vmethod_2().Controls.Add(this.vmethod_49());
			this.vmethod_2().Controls.Add(this.vmethod_39());
			this.vmethod_2().Controls.Add(this.vmethod_37());
			this.vmethod_2().Controls.Add(this.vmethod_27());
			this.vmethod_2().Controls.Add(this.vmethod_29());
			this.vmethod_2().Controls.Add(this.vmethod_31());
			this.vmethod_2().Controls.Add(this.vmethod_33());
			this.vmethod_2().Controls.Add(this.vmethod_35());
			this.vmethod_2().Controls.Add(this.vmethod_21());
			this.vmethod_2().Controls.Add(this.vmethod_87());
			this.vmethod_2().Location = new Point(4, 24);
			this.vmethod_2().Name = "TabPage1";
			this.vmethod_2().Padding = new Padding(3);
			this.vmethod_2().Size = new Size(1086, 543);
			this.vmethod_2().TabIndex = 0;
			this.vmethod_2().Text = "Aircraft Status";
			this.vmethod_105().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_105().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_105().Controls.Add(this.vmethod_89());
			this.vmethod_105().Controls.Add(this.vmethod_53());
			this.vmethod_105().Controls.Add(this.vmethod_51());
			this.vmethod_105().Location = new Point(3, 309);
			this.vmethod_105().Name = "FlowLayoutPanel1";
			this.vmethod_105().Size = new Size(1080, 31);
			this.vmethod_105().TabIndex = 36;
			this.vmethod_89().Anchor = AnchorStyles.Left;
			this.vmethod_89().Location = new Point(3, 6);
			this.vmethod_89().Name = "CB_QuickTurnaround";
			this.vmethod_89().Size = new Size(148, 17);
			this.vmethod_89().TabIndex = 32;
			this.vmethod_89().Text = "Enable Quick Turnaround";
			this.vmethod_53().Anchor = AnchorStyles.Left;
			this.vmethod_53().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_53().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_53().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_53().FormattingEnabled = true;
			this.vmethod_53().Location = new Point(157, 3);
			this.vmethod_53().Name = "Combo_NumberOfSorties";
			this.vmethod_53().Size = new Size(166, 24);
			this.vmethod_53().TabIndex = 33;
			this.vmethod_51().Anchor = AnchorStyles.Left;
			this.vmethod_51().method_2(true);
			this.vmethod_51().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_51().Location = new Point(329, 8);
			this.vmethod_51().Name = "Label_QuickTurnaroundInfo";
			this.vmethod_51().Size = new Size(39, 13);
			this.vmethod_51().TabIndex = 34;
			this.vmethod_51().Text = "Label1";
			this.vmethod_91().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_91().method_2(true);
			this.vmethod_91().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_91().Location = new Point(655, 412);
			this.vmethod_91().MaximumSize = new Size(400, 40);
			this.vmethod_91().MinimumSize = new Size(400, 40);
			this.vmethod_91().Name = "Label3";
			this.vmethod_91().Size = new Size(400, 40);
			this.vmethod_91().TabIndex = 35;
			this.vmethod_91().Text = "WeaponState";
			this.vmethod_47().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_47().method_2(true);
			this.vmethod_47().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_47().Location = new Point(655, 483);
			this.vmethod_47().Name = "Label7";
			this.vmethod_47().Size = new Size(123, 13);
			this.vmethod_47().TabIndex = 31;
			this.vmethod_47().Text = "NumberOfLoadoutsTotal";
			this.vmethod_49().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_49().method_2(true);
			this.vmethod_49().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_49().Location = new Point(655, 498);
			this.vmethod_49().Name = "Label8";
			this.vmethod_49().Size = new Size(200, 13);
			this.vmethod_49().TabIndex = 30;
			this.vmethod_49().Text = "NumberOfLoadoutsTotal_MandatoryOnly";
			this.vmethod_39().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_39().method_2(true);
			this.vmethod_39().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_39().Location = new Point(655, 468);
			this.vmethod_39().Name = "Label6";
			this.vmethod_39().Size = new Size(137, 13);
			this.vmethod_39().TabIndex = 29;
			this.vmethod_39().Text = "NumberOfLoadoutsOnBase";
			this.vmethod_37().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_37().method_2(true);
			this.vmethod_37().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_37().Location = new Point(655, 373);
			this.vmethod_37().MaximumSize = new Size(400, 38);
			this.vmethod_37().MinimumSize = new Size(400, 38);
			this.vmethod_37().Name = "Label1";
			this.vmethod_37().Size = new Size(400, 38);
			this.vmethod_37().TabIndex = 28;
			this.vmethod_37().Text = "RangeProfile";
			this.vmethod_27().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_27().method_2(true);
			this.vmethod_27().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_27().Location = new Point(655, 453);
			this.vmethod_27().Name = "Label5";
			this.vmethod_27().Size = new Size(73, 13);
			this.vmethod_27().TabIndex = 27;
			this.vmethod_27().Text = "AttackAltitude";
			this.vmethod_29().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_29().method_2(true);
			this.vmethod_29().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_29().Location = new Point(655, 358);
			this.vmethod_29().Name = "Label4";
			this.vmethod_29().Size = new Size(60, 13);
			this.vmethod_29().TabIndex = 26;
			this.vmethod_29().Text = "TimeOfDay";
			this.vmethod_31().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_31().method_2(true);
			this.vmethod_31().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_31().Location = new Point(655, 343);
			this.vmethod_31().Name = "Label2";
			this.vmethod_31().Size = new Size(121, 13);
			this.vmethod_31().TabIndex = 24;
			this.vmethod_31().Text = "LoadoutRoleDescription";
			this.vmethod_33().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_33().method_2(true);
			this.vmethod_33().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_33().Location = new Point(3, 347);
			this.vmethod_33().Name = "Label_Loadout";
			this.vmethod_33().Size = new Size(84, 13);
			this.vmethod_33().TabIndex = 23;
			this.vmethod_33().Text = "Loadout Details:";
			this.vmethod_35().AllowUserToAddRows = false;
			this.vmethod_35().AllowUserToDeleteRows = false;
			this.vmethod_35().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_35().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			this.vmethod_35().AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.vmethod_35().BackgroundColor = Color.FromArgb(43, 43, 43);
			this.vmethod_35().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_35().CausesValidation = false;
			this.vmethod_35().CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.vmethod_35().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.LightGray;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_35().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_35().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_35().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_107(),
				this.vmethod_109(),
				this.vmethod_111(),
				this.vmethod_113()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_35().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_35().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_35().EnableHeadersVisualStyles = false;
			this.vmethod_35().Location = new Point(3, 363);
			this.vmethod_35().MultiSelect = false;
			this.vmethod_35().Name = "DGV_LoadoutItems";
			this.vmethod_35().RowHeadersVisible = false;
			this.vmethod_35().RowHeadersWidth = 20;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_35().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_35().RowTemplate.Height = 15;
			this.vmethod_35().RowTemplate.Resizable = DataGridViewTriState.False;
			this.vmethod_35().ScrollBars = ScrollBars.Vertical;
			this.vmethod_35().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_35().Size = new Size(650, 149);
			this.vmethod_35().TabIndex = 22;
			this.vmethod_107().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_107().DataPropertyName = "ComponentID";
			this.vmethod_107().HeaderText = "ID";
			this.vmethod_107().Name = "ComponentID";
			this.vmethod_107().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_107().Visible = false;
			this.vmethod_109().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_109().DataPropertyName = "Item";
			this.vmethod_109().HeaderText = "Stores (click for info)";
			this.vmethod_109().LinkBehavior = LinkBehavior.HoverUnderline;
			this.vmethod_109().LinkColor = Color.LightBlue;
			this.vmethod_109().MinimumWidth = 470;
			this.vmethod_109().Name = "Column_Description";
			this.vmethod_109().ReadOnly = true;
			this.vmethod_109().Resizable = DataGridViewTriState.True;
			this.vmethod_109().TrackVisitedState = false;
			this.vmethod_109().Width = 470;
			this.vmethod_111().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_111().DataPropertyName = "Available";
			this.vmethod_111().HeaderText = "# Available, Magazines";
			this.vmethod_111().MinimumWidth = 90;
			this.vmethod_111().Name = "Available";
			this.vmethod_111().ReadOnly = true;
			this.vmethod_111().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_111().ToolTipText = "The number of weapons available in the base's ammo dump";
			this.vmethod_113().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_113().DataPropertyName = "AvailableTotal";
			this.vmethod_113().HeaderText = "# Available, Mags + A/C";
			this.vmethod_113().MinimumWidth = 90;
			this.vmethod_113().Name = "AvailableTotal";
			this.vmethod_113().ReadOnly = true;
			this.vmethod_113().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_113().ToolTipText = "The total number of weapons available including those mounted on the currently selected aircraft";
			this.vmethod_21().AllowUserToAddRows = false;
			this.vmethod_21().AllowUserToDeleteRows = false;
			this.vmethod_21().AllowUserToOrderColumns = true;
			this.vmethod_21().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_21().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
			this.vmethod_21().AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			this.vmethod_21().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_21().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_21().CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.vmethod_21().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle4.ForeColor = Color.LightGray;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			this.vmethod_21().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_21().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_93(),
				this.vmethod_95(),
				this.vmethod_97(),
				this.vmethod_99(),
				this.vmethod_101(),
				this.vmethod_103()
			});
			this.vmethod_21().ContextMenuStrip = this.vmethod_57();
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle5.ForeColor = Color.LightGray;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
			this.vmethod_21().DefaultCellStyle = dataGridViewCellStyle5;
			this.vmethod_21().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_21().EnableHeadersVisualStyles = false;
			this.vmethod_21().method_9(null);
			this.vmethod_21().Location = new Point(3, 3);
			this.vmethod_21().Name = "TGV_Aircraft";
			this.vmethod_21().RowHeadersVisible = false;
			this.vmethod_21().RowHeadersWidth = 20;
			this.vmethod_21().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_21().method_7(false);
			this.vmethod_21().Size = new Size(1080, 300);
			this.vmethod_21().TabIndex = 7;
			this.vmethod_93().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_93().method_0(null);
			this.vmethod_93().FillWeight = 60f;
			this.vmethod_93().HeaderText = "Aircraft (click for info)";
			this.vmethod_93().Name = "Aircraft";
			this.vmethod_93().ReadOnly = true;
			this.vmethod_93().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_95().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_95().HeaderText = "Status";
			this.vmethod_95().MinimumWidth = 43;
			this.vmethod_95().Name = "Status";
			this.vmethod_95().ReadOnly = true;
			this.vmethod_95().Resizable = DataGridViewTriState.True;
			this.vmethod_95().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_95().Width = 43;
			this.vmethod_97().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_97().FillWeight = 50f;
			this.vmethod_97().HeaderText = "Mission";
			this.vmethod_97().Name = "Mission";
			this.vmethod_97().ReadOnly = true;
			this.vmethod_97().Resizable = DataGridViewTriState.True;
			this.vmethod_97().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_99().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_99().HeaderText = "Loadout";
			this.vmethod_99().Name = "Loadout";
			this.vmethod_99().ReadOnly = true;
			this.vmethod_99().Resizable = DataGridViewTriState.True;
			this.vmethod_99().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_101().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_101().HeaderText = "Time to ready";
			this.vmethod_101().MinimumWidth = 77;
			this.vmethod_101().Name = "TimeToReady";
			this.vmethod_101().ReadOnly = true;
			this.vmethod_101().Resizable = DataGridViewTriState.True;
			this.vmethod_101().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_101().Width = 77;
			this.vmethod_103().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_103().HeaderText = "Quick Turnaround";
			this.vmethod_103().MinimumWidth = 97;
			this.vmethod_103().Name = "QuickTurnaroundDescription";
			this.vmethod_103().ReadOnly = true;
			this.vmethod_103().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_103().Width = 97;
			this.vmethod_87().AutoSize = false;
			this.vmethod_87().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_87().Dock = DockStyle.Bottom;
			this.vmethod_87().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_87().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_87().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_12(),
				this.vmethod_16(),
				this.vmethod_14(),
				this.vmethod_25(),
				this.vmethod_55(),
				this.vmethod_65(),
				this.vmethod_63(),
				this.vmethod_23(),
				this.vmethod_41(),
				this.vmethod_43(),
				this.vmethod_45(),
				this.vmethod_85()
			});
			this.vmethod_87().Location = new Point(3, 515);
			this.vmethod_87().Name = "ToolStrip1";
			this.vmethod_87().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_87().Size = new Size(1080, 25);
			this.vmethod_87().TabIndex = 1;
			this.vmethod_87().Text = "ToolStrip1";
			this.vmethod_12().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().ImageTransparentColor = Color.Magenta;
			this.vmethod_12().Name = "ToolStripButton1";
			this.vmethod_12().Size = new Size(114, 22);
			this.vmethod_12().Text = "Launch individually";
			this.vmethod_16().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().ImageTransparentColor = Color.Magenta;
			this.vmethod_16().Name = "ToolStripButton3";
			this.vmethod_16().Size = new Size(112, 22);
			this.vmethod_16().Text = "Launch as group(s)";
			this.vmethod_14().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().ImageTransparentColor = Color.Magenta;
			this.vmethod_14().Name = "ToolStripButton2";
			this.vmethod_14().Size = new Size(77, 22);
			this.vmethod_14().Text = "Ready / Arm";
			this.vmethod_25().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_25().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_25().ImageTransparentColor = Color.Magenta;
			this.vmethod_25().Name = "TSB_AbortLaunch";
			this.vmethod_25().Size = new Size(83, 22);
			this.vmethod_25().Text = "Abort Launch";
			this.vmethod_55().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_55().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_55().Margin = new Padding(0, 0, 2, 0);
			this.vmethod_55().Name = "ToolStripSeparator2";
			this.vmethod_55().Size = new Size(6, 25);
			this.vmethod_65().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_65().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_65().ImageTransparentColor = Color.Magenta;
			this.vmethod_65().Name = "TSB_Doctrine";
			this.vmethod_65().Size = new Size(56, 22);
			this.vmethod_65().Text = "Doctrine";
			this.vmethod_63().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_63().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_63().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_63().ImageTransparentColor = Color.Magenta;
			this.vmethod_63().Name = "TSB_AssignToMission";
			this.vmethod_63().Size = new Size(113, 22);
			this.vmethod_63().Text = "Assign to mission";
			this.vmethod_23().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_23().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_23().Margin = new Padding(0, 0, 2, 0);
			this.vmethod_23().Name = "ToolStripSeparator1";
			this.vmethod_23().Size = new Size(6, 25);
			this.vmethod_41().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_41().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_41().Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.vmethod_41().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_41().ImageTransparentColor = Color.Magenta;
			this.vmethod_41().Name = "TSB_SetReadyTime";
			this.vmethod_41().Size = new Size(108, 22);
			this.vmethod_41().Text = "Set time to ready";
			this.vmethod_43().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_43().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_43().Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.vmethod_43().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_43().ImageTransparentColor = Color.Magenta;
			this.vmethod_43().Name = "TSB_Rename";
			this.vmethod_43().Size = new Size(57, 22);
			this.vmethod_43().Text = "Rename";
			this.vmethod_45().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_45().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_45().Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.vmethod_45().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_45().ImageTransparentColor = Color.Magenta;
			this.vmethod_45().Name = "TSB_Delete";
			this.vmethod_45().Size = new Size(58, 22);
			this.vmethod_45().Text = "Remove";
			this.vmethod_85().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_85().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_85().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_85().Image = (Image)componentResourceManager.GetObject("TSB_Cargo.Image");
			this.vmethod_85().ImageTransparentColor = Color.Magenta;
			this.vmethod_85().Name = "TSB_Cargo";
			this.vmethod_85().Size = new Size(121, 22);
			this.vmethod_85().Text = "Cargo Load / Unload";
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().Controls.Add(this.vmethod_18());
			this.vmethod_4().Location = new Point(4, 24);
			this.vmethod_4().Name = "TabPage2";
			this.vmethod_4().Padding = new Padding(3);
			this.vmethod_4().Size = new Size(1086, 543);
			this.vmethod_4().TabIndex = 1;
			this.vmethod_4().Text = "Air Facilities";
			this.vmethod_18().Dock = DockStyle.Fill;
			this.vmethod_18().Location = new Point(3, 3);
			this.vmethod_18().method_6(20);
			this.vmethod_18().Name = "TV_Facilities";
			this.vmethod_18().Size = new Size(1080, 537);
			this.vmethod_18().TabIndex = 7;
			this.vmethod_85().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_85().Image = (Image)componentResourceManager.GetObject("TSB_Cargo.Image");
			this.vmethod_85().ImageTransparentColor = Color.Magenta;
			this.vmethod_85().Name = "TSB_Cargo";
			this.vmethod_85().Size = new Size(121, 22);
			this.vmethod_85().Text = "Un/Load Cargo";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1094, 571);
			base.Controls.Add(this.vmethod_0());
			this.DoubleBuffered = true;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AirOps";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Air Ops";
			this.vmethod_57().ResumeLayout(false);
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			this.vmethod_105().ResumeLayout(false);
			this.vmethod_105().PerformLayout();
			((ISupportInitialize)this.vmethod_35()).EndInit();
			((ISupportInitialize)this.vmethod_21()).EndInit();
			this.vmethod_87().ResumeLayout(false);
			this.vmethod_87().PerformLayout();
			this.vmethod_4().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0600738B RID: 29579 RVA: 0x0004819E File Offset: 0x0004639E
		[CompilerGenerated]
		internal Control12 vmethod_0()
		{
			return this.control12_0;
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x003E7C08 File Offset: 0x003E5E08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control12 control12_1)
		{
			EventHandler value = new EventHandler(this.method_22);
			Control12 control = this.control12_0;
			if (control != null)
			{
				control.SelectedIndexChanged -= value;
			}
			this.control12_0 = control12_1;
			control = this.control12_0;
			if (control != null)
			{
				control.SelectedIndexChanged += value;
			}
		}

		// Token: 0x0600738D RID: 29581 RVA: 0x000481A6 File Offset: 0x000463A6
		[CompilerGenerated]
		internal TabPage vmethod_2()
		{
			return this.tabPage_0;
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x000481AE File Offset: 0x000463AE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TabPage tabPage_2)
		{
			this.tabPage_0 = tabPage_2;
		}

		// Token: 0x0600738F RID: 29583 RVA: 0x000481B7 File Offset: 0x000463B7
		[CompilerGenerated]
		internal TabPage vmethod_4()
		{
			return this.tabPage_1;
		}

		// Token: 0x06007390 RID: 29584 RVA: 0x000481BF File Offset: 0x000463BF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(TabPage tabPage_2)
		{
			this.tabPage_1 = tabPage_2;
		}

		// Token: 0x06007391 RID: 29585 RVA: 0x000481C8 File Offset: 0x000463C8
		[CompilerGenerated]
		internal Timer vmethod_6()
		{
			return this.timer_0;
		}

		// Token: 0x06007392 RID: 29586 RVA: 0x003E7C4C File Offset: 0x003E5E4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Timer timer_2)
		{
			EventHandler value = new EventHandler(this.method_12);
			Timer timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.timer_0 = timer_2;
			timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06007393 RID: 29587 RVA: 0x000481D0 File Offset: 0x000463D0
		[CompilerGenerated]
		internal Class44 vmethod_8()
		{
			return this.class44_0;
		}

		// Token: 0x06007394 RID: 29588 RVA: 0x000481D8 File Offset: 0x000463D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class44 class44_3)
		{
			this.class44_0 = class44_3;
		}

		// Token: 0x06007395 RID: 29589 RVA: 0x000481E1 File Offset: 0x000463E1
		[CompilerGenerated]
		internal Class44 vmethod_10()
		{
			return this.class44_1;
		}

		// Token: 0x06007396 RID: 29590 RVA: 0x000481E9 File Offset: 0x000463E9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class44 class44_3)
		{
			this.class44_1 = class44_3;
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x000481F2 File Offset: 0x000463F2
		[CompilerGenerated]
		internal ToolStripButton vmethod_12()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06007398 RID: 29592 RVA: 0x003E7C90 File Offset: 0x003E5E90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_23);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_9;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06007399 RID: 29593 RVA: 0x000481FA File Offset: 0x000463FA
		[CompilerGenerated]
		internal ToolStripButton vmethod_14()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x0600739A RID: 29594 RVA: 0x003E7CD4 File Offset: 0x003E5ED4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_26);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_9;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600739B RID: 29595 RVA: 0x00048202 File Offset: 0x00046402
		[CompilerGenerated]
		internal ToolStripButton vmethod_16()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x0600739C RID: 29596 RVA: 0x003E7D18 File Offset: 0x003E5F18
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_30);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_9;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600739D RID: 29597 RVA: 0x0004820A File Offset: 0x0004640A
		[CompilerGenerated]
		internal Control6 vmethod_18()
		{
			return this.control6_0;
		}

		// Token: 0x0600739E RID: 29598 RVA: 0x00048212 File Offset: 0x00046412
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Control6 control6_1)
		{
			this.control6_0 = control6_1;
		}

		// Token: 0x0600739F RID: 29599 RVA: 0x0004821B File Offset: 0x0004641B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_20(Timer timer_2)
		{
			this.timer_1 = timer_2;
		}

		// Token: 0x060073A0 RID: 29600 RVA: 0x00048224 File Offset: 0x00046424
		[CompilerGenerated]
		private Class50 vmethod_21()
		{
			return this.class50_0;
		}

		// Token: 0x060073A1 RID: 29601 RVA: 0x003E7D5C File Offset: 0x003E5F5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_22(Class50 class50_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_28);
			Delegate3 delegate3_ = new Delegate3(this.method_29);
			EventHandler value2 = new EventHandler(this.method_36);
			Delegate2 delegate2_ = new Delegate2(this.method_68);
			Class50 @class = this.class50_0;
			if (@class != null)
			{
				@class.CellContentClick -= value;
				@class.method_16(delegate3_);
				@class.SelectionChanged -= value2;
				@class.method_14(delegate2_);
			}
			this.class50_0 = class50_1;
			@class = this.class50_0;
			if (@class != null)
			{
				@class.CellContentClick += value;
				@class.method_15(delegate3_);
				@class.SelectionChanged += value2;
				@class.method_13(delegate2_);
			}
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x0004822C File Offset: 0x0004642C
		[CompilerGenerated]
		internal ToolStripSeparator vmethod_23()
		{
			return this.toolStripSeparator_0;
		}

		// Token: 0x060073A3 RID: 29603 RVA: 0x00048234 File Offset: 0x00046434
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_24(ToolStripSeparator toolStripSeparator_4)
		{
			this.toolStripSeparator_0 = toolStripSeparator_4;
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x0004823D File Offset: 0x0004643D
		[CompilerGenerated]
		internal ToolStripButton vmethod_25()
		{
			return this.toolStripButton_3;
		}

		// Token: 0x060073A5 RID: 29605 RVA: 0x003E7DFC File Offset: 0x003E5FFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_26(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_34);
			ToolStripButton toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_3 = toolStripButton_9;
			toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060073A6 RID: 29606 RVA: 0x00048245 File Offset: 0x00046445
		[CompilerGenerated]
		internal Class116 vmethod_27()
		{
			return this.class116_0;
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x0004824D File Offset: 0x0004644D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_28(Class116 class116_10)
		{
			this.class116_0 = class116_10;
		}

		// Token: 0x060073A8 RID: 29608 RVA: 0x00048256 File Offset: 0x00046456
		[CompilerGenerated]
		internal Class116 vmethod_29()
		{
			return this.class116_1;
		}

		// Token: 0x060073A9 RID: 29609 RVA: 0x0004825E File Offset: 0x0004645E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_30(Class116 class116_10)
		{
			this.class116_1 = class116_10;
		}

		// Token: 0x060073AA RID: 29610 RVA: 0x00048267 File Offset: 0x00046467
		[CompilerGenerated]
		internal Class116 vmethod_31()
		{
			return this.class116_2;
		}

		// Token: 0x060073AB RID: 29611 RVA: 0x0004826F File Offset: 0x0004646F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_32(Class116 class116_10)
		{
			this.class116_2 = class116_10;
		}

		// Token: 0x060073AC RID: 29612 RVA: 0x00048278 File Offset: 0x00046478
		[CompilerGenerated]
		internal Class116 vmethod_33()
		{
			return this.class116_3;
		}

		// Token: 0x060073AD RID: 29613 RVA: 0x00048280 File Offset: 0x00046480
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_34(Class116 class116_10)
		{
			this.class116_3 = class116_10;
		}

		// Token: 0x060073AE RID: 29614 RVA: 0x00048289 File Offset: 0x00046489
		[CompilerGenerated]
		internal Class114 vmethod_35()
		{
			return this.class114_0;
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x003E7E40 File Offset: 0x003E6040
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_36(Class114 class114_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_8);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.CellContentClick -= value;
			}
			this.class114_0 = class114_1;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.CellContentClick += value;
			}
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x00048291 File Offset: 0x00046491
		[CompilerGenerated]
		internal Class116 vmethod_37()
		{
			return this.class116_4;
		}

		// Token: 0x060073B1 RID: 29617 RVA: 0x00048299 File Offset: 0x00046499
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_38(Class116 class116_10)
		{
			this.class116_4 = class116_10;
		}

		// Token: 0x060073B2 RID: 29618 RVA: 0x000482A2 File Offset: 0x000464A2
		[CompilerGenerated]
		internal Class116 vmethod_39()
		{
			return this.class116_5;
		}

		// Token: 0x060073B3 RID: 29619 RVA: 0x000482AA File Offset: 0x000464AA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_40(Class116 class116_10)
		{
			this.class116_5 = class116_10;
		}

		// Token: 0x060073B4 RID: 29620 RVA: 0x000482B3 File Offset: 0x000464B3
		[CompilerGenerated]
		internal ToolStripButton vmethod_41()
		{
			return this.toolStripButton_4;
		}

		// Token: 0x060073B5 RID: 29621 RVA: 0x003E7E84 File Offset: 0x003E6084
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_42(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_41);
			ToolStripButton toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_4 = toolStripButton_9;
			toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x000482BB File Offset: 0x000464BB
		[CompilerGenerated]
		internal ToolStripButton vmethod_43()
		{
			return this.toolStripButton_5;
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x003E7EC8 File Offset: 0x003E60C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_44(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_39);
			ToolStripButton toolStripButton = this.toolStripButton_5;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_5 = toolStripButton_9;
			toolStripButton = this.toolStripButton_5;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x000482C3 File Offset: 0x000464C3
		[CompilerGenerated]
		internal ToolStripButton vmethod_45()
		{
			return this.toolStripButton_6;
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x003E7F0C File Offset: 0x003E610C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_46(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_43);
			ToolStripButton toolStripButton = this.toolStripButton_6;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_6 = toolStripButton_9;
			toolStripButton = this.toolStripButton_6;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x000482CB File Offset: 0x000464CB
		[CompilerGenerated]
		internal Class116 vmethod_47()
		{
			return this.class116_6;
		}

		// Token: 0x060073BB RID: 29627 RVA: 0x000482D3 File Offset: 0x000464D3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_48(Class116 class116_10)
		{
			this.class116_6 = class116_10;
		}

		// Token: 0x060073BC RID: 29628 RVA: 0x000482DC File Offset: 0x000464DC
		[CompilerGenerated]
		internal Class116 vmethod_49()
		{
			return this.class116_7;
		}

		// Token: 0x060073BD RID: 29629 RVA: 0x000482E4 File Offset: 0x000464E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_50(Class116 class116_10)
		{
			this.class116_7 = class116_10;
		}

		// Token: 0x060073BE RID: 29630 RVA: 0x000482ED File Offset: 0x000464ED
		[CompilerGenerated]
		internal Class116 vmethod_51()
		{
			return this.class116_8;
		}

		// Token: 0x060073BF RID: 29631 RVA: 0x000482F5 File Offset: 0x000464F5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_52(Class116 class116_10)
		{
			this.class116_8 = class116_10;
		}

		// Token: 0x060073C0 RID: 29632 RVA: 0x000482FE File Offset: 0x000464FE
		[CompilerGenerated]
		internal Class2451 vmethod_53()
		{
			return this.class2451_0;
		}

		// Token: 0x060073C1 RID: 29633 RVA: 0x003E7F50 File Offset: 0x003E6150
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_54(Class2451 class2451_1)
		{
			EventHandler value = new EventHandler(this.method_45);
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

		// Token: 0x060073C2 RID: 29634 RVA: 0x00048306 File Offset: 0x00046506
		[CompilerGenerated]
		internal ToolStripSeparator vmethod_55()
		{
			return this.toolStripSeparator_1;
		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x0004830E File Offset: 0x0004650E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_56(ToolStripSeparator toolStripSeparator_4)
		{
			this.toolStripSeparator_1 = toolStripSeparator_4;
		}

		// Token: 0x060073C4 RID: 29636 RVA: 0x00048317 File Offset: 0x00046517
		[CompilerGenerated]
		internal ContextMenuStrip vmethod_57()
		{
			return this.contextMenuStrip_0;
		}

		// Token: 0x060073C5 RID: 29637 RVA: 0x003E7F94 File Offset: 0x003E6194
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_58(ContextMenuStrip contextMenuStrip_1)
		{
			CancelEventHandler value = new CancelEventHandler(this.method_65);
			ContextMenuStrip contextMenuStrip = this.contextMenuStrip_0;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.Opening -= value;
			}
			this.contextMenuStrip_0 = contextMenuStrip_1;
			contextMenuStrip = this.contextMenuStrip_0;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.Opening += value;
			}
		}

		// Token: 0x060073C6 RID: 29638 RVA: 0x0004831F File Offset: 0x0004651F
		[CompilerGenerated]
		internal Class128 vmethod_59()
		{
			return this.class128_0;
		}

		// Token: 0x060073C7 RID: 29639 RVA: 0x003E7FD8 File Offset: 0x003E61D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_60(Class128 class128_9)
		{
			EventHandler value = new EventHandler(this.method_59);
			Class128 @class = this.class128_0;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_0 = class128_9;
			@class = this.class128_0;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060073C8 RID: 29640 RVA: 0x00048327 File Offset: 0x00046527
		[CompilerGenerated]
		internal Class128 vmethod_61()
		{
			return this.class128_1;
		}

		// Token: 0x060073C9 RID: 29641 RVA: 0x003E801C File Offset: 0x003E621C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_62(Class128 class128_9)
		{
			EventHandler value = new EventHandler(this.method_60);
			ToolStripItemClickedEventHandler value2 = new ToolStripItemClickedEventHandler(this.method_66);
			Class128 @class = this.class128_1;
			if (@class != null)
			{
				@class.Click -= value;
				@class.DropDownItemClicked -= value2;
			}
			this.class128_1 = class128_9;
			@class = this.class128_1;
			if (@class != null)
			{
				@class.Click += value;
				@class.DropDownItemClicked += value2;
			}
		}

		// Token: 0x060073CA RID: 29642 RVA: 0x0004832F File Offset: 0x0004652F
		[CompilerGenerated]
		internal ToolStripDropDownButton vmethod_63()
		{
			return this.toolStripDropDownButton_0;
		}

		// Token: 0x060073CB RID: 29643 RVA: 0x003E807C File Offset: 0x003E627C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_64(ToolStripDropDownButton toolStripDropDownButton_1)
		{
			EventHandler value = new EventHandler(this.method_50);
			EventHandler value2 = new EventHandler(this.method_51);
			ToolStripItemClickedEventHandler value3 = new ToolStripItemClickedEventHandler(this.method_52);
			ToolStripDropDownButton toolStripDropDownButton = this.toolStripDropDownButton_0;
			if (toolStripDropDownButton != null)
			{
				toolStripDropDownButton.Click -= value;
				toolStripDropDownButton.DropDownOpening -= value2;
				toolStripDropDownButton.DropDownItemClicked -= value3;
			}
			this.toolStripDropDownButton_0 = toolStripDropDownButton_1;
			toolStripDropDownButton = this.toolStripDropDownButton_0;
			if (toolStripDropDownButton != null)
			{
				toolStripDropDownButton.Click += value;
				toolStripDropDownButton.DropDownOpening += value2;
				toolStripDropDownButton.DropDownItemClicked += value3;
			}
		}

		// Token: 0x060073CC RID: 29644 RVA: 0x00048337 File Offset: 0x00046537
		[CompilerGenerated]
		internal ToolStripButton vmethod_65()
		{
			return this.toolStripButton_7;
		}

		// Token: 0x060073CD RID: 29645 RVA: 0x003E80F8 File Offset: 0x003E62F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_66(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_54);
			ToolStripButton toolStripButton = this.toolStripButton_7;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_7 = toolStripButton_9;
			toolStripButton = this.toolStripButton_7;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060073CE RID: 29646 RVA: 0x0004833F File Offset: 0x0004653F
		[CompilerGenerated]
		internal Class128 vmethod_67()
		{
			return this.class128_2;
		}

		// Token: 0x060073CF RID: 29647 RVA: 0x003E813C File Offset: 0x003E633C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_68(Class128 class128_9)
		{
			EventHandler value = new EventHandler(this.method_55);
			Class128 @class = this.class128_2;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_2 = class128_9;
			@class = this.class128_2;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060073D0 RID: 29648 RVA: 0x00048347 File Offset: 0x00046547
		[CompilerGenerated]
		internal Class128 vmethod_69()
		{
			return this.class128_3;
		}

		// Token: 0x060073D1 RID: 29649 RVA: 0x003E8180 File Offset: 0x003E6380
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_70(Class128 class128_9)
		{
			EventHandler value = new EventHandler(this.method_56);
			Class128 @class = this.class128_3;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_3 = class128_9;
			@class = this.class128_3;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060073D2 RID: 29650 RVA: 0x0004834F File Offset: 0x0004654F
		[CompilerGenerated]
		internal Class128 vmethod_71()
		{
			return this.class128_4;
		}

		// Token: 0x060073D3 RID: 29651 RVA: 0x003E81C4 File Offset: 0x003E63C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_72(Class128 class128_9)
		{
			EventHandler value = new EventHandler(this.method_57);
			Class128 @class = this.class128_4;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_4 = class128_9;
			@class = this.class128_4;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060073D4 RID: 29652 RVA: 0x00048357 File Offset: 0x00046557
		[CompilerGenerated]
		internal Class128 vmethod_73()
		{
			return this.class128_5;
		}

		// Token: 0x060073D5 RID: 29653 RVA: 0x003E8208 File Offset: 0x003E6408
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_74(Class128 class128_9)
		{
			EventHandler value = new EventHandler(this.method_58);
			Class128 @class = this.class128_5;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_5 = class128_9;
			@class = this.class128_5;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060073D6 RID: 29654 RVA: 0x0004835F File Offset: 0x0004655F
		[CompilerGenerated]
		internal ToolStripSeparator vmethod_75()
		{
			return this.toolStripSeparator_2;
		}

		// Token: 0x060073D7 RID: 29655 RVA: 0x00048367 File Offset: 0x00046567
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_76(ToolStripSeparator toolStripSeparator_4)
		{
			this.toolStripSeparator_2 = toolStripSeparator_4;
		}

		// Token: 0x060073D8 RID: 29656 RVA: 0x00048370 File Offset: 0x00046570
		[CompilerGenerated]
		internal ToolStripSeparator vmethod_77()
		{
			return this.toolStripSeparator_3;
		}

		// Token: 0x060073D9 RID: 29657 RVA: 0x00048378 File Offset: 0x00046578
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_78(ToolStripSeparator toolStripSeparator_4)
		{
			this.toolStripSeparator_3 = toolStripSeparator_4;
		}

		// Token: 0x060073DA RID: 29658 RVA: 0x00048381 File Offset: 0x00046581
		[CompilerGenerated]
		internal Class128 vmethod_79()
		{
			return this.class128_6;
		}

		// Token: 0x060073DB RID: 29659 RVA: 0x003E824C File Offset: 0x003E644C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_80(Class128 class128_9)
		{
			EventHandler value = new EventHandler(this.method_61);
			Class128 @class = this.class128_6;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_6 = class128_9;
			@class = this.class128_6;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060073DC RID: 29660 RVA: 0x00048389 File Offset: 0x00046589
		[CompilerGenerated]
		internal Class128 vmethod_81()
		{
			return this.class128_7;
		}

		// Token: 0x060073DD RID: 29661 RVA: 0x003E8290 File Offset: 0x003E6490
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_82(Class128 class128_9)
		{
			EventHandler value = new EventHandler(this.method_62);
			Class128 @class = this.class128_7;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_7 = class128_9;
			@class = this.class128_7;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060073DE RID: 29662 RVA: 0x00048391 File Offset: 0x00046591
		[CompilerGenerated]
		internal Class128 vmethod_83()
		{
			return this.class128_8;
		}

		// Token: 0x060073DF RID: 29663 RVA: 0x003E82D4 File Offset: 0x003E64D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_84(Class128 class128_9)
		{
			EventHandler value = new EventHandler(this.method_63);
			Class128 @class = this.class128_8;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_8 = class128_9;
			@class = this.class128_8;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x060073E0 RID: 29664 RVA: 0x00048399 File Offset: 0x00046599
		[CompilerGenerated]
		internal ToolStripButton vmethod_85()
		{
			return this.toolStripButton_8;
		}

		// Token: 0x060073E1 RID: 29665 RVA: 0x003E8318 File Offset: 0x003E6518
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_86(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_67);
			ToolStripButton toolStripButton = this.toolStripButton_8;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_8 = toolStripButton_9;
			toolStripButton = this.toolStripButton_8;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060073E2 RID: 29666 RVA: 0x000483A1 File Offset: 0x000465A1
		[CompilerGenerated]
		internal Class125 vmethod_87()
		{
			return this.class125_0;
		}

		// Token: 0x060073E3 RID: 29667 RVA: 0x000483A9 File Offset: 0x000465A9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_88(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x060073E4 RID: 29668 RVA: 0x000483B2 File Offset: 0x000465B2
		[CompilerGenerated]
		internal Class112 vmethod_89()
		{
			return this.class112_0;
		}

		// Token: 0x060073E5 RID: 29669 RVA: 0x003E835C File Offset: 0x003E655C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_90(Class112 class112_1)
		{
			EventHandler value = new EventHandler(this.method_48);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_0 = class112_1;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x060073E6 RID: 29670 RVA: 0x000483BA File Offset: 0x000465BA
		[CompilerGenerated]
		internal Class116 vmethod_91()
		{
			return this.class116_9;
		}

		// Token: 0x060073E7 RID: 29671 RVA: 0x000483C2 File Offset: 0x000465C2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_92(Class116 class116_10)
		{
			this.class116_9 = class116_10;
		}

		// Token: 0x060073E8 RID: 29672 RVA: 0x000483CB File Offset: 0x000465CB
		[CompilerGenerated]
		internal Class44 vmethod_93()
		{
			return this.class44_2;
		}

		// Token: 0x060073E9 RID: 29673 RVA: 0x000483D3 File Offset: 0x000465D3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_94(Class44 class44_3)
		{
			this.class44_2 = class44_3;
		}

		// Token: 0x060073EA RID: 29674 RVA: 0x000483DC File Offset: 0x000465DC
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_95()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x060073EB RID: 29675 RVA: 0x000483E4 File Offset: 0x000465E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_96(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x060073EC RID: 29676 RVA: 0x000483ED File Offset: 0x000465ED
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_97()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x060073ED RID: 29677 RVA: 0x000483F5 File Offset: 0x000465F5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_98(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x060073EE RID: 29678 RVA: 0x000483FE File Offset: 0x000465FE
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_99()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060073EF RID: 29679 RVA: 0x00048406 File Offset: 0x00046606
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_100(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x060073F0 RID: 29680 RVA: 0x0004840F File Offset: 0x0004660F
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_101()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x060073F1 RID: 29681 RVA: 0x00048417 File Offset: 0x00046617
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_102(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x060073F2 RID: 29682 RVA: 0x00048420 File Offset: 0x00046620
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_103()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x060073F3 RID: 29683 RVA: 0x00048428 File Offset: 0x00046628
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_104(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x060073F4 RID: 29684 RVA: 0x00048431 File Offset: 0x00046631
		[CompilerGenerated]
		internal FlowLayoutPanel vmethod_105()
		{
			return this.flowLayoutPanel_0;
		}

		// Token: 0x060073F5 RID: 29685 RVA: 0x00048439 File Offset: 0x00046639
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_106(FlowLayoutPanel flowLayoutPanel_1)
		{
			this.flowLayoutPanel_0 = flowLayoutPanel_1;
		}

		// Token: 0x060073F6 RID: 29686 RVA: 0x00048442 File Offset: 0x00046642
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_107()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x060073F7 RID: 29687 RVA: 0x0004844A File Offset: 0x0004664A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_108(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x060073F8 RID: 29688 RVA: 0x00048453 File Offset: 0x00046653
		[CompilerGenerated]
		internal DataGridViewLinkColumn vmethod_109()
		{
			return this.dataGridViewLinkColumn_0;
		}

		// Token: 0x060073F9 RID: 29689 RVA: 0x0004845B File Offset: 0x0004665B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_110(DataGridViewLinkColumn dataGridViewLinkColumn_1)
		{
			this.dataGridViewLinkColumn_0 = dataGridViewLinkColumn_1;
		}

		// Token: 0x060073FA RID: 29690 RVA: 0x00048464 File Offset: 0x00046664
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_111()
		{
			return this.dataGridViewTextBoxColumn_6;
		}

		// Token: 0x060073FB RID: 29691 RVA: 0x0004846C File Offset: 0x0004666C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_112(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x060073FC RID: 29692 RVA: 0x00048475 File Offset: 0x00046675
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_113()
		{
			return this.dataGridViewTextBoxColumn_7;
		}

		// Token: 0x060073FD RID: 29693 RVA: 0x0004847D File Offset: 0x0004667D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_114(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
		{
			this.dataGridViewTextBoxColumn_7 = dataGridViewTextBoxColumn_8;
		}

		// Token: 0x060073FE RID: 29694 RVA: 0x00048486 File Offset: 0x00046686
		[CompilerGenerated]
		private BackgroundWorker vmethod_115()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x060073FF RID: 29695 RVA: 0x003E83A0 File Offset: 0x003E65A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_116(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler doWorkEventHandler = new DoWorkEventHandler(this.method_32);
			RunWorkerCompletedEventHandler runWorkerCompletedEventHandler = new RunWorkerCompletedEventHandler(this.method_33);
			BackgroundWorker backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted -= runWorkerCompletedEventHandler;
			}
			this.backgroundWorker_0 = backgroundWorker_1;
			backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted += runWorkerCompletedEventHandler;
			}
		}

		// Token: 0x06007400 RID: 29696 RVA: 0x0004848E File Offset: 0x0004668E
		private void AirOps_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.bool_3)
			{
				Client.smethod_0().method_3();
			}
			Class2413.smethod_2().method_41().BringToFront();
			this.vmethod_6().Stop();
		}

		// Token: 0x06007401 RID: 29697 RVA: 0x003E8400 File Offset: 0x003E6600
		private List<ActiveUnit> method_3()
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			try
			{
				foreach (string text in this.hashSet_0)
				{
					ActiveUnit item;
					if (!string.IsNullOrEmpty(text) && Client.smethod_46().vmethod_0().TryGetValue(text, ref item))
					{
						list.Add(item);
					}
				}
			}
			finally
			{
				HashSet<string>.Enumerator enumerator;
				enumerator.Dispose();
			}
			return list;
		}

		// Token: 0x06007402 RID: 29698 RVA: 0x003E8478 File Offset: 0x003E6678
		private ReadOnlyCollection<ActiveUnit> method_4()
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			try
			{
				foreach (string text in this.hashSet_1)
				{
					ActiveUnit item;
					if (!string.IsNullOrEmpty(text) && Client.smethod_46().vmethod_0().TryGetValue(text, ref item))
					{
						list.Add(item);
					}
				}
			}
			finally
			{
				HashSet<string>.Enumerator enumerator;
				enumerator.Dispose();
			}
			return list.AsReadOnly();
		}

		// Token: 0x06007403 RID: 29699 RVA: 0x003E84F4 File Offset: 0x003E66F4
		private void method_5(Group group_0, ActiveUnit activeUnit_0)
		{
			try
			{
				List<ActiveUnit>.Enumerator enumerator = this.method_3().GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == group_0)
					{
						Class127 @class = new Class127(activeUnit_0.Name);
						this.vmethod_18().method_20().method_4(@class);
						@class.Tag = activeUnit_0;
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06007404 RID: 29700 RVA: 0x003E8568 File Offset: 0x003E6768
		private void method_6(Group group_0, ActiveUnit activeUnit_0)
		{
			try
			{
				List<ActiveUnit>.Enumerator enumerator = this.method_3().GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == group_0)
					{
						try
						{
							foreach (Class127 @class in this.vmethod_18().method_20())
							{
								if (@class.Tag == activeUnit_0)
								{
									this.vmethod_18().method_20().method_6(@class);
									break;
								}
							}
						}
						finally
						{
							List<Class127>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06007405 RID: 29701 RVA: 0x003E8618 File Offset: 0x003E6818
		private Dictionary<int, int> method_7(ref ActiveUnit activeUnit_0)
		{
			List<Aircraft> list = new List<Aircraft>();
			Dictionary<int, int> result;
			if (Information.IsNothing(activeUnit_0))
			{
				result = null;
			}
			else
			{
				try
				{
					foreach (Aircraft item in activeUnit_0.vmethod_92().vmethod_4())
					{
						list.Add(item);
					}
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (list.Count == 0)
				{
					result = null;
				}
				else
				{
					List<Aircraft> selectedAircraft = list;
					SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
					bool flag = Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2);
					result = DBFunctions.smethod_40(selectedAircraft, ref sqliteConnection, ref flag);
				}
			}
			return result;
		}

		// Token: 0x06007406 RID: 29702 RVA: 0x003E86BC File Offset: 0x003E68BC
		private void method_8(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && this.vmethod_35().Columns[e.ColumnIndex].CellType == typeof(DataGridViewLinkCell))
			{
				int selectedObjectID = Conversions.ToInteger(this.vmethod_35().Rows[e.RowIndex].Cells["ComponentID"].Value);
				Client.smethod_63("Weapon", selectedObjectID, null);
			}
		}

		// Token: 0x06007407 RID: 29703 RVA: 0x003E8738 File Offset: 0x003E6938
		private void method_9(Aircraft aircraft_0)
		{
			try
			{
				List<ActiveUnit>.Enumerator enumerator = this.method_3().GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.vmethod_92().vmethod_4().Contains(aircraft_0))
					{
						this.list_0.Add(aircraft_0);
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06007408 RID: 29704 RVA: 0x000484BC File Offset: 0x000466BC
		public void imethod_0()
		{
			this.method_14();
			this.method_19();
		}

		// Token: 0x06007409 RID: 29705 RVA: 0x000484CA File Offset: 0x000466CA
		private void method_10()
		{
			this.vmethod_115().RunWorkerAsync();
		}

		// Token: 0x0600740A RID: 29706 RVA: 0x000484D7 File Offset: 0x000466D7
		private void method_11(Aircraft aircraft_0)
		{
			this.list_1.Add(aircraft_0);
		}

		// Token: 0x0600740B RID: 29707 RVA: 0x000484E5 File Offset: 0x000466E5
		private void method_12(object sender, EventArgs e)
		{
			if (Client.smethod_0().method_0() == Class279.Enum68.const_1)
			{
				this.method_13();
			}
		}

		// Token: 0x0600740C RID: 29708 RVA: 0x000484FA File Offset: 0x000466FA
		public void method_13()
		{
			this.method_14();
			this.method_19();
			this.list_0.Clear();
			this.list_1.Clear();
		}

		// Token: 0x0600740D RID: 29709 RVA: 0x003E87A4 File Offset: 0x003E69A4
		private void method_14()
		{
			try
			{
				try
				{
					foreach (Class48 @class in this.method_15())
					{
						if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(@class.Tag)) && @class.Tag.GetType() == typeof(Aircraft))
						{
							Aircraft aircraft = (Aircraft)@class.Tag;
							string text;
							if (Information.IsNothing(aircraft.method_167()))
							{
								text = "Nothing";
							}
							else
							{
								text = aircraft.method_167().Name;
							}
							string text2;
							if (Information.IsNothing(aircraft.vmethod_101()))
							{
								if (!Information.IsNothing(aircraft.vmethod_103()))
								{
									text2 = aircraft.vmethod_103().Name + " (Task Pool)";
								}
								else
								{
									text2 = "-";
								}
							}
							else
							{
								string text3 = "";
								if (aircraft.method_158().bool_2)
								{
									text3 = ", Escort";
								}
								text2 = string.Concat(new string[]
								{
									aircraft.vmethod_101().Name,
									" (",
									aircraft.vmethod_101().vmethod_5(Client.smethod_46()),
									text3,
									")"
								});
							}
							Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
							DataGridViewRow dataGridViewRow = @class;
							object[] array = new object[6];
							array[0] = aircraft.Name;
							array[1] = aircraft_AirOps.method_40();
							array[2] = text2;
							array[3] = Misc.smethod_9(text);
							int num = 4;
							long seconds = (long)Math.Round((double)aircraft_AirOps.method_38());
							Aircraft aircraft2 = aircraft;
							string text4 = null;
							array[num] = Misc.smethod_11(seconds, aircraft2.method_147(ref text4), false, false);
							array[5] = aircraft.method_148();
							dataGridViewRow.SetValues(array);
							this.method_69(@class, aircraft);
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
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200279", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				base.Close();
				return;
			}
			try
			{
				try
				{
					foreach (Aircraft aircraft_ in this.list_1)
					{
						AirOps.Class2493 class2 = new AirOps.Class2493(class2);
						class2.aircraft_0 = aircraft_;
						IEnumerable<Class48> enumerable = Enumerable.Where<Class48>(this.method_15(), new Func<Class48, bool>(class2.method_0));
						if (Enumerable.Count<Class48>(enumerable) > 0)
						{
							Enumerable.ElementAtOrDefault<Class48>(enumerable, 0).method_9().method_7().Remove(Enumerable.ElementAtOrDefault<Class48>(enumerable, 0));
						}
					}
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 200111", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			try
			{
				try
				{
					foreach (Aircraft aircraft3 in this.list_0)
					{
						bool flag;
						try
						{
							foreach (Class48 class3 in this.vmethod_21().method_2())
							{
								if (Operators.CompareString(class3.Tag.ToString(), aircraft3.DBID.ToString(), false) == 0)
								{
									string text5;
									if (Information.IsNothing(aircraft3.method_167()))
									{
										text5 = "Nothing";
									}
									else
									{
										text5 = aircraft3.method_167().Name;
									}
									string text6;
									if (Information.IsNothing(aircraft3.vmethod_101()))
									{
										if (!Information.IsNothing(aircraft3.vmethod_103()))
										{
											text6 = aircraft3.vmethod_103().Name + " (Task Pool)";
										}
										else
										{
											text6 = "-";
										}
									}
									else
									{
										string text7 = "";
										if (aircraft3.method_158().bool_2)
										{
											text7 = ", Escort";
										}
										text6 = string.Concat(new string[]
										{
											aircraft3.vmethod_101().Name,
											" (",
											aircraft3.vmethod_101().vmethod_5(Client.smethod_46()),
											text7,
											")"
										});
									}
									Aircraft_AirOps aircraft_AirOps = aircraft3.method_164();
									Class49 class4 = class3.method_7();
									object[] array2 = new object[6];
									array2[0] = aircraft3.Name;
									array2[1] = aircraft_AirOps.method_40();
									array2[2] = text6;
									array2[3] = Misc.smethod_9(text5);
									int num2 = 4;
									long seconds2 = (long)Math.Round((double)aircraft_AirOps.method_38());
									Aircraft aircraft4 = aircraft3;
									string text4 = null;
									array2[num2] = Misc.smethod_11(seconds2, aircraft4.method_147(ref text4), false, false);
									array2[5] = aircraft3.method_148();
									class4.method_1(array2).Tag = aircraft3;
									this.method_69(class3, aircraft3);
									flag = true;
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
						if (!flag)
						{
							string text8;
							if (Information.IsNothing(aircraft3.method_167()))
							{
								text8 = "Nothing";
							}
							else
							{
								text8 = aircraft3.method_167().Name;
							}
							string text9;
							if (Information.IsNothing(aircraft3.vmethod_101()))
							{
								if (!Information.IsNothing(aircraft3.vmethod_103()))
								{
									text9 = aircraft3.vmethod_103().Name + " (Task Pool)";
								}
								else
								{
									text9 = "-";
								}
							}
							else
							{
								string text10 = "";
								if (aircraft3.method_158().bool_2)
								{
									text10 = ", Escort";
								}
								text9 = string.Concat(new string[]
								{
									aircraft3.vmethod_101().Name,
									" (",
									aircraft3.vmethod_101().vmethod_5(Client.smethod_46()),
									text10,
									")"
								});
							}
							Class48 class5 = this.vmethod_21().method_2().method_0("1x " + Misc.smethod_9(aircraft3.string_2));
							class5.Tag = aircraft3.DBID;
							Aircraft_AirOps aircraft_AirOps = aircraft3.method_164();
							Class49 class6 = class5.method_7();
							object[] array3 = new object[6];
							array3[0] = aircraft3.Name;
							array3[1] = aircraft_AirOps.method_40();
							array3[2] = text9;
							array3[3] = Misc.smethod_9(text8);
							int num3 = 4;
							long seconds3 = (long)Math.Round((double)aircraft_AirOps.method_38());
							Aircraft aircraft5 = aircraft3;
							string text4 = null;
							array3[num3] = Misc.smethod_11(seconds3, aircraft5.method_147(ref text4), false, false);
							array3[5] = aircraft3.method_148();
							Class48 class7 = class6.method_1(array3);
							class7.Tag = aircraft3;
							this.method_69(class7, aircraft3);
						}
					}
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				if (this.bool_5)
				{
					this.method_37();
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 200112", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600740E RID: 29710 RVA: 0x003E8E90 File Offset: 0x003E7090
		private ReadOnlyCollection<Class48> method_15()
		{
			ReadOnlyCollection<Class48> result;
			try
			{
				List<Class48> list = new List<Class48>();
				try
				{
					foreach (Class48 @class in this.vmethod_21().method_2())
					{
						if (!list.Contains(@class))
						{
							list.Add(@class);
						}
						this.method_16(@class, list);
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
				result = list.AsReadOnly();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101133", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Class48>().AsReadOnly();
			}
			return result;
		}

		// Token: 0x0600740F RID: 29711 RVA: 0x003E8F54 File Offset: 0x003E7154
		private void method_16(Class48 class48_0, List<Class48> list_3)
		{
			try
			{
				foreach (Class48 @class in class48_0.method_7())
				{
					if (!list_3.Contains(@class))
					{
						list_3.Add(@class);
					}
					this.method_16(@class, list_3);
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

		// Token: 0x06007410 RID: 29712 RVA: 0x003E8FB4 File Offset: 0x003E71B4
		private void method_17()
		{
			try
			{
				this.vmethod_21().method_2().Clear();
				try
				{
					foreach (ActiveUnit activeUnit in this.method_3())
					{
						IEnumerable<int> enumerable = Enumerable.Distinct<int>(Enumerable.Select<Aircraft, int>(activeUnit.vmethod_92().vmethod_4(), (AirOps._Closure$__.$I279-0 == null) ? (AirOps._Closure$__.$I279-0 = new Func<Aircraft, int>(AirOps._Closure$__.$I.method_0)) : AirOps._Closure$__.$I279-0));
						try
						{
							foreach (int num in enumerable)
							{
								AirOps.Class2494 @class = new AirOps.Class2494(@class);
								@class.int_0 = num;
								IEnumerable<Aircraft> enumerable2 = Enumerable.Select<Aircraft, Aircraft>(Enumerable.Where<Aircraft>(activeUnit.vmethod_92().vmethod_4(), new Func<Aircraft, bool>(@class.method_0)), (AirOps._Closure$__.$I279-2 == null) ? (AirOps._Closure$__.$I279-2 = new Func<Aircraft, Aircraft>(AirOps._Closure$__.$I.method_1)) : AirOps._Closure$__.$I279-2);
								Class48 class2 = this.vmethod_21().method_2().method_0(string.Concat(new string[]
								{
									Conversions.ToString(Enumerable.Count<Aircraft>(enumerable2)),
									"x ",
									Misc.smethod_9(Enumerable.ElementAtOrDefault<Aircraft>(enumerable2, 0).string_2),
									" (",
									activeUnit.Name,
									")"
								}));
								class2.Tag = enumerable2;
								class2.method_7().method_0("Temp");
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
						try
						{
							foreach (int num2 in this.list_2)
							{
								try
								{
									foreach (Class48 class3 in this.vmethod_21().method_2())
									{
										try
										{
											if (Enumerable.ElementAtOrDefault<Aircraft>((IEnumerable<Aircraft>)class3.Tag, 0).DBID == num2)
											{
												class3.vmethod_4();
											}
										}
										catch (Exception ex)
										{
											ex.Data.Add("Error at 200121", ex.Message);
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
							List<int>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (this.vmethod_21().method_2().Count > 0)
				{
					this.vmethod_21().method_2()[0].vmethod_4();
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 101134", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06007411 RID: 29713 RVA: 0x003E9300 File Offset: 0x003E7500
		private void method_18()
		{
			try
			{
				this.vmethod_18().method_20().Clear();
				try
				{
					foreach (Unit unit in this.method_3())
					{
						Class127 @class;
						if (unit.bool_1)
						{
							Group.GroupType groupType = ((Group)unit).method_143();
							if (groupType == Group.GroupType.AirBase)
							{
								@class = new Class127(unit.Name);
								this.vmethod_18().method_20().method_4(@class);
								@class.Tag = unit;
								this.method_20((Group)unit, @class);
								continue;
							}
							IEnumerable<ActiveUnit> enumerable = Enumerable.OrderBy<ActiveUnit, string>(Enumerable.Select<ActiveUnit, ActiveUnit>(((Group)unit).vmethod_141().Values, (AirOps._Closure$__.$I280-0 == null) ? (AirOps._Closure$__.$I280-0 = new Func<ActiveUnit, ActiveUnit>(AirOps._Closure$__.$I.method_2)) : AirOps._Closure$__.$I280-0), (AirOps._Closure$__.$I280-1 == null) ? (AirOps._Closure$__.$I280-1 = new Func<ActiveUnit, string>(AirOps._Closure$__.$I.method_3)) : AirOps._Closure$__.$I280-1);
							try
							{
								foreach (ActiveUnit activeUnit in enumerable)
								{
									if (activeUnit.vmethod_99().Length > 0)
									{
										@class = new Class127(activeUnit.Name);
										this.vmethod_18().method_20().method_4(@class);
										@class.Tag = activeUnit;
										this.method_20(activeUnit, @class);
									}
								}
								continue;
							}
							finally
							{
								IEnumerator<ActiveUnit> enumerator2;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
								}
							}
						}
						@class = new Class127(unit.Name);
						this.vmethod_18().method_20().method_4(@class);
						@class.Tag = unit;
						this.method_20((ActiveUnit)unit, @class);
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				Class2558.smethod_6(this.vmethod_18());
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101135", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06007412 RID: 29714 RVA: 0x003E9530 File Offset: 0x003E7730
		private void method_19()
		{
			this.vmethod_18().SuspendLayout();
			try
			{
				foreach (ActiveUnit activeUnit in this.method_3())
				{
					try
					{
						foreach (Class127 @class in this.vmethod_18().method_20())
						{
							ActiveUnit activeUnit_ = (ActiveUnit)@class.Tag;
							this.method_20(activeUnit_, @class);
						}
					}
					finally
					{
						List<Class127>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.vmethod_18().ResumeLayout();
		}

		// Token: 0x06007413 RID: 29715 RVA: 0x003E95E8 File Offset: 0x003E77E8
		private void method_20(ActiveUnit activeUnit_0, Class127 class127_0)
		{
			IEnumerable<AirFacility> enumerable = Enumerable.OrderBy<AirFacility, string>(Enumerable.Select<AirFacility, AirFacility>(activeUnit_0.vmethod_99(), (AirOps._Closure$__.$I282-0 == null) ? (AirOps._Closure$__.$I282-0 = new Func<AirFacility, AirFacility>(AirOps._Closure$__.$I.method_4)) : AirOps._Closure$__.$I282-0), (AirOps._Closure$__.$I282-1 == null) ? (AirOps._Closure$__.$I282-1 = new Func<AirFacility, string>(AirOps._Closure$__.$I.method_5)) : AirOps._Closure$__.$I282-1);
			try
			{
				foreach (AirFacility airFacility in enumerable)
				{
					bool flag;
					try
					{
						foreach (Class127 @class in class127_0.method_23())
						{
							if (@class.Tag == airFacility)
							{
								flag = true;
								this.method_21(airFacility, @class);
								break;
							}
						}
					}
					finally
					{
						List<Class127>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					if (!flag)
					{
						Class127 class2 = new Class127(airFacility.Name);
						class127_0.method_23().method_4(class2);
						class2.Tag = airFacility;
						class2.method_22(true);
						try
						{
							foreach (Aircraft aircraft in airFacility.method_24().Values)
							{
								string[] array = new string[8];
								array[0] = aircraft.Name;
								array[1] = " (";
								array[2] = Misc.smethod_9(aircraft.string_2);
								array[3] = "): ";
								array[4] = aircraft.method_164().method_40();
								array[5] = " (";
								int num = 6;
								long seconds = (long)Math.Round((double)aircraft.method_164().method_38());
								Aircraft aircraft2 = aircraft;
								string text = null;
								array[num] = Misc.smethod_11(seconds, aircraft2.method_147(ref text), false, false);
								array[7] = ")";
								Class127 class3 = new Class127(string.Concat(array));
								class2.method_23().method_4(class3);
								class3.Tag = aircraft;
								class3.method_22(true);
							}
						}
						finally
						{
							IEnumerator<Aircraft> enumerator3;
							if (enumerator3 != null)
							{
								enumerator3.Dispose();
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator<AirFacility> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			List<Class127> list = new List<Class127>();
			try
			{
				foreach (Class127 class4 in class127_0.method_23())
				{
					if (!Enumerable.Contains<AirFacility>(activeUnit_0.vmethod_99(), (AirFacility)class4.Tag))
					{
						list.Add(class4);
					}
				}
			}
			finally
			{
				List<Class127>.Enumerator enumerator4;
				((IDisposable)enumerator4).Dispose();
			}
			try
			{
				foreach (Class127 gparam_ in list)
				{
					class127_0.method_23().method_6(gparam_);
				}
			}
			finally
			{
				List<Class127>.Enumerator enumerator5;
				((IDisposable)enumerator5).Dispose();
			}
		}

		// Token: 0x06007414 RID: 29716 RVA: 0x003E98E4 File Offset: 0x003E7AE4
		private void method_21(AirFacility airFacility_0, Class127 class127_0)
		{
			try
			{
				foreach (Aircraft aircraft in airFacility_0.method_24().Values)
				{
					bool flag;
					try
					{
						foreach (Class127 @class in class127_0.method_23())
						{
							if (@class.Tag == aircraft)
							{
								flag = true;
								@class.method_7(string.Concat(new string[]
								{
									aircraft.Name,
									" (",
									Misc.smethod_9(aircraft.string_2),
									"): ",
									aircraft.method_164().method_40(),
									" (",
									Misc.smethod_11((long)Math.Round((double)aircraft.method_164().method_38()), Aircraft_AirOps.Enum44.const_0, false, false),
									")"
								}));
								break;
							}
						}
						goto IL_176;
					}
					finally
					{
						List<Class127>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					IL_DE:
					string[] array = new string[8];
					array[0] = aircraft.Name;
					array[1] = " (";
					array[2] = Misc.smethod_9(aircraft.string_2);
					array[3] = "): ";
					array[4] = aircraft.method_164().method_40();
					array[5] = " (";
					int num = 6;
					long seconds = (long)Math.Round((double)aircraft.method_164().method_38());
					Aircraft aircraft2 = aircraft;
					string text = null;
					array[num] = Misc.smethod_11(seconds, aircraft2.method_147(ref text), false, false);
					array[7] = ")";
					Class127 class2 = new Class127(string.Concat(array));
					class127_0.method_23().method_4(class2);
					class2.Tag = aircraft;
					continue;
					IL_176:
					if (!flag)
					{
						goto IL_DE;
					}
				}
			}
			finally
			{
				IEnumerator<Aircraft> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			List<Class127> list = new List<Class127>();
			try
			{
				foreach (Class127 class3 in class127_0.method_23())
				{
					if (!airFacility_0.method_24().Values.Contains((Aircraft)class3.Tag))
					{
						list.Add(class3);
					}
				}
			}
			finally
			{
				List<Class127>.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
			try
			{
				foreach (Class127 gparam_ in list)
				{
					class127_0.method_23().method_6(gparam_);
				}
			}
			finally
			{
				List<Class127>.Enumerator enumerator4;
				((IDisposable)enumerator4).Dispose();
			}
		}

		// Token: 0x06007415 RID: 29717 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_22(object sender, EventArgs e)
		{
		}

		// Token: 0x06007416 RID: 29718 RVA: 0x0004851E File Offset: 0x0004671E
		private void method_23(object sender, EventArgs e)
		{
			this.method_24();
		}

		// Token: 0x06007417 RID: 29719 RVA: 0x003E9B7C File Offset: 0x003E7D7C
		private void method_24()
		{
			this.method_25(true, true, true, true, true);
			int count = this.method_4().Count;
			if (count != 0)
			{
				if (count == 1)
				{
					Aircraft aircraft = (Aircraft)this.method_4()[0];
					aircraft.method_164().method_37(Aircraft_AirOps._AirOpsCondition.PreparingToLaunch);
					aircraft.method_164().method_70();
				}
				else
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.method_4())
						{
							Aircraft aircraft2 = (Aircraft)activeUnit;
							aircraft2.method_164().method_37(Aircraft_AirOps._AirOpsCondition.PreparingToLaunch);
							aircraft2.method_164().method_70();
						}
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
			this.method_14();
		}

		// Token: 0x06007418 RID: 29720 RVA: 0x003E9C2C File Offset: 0x003E7E2C
		private void method_25(bool bool_6, bool bool_7, bool bool_8, bool bool_9, bool bool_10)
		{
			this.hashSet_1.Clear();
			try
			{
				foreach (Class48 @class in this.vmethod_21().method_2())
				{
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected)
							{
								this.hashSet_1.Add(((Aircraft)class2.Tag).string_0);
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
			if (bool_6)
			{
				List<Aircraft> list = new List<Aircraft>();
				try
				{
					foreach (ActiveUnit activeUnit in this.method_4())
					{
						Aircraft aircraft = (Aircraft)activeUnit;
						Aircraft aircraft2 = aircraft;
						string text = null;
						if (aircraft2.method_147(ref text) == Aircraft_AirOps.Enum44.const_2)
						{
							list.Add(aircraft);
						}
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator3;
					if (enumerator3 != null)
					{
						enumerator3.Dispose();
					}
				}
				if (list.Count > 0)
				{
					DarkMessageBox.smethod_1(Conversions.ToString(list.Count) + " of the selected aircraft are unavailable for operations, and will not launch.", "Unavailable aircraft selected!", Enum11.const_0);
					try
					{
						foreach (Aircraft aircraft3 in list)
						{
							this.hashSet_1.Remove(aircraft3.string_0);
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
			}
			if (bool_7)
			{
				List<Aircraft> list2 = new List<Aircraft>();
				try
				{
					foreach (ActiveUnit activeUnit2 in this.method_4())
					{
						Aircraft aircraft4 = (Aircraft)activeUnit2;
						if (aircraft4.vmethod_7(false) != Client.smethod_50())
						{
							list2.Add(aircraft4);
						}
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator5;
					if (enumerator5 != null)
					{
						enumerator5.Dispose();
					}
				}
				if (list2.Count > 0)
				{
					DarkMessageBox.smethod_1(Conversions.ToString(list2.Count) + " of the selected aircraft are allied units not under your direct control.", "Allied aircraft selected!", Enum11.const_0);
					try
					{
						foreach (Aircraft aircraft5 in list2)
						{
							this.hashSet_1.Remove(aircraft5.string_0);
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
				}
			}
			if (bool_8)
			{
				List<Aircraft> list3 = new List<Aircraft>();
				try
				{
					foreach (ActiveUnit activeUnit3 in this.method_4())
					{
						Aircraft aircraft6 = (Aircraft)activeUnit3;
						if (aircraft6.vmethod_127())
						{
							list3.Add(aircraft6);
						}
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator7;
					if (enumerator7 != null)
					{
						enumerator7.Dispose();
					}
				}
				if (list3.Count > 0)
				{
					DarkMessageBox.smethod_1(Conversions.ToString(list3.Count) + " of the selected aircraft are already airborne.", "Airborne aircraft selected!", Enum11.const_0);
					try
					{
						foreach (Aircraft aircraft7 in list3)
						{
							this.hashSet_1.Remove(aircraft7.string_0);
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator8;
						((IDisposable)enumerator8).Dispose();
					}
				}
			}
			if (bool_9)
			{
				List<Aircraft> list4 = new List<Aircraft>();
				try
				{
					foreach (ActiveUnit activeUnit4 in this.method_4())
					{
						Aircraft aircraft8 = (Aircraft)activeUnit4;
						if (Information.IsNothing(aircraft8.method_167()))
						{
							list4.Add(aircraft8);
						}
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator9;
					if (enumerator9 != null)
					{
						enumerator9.Dispose();
					}
				}
				if (list4.Count > 0)
				{
					DarkMessageBox.smethod_1(Conversions.ToString(list4.Count) + " of the selected aircraft do not have a loadout, and will not launch.", "Aircraft with no loadout selected!", Enum11.const_0);
					try
					{
						foreach (Aircraft aircraft9 in list4)
						{
							this.hashSet_1.Remove(aircraft9.string_0);
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator10;
						((IDisposable)enumerator10).Dispose();
					}
				}
			}
			if (bool_10)
			{
				List<Aircraft> list5 = new List<Aircraft>();
				try
				{
					foreach (ActiveUnit activeUnit5 in this.method_4())
					{
						Aircraft aircraft10 = (Aircraft)activeUnit5;
						if (!Information.IsNothing(aircraft10.method_167()))
						{
							Aircraft aircraft11 = aircraft10;
							string text = null;
							if (aircraft11.method_147(ref text) == Aircraft_AirOps.Enum44.const_3)
							{
								list5.Add(aircraft10);
							}
						}
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator11;
					if (enumerator11 != null)
					{
						enumerator11.Dispose();
					}
				}
				if (list5.Count > 0)
				{
					DarkMessageBox.smethod_1(Conversions.ToString(list5.Count) + " of the selected aircraft have a reserve loadout, and will not launch.", "Aircraft with reserve loadout selected!", Enum11.const_0);
					try
					{
						foreach (Aircraft aircraft12 in list5)
						{
							this.hashSet_1.Remove(aircraft12.string_0);
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator12;
						((IDisposable)enumerator12).Dispose();
					}
				}
			}
		}

		// Token: 0x06007419 RID: 29721 RVA: 0x00048526 File Offset: 0x00046726
		private void method_26(object sender, EventArgs e)
		{
			this.method_27();
		}

		// Token: 0x0600741A RID: 29722 RVA: 0x003EA138 File Offset: 0x003E8338
		private void method_27()
		{
			this.hashSet_1.Clear();
			try
			{
				foreach (Class48 @class in this.vmethod_21().method_2())
				{
					if (@class.Selected)
					{
						try
						{
							foreach (Aircraft aircraft in ((IEnumerable<Aircraft>)@class.Tag))
							{
								if (aircraft.method_164().method_68())
								{
									this.hashSet_1.Add(aircraft.string_0);
								}
							}
						}
						finally
						{
							IEnumerator<Aircraft> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
					}
					if (this.method_4().Count > 0)
					{
						break;
					}
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected && ((Aircraft)class2.Tag).method_164().method_68())
							{
								this.hashSet_1.Add(((Aircraft)class2.Tag).string_0);
							}
						}
					}
					finally
					{
						IEnumerator<Class48> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
					if (this.method_4().Count > 0)
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
			if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				List<Aircraft> list = new List<Aircraft>();
				try
				{
					foreach (ActiveUnit activeUnit in this.method_4())
					{
						Aircraft aircraft2 = (Aircraft)activeUnit;
						Aircraft aircraft3 = aircraft2;
						string text = null;
						if (aircraft3.method_147(ref text) == Aircraft_AirOps.Enum44.const_2)
						{
							list.Add(aircraft2);
						}
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator4;
					if (enumerator4 != null)
					{
						enumerator4.Dispose();
					}
				}
				if (list.Count > 0)
				{
					DarkMessageBox.smethod_1(Conversions.ToString(list.Count) + " of the selected aircraft are unavailable for operations, and will not be readied.", "Unavailable aircraft selected!", Enum11.const_0);
					try
					{
						foreach (Aircraft aircraft4 in list)
						{
							this.hashSet_1.Remove(aircraft4.string_0);
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
			}
			List<Aircraft> list2 = new List<Aircraft>();
			try
			{
				foreach (ActiveUnit activeUnit2 in this.method_4())
				{
					Aircraft aircraft5 = (Aircraft)activeUnit2;
					if (aircraft5.vmethod_7(false) != Client.smethod_50())
					{
						list2.Add(aircraft5);
					}
				}
			}
			finally
			{
				IEnumerator<ActiveUnit> enumerator6;
				if (enumerator6 != null)
				{
					enumerator6.Dispose();
				}
			}
			if (list2.Count > 0)
			{
				DarkMessageBox.smethod_1(Conversions.ToString(list2.Count) + " of the selected aircraft are allied units not under your direct control.", "Allied aircraft selected!", Enum11.const_0);
				try
				{
					foreach (Aircraft aircraft6 in list2)
					{
						this.hashSet_1.Remove(aircraft6.string_0);
					}
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator7;
					((IDisposable)enumerator7).Dispose();
				}
			}
			List<Aircraft> list3 = new List<Aircraft>();
			try
			{
				foreach (ActiveUnit activeUnit3 in this.method_4())
				{
					Aircraft aircraft7 = (Aircraft)activeUnit3;
					if (aircraft7.vmethod_127())
					{
						list3.Add(aircraft7);
					}
				}
			}
			finally
			{
				IEnumerator<ActiveUnit> enumerator8;
				if (enumerator8 != null)
				{
					enumerator8.Dispose();
				}
			}
			if (list3.Count > 0)
			{
				DarkMessageBox.smethod_1(Conversions.ToString(list3.Count) + " of the selected aircraft are already airborne.", "Airborne aircraft selected!", Enum11.const_0);
				try
				{
					foreach (Aircraft aircraft8 in list3)
					{
						this.hashSet_1.Remove(aircraft8.string_0);
					}
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator9;
					((IDisposable)enumerator9).Dispose();
				}
			}
			int num = 0;
			List<Aircraft> list4 = new List<Aircraft>();
			try
			{
				foreach (ActiveUnit activeUnit4 in this.method_4())
				{
					Aircraft aircraft9 = (Aircraft)activeUnit4;
					if (num == 0)
					{
						num = aircraft9.DBID;
					}
					else if (aircraft9.DBID != num)
					{
						list4.Add(aircraft9);
					}
				}
			}
			finally
			{
				IEnumerator<ActiveUnit> enumerator10;
				if (enumerator10 != null)
				{
					enumerator10.Dispose();
				}
			}
			if (list4.Count > 0)
			{
				DarkMessageBox.smethod_1(Conversions.ToString(list4.Count) + " of the selected aircraft are of a different type, and will not be readied.", "Different aircraft types selected!", Enum11.const_0);
				try
				{
					foreach (Aircraft aircraft10 in list4)
					{
						this.hashSet_1.Remove(aircraft10.string_0);
					}
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator11;
					((IDisposable)enumerator11).Dispose();
				}
			}
			if (this.method_4().Count > 0)
			{
				if (!Information.IsNothing(Class2413.smethod_2().method_51().list_0))
				{
					Class2413.smethod_2().method_51().list_0.Clear();
				}
				else
				{
					Class2413.smethod_2().method_51().list_0 = new List<Aircraft>();
				}
				try
				{
					foreach (ActiveUnit activeUnit5 in this.method_4())
					{
						Class2413.smethod_2().method_51().list_0.Add((Aircraft)activeUnit5);
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator12;
					if (enumerator12 != null)
					{
						enumerator12.Dispose();
					}
				}
				if (!Information.IsNothing(((Aircraft)this.method_4()[0]).method_167()))
				{
					Class2413.smethod_2().method_51().int_0 = ((Aircraft)this.method_4()[0]).method_167().DBID;
				}
				else
				{
					Class2413.smethod_2().method_51().int_0 = 0;
				}
				Class2413.smethod_2().method_51().Show();
			}
		}

		// Token: 0x0600741B RID: 29723 RVA: 0x003EA7A4 File Offset: 0x003E89A4
		private void method_28(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				Class48 @class = null;
				try
				{
					foreach (Class48 class2 in this.vmethod_21().method_2())
					{
						if (class2.Selected)
						{
							@class = class2;
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
				if (!Information.IsNothing(@class))
				{
					if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(@class.Tag)))
					{
						int dbid = Enumerable.ElementAtOrDefault<Aircraft>((IEnumerable<Aircraft>)@class.Tag, 0).DBID;
						Client.smethod_63("Aircraft", dbid, null);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200122", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600741C RID: 29724 RVA: 0x0004852E File Offset: 0x0004672E
		private void method_29(object sender, EventArgs0 e)
		{
			if (e.method_0().method_8() == 1)
			{
				this.list_2.Remove(Enumerable.ElementAtOrDefault<Aircraft>((IEnumerable<Aircraft>)e.method_0().Tag, 0).DBID);
			}
		}

		// Token: 0x0600741D RID: 29725 RVA: 0x00048565 File Offset: 0x00046765
		private void method_30(object sender, EventArgs e)
		{
			this.method_31();
		}

		// Token: 0x0600741E RID: 29726 RVA: 0x003EA884 File Offset: 0x003E8A84
		private void method_31()
		{
			this.method_25(true, true, true, true, true);
			Misc.smethod_58(Enumerable.ToList<ActiveUnit>(this.method_4()), Client.smethod_46(), Client.smethod_50(), null);
			int count = this.method_4().Count;
			if (count != 0)
			{
				if (count == 1)
				{
					Aircraft aircraft = (Aircraft)this.method_4()[0];
					aircraft.method_164().method_37(Aircraft_AirOps._AirOpsCondition.PreparingToLaunch);
					aircraft.method_164().method_70();
				}
				else
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.method_4())
						{
							Aircraft aircraft2 = (Aircraft)activeUnit;
							aircraft2.method_164().method_37(Aircraft_AirOps._AirOpsCondition.PreparingToLaunch);
							aircraft2.method_164().method_70();
						}
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
			this.method_14();
		}

		// Token: 0x0600741F RID: 29727 RVA: 0x0004856D File Offset: 0x0004676D
		private void method_32(object sender, DoWorkEventArgs e)
		{
			Thread.Sleep(100);
		}

		// Token: 0x06007420 RID: 29728 RVA: 0x00048576 File Offset: 0x00046776
		private void method_33(object sender, RunWorkerCompletedEventArgs e)
		{
			this.method_17();
		}

		// Token: 0x06007421 RID: 29729 RVA: 0x003EA950 File Offset: 0x003E8B50
		private void AirOps_Shown(object sender, EventArgs e)
		{
			this.bool_3 = (Client.smethod_0().method_0() == Class279.Enum68.const_1);
			if (this.bool_3)
			{
				Client.smethod_0().method_4();
			}
			if (this.method_3().Count > 1)
			{
				this.Text = "Air Ops - Multiple host units";
			}
			else
			{
				this.Text = "Air Ops - " + this.method_3()[0].Name;
			}
			this.method_10();
			this.method_18();
			this.vmethod_41().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			this.vmethod_43().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			this.vmethod_45().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			this.vmethod_85().Visible = true;
			this.vmethod_23().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			this.vmethod_6().Start();
			Aircraft_AirOps.smethod_1(new Aircraft_AirOps.Delegate23(this.method_11));
			Aircraft_AirOps.smethod_3(new Aircraft_AirOps.Delegate24(this.method_9));
			Group.smethod_10(new Group.Delegate32(this.method_5));
			Group.smethod_12(new Group.Delegate33(this.method_6));
		}

		// Token: 0x06007422 RID: 29730 RVA: 0x0004857E File Offset: 0x0004677E
		private void method_34(object sender, EventArgs e)
		{
			this.method_35();
		}

		// Token: 0x06007423 RID: 29731 RVA: 0x003EAA88 File Offset: 0x003E8C88
		private void method_35()
		{
			this.method_25(false, true, true, false, false);
			try
			{
				foreach (ActiveUnit activeUnit in this.method_4())
				{
					if (((Aircraft_AirOps)activeUnit.vmethod_92()).method_22())
					{
						((Aircraft_AirOps)activeUnit.vmethod_92()).method_48(true, false, true);
						if (activeUnit.vmethod_85().method_48())
						{
							activeUnit.vmethod_85().method_7().method_11(Client.smethod_46(), Mission.Enum102.const_0);
						}
					}
					if (activeUnit.method_120())
					{
						activeUnit.vmethod_66(false, null);
					}
				}
			}
			finally
			{
				IEnumerator<ActiveUnit> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.method_14();
		}

		// Token: 0x06007424 RID: 29732 RVA: 0x003EAB38 File Offset: 0x003E8D38
		private void method_36(object sender, EventArgs e)
		{
			this.hashSet_1.Clear();
			bool flag;
			try
			{
				foreach (Class48 @class in this.vmethod_21().method_2())
				{
					if (@class.Selected)
					{
						flag = true;
					}
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected)
							{
								this.hashSet_1.Add(((Aircraft)class2.Tag).string_0);
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
			if (this.method_4().Count > 0)
			{
				string text = ((Aircraft_AirOps)this.method_4()[0].vmethod_92()).method_30().string_0;
				if (Operators.CompareString(this.string_0, text, false) != 0)
				{
					ActiveUnit activeUnit = Client.smethod_46().vmethod_0()[text];
					this.dictionary_0 = this.method_7(ref activeUnit);
					this.string_0 = activeUnit.string_0;
				}
			}
			if (!flag)
			{
				int count = this.method_4().Count;
				if (count == 1)
				{
					Aircraft aircraft = (Aircraft)this.method_4()[0];
					if (!Information.IsNothing(aircraft.method_167()))
					{
						if (this.method_4()[0].vmethod_127())
						{
							if (!Information.IsNothing(this.dataTable_0))
							{
								this.dataTable_0.Rows.Clear();
							}
						}
						else
						{
							int dbid = this.method_4()[0].DBID;
							Dictionary<int, int> selectedAircraftTotalWeaponQty = this.dictionary_0;
							SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
							Scenario theScen = Client.smethod_46();
							bool flag2 = Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2);
							Scenario scenario = Client.smethod_46();
							Aircraft aircraft2 = (Aircraft)this.method_4()[0];
							this.dataTable_0 = DBFunctions.smethod_42(dbid, selectedAircraftTotalWeaponQty, ref sqliteConnection, theScen, ref flag2, ref scenario, ref aircraft2, ref ((Aircraft)this.method_4()[0]).method_167().DBID, ref aircraft.method_167().bool_11);
						}
					}
					else if (!Information.IsNothing(this.dataTable_0))
					{
						this.dataTable_0.Rows.Clear();
					}
				}
				else if (!Information.IsNothing(this.dataTable_0))
				{
					this.dataTable_0.Rows.Clear();
				}
			}
			else if (!Information.IsNothing(this.dataTable_0))
			{
				this.dataTable_0.Rows.Clear();
			}
			if (!Information.IsNothing(this.dataTable_0))
			{
				if (this.method_4().Count > 0)
				{
					this.method_38((Aircraft)this.method_4()[0]);
				}
				else
				{
					this.method_38(null);
				}
			}
			if (this.method_4().Count > 0)
			{
				this.vmethod_12().Enabled = true;
				this.vmethod_14().Enabled = true;
				this.vmethod_16().Enabled = true;
				this.vmethod_25().Enabled = true;
				this.vmethod_65().Enabled = true;
				this.vmethod_63().Enabled = true;
				if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
				{
					this.vmethod_41().Enabled = true;
					this.vmethod_43().Enabled = true;
					this.vmethod_45().Enabled = true;
				}
				this.vmethod_85().Enabled = false;
				try
				{
					IEnumerator<ActiveUnit> enumerator3 = this.method_4().GetEnumerator();
					while (enumerator3.MoveNext())
					{
						if (((Interface3)enumerator3.Current).imethod_2() != CargoType.NoCargo)
						{
							this.vmethod_85().Enabled = true;
						}
					}
					goto IL_402;
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator3;
					if (enumerator3 != null)
					{
						enumerator3.Dispose();
					}
				}
			}
			this.vmethod_85().Enabled = false;
			this.vmethod_12().Enabled = false;
			this.vmethod_14().Enabled = false;
			this.vmethod_16().Enabled = false;
			this.vmethod_25().Enabled = false;
			this.vmethod_65().Enabled = false;
			this.vmethod_63().Enabled = false;
			if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
			{
				this.vmethod_41().Enabled = false;
				this.vmethod_43().Enabled = false;
				this.vmethod_45().Enabled = false;
			}
			IL_402:
			this.method_37();
		}

		// Token: 0x06007425 RID: 29733 RVA: 0x003EAF78 File Offset: 0x003E9178
		private void method_37()
		{
			bool flag = true;
			int num = 0;
			bool? flag2;
			int? num4;
			if (this.method_4().Count > 0)
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.method_4())
					{
						Aircraft aircraft = (Aircraft)activeUnit;
						num++;
						if (aircraft.vmethod_7(false) != Client.smethod_50())
						{
							flag = false;
							break;
						}
						int? num2;
						if (num == 1 && !Information.IsNothing(aircraft.method_167()))
						{
							num2 = new int?(aircraft.method_167().DBID);
						}
						Doctrine.Enum53? @enum = aircraft.doctrine_0.method_196(aircraft.scenario_0, false, false, false, false);
						byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							flag = false;
							break;
						}
						@enum = aircraft.doctrine_0.method_196(aircraft.scenario_0, false, false, false, false);
						b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							if (Information.IsNothing(aircraft.method_167()))
							{
								flag = false;
								break;
							}
							Loadout loadout = aircraft.method_167();
							if (!loadout.method_10() && !loadout.method_12() && !loadout.method_11())
							{
								flag = false;
								break;
							}
						}
						else if (!Information.IsNothing(num2))
						{
							if (Information.IsNothing(aircraft.method_167()))
							{
								flag = false;
								break;
							}
							int? num3 = num2;
							int dbid = aircraft.method_167().DBID;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() != dbid) : null).GetValueOrDefault())
							{
								flag = false;
								break;
							}
						}
						else if (Information.IsNothing(num2))
						{
							flag = false;
							break;
						}
						if (!Information.IsNothing(aircraft.method_167()))
						{
							if (!aircraft.method_167().bool_13)
							{
								flag = false;
								break;
							}
							Doctrine.Enum54? enum2 = aircraft.doctrine_0.method_201(aircraft.scenario_0, false, false, false, false);
							b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								this.int_0 = aircraft.method_167().int_3;
							}
							else
							{
								this.int_0 = aircraft.method_167().int_2;
							}
							this.bool_4 = aircraft.method_167().bool_13;
							this.int_2 = aircraft.method_167().int_9;
							this.int_1 = aircraft.method_167().int_12;
							this.int_3 = aircraft.method_167().int_10;
							this.int_4 = aircraft.method_167().int_11;
							if (!this.bool_4)
							{
								flag = false;
								break;
							}
						}
						Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
						if (!Information.IsNothing(flag2))
						{
							bool bool_ = aircraft_AirOps.bool_0;
							if (((flag2 != null) ? new bool?(bool_ != flag2.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								flag2 = null;
							}
							int dbid = aircraft_AirOps.int_2;
							if (((num4 != null) ? new bool?(dbid != num4.GetValueOrDefault()) : null).GetValueOrDefault() && !Information.IsNothing(num4))
							{
								num4 = null;
							}
						}
						else if (num == 1)
						{
							flag2 = new bool?(aircraft_AirOps.bool_0);
							num4 = new int?(aircraft_AirOps.int_2);
						}
					}
					goto IL_42C;
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			flag = false;
			IL_42C:
			this.bool_5 = false;
			if (flag)
			{
				this.vmethod_89().Enabled = true;
				if (Information.IsNothing(flag2))
				{
					this.vmethod_89().CheckState = CheckState.Indeterminate;
					this.method_49(num4);
					this.vmethod_53().Enabled = false;
					this.vmethod_51().Enabled = true;
					this.vmethod_51().Text = "Selection includes aircraft with and without the Quick Turnaround option set.";
				}
				else if (flag2.GetValueOrDefault())
				{
					if (this.vmethod_89().CheckState == CheckState.Indeterminate)
					{
						this.vmethod_89().CheckState = CheckState.Checked;
					}
					else
					{
						this.vmethod_89().Checked = true;
					}
					this.method_49(num4);
					this.vmethod_53().Enabled = true;
					this.vmethod_51().Enabled = true;
					if (!Information.IsNothing(num4))
					{
						this.vmethod_51().Text = this.method_46();
					}
					else
					{
						this.vmethod_51().Text = "";
					}
				}
				else
				{
					if (this.vmethod_89().CheckState == CheckState.Indeterminate)
					{
						this.vmethod_89().CheckState = CheckState.Unchecked;
					}
					else
					{
						this.vmethod_89().Checked = false;
					}
					this.method_49(new int?(this.int_3));
					this.vmethod_53().Enabled = false;
					this.vmethod_51().Enabled = false;
					this.vmethod_51().Text = "";
				}
			}
			else
			{
				this.vmethod_89().Enabled = false;
				if (this.vmethod_89().CheckState == CheckState.Indeterminate)
				{
					this.vmethod_89().CheckState = CheckState.Unchecked;
				}
				else
				{
					this.vmethod_89().Checked = false;
				}
				this.method_49(new int?(this.int_3));
			}
			this.bool_5 = true;
		}

		// Token: 0x06007426 RID: 29734 RVA: 0x003EB56C File Offset: 0x003E976C
		private void method_38(Aircraft aircraft_0)
		{
			new Class403(Client.smethod_46().method_39());
			try
			{
				if (this.dataTable_0.Rows.Count > 0 && Conversions.ToInteger(Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_0.AsEnumerable(), 0)["ID"]) > 4)
				{
					this.vmethod_37().Text = "Range and Profile: " + Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_0.AsEnumerable(), 0)["RangeProfileDescription"].ToString();
					this.vmethod_31().Text = Conversions.ToString(Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_0.AsEnumerable(), 0)["LoadoutRoleDescription"]);
					this.vmethod_29().Text = string.Concat(new string[]
					{
						"Capabilities: ",
						Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_0.AsEnumerable(), 0)["TimeofDay"].ToString(),
						", ",
						Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_0.AsEnumerable(), 0)["Weather"].ToString(),
						" capable"
					});
					Doctrine._WeaponState value = aircraft_0.doctrine_0.method_211(Client.smethod_46(), false, false, false, false).Value;
					if (value == Doctrine._WeaponState.LoadoutSetting)
					{
						this.vmethod_91().Text = "Pre-briefed weapon state " + Conversions.ToString(Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_0.AsEnumerable(), 0)["WinchesterShotgunDescription"]);
					}
					else
					{
						string text = Aircraft.smethod_13(Conversions.ToInteger(Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_0.AsEnumerable(), 0)["ID"]), (int)value, (Loadout.LoadoutRole)Conversions.ToInteger(Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_0.AsEnumerable(), 0)["LoadoutRole"]), Client.smethod_46());
						string text2 = Conversions.ToString(Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_0.AsEnumerable(), 0)["WinchesterShotgunDescription"]);
						if (string.CompareOrdinal(text2, text) != 0)
						{
							this.vmethod_91().Text = string.Concat(new string[]
							{
								"Effective pre-briefed weapon state ",
								text,
								Environment.NewLine,
								"Loadout's default weapon state ",
								text2
							});
						}
						else
						{
							this.vmethod_91().Text = "Pre-briefed weapon state" + text2;
						}
					}
					this.vmethod_27().Text = "Attack Altitude: " + Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_0.AsEnumerable(), 0)["AttackAltitude"].ToString();
					this.vmethod_39().Text = "Loadouts available in magazines: " + Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_0.AsEnumerable(), 0)["NumberOfLoadouts"].ToString();
					this.vmethod_47().Text = "Loadouts available, incl. weapons mounted on all aircraft: " + Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_0.AsEnumerable(), 0)["NumberOfLoadoutsIncludingMountedWeapons"].ToString();
					this.vmethod_49().Text = "Loadouts available, same as above excl. optional weapons: " + Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_0.AsEnumerable(), 0)["NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly"].ToString();
					this.vmethod_33().Text = "Loadout Details: " + Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_0.AsEnumerable(), 0)["Name"].ToString();
					int num = Conversions.ToInteger(Enumerable.ElementAtOrDefault<DataRow>(this.dataTable_0.AsEnumerable(), 0)["ID"]);
					SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
					this.dataTable_1 = DBFunctions.smethod_44(num, ref sqliteConnection, ref aircraft_0.method_167().bool_11);
					this.dataTable_1.Columns.Add("Available");
					this.dataTable_1.Columns.Add("AvailableTotal");
					try
					{
						foreach (object obj in this.dataTable_1.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							int key = Conversions.ToInteger(dataRow["ComponentID"]);
							int int_ = Conversions.ToInteger(dataRow["ComponentID"]);
							Scenario scenario = Client.smethod_46();
							if (Weapon.smethod_17(int_, ref scenario))
							{
								dataRow["Available"] = "-";
								dataRow["AvailableTotal"] = "-";
							}
							else if (!Client.smethod_46().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2))
							{
								int num2 = ((Aircraft)this.vmethod_21().SelectedRows[0].Tag).method_164().method_30().vmethod_89().vmethod_8(key);
								int num3 = 0;
								if (!Information.IsNothing(this.dictionary_0) && this.dictionary_0.ContainsKey(key))
								{
									num3 = this.dictionary_0[key];
								}
								dataRow["Available"] = num2;
								dataRow["AvailableTotal"] = num2 + num3;
							}
							else
							{
								dataRow["Available"] = "Unlimited";
								dataRow["AvailableTotal"] = "Unlimited";
							}
							dataRow["Item"] = Misc.smethod_9(Conversions.ToString(dataRow["Item"]));
						}
						goto IL_5E3;
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
				this.vmethod_37().Text = "";
				this.vmethod_31().Text = "";
				this.vmethod_29().Text = "";
				this.vmethod_91().Text = "";
				this.vmethod_27().Text = "";
				this.vmethod_39().Text = "";
				this.vmethod_47().Text = "";
				this.vmethod_49().Text = "";
				this.vmethod_33().Text = "Loadout Details: None Selected";
				this.dataTable_1.Rows.Clear();
				IL_5E3:
				this.vmethod_35().AutoGenerateColumns = false;
				this.vmethod_35().DataSource = this.dataTable_1;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101136", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06007427 RID: 29735 RVA: 0x003EBBE8 File Offset: 0x003E9DE8
		private void AirOps_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F6 && base.Visible)
			{
				base.Close();
				return;
			}
			if (!base.Visible || (e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Add && e.KeyCode != Keys.Subtract && e.KeyCode != Keys.End && e.KeyCode != Keys.Home))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x00048586 File Offset: 0x00046786
		private void method_39(object sender, EventArgs e)
		{
			this.method_40();
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x003EBCAC File Offset: 0x003E9EAC
		private void method_40()
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			try
			{
				foreach (Class48 @class in this.vmethod_21().method_2())
				{
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected)
							{
								list.Add((Aircraft)class2.Tag);
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
			if (list.Count == 1)
			{
				Class2413.smethod_2().method_54().string_0 = list[0].Name;
				if (Class2413.smethod_2().method_54().ShowDialog() == DialogResult.OK)
				{
					list[0].Name = Class2413.smethod_2().method_54().string_0;
				}
				this.method_14();
				this.method_19();
			}
		}

		// Token: 0x0600742A RID: 29738 RVA: 0x0004858E File Offset: 0x0004678E
		private void method_41(object sender, EventArgs e)
		{
			this.method_42();
		}

		// Token: 0x0600742B RID: 29739 RVA: 0x003EBDAC File Offset: 0x003E9FAC
		private void method_42()
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			try
			{
				foreach (Class48 @class in this.vmethod_21().method_2())
				{
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected)
							{
								list.Add((Aircraft)class2.Tag);
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
			Class2413.smethod_2().method_72().list_0 = list;
			Class2413.smethod_2().method_72().Show();
		}

		// Token: 0x0600742C RID: 29740 RVA: 0x00048596 File Offset: 0x00046796
		private void method_43(object sender, EventArgs e)
		{
			this.method_44();
		}

		// Token: 0x0600742D RID: 29741 RVA: 0x003EBE70 File Offset: 0x003EA070
		private void method_44()
		{
			List<Class48> list = new List<Class48>();
			try
			{
				foreach (Class48 @class in this.vmethod_21().method_2())
				{
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected)
							{
								list.Add(class2);
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
			try
			{
				foreach (Class48 class3 in list)
				{
					Aircraft aircraft = (Aircraft)class3.Tag;
					aircraft.method_164().method_34().method_24().TryRemove(aircraft.string_0, ref aircraft);
					Client.smethod_46().method_66(aircraft.string_0, true);
					class3.method_9().method_7().Remove(class3);
				}
			}
			finally
			{
				List<Class48>.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
			if (Client.smethod_0().method_0() == Class279.Enum68.const_0)
			{
				Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), Client.smethod_54(), false);
			}
			this.method_17();
		}

		// Token: 0x0600742E RID: 29742 RVA: 0x003EBFCC File Offset: 0x003EA1CC
		private void method_45(object sender, EventArgs e)
		{
			this.vmethod_51().Text = this.method_46();
			if (this.bool_5)
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.method_4())
					{
						Aircraft aircraft = (Aircraft)activeUnit;
						Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
						if (aircraft_AirOps.int_1 >= this.vmethod_53().SelectedIndex + 2)
						{
							if (DarkMessageBox.smethod_1("Aircraft " + aircraft.Name + " had flow equal or more sorties than the selected Max Number of Sorties. Do you want to change to this number and stand down?", "Change Max Number of Sorties and Stand Down?", Enum11.const_3) == DialogResult.Yes)
							{
								aircraft_AirOps.method_51(ref aircraft_AirOps, ref aircraft);
								if (this.vmethod_53().SelectedIndex + 2 <= aircraft.method_167().int_10)
								{
									aircraft_AirOps.int_2 = this.vmethod_53().SelectedIndex + 2;
								}
							}
						}
						else if (this.vmethod_53().SelectedIndex + 2 <= aircraft.method_167().int_10)
						{
							aircraft_AirOps.int_2 = this.vmethod_53().SelectedIndex + 2;
						}
					}
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			this.imethod_0();
		}

		// Token: 0x0600742F RID: 29743 RVA: 0x003EC0E4 File Offset: 0x003EA2E4
		public string method_46()
		{
			string result;
			if (this.vmethod_53().SelectedIndex + 2 <= this.int_3)
			{
				result = string.Concat(new string[]
				{
					Conversions.ToString(this.vmethod_53().SelectedIndex + 2),
					" sorties @ ",
					Misc.smethod_11((long)(this.int_1 * 60), Aircraft_AirOps.Enum44.const_0, false, false),
					" maximum airborne time and ",
					Misc.smethod_11((long)(this.int_2 * 60), Aircraft_AirOps.Enum44.const_0, false, false),
					" turnaround, with ",
					Misc.smethod_11((long)(this.int_0 * 60), Aircraft_AirOps.Enum44.const_0, false, false),
					" standdown ready time"
				});
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06007430 RID: 29744 RVA: 0x003EC194 File Offset: 0x003EA394
		private void method_47(int? nullable_0)
		{
			this.vmethod_53().Items.Clear();
			this.vmethod_53().SelectedIndex = -1;
			if (this.vmethod_89().CheckState != CheckState.Indeterminate && this.vmethod_89().Checked)
			{
				int num = this.int_3;
				for (int i = 2; i <= num; i++)
				{
					if (i == this.int_3)
					{
						this.vmethod_53().Items.Add(Conversions.ToString(i) + " Sorties (Maximum)");
					}
					else
					{
						this.vmethod_53().Items.Add(Conversions.ToString(i) + " Sorties");
					}
				}
				if (!Information.IsNothing(nullable_0) && this.vmethod_53().Items.Count > 0)
				{
					Aircraft_AirOps aircraft_AirOps = (Aircraft_AirOps)this.method_4()[0].vmethod_92();
					if (aircraft_AirOps.int_2 == 0)
					{
						this.vmethod_53().SelectedIndex = this.int_3 - 2;
						return;
					}
					if (this.vmethod_53().Items.Count < aircraft_AirOps.int_2 - 2)
					{
						this.vmethod_53().SelectedIndex = this.vmethod_53().Items.Count - 1;
						return;
					}
					try
					{
						this.vmethod_53().SelectedIndex = aircraft_AirOps.int_2 - 2;
						return;
					}
					catch (Exception ex)
					{
						this.vmethod_53().SelectedIndex = 0;
						return;
					}
				}
				this.vmethod_53().Items.Add("Various");
				this.vmethod_53().SelectedIndex = this.vmethod_53().Items.Count - 1;
			}
		}

		// Token: 0x06007431 RID: 29745 RVA: 0x0004859E File Offset: 0x0004679E
		private void method_48(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				this.method_49(new int?(this.int_3));
			}
			this.imethod_0();
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x003EC340 File Offset: 0x003EA540
		private void method_49(int? nullable_0)
		{
			if (this.vmethod_89().Checked)
			{
				this.vmethod_53().Enabled = true;
				this.method_47(nullable_0);
				this.vmethod_51().Enabled = true;
				this.vmethod_51().Text = this.method_46();
				if (!this.bool_5)
				{
					return;
				}
				try
				{
					foreach (ActiveUnit activeUnit in this.method_4())
					{
						((Aircraft)activeUnit).method_164().bool_0 = true;
					}
					return;
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			this.vmethod_53().Enabled = false;
			this.method_47(nullable_0);
			this.vmethod_51().Enabled = false;
			this.vmethod_51().Text = "";
			if (this.bool_5)
			{
				try
				{
					foreach (ActiveUnit activeUnit2 in this.method_4())
					{
						Aircraft aircraft = (Aircraft)activeUnit2;
						Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
						if (aircraft_AirOps.int_1 > 0)
						{
							if (DarkMessageBox.smethod_1("Aircraft " + aircraft.Name + " had Quick Turnaround enabled previously and has flown at least one Quick Turnaround Sortie. Do you want to disable Quick Turnaround and stand down?", "Disable Quick Turnaround and Stand Down?", Enum11.const_3) == DialogResult.Yes)
							{
								aircraft_AirOps.bool_0 = false;
								aircraft_AirOps.method_51(ref aircraft_AirOps, ref aircraft);
							}
						}
						else
						{
							aircraft_AirOps.bool_0 = false;
							aircraft_AirOps.method_51(ref aircraft_AirOps, ref aircraft);
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
			}
		}

		// Token: 0x06007433 RID: 29747 RVA: 0x003EC4AC File Offset: 0x003EA6AC
		private void AirOps_FormClosed(object sender, FormClosedEventArgs e)
		{
			Aircraft_AirOps.smethod_2(new Aircraft_AirOps.Delegate23(this.method_11));
			Aircraft_AirOps.smethod_4(new Aircraft_AirOps.Delegate24(this.method_9));
			Group.smethod_11(new Group.Delegate32(this.method_5));
			Group.smethod_13(new Group.Delegate33(this.method_6));
		}

		// Token: 0x06007434 RID: 29748 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_50(object sender, EventArgs e)
		{
		}

		// Token: 0x06007435 RID: 29749 RVA: 0x003EC500 File Offset: 0x003EA700
		private void method_51(object sender, EventArgs e)
		{
			this.hashSet_1.Clear();
			try
			{
				foreach (Class48 @class in this.vmethod_21().method_2())
				{
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected)
							{
								this.hashSet_1.Add(((Aircraft)class2.Tag).string_0);
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
			this.vmethod_63().DropDownItems.Clear();
			if (this.method_4().Count > 0)
			{
				new ToolStripMenuItem();
				((ToolStripMenuItem)this.vmethod_63().DropDown.Items.Add("< Unassign >", null, new EventHandler(this.method_50))).Tag = null;
				try
				{
					foreach (Mission mission in Client.smethod_50().method_35())
					{
						ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
						ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
						toolStripMenuItem = (ToolStripMenuItem)this.vmethod_63().DropDown.Items.Add(mission.Name, null, new EventHandler(this.method_50));
						toolStripMenuItem.Tag = mission;
						if (mission._MissionClass_0 == Mission._MissionClass.Strike)
						{
							toolStripMenuItem2 = (ToolStripMenuItem)this.vmethod_63().DropDown.Items.Add(mission.Name + " - Escort", null, new EventHandler(this.method_50));
							toolStripMenuItem2.Tag = mission;
						}
						if (this.method_4().Count == 1)
						{
							ActiveUnit activeUnit = this.method_4()[0];
							if (mission == activeUnit.vmethod_101())
							{
								if (mission._MissionClass_0 == Mission._MissionClass.Strike && activeUnit.vmethod_86().bool_2)
								{
									toolStripMenuItem2.Checked = true;
								}
								else
								{
									toolStripMenuItem.Checked = true;
								}
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
			}
		}

		// Token: 0x06007436 RID: 29750 RVA: 0x000485BF File Offset: 0x000467BF
		private void method_52(object sender, ToolStripItemClickedEventArgs e)
		{
			this.method_53(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06007437 RID: 29751 RVA: 0x003EC758 File Offset: 0x003EA958
		private void method_53(object sender, ToolStripItemClickedEventArgs e)
		{
			this.method_25(false, true, true, false, false);
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(e.ClickedItem.Tag)))
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.method_4())
					{
						Class2413.smethod_2().method_41().method_399(ref activeUnit);
					}
					goto IL_DD;
				}
				finally
				{
					IEnumerator<ActiveUnit> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			Mission mission_ = (Mission)e.ClickedItem.Tag;
			bool flag = Strings.InStr(e.ClickedItem.Text, " - Escort", CompareMethod.Binary) != 0;
			Client.smethod_55(RuntimeHelpers.GetObjectValue(sender), this.method_4(), ref mission_, ref flag);
			try
			{
				foreach (ActiveUnit activeUnit2 in this.method_4())
				{
					Class514.smethod_72(activeUnit2.scenario_0, mission_, ref activeUnit2);
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
			IL_DD:
			this.imethod_0();
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x003EC864 File Offset: 0x003EAA64
		private void method_54(object sender, EventArgs e)
		{
			this.method_25(false, true, true, false, false);
			if (this.method_4().Count > 0)
			{
				MainForm mainForm = Class2413.smethod_2().method_41();
				Class310 class310_ = null;
				ReadOnlyCollection<Unit> readOnlyCollection = null;
				List<ActiveUnit> list = Enumerable.ToList<ActiveUnit>(this.method_4());
				mainForm.method_308(class310_, ref readOnlyCollection, ref list, false);
			}
		}

		// Token: 0x06007439 RID: 29753 RVA: 0x0004851E File Offset: 0x0004671E
		private void method_55(object sender, EventArgs e)
		{
			this.method_24();
		}

		// Token: 0x0600743A RID: 29754 RVA: 0x00048565 File Offset: 0x00046765
		private void method_56(object sender, EventArgs e)
		{
			this.method_31();
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x00048526 File Offset: 0x00046726
		private void method_57(object sender, EventArgs e)
		{
			this.method_27();
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x0004857E File Offset: 0x0004677E
		private void method_58(object sender, EventArgs e)
		{
			this.method_35();
		}

		// Token: 0x0600743D RID: 29757 RVA: 0x003EC864 File Offset: 0x003EAA64
		private void method_59(object sender, EventArgs e)
		{
			this.method_25(false, true, true, false, false);
			if (this.method_4().Count > 0)
			{
				MainForm mainForm = Class2413.smethod_2().method_41();
				Class310 class310_ = null;
				ReadOnlyCollection<Unit> readOnlyCollection = null;
				List<ActiveUnit> list = Enumerable.ToList<ActiveUnit>(this.method_4());
				mainForm.method_308(class310_, ref readOnlyCollection, ref list, false);
			}
		}

		// Token: 0x0600743E RID: 29758 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_60(object sender, EventArgs e)
		{
		}

		// Token: 0x0600743F RID: 29759 RVA: 0x0004858E File Offset: 0x0004678E
		private void method_61(object sender, EventArgs e)
		{
			this.method_42();
		}

		// Token: 0x06007440 RID: 29760 RVA: 0x00048586 File Offset: 0x00046786
		private void method_62(object sender, EventArgs e)
		{
			this.method_40();
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x00048596 File Offset: 0x00046796
		private void method_63(object sender, EventArgs e)
		{
			this.method_44();
		}

		// Token: 0x06007442 RID: 29762 RVA: 0x003EC8B0 File Offset: 0x003EAAB0
		private void method_64()
		{
			this.vmethod_79().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			this.vmethod_81().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			this.vmethod_83().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			this.vmethod_77().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			if (this.method_4().Count > 0)
			{
				this.vmethod_67().Enabled = true;
				this.vmethod_69().Enabled = true;
				this.vmethod_71().Enabled = true;
				this.vmethod_73().Enabled = true;
				this.vmethod_59().Enabled = true;
				this.vmethod_61().Enabled = true;
				if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
				{
					this.vmethod_79().Enabled = true;
					this.vmethod_81().Enabled = true;
					this.vmethod_83().Enabled = true;
				}
			}
			else
			{
				this.vmethod_67().Enabled = false;
				this.vmethod_69().Enabled = false;
				this.vmethod_71().Enabled = false;
				this.vmethod_73().Enabled = false;
				this.vmethod_59().Enabled = false;
				this.vmethod_61().Enabled = false;
				if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
				{
					this.vmethod_79().Enabled = false;
					this.vmethod_81().Enabled = false;
					this.vmethod_83().Enabled = false;
				}
			}
			this.hashSet_1.Clear();
			try
			{
				foreach (Class48 @class in this.vmethod_21().method_2())
				{
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected)
							{
								this.hashSet_1.Add(((Aircraft)class2.Tag).string_0);
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
			this.vmethod_61().DropDownItems.Clear();
			if (this.method_4().Count > 0)
			{
				new ToolStripMenuItem();
				((ToolStripMenuItem)this.vmethod_61().DropDown.Items.Add("< Unassign >", null, new EventHandler(this.method_60))).Tag = null;
				try
				{
					foreach (Mission mission in Client.smethod_50().method_35())
					{
						ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
						ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
						toolStripMenuItem = (ToolStripMenuItem)this.vmethod_61().DropDown.Items.Add(mission.Name, null, new EventHandler(this.method_60));
						toolStripMenuItem.Tag = mission;
						if (mission._MissionClass_0 == Mission._MissionClass.Strike)
						{
							toolStripMenuItem2 = (ToolStripMenuItem)this.vmethod_61().DropDown.Items.Add(mission.Name + " - Escort", null, new EventHandler(this.method_60));
							toolStripMenuItem2.Tag = mission;
						}
						if (this.method_4().Count == 1)
						{
							ActiveUnit activeUnit = this.method_4()[0];
							if (mission == activeUnit.vmethod_101())
							{
								if (mission._MissionClass_0 == Mission._MissionClass.Strike && activeUnit.vmethod_86().bool_2)
								{
									toolStripMenuItem2.Checked = true;
								}
								else
								{
									toolStripMenuItem.Checked = true;
								}
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
			}
		}

		// Token: 0x06007443 RID: 29763 RVA: 0x000485CE File Offset: 0x000467CE
		private void method_65(object sender, CancelEventArgs e)
		{
			this.method_64();
		}

		// Token: 0x06007444 RID: 29764 RVA: 0x000485BF File Offset: 0x000467BF
		private void method_66(object sender, ToolStripItemClickedEventArgs e)
		{
			this.method_53(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06007445 RID: 29765 RVA: 0x00044489 File Offset: 0x00042689
		private void AirOps_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x06007446 RID: 29766 RVA: 0x003ECC6C File Offset: 0x003EAE6C
		private void method_67(object sender, EventArgs e)
		{
			this.hashSet_1.Clear();
			try
			{
				foreach (Class48 @class in this.vmethod_21().method_2())
				{
					if (@class.Selected)
					{
						try
						{
							foreach (Aircraft aircraft in ((IEnumerable<Aircraft>)@class.Tag))
							{
								if (aircraft.method_164().method_68())
								{
									this.hashSet_1.Add(aircraft.string_0);
								}
							}
						}
						finally
						{
							IEnumerator<Aircraft> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
					}
					if (this.method_4().Count > 0)
					{
						break;
					}
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected && ((Aircraft)class2.Tag).method_164().method_68())
							{
								this.hashSet_1.Add(((Aircraft)class2.Tag).string_0);
							}
						}
					}
					finally
					{
						IEnumerator<Class48> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
					if (this.method_4().Count > 0)
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
			if (this.method_4().Count == 1)
			{
				Class2413.smethod_2().method_12().activeUnit_0 = null;
				Class2413.smethod_2().method_12().activeUnit_1 = this.method_4()[0];
				Class2413.smethod_2().method_12().Show();
			}
		}

		// Token: 0x06007447 RID: 29767 RVA: 0x003ECE34 File Offset: 0x003EB034
		private void method_68(object object_0, Class47 class47_0)
		{
			AirOps.Class2497 @class = new AirOps.Class2497(@class);
			@class.airOps_0 = this;
			@class.class47_0 = class47_0;
			@class.class47_0.method_0().method_7().Clear();
			if (@class.class47_0.method_0().method_8() == 1)
			{
				AirOps.Class2495 class2 = new AirOps.Class2495(class2);
				class2.class2497_0 = @class;
				int dbid = Enumerable.ElementAtOrDefault<Aircraft>((IEnumerable<Aircraft>)class2.class2497_0.class47_0.method_0().Tag, 0).DBID;
				if (!this.list_2.Contains(dbid))
				{
					this.list_2.Add(dbid);
				}
				class2.list_0 = Enumerable.ToList<Aircraft>(Enumerable.OrderBy<Aircraft, string>(Enumerable.Select<Aircraft, Aircraft>((IEnumerable<Aircraft>)class2.class2497_0.class47_0.method_0().Tag, (AirOps._Closure$__.$I334-0 == null) ? (AirOps._Closure$__.$I334-0 = new Func<Aircraft, Aircraft>(AirOps._Closure$__.$I.method_6)) : AirOps._Closure$__.$I334-0), (AirOps._Closure$__.$I334-1 == null) ? (AirOps._Closure$__.$I334-1 = new Func<Aircraft, string>(AirOps._Closure$__.$I.method_7)) : AirOps._Closure$__.$I334-1, new Class440<string[]>(true)));
				Task.Factory.StartNew(new Action(class2.method_0));
			}
		}

		// Token: 0x06007448 RID: 29768 RVA: 0x003ECF64 File Offset: 0x003EB164
		private void method_69(Class48 class48_0, Aircraft aircraft_0)
		{
			string text;
			if (aircraft_0.method_164().method_38() == 0f)
			{
				text = null;
				if (aircraft_0.method_147(ref text) == Aircraft_AirOps.Enum44.const_0)
				{
					class48_0.DefaultCellStyle.ForeColor = Color.LightGreen;
					return;
				}
			}
			text = null;
			if (aircraft_0.method_147(ref text) == Aircraft_AirOps.Enum44.const_0)
			{
				class48_0.DefaultCellStyle.ForeColor = Color.Orange;
				return;
			}
			class48_0.DefaultCellStyle.ForeColor = Color.Red;
		}

		// Token: 0x0400410B RID: 16651
		[CompilerGenerated]
		[AccessedThroughProperty("TabControl1")]
		private Control12 control12_0;

		// Token: 0x0400410C RID: 16652
		[AccessedThroughProperty("TabPage1")]
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x0400410D RID: 16653
		[AccessedThroughProperty("TabPage2")]
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x0400410E RID: 16654
		[AccessedThroughProperty("Timer1")]
		[CompilerGenerated]
		private Timer timer_0;

		// Token: 0x0400410F RID: 16655
		[AccessedThroughProperty("Facilities")]
		[CompilerGenerated]
		private Class44 class44_0;

		// Token: 0x04004110 RID: 16656
		[CompilerGenerated]
		[AccessedThroughProperty("theStatus")]
		private Class44 class44_1;

		// Token: 0x04004111 RID: 16657
		[AccessedThroughProperty("ToolStripButton1")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04004112 RID: 16658
		[AccessedThroughProperty("ToolStripButton2")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x04004113 RID: 16659
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripButton3")]
		private ToolStripButton toolStripButton_2;

		// Token: 0x04004114 RID: 16660
		[CompilerGenerated]
		[AccessedThroughProperty("TV_Facilities")]
		private Control6 control6_0;

		// Token: 0x04004115 RID: 16661
		[CompilerGenerated]
		[AccessedThroughProperty("Timer2")]
		private Timer timer_1;

		// Token: 0x04004116 RID: 16662
		[CompilerGenerated]
		[AccessedThroughProperty("TGV_Aircraft")]
		private Class50 class50_0;

		// Token: 0x04004117 RID: 16663
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x04004118 RID: 16664
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_AbortLaunch")]
		private ToolStripButton toolStripButton_3;

		// Token: 0x04004119 RID: 16665
		[AccessedThroughProperty("Label5")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x0400411A RID: 16666
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x0400411B RID: 16667
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_2;

		// Token: 0x0400411C RID: 16668
		[AccessedThroughProperty("Label_Loadout")]
		[CompilerGenerated]
		private Class116 class116_3;

		// Token: 0x0400411D RID: 16669
		[AccessedThroughProperty("DGV_LoadoutItems")]
		[CompilerGenerated]
		private Class114 class114_0;

		// Token: 0x0400411E RID: 16670
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_4;

		// Token: 0x0400411F RID: 16671
		[AccessedThroughProperty("Label6")]
		[CompilerGenerated]
		private Class116 class116_5;

		// Token: 0x04004120 RID: 16672
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_SetReadyTime")]
		private ToolStripButton toolStripButton_4;

		// Token: 0x04004121 RID: 16673
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_Rename")]
		private ToolStripButton toolStripButton_5;

		// Token: 0x04004122 RID: 16674
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_Delete")]
		private ToolStripButton toolStripButton_6;

		// Token: 0x04004123 RID: 16675
		[CompilerGenerated]
		[AccessedThroughProperty("Label7")]
		private Class116 class116_6;

		// Token: 0x04004124 RID: 16676
		[AccessedThroughProperty("Label8")]
		[CompilerGenerated]
		private Class116 class116_7;

		// Token: 0x04004125 RID: 16677
		[AccessedThroughProperty("Label_QuickTurnaroundInfo")]
		[CompilerGenerated]
		private Class116 class116_8;

		// Token: 0x04004126 RID: 16678
		[AccessedThroughProperty("Combo_NumberOfSorties")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x04004127 RID: 16679
		[AccessedThroughProperty("ToolStripSeparator2")]
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_1;

		// Token: 0x04004128 RID: 16680
		[AccessedThroughProperty("CMenu_AirOps")]
		[CompilerGenerated]
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x04004129 RID: 16681
		[AccessedThroughProperty("TSMI_Doctrine")]
		[CompilerGenerated]
		private Class128 class128_0;

		// Token: 0x0400412A RID: 16682
		[AccessedThroughProperty("TSMI_AssignToMission")]
		[CompilerGenerated]
		private Class128 class128_1;

		// Token: 0x0400412B RID: 16683
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_AssignToMission")]
		private ToolStripDropDownButton toolStripDropDownButton_0;

		// Token: 0x0400412C RID: 16684
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_Doctrine")]
		private ToolStripButton toolStripButton_7;

		// Token: 0x0400412D RID: 16685
		[CompilerGenerated]
		[AccessedThroughProperty("LaunchIndividuallyToolStripMenuItem")]
		private Class128 class128_2;

		// Token: 0x0400412E RID: 16686
		[AccessedThroughProperty("LaunchAsGroupsToolStripMenuItem")]
		[CompilerGenerated]
		private Class128 class128_3;

		// Token: 0x0400412F RID: 16687
		[CompilerGenerated]
		[AccessedThroughProperty("ReadyArmToolStripMenuItem")]
		private Class128 class128_4;

		// Token: 0x04004130 RID: 16688
		[CompilerGenerated]
		[AccessedThroughProperty("AbortLaunchToolStripMenuItem")]
		private Class128 class128_5;

		// Token: 0x04004131 RID: 16689
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator toolStripSeparator_2;

		// Token: 0x04004132 RID: 16690
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator toolStripSeparator_3;

		// Token: 0x04004133 RID: 16691
		[CompilerGenerated]
		[AccessedThroughProperty("SetTimeToReadyToolStripMenuItem")]
		private Class128 class128_6;

		// Token: 0x04004134 RID: 16692
		[CompilerGenerated]
		[AccessedThroughProperty("RenameToolStripMenuItem")]
		private Class128 class128_7;

		// Token: 0x04004135 RID: 16693
		[CompilerGenerated]
		[AccessedThroughProperty("RemoveToolStripMenuItem")]
		private Class128 class128_8;

		// Token: 0x04004136 RID: 16694
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_Cargo")]
		private ToolStripButton toolStripButton_8;

		// Token: 0x04004137 RID: 16695
		[AccessedThroughProperty("ToolStrip1")]
		[CompilerGenerated]
		private Class125 class125_0;

		// Token: 0x04004138 RID: 16696
		[CompilerGenerated]
		[AccessedThroughProperty("CB_QuickTurnaround")]
		private Class112 class112_0;

		// Token: 0x04004139 RID: 16697
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_9;

		// Token: 0x0400413A RID: 16698
		[CompilerGenerated]
		[AccessedThroughProperty("Aircraft")]
		private Class44 class44_2;

		// Token: 0x0400413B RID: 16699
		[CompilerGenerated]
		[AccessedThroughProperty("Status")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x0400413C RID: 16700
		[CompilerGenerated]
		[AccessedThroughProperty("Mission")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x0400413D RID: 16701
		[AccessedThroughProperty("Loadout")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x0400413E RID: 16702
		[CompilerGenerated]
		[AccessedThroughProperty("TimeToReady")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x0400413F RID: 16703
		[CompilerGenerated]
		[AccessedThroughProperty("QuickTurnaroundDescription")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04004140 RID: 16704
		[CompilerGenerated]
		[AccessedThroughProperty("FlowLayoutPanel1")]
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x04004141 RID: 16705
		[CompilerGenerated]
		[AccessedThroughProperty("ComponentID")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x04004142 RID: 16706
		[CompilerGenerated]
		[AccessedThroughProperty("Column_Description")]
		private DataGridViewLinkColumn dataGridViewLinkColumn_0;

		// Token: 0x04004143 RID: 16707
		[AccessedThroughProperty("Available")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x04004144 RID: 16708
		[AccessedThroughProperty("AvailableTotal")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		// Token: 0x04004145 RID: 16709
		public HashSet<string> hashSet_0;

		// Token: 0x04004146 RID: 16710
		private HashSet<string> hashSet_1;

		// Token: 0x04004147 RID: 16711
		private string string_0;

		// Token: 0x04004148 RID: 16712
		private List<Aircraft> list_0;

		// Token: 0x04004149 RID: 16713
		private List<Aircraft> list_1;

		// Token: 0x0400414A RID: 16714
		private Class2419 class2419_0;

		// Token: 0x0400414B RID: 16715
		private bool bool_3;

		// Token: 0x0400414C RID: 16716
		private List<int> list_2;

		// Token: 0x0400414D RID: 16717
		private DataTable dataTable_0;

		// Token: 0x0400414E RID: 16718
		private DataTable dataTable_1;

		// Token: 0x0400414F RID: 16719
		private int int_0;

		// Token: 0x04004150 RID: 16720
		private bool bool_4;

		// Token: 0x04004151 RID: 16721
		private int int_1;

		// Token: 0x04004152 RID: 16722
		private int int_2;

		// Token: 0x04004153 RID: 16723
		private int int_3;

		// Token: 0x04004154 RID: 16724
		private int int_4;

		// Token: 0x04004155 RID: 16725
		private bool bool_5;

		// Token: 0x04004156 RID: 16726
		private Dictionary<int, int> dictionary_0;

		// Token: 0x04004157 RID: 16727
		[CompilerGenerated]
		[AccessedThroughProperty("BW_TGV_Aircraft")]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x02000E91 RID: 3729
		[CompilerGenerated]
		internal sealed class Class2493
		{
			// Token: 0x06007449 RID: 29769 RVA: 0x000485D6 File Offset: 0x000467D6
			public Class2493(AirOps.Class2493 class2493_0)
			{
				if (class2493_0 != null)
				{
					this.aircraft_0 = class2493_0.aircraft_0;
				}
			}

			// Token: 0x0600744A RID: 29770 RVA: 0x000485ED File Offset: 0x000467ED
			internal bool method_0(Class48 class48_0)
			{
				return class48_0.Tag == this.aircraft_0;
			}

			// Token: 0x04004158 RID: 16728
			public Aircraft aircraft_0;
		}

		// Token: 0x02000E92 RID: 3730
		[CompilerGenerated]
		internal sealed class Class2494
		{
			// Token: 0x0600744B RID: 29771 RVA: 0x000485FD File Offset: 0x000467FD
			public Class2494(AirOps.Class2494 class2494_0)
			{
				if (class2494_0 != null)
				{
					this.int_0 = class2494_0.int_0;
				}
			}

			// Token: 0x0600744C RID: 29772 RVA: 0x00048614 File Offset: 0x00046814
			internal bool method_0(Aircraft aircraft_0)
			{
				return aircraft_0.DBID == this.int_0;
			}

			// Token: 0x04004159 RID: 16729
			public int int_0;
		}

		// Token: 0x02000E94 RID: 3732
		[CompilerGenerated]
		internal sealed class Class2495
		{
			// Token: 0x06007457 RID: 29783 RVA: 0x00048638 File Offset: 0x00046838
			public Class2495(AirOps.Class2495 class2495_0)
			{
				if (class2495_0 != null)
				{
					this.list_0 = class2495_0.list_0;
				}
			}

			// Token: 0x06007458 RID: 29784 RVA: 0x003ECFD0 File Offset: 0x003EB1D0
			internal void method_0()
			{
				try
				{
					List<Aircraft>.Enumerator enumerator = this.list_0.GetEnumerator();
					while (enumerator.MoveNext())
					{
						AirOps.Class2498 @class = new AirOps.Class2498(@class);
						@class.class2495_0 = this;
						@class.aircraft_0 = enumerator.Current;
						AirOps.Class2496 class2 = new AirOps.Class2496(class2);
						class2.class2498_0 = @class;
						if (Information.IsNothing(class2.class2498_0.aircraft_0.method_167()))
						{
							class2.string_1 = "No Loadout";
						}
						else
						{
							class2.string_1 = class2.class2498_0.aircraft_0.method_167().Name;
						}
						if (Information.IsNothing(class2.class2498_0.aircraft_0.vmethod_101()))
						{
							if (!Information.IsNothing(class2.class2498_0.aircraft_0.vmethod_103()))
							{
								class2.string_0 = class2.class2498_0.aircraft_0.vmethod_103().Name + " (Task Pool)";
							}
							else
							{
								class2.string_0 = "-";
							}
						}
						else
						{
							string text = "";
							if (class2.class2498_0.aircraft_0.method_158().bool_2)
							{
								text = ", Escort";
							}
							class2.string_0 = string.Concat(new string[]
							{
								class2.class2498_0.aircraft_0.vmethod_101().Name,
								" (",
								class2.class2498_0.aircraft_0.vmethod_101().vmethod_5(Client.smethod_46()),
								text,
								")"
							});
						}
						this.class2497_0.airOps_0.vmethod_21().Invoke(new VB$AnonymousDelegate_0(class2.method_0));
					}
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}

			// Token: 0x04004163 RID: 16739
			public List<Aircraft> list_0;

			// Token: 0x04004164 RID: 16740
			public AirOps.Class2497 class2497_0;
		}

		// Token: 0x02000E95 RID: 3733
		[CompilerGenerated]
		internal sealed class Class2496
		{
			// Token: 0x06007459 RID: 29785 RVA: 0x0004864F File Offset: 0x0004684F
			public Class2496(AirOps.Class2496 class2496_0)
			{
				if (class2496_0 != null)
				{
					this.class48_0 = class2496_0.class48_0;
					this.string_0 = class2496_0.string_0;
					this.string_1 = class2496_0.string_1;
				}
			}

			// Token: 0x0600745A RID: 29786 RVA: 0x003ED194 File Offset: 0x003EB394
			internal void method_0()
			{
				Class49 @class = this.class2498_0.class2495_0.class2497_0.class47_0.method_0().method_7();
				object[] array = new object[6];
				array[0] = this.class2498_0.aircraft_0.Name;
				array[1] = this.class2498_0.aircraft_0.method_164().method_40();
				array[2] = this.string_0;
				array[3] = Misc.smethod_9(this.string_1);
				int num = 4;
				long seconds = (long)Math.Round((double)this.class2498_0.aircraft_0.method_164().method_38());
				Aircraft aircraft_ = this.class2498_0.aircraft_0;
				string text = null;
				array[num] = Misc.smethod_11(seconds, aircraft_.method_147(ref text), false, false);
				array[5] = this.class2498_0.aircraft_0.method_148();
				this.class48_0 = @class.method_1(array);
				this.class48_0.DefaultCellStyle.Font = new Font(this.class2498_0.class2495_0.class2497_0.airOps_0.Font, FontStyle.Regular);
				this.class2498_0.class2495_0.class2497_0.airOps_0.method_69(this.class48_0, this.class2498_0.aircraft_0);
				this.class48_0.Tag = this.class2498_0.aircraft_0;
			}

			// Token: 0x04004165 RID: 16741
			public Class48 class48_0;

			// Token: 0x04004166 RID: 16742
			public string string_0;

			// Token: 0x04004167 RID: 16743
			public string string_1;

			// Token: 0x04004168 RID: 16744
			public AirOps.Class2498 class2498_0;
		}

		// Token: 0x02000E96 RID: 3734
		[CompilerGenerated]
		internal sealed class Class2497
		{
			// Token: 0x0600745B RID: 29787 RVA: 0x0004867E File Offset: 0x0004687E
			public Class2497(AirOps.Class2497 class2497_0)
			{
				if (class2497_0 != null)
				{
					this.class47_0 = class2497_0.class47_0;
				}
			}

			// Token: 0x04004169 RID: 16745
			public Class47 class47_0;

			// Token: 0x0400416A RID: 16746
			public AirOps airOps_0;
		}

		// Token: 0x02000E97 RID: 3735
		[CompilerGenerated]
		internal sealed class Class2498
		{
			// Token: 0x0600745C RID: 29788 RVA: 0x00048695 File Offset: 0x00046895
			public Class2498(AirOps.Class2498 class2498_0)
			{
				if (class2498_0 != null)
				{
					this.aircraft_0 = class2498_0.aircraft_0;
				}
			}

			// Token: 0x0400416B RID: 16747
			public Aircraft aircraft_0;

			// Token: 0x0400416C RID: 16748
			public AirOps.Class2495 class2495_0;
		}
	}
}
