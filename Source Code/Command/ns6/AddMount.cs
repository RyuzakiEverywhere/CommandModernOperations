using System;
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
	// Token: 0x02000EFD RID: 3837
	[DesignerGenerated]
	internal sealed partial class AddMount : DarkSecondaryFormBase
	{
		// Token: 0x06008782 RID: 34690 RVA: 0x0048A68C File Offset: 0x0048888C
		public AddMount()
		{
			base.Load += this.AddMount_Load;
			base.KeyDown += this.AddMount_KeyDown;
			base.FormClosing += this.AddMount_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x06008784 RID: 34692 RVA: 0x0048A71C File Offset: 0x0048891C
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_1(new Class114());
			this.vmethod_15(new DataGridViewTextBoxColumn());
			this.vmethod_17(new DataGridViewTextBoxColumn());
			this.vmethod_3(new BackgroundWorker());
			this.vmethod_5(new Control9());
			this.vmethod_7(new Class112());
			this.vmethod_9(new Control8());
			this.vmethod_11(new PlatformComponentArcControl());
			this.vmethod_13(new Class116());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_0().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_0().CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.vmethod_0().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font(Client.font_1.FontFamily, 8f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_0().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_0().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_14(),
				this.vmethod_16()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().EnableHeadersVisualStyles = false;
			this.vmethod_0().Location = new Point(0, 110);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DataGridView1";
			this.vmethod_0().RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_0().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_0().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new Size(503, 404);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_14().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_14().DataPropertyName = "ID";
			this.vmethod_14().HeaderText = "ID";
			this.vmethod_14().Name = "ID";
			this.vmethod_14().ReadOnly = true;
			this.vmethod_14().Width = 41;
			this.vmethod_16().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_16().DataPropertyName = "Name";
			this.vmethod_16().HeaderText = "Name";
			this.vmethod_16().Name = "Description";
			this.vmethod_16().ReadOnly = true;
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(7, 5);
			this.vmethod_4().Name = "Button1";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(89, 23);
			this.vmethod_4().TabIndex = 3;
			this.vmethod_4().Text = "Add Selected";
			this.vmethod_6().AutoSize = true;
			this.vmethod_6().Location = new Point(7, 62);
			this.vmethod_6().Name = "CB_Filter1";
			this.vmethod_6().Size = new Size(108, 17);
			this.vmethod_6().TabIndex = 13;
			this.vmethod_6().Text = "Filter by keyword:";
			this.vmethod_8().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_8().method_14(null);
			this.vmethod_8().method_15(AutoCompleteMode.None);
			this.vmethod_8().method_13(AutoCompleteSource.None);
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().method_17(new Font(Client.font_1.FontFamily, 10f));
			this.vmethod_8().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_8().method_12(null);
			this.vmethod_8().method_18(null);
			this.vmethod_8().Location = new Point(7, 85);
			this.vmethod_8().method_2(32767);
			this.vmethod_8().method_7(false);
			this.vmethod_8().Name = "TB_Find";
			this.vmethod_8().method_3(false);
			this.vmethod_8().method_9(0);
			this.vmethod_8().Size = new Size(386, 20);
			this.vmethod_8().TabIndex = 12;
			this.vmethod_8().method_1(HorizontalAlignment.Left);
			this.vmethod_8().method_5(false);
			this.vmethod_8().method_10("");
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().Location = new Point(399, 4);
			this.vmethod_10().Name = "ArcControl1";
			this.vmethod_10().Size = new Size(103, 100);
			this.vmethod_10().TabIndex = 14;
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Location = new Point(179, 10);
			this.vmethod_12().Name = "Label3";
			this.vmethod_12().Size = new Size(226, 13);
			this.vmethod_12().TabIndex = 19;
			this.vmethod_12().Text = "Tips: Double-click to select or deselect all arcs";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(503, 514);
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AddMount";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Add Weapon Mount";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06008785 RID: 34693 RVA: 0x00051861 File Offset: 0x0004FA61
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x06008786 RID: 34694 RVA: 0x00051869 File Offset: 0x0004FA69
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class114 class114_1)
		{
			this.class114_0 = class114_1;
		}

		// Token: 0x06008787 RID: 34695 RVA: 0x00051872 File Offset: 0x0004FA72
		[CompilerGenerated]
		internal BackgroundWorker vmethod_2()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x06008788 RID: 34696 RVA: 0x0048AE9C File Offset: 0x0048909C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler doWorkEventHandler = new DoWorkEventHandler(this.method_4);
			RunWorkerCompletedEventHandler runWorkerCompletedEventHandler = new RunWorkerCompletedEventHandler(this.method_5);
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

		// Token: 0x06008789 RID: 34697 RVA: 0x0005187A File Offset: 0x0004FA7A
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_0;
		}

		// Token: 0x0600878A RID: 34698 RVA: 0x0048AEFC File Offset: 0x004890FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_1)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_1;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600878B RID: 34699 RVA: 0x00051882 File Offset: 0x0004FA82
		[CompilerGenerated]
		internal Class112 vmethod_6()
		{
			return this.class112_0;
		}

		// Token: 0x0600878C RID: 34700 RVA: 0x0005188A File Offset: 0x0004FA8A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class112 class112_1)
		{
			this.class112_0 = class112_1;
		}

		// Token: 0x0600878D RID: 34701 RVA: 0x00051893 File Offset: 0x0004FA93
		[CompilerGenerated]
		internal Control8 vmethod_8()
		{
			return this.control8_0;
		}

		// Token: 0x0600878E RID: 34702 RVA: 0x0048AF40 File Offset: 0x00489140
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control8 control8_1)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_6);
			EventHandler value = new EventHandler(this.method_9);
			EventHandler value2 = new EventHandler(this.method_10);
			Control8 control = this.control8_0;
			if (control != null)
			{
				control.method_22(delegate85_);
				control.Enter -= value;
				control.Leave -= value2;
			}
			this.control8_0 = control8_1;
			control = this.control8_0;
			if (control != null)
			{
				control.method_21(delegate85_);
				control.Enter += value;
				control.Leave += value2;
			}
		}

		// Token: 0x0600878F RID: 34703 RVA: 0x0005189B File Offset: 0x0004FA9B
		[CompilerGenerated]
		internal PlatformComponentArcControl vmethod_10()
		{
			return this.platformComponentArcControl_0;
		}

		// Token: 0x06008790 RID: 34704 RVA: 0x000518A3 File Offset: 0x0004FAA3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(PlatformComponentArcControl platformComponentArcControl_1)
		{
			this.platformComponentArcControl_0 = platformComponentArcControl_1;
		}

		// Token: 0x06008791 RID: 34705 RVA: 0x000518AC File Offset: 0x0004FAAC
		[CompilerGenerated]
		internal Class116 vmethod_12()
		{
			return this.class116_0;
		}

		// Token: 0x06008792 RID: 34706 RVA: 0x000518B4 File Offset: 0x0004FAB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x06008793 RID: 34707 RVA: 0x000518BD File Offset: 0x0004FABD
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_14()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06008794 RID: 34708 RVA: 0x000518C5 File Offset: 0x0004FAC5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06008795 RID: 34709 RVA: 0x000518CE File Offset: 0x0004FACE
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_16()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06008796 RID: 34710 RVA: 0x000518D6 File Offset: 0x0004FAD6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06008797 RID: 34711 RVA: 0x000518DF File Offset: 0x0004FADF
		private void AddMount_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_2().RunWorkerAsync();
		}

		// Token: 0x06008798 RID: 34712 RVA: 0x0048AFBC File Offset: 0x004891BC
		private void method_3(object sender, EventArgs e)
		{
			if (!Information.IsNothing(Client.smethod_54()) && Client.smethod_54().bool_0)
			{
				if (this.vmethod_10().method_1())
				{
					DarkMessageBox.smethod_2("You must select coverage arcs for this mount", "No coverage arcs selected!", Enum11.const_0);
					return;
				}
				int mountDBID = Conversions.ToInteger(this.vmethod_0().CurrentRow.Cells["ID"].Value);
				Scenario scenario = Client.smethod_46();
				Mount mount = DBFunctions.smethod_110(mountDBID, ref scenario, true);
				mount.class295_0 = this.vmethod_10().class295_0;
				((ActiveUnit)Client.smethod_54()).vmethod_51().method_4(mount);
				mount.method_19((ActiveUnit)Client.smethod_54());
				foreach (Sensor sensor in mount.method_36())
				{
					sensor.method_19((ActiveUnit)Client.smethod_54());
					sensor.class295_0 = mount.class295_0;
					sensor.class295_1 = mount.class295_0;
				}
			}
		}

		// Token: 0x06008799 RID: 34713 RVA: 0x0048B0B0 File Offset: 0x004892B0
		private void method_4(object sender, DoWorkEventArgs e)
		{
			SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
			this.dataTable_0 = DBFunctions.smethod_67(ref sqliteConnection);
		}

		// Token: 0x0600879A RID: 34714 RVA: 0x000518FF File Offset: 0x0004FAFF
		private void method_5(object sender, RunWorkerCompletedEventArgs e)
		{
			this.method_8();
		}

		// Token: 0x0600879B RID: 34715 RVA: 0x00051907 File Offset: 0x0004FB07
		private void method_6(object object_0)
		{
			if (this.vmethod_6().Checked & Operators.CompareString(this.vmethod_8().Text, "", false) != 0)
			{
				this.method_7();
			}
		}

		// Token: 0x0600879C RID: 34716 RVA: 0x0048B0D8 File Offset: 0x004892D8
		private void method_7()
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Name ASC";
			dataView.RowFilter = "Name LIKE '%" + this.vmethod_8().Text + "%'";
			this.vmethod_0().AutoGenerateColumns = false;
			this.vmethod_0().DataSource = dataView;
			this.vmethod_0().Refresh();
		}

		// Token: 0x0600879D RID: 34717 RVA: 0x00051936 File Offset: 0x0004FB36
		private void method_8()
		{
			this.dataView_0 = new DataView(this.dataTable_0);
			this.dataView_0.Sort = "Name ASC";
			this.vmethod_0().AutoGenerateColumns = false;
			this.vmethod_0().DataSource = this.dataView_0;
		}

		// Token: 0x0600879E RID: 34718 RVA: 0x0048B140 File Offset: 0x00489340
		private void AddMount_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (this.bool_3)
			{
				if (e.KeyValue == 13 && base.Visible)
				{
					this.vmethod_6().Select();
					return;
				}
				if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
				{
					Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
			if (!this.bool_3 && (e.KeyValue != 32 || !base.Visible))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x0600879F RID: 34719 RVA: 0x00051976 File Offset: 0x0004FB76
		private void method_9(object sender, EventArgs e)
		{
			this.bool_3 = true;
		}

		// Token: 0x060087A0 RID: 34720 RVA: 0x0005197F File Offset: 0x0004FB7F
		private void method_10(object sender, EventArgs e)
		{
			this.bool_3 = false;
			this.vmethod_6().Select();
		}

		// Token: 0x060087A1 RID: 34721 RVA: 0x00044820 File Offset: 0x00042A20
		private void AddMount_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x040049C5 RID: 18885
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridView1")]
		private Class114 class114_0;

		// Token: 0x040049C6 RID: 18886
		[AccessedThroughProperty("BW1")]
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x040049C7 RID: 18887
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x040049C8 RID: 18888
		[AccessedThroughProperty("CB_Filter1")]
		[CompilerGenerated]
		private Class112 class112_0;

		// Token: 0x040049C9 RID: 18889
		[AccessedThroughProperty("TB_Find")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x040049CA RID: 18890
		[AccessedThroughProperty("ArcControl1")]
		[CompilerGenerated]
		private PlatformComponentArcControl platformComponentArcControl_0;

		// Token: 0x040049CB RID: 18891
		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x040049CC RID: 18892
		[CompilerGenerated]
		[AccessedThroughProperty("ID")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x040049CD RID: 18893
		[AccessedThroughProperty("Description")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x040049CE RID: 18894
		private DataTable dataTable_0;

		// Token: 0x040049CF RID: 18895
		private DataView dataView_0;

		// Token: 0x040049D0 RID: 18896
		private bool bool_3;

		// Token: 0x040049D1 RID: 18897
		public Form form_0;
	}
}
