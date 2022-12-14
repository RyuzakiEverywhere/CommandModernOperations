using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000F06 RID: 3846
	[DesignerGenerated]
	internal sealed partial class MCMWindow : DarkSecondaryFormBase
	{
		// Token: 0x0600887F RID: 34943 RVA: 0x00491334 File Offset: 0x0048F534
		public MCMWindow()
		{
			base.Load += this.MCMWindow_Load;
			base.KeyDown += this.MCMWindow_KeyDown;
			base.FormClosing += this.MCMWindow_FormClosing;
			this.dataTable_0 = new DataTable();
			this.InitializeComponent_1();
		}

		// Token: 0x06008881 RID: 34945 RVA: 0x004913D0 File Offset: 0x0048F5D0
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_1(new Class114());
			this.vmethod_3(new DataGridViewTextBoxColumn());
			this.vmethod_5(new DataGridViewTextBoxColumn());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			this.vmethod_0().AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.vmethod_0().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_0().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_0().CausesValidation = false;
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
				this.vmethod_2(),
				this.vmethod_4()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().Dock = DockStyle.Fill;
			this.vmethod_0().EnableHeadersVisualStyles = false;
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DGV_Sensors";
			this.vmethod_0().RowHeadersVisible = false;
			this.vmethod_0().RowHeadersWidth = 4;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_0().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_0().RowTemplate.Height = 20;
			this.vmethod_0().ScrollBars = ScrollBars.Vertical;
			this.vmethod_0().RowTemplate.Resizable = DataGridViewTriState.False;
			this.vmethod_0().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new Size(523, 205);
			this.vmethod_0().TabIndex = 9;
			this.vmethod_2().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_2().DataPropertyName = "Sensor";
			this.vmethod_2().HeaderText = "Sensor";
			this.vmethod_2().Name = "Sensor";
			this.vmethod_4().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_4().DataPropertyName = "SensorType";
			this.vmethod_4().HeaderText = "Sensor Type";
			this.vmethod_4().Name = "SensorType";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			this.AutoSize = true;
			base.ClientSize = new Size(523, 205);
			base.Controls.Add(this.vmethod_0());
			this.DoubleBuffered = true;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MCMWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Mine Countermeasures";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06008882 RID: 34946 RVA: 0x000520B0 File Offset: 0x000502B0
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x06008883 RID: 34947 RVA: 0x004917E0 File Offset: 0x0048F9E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class114 class114_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_5);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_6);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.CellClick -= value;
				@class.CellContentClick -= value2;
			}
			this.class114_0 = class114_1;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.CellClick += value;
				@class.CellContentClick += value2;
			}
		}

		// Token: 0x06008884 RID: 34948 RVA: 0x000520B8 File Offset: 0x000502B8
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_2()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06008885 RID: 34949 RVA: 0x000520C0 File Offset: 0x000502C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06008886 RID: 34950 RVA: 0x000520C9 File Offset: 0x000502C9
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_4()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06008887 RID: 34951 RVA: 0x000520D1 File Offset: 0x000502D1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06008888 RID: 34952 RVA: 0x000520DA File Offset: 0x000502DA
		private void MCMWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.Text = "MCM & Podded Equipment";
			this.method_3();
		}

		// Token: 0x06008889 RID: 34953 RVA: 0x00491840 File Offset: 0x0048FA40
		public void method_3()
		{
			this.method_4();
			this.vmethod_0().DataSource = this.dataTable_0;
			this.vmethod_0().Columns["CanBeActive"].Visible = false;
			this.vmethod_0().Columns["Order#"].Visible = false;
			try
			{
				foreach (object obj in ((IEnumerable)this.vmethod_0().Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					if (!((ActiveUnit)Client.smethod_54()).vmethod_95()[Conversions.ToInteger(dataGridViewRow.Cells["Order#"].Value)].method_58())
					{
						dataGridViewRow.ReadOnly = true;
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
				foreach (object obj2 in this.vmethod_0().Columns)
				{
					DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj2;
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
		}

		// Token: 0x0600888A RID: 34954 RVA: 0x00491970 File Offset: 0x0048FB70
		private void method_4()
		{
			this.vmethod_0().DataSource = null;
			this.vmethod_0().Rows.Clear();
			this.dataTable_0.Columns.Clear();
			this.dataTable_0.Rows.Clear();
			this.dataTable_0.Columns.Add("Order#", typeof(int));
			this.dataTable_0.Columns.Add("CanBeActive", typeof(bool));
			this.dataTable_0.Columns.Add("Sensor", typeof(string));
			this.dataTable_0.Columns.Add("SensorType", typeof(string));
			this.dataTable_0.Columns.Add("Active", typeof(bool));
			this.dataTable_0.Columns.Add("Status", typeof(string));
			int num = ((ActiveUnit)Client.smethod_54()).vmethod_95().Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Sensor sensor = ((ActiveUnit)Client.smethod_54()).vmethod_95()[i];
				DataRow dataRow = this.dataTable_0.NewRow();
				dataRow["Order#"] = i;
				dataRow["CanBeActive"] = sensor.method_58();
				dataRow["Sensor"] = Misc.smethod_9(sensor.Name);
				dataRow["SensorType"] = sensor.string_2;
				dataRow["Active"] = sensor.method_43();
				dataRow["Status"] = sensor.vmethod_5().ToString();
				this.dataTable_0.Rows.Add(dataRow);
			}
		}

		// Token: 0x0600888B RID: 34955 RVA: 0x00491B5C File Offset: 0x0048FD5C
		private void method_5(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1)
			{
				DataGridViewRow dataGridViewRow = this.vmethod_0().Rows[e.RowIndex];
				if (((ActiveUnit)Client.smethod_54()).vmethod_95()[e.RowIndex].vmethod_5() == PlatformComponent._ComponentStatus.Destroyed)
				{
					dataGridViewRow.Selected = false;
				}
			}
		}

		// Token: 0x0600888C RID: 34956 RVA: 0x00491BBC File Offset: 0x0048FDBC
		private void method_6(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				DataGridViewColumn dataGridViewColumn = this.vmethod_0().Columns[e.ColumnIndex];
				if (((ActiveUnit)Client.smethod_54()).vmethod_95()[e.RowIndex].vmethod_5() == PlatformComponent._ComponentStatus.Operational && Operators.CompareString(dataGridViewColumn.Name, "Active", false) == 0)
				{
					int index = Conversions.ToInteger(this.vmethod_0().Rows[e.RowIndex].Cells["Order#"].Value);
					if (((ActiveUnit)Client.smethod_54()).vmethod_95()[index].method_58())
					{
						if (!((ActiveUnit)Client.smethod_54()).vmethod_95()[index].method_43())
						{
							((ActiveUnit)Client.smethod_54()).vmethod_95()[index].method_77();
							this.vmethod_0().Rows[e.RowIndex].Cells["Active"].Value = true;
						}
						else
						{
							((ActiveUnit)Client.smethod_54()).vmethod_95()[index].method_78();
							this.vmethod_0().Rows[e.RowIndex].Cells["Active"].Value = false;
						}
						Client.bool_1 = true;
						Client.bool_1 = true;
					}
				}
			}
		}

		// Token: 0x0600888D RID: 34957 RVA: 0x000476BE File Offset: 0x000458BE
		private void MCMWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x0600888E RID: 34958 RVA: 0x00044820 File Offset: 0x00042A20
		private void MCMWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x04004A31 RID: 18993
		[CompilerGenerated]
		[AccessedThroughProperty("DGV_Sensors")]
		private Class114 class114_0;

		// Token: 0x04004A32 RID: 18994
		[CompilerGenerated]
		[AccessedThroughProperty("Sensor")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04004A33 RID: 18995
		[AccessedThroughProperty("SensorType")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04004A34 RID: 18996
		private DataTable dataTable_0;
	}
}
