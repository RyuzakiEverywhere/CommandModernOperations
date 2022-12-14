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
using ns2;
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000E78 RID: 3704
	[DesignerGenerated]
	public sealed partial class ListSpecialActions : DarkSecondaryFormBase
	{
		// Token: 0x060071AA RID: 29098 RVA: 0x003D1910 File Offset: 0x003CFB10
		public ListSpecialActions()
		{
			base.Shown += this.ListSpecialActions_Shown;
			base.KeyDown += this.ListSpecialActions_KeyDown;
			base.FormClosing += this.ListSpecialActions_FormClosing;
			base.Load += this.ListSpecialActions_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x060071AC RID: 29100 RVA: 0x003D19B4 File Offset: 0x003CFBB4
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_17(new Class114());
			this.vmethod_9(new DataGridViewTextBoxColumn());
			this.vmethod_11(new DataGridViewTextBoxColumn());
			this.vmethod_13(new DataGridViewCheckBoxColumn());
			this.vmethod_15(new DataGridViewCheckBoxColumn());
			this.vmethod_1(new Control9());
			this.vmethod_3(new Control9());
			this.vmethod_5(new Control9());
			this.vmethod_7(new Control9());
			this.vmethod_19(new Class116());
			((ISupportInitialize)this.vmethod_16()).BeginInit();
			base.SuspendLayout();
			this.vmethod_16().AllowUserToAddRows = false;
			this.vmethod_16().AllowUserToDeleteRows = false;
			this.vmethod_16().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_16().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_16().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_16().CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.vmethod_16().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font(Client.font_1.FontFamily, 8f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_16().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_16().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_16().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_8(),
				this.vmethod_10(),
				this.vmethod_12(),
				this.vmethod_14()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_16().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_16().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_16().EnableHeadersVisualStyles = false;
			this.vmethod_16().Location = new Point(3, 3);
			this.vmethod_16().MultiSelect = false;
			this.vmethod_16().Name = "DataGridView1";
			this.vmethod_16().ReadOnly = true;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_16().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_16().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_16().ShowCellToolTips = false;
			this.vmethod_16().ShowEditingIcon = false;
			this.vmethod_16().ShowRowErrors = false;
			this.vmethod_16().Size = new Size(496, 365);
			this.vmethod_16().TabIndex = 3;
			this.vmethod_8().DataPropertyName = "ID";
			this.vmethod_8().HeaderText = "ID";
			this.vmethod_8().Name = "ID";
			this.vmethod_8().ReadOnly = true;
			this.vmethod_8().Visible = false;
			this.vmethod_10().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_10().DataPropertyName = "Name";
			this.vmethod_10().HeaderText = "Name";
			this.vmethod_10().Name = "ActionName";
			this.vmethod_10().ReadOnly = true;
			this.vmethod_12().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_12().DataPropertyName = "IsActive";
			this.vmethod_12().HeaderText = "Is Active";
			this.vmethod_12().Name = "IsActive";
			this.vmethod_12().ReadOnly = true;
			this.vmethod_12().Width = 52;
			this.vmethod_14().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_14().DataPropertyName = "IsRepeatable";
			this.vmethod_14().HeaderText = "Is Repeatable";
			this.vmethod_14().Name = "IsRepeatable";
			this.vmethod_14().ReadOnly = true;
			this.vmethod_14().Width = 77;
			this.vmethod_0().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_0().BackColor = Color.Transparent;
			this.vmethod_0().DialogResult = DialogResult.None;
			this.vmethod_0().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_0().ForeColor = SystemColors.Control;
			this.vmethod_0().Location = new Point(276, 373);
			this.vmethod_0().Name = "Button_EditSelected";
			this.vmethod_0().method_1(0);
			this.vmethod_0().Size = new Size(110, 21);
			this.vmethod_0().TabIndex = 14;
			this.vmethod_0().Text = "Edit selected";
			this.vmethod_2().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DialogResult = DialogResult.None;
			this.vmethod_2().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_2().ForeColor = SystemColors.Control;
			this.vmethod_2().Location = new Point(392, 373);
			this.vmethod_2().Name = "Button_DeleteSelected";
			this.vmethod_2().method_1(0);
			this.vmethod_2().Size = new Size(105, 21);
			this.vmethod_2().TabIndex = 13;
			this.vmethod_2().Text = "Delete selected";
			this.vmethod_4().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_4().BackColor = Color.Transparent;
			this.vmethod_4().DialogResult = DialogResult.None;
			this.vmethod_4().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_4().ForeColor = SystemColors.Control;
			this.vmethod_4().Location = new Point(3, 373);
			this.vmethod_4().Name = "Button1";
			this.vmethod_4().method_1(0);
			this.vmethod_4().Size = new Size(145, 21);
			this.vmethod_4().TabIndex = 12;
			this.vmethod_4().Text = "Create new special action";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().DialogResult = DialogResult.None;
			this.vmethod_6().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_6().ForeColor = SystemColors.Control;
			this.vmethod_6().Location = new Point(154, 373);
			this.vmethod_6().Name = "Button_CloneSelected";
			this.vmethod_6().method_1(0);
			this.vmethod_6().Size = new Size(116, 21);
			this.vmethod_6().TabIndex = 16;
			this.vmethod_6().Text = "Clone selected";
			this.vmethod_18().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.vmethod_18().method_2(true);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(505, 3);
			this.vmethod_18().MaximumSize = new Size(185, 0);
			this.vmethod_18().Name = "Label_ActionDescription";
			this.vmethod_18().Size = new Size(39, 13);
			this.vmethod_18().TabIndex = 17;
			this.vmethod_18().Text = "Label1";
			this.vmethod_18().Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(693, 397);
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_16());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ListSpecialActions";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Special Actions for this side";
			((ISupportInitialize)this.vmethod_16()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060071AD RID: 29101 RVA: 0x000474FB File Offset: 0x000456FB
		[CompilerGenerated]
		internal Control9 vmethod_0()
		{
			return this.control9_0;
		}

		// Token: 0x060071AE RID: 29102 RVA: 0x003D22DC File Offset: 0x003D04DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control9 control9_4)
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

		// Token: 0x060071AF RID: 29103 RVA: 0x00047503 File Offset: 0x00045703
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_1;
		}

		// Token: 0x060071B0 RID: 29104 RVA: 0x003D2320 File Offset: 0x003D0520
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Control9 control9_4)
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

		// Token: 0x060071B1 RID: 29105 RVA: 0x0004750B File Offset: 0x0004570B
		[CompilerGenerated]
		internal Control9 vmethod_4()
		{
			return this.control9_2;
		}

		// Token: 0x060071B2 RID: 29106 RVA: 0x003D2364 File Offset: 0x003D0564
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control9 control9_4)
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

		// Token: 0x060071B3 RID: 29107 RVA: 0x00047513 File Offset: 0x00045713
		[CompilerGenerated]
		internal Control9 vmethod_6()
		{
			return this.control9_3;
		}

		// Token: 0x060071B4 RID: 29108 RVA: 0x003D23A8 File Offset: 0x003D05A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control9 control9_4)
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

		// Token: 0x060071B5 RID: 29109 RVA: 0x0004751B File Offset: 0x0004571B
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_8()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x060071B6 RID: 29110 RVA: 0x00047523 File Offset: 0x00045723
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060071B7 RID: 29111 RVA: 0x0004752C File Offset: 0x0004572C
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_10()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x060071B8 RID: 29112 RVA: 0x00047534 File Offset: 0x00045734
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060071B9 RID: 29113 RVA: 0x0004753D File Offset: 0x0004573D
		[CompilerGenerated]
		internal DataGridViewCheckBoxColumn vmethod_12()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x060071BA RID: 29114 RVA: 0x00047545 File Offset: 0x00045745
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x060071BB RID: 29115 RVA: 0x0004754E File Offset: 0x0004574E
		[CompilerGenerated]
		internal DataGridViewCheckBoxColumn vmethod_14()
		{
			return this.dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x060071BC RID: 29116 RVA: 0x00047556 File Offset: 0x00045756
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_1 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x060071BD RID: 29117 RVA: 0x0004755F File Offset: 0x0004575F
		[CompilerGenerated]
		internal Class114 vmethod_16()
		{
			return this.class114_0;
		}

		// Token: 0x060071BE RID: 29118 RVA: 0x003D23EC File Offset: 0x003D05EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class114 class114_1)
		{
			EventHandler value = new EventHandler(this.method_8);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_9);
			DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.method_10);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.SelectionChanged -= value;
				@class.CellClick -= value2;
				@class.CellDoubleClick -= value3;
			}
			this.class114_0 = class114_1;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.SelectionChanged += value;
				@class.CellClick += value2;
				@class.CellDoubleClick += value3;
			}
		}

		// Token: 0x060071BF RID: 29119 RVA: 0x00047567 File Offset: 0x00045767
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_0;
		}

		// Token: 0x060071C0 RID: 29120 RVA: 0x0004756F File Offset: 0x0004576F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x060071C1 RID: 29121 RVA: 0x003D2468 File Offset: 0x003D0668
		public void method_3()
		{
			if (Client.smethod_50() != null)
			{
				try
				{
					this.bool_3 = true;
					this.vmethod_16().SuspendLayout();
					DataTable dataTable = new DataTable();
					dataTable.Columns.Add("ID", typeof(string));
					dataTable.Columns.Add("Name", typeof(string));
					dataTable.Columns.Add("IsActive", typeof(string));
					dataTable.Columns.Add("IsRepeatable", typeof(string));
					try
					{
						foreach (SpecialAction specialAction in Enumerable.OrderBy<SpecialAction, string>(Client.smethod_50().dictionary_2.Values, (ListSpecialActions._Closure$__.$I47-0 == null) ? (ListSpecialActions._Closure$__.$I47-0 = new Func<SpecialAction, string>(ListSpecialActions._Closure$__.$I.method_0)) : ListSpecialActions._Closure$__.$I47-0))
						{
							DataRow dataRow = dataTable.NewRow();
							dataRow["ID"] = specialAction.string_0;
							dataRow["Name"] = specialAction.Name;
							dataRow["IsActive"] = specialAction.bool_11;
							dataRow["IsRepeatable"] = specialAction.bool_12;
							dataTable.Rows.Add(dataRow);
						}
					}
					finally
					{
						IEnumerator<SpecialAction> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					this.vmethod_16().DataSource = dataTable;
					this.vmethod_16().ResumeLayout();
					this.bool_3 = false;
					if (!string.IsNullOrEmpty(this.string_0))
					{
						try
						{
							foreach (object obj in ((IEnumerable)this.vmethod_16().Rows))
							{
								object objectValue = RuntimeHelpers.GetObjectValue(obj);
								if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
								{
									"ID"
								}, null, null, null), null, "Value", new object[0], null, null, null), this.string_0, false))
								{
									this.vmethod_16().CurrentCell = (DataGridViewCell)NewLateBinding.LateGet(objectValue, null, "cells", new object[]
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
					ex.Data.Add("Error at 200381", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060071C2 RID: 29122 RVA: 0x003D2730 File Offset: 0x003D0930
		private void method_4(object sender, EventArgs e)
		{
			SpecialAction specialAction_ = new SpecialAction();
			this.editSpecialAction_0 = new EditSpecialAction();
			this.editSpecialAction_0.specialAction_0 = specialAction_;
			this.editSpecialAction_0.enum203_0 = EditSpecialAction.Enum203.const_0;
			this.editSpecialAction_0.Show();
		}

		// Token: 0x060071C3 RID: 29123 RVA: 0x003D2774 File Offset: 0x003D0974
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_16().SelectedRows.Count != 0)
			{
				SpecialAction specialAction_ = Client.smethod_50().dictionary_2[Conversions.ToString(this.vmethod_16().SelectedRows[0].Cells["ID"].Value)];
				this.editSpecialAction_0 = new EditSpecialAction();
				this.editSpecialAction_0.specialAction_0 = specialAction_;
				this.editSpecialAction_0.enum203_0 = EditSpecialAction.Enum203.const_1;
				this.editSpecialAction_0.Show();
			}
		}

		// Token: 0x060071C4 RID: 29124 RVA: 0x003D27FC File Offset: 0x003D09FC
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_16().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_16().SelectedRows[0].Cells["ID"].Value);
				SpecialAction specialAction = Client.smethod_50().dictionary_2[key];
				if (!Information.IsNothing(specialAction))
				{
					Client.smethod_50().dictionary_2.Remove(specialAction.string_0);
					this.method_3();
				}
			}
		}

		// Token: 0x060071C5 RID: 29125 RVA: 0x00047578 File Offset: 0x00045778
		private void ListSpecialActions_Shown(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x060071C6 RID: 29126 RVA: 0x003B6260 File Offset: 0x003B4460
		private void ListSpecialActions_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x060071C7 RID: 29127 RVA: 0x00044820 File Offset: 0x00042A20
		private void ListSpecialActions_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x060071C8 RID: 29128 RVA: 0x003D287C File Offset: 0x003D0A7C
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_16().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_16().SelectedRows[0].Cells["ID"].Value);
				SpecialAction specialAction = Client.smethod_50().dictionary_2[key].method_10();
				Client.smethod_50().dictionary_2.Add(specialAction.string_0, specialAction);
				this.method_3();
			}
		}

		// Token: 0x060071C9 RID: 29129 RVA: 0x003D28F8 File Offset: 0x003D0AF8
		private void method_8(object sender, EventArgs e)
		{
			if (this.vmethod_16().SelectedRows.Count == 0)
			{
				this.vmethod_18().Visible = false;
				return;
			}
			this.vmethod_18().Visible = true;
			if (this.vmethod_16().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_16().SelectedRows[0].Cells["ID"].Value);
				SpecialAction specialAction = Client.smethod_50().dictionary_2[key];
				this.vmethod_18().Text = specialAction.string_2;
				if (!this.bool_3)
				{
					this.string_0 = Conversions.ToString(this.vmethod_16().SelectedRows[0].Cells["ID"].Value);
				}
			}
		}

		// Token: 0x060071CA RID: 29130 RVA: 0x003D29CC File Offset: 0x003D0BCC
		private void method_9(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1)
			{
				DataGridViewColumn dataGridViewColumn = this.vmethod_16().Columns[e.ColumnIndex];
				if (Operators.CompareString(dataGridViewColumn.Name, "IsActive", false) == 0 | Operators.CompareString(dataGridViewColumn.Name, "IsRepeatable", false) == 0)
				{
					DataGridViewCheckBoxCell dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)this.vmethod_16()[e.ColumnIndex, e.RowIndex];
					string key = Conversions.ToString(this.vmethod_16().Rows[e.RowIndex].Cells["ID"].Value);
					SpecialAction specialAction = Client.smethod_50().dictionary_2[key];
					dataGridViewCheckBoxCell.Value = !Conversions.ToBoolean(dataGridViewCheckBoxCell.Value);
					if (Operators.CompareString(dataGridViewColumn.Name, "IsActive", false) == 0)
					{
						specialAction.bool_11 = Conversions.ToBoolean(dataGridViewCheckBoxCell.Value);
						return;
					}
					if (Operators.CompareString(dataGridViewColumn.Name, "IsRepeatable", false) == 0)
					{
						specialAction.bool_12 = Conversions.ToBoolean(dataGridViewCheckBoxCell.Value);
					}
				}
			}
		}

		// Token: 0x060071CB RID: 29131 RVA: 0x00044489 File Offset: 0x00042689
		private void ListSpecialActions_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x060071CC RID: 29132 RVA: 0x003D2774 File Offset: 0x003D0974
		private void method_10(object sender, DataGridViewCellEventArgs e)
		{
			if (this.vmethod_16().SelectedRows.Count != 0)
			{
				SpecialAction specialAction_ = Client.smethod_50().dictionary_2[Conversions.ToString(this.vmethod_16().SelectedRows[0].Cells["ID"].Value)];
				this.editSpecialAction_0 = new EditSpecialAction();
				this.editSpecialAction_0.specialAction_0 = specialAction_;
				this.editSpecialAction_0.enum203_0 = EditSpecialAction.Enum203.const_1;
				this.editSpecialAction_0.Show();
			}
		}

		// Token: 0x04004023 RID: 16419
		[CompilerGenerated]
		[AccessedThroughProperty("Button_EditSelected")]
		private Control9 control9_0;

		// Token: 0x04004024 RID: 16420
		[CompilerGenerated]
		[AccessedThroughProperty("Button_DeleteSelected")]
		private Control9 control9_1;

		// Token: 0x04004025 RID: 16421
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_2;

		// Token: 0x04004026 RID: 16422
		[CompilerGenerated]
		[AccessedThroughProperty("Button_CloneSelected")]
		private Control9 control9_3;

		// Token: 0x04004027 RID: 16423
		[CompilerGenerated]
		[AccessedThroughProperty("ID")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04004028 RID: 16424
		[CompilerGenerated]
		[AccessedThroughProperty("ActionName")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04004029 RID: 16425
		[AccessedThroughProperty("IsActive")]
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x0400402A RID: 16426
		[CompilerGenerated]
		[AccessedThroughProperty("IsRepeatable")]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		// Token: 0x0400402B RID: 16427
		[AccessedThroughProperty("DataGridView1")]
		[CompilerGenerated]
		private Class114 class114_0;

		// Token: 0x0400402C RID: 16428
		[CompilerGenerated]
		[AccessedThroughProperty("Label_ActionDescription")]
		private Class116 class116_0;

		// Token: 0x0400402D RID: 16429
		private EditSpecialAction editSpecialAction_0;

		// Token: 0x0400402E RID: 16430
		private string string_0;

		// Token: 0x0400402F RID: 16431
		private bool bool_3;
	}
}
