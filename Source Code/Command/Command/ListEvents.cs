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
using ns2;
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000EBA RID: 3770
	[DesignerGenerated]
	public sealed partial class ListEvents : DarkSecondaryFormBase
	{
		// Token: 0x06007988 RID: 31112 RVA: 0x00420E38 File Offset: 0x0041F038
		public ListEvents()
		{
			base.Shown += this.ListEvents_Shown;
			base.KeyDown += this.ListEvents_KeyDown;
			base.FormClosing += this.ListEvents_FormClosing;
			base.Load += this.ListEvents_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x0600798A RID: 31114 RVA: 0x00420EDC File Offset: 0x0041F0DC
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_1(new Class114());
			this.vmethod_9(new DataGridViewTextBoxColumn());
			this.vmethod_11(new DataGridViewTextBoxColumn());
			this.vmethod_13(new DataGridViewCheckBoxColumn());
			this.vmethod_15(new DataGridViewCheckBoxColumn());
			this.vmethod_17(new DataGridViewTextBoxColumn());
			this.vmethod_3(new Control9());
			this.vmethod_5(new Control9());
			this.vmethod_7(new Control9());
			this.vmethod_19(new Control9());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
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
				this.vmethod_8(),
				this.vmethod_10(),
				this.vmethod_12(),
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
			this.vmethod_0().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_0().EnableHeadersVisualStyles = false;
			this.vmethod_0().Location = new Point(2, 2);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DataGridView1";
			this.vmethod_0().ReadOnly = true;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_0().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_0().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().ShowCellToolTips = false;
			this.vmethod_0().ShowEditingIcon = false;
			this.vmethod_0().ShowRowErrors = false;
			this.vmethod_0().Size = new Size(678, 361);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_8().DataPropertyName = "ID";
			this.vmethod_8().HeaderText = "ID";
			this.vmethod_8().Name = "ID";
			this.vmethod_8().ReadOnly = true;
			this.vmethod_8().Visible = false;
			this.vmethod_10().DataPropertyName = "Description";
			this.vmethod_10().HeaderText = "Description";
			this.vmethod_10().Name = "Description";
			this.vmethod_10().ReadOnly = true;
			this.vmethod_10().Width = 335;
			this.vmethod_12().DataPropertyName = "IsRepeatable";
			this.vmethod_12().HeaderText = "Is Repeatable";
			this.vmethod_12().Name = "IsRepeatable";
			this.vmethod_12().ReadOnly = true;
			this.vmethod_14().DataPropertyName = "IsActive";
			this.vmethod_14().HeaderText = "Is Active";
			this.vmethod_14().Name = "IsActive";
			this.vmethod_14().ReadOnly = true;
			this.vmethod_16().DataPropertyName = "Probability";
			this.vmethod_16().HeaderText = "Probability (%)";
			this.vmethod_16().Name = "Probability";
			this.vmethod_16().ReadOnly = true;
			this.vmethod_2().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DialogResult = DialogResult.None;
			this.vmethod_2().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_2().ForeColor = SystemColors.Control;
			this.vmethod_2().Location = new Point(432, 369);
			this.vmethod_2().Name = "Button_EditSelected";
			this.vmethod_2().method_1(0);
			this.vmethod_2().Size = new Size(121, 21);
			this.vmethod_2().TabIndex = 7;
			this.vmethod_2().Text = "Edit selected";
			this.vmethod_4().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(559, 369);
			this.vmethod_4().Name = "Button_DeleteSelected";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(121, 21);
			this.vmethod_4().TabIndex = 6;
			this.vmethod_4().Text = "Delete selected";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.None;
			this.vmethod_6().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_6().ForeColor = SystemColors.Control;
			this.vmethod_6().Location = new Point(2, 369);
			this.vmethod_6().Name = "Button1";
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(133, 21);
			this.vmethod_6().TabIndex = 5;
			this.vmethod_6().Text = "Create new event";
			this.vmethod_18().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_18().BackColor = Color.Transparent;
			this.vmethod_18().DialogResult = DialogResult.None;
			this.vmethod_18().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_18().ForeColor = SystemColors.Control;
			this.vmethod_18().Location = new Point(305, 369);
			this.vmethod_18().Name = "Button_CloneSelected";
			this.vmethod_18().method_1(0);
			this.vmethod_18().Size = new Size(121, 21);
			this.vmethod_18().TabIndex = 8;
			this.vmethod_18().Text = "Clone selected";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(682, 392);
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ListEvents";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Events";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0600798B RID: 31115 RVA: 0x0004B04C File Offset: 0x0004924C
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x0600798C RID: 31116 RVA: 0x0042174C File Offset: 0x0041F94C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class114 class114_1)
		{
			EventHandler value = new EventHandler(this.method_8);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_9);
			DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.method_10);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.SelectionChanged -= value;
				@class.CellContentClick -= value2;
				@class.CellContentDoubleClick -= value3;
			}
			this.class114_0 = class114_1;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.SelectionChanged += value;
				@class.CellContentClick += value2;
				@class.CellContentDoubleClick += value3;
			}
		}

		// Token: 0x0600798D RID: 31117 RVA: 0x0004B054 File Offset: 0x00049254
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_0;
		}

		// Token: 0x0600798E RID: 31118 RVA: 0x004217C8 File Offset: 0x0041F9C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_5);
			Control9 control = this.control9_0;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_0 = control9_4;
			control = this.control9_0;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600798F RID: 31119 RVA: 0x0004B05C File Offset: 0x0004925C
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_1;
		}

		// Token: 0x06007990 RID: 31120 RVA: 0x0042180C File Offset: 0x0041FA0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_6);
			Control9 control = this.control9_1;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_1 = control9_4;
			control = this.control9_1;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007991 RID: 31121 RVA: 0x0004B064 File Offset: 0x00049264
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_2;
		}

		// Token: 0x06007992 RID: 31122 RVA: 0x00421850 File Offset: 0x0041FA50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_4);
			Control9 control = this.control9_2;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_2 = control9_4;
			control = this.control9_2;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x06007993 RID: 31123 RVA: 0x0004B06C File Offset: 0x0004926C
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_8()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06007994 RID: 31124 RVA: 0x0004B074 File Offset: 0x00049274
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06007995 RID: 31125 RVA: 0x0004B07D File Offset: 0x0004927D
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_10()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06007996 RID: 31126 RVA: 0x0004B085 File Offset: 0x00049285
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06007997 RID: 31127 RVA: 0x0004B08E File Offset: 0x0004928E
		[CompilerGenerated]
		internal DataGridViewCheckBoxColumn vmethod_12()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x06007998 RID: 31128 RVA: 0x0004B096 File Offset: 0x00049296
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x06007999 RID: 31129 RVA: 0x0004B09F File Offset: 0x0004929F
		[CompilerGenerated]
		internal DataGridViewCheckBoxColumn vmethod_14()
		{
			return this.dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x0600799A RID: 31130 RVA: 0x0004B0A7 File Offset: 0x000492A7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_1 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x0600799B RID: 31131 RVA: 0x0004B0B0 File Offset: 0x000492B0
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_16()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600799C RID: 31132 RVA: 0x0004B0B8 File Offset: 0x000492B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x0600799D RID: 31133 RVA: 0x0004B0C1 File Offset: 0x000492C1
		[CompilerGenerated]
		internal Control9 vmethod_18()
		{
			return this.control9_3;
		}

		// Token: 0x0600799E RID: 31134 RVA: 0x00421894 File Offset: 0x0041FA94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_7);
			Control9 control = this.control9_3;
			if (control != null)
			{
				control.Click -= value;
			}
			this.control9_3 = control9_4;
			control = this.control9_3;
			if (control != null)
			{
				control.Click += value;
			}
		}

		// Token: 0x0600799F RID: 31135 RVA: 0x004218D8 File Offset: 0x0041FAD8
		public void method_3()
		{
			try
			{
				this.bool_3 = true;
				this.vmethod_0().SuspendLayout();
				DataTable dataTable = new DataTable();
				dataTable.Columns.Add("ID", typeof(string));
				dataTable.Columns.Add("Description", typeof(string));
				dataTable.Columns.Add("IsRepeatable", typeof(bool));
				dataTable.Columns.Add("IsActive", typeof(bool));
				dataTable.Columns.Add("IsShown", typeof(bool));
				dataTable.Columns.Add("Probability", typeof(short));
				try
				{
					foreach (SimEvent simEvent in Enumerable.OrderBy<SimEvent, string>(Client.smethod_46().vmethod_10().Values, (ListEvents._Closure$__.$I47-0 == null) ? (ListEvents._Closure$__.$I47-0 = new Func<SimEvent, string>(ListEvents._Closure$__.$I.method_0)) : ListEvents._Closure$__.$I47-0))
					{
						DataRow dataRow = dataTable.NewRow();
						dataRow["ID"] = simEvent.string_0;
						dataRow["Description"] = simEvent.string_2;
						dataRow["IsRepeatable"] = simEvent.bool_11;
						dataRow["IsActive"] = simEvent.bool_12;
						dataRow["IsShown"] = simEvent.bool_13;
						dataRow["Probability"] = simEvent.short_0;
						dataTable.Rows.Add(dataRow);
					}
				}
				finally
				{
					IEnumerator<SimEvent> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				this.vmethod_0().DataSource = dataTable;
				this.vmethod_0().Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				this.vmethod_0().ResumeLayout();
				this.bool_3 = false;
				if (!string.IsNullOrEmpty(this.string_0))
				{
					try
					{
						foreach (object obj in ((IEnumerable)this.vmethod_0().Rows))
						{
							object objectValue = RuntimeHelpers.GetObjectValue(obj);
							if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"ID"
							}, null, null, null), null, "Value", new object[0], null, null, null), this.string_0, false))
							{
								this.vmethod_0().CurrentCell = (DataGridViewCell)NewLateBinding.LateGet(objectValue, null, "cells", new object[]
								{
									1
								}, null, null, null);
								break;
							}
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
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200102", ex.Message);
				GameGeneral.smethod_25(ref ex);
				this.method_3();
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060079A0 RID: 31136 RVA: 0x00421C1C File Offset: 0x0041FE1C
		private void method_4(object sender, EventArgs e)
		{
			SimEvent simEvent_ = new SimEvent();
			this.editEvent_0 = new EditEvent();
			this.editEvent_0.method_4(simEvent_);
			this.editEvent_0.enum206_0 = EditEvent.Enum206.const_0;
			this.editEvent_0.Show();
		}

		// Token: 0x060079A1 RID: 31137 RVA: 0x00421C60 File Offset: 0x0041FE60
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				SimEvent simEvent_ = Client.smethod_46().vmethod_10()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)];
				this.editEvent_0 = new EditEvent();
				this.editEvent_0.method_4(simEvent_);
				this.editEvent_0.enum206_0 = EditEvent.Enum206.const_1;
				this.editEvent_0.Show();
			}
		}

		// Token: 0x060079A2 RID: 31138 RVA: 0x00421CE8 File Offset: 0x0041FEE8
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				SimEvent simEvent = Client.smethod_46().vmethod_10()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)];
				Client.smethod_46().vmethod_10().Remove(simEvent.string_0);
				this.method_3();
			}
		}

		// Token: 0x060079A3 RID: 31139 RVA: 0x0004B0C9 File Offset: 0x000492C9
		private void ListEvents_Shown(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x060079A4 RID: 31140 RVA: 0x003B6260 File Offset: 0x003B4460
		private void ListEvents_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x060079A5 RID: 31141 RVA: 0x00044820 File Offset: 0x00042A20
		private void ListEvents_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x060079A6 RID: 31142 RVA: 0x00421D60 File Offset: 0x0041FF60
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				SimEvent simEvent = Client.smethod_46().vmethod_10()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)].method_10();
				Client.smethod_46().vmethod_10().Add(simEvent.string_0, simEvent);
				this.method_3();
			}
		}

		// Token: 0x060079A7 RID: 31143 RVA: 0x00421DDC File Offset: 0x0041FFDC
		private void method_8(object sender, EventArgs e)
		{
			if (!this.bool_3 && this.vmethod_0().SelectedRows.Count != 0)
			{
				this.string_0 = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
			}
		}

		// Token: 0x060079A8 RID: 31144 RVA: 0x00044489 File Offset: 0x00042689
		private void ListEvents_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x060079A9 RID: 31145 RVA: 0x00421E34 File Offset: 0x00420034
		private void method_9(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				DataGridViewColumn dataGridViewColumn = this.vmethod_0().Columns[e.ColumnIndex];
				if (dataGridViewColumn.CellType == typeof(DataGridViewCheckBoxCell))
				{
					DataGridViewCheckBoxCell dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)this.vmethod_0().Rows[e.RowIndex].Cells[e.ColumnIndex];
					string key = Conversions.ToString(this.vmethod_0().Rows[e.RowIndex].Cells["ID"].Value);
					SimEvent simEvent = Client.smethod_46().vmethod_10()[key];
					dataGridViewCheckBoxCell.Value = Operators.NotObject(dataGridViewCheckBoxCell.Value);
					string name = dataGridViewColumn.Name;
					if (Operators.CompareString(name, "IsRepeatable", false) == 0)
					{
						simEvent.bool_11 = Conversions.ToBoolean(dataGridViewCheckBoxCell.Value);
						return;
					}
					if (Operators.CompareString(name, "IsActive", false) == 0)
					{
						simEvent.bool_12 = Conversions.ToBoolean(dataGridViewCheckBoxCell.Value);
						return;
					}
					if (Operators.CompareString(name, "IsShown", false) != 0)
					{
						return;
					}
					simEvent.bool_13 = Conversions.ToBoolean(dataGridViewCheckBoxCell.Value);
				}
			}
		}

		// Token: 0x060079AA RID: 31146 RVA: 0x00421C60 File Offset: 0x0041FE60
		private void method_10(object sender, DataGridViewCellEventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				SimEvent simEvent_ = Client.smethod_46().vmethod_10()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)];
				this.editEvent_0 = new EditEvent();
				this.editEvent_0.method_4(simEvent_);
				this.editEvent_0.enum206_0 = EditEvent.Enum206.const_1;
				this.editEvent_0.Show();
			}
		}

		// Token: 0x040043EB RID: 17387
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridView1")]
		private Class114 class114_0;

		// Token: 0x040043EC RID: 17388
		[CompilerGenerated]
		[AccessedThroughProperty("Button_EditSelected")]
		private Control9 control9_0;

		// Token: 0x040043ED RID: 17389
		[CompilerGenerated]
		[AccessedThroughProperty("Button_DeleteSelected")]
		private Control9 control9_1;

		// Token: 0x040043EE RID: 17390
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_2;

		// Token: 0x040043EF RID: 17391
		[CompilerGenerated]
		[AccessedThroughProperty("ID")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x040043F0 RID: 17392
		[CompilerGenerated]
		[AccessedThroughProperty("Description")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x040043F1 RID: 17393
		[CompilerGenerated]
		[AccessedThroughProperty("IsRepeatable")]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x040043F2 RID: 17394
		[CompilerGenerated]
		[AccessedThroughProperty("IsActive")]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		// Token: 0x040043F3 RID: 17395
		[CompilerGenerated]
		[AccessedThroughProperty("Probability")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x040043F4 RID: 17396
		[AccessedThroughProperty("Button_CloneSelected")]
		[CompilerGenerated]
		private Control9 control9_3;

		// Token: 0x040043F5 RID: 17397
		private EditEvent editEvent_0;

		// Token: 0x040043F6 RID: 17398
		private string string_0;

		// Token: 0x040043F7 RID: 17399
		private bool bool_3;
	}
}
