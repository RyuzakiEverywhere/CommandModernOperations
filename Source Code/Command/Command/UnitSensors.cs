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
using ns4;
using ns5;

namespace Command
{
	// Token: 0x02000F1E RID: 3870
	[DesignerGenerated]
	public sealed partial class UnitSensors : DarkSecondaryFormBase, Interface66
	{
		// Token: 0x06008A5B RID: 35419 RVA: 0x004A75A0 File Offset: 0x004A57A0
		public UnitSensors()
		{
			base.FormClosing += this.UnitSensors_FormClosing;
			base.Load += this.UnitSensors_Load;
			base.Shown += this.UnitSensors_Shown;
			base.SizeChanged += this.UnitSensors_SizeChanged;
			base.KeyDown += this.UnitSensors_KeyDown;
			base.FormClosed += this.UnitSensors_FormClosed;
			this.dataTable_0 = new DataTable();
			this.list_0 = new List<Sensor>();
			this.list_1 = new List<Sensor>();
			this.list_2 = new List<Sensor>();
			this.InitializeComponent_1();
		}

		// Token: 0x06008A5D RID: 35421 RVA: 0x004A7654 File Offset: 0x004A5854
		private void InitializeComponent_1()
		{
			this.icontainer_1 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(UnitSensors));
			this.vmethod_17(new Timer(this.icontainer_1));
			this.vmethod_19(new Class114());
			this.vmethod_21(new DataGridViewTextBoxColumn());
			this.vmethod_23(new DataGridViewTextBoxColumn());
			this.vmethod_25(new DataGridViewTextBoxColumn());
			this.vmethod_27(new DataGridViewCheckBoxColumn());
			this.vmethod_29(new DataGridViewTextBoxColumn());
			this.vmethod_11(new Class125());
			this.vmethod_13(new ToolStripButton());
			this.vmethod_15(new ToolStripButton());
			this.vmethod_9(new Class116());
			this.vmethod_3(new Class112());
			this.vmethod_5(new Class112());
			this.vmethod_7(new Class112());
			this.vmethod_1(new Class112());
			((ISupportInitialize)this.vmethod_18()).BeginInit();
			this.vmethod_10().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_18().AllowUserToAddRows = false;
			this.vmethod_18().AllowUserToDeleteRows = false;
			this.vmethod_18().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_18().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.vmethod_18().AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.vmethod_18().BackgroundColor = Color.FromArgb(60, 63, 65);
			this.vmethod_18().BorderStyle = BorderStyle.Fixed3D;
			this.vmethod_18().CausesValidation = false;
			this.vmethod_18().CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.vmethod_18().ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.FromArgb(66, 77, 95);
			dataGridViewCellStyle.Font = new Font(Client.font_1.FontFamily, 8f);
			dataGridViewCellStyle.ForeColor = Color.LightGray;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle.SelectionForeColor = Color.FromArgb(122, 128, 132);
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_18().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_18().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_18().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_20(),
				this.vmethod_22(),
				this.vmethod_24(),
				this.vmethod_26(),
				this.vmethod_28()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle2.Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.LightGray;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 110, 175);
			dataGridViewCellStyle2.SelectionForeColor = Color.LightGray;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_18().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_18().EnableHeadersVisualStyles = false;
			this.vmethod_18().Location = new Point(0, 50);
			this.vmethod_18().MultiSelect = false;
			this.vmethod_18().Name = "DGV_Sensors";
			this.vmethod_18().RowHeadersVisible = false;
			this.vmethod_18().RowHeadersWidth = 4;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.ForeColor = Color.LightGray;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(60, 63, 65);
			dataGridViewCellStyle3.SelectionForeColor = Color.LightGray;
			this.vmethod_18().RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_18().RowTemplate.Height = 20;
			this.vmethod_18().RowTemplate.Resizable = DataGridViewTriState.False;
			this.vmethod_18().ScrollBars = ScrollBars.Vertical;
			this.vmethod_18().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_18().Size = new Size(681, 263);
			this.vmethod_18().TabIndex = 8;
			this.vmethod_20().DataPropertyName = "ObjectID";
			this.vmethod_20().HeaderText = "ObjectID";
			this.vmethod_20().Name = "ObjectID";
			this.vmethod_20().ReadOnly = true;
			this.vmethod_20().Visible = false;
			this.vmethod_22().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_22().DataPropertyName = "Sensor";
			this.vmethod_22().FillWeight = 92.72417f;
			this.vmethod_22().HeaderText = "Sensor";
			this.vmethod_22().Name = "SensorColumn";
			this.vmethod_22().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_24().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_24().DataPropertyName = "SensorType";
			this.vmethod_24().FillWeight = 92.72417f;
			this.vmethod_24().HeaderText = "Sensor Type";
			this.vmethod_24().Name = "SensorType";
			this.vmethod_24().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_26().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_26().DataPropertyName = "Active";
			this.vmethod_26().FillWeight = 121.8274f;
			this.vmethod_26().HeaderText = "Active";
			this.vmethod_26().MinimumWidth = 60;
			this.vmethod_26().Name = "Active";
			this.vmethod_26().Width = 60;
			this.vmethod_28().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_28().DataPropertyName = "Status";
			this.vmethod_28().FillWeight = 92.72417f;
			this.vmethod_28().HeaderText = "Status";
			this.vmethod_28().Name = "Status";
			this.vmethod_28().Resizable = DataGridViewTriState.True;
			this.vmethod_28().SortMode = DataGridViewColumnSortMode.NotSortable;
			this.vmethod_10().AutoSize = false;
			this.vmethod_10().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_10().Dock = DockStyle.Bottom;
			this.vmethod_10().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_10().GripStyle = ToolStripGripStyle.Hidden;
			this.vmethod_10().Items.AddRange(new ToolStripItem[]
			{
				this.vmethod_12(),
				this.vmethod_14()
			});
			this.vmethod_10().Location = new Point(0, 313);
			this.vmethod_10().Name = "TS_Edit";
			this.vmethod_10().Padding = new Padding(5, 0, 1, 0);
			this.vmethod_10().Size = new Size(681, 25);
			this.vmethod_10().TabIndex = 14;
			this.vmethod_10().Text = "ToolStrip1";
			this.vmethod_12().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_12().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_12().Image = (Image)componentResourceManager.GetObject("TSB_AddSensor.Image");
			this.vmethod_12().ImageTransparentColor = Color.Magenta;
			this.vmethod_12().Name = "TSB_AddSensor";
			this.vmethod_12().Size = new Size(87, 22);
			this.vmethod_12().Text = "Add Sensor";
			this.vmethod_14().BackColor = Color.FromArgb(60, 63, 65);
			this.vmethod_14().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_14().Image = (Image)componentResourceManager.GetObject("TSB_RemoveSensor.Image");
			this.vmethod_14().ImageTransparentColor = Color.Magenta;
			this.vmethod_14().Name = "TSB_RemoveSensor";
			this.vmethod_14().Size = new Size(108, 22);
			this.vmethod_14().Text = "Remove Sensor";
			this.vmethod_8().Font = new Font(Client.font_1.FontFamily, 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.vmethod_8().ForeColor = Color.FromArgb(220, 220, 220);
			this.vmethod_8().Location = new Point(3, 27);
			this.vmethod_8().Name = "Label1";
			this.vmethod_8().Size = new Size(99, 13);
			this.vmethod_8().TabIndex = 13;
			this.vmethod_8().Text = "Quick selection:";
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().CheckAlign = ContentAlignment.BottomRight;
			this.vmethod_2().Location = new Point(279, 26);
			this.vmethod_2().Name = "CB_ECM";
			this.vmethod_2().RightToLeft = RightToLeft.Yes;
			this.vmethod_2().Size = new Size(97, 17);
			this.vmethod_2().TabIndex = 12;
			this.vmethod_2().Text = "Offensive ECM";
			this.vmethod_4().AutoSize = true;
			this.vmethod_4().CheckAlign = ContentAlignment.BottomRight;
			this.vmethod_4().Location = new Point(116, 26);
			this.vmethod_4().Name = "CB_radar";
			this.vmethod_4().RightToLeft = RightToLeft.Yes;
			this.vmethod_4().Size = new Size(60, 17);
			this.vmethod_4().TabIndex = 10;
			this.vmethod_4().Text = "Radars";
			this.vmethod_6().AutoSize = true;
			this.vmethod_6().CheckAlign = ContentAlignment.BottomRight;
			this.vmethod_6().Location = new Point(200, 26);
			this.vmethod_6().Name = "CB_Sonar";
			this.vmethod_6().RightToLeft = RightToLeft.Yes;
			this.vmethod_6().Size = new Size(59, 17);
			this.vmethod_6().TabIndex = 11;
			this.vmethod_6().Text = "Sonars";
			this.vmethod_0().Location = new Point(3, 2);
			this.vmethod_0().Name = "CB_ObeyEMCON";
			this.vmethod_0().Size = new Size(300, 17);
			this.vmethod_0().TabIndex = 9;
			this.vmethod_0().Text = "Unit obeys EMCON (disables manual sensor control)";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.None;
			this.AutoSize = true;
			base.ClientSize = new Size(681, 338);
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_0());
			this.DoubleBuffered = true;
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "UnitSensors";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Sensors for: ";
			((ISupportInitialize)this.vmethod_18()).EndInit();
			this.vmethod_10().ResumeLayout(false);
			this.vmethod_10().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06008A5E RID: 35422 RVA: 0x00052CFB File Offset: 0x00050EFB
		[CompilerGenerated]
		internal Class112 vmethod_0()
		{
			return this.class112_0;
		}

		// Token: 0x06008A5F RID: 35423 RVA: 0x004A8180 File Offset: 0x004A6380
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Class112 class112_4)
		{
			EventHandler value = new EventHandler(this.method_21);
			Class112 @class = this.class112_0;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_0 = class112_4;
			@class = this.class112_0;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008A60 RID: 35424 RVA: 0x00052D03 File Offset: 0x00050F03
		[CompilerGenerated]
		internal Class112 vmethod_2()
		{
			return this.class112_1;
		}

		// Token: 0x06008A61 RID: 35425 RVA: 0x004A81C4 File Offset: 0x004A63C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Class112 class112_4)
		{
			EventHandler value = new EventHandler(this.method_15);
			Class112 @class = this.class112_1;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_1 = class112_4;
			@class = this.class112_1;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008A62 RID: 35426 RVA: 0x00052D0B File Offset: 0x00050F0B
		[CompilerGenerated]
		internal Class112 vmethod_4()
		{
			return this.class112_2;
		}

		// Token: 0x06008A63 RID: 35427 RVA: 0x004A8208 File Offset: 0x004A6408
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Class112 class112_4)
		{
			EventHandler value = new EventHandler(this.method_13);
			Class112 @class = this.class112_2;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_2 = class112_4;
			@class = this.class112_2;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008A64 RID: 35428 RVA: 0x00052D13 File Offset: 0x00050F13
		[CompilerGenerated]
		internal Class112 vmethod_6()
		{
			return this.class112_3;
		}

		// Token: 0x06008A65 RID: 35429 RVA: 0x004A824C File Offset: 0x004A644C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Class112 class112_4)
		{
			EventHandler value = new EventHandler(this.method_14);
			Class112 @class = this.class112_3;
			if (@class != null)
			{
				@class.Click -= value;
			}
			this.class112_3 = class112_4;
			@class = this.class112_3;
			if (@class != null)
			{
				@class.Click += value;
			}
		}

		// Token: 0x06008A66 RID: 35430 RVA: 0x00052D1B File Offset: 0x00050F1B
		[CompilerGenerated]
		internal Class116 vmethod_8()
		{
			return this.class116_0;
		}

		// Token: 0x06008A67 RID: 35431 RVA: 0x00052D23 File Offset: 0x00050F23
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Class116 class116_1)
		{
			this.class116_0 = class116_1;
		}

		// Token: 0x06008A68 RID: 35432 RVA: 0x00052D2C File Offset: 0x00050F2C
		[CompilerGenerated]
		internal Class125 vmethod_10()
		{
			return this.class125_0;
		}

		// Token: 0x06008A69 RID: 35433 RVA: 0x00052D34 File Offset: 0x00050F34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Class125 class125_1)
		{
			this.class125_0 = class125_1;
		}

		// Token: 0x06008A6A RID: 35434 RVA: 0x00052D3D File Offset: 0x00050F3D
		[CompilerGenerated]
		internal ToolStripButton vmethod_12()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06008A6B RID: 35435 RVA: 0x004A8290 File Offset: 0x004A6490
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(ToolStripButton toolStripButton_2)
		{
			EventHandler value = new EventHandler(this.method_16);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_2;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008A6C RID: 35436 RVA: 0x00052D45 File Offset: 0x00050F45
		[CompilerGenerated]
		internal ToolStripButton vmethod_14()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x06008A6D RID: 35437 RVA: 0x004A82D4 File Offset: 0x004A64D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ToolStripButton toolStripButton_2)
		{
			EventHandler value = new EventHandler(this.method_20);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_2;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06008A6E RID: 35438 RVA: 0x00052D4D File Offset: 0x00050F4D
		[CompilerGenerated]
		internal Timer vmethod_16()
		{
			return this.timer_0;
		}

		// Token: 0x06008A6F RID: 35439 RVA: 0x004A8318 File Offset: 0x004A6518
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_22);
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

		// Token: 0x06008A70 RID: 35440 RVA: 0x00052D55 File Offset: 0x00050F55
		[CompilerGenerated]
		internal Class114 vmethod_18()
		{
			return this.class114_0;
		}

		// Token: 0x06008A71 RID: 35441 RVA: 0x004A835C File Offset: 0x004A655C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Class114 class114_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_8);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_9);
			DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.method_10);
			DataGridViewCellPaintingEventHandler value4 = new DataGridViewCellPaintingEventHandler(this.method_17);
			EventHandler value5 = new EventHandler(this.method_18);
			EventHandler value6 = new EventHandler(this.method_19);
			Class114 @class = this.class114_0;
			if (@class != null)
			{
				@class.CellClick -= value;
				@class.CellContentClick -= value2;
				@class.CellContentDoubleClick -= value3;
				@class.CellPainting -= value4;
				@class.ReadOnlyChanged -= value5;
				@class.SelectionChanged -= value6;
			}
			this.class114_0 = class114_1;
			@class = this.class114_0;
			if (@class != null)
			{
				@class.CellClick += value;
				@class.CellContentClick += value2;
				@class.CellContentDoubleClick += value3;
				@class.CellPainting += value4;
				@class.ReadOnlyChanged += value5;
				@class.SelectionChanged += value6;
			}
		}

		// Token: 0x06008A72 RID: 35442 RVA: 0x00052D5D File Offset: 0x00050F5D
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_20()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06008A73 RID: 35443 RVA: 0x00052D65 File Offset: 0x00050F65
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06008A74 RID: 35444 RVA: 0x00052D6E File Offset: 0x00050F6E
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_22()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06008A75 RID: 35445 RVA: 0x00052D76 File Offset: 0x00050F76
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06008A76 RID: 35446 RVA: 0x00052D7F File Offset: 0x00050F7F
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_24()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06008A77 RID: 35447 RVA: 0x00052D87 File Offset: 0x00050F87
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06008A78 RID: 35448 RVA: 0x00052D90 File Offset: 0x00050F90
		[CompilerGenerated]
		internal DataGridViewCheckBoxColumn vmethod_26()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x06008A79 RID: 35449 RVA: 0x00052D98 File Offset: 0x00050F98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x06008A7A RID: 35450 RVA: 0x00052DA1 File Offset: 0x00050FA1
		[CompilerGenerated]
		internal DataGridViewTextBoxColumn vmethod_28()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06008A7B RID: 35451 RVA: 0x00052DA9 File Offset: 0x00050FA9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06008A7C RID: 35452 RVA: 0x00052DB2 File Offset: 0x00050FB2
		private void UnitSensors_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2413.smethod_2().method_41().BringToFront();
			if (Class2413.smethod_2().method_3().Visible)
			{
				Class2413.smethod_2().method_3().Close();
			}
		}

		// Token: 0x06008A7D RID: 35453 RVA: 0x004A843C File Offset: 0x004A663C
		private void UnitSensors_Load(object sender, EventArgs e)
		{
			Doctrine.smethod_2(new Doctrine.Delegate29(this.method_3));
			if (Client.float_1 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (Client.smethod_54().bool_0)
			{
				this.activeUnit_0 = (ActiveUnit)Client.smethod_54();
			}
			this.Text = "Sensors for: " + Client.smethod_54().Name;
			Client.smethod_14(new Client.Delegate78(this.method_4));
		}

		// Token: 0x06008A7E RID: 35454 RVA: 0x004A84B4 File Offset: 0x004A66B4
		private void UnitSensors_Shown(object sender, EventArgs e)
		{
			if (!this.vmethod_18().ReadOnly)
			{
				this.vmethod_18().ForeColor = Color.Black;
				this.vmethod_18().RowsDefaultCellStyle.SelectionForeColor = Color.Gray;
			}
			else
			{
				this.vmethod_18().ForeColor = Color.Gray;
				this.vmethod_18().RowsDefaultCellStyle.SelectionForeColor = Color.Gray;
			}
			this.method_5();
			this.method_5();
		}

		// Token: 0x06008A7F RID: 35455 RVA: 0x00052DE3 File Offset: 0x00050FE3
		private void UnitSensors_SizeChanged(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x06008A80 RID: 35456 RVA: 0x004A8528 File Offset: 0x004A6728
		private void method_3(Class310 class310_0, bool? nullable_0, bool bool_4, bool bool_5, bool bool_6, bool bool_7)
		{
			if (!bool_7 && !Information.IsNothing(class310_0) && class310_0.bool_0 && (!bool_4 || class310_0 == Client.smethod_54()) && !Information.IsNothing(nullable_0) && base.Visible && class310_0.bool_0 && class310_0 == this.activeUnit_0)
			{
				this.method_5();
			}
		}

		// Token: 0x06008A81 RID: 35457 RVA: 0x00052DEB File Offset: 0x00050FEB
		private void method_4(Unit unit_0)
		{
			if (base.Visible && !Information.IsNothing(unit_0) && unit_0.bool_0)
			{
				this.activeUnit_0 = (ActiveUnit)unit_0;
				this.method_5();
			}
		}

		// Token: 0x06008A82 RID: 35458 RVA: 0x00052E17 File Offset: 0x00051017
		public void method_5()
		{
			this.method_7();
			this.method_6();
		}

		// Token: 0x06008A83 RID: 35459 RVA: 0x004A8580 File Offset: 0x004A6780
		private void method_6()
		{
			if (!Information.IsNothing(this.activeUnit_0))
			{
				this.list_0.Clear();
				this.list_1.Clear();
				this.list_2.Clear();
				if (this.activeUnit_0.bool_0)
				{
					ActiveUnit activeUnit = this.activeUnit_0;
					foreach (Sensor sensor in activeUnit.vmethod_96())
					{
						if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar)
						{
							this.list_0.Add(sensor);
						}
					}
					IEnumerable<Sensor> enumerable = Enumerable.Where<Sensor>(this.list_0, (UnitSensors._Closure$__.$I78-0 == null) ? (UnitSensors._Closure$__.$I78-0 = new Func<Sensor, bool>(UnitSensors._Closure$__.$I.method_0)) : UnitSensors._Closure$__.$I78-0);
					if (Enumerable.Count<Sensor>(enumerable) == 0)
					{
						this.vmethod_4().Checked = false;
					}
					else if (Enumerable.Count<Sensor>(enumerable) == this.list_0.Count)
					{
						this.vmethod_4().Checked = true;
					}
					else
					{
						this.vmethod_4().CheckState = CheckState.Indeterminate;
					}
					foreach (Sensor sensor2 in activeUnit.vmethod_96())
					{
						if (sensor2.method_74())
						{
							this.list_1.Add(sensor2);
						}
					}
					IEnumerable<Sensor> enumerable2 = Enumerable.Where<Sensor>(this.list_1, (UnitSensors._Closure$__.$I78-1 == null) ? (UnitSensors._Closure$__.$I78-1 = new Func<Sensor, bool>(UnitSensors._Closure$__.$I.method_1)) : UnitSensors._Closure$__.$I78-1);
					if (Enumerable.Count<Sensor>(enumerable2) == 0)
					{
						this.vmethod_6().Checked = false;
					}
					else if (Enumerable.Count<Sensor>(enumerable2) == this.list_1.Count)
					{
						this.vmethod_6().Checked = true;
					}
					else
					{
						this.vmethod_6().CheckState = CheckState.Indeterminate;
					}
					foreach (Sensor sensor3 in activeUnit.vmethod_96())
					{
						if (sensor3.method_72())
						{
							this.list_2.Add(sensor3);
						}
					}
					IEnumerable<Sensor> enumerable3 = Enumerable.Where<Sensor>(this.list_2, (UnitSensors._Closure$__.$I78-2 == null) ? (UnitSensors._Closure$__.$I78-2 = new Func<Sensor, bool>(UnitSensors._Closure$__.$I.method_2)) : UnitSensors._Closure$__.$I78-2);
					if (Enumerable.Count<Sensor>(enumerable3) == 0)
					{
						this.vmethod_2().Checked = false;
						return;
					}
					if (Enumerable.Count<Sensor>(enumerable3) == this.list_2.Count)
					{
						this.vmethod_2().Checked = true;
						return;
					}
					this.vmethod_2().CheckState = CheckState.Indeterminate;
				}
			}
		}

		// Token: 0x06008A84 RID: 35460 RVA: 0x004A87DC File Offset: 0x004A69DC
		public void method_7()
		{
			this.vmethod_10().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			if (!Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.bool_0)
			{
				this.method_11();
				if (!Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.bool_0)
				{
					this.Text = "Sensors for: " + this.activeUnit_0.Name;
					this.vmethod_18().DataSource = this.dataTable_0;
					try
					{
						foreach (object obj in this.vmethod_18().Columns)
						{
							((DataGridViewColumn)obj).SortMode = DataGridViewColumnSortMode.NotSortable;
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
					this.vmethod_18().Columns["CanBeActive"].Visible = false;
					this.vmethod_18().Columns["Order#"].Visible = false;
					this.vmethod_18().Columns["ObjectID"].Visible = false;
					try
					{
						foreach (object obj2 in ((IEnumerable)this.vmethod_18().Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
							if (!this.activeUnit_0.vmethod_96()[Conversions.ToInteger(dataGridViewRow.Cells["Order#"].Value)].method_58())
							{
								dataGridViewRow.ReadOnly = true;
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
					try
					{
						foreach (object obj3 in this.vmethod_18().Columns)
						{
							DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj3;
						}
					}
					finally
					{
						IEnumerator enumerator3;
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
					this.vmethod_18().Columns["Active"].Width = 40;
					this.vmethod_18().Columns["SensorType"].HeaderText = "Sensor Type";
					this.method_12();
					this.vmethod_0().Checked = this.activeUnit_0.vmethod_88().vmethod_3();
					this.vmethod_18().ReadOnly = this.activeUnit_0.vmethod_88().vmethod_3();
				}
			}
		}

		// Token: 0x06008A85 RID: 35461 RVA: 0x004A8A54 File Offset: 0x004A6C54
		public void imethod_0()
		{
			if (!this.bool_3)
			{
				this.bool_3 = true;
				try
				{
					if (Information.IsNothing(this.activeUnit_0))
					{
						this.vmethod_18().Columns.Clear();
					}
					else if (this.activeUnit_0.vmethod_7(false) != Client.smethod_50())
					{
						this.vmethod_18().Columns.Clear();
					}
					this.vmethod_10().Visible = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200107", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				this.bool_3 = false;
			}
		}

		// Token: 0x06008A86 RID: 35462 RVA: 0x004A8B20 File Offset: 0x004A6D20
		private void method_8(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex != -1)
				{
					if (e.ColumnIndex != -1)
					{
						if (!this.vmethod_18().ReadOnly)
						{
							if (this.vmethod_18().Rows.Count != 0)
							{
								DataGridViewRow dataGridViewRow = this.vmethod_18().Rows[e.RowIndex];
								if (this.activeUnit_0.vmethod_96()[e.RowIndex].vmethod_5() == PlatformComponent._ComponentStatus.Destroyed)
								{
									dataGridViewRow.Selected = false;
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200108", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06008A87 RID: 35463 RVA: 0x004A8BF0 File Offset: 0x004A6DF0
		private void method_9(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex != -1)
				{
					if (!this.vmethod_18().ReadOnly)
					{
						if (this.vmethod_18().Rows.Count != 0)
						{
							DataGridViewColumn dataGridViewColumn = this.vmethod_18().Columns[e.ColumnIndex];
							if (this.activeUnit_0.vmethod_96()[e.RowIndex].vmethod_5() == PlatformComponent._ComponentStatus.Operational)
							{
								if (Operators.CompareString(dataGridViewColumn.Name, "Active", false) == 0)
								{
									int num = Conversions.ToInteger(this.vmethod_18().Rows[e.RowIndex].Cells["Order#"].Value);
									if (this.activeUnit_0.vmethod_96()[num].method_58())
									{
										if (!Conversions.ToBoolean(this.vmethod_18().Rows[e.RowIndex].Cells["Active"].Value) && !this.activeUnit_0.vmethod_96()[num].method_43())
										{
											this.activeUnit_0.vmethod_96()[num].method_77();
											this.vmethod_18().Rows[e.RowIndex].Cells["Active"].Value = true;
										}
										else if (Conversions.ToBoolean(this.vmethod_18().Rows[e.RowIndex].Cells["Active"].Value) && this.activeUnit_0.vmethod_96()[num].method_43())
										{
											this.activeUnit_0.vmethod_96()[num].method_78();
											this.vmethod_18().Rows[e.RowIndex].Cells["Active"].Value = false;
										}
										if (this.activeUnit_0.bool_3)
										{
											Sensor[] array = this.activeUnit_0.vmethod_96();
											string right = array[num].string_0;
											for (int i = array.Length - 1; i >= 0; i += -1)
											{
												if (Operators.CompareString(array[i].string_0, right, false) == 0)
												{
													this.vmethod_18().Rows[i].Cells["Active"].Value = RuntimeHelpers.GetObjectValue(this.vmethod_18().Rows[e.RowIndex].Cells["Active"].Value);
												}
											}
										}
										this.method_5();
										Client.bool_1 = true;
										Client.bool_1 = true;
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200109", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06008A88 RID: 35464 RVA: 0x00052E25 File Offset: 0x00051025
		private void method_10(object sender, DataGridViewCellEventArgs e)
		{
			this.method_5();
			Client.bool_1 = true;
			Client.bool_1 = true;
		}

		// Token: 0x06008A89 RID: 35465 RVA: 0x004A8EE8 File Offset: 0x004A70E8
		private void method_11()
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.bool_0)
			{
				this.vmethod_18().DataSource = null;
				this.vmethod_18().Rows.Clear();
				this.dataTable_0.Columns.Clear();
				this.dataTable_0.Rows.Clear();
				this.dataTable_0.Columns.Add("Sensor", typeof(string));
				this.dataTable_0.Columns.Add("SensorType", typeof(string));
				this.dataTable_0.Columns.Add("Active", typeof(bool));
				this.dataTable_0.Columns.Add("Status", typeof(string));
				this.dataTable_0.Columns.Add("ObjectID", typeof(string));
				this.dataTable_0.Columns.Add("Order#", typeof(int));
				this.dataTable_0.Columns.Add("CanBeActive", typeof(bool));
				Sensor[] array = this.activeUnit_0.vmethod_96();
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					Sensor sensor = array[i];
					DataRow dataRow = this.dataTable_0.NewRow();
					dataRow["ObjectID"] = sensor.string_0;
					dataRow["Order#"] = i;
					dataRow["CanBeActive"] = sensor.method_58();
					dataRow["Sensor"] = Misc.smethod_9(sensor.Name);
					dataRow["SensorType"] = sensor.string_2;
					dataRow["Active"] = sensor.method_43();
					if (sensor.vmethod_5() == PlatformComponent._ComponentStatus.Operational && Operators.CompareString(sensor.vmethod_4(), "None", false) != 0)
					{
						dataRow["Status"] = "Not operating (" + sensor.vmethod_4() + ")";
					}
					else
					{
						dataRow["Status"] = sensor.vmethod_5().ToString();
					}
					this.dataTable_0.Rows.Add(dataRow);
				}
			}
		}

		// Token: 0x06008A8A RID: 35466 RVA: 0x004A9150 File Offset: 0x004A7350
		private void method_12()
		{
			int num = this.vmethod_18().Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataGridViewRow dataGridViewRow = this.vmethod_18().Rows[i];
				Sensor sensor = this.activeUnit_0.vmethod_96()[Conversions.ToInteger(dataGridViewRow.Cells["Order#"].Value)];
				if (sensor.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
				{
					dataGridViewRow.DefaultCellStyle.ForeColor = base.method_2(sensor);
					dataGridViewRow.ReadOnly = true;
				}
				else
				{
					dataGridViewRow.DefaultCellStyle.ForeColor = Color.LightGray;
				}
				DataGridViewCell dataGridViewCell = this.vmethod_18().Rows[Conversions.ToInteger(dataGridViewRow.Cells["Order#"].Value)].Cells["Active"];
				if (!sensor.method_58())
				{
					dataGridViewCell.ReadOnly = true;
					dataGridViewCell.Value = false;
				}
			}
		}

		// Token: 0x06008A8B RID: 35467 RVA: 0x004A9248 File Offset: 0x004A7448
		private void method_13(object sender, EventArgs e)
		{
			bool @checked;
			if (@checked = this.vmethod_4().Checked)
			{
				if (!@checked)
				{
					goto IL_A6;
				}
				try
				{
					foreach (Sensor sensor in this.list_0)
					{
						if (!sensor.method_49() && !sensor.method_43())
						{
							sensor.method_77();
						}
					}
					goto IL_A6;
				}
				finally
				{
					List<Sensor>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			try
			{
				foreach (Sensor sensor2 in this.list_0)
				{
					if (!sensor2.method_49() && sensor2.method_43())
					{
						sensor2.method_78();
					}
				}
			}
			finally
			{
				List<Sensor>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			IL_A6:
			this.method_7();
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().method_97().class2424_0.method_0(true);
		}

		// Token: 0x06008A8C RID: 35468 RVA: 0x004A9340 File Offset: 0x004A7540
		private void method_14(object sender, EventArgs e)
		{
			bool @checked;
			if (@checked = this.vmethod_6().Checked)
			{
				if (!@checked)
				{
					goto IL_B0;
				}
				try
				{
					foreach (Sensor sensor in this.list_1)
					{
						if (!sensor.method_49() && (!sensor.method_43() & sensor.method_58()))
						{
							sensor.method_77();
						}
					}
					goto IL_B0;
				}
				finally
				{
					List<Sensor>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			try
			{
				foreach (Sensor sensor2 in this.list_1)
				{
					if (!sensor2.method_49() && sensor2.method_43())
					{
						sensor2.method_78();
					}
				}
			}
			finally
			{
				List<Sensor>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			IL_B0:
			this.method_7();
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().method_97().class2424_0.method_0(true);
		}

		// Token: 0x06008A8D RID: 35469 RVA: 0x004A9440 File Offset: 0x004A7640
		private void method_15(object sender, EventArgs e)
		{
			bool @checked;
			if (@checked = this.vmethod_2().Checked)
			{
				if (!@checked)
				{
					goto IL_92;
				}
				try
				{
					foreach (Sensor sensor in this.list_2)
					{
						if (!sensor.method_43())
						{
							sensor.method_77();
						}
					}
					goto IL_92;
				}
				finally
				{
					List<Sensor>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			try
			{
				foreach (Sensor sensor2 in this.list_2)
				{
					if (sensor2.method_43())
					{
						sensor2.method_78();
					}
				}
			}
			finally
			{
				List<Sensor>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			IL_92:
			this.method_7();
			Client.bool_1 = true;
			Class2413.smethod_2().method_41().method_97().class2424_0.method_0(true);
		}

		// Token: 0x06008A8E RID: 35470 RVA: 0x00052E39 File Offset: 0x00051039
		private void method_16(object sender, EventArgs e)
		{
			Class2413.smethod_2().method_3().form_0 = this;
			Class2413.smethod_2().method_3().Show();
			Client.bool_1 = true;
		}

		// Token: 0x06008A8F RID: 35471 RVA: 0x004A9524 File Offset: 0x004A7724
		private void method_17(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex > -1 && e.ColumnIndex == this.vmethod_18().Columns.IndexOf(this.vmethod_18().Columns["Active"]))
			{
				if (!Conversions.ToBoolean(this.vmethod_18().Rows[e.RowIndex].Cells["CanBeActive"].Value))
				{
					e.Paint(e.ClipBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);
					e.Handled = true;
					return;
				}
				if (Operators.CompareString(Conversions.ToString(this.vmethod_18().Rows[e.RowIndex].Cells["Status"].Value), "Damaged", false) == 0 || Operators.CompareString(Conversions.ToString(this.vmethod_18().Rows[e.RowIndex].Cells["Status"].Value), "Destroyed", false) == 0)
				{
					e.Paint(e.ClipBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);
					e.Handled = true;
				}
			}
		}

		// Token: 0x06008A90 RID: 35472 RVA: 0x004A9640 File Offset: 0x004A7840
		private void method_18(object sender, EventArgs e)
		{
			if (!this.vmethod_18().ReadOnly)
			{
				this.vmethod_18().ForeColor = Color.Black;
				this.vmethod_18().RowsDefaultCellStyle.SelectionForeColor = Color.Gray;
				return;
			}
			this.vmethod_18().ForeColor = Color.Gray;
			this.vmethod_18().RowsDefaultCellStyle.SelectionForeColor = Color.Gray;
		}

		// Token: 0x06008A91 RID: 35473 RVA: 0x004A96A8 File Offset: 0x004A78A8
		private void method_19(object sender, EventArgs e)
		{
			if (!this.vmethod_18().ReadOnly && this.vmethod_18().SelectedRows.Count > 0)
			{
				this.string_0 = Conversions.ToString(this.vmethod_18().SelectedRows[0].Cells["ObjectID"].Value);
			}
		}

		// Token: 0x06008A92 RID: 35474 RVA: 0x004A9708 File Offset: 0x004A7908
		private void method_20(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.string_0) && this.activeUnit_0.bool_0)
			{
				ActiveUnit activeUnit = this.activeUnit_0;
				foreach (Sensor sensor in activeUnit.vmethod_96())
				{
					if (Operators.CompareString(sensor.string_0, this.string_0, false) == 0)
					{
						Sensor sensor2 = sensor;
						IL_55:
						if (!Information.IsNothing(sensor2))
						{
							activeUnit.method_127(sensor2);
							this.method_5();
						}
						Client.bool_1 = true;
						return;
					}
				}
				goto IL_55;
			}
		}

		// Token: 0x06008A93 RID: 35475 RVA: 0x004A9788 File Offset: 0x004A7988
		private void method_21(object sender, EventArgs e)
		{
			this.activeUnit_0.vmethod_88().vmethod_4(this.vmethod_0().Checked);
			this.vmethod_18().ReadOnly = this.activeUnit_0.vmethod_88().vmethod_3();
			this.vmethod_4().Enabled = this.vmethod_18().Enabled;
			this.vmethod_6().Enabled = this.vmethod_18().Enabled;
			this.vmethod_2().Enabled = this.vmethod_18().Enabled;
			Class2413.smethod_2().method_41().method_97().class2424_0.method_0(true);
		}

		// Token: 0x06008A94 RID: 35476 RVA: 0x00052E60 File Offset: 0x00051060
		private void method_22(object sender, EventArgs e)
		{
			this.imethod_0();
			this.vmethod_16().Stop();
		}

		// Token: 0x06008A95 RID: 35477 RVA: 0x00493608 File Offset: 0x00491808
		private void UnitSensors_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
				return;
			}
			if (e.KeyCode == Keys.F9 && base.Visible)
			{
				base.Close();
				return;
			}
			if (!base.Visible || (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Space))
			{
				Class2413.smethod_2().method_41().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06008A96 RID: 35478 RVA: 0x00052E73 File Offset: 0x00051073
		private void UnitSensors_FormClosed(object sender, FormClosedEventArgs e)
		{
			Client.smethod_15(new Client.Delegate78(this.method_4));
			Doctrine.smethod_3(new Doctrine.Delegate29(this.method_3));
		}

		// Token: 0x04004B12 RID: 19218
		[CompilerGenerated]
		[AccessedThroughProperty("CB_ObeyEMCON")]
		private Class112 class112_0;

		// Token: 0x04004B13 RID: 19219
		[AccessedThroughProperty("CB_ECM")]
		[CompilerGenerated]
		private Class112 class112_1;

		// Token: 0x04004B14 RID: 19220
		[AccessedThroughProperty("CB_radar")]
		[CompilerGenerated]
		private Class112 class112_2;

		// Token: 0x04004B15 RID: 19221
		[CompilerGenerated]
		[AccessedThroughProperty("CB_Sonar")]
		private Class112 class112_3;

		// Token: 0x04004B16 RID: 19222
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Class116 class116_0;

		// Token: 0x04004B17 RID: 19223
		[CompilerGenerated]
		[AccessedThroughProperty("TS_Edit")]
		private Class125 class125_0;

		// Token: 0x04004B18 RID: 19224
		[AccessedThroughProperty("TSB_AddSensor")]
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04004B19 RID: 19225
		[CompilerGenerated]
		[AccessedThroughProperty("TSB_RemoveSensor")]
		private ToolStripButton toolStripButton_1;

		// Token: 0x04004B1A RID: 19226
		[CompilerGenerated]
		[AccessedThroughProperty("Timer_Refresh")]
		private Timer timer_0;

		// Token: 0x04004B1B RID: 19227
		[CompilerGenerated]
		[AccessedThroughProperty("DGV_Sensors")]
		private Class114 class114_0;

		// Token: 0x04004B1C RID: 19228
		[AccessedThroughProperty("ObjectID")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04004B1D RID: 19229
		[CompilerGenerated]
		[AccessedThroughProperty("SensorColumn")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04004B1E RID: 19230
		[CompilerGenerated]
		[AccessedThroughProperty("SensorType")]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04004B1F RID: 19231
		[AccessedThroughProperty("Active")]
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x04004B20 RID: 19232
		[AccessedThroughProperty("Status")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04004B21 RID: 19233
		private DataTable dataTable_0;

		// Token: 0x04004B22 RID: 19234
		private List<Sensor> list_0;

		// Token: 0x04004B23 RID: 19235
		private List<Sensor> list_1;

		// Token: 0x04004B24 RID: 19236
		private List<Sensor> list_2;

		// Token: 0x04004B25 RID: 19237
		private bool bool_3;

		// Token: 0x04004B26 RID: 19238
		private string string_0;

		// Token: 0x04004B27 RID: 19239
		private ActiveUnit activeUnit_0;
	}
}
