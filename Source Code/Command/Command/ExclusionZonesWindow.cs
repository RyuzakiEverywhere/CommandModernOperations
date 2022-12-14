using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using Command_Core;
using DarkUI.Collections;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns2;
using ns3;
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000EE6 RID: 3814
	[DesignerGenerated]
	public sealed partial class ExclusionZonesWindow : DarkSecondaryFormBase
	{
		// Token: 0x060085E0 RID: 34272 RVA: 0x0047D268 File Offset: 0x0047B468
		public ExclusionZonesWindow()
		{
			base.FormClosing += this.ExclusionZonesWindow_FormClosing;
			base.KeyDown += this.ExclusionZonesWindow_KeyDown;
			base.Shown += this.ExclusionZonesWindow_Shown;
			this.InitializeComponent_1();
		}

		// Token: 0x060085E2 RID: 34274 RVA: 0x0047D2F8 File Offset: 0x0047B4F8
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_41(new Class112());
			this.vmethod_29(new Control9());
			this.vmethod_31(new Control9());
			this.vmethod_27(new Class116());
			this.vmethod_25(new AreaEditor());
			this.vmethod_15(new Class112());
			this.vmethod_17(new Class112());
			this.vmethod_1(new Class114());
			this.vmethod_33(new DataGridViewTextBoxColumn());
			this.vmethod_35(new DataGridViewTextBoxColumn());
			this.vmethod_37(new DataGridViewTextBoxColumn());
			this.vmethod_39(new DataGridViewCheckBoxColumn());
			this.vmethod_19(new Class112());
			this.vmethod_9(new Class116());
			this.vmethod_21(new Class112());
			this.vmethod_23(new Class116());
			this.vmethod_5(new Class116());
			this.vmethod_13(new Control9());
			this.vmethod_3(new Class2451());
			this.vmethod_11(new Control9());
			this.vmethod_7(new Control8());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			this.vmethod_40().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_40().Location = new Point(297, 497);
			this.vmethod_40().Name = "CB_VisibleRP";
			this.vmethod_40().Size = new Size(141, 17);
			this.vmethod_40().TabIndex = 32;
			this.vmethod_40().Text = "Visible Reference Points";
			this.vmethod_28().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_28().BackColor = Color.Transparent;
			this.vmethod_28().DialogResult = DialogResult.None;
			this.vmethod_28().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_28().ForeColor = SystemColors.Control;
			this.vmethod_28().Location = new Point(573, 521);
			this.vmethod_28().Name = "ImportZone";
			this.vmethod_28().method_1(0);
			this.vmethod_28().Size = new Size(75, 23);
			this.vmethod_28().TabIndex = 31;
			this.vmethod_28().Text = "Import";
			this.vmethod_30().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_30().BackColor = Color.Transparent;
			this.vmethod_30().DialogResult = DialogResult.None;
			this.vmethod_30().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_30().ForeColor = SystemColors.Control;
			this.vmethod_30().Location = new Point(472, 521);
			this.vmethod_30().Name = "ExportZone";
			this.vmethod_30().method_1(0);
			this.vmethod_30().Size = new Size(75, 23);
			this.vmethod_30().TabIndex = 30;
			this.vmethod_30().Text = "Export";
			this.vmethod_26().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_26().Font = new Font("Segoe UI", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_26().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_26().Location = new Point(8, 379);
			this.vmethod_26().Name = "Label4";
			this.vmethod_26().Size = new Size(116, 18);
			this.vmethod_26().TabIndex = 13;
			this.vmethod_26().Text = "Selected Zone";
			this.vmethod_24().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_24().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_24().Location = new Point(297, 367);
			this.vmethod_24().Name = "AreaEditor1";
			this.vmethod_24().Size = new Size(351, 124);
			this.vmethod_24().TabIndex = 12;
			this.vmethod_24().method_1(null);
			this.vmethod_14().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().Location = new Point(99, 444);
			this.vmethod_14().Name = "CB_Facility";
			this.vmethod_14().Size = new Size(81, 19);
			this.vmethod_14().TabIndex = 11;
			this.vmethod_14().Text = "Land units";
			this.vmethod_16().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_16().AutoSize = true;
			this.vmethod_16().Location = new Point(16, 444);
			this.vmethod_16().Name = "CB_Submarine";
			this.vmethod_16().Size = new Size(88, 19);
			this.vmethod_16().TabIndex = 10;
			this.vmethod_16().Text = "Submarines";
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
				this.vmethod_32(),
				this.vmethod_34(),
				this.vmethod_36(),
				this.vmethod_38()
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
			this.vmethod_0().Location = new Point(-3, 1);
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
			this.vmethod_0().Size = new Size(662, 365);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_32().DataPropertyName = "ID";
			this.vmethod_32().HeaderText = "ID";
			this.vmethod_32().Name = "ID";
			this.vmethod_32().ReadOnly = true;
			this.vmethod_32().Visible = false;
			this.vmethod_34().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_34().DataPropertyName = "Description";
			this.vmethod_34().HeaderText = "Description";
			this.vmethod_34().Name = "Description";
			this.vmethod_34().ReadOnly = true;
			this.vmethod_36().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_36().DataPropertyName = "MarkViolatorAs";
			this.vmethod_36().HeaderText = "Violators are marked as:";
			this.vmethod_36().Name = "Points";
			this.vmethod_36().ReadOnly = true;
			this.vmethod_38().DataPropertyName = "IsActive";
			this.vmethod_38().HeaderText = "Active";
			this.vmethod_38().Name = "Active";
			this.vmethod_38().ReadOnly = true;
			this.vmethod_18().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_18().AutoSize = true;
			this.vmethod_18().Location = new Point(99, 421);
			this.vmethod_18().Name = "CB_Ship";
			this.vmethod_18().Size = new Size(54, 19);
			this.vmethod_18().TabIndex = 9;
			this.vmethod_18().Text = "Ships";
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(9, 477);
			this.vmethod_8().Name = "Label1";
			this.vmethod_8().Size = new Size(72, 17);
			this.vmethod_8().TabIndex = 0;
			this.vmethod_8().Text = "Description:";
			this.vmethod_20().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_20().AutoSize = true;
			this.vmethod_20().Location = new Point(16, 421);
			this.vmethod_20().Name = "CB_Aircraft";
			this.vmethod_20().Size = new Size(65, 19);
			this.vmethod_20().TabIndex = 8;
			this.vmethod_20().Text = "Aircraft";
			this.vmethod_22().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_22().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_22().Location = new Point(15, 408);
			this.vmethod_22().Name = "Label3";
			this.vmethod_22().Size = new Size(60, 13);
			this.vmethod_22().TabIndex = 7;
			this.vmethod_22().Text = "Applies To:";
			this.vmethod_4().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_4().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_4().Location = new Point(9, 505);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new Size(101, 16);
			this.vmethod_4().TabIndex = 3;
			this.vmethod_4().Text = "Mark violators as:";
			this.vmethod_12().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_12().BackColor = Color.Transparent;
			this.vmethod_12().DialogResult = DialogResult.None;
			this.vmethod_12().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_12().ForeColor = SystemColors.Control;
			this.vmethod_12().Location = new Point(297, 521);
			this.vmethod_12().Name = "Button_SetDescription";
			this.vmethod_12().method_1(0);
			this.vmethod_12().Size = new Size(47, 23);
			this.vmethod_12().TabIndex = 6;
			this.vmethod_12().Text = "Save";
			this.vmethod_2().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_2().BackColor = Color.Transparent;
			this.vmethod_2().DrawMode = DrawMode.OwnerDrawFixed;
			this.vmethod_2().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_2().Font = new Font("Segoe UI", 7f);
			this.vmethod_2().FormattingEnabled = true;
			this.vmethod_2().Items.AddRange(new object[]
			{
				"Unfriendly",
				"Hostile"
			});
			this.vmethod_2().Location = new Point(116, 500);
			this.vmethod_2().Name = "CB_MarkViolatorAs";
			this.vmethod_2().Size = new Size(167, 21);
			this.vmethod_2().TabIndex = 4;
			this.vmethod_10().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_10().BackColor = Color.Red;
			this.vmethod_10().DialogResult = DialogResult.None;
			this.vmethod_10().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_10().ForeColor = Color.Red;
			this.vmethod_10().Location = new Point(373, 521);
			this.vmethod_10().Name = "Button2";
			this.vmethod_10().method_1(0);
			this.vmethod_10().Size = new Size(75, 23);
			this.vmethod_10().TabIndex = 5;
			this.vmethod_10().Text = "Remove";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_6().method_14(null);
			this.vmethod_6().method_15(AutoCompleteMode.None);
			this.vmethod_6().method_13(AutoCompleteSource.None);
			this.vmethod_6().BackColor = Color.Transparent;
			this.vmethod_6().method_17(new Font("Segoe UI", 10f));
			this.vmethod_6().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_6().method_12(null);
			this.vmethod_6().method_18(null);
			this.vmethod_6().Location = new Point(116, 474);
			this.vmethod_6().method_2(32767);
			this.vmethod_6().method_7(false);
			this.vmethod_6().Name = "TB_Description";
			this.vmethod_6().method_3(false);
			this.vmethod_6().method_9(0);
			this.vmethod_6().Size = new Size(167, 20);
			this.vmethod_6().TabIndex = 1;
			this.vmethod_6().method_1(HorizontalAlignment.Left);
			this.vmethod_6().method_5(false);
			this.vmethod_6().method_10("");
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(655, 548);
			base.Controls.Add(this.vmethod_40());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_10());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ExclusionZonesWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Edit Exclusion Zones";
			((ISupportInitialize)this.vmethod_0()).EndInit();
		}

		// Token: 0x060085E3 RID: 34275 RVA: 0x00050D62 File Offset: 0x0004EF62
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x060085E4 RID: 34276 RVA: 0x0047E304 File Offset: 0x0047C504
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class114 class114_1)
		{
			EventHandler value = new EventHandler(this.method_9);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_18);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.SelectionChanged -= value;
				@class.CellClick -= value2;
			}
			this.class114_0 = class114_1;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.SelectionChanged += value;
				@class.CellClick += value2;
			}
		}

		// Token: 0x060085E5 RID: 34277 RVA: 0x00050D6A File Offset: 0x0004EF6A
		[CompilerGenerated]
		internal Class2451 vmethod_2()
		{
			return this.class2451_0;
		}

		// Token: 0x060085E6 RID: 34278 RVA: 0x0047E364 File Offset: 0x0047C564
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class2451 class2451_1)
		{
			EventHandler value = new EventHandler(this.method_6);
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

		// Token: 0x060085E7 RID: 34279 RVA: 0x00050D72 File Offset: 0x0004EF72
		[CompilerGenerated]
		internal Class116 vmethod_4()
		{
			return this.class116_0;
		}

		// Token: 0x060085E8 RID: 34280 RVA: 0x00050D7A File Offset: 0x0004EF7A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class116 class116_4)
		{
			this.class116_0 = class116_4;
		}

		// Token: 0x060085E9 RID: 34281 RVA: 0x00050D83 File Offset: 0x0004EF83
		[CompilerGenerated]
		internal Control8 vmethod_6()
		{
			return this.control8_0;
		}

		// Token: 0x060085EA RID: 34282 RVA: 0x00050D8B File Offset: 0x0004EF8B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control8 control8_1)
		{
			this.control8_0 = control8_1;
		}

		// Token: 0x060085EB RID: 34283 RVA: 0x00050D94 File Offset: 0x0004EF94
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_1;
		}

		// Token: 0x060085EC RID: 34284 RVA: 0x00050D9C File Offset: 0x0004EF9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_4)
		{
			this.class116_1 = class116_4;
		}

		// Token: 0x060085ED RID: 34285 RVA: 0x00050DA5 File Offset: 0x0004EFA5
		[CompilerGenerated]
		internal Control9 vmethod_10()
		{
			return this.control9_0;
		}

		// Token: 0x060085EE RID: 34286 RVA: 0x0047E3A8 File Offset: 0x0047C5A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_8);
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

		// Token: 0x060085EF RID: 34287 RVA: 0x00050DAD File Offset: 0x0004EFAD
		[CompilerGenerated]
		internal Control9 vmethod_12()
		{
			return this.control9_1;
		}

		// Token: 0x060085F0 RID: 34288 RVA: 0x0047E3EC File Offset: 0x0047C5EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_7);
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

		// Token: 0x060085F1 RID: 34289 RVA: 0x00050DB5 File Offset: 0x0004EFB5
		[CompilerGenerated]
		internal Class112 vmethod_14()
		{
			return this.class112_0;
		}

		// Token: 0x060085F2 RID: 34290 RVA: 0x0047E430 File Offset: 0x0047C630
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class112 class112_5)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_13);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.MouseClick -= value;
			}
			this.class112_0 = class112_5;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.MouseClick += value;
			}
		}

		// Token: 0x060085F3 RID: 34291 RVA: 0x00050DBD File Offset: 0x0004EFBD
		[CompilerGenerated]
		internal Class112 vmethod_16()
		{
			return this.class112_1;
		}

		// Token: 0x060085F4 RID: 34292 RVA: 0x0047E474 File Offset: 0x0047C674
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Class112 class112_5)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_12);
			Class112 @class = this.class112_1;
			if (@class != null)
			{
				@class.MouseClick -= value;
			}
			this.class112_1 = class112_5;
			@class = this.class112_1;
			if (@class != null)
			{
				@class.MouseClick += value;
			}
		}

		// Token: 0x060085F5 RID: 34293 RVA: 0x00050DC5 File Offset: 0x0004EFC5
		[CompilerGenerated]
		internal Class112 vmethod_18()
		{
			return this.class112_2;
		}

		// Token: 0x060085F6 RID: 34294 RVA: 0x0047E4B8 File Offset: 0x0047C6B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class112 class112_5)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_11);
			Class112 @class = this.class112_2;
			if (@class != null)
			{
				@class.MouseClick -= value;
			}
			this.class112_2 = class112_5;
			@class = this.class112_2;
			if (@class != null)
			{
				@class.MouseClick += value;
			}
		}

		// Token: 0x060085F7 RID: 34295 RVA: 0x00050DCD File Offset: 0x0004EFCD
		[CompilerGenerated]
		internal Class112 vmethod_20()
		{
			return this.class112_3;
		}

		// Token: 0x060085F8 RID: 34296 RVA: 0x0047E4FC File Offset: 0x0047C6FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Class112 class112_5)
		{
			EventHandler value = new EventHandler(this.method_10);
			Class112 @class = this.class112_3;
			if (@class != null)
			{
				@class.Enter -= value;
			}
			this.class112_3 = class112_5;
			@class = this.class112_3;
			if (@class != null)
			{
				@class.Enter += value;
			}
		}

		// Token: 0x060085F9 RID: 34297 RVA: 0x00050DD5 File Offset: 0x0004EFD5
		[CompilerGenerated]
		internal Class116 vmethod_22()
		{
			return this.class116_2;
		}

		// Token: 0x060085FA RID: 34298 RVA: 0x00050DDD File Offset: 0x0004EFDD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Class116 class116_4)
		{
			this.class116_2 = class116_4;
		}

		// Token: 0x060085FB RID: 34299 RVA: 0x00050DE6 File Offset: 0x0004EFE6
		[CompilerGenerated]
		internal AreaEditor vmethod_24()
		{
			return this.areaEditor_0;
		}

		// Token: 0x060085FC RID: 34300 RVA: 0x00050DEE File Offset: 0x0004EFEE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(AreaEditor areaEditor_1)
		{
			this.areaEditor_0 = areaEditor_1;
		}

		// Token: 0x060085FD RID: 34301 RVA: 0x00050DF7 File Offset: 0x0004EFF7
		[CompilerGenerated]
		internal Class116 vmethod_26()
		{
			return this.class116_3;
		}

		// Token: 0x060085FE RID: 34302 RVA: 0x00050DFF File Offset: 0x0004EFFF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Class116 class116_4)
		{
			this.class116_3 = class116_4;
		}

		// Token: 0x060085FF RID: 34303 RVA: 0x00050E08 File Offset: 0x0004F008
		[CompilerGenerated]
		internal Control9 vmethod_28()
		{
			return this.control9_2;
		}

		// Token: 0x06008600 RID: 34304 RVA: 0x0047E540 File Offset: 0x0047C740
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_16);
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

		// Token: 0x06008601 RID: 34305 RVA: 0x00050E10 File Offset: 0x0004F010
		[CompilerGenerated]
		internal Control9 vmethod_30()
		{
			return this.control9_3;
		}

		// Token: 0x06008602 RID: 34306 RVA: 0x0047E584 File Offset: 0x0047C784
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_15);
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

		// Token: 0x06008603 RID: 34307 RVA: 0x00050E18 File Offset: 0x0004F018
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_32()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06008604 RID: 34308 RVA: 0x00050E20 File Offset: 0x0004F020
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06008605 RID: 34309 RVA: 0x00050E29 File Offset: 0x0004F029
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_34()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06008606 RID: 34310 RVA: 0x00050E31 File Offset: 0x0004F031
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06008607 RID: 34311 RVA: 0x00050E3A File Offset: 0x0004F03A
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_36()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06008608 RID: 34312 RVA: 0x00050E42 File Offset: 0x0004F042
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06008609 RID: 34313 RVA: 0x00050E4B File Offset: 0x0004F04B
		[CompilerGenerated]
		internal DataGridViewCheckBoxColumn vmethod_38()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x0600860A RID: 34314 RVA: 0x00050E53 File Offset: 0x0004F053
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x0600860B RID: 34315 RVA: 0x00050E5C File Offset: 0x0004F05C
		[CompilerGenerated]
		internal Class112 vmethod_40()
		{
			return this.class112_4;
		}

		// Token: 0x0600860C RID: 34316 RVA: 0x0047E5C8 File Offset: 0x0047C7C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Class112 class112_5)
		{
			EventHandler value = new EventHandler(this.method_17);
			Class112 @class = this.class112_4;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_4 = class112_5;
			@class = this.class112_4;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x0600860D RID: 34317 RVA: 0x00050E64 File Offset: 0x0004F064
		[CompilerGenerated]
		internal OpenFileDialog vmethod_42()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x0600860E RID: 34318 RVA: 0x00050E6C File Offset: 0x0004F06C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x0600860F RID: 34319 RVA: 0x00050E75 File Offset: 0x0004F075
		[CompilerGenerated]
		internal SaveFileDialog vmethod_44()
		{
			return this.saveFileDialog_0;
		}

		// Token: 0x06008610 RID: 34320 RVA: 0x00050E7D File Offset: 0x0004F07D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(SaveFileDialog saveFileDialog_1)
		{
			this.saveFileDialog_0 = saveFileDialog_1;
		}

		// Token: 0x06008611 RID: 34321 RVA: 0x00050E86 File Offset: 0x0004F086
		public ExclusionZone method_3()
		{
			return this.exclusionZone_0;
		}

		// Token: 0x06008612 RID: 34322 RVA: 0x0047E60C File Offset: 0x0047C80C
		public void method_4(ExclusionZone exclusionZone_1)
		{
			this.exclusionZone_0 = exclusionZone_1;
			if (!Information.IsNothing(exclusionZone_1))
			{
				this.vmethod_6().Text = exclusionZone_1.string_2;
				Misc.PostureStance postureStance_ = exclusionZone_1.postureStance_0;
				if (postureStance_ != Misc.PostureStance.Unfriendly)
				{
					if (postureStance_ == Misc.PostureStance.Hostile)
					{
						this.vmethod_2().SelectedIndex = 1;
					}
				}
				else
				{
					this.vmethod_2().SelectedIndex = 0;
				}
				this.vmethod_20().Checked = this.exclusionZone_0.vmethod_4().Contains(GlobalVariables.ActiveUnitType.Aircraft);
				this.vmethod_18().Checked = this.exclusionZone_0.vmethod_4().Contains(GlobalVariables.ActiveUnitType.Ship);
				this.vmethod_16().Checked = this.exclusionZone_0.vmethod_4().Contains(GlobalVariables.ActiveUnitType.Submarine);
				this.vmethod_14().Checked = this.exclusionZone_0.vmethod_4().Contains(GlobalVariables.ActiveUnitType.Facility);
				this.vmethod_24().list_0 = this.exclusionZone_0.list_0;
				this.vmethod_24().method_1("Zone Area");
				this.vmethod_24().imethod_0();
			}
			bool flag = false;
			Side[] array = Client.smethod_46().method_44();
			int i = 0;
			checked
			{
				while (i < array.Length)
				{
					Side side = array[i];
					try
					{
						List<ExclusionZone>.Enumerator enumerator = side.list_6.GetEnumerator();
						while (enumerator.MoveNext())
						{
							if (enumerator.Current == this.method_3())
							{
								try
								{
									foreach (ReferencePoint item in this.method_3().list_0)
									{
										if (side.vmethod_12().Contains(item))
										{
											flag = true;
											break;
										}
									}
								}
								finally
								{
									List<ReferencePoint>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
								if (flag)
								{
									break;
								}
							}
						}
						goto IL_19C;
					}
					finally
					{
						List<ExclusionZone>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					IL_193:
					i++;
					continue;
					IL_19C:
					if (flag)
					{
						break;
					}
					goto IL_193;
				}
				this.vmethod_40().Checked = flag;
				Client.bool_1 = true;
			}
		}

		// Token: 0x06008613 RID: 34323 RVA: 0x00050E8E File Offset: 0x0004F08E
		private void ExclusionZonesWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.method_4(null);
			base.Hide();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x06008614 RID: 34324 RVA: 0x0047E7E8 File Offset: 0x0047C9E8
		private void method_5()
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("ID", typeof(string));
			dataTable.Columns.Add("Description", typeof(string));
			dataTable.Columns.Add("MarkViolatorAs", typeof(string));
			dataTable.Columns.Add("IsActive", typeof(bool));
			try
			{
				foreach (ExclusionZone exclusionZone in Client.smethod_50().list_6)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["ID"] = exclusionZone.string_0;
					dataRow["Description"] = exclusionZone.string_2;
					dataRow["MarkViolatorAs"] = exclusionZone.postureStance_0.ToString();
					dataRow["IsActive"] = exclusionZone.bool_11;
					dataTable.Rows.Add(dataRow);
				}
			}
			finally
			{
				List<ExclusionZone>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.vmethod_0().DataSource = dataTable;
		}

		// Token: 0x06008615 RID: 34325 RVA: 0x0047E920 File Offset: 0x0047CB20
		private void method_6(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.method_3()))
			{
				int selectedIndex = this.vmethod_2().SelectedIndex;
				if (selectedIndex != 0)
				{
					if (selectedIndex == 1)
					{
						this.method_3().postureStance_0 = Misc.PostureStance.Hostile;
					}
				}
				else
				{
					this.method_3().postureStance_0 = Misc.PostureStance.Unfriendly;
				}
				this.method_5();
			}
		}

		// Token: 0x06008616 RID: 34326 RVA: 0x00050EB3 File Offset: 0x0004F0B3
		private void method_7(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.method_3()))
			{
				this.method_3().string_2 = this.vmethod_6().Text;
				this.method_5();
			}
		}

		// Token: 0x06008617 RID: 34327 RVA: 0x00050EDE File Offset: 0x0004F0DE
		private void method_8(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.method_3()))
			{
				Client.smethod_50().list_6.Remove(this.method_3());
				this.method_4(null);
				this.method_5();
			}
		}

		// Token: 0x06008618 RID: 34328 RVA: 0x0047E970 File Offset: 0x0047CB70
		private void method_9(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				int num = this.vmethod_0().Rows.IndexOf(this.vmethod_0().SelectedRows[0]);
				if (num != -1)
				{
					this.method_4(Client.smethod_50().list_6[num]);
				}
			}
		}

		// Token: 0x06008619 RID: 34329 RVA: 0x00050F10 File Offset: 0x0004F110
		private void method_10(object sender, EventArgs e)
		{
			this.method_14();
		}

		// Token: 0x0600861A RID: 34330 RVA: 0x00050F10 File Offset: 0x0004F110
		private void method_11(object sender, EventArgs e)
		{
			this.method_14();
		}

		// Token: 0x0600861B RID: 34331 RVA: 0x00050F10 File Offset: 0x0004F110
		private void method_12(object sender, EventArgs e)
		{
			this.method_14();
		}

		// Token: 0x0600861C RID: 34332 RVA: 0x00050F10 File Offset: 0x0004F110
		private void method_13(object sender, EventArgs e)
		{
			this.method_14();
		}

		// Token: 0x0600861D RID: 34333 RVA: 0x0047E9CC File Offset: 0x0047CBCC
		private void method_14()
		{
			if (Information.IsNothing(this.method_3()))
			{
				if (Client.smethod_50().list_6.Count <= 0)
				{
					return;
				}
				this.method_4(Client.smethod_50().list_6[0]);
			}
			this.method_3().vmethod_4().Clear();
			if (this.vmethod_20().Checked)
			{
				this.method_3().vmethod_4().method_4(GlobalVariables.ActiveUnitType.Aircraft);
			}
			if (this.vmethod_18().Checked)
			{
				this.method_3().vmethod_4().method_4(GlobalVariables.ActiveUnitType.Ship);
			}
			if (this.vmethod_16().Checked)
			{
				this.method_3().vmethod_4().method_4(GlobalVariables.ActiveUnitType.Submarine);
			}
			if (this.vmethod_14().Checked)
			{
				this.method_3().vmethod_4().method_4(GlobalVariables.ActiveUnitType.Facility);
			}
		}

		// Token: 0x0600861E RID: 34334 RVA: 0x003B6260 File Offset: 0x003B4460
		private void ExclusionZonesWindow_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x0600861F RID: 34335 RVA: 0x0047EA9C File Offset: 0x0047CC9C
		private void method_15(object sender, EventArgs e)
		{
			this.vmethod_45(new SaveFileDialog());
			this.vmethod_44().InitialDirectory = GameGeneral.string_4;
			if (this.vmethod_44().ShowDialog() == DialogResult.OK)
			{
				try
				{
					FileStream fileStream = File.Create(this.vmethod_44().FileName);
					XmlWriterSettings settings = new XmlWriterSettings();
					MemoryStream memoryStream = new MemoryStream();
					using (XmlWriter xmlWriter = XmlWriter.Create(memoryStream, settings))
					{
						xmlWriter.WriteStartElement("ExclusionZone");
						xmlWriter.WriteElementString("Description", this.method_3().string_2);
						xmlWriter.WriteStartElement("Area");
						try
						{
							foreach (ReferencePoint referencePoint in this.method_3().list_0)
							{
								XmlWriter xmlWriter2 = xmlWriter;
								ReferencePoint referencePoint2 = referencePoint;
								HashSet<string> hashSet = null;
								xmlWriter2.WriteRaw(referencePoint2.method_17(ref hashSet));
								xmlWriter.Flush();
							}
						}
						finally
						{
							List<ReferencePoint>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						xmlWriter.WriteEndElement();
						xmlWriter.WriteElementString("AffectedUnitTypes", string.Join("_", Enumerable.Select<GlobalVariables.ActiveUnitType, string>(this.method_3().vmethod_4(), (ExclusionZonesWindow._Closure$__.$I112-0 == null) ? (ExclusionZonesWindow._Closure$__.$I112-0 = new Func<GlobalVariables.ActiveUnitType, string>(ExclusionZonesWindow._Closure$__.$I.method_0)) : ExclusionZonesWindow._Closure$__.$I112-0)));
						xmlWriter.WriteEndElement();
					}
					fileStream.Write(memoryStream.ToArray(), 0, (int)memoryStream.Position);
					fileStream.Close();
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101277", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				Client.bool_1 = true;
			}
		}

		// Token: 0x06008620 RID: 34336 RVA: 0x0047EC7C File Offset: 0x0047CE7C
		private void method_16(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.method_3()))
			{
				DarkMessageBox.smethod_2("Please select a No Navigation Zone.", "No zone selected", Enum11.const_0);
				return;
			}
			this.vmethod_43(new OpenFileDialog());
			this.vmethod_42().InitialDirectory = GameGeneral.string_4;
			if (this.vmethod_42().ShowDialog() == DialogResult.OK)
			{
				FileStream fileStream = new FileStream(this.vmethod_42().FileName, FileMode.Open, FileAccess.Read);
				XmlDocument xmlDocument = new XmlDocument();
				try
				{
					using (fileStream)
					{
						try
						{
							xmlDocument.Load(fileStream);
						}
						catch (Exception ex)
						{
							DarkMessageBox.smethod_2("File is improperly formatted, read failed!", "Error", Enum11.const_0);
						}
					}
					ExclusionZone exclusionZone = this.method_3();
					bool flag = true;
					XmlNode xmlNode = xmlDocument.SelectSingleNode("/ExclusionZone");
					if (Information.IsNothing(xmlNode))
					{
						xmlNode = xmlDocument.SelectSingleNode("/NoNavZone");
						flag = false;
					}
					if (xmlNode != null)
					{
						try
						{
							foreach (object obj in xmlNode.ChildNodes)
							{
								XmlNode xmlNode2 = (XmlNode)obj;
								string name = xmlNode2.Name;
								if (Operators.CompareString(name, "Description", false) != 0)
								{
									if (Operators.CompareString(name, "Area", false) != 0)
									{
										if (Operators.CompareString(name, "AffectedUnitTypes", false) == 0)
										{
											exclusionZone.vmethod_5(new ObservableList<GlobalVariables.ActiveUnitType>());
											foreach (string text in xmlNode2.InnerText.Split(new char[]
											{
												'_'
											}))
											{
												if (Versioned.IsNumeric(text))
												{
													int num = Conversions.ToInteger(text);
													exclusionZone.vmethod_4().method_4((GlobalVariables.ActiveUnitType)num);
												}
											}
											continue;
										}
										continue;
									}
									else
									{
										try
										{
											foreach (object obj2 in xmlNode2.ChildNodes)
											{
												XmlNode xmlNode3 = (XmlNode)obj2;
												Dictionary<string, Class310> dictionary = null;
												ReferencePoint referencePoint = ReferencePoint.smethod_13(ref xmlNode3, ref dictionary);
												if (!flag)
												{
													referencePoint.vmethod_1();
												}
												exclusionZone.list_0.Add(referencePoint);
											}
											continue;
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
								exclusionZone.string_2 = xmlNode2.InnerText;
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
						if (Information.IsNothing(exclusionZone.vmethod_4()))
						{
							Zone zone = exclusionZone;
							ObservableList<GlobalVariables.ActiveUnitType> observableList = new ObservableList<GlobalVariables.ActiveUnitType>();
							observableList.method_4(GlobalVariables.ActiveUnitType.Aircraft);
							observableList.method_4(GlobalVariables.ActiveUnitType.Ship);
							observableList.method_4(GlobalVariables.ActiveUnitType.Submarine);
							observableList.method_4(GlobalVariables.ActiveUnitType.Facility);
							zone.vmethod_5(observableList);
						}
						this.vmethod_24().imethod_0();
					}
					else
					{
						DarkMessageBox.smethod_2("No XML data found.", "Error", Enum11.const_0);
					}
					bool flag2 = false;
					foreach (Side side in Client.smethod_46().method_44())
					{
						try
						{
							List<ExclusionZone>.Enumerator enumerator3 = side.list_6.GetEnumerator();
							while (enumerator3.MoveNext())
							{
								if (enumerator3.Current == this.method_3())
								{
									try
									{
										foreach (ReferencePoint referencePoint2 in this.method_3().list_0)
										{
											if (!side.vmethod_12().Contains(referencePoint2))
											{
												side.vmethod_12().method_4(referencePoint2);
											}
										}
									}
									finally
									{
										List<ReferencePoint>.Enumerator enumerator4;
										((IDisposable)enumerator4).Dispose();
									}
									flag2 = true;
									break;
								}
							}
						}
						finally
						{
							List<ExclusionZone>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
						if (flag2)
						{
							break;
						}
					}
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 101276", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				Client.bool_1 = true;
			}
		}

		// Token: 0x06008621 RID: 34337 RVA: 0x0047F0B4 File Offset: 0x0047D2B4
		private void method_17(object sender, EventArgs e)
		{
			bool flag = false;
			flag = this.vmethod_40().Checked;
			bool flag2 = false;
			Side[] array = Client.smethod_46().method_44();
			int i = 0;
			checked
			{
				while (i < array.Length)
				{
					Side side = array[i];
					try
					{
						List<ExclusionZone>.Enumerator enumerator = side.list_6.GetEnumerator();
						while (enumerator.MoveNext())
						{
							if (enumerator.Current == this.method_3())
							{
								try
								{
									foreach (ReferencePoint referencePoint in this.method_3().list_0)
									{
										if (flag)
										{
											if (!side.vmethod_12().Contains(referencePoint))
											{
												side.vmethod_12().method_4(referencePoint);
											}
										}
										else if (side.vmethod_12().Contains(referencePoint))
										{
											side.vmethod_12().method_6(referencePoint);
										}
									}
								}
								finally
								{
									List<ReferencePoint>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
								flag2 = true;
								break;
							}
						}
						goto IL_EC;
					}
					finally
					{
						List<ExclusionZone>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					IL_E3:
					i++;
					continue;
					IL_EC:
					if (flag2)
					{
						break;
					}
					goto IL_E3;
				}
				Client.bool_1 = true;
			}
		}

		// Token: 0x06008622 RID: 34338 RVA: 0x0047F1D4 File Offset: 0x0047D3D4
		private void method_18(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1 && Operators.CompareString(this.vmethod_0().Columns[e.ColumnIndex].Name, "Active", false) == 0)
			{
				DataGridViewCheckBoxCell dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)this.vmethod_0()[e.ColumnIndex, e.RowIndex];
				ExclusionZone exclusionZone = null;
				string right = Conversions.ToString(this.vmethod_0().Rows[e.RowIndex].Cells["ID"].Value);
				try
				{
					foreach (ExclusionZone exclusionZone2 in Client.smethod_50().list_6)
					{
						if (Operators.CompareString(exclusionZone2.string_0, right, false) == 0)
						{
							exclusionZone = exclusionZone2;
							break;
						}
					}
				}
				finally
				{
					List<ExclusionZone>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (!Information.IsNothing(exclusionZone))
				{
					if (exclusionZone.bool_11)
					{
						dataGridViewCheckBoxCell.Value = false;
						exclusionZone.bool_11 = false;
					}
					else
					{
						dataGridViewCheckBoxCell.Value = true;
						exclusionZone.bool_11 = true;
					}
					Client.bool_1 = true;
					this.method_5();
				}
			}
		}

		// Token: 0x06008623 RID: 34339 RVA: 0x00050F18 File Offset: 0x0004F118
		private void ExclusionZonesWindow_Shown(object sender, EventArgs e)
		{
			this.method_5();
			if (Client.smethod_50().list_6.Count > 0 && Information.IsNothing(this.method_3()))
			{
				this.method_4(Client.smethod_50().list_6[0]);
			}
		}

		// Token: 0x04004918 RID: 18712
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridView1")]
		private Class114 class114_0;

		// Token: 0x04004919 RID: 18713
		[AccessedThroughProperty("CB_MarkViolatorAs")]
		[CompilerGenerated]
		private Class2451 class2451_0;

		// Token: 0x0400491A RID: 18714
		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Class116 class116_0;

		// Token: 0x0400491B RID: 18715
		[AccessedThroughProperty("TB_Description")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x0400491C RID: 18716
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x0400491D RID: 18717
		[AccessedThroughProperty("Button2")]
		[CompilerGenerated]
		private Control9 control9_0;

		// Token: 0x0400491E RID: 18718
		[AccessedThroughProperty("Button_SetDescription")]
		[CompilerGenerated]
		private Control9 control9_1;

		// Token: 0x0400491F RID: 18719
		[AccessedThroughProperty("CB_Facility")]
		[CompilerGenerated]
		private Class112 class112_0;

		// Token: 0x04004920 RID: 18720
		[AccessedThroughProperty("CB_Submarine")]
		[CompilerGenerated]
		private Class112 class112_1;

		// Token: 0x04004921 RID: 18721
		[AccessedThroughProperty("CB_Ship")]
		[CompilerGenerated]
		private Class112 class112_2;

		// Token: 0x04004922 RID: 18722
		[AccessedThroughProperty("CB_Aircraft")]
		[CompilerGenerated]
		private Class112 class112_3;

		// Token: 0x04004923 RID: 18723
		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		private Class116 class116_2;

		// Token: 0x04004924 RID: 18724
		[AccessedThroughProperty("AreaEditor1")]
		[CompilerGenerated]
		private AreaEditor areaEditor_0;

		// Token: 0x04004925 RID: 18725
		[CompilerGenerated]
		[AccessedThroughProperty("Label4")]
		private Class116 class116_3;

		// Token: 0x04004926 RID: 18726
		[CompilerGenerated]
		[AccessedThroughProperty("ImportZone")]
		private Control9 control9_2;

		// Token: 0x04004927 RID: 18727
		[CompilerGenerated]
		[AccessedThroughProperty("ExportZone")]
		private Control9 control9_3;

		// Token: 0x04004928 RID: 18728
		[CompilerGenerated]
		[AccessedThroughProperty("ID")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04004929 RID: 18729
		[AccessedThroughProperty("Description")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x0400492A RID: 18730
		[CompilerGenerated]
		[AccessedThroughProperty("Points")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x0400492B RID: 18731
		[AccessedThroughProperty("Active")]
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x0400492C RID: 18732
		[AccessedThroughProperty("CB_VisibleRP")]
		[CompilerGenerated]
		private Class112 class112_4;

		// Token: 0x0400492D RID: 18733
		private ExclusionZone exclusionZone_0;

		// Token: 0x0400492E RID: 18734
		[CompilerGenerated]
		[AccessedThroughProperty("FD_LoadExclusionZone")]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x0400492F RID: 18735
		[CompilerGenerated]
		[AccessedThroughProperty("FD_ExportExclusionZone")]
		private SaveFileDialog saveFileDialog_0;
	}
}
