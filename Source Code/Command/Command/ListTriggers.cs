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
using ns11;
using ns2;
using ns3;
using ns4;
using ns5;
using ns6;

namespace Command
{
	// Token: 0x02000EBC RID: 3772
	[DesignerGenerated]
	public sealed partial class ListTriggers : DarkSecondaryFormBase
	{
		// Token: 0x060079AE RID: 31150 RVA: 0x00421F64 File Offset: 0x00420164
		public ListTriggers()
		{
			base.Shown += this.ListTriggers_Shown;
			base.KeyDown += this.ListTriggers_KeyDown;
			base.FormClosing += this.ListTriggers_FormClosing;
			base.Load += this.ListTriggers_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x060079B0 RID: 31152 RVA: 0x00422008 File Offset: 0x00420208
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_1(new Class114());
			this.vmethod_11(new DataGridViewTextBoxColumn());
			this.vmethod_13(new DataGridViewTextBoxColumn());
			this.vmethod_3(new Control9());
			this.vmethod_5(new Control9());
			this.vmethod_7(new Control9());
			this.vmethod_9(new Class2451());
			this.vmethod_15(new Control9());
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
			dataGridViewCellStyle.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_0().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_0().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_10(),
				this.vmethod_12()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9f);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_0().EnableHeadersVisualStyles = false;
			this.vmethod_0().Location = new Point(3, 3);
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
			this.vmethod_0().Size = new Size(655, 365);
			this.vmethod_0().TabIndex = 2;
			this.vmethod_10().DataPropertyName = "ID";
			this.vmethod_10().HeaderText = "ID";
			this.vmethod_10().Name = "ID";
			this.vmethod_10().ReadOnly = true;
			this.vmethod_10().Visible = false;
			this.vmethod_12().DataPropertyName = "Description";
			this.vmethod_12().HeaderText = "Description";
			this.vmethod_12().Name = "Description";
			this.vmethod_12().ReadOnly = true;
			this.vmethod_12().Width = 612;
			this.vmethod_2().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DialogResult = DialogResult.None;
			this.vmethod_2().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_2().ForeColor = SystemColors.Control;
			this.vmethod_2().Location = new Point(455, 370);
			this.vmethod_2().Name = "Button_EditSelected";
			this.vmethod_2().method_1(0);
			this.vmethod_2().Size = new Size(98, 21);
			this.vmethod_2().TabIndex = 10;
			this.vmethod_2().Text = "Edit selected";
			this.vmethod_4().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(559, 370);
			this.vmethod_4().Name = "Button_DeleteSelected";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(99, 21);
			this.vmethod_4().TabIndex = 9;
			this.vmethod_4().Text = "Delete selected";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.None;
			this.vmethod_6().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_6().ForeColor = SystemColors.Control;
			this.vmethod_6().Location = new Point(3, 370);
			this.vmethod_6().Name = "Button1";
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(106, 21);
			this.vmethod_6().TabIndex = 8;
			this.vmethod_6().Text = "Create new trigger:";
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_8().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_8().Font = new Font("Segoe UI", 7f);
			this.vmethod_8().FormattingEnabled = true;
			this.vmethod_8().Items.AddRange(new object[]
			{
				"Unit Is Destroyed",
				"Unit Is Damaged",
				"Side Points",
				"Time",
				"Unit Remains In Area",
				"Unit Enters Area",
				"Random Time",
				"Unit is Detected",
				"Scenario is Loaded",
				"Regular Time",
				"Scenario has Ended"
			});
			this.vmethod_8().Location = new Point(115, 370);
			this.vmethod_8().Name = "CB_TriggerType";
			this.vmethod_8().Size = new Size(173, 21);
			this.vmethod_8().TabIndex = 11;
			this.vmethod_14().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_14().BackColor = Color.Transparent;
			this.vmethod_14().DialogResult = DialogResult.None;
			this.vmethod_14().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_14().ForeColor = SystemColors.Control;
			this.vmethod_14().Location = new Point(342, 370);
			this.vmethod_14().Name = "Button_CloneSelected";
			this.vmethod_14().method_1(0);
			this.vmethod_14().Size = new Size(107, 21);
			this.vmethod_14().TabIndex = 12;
			this.vmethod_14().Text = "Clone selected";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(661, 397);
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ListTriggers";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Event Triggers";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x060079B1 RID: 31153 RVA: 0x0004B0E5 File Offset: 0x000492E5
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x060079B2 RID: 31154 RVA: 0x00422884 File Offset: 0x00420A84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class114 class114_1)
		{
			EventHandler value = new EventHandler(this.method_8);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_9);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.SelectionChanged -= value;
				@class.CellDoubleClick -= value2;
			}
			this.class114_0 = class114_1;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.SelectionChanged += value;
				@class.CellDoubleClick += value2;
			}
		}

		// Token: 0x060079B3 RID: 31155 RVA: 0x0004B0ED File Offset: 0x000492ED
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_0;
		}

		// Token: 0x060079B4 RID: 31156 RVA: 0x004228E4 File Offset: 0x00420AE4
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

		// Token: 0x060079B5 RID: 31157 RVA: 0x0004B0F5 File Offset: 0x000492F5
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_1;
		}

		// Token: 0x060079B6 RID: 31158 RVA: 0x00422928 File Offset: 0x00420B28
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

		// Token: 0x060079B7 RID: 31159 RVA: 0x0004B0FD File Offset: 0x000492FD
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_2;
		}

		// Token: 0x060079B8 RID: 31160 RVA: 0x0042296C File Offset: 0x00420B6C
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

		// Token: 0x060079B9 RID: 31161 RVA: 0x0004B105 File Offset: 0x00049305
		[CompilerGenerated]
		internal Class2451 vmethod_8()
		{
			return this.class2451_0;
		}

		// Token: 0x060079BA RID: 31162 RVA: 0x0004B10D File Offset: 0x0004930D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class2451 class2451_1)
		{
			this.class2451_0 = class2451_1;
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x0004B116 File Offset: 0x00049316
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_10()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x060079BC RID: 31164 RVA: 0x0004B11E File Offset: 0x0004931E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060079BD RID: 31165 RVA: 0x0004B127 File Offset: 0x00049327
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_12()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x060079BE RID: 31166 RVA: 0x0004B12F File Offset: 0x0004932F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x0004B138 File Offset: 0x00049338
		[CompilerGenerated]
		internal Control9 vmethod_14()
		{
			return this.control9_3;
		}

		// Token: 0x060079C0 RID: 31168 RVA: 0x004229B0 File Offset: 0x00420BB0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Control9 control9_4)
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

		// Token: 0x060079C1 RID: 31169 RVA: 0x004229F4 File Offset: 0x00420BF4
		public void method_3()
		{
			try
			{
				this.bool_3 = true;
				this.vmethod_0().SuspendLayout();
				DataTable dataTable = new DataTable();
				dataTable.Columns.Add("ID", typeof(string));
				dataTable.Columns.Add("Description", typeof(string));
				try
				{
					foreach (EventTrigger eventTrigger in Enumerable.OrderBy<EventTrigger, string>(Client.smethod_46().vmethod_4().Values, (ListTriggers._Closure$__.$I39-0 == null) ? (ListTriggers._Closure$__.$I39-0 = new Func<EventTrigger, string>(ListTriggers._Closure$__.$I.method_0)) : ListTriggers._Closure$__.$I39-0))
					{
						DataRow dataRow = dataTable.NewRow();
						dataRow["ID"] = eventTrigger.string_0;
						dataRow["Description"] = eventTrigger.string_2;
						dataTable.Rows.Add(dataRow);
					}
				}
				finally
				{
					IEnumerator<EventTrigger> enumerator;
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
				this.method_3();
				ex.Data.Add("Error at 200382", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060079C2 RID: 31170 RVA: 0x00422C6C File Offset: 0x00420E6C
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_8().SelectedIndex > -1)
			{
				EventTrigger eventTrigger = null;
				switch (this.vmethod_8().SelectedIndex)
				{
				case 0:
					eventTrigger = new Class337();
					break;
				case 1:
					eventTrigger = new Class336();
					break;
				case 2:
					eventTrigger = new Class334();
					break;
				case 3:
					eventTrigger = new Class335(Client.smethod_46().method_31().AddMinutes(30.0));
					break;
				case 4:
					eventTrigger = new Class333();
					break;
				case 5:
					eventTrigger = new Class332();
					((Class332)eventTrigger).dateTime_0 = Client.smethod_46().method_31();
					((Class332)eventTrigger).dateTime_1 = ((Class332)eventTrigger).dateTime_0.AddYears(1);
					break;
				case 6:
					eventTrigger = new Class327(Client.smethod_46().method_31().AddMinutes(30.0), Client.smethod_46().method_31().AddMinutes(120.0));
					break;
				case 7:
					eventTrigger = new Class329();
					break;
				case 8:
					eventTrigger = new Class326();
					break;
				case 9:
					eventTrigger = new EventTrigger_RegularTime();
					break;
				case 10:
					if (Client.smethod_46().method_16())
					{
						eventTrigger = new Class326();
					}
					break;
				case 11:
					eventTrigger = new Class328();
					break;
				case 12:
					eventTrigger = new Class331();
					break;
				case 13:
					eventTrigger = new Class330();
					break;
				default:
					if (Debugger.IsAttached)
					{
						Debugger.Break();
						return;
					}
					return;
				}
				if (this.vmethod_8().SelectedIndex == 8)
				{
					Class326 @class = new Class326();
					@class.string_2 = "Scenario is Loaded";
					Client.smethod_46().vmethod_4().Add(@class.string_0, @class);
					this.method_3();
					return;
				}
				if (this.vmethod_8().SelectedIndex == 10)
				{
					Class325 class2 = new Class325();
					class2.string_2 = "Campaign Scenario has Ended";
					Client.smethod_46().vmethod_4().Add(class2.string_0, class2);
					this.method_3();
					return;
				}
				this.editTrigger_0 = new EditTrigger();
				this.editTrigger_0.eventTrigger_0 = eventTrigger;
				this.editTrigger_0.enum207_0 = EditTrigger.Enum207.const_0;
				this.editTrigger_0.Show();
			}
		}

		// Token: 0x060079C3 RID: 31171 RVA: 0x00422EA0 File Offset: 0x004210A0
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				EventTrigger eventTrigger_ = Client.smethod_46().vmethod_4()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)];
				this.editTrigger_0 = new EditTrigger();
				this.editTrigger_0.eventTrigger_0 = eventTrigger_;
				this.editTrigger_0.enum207_0 = EditTrigger.Enum207.const_1;
				this.editTrigger_0.Show();
			}
		}

		// Token: 0x060079C4 RID: 31172 RVA: 0x00422F28 File Offset: 0x00421128
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				EventTrigger eventTrigger = Client.smethod_46().vmethod_4()[key];
				if (!Information.IsNothing(eventTrigger))
				{
					bool flag = false;
					try
					{
						IEnumerator<SimEvent> enumerator = Client.smethod_46().vmethod_10().Values.GetEnumerator();
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.list_0.Contains(eventTrigger))
							{
								flag = true;
								break;
							}
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
					if (!flag || DarkMessageBox.smethod_1("This trigger is used by at least one event, are you sure you want to delete it?", "Trigger is in use!", Enum11.const_3) != DialogResult.No)
					{
						Client.smethod_46().vmethod_4().Remove(eventTrigger.string_0);
						try
						{
							foreach (SimEvent simEvent in Client.smethod_46().vmethod_10().Values)
							{
								simEvent.list_0.Remove(eventTrigger);
							}
						}
						finally
						{
							IEnumerator<SimEvent> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						this.method_3();
					}
				}
			}
		}

		// Token: 0x060079C5 RID: 31173 RVA: 0x0004B140 File Offset: 0x00049340
		private void ListTriggers_Shown(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x060079C6 RID: 31174 RVA: 0x003B6260 File Offset: 0x003B4460
		private void ListTriggers_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x060079C7 RID: 31175 RVA: 0x00044820 File Offset: 0x00042A20
		private void ListTriggers_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x060079C8 RID: 31176 RVA: 0x00423068 File Offset: 0x00421268
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				EventTrigger eventTrigger = Client.smethod_46().vmethod_4()[key].vmethod_5();
				Client.smethod_46().vmethod_4().Add(eventTrigger.string_0, eventTrigger);
				this.method_3();
			}
		}

		// Token: 0x060079C9 RID: 31177 RVA: 0x004230E4 File Offset: 0x004212E4
		private void method_8(object sender, EventArgs e)
		{
			if (!this.bool_3 && this.vmethod_0().SelectedRows.Count != 0)
			{
				this.string_0 = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
			}
		}

		// Token: 0x060079CA RID: 31178 RVA: 0x00044489 File Offset: 0x00042689
		private void ListTriggers_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x060079CB RID: 31179 RVA: 0x00422EA0 File Offset: 0x004210A0
		private void method_9(object sender, DataGridViewCellEventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				EventTrigger eventTrigger_ = Client.smethod_46().vmethod_4()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)];
				this.editTrigger_0 = new EditTrigger();
				this.editTrigger_0.eventTrigger_0 = eventTrigger_;
				this.editTrigger_0.enum207_0 = EditTrigger.Enum207.const_1;
				this.editTrigger_0.Show();
			}
		}

		// Token: 0x040043FB RID: 17403
		[AccessedThroughProperty("DataGridView1")]
		[CompilerGenerated]
		private Class114 class114_0;

		// Token: 0x040043FC RID: 17404
		[AccessedThroughProperty("Button_EditSelected")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x040043FD RID: 17405
		[CompilerGenerated]
		[AccessedThroughProperty("Button_DeleteSelected")]
		private Control9 control9_1;

		// Token: 0x040043FE RID: 17406
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_2;

		// Token: 0x040043FF RID: 17407
		[CompilerGenerated]
		[AccessedThroughProperty("CB_TriggerType")]
		private Class2451 class2451_0;

		// Token: 0x04004400 RID: 17408
		[AccessedThroughProperty("ID")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04004401 RID: 17409
		[AccessedThroughProperty("Description")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04004402 RID: 17410
		[AccessedThroughProperty("Button_CloneSelected")]
		[CompilerGenerated]
		private Control9 control9_3;

		// Token: 0x04004403 RID: 17411
		private EditTrigger editTrigger_0;

		// Token: 0x04004404 RID: 17412
		private string string_0;

		// Token: 0x04004405 RID: 17413
		private bool bool_3;
	}
}
