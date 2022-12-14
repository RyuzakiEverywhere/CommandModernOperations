using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
using ns13;
using ns2;
using ns4;
using ns5;
using ns7;
using ns9;

namespace Command
{
	// Token: 0x02000E6E RID: 3694
	[DesignerGenerated]
	public sealed partial class CampaignPlayWindow : DarkSecondaryFormBase
	{
		// Token: 0x06007128 RID: 28968 RVA: 0x003CE2AC File Offset: 0x003CC4AC
		private void InitializeComponent_1()
		{
			new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.vmethod_3(new Control9());
			this.vmethod_1(new WebBrowser());
			this.vmethod_5(new Control12());
			this.vmethod_7(new TabPage());
			this.vmethod_21(new Control9());
			this.vmethod_19(new Class116());
			this.vmethod_17(new FlowLayoutPanel());
			this.vmethod_9(new TabPage());
			this.vmethod_23(new Control11());
			this.vmethod_13(new Control9());
			this.vmethod_15(new Control9());
			this.vmethod_11(new Class50());
			this.vmethod_25(new Class44());
			this.vmethod_27(new Class44());
			this.vmethod_29(new Class44());
			this.vmethod_4().SuspendLayout();
			this.vmethod_6().SuspendLayout();
			this.vmethod_8().SuspendLayout();
			((ISupportInitialize)this.vmethod_10()).BeginInit();
			base.SuspendLayout();
			this.vmethod_2().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DialogResult = DialogResult.None;
			this.vmethod_2().Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_2().ForeColor = SystemColors.Control;
			this.vmethod_2().Location = new Point(316, 508);
			this.vmethod_2().Name = "Button1";
			this.vmethod_2().method_1(0);
			this.vmethod_2().Size = new Size(253, 48);
			this.vmethod_2().TabIndex = 17;
			this.vmethod_2().Text = "START NEW CAMPAIGN";
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_0().Location = new Point(316, 3);
			this.vmethod_0().MinimumSize = new Size(20, 20);
			this.vmethod_0().Name = "WebBrowser1";
			this.vmethod_0().Size = new Size(687, 502);
			this.vmethod_0().TabIndex = 16;
			this.vmethod_4().Controls.Add(this.vmethod_6());
			this.vmethod_4().Controls.Add(this.vmethod_8());
			this.vmethod_4().Cursor = Cursors.Hand;
			this.vmethod_4().Dock = DockStyle.Fill;
			this.vmethod_4().Font = new Font("Segoe UI", 8f);
			this.vmethod_4().ItemSize = new Size(80, 20);
			this.vmethod_4().Location = new Point(0, 0);
			this.vmethod_4().Name = "TabControl1";
			this.vmethod_4().SelectedIndex = 0;
			this.vmethod_4().Size = new Size(1014, 588);
			this.vmethod_4().TabIndex = 19;
			this.vmethod_6().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_6().Controls.Add(this.vmethod_20());
			this.vmethod_6().Controls.Add(this.vmethod_18());
			this.vmethod_6().Controls.Add(this.vmethod_16());
			this.vmethod_6().Controls.Add(this.vmethod_0());
			this.vmethod_6().Controls.Add(this.vmethod_2());
			this.vmethod_6().Location = new Point(4, 24);
			this.vmethod_6().Name = "TabPage1";
			this.vmethod_6().Padding = new Padding(3);
			this.vmethod_6().Size = new Size(1006, 560);
			this.vmethod_6().TabIndex = 0;
			this.vmethod_6().Text = "Start new campaign";
			this.vmethod_20().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_20().BackColor = Color.Transparent;
			this.vmethod_20().DialogResult = DialogResult.None;
			this.vmethod_20().Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.vmethod_20().ForeColor = SystemColors.Control;
			this.vmethod_20().Location = new Point(750, 508);
			this.vmethod_20().Name = "Button2";
			this.vmethod_20().method_1(0);
			this.vmethod_20().Size = new Size(253, 48);
			this.vmethod_20().TabIndex = 20;
			this.vmethod_20().Text = "CANCEL";
			this.vmethod_18().method_2(true);
			this.vmethod_18().Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(317, 4);
			this.vmethod_18().Name = "Label_SelectCampaign";
			this.vmethod_18().Size = new Size(429, 42);
			this.vmethod_18().TabIndex = 19;
			this.vmethod_18().Text = "Select one of the campaigns available to start a new session, \r\nor resume an existing campaign session from a save.";
			this.vmethod_16().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_16().AutoScroll = true;
			this.vmethod_16().BackColor = Color.FromArgb(43, 43, 43);
			this.vmethod_16().BorderStyle = BorderStyle.FixedSingle;
			this.vmethod_16().FlowDirection = FlowDirection.TopDown;
			this.vmethod_16().Location = new Point(0, 0);
			this.vmethod_16().Name = "FlowLayoutPanel1";
			this.vmethod_16().Size = new Size(305, 562);
			this.vmethod_16().TabIndex = 18;
			this.vmethod_16().WrapContents = false;
			this.vmethod_8().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_8().Controls.Add(this.vmethod_22());
			this.vmethod_8().Controls.Add(this.vmethod_12());
			this.vmethod_8().Controls.Add(this.vmethod_14());
			this.vmethod_8().Controls.Add(this.vmethod_10());
			this.vmethod_8().Location = new Point(4, 24);
			this.vmethod_8().Name = "TabPage2";
			this.vmethod_8().Padding = new Padding(3);
			this.vmethod_8().Size = new Size(1006, 560);
			this.vmethod_8().TabIndex = 1;
			this.vmethod_8().Text = "Resume from save";
			this.vmethod_22().Anchor = (AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_22().BackColor = Color.Transparent;
			this.vmethod_22().Font = new Font("Segoe UI", 9f);
			this.vmethod_22().Location = new Point(346, 521);
			this.vmethod_22().method_1(100);
			this.vmethod_22().Name = "PB_CampaignSaves";
			this.vmethod_22().method_3(true);
			this.vmethod_22().method_5(true);
			this.vmethod_22().Size = new Size(340, 33);
			this.vmethod_22().TabIndex = 11;
			this.vmethod_22().Value = 0;
			this.vmethod_12().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.vmethod_12().ForeColor = SystemColors.Control;
			this.vmethod_12().Location = new Point(773, 521);
			this.vmethod_12().Name = "Button4";
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new Size(225, 33);
			this.vmethod_12().TabIndex = 10;
			this.vmethod_12().Text = "Delete selected save";
			this.vmethod_14().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_14().BackColor = Color.Transparent;
			this.vmethod_14().DialogResult = DialogResult.None;
			this.vmethod_14().Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.vmethod_14().ForeColor = SystemColors.Control;
			this.vmethod_14().Location = new Point(3, 521);
			this.vmethod_14().Name = "Button3";
			this.vmethod_14().method_1(0);
			this.vmethod_14().Size = new Size(223, 33);
			this.vmethod_14().TabIndex = 9;
			this.vmethod_14().Text = "Resume from selected save";
			this.vmethod_10().AllowUserToAddRows = false;
			this.vmethod_10().AllowUserToDeleteRows = false;
			this.vmethod_10().AllowUserToOrderColumns = true;
			this.vmethod_10().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_10().BackgroundColor = Color.FromArgb(43, 43, 43);
			this.vmethod_10().BorderStyle = BorderStyle.None;
			this.vmethod_10().CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.vmethod_10().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_10().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_10().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_24(),
				this.vmethod_26(),
				this.vmethod_28()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_10().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_10().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_10().EnableHeadersVisualStyles = false;
			this.vmethod_10().method_9(null);
			this.vmethod_10().Location = new Point(3, 3);
			this.vmethod_10().Name = "TGV_CampaignSaves";
			this.vmethod_10().RowHeadersVisible = false;
			this.vmethod_10().RowHeadersWidth = 20;
			this.vmethod_10().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_10().method_7(false);
			this.vmethod_10().Size = new Size(997, 500);
			this.vmethod_10().TabIndex = 8;
			this.vmethod_24().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_24().method_0(null);
			this.vmethod_24().HeaderText = "Name";
			this.vmethod_24().Name = "Column_Name";
			this.vmethod_24().ReadOnly = true;
			this.vmethod_24().Resizable = DataGridViewTriState.True;
			this.vmethod_24().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_26().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_26().method_0(null);
			this.vmethod_26().HeaderText = "Scenario Time";
			this.vmethod_26().Name = "Column_ScenTime";
			this.vmethod_26().ReadOnly = true;
			this.vmethod_26().Resizable = DataGridViewTriState.True;
			this.vmethod_26().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_26().Width = 82;
			this.vmethod_28().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_28().method_0(null);
			this.vmethod_28().HeaderText = "Save Actual Time";
			this.vmethod_28().Name = "Column_SaveTime";
			this.vmethod_28().ReadOnly = true;
			this.vmethod_28().Resizable = DataGridViewTriState.True;
			this.vmethod_28().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_28().Width = 96;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1014, 588);
			base.Controls.Add(this.vmethod_4());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CampaignPlayWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Campaigns";
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_6().ResumeLayout(false);
			this.vmethod_6().PerformLayout();
			this.vmethod_8().ResumeLayout(false);
			((ISupportInitialize)this.vmethod_10()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06007129 RID: 28969 RVA: 0x00047020 File Offset: 0x00045220
		[CompilerGenerated]
		internal WebBrowser vmethod_0()
		{
			return this.webBrowser_0;
		}

		// Token: 0x0600712A RID: 28970 RVA: 0x00047028 File Offset: 0x00045228
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(WebBrowser webBrowser_1)
		{
			this.webBrowser_0 = webBrowser_1;
		}

		// Token: 0x0600712B RID: 28971 RVA: 0x00047031 File Offset: 0x00045231
		[CompilerGenerated]
		internal Control9 vmethod_2()
		{
			return this.control9_0;
		}

		// Token: 0x0600712C RID: 28972 RVA: 0x003CEF50 File Offset: 0x003CD150
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

		// Token: 0x0600712D RID: 28973 RVA: 0x00047039 File Offset: 0x00045239
		[CompilerGenerated]
		internal Control12 vmethod_4()
		{
			return this.control12_0;
		}

		// Token: 0x0600712E RID: 28974 RVA: 0x00047041 File Offset: 0x00045241
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control12 control12_1)
		{
			this.control12_0 = control12_1;
		}

		// Token: 0x0600712F RID: 28975 RVA: 0x0004704A File Offset: 0x0004524A
		[CompilerGenerated]
		internal TabPage vmethod_6()
		{
			return this.tabPage_0;
		}

		// Token: 0x06007130 RID: 28976 RVA: 0x00047052 File Offset: 0x00045252
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TabPage tabPage_2)
		{
			this.tabPage_0 = tabPage_2;
		}

		// Token: 0x06007131 RID: 28977 RVA: 0x0004705B File Offset: 0x0004525B
		[CompilerGenerated]
		internal TabPage vmethod_8()
		{
			return this.tabPage_1;
		}

		// Token: 0x06007132 RID: 28978 RVA: 0x00047063 File Offset: 0x00045263
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TabPage tabPage_2)
		{
			this.tabPage_1 = tabPage_2;
		}

		// Token: 0x06007133 RID: 28979 RVA: 0x0004706C File Offset: 0x0004526C
		[CompilerGenerated]
		private Class50 vmethod_10()
		{
			return this.class50_0;
		}

		// Token: 0x06007134 RID: 28980 RVA: 0x003CEF94 File Offset: 0x003CD194
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_11(Class50 class50_1)
		{
			EventHandler value = new EventHandler(this.method_7);
			Class50 @class = this.class50_0;
			if (@class != null)
			{
				@class.SelectionChanged -= value;
			}
			this.class50_0 = class50_1;
			@class = this.class50_0;
			if (@class != null)
			{
				@class.SelectionChanged += value;
			}
		}

		// Token: 0x06007135 RID: 28981 RVA: 0x00047074 File Offset: 0x00045274
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_1;
		}

		// Token: 0x06007136 RID: 28982 RVA: 0x003CEFD8 File Offset: 0x003CD1D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_8);
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

		// Token: 0x06007137 RID: 28983 RVA: 0x0004707C File Offset: 0x0004527C
		[CompilerGenerated]
		internal Control9 vmethod_14()
		{
			return this.control9_2;
		}

		// Token: 0x06007138 RID: 28984 RVA: 0x003CF01C File Offset: 0x003CD21C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_6);
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

		// Token: 0x06007139 RID: 28985 RVA: 0x00047084 File Offset: 0x00045284
		[CompilerGenerated]
		internal FlowLayoutPanel vmethod_16()
		{
			return this.flowLayoutPanel_0;
		}

		// Token: 0x0600713A RID: 28986 RVA: 0x0004708C File Offset: 0x0004528C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(FlowLayoutPanel flowLayoutPanel_1)
		{
			this.flowLayoutPanel_0 = flowLayoutPanel_1;
		}

		// Token: 0x0600713B RID: 28987 RVA: 0x00047095 File Offset: 0x00045295
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_0;
		}

		// Token: 0x0600713C RID: 28988 RVA: 0x0004709D File Offset: 0x0004529D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x0600713D RID: 28989 RVA: 0x000470A6 File Offset: 0x000452A6
		[CompilerGenerated]
		internal Control9 vmethod_20()
		{
			return this.control9_3;
		}

		// Token: 0x0600713E RID: 28990 RVA: 0x003CF060 File Offset: 0x003CD260
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_13);
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

		// Token: 0x0600713F RID: 28991 RVA: 0x000470AE File Offset: 0x000452AE
		[CompilerGenerated]
		internal Control11 vmethod_22()
		{
			return this.control11_0;
		}

		// Token: 0x06007140 RID: 28992 RVA: 0x000470B6 File Offset: 0x000452B6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Control11 control11_1)
		{
			this.control11_0 = control11_1;
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x000470BF File Offset: 0x000452BF
		[CompilerGenerated]
		internal Class44 vmethod_24()
		{
			return this.class44_0;
		}

		// Token: 0x06007142 RID: 28994 RVA: 0x000470C7 File Offset: 0x000452C7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class44 class44_3)
		{
			this.class44_0 = class44_3;
		}

		// Token: 0x06007143 RID: 28995 RVA: 0x000470D0 File Offset: 0x000452D0
		[CompilerGenerated]
		internal Class44 vmethod_26()
		{
			return this.class44_1;
		}

		// Token: 0x06007144 RID: 28996 RVA: 0x000470D8 File Offset: 0x000452D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class44 class44_3)
		{
			this.class44_1 = class44_3;
		}

		// Token: 0x06007145 RID: 28997 RVA: 0x000470E1 File Offset: 0x000452E1
		[CompilerGenerated]
		internal Class44 vmethod_28()
		{
			return this.class44_2;
		}

		// Token: 0x06007146 RID: 28998 RVA: 0x000470E9 File Offset: 0x000452E9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Class44 class44_3)
		{
			this.class44_2 = class44_3;
		}

		// Token: 0x06007147 RID: 28999 RVA: 0x000470F2 File Offset: 0x000452F2
		[CompilerGenerated]
		private Button vmethod_30()
		{
			return this.button_0;
		}

		// Token: 0x06007148 RID: 29000 RVA: 0x000470FA File Offset: 0x000452FA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private void vmethod_31(Button button_1)
		{
			this.button_0 = button_1;
		}

		// Token: 0x06007149 RID: 29001 RVA: 0x003CF0A4 File Offset: 0x003CD2A4
		public CampaignPlayWindow()
		{
			base.FormClosed += this.CampaignPlayWindow_FormClosed;
			base.Load += this.CampaignPlayWindow_Load;
			base.Shown += this.CampaignPlayWindow_Shown;
			this.queue_0 = new Queue<Tuple<string, string, string, string>>();
			this.InitializeComponent_1();
			Class2558.ShowScrollBar(this.vmethod_16().Handle, 1, true);
		}

		// Token: 0x0600714A RID: 29002 RVA: 0x003CF114 File Offset: 0x003CD314
		private void method_3()
		{
			this.vmethod_16().Controls.Clear();
			List<string> list = new List<string>();
			Class264.smethod_3(GameGeneral.string_4, list);
			list = Enumerable.ToList<string>(Enumerable.OrderByDescending<string, DateTime>(list, (CampaignPlayWindow._Closure$__.$I70-0 == null) ? (CampaignPlayWindow._Closure$__.$I70-0 = new Func<string, DateTime>(CampaignPlayWindow._Closure$__.$I.method_0)) : CampaignPlayWindow._Closure$__.$I70-0));
			try
			{
				foreach (string text in list)
				{
					Class264.smethod_1(text);
					this.vmethod_31(new Button());
					this.vmethod_30().Height = 135;
					this.vmethod_30().Width = 280;
					if (File.Exists(Path.ChangeExtension(text, "png")))
					{
						this.vmethod_30().Image = Image.FromFile(Path.ChangeExtension(text, "png"));
					}
					else
					{
						this.vmethod_30().Image = Image.FromFile(Path.Combine(Class2413.smethod_1().Info.DirectoryPath, "Command.ico"));
					}
					this.vmethod_30().Tag = text;
					this.vmethod_16().Controls.Add(this.vmethod_30());
					this.vmethod_30().Click += this.method_9;
					this.vmethod_30().MouseEnter += this.method_11;
					this.vmethod_30().MouseLeave += this.method_12;
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x0600714B RID: 29003 RVA: 0x003CF2B0 File Offset: 0x003CD4B0
		private void CampaignPlayWindow_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				foreach (object obj in this.vmethod_16().Controls)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					this.vmethod_31((Button)objectValue);
					this.vmethod_30().Click -= this.method_9;
					this.vmethod_30().MouseEnter -= this.method_11;
					this.vmethod_30().MouseLeave -= this.method_12;
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
		}

		// Token: 0x0600714C RID: 29004 RVA: 0x003CF35C File Offset: 0x003CD55C
		private void method_4()
		{
			CampaignPlayWindow.Class2480 @class = new CampaignPlayWindow.Class2480(@class);
			@class.campaignPlayWindow_0 = this;
			this.vmethod_10().method_2().Clear();
			@class.list_0 = new List<string>();
			Class264.smethod_3(GameGeneral.string_4, @class.list_0);
			@class.int_1 = 0;
			try
			{
				foreach (string path in @class.list_0)
				{
					string directoryName = Path.GetDirectoryName(path);
					@class.int_1 += Enumerable.Count<string>(Directory.GetFiles(directoryName, "*-*-*-*-*.save"));
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.vmethod_22().Visible = true;
			@class.int_0 = 0;
			Application.DoEvents();
			Task.Factory.StartNew(new Action(@class.method_0));
		}

		// Token: 0x0600714D RID: 29005 RVA: 0x00047103 File Offset: 0x00045303
		private void CampaignPlayWindow_Load(object sender, EventArgs e)
		{
			this.vmethod_0().Visible = false;
			this.vmethod_16().VerticalScroll.Visible = true;
			this.method_3();
			this.vmethod_2().Visible = false;
			Application.DoEvents();
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x003CF43C File Offset: 0x003CD63C
		private void method_5(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.string_0))
			{
				string extension = Path.GetExtension(this.string_0);
				if (Operators.CompareString(extension, ".campaign", false) == 0)
				{
					Class264 @class = Class264.smethod_1(this.string_0);
					Class258.smethod_2(Path.GetDirectoryName(this.string_0));
					try
					{
						foreach (Class264.Class265 class2 in @class.list_0)
						{
							Type type = class2.GetType();
							if (type == typeof(Class264.Class266))
							{
								string text = Path.GetDirectoryName(this.string_0) + "\\" + ((Class264.Class266)class2).string_2;
								Class2413.smethod_2().method_11().class264_0 = @class;
								Class2413.smethod_2().method_11().string_0 = text;
								Class2413.smethod_2().method_11().string_1 = Guid.NewGuid().ToString();
								Class2413.smethod_2().method_11().int_0 = 0;
								Class2413.smethod_2().method_11().string_2 = "";
								Class2413.smethod_2().method_11().Show();
								base.Close();
								break;
							}
							if (type == typeof(Class264.Class267))
							{
								Class508.smethod_0(((Class264.Class267)class2).string_1, null);
							}
						}
					}
					finally
					{
						List<Class264.Class265>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x003CF5C4 File Offset: 0x003CD7C4
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_10().method_5() != null)
			{
				string extension = Path.GetExtension(this.string_0);
				if (Operators.CompareString(extension, ".save", false) == 0)
				{
					Client.smethod_0().method_2(Class279.Enum67.const_0);
					ScenContainer scenContainer = ScenContainer.smethod_2(this.string_0);
					if (scenContainer.IsCampaignCheckpoint)
					{
						string directoryName = Path.GetDirectoryName(this.string_0);
						string text = scenContainer.CampaignID;
						if (string.IsNullOrEmpty(text))
						{
							text = Scenario.smethod_22(this.string_0, "CampaignID");
						}
						string text2 = scenContainer.CampaignSessionID;
						if (string.IsNullOrEmpty(text2))
						{
							text2 = Scenario.smethod_22(this.string_0, "CampaignSessionID");
						}
						if (!string.IsNullOrEmpty(text))
						{
							Class264 @class = Class264.smethod_2(GameGeneral.string_4, text);
							if (@class != null)
							{
								string text3 = Scenario.smethod_22(this.string_0, "ObjectID");
								if (!string.IsNullOrEmpty(text3))
								{
									Class264.Class266 class2 = @class.method_2(text3);
									if (class2 != null)
									{
										this.string_0 = Path.Combine(directoryName, class2.string_2);
										Class2413.smethod_2().method_55().string_1 = text2;
									}
								}
							}
						}
					}
					Class2413.smethod_2().method_55().string_0 = this.string_0;
					Class2413.smethod_2().method_55().Show();
					if (Client.smethod_0().method_1() != Class279.Enum67.const_0)
					{
						Client.smethod_0().method_2(Class279.Enum67.const_0);
					}
					base.Close();
				}
			}
		}

		// Token: 0x06007150 RID: 29008 RVA: 0x003CF718 File Offset: 0x003CD918
		private void method_7(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.vmethod_10().method_5()))
			{
				this.vmethod_14().Enabled = false;
				return;
			}
			if (this.vmethod_10().method_5().Tag.GetType() == typeof(string) && !Conversions.ToString(this.vmethod_10().method_5().Tag).StartsWith("Session_"))
			{
				this.string_0 = Conversions.ToString(this.vmethod_10().method_5().Tag);
				this.vmethod_14().Enabled = true;
				return;
			}
			this.vmethod_14().Enabled = false;
		}

		// Token: 0x06007151 RID: 29009 RVA: 0x003CF7BC File Offset: 0x003CD9BC
		private void method_8(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.vmethod_10().method_5()))
			{
				string extension = Path.GetExtension(this.string_0);
				if (Operators.CompareString(extension, ".save", false) == 0)
				{
					File.Delete(this.string_0);
					this.vmethod_10().method_5().method_9().method_7().Remove(this.vmethod_10().method_5());
				}
			}
		}

		// Token: 0x06007152 RID: 29010 RVA: 0x003CF828 File Offset: 0x003CDA28
		private void method_9(object sender, EventArgs e)
		{
			this.vmethod_0().Visible = true;
			this.string_0 = Conversions.ToString(((Button)sender).Tag);
			string extension = Path.GetExtension(this.string_0);
			if (Operators.CompareString(extension, ".campaign", false) == 0)
			{
				this.vmethod_18().Visible = false;
				Class264 @class = Class264.smethod_1(this.string_0);
				string text = Scenario.smethod_23(ScenContainer.smethod_2(@class.method_3(this.string_0)).method_7(), "ContentTag");
				if (!Class2556.smethod_10(text))
				{
					Class2413.smethod_2().method_30().method_2(new List<Class2556.Enum209>
					{
						Class2556.smethod_12(text)
					});
					Class2413.smethod_2().method_30().Show();
					this.vmethod_0().Visible = false;
					this.vmethod_0().AllowNavigation = false;
					this.vmethod_2().Visible = false;
					return;
				}
				this.vmethod_0().Visible = true;
				this.vmethod_0().AllowNavigation = true;
				if (!this.method_10(this.vmethod_0(), @class.string_2, Path.GetDirectoryName(this.string_0)))
				{
					Class2558.smethod_11(this.vmethod_0(), @class.string_2);
				}
				this.vmethod_2().Visible = true;
			}
		}

		// Token: 0x06007153 RID: 29011 RVA: 0x003CBEE0 File Offset: 0x003CA0E0
		private bool method_10(WebBrowser webBrowser_1, string string_1, string string_2)
		{
			bool result;
			if (string_1.Contains("[LOADDOC]"))
			{
				int num = Strings.InStr(string_1, "[LOADDOC]", CompareMethod.Binary) + "[LOADDOC]".Length - 1;
				int num2 = Strings.InStr(string_1, "[/LOADDOC]", CompareMethod.Binary);
				string path = string_1.Substring(num, string_1.Length - num - (string_1.Length - num2 + 1));
				webBrowser_1.Navigate(Path.Combine(string_2, path));
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06007154 RID: 29012 RVA: 0x00047139 File Offset: 0x00045339
		private void method_11(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06007155 RID: 29013 RVA: 0x00047146 File Offset: 0x00045346
		private void method_12(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Arrow;
		}

		// Token: 0x06007156 RID: 29014 RVA: 0x00047153 File Offset: 0x00045353
		private void method_13(object sender, EventArgs e)
		{
			StartGameMenuWindow.smethod_1();
			base.Close();
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x00047160 File Offset: 0x00045360
		private void CampaignPlayWindow_Shown(object sender, EventArgs e)
		{
			Application.DoEvents();
			this.method_4();
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x0004716D File Offset: 0x0004536D
		[CompilerGenerated]
		private void method_14()
		{
			this.vmethod_22().Visible = false;
			Application.DoEvents();
		}

		// Token: 0x04003FD7 RID: 16343
		[CompilerGenerated]
		[AccessedThroughProperty("WebBrowser1")]
		private WebBrowser webBrowser_0;

		// Token: 0x04003FD8 RID: 16344
		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Control9 control9_0;

		// Token: 0x04003FD9 RID: 16345
		[CompilerGenerated]
		[AccessedThroughProperty("TabControl1")]
		private Control12 control12_0;

		// Token: 0x04003FDA RID: 16346
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage1")]
		private TabPage tabPage_0;

		// Token: 0x04003FDB RID: 16347
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage2")]
		private TabPage tabPage_1;

		// Token: 0x04003FDC RID: 16348
		[CompilerGenerated]
		[AccessedThroughProperty("TGV_CampaignSaves")]
		private Class50 class50_0;

		// Token: 0x04003FDD RID: 16349
		[AccessedThroughProperty("Button4")]
		[CompilerGenerated]
		private Control9 control9_1;

		// Token: 0x04003FDE RID: 16350
		[AccessedThroughProperty("Button3")]
		[CompilerGenerated]
		private Control9 control9_2;

		// Token: 0x04003FDF RID: 16351
		[CompilerGenerated]
		[AccessedThroughProperty("FlowLayoutPanel1")]
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x04003FE0 RID: 16352
		[CompilerGenerated]
		[AccessedThroughProperty("Label_SelectCampaign")]
		private Class116 class116_0;

		// Token: 0x04003FE1 RID: 16353
		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Control9 control9_3;

		// Token: 0x04003FE2 RID: 16354
		[AccessedThroughProperty("PB_CampaignSaves")]
		[CompilerGenerated]
		private Control11 control11_0;

		// Token: 0x04003FE3 RID: 16355
		[CompilerGenerated]
		[AccessedThroughProperty("Column_Name")]
		private Class44 class44_0;

		// Token: 0x04003FE4 RID: 16356
		[CompilerGenerated]
		[AccessedThroughProperty("Column_ScenTime")]
		private Class44 class44_1;

		// Token: 0x04003FE5 RID: 16357
		[CompilerGenerated]
		[AccessedThroughProperty("Column_SaveTime")]
		private Class44 class44_2;

		// Token: 0x04003FE6 RID: 16358
		private string string_0;

		// Token: 0x04003FE7 RID: 16359
		[CompilerGenerated]
		[AccessedThroughProperty("theButton")]
		private Button button_0;

		// Token: 0x04003FE8 RID: 16360
		private Queue<Tuple<string, string, string, string>> queue_0;

		// Token: 0x02000E70 RID: 3696
		[CompilerGenerated]
		internal sealed class Class2480
		{
			// Token: 0x0600715D RID: 29021 RVA: 0x000471A6 File Offset: 0x000453A6
			public Class2480(CampaignPlayWindow.Class2480 class2480_0)
			{
				if (class2480_0 != null)
				{
					this.list_0 = class2480_0.list_0;
					this.int_0 = class2480_0.int_0;
					this.int_1 = class2480_0.int_1;
				}
			}

			// Token: 0x0600715E RID: 29022 RVA: 0x003CF960 File Offset: 0x003CDB60
			internal void method_0()
			{
				try
				{
					foreach (string text in this.list_0)
					{
						CampaignPlayWindow.Class2481 @class = new CampaignPlayWindow.Class2481(@class);
						@class.class2480_0 = this;
						@class.class264_0 = Class264.smethod_1(text);
						string directoryName = Path.GetDirectoryName(text);
						@class.class48_0 = null;
						IEnumerable<string> enumerable = Enumerable.OrderBy<string, DateTime>(Directory.GetFiles(directoryName, "*-*-*-*-*.save"), (CampaignPlayWindow._Closure$__.$I72-1 == null) ? (CampaignPlayWindow._Closure$__.$I72-1 = new Func<string, DateTime>(CampaignPlayWindow._Closure$__.$I.method_1)) : CampaignPlayWindow._Closure$__.$I72-1);
						if (Enumerable.Count<string>(enumerable) > 0)
						{
							if (!this.campaignPlayWindow_0.Visible)
							{
								return;
							}
							this.campaignPlayWindow_0.vmethod_10().Invoke(new VB$AnonymousDelegate_0(@class.method_0));
							@class.class48_0.Tag = @class.class264_0;
							HashSet<string> hashSet = new HashSet<string>();
							try
							{
								IEnumerator<string> enumerator2 = enumerable.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									CampaignPlayWindow.Class2483 class2 = new CampaignPlayWindow.Class2483(class2);
									class2.class2481_0 = @class;
									class2.string_0 = enumerator2.Current;
									if (Operators.CompareString(Path.GetExtension(class2.string_0), ".save", false) == 0)
									{
										try
										{
											CampaignPlayWindow.Class2482 class3 = new CampaignPlayWindow.Class2482(class3);
											class3.class2483_0 = class2;
											ScenContainer scenContainer = ScenContainer.smethod_2(class3.class2483_0.string_0);
											string text2;
											string value;
											if (scenContainer.SaveCurrentTime != 0L)
											{
												text2 = scenContainer.CampaignID;
												class3.string_0 = scenContainer.CampaignSessionID;
												class3.string_1 = scenContainer.ScenTitle;
												value = Conversions.ToString(scenContainer.SaveCurrentTime);
											}
											else
											{
												List<string> list = new List<string>();
												list.Add("CampaignID");
												list.Add("CampaignSessionID");
												list.Add("Title");
												list.Add("Time");
												string[] array = Scenario.smethod_21(class3.class2483_0.string_0, list);
												text2 = array[0];
												class3.string_0 = array[1];
												class3.string_1 = array[2];
												value = array[3];
												scenContainer.CampaignID = text2;
												scenContainer.CampaignSessionID = class3.string_0;
												scenContainer.ScenTitle = class3.string_1;
												scenContainer.SaveCurrentTime = Conversions.ToLong(value);
												scenContainer.method_5(class3.class2483_0.string_0, true);
											}
											if (!string.IsNullOrEmpty(text2))
											{
												class3.class48_0 = null;
												if (hashSet.Contains(class3.string_0))
												{
													class3.class48_0 = Enumerable.ElementAtOrDefault<Class48>(Enumerable.Where<Class48>(Class2558.smethod_15(this.campaignPlayWindow_0.vmethod_10()), new Func<Class48, bool>(class3.method_0)), 0);
												}
												else
												{
													hashSet.Add(class3.string_0);
													if (!this.campaignPlayWindow_0.Visible)
													{
														return;
													}
													this.campaignPlayWindow_0.vmethod_10().Invoke(new VB$AnonymousDelegate_0(class3.method_1));
													class3.class48_0.Tag = "Session_" + class3.string_0;
												}
												class3.dateTime_0 = DateTime.FromBinary(Conversions.ToLong(value));
												if (scenContainer.IsCampaignCheckpoint)
												{
													class3.string_1 += " (Checkpoint)";
												}
												class3.dateTime_1 = File.GetLastWriteTime(class3.class2483_0.string_0);
												class3.class48_1 = null;
												if (!this.campaignPlayWindow_0.Visible)
												{
													return;
												}
												this.campaignPlayWindow_0.vmethod_10().Invoke(new VB$AnonymousDelegate_0(class3.method_2));
												class3.class48_1.Tag = class3.class2483_0.string_0;
											}
										}
										catch (Exception ex)
										{
											ex.Data.Add("Error at 200374", ex.Message);
											GameGeneral.smethod_25(ref ex);
											if (Debugger.IsAttached)
											{
												Debugger.Break();
											}
										}
									}
								}
							}
							finally
							{
								IEnumerator<string> enumerator2;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
								}
							}
							if (!this.campaignPlayWindow_0.Visible)
							{
								return;
							}
							this.campaignPlayWindow_0.vmethod_10().Invoke(new VB$AnonymousDelegate_0(@class.method_1));
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (this.campaignPlayWindow_0.Visible)
				{
					this.campaignPlayWindow_0.vmethod_10().Invoke(new VB$AnonymousDelegate_0(this.campaignPlayWindow_0.method_14));
				}
			}

			// Token: 0x04003FEC RID: 16364
			public List<string> list_0;

			// Token: 0x04003FED RID: 16365
			public int int_0;

			// Token: 0x04003FEE RID: 16366
			public int int_1;

			// Token: 0x04003FEF RID: 16367
			public CampaignPlayWindow campaignPlayWindow_0;
		}

		// Token: 0x02000E71 RID: 3697
		[CompilerGenerated]
		internal sealed class Class2481
		{
			// Token: 0x0600715F RID: 29023 RVA: 0x000471D5 File Offset: 0x000453D5
			public Class2481(CampaignPlayWindow.Class2481 class2481_0)
			{
				if (class2481_0 != null)
				{
					this.class48_0 = class2481_0.class48_0;
					this.class264_0 = class2481_0.class264_0;
				}
			}

			// Token: 0x06007160 RID: 29024 RVA: 0x000471F8 File Offset: 0x000453F8
			internal void method_0()
			{
				this.class48_0 = this.class2480_0.campaignPlayWindow_0.vmethod_10().method_2().method_0(this.class264_0.string_1);
				Application.DoEvents();
			}

			// Token: 0x06007161 RID: 29025 RVA: 0x0004722A File Offset: 0x0004542A
			internal void method_1()
			{
				this.class48_0.vmethod_4();
				Application.DoEvents();
			}

			// Token: 0x04003FF0 RID: 16368
			public Class48 class48_0;

			// Token: 0x04003FF1 RID: 16369
			public Class264 class264_0;

			// Token: 0x04003FF2 RID: 16370
			public CampaignPlayWindow.Class2480 class2480_0;
		}

		// Token: 0x02000E72 RID: 3698
		[CompilerGenerated]
		internal sealed class Class2482
		{
			// Token: 0x06007162 RID: 29026 RVA: 0x003CFE00 File Offset: 0x003CE000
			public Class2482(CampaignPlayWindow.Class2482 class2482_0)
			{
				if (class2482_0 != null)
				{
					this.string_0 = class2482_0.string_0;
					this.class48_0 = class2482_0.class48_0;
					this.class48_1 = class2482_0.class48_1;
					this.string_1 = class2482_0.string_1;
					this.dateTime_0 = class2482_0.dateTime_0;
					this.dateTime_1 = class2482_0.dateTime_1;
				}
			}

			// Token: 0x06007163 RID: 29027 RVA: 0x0004723D File Offset: 0x0004543D
			internal bool method_0(Class48 class48_2)
			{
				return class48_2.Tag.GetType() == typeof(string) && Operators.CompareString(Conversions.ToString(class48_2.Tag), "Session_" + this.string_0, false) == 0;
			}

			// Token: 0x06007164 RID: 29028 RVA: 0x003CFE60 File Offset: 0x003CE060
			internal void method_1()
			{
				this.class48_0 = this.class2483_0.class2481_0.class48_0.method_7().method_0("Session started at: " + new FileInfo(this.class2483_0.string_0).CreationTime.ToShortDateString() + " " + new FileInfo(this.class2483_0.string_0).CreationTime.ToShortTimeString());
				Application.DoEvents();
			}

			// Token: 0x06007165 RID: 29029 RVA: 0x003CFEDC File Offset: 0x003CE0DC
			internal void method_2()
			{
				this.class48_1 = this.class48_0.method_7().method_1(new object[]
				{
					this.string_1,
					this.dateTime_0,
					this.dateTime_1
				});
				this.class2483_0.class2481_0.class2480_0.int_0 = this.class2483_0.class2481_0.class2480_0.int_0 + 1;
				this.class2483_0.class2481_0.class2480_0.campaignPlayWindow_0.vmethod_22().Value = (int)Math.Round(100.0 * ((double)this.class2483_0.class2481_0.class2480_0.int_0 / (double)this.class2483_0.class2481_0.class2480_0.int_1));
				Application.DoEvents();
			}

			// Token: 0x04003FF3 RID: 16371
			public string string_0;

			// Token: 0x04003FF4 RID: 16372
			public Class48 class48_0;

			// Token: 0x04003FF5 RID: 16373
			public Class48 class48_1;

			// Token: 0x04003FF6 RID: 16374
			public string string_1;

			// Token: 0x04003FF7 RID: 16375
			public DateTime dateTime_0;

			// Token: 0x04003FF8 RID: 16376
			public DateTime dateTime_1;

			// Token: 0x04003FF9 RID: 16377
			public CampaignPlayWindow.Class2483 class2483_0;
		}

		// Token: 0x02000E73 RID: 3699
		[CompilerGenerated]
		internal sealed class Class2483
		{
			// Token: 0x06007166 RID: 29030 RVA: 0x0004727C File Offset: 0x0004547C
			public Class2483(CampaignPlayWindow.Class2483 class2483_0)
			{
				if (class2483_0 != null)
				{
					this.string_0 = class2483_0.string_0;
				}
			}

			// Token: 0x04003FFA RID: 16378
			public string string_0;

			// Token: 0x04003FFB RID: 16379
			public CampaignPlayWindow.Class2481 class2481_0;
		}
	}
}
