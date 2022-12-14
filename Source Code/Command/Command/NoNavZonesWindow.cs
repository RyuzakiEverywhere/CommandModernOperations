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
	// Token: 0x02000EEA RID: 3818
	[DesignerGenerated]
	public sealed partial class NoNavZonesWindow : DarkSecondaryFormBase
	{
		// Token: 0x0600863E RID: 34366 RVA: 0x0047FDA0 File Offset: 0x0047DFA0
		public NoNavZonesWindow()
		{
			base.FormClosing += this.NoNavZonesWindow_FormClosing;
			base.Load += this.NoNavZonesWindow_Load;
			base.KeyDown += this.NoNavZonesWindow_KeyDown;
			this.InitializeComponent_1();
		}

		// Token: 0x06008640 RID: 34368 RVA: 0x0047FE30 File Offset: 0x0047E030
		private void InitializeComponent_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.vmethod_1(new Class114());
			this.vmethod_31(new DataGridViewTextBoxColumn());
			this.vmethod_33(new DataGridViewTextBoxColumn());
			this.vmethod_35(new DataGridViewCheckBoxColumn());
			this.vmethod_3(new Class116());
			this.vmethod_7(new Class112());
			this.vmethod_9(new Class112());
			this.vmethod_11(new Class112());
			this.vmethod_13(new Class116());
			this.vmethod_15(new Class112());
			this.vmethod_17(new Control8());
			this.vmethod_19(new Class116());
			this.vmethod_21(new Control9());
			this.vmethod_23(new Control9());
			this.vmethod_25(new Class112());
			this.vmethod_5(new AreaEditor());
			this.vmethod_27(new Control9());
			this.vmethod_29(new Control9());
			this.vmethod_37(new Class112());
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
				this.vmethod_30(),
				this.vmethod_32(),
				this.vmethod_34()
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
			this.vmethod_0().Location = new Point(0, -1);
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
			this.vmethod_0().Size = new Size(654, 373);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_30().DataPropertyName = "ID";
			this.vmethod_30().HeaderText = "ID";
			this.vmethod_30().Name = "ID";
			this.vmethod_30().ReadOnly = true;
			this.vmethod_30().Visible = false;
			this.vmethod_32().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_32().DataPropertyName = "Description";
			this.vmethod_32().HeaderText = "Description";
			this.vmethod_32().Name = "Description";
			this.vmethod_32().ReadOnly = true;
			this.vmethod_34().DataPropertyName = "IsActive";
			this.vmethod_34().HeaderText = "Active";
			this.vmethod_34().Name = "Active";
			this.vmethod_34().ReadOnly = true;
			this.vmethod_2().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_2().method_2(true);
			this.vmethod_2().Font = new Font("Segoe UI", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_2().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_2().Location = new Point(6, 385);
			this.vmethod_2().Name = "Label4";
			this.vmethod_2().Size = new Size(106, 20);
			this.vmethod_2().TabIndex = 26;
			this.vmethod_2().Text = "Selected Zone";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_6().AutoSize = true;
			this.vmethod_6().Location = new Point(97, 450);
			this.vmethod_6().Name = "CB_Facility";
			this.vmethod_6().Size = new Size(81, 19);
			this.vmethod_6().TabIndex = 24;
			this.vmethod_6().Text = "Land units";
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_8().AutoSize = true;
			this.vmethod_8().Location = new Point(14, 450);
			this.vmethod_8().Name = "CB_Submarine";
			this.vmethod_8().Size = new Size(88, 19);
			this.vmethod_8().TabIndex = 23;
			this.vmethod_8().Text = "Submarines";
			this.vmethod_10().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Location = new Point(97, 427);
			this.vmethod_10().Name = "CB_Ship";
			this.vmethod_10().Size = new Size(54, 19);
			this.vmethod_10().TabIndex = 22;
			this.vmethod_10().Text = "Ships";
			this.vmethod_12().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_12().method_2(true);
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Location = new Point(11, 510);
			this.vmethod_12().Name = "Label1";
			this.vmethod_12().Size = new Size(70, 15);
			this.vmethod_12().TabIndex = 14;
			this.vmethod_12().Text = "Description:";
			this.vmethod_14().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().Location = new Point(14, 427);
			this.vmethod_14().Name = "CB_Aircraft";
			this.vmethod_14().Size = new Size(65, 19);
			this.vmethod_14().TabIndex = 21;
			this.vmethod_14().Text = "Aircraft";
			this.vmethod_16().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_16().method_14(null);
			this.vmethod_16().method_15(AutoCompleteMode.None);
			this.vmethod_16().method_13(AutoCompleteSource.None);
			this.vmethod_16().BackColor = Color.Transparent;
			this.vmethod_16().method_17(new Font("Segoe UI", 10f));
			this.vmethod_16().ForeColor = Color.FromArgb(189, 189, 189);
			this.vmethod_16().method_12(null);
			this.vmethod_16().method_18(null);
			this.vmethod_16().Location = new Point(80, 507);
			this.vmethod_16().method_2(32767);
			this.vmethod_16().method_7(false);
			this.vmethod_16().Name = "TB_Description";
			this.vmethod_16().method_3(false);
			this.vmethod_16().method_9(0);
			this.vmethod_16().Size = new Size(205, 20);
			this.vmethod_16().TabIndex = 15;
			this.vmethod_16().method_1(HorizontalAlignment.Left);
			this.vmethod_16().method_5(false);
			this.vmethod_16().method_10("");
			this.vmethod_18().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_18().method_2(true);
			this.vmethod_18().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_18().Location = new Point(13, 414);
			this.vmethod_18().Name = "Label3";
			this.vmethod_18().Size = new Size(65, 15);
			this.vmethod_18().TabIndex = 20;
			this.vmethod_18().Text = "Applies To:";
			this.vmethod_20().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_20().BackColor = Color.Transparent;
			this.vmethod_20().DialogResult = DialogResult.None;
			this.vmethod_20().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_20().ForeColor = SystemColors.Control;
			this.vmethod_20().Location = new Point(295, 523);
			this.vmethod_20().Name = "Button_SetDescription";
			this.vmethod_20().method_1(0);
			this.vmethod_20().Size = new Size(49, 24);
			this.vmethod_20().TabIndex = 19;
			this.vmethod_20().Text = "Save";
			this.vmethod_22().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_22().BackColor = Color.Red;
			this.vmethod_22().DialogResult = DialogResult.None;
			this.vmethod_22().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_22().ForeColor = Color.Red;
			this.vmethod_22().Location = new Point(369, 523);
			this.vmethod_22().Name = "Button2";
			this.vmethod_22().method_1(0);
			this.vmethod_22().Size = new Size(75, 23);
			this.vmethod_22().TabIndex = 18;
			this.vmethod_22().Text = "Remove";
			this.vmethod_24().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_24().Location = new Point(14, 482);
			this.vmethod_24().Name = "CB_IsLocked";
			this.vmethod_24().Size = new Size(250, 17);
			this.vmethod_24().TabIndex = 27;
			this.vmethod_24().Text = "Zone is locked (non player-editable)";
			this.vmethod_4().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_4().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_4().Location = new Point(303, 373);
			this.vmethod_4().Name = "AreaEditor1";
			this.vmethod_4().Size = new Size(351, 124);
			this.vmethod_4().TabIndex = 25;
			this.vmethod_4().method_1(null);
			this.vmethod_26().BackColor = Color.Transparent;
			this.vmethod_26().DialogResult = DialogResult.None;
			this.vmethod_26().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_26().ForeColor = SystemColors.Control;
			this.vmethod_26().Location = new Point(467, 523);
			this.vmethod_26().Name = "ExportZone";
			this.vmethod_26().method_1(0);
			this.vmethod_26().Size = new Size(75, 23);
			this.vmethod_26().TabIndex = 28;
			this.vmethod_26().Text = "Export";
			this.vmethod_28().BackColor = Color.Transparent;
			this.vmethod_28().DialogResult = DialogResult.None;
			this.vmethod_28().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_28().ForeColor = SystemColors.Control;
			this.vmethod_28().Location = new Point(571, 524);
			this.vmethod_28().Name = "ImportZone";
			this.vmethod_28().method_1(0);
			this.vmethod_28().Size = new Size(75, 22);
			this.vmethod_28().TabIndex = 29;
			this.vmethod_28().Text = "Import";
			this.vmethod_36().AutoSize = true;
			this.vmethod_36().Location = new Point(295, 503);
			this.vmethod_36().Name = "CB_VisibleRP";
			this.vmethod_36().Size = new Size(151, 19);
			this.vmethod_36().TabIndex = 30;
			this.vmethod_36().Text = "Visible Reference Points";
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(655, 552);
			base.Controls.Add(this.vmethod_36());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "NoNavZonesWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Edit No-Navigation Zones";
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06008641 RID: 34369 RVA: 0x00051027 File Offset: 0x0004F227
		[CompilerGenerated]
		internal Class114 vmethod_0()
		{
			return this.class114_0;
		}

		// Token: 0x06008642 RID: 34370 RVA: 0x00480D00 File Offset: 0x0047EF00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class114 class114_1)
		{
			EventHandler value = new EventHandler(this.method_9);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_19);
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

		// Token: 0x06008643 RID: 34371 RVA: 0x0005102F File Offset: 0x0004F22F
		[CompilerGenerated]
		internal Class116 vmethod_2()
		{
			return this.class116_0;
		}

		// Token: 0x06008644 RID: 34372 RVA: 0x00051037 File Offset: 0x0004F237
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class116 class116_3)
		{
			this.class116_0 = class116_3;
		}

		// Token: 0x06008645 RID: 34373 RVA: 0x00051040 File Offset: 0x0004F240
		[CompilerGenerated]
		internal AreaEditor vmethod_4()
		{
			return this.areaEditor_0;
		}

		// Token: 0x06008646 RID: 34374 RVA: 0x00051048 File Offset: 0x0004F248
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(AreaEditor areaEditor_1)
		{
			this.areaEditor_0 = areaEditor_1;
		}

		// Token: 0x06008647 RID: 34375 RVA: 0x00051051 File Offset: 0x0004F251
		[CompilerGenerated]
		internal Class112 vmethod_6()
		{
			return this.class112_0;
		}

		// Token: 0x06008648 RID: 34376 RVA: 0x00480D60 File Offset: 0x0047EF60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class112 class112_6)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_13);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.MouseClick -= value;
			}
			this.class112_0 = class112_6;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.MouseClick += value;
			}
		}

		// Token: 0x06008649 RID: 34377 RVA: 0x00051059 File Offset: 0x0004F259
		[CompilerGenerated]
		internal Class112 vmethod_8()
		{
			return this.class112_1;
		}

		// Token: 0x0600864A RID: 34378 RVA: 0x00480DA4 File Offset: 0x0047EFA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class112 class112_6)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_15);
			Class112 @class = this.class112_1;
			if (@class != null)
			{
				@class.MouseClick -= value;
			}
			this.class112_1 = class112_6;
			@class = this.class112_1;
			if (@class != null)
			{
				@class.MouseClick += value;
			}
		}

		// Token: 0x0600864B RID: 34379 RVA: 0x00051061 File Offset: 0x0004F261
		[CompilerGenerated]
		internal Class112 vmethod_10()
		{
			return this.class112_2;
		}

		// Token: 0x0600864C RID: 34380 RVA: 0x00480DE8 File Offset: 0x0047EFE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class112 class112_6)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_14);
			Class112 @class = this.class112_2;
			if (@class != null)
			{
				@class.MouseClick -= value;
			}
			this.class112_2 = class112_6;
			@class = this.class112_2;
			if (@class != null)
			{
				@class.MouseClick += value;
			}
		}

		// Token: 0x0600864D RID: 34381 RVA: 0x00051069 File Offset: 0x0004F269
		[CompilerGenerated]
		internal Class116 vmethod_12()
		{
			return this.class116_1;
		}

		// Token: 0x0600864E RID: 34382 RVA: 0x00051071 File Offset: 0x0004F271
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Class116 class116_3)
		{
			this.class116_1 = class116_3;
		}

		// Token: 0x0600864F RID: 34383 RVA: 0x0005107A File Offset: 0x0004F27A
		[CompilerGenerated]
		internal Class112 vmethod_14()
		{
			return this.class112_3;
		}

		// Token: 0x06008650 RID: 34384 RVA: 0x00480E2C File Offset: 0x0047F02C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Class112 class112_6)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_12);
			Class112 @class = this.class112_3;
			if (@class != null)
			{
				@class.MouseClick -= value;
			}
			this.class112_3 = class112_6;
			@class = this.class112_3;
			if (@class != null)
			{
				@class.MouseClick += value;
			}
		}

		// Token: 0x06008651 RID: 34385 RVA: 0x00051082 File Offset: 0x0004F282
		[CompilerGenerated]
		internal Control8 vmethod_16()
		{
			return this.control8_0;
		}

		// Token: 0x06008652 RID: 34386 RVA: 0x0005108A File Offset: 0x0004F28A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Control8 control8_1)
		{
			this.control8_0 = control8_1;
		}

		// Token: 0x06008653 RID: 34387 RVA: 0x00051093 File Offset: 0x0004F293
		[CompilerGenerated]
		internal Class116 vmethod_18()
		{
			return this.class116_2;
		}

		// Token: 0x06008654 RID: 34388 RVA: 0x0005109B File Offset: 0x0004F29B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class116 class116_3)
		{
			this.class116_2 = class116_3;
		}

		// Token: 0x06008655 RID: 34389 RVA: 0x000510A4 File Offset: 0x0004F2A4
		[CompilerGenerated]
		internal Control9 vmethod_20()
		{
			return this.control9_0;
		}

		// Token: 0x06008656 RID: 34390 RVA: 0x00480E70 File Offset: 0x0047F070
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_7);
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

		// Token: 0x06008657 RID: 34391 RVA: 0x000510AC File Offset: 0x0004F2AC
		[CompilerGenerated]
		internal Control9 vmethod_22()
		{
			return this.control9_1;
		}

		// Token: 0x06008658 RID: 34392 RVA: 0x00480EB4 File Offset: 0x0047F0B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Control9 control9_4)
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

		// Token: 0x06008659 RID: 34393 RVA: 0x000510B4 File Offset: 0x0004F2B4
		[CompilerGenerated]
		internal Class112 vmethod_24()
		{
			return this.class112_4;
		}

		// Token: 0x0600865A RID: 34394 RVA: 0x00480EF8 File Offset: 0x0047F0F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Class112 class112_6)
		{
			EventHandler value = new EventHandler(this.method_11);
			Class112 @class = this.class112_4;
			if (@class != null)
			{
				@class.CheckedChanged -= value;
			}
			this.class112_4 = class112_6;
			@class = this.class112_4;
			if (@class != null)
			{
				@class.CheckedChanged += value;
			}
		}

		// Token: 0x0600865B RID: 34395 RVA: 0x000510BC File Offset: 0x0004F2BC
		[CompilerGenerated]
		internal Control9 vmethod_26()
		{
			return this.control9_2;
		}

		// Token: 0x0600865C RID: 34396 RVA: 0x00480F3C File Offset: 0x0047F13C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Control9 control9_4)
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

		// Token: 0x0600865D RID: 34397 RVA: 0x000510C4 File Offset: 0x0004F2C4
		[CompilerGenerated]
		internal Control9 vmethod_28()
		{
			return this.control9_3;
		}

		// Token: 0x0600865E RID: 34398 RVA: 0x00480F80 File Offset: 0x0047F180
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Control9 control9_4)
		{
			EventHandler value = new EventHandler(this.method_17);
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

		// Token: 0x0600865F RID: 34399 RVA: 0x000510CC File Offset: 0x0004F2CC
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_30()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06008660 RID: 34400 RVA: 0x000510D4 File Offset: 0x0004F2D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06008661 RID: 34401 RVA: 0x000510DD File Offset: 0x0004F2DD
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_32()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06008662 RID: 34402 RVA: 0x000510E5 File Offset: 0x0004F2E5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06008663 RID: 34403 RVA: 0x000510EE File Offset: 0x0004F2EE
		[CompilerGenerated]
		internal DataGridViewCheckBoxColumn vmethod_34()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x06008664 RID: 34404 RVA: 0x000510F6 File Offset: 0x0004F2F6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x06008665 RID: 34405 RVA: 0x000510FF File Offset: 0x0004F2FF
		[CompilerGenerated]
		internal Class112 vmethod_36()
		{
			return this.class112_5;
		}

		// Token: 0x06008666 RID: 34406 RVA: 0x00480FC4 File Offset: 0x0047F1C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Class112 class112_6)
		{
			EventHandler value = new EventHandler(this.method_18);
			Class112 @class = this.class112_5;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_5 = class112_6;
			@class = this.class112_5;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008667 RID: 34407 RVA: 0x00051107 File Offset: 0x0004F307
		[CompilerGenerated]
		internal OpenFileDialog vmethod_38()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x06008668 RID: 34408 RVA: 0x0005110F File Offset: 0x0004F30F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x06008669 RID: 34409 RVA: 0x00051118 File Offset: 0x0004F318
		[CompilerGenerated]
		internal SaveFileDialog vmethod_40()
		{
			return this.saveFileDialog_0;
		}

		// Token: 0x0600866A RID: 34410 RVA: 0x00051120 File Offset: 0x0004F320
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(SaveFileDialog saveFileDialog_1)
		{
			this.saveFileDialog_0 = saveFileDialog_1;
		}

		// Token: 0x0600866B RID: 34411 RVA: 0x00051129 File Offset: 0x0004F329
		public NoNavZone method_3()
		{
			return this.noNavZone_0;
		}

		// Token: 0x0600866C RID: 34412 RVA: 0x00481008 File Offset: 0x0047F208
		public void method_4(NoNavZone noNavZone_1)
		{
			this.noNavZone_0 = noNavZone_1;
			if (!Information.IsNothing(noNavZone_1))
			{
				this.vmethod_16().Text = noNavZone_1.string_2;
				this.vmethod_14().Checked = this.noNavZone_0.vmethod_4().Contains(GlobalVariables.ActiveUnitType.Aircraft);
				this.vmethod_10().Checked = this.noNavZone_0.vmethod_4().Contains(GlobalVariables.ActiveUnitType.Ship);
				this.vmethod_8().Checked = this.noNavZone_0.vmethod_4().Contains(GlobalVariables.ActiveUnitType.Submarine);
				this.vmethod_6().Checked = this.noNavZone_0.vmethod_4().Contains(GlobalVariables.ActiveUnitType.Facility);
				this.vmethod_24().Checked = this.noNavZone_0.bool_12;
				this.vmethod_4().list_0 = this.noNavZone_0.list_0;
				this.vmethod_4().method_1("Zone Area");
				this.vmethod_4().imethod_0();
				this.method_5();
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
						List<NoNavZone>.Enumerator enumerator = side.list_7.GetEnumerator();
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
						goto IL_18A;
					}
					finally
					{
						List<NoNavZone>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					IL_181:
					i++;
					continue;
					IL_18A:
					if (flag)
					{
						break;
					}
					goto IL_181;
				}
				this.vmethod_36().Checked = flag;
				Client.bool_1 = true;
			}
		}

		// Token: 0x0600866D RID: 34413 RVA: 0x00051131 File Offset: 0x0004F331
		private void NoNavZonesWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.method_4(null);
			base.Hide();
			Class2413.smethod_2().method_41().BringToFront();
		}

		// Token: 0x0600866E RID: 34414 RVA: 0x004811D0 File Offset: 0x0047F3D0
		private void method_5()
		{
			if (!Information.IsNothing(this.method_3()) && Client.smethod_0().method_1() != Class279.Enum67.const_2)
			{
				this.vmethod_24().Visible = this.method_3().bool_12;
				this.vmethod_24().Enabled = false;
				this.vmethod_16().Enabled = !this.method_3().bool_12;
				this.vmethod_14().Enabled = !this.method_3().bool_12;
				this.vmethod_10().Enabled = !this.method_3().bool_12;
				this.vmethod_8().Enabled = !this.method_3().bool_12;
				this.vmethod_6().Enabled = !this.method_3().bool_12;
				this.vmethod_24().Checked = this.method_3().bool_12;
				this.vmethod_4().Enabled = !this.method_3().bool_12;
				this.vmethod_20().Enabled = !this.method_3().bool_12;
				this.vmethod_22().Enabled = !this.method_3().bool_12;
			}
		}

		// Token: 0x0600866F RID: 34415 RVA: 0x00481300 File Offset: 0x0047F500
		private void method_6()
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("ID", typeof(string));
			dataTable.Columns.Add("Description", typeof(string));
			dataTable.Columns.Add("IsActive", typeof(bool));
			try
			{
				foreach (NoNavZone noNavZone in Client.smethod_50().list_7)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["ID"] = noNavZone.string_0;
					dataRow["Description"] = noNavZone.string_2;
					dataRow["IsActive"] = noNavZone.bool_11;
					dataTable.Rows.Add(dataRow);
				}
			}
			finally
			{
				List<NoNavZone>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.vmethod_0().DataSource = dataTable;
		}

		// Token: 0x06008670 RID: 34416 RVA: 0x00051156 File Offset: 0x0004F356
		private void method_7(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.method_3()))
			{
				this.method_3().string_2 = this.vmethod_16().Text;
				this.method_6();
			}
		}

		// Token: 0x06008671 RID: 34417 RVA: 0x00051181 File Offset: 0x0004F381
		private void method_8(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.method_3()))
			{
				Client.smethod_50().list_7.Remove(this.method_3());
				this.method_4(null);
				this.method_6();
			}
		}

		// Token: 0x06008672 RID: 34418 RVA: 0x00481400 File Offset: 0x0047F600
		private void method_9(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				int num = this.vmethod_0().Rows.IndexOf(this.vmethod_0().SelectedRows[0]);
				if (num != -1)
				{
					this.method_4(Client.smethod_50().list_7[num]);
				}
			}
		}

		// Token: 0x06008673 RID: 34419 RVA: 0x0048145C File Offset: 0x0047F65C
		private void method_10()
		{
			if (Information.IsNothing(this.method_3()))
			{
				if (Client.smethod_50().list_7.Count <= 0)
				{
					return;
				}
				this.method_4(Client.smethod_50().list_7[0]);
			}
			this.method_3().vmethod_4().Clear();
			if (this.vmethod_14().Checked)
			{
				this.method_3().vmethod_4().method_4(GlobalVariables.ActiveUnitType.Aircraft);
			}
			if (this.vmethod_10().Checked)
			{
				this.method_3().vmethod_4().method_4(GlobalVariables.ActiveUnitType.Ship);
			}
			if (this.vmethod_8().Checked)
			{
				this.method_3().vmethod_4().method_4(GlobalVariables.ActiveUnitType.Submarine);
			}
			if (this.vmethod_6().Checked)
			{
				this.method_3().vmethod_4().method_4(GlobalVariables.ActiveUnitType.Facility);
			}
		}

		// Token: 0x06008674 RID: 34420 RVA: 0x0048152C File Offset: 0x0047F72C
		private void NoNavZonesWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.method_6();
			if (Client.smethod_50().list_7.Count > 0 && Information.IsNothing(this.method_3()))
			{
				this.method_4(Client.smethod_50().list_7[0]);
			}
		}

		// Token: 0x06008675 RID: 34421 RVA: 0x000511B3 File Offset: 0x0004F3B3
		private void method_11(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.method_3()))
			{
				this.method_3().bool_12 = this.vmethod_24().Checked;
			}
		}

		// Token: 0x06008676 RID: 34422 RVA: 0x000511D8 File Offset: 0x0004F3D8
		private void method_12(object sender, MouseEventArgs e)
		{
			this.method_10();
		}

		// Token: 0x06008677 RID: 34423 RVA: 0x000511D8 File Offset: 0x0004F3D8
		private void method_13(object sender, MouseEventArgs e)
		{
			this.method_10();
		}

		// Token: 0x06008678 RID: 34424 RVA: 0x000511D8 File Offset: 0x0004F3D8
		private void method_14(object sender, MouseEventArgs e)
		{
			this.method_10();
		}

		// Token: 0x06008679 RID: 34425 RVA: 0x000511D8 File Offset: 0x0004F3D8
		private void method_15(object sender, MouseEventArgs e)
		{
			this.method_10();
		}

		// Token: 0x0600867A RID: 34426 RVA: 0x003B6260 File Offset: 0x003B4460
		private void NoNavZonesWindow_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x0600867B RID: 34427 RVA: 0x00481588 File Offset: 0x0047F788
		private void method_16(object sender, EventArgs e)
		{
			this.vmethod_41(new SaveFileDialog());
			this.vmethod_40().InitialDirectory = GameGeneral.string_4;
			if (this.vmethod_40().ShowDialog() == DialogResult.OK)
			{
				try
				{
					FileStream fileStream = File.Create(this.vmethod_40().FileName);
					XmlWriterSettings settings = new XmlWriterSettings();
					MemoryStream memoryStream = new MemoryStream();
					using (XmlWriter xmlWriter = XmlWriter.Create(memoryStream, settings))
					{
						xmlWriter.WriteStartElement("NoNavZone");
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
						xmlWriter.WriteElementString("AffectedUnitTypes", string.Join("_", Enumerable.Select<GlobalVariables.ActiveUnitType, string>(this.method_3().vmethod_4(), (NoNavZonesWindow._Closure$__.$I106-0 == null) ? (NoNavZonesWindow._Closure$__.$I106-0 = new Func<GlobalVariables.ActiveUnitType, string>(NoNavZonesWindow._Closure$__.$I.method_0)) : NoNavZonesWindow._Closure$__.$I106-0)));
						xmlWriter.WriteElementString("IsLocked", this.method_3().bool_12.ToString());
						xmlWriter.WriteEndElement();
					}
					fileStream.Write(memoryStream.ToArray(), 0, (int)memoryStream.Position);
					fileStream.Close();
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101279", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				Client.bool_1 = true;
			}
		}

		// Token: 0x0600867C RID: 34428 RVA: 0x00481784 File Offset: 0x0047F984
		private void method_17(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.method_3()))
			{
				DarkMessageBox.smethod_2("Please select a No Navigation Zone.", "No zone selected", Enum11.const_0);
				return;
			}
			this.vmethod_39(new OpenFileDialog());
			this.vmethod_38().InitialDirectory = GameGeneral.string_4;
			if (this.vmethod_38().ShowDialog() == DialogResult.OK)
			{
				FileStream fileStream = new FileStream(this.vmethod_38().FileName, FileMode.Open, FileAccess.Read);
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
							DarkMessageBox.smethod_2("File is improperly formatted, read failed!", "Read error", Enum11.const_0);
						}
					}
					NoNavZone noNavZone = this.method_3();
					bool flag = true;
					XmlNode xmlNode = xmlDocument.SelectSingleNode("/NoNavZone");
					if (Information.IsNothing(xmlNode))
					{
						xmlNode = xmlDocument.SelectSingleNode("/ExclusionZone");
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
											noNavZone.vmethod_5(new ObservableList<GlobalVariables.ActiveUnitType>());
											foreach (string text in xmlNode2.InnerText.Split(new char[]
											{
												'_'
											}))
											{
												if (Versioned.IsNumeric(text))
												{
													int num = Conversions.ToInteger(text);
													noNavZone.vmethod_4().method_4((GlobalVariables.ActiveUnitType)num);
												}
											}
											continue;
										}
										if (Operators.CompareString(name, "IsLocked", false) == 0)
										{
											noNavZone.bool_12 = Conversions.ToBoolean(xmlNode2.InnerText);
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
												noNavZone.list_0.Add(referencePoint);
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
								noNavZone.string_2 = xmlNode2.InnerText;
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
						if (Information.IsNothing(noNavZone.vmethod_4()))
						{
							Zone zone = noNavZone;
							ObservableList<GlobalVariables.ActiveUnitType> observableList = new ObservableList<GlobalVariables.ActiveUnitType>();
							observableList.method_4(GlobalVariables.ActiveUnitType.Aircraft);
							observableList.method_4(GlobalVariables.ActiveUnitType.Ship);
							observableList.method_4(GlobalVariables.ActiveUnitType.Submarine);
							observableList.method_4(GlobalVariables.ActiveUnitType.Facility);
							zone.vmethod_5(observableList);
						}
						this.vmethod_4().imethod_0();
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
							List<NoNavZone>.Enumerator enumerator3 = side.list_7.GetEnumerator();
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
							List<NoNavZone>.Enumerator enumerator3;
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
					ex2.Data.Add("Error at 101278", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				Client.bool_1 = true;
			}
		}

		// Token: 0x0600867D RID: 34429 RVA: 0x00481BE4 File Offset: 0x0047FDE4
		private void method_18(object sender, EventArgs e)
		{
			bool flag = false;
			flag = this.vmethod_36().Checked;
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
						List<NoNavZone>.Enumerator enumerator = side.list_7.GetEnumerator();
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
						List<NoNavZone>.Enumerator enumerator;
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

		// Token: 0x0600867E RID: 34430 RVA: 0x00481D04 File Offset: 0x0047FF04
		private void method_19(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1 && Operators.CompareString(this.vmethod_0().Columns[e.ColumnIndex].Name, "Active", false) == 0)
			{
				DataGridViewCheckBoxCell dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)this.vmethod_0()[e.ColumnIndex, e.RowIndex];
				NoNavZone noNavZone = null;
				string right = Conversions.ToString(this.vmethod_0().Rows[e.RowIndex].Cells["ID"].Value);
				try
				{
					foreach (NoNavZone noNavZone2 in Client.smethod_50().list_7)
					{
						if (Operators.CompareString(noNavZone2.string_0, right, false) == 0)
						{
							noNavZone = noNavZone2;
							break;
						}
					}
				}
				finally
				{
					List<NoNavZone>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (!Information.IsNothing(noNavZone))
				{
					if (noNavZone.bool_11)
					{
						dataGridViewCheckBoxCell.Value = false;
						noNavZone.bool_11 = false;
					}
					else
					{
						dataGridViewCheckBoxCell.Value = true;
						noNavZone.bool_11 = true;
					}
					Client.bool_1 = true;
					this.method_6();
				}
			}
		}

		// Token: 0x04004939 RID: 18745
		[CompilerGenerated]
		[AccessedThroughProperty("DataGridView1")]
		private Class114 class114_0;

		// Token: 0x0400493A RID: 18746
		[CompilerGenerated]
		[AccessedThroughProperty("Label4")]
		private Class116 class116_0;

		// Token: 0x0400493B RID: 18747
		[CompilerGenerated]
		[AccessedThroughProperty("AreaEditor1")]
		private AreaEditor areaEditor_0;

		// Token: 0x0400493C RID: 18748
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Facility")]
		private Class112 class112_0;

		// Token: 0x0400493D RID: 18749
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Submarine")]
		private Class112 class112_1;

		// Token: 0x0400493E RID: 18750
		[AccessedThroughProperty("CB_Ship")]
		[CompilerGenerated]
		private Class112 class112_2;

		// Token: 0x0400493F RID: 18751
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Class116 class116_1;

		// Token: 0x04004940 RID: 18752
		[AccessedThroughProperty("CB_Aircraft")]
		[CompilerGenerated]
		private Class112 class112_3;

		// Token: 0x04004941 RID: 18753
		[AccessedThroughProperty("TB_Description")]
		[CompilerGenerated]
		private Control8 control8_0;

		// Token: 0x04004942 RID: 18754
		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Class116 class116_2;

		// Token: 0x04004943 RID: 18755
		[CompilerGenerated]
		[AccessedThroughProperty("Button_SetDescription")]
		private Control9 control9_0;

		// Token: 0x04004944 RID: 18756
		[AccessedThroughProperty("Button2")]
		[CompilerGenerated]
		private Control9 control9_1;

		// Token: 0x04004945 RID: 18757
		[AccessedThroughProperty("CB_IsLocked")]
		[CompilerGenerated]
		private Class112 class112_4;

		// Token: 0x04004946 RID: 18758
		[CompilerGenerated]
		[AccessedThroughProperty("ExportZone")]
		private Control9 control9_2;

		// Token: 0x04004947 RID: 18759
		[CompilerGenerated]
		[AccessedThroughProperty("ImportZone")]
		private Control9 control9_3;

		// Token: 0x04004948 RID: 18760
		[AccessedThroughProperty("ID")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04004949 RID: 18761
		[CompilerGenerated]
		[AccessedThroughProperty("Description")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x0400494A RID: 18762
		[AccessedThroughProperty("Active")]
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x0400494B RID: 18763
		[AccessedThroughProperty("CB_VisibleRP")]
		[CompilerGenerated]
		private Class112 class112_5;

		// Token: 0x0400494C RID: 18764
		private NoNavZone noNavZone_0;

		// Token: 0x0400494D RID: 18765
		[AccessedThroughProperty("FD_LoadNoNavZone")]
		[CompilerGenerated]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x0400494E RID: 18766
		[CompilerGenerated]
		[AccessedThroughProperty("FD_ExportNoNavZone")]
		private SaveFileDialog saveFileDialog_0;
	}
}
