using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Command;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;
using ns5;

namespace ns6
{
	// Token: 0x02000F02 RID: 3842
	[DesignerGenerated]
	internal sealed partial class AddWeaponRecord : DarkSecondaryFormBase
	{
		// Token: 0x0600882A RID: 34858 RVA: 0x0048EF18 File Offset: 0x0048D118
		public AddWeaponRecord()
		{
			base.Shown += this.AddWeaponRecord_Shown;
			base.KeyDown += this.AddWeaponRecord_KeyDown;
			base.FormClosing += this.AddWeaponRecord_FormClosing;
			base.Load += this.AddWeaponRecord_Load;
			this.InitializeComponent_1();
		}

		// Token: 0x0600882C RID: 34860 RVA: 0x0048EFBC File Offset: 0x0048D1BC
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_1(new Class114());
			this.vmethod_14(new DataGridViewTextBoxColumn());
			this.vmethod_16(new DataGridViewTextBoxColumn());
			this.vmethod_2(new BackgroundWorker());
			this.vmethod_4(new Control9());
			this.vmethod_6(new Class112());
			this.vmethod_8(new Control8());
			this.vmethod_10(new Class112());
			this.vmethod_12(new Control9());
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
				this.vmethod_13(),
				this.vmethod_15()
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
			this.vmethod_0().Location = new Point(0, 93);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DataGridView1";
			this.vmethod_0().RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_0().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_0().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new Size(331, 413);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_13().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_13().DataPropertyName = "ID";
			this.vmethod_13().HeaderText = "ID";
			this.vmethod_13().Name = "ID";
			this.vmethod_13().ReadOnly = true;
			this.vmethod_13().Width = 41;
			this.vmethod_15().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_15().DataPropertyName = "Description";
			this.vmethod_15().HeaderText = "Description";
			this.vmethod_15().Name = "Description";
			this.vmethod_15().ReadOnly = true;
			this.vmethod_3().BackColor = Color.Transparent;
			this.vmethod_3().DialogResult = DialogResult.None;
			this.vmethod_3().Font = new Font("Segoe UI", 10f);
			this.vmethod_3().ForeColor = SystemColors.Control;
			this.vmethod_3().Location = new Point(7, 12);
			this.vmethod_3().Name = "Button_AddSelected";
			this.vmethod_3().method_1(0);
			this.vmethod_3().Size = new Size(89, 23);
			this.vmethod_3().TabIndex = 3;
			this.vmethod_3().Text = "Add Selected";
			this.vmethod_5().AutoSize = true;
			this.vmethod_5().Location = new Point(7, 47);
			this.vmethod_5().Name = "CB_Filter1";
			this.vmethod_5().Size = new Size(119, 19);
			this.vmethod_5().TabIndex = 13;
			this.vmethod_5().Text = "Filter by keyword:";
			this.vmethod_7().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_7().method_14(null);
			this.vmethod_7().method_15(AutoCompleteMode.None);
			this.vmethod_7().method_13(AutoCompleteSource.None);
			this.vmethod_7().BackColor = Color.Transparent;
			this.vmethod_7().method_17(new Font("Segoe UI", 8f));
			this.vmethod_7().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_7().method_12(null);
			this.vmethod_7().method_18(null);
			this.vmethod_7().Location = new Point(132, 45);
			this.vmethod_7().method_2(32767);
			this.vmethod_7().method_7(false);
			this.vmethod_7().Name = "TB_Find";
			this.vmethod_7().method_3(false);
			this.vmethod_7().method_9(0);
			this.vmethod_7().Size = new Size(187, 20);
			this.vmethod_7().TabIndex = 12;
			this.vmethod_7().method_1(HorizontalAlignment.Left);
			this.vmethod_7().method_5(false);
			this.vmethod_7().method_10("");
			this.vmethod_9().Location = new Point(7, 70);
			this.vmethod_9().Name = "CB_Filter2";
			this.vmethod_9().Size = new Size(340, 17);
			this.vmethod_9().TabIndex = 14;
			this.vmethod_9().Text = "Show only weapons compatible with aircraft hosted by parent";
			this.vmethod_11().BackColor = Color.Transparent;
			this.vmethod_11().DialogResult = DialogResult.None;
			this.vmethod_11().Font = new Font("Segoe UI", 10f);
			this.vmethod_11().ForeColor = SystemColors.Control;
			this.vmethod_11().Location = new Point(121, 12);
			this.vmethod_11().Name = "Button_Add10K";
			this.vmethod_11().method_1(0);
			this.vmethod_11().Size = new Size(198, 23);
			this.vmethod_11().TabIndex = 15;
			this.vmethod_11().Text = "Add '10000' version of selected";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(331, 506);
			base.Controls.Add(this.vmethod_11());
			base.Controls.Add(this.vmethod_9());
			base.Controls.Add(this.vmethod_5());
			base.Controls.Add(this.vmethod_7());
			base.Controls.Add(this.vmethod_3());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AddWeaponRecord";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "Add Weapon Record";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600882D RID: 34861 RVA: 0x00051DE3 File Offset: 0x0004FFE3
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x0600882E RID: 34862 RVA: 0x0048F72C File Offset: 0x0048D92C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class114 class114_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_16);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.CellDoubleClick -= value;
			}
			this.class114_0 = class114_1;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.CellDoubleClick += value;
			}
		}

		// Token: 0x0600882F RID: 34863 RVA: 0x00051DEB File Offset: 0x0004FFEB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_2(BackgroundWorker backgroundWorker_1)
		{
			this.backgroundWorker_0 = backgroundWorker_1;
		}

		// Token: 0x06008830 RID: 34864 RVA: 0x00051DF4 File Offset: 0x0004FFF4
		[CompilerGenerated]
		internal Control9 vmethod_3()
		{
			return this.control9_0;
		}

		// Token: 0x06008831 RID: 34865 RVA: 0x0048F770 File Offset: 0x0048D970
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_4(Control9 control9_2)
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

		// Token: 0x06008832 RID: 34866 RVA: 0x00051DFC File Offset: 0x0004FFFC
		[CompilerGenerated]
		internal Class112 vmethod_5()
		{
			return this.class112_0;
		}

		// Token: 0x06008833 RID: 34867 RVA: 0x0048F7B4 File Offset: 0x0048D9B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_6(Class112 class112_2)
		{
			EventHandler value = new EventHandler(this.method_8);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_0 = class112_2;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06008834 RID: 34868 RVA: 0x00051E04 File Offset: 0x00050004
		[CompilerGenerated]
		internal Control8 vmethod_7()
		{
			return this.control8_0;
		}

		// Token: 0x06008835 RID: 34869 RVA: 0x0048F7F8 File Offset: 0x0048D9F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_8(Control8 control8_1)
		{
			Control8.Delegate85 delegate85_ = new Control8.Delegate85(this.method_6);
			EventHandler value = new EventHandler(this.method_13);
			EventHandler value2 = new EventHandler(this.method_14);
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

		// Token: 0x06008836 RID: 34870 RVA: 0x00051E0C File Offset: 0x0005000C
		[CompilerGenerated]
		internal Class112 vmethod_9()
		{
			return this.class112_1;
		}

		// Token: 0x06008837 RID: 34871 RVA: 0x0048F874 File Offset: 0x0048DA74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_10(Class112 class112_2)
		{
			EventHandler value = new EventHandler(this.method_10);
			Class112 @class = this.class112_1;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_1 = class112_2;
			@class = this.class112_1;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x06008838 RID: 34872 RVA: 0x00051E14 File Offset: 0x00050014
		[CompilerGenerated]
		internal Control9 vmethod_11()
		{
			return this.control9_1;
		}

		// Token: 0x06008839 RID: 34873 RVA: 0x0048F8B8 File Offset: 0x0048DAB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_12(Control9 control9_2)
		{
			EventHandler value = new EventHandler(this.method_15);
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

		// Token: 0x0600883A RID: 34874 RVA: 0x00051E1C File Offset: 0x0005001C
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_13()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x0600883B RID: 34875 RVA: 0x00051E24 File Offset: 0x00050024
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_14(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600883C RID: 34876 RVA: 0x00051E2D File Offset: 0x0005002D
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_15()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x0600883D RID: 34877 RVA: 0x00051E35 File Offset: 0x00050035
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_16(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600883E RID: 34878 RVA: 0x00051E3E File Offset: 0x0005003E
		private void method_3(object sender, EventArgs e)
		{
			this.method_4();
		}

		// Token: 0x0600883F RID: 34879 RVA: 0x0048F8FC File Offset: 0x0048DAFC
		private void method_4()
		{
			if (this.form_0 == Client.smethod_33())
			{
				WeaponRec weaponRec_ = DBFunctions.smethod_59(Conversions.ToInteger(this.vmethod_0().CurrentRow.Cells["ID"].Value), Client.smethod_46());
				Client.smethod_33().method_4(weaponRec_);
			}
			if (this.form_0 == Client.magazines_0)
			{
				WeaponRec gparam_ = DBFunctions.smethod_59(Conversions.ToInteger(this.vmethod_0().CurrentRow.Cells["ID"].Value), Client.magazines_0.activeUnit_0.scenario_0);
				Client.magazines_0.magazine_0.vmethod_10().method_4(gparam_);
			}
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x0048F9AC File Offset: 0x0048DBAC
		private void method_5()
		{
			SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
			this.dataTable_0 = DBFunctions.smethod_71(ref sqliteConnection);
		}

		// Token: 0x06008841 RID: 34881 RVA: 0x00051E46 File Offset: 0x00050046
		private void method_6(object object_0)
		{
			if (this.vmethod_5().Checked & Operators.CompareString(this.vmethod_7().Text, "", false) != 0)
			{
				this.method_7();
			}
		}

		// Token: 0x06008842 RID: 34882 RVA: 0x0048F9D4 File Offset: 0x0048DBD4
		private void method_7()
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Description ASC";
			dataView.RowFilter = "Description LIKE '%" + this.vmethod_7().Text + "%'";
			this.vmethod_0().AutoGenerateColumns = false;
			this.vmethod_0().DataSource = dataView;
			this.vmethod_0().Refresh();
		}

		// Token: 0x06008843 RID: 34883 RVA: 0x00051E75 File Offset: 0x00050075
		private void method_8(object sender, EventArgs e)
		{
			if (this.vmethod_5().Checked)
			{
				this.vmethod_9().Checked = false;
			}
		}

		// Token: 0x06008844 RID: 34884 RVA: 0x00051E90 File Offset: 0x00050090
		private void method_9()
		{
			if (this.dataTable_0 == null)
			{
				this.method_5();
			}
			base.Invoke(new VB$AnonymousDelegate_0(this.method_17));
		}

		// Token: 0x06008845 RID: 34885 RVA: 0x00051EB3 File Offset: 0x000500B3
		private void method_10(object sender, EventArgs e)
		{
			if (this.vmethod_9().Checked)
			{
				this.vmethod_5().Checked = false;
				this.method_11();
				return;
			}
			this.method_9();
		}

		// Token: 0x06008846 RID: 34886 RVA: 0x0048FA3C File Offset: 0x0048DC3C
		private void method_11()
		{
			AddWeaponRecord.Class2523 @class = new AddWeaponRecord.Class2523(@class);
			@class.addWeaponRecord_0 = this;
			if (this.dataTable_0 == null)
			{
				this.method_5();
			}
			List<int> list = new List<int>();
			try
			{
				foreach (Aircraft aircraft in this.method_12())
				{
					int dbid = aircraft.DBID;
					SQLiteConnection sqliteConnection = Client.smethod_46().method_39();
					List<int> list2 = DBFunctions.smethod_43(dbid, ref sqliteConnection);
					try
					{
						foreach (int item in list2)
						{
							if (!list.Contains(item))
							{
								list.Add(item);
							}
						}
					}
					finally
					{
						List<int>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
			}
			finally
			{
				List<Aircraft>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			@class.dataView_0 = new DataView(this.dataTable_0);
			@class.dataView_0.Sort = "Description ASC";
			if (list.Count > 0)
			{
				string text = "(";
				try
				{
					foreach (int value in list)
					{
						text = text + Conversions.ToString(value) + ",";
					}
				}
				finally
				{
					List<int>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				text += ")";
				@class.dataView_0.RowFilter = "ComponentID IN " + text;
			}
			else
			{
				@class.dataView_0.RowFilter = "1=2";
			}
			base.Invoke(new VB$AnonymousDelegate_0(@class.method_0));
		}

		// Token: 0x06008847 RID: 34887 RVA: 0x0048FBD4 File Offset: 0x0048DDD4
		private List<Aircraft> method_12()
		{
			List<Aircraft> result;
			if (this.form_0 == Client.magazines_0)
			{
				ActiveUnit activeUnit = Client.magazines_0.magazine_0.method_18();
				if (activeUnit.method_120())
				{
					if (activeUnit.vmethod_65(false).method_140())
					{
						result = activeUnit.vmethod_65(false).vmethod_92().vmethod_4();
					}
					else
					{
						result = activeUnit.vmethod_92().vmethod_4();
					}
				}
				else
				{
					result = activeUnit.vmethod_92().vmethod_4();
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06008848 RID: 34888 RVA: 0x0048FC48 File Offset: 0x0048DE48
		private void AddWeaponRecord_Shown(object sender, EventArgs e)
		{
			if (!Information.IsNothing(Client.magazines_0))
			{
				if (this.form_0 == Client.magazines_0)
				{
					List<Aircraft> list = this.method_12();
					this.vmethod_9().Visible = (!Information.IsNothing(list) && list.Count > 0);
				}
				else
				{
					this.vmethod_9().Visible = false;
				}
			}
			else
			{
				this.vmethod_9().Visible = false;
			}
			if (this.vmethod_9().Visible)
			{
				this.vmethod_9().Checked = true;
				Task.Factory.StartNew(new Action(this.method_11));
				return;
			}
			Task.Factory.StartNew(new Action(this.method_9));
		}

		// Token: 0x06008849 RID: 34889 RVA: 0x0048FCF8 File Offset: 0x0048DEF8
		private void AddWeaponRecord_KeyDown(object sender, KeyEventArgs e)
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
					this.vmethod_5().Select();
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

		// Token: 0x0600884A RID: 34890 RVA: 0x00051EDB File Offset: 0x000500DB
		private void method_13(object sender, EventArgs e)
		{
			this.bool_3 = true;
		}

		// Token: 0x0600884B RID: 34891 RVA: 0x00051EE4 File Offset: 0x000500E4
		private void method_14(object sender, EventArgs e)
		{
			this.bool_3 = false;
			this.vmethod_5().Select();
		}

		// Token: 0x0600884C RID: 34892 RVA: 0x00044820 File Offset: 0x00042A20
		private void AddWeaponRecord_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x0600884D RID: 34893 RVA: 0x0048FE08 File Offset: 0x0048E008
		private void method_15(object sender, EventArgs e)
		{
			if (this.form_0 == Client.smethod_33())
			{
				WeaponRec weaponRec = DBFunctions.smethod_59(Conversions.ToInteger(this.vmethod_0().CurrentRow.Cells["ID"].Value), Client.smethod_46());
				weaponRec.nullable_0 = null;
				weaponRec.method_10(10000);
				weaponRec.int_2 = 10000;
				Client.smethod_33().method_4(weaponRec);
			}
			if (this.form_0 == Client.magazines_0)
			{
				WeaponRec weaponRec2 = DBFunctions.smethod_59(Conversions.ToInteger(this.vmethod_0().CurrentRow.Cells["ID"].Value), Client.magazines_0.activeUnit_0.scenario_0);
				weaponRec2.nullable_0 = null;
				weaponRec2.int_2 = 10000;
				Client.magazines_0.magazine_0.vmethod_10().method_4(weaponRec2);
			}
		}

		// Token: 0x0600884E RID: 34894 RVA: 0x00051EF8 File Offset: 0x000500F8
		private void AddWeaponRecord_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_0().AutoGenerateColumns = false;
		}

		// Token: 0x0600884F RID: 34895 RVA: 0x00051E3E File Offset: 0x0005003E
		private void method_16(object sender, DataGridViewCellEventArgs e)
		{
			this.method_4();
		}

		// Token: 0x06008850 RID: 34896 RVA: 0x00051F19 File Offset: 0x00050119
		[CompilerGenerated]
		private void method_17()
		{
			this.dataView_0 = new DataView(this.dataTable_0);
			this.dataView_0.Sort = "Description ASC";
			this.vmethod_0().DataSource = this.dataView_0;
		}

		// Token: 0x04004A0F RID: 18959
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridView1")]
		private Class114 class114_0;

		// Token: 0x04004A10 RID: 18960
		[CompilerGenerated]
		[AccessedThroughProperty("BW1")]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04004A11 RID: 18961
		[AccessedThroughProperty("Button_AddSelected")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x04004A12 RID: 18962
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Filter1")]
		private Class112 class112_0;

		// Token: 0x04004A13 RID: 18963
		[AccessedThroughProperty("TB_Find")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x04004A14 RID: 18964
		[AccessedThroughProperty("CB_Filter2")]
		[CompilerGenerated]
		private Class112 class112_1;

		// Token: 0x04004A15 RID: 18965
		[AccessedThroughProperty("Button_Add10K")]
		[CompilerGenerated]
		private Control9 control9_1;

		// Token: 0x04004A16 RID: 18966
		[AccessedThroughProperty("ID")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04004A17 RID: 18967
		[AccessedThroughProperty("Description")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04004A18 RID: 18968
		private DataTable dataTable_0;

		// Token: 0x04004A19 RID: 18969
		private DataView dataView_0;

		// Token: 0x04004A1A RID: 18970
		private bool bool_3;

		// Token: 0x04004A1B RID: 18971
		public Form form_0;

		// Token: 0x02000F03 RID: 3843
		[CompilerGenerated]
		internal sealed class Class2523
		{
			// Token: 0x06008851 RID: 34897 RVA: 0x00051F4D File Offset: 0x0005014D
			public Class2523(AddWeaponRecord.Class2523 class2523_0)
			{
				if (class2523_0 != null)
				{
					this.dataView_0 = class2523_0.dataView_0;
				}
			}

			// Token: 0x06008852 RID: 34898 RVA: 0x00051F64 File Offset: 0x00050164
			internal void method_0()
			{
				this.addWeaponRecord_0.vmethod_0().DataSource = this.dataView_0;
				this.addWeaponRecord_0.vmethod_0().Refresh();
			}

			// Token: 0x04004A1C RID: 18972
			public DataView dataView_0;

			// Token: 0x04004A1D RID: 18973
			public AddWeaponRecord addWeaponRecord_0;
		}
	}
}
