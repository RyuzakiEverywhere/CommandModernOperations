using System;
using System.Collections;
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
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns2;
using ns5;

namespace ns4
{
	// Token: 0x02000E44 RID: 3652
	[DesignerGenerated]
	internal sealed partial class AddMagazine : DarkSecondaryFormBase
	{
		// Token: 0x06006DD6 RID: 28118 RVA: 0x003BCF00 File Offset: 0x003BB100
		public AddMagazine()
		{
			base.Shown += this.AddMagazine_Shown;
			base.KeyDown += this.AddMagazine_KeyDown;
			base.FormClosing += this.AddMagazine_FormClosing;
			base.Load += this.AddMagazine_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x06006DD8 RID: 28120 RVA: 0x003BCFA4 File Offset: 0x003BB1A4
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_1(new Class114());
			this.vmethod_10(new DataGridViewTextBoxColumn());
			this.vmethod_12(new DataGridViewTextBoxColumn());
			this.vmethod_2(new BackgroundWorker());
			this.vmethod_4(new Control9());
			this.vmethod_6(new Control8());
			this.vmethod_8(new Class112());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_0().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_0().CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.vmethod_0().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_0().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_0().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_9(),
				this.vmethod_11()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().EnableHeadersVisualStyles = false;
			this.vmethod_0().Location = new Point(0, 71);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DataGridView1";
			this.vmethod_0().RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_0().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_0().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new Size(401, 435);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_9().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_9().DataPropertyName = "ID";
			this.vmethod_9().HeaderText = "ID";
			this.vmethod_9().Name = "ID";
			this.vmethod_9().ReadOnly = true;
			this.vmethod_9().Width = 41;
			this.vmethod_11().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_11().DataPropertyName = "Description";
			this.vmethod_11().HeaderText = "Description";
			this.vmethod_11().Name = "Description";
			this.vmethod_11().ReadOnly = true;
			this.vmethod_3().BackColor = Color.Transparent;
			this.vmethod_3().DialogResult = DialogResult.None;
			this.vmethod_3().Font = new Font("Segoe UI", 10f);
			this.vmethod_3().ForeColor = SystemColors.Control;
			this.vmethod_3().Location = new Point(7, 12);
			this.vmethod_3().Name = "Button1";
			this.vmethod_3().method_1(0);
			this.vmethod_3().Size = new Size(89, 23);
			this.vmethod_3().TabIndex = 3;
			this.vmethod_3().Text = "Add Selected";
			this.vmethod_5().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_5().method_14(null);
			this.vmethod_5().method_15(AutoCompleteMode.None);
			this.vmethod_5().method_13(AutoCompleteSource.None);
			this.vmethod_5().BackColor = Color.Transparent;
			this.vmethod_5().method_17(new Font("Segoe UI", 10f));
			this.vmethod_5().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_5().method_12(null);
			this.vmethod_5().method_18(null);
			this.vmethod_5().Location = new Point(132, 45);
			this.vmethod_5().method_2(32767);
			this.vmethod_5().method_7(false);
			this.vmethod_5().Name = "TB_Find";
			this.vmethod_5().method_3(false);
			this.vmethod_5().method_9(0);
			this.vmethod_5().Size = new Size(269, 20);
			this.vmethod_5().TabIndex = 12;
			this.vmethod_5().method_1(HorizontalAlignment.Left);
			this.vmethod_5().method_5(false);
			this.vmethod_5().method_10("");
			this.vmethod_7().AutoSize = true;
			this.vmethod_7().Location = new Point(7, 47);
			this.vmethod_7().Name = "CB_Filter1";
			this.vmethod_7().Size = new Size(119, 19);
			this.vmethod_7().TabIndex = 13;
			this.vmethod_7().Text = "Filter by keyword:";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(401, 506);
			base.Controls.Add(this.vmethod_7());
			base.Controls.Add(this.vmethod_5());
			base.Controls.Add(this.vmethod_3());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AddMagazine";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "Add Magazine";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06006DD9 RID: 28121 RVA: 0x00045331 File Offset: 0x00043531
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x06006DDA RID: 28122 RVA: 0x00045339 File Offset: 0x00043539
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class114 class114_1)
		{
			this.class114_0 = class114_1;
		}

		// Token: 0x06006DDB RID: 28123 RVA: 0x00045342 File Offset: 0x00043542
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_2(BackgroundWorker backgroundWorker_1)
		{
			this.backgroundWorker_0 = backgroundWorker_1;
		}

		// Token: 0x06006DDC RID: 28124 RVA: 0x0004534B File Offset: 0x0004354B
		[CompilerGenerated]
		internal Control9 vmethod_3()
		{
			return this.control9_0;
		}

		// Token: 0x06006DDD RID: 28125 RVA: 0x003BD5DC File Offset: 0x003BB7DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_4(Control9 control9_1)
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

		// Token: 0x06006DDE RID: 28126 RVA: 0x00045353 File Offset: 0x00043553
		[CompilerGenerated]
		internal Control8 vmethod_5()
		{
			return this.control8_0;
		}

		// Token: 0x06006DDF RID: 28127 RVA: 0x003BD620 File Offset: 0x003BB820
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_6(Control8 control8_1)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_5);
			EventHandler value = new EventHandler(this.method_8);
			EventHandler value2 = new EventHandler(this.method_9);
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

		// Token: 0x06006DE0 RID: 28128 RVA: 0x0004535B File Offset: 0x0004355B
		[CompilerGenerated]
		internal Class112 vmethod_7()
		{
			return this.class112_0;
		}

		// Token: 0x06006DE1 RID: 28129 RVA: 0x00045363 File Offset: 0x00043563
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_8(Class112 class112_1)
		{
			this.class112_0 = class112_1;
		}

		// Token: 0x06006DE2 RID: 28130 RVA: 0x0004536C File Offset: 0x0004356C
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_9()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06006DE3 RID: 28131 RVA: 0x00045374 File Offset: 0x00043574
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_10(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06006DE4 RID: 28132 RVA: 0x0004537D File Offset: 0x0004357D
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_11()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06006DE5 RID: 28133 RVA: 0x00045385 File Offset: 0x00043585
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_12(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06006DE6 RID: 28134 RVA: 0x0004538E File Offset: 0x0004358E
		private void AddMagazine_Shown(object sender, EventArgs e)
		{
			this.method_4();
		}

		// Token: 0x06006DE7 RID: 28135 RVA: 0x003BD69C File Offset: 0x003BB89C
		private void method_3(object sender, EventArgs e)
		{
			Magazine magazine = DBFunctions.smethod_82(Conversions.ToInteger(this.vmethod_0().CurrentRow.Cells["ID"].Value), ref Client.magazines_0.activeUnit_0.scenario_0, true);
			magazine.method_19((ActiveUnit)Client.smethod_54());
			((Class350)Client.magazines_0.activeUnit_0).method_140(magazine);
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x003BD708 File Offset: 0x003BB908
		private void method_4()
		{
			SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
			this.dataTable_0 = DBFunctions.smethod_69(ref sqliteConnection);
			if (!this.dataTable_0.Columns.Contains("Description"))
			{
				this.dataTable_0.Columns.Add("Description", typeof(string));
			}
			try
			{
				foreach (object obj in this.dataTable_0.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					dataRow["Description"] = RuntimeHelpers.GetObjectValue(dataRow["Name"]);
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
			this.method_7();
		}

		// Token: 0x06006DE9 RID: 28137 RVA: 0x00045396 File Offset: 0x00043596
		private void method_5(object object_0)
		{
			if (this.vmethod_7().Checked & Operators.CompareString(this.vmethod_5().Text, "", false) != 0)
			{
				this.method_6();
			}
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x003BD7D4 File Offset: 0x003BB9D4
		private void method_6()
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Description ASC";
			dataView.RowFilter = "Description LIKE '%" + this.vmethod_5().Text + "%'";
			this.vmethod_0().AutoGenerateColumns = false;
			this.vmethod_0().DataSource = dataView;
			this.vmethod_0().Refresh();
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x000453C5 File Offset: 0x000435C5
		private void method_7()
		{
			this.dataView_0 = new DataView(this.dataTable_0);
			this.dataView_0.Sort = "Description ASC";
			this.vmethod_0().AutoGenerateColumns = false;
			this.vmethod_0().DataSource = this.dataView_0;
		}

		// Token: 0x06006DEC RID: 28140 RVA: 0x003BD83C File Offset: 0x003BBA3C
		private void AddMagazine_KeyDown(object sender, KeyEventArgs e)
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
					this.vmethod_7().Select();
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

		// Token: 0x06006DED RID: 28141 RVA: 0x00045405 File Offset: 0x00043605
		private void method_8(object sender, EventArgs e)
		{
			this.bool_3 = true;
		}

		// Token: 0x06006DEE RID: 28142 RVA: 0x0004540E File Offset: 0x0004360E
		private void method_9(object sender, EventArgs e)
		{
			this.bool_3 = false;
			this.vmethod_7().Select();
		}

		// Token: 0x06006DEF RID: 28143 RVA: 0x00044820 File Offset: 0x00042A20
		private void AddMagazine_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06006DF0 RID: 28144 RVA: 0x00044489 File Offset: 0x00042689
		private void AddMagazine_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04003E82 RID: 16002
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridView1")]
		private Class114 class114_0;

		// Token: 0x04003E83 RID: 16003
		[CompilerGenerated]
		[AccessedThroughProperty("BW1")]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04003E84 RID: 16004
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_0;

		// Token: 0x04003E85 RID: 16005
		[CompilerGenerated]
		[AccessedThroughProperty("TB_Find")]
		private Control8 control8_0;

		// Token: 0x04003E86 RID: 16006
		[AccessedThroughProperty("CB_Filter1")]
		[CompilerGenerated]
		private Class112 class112_0;

		// Token: 0x04003E87 RID: 16007
		[AccessedThroughProperty("ID")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04003E88 RID: 16008
		[CompilerGenerated]
		[AccessedThroughProperty("Description")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04003E89 RID: 16009
		private DataTable dataTable_0;

		// Token: 0x04003E8A RID: 16010
		private DataView dataView_0;

		// Token: 0x04003E8B RID: 16011
		private bool bool_3;

		// Token: 0x04003E8C RID: 16012
		public Form form_0;
	}
}
