using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns10;
using ns11;
using ns13;
using ns2;
using ns4;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000EEC RID: 3820
	[DesignerGenerated]
	public sealed partial class ORBAT : DarkSecondaryFormBase
	{
		// Token: 0x06008682 RID: 34434 RVA: 0x00481E40 File Offset: 0x00480040
		public ORBAT()
		{
			base.Load += this.ORBAT_Load;
			base.Closing += new CancelEventHandler(this.ORBAT_Closing);
			base.KeyDown += this.ORBAT_KeyDown;
			base.FormClosing += this.ORBAT_FormClosing;
			base.Shown += this.ORBAT_Shown;
			this.object_0 = RuntimeHelpers.GetObjectValue(new object());
			this.InitializeComponent_1();
		}

		// Token: 0x06008684 RID: 34436 RVA: 0x00481F04 File Offset: 0x00480104
		private void InitializeComponent_1()
		{
			this.icontainer_1 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			this.vmethod_1(new Control12());
			this.vmethod_3(new TabPage());
			this.vmethod_13(new Control5());
			this.vmethod_5(new TabPage());
			this.vmethod_15(new Control5());
			this.vmethod_21(new TabPage());
			this.vmethod_23(new Class50());
			this.vmethod_25(new Class44());
			this.vmethod_27(new DataGridViewTextBoxColumn());
			this.vmethod_29(new DataGridViewTextBoxColumn());
			this.vmethod_31(new DataGridViewTextBoxColumn());
			this.vmethod_33(new DataGridViewTextBoxColumn());
			this.vmethod_7(new Class116());
			this.vmethod_9(new Class116());
			this.vmethod_11(new Class2451());
			this.vmethod_17(new Class116());
			this.vmethod_19(new Class124());
			this.vmethod_35(new Timer(this.icontainer_1));
			this.vmethod_0().SuspendLayout();
			this.vmethod_2().SuspendLayout();
			this.vmethod_4().SuspendLayout();
			this.vmethod_20().SuspendLayout();
			((ISupportInitialize)this.vmethod_22()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().Controls.Add(this.vmethod_2());
			this.vmethod_0().Controls.Add(this.vmethod_4());
			this.vmethod_0().Controls.Add(this.vmethod_20());
			this.vmethod_0().Cursor = Cursors.Hand;
			this.vmethod_0().Font = new Font("Segoe UI", 8f);
			this.vmethod_0().ItemSize = new Size(80, 20);
			this.vmethod_0().Location = new Point(0, 1);
			this.vmethod_0().Name = "TabControl1";
			this.vmethod_0().SelectedIndex = 0;
			this.vmethod_0().Size = new Size(592, 374);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_2().Controls.Add(this.vmethod_12());
			this.vmethod_2().Location = new Point(4, 24);
			this.vmethod_2().Name = "TabPage1";
			this.vmethod_2().Padding = new Padding(3);
			this.vmethod_2().Size = new Size(584, 346);
			this.vmethod_2().TabIndex = 0;
			this.vmethod_2().Text = "Units By Group";
			this.vmethod_12().Dock = DockStyle.Fill;
			this.vmethod_12().Location = new Point(3, 3);
			this.vmethod_12().method_6(20);
			this.vmethod_12().Name = "TV_ByGroup";
			this.vmethod_12().Size = new Size(578, 340);
			this.vmethod_12().TabIndex = 0;
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().Controls.Add(this.vmethod_14());
			this.vmethod_4().Location = new Point(4, 24);
			this.vmethod_4().Name = "TabPage2";
			this.vmethod_4().Padding = new Padding(3);
			this.vmethod_4().Size = new Size(584, 346);
			this.vmethod_4().TabIndex = 1;
			this.vmethod_4().Text = "Units By Mission / Task";
			this.vmethod_14().Dock = DockStyle.Fill;
			this.vmethod_14().Location = new Point(3, 3);
			this.vmethod_14().method_6(20);
			this.vmethod_14().Name = "TV_ByMission";
			this.vmethod_14().Size = new Size(578, 340);
			this.vmethod_14().TabIndex = 0;
			this.vmethod_20().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_20().Controls.Add(this.vmethod_22());
			this.vmethod_20().Location = new Point(4, 24);
			this.vmethod_20().Name = "TabPage3";
			this.vmethod_20().Padding = new Padding(3);
			this.vmethod_20().Size = new Size(584, 346);
			this.vmethod_20().TabIndex = 2;
			this.vmethod_20().Text = "Contacts";
			this.vmethod_22().AllowUserToAddRows = false;
			this.vmethod_22().AllowUserToDeleteRows = false;
			this.vmethod_22().AllowUserToOrderColumns = true;
			this.vmethod_22().BackgroundColor = Color.FromArgb(51, 51, 51);
			this.vmethod_22().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_22().CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.vmethod_22().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font("Segoe UI", 8f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_22().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_22().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_24(),
				this.vmethod_26(),
				this.vmethod_28(),
				this.vmethod_30(),
				this.vmethod_32()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 51, 51);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 8f);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_22().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_22().Dock = DockStyle.Fill;
			this.vmethod_22().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_22().EnableHeadersVisualStyles = false;
			this.vmethod_22().method_9(null);
			this.vmethod_22().Location = new Point(3, 3);
			this.vmethod_22().Name = "TGV_Contacts";
			this.vmethod_22().RowHeadersVisible = false;
			this.vmethod_22().RowHeadersWidth = 20;
			this.vmethod_22().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_22().method_7(false);
			this.vmethod_22().Size = new Size(578, 340);
			this.vmethod_22().TabIndex = 8;
			this.vmethod_24().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_24().method_0(null);
			this.vmethod_24().HeaderText = "Name";
			this.vmethod_24().Name = "ContactName";
			this.vmethod_24().ReadOnly = true;
			this.vmethod_24().Resizable = DataGridViewTriState.True;
			this.vmethod_24().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_26().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_26().HeaderText = "Type/Class";
			this.vmethod_26().Name = "ContactType";
			this.vmethod_26().ReadOnly = true;
			this.vmethod_26().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_26().Width = 64;
			this.vmethod_28().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.vmethod_28().DefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_28().HeaderText = "Posture";
			this.vmethod_28().Name = "ContactPosture";
			this.vmethod_28().ReadOnly = true;
			this.vmethod_28().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_28().Width = 50;
			this.vmethod_30().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.vmethod_30().DefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_30().HeaderText = "BDA";
			this.vmethod_30().Name = "ContactBDA";
			this.vmethod_30().ReadOnly = true;
			this.vmethod_30().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_30().Width = 32;
			this.vmethod_32().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.vmethod_32().DefaultCellStyle = dataGridViewCellStyle5;
			this.vmethod_32().HeaderText = "Spotted hosted";
			this.vmethod_32().Name = "ContactHostedUnits";
			this.vmethod_32().ReadOnly = true;
			this.vmethod_32().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_32().Width = 91;
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_6().method_2(true);
			this.vmethod_6().Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_6().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_6().Location = new Point(4, 416);
			this.vmethod_6().Name = "Label_Proficiency";
			this.vmethod_6().Size = new Size(47, 13);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_6().Text = "Regular";
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_8().method_2(true);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(265, 415);
			this.vmethod_8().Name = "Label_SetUnitProficiency";
			this.vmethod_8().Size = new Size(149, 15);
			this.vmethod_8().TabIndex = 5;
			this.vmethod_8().Text = "Set unit/group proficiency:";
			this.vmethod_10().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_10().BackColor = Color.Transparent;
			this.vmethod_10().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_10().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_10().Font = new Font("Segoe UI", 7f);
			this.vmethod_10().FormattingEnabled = true;
			this.vmethod_10().Items.AddRange(new object[]
			{
				"Novice",
				"Cadet",
				"Regular",
				"Veteran",
				"Ace",
				"Inherited from Side"
			});
			this.vmethod_10().Location = new Point(420, 414);
			this.vmethod_10().Name = "CB_Proficiency";
			this.vmethod_10().Size = new Size(165, 21);
			this.vmethod_10().TabIndex = 6;
			this.vmethod_16().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_16().method_2(true);
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Location = new Point(4, 386);
			this.vmethod_16().Name = "DarkLabel1";
			this.vmethod_16().Size = new Size(45, 15);
			this.vmethod_16().TabIndex = 8;
			this.vmethod_16().Text = "Search:";
			this.vmethod_18().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_18().BackColor = Color.FromArgb(69, 73, 74);
			this.vmethod_18().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(52, 382);
			this.vmethod_18().Name = "TB_SearchOOB";
			this.vmethod_18().Size = new Size(533, 23);
			this.vmethod_18().TabIndex = 9;
			this.vmethod_34().Interval = 500;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(592, 442);
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ORBAT";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Show;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Order of Battle + Contacts";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_20().ResumeLayout(false);
			((ISupportInitialize)this.vmethod_22()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06008685 RID: 34437 RVA: 0x000511EC File Offset: 0x0004F3EC
		[CompilerGenerated]
		internal Control12 vmethod_0()
		{
			return this.control12_0;
		}

		// Token: 0x06008686 RID: 34438 RVA: 0x00482C28 File Offset: 0x00480E28
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Control12 control12_1)
		{
			EventHandler value = new EventHandler(this.method_33);
			Control12 control = this.control12_0;
			if (control != null)
			{
				control.SelectedIndexChanged -= value;
			}
			this.control12_0 = control12_1;
			control = this.control12_0;
			if (control != null)
			{
				control.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06008687 RID: 34439 RVA: 0x000511F4 File Offset: 0x0004F3F4
		[CompilerGenerated]
		internal TabPage vmethod_2()
		{
			return this.tabPage_0;
		}

		// Token: 0x06008688 RID: 34440 RVA: 0x000511FC File Offset: 0x0004F3FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TabPage tabPage_3)
		{
			this.tabPage_0 = tabPage_3;
		}

		// Token: 0x06008689 RID: 34441 RVA: 0x00051205 File Offset: 0x0004F405
		[CompilerGenerated]
		internal TabPage vmethod_4()
		{
			return this.tabPage_1;
		}

		// Token: 0x0600868A RID: 34442 RVA: 0x0005120D File Offset: 0x0004F40D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(TabPage tabPage_3)
		{
			this.tabPage_1 = tabPage_3;
		}

		// Token: 0x0600868B RID: 34443 RVA: 0x00051216 File Offset: 0x0004F416
		[CompilerGenerated]
		internal Class116 vmethod_6()
		{
			return this.class116_0;
		}

		// Token: 0x0600868C RID: 34444 RVA: 0x0005121E File Offset: 0x0004F41E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class116 class116_3)
		{
			this.class116_0 = class116_3;
		}

		// Token: 0x0600868D RID: 34445 RVA: 0x00051227 File Offset: 0x0004F427
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_1;
		}

		// Token: 0x0600868E RID: 34446 RVA: 0x0005122F File Offset: 0x0004F42F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_3)
		{
			this.class116_1 = class116_3;
		}

		// Token: 0x0600868F RID: 34447 RVA: 0x00051238 File Offset: 0x0004F438
		[CompilerGenerated]
		internal Class2451 vmethod_10()
		{
			return this.class2451_0;
		}

		// Token: 0x06008690 RID: 34448 RVA: 0x00482C6C File Offset: 0x00480E6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class2451 class2451_1)
		{
			EventHandler value = new EventHandler(this.method_23);
			Class2451 @class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted -= value;
			}
			this.class2451_0 = class2451_1;
			@class = this.class2451_0;
			if (@class != null)
			{
				@class.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06008691 RID: 34449 RVA: 0x00051240 File Offset: 0x0004F440
		[CompilerGenerated]
		internal Control5 vmethod_12()
		{
			return this.control5_0;
		}

		// Token: 0x06008692 RID: 34450 RVA: 0x00482CB0 File Offset: 0x00480EB0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control5 control5_2)
		{
			EventHandler eventHandler_ = new EventHandler(this.method_24);
			Control5 control = this.control5_0;
			if (control != null)
			{
				control.method_18(eventHandler_);
			}
			this.control5_0 = control5_2;
			control = this.control5_0;
			if (control != null)
			{
				control.method_17(eventHandler_);
			}
		}

		// Token: 0x06008693 RID: 34451 RVA: 0x00051248 File Offset: 0x0004F448
		[CompilerGenerated]
		internal Control5 vmethod_14()
		{
			return this.control5_1;
		}

		// Token: 0x06008694 RID: 34452 RVA: 0x00482CF4 File Offset: 0x00480EF4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Control5 control5_2)
		{
			EventHandler eventHandler_ = new EventHandler(this.method_25);
			Control5 control = this.control5_1;
			if (control != null)
			{
				control.method_18(eventHandler_);
			}
			this.control5_1 = control5_2;
			control = this.control5_1;
			if (control != null)
			{
				control.method_17(eventHandler_);
			}
		}

		// Token: 0x06008695 RID: 34453 RVA: 0x00051250 File Offset: 0x0004F450
		[CompilerGenerated]
		internal Class116 vmethod_16()
		{
			return this.class116_2;
		}

		// Token: 0x06008696 RID: 34454 RVA: 0x00051258 File Offset: 0x0004F458
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class116 class116_3)
		{
			this.class116_2 = class116_3;
		}

		// Token: 0x06008697 RID: 34455 RVA: 0x00051261 File Offset: 0x0004F461
		[CompilerGenerated]
		internal Class124 vmethod_18()
		{
			return this.class124_0;
		}

		// Token: 0x06008698 RID: 34456 RVA: 0x00482D38 File Offset: 0x00480F38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class124 class124_1)
		{
			EventHandler value = new EventHandler(this.method_26);
			KeyPressEventHandler value2 = new KeyPressEventHandler(this.method_27);
			Class124 @class = this.class124_0;
			if (@class != null)
			{
				@class.TextChanged -= value;
				@class.KeyPress -= value2;
			}
			this.class124_0 = class124_1;
			@class = this.class124_0;
			if (@class != null)
			{
				@class.TextChanged += value;
				@class.KeyPress += value2;
			}
		}

		// Token: 0x06008699 RID: 34457 RVA: 0x00051269 File Offset: 0x0004F469
		[CompilerGenerated]
		internal TabPage vmethod_20()
		{
			return this.tabPage_2;
		}

		// Token: 0x0600869A RID: 34458 RVA: 0x00051271 File Offset: 0x0004F471
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(TabPage tabPage_3)
		{
			this.tabPage_2 = tabPage_3;
		}

		// Token: 0x0600869B RID: 34459 RVA: 0x0005127A File Offset: 0x0004F47A
		[CompilerGenerated]
		private Class50 vmethod_22()
		{
			return this.class50_0;
		}

		// Token: 0x0600869C RID: 34460 RVA: 0x00482D98 File Offset: 0x00480F98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_23(Class50 class50_1)
		{
			Delegate1 delegate1_ = new Delegate1(this.method_29);
			EventHandler value = new EventHandler(this.method_30);
			Class50 @class = this.class50_0;
			if (@class != null)
			{
				@class.method_12(delegate1_);
				@class.SelectionChanged -= value;
			}
			this.class50_0 = class50_1;
			@class = this.class50_0;
			if (@class != null)
			{
				@class.method_11(delegate1_);
				@class.SelectionChanged += value;
			}
		}

		// Token: 0x0600869D RID: 34461 RVA: 0x00051282 File Offset: 0x0004F482
		[CompilerGenerated]
		internal Class44 vmethod_24()
		{
			return this.class44_0;
		}

		// Token: 0x0600869E RID: 34462 RVA: 0x0005128A File Offset: 0x0004F48A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class44 class44_1)
		{
			this.class44_0 = class44_1;
		}

		// Token: 0x0600869F RID: 34463 RVA: 0x00051293 File Offset: 0x0004F493
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_26()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x060086A0 RID: 34464 RVA: 0x0005129B File Offset: 0x0004F49B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x060086A1 RID: 34465 RVA: 0x000512A4 File Offset: 0x0004F4A4
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_28()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x060086A2 RID: 34466 RVA: 0x000512AC File Offset: 0x0004F4AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x060086A3 RID: 34467 RVA: 0x000512B5 File Offset: 0x0004F4B5
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_30()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060086A4 RID: 34468 RVA: 0x000512BD File Offset: 0x0004F4BD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x060086A5 RID: 34469 RVA: 0x000512C6 File Offset: 0x0004F4C6
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_32()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x060086A6 RID: 34470 RVA: 0x000512CE File Offset: 0x0004F4CE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x060086A7 RID: 34471 RVA: 0x000512D7 File Offset: 0x0004F4D7
		[CompilerGenerated]
		internal Timer vmethod_34()
		{
			return this.timer_0;
		}

		// Token: 0x060086A8 RID: 34472 RVA: 0x00482DF8 File Offset: 0x00480FF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_32);
			Timer timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.timer_0 = timer_1;
			timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x060086A9 RID: 34473 RVA: 0x00482E3C File Offset: 0x0048103C
		private void ORBAT_Load(object sender, EventArgs e)
		{
			this.method_14();
			Scenario.smethod_5(new Scenario.UnitAddedEventHandler(this.method_12));
			Scenario.smethod_7(new Scenario.UnitRemovedEventHandler(this.method_13));
			ActiveUnit_DockingOps.smethod_4(new ActiveUnit_DockingOps.Delegate19(this.method_8));
			Aircraft_AirOps.smethod_5(new Aircraft_AirOps.Delegate25(this.method_8));
			ActiveUnit.smethod_0(new ActiveUnit.Delegate12(this.method_7));
			ActiveUnit.smethod_2(new ActiveUnit.Delegate13(this.method_6));
			Side.smethod_2(new Side.Delegate50(this.method_4));
			Side.smethod_4(new Side.Delegate51(this.method_3));
			Side.smethod_6(new Side.Delegate52(this.method_5));
			Side.smethod_8(new Side.Delegate53(this.method_3));
			this.vmethod_34().Start();
		}

		// Token: 0x060086AA RID: 34474 RVA: 0x00482F04 File Offset: 0x00481104
		private void ORBAT_Closing(object sender, CancelEventArgs e)
		{
			Scenario.smethod_6(new Scenario.UnitAddedEventHandler(this.method_12));
			Scenario.smethod_8(new Scenario.UnitRemovedEventHandler(this.method_13));
			ActiveUnit_DockingOps.smethod_5(new ActiveUnit_DockingOps.Delegate19(this.method_8));
			Aircraft_AirOps.smethod_6(new Aircraft_AirOps.Delegate25(this.method_8));
			ActiveUnit.smethod_1(new ActiveUnit.Delegate12(this.method_7));
			ActiveUnit.smethod_3(new ActiveUnit.Delegate13(this.method_6));
			Side.smethod_3(new Side.Delegate50(this.method_4));
			Side.smethod_5(new Side.Delegate51(this.method_3));
			Side.smethod_7(new Side.Delegate52(this.method_5));
			Side.smethod_9(new Side.Delegate53(this.method_3));
		}

		// Token: 0x060086AB RID: 34475 RVA: 0x00482FBC File Offset: 0x004811BC
		private void method_3(string string_0, string string_1)
		{
			if (Client.smethod_50() != null && Operators.CompareString(string_0, Client.smethod_50().string_0, false) == 0)
			{
				try
				{
					IEnumerator<Class48> enumerator = this.vmethod_22().method_2().GetEnumerator();
					while (enumerator.MoveNext())
					{
						ORBAT.Class2514 @class = new ORBAT.Class2514(@class);
						@class.orbat_0 = this;
						@class.class48_0 = enumerator.Current;
						if (@class.class48_0.Tag != null && Operators.CompareString(@class.class48_0.Tag.ToString(), string_1, false) == 0)
						{
							base.Invoke(new VB$AnonymousDelegate_0(@class.method_0));
							break;
						}
					}
				}
				finally
				{
					IEnumerator<Class48> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x060086AC RID: 34476 RVA: 0x00483074 File Offset: 0x00481274
		private void method_4(string string_0, string string_1)
		{
			ORBAT.Class2515 @class = new ORBAT.Class2515();
			@class.orbat_0 = this;
			if (Client.smethod_50() != null && Operators.CompareString(string_0, Client.smethod_50().string_0, false) == 0)
			{
				@class.contact_0 = Client.smethod_50().method_11()[string_1];
				if (@class.contact_0 == null)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
						return;
					}
				}
				else if (!@class.contact_0.activeUnit_0.method_120() || !@class.contact_0.activeUnit_0.vmethod_65(false).method_140())
				{
					base.Invoke(new VB$AnonymousDelegate_0(@class.method_0));
				}
			}
		}

		// Token: 0x060086AD RID: 34477 RVA: 0x00483110 File Offset: 0x00481310
		private void method_5(string string_0, string string_1)
		{
			ORBAT.Class2516 @class = new ORBAT.Class2516();
			@class.orbat_0 = this;
			if (Client.smethod_50() != null && Operators.CompareString(string_0, Client.smethod_50().string_0, false) == 0)
			{
				@class.contact_0 = Client.smethod_50().method_12()[string_1];
				if (@class.contact_0 == null)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
						return;
					}
				}
				else
				{
					base.Invoke(new VB$AnonymousDelegate_0(@class.method_0));
				}
			}
		}

		// Token: 0x060086AE RID: 34478 RVA: 0x00483184 File Offset: 0x00481384
		private void method_6(string string_0)
		{
			ORBAT.Class2518 @class = new ORBAT.Class2518(@class);
			@class.orbat_0 = this;
			if (base.Visible && Client.smethod_46().vmethod_0().ContainsKey(string_0))
			{
				@class.activeUnit_0 = Client.smethod_46().vmethod_0()[string_0];
				if (Operators.CompareString(@class.activeUnit_0.vmethod_7(false).string_0, Client.smethod_50().string_0, false) == 0)
				{
					try
					{
						IEnumerator<Class126> enumerator = Class2558.smethod_10(this.vmethod_12()).GetEnumerator();
						while (enumerator.MoveNext())
						{
							ORBAT.Class2517 class2 = new ORBAT.Class2517(class2);
							class2.class2518_0 = @class;
							class2.class126_0 = enumerator.Current;
							if (class2.class126_0.Tag == class2.class2518_0.activeUnit_0)
							{
								base.Invoke(new VB$AnonymousDelegate_0(class2.method_0));
								break;
							}
						}
					}
					finally
					{
						IEnumerator<Class126> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x060086AF RID: 34479 RVA: 0x0048327C File Offset: 0x0048147C
		private void method_7(string string_0)
		{
			if (base.Visible && Client.smethod_46().vmethod_0().ContainsKey(string_0))
			{
				ActiveUnit activeUnit = Client.smethod_46().vmethod_0()[string_0];
				if (Operators.CompareString(activeUnit.vmethod_7(false).string_0, Client.smethod_50().string_0, false) == 0)
				{
					this.method_10(activeUnit);
					this.method_9(activeUnit);
				}
			}
		}

		// Token: 0x060086B0 RID: 34480 RVA: 0x004832E0 File Offset: 0x004814E0
		private void method_8(string string_0)
		{
			if (base.Visible && Client.smethod_46().vmethod_0().ContainsKey(string_0))
			{
				ActiveUnit activeUnit = Client.smethod_46().vmethod_0()[string_0];
				if (Operators.CompareString(activeUnit.vmethod_7(false).string_0, Client.smethod_50().string_0, false) == 0)
				{
					try
					{
						Class126 @class = null;
						try
						{
							foreach (Class126 class2 in Class2558.smethod_10(this.vmethod_12()))
							{
								try
								{
									foreach (Class126 class3 in class2.method_22())
									{
										try
										{
											if (Operators.CompareString(((ActiveUnit)class3.Tag).string_0, string_0, false) == 0)
											{
												@class = class2;
												break;
											}
										}
										catch (Exception ex)
										{
										}
									}
								}
								finally
								{
									List<Class126>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
							}
						}
						finally
						{
							IEnumerator<Class126> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						ActiveUnit activeUnit2 = activeUnit.bool_3 ? ((Aircraft)activeUnit).method_164().method_30() : activeUnit.vmethod_93().method_17();
						if (!Information.IsNothing(@class))
						{
							string right = Information.IsNothing(activeUnit2) ? string.Empty : activeUnit2.string_0;
							if (Operators.CompareString(((ActiveUnit)@class.Tag).string_0, right, false) == 0)
							{
								return;
							}
						}
						this.method_10(activeUnit);
						this.method_9(activeUnit);
					}
					catch (Exception ex2)
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
				}
			}
		}

		// Token: 0x060086B1 RID: 34481 RVA: 0x004834C4 File Offset: 0x004816C4
		private void method_9(ActiveUnit activeUnit_0)
		{
			ORBAT.Class2519 @class = new ORBAT.Class2519(@class);
			@class.orbat_0 = this;
			@class.activeUnit_0 = activeUnit_0;
			object obj = this.object_0;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			lock (obj)
			{
				ORBAT.Class2520 class2 = new ORBAT.Class2520(class2);
				class2.class2519_0 = @class;
				class2.activeUnit_0 = (class2.class2519_0.activeUnit_0.bool_3 ? ((Aircraft)class2.class2519_0.activeUnit_0).method_164().method_30() : class2.class2519_0.activeUnit_0.vmethod_93().method_17());
				try
				{
					foreach (Class126 class3 in Class2558.smethod_10(this.vmethod_12()))
					{
						if (class3.Tag != null && class3.Tag == class2.class2519_0.activeUnit_0)
						{
							return;
						}
					}
				}
				finally
				{
					IEnumerator<Class126> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				class2.class126_0 = null;
				if (class2.activeUnit_0 == null)
				{
					if (class2.class2519_0.activeUnit_0.vmethod_65(false) == null)
					{
						base.Invoke(new VB$AnonymousDelegate_0(class2.method_0));
					}
					else
					{
						base.Invoke(new VB$AnonymousDelegate_0(class2.method_1));
					}
				}
				else
				{
					base.Invoke(new VB$AnonymousDelegate_0(class2.method_2));
				}
				if (class2.class126_0 != null && class2.class2519_0.activeUnit_0.bool_1)
				{
					try
					{
						foreach (ActiveUnit activeUnit in ((Group)class2.class2519_0.activeUnit_0).vmethod_141().Values)
						{
							bool flag2 = false;
							try
							{
								foreach (Class126 class4 in Class2558.smethod_10(this.vmethod_12()))
								{
									try
									{
										if (Operators.CompareString(((ActiveUnit)class4.Tag).string_0, activeUnit.string_0, false) == 0)
										{
											flag2 = true;
											break;
										}
									}
									catch (Exception ex)
									{
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
									}
								}
								goto IL_21D;
							}
							finally
							{
								IEnumerator<Class126> enumerator3;
								if (enumerator3 != null)
								{
									enumerator3.Dispose();
								}
							}
							IL_208:
							this.method_10(activeUnit);
							this.method_9(activeUnit);
							continue;
							IL_21D:
							if (!flag2)
							{
								goto IL_208;
							}
						}
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
					base.Invoke(new VB$AnonymousDelegate_0(class2.method_4));
				}
			}
		}

		// Token: 0x060086B2 RID: 34482 RVA: 0x004837A0 File Offset: 0x004819A0
		private void method_10(ActiveUnit activeUnit_0)
		{
			ORBAT.Class2521 @class = new ORBAT.Class2521(@class);
			@class.orbat_0 = this;
			try
			{
				foreach (Class126 class2 in Class2558.smethod_10(this.vmethod_12()))
				{
					if (class2.Tag == activeUnit_0)
					{
						@class.class126_0 = class2;
						break;
					}
				}
			}
			finally
			{
				IEnumerator<Class126> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			if (!Information.IsNothing(@class.class126_0))
			{
				base.Invoke(new VB$AnonymousDelegate_0(@class.method_0));
			}
		}

		// Token: 0x060086B3 RID: 34483 RVA: 0x00483830 File Offset: 0x00481A30
		private void method_11(ActiveUnit activeUnit_0)
		{
			ORBAT.Class2522 @class = new ORBAT.Class2522(@class);
			@class.orbat_0 = this;
			try
			{
				foreach (Class126 class2 in Class2558.smethod_10(this.vmethod_14()))
				{
					if (class2.Tag == activeUnit_0)
					{
						@class.class126_0 = class2;
						break;
					}
				}
			}
			finally
			{
				IEnumerator<Class126> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			if (!Information.IsNothing(@class.class126_0))
			{
				base.Invoke(new VB$AnonymousDelegate_0(@class.method_0));
			}
		}

		// Token: 0x060086B4 RID: 34484 RVA: 0x004838C0 File Offset: 0x00481AC0
		private void method_12(Scenario scenario_0, string string_0)
		{
			if (base.Visible && Client.smethod_46().vmethod_0().ContainsKey(string_0))
			{
				ActiveUnit activeUnit = Client.smethod_46().vmethod_0()[string_0];
				if (Operators.CompareString(activeUnit.vmethod_7(false).string_0, Client.smethod_50().string_0, false) == 0)
				{
					if (!activeUnit.bool_3)
					{
						activeUnit.vmethod_93().method_17();
					}
					else
					{
						((Aircraft)activeUnit).method_164().method_30();
					}
					this.method_9(activeUnit);
				}
			}
		}

		// Token: 0x060086B5 RID: 34485 RVA: 0x000512DF File Offset: 0x0004F4DF
		private void method_13(Scenario scenario_0, ActiveUnit activeUnit_0)
		{
			if (base.Visible && Operators.CompareString(activeUnit_0.vmethod_7(false).string_0, Client.smethod_50().string_0, false) == 0)
			{
				this.method_10(activeUnit_0);
				this.method_11(activeUnit_0);
			}
		}

		// Token: 0x060086B6 RID: 34486 RVA: 0x00483944 File Offset: 0x00481B44
		public void method_14()
		{
			switch (this.vmethod_0().SelectedIndex)
			{
			case 0:
				this.method_17();
				break;
			case 1:
				this.method_18();
				break;
			case 2:
				this.method_19();
				break;
			}
			if (Client.smethod_50() != null)
			{
				this.vmethod_6().Text = Misc.smethod_20(Client.smethod_50().method_24());
			}
			this.vmethod_8().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			this.vmethod_10().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
		}

		// Token: 0x060086B7 RID: 34487 RVA: 0x004839D8 File Offset: 0x00481BD8
		public Color method_15(ActiveUnit activeUnit_0)
		{
			Color result;
			if (activeUnit_0.bool_1)
			{
				result = Color.LightGray;
			}
			else
			{
				GlobalVariables.ProficiencyLevel? proficiencyLevel = activeUnit_0.vmethod_53();
				int? num = (proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					result = Color.Cyan;
				}
				else
				{
					num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						result = Color.Lime;
					}
					else
					{
						num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							result = Color.Yellow;
						}
						else
						{
							num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								result = Color.Orange;
							}
							else
							{
								num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									result = Color.Red;
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060086B8 RID: 34488 RVA: 0x00483BC0 File Offset: 0x00481DC0
		private string method_16(ActiveUnit activeUnit_0)
		{
			string text;
			if (activeUnit_0.bool_3)
			{
				Aircraft aircraft = (Aircraft)activeUnit_0;
				if (Information.IsNothing(aircraft.method_167()))
				{
					text = "";
				}
				else
				{
					text = " , " + aircraft.method_167().Name;
				}
			}
			else
			{
				text = "";
			}
			string text2 = activeUnit_0.Name;
			if (!activeUnit_0.bool_1)
			{
				text2 = string.Concat(new string[]
				{
					text2,
					" (",
					Misc.smethod_9(activeUnit_0.string_2),
					text,
					")"
				});
			}
			return text2;
		}

		// Token: 0x060086B9 RID: 34489 RVA: 0x00483C54 File Offset: 0x00481E54
		private void method_17()
		{
			this.vmethod_12().method_19().Clear();
			List<ActiveUnit> list = Enumerable.ToList<ActiveUnit>(Enumerable.OrderBy<ActiveUnit, string>(Enumerable.Select<ActiveUnit, ActiveUnit>(Client.smethod_50().activeUnit_0, (ORBAT._Closure$__.$I97-0 == null) ? (ORBAT._Closure$__.$I97-0 = new Func<ActiveUnit, ActiveUnit>(ORBAT._Closure$__.$I.method_0)) : ORBAT._Closure$__.$I97-0), (ORBAT._Closure$__.$I97-1 == null) ? (ORBAT._Closure$__.$I97-1 = new Func<ActiveUnit, string>(ORBAT._Closure$__.$I.method_1)) : ORBAT._Closure$__.$I97-1, new Class440<string[]>(true)));
			try
			{
				foreach (ActiveUnit activeUnit in list)
				{
					if (activeUnit.bool_1)
					{
						Class126 @class = new Class126(activeUnit.Name);
						this.vmethod_12().method_19().method_4(@class);
						@class.Tag = activeUnit;
						List<ActiveUnit> list2 = Enumerable.ToList<ActiveUnit>(Enumerable.OrderBy<ActiveUnit, string>(Enumerable.Select<ActiveUnit, ActiveUnit>(((Group)activeUnit).vmethod_141().Values, (ORBAT._Closure$__.$I97-2 == null) ? (ORBAT._Closure$__.$I97-2 = new Func<ActiveUnit, ActiveUnit>(ORBAT._Closure$__.$I.method_2)) : ORBAT._Closure$__.$I97-2), (ORBAT._Closure$__.$I97-3 == null) ? (ORBAT._Closure$__.$I97-3 = new Func<ActiveUnit, string>(ORBAT._Closure$__.$I.method_3)) : ORBAT._Closure$__.$I97-3, new Class440<string[]>(true)));
						try
						{
							foreach (ActiveUnit activeUnit2 in list2)
							{
								Class126 class2 = new Class126(this.method_16(activeUnit2));
								@class.method_22().method_4(class2);
								class2.method_40(new Font(this.vmethod_12().Font, FontStyle.Regular));
								class2.method_38(this.method_15(activeUnit2));
								class2.Tag = activeUnit2;
								IEnumerable<ActiveUnit> enumerable = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.OrderBy<ActiveUnit, string>(activeUnit2.vmethod_93().method_14(), (ORBAT._Closure$__.$I97-4 == null) ? (ORBAT._Closure$__.$I97-4 = new Func<ActiveUnit, string>(ORBAT._Closure$__.$I.method_4)) : ORBAT._Closure$__.$I97-4, new Class440<string[]>(true)), (ORBAT._Closure$__.$I97-5 == null) ? (ORBAT._Closure$__.$I97-5 = new Func<ActiveUnit, ActiveUnit>(ORBAT._Closure$__.$I.method_5)) : ORBAT._Closure$__.$I97-5);
								try
								{
									foreach (ActiveUnit activeUnit3 in enumerable)
									{
										Class126 class3 = new Class126(this.method_16(activeUnit3));
										class2.method_22().method_4(class3);
										class3.method_40(new Font(this.vmethod_12().Font, FontStyle.Regular));
										class3.method_38(this.method_15(activeUnit3));
										class3.Tag = activeUnit3;
									}
								}
								finally
								{
									IEnumerator<ActiveUnit> enumerator3;
									if (enumerator3 != null)
									{
										enumerator3.Dispose();
									}
								}
								IEnumerable<Aircraft> enumerable2 = Enumerable.Select<Aircraft, Aircraft>(Enumerable.OrderBy<Aircraft, string>(activeUnit2.vmethod_92().vmethod_4(), (ORBAT._Closure$__.$I97-6 == null) ? (ORBAT._Closure$__.$I97-6 = new Func<Aircraft, string>(ORBAT._Closure$__.$I.method_6)) : ORBAT._Closure$__.$I97-6, new Class440<string[]>(true)), (ORBAT._Closure$__.$I97-7 == null) ? (ORBAT._Closure$__.$I97-7 = new Func<Aircraft, Aircraft>(ORBAT._Closure$__.$I.method_7)) : ORBAT._Closure$__.$I97-7);
								try
								{
									foreach (Aircraft aircraft in enumerable2)
									{
										Class126 class3 = new Class126(this.method_16(aircraft));
										class2.method_22().method_4(class3);
										class3.method_40(new Font(this.vmethod_12().Font, FontStyle.Regular));
										class3.method_38(this.method_15(aircraft));
										class3.Tag = aircraft;
									}
								}
								finally
								{
									IEnumerator<Aircraft> enumerator4;
									if (enumerator4 != null)
									{
										enumerator4.Dispose();
									}
								}
								class2.method_21(true);
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						@class.method_21(true);
					}
					if (activeUnit.vmethod_127() && activeUnit.vmethod_43() && !activeUnit.bool_1 && !activeUnit.method_120())
					{
						Class126 class2 = new Class126(this.method_16(activeUnit));
						this.vmethod_12().method_19().method_4(class2);
						class2.method_40(new Font(this.vmethod_12().Font, FontStyle.Regular));
						class2.method_38(this.method_15(activeUnit));
						class2.Tag = activeUnit;
						IEnumerable<ActiveUnit> enumerable = Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.OrderBy<ActiveUnit, string>(activeUnit.vmethod_93().method_14(), (ORBAT._Closure$__.$I97-8 == null) ? (ORBAT._Closure$__.$I97-8 = new Func<ActiveUnit, string>(ORBAT._Closure$__.$I.method_8)) : ORBAT._Closure$__.$I97-8, new Class440<string[]>(true)), (ORBAT._Closure$__.$I97-9 == null) ? (ORBAT._Closure$__.$I97-9 = new Func<ActiveUnit, ActiveUnit>(ORBAT._Closure$__.$I.method_9)) : ORBAT._Closure$__.$I97-9);
						try
						{
							foreach (ActiveUnit activeUnit4 in enumerable)
							{
								Class126 class3 = new Class126(this.method_16(activeUnit4));
								class2.method_22().method_4(class3);
								class3.method_40(new Font(this.vmethod_12().Font, FontStyle.Regular));
								class3.method_38(this.method_15(activeUnit4));
								class3.Tag = activeUnit4;
							}
						}
						finally
						{
							IEnumerator<ActiveUnit> enumerator5;
							if (enumerator5 != null)
							{
								enumerator5.Dispose();
							}
						}
						IEnumerable<Aircraft> enumerable2 = Enumerable.Select<Aircraft, Aircraft>(Enumerable.OrderBy<Aircraft, string>(activeUnit.vmethod_92().vmethod_4(), (ORBAT._Closure$__.$I97-10 == null) ? (ORBAT._Closure$__.$I97-10 = new Func<Aircraft, string>(ORBAT._Closure$__.$I.method_10)) : ORBAT._Closure$__.$I97-10, new Class440<string[]>(true)), (ORBAT._Closure$__.$I97-11 == null) ? (ORBAT._Closure$__.$I97-11 = new Func<Aircraft, Aircraft>(ORBAT._Closure$__.$I.method_11)) : ORBAT._Closure$__.$I97-11);
						try
						{
							foreach (Aircraft aircraft2 in enumerable2)
							{
								Class126 class3 = new Class126(this.method_16(aircraft2));
								class2.method_22().method_4(class3);
								class3.method_40(new Font(this.vmethod_12().Font, FontStyle.Regular));
								class3.method_38(this.method_15(aircraft2));
								class3.Tag = aircraft2;
							}
						}
						finally
						{
							IEnumerator<Aircraft> enumerator6;
							if (enumerator6 != null)
							{
								enumerator6.Dispose();
							}
						}
						class2.method_21(true);
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x060086BA RID: 34490 RVA: 0x004842AC File Offset: 0x004824AC
		private void method_18()
		{
			this.vmethod_14().method_19().Clear();
			if (!Information.IsNothing(Client.smethod_50()))
			{
				IEnumerable<Mission> enumerable = Enumerable.OrderBy<Mission, string>(Client.smethod_50().method_36(Client.smethod_46()), (ORBAT._Closure$__.$I98-0 == null) ? (ORBAT._Closure$__.$I98-0 = new Func<Mission, string>(ORBAT._Closure$__.$I.method_12)) : ORBAT._Closure$__.$I98-0);
				try
				{
					foreach (Mission mission in enumerable)
					{
						if (mission.enum88_0 == Mission.Enum88.const_0)
						{
							Class126 @class = new Class126(mission.Name);
							this.vmethod_14().method_19().method_4(@class);
							if (mission.method_12())
							{
								@class.method_38(Color.LightGreen);
							}
							else
							{
								@class.method_38(Color.Red);
								@class.method_40(new Font(this.Font, FontStyle.Italic));
							}
							@class.Tag = mission;
							List<Aircraft> list = new List<Aircraft>();
							List<Aircraft> list2 = new List<Aircraft>();
							List<ActiveUnit> list3 = new List<ActiveUnit>();
							foreach (ActiveUnit activeUnit in Client.smethod_50().activeUnit_0)
							{
								if (!(activeUnit.method_120() | (activeUnit.bool_2 && ((Weapon)activeUnit).method_167() == Weapon._WeaponType.Sonobuoy)) && activeUnit.vmethod_101() == mission)
								{
									if (activeUnit.bool_3)
									{
										if (!Information.IsNothing(activeUnit.vmethod_85().method_7()))
										{
											if (activeUnit.method_120())
											{
												if (!Information.IsNothing(activeUnit.vmethod_65(false)) && !list3.Contains(activeUnit.vmethod_65(false)))
												{
													list3.Add(activeUnit.vmethod_65(false));
												}
											}
											else
											{
												list2.Add((Aircraft)activeUnit);
											}
										}
										else if (activeUnit.method_120())
										{
											if (!Information.IsNothing(activeUnit.vmethod_65(false)) && !list3.Contains(activeUnit.vmethod_65(false)))
											{
												list3.Add(activeUnit.vmethod_65(false));
											}
										}
										else
										{
											list.Add((Aircraft)activeUnit);
										}
									}
									else if (!activeUnit.bool_5 || !((Submarine)activeUnit).method_159())
									{
										list3.Add(activeUnit);
									}
								}
							}
							IEnumerable<Aircraft> enumerable2 = Enumerable.ThenBy<Aircraft, string>(Enumerable.OrderBy<Aircraft, string>(list, (ORBAT._Closure$__.$I98-1 == null) ? (ORBAT._Closure$__.$I98-1 = new Func<Aircraft, string>(ORBAT._Closure$__.$I.method_13)) : ORBAT._Closure$__.$I98-1), new Func<Aircraft, string>(this.method_34));
							List<Aircraft> list4 = Enumerable.ToList<Aircraft>(Enumerable.OrderBy<Aircraft, string>(Enumerable.Select<Aircraft, Aircraft>(list2, (ORBAT._Closure$__.$I98-3 == null) ? (ORBAT._Closure$__.$I98-3 = new Func<Aircraft, Aircraft>(ORBAT._Closure$__.$I.method_14)) : ORBAT._Closure$__.$I98-3), (ORBAT._Closure$__.$I98-4 == null) ? (ORBAT._Closure$__.$I98-4 = new Func<Aircraft, string>(ORBAT._Closure$__.$I.method_15)) : ORBAT._Closure$__.$I98-4, new Class440<string[]>(true)));
							IEnumerable<ActiveUnit> enumerable3 = Enumerable.OrderBy<ActiveUnit, string>(list3, (ORBAT._Closure$__.$I98-5 == null) ? (ORBAT._Closure$__.$I98-5 = new Func<ActiveUnit, string>(ORBAT._Closure$__.$I.method_16)) : ORBAT._Closure$__.$I98-5);
							try
							{
								foreach (Aircraft aircraft in enumerable2)
								{
									Class126 class2 = null;
									string string_ = aircraft.string_2;
									try
									{
										foreach (Class126 class3 in @class.method_22())
										{
											if (Operators.CompareString(class3.Tag.ToString(), string_, false) == 0)
											{
												class2 = class3;
											}
										}
									}
									finally
									{
										List<Class126>.Enumerator enumerator3;
										((IDisposable)enumerator3).Dispose();
									}
									if (Information.IsNothing(class2))
									{
										class2 = new Class126(aircraft.string_2);
										@class.method_22().method_4(class2);
										class2.Tag = string_;
									}
									string string_2 = this.method_22(aircraft);
									Class126 class4 = new Class126(string_2);
									class2.method_22().method_4(class4);
									class4.Tag = aircraft;
									class4.method_38(this.method_15(aircraft));
									class2.method_7(Conversions.ToString(class2.method_22().Count) + "x " + Misc.smethod_9(Conversions.ToString(class2.Tag)));
									class2 = null;
								}
							}
							finally
							{
								IEnumerator<Aircraft> enumerator2;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
								}
							}
							try
							{
								foreach (ActiveUnit activeUnit2 in enumerable3)
								{
									string text = activeUnit2.Name;
									if (activeUnit2.bool_1)
									{
										Group group = (Group)activeUnit2;
										if (group.method_143() == Group.GroupType.AirGroup && group.vmethod_141().Values.Count > 0)
										{
											string text2;
											if (string.IsNullOrEmpty(Enumerable.ElementAtOrDefault<ActiveUnit>(group.vmethod_141().Values, 0).string_2))
											{
												text2 = "";
											}
											else
											{
												text2 = " " + Enumerable.ElementAtOrDefault<ActiveUnit>(group.vmethod_141().Values, 0).string_2;
											}
											text = string.Concat(new string[]
											{
												text,
												" (",
												Conversions.ToString(group.vmethod_141().Count),
												"x",
												text2,
												")"
											});
										}
									}
									Class126 class5 = new Class126(text);
									@class.method_22().method_4(class5);
									class5.Tag = activeUnit2;
									if (activeUnit2.bool_1)
									{
										try
										{
											foreach (ActiveUnit activeUnit3 in ((Group)activeUnit2).vmethod_141().Values)
											{
												if (activeUnit3.bool_3)
												{
													text = this.method_22((Aircraft)activeUnit3);
												}
												else
												{
													text = activeUnit3.Name;
												}
												Class126 class6 = new Class126(text);
												class5.method_22().method_4(class6);
												class6.method_38(this.method_15(activeUnit2));
												class6.Tag = activeUnit3;
											}
											continue;
										}
										finally
										{
											IEnumerator<ActiveUnit> enumerator5;
											if (enumerator5 != null)
											{
												enumerator5.Dispose();
											}
										}
									}
									class5.method_38(this.method_15(activeUnit2));
								}
							}
							finally
							{
								IEnumerator<ActiveUnit> enumerator4;
								if (enumerator4 != null)
								{
									enumerator4.Dispose();
								}
							}
							try
							{
								foreach (Aircraft aircraft2 in list4)
								{
									Class126 class7 = null;
									string string_3 = aircraft2.method_157().method_7().string_4;
									try
									{
										foreach (Class126 class8 in @class.method_22())
										{
											if (Operators.CompareString(class8.Tag.ToString(), string_3, false) == 0)
											{
												class7 = class8;
											}
										}
									}
									finally
									{
										List<Class126>.Enumerator enumerator7;
										((IDisposable)enumerator7).Dispose();
									}
									if (Information.IsNothing(class7))
									{
										class7 = new Class126(aircraft2.string_2);
										@class.method_22().method_4(class7);
										class7.Tag = string_3;
									}
									string string_4 = this.method_22(aircraft2);
									Class126 class9 = new Class126(string_4);
									class7.method_22().method_4(class9);
									class9.Tag = aircraft2;
									class9.method_38(this.method_15(aircraft2));
									class7.method_7(string.Concat(new string[]
									{
										"Flight ",
										string_3,
										" (",
										Conversions.ToString(class7.method_22().Count),
										"x ",
										Misc.smethod_9(aircraft2.string_2),
										")"
									}));
									class7 = null;
								}
							}
							finally
							{
								List<Aircraft>.Enumerator enumerator6;
								((IDisposable)enumerator6).Dispose();
							}
							@class.method_21(true);
						}
						else if (mission.enum88_0 == Mission.Enum88.const_2)
						{
							Class126 class10 = new Class126(mission.Name);
							this.vmethod_14().method_19().method_4(class10);
							class10.method_38(Color.LightGreen);
							class10.Tag = mission;
							List<Aircraft> list5 = new List<Aircraft>();
							List<ActiveUnit> list6 = new List<ActiveUnit>();
							foreach (ActiveUnit activeUnit4 in Client.smethod_50().activeUnit_0)
							{
								if (!(activeUnit4.method_120() | (activeUnit4.bool_2 && ((Weapon)activeUnit4).method_167() == Weapon._WeaponType.Sonobuoy)) && Information.IsNothing(activeUnit4.vmethod_101()) && activeUnit4.vmethod_103() == mission)
								{
									if (activeUnit4.bool_3)
									{
										list5.Add((Aircraft)activeUnit4);
									}
									else if (!activeUnit4.bool_5 || !((Submarine)activeUnit4).method_159())
									{
										list6.Add(activeUnit4);
									}
								}
							}
							Class342 class11 = (Class342)mission;
							try
							{
								foreach (Mission mission2 in class11.list_5)
								{
									Class126 class12 = new Class126(mission2.Name);
									class10.method_22().method_4(class12);
									if (mission2.method_12())
									{
										class12.method_38(Color.LightGreen);
									}
									else
									{
										class12.method_38(Color.Red);
										class12.method_40(new Font(this.Font, FontStyle.Italic));
									}
									class12.Tag = mission2;
									List<Aircraft> list7 = new List<Aircraft>();
									List<Aircraft> list8 = new List<Aircraft>();
									List<ActiveUnit> list9 = new List<ActiveUnit>();
									foreach (ActiveUnit activeUnit5 in Client.smethod_50().activeUnit_0)
									{
										if (!(activeUnit5.method_120() | (activeUnit5.bool_2 && ((Weapon)activeUnit5).method_167() == Weapon._WeaponType.Sonobuoy)) && activeUnit5.vmethod_101() == mission2)
										{
											if (activeUnit5.bool_3)
											{
												if (!Information.IsNothing(activeUnit5.vmethod_85().method_7()))
												{
													if (activeUnit5.method_120())
													{
														if (!Information.IsNothing(activeUnit5.vmethod_65(false)) && !list9.Contains(activeUnit5.vmethod_65(false)))
														{
															list9.Add(activeUnit5.vmethod_65(false));
														}
													}
													else
													{
														list8.Add((Aircraft)activeUnit5);
													}
												}
												else if (activeUnit5.method_120())
												{
													if (!Information.IsNothing(activeUnit5.vmethod_65(false)) && !list9.Contains(activeUnit5.vmethod_65(false)))
													{
														list9.Add(activeUnit5.vmethod_65(false));
													}
												}
												else
												{
													list7.Add((Aircraft)activeUnit5);
												}
											}
											else if (!activeUnit5.bool_5 || !((Submarine)activeUnit5).method_159())
											{
												list9.Add(activeUnit5);
											}
										}
									}
									IEnumerable<Aircraft> enumerable4 = Enumerable.ThenBy<Aircraft, string>(Enumerable.OrderBy<Aircraft, string>(list7, (ORBAT._Closure$__.$I98-6 == null) ? (ORBAT._Closure$__.$I98-6 = new Func<Aircraft, string>(ORBAT._Closure$__.$I.method_17)) : ORBAT._Closure$__.$I98-6), new Func<Aircraft, string>(this.method_35));
									List<Aircraft> list10 = Enumerable.ToList<Aircraft>(Enumerable.OrderBy<Aircraft, string>(Enumerable.Select<Aircraft, Aircraft>(list8, (ORBAT._Closure$__.$I98-8 == null) ? (ORBAT._Closure$__.$I98-8 = new Func<Aircraft, Aircraft>(ORBAT._Closure$__.$I.method_18)) : ORBAT._Closure$__.$I98-8), (ORBAT._Closure$__.$I98-9 == null) ? (ORBAT._Closure$__.$I98-9 = new Func<Aircraft, string>(ORBAT._Closure$__.$I.method_19)) : ORBAT._Closure$__.$I98-9, new Class440<string[]>(true)));
									IEnumerable<ActiveUnit> enumerable5 = Enumerable.OrderBy<ActiveUnit, string>(list9, (ORBAT._Closure$__.$I98-10 == null) ? (ORBAT._Closure$__.$I98-10 = new Func<ActiveUnit, string>(ORBAT._Closure$__.$I.method_20)) : ORBAT._Closure$__.$I98-10);
									try
									{
										foreach (Aircraft aircraft3 in enumerable4)
										{
											Class126 class13 = null;
											string string_5 = aircraft3.string_2;
											try
											{
												foreach (Class126 class14 in class12.method_22())
												{
													if (Operators.CompareString(class14.Tag.ToString(), string_5, false) == 0)
													{
														class13 = class14;
													}
												}
											}
											finally
											{
												List<Class126>.Enumerator enumerator10;
												((IDisposable)enumerator10).Dispose();
											}
											if (Information.IsNothing(class13))
											{
												class13 = new Class126(aircraft3.string_2);
												class12.method_22().method_4(class13);
												class13.Tag = string_5;
											}
											string string_6 = this.method_22(aircraft3);
											Class126 class15 = new Class126(string_6);
											class13.method_22().method_4(class15);
											class15.Tag = aircraft3;
											class15.method_38(this.method_15(aircraft3));
											class13.method_7(Conversions.ToString(class13.method_22().Count) + "x " + Misc.smethod_9(Conversions.ToString(class13.Tag)));
											class13 = null;
										}
									}
									finally
									{
										IEnumerator<Aircraft> enumerator9;
										if (enumerator9 != null)
										{
											enumerator9.Dispose();
										}
									}
									try
									{
										foreach (ActiveUnit activeUnit6 in enumerable5)
										{
											string name = activeUnit6.Name;
											string string_7;
											if (string.IsNullOrEmpty(activeUnit6.string_2))
											{
												string_7 = name;
											}
											else
											{
												string_7 = name + " (" + Misc.smethod_9(activeUnit6.string_2) + ")";
											}
											Class126 class16 = new Class126(string_7);
											class12.method_22().method_4(class16);
											class16.Tag = activeUnit6;
											if (activeUnit6.bool_1)
											{
												try
												{
													foreach (ActiveUnit activeUnit7 in ((Group)activeUnit6).vmethod_141().Values)
													{
														Class126 class17 = new Class126(activeUnit7.Name + " (" + Misc.smethod_9(activeUnit7.string_2) + ")");
														class16.method_22().method_4(class17);
														class17.method_38(this.method_15(activeUnit7));
														class17.Tag = activeUnit7;
													}
													continue;
												}
												finally
												{
													IEnumerator<ActiveUnit> enumerator12;
													if (enumerator12 != null)
													{
														enumerator12.Dispose();
													}
												}
											}
											class16.method_38(this.method_15(activeUnit6));
										}
									}
									finally
									{
										IEnumerator<ActiveUnit> enumerator11;
										if (enumerator11 != null)
										{
											enumerator11.Dispose();
										}
									}
									try
									{
										foreach (Aircraft aircraft4 in list10)
										{
											Class126 class18 = null;
											string string_8 = aircraft4.method_157().method_7().string_4;
											try
											{
												foreach (Class126 class19 in class12.method_22())
												{
													if (Operators.CompareString(class19.Tag.ToString(), string_8, false) == 0)
													{
														class18 = class19;
													}
												}
											}
											finally
											{
												List<Class126>.Enumerator enumerator14;
												((IDisposable)enumerator14).Dispose();
											}
											if (Information.IsNothing(class18))
											{
												class18 = new Class126(aircraft4.string_2);
												class12.method_22().method_4(class18);
												class18.Tag = string_8;
											}
											string string_9 = this.method_22(aircraft4);
											Class126 class20 = new Class126(string_9);
											class18.method_22().method_4(class20);
											class20.Tag = aircraft4;
											class20.method_38(this.method_15(aircraft4));
											class18.method_7(string.Concat(new string[]
											{
												"Flight ",
												string_8,
												" (",
												Conversions.ToString(class18.method_22().Count),
												"x ",
												Misc.smethod_9(aircraft4.string_2),
												")"
											}));
											class18 = null;
										}
									}
									finally
									{
										List<Aircraft>.Enumerator enumerator13;
										((IDisposable)enumerator13).Dispose();
									}
									class12.method_21(true);
								}
							}
							finally
							{
								List<Mission>.Enumerator enumerator8;
								((IDisposable)enumerator8).Dispose();
							}
							IEnumerable<Aircraft> enumerable6 = Enumerable.ThenBy<Aircraft, string>(Enumerable.OrderBy<Aircraft, string>(list5, (ORBAT._Closure$__.$I98-11 == null) ? (ORBAT._Closure$__.$I98-11 = new Func<Aircraft, string>(ORBAT._Closure$__.$I.method_21)) : ORBAT._Closure$__.$I98-11), new Func<Aircraft, string>(this.method_36));
							IEnumerable<ActiveUnit> enumerable7 = Enumerable.OrderBy<ActiveUnit, string>(list6, (ORBAT._Closure$__.$I98-13 == null) ? (ORBAT._Closure$__.$I98-13 = new Func<ActiveUnit, string>(ORBAT._Closure$__.$I.method_22)) : ORBAT._Closure$__.$I98-13);
							try
							{
								foreach (Aircraft aircraft5 in enumerable6)
								{
									Class126 class21 = null;
									string string_10 = aircraft5.string_2;
									try
									{
										foreach (Class126 class22 in class10.method_22())
										{
											if (Operators.CompareString(class22.Tag.ToString(), string_10, false) == 0)
											{
												class21 = class22;
											}
										}
									}
									finally
									{
										List<Class126>.Enumerator enumerator16;
										((IDisposable)enumerator16).Dispose();
									}
									if (Information.IsNothing(class21))
									{
										class21 = new Class126(aircraft5.string_2);
										class10.method_22().method_4(class21);
										class21.Tag = string_10;
									}
									string string_11 = this.method_22(aircraft5);
									Class126 class23 = new Class126(string_11);
									class21.method_22().method_4(class23);
									class23.Tag = aircraft5;
									class23.method_38(this.method_15(aircraft5));
									class21.method_7(Conversions.ToString(class21.method_22().Count) + "x " + Misc.smethod_9(Conversions.ToString(class21.Tag)));
									class21 = null;
								}
							}
							finally
							{
								IEnumerator<Aircraft> enumerator15;
								if (enumerator15 != null)
								{
									enumerator15.Dispose();
								}
							}
							try
							{
								foreach (ActiveUnit activeUnit8 in enumerable7)
								{
									string name2 = activeUnit8.Name;
									string string_12;
									if (string.IsNullOrEmpty(activeUnit8.string_2))
									{
										string_12 = name2;
									}
									else
									{
										string_12 = name2 + " (" + Misc.smethod_9(activeUnit8.string_2) + ")";
									}
									Class126 class24 = new Class126(string_12);
									class10.method_22().method_4(class24);
									class24.method_38(this.method_15(activeUnit8));
									class24.Tag = activeUnit8;
									if (activeUnit8.bool_1)
									{
										try
										{
											foreach (ActiveUnit activeUnit9 in ((Group)activeUnit8).vmethod_141().Values)
											{
												Class126 class25 = new Class126(this.method_16(activeUnit9));
												class24.method_22().method_4(class25);
												class25.method_38(this.method_15(activeUnit9));
												class25.Tag = activeUnit9;
											}
										}
										finally
										{
											IEnumerator<ActiveUnit> enumerator18;
											if (enumerator18 != null)
											{
												enumerator18.Dispose();
											}
										}
									}
								}
							}
							finally
							{
								IEnumerator<ActiveUnit> enumerator17;
								if (enumerator17 != null)
								{
									enumerator17.Dispose();
								}
							}
							class10.method_21(true);
						}
					}
				}
				finally
				{
					IEnumerator<Mission> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x060086BB RID: 34491 RVA: 0x004855D4 File Offset: 0x004837D4
		private void method_19()
		{
			if (this.vmethod_22().method_2().Count > 0)
			{
				this.vmethod_22().method_2().Clear();
			}
			List<Contact> list = new List<Contact>(Client.smethod_50().method_11().Count + Client.smethod_50().method_12().Count);
			list.AddRange(Client.smethod_50().method_44());
			list.AddRange(Client.smethod_50().method_46());
			list = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, string>(list, (ORBAT._Closure$__.$I99-0 == null) ? (ORBAT._Closure$__.$I99-0 = new Func<Contact, string>(ORBAT._Closure$__.$I.method_23)) : ORBAT._Closure$__.$I99-0));
			try
			{
				foreach (Contact contact in list)
				{
					if (!contact.activeUnit_0.method_120() || !contact.activeUnit_0.vmethod_65(false).method_140())
					{
						Class48 @class = this.vmethod_22().method_2().method_1(new object[0]);
						this.method_20(@class, contact);
						if (contact.activeUnit_0.bool_1)
						{
							@class.method_7().method_0("temp");
						}
					}
				}
			}
			finally
			{
				List<Contact>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x060086BC RID: 34492 RVA: 0x00485710 File Offset: 0x00483910
		private void method_20(Class48 class48_0, Contact contact_0)
		{
			if (contact_0.activeUnit_0.bool_1)
			{
				class48_0.SetValues(new object[]
				{
					contact_0.Name,
					Contact.smethod_4(contact_0),
					contact_0.method_130(Client.smethod_50()).ToString()
				});
			}
			else
			{
				class48_0.SetValues(new object[]
				{
					contact_0.Name,
					Contact.smethod_4(contact_0),
					contact_0.method_130(Client.smethod_50()).ToString(),
					(contact_0.method_74(Client.smethod_50()) != null) ? (Misc.smethod_54(contact_0.method_74(Client.smethod_50())) + " (" + Misc.smethod_11((long)Math.Round((double)contact_0.method_59()), Aircraft_AirOps.Enum44.const_0, false, false) + " ago)") : "---",
					this.method_31(contact_0)
				});
			}
			class48_0.Tag = contact_0.activeUnit_0.string_0;
			class48_0.DefaultCellStyle.ForeColor = Client.smethod_29(contact_0.method_130(Client.smethod_50()));
		}

		// Token: 0x060086BD RID: 34493 RVA: 0x00485830 File Offset: 0x00483A30
		private string method_21(Aircraft aircraft_0)
		{
			ActiveUnit activeUnit = aircraft_0.method_164().method_30();
			string result;
			if (Information.IsNothing(activeUnit))
			{
				result = "Airborne";
			}
			else
			{
				result = activeUnit.Name;
			}
			return result;
		}

		// Token: 0x060086BE RID: 34494 RVA: 0x00485864 File Offset: 0x00483A64
		private string method_22(Aircraft aircraft_0)
		{
			string text = null;
			string result;
			if (aircraft_0.method_147(ref text) == Aircraft_AirOps.Enum44.const_2)
			{
				result = "[UNAVAILABLE] " + aircraft_0.Name;
			}
			else
			{
				string text2;
				if (aircraft_0.vmethod_127())
				{
					text2 = "Airborne";
				}
				else
				{
					text2 = aircraft_0.method_164().method_30().Name;
				}
				string text3;
				if (Information.IsNothing(aircraft_0.method_167()))
				{
					text3 = "";
				}
				else
				{
					text3 = " (" + aircraft_0.method_167().Name + ")";
				}
				result = string.Concat(new string[]
				{
					aircraft_0.Name,
					text3,
					" (",
					text2,
					")"
				});
			}
			return result;
		}

		// Token: 0x060086BF RID: 34495 RVA: 0x00485910 File Offset: 0x00483B10
		private void ORBAT_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Escape && base.Visible) || (e.KeyCode == Keys.O && base.Visible))
			{
				base.Close();
				return;
			}
			if (base.Visible)
			{
				if (e.KeyCode == Keys.Prior || e.KeyCode == Keys.Next || e.KeyCode == Keys.End || e.KeyCode == Keys.Home || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
				{
					return;
				}
				if (e.KeyCode == Keys.Add)
				{
					if (Operators.CompareString(((ContainerControl)sender).ActiveControl.Name, "TV_ByMission", false) == 0)
					{
						Class2558.smethod_7(this.vmethod_14());
					}
					else
					{
						Class2558.smethod_7(this.vmethod_12());
					}
					e.Handled = true;
					e.SuppressKeyPress = true;
					return;
				}
				if (e.KeyCode == Keys.Subtract)
				{
					if (Operators.CompareString(((ContainerControl)sender).ActiveControl.Name, "TV_ByMission", false) == 0)
					{
						Class2558.smethod_8(this.vmethod_14());
					}
					else
					{
						Class2558.smethod_8(this.vmethod_12());
					}
					e.Handled = true;
					e.SuppressKeyPress = true;
					return;
				}
				if (e.KeyCode == Keys.Subtract || (e.KeyCode == Keys.C && e.Modifiers == Keys.Control) || (e.KeyCode == Keys.X && e.Modifiers == Keys.Control))
				{
					return;
				}
			}
			if (!this.vmethod_18().Focused)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060086C0 RID: 34496 RVA: 0x00485AB4 File Offset: 0x00483CB4
		private void method_23(object sender, EventArgs e)
		{
			GlobalVariables.ProficiencyLevel? nullable_;
			switch (this.vmethod_10().SelectedIndex)
			{
			case 0:
				nullable_ = new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Novice);
				break;
			case 1:
				nullable_ = new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Cadet);
				break;
			case 2:
				nullable_ = new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Regular);
				break;
			case 3:
				nullable_ = new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Veteran);
				break;
			case 4:
				nullable_ = new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Ace);
				break;
			case 5:
				nullable_ = null;
				break;
			}
			int selectedIndex = this.vmethod_0().SelectedIndex;
			if (selectedIndex != 0)
			{
				if (selectedIndex != 1)
				{
					return;
				}
				try
				{
					foreach (Class126 @class in this.vmethod_14().method_21())
					{
						try
						{
							if (((Unit)@class.Tag).bool_0)
							{
								((ActiveUnit)@class.Tag).vmethod_54(nullable_);
								@class.method_38(this.method_15((ActiveUnit)@class.Tag));
								if (((ActiveUnit)@class.Tag).bool_1)
								{
									try
									{
										foreach (Class126 class2 in @class.method_22())
										{
											class2.method_38(this.method_15((ActiveUnit)class2.Tag));
										}
									}
									finally
									{
										List<Class126>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
								}
							}
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 200402", ex.Message);
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
					}
					return;
				}
				finally
				{
					IEnumerator<Class126> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			try
			{
				foreach (Class126 class3 in this.vmethod_12().method_21())
				{
					((ActiveUnit)class3.Tag).vmethod_54(nullable_);
					class3.method_38(this.method_15((ActiveUnit)class3.Tag));
					if (((ActiveUnit)class3.Tag).bool_1)
					{
						try
						{
							foreach (Class126 class4 in class3.method_22())
							{
								class4.method_38(this.method_15((ActiveUnit)class4.Tag));
							}
						}
						finally
						{
							List<Class126>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator<Class126> enumerator3;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
			}
		}

		// Token: 0x060086C1 RID: 34497 RVA: 0x00044820 File Offset: 0x00042A20
		private void ORBAT_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x060086C2 RID: 34498 RVA: 0x00485D94 File Offset: 0x00483F94
		private void method_24(object sender, EventArgs e)
		{
			if (this.vmethod_12().method_21().Count == 1)
			{
				ActiveUnit activeUnit = (ActiveUnit)this.vmethod_12().method_21()[0].Tag;
				if (activeUnit.vmethod_127())
				{
					Class2413.smethod_2().method_41().method_161(true, new GeoPoint(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
					Client.smethod_56(activeUnit, true);
				}
				GlobalVariables.ProficiencyLevel? proficiencyLevel = activeUnit.vmethod_53();
				int? num = (proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					this.vmethod_10().SelectedIndex = 0;
					return;
				}
				num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					this.vmethod_10().SelectedIndex = 1;
					return;
				}
				num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
				{
					this.vmethod_10().SelectedIndex = 2;
					return;
				}
				num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
				{
					this.vmethod_10().SelectedIndex = 3;
					return;
				}
				num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
				if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
				{
					this.vmethod_10().SelectedIndex = 4;
				}
			}
		}

		// Token: 0x060086C3 RID: 34499 RVA: 0x00485FE8 File Offset: 0x004841E8
		private void method_25(object sender, EventArgs e)
		{
			try
			{
				if (this.vmethod_14().method_21().Count == 1)
				{
					try
					{
						if (this.vmethod_14().method_21()[0].Tag.GetType().BaseType != typeof(Mission) && this.vmethod_14().method_21()[0].Tag.GetType() != typeof(string) && ((Unit)this.vmethod_14().method_21()[0].Tag).bool_0)
						{
							ActiveUnit activeUnit = (ActiveUnit)this.vmethod_14().method_21()[0].Tag;
							Class2413.smethod_2().method_41().method_161(true, new GeoPoint(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
							Client.smethod_56(activeUnit, true);
							GlobalVariables.ProficiencyLevel? proficiencyLevel = activeUnit.vmethod_53();
							int? num = (proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								this.vmethod_10().SelectedIndex = 0;
							}
							else
							{
								num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									this.vmethod_10().SelectedIndex = 1;
								}
								else
								{
									num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										this.vmethod_10().SelectedIndex = 2;
									}
									else
									{
										num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
										if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											this.vmethod_10().SelectedIndex = 3;
										}
										else
										{
											num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
											if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
											{
												this.vmethod_10().SelectedIndex = 4;
											}
										}
									}
								}
							}
						}
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 200401", ex.Message);
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
				}
			}
			catch (Exception ex2)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060086C4 RID: 34500 RVA: 0x00051315 File Offset: 0x0004F515
		private void ORBAT_Shown(object sender, EventArgs e)
		{
			this.method_14();
		}

		// Token: 0x060086C5 RID: 34501 RVA: 0x0005131D File Offset: 0x0004F51D
		private void method_26(object sender, EventArgs e)
		{
			this.method_28();
		}

		// Token: 0x060086C6 RID: 34502 RVA: 0x0005131D File Offset: 0x0004F51D
		private void method_27(object sender, KeyPressEventArgs e)
		{
			this.method_28();
		}

		// Token: 0x060086C7 RID: 34503 RVA: 0x0048634C File Offset: 0x0048454C
		private void method_28()
		{
			this.vmethod_12().method_16(this.vmethod_18().Text);
			this.vmethod_14().method_16(this.vmethod_18().Text);
			try
			{
				foreach (Class48 @class in this.vmethod_22().method_2())
				{
					if (@class.Visible)
					{
						if (Conversions.ToString(((DataGridViewTextBoxCell)@class.Cells[0]).Value).ToLower().Contains(this.vmethod_18().Text.ToLower()))
						{
							@class.DefaultCellStyle.BackColor = Color.DarkGreen;
						}
						else
						{
							@class.DefaultCellStyle.BackColor = this.vmethod_22().DefaultCellStyle.BackColor;
						}
					}
				}
			}
			finally
			{
				IEnumerator<Class48> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060086C8 RID: 34504 RVA: 0x00486430 File Offset: 0x00484630
		private void method_29(object sender, EventArgs1 e)
		{
			Contact contact = Client.smethod_50().method_12()[Conversions.ToString(e.method_0().Tag)];
			if (contact != null)
			{
				Group group = (Group)contact.activeUnit_0;
				e.method_0().method_7().Clear();
				try
				{
					foreach (Contact contact2 in Client.smethod_50().method_44())
					{
						if (contact2.activeUnit_0.method_120() && contact2.activeUnit_0.vmethod_65(false) == group)
						{
							Class48 @class = e.method_0().method_7().method_1(new object[]
							{
								contact2.Name,
								contact2.method_56(),
								contact2.method_130(Client.smethod_50()).ToString(),
								(contact2.method_74(Client.smethod_50()) != null) ? (Misc.smethod_54(contact2.method_74(Client.smethod_50())) + " (" + Misc.smethod_11((long)Math.Round((double)contact2.method_59()), Aircraft_AirOps.Enum44.const_0, false, false) + " ago)") : "---",
								this.method_31(contact2)
							});
							@class.Tag = contact2.activeUnit_0.string_0;
							@class.DefaultCellStyle.ForeColor = Client.smethod_29(contact2.method_130(Client.smethod_50()));
						}
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x060086C9 RID: 34505 RVA: 0x004865C4 File Offset: 0x004847C4
		private void method_30(object sender, EventArgs e)
		{
			if (this.vmethod_22().method_5() != null)
			{
				string key = Conversions.ToString(this.vmethod_22().method_5().Tag);
				if (Client.smethod_50().method_11().ContainsKey(key))
				{
					Contact contact = Client.smethod_50().method_11()[key];
					Class2413.smethod_2().method_41().method_161(true, new GeoPoint(contact.vmethod_28(null), contact.vmethod_30(null)));
					Client.smethod_56(contact, true);
					if (contact.activeUnit_0.method_120() && Client.smethod_52().enum87_0 == Class285.Enum87.const_0)
					{
						Class2413.smethod_2().method_41().method_177();
						return;
					}
				}
				else if (Client.smethod_50().method_12().ContainsKey(key))
				{
					Contact contact = Client.smethod_50().method_12()[key];
					Class2413.smethod_2().method_41().method_161(true, new GeoPoint(contact.vmethod_28(null), contact.vmethod_30(null)));
					Client.smethod_56(contact, true);
				}
			}
		}

		// Token: 0x060086CA RID: 34506 RVA: 0x004866DC File Offset: 0x004848DC
		private object method_31(Contact contact_0)
		{
			object result;
			if (contact_0.method_73(Client.smethod_50()).Count > 0)
			{
				Dictionary<string, int> dictionary = new Dictionary<string, int>();
				try
				{
					foreach (Contact.Class269 @class in contact_0.method_73(Client.smethod_50()))
					{
						string text;
						switch (@class.identificationStatus_0)
						{
						case Contact_Base.IdentificationStatus.Unknown:
							text = "Unknown unit";
							break;
						case Contact_Base.IdentificationStatus.KnownDomain:
							try
							{
								ActiveUnit activeUnit = Client.smethod_46().vmethod_0()[@class.string_0];
								text = Misc.smethod_56(activeUnit.vmethod_121()) + " " + activeUnit.method_63();
								break;
							}
							catch (Exception ex)
							{
								ex.Data.Add("Error at 999999", ex.Message);
								GameGeneral.smethod_25(ref ex);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								text = "Unknown unit";
								break;
							}
							goto IL_F6;
						case Contact_Base.IdentificationStatus.KnownType:
							goto IL_F6;
						case Contact_Base.IdentificationStatus.KnownClass:
							goto IL_175;
						case Contact_Base.IdentificationStatus.PreciseID:
							goto IL_1D7;
						}
						IL_236:
						text = text + " (Last Recon: " + ((@class.float_0 > 0f) ? (Misc.smethod_11((long)Math.Round((double)@class.float_0), Aircraft_AirOps.Enum44.const_0, false, true) + " ago)") : "Now)");
						if (dictionary.ContainsKey(text))
						{
							dictionary[text]++;
							continue;
						}
						dictionary.Add(text, 1);
						continue;
						IL_F6:
						try
						{
							ActiveUnit activeUnit2 = Client.smethod_46().vmethod_0()[@class.string_0];
							text = Misc.smethod_56(activeUnit2.vmethod_121()) + " " + activeUnit2.vmethod_58();
							goto IL_236;
						}
						catch (Exception ex2)
						{
							ex2.Data.Add("Error at 200409", ex2.Message);
							GameGeneral.smethod_25(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							text = "Unknown unit";
							goto IL_236;
						}
						IL_175:
						try
						{
							text = Client.smethod_46().vmethod_0()[@class.string_0].string_2;
							goto IL_236;
						}
						catch (Exception ex3)
						{
							ex3.Data.Add("Error at 200410", ex3.Message);
							GameGeneral.smethod_25(ref ex3);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							text = "Unknown unit";
							goto IL_236;
						}
						IL_1D7:
						try
						{
							text = Client.smethod_46().vmethod_0()[@class.string_0].Name;
						}
						catch (Exception ex4)
						{
							ex4.Data.Add("Error at 200411", ex4.Message);
							GameGeneral.smethod_25(ref ex4);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							text = "Unknown unit";
						}
						goto IL_236;
					}
				}
				finally
				{
					List<Contact.Class269>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				List<string> list = new List<string>();
				try
				{
					foreach (KeyValuePair<string, int> keyValuePair in dictionary)
					{
						list.Add(Conversions.ToString(keyValuePair.Value) + "x " + keyValuePair.Key);
					}
				}
				finally
				{
					Dictionary<string, int>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				result = string.Join("\r\n", list);
			}
			else
			{
				result = "---";
			}
			return result;
		}

		// Token: 0x060086CB RID: 34507 RVA: 0x00486A9C File Offset: 0x00484C9C
		private void method_32(object sender, EventArgs e)
		{
			if (Client.smethod_0().method_0() == Class279.Enum68.const_1)
			{
				int num = this.vmethod_22().method_2().Count - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						Class48 @class = this.vmethod_22().method_2()[i];
						Contact contact = null;
						if (Client.smethod_50().method_11().ContainsKey(@class.Tag.ToString()))
						{
							contact = Client.smethod_50().method_11()[@class.Tag.ToString()];
						}
						else if (Client.smethod_50().method_12().ContainsKey(@class.Tag.ToString()))
						{
							contact = Client.smethod_50().method_12()[@class.Tag.ToString()];
						}
						if (contact == null)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
						else
						{
							this.method_20(@class, contact);
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x060086CC RID: 34508 RVA: 0x00486B9C File Offset: 0x00484D9C
		private void method_33(object sender, EventArgs e)
		{
			switch (this.vmethod_0().SelectedIndex)
			{
			case 0:
				this.method_17();
				return;
			case 1:
				this.method_18();
				return;
			case 2:
				this.method_19();
				return;
			default:
				return;
			}
		}

		// Token: 0x060086CD RID: 34509 RVA: 0x00051325 File Offset: 0x0004F525
		[CompilerGenerated]
		private string method_34(Aircraft aircraft_0)
		{
			return this.method_21(aircraft_0);
		}

		// Token: 0x060086CE RID: 34510 RVA: 0x00051325 File Offset: 0x0004F525
		[CompilerGenerated]
		private string method_35(Aircraft aircraft_0)
		{
			return this.method_21(aircraft_0);
		}

		// Token: 0x060086CF RID: 34511 RVA: 0x00051325 File Offset: 0x0004F525
		[CompilerGenerated]
		private string method_36(Aircraft aircraft_0)
		{
			return this.method_21(aircraft_0);
		}

		// Token: 0x04004952 RID: 18770
		[CompilerGenerated]
		[AccessedThroughProperty("TabControl1")]
		private Control12 control12_0;

		// Token: 0x04004953 RID: 18771
		[AccessedThroughProperty("TabPage1")]
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x04004954 RID: 18772
		[AccessedThroughProperty("TabPage2")]
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x04004955 RID: 18773
		[AccessedThroughProperty("Label_Proficiency")]
		[CompilerGenerated]
		private Class116 class116_0;

		// Token: 0x04004956 RID: 18774
		[CompilerGenerated]
		[AccessedThroughProperty("Label_SetUnitProficiency")]
		private Class116 class116_1;

		// Token: 0x04004957 RID: 18775
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Proficiency")]
		private Class2451 class2451_0;

		// Token: 0x04004958 RID: 18776
		[AccessedThroughProperty("TV_ByGroup")]
		[CompilerGenerated]
		private Control5 control5_0;

		// Token: 0x04004959 RID: 18777
		[CompilerGenerated]
		[AccessedThroughProperty("TV_ByMission")]
		private Control5 control5_1;

		// Token: 0x0400495A RID: 18778
		[AccessedThroughProperty("DarkLabel1")]
		[CompilerGenerated]
		private Class116 class116_2;

		// Token: 0x0400495B RID: 18779
		[AccessedThroughProperty("TB_SearchOOB")]
		[CompilerGenerated]
		private Class124 class124_0;

		// Token: 0x0400495C RID: 18780
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage3")]
		private TabPage tabPage_2;

		// Token: 0x0400495D RID: 18781
		[AccessedThroughProperty("TGV_Contacts")]
		[CompilerGenerated]
		private Class50 class50_0;

		// Token: 0x0400495E RID: 18782
		[CompilerGenerated]
		[AccessedThroughProperty("ContactName")]
		private Class44 class44_0;

		// Token: 0x0400495F RID: 18783
		[CompilerGenerated]
		[AccessedThroughProperty("ContactType")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04004960 RID: 18784
		[CompilerGenerated]
		[AccessedThroughProperty("ContactPosture")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04004961 RID: 18785
		[AccessedThroughProperty("ContactBDA")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04004962 RID: 18786
		[CompilerGenerated]
		[AccessedThroughProperty("ContactHostedUnits")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04004963 RID: 18787
		[AccessedThroughProperty("Timer1")]
		[CompilerGenerated]
		private Timer timer_0;

		// Token: 0x04004964 RID: 18788
		private object object_0;

		// Token: 0x02000EED RID: 3821
		[CompilerGenerated]
		internal sealed class Class2514
		{
			// Token: 0x060086D0 RID: 34512 RVA: 0x0005132E File Offset: 0x0004F52E
			public Class2514(ORBAT.Class2514 class2514_0)
			{
				if (class2514_0 != null)
				{
					this.class48_0 = class2514_0.class48_0;
				}
			}

			// Token: 0x060086D1 RID: 34513 RVA: 0x00051345 File Offset: 0x0004F545
			internal void method_0()
			{
				this.orbat_0.vmethod_22().method_2().Remove(this.class48_0);
			}

			// Token: 0x04004965 RID: 18789
			public Class48 class48_0;

			// Token: 0x04004966 RID: 18790
			public ORBAT orbat_0;
		}

		// Token: 0x02000EEE RID: 3822
		[CompilerGenerated]
		internal sealed class Class2515
		{
			// Token: 0x060086D3 RID: 34515 RVA: 0x00486BDC File Offset: 0x00484DDC
			internal void method_0()
			{
				Class48 @class = this.orbat_0.vmethod_22().method_2().method_1(new object[0]);
				this.orbat_0.method_20(@class, this.contact_0);
				if (this.contact_0.activeUnit_0.bool_1 && ((Group)this.contact_0.activeUnit_0).method_140())
				{
					@class.method_7().method_0("temp");
				}
			}

			// Token: 0x04004967 RID: 18791
			public Contact contact_0;

			// Token: 0x04004968 RID: 18792
			public ORBAT orbat_0;
		}

		// Token: 0x02000EEF RID: 3823
		[CompilerGenerated]
		internal sealed class Class2516
		{
			// Token: 0x060086D5 RID: 34517 RVA: 0x00486C54 File Offset: 0x00484E54
			internal void method_0()
			{
				Class48 @class = this.orbat_0.vmethod_22().method_2().method_1(new object[0]);
				this.orbat_0.method_20(@class, this.contact_0);
				@class.method_7().method_0("temp");
			}

			// Token: 0x04004969 RID: 18793
			public Contact contact_0;

			// Token: 0x0400496A RID: 18794
			public ORBAT orbat_0;
		}

		// Token: 0x02000EF0 RID: 3824
		[CompilerGenerated]
		internal sealed class Class2517
		{
			// Token: 0x060086D6 RID: 34518 RVA: 0x00051363 File Offset: 0x0004F563
			public Class2517(ORBAT.Class2517 class2517_0)
			{
				if (class2517_0 != null)
				{
					this.class126_0 = class2517_0.class126_0;
				}
			}

			// Token: 0x060086D7 RID: 34519 RVA: 0x0005137A File Offset: 0x0004F57A
			internal void method_0()
			{
				this.class126_0.method_7(this.class2518_0.orbat_0.method_16(this.class2518_0.activeUnit_0));
			}

			// Token: 0x0400496B RID: 18795
			public Class126 class126_0;

			// Token: 0x0400496C RID: 18796
			public ORBAT.Class2518 class2518_0;
		}

		// Token: 0x02000EF1 RID: 3825
		[CompilerGenerated]
		internal sealed class Class2518
		{
			// Token: 0x060086D8 RID: 34520 RVA: 0x000513A2 File Offset: 0x0004F5A2
			public Class2518(ORBAT.Class2518 class2518_0)
			{
				if (class2518_0 != null)
				{
					this.activeUnit_0 = class2518_0.activeUnit_0;
				}
			}

			// Token: 0x0400496D RID: 18797
			public ActiveUnit activeUnit_0;

			// Token: 0x0400496E RID: 18798
			public ORBAT orbat_0;
		}

		// Token: 0x02000EF2 RID: 3826
		[CompilerGenerated]
		internal sealed class Class2519
		{
			// Token: 0x060086D9 RID: 34521 RVA: 0x000513B9 File Offset: 0x0004F5B9
			public Class2519(ORBAT.Class2519 class2519_0)
			{
				if (class2519_0 != null)
				{
					this.activeUnit_0 = class2519_0.activeUnit_0;
				}
			}

			// Token: 0x060086DA RID: 34522 RVA: 0x000513D0 File Offset: 0x0004F5D0
			internal bool method_0(Class126 class126_0)
			{
				return class126_0.Tag == this.activeUnit_0.vmethod_65(false);
			}

			// Token: 0x0400496F RID: 18799
			public ActiveUnit activeUnit_0;

			// Token: 0x04004970 RID: 18800
			public ORBAT orbat_0;

			// Token: 0x04004971 RID: 18801
			public Func<Class126, bool> func_0;
		}

		// Token: 0x02000EF3 RID: 3827
		[CompilerGenerated]
		internal sealed class Class2520
		{
			// Token: 0x060086DB RID: 34523 RVA: 0x000513E6 File Offset: 0x0004F5E6
			public Class2520(ORBAT.Class2520 class2520_0)
			{
				if (class2520_0 != null)
				{
					this.class126_0 = class2520_0.class126_0;
					this.activeUnit_0 = class2520_0.activeUnit_0;
				}
			}

			// Token: 0x060086DC RID: 34524 RVA: 0x00486CA0 File Offset: 0x00484EA0
			internal void method_0()
			{
				string text = this.class2519_0.orbat_0.method_16(this.class2519_0.activeUnit_0);
				if (this.class2519_0.orbat_0.vmethod_12().method_19().Count == 0)
				{
					this.class126_0 = new Class126();
					this.class126_0.Tag = this.class2519_0.activeUnit_0;
					this.class126_0.method_40(new Font(this.class2519_0.orbat_0.vmethod_12().Font, FontStyle.Regular));
					this.class126_0.method_38(this.class2519_0.orbat_0.method_15(this.class2519_0.activeUnit_0));
					this.class126_0.method_7(text);
					this.class126_0.method_26(this.class2519_0.orbat_0.vmethod_12());
					this.class2519_0.orbat_0.vmethod_12().method_19().method_4(this.class126_0);
					this.class126_0.method_41();
				}
				else
				{
					try
					{
						foreach (Class126 @class in this.class2519_0.orbat_0.vmethod_12().method_19())
						{
							if (@class.method_6().CompareTo(text) > 0)
							{
								this.class126_0 = new Class126();
								this.class126_0.Tag = this.class2519_0.activeUnit_0;
								this.class126_0.method_40(new Font(this.class2519_0.orbat_0.vmethod_12().Font, FontStyle.Regular));
								this.class126_0.method_38(this.class2519_0.orbat_0.method_15(this.class2519_0.activeUnit_0));
								this.class126_0.method_7(text);
								this.class126_0.method_26(this.class2519_0.orbat_0.vmethod_12());
								this.class2519_0.orbat_0.vmethod_12().method_19().Insert(this.class2519_0.orbat_0.vmethod_12().method_19().IndexOf(@class), this.class126_0);
								this.class126_0.method_41();
								break;
							}
						}
					}
					finally
					{
						List<Class126>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				this.class2519_0.orbat_0.vmethod_12().method_38();
			}

			// Token: 0x060086DD RID: 34525 RVA: 0x00486F0C File Offset: 0x0048510C
			internal void method_1()
			{
				string text = this.class2519_0.orbat_0.method_16(this.class2519_0.activeUnit_0);
				Class126 @class = Enumerable.FirstOrDefault<Class126>(Enumerable.Where<Class126>(Class2558.smethod_10(this.class2519_0.orbat_0.vmethod_12()), (this.class2519_0.func_0 == null) ? (this.class2519_0.func_0 = new Func<Class126, bool>(this.class2519_0.method_0)) : this.class2519_0.func_0));
				if (@class != null)
				{
					if (@class.method_22().Count == 0)
					{
						this.class126_0 = new Class126();
						this.class126_0.Tag = this.class2519_0.activeUnit_0;
						this.class126_0.method_40(new Font(this.class2519_0.orbat_0.vmethod_12().Font, FontStyle.Regular));
						this.class126_0.method_38(this.class2519_0.orbat_0.method_15(this.class2519_0.activeUnit_0));
						this.class126_0.method_7(text);
						this.class126_0.method_26(this.class2519_0.orbat_0.vmethod_12());
						@class.method_22().method_4(this.class126_0);
					}
					else
					{
						bool flag = false;
						try
						{
							foreach (Class126 class2 in @class.method_22())
							{
								if (class2.method_6().CompareTo(text) > 0)
								{
									this.class126_0 = new Class126();
									this.class126_0.Tag = this.class2519_0.activeUnit_0;
									this.class126_0.method_40(new Font(this.class2519_0.orbat_0.vmethod_12().Font, FontStyle.Regular));
									this.class126_0.method_38(this.class2519_0.orbat_0.method_15(this.class2519_0.activeUnit_0));
									this.class126_0.method_7(text);
									this.class126_0.method_26(this.class2519_0.orbat_0.vmethod_12());
									@class.method_22().Insert(@class.method_22().IndexOf(class2), this.class126_0);
									this.class126_0.method_41();
									flag = true;
									break;
								}
							}
						}
						finally
						{
							List<Class126>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (!flag)
						{
							this.class126_0 = new Class126();
							this.class126_0.Tag = this.class2519_0.activeUnit_0;
							this.class126_0.method_40(new Font(this.class2519_0.orbat_0.vmethod_12().Font, FontStyle.Regular));
							this.class126_0.method_38(this.class2519_0.orbat_0.method_15(this.class2519_0.activeUnit_0));
							this.class126_0.method_7(text);
							this.class126_0.method_26(this.class2519_0.orbat_0.vmethod_12());
							@class.method_22().method_4(this.class126_0);
							this.class126_0.method_41();
						}
					}
					this.class2519_0.orbat_0.vmethod_12().method_38();
				}
			}

			// Token: 0x060086DE RID: 34526 RVA: 0x00487230 File Offset: 0x00485430
			internal void method_2()
			{
				string text = this.class2519_0.orbat_0.method_16(this.class2519_0.activeUnit_0);
				Class126 @class = Enumerable.FirstOrDefault<Class126>(Enumerable.Where<Class126>(Class2558.smethod_10(this.class2519_0.orbat_0.vmethod_12()), (this.func_0 == null) ? (this.func_0 = new Func<Class126, bool>(this.method_3)) : this.func_0));
				if (@class != null)
				{
					if (@class.method_22().Count == 0)
					{
						this.class126_0 = new Class126();
						this.class126_0.Tag = this.class2519_0.activeUnit_0;
						this.class126_0.method_40(new Font(this.class2519_0.orbat_0.vmethod_12().Font, FontStyle.Regular));
						this.class126_0.method_38(this.class2519_0.orbat_0.method_15(this.class2519_0.activeUnit_0));
						this.class126_0.method_7(text);
						this.class126_0.method_26(this.class2519_0.orbat_0.vmethod_12());
						@class.method_22().method_4(this.class126_0);
						this.class126_0.method_41();
					}
					else
					{
						bool flag = false;
						try
						{
							foreach (Class126 class2 in @class.method_22())
							{
								if (class2.method_6().CompareTo(text) > 0)
								{
									this.class126_0 = new Class126();
									this.class126_0.Tag = this.class2519_0.activeUnit_0;
									this.class126_0.method_40(new Font(this.class2519_0.orbat_0.vmethod_12().Font, FontStyle.Regular));
									this.class126_0.method_38(this.class2519_0.orbat_0.method_15(this.class2519_0.activeUnit_0));
									this.class126_0.method_7(text);
									this.class126_0.method_26(this.class2519_0.orbat_0.vmethod_12());
									@class.method_22().Insert(@class.method_22().IndexOf(class2), this.class126_0);
									this.class126_0.method_41();
									flag = true;
									break;
								}
							}
						}
						finally
						{
							List<Class126>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (!flag)
						{
							this.class126_0 = new Class126();
							this.class126_0.Tag = this.class2519_0.activeUnit_0;
							this.class126_0.method_40(new Font(this.class2519_0.orbat_0.vmethod_12().Font, FontStyle.Regular));
							this.class126_0.method_38(this.class2519_0.orbat_0.method_15(this.class2519_0.activeUnit_0));
							this.class126_0.method_7(text);
							this.class126_0.method_26(this.class2519_0.orbat_0.vmethod_12());
							@class.method_22().method_4(this.class126_0);
							this.class126_0.method_41();
						}
					}
					this.class2519_0.orbat_0.vmethod_12().method_38();
				}
			}

			// Token: 0x060086DF RID: 34527 RVA: 0x00051409 File Offset: 0x0004F609
			internal bool method_3(Class126 class126_1)
			{
				return class126_1.Tag == this.activeUnit_0;
			}

			// Token: 0x060086E0 RID: 34528 RVA: 0x00051419 File Offset: 0x0004F619
			internal void method_4()
			{
				this.class126_0.method_21(true);
				this.class2519_0.orbat_0.vmethod_12().method_38();
			}

			// Token: 0x04004972 RID: 18802
			public Class126 class126_0;

			// Token: 0x04004973 RID: 18803
			public ActiveUnit activeUnit_0;

			// Token: 0x04004974 RID: 18804
			public ORBAT.Class2519 class2519_0;

			// Token: 0x04004975 RID: 18805
			public Func<Class126, bool> func_0;
		}

		// Token: 0x02000EF4 RID: 3828
		[CompilerGenerated]
		internal sealed class Class2521
		{
			// Token: 0x060086E1 RID: 34529 RVA: 0x0005143C File Offset: 0x0004F63C
			public Class2521(ORBAT.Class2521 class2521_0)
			{
				if (class2521_0 != null)
				{
					this.class126_0 = class2521_0.class126_0;
				}
			}

			// Token: 0x060086E2 RID: 34530 RVA: 0x0048754C File Offset: 0x0048574C
			internal void method_0()
			{
				if (Information.IsNothing(this.class126_0.method_27()))
				{
					this.orbat_0.vmethod_12().method_19().method_6(this.class126_0);
				}
				else
				{
					this.class126_0.method_27().method_22().method_6(this.class126_0);
				}
				this.orbat_0.vmethod_12().method_38();
			}

			// Token: 0x04004976 RID: 18806
			public Class126 class126_0;

			// Token: 0x04004977 RID: 18807
			public ORBAT orbat_0;
		}

		// Token: 0x02000EF5 RID: 3829
		[CompilerGenerated]
		internal sealed class Class2522
		{
			// Token: 0x060086E3 RID: 34531 RVA: 0x00051453 File Offset: 0x0004F653
			public Class2522(ORBAT.Class2522 class2522_0)
			{
				if (class2522_0 != null)
				{
					this.class126_0 = class2522_0.class126_0;
				}
			}

			// Token: 0x060086E4 RID: 34532 RVA: 0x004875B4 File Offset: 0x004857B4
			internal void method_0()
			{
				if (Information.IsNothing(this.class126_0.method_27()))
				{
					this.orbat_0.vmethod_14().method_19().method_6(this.class126_0);
				}
				else
				{
					this.class126_0.method_27().method_22().method_6(this.class126_0);
				}
				this.orbat_0.vmethod_12().method_38();
			}

			// Token: 0x04004978 RID: 18808
			public Class126 class126_0;

			// Token: 0x04004979 RID: 18809
			public ORBAT orbat_0;
		}
	}
}
