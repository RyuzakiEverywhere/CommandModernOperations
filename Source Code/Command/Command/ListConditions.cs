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
using ns11;
using ns2;
using ns3;
using ns4;
using ns5;
using ns9;

namespace Command
{
	// Token: 0x02000EB8 RID: 3768
	[DesignerGenerated]
	public sealed partial class ListConditions : DarkSecondaryFormBase
	{
		// Token: 0x06007967 RID: 31079 RVA: 0x0041FE6C File Offset: 0x0041E06C
		public ListConditions()
		{
			base.Shown += this.ListConditions_Shown;
			base.KeyDown += this.ListConditions_KeyDown;
			base.FormClosing += this.ListConditions_FormClosing;
			base.Load += this.ListConditions_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x06007969 RID: 31081 RVA: 0x0041FF10 File Offset: 0x0041E110
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
				"Side Posture",
				"Scenario Has Started",
				"Lua Script"
			});
			this.vmethod_6().Location = new Point(115, 370);
			this.vmethod_6().Name = "CB_ConditionType";
			this.vmethod_6().Size = new Size(173, 21);
			this.vmethod_6().TabIndex = 15;
			this.vmethod_8().Anchor = AnchorStyles.Bottom;
			this.vmethod_8().BackColor = Color.Transparent;
			this.vmethod_8().DialogResult = DialogResult.None;
			this.vmethod_8().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_8().ForeColor = SystemColors.Control;
			this.vmethod_8().Location = new Point(435, 370);
			this.vmethod_8().Name = "Button_EditSelected";
			this.vmethod_8().method_1(0);
			this.vmethod_8().Size = new Size(107, 21);
			this.vmethod_8().TabIndex = 14;
			this.vmethod_8().Text = "Edit selected";
			this.vmethod_10().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().DialogResult = DialogResult.None;
			this.vmethod_10().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_10().ForeColor = SystemColors.Control;
			this.vmethod_10().Location = new Point(548, 370);
			this.vmethod_10().Name = "Button_DeleteSelected";
			this.vmethod_10().method_1(0);
			this.vmethod_10().Size = new Size(110, 21);
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
			this.vmethod_12().Text = "Create new:";
			this.vmethod_14().Anchor = AnchorStyles.Bottom;
			this.vmethod_14().BackColor = Color.Transparent;
			this.vmethod_14().DialogResult = DialogResult.None;
			this.vmethod_14().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_14().ForeColor = SystemColors.Control;
			this.vmethod_14().Location = new Point(318, 370);
			this.vmethod_14().Name = "Button_CloneSelected";
			this.vmethod_14().method_1(0);
			this.vmethod_14().Size = new Size(111, 21);
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
			base.Name = "ListConditions";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Event Conditions";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0600796A RID: 31082 RVA: 0x0004AFDD File Offset: 0x000491DD
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x0600796B RID: 31083 RVA: 0x00420744 File Offset: 0x0041E944
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

		// Token: 0x0600796C RID: 31084 RVA: 0x0004AFE5 File Offset: 0x000491E5
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_2()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x0600796D RID: 31085 RVA: 0x0004AFED File Offset: 0x000491ED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600796E RID: 31086 RVA: 0x0004AFF6 File Offset: 0x000491F6
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_4()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x0600796F RID: 31087 RVA: 0x0004AFFE File Offset: 0x000491FE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06007970 RID: 31088 RVA: 0x0004B007 File Offset: 0x00049207
		[CompilerGenerated]
		internal Class2451 vmethod_6()
		{
			return this.class2451_0;
		}

		// Token: 0x06007971 RID: 31089 RVA: 0x0004B00F File Offset: 0x0004920F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class2451 class2451_1)
		{
			this.class2451_0 = class2451_1;
		}

		// Token: 0x06007972 RID: 31090 RVA: 0x0004B018 File Offset: 0x00049218
		[CompilerGenerated]
		internal Control9 vmethod_8()
		{
			return this.control9_0;
		}

		// Token: 0x06007973 RID: 31091 RVA: 0x004207A4 File Offset: 0x0041E9A4
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

		// Token: 0x06007974 RID: 31092 RVA: 0x0004B020 File Offset: 0x00049220
		[CompilerGenerated]
		internal Control9 vmethod_10()
		{
			return this.control9_1;
		}

		// Token: 0x06007975 RID: 31093 RVA: 0x004207E8 File Offset: 0x0041E9E8
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

		// Token: 0x06007976 RID: 31094 RVA: 0x0004B028 File Offset: 0x00049228
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_2;
		}

		// Token: 0x06007977 RID: 31095 RVA: 0x0042082C File Offset: 0x0041EA2C
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

		// Token: 0x06007978 RID: 31096 RVA: 0x0004B030 File Offset: 0x00049230
		[CompilerGenerated]
		internal Control9 vmethod_14()
		{
			return this.control9_3;
		}

		// Token: 0x06007979 RID: 31097 RVA: 0x00420870 File Offset: 0x0041EA70
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

		// Token: 0x0600797A RID: 31098 RVA: 0x004208B4 File Offset: 0x0041EAB4
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
					foreach (EventCondition eventCondition in Enumerable.OrderBy<EventCondition, string>(Client.smethod_46().vmethod_6().Values, (ListConditions._Closure$__.$I39-0 == null) ? (ListConditions._Closure$__.$I39-0 = new Func<EventCondition, string>(ListConditions._Closure$__.$I.method_0)) : ListConditions._Closure$__.$I39-0))
					{
						DataRow dataRow = dataTable.NewRow();
						dataRow["ID"] = eventCondition.string_0;
						dataRow["Description"] = eventCondition.string_2;
						dataTable.Rows.Add(dataRow);
					}
				}
				finally
				{
					IEnumerator<EventCondition> enumerator;
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
				ex.Data.Add("Error at 200105", ex.Message);
				GameGeneral.smethod_25(ref ex);
				this.method_3();
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600797B RID: 31099 RVA: 0x00420B10 File Offset: 0x0041ED10
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_6().SelectedIndex > -1)
			{
				EventCondition eventCondition_;
				switch (this.vmethod_6().SelectedIndex)
				{
				case 0:
					eventCondition_ = new Class324();
					break;
				case 1:
					eventCondition_ = new Class323();
					break;
				case 2:
					eventCondition_ = new Class322();
					break;
				default:
					if (Debugger.IsAttached)
					{
						Debugger.Break();
						return;
					}
					return;
				}
				this.editCondition_0 = new EditCondition();
				this.editCondition_0.eventCondition_0 = eventCondition_;
				this.editCondition_0.enum205_0 = EditCondition.Enum205.const_0;
				this.editCondition_0.Show();
			}
		}

		// Token: 0x0600797C RID: 31100 RVA: 0x00420B9C File Offset: 0x0041ED9C
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				EventCondition eventCondition_ = Client.smethod_46().vmethod_6()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)];
				this.editCondition_0 = new EditCondition();
				this.editCondition_0.eventCondition_0 = eventCondition_;
				this.editCondition_0.enum205_0 = EditCondition.Enum205.const_1;
				this.editCondition_0.Show();
			}
		}

		// Token: 0x0600797D RID: 31101 RVA: 0x00420C24 File Offset: 0x0041EE24
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				EventCondition eventCondition = Client.smethod_46().vmethod_6()[key];
				if (!Information.IsNothing(eventCondition))
				{
					bool flag = false;
					try
					{
						IEnumerator<SimEvent> enumerator = Client.smethod_46().vmethod_10().Values.GetEnumerator();
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.list_1.Contains(eventCondition))
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
					if (!flag || DarkMessageBox.smethod_1("This condition is used by at least one event, are you sure you want to delete it?", "Condition is in use!", Enum11.const_3) != DialogResult.No)
					{
						Client.smethod_46().vmethod_6().Remove(eventCondition.string_0);
						try
						{
							foreach (SimEvent simEvent in Client.smethod_46().vmethod_10().Values)
							{
								simEvent.list_1.Remove(eventCondition);
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

		// Token: 0x0600797E RID: 31102 RVA: 0x0004B038 File Offset: 0x00049238
		private void ListConditions_Shown(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x0600797F RID: 31103 RVA: 0x003B6260 File Offset: 0x003B4460
		private void ListConditions_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06007980 RID: 31104 RVA: 0x00044820 File Offset: 0x00042A20
		private void ListConditions_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06007981 RID: 31105 RVA: 0x00420D64 File Offset: 0x0041EF64
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				EventCondition eventCondition = Client.smethod_46().vmethod_6()[key].vmethod_6();
				Client.smethod_46().vmethod_6().Add(eventCondition.string_0, eventCondition);
				this.method_3();
			}
		}

		// Token: 0x06007982 RID: 31106 RVA: 0x00420DE0 File Offset: 0x0041EFE0
		private void method_8(object sender, EventArgs e)
		{
			if (!this.bool_3 && this.vmethod_0().SelectedRows.Count != 0)
			{
				this.string_0 = Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
			}
		}

		// Token: 0x06007983 RID: 31107 RVA: 0x00044489 File Offset: 0x00042689
		private void ListConditions_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x06007984 RID: 31108 RVA: 0x00420B9C File Offset: 0x0041ED9C
		private void method_9(object sender, DataGridViewCellEventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				EventCondition eventCondition_ = Client.smethod_46().vmethod_6()[Conversions.ToString(this.vmethod_0().SelectedRows[0].Cells["ID"].Value)];
				this.editCondition_0 = new EditCondition();
				this.editCondition_0.eventCondition_0 = eventCondition_;
				this.editCondition_0.enum205_0 = EditCondition.Enum205.const_1;
				this.editCondition_0.Show();
			}
		}

		// Token: 0x040043DD RID: 17373
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridView1")]
		private Class114 class114_0;

		// Token: 0x040043DE RID: 17374
		[AccessedThroughProperty("ID")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x040043DF RID: 17375
		[CompilerGenerated]
		[AccessedThroughProperty("Description")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x040043E0 RID: 17376
		[CompilerGenerated]
		[AccessedThroughProperty("CB_ConditionType")]
		private Class2451 class2451_0;

		// Token: 0x040043E1 RID: 17377
		[CompilerGenerated]
		[AccessedThroughProperty("Button_EditSelected")]
		private Control9 control9_0;

		// Token: 0x040043E2 RID: 17378
		[CompilerGenerated]
		[AccessedThroughProperty("Button_DeleteSelected")]
		private Control9 control9_1;

		// Token: 0x040043E3 RID: 17379
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_2;

		// Token: 0x040043E4 RID: 17380
		[AccessedThroughProperty("Button_CloneSelected")]
		[CompilerGenerated]
		private Control9 control9_3;

		// Token: 0x040043E5 RID: 17381
		private EditCondition editCondition_0;

		// Token: 0x040043E6 RID: 17382
		private string string_0;

		// Token: 0x040043E7 RID: 17383
		private bool bool_3;
	}
}
