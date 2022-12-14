using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns10;
using ns2;
using ns3;
using ns4;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000F20 RID: 3872
	[DesignerGenerated]
	public sealed partial class WeaponsWindow : DarkSecondaryFormBase
	{
		// Token: 0x06008A9C RID: 35484 RVA: 0x004A9828 File Offset: 0x004A7A28
		public WeaponsWindow()
		{
			base.FormClosing += this.WeaponsWindow_FormClosing;
			base.VisibleChanged += this.WeaponsWindow_VisibleChanged;
			base.Load += this.WeaponsWindow_Load;
			base.KeyDown += this.WeaponsWindow_KeyDown;
			base.FormClosed += this.WeaponsWindow_FormClosed;
			this.bool_4 = false;
			this.InitializeComponent_1();
		}

		// Token: 0x06008A9E RID: 35486 RVA: 0x004A98E4 File Offset: 0x004A7AE4
		private void InitializeComponent_1()
		{
			this.icontainer_1 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(WeaponsWindow));
			this.vmethod_1(new Class44());
			this.vmethod_3(new DataGridViewTextBoxColumn());
			this.vmethod_5(new DataGridViewTextBoxColumn());
			this.vmethod_7(new Class50());
			this.vmethod_35(new Class44());
			this.vmethod_37(new DataGridViewTextBoxColumn());
			this.vmethod_39(new DataGridViewTextBoxColumn());
			this.vmethod_41(new DataGridViewTextBoxColumn());
			this.vmethod_43(new DataGridViewCheckBoxColumn());
			this.vmethod_45(new DataGridViewCheckBoxColumn());
			this.vmethod_9(new ImageList(this.icontainer_1));
			this.vmethod_11(new Timer(this.icontainer_1));
			this.vmethod_13(new Class125());
			this.vmethod_15(new ToolStripButton());
			this.vmethod_17(new ToolStripButton());
			this.vmethod_31(new ToolStripSeparator());
			this.vmethod_23(new ToolStripButton());
			this.vmethod_25(new ToolStripButton());
			this.vmethod_33(new ToolStripSeparator());
			this.vmethod_19(new ToolStripLabel());
			this.vmethod_27(new ToolStripLabel());
			this.vmethod_21(new ToolStripTextBox());
			this.vmethod_29(new ToolStripButton());
			((ISupportInitialize)this.vmethod_6()).BeginInit();
			this.vmethod_12().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_0().method_0(null);
			this.vmethod_0().HeaderText = "Mount";
			this.vmethod_0().Name = "Mount";
			this.vmethod_0().ReadOnly = true;
			this.vmethod_0().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_2().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_2().HeaderText = "Type";
			this.vmethod_2().Name = "WeaponType";
			this.vmethod_2().ReadOnly = true;
			this.vmethod_2().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_4().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_4().HeaderText = "Status";
			this.vmethod_4().Name = "Status";
			this.vmethod_4().ReadOnly = true;
			this.vmethod_4().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_6().AllowUserToAddRows = false;
			this.vmethod_6().AllowUserToDeleteRows = false;
			this.vmethod_6().AllowUserToOrderColumns = true;
			this.vmethod_6().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_6().BackgroundColor = Color.FromArgb(43, 43, 43);
			this.vmethod_6().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_6().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
			this.vmethod_6().AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			this.vmethod_6().CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.vmethod_6().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_6().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_6().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_34(),
				this.vmethod_36(),
				this.vmethod_38(),
				this.vmethod_40(),
				this.vmethod_42(),
				this.vmethod_44()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_6().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_6().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_6().EnableHeadersVisualStyles = false;
			this.vmethod_6().method_9(null);
			this.vmethod_6().Location = new Point(0, 0);
			this.vmethod_6().MultiSelect = false;
			this.vmethod_6().Name = "TGV_Weapons";
			this.vmethod_6().RowHeadersVisible = false;
			this.vmethod_6().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_6().method_7(false);
			this.vmethod_6().Size = new Size(732, 333);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_34().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_34().method_0(null);
			this.vmethod_34().HeaderText = "Mount (click weapon for DB info)";
			this.vmethod_34().MinimumWidth = 250;
			this.vmethod_34().Name = "Column1";
			this.vmethod_34().ReadOnly = true;
			this.vmethod_34().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_36().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_36().FillWeight = 10f;
			this.vmethod_36().HeaderText = "";
			this.vmethod_36().MinimumWidth = 75;
			this.vmethod_36().Name = "Type";
			this.vmethod_36().ReadOnly = true;
			this.vmethod_36().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_38().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_38().HeaderText = "Time to fire";
			this.vmethod_38().Name = "TimeToFire";
			this.vmethod_38().ReadOnly = true;
			this.vmethod_38().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_38().Width = 63;
			this.vmethod_40().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_40().FillWeight = 10f;
			this.vmethod_40().HeaderText = "Status";
			this.vmethod_40().MinimumWidth = 75;
			this.vmethod_40().Name = "Column3";
			this.vmethod_40().ReadOnly = true;
			this.vmethod_40().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_42().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_42().HeaderText = "Reload Priority";
			this.vmethod_42().Name = "ReloadPriority";
			this.vmethod_42().Width = 79;
			this.vmethod_44().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_44().HeaderText = "Show Arcs";
			this.vmethod_44().Name = "ShowArcs";
			this.vmethod_44().Width = 62;
			this.vmethod_8().ColorDepth = ColorDepth.Depth8Bit;
			this.vmethod_8().ImageSize = new Size(16, 16);
			this.vmethod_8().TransparentColor = Color.Transparent;
			this.vmethod_10().Interval = 500;
			this.vmethod_12().AutoSize = false;
			this.vmethod_12().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_12().Dock = DockStyle.Bottom;
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_12().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_14(),
				this.vmethod_16(),
				this.vmethod_30(),
				this.vmethod_22(),
				this.vmethod_24(),
				this.vmethod_32(),
				this.vmethod_18(),
				this.vmethod_26(),
				this.vmethod_20(),
				this.vmethod_28()
			});
			this.vmethod_12().Location = new Point(0, 336);
			this.vmethod_12().Name = "TS_Edit";
			this.vmethod_12().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_12().Size = new Size(732, 25);
			this.vmethod_12().TabIndex = 7;
			this.vmethod_12().Text = "ToolStrip1";
			this.vmethod_14().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Image = (Image)componentResourceManager.GetObject("TSB_AddRec.Image");
			this.vmethod_14().ImageTransparentColor = Color.Magenta;
			this.vmethod_14().Name = "TSB_AddRec";
			this.vmethod_14().Size = new Size(136, 22);
			this.vmethod_14().Text = "Add Weapon Record";
			this.vmethod_16().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_16().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_16().Image = (Image)componentResourceManager.GetObject("TSB_RemoveRec.Image");
			this.vmethod_16().ImageTransparentColor = Color.Magenta;
			this.vmethod_16().Name = "TSB_RemoveRec";
			this.vmethod_16().Size = new Size(170, 22);
			this.vmethod_16().Text = "Remove Weapon Record(s)";
			this.vmethod_30().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_30().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_30().Margin = new Padding(0, 0, 2, 0);
			this.vmethod_30().Name = "ToolStripSeparator1";
			this.vmethod_30().Size = new Size(6, 25);
			this.vmethod_22().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_22().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_22().Image = (Image)componentResourceManager.GetObject("TSB_AddMount.Image");
			this.vmethod_22().ImageTransparentColor = Color.Magenta;
			this.vmethod_22().Name = "TSB_AddMount";
			this.vmethod_22().Size = new Size(88, 22);
			this.vmethod_22().Text = "Add Mount";
			this.vmethod_24().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_24().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_24().Image = (Image)componentResourceManager.GetObject("TSB_RemoveMount.Image");
			this.vmethod_24().ImageTransparentColor = Color.Magenta;
			this.vmethod_24().Name = "TSB_RemoveMount";
			this.vmethod_24().Size = new Size(109, 22);
			this.vmethod_24().Text = "Remove Mount";
			this.vmethod_24().ToolTipText = "Remove Mount";
			this.vmethod_32().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_32().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_32().Margin = new Padding(0, 0, 2, 0);
			this.vmethod_32().Name = "ToolStripSeparator2";
			this.vmethod_32().Size = new Size(6, 25);
			this.vmethod_18().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Name = "TSL_WeaponCount1";
			this.vmethod_18().Size = new Size(59, 22);
			this.vmethod_18().Text = "Weapons:";
			this.vmethod_26().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().Name = "TSL_WeaponCount2";
			this.vmethod_26().Size = new Size(37, 22);
			this.vmethod_26().Text = "12345";
			this.vmethod_20().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_20().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_20().Name = "TSTB_RecCount";
			this.vmethod_20().Size = new Size(40, 25);
			this.vmethod_20().Visible = false;
			this.vmethod_28().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_28().DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.vmethod_28().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_28().Image = (Image)componentResourceManager.GetObject("TSB_ChangeWeaponCount.Image");
			this.vmethod_28().ImageTransparentColor = Color.Magenta;
			this.vmethod_28().Name = "TSB_ChangeWeaponCount";
			this.vmethod_28().Size = new Size(52, 22);
			this.vmethod_28().Text = "Change";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(732, 361);
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_6());
			this.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "WeaponsWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Weapons";
			((ISupportInitialize)this.vmethod_6()).EndInit();
			this.vmethod_12().ResumeLayout(false);
			this.vmethod_12().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x06008A9F RID: 35487 RVA: 0x00052EA3 File Offset: 0x000510A3
		[CompilerGenerated]
		internal Class44 vmethod_0()
		{
			return this.class44_0;
		}

		// Token: 0x06008AA0 RID: 35488 RVA: 0x00052EAB File Offset: 0x000510AB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class44 class44_2)
		{
			this.class44_0 = class44_2;
		}

		// Token: 0x06008AA1 RID: 35489 RVA: 0x00052EB4 File Offset: 0x000510B4
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_2()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06008AA2 RID: 35490 RVA: 0x00052EBC File Offset: 0x000510BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_5;
		}

		// Token: 0x06008AA3 RID: 35491 RVA: 0x00052EC5 File Offset: 0x000510C5
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_4()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06008AA4 RID: 35492 RVA: 0x00052ECD File Offset: 0x000510CD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_5;
		}

		// Token: 0x06008AA5 RID: 35493 RVA: 0x00052ED6 File Offset: 0x000510D6
		[CompilerGenerated]
		private Class50 vmethod_6()
		{
			return this.class50_0;
		}

		// Token: 0x06008AA6 RID: 35494 RVA: 0x004AA6C4 File Offset: 0x004A88C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_7(Class50 class50_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_23);
			Delegate1 delegate1_ = new Delegate1(this.method_24);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_26);
			EventHandler value3 = new EventHandler(this.method_29);
			Class50 @class = this.class50_0;
			if (@class != null)
			{
				@class.CellClick -= value;
				@class.method_12(delegate1_);
				@class.CellContentClick -= value2;
				@class.SelectionChanged -= value3;
			}
			this.class50_0 = class50_1;
			@class = this.class50_0;
			if (@class != null)
			{
				@class.CellClick += value;
				@class.method_11(delegate1_);
				@class.CellContentClick += value2;
				@class.SelectionChanged += value3;
			}
		}

		// Token: 0x06008AA7 RID: 35495 RVA: 0x00052EDE File Offset: 0x000510DE
		[CompilerGenerated]
		internal ImageList vmethod_8()
		{
			return this.imageList_0;
		}

		// Token: 0x06008AA8 RID: 35496 RVA: 0x00052EE6 File Offset: 0x000510E6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ImageList imageList_1)
		{
			this.imageList_0 = imageList_1;
		}

		// Token: 0x06008AA9 RID: 35497 RVA: 0x00052EEF File Offset: 0x000510EF
		[CompilerGenerated]
		internal Timer vmethod_10()
		{
			return this.timer_0;
		}

		// Token: 0x06008AAA RID: 35498 RVA: 0x004AA764 File Offset: 0x004A8964
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Timer timer_1)
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

		// Token: 0x06008AAB RID: 35499 RVA: 0x00052EF7 File Offset: 0x000510F7
		[CompilerGenerated]
		internal Class125 vmethod_12()
		{
			return this.class125_0;
		}

		// Token: 0x06008AAC RID: 35500 RVA: 0x00052EFF File Offset: 0x000510FF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x06008AAD RID: 35501 RVA: 0x00052F08 File Offset: 0x00051108
		[CompilerGenerated]
		internal ToolStripButton vmethod_14()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06008AAE RID: 35502 RVA: 0x004AA7A8 File Offset: 0x004A89A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_21);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_5;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008AAF RID: 35503 RVA: 0x00052F10 File Offset: 0x00051110
		[CompilerGenerated]
		internal ToolStripButton vmethod_16()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x06008AB0 RID: 35504 RVA: 0x004AA7EC File Offset: 0x004A89EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_22);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_5;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008AB1 RID: 35505 RVA: 0x00052F18 File Offset: 0x00051118
		[CompilerGenerated]
		internal ToolStripLabel vmethod_18()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x06008AB2 RID: 35506 RVA: 0x00052F20 File Offset: 0x00051120
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(ToolStripLabel toolStripLabel_2)
		{
			this.toolStripLabel_0 = toolStripLabel_2;
		}

		// Token: 0x06008AB3 RID: 35507 RVA: 0x00052F29 File Offset: 0x00051129
		[CompilerGenerated]
		internal ToolStripTextBox vmethod_20()
		{
			return this.toolStripTextBox_0;
		}

		// Token: 0x06008AB4 RID: 35508 RVA: 0x004AA830 File Offset: 0x004A8A30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(ToolStripTextBox toolStripTextBox_1)
		{
			EventHandler value = new EventHandler(this.method_30);
			EventHandler value2 = new EventHandler(this.method_31);
			ToolStripTextBox toolStripTextBox = this.toolStripTextBox_0;
			if (toolStripTextBox != null)
			{
				toolStripTextBox.Enter -= value;
				toolStripTextBox.Leave -= value2;
			}
			this.toolStripTextBox_0 = toolStripTextBox_1;
			toolStripTextBox = this.toolStripTextBox_0;
			if (toolStripTextBox != null)
			{
				toolStripTextBox.Enter += value;
				toolStripTextBox.Leave += value2;
			}
		}

		// Token: 0x06008AB5 RID: 35509 RVA: 0x00052F31 File Offset: 0x00051131
		[CompilerGenerated]
		internal ToolStripButton vmethod_22()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x06008AB6 RID: 35510 RVA: 0x004AA890 File Offset: 0x004A8A90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_25);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_5;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008AB7 RID: 35511 RVA: 0x00052F39 File Offset: 0x00051139
		[CompilerGenerated]
		internal ToolStripButton vmethod_24()
		{
			return this.toolStripButton_3;
		}

		// Token: 0x06008AB8 RID: 35512 RVA: 0x004AA8D4 File Offset: 0x004A8AD4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_27);
			ToolStripButton toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_3 = toolStripButton_5;
			toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008AB9 RID: 35513 RVA: 0x00052F41 File Offset: 0x00051141
		[CompilerGenerated]
		internal ToolStripLabel vmethod_26()
		{
			return this.toolStripLabel_1;
		}

		// Token: 0x06008ABA RID: 35514 RVA: 0x00052F49 File Offset: 0x00051149
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(ToolStripLabel toolStripLabel_2)
		{
			this.toolStripLabel_1 = toolStripLabel_2;
		}

		// Token: 0x06008ABB RID: 35515 RVA: 0x00052F52 File Offset: 0x00051152
		[CompilerGenerated]
		internal ToolStripButton vmethod_28()
		{
			return this.toolStripButton_4;
		}

		// Token: 0x06008ABC RID: 35516 RVA: 0x004AA918 File Offset: 0x004A8B18
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_28);
			ToolStripButton toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_4 = toolStripButton_5;
			toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008ABD RID: 35517 RVA: 0x00052F5A File Offset: 0x0005115A
		[CompilerGenerated]
		internal ToolStripSeparator vmethod_30()
		{
			return this.toolStripSeparator_0;
		}

		// Token: 0x06008ABE RID: 35518 RVA: 0x00052F62 File Offset: 0x00051162
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(ToolStripSeparator toolStripSeparator_2)
		{
			this.toolStripSeparator_0 = toolStripSeparator_2;
		}

		// Token: 0x06008ABF RID: 35519 RVA: 0x00052F6B File Offset: 0x0005116B
		[CompilerGenerated]
		internal ToolStripSeparator vmethod_32()
		{
			return this.toolStripSeparator_1;
		}

		// Token: 0x06008AC0 RID: 35520 RVA: 0x00052F73 File Offset: 0x00051173
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(ToolStripSeparator toolStripSeparator_2)
		{
			this.toolStripSeparator_1 = toolStripSeparator_2;
		}

		// Token: 0x06008AC1 RID: 35521 RVA: 0x00052F7C File Offset: 0x0005117C
		[CompilerGenerated]
		internal Class44 vmethod_34()
		{
			return this.class44_1;
		}

		// Token: 0x06008AC2 RID: 35522 RVA: 0x00052F84 File Offset: 0x00051184
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Class44 class44_2)
		{
			this.class44_1 = class44_2;
		}

		// Token: 0x06008AC3 RID: 35523 RVA: 0x00052F8D File Offset: 0x0005118D
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_36()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06008AC4 RID: 35524 RVA: 0x00052F95 File Offset: 0x00051195
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_5;
		}

		// Token: 0x06008AC5 RID: 35525 RVA: 0x00052F9E File Offset: 0x0005119E
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_38()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06008AC6 RID: 35526 RVA: 0x00052FA6 File Offset: 0x000511A6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_5;
		}

		// Token: 0x06008AC7 RID: 35527 RVA: 0x00052FAF File Offset: 0x000511AF
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_40()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06008AC8 RID: 35528 RVA: 0x00052FB7 File Offset: 0x000511B7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_5;
		}

		// Token: 0x06008AC9 RID: 35529 RVA: 0x00052FC0 File Offset: 0x000511C0
		[CompilerGenerated]
		internal DataGridViewCheckBoxColumn vmethod_42()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x06008ACA RID: 35530 RVA: 0x00052FC8 File Offset: 0x000511C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x06008ACB RID: 35531 RVA: 0x00052FD1 File Offset: 0x000511D1
		[CompilerGenerated]
		internal DataGridViewCheckBoxColumn vmethod_44()
		{
			return this.dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x06008ACC RID: 35532 RVA: 0x00052FD9 File Offset: 0x000511D9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_1 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x06008ACD RID: 35533 RVA: 0x004AA95C File Offset: 0x004A8B5C
		public void method_3(ActiveUnit activeUnit_1)
		{
			bool flag;
			if (activeUnit_1 != null)
			{
				flag = (activeUnit_1 != this.activeUnit_0);
			}
			this.activeUnit_0 = activeUnit_1;
			if (flag && base.Visible && this.bool_6)
			{
				this.method_19();
			}
		}

		// Token: 0x06008ACE RID: 35534 RVA: 0x00052FE2 File Offset: 0x000511E2
		public void method_4(WeaponRec weaponRec_1)
		{
			if (!Information.IsNothing(this.mount_0))
			{
				this.mount_0.vmethod_10().method_4(weaponRec_1);
				return;
			}
			if (!Information.IsNothing(this.loadout_0))
			{
				this.loadout_0.method_16(weaponRec_1);
			}
		}

		// Token: 0x06008ACF RID: 35535 RVA: 0x0005301C File Offset: 0x0005121C
		public void method_5(WeaponRec weaponRec_1)
		{
			if (!Information.IsNothing(this.mount_0))
			{
				this.mount_0.vmethod_10().method_6(weaponRec_1);
				return;
			}
			if (!Information.IsNothing(this.loadout_0))
			{
				this.loadout_0.method_17(weaponRec_1);
			}
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x00053056 File Offset: 0x00051256
		private void WeaponsWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Client.mount_0 = null;
			this.activeUnit_0 = null;
			e.Cancel = true;
			Class2413.smethod_2().method_41().BringToFront();
			base.Hide();
		}

		// Token: 0x06008AD1 RID: 35537 RVA: 0x004AA99C File Offset: 0x004A8B9C
		private void WeaponsWindow_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				if (Information.IsNothing(this.activeUnit_0) && Client.smethod_54().bool_0)
				{
					this.activeUnit_0 = (ActiveUnit)Client.smethod_54();
				}
				if (Information.IsNothing(this.activeUnit_0) || !this.activeUnit_0.bool_0)
				{
					base.Hide();
					return;
				}
				this.method_19();
				if ((this.vmethod_6().method_2().Count > 0 && !Information.IsNothing(this.activeUnit_0)) & this.activeUnit_0.vmethod_51().Count > 0)
				{
					this.mount_0 = (Mount)this.vmethod_6().method_2()[0].Tag;
				}
			}
		}

		// Token: 0x06008AD2 RID: 35538 RVA: 0x004AAA64 File Offset: 0x004A8C64
		private void WeaponsWindow_Load(object sender, EventArgs e)
		{
			this.bool_3 = false;
			PlatformComponent.smethod_0(new PlatformComponent.Delegate46(this.method_10));
			WeaponRec.smethod_0(new WeaponRec.Delegate54(this.method_11));
			Mount.smethod_2(new Mount.Delegate44(this.method_6));
			Mount.smethod_4(new Mount.Delegate45(this.method_7));
			Loadout.smethod_0(new Loadout.Delegate34(this.method_8));
			Loadout.smethod_2(new Loadout.Delegate35(this.method_9));
			ActiveUnit.smethod_4(new ActiveUnit.Delegate14(this.method_13));
			ActiveUnit.smethod_6(new ActiveUnit.Delegate15(this.method_12));
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.bool_6 = true;
		}

		// Token: 0x06008AD3 RID: 35539 RVA: 0x004AAB1C File Offset: 0x004A8D1C
		private void method_6(string string_0, string string_1)
		{
			WeaponsWindow.Class2538 @class = new WeaponsWindow.Class2538(@class);
			@class.weaponsWindow_0 = this;
			try
			{
				IEnumerator<Class48> enumerator = this.vmethod_6().method_2().GetEnumerator();
				while (enumerator.MoveNext())
				{
					WeaponsWindow.Class2537 class2 = new WeaponsWindow.Class2537(class2);
					class2.class2538_0 = @class;
					class2.class48_0 = enumerator.Current;
					if (class2.class48_0.Tag != null && class2.class48_0.Tag.GetType() == typeof(Mount))
					{
						class2.class2538_0.mount_0 = (Mount)class2.class48_0.Tag;
						if (Operators.CompareString(class2.class2538_0.mount_0.string_0, string_0, false) == 0)
						{
							try
							{
								List<WeaponRec>.Enumerator enumerator2 = class2.class2538_0.mount_0.vmethod_10().GetEnumerator();
								while (enumerator2.MoveNext())
								{
									WeaponsWindow.Class2539 class3 = new WeaponsWindow.Class2539(class3);
									class3.class2537_0 = class2;
									class3.weaponRec_0 = enumerator2.Current;
									if (Operators.CompareString(class3.weaponRec_0.string_0, string_1, false) == 0)
									{
										base.Invoke(new VB$AnonymousDelegate_0(class3.method_0));
										break;
									}
								}
							}
							finally
							{
								List<WeaponRec>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							break;
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

		// Token: 0x06008AD4 RID: 35540 RVA: 0x004AAC88 File Offset: 0x004A8E88
		private void method_7(string string_0, string string_1)
		{
			try
			{
				IEnumerator<Class48> enumerator = this.vmethod_6().method_2().GetEnumerator();
				while (enumerator.MoveNext())
				{
					WeaponsWindow.Class2540 @class = new WeaponsWindow.Class2540(@class);
					@class.class48_0 = enumerator.Current;
					if (@class.class48_0.Tag != null && @class.class48_0.Tag.GetType() == typeof(Mount) && Operators.CompareString(((Mount)@class.class48_0.Tag).string_0, string_0, false) == 0)
					{
						try
						{
							IEnumerator<Class48> enumerator2 = @class.class48_0.method_7().GetEnumerator();
							while (enumerator2.MoveNext())
							{
								WeaponsWindow.Class2541 class2 = new WeaponsWindow.Class2541(class2);
								class2.class2540_0 = @class;
								class2.class48_0 = enumerator2.Current;
								if (class2.class48_0.Tag != null && class2.class48_0.Tag.GetType() == typeof(WeaponRec) && Operators.CompareString(((WeaponRec)class2.class48_0.Tag).string_0, string_1, false) == 0)
								{
									base.Invoke(new VB$AnonymousDelegate_0(class2.method_0));
									break;
								}
							}
						}
						finally
						{
							IEnumerator<Class48> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
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

		// Token: 0x06008AD5 RID: 35541 RVA: 0x004AADEC File Offset: 0x004A8FEC
		private void method_8(string string_0, string string_1)
		{
			checked
			{
				try
				{
					IEnumerator<Class48> enumerator = this.vmethod_6().method_2().GetEnumerator();
					while (enumerator.MoveNext())
					{
						WeaponsWindow.Class2542 @class = new WeaponsWindow.Class2542(@class);
						@class.weaponsWindow_0 = this;
						@class.class48_0 = enumerator.Current;
						if (@class.class48_0.Tag != null && @class.class48_0.Tag.GetType() == typeof(Loadout))
						{
							Loadout loadout = (Loadout)@class.class48_0.Tag;
							if (Operators.CompareString(loadout.string_0, string_0, false) == 0)
							{
								WeaponRec[] array = loadout.weaponRec_0;
								for (int i = 0; i < array.Length; i++)
								{
									WeaponsWindow.Class2543 class2 = new WeaponsWindow.Class2543(class2);
									class2.class2542_0 = @class;
									class2.weaponRec_0 = array[i];
									if (Operators.CompareString(class2.weaponRec_0.string_0, string_1, false) == 0)
									{
										base.Invoke(new VB$AnonymousDelegate_0(class2.method_0));
										break;
									}
								}
								break;
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
		}

		// Token: 0x06008AD6 RID: 35542 RVA: 0x004AAEF8 File Offset: 0x004A90F8
		private void method_9(string string_0, string string_1)
		{
			try
			{
				IEnumerator<Class48> enumerator = this.vmethod_6().method_2().GetEnumerator();
				while (enumerator.MoveNext())
				{
					WeaponsWindow.Class2544 @class = new WeaponsWindow.Class2544(@class);
					@class.class48_0 = enumerator.Current;
					if (@class.class48_0.Tag != null && @class.class48_0.Tag.GetType() == typeof(Loadout) && Operators.CompareString(((Loadout)@class.class48_0.Tag).string_0, string_0, false) == 0)
					{
						try
						{
							IEnumerator<Class48> enumerator2 = @class.class48_0.method_7().GetEnumerator();
							while (enumerator2.MoveNext())
							{
								WeaponsWindow.Class2545 class2 = new WeaponsWindow.Class2545(class2);
								class2.class2544_0 = @class;
								class2.class48_0 = enumerator2.Current;
								if (class2.class48_0.Tag != null && class2.class48_0.Tag.GetType() == typeof(WeaponRec) && Operators.CompareString(((WeaponRec)class2.class48_0.Tag).string_0, string_1, false) == 0)
								{
									base.Invoke(new VB$AnonymousDelegate_0(class2.method_0));
									break;
								}
							}
						}
						finally
						{
							IEnumerator<Class48> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
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

		// Token: 0x06008AD7 RID: 35543 RVA: 0x004AB05C File Offset: 0x004A925C
		private void method_10(PlatformComponent platformComponent_0)
		{
			try
			{
				IEnumerator<Class48> enumerator = this.vmethod_6().method_2().GetEnumerator();
				while (enumerator.MoveNext())
				{
					WeaponsWindow.Class2546 @class = new WeaponsWindow.Class2546(@class);
					@class.weaponsWindow_0 = this;
					@class.class48_0 = enumerator.Current;
					if (@class.class48_0.Tag != null && @class.class48_0.Tag.GetType() == typeof(Mount))
					{
						WeaponsWindow.Class2547 class2 = new WeaponsWindow.Class2547(class2);
						class2.class2546_0 = @class;
						class2.mount_0 = (Mount)class2.class2546_0.class48_0.Tag;
						if (Operators.CompareString(class2.mount_0.string_0, platformComponent_0.string_0, false) == 0)
						{
							base.Invoke(new VB$AnonymousDelegate_0(class2.method_0));
							break;
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

		// Token: 0x06008AD8 RID: 35544 RVA: 0x004AB140 File Offset: 0x004A9340
		private void method_11(string string_0)
		{
			WeaponsWindow.Class2550 @class = new WeaponsWindow.Class2550(@class);
			@class.weaponsWindow_0 = this;
			try
			{
				IEnumerator<Class48> enumerator = this.vmethod_6().method_2().GetEnumerator();
				while (enumerator.MoveNext())
				{
					WeaponsWindow.Class2548 class2 = new WeaponsWindow.Class2548(class2);
					class2.class2550_0 = @class;
					class2.class48_0 = enumerator.Current;
					if (class2.class48_0.Tag != null && (class2.class48_0.Tag.GetType() == typeof(Mount) || class2.class48_0.Tag.GetType() == typeof(Loadout)))
					{
						try
						{
							IEnumerator<Class48> enumerator2 = class2.class48_0.method_7().GetEnumerator();
							while (enumerator2.MoveNext())
							{
								WeaponsWindow.Class2549 class3 = new WeaponsWindow.Class2549(class3);
								class3.class2548_0 = class2;
								class3.class48_0 = enumerator2.Current;
								if (class3.class48_0.Tag != null && class3.class48_0.Tag.GetType() == typeof(WeaponRec))
								{
									class3.class2548_0.class2550_0.weaponRec_0 = (WeaponRec)class3.class48_0.Tag;
									if (Operators.CompareString(class3.class2548_0.class2550_0.weaponRec_0.string_0, string_0, false) == 0)
									{
										base.Invoke(new VB$AnonymousDelegate_0(class3.method_0));
										return;
									}
								}
							}
						}
						finally
						{
							IEnumerator<Class48> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
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

		// Token: 0x06008AD9 RID: 35545 RVA: 0x004AB2F0 File Offset: 0x004A94F0
		private void method_12(string string_0, string string_1)
		{
			if (base.Visible && Operators.CompareString(this.activeUnit_0.string_0, string_0, false) == 0)
			{
				try
				{
					IEnumerator<Class48> enumerator = this.vmethod_6().method_2().GetEnumerator();
					while (enumerator.MoveNext())
					{
						WeaponsWindow.Class2551 @class = new WeaponsWindow.Class2551(@class);
						@class.weaponsWindow_0 = this;
						@class.class48_0 = enumerator.Current;
						if (@class.class48_0.Tag != null && @class.class48_0.Tag.GetType() == typeof(Mount) && Operators.CompareString(((Mount)@class.class48_0.Tag).string_0, string_1, false) == 0)
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

		// Token: 0x06008ADA RID: 35546 RVA: 0x004AB3CC File Offset: 0x004A95CC
		private void method_13(string string_0, string string_1)
		{
			if (base.Visible && Operators.CompareString(this.activeUnit_0.string_0, string_0, false) == 0)
			{
				try
				{
					List<Mount>.Enumerator enumerator = this.activeUnit_0.vmethod_51().GetEnumerator();
					while (enumerator.MoveNext())
					{
						WeaponsWindow.Class2552 @class = new WeaponsWindow.Class2552(@class);
						@class.weaponsWindow_0 = this;
						@class.mount_0 = enumerator.Current;
						if (Operators.CompareString(@class.mount_0.string_0, string_1, false) == 0)
						{
							base.Invoke(new VB$AnonymousDelegate_0(@class.method_0));
							break;
						}
					}
				}
				finally
				{
					List<Mount>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06008ADB RID: 35547 RVA: 0x004AB478 File Offset: 0x004A9678
		private void method_14(Class48 class48_0, Mount mount_1)
		{
			int num = 0;
			try
			{
				foreach (WeaponRec weaponRec in mount_1.vmethod_10())
				{
					num += weaponRec.int_2;
				}
			}
			finally
			{
				List<WeaponRec>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			string text = Conversions.ToString(0);
			if (mount_1.enum113_0 == Mount.Enum113.const_0)
			{
				text = Misc.smethod_11((long)Math.Round((double)mount_1.method_28()), Aircraft_AirOps.Enum44.const_0, false, false);
			}
			else
			{
				float num2 = 0f;
				if (mount_1.method_28() > 0f)
				{
					num2 = mount_1.method_28();
				}
				if (mount_1.method_32().method_24() > 0f && mount_1.method_32().method_24() > num2)
				{
					num2 = mount_1.method_32().method_24();
				}
				try
				{
					foreach (WeaponRec weaponRec2 in mount_1.vmethod_10())
					{
						if (weaponRec2.float_0 > num2)
						{
							num2 = weaponRec2.float_0;
						}
					}
				}
				finally
				{
					List<WeaponRec>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				try
				{
					foreach (WeaponRec weaponRec3 in mount_1.method_32().vmethod_10())
					{
						if (weaponRec3.float_0 > num2)
						{
							num2 = weaponRec3.float_0;
						}
					}
				}
				finally
				{
					List<WeaponRec>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				if (num2 == 0f)
				{
					text = Misc.smethod_11((long)Math.Round((double)mount_1.method_28()), Aircraft_AirOps.Enum44.const_0, false, false);
				}
				else if (mount_1.enum113_0 == Mount.Enum113.const_1)
				{
					text = "Reloading: " + Misc.smethod_11((long)Math.Round((double)num2), Aircraft_AirOps.Enum44.const_0, false, false);
				}
				else if (mount_1.enum113_0 == Mount.Enum113.const_2)
				{
					text = "Unloading: " + Misc.smethod_11((long)Math.Round((double)num2), Aircraft_AirOps.Enum44.const_0, false, false);
				}
			}
			object[] array = new object[4];
			array[0] = Misc.smethod_9(mount_1.Name);
			int num3 = 1;
			string[] array2 = new string[5];
			array2[0] = "(";
			int num4 = 1;
			int num5 = 0;
			int num6 = 0;
			array2[num4] = Conversions.ToString(mount_1.method_35(ref num5, ref num6));
			array2[2] = "/";
			array2[3] = Conversions.ToString(mount_1.int_1);
			array2[4] = ")";
			array[num3] = string.Concat(array2);
			array[2] = text;
			array[3] = mount_1.vmethod_5().ToString();
			class48_0.SetValues(array);
			class48_0.DefaultCellStyle.ForeColor = Color.Black;
			class48_0.DefaultCellStyle.Font = new Font(this.Font, FontStyle.Regular);
			class48_0.DefaultCellStyle.ForeColor = base.method_2(mount_1);
			class48_0.Tag = mount_1;
		}

		// Token: 0x06008ADC RID: 35548 RVA: 0x004AB71C File Offset: 0x004A991C
		private void method_15(Class48 class48_0, Mount mount_1, WeaponRec weaponRec_1)
		{
			Class48 class48_ = class48_0.method_7().method_0("New node");
			this.method_17(class48_, weaponRec_1, mount_1);
		}

		// Token: 0x06008ADD RID: 35549 RVA: 0x004AB744 File Offset: 0x004A9944
		private void method_16(Class48 class48_0, WeaponRec weaponRec_1)
		{
			Class48 class48_ = class48_0.method_7().method_0("New node");
			this.method_18(class48_, weaponRec_1);
		}

		// Token: 0x06008ADE RID: 35550 RVA: 0x004AB76C File Offset: 0x004A996C
		private void method_17(Class48 class48_0, WeaponRec weaponRec_1, Mount mount_1)
		{
			if (this.activeUnit_0 != null)
			{
				int num = this.activeUnit_0.vmethod_89().method_34(mount_1, weaponRec_1.int_5);
				string text = "";
				if (num > 0)
				{
					text = " (" + Conversions.ToString(num) + " on mount mag)";
				}
				string text2;
				if (this.bool_3)
				{
					text2 = " (TTF:" + Misc.smethod_11((long)Math.Round((double)weaponRec_1.float_0), Aircraft_AirOps.Enum44.const_0, false, false) + ") ";
				}
				else
				{
					text2 = "";
				}
				class48_0.SetValues(new object[]
				{
					string.Concat(new string[]
					{
						Conversions.ToString(weaponRec_1.method_9()),
						"/",
						Conversions.ToString(weaponRec_1.int_2),
						text2,
						"  ",
						Misc.smethod_9(Strings.Trim(weaponRec_1.method_12(Client.smethod_46()).Name)),
						text
					}),
					Misc.smethod_55(weaponRec_1.method_12(Client.smethod_46()).method_167()),
					null,
					null,
					mount_1.hashSet_0.Contains(weaponRec_1.int_5)
				});
				class48_0.Tag = weaponRec_1;
				if (weaponRec_1.method_9() == 0)
				{
					class48_0.DefaultCellStyle.ForeColor = Color.DarkGray;
					class48_0.DefaultCellStyle.Font = new Font(this.vmethod_6().DefaultCellStyle.Font, FontStyle.Italic);
					return;
				}
				class48_0.DefaultCellStyle.ForeColor = Color.LightBlue;
			}
		}

		// Token: 0x06008ADF RID: 35551 RVA: 0x004AB8E0 File Offset: 0x004A9AE0
		private void method_18(Class48 class48_0, WeaponRec weaponRec_1)
		{
			string text;
			if (this.bool_3)
			{
				text = " (TTF:" + Misc.smethod_11((long)Math.Round((double)weaponRec_1.float_0), Aircraft_AirOps.Enum44.const_0, false, false) + ") ";
			}
			else
			{
				text = "";
			}
			class48_0.SetValues(new object[]
			{
				string.Concat(new string[]
				{
					Conversions.ToString(weaponRec_1.method_9()),
					"/",
					Conversions.ToString(weaponRec_1.int_2),
					text,
					"  ",
					Misc.smethod_9(Strings.Trim(weaponRec_1.method_12(Client.smethod_46()).Name))
				}),
				Misc.smethod_55(weaponRec_1.method_12(Client.smethod_46()).method_167())
			});
			class48_0.Tag = weaponRec_1;
			if (weaponRec_1.method_9() == 0)
			{
				class48_0.DefaultCellStyle.ForeColor = Color.DarkGray;
				class48_0.DefaultCellStyle.Font = new Font(this.vmethod_6().DefaultCellStyle.Font, FontStyle.Italic);
				return;
			}
			class48_0.DefaultCellStyle.ForeColor = Color.LightBlue;
		}

		// Token: 0x06008AE0 RID: 35552 RVA: 0x004AB9F4 File Offset: 0x004A9BF4
		public void method_19()
		{
			if (Information.IsNothing(this.activeUnit_0))
			{
				if (!Client.smethod_54().bool_0)
				{
					return;
				}
				this.activeUnit_0 = (ActiveUnit)Client.smethod_54();
			}
			this.vmethod_6().method_2().Clear();
			this.vmethod_12().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			this.Text = "Weapons for " + this.activeUnit_0.Name;
			this.vmethod_14().Visible = (this.activeUnit_0.vmethod_51().Count > 0 || (this.activeUnit_0.bool_3 && ((Aircraft)this.activeUnit_0).method_167() != null));
			this.vmethod_16().Visible = this.vmethod_14().Visible;
			this.vmethod_6().method_2().Clear();
			List<Mount> list = Enumerable.ToList<Mount>(Enumerable.OrderBy<Mount, string>(this.activeUnit_0.vmethod_51(), (WeaponsWindow._Closure$__.$I127-0 == null) ? (WeaponsWindow._Closure$__.$I127-0 = new Func<Mount, string>(WeaponsWindow._Closure$__.$I.method_0)) : WeaponsWindow._Closure$__.$I127-0));
			try
			{
				foreach (Mount mount in list)
				{
					Class48 @class = this.vmethod_6().method_2().method_0("New node");
					this.method_14(@class, mount);
					if (mount.vmethod_10().Count > 0)
					{
						@class.method_7().method_0("Temp");
					}
				}
			}
			finally
			{
				List<Mount>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
			{
				Loadout loadout = ((Aircraft)this.activeUnit_0).method_167();
				Class48 class2 = this.vmethod_6().method_2().method_0("New node");
				this.method_20(class2, loadout);
				foreach (WeaponRec weaponRec_ in loadout.weaponRec_0)
				{
					this.method_16(class2, weaponRec_);
				}
				class2.vmethod_4();
			}
		}

		// Token: 0x06008AE1 RID: 35553 RVA: 0x004ABC18 File Offset: 0x004A9E18
		private void method_20(Class48 class48_0, Loadout loadout_1)
		{
			int num = 0;
			foreach (WeaponRec weaponRec in loadout_1.weaponRec_0)
			{
				num += weaponRec.int_2;
			}
			class48_0.SetValues(new object[]
			{
				"Loadout: " + Misc.smethod_9(loadout_1.Name),
				string.Concat(new string[]
				{
					"(",
					Conversions.ToString(loadout_1.method_14()),
					"/",
					Conversions.ToString(num),
					")"
				})
			});
			class48_0.Tag = loadout_1;
			class48_0.DefaultCellStyle.ForeColor = Color.LightGray;
			class48_0.DefaultCellStyle.Font = new Font(this.Font, FontStyle.Regular);
		}

		// Token: 0x06008AE2 RID: 35554 RVA: 0x000522BC File Offset: 0x000504BC
		private void method_21(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_6().form_0 = this;
			Class2413.smethod_2().method_6().Show();
		}

		// Token: 0x06008AE3 RID: 35555 RVA: 0x004ABCDC File Offset: 0x004A9EDC
		private void method_22(object sender, EventArgs e)
		{
			int count = this.vmethod_6().SelectedRows.Count;
			if (count != 0)
			{
				if (count == 1)
				{
					this.method_5(this.weaponRec_0);
					return;
				}
				List<DataGridViewRow> list = new List<DataGridViewRow>();
				try
				{
					foreach (object obj in this.vmethod_6().SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (dataGridViewRow.Tag.GetType() == typeof(WeaponRec))
						{
							list.Add(dataGridViewRow);
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
				if (DarkMessageBox.smethod_1("Are you sure?", "Remove " + Conversions.ToString(list.Count) + " weapon records", Enum11.const_2) == DialogResult.OK)
				{
					try
					{
						foreach (DataGridViewRow dataGridViewRow2 in list)
						{
							this.method_5((WeaponRec)dataGridViewRow2.Tag);
						}
					}
					finally
					{
						List<DataGridViewRow>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
			}
		}

		// Token: 0x06008AE4 RID: 35556 RVA: 0x004ABDF4 File Offset: 0x004A9FF4
		private void method_23(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1)
			{
				DataGridViewColumn dataGridViewColumn = this.vmethod_6().Columns[e.ColumnIndex];
				if (!Information.IsNothing(this.vmethod_6().method_5()))
				{
					if (this.vmethod_6().method_5().Tag.GetType() == typeof(WeaponRec) && Operators.CompareString(dataGridViewColumn.Name, "ReloadPriority", false) == 0 && !Information.IsNothing(this.mount_0))
					{
						DataGridViewCheckBoxCell dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)this.vmethod_6()[e.ColumnIndex, e.RowIndex];
						WeaponRec weaponRec = (WeaponRec)this.vmethod_6().method_5().Tag;
						Mount mount = (Mount)this.vmethod_6().method_5().method_9().Tag;
						if (mount.hashSet_0.Contains(weaponRec.int_5))
						{
							mount.hashSet_0.Remove(weaponRec.int_5);
							dataGridViewCheckBoxCell.Value = false;
						}
						else
						{
							mount.hashSet_0.Add(weaponRec.int_5);
							dataGridViewCheckBoxCell.Value = true;
						}
					}
					if (Operators.CompareString(dataGridViewColumn.Name, "ShowArcs", false) == 0 && !Information.IsNothing(this.mount_0))
					{
						Mount mount2;
						WeaponRec weaponRec2;
						try
						{
							foreach (Class48 @class in Class2558.smethod_15(this.vmethod_6()))
							{
								DataGridViewCheckBoxCell dataGridViewCheckBoxCell2 = (DataGridViewCheckBoxCell)@class.Cells[e.ColumnIndex];
								if (Operators.ConditionalCompareObjectEqual(dataGridViewCheckBoxCell2.Value, true, false))
								{
									if (@class.Tag.GetType() == typeof(Mount))
									{
										mount2 = (Mount)@class.Tag;
									}
									else if (@class.Tag.GetType() == typeof(WeaponRec))
									{
										weaponRec2 = (WeaponRec)@class.Tag;
									}
								}
								dataGridViewCheckBoxCell2.Value = false;
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
						Mount mount3;
						WeaponRec weaponRec3;
						if (this.vmethod_6().method_5().Tag.GetType() == typeof(Mount))
						{
							mount3 = (Mount)this.vmethod_6().method_5().Tag;
						}
						else if (this.vmethod_6().method_5().Tag.GetType() == typeof(WeaponRec))
						{
							mount3 = (Mount)this.vmethod_6().method_5().method_9().Tag;
							weaponRec3 = (WeaponRec)this.vmethod_6().method_5().Tag;
						}
						else
						{
							mount3 = null;
						}
						if (!Information.IsNothing(mount3))
						{
							DataGridViewCheckBoxCell dataGridViewCheckBoxCell2 = (DataGridViewCheckBoxCell)this.vmethod_6()[e.ColumnIndex, e.RowIndex];
							if (!Information.IsNothing(mount3) && !Information.IsNothing(mount2) && mount2 == mount3)
							{
								Client.mount_0 = null;
							}
							else if (!Information.IsNothing(weaponRec3) && !Information.IsNothing(weaponRec2) && weaponRec2 == weaponRec3)
							{
								Client.mount_0 = null;
							}
							else
							{
								dataGridViewCheckBoxCell2.Value = true;
								Client.mount_0 = mount3;
							}
							Client.bool_1 = true;
						}
					}
				}
			}
		}

		// Token: 0x06008AE5 RID: 35557 RVA: 0x004AC13C File Offset: 0x004AA33C
		private void method_24(object sender, EventArgs1 e)
		{
			WeaponsWindow.Class2554 @class = new WeaponsWindow.Class2554(@class);
			@class.weaponsWindow_0 = this;
			@class.eventArgs1_0 = e;
			@class.eventArgs1_0.method_0().method_7().Clear();
			if (@class.eventArgs1_0.method_0().Tag != null && @class.eventArgs1_0.method_0().Tag.GetType() == typeof(Mount))
			{
				WeaponsWindow.Class2553 class2 = new WeaponsWindow.Class2553(class2);
				class2.class2554_0 = @class;
				class2.mount_0 = (Mount)class2.class2554_0.eventArgs1_0.method_0().Tag;
				Task.Factory.StartNew(new Action(class2.method_0));
				this.mount_0 = (Mount)class2.class2554_0.eventArgs1_0.method_0().Tag;
				this.vmethod_16().Visible = false;
			}
			if (@class.eventArgs1_0.method_0().Tag.GetType() == typeof(Loadout))
			{
				this.vmethod_14().Visible = false;
				this.vmethod_16().Visible = false;
			}
		}

		// Token: 0x06008AE6 RID: 35558 RVA: 0x00053081 File Offset: 0x00051281
		private void method_25(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_2().form_0 = this;
			Class2413.smethod_2().method_2().Show();
		}

		// Token: 0x06008AE7 RID: 35559 RVA: 0x004AC254 File Offset: 0x004AA454
		private void method_26(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
			{
				try
				{
					Class48 @class = null;
					try
					{
						foreach (Class48 class2 in Class2558.smethod_15(this.vmethod_6()))
						{
							if (class2.Selected)
							{
								@class = class2;
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
					if (!Information.IsNothing(@class))
					{
						if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(@class.Tag)) && @class.Tag.GetType() == typeof(WeaponRec))
						{
							int int_ = ((WeaponRec)@class.Tag).int_5;
							Client.smethod_63("Weapon", int_, null);
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200104", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06008AE8 RID: 35560 RVA: 0x004AC354 File Offset: 0x004AA554
		private void method_27(object sender, EventArgs e)
		{
			this.mount_0 = null;
			if (!Information.IsNothing(this.vmethod_6().method_5()))
			{
				if (this.vmethod_6().method_5().Tag.GetType() == typeof(Mount))
				{
					this.mount_0 = (Mount)this.vmethod_6().method_5().Tag;
				}
				else if (this.vmethod_6().method_5().method_9().Tag.GetType() == typeof(Mount))
				{
					this.mount_0 = (Mount)this.vmethod_6().method_5().method_9().Tag;
				}
			}
			if (Information.IsNothing(this.mount_0))
			{
				DarkMessageBox.smethod_1("No mount selected!", string.Empty, Enum11.const_0);
				return;
			}
			this.vmethod_6().method_5().method_9().method_7().Remove(this.vmethod_6().method_5());
			if (!Information.IsNothing(this.activeUnit_0))
			{
				this.activeUnit_0.vmethod_51().method_6(this.mount_0);
			}
		}

		// Token: 0x06008AE9 RID: 35561 RVA: 0x004AC46C File Offset: 0x004AA66C
		private void method_28(object sender, EventArgs e)
		{
			bool flag;
			if (!(flag = this.bool_4))
			{
				this.bool_4 = true;
				this.vmethod_28().Text = "Set";
				this.vmethod_20().Visible = true;
				this.vmethod_26().Visible = false;
				return;
			}
			if (!flag)
			{
				return;
			}
			this.bool_4 = false;
			this.vmethod_28().Text = "Change";
			this.vmethod_20().Visible = false;
			this.vmethod_26().Visible = true;
			if (!Information.IsNothing(this.weaponRec_0))
			{
				if (Operators.CompareString(this.vmethod_20().Text, "", false) != 0 & Versioned.IsNumeric(this.vmethod_20().Text))
				{
					int num = Conversions.ToInteger(this.vmethod_20().Text);
					if (num < 0)
					{
						num = 0;
					}
					if ((double)num / (double)this.weaponRec_0.int_4 > (double)this.weaponRec_0.int_2)
					{
						num = this.weaponRec_0.int_2;
					}
					if (!Information.IsNothing(this.mount_0))
					{
						this.weaponRec_0.method_10(0);
						Mount mount = this.mount_0;
						int num2 = 0;
						int num3 = 0;
						int num4 = mount.method_35(ref num2, ref num3);
						if ((double)num / (double)this.weaponRec_0.int_4 > (double)(this.mount_0.int_1 - num4))
						{
							num = this.mount_0.int_1 - num4 * this.weaponRec_0.int_4;
						}
					}
					if (num < 0)
					{
						num = 0;
					}
					this.weaponRec_0.method_10(num);
					this.vmethod_26().Text = Conversions.ToString(num);
					try
					{
						foreach (Class48 @class in this.vmethod_6().method_2())
						{
							try
							{
								foreach (Class48 class2 in @class.method_7())
								{
									if (class2.Tag == this.weaponRec_0)
									{
										class2.SetValues(new object[]
										{
											string.Concat(new string[]
											{
												Conversions.ToString(this.weaponRec_0.method_9()),
												"/",
												Conversions.ToString(this.weaponRec_0.int_2),
												"  ",
												Misc.smethod_9(Strings.Trim(this.weaponRec_0.method_12(Client.smethod_46()).Name))
											})
										});
									}
								}
							}
							finally
							{
								IEnumerator<Class48> enumerator2;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
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
					if (!Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.bool_3)
					{
						Aircraft aircraft = (Aircraft)this.activeUnit_0;
						if (!Information.IsNothing(aircraft.method_167()))
						{
							aircraft.method_161().method_45();
						}
					}
				}
				this.activeUnit_0.vmethod_89().vmethod_3();
				Client.bool_1 = true;
				Class2413.smethod_2().method_41().method_84();
			}
		}

		// Token: 0x06008AEA RID: 35562 RVA: 0x004AC768 File Offset: 0x004AA968
		private void method_29(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.vmethod_6().method_5()))
			{
				this.vmethod_22().Visible = true;
				this.vmethod_18().Visible = false;
				this.bool_4 = false;
				this.vmethod_18().Visible = true;
				this.vmethod_26().Visible = true;
				this.vmethod_20().Visible = false;
				this.vmethod_28().Text = "Change";
				if (this.vmethod_6().method_5().Tag.GetType() == typeof(WeaponRec))
				{
					this.weaponRec_0 = (WeaponRec)this.vmethod_6().method_5().Tag;
					if (this.vmethod_6().method_5().method_9().Tag.GetType() == typeof(Mount))
					{
						this.mount_0 = (Mount)this.vmethod_6().method_5().method_9().Tag;
						this.loadout_0 = null;
					}
					else if (this.vmethod_6().method_5().method_9().Tag.GetType() == typeof(Loadout))
					{
						this.mount_0 = null;
						this.loadout_0 = (Loadout)this.vmethod_6().method_5().method_9().Tag;
					}
					this.vmethod_14().Visible = true;
					this.vmethod_16().Visible = true;
					this.vmethod_20().Text = Conversions.ToString(this.weaponRec_0.method_9());
					this.vmethod_26().Text = Conversions.ToString(this.weaponRec_0.method_9());
					this.vmethod_24().Visible = true;
					this.vmethod_18().Visible = true;
					this.vmethod_26().Visible = true;
					this.vmethod_28().Visible = true;
				}
				if (this.vmethod_6().method_5().Tag.GetType() == typeof(Mount))
				{
					this.mount_0 = (Mount)this.vmethod_6().method_5().Tag;
					this.loadout_0 = null;
					this.vmethod_14().Visible = true;
					this.vmethod_16().Visible = false;
					this.vmethod_24().Visible = true;
					this.vmethod_26().Visible = false;
					this.vmethod_18().Visible = false;
					this.vmethod_28().Visible = false;
				}
				if (this.vmethod_6().method_5().Tag.GetType() == typeof(Loadout))
				{
					this.loadout_0 = (Loadout)this.vmethod_6().method_5().Tag;
					this.vmethod_14().Visible = false;
					this.vmethod_16().Visible = false;
					this.vmethod_24().Visible = false;
					this.vmethod_26().Visible = false;
					this.vmethod_18().Visible = false;
					this.vmethod_28().Visible = false;
				}
			}
		}

		// Token: 0x06008AEB RID: 35563 RVA: 0x004ACA48 File Offset: 0x004AAC48
		private void WeaponsWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F8 && base.Visible)
			{
				base.Close();
				return;
			}
			if (this.bool_5)
			{
				if (e.KeyValue == 13 && base.Visible)
				{
					this.vmethod_28().Select();
					return;
				}
				if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
				{
					Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
			if (!this.bool_5 && e.KeyValue != 32)
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06008AEC RID: 35564 RVA: 0x000530A2 File Offset: 0x000512A2
		private void method_30(object sender, EventArgs e)
		{
			this.bool_5 = true;
		}

		// Token: 0x06008AED RID: 35565 RVA: 0x000530AB File Offset: 0x000512AB
		private void method_31(object sender, EventArgs e)
		{
			this.bool_5 = false;
			this.vmethod_28().Select();
		}

		// Token: 0x06008AEE RID: 35566 RVA: 0x004ACB68 File Offset: 0x004AAD68
		private void WeaponsWindow_FormClosed(object sender, FormClosedEventArgs e)
		{
			PlatformComponent.smethod_1(new PlatformComponent.Delegate46(this.method_10));
			WeaponRec.smethod_1(new WeaponRec.Delegate54(this.method_11));
			Mount.smethod_3(new Mount.Delegate44(this.method_6));
			Mount.smethod_5(new Mount.Delegate45(this.method_7));
			Loadout.smethod_1(new Loadout.Delegate34(this.method_8));
			Loadout.smethod_3(new Loadout.Delegate35(this.method_9));
			ActiveUnit.smethod_5(new ActiveUnit.Delegate14(this.method_13));
			ActiveUnit.smethod_7(new ActiveUnit.Delegate15(this.method_12));
			Client.mount_0 = null;
		}

		// Token: 0x06008AEF RID: 35567 RVA: 0x004ACC04 File Offset: 0x004AAE04
		private void method_32(object sender, EventArgs e)
		{
			if (Client.smethod_0().method_0() == Class279.Enum68.const_1)
			{
				try
				{
					foreach (Class48 @class in this.vmethod_6().method_2())
					{
						if (@class.Tag != null && @class.GetType() == typeof(Mount))
						{
							Mount mount_ = (Mount)@class.Tag;
							this.method_14(@class, mount_);
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

		// Token: 0x04004B2D RID: 19245
		[AccessedThroughProperty("Mount")]
		[CompilerGenerated]
		private Class44 class44_0;

		// Token: 0x04004B2E RID: 19246
		[AccessedThroughProperty("WeaponType")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04004B2F RID: 19247
		[CompilerGenerated]
		[AccessedThroughProperty("Status")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04004B30 RID: 19248
		[AccessedThroughProperty("TGV_Weapons")]
		[CompilerGenerated]
		private Class50 class50_0;

		// Token: 0x04004B31 RID: 19249
		[CompilerGenerated]
		[AccessedThroughProperty("ImageList1")]
		private ImageList imageList_0;

		// Token: 0x04004B32 RID: 19250
		[CompilerGenerated]
		[AccessedThroughProperty("Timer1")]
		private Timer timer_0;

		// Token: 0x04004B33 RID: 19251
		[CompilerGenerated]
		[AccessedThroughProperty("TS_Edit")]
		private Class125 class125_0;

		// Token: 0x04004B34 RID: 19252
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_AddRec")]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04004B35 RID: 19253
		[AccessedThroughProperty("TSB_RemoveRec")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x04004B36 RID: 19254
		[CompilerGenerated]
		[AccessedThroughProperty("TSL_WeaponCount1")]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x04004B37 RID: 19255
		[AccessedThroughProperty("TSTB_RecCount")]
		[CompilerGenerated]
		private ToolStripTextBox toolStripTextBox_0;

		// Token: 0x04004B38 RID: 19256
		[AccessedThroughProperty("TSB_AddMount")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_2;

		// Token: 0x04004B39 RID: 19257
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_RemoveMount")]
		private ToolStripButton toolStripButton_3;

		// Token: 0x04004B3A RID: 19258
		[AccessedThroughProperty("TSL_WeaponCount2")]
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_1;

		// Token: 0x04004B3B RID: 19259
		[AccessedThroughProperty("TSB_ChangeWeaponCount")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_4;

		// Token: 0x04004B3C RID: 19260
		[AccessedThroughProperty("ToolStripSeparator1")]
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x04004B3D RID: 19261
		[AccessedThroughProperty("ToolStripSeparator2")]
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_1;

		// Token: 0x04004B3E RID: 19262
		[AccessedThroughProperty("Column1")]
		[CompilerGenerated]
		private Class44 class44_1;

		// Token: 0x04004B3F RID: 19263
		[AccessedThroughProperty("Type")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04004B40 RID: 19264
		[CompilerGenerated]
		[AccessedThroughProperty("TimeToFire")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04004B41 RID: 19265
		[CompilerGenerated]
		[AccessedThroughProperty("Column3")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04004B42 RID: 19266
		[AccessedThroughProperty("ReloadPriority")]
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x04004B43 RID: 19267
		[AccessedThroughProperty("ShowArcs")]
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		// Token: 0x04004B44 RID: 19268
		private ActiveUnit activeUnit_0;

		// Token: 0x04004B45 RID: 19269
		private WeaponRec weaponRec_0;

		// Token: 0x04004B46 RID: 19270
		private Mount mount_0;

		// Token: 0x04004B47 RID: 19271
		private Loadout loadout_0;

		// Token: 0x04004B48 RID: 19272
		private bool bool_3;

		// Token: 0x04004B49 RID: 19273
		private bool bool_4;

		// Token: 0x04004B4A RID: 19274
		private bool bool_5;

		// Token: 0x04004B4B RID: 19275
		private bool bool_6;

		// Token: 0x02000F21 RID: 3873
		[CompilerGenerated]
		internal sealed class Class2537
		{
			// Token: 0x06008AF0 RID: 35568 RVA: 0x000530BF File Offset: 0x000512BF
			public Class2537(WeaponsWindow.Class2537 class2537_0)
			{
				if (class2537_0 != null)
				{
					this.class48_0 = class2537_0.class48_0;
				}
			}

			// Token: 0x04004B4C RID: 19276
			public Class48 class48_0;

			// Token: 0x04004B4D RID: 19277
			public WeaponsWindow.Class2538 class2538_0;
		}

		// Token: 0x02000F22 RID: 3874
		[CompilerGenerated]
		internal sealed class Class2538
		{
			// Token: 0x06008AF1 RID: 35569 RVA: 0x000530D6 File Offset: 0x000512D6
			public Class2538(WeaponsWindow.Class2538 class2538_0)
			{
				if (class2538_0 != null)
				{
					this.mount_0 = class2538_0.mount_0;
				}
			}

			// Token: 0x04004B4E RID: 19278
			public Mount mount_0;

			// Token: 0x04004B4F RID: 19279
			public WeaponsWindow weaponsWindow_0;
		}

		// Token: 0x02000F23 RID: 3875
		[CompilerGenerated]
		internal sealed class Class2539
		{
			// Token: 0x06008AF2 RID: 35570 RVA: 0x000530ED File Offset: 0x000512ED
			public Class2539(WeaponsWindow.Class2539 class2539_0)
			{
				if (class2539_0 != null)
				{
					this.weaponRec_0 = class2539_0.weaponRec_0;
				}
			}

			// Token: 0x06008AF3 RID: 35571 RVA: 0x004ACC8C File Offset: 0x004AAE8C
			internal void method_0()
			{
				this.class2537_0.class2538_0.weaponsWindow_0.method_15(this.class2537_0.class48_0, this.class2537_0.class2538_0.mount_0, this.weaponRec_0);
				if (!this.class2537_0.class48_0.method_0())
				{
					this.class2537_0.class48_0.vmethod_4();
				}
			}

			// Token: 0x04004B50 RID: 19280
			public WeaponRec weaponRec_0;

			// Token: 0x04004B51 RID: 19281
			public WeaponsWindow.Class2537 class2537_0;
		}

		// Token: 0x02000F24 RID: 3876
		[CompilerGenerated]
		internal sealed class Class2540
		{
			// Token: 0x06008AF4 RID: 35572 RVA: 0x00053104 File Offset: 0x00051304
			public Class2540(WeaponsWindow.Class2540 class2540_0)
			{
				if (class2540_0 != null)
				{
					this.class48_0 = class2540_0.class48_0;
				}
			}

			// Token: 0x04004B52 RID: 19282
			public Class48 class48_0;
		}

		// Token: 0x02000F25 RID: 3877
		[CompilerGenerated]
		internal sealed class Class2541
		{
			// Token: 0x06008AF5 RID: 35573 RVA: 0x0005311B File Offset: 0x0005131B
			public Class2541(WeaponsWindow.Class2541 class2541_0)
			{
				if (class2541_0 != null)
				{
					this.class48_0 = class2541_0.class48_0;
				}
			}

			// Token: 0x06008AF6 RID: 35574 RVA: 0x00053132 File Offset: 0x00051332
			internal void method_0()
			{
				this.class2540_0.class48_0.method_7().Remove(this.class48_0);
			}

			// Token: 0x04004B53 RID: 19283
			public Class48 class48_0;

			// Token: 0x04004B54 RID: 19284
			public WeaponsWindow.Class2540 class2540_0;
		}

		// Token: 0x02000F26 RID: 3878
		[CompilerGenerated]
		internal sealed class Class2542
		{
			// Token: 0x06008AF7 RID: 35575 RVA: 0x00053150 File Offset: 0x00051350
			public Class2542(WeaponsWindow.Class2542 class2542_0)
			{
				if (class2542_0 != null)
				{
					this.class48_0 = class2542_0.class48_0;
				}
			}

			// Token: 0x04004B55 RID: 19285
			public Class48 class48_0;

			// Token: 0x04004B56 RID: 19286
			public WeaponsWindow weaponsWindow_0;
		}

		// Token: 0x02000F27 RID: 3879
		[CompilerGenerated]
		internal sealed class Class2543
		{
			// Token: 0x06008AF8 RID: 35576 RVA: 0x00053167 File Offset: 0x00051367
			public Class2543(WeaponsWindow.Class2543 class2543_0)
			{
				if (class2543_0 != null)
				{
					this.weaponRec_0 = class2543_0.weaponRec_0;
				}
			}

			// Token: 0x06008AF9 RID: 35577 RVA: 0x004ACCF4 File Offset: 0x004AAEF4
			internal void method_0()
			{
				this.class2542_0.weaponsWindow_0.method_16(this.class2542_0.class48_0, this.weaponRec_0);
				if (!this.class2542_0.class48_0.method_0())
				{
					this.class2542_0.class48_0.vmethod_4();
				}
			}

			// Token: 0x04004B57 RID: 19287
			public WeaponRec weaponRec_0;

			// Token: 0x04004B58 RID: 19288
			public WeaponsWindow.Class2542 class2542_0;
		}

		// Token: 0x02000F28 RID: 3880
		[CompilerGenerated]
		internal sealed class Class2544
		{
			// Token: 0x06008AFA RID: 35578 RVA: 0x0005317E File Offset: 0x0005137E
			public Class2544(WeaponsWindow.Class2544 class2544_0)
			{
				if (class2544_0 != null)
				{
					this.class48_0 = class2544_0.class48_0;
				}
			}

			// Token: 0x04004B59 RID: 19289
			public Class48 class48_0;
		}

		// Token: 0x02000F29 RID: 3881
		[CompilerGenerated]
		internal sealed class Class2545
		{
			// Token: 0x06008AFB RID: 35579 RVA: 0x00053195 File Offset: 0x00051395
			public Class2545(WeaponsWindow.Class2545 class2545_0)
			{
				if (class2545_0 != null)
				{
					this.class48_0 = class2545_0.class48_0;
				}
			}

			// Token: 0x06008AFC RID: 35580 RVA: 0x000531AC File Offset: 0x000513AC
			internal void method_0()
			{
				this.class2544_0.class48_0.method_7().Remove(this.class48_0);
			}

			// Token: 0x04004B5A RID: 19290
			public Class48 class48_0;

			// Token: 0x04004B5B RID: 19291
			public WeaponsWindow.Class2544 class2544_0;
		}

		// Token: 0x02000F2A RID: 3882
		[CompilerGenerated]
		internal sealed class Class2546
		{
			// Token: 0x06008AFD RID: 35581 RVA: 0x000531CA File Offset: 0x000513CA
			public Class2546(WeaponsWindow.Class2546 class2546_0)
			{
				if (class2546_0 != null)
				{
					this.class48_0 = class2546_0.class48_0;
				}
			}

			// Token: 0x04004B5C RID: 19292
			public Class48 class48_0;

			// Token: 0x04004B5D RID: 19293
			public WeaponsWindow weaponsWindow_0;
		}

		// Token: 0x02000F2B RID: 3883
		[CompilerGenerated]
		internal sealed class Class2547
		{
			// Token: 0x06008AFE RID: 35582 RVA: 0x000531E1 File Offset: 0x000513E1
			public Class2547(WeaponsWindow.Class2547 class2547_0)
			{
				if (class2547_0 != null)
				{
					this.mount_0 = class2547_0.mount_0;
				}
			}

			// Token: 0x06008AFF RID: 35583 RVA: 0x000531F8 File Offset: 0x000513F8
			internal void method_0()
			{
				this.class2546_0.weaponsWindow_0.method_14(this.class2546_0.class48_0, this.mount_0);
			}

			// Token: 0x04004B5E RID: 19294
			public Mount mount_0;

			// Token: 0x04004B5F RID: 19295
			public WeaponsWindow.Class2546 class2546_0;
		}

		// Token: 0x02000F2C RID: 3884
		[CompilerGenerated]
		internal sealed class Class2548
		{
			// Token: 0x06008B00 RID: 35584 RVA: 0x0005321B File Offset: 0x0005141B
			public Class2548(WeaponsWindow.Class2548 class2548_0)
			{
				if (class2548_0 != null)
				{
					this.class48_0 = class2548_0.class48_0;
				}
			}

			// Token: 0x04004B60 RID: 19296
			public Class48 class48_0;

			// Token: 0x04004B61 RID: 19297
			public WeaponsWindow.Class2550 class2550_0;
		}

		// Token: 0x02000F2D RID: 3885
		[CompilerGenerated]
		internal sealed class Class2549
		{
			// Token: 0x06008B01 RID: 35585 RVA: 0x00053232 File Offset: 0x00051432
			public Class2549(WeaponsWindow.Class2549 class2549_0)
			{
				if (class2549_0 != null)
				{
					this.class48_0 = class2549_0.class48_0;
				}
			}

			// Token: 0x06008B02 RID: 35586 RVA: 0x004ACD48 File Offset: 0x004AAF48
			internal void method_0()
			{
				if (this.class2548_0.class48_0.Tag.GetType() == typeof(Mount))
				{
					this.class2548_0.class2550_0.weaponsWindow_0.method_17(this.class48_0, this.class2548_0.class2550_0.weaponRec_0, (Mount)this.class2548_0.class48_0.Tag);
				}
				if (this.class2548_0.class48_0.Tag.GetType() == typeof(Loadout))
				{
					this.class2548_0.class2550_0.weaponsWindow_0.method_18(this.class48_0, this.class2548_0.class2550_0.weaponRec_0);
				}
			}

			// Token: 0x04004B62 RID: 19298
			public Class48 class48_0;

			// Token: 0x04004B63 RID: 19299
			public WeaponsWindow.Class2548 class2548_0;
		}

		// Token: 0x02000F2E RID: 3886
		[CompilerGenerated]
		internal sealed class Class2550
		{
			// Token: 0x06008B03 RID: 35587 RVA: 0x00053249 File Offset: 0x00051449
			public Class2550(WeaponsWindow.Class2550 class2550_0)
			{
				if (class2550_0 != null)
				{
					this.weaponRec_0 = class2550_0.weaponRec_0;
				}
			}

			// Token: 0x04004B64 RID: 19300
			public WeaponRec weaponRec_0;

			// Token: 0x04004B65 RID: 19301
			public WeaponsWindow weaponsWindow_0;
		}

		// Token: 0x02000F2F RID: 3887
		[CompilerGenerated]
		internal sealed class Class2551
		{
			// Token: 0x06008B04 RID: 35588 RVA: 0x00053260 File Offset: 0x00051460
			public Class2551(WeaponsWindow.Class2551 class2551_0)
			{
				if (class2551_0 != null)
				{
					this.class48_0 = class2551_0.class48_0;
				}
			}

			// Token: 0x06008B05 RID: 35589 RVA: 0x00053277 File Offset: 0x00051477
			internal void method_0()
			{
				this.weaponsWindow_0.vmethod_6().method_2().Remove(this.class48_0);
			}

			// Token: 0x04004B66 RID: 19302
			public Class48 class48_0;

			// Token: 0x04004B67 RID: 19303
			public WeaponsWindow weaponsWindow_0;
		}

		// Token: 0x02000F30 RID: 3888
		[CompilerGenerated]
		internal sealed class Class2552
		{
			// Token: 0x06008B06 RID: 35590 RVA: 0x00053295 File Offset: 0x00051495
			public Class2552(WeaponsWindow.Class2552 class2552_0)
			{
				if (class2552_0 != null)
				{
					this.mount_0 = class2552_0.mount_0;
				}
			}

			// Token: 0x06008B07 RID: 35591 RVA: 0x004ACE04 File Offset: 0x004AB004
			internal void method_0()
			{
				Class48 @class = this.weaponsWindow_0.vmethod_6().method_2().method_0("New node");
				this.weaponsWindow_0.method_14(@class, this.mount_0);
				try
				{
					foreach (WeaponRec weaponRec_ in this.mount_0.vmethod_10())
					{
						this.weaponsWindow_0.method_15(@class, this.mount_0, weaponRec_);
					}
				}
				finally
				{
					List<WeaponRec>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				@class.vmethod_4();
			}

			// Token: 0x04004B68 RID: 19304
			public Mount mount_0;

			// Token: 0x04004B69 RID: 19305
			public WeaponsWindow weaponsWindow_0;
		}

		// Token: 0x02000F32 RID: 3890
		[CompilerGenerated]
		internal sealed class Class2553
		{
			// Token: 0x06008B0B RID: 35595 RVA: 0x000532B8 File Offset: 0x000514B8
			public Class2553(WeaponsWindow.Class2553 class2553_0)
			{
				if (class2553_0 != null)
				{
					this.mount_0 = class2553_0.mount_0;
				}
			}

			// Token: 0x06008B0C RID: 35596 RVA: 0x004ACE9C File Offset: 0x004AB09C
			internal void method_0()
			{
				try
				{
					List<WeaponRec>.Enumerator enumerator = this.mount_0.vmethod_10().GetEnumerator();
					while (enumerator.MoveNext())
					{
						WeaponsWindow.Class2555 @class = new WeaponsWindow.Class2555(@class);
						@class.class2553_0 = this;
						@class.weaponRec_0 = enumerator.Current;
						this.class2554_0.weaponsWindow_0.Invoke(new VB$AnonymousDelegate_0(@class.method_0));
					}
				}
				finally
				{
					List<WeaponRec>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}

			// Token: 0x04004B6C RID: 19308
			public Mount mount_0;

			// Token: 0x04004B6D RID: 19309
			public WeaponsWindow.Class2554 class2554_0;
		}

		// Token: 0x02000F33 RID: 3891
		[CompilerGenerated]
		internal sealed class Class2554
		{
			// Token: 0x06008B0D RID: 35597 RVA: 0x000532CF File Offset: 0x000514CF
			public Class2554(WeaponsWindow.Class2554 class2554_0)
			{
				if (class2554_0 != null)
				{
					this.eventArgs1_0 = class2554_0.eventArgs1_0;
				}
			}

			// Token: 0x04004B6E RID: 19310
			public EventArgs1 eventArgs1_0;

			// Token: 0x04004B6F RID: 19311
			public WeaponsWindow weaponsWindow_0;
		}

		// Token: 0x02000F34 RID: 3892
		[CompilerGenerated]
		internal sealed class Class2555
		{
			// Token: 0x06008B0E RID: 35598 RVA: 0x000532E6 File Offset: 0x000514E6
			public Class2555(WeaponsWindow.Class2555 class2555_0)
			{
				if (class2555_0 != null)
				{
					this.weaponRec_0 = class2555_0.weaponRec_0;
				}
			}

			// Token: 0x06008B0F RID: 35599 RVA: 0x000532FD File Offset: 0x000514FD
			internal void method_0()
			{
				this.class2553_0.class2554_0.weaponsWindow_0.method_15(this.class2553_0.class2554_0.eventArgs1_0.method_0(), this.class2553_0.mount_0, this.weaponRec_0);
			}

			// Token: 0x04004B70 RID: 19312
			public WeaponRec weaponRec_0;

			// Token: 0x04004B71 RID: 19313
			public WeaponsWindow.Class2553 class2553_0;
		}
	}
}
