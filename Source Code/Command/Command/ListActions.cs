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
using ns2;
using ns3;
using ns4;
using ns5;
using ns9;

namespace Command
{
	// Token: 0x02000EB6 RID: 3766
	[DesignerGenerated]
	public sealed partial class ListActions : DarkSecondaryFormBase
	{
		// Token: 0x06007946 RID: 31046 RVA: 0x0041EE54 File Offset: 0x0041D054
		public ListActions()
		{
			base.Shown += this.ListActions_Shown;
			base.KeyDown += this.ListActions_KeyDown;
			base.FormClosing += this.ListActions_FormClosing;
			base.Load += this.ListActions_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x06007948 RID: 31048 RVA: 0x0041EEF8 File Offset: 0x0041D0F8
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_1(new Class114());
			this.vmethod_3(new DataGridViewTextBoxColumn());
			this.vmethod_5(new DataGridViewTextBoxColumn());
			this.vmethod_7(new Class2451());
			this.vmethod_9(new Control9());
			this.vmethod_11(new Control9());
			this.vmethod_13(new Control9());
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
				this.vmethod_2(),
				this.vmethod_4()
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
			this.vmethod_0().RowHeadersVisible = false;
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
			this.vmethod_0().TabIndex = 3;
			this.vmethod_2().DataPropertyName = "ID";
			this.vmethod_2().HeaderText = "ID";
			this.vmethod_2().Name = "ID";
			this.vmethod_2().ReadOnly = true;
			this.vmethod_2().Visible = false;
			this.vmethod_4().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_4().DataPropertyName = "Description";
			this.vmethod_4().HeaderText = "Description";
			this.vmethod_4().Name = "Description";
			this.vmethod_4().ReadOnly = true;
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_6().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_6().Font = new Font("Segoe UI", 7f);
			this.vmethod_6().FormattingEnabled = true;
			this.vmethod_6().Items.AddRange(new object[]
			{
				"Points",
				"End Scenario",
				"Teleport to Area",
				"Message",
				"Change Mission Status",
				"Lua Script"
			});
			this.vmethod_6().Location = new Point(115, 370);
			this.vmethod_6().Name = "CB_ActionType";
			this.vmethod_6().Size = new Size(173, 21);
			this.vmethod_6().TabIndex = 15;
			this.vmethod_8().Anchor = AnchorStyles.Bottom;
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().DialogResult = DialogResult.None;
			this.vmethod_8().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_8().ForeColor = SystemColors.Control;
			this.vmethod_8().Location = new Point(437, 370);
			this.vmethod_8().Name = "Button_EditSelected";
			this.vmethod_8().method_1(0);
			this.vmethod_8().Size = new Size(110, 21);
			this.vmethod_8().TabIndex = 14;
			this.vmethod_8().Text = "Edit selected";
			this.vmethod_10().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().DialogResult = DialogResult.None;
			this.vmethod_10().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_10().ForeColor = SystemColors.Control;
			this.vmethod_10().Location = new Point(553, 370);
			this.vmethod_10().Name = "Button_DeleteSelected";
			this.vmethod_10().method_1(0);
			this.vmethod_10().Size = new Size(105, 21);
			this.vmethod_10().TabIndex = 13;
			this.vmethod_10().Text = "Delete selected";
			this.vmethod_12().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_12().ForeColor = SystemColors.Control;
			this.vmethod_12().Location = new Point(3, 370);
			this.vmethod_12().Name = "Button1";
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new Size(106, 21);
			this.vmethod_12().TabIndex = 12;
			this.vmethod_12().Text = "Create new action:";
			this.vmethod_14().Anchor = AnchorStyles.Bottom;
			this.vmethod_14().BackColor = Color.Transparent;
			this.vmethod_14().DialogResult = DialogResult.None;
			this.vmethod_14().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_14().ForeColor = SystemColors.Control;
			this.vmethod_14().Location = new Point(315, 370);
			this.vmethod_14().Name = "Button_CloneSelected";
			this.vmethod_14().method_1(0);
			this.vmethod_14().Size = new Size(116, 21);
			this.vmethod_14().TabIndex = 16;
			this.vmethod_14().Text = "Clone selected";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(661, 397);
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ListActions";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Event Actions";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06007949 RID: 31049 RVA: 0x0004AF6E File Offset: 0x0004916E
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x0600794A RID: 31050 RVA: 0x0041F750 File Offset: 0x0041D950
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

		// Token: 0x0600794B RID: 31051 RVA: 0x0004AF76 File Offset: 0x00049176
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_2()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x0004AF7E File Offset: 0x0004917E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x0004AF87 File Offset: 0x00049187
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_4()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x0004AF8F File Offset: 0x0004918F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600794F RID: 31055 RVA: 0x0004AF98 File Offset: 0x00049198
		[CompilerGenerated]
		internal Class2451 vmethod_6()
		{
			return this.class2451_0;
		}

		// Token: 0x06007950 RID: 31056 RVA: 0x0004AFA0 File Offset: 0x000491A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class2451 class2451_1)
		{
			this.class2451_0 = class2451_1;
		}

		// Token: 0x06007951 RID: 31057 RVA: 0x0004AFA9 File Offset: 0x000491A9
		[CompilerGenerated]
		internal Control9 vmethod_8()
		{
			return this.control9_0;
		}

		// Token: 0x06007952 RID: 31058 RVA: 0x0041F7B0 File Offset: 0x0041D9B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Control9 control9_4)
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

		// Token: 0x06007953 RID: 31059 RVA: 0x0004AFB1 File Offset: 0x000491B1
		[CompilerGenerated]
		internal Control9 vmethod_10()
		{
			return this.control9_1;
		}

		// Token: 0x06007954 RID: 31060 RVA: 0x0041F7F4 File Offset: 0x0041D9F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control9 control9_4)
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

		// Token: 0x06007955 RID: 31061 RVA: 0x0004AFB9 File Offset: 0x000491B9
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_2;
		}

		// Token: 0x06007956 RID: 31062 RVA: 0x0041F838 File Offset: 0x0041DA38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_4)
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

		// Token: 0x06007957 RID: 31063 RVA: 0x0004AFC1 File Offset: 0x000491C1
		[CompilerGenerated]
		internal Control9 vmethod_14()
		{
			return this.control9_3;
		}

		// Token: 0x06007958 RID: 31064 RVA: 0x0041F87C File Offset: 0x0041DA7C
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

		// Token: 0x06007959 RID: 31065 RVA: 0x0041F8C0 File Offset: 0x0041DAC0
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
					foreach (EventAction eventAction in Enumerable.OrderBy<EventAction, string>(Client.smethod_46().vmethod_8().Values, (ListActions._Closure$__.$I39-0 == null) ? (ListActions._Closure$__.$I39-0 = new Func<EventAction, string>(ListActions._Closure$__.$I.method_0)) : ListActions._Closure$__.$I39-0))
					{
						DataRow dataRow = dataTable.NewRow();
						dataRow["ID"] = eventAction.string_0;
						dataRow["Description"] = eventAction.string_2;
						dataTable.Rows.Add(dataRow);
					}
				}
				finally
				{
					IEnumerator<EventAction> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				this.vmethod_0().DataSource = dataTable;
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
				ex.Data.Add("Error at 200380", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600795A RID: 31066 RVA: 0x0041FB1C File Offset: 0x0041DD1C
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_6().SelectedIndex > -1)
			{
				EventAction eventAction_;
				switch (this.vmethod_6().SelectedIndex)
				{
				case 0:
					eventAction_ = new Class321();
					break;
				case 1:
					eventAction_ = new Class320();
					break;
				case 2:
					eventAction_ = new EventAction_TeleportInArea();
					break;
				case 3:
					eventAction_ = new Class319();
					break;
				case 4:
					eventAction_ = new Class318();
					break;
				case 5:
					eventAction_ = new Class317();
					break;
				default:
					if (Debugger.IsAttached)
					{
						Debugger.Break();
						return;
					}
					return;
				}
				this.editAction_0 = new EditAction();
				this.editAction_0.eventAction_0 = eventAction_;
				this.editAction_0.enum204_0 = EditAction.Enum204.const_0;
				this.editAction_0.Show();
			}
		}

		// Token: 0x0600795B RID: 31067 RVA: 0x0041FBD0 File Offset: 0x0041DDD0
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				EventAction eventAction_ = Client.smethod_46().vmethod_8()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)];
				this.editAction_0 = new EditAction();
				this.editAction_0.eventAction_0 = eventAction_;
				this.editAction_0.enum204_0 = EditAction.Enum204.const_1;
				this.editAction_0.Show();
			}
		}

		// Token: 0x0600795C RID: 31068 RVA: 0x0041FC58 File Offset: 0x0041DE58
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				EventAction eventAction = Client.smethod_46().vmethod_8()[key];
				if (!Information.IsNothing(eventAction))
				{
					bool flag = false;
					try
					{
						IEnumerator<SimEvent> enumerator = Client.smethod_46().vmethod_10().Values.GetEnumerator();
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.list_2.Contains(eventAction))
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
					if (!flag || DarkMessageBox.smethod_1("This action is used by at least one event, are you sure you want to delete it?", "Action is in use!", Enum11.const_3) != DialogResult.No)
					{
						Client.smethod_46().vmethod_8().Remove(eventAction.string_0);
						try
						{
							foreach (SimEvent simEvent in Client.smethod_46().vmethod_10().Values)
							{
								simEvent.list_2.Remove(eventAction);
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

		// Token: 0x0600795D RID: 31069 RVA: 0x0004AFC9 File Offset: 0x000491C9
		private void ListActions_Shown(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x0600795E RID: 31070 RVA: 0x003B6260 File Offset: 0x003B4460
		private void ListActions_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x0600795F RID: 31071 RVA: 0x00044820 File Offset: 0x00042A20
		private void ListActions_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06007960 RID: 31072 RVA: 0x0041FD98 File Offset: 0x0041DF98
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				EventAction eventAction = Client.smethod_46().vmethod_8()[key].vmethod_6();
				Client.smethod_46().vmethod_8().Add(eventAction.string_0, eventAction);
				this.method_3();
			}
		}

		// Token: 0x06007961 RID: 31073 RVA: 0x0041FE14 File Offset: 0x0041E014
		private void method_8(object sender, EventArgs e)
		{
			if (!this.bool_3 && this.vmethod_0().SelectedRows.Count != 0)
			{
				this.string_0 = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
			}
		}

		// Token: 0x06007962 RID: 31074 RVA: 0x00044489 File Offset: 0x00042689
		private void ListActions_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x06007963 RID: 31075 RVA: 0x0041FBD0 File Offset: 0x0041DDD0
		private void method_9(object sender, DataGridViewCellEventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				EventAction eventAction_ = Client.smethod_46().vmethod_8()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)];
				this.editAction_0 = new EditAction();
				this.editAction_0.eventAction_0 = eventAction_;
				this.editAction_0.enum204_0 = EditAction.Enum204.const_1;
				this.editAction_0.Show();
			}
		}

		// Token: 0x040043CF RID: 17359
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridView1")]
		private Class114 class114_0;

		// Token: 0x040043D0 RID: 17360
		[AccessedThroughProperty("ID")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x040043D1 RID: 17361
		[CompilerGenerated]
		[AccessedThroughProperty("Description")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x040043D2 RID: 17362
		[AccessedThroughProperty("CB_ActionType")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x040043D3 RID: 17363
		[CompilerGenerated]
		[AccessedThroughProperty("Button_EditSelected")]
		private Control9 control9_0;

		// Token: 0x040043D4 RID: 17364
		[CompilerGenerated]
		[AccessedThroughProperty("Button_DeleteSelected")]
		private Control9 control9_1;

		// Token: 0x040043D5 RID: 17365
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_2;

		// Token: 0x040043D6 RID: 17366
		[CompilerGenerated]
		[AccessedThroughProperty("Button_CloneSelected")]
		private Control9 control9_3;

		// Token: 0x040043D7 RID: 17367
		private EditAction editAction_0;

		// Token: 0x040043D8 RID: 17368
		private string string_0;

		// Token: 0x040043D9 RID: 17369
		private bool bool_3;
	}
}
