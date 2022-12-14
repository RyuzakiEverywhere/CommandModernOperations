using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns10;
using ns2;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;
using ns8;
using ns9;

namespace Command
{
	// Token: 0x02000E9F RID: 3743
	[DesignerGenerated]
	public sealed partial class DockingOps : DarkSecondaryFormBase, Interface66
	{
		// Token: 0x06007558 RID: 30040 RVA: 0x003F4ADC File Offset: 0x003F2CDC
		public DockingOps()
		{
			base.FormClosing += this.DockingOps_FormClosing;
			base.Load += this.DockingOps_Load;
			base.KeyDown += this.DockingOps_KeyDown;
			base.FormClosed += this.DockingOps_FormClosed;
			this.list_0 = new List<ActiveUnit>();
			this.list_1 = new List<ActiveUnit>();
			this.list_2 = new List<ActiveUnit>();
			this.list_3 = new List<ActiveUnit>();
			this.class2419_0 = new Class2419();
			this.hashSet_0 = new HashSet<Class48>();
			this.vmethod_77(new BackgroundWorker());
			this.InitializeComponent_1();
		}

		// Token: 0x0600755A RID: 30042 RVA: 0x003F4BCC File Offset: 0x003F2DCC
		private void InitializeComponent_1()
		{
			this.icontainer_1 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DockingOps));
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			this.vmethod_1(new Control12());
			this.vmethod_3(new TabPage());
			this.vmethod_5(new Class125());
			this.vmethod_7(new ToolStripButton());
			this.vmethod_9(new ToolStripButton());
			this.vmethod_21(new ToolStripButton());
			this.vmethod_23(new ToolStripSeparator());
			this.vmethod_25(new ToolStripButton());
			this.vmethod_27(new ToolStripDropDownButton());
			this.vmethod_43(new ToolStripSeparator());
			this.vmethod_59(new ToolStripButton());
			this.vmethod_11(new SplitContainer());
			this.vmethod_13(new Class50());
			this.vmethod_61(new Class44());
			this.vmethod_63(new DataGridViewLinkColumn());
			this.vmethod_65(new DataGridViewLinkColumn());
			this.vmethod_67(new DataGridViewLinkColumn());
			this.vmethod_69(new DataGridViewTextBoxColumn());
			this.vmethod_71(new DataGridViewTextBoxColumn());
			this.vmethod_73(new DataGridViewTextBoxColumn());
			this.vmethod_75(new DataGridViewTextBoxColumn());
			this.vmethod_29(new Class113());
			this.vmethod_31(new Class128());
			this.vmethod_33(new Class128());
			this.vmethod_35(new Class128());
			this.vmethod_37(new ToolStripSeparator());
			this.vmethod_39(new Class128());
			this.vmethod_41(new Class128());
			this.vmethod_51(new ToolStripSeparator());
			this.vmethod_53(new Class128());
			this.vmethod_55(new Class128());
			this.vmethod_57(new Class128());
			this.vmethod_15(new TabPage());
			this.vmethod_17(new Control6());
			this.vmethod_45(new ToolStripButton());
			this.vmethod_47(new ToolStripButton());
			this.vmethod_49(new ToolStripButton());
			this.vmethod_19(new Timer(this.icontainer_1));
			this.vmethod_0().SuspendLayout();
			this.vmethod_2().SuspendLayout();
			this.vmethod_4().SuspendLayout();
			((ISupportInitialize)this.vmethod_10()).BeginInit();
			this.vmethod_10().Panel1.SuspendLayout();
			this.vmethod_10().SuspendLayout();
			((ISupportInitialize)this.vmethod_12()).BeginInit();
			this.vmethod_28().SuspendLayout();
			this.vmethod_14().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Controls.Add(this.vmethod_2());
			this.vmethod_0().Controls.Add(this.vmethod_14());
			this.vmethod_0().Cursor = Cursors.Hand;
			this.vmethod_0().Dock = DockStyle.Fill;
			this.vmethod_0().Font = new Font(Client.font_1.FontFamily, 8f);
			this.vmethod_0().ItemSize = new Size(80, 20);
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "TabControl1";
			this.vmethod_0().SelectedIndex = 0;
			this.vmethod_0().Size = new Size(852, 531);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().Controls.Add(this.vmethod_4());
			this.vmethod_2().Controls.Add(this.vmethod_10());
			this.vmethod_2().Location = new Point(4, 24);
			this.vmethod_2().Name = "TabPage1";
			this.vmethod_2().Padding = new Padding(3);
			this.vmethod_2().Size = new Size(844, 503);
			this.vmethod_2().TabIndex = 0;
			this.vmethod_2().Text = "Boat Status";
			this.vmethod_4().AutoSize = false;
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().Dock = DockStyle.Bottom;
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_4().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_6(),
				this.vmethod_8(),
				this.vmethod_20(),
				this.vmethod_22(),
				this.vmethod_24(),
				this.vmethod_26(),
				this.vmethod_42(),
				this.vmethod_58()
			});
			this.vmethod_4().Location = new Point(3, 470);
			this.vmethod_4().Name = "ToolStrip1";
			this.vmethod_4().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_4().Size = new Size(838, 30);
			this.vmethod_4().TabIndex = 1;
			this.vmethod_4().Text = "ToolStrip1";
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Image = (Image)componentResourceManager.GetObject("ToolStripButton1.Image");
			this.vmethod_6().ImageTransparentColor = Color.Magenta;
			this.vmethod_6().Name = "ToolStripButton1";
			this.vmethod_6().Size = new Size(130, 27);
			this.vmethod_6().Text = "Launch individually";
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Image = (Image)componentResourceManager.GetObject("ToolStripButton3.Image");
			this.vmethod_8().ImageTransparentColor = Color.Magenta;
			this.vmethod_8().Name = "ToolStripButton3";
			this.vmethod_8().Size = new Size(128, 27);
			this.vmethod_8().Text = "Launch as group(s)";
			this.vmethod_20().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().ImageTransparentColor = Color.Magenta;
			this.vmethod_20().Name = "TSB_AbortLaunch";
			this.vmethod_20().Size = new Size(83, 27);
			this.vmethod_20().Text = "Abort Launch";
			this.vmethod_22().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_22().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_22().Margin = new Padding(0, 0, 2, 0);
			this.vmethod_22().Name = "ToolStripSeparator1";
			this.vmethod_22().Size = new Size(6, 30);
			this.vmethod_24().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_24().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_24().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_24().ImageTransparentColor = Color.Magenta;
			this.vmethod_24().Name = "TSB_Doctrine";
			this.vmethod_24().Size = new Size(56, 27);
			this.vmethod_24().Text = "Doctrine";
			this.vmethod_26().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_26().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().ImageTransparentColor = Color.Magenta;
			this.vmethod_26().Name = "TSB_AssignToMission";
			this.vmethod_26().Size = new Size(113, 27);
			this.vmethod_26().Text = "Assign to mission";
			this.vmethod_42().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_42().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_42().Margin = new Padding(0, 0, 2, 0);
			this.vmethod_42().Name = "ToolStripSeparator3";
			this.vmethod_42().Size = new Size(6, 30);
			this.vmethod_58().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_58().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_58().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_58().ImageTransparentColor = Color.Magenta;
			this.vmethod_58().Name = "TSB_Cargo";
			this.vmethod_58().Size = new Size(72, 22);
			this.vmethod_58().Text = "Un/Load Cargo";
			this.vmethod_10().Dock = DockStyle.Fill;
			this.vmethod_10().FixedPanel = FixedPanel.Panel2;
			this.vmethod_10().Location = new Point(3, 3);
			this.vmethod_10().Name = "SplitContainer1";
			this.vmethod_10().Orientation = Orientation.Horizontal;
			this.vmethod_10().Panel1.Controls.Add(this.vmethod_12());
			this.vmethod_10().Size = new Size(838, 497);
			this.vmethod_10().SplitterDistance = 464;
			this.vmethod_10().TabIndex = 0;
			this.vmethod_12().AllowUserToAddRows = false;
			this.vmethod_12().AllowUserToDeleteRows = false;
			this.vmethod_12().AllowUserToOrderColumns = true;
			this.vmethod_12().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_12().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_12().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
			this.vmethod_12().AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			this.vmethod_12().CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.vmethod_12().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font(Client.font_1.FontFamily, 8f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_12().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_12().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_60(),
				this.vmethod_62(),
				this.vmethod_64(),
				this.vmethod_66(),
				this.vmethod_68(),
				this.vmethod_70(),
				this.vmethod_72(),
				this.vmethod_74()
			});
			this.vmethod_12().ContextMenuStrip = this.vmethod_28();
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font(Client.font_1.FontFamily, 8f);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_12().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_12().Dock = DockStyle.Fill;
			this.vmethod_12().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_12().EnableHeadersVisualStyles = false;
			this.vmethod_12().method_9(null);
			this.vmethod_12().Location = new Point(0, 0);
			this.vmethod_12().Name = "TGV_Boats";
			this.vmethod_12().RowHeadersVisible = false;
			this.vmethod_12().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_12().method_7(false);
			this.vmethod_12().Size = new Size(838, 464);
			this.vmethod_12().TabIndex = 5;
			this.vmethod_60().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle3.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Underline);
			dataGridViewCellStyle3.ForeColor = Color.Blue;
			this.vmethod_60().DefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_60().method_0(null);
			this.vmethod_60().HeaderText = "Boat (click for DB info)";
			this.vmethod_60().Name = "Boat";
			this.vmethod_60().Resizable = DataGridViewTriState.True;
			this.vmethod_60().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_62().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle4.Padding = new Padding(1);
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			this.vmethod_62().DefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_62().HeaderText = "Damage (click for details)";
			this.vmethod_62().Name = "Damage";
			this.vmethod_62().ReadOnly = true;
			this.vmethod_62().LinkColor = Color.LightBlue;
			this.vmethod_64().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle5.Padding = new Padding(1);
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			this.vmethod_64().DefaultCellStyle = dataGridViewCellStyle5;
			this.vmethod_64().HeaderText = "Weapons (click for details)";
			this.vmethod_64().Name = "Weapons";
			this.vmethod_64().ReadOnly = true;
			this.vmethod_64().LinkColor = Color.LightBlue;
			this.vmethod_66().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle6.Padding = new Padding(1);
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
			this.vmethod_66().DefaultCellStyle = dataGridViewCellStyle6;
			this.vmethod_66().HeaderText = "Magazines (click for details)";
			this.vmethod_66().Name = "Magazines";
			this.vmethod_66().ReadOnly = true;
			this.vmethod_66().LinkColor = Color.LightBlue;
			this.vmethod_68().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_68().HeaderText = "Fuel";
			this.vmethod_68().Name = "Fuel";
			this.vmethod_68().ReadOnly = true;
			this.vmethod_68().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_68().Width = 31;
			this.vmethod_70().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_70().HeaderText = "Mission";
			this.vmethod_70().Name = "Mission";
			this.vmethod_70().Resizable = DataGridViewTriState.True;
			this.vmethod_70().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_72().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_72().HeaderText = "Status";
			this.vmethod_72().Name = "Status";
			this.vmethod_72().Resizable = DataGridViewTriState.True;
			this.vmethod_72().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_72().Width = 41;
			this.vmethod_74().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_74().HeaderText = "Time to ready";
			this.vmethod_74().MinimumWidth = 77;
			this.vmethod_74().Name = "TimeToReady";
			this.vmethod_74().Resizable = DataGridViewTriState.True;
			this.vmethod_74().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_74().Width = 77;
			this.vmethod_28().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_28().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_28().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_30(),
				this.vmethod_32(),
				this.vmethod_34(),
				this.vmethod_36(),
				this.vmethod_38(),
				this.vmethod_40(),
				this.vmethod_50(),
				this.vmethod_52(),
				this.vmethod_54(),
				this.vmethod_56()
			});
			this.vmethod_28().Name = "CMenu_BoatOps";
			this.vmethod_28().Size = new Size(178, 194);
			this.vmethod_30().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Name = "LaunchIndividuallyToolStripMenuItem";
			this.vmethod_30().Size = new Size(177, 22);
			this.vmethod_30().Text = "Launch individually";
			this.vmethod_32().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_32().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_32().Name = "LaunchAsGroupsToolStripMenuItem";
			this.vmethod_32().Size = new Size(177, 22);
			this.vmethod_32().Text = "Launch as group(s)";
			this.vmethod_34().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_34().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_34().Name = "AbortLaunchToolStripMenuItem";
			this.vmethod_34().Size = new Size(177, 22);
			this.vmethod_34().Text = "Abort Launch";
			this.vmethod_36().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_36().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_36().Margin = new Padding(0, 0, 0, 1);
			this.vmethod_36().Name = "ToolStripSeparator2";
			this.vmethod_36().Size = new Size(174, 6);
			this.vmethod_38().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_38().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_38().Name = "DoctrineToolStripMenuItem";
			this.vmethod_38().Size = new Size(177, 22);
			this.vmethod_38().Text = "Doctrine";
			this.vmethod_40().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_40().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_40().Name = "AssignToMissionToolStripMenuItem";
			this.vmethod_40().Size = new Size(177, 22);
			this.vmethod_40().Text = "Assign to mission";
			this.vmethod_50().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_50().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_50().Margin = new Padding(0, 0, 0, 1);
			this.vmethod_50().Name = "ToolStripSeparator4";
			this.vmethod_50().Size = new Size(174, 6);
			this.vmethod_52().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_52().Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.vmethod_52().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_52().Name = "SetTimeToReadyToolStripMenuItem";
			this.vmethod_52().Size = new Size(177, 22);
			this.vmethod_52().Text = "Set time to ready";
			this.vmethod_54().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_54().Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.vmethod_54().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_54().Name = "RenameToolStripMenuItem";
			this.vmethod_54().Size = new Size(177, 22);
			this.vmethod_54().Text = "Rename";
			this.vmethod_56().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_56().Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.vmethod_56().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_56().Name = "RemoveToolStripMenuItem";
			this.vmethod_56().Size = new Size(177, 22);
			this.vmethod_56().Text = "Remove";
			this.vmethod_14().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_14().Controls.Add(this.vmethod_16());
			this.vmethod_14().Location = new Point(4, 24);
			this.vmethod_14().Name = "TabPage2";
			this.vmethod_14().Padding = new Padding(3);
			this.vmethod_14().Size = new Size(844, 503);
			this.vmethod_14().TabIndex = 1;
			this.vmethod_14().Text = "Docking Facilities";
			this.vmethod_16().Dock = DockStyle.Fill;
			this.vmethod_16().Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_16().Location = new Point(3, 3);
			this.vmethod_16().method_6(20);
			this.vmethod_16().Name = "TV_Facilities";
			this.vmethod_16().Size = new Size(838, 497);
			this.vmethod_16().TabIndex = 7;
			this.vmethod_44().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_44().Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.vmethod_44().ForeColor = Color.Red;
			this.vmethod_44().ImageTransparentColor = Color.Magenta;
			this.vmethod_44().Name = "TSB_SetReadyTime";
			this.vmethod_44().Size = new Size(108, 22);
			this.vmethod_44().Text = "Set time to ready";
			this.vmethod_46().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_46().Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.vmethod_46().ForeColor = Color.Red;
			this.vmethod_46().ImageTransparentColor = Color.Magenta;
			this.vmethod_46().Name = "TSB_Rename";
			this.vmethod_46().Size = new Size(57, 22);
			this.vmethod_46().Text = "Rename";
			this.vmethod_48().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_48().Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.vmethod_48().ForeColor = Color.Red;
			this.vmethod_48().ImageTransparentColor = Color.Magenta;
			this.vmethod_48().Name = "TSB_Delete";
			this.vmethod_48().Size = new Size(58, 22);
			this.vmethod_48().Text = "Remove";
			this.vmethod_18().Interval = 1000;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(852, 531);
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DockingOps";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Docking Operations";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_4().PerformLayout();
			this.vmethod_10().Panel1.ResumeLayout(false);
			((ISupportInitialize)this.vmethod_10()).EndInit();
			this.vmethod_10().ResumeLayout(false);
			((ISupportInitialize)this.vmethod_12()).EndInit();
			this.vmethod_28().ResumeLayout(false);
			this.vmethod_14().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0600755B RID: 30043 RVA: 0x00048DE6 File Offset: 0x00046FE6
		[CompilerGenerated]
		internal Control12 vmethod_0()
		{
			return this.control12_0;
		}

		// Token: 0x0600755C RID: 30044 RVA: 0x003F63D8 File Offset: 0x003F45D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control12 control12_1)
		{
			EventHandler value = new EventHandler(this.method_16);
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

		// Token: 0x0600755D RID: 30045 RVA: 0x00048DEE File Offset: 0x00046FEE
		[CompilerGenerated]
		internal TabPage vmethod_2()
		{
			return this.tabPage_0;
		}

		// Token: 0x0600755E RID: 30046 RVA: 0x00048DF6 File Offset: 0x00046FF6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TabPage tabPage_2)
		{
			this.tabPage_0 = tabPage_2;
		}

		// Token: 0x0600755F RID: 30047 RVA: 0x00048DFF File Offset: 0x00046FFF
		[CompilerGenerated]
		internal Class125 vmethod_4()
		{
			return this.class125_0;
		}

		// Token: 0x06007560 RID: 30048 RVA: 0x00048E07 File Offset: 0x00047007
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x06007561 RID: 30049 RVA: 0x00048E10 File Offset: 0x00047010
		[CompilerGenerated]
		internal ToolStripButton vmethod_6()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06007562 RID: 30050 RVA: 0x003F641C File Offset: 0x003F461C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.method_17);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_8;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06007563 RID: 30051 RVA: 0x00048E18 File Offset: 0x00047018
		[CompilerGenerated]
		internal ToolStripButton vmethod_8()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x06007564 RID: 30052 RVA: 0x003F6460 File Offset: 0x003F4660
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.method_24);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_8;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06007565 RID: 30053 RVA: 0x00048E20 File Offset: 0x00047020
		[CompilerGenerated]
		internal SplitContainer vmethod_10()
		{
			return this.splitContainer_0;
		}

		// Token: 0x06007566 RID: 30054 RVA: 0x00048E28 File Offset: 0x00047028
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(SplitContainer splitContainer_1)
		{
			this.splitContainer_0 = splitContainer_1;
		}

		// Token: 0x06007567 RID: 30055 RVA: 0x00048E31 File Offset: 0x00047031
		[CompilerGenerated]
		private Class50 vmethod_12()
		{
			return this.class50_0;
		}

		// Token: 0x06007568 RID: 30056 RVA: 0x003F64A4 File Offset: 0x003F46A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_13(Class50 class50_1)
		{
			Delegate3 delegate3_ = new Delegate3(this.method_20);
			Delegate1 delegate1_ = new Delegate1(this.method_21);
			EventHandler value = new EventHandler(this.method_26);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_45);
			Class50 @class = this.class50_0;
			if (@class != null)
			{
				@class.method_16(delegate3_);
				@class.method_12(delegate1_);
				@class.SelectionChanged -= value;
				@class.CellContentClick -= value2;
			}
			this.class50_0 = class50_1;
			@class = this.class50_0;
			if (@class != null)
			{
				@class.method_15(delegate3_);
				@class.method_11(delegate1_);
				@class.SelectionChanged += value;
				@class.CellContentClick += value2;
			}
		}

		// Token: 0x06007569 RID: 30057 RVA: 0x00048E39 File Offset: 0x00047039
		[CompilerGenerated]
		internal TabPage vmethod_14()
		{
			return this.tabPage_1;
		}

		// Token: 0x0600756A RID: 30058 RVA: 0x00048E41 File Offset: 0x00047041
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(TabPage tabPage_2)
		{
			this.tabPage_1 = tabPage_2;
		}

		// Token: 0x0600756B RID: 30059 RVA: 0x00048E4A File Offset: 0x0004704A
		[CompilerGenerated]
		internal Control6 vmethod_16()
		{
			return this.control6_0;
		}

		// Token: 0x0600756C RID: 30060 RVA: 0x00048E52 File Offset: 0x00047052
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Control6 control6_1)
		{
			this.control6_0 = control6_1;
		}

		// Token: 0x0600756D RID: 30061 RVA: 0x00048E5B File Offset: 0x0004705B
		[CompilerGenerated]
		internal Timer vmethod_18()
		{
			return this.timer_0;
		}

		// Token: 0x0600756E RID: 30062 RVA: 0x003F6544 File Offset: 0x003F4744
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_7);
			Timer timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.timer_0 = timer_1;
			timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x00048E63 File Offset: 0x00047063
		[CompilerGenerated]
		internal ToolStripButton vmethod_20()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x06007570 RID: 30064 RVA: 0x003F6588 File Offset: 0x003F4788
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.method_29);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_8;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06007571 RID: 30065 RVA: 0x00048E6B File Offset: 0x0004706B
		[CompilerGenerated]
		internal ToolStripSeparator vmethod_22()
		{
			return this.toolStripSeparator_0;
		}

		// Token: 0x06007572 RID: 30066 RVA: 0x00048E73 File Offset: 0x00047073
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(ToolStripSeparator toolStripSeparator_4)
		{
			this.toolStripSeparator_0 = toolStripSeparator_4;
		}

		// Token: 0x06007573 RID: 30067 RVA: 0x00048E7C File Offset: 0x0004707C
		[CompilerGenerated]
		internal ToolStripButton vmethod_24()
		{
			return this.toolStripButton_3;
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x003F65CC File Offset: 0x003F47CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.method_32);
			ToolStripButton toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_3 = toolStripButton_8;
			toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x00048E84 File Offset: 0x00047084
		[CompilerGenerated]
		internal ToolStripDropDownButton vmethod_26()
		{
			return this.toolStripDropDownButton_0;
		}

		// Token: 0x06007576 RID: 30070 RVA: 0x003F6610 File Offset: 0x003F4810
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(ToolStripDropDownButton toolStripDropDownButton_1)
		{
			EventHandler value = new EventHandler(this.method_33);
			EventHandler value2 = new EventHandler(this.method_34);
			ToolStripItemClickedEventHandler value3 = new ToolStripItemClickedEventHandler(this.method_35);
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

		// Token: 0x06007577 RID: 30071 RVA: 0x00048E8C File Offset: 0x0004708C
		[CompilerGenerated]
		internal Class113 vmethod_28()
		{
			return this.class113_0;
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x003F668C File Offset: 0x003F488C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Class113 class113_1)
		{
			CancelEventHandler value = new CancelEventHandler(this.method_43);
			Class113 @class = this.class113_0;
			if (@class != null)
			{
				@class.Opening -= value;
			}
			this.class113_0 = class113_1;
			@class = this.class113_0;
			if (@class != null)
			{
				@class.Opening += value;
			}
		}

		// Token: 0x06007579 RID: 30073 RVA: 0x00048E94 File Offset: 0x00047094
		[CompilerGenerated]
		internal Class128 vmethod_30()
		{
			return this.class128_0;
		}

		// Token: 0x0600757A RID: 30074 RVA: 0x003F66D0 File Offset: 0x003F48D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Class128 class128_8)
		{
			EventHandler value = new EventHandler(this.method_37);
			Class128 @class = this.class128_0;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_0 = class128_8;
			@class = this.class128_0;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x0600757B RID: 30075 RVA: 0x00048E9C File Offset: 0x0004709C
		[CompilerGenerated]
		internal Class128 vmethod_32()
		{
			return this.class128_1;
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x003F6714 File Offset: 0x003F4914
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Class128 class128_8)
		{
			EventHandler value = new EventHandler(this.method_38);
			Class128 @class = this.class128_1;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_1 = class128_8;
			@class = this.class128_1;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x00048EA4 File Offset: 0x000470A4
		[CompilerGenerated]
		internal Class128 vmethod_34()
		{
			return this.class128_2;
		}

		// Token: 0x0600757E RID: 30078 RVA: 0x003F6758 File Offset: 0x003F4958
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Class128 class128_8)
		{
			EventHandler value = new EventHandler(this.method_39);
			Class128 @class = this.class128_2;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_2 = class128_8;
			@class = this.class128_2;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x0600757F RID: 30079 RVA: 0x00048EAC File Offset: 0x000470AC
		[CompilerGenerated]
		internal ToolStripSeparator vmethod_36()
		{
			return this.toolStripSeparator_1;
		}

		// Token: 0x06007580 RID: 30080 RVA: 0x00048EB4 File Offset: 0x000470B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(ToolStripSeparator toolStripSeparator_4)
		{
			this.toolStripSeparator_1 = toolStripSeparator_4;
		}

		// Token: 0x06007581 RID: 30081 RVA: 0x00048EBD File Offset: 0x000470BD
		[CompilerGenerated]
		internal Class128 vmethod_38()
		{
			return this.class128_3;
		}

		// Token: 0x06007582 RID: 30082 RVA: 0x003F679C File Offset: 0x003F499C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Class128 class128_8)
		{
			EventHandler value = new EventHandler(this.method_40);
			Class128 @class = this.class128_3;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_3 = class128_8;
			@class = this.class128_3;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007583 RID: 30083 RVA: 0x00048EC5 File Offset: 0x000470C5
		[CompilerGenerated]
		internal Class128 vmethod_40()
		{
			return this.class128_4;
		}

		// Token: 0x06007584 RID: 30084 RVA: 0x003F67E0 File Offset: 0x003F49E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Class128 class128_8)
		{
			EventHandler value = new EventHandler(this.method_41);
			ToolStripItemClickedEventHandler value2 = new ToolStripItemClickedEventHandler(this.method_44);
			Class128 @class = this.class128_4;
			if (@class != null)
			{
				@class.Click -= value;
				@class.DropDownItemClicked -= value2;
			}
			this.class128_4 = class128_8;
			@class = this.class128_4;
			if (@class != null)
			{
				@class.Click += value;
				@class.DropDownItemClicked += value2;
			}
		}

		// Token: 0x06007585 RID: 30085 RVA: 0x00048ECD File Offset: 0x000470CD
		[CompilerGenerated]
		internal ToolStripSeparator vmethod_42()
		{
			return this.toolStripSeparator_2;
		}

		// Token: 0x06007586 RID: 30086 RVA: 0x00048ED5 File Offset: 0x000470D5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(ToolStripSeparator toolStripSeparator_4)
		{
			this.toolStripSeparator_2 = toolStripSeparator_4;
		}

		// Token: 0x06007587 RID: 30087 RVA: 0x00048EDE File Offset: 0x000470DE
		[CompilerGenerated]
		internal ToolStripButton vmethod_44()
		{
			return this.toolStripButton_4;
		}

		// Token: 0x06007588 RID: 30088 RVA: 0x003F6840 File Offset: 0x003F4A40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.method_46);
			ToolStripButton toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_4 = toolStripButton_8;
			toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06007589 RID: 30089 RVA: 0x00048EE6 File Offset: 0x000470E6
		[CompilerGenerated]
		internal ToolStripButton vmethod_46()
		{
			return this.toolStripButton_5;
		}

		// Token: 0x0600758A RID: 30090 RVA: 0x003F6884 File Offset: 0x003F4A84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.method_48);
			ToolStripButton toolStripButton = this.toolStripButton_5;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_5 = toolStripButton_8;
			toolStripButton = this.toolStripButton_5;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600758B RID: 30091 RVA: 0x00048EEE File Offset: 0x000470EE
		[CompilerGenerated]
		internal ToolStripButton vmethod_48()
		{
			return this.toolStripButton_6;
		}

		// Token: 0x0600758C RID: 30092 RVA: 0x003F68C8 File Offset: 0x003F4AC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.method_50);
			ToolStripButton toolStripButton = this.toolStripButton_6;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_6 = toolStripButton_8;
			toolStripButton = this.toolStripButton_6;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x00048EF6 File Offset: 0x000470F6
		[CompilerGenerated]
		internal ToolStripSeparator vmethod_50()
		{
			return this.toolStripSeparator_3;
		}

		// Token: 0x0600758E RID: 30094 RVA: 0x00048EFE File Offset: 0x000470FE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(ToolStripSeparator toolStripSeparator_4)
		{
			this.toolStripSeparator_3 = toolStripSeparator_4;
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x00048F07 File Offset: 0x00047107
		[CompilerGenerated]
		internal Class128 vmethod_52()
		{
			return this.class128_5;
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x003F690C File Offset: 0x003F4B0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(Class128 class128_8)
		{
			EventHandler value = new EventHandler(this.method_52);
			Class128 @class = this.class128_5;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_5 = class128_8;
			@class = this.class128_5;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x00048F0F File Offset: 0x0004710F
		[CompilerGenerated]
		internal Class128 vmethod_54()
		{
			return this.class128_6;
		}

		// Token: 0x06007592 RID: 30098 RVA: 0x003F6950 File Offset: 0x003F4B50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(Class128 class128_8)
		{
			EventHandler value = new EventHandler(this.method_53);
			Class128 @class = this.class128_6;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_6 = class128_8;
			@class = this.class128_6;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x00048F17 File Offset: 0x00047117
		[CompilerGenerated]
		internal Class128 vmethod_56()
		{
			return this.class128_7;
		}

		// Token: 0x06007594 RID: 30100 RVA: 0x003F6994 File Offset: 0x003F4B94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(Class128 class128_8)
		{
			EventHandler value = new EventHandler(this.method_54);
			Class128 @class = this.class128_7;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class128_7 = class128_8;
			@class = this.class128_7;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x00048F1F File Offset: 0x0004711F
		[CompilerGenerated]
		internal ToolStripButton vmethod_58()
		{
			return this.toolStripButton_7;
		}

		// Token: 0x06007596 RID: 30102 RVA: 0x003F69D8 File Offset: 0x003F4BD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.method_55);
			ToolStripButton toolStripButton = this.toolStripButton_7;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_7 = toolStripButton_8;
			toolStripButton = this.toolStripButton_7;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x00048F27 File Offset: 0x00047127
		[CompilerGenerated]
		internal Class44 vmethod_60()
		{
			return this.class44_0;
		}

		// Token: 0x06007598 RID: 30104 RVA: 0x00048F2F File Offset: 0x0004712F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(Class44 class44_1)
		{
			this.class44_0 = class44_1;
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x00048F38 File Offset: 0x00047138
		[CompilerGenerated]
		internal DataGridViewLinkColumn vmethod_62()
		{
			return this.dataGridViewLinkColumn_0;
		}

		// Token: 0x0600759A RID: 30106 RVA: 0x00048F40 File Offset: 0x00047140
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(DataGridViewLinkColumn dataGridViewLinkColumn_3)
		{
			this.dataGridViewLinkColumn_0 = dataGridViewLinkColumn_3;
		}

		// Token: 0x0600759B RID: 30107 RVA: 0x00048F49 File Offset: 0x00047149
		[CompilerGenerated]
		internal DataGridViewLinkColumn vmethod_64()
		{
			return this.dataGridViewLinkColumn_1;
		}

		// Token: 0x0600759C RID: 30108 RVA: 0x00048F51 File Offset: 0x00047151
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(DataGridViewLinkColumn dataGridViewLinkColumn_3)
		{
			this.dataGridViewLinkColumn_1 = dataGridViewLinkColumn_3;
		}

		// Token: 0x0600759D RID: 30109 RVA: 0x00048F5A File Offset: 0x0004715A
		[CompilerGenerated]
		internal DataGridViewLinkColumn vmethod_66()
		{
			return this.dataGridViewLinkColumn_2;
		}

		// Token: 0x0600759E RID: 30110 RVA: 0x00048F62 File Offset: 0x00047162
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(DataGridViewLinkColumn dataGridViewLinkColumn_3)
		{
			this.dataGridViewLinkColumn_2 = dataGridViewLinkColumn_3;
		}

		// Token: 0x0600759F RID: 30111 RVA: 0x00048F6B File Offset: 0x0004716B
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_68()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x00048F73 File Offset: 0x00047173
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x060075A1 RID: 30113 RVA: 0x00048F7C File Offset: 0x0004717C
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_70()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x060075A2 RID: 30114 RVA: 0x00048F84 File Offset: 0x00047184
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x00048F8D File Offset: 0x0004718D
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_72()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x00048F95 File Offset: 0x00047195
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x00048F9E File Offset: 0x0004719E
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_74()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x00048FA6 File Offset: 0x000471A6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x00048FAF File Offset: 0x000471AF
		[CompilerGenerated]
		private BackgroundWorker vmethod_76()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x003F6A1C File Offset: 0x003F4C1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_77(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler doWorkEventHandler = new DoWorkEventHandler(this.method_27);
			RunWorkerCompletedEventHandler runWorkerCompletedEventHandler = new RunWorkerCompletedEventHandler(this.method_28);
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

		// Token: 0x060075A9 RID: 30121 RVA: 0x00048FB7 File Offset: 0x000471B7
		private void DockingOps_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.bool_3)
			{
				Client.smethod_0().method_3();
			}
			Class2413.smethod_2().method_41().BringToFront();
			this.vmethod_18().Stop();
		}

		// Token: 0x060075AA RID: 30122 RVA: 0x003F6A7C File Offset: 0x003F4C7C
		private void DockingOps_Load(object sender, EventArgs e)
		{
			this.vmethod_12().DefaultCellStyle.BackColor = Class129.smethod_4();
			this.vmethod_12().DefaultCellStyle.ForeColor = Color.White;
			this.vmethod_0().TabPages[0].BackColor = Class129.smethod_4();
			this.vmethod_0().TabPages[1].BackColor = Class129.smethod_4();
			this.bool_3 = (Client.smethod_0().method_0() == Class279.Enum68.const_1);
			if (this.bool_3)
			{
				Client.smethod_0().method_4();
			}
			if (this.list_0.Count > 1)
			{
				this.Text = "Docking Ops - Multiple host units";
			}
			else
			{
				this.Text = "Docking Ops - " + this.list_0[0].Name;
			}
			this.method_4();
			this.method_12();
			this.vmethod_44().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			this.vmethod_46().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			this.vmethod_48().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			this.vmethod_58().Visible = true;
			this.vmethod_18().Start();
			ActiveUnit_DockingOps.smethod_2(new ActiveUnit_DockingOps.Delegate18(this.method_5));
			ActiveUnit_DockingOps.smethod_0(new ActiveUnit_DockingOps.Delegate17(this.method_3));
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x003F6BD8 File Offset: 0x003F4DD8
		private void method_3(ActiveUnit activeUnit_0)
		{
			try
			{
				List<ActiveUnit>.Enumerator enumerator = this.list_0.GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.vmethod_93().method_14().Contains(activeUnit_0))
					{
						this.list_2.Add(activeUnit_0);
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x060075AC RID: 30124 RVA: 0x00048FE5 File Offset: 0x000471E5
		public void imethod_0()
		{
			this.method_8();
			this.method_13();
		}

		// Token: 0x060075AD RID: 30125 RVA: 0x00048FF3 File Offset: 0x000471F3
		private void method_4()
		{
			this.vmethod_76().RunWorkerAsync();
		}

		// Token: 0x060075AE RID: 30126 RVA: 0x00049000 File Offset: 0x00047200
		private void method_5(ActiveUnit activeUnit_0)
		{
			this.list_3.Add(activeUnit_0);
		}

		// Token: 0x060075AF RID: 30127 RVA: 0x0004900E File Offset: 0x0004720E
		public void method_6()
		{
			this.method_8();
			this.method_13();
			this.list_2.Clear();
			this.list_3.Clear();
		}

		// Token: 0x060075B0 RID: 30128 RVA: 0x00049032 File Offset: 0x00047232
		private void method_7(object sender, EventArgs e)
		{
			if (Client.smethod_0().method_0() == Class279.Enum68.const_1)
			{
				this.method_6();
			}
		}

		// Token: 0x060075B1 RID: 30129 RVA: 0x003F6C44 File Offset: 0x003F4E44
		private void method_8()
		{
			string text;
			string text2;
			string text3;
			string text4;
			string text5;
			string text6;
			string text7;
			try
			{
				foreach (Class48 @class in this.method_9())
				{
					if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(@class.Tag)) && (@class.Tag.GetType() == typeof(Ship) | @class.Tag.GetType() == typeof(Submarine)))
					{
						ActiveUnit activeUnit = (ActiveUnit)@class.Tag;
						this.method_23(activeUnit, ref text, ref text2, ref text3, ref text4, ref text5, ref text6, ref text7);
						@class.SetValues(new object[]
						{
							activeUnit.Name,
							text,
							text2,
							text3,
							text4,
							text5,
							text6,
							text7
						});
						this.method_22(ref @class, activeUnit);
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
				List<ActiveUnit>.Enumerator enumerator2 = this.list_3.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DockingOps.Class2500 class2 = new DockingOps.Class2500(class2);
					class2.activeUnit_0 = enumerator2.Current;
					IEnumerable<Class48> enumerable = Enumerable.Where<Class48>(this.method_9(), new Func<Class48, bool>(class2.method_0));
					if (Enumerable.Count<Class48>(enumerable) > 0)
					{
						Enumerable.ElementAtOrDefault<Class48>(enumerable, 0).method_9().method_7().Remove(Enumerable.ElementAtOrDefault<Class48>(enumerable, 0));
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			try
			{
				foreach (ActiveUnit activeUnit2 in this.list_2)
				{
					bool flag;
					try
					{
						foreach (Class48 class3 in this.vmethod_12().method_2())
						{
							if (class3.GetType() == typeof(List<ActiveUnit>))
							{
								this.method_23(activeUnit2, ref text, ref text2, ref text3, ref text4, ref text5, ref text6, ref text7);
								class3.method_7().method_1(new object[]
								{
									activeUnit2.Name,
									text,
									text2,
									text3,
									text4,
									text5,
									text6,
									text7
								}).Tag = activeUnit2;
								this.method_22(ref class3, activeUnit2);
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
						Class48 class4 = this.vmethod_12().method_2().method_0("1x " + Misc.smethod_9(activeUnit2.string_2));
						class4.Tag = activeUnit2.DBID;
						this.method_23(activeUnit2, ref text, ref text2, ref text3, ref text4, ref text5, ref text6, ref text7);
						Class48 class5 = class4.method_7().method_1(new object[]
						{
							activeUnit2.Name,
							text,
							text2,
							text3,
							text4,
							text5,
							text6,
							text7
						});
						class5.Tag = activeUnit2;
						this.method_22(ref class5, activeUnit2);
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
		}

		// Token: 0x060075B2 RID: 30130 RVA: 0x003F6FAC File Offset: 0x003F51AC
		private ReadOnlyCollection<Class48> method_9()
		{
			List<Class48> list = new List<Class48>();
			try
			{
				foreach (Class48 @class in this.vmethod_12().method_2())
				{
					if (!list.Contains(@class))
					{
						list.Add(@class);
					}
					this.method_10(@class, list);
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
			return list.AsReadOnly();
		}

		// Token: 0x060075B3 RID: 30131 RVA: 0x003F701C File Offset: 0x003F521C
		private void method_10(Class48 class48_0, List<Class48> list_4)
		{
			try
			{
				foreach (Class48 @class in class48_0.method_7())
				{
					if (!list_4.Contains(@class))
					{
						list_4.Add(@class);
					}
					this.method_10(@class, list_4);
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

		// Token: 0x060075B4 RID: 30132 RVA: 0x003F707C File Offset: 0x003F527C
		private void method_11()
		{
			this.vmethod_12().method_2().Clear();
			try
			{
				foreach (ActiveUnit activeUnit in this.list_0)
				{
					IEnumerable<int> enumerable = Enumerable.Distinct<int>(Enumerable.Select<ActiveUnit, int>(Enumerable.Where<ActiveUnit>(activeUnit.vmethod_93().method_14(), (DockingOps._Closure$__.$I181-0 == null) ? (DockingOps._Closure$__.$I181-0 = new Func<ActiveUnit, bool>(DockingOps._Closure$__.$I.method_0)) : DockingOps._Closure$__.$I181-0), (DockingOps._Closure$__.$I181-1 == null) ? (DockingOps._Closure$__.$I181-1 = new Func<ActiveUnit, int>(DockingOps._Closure$__.$I.method_1)) : DockingOps._Closure$__.$I181-1));
					IEnumerable<int> enumerable2 = Enumerable.Distinct<int>(Enumerable.Select<ActiveUnit, int>(Enumerable.Where<ActiveUnit>(activeUnit.vmethod_93().method_14(), (DockingOps._Closure$__.$I181-2 == null) ? (DockingOps._Closure$__.$I181-2 = new Func<ActiveUnit, bool>(DockingOps._Closure$__.$I.method_2)) : DockingOps._Closure$__.$I181-2), (DockingOps._Closure$__.$I181-3 == null) ? (DockingOps._Closure$__.$I181-3 = new Func<ActiveUnit, int>(DockingOps._Closure$__.$I.method_3)) : DockingOps._Closure$__.$I181-3));
					try
					{
						foreach (int int_ in enumerable)
						{
							DockingOps.Class2501 @class = new DockingOps.Class2501(@class);
							@class.int_0 = int_;
							IEnumerable<ActiveUnit> enumerable3 = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(activeUnit.vmethod_93().method_14(), new Func<ActiveUnit, bool>(@class.method_0)), (DockingOps._Closure$__.$I181-5 == null) ? (DockingOps._Closure$__.$I181-5 = new Func<ActiveUnit, ActiveUnit>(DockingOps._Closure$__.$I.method_4)) : DockingOps._Closure$__.$I181-5);
							string text = Conversions.ToString(Enumerable.Count<ActiveUnit>(enumerable3)) + "x " + Misc.smethod_9(Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable3, 0).string_2);
							if (this.list_0.Count > 1)
							{
								text = text + " (" + activeUnit.Name + ")";
							}
							Class48 class2 = this.vmethod_12().method_2().method_0(text);
							class2.DefaultCellStyle.ForeColor = Color.DodgerBlue;
							class2.Tag = enumerable3;
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
						foreach (int int_2 in enumerable2)
						{
							DockingOps.Class2502 class3 = new DockingOps.Class2502(class3);
							class3.int_0 = int_2;
							IEnumerable<ActiveUnit> enumerable4 = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(activeUnit.vmethod_93().method_14(), new Func<ActiveUnit, bool>(class3.method_0)), (DockingOps._Closure$__.$I181-7 == null) ? (DockingOps._Closure$__.$I181-7 = new Func<ActiveUnit, ActiveUnit>(DockingOps._Closure$__.$I.method_5)) : DockingOps._Closure$__.$I181-7);
							string text = Conversions.ToString(Enumerable.Count<ActiveUnit>(enumerable4)) + "x " + Misc.smethod_9(Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable4, 0).string_2);
							if (this.list_0.Count > 1)
							{
								text = text + " (" + activeUnit.Name + ")";
							}
							Class48 class4 = this.vmethod_12().method_2().method_0(text);
							class4.DefaultCellStyle.ForeColor = Color.DodgerBlue;
							class4.Tag = enumerable4;
							class4.method_7().method_0("Temp");
						}
					}
					finally
					{
						IEnumerator<int> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
					try
					{
						foreach (Class48 class5 in this.vmethod_12().method_2())
						{
							class5.vmethod_4();
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
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x060075B5 RID: 30133 RVA: 0x003F7458 File Offset: 0x003F5658
		private void method_12()
		{
			this.vmethod_16().method_20().Clear();
			try
			{
				foreach (Unit unit in this.list_0)
				{
					Class127 @class;
					if (unit.bool_1)
					{
						IEnumerable<ActiveUnit> enumerable = Enumerable.OrderBy<ActiveUnit, string>(Enumerable.Select<ActiveUnit, ActiveUnit>(((Group)unit).vmethod_141().Values, (DockingOps._Closure$__.$I182-0 == null) ? (DockingOps._Closure$__.$I182-0 = new Func<ActiveUnit, ActiveUnit>(DockingOps._Closure$__.$I.method_6)) : DockingOps._Closure$__.$I182-0), (DockingOps._Closure$__.$I182-1 == null) ? (DockingOps._Closure$__.$I182-1 = new Func<ActiveUnit, string>(DockingOps._Closure$__.$I.method_7)) : DockingOps._Closure$__.$I182-1);
						try
						{
							foreach (ActiveUnit activeUnit in enumerable)
							{
								if (activeUnit.vmethod_100().Length > 0)
								{
									@class = new Class127(activeUnit.Name);
									this.vmethod_16().method_20().method_4(@class);
									@class.Tag = activeUnit;
									this.method_14(activeUnit, @class);
								}
							}
							goto IL_12D;
						}
						finally
						{
							IEnumerator<ActiveUnit> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						goto IL_FC;
					}
					goto IL_FC;
					IL_12D:
					Class2558.smethod_6(this.vmethod_16());
					continue;
					IL_FC:
					@class = new Class127(unit.Name);
					this.vmethod_16().method_20().method_4(@class);
					@class.Tag = unit;
					this.method_14((ActiveUnit)unit, @class);
					goto IL_12D;
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x060075B6 RID: 30134 RVA: 0x003F75F0 File Offset: 0x003F57F0
		private void method_13()
		{
			this.vmethod_16().SuspendLayout();
			try
			{
				foreach (Class127 @class in this.vmethod_16().method_20())
				{
					ActiveUnit activeUnit_ = (ActiveUnit)@class.Tag;
					this.method_14(activeUnit_, @class);
				}
			}
			finally
			{
				List<Class127>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.vmethod_16().ResumeLayout();
		}

		// Token: 0x060075B7 RID: 30135 RVA: 0x003F766C File Offset: 0x003F586C
		private void method_14(ActiveUnit activeUnit_0, Class127 class127_0)
		{
			IEnumerable<DockFacility> enumerable = Enumerable.OrderBy<DockFacility, string>(Enumerable.Select<DockFacility, DockFacility>(activeUnit_0.vmethod_100(), (DockingOps._Closure$__.$I184-0 == null) ? (DockingOps._Closure$__.$I184-0 = new Func<DockFacility, DockFacility>(DockingOps._Closure$__.$I.method_8)) : DockingOps._Closure$__.$I184-0), (DockingOps._Closure$__.$I184-1 == null) ? (DockingOps._Closure$__.$I184-1 = new Func<DockFacility, string>(DockingOps._Closure$__.$I.method_9)) : DockingOps._Closure$__.$I184-1);
			try
			{
				foreach (DockFacility dockFacility in enumerable)
				{
					bool flag;
					try
					{
						foreach (Class127 @class in class127_0.method_23())
						{
							if (@class.Tag == dockFacility)
							{
								flag = true;
								this.method_15(dockFacility, @class);
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
						Class127 class2 = new Class127(dockFacility.Name);
						class127_0.method_23().method_4(class2);
						class2.Tag = dockFacility;
						class2.method_22(true);
						try
						{
							foreach (ActiveUnit activeUnit in dockFacility.lazy_0.Value.Values)
							{
								Class127 class3 = new Class127(string.Concat(new string[]
								{
									activeUnit.Name,
									"(",
									Misc.smethod_9(activeUnit.string_2),
									"): ",
									activeUnit.vmethod_93().method_10(),
									" (",
									Misc.smethod_11((long)Math.Round((double)activeUnit.vmethod_93().method_0()), Aircraft_AirOps.Enum44.const_0, false, false),
									")"
								}));
								class2.method_23().method_4(class3);
								class3.Tag = activeUnit;
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
					}
				}
			}
			finally
			{
				IEnumerator<DockFacility> enumerator;
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
					if (!Enumerable.Contains<DockFacility>(activeUnit_0.vmethod_100(), (DockFacility)class4.Tag))
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

		// Token: 0x060075B8 RID: 30136 RVA: 0x003F7958 File Offset: 0x003F5B58
		private void method_15(DockFacility dockFacility_0, Class127 class127_0)
		{
			try
			{
				foreach (ActiveUnit activeUnit in dockFacility_0.lazy_0.Value.Values)
				{
					bool flag;
					try
					{
						foreach (Class127 @class in class127_0.method_23())
						{
							if (@class.Tag == activeUnit)
							{
								flag = true;
								@class.method_7(string.Concat(new string[]
								{
									activeUnit.Name,
									"(",
									Misc.smethod_9(activeUnit.string_2),
									"): ",
									activeUnit.vmethod_93().method_10(),
									" (",
									Misc.smethod_11((long)Math.Round((double)activeUnit.vmethod_93().method_0()), Aircraft_AirOps.Enum44.const_0, false, false),
									")"
								}));
								break;
							}
						}
						goto IL_171;
					}
					finally
					{
						List<Class127>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					IL_E3:
					Class127 class2 = new Class127(string.Concat(new string[]
					{
						activeUnit.Name,
						"(",
						Misc.smethod_9(activeUnit.string_2),
						"): ",
						activeUnit.vmethod_93().method_10(),
						" (",
						Misc.smethod_11((long)Math.Round((double)activeUnit.vmethod_93().method_0()), Aircraft_AirOps.Enum44.const_0, false, false),
						")"
					}));
					class127_0.method_23().method_4(class2);
					class2.Tag = activeUnit;
					continue;
					IL_171:
					if (!flag)
					{
						goto IL_E3;
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
			List<Class127> list = new List<Class127>();
			try
			{
				foreach (Class127 class3 in class127_0.method_23())
				{
					if (!dockFacility_0.lazy_0.Value.Values.Contains((ActiveUnit)class3.Tag))
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

		// Token: 0x060075B9 RID: 30137 RVA: 0x003F7BF0 File Offset: 0x003F5DF0
		private void method_16(object sender, EventArgs e)
		{
			int selectedIndex = this.vmethod_0().SelectedIndex;
			if (selectedIndex == 0)
			{
				this.method_4();
				return;
			}
			if (selectedIndex != 1)
			{
				return;
			}
			this.method_12();
		}

		// Token: 0x060075BA RID: 30138 RVA: 0x00049047 File Offset: 0x00047247
		private void method_17(object sender, EventArgs e)
		{
			this.method_18();
		}

		// Token: 0x060075BB RID: 30139 RVA: 0x003F7C20 File Offset: 0x003F5E20
		private void method_18()
		{
			this.method_19(true, false);
			int count = this.list_1.Count;
			if (count != 0)
			{
				if (count == 1)
				{
					this.list_1[0].vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
				}
				else
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_1)
						{
							activeUnit.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
			this.method_8();
		}

		// Token: 0x060075BC RID: 30140 RVA: 0x003F7CB4 File Offset: 0x003F5EB4
		private void method_19(bool bool_4, bool bool_5)
		{
			this.list_1.Clear();
			try
			{
				foreach (Class48 @class in this.vmethod_12().method_2())
				{
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected)
							{
								this.list_1.Add((ActiveUnit)class2.Tag);
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
			if (bool_4)
			{
				List<ActiveUnit> list = new List<ActiveUnit>();
				try
				{
					foreach (ActiveUnit activeUnit in this.list_1)
					{
						if (activeUnit.vmethod_7(false) != Client.smethod_50())
						{
							list.Add(activeUnit);
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				if (list.Count > 0)
				{
					DarkMessageBox.smethod_1(Conversions.ToString(list.Count) + " of the selected boats are allied units not under your direct control.", "Allied boats selected!", Enum11.const_0);
					try
					{
						foreach (ActiveUnit item in list)
						{
							this.list_1.Remove(item);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
			}
			List<ActiveUnit> list2 = new List<ActiveUnit>();
			try
			{
				foreach (ActiveUnit activeUnit2 in this.list_1)
				{
					ActiveUnit activeUnit3 = activeUnit2;
					string text = null;
					if (!activeUnit3.vmethod_125(ref text))
					{
						list2.Add(activeUnit2);
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator5;
				((IDisposable)enumerator5).Dispose();
			}
			if (list2.Count > 0)
			{
				DarkMessageBox.smethod_1(Conversions.ToString(list2.Count) + " of the selected boats are unavailable for operations, and will not launch.", "Unavailable boats selected!", Enum11.const_0);
				try
				{
					foreach (ActiveUnit activeUnit4 in list2)
					{
						Aircraft item2 = (Aircraft)activeUnit4;
						this.list_1.Remove(item2);
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator6;
					((IDisposable)enumerator6).Dispose();
				}
			}
		}

		// Token: 0x060075BD RID: 30141 RVA: 0x0004904F File Offset: 0x0004724F
		private void method_20(object sender, EventArgs0 e)
		{
			if (e.method_0().method_8() == 1)
			{
				this.hashSet_0.Remove(e.method_0());
			}
		}

		// Token: 0x060075BE RID: 30142 RVA: 0x003F7F04 File Offset: 0x003F6104
		private void method_21(object sender, EventArgs1 e)
		{
			e.method_0().method_7().Clear();
			if (e.method_0().method_8() == 1)
			{
				string string_ = Enumerable.ElementAtOrDefault<ActiveUnit>((IEnumerable<ActiveUnit>)e.method_0().Tag, 0).string_2;
				this.hashSet_0.Add(e.method_0());
				IEnumerable<ActiveUnit> enumerable = Enumerable.OrderBy<ActiveUnit, string>(Enumerable.Select<ActiveUnit, ActiveUnit>((IEnumerable<ActiveUnit>)e.method_0().Tag, (DockingOps._Closure$__.$I191-0 == null) ? (DockingOps._Closure$__.$I191-0 = new Func<ActiveUnit, ActiveUnit>(DockingOps._Closure$__.$I.method_10)) : DockingOps._Closure$__.$I191-0), (DockingOps._Closure$__.$I191-1 == null) ? (DockingOps._Closure$__.$I191-1 = new Func<ActiveUnit, string>(DockingOps._Closure$__.$I.method_11)) : DockingOps._Closure$__.$I191-1);
				try
				{
					foreach (ActiveUnit activeUnit in enumerable)
					{
						string text;
						string text2;
						string text3;
						string text4;
						string text5;
						string text6;
						string text7;
						this.method_23(activeUnit, ref text, ref text2, ref text3, ref text4, ref text5, ref text6, ref text7);
						Class48 @class = e.method_0().method_7().method_1(new object[]
						{
							activeUnit.Name,
							text,
							text2,
							text3,
							text4,
							text5,
							text6,
							text7
						});
						@class.DefaultCellStyle.ForeColor = Color.LightGray;
						@class.DefaultCellStyle.Font = new Font(this.Font, FontStyle.Regular);
						@class.Tag = activeUnit;
						this.method_22(ref @class, activeUnit);
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

		// Token: 0x060075BF RID: 30143 RVA: 0x003F8098 File Offset: 0x003F6298
		private void method_22(ref Class48 class48_0, ActiveUnit activeUnit_0)
		{
			if (activeUnit_0.vmethod_86().method_78())
			{
				((DataGridViewLinkCell)class48_0.Cells[1]).LinkColor = Color.LightGreen;
			}
			else
			{
				((DataGridViewLinkCell)class48_0.Cells[1]).LinkColor = Color.PaleVioletRed;
			}
			if (activeUnit_0.vmethod_86().method_80() && activeUnit_0.vmethod_86().method_81())
			{
				((DataGridViewLinkCell)class48_0.Cells[2]).LinkColor = Color.LightGreen;
				((DataGridViewLinkCell)class48_0.Cells[3]).LinkColor = Color.LightGreen;
			}
			else
			{
				((DataGridViewLinkCell)class48_0.Cells[2]).LinkColor = Color.PaleVioletRed;
				((DataGridViewLinkCell)class48_0.Cells[3]).LinkColor = Color.PaleVioletRed;
			}
			if (activeUnit_0.vmethod_86().method_79())
			{
				class48_0.Cells[4].Style.ForeColor = Color.LightGreen;
				return;
			}
			class48_0.Cells[4].Style.ForeColor = Color.PaleVioletRed;
		}

		// Token: 0x060075C0 RID: 30144 RVA: 0x003F81C0 File Offset: 0x003F63C0
		private void method_23(ActiveUnit activeUnit_0, ref string string_0, ref string string_1, ref string string_2, ref string string_3, ref string string_4, ref string string_5, ref string string_6)
		{
			if (activeUnit_0.vmethod_91().method_0() > 0f)
			{
				string_0 = string.Format("{0:0.0}", activeUnit_0.vmethod_91().method_0(), 1) + "% damage, ";
			}
			else
			{
				string_0 = "No structural damage, ";
			}
			int count = activeUnit_0.vmethod_120().Count;
			int num = Enumerable.Count<PlatformComponent>(Enumerable.Where<PlatformComponent>(activeUnit_0.vmethod_120(), (DockingOps._Closure$__.$I193-0 == null) ? (DockingOps._Closure$__.$I193-0 = new Func<PlatformComponent, bool>(DockingOps._Closure$__.$I.method_12)) : DockingOps._Closure$__.$I193-0));
			if (num > 0)
			{
				string_0 = string_0 + Conversions.ToString(num) + " systems offline";
			}
			else
			{
				string_0 += "all systems online";
			}
			List<WeaponRec> list = new List<WeaponRec>();
			List<WeaponRec> list2 = new List<WeaponRec>();
			List<WeaponRec> list3 = new List<WeaponRec>();
			try
			{
				foreach (Mount mount in activeUnit_0.vmethod_51())
				{
					try
					{
						foreach (WeaponRec weaponRec in mount.vmethod_10())
						{
							Weapon._WeaponType weaponType = weaponRec.method_12(Client.smethod_46()).method_167();
							switch (weaponType)
							{
							case Weapon._WeaponType.GuidedWeapon:
								break;
							case Weapon._WeaponType.Rocket:
							case Weapon._WeaponType.IronBomb:
							case Weapon._WeaponType.Gun:
							case Weapon._WeaponType.Dispenser:
								goto IL_1A3;
							case Weapon._WeaponType.Decoy_Expendable:
							case Weapon._WeaponType.Decoy_Towed:
							case Weapon._WeaponType.Decoy_Vehicle:
							case Weapon._WeaponType.TrainingRound:
								goto IL_198;
							default:
								switch (weaponType)
								{
								case Weapon._WeaponType.Torpedo:
									break;
								case Weapon._WeaponType.DepthCharge:
								case Weapon._WeaponType.BottomMine:
								case Weapon._WeaponType.FloatingMine:
								case Weapon._WeaponType.MovingMine:
								case Weapon._WeaponType.RisingMine:
								case Weapon._WeaponType.DriftingMine:
								case Weapon._WeaponType.DummyMine:
									goto IL_1A3;
								case Weapon._WeaponType.Sonobuoy:
								case Weapon._WeaponType.MooredMine:
								case (Weapon._WeaponType)4010:
									goto IL_198;
								default:
									goto IL_198;
								}
								break;
							}
							list.Add(weaponRec);
							continue;
							IL_198:
							list3.Add(weaponRec);
							continue;
							IL_1A3:
							list2.Add(weaponRec);
						}
					}
					finally
					{
						List<WeaponRec>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					if (!Information.IsNothing(mount.method_32()))
					{
						try
						{
							foreach (WeaponRec weaponRec2 in mount.method_32().vmethod_10())
							{
								Weapon._WeaponType weaponType2 = weaponRec2.method_12(Client.smethod_46()).method_167();
								switch (weaponType2)
								{
								case Weapon._WeaponType.GuidedWeapon:
									break;
								case Weapon._WeaponType.Rocket:
								case Weapon._WeaponType.IronBomb:
								case Weapon._WeaponType.Gun:
								case Weapon._WeaponType.Dispenser:
									goto IL_28F;
								case Weapon._WeaponType.Decoy_Expendable:
								case Weapon._WeaponType.Decoy_Towed:
								case Weapon._WeaponType.Decoy_Vehicle:
								case Weapon._WeaponType.TrainingRound:
									goto IL_284;
								default:
									switch (weaponType2)
									{
									case Weapon._WeaponType.Torpedo:
										break;
									case Weapon._WeaponType.DepthCharge:
									case Weapon._WeaponType.BottomMine:
									case Weapon._WeaponType.FloatingMine:
									case Weapon._WeaponType.MovingMine:
									case Weapon._WeaponType.RisingMine:
									case Weapon._WeaponType.DriftingMine:
									case Weapon._WeaponType.DummyMine:
										goto IL_28F;
									case Weapon._WeaponType.Sonobuoy:
									case Weapon._WeaponType.MooredMine:
									case (Weapon._WeaponType)4010:
										goto IL_284;
									default:
										goto IL_284;
									}
									break;
								}
								list.Add(weaponRec2);
								continue;
								IL_284:
								list3.Add(weaponRec2);
								continue;
								IL_28F:
								list2.Add(weaponRec2);
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
					}
				}
			}
			finally
			{
				List<Mount>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			List<string> list4 = new List<string>();
			if (list.Count > 0)
			{
				string item = "Guided: " + Conversions.ToString(Enumerable.Sum(Enumerable.Select<WeaponRec, int>(list, (DockingOps._Closure$__.$I193-1 == null) ? (DockingOps._Closure$__.$I193-1 = new Func<WeaponRec, int>(DockingOps._Closure$__.$I.method_13)) : DockingOps._Closure$__.$I193-1))) + "/" + Conversions.ToString(Enumerable.Sum(Enumerable.Select<WeaponRec, int>(list, (DockingOps._Closure$__.$I193-2 == null) ? (DockingOps._Closure$__.$I193-2 = new Func<WeaponRec, int>(DockingOps._Closure$__.$I.method_14)) : DockingOps._Closure$__.$I193-2)));
				list4.Add(item);
			}
			if (list2.Count > 0)
			{
				string item2 = "Unguided: " + Conversions.ToString(Enumerable.Sum(Enumerable.Select<WeaponRec, int>(list2, (DockingOps._Closure$__.$I193-3 == null) ? (DockingOps._Closure$__.$I193-3 = new Func<WeaponRec, int>(DockingOps._Closure$__.$I.method_15)) : DockingOps._Closure$__.$I193-3))) + "/" + Conversions.ToString(Enumerable.Sum(Enumerable.Select<WeaponRec, int>(list2, (DockingOps._Closure$__.$I193-4 == null) ? (DockingOps._Closure$__.$I193-4 = new Func<WeaponRec, int>(DockingOps._Closure$__.$I.method_16)) : DockingOps._Closure$__.$I193-4)));
				list4.Add(item2);
			}
			if (list3.Count > 0)
			{
				string item3 = "Other: " + Conversions.ToString(Enumerable.Sum(Enumerable.Select<WeaponRec, int>(list3, (DockingOps._Closure$__.$I193-5 == null) ? (DockingOps._Closure$__.$I193-5 = new Func<WeaponRec, int>(DockingOps._Closure$__.$I.method_17)) : DockingOps._Closure$__.$I193-5))) + "/" + Conversions.ToString(Enumerable.Sum(Enumerable.Select<WeaponRec, int>(list3, (DockingOps._Closure$__.$I193-6 == null) ? (DockingOps._Closure$__.$I193-6 = new Func<WeaponRec, int>(DockingOps._Closure$__.$I.method_18)) : DockingOps._Closure$__.$I193-6)));
				list4.Add(item3);
			}
			string_1 = string.Join("\r\n", list4);
			list.Clear();
			list2.Clear();
			list3.Clear();
			list4.Clear();
			foreach (Magazine magazine in activeUnit_0.method_91())
			{
				try
				{
					foreach (WeaponRec weaponRec3 in magazine.vmethod_10())
					{
						Weapon._WeaponType weaponType3 = weaponRec3.method_12(Client.smethod_46()).method_167();
						switch (weaponType3)
						{
						case Weapon._WeaponType.GuidedWeapon:
							break;
						case Weapon._WeaponType.Rocket:
						case Weapon._WeaponType.IronBomb:
						case Weapon._WeaponType.Gun:
						case Weapon._WeaponType.Dispenser:
							goto IL_576;
						case Weapon._WeaponType.Decoy_Expendable:
						case Weapon._WeaponType.Decoy_Towed:
						case Weapon._WeaponType.Decoy_Vehicle:
						case Weapon._WeaponType.TrainingRound:
							goto IL_56B;
						default:
							switch (weaponType3)
							{
							case Weapon._WeaponType.Torpedo:
								break;
							case Weapon._WeaponType.DepthCharge:
							case Weapon._WeaponType.BottomMine:
							case Weapon._WeaponType.FloatingMine:
							case Weapon._WeaponType.MovingMine:
							case Weapon._WeaponType.RisingMine:
							case Weapon._WeaponType.DriftingMine:
							case Weapon._WeaponType.DummyMine:
								goto IL_576;
							case Weapon._WeaponType.Sonobuoy:
							case Weapon._WeaponType.MooredMine:
							case (Weapon._WeaponType)4010:
								goto IL_56B;
							default:
								goto IL_56B;
							}
							break;
						}
						list.Add(weaponRec3);
						continue;
						IL_56B:
						list3.Add(weaponRec3);
						continue;
						IL_576:
						list2.Add(weaponRec3);
					}
				}
				finally
				{
					List<WeaponRec>.Enumerator enumerator4;
					((IDisposable)enumerator4).Dispose();
				}
			}
			if (list.Count > 0)
			{
				string item = "Guided: " + Conversions.ToString(Enumerable.Sum(Enumerable.Select<WeaponRec, int>(list, (DockingOps._Closure$__.$I193-7 == null) ? (DockingOps._Closure$__.$I193-7 = new Func<WeaponRec, int>(DockingOps._Closure$__.$I.method_19)) : DockingOps._Closure$__.$I193-7))) + "/" + Conversions.ToString(Enumerable.Sum(Enumerable.Select<WeaponRec, int>(list, (DockingOps._Closure$__.$I193-8 == null) ? (DockingOps._Closure$__.$I193-8 = new Func<WeaponRec, int>(DockingOps._Closure$__.$I.method_20)) : DockingOps._Closure$__.$I193-8)));
				list4.Add(item);
			}
			if (list2.Count > 0)
			{
				string item2 = "Unguided: " + Conversions.ToString(Enumerable.Sum(Enumerable.Select<WeaponRec, int>(list2, (DockingOps._Closure$__.$I193-9 == null) ? (DockingOps._Closure$__.$I193-9 = new Func<WeaponRec, int>(DockingOps._Closure$__.$I.method_21)) : DockingOps._Closure$__.$I193-9))) + "/" + Conversions.ToString(Enumerable.Sum(Enumerable.Select<WeaponRec, int>(list2, (DockingOps._Closure$__.$I193-10 == null) ? (DockingOps._Closure$__.$I193-10 = new Func<WeaponRec, int>(DockingOps._Closure$__.$I.method_22)) : DockingOps._Closure$__.$I193-10)));
				list4.Add(item2);
			}
			if (list3.Count > 0)
			{
				string item3 = "Other: " + Conversions.ToString(Enumerable.Sum(Enumerable.Select<WeaponRec, int>(list3, (DockingOps._Closure$__.$I193-11 == null) ? (DockingOps._Closure$__.$I193-11 = new Func<WeaponRec, int>(DockingOps._Closure$__.$I.method_23)) : DockingOps._Closure$__.$I193-11))) + "/" + Conversions.ToString(Enumerable.Sum(Enumerable.Select<WeaponRec, int>(list3, (DockingOps._Closure$__.$I193-12 == null) ? (DockingOps._Closure$__.$I193-12 = new Func<WeaponRec, int>(DockingOps._Closure$__.$I.method_24)) : DockingOps._Closure$__.$I193-12)));
				list4.Add(item3);
			}
			string_2 = string.Join("\r\n", list4);
			string format = "{0:0.0}";
			double num2 = 0.0;
			double num3 = 0.0;
			string_3 = string.Format(format, activeUnit_0.vmethod_119(ref num2, ref num3, false) * 100.0, 1) + "%";
			if (Information.IsNothing(activeUnit_0.vmethod_101()))
			{
				string_4 = "-";
			}
			else
			{
				string text = "";
				if (activeUnit_0.vmethod_86().bool_2)
				{
					text = ", Escort";
				}
				string_4 = string.Concat(new string[]
				{
					activeUnit_0.vmethod_101().Name,
					" (",
					activeUnit_0.vmethod_101().vmethod_5(Client.smethod_46()),
					text,
					")"
				});
			}
			string_5 = activeUnit_0.vmethod_93().method_10();
			string_6 = Misc.smethod_11((long)Math.Round((double)activeUnit_0.vmethod_93().method_0()), Aircraft_AirOps.Enum44.const_0, false, false);
		}

		// Token: 0x060075C1 RID: 30145 RVA: 0x00049071 File Offset: 0x00047271
		private void method_24(object sender, EventArgs e)
		{
			this.method_25();
		}

		// Token: 0x060075C2 RID: 30146 RVA: 0x003F8A88 File Offset: 0x003F6C88
		private void method_25()
		{
			this.method_19(true, true);
			Misc.smethod_58(this.list_1, Client.smethod_46(), Client.smethod_50(), null);
			int count = this.list_1.Count;
			if (count != 0)
			{
				if (count == 1)
				{
					this.list_1[0].vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
				}
				else
				{
					try
					{
						foreach (ActiveUnit activeUnit in this.list_1)
						{
							activeUnit.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
			this.method_8();
		}

		// Token: 0x060075C3 RID: 30147 RVA: 0x003F8B30 File Offset: 0x003F6D30
		private void method_26(object sender, EventArgs e)
		{
			this.list_1.Clear();
			try
			{
				foreach (Class48 @class in this.vmethod_12().method_2())
				{
					bool selected = @class.Selected;
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected)
							{
								if (((ActiveUnit)class2.Tag).bool_6)
								{
									this.list_1.Add((Ship)class2.Tag);
								}
								else if (((ActiveUnit)class2.Tag).bool_5)
								{
									this.list_1.Add((Submarine)class2.Tag);
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
				IEnumerator<Class48> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			if (this.list_1.Count > 0)
			{
				this.vmethod_6().Enabled = true;
				this.vmethod_58().Enabled = false;
				try
				{
					List<ActiveUnit>.Enumerator enumerator3 = this.list_1.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						if (((Interface3)enumerator3.Current).imethod_2() != CargoType.NoCargo)
						{
							this.vmethod_58().Enabled = true;
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				this.vmethod_8().Enabled = true;
				this.vmethod_20().Enabled = true;
				this.vmethod_24().Enabled = true;
				this.vmethod_26().Enabled = true;
				if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
				{
					this.vmethod_44().Enabled = true;
					this.vmethod_46().Enabled = true;
					this.vmethod_48().Enabled = true;
					return;
				}
			}
			else
			{
				this.vmethod_6().Enabled = false;
				this.vmethod_58().Enabled = false;
				this.vmethod_8().Enabled = false;
				this.vmethod_20().Enabled = false;
				this.vmethod_24().Enabled = false;
				this.vmethod_26().Enabled = false;
				if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
				{
					this.vmethod_44().Enabled = false;
					this.vmethod_46().Enabled = false;
					this.vmethod_48().Enabled = false;
				}
			}
		}

		// Token: 0x060075C4 RID: 30148 RVA: 0x00049079 File Offset: 0x00047279
		private void method_27(object sender, DoWorkEventArgs e)
		{
			Thread.Sleep(10);
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x00049082 File Offset: 0x00047282
		private void method_28(object sender, RunWorkerCompletedEventArgs e)
		{
			this.method_11();
		}

		// Token: 0x060075C6 RID: 30150 RVA: 0x003F8D7C File Offset: 0x003F6F7C
		private void DockingOps_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F7 && base.Visible)
			{
				base.Close();
				return;
			}
			if (!base.Visible || (e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Add && e.KeyCode != Keys.Subtract && e.KeyCode != Keys.End && e.KeyCode != Keys.Home))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x0004908A File Offset: 0x0004728A
		private void DockingOps_FormClosed(object sender, FormClosedEventArgs e)
		{
			ActiveUnit_DockingOps.smethod_3(new ActiveUnit_DockingOps.Delegate18(this.method_5));
			ActiveUnit_DockingOps.smethod_1(new ActiveUnit_DockingOps.Delegate17(this.method_3));
		}

		// Token: 0x060075C8 RID: 30152 RVA: 0x000490AE File Offset: 0x000472AE
		private void method_29(object sender, EventArgs e)
		{
			this.method_30();
		}

		// Token: 0x060075C9 RID: 30153 RVA: 0x003F8E40 File Offset: 0x003F7040
		private void method_30()
		{
			this.method_19(true, false);
			try
			{
				foreach (ActiveUnit activeUnit in this.list_1)
				{
					if (activeUnit.vmethod_93().method_51())
					{
						activeUnit.vmethod_93().method_48(activeUnit.vmethod_93().method_17(), true);
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.method_8();
		}

		// Token: 0x060075CA RID: 30154 RVA: 0x003F8EC0 File Offset: 0x003F70C0
		private void method_31()
		{
			this.list_1.Clear();
			try
			{
				foreach (Class48 @class in this.vmethod_12().method_2())
				{
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected)
							{
								this.list_1.Add((ActiveUnit)class2.Tag);
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
			this.vmethod_26().DropDownItems.Clear();
			if (this.list_1.Count > 0)
			{
				new ToolStripMenuItem();
				((ToolStripMenuItem)this.vmethod_26().DropDown.Items.Add("< Unassign >", null, new EventHandler(this.method_33))).Tag = null;
				try
				{
					foreach (Mission mission in Client.smethod_50().method_35())
					{
						if (mission.enum88_0 != Mission.Enum88.const_2 && mission.enum88_0 != Mission.Enum88.const_1)
						{
							ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
							ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
							toolStripMenuItem = (ToolStripMenuItem)this.vmethod_26().DropDown.Items.Add(mission.Name, null, new EventHandler(this.method_33));
							toolStripMenuItem.Tag = mission;
							if (mission._MissionClass_0 == Mission._MissionClass.Strike)
							{
								toolStripMenuItem2 = (ToolStripMenuItem)this.vmethod_26().DropDown.Items.Add(mission.Name + " - Escort", null, new EventHandler(this.method_33));
								toolStripMenuItem2.Tag = mission;
							}
							if (this.list_1.Count == 1)
							{
								ActiveUnit activeUnit = this.list_1[0];
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

		// Token: 0x060075CB RID: 30155 RVA: 0x003F912C File Offset: 0x003F732C
		private void method_32(object sender, EventArgs e)
		{
			this.method_19(true, false);
			if (this.list_1.Count > 0)
			{
				MainForm mainForm = Class2413.smethod_2().method_41();
				Class310 class310_ = null;
				ReadOnlyCollection<Unit> readOnlyCollection = null;
				mainForm.method_308(class310_, ref readOnlyCollection, ref this.list_1, false);
			}
		}

		// Token: 0x060075CC RID: 30156 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_33(object sender, EventArgs e)
		{
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x000490B6 File Offset: 0x000472B6
		private void method_34(object sender, EventArgs e)
		{
			this.method_31();
		}

		// Token: 0x060075CE RID: 30158 RVA: 0x000490BE File Offset: 0x000472BE
		private void method_35(object sender, ToolStripItemClickedEventArgs e)
		{
			this.method_36(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x060075CF RID: 30159 RVA: 0x003F916C File Offset: 0x003F736C
		private void method_36(object sender, ToolStripItemClickedEventArgs e)
		{
			this.method_19(true, false);
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(e.ClickedItem.Tag)))
			{
				try
				{
					foreach (ActiveUnit activeUnit in this.list_1)
					{
						Class2413.smethod_2().method_41().method_399(ref activeUnit);
					}
					goto IL_9F;
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			Mission mission = (Mission)e.ClickedItem.Tag;
			bool flag = Strings.InStr(e.ClickedItem.Text, " - Escort", CompareMethod.Binary) != 0;
			Client.smethod_55(RuntimeHelpers.GetObjectValue(sender), this.list_1, ref mission, ref flag);
			IL_9F:
			this.imethod_0();
		}

		// Token: 0x060075D0 RID: 30160 RVA: 0x00049047 File Offset: 0x00047247
		private void method_37(object sender, EventArgs e)
		{
			this.method_18();
		}

		// Token: 0x060075D1 RID: 30161 RVA: 0x00049071 File Offset: 0x00047271
		private void method_38(object sender, EventArgs e)
		{
			this.method_25();
		}

		// Token: 0x060075D2 RID: 30162 RVA: 0x000490AE File Offset: 0x000472AE
		private void method_39(object sender, EventArgs e)
		{
			this.method_30();
		}

		// Token: 0x060075D3 RID: 30163 RVA: 0x003F912C File Offset: 0x003F732C
		private void method_40(object sender, EventArgs e)
		{
			this.method_19(true, false);
			if (this.list_1.Count > 0)
			{
				MainForm mainForm = Class2413.smethod_2().method_41();
				Class310 class310_ = null;
				ReadOnlyCollection<Unit> readOnlyCollection = null;
				mainForm.method_308(class310_, ref readOnlyCollection, ref this.list_1, false);
			}
		}

		// Token: 0x060075D4 RID: 30164 RVA: 0x0000378C File Offset: 0x0000198C
		private void method_41(object sender, EventArgs e)
		{
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x003F9230 File Offset: 0x003F7430
		private void method_42()
		{
			if (this.list_1.Count > 0)
			{
				this.vmethod_30().Enabled = true;
				this.vmethod_32().Enabled = true;
				this.vmethod_34().Enabled = true;
				this.vmethod_38().Enabled = true;
				this.vmethod_40().Enabled = true;
			}
			else
			{
				this.vmethod_30().Enabled = false;
				this.vmethod_32().Enabled = false;
				this.vmethod_34().Enabled = false;
				this.vmethod_38().Enabled = false;
				this.vmethod_40().Enabled = false;
			}
			this.list_1.Clear();
			try
			{
				foreach (Class48 @class in this.vmethod_12().method_2())
				{
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected)
							{
								this.list_1.Add((ActiveUnit)class2.Tag);
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
			this.vmethod_40().DropDownItems.Clear();
			if (this.list_1.Count > 0)
			{
				new ToolStripMenuItem();
				((ToolStripMenuItem)this.vmethod_40().DropDown.Items.Add("< Unassign >", null, new EventHandler(this.method_41))).Tag = null;
				try
				{
					foreach (Mission mission in Client.smethod_50().method_35())
					{
						if (mission.enum88_0 != Mission.Enum88.const_2 && mission.enum88_0 != Mission.Enum88.const_1)
						{
							ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
							ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
							toolStripMenuItem = (ToolStripMenuItem)this.vmethod_40().DropDown.Items.Add(mission.Name, null, new EventHandler(this.method_41));
							toolStripMenuItem.Tag = mission;
							if (mission._MissionClass_0 == Mission._MissionClass.Strike)
							{
								toolStripMenuItem2 = (ToolStripMenuItem)this.vmethod_40().DropDown.Items.Add(mission.Name + " - Escort", null, new EventHandler(this.method_41));
								toolStripMenuItem2.Tag = mission;
							}
							if (this.list_1.Count == 1)
							{
								ActiveUnit activeUnit = this.list_1[0];
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

		// Token: 0x060075D6 RID: 30166 RVA: 0x000490CD File Offset: 0x000472CD
		private void method_43(object sender, CancelEventArgs e)
		{
			this.method_42();
		}

		// Token: 0x060075D7 RID: 30167 RVA: 0x000490BE File Offset: 0x000472BE
		private void method_44(object sender, ToolStripItemClickedEventArgs e)
		{
			this.method_36(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x060075D8 RID: 30168 RVA: 0x003F9524 File Offset: 0x003F7724
		private void method_45(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				Class48 @class = this.vmethod_12().method_5();
				if (!Information.IsNothing(@class))
				{
					if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(@class.Tag)))
					{
						string name = this.vmethod_12().Columns[e.ColumnIndex].Name;
						if (Operators.CompareString(name, "Boat", false) != 0)
						{
							if (Operators.CompareString(name, "Damage", false) != 0)
							{
								if (Operators.CompareString(name, "Weapons", false) != 0)
								{
									if (Operators.CompareString(name, "Magazines", false) == 0)
									{
										ActiveUnit activeUnit = (ActiveUnit)@class.Tag;
										if (!Information.IsNothing(activeUnit))
										{
											Client.magazines_0 = new Magazines();
											Client.magazines_0.activeUnit_0 = activeUnit;
											Client.magazines_0.Show();
										}
									}
								}
								else
								{
									ActiveUnit activeUnit2 = (ActiveUnit)@class.Tag;
									if (!Information.IsNothing(activeUnit2))
									{
										Client.smethod_33().method_3(activeUnit2);
										Client.smethod_33().Show();
									}
								}
							}
							else
							{
								ActiveUnit activeUnit_ = (ActiveUnit)@class.Tag;
								Client.damageControlWindow_0 = new DamageControlWindow();
								Client.damageControlWindow_0.activeUnit_0 = activeUnit_;
								Client.damageControlWindow_0.class279_0 = Client.smethod_0();
								Client.damageControlWindow_0.Show();
							}
						}
						else
						{
							try
							{
								if (@class.Tag.GetType() != typeof(Ship))
								{
									if (@class.Tag.GetType() != typeof(Submarine))
									{
										try
										{
											ActiveUnit activeUnit3 = (ActiveUnit)@class.Tag;
										}
										catch (Exception ex)
										{
											ActiveUnit activeUnit3 = Enumerable.ElementAtOrDefault<ActiveUnit>((IEnumerable<ActiveUnit>)@class.Tag, 0);
											int dbid = activeUnit3.DBID;
											if (activeUnit3.bool_6)
											{
												Client.smethod_63("Ship", dbid, null);
											}
											else if (activeUnit3.bool_5)
											{
												Client.smethod_63("Submarine", dbid, null);
											}
										}
									}
								}
							}
							catch (Exception ex2)
							{
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 200379", ex3.Message);
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060075D9 RID: 30169 RVA: 0x000490D5 File Offset: 0x000472D5
		private void method_46(object sender, EventArgs e)
		{
			this.method_47();
		}

		// Token: 0x060075DA RID: 30170 RVA: 0x003F97A0 File Offset: 0x003F79A0
		private void method_47()
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			try
			{
				foreach (Class48 @class in this.vmethod_12().method_2())
				{
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected)
							{
								list.Add((ActiveUnit)class2.Tag);
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

		// Token: 0x060075DB RID: 30171 RVA: 0x000490DD File Offset: 0x000472DD
		private void method_48(object sender, EventArgs e)
		{
			this.method_49();
		}

		// Token: 0x060075DC RID: 30172 RVA: 0x003F9864 File Offset: 0x003F7A64
		private void method_49()
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			try
			{
				foreach (Class48 @class in this.vmethod_12().method_2())
				{
					try
					{
						foreach (Class48 class2 in @class.method_7())
						{
							if (class2.Selected)
							{
								list.Add((ActiveUnit)class2.Tag);
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
				this.method_8();
				this.method_13();
			}
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x000490E5 File Offset: 0x000472E5
		private void method_50(object sender, EventArgs e)
		{
			this.method_51();
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x003F9964 File Offset: 0x003F7B64
		private void method_51()
		{
			List<Class48> list = new List<Class48>();
			try
			{
				foreach (Class48 @class in this.vmethod_12().method_2())
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
					ActiveUnit activeUnit = (ActiveUnit)class3.Tag;
					activeUnit.vmethod_93().method_15().lazy_0.Value.TryRemove(activeUnit.string_0, ref activeUnit);
					Client.smethod_46().method_66(activeUnit.string_0, true);
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
			this.method_11();
		}

		// Token: 0x060075DF RID: 30175 RVA: 0x000490D5 File Offset: 0x000472D5
		private void method_52(object sender, EventArgs e)
		{
			this.method_47();
		}

		// Token: 0x060075E0 RID: 30176 RVA: 0x000490DD File Offset: 0x000472DD
		private void method_53(object sender, EventArgs e)
		{
			this.method_49();
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x000490E5 File Offset: 0x000472E5
		private void method_54(object sender, EventArgs e)
		{
			this.method_51();
		}

		// Token: 0x060075E2 RID: 30178 RVA: 0x003F9AC4 File Offset: 0x003F7CC4
		private void method_55(object sender, EventArgs e)
		{
			this.method_19(true, false);
			int count = this.list_1.Count;
			if (count != 0)
			{
				if (count == 1)
				{
					ActiveUnit activeUnit = this.list_1[0];
					Class2413.smethod_2().method_12().activeUnit_0 = activeUnit.vmethod_93().method_15().method_18();
					Class2413.smethod_2().method_12().activeUnit_1 = activeUnit;
					Class2413.smethod_2().method_12().Show();
				}
				else
				{
					DarkMessageBox.smethod_2("Select one docked ship only.", "", Enum11.const_0);
				}
			}
			this.method_8();
		}

		// Token: 0x040041E0 RID: 16864
		[AccessedThroughProperty("TabControl1")]
		[CompilerGenerated]
		private Control12 control12_0;

		// Token: 0x040041E1 RID: 16865
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage1")]
		private TabPage tabPage_0;

		// Token: 0x040041E2 RID: 16866
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStrip1")]
		private Class125 class125_0;

		// Token: 0x040041E3 RID: 16867
		[AccessedThroughProperty("ToolStripButton1")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x040041E4 RID: 16868
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripButton3")]
		private ToolStripButton toolStripButton_1;

		// Token: 0x040041E5 RID: 16869
		[AccessedThroughProperty("SplitContainer1")]
		[CompilerGenerated]
		private SplitContainer splitContainer_0;

		// Token: 0x040041E6 RID: 16870
		[AccessedThroughProperty("TGV_Boats")]
		[CompilerGenerated]
		private Class50 class50_0;

		// Token: 0x040041E7 RID: 16871
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage2")]
		private TabPage tabPage_1;

		// Token: 0x040041E8 RID: 16872
		[CompilerGenerated]
		[AccessedThroughProperty("TV_Facilities")]
		private Control6 control6_0;

		// Token: 0x040041E9 RID: 16873
		[CompilerGenerated]
		[AccessedThroughProperty("Timer1")]
		private Timer timer_0;

		// Token: 0x040041EA RID: 16874
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_AbortLaunch")]
		private ToolStripButton toolStripButton_2;

		// Token: 0x040041EB RID: 16875
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x040041EC RID: 16876
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_Doctrine")]
		private ToolStripButton toolStripButton_3;

		// Token: 0x040041ED RID: 16877
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_AssignToMission")]
		private ToolStripDropDownButton toolStripDropDownButton_0;

		// Token: 0x040041EE RID: 16878
		[AccessedThroughProperty("CMenu_BoatOps")]
		[CompilerGenerated]
		private Class113 class113_0;

		// Token: 0x040041EF RID: 16879
		[AccessedThroughProperty("LaunchIndividuallyToolStripMenuItem")]
		[CompilerGenerated]
		private Class128 class128_0;

		// Token: 0x040041F0 RID: 16880
		[AccessedThroughProperty("LaunchAsGroupsToolStripMenuItem")]
		[CompilerGenerated]
		private Class128 class128_1;

		// Token: 0x040041F1 RID: 16881
		[CompilerGenerated]
		[AccessedThroughProperty("AbortLaunchToolStripMenuItem")]
		private Class128 class128_2;

		// Token: 0x040041F2 RID: 16882
		[AccessedThroughProperty("ToolStripSeparator2")]
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_1;

		// Token: 0x040041F3 RID: 16883
		[AccessedThroughProperty("DoctrineToolStripMenuItem")]
		[CompilerGenerated]
		private Class128 class128_3;

		// Token: 0x040041F4 RID: 16884
		[CompilerGenerated]
		[AccessedThroughProperty("AssignToMissionToolStripMenuItem")]
		private Class128 class128_4;

		// Token: 0x040041F5 RID: 16885
		[AccessedThroughProperty("ToolStripSeparator3")]
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_2;

		// Token: 0x040041F6 RID: 16886
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_SetReadyTime")]
		private ToolStripButton toolStripButton_4;

		// Token: 0x040041F7 RID: 16887
		[AccessedThroughProperty("TSB_Rename")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_5;

		// Token: 0x040041F8 RID: 16888
		[AccessedThroughProperty("TSB_Delete")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_6;

		// Token: 0x040041F9 RID: 16889
		[AccessedThroughProperty("ToolStripSeparator4")]
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_3;

		// Token: 0x040041FA RID: 16890
		[CompilerGenerated]
		[AccessedThroughProperty("SetTimeToReadyToolStripMenuItem")]
		private Class128 class128_5;

		// Token: 0x040041FB RID: 16891
		[CompilerGenerated]
		[AccessedThroughProperty("RenameToolStripMenuItem")]
		private Class128 class128_6;

		// Token: 0x040041FC RID: 16892
		[CompilerGenerated]
		[AccessedThroughProperty("RemoveToolStripMenuItem")]
		private Class128 class128_7;

		// Token: 0x040041FD RID: 16893
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_Cargo")]
		private ToolStripButton toolStripButton_7;

		// Token: 0x040041FE RID: 16894
		[CompilerGenerated]
		[AccessedThroughProperty("Boat")]
		private Class44 class44_0;

		// Token: 0x040041FF RID: 16895
		[AccessedThroughProperty("Damage")]
		[CompilerGenerated]
		private DataGridViewLinkColumn dataGridViewLinkColumn_0;

		// Token: 0x04004200 RID: 16896
		[AccessedThroughProperty("Weapons")]
		[CompilerGenerated]
		private DataGridViewLinkColumn dataGridViewLinkColumn_1;

		// Token: 0x04004201 RID: 16897
		[AccessedThroughProperty("Magazines")]
		[CompilerGenerated]
		private DataGridViewLinkColumn dataGridViewLinkColumn_2;

		// Token: 0x04004202 RID: 16898
		[CompilerGenerated]
		[AccessedThroughProperty("Fuel")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04004203 RID: 16899
		[CompilerGenerated]
		[AccessedThroughProperty("Mission")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04004204 RID: 16900
		[AccessedThroughProperty("Status")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04004205 RID: 16901
		[AccessedThroughProperty("TimeToReady")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04004206 RID: 16902
		public List<ActiveUnit> list_0;

		// Token: 0x04004207 RID: 16903
		private List<ActiveUnit> list_1;

		// Token: 0x04004208 RID: 16904
		private List<ActiveUnit> list_2;

		// Token: 0x04004209 RID: 16905
		private List<ActiveUnit> list_3;

		// Token: 0x0400420A RID: 16906
		private Class2419 class2419_0;

		// Token: 0x0400420B RID: 16907
		private bool bool_3;

		// Token: 0x0400420C RID: 16908
		private HashSet<Class48> hashSet_0;

		// Token: 0x0400420D RID: 16909
		[AccessedThroughProperty("BW_TGV_Boats")]
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x02000EA0 RID: 3744
		[CompilerGenerated]
		internal sealed class Class2500
		{
			// Token: 0x060075E3 RID: 30179 RVA: 0x000490ED File Offset: 0x000472ED
			public Class2500(DockingOps.Class2500 class2500_0)
			{
				if (class2500_0 != null)
				{
					this.activeUnit_0 = class2500_0.activeUnit_0;
				}
			}

			// Token: 0x060075E4 RID: 30180 RVA: 0x00049104 File Offset: 0x00047304
			internal bool method_0(Class48 class48_0)
			{
				return class48_0.Tag == this.activeUnit_0;
			}

			// Token: 0x0400420E RID: 16910
			public ActiveUnit activeUnit_0;
		}

		// Token: 0x02000EA1 RID: 3745
		[CompilerGenerated]
		internal sealed class Class2501
		{
			// Token: 0x060075E5 RID: 30181 RVA: 0x00049114 File Offset: 0x00047314
			public Class2501(DockingOps.Class2501 class2501_0)
			{
				if (class2501_0 != null)
				{
					this.int_0 = class2501_0.int_0;
				}
			}

			// Token: 0x060075E6 RID: 30182 RVA: 0x0004912B File Offset: 0x0004732B
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.bool_6 & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x0400420F RID: 16911
			public int int_0;
		}

		// Token: 0x02000EA2 RID: 3746
		[CompilerGenerated]
		internal sealed class Class2502
		{
			// Token: 0x060075E7 RID: 30183 RVA: 0x00049142 File Offset: 0x00047342
			public Class2502(DockingOps.Class2502 class2502_0)
			{
				if (class2502_0 != null)
				{
					this.int_0 = class2502_0.int_0;
				}
			}

			// Token: 0x060075E8 RID: 30184 RVA: 0x00049159 File Offset: 0x00047359
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.bool_5 & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04004210 RID: 16912
			public int int_0;
		}
	}
}
