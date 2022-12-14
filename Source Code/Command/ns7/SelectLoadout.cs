using System;
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
using ns4;
using ns5;

namespace ns7
{
	// Token: 0x02000F1B RID: 3867
	[DesignerGenerated]
	internal sealed partial class SelectLoadout : DarkSecondaryFormBase
	{
		// Token: 0x06008933 RID: 35123 RVA: 0x00496190 File Offset: 0x00494390
		public SelectLoadout()
		{
			base.Load += this.SelectLoadout_Load;
			base.KeyDown += this.SelectLoadout_KeyDown;
			base.FormClosing += this.SelectLoadout_FormClosing;
			this.dataTable_0 = new DataTable();
			this.dataTable_1 = new DataTable();
			this.InitializeComponent_1();
		}

		// Token: 0x06008935 RID: 35125 RVA: 0x00496238 File Offset: 0x00494438
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			this.vmethod_1(new Class114());
			this.vmethod_23(new DataGridViewTextBoxColumn());
			this.vmethod_25(new DataGridViewTextBoxColumn());
			this.vmethod_27(new DataGridViewTextBoxColumn());
			this.vmethod_3(new Class114());
			this.vmethod_11(new DataGridViewTextBoxColumn());
			this.vmethod_13(new DataGridViewTextBoxColumn());
			this.vmethod_15(new DataGridViewTextBoxColumn());
			this.vmethod_17(new DataGridViewTextBoxColumn());
			this.vmethod_19(new DataGridViewTextBoxColumn());
			this.vmethod_21(new DataGridViewTextBoxColumn());
			this.vmethod_5(new Class116());
			this.vmethod_7(new Control9());
			this.vmethod_9(new Control9());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			((ISupportInitialize)this.vmethod_2()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().AllowUserToResizeRows = false;
			this.vmethod_0().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_0().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_0().CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
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
				this.vmethod_22(),
				this.vmethod_24(),
				this.vmethod_26()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().Dock = DockStyle.Top;
			this.vmethod_0().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_0().EnableHeadersVisualStyles = false;
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DGV_Loadouts";
			this.vmethod_0().RowHeadersVisible = false;
			this.vmethod_0().RowHeadersWidth = 10;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_0().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_0().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new Size(442, 279);
			this.vmethod_0().TabIndex = 7;
			this.vmethod_22().DataPropertyName = "ID";
			this.vmethod_22().HeaderText = "ID";
			this.vmethod_22().Name = "ID";
			this.vmethod_22().ReadOnly = true;
			this.vmethod_22().Visible = false;
			this.vmethod_24().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_24().DataPropertyName = "Name";
			this.vmethod_24().HeaderText = "Loadout";
			this.vmethod_24().Name = "Loadout";
			this.vmethod_24().ReadOnly = true;
			this.vmethod_26().DataPropertyName = "AttackAltitude";
			this.vmethod_26().HeaderText = "Attack Altitude";
			this.vmethod_26().Name = "AttackAltitude";
			this.vmethod_26().ReadOnly = true;
			this.vmethod_2().AllowUserToAddRows = false;
			this.vmethod_2().AllowUserToDeleteRows = false;
			this.vmethod_2().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_2().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			this.vmethod_2().AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.vmethod_2().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_2().CausesValidation = false;
			this.vmethod_2().CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.vmethod_2().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle4.Font = new Font(Client.font_1.FontFamily, 8f);
			dataGridViewCellStyle4.ForeColor = Color.LightGray;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			this.vmethod_2().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_2().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_2().ColumnHeadersVisible = false;
			this.vmethod_2().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_10(),
				this.vmethod_12(),
				this.vmethod_14(),
				this.vmethod_16(),
				this.vmethod_18(),
				this.vmethod_20()
			});
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle5.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle5.ForeColor = Color.LightGray;
			dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
			this.vmethod_2().DefaultCellStyle = dataGridViewCellStyle5;
			this.vmethod_2().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_2().Enabled = false;
			this.vmethod_2().EnableHeadersVisualStyles = false;
			this.vmethod_2().Location = new Point(3, 302);
			this.vmethod_2().MultiSelect = false;
			this.vmethod_2().Name = "DGV_LoadoutItems";
			this.vmethod_2().RowHeadersVisible = false;
			this.vmethod_2().RowHeadersWidth = 4;
			dataGridViewCellStyle6.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle6.ForeColor = Color.LightGray;
			dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle6.SelectionForeColor = Color.LightGray;
			this.vmethod_2().RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.vmethod_2().RowTemplate.Height = 15;
			this.vmethod_2().RowTemplate.Resizable = DataGridViewTriState.False;
			this.vmethod_2().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_2().Size = new Size(439, 115);
			this.vmethod_2().TabIndex = 9;
			this.vmethod_10().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_10().DataPropertyName = "ID";
			this.vmethod_10().HeaderText = "ID";
			this.vmethod_10().Name = "DataGridViewTextBoxColumn1";
			this.vmethod_10().Visible = false;
			this.vmethod_12().DataPropertyName = "ComponentID";
			this.vmethod_12().HeaderText = "ComponentID";
			this.vmethod_12().Name = "ComponentID";
			this.vmethod_12().Visible = false;
			this.vmethod_12().Width = 5;
			this.vmethod_14().DataPropertyName = "Quantity";
			this.vmethod_14().HeaderText = "Quantity";
			this.vmethod_14().Name = "Quantity";
			this.vmethod_14().Visible = false;
			this.vmethod_14().Width = 5;
			this.vmethod_16().DataPropertyName = "Fill";
			this.vmethod_16().HeaderText = "Item";
			this.vmethod_16().Name = "Item";
			this.vmethod_16().Width = 5;
			this.vmethod_18().DataPropertyName = "Internal";
			this.vmethod_18().HeaderText = "Internal";
			this.vmethod_18().Name = "Internal";
			this.vmethod_18().Visible = false;
			this.vmethod_18().Width = 5;
			this.vmethod_20().DataPropertyName = "Optional";
			this.vmethod_20().HeaderText = "OptionalWeapon";
			this.vmethod_20().Name = "OptionalWeapon";
			this.vmethod_20().Visible = false;
			this.vmethod_20().Width = 5;
			this.vmethod_4().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(0, 286);
			this.vmethod_4().Name = "Label1";
			this.vmethod_4().Size = new Size(90, 13);
			this.vmethod_4().TabIndex = 10;
			this.vmethod_4().Text = "Loadout items:";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.None;
			this.vmethod_6().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_6().ForeColor = SystemColors.Control;
			this.vmethod_6().Location = new Point(3, 438);
			this.vmethod_6().Name = "Button1";
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(75, 23);
			this.vmethod_6().TabIndex = 11;
			this.vmethod_6().Text = "OK";
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().DialogResult = DialogResult.Cancel;
			this.vmethod_8().Font = new Font(Client.font_1.FontFamily, 10f);
			this.vmethod_8().ForeColor = SystemColors.Control;
			this.vmethod_8().Location = new Point(367, 438);
			this.vmethod_8().Name = "Button2";
			this.vmethod_8().method_1(0);
			this.vmethod_8().Size = new Size(75, 23);
			this.vmethod_8().TabIndex = 12;
			this.vmethod_8().Text = "Cancel";
			base.AcceptButton = this.vmethod_6();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.CancelButton = this.vmethod_8();
			base.ClientSize = new Size(442, 464);
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SelectLoadout";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "SelectLoadout";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			((ISupportInitialize)this.vmethod_2()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06008936 RID: 35126 RVA: 0x0005265D File Offset: 0x0005085D
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x06008937 RID: 35127 RVA: 0x00496E1C File Offset: 0x0049501C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class114 class114_2)
		{
			KeyEventHandler value = new KeyEventHandler(this.method_7);
			EventHandler value2 = new EventHandler(this.method_8);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.KeyDown -= value;
				@class.SelectionChanged -= value2;
			}
			this.class114_0 = class114_2;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.KeyDown += value;
				@class.SelectionChanged += value2;
			}
		}

		// Token: 0x06008938 RID: 35128 RVA: 0x00052665 File Offset: 0x00050865
		[CompilerGenerated]
		internal Class114 vmethod_2()
		{
			return this.class114_1;
		}

		// Token: 0x06008939 RID: 35129 RVA: 0x0005266D File Offset: 0x0005086D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class114 class114_2)
		{
			this.class114_1 = class114_2;
		}

		// Token: 0x0600893A RID: 35130 RVA: 0x00052676 File Offset: 0x00050876
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_0;
		}

		// Token: 0x0600893B RID: 35131 RVA: 0x0005267E File Offset: 0x0005087E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x0600893C RID: 35132 RVA: 0x00052687 File Offset: 0x00050887
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_0;
		}

		// Token: 0x0600893D RID: 35133 RVA: 0x00496E7C File Offset: 0x0049507C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_3);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_2;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600893E RID: 35134 RVA: 0x0005268F File Offset: 0x0005088F
		[CompilerGenerated]
		internal Control9 vmethod_8()
		{
			return this.control9_1;
		}

		// Token: 0x0600893F RID: 35135 RVA: 0x00496EC0 File Offset: 0x004950C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_5);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_2;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06008940 RID: 35136 RVA: 0x00052697 File Offset: 0x00050897
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_10()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06008941 RID: 35137 RVA: 0x0005269F File Offset: 0x0005089F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06008942 RID: 35138 RVA: 0x000526A8 File Offset: 0x000508A8
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_12()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06008943 RID: 35139 RVA: 0x000526B0 File Offset: 0x000508B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06008944 RID: 35140 RVA: 0x000526B9 File Offset: 0x000508B9
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_14()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06008945 RID: 35141 RVA: 0x000526C1 File Offset: 0x000508C1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06008946 RID: 35142 RVA: 0x000526CA File Offset: 0x000508CA
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_16()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06008947 RID: 35143 RVA: 0x000526D2 File Offset: 0x000508D2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06008948 RID: 35144 RVA: 0x000526DB File Offset: 0x000508DB
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_18()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06008949 RID: 35145 RVA: 0x000526E3 File Offset: 0x000508E3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x0600894A RID: 35146 RVA: 0x000526EC File Offset: 0x000508EC
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_20()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x0600894B RID: 35147 RVA: 0x000526F4 File Offset: 0x000508F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x0600894C RID: 35148 RVA: 0x000526FD File Offset: 0x000508FD
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_22()
		{
			return this.dataGridViewTextBoxColumn_6;
		}

		// Token: 0x0600894D RID: 35149 RVA: 0x00052705 File Offset: 0x00050905
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x0600894E RID: 35150 RVA: 0x0005270E File Offset: 0x0005090E
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_24()
		{
			return this.dataGridViewTextBoxColumn_7;
		}

		// Token: 0x0600894F RID: 35151 RVA: 0x00052716 File Offset: 0x00050916
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_7 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06008950 RID: 35152 RVA: 0x0005271F File Offset: 0x0005091F
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_26()
		{
			return this.dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06008951 RID: 35153 RVA: 0x00052727 File Offset: 0x00050927
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_8 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06008952 RID: 35154 RVA: 0x00496F04 File Offset: 0x00495104
		private void SelectLoadout_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.geopoint_Struct_0 = Class2413.smethod_2().method_41().geopoint_Struct_0;
			this.vmethod_0().AutoGenerateColumns = false;
			int aircraftID = this.int_0;
			Dictionary<int, int> selectedAircraftTotalWeaponQty = null;
			SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
			Scenario theScen = Client.smethod_46();
			bool flag = false;
			Scenario scenario = null;
			Aircraft aircraft = null;
			int num = 0;
			bool flag2 = false;
			this.dataTable_0 = DBFunctions.smethod_42(aircraftID, selectedAircraftTotalWeaponQty, ref sqliteConnection, theScen, ref flag, ref scenario, ref aircraft, ref num, ref flag2);
			this.vmethod_0().DataSource = this.dataTable_0;
			this.vmethod_2().DataSource = this.method_6(this.int_1);
			this.int_1 = Conversions.ToInteger(this.vmethod_0().Rows[0].Cells["ID"].Value);
		}

		// Token: 0x06008953 RID: 35155 RVA: 0x00052730 File Offset: 0x00050930
		private void method_3(object sender, EventArgs e)
		{
			this.method_4();
		}

		// Token: 0x06008954 RID: 35156 RVA: 0x00496FD8 File Offset: 0x004951D8
		private void method_4()
		{
			Aircraft aircraft = Client.smethod_46().method_71(this.side_0, this.string_0, this.geopoint_Struct_0.double_0, this.geopoint_Struct_0.double_1, this.int_0, this.int_1, 100f, Unit.Enum122.const_0, Class2413.smethod_2().method_5().string_0);
			Aircraft aircraft2 = aircraft;
			ActiveUnit.Throttle throttle_ = ActiveUnit.Throttle.Cruise;
			Aircraft aircraft3;
			ActiveUnit activeUnit_;
			bool bool_ = (aircraft3 = aircraft).vmethod_76(activeUnit_ = aircraft);
			float float_ = Aircraft_AI.smethod_2(ref aircraft, throttle_, ref bool_);
			aircraft3.vmethod_77(activeUnit_, bool_);
			aircraft2.vmethod_73(float_);
			aircraft.vmethod_15(false, aircraft.vmethod_72());
			checked
			{
				if (!Information.IsNothing(aircraft.method_167()))
				{
					WeaponRec[] weaponRec_ = aircraft.method_167().weaponRec_0;
					for (int i = 0; i < weaponRec_.Length; i++)
					{
						weaponRec_[i].method_12(aircraft.scenario_0).vmethod_15(false, aircraft.vmethod_14(false));
					}
				}
				Client.bool_1 = true;
				if (Class2413.smethod_2().method_5().Visible)
				{
					Class2413.smethod_2().method_5().Close();
				}
				base.Close();
			}
		}

		// Token: 0x06008955 RID: 35157 RVA: 0x0003F161 File Offset: 0x0003D361
		private void method_5(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06008956 RID: 35158 RVA: 0x004970DC File Offset: 0x004952DC
		private DataTable method_6(int int_2)
		{
			int num = this.int_1;
			SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
			bool flag = false;
			return DBFunctions.smethod_44(num, ref sqliteConnection, ref flag);
		}

		// Token: 0x06008957 RID: 35159 RVA: 0x00052738 File Offset: 0x00050938
		private void method_7(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.method_4();
			}
		}

		// Token: 0x06008958 RID: 35160 RVA: 0x00497108 File Offset: 0x00495308
		private void method_8(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				this.int_1 = Conversions.ToInteger(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				this.vmethod_2().DataSource = this.method_6(this.int_1);
			}
		}

		// Token: 0x06008959 RID: 35161 RVA: 0x0004B8B4 File Offset: 0x00049AB4
		private void SelectLoadout_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x0600895A RID: 35162 RVA: 0x00044820 File Offset: 0x00042A20
		private void SelectLoadout_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x04004A93 RID: 19091
		[AccessedThroughProperty("DGV_Loadouts")]
		[CompilerGenerated]
		private Class114 class114_0;

		// Token: 0x04004A94 RID: 19092
		[CompilerGenerated]
		[AccessedThroughProperty("DGV_LoadoutItems")]
		private Class114 class114_1;

		// Token: 0x04004A95 RID: 19093
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04004A96 RID: 19094
		[AccessedThroughProperty("Button1")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x04004A97 RID: 19095
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_1;

		// Token: 0x04004A98 RID: 19096
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04004A99 RID: 19097
		[CompilerGenerated]
		[AccessedThroughProperty("ComponentID")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04004A9A RID: 19098
		[CompilerGenerated]
		[AccessedThroughProperty("Quantity")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04004A9B RID: 19099
		[CompilerGenerated]
		[AccessedThroughProperty("Item")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04004A9C RID: 19100
		[AccessedThroughProperty("Internal")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04004A9D RID: 19101
		[CompilerGenerated]
		[AccessedThroughProperty("OptionalWeapon")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x04004A9E RID: 19102
		[AccessedThroughProperty("ID")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x04004A9F RID: 19103
		[AccessedThroughProperty("Loadout")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		// Token: 0x04004AA0 RID: 19104
		[CompilerGenerated]
		[AccessedThroughProperty("AttackAltitude")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		// Token: 0x04004AA1 RID: 19105
		public string string_0;

		// Token: 0x04004AA2 RID: 19106
		public int int_0;

		// Token: 0x04004AA3 RID: 19107
		public Side side_0;

		// Token: 0x04004AA4 RID: 19108
		private int int_1;

		// Token: 0x04004AA5 RID: 19109
		private Geopoint_Struct geopoint_Struct_0;

		// Token: 0x04004AA6 RID: 19110
		private DataTable dataTable_0;

		// Token: 0x04004AA7 RID: 19111
		private DataTable dataTable_1;
	}
}
