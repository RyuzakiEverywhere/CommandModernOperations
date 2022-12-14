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
	// Token: 0x02000F00 RID: 3840
	[DesignerGenerated]
	internal sealed partial class AddSensor : DarkSecondaryFormBase
	{
		// Token: 0x060087B9 RID: 34745 RVA: 0x0048BDB4 File Offset: 0x00489FB4
		public AddSensor()
		{
			base.Load += this.AddSensor_Load;
			base.KeyDown += this.AddSensor_KeyDown;
			base.FormClosing += this.AddSensor_FormClosing;
			this.InitializeComponent_1();
		}

		// Token: 0x060087BB RID: 34747 RVA: 0x0048BE44 File Offset: 0x0048A044
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_1(new Class114());
			this.vmethod_21(new DataGridViewTextBoxColumn());
			this.vmethod_23(new DataGridViewTextBoxColumn());
			this.vmethod_3(new BackgroundWorker());
			this.vmethod_5(new Control9());
			this.vmethod_7(new Class112());
			this.vmethod_9(new Control8());
			this.vmethod_13(new Class116());
			this.vmethod_11(new PlatformComponentArcControl());
			this.vmethod_15(new PlatformComponentArcControl());
			this.vmethod_17(new Class116());
			this.vmethod_19(new Class116());
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
				this.vmethod_20(),
				this.vmethod_22()
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
			this.vmethod_0().Location = new Point(0, 159);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DataGridView1";
			this.vmethod_0().RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_0().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_0().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new Size(503, 355);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_20().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_20().DataPropertyName = "ID";
			this.vmethod_20().HeaderText = "ID";
			this.vmethod_20().Name = "ID";
			this.vmethod_20().ReadOnly = true;
			this.vmethod_20().Width = 41;
			this.vmethod_22().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_22().DataPropertyName = "Name";
			this.vmethod_22().HeaderText = "Name";
			this.vmethod_22().Name = "Description";
			this.vmethod_22().ReadOnly = true;
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
			this.vmethod_6().Location = new Point(7, 111);
			this.vmethod_6().Name = "CB_Filter1";
			this.vmethod_6().Size = new Size(108, 17);
			this.vmethod_6().TabIndex = 13;
			this.vmethod_6().Text = "Filter by keyword:";
			this.vmethod_8().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_8().method_14(null);
			this.vmethod_8().method_15(AutoCompleteMode.None);
			this.vmethod_8().method_13(AutoCompleteSource.None);
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().method_17(new Font(Client.font_1.FontFamily, 8f));
			this.vmethod_8().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_8().method_12(null);
			this.vmethod_8().method_18(null);
			this.vmethod_8().Location = new Point(6, 134);
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
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Location = new Point(309, 1);
			this.vmethod_12().Name = "Label1";
			this.vmethod_12().Size = new Size(53, 13);
			this.vmethod_12().TabIndex = 15;
			this.vmethod_12().Text = "Detection";
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().Location = new Point(394, 13);
			this.vmethod_10().Name = "ArcControl_Illumination";
			this.vmethod_10().Size = new Size(103, 100);
			this.vmethod_10().TabIndex = 14;
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_14().Location = new Point(288, 12);
			this.vmethod_14().Name = "ArcControl_Detection";
			this.vmethod_14().Size = new Size(103, 100);
			this.vmethod_14().TabIndex = 16;
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Location = new Point(386, 2);
			this.vmethod_16().Name = "Label2";
			this.vmethod_16().Size = new Size(112, 13);
			this.vmethod_16().TabIndex = 17;
			this.vmethod_16().Text = "Tracking / Illumination";
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(271, 111);
			this.vmethod_18().Name = "Label3";
			this.vmethod_18().Size = new Size(226, 13);
			this.vmethod_18().TabIndex = 18;
			this.vmethod_18().Text = "Tips: Double-click to select or deselect all arcs";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(503, 514);
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AddSensor";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Add Sensor";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060087BC RID: 34748 RVA: 0x00051A5B File Offset: 0x0004FC5B
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x060087BD RID: 34749 RVA: 0x00051A63 File Offset: 0x0004FC63
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class114 class114_1)
		{
			this.class114_0 = class114_1;
		}

		// Token: 0x060087BE RID: 34750 RVA: 0x00051A6C File Offset: 0x0004FC6C
		[CompilerGenerated]
		internal BackgroundWorker vmethod_2()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x060087BF RID: 34751 RVA: 0x0048C778 File Offset: 0x0048A978
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

		// Token: 0x060087C0 RID: 34752 RVA: 0x00051A74 File Offset: 0x0004FC74
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_0;
		}

		// Token: 0x060087C1 RID: 34753 RVA: 0x0048C7D8 File Offset: 0x0048A9D8
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

		// Token: 0x060087C2 RID: 34754 RVA: 0x00051A7C File Offset: 0x0004FC7C
		[CompilerGenerated]
		internal Class112 vmethod_6()
		{
			return this.class112_0;
		}

		// Token: 0x060087C3 RID: 34755 RVA: 0x00051A84 File Offset: 0x0004FC84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class112 class112_1)
		{
			this.class112_0 = class112_1;
		}

		// Token: 0x060087C4 RID: 34756 RVA: 0x00051A8D File Offset: 0x0004FC8D
		[CompilerGenerated]
		internal Control8 vmethod_8()
		{
			return this.control8_0;
		}

		// Token: 0x060087C5 RID: 34757 RVA: 0x0048C81C File Offset: 0x0048AA1C
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

		// Token: 0x060087C6 RID: 34758 RVA: 0x00051A95 File Offset: 0x0004FC95
		[CompilerGenerated]
		internal PlatformComponentArcControl vmethod_10()
		{
			return this.platformComponentArcControl_0;
		}

		// Token: 0x060087C7 RID: 34759 RVA: 0x00051A9D File Offset: 0x0004FC9D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(PlatformComponentArcControl platformComponentArcControl_2)
		{
			this.platformComponentArcControl_0 = platformComponentArcControl_2;
		}

		// Token: 0x060087C8 RID: 34760 RVA: 0x00051AA6 File Offset: 0x0004FCA6
		[CompilerGenerated]
		internal Class116 vmethod_12()
		{
			return this.class116_0;
		}

		// Token: 0x060087C9 RID: 34761 RVA: 0x00051AAE File Offset: 0x0004FCAE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class116 class116_3)
		{
			this.class116_0 = class116_3;
		}

		// Token: 0x060087CA RID: 34762 RVA: 0x00051AB7 File Offset: 0x0004FCB7
		[CompilerGenerated]
		internal PlatformComponentArcControl vmethod_14()
		{
			return this.platformComponentArcControl_1;
		}

		// Token: 0x060087CB RID: 34763 RVA: 0x00051ABF File Offset: 0x0004FCBF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(PlatformComponentArcControl platformComponentArcControl_2)
		{
			this.platformComponentArcControl_1 = platformComponentArcControl_2;
		}

		// Token: 0x060087CC RID: 34764 RVA: 0x00051AC8 File Offset: 0x0004FCC8
		[CompilerGenerated]
		internal Class116 vmethod_16()
		{
			return this.class116_1;
		}

		// Token: 0x060087CD RID: 34765 RVA: 0x00051AD0 File Offset: 0x0004FCD0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class116 class116_3)
		{
			this.class116_1 = class116_3;
		}

		// Token: 0x060087CE RID: 34766 RVA: 0x00051AD9 File Offset: 0x0004FCD9
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_2;
		}

		// Token: 0x060087CF RID: 34767 RVA: 0x00051AE1 File Offset: 0x0004FCE1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_3)
		{
			this.class116_2 = class116_3;
		}

		// Token: 0x060087D0 RID: 34768 RVA: 0x00051AEA File Offset: 0x0004FCEA
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_20()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x060087D1 RID: 34769 RVA: 0x00051AF2 File Offset: 0x0004FCF2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060087D2 RID: 34770 RVA: 0x00051AFB File Offset: 0x0004FCFB
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_22()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x060087D3 RID: 34771 RVA: 0x00051B03 File Offset: 0x0004FD03
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060087D4 RID: 34772 RVA: 0x00051B0C File Offset: 0x0004FD0C
		private void AddSensor_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_2().RunWorkerAsync();
		}

		// Token: 0x060087D5 RID: 34773 RVA: 0x0048C898 File Offset: 0x0048AA98
		private void method_3(object sender, EventArgs e)
		{
			if (!Information.IsNothing(Client.smethod_54()) && Client.smethod_54().bool_0 && (!this.vmethod_14().method_1() || DarkMessageBox.smethod_1("You have defined no detection arcs for this sensor. Are you sure?", "No detection arcs defined!", Enum11.const_3) != DialogResult.No))
			{
				int int_ = Conversions.ToInteger(this.vmethod_0().CurrentRow.Cells["ID"].Value);
				SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
				Sensor sensor = DBFunctions.smethod_97(int_, ref sqliteConnection);
				sensor.class295_0 = this.vmethod_14().class295_0;
				sensor.class295_1 = this.vmethod_10().class295_0;
				((ActiveUnit)Client.smethod_54()).method_102(sensor);
				sensor.method_19((ActiveUnit)Client.smethod_54());
				if (!Information.IsNothing(Client.unitSensors_0) && Client.unitSensors_0.Visible)
				{
					Client.unitSensors_0.method_5();
				}
			}
		}

		// Token: 0x060087D6 RID: 34774 RVA: 0x0048C984 File Offset: 0x0048AB84
		private void method_4(object sender, DoWorkEventArgs e)
		{
			SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
			this.dataTable_0 = DBFunctions.smethod_70(ref sqliteConnection);
		}

		// Token: 0x060087D7 RID: 34775 RVA: 0x00051B2C File Offset: 0x0004FD2C
		private void method_5(object sender, RunWorkerCompletedEventArgs e)
		{
			this.method_8();
		}

		// Token: 0x060087D8 RID: 34776 RVA: 0x00051B34 File Offset: 0x0004FD34
		private void method_6(object object_0)
		{
			if (this.vmethod_6().Checked & Operators.CompareString(this.vmethod_8().Text, "", false) != 0)
			{
				this.method_7();
			}
		}

		// Token: 0x060087D9 RID: 34777 RVA: 0x0048C9AC File Offset: 0x0048ABAC
		private void method_7()
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Name ASC";
			dataView.RowFilter = "Name LIKE '%" + this.vmethod_8().Text + "%'";
			this.vmethod_0().AutoGenerateColumns = false;
			this.vmethod_0().DataSource = dataView;
			this.vmethod_0().Refresh();
		}

		// Token: 0x060087DA RID: 34778 RVA: 0x00051B63 File Offset: 0x0004FD63
		private void method_8()
		{
			this.dataView_0 = new DataView(this.dataTable_0);
			this.dataView_0.Sort = "Name ASC";
			this.vmethod_0().AutoGenerateColumns = false;
			this.vmethod_0().DataSource = this.dataView_0;
		}

		// Token: 0x060087DB RID: 34779 RVA: 0x0048CA14 File Offset: 0x0048AC14
		private void AddSensor_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x060087DC RID: 34780 RVA: 0x00051BA3 File Offset: 0x0004FDA3
		private void method_9(object sender, EventArgs e)
		{
			this.bool_3 = true;
		}

		// Token: 0x060087DD RID: 34781 RVA: 0x00051BAC File Offset: 0x0004FDAC
		private void method_10(object sender, EventArgs e)
		{
			this.bool_3 = false;
			this.vmethod_6().Select();
		}

		// Token: 0x060087DE RID: 34782 RVA: 0x00044820 File Offset: 0x00042A20
		private void AddSensor_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x040049DF RID: 18911
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridView1")]
		private Class114 class114_0;

		// Token: 0x040049E0 RID: 18912
		[CompilerGenerated]
		[AccessedThroughProperty("BW1")]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x040049E1 RID: 18913
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x040049E2 RID: 18914
		[AccessedThroughProperty("CB_Filter1")]
		[CompilerGenerated]
		private Class112 class112_0;

		// Token: 0x040049E3 RID: 18915
		[AccessedThroughProperty("TB_Find")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x040049E4 RID: 18916
		[AccessedThroughProperty("ArcControl_Illumination")]
		[CompilerGenerated]
		private PlatformComponentArcControl platformComponentArcControl_0;

		// Token: 0x040049E5 RID: 18917
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x040049E6 RID: 18918
		[AccessedThroughProperty("ArcControl_Detection")]
		[CompilerGenerated]
		private PlatformComponentArcControl platformComponentArcControl_1;

		// Token: 0x040049E7 RID: 18919
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x040049E8 RID: 18920
		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		private Class116 class116_2;

		// Token: 0x040049E9 RID: 18921
		[CompilerGenerated]
		[AccessedThroughProperty("ID")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x040049EA RID: 18922
		[AccessedThroughProperty("Description")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x040049EB RID: 18923
		private DataTable dataTable_0;

		// Token: 0x040049EC RID: 18924
		private DataView dataView_0;

		// Token: 0x040049ED RID: 18925
		private bool bool_3;

		// Token: 0x040049EE RID: 18926
		public Form form_0;
	}
}
